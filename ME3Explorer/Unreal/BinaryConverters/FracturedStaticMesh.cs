﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ME3Explorer.Packages;
using SharpDX;

namespace ME3Explorer.Unreal.BinaryConverters
{
    public class FracturedStaticMesh : StaticMesh
    {
        public UIndex SourceStaticMesh;
        public FragmentInfo[] Fragments;
        public int CoreFragmentIndex;
        public int InteriorElementIndex;// ME3/UDK
        public Vector3 CoreMeshScale3D;// ME3/UDK
        public Vector3 CoreMeshOffset;// ME3/UDK
        public Rotator CoreMeshRotation;// ME3/UDK
        public Vector3 PlaneBias;// ME3/UDK
        public ushort NonCriticalBuildVersion;// ME3/UDK
        public ushort LicenseeNonCriticalBuildVersion;// ME3/UDK

        protected override void Serialize(SerializingContainer2 sc)
        {
            base.Serialize(sc);
            sc.Serialize(ref SourceStaticMesh);
            sc.Serialize(ref Fragments, SCExt.Serialize);
            sc.Serialize(ref CoreFragmentIndex);
            if (sc.Game >= MEGame.ME3)
            {
                sc.Serialize(ref InteriorElementIndex);
                sc.Serialize(ref CoreMeshScale3D);
                sc.Serialize(ref CoreMeshOffset);
                sc.Serialize(ref CoreMeshRotation);
                sc.Serialize(ref PlaneBias);
                sc.Serialize(ref NonCriticalBuildVersion);
                sc.Serialize(ref LicenseeNonCriticalBuildVersion);
            }
            else if (sc.IsLoading)
            {
                InteriorElementIndex = -1;
                CoreMeshScale3D = new Vector3(1,1,1);
                PlaneBias = new Vector3(1,1,1);
                NonCriticalBuildVersion = 1;
                LicenseeNonCriticalBuildVersion = 1;
            }
        }

        public override List<(UIndex, string)> GetUIndexes(MEGame game)
        {
            List<(UIndex, string)> uIndexes = base.GetUIndexes(game);
            uIndexes.Add((SourceStaticMesh, nameof(SourceStaticMesh)));
            return uIndexes;
        }
    }

    public class FragmentInfo
    {
        public Vector3 Center;
        public ConvexHull ConvexHull;
        public BoxSphereBounds Bounds;
        public byte[] Neighbours; // ME3/UDK
        public bool bCanBeDestroyed;// ME3/UDK
        public bool bRootFragment; // ME3/UDK
        public bool bNeverSpawnPhysicsChunk;// ME3/UDK
        public Vector3 AverageExteriorNormal; // ME3/UDK
        public float[] NeighbourDims;// ME3/UDK
    }

    public class ConvexHull
    {
        public Vector3[] VertexData;
        public Plane[] PermutedVertexData;
        public int[] FaceTriData;
        public Vector3[] EdgeDirections;
        public Vector3[] FaceNormalDirections;
        public Plane[] FacePlaneData;
        public Box ElemBox;
    }
}

namespace ME3Explorer
{
    using Unreal.BinaryConverters;

    public static partial class SCExt
    {
        public static void Serialize(this SerializingContainer2 sc, ref ConvexHull hull)
        {
            if (sc.IsLoading)
            {
                hull = new ConvexHull();
            }
            sc.Serialize(ref hull.VertexData, Serialize);
            sc.Serialize(ref hull.PermutedVertexData, Serialize);
            sc.Serialize(ref hull.FaceTriData, Serialize);
            sc.Serialize(ref hull.EdgeDirections, Serialize);
            sc.Serialize(ref hull.FaceNormalDirections, Serialize);
            sc.Serialize(ref hull.FacePlaneData, Serialize);
            sc.Serialize(ref hull.ElemBox);
        }
        public static void Serialize(this SerializingContainer2 sc, ref FragmentInfo info)
        {
            if (sc.IsLoading)
            {
                info = new FragmentInfo();
            }
            sc.Serialize(ref info.Center);
            sc.Serialize(ref info.ConvexHull);
            sc.Serialize(ref info.Bounds);
            if (sc.Game >= MEGame.ME3)
            {
                sc.Serialize(ref info.Neighbours, Serialize);
                sc.Serialize(ref info.bCanBeDestroyed);
                sc.Serialize(ref info.bRootFragment);
                sc.Serialize(ref info.bNeverSpawnPhysicsChunk);
                sc.Serialize(ref info.AverageExteriorNormal);
                sc.Serialize(ref info.NeighbourDims, Serialize);
            }
            else if (sc.IsLoading)
            {
                info.Neighbours = new byte[info.ConvexHull.FacePlaneData.Length];
                info.bCanBeDestroyed = true;
                info.NeighbourDims = new float[info.Neighbours.Length];
                for (int i = 0; i < info.NeighbourDims.Length; i++)
                {
                    info.NeighbourDims[i] = 1;
                }
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ME3Explorer.Packages;
using StreamHelpers;

namespace ME3Explorer.Unreal.BinaryConverters
{
    public class UState : UStruct
    {
        public uint stateUnk1; //probemask?
        public uint stateUnk2;
        public uint stateUnk3;
        public uint stateUnk4;
        public short stateUnk5;
        public StateFlags StateFlags;
        public OrderedMultiValueDictionary<NameReference, UIndex> LocalFunctionMap;
        protected override void Serialize(SerializingContainer2 sc)
        {
            base.Serialize(sc);
            sc.Serialize(ref stateUnk1);
            sc.Serialize(ref stateUnk2);
            sc.Serialize(ref stateUnk3);
            sc.Serialize(ref stateUnk4);
            sc.Serialize(ref stateUnk5);
            sc.Serialize(ref StateFlags);
            sc.Serialize(ref LocalFunctionMap, SCExt.Serialize, SCExt.Serialize);
        }

        public override List<(UIndex, string)> GetUIndexes(MEGame game)
        {
            List<(UIndex, string)> uIndices = base.GetUIndexes(game);
            uIndices.AddRange(LocalFunctionMap.Select((kvp, i) => (kvp.Value, $"LocalFunctions[{i}]")));
            return uIndices;
        }
        public override List<(NameReference, string)> GetNames(MEGame game)
        {
            var names = base.GetNames(game);

            names.AddRange(LocalFunctionMap.Select((kvp, i) => (kvp.Key, $"LocalFunctions[{i}]")));

            return names;
        }
    }

    [Flags]
    public enum StateFlags : uint
    {
        None = 0,
        Editable = 1,
        Auto = 2,
        Simulated = 4,
    }
}

namespace ME3Explorer
{
    using Unreal.BinaryConverters;

    public static partial class SCExt
    {
        public static void Serialize(this SerializingContainer2 sc, ref StateFlags flags)
        {
            if (sc.IsLoading)
            {
                flags = (StateFlags)sc.ms.ReadUInt32();
            }
            else
            {
                sc.ms.WriteUInt32((uint)flags);
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using ME3Explorer.SharedUI;
using ME3Explorer;
using ME3Explorer.Packages;
using ME3Explorer.Unreal;
using Color = System.Windows.Media.Color;

namespace ME3Explorer.Matinee
{
    public class InterpGroup : NotifyPropertyChangedBase
    {
        public ExportEntry Export { get; }

        public string GroupName { get; set; }

        public Color GroupColor { get; set; } = Color.FromArgb(0, 0, 0, 0);

        public ObservableCollectionExtended<InterpTrack> Tracks { get; } = new ObservableCollectionExtended<InterpTrack>();

        public InterpGroup(ExportEntry export)
        {
            Export = export;
            GroupName = export.GetProperty<NameProperty>("GroupName")?.Value.Instanced ?? export.ObjectName.Instanced;

            if (export.GetProperty<StructProperty>("GroupColor") is StructProperty colorStruct)
            {

                var a = colorStruct.GetProp<ByteProperty>("A").Value;
                var r = colorStruct.GetProp<ByteProperty>("R").Value;
                var g = colorStruct.GetProp<ByteProperty>("G").Value;
                var b = colorStruct.GetProp<ByteProperty>("B").Value;
                GroupColor = Color.FromArgb(a, r, g, b);
            }

            RefreshTracks();
        }

        public void RefreshTracks()
        {
            Tracks.ClearEx();
            var tracksProp = Export.GetProperty<ArrayProperty<ObjectProperty>>("InterpTracks");
            if (tracksProp != null)
            {
                var trackExports = tracksProp.Where(prop => Export.FileRef.IsUExport(prop.Value)).Select(prop => Export.FileRef.GetUExport(prop.Value));
                foreach (ExportEntry trackExport in trackExports)
                {
                    if (trackExport.IsA("BioInterpTrack"))
                    {
                        Tracks.Add(new BioInterpTrack(trackExport));
                    }
                    else if (trackExport.IsA("InterpTrackFloatBase"))
                    {
                        Tracks.Add(new InterpTrackFloatBase(trackExport));
                    }
                    else if (trackExport.IsA("InterpTrackVectorBase"))
                    {
                        Tracks.Add(new InterpTrackVectorBase(trackExport));
                    }
                    else if (trackExport.IsA("InterpTrackEvent"))
                    {
                        Tracks.Add(new InterpTrackEvent(trackExport));
                    }
                    else if (trackExport.IsA("InterpTrackFaceFX"))
                    {
                        Tracks.Add(new InterpTrackFaceFX(trackExport));
                    }
                    else if (trackExport.IsA("InterpTrackAnimControl"))
                    {
                        Tracks.Add(new InterpTrackAnimControl(trackExport));
                    }
                    else if (trackExport.IsA("InterpTrackMove"))
                    {
                        Tracks.Add(new InterpTrackMove(trackExport));
                    }
                    else if (trackExport.IsA("InterpTrackVisibility"))
                    {
                        Tracks.Add(new InterpTrackVisibility(trackExport));
                    }
                    else if (trackExport.IsA("InterpTrackToggle"))
                    {
                        Tracks.Add(new InterpTrackToggle(trackExport));
                    }
                    else if (trackExport.IsA("InterpTrackWwiseEvent"))
                    {
                        Tracks.Add(new InterpTrackWwiseEvent(trackExport));
                    }
                    else if (trackExport.IsA("InterpTrackDirector"))
                    {
                        Tracks.Add(new InterpTrackDirector(trackExport));
                    }
                    else
                    {
                        throw new FormatException($"Unknown Track Type: {trackExport.ClassName}");
                    }
                }
            }
        }
    }

    public abstract class InterpTrack : NotifyPropertyChangedBase
    {
        public ExportEntry Export { get; }

        public string TrackTitle { get; set; }

        public ObservableCollectionExtended<Key> Keys { get; } = new ObservableCollectionExtended<Key>();

        protected InterpTrack(ExportEntry export)
        {
            Export = export;
            TrackTitle = export.GetProperty<StrProperty>("TrackTitle")?.Value ?? export.ObjectName.Instanced;
        }
    }

    public class BioInterpTrack : InterpTrack
    {
        public BioInterpTrack(ExportEntry exp) : base(exp)
        {
            var trackKeys = exp.GetProperty<ArrayProperty<StructProperty>>("m_aTrackKeys");
            if (trackKeys != null)
            {
                foreach (StructProperty bioTrackKey in trackKeys)
                {
                    var fTime = bioTrackKey.GetProp<FloatProperty>("fTime");
                    Keys.Add(new Key(fTime));
                }
            }
        }
    }
    public class InterpTrackFloatBase : InterpTrack
    {
        public InterpTrackFloatBase(ExportEntry export) : base(export)
        {
            var floatTrackProp = export.GetProperty<StructProperty>("FloatTrack");
            if (floatTrackProp != null)
            {
                foreach (var curvePoint in floatTrackProp.GetPropOrDefault<ArrayProperty<StructProperty>>("Points"))
                {
                    Keys.Add(new Key(curvePoint.GetProp<FloatProperty>("InVal")));
                }
            }
        }
    }
    public class InterpTrackVectorBase : InterpTrack
    {
        public InterpTrackVectorBase(ExportEntry export) : base(export)
        {
            var vectorTrackProp = export.GetProperty<StructProperty>("VectorTrack");
            if (vectorTrackProp != null)
            {
                foreach (var curvePoint in vectorTrackProp.GetPropOrDefault<ArrayProperty<StructProperty>>("Points"))
                {
                    Keys.Add(new Key(curvePoint.GetProp<FloatProperty>("InVal")));
                }
            }
        }
    }
    public class InterpTrackEvent : InterpTrack
    {
        public InterpTrackEvent(ExportEntry export) : base(export)
        {
            var trackKeys = export.GetProperty<ArrayProperty<StructProperty>>("EventTrack");
            if (trackKeys != null)
            {
                foreach (var trackKey in trackKeys)
                {
                    Keys.Add(new Key(trackKey.GetProp<FloatProperty>("StartTime")));
                }
            }
        }
    }
    public class InterpTrackFaceFX : InterpTrack
    {
        public InterpTrackFaceFX(ExportEntry export) : base(export)
        {
            var trackKeys = export.GetProperty<ArrayProperty<StructProperty>>("FaceFXSeqs");
            if (trackKeys != null)
            {
                foreach (StructProperty trackKey in trackKeys)
                {
                    Keys.Add(new Key(trackKey.GetProp<FloatProperty>("StartTime")));
                }
            }
        }
    }
    public class InterpTrackAnimControl : InterpTrack
    {
        public InterpTrackAnimControl(ExportEntry export) : base(export)
        {
            var trackKeys = export.GetProperty<ArrayProperty<StructProperty>>("AnimSeqs");
            if (trackKeys != null)
            {
                foreach (var trackKey in trackKeys)
                {
                    Keys.Add(new Key(trackKey.GetProp<FloatProperty>("StartTime")));
                }
            }
        }
    }
    public class InterpTrackMove : InterpTrack
    {
        public InterpTrackMove(ExportEntry export) : base(export)
        {
            var lookupstruct = export.GetProperty<StructProperty>("LookupTrack");
            if(lookupstruct != null)
            {
                var trackKeys = lookupstruct.GetProp<ArrayProperty<StructProperty>>("Points");
                if (trackKeys != null)
                {
                    foreach (var trackKey in trackKeys)
                    {
                        Keys.Add(new Key(trackKey.GetProp<FloatProperty>("Time")));
                    }
                }
            }
        }
    }
    public class InterpTrackVisibility : InterpTrack
    {
        public InterpTrackVisibility(ExportEntry export) : base(export)
        {
            var trackKeys = export.GetProperty<ArrayProperty<StructProperty>>("VisibilityTrack");
            if (trackKeys != null)
            {
                foreach (var trackKey in trackKeys)
                {
                    Keys.Add(new Key(trackKey.GetProp<FloatProperty>("Time")));
                }
            }
        }
    }
    public class InterpTrackToggle : InterpTrack
    {
        public InterpTrackToggle(ExportEntry export) : base(export)
        {
            var trackKeys = export.GetProperty<ArrayProperty<StructProperty>>("ToggleTrack");
            if (trackKeys != null)
            {
                foreach (var trackKey in trackKeys)
                {
                    Keys.Add(new Key(trackKey.GetProp<FloatProperty>("Time")));
                }
            }
        }
    }
    public class InterpTrackWwiseEvent : InterpTrack
    {
        public InterpTrackWwiseEvent(ExportEntry export) : base(export)
        {
            var trackKeys = export.GetProperty<ArrayProperty<StructProperty>>("WwiseEvents");
            if (trackKeys != null)
            {
                foreach (var trackKey in trackKeys)
                {
                    Keys.Add(new Key(trackKey.GetProp<FloatProperty>("Time")));
                }
            }
        }
    }
    public class InterpTrackDirector : InterpTrack
    {
        public InterpTrackDirector(ExportEntry export) : base(export)
        {
            var trackKeys = export.GetProperty<ArrayProperty<StructProperty>>("CutTrack");
            if (trackKeys != null)
            {
                foreach (var trackKey in trackKeys)
                {
                    Keys.Add(new Key(trackKey.GetProp<FloatProperty>("Time")));
                }
            }
        }
    }
}

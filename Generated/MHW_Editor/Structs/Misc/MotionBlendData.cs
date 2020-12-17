using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using MHW_Editor.Assets;
using MHW_Editor.Controls.Models;
using MHW_Editor.Models;
using MHW_Editor.Windows;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Structs.Misc {
    public partial class MotionBlendData {
        public override string EncryptionKey => null;

        public partial class Motion_Blend_Data_1_ : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Motion Blend Data (1)";

            protected uint Magic_1_raw;
            public const string Magic_1_displayName = "Magic 1";
            public const int Magic_1_sortIndex = 50;
            [SortOrder(Magic_1_sortIndex)]
            [DisplayName(Magic_1_displayName)]
            [IsReadOnly]
            public virtual uint Magic_1 {
                get => Magic_1_raw;
                set {
                    if (Magic_1_raw == value) return;
                    Magic_1_raw = value;
                    ChangedItems.Add(nameof(Magic_1));
                    OnPropertyChanged(nameof(Magic_1));
                }
            }

            protected uint Magic_2_raw;
            public const string Magic_2_displayName = "Magic 2";
            public const int Magic_2_sortIndex = 100;
            [SortOrder(Magic_2_sortIndex)]
            [DisplayName(Magic_2_displayName)]
            [IsReadOnly]
            public virtual uint Magic_2 {
                get => Magic_2_raw;
                set {
                    if (Magic_2_raw == value) return;
                    Magic_2_raw = value;
                    ChangedItems.Add(nameof(Magic_2));
                    OnPropertyChanged(nameof(Magic_2));
                }
            }

            protected uint Entry_Count_raw;
            public const string Entry_Count_displayName = "Entry Count";
            public const int Entry_Count_sortIndex = 150;
            [SortOrder(Entry_Count_sortIndex)]
            [DisplayName(Entry_Count_displayName)]
            [IsReadOnly]
            public virtual uint Entry_Count {
                get => Entry_Count_raw;
                set {
                    if (Entry_Count_raw == value) return;
                    Entry_Count_raw = value;
                    ChangedItems.Add(nameof(Entry_Count));
                    OnPropertyChanged(nameof(Entry_Count));
                }
            }

            protected uint Unk_1_raw;
            public const string Unk_1_displayName = "Unk 1";
            public const int Unk_1_sortIndex = 200;
            [SortOrder(Unk_1_sortIndex)]
            [DisplayName(Unk_1_displayName)]
            public virtual uint Unk_1 {
                get => Unk_1_raw;
                set {
                    if (Unk_1_raw == value) return;
                    Unk_1_raw = value;
                    ChangedItems.Add(nameof(Unk_1));
                    OnPropertyChanged(nameof(Unk_1));
                }
            }

            public const int lastSortIndex = 250;

            public static ObservableMhwStructCollection<Motion_Blend_Data_1_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Motion_Blend_Data_1_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Motion_Blend_Data_1_ LoadData(BinaryReader reader, ulong i) {
                var data = new Motion_Blend_Data_1_();
                data.Index = i;
                data.Magic_1_raw = reader.ReadUInt32();
                data.Magic_2_raw = reader.ReadUInt32();
                data.Entry_Count_raw = reader.ReadUInt32();
                data.Unk_1_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Magic_1_raw);
                writer.Write(Magic_2_raw);
                writer.Write(Entry_Count_raw);
                writer.Write(Unk_1_raw);
            }
        }

        public partial class Default : MhwStructItem, IWriteData, IHasChildren {
            public const ulong FixedSizeCount = 0;
            public const string GridName = "Default";
            public const bool IsAddingAllowed = true;

            [SortOrder(-1)]
            [IsReadOnly]
            [DisplayName("X")]
            public string Delete => "X";

            protected uint lmt_Offset_Index_raw;
            public const string lmt_Offset_Index_displayName = "lmt Offset Index";
            public const int lmt_Offset_Index_sortIndex = 50;
            [SortOrder(lmt_Offset_Index_sortIndex)]
            [DisplayName(lmt_Offset_Index_displayName)]
            public virtual uint lmt_Offset_Index {
                get => lmt_Offset_Index_raw;
                set {
                    if (lmt_Offset_Index_raw == value) return;
                    lmt_Offset_Index_raw = value;
                    ChangedItems.Add(nameof(lmt_Offset_Index));
                    OnPropertyChanged(nameof(lmt_Offset_Index));
                }
            }

            protected uint Num_of_Values_raw;
            public const string Num_of_Values_displayName = "Num of Values";
            public const int Num_of_Values_sortIndex = 100;
            [SortOrder(Num_of_Values_sortIndex)]
            [DisplayName(Num_of_Values_displayName)]
            [IsReadOnly]
            public virtual uint Num_of_Values {
                get => Num_of_Values_raw;
                set {
                    if (Num_of_Values_raw == value) return;
                    Num_of_Values_raw = value;
                    ChangedItems.Add(nameof(Num_of_Values));
                    OnPropertyChanged(nameof(Num_of_Values));
                }
            }

            protected uint Unk_2_raw;
            public const string Unk_2_displayName = "Unk 2";
            public const int Unk_2_sortIndex = 150;
            [SortOrder(Unk_2_sortIndex)]
            [DisplayName(Unk_2_displayName)]
            public virtual uint Unk_2 {
                get => Unk_2_raw;
                set {
                    if (Unk_2_raw == value) return;
                    Unk_2_raw = value;
                    ChangedItems.Add(nameof(Unk_2));
                    OnPropertyChanged(nameof(Unk_2));
                }
            }

            protected uint Unk_3_raw;
            public const string Unk_3_displayName = "Unk 3";
            public const int Unk_3_sortIndex = 200;
            [SortOrder(Unk_3_sortIndex)]
            [DisplayName(Unk_3_displayName)]
            public virtual uint Unk_3 {
                get => Unk_3_raw;
                set {
                    if (Unk_3_raw == value) return;
                    Unk_3_raw = value;
                    ChangedItems.Add(nameof(Unk_3));
                    OnPropertyChanged(nameof(Unk_3));
                }
            }

            public partial class Unk_Array : MhwStructItem, IWriteDataInner<Default> {
                public const ulong FixedSizeCount = 0;
                public const string GridName = "Unk Array";
                public const bool IsAddingAllowed = true;

                [SortOrder(-1)]
                [IsReadOnly]
                [DisplayName("X")]
                public string Delete => "X";

                protected string Unk_1_raw;
                public const string Unk_1_displayName = "Unk 1";
                public const int Unk_1_sortIndex = 50;
                [SortOrder(Unk_1_sortIndex)]
                [DisplayName(Unk_1_displayName)]
                public virtual string Unk_1 {
                    get => Unk_1_raw;
                    set {
                        if (Unk_1_raw == value) return;
                        Unk_1_raw = value;
                        ChangedItems.Add(nameof(Unk_1));
                        OnPropertyChanged(nameof(Unk_1));
                    }
                }

                protected float Unk_2_raw;
                public const string Unk_2_displayName = "Unk 2";
                public const int Unk_2_sortIndex = 100;
                [SortOrder(Unk_2_sortIndex)]
                [DisplayName(Unk_2_displayName)]
                public virtual float Unk_2 {
                    get => Unk_2_raw;
                    set {
                        if (Unk_2_raw == value) return;
                        Unk_2_raw = value;
                        ChangedItems.Add(nameof(Unk_2));
                        OnPropertyChanged(nameof(Unk_2));
                    }
                }

                protected uint Animation_Start_Frame_raw;
                public const string Animation_Start_Frame_displayName = "Animation Start Frame";
                public const int Animation_Start_Frame_sortIndex = 150;
                [SortOrder(Animation_Start_Frame_sortIndex)]
                [DisplayName(Animation_Start_Frame_displayName)]
                public virtual uint Animation_Start_Frame {
                    get => Animation_Start_Frame_raw;
                    set {
                        if (Animation_Start_Frame_raw == value) return;
                        Animation_Start_Frame_raw = value;
                        ChangedItems.Add(nameof(Animation_Start_Frame));
                        OnPropertyChanged(nameof(Animation_Start_Frame));
                    }
                }

                protected uint Interpolation_raw;
                public const string Interpolation_displayName = "Interpolation";
                public const int Interpolation_sortIndex = 200;
                [SortOrder(Interpolation_sortIndex)]
                [DisplayName(Interpolation_displayName)]
                public virtual uint Interpolation {
                    get => Interpolation_raw;
                    set {
                        if (Interpolation_raw == value) return;
                        Interpolation_raw = value;
                        ChangedItems.Add(nameof(Interpolation));
                        OnPropertyChanged(nameof(Interpolation));
                    }
                }

                protected uint Overlap_Blending_raw;
                public const string Overlap_Blending_displayName = "Overlap Blending";
                public const int Overlap_Blending_sortIndex = 250;
                [SortOrder(Overlap_Blending_sortIndex)]
                [DisplayName(Overlap_Blending_displayName)]
                public virtual uint Overlap_Blending {
                    get => Overlap_Blending_raw;
                    set {
                        if (Overlap_Blending_raw == value) return;
                        Overlap_Blending_raw = value;
                        ChangedItems.Add(nameof(Overlap_Blending));
                        OnPropertyChanged(nameof(Overlap_Blending));
                    }
                }

                protected float Unk_6_raw;
                public const string Unk_6_displayName = "Unk 6";
                public const int Unk_6_sortIndex = 300;
                [SortOrder(Unk_6_sortIndex)]
                [DisplayName(Unk_6_displayName)]
                public virtual float Unk_6 {
                    get => Unk_6_raw;
                    set {
                        if (Unk_6_raw == value) return;
                        Unk_6_raw = value;
                        ChangedItems.Add(nameof(Unk_6));
                        OnPropertyChanged(nameof(Unk_6));
                    }
                }

                protected uint Interpolation_Modifier__raw;
                public const string Interpolation_Modifier__displayName = "Interpolation Modifier?";
                public const int Interpolation_Modifier__sortIndex = 350;
                [SortOrder(Interpolation_Modifier__sortIndex)]
                [DisplayName(Interpolation_Modifier__displayName)]
                public virtual uint Interpolation_Modifier_ {
                    get => Interpolation_Modifier__raw;
                    set {
                        if (Interpolation_Modifier__raw == value) return;
                        Interpolation_Modifier__raw = value;
                        ChangedItems.Add(nameof(Interpolation_Modifier_));
                        OnPropertyChanged(nameof(Interpolation_Modifier_));
                    }
                }

                protected int Unk_8_raw;
                public const string Unk_8_displayName = "Unk 8";
                public const int Unk_8_sortIndex = 400;
                [SortOrder(Unk_8_sortIndex)]
                [DisplayName(Unk_8_displayName)]
                public virtual int Unk_8 {
                    get => Unk_8_raw;
                    set {
                        if (Unk_8_raw == value) return;
                        Unk_8_raw = value;
                        ChangedItems.Add(nameof(Unk_8));
                        OnPropertyChanged(nameof(Unk_8));
                    }
                }

                protected uint Animation_Id_raw;
                public const string Animation_Id_displayName = "Animation Id";
                public const int Animation_Id_sortIndex = 450;
                [SortOrder(Animation_Id_sortIndex)]
                [DisplayName(Animation_Id_displayName)]
                public virtual uint Animation_Id {
                    get => Animation_Id_raw;
                    set {
                        if (Animation_Id_raw == value) return;
                        Animation_Id_raw = value;
                        ChangedItems.Add(nameof(Animation_Id));
                        OnPropertyChanged(nameof(Animation_Id));
                    }
                }

                public const int lastSortIndex = 500;

                public static ObservableMhwStructCollection<Unk_Array> LoadData(BinaryReader reader, Default parent) {
                    var list = new ObservableMhwStructCollection<Unk_Array>();
                    var count = (ulong) parent.Num_of_Values;
                    for (ulong i = 0; i < count; i++) {
                        list.Add(LoadData(reader, i, parent));
                    }
                    return list;
                }

                public static Unk_Array LoadData(BinaryReader reader, ulong i, Default parent) {
                    var data = new Unk_Array();
                    data.Index = i;
                    data.Unk_1_raw = reader.ReadNullTermString();
                    data.Unk_2_raw = reader.ReadSingle();
                    data.Animation_Start_Frame_raw = reader.ReadUInt32();
                    data.Interpolation_raw = reader.ReadUInt32();
                    data.Overlap_Blending_raw = reader.ReadUInt32();
                    data.Unk_6_raw = reader.ReadSingle();
                    data.Interpolation_Modifier__raw = reader.ReadUInt32();
                    data.Unk_8_raw = reader.ReadInt32();
                    data.Animation_Id_raw = reader.ReadUInt32();
                    return data;
                }

                public void WriteData(BinaryWriter writer, Default parent) {
                    writer.Write(Unk_1_raw.ToNullTermCharArray());
                    writer.Write(Unk_2_raw);
                    writer.Write(Animation_Start_Frame_raw);
                    writer.Write(Interpolation_raw);
                    writer.Write(Overlap_Blending_raw);
                    writer.Write(Unk_6_raw);
                    writer.Write(Interpolation_Modifier__raw);
                    writer.Write(Unk_8_raw);
                    writer.Write(Animation_Id_raw);
                }
            }

            public const string Unk_4_displayName = "Unk 4";
            public const int Unk_4_sortIndex = 250;
            [SortOrder(Unk_4_sortIndex)]
            [DisplayName(Unk_4_displayName)]
            public virtual ObservableCollection<Unk_Array> Unk_4_raw { get; protected set; }

            protected uint Unk_5_raw;
            public const string Unk_5_displayName = "Unk 5";
            public const int Unk_5_sortIndex = 300;
            [SortOrder(Unk_5_sortIndex)]
            [DisplayName(Unk_5_displayName)]
            public virtual uint Unk_5 {
                get => Unk_5_raw;
                set {
                    if (Unk_5_raw == value) return;
                    Unk_5_raw = value;
                    ChangedItems.Add(nameof(Unk_5));
                    OnPropertyChanged(nameof(Unk_5));
                }
            }

            protected uint Unk_6_raw;
            public const string Unk_6_displayName = "Unk 6";
            public const int Unk_6_sortIndex = 350;
            [SortOrder(Unk_6_sortIndex)]
            [DisplayName(Unk_6_displayName)]
            public virtual uint Unk_6 {
                get => Unk_6_raw;
                set {
                    if (Unk_6_raw == value) return;
                    Unk_6_raw = value;
                    ChangedItems.Add(nameof(Unk_6));
                    OnPropertyChanged(nameof(Unk_6));
                }
            }

            public const int lastSortIndex = 400;

            public IEnumerable<F> GetAllEnumerableChildrenOfType<F>() {
                if (typeof(Unk_Array).Is(typeof(F)) || typeof(Unk_Array).IsGeneric(typeof(F))) {
                    foreach (var item in Unk_4_raw.Cast<F>()) {
                        yield return item;
                    }
                }
            }

            public static ObservableMhwStructCollection<Default> LoadData(BinaryReader reader, ObservableMhwStructCollection<Motion_Blend_Data_1_> lastStruct) {
                var list = new ObservableMhwStructCollection<Default>();
                var countTarget = (Motion_Blend_Data_1_) lastStruct.Last();
                var count = (ulong) countTarget.Entry_Count;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Default LoadData(BinaryReader reader, ulong i) {
                var data = new Default();
                data.Index = i;
                data.lmt_Offset_Index_raw = reader.ReadUInt32();
                data.Num_of_Values_raw = reader.ReadUInt32();
                data.Unk_2_raw = reader.ReadUInt32();
                data.Unk_3_raw = reader.ReadUInt32();
                data.Unk_4_raw = Unk_Array.LoadData(reader, data);
                data.Unk_5_raw = reader.ReadUInt32();
                data.Unk_6_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                Num_of_Values = (uint) Unk_4_raw.Count;
                writer.Write(lmt_Offset_Index_raw);
                writer.Write(Num_of_Values_raw);
                writer.Write(Unk_2_raw);
                writer.Write(Unk_3_raw);
                foreach (var obj in Unk_4_raw) {
                    obj.WriteData(writer, this);
                }
                writer.Write(Unk_5_raw);
                writer.Write(Unk_6_raw);
            }
        }

        public override void LoadFile(string targetFile) {
            using var reader = new BinaryReader(OpenFile(targetFile, EncryptionKey), Encoding.UTF8);
            data = new LinkedList<MhwStructDataContainer>();
            var Motion_Blend_Data_1__ = new MhwStructDataContainer<Motion_Blend_Data_1_>(Motion_Blend_Data_1_.LoadData(reader), typeof(Motion_Blend_Data_1_));
            data.AddLast(Motion_Blend_Data_1__);
            var Default_ = new MhwStructDataContainer<Default, Motion_Blend_Data_1_>(Default.LoadData(reader, Motion_Blend_Data_1__.list), typeof(Default));
            Default_.SetCountTargetToUpdate(Motion_Blend_Data_1__, -1, "Entry_Count");
            data.AddLast(Default_);
        }
    }
}
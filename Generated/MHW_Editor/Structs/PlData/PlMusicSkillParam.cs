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

namespace MHW_Editor.Structs.PlData {
    public partial class PlMusicSkillParam {
        public override string EncryptionKey => "qm7psvaMXQoay7kARXpNPcLNWqsbqcOyI4lqHtxFh26HSuE6RHNq7J4e";

        public partial class Header : MhwStructItem {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Header";

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
                    OnPropertyChanged(nameof(Magic_1));
                }
            }

            protected ushort Magic_2_raw;
            public const string Magic_2_displayName = "Magic 2";
            public const int Magic_2_sortIndex = 100;
            [SortOrder(Magic_2_sortIndex)]
            [DisplayName(Magic_2_displayName)]
            [IsReadOnly]
            public virtual ushort Magic_2 {
                get => Magic_2_raw;
                set {
                    if (Magic_2_raw == value) return;
                    Magic_2_raw = value;
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
                    OnPropertyChanged(nameof(Entry_Count));
                }
            }

            protected uint Magic_3_raw;
            public const string Magic_3_displayName = "Magic 3";
            public const int Magic_3_sortIndex = 200;
            [SortOrder(Magic_3_sortIndex)]
            [DisplayName(Magic_3_displayName)]
            [IsReadOnly]
            public virtual uint Magic_3 {
                get => Magic_3_raw;
                set {
                    if (Magic_3_raw == value) return;
                    Magic_3_raw = value;
                    OnPropertyChanged(nameof(Magic_3));
                }
            }

            public const int lastSortIndex = 250;

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Header LoadData(BinaryReader reader, ulong i) {
                var data = new Header();
                data.Index = i;
                data.Magic_1_raw = reader.ReadUInt32();
                data.Magic_2_raw = reader.ReadUInt16();
                data.Entry_Count_raw = reader.ReadUInt32();
                data.Magic_3_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Magic_1_raw);
                writer.Write(Magic_2_raw);
                writer.Write(Entry_Count_raw);
                writer.Write(Magic_3_raw);
            }
        }

        public partial class Entries : MhwStructItem {
            public const ulong FixedSizeCount = 0;
            public const string GridName = "Entries";

            protected float Duration_raw;
            public const string Duration_displayName = "Duration";
            public const int Duration_sortIndex = 50;
            [SortOrder(Duration_sortIndex)]
            [DisplayName(Duration_displayName)]
            public virtual float Duration {
                get => Duration_raw;
                set {
                    if (Duration_raw == value) return;
                    Duration_raw = value;
                    OnPropertyChanged(nameof(Duration));
                }
            }

            protected float Extension_raw;
            public const string Extension_displayName = "Extension";
            public const int Extension_sortIndex = 100;
            [SortOrder(Extension_sortIndex)]
            [DisplayName(Extension_displayName)]
            public virtual float Extension {
                get => Extension_raw;
                set {
                    if (Extension_raw == value) return;
                    Extension_raw = value;
                    OnPropertyChanged(nameof(Extension));
                }
            }

            protected float M1_Duration_raw;
            public const string M1_Duration_displayName = "M1 Duration";
            public const int M1_Duration_sortIndex = 150;
            [SortOrder(M1_Duration_sortIndex)]
            [DisplayName(M1_Duration_displayName)]
            public virtual float M1_Duration {
                get => M1_Duration_raw;
                set {
                    if (M1_Duration_raw == value) return;
                    M1_Duration_raw = value;
                    OnPropertyChanged(nameof(M1_Duration));
                }
            }

            protected float M1_Extension_raw;
            public const string M1_Extension_displayName = "M1 Extension";
            public const int M1_Extension_sortIndex = 200;
            [SortOrder(M1_Extension_sortIndex)]
            [DisplayName(M1_Extension_displayName)]
            public virtual float M1_Extension {
                get => M1_Extension_raw;
                set {
                    if (M1_Extension_raw == value) return;
                    M1_Extension_raw = value;
                    OnPropertyChanged(nameof(M1_Extension));
                }
            }

            protected float M2_Duration_raw;
            public const string M2_Duration_displayName = "M2 Duration";
            public const int M2_Duration_sortIndex = 250;
            [SortOrder(M2_Duration_sortIndex)]
            [DisplayName(M2_Duration_displayName)]
            public virtual float M2_Duration {
                get => M2_Duration_raw;
                set {
                    if (M2_Duration_raw == value) return;
                    M2_Duration_raw = value;
                    OnPropertyChanged(nameof(M2_Duration));
                }
            }

            protected float M2_Extension_raw;
            public const string M2_Extension_displayName = "M2 Extension";
            public const int M2_Extension_sortIndex = 300;
            [SortOrder(M2_Extension_sortIndex)]
            [DisplayName(M2_Extension_displayName)]
            public virtual float M2_Extension {
                get => M2_Extension_raw;
                set {
                    if (M2_Extension_raw == value) return;
                    M2_Extension_raw = value;
                    OnPropertyChanged(nameof(M2_Extension));
                }
            }

            protected float Effect_raw;
            public const string Effect_displayName = "Effect";
            public const int Effect_sortIndex = 350;
            [SortOrder(Effect_sortIndex)]
            [DisplayName(Effect_displayName)]
            public virtual float Effect {
                get => Effect_raw;
                set {
                    if (Effect_raw == value) return;
                    Effect_raw = value;
                    OnPropertyChanged(nameof(Effect));
                }
            }

            protected float Recast_Effect_raw;
            public const string Recast_Effect_displayName = "Recast Effect";
            public const int Recast_Effect_sortIndex = 400;
            [SortOrder(Recast_Effect_sortIndex)]
            [DisplayName(Recast_Effect_displayName)]
            public virtual float Recast_Effect {
                get => Recast_Effect_raw;
                set {
                    if (Recast_Effect_raw == value) return;
                    Recast_Effect_raw = value;
                    OnPropertyChanged(nameof(Recast_Effect));
                }
            }

            protected uint Unk_1_raw;
            public const string Unk_1_displayName = "Unk 1";
            public const int Unk_1_sortIndex = 450;
            [SortOrder(Unk_1_sortIndex)]
            [DisplayName(Unk_1_displayName)]
            public virtual uint Unk_1 {
                get => Unk_1_raw;
                set {
                    if (Unk_1_raw == value) return;
                    Unk_1_raw = value;
                    OnPropertyChanged(nameof(Unk_1));
                }
            }

            protected uint Unk_2_raw;
            public const string Unk_2_displayName = "Unk 2";
            public const int Unk_2_sortIndex = 500;
            [SortOrder(Unk_2_sortIndex)]
            [DisplayName(Unk_2_displayName)]
            public virtual uint Unk_2 {
                get => Unk_2_raw;
                set {
                    if (Unk_2_raw == value) return;
                    Unk_2_raw = value;
                    OnPropertyChanged(nameof(Unk_2));
                }
            }

            protected uint Unk_3_raw;
            public const string Unk_3_displayName = "Unk 3";
            public const int Unk_3_sortIndex = 550;
            [SortOrder(Unk_3_sortIndex)]
            [DisplayName(Unk_3_displayName)]
            public virtual uint Unk_3 {
                get => Unk_3_raw;
                set {
                    if (Unk_3_raw == value) return;
                    Unk_3_raw = value;
                    OnPropertyChanged(nameof(Unk_3));
                }
            }

            protected uint Unk_4_raw;
            public const string Unk_4_displayName = "Unk 4";
            public const int Unk_4_sortIndex = 600;
            [SortOrder(Unk_4_sortIndex)]
            [DisplayName(Unk_4_displayName)]
            public virtual uint Unk_4 {
                get => Unk_4_raw;
                set {
                    if (Unk_4_raw == value) return;
                    Unk_4_raw = value;
                    OnPropertyChanged(nameof(Unk_4));
                }
            }

            protected uint Unk_5_raw;
            public const string Unk_5_displayName = "Unk 5";
            public const int Unk_5_sortIndex = 650;
            [SortOrder(Unk_5_sortIndex)]
            [DisplayName(Unk_5_displayName)]
            public virtual uint Unk_5 {
                get => Unk_5_raw;
                set {
                    if (Unk_5_raw == value) return;
                    Unk_5_raw = value;
                    OnPropertyChanged(nameof(Unk_5));
                }
            }

            protected uint Unk_6_raw;
            public const string Unk_6_displayName = "Unk 6";
            public const int Unk_6_sortIndex = 700;
            [SortOrder(Unk_6_sortIndex)]
            [DisplayName(Unk_6_displayName)]
            public virtual uint Unk_6 {
                get => Unk_6_raw;
                set {
                    if (Unk_6_raw == value) return;
                    Unk_6_raw = value;
                    OnPropertyChanged(nameof(Unk_6));
                }
            }

            public const int lastSortIndex = 750;

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
                var countTarget = (Header) lastStruct.Last();
                var count = (ulong) countTarget.Entry_Count;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Entries LoadData(BinaryReader reader, ulong i) {
                var data = new Entries();
                data.Index = i;
                data.Duration_raw = reader.ReadSingle();
                data.Extension_raw = reader.ReadSingle();
                data.M1_Duration_raw = reader.ReadSingle();
                data.M1_Extension_raw = reader.ReadSingle();
                data.M2_Duration_raw = reader.ReadSingle();
                data.M2_Extension_raw = reader.ReadSingle();
                data.Effect_raw = reader.ReadSingle();
                data.Recast_Effect_raw = reader.ReadSingle();
                data.Unk_1_raw = reader.ReadUInt32();
                data.Unk_2_raw = reader.ReadUInt32();
                data.Unk_3_raw = reader.ReadUInt32();
                data.Unk_4_raw = reader.ReadUInt32();
                data.Unk_5_raw = reader.ReadUInt32();
                data.Unk_6_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Duration_raw);
                writer.Write(Extension_raw);
                writer.Write(M1_Duration_raw);
                writer.Write(M1_Extension_raw);
                writer.Write(M2_Duration_raw);
                writer.Write(M2_Extension_raw);
                writer.Write(Effect_raw);
                writer.Write(Recast_Effect_raw);
                writer.Write(Unk_1_raw);
                writer.Write(Unk_2_raw);
                writer.Write(Unk_3_raw);
                writer.Write(Unk_4_raw);
                writer.Write(Unk_5_raw);
                writer.Write(Unk_6_raw);
            }
        }

        public override void LoadFile(string targetFile) {
            using var reader = new BinaryReader(OpenFile(targetFile, EncryptionKey), Encoding.UTF8);
            data = new LinkedList<MhwStructDataContainer>();
            var Header_ = new MhwStructDataContainer(Header.LoadData(reader, null), typeof(Header));
            data.AddLast(Header_);
            var Entries_ = new MhwStructDataContainer(Entries.LoadData(reader, Header_.list), typeof(Entries));
            Entries_.SetCountTargetToUpdate(Header_, -1, "Entry_Count");
            data.AddLast(Entries_);
        }
    }
}
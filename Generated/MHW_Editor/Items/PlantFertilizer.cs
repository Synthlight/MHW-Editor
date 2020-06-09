using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Items {
    public partial class PlantFertilizer {
        public override string EncryptionKey => null;

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

            public const int lastSortIndex = 200;

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
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Magic_1_raw);
                writer.Write(Magic_2_raw);
                writer.Write(Entry_Count_raw);
            }
        }

        public partial class Entries : MhwStructItem {
            public const ulong FixedSizeCount = 0;
            public const string GridName = "Entries";
            public override string UniqueId => "{Fertilizer_Id}";

            protected uint Fertilizer_Id_raw;
            public const string Fertilizer_Id_displayName = "Fertilizer Id";
            public const int Fertilizer_Id_sortIndex = 50;
            [SortOrder(Fertilizer_Id_sortIndex)]
            [DisplayName(Fertilizer_Id_displayName)]
            public virtual MHW_Template.Items.Fertilizer Fertilizer_Id {
                get => (MHW_Template.Items.Fertilizer) Fertilizer_Id_raw;
                set {
                    if ((MHW_Template.Items.Fertilizer) Fertilizer_Id_raw == value) return;
                    Fertilizer_Id_raw = (uint) value;
                    OnPropertyChanged(nameof(Fertilizer_Id));
                }
            }

            protected uint Prize_raw;
            public const string Prize_displayName = "Prize";
            public const int Prize_sortIndex = 100;
            [SortOrder(Prize_sortIndex)]
            [DisplayName(Prize_displayName)]
            public virtual uint Prize {
                get => Prize_raw;
                set {
                    if (Prize_raw == value) return;
                    Prize_raw = value;
                    OnPropertyChanged(nameof(Prize));
                }
            }

            protected uint Base_duration_raw;
            public const string Base_duration_displayName = "Base duration";
            public const int Base_duration_sortIndex = 150;
            [SortOrder(Base_duration_sortIndex)]
            [DisplayName(Base_duration_displayName)]
            public virtual uint Base_duration {
                get => Base_duration_raw;
                set {
                    if (Base_duration_raw == value) return;
                    Base_duration_raw = value;
                    OnPropertyChanged(nameof(Base_duration));
                }
            }

            protected uint Unknown_int32_1_raw;
            public const string Unknown_int32_1_displayName = "Unknown (int32) 1";
            public const int Unknown_int32_1_sortIndex = 200;
            [SortOrder(Unknown_int32_1_sortIndex)]
            [DisplayName(Unknown_int32_1_displayName)]
            public virtual uint Unknown_int32_1 {
                get => Unknown_int32_1_raw;
                set {
                    if (Unknown_int32_1_raw == value) return;
                    Unknown_int32_1_raw = value;
                    OnPropertyChanged(nameof(Unknown_int32_1));
                }
            }

            protected uint Unknown_int32_2_raw;
            public const string Unknown_int32_2_displayName = "Unknown (int32) 2";
            public const int Unknown_int32_2_sortIndex = 250;
            [SortOrder(Unknown_int32_2_sortIndex)]
            [DisplayName(Unknown_int32_2_displayName)]
            public virtual uint Unknown_int32_2 {
                get => Unknown_int32_2_raw;
                set {
                    if (Unknown_int32_2_raw == value) return;
                    Unknown_int32_2_raw = value;
                    OnPropertyChanged(nameof(Unknown_int32_2));
                }
            }

            protected uint Unknown_int32_3_raw;
            public const string Unknown_int32_3_displayName = "Unknown (int32) 3";
            public const int Unknown_int32_3_sortIndex = 300;
            [SortOrder(Unknown_int32_3_sortIndex)]
            [DisplayName(Unknown_int32_3_displayName)]
            public virtual uint Unknown_int32_3 {
                get => Unknown_int32_3_raw;
                set {
                    if (Unknown_int32_3_raw == value) return;
                    Unknown_int32_3_raw = value;
                    OnPropertyChanged(nameof(Unknown_int32_3));
                }
            }

            public const int lastSortIndex = 350;

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
                data.Fertilizer_Id_raw = reader.ReadUInt32();
                data.Prize_raw = reader.ReadUInt32();
                data.Base_duration_raw = reader.ReadUInt32();
                data.Unknown_int32_1_raw = reader.ReadUInt32();
                data.Unknown_int32_2_raw = reader.ReadUInt32();
                data.Unknown_int32_3_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Fertilizer_Id_raw);
                writer.Write(Prize_raw);
                writer.Write(Base_duration_raw);
                writer.Write(Unknown_int32_1_raw);
                writer.Write(Unknown_int32_2_raw);
                writer.Write(Unknown_int32_3_raw);
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
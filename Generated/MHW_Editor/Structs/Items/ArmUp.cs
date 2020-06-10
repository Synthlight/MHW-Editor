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

namespace MHW_Editor.Structs.Items {
    public partial class ArmUp {
        public override string EncryptionKey => null;

        public partial class Header : MhwStructItem, IWriteData {
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

            public static ObservableMhwStructCollection<Header> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Header>();
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

        public partial class Entries : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 0;
            public const string GridName = "Entries";
            public override string UniqueId => $"{Rarity}";

            protected short Quest_Progress_1_raw;
            public const string Quest_Progress_1_displayName = "Quest Progress 1";
            public const int Quest_Progress_1_sortIndex = 50;
            [SortOrder(Quest_Progress_1_sortIndex)]
            [DisplayName(Quest_Progress_1_displayName)]
            public virtual short Quest_Progress_1 {
                get => Quest_Progress_1_raw;
                set {
                    if (Quest_Progress_1_raw == value) return;
                    Quest_Progress_1_raw = value;
                    OnPropertyChanged(nameof(Quest_Progress_1));
                }
            }

            protected short Quest_Progress_2_raw;
            public const string Quest_Progress_2_displayName = "Quest Progress 2";
            public const int Quest_Progress_2_sortIndex = 100;
            [SortOrder(Quest_Progress_2_sortIndex)]
            [DisplayName(Quest_Progress_2_displayName)]
            public virtual short Quest_Progress_2 {
                get => Quest_Progress_2_raw;
                set {
                    if (Quest_Progress_2_raw == value) return;
                    Quest_Progress_2_raw = value;
                    OnPropertyChanged(nameof(Quest_Progress_2));
                }
            }

            protected short Quest_Progress_3_raw;
            public const string Quest_Progress_3_displayName = "Quest Progress 3";
            public const int Quest_Progress_3_sortIndex = 150;
            [SortOrder(Quest_Progress_3_sortIndex)]
            [DisplayName(Quest_Progress_3_displayName)]
            public virtual short Quest_Progress_3 {
                get => Quest_Progress_3_raw;
                set {
                    if (Quest_Progress_3_raw == value) return;
                    Quest_Progress_3_raw = value;
                    OnPropertyChanged(nameof(Quest_Progress_3));
                }
            }

            protected short Quest_Progress_4_raw;
            public const string Quest_Progress_4_displayName = "Quest Progress 4";
            public const int Quest_Progress_4_sortIndex = 200;
            [SortOrder(Quest_Progress_4_sortIndex)]
            [DisplayName(Quest_Progress_4_displayName)]
            public virtual short Quest_Progress_4 {
                get => Quest_Progress_4_raw;
                set {
                    if (Quest_Progress_4_raw == value) return;
                    Quest_Progress_4_raw = value;
                    OnPropertyChanged(nameof(Quest_Progress_4));
                }
            }

            protected short Quest_Progress_5_raw;
            public const string Quest_Progress_5_displayName = "Quest Progress 5";
            public const int Quest_Progress_5_sortIndex = 250;
            [SortOrder(Quest_Progress_5_sortIndex)]
            [DisplayName(Quest_Progress_5_displayName)]
            public virtual short Quest_Progress_5 {
                get => Quest_Progress_5_raw;
                set {
                    if (Quest_Progress_5_raw == value) return;
                    Quest_Progress_5_raw = value;
                    OnPropertyChanged(nameof(Quest_Progress_5));
                }
            }

            protected short Quest_Progress_6_raw;
            public const string Quest_Progress_6_displayName = "Quest Progress 6";
            public const int Quest_Progress_6_sortIndex = 300;
            [SortOrder(Quest_Progress_6_sortIndex)]
            [DisplayName(Quest_Progress_6_displayName)]
            public virtual short Quest_Progress_6 {
                get => Quest_Progress_6_raw;
                set {
                    if (Quest_Progress_6_raw == value) return;
                    Quest_Progress_6_raw = value;
                    OnPropertyChanged(nameof(Quest_Progress_6));
                }
            }

            protected short Quest_Progress_7_raw;
            public const string Quest_Progress_7_displayName = "Quest Progress 7";
            public const int Quest_Progress_7_sortIndex = 350;
            [SortOrder(Quest_Progress_7_sortIndex)]
            [DisplayName(Quest_Progress_7_displayName)]
            public virtual short Quest_Progress_7 {
                get => Quest_Progress_7_raw;
                set {
                    if (Quest_Progress_7_raw == value) return;
                    Quest_Progress_7_raw = value;
                    OnPropertyChanged(nameof(Quest_Progress_7));
                }
            }

            protected short Quest_Progress_8_raw;
            public const string Quest_Progress_8_displayName = "Quest Progress 8";
            public const int Quest_Progress_8_sortIndex = 400;
            [SortOrder(Quest_Progress_8_sortIndex)]
            [DisplayName(Quest_Progress_8_displayName)]
            public virtual short Quest_Progress_8 {
                get => Quest_Progress_8_raw;
                set {
                    if (Quest_Progress_8_raw == value) return;
                    Quest_Progress_8_raw = value;
                    OnPropertyChanged(nameof(Quest_Progress_8));
                }
            }

            protected short Quest_Progress_9_raw;
            public const string Quest_Progress_9_displayName = "Quest Progress 9";
            public const int Quest_Progress_9_sortIndex = 450;
            [SortOrder(Quest_Progress_9_sortIndex)]
            [DisplayName(Quest_Progress_9_displayName)]
            public virtual short Quest_Progress_9 {
                get => Quest_Progress_9_raw;
                set {
                    if (Quest_Progress_9_raw == value) return;
                    Quest_Progress_9_raw = value;
                    OnPropertyChanged(nameof(Quest_Progress_9));
                }
            }

            protected short Quest_Progress_10_raw;
            public const string Quest_Progress_10_displayName = "Quest Progress 10";
            public const int Quest_Progress_10_sortIndex = 500;
            [SortOrder(Quest_Progress_10_sortIndex)]
            [DisplayName(Quest_Progress_10_displayName)]
            public virtual short Quest_Progress_10 {
                get => Quest_Progress_10_raw;
                set {
                    if (Quest_Progress_10_raw == value) return;
                    Quest_Progress_10_raw = value;
                    OnPropertyChanged(nameof(Quest_Progress_10));
                }
            }

            protected short Quest_Progress_11_raw;
            public const string Quest_Progress_11_displayName = "Quest Progress 11";
            public const int Quest_Progress_11_sortIndex = 550;
            [SortOrder(Quest_Progress_11_sortIndex)]
            [DisplayName(Quest_Progress_11_displayName)]
            public virtual short Quest_Progress_11 {
                get => Quest_Progress_11_raw;
                set {
                    if (Quest_Progress_11_raw == value) return;
                    Quest_Progress_11_raw = value;
                    OnPropertyChanged(nameof(Quest_Progress_11));
                }
            }

            public const int lastSortIndex = 600;

            public static ObservableMhwStructCollection<Entries> LoadData(BinaryReader reader, ObservableMhwStructCollection<Header> lastStruct) {
                var list = new ObservableMhwStructCollection<Entries>();
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
                data.Quest_Progress_1_raw = reader.ReadInt16();
                data.Quest_Progress_2_raw = reader.ReadInt16();
                data.Quest_Progress_3_raw = reader.ReadInt16();
                data.Quest_Progress_4_raw = reader.ReadInt16();
                data.Quest_Progress_5_raw = reader.ReadInt16();
                data.Quest_Progress_6_raw = reader.ReadInt16();
                data.Quest_Progress_7_raw = reader.ReadInt16();
                data.Quest_Progress_8_raw = reader.ReadInt16();
                data.Quest_Progress_9_raw = reader.ReadInt16();
                data.Quest_Progress_10_raw = reader.ReadInt16();
                data.Quest_Progress_11_raw = reader.ReadInt16();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Quest_Progress_1_raw);
                writer.Write(Quest_Progress_2_raw);
                writer.Write(Quest_Progress_3_raw);
                writer.Write(Quest_Progress_4_raw);
                writer.Write(Quest_Progress_5_raw);
                writer.Write(Quest_Progress_6_raw);
                writer.Write(Quest_Progress_7_raw);
                writer.Write(Quest_Progress_8_raw);
                writer.Write(Quest_Progress_9_raw);
                writer.Write(Quest_Progress_10_raw);
                writer.Write(Quest_Progress_11_raw);
            }
        }

        public override void LoadFile(string targetFile) {
            using var reader = new BinaryReader(OpenFile(targetFile, EncryptionKey), Encoding.UTF8);
            data = new LinkedList<MhwStructDataContainer>();
            var Header_ = new MhwStructDataContainer<Header>(Header.LoadData(reader), typeof(Header));
            data.AddLast(Header_);
            var Entries_ = new MhwStructDataContainer<Entries, Header>(Entries.LoadData(reader, Header_.list), typeof(Entries));
            Entries_.SetCountTargetToUpdate(Header_, -1, "Entry_Count");
            data.AddLast(Entries_);
        }
    }
}
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
    public partial class KulveGradeLottery {
        public override string EncryptionKey => null;

        public partial class Header : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Header";

            protected ushort Magic_1_raw;
            public const string Magic_1_displayName = "Magic 1";
            public const int Magic_1_sortIndex = 50;
            [SortOrder(Magic_1_sortIndex)]
            [DisplayName(Magic_1_displayName)]
            [IsReadOnly]
            public virtual ushort Magic_1 {
                get => Magic_1_raw;
                set {
                    if (Magic_1_raw == value) return;
                    Magic_1_raw = value;
                    OnPropertyChanged(nameof(Magic_1));
                }
            }

            protected uint Entry_Count_raw;
            public const string Entry_Count_displayName = "Entry Count";
            public const int Entry_Count_sortIndex = 100;
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

            public const int lastSortIndex = 150;

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
                data.Magic_1_raw = reader.ReadUInt16();
                data.Entry_Count_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Magic_1_raw);
                writer.Write(Entry_Count_raw);
            }
        }

        public partial class Entries : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 0;
            public const string GridName = "Entries";
            public override string UniqueId => "{Item_Id}";

            protected uint Index_raw;
            public const string Index_displayName = "Index";
            public const int Index_sortIndex = 50;
            [SortOrder(Index_sortIndex)]
            [DisplayName(Index_displayName)]
            [IsReadOnly]
            public override ulong Index {
                get => (ulong) Index_raw;
                set {
                    if ((ulong) Index_raw == value) return;
                    Index_raw = (uint) value;
                    OnPropertyChanged(nameof(Index));
                }
            }

            protected uint Item_Id_raw;
            public const string Item_Id_displayName = "Item Id";
            public const int Item_Id_sortIndex = 100;
            [SortOrder(Item_Id_sortIndex)]
            [DisplayName(Item_Id_displayName)]
            [DataSource(DataSourceType.Items)]
            [IsReadOnly]
            public virtual uint Item_Id {
                get => Item_Id_raw;
                set {
                    if (Item_Id_raw == value) return;
                    Item_Id_raw = value;
                    OnPropertyChanged(nameof(Item_Id));
                    OnPropertyChanged(nameof(Item_Id_button));
                }
            }

            [SortOrder(Item_Id_sortIndex)]
            [DisplayName(Item_Id_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Item_Id_button => DataHelper.itemNames[MainWindow.locale].TryGet(Item_Id).ToStringWithId(Item_Id);

            protected uint Grade_1_raw;
            public const string Grade_1_displayName = "Grade 1";
            public const int Grade_1_sortIndex = 150;
            [SortOrder(Grade_1_sortIndex)]
            [DisplayName(Grade_1_displayName)]
            public virtual uint Grade_1 {
                get => Grade_1_raw;
                set {
                    if (Grade_1_raw == value) return;
                    Grade_1_raw = value;
                    OnPropertyChanged(nameof(Grade_1));
                }
            }

            private float _Grade_1Percent;
            [SortOrder(Grade_1_sortIndex + 1)]
            [DisplayName(Grade_1_displayName + "%")]
            public float Grade_1_percent {
                get => _Grade_1Percent;
                set {
                    _Grade_1Percent = value.Clamp(0f, 100f);
                    OnPropertyChanged(nameof(Grade_1_percent));
                }
            }

            protected uint Grade_2_raw;
            public const string Grade_2_displayName = "Grade 2";
            public const int Grade_2_sortIndex = 200;
            [SortOrder(Grade_2_sortIndex)]
            [DisplayName(Grade_2_displayName)]
            public virtual uint Grade_2 {
                get => Grade_2_raw;
                set {
                    if (Grade_2_raw == value) return;
                    Grade_2_raw = value;
                    OnPropertyChanged(nameof(Grade_2));
                }
            }

            private float _Grade_2Percent;
            [SortOrder(Grade_2_sortIndex + 1)]
            [DisplayName(Grade_2_displayName + "%")]
            public float Grade_2_percent {
                get => _Grade_2Percent;
                set {
                    _Grade_2Percent = value.Clamp(0f, 100f);
                    OnPropertyChanged(nameof(Grade_2_percent));
                }
            }

            protected uint Grade_3_raw;
            public const string Grade_3_displayName = "Grade 3";
            public const int Grade_3_sortIndex = 250;
            [SortOrder(Grade_3_sortIndex)]
            [DisplayName(Grade_3_displayName)]
            public virtual uint Grade_3 {
                get => Grade_3_raw;
                set {
                    if (Grade_3_raw == value) return;
                    Grade_3_raw = value;
                    OnPropertyChanged(nameof(Grade_3));
                }
            }

            private float _Grade_3Percent;
            [SortOrder(Grade_3_sortIndex + 1)]
            [DisplayName(Grade_3_displayName + "%")]
            public float Grade_3_percent {
                get => _Grade_3Percent;
                set {
                    _Grade_3Percent = value.Clamp(0f, 100f);
                    OnPropertyChanged(nameof(Grade_3_percent));
                }
            }

            protected uint Grade_4_raw;
            public const string Grade_4_displayName = "Grade 4";
            public const int Grade_4_sortIndex = 300;
            [SortOrder(Grade_4_sortIndex)]
            [DisplayName(Grade_4_displayName)]
            public virtual uint Grade_4 {
                get => Grade_4_raw;
                set {
                    if (Grade_4_raw == value) return;
                    Grade_4_raw = value;
                    OnPropertyChanged(nameof(Grade_4));
                }
            }

            private float _Grade_4Percent;
            [SortOrder(Grade_4_sortIndex + 1)]
            [DisplayName(Grade_4_displayName + "%")]
            public float Grade_4_percent {
                get => _Grade_4Percent;
                set {
                    _Grade_4Percent = value.Clamp(0f, 100f);
                    OnPropertyChanged(nameof(Grade_4_percent));
                }
            }

            protected uint Grade_5_raw;
            public const string Grade_5_displayName = "Grade 5";
            public const int Grade_5_sortIndex = 350;
            [SortOrder(Grade_5_sortIndex)]
            [DisplayName(Grade_5_displayName)]
            public virtual uint Grade_5 {
                get => Grade_5_raw;
                set {
                    if (Grade_5_raw == value) return;
                    Grade_5_raw = value;
                    OnPropertyChanged(nameof(Grade_5));
                }
            }

            private float _Grade_5Percent;
            [SortOrder(Grade_5_sortIndex + 1)]
            [DisplayName(Grade_5_displayName + "%")]
            public float Grade_5_percent {
                get => _Grade_5Percent;
                set {
                    _Grade_5Percent = value.Clamp(0f, 100f);
                    OnPropertyChanged(nameof(Grade_5_percent));
                }
            }

            public const int lastSortIndex = 400;

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
                data.Index_raw = reader.ReadUInt32();
                data.Item_Id_raw = reader.ReadUInt32();
                data.Grade_1_raw = reader.ReadUInt32();
                data.Grade_2_raw = reader.ReadUInt32();
                data.Grade_3_raw = reader.ReadUInt32();
                data.Grade_4_raw = reader.ReadUInt32();
                data.Grade_5_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Index_raw);
                writer.Write(Item_Id_raw);
                writer.Write(Grade_1_raw);
                writer.Write(Grade_2_raw);
                writer.Write(Grade_3_raw);
                writer.Write(Grade_4_raw);
                writer.Write(Grade_5_raw);
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
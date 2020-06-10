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
    public partial class Treasure {
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
                    ChangedItems.Add(nameof(Magic_1));
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

            protected uint Item_Id_raw;
            public const string Item_Id_displayName = "Item Id";
            public const int Item_Id_sortIndex = 50;
            [SortOrder(Item_Id_sortIndex)]
            [DisplayName(Item_Id_displayName)]
            [DataSource(DataSourceType.Items)]
            public virtual uint Item_Id {
                get => Item_Id_raw;
                set {
                    if (Item_Id_raw == value) return;
                    Item_Id_raw = value;
                    ChangedItems.Add(nameof(Item_Id));
                    OnPropertyChanged(nameof(Item_Id));
                    OnPropertyChanged(nameof(Item_Id_button));
                }
            }

            [SortOrder(Item_Id_sortIndex)]
            [DisplayName(Item_Id_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Item_Id_button => DataHelper.itemNames[MainWindow.locale].TryGet(Item_Id).ToStringWithId(Item_Id);

            protected uint Unk2_raw;
            public const string Unk2_displayName = "Unk2";
            public const int Unk2_sortIndex = 100;
            [SortOrder(Unk2_sortIndex)]
            [DisplayName(Unk2_displayName)]
            public virtual uint Unk2 {
                get => Unk2_raw;
                set {
                    if (Unk2_raw == value) return;
                    Unk2_raw = value;
                    ChangedItems.Add(nameof(Unk2));
                    OnPropertyChanged(nameof(Unk2));
                }
            }

            protected uint Unk3_raw;
            public const string Unk3_displayName = "Unk3";
            public const int Unk3_sortIndex = 150;
            [SortOrder(Unk3_sortIndex)]
            [DisplayName(Unk3_displayName)]
            public virtual uint Unk3 {
                get => Unk3_raw;
                set {
                    if (Unk3_raw == value) return;
                    Unk3_raw = value;
                    ChangedItems.Add(nameof(Unk3));
                    OnPropertyChanged(nameof(Unk3));
                }
            }

            protected uint Unk4_raw;
            public const string Unk4_displayName = "Unk4";
            public const int Unk4_sortIndex = 200;
            [SortOrder(Unk4_sortIndex)]
            [DisplayName(Unk4_displayName)]
            public virtual uint Unk4 {
                get => Unk4_raw;
                set {
                    if (Unk4_raw == value) return;
                    Unk4_raw = value;
                    ChangedItems.Add(nameof(Unk4));
                    OnPropertyChanged(nameof(Unk4));
                }
            }

            protected uint Unk5_raw;
            public const string Unk5_displayName = "Unk5";
            public const int Unk5_sortIndex = 250;
            [SortOrder(Unk5_sortIndex)]
            [DisplayName(Unk5_displayName)]
            public virtual uint Unk5 {
                get => Unk5_raw;
                set {
                    if (Unk5_raw == value) return;
                    Unk5_raw = value;
                    ChangedItems.Add(nameof(Unk5));
                    OnPropertyChanged(nameof(Unk5));
                }
            }

            protected uint Unk6_raw;
            public const string Unk6_displayName = "Unk6";
            public const int Unk6_sortIndex = 300;
            [SortOrder(Unk6_sortIndex)]
            [DisplayName(Unk6_displayName)]
            public virtual uint Unk6 {
                get => Unk6_raw;
                set {
                    if (Unk6_raw == value) return;
                    Unk6_raw = value;
                    ChangedItems.Add(nameof(Unk6));
                    OnPropertyChanged(nameof(Unk6));
                }
            }

            protected uint Unk7_raw;
            public const string Unk7_displayName = "Unk7";
            public const int Unk7_sortIndex = 350;
            [SortOrder(Unk7_sortIndex)]
            [DisplayName(Unk7_displayName)]
            public virtual uint Unk7 {
                get => Unk7_raw;
                set {
                    if (Unk7_raw == value) return;
                    Unk7_raw = value;
                    ChangedItems.Add(nameof(Unk7));
                    OnPropertyChanged(nameof(Unk7));
                }
            }

            protected uint Unk8_raw;
            public const string Unk8_displayName = "Unk8";
            public const int Unk8_sortIndex = 400;
            [SortOrder(Unk8_sortIndex)]
            [DisplayName(Unk8_displayName)]
            public virtual uint Unk8 {
                get => Unk8_raw;
                set {
                    if (Unk8_raw == value) return;
                    Unk8_raw = value;
                    ChangedItems.Add(nameof(Unk8));
                    OnPropertyChanged(nameof(Unk8));
                }
            }

            protected uint Unk9_raw;
            public const string Unk9_displayName = "Unk9";
            public const int Unk9_sortIndex = 450;
            [SortOrder(Unk9_sortIndex)]
            [DisplayName(Unk9_displayName)]
            public virtual uint Unk9 {
                get => Unk9_raw;
                set {
                    if (Unk9_raw == value) return;
                    Unk9_raw = value;
                    ChangedItems.Add(nameof(Unk9));
                    OnPropertyChanged(nameof(Unk9));
                }
            }

            protected uint Unk10_raw;
            public const string Unk10_displayName = "Unk10";
            public const int Unk10_sortIndex = 500;
            [SortOrder(Unk10_sortIndex)]
            [DisplayName(Unk10_displayName)]
            public virtual uint Unk10 {
                get => Unk10_raw;
                set {
                    if (Unk10_raw == value) return;
                    Unk10_raw = value;
                    ChangedItems.Add(nameof(Unk10));
                    OnPropertyChanged(nameof(Unk10));
                }
            }

            protected uint Unk11_raw;
            public const string Unk11_displayName = "Unk11";
            public const int Unk11_sortIndex = 550;
            [SortOrder(Unk11_sortIndex)]
            [DisplayName(Unk11_displayName)]
            public virtual uint Unk11 {
                get => Unk11_raw;
                set {
                    if (Unk11_raw == value) return;
                    Unk11_raw = value;
                    ChangedItems.Add(nameof(Unk11));
                    OnPropertyChanged(nameof(Unk11));
                }
            }

            protected uint Unk12_raw;
            public const string Unk12_displayName = "Unk12";
            public const int Unk12_sortIndex = 600;
            [SortOrder(Unk12_sortIndex)]
            [DisplayName(Unk12_displayName)]
            public virtual uint Unk12 {
                get => Unk12_raw;
                set {
                    if (Unk12_raw == value) return;
                    Unk12_raw = value;
                    ChangedItems.Add(nameof(Unk12));
                    OnPropertyChanged(nameof(Unk12));
                }
            }

            protected uint Unk13_raw;
            public const string Unk13_displayName = "Unk13";
            public const int Unk13_sortIndex = 650;
            [SortOrder(Unk13_sortIndex)]
            [DisplayName(Unk13_displayName)]
            public virtual uint Unk13 {
                get => Unk13_raw;
                set {
                    if (Unk13_raw == value) return;
                    Unk13_raw = value;
                    ChangedItems.Add(nameof(Unk13));
                    OnPropertyChanged(nameof(Unk13));
                }
            }

            protected uint Unk14_raw;
            public const string Unk14_displayName = "Unk14";
            public const int Unk14_sortIndex = 700;
            [SortOrder(Unk14_sortIndex)]
            [DisplayName(Unk14_displayName)]
            public virtual uint Unk14 {
                get => Unk14_raw;
                set {
                    if (Unk14_raw == value) return;
                    Unk14_raw = value;
                    ChangedItems.Add(nameof(Unk14));
                    OnPropertyChanged(nameof(Unk14));
                }
            }

            public const int lastSortIndex = 750;

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
                data.Item_Id_raw = reader.ReadUInt32();
                data.Unk2_raw = reader.ReadUInt32();
                data.Unk3_raw = reader.ReadUInt32();
                data.Unk4_raw = reader.ReadUInt32();
                data.Unk5_raw = reader.ReadUInt32();
                data.Unk6_raw = reader.ReadUInt32();
                data.Unk7_raw = reader.ReadUInt32();
                data.Unk8_raw = reader.ReadUInt32();
                data.Unk9_raw = reader.ReadUInt32();
                data.Unk10_raw = reader.ReadUInt32();
                data.Unk11_raw = reader.ReadUInt32();
                data.Unk12_raw = reader.ReadUInt32();
                data.Unk13_raw = reader.ReadUInt32();
                data.Unk14_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Item_Id_raw);
                writer.Write(Unk2_raw);
                writer.Write(Unk3_raw);
                writer.Write(Unk4_raw);
                writer.Write(Unk5_raw);
                writer.Write(Unk6_raw);
                writer.Write(Unk7_raw);
                writer.Write(Unk8_raw);
                writer.Write(Unk9_raw);
                writer.Write(Unk10_raw);
                writer.Write(Unk11_raw);
                writer.Write(Unk12_raw);
                writer.Write(Unk13_raw);
                writer.Write(Unk14_raw);
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
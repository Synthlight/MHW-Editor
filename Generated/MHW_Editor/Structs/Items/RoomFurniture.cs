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
    public partial class RoomFurniture {
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

            protected uint Unk1_raw;
            public const string Unk1_displayName = "Unk1";
            public const int Unk1_sortIndex = 100;
            [SortOrder(Unk1_sortIndex)]
            [DisplayName(Unk1_displayName)]
            public virtual uint Unk1 {
                get => Unk1_raw;
                set {
                    if (Unk1_raw == value) return;
                    Unk1_raw = value;
                    ChangedItems.Add(nameof(Unk1));
                    OnPropertyChanged(nameof(Unk1));
                }
            }

            protected uint Unk2_raw;
            public const string Unk2_displayName = "Unk2";
            public const int Unk2_sortIndex = 150;
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
            public const int Unk3_sortIndex = 200;
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

            protected byte Unk4_raw;
            public const string Unk4_displayName = "Unk4";
            public const int Unk4_sortIndex = 250;
            [SortOrder(Unk4_sortIndex)]
            [DisplayName(Unk4_displayName)]
            public virtual bool Unk4 {
                get => (bool) Convert.ToBoolean(Unk4_raw);
                set {
                    if (Convert.ToBoolean(Unk4_raw) == value) return;
                    Unk4_raw = Convert.ToByte(value);
                    ChangedItems.Add(nameof(Unk4));
                    OnPropertyChanged(nameof(Unk4));
                }
            }

            protected byte Unk5_raw;
            public const string Unk5_displayName = "Unk5";
            public const int Unk5_sortIndex = 300;
            [SortOrder(Unk5_sortIndex)]
            [DisplayName(Unk5_displayName)]
            public virtual byte Unk5 {
                get => Unk5_raw;
                set {
                    if (Unk5_raw == value) return;
                    Unk5_raw = value;
                    ChangedItems.Add(nameof(Unk5));
                    OnPropertyChanged(nameof(Unk5));
                }
            }

            protected byte Unk6_raw;
            public const string Unk6_displayName = "Unk6";
            public const int Unk6_sortIndex = 350;
            [SortOrder(Unk6_sortIndex)]
            [DisplayName(Unk6_displayName)]
            public virtual bool Unk6 {
                get => (bool) Convert.ToBoolean(Unk6_raw);
                set {
                    if (Convert.ToBoolean(Unk6_raw) == value) return;
                    Unk6_raw = Convert.ToByte(value);
                    ChangedItems.Add(nameof(Unk6));
                    OnPropertyChanged(nameof(Unk6));
                }
            }

            protected byte Unk7_raw;
            public const string Unk7_displayName = "Unk7";
            public const int Unk7_sortIndex = 400;
            [SortOrder(Unk7_sortIndex)]
            [DisplayName(Unk7_displayName)]
            public virtual bool Unk7 {
                get => (bool) Convert.ToBoolean(Unk7_raw);
                set {
                    if (Convert.ToBoolean(Unk7_raw) == value) return;
                    Unk7_raw = Convert.ToByte(value);
                    ChangedItems.Add(nameof(Unk7));
                    OnPropertyChanged(nameof(Unk7));
                }
            }

            protected byte Unk8_raw;
            public const string Unk8_displayName = "Unk8";
            public const int Unk8_sortIndex = 450;
            [SortOrder(Unk8_sortIndex)]
            [DisplayName(Unk8_displayName)]
            public virtual bool Unk8 {
                get => (bool) Convert.ToBoolean(Unk8_raw);
                set {
                    if (Convert.ToBoolean(Unk8_raw) == value) return;
                    Unk8_raw = Convert.ToByte(value);
                    ChangedItems.Add(nameof(Unk8));
                    OnPropertyChanged(nameof(Unk8));
                }
            }

            protected byte Unk9_raw;
            public const string Unk9_displayName = "Unk9";
            public const int Unk9_sortIndex = 500;
            [SortOrder(Unk9_sortIndex)]
            [DisplayName(Unk9_displayName)]
            public virtual bool Unk9 {
                get => (bool) Convert.ToBoolean(Unk9_raw);
                set {
                    if (Convert.ToBoolean(Unk9_raw) == value) return;
                    Unk9_raw = Convert.ToByte(value);
                    ChangedItems.Add(nameof(Unk9));
                    OnPropertyChanged(nameof(Unk9));
                }
            }

            protected byte Unk10_raw;
            public const string Unk10_displayName = "Unk10";
            public const int Unk10_sortIndex = 550;
            [SortOrder(Unk10_sortIndex)]
            [DisplayName(Unk10_displayName)]
            public virtual bool Unk10 {
                get => (bool) Convert.ToBoolean(Unk10_raw);
                set {
                    if (Convert.ToBoolean(Unk10_raw) == value) return;
                    Unk10_raw = Convert.ToByte(value);
                    ChangedItems.Add(nameof(Unk10));
                    OnPropertyChanged(nameof(Unk10));
                }
            }

            protected byte Unk11_raw;
            public const string Unk11_displayName = "Unk11";
            public const int Unk11_sortIndex = 600;
            [SortOrder(Unk11_sortIndex)]
            [DisplayName(Unk11_displayName)]
            public virtual bool Unk11 {
                get => (bool) Convert.ToBoolean(Unk11_raw);
                set {
                    if (Convert.ToBoolean(Unk11_raw) == value) return;
                    Unk11_raw = Convert.ToByte(value);
                    ChangedItems.Add(nameof(Unk11));
                    OnPropertyChanged(nameof(Unk11));
                }
            }

            protected byte Unk12_raw;
            public const string Unk12_displayName = "Unk12";
            public const int Unk12_sortIndex = 650;
            [SortOrder(Unk12_sortIndex)]
            [DisplayName(Unk12_displayName)]
            public virtual bool Unk12 {
                get => (bool) Convert.ToBoolean(Unk12_raw);
                set {
                    if (Convert.ToBoolean(Unk12_raw) == value) return;
                    Unk12_raw = Convert.ToByte(value);
                    ChangedItems.Add(nameof(Unk12));
                    OnPropertyChanged(nameof(Unk12));
                }
            }

            protected byte Unk13_raw;
            public const string Unk13_displayName = "Unk13";
            public const int Unk13_sortIndex = 700;
            [SortOrder(Unk13_sortIndex)]
            [DisplayName(Unk13_displayName)]
            public virtual bool Unk13 {
                get => (bool) Convert.ToBoolean(Unk13_raw);
                set {
                    if (Convert.ToBoolean(Unk13_raw) == value) return;
                    Unk13_raw = Convert.ToByte(value);
                    ChangedItems.Add(nameof(Unk13));
                    OnPropertyChanged(nameof(Unk13));
                }
            }

            protected byte Unk14_raw;
            public const string Unk14_displayName = "Unk14";
            public const int Unk14_sortIndex = 750;
            [SortOrder(Unk14_sortIndex)]
            [DisplayName(Unk14_displayName)]
            public virtual bool Unk14 {
                get => (bool) Convert.ToBoolean(Unk14_raw);
                set {
                    if (Convert.ToBoolean(Unk14_raw) == value) return;
                    Unk14_raw = Convert.ToByte(value);
                    ChangedItems.Add(nameof(Unk14));
                    OnPropertyChanged(nameof(Unk14));
                }
            }

            protected int Unk15_raw;
            public const string Unk15_displayName = "Unk15";
            public const int Unk15_sortIndex = 800;
            [SortOrder(Unk15_sortIndex)]
            [DisplayName(Unk15_displayName)]
            public virtual int Unk15 {
                get => Unk15_raw;
                set {
                    if (Unk15_raw == value) return;
                    Unk15_raw = value;
                    ChangedItems.Add(nameof(Unk15));
                    OnPropertyChanged(nameof(Unk15));
                }
            }

            protected uint Unk16_raw;
            public const string Unk16_displayName = "Unk16";
            public const int Unk16_sortIndex = 850;
            [SortOrder(Unk16_sortIndex)]
            [DisplayName(Unk16_displayName)]
            public virtual uint Unk16 {
                get => Unk16_raw;
                set {
                    if (Unk16_raw == value) return;
                    Unk16_raw = value;
                    ChangedItems.Add(nameof(Unk16));
                    OnPropertyChanged(nameof(Unk16));
                }
            }

            protected ushort Unk17_raw;
            public const string Unk17_displayName = "Unk17";
            public const int Unk17_sortIndex = 900;
            [SortOrder(Unk17_sortIndex)]
            [DisplayName(Unk17_displayName)]
            public virtual ushort Unk17 {
                get => Unk17_raw;
                set {
                    if (Unk17_raw == value) return;
                    Unk17_raw = value;
                    ChangedItems.Add(nameof(Unk17));
                    OnPropertyChanged(nameof(Unk17));
                }
            }

            protected ushort Unk18_raw;
            public const string Unk18_displayName = "Unk18";
            public const int Unk18_sortIndex = 950;
            [SortOrder(Unk18_sortIndex)]
            [DisplayName(Unk18_displayName)]
            public virtual ushort Unk18 {
                get => Unk18_raw;
                set {
                    if (Unk18_raw == value) return;
                    Unk18_raw = value;
                    ChangedItems.Add(nameof(Unk18));
                    OnPropertyChanged(nameof(Unk18));
                }
            }

            protected uint Unk19_raw;
            public const string Unk19_displayName = "Unk19";
            public const int Unk19_sortIndex = 1000;
            [SortOrder(Unk19_sortIndex)]
            [DisplayName(Unk19_displayName)]
            public virtual uint Unk19 {
                get => Unk19_raw;
                set {
                    if (Unk19_raw == value) return;
                    Unk19_raw = value;
                    ChangedItems.Add(nameof(Unk19));
                    OnPropertyChanged(nameof(Unk19));
                }
            }

            protected uint Unk21_raw;
            public const string Unk21_displayName = "Unk21";
            public const int Unk21_sortIndex = 1050;
            [SortOrder(Unk21_sortIndex)]
            [DisplayName(Unk21_displayName)]
            public virtual uint Unk21 {
                get => Unk21_raw;
                set {
                    if (Unk21_raw == value) return;
                    Unk21_raw = value;
                    ChangedItems.Add(nameof(Unk21));
                    OnPropertyChanged(nameof(Unk21));
                }
            }

            public const int lastSortIndex = 1100;

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
                data.Unk1_raw = reader.ReadUInt32();
                data.Unk2_raw = reader.ReadUInt32();
                data.Unk3_raw = reader.ReadUInt32();
                data.Unk4_raw = reader.ReadByte();
                data.Unk5_raw = reader.ReadByte();
                data.Unk6_raw = reader.ReadByte();
                data.Unk7_raw = reader.ReadByte();
                data.Unk8_raw = reader.ReadByte();
                data.Unk9_raw = reader.ReadByte();
                data.Unk10_raw = reader.ReadByte();
                data.Unk11_raw = reader.ReadByte();
                data.Unk12_raw = reader.ReadByte();
                data.Unk13_raw = reader.ReadByte();
                data.Unk14_raw = reader.ReadByte();
                data.Unk15_raw = reader.ReadInt32();
                data.Unk16_raw = reader.ReadUInt32();
                data.Unk17_raw = reader.ReadUInt16();
                data.Unk18_raw = reader.ReadUInt16();
                data.Unk19_raw = reader.ReadUInt32();
                data.Unk21_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Item_Id_raw);
                writer.Write(Unk1_raw);
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
                writer.Write(Unk15_raw);
                writer.Write(Unk16_raw);
                writer.Write(Unk17_raw);
                writer.Write(Unk18_raw);
                writer.Write(Unk19_raw);
                writer.Write(Unk21_raw);
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
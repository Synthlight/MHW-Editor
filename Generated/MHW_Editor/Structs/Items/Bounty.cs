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
    public partial class Bounty {
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
            public override string UniqueId => "{Id}";

            protected uint Id_raw;
            public const string Id_displayName = "Id";
            public const int Id_sortIndex = 50;
            [SortOrder(Id_sortIndex)]
            [DisplayName(Id_displayName)]
            [IsReadOnly]
            public virtual uint Id {
                get => Id_raw;
                set {
                    if (Id_raw == value) return;
                    Id_raw = value;
                    OnPropertyChanged(nameof(Id));
                }
            }

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
                    OnPropertyChanged(nameof(Unk1));
                }
            }

            protected byte Unk2_raw;
            public const string Unk2_displayName = "Unk2";
            public const int Unk2_sortIndex = 150;
            [SortOrder(Unk2_sortIndex)]
            [DisplayName(Unk2_displayName)]
            public virtual byte Unk2 {
                get => Unk2_raw;
                set {
                    if (Unk2_raw == value) return;
                    Unk2_raw = value;
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
                    OnPropertyChanged(nameof(Unk3));
                }
            }

            protected uint Unk4_raw;
            public const string Unk4_displayName = "Unk4";
            public const int Unk4_sortIndex = 250;
            [SortOrder(Unk4_sortIndex)]
            [DisplayName(Unk4_displayName)]
            public virtual uint Unk4 {
                get => Unk4_raw;
                set {
                    if (Unk4_raw == value) return;
                    Unk4_raw = value;
                    OnPropertyChanged(nameof(Unk4));
                }
            }

            protected int Unk5_raw;
            public const string Unk5_displayName = "Unk5";
            public const int Unk5_sortIndex = 300;
            [SortOrder(Unk5_sortIndex)]
            [DisplayName(Unk5_displayName)]
            public virtual int Unk5 {
                get => Unk5_raw;
                set {
                    if (Unk5_raw == value) return;
                    Unk5_raw = value;
                    OnPropertyChanged(nameof(Unk5));
                }
            }

            protected uint Rank_raw;
            public const string Rank_displayName = "Rank";
            public const int Rank_sortIndex = 350;
            [SortOrder(Rank_sortIndex)]
            [DisplayName(Rank_displayName)]
            public virtual MHW_Template.Items.RankType Rank {
                get => (MHW_Template.Items.RankType) Rank_raw;
                set {
                    if ((MHW_Template.Items.RankType) Rank_raw == value) return;
                    Rank_raw = (uint) value;
                    OnPropertyChanged(nameof(Rank));
                }
            }

            protected uint Type_raw;
            public const string Type_displayName = "Type";
            public const int Type_sortIndex = 400;
            [SortOrder(Type_sortIndex)]
            [DisplayName(Type_displayName)]
            public virtual MHW_Template.Items.BountyType Type {
                get => (MHW_Template.Items.BountyType) Type_raw;
                set {
                    if ((MHW_Template.Items.BountyType) Type_raw == value) return;
                    Type_raw = (uint) value;
                    OnPropertyChanged(nameof(Type));
                }
            }

            protected uint Unk8_raw;
            public const string Unk8_displayName = "Unk8";
            public const int Unk8_sortIndex = 450;
            [SortOrder(Unk8_sortIndex)]
            [DisplayName(Unk8_displayName)]
            public virtual uint Unk8 {
                get => Unk8_raw;
                set {
                    if (Unk8_raw == value) return;
                    Unk8_raw = value;
                    OnPropertyChanged(nameof(Unk8));
                }
            }

            protected int Monster_Type_raw;
            public const string Monster_Type_displayName = "Monster Type";
            public const int Monster_Type_sortIndex = 500;
            [SortOrder(Monster_Type_sortIndex)]
            [DisplayName(Monster_Type_displayName)]
            public virtual MHW_Template.Items.MonsterType Monster_Type {
                get => (MHW_Template.Items.MonsterType) Monster_Type_raw;
                set {
                    if ((MHW_Template.Items.MonsterType) Monster_Type_raw == value) return;
                    Monster_Type_raw = (int) value;
                    OnPropertyChanged(nameof(Monster_Type));
                }
            }

            protected uint Unk10_raw;
            public const string Unk10_displayName = "Unk10";
            public const int Unk10_sortIndex = 550;
            [SortOrder(Unk10_sortIndex)]
            [DisplayName(Unk10_displayName)]
            public virtual uint Unk10 {
                get => Unk10_raw;
                set {
                    if (Unk10_raw == value) return;
                    Unk10_raw = value;
                    OnPropertyChanged(nameof(Unk10));
                }
            }

            protected uint Map_raw;
            public const string Map_displayName = "Map";
            public const int Map_sortIndex = 600;
            [SortOrder(Map_sortIndex)]
            [DisplayName(Map_displayName)]
            public virtual MHW_Template.Items.Location Map {
                get => (MHW_Template.Items.Location) Map_raw;
                set {
                    if ((MHW_Template.Items.Location) Map_raw == value) return;
                    Map_raw = (uint) value;
                    OnPropertyChanged(nameof(Map));
                }
            }

            protected uint Target_Count_raw;
            public const string Target_Count_displayName = "Target Count";
            public const int Target_Count_sortIndex = 650;
            [SortOrder(Target_Count_sortIndex)]
            [DisplayName(Target_Count_displayName)]
            public virtual uint Target_Count {
                get => Target_Count_raw;
                set {
                    if (Target_Count_raw == value) return;
                    Target_Count_raw = value;
                    OnPropertyChanged(nameof(Target_Count));
                }
            }

            protected uint Item_Id_1_raw;
            public const string Item_Id_1_displayName = "Item Id 1";
            public const int Item_Id_1_sortIndex = 700;
            [SortOrder(Item_Id_1_sortIndex)]
            [DisplayName(Item_Id_1_displayName)]
            [DataSource(DataSourceType.Items)]
            public virtual uint Item_Id_1 {
                get => Item_Id_1_raw;
                set {
                    if (Item_Id_1_raw == value) return;
                    Item_Id_1_raw = value;
                    OnPropertyChanged(nameof(Item_Id_1));
                    OnPropertyChanged(nameof(Item_Id_1_button));
                }
            }

            [SortOrder(Item_Id_1_sortIndex)]
            [DisplayName(Item_Id_1_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Item_Id_1_button => DataHelper.itemNames[MainWindow.locale].TryGet(Item_Id_1).ToStringWithId(Item_Id_1);

            protected uint Item_Id_1_Cnt_raw;
            public const string Item_Id_1_Cnt_displayName = "Item Id 1 Cnt";
            public const int Item_Id_1_Cnt_sortIndex = 750;
            [SortOrder(Item_Id_1_Cnt_sortIndex)]
            [DisplayName(Item_Id_1_Cnt_displayName)]
            public virtual uint Item_Id_1_Cnt {
                get => Item_Id_1_Cnt_raw;
                set {
                    if (Item_Id_1_Cnt_raw == value) return;
                    Item_Id_1_Cnt_raw = value;
                    OnPropertyChanged(nameof(Item_Id_1_Cnt));
                }
            }

            protected uint Item_Id_2_raw;
            public const string Item_Id_2_displayName = "Item Id 2";
            public const int Item_Id_2_sortIndex = 800;
            [SortOrder(Item_Id_2_sortIndex)]
            [DisplayName(Item_Id_2_displayName)]
            [DataSource(DataSourceType.Items)]
            public virtual uint Item_Id_2 {
                get => Item_Id_2_raw;
                set {
                    if (Item_Id_2_raw == value) return;
                    Item_Id_2_raw = value;
                    OnPropertyChanged(nameof(Item_Id_2));
                    OnPropertyChanged(nameof(Item_Id_2_button));
                }
            }

            [SortOrder(Item_Id_2_sortIndex)]
            [DisplayName(Item_Id_2_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Item_Id_2_button => DataHelper.itemNames[MainWindow.locale].TryGet(Item_Id_2).ToStringWithId(Item_Id_2);

            protected uint Item_Id_2_Cnt_raw;
            public const string Item_Id_2_Cnt_displayName = "Item Id 2 Cnt";
            public const int Item_Id_2_Cnt_sortIndex = 850;
            [SortOrder(Item_Id_2_Cnt_sortIndex)]
            [DisplayName(Item_Id_2_Cnt_displayName)]
            public virtual uint Item_Id_2_Cnt {
                get => Item_Id_2_Cnt_raw;
                set {
                    if (Item_Id_2_Cnt_raw == value) return;
                    Item_Id_2_Cnt_raw = value;
                    OnPropertyChanged(nameof(Item_Id_2_Cnt));
                }
            }

            protected uint Item_Id_3_raw;
            public const string Item_Id_3_displayName = "Item Id 3";
            public const int Item_Id_3_sortIndex = 900;
            [SortOrder(Item_Id_3_sortIndex)]
            [DisplayName(Item_Id_3_displayName)]
            [DataSource(DataSourceType.Items)]
            public virtual uint Item_Id_3 {
                get => Item_Id_3_raw;
                set {
                    if (Item_Id_3_raw == value) return;
                    Item_Id_3_raw = value;
                    OnPropertyChanged(nameof(Item_Id_3));
                    OnPropertyChanged(nameof(Item_Id_3_button));
                }
            }

            [SortOrder(Item_Id_3_sortIndex)]
            [DisplayName(Item_Id_3_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Item_Id_3_button => DataHelper.itemNames[MainWindow.locale].TryGet(Item_Id_3).ToStringWithId(Item_Id_3);

            protected uint Item_Id_3_Cnt_raw;
            public const string Item_Id_3_Cnt_displayName = "Item Id 3 Cnt";
            public const int Item_Id_3_Cnt_sortIndex = 950;
            [SortOrder(Item_Id_3_Cnt_sortIndex)]
            [DisplayName(Item_Id_3_Cnt_displayName)]
            public virtual uint Item_Id_3_Cnt {
                get => Item_Id_3_Cnt_raw;
                set {
                    if (Item_Id_3_Cnt_raw == value) return;
                    Item_Id_3_Cnt_raw = value;
                    OnPropertyChanged(nameof(Item_Id_3_Cnt));
                }
            }

            protected uint Research_Points_raw;
            public const string Research_Points_displayName = "Research Points";
            public const int Research_Points_sortIndex = 1000;
            [SortOrder(Research_Points_sortIndex)]
            [DisplayName(Research_Points_displayName)]
            public virtual uint Research_Points {
                get => Research_Points_raw;
                set {
                    if (Research_Points_raw == value) return;
                    Research_Points_raw = value;
                    OnPropertyChanged(nameof(Research_Points));
                }
            }

            public const int lastSortIndex = 1050;

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
                data.Id_raw = reader.ReadUInt32();
                data.Unk1_raw = reader.ReadUInt32();
                data.Unk2_raw = reader.ReadByte();
                data.Unk3_raw = reader.ReadUInt32();
                data.Unk4_raw = reader.ReadUInt32();
                data.Unk5_raw = reader.ReadInt32();
                data.Rank_raw = reader.ReadUInt32();
                data.Type_raw = reader.ReadUInt32();
                data.Unk8_raw = reader.ReadUInt32();
                data.Monster_Type_raw = reader.ReadInt32();
                data.Unk10_raw = reader.ReadUInt32();
                data.Map_raw = reader.ReadUInt32();
                data.Target_Count_raw = reader.ReadUInt32();
                data.Item_Id_1_raw = reader.ReadUInt32();
                data.Item_Id_1_Cnt_raw = reader.ReadUInt32();
                data.Item_Id_2_raw = reader.ReadUInt32();
                data.Item_Id_2_Cnt_raw = reader.ReadUInt32();
                data.Item_Id_3_raw = reader.ReadUInt32();
                data.Item_Id_3_Cnt_raw = reader.ReadUInt32();
                data.Research_Points_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Id_raw);
                writer.Write(Unk1_raw);
                writer.Write(Unk2_raw);
                writer.Write(Unk3_raw);
                writer.Write(Unk4_raw);
                writer.Write(Unk5_raw);
                writer.Write(Rank_raw);
                writer.Write(Type_raw);
                writer.Write(Unk8_raw);
                writer.Write(Monster_Type_raw);
                writer.Write(Unk10_raw);
                writer.Write(Map_raw);
                writer.Write(Target_Count_raw);
                writer.Write(Item_Id_1_raw);
                writer.Write(Item_Id_1_Cnt_raw);
                writer.Write(Item_Id_2_raw);
                writer.Write(Item_Id_2_Cnt_raw);
                writer.Write(Item_Id_3_raw);
                writer.Write(Item_Id_3_Cnt_raw);
                writer.Write(Research_Points_raw);
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
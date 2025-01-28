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
                const ulong count = 1UL;
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
            public override string UniqueId => $"{Id}";
            public const bool IsAddingAllowed = true;

            [SortOrder(-1)]
            [IsReadOnly]
            [DisplayName("X")]
            public string Delete => "X";

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
                    ChangedItems.Add(nameof(Id));
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
                    ChangedItems.Add(nameof(Unk1));
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
                    ChangedItems.Add(nameof(Unk2));
                    OnPropertyChanged(nameof(Unk2));
                }
            }

            protected uint Unlock_Flag_1_raw;
            public const string Unlock_Flag_1_displayName = "Unlock Flag 1";
            public const int Unlock_Flag_1_sortIndex = 200;
            [SortOrder(Unlock_Flag_1_sortIndex)]
            [DisplayName(Unlock_Flag_1_displayName)]
            public virtual uint Unlock_Flag_1 {
                get => Unlock_Flag_1_raw;
                set {
                    if (Unlock_Flag_1_raw == value) return;
                    Unlock_Flag_1_raw = value;
                    ChangedItems.Add(nameof(Unlock_Flag_1));
                    OnPropertyChanged(nameof(Unlock_Flag_1));
                }
            }

            protected uint Unlock_Flag_2_raw;
            public const string Unlock_Flag_2_displayName = "Unlock Flag 2";
            public const int Unlock_Flag_2_sortIndex = 250;
            [SortOrder(Unlock_Flag_2_sortIndex)]
            [DisplayName(Unlock_Flag_2_displayName)]
            public virtual uint Unlock_Flag_2 {
                get => Unlock_Flag_2_raw;
                set {
                    if (Unlock_Flag_2_raw == value) return;
                    Unlock_Flag_2_raw = value;
                    ChangedItems.Add(nameof(Unlock_Flag_2));
                    OnPropertyChanged(nameof(Unlock_Flag_2));
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
                    ChangedItems.Add(nameof(Unk5));
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
                    ChangedItems.Add(nameof(Rank));
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
                    ChangedItems.Add(nameof(Type));
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
                    ChangedItems.Add(nameof(Unk8));
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
                    ChangedItems.Add(nameof(Monster_Type));
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
                    ChangedItems.Add(nameof(Unk10));
                    OnPropertyChanged(nameof(Unk10));
                }
            }

            protected uint Map_raw;
            public const string Map_displayName = "Map";
            public const int Map_sortIndex = 600;
            [SortOrder(Map_sortIndex)]
            [DisplayName(Map_displayName)]
            public virtual MHW_Template.Misc.Stage Map {
                get => (MHW_Template.Misc.Stage) Map_raw;
                set {
                    if ((MHW_Template.Misc.Stage) Map_raw == value) return;
                    Map_raw = (uint) value;
                    ChangedItems.Add(nameof(Map));
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
                    ChangedItems.Add(nameof(Target_Count));
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
                    ChangedItems.Add(nameof(Item_Id_1));
                    OnPropertyChanged(nameof(Item_Id_1));
                    OnPropertyChanged(nameof(Item_Id_1_button));
                }
            }

            [SortOrder(Item_Id_1_sortIndex)]
            [DisplayName(Item_Id_1_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Item_Id_1_button => DataHelper.itemNames[MainWindow.locale].TryGet(Item_Id_1).ToStringWithId(Item_Id_1);

            protected uint Item_Id_2_raw;
            public const string Item_Id_2_displayName = "Item Id 2";
            public const int Item_Id_2_sortIndex = 750;
            [SortOrder(Item_Id_2_sortIndex)]
            [DisplayName(Item_Id_2_displayName)]
            [DataSource(DataSourceType.Items)]
            public virtual uint Item_Id_2 {
                get => Item_Id_2_raw;
                set {
                    if (Item_Id_2_raw == value) return;
                    Item_Id_2_raw = value;
                    ChangedItems.Add(nameof(Item_Id_2));
                    OnPropertyChanged(nameof(Item_Id_2));
                    OnPropertyChanged(nameof(Item_Id_2_button));
                }
            }

            [SortOrder(Item_Id_2_sortIndex)]
            [DisplayName(Item_Id_2_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Item_Id_2_button => DataHelper.itemNames[MainWindow.locale].TryGet(Item_Id_2).ToStringWithId(Item_Id_2);

            protected uint Item_Id_3_raw;
            public const string Item_Id_3_displayName = "Item Id 3";
            public const int Item_Id_3_sortIndex = 800;
            [SortOrder(Item_Id_3_sortIndex)]
            [DisplayName(Item_Id_3_displayName)]
            [DataSource(DataSourceType.Items)]
            public virtual uint Item_Id_3 {
                get => Item_Id_3_raw;
                set {
                    if (Item_Id_3_raw == value) return;
                    Item_Id_3_raw = value;
                    ChangedItems.Add(nameof(Item_Id_3));
                    OnPropertyChanged(nameof(Item_Id_3));
                    OnPropertyChanged(nameof(Item_Id_3_button));
                }
            }

            [SortOrder(Item_Id_3_sortIndex)]
            [DisplayName(Item_Id_3_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Item_Id_3_button => DataHelper.itemNames[MainWindow.locale].TryGet(Item_Id_3).ToStringWithId(Item_Id_3);

            protected uint Item_Id_1_Cnt_raw;
            public const string Item_Id_1_Cnt_displayName = "Item Id 1 Cnt";
            public const int Item_Id_1_Cnt_sortIndex = 850;
            [SortOrder(Item_Id_1_Cnt_sortIndex)]
            [DisplayName(Item_Id_1_Cnt_displayName)]
            public virtual uint Item_Id_1_Cnt {
                get => Item_Id_1_Cnt_raw;
                set {
                    if (Item_Id_1_Cnt_raw == value) return;
                    Item_Id_1_Cnt_raw = value;
                    ChangedItems.Add(nameof(Item_Id_1_Cnt));
                    OnPropertyChanged(nameof(Item_Id_1_Cnt));
                }
            }

            protected uint Item_Id_2_Cnt_raw;
            public const string Item_Id_2_Cnt_displayName = "Item Id 2 Cnt";
            public const int Item_Id_2_Cnt_sortIndex = 900;
            [SortOrder(Item_Id_2_Cnt_sortIndex)]
            [DisplayName(Item_Id_2_Cnt_displayName)]
            public virtual uint Item_Id_2_Cnt {
                get => Item_Id_2_Cnt_raw;
                set {
                    if (Item_Id_2_Cnt_raw == value) return;
                    Item_Id_2_Cnt_raw = value;
                    ChangedItems.Add(nameof(Item_Id_2_Cnt));
                    OnPropertyChanged(nameof(Item_Id_2_Cnt));
                }
            }

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
                    ChangedItems.Add(nameof(Item_Id_3_Cnt));
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
                    ChangedItems.Add(nameof(Research_Points));
                    OnPropertyChanged(nameof(Research_Points));
                }
            }

            public const int lastSortIndex = 1050;

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
                data.Id_raw = reader.ReadUInt32();
                data.Unk1_raw = reader.ReadUInt32();
                data.Unk2_raw = reader.ReadByte();
                data.Unlock_Flag_1_raw = reader.ReadUInt32();
                data.Unlock_Flag_2_raw = reader.ReadUInt32();
                data.Unk5_raw = reader.ReadInt32();
                data.Rank_raw = reader.ReadUInt32();
                data.Type_raw = reader.ReadUInt32();
                data.Unk8_raw = reader.ReadUInt32();
                data.Monster_Type_raw = reader.ReadInt32();
                data.Unk10_raw = reader.ReadUInt32();
                data.Map_raw = reader.ReadUInt32();
                data.Target_Count_raw = reader.ReadUInt32();
                data.Item_Id_1_raw = reader.ReadUInt32();
                data.Item_Id_2_raw = reader.ReadUInt32();
                data.Item_Id_3_raw = reader.ReadUInt32();
                data.Item_Id_1_Cnt_raw = reader.ReadUInt32();
                data.Item_Id_2_Cnt_raw = reader.ReadUInt32();
                data.Item_Id_3_Cnt_raw = reader.ReadUInt32();
                data.Research_Points_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Id_raw);
                writer.Write(Unk1_raw);
                writer.Write(Unk2_raw);
                writer.Write(Unlock_Flag_1_raw);
                writer.Write(Unlock_Flag_2_raw);
                writer.Write(Unk5_raw);
                writer.Write(Rank_raw);
                writer.Write(Type_raw);
                writer.Write(Unk8_raw);
                writer.Write(Monster_Type_raw);
                writer.Write(Unk10_raw);
                writer.Write(Map_raw);
                writer.Write(Target_Count_raw);
                writer.Write(Item_Id_1_raw);
                writer.Write(Item_Id_2_raw);
                writer.Write(Item_Id_3_raw);
                writer.Write(Item_Id_1_Cnt_raw);
                writer.Write(Item_Id_2_Cnt_raw);
                writer.Write(Item_Id_3_Cnt_raw);
                writer.Write(Research_Points_raw);
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
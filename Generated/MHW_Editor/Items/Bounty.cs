
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Items {
    public partial class Bounty {
        public const uint StructSize = 77;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public const string EncryptionKey = null;
        public override string UniqueId => $"{Id}";

        public const string Id_displayName = "Id";
        public const int Id_sortIndex = 50;
        [SortOrder(Id_sortIndex)]
        [DisplayName(Id_displayName)]
        public virtual uint Id {
            get => GetData<uint>(0);
        }

        public const string Unk1_displayName = "Unk1";
        public const int Unk1_sortIndex = 100;
        [SortOrder(Unk1_sortIndex)]
        [DisplayName(Unk1_displayName)]
        public virtual uint Unk1 {
            get => GetData<uint>(4);
            set {
                if (GetData<uint>(4) == value) return;
                SetData(4, value, nameof(Unk1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk1));
            }
        }

        public const string Unk2_displayName = "Unk2";
        public const int Unk2_sortIndex = 150;
        [SortOrder(Unk2_sortIndex)]
        [DisplayName(Unk2_displayName)]
        public virtual byte Unk2 {
            get => GetData<byte>(8);
            set {
                if (GetData<byte>(8) == value) return;
                SetData(8, value, nameof(Unk2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk2));
            }
        }

        public const string Unk3_displayName = "Unk3";
        public const int Unk3_sortIndex = 200;
        [SortOrder(Unk3_sortIndex)]
        [DisplayName(Unk3_displayName)]
        public virtual uint Unk3 {
            get => GetData<uint>(9);
            set {
                if (GetData<uint>(9) == value) return;
                SetData(9, value, nameof(Unk3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk3));
            }
        }

        public const string Unk4_displayName = "Unk4";
        public const int Unk4_sortIndex = 250;
        [SortOrder(Unk4_sortIndex)]
        [DisplayName(Unk4_displayName)]
        public virtual uint Unk4 {
            get => GetData<uint>(13);
            set {
                if (GetData<uint>(13) == value) return;
                SetData(13, value, nameof(Unk4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk4));
            }
        }

        public const string Unk5_displayName = "Unk5";
        public const int Unk5_sortIndex = 300;
        [SortOrder(Unk5_sortIndex)]
        [DisplayName(Unk5_displayName)]
        public virtual int Unk5 {
            get => GetData<int>(17);
            set {
                if (GetData<int>(17) == value) return;
                SetData(17, value, nameof(Unk5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk5));
            }
        }

        public const string Rank_displayName = "Rank";
        public const int Rank_sortIndex = 350;
        [SortOrder(Rank_sortIndex)]
        [DisplayName(Rank_displayName)]
        public virtual MHW_Template.Items.RankType Rank {
            get => (MHW_Template.Items.RankType) GetData<uint>(21);
            set {
                if ((MHW_Template.Items.RankType) GetData<uint>(21) == value) return;
                SetData(21, (uint) value, nameof(Rank));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Rank));
            }
        }

        public const string Type_displayName = "Type";
        public const int Type_sortIndex = 400;
        [SortOrder(Type_sortIndex)]
        [DisplayName(Type_displayName)]
        public virtual MHW_Template.Items.BountyType Type {
            get => (MHW_Template.Items.BountyType) GetData<uint>(25);
            set {
                if ((MHW_Template.Items.BountyType) GetData<uint>(25) == value) return;
                SetData(25, (uint) value, nameof(Type));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Type));
            }
        }

        public const string Unk8_displayName = "Unk8";
        public const int Unk8_sortIndex = 450;
        [SortOrder(Unk8_sortIndex)]
        [DisplayName(Unk8_displayName)]
        public virtual uint Unk8 {
            get => GetData<uint>(29);
            set {
                if (GetData<uint>(29) == value) return;
                SetData(29, value, nameof(Unk8));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk8));
            }
        }

        public const string Monster_Type_displayName = "Monster Type";
        public const int Monster_Type_sortIndex = 500;
        [SortOrder(Monster_Type_sortIndex)]
        [DisplayName(Monster_Type_displayName)]
        public virtual MHW_Template.Items.MonsterType Monster_Type {
            get => (MHW_Template.Items.MonsterType) GetData<int>(33);
            set {
                if ((MHW_Template.Items.MonsterType) GetData<int>(33) == value) return;
                SetData(33, (int) value, nameof(Monster_Type));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Monster_Type));
            }
        }

        public const string Unk10_displayName = "Unk10";
        public const int Unk10_sortIndex = 550;
        [SortOrder(Unk10_sortIndex)]
        [DisplayName(Unk10_displayName)]
        public virtual uint Unk10 {
            get => GetData<uint>(37);
            set {
                if (GetData<uint>(37) == value) return;
                SetData(37, value, nameof(Unk10));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk10));
            }
        }

        public const string Map_displayName = "Map";
        public const int Map_sortIndex = 600;
        [SortOrder(Map_sortIndex)]
        [DisplayName(Map_displayName)]
        public virtual MHW_Template.Items.Location Map {
            get => (MHW_Template.Items.Location) GetData<uint>(41);
            set {
                if ((MHW_Template.Items.Location) GetData<uint>(41) == value) return;
                SetData(41, (uint) value, nameof(Map));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Map));
            }
        }

        public const string Target_Count_displayName = "Target Count";
        public const int Target_Count_sortIndex = 650;
        [SortOrder(Target_Count_sortIndex)]
        [DisplayName(Target_Count_displayName)]
        public virtual uint Target_Count {
            get => GetData<uint>(45);
            set {
                if (GetData<uint>(45) == value) return;
                SetData(45, value, nameof(Target_Count));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Target_Count));
            }
        }

        public const string Item_Id_1_displayName = "Item Id 1";
        public const int Item_Id_1_sortIndex = 700;
        [SortOrder(Item_Id_1_sortIndex)]
        [DisplayName(Item_Id_1_displayName)]
        [DataSource(DataSourceType.Items)]
        public virtual uint Item_Id_1 {
            get => GetData<uint>(49);
            set {
                if (GetData<uint>(49) == value) return;
                SetData(49, value, nameof(Item_Id_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_Id_1));
                OnPropertyChanged(nameof(Item_Id_1_button));
            }
        }

        [SortOrder(Item_Id_1_sortIndex)]
        [DisplayName(Item_Id_1_displayName)]
        [CustomSorter(typeof(UInt16Sorter))]
        public string Item_Id_1_button => DataHelper.itemData[MainWindow.locale].TryGet((ushort) Item_Id_1, IdNamePair.Unknown((ushort) Item_Id_1)).ToString();

        public const string Item_Id_1_Cnt_displayName = "Item Id 1 Cnt";
        public const int Item_Id_1_Cnt_sortIndex = 750;
        [SortOrder(Item_Id_1_Cnt_sortIndex)]
        [DisplayName(Item_Id_1_Cnt_displayName)]
        public virtual uint Item_Id_1_Cnt {
            get => GetData<uint>(61);
            set {
                if (GetData<uint>(61) == value) return;
                SetData(61, value, nameof(Item_Id_1_Cnt));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_Id_1_Cnt));
            }
        }

        public const string Item_Id_2_displayName = "Item Id 2";
        public const int Item_Id_2_sortIndex = 800;
        [SortOrder(Item_Id_2_sortIndex)]
        [DisplayName(Item_Id_2_displayName)]
        [DataSource(DataSourceType.Items)]
        public virtual uint Item_Id_2 {
            get => GetData<uint>(53);
            set {
                if (GetData<uint>(53) == value) return;
                SetData(53, value, nameof(Item_Id_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_Id_2));
                OnPropertyChanged(nameof(Item_Id_2_button));
            }
        }

        [SortOrder(Item_Id_2_sortIndex)]
        [DisplayName(Item_Id_2_displayName)]
        [CustomSorter(typeof(UInt16Sorter))]
        public string Item_Id_2_button => DataHelper.itemData[MainWindow.locale].TryGet((ushort) Item_Id_2, IdNamePair.Unknown((ushort) Item_Id_2)).ToString();

        public const string Item_Id_2_Cnt_displayName = "Item Id 2 Cnt";
        public const int Item_Id_2_Cnt_sortIndex = 850;
        [SortOrder(Item_Id_2_Cnt_sortIndex)]
        [DisplayName(Item_Id_2_Cnt_displayName)]
        public virtual uint Item_Id_2_Cnt {
            get => GetData<uint>(65);
            set {
                if (GetData<uint>(65) == value) return;
                SetData(65, value, nameof(Item_Id_2_Cnt));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_Id_2_Cnt));
            }
        }

        public const string Item_Id_3_displayName = "Item Id 3";
        public const int Item_Id_3_sortIndex = 900;
        [SortOrder(Item_Id_3_sortIndex)]
        [DisplayName(Item_Id_3_displayName)]
        [DataSource(DataSourceType.Items)]
        public virtual uint Item_Id_3 {
            get => GetData<uint>(57);
            set {
                if (GetData<uint>(57) == value) return;
                SetData(57, value, nameof(Item_Id_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_Id_3));
                OnPropertyChanged(nameof(Item_Id_3_button));
            }
        }

        [SortOrder(Item_Id_3_sortIndex)]
        [DisplayName(Item_Id_3_displayName)]
        [CustomSorter(typeof(UInt16Sorter))]
        public string Item_Id_3_button => DataHelper.itemData[MainWindow.locale].TryGet((ushort) Item_Id_3, IdNamePair.Unknown((ushort) Item_Id_3)).ToString();

        public const string Item_Id_3_Cnt_displayName = "Item Id 3 Cnt";
        public const int Item_Id_3_Cnt_sortIndex = 950;
        [SortOrder(Item_Id_3_Cnt_sortIndex)]
        [DisplayName(Item_Id_3_Cnt_displayName)]
        public virtual uint Item_Id_3_Cnt {
            get => GetData<uint>(69);
            set {
                if (GetData<uint>(69) == value) return;
                SetData(69, value, nameof(Item_Id_3_Cnt));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_Id_3_Cnt));
            }
        }

        public const string Research_Points_displayName = "Research Points";
        public const int Research_Points_sortIndex = 1000;
        [SortOrder(Research_Points_sortIndex)]
        [DisplayName(Research_Points_displayName)]
        public virtual uint Research_Points {
            get => GetData<uint>(72);
            set {
                if (GetData<uint>(72) == value) return;
                SetData(72, value, nameof(Research_Points));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Research_Points));
            }
        }

        public const int lastSortIndex = 1050;
    }
}
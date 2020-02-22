
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Armors {
    public partial class ASkill {
        public const uint StructSize = 28;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public const string EncryptionKey = null;
        public override string UniqueId => $"{Mantle_Id}";

        public const string Mantle_Id_displayName = "Mantle Id";
        public const int Mantle_Id_sortIndex = 50;
        [SortOrder(Mantle_Id_sortIndex)]
        [DisplayName(Mantle_Id_displayName)]
        public virtual uint Mantle_Id {
            get => GetData<uint>(16);
        }

        public const string Icon_Id_displayName = "Icon Id";
        public const int Icon_Id_sortIndex = 100;
        [SortOrder(Icon_Id_sortIndex)]
        [DisplayName(Icon_Id_displayName)]
        public virtual uint Icon_Id {
            get => GetData<uint>(0);
            set {
                if (GetData<uint>(0) == value) return;
                SetData(0, value, nameof(Icon_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Icon_Id));
            }
        }

        public const string Color_displayName = "Color";
        public const int Color_sortIndex = 150;
        [SortOrder(Color_sortIndex)]
        [DisplayName(Color_displayName)]
        public virtual uint Color {
            get => GetData<uint>(4);
            set {
                if (GetData<uint>(4) == value) return;
                SetData(4, value, nameof(Color));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Color));
            }
        }

        public const string Sort_Order_displayName = "Sort Order";
        public const int Sort_Order_sortIndex = 200;
        [SortOrder(Sort_Order_sortIndex)]
        [DisplayName(Sort_Order_displayName)]
        public virtual uint Sort_Order {
            get => GetData<uint>(8);
            set {
                if (GetData<uint>(8) == value) return;
                SetData(8, value, nameof(Sort_Order));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Sort_Order));
            }
        }

        public const string Mantle_Item_Id_displayName = "Mantle Item Id";
        public const int Mantle_Item_Id_sortIndex = 250;
        [SortOrder(Mantle_Item_Id_sortIndex)]
        [DisplayName(Mantle_Item_Id_displayName)]
        [DataSource(DataSourceType.Items)]
        public virtual uint Mantle_Item_Id {
            get => GetData<uint>(12);
            set {
                if (GetData<uint>(12) == value) return;
                SetData(12, value, nameof(Mantle_Item_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Mantle_Item_Id));
                OnPropertyChanged(nameof(Mantle_Item_Id_button));
            }
        }

        [SortOrder(Mantle_Item_Id_sortIndex)]
        [DisplayName(Mantle_Item_Id_displayName)]
        [CustomSorter(typeof(UInt16Sorter))]
        public string Mantle_Item_Id_button => DataHelper.itemData[MainWindow.locale].TryGet((ushort) Mantle_Item_Id, IdNamePair.Unknown((ushort) Mantle_Item_Id)).ToString();

        public const string Unlock_Flag_or_Item_Id__displayName = "Unlock Flag or Item Id?";
        public const int Unlock_Flag_or_Item_Id__sortIndex = 300;
        [SortOrder(Unlock_Flag_or_Item_Id__sortIndex)]
        [DisplayName(Unlock_Flag_or_Item_Id__displayName)]
        public virtual uint Unlock_Flag_or_Item_Id_ {
            get => GetData<uint>(20);
            set {
                if (GetData<uint>(20) == value) return;
                SetData(20, value, nameof(Unlock_Flag_or_Item_Id_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unlock_Flag_or_Item_Id_));
            }
        }

        public const string Deco_Count_displayName = "Deco Count";
        public const int Deco_Count_sortIndex = 350;
        [SortOrder(Deco_Count_sortIndex)]
        [DisplayName(Deco_Count_displayName)]
        public virtual byte Deco_Count {
            get => GetData<byte>(24);
            set {
                if (GetData<byte>(24) == value) return;
                SetData(24, value, nameof(Deco_Count));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Deco_Count));
            }
        }

        public const string Deco_Lvl_1_displayName = "Deco Lvl 1";
        public const int Deco_Lvl_1_sortIndex = 400;
        [SortOrder(Deco_Lvl_1_sortIndex)]
        [DisplayName(Deco_Lvl_1_displayName)]
        public virtual byte Deco_Lvl_1 {
            get => GetData<byte>(25);
            set {
                if (GetData<byte>(25) == value) return;
                SetData(25, value, nameof(Deco_Lvl_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Deco_Lvl_1));
            }
        }

        public const string Deco_Lvl_2_displayName = "Deco Lvl 2";
        public const int Deco_Lvl_2_sortIndex = 450;
        [SortOrder(Deco_Lvl_2_sortIndex)]
        [DisplayName(Deco_Lvl_2_displayName)]
        public virtual byte Deco_Lvl_2 {
            get => GetData<byte>(26);
            set {
                if (GetData<byte>(26) == value) return;
                SetData(26, value, nameof(Deco_Lvl_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Deco_Lvl_2));
            }
        }

        public const string Deco_Lvl_3_displayName = "Deco Lvl 3";
        public const int Deco_Lvl_3_sortIndex = 500;
        [SortOrder(Deco_Lvl_3_sortIndex)]
        [DisplayName(Deco_Lvl_3_displayName)]
        public virtual byte Deco_Lvl_3 {
            get => GetData<byte>(27);
            set {
                if (GetData<byte>(27) == value) return;
                SetData(27, value, nameof(Deco_Lvl_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Deco_Lvl_3));
            }
        }

        public const int lastSortIndex = 550;
    }
}
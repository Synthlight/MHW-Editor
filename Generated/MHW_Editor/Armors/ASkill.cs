using System.ComponentModel;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Armors {
    public partial class ASkill {
        public const uint StructSize = 28;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public const string EncryptionKey = null;

        public const string Mantle_Id_displayName = "Mantle Id";
        public const int Mantle_Id_sortIndex = 50;
        [SortOrder(Mantle_Id_sortIndex)]
        [DisplayName(Mantle_Id_displayName)]
        public uint Mantle_Id {
            get => GetData<uint>(16);
            set {
                if (GetData<uint>(16) == value) return;
                SetData(16, value);
                OnPropertyChanged(nameof(Mantle_Id));
            }
        }

        public const string Unknown_uint32__displayName = "Unknown (uint32)";
        public const int Unknown_uint32__sortIndex = 100;
        [SortOrder(Unknown_uint32__sortIndex)]
        [DisplayName(Unknown_uint32__displayName)]
        public uint Unknown_uint32_ {
            get => GetData<uint>(0);
            set {
                if (GetData<uint>(0) == value) return;
                SetData(0, value);
                OnPropertyChanged(nameof(Unknown_uint32_));
            }
        }

        public const string Color_displayName = "Color";
        public const int Color_sortIndex = 150;
        [SortOrder(Color_sortIndex)]
        [DisplayName(Color_displayName)]
        public uint Color {
            get => GetData<uint>(4);
            set {
                if (GetData<uint>(4) == value) return;
                SetData(4, value);
                OnPropertyChanged(nameof(Color));
            }
        }

        public const string Sort_Order_displayName = "Sort Order";
        public const int Sort_Order_sortIndex = 200;
        [SortOrder(Sort_Order_sortIndex)]
        [DisplayName(Sort_Order_displayName)]
        public uint Sort_Order {
            get => GetData<uint>(8);
            set {
                if (GetData<uint>(8) == value) return;
                SetData(8, value);
                OnPropertyChanged(nameof(Sort_Order));
            }
        }

        public const string Mantle_Item_Id_displayName = "Mantle Item Id";
        public const int Mantle_Item_Id_sortIndex = 250;
        [SortOrder(Mantle_Item_Id_sortIndex)]
        [DisplayName(Mantle_Item_Id_displayName)]
        [DataSource(DataSourceType.Items)]
        public uint Mantle_Item_Id {
            get => GetData<uint>(12);
            set {
                if (GetData<uint>(12) == value) return;
                SetData(12, value);
                OnPropertyChanged(nameof(Mantle_Item_Id));
            }
        }

        public const string Unlock_Flag_or_Item_Id__displayName = "Unlock Flag or Item Id?";
        public const int Unlock_Flag_or_Item_Id__sortIndex = 300;
        [SortOrder(Unlock_Flag_or_Item_Id__sortIndex)]
        [DisplayName(Unlock_Flag_or_Item_Id__displayName)]
        public uint Unlock_Flag_or_Item_Id_ {
            get => GetData<uint>(20);
            set {
                if (GetData<uint>(20) == value) return;
                SetData(20, value);
                OnPropertyChanged(nameof(Unlock_Flag_or_Item_Id_));
            }
        }

        public const string Deco_Count_displayName = "Deco Count";
        public const int Deco_Count_sortIndex = 350;
        [SortOrder(Deco_Count_sortIndex)]
        [DisplayName(Deco_Count_displayName)]
        public byte Deco_Count {
            get => GetData<byte>(24);
            set {
                if (GetData<byte>(24) == value) return;
                SetData(24, value);
                OnPropertyChanged(nameof(Deco_Count));
            }
        }

        public const string Deco_Lvl_1_displayName = "Deco Lvl 1";
        public const int Deco_Lvl_1_sortIndex = 400;
        [SortOrder(Deco_Lvl_1_sortIndex)]
        [DisplayName(Deco_Lvl_1_displayName)]
        public byte Deco_Lvl_1 {
            get => GetData<byte>(25);
            set {
                if (GetData<byte>(25) == value) return;
                SetData(25, value);
                OnPropertyChanged(nameof(Deco_Lvl_1));
            }
        }

        public const string Deco_Lvl_2_displayName = "Deco Lvl 2";
        public const int Deco_Lvl_2_sortIndex = 450;
        [SortOrder(Deco_Lvl_2_sortIndex)]
        [DisplayName(Deco_Lvl_2_displayName)]
        public byte Deco_Lvl_2 {
            get => GetData<byte>(26);
            set {
                if (GetData<byte>(26) == value) return;
                SetData(26, value);
                OnPropertyChanged(nameof(Deco_Lvl_2));
            }
        }

        public const string Deco_Lvl_3_displayName = "Deco Lvl 3";
        public const int Deco_Lvl_3_sortIndex = 500;
        [SortOrder(Deco_Lvl_3_sortIndex)]
        [DisplayName(Deco_Lvl_3_displayName)]
        public byte Deco_Lvl_3 {
            get => GetData<byte>(27);
            set {
                if (GetData<byte>(27) == value) return;
                SetData(27, value);
                OnPropertyChanged(nameof(Deco_Lvl_3));
            }
        }
    }
}
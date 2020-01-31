
using System.ComponentModel;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.Skills {
    public partial class ASkill {
        public const uint StructSize = 28;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        protected const string Mantle_Id_displayName = "Mantle Id";
        protected const int Mantle_Id_sortIndex = 50;
        [SortOrder(Mantle_Id_sortIndex)]
        [DisplayName(Mantle_Id_displayName)]
        public uint Mantle_Id {
            get => GetData<uint>(16);
            set {
                SetData(16, value);
                OnPropertyChanged(nameof(Mantle_Id));
            }
        }
        protected const string Unknown_uint32__displayName = "Unknown (uint32)";
        protected const int Unknown_uint32__sortIndex = 100;
        [SortOrder(Unknown_uint32__sortIndex)]
        [DisplayName(Unknown_uint32__displayName)]
        public uint Unknown_uint32_ {
            get => GetData<uint>(0);
            set {
                SetData(0, value);
                OnPropertyChanged(nameof(Unknown_uint32_));
            }
        }
        protected const string Color_displayName = "Color";
        protected const int Color_sortIndex = 150;
        [SortOrder(Color_sortIndex)]
        [DisplayName(Color_displayName)]
        public uint Color {
            get => GetData<uint>(4);
            set {
                SetData(4, value);
                OnPropertyChanged(nameof(Color));
            }
        }
        protected const string Sort_Order_displayName = "Sort Order";
        protected const int Sort_Order_sortIndex = 200;
        [SortOrder(Sort_Order_sortIndex)]
        [DisplayName(Sort_Order_displayName)]
        public uint Sort_Order {
            get => GetData<uint>(8);
            set {
                SetData(8, value);
                OnPropertyChanged(nameof(Sort_Order));
            }
        }
        protected const string Mantle_Item_Id_displayName = "Mantle Item Id";
        protected const int Mantle_Item_Id_sortIndex = 250;
        [SortOrder(Mantle_Item_Id_sortIndex)]
        [DisplayName(Mantle_Item_Id_displayName)]
        public uint Mantle_Item_Id {
            get => GetData<uint>(12);
            set {
                SetData(12, value);
                OnPropertyChanged(nameof(Mantle_Item_Id));
            }
        }
        protected const string Unlock_Flag_or_Item_Id__displayName = "Unlock Flag or Item Id?";
        protected const int Unlock_Flag_or_Item_Id__sortIndex = 300;
        [SortOrder(Unlock_Flag_or_Item_Id__sortIndex)]
        [DisplayName(Unlock_Flag_or_Item_Id__displayName)]
        public uint Unlock_Flag_or_Item_Id_ {
            get => GetData<uint>(20);
            set {
                SetData(20, value);
                OnPropertyChanged(nameof(Unlock_Flag_or_Item_Id_));
            }
        }
        protected const string Deco_Count_displayName = "Deco Count";
        protected const int Deco_Count_sortIndex = 350;
        [SortOrder(Deco_Count_sortIndex)]
        [DisplayName(Deco_Count_displayName)]
        public byte Deco_Count {
            get => GetData<byte>(24);
            set {
                SetData(24, value);
                OnPropertyChanged(nameof(Deco_Count));
            }
        }
        protected const string Deco_Lvl_1_displayName = "Deco Lvl 1";
        protected const int Deco_Lvl_1_sortIndex = 400;
        [SortOrder(Deco_Lvl_1_sortIndex)]
        [DisplayName(Deco_Lvl_1_displayName)]
        public byte Deco_Lvl_1 {
            get => GetData<byte>(25);
            set {
                SetData(25, value);
                OnPropertyChanged(nameof(Deco_Lvl_1));
            }
        }
        protected const string Deco_Lvl_2_displayName = "Deco Lvl 2";
        protected const int Deco_Lvl_2_sortIndex = 450;
        [SortOrder(Deco_Lvl_2_sortIndex)]
        [DisplayName(Deco_Lvl_2_displayName)]
        public byte Deco_Lvl_2 {
            get => GetData<byte>(26);
            set {
                SetData(26, value);
                OnPropertyChanged(nameof(Deco_Lvl_2));
            }
        }
        protected const string Deco_Lvl_3_displayName = "Deco Lvl 3";
        protected const int Deco_Lvl_3_sortIndex = 500;
        [SortOrder(Deco_Lvl_3_sortIndex)]
        [DisplayName(Deco_Lvl_3_displayName)]
        public byte Deco_Lvl_3 {
            get => GetData<byte>(27);
            set {
                SetData(27, value);
                OnPropertyChanged(nameof(Deco_Lvl_3));
            }
        }
    }
}
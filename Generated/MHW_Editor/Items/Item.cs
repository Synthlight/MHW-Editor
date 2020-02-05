
using System.ComponentModel;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Items {
    public partial class Item {
        public const uint StructSize = 32;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public const string EncryptionKey = null;

        protected const string Id_displayName = "Id";
        protected const int Id_sortIndex = 50;
        [SortOrder(Id_sortIndex)]
        [DisplayName(Id_displayName)]
        public uint Id {
            get => GetData<uint>(0);
        }

        protected const string Sub_Type_displayName = "Sub Type";
        protected const int Sub_Type_sortIndex = 100;
        [SortOrder(Sub_Type_sortIndex)]
        [DisplayName(Sub_Type_displayName)]
        public MHW_Template.Items.ItemSubType Sub_Type {
            get => (MHW_Template.Items.ItemSubType) GetData<byte>(4);
            set {
                if ((MHW_Template.Items.ItemSubType) GetData<byte>(4) == value) return;
                SetData(4, (byte) value);
                OnPropertyChanged(nameof(Sub_Type));
            }
        }

        protected const string Type_displayName = "Type";
        protected const int Type_sortIndex = 150;
        [SortOrder(Type_sortIndex)]
        [DisplayName(Type_displayName)]
        public MHW_Template.Items.ItemType Type {
            get => (MHW_Template.Items.ItemType) GetData<uint>(5);
            set {
                if ((MHW_Template.Items.ItemType) GetData<uint>(5) == value) return;
                SetData(5, (uint) value);
                OnPropertyChanged(nameof(Type));
            }
        }

        protected const string Rarity_displayName = "Rarity";
        protected const int Rarity_sortIndex = 200;
        [SortOrder(Rarity_sortIndex)]
        [DisplayName(Rarity_displayName)]
        public byte Rarity {
            get => GetData<byte>(9);
            set {
                if (GetData<byte>(9) == value) return;
                SetData(9, value);
                OnPropertyChanged(nameof(Rarity));
            }
        }

        protected const string Carry_Limit_displayName = "Carry Limit";
        protected const int Carry_Limit_sortIndex = 250;
        [SortOrder(Carry_Limit_sortIndex)]
        [DisplayName(Carry_Limit_displayName)]
        public byte Carry_Limit {
            get => GetData<byte>(10);
            set {
                if (GetData<byte>(10) == value) return;
                SetData(10, value);
                OnPropertyChanged(nameof(Carry_Limit));
            }
        }

        protected const string Unknown_uint8__displayName = "Unknown (uint8)";
        protected const int Unknown_uint8__sortIndex = 300;
        [SortOrder(Unknown_uint8__sortIndex)]
        [DisplayName(Unknown_uint8__displayName)]
        public byte Unknown_uint8_ {
            get => GetData<byte>(11);
            set {
                if (GetData<byte>(11) == value) return;
                SetData(11, value);
                OnPropertyChanged(nameof(Unknown_uint8_));
            }
        }

        protected const string Sort_Order_displayName = "Sort Order";
        protected const int Sort_Order_sortIndex = 350;
        [SortOrder(Sort_Order_sortIndex)]
        [DisplayName(Sort_Order_displayName)]
        public ushort Sort_Order {
            get => GetData<ushort>(12);
            set {
                if (GetData<ushort>(12) == value) return;
                SetData(12, value);
                OnPropertyChanged(nameof(Sort_Order));
            }
        }

        protected const string Icon_Id_displayName = "Icon Id";
        protected const int Icon_Id_sortIndex = 400;
        [SortOrder(Icon_Id_sortIndex)]
        [DisplayName(Icon_Id_displayName)]
        public uint Icon_Id {
            get => GetData<uint>(18);
            set {
                if (GetData<uint>(18) == value) return;
                SetData(18, value);
                OnPropertyChanged(nameof(Icon_Id));
            }
        }

        protected const string Icon_Color_Id_displayName = "Icon Color Id";
        protected const int Icon_Color_Id_sortIndex = 450;
        [SortOrder(Icon_Color_Id_sortIndex)]
        [DisplayName(Icon_Color_Id_displayName)]
        public ushort Icon_Color_Id {
            get => GetData<ushort>(22);
            set {
                if (GetData<ushort>(22) == value) return;
                SetData(22, value);
                OnPropertyChanged(nameof(Icon_Color_Id));
            }
        }

        protected const string Sell_Price_displayName = "Sell Price";
        protected const int Sell_Price_sortIndex = 500;
        [SortOrder(Sell_Price_sortIndex)]
        [DisplayName(Sell_Price_displayName)]
        public uint Sell_Price {
            get => GetData<uint>(24);
            set {
                if (GetData<uint>(24) == value) return;
                SetData(24, value);
                OnPropertyChanged(nameof(Sell_Price));
            }
        }

        protected const string Buy_Price_displayName = "Buy Price";
        protected const int Buy_Price_sortIndex = 550;
        [SortOrder(Buy_Price_sortIndex)]
        [DisplayName(Buy_Price_displayName)]
        public uint Buy_Price {
            get => GetData<uint>(28);
            set {
                if (GetData<uint>(28) == value) return;
                SetData(28, value);
                OnPropertyChanged(nameof(Buy_Price));
            }
        }

        protected const string Flags_Raw_displayName = "Flags Raw";
        protected const int Flags_Raw_sortIndex = 600;
        [SortOrder(Flags_Raw_sortIndex)]
        [DisplayName(Flags_Raw_displayName)]
        private uint Flags_Raw {
            get => GetData<uint>(14);
            set {
                if (GetData<uint>(14) == value) return;
                SetData(14, value);
                OnPropertyChanged(nameof(Flags_Raw));
            }
        }
    }
}
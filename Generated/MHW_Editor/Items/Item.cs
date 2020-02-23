using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Items {
    public partial class Item {
        public const uint StructSize = 32;
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

        public const string Sub_Type_displayName = "Sub Type";
        public const int Sub_Type_sortIndex = 100;
        [SortOrder(Sub_Type_sortIndex)]
        [DisplayName(Sub_Type_displayName)]
        public virtual MHW_Template.Items.ItemSubType Sub_Type {
            get => (MHW_Template.Items.ItemSubType) GetData<byte>(4);
            set {
                if ((MHW_Template.Items.ItemSubType) GetData<byte>(4) == value) return;
                SetData(4, (byte) value, nameof(Sub_Type));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Sub_Type));
            }
        }

        public const string Type_displayName = "Type";
        public const int Type_sortIndex = 150;
        [SortOrder(Type_sortIndex)]
        [DisplayName(Type_displayName)]
        public virtual MHW_Template.Items.ItemType Type {
            get => (MHW_Template.Items.ItemType) GetData<uint>(5);
            set {
                if ((MHW_Template.Items.ItemType) GetData<uint>(5) == value) return;
                SetData(5, (uint) value, nameof(Type));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Type));
            }
        }

        public const string Rarity_displayName = "Rarity";
        public const int Rarity_sortIndex = 200;
        [SortOrder(Rarity_sortIndex)]
        [DisplayName(Rarity_displayName)]
        public virtual byte Rarity {
            get => GetData<byte>(9);
            set {
                if (GetData<byte>(9) == value) return;
                SetData(9, value, nameof(Rarity));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Rarity));
            }
        }

        public const string Carry_Limit_displayName = "Carry Limit";
        public const int Carry_Limit_sortIndex = 250;
        [SortOrder(Carry_Limit_sortIndex)]
        [DisplayName(Carry_Limit_displayName)]
        public virtual byte Carry_Limit {
            get => GetData<byte>(10);
            set {
                if (GetData<byte>(10) == value) return;
                SetData(10, value, nameof(Carry_Limit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Carry_Limit));
            }
        }

        public const string Unknown_uint8__displayName = "Unknown (uint8)";
        public const int Unknown_uint8__sortIndex = 300;
        [SortOrder(Unknown_uint8__sortIndex)]
        [DisplayName(Unknown_uint8__displayName)]
        public virtual byte Unknown_uint8_ {
            get => GetData<byte>(11);
            set {
                if (GetData<byte>(11) == value) return;
                SetData(11, value, nameof(Unknown_uint8_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unknown_uint8_));
            }
        }

        public const string Sort_Order_displayName = "Sort Order";
        public const int Sort_Order_sortIndex = 350;
        [SortOrder(Sort_Order_sortIndex)]
        [DisplayName(Sort_Order_displayName)]
        public virtual ushort Sort_Order {
            get => GetData<ushort>(12);
            set {
                if (GetData<ushort>(12) == value) return;
                SetData(12, value, nameof(Sort_Order));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Sort_Order));
            }
        }

        public const string Icon_Id_displayName = "Icon Id";
        public const int Icon_Id_sortIndex = 400;
        [SortOrder(Icon_Id_sortIndex)]
        [DisplayName(Icon_Id_displayName)]
        public virtual uint Icon_Id {
            get => GetData<uint>(18);
            set {
                if (GetData<uint>(18) == value) return;
                SetData(18, value, nameof(Icon_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Icon_Id));
            }
        }

        public const string Icon_Color_Id_displayName = "Icon Color Id";
        public const int Icon_Color_Id_sortIndex = 450;
        [SortOrder(Icon_Color_Id_sortIndex)]
        [DisplayName(Icon_Color_Id_displayName)]
        public virtual ushort Icon_Color_Id {
            get => GetData<ushort>(22);
            set {
                if (GetData<ushort>(22) == value) return;
                SetData(22, value, nameof(Icon_Color_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Icon_Color_Id));
            }
        }

        public const string Sell_Price_displayName = "Sell Price";
        public const int Sell_Price_sortIndex = 500;
        [SortOrder(Sell_Price_sortIndex)]
        [DisplayName(Sell_Price_displayName)]
        public virtual uint Sell_Price {
            get => GetData<uint>(24);
            set {
                if (GetData<uint>(24) == value) return;
                SetData(24, value, nameof(Sell_Price));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Sell_Price));
            }
        }

        public const string Buy_Price_displayName = "Buy Price";
        public const int Buy_Price_sortIndex = 550;
        [SortOrder(Buy_Price_sortIndex)]
        [DisplayName(Buy_Price_displayName)]
        public virtual uint Buy_Price {
            get => GetData<uint>(28);
            set {
                if (GetData<uint>(28) == value) return;
                SetData(28, value, nameof(Buy_Price));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Buy_Price));
            }
        }

        public const string Flags_Raw_displayName = "Flags Raw";
        public const int Flags_Raw_sortIndex = 600;
        [SortOrder(Flags_Raw_sortIndex)]
        [DisplayName(Flags_Raw_displayName)]
        private uint Flags_Raw {
            get => GetData<uint>(14);
            set {
                if (GetData<uint>(14) == value) return;
                SetData(14, value, nameof(Flags_Raw));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Flags_Raw));
                OnPropertyChanged(nameof(Flags));
            }
        }

        public const int lastSortIndex = 650;
    }
}
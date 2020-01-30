
using System.ComponentModel;
using MHW_Template;

namespace MHW_Editor.Items {
    public partial class Item {
        public const uint StructSize = 32;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        [DisplayName("Id")]
        public uint Id {
            get => GetData<uint>(0);
        }
        [DisplayName("Sub Type")]
        public MHW_Template.Items.ItemSubType Sub_Type {
            get => (MHW_Template.Items.ItemSubType) GetData<byte>(4);
            set {
                SetData(4, (byte) value);
                OnPropertyChanged(nameof(Sub_Type));
            }
        }
        [DisplayName("Type")]
        public MHW_Template.Items.ItemType Type {
            get => (MHW_Template.Items.ItemType) GetData<uint>(5);
            set {
                SetData(5, (uint) value);
                OnPropertyChanged(nameof(Type));
            }
        }
        [DisplayName("Rarity")]
        public byte Rarity {
            get => GetData<byte>(9);
            set {
                SetData(9, value);
                OnPropertyChanged(nameof(Rarity));
            }
        }
        [DisplayName("Carry Limit")]
        public byte Carry_Limit {
            get => GetData<byte>(10);
            set {
                SetData(10, value);
                OnPropertyChanged(nameof(Carry_Limit));
            }
        }
        [DisplayName("Unknown (uint16)")]
        public byte Unknown_uint16_ {
            get => GetData<byte>(11);
            set {
                SetData(11, value);
                OnPropertyChanged(nameof(Unknown_uint16_));
            }
        }
        [DisplayName("Sort Order")]
        public ushort Sort_Order {
            get => GetData<ushort>(12);
            set {
                SetData(12, value);
                OnPropertyChanged(nameof(Sort_Order));
            }
        }
        [DisplayName("Flags Raw")]
        private uint Flags_Raw {
            get => GetData<uint>(14);
            set {
                SetData(14, value);
                OnPropertyChanged(nameof(Flags_Raw));
            }
        }
        [DisplayName("Icon Id")]
        public uint Icon_Id {
            get => GetData<uint>(18);
            set {
                SetData(18, value);
                OnPropertyChanged(nameof(Icon_Id));
            }
        }
        [DisplayName("Icon Color Id")]
        public ushort Icon_Color_Id {
            get => GetData<ushort>(22);
            set {
                SetData(22, value);
                OnPropertyChanged(nameof(Icon_Color_Id));
            }
        }
        [DisplayName("Sell Price")]
        public uint Sell_Price {
            get => GetData<uint>(24);
            set {
                SetData(24, value);
                OnPropertyChanged(nameof(Sell_Price));
            }
        }
        [DisplayName("Buy Price")]
        public uint Buy_Price {
            get => GetData<uint>(28);
            set {
                SetData(28, value);
                OnPropertyChanged(nameof(Buy_Price));
            }
        }
    }
}
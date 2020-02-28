using System;
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Items {
    public partial class RoomFurniture {
        public const uint StructSize = 47;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public const string EncryptionKey = null;
        public override string UniqueId => $"{Index}";

        public const string Item_Id_displayName = "Item Id";
        public const int Item_Id_sortIndex = 50;
        [SortOrder(Item_Id_sortIndex)]
        [DisplayName(Item_Id_displayName)]
        [DataSource(DataSourceType.Items)]
        public virtual uint Item_Id {
            get => GetData<uint>(0);
            set {
                if (GetData<uint>(0) == value) return;
                SetData(0, value, nameof(Item_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_Id));
                OnPropertyChanged(nameof(Item_Id_button));
            }
        }

        [SortOrder(Item_Id_sortIndex)]
        [DisplayName(Item_Id_displayName)]
        [CustomSorter(typeof(ButtonSorter))]
        public string Item_Id_button => DataHelper.itemNames[MainWindow.locale].TryGet(Item_Id).ToStringWithId(Item_Id);

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
        public virtual uint Unk2 {
            get => GetData<uint>(8);
            set {
                if (GetData<uint>(8) == value) return;
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
            get => GetData<uint>(12);
            set {
                if (GetData<uint>(12) == value) return;
                SetData(12, value, nameof(Unk3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk3));
            }
        }

        public const string Unk4_displayName = "Unk4";
        public const int Unk4_sortIndex = 250;
        [SortOrder(Unk4_sortIndex)]
        [DisplayName(Unk4_displayName)]
        public virtual bool Unk4 {
            get => (bool) Convert.ToBoolean(GetData<byte>(16));
            set {
                if (Convert.ToBoolean(GetData<byte>(16)) == value) return;
                SetData(16, Convert.ToByte(value), nameof(Unk4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk4));
            }
        }

        public const string Unk5_displayName = "Unk5";
        public const int Unk5_sortIndex = 300;
        [SortOrder(Unk5_sortIndex)]
        [DisplayName(Unk5_displayName)]
        public virtual byte Unk5 {
            get => GetData<byte>(17);
            set {
                if (GetData<byte>(17) == value) return;
                SetData(17, value, nameof(Unk5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk5));
            }
        }

        public const string Unk6_displayName = "Unk6";
        public const int Unk6_sortIndex = 350;
        [SortOrder(Unk6_sortIndex)]
        [DisplayName(Unk6_displayName)]
        public virtual bool Unk6 {
            get => (bool) Convert.ToBoolean(GetData<byte>(18));
            set {
                if (Convert.ToBoolean(GetData<byte>(18)) == value) return;
                SetData(18, Convert.ToByte(value), nameof(Unk6));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk6));
            }
        }

        public const string Unk7_displayName = "Unk7";
        public const int Unk7_sortIndex = 400;
        [SortOrder(Unk7_sortIndex)]
        [DisplayName(Unk7_displayName)]
        public virtual bool Unk7 {
            get => (bool) Convert.ToBoolean(GetData<byte>(19));
            set {
                if (Convert.ToBoolean(GetData<byte>(19)) == value) return;
                SetData(19, Convert.ToByte(value), nameof(Unk7));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk7));
            }
        }

        public const string Unk8_displayName = "Unk8";
        public const int Unk8_sortIndex = 450;
        [SortOrder(Unk8_sortIndex)]
        [DisplayName(Unk8_displayName)]
        public virtual bool Unk8 {
            get => (bool) Convert.ToBoolean(GetData<byte>(20));
            set {
                if (Convert.ToBoolean(GetData<byte>(20)) == value) return;
                SetData(20, Convert.ToByte(value), nameof(Unk8));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk8));
            }
        }

        public const string Unk9_displayName = "Unk9";
        public const int Unk9_sortIndex = 500;
        [SortOrder(Unk9_sortIndex)]
        [DisplayName(Unk9_displayName)]
        public virtual bool Unk9 {
            get => (bool) Convert.ToBoolean(GetData<byte>(21));
            set {
                if (Convert.ToBoolean(GetData<byte>(21)) == value) return;
                SetData(21, Convert.ToByte(value), nameof(Unk9));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk9));
            }
        }

        public const string Unk10_displayName = "Unk10";
        public const int Unk10_sortIndex = 550;
        [SortOrder(Unk10_sortIndex)]
        [DisplayName(Unk10_displayName)]
        public virtual bool Unk10 {
            get => (bool) Convert.ToBoolean(GetData<byte>(22));
            set {
                if (Convert.ToBoolean(GetData<byte>(22)) == value) return;
                SetData(22, Convert.ToByte(value), nameof(Unk10));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk10));
            }
        }

        public const string Unk11_displayName = "Unk11";
        public const int Unk11_sortIndex = 600;
        [SortOrder(Unk11_sortIndex)]
        [DisplayName(Unk11_displayName)]
        public virtual bool Unk11 {
            get => (bool) Convert.ToBoolean(GetData<byte>(23));
            set {
                if (Convert.ToBoolean(GetData<byte>(23)) == value) return;
                SetData(23, Convert.ToByte(value), nameof(Unk11));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk11));
            }
        }

        public const string Unk12_displayName = "Unk12";
        public const int Unk12_sortIndex = 650;
        [SortOrder(Unk12_sortIndex)]
        [DisplayName(Unk12_displayName)]
        public virtual bool Unk12 {
            get => (bool) Convert.ToBoolean(GetData<byte>(24));
            set {
                if (Convert.ToBoolean(GetData<byte>(24)) == value) return;
                SetData(24, Convert.ToByte(value), nameof(Unk12));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk12));
            }
        }

        public const string Unk13_displayName = "Unk13";
        public const int Unk13_sortIndex = 700;
        [SortOrder(Unk13_sortIndex)]
        [DisplayName(Unk13_displayName)]
        public virtual bool Unk13 {
            get => (bool) Convert.ToBoolean(GetData<byte>(25));
            set {
                if (Convert.ToBoolean(GetData<byte>(25)) == value) return;
                SetData(25, Convert.ToByte(value), nameof(Unk13));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk13));
            }
        }

        public const string Unk14_displayName = "Unk14";
        public const int Unk14_sortIndex = 750;
        [SortOrder(Unk14_sortIndex)]
        [DisplayName(Unk14_displayName)]
        public virtual bool Unk14 {
            get => (bool) Convert.ToBoolean(GetData<byte>(26));
            set {
                if (Convert.ToBoolean(GetData<byte>(26)) == value) return;
                SetData(26, Convert.ToByte(value), nameof(Unk14));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk14));
            }
        }

        public const string Unk15_displayName = "Unk15";
        public const int Unk15_sortIndex = 800;
        [SortOrder(Unk15_sortIndex)]
        [DisplayName(Unk15_displayName)]
        public virtual int Unk15 {
            get => GetData<int>(27);
            set {
                if (GetData<int>(27) == value) return;
                SetData(27, value, nameof(Unk15));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk15));
            }
        }

        public const string Unk16_displayName = "Unk16";
        public const int Unk16_sortIndex = 850;
        [SortOrder(Unk16_sortIndex)]
        [DisplayName(Unk16_displayName)]
        public virtual uint Unk16 {
            get => GetData<uint>(31);
            set {
                if (GetData<uint>(31) == value) return;
                SetData(31, value, nameof(Unk16));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk16));
            }
        }

        public const string Unk17_displayName = "Unk17";
        public const int Unk17_sortIndex = 900;
        [SortOrder(Unk17_sortIndex)]
        [DisplayName(Unk17_displayName)]
        public virtual ushort Unk17 {
            get => GetData<ushort>(35);
            set {
                if (GetData<ushort>(35) == value) return;
                SetData(35, value, nameof(Unk17));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk17));
            }
        }

        public const string Unk18_displayName = "Unk18";
        public const int Unk18_sortIndex = 950;
        [SortOrder(Unk18_sortIndex)]
        [DisplayName(Unk18_displayName)]
        public virtual ushort Unk18 {
            get => GetData<ushort>(37);
            set {
                if (GetData<ushort>(37) == value) return;
                SetData(37, value, nameof(Unk18));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk18));
            }
        }

        public const string Unk19_displayName = "Unk19";
        public const int Unk19_sortIndex = 1000;
        [SortOrder(Unk19_sortIndex)]
        [DisplayName(Unk19_displayName)]
        public virtual uint Unk19 {
            get => GetData<uint>(39);
            set {
                if (GetData<uint>(39) == value) return;
                SetData(39, value, nameof(Unk19));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk19));
            }
        }

        public const string Unk21_displayName = "Unk21";
        public const int Unk21_sortIndex = 1050;
        [SortOrder(Unk21_sortIndex)]
        [DisplayName(Unk21_displayName)]
        public virtual uint Unk21 {
            get => GetData<uint>(43);
            set {
                if (GetData<uint>(43) == value) return;
                SetData(43, value, nameof(Unk21));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk21));
            }
        }

        public const int lastSortIndex = 1100;
    }
}
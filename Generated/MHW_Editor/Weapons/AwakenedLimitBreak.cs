using System;
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Weapons {
    public partial class AwakenedLimitBreak {
        public const uint StructSize = 45;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public const string EncryptionKey = null;
        public override string UniqueId => $"{Index}";

        public const string Unk1_displayName = "Unk1";
        public const int Unk1_sortIndex = 50;
        [SortOrder(Unk1_sortIndex)]
        [DisplayName(Unk1_displayName)]
        public virtual ushort Unk1 {
            get => GetData<ushort>(0);
            set {
                if (GetData<ushort>(0) == value) return;
                SetData(0, value, nameof(Unk1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk1));
            }
        }

        public const string Unk2_displayName = "Unk2";
        public const int Unk2_sortIndex = 100;
        [SortOrder(Unk2_sortIndex)]
        [DisplayName(Unk2_displayName)]
        public virtual uint Unk2 {
            get => GetData<uint>(2);
            set {
                if (GetData<uint>(2) == value) return;
                SetData(2, value, nameof(Unk2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk2));
            }
        }

        public const string Unk3_displayName = "Unk3";
        public const int Unk3_sortIndex = 150;
        [SortOrder(Unk3_sortIndex)]
        [DisplayName(Unk3_displayName)]
        public virtual uint Unk3 {
            get => GetData<uint>(6);
            set {
                if (GetData<uint>(6) == value) return;
                SetData(6, value, nameof(Unk3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk3));
            }
        }

        public const string Unk4_displayName = "Unk4";
        public const int Unk4_sortIndex = 200;
        [SortOrder(Unk4_sortIndex)]
        [DisplayName(Unk4_displayName)]
        public virtual bool Unk4 {
            get => (bool) Convert.ToBoolean(GetData<byte>(10));
            set {
                if (Convert.ToBoolean(GetData<byte>(10)) == value) return;
                SetData(10, Convert.ToByte(value), nameof(Unk4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk4));
            }
        }

        public const string Unk5_displayName = "Unk5";
        public const int Unk5_sortIndex = 250;
        [SortOrder(Unk5_sortIndex)]
        [DisplayName(Unk5_displayName)]
        public virtual ushort Unk5 {
            get => GetData<ushort>(11);
            set {
                if (GetData<ushort>(11) == value) return;
                SetData(11, value, nameof(Unk5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk5));
            }
        }

        public const string Unk6_displayName = "Unk6";
        public const int Unk6_sortIndex = 300;
        [SortOrder(Unk6_sortIndex)]
        [DisplayName(Unk6_displayName)]
        public virtual ushort Unk6 {
            get => GetData<ushort>(13);
            set {
                if (GetData<ushort>(13) == value) return;
                SetData(13, value, nameof(Unk6));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk6));
            }
        }

        public const string Unk7_displayName = "Unk7";
        public const int Unk7_sortIndex = 350;
        [SortOrder(Unk7_sortIndex)]
        [DisplayName(Unk7_displayName)]
        public virtual bool Unk7 {
            get => (bool) Convert.ToBoolean(GetData<byte>(15));
            set {
                if (Convert.ToBoolean(GetData<byte>(15)) == value) return;
                SetData(15, Convert.ToByte(value), nameof(Unk7));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk7));
            }
        }

        public const string Unk8_displayName = "Unk8";
        public const int Unk8_sortIndex = 400;
        [SortOrder(Unk8_sortIndex)]
        [DisplayName(Unk8_displayName)]
        public virtual bool Unk8 {
            get => (bool) Convert.ToBoolean(GetData<byte>(16));
            set {
                if (Convert.ToBoolean(GetData<byte>(16)) == value) return;
                SetData(16, Convert.ToByte(value), nameof(Unk8));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk8));
            }
        }

        public const string Unk9_displayName = "Unk9";
        public const int Unk9_sortIndex = 450;
        [SortOrder(Unk9_sortIndex)]
        [DisplayName(Unk9_displayName)]
        public virtual ushort Unk9 {
            get => GetData<ushort>(17);
            set {
                if (GetData<ushort>(17) == value) return;
                SetData(17, value, nameof(Unk9));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk9));
            }
        }

        public const string Unk10_displayName = "Unk10";
        public const int Unk10_sortIndex = 500;
        [SortOrder(Unk10_sortIndex)]
        [DisplayName(Unk10_displayName)]
        public virtual ushort Unk10 {
            get => GetData<ushort>(19);
            set {
                if (GetData<ushort>(19) == value) return;
                SetData(19, value, nameof(Unk10));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk10));
            }
        }

        public const string Unk11_displayName = "Unk11";
        public const int Unk11_sortIndex = 550;
        [SortOrder(Unk11_sortIndex)]
        [DisplayName(Unk11_displayName)]
        public virtual ushort Unk11 {
            get => GetData<ushort>(21);
            set {
                if (GetData<ushort>(21) == value) return;
                SetData(21, value, nameof(Unk11));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk11));
            }
        }

        public const string Unk12_displayName = "Unk12";
        public const int Unk12_sortIndex = 600;
        [SortOrder(Unk12_sortIndex)]
        [DisplayName(Unk12_displayName)]
        public virtual ushort Unk12 {
            get => GetData<ushort>(23);
            set {
                if (GetData<ushort>(23) == value) return;
                SetData(23, value, nameof(Unk12));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk12));
            }
        }

        public const string Unk13_displayName = "Unk13";
        public const int Unk13_sortIndex = 650;
        [SortOrder(Unk13_sortIndex)]
        [DisplayName(Unk13_displayName)]
        public virtual ushort Unk13 {
            get => GetData<ushort>(25);
            set {
                if (GetData<ushort>(25) == value) return;
                SetData(25, value, nameof(Unk13));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk13));
            }
        }

        public const string Unk14_displayName = "Unk14";
        public const int Unk14_sortIndex = 700;
        [SortOrder(Unk14_sortIndex)]
        [DisplayName(Unk14_displayName)]
        public virtual bool Unk14 {
            get => (bool) Convert.ToBoolean(GetData<byte>(27));
            set {
                if (Convert.ToBoolean(GetData<byte>(27)) == value) return;
                SetData(27, Convert.ToByte(value), nameof(Unk14));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk14));
            }
        }

        public const string Unk15_displayName = "Unk15";
        public const int Unk15_sortIndex = 750;
        [SortOrder(Unk15_sortIndex)]
        [DisplayName(Unk15_displayName)]
        public virtual bool Unk15 {
            get => (bool) Convert.ToBoolean(GetData<byte>(28));
            set {
                if (Convert.ToBoolean(GetData<byte>(28)) == value) return;
                SetData(28, Convert.ToByte(value), nameof(Unk15));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk15));
            }
        }

        public const string Unk16_displayName = "Unk16";
        public const int Unk16_sortIndex = 800;
        [SortOrder(Unk16_sortIndex)]
        [DisplayName(Unk16_displayName)]
        public virtual bool Unk16 {
            get => (bool) Convert.ToBoolean(GetData<byte>(29));
            set {
                if (Convert.ToBoolean(GetData<byte>(29)) == value) return;
                SetData(29, Convert.ToByte(value), nameof(Unk16));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk16));
            }
        }

        public const string Unk17_displayName = "Unk17";
        public const int Unk17_sortIndex = 850;
        [SortOrder(Unk17_sortIndex)]
        [DisplayName(Unk17_displayName)]
        public virtual bool Unk17 {
            get => (bool) Convert.ToBoolean(GetData<byte>(30));
            set {
                if (Convert.ToBoolean(GetData<byte>(30)) == value) return;
                SetData(30, Convert.ToByte(value), nameof(Unk17));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk17));
            }
        }

        public const string Unk18_displayName = "Unk18";
        public const int Unk18_sortIndex = 900;
        [SortOrder(Unk18_sortIndex)]
        [DisplayName(Unk18_displayName)]
        public virtual bool Unk18 {
            get => (bool) Convert.ToBoolean(GetData<byte>(31));
            set {
                if (Convert.ToBoolean(GetData<byte>(31)) == value) return;
                SetData(31, Convert.ToByte(value), nameof(Unk18));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk18));
            }
        }

        public const string Unk19_displayName = "Unk19";
        public const int Unk19_sortIndex = 950;
        [SortOrder(Unk19_sortIndex)]
        [DisplayName(Unk19_displayName)]
        public virtual bool Unk19 {
            get => (bool) Convert.ToBoolean(GetData<byte>(32));
            set {
                if (Convert.ToBoolean(GetData<byte>(32)) == value) return;
                SetData(32, Convert.ToByte(value), nameof(Unk19));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk19));
            }
        }

        public const string Unk20_displayName = "Unk20";
        public const int Unk20_sortIndex = 1000;
        [SortOrder(Unk20_sortIndex)]
        [DisplayName(Unk20_displayName)]
        public virtual bool Unk20 {
            get => (bool) Convert.ToBoolean(GetData<byte>(33));
            set {
                if (Convert.ToBoolean(GetData<byte>(33)) == value) return;
                SetData(33, Convert.ToByte(value), nameof(Unk20));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk20));
            }
        }

        public const string Unk21_displayName = "Unk21";
        public const int Unk21_sortIndex = 1050;
        [SortOrder(Unk21_sortIndex)]
        [DisplayName(Unk21_displayName)]
        public virtual bool Unk21 {
            get => (bool) Convert.ToBoolean(GetData<byte>(34));
            set {
                if (Convert.ToBoolean(GetData<byte>(34)) == value) return;
                SetData(34, Convert.ToByte(value), nameof(Unk21));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk21));
            }
        }

        public const string Unk22_displayName = "Unk22";
        public const int Unk22_sortIndex = 1100;
        [SortOrder(Unk22_sortIndex)]
        [DisplayName(Unk22_displayName)]
        public virtual bool Unk22 {
            get => (bool) Convert.ToBoolean(GetData<byte>(35));
            set {
                if (Convert.ToBoolean(GetData<byte>(35)) == value) return;
                SetData(35, Convert.ToByte(value), nameof(Unk22));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk22));
            }
        }

        public const string Unk23_displayName = "Unk23";
        public const int Unk23_sortIndex = 1150;
        [SortOrder(Unk23_sortIndex)]
        [DisplayName(Unk23_displayName)]
        public virtual bool Unk23 {
            get => (bool) Convert.ToBoolean(GetData<byte>(36));
            set {
                if (Convert.ToBoolean(GetData<byte>(36)) == value) return;
                SetData(36, Convert.ToByte(value), nameof(Unk23));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk23));
            }
        }

        public const string Unk24_displayName = "Unk24";
        public const int Unk24_sortIndex = 1200;
        [SortOrder(Unk24_sortIndex)]
        [DisplayName(Unk24_displayName)]
        public virtual bool Unk24 {
            get => (bool) Convert.ToBoolean(GetData<byte>(37));
            set {
                if (Convert.ToBoolean(GetData<byte>(37)) == value) return;
                SetData(37, Convert.ToByte(value), nameof(Unk24));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk24));
            }
        }

        public const string Unk25_displayName = "Unk25";
        public const int Unk25_sortIndex = 1250;
        [SortOrder(Unk25_sortIndex)]
        [DisplayName(Unk25_displayName)]
        public virtual bool Unk25 {
            get => (bool) Convert.ToBoolean(GetData<byte>(38));
            set {
                if (Convert.ToBoolean(GetData<byte>(38)) == value) return;
                SetData(38, Convert.ToByte(value), nameof(Unk25));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk25));
            }
        }

        public const string Unk26_displayName = "Unk26";
        public const int Unk26_sortIndex = 1300;
        [SortOrder(Unk26_sortIndex)]
        [DisplayName(Unk26_displayName)]
        public virtual bool Unk26 {
            get => (bool) Convert.ToBoolean(GetData<byte>(39));
            set {
                if (Convert.ToBoolean(GetData<byte>(39)) == value) return;
                SetData(39, Convert.ToByte(value), nameof(Unk26));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk26));
            }
        }

        public const string Unk27_displayName = "Unk27";
        public const int Unk27_sortIndex = 1350;
        [SortOrder(Unk27_sortIndex)]
        [DisplayName(Unk27_displayName)]
        public virtual bool Unk27 {
            get => (bool) Convert.ToBoolean(GetData<byte>(40));
            set {
                if (Convert.ToBoolean(GetData<byte>(40)) == value) return;
                SetData(40, Convert.ToByte(value), nameof(Unk27));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk27));
            }
        }

        public const string Unk28_displayName = "Unk28";
        public const int Unk28_sortIndex = 1400;
        [SortOrder(Unk28_sortIndex)]
        [DisplayName(Unk28_displayName)]
        public virtual byte Unk28 {
            get => GetData<byte>(44);
            set {
                if (GetData<byte>(44) == value) return;
                SetData(44, value, nameof(Unk28));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk28));
            }
        }

        public const int lastSortIndex = 1450;
    }
}
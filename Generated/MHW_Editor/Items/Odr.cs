using System.ComponentModel;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Items {
    public partial class Odr {
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

        public const string Unk6_displayName = "Unk6";
        public const int Unk6_sortIndex = 350;
        [SortOrder(Unk6_sortIndex)]
        [DisplayName(Unk6_displayName)]
        public virtual uint Unk6 {
            get => GetData<uint>(21);
            set {
                if (GetData<uint>(21) == value) return;
                SetData(21, value, nameof(Unk6));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk6));
            }
        }

        public const string Unk7_displayName = "Unk7";
        public const int Unk7_sortIndex = 400;
        [SortOrder(Unk7_sortIndex)]
        [DisplayName(Unk7_displayName)]
        public virtual uint Unk7 {
            get => GetData<uint>(25);
            set {
                if (GetData<uint>(25) == value) return;
                SetData(25, value, nameof(Unk7));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk7));
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

        public const string Unk9_displayName = "Unk9";
        public const int Unk9_sortIndex = 500;
        [SortOrder(Unk9_sortIndex)]
        [DisplayName(Unk9_displayName)]
        public virtual int Unk9 {
            get => GetData<int>(33);
            set {
                if (GetData<int>(33) == value) return;
                SetData(33, value, nameof(Unk9));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk9));
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

        public const string Unk11_displayName = "Unk11";
        public const int Unk11_sortIndex = 600;
        [SortOrder(Unk11_sortIndex)]
        [DisplayName(Unk11_displayName)]
        public virtual uint Unk11 {
            get => GetData<uint>(41);
            set {
                if (GetData<uint>(41) == value) return;
                SetData(41, value, nameof(Unk11));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk11));
            }
        }

        public const string Unk12_displayName = "Unk12";
        public const int Unk12_sortIndex = 650;
        [SortOrder(Unk12_sortIndex)]
        [DisplayName(Unk12_displayName)]
        public virtual uint Unk12 {
            get => GetData<uint>(45);
            set {
                if (GetData<uint>(45) == value) return;
                SetData(45, value, nameof(Unk12));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk12));
            }
        }

        public const string Unk13_displayName = "Unk13";
        public const int Unk13_sortIndex = 700;
        [SortOrder(Unk13_sortIndex)]
        [DisplayName(Unk13_displayName)]
        public virtual uint Unk13 {
            get => GetData<uint>(49);
            set {
                if (GetData<uint>(49) == value) return;
                SetData(49, value, nameof(Unk13));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk13));
            }
        }

        public const string Unk14_displayName = "Unk14";
        public const int Unk14_sortIndex = 750;
        [SortOrder(Unk14_sortIndex)]
        [DisplayName(Unk14_displayName)]
        public virtual uint Unk14 {
            get => GetData<uint>(53);
            set {
                if (GetData<uint>(53) == value) return;
                SetData(53, value, nameof(Unk14));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk14));
            }
        }

        public const string Unk15_displayName = "Unk15";
        public const int Unk15_sortIndex = 800;
        [SortOrder(Unk15_sortIndex)]
        [DisplayName(Unk15_displayName)]
        public virtual uint Unk15 {
            get => GetData<uint>(57);
            set {
                if (GetData<uint>(57) == value) return;
                SetData(57, value, nameof(Unk15));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk15));
            }
        }

        public const string Unk16_displayName = "Unk16";
        public const int Unk16_sortIndex = 850;
        [SortOrder(Unk16_sortIndex)]
        [DisplayName(Unk16_displayName)]
        public virtual uint Unk16 {
            get => GetData<uint>(61);
            set {
                if (GetData<uint>(61) == value) return;
                SetData(61, value, nameof(Unk16));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk16));
            }
        }

        public const string Unk17_displayName = "Unk17";
        public const int Unk17_sortIndex = 900;
        [SortOrder(Unk17_sortIndex)]
        [DisplayName(Unk17_displayName)]
        public virtual uint Unk17 {
            get => GetData<uint>(65);
            set {
                if (GetData<uint>(65) == value) return;
                SetData(65, value, nameof(Unk17));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk17));
            }
        }

        public const string Unk18_displayName = "Unk18";
        public const int Unk18_sortIndex = 950;
        [SortOrder(Unk18_sortIndex)]
        [DisplayName(Unk18_displayName)]
        public virtual uint Unk18 {
            get => GetData<uint>(69);
            set {
                if (GetData<uint>(69) == value) return;
                SetData(69, value, nameof(Unk18));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk18));
            }
        }

        public const string Unk19_displayName = "Unk19";
        public const int Unk19_sortIndex = 1000;
        [SortOrder(Unk19_sortIndex)]
        [DisplayName(Unk19_displayName)]
        public virtual uint Unk19 {
            get => GetData<uint>(72);
            set {
                if (GetData<uint>(72) == value) return;
                SetData(72, value, nameof(Unk19));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk19));
            }
        }

        public const int lastSortIndex = 1050;
    }
}
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.PlData {
    public partial class PlPlayerParam {
        public const uint StructSize = 20640;
        public const ulong InitialOffset = 0;
        public const long EntryCountOffset = -1;
        public const string EncryptionKey = "j1P15gEkgVa7NdFxiqwCPitykHctY2nZPjSaElvqb0eSwcLO1cOlTqqv";
        public override string UniqueId => $"0";

        public const string Unk1_displayName = "Unk1";
        public const int Unk1_sortIndex = 50;
        [SortOrder(Unk1_sortIndex)]
        [DisplayName(Unk1_displayName)]
        public virtual float Unk1 {
            get => GetData<float>(8);
            set {
                if (GetData<float>(8) == value) return;
                SetData(8, value, nameof(Unk1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk1));
            }
        }

        public const string Unk2_displayName = "Unk2";
        public const int Unk2_sortIndex = 100;
        [SortOrder(Unk2_sortIndex)]
        [DisplayName(Unk2_displayName)]
        public virtual float Unk2 {
            get => GetData<float>(12);
            set {
                if (GetData<float>(12) == value) return;
                SetData(12, value, nameof(Unk2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk2));
            }
        }

        public const string Unk3_displayName = "Unk3";
        public const int Unk3_sortIndex = 150;
        [SortOrder(Unk3_sortIndex)]
        [DisplayName(Unk3_displayName)]
        public virtual float Unk3 {
            get => GetData<float>(16);
            set {
                if (GetData<float>(16) == value) return;
                SetData(16, value, nameof(Unk3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk3));
            }
        }

        public const string Unk4_displayName = "Unk4";
        public const int Unk4_sortIndex = 200;
        [SortOrder(Unk4_sortIndex)]
        [DisplayName(Unk4_displayName)]
        public virtual float Unk4 {
            get => GetData<float>(20);
            set {
                if (GetData<float>(20) == value) return;
                SetData(20, value, nameof(Unk4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk4));
            }
        }

        public const string Unk5_displayName = "Unk5";
        public const int Unk5_sortIndex = 250;
        [SortOrder(Unk5_sortIndex)]
        [DisplayName(Unk5_displayName)]
        public virtual float Unk5 {
            get => GetData<float>(24);
            set {
                if (GetData<float>(24) == value) return;
                SetData(24, value, nameof(Unk5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk5));
            }
        }

        public const string Unk6_displayName = "Unk6";
        public const int Unk6_sortIndex = 300;
        [SortOrder(Unk6_sortIndex)]
        [DisplayName(Unk6_displayName)]
        public virtual float Unk6 {
            get => GetData<float>(28);
            set {
                if (GetData<float>(28) == value) return;
                SetData(28, value, nameof(Unk6));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk6));
            }
        }

        public const string Unk7_displayName = "Unk7";
        public const int Unk7_sortIndex = 350;
        [SortOrder(Unk7_sortIndex)]
        [DisplayName(Unk7_displayName)]
        public virtual float Unk7 {
            get => GetData<float>(32);
            set {
                if (GetData<float>(32) == value) return;
                SetData(32, value, nameof(Unk7));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk7));
            }
        }

        public const string Unk8_displayName = "Unk8";
        public const int Unk8_sortIndex = 400;
        [SortOrder(Unk8_sortIndex)]
        [DisplayName(Unk8_displayName)]
        public virtual float Unk8 {
            get => GetData<float>(36);
            set {
                if (GetData<float>(36) == value) return;
                SetData(36, value, nameof(Unk8));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk8));
            }
        }

        public const string Unk9_displayName = "Unk9";
        public const int Unk9_sortIndex = 450;
        [SortOrder(Unk9_sortIndex)]
        [DisplayName(Unk9_displayName)]
        public virtual float Unk9 {
            get => GetData<float>(40);
            set {
                if (GetData<float>(40) == value) return;
                SetData(40, value, nameof(Unk9));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk9));
            }
        }

        public const string Unk10_displayName = "Unk10";
        public const int Unk10_sortIndex = 500;
        [SortOrder(Unk10_sortIndex)]
        [DisplayName(Unk10_displayName)]
        public virtual float Unk10 {
            get => GetData<float>(44);
            set {
                if (GetData<float>(44) == value) return;
                SetData(44, value, nameof(Unk10));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk10));
            }
        }

        public const string Unk11_displayName = "Unk11";
        public const int Unk11_sortIndex = 550;
        [SortOrder(Unk11_sortIndex)]
        [DisplayName(Unk11_displayName)]
        public virtual float Unk11 {
            get => GetData<float>(48);
            set {
                if (GetData<float>(48) == value) return;
                SetData(48, value, nameof(Unk11));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk11));
            }
        }

        public const string Unk12_displayName = "Unk12";
        public const int Unk12_sortIndex = 600;
        [SortOrder(Unk12_sortIndex)]
        [DisplayName(Unk12_displayName)]
        public virtual float Unk12 {
            get => GetData<float>(52);
            set {
                if (GetData<float>(52) == value) return;
                SetData(52, value, nameof(Unk12));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk12));
            }
        }

        public const string Unk13_displayName = "Unk13";
        public const int Unk13_sortIndex = 650;
        [SortOrder(Unk13_sortIndex)]
        [DisplayName(Unk13_displayName)]
        public virtual float Unk13 {
            get => GetData<float>(56);
            set {
                if (GetData<float>(56) == value) return;
                SetData(56, value, nameof(Unk13));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk13));
            }
        }

        public const string Unk14_displayName = "Unk14";
        public const int Unk14_sortIndex = 700;
        [SortOrder(Unk14_sortIndex)]
        [DisplayName(Unk14_displayName)]
        public virtual float Unk14 {
            get => GetData<float>(60);
            set {
                if (GetData<float>(60) == value) return;
                SetData(60, value, nameof(Unk14));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk14));
            }
        }

        public const string Unk15_displayName = "Unk15";
        public const int Unk15_sortIndex = 750;
        [SortOrder(Unk15_sortIndex)]
        [DisplayName(Unk15_displayName)]
        public virtual float Unk15 {
            get => GetData<float>(64);
            set {
                if (GetData<float>(64) == value) return;
                SetData(64, value, nameof(Unk15));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk15));
            }
        }

        public const string Unk16_displayName = "Unk16";
        public const int Unk16_sortIndex = 800;
        [SortOrder(Unk16_sortIndex)]
        [DisplayName(Unk16_displayName)]
        public virtual float Unk16 {
            get => GetData<float>(68);
            set {
                if (GetData<float>(68) == value) return;
                SetData(68, value, nameof(Unk16));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk16));
            }
        }

        public const string Unk17_displayName = "Unk17";
        public const int Unk17_sortIndex = 850;
        [SortOrder(Unk17_sortIndex)]
        [DisplayName(Unk17_displayName)]
        public virtual float Unk17 {
            get => GetData<float>(72);
            set {
                if (GetData<float>(72) == value) return;
                SetData(72, value, nameof(Unk17));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk17));
            }
        }

        public const string Unk18_displayName = "Unk18";
        public const int Unk18_sortIndex = 900;
        [SortOrder(Unk18_sortIndex)]
        [DisplayName(Unk18_displayName)]
        public virtual float Unk18 {
            get => GetData<float>(76);
            set {
                if (GetData<float>(76) == value) return;
                SetData(76, value, nameof(Unk18));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk18));
            }
        }

        public const string Unk19_displayName = "Unk19";
        public const int Unk19_sortIndex = 950;
        [SortOrder(Unk19_sortIndex)]
        [DisplayName(Unk19_displayName)]
        public virtual float Unk19 {
            get => GetData<float>(80);
            set {
                if (GetData<float>(80) == value) return;
                SetData(80, value, nameof(Unk19));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk19));
            }
        }

        public const string Unk20_displayName = "Unk20";
        public const int Unk20_sortIndex = 1000;
        [SortOrder(Unk20_sortIndex)]
        [DisplayName(Unk20_displayName)]
        public virtual float Unk20 {
            get => GetData<float>(84);
            set {
                if (GetData<float>(84) == value) return;
                SetData(84, value, nameof(Unk20));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk20));
            }
        }

        public const string Unk21_displayName = "Unk21";
        public const int Unk21_sortIndex = 1050;
        [SortOrder(Unk21_sortIndex)]
        [DisplayName(Unk21_displayName)]
        public virtual float Unk21 {
            get => GetData<float>(88);
            set {
                if (GetData<float>(88) == value) return;
                SetData(88, value, nameof(Unk21));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk21));
            }
        }

        public const string Unk22_displayName = "Unk22";
        public const int Unk22_sortIndex = 1100;
        [SortOrder(Unk22_sortIndex)]
        [DisplayName(Unk22_displayName)]
        public virtual float Unk22 {
            get => GetData<float>(92);
            set {
                if (GetData<float>(92) == value) return;
                SetData(92, value, nameof(Unk22));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk22));
            }
        }

        public const string Unk23_displayName = "Unk23";
        public const int Unk23_sortIndex = 1150;
        [SortOrder(Unk23_sortIndex)]
        [DisplayName(Unk23_displayName)]
        public virtual float Unk23 {
            get => GetData<float>(96);
            set {
                if (GetData<float>(96) == value) return;
                SetData(96, value, nameof(Unk23));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk23));
            }
        }

        public const string Unk24_displayName = "Unk24";
        public const int Unk24_sortIndex = 1200;
        [SortOrder(Unk24_sortIndex)]
        [DisplayName(Unk24_displayName)]
        public virtual float Unk24 {
            get => GetData<float>(100);
            set {
                if (GetData<float>(100) == value) return;
                SetData(100, value, nameof(Unk24));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk24));
            }
        }

        public const string Unk25_displayName = "Unk25";
        public const int Unk25_sortIndex = 1250;
        [SortOrder(Unk25_sortIndex)]
        [DisplayName(Unk25_displayName)]
        public virtual float Unk25 {
            get => GetData<float>(104);
            set {
                if (GetData<float>(104) == value) return;
                SetData(104, value, nameof(Unk25));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk25));
            }
        }

        public const string Unk26_displayName = "Unk26";
        public const int Unk26_sortIndex = 1300;
        [SortOrder(Unk26_sortIndex)]
        [DisplayName(Unk26_displayName)]
        public virtual float Unk26 {
            get => GetData<float>(108);
            set {
                if (GetData<float>(108) == value) return;
                SetData(108, value, nameof(Unk26));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk26));
            }
        }

        public const string Unk27_displayName = "Unk27";
        public const int Unk27_sortIndex = 1350;
        [SortOrder(Unk27_sortIndex)]
        [DisplayName(Unk27_displayName)]
        public virtual float Unk27 {
            get => GetData<float>(112);
            set {
                if (GetData<float>(112) == value) return;
                SetData(112, value, nameof(Unk27));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk27));
            }
        }

        public const string Unk28_displayName = "Unk28";
        public const int Unk28_sortIndex = 1400;
        [SortOrder(Unk28_sortIndex)]
        [DisplayName(Unk28_displayName)]
        public virtual float Unk28 {
            get => GetData<float>(116);
            set {
                if (GetData<float>(116) == value) return;
                SetData(116, value, nameof(Unk28));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk28));
            }
        }

        public const string Unk29_displayName = "Unk29";
        public const int Unk29_sortIndex = 1450;
        [SortOrder(Unk29_sortIndex)]
        [DisplayName(Unk29_displayName)]
        public virtual float Unk29 {
            get => GetData<float>(120);
            set {
                if (GetData<float>(120) == value) return;
                SetData(120, value, nameof(Unk29));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk29));
            }
        }

        public const string Unk30_displayName = "Unk30";
        public const int Unk30_sortIndex = 1500;
        [SortOrder(Unk30_sortIndex)]
        [DisplayName(Unk30_displayName)]
        public virtual float Unk30 {
            get => GetData<float>(124);
            set {
                if (GetData<float>(124) == value) return;
                SetData(124, value, nameof(Unk30));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk30));
            }
        }

        public const string Unk31_displayName = "Unk31";
        public const int Unk31_sortIndex = 1550;
        [SortOrder(Unk31_sortIndex)]
        [DisplayName(Unk31_displayName)]
        public virtual float Unk31 {
            get => GetData<float>(128);
            set {
                if (GetData<float>(128) == value) return;
                SetData(128, value, nameof(Unk31));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk31));
            }
        }

        public const string Unk32_displayName = "Unk32";
        public const int Unk32_sortIndex = 1600;
        [SortOrder(Unk32_sortIndex)]
        [DisplayName(Unk32_displayName)]
        public virtual float Unk32 {
            get => GetData<float>(132);
            set {
                if (GetData<float>(132) == value) return;
                SetData(132, value, nameof(Unk32));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk32));
            }
        }

        public const string Unk33_displayName = "Unk33";
        public const int Unk33_sortIndex = 1650;
        [SortOrder(Unk33_sortIndex)]
        [DisplayName(Unk33_displayName)]
        public virtual float Unk33 {
            get => GetData<float>(136);
            set {
                if (GetData<float>(136) == value) return;
                SetData(136, value, nameof(Unk33));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk33));
            }
        }

        public const string Unk34_displayName = "Unk34";
        public const int Unk34_sortIndex = 1700;
        [SortOrder(Unk34_sortIndex)]
        [DisplayName(Unk34_displayName)]
        public virtual float Unk34 {
            get => GetData<float>(140);
            set {
                if (GetData<float>(140) == value) return;
                SetData(140, value, nameof(Unk34));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk34));
            }
        }

        public const string Unk35_displayName = "Unk35";
        public const int Unk35_sortIndex = 1750;
        [SortOrder(Unk35_sortIndex)]
        [DisplayName(Unk35_displayName)]
        public virtual float Unk35 {
            get => GetData<float>(144);
            set {
                if (GetData<float>(144) == value) return;
                SetData(144, value, nameof(Unk35));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk35));
            }
        }

        public const string Unk36_displayName = "Unk36";
        public const int Unk36_sortIndex = 1800;
        [SortOrder(Unk36_sortIndex)]
        [DisplayName(Unk36_displayName)]
        public virtual float Unk36 {
            get => GetData<float>(148);
            set {
                if (GetData<float>(148) == value) return;
                SetData(148, value, nameof(Unk36));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk36));
            }
        }

        public const string Unk37_displayName = "Unk37";
        public const int Unk37_sortIndex = 1850;
        [SortOrder(Unk37_sortIndex)]
        [DisplayName(Unk37_displayName)]
        public virtual uint Unk37 {
            get => GetData<uint>(152);
            set {
                if (GetData<uint>(152) == value) return;
                SetData(152, value, nameof(Unk37));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk37));
            }
        }

        public const string Unk38_displayName = "Unk38";
        public const int Unk38_sortIndex = 1900;
        [SortOrder(Unk38_sortIndex)]
        [DisplayName(Unk38_displayName)]
        public virtual uint Unk38 {
            get => GetData<uint>(156);
            set {
                if (GetData<uint>(156) == value) return;
                SetData(156, value, nameof(Unk38));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk38));
            }
        }

        public const string Unk39_displayName = "Unk39";
        public const int Unk39_sortIndex = 1950;
        [SortOrder(Unk39_sortIndex)]
        [DisplayName(Unk39_displayName)]
        public virtual float Unk39 {
            get => GetData<float>(160);
            set {
                if (GetData<float>(160) == value) return;
                SetData(160, value, nameof(Unk39));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk39));
            }
        }

        public const string Unk40_displayName = "Unk40";
        public const int Unk40_sortIndex = 2000;
        [SortOrder(Unk40_sortIndex)]
        [DisplayName(Unk40_displayName)]
        public virtual float Unk40 {
            get => GetData<float>(164);
            set {
                if (GetData<float>(164) == value) return;
                SetData(164, value, nameof(Unk40));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk40));
            }
        }

        public const string Unk41_displayName = "Unk41";
        public const int Unk41_sortIndex = 2050;
        [SortOrder(Unk41_sortIndex)]
        [DisplayName(Unk41_displayName)]
        public virtual float Unk41 {
            get => GetData<float>(168);
            set {
                if (GetData<float>(168) == value) return;
                SetData(168, value, nameof(Unk41));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk41));
            }
        }

        public const string Unk42_displayName = "Unk42";
        public const int Unk42_sortIndex = 2100;
        [SortOrder(Unk42_sortIndex)]
        [DisplayName(Unk42_displayName)]
        public virtual float Unk42 {
            get => GetData<float>(172);
            set {
                if (GetData<float>(172) == value) return;
                SetData(172, value, nameof(Unk42));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk42));
            }
        }

        public const string Unk43_displayName = "Unk43";
        public const int Unk43_sortIndex = 2150;
        [SortOrder(Unk43_sortIndex)]
        [DisplayName(Unk43_displayName)]
        public virtual float Unk43 {
            get => GetData<float>(176);
            set {
                if (GetData<float>(176) == value) return;
                SetData(176, value, nameof(Unk43));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk43));
            }
        }

        public const string Unk44_displayName = "Unk44";
        public const int Unk44_sortIndex = 2200;
        [SortOrder(Unk44_sortIndex)]
        [DisplayName(Unk44_displayName)]
        public virtual float Unk44 {
            get => GetData<float>(180);
            set {
                if (GetData<float>(180) == value) return;
                SetData(180, value, nameof(Unk44));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk44));
            }
        }

        public const string Unk45_displayName = "Unk45";
        public const int Unk45_sortIndex = 2250;
        [SortOrder(Unk45_sortIndex)]
        [DisplayName(Unk45_displayName)]
        public virtual float Unk45 {
            get => GetData<float>(184);
            set {
                if (GetData<float>(184) == value) return;
                SetData(184, value, nameof(Unk45));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk45));
            }
        }

        public const string Unk46_displayName = "Unk46";
        public const int Unk46_sortIndex = 2300;
        [SortOrder(Unk46_sortIndex)]
        [DisplayName(Unk46_displayName)]
        public virtual float Unk46 {
            get => GetData<float>(188);
            set {
                if (GetData<float>(188) == value) return;
                SetData(188, value, nameof(Unk46));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk46));
            }
        }

        public const string Unk47_displayName = "Unk47";
        public const int Unk47_sortIndex = 2350;
        [SortOrder(Unk47_sortIndex)]
        [DisplayName(Unk47_displayName)]
        public virtual float Unk47 {
            get => GetData<float>(192);
            set {
                if (GetData<float>(192) == value) return;
                SetData(192, value, nameof(Unk47));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk47));
            }
        }

        public const string Unk48_displayName = "Unk48";
        public const int Unk48_sortIndex = 2400;
        [SortOrder(Unk48_sortIndex)]
        [DisplayName(Unk48_displayName)]
        public virtual float Unk48 {
            get => GetData<float>(196);
            set {
                if (GetData<float>(196) == value) return;
                SetData(196, value, nameof(Unk48));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk48));
            }
        }

        public const string Unk49_displayName = "Unk49";
        public const int Unk49_sortIndex = 2450;
        [SortOrder(Unk49_sortIndex)]
        [DisplayName(Unk49_displayName)]
        public virtual float Unk49 {
            get => GetData<float>(200);
            set {
                if (GetData<float>(200) == value) return;
                SetData(200, value, nameof(Unk49));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk49));
            }
        }

        public const string Unk50_displayName = "Unk50";
        public const int Unk50_sortIndex = 2500;
        [SortOrder(Unk50_sortIndex)]
        [DisplayName(Unk50_displayName)]
        public virtual float Unk50 {
            get => GetData<float>(204);
            set {
                if (GetData<float>(204) == value) return;
                SetData(204, value, nameof(Unk50));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk50));
            }
        }

        public const string Unk51_displayName = "Unk51";
        public const int Unk51_sortIndex = 2550;
        [SortOrder(Unk51_sortIndex)]
        [DisplayName(Unk51_displayName)]
        public virtual float Unk51 {
            get => GetData<float>(208);
            set {
                if (GetData<float>(208) == value) return;
                SetData(208, value, nameof(Unk51));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk51));
            }
        }

        public const string Unk52_displayName = "Unk52";
        public const int Unk52_sortIndex = 2600;
        [SortOrder(Unk52_sortIndex)]
        [DisplayName(Unk52_displayName)]
        public virtual float Unk52 {
            get => GetData<float>(212);
            set {
                if (GetData<float>(212) == value) return;
                SetData(212, value, nameof(Unk52));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk52));
            }
        }

        public const string Unk53_displayName = "Unk53";
        public const int Unk53_sortIndex = 2650;
        [SortOrder(Unk53_sortIndex)]
        [DisplayName(Unk53_displayName)]
        public virtual float Unk53 {
            get => GetData<float>(216);
            set {
                if (GetData<float>(216) == value) return;
                SetData(216, value, nameof(Unk53));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk53));
            }
        }

        public const string Unk54_displayName = "Unk54";
        public const int Unk54_sortIndex = 2700;
        [SortOrder(Unk54_sortIndex)]
        [DisplayName(Unk54_displayName)]
        public virtual float Unk54 {
            get => GetData<float>(220);
            set {
                if (GetData<float>(220) == value) return;
                SetData(220, value, nameof(Unk54));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk54));
            }
        }

        public const string Unk55_displayName = "Unk55";
        public const int Unk55_sortIndex = 2750;
        [SortOrder(Unk55_sortIndex)]
        [DisplayName(Unk55_displayName)]
        public virtual float Unk55 {
            get => GetData<float>(224);
            set {
                if (GetData<float>(224) == value) return;
                SetData(224, value, nameof(Unk55));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk55));
            }
        }

        public const string Unk56_displayName = "Unk56";
        public const int Unk56_sortIndex = 2800;
        [SortOrder(Unk56_sortIndex)]
        [DisplayName(Unk56_displayName)]
        public virtual float Unk56 {
            get => GetData<float>(228);
            set {
                if (GetData<float>(228) == value) return;
                SetData(228, value, nameof(Unk56));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk56));
            }
        }

        public const string Unk57_displayName = "Unk57";
        public const int Unk57_sortIndex = 2850;
        [SortOrder(Unk57_sortIndex)]
        [DisplayName(Unk57_displayName)]
        public virtual float Unk57 {
            get => GetData<float>(232);
            set {
                if (GetData<float>(232) == value) return;
                SetData(232, value, nameof(Unk57));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk57));
            }
        }

        public const string Unk58_displayName = "Unk58";
        public const int Unk58_sortIndex = 2900;
        [SortOrder(Unk58_sortIndex)]
        [DisplayName(Unk58_displayName)]
        public virtual byte Unk58 {
            get => GetData<byte>(236);
            set {
                if (GetData<byte>(236) == value) return;
                SetData(236, value, nameof(Unk58));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk58));
            }
        }

        public const string Unk59_displayName = "Unk59";
        public const int Unk59_sortIndex = 2950;
        [SortOrder(Unk59_sortIndex)]
        [DisplayName(Unk59_displayName)]
        public virtual ushort Unk59 {
            get => GetData<ushort>(237);
            set {
                if (GetData<ushort>(237) == value) return;
                SetData(237, value, nameof(Unk59));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk59));
            }
        }

        public const string Unk60_displayName = "Unk60";
        public const int Unk60_sortIndex = 3000;
        [SortOrder(Unk60_sortIndex)]
        [DisplayName(Unk60_displayName)]
        public virtual ushort Unk60 {
            get => GetData<ushort>(239);
            set {
                if (GetData<ushort>(239) == value) return;
                SetData(239, value, nameof(Unk60));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk60));
            }
        }

        public const string Unk61_displayName = "Unk61";
        public const int Unk61_sortIndex = 3050;
        [SortOrder(Unk61_sortIndex)]
        [DisplayName(Unk61_displayName)]
        public virtual float Unk61 {
            get => GetData<float>(241);
            set {
                if (GetData<float>(241) == value) return;
                SetData(241, value, nameof(Unk61));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk61));
            }
        }

        public const string Unk62_displayName = "Unk62";
        public const int Unk62_sortIndex = 3100;
        [SortOrder(Unk62_sortIndex)]
        [DisplayName(Unk62_displayName)]
        public virtual byte Unk62 {
            get => GetData<byte>(245);
            set {
                if (GetData<byte>(245) == value) return;
                SetData(245, value, nameof(Unk62));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk62));
            }
        }

        public const string Unk63_displayName = "Unk63";
        public const int Unk63_sortIndex = 3150;
        [SortOrder(Unk63_sortIndex)]
        [DisplayName(Unk63_displayName)]
        public virtual ushort Unk63 {
            get => GetData<ushort>(246);
            set {
                if (GetData<ushort>(246) == value) return;
                SetData(246, value, nameof(Unk63));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk63));
            }
        }

        public const string Unk64_displayName = "Unk64";
        public const int Unk64_sortIndex = 3200;
        [SortOrder(Unk64_sortIndex)]
        [DisplayName(Unk64_displayName)]
        public virtual ushort Unk64 {
            get => GetData<ushort>(248);
            set {
                if (GetData<ushort>(248) == value) return;
                SetData(248, value, nameof(Unk64));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk64));
            }
        }

        public const string Unk65_displayName = "Unk65";
        public const int Unk65_sortIndex = 3250;
        [SortOrder(Unk65_sortIndex)]
        [DisplayName(Unk65_displayName)]
        public virtual ushort Unk65 {
            get => GetData<ushort>(250);
            set {
                if (GetData<ushort>(250) == value) return;
                SetData(250, value, nameof(Unk65));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk65));
            }
        }

        public const string Unk66_displayName = "Unk66";
        public const int Unk66_sortIndex = 3300;
        [SortOrder(Unk66_sortIndex)]
        [DisplayName(Unk66_displayName)]
        public virtual float Unk66 {
            get => GetData<float>(252);
            set {
                if (GetData<float>(252) == value) return;
                SetData(252, value, nameof(Unk66));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk66));
            }
        }

        public const string _Skipping_ahead_1__displayName = "------Skipping ahead 1.";
        public const int _Skipping_ahead_1__sortIndex = 3350;
        [SortOrder(_Skipping_ahead_1__sortIndex)]
        [DisplayName(_Skipping_ahead_1__displayName)]
        public virtual byte _Skipping_ahead_1_ {
            get => GetData<byte>(256);
            set {
                if (GetData<byte>(256) == value) return;
                SetData(256, value, nameof(_Skipping_ahead_1_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(_Skipping_ahead_1_));
            }
        }

        public const string Health_Initial_Value_displayName = "Health Initial Value";
        public const int Health_Initial_Value_sortIndex = 3400;
        [SortOrder(Health_Initial_Value_sortIndex)]
        [DisplayName(Health_Initial_Value_displayName)]
        public virtual float Health_Initial_Value {
            get => GetData<float>(408);
            set {
                if (GetData<float>(408) == value) return;
                SetData(408, value, nameof(Health_Initial_Value));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Health_Initial_Value));
            }
        }

        public const string Health_Max_Value_displayName = "Health Max Value";
        public const int Health_Max_Value_sortIndex = 3450;
        [SortOrder(Health_Max_Value_sortIndex)]
        [DisplayName(Health_Max_Value_displayName)]
        public virtual float Health_Max_Value {
            get => GetData<float>(412);
            set {
                if (GetData<float>(412) == value) return;
                SetData(412, value, nameof(Health_Max_Value));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Health_Max_Value));
            }
        }

        public const string Health_Damage_Recovery_Rate_displayName = "Health Damage Recovery Rate";
        public const int Health_Damage_Recovery_Rate_sortIndex = 3500;
        [SortOrder(Health_Damage_Recovery_Rate_sortIndex)]
        [DisplayName(Health_Damage_Recovery_Rate_displayName)]
        public virtual float Health_Damage_Recovery_Rate {
            get => GetData<float>(416);
            set {
                if (GetData<float>(416) == value) return;
                SetData(416, value, nameof(Health_Damage_Recovery_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Health_Damage_Recovery_Rate));
            }
        }

        public const string Health_Damage_Recovery_Wait_Time_displayName = "Health Damage Recovery Wait Time";
        public const int Health_Damage_Recovery_Wait_Time_sortIndex = 3550;
        [SortOrder(Health_Damage_Recovery_Wait_Time_sortIndex)]
        [DisplayName(Health_Damage_Recovery_Wait_Time_displayName)]
        public virtual float Health_Damage_Recovery_Wait_Time {
            get => GetData<float>(420);
            set {
                if (GetData<float>(420) == value) return;
                SetData(420, value, nameof(Health_Damage_Recovery_Wait_Time));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Health_Damage_Recovery_Wait_Time));
            }
        }

        public const string Health_Damage_Recovery_Interval_displayName = "Health Damage Recovery Interval";
        public const int Health_Damage_Recovery_Interval_sortIndex = 3600;
        [SortOrder(Health_Damage_Recovery_Interval_sortIndex)]
        [DisplayName(Health_Damage_Recovery_Interval_displayName)]
        public virtual float Health_Damage_Recovery_Interval {
            get => GetData<float>(424);
            set {
                if (GetData<float>(424) == value) return;
                SetData(424, value, nameof(Health_Damage_Recovery_Interval));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Health_Damage_Recovery_Interval));
            }
        }

        public const string Health_Damage_Recovery_Value_displayName = "Health Damage Recovery Value";
        public const int Health_Damage_Recovery_Value_sortIndex = 3650;
        [SortOrder(Health_Damage_Recovery_Value_sortIndex)]
        [DisplayName(Health_Damage_Recovery_Value_displayName)]
        public virtual float Health_Damage_Recovery_Value {
            get => GetData<float>(428);
            set {
                if (GetData<float>(428) == value) return;
                SetData(428, value, nameof(Health_Damage_Recovery_Value));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Health_Damage_Recovery_Value));
            }
        }

        public const string Stamina_Initial_Value_displayName = "Stamina Initial Value";
        public const int Stamina_Initial_Value_sortIndex = 3700;
        [SortOrder(Stamina_Initial_Value_sortIndex)]
        [DisplayName(Stamina_Initial_Value_displayName)]
        public virtual float Stamina_Initial_Value {
            get => GetData<float>(432);
            set {
                if (GetData<float>(432) == value) return;
                SetData(432, value, nameof(Stamina_Initial_Value));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Initial_Value));
            }
        }

        public const string Stamina_Max_Value_displayName = "Stamina Max Value";
        public const int Stamina_Max_Value_sortIndex = 3750;
        [SortOrder(Stamina_Max_Value_sortIndex)]
        [DisplayName(Stamina_Max_Value_displayName)]
        public virtual float Stamina_Max_Value {
            get => GetData<float>(436);
            set {
                if (GetData<float>(436) == value) return;
                SetData(436, value, nameof(Stamina_Max_Value));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Max_Value));
            }
        }

        public const string Stamina_Min_Value_displayName = "Stamina Min Value";
        public const int Stamina_Min_Value_sortIndex = 3800;
        [SortOrder(Stamina_Min_Value_sortIndex)]
        [DisplayName(Stamina_Min_Value_displayName)]
        public virtual float Stamina_Min_Value {
            get => GetData<float>(440);
            set {
                if (GetData<float>(440) == value) return;
                SetData(440, value, nameof(Stamina_Min_Value));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Min_Value));
            }
        }

        public const string Stamina_Tired_Value_displayName = "Stamina Tired Value";
        public const int Stamina_Tired_Value_sortIndex = 3850;
        [SortOrder(Stamina_Tired_Value_sortIndex)]
        [DisplayName(Stamina_Tired_Value_displayName)]
        public virtual float Stamina_Tired_Value {
            get => GetData<float>(444);
            set {
                if (GetData<float>(444) == value) return;
                SetData(444, value, nameof(Stamina_Tired_Value));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Tired_Value));
            }
        }

        public const string Stamina_Auto_Recover_displayName = "Stamina Auto Recover";
        public const int Stamina_Auto_Recover_sortIndex = 3900;
        [SortOrder(Stamina_Auto_Recover_sortIndex)]
        [DisplayName(Stamina_Auto_Recover_displayName)]
        public virtual float Stamina_Auto_Recover {
            get => GetData<float>(448);
            set {
                if (GetData<float>(448) == value) return;
                SetData(448, value, nameof(Stamina_Auto_Recover));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Auto_Recover));
            }
        }

        public const string Stamina_Auto_Max_Reduce_displayName = "Stamina Auto Max Reduce";
        public const int Stamina_Auto_Max_Reduce_sortIndex = 3950;
        [SortOrder(Stamina_Auto_Max_Reduce_sortIndex)]
        [DisplayName(Stamina_Auto_Max_Reduce_displayName)]
        public virtual float Stamina_Auto_Max_Reduce {
            get => GetData<float>(452);
            set {
                if (GetData<float>(452) == value) return;
                SetData(452, value, nameof(Stamina_Auto_Max_Reduce));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Auto_Max_Reduce));
            }
        }

        public const string Stamina_Auto_Max_Reduce_Time_displayName = "Stamina Auto Max Reduce Time";
        public const int Stamina_Auto_Max_Reduce_Time_sortIndex = 4000;
        [SortOrder(Stamina_Auto_Max_Reduce_Time_sortIndex)]
        [DisplayName(Stamina_Auto_Max_Reduce_Time_displayName)]
        public virtual float Stamina_Auto_Max_Reduce_Time {
            get => GetData<float>(456);
            set {
                if (GetData<float>(456) == value) return;
                SetData(456, value, nameof(Stamina_Auto_Max_Reduce_Time));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Auto_Max_Reduce_Time));
            }
        }

        public const string Stamina_IB_Unknown_displayName = "Stamina IB Unknown";
        public const int Stamina_IB_Unknown_sortIndex = 4050;
        [SortOrder(Stamina_IB_Unknown_sortIndex)]
        [DisplayName(Stamina_IB_Unknown_displayName)]
        public virtual float Stamina_IB_Unknown {
            get => GetData<float>(460);
            set {
                if (GetData<float>(460) == value) return;
                SetData(460, value, nameof(Stamina_IB_Unknown));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_IB_Unknown));
            }
        }

        public const string Stamina_Escape_Dash_Rate_displayName = "Stamina Escape Dash Rate";
        public const int Stamina_Escape_Dash_Rate_sortIndex = 4100;
        [SortOrder(Stamina_Escape_Dash_Rate_sortIndex)]
        [DisplayName(Stamina_Escape_Dash_Rate_displayName)]
        public virtual float Stamina_Escape_Dash_Rate {
            get => GetData<float>(464);
            set {
                if (GetData<float>(464) == value) return;
                SetData(464, value, nameof(Stamina_Escape_Dash_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Escape_Dash_Rate));
            }
        }

        public const string Stamina_Out_of_Battle_Rate_displayName = "Stamina Out of Battle Rate";
        public const int Stamina_Out_of_Battle_Rate_sortIndex = 4150;
        [SortOrder(Stamina_Out_of_Battle_Rate_sortIndex)]
        [DisplayName(Stamina_Out_of_Battle_Rate_displayName)]
        public virtual float Stamina_Out_of_Battle_Rate {
            get => GetData<float>(468);
            set {
                if (GetData<float>(468) == value) return;
                SetData(468, value, nameof(Stamina_Out_of_Battle_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Out_of_Battle_Rate));
            }
        }

        public const string Stamina_Reduce_Rate_Limit_Trigger_displayName = "Stamina Reduce Rate Limit Trigger";
        public const int Stamina_Reduce_Rate_Limit_Trigger_sortIndex = 4200;
        [SortOrder(Stamina_Reduce_Rate_Limit_Trigger_sortIndex)]
        [DisplayName(Stamina_Reduce_Rate_Limit_Trigger_displayName)]
        public virtual float Stamina_Reduce_Rate_Limit_Trigger {
            get => GetData<float>(472);
            set {
                if (GetData<float>(472) == value) return;
                SetData(472, value, nameof(Stamina_Reduce_Rate_Limit_Trigger));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Reduce_Rate_Limit_Trigger));
            }
        }

        public const string Stamina_Reduce_Rate_Limit_Time_displayName = "Stamina Reduce Rate Limit Time";
        public const int Stamina_Reduce_Rate_Limit_Time_sortIndex = 4250;
        [SortOrder(Stamina_Reduce_Rate_Limit_Time_sortIndex)]
        [DisplayName(Stamina_Reduce_Rate_Limit_Time_displayName)]
        public virtual float Stamina_Reduce_Rate_Limit_Time {
            get => GetData<float>(476);
            set {
                if (GetData<float>(476) == value) return;
                SetData(476, value, nameof(Stamina_Reduce_Rate_Limit_Time));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Reduce_Rate_Limit_Time));
            }
        }

        public const string Stamina_Mount_Endurance_Rate_displayName = "Stamina Mount Endurance Rate";
        public const int Stamina_Mount_Endurance_Rate_sortIndex = 4300;
        [SortOrder(Stamina_Mount_Endurance_Rate_sortIndex)]
        [DisplayName(Stamina_Mount_Endurance_Rate_displayName)]
        public virtual float Stamina_Mount_Endurance_Rate {
            get => GetData<float>(480);
            set {
                if (GetData<float>(480) == value) return;
                SetData(480, value, nameof(Stamina_Mount_Endurance_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Mount_Endurance_Rate));
            }
        }

        public const string Stamina_Consumption_Dodge_displayName = "Stamina Consumption: Dodge";
        public const int Stamina_Consumption_Dodge_sortIndex = 4350;
        [SortOrder(Stamina_Consumption_Dodge_sortIndex)]
        [DisplayName(Stamina_Consumption_Dodge_displayName)]
        public virtual float Stamina_Consumption_Dodge {
            get => GetData<float>(484);
            set {
                if (GetData<float>(484) == value) return;
                SetData(484, value, nameof(Stamina_Consumption_Dodge));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Consumption_Dodge));
            }
        }

        public const string Stamina_Consumption_LS_Counter_displayName = "Stamina Consumption: LS Counter";
        public const int Stamina_Consumption_LS_Counter_sortIndex = 4400;
        [SortOrder(Stamina_Consumption_LS_Counter_sortIndex)]
        [DisplayName(Stamina_Consumption_LS_Counter_displayName)]
        public virtual float Stamina_Consumption_LS_Counter {
            get => GetData<float>(488);
            set {
                if (GetData<float>(488) == value) return;
                SetData(488, value, nameof(Stamina_Consumption_LS_Counter));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Consumption_LS_Counter));
            }
        }

        public const string Stamina_Consumption_Unk1_displayName = "Stamina Consumption: Unk1";
        public const int Stamina_Consumption_Unk1_sortIndex = 4450;
        [SortOrder(Stamina_Consumption_Unk1_sortIndex)]
        [DisplayName(Stamina_Consumption_Unk1_displayName)]
        public virtual float Stamina_Consumption_Unk1 {
            get => GetData<float>(492);
            set {
                if (GetData<float>(492) == value) return;
                SetData(492, value, nameof(Stamina_Consumption_Unk1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Consumption_Unk1));
            }
        }

        public const string Stamina_Consumption_Unk2_displayName = "Stamina Consumption: Unk2";
        public const int Stamina_Consumption_Unk2_sortIndex = 4500;
        [SortOrder(Stamina_Consumption_Unk2_sortIndex)]
        [DisplayName(Stamina_Consumption_Unk2_displayName)]
        public virtual float Stamina_Consumption_Unk2 {
            get => GetData<float>(496);
            set {
                if (GetData<float>(496) == value) return;
                SetData(496, value, nameof(Stamina_Consumption_Unk2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Consumption_Unk2));
            }
        }

        public const string Stamina_Consumption_Unk3_displayName = "Stamina Consumption: Unk3";
        public const int Stamina_Consumption_Unk3_sortIndex = 4550;
        [SortOrder(Stamina_Consumption_Unk3_sortIndex)]
        [DisplayName(Stamina_Consumption_Unk3_displayName)]
        public virtual float Stamina_Consumption_Unk3 {
            get => GetData<float>(500);
            set {
                if (GetData<float>(500) == value) return;
                SetData(500, value, nameof(Stamina_Consumption_Unk3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Consumption_Unk3));
            }
        }

        public const string Stamina_Consumption_Unk4_displayName = "Stamina Consumption: Unk4";
        public const int Stamina_Consumption_Unk4_sortIndex = 4600;
        [SortOrder(Stamina_Consumption_Unk4_sortIndex)]
        [DisplayName(Stamina_Consumption_Unk4_displayName)]
        public virtual float Stamina_Consumption_Unk4 {
            get => GetData<float>(504);
            set {
                if (GetData<float>(504) == value) return;
                SetData(504, value, nameof(Stamina_Consumption_Unk4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Consumption_Unk4));
            }
        }

        public const string Stamina_Consumption_Bow_Shoot_displayName = "Stamina Consumption: Bow Shoot";
        public const int Stamina_Consumption_Bow_Shoot_sortIndex = 4650;
        [SortOrder(Stamina_Consumption_Bow_Shoot_sortIndex)]
        [DisplayName(Stamina_Consumption_Bow_Shoot_displayName)]
        public virtual float Stamina_Consumption_Bow_Shoot {
            get => GetData<float>(508);
            set {
                if (GetData<float>(508) == value) return;
                SetData(508, value, nameof(Stamina_Consumption_Bow_Shoot));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Consumption_Bow_Shoot));
            }
        }

        public const string Stamina_Consumption_Unk5_displayName = "Stamina Consumption: Unk5";
        public const int Stamina_Consumption_Unk5_sortIndex = 4700;
        [SortOrder(Stamina_Consumption_Unk5_sortIndex)]
        [DisplayName(Stamina_Consumption_Unk5_displayName)]
        public virtual float Stamina_Consumption_Unk5 {
            get => GetData<float>(512);
            set {
                if (GetData<float>(512) == value) return;
                SetData(512, value, nameof(Stamina_Consumption_Unk5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Consumption_Unk5));
            }
        }

        public const string Stamina_Consumption_Unk6_displayName = "Stamina Consumption: Unk6";
        public const int Stamina_Consumption_Unk6_sortIndex = 4750;
        [SortOrder(Stamina_Consumption_Unk6_sortIndex)]
        [DisplayName(Stamina_Consumption_Unk6_displayName)]
        public virtual float Stamina_Consumption_Unk6 {
            get => GetData<float>(516);
            set {
                if (GetData<float>(516) == value) return;
                SetData(516, value, nameof(Stamina_Consumption_Unk6));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Consumption_Unk6));
            }
        }

        public const string Stamina_Consumption_Unk7_displayName = "Stamina Consumption: Unk7";
        public const int Stamina_Consumption_Unk7_sortIndex = 4800;
        [SortOrder(Stamina_Consumption_Unk7_sortIndex)]
        [DisplayName(Stamina_Consumption_Unk7_displayName)]
        public virtual float Stamina_Consumption_Unk7 {
            get => GetData<float>(520);
            set {
                if (GetData<float>(520) == value) return;
                SetData(520, value, nameof(Stamina_Consumption_Unk7));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Consumption_Unk7));
            }
        }

        public const string Stamina_Consumption_Bow_Charge_Step_displayName = "Stamina Consumption: Bow Charge Step";
        public const int Stamina_Consumption_Bow_Charge_Step_sortIndex = 4850;
        [SortOrder(Stamina_Consumption_Bow_Charge_Step_sortIndex)]
        [DisplayName(Stamina_Consumption_Bow_Charge_Step_displayName)]
        public virtual float Stamina_Consumption_Bow_Charge_Step {
            get => GetData<float>(524);
            set {
                if (GetData<float>(524) == value) return;
                SetData(524, value, nameof(Stamina_Consumption_Bow_Charge_Step));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Consumption_Bow_Charge_Step));
            }
        }

        public const string Stamina_Consumption_Unk8_displayName = "Stamina Consumption: Unk8";
        public const int Stamina_Consumption_Unk8_sortIndex = 4900;
        [SortOrder(Stamina_Consumption_Unk8_sortIndex)]
        [DisplayName(Stamina_Consumption_Unk8_displayName)]
        public virtual float Stamina_Consumption_Unk8 {
            get => GetData<float>(528);
            set {
                if (GetData<float>(528) == value) return;
                SetData(528, value, nameof(Stamina_Consumption_Unk8));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Consumption_Unk8));
            }
        }

        public const string Stamina_Consumption_IB_Unk9_displayName = "Stamina Consumption: IB Unk9";
        public const int Stamina_Consumption_IB_Unk9_sortIndex = 4950;
        [SortOrder(Stamina_Consumption_IB_Unk9_sortIndex)]
        [DisplayName(Stamina_Consumption_IB_Unk9_displayName)]
        public virtual float Stamina_Consumption_IB_Unk9 {
            get => GetData<float>(532);
            set {
                if (GetData<float>(532) == value) return;
                SetData(532, value, nameof(Stamina_Consumption_IB_Unk9));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Consumption_IB_Unk9));
            }
        }

        public const string Stamina_Consumption_IB_Unk10_displayName = "Stamina Consumption: IB Unk10";
        public const int Stamina_Consumption_IB_Unk10_sortIndex = 5000;
        [SortOrder(Stamina_Consumption_IB_Unk10_sortIndex)]
        [DisplayName(Stamina_Consumption_IB_Unk10_displayName)]
        public virtual float Stamina_Consumption_IB_Unk10 {
            get => GetData<float>(536);
            set {
                if (GetData<float>(536) == value) return;
                SetData(536, value, nameof(Stamina_Consumption_IB_Unk10));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Consumption_IB_Unk10));
            }
        }

        public const string Stamina_Consumption_IB_Unk11_displayName = "Stamina Consumption: IB Unk11";
        public const int Stamina_Consumption_IB_Unk11_sortIndex = 5050;
        [SortOrder(Stamina_Consumption_IB_Unk11_sortIndex)]
        [DisplayName(Stamina_Consumption_IB_Unk11_displayName)]
        public virtual float Stamina_Consumption_IB_Unk11 {
            get => GetData<float>(540);
            set {
                if (GetData<float>(540) == value) return;
                SetData(540, value, nameof(Stamina_Consumption_IB_Unk11));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Consumption_IB_Unk11));
            }
        }

        public const string Stamina_Consumption_IB_Unk12_displayName = "Stamina Consumption: IB Unk12";
        public const int Stamina_Consumption_IB_Unk12_sortIndex = 5100;
        [SortOrder(Stamina_Consumption_IB_Unk12_sortIndex)]
        [DisplayName(Stamina_Consumption_IB_Unk12_displayName)]
        public virtual float Stamina_Consumption_IB_Unk12 {
            get => GetData<float>(544);
            set {
                if (GetData<float>(544) == value) return;
                SetData(544, value, nameof(Stamina_Consumption_IB_Unk12));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Consumption_IB_Unk12));
            }
        }

        public const string Stamina_Consumption_Unk13_displayName = "Stamina Consumption: Unk13";
        public const int Stamina_Consumption_Unk13_sortIndex = 5150;
        [SortOrder(Stamina_Consumption_Unk13_sortIndex)]
        [DisplayName(Stamina_Consumption_Unk13_displayName)]
        public virtual float Stamina_Consumption_Unk13 {
            get => GetData<float>(548);
            set {
                if (GetData<float>(548) == value) return;
                SetData(548, value, nameof(Stamina_Consumption_Unk13));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Consumption_Unk13));
            }
        }

        public const string Stamina_Consumption_Unk14_displayName = "Stamina Consumption: Unk14";
        public const int Stamina_Consumption_Unk14_sortIndex = 5200;
        [SortOrder(Stamina_Consumption_Unk14_sortIndex)]
        [DisplayName(Stamina_Consumption_Unk14_displayName)]
        public virtual float Stamina_Consumption_Unk14 {
            get => GetData<float>(552);
            set {
                if (GetData<float>(552) == value) return;
                SetData(552, value, nameof(Stamina_Consumption_Unk14));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Consumption_Unk14));
            }
        }

        public const string Stamina_Time_Reduce_mCore_Unk1_displayName = "Stamina Time Reduce mCore: Unk1";
        public const int Stamina_Time_Reduce_mCore_Unk1_sortIndex = 5250;
        [SortOrder(Stamina_Time_Reduce_mCore_Unk1_sortIndex)]
        [DisplayName(Stamina_Time_Reduce_mCore_Unk1_displayName)]
        public virtual float Stamina_Time_Reduce_mCore_Unk1 {
            get => GetData<float>(556);
            set {
                if (GetData<float>(556) == value) return;
                SetData(556, value, nameof(Stamina_Time_Reduce_mCore_Unk1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Time_Reduce_mCore_Unk1));
            }
        }

        public const string Stamina_Time_Reduce_mCore_Unk2_displayName = "Stamina Time Reduce mCore: Unk2";
        public const int Stamina_Time_Reduce_mCore_Unk2_sortIndex = 5300;
        [SortOrder(Stamina_Time_Reduce_mCore_Unk2_sortIndex)]
        [DisplayName(Stamina_Time_Reduce_mCore_Unk2_displayName)]
        public virtual float Stamina_Time_Reduce_mCore_Unk2 {
            get => GetData<float>(560);
            set {
                if (GetData<float>(560) == value) return;
                SetData(560, value, nameof(Stamina_Time_Reduce_mCore_Unk2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Time_Reduce_mCore_Unk2));
            }
        }

        public const string Stamina_Time_Reduce_mCore_Unk3_displayName = "Stamina Time Reduce mCore: Unk3";
        public const int Stamina_Time_Reduce_mCore_Unk3_sortIndex = 5350;
        [SortOrder(Stamina_Time_Reduce_mCore_Unk3_sortIndex)]
        [DisplayName(Stamina_Time_Reduce_mCore_Unk3_displayName)]
        public virtual float Stamina_Time_Reduce_mCore_Unk3 {
            get => GetData<float>(564);
            set {
                if (GetData<float>(564) == value) return;
                SetData(564, value, nameof(Stamina_Time_Reduce_mCore_Unk3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Time_Reduce_mCore_Unk3));
            }
        }

        public const string Stamina_Time_Reduce_mCore_Unk4_displayName = "Stamina Time Reduce mCore: Unk4";
        public const int Stamina_Time_Reduce_mCore_Unk4_sortIndex = 5400;
        [SortOrder(Stamina_Time_Reduce_mCore_Unk4_sortIndex)]
        [DisplayName(Stamina_Time_Reduce_mCore_Unk4_displayName)]
        public virtual float Stamina_Time_Reduce_mCore_Unk4 {
            get => GetData<float>(568);
            set {
                if (GetData<float>(568) == value) return;
                SetData(568, value, nameof(Stamina_Time_Reduce_mCore_Unk4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Time_Reduce_mCore_Unk4));
            }
        }

        public const string Stamina_Time_Reduce_mCore_Unk5_displayName = "Stamina Time Reduce mCore: Unk5";
        public const int Stamina_Time_Reduce_mCore_Unk5_sortIndex = 5450;
        [SortOrder(Stamina_Time_Reduce_mCore_Unk5_sortIndex)]
        [DisplayName(Stamina_Time_Reduce_mCore_Unk5_displayName)]
        public virtual float Stamina_Time_Reduce_mCore_Unk5 {
            get => GetData<float>(572);
            set {
                if (GetData<float>(572) == value) return;
                SetData(572, value, nameof(Stamina_Time_Reduce_mCore_Unk5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Time_Reduce_mCore_Unk5));
            }
        }

        public const string Stamina_Time_Reduce_mCore_Unk6_displayName = "Stamina Time Reduce mCore: Unk6";
        public const int Stamina_Time_Reduce_mCore_Unk6_sortIndex = 5500;
        [SortOrder(Stamina_Time_Reduce_mCore_Unk6_sortIndex)]
        [DisplayName(Stamina_Time_Reduce_mCore_Unk6_displayName)]
        public virtual float Stamina_Time_Reduce_mCore_Unk6 {
            get => GetData<float>(576);
            set {
                if (GetData<float>(576) == value) return;
                SetData(576, value, nameof(Stamina_Time_Reduce_mCore_Unk6));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Time_Reduce_mCore_Unk6));
            }
        }

        public const string Stamina_Time_Reduce_mCore_Unk7_displayName = "Stamina Time Reduce mCore: Unk7";
        public const int Stamina_Time_Reduce_mCore_Unk7_sortIndex = 5550;
        [SortOrder(Stamina_Time_Reduce_mCore_Unk7_sortIndex)]
        [DisplayName(Stamina_Time_Reduce_mCore_Unk7_displayName)]
        public virtual float Stamina_Time_Reduce_mCore_Unk7 {
            get => GetData<float>(580);
            set {
                if (GetData<float>(580) == value) return;
                SetData(580, value, nameof(Stamina_Time_Reduce_mCore_Unk7));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Time_Reduce_mCore_Unk7));
            }
        }

        public const string Stamina_Time_Reduce_mCore_Unk8_displayName = "Stamina Time Reduce mCore: Unk8";
        public const int Stamina_Time_Reduce_mCore_Unk8_sortIndex = 5600;
        [SortOrder(Stamina_Time_Reduce_mCore_Unk8_sortIndex)]
        [DisplayName(Stamina_Time_Reduce_mCore_Unk8_displayName)]
        public virtual float Stamina_Time_Reduce_mCore_Unk8 {
            get => GetData<float>(584);
            set {
                if (GetData<float>(584) == value) return;
                SetData(584, value, nameof(Stamina_Time_Reduce_mCore_Unk8));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Time_Reduce_mCore_Unk8));
            }
        }

        public const string Stamina_Time_Reduce_mCore_Unk9_displayName = "Stamina Time Reduce mCore: Unk9";
        public const int Stamina_Time_Reduce_mCore_Unk9_sortIndex = 5650;
        [SortOrder(Stamina_Time_Reduce_mCore_Unk9_sortIndex)]
        [DisplayName(Stamina_Time_Reduce_mCore_Unk9_displayName)]
        public virtual float Stamina_Time_Reduce_mCore_Unk9 {
            get => GetData<float>(588);
            set {
                if (GetData<float>(588) == value) return;
                SetData(588, value, nameof(Stamina_Time_Reduce_mCore_Unk9));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Time_Reduce_mCore_Unk9));
            }
        }

        public const string Stamina_Time_Reduce_mCore_Unk10_displayName = "Stamina Time Reduce mCore: Unk10";
        public const int Stamina_Time_Reduce_mCore_Unk10_sortIndex = 5700;
        [SortOrder(Stamina_Time_Reduce_mCore_Unk10_sortIndex)]
        [DisplayName(Stamina_Time_Reduce_mCore_Unk10_displayName)]
        public virtual float Stamina_Time_Reduce_mCore_Unk10 {
            get => GetData<float>(592);
            set {
                if (GetData<float>(592) == value) return;
                SetData(592, value, nameof(Stamina_Time_Reduce_mCore_Unk10));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Time_Reduce_mCore_Unk10));
            }
        }

        public const string Stamina_Time_Reduce_mCore_Unk11_displayName = "Stamina Time Reduce mCore: Unk11";
        public const int Stamina_Time_Reduce_mCore_Unk11_sortIndex = 5750;
        [SortOrder(Stamina_Time_Reduce_mCore_Unk11_sortIndex)]
        [DisplayName(Stamina_Time_Reduce_mCore_Unk11_displayName)]
        public virtual float Stamina_Time_Reduce_mCore_Unk11 {
            get => GetData<float>(596);
            set {
                if (GetData<float>(596) == value) return;
                SetData(596, value, nameof(Stamina_Time_Reduce_mCore_Unk11));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Time_Reduce_mCore_Unk11));
            }
        }

        public const string Stamina_Time_Reduce_mCore_Unk12_displayName = "Stamina Time Reduce mCore: Unk12";
        public const int Stamina_Time_Reduce_mCore_Unk12_sortIndex = 5800;
        [SortOrder(Stamina_Time_Reduce_mCore_Unk12_sortIndex)]
        [DisplayName(Stamina_Time_Reduce_mCore_Unk12_displayName)]
        public virtual float Stamina_Time_Reduce_mCore_Unk12 {
            get => GetData<float>(600);
            set {
                if (GetData<float>(600) == value) return;
                SetData(600, value, nameof(Stamina_Time_Reduce_mCore_Unk12));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Time_Reduce_mCore_Unk12));
            }
        }

        public const string Stamina_Time_Reduce_mCore_Unk13_displayName = "Stamina Time Reduce mCore: Unk13";
        public const int Stamina_Time_Reduce_mCore_Unk13_sortIndex = 5850;
        [SortOrder(Stamina_Time_Reduce_mCore_Unk13_sortIndex)]
        [DisplayName(Stamina_Time_Reduce_mCore_Unk13_displayName)]
        public virtual float Stamina_Time_Reduce_mCore_Unk13 {
            get => GetData<float>(604);
            set {
                if (GetData<float>(604) == value) return;
                SetData(604, value, nameof(Stamina_Time_Reduce_mCore_Unk13));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Time_Reduce_mCore_Unk13));
            }
        }

        public const string Stamina_Time_Reduce_mCore_Unk14_displayName = "Stamina Time Reduce mCore: Unk14";
        public const int Stamina_Time_Reduce_mCore_Unk14_sortIndex = 5900;
        [SortOrder(Stamina_Time_Reduce_mCore_Unk14_sortIndex)]
        [DisplayName(Stamina_Time_Reduce_mCore_Unk14_displayName)]
        public virtual float Stamina_Time_Reduce_mCore_Unk14 {
            get => GetData<float>(608);
            set {
                if (GetData<float>(608) == value) return;
                SetData(608, value, nameof(Stamina_Time_Reduce_mCore_Unk14));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Time_Reduce_mCore_Unk14));
            }
        }

        public const string Stamina_Time_Reduce_mCore_Unk15_displayName = "Stamina Time Reduce mCore: Unk15";
        public const int Stamina_Time_Reduce_mCore_Unk15_sortIndex = 5950;
        [SortOrder(Stamina_Time_Reduce_mCore_Unk15_sortIndex)]
        [DisplayName(Stamina_Time_Reduce_mCore_Unk15_displayName)]
        public virtual float Stamina_Time_Reduce_mCore_Unk15 {
            get => GetData<float>(612);
            set {
                if (GetData<float>(612) == value) return;
                SetData(612, value, nameof(Stamina_Time_Reduce_mCore_Unk15));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Time_Reduce_mCore_Unk15));
            }
        }

        public const string Stamina_Time_Reduce_mCore_Unk16_displayName = "Stamina Time Reduce mCore: Unk16";
        public const int Stamina_Time_Reduce_mCore_Unk16_sortIndex = 6000;
        [SortOrder(Stamina_Time_Reduce_mCore_Unk16_sortIndex)]
        [DisplayName(Stamina_Time_Reduce_mCore_Unk16_displayName)]
        public virtual float Stamina_Time_Reduce_mCore_Unk16 {
            get => GetData<float>(616);
            set {
                if (GetData<float>(616) == value) return;
                SetData(616, value, nameof(Stamina_Time_Reduce_mCore_Unk16));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Time_Reduce_mCore_Unk16));
            }
        }

        public const string Stamina_Time_Reduce_mCore_Unk17_displayName = "Stamina Time Reduce mCore: Unk17";
        public const int Stamina_Time_Reduce_mCore_Unk17_sortIndex = 6050;
        [SortOrder(Stamina_Time_Reduce_mCore_Unk17_sortIndex)]
        [DisplayName(Stamina_Time_Reduce_mCore_Unk17_displayName)]
        public virtual float Stamina_Time_Reduce_mCore_Unk17 {
            get => GetData<float>(620);
            set {
                if (GetData<float>(620) == value) return;
                SetData(620, value, nameof(Stamina_Time_Reduce_mCore_Unk17));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Time_Reduce_mCore_Unk17));
            }
        }

        public const string Stamina_Time_Reduce_mCore_Unk18_displayName = "Stamina Time Reduce mCore: Unk18";
        public const int Stamina_Time_Reduce_mCore_Unk18_sortIndex = 6100;
        [SortOrder(Stamina_Time_Reduce_mCore_Unk18_sortIndex)]
        [DisplayName(Stamina_Time_Reduce_mCore_Unk18_displayName)]
        public virtual float Stamina_Time_Reduce_mCore_Unk18 {
            get => GetData<float>(624);
            set {
                if (GetData<float>(624) == value) return;
                SetData(624, value, nameof(Stamina_Time_Reduce_mCore_Unk18));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Time_Reduce_mCore_Unk18));
            }
        }

        public const string Mount_Reduce_Stamina_mCore_Unk1_displayName = "Mount Reduce Stamina mCore: Unk1";
        public const int Mount_Reduce_Stamina_mCore_Unk1_sortIndex = 6150;
        [SortOrder(Mount_Reduce_Stamina_mCore_Unk1_sortIndex)]
        [DisplayName(Mount_Reduce_Stamina_mCore_Unk1_displayName)]
        public virtual float Mount_Reduce_Stamina_mCore_Unk1 {
            get => GetData<float>(628);
            set {
                if (GetData<float>(628) == value) return;
                SetData(628, value, nameof(Mount_Reduce_Stamina_mCore_Unk1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Mount_Reduce_Stamina_mCore_Unk1));
            }
        }

        public const string Mount_Reduce_Stamina_mCore_Unk2_displayName = "Mount Reduce Stamina mCore: Unk2";
        public const int Mount_Reduce_Stamina_mCore_Unk2_sortIndex = 6200;
        [SortOrder(Mount_Reduce_Stamina_mCore_Unk2_sortIndex)]
        [DisplayName(Mount_Reduce_Stamina_mCore_Unk2_displayName)]
        public virtual float Mount_Reduce_Stamina_mCore_Unk2 {
            get => GetData<float>(632);
            set {
                if (GetData<float>(632) == value) return;
                SetData(632, value, nameof(Mount_Reduce_Stamina_mCore_Unk2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Mount_Reduce_Stamina_mCore_Unk2));
            }
        }

        public const string Mount_Life_Reduce_Stamina_mCore_Unk1_displayName = "Mount Life Reduce Stamina mCore: Unk1";
        public const int Mount_Life_Reduce_Stamina_mCore_Unk1_sortIndex = 6250;
        [SortOrder(Mount_Life_Reduce_Stamina_mCore_Unk1_sortIndex)]
        [DisplayName(Mount_Life_Reduce_Stamina_mCore_Unk1_displayName)]
        public virtual float Mount_Life_Reduce_Stamina_mCore_Unk1 {
            get => GetData<float>(636);
            set {
                if (GetData<float>(636) == value) return;
                SetData(636, value, nameof(Mount_Life_Reduce_Stamina_mCore_Unk1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Mount_Life_Reduce_Stamina_mCore_Unk1));
            }
        }

        public const string Mount_Life_Reduce_Stamina_mCore_Unk2_displayName = "Mount Life Reduce Stamina mCore: Unk2";
        public const int Mount_Life_Reduce_Stamina_mCore_Unk2_sortIndex = 6300;
        [SortOrder(Mount_Life_Reduce_Stamina_mCore_Unk2_sortIndex)]
        [DisplayName(Mount_Life_Reduce_Stamina_mCore_Unk2_displayName)]
        public virtual float Mount_Life_Reduce_Stamina_mCore_Unk2 {
            get => GetData<float>(640);
            set {
                if (GetData<float>(640) == value) return;
                SetData(640, value, nameof(Mount_Life_Reduce_Stamina_mCore_Unk2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Mount_Life_Reduce_Stamina_mCore_Unk2));
            }
        }

        public const string Mount_Life_Reduce_Stamina_mCore_Unk3_displayName = "Mount Life Reduce Stamina mCore: Unk3";
        public const int Mount_Life_Reduce_Stamina_mCore_Unk3_sortIndex = 6350;
        [SortOrder(Mount_Life_Reduce_Stamina_mCore_Unk3_sortIndex)]
        [DisplayName(Mount_Life_Reduce_Stamina_mCore_Unk3_displayName)]
        public virtual float Mount_Life_Reduce_Stamina_mCore_Unk3 {
            get => GetData<float>(644);
            set {
                if (GetData<float>(644) == value) return;
                SetData(644, value, nameof(Mount_Life_Reduce_Stamina_mCore_Unk3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Mount_Life_Reduce_Stamina_mCore_Unk3));
            }
        }

        public const string Mount_Life_Reduce_Stamina_mCore_Unk4_displayName = "Mount Life Reduce Stamina mCore: Unk4";
        public const int Mount_Life_Reduce_Stamina_mCore_Unk4_sortIndex = 6400;
        [SortOrder(Mount_Life_Reduce_Stamina_mCore_Unk4_sortIndex)]
        [DisplayName(Mount_Life_Reduce_Stamina_mCore_Unk4_displayName)]
        public virtual float Mount_Life_Reduce_Stamina_mCore_Unk4 {
            get => GetData<float>(648);
            set {
                if (GetData<float>(648) == value) return;
                SetData(648, value, nameof(Mount_Life_Reduce_Stamina_mCore_Unk4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Mount_Life_Reduce_Stamina_mCore_Unk4));
            }
        }

        public const string Unk67_displayName = "Unk67";
        public const int Unk67_sortIndex = 6450;
        [SortOrder(Unk67_sortIndex)]
        [DisplayName(Unk67_displayName)]
        public virtual float Unk67 {
            get => GetData<float>(652);
            set {
                if (GetData<float>(652) == value) return;
                SetData(652, value, nameof(Unk67));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk67));
            }
        }

        public const string Unk68_displayName = "Unk68";
        public const int Unk68_sortIndex = 6500;
        [SortOrder(Unk68_sortIndex)]
        [DisplayName(Unk68_displayName)]
        public virtual float Unk68 {
            get => GetData<float>(656);
            set {
                if (GetData<float>(656) == value) return;
                SetData(656, value, nameof(Unk68));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk68));
            }
        }

        public const string Unk69_displayName = "Unk69";
        public const int Unk69_sortIndex = 6550;
        [SortOrder(Unk69_sortIndex)]
        [DisplayName(Unk69_displayName)]
        public virtual float Unk69 {
            get => GetData<float>(660);
            set {
                if (GetData<float>(660) == value) return;
                SetData(660, value, nameof(Unk69));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk69));
            }
        }

        public const string Quest_Level_HR_Fix_Attack_Rate_displayName = "Quest Level HR Fix Attack Rate";
        public const int Quest_Level_HR_Fix_Attack_Rate_sortIndex = 6600;
        [SortOrder(Quest_Level_HR_Fix_Attack_Rate_sortIndex)]
        [DisplayName(Quest_Level_HR_Fix_Attack_Rate_displayName)]
        public virtual float Quest_Level_HR_Fix_Attack_Rate {
            get => GetData<float>(664);
            set {
                if (GetData<float>(664) == value) return;
                SetData(664, value, nameof(Quest_Level_HR_Fix_Attack_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Quest_Level_HR_Fix_Attack_Rate));
            }
        }

        public const string Quest_Level_MR_Fix_Attack_Rate_displayName = "Quest Level MR Fix Attack Rate";
        public const int Quest_Level_MR_Fix_Attack_Rate_sortIndex = 6650;
        [SortOrder(Quest_Level_MR_Fix_Attack_Rate_sortIndex)]
        [DisplayName(Quest_Level_MR_Fix_Attack_Rate_displayName)]
        public virtual float Quest_Level_MR_Fix_Attack_Rate {
            get => GetData<float>(668);
            set {
                if (GetData<float>(668) == value) return;
                SetData(668, value, nameof(Quest_Level_MR_Fix_Attack_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Quest_Level_MR_Fix_Attack_Rate));
            }
        }

        public const string Critical_Attack_Rate_displayName = "Critical Attack Rate";
        public const int Critical_Attack_Rate_sortIndex = 6700;
        [SortOrder(Critical_Attack_Rate_sortIndex)]
        [DisplayName(Critical_Attack_Rate_displayName)]
        public virtual float Critical_Attack_Rate {
            get => GetData<float>(672);
            set {
                if (GetData<float>(672) == value) return;
                SetData(672, value, nameof(Critical_Attack_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Critical_Attack_Rate));
            }
        }

        public const string Bad_Critical_Attack_Rate_displayName = "Bad Critical Attack Rate";
        public const int Bad_Critical_Attack_Rate_sortIndex = 6750;
        [SortOrder(Bad_Critical_Attack_Rate_sortIndex)]
        [DisplayName(Bad_Critical_Attack_Rate_displayName)]
        public virtual float Bad_Critical_Attack_Rate {
            get => GetData<float>(676);
            set {
                if (GetData<float>(676) == value) return;
                SetData(676, value, nameof(Bad_Critical_Attack_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Bad_Critical_Attack_Rate));
            }
        }

        public const string Sharpness_Recoil_Reduction__displayName = "Sharpness Recoil Reduction %";
        public const int Sharpness_Recoil_Reduction__sortIndex = 6800;
        [SortOrder(Sharpness_Recoil_Reduction__sortIndex)]
        [DisplayName(Sharpness_Recoil_Reduction__displayName)]
        public virtual byte Sharpness_Recoil_Reduction_ {
            get => GetData<byte>(680);
            set {
                if (GetData<byte>(680) == value) return;
                SetData(680, value, nameof(Sharpness_Recoil_Reduction_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Sharpness_Recoil_Reduction_));
            }
        }

        public const string Sharpness_Recoil_Reduction_Value_displayName = "Sharpness Recoil Reduction Value";
        public const int Sharpness_Recoil_Reduction_Value_sortIndex = 6850;
        [SortOrder(Sharpness_Recoil_Reduction_Value_sortIndex)]
        [DisplayName(Sharpness_Recoil_Reduction_Value_displayName)]
        public virtual byte Sharpness_Recoil_Reduction_Value {
            get => GetData<byte>(681);
            set {
                if (GetData<byte>(681) == value) return;
                SetData(681, value, nameof(Sharpness_Recoil_Reduction_Value));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Sharpness_Recoil_Reduction_Value));
            }
        }

        public const string Unk70_displayName = "Unk70";
        public const int Unk70_sortIndex = 6900;
        [SortOrder(Unk70_sortIndex)]
        [DisplayName(Unk70_displayName)]
        public virtual float Unk70 {
            get => GetData<float>(682);
            set {
                if (GetData<float>(682) == value) return;
                SetData(682, value, nameof(Unk70));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk70));
            }
        }

        public const string Unk71_displayName = "Unk71";
        public const int Unk71_sortIndex = 6950;
        [SortOrder(Unk71_sortIndex)]
        [DisplayName(Unk71_displayName)]
        public virtual float Unk71 {
            get => GetData<float>(686);
            set {
                if (GetData<float>(686) == value) return;
                SetData(686, value, nameof(Unk71));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk71));
            }
        }

        public const string Unk72_displayName = "Unk72";
        public const int Unk72_sortIndex = 7000;
        [SortOrder(Unk72_sortIndex)]
        [DisplayName(Unk72_displayName)]
        public virtual float Unk72 {
            get => GetData<float>(690);
            set {
                if (GetData<float>(690) == value) return;
                SetData(690, value, nameof(Unk72));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk72));
            }
        }

        public const string Unk73_displayName = "Unk73";
        public const int Unk73_sortIndex = 7050;
        [SortOrder(Unk73_sortIndex)]
        [DisplayName(Unk73_displayName)]
        public virtual float Unk73 {
            get => GetData<float>(694);
            set {
                if (GetData<float>(694) == value) return;
                SetData(694, value, nameof(Unk73));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk73));
            }
        }

        public const string Unk74_displayName = "Unk74";
        public const int Unk74_sortIndex = 7100;
        [SortOrder(Unk74_sortIndex)]
        [DisplayName(Unk74_displayName)]
        public virtual uint Unk74 {
            get => GetData<uint>(698);
            set {
                if (GetData<uint>(698) == value) return;
                SetData(698, value, nameof(Unk74));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk74));
            }
        }

        public const string Physical_Attack_Rate_Limit_displayName = "Physical Attack Rate Limit";
        public const int Physical_Attack_Rate_Limit_sortIndex = 7150;
        [SortOrder(Physical_Attack_Rate_Limit_sortIndex)]
        [DisplayName(Physical_Attack_Rate_Limit_displayName)]
        public virtual float Physical_Attack_Rate_Limit {
            get => GetData<float>(702);
            set {
                if (GetData<float>(702) == value) return;
                SetData(702, value, nameof(Physical_Attack_Rate_Limit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Physical_Attack_Rate_Limit));
            }
        }

        public const string Elemental_Attack_Rate_Limit_displayName = "Elemental Attack Rate Limit";
        public const int Elemental_Attack_Rate_Limit_sortIndex = 7200;
        [SortOrder(Elemental_Attack_Rate_Limit_sortIndex)]
        [DisplayName(Elemental_Attack_Rate_Limit_displayName)]
        public virtual float Elemental_Attack_Rate_Limit {
            get => GetData<float>(706);
            set {
                if (GetData<float>(706) == value) return;
                SetData(706, value, nameof(Elemental_Attack_Rate_Limit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Elemental_Attack_Rate_Limit));
            }
        }

        public const string Condition_Attack_Flat_Limit_displayName = "Condition Attack Flat Limit";
        public const int Condition_Attack_Flat_Limit_sortIndex = 7250;
        [SortOrder(Condition_Attack_Flat_Limit_sortIndex)]
        [DisplayName(Condition_Attack_Flat_Limit_displayName)]
        public virtual float Condition_Attack_Flat_Limit {
            get => GetData<float>(710);
            set {
                if (GetData<float>(710) == value) return;
                SetData(710, value, nameof(Condition_Attack_Flat_Limit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Condition_Attack_Flat_Limit));
            }
        }

        public const string Bowgun_Elemental_Attack_Rate_Limit_displayName = "Bowgun Elemental Attack Rate Limit";
        public const int Bowgun_Elemental_Attack_Rate_Limit_sortIndex = 7300;
        [SortOrder(Bowgun_Elemental_Attack_Rate_Limit_sortIndex)]
        [DisplayName(Bowgun_Elemental_Attack_Rate_Limit_displayName)]
        public virtual float Bowgun_Elemental_Attack_Rate_Limit {
            get => GetData<float>(714);
            set {
                if (GetData<float>(714) == value) return;
                SetData(714, value, nameof(Bowgun_Elemental_Attack_Rate_Limit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Bowgun_Elemental_Attack_Rate_Limit));
            }
        }

        public const string Condition_Attack_Rate_Limit_displayName = "Condition Attack Rate Limit";
        public const int Condition_Attack_Rate_Limit_sortIndex = 7350;
        [SortOrder(Condition_Attack_Rate_Limit_sortIndex)]
        [DisplayName(Condition_Attack_Rate_Limit_displayName)]
        public virtual float Condition_Attack_Rate_Limit {
            get => GetData<float>(718);
            set {
                if (GetData<float>(718) == value) return;
                SetData(718, value, nameof(Condition_Attack_Rate_Limit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Condition_Attack_Rate_Limit));
            }
        }

        public const string Stun_Attack_Rate_Limit_displayName = "Stun Attack Rate Limit";
        public const int Stun_Attack_Rate_Limit_sortIndex = 7400;
        [SortOrder(Stun_Attack_Rate_Limit_sortIndex)]
        [DisplayName(Stun_Attack_Rate_Limit_displayName)]
        public virtual float Stun_Attack_Rate_Limit {
            get => GetData<float>(722);
            set {
                if (GetData<float>(722) == value) return;
                SetData(722, value, nameof(Stun_Attack_Rate_Limit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stun_Attack_Rate_Limit));
            }
        }

        public const string Stamina_Attack_Rate_Limit_displayName = "Stamina Attack Rate Limit";
        public const int Stamina_Attack_Rate_Limit_sortIndex = 7450;
        [SortOrder(Stamina_Attack_Rate_Limit_sortIndex)]
        [DisplayName(Stamina_Attack_Rate_Limit_displayName)]
        public virtual float Stamina_Attack_Rate_Limit {
            get => GetData<float>(726);
            set {
                if (GetData<float>(726) == value) return;
                SetData(726, value, nameof(Stamina_Attack_Rate_Limit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Stamina_Attack_Rate_Limit));
            }
        }

        public const string Mount_Attack_Rate_Limit_displayName = "Mount Attack Rate Limit";
        public const int Mount_Attack_Rate_Limit_sortIndex = 7500;
        [SortOrder(Mount_Attack_Rate_Limit_sortIndex)]
        [DisplayName(Mount_Attack_Rate_Limit_displayName)]
        public virtual float Mount_Attack_Rate_Limit {
            get => GetData<float>(730);
            set {
                if (GetData<float>(730) == value) return;
                SetData(730, value, nameof(Mount_Attack_Rate_Limit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Mount_Attack_Rate_Limit));
            }
        }

        public const string Super_Armor_Stun_Damage_Rate_displayName = "Super Armor Stun Damage Rate";
        public const int Super_Armor_Stun_Damage_Rate_sortIndex = 7550;
        [SortOrder(Super_Armor_Stun_Damage_Rate_sortIndex)]
        [DisplayName(Super_Armor_Stun_Damage_Rate_displayName)]
        public virtual float Super_Armor_Stun_Damage_Rate {
            get => GetData<float>(734);
            set {
                if (GetData<float>(734) == value) return;
                SetData(734, value, nameof(Super_Armor_Stun_Damage_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Super_Armor_Stun_Damage_Rate));
            }
        }

        public const string Hyper_Armor_Damage_Rate_displayName = "Hyper Armor Damage Rate";
        public const int Hyper_Armor_Damage_Rate_sortIndex = 7600;
        [SortOrder(Hyper_Armor_Damage_Rate_sortIndex)]
        [DisplayName(Hyper_Armor_Damage_Rate_displayName)]
        public virtual float Hyper_Armor_Damage_Rate {
            get => GetData<float>(738);
            set {
                if (GetData<float>(738) == value) return;
                SetData(738, value, nameof(Hyper_Armor_Damage_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Hyper_Armor_Damage_Rate));
            }
        }

        public const string Hyper_Armor_Stun_Damage_Rate_displayName = "Hyper Armor Stun Damage Rate";
        public const int Hyper_Armor_Stun_Damage_Rate_sortIndex = 7650;
        [SortOrder(Hyper_Armor_Stun_Damage_Rate_sortIndex)]
        [DisplayName(Hyper_Armor_Stun_Damage_Rate_displayName)]
        public virtual float Hyper_Armor_Stun_Damage_Rate {
            get => GetData<float>(742);
            set {
                if (GetData<float>(742) == value) return;
                SetData(742, value, nameof(Hyper_Armor_Stun_Damage_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Hyper_Armor_Stun_Damage_Rate));
            }
        }

        public const string Gunner_Defense_Rate_displayName = "Gunner Defense Rate";
        public const int Gunner_Defense_Rate_sortIndex = 7700;
        [SortOrder(Gunner_Defense_Rate_sortIndex)]
        [DisplayName(Gunner_Defense_Rate_displayName)]
        public virtual float Gunner_Defense_Rate {
            get => GetData<float>(746);
            set {
                if (GetData<float>(746) == value) return;
                SetData(746, value, nameof(Gunner_Defense_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Gunner_Defense_Rate));
            }
        }

        public const string Gunner_Elemental_Resistance_Bonus_displayName = "Gunner Elemental Resistance Bonus";
        public const int Gunner_Elemental_Resistance_Bonus_sortIndex = 7750;
        [SortOrder(Gunner_Elemental_Resistance_Bonus_sortIndex)]
        [DisplayName(Gunner_Elemental_Resistance_Bonus_displayName)]
        public virtual byte Gunner_Elemental_Resistance_Bonus {
            get => GetData<byte>(750);
            set {
                if (GetData<byte>(750) == value) return;
                SetData(750, value, nameof(Gunner_Elemental_Resistance_Bonus));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Gunner_Elemental_Resistance_Bonus));
            }
        }

        public const string _Skipping_ahead_2__displayName = "------Skipping ahead 2.";
        public const int _Skipping_ahead_2__sortIndex = 7800;
        [SortOrder(_Skipping_ahead_2__sortIndex)]
        [DisplayName(_Skipping_ahead_2__displayName)]
        public virtual float _Skipping_ahead_2_ {
            get => GetData<float>(751);
            set {
                if (GetData<float>(751) == value) return;
                SetData(751, value, nameof(_Skipping_ahead_2_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(_Skipping_ahead_2_));
            }
        }

        public const int lastSortIndex = 7850;
    }
}
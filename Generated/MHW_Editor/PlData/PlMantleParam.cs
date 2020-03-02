using System;
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.PlData {
    public partial class PlMantleParam {
        public const uint StructSize = 560;
        public const ulong InitialOffset = 0;
        public const long EntryCountOffset = -1;
        public const string EncryptionKey = "Nb06gpPJ9WtbO6FF1ZYqm5NbLREsCzuqAY0G25ug2Ei5XkkAtVXD5Uda";
        public override string UniqueId => $"0";

        public const string Unk_Unk1_displayName = "Unk: Unk1";
        public const int Unk_Unk1_sortIndex = 50;
        [SortOrder(Unk_Unk1_sortIndex)]
        [DisplayName(Unk_Unk1_displayName)]
        public virtual float Unk_Unk1 {
            get => GetData<float>(8);
            set {
                if (GetData<float>(8) == value) return;
                SetData(8, value, nameof(Unk_Unk1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk_Unk1));
            }
        }

        public const string Unk_Unk2_displayName = "Unk: Unk2";
        public const int Unk_Unk2_sortIndex = 100;
        [SortOrder(Unk_Unk2_sortIndex)]
        [DisplayName(Unk_Unk2_displayName)]
        public virtual float Unk_Unk2 {
            get => GetData<float>(12);
            set {
                if (GetData<float>(12) == value) return;
                SetData(12, value, nameof(Unk_Unk2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk_Unk2));
            }
        }

        public const string Unk_Unk3_displayName = "Unk: Unk3";
        public const int Unk_Unk3_sortIndex = 150;
        [SortOrder(Unk_Unk3_sortIndex)]
        [DisplayName(Unk_Unk3_displayName)]
        public virtual float Unk_Unk3 {
            get => GetData<float>(16);
            set {
                if (GetData<float>(16) == value) return;
                SetData(16, value, nameof(Unk_Unk3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk_Unk3));
            }
        }

        public const string Unk_Unk4_displayName = "Unk: Unk4";
        public const int Unk_Unk4_sortIndex = 200;
        [SortOrder(Unk_Unk4_sortIndex)]
        [DisplayName(Unk_Unk4_displayName)]
        public virtual float Unk_Unk4 {
            get => GetData<float>(20);
            set {
                if (GetData<float>(20) == value) return;
                SetData(20, value, nameof(Unk_Unk4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk_Unk4));
            }
        }

        public const string Unk_Unk5_displayName = "Unk: Unk5";
        public const int Unk_Unk5_sortIndex = 250;
        [SortOrder(Unk_Unk5_sortIndex)]
        [DisplayName(Unk_Unk5_displayName)]
        public virtual float Unk_Unk5 {
            get => GetData<float>(24);
            set {
                if (GetData<float>(24) == value) return;
                SetData(24, value, nameof(Unk_Unk5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk_Unk5));
            }
        }

        public const string Unk_Unk6_displayName = "Unk: Unk6";
        public const int Unk_Unk6_sortIndex = 300;
        [SortOrder(Unk_Unk6_sortIndex)]
        [DisplayName(Unk_Unk6_displayName)]
        public virtual uint Unk_Unk6 {
            get => GetData<uint>(28);
            set {
                if (GetData<uint>(28) == value) return;
                SetData(28, value, nameof(Unk_Unk6));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk_Unk6));
            }
        }

        public const string Unk_Unk7_displayName = "Unk: Unk7";
        public const int Unk_Unk7_sortIndex = 350;
        [SortOrder(Unk_Unk7_sortIndex)]
        [DisplayName(Unk_Unk7_displayName)]
        public virtual float Unk_Unk7 {
            get => GetData<float>(32);
            set {
                if (GetData<float>(32) == value) return;
                SetData(32, value, nameof(Unk_Unk7));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk_Unk7));
            }
        }

        public const string Unk_Unk8_displayName = "Unk: Unk8";
        public const int Unk_Unk8_sortIndex = 400;
        [SortOrder(Unk_Unk8_sortIndex)]
        [DisplayName(Unk_Unk8_displayName)]
        public virtual float Unk_Unk8 {
            get => GetData<float>(36);
            set {
                if (GetData<float>(36) == value) return;
                SetData(36, value, nameof(Unk_Unk8));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk_Unk8));
            }
        }

        public const string Unk_Unk9_displayName = "Unk: Unk9";
        public const int Unk_Unk9_sortIndex = 450;
        [SortOrder(Unk_Unk9_sortIndex)]
        [DisplayName(Unk_Unk9_displayName)]
        public virtual float Unk_Unk9 {
            get => GetData<float>(40);
            set {
                if (GetData<float>(40) == value) return;
                SetData(40, value, nameof(Unk_Unk9));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk_Unk9));
            }
        }

        public const string __500_displayName = "-------------------------------------------------------------------------------------------";
        public const int __500_sortIndex = 500;
        [SortOrder(__500_sortIndex)]
        [DisplayName(__500_displayName)]
        [IsReadOnly]
        public virtual byte __500 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__500));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__500));
            }
        }

        public const string Ghillie_Mantle_Cooldown_displayName = "Ghillie Mantle: Cooldown";
        public const int Ghillie_Mantle_Cooldown_sortIndex = 550;
        [SortOrder(Ghillie_Mantle_Cooldown_sortIndex)]
        [DisplayName(Ghillie_Mantle_Cooldown_displayName)]
        public virtual float Ghillie_Mantle_Cooldown {
            get => GetData<float>(44);
            set {
                if (GetData<float>(44) == value) return;
                SetData(44, value, nameof(Ghillie_Mantle_Cooldown));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Ghillie_Mantle_Cooldown));
            }
        }

        public const string Ghillie_Mantle_Duration_displayName = "Ghillie Mantle: Duration";
        public const int Ghillie_Mantle_Duration_sortIndex = 600;
        [SortOrder(Ghillie_Mantle_Duration_sortIndex)]
        [DisplayName(Ghillie_Mantle_Duration_displayName)]
        public virtual float Ghillie_Mantle_Duration {
            get => GetData<float>(48);
            set {
                if (GetData<float>(48) == value) return;
                SetData(48, value, nameof(Ghillie_Mantle_Duration));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Ghillie_Mantle_Duration));
            }
        }

        public const string Ghillie_Mantle_Unk1_displayName = "Ghillie Mantle: Unk1";
        public const int Ghillie_Mantle_Unk1_sortIndex = 650;
        [SortOrder(Ghillie_Mantle_Unk1_sortIndex)]
        [DisplayName(Ghillie_Mantle_Unk1_displayName)]
        public virtual float Ghillie_Mantle_Unk1 {
            get => GetData<float>(52);
            set {
                if (GetData<float>(52) == value) return;
                SetData(52, value, nameof(Ghillie_Mantle_Unk1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Ghillie_Mantle_Unk1));
            }
        }

        public const string Ghillie_Mantle_Unk2_displayName = "Ghillie Mantle: Unk2";
        public const int Ghillie_Mantle_Unk2_sortIndex = 700;
        [SortOrder(Ghillie_Mantle_Unk2_sortIndex)]
        [DisplayName(Ghillie_Mantle_Unk2_displayName)]
        public virtual float Ghillie_Mantle_Unk2 {
            get => GetData<float>(56);
            set {
                if (GetData<float>(56) == value) return;
                SetData(56, value, nameof(Ghillie_Mantle_Unk2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Ghillie_Mantle_Unk2));
            }
        }

        public const string __750_displayName = "-------------------------------------------------------------------------------------------";
        public const int __750_sortIndex = 750;
        [SortOrder(__750_sortIndex)]
        [DisplayName(__750_displayName)]
        [IsReadOnly]
        public virtual byte __750 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__750));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__750));
            }
        }

        public const string Temporal_Mantle_Cooldown_displayName = "Temporal Mantle: Cooldown";
        public const int Temporal_Mantle_Cooldown_sortIndex = 800;
        [SortOrder(Temporal_Mantle_Cooldown_sortIndex)]
        [DisplayName(Temporal_Mantle_Cooldown_displayName)]
        public virtual float Temporal_Mantle_Cooldown {
            get => GetData<float>(60);
            set {
                if (GetData<float>(60) == value) return;
                SetData(60, value, nameof(Temporal_Mantle_Cooldown));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Temporal_Mantle_Cooldown));
            }
        }

        public const string Temporal_Mantle_Duration_displayName = "Temporal Mantle: Duration";
        public const int Temporal_Mantle_Duration_sortIndex = 850;
        [SortOrder(Temporal_Mantle_Duration_sortIndex)]
        [DisplayName(Temporal_Mantle_Duration_displayName)]
        public virtual float Temporal_Mantle_Duration {
            get => GetData<float>(64);
            set {
                if (GetData<float>(64) == value) return;
                SetData(64, value, nameof(Temporal_Mantle_Duration));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Temporal_Mantle_Duration));
            }
        }

        public const string Temporal_Mantle_Unk1_displayName = "Temporal Mantle: Unk1";
        public const int Temporal_Mantle_Unk1_sortIndex = 900;
        [SortOrder(Temporal_Mantle_Unk1_sortIndex)]
        [DisplayName(Temporal_Mantle_Unk1_displayName)]
        public virtual float Temporal_Mantle_Unk1 {
            get => GetData<float>(68);
            set {
                if (GetData<float>(68) == value) return;
                SetData(68, value, nameof(Temporal_Mantle_Unk1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Temporal_Mantle_Unk1));
            }
        }

        public const string Temporal_Mantle_Unk2_displayName = "Temporal Mantle: Unk2";
        public const int Temporal_Mantle_Unk2_sortIndex = 950;
        [SortOrder(Temporal_Mantle_Unk2_sortIndex)]
        [DisplayName(Temporal_Mantle_Unk2_displayName)]
        public virtual float Temporal_Mantle_Unk2 {
            get => GetData<float>(72);
            set {
                if (GetData<float>(72) == value) return;
                SetData(72, value, nameof(Temporal_Mantle_Unk2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Temporal_Mantle_Unk2));
            }
        }

        public const string Temporal_Mantle_Unk3_displayName = "Temporal Mantle: Unk3";
        public const int Temporal_Mantle_Unk3_sortIndex = 1000;
        [SortOrder(Temporal_Mantle_Unk3_sortIndex)]
        [DisplayName(Temporal_Mantle_Unk3_displayName)]
        public virtual float Temporal_Mantle_Unk3 {
            get => GetData<float>(76);
            set {
                if (GetData<float>(76) == value) return;
                SetData(76, value, nameof(Temporal_Mantle_Unk3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Temporal_Mantle_Unk3));
            }
        }

        public const string Temporal_Mantle_Unk4_displayName = "Temporal Mantle: Unk4";
        public const int Temporal_Mantle_Unk4_sortIndex = 1050;
        [SortOrder(Temporal_Mantle_Unk4_sortIndex)]
        [DisplayName(Temporal_Mantle_Unk4_displayName)]
        public virtual float Temporal_Mantle_Unk4 {
            get => GetData<float>(80);
            set {
                if (GetData<float>(80) == value) return;
                SetData(80, value, nameof(Temporal_Mantle_Unk4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Temporal_Mantle_Unk4));
            }
        }

        public const string Temporal_Mantle_Unk5_displayName = "Temporal Mantle: Unk5";
        public const int Temporal_Mantle_Unk5_sortIndex = 1100;
        [SortOrder(Temporal_Mantle_Unk5_sortIndex)]
        [DisplayName(Temporal_Mantle_Unk5_displayName)]
        public virtual float Temporal_Mantle_Unk5 {
            get => GetData<float>(84);
            set {
                if (GetData<float>(84) == value) return;
                SetData(84, value, nameof(Temporal_Mantle_Unk5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Temporal_Mantle_Unk5));
            }
        }

        public const string Temporal_Mantle_Unk6_displayName = "Temporal Mantle: Unk6";
        public const int Temporal_Mantle_Unk6_sortIndex = 1150;
        [SortOrder(Temporal_Mantle_Unk6_sortIndex)]
        [DisplayName(Temporal_Mantle_Unk6_displayName)]
        public virtual float Temporal_Mantle_Unk6 {
            get => GetData<float>(88);
            set {
                if (GetData<float>(88) == value) return;
                SetData(88, value, nameof(Temporal_Mantle_Unk6));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Temporal_Mantle_Unk6));
            }
        }

        public const string Temporal_Mantle_Unk7_displayName = "Temporal Mantle: Unk7";
        public const int Temporal_Mantle_Unk7_sortIndex = 1200;
        [SortOrder(Temporal_Mantle_Unk7_sortIndex)]
        [DisplayName(Temporal_Mantle_Unk7_displayName)]
        public virtual float Temporal_Mantle_Unk7 {
            get => GetData<float>(92);
            set {
                if (GetData<float>(92) == value) return;
                SetData(92, value, nameof(Temporal_Mantle_Unk7));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Temporal_Mantle_Unk7));
            }
        }

        public const string Temporal_Mantle_Unk8_displayName = "Temporal Mantle: Unk8";
        public const int Temporal_Mantle_Unk8_sortIndex = 1250;
        [SortOrder(Temporal_Mantle_Unk8_sortIndex)]
        [DisplayName(Temporal_Mantle_Unk8_displayName)]
        public virtual float Temporal_Mantle_Unk8 {
            get => GetData<float>(96);
            set {
                if (GetData<float>(96) == value) return;
                SetData(96, value, nameof(Temporal_Mantle_Unk8));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Temporal_Mantle_Unk8));
            }
        }

        public const string Temporal_Mantle_Unk9_displayName = "Temporal Mantle: Unk9";
        public const int Temporal_Mantle_Unk9_sortIndex = 1300;
        [SortOrder(Temporal_Mantle_Unk9_sortIndex)]
        [DisplayName(Temporal_Mantle_Unk9_displayName)]
        public virtual float Temporal_Mantle_Unk9 {
            get => GetData<float>(100);
            set {
                if (GetData<float>(100) == value) return;
                SetData(100, value, nameof(Temporal_Mantle_Unk9));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Temporal_Mantle_Unk9));
            }
        }

        public const string Temporal_Mantle_Unk10_displayName = "Temporal Mantle: Unk10";
        public const int Temporal_Mantle_Unk10_sortIndex = 1350;
        [SortOrder(Temporal_Mantle_Unk10_sortIndex)]
        [DisplayName(Temporal_Mantle_Unk10_displayName)]
        public virtual float Temporal_Mantle_Unk10 {
            get => GetData<float>(104);
            set {
                if (GetData<float>(104) == value) return;
                SetData(104, value, nameof(Temporal_Mantle_Unk10));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Temporal_Mantle_Unk10));
            }
        }

        public const string Temporal_Mantle_Unk11_displayName = "Temporal Mantle: Unk11";
        public const int Temporal_Mantle_Unk11_sortIndex = 1400;
        [SortOrder(Temporal_Mantle_Unk11_sortIndex)]
        [DisplayName(Temporal_Mantle_Unk11_displayName)]
        public virtual float Temporal_Mantle_Unk11 {
            get => GetData<float>(108);
            set {
                if (GetData<float>(108) == value) return;
                SetData(108, value, nameof(Temporal_Mantle_Unk11));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Temporal_Mantle_Unk11));
            }
        }

        public const string Temporal_Mantle_Unk12_displayName = "Temporal Mantle: Unk12";
        public const int Temporal_Mantle_Unk12_sortIndex = 1450;
        [SortOrder(Temporal_Mantle_Unk12_sortIndex)]
        [DisplayName(Temporal_Mantle_Unk12_displayName)]
        public virtual float Temporal_Mantle_Unk12 {
            get => GetData<float>(112);
            set {
                if (GetData<float>(112) == value) return;
                SetData(112, value, nameof(Temporal_Mantle_Unk12));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Temporal_Mantle_Unk12));
            }
        }

        public const string Temporal_Mantle_Duration_Decrease_Per_Hit_displayName = "Temporal Mantle: Duration Decrease Per Hit";
        public const int Temporal_Mantle_Duration_Decrease_Per_Hit_sortIndex = 1500;
        [SortOrder(Temporal_Mantle_Duration_Decrease_Per_Hit_sortIndex)]
        [DisplayName(Temporal_Mantle_Duration_Decrease_Per_Hit_displayName)]
        public virtual float Temporal_Mantle_Duration_Decrease_Per_Hit {
            get => GetData<float>(116);
            set {
                if (GetData<float>(116) == value) return;
                SetData(116, value, nameof(Temporal_Mantle_Duration_Decrease_Per_Hit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Temporal_Mantle_Duration_Decrease_Per_Hit));
            }
        }

        public const string __1550_displayName = "-------------------------------------------------------------------------------------------";
        public const int __1550_sortIndex = 1550;
        [SortOrder(__1550_sortIndex)]
        [DisplayName(__1550_displayName)]
        [IsReadOnly]
        public virtual byte __1550 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__1550));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__1550));
            }
        }

        public const string Health_Booster_Cooldown_displayName = "Health Booster: Cooldown";
        public const int Health_Booster_Cooldown_sortIndex = 1600;
        [SortOrder(Health_Booster_Cooldown_sortIndex)]
        [DisplayName(Health_Booster_Cooldown_displayName)]
        public virtual float Health_Booster_Cooldown {
            get => GetData<float>(120);
            set {
                if (GetData<float>(120) == value) return;
                SetData(120, value, nameof(Health_Booster_Cooldown));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Health_Booster_Cooldown));
            }
        }

        public const string Health_Booster_Duration_displayName = "Health Booster: Duration";
        public const int Health_Booster_Duration_sortIndex = 1650;
        [SortOrder(Health_Booster_Duration_sortIndex)]
        [DisplayName(Health_Booster_Duration_displayName)]
        public virtual float Health_Booster_Duration {
            get => GetData<float>(124);
            set {
                if (GetData<float>(124) == value) return;
                SetData(124, value, nameof(Health_Booster_Duration));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Health_Booster_Duration));
            }
        }

        public const string Health_Booster_Upgraded_Duration_displayName = "Health Booster: Upgraded Duration";
        public const int Health_Booster_Upgraded_Duration_sortIndex = 1700;
        [SortOrder(Health_Booster_Upgraded_Duration_sortIndex)]
        [DisplayName(Health_Booster_Upgraded_Duration_displayName)]
        public virtual float Health_Booster_Upgraded_Duration {
            get => GetData<float>(128);
            set {
                if (GetData<float>(128) == value) return;
                SetData(128, value, nameof(Health_Booster_Upgraded_Duration));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Health_Booster_Upgraded_Duration));
            }
        }

        public const string __1750_displayName = "-------------------------------------------------------------------------------------------";
        public const int __1750_sortIndex = 1750;
        [SortOrder(__1750_sortIndex)]
        [DisplayName(__1750_displayName)]
        [IsReadOnly]
        public virtual byte __1750 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__1750));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__1750));
            }
        }

        public const string Rocksteady_Mantle_Cooldown_displayName = "Rocksteady Mantle: Cooldown";
        public const int Rocksteady_Mantle_Cooldown_sortIndex = 1800;
        [SortOrder(Rocksteady_Mantle_Cooldown_sortIndex)]
        [DisplayName(Rocksteady_Mantle_Cooldown_displayName)]
        public virtual float Rocksteady_Mantle_Cooldown {
            get => GetData<float>(132);
            set {
                if (GetData<float>(132) == value) return;
                SetData(132, value, nameof(Rocksteady_Mantle_Cooldown));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Rocksteady_Mantle_Cooldown));
            }
        }

        public const string Rocksteady_Mantle_Duration_displayName = "Rocksteady Mantle: Duration";
        public const int Rocksteady_Mantle_Duration_sortIndex = 1850;
        [SortOrder(Rocksteady_Mantle_Duration_sortIndex)]
        [DisplayName(Rocksteady_Mantle_Duration_displayName)]
        public virtual float Rocksteady_Mantle_Duration {
            get => GetData<float>(136);
            set {
                if (GetData<float>(136) == value) return;
                SetData(136, value, nameof(Rocksteady_Mantle_Duration));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Rocksteady_Mantle_Duration));
            }
        }

        public const string Rocksteady_Mantle_Unk1_displayName = "Rocksteady Mantle: Unk1";
        public const int Rocksteady_Mantle_Unk1_sortIndex = 1900;
        [SortOrder(Rocksteady_Mantle_Unk1_sortIndex)]
        [DisplayName(Rocksteady_Mantle_Unk1_displayName)]
        public virtual float Rocksteady_Mantle_Unk1 {
            get => GetData<float>(140);
            set {
                if (GetData<float>(140) == value) return;
                SetData(140, value, nameof(Rocksteady_Mantle_Unk1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Rocksteady_Mantle_Unk1));
            }
        }

        public const string Rocksteady_Mantle_Damage_Resist_displayName = "Rocksteady Mantle: Damage Resist";
        public const int Rocksteady_Mantle_Damage_Resist_sortIndex = 1950;
        [SortOrder(Rocksteady_Mantle_Damage_Resist_sortIndex)]
        [DisplayName(Rocksteady_Mantle_Damage_Resist_displayName)]
        public virtual float Rocksteady_Mantle_Damage_Resist {
            get => GetData<float>(144);
            set {
                if (GetData<float>(144) == value) return;
                SetData(144, value, nameof(Rocksteady_Mantle_Damage_Resist));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Rocksteady_Mantle_Damage_Resist));
            }
        }

        public const string Rocksteady_Mantle_Unk2_displayName = "Rocksteady Mantle: Unk2";
        public const int Rocksteady_Mantle_Unk2_sortIndex = 2000;
        [SortOrder(Rocksteady_Mantle_Unk2_sortIndex)]
        [DisplayName(Rocksteady_Mantle_Unk2_displayName)]
        public virtual float Rocksteady_Mantle_Unk2 {
            get => GetData<float>(148);
            set {
                if (GetData<float>(148) == value) return;
                SetData(148, value, nameof(Rocksteady_Mantle_Unk2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Rocksteady_Mantle_Unk2));
            }
        }

        public const string __2050_displayName = "-------------------------------------------------------------------------------------------";
        public const int __2050_sortIndex = 2050;
        [SortOrder(__2050_sortIndex)]
        [DisplayName(__2050_displayName)]
        [IsReadOnly]
        public virtual byte __2050 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__2050));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__2050));
            }
        }

        public const string Challenger_Mantle_Cooldown_displayName = "Challenger Mantle: Cooldown";
        public const int Challenger_Mantle_Cooldown_sortIndex = 2100;
        [SortOrder(Challenger_Mantle_Cooldown_sortIndex)]
        [DisplayName(Challenger_Mantle_Cooldown_displayName)]
        public virtual float Challenger_Mantle_Cooldown {
            get => GetData<float>(152);
            set {
                if (GetData<float>(152) == value) return;
                SetData(152, value, nameof(Challenger_Mantle_Cooldown));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Challenger_Mantle_Cooldown));
            }
        }

        public const string Challenger_Mantle_Duration_displayName = "Challenger Mantle: Duration";
        public const int Challenger_Mantle_Duration_sortIndex = 2150;
        [SortOrder(Challenger_Mantle_Duration_sortIndex)]
        [DisplayName(Challenger_Mantle_Duration_displayName)]
        public virtual float Challenger_Mantle_Duration {
            get => GetData<float>(156);
            set {
                if (GetData<float>(156) == value) return;
                SetData(156, value, nameof(Challenger_Mantle_Duration));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Challenger_Mantle_Duration));
            }
        }

        public const string Challenger_Mantle_Unk1_displayName = "Challenger Mantle: Unk1";
        public const int Challenger_Mantle_Unk1_sortIndex = 2200;
        [SortOrder(Challenger_Mantle_Unk1_sortIndex)]
        [DisplayName(Challenger_Mantle_Unk1_displayName)]
        public virtual float Challenger_Mantle_Unk1 {
            get => GetData<float>(160);
            set {
                if (GetData<float>(160) == value) return;
                SetData(160, value, nameof(Challenger_Mantle_Unk1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Challenger_Mantle_Unk1));
            }
        }

        public const string Challenger_Mantle_Unk2_displayName = "Challenger Mantle: Unk2";
        public const int Challenger_Mantle_Unk2_sortIndex = 2250;
        [SortOrder(Challenger_Mantle_Unk2_sortIndex)]
        [DisplayName(Challenger_Mantle_Unk2_displayName)]
        public virtual float Challenger_Mantle_Unk2 {
            get => GetData<float>(164);
            set {
                if (GetData<float>(164) == value) return;
                SetData(164, value, nameof(Challenger_Mantle_Unk2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Challenger_Mantle_Unk2));
            }
        }

        public const string __2300_displayName = "-------------------------------------------------------------------------------------------";
        public const int __2300_sortIndex = 2300;
        [SortOrder(__2300_sortIndex)]
        [DisplayName(__2300_displayName)]
        [IsReadOnly]
        public virtual byte __2300 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__2300));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__2300));
            }
        }

        public const string Vitality_Mantle_Cooldown_displayName = "Vitality Mantle: Cooldown";
        public const int Vitality_Mantle_Cooldown_sortIndex = 2350;
        [SortOrder(Vitality_Mantle_Cooldown_sortIndex)]
        [DisplayName(Vitality_Mantle_Cooldown_displayName)]
        public virtual float Vitality_Mantle_Cooldown {
            get => GetData<float>(168);
            set {
                if (GetData<float>(168) == value) return;
                SetData(168, value, nameof(Vitality_Mantle_Cooldown));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Vitality_Mantle_Cooldown));
            }
        }

        public const string Vitality_Mantle_Duration_displayName = "Vitality Mantle: Duration";
        public const int Vitality_Mantle_Duration_sortIndex = 2400;
        [SortOrder(Vitality_Mantle_Duration_sortIndex)]
        [DisplayName(Vitality_Mantle_Duration_displayName)]
        public virtual float Vitality_Mantle_Duration {
            get => GetData<float>(172);
            set {
                if (GetData<float>(172) == value) return;
                SetData(172, value, nameof(Vitality_Mantle_Duration));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Vitality_Mantle_Duration));
            }
        }

        public const string Vitality_Mantle_Mantle_Health_displayName = "Vitality Mantle: Mantle Health";
        public const int Vitality_Mantle_Mantle_Health_sortIndex = 2450;
        [SortOrder(Vitality_Mantle_Mantle_Health_sortIndex)]
        [DisplayName(Vitality_Mantle_Mantle_Health_displayName)]
        public virtual float Vitality_Mantle_Mantle_Health {
            get => GetData<float>(176);
            set {
                if (GetData<float>(176) == value) return;
                SetData(176, value, nameof(Vitality_Mantle_Mantle_Health));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Vitality_Mantle_Mantle_Health));
            }
        }

        public const string __2500_displayName = "-------------------------------------------------------------------------------------------";
        public const int __2500_sortIndex = 2500;
        [SortOrder(__2500_sortIndex)]
        [DisplayName(__2500_displayName)]
        [IsReadOnly]
        public virtual byte __2500 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__2500));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__2500));
            }
        }

        public const string Fireproof_Mantle_Cooldown_displayName = "Fireproof Mantle: Cooldown";
        public const int Fireproof_Mantle_Cooldown_sortIndex = 2550;
        [SortOrder(Fireproof_Mantle_Cooldown_sortIndex)]
        [DisplayName(Fireproof_Mantle_Cooldown_displayName)]
        public virtual float Fireproof_Mantle_Cooldown {
            get => GetData<float>(180);
            set {
                if (GetData<float>(180) == value) return;
                SetData(180, value, nameof(Fireproof_Mantle_Cooldown));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Fireproof_Mantle_Cooldown));
            }
        }

        public const string Fireproof_Mantle_Duration_displayName = "Fireproof Mantle: Duration";
        public const int Fireproof_Mantle_Duration_sortIndex = 2600;
        [SortOrder(Fireproof_Mantle_Duration_sortIndex)]
        [DisplayName(Fireproof_Mantle_Duration_displayName)]
        public virtual float Fireproof_Mantle_Duration {
            get => GetData<float>(184);
            set {
                if (GetData<float>(184) == value) return;
                SetData(184, value, nameof(Fireproof_Mantle_Duration));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Fireproof_Mantle_Duration));
            }
        }

        public const string Fireproof_Mantle_Damage_Reduction__displayName = "Fireproof Mantle: Damage Reduction %";
        public const int Fireproof_Mantle_Damage_Reduction__sortIndex = 2650;
        [SortOrder(Fireproof_Mantle_Damage_Reduction__sortIndex)]
        [DisplayName(Fireproof_Mantle_Damage_Reduction__displayName)]
        public virtual float Fireproof_Mantle_Damage_Reduction_ {
            get => GetData<float>(188);
            set {
                if (GetData<float>(188) == value) return;
                SetData(188, value, nameof(Fireproof_Mantle_Damage_Reduction_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Fireproof_Mantle_Damage_Reduction_));
            }
        }

        public const string __2700_displayName = "-------------------------------------------------------------------------------------------";
        public const int __2700_sortIndex = 2700;
        [SortOrder(__2700_sortIndex)]
        [DisplayName(__2700_displayName)]
        [IsReadOnly]
        public virtual byte __2700 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__2700));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__2700));
            }
        }

        public const string Waterproof_Mantle_Cooldown_displayName = "Waterproof Mantle: Cooldown";
        public const int Waterproof_Mantle_Cooldown_sortIndex = 2750;
        [SortOrder(Waterproof_Mantle_Cooldown_sortIndex)]
        [DisplayName(Waterproof_Mantle_Cooldown_displayName)]
        public virtual float Waterproof_Mantle_Cooldown {
            get => GetData<float>(192);
            set {
                if (GetData<float>(192) == value) return;
                SetData(192, value, nameof(Waterproof_Mantle_Cooldown));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Waterproof_Mantle_Cooldown));
            }
        }

        public const string Waterproof_Mantle_Duration_displayName = "Waterproof Mantle: Duration";
        public const int Waterproof_Mantle_Duration_sortIndex = 2800;
        [SortOrder(Waterproof_Mantle_Duration_sortIndex)]
        [DisplayName(Waterproof_Mantle_Duration_displayName)]
        public virtual float Waterproof_Mantle_Duration {
            get => GetData<float>(196);
            set {
                if (GetData<float>(196) == value) return;
                SetData(196, value, nameof(Waterproof_Mantle_Duration));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Waterproof_Mantle_Duration));
            }
        }

        public const string Waterproof_Mantle_Damage_Reduction__displayName = "Waterproof Mantle: Damage Reduction %";
        public const int Waterproof_Mantle_Damage_Reduction__sortIndex = 2850;
        [SortOrder(Waterproof_Mantle_Damage_Reduction__sortIndex)]
        [DisplayName(Waterproof_Mantle_Damage_Reduction__displayName)]
        public virtual float Waterproof_Mantle_Damage_Reduction_ {
            get => GetData<float>(200);
            set {
                if (GetData<float>(200) == value) return;
                SetData(200, value, nameof(Waterproof_Mantle_Damage_Reduction_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Waterproof_Mantle_Damage_Reduction_));
            }
        }

        public const string __2900_displayName = "-------------------------------------------------------------------------------------------";
        public const int __2900_sortIndex = 2900;
        [SortOrder(__2900_sortIndex)]
        [DisplayName(__2900_displayName)]
        [IsReadOnly]
        public virtual byte __2900 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__2900));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__2900));
            }
        }

        public const string Iceproof_Mantle_Cooldown_displayName = "Iceproof Mantle: Cooldown";
        public const int Iceproof_Mantle_Cooldown_sortIndex = 2950;
        [SortOrder(Iceproof_Mantle_Cooldown_sortIndex)]
        [DisplayName(Iceproof_Mantle_Cooldown_displayName)]
        public virtual float Iceproof_Mantle_Cooldown {
            get => GetData<float>(204);
            set {
                if (GetData<float>(204) == value) return;
                SetData(204, value, nameof(Iceproof_Mantle_Cooldown));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Iceproof_Mantle_Cooldown));
            }
        }

        public const string Iceproof_Mantle_Duration_displayName = "Iceproof Mantle: Duration";
        public const int Iceproof_Mantle_Duration_sortIndex = 3000;
        [SortOrder(Iceproof_Mantle_Duration_sortIndex)]
        [DisplayName(Iceproof_Mantle_Duration_displayName)]
        public virtual float Iceproof_Mantle_Duration {
            get => GetData<float>(208);
            set {
                if (GetData<float>(208) == value) return;
                SetData(208, value, nameof(Iceproof_Mantle_Duration));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Iceproof_Mantle_Duration));
            }
        }

        public const string Iceproof_Mantle_Damage_Reduction__displayName = "Iceproof Mantle: Damage Reduction %";
        public const int Iceproof_Mantle_Damage_Reduction__sortIndex = 3050;
        [SortOrder(Iceproof_Mantle_Damage_Reduction__sortIndex)]
        [DisplayName(Iceproof_Mantle_Damage_Reduction__displayName)]
        public virtual float Iceproof_Mantle_Damage_Reduction_ {
            get => GetData<float>(212);
            set {
                if (GetData<float>(212) == value) return;
                SetData(212, value, nameof(Iceproof_Mantle_Damage_Reduction_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Iceproof_Mantle_Damage_Reduction_));
            }
        }

        public const string __3100_displayName = "-------------------------------------------------------------------------------------------";
        public const int __3100_sortIndex = 3100;
        [SortOrder(__3100_sortIndex)]
        [DisplayName(__3100_displayName)]
        [IsReadOnly]
        public virtual byte __3100 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__3100));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__3100));
            }
        }

        public const string Thunderproof_Mantle_Cooldown_displayName = "Thunderproof Mantle: Cooldown";
        public const int Thunderproof_Mantle_Cooldown_sortIndex = 3150;
        [SortOrder(Thunderproof_Mantle_Cooldown_sortIndex)]
        [DisplayName(Thunderproof_Mantle_Cooldown_displayName)]
        public virtual float Thunderproof_Mantle_Cooldown {
            get => GetData<float>(216);
            set {
                if (GetData<float>(216) == value) return;
                SetData(216, value, nameof(Thunderproof_Mantle_Cooldown));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Thunderproof_Mantle_Cooldown));
            }
        }

        public const string Thunderproof_Mantle_Duration_displayName = "Thunderproof Mantle: Duration";
        public const int Thunderproof_Mantle_Duration_sortIndex = 3200;
        [SortOrder(Thunderproof_Mantle_Duration_sortIndex)]
        [DisplayName(Thunderproof_Mantle_Duration_displayName)]
        public virtual float Thunderproof_Mantle_Duration {
            get => GetData<float>(220);
            set {
                if (GetData<float>(220) == value) return;
                SetData(220, value, nameof(Thunderproof_Mantle_Duration));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Thunderproof_Mantle_Duration));
            }
        }

        public const string Thunderproof_Mantle_Damage_Reduction__displayName = "Thunderproof Mantle: Damage Reduction %";
        public const int Thunderproof_Mantle_Damage_Reduction__sortIndex = 3250;
        [SortOrder(Thunderproof_Mantle_Damage_Reduction__sortIndex)]
        [DisplayName(Thunderproof_Mantle_Damage_Reduction__displayName)]
        public virtual float Thunderproof_Mantle_Damage_Reduction_ {
            get => GetData<float>(224);
            set {
                if (GetData<float>(224) == value) return;
                SetData(224, value, nameof(Thunderproof_Mantle_Damage_Reduction_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Thunderproof_Mantle_Damage_Reduction_));
            }
        }

        public const string __3300_displayName = "-------------------------------------------------------------------------------------------";
        public const int __3300_sortIndex = 3300;
        [SortOrder(__3300_sortIndex)]
        [DisplayName(__3300_displayName)]
        [IsReadOnly]
        public virtual byte __3300 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__3300));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__3300));
            }
        }

        public const string Dragonproof_Mantle_Cooldown_displayName = "Dragonproof Mantle: Cooldown";
        public const int Dragonproof_Mantle_Cooldown_sortIndex = 3350;
        [SortOrder(Dragonproof_Mantle_Cooldown_sortIndex)]
        [DisplayName(Dragonproof_Mantle_Cooldown_displayName)]
        public virtual float Dragonproof_Mantle_Cooldown {
            get => GetData<float>(228);
            set {
                if (GetData<float>(228) == value) return;
                SetData(228, value, nameof(Dragonproof_Mantle_Cooldown));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dragonproof_Mantle_Cooldown));
            }
        }

        public const string Dragonproof_Mantle_Duration_displayName = "Dragonproof Mantle: Duration";
        public const int Dragonproof_Mantle_Duration_sortIndex = 3400;
        [SortOrder(Dragonproof_Mantle_Duration_sortIndex)]
        [DisplayName(Dragonproof_Mantle_Duration_displayName)]
        public virtual float Dragonproof_Mantle_Duration {
            get => GetData<float>(232);
            set {
                if (GetData<float>(232) == value) return;
                SetData(232, value, nameof(Dragonproof_Mantle_Duration));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dragonproof_Mantle_Duration));
            }
        }

        public const string Dragonproof_Mantle_Damage_Reduction__displayName = "Dragonproof Mantle: Damage Reduction %";
        public const int Dragonproof_Mantle_Damage_Reduction__sortIndex = 3450;
        [SortOrder(Dragonproof_Mantle_Damage_Reduction__sortIndex)]
        [DisplayName(Dragonproof_Mantle_Damage_Reduction__displayName)]
        public virtual float Dragonproof_Mantle_Damage_Reduction_ {
            get => GetData<float>(236);
            set {
                if (GetData<float>(236) == value) return;
                SetData(236, value, nameof(Dragonproof_Mantle_Damage_Reduction_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dragonproof_Mantle_Damage_Reduction_));
            }
        }

        public const string Dragonproof_Mantle_Dragon_Damage_Multiplier_displayName = "Dragonproof Mantle: Dragon Damage Multiplier";
        public const int Dragonproof_Mantle_Dragon_Damage_Multiplier_sortIndex = 3500;
        [SortOrder(Dragonproof_Mantle_Dragon_Damage_Multiplier_sortIndex)]
        [DisplayName(Dragonproof_Mantle_Dragon_Damage_Multiplier_displayName)]
        public virtual float Dragonproof_Mantle_Dragon_Damage_Multiplier {
            get => GetData<float>(240);
            set {
                if (GetData<float>(240) == value) return;
                SetData(240, value, nameof(Dragonproof_Mantle_Dragon_Damage_Multiplier));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dragonproof_Mantle_Dragon_Damage_Multiplier));
            }
        }

        public const string __3550_displayName = "-------------------------------------------------------------------------------------------";
        public const int __3550_sortIndex = 3550;
        [SortOrder(__3550_sortIndex)]
        [DisplayName(__3550_displayName)]
        [IsReadOnly]
        public virtual byte __3550 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__3550));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__3550));
            }
        }

        public const string Cleanser_Booster_Cooldown_displayName = "Cleanser Booster: Cooldown";
        public const int Cleanser_Booster_Cooldown_sortIndex = 3600;
        [SortOrder(Cleanser_Booster_Cooldown_sortIndex)]
        [DisplayName(Cleanser_Booster_Cooldown_displayName)]
        public virtual float Cleanser_Booster_Cooldown {
            get => GetData<float>(244);
            set {
                if (GetData<float>(244) == value) return;
                SetData(244, value, nameof(Cleanser_Booster_Cooldown));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Cleanser_Booster_Cooldown));
            }
        }

        public const string Cleanser_Booster_Duration_displayName = "Cleanser Booster: Duration";
        public const int Cleanser_Booster_Duration_sortIndex = 3650;
        [SortOrder(Cleanser_Booster_Duration_sortIndex)]
        [DisplayName(Cleanser_Booster_Duration_displayName)]
        public virtual float Cleanser_Booster_Duration {
            get => GetData<float>(248);
            set {
                if (GetData<float>(248) == value) return;
                SetData(248, value, nameof(Cleanser_Booster_Duration));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Cleanser_Booster_Duration));
            }
        }

        public const string Cleanser_Booster_Upgraded_Duration_displayName = "Cleanser Booster: Upgraded Duration";
        public const int Cleanser_Booster_Upgraded_Duration_sortIndex = 3700;
        [SortOrder(Cleanser_Booster_Upgraded_Duration_sortIndex)]
        [DisplayName(Cleanser_Booster_Upgraded_Duration_displayName)]
        public virtual float Cleanser_Booster_Upgraded_Duration {
            get => GetData<float>(252);
            set {
                if (GetData<float>(252) == value) return;
                SetData(252, value, nameof(Cleanser_Booster_Upgraded_Duration));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Cleanser_Booster_Upgraded_Duration));
            }
        }

        public const string Cleanser_Booster_Unk1_displayName = "Cleanser Booster: Unk1";
        public const int Cleanser_Booster_Unk1_sortIndex = 3750;
        [SortOrder(Cleanser_Booster_Unk1_sortIndex)]
        [DisplayName(Cleanser_Booster_Unk1_displayName)]
        public virtual float Cleanser_Booster_Unk1 {
            get => GetData<float>(256);
            set {
                if (GetData<float>(256) == value) return;
                SetData(256, value, nameof(Cleanser_Booster_Unk1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Cleanser_Booster_Unk1));
            }
        }

        public const string Cleanser_Booster_Unk2_displayName = "Cleanser Booster: Unk2";
        public const int Cleanser_Booster_Unk2_sortIndex = 3800;
        [SortOrder(Cleanser_Booster_Unk2_sortIndex)]
        [DisplayName(Cleanser_Booster_Unk2_displayName)]
        public virtual float Cleanser_Booster_Unk2 {
            get => GetData<float>(260);
            set {
                if (GetData<float>(260) == value) return;
                SetData(260, value, nameof(Cleanser_Booster_Unk2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Cleanser_Booster_Unk2));
            }
        }

        public const string Cleanser_Booster_Unk3_displayName = "Cleanser Booster: Unk3";
        public const int Cleanser_Booster_Unk3_sortIndex = 3850;
        [SortOrder(Cleanser_Booster_Unk3_sortIndex)]
        [DisplayName(Cleanser_Booster_Unk3_displayName)]
        public virtual float Cleanser_Booster_Unk3 {
            get => GetData<float>(264);
            set {
                if (GetData<float>(264) == value) return;
                SetData(264, value, nameof(Cleanser_Booster_Unk3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Cleanser_Booster_Unk3));
            }
        }

        public const string Cleanser_Booster_Unk4_displayName = "Cleanser Booster: Unk4";
        public const int Cleanser_Booster_Unk4_sortIndex = 3900;
        [SortOrder(Cleanser_Booster_Unk4_sortIndex)]
        [DisplayName(Cleanser_Booster_Unk4_displayName)]
        public virtual float Cleanser_Booster_Unk4 {
            get => GetData<float>(268);
            set {
                if (GetData<float>(268) == value) return;
                SetData(268, value, nameof(Cleanser_Booster_Unk4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Cleanser_Booster_Unk4));
            }
        }

        public const string __3950_displayName = "-------------------------------------------------------------------------------------------";
        public const int __3950_sortIndex = 3950;
        [SortOrder(__3950_sortIndex)]
        [DisplayName(__3950_displayName)]
        [IsReadOnly]
        public virtual byte __3950 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__3950));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__3950));
            }
        }

        public const string Glider_Mantle_Cooldown_displayName = "Glider Mantle: Cooldown";
        public const int Glider_Mantle_Cooldown_sortIndex = 4000;
        [SortOrder(Glider_Mantle_Cooldown_sortIndex)]
        [DisplayName(Glider_Mantle_Cooldown_displayName)]
        public virtual float Glider_Mantle_Cooldown {
            get => GetData<float>(272);
            set {
                if (GetData<float>(272) == value) return;
                SetData(272, value, nameof(Glider_Mantle_Cooldown));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Glider_Mantle_Cooldown));
            }
        }

        public const string Glider_Mantle_Duration_displayName = "Glider Mantle: Duration";
        public const int Glider_Mantle_Duration_sortIndex = 4050;
        [SortOrder(Glider_Mantle_Duration_sortIndex)]
        [DisplayName(Glider_Mantle_Duration_displayName)]
        public virtual float Glider_Mantle_Duration {
            get => GetData<float>(276);
            set {
                if (GetData<float>(276) == value) return;
                SetData(276, value, nameof(Glider_Mantle_Duration));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Glider_Mantle_Duration));
            }
        }

        public const string Glider_Mantle_Mount_Multiplier_displayName = "Glider Mantle: Mount Multiplier";
        public const int Glider_Mantle_Mount_Multiplier_sortIndex = 4100;
        [SortOrder(Glider_Mantle_Mount_Multiplier_sortIndex)]
        [DisplayName(Glider_Mantle_Mount_Multiplier_displayName)]
        public virtual float Glider_Mantle_Mount_Multiplier {
            get => GetData<float>(280);
            set {
                if (GetData<float>(280) == value) return;
                SetData(280, value, nameof(Glider_Mantle_Mount_Multiplier));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Glider_Mantle_Mount_Multiplier));
            }
        }

        public const string __4150_displayName = "-------------------------------------------------------------------------------------------";
        public const int __4150_sortIndex = 4150;
        [SortOrder(__4150_sortIndex)]
        [DisplayName(__4150_displayName)]
        [IsReadOnly]
        public virtual byte __4150 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__4150));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__4150));
            }
        }

        public const string Evasion_Mantle_Cooldown_displayName = "Evasion Mantle: Cooldown";
        public const int Evasion_Mantle_Cooldown_sortIndex = 4200;
        [SortOrder(Evasion_Mantle_Cooldown_sortIndex)]
        [DisplayName(Evasion_Mantle_Cooldown_displayName)]
        public virtual float Evasion_Mantle_Cooldown {
            get => GetData<float>(284);
            set {
                if (GetData<float>(284) == value) return;
                SetData(284, value, nameof(Evasion_Mantle_Cooldown));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Evasion_Mantle_Cooldown));
            }
        }

        public const string Evasion_Mantle_Duration_displayName = "Evasion Mantle: Duration";
        public const int Evasion_Mantle_Duration_sortIndex = 4250;
        [SortOrder(Evasion_Mantle_Duration_sortIndex)]
        [DisplayName(Evasion_Mantle_Duration_displayName)]
        public virtual float Evasion_Mantle_Duration {
            get => GetData<float>(288);
            set {
                if (GetData<float>(288) == value) return;
                SetData(288, value, nameof(Evasion_Mantle_Duration));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Evasion_Mantle_Duration));
            }
        }

        public const string Evasion_Mantle_Attack_Boost_Duration_displayName = "Evasion Mantle: Attack Boost Duration";
        public const int Evasion_Mantle_Attack_Boost_Duration_sortIndex = 4300;
        [SortOrder(Evasion_Mantle_Attack_Boost_Duration_sortIndex)]
        [DisplayName(Evasion_Mantle_Attack_Boost_Duration_displayName)]
        public virtual float Evasion_Mantle_Attack_Boost_Duration {
            get => GetData<float>(292);
            set {
                if (GetData<float>(292) == value) return;
                SetData(292, value, nameof(Evasion_Mantle_Attack_Boost_Duration));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Evasion_Mantle_Attack_Boost_Duration));
            }
        }

        public const string Evasion_Mantle_Evasion_Multiplier_displayName = "Evasion Mantle: Evasion Multiplier";
        public const int Evasion_Mantle_Evasion_Multiplier_sortIndex = 4350;
        [SortOrder(Evasion_Mantle_Evasion_Multiplier_sortIndex)]
        [DisplayName(Evasion_Mantle_Evasion_Multiplier_displayName)]
        public virtual float Evasion_Mantle_Evasion_Multiplier {
            get => GetData<float>(296);
            set {
                if (GetData<float>(296) == value) return;
                SetData(296, value, nameof(Evasion_Mantle_Evasion_Multiplier));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Evasion_Mantle_Evasion_Multiplier));
            }
        }

        public const string Evasion_Mantle_Unk1_displayName = "Evasion Mantle: Unk1";
        public const int Evasion_Mantle_Unk1_sortIndex = 4400;
        [SortOrder(Evasion_Mantle_Unk1_sortIndex)]
        [DisplayName(Evasion_Mantle_Unk1_displayName)]
        public virtual float Evasion_Mantle_Unk1 {
            get => GetData<float>(300);
            set {
                if (GetData<float>(300) == value) return;
                SetData(300, value, nameof(Evasion_Mantle_Unk1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Evasion_Mantle_Unk1));
            }
        }

        public const string Evasion_Mantle_Unk2_displayName = "Evasion Mantle: Unk2";
        public const int Evasion_Mantle_Unk2_sortIndex = 4450;
        [SortOrder(Evasion_Mantle_Unk2_sortIndex)]
        [DisplayName(Evasion_Mantle_Unk2_displayName)]
        public virtual byte Evasion_Mantle_Unk2 {
            get => GetData<byte>(304);
            set {
                if (GetData<byte>(304) == value) return;
                SetData(304, value, nameof(Evasion_Mantle_Unk2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Evasion_Mantle_Unk2));
            }
        }

        public const string Evasion_Mantle_Unk3_displayName = "Evasion Mantle: Unk3";
        public const int Evasion_Mantle_Unk3_sortIndex = 4500;
        [SortOrder(Evasion_Mantle_Unk3_sortIndex)]
        [DisplayName(Evasion_Mantle_Unk3_displayName)]
        public virtual ushort Evasion_Mantle_Unk3 {
            get => GetData<ushort>(305);
            set {
                if (GetData<ushort>(305) == value) return;
                SetData(305, value, nameof(Evasion_Mantle_Unk3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Evasion_Mantle_Unk3));
            }
        }

        public const string Evasion_Mantle_Unk4_displayName = "Evasion Mantle: Unk4";
        public const int Evasion_Mantle_Unk4_sortIndex = 4550;
        [SortOrder(Evasion_Mantle_Unk4_sortIndex)]
        [DisplayName(Evasion_Mantle_Unk4_displayName)]
        public virtual ushort Evasion_Mantle_Unk4 {
            get => GetData<ushort>(307);
            set {
                if (GetData<ushort>(307) == value) return;
                SetData(307, value, nameof(Evasion_Mantle_Unk4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Evasion_Mantle_Unk4));
            }
        }

        public const string Evasion_Mantle_Unk5_displayName = "Evasion Mantle: Unk5";
        public const int Evasion_Mantle_Unk5_sortIndex = 4600;
        [SortOrder(Evasion_Mantle_Unk5_sortIndex)]
        [DisplayName(Evasion_Mantle_Unk5_displayName)]
        public virtual float Evasion_Mantle_Unk5 {
            get => GetData<float>(309);
            set {
                if (GetData<float>(309) == value) return;
                SetData(309, value, nameof(Evasion_Mantle_Unk5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Evasion_Mantle_Unk5));
            }
        }

        public const string Evasion_Mantle_Unk6_displayName = "Evasion Mantle: Unk6";
        public const int Evasion_Mantle_Unk6_sortIndex = 4650;
        [SortOrder(Evasion_Mantle_Unk6_sortIndex)]
        [DisplayName(Evasion_Mantle_Unk6_displayName)]
        public virtual ushort Evasion_Mantle_Unk6 {
            get => GetData<ushort>(313);
            set {
                if (GetData<ushort>(313) == value) return;
                SetData(313, value, nameof(Evasion_Mantle_Unk6));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Evasion_Mantle_Unk6));
            }
        }

        public const string __4700_displayName = "-------------------------------------------------------------------------------------------";
        public const int __4700_sortIndex = 4700;
        [SortOrder(__4700_sortIndex)]
        [DisplayName(__4700_displayName)]
        [IsReadOnly]
        public virtual byte __4700 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__4700));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__4700));
            }
        }

        public const string Impact_Mantle_Cooldown_displayName = "Impact Mantle: Cooldown";
        public const int Impact_Mantle_Cooldown_sortIndex = 4750;
        [SortOrder(Impact_Mantle_Cooldown_sortIndex)]
        [DisplayName(Impact_Mantle_Cooldown_displayName)]
        public virtual float Impact_Mantle_Cooldown {
            get => GetData<float>(315);
            set {
                if (GetData<float>(315) == value) return;
                SetData(315, value, nameof(Impact_Mantle_Cooldown));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Impact_Mantle_Cooldown));
            }
        }

        public const string Impact_Mantle_Duration_displayName = "Impact Mantle: Duration";
        public const int Impact_Mantle_Duration_sortIndex = 4800;
        [SortOrder(Impact_Mantle_Duration_sortIndex)]
        [DisplayName(Impact_Mantle_Duration_displayName)]
        public virtual float Impact_Mantle_Duration {
            get => GetData<float>(319);
            set {
                if (GetData<float>(319) == value) return;
                SetData(319, value, nameof(Impact_Mantle_Duration));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Impact_Mantle_Duration));
            }
        }

        public const string Impact_Mantle_Motion_Value_Needed_for_Light_Attack_Stun_Bonus_displayName = "Impact Mantle: Motion Value Needed for Light Attack Stun Bonus";
        public const int Impact_Mantle_Motion_Value_Needed_for_Light_Attack_Stun_Bonus_sortIndex = 4850;
        [SortOrder(Impact_Mantle_Motion_Value_Needed_for_Light_Attack_Stun_Bonus_sortIndex)]
        [DisplayName(Impact_Mantle_Motion_Value_Needed_for_Light_Attack_Stun_Bonus_displayName)]
        public virtual float Impact_Mantle_Motion_Value_Needed_for_Light_Attack_Stun_Bonus {
            get => GetData<float>(323);
            set {
                if (GetData<float>(323) == value) return;
                SetData(323, value, nameof(Impact_Mantle_Motion_Value_Needed_for_Light_Attack_Stun_Bonus));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Impact_Mantle_Motion_Value_Needed_for_Light_Attack_Stun_Bonus));
            }
        }

        public const string Impact_Mantle_Motion_Value_Needed_for_Heavy_Attack_Stun_Bonus_displayName = "Impact Mantle: Motion Value Needed for Heavy Attack Stun Bonus";
        public const int Impact_Mantle_Motion_Value_Needed_for_Heavy_Attack_Stun_Bonus_sortIndex = 4900;
        [SortOrder(Impact_Mantle_Motion_Value_Needed_for_Heavy_Attack_Stun_Bonus_sortIndex)]
        [DisplayName(Impact_Mantle_Motion_Value_Needed_for_Heavy_Attack_Stun_Bonus_displayName)]
        public virtual float Impact_Mantle_Motion_Value_Needed_for_Heavy_Attack_Stun_Bonus {
            get => GetData<float>(327);
            set {
                if (GetData<float>(327) == value) return;
                SetData(327, value, nameof(Impact_Mantle_Motion_Value_Needed_for_Heavy_Attack_Stun_Bonus));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Impact_Mantle_Motion_Value_Needed_for_Heavy_Attack_Stun_Bonus));
            }
        }

        public const string Impact_Mantle_Motion_Value_Needed_for_Extreme_Attack_Stun_Bonus_displayName = "Impact Mantle: Motion Value Needed for Extreme Attack Stun Bonus";
        public const int Impact_Mantle_Motion_Value_Needed_for_Extreme_Attack_Stun_Bonus_sortIndex = 4950;
        [SortOrder(Impact_Mantle_Motion_Value_Needed_for_Extreme_Attack_Stun_Bonus_sortIndex)]
        [DisplayName(Impact_Mantle_Motion_Value_Needed_for_Extreme_Attack_Stun_Bonus_displayName)]
        public virtual float Impact_Mantle_Motion_Value_Needed_for_Extreme_Attack_Stun_Bonus {
            get => GetData<float>(331);
            set {
                if (GetData<float>(331) == value) return;
                SetData(331, value, nameof(Impact_Mantle_Motion_Value_Needed_for_Extreme_Attack_Stun_Bonus));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Impact_Mantle_Motion_Value_Needed_for_Extreme_Attack_Stun_Bonus));
            }
        }

        public const string Impact_Mantle_Weak_Attack_Stun_Bonus_displayName = "Impact Mantle: Weak Attack Stun Bonus";
        public const int Impact_Mantle_Weak_Attack_Stun_Bonus_sortIndex = 5000;
        [SortOrder(Impact_Mantle_Weak_Attack_Stun_Bonus_sortIndex)]
        [DisplayName(Impact_Mantle_Weak_Attack_Stun_Bonus_displayName)]
        public virtual float Impact_Mantle_Weak_Attack_Stun_Bonus {
            get => GetData<float>(335);
            set {
                if (GetData<float>(335) == value) return;
                SetData(335, value, nameof(Impact_Mantle_Weak_Attack_Stun_Bonus));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Impact_Mantle_Weak_Attack_Stun_Bonus));
            }
        }

        public const string Impact_Mantle_Light_Attack_Stun_Bonus_displayName = "Impact Mantle: Light Attack Stun Bonus";
        public const int Impact_Mantle_Light_Attack_Stun_Bonus_sortIndex = 5050;
        [SortOrder(Impact_Mantle_Light_Attack_Stun_Bonus_sortIndex)]
        [DisplayName(Impact_Mantle_Light_Attack_Stun_Bonus_displayName)]
        public virtual float Impact_Mantle_Light_Attack_Stun_Bonus {
            get => GetData<float>(339);
            set {
                if (GetData<float>(339) == value) return;
                SetData(339, value, nameof(Impact_Mantle_Light_Attack_Stun_Bonus));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Impact_Mantle_Light_Attack_Stun_Bonus));
            }
        }

        public const string Impact_Mantle_Heavy_Attack_Stun_Bonus_displayName = "Impact Mantle: Heavy Attack Stun Bonus";
        public const int Impact_Mantle_Heavy_Attack_Stun_Bonus_sortIndex = 5100;
        [SortOrder(Impact_Mantle_Heavy_Attack_Stun_Bonus_sortIndex)]
        [DisplayName(Impact_Mantle_Heavy_Attack_Stun_Bonus_displayName)]
        public virtual float Impact_Mantle_Heavy_Attack_Stun_Bonus {
            get => GetData<float>(343);
            set {
                if (GetData<float>(343) == value) return;
                SetData(343, value, nameof(Impact_Mantle_Heavy_Attack_Stun_Bonus));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Impact_Mantle_Heavy_Attack_Stun_Bonus));
            }
        }

        public const string Impact_Mantle_Extreme_Attack_Stun_Bonus_displayName = "Impact Mantle: Extreme Attack Stun Bonus";
        public const int Impact_Mantle_Extreme_Attack_Stun_Bonus_sortIndex = 5150;
        [SortOrder(Impact_Mantle_Extreme_Attack_Stun_Bonus_sortIndex)]
        [DisplayName(Impact_Mantle_Extreme_Attack_Stun_Bonus_displayName)]
        public virtual float Impact_Mantle_Extreme_Attack_Stun_Bonus {
            get => GetData<float>(347);
            set {
                if (GetData<float>(347) == value) return;
                SetData(347, value, nameof(Impact_Mantle_Extreme_Attack_Stun_Bonus));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Impact_Mantle_Extreme_Attack_Stun_Bonus));
            }
        }

        public const string Impact_Mantle_Existing_Stun_Multiplier_displayName = "Impact Mantle: Existing Stun Multiplier";
        public const int Impact_Mantle_Existing_Stun_Multiplier_sortIndex = 5200;
        [SortOrder(Impact_Mantle_Existing_Stun_Multiplier_sortIndex)]
        [DisplayName(Impact_Mantle_Existing_Stun_Multiplier_displayName)]
        public virtual float Impact_Mantle_Existing_Stun_Multiplier {
            get => GetData<float>(351);
            set {
                if (GetData<float>(351) == value) return;
                SetData(351, value, nameof(Impact_Mantle_Existing_Stun_Multiplier));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Impact_Mantle_Existing_Stun_Multiplier));
            }
        }

        public const string Impact_Mantle_Motion_Value_Needed_for_Light_Attack_Exhaust_Bonus_displayName = "Impact Mantle: Motion Value Needed for Light Attack Exhaust Bonus";
        public const int Impact_Mantle_Motion_Value_Needed_for_Light_Attack_Exhaust_Bonus_sortIndex = 5250;
        [SortOrder(Impact_Mantle_Motion_Value_Needed_for_Light_Attack_Exhaust_Bonus_sortIndex)]
        [DisplayName(Impact_Mantle_Motion_Value_Needed_for_Light_Attack_Exhaust_Bonus_displayName)]
        public virtual float Impact_Mantle_Motion_Value_Needed_for_Light_Attack_Exhaust_Bonus {
            get => GetData<float>(355);
            set {
                if (GetData<float>(355) == value) return;
                SetData(355, value, nameof(Impact_Mantle_Motion_Value_Needed_for_Light_Attack_Exhaust_Bonus));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Impact_Mantle_Motion_Value_Needed_for_Light_Attack_Exhaust_Bonus));
            }
        }

        public const string Impact_Mantle_Motion_Value_Needed_for_Heavy_Attack_Exhaust_Bonus_displayName = "Impact Mantle: Motion Value Needed for Heavy Attack Exhaust Bonus";
        public const int Impact_Mantle_Motion_Value_Needed_for_Heavy_Attack_Exhaust_Bonus_sortIndex = 5300;
        [SortOrder(Impact_Mantle_Motion_Value_Needed_for_Heavy_Attack_Exhaust_Bonus_sortIndex)]
        [DisplayName(Impact_Mantle_Motion_Value_Needed_for_Heavy_Attack_Exhaust_Bonus_displayName)]
        public virtual float Impact_Mantle_Motion_Value_Needed_for_Heavy_Attack_Exhaust_Bonus {
            get => GetData<float>(359);
            set {
                if (GetData<float>(359) == value) return;
                SetData(359, value, nameof(Impact_Mantle_Motion_Value_Needed_for_Heavy_Attack_Exhaust_Bonus));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Impact_Mantle_Motion_Value_Needed_for_Heavy_Attack_Exhaust_Bonus));
            }
        }

        public const string Impact_Mantle_Motion_Value_Needed_for_Extreme_Attack_Exhaust_Bonus_displayName = "Impact Mantle: Motion Value Needed for Extreme Attack Exhaust Bonus";
        public const int Impact_Mantle_Motion_Value_Needed_for_Extreme_Attack_Exhaust_Bonus_sortIndex = 5350;
        [SortOrder(Impact_Mantle_Motion_Value_Needed_for_Extreme_Attack_Exhaust_Bonus_sortIndex)]
        [DisplayName(Impact_Mantle_Motion_Value_Needed_for_Extreme_Attack_Exhaust_Bonus_displayName)]
        public virtual float Impact_Mantle_Motion_Value_Needed_for_Extreme_Attack_Exhaust_Bonus {
            get => GetData<float>(363);
            set {
                if (GetData<float>(363) == value) return;
                SetData(363, value, nameof(Impact_Mantle_Motion_Value_Needed_for_Extreme_Attack_Exhaust_Bonus));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Impact_Mantle_Motion_Value_Needed_for_Extreme_Attack_Exhaust_Bonus));
            }
        }

        public const string Impact_Mantle_Weak_Attack_Exhaust_Bonus_displayName = "Impact Mantle: Weak Attack Exhaust Bonus";
        public const int Impact_Mantle_Weak_Attack_Exhaust_Bonus_sortIndex = 5400;
        [SortOrder(Impact_Mantle_Weak_Attack_Exhaust_Bonus_sortIndex)]
        [DisplayName(Impact_Mantle_Weak_Attack_Exhaust_Bonus_displayName)]
        public virtual float Impact_Mantle_Weak_Attack_Exhaust_Bonus {
            get => GetData<float>(367);
            set {
                if (GetData<float>(367) == value) return;
                SetData(367, value, nameof(Impact_Mantle_Weak_Attack_Exhaust_Bonus));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Impact_Mantle_Weak_Attack_Exhaust_Bonus));
            }
        }

        public const string Impact_Mantle_Light_Attack_Exhaust_Bonus_displayName = "Impact Mantle: Light Attack Exhaust Bonus";
        public const int Impact_Mantle_Light_Attack_Exhaust_Bonus_sortIndex = 5450;
        [SortOrder(Impact_Mantle_Light_Attack_Exhaust_Bonus_sortIndex)]
        [DisplayName(Impact_Mantle_Light_Attack_Exhaust_Bonus_displayName)]
        public virtual float Impact_Mantle_Light_Attack_Exhaust_Bonus {
            get => GetData<float>(371);
            set {
                if (GetData<float>(371) == value) return;
                SetData(371, value, nameof(Impact_Mantle_Light_Attack_Exhaust_Bonus));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Impact_Mantle_Light_Attack_Exhaust_Bonus));
            }
        }

        public const string Impact_Mantle_Heavy_Attack_Exhaust_Bonus_displayName = "Impact Mantle: Heavy Attack Exhaust Bonus";
        public const int Impact_Mantle_Heavy_Attack_Exhaust_Bonus_sortIndex = 5500;
        [SortOrder(Impact_Mantle_Heavy_Attack_Exhaust_Bonus_sortIndex)]
        [DisplayName(Impact_Mantle_Heavy_Attack_Exhaust_Bonus_displayName)]
        public virtual float Impact_Mantle_Heavy_Attack_Exhaust_Bonus {
            get => GetData<float>(375);
            set {
                if (GetData<float>(375) == value) return;
                SetData(375, value, nameof(Impact_Mantle_Heavy_Attack_Exhaust_Bonus));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Impact_Mantle_Heavy_Attack_Exhaust_Bonus));
            }
        }

        public const string Impact_Mantle_Extreme_Attack_Exhaust_Bonus_displayName = "Impact Mantle: Extreme Attack Exhaust Bonus";
        public const int Impact_Mantle_Extreme_Attack_Exhaust_Bonus_sortIndex = 5550;
        [SortOrder(Impact_Mantle_Extreme_Attack_Exhaust_Bonus_sortIndex)]
        [DisplayName(Impact_Mantle_Extreme_Attack_Exhaust_Bonus_displayName)]
        public virtual float Impact_Mantle_Extreme_Attack_Exhaust_Bonus {
            get => GetData<float>(379);
            set {
                if (GetData<float>(379) == value) return;
                SetData(379, value, nameof(Impact_Mantle_Extreme_Attack_Exhaust_Bonus));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Impact_Mantle_Extreme_Attack_Exhaust_Bonus));
            }
        }

        public const string Impact_Mantle_Existing_Exhaust_Multiplier_displayName = "Impact Mantle: Existing Exhaust Multiplier";
        public const int Impact_Mantle_Existing_Exhaust_Multiplier_sortIndex = 5600;
        [SortOrder(Impact_Mantle_Existing_Exhaust_Multiplier_sortIndex)]
        [DisplayName(Impact_Mantle_Existing_Exhaust_Multiplier_displayName)]
        public virtual float Impact_Mantle_Existing_Exhaust_Multiplier {
            get => GetData<float>(383);
            set {
                if (GetData<float>(383) == value) return;
                SetData(383, value, nameof(Impact_Mantle_Existing_Exhaust_Multiplier));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Impact_Mantle_Existing_Exhaust_Multiplier));
            }
        }

        public const string __5650_displayName = "-------------------------------------------------------------------------------------------";
        public const int __5650_sortIndex = 5650;
        [SortOrder(__5650_sortIndex)]
        [DisplayName(__5650_displayName)]
        [IsReadOnly]
        public virtual byte __5650 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__5650));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__5650));
            }
        }

        public const string Apothecary_Mantle_Cooldown_displayName = "Apothecary Mantle: Cooldown";
        public const int Apothecary_Mantle_Cooldown_sortIndex = 5700;
        [SortOrder(Apothecary_Mantle_Cooldown_sortIndex)]
        [DisplayName(Apothecary_Mantle_Cooldown_displayName)]
        public virtual float Apothecary_Mantle_Cooldown {
            get => GetData<float>(387);
            set {
                if (GetData<float>(387) == value) return;
                SetData(387, value, nameof(Apothecary_Mantle_Cooldown));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Apothecary_Mantle_Cooldown));
            }
        }

        public const string Apothecary_Mantle_Duration_displayName = "Apothecary Mantle: Duration";
        public const int Apothecary_Mantle_Duration_sortIndex = 5750;
        [SortOrder(Apothecary_Mantle_Duration_sortIndex)]
        [DisplayName(Apothecary_Mantle_Duration_displayName)]
        public virtual float Apothecary_Mantle_Duration {
            get => GetData<float>(391);
            set {
                if (GetData<float>(391) == value) return;
                SetData(391, value, nameof(Apothecary_Mantle_Duration));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Apothecary_Mantle_Duration));
            }
        }

        public const string Apothecary_Mantle_Status_Multiplier_Poison_displayName = "Apothecary Mantle: Status Multiplier: Poison";
        public const int Apothecary_Mantle_Status_Multiplier_Poison_sortIndex = 5800;
        [SortOrder(Apothecary_Mantle_Status_Multiplier_Poison_sortIndex)]
        [DisplayName(Apothecary_Mantle_Status_Multiplier_Poison_displayName)]
        public virtual float Apothecary_Mantle_Status_Multiplier_Poison {
            get => GetData<float>(395);
            set {
                if (GetData<float>(395) == value) return;
                SetData(395, value, nameof(Apothecary_Mantle_Status_Multiplier_Poison));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Apothecary_Mantle_Status_Multiplier_Poison));
            }
        }

        public const string Apothecary_Mantle_Status_Multiplier_Para_displayName = "Apothecary Mantle: Status Multiplier: Para";
        public const int Apothecary_Mantle_Status_Multiplier_Para_sortIndex = 5850;
        [SortOrder(Apothecary_Mantle_Status_Multiplier_Para_sortIndex)]
        [DisplayName(Apothecary_Mantle_Status_Multiplier_Para_displayName)]
        public virtual float Apothecary_Mantle_Status_Multiplier_Para {
            get => GetData<float>(399);
            set {
                if (GetData<float>(399) == value) return;
                SetData(399, value, nameof(Apothecary_Mantle_Status_Multiplier_Para));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Apothecary_Mantle_Status_Multiplier_Para));
            }
        }

        public const string Apothecary_Mantle_Status_Multiplier_Sleep_displayName = "Apothecary Mantle: Status Multiplier: Sleep";
        public const int Apothecary_Mantle_Status_Multiplier_Sleep_sortIndex = 5900;
        [SortOrder(Apothecary_Mantle_Status_Multiplier_Sleep_sortIndex)]
        [DisplayName(Apothecary_Mantle_Status_Multiplier_Sleep_displayName)]
        public virtual float Apothecary_Mantle_Status_Multiplier_Sleep {
            get => GetData<float>(403);
            set {
                if (GetData<float>(403) == value) return;
                SetData(403, value, nameof(Apothecary_Mantle_Status_Multiplier_Sleep));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Apothecary_Mantle_Status_Multiplier_Sleep));
            }
        }

        public const string Apothecary_Mantle_Status_Multiplier_Blast_displayName = "Apothecary Mantle: Status Multiplier: Blast";
        public const int Apothecary_Mantle_Status_Multiplier_Blast_sortIndex = 5950;
        [SortOrder(Apothecary_Mantle_Status_Multiplier_Blast_sortIndex)]
        [DisplayName(Apothecary_Mantle_Status_Multiplier_Blast_displayName)]
        public virtual float Apothecary_Mantle_Status_Multiplier_Blast {
            get => GetData<float>(407);
            set {
                if (GetData<float>(407) == value) return;
                SetData(407, value, nameof(Apothecary_Mantle_Status_Multiplier_Blast));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Apothecary_Mantle_Status_Multiplier_Blast));
            }
        }

        public const string __6000_displayName = "-------------------------------------------------------------------------------------------";
        public const int __6000_sortIndex = 6000;
        [SortOrder(__6000_sortIndex)]
        [DisplayName(__6000_displayName)]
        [IsReadOnly]
        public virtual byte __6000 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__6000));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__6000));
            }
        }

        public const string Immunity_Mantle_Cooldown_displayName = "Immunity Mantle: Cooldown";
        public const int Immunity_Mantle_Cooldown_sortIndex = 6050;
        [SortOrder(Immunity_Mantle_Cooldown_sortIndex)]
        [DisplayName(Immunity_Mantle_Cooldown_displayName)]
        public virtual float Immunity_Mantle_Cooldown {
            get => GetData<float>(411);
            set {
                if (GetData<float>(411) == value) return;
                SetData(411, value, nameof(Immunity_Mantle_Cooldown));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Immunity_Mantle_Cooldown));
            }
        }

        public const string Immunity_Mantle_Duration_displayName = "Immunity Mantle: Duration";
        public const int Immunity_Mantle_Duration_sortIndex = 6100;
        [SortOrder(Immunity_Mantle_Duration_sortIndex)]
        [DisplayName(Immunity_Mantle_Duration_displayName)]
        public virtual float Immunity_Mantle_Duration {
            get => GetData<float>(415);
            set {
                if (GetData<float>(415) == value) return;
                SetData(415, value, nameof(Immunity_Mantle_Duration));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Immunity_Mantle_Duration));
            }
        }

        public const string __6150_displayName = "-------------------------------------------------------------------------------------------";
        public const int __6150_sortIndex = 6150;
        [SortOrder(__6150_sortIndex)]
        [DisplayName(__6150_displayName)]
        [IsReadOnly]
        public virtual byte __6150 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__6150));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__6150));
            }
        }

        public const string Affinity_Booster_Cooldown_displayName = "Affinity Booster: Cooldown";
        public const int Affinity_Booster_Cooldown_sortIndex = 6200;
        [SortOrder(Affinity_Booster_Cooldown_sortIndex)]
        [DisplayName(Affinity_Booster_Cooldown_displayName)]
        public virtual float Affinity_Booster_Cooldown {
            get => GetData<float>(419);
            set {
                if (GetData<float>(419) == value) return;
                SetData(419, value, nameof(Affinity_Booster_Cooldown));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Affinity_Booster_Cooldown));
            }
        }

        public const string Affinity_Booster_Duration_displayName = "Affinity Booster: Duration";
        public const int Affinity_Booster_Duration_sortIndex = 6250;
        [SortOrder(Affinity_Booster_Duration_sortIndex)]
        [DisplayName(Affinity_Booster_Duration_displayName)]
        public virtual float Affinity_Booster_Duration {
            get => GetData<float>(423);
            set {
                if (GetData<float>(423) == value) return;
                SetData(423, value, nameof(Affinity_Booster_Duration));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Affinity_Booster_Duration));
            }
        }

        public const string Affinity_Booster_Buff_Duration_displayName = "Affinity Booster: Buff Duration";
        public const int Affinity_Booster_Buff_Duration_sortIndex = 6300;
        [SortOrder(Affinity_Booster_Buff_Duration_sortIndex)]
        [DisplayName(Affinity_Booster_Buff_Duration_displayName)]
        public virtual float Affinity_Booster_Buff_Duration {
            get => GetData<float>(427);
            set {
                if (GetData<float>(427) == value) return;
                SetData(427, value, nameof(Affinity_Booster_Buff_Duration));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Affinity_Booster_Buff_Duration));
            }
        }

        public const string Affinity_Booster_Buff_Affinity_displayName = "Affinity Booster: Buff Affinity";
        public const int Affinity_Booster_Buff_Affinity_sortIndex = 6350;
        [SortOrder(Affinity_Booster_Buff_Affinity_sortIndex)]
        [DisplayName(Affinity_Booster_Buff_Affinity_displayName)]
        public virtual int Affinity_Booster_Buff_Affinity {
            get => GetData<int>(431);
            set {
                if (GetData<int>(431) == value) return;
                SetData(431, value, nameof(Affinity_Booster_Buff_Affinity));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Affinity_Booster_Buff_Affinity));
            }
        }

        public const string __6400_displayName = "-------------------------------------------------------------------------------------------";
        public const int __6400_sortIndex = 6400;
        [SortOrder(__6400_sortIndex)]
        [DisplayName(__6400_displayName)]
        [IsReadOnly]
        public virtual byte __6400 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__6400));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__6400));
            }
        }

        public const string Bandit_Mantle_Cooldown_displayName = "Bandit Mantle: Cooldown";
        public const int Bandit_Mantle_Cooldown_sortIndex = 6450;
        [SortOrder(Bandit_Mantle_Cooldown_sortIndex)]
        [DisplayName(Bandit_Mantle_Cooldown_displayName)]
        public virtual float Bandit_Mantle_Cooldown {
            get => GetData<float>(435);
            set {
                if (GetData<float>(435) == value) return;
                SetData(435, value, nameof(Bandit_Mantle_Cooldown));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Bandit_Mantle_Cooldown));
            }
        }

        public const string Bandit_Mantle_Duration_displayName = "Bandit Mantle: Duration";
        public const int Bandit_Mantle_Duration_sortIndex = 6500;
        [SortOrder(Bandit_Mantle_Duration_sortIndex)]
        [DisplayName(Bandit_Mantle_Duration_displayName)]
        public virtual float Bandit_Mantle_Duration {
            get => GetData<float>(439);
            set {
                if (GetData<float>(439) == value) return;
                SetData(439, value, nameof(Bandit_Mantle_Duration));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Bandit_Mantle_Duration));
            }
        }

        public const string Bandit_Mantle_Hits_to_Drop_Shiny_displayName = "Bandit Mantle: Hits to Drop Shiny";
        public const int Bandit_Mantle_Hits_to_Drop_Shiny_sortIndex = 6550;
        [SortOrder(Bandit_Mantle_Hits_to_Drop_Shiny_sortIndex)]
        [DisplayName(Bandit_Mantle_Hits_to_Drop_Shiny_displayName)]
        public virtual float Bandit_Mantle_Hits_to_Drop_Shiny {
            get => GetData<float>(443);
            set {
                if (GetData<float>(443) == value) return;
                SetData(443, value, nameof(Bandit_Mantle_Hits_to_Drop_Shiny));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Bandit_Mantle_Hits_to_Drop_Shiny));
            }
        }

        public const string Bandit_Mantle_Unk1_displayName = "Bandit Mantle: Unk1";
        public const int Bandit_Mantle_Unk1_sortIndex = 6600;
        [SortOrder(Bandit_Mantle_Unk1_sortIndex)]
        [DisplayName(Bandit_Mantle_Unk1_displayName)]
        public virtual sbyte Bandit_Mantle_Unk1 {
            get => GetData<sbyte>(447);
            set {
                if (GetData<sbyte>(447) == value) return;
                SetData(447, value, nameof(Bandit_Mantle_Unk1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Bandit_Mantle_Unk1));
            }
        }

        public const string Bandit_Mantle_Unk2_displayName = "Bandit Mantle: Unk2";
        public const int Bandit_Mantle_Unk2_sortIndex = 6650;
        [SortOrder(Bandit_Mantle_Unk2_sortIndex)]
        [DisplayName(Bandit_Mantle_Unk2_displayName)]
        public virtual sbyte Bandit_Mantle_Unk2 {
            get => GetData<sbyte>(448);
            set {
                if (GetData<sbyte>(448) == value) return;
                SetData(448, value, nameof(Bandit_Mantle_Unk2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Bandit_Mantle_Unk2));
            }
        }

        public const string Bandit_Mantle_Unk3_displayName = "Bandit Mantle: Unk3";
        public const int Bandit_Mantle_Unk3_sortIndex = 6700;
        [SortOrder(Bandit_Mantle_Unk3_sortIndex)]
        [DisplayName(Bandit_Mantle_Unk3_displayName)]
        public virtual sbyte Bandit_Mantle_Unk3 {
            get => GetData<sbyte>(449);
            set {
                if (GetData<sbyte>(449) == value) return;
                SetData(449, value, nameof(Bandit_Mantle_Unk3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Bandit_Mantle_Unk3));
            }
        }

        public const string Bandit_Mantle_Unk4_displayName = "Bandit Mantle: Unk4";
        public const int Bandit_Mantle_Unk4_sortIndex = 6750;
        [SortOrder(Bandit_Mantle_Unk4_sortIndex)]
        [DisplayName(Bandit_Mantle_Unk4_displayName)]
        public virtual sbyte Bandit_Mantle_Unk4 {
            get => GetData<sbyte>(450);
            set {
                if (GetData<sbyte>(450) == value) return;
                SetData(450, value, nameof(Bandit_Mantle_Unk4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Bandit_Mantle_Unk4));
            }
        }

        public const string Bandit_Mantle_Unk5_displayName = "Bandit Mantle: Unk5";
        public const int Bandit_Mantle_Unk5_sortIndex = 6800;
        [SortOrder(Bandit_Mantle_Unk5_sortIndex)]
        [DisplayName(Bandit_Mantle_Unk5_displayName)]
        public virtual sbyte Bandit_Mantle_Unk5 {
            get => GetData<sbyte>(451);
            set {
                if (GetData<sbyte>(451) == value) return;
                SetData(451, value, nameof(Bandit_Mantle_Unk5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Bandit_Mantle_Unk5));
            }
        }

        public const string Bandit_Mantle_Unk6_displayName = "Bandit Mantle: Unk6";
        public const int Bandit_Mantle_Unk6_sortIndex = 6850;
        [SortOrder(Bandit_Mantle_Unk6_sortIndex)]
        [DisplayName(Bandit_Mantle_Unk6_displayName)]
        public virtual sbyte Bandit_Mantle_Unk6 {
            get => GetData<sbyte>(452);
            set {
                if (GetData<sbyte>(452) == value) return;
                SetData(452, value, nameof(Bandit_Mantle_Unk6));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Bandit_Mantle_Unk6));
            }
        }

        public const string Bandit_Mantle_Unk7_displayName = "Bandit Mantle: Unk7";
        public const int Bandit_Mantle_Unk7_sortIndex = 6900;
        [SortOrder(Bandit_Mantle_Unk7_sortIndex)]
        [DisplayName(Bandit_Mantle_Unk7_displayName)]
        public virtual sbyte Bandit_Mantle_Unk7 {
            get => GetData<sbyte>(453);
            set {
                if (GetData<sbyte>(453) == value) return;
                SetData(453, value, nameof(Bandit_Mantle_Unk7));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Bandit_Mantle_Unk7));
            }
        }

        public const string Bandit_Mantle_Unk8_displayName = "Bandit Mantle: Unk8";
        public const int Bandit_Mantle_Unk8_sortIndex = 6950;
        [SortOrder(Bandit_Mantle_Unk8_sortIndex)]
        [DisplayName(Bandit_Mantle_Unk8_displayName)]
        public virtual sbyte Bandit_Mantle_Unk8 {
            get => GetData<sbyte>(454);
            set {
                if (GetData<sbyte>(454) == value) return;
                SetData(454, value, nameof(Bandit_Mantle_Unk8));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Bandit_Mantle_Unk8));
            }
        }

        public const string __7000_displayName = "-------------------------------------------------------------------------------------------";
        public const int __7000_sortIndex = 7000;
        [SortOrder(__7000_sortIndex)]
        [DisplayName(__7000_displayName)]
        [IsReadOnly]
        public virtual byte __7000 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__7000));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__7000));
            }
        }

        public const string Assassin_s_Hood_Cooldown_displayName = "Assassin's Hood: Cooldown";
        public const int Assassin_s_Hood_Cooldown_sortIndex = 7050;
        [SortOrder(Assassin_s_Hood_Cooldown_sortIndex)]
        [DisplayName(Assassin_s_Hood_Cooldown_displayName)]
        public virtual float Assassin_s_Hood_Cooldown {
            get => GetData<float>(455);
            set {
                if (GetData<float>(455) == value) return;
                SetData(455, value, nameof(Assassin_s_Hood_Cooldown));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Assassin_s_Hood_Cooldown));
            }
        }

        public const string Assassin_s_Hood_Duration_displayName = "Assassin's Hood: Duration";
        public const int Assassin_s_Hood_Duration_sortIndex = 7100;
        [SortOrder(Assassin_s_Hood_Duration_sortIndex)]
        [DisplayName(Assassin_s_Hood_Duration_displayName)]
        public virtual float Assassin_s_Hood_Duration {
            get => GetData<float>(459);
            set {
                if (GetData<float>(459) == value) return;
                SetData(459, value, nameof(Assassin_s_Hood_Duration));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Assassin_s_Hood_Duration));
            }
        }

        public const string Assassin_s_Hood_Sneak_Attack_Multiplier_displayName = "Assassin's Hood: Sneak Attack Multiplier";
        public const int Assassin_s_Hood_Sneak_Attack_Multiplier_sortIndex = 7150;
        [SortOrder(Assassin_s_Hood_Sneak_Attack_Multiplier_sortIndex)]
        [DisplayName(Assassin_s_Hood_Sneak_Attack_Multiplier_displayName)]
        public virtual float Assassin_s_Hood_Sneak_Attack_Multiplier {
            get => GetData<float>(463);
            set {
                if (GetData<float>(463) == value) return;
                SetData(463, value, nameof(Assassin_s_Hood_Sneak_Attack_Multiplier));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Assassin_s_Hood_Sneak_Attack_Multiplier));
            }
        }

        public const string Assassin_s_Hood_Speed_Multiplier_1_displayName = "Assassin's Hood: Speed Multiplier 1";
        public const int Assassin_s_Hood_Speed_Multiplier_1_sortIndex = 7200;
        [SortOrder(Assassin_s_Hood_Speed_Multiplier_1_sortIndex)]
        [DisplayName(Assassin_s_Hood_Speed_Multiplier_1_displayName)]
        public virtual float Assassin_s_Hood_Speed_Multiplier_1 {
            get => GetData<float>(467);
            set {
                if (GetData<float>(467) == value) return;
                SetData(467, value, nameof(Assassin_s_Hood_Speed_Multiplier_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Assassin_s_Hood_Speed_Multiplier_1));
            }
        }

        public const string Assassin_s_Hood_Unk1_displayName = "Assassin's Hood: Unk1";
        public const int Assassin_s_Hood_Unk1_sortIndex = 7250;
        [SortOrder(Assassin_s_Hood_Unk1_sortIndex)]
        [DisplayName(Assassin_s_Hood_Unk1_displayName)]
        public virtual float Assassin_s_Hood_Unk1 {
            get => GetData<float>(471);
            set {
                if (GetData<float>(471) == value) return;
                SetData(471, value, nameof(Assassin_s_Hood_Unk1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Assassin_s_Hood_Unk1));
            }
        }

        public const string Assassin_s_Hood_Speed_Multiplier_2_displayName = "Assassin's Hood: Speed Multiplier 2";
        public const int Assassin_s_Hood_Speed_Multiplier_2_sortIndex = 7300;
        [SortOrder(Assassin_s_Hood_Speed_Multiplier_2_sortIndex)]
        [DisplayName(Assassin_s_Hood_Speed_Multiplier_2_displayName)]
        public virtual float Assassin_s_Hood_Speed_Multiplier_2 {
            get => GetData<float>(475);
            set {
                if (GetData<float>(475) == value) return;
                SetData(475, value, nameof(Assassin_s_Hood_Speed_Multiplier_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Assassin_s_Hood_Speed_Multiplier_2));
            }
        }

        public const string Assassin_s_Hood_Speed_Multiplier_3_displayName = "Assassin's Hood: Speed Multiplier 3";
        public const int Assassin_s_Hood_Speed_Multiplier_3_sortIndex = 7350;
        [SortOrder(Assassin_s_Hood_Speed_Multiplier_3_sortIndex)]
        [DisplayName(Assassin_s_Hood_Speed_Multiplier_3_displayName)]
        public virtual float Assassin_s_Hood_Speed_Multiplier_3 {
            get => GetData<float>(479);
            set {
                if (GetData<float>(479) == value) return;
                SetData(479, value, nameof(Assassin_s_Hood_Speed_Multiplier_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Assassin_s_Hood_Speed_Multiplier_3));
            }
        }

        public const string Assassin_s_Hood_Speed_Multiplier_4_displayName = "Assassin's Hood: Speed Multiplier 4";
        public const int Assassin_s_Hood_Speed_Multiplier_4_sortIndex = 7400;
        [SortOrder(Assassin_s_Hood_Speed_Multiplier_4_sortIndex)]
        [DisplayName(Assassin_s_Hood_Speed_Multiplier_4_displayName)]
        public virtual float Assassin_s_Hood_Speed_Multiplier_4 {
            get => GetData<float>(483);
            set {
                if (GetData<float>(483) == value) return;
                SetData(483, value, nameof(Assassin_s_Hood_Speed_Multiplier_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Assassin_s_Hood_Speed_Multiplier_4));
            }
        }

        public const string Assassin_s_Hood_Speed_Multiplier_5_displayName = "Assassin's Hood: Speed Multiplier 5";
        public const int Assassin_s_Hood_Speed_Multiplier_5_sortIndex = 7450;
        [SortOrder(Assassin_s_Hood_Speed_Multiplier_5_sortIndex)]
        [DisplayName(Assassin_s_Hood_Speed_Multiplier_5_displayName)]
        public virtual float Assassin_s_Hood_Speed_Multiplier_5 {
            get => GetData<float>(487);
            set {
                if (GetData<float>(487) == value) return;
                SetData(487, value, nameof(Assassin_s_Hood_Speed_Multiplier_5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Assassin_s_Hood_Speed_Multiplier_5));
            }
        }

        public const string Assassin_s_Hood_Unk2_displayName = "Assassin's Hood: Unk2";
        public const int Assassin_s_Hood_Unk2_sortIndex = 7500;
        [SortOrder(Assassin_s_Hood_Unk2_sortIndex)]
        [DisplayName(Assassin_s_Hood_Unk2_displayName)]
        public virtual float Assassin_s_Hood_Unk2 {
            get => GetData<float>(491);
            set {
                if (GetData<float>(491) == value) return;
                SetData(491, value, nameof(Assassin_s_Hood_Unk2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Assassin_s_Hood_Unk2));
            }
        }

        public const string Assassin_s_Hood_Unk3_displayName = "Assassin's Hood: Unk3";
        public const int Assassin_s_Hood_Unk3_sortIndex = 7550;
        [SortOrder(Assassin_s_Hood_Unk3_sortIndex)]
        [DisplayName(Assassin_s_Hood_Unk3_displayName)]
        public virtual float Assassin_s_Hood_Unk3 {
            get => GetData<float>(495);
            set {
                if (GetData<float>(495) == value) return;
                SetData(495, value, nameof(Assassin_s_Hood_Unk3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Assassin_s_Hood_Unk3));
            }
        }

        public const string Assassin_s_Hood_Unk4_displayName = "Assassin's Hood: Unk4";
        public const int Assassin_s_Hood_Unk4_sortIndex = 7600;
        [SortOrder(Assassin_s_Hood_Unk4_sortIndex)]
        [DisplayName(Assassin_s_Hood_Unk4_displayName)]
        public virtual float Assassin_s_Hood_Unk4 {
            get => GetData<float>(499);
            set {
                if (GetData<float>(499) == value) return;
                SetData(499, value, nameof(Assassin_s_Hood_Unk4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Assassin_s_Hood_Unk4));
            }
        }

        public const string Assassin_s_Hood_Unk5_displayName = "Assassin's Hood: Unk5";
        public const int Assassin_s_Hood_Unk5_sortIndex = 7650;
        [SortOrder(Assassin_s_Hood_Unk5_sortIndex)]
        [DisplayName(Assassin_s_Hood_Unk5_displayName)]
        public virtual float Assassin_s_Hood_Unk5 {
            get => GetData<float>(503);
            set {
                if (GetData<float>(503) == value) return;
                SetData(503, value, nameof(Assassin_s_Hood_Unk5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Assassin_s_Hood_Unk5));
            }
        }

        public const string Assassin_s_Hood_Unk6_displayName = "Assassin's Hood: Unk6";
        public const int Assassin_s_Hood_Unk6_sortIndex = 7700;
        [SortOrder(Assassin_s_Hood_Unk6_sortIndex)]
        [DisplayName(Assassin_s_Hood_Unk6_displayName)]
        public virtual float Assassin_s_Hood_Unk6 {
            get => GetData<float>(507);
            set {
                if (GetData<float>(507) == value) return;
                SetData(507, value, nameof(Assassin_s_Hood_Unk6));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Assassin_s_Hood_Unk6));
            }
        }

        public const string Assassin_s_Hood_Unk7_displayName = "Assassin's Hood: Unk7";
        public const int Assassin_s_Hood_Unk7_sortIndex = 7750;
        [SortOrder(Assassin_s_Hood_Unk7_sortIndex)]
        [DisplayName(Assassin_s_Hood_Unk7_displayName)]
        public virtual float Assassin_s_Hood_Unk7 {
            get => GetData<float>(511);
            set {
                if (GetData<float>(511) == value) return;
                SetData(511, value, nameof(Assassin_s_Hood_Unk7));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Assassin_s_Hood_Unk7));
            }
        }

        public const string Assassin_s_Hood_Unk8_displayName = "Assassin's Hood: Unk8";
        public const int Assassin_s_Hood_Unk8_sortIndex = 7800;
        [SortOrder(Assassin_s_Hood_Unk8_sortIndex)]
        [DisplayName(Assassin_s_Hood_Unk8_displayName)]
        public virtual float Assassin_s_Hood_Unk8 {
            get => GetData<float>(515);
            set {
                if (GetData<float>(515) == value) return;
                SetData(515, value, nameof(Assassin_s_Hood_Unk8));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Assassin_s_Hood_Unk8));
            }
        }

        public const string Assassin_s_Hood_Unk9_displayName = "Assassin's Hood: Unk9";
        public const int Assassin_s_Hood_Unk9_sortIndex = 7850;
        [SortOrder(Assassin_s_Hood_Unk9_sortIndex)]
        [DisplayName(Assassin_s_Hood_Unk9_displayName)]
        public virtual float Assassin_s_Hood_Unk9 {
            get => GetData<float>(519);
            set {
                if (GetData<float>(519) == value) return;
                SetData(519, value, nameof(Assassin_s_Hood_Unk9));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Assassin_s_Hood_Unk9));
            }
        }

        public const string Assassin_s_Hood_Unk10_displayName = "Assassin's Hood: Unk10";
        public const int Assassin_s_Hood_Unk10_sortIndex = 7900;
        [SortOrder(Assassin_s_Hood_Unk10_sortIndex)]
        [DisplayName(Assassin_s_Hood_Unk10_displayName)]
        public virtual float Assassin_s_Hood_Unk10 {
            get => GetData<float>(523);
            set {
                if (GetData<float>(523) == value) return;
                SetData(523, value, nameof(Assassin_s_Hood_Unk10));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Assassin_s_Hood_Unk10));
            }
        }

        public const string Assassin_s_Hood_Unk11_displayName = "Assassin's Hood: Unk11";
        public const int Assassin_s_Hood_Unk11_sortIndex = 7950;
        [SortOrder(Assassin_s_Hood_Unk11_sortIndex)]
        [DisplayName(Assassin_s_Hood_Unk11_displayName)]
        public virtual float Assassin_s_Hood_Unk11 {
            get => GetData<float>(527);
            set {
                if (GetData<float>(527) == value) return;
                SetData(527, value, nameof(Assassin_s_Hood_Unk11));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Assassin_s_Hood_Unk11));
            }
        }

        public const string Assassin_s_Hood_Unk12_displayName = "Assassin's Hood: Unk12";
        public const int Assassin_s_Hood_Unk12_sortIndex = 8000;
        [SortOrder(Assassin_s_Hood_Unk12_sortIndex)]
        [DisplayName(Assassin_s_Hood_Unk12_displayName)]
        public virtual float Assassin_s_Hood_Unk12 {
            get => GetData<float>(531);
            set {
                if (GetData<float>(531) == value) return;
                SetData(531, value, nameof(Assassin_s_Hood_Unk12));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Assassin_s_Hood_Unk12));
            }
        }

        public const string Assassin_s_Hood_Unk13_displayName = "Assassin's Hood: Unk13";
        public const int Assassin_s_Hood_Unk13_sortIndex = 8050;
        [SortOrder(Assassin_s_Hood_Unk13_sortIndex)]
        [DisplayName(Assassin_s_Hood_Unk13_displayName)]
        public virtual float Assassin_s_Hood_Unk13 {
            get => GetData<float>(535);
            set {
                if (GetData<float>(535) == value) return;
                SetData(535, value, nameof(Assassin_s_Hood_Unk13));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Assassin_s_Hood_Unk13));
            }
        }

        public const string Assassin_s_Hood_Unk14_displayName = "Assassin's Hood: Unk14";
        public const int Assassin_s_Hood_Unk14_sortIndex = 8100;
        [SortOrder(Assassin_s_Hood_Unk14_sortIndex)]
        [DisplayName(Assassin_s_Hood_Unk14_displayName)]
        public virtual float Assassin_s_Hood_Unk14 {
            get => GetData<float>(539);
            set {
                if (GetData<float>(539) == value) return;
                SetData(539, value, nameof(Assassin_s_Hood_Unk14));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Assassin_s_Hood_Unk14));
            }
        }

        public const string Assassin_s_Hood_Unk15_displayName = "Assassin's Hood: Unk15";
        public const int Assassin_s_Hood_Unk15_sortIndex = 8150;
        [SortOrder(Assassin_s_Hood_Unk15_sortIndex)]
        [DisplayName(Assassin_s_Hood_Unk15_displayName)]
        public virtual float Assassin_s_Hood_Unk15 {
            get => GetData<float>(543);
            set {
                if (GetData<float>(543) == value) return;
                SetData(543, value, nameof(Assassin_s_Hood_Unk15));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Assassin_s_Hood_Unk15));
            }
        }

        public const string Assassin_s_Hood_Unk16_displayName = "Assassin's Hood: Unk16";
        public const int Assassin_s_Hood_Unk16_sortIndex = 8200;
        [SortOrder(Assassin_s_Hood_Unk16_sortIndex)]
        [DisplayName(Assassin_s_Hood_Unk16_displayName)]
        public virtual float Assassin_s_Hood_Unk16 {
            get => GetData<float>(547);
            set {
                if (GetData<float>(547) == value) return;
                SetData(547, value, nameof(Assassin_s_Hood_Unk16));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Assassin_s_Hood_Unk16));
            }
        }

        public const int lastSortIndex = 8250;
    }
}
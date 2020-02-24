using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.PlData {
    public partial class PlItemParam {
        public const uint StructSize = 512;
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

        public const string Potion_Power_displayName = "Potion Power";
        public const int Potion_Power_sortIndex = 100;
        [SortOrder(Potion_Power_sortIndex)]
        [DisplayName(Potion_Power_displayName)]
        public virtual uint Potion_Power {
            get => GetData<uint>(12);
            set {
                if (GetData<uint>(12) == value) return;
                SetData(12, value, nameof(Potion_Power));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Potion_Power));
            }
        }

        public const string Unk2_displayName = "Unk2";
        public const int Unk2_sortIndex = 150;
        [SortOrder(Unk2_sortIndex)]
        [DisplayName(Unk2_displayName)]
        public virtual float Unk2 {
            get => GetData<float>(16);
            set {
                if (GetData<float>(16) == value) return;
                SetData(16, value, nameof(Unk2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk2));
            }
        }

        public const string Unk3_displayName = "Unk3";
        public const int Unk3_sortIndex = 200;
        [SortOrder(Unk3_sortIndex)]
        [DisplayName(Unk3_displayName)]
        public virtual float Unk3 {
            get => GetData<float>(20);
            set {
                if (GetData<float>(20) == value) return;
                SetData(20, value, nameof(Unk3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk3));
            }
        }

        public const string Unk4_displayName = "Unk4";
        public const int Unk4_sortIndex = 250;
        [SortOrder(Unk4_sortIndex)]
        [DisplayName(Unk4_displayName)]
        public virtual float Unk4 {
            get => GetData<float>(24);
            set {
                if (GetData<float>(24) == value) return;
                SetData(24, value, nameof(Unk4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk4));
            }
        }

        public const string Mega_Potion_Power_displayName = "Mega Potion Power";
        public const int Mega_Potion_Power_sortIndex = 300;
        [SortOrder(Mega_Potion_Power_sortIndex)]
        [DisplayName(Mega_Potion_Power_displayName)]
        public virtual uint Mega_Potion_Power {
            get => GetData<uint>(28);
            set {
                if (GetData<uint>(28) == value) return;
                SetData(28, value, nameof(Mega_Potion_Power));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Mega_Potion_Power));
            }
        }

        public const string Unk5_displayName = "Unk5";
        public const int Unk5_sortIndex = 350;
        [SortOrder(Unk5_sortIndex)]
        [DisplayName(Unk5_displayName)]
        public virtual float Unk5 {
            get => GetData<float>(32);
            set {
                if (GetData<float>(32) == value) return;
                SetData(32, value, nameof(Unk5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk5));
            }
        }

        public const string Unk6_displayName = "Unk6";
        public const int Unk6_sortIndex = 400;
        [SortOrder(Unk6_sortIndex)]
        [DisplayName(Unk6_displayName)]
        public virtual float Unk6 {
            get => GetData<float>(36);
            set {
                if (GetData<float>(36) == value) return;
                SetData(36, value, nameof(Unk6));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk6));
            }
        }

        public const string Unk7_displayName = "Unk7";
        public const int Unk7_sortIndex = 450;
        [SortOrder(Unk7_sortIndex)]
        [DisplayName(Unk7_displayName)]
        public virtual float Unk7 {
            get => GetData<float>(40);
            set {
                if (GetData<float>(40) == value) return;
                SetData(40, value, nameof(Unk7));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk7));
            }
        }

        public const string Unk8_displayName = "Unk8";
        public const int Unk8_sortIndex = 500;
        [SortOrder(Unk8_sortIndex)]
        [DisplayName(Unk8_displayName)]
        public virtual byte Unk8 {
            get => GetData<byte>(44);
            set {
                if (GetData<byte>(44) == value) return;
                SetData(44, value, nameof(Unk8));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk8));
            }
        }

        public const string Mega_Nutrients_Power_displayName = "Mega Nutrients Power";
        public const int Mega_Nutrients_Power_sortIndex = 550;
        [SortOrder(Mega_Nutrients_Power_sortIndex)]
        [DisplayName(Mega_Nutrients_Power_displayName)]
        public virtual byte Mega_Nutrients_Power {
            get => GetData<byte>(45);
            set {
                if (GetData<byte>(45) == value) return;
                SetData(45, value, nameof(Mega_Nutrients_Power));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Mega_Nutrients_Power));
            }
        }

        public const string Unk9_displayName = "Unk9";
        public const int Unk9_sortIndex = 600;
        [SortOrder(Unk9_sortIndex)]
        [DisplayName(Unk9_displayName)]
        public virtual byte Unk9 {
            get => GetData<byte>(46);
            set {
                if (GetData<byte>(46) == value) return;
                SetData(46, value, nameof(Unk9));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk9));
            }
        }

        public const string Mega_Dash_Juice_Stamina_Power_displayName = "Mega Dash Juice Stamina Power";
        public const int Mega_Dash_Juice_Stamina_Power_sortIndex = 650;
        [SortOrder(Mega_Dash_Juice_Stamina_Power_sortIndex)]
        [DisplayName(Mega_Dash_Juice_Stamina_Power_displayName)]
        public virtual float Mega_Dash_Juice_Stamina_Power {
            get => GetData<float>(47);
            set {
                if (GetData<float>(47) == value) return;
                SetData(47, value, nameof(Mega_Dash_Juice_Stamina_Power));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Mega_Dash_Juice_Stamina_Power));
            }
        }

        public const string Dash_Juice_Stamina_Power_displayName = "Dash Juice Stamina Power";
        public const int Dash_Juice_Stamina_Power_sortIndex = 700;
        [SortOrder(Dash_Juice_Stamina_Power_sortIndex)]
        [DisplayName(Dash_Juice_Stamina_Power_displayName)]
        public virtual float Dash_Juice_Stamina_Power {
            get => GetData<float>(51);
            set {
                if (GetData<float>(51) == value) return;
                SetData(51, value, nameof(Dash_Juice_Stamina_Power));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dash_Juice_Stamina_Power));
            }
        }

        public const string Both_Dash_Juice_Duration_displayName = "Both Dash Juice Duration";
        public const int Both_Dash_Juice_Duration_sortIndex = 750;
        [SortOrder(Both_Dash_Juice_Duration_sortIndex)]
        [DisplayName(Both_Dash_Juice_Duration_displayName)]
        public virtual ushort Both_Dash_Juice_Duration {
            get => GetData<ushort>(55);
            set {
                if (GetData<ushort>(55) == value) return;
                SetData(55, value, nameof(Both_Dash_Juice_Duration));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Both_Dash_Juice_Duration));
            }
        }

        public const string Both_Dash_Juice_Power_displayName = "Both Dash Juice Power";
        public const int Both_Dash_Juice_Power_sortIndex = 800;
        [SortOrder(Both_Dash_Juice_Power_sortIndex)]
        [DisplayName(Both_Dash_Juice_Power_displayName)]
        public virtual byte Both_Dash_Juice_Power {
            get => GetData<byte>(57);
            set {
                if (GetData<byte>(57) == value) return;
                SetData(57, value, nameof(Both_Dash_Juice_Power));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Both_Dash_Juice_Power));
            }
        }

        public const string Unk10_displayName = "Unk10";
        public const int Unk10_sortIndex = 850;
        [SortOrder(Unk10_sortIndex)]
        [DisplayName(Unk10_displayName)]
        public virtual float Unk10 {
            get => GetData<float>(58);
            set {
                if (GetData<float>(58) == value) return;
                SetData(58, value, nameof(Unk10));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk10));
            }
        }

        public const string Unk11_displayName = "Unk11";
        public const int Unk11_sortIndex = 900;
        [SortOrder(Unk11_sortIndex)]
        [DisplayName(Unk11_displayName)]
        public virtual ushort Unk11 {
            get => GetData<ushort>(62);
            set {
                if (GetData<ushort>(62) == value) return;
                SetData(62, value, nameof(Unk11));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk11));
            }
        }

        public const string Astera_Jerky_Power_displayName = "Astera Jerky Power";
        public const int Astera_Jerky_Power_sortIndex = 950;
        [SortOrder(Astera_Jerky_Power_sortIndex)]
        [DisplayName(Astera_Jerky_Power_displayName)]
        public virtual float Astera_Jerky_Power {
            get => GetData<float>(64);
            set {
                if (GetData<float>(64) == value) return;
                SetData(64, value, nameof(Astera_Jerky_Power));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Astera_Jerky_Power));
            }
        }

        public const string Astera_Jerky_Duration_displayName = "Astera Jerky Duration";
        public const int Astera_Jerky_Duration_sortIndex = 1000;
        [SortOrder(Astera_Jerky_Duration_sortIndex)]
        [DisplayName(Astera_Jerky_Duration_displayName)]
        public virtual ushort Astera_Jerky_Duration {
            get => GetData<ushort>(68);
            set {
                if (GetData<ushort>(68) == value) return;
                SetData(68, value, nameof(Astera_Jerky_Duration));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Astera_Jerky_Duration));
            }
        }

        public const string Unk12_displayName = "Unk12";
        public const int Unk12_sortIndex = 1050;
        [SortOrder(Unk12_sortIndex)]
        [DisplayName(Unk12_displayName)]
        public virtual ushort Unk12 {
            get => GetData<ushort>(70);
            set {
                if (GetData<ushort>(70) == value) return;
                SetData(70, value, nameof(Unk12));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk12));
            }
        }

        public const string Unk13_displayName = "Unk13";
        public const int Unk13_sortIndex = 1100;
        [SortOrder(Unk13_sortIndex)]
        [DisplayName(Unk13_displayName)]
        public virtual uint Unk13 {
            get => GetData<uint>(72);
            set {
                if (GetData<uint>(72) == value) return;
                SetData(72, value, nameof(Unk13));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk13));
            }
        }

        public const string Unk14_displayName = "Unk14";
        public const int Unk14_sortIndex = 1150;
        [SortOrder(Unk14_sortIndex)]
        [DisplayName(Unk14_displayName)]
        public virtual uint Unk14 {
            get => GetData<uint>(76);
            set {
                if (GetData<uint>(76) == value) return;
                SetData(76, value, nameof(Unk14));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk14));
            }
        }

        public const string Unk15_displayName = "Unk15";
        public const int Unk15_sortIndex = 1200;
        [SortOrder(Unk15_sortIndex)]
        [DisplayName(Unk15_displayName)]
        public virtual float Unk15 {
            get => GetData<float>(80);
            set {
                if (GetData<float>(80) == value) return;
                SetData(80, value, nameof(Unk15));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk15));
            }
        }

        public const string Cool_Drink_Duration_displayName = "Cool Drink Duration";
        public const int Cool_Drink_Duration_sortIndex = 1250;
        [SortOrder(Cool_Drink_Duration_sortIndex)]
        [DisplayName(Cool_Drink_Duration_displayName)]
        public virtual ushort Cool_Drink_Duration {
            get => GetData<ushort>(84);
            set {
                if (GetData<ushort>(84) == value) return;
                SetData(84, value, nameof(Cool_Drink_Duration));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Cool_Drink_Duration));
            }
        }

        public const string Hot_Drink_Duration_displayName = "Hot Drink Duration";
        public const int Hot_Drink_Duration_sortIndex = 1300;
        [SortOrder(Hot_Drink_Duration_sortIndex)]
        [DisplayName(Hot_Drink_Duration_displayName)]
        public virtual ushort Hot_Drink_Duration {
            get => GetData<ushort>(86);
            set {
                if (GetData<ushort>(86) == value) return;
                SetData(86, value, nameof(Hot_Drink_Duration));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Hot_Drink_Duration));
            }
        }

        public const string Might_Seed_Duration_displayName = "Might Seed Duration";
        public const int Might_Seed_Duration_sortIndex = 1350;
        [SortOrder(Might_Seed_Duration_sortIndex)]
        [DisplayName(Might_Seed_Duration_displayName)]
        public virtual ushort Might_Seed_Duration {
            get => GetData<ushort>(88);
            set {
                if (GetData<ushort>(88) == value) return;
                SetData(88, value, nameof(Might_Seed_Duration));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Might_Seed_Duration));
            }
        }

        public const string Might_Seed_Power_displayName = "Might Seed Power";
        public const int Might_Seed_Power_sortIndex = 1400;
        [SortOrder(Might_Seed_Power_sortIndex)]
        [DisplayName(Might_Seed_Power_displayName)]
        public virtual ushort Might_Seed_Power {
            get => GetData<ushort>(90);
            set {
                if (GetData<ushort>(90) == value) return;
                SetData(90, value, nameof(Might_Seed_Power));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Might_Seed_Power));
            }
        }

        public const string Might_Pill_Duration_displayName = "Might Pill Duration";
        public const int Might_Pill_Duration_sortIndex = 1450;
        [SortOrder(Might_Pill_Duration_sortIndex)]
        [DisplayName(Might_Pill_Duration_displayName)]
        public virtual ushort Might_Pill_Duration {
            get => GetData<ushort>(92);
            set {
                if (GetData<ushort>(92) == value) return;
                SetData(92, value, nameof(Might_Pill_Duration));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Might_Pill_Duration));
            }
        }

        public const string Might_Pill_Power_displayName = "Might Pill Power";
        public const int Might_Pill_Power_sortIndex = 1500;
        [SortOrder(Might_Pill_Power_sortIndex)]
        [DisplayName(Might_Pill_Power_displayName)]
        public virtual ushort Might_Pill_Power {
            get => GetData<ushort>(94);
            set {
                if (GetData<ushort>(94) == value) return;
                SetData(94, value, nameof(Might_Pill_Power));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Might_Pill_Power));
            }
        }

        public const string Adamant_Seed_Duration_displayName = "Adamant Seed Duration";
        public const int Adamant_Seed_Duration_sortIndex = 1550;
        [SortOrder(Adamant_Seed_Duration_sortIndex)]
        [DisplayName(Adamant_Seed_Duration_displayName)]
        public virtual ushort Adamant_Seed_Duration {
            get => GetData<ushort>(96);
            set {
                if (GetData<ushort>(96) == value) return;
                SetData(96, value, nameof(Adamant_Seed_Duration));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Adamant_Seed_Duration));
            }
        }

        public const string Adamant_Seed_Power_displayName = "Adamant Seed Power";
        public const int Adamant_Seed_Power_sortIndex = 1600;
        [SortOrder(Adamant_Seed_Power_sortIndex)]
        [DisplayName(Adamant_Seed_Power_displayName)]
        public virtual ushort Adamant_Seed_Power {
            get => GetData<ushort>(98);
            set {
                if (GetData<ushort>(98) == value) return;
                SetData(98, value, nameof(Adamant_Seed_Power));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Adamant_Seed_Power));
            }
        }

        public const string Adamant_Pill_Duration_displayName = "Adamant Pill Duration";
        public const int Adamant_Pill_Duration_sortIndex = 1650;
        [SortOrder(Adamant_Pill_Duration_sortIndex)]
        [DisplayName(Adamant_Pill_Duration_displayName)]
        public virtual ushort Adamant_Pill_Duration {
            get => GetData<ushort>(100);
            set {
                if (GetData<ushort>(100) == value) return;
                SetData(100, value, nameof(Adamant_Pill_Duration));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Adamant_Pill_Duration));
            }
        }

        public const string Adamant_Pill_Power_displayName = "Adamant Pill Power";
        public const int Adamant_Pill_Power_sortIndex = 1700;
        [SortOrder(Adamant_Pill_Power_sortIndex)]
        [DisplayName(Adamant_Pill_Power_displayName)]
        public virtual float Adamant_Pill_Power {
            get => GetData<float>(102);
            set {
                if (GetData<float>(102) == value) return;
                SetData(102, value, nameof(Adamant_Pill_Power));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Adamant_Pill_Power));
            }
        }

        public const string Demondrug_Power_displayName = "Demondrug Power";
        public const int Demondrug_Power_sortIndex = 1750;
        [SortOrder(Demondrug_Power_sortIndex)]
        [DisplayName(Demondrug_Power_displayName)]
        public virtual byte Demondrug_Power {
            get => GetData<byte>(106);
            set {
                if (GetData<byte>(106) == value) return;
                SetData(106, value, nameof(Demondrug_Power));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Demondrug_Power));
            }
        }

        public const string Mega_Demondrug_Power_displayName = "Mega Demondrug Power";
        public const int Mega_Demondrug_Power_sortIndex = 1800;
        [SortOrder(Mega_Demondrug_Power_sortIndex)]
        [DisplayName(Mega_Demondrug_Power_displayName)]
        public virtual byte Mega_Demondrug_Power {
            get => GetData<byte>(107);
            set {
                if (GetData<byte>(107) == value) return;
                SetData(107, value, nameof(Mega_Demondrug_Power));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Mega_Demondrug_Power));
            }
        }

        public const string Armorskin_Power_displayName = "Armorskin Power";
        public const int Armorskin_Power_sortIndex = 1850;
        [SortOrder(Armorskin_Power_sortIndex)]
        [DisplayName(Armorskin_Power_displayName)]
        public virtual byte Armorskin_Power {
            get => GetData<byte>(108);
            set {
                if (GetData<byte>(108) == value) return;
                SetData(108, value, nameof(Armorskin_Power));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Armorskin_Power));
            }
        }

        public const string Mega_Armorskin_Power_displayName = "Mega Armorskin Power";
        public const int Mega_Armorskin_Power_sortIndex = 1900;
        [SortOrder(Mega_Armorskin_Power_sortIndex)]
        [DisplayName(Mega_Armorskin_Power_displayName)]
        public virtual byte Mega_Armorskin_Power {
            get => GetData<byte>(109);
            set {
                if (GetData<byte>(109) == value) return;
                SetData(109, value, nameof(Mega_Armorskin_Power));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Mega_Armorskin_Power));
            }
        }

        public const string Lifepowder_Power_displayName = "Lifepowder Power";
        public const int Lifepowder_Power_sortIndex = 1950;
        [SortOrder(Lifepowder_Power_sortIndex)]
        [DisplayName(Lifepowder_Power_displayName)]
        public virtual ushort Lifepowder_Power {
            get => GetData<ushort>(110);
            set {
                if (GetData<ushort>(110) == value) return;
                SetData(110, value, nameof(Lifepowder_Power));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Lifepowder_Power));
            }
        }

        public const string Dustof_Life_Power_displayName = "Dustof Life Power";
        public const int Dustof_Life_Power_sortIndex = 2000;
        [SortOrder(Dustof_Life_Power_sortIndex)]
        [DisplayName(Dustof_Life_Power_displayName)]
        public virtual ushort Dustof_Life_Power {
            get => GetData<ushort>(112);
            set {
                if (GetData<ushort>(112) == value) return;
                SetData(112, value, nameof(Dustof_Life_Power));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dustof_Life_Power));
            }
        }

        public const string Herbal_Powder_Power_displayName = "Herbal Powder Power";
        public const int Herbal_Powder_Power_sortIndex = 2050;
        [SortOrder(Herbal_Powder_Power_sortIndex)]
        [DisplayName(Herbal_Powder_Power_displayName)]
        public virtual ushort Herbal_Powder_Power {
            get => GetData<ushort>(114);
            set {
                if (GetData<ushort>(114) == value) return;
                SetData(114, value, nameof(Herbal_Powder_Power));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Herbal_Powder_Power));
            }
        }

        public const string Demon_Powder_Power_displayName = "Demon Powder Power";
        public const int Demon_Powder_Power_sortIndex = 2100;
        [SortOrder(Demon_Powder_Power_sortIndex)]
        [DisplayName(Demon_Powder_Power_displayName)]
        public virtual ushort Demon_Powder_Power {
            get => GetData<ushort>(116);
            set {
                if (GetData<ushort>(116) == value) return;
                SetData(116, value, nameof(Demon_Powder_Power));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Demon_Powder_Power));
            }
        }

        public const string Demon_Powder_Duration_displayName = "Demon Powder Duration";
        public const int Demon_Powder_Duration_sortIndex = 2150;
        [SortOrder(Demon_Powder_Duration_sortIndex)]
        [DisplayName(Demon_Powder_Duration_displayName)]
        public virtual ushort Demon_Powder_Duration {
            get => GetData<ushort>(118);
            set {
                if (GetData<ushort>(118) == value) return;
                SetData(118, value, nameof(Demon_Powder_Duration));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Demon_Powder_Duration));
            }
        }

        public const string Hardshell_Powder_Power_displayName = "Hardshell Powder Power";
        public const int Hardshell_Powder_Power_sortIndex = 2200;
        [SortOrder(Hardshell_Powder_Power_sortIndex)]
        [DisplayName(Hardshell_Powder_Power_displayName)]
        public virtual ushort Hardshell_Powder_Power {
            get => GetData<ushort>(120);
            set {
                if (GetData<ushort>(120) == value) return;
                SetData(120, value, nameof(Hardshell_Powder_Power));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Hardshell_Powder_Power));
            }
        }

        public const string Hardshell_Powder_Duration_displayName = "Hardshell Powder Duration";
        public const int Hardshell_Powder_Duration_sortIndex = 2250;
        [SortOrder(Hardshell_Powder_Duration_sortIndex)]
        [DisplayName(Hardshell_Powder_Duration_displayName)]
        public virtual ushort Hardshell_Powder_Duration {
            get => GetData<ushort>(122);
            set {
                if (GetData<ushort>(122) == value) return;
                SetData(122, value, nameof(Hardshell_Powder_Duration));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Hardshell_Powder_Duration));
            }
        }

        public const string Unk16_displayName = "Unk16";
        public const int Unk16_sortIndex = 2300;
        [SortOrder(Unk16_sortIndex)]
        [DisplayName(Unk16_displayName)]
        public virtual ushort Unk16 {
            get => GetData<ushort>(124);
            set {
                if (GetData<ushort>(124) == value) return;
                SetData(124, value, nameof(Unk16));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk16));
            }
        }

        public const string Unk17_displayName = "Unk17";
        public const int Unk17_sortIndex = 2350;
        [SortOrder(Unk17_sortIndex)]
        [DisplayName(Unk17_displayName)]
        public virtual ushort Unk17 {
            get => GetData<ushort>(126);
            set {
                if (GetData<ushort>(126) == value) return;
                SetData(126, value, nameof(Unk17));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk17));
            }
        }

        public const string Unk18_displayName = "Unk18";
        public const int Unk18_sortIndex = 2400;
        [SortOrder(Unk18_sortIndex)]
        [DisplayName(Unk18_displayName)]
        public virtual ushort Unk18 {
            get => GetData<ushort>(128);
            set {
                if (GetData<ushort>(128) == value) return;
                SetData(128, value, nameof(Unk18));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk18));
            }
        }

        public const string Unk19_displayName = "Unk19";
        public const int Unk19_sortIndex = 2450;
        [SortOrder(Unk19_sortIndex)]
        [DisplayName(Unk19_displayName)]
        public virtual ushort Unk19 {
            get => GetData<ushort>(130);
            set {
                if (GetData<ushort>(130) == value) return;
                SetData(130, value, nameof(Unk19));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk19));
            }
        }

        public const string Unk20_displayName = "Unk20";
        public const int Unk20_sortIndex = 2500;
        [SortOrder(Unk20_sortIndex)]
        [DisplayName(Unk20_displayName)]
        public virtual ushort Unk20 {
            get => GetData<ushort>(132);
            set {
                if (GetData<ushort>(132) == value) return;
                SetData(132, value, nameof(Unk20));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk20));
            }
        }

        public const string Unk21_displayName = "Unk21";
        public const int Unk21_sortIndex = 2550;
        [SortOrder(Unk21_sortIndex)]
        [DisplayName(Unk21_displayName)]
        public virtual ushort Unk21 {
            get => GetData<ushort>(134);
            set {
                if (GetData<ushort>(134) == value) return;
                SetData(134, value, nameof(Unk21));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk21));
            }
        }

        public const string Well_Done_Steak_Something_displayName = "Well Done Steak Something";
        public const int Well_Done_Steak_Something_sortIndex = 2600;
        [SortOrder(Well_Done_Steak_Something_sortIndex)]
        [DisplayName(Well_Done_Steak_Something_displayName)]
        public virtual uint Well_Done_Steak_Something {
            get => GetData<uint>(136);
            set {
                if (GetData<uint>(136) == value) return;
                SetData(136, value, nameof(Well_Done_Steak_Something));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Well_Done_Steak_Something));
            }
        }

        public const string Unk22_displayName = "Unk22";
        public const int Unk22_sortIndex = 2650;
        [SortOrder(Unk22_sortIndex)]
        [DisplayName(Unk22_displayName)]
        public virtual float Unk22 {
            get => GetData<float>(140);
            set {
                if (GetData<float>(140) == value) return;
                SetData(140, value, nameof(Unk22));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk22));
            }
        }

        public const string Unk23_displayName = "Unk23";
        public const int Unk23_sortIndex = 2700;
        [SortOrder(Unk23_sortIndex)]
        [DisplayName(Unk23_displayName)]
        public virtual float Unk23 {
            get => GetData<float>(144);
            set {
                if (GetData<float>(144) == value) return;
                SetData(144, value, nameof(Unk23));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk23));
            }
        }

        public const string Unk24_displayName = "Unk24";
        public const int Unk24_sortIndex = 2750;
        [SortOrder(Unk24_sortIndex)]
        [DisplayName(Unk24_displayName)]
        public virtual float Unk24 {
            get => GetData<float>(148);
            set {
                if (GetData<float>(148) == value) return;
                SetData(148, value, nameof(Unk24));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk24));
            }
        }

        public const string Unk25_displayName = "Unk25";
        public const int Unk25_sortIndex = 2800;
        [SortOrder(Unk25_sortIndex)]
        [DisplayName(Unk25_displayName)]
        public virtual ushort Unk25 {
            get => GetData<ushort>(152);
            set {
                if (GetData<ushort>(152) == value) return;
                SetData(152, value, nameof(Unk25));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk25));
            }
        }

        public const string Unk26_displayName = "Unk26";
        public const int Unk26_sortIndex = 2850;
        [SortOrder(Unk26_sortIndex)]
        [DisplayName(Unk26_displayName)]
        public virtual short Unk26 {
            get => GetData<short>(154);
            set {
                if (GetData<short>(154) == value) return;
                SetData(154, value, nameof(Unk26));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk26));
            }
        }

        public const string Unk27_displayName = "Unk27";
        public const int Unk27_sortIndex = 2900;
        [SortOrder(Unk27_sortIndex)]
        [DisplayName(Unk27_displayName)]
        public virtual byte Unk27 {
            get => GetData<byte>(156);
            set {
                if (GetData<byte>(156) == value) return;
                SetData(156, value, nameof(Unk27));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk27));
            }
        }

        public const string Unk28_displayName = "Unk28";
        public const int Unk28_sortIndex = 2950;
        [SortOrder(Unk28_sortIndex)]
        [DisplayName(Unk28_displayName)]
        public virtual float Unk28 {
            get => GetData<float>(157);
            set {
                if (GetData<float>(157) == value) return;
                SetData(157, value, nameof(Unk28));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk28));
            }
        }

        public const string Unk29_displayName = "Unk29";
        public const int Unk29_sortIndex = 3000;
        [SortOrder(Unk29_sortIndex)]
        [DisplayName(Unk29_displayName)]
        public virtual float Unk29 {
            get => GetData<float>(161);
            set {
                if (GetData<float>(161) == value) return;
                SetData(161, value, nameof(Unk29));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk29));
            }
        }

        public const string Unk30_displayName = "Unk30";
        public const int Unk30_sortIndex = 3050;
        [SortOrder(Unk30_sortIndex)]
        [DisplayName(Unk30_displayName)]
        public virtual float Unk30 {
            get => GetData<float>(165);
            set {
                if (GetData<float>(165) == value) return;
                SetData(165, value, nameof(Unk30));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk30));
            }
        }

        public const string Unk31_displayName = "Unk31";
        public const int Unk31_sortIndex = 3100;
        [SortOrder(Unk31_sortIndex)]
        [DisplayName(Unk31_displayName)]
        public virtual float Unk31 {
            get => GetData<float>(169);
            set {
                if (GetData<float>(169) == value) return;
                SetData(169, value, nameof(Unk31));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk31));
            }
        }

        public const string Unk32_displayName = "Unk32";
        public const int Unk32_sortIndex = 3150;
        [SortOrder(Unk32_sortIndex)]
        [DisplayName(Unk32_displayName)]
        public virtual float Unk32 {
            get => GetData<float>(173);
            set {
                if (GetData<float>(173) == value) return;
                SetData(173, value, nameof(Unk32));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk32));
            }
        }

        public const string Unk33_displayName = "Unk33";
        public const int Unk33_sortIndex = 3200;
        [SortOrder(Unk33_sortIndex)]
        [DisplayName(Unk33_displayName)]
        public virtual float Unk33 {
            get => GetData<float>(177);
            set {
                if (GetData<float>(177) == value) return;
                SetData(177, value, nameof(Unk33));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk33));
            }
        }

        public const string Unk34_displayName = "Unk34";
        public const int Unk34_sortIndex = 3250;
        [SortOrder(Unk34_sortIndex)]
        [DisplayName(Unk34_displayName)]
        public virtual float Unk34 {
            get => GetData<float>(181);
            set {
                if (GetData<float>(181) == value) return;
                SetData(181, value, nameof(Unk34));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk34));
            }
        }

        public const string Unk35_displayName = "Unk35";
        public const int Unk35_sortIndex = 3300;
        [SortOrder(Unk35_sortIndex)]
        [DisplayName(Unk35_displayName)]
        public virtual float Unk35 {
            get => GetData<float>(185);
            set {
                if (GetData<float>(185) == value) return;
                SetData(185, value, nameof(Unk35));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk35));
            }
        }

        public const string Unk36_displayName = "Unk36";
        public const int Unk36_sortIndex = 3350;
        [SortOrder(Unk36_sortIndex)]
        [DisplayName(Unk36_displayName)]
        public virtual float Unk36 {
            get => GetData<float>(189);
            set {
                if (GetData<float>(189) == value) return;
                SetData(189, value, nameof(Unk36));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk36));
            }
        }

        public const string Unk37_displayName = "Unk37";
        public const int Unk37_sortIndex = 3400;
        [SortOrder(Unk37_sortIndex)]
        [DisplayName(Unk37_displayName)]
        public virtual float Unk37 {
            get => GetData<float>(193);
            set {
                if (GetData<float>(193) == value) return;
                SetData(193, value, nameof(Unk37));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk37));
            }
        }

        public const string Unk38_displayName = "Unk38";
        public const int Unk38_sortIndex = 3450;
        [SortOrder(Unk38_sortIndex)]
        [DisplayName(Unk38_displayName)]
        public virtual float Unk38 {
            get => GetData<float>(197);
            set {
                if (GetData<float>(197) == value) return;
                SetData(197, value, nameof(Unk38));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk38));
            }
        }

        public const string Unk39_displayName = "Unk39";
        public const int Unk39_sortIndex = 3500;
        [SortOrder(Unk39_sortIndex)]
        [DisplayName(Unk39_displayName)]
        public virtual uint Unk39 {
            get => GetData<uint>(201);
            set {
                if (GetData<uint>(201) == value) return;
                SetData(201, value, nameof(Unk39));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk39));
            }
        }

        public const string Unk40_displayName = "Unk40";
        public const int Unk40_sortIndex = 3550;
        [SortOrder(Unk40_sortIndex)]
        [DisplayName(Unk40_displayName)]
        public virtual uint Unk40 {
            get => GetData<uint>(205);
            set {
                if (GetData<uint>(205) == value) return;
                SetData(205, value, nameof(Unk40));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk40));
            }
        }

        public const string Unk41_displayName = "Unk41";
        public const int Unk41_sortIndex = 3600;
        [SortOrder(Unk41_sortIndex)]
        [DisplayName(Unk41_displayName)]
        public virtual uint Unk41 {
            get => GetData<uint>(209);
            set {
                if (GetData<uint>(209) == value) return;
                SetData(209, value, nameof(Unk41));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk41));
            }
        }

        public const int lastSortIndex = 3650;
    }
}
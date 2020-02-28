using System;
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

        public const string Powder_Radius_displayName = "Powder Radius";
        public const int Powder_Radius_sortIndex = 50;
        [SortOrder(Powder_Radius_sortIndex)]
        [DisplayName(Powder_Radius_displayName)]
        public virtual float Powder_Radius {
            get => GetData<float>(8);
            set {
                if (GetData<float>(8) == value) return;
                SetData(8, value, nameof(Powder_Radius));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Powder_Radius));
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

        public const string Nutrients_Power_displayName = "Nutrients Power";
        public const int Nutrients_Power_sortIndex = 500;
        [SortOrder(Nutrients_Power_sortIndex)]
        [DisplayName(Nutrients_Power_displayName)]
        public virtual byte Nutrients_Power {
            get => GetData<byte>(44);
            set {
                if (GetData<byte>(44) == value) return;
                SetData(44, value, nameof(Nutrients_Power));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Nutrients_Power));
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

        public const string Immunizer_Power_displayName = "Immunizer Power";
        public const int Immunizer_Power_sortIndex = 850;
        [SortOrder(Immunizer_Power_sortIndex)]
        [DisplayName(Immunizer_Power_displayName)]
        public virtual float Immunizer_Power {
            get => GetData<float>(58);
            set {
                if (GetData<float>(58) == value) return;
                SetData(58, value, nameof(Immunizer_Power));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Immunizer_Power));
            }
        }

        public const string Immunizer_Duration_displayName = "Immunizer Duration";
        public const int Immunizer_Duration_sortIndex = 900;
        [SortOrder(Immunizer_Duration_sortIndex)]
        [DisplayName(Immunizer_Duration_displayName)]
        public virtual ushort Immunizer_Duration {
            get => GetData<ushort>(62);
            set {
                if (GetData<ushort>(62) == value) return;
                SetData(62, value, nameof(Immunizer_Duration));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Immunizer_Duration));
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

        public const string Herbal_Medicine_Power_displayName = "Herbal Medicine Power";
        public const int Herbal_Medicine_Power_sortIndex = 1050;
        [SortOrder(Herbal_Medicine_Power_sortIndex)]
        [DisplayName(Herbal_Medicine_Power_displayName)]
        public virtual ushort Herbal_Medicine_Power {
            get => GetData<ushort>(70);
            set {
                if (GetData<ushort>(70) == value) return;
                SetData(70, value, nameof(Herbal_Medicine_Power));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Herbal_Medicine_Power));
            }
        }

        public const string Sushifish_Scale_Power_displayName = "Sushifish Scale Power";
        public const int Sushifish_Scale_Power_sortIndex = 1100;
        [SortOrder(Sushifish_Scale_Power_sortIndex)]
        [DisplayName(Sushifish_Scale_Power_displayName)]
        public virtual uint Sushifish_Scale_Power {
            get => GetData<uint>(72);
            set {
                if (GetData<uint>(72) == value) return;
                SetData(72, value, nameof(Sushifish_Scale_Power));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Sushifish_Scale_Power));
            }
        }

        public const string Great_Sushifish_Scale_Power_displayName = "Great Sushifish Scale Power";
        public const int Great_Sushifish_Scale_Power_sortIndex = 1150;
        [SortOrder(Great_Sushifish_Scale_Power_sortIndex)]
        [DisplayName(Great_Sushifish_Scale_Power_displayName)]
        public virtual uint Great_Sushifish_Scale_Power {
            get => GetData<uint>(76);
            set {
                if (GetData<uint>(76) == value) return;
                SetData(76, value, nameof(Great_Sushifish_Scale_Power));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Great_Sushifish_Scale_Power));
            }
        }

        public const string Great_Sushifish_Scale_Duration_displayName = "Great Sushifish Scale Duration";
        public const int Great_Sushifish_Scale_Duration_sortIndex = 1200;
        [SortOrder(Great_Sushifish_Scale_Duration_sortIndex)]
        [DisplayName(Great_Sushifish_Scale_Duration_displayName)]
        public virtual float Great_Sushifish_Scale_Duration {
            get => GetData<float>(80);
            set {
                if (GetData<float>(80) == value) return;
                SetData(80, value, nameof(Great_Sushifish_Scale_Duration));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Great_Sushifish_Scale_Duration));
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

        public const string Unk16_displayName = "Unk16";
        public const int Unk16_sortIndex = 1950;
        [SortOrder(Unk16_sortIndex)]
        [DisplayName(Unk16_displayName)]
        public virtual ushort Unk16 {
            get => GetData<ushort>(110);
            set {
                if (GetData<ushort>(110) == value) return;
                SetData(110, value, nameof(Unk16));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk16));
            }
        }

        public const string Lifepowder_Power_displayName = "Lifepowder Power";
        public const int Lifepowder_Power_sortIndex = 2000;
        [SortOrder(Lifepowder_Power_sortIndex)]
        [DisplayName(Lifepowder_Power_displayName)]
        public virtual ushort Lifepowder_Power {
            get => GetData<ushort>(112);
            set {
                if (GetData<ushort>(112) == value) return;
                SetData(112, value, nameof(Lifepowder_Power));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Lifepowder_Power));
            }
        }

        public const string Dust_of_Life_Power_displayName = "Dust of Life Power";
        public const int Dust_of_Life_Power_sortIndex = 2050;
        [SortOrder(Dust_of_Life_Power_sortIndex)]
        [DisplayName(Dust_of_Life_Power_displayName)]
        public virtual ushort Dust_of_Life_Power {
            get => GetData<ushort>(114);
            set {
                if (GetData<ushort>(114) == value) return;
                SetData(114, value, nameof(Dust_of_Life_Power));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dust_of_Life_Power));
            }
        }

        public const string Herbal_Powder_Power_displayName = "Herbal Powder Power";
        public const int Herbal_Powder_Power_sortIndex = 2100;
        [SortOrder(Herbal_Powder_Power_sortIndex)]
        [DisplayName(Herbal_Powder_Power_displayName)]
        public virtual ushort Herbal_Powder_Power {
            get => GetData<ushort>(116);
            set {
                if (GetData<ushort>(116) == value) return;
                SetData(116, value, nameof(Herbal_Powder_Power));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Herbal_Powder_Power));
            }
        }

        public const string Demon_Powder_Power_displayName = "Demon Powder Power";
        public const int Demon_Powder_Power_sortIndex = 2150;
        [SortOrder(Demon_Powder_Power_sortIndex)]
        [DisplayName(Demon_Powder_Power_displayName)]
        public virtual ushort Demon_Powder_Power {
            get => GetData<ushort>(118);
            set {
                if (GetData<ushort>(118) == value) return;
                SetData(118, value, nameof(Demon_Powder_Power));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Demon_Powder_Power));
            }
        }

        public const string Demon_Powder_Duration_displayName = "Demon Powder Duration";
        public const int Demon_Powder_Duration_sortIndex = 2200;
        [SortOrder(Demon_Powder_Duration_sortIndex)]
        [DisplayName(Demon_Powder_Duration_displayName)]
        public virtual ushort Demon_Powder_Duration {
            get => GetData<ushort>(120);
            set {
                if (GetData<ushort>(120) == value) return;
                SetData(120, value, nameof(Demon_Powder_Duration));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Demon_Powder_Duration));
            }
        }

        public const string Hardshell_Powder_Power_displayName = "Hardshell Powder Power";
        public const int Hardshell_Powder_Power_sortIndex = 2250;
        [SortOrder(Hardshell_Powder_Power_sortIndex)]
        [DisplayName(Hardshell_Powder_Power_displayName)]
        public virtual ushort Hardshell_Powder_Power {
            get => GetData<ushort>(122);
            set {
                if (GetData<ushort>(122) == value) return;
                SetData(122, value, nameof(Hardshell_Powder_Power));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Hardshell_Powder_Power));
            }
        }

        public const string Hardshell_Powder_Duration_displayName = "Hardshell Powder Duration";
        public const int Hardshell_Powder_Duration_sortIndex = 2300;
        [SortOrder(Hardshell_Powder_Duration_sortIndex)]
        [DisplayName(Hardshell_Powder_Duration_displayName)]
        public virtual ushort Hardshell_Powder_Duration {
            get => GetData<ushort>(124);
            set {
                if (GetData<ushort>(124) == value) return;
                SetData(124, value, nameof(Hardshell_Powder_Duration));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Hardshell_Powder_Duration));
            }
        }

        public const string Demon_Ammo_Power_displayName = "Demon Ammo Power";
        public const int Demon_Ammo_Power_sortIndex = 2350;
        [SortOrder(Demon_Ammo_Power_sortIndex)]
        [DisplayName(Demon_Ammo_Power_displayName)]
        public virtual ushort Demon_Ammo_Power {
            get => GetData<ushort>(126);
            set {
                if (GetData<ushort>(126) == value) return;
                SetData(126, value, nameof(Demon_Ammo_Power));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Demon_Ammo_Power));
            }
        }

        public const string Demon_Ammo_Duration_displayName = "Demon Ammo Duration";
        public const int Demon_Ammo_Duration_sortIndex = 2400;
        [SortOrder(Demon_Ammo_Duration_sortIndex)]
        [DisplayName(Demon_Ammo_Duration_displayName)]
        public virtual ushort Demon_Ammo_Duration {
            get => GetData<ushort>(128);
            set {
                if (GetData<ushort>(128) == value) return;
                SetData(128, value, nameof(Demon_Ammo_Duration));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Demon_Ammo_Duration));
            }
        }

        public const string Armor_Ammo_Power_displayName = "Armor Ammo Power";
        public const int Armor_Ammo_Power_sortIndex = 2450;
        [SortOrder(Armor_Ammo_Power_sortIndex)]
        [DisplayName(Armor_Ammo_Power_displayName)]
        public virtual ushort Armor_Ammo_Power {
            get => GetData<ushort>(130);
            set {
                if (GetData<ushort>(130) == value) return;
                SetData(130, value, nameof(Armor_Ammo_Power));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Armor_Ammo_Power));
            }
        }

        public const string Armor_Ammo_Duration_displayName = "Armor Ammo Duration";
        public const int Armor_Ammo_Duration_sortIndex = 2500;
        [SortOrder(Armor_Ammo_Duration_sortIndex)]
        [DisplayName(Armor_Ammo_Duration_displayName)]
        public virtual ushort Armor_Ammo_Duration {
            get => GetData<ushort>(132);
            set {
                if (GetData<ushort>(132) == value) return;
                SetData(132, value, nameof(Armor_Ammo_Duration));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Armor_Ammo_Duration));
            }
        }

        public const string Ration_Power_displayName = "Ration Power";
        public const int Ration_Power_sortIndex = 2550;
        [SortOrder(Ration_Power_sortIndex)]
        [DisplayName(Ration_Power_displayName)]
        public virtual ushort Ration_Power {
            get => GetData<ushort>(134);
            set {
                if (GetData<ushort>(134) == value) return;
                SetData(134, value, nameof(Ration_Power));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Ration_Power));
            }
        }

        public const string Well_Done_Steak_Multiplier_displayName = "Well Done Steak Multiplier";
        public const int Well_Done_Steak_Multiplier_sortIndex = 2600;
        [SortOrder(Well_Done_Steak_Multiplier_sortIndex)]
        [DisplayName(Well_Done_Steak_Multiplier_displayName)]
        public virtual uint Well_Done_Steak_Multiplier {
            get => GetData<uint>(136);
            set {
                if (GetData<uint>(136) == value) return;
                SetData(136, value, nameof(Well_Done_Steak_Multiplier));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Well_Done_Steak_Multiplier));
            }
        }

        public const string Well_Done_Steak_Stamina_Bonus_displayName = "Well Done Steak Stamina Bonus";
        public const int Well_Done_Steak_Stamina_Bonus_sortIndex = 2650;
        [SortOrder(Well_Done_Steak_Stamina_Bonus_sortIndex)]
        [DisplayName(Well_Done_Steak_Stamina_Bonus_displayName)]
        public virtual float Well_Done_Steak_Stamina_Bonus {
            get => GetData<float>(140);
            set {
                if (GetData<float>(140) == value) return;
                SetData(140, value, nameof(Well_Done_Steak_Stamina_Bonus));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Well_Done_Steak_Stamina_Bonus));
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

        public const string Burnt_Meat_Stamina_Recovery_displayName = "Burnt Meat Stamina Recovery";
        public const int Burnt_Meat_Stamina_Recovery_sortIndex = 2800;
        [SortOrder(Burnt_Meat_Stamina_Recovery_sortIndex)]
        [DisplayName(Burnt_Meat_Stamina_Recovery_displayName)]
        public virtual ushort Burnt_Meat_Stamina_Recovery {
            get => GetData<ushort>(152);
            set {
                if (GetData<ushort>(152) == value) return;
                SetData(152, value, nameof(Burnt_Meat_Stamina_Recovery));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Burnt_Meat_Stamina_Recovery));
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

        public const string Whetstone_Sharpness_Restored_displayName = "Whetstone Sharpness Restored";
        public const int Whetstone_Sharpness_Restored_sortIndex = 3500;
        [SortOrder(Whetstone_Sharpness_Restored_sortIndex)]
        [DisplayName(Whetstone_Sharpness_Restored_displayName)]
        public virtual uint Whetstone_Sharpness_Restored {
            get => GetData<uint>(201);
            set {
                if (GetData<uint>(201) == value) return;
                SetData(201, value, nameof(Whetstone_Sharpness_Restored));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Whetstone_Sharpness_Restored));
            }
        }

        public const string Whetstone_Cycles_displayName = "Whetstone Cycles";
        public const int Whetstone_Cycles_sortIndex = 3550;
        [SortOrder(Whetstone_Cycles_sortIndex)]
        [DisplayName(Whetstone_Cycles_displayName)]
        public virtual uint Whetstone_Cycles {
            get => GetData<uint>(205);
            set {
                if (GetData<uint>(205) == value) return;
                SetData(205, value, nameof(Whetstone_Cycles));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Whetstone_Cycles));
            }
        }

        public const string Whetfish_Scale_Sharpness_Restored_displayName = "Whetfish Scale Sharpness Restored";
        public const int Whetfish_Scale_Sharpness_Restored_sortIndex = 3600;
        [SortOrder(Whetfish_Scale_Sharpness_Restored_sortIndex)]
        [DisplayName(Whetfish_Scale_Sharpness_Restored_displayName)]
        public virtual uint Whetfish_Scale_Sharpness_Restored {
            get => GetData<uint>(209);
            set {
                if (GetData<uint>(209) == value) return;
                SetData(209, value, nameof(Whetfish_Scale_Sharpness_Restored));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Whetfish_Scale_Sharpness_Restored));
            }
        }

        public const string Whetfish_Scale_Cycles_displayName = "Whetfish Scale Cycles";
        public const int Whetfish_Scale_Cycles_sortIndex = 3650;
        [SortOrder(Whetfish_Scale_Cycles_sortIndex)]
        [DisplayName(Whetfish_Scale_Cycles_displayName)]
        public virtual byte Whetfish_Scale_Cycles {
            get => GetData<byte>(213);
            set {
                if (GetData<byte>(213) == value) return;
                SetData(213, value, nameof(Whetfish_Scale_Cycles));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Whetfish_Scale_Cycles));
            }
        }

        public const string Whetfish_Scale_Plus_Cycles_displayName = "Whetfish Scale Plus Cycles";
        public const int Whetfish_Scale_Plus_Cycles_sortIndex = 3700;
        [SortOrder(Whetfish_Scale_Plus_Cycles_sortIndex)]
        [DisplayName(Whetfish_Scale_Plus_Cycles_displayName)]
        public virtual byte Whetfish_Scale_Plus_Cycles {
            get => GetData<byte>(214);
            set {
                if (GetData<byte>(214) == value) return;
                SetData(214, value, nameof(Whetfish_Scale_Plus_Cycles));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Whetfish_Scale_Plus_Cycles));
            }
        }

        public const string Whetfish_Scale_Consume__displayName = "Whetfish Scale Consume %";
        public const int Whetfish_Scale_Consume__sortIndex = 3750;
        [SortOrder(Whetfish_Scale_Consume__sortIndex)]
        [DisplayName(Whetfish_Scale_Consume__displayName)]
        public virtual byte Whetfish_Scale_Consume_ {
            get => GetData<byte>(215);
            set {
                if (GetData<byte>(215) == value) return;
                SetData(215, value, nameof(Whetfish_Scale_Consume_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Whetfish_Scale_Consume_));
            }
        }

        public const string Powertalon_Power_displayName = "Powertalon Power";
        public const int Powertalon_Power_sortIndex = 3800;
        [SortOrder(Powertalon_Power_sortIndex)]
        [DisplayName(Powertalon_Power_displayName)]
        public virtual byte Powertalon_Power {
            get => GetData<byte>(216);
            set {
                if (GetData<byte>(216) == value) return;
                SetData(216, value, nameof(Powertalon_Power));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Powertalon_Power));
            }
        }

        public const string Powercharm_Power_displayName = "Powercharm Power";
        public const int Powercharm_Power_sortIndex = 3850;
        [SortOrder(Powercharm_Power_sortIndex)]
        [DisplayName(Powercharm_Power_displayName)]
        public virtual byte Powercharm_Power {
            get => GetData<byte>(217);
            set {
                if (GetData<byte>(217) == value) return;
                SetData(217, value, nameof(Powercharm_Power));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Powercharm_Power));
            }
        }

        public const string Armortalon_Power_displayName = "Armortalon Power";
        public const int Armortalon_Power_sortIndex = 3900;
        [SortOrder(Armortalon_Power_sortIndex)]
        [DisplayName(Armortalon_Power_displayName)]
        public virtual byte Armortalon_Power {
            get => GetData<byte>(218);
            set {
                if (GetData<byte>(218) == value) return;
                SetData(218, value, nameof(Armortalon_Power));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Armortalon_Power));
            }
        }

        public const string Armorcharm_Power_displayName = "Armorcharm Power";
        public const int Armorcharm_Power_sortIndex = 3950;
        [SortOrder(Armorcharm_Power_sortIndex)]
        [DisplayName(Armorcharm_Power_displayName)]
        public virtual byte Armorcharm_Power {
            get => GetData<byte>(219);
            set {
                if (GetData<byte>(219) == value) return;
                SetData(219, value, nameof(Armorcharm_Power));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Armorcharm_Power));
            }
        }

        public const string Unk49_displayName = "Unk49";
        public const int Unk49_sortIndex = 4000;
        [SortOrder(Unk49_sortIndex)]
        [DisplayName(Unk49_displayName)]
        public virtual byte Unk49 {
            get => GetData<byte>(220);
            set {
                if (GetData<byte>(220) == value) return;
                SetData(220, value, nameof(Unk49));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk49));
            }
        }

        public const string Unk50_displayName = "Unk50";
        public const int Unk50_sortIndex = 4050;
        [SortOrder(Unk50_sortIndex)]
        [DisplayName(Unk50_displayName)]
        public virtual float Unk50 {
            get => GetData<float>(221);
            set {
                if (GetData<float>(221) == value) return;
                SetData(221, value, nameof(Unk50));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk50));
            }
        }

        public const string Unk51_displayName = "Unk51";
        public const int Unk51_sortIndex = 4100;
        [SortOrder(Unk51_sortIndex)]
        [DisplayName(Unk51_displayName)]
        public virtual float Unk51 {
            get => GetData<float>(225);
            set {
                if (GetData<float>(225) == value) return;
                SetData(225, value, nameof(Unk51));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk51));
            }
        }

        public const string Unk52_displayName = "Unk52";
        public const int Unk52_sortIndex = 4150;
        [SortOrder(Unk52_sortIndex)]
        [DisplayName(Unk52_displayName)]
        public virtual float Unk52 {
            get => GetData<float>(229);
            set {
                if (GetData<float>(229) == value) return;
                SetData(229, value, nameof(Unk52));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk52));
            }
        }

        public const string Unk53_displayName = "Unk53";
        public const int Unk53_sortIndex = 4200;
        [SortOrder(Unk53_sortIndex)]
        [DisplayName(Unk53_displayName)]
        public virtual float Unk53 {
            get => GetData<float>(233);
            set {
                if (GetData<float>(233) == value) return;
                SetData(233, value, nameof(Unk53));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk53));
            }
        }

        public const string Unk54_displayName = "Unk54";
        public const int Unk54_sortIndex = 4250;
        [SortOrder(Unk54_sortIndex)]
        [DisplayName(Unk54_displayName)]
        public virtual float Unk54 {
            get => GetData<float>(237);
            set {
                if (GetData<float>(237) == value) return;
                SetData(237, value, nameof(Unk54));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk54));
            }
        }

        public const string Unk55_displayName = "Unk55";
        public const int Unk55_sortIndex = 4300;
        [SortOrder(Unk55_sortIndex)]
        [DisplayName(Unk55_displayName)]
        public virtual float Unk55 {
            get => GetData<float>(241);
            set {
                if (GetData<float>(241) == value) return;
                SetData(241, value, nameof(Unk55));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk55));
            }
        }

        public const string Unk56_displayName = "Unk56";
        public const int Unk56_sortIndex = 4350;
        [SortOrder(Unk56_sortIndex)]
        [DisplayName(Unk56_displayName)]
        public virtual float Unk56 {
            get => GetData<float>(245);
            set {
                if (GetData<float>(245) == value) return;
                SetData(245, value, nameof(Unk56));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk56));
            }
        }

        public const string Unk57_displayName = "Unk57";
        public const int Unk57_sortIndex = 4400;
        [SortOrder(Unk57_sortIndex)]
        [DisplayName(Unk57_displayName)]
        public virtual float Unk57 {
            get => GetData<float>(249);
            set {
                if (GetData<float>(249) == value) return;
                SetData(249, value, nameof(Unk57));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk57));
            }
        }

        public const string Unk58_displayName = "Unk58";
        public const int Unk58_sortIndex = 4450;
        [SortOrder(Unk58_sortIndex)]
        [DisplayName(Unk58_displayName)]
        public virtual float Unk58 {
            get => GetData<float>(253);
            set {
                if (GetData<float>(253) == value) return;
                SetData(253, value, nameof(Unk58));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk58));
            }
        }

        public const string Unk59_displayName = "Unk59";
        public const int Unk59_sortIndex = 4500;
        [SortOrder(Unk59_sortIndex)]
        [DisplayName(Unk59_displayName)]
        public virtual float Unk59 {
            get => GetData<float>(257);
            set {
                if (GetData<float>(257) == value) return;
                SetData(257, value, nameof(Unk59));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk59));
            }
        }

        public const string Unk60_displayName = "Unk60";
        public const int Unk60_sortIndex = 4550;
        [SortOrder(Unk60_sortIndex)]
        [DisplayName(Unk60_displayName)]
        public virtual float Unk60 {
            get => GetData<float>(261);
            set {
                if (GetData<float>(261) == value) return;
                SetData(261, value, nameof(Unk60));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk60));
            }
        }

        public const string Unk61_displayName = "Unk61";
        public const int Unk61_sortIndex = 4600;
        [SortOrder(Unk61_sortIndex)]
        [DisplayName(Unk61_displayName)]
        public virtual float Unk61 {
            get => GetData<float>(265);
            set {
                if (GetData<float>(265) == value) return;
                SetData(265, value, nameof(Unk61));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk61));
            }
        }

        public const string Unk62_displayName = "Unk62";
        public const int Unk62_sortIndex = 4650;
        [SortOrder(Unk62_sortIndex)]
        [DisplayName(Unk62_displayName)]
        public virtual float Unk62 {
            get => GetData<float>(269);
            set {
                if (GetData<float>(269) == value) return;
                SetData(269, value, nameof(Unk62));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk62));
            }
        }

        public const string Unk63_displayName = "Unk63";
        public const int Unk63_sortIndex = 4700;
        [SortOrder(Unk63_sortIndex)]
        [DisplayName(Unk63_displayName)]
        public virtual float Unk63 {
            get => GetData<float>(273);
            set {
                if (GetData<float>(273) == value) return;
                SetData(273, value, nameof(Unk63));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk63));
            }
        }

        public const string Unk64_displayName = "Unk64";
        public const int Unk64_sortIndex = 4750;
        [SortOrder(Unk64_sortIndex)]
        [DisplayName(Unk64_displayName)]
        public virtual float Unk64 {
            get => GetData<float>(277);
            set {
                if (GetData<float>(277) == value) return;
                SetData(277, value, nameof(Unk64));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk64));
            }
        }

        public const string Unk65_displayName = "Unk65";
        public const int Unk65_sortIndex = 4800;
        [SortOrder(Unk65_sortIndex)]
        [DisplayName(Unk65_displayName)]
        public virtual float Unk65 {
            get => GetData<float>(281);
            set {
                if (GetData<float>(281) == value) return;
                SetData(281, value, nameof(Unk65));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk65));
            }
        }

        public const string Unk66_displayName = "Unk66";
        public const int Unk66_sortIndex = 4850;
        [SortOrder(Unk66_sortIndex)]
        [DisplayName(Unk66_displayName)]
        public virtual float Unk66 {
            get => GetData<float>(285);
            set {
                if (GetData<float>(285) == value) return;
                SetData(285, value, nameof(Unk66));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk66));
            }
        }

        public const string Unk67_displayName = "Unk67";
        public const int Unk67_sortIndex = 4900;
        [SortOrder(Unk67_sortIndex)]
        [DisplayName(Unk67_displayName)]
        public virtual float Unk67 {
            get => GetData<float>(289);
            set {
                if (GetData<float>(289) == value) return;
                SetData(289, value, nameof(Unk67));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk67));
            }
        }

        public const string Unk68_displayName = "Unk68";
        public const int Unk68_sortIndex = 4950;
        [SortOrder(Unk68_sortIndex)]
        [DisplayName(Unk68_displayName)]
        public virtual float Unk68 {
            get => GetData<float>(293);
            set {
                if (GetData<float>(293) == value) return;
                SetData(293, value, nameof(Unk68));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk68));
            }
        }

        public const string Unk69_displayName = "Unk69";
        public const int Unk69_sortIndex = 5000;
        [SortOrder(Unk69_sortIndex)]
        [DisplayName(Unk69_displayName)]
        public virtual float Unk69 {
            get => GetData<float>(297);
            set {
                if (GetData<float>(297) == value) return;
                SetData(297, value, nameof(Unk69));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk69));
            }
        }

        public const string Unk70_displayName = "Unk70";
        public const int Unk70_sortIndex = 5050;
        [SortOrder(Unk70_sortIndex)]
        [DisplayName(Unk70_displayName)]
        public virtual float Unk70 {
            get => GetData<float>(301);
            set {
                if (GetData<float>(301) == value) return;
                SetData(301, value, nameof(Unk70));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk70));
            }
        }

        public const string Unk71_displayName = "Unk71";
        public const int Unk71_sortIndex = 5100;
        [SortOrder(Unk71_sortIndex)]
        [DisplayName(Unk71_displayName)]
        public virtual float Unk71 {
            get => GetData<float>(305);
            set {
                if (GetData<float>(305) == value) return;
                SetData(305, value, nameof(Unk71));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk71));
            }
        }

        public const string Unk72_displayName = "Unk72";
        public const int Unk72_sortIndex = 5150;
        [SortOrder(Unk72_sortIndex)]
        [DisplayName(Unk72_displayName)]
        public virtual float Unk72 {
            get => GetData<float>(309);
            set {
                if (GetData<float>(309) == value) return;
                SetData(309, value, nameof(Unk72));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk72));
            }
        }

        public const string Unk73_displayName = "Unk73";
        public const int Unk73_sortIndex = 5200;
        [SortOrder(Unk73_sortIndex)]
        [DisplayName(Unk73_displayName)]
        public virtual float Unk73 {
            get => GetData<float>(313);
            set {
                if (GetData<float>(313) == value) return;
                SetData(313, value, nameof(Unk73));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk73));
            }
        }

        public const string Unk74_displayName = "Unk74";
        public const int Unk74_sortIndex = 5250;
        [SortOrder(Unk74_sortIndex)]
        [DisplayName(Unk74_displayName)]
        public virtual float Unk74 {
            get => GetData<float>(317);
            set {
                if (GetData<float>(317) == value) return;
                SetData(317, value, nameof(Unk74));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk74));
            }
        }

        public const string Unk75_displayName = "Unk75";
        public const int Unk75_sortIndex = 5300;
        [SortOrder(Unk75_sortIndex)]
        [DisplayName(Unk75_displayName)]
        public virtual float Unk75 {
            get => GetData<float>(321);
            set {
                if (GetData<float>(321) == value) return;
                SetData(321, value, nameof(Unk75));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk75));
            }
        }

        public const string Unk76_displayName = "Unk76";
        public const int Unk76_sortIndex = 5350;
        [SortOrder(Unk76_sortIndex)]
        [DisplayName(Unk76_displayName)]
        public virtual float Unk76 {
            get => GetData<float>(325);
            set {
                if (GetData<float>(325) == value) return;
                SetData(325, value, nameof(Unk76));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk76));
            }
        }

        public const string Unk77_displayName = "Unk77";
        public const int Unk77_sortIndex = 5400;
        [SortOrder(Unk77_sortIndex)]
        [DisplayName(Unk77_displayName)]
        public virtual float Unk77 {
            get => GetData<float>(329);
            set {
                if (GetData<float>(329) == value) return;
                SetData(329, value, nameof(Unk77));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk77));
            }
        }

        public const string Unk78_displayName = "Unk78";
        public const int Unk78_sortIndex = 5450;
        [SortOrder(Unk78_sortIndex)]
        [DisplayName(Unk78_displayName)]
        public virtual float Unk78 {
            get => GetData<float>(337);
            set {
                if (GetData<float>(337) == value) return;
                SetData(337, value, nameof(Unk78));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk78));
            }
        }

        public const string Unk79_displayName = "Unk79";
        public const int Unk79_sortIndex = 5500;
        [SortOrder(Unk79_sortIndex)]
        [DisplayName(Unk79_displayName)]
        public virtual float Unk79 {
            get => GetData<float>(341);
            set {
                if (GetData<float>(341) == value) return;
                SetData(341, value, nameof(Unk79));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk79));
            }
        }

        public const string Unk80_displayName = "Unk80";
        public const int Unk80_sortIndex = 5550;
        [SortOrder(Unk80_sortIndex)]
        [DisplayName(Unk80_displayName)]
        public virtual float Unk80 {
            get => GetData<float>(345);
            set {
                if (GetData<float>(345) == value) return;
                SetData(345, value, nameof(Unk80));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk80));
            }
        }

        public const string Unk81_displayName = "Unk81";
        public const int Unk81_sortIndex = 5600;
        [SortOrder(Unk81_sortIndex)]
        [DisplayName(Unk81_displayName)]
        public virtual float Unk81 {
            get => GetData<float>(349);
            set {
                if (GetData<float>(349) == value) return;
                SetData(349, value, nameof(Unk81));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk81));
            }
        }

        public const string Unk82_displayName = "Unk82";
        public const int Unk82_sortIndex = 5650;
        [SortOrder(Unk82_sortIndex)]
        [DisplayName(Unk82_displayName)]
        public virtual float Unk82 {
            get => GetData<float>(353);
            set {
                if (GetData<float>(353) == value) return;
                SetData(353, value, nameof(Unk82));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk82));
            }
        }

        public const string Unk83_displayName = "Unk83";
        public const int Unk83_sortIndex = 5700;
        [SortOrder(Unk83_sortIndex)]
        [DisplayName(Unk83_displayName)]
        public virtual float Unk83 {
            get => GetData<float>(357);
            set {
                if (GetData<float>(357) == value) return;
                SetData(357, value, nameof(Unk83));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk83));
            }
        }

        public const string Unk84_displayName = "Unk84";
        public const int Unk84_sortIndex = 5750;
        [SortOrder(Unk84_sortIndex)]
        [DisplayName(Unk84_displayName)]
        public virtual float Unk84 {
            get => GetData<float>(361);
            set {
                if (GetData<float>(361) == value) return;
                SetData(361, value, nameof(Unk84));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk84));
            }
        }

        public const string Unk85_displayName = "Unk85";
        public const int Unk85_sortIndex = 5800;
        [SortOrder(Unk85_sortIndex)]
        [DisplayName(Unk85_displayName)]
        public virtual float Unk85 {
            get => GetData<float>(365);
            set {
                if (GetData<float>(365) == value) return;
                SetData(365, value, nameof(Unk85));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk85));
            }
        }

        public const string Unk86_displayName = "Unk86";
        public const int Unk86_sortIndex = 5850;
        [SortOrder(Unk86_sortIndex)]
        [DisplayName(Unk86_displayName)]
        public virtual float Unk86 {
            get => GetData<float>(369);
            set {
                if (GetData<float>(369) == value) return;
                SetData(369, value, nameof(Unk86));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk86));
            }
        }

        public const string Unk87_displayName = "Unk87";
        public const int Unk87_sortIndex = 5900;
        [SortOrder(Unk87_sortIndex)]
        [DisplayName(Unk87_displayName)]
        public virtual float Unk87 {
            get => GetData<float>(373);
            set {
                if (GetData<float>(373) == value) return;
                SetData(373, value, nameof(Unk87));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk87));
            }
        }

        public const string Unk88_displayName = "Unk88";
        public const int Unk88_sortIndex = 5950;
        [SortOrder(Unk88_sortIndex)]
        [DisplayName(Unk88_displayName)]
        public virtual float Unk88 {
            get => GetData<float>(377);
            set {
                if (GetData<float>(377) == value) return;
                SetData(377, value, nameof(Unk88));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk88));
            }
        }

        public const string Unk89_displayName = "Unk89";
        public const int Unk89_sortIndex = 6000;
        [SortOrder(Unk89_sortIndex)]
        [DisplayName(Unk89_displayName)]
        public virtual float Unk89 {
            get => GetData<float>(381);
            set {
                if (GetData<float>(381) == value) return;
                SetData(381, value, nameof(Unk89));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk89));
            }
        }

        public const string Unk90_displayName = "Unk90";
        public const int Unk90_sortIndex = 6050;
        [SortOrder(Unk90_sortIndex)]
        [DisplayName(Unk90_displayName)]
        public virtual float Unk90 {
            get => GetData<float>(385);
            set {
                if (GetData<float>(385) == value) return;
                SetData(385, value, nameof(Unk90));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk90));
            }
        }

        public const string Unk91_displayName = "Unk91";
        public const int Unk91_sortIndex = 6100;
        [SortOrder(Unk91_sortIndex)]
        [DisplayName(Unk91_displayName)]
        public virtual float Unk91 {
            get => GetData<float>(389);
            set {
                if (GetData<float>(389) == value) return;
                SetData(389, value, nameof(Unk91));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk91));
            }
        }

        public const string Unk92_displayName = "Unk92";
        public const int Unk92_sortIndex = 6150;
        [SortOrder(Unk92_sortIndex)]
        [DisplayName(Unk92_displayName)]
        public virtual float Unk92 {
            get => GetData<float>(393);
            set {
                if (GetData<float>(393) == value) return;
                SetData(393, value, nameof(Unk92));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk92));
            }
        }

        public const string Unk93_displayName = "Unk93";
        public const int Unk93_sortIndex = 6200;
        [SortOrder(Unk93_sortIndex)]
        [DisplayName(Unk93_displayName)]
        public virtual float Unk93 {
            get => GetData<float>(397);
            set {
                if (GetData<float>(397) == value) return;
                SetData(397, value, nameof(Unk93));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk93));
            }
        }

        public const string Unk94_displayName = "Unk94";
        public const int Unk94_sortIndex = 6250;
        [SortOrder(Unk94_sortIndex)]
        [DisplayName(Unk94_displayName)]
        public virtual float Unk94 {
            get => GetData<float>(401);
            set {
                if (GetData<float>(401) == value) return;
                SetData(401, value, nameof(Unk94));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk94));
            }
        }

        public const string Unk95_displayName = "Unk95";
        public const int Unk95_sortIndex = 6300;
        [SortOrder(Unk95_sortIndex)]
        [DisplayName(Unk95_displayName)]
        public virtual float Unk95 {
            get => GetData<float>(405);
            set {
                if (GetData<float>(405) == value) return;
                SetData(405, value, nameof(Unk95));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk95));
            }
        }

        public const string Unk96_displayName = "Unk96";
        public const int Unk96_sortIndex = 6350;
        [SortOrder(Unk96_sortIndex)]
        [DisplayName(Unk96_displayName)]
        public virtual float Unk96 {
            get => GetData<float>(409);
            set {
                if (GetData<float>(409) == value) return;
                SetData(409, value, nameof(Unk96));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk96));
            }
        }

        public const string Unk97_displayName = "Unk97";
        public const int Unk97_sortIndex = 6400;
        [SortOrder(Unk97_sortIndex)]
        [DisplayName(Unk97_displayName)]
        public virtual float Unk97 {
            get => GetData<float>(413);
            set {
                if (GetData<float>(413) == value) return;
                SetData(413, value, nameof(Unk97));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk97));
            }
        }

        public const string Unk98_displayName = "Unk98";
        public const int Unk98_sortIndex = 6450;
        [SortOrder(Unk98_sortIndex)]
        [DisplayName(Unk98_displayName)]
        public virtual float Unk98 {
            get => GetData<float>(417);
            set {
                if (GetData<float>(417) == value) return;
                SetData(417, value, nameof(Unk98));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk98));
            }
        }

        public const string Unk99_displayName = "Unk99";
        public const int Unk99_sortIndex = 6500;
        [SortOrder(Unk99_sortIndex)]
        [DisplayName(Unk99_displayName)]
        public virtual float Unk99 {
            get => GetData<float>(417);
            set {
                if (GetData<float>(417) == value) return;
                SetData(417, value, nameof(Unk99));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk99));
            }
        }

        public const string Unk100_displayName = "Unk100";
        public const int Unk100_sortIndex = 6550;
        [SortOrder(Unk100_sortIndex)]
        [DisplayName(Unk100_displayName)]
        public virtual float Unk100 {
            get => GetData<float>(421);
            set {
                if (GetData<float>(421) == value) return;
                SetData(421, value, nameof(Unk100));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk100));
            }
        }

        public const string Unk101_displayName = "Unk101";
        public const int Unk101_sortIndex = 6600;
        [SortOrder(Unk101_sortIndex)]
        [DisplayName(Unk101_displayName)]
        public virtual float Unk101 {
            get => GetData<float>(425);
            set {
                if (GetData<float>(425) == value) return;
                SetData(425, value, nameof(Unk101));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk101));
            }
        }

        public const string Unk102_displayName = "Unk102";
        public const int Unk102_sortIndex = 6650;
        [SortOrder(Unk102_sortIndex)]
        [DisplayName(Unk102_displayName)]
        public virtual float Unk102 {
            get => GetData<float>(429);
            set {
                if (GetData<float>(429) == value) return;
                SetData(429, value, nameof(Unk102));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk102));
            }
        }

        public const string Unk103_displayName = "Unk103";
        public const int Unk103_sortIndex = 6700;
        [SortOrder(Unk103_sortIndex)]
        [DisplayName(Unk103_displayName)]
        public virtual float Unk103 {
            get => GetData<float>(433);
            set {
                if (GetData<float>(433) == value) return;
                SetData(433, value, nameof(Unk103));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk103));
            }
        }

        public const string Unk104_displayName = "Unk104";
        public const int Unk104_sortIndex = 6750;
        [SortOrder(Unk104_sortIndex)]
        [DisplayName(Unk104_displayName)]
        public virtual float Unk104 {
            get => GetData<float>(437);
            set {
                if (GetData<float>(437) == value) return;
                SetData(437, value, nameof(Unk104));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk104));
            }
        }

        public const string Unk105_displayName = "Unk105";
        public const int Unk105_sortIndex = 6800;
        [SortOrder(Unk105_sortIndex)]
        [DisplayName(Unk105_displayName)]
        public virtual float Unk105 {
            get => GetData<float>(441);
            set {
                if (GetData<float>(441) == value) return;
                SetData(441, value, nameof(Unk105));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk105));
            }
        }

        public const string Deathcream_455_499_are_fishing_rumble_displayName = "Deathcream: 455-499 are fishing rumble";
        public const int Deathcream_455_499_are_fishing_rumble_sortIndex = 6850;
        [SortOrder(Deathcream_455_499_are_fishing_rumble_sortIndex)]
        [DisplayName(Deathcream_455_499_are_fishing_rumble_displayName)]
        public virtual byte Deathcream_455_499_are_fishing_rumble {
            get => GetData<byte>(445);
            set {
                if (GetData<byte>(445) == value) return;
                SetData(445, value, nameof(Deathcream_455_499_are_fishing_rumble));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Deathcream_455_499_are_fishing_rumble));
            }
        }

        public const string and_skipped_for_now__displayName = "and skipped for now.";
        public const int and_skipped_for_now__sortIndex = 6900;
        [SortOrder(and_skipped_for_now__sortIndex)]
        [DisplayName(and_skipped_for_now__displayName)]
        public virtual uint and_skipped_for_now_ {
            get => GetData<uint>(446);
            set {
                if (GetData<uint>(446) == value) return;
                SetData(446, value, nameof(and_skipped_for_now_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(and_skipped_for_now_));
            }
        }

        public const string Unk106_displayName = "Unk106";
        public const int Unk106_sortIndex = 6950;
        [SortOrder(Unk106_sortIndex)]
        [DisplayName(Unk106_displayName)]
        public virtual float Unk106 {
            get => GetData<float>(500);
            set {
                if (GetData<float>(500) == value) return;
                SetData(500, value, nameof(Unk106));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk106));
            }
        }

        public const string Unk107_displayName = "Unk107";
        public const int Unk107_sortIndex = 7000;
        [SortOrder(Unk107_sortIndex)]
        [DisplayName(Unk107_displayName)]
        public virtual float Unk107 {
            get => GetData<float>(504);
            set {
                if (GetData<float>(504) == value) return;
                SetData(504, value, nameof(Unk107));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk107));
            }
        }

        public const string Unk108_displayName = "Unk108";
        public const int Unk108_sortIndex = 7050;
        [SortOrder(Unk108_sortIndex)]
        [DisplayName(Unk108_displayName)]
        public virtual float Unk108 {
            get => GetData<float>(508);
            set {
                if (GetData<float>(508) == value) return;
                SetData(508, value, nameof(Unk108));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk108));
            }
        }

        public const int lastSortIndex = 7100;
    }
}
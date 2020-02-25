using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Items {
    public partial class MelderExchange {
        public const uint StructSize = 430;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public const string EncryptionKey = null;
        public override string UniqueId => $"{Index}";

        public const string Source_Item_Id_displayName = "Source Item Id";
        public const int Source_Item_Id_sortIndex = 50;
        [SortOrder(Source_Item_Id_sortIndex)]
        [DisplayName(Source_Item_Id_displayName)]
        [DataSource(DataSourceType.Items)]
        public virtual uint Source_Item_Id {
            get => GetData<uint>(0);
            set {
                if (GetData<uint>(0) == value) return;
                SetData(0, value, nameof(Source_Item_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Source_Item_Id));
                OnPropertyChanged(nameof(Source_Item_Id_button));
            }
        }

        [SortOrder(Source_Item_Id_sortIndex)]
        [DisplayName(Source_Item_Id_displayName)]
        [CustomSorter(typeof(ButtonSorter))]
        public string Source_Item_Id_button => DataHelper.itemNames[MainWindow.locale].TryGet(Source_Item_Id).ToStringWithId(Source_Item_Id);

        public const string Unknown_int32_1_displayName = "Unknown (int32) 1";
        public const int Unknown_int32_1_sortIndex = 100;
        [SortOrder(Unknown_int32_1_sortIndex)]
        [DisplayName(Unknown_int32_1_displayName)]
        public virtual int Unknown_int32_1 {
            get => GetData<int>(4);
            set {
                if (GetData<int>(4) == value) return;
                SetData(4, value, nameof(Unknown_int32_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unknown_int32_1));
            }
        }

        public const string It_0_displayName = "It 0";
        public const int It_0_sortIndex = 150;
        [SortOrder(It_0_sortIndex)]
        [DisplayName(It_0_displayName)]
        public virtual ushort It_0 {
            get => GetData<ushort>(8);
            set {
                if (GetData<ushort>(8) == value) return;
                SetData(8, value, nameof(It_0));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_0));
            }
        }

        public const string It_1_displayName = "It 1";
        public const int It_1_sortIndex = 200;
        [SortOrder(It_1_sortIndex)]
        [DisplayName(It_1_displayName)]
        public virtual ushort It_1 {
            get => GetData<ushort>(10);
            set {
                if (GetData<ushort>(10) == value) return;
                SetData(10, value, nameof(It_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_1));
            }
        }

        public const string It_2_displayName = "It 2";
        public const int It_2_sortIndex = 250;
        [SortOrder(It_2_sortIndex)]
        [DisplayName(It_2_displayName)]
        public virtual ushort It_2 {
            get => GetData<ushort>(12);
            set {
                if (GetData<ushort>(12) == value) return;
                SetData(12, value, nameof(It_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_2));
            }
        }

        public const string It_3_displayName = "It 3";
        public const int It_3_sortIndex = 300;
        [SortOrder(It_3_sortIndex)]
        [DisplayName(It_3_displayName)]
        public virtual ushort It_3 {
            get => GetData<ushort>(14);
            set {
                if (GetData<ushort>(14) == value) return;
                SetData(14, value, nameof(It_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_3));
            }
        }

        public const string It_4_displayName = "It 4";
        public const int It_4_sortIndex = 350;
        [SortOrder(It_4_sortIndex)]
        [DisplayName(It_4_displayName)]
        public virtual ushort It_4 {
            get => GetData<ushort>(16);
            set {
                if (GetData<ushort>(16) == value) return;
                SetData(16, value, nameof(It_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_4));
            }
        }

        public const string It_5_displayName = "It 5";
        public const int It_5_sortIndex = 400;
        [SortOrder(It_5_sortIndex)]
        [DisplayName(It_5_displayName)]
        public virtual ushort It_5 {
            get => GetData<ushort>(18);
            set {
                if (GetData<ushort>(18) == value) return;
                SetData(18, value, nameof(It_5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_5));
            }
        }

        public const string It_6_displayName = "It 6";
        public const int It_6_sortIndex = 450;
        [SortOrder(It_6_sortIndex)]
        [DisplayName(It_6_displayName)]
        public virtual ushort It_6 {
            get => GetData<ushort>(20);
            set {
                if (GetData<ushort>(20) == value) return;
                SetData(20, value, nameof(It_6));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_6));
            }
        }

        public const string It_7_displayName = "It 7";
        public const int It_7_sortIndex = 500;
        [SortOrder(It_7_sortIndex)]
        [DisplayName(It_7_displayName)]
        public virtual ushort It_7 {
            get => GetData<ushort>(22);
            set {
                if (GetData<ushort>(22) == value) return;
                SetData(22, value, nameof(It_7));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_7));
            }
        }

        public const string It_8_displayName = "It 8";
        public const int It_8_sortIndex = 550;
        [SortOrder(It_8_sortIndex)]
        [DisplayName(It_8_displayName)]
        public virtual ushort It_8 {
            get => GetData<ushort>(24);
            set {
                if (GetData<ushort>(24) == value) return;
                SetData(24, value, nameof(It_8));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_8));
            }
        }

        public const string It_9_displayName = "It 9";
        public const int It_9_sortIndex = 600;
        [SortOrder(It_9_sortIndex)]
        [DisplayName(It_9_displayName)]
        public virtual ushort It_9 {
            get => GetData<ushort>(26);
            set {
                if (GetData<ushort>(26) == value) return;
                SetData(26, value, nameof(It_9));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_9));
            }
        }

        public const string It_10_displayName = "It 10";
        public const int It_10_sortIndex = 650;
        [SortOrder(It_10_sortIndex)]
        [DisplayName(It_10_displayName)]
        public virtual ushort It_10 {
            get => GetData<ushort>(28);
            set {
                if (GetData<ushort>(28) == value) return;
                SetData(28, value, nameof(It_10));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_10));
            }
        }

        public const string It_11_displayName = "It 11";
        public const int It_11_sortIndex = 700;
        [SortOrder(It_11_sortIndex)]
        [DisplayName(It_11_displayName)]
        public virtual ushort It_11 {
            get => GetData<ushort>(30);
            set {
                if (GetData<ushort>(30) == value) return;
                SetData(30, value, nameof(It_11));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_11));
            }
        }

        public const string It_12_displayName = "It 12";
        public const int It_12_sortIndex = 750;
        [SortOrder(It_12_sortIndex)]
        [DisplayName(It_12_displayName)]
        public virtual ushort It_12 {
            get => GetData<ushort>(32);
            set {
                if (GetData<ushort>(32) == value) return;
                SetData(32, value, nameof(It_12));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_12));
            }
        }

        public const string It_13_displayName = "It 13";
        public const int It_13_sortIndex = 800;
        [SortOrder(It_13_sortIndex)]
        [DisplayName(It_13_displayName)]
        public virtual ushort It_13 {
            get => GetData<ushort>(34);
            set {
                if (GetData<ushort>(34) == value) return;
                SetData(34, value, nameof(It_13));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_13));
            }
        }

        public const string It_14_displayName = "It 14";
        public const int It_14_sortIndex = 850;
        [SortOrder(It_14_sortIndex)]
        [DisplayName(It_14_displayName)]
        public virtual ushort It_14 {
            get => GetData<ushort>(36);
            set {
                if (GetData<ushort>(36) == value) return;
                SetData(36, value, nameof(It_14));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_14));
            }
        }

        public const string It_15_displayName = "It 15";
        public const int It_15_sortIndex = 900;
        [SortOrder(It_15_sortIndex)]
        [DisplayName(It_15_displayName)]
        public virtual ushort It_15 {
            get => GetData<ushort>(38);
            set {
                if (GetData<ushort>(38) == value) return;
                SetData(38, value, nameof(It_15));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_15));
            }
        }

        public const string It_16_displayName = "It 16";
        public const int It_16_sortIndex = 950;
        [SortOrder(It_16_sortIndex)]
        [DisplayName(It_16_displayName)]
        public virtual ushort It_16 {
            get => GetData<ushort>(40);
            set {
                if (GetData<ushort>(40) == value) return;
                SetData(40, value, nameof(It_16));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_16));
            }
        }

        public const string It_17_displayName = "It 17";
        public const int It_17_sortIndex = 1000;
        [SortOrder(It_17_sortIndex)]
        [DisplayName(It_17_displayName)]
        public virtual ushort It_17 {
            get => GetData<ushort>(42);
            set {
                if (GetData<ushort>(42) == value) return;
                SetData(42, value, nameof(It_17));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_17));
            }
        }

        public const string It_18_displayName = "It 18";
        public const int It_18_sortIndex = 1050;
        [SortOrder(It_18_sortIndex)]
        [DisplayName(It_18_displayName)]
        public virtual ushort It_18 {
            get => GetData<ushort>(44);
            set {
                if (GetData<ushort>(44) == value) return;
                SetData(44, value, nameof(It_18));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_18));
            }
        }

        public const string It_19_displayName = "It 19";
        public const int It_19_sortIndex = 1100;
        [SortOrder(It_19_sortIndex)]
        [DisplayName(It_19_displayName)]
        public virtual ushort It_19 {
            get => GetData<ushort>(46);
            set {
                if (GetData<ushort>(46) == value) return;
                SetData(46, value, nameof(It_19));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_19));
            }
        }

        public const string It_20_displayName = "It 20";
        public const int It_20_sortIndex = 1150;
        [SortOrder(It_20_sortIndex)]
        [DisplayName(It_20_displayName)]
        public virtual ushort It_20 {
            get => GetData<ushort>(48);
            set {
                if (GetData<ushort>(48) == value) return;
                SetData(48, value, nameof(It_20));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_20));
            }
        }

        public const string It_21_displayName = "It 21";
        public const int It_21_sortIndex = 1200;
        [SortOrder(It_21_sortIndex)]
        [DisplayName(It_21_displayName)]
        public virtual ushort It_21 {
            get => GetData<ushort>(50);
            set {
                if (GetData<ushort>(50) == value) return;
                SetData(50, value, nameof(It_21));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_21));
            }
        }

        public const string It_22_displayName = "It 22";
        public const int It_22_sortIndex = 1250;
        [SortOrder(It_22_sortIndex)]
        [DisplayName(It_22_displayName)]
        public virtual ushort It_22 {
            get => GetData<ushort>(52);
            set {
                if (GetData<ushort>(52) == value) return;
                SetData(52, value, nameof(It_22));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_22));
            }
        }

        public const string It_23_displayName = "It 23";
        public const int It_23_sortIndex = 1300;
        [SortOrder(It_23_sortIndex)]
        [DisplayName(It_23_displayName)]
        public virtual ushort It_23 {
            get => GetData<ushort>(54);
            set {
                if (GetData<ushort>(54) == value) return;
                SetData(54, value, nameof(It_23));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_23));
            }
        }

        public const string It_24_displayName = "It 24";
        public const int It_24_sortIndex = 1350;
        [SortOrder(It_24_sortIndex)]
        [DisplayName(It_24_displayName)]
        public virtual ushort It_24 {
            get => GetData<ushort>(56);
            set {
                if (GetData<ushort>(56) == value) return;
                SetData(56, value, nameof(It_24));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_24));
            }
        }

        public const string It_25_displayName = "It 25";
        public const int It_25_sortIndex = 1400;
        [SortOrder(It_25_sortIndex)]
        [DisplayName(It_25_displayName)]
        public virtual ushort It_25 {
            get => GetData<ushort>(58);
            set {
                if (GetData<ushort>(58) == value) return;
                SetData(58, value, nameof(It_25));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_25));
            }
        }

        public const string It_26_displayName = "It 26";
        public const int It_26_sortIndex = 1450;
        [SortOrder(It_26_sortIndex)]
        [DisplayName(It_26_displayName)]
        public virtual ushort It_26 {
            get => GetData<ushort>(60);
            set {
                if (GetData<ushort>(60) == value) return;
                SetData(60, value, nameof(It_26));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_26));
            }
        }

        public const string It_27_displayName = "It 27";
        public const int It_27_sortIndex = 1500;
        [SortOrder(It_27_sortIndex)]
        [DisplayName(It_27_displayName)]
        public virtual ushort It_27 {
            get => GetData<ushort>(62);
            set {
                if (GetData<ushort>(62) == value) return;
                SetData(62, value, nameof(It_27));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_27));
            }
        }

        public const string It_28_displayName = "It 28";
        public const int It_28_sortIndex = 1550;
        [SortOrder(It_28_sortIndex)]
        [DisplayName(It_28_displayName)]
        public virtual ushort It_28 {
            get => GetData<ushort>(64);
            set {
                if (GetData<ushort>(64) == value) return;
                SetData(64, value, nameof(It_28));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_28));
            }
        }

        public const string It_29_displayName = "It 29";
        public const int It_29_sortIndex = 1600;
        [SortOrder(It_29_sortIndex)]
        [DisplayName(It_29_displayName)]
        public virtual ushort It_29 {
            get => GetData<ushort>(66);
            set {
                if (GetData<ushort>(66) == value) return;
                SetData(66, value, nameof(It_29));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_29));
            }
        }

        public const string It_30_displayName = "It 30";
        public const int It_30_sortIndex = 1650;
        [SortOrder(It_30_sortIndex)]
        [DisplayName(It_30_displayName)]
        public virtual ushort It_30 {
            get => GetData<ushort>(68);
            set {
                if (GetData<ushort>(68) == value) return;
                SetData(68, value, nameof(It_30));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_30));
            }
        }

        public const string It_31_displayName = "It 31";
        public const int It_31_sortIndex = 1700;
        [SortOrder(It_31_sortIndex)]
        [DisplayName(It_31_displayName)]
        public virtual ushort It_31 {
            get => GetData<ushort>(70);
            set {
                if (GetData<ushort>(70) == value) return;
                SetData(70, value, nameof(It_31));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_31));
            }
        }

        public const string It_32_displayName = "It 32";
        public const int It_32_sortIndex = 1750;
        [SortOrder(It_32_sortIndex)]
        [DisplayName(It_32_displayName)]
        public virtual ushort It_32 {
            get => GetData<ushort>(72);
            set {
                if (GetData<ushort>(72) == value) return;
                SetData(72, value, nameof(It_32));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_32));
            }
        }

        public const string It_33_displayName = "It 33";
        public const int It_33_sortIndex = 1800;
        [SortOrder(It_33_sortIndex)]
        [DisplayName(It_33_displayName)]
        public virtual ushort It_33 {
            get => GetData<ushort>(74);
            set {
                if (GetData<ushort>(74) == value) return;
                SetData(74, value, nameof(It_33));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_33));
            }
        }

        public const string It_34_displayName = "It 34";
        public const int It_34_sortIndex = 1850;
        [SortOrder(It_34_sortIndex)]
        [DisplayName(It_34_displayName)]
        public virtual ushort It_34 {
            get => GetData<ushort>(76);
            set {
                if (GetData<ushort>(76) == value) return;
                SetData(76, value, nameof(It_34));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_34));
            }
        }

        public const string It_35_displayName = "It 35";
        public const int It_35_sortIndex = 1900;
        [SortOrder(It_35_sortIndex)]
        [DisplayName(It_35_displayName)]
        public virtual ushort It_35 {
            get => GetData<ushort>(78);
            set {
                if (GetData<ushort>(78) == value) return;
                SetData(78, value, nameof(It_35));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_35));
            }
        }

        public const string It_36_displayName = "It 36";
        public const int It_36_sortIndex = 1950;
        [SortOrder(It_36_sortIndex)]
        [DisplayName(It_36_displayName)]
        public virtual ushort It_36 {
            get => GetData<ushort>(80);
            set {
                if (GetData<ushort>(80) == value) return;
                SetData(80, value, nameof(It_36));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_36));
            }
        }

        public const string It_37_displayName = "It 37";
        public const int It_37_sortIndex = 2000;
        [SortOrder(It_37_sortIndex)]
        [DisplayName(It_37_displayName)]
        public virtual ushort It_37 {
            get => GetData<ushort>(82);
            set {
                if (GetData<ushort>(82) == value) return;
                SetData(82, value, nameof(It_37));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_37));
            }
        }

        public const string It_38_displayName = "It 38";
        public const int It_38_sortIndex = 2050;
        [SortOrder(It_38_sortIndex)]
        [DisplayName(It_38_displayName)]
        public virtual ushort It_38 {
            get => GetData<ushort>(84);
            set {
                if (GetData<ushort>(84) == value) return;
                SetData(84, value, nameof(It_38));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_38));
            }
        }

        public const string It_39_displayName = "It 39";
        public const int It_39_sortIndex = 2100;
        [SortOrder(It_39_sortIndex)]
        [DisplayName(It_39_displayName)]
        public virtual ushort It_39 {
            get => GetData<ushort>(86);
            set {
                if (GetData<ushort>(86) == value) return;
                SetData(86, value, nameof(It_39));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_39));
            }
        }

        public const string It_40_displayName = "It 40";
        public const int It_40_sortIndex = 2150;
        [SortOrder(It_40_sortIndex)]
        [DisplayName(It_40_displayName)]
        public virtual ushort It_40 {
            get => GetData<ushort>(88);
            set {
                if (GetData<ushort>(88) == value) return;
                SetData(88, value, nameof(It_40));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_40));
            }
        }

        public const string It_41_displayName = "It 41";
        public const int It_41_sortIndex = 2200;
        [SortOrder(It_41_sortIndex)]
        [DisplayName(It_41_displayName)]
        public virtual ushort It_41 {
            get => GetData<ushort>(90);
            set {
                if (GetData<ushort>(90) == value) return;
                SetData(90, value, nameof(It_41));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_41));
            }
        }

        public const string It_42_displayName = "It 42";
        public const int It_42_sortIndex = 2250;
        [SortOrder(It_42_sortIndex)]
        [DisplayName(It_42_displayName)]
        public virtual ushort It_42 {
            get => GetData<ushort>(92);
            set {
                if (GetData<ushort>(92) == value) return;
                SetData(92, value, nameof(It_42));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_42));
            }
        }

        public const string It_43_displayName = "It 43";
        public const int It_43_sortIndex = 2300;
        [SortOrder(It_43_sortIndex)]
        [DisplayName(It_43_displayName)]
        public virtual ushort It_43 {
            get => GetData<ushort>(94);
            set {
                if (GetData<ushort>(94) == value) return;
                SetData(94, value, nameof(It_43));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_43));
            }
        }

        public const string It_44_displayName = "It 44";
        public const int It_44_sortIndex = 2350;
        [SortOrder(It_44_sortIndex)]
        [DisplayName(It_44_displayName)]
        public virtual ushort It_44 {
            get => GetData<ushort>(96);
            set {
                if (GetData<ushort>(96) == value) return;
                SetData(96, value, nameof(It_44));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_44));
            }
        }

        public const string It_45_displayName = "It 45";
        public const int It_45_sortIndex = 2400;
        [SortOrder(It_45_sortIndex)]
        [DisplayName(It_45_displayName)]
        public virtual ushort It_45 {
            get => GetData<ushort>(98);
            set {
                if (GetData<ushort>(98) == value) return;
                SetData(98, value, nameof(It_45));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_45));
            }
        }

        public const string It_46_displayName = "It 46";
        public const int It_46_sortIndex = 2450;
        [SortOrder(It_46_sortIndex)]
        [DisplayName(It_46_displayName)]
        public virtual ushort It_46 {
            get => GetData<ushort>(100);
            set {
                if (GetData<ushort>(100) == value) return;
                SetData(100, value, nameof(It_46));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_46));
            }
        }

        public const string It_47_displayName = "It 47";
        public const int It_47_sortIndex = 2500;
        [SortOrder(It_47_sortIndex)]
        [DisplayName(It_47_displayName)]
        public virtual ushort It_47 {
            get => GetData<ushort>(102);
            set {
                if (GetData<ushort>(102) == value) return;
                SetData(102, value, nameof(It_47));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_47));
            }
        }

        public const string It_48_displayName = "It 48";
        public const int It_48_sortIndex = 2550;
        [SortOrder(It_48_sortIndex)]
        [DisplayName(It_48_displayName)]
        public virtual ushort It_48 {
            get => GetData<ushort>(104);
            set {
                if (GetData<ushort>(104) == value) return;
                SetData(104, value, nameof(It_48));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_48));
            }
        }

        public const string It_49_displayName = "It 49";
        public const int It_49_sortIndex = 2600;
        [SortOrder(It_49_sortIndex)]
        [DisplayName(It_49_displayName)]
        public virtual ushort It_49 {
            get => GetData<ushort>(106);
            set {
                if (GetData<ushort>(106) == value) return;
                SetData(106, value, nameof(It_49));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_49));
            }
        }

        public const string It_50_displayName = "It 50";
        public const int It_50_sortIndex = 2650;
        [SortOrder(It_50_sortIndex)]
        [DisplayName(It_50_displayName)]
        public virtual ushort It_50 {
            get => GetData<ushort>(108);
            set {
                if (GetData<ushort>(108) == value) return;
                SetData(108, value, nameof(It_50));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_50));
            }
        }

        public const string It_51_displayName = "It 51";
        public const int It_51_sortIndex = 2700;
        [SortOrder(It_51_sortIndex)]
        [DisplayName(It_51_displayName)]
        public virtual ushort It_51 {
            get => GetData<ushort>(110);
            set {
                if (GetData<ushort>(110) == value) return;
                SetData(110, value, nameof(It_51));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_51));
            }
        }

        public const string It_52_displayName = "It 52";
        public const int It_52_sortIndex = 2750;
        [SortOrder(It_52_sortIndex)]
        [DisplayName(It_52_displayName)]
        public virtual ushort It_52 {
            get => GetData<ushort>(112);
            set {
                if (GetData<ushort>(112) == value) return;
                SetData(112, value, nameof(It_52));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_52));
            }
        }

        public const string It_53_displayName = "It 53";
        public const int It_53_sortIndex = 2800;
        [SortOrder(It_53_sortIndex)]
        [DisplayName(It_53_displayName)]
        public virtual ushort It_53 {
            get => GetData<ushort>(114);
            set {
                if (GetData<ushort>(114) == value) return;
                SetData(114, value, nameof(It_53));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_53));
            }
        }

        public const string It_54_displayName = "It 54";
        public const int It_54_sortIndex = 2850;
        [SortOrder(It_54_sortIndex)]
        [DisplayName(It_54_displayName)]
        public virtual ushort It_54 {
            get => GetData<ushort>(116);
            set {
                if (GetData<ushort>(116) == value) return;
                SetData(116, value, nameof(It_54));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_54));
            }
        }

        public const string It_55_displayName = "It 55";
        public const int It_55_sortIndex = 2900;
        [SortOrder(It_55_sortIndex)]
        [DisplayName(It_55_displayName)]
        public virtual ushort It_55 {
            get => GetData<ushort>(118);
            set {
                if (GetData<ushort>(118) == value) return;
                SetData(118, value, nameof(It_55));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_55));
            }
        }

        public const string It_56_displayName = "It 56";
        public const int It_56_sortIndex = 2950;
        [SortOrder(It_56_sortIndex)]
        [DisplayName(It_56_displayName)]
        public virtual ushort It_56 {
            get => GetData<ushort>(120);
            set {
                if (GetData<ushort>(120) == value) return;
                SetData(120, value, nameof(It_56));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_56));
            }
        }

        public const string It_57_displayName = "It 57";
        public const int It_57_sortIndex = 3000;
        [SortOrder(It_57_sortIndex)]
        [DisplayName(It_57_displayName)]
        public virtual ushort It_57 {
            get => GetData<ushort>(122);
            set {
                if (GetData<ushort>(122) == value) return;
                SetData(122, value, nameof(It_57));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_57));
            }
        }

        public const string It_58_displayName = "It 58";
        public const int It_58_sortIndex = 3050;
        [SortOrder(It_58_sortIndex)]
        [DisplayName(It_58_displayName)]
        public virtual ushort It_58 {
            get => GetData<ushort>(124);
            set {
                if (GetData<ushort>(124) == value) return;
                SetData(124, value, nameof(It_58));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_58));
            }
        }

        public const string It_59_displayName = "It 59";
        public const int It_59_sortIndex = 3100;
        [SortOrder(It_59_sortIndex)]
        [DisplayName(It_59_displayName)]
        public virtual ushort It_59 {
            get => GetData<ushort>(126);
            set {
                if (GetData<ushort>(126) == value) return;
                SetData(126, value, nameof(It_59));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_59));
            }
        }

        public const string It_60_displayName = "It 60";
        public const int It_60_sortIndex = 3150;
        [SortOrder(It_60_sortIndex)]
        [DisplayName(It_60_displayName)]
        public virtual ushort It_60 {
            get => GetData<ushort>(128);
            set {
                if (GetData<ushort>(128) == value) return;
                SetData(128, value, nameof(It_60));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_60));
            }
        }

        public const string It_61_displayName = "It 61";
        public const int It_61_sortIndex = 3200;
        [SortOrder(It_61_sortIndex)]
        [DisplayName(It_61_displayName)]
        public virtual ushort It_61 {
            get => GetData<ushort>(130);
            set {
                if (GetData<ushort>(130) == value) return;
                SetData(130, value, nameof(It_61));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_61));
            }
        }

        public const string It_62_displayName = "It 62";
        public const int It_62_sortIndex = 3250;
        [SortOrder(It_62_sortIndex)]
        [DisplayName(It_62_displayName)]
        public virtual ushort It_62 {
            get => GetData<ushort>(132);
            set {
                if (GetData<ushort>(132) == value) return;
                SetData(132, value, nameof(It_62));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_62));
            }
        }

        public const string It_63_displayName = "It 63";
        public const int It_63_sortIndex = 3300;
        [SortOrder(It_63_sortIndex)]
        [DisplayName(It_63_displayName)]
        public virtual ushort It_63 {
            get => GetData<ushort>(134);
            set {
                if (GetData<ushort>(134) == value) return;
                SetData(134, value, nameof(It_63));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_63));
            }
        }

        public const string It_64_displayName = "It 64";
        public const int It_64_sortIndex = 3350;
        [SortOrder(It_64_sortIndex)]
        [DisplayName(It_64_displayName)]
        public virtual ushort It_64 {
            get => GetData<ushort>(136);
            set {
                if (GetData<ushort>(136) == value) return;
                SetData(136, value, nameof(It_64));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_64));
            }
        }

        public const string It_65_displayName = "It 65";
        public const int It_65_sortIndex = 3400;
        [SortOrder(It_65_sortIndex)]
        [DisplayName(It_65_displayName)]
        public virtual ushort It_65 {
            get => GetData<ushort>(138);
            set {
                if (GetData<ushort>(138) == value) return;
                SetData(138, value, nameof(It_65));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_65));
            }
        }

        public const string It_66_displayName = "It 66";
        public const int It_66_sortIndex = 3450;
        [SortOrder(It_66_sortIndex)]
        [DisplayName(It_66_displayName)]
        public virtual ushort It_66 {
            get => GetData<ushort>(140);
            set {
                if (GetData<ushort>(140) == value) return;
                SetData(140, value, nameof(It_66));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_66));
            }
        }

        public const string It_67_displayName = "It 67";
        public const int It_67_sortIndex = 3500;
        [SortOrder(It_67_sortIndex)]
        [DisplayName(It_67_displayName)]
        public virtual ushort It_67 {
            get => GetData<ushort>(142);
            set {
                if (GetData<ushort>(142) == value) return;
                SetData(142, value, nameof(It_67));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_67));
            }
        }

        public const string It_68_displayName = "It 68";
        public const int It_68_sortIndex = 3550;
        [SortOrder(It_68_sortIndex)]
        [DisplayName(It_68_displayName)]
        public virtual ushort It_68 {
            get => GetData<ushort>(144);
            set {
                if (GetData<ushort>(144) == value) return;
                SetData(144, value, nameof(It_68));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_68));
            }
        }

        public const string It_69_displayName = "It 69";
        public const int It_69_sortIndex = 3600;
        [SortOrder(It_69_sortIndex)]
        [DisplayName(It_69_displayName)]
        public virtual ushort It_69 {
            get => GetData<ushort>(146);
            set {
                if (GetData<ushort>(146) == value) return;
                SetData(146, value, nameof(It_69));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_69));
            }
        }

        public const string It_70_displayName = "It 70";
        public const int It_70_sortIndex = 3650;
        [SortOrder(It_70_sortIndex)]
        [DisplayName(It_70_displayName)]
        public virtual ushort It_70 {
            get => GetData<ushort>(148);
            set {
                if (GetData<ushort>(148) == value) return;
                SetData(148, value, nameof(It_70));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_70));
            }
        }

        public const string It_71_displayName = "It 71";
        public const int It_71_sortIndex = 3700;
        [SortOrder(It_71_sortIndex)]
        [DisplayName(It_71_displayName)]
        public virtual ushort It_71 {
            get => GetData<ushort>(150);
            set {
                if (GetData<ushort>(150) == value) return;
                SetData(150, value, nameof(It_71));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_71));
            }
        }

        public const string It_72_displayName = "It 72";
        public const int It_72_sortIndex = 3750;
        [SortOrder(It_72_sortIndex)]
        [DisplayName(It_72_displayName)]
        public virtual ushort It_72 {
            get => GetData<ushort>(152);
            set {
                if (GetData<ushort>(152) == value) return;
                SetData(152, value, nameof(It_72));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_72));
            }
        }

        public const string It_73_displayName = "It 73";
        public const int It_73_sortIndex = 3800;
        [SortOrder(It_73_sortIndex)]
        [DisplayName(It_73_displayName)]
        public virtual ushort It_73 {
            get => GetData<ushort>(154);
            set {
                if (GetData<ushort>(154) == value) return;
                SetData(154, value, nameof(It_73));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_73));
            }
        }

        public const string It_74_displayName = "It 74";
        public const int It_74_sortIndex = 3850;
        [SortOrder(It_74_sortIndex)]
        [DisplayName(It_74_displayName)]
        public virtual ushort It_74 {
            get => GetData<ushort>(156);
            set {
                if (GetData<ushort>(156) == value) return;
                SetData(156, value, nameof(It_74));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_74));
            }
        }

        public const string It_75_displayName = "It 75";
        public const int It_75_sortIndex = 3900;
        [SortOrder(It_75_sortIndex)]
        [DisplayName(It_75_displayName)]
        public virtual ushort It_75 {
            get => GetData<ushort>(158);
            set {
                if (GetData<ushort>(158) == value) return;
                SetData(158, value, nameof(It_75));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_75));
            }
        }

        public const string It_76_displayName = "It 76";
        public const int It_76_sortIndex = 3950;
        [SortOrder(It_76_sortIndex)]
        [DisplayName(It_76_displayName)]
        public virtual ushort It_76 {
            get => GetData<ushort>(160);
            set {
                if (GetData<ushort>(160) == value) return;
                SetData(160, value, nameof(It_76));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_76));
            }
        }

        public const string It_77_displayName = "It 77";
        public const int It_77_sortIndex = 4000;
        [SortOrder(It_77_sortIndex)]
        [DisplayName(It_77_displayName)]
        public virtual ushort It_77 {
            get => GetData<ushort>(162);
            set {
                if (GetData<ushort>(162) == value) return;
                SetData(162, value, nameof(It_77));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_77));
            }
        }

        public const string It_78_displayName = "It 78";
        public const int It_78_sortIndex = 4050;
        [SortOrder(It_78_sortIndex)]
        [DisplayName(It_78_displayName)]
        public virtual ushort It_78 {
            get => GetData<ushort>(164);
            set {
                if (GetData<ushort>(164) == value) return;
                SetData(164, value, nameof(It_78));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_78));
            }
        }

        public const string It_79_displayName = "It 79";
        public const int It_79_sortIndex = 4100;
        [SortOrder(It_79_sortIndex)]
        [DisplayName(It_79_displayName)]
        public virtual ushort It_79 {
            get => GetData<ushort>(166);
            set {
                if (GetData<ushort>(166) == value) return;
                SetData(166, value, nameof(It_79));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_79));
            }
        }

        public const string It_80_displayName = "It 80";
        public const int It_80_sortIndex = 4150;
        [SortOrder(It_80_sortIndex)]
        [DisplayName(It_80_displayName)]
        public virtual ushort It_80 {
            get => GetData<ushort>(168);
            set {
                if (GetData<ushort>(168) == value) return;
                SetData(168, value, nameof(It_80));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_80));
            }
        }

        public const string It_81_displayName = "It 81";
        public const int It_81_sortIndex = 4200;
        [SortOrder(It_81_sortIndex)]
        [DisplayName(It_81_displayName)]
        public virtual ushort It_81 {
            get => GetData<ushort>(170);
            set {
                if (GetData<ushort>(170) == value) return;
                SetData(170, value, nameof(It_81));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_81));
            }
        }

        public const string It_82_displayName = "It 82";
        public const int It_82_sortIndex = 4250;
        [SortOrder(It_82_sortIndex)]
        [DisplayName(It_82_displayName)]
        public virtual ushort It_82 {
            get => GetData<ushort>(172);
            set {
                if (GetData<ushort>(172) == value) return;
                SetData(172, value, nameof(It_82));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_82));
            }
        }

        public const string It_83_displayName = "It 83";
        public const int It_83_sortIndex = 4300;
        [SortOrder(It_83_sortIndex)]
        [DisplayName(It_83_displayName)]
        public virtual ushort It_83 {
            get => GetData<ushort>(174);
            set {
                if (GetData<ushort>(174) == value) return;
                SetData(174, value, nameof(It_83));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_83));
            }
        }

        public const string It_84_displayName = "It 84";
        public const int It_84_sortIndex = 4350;
        [SortOrder(It_84_sortIndex)]
        [DisplayName(It_84_displayName)]
        public virtual ushort It_84 {
            get => GetData<ushort>(176);
            set {
                if (GetData<ushort>(176) == value) return;
                SetData(176, value, nameof(It_84));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_84));
            }
        }

        public const string It_85_displayName = "It 85";
        public const int It_85_sortIndex = 4400;
        [SortOrder(It_85_sortIndex)]
        [DisplayName(It_85_displayName)]
        public virtual ushort It_85 {
            get => GetData<ushort>(178);
            set {
                if (GetData<ushort>(178) == value) return;
                SetData(178, value, nameof(It_85));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_85));
            }
        }

        public const string It_86_displayName = "It 86";
        public const int It_86_sortIndex = 4450;
        [SortOrder(It_86_sortIndex)]
        [DisplayName(It_86_displayName)]
        public virtual ushort It_86 {
            get => GetData<ushort>(180);
            set {
                if (GetData<ushort>(180) == value) return;
                SetData(180, value, nameof(It_86));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_86));
            }
        }

        public const string It_87_displayName = "It 87";
        public const int It_87_sortIndex = 4500;
        [SortOrder(It_87_sortIndex)]
        [DisplayName(It_87_displayName)]
        public virtual ushort It_87 {
            get => GetData<ushort>(182);
            set {
                if (GetData<ushort>(182) == value) return;
                SetData(182, value, nameof(It_87));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_87));
            }
        }

        public const string It_88_displayName = "It 88";
        public const int It_88_sortIndex = 4550;
        [SortOrder(It_88_sortIndex)]
        [DisplayName(It_88_displayName)]
        public virtual ushort It_88 {
            get => GetData<ushort>(184);
            set {
                if (GetData<ushort>(184) == value) return;
                SetData(184, value, nameof(It_88));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_88));
            }
        }

        public const string It_89_displayName = "It 89";
        public const int It_89_sortIndex = 4600;
        [SortOrder(It_89_sortIndex)]
        [DisplayName(It_89_displayName)]
        public virtual ushort It_89 {
            get => GetData<ushort>(186);
            set {
                if (GetData<ushort>(186) == value) return;
                SetData(186, value, nameof(It_89));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_89));
            }
        }

        public const string It_90_displayName = "It 90";
        public const int It_90_sortIndex = 4650;
        [SortOrder(It_90_sortIndex)]
        [DisplayName(It_90_displayName)]
        public virtual ushort It_90 {
            get => GetData<ushort>(188);
            set {
                if (GetData<ushort>(188) == value) return;
                SetData(188, value, nameof(It_90));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_90));
            }
        }

        public const string It_91_displayName = "It 91";
        public const int It_91_sortIndex = 4700;
        [SortOrder(It_91_sortIndex)]
        [DisplayName(It_91_displayName)]
        public virtual ushort It_91 {
            get => GetData<ushort>(190);
            set {
                if (GetData<ushort>(190) == value) return;
                SetData(190, value, nameof(It_91));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_91));
            }
        }

        public const string It_92_displayName = "It 92";
        public const int It_92_sortIndex = 4750;
        [SortOrder(It_92_sortIndex)]
        [DisplayName(It_92_displayName)]
        public virtual ushort It_92 {
            get => GetData<ushort>(192);
            set {
                if (GetData<ushort>(192) == value) return;
                SetData(192, value, nameof(It_92));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_92));
            }
        }

        public const string It_93_displayName = "It 93";
        public const int It_93_sortIndex = 4800;
        [SortOrder(It_93_sortIndex)]
        [DisplayName(It_93_displayName)]
        public virtual ushort It_93 {
            get => GetData<ushort>(194);
            set {
                if (GetData<ushort>(194) == value) return;
                SetData(194, value, nameof(It_93));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_93));
            }
        }

        public const string It_94_displayName = "It 94";
        public const int It_94_sortIndex = 4850;
        [SortOrder(It_94_sortIndex)]
        [DisplayName(It_94_displayName)]
        public virtual ushort It_94 {
            get => GetData<ushort>(196);
            set {
                if (GetData<ushort>(196) == value) return;
                SetData(196, value, nameof(It_94));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_94));
            }
        }

        public const string It_95_displayName = "It 95";
        public const int It_95_sortIndex = 4900;
        [SortOrder(It_95_sortIndex)]
        [DisplayName(It_95_displayName)]
        public virtual ushort It_95 {
            get => GetData<ushort>(198);
            set {
                if (GetData<ushort>(198) == value) return;
                SetData(198, value, nameof(It_95));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_95));
            }
        }

        public const string It_96_displayName = "It 96";
        public const int It_96_sortIndex = 4950;
        [SortOrder(It_96_sortIndex)]
        [DisplayName(It_96_displayName)]
        public virtual ushort It_96 {
            get => GetData<ushort>(200);
            set {
                if (GetData<ushort>(200) == value) return;
                SetData(200, value, nameof(It_96));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_96));
            }
        }

        public const string It_97_displayName = "It 97";
        public const int It_97_sortIndex = 5000;
        [SortOrder(It_97_sortIndex)]
        [DisplayName(It_97_displayName)]
        public virtual ushort It_97 {
            get => GetData<ushort>(202);
            set {
                if (GetData<ushort>(202) == value) return;
                SetData(202, value, nameof(It_97));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_97));
            }
        }

        public const string It_98_displayName = "It 98";
        public const int It_98_sortIndex = 5050;
        [SortOrder(It_98_sortIndex)]
        [DisplayName(It_98_displayName)]
        public virtual ushort It_98 {
            get => GetData<ushort>(204);
            set {
                if (GetData<ushort>(204) == value) return;
                SetData(204, value, nameof(It_98));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_98));
            }
        }

        public const string It_99_displayName = "It 99";
        public const int It_99_sortIndex = 5100;
        [SortOrder(It_99_sortIndex)]
        [DisplayName(It_99_displayName)]
        public virtual ushort It_99 {
            get => GetData<ushort>(206);
            set {
                if (GetData<ushort>(206) == value) return;
                SetData(206, value, nameof(It_99));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_99));
            }
        }

        public const string It_100_displayName = "It 100";
        public const int It_100_sortIndex = 5150;
        [SortOrder(It_100_sortIndex)]
        [DisplayName(It_100_displayName)]
        public virtual ushort It_100 {
            get => GetData<ushort>(208);
            set {
                if (GetData<ushort>(208) == value) return;
                SetData(208, value, nameof(It_100));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_100));
            }
        }

        public const string It_101_displayName = "It 101";
        public const int It_101_sortIndex = 5200;
        [SortOrder(It_101_sortIndex)]
        [DisplayName(It_101_displayName)]
        public virtual ushort It_101 {
            get => GetData<ushort>(210);
            set {
                if (GetData<ushort>(210) == value) return;
                SetData(210, value, nameof(It_101));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_101));
            }
        }

        public const string It_102_displayName = "It 102";
        public const int It_102_sortIndex = 5250;
        [SortOrder(It_102_sortIndex)]
        [DisplayName(It_102_displayName)]
        public virtual ushort It_102 {
            get => GetData<ushort>(212);
            set {
                if (GetData<ushort>(212) == value) return;
                SetData(212, value, nameof(It_102));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_102));
            }
        }

        public const string It_103_displayName = "It 103";
        public const int It_103_sortIndex = 5300;
        [SortOrder(It_103_sortIndex)]
        [DisplayName(It_103_displayName)]
        public virtual ushort It_103 {
            get => GetData<ushort>(214);
            set {
                if (GetData<ushort>(214) == value) return;
                SetData(214, value, nameof(It_103));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_103));
            }
        }

        public const string It_104_displayName = "It 104";
        public const int It_104_sortIndex = 5350;
        [SortOrder(It_104_sortIndex)]
        [DisplayName(It_104_displayName)]
        public virtual ushort It_104 {
            get => GetData<ushort>(216);
            set {
                if (GetData<ushort>(216) == value) return;
                SetData(216, value, nameof(It_104));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_104));
            }
        }

        public const string It_105_displayName = "It 105";
        public const int It_105_sortIndex = 5400;
        [SortOrder(It_105_sortIndex)]
        [DisplayName(It_105_displayName)]
        public virtual ushort It_105 {
            get => GetData<ushort>(218);
            set {
                if (GetData<ushort>(218) == value) return;
                SetData(218, value, nameof(It_105));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_105));
            }
        }

        public const string It_106_displayName = "It 106";
        public const int It_106_sortIndex = 5450;
        [SortOrder(It_106_sortIndex)]
        [DisplayName(It_106_displayName)]
        public virtual ushort It_106 {
            get => GetData<ushort>(220);
            set {
                if (GetData<ushort>(220) == value) return;
                SetData(220, value, nameof(It_106));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_106));
            }
        }

        public const string It_107_displayName = "It 107";
        public const int It_107_sortIndex = 5500;
        [SortOrder(It_107_sortIndex)]
        [DisplayName(It_107_displayName)]
        public virtual ushort It_107 {
            get => GetData<ushort>(222);
            set {
                if (GetData<ushort>(222) == value) return;
                SetData(222, value, nameof(It_107));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_107));
            }
        }

        public const string It_108_displayName = "It 108";
        public const int It_108_sortIndex = 5550;
        [SortOrder(It_108_sortIndex)]
        [DisplayName(It_108_displayName)]
        public virtual ushort It_108 {
            get => GetData<ushort>(224);
            set {
                if (GetData<ushort>(224) == value) return;
                SetData(224, value, nameof(It_108));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_108));
            }
        }

        public const string It_109_displayName = "It 109";
        public const int It_109_sortIndex = 5600;
        [SortOrder(It_109_sortIndex)]
        [DisplayName(It_109_displayName)]
        public virtual ushort It_109 {
            get => GetData<ushort>(226);
            set {
                if (GetData<ushort>(226) == value) return;
                SetData(226, value, nameof(It_109));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_109));
            }
        }

        public const string It_110_displayName = "It 110";
        public const int It_110_sortIndex = 5650;
        [SortOrder(It_110_sortIndex)]
        [DisplayName(It_110_displayName)]
        public virtual ushort It_110 {
            get => GetData<ushort>(228);
            set {
                if (GetData<ushort>(228) == value) return;
                SetData(228, value, nameof(It_110));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_110));
            }
        }

        public const string It_111_displayName = "It 111";
        public const int It_111_sortIndex = 5700;
        [SortOrder(It_111_sortIndex)]
        [DisplayName(It_111_displayName)]
        public virtual ushort It_111 {
            get => GetData<ushort>(230);
            set {
                if (GetData<ushort>(230) == value) return;
                SetData(230, value, nameof(It_111));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_111));
            }
        }

        public const string It_112_displayName = "It 112";
        public const int It_112_sortIndex = 5750;
        [SortOrder(It_112_sortIndex)]
        [DisplayName(It_112_displayName)]
        public virtual ushort It_112 {
            get => GetData<ushort>(232);
            set {
                if (GetData<ushort>(232) == value) return;
                SetData(232, value, nameof(It_112));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_112));
            }
        }

        public const string It_113_displayName = "It 113";
        public const int It_113_sortIndex = 5800;
        [SortOrder(It_113_sortIndex)]
        [DisplayName(It_113_displayName)]
        public virtual ushort It_113 {
            get => GetData<ushort>(234);
            set {
                if (GetData<ushort>(234) == value) return;
                SetData(234, value, nameof(It_113));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_113));
            }
        }

        public const string It_114_displayName = "It 114";
        public const int It_114_sortIndex = 5850;
        [SortOrder(It_114_sortIndex)]
        [DisplayName(It_114_displayName)]
        public virtual ushort It_114 {
            get => GetData<ushort>(236);
            set {
                if (GetData<ushort>(236) == value) return;
                SetData(236, value, nameof(It_114));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_114));
            }
        }

        public const string It_115_displayName = "It 115";
        public const int It_115_sortIndex = 5900;
        [SortOrder(It_115_sortIndex)]
        [DisplayName(It_115_displayName)]
        public virtual ushort It_115 {
            get => GetData<ushort>(238);
            set {
                if (GetData<ushort>(238) == value) return;
                SetData(238, value, nameof(It_115));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_115));
            }
        }

        public const string It_116_displayName = "It 116";
        public const int It_116_sortIndex = 5950;
        [SortOrder(It_116_sortIndex)]
        [DisplayName(It_116_displayName)]
        public virtual ushort It_116 {
            get => GetData<ushort>(240);
            set {
                if (GetData<ushort>(240) == value) return;
                SetData(240, value, nameof(It_116));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_116));
            }
        }

        public const string It_117_displayName = "It 117";
        public const int It_117_sortIndex = 6000;
        [SortOrder(It_117_sortIndex)]
        [DisplayName(It_117_displayName)]
        public virtual ushort It_117 {
            get => GetData<ushort>(242);
            set {
                if (GetData<ushort>(242) == value) return;
                SetData(242, value, nameof(It_117));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_117));
            }
        }

        public const string It_118_displayName = "It 118";
        public const int It_118_sortIndex = 6050;
        [SortOrder(It_118_sortIndex)]
        [DisplayName(It_118_displayName)]
        public virtual ushort It_118 {
            get => GetData<ushort>(244);
            set {
                if (GetData<ushort>(244) == value) return;
                SetData(244, value, nameof(It_118));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_118));
            }
        }

        public const string It_119_displayName = "It 119";
        public const int It_119_sortIndex = 6100;
        [SortOrder(It_119_sortIndex)]
        [DisplayName(It_119_displayName)]
        public virtual ushort It_119 {
            get => GetData<ushort>(246);
            set {
                if (GetData<ushort>(246) == value) return;
                SetData(246, value, nameof(It_119));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_119));
            }
        }

        public const string It_120_displayName = "It 120";
        public const int It_120_sortIndex = 6150;
        [SortOrder(It_120_sortIndex)]
        [DisplayName(It_120_displayName)]
        public virtual ushort It_120 {
            get => GetData<ushort>(248);
            set {
                if (GetData<ushort>(248) == value) return;
                SetData(248, value, nameof(It_120));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_120));
            }
        }

        public const string It_121_displayName = "It 121";
        public const int It_121_sortIndex = 6200;
        [SortOrder(It_121_sortIndex)]
        [DisplayName(It_121_displayName)]
        public virtual ushort It_121 {
            get => GetData<ushort>(250);
            set {
                if (GetData<ushort>(250) == value) return;
                SetData(250, value, nameof(It_121));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_121));
            }
        }

        public const string It_122_displayName = "It 122";
        public const int It_122_sortIndex = 6250;
        [SortOrder(It_122_sortIndex)]
        [DisplayName(It_122_displayName)]
        public virtual ushort It_122 {
            get => GetData<ushort>(252);
            set {
                if (GetData<ushort>(252) == value) return;
                SetData(252, value, nameof(It_122));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_122));
            }
        }

        public const string It_123_displayName = "It 123";
        public const int It_123_sortIndex = 6300;
        [SortOrder(It_123_sortIndex)]
        [DisplayName(It_123_displayName)]
        public virtual ushort It_123 {
            get => GetData<ushort>(254);
            set {
                if (GetData<ushort>(254) == value) return;
                SetData(254, value, nameof(It_123));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_123));
            }
        }

        public const string It_124_displayName = "It 124";
        public const int It_124_sortIndex = 6350;
        [SortOrder(It_124_sortIndex)]
        [DisplayName(It_124_displayName)]
        public virtual ushort It_124 {
            get => GetData<ushort>(256);
            set {
                if (GetData<ushort>(256) == value) return;
                SetData(256, value, nameof(It_124));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_124));
            }
        }

        public const string It_125_displayName = "It 125";
        public const int It_125_sortIndex = 6400;
        [SortOrder(It_125_sortIndex)]
        [DisplayName(It_125_displayName)]
        public virtual ushort It_125 {
            get => GetData<ushort>(258);
            set {
                if (GetData<ushort>(258) == value) return;
                SetData(258, value, nameof(It_125));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_125));
            }
        }

        public const string It_126_displayName = "It 126";
        public const int It_126_sortIndex = 6450;
        [SortOrder(It_126_sortIndex)]
        [DisplayName(It_126_displayName)]
        public virtual ushort It_126 {
            get => GetData<ushort>(260);
            set {
                if (GetData<ushort>(260) == value) return;
                SetData(260, value, nameof(It_126));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_126));
            }
        }

        public const string It_127_displayName = "It 127";
        public const int It_127_sortIndex = 6500;
        [SortOrder(It_127_sortIndex)]
        [DisplayName(It_127_displayName)]
        public virtual ushort It_127 {
            get => GetData<ushort>(262);
            set {
                if (GetData<ushort>(262) == value) return;
                SetData(262, value, nameof(It_127));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_127));
            }
        }

        public const string It_128_displayName = "It 128";
        public const int It_128_sortIndex = 6550;
        [SortOrder(It_128_sortIndex)]
        [DisplayName(It_128_displayName)]
        public virtual ushort It_128 {
            get => GetData<ushort>(264);
            set {
                if (GetData<ushort>(264) == value) return;
                SetData(264, value, nameof(It_128));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_128));
            }
        }

        public const string It_129_displayName = "It 129";
        public const int It_129_sortIndex = 6600;
        [SortOrder(It_129_sortIndex)]
        [DisplayName(It_129_displayName)]
        public virtual ushort It_129 {
            get => GetData<ushort>(266);
            set {
                if (GetData<ushort>(266) == value) return;
                SetData(266, value, nameof(It_129));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_129));
            }
        }

        public const string It_130_displayName = "It 130";
        public const int It_130_sortIndex = 6650;
        [SortOrder(It_130_sortIndex)]
        [DisplayName(It_130_displayName)]
        public virtual ushort It_130 {
            get => GetData<ushort>(268);
            set {
                if (GetData<ushort>(268) == value) return;
                SetData(268, value, nameof(It_130));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_130));
            }
        }

        public const string It_131_displayName = "It 131";
        public const int It_131_sortIndex = 6700;
        [SortOrder(It_131_sortIndex)]
        [DisplayName(It_131_displayName)]
        public virtual ushort It_131 {
            get => GetData<ushort>(270);
            set {
                if (GetData<ushort>(270) == value) return;
                SetData(270, value, nameof(It_131));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_131));
            }
        }

        public const string It_132_displayName = "It 132";
        public const int It_132_sortIndex = 6750;
        [SortOrder(It_132_sortIndex)]
        [DisplayName(It_132_displayName)]
        public virtual ushort It_132 {
            get => GetData<ushort>(272);
            set {
                if (GetData<ushort>(272) == value) return;
                SetData(272, value, nameof(It_132));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_132));
            }
        }

        public const string It_133_displayName = "It 133";
        public const int It_133_sortIndex = 6800;
        [SortOrder(It_133_sortIndex)]
        [DisplayName(It_133_displayName)]
        public virtual ushort It_133 {
            get => GetData<ushort>(274);
            set {
                if (GetData<ushort>(274) == value) return;
                SetData(274, value, nameof(It_133));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_133));
            }
        }

        public const string It_134_displayName = "It 134";
        public const int It_134_sortIndex = 6850;
        [SortOrder(It_134_sortIndex)]
        [DisplayName(It_134_displayName)]
        public virtual ushort It_134 {
            get => GetData<ushort>(276);
            set {
                if (GetData<ushort>(276) == value) return;
                SetData(276, value, nameof(It_134));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_134));
            }
        }

        public const string It_135_displayName = "It 135";
        public const int It_135_sortIndex = 6900;
        [SortOrder(It_135_sortIndex)]
        [DisplayName(It_135_displayName)]
        public virtual ushort It_135 {
            get => GetData<ushort>(278);
            set {
                if (GetData<ushort>(278) == value) return;
                SetData(278, value, nameof(It_135));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_135));
            }
        }

        public const string It_136_displayName = "It 136";
        public const int It_136_sortIndex = 6950;
        [SortOrder(It_136_sortIndex)]
        [DisplayName(It_136_displayName)]
        public virtual ushort It_136 {
            get => GetData<ushort>(280);
            set {
                if (GetData<ushort>(280) == value) return;
                SetData(280, value, nameof(It_136));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_136));
            }
        }

        public const string It_137_displayName = "It 137";
        public const int It_137_sortIndex = 7000;
        [SortOrder(It_137_sortIndex)]
        [DisplayName(It_137_displayName)]
        public virtual ushort It_137 {
            get => GetData<ushort>(282);
            set {
                if (GetData<ushort>(282) == value) return;
                SetData(282, value, nameof(It_137));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_137));
            }
        }

        public const string It_138_displayName = "It 138";
        public const int It_138_sortIndex = 7050;
        [SortOrder(It_138_sortIndex)]
        [DisplayName(It_138_displayName)]
        public virtual ushort It_138 {
            get => GetData<ushort>(284);
            set {
                if (GetData<ushort>(284) == value) return;
                SetData(284, value, nameof(It_138));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_138));
            }
        }

        public const string It_139_displayName = "It 139";
        public const int It_139_sortIndex = 7100;
        [SortOrder(It_139_sortIndex)]
        [DisplayName(It_139_displayName)]
        public virtual ushort It_139 {
            get => GetData<ushort>(286);
            set {
                if (GetData<ushort>(286) == value) return;
                SetData(286, value, nameof(It_139));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_139));
            }
        }

        public const string It_140_displayName = "It 140";
        public const int It_140_sortIndex = 7150;
        [SortOrder(It_140_sortIndex)]
        [DisplayName(It_140_displayName)]
        public virtual ushort It_140 {
            get => GetData<ushort>(288);
            set {
                if (GetData<ushort>(288) == value) return;
                SetData(288, value, nameof(It_140));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_140));
            }
        }

        public const string It_141_displayName = "It 141";
        public const int It_141_sortIndex = 7200;
        [SortOrder(It_141_sortIndex)]
        [DisplayName(It_141_displayName)]
        public virtual ushort It_141 {
            get => GetData<ushort>(290);
            set {
                if (GetData<ushort>(290) == value) return;
                SetData(290, value, nameof(It_141));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_141));
            }
        }

        public const string It_142_displayName = "It 142";
        public const int It_142_sortIndex = 7250;
        [SortOrder(It_142_sortIndex)]
        [DisplayName(It_142_displayName)]
        public virtual ushort It_142 {
            get => GetData<ushort>(292);
            set {
                if (GetData<ushort>(292) == value) return;
                SetData(292, value, nameof(It_142));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_142));
            }
        }

        public const string It_143_displayName = "It 143";
        public const int It_143_sortIndex = 7300;
        [SortOrder(It_143_sortIndex)]
        [DisplayName(It_143_displayName)]
        public virtual ushort It_143 {
            get => GetData<ushort>(294);
            set {
                if (GetData<ushort>(294) == value) return;
                SetData(294, value, nameof(It_143));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_143));
            }
        }

        public const string It_144_displayName = "It 144";
        public const int It_144_sortIndex = 7350;
        [SortOrder(It_144_sortIndex)]
        [DisplayName(It_144_displayName)]
        public virtual ushort It_144 {
            get => GetData<ushort>(296);
            set {
                if (GetData<ushort>(296) == value) return;
                SetData(296, value, nameof(It_144));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_144));
            }
        }

        public const string It_145_displayName = "It 145";
        public const int It_145_sortIndex = 7400;
        [SortOrder(It_145_sortIndex)]
        [DisplayName(It_145_displayName)]
        public virtual ushort It_145 {
            get => GetData<ushort>(298);
            set {
                if (GetData<ushort>(298) == value) return;
                SetData(298, value, nameof(It_145));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_145));
            }
        }

        public const string It_146_displayName = "It 146";
        public const int It_146_sortIndex = 7450;
        [SortOrder(It_146_sortIndex)]
        [DisplayName(It_146_displayName)]
        public virtual ushort It_146 {
            get => GetData<ushort>(300);
            set {
                if (GetData<ushort>(300) == value) return;
                SetData(300, value, nameof(It_146));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_146));
            }
        }

        public const string It_147_displayName = "It 147";
        public const int It_147_sortIndex = 7500;
        [SortOrder(It_147_sortIndex)]
        [DisplayName(It_147_displayName)]
        public virtual ushort It_147 {
            get => GetData<ushort>(302);
            set {
                if (GetData<ushort>(302) == value) return;
                SetData(302, value, nameof(It_147));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_147));
            }
        }

        public const string It_148_displayName = "It 148";
        public const int It_148_sortIndex = 7550;
        [SortOrder(It_148_sortIndex)]
        [DisplayName(It_148_displayName)]
        public virtual ushort It_148 {
            get => GetData<ushort>(304);
            set {
                if (GetData<ushort>(304) == value) return;
                SetData(304, value, nameof(It_148));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_148));
            }
        }

        public const string It_149_displayName = "It 149";
        public const int It_149_sortIndex = 7600;
        [SortOrder(It_149_sortIndex)]
        [DisplayName(It_149_displayName)]
        public virtual ushort It_149 {
            get => GetData<ushort>(306);
            set {
                if (GetData<ushort>(306) == value) return;
                SetData(306, value, nameof(It_149));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_149));
            }
        }

        public const string It_150_displayName = "It 150";
        public const int It_150_sortIndex = 7650;
        [SortOrder(It_150_sortIndex)]
        [DisplayName(It_150_displayName)]
        public virtual ushort It_150 {
            get => GetData<ushort>(308);
            set {
                if (GetData<ushort>(308) == value) return;
                SetData(308, value, nameof(It_150));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_150));
            }
        }

        public const string It_151_displayName = "It 151";
        public const int It_151_sortIndex = 7700;
        [SortOrder(It_151_sortIndex)]
        [DisplayName(It_151_displayName)]
        public virtual ushort It_151 {
            get => GetData<ushort>(310);
            set {
                if (GetData<ushort>(310) == value) return;
                SetData(310, value, nameof(It_151));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_151));
            }
        }

        public const string It_152_displayName = "It 152";
        public const int It_152_sortIndex = 7750;
        [SortOrder(It_152_sortIndex)]
        [DisplayName(It_152_displayName)]
        public virtual ushort It_152 {
            get => GetData<ushort>(312);
            set {
                if (GetData<ushort>(312) == value) return;
                SetData(312, value, nameof(It_152));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_152));
            }
        }

        public const string It_153_displayName = "It 153";
        public const int It_153_sortIndex = 7800;
        [SortOrder(It_153_sortIndex)]
        [DisplayName(It_153_displayName)]
        public virtual ushort It_153 {
            get => GetData<ushort>(314);
            set {
                if (GetData<ushort>(314) == value) return;
                SetData(314, value, nameof(It_153));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_153));
            }
        }

        public const string It_154_displayName = "It 154";
        public const int It_154_sortIndex = 7850;
        [SortOrder(It_154_sortIndex)]
        [DisplayName(It_154_displayName)]
        public virtual ushort It_154 {
            get => GetData<ushort>(316);
            set {
                if (GetData<ushort>(316) == value) return;
                SetData(316, value, nameof(It_154));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_154));
            }
        }

        public const string It_155_displayName = "It 155";
        public const int It_155_sortIndex = 7900;
        [SortOrder(It_155_sortIndex)]
        [DisplayName(It_155_displayName)]
        public virtual ushort It_155 {
            get => GetData<ushort>(318);
            set {
                if (GetData<ushort>(318) == value) return;
                SetData(318, value, nameof(It_155));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_155));
            }
        }

        public const string It_156_displayName = "It 156";
        public const int It_156_sortIndex = 7950;
        [SortOrder(It_156_sortIndex)]
        [DisplayName(It_156_displayName)]
        public virtual ushort It_156 {
            get => GetData<ushort>(320);
            set {
                if (GetData<ushort>(320) == value) return;
                SetData(320, value, nameof(It_156));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_156));
            }
        }

        public const string It_157_displayName = "It 157";
        public const int It_157_sortIndex = 8000;
        [SortOrder(It_157_sortIndex)]
        [DisplayName(It_157_displayName)]
        public virtual ushort It_157 {
            get => GetData<ushort>(322);
            set {
                if (GetData<ushort>(322) == value) return;
                SetData(322, value, nameof(It_157));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_157));
            }
        }

        public const string It_158_displayName = "It 158";
        public const int It_158_sortIndex = 8050;
        [SortOrder(It_158_sortIndex)]
        [DisplayName(It_158_displayName)]
        public virtual ushort It_158 {
            get => GetData<ushort>(324);
            set {
                if (GetData<ushort>(324) == value) return;
                SetData(324, value, nameof(It_158));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_158));
            }
        }

        public const string It_159_displayName = "It 159";
        public const int It_159_sortIndex = 8100;
        [SortOrder(It_159_sortIndex)]
        [DisplayName(It_159_displayName)]
        public virtual ushort It_159 {
            get => GetData<ushort>(326);
            set {
                if (GetData<ushort>(326) == value) return;
                SetData(326, value, nameof(It_159));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_159));
            }
        }

        public const string It_160_displayName = "It 160";
        public const int It_160_sortIndex = 8150;
        [SortOrder(It_160_sortIndex)]
        [DisplayName(It_160_displayName)]
        public virtual ushort It_160 {
            get => GetData<ushort>(328);
            set {
                if (GetData<ushort>(328) == value) return;
                SetData(328, value, nameof(It_160));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_160));
            }
        }

        public const string It_161_displayName = "It 161";
        public const int It_161_sortIndex = 8200;
        [SortOrder(It_161_sortIndex)]
        [DisplayName(It_161_displayName)]
        public virtual ushort It_161 {
            get => GetData<ushort>(330);
            set {
                if (GetData<ushort>(330) == value) return;
                SetData(330, value, nameof(It_161));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_161));
            }
        }

        public const string It_162_displayName = "It 162";
        public const int It_162_sortIndex = 8250;
        [SortOrder(It_162_sortIndex)]
        [DisplayName(It_162_displayName)]
        public virtual ushort It_162 {
            get => GetData<ushort>(332);
            set {
                if (GetData<ushort>(332) == value) return;
                SetData(332, value, nameof(It_162));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_162));
            }
        }

        public const string It_163_displayName = "It 163";
        public const int It_163_sortIndex = 8300;
        [SortOrder(It_163_sortIndex)]
        [DisplayName(It_163_displayName)]
        public virtual ushort It_163 {
            get => GetData<ushort>(334);
            set {
                if (GetData<ushort>(334) == value) return;
                SetData(334, value, nameof(It_163));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_163));
            }
        }

        public const string It_164_displayName = "It 164";
        public const int It_164_sortIndex = 8350;
        [SortOrder(It_164_sortIndex)]
        [DisplayName(It_164_displayName)]
        public virtual ushort It_164 {
            get => GetData<ushort>(336);
            set {
                if (GetData<ushort>(336) == value) return;
                SetData(336, value, nameof(It_164));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_164));
            }
        }

        public const string It_165_displayName = "It 165";
        public const int It_165_sortIndex = 8400;
        [SortOrder(It_165_sortIndex)]
        [DisplayName(It_165_displayName)]
        public virtual ushort It_165 {
            get => GetData<ushort>(338);
            set {
                if (GetData<ushort>(338) == value) return;
                SetData(338, value, nameof(It_165));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_165));
            }
        }

        public const string It_166_displayName = "It 166";
        public const int It_166_sortIndex = 8450;
        [SortOrder(It_166_sortIndex)]
        [DisplayName(It_166_displayName)]
        public virtual ushort It_166 {
            get => GetData<ushort>(340);
            set {
                if (GetData<ushort>(340) == value) return;
                SetData(340, value, nameof(It_166));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_166));
            }
        }

        public const string It_167_displayName = "It 167";
        public const int It_167_sortIndex = 8500;
        [SortOrder(It_167_sortIndex)]
        [DisplayName(It_167_displayName)]
        public virtual ushort It_167 {
            get => GetData<ushort>(342);
            set {
                if (GetData<ushort>(342) == value) return;
                SetData(342, value, nameof(It_167));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_167));
            }
        }

        public const string It_168_displayName = "It 168";
        public const int It_168_sortIndex = 8550;
        [SortOrder(It_168_sortIndex)]
        [DisplayName(It_168_displayName)]
        public virtual ushort It_168 {
            get => GetData<ushort>(344);
            set {
                if (GetData<ushort>(344) == value) return;
                SetData(344, value, nameof(It_168));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_168));
            }
        }

        public const string It_169_displayName = "It 169";
        public const int It_169_sortIndex = 8600;
        [SortOrder(It_169_sortIndex)]
        [DisplayName(It_169_displayName)]
        public virtual ushort It_169 {
            get => GetData<ushort>(346);
            set {
                if (GetData<ushort>(346) == value) return;
                SetData(346, value, nameof(It_169));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_169));
            }
        }

        public const string It_170_displayName = "It 170";
        public const int It_170_sortIndex = 8650;
        [SortOrder(It_170_sortIndex)]
        [DisplayName(It_170_displayName)]
        public virtual ushort It_170 {
            get => GetData<ushort>(348);
            set {
                if (GetData<ushort>(348) == value) return;
                SetData(348, value, nameof(It_170));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_170));
            }
        }

        public const string It_171_displayName = "It 171";
        public const int It_171_sortIndex = 8700;
        [SortOrder(It_171_sortIndex)]
        [DisplayName(It_171_displayName)]
        public virtual ushort It_171 {
            get => GetData<ushort>(350);
            set {
                if (GetData<ushort>(350) == value) return;
                SetData(350, value, nameof(It_171));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_171));
            }
        }

        public const string It_172_displayName = "It 172";
        public const int It_172_sortIndex = 8750;
        [SortOrder(It_172_sortIndex)]
        [DisplayName(It_172_displayName)]
        public virtual ushort It_172 {
            get => GetData<ushort>(352);
            set {
                if (GetData<ushort>(352) == value) return;
                SetData(352, value, nameof(It_172));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_172));
            }
        }

        public const string It_173_displayName = "It 173";
        public const int It_173_sortIndex = 8800;
        [SortOrder(It_173_sortIndex)]
        [DisplayName(It_173_displayName)]
        public virtual ushort It_173 {
            get => GetData<ushort>(354);
            set {
                if (GetData<ushort>(354) == value) return;
                SetData(354, value, nameof(It_173));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_173));
            }
        }

        public const string It_174_displayName = "It 174";
        public const int It_174_sortIndex = 8850;
        [SortOrder(It_174_sortIndex)]
        [DisplayName(It_174_displayName)]
        public virtual ushort It_174 {
            get => GetData<ushort>(356);
            set {
                if (GetData<ushort>(356) == value) return;
                SetData(356, value, nameof(It_174));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_174));
            }
        }

        public const string It_175_displayName = "It 175";
        public const int It_175_sortIndex = 8900;
        [SortOrder(It_175_sortIndex)]
        [DisplayName(It_175_displayName)]
        public virtual ushort It_175 {
            get => GetData<ushort>(358);
            set {
                if (GetData<ushort>(358) == value) return;
                SetData(358, value, nameof(It_175));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_175));
            }
        }

        public const string It_176_displayName = "It 176";
        public const int It_176_sortIndex = 8950;
        [SortOrder(It_176_sortIndex)]
        [DisplayName(It_176_displayName)]
        public virtual ushort It_176 {
            get => GetData<ushort>(360);
            set {
                if (GetData<ushort>(360) == value) return;
                SetData(360, value, nameof(It_176));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_176));
            }
        }

        public const string It_177_displayName = "It 177";
        public const int It_177_sortIndex = 9000;
        [SortOrder(It_177_sortIndex)]
        [DisplayName(It_177_displayName)]
        public virtual ushort It_177 {
            get => GetData<ushort>(362);
            set {
                if (GetData<ushort>(362) == value) return;
                SetData(362, value, nameof(It_177));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_177));
            }
        }

        public const string It_178_displayName = "It 178";
        public const int It_178_sortIndex = 9050;
        [SortOrder(It_178_sortIndex)]
        [DisplayName(It_178_displayName)]
        public virtual ushort It_178 {
            get => GetData<ushort>(364);
            set {
                if (GetData<ushort>(364) == value) return;
                SetData(364, value, nameof(It_178));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_178));
            }
        }

        public const string It_179_displayName = "It 179";
        public const int It_179_sortIndex = 9100;
        [SortOrder(It_179_sortIndex)]
        [DisplayName(It_179_displayName)]
        public virtual ushort It_179 {
            get => GetData<ushort>(366);
            set {
                if (GetData<ushort>(366) == value) return;
                SetData(366, value, nameof(It_179));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_179));
            }
        }

        public const string It_180_displayName = "It 180";
        public const int It_180_sortIndex = 9150;
        [SortOrder(It_180_sortIndex)]
        [DisplayName(It_180_displayName)]
        public virtual ushort It_180 {
            get => GetData<ushort>(368);
            set {
                if (GetData<ushort>(368) == value) return;
                SetData(368, value, nameof(It_180));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_180));
            }
        }

        public const string It_181_displayName = "It 181";
        public const int It_181_sortIndex = 9200;
        [SortOrder(It_181_sortIndex)]
        [DisplayName(It_181_displayName)]
        public virtual ushort It_181 {
            get => GetData<ushort>(370);
            set {
                if (GetData<ushort>(370) == value) return;
                SetData(370, value, nameof(It_181));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_181));
            }
        }

        public const string It_182_displayName = "It 182";
        public const int It_182_sortIndex = 9250;
        [SortOrder(It_182_sortIndex)]
        [DisplayName(It_182_displayName)]
        public virtual ushort It_182 {
            get => GetData<ushort>(372);
            set {
                if (GetData<ushort>(372) == value) return;
                SetData(372, value, nameof(It_182));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_182));
            }
        }

        public const string It_183_displayName = "It 183";
        public const int It_183_sortIndex = 9300;
        [SortOrder(It_183_sortIndex)]
        [DisplayName(It_183_displayName)]
        public virtual ushort It_183 {
            get => GetData<ushort>(374);
            set {
                if (GetData<ushort>(374) == value) return;
                SetData(374, value, nameof(It_183));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_183));
            }
        }

        public const string It_184_displayName = "It 184";
        public const int It_184_sortIndex = 9350;
        [SortOrder(It_184_sortIndex)]
        [DisplayName(It_184_displayName)]
        public virtual ushort It_184 {
            get => GetData<ushort>(376);
            set {
                if (GetData<ushort>(376) == value) return;
                SetData(376, value, nameof(It_184));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_184));
            }
        }

        public const string It_185_displayName = "It 185";
        public const int It_185_sortIndex = 9400;
        [SortOrder(It_185_sortIndex)]
        [DisplayName(It_185_displayName)]
        public virtual ushort It_185 {
            get => GetData<ushort>(378);
            set {
                if (GetData<ushort>(378) == value) return;
                SetData(378, value, nameof(It_185));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_185));
            }
        }

        public const string It_186_displayName = "It 186";
        public const int It_186_sortIndex = 9450;
        [SortOrder(It_186_sortIndex)]
        [DisplayName(It_186_displayName)]
        public virtual ushort It_186 {
            get => GetData<ushort>(380);
            set {
                if (GetData<ushort>(380) == value) return;
                SetData(380, value, nameof(It_186));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_186));
            }
        }

        public const string It_187_displayName = "It 187";
        public const int It_187_sortIndex = 9500;
        [SortOrder(It_187_sortIndex)]
        [DisplayName(It_187_displayName)]
        public virtual ushort It_187 {
            get => GetData<ushort>(382);
            set {
                if (GetData<ushort>(382) == value) return;
                SetData(382, value, nameof(It_187));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_187));
            }
        }

        public const string It_188_displayName = "It 188";
        public const int It_188_sortIndex = 9550;
        [SortOrder(It_188_sortIndex)]
        [DisplayName(It_188_displayName)]
        public virtual ushort It_188 {
            get => GetData<ushort>(384);
            set {
                if (GetData<ushort>(384) == value) return;
                SetData(384, value, nameof(It_188));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_188));
            }
        }

        public const string It_189_displayName = "It 189";
        public const int It_189_sortIndex = 9600;
        [SortOrder(It_189_sortIndex)]
        [DisplayName(It_189_displayName)]
        public virtual ushort It_189 {
            get => GetData<ushort>(386);
            set {
                if (GetData<ushort>(386) == value) return;
                SetData(386, value, nameof(It_189));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_189));
            }
        }

        public const string It_190_displayName = "It 190";
        public const int It_190_sortIndex = 9650;
        [SortOrder(It_190_sortIndex)]
        [DisplayName(It_190_displayName)]
        public virtual ushort It_190 {
            get => GetData<ushort>(388);
            set {
                if (GetData<ushort>(388) == value) return;
                SetData(388, value, nameof(It_190));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_190));
            }
        }

        public const string It_191_displayName = "It 191";
        public const int It_191_sortIndex = 9700;
        [SortOrder(It_191_sortIndex)]
        [DisplayName(It_191_displayName)]
        public virtual ushort It_191 {
            get => GetData<ushort>(390);
            set {
                if (GetData<ushort>(390) == value) return;
                SetData(390, value, nameof(It_191));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_191));
            }
        }

        public const string It_192_displayName = "It 192";
        public const int It_192_sortIndex = 9750;
        [SortOrder(It_192_sortIndex)]
        [DisplayName(It_192_displayName)]
        public virtual ushort It_192 {
            get => GetData<ushort>(392);
            set {
                if (GetData<ushort>(392) == value) return;
                SetData(392, value, nameof(It_192));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_192));
            }
        }

        public const string It_193_displayName = "It 193";
        public const int It_193_sortIndex = 9800;
        [SortOrder(It_193_sortIndex)]
        [DisplayName(It_193_displayName)]
        public virtual ushort It_193 {
            get => GetData<ushort>(394);
            set {
                if (GetData<ushort>(394) == value) return;
                SetData(394, value, nameof(It_193));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_193));
            }
        }

        public const string It_194_displayName = "It 194";
        public const int It_194_sortIndex = 9850;
        [SortOrder(It_194_sortIndex)]
        [DisplayName(It_194_displayName)]
        public virtual ushort It_194 {
            get => GetData<ushort>(396);
            set {
                if (GetData<ushort>(396) == value) return;
                SetData(396, value, nameof(It_194));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_194));
            }
        }

        public const string It_195_displayName = "It 195";
        public const int It_195_sortIndex = 9900;
        [SortOrder(It_195_sortIndex)]
        [DisplayName(It_195_displayName)]
        public virtual ushort It_195 {
            get => GetData<ushort>(398);
            set {
                if (GetData<ushort>(398) == value) return;
                SetData(398, value, nameof(It_195));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_195));
            }
        }

        public const string It_196_displayName = "It 196";
        public const int It_196_sortIndex = 9950;
        [SortOrder(It_196_sortIndex)]
        [DisplayName(It_196_displayName)]
        public virtual ushort It_196 {
            get => GetData<ushort>(400);
            set {
                if (GetData<ushort>(400) == value) return;
                SetData(400, value, nameof(It_196));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_196));
            }
        }

        public const string It_197_displayName = "It 197";
        public const int It_197_sortIndex = 10000;
        [SortOrder(It_197_sortIndex)]
        [DisplayName(It_197_displayName)]
        public virtual ushort It_197 {
            get => GetData<ushort>(402);
            set {
                if (GetData<ushort>(402) == value) return;
                SetData(402, value, nameof(It_197));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_197));
            }
        }

        public const string It_198_displayName = "It 198";
        public const int It_198_sortIndex = 10050;
        [SortOrder(It_198_sortIndex)]
        [DisplayName(It_198_displayName)]
        public virtual ushort It_198 {
            get => GetData<ushort>(404);
            set {
                if (GetData<ushort>(404) == value) return;
                SetData(404, value, nameof(It_198));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_198));
            }
        }

        public const string It_199_displayName = "It 199";
        public const int It_199_sortIndex = 10100;
        [SortOrder(It_199_sortIndex)]
        [DisplayName(It_199_displayName)]
        public virtual ushort It_199 {
            get => GetData<ushort>(406);
            set {
                if (GetData<ushort>(406) == value) return;
                SetData(406, value, nameof(It_199));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_199));
            }
        }

        public const string It_200_displayName = "It 200";
        public const int It_200_sortIndex = 10150;
        [SortOrder(It_200_sortIndex)]
        [DisplayName(It_200_displayName)]
        public virtual ushort It_200 {
            get => GetData<ushort>(408);
            set {
                if (GetData<ushort>(408) == value) return;
                SetData(408, value, nameof(It_200));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_200));
            }
        }

        public const string It_201_displayName = "It 201";
        public const int It_201_sortIndex = 10200;
        [SortOrder(It_201_sortIndex)]
        [DisplayName(It_201_displayName)]
        public virtual ushort It_201 {
            get => GetData<ushort>(410);
            set {
                if (GetData<ushort>(410) == value) return;
                SetData(410, value, nameof(It_201));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_201));
            }
        }

        public const string It_202_displayName = "It 202";
        public const int It_202_sortIndex = 10250;
        [SortOrder(It_202_sortIndex)]
        [DisplayName(It_202_displayName)]
        public virtual ushort It_202 {
            get => GetData<ushort>(412);
            set {
                if (GetData<ushort>(412) == value) return;
                SetData(412, value, nameof(It_202));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_202));
            }
        }

        public const string It_203_displayName = "It 203";
        public const int It_203_sortIndex = 10300;
        [SortOrder(It_203_sortIndex)]
        [DisplayName(It_203_displayName)]
        public virtual ushort It_203 {
            get => GetData<ushort>(414);
            set {
                if (GetData<ushort>(414) == value) return;
                SetData(414, value, nameof(It_203));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_203));
            }
        }

        public const string It_204_displayName = "It 204";
        public const int It_204_sortIndex = 10350;
        [SortOrder(It_204_sortIndex)]
        [DisplayName(It_204_displayName)]
        public virtual ushort It_204 {
            get => GetData<ushort>(416);
            set {
                if (GetData<ushort>(416) == value) return;
                SetData(416, value, nameof(It_204));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_204));
            }
        }

        public const string It_205_displayName = "It 205";
        public const int It_205_sortIndex = 10400;
        [SortOrder(It_205_sortIndex)]
        [DisplayName(It_205_displayName)]
        public virtual ushort It_205 {
            get => GetData<ushort>(418);
            set {
                if (GetData<ushort>(418) == value) return;
                SetData(418, value, nameof(It_205));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_205));
            }
        }

        public const string It_206_displayName = "It 206";
        public const int It_206_sortIndex = 10450;
        [SortOrder(It_206_sortIndex)]
        [DisplayName(It_206_displayName)]
        public virtual ushort It_206 {
            get => GetData<ushort>(420);
            set {
                if (GetData<ushort>(420) == value) return;
                SetData(420, value, nameof(It_206));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_206));
            }
        }

        public const string It_207_displayName = "It 207";
        public const int It_207_sortIndex = 10500;
        [SortOrder(It_207_sortIndex)]
        [DisplayName(It_207_displayName)]
        public virtual ushort It_207 {
            get => GetData<ushort>(422);
            set {
                if (GetData<ushort>(422) == value) return;
                SetData(422, value, nameof(It_207));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_207));
            }
        }

        public const string It_208_displayName = "It 208";
        public const int It_208_sortIndex = 10550;
        [SortOrder(It_208_sortIndex)]
        [DisplayName(It_208_displayName)]
        public virtual ushort It_208 {
            get => GetData<ushort>(424);
            set {
                if (GetData<ushort>(424) == value) return;
                SetData(424, value, nameof(It_208));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_208));
            }
        }

        public const string It_209_displayName = "It 209";
        public const int It_209_sortIndex = 10600;
        [SortOrder(It_209_sortIndex)]
        [DisplayName(It_209_displayName)]
        public virtual ushort It_209 {
            get => GetData<ushort>(426);
            set {
                if (GetData<ushort>(426) == value) return;
                SetData(426, value, nameof(It_209));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_209));
            }
        }

        public const string It_210_displayName = "It 210";
        public const int It_210_sortIndex = 10650;
        [SortOrder(It_210_sortIndex)]
        [DisplayName(It_210_displayName)]
        public virtual ushort It_210 {
            get => GetData<ushort>(428);
            set {
                if (GetData<ushort>(428) == value) return;
                SetData(428, value, nameof(It_210));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(It_210));
            }
        }

        public const int lastSortIndex = 10700;
    }
}
using System.ComponentModel;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Items {
    public partial class MelderExchange {
        public const uint StructSize = 430;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public const string EncryptionKey = null;

        public const string Source_Item_Id_displayName = "Source Item Id";
        public const int Source_Item_Id_sortIndex = 50;
        [SortOrder(Source_Item_Id_sortIndex)]
        [DisplayName(Source_Item_Id_displayName)]
        [DataSource(DataSourceType.Items)]
        public virtual uint Source_Item_Id {
            get => GetData<uint>(0);
        }

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

        public const string Un_2_displayName = "Un 2";
        public const int Un_2_sortIndex = 150;
        [SortOrder(Un_2_sortIndex)]
        [DisplayName(Un_2_displayName)]
        public virtual ushort Un_2 {
            get => GetData<ushort>(8);
            set {
                if (GetData<ushort>(8) == value) return;
                SetData(8, value, nameof(Un_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_2));
            }
        }

        public const string Un_3_displayName = "Un 3";
        public const int Un_3_sortIndex = 200;
        [SortOrder(Un_3_sortIndex)]
        [DisplayName(Un_3_displayName)]
        public virtual ushort Un_3 {
            get => GetData<ushort>(10);
            set {
                if (GetData<ushort>(10) == value) return;
                SetData(10, value, nameof(Un_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_3));
            }
        }

        public const string Un_4_displayName = "Un 4";
        public const int Un_4_sortIndex = 250;
        [SortOrder(Un_4_sortIndex)]
        [DisplayName(Un_4_displayName)]
        public virtual ushort Un_4 {
            get => GetData<ushort>(12);
            set {
                if (GetData<ushort>(12) == value) return;
                SetData(12, value, nameof(Un_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_4));
            }
        }

        public const string Un_5_displayName = "Un 5";
        public const int Un_5_sortIndex = 300;
        [SortOrder(Un_5_sortIndex)]
        [DisplayName(Un_5_displayName)]
        public virtual ushort Un_5 {
            get => GetData<ushort>(14);
            set {
                if (GetData<ushort>(14) == value) return;
                SetData(14, value, nameof(Un_5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_5));
            }
        }

        public const string Un_6_displayName = "Un 6";
        public const int Un_6_sortIndex = 350;
        [SortOrder(Un_6_sortIndex)]
        [DisplayName(Un_6_displayName)]
        public virtual ushort Un_6 {
            get => GetData<ushort>(16);
            set {
                if (GetData<ushort>(16) == value) return;
                SetData(16, value, nameof(Un_6));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_6));
            }
        }

        public const string Un_7_displayName = "Un 7";
        public const int Un_7_sortIndex = 400;
        [SortOrder(Un_7_sortIndex)]
        [DisplayName(Un_7_displayName)]
        public virtual ushort Un_7 {
            get => GetData<ushort>(18);
            set {
                if (GetData<ushort>(18) == value) return;
                SetData(18, value, nameof(Un_7));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_7));
            }
        }

        public const string Un_8_displayName = "Un 8";
        public const int Un_8_sortIndex = 450;
        [SortOrder(Un_8_sortIndex)]
        [DisplayName(Un_8_displayName)]
        public virtual ushort Un_8 {
            get => GetData<ushort>(20);
            set {
                if (GetData<ushort>(20) == value) return;
                SetData(20, value, nameof(Un_8));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_8));
            }
        }

        public const string Un_9_displayName = "Un 9";
        public const int Un_9_sortIndex = 500;
        [SortOrder(Un_9_sortIndex)]
        [DisplayName(Un_9_displayName)]
        public virtual ushort Un_9 {
            get => GetData<ushort>(22);
            set {
                if (GetData<ushort>(22) == value) return;
                SetData(22, value, nameof(Un_9));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_9));
            }
        }

        public const string Un_10_displayName = "Un 10";
        public const int Un_10_sortIndex = 550;
        [SortOrder(Un_10_sortIndex)]
        [DisplayName(Un_10_displayName)]
        public virtual ushort Un_10 {
            get => GetData<ushort>(24);
            set {
                if (GetData<ushort>(24) == value) return;
                SetData(24, value, nameof(Un_10));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_10));
            }
        }

        public const string Un_11_displayName = "Un 11";
        public const int Un_11_sortIndex = 600;
        [SortOrder(Un_11_sortIndex)]
        [DisplayName(Un_11_displayName)]
        public virtual ushort Un_11 {
            get => GetData<ushort>(26);
            set {
                if (GetData<ushort>(26) == value) return;
                SetData(26, value, nameof(Un_11));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_11));
            }
        }

        public const string Un_12_displayName = "Un 12";
        public const int Un_12_sortIndex = 650;
        [SortOrder(Un_12_sortIndex)]
        [DisplayName(Un_12_displayName)]
        public virtual ushort Un_12 {
            get => GetData<ushort>(28);
            set {
                if (GetData<ushort>(28) == value) return;
                SetData(28, value, nameof(Un_12));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_12));
            }
        }

        public const string Un_13_displayName = "Un 13";
        public const int Un_13_sortIndex = 700;
        [SortOrder(Un_13_sortIndex)]
        [DisplayName(Un_13_displayName)]
        public virtual ushort Un_13 {
            get => GetData<ushort>(30);
            set {
                if (GetData<ushort>(30) == value) return;
                SetData(30, value, nameof(Un_13));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_13));
            }
        }

        public const string Un_14_displayName = "Un 14";
        public const int Un_14_sortIndex = 750;
        [SortOrder(Un_14_sortIndex)]
        [DisplayName(Un_14_displayName)]
        public virtual ushort Un_14 {
            get => GetData<ushort>(32);
            set {
                if (GetData<ushort>(32) == value) return;
                SetData(32, value, nameof(Un_14));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_14));
            }
        }

        public const string Un_15_displayName = "Un 15";
        public const int Un_15_sortIndex = 800;
        [SortOrder(Un_15_sortIndex)]
        [DisplayName(Un_15_displayName)]
        public virtual ushort Un_15 {
            get => GetData<ushort>(34);
            set {
                if (GetData<ushort>(34) == value) return;
                SetData(34, value, nameof(Un_15));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_15));
            }
        }

        public const string Un_16_displayName = "Un 16";
        public const int Un_16_sortIndex = 850;
        [SortOrder(Un_16_sortIndex)]
        [DisplayName(Un_16_displayName)]
        public virtual ushort Un_16 {
            get => GetData<ushort>(36);
            set {
                if (GetData<ushort>(36) == value) return;
                SetData(36, value, nameof(Un_16));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_16));
            }
        }

        public const string Un_17_displayName = "Un 17";
        public const int Un_17_sortIndex = 900;
        [SortOrder(Un_17_sortIndex)]
        [DisplayName(Un_17_displayName)]
        public virtual ushort Un_17 {
            get => GetData<ushort>(38);
            set {
                if (GetData<ushort>(38) == value) return;
                SetData(38, value, nameof(Un_17));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_17));
            }
        }

        public const string Un_18_displayName = "Un 18";
        public const int Un_18_sortIndex = 950;
        [SortOrder(Un_18_sortIndex)]
        [DisplayName(Un_18_displayName)]
        public virtual ushort Un_18 {
            get => GetData<ushort>(40);
            set {
                if (GetData<ushort>(40) == value) return;
                SetData(40, value, nameof(Un_18));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_18));
            }
        }

        public const string Un_19_displayName = "Un 19";
        public const int Un_19_sortIndex = 1000;
        [SortOrder(Un_19_sortIndex)]
        [DisplayName(Un_19_displayName)]
        public virtual ushort Un_19 {
            get => GetData<ushort>(42);
            set {
                if (GetData<ushort>(42) == value) return;
                SetData(42, value, nameof(Un_19));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_19));
            }
        }

        public const string Un_20_displayName = "Un 20";
        public const int Un_20_sortIndex = 1050;
        [SortOrder(Un_20_sortIndex)]
        [DisplayName(Un_20_displayName)]
        public virtual ushort Un_20 {
            get => GetData<ushort>(44);
            set {
                if (GetData<ushort>(44) == value) return;
                SetData(44, value, nameof(Un_20));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_20));
            }
        }

        public const string Un_21_displayName = "Un 21";
        public const int Un_21_sortIndex = 1100;
        [SortOrder(Un_21_sortIndex)]
        [DisplayName(Un_21_displayName)]
        public virtual ushort Un_21 {
            get => GetData<ushort>(46);
            set {
                if (GetData<ushort>(46) == value) return;
                SetData(46, value, nameof(Un_21));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_21));
            }
        }

        public const string Un_22_displayName = "Un 22";
        public const int Un_22_sortIndex = 1150;
        [SortOrder(Un_22_sortIndex)]
        [DisplayName(Un_22_displayName)]
        public virtual ushort Un_22 {
            get => GetData<ushort>(48);
            set {
                if (GetData<ushort>(48) == value) return;
                SetData(48, value, nameof(Un_22));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_22));
            }
        }

        public const string Un_23_displayName = "Un 23";
        public const int Un_23_sortIndex = 1200;
        [SortOrder(Un_23_sortIndex)]
        [DisplayName(Un_23_displayName)]
        public virtual ushort Un_23 {
            get => GetData<ushort>(50);
            set {
                if (GetData<ushort>(50) == value) return;
                SetData(50, value, nameof(Un_23));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_23));
            }
        }

        public const string Un_24_displayName = "Un 24";
        public const int Un_24_sortIndex = 1250;
        [SortOrder(Un_24_sortIndex)]
        [DisplayName(Un_24_displayName)]
        public virtual ushort Un_24 {
            get => GetData<ushort>(52);
            set {
                if (GetData<ushort>(52) == value) return;
                SetData(52, value, nameof(Un_24));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_24));
            }
        }

        public const string Un_25_displayName = "Un 25";
        public const int Un_25_sortIndex = 1300;
        [SortOrder(Un_25_sortIndex)]
        [DisplayName(Un_25_displayName)]
        public virtual ushort Un_25 {
            get => GetData<ushort>(54);
            set {
                if (GetData<ushort>(54) == value) return;
                SetData(54, value, nameof(Un_25));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_25));
            }
        }

        public const string Un_26_displayName = "Un 26";
        public const int Un_26_sortIndex = 1350;
        [SortOrder(Un_26_sortIndex)]
        [DisplayName(Un_26_displayName)]
        public virtual ushort Un_26 {
            get => GetData<ushort>(56);
            set {
                if (GetData<ushort>(56) == value) return;
                SetData(56, value, nameof(Un_26));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_26));
            }
        }

        public const string Un_27_displayName = "Un 27";
        public const int Un_27_sortIndex = 1400;
        [SortOrder(Un_27_sortIndex)]
        [DisplayName(Un_27_displayName)]
        public virtual ushort Un_27 {
            get => GetData<ushort>(58);
            set {
                if (GetData<ushort>(58) == value) return;
                SetData(58, value, nameof(Un_27));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_27));
            }
        }

        public const string Un_28_displayName = "Un 28";
        public const int Un_28_sortIndex = 1450;
        [SortOrder(Un_28_sortIndex)]
        [DisplayName(Un_28_displayName)]
        public virtual ushort Un_28 {
            get => GetData<ushort>(60);
            set {
                if (GetData<ushort>(60) == value) return;
                SetData(60, value, nameof(Un_28));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_28));
            }
        }

        public const string Un_29_displayName = "Un 29";
        public const int Un_29_sortIndex = 1500;
        [SortOrder(Un_29_sortIndex)]
        [DisplayName(Un_29_displayName)]
        public virtual ushort Un_29 {
            get => GetData<ushort>(62);
            set {
                if (GetData<ushort>(62) == value) return;
                SetData(62, value, nameof(Un_29));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_29));
            }
        }

        public const string Un_30_displayName = "Un 30";
        public const int Un_30_sortIndex = 1550;
        [SortOrder(Un_30_sortIndex)]
        [DisplayName(Un_30_displayName)]
        public virtual ushort Un_30 {
            get => GetData<ushort>(64);
            set {
                if (GetData<ushort>(64) == value) return;
                SetData(64, value, nameof(Un_30));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_30));
            }
        }

        public const string Un_31_displayName = "Un 31";
        public const int Un_31_sortIndex = 1600;
        [SortOrder(Un_31_sortIndex)]
        [DisplayName(Un_31_displayName)]
        public virtual ushort Un_31 {
            get => GetData<ushort>(66);
            set {
                if (GetData<ushort>(66) == value) return;
                SetData(66, value, nameof(Un_31));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_31));
            }
        }

        public const string Un_32_displayName = "Un 32";
        public const int Un_32_sortIndex = 1650;
        [SortOrder(Un_32_sortIndex)]
        [DisplayName(Un_32_displayName)]
        public virtual ushort Un_32 {
            get => GetData<ushort>(68);
            set {
                if (GetData<ushort>(68) == value) return;
                SetData(68, value, nameof(Un_32));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_32));
            }
        }

        public const string Un_33_displayName = "Un 33";
        public const int Un_33_sortIndex = 1700;
        [SortOrder(Un_33_sortIndex)]
        [DisplayName(Un_33_displayName)]
        public virtual ushort Un_33 {
            get => GetData<ushort>(70);
            set {
                if (GetData<ushort>(70) == value) return;
                SetData(70, value, nameof(Un_33));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_33));
            }
        }

        public const string Un_34_displayName = "Un 34";
        public const int Un_34_sortIndex = 1750;
        [SortOrder(Un_34_sortIndex)]
        [DisplayName(Un_34_displayName)]
        public virtual ushort Un_34 {
            get => GetData<ushort>(72);
            set {
                if (GetData<ushort>(72) == value) return;
                SetData(72, value, nameof(Un_34));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_34));
            }
        }

        public const string Un_35_displayName = "Un 35";
        public const int Un_35_sortIndex = 1800;
        [SortOrder(Un_35_sortIndex)]
        [DisplayName(Un_35_displayName)]
        public virtual ushort Un_35 {
            get => GetData<ushort>(74);
            set {
                if (GetData<ushort>(74) == value) return;
                SetData(74, value, nameof(Un_35));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_35));
            }
        }

        public const string Un_36_displayName = "Un 36";
        public const int Un_36_sortIndex = 1850;
        [SortOrder(Un_36_sortIndex)]
        [DisplayName(Un_36_displayName)]
        public virtual ushort Un_36 {
            get => GetData<ushort>(76);
            set {
                if (GetData<ushort>(76) == value) return;
                SetData(76, value, nameof(Un_36));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_36));
            }
        }

        public const string Un_37_displayName = "Un 37";
        public const int Un_37_sortIndex = 1900;
        [SortOrder(Un_37_sortIndex)]
        [DisplayName(Un_37_displayName)]
        public virtual ushort Un_37 {
            get => GetData<ushort>(78);
            set {
                if (GetData<ushort>(78) == value) return;
                SetData(78, value, nameof(Un_37));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_37));
            }
        }

        public const string Un_38_displayName = "Un 38";
        public const int Un_38_sortIndex = 1950;
        [SortOrder(Un_38_sortIndex)]
        [DisplayName(Un_38_displayName)]
        public virtual ushort Un_38 {
            get => GetData<ushort>(80);
            set {
                if (GetData<ushort>(80) == value) return;
                SetData(80, value, nameof(Un_38));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_38));
            }
        }

        public const string Un_39_displayName = "Un 39";
        public const int Un_39_sortIndex = 2000;
        [SortOrder(Un_39_sortIndex)]
        [DisplayName(Un_39_displayName)]
        public virtual ushort Un_39 {
            get => GetData<ushort>(82);
            set {
                if (GetData<ushort>(82) == value) return;
                SetData(82, value, nameof(Un_39));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_39));
            }
        }

        public const string Un_40_displayName = "Un 40";
        public const int Un_40_sortIndex = 2050;
        [SortOrder(Un_40_sortIndex)]
        [DisplayName(Un_40_displayName)]
        public virtual ushort Un_40 {
            get => GetData<ushort>(84);
            set {
                if (GetData<ushort>(84) == value) return;
                SetData(84, value, nameof(Un_40));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_40));
            }
        }

        public const string Un_41_displayName = "Un 41";
        public const int Un_41_sortIndex = 2100;
        [SortOrder(Un_41_sortIndex)]
        [DisplayName(Un_41_displayName)]
        public virtual ushort Un_41 {
            get => GetData<ushort>(86);
            set {
                if (GetData<ushort>(86) == value) return;
                SetData(86, value, nameof(Un_41));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_41));
            }
        }

        public const string Un_42_displayName = "Un 42";
        public const int Un_42_sortIndex = 2150;
        [SortOrder(Un_42_sortIndex)]
        [DisplayName(Un_42_displayName)]
        public virtual ushort Un_42 {
            get => GetData<ushort>(88);
            set {
                if (GetData<ushort>(88) == value) return;
                SetData(88, value, nameof(Un_42));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_42));
            }
        }

        public const string Un_43_displayName = "Un 43";
        public const int Un_43_sortIndex = 2200;
        [SortOrder(Un_43_sortIndex)]
        [DisplayName(Un_43_displayName)]
        public virtual ushort Un_43 {
            get => GetData<ushort>(90);
            set {
                if (GetData<ushort>(90) == value) return;
                SetData(90, value, nameof(Un_43));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_43));
            }
        }

        public const string Un_44_displayName = "Un 44";
        public const int Un_44_sortIndex = 2250;
        [SortOrder(Un_44_sortIndex)]
        [DisplayName(Un_44_displayName)]
        public virtual ushort Un_44 {
            get => GetData<ushort>(92);
            set {
                if (GetData<ushort>(92) == value) return;
                SetData(92, value, nameof(Un_44));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_44));
            }
        }

        public const string Un_45_displayName = "Un 45";
        public const int Un_45_sortIndex = 2300;
        [SortOrder(Un_45_sortIndex)]
        [DisplayName(Un_45_displayName)]
        public virtual ushort Un_45 {
            get => GetData<ushort>(94);
            set {
                if (GetData<ushort>(94) == value) return;
                SetData(94, value, nameof(Un_45));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_45));
            }
        }

        public const string Un_46_displayName = "Un 46";
        public const int Un_46_sortIndex = 2350;
        [SortOrder(Un_46_sortIndex)]
        [DisplayName(Un_46_displayName)]
        public virtual ushort Un_46 {
            get => GetData<ushort>(96);
            set {
                if (GetData<ushort>(96) == value) return;
                SetData(96, value, nameof(Un_46));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_46));
            }
        }

        public const string Un_47_displayName = "Un 47";
        public const int Un_47_sortIndex = 2400;
        [SortOrder(Un_47_sortIndex)]
        [DisplayName(Un_47_displayName)]
        public virtual ushort Un_47 {
            get => GetData<ushort>(98);
            set {
                if (GetData<ushort>(98) == value) return;
                SetData(98, value, nameof(Un_47));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_47));
            }
        }

        public const string Un_48_displayName = "Un 48";
        public const int Un_48_sortIndex = 2450;
        [SortOrder(Un_48_sortIndex)]
        [DisplayName(Un_48_displayName)]
        public virtual ushort Un_48 {
            get => GetData<ushort>(100);
            set {
                if (GetData<ushort>(100) == value) return;
                SetData(100, value, nameof(Un_48));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_48));
            }
        }

        public const string Un_49_displayName = "Un 49";
        public const int Un_49_sortIndex = 2500;
        [SortOrder(Un_49_sortIndex)]
        [DisplayName(Un_49_displayName)]
        public virtual ushort Un_49 {
            get => GetData<ushort>(102);
            set {
                if (GetData<ushort>(102) == value) return;
                SetData(102, value, nameof(Un_49));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_49));
            }
        }

        public const string Un_50_displayName = "Un 50";
        public const int Un_50_sortIndex = 2550;
        [SortOrder(Un_50_sortIndex)]
        [DisplayName(Un_50_displayName)]
        public virtual ushort Un_50 {
            get => GetData<ushort>(104);
            set {
                if (GetData<ushort>(104) == value) return;
                SetData(104, value, nameof(Un_50));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_50));
            }
        }

        public const string Un_51_displayName = "Un 51";
        public const int Un_51_sortIndex = 2600;
        [SortOrder(Un_51_sortIndex)]
        [DisplayName(Un_51_displayName)]
        public virtual ushort Un_51 {
            get => GetData<ushort>(106);
            set {
                if (GetData<ushort>(106) == value) return;
                SetData(106, value, nameof(Un_51));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_51));
            }
        }

        public const string Un_52_displayName = "Un 52";
        public const int Un_52_sortIndex = 2650;
        [SortOrder(Un_52_sortIndex)]
        [DisplayName(Un_52_displayName)]
        public virtual ushort Un_52 {
            get => GetData<ushort>(108);
            set {
                if (GetData<ushort>(108) == value) return;
                SetData(108, value, nameof(Un_52));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_52));
            }
        }

        public const string Un_53_displayName = "Un 53";
        public const int Un_53_sortIndex = 2700;
        [SortOrder(Un_53_sortIndex)]
        [DisplayName(Un_53_displayName)]
        public virtual ushort Un_53 {
            get => GetData<ushort>(110);
            set {
                if (GetData<ushort>(110) == value) return;
                SetData(110, value, nameof(Un_53));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_53));
            }
        }

        public const string Un_54_displayName = "Un 54";
        public const int Un_54_sortIndex = 2750;
        [SortOrder(Un_54_sortIndex)]
        [DisplayName(Un_54_displayName)]
        public virtual ushort Un_54 {
            get => GetData<ushort>(112);
            set {
                if (GetData<ushort>(112) == value) return;
                SetData(112, value, nameof(Un_54));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_54));
            }
        }

        public const string Un_55_displayName = "Un 55";
        public const int Un_55_sortIndex = 2800;
        [SortOrder(Un_55_sortIndex)]
        [DisplayName(Un_55_displayName)]
        public virtual ushort Un_55 {
            get => GetData<ushort>(114);
            set {
                if (GetData<ushort>(114) == value) return;
                SetData(114, value, nameof(Un_55));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_55));
            }
        }

        public const string Un_56_displayName = "Un 56";
        public const int Un_56_sortIndex = 2850;
        [SortOrder(Un_56_sortIndex)]
        [DisplayName(Un_56_displayName)]
        public virtual ushort Un_56 {
            get => GetData<ushort>(116);
            set {
                if (GetData<ushort>(116) == value) return;
                SetData(116, value, nameof(Un_56));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_56));
            }
        }

        public const string Un_57_displayName = "Un 57";
        public const int Un_57_sortIndex = 2900;
        [SortOrder(Un_57_sortIndex)]
        [DisplayName(Un_57_displayName)]
        public virtual ushort Un_57 {
            get => GetData<ushort>(118);
            set {
                if (GetData<ushort>(118) == value) return;
                SetData(118, value, nameof(Un_57));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_57));
            }
        }

        public const string Un_58_displayName = "Un 58";
        public const int Un_58_sortIndex = 2950;
        [SortOrder(Un_58_sortIndex)]
        [DisplayName(Un_58_displayName)]
        public virtual ushort Un_58 {
            get => GetData<ushort>(120);
            set {
                if (GetData<ushort>(120) == value) return;
                SetData(120, value, nameof(Un_58));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_58));
            }
        }

        public const string Un_59_displayName = "Un 59";
        public const int Un_59_sortIndex = 3000;
        [SortOrder(Un_59_sortIndex)]
        [DisplayName(Un_59_displayName)]
        public virtual ushort Un_59 {
            get => GetData<ushort>(122);
            set {
                if (GetData<ushort>(122) == value) return;
                SetData(122, value, nameof(Un_59));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_59));
            }
        }

        public const string Un_60_displayName = "Un 60";
        public const int Un_60_sortIndex = 3050;
        [SortOrder(Un_60_sortIndex)]
        [DisplayName(Un_60_displayName)]
        public virtual ushort Un_60 {
            get => GetData<ushort>(124);
            set {
                if (GetData<ushort>(124) == value) return;
                SetData(124, value, nameof(Un_60));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_60));
            }
        }

        public const string Un_61_displayName = "Un 61";
        public const int Un_61_sortIndex = 3100;
        [SortOrder(Un_61_sortIndex)]
        [DisplayName(Un_61_displayName)]
        public virtual ushort Un_61 {
            get => GetData<ushort>(126);
            set {
                if (GetData<ushort>(126) == value) return;
                SetData(126, value, nameof(Un_61));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_61));
            }
        }

        public const string Un_62_displayName = "Un 62";
        public const int Un_62_sortIndex = 3150;
        [SortOrder(Un_62_sortIndex)]
        [DisplayName(Un_62_displayName)]
        public virtual ushort Un_62 {
            get => GetData<ushort>(128);
            set {
                if (GetData<ushort>(128) == value) return;
                SetData(128, value, nameof(Un_62));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_62));
            }
        }

        public const string Un_63_displayName = "Un 63";
        public const int Un_63_sortIndex = 3200;
        [SortOrder(Un_63_sortIndex)]
        [DisplayName(Un_63_displayName)]
        public virtual ushort Un_63 {
            get => GetData<ushort>(130);
            set {
                if (GetData<ushort>(130) == value) return;
                SetData(130, value, nameof(Un_63));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_63));
            }
        }

        public const string Un_64_displayName = "Un 64";
        public const int Un_64_sortIndex = 3250;
        [SortOrder(Un_64_sortIndex)]
        [DisplayName(Un_64_displayName)]
        public virtual ushort Un_64 {
            get => GetData<ushort>(132);
            set {
                if (GetData<ushort>(132) == value) return;
                SetData(132, value, nameof(Un_64));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_64));
            }
        }

        public const string Un_65_displayName = "Un 65";
        public const int Un_65_sortIndex = 3300;
        [SortOrder(Un_65_sortIndex)]
        [DisplayName(Un_65_displayName)]
        public virtual ushort Un_65 {
            get => GetData<ushort>(134);
            set {
                if (GetData<ushort>(134) == value) return;
                SetData(134, value, nameof(Un_65));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_65));
            }
        }

        public const string Un_66_displayName = "Un 66";
        public const int Un_66_sortIndex = 3350;
        [SortOrder(Un_66_sortIndex)]
        [DisplayName(Un_66_displayName)]
        public virtual ushort Un_66 {
            get => GetData<ushort>(136);
            set {
                if (GetData<ushort>(136) == value) return;
                SetData(136, value, nameof(Un_66));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_66));
            }
        }

        public const string Un_67_displayName = "Un 67";
        public const int Un_67_sortIndex = 3400;
        [SortOrder(Un_67_sortIndex)]
        [DisplayName(Un_67_displayName)]
        public virtual ushort Un_67 {
            get => GetData<ushort>(138);
            set {
                if (GetData<ushort>(138) == value) return;
                SetData(138, value, nameof(Un_67));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_67));
            }
        }

        public const string Un_68_displayName = "Un 68";
        public const int Un_68_sortIndex = 3450;
        [SortOrder(Un_68_sortIndex)]
        [DisplayName(Un_68_displayName)]
        public virtual ushort Un_68 {
            get => GetData<ushort>(140);
            set {
                if (GetData<ushort>(140) == value) return;
                SetData(140, value, nameof(Un_68));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_68));
            }
        }

        public const string Un_69_displayName = "Un 69";
        public const int Un_69_sortIndex = 3500;
        [SortOrder(Un_69_sortIndex)]
        [DisplayName(Un_69_displayName)]
        public virtual ushort Un_69 {
            get => GetData<ushort>(142);
            set {
                if (GetData<ushort>(142) == value) return;
                SetData(142, value, nameof(Un_69));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_69));
            }
        }

        public const string Un_70_displayName = "Un 70";
        public const int Un_70_sortIndex = 3550;
        [SortOrder(Un_70_sortIndex)]
        [DisplayName(Un_70_displayName)]
        public virtual ushort Un_70 {
            get => GetData<ushort>(144);
            set {
                if (GetData<ushort>(144) == value) return;
                SetData(144, value, nameof(Un_70));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_70));
            }
        }

        public const string Un_71_displayName = "Un 71";
        public const int Un_71_sortIndex = 3600;
        [SortOrder(Un_71_sortIndex)]
        [DisplayName(Un_71_displayName)]
        public virtual ushort Un_71 {
            get => GetData<ushort>(146);
            set {
                if (GetData<ushort>(146) == value) return;
                SetData(146, value, nameof(Un_71));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_71));
            }
        }

        public const string Un_72_displayName = "Un 72";
        public const int Un_72_sortIndex = 3650;
        [SortOrder(Un_72_sortIndex)]
        [DisplayName(Un_72_displayName)]
        public virtual ushort Un_72 {
            get => GetData<ushort>(148);
            set {
                if (GetData<ushort>(148) == value) return;
                SetData(148, value, nameof(Un_72));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_72));
            }
        }

        public const string Un_73_displayName = "Un 73";
        public const int Un_73_sortIndex = 3700;
        [SortOrder(Un_73_sortIndex)]
        [DisplayName(Un_73_displayName)]
        public virtual ushort Un_73 {
            get => GetData<ushort>(150);
            set {
                if (GetData<ushort>(150) == value) return;
                SetData(150, value, nameof(Un_73));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_73));
            }
        }

        public const string Un_74_displayName = "Un 74";
        public const int Un_74_sortIndex = 3750;
        [SortOrder(Un_74_sortIndex)]
        [DisplayName(Un_74_displayName)]
        public virtual ushort Un_74 {
            get => GetData<ushort>(152);
            set {
                if (GetData<ushort>(152) == value) return;
                SetData(152, value, nameof(Un_74));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_74));
            }
        }

        public const string Un_75_displayName = "Un 75";
        public const int Un_75_sortIndex = 3800;
        [SortOrder(Un_75_sortIndex)]
        [DisplayName(Un_75_displayName)]
        public virtual ushort Un_75 {
            get => GetData<ushort>(154);
            set {
                if (GetData<ushort>(154) == value) return;
                SetData(154, value, nameof(Un_75));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_75));
            }
        }

        public const string Un_76_displayName = "Un 76";
        public const int Un_76_sortIndex = 3850;
        [SortOrder(Un_76_sortIndex)]
        [DisplayName(Un_76_displayName)]
        public virtual ushort Un_76 {
            get => GetData<ushort>(156);
            set {
                if (GetData<ushort>(156) == value) return;
                SetData(156, value, nameof(Un_76));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_76));
            }
        }

        public const string Un_77_displayName = "Un 77";
        public const int Un_77_sortIndex = 3900;
        [SortOrder(Un_77_sortIndex)]
        [DisplayName(Un_77_displayName)]
        public virtual ushort Un_77 {
            get => GetData<ushort>(158);
            set {
                if (GetData<ushort>(158) == value) return;
                SetData(158, value, nameof(Un_77));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_77));
            }
        }

        public const string Un_78_displayName = "Un 78";
        public const int Un_78_sortIndex = 3950;
        [SortOrder(Un_78_sortIndex)]
        [DisplayName(Un_78_displayName)]
        public virtual ushort Un_78 {
            get => GetData<ushort>(160);
            set {
                if (GetData<ushort>(160) == value) return;
                SetData(160, value, nameof(Un_78));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_78));
            }
        }

        public const string Un_79_displayName = "Un 79";
        public const int Un_79_sortIndex = 4000;
        [SortOrder(Un_79_sortIndex)]
        [DisplayName(Un_79_displayName)]
        public virtual ushort Un_79 {
            get => GetData<ushort>(162);
            set {
                if (GetData<ushort>(162) == value) return;
                SetData(162, value, nameof(Un_79));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_79));
            }
        }

        public const string Un_80_displayName = "Un 80";
        public const int Un_80_sortIndex = 4050;
        [SortOrder(Un_80_sortIndex)]
        [DisplayName(Un_80_displayName)]
        public virtual ushort Un_80 {
            get => GetData<ushort>(164);
            set {
                if (GetData<ushort>(164) == value) return;
                SetData(164, value, nameof(Un_80));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_80));
            }
        }

        public const string Un_81_displayName = "Un 81";
        public const int Un_81_sortIndex = 4100;
        [SortOrder(Un_81_sortIndex)]
        [DisplayName(Un_81_displayName)]
        public virtual ushort Un_81 {
            get => GetData<ushort>(166);
            set {
                if (GetData<ushort>(166) == value) return;
                SetData(166, value, nameof(Un_81));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_81));
            }
        }

        public const string Un_82_displayName = "Un 82";
        public const int Un_82_sortIndex = 4150;
        [SortOrder(Un_82_sortIndex)]
        [DisplayName(Un_82_displayName)]
        public virtual ushort Un_82 {
            get => GetData<ushort>(168);
            set {
                if (GetData<ushort>(168) == value) return;
                SetData(168, value, nameof(Un_82));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_82));
            }
        }

        public const string Un_83_displayName = "Un 83";
        public const int Un_83_sortIndex = 4200;
        [SortOrder(Un_83_sortIndex)]
        [DisplayName(Un_83_displayName)]
        public virtual ushort Un_83 {
            get => GetData<ushort>(170);
            set {
                if (GetData<ushort>(170) == value) return;
                SetData(170, value, nameof(Un_83));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_83));
            }
        }

        public const string Un_84_displayName = "Un 84";
        public const int Un_84_sortIndex = 4250;
        [SortOrder(Un_84_sortIndex)]
        [DisplayName(Un_84_displayName)]
        public virtual ushort Un_84 {
            get => GetData<ushort>(172);
            set {
                if (GetData<ushort>(172) == value) return;
                SetData(172, value, nameof(Un_84));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_84));
            }
        }

        public const string Un_85_displayName = "Un 85";
        public const int Un_85_sortIndex = 4300;
        [SortOrder(Un_85_sortIndex)]
        [DisplayName(Un_85_displayName)]
        public virtual ushort Un_85 {
            get => GetData<ushort>(174);
            set {
                if (GetData<ushort>(174) == value) return;
                SetData(174, value, nameof(Un_85));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_85));
            }
        }

        public const string Un_86_displayName = "Un 86";
        public const int Un_86_sortIndex = 4350;
        [SortOrder(Un_86_sortIndex)]
        [DisplayName(Un_86_displayName)]
        public virtual ushort Un_86 {
            get => GetData<ushort>(176);
            set {
                if (GetData<ushort>(176) == value) return;
                SetData(176, value, nameof(Un_86));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_86));
            }
        }

        public const string Un_87_displayName = "Un 87";
        public const int Un_87_sortIndex = 4400;
        [SortOrder(Un_87_sortIndex)]
        [DisplayName(Un_87_displayName)]
        public virtual ushort Un_87 {
            get => GetData<ushort>(178);
            set {
                if (GetData<ushort>(178) == value) return;
                SetData(178, value, nameof(Un_87));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_87));
            }
        }

        public const string Un_88_displayName = "Un 88";
        public const int Un_88_sortIndex = 4450;
        [SortOrder(Un_88_sortIndex)]
        [DisplayName(Un_88_displayName)]
        public virtual ushort Un_88 {
            get => GetData<ushort>(180);
            set {
                if (GetData<ushort>(180) == value) return;
                SetData(180, value, nameof(Un_88));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_88));
            }
        }

        public const string Un_89_displayName = "Un 89";
        public const int Un_89_sortIndex = 4500;
        [SortOrder(Un_89_sortIndex)]
        [DisplayName(Un_89_displayName)]
        public virtual ushort Un_89 {
            get => GetData<ushort>(182);
            set {
                if (GetData<ushort>(182) == value) return;
                SetData(182, value, nameof(Un_89));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_89));
            }
        }

        public const string Un_90_displayName = "Un 90";
        public const int Un_90_sortIndex = 4550;
        [SortOrder(Un_90_sortIndex)]
        [DisplayName(Un_90_displayName)]
        public virtual ushort Un_90 {
            get => GetData<ushort>(184);
            set {
                if (GetData<ushort>(184) == value) return;
                SetData(184, value, nameof(Un_90));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_90));
            }
        }

        public const string Un_91_displayName = "Un 91";
        public const int Un_91_sortIndex = 4600;
        [SortOrder(Un_91_sortIndex)]
        [DisplayName(Un_91_displayName)]
        public virtual ushort Un_91 {
            get => GetData<ushort>(186);
            set {
                if (GetData<ushort>(186) == value) return;
                SetData(186, value, nameof(Un_91));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_91));
            }
        }

        public const string Un_92_displayName = "Un 92";
        public const int Un_92_sortIndex = 4650;
        [SortOrder(Un_92_sortIndex)]
        [DisplayName(Un_92_displayName)]
        public virtual ushort Un_92 {
            get => GetData<ushort>(188);
            set {
                if (GetData<ushort>(188) == value) return;
                SetData(188, value, nameof(Un_92));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_92));
            }
        }

        public const string Un_93_displayName = "Un 93";
        public const int Un_93_sortIndex = 4700;
        [SortOrder(Un_93_sortIndex)]
        [DisplayName(Un_93_displayName)]
        public virtual ushort Un_93 {
            get => GetData<ushort>(190);
            set {
                if (GetData<ushort>(190) == value) return;
                SetData(190, value, nameof(Un_93));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_93));
            }
        }

        public const string Un_94_displayName = "Un 94";
        public const int Un_94_sortIndex = 4750;
        [SortOrder(Un_94_sortIndex)]
        [DisplayName(Un_94_displayName)]
        public virtual ushort Un_94 {
            get => GetData<ushort>(192);
            set {
                if (GetData<ushort>(192) == value) return;
                SetData(192, value, nameof(Un_94));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_94));
            }
        }

        public const string Un_95_displayName = "Un 95";
        public const int Un_95_sortIndex = 4800;
        [SortOrder(Un_95_sortIndex)]
        [DisplayName(Un_95_displayName)]
        public virtual ushort Un_95 {
            get => GetData<ushort>(194);
            set {
                if (GetData<ushort>(194) == value) return;
                SetData(194, value, nameof(Un_95));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_95));
            }
        }

        public const string Un_96_displayName = "Un 96";
        public const int Un_96_sortIndex = 4850;
        [SortOrder(Un_96_sortIndex)]
        [DisplayName(Un_96_displayName)]
        public virtual ushort Un_96 {
            get => GetData<ushort>(196);
            set {
                if (GetData<ushort>(196) == value) return;
                SetData(196, value, nameof(Un_96));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_96));
            }
        }

        public const string Un_97_displayName = "Un 97";
        public const int Un_97_sortIndex = 4900;
        [SortOrder(Un_97_sortIndex)]
        [DisplayName(Un_97_displayName)]
        public virtual ushort Un_97 {
            get => GetData<ushort>(198);
            set {
                if (GetData<ushort>(198) == value) return;
                SetData(198, value, nameof(Un_97));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_97));
            }
        }

        public const string Un_98_displayName = "Un 98";
        public const int Un_98_sortIndex = 4950;
        [SortOrder(Un_98_sortIndex)]
        [DisplayName(Un_98_displayName)]
        public virtual ushort Un_98 {
            get => GetData<ushort>(200);
            set {
                if (GetData<ushort>(200) == value) return;
                SetData(200, value, nameof(Un_98));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_98));
            }
        }

        public const string Un_99_displayName = "Un 99";
        public const int Un_99_sortIndex = 5000;
        [SortOrder(Un_99_sortIndex)]
        [DisplayName(Un_99_displayName)]
        public virtual ushort Un_99 {
            get => GetData<ushort>(202);
            set {
                if (GetData<ushort>(202) == value) return;
                SetData(202, value, nameof(Un_99));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_99));
            }
        }

        public const string Un_100_displayName = "Un 100";
        public const int Un_100_sortIndex = 5050;
        [SortOrder(Un_100_sortIndex)]
        [DisplayName(Un_100_displayName)]
        public virtual ushort Un_100 {
            get => GetData<ushort>(204);
            set {
                if (GetData<ushort>(204) == value) return;
                SetData(204, value, nameof(Un_100));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_100));
            }
        }

        public const string Un_101_displayName = "Un 101";
        public const int Un_101_sortIndex = 5100;
        [SortOrder(Un_101_sortIndex)]
        [DisplayName(Un_101_displayName)]
        public virtual ushort Un_101 {
            get => GetData<ushort>(206);
            set {
                if (GetData<ushort>(206) == value) return;
                SetData(206, value, nameof(Un_101));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_101));
            }
        }

        public const string Un_102_displayName = "Un 102";
        public const int Un_102_sortIndex = 5150;
        [SortOrder(Un_102_sortIndex)]
        [DisplayName(Un_102_displayName)]
        public virtual ushort Un_102 {
            get => GetData<ushort>(208);
            set {
                if (GetData<ushort>(208) == value) return;
                SetData(208, value, nameof(Un_102));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_102));
            }
        }

        public const string Un_103_displayName = "Un 103";
        public const int Un_103_sortIndex = 5200;
        [SortOrder(Un_103_sortIndex)]
        [DisplayName(Un_103_displayName)]
        public virtual ushort Un_103 {
            get => GetData<ushort>(210);
            set {
                if (GetData<ushort>(210) == value) return;
                SetData(210, value, nameof(Un_103));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_103));
            }
        }

        public const string Un_104_displayName = "Un 104";
        public const int Un_104_sortIndex = 5250;
        [SortOrder(Un_104_sortIndex)]
        [DisplayName(Un_104_displayName)]
        public virtual ushort Un_104 {
            get => GetData<ushort>(212);
            set {
                if (GetData<ushort>(212) == value) return;
                SetData(212, value, nameof(Un_104));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_104));
            }
        }

        public const string Un_105_displayName = "Un 105";
        public const int Un_105_sortIndex = 5300;
        [SortOrder(Un_105_sortIndex)]
        [DisplayName(Un_105_displayName)]
        public virtual ushort Un_105 {
            get => GetData<ushort>(214);
            set {
                if (GetData<ushort>(214) == value) return;
                SetData(214, value, nameof(Un_105));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_105));
            }
        }

        public const string Un_106_displayName = "Un 106";
        public const int Un_106_sortIndex = 5350;
        [SortOrder(Un_106_sortIndex)]
        [DisplayName(Un_106_displayName)]
        public virtual ushort Un_106 {
            get => GetData<ushort>(216);
            set {
                if (GetData<ushort>(216) == value) return;
                SetData(216, value, nameof(Un_106));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_106));
            }
        }

        public const string Un_107_displayName = "Un 107";
        public const int Un_107_sortIndex = 5400;
        [SortOrder(Un_107_sortIndex)]
        [DisplayName(Un_107_displayName)]
        public virtual ushort Un_107 {
            get => GetData<ushort>(218);
            set {
                if (GetData<ushort>(218) == value) return;
                SetData(218, value, nameof(Un_107));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_107));
            }
        }

        public const string Un_108_displayName = "Un 108";
        public const int Un_108_sortIndex = 5450;
        [SortOrder(Un_108_sortIndex)]
        [DisplayName(Un_108_displayName)]
        public virtual ushort Un_108 {
            get => GetData<ushort>(220);
            set {
                if (GetData<ushort>(220) == value) return;
                SetData(220, value, nameof(Un_108));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_108));
            }
        }

        public const string Un_109_displayName = "Un 109";
        public const int Un_109_sortIndex = 5500;
        [SortOrder(Un_109_sortIndex)]
        [DisplayName(Un_109_displayName)]
        public virtual ushort Un_109 {
            get => GetData<ushort>(222);
            set {
                if (GetData<ushort>(222) == value) return;
                SetData(222, value, nameof(Un_109));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_109));
            }
        }

        public const string Un_110_displayName = "Un 110";
        public const int Un_110_sortIndex = 5550;
        [SortOrder(Un_110_sortIndex)]
        [DisplayName(Un_110_displayName)]
        public virtual ushort Un_110 {
            get => GetData<ushort>(224);
            set {
                if (GetData<ushort>(224) == value) return;
                SetData(224, value, nameof(Un_110));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_110));
            }
        }

        public const string Un_111_displayName = "Un 111";
        public const int Un_111_sortIndex = 5600;
        [SortOrder(Un_111_sortIndex)]
        [DisplayName(Un_111_displayName)]
        public virtual ushort Un_111 {
            get => GetData<ushort>(226);
            set {
                if (GetData<ushort>(226) == value) return;
                SetData(226, value, nameof(Un_111));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_111));
            }
        }

        public const string Un_112_displayName = "Un 112";
        public const int Un_112_sortIndex = 5650;
        [SortOrder(Un_112_sortIndex)]
        [DisplayName(Un_112_displayName)]
        public virtual ushort Un_112 {
            get => GetData<ushort>(228);
            set {
                if (GetData<ushort>(228) == value) return;
                SetData(228, value, nameof(Un_112));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_112));
            }
        }

        public const string Un_113_displayName = "Un 113";
        public const int Un_113_sortIndex = 5700;
        [SortOrder(Un_113_sortIndex)]
        [DisplayName(Un_113_displayName)]
        public virtual ushort Un_113 {
            get => GetData<ushort>(230);
            set {
                if (GetData<ushort>(230) == value) return;
                SetData(230, value, nameof(Un_113));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_113));
            }
        }

        public const string Un_114_displayName = "Un 114";
        public const int Un_114_sortIndex = 5750;
        [SortOrder(Un_114_sortIndex)]
        [DisplayName(Un_114_displayName)]
        public virtual ushort Un_114 {
            get => GetData<ushort>(232);
            set {
                if (GetData<ushort>(232) == value) return;
                SetData(232, value, nameof(Un_114));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_114));
            }
        }

        public const string Un_115_displayName = "Un 115";
        public const int Un_115_sortIndex = 5800;
        [SortOrder(Un_115_sortIndex)]
        [DisplayName(Un_115_displayName)]
        public virtual ushort Un_115 {
            get => GetData<ushort>(234);
            set {
                if (GetData<ushort>(234) == value) return;
                SetData(234, value, nameof(Un_115));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_115));
            }
        }

        public const string Un_116_displayName = "Un 116";
        public const int Un_116_sortIndex = 5850;
        [SortOrder(Un_116_sortIndex)]
        [DisplayName(Un_116_displayName)]
        public virtual ushort Un_116 {
            get => GetData<ushort>(236);
            set {
                if (GetData<ushort>(236) == value) return;
                SetData(236, value, nameof(Un_116));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_116));
            }
        }

        public const string Un_117_displayName = "Un 117";
        public const int Un_117_sortIndex = 5900;
        [SortOrder(Un_117_sortIndex)]
        [DisplayName(Un_117_displayName)]
        public virtual ushort Un_117 {
            get => GetData<ushort>(238);
            set {
                if (GetData<ushort>(238) == value) return;
                SetData(238, value, nameof(Un_117));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_117));
            }
        }

        public const string Un_118_displayName = "Un 118";
        public const int Un_118_sortIndex = 5950;
        [SortOrder(Un_118_sortIndex)]
        [DisplayName(Un_118_displayName)]
        public virtual ushort Un_118 {
            get => GetData<ushort>(240);
            set {
                if (GetData<ushort>(240) == value) return;
                SetData(240, value, nameof(Un_118));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_118));
            }
        }

        public const string Un_119_displayName = "Un 119";
        public const int Un_119_sortIndex = 6000;
        [SortOrder(Un_119_sortIndex)]
        [DisplayName(Un_119_displayName)]
        public virtual ushort Un_119 {
            get => GetData<ushort>(242);
            set {
                if (GetData<ushort>(242) == value) return;
                SetData(242, value, nameof(Un_119));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_119));
            }
        }

        public const string Un_120_displayName = "Un 120";
        public const int Un_120_sortIndex = 6050;
        [SortOrder(Un_120_sortIndex)]
        [DisplayName(Un_120_displayName)]
        public virtual ushort Un_120 {
            get => GetData<ushort>(244);
            set {
                if (GetData<ushort>(244) == value) return;
                SetData(244, value, nameof(Un_120));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_120));
            }
        }

        public const string Un_121_displayName = "Un 121";
        public const int Un_121_sortIndex = 6100;
        [SortOrder(Un_121_sortIndex)]
        [DisplayName(Un_121_displayName)]
        public virtual ushort Un_121 {
            get => GetData<ushort>(246);
            set {
                if (GetData<ushort>(246) == value) return;
                SetData(246, value, nameof(Un_121));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_121));
            }
        }

        public const string Un_122_displayName = "Un 122";
        public const int Un_122_sortIndex = 6150;
        [SortOrder(Un_122_sortIndex)]
        [DisplayName(Un_122_displayName)]
        public virtual ushort Un_122 {
            get => GetData<ushort>(248);
            set {
                if (GetData<ushort>(248) == value) return;
                SetData(248, value, nameof(Un_122));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_122));
            }
        }

        public const string Un_123_displayName = "Un 123";
        public const int Un_123_sortIndex = 6200;
        [SortOrder(Un_123_sortIndex)]
        [DisplayName(Un_123_displayName)]
        public virtual ushort Un_123 {
            get => GetData<ushort>(250);
            set {
                if (GetData<ushort>(250) == value) return;
                SetData(250, value, nameof(Un_123));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_123));
            }
        }

        public const string Un_124_displayName = "Un 124";
        public const int Un_124_sortIndex = 6250;
        [SortOrder(Un_124_sortIndex)]
        [DisplayName(Un_124_displayName)]
        public virtual ushort Un_124 {
            get => GetData<ushort>(252);
            set {
                if (GetData<ushort>(252) == value) return;
                SetData(252, value, nameof(Un_124));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_124));
            }
        }

        public const string Un_125_displayName = "Un 125";
        public const int Un_125_sortIndex = 6300;
        [SortOrder(Un_125_sortIndex)]
        [DisplayName(Un_125_displayName)]
        public virtual ushort Un_125 {
            get => GetData<ushort>(254);
            set {
                if (GetData<ushort>(254) == value) return;
                SetData(254, value, nameof(Un_125));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_125));
            }
        }

        public const string Un_126_displayName = "Un 126";
        public const int Un_126_sortIndex = 6350;
        [SortOrder(Un_126_sortIndex)]
        [DisplayName(Un_126_displayName)]
        public virtual ushort Un_126 {
            get => GetData<ushort>(256);
            set {
                if (GetData<ushort>(256) == value) return;
                SetData(256, value, nameof(Un_126));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_126));
            }
        }

        public const string Un_127_displayName = "Un 127";
        public const int Un_127_sortIndex = 6400;
        [SortOrder(Un_127_sortIndex)]
        [DisplayName(Un_127_displayName)]
        public virtual ushort Un_127 {
            get => GetData<ushort>(258);
            set {
                if (GetData<ushort>(258) == value) return;
                SetData(258, value, nameof(Un_127));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_127));
            }
        }

        public const string Un_128_displayName = "Un 128";
        public const int Un_128_sortIndex = 6450;
        [SortOrder(Un_128_sortIndex)]
        [DisplayName(Un_128_displayName)]
        public virtual ushort Un_128 {
            get => GetData<ushort>(260);
            set {
                if (GetData<ushort>(260) == value) return;
                SetData(260, value, nameof(Un_128));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_128));
            }
        }

        public const string Un_129_displayName = "Un 129";
        public const int Un_129_sortIndex = 6500;
        [SortOrder(Un_129_sortIndex)]
        [DisplayName(Un_129_displayName)]
        public virtual ushort Un_129 {
            get => GetData<ushort>(262);
            set {
                if (GetData<ushort>(262) == value) return;
                SetData(262, value, nameof(Un_129));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_129));
            }
        }

        public const string Un_130_displayName = "Un 130";
        public const int Un_130_sortIndex = 6550;
        [SortOrder(Un_130_sortIndex)]
        [DisplayName(Un_130_displayName)]
        public virtual ushort Un_130 {
            get => GetData<ushort>(264);
            set {
                if (GetData<ushort>(264) == value) return;
                SetData(264, value, nameof(Un_130));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_130));
            }
        }

        public const string Un_131_displayName = "Un 131";
        public const int Un_131_sortIndex = 6600;
        [SortOrder(Un_131_sortIndex)]
        [DisplayName(Un_131_displayName)]
        public virtual ushort Un_131 {
            get => GetData<ushort>(266);
            set {
                if (GetData<ushort>(266) == value) return;
                SetData(266, value, nameof(Un_131));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_131));
            }
        }

        public const string Un_132_displayName = "Un 132";
        public const int Un_132_sortIndex = 6650;
        [SortOrder(Un_132_sortIndex)]
        [DisplayName(Un_132_displayName)]
        public virtual ushort Un_132 {
            get => GetData<ushort>(268);
            set {
                if (GetData<ushort>(268) == value) return;
                SetData(268, value, nameof(Un_132));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_132));
            }
        }

        public const string Un_133_displayName = "Un 133";
        public const int Un_133_sortIndex = 6700;
        [SortOrder(Un_133_sortIndex)]
        [DisplayName(Un_133_displayName)]
        public virtual ushort Un_133 {
            get => GetData<ushort>(270);
            set {
                if (GetData<ushort>(270) == value) return;
                SetData(270, value, nameof(Un_133));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_133));
            }
        }

        public const string Un_134_displayName = "Un 134";
        public const int Un_134_sortIndex = 6750;
        [SortOrder(Un_134_sortIndex)]
        [DisplayName(Un_134_displayName)]
        public virtual ushort Un_134 {
            get => GetData<ushort>(272);
            set {
                if (GetData<ushort>(272) == value) return;
                SetData(272, value, nameof(Un_134));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_134));
            }
        }

        public const string Un_135_displayName = "Un 135";
        public const int Un_135_sortIndex = 6800;
        [SortOrder(Un_135_sortIndex)]
        [DisplayName(Un_135_displayName)]
        public virtual ushort Un_135 {
            get => GetData<ushort>(274);
            set {
                if (GetData<ushort>(274) == value) return;
                SetData(274, value, nameof(Un_135));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_135));
            }
        }

        public const string Un_136_displayName = "Un 136";
        public const int Un_136_sortIndex = 6850;
        [SortOrder(Un_136_sortIndex)]
        [DisplayName(Un_136_displayName)]
        public virtual ushort Un_136 {
            get => GetData<ushort>(276);
            set {
                if (GetData<ushort>(276) == value) return;
                SetData(276, value, nameof(Un_136));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_136));
            }
        }

        public const string Un_137_displayName = "Un 137";
        public const int Un_137_sortIndex = 6900;
        [SortOrder(Un_137_sortIndex)]
        [DisplayName(Un_137_displayName)]
        public virtual ushort Un_137 {
            get => GetData<ushort>(278);
            set {
                if (GetData<ushort>(278) == value) return;
                SetData(278, value, nameof(Un_137));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_137));
            }
        }

        public const string Un_138_displayName = "Un 138";
        public const int Un_138_sortIndex = 6950;
        [SortOrder(Un_138_sortIndex)]
        [DisplayName(Un_138_displayName)]
        public virtual ushort Un_138 {
            get => GetData<ushort>(280);
            set {
                if (GetData<ushort>(280) == value) return;
                SetData(280, value, nameof(Un_138));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_138));
            }
        }

        public const string Un_139_displayName = "Un 139";
        public const int Un_139_sortIndex = 7000;
        [SortOrder(Un_139_sortIndex)]
        [DisplayName(Un_139_displayName)]
        public virtual ushort Un_139 {
            get => GetData<ushort>(282);
            set {
                if (GetData<ushort>(282) == value) return;
                SetData(282, value, nameof(Un_139));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_139));
            }
        }

        public const string Un_140_displayName = "Un 140";
        public const int Un_140_sortIndex = 7050;
        [SortOrder(Un_140_sortIndex)]
        [DisplayName(Un_140_displayName)]
        public virtual ushort Un_140 {
            get => GetData<ushort>(284);
            set {
                if (GetData<ushort>(284) == value) return;
                SetData(284, value, nameof(Un_140));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_140));
            }
        }

        public const string Un_141_displayName = "Un 141";
        public const int Un_141_sortIndex = 7100;
        [SortOrder(Un_141_sortIndex)]
        [DisplayName(Un_141_displayName)]
        public virtual ushort Un_141 {
            get => GetData<ushort>(286);
            set {
                if (GetData<ushort>(286) == value) return;
                SetData(286, value, nameof(Un_141));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_141));
            }
        }

        public const string Un_142_displayName = "Un 142";
        public const int Un_142_sortIndex = 7150;
        [SortOrder(Un_142_sortIndex)]
        [DisplayName(Un_142_displayName)]
        public virtual ushort Un_142 {
            get => GetData<ushort>(288);
            set {
                if (GetData<ushort>(288) == value) return;
                SetData(288, value, nameof(Un_142));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_142));
            }
        }

        public const string Un_143_displayName = "Un 143";
        public const int Un_143_sortIndex = 7200;
        [SortOrder(Un_143_sortIndex)]
        [DisplayName(Un_143_displayName)]
        public virtual ushort Un_143 {
            get => GetData<ushort>(290);
            set {
                if (GetData<ushort>(290) == value) return;
                SetData(290, value, nameof(Un_143));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_143));
            }
        }

        public const string Un_144_displayName = "Un 144";
        public const int Un_144_sortIndex = 7250;
        [SortOrder(Un_144_sortIndex)]
        [DisplayName(Un_144_displayName)]
        public virtual ushort Un_144 {
            get => GetData<ushort>(292);
            set {
                if (GetData<ushort>(292) == value) return;
                SetData(292, value, nameof(Un_144));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_144));
            }
        }

        public const string Un_145_displayName = "Un 145";
        public const int Un_145_sortIndex = 7300;
        [SortOrder(Un_145_sortIndex)]
        [DisplayName(Un_145_displayName)]
        public virtual ushort Un_145 {
            get => GetData<ushort>(294);
            set {
                if (GetData<ushort>(294) == value) return;
                SetData(294, value, nameof(Un_145));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_145));
            }
        }

        public const string Un_146_displayName = "Un 146";
        public const int Un_146_sortIndex = 7350;
        [SortOrder(Un_146_sortIndex)]
        [DisplayName(Un_146_displayName)]
        public virtual ushort Un_146 {
            get => GetData<ushort>(296);
            set {
                if (GetData<ushort>(296) == value) return;
                SetData(296, value, nameof(Un_146));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_146));
            }
        }

        public const string Un_147_displayName = "Un 147";
        public const int Un_147_sortIndex = 7400;
        [SortOrder(Un_147_sortIndex)]
        [DisplayName(Un_147_displayName)]
        public virtual ushort Un_147 {
            get => GetData<ushort>(298);
            set {
                if (GetData<ushort>(298) == value) return;
                SetData(298, value, nameof(Un_147));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_147));
            }
        }

        public const string Un_148_displayName = "Un 148";
        public const int Un_148_sortIndex = 7450;
        [SortOrder(Un_148_sortIndex)]
        [DisplayName(Un_148_displayName)]
        public virtual ushort Un_148 {
            get => GetData<ushort>(300);
            set {
                if (GetData<ushort>(300) == value) return;
                SetData(300, value, nameof(Un_148));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_148));
            }
        }

        public const string Un_149_displayName = "Un 149";
        public const int Un_149_sortIndex = 7500;
        [SortOrder(Un_149_sortIndex)]
        [DisplayName(Un_149_displayName)]
        public virtual ushort Un_149 {
            get => GetData<ushort>(302);
            set {
                if (GetData<ushort>(302) == value) return;
                SetData(302, value, nameof(Un_149));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_149));
            }
        }

        public const string Un_150_displayName = "Un 150";
        public const int Un_150_sortIndex = 7550;
        [SortOrder(Un_150_sortIndex)]
        [DisplayName(Un_150_displayName)]
        public virtual ushort Un_150 {
            get => GetData<ushort>(304);
            set {
                if (GetData<ushort>(304) == value) return;
                SetData(304, value, nameof(Un_150));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_150));
            }
        }

        public const string Un_151_displayName = "Un 151";
        public const int Un_151_sortIndex = 7600;
        [SortOrder(Un_151_sortIndex)]
        [DisplayName(Un_151_displayName)]
        public virtual ushort Un_151 {
            get => GetData<ushort>(306);
            set {
                if (GetData<ushort>(306) == value) return;
                SetData(306, value, nameof(Un_151));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_151));
            }
        }

        public const string Un_152_displayName = "Un 152";
        public const int Un_152_sortIndex = 7650;
        [SortOrder(Un_152_sortIndex)]
        [DisplayName(Un_152_displayName)]
        public virtual ushort Un_152 {
            get => GetData<ushort>(308);
            set {
                if (GetData<ushort>(308) == value) return;
                SetData(308, value, nameof(Un_152));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_152));
            }
        }

        public const string Un_153_displayName = "Un 153";
        public const int Un_153_sortIndex = 7700;
        [SortOrder(Un_153_sortIndex)]
        [DisplayName(Un_153_displayName)]
        public virtual ushort Un_153 {
            get => GetData<ushort>(310);
            set {
                if (GetData<ushort>(310) == value) return;
                SetData(310, value, nameof(Un_153));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_153));
            }
        }

        public const string Un_154_displayName = "Un 154";
        public const int Un_154_sortIndex = 7750;
        [SortOrder(Un_154_sortIndex)]
        [DisplayName(Un_154_displayName)]
        public virtual ushort Un_154 {
            get => GetData<ushort>(312);
            set {
                if (GetData<ushort>(312) == value) return;
                SetData(312, value, nameof(Un_154));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_154));
            }
        }

        public const string Un_155_displayName = "Un 155";
        public const int Un_155_sortIndex = 7800;
        [SortOrder(Un_155_sortIndex)]
        [DisplayName(Un_155_displayName)]
        public virtual ushort Un_155 {
            get => GetData<ushort>(314);
            set {
                if (GetData<ushort>(314) == value) return;
                SetData(314, value, nameof(Un_155));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_155));
            }
        }

        public const string Un_156_displayName = "Un 156";
        public const int Un_156_sortIndex = 7850;
        [SortOrder(Un_156_sortIndex)]
        [DisplayName(Un_156_displayName)]
        public virtual ushort Un_156 {
            get => GetData<ushort>(316);
            set {
                if (GetData<ushort>(316) == value) return;
                SetData(316, value, nameof(Un_156));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_156));
            }
        }

        public const string Un_157_displayName = "Un 157";
        public const int Un_157_sortIndex = 7900;
        [SortOrder(Un_157_sortIndex)]
        [DisplayName(Un_157_displayName)]
        public virtual ushort Un_157 {
            get => GetData<ushort>(318);
            set {
                if (GetData<ushort>(318) == value) return;
                SetData(318, value, nameof(Un_157));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_157));
            }
        }

        public const string Un_158_displayName = "Un 158";
        public const int Un_158_sortIndex = 7950;
        [SortOrder(Un_158_sortIndex)]
        [DisplayName(Un_158_displayName)]
        public virtual ushort Un_158 {
            get => GetData<ushort>(320);
            set {
                if (GetData<ushort>(320) == value) return;
                SetData(320, value, nameof(Un_158));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_158));
            }
        }

        public const string Un_159_displayName = "Un 159";
        public const int Un_159_sortIndex = 8000;
        [SortOrder(Un_159_sortIndex)]
        [DisplayName(Un_159_displayName)]
        public virtual ushort Un_159 {
            get => GetData<ushort>(322);
            set {
                if (GetData<ushort>(322) == value) return;
                SetData(322, value, nameof(Un_159));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_159));
            }
        }

        public const string Un_160_displayName = "Un 160";
        public const int Un_160_sortIndex = 8050;
        [SortOrder(Un_160_sortIndex)]
        [DisplayName(Un_160_displayName)]
        public virtual ushort Un_160 {
            get => GetData<ushort>(324);
            set {
                if (GetData<ushort>(324) == value) return;
                SetData(324, value, nameof(Un_160));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_160));
            }
        }

        public const string Un_161_displayName = "Un 161";
        public const int Un_161_sortIndex = 8100;
        [SortOrder(Un_161_sortIndex)]
        [DisplayName(Un_161_displayName)]
        public virtual ushort Un_161 {
            get => GetData<ushort>(326);
            set {
                if (GetData<ushort>(326) == value) return;
                SetData(326, value, nameof(Un_161));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_161));
            }
        }

        public const string Un_162_displayName = "Un 162";
        public const int Un_162_sortIndex = 8150;
        [SortOrder(Un_162_sortIndex)]
        [DisplayName(Un_162_displayName)]
        public virtual ushort Un_162 {
            get => GetData<ushort>(328);
            set {
                if (GetData<ushort>(328) == value) return;
                SetData(328, value, nameof(Un_162));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_162));
            }
        }

        public const string Un_163_displayName = "Un 163";
        public const int Un_163_sortIndex = 8200;
        [SortOrder(Un_163_sortIndex)]
        [DisplayName(Un_163_displayName)]
        public virtual ushort Un_163 {
            get => GetData<ushort>(330);
            set {
                if (GetData<ushort>(330) == value) return;
                SetData(330, value, nameof(Un_163));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_163));
            }
        }

        public const string Un_164_displayName = "Un 164";
        public const int Un_164_sortIndex = 8250;
        [SortOrder(Un_164_sortIndex)]
        [DisplayName(Un_164_displayName)]
        public virtual ushort Un_164 {
            get => GetData<ushort>(332);
            set {
                if (GetData<ushort>(332) == value) return;
                SetData(332, value, nameof(Un_164));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_164));
            }
        }

        public const string Un_165_displayName = "Un 165";
        public const int Un_165_sortIndex = 8300;
        [SortOrder(Un_165_sortIndex)]
        [DisplayName(Un_165_displayName)]
        public virtual ushort Un_165 {
            get => GetData<ushort>(334);
            set {
                if (GetData<ushort>(334) == value) return;
                SetData(334, value, nameof(Un_165));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_165));
            }
        }

        public const string Un_166_displayName = "Un 166";
        public const int Un_166_sortIndex = 8350;
        [SortOrder(Un_166_sortIndex)]
        [DisplayName(Un_166_displayName)]
        public virtual ushort Un_166 {
            get => GetData<ushort>(336);
            set {
                if (GetData<ushort>(336) == value) return;
                SetData(336, value, nameof(Un_166));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_166));
            }
        }

        public const string Un_167_displayName = "Un 167";
        public const int Un_167_sortIndex = 8400;
        [SortOrder(Un_167_sortIndex)]
        [DisplayName(Un_167_displayName)]
        public virtual ushort Un_167 {
            get => GetData<ushort>(338);
            set {
                if (GetData<ushort>(338) == value) return;
                SetData(338, value, nameof(Un_167));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_167));
            }
        }

        public const string Un_168_displayName = "Un 168";
        public const int Un_168_sortIndex = 8450;
        [SortOrder(Un_168_sortIndex)]
        [DisplayName(Un_168_displayName)]
        public virtual ushort Un_168 {
            get => GetData<ushort>(340);
            set {
                if (GetData<ushort>(340) == value) return;
                SetData(340, value, nameof(Un_168));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_168));
            }
        }

        public const string Un_169_displayName = "Un 169";
        public const int Un_169_sortIndex = 8500;
        [SortOrder(Un_169_sortIndex)]
        [DisplayName(Un_169_displayName)]
        public virtual ushort Un_169 {
            get => GetData<ushort>(342);
            set {
                if (GetData<ushort>(342) == value) return;
                SetData(342, value, nameof(Un_169));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_169));
            }
        }

        public const string Un_170_displayName = "Un 170";
        public const int Un_170_sortIndex = 8550;
        [SortOrder(Un_170_sortIndex)]
        [DisplayName(Un_170_displayName)]
        public virtual ushort Un_170 {
            get => GetData<ushort>(344);
            set {
                if (GetData<ushort>(344) == value) return;
                SetData(344, value, nameof(Un_170));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_170));
            }
        }

        public const string Un_171_displayName = "Un 171";
        public const int Un_171_sortIndex = 8600;
        [SortOrder(Un_171_sortIndex)]
        [DisplayName(Un_171_displayName)]
        public virtual ushort Un_171 {
            get => GetData<ushort>(346);
            set {
                if (GetData<ushort>(346) == value) return;
                SetData(346, value, nameof(Un_171));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_171));
            }
        }

        public const string Un_172_displayName = "Un 172";
        public const int Un_172_sortIndex = 8650;
        [SortOrder(Un_172_sortIndex)]
        [DisplayName(Un_172_displayName)]
        public virtual ushort Un_172 {
            get => GetData<ushort>(348);
            set {
                if (GetData<ushort>(348) == value) return;
                SetData(348, value, nameof(Un_172));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_172));
            }
        }

        public const string Un_173_displayName = "Un 173";
        public const int Un_173_sortIndex = 8700;
        [SortOrder(Un_173_sortIndex)]
        [DisplayName(Un_173_displayName)]
        public virtual ushort Un_173 {
            get => GetData<ushort>(350);
            set {
                if (GetData<ushort>(350) == value) return;
                SetData(350, value, nameof(Un_173));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_173));
            }
        }

        public const string Un_174_displayName = "Un 174";
        public const int Un_174_sortIndex = 8750;
        [SortOrder(Un_174_sortIndex)]
        [DisplayName(Un_174_displayName)]
        public virtual ushort Un_174 {
            get => GetData<ushort>(352);
            set {
                if (GetData<ushort>(352) == value) return;
                SetData(352, value, nameof(Un_174));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_174));
            }
        }

        public const string Un_175_displayName = "Un 175";
        public const int Un_175_sortIndex = 8800;
        [SortOrder(Un_175_sortIndex)]
        [DisplayName(Un_175_displayName)]
        public virtual ushort Un_175 {
            get => GetData<ushort>(354);
            set {
                if (GetData<ushort>(354) == value) return;
                SetData(354, value, nameof(Un_175));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_175));
            }
        }

        public const string Un_176_displayName = "Un 176";
        public const int Un_176_sortIndex = 8850;
        [SortOrder(Un_176_sortIndex)]
        [DisplayName(Un_176_displayName)]
        public virtual ushort Un_176 {
            get => GetData<ushort>(356);
            set {
                if (GetData<ushort>(356) == value) return;
                SetData(356, value, nameof(Un_176));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_176));
            }
        }

        public const string Un_177_displayName = "Un 177";
        public const int Un_177_sortIndex = 8900;
        [SortOrder(Un_177_sortIndex)]
        [DisplayName(Un_177_displayName)]
        public virtual ushort Un_177 {
            get => GetData<ushort>(358);
            set {
                if (GetData<ushort>(358) == value) return;
                SetData(358, value, nameof(Un_177));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_177));
            }
        }

        public const string Un_178_displayName = "Un 178";
        public const int Un_178_sortIndex = 8950;
        [SortOrder(Un_178_sortIndex)]
        [DisplayName(Un_178_displayName)]
        public virtual ushort Un_178 {
            get => GetData<ushort>(360);
            set {
                if (GetData<ushort>(360) == value) return;
                SetData(360, value, nameof(Un_178));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_178));
            }
        }

        public const string Un_179_displayName = "Un 179";
        public const int Un_179_sortIndex = 9000;
        [SortOrder(Un_179_sortIndex)]
        [DisplayName(Un_179_displayName)]
        public virtual ushort Un_179 {
            get => GetData<ushort>(362);
            set {
                if (GetData<ushort>(362) == value) return;
                SetData(362, value, nameof(Un_179));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_179));
            }
        }

        public const string Un_180_displayName = "Un 180";
        public const int Un_180_sortIndex = 9050;
        [SortOrder(Un_180_sortIndex)]
        [DisplayName(Un_180_displayName)]
        public virtual ushort Un_180 {
            get => GetData<ushort>(364);
            set {
                if (GetData<ushort>(364) == value) return;
                SetData(364, value, nameof(Un_180));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_180));
            }
        }

        public const string Un_181_displayName = "Un 181";
        public const int Un_181_sortIndex = 9100;
        [SortOrder(Un_181_sortIndex)]
        [DisplayName(Un_181_displayName)]
        public virtual ushort Un_181 {
            get => GetData<ushort>(366);
            set {
                if (GetData<ushort>(366) == value) return;
                SetData(366, value, nameof(Un_181));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_181));
            }
        }

        public const string Un_182_displayName = "Un 182";
        public const int Un_182_sortIndex = 9150;
        [SortOrder(Un_182_sortIndex)]
        [DisplayName(Un_182_displayName)]
        public virtual ushort Un_182 {
            get => GetData<ushort>(368);
            set {
                if (GetData<ushort>(368) == value) return;
                SetData(368, value, nameof(Un_182));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_182));
            }
        }

        public const string Un_183_displayName = "Un 183";
        public const int Un_183_sortIndex = 9200;
        [SortOrder(Un_183_sortIndex)]
        [DisplayName(Un_183_displayName)]
        public virtual ushort Un_183 {
            get => GetData<ushort>(370);
            set {
                if (GetData<ushort>(370) == value) return;
                SetData(370, value, nameof(Un_183));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_183));
            }
        }

        public const string Un_184_displayName = "Un 184";
        public const int Un_184_sortIndex = 9250;
        [SortOrder(Un_184_sortIndex)]
        [DisplayName(Un_184_displayName)]
        public virtual ushort Un_184 {
            get => GetData<ushort>(372);
            set {
                if (GetData<ushort>(372) == value) return;
                SetData(372, value, nameof(Un_184));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_184));
            }
        }

        public const string Un_185_displayName = "Un 185";
        public const int Un_185_sortIndex = 9300;
        [SortOrder(Un_185_sortIndex)]
        [DisplayName(Un_185_displayName)]
        public virtual ushort Un_185 {
            get => GetData<ushort>(374);
            set {
                if (GetData<ushort>(374) == value) return;
                SetData(374, value, nameof(Un_185));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_185));
            }
        }

        public const string Un_186_displayName = "Un 186";
        public const int Un_186_sortIndex = 9350;
        [SortOrder(Un_186_sortIndex)]
        [DisplayName(Un_186_displayName)]
        public virtual ushort Un_186 {
            get => GetData<ushort>(376);
            set {
                if (GetData<ushort>(376) == value) return;
                SetData(376, value, nameof(Un_186));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_186));
            }
        }

        public const string Un_187_displayName = "Un 187";
        public const int Un_187_sortIndex = 9400;
        [SortOrder(Un_187_sortIndex)]
        [DisplayName(Un_187_displayName)]
        public virtual ushort Un_187 {
            get => GetData<ushort>(378);
            set {
                if (GetData<ushort>(378) == value) return;
                SetData(378, value, nameof(Un_187));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_187));
            }
        }

        public const string Un_188_displayName = "Un 188";
        public const int Un_188_sortIndex = 9450;
        [SortOrder(Un_188_sortIndex)]
        [DisplayName(Un_188_displayName)]
        public virtual ushort Un_188 {
            get => GetData<ushort>(380);
            set {
                if (GetData<ushort>(380) == value) return;
                SetData(380, value, nameof(Un_188));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_188));
            }
        }

        public const string Un_189_displayName = "Un 189";
        public const int Un_189_sortIndex = 9500;
        [SortOrder(Un_189_sortIndex)]
        [DisplayName(Un_189_displayName)]
        public virtual ushort Un_189 {
            get => GetData<ushort>(382);
            set {
                if (GetData<ushort>(382) == value) return;
                SetData(382, value, nameof(Un_189));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_189));
            }
        }

        public const string Un_190_displayName = "Un 190";
        public const int Un_190_sortIndex = 9550;
        [SortOrder(Un_190_sortIndex)]
        [DisplayName(Un_190_displayName)]
        public virtual ushort Un_190 {
            get => GetData<ushort>(384);
            set {
                if (GetData<ushort>(384) == value) return;
                SetData(384, value, nameof(Un_190));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_190));
            }
        }

        public const string Un_191_displayName = "Un 191";
        public const int Un_191_sortIndex = 9600;
        [SortOrder(Un_191_sortIndex)]
        [DisplayName(Un_191_displayName)]
        public virtual ushort Un_191 {
            get => GetData<ushort>(386);
            set {
                if (GetData<ushort>(386) == value) return;
                SetData(386, value, nameof(Un_191));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_191));
            }
        }

        public const string Un_192_displayName = "Un 192";
        public const int Un_192_sortIndex = 9650;
        [SortOrder(Un_192_sortIndex)]
        [DisplayName(Un_192_displayName)]
        public virtual ushort Un_192 {
            get => GetData<ushort>(388);
            set {
                if (GetData<ushort>(388) == value) return;
                SetData(388, value, nameof(Un_192));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_192));
            }
        }

        public const string Un_193_displayName = "Un 193";
        public const int Un_193_sortIndex = 9700;
        [SortOrder(Un_193_sortIndex)]
        [DisplayName(Un_193_displayName)]
        public virtual ushort Un_193 {
            get => GetData<ushort>(390);
            set {
                if (GetData<ushort>(390) == value) return;
                SetData(390, value, nameof(Un_193));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_193));
            }
        }

        public const string Un_194_displayName = "Un 194";
        public const int Un_194_sortIndex = 9750;
        [SortOrder(Un_194_sortIndex)]
        [DisplayName(Un_194_displayName)]
        public virtual ushort Un_194 {
            get => GetData<ushort>(392);
            set {
                if (GetData<ushort>(392) == value) return;
                SetData(392, value, nameof(Un_194));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_194));
            }
        }

        public const string Un_195_displayName = "Un 195";
        public const int Un_195_sortIndex = 9800;
        [SortOrder(Un_195_sortIndex)]
        [DisplayName(Un_195_displayName)]
        public virtual ushort Un_195 {
            get => GetData<ushort>(394);
            set {
                if (GetData<ushort>(394) == value) return;
                SetData(394, value, nameof(Un_195));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_195));
            }
        }

        public const string Un_196_displayName = "Un 196";
        public const int Un_196_sortIndex = 9850;
        [SortOrder(Un_196_sortIndex)]
        [DisplayName(Un_196_displayName)]
        public virtual ushort Un_196 {
            get => GetData<ushort>(396);
            set {
                if (GetData<ushort>(396) == value) return;
                SetData(396, value, nameof(Un_196));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_196));
            }
        }

        public const string Un_197_displayName = "Un 197";
        public const int Un_197_sortIndex = 9900;
        [SortOrder(Un_197_sortIndex)]
        [DisplayName(Un_197_displayName)]
        public virtual ushort Un_197 {
            get => GetData<ushort>(398);
            set {
                if (GetData<ushort>(398) == value) return;
                SetData(398, value, nameof(Un_197));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_197));
            }
        }

        public const string Un_198_displayName = "Un 198";
        public const int Un_198_sortIndex = 9950;
        [SortOrder(Un_198_sortIndex)]
        [DisplayName(Un_198_displayName)]
        public virtual ushort Un_198 {
            get => GetData<ushort>(400);
            set {
                if (GetData<ushort>(400) == value) return;
                SetData(400, value, nameof(Un_198));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_198));
            }
        }

        public const string Un_199_displayName = "Un 199";
        public const int Un_199_sortIndex = 10000;
        [SortOrder(Un_199_sortIndex)]
        [DisplayName(Un_199_displayName)]
        public virtual ushort Un_199 {
            get => GetData<ushort>(402);
            set {
                if (GetData<ushort>(402) == value) return;
                SetData(402, value, nameof(Un_199));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_199));
            }
        }

        public const string Un_200_displayName = "Un 200";
        public const int Un_200_sortIndex = 10050;
        [SortOrder(Un_200_sortIndex)]
        [DisplayName(Un_200_displayName)]
        public virtual ushort Un_200 {
            get => GetData<ushort>(404);
            set {
                if (GetData<ushort>(404) == value) return;
                SetData(404, value, nameof(Un_200));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_200));
            }
        }

        public const string Un_201_displayName = "Un 201";
        public const int Un_201_sortIndex = 10100;
        [SortOrder(Un_201_sortIndex)]
        [DisplayName(Un_201_displayName)]
        public virtual ushort Un_201 {
            get => GetData<ushort>(406);
            set {
                if (GetData<ushort>(406) == value) return;
                SetData(406, value, nameof(Un_201));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_201));
            }
        }

        public const string Un_202_displayName = "Un 202";
        public const int Un_202_sortIndex = 10150;
        [SortOrder(Un_202_sortIndex)]
        [DisplayName(Un_202_displayName)]
        public virtual ushort Un_202 {
            get => GetData<ushort>(408);
            set {
                if (GetData<ushort>(408) == value) return;
                SetData(408, value, nameof(Un_202));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_202));
            }
        }

        public const string Un_203_displayName = "Un 203";
        public const int Un_203_sortIndex = 10200;
        [SortOrder(Un_203_sortIndex)]
        [DisplayName(Un_203_displayName)]
        public virtual ushort Un_203 {
            get => GetData<ushort>(410);
            set {
                if (GetData<ushort>(410) == value) return;
                SetData(410, value, nameof(Un_203));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_203));
            }
        }

        public const string Un_204_displayName = "Un 204";
        public const int Un_204_sortIndex = 10250;
        [SortOrder(Un_204_sortIndex)]
        [DisplayName(Un_204_displayName)]
        public virtual ushort Un_204 {
            get => GetData<ushort>(412);
            set {
                if (GetData<ushort>(412) == value) return;
                SetData(412, value, nameof(Un_204));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_204));
            }
        }

        public const string Un_205_displayName = "Un 205";
        public const int Un_205_sortIndex = 10300;
        [SortOrder(Un_205_sortIndex)]
        [DisplayName(Un_205_displayName)]
        public virtual ushort Un_205 {
            get => GetData<ushort>(414);
            set {
                if (GetData<ushort>(414) == value) return;
                SetData(414, value, nameof(Un_205));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_205));
            }
        }

        public const string Un_206_displayName = "Un 206";
        public const int Un_206_sortIndex = 10350;
        [SortOrder(Un_206_sortIndex)]
        [DisplayName(Un_206_displayName)]
        public virtual ushort Un_206 {
            get => GetData<ushort>(416);
            set {
                if (GetData<ushort>(416) == value) return;
                SetData(416, value, nameof(Un_206));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_206));
            }
        }

        public const string Un_207_displayName = "Un 207";
        public const int Un_207_sortIndex = 10400;
        [SortOrder(Un_207_sortIndex)]
        [DisplayName(Un_207_displayName)]
        public virtual ushort Un_207 {
            get => GetData<ushort>(418);
            set {
                if (GetData<ushort>(418) == value) return;
                SetData(418, value, nameof(Un_207));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_207));
            }
        }

        public const string Un_208_displayName = "Un 208";
        public const int Un_208_sortIndex = 10450;
        [SortOrder(Un_208_sortIndex)]
        [DisplayName(Un_208_displayName)]
        public virtual ushort Un_208 {
            get => GetData<ushort>(420);
            set {
                if (GetData<ushort>(420) == value) return;
                SetData(420, value, nameof(Un_208));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_208));
            }
        }

        public const string Un_209_displayName = "Un 209";
        public const int Un_209_sortIndex = 10500;
        [SortOrder(Un_209_sortIndex)]
        [DisplayName(Un_209_displayName)]
        public virtual ushort Un_209 {
            get => GetData<ushort>(422);
            set {
                if (GetData<ushort>(422) == value) return;
                SetData(422, value, nameof(Un_209));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_209));
            }
        }

        public const string Un_210_displayName = "Un 210";
        public const int Un_210_sortIndex = 10550;
        [SortOrder(Un_210_sortIndex)]
        [DisplayName(Un_210_displayName)]
        public virtual ushort Un_210 {
            get => GetData<ushort>(424);
            set {
                if (GetData<ushort>(424) == value) return;
                SetData(424, value, nameof(Un_210));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_210));
            }
        }

        public const string Un_211_displayName = "Un 211";
        public const int Un_211_sortIndex = 10600;
        [SortOrder(Un_211_sortIndex)]
        [DisplayName(Un_211_displayName)]
        public virtual ushort Un_211 {
            get => GetData<ushort>(426);
            set {
                if (GetData<ushort>(426) == value) return;
                SetData(426, value, nameof(Un_211));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_211));
            }
        }

        public const string Un_212_displayName = "Un 212";
        public const int Un_212_sortIndex = 10650;
        [SortOrder(Un_212_sortIndex)]
        [DisplayName(Un_212_displayName)]
        public virtual ushort Un_212 {
            get => GetData<ushort>(428);
            set {
                if (GetData<ushort>(428) == value) return;
                SetData(428, value, nameof(Un_212));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Un_212));
            }
        }

        public const int lastSortIndex = 10700;
    }
}
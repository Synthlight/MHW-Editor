using System;
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Items {
    public partial class QuestReward {
        public const uint StructSize = 104;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = -1;
        public const string EncryptionKey = null;
        public override string UniqueId => $"{Id}";

        public const string Id_displayName = "Id";
        public const int Id_sortIndex = 50;
        [SortOrder(Id_sortIndex)]
        [DisplayName(Id_displayName)]
        public virtual uint Id {
            get => GetData<uint>(0);
        }

        public const string Item_1_Id_displayName = "Item 1 Id";
        public const int Item_1_Id_sortIndex = 100;
        [SortOrder(Item_1_Id_sortIndex)]
        [DisplayName(Item_1_Id_displayName)]
        public virtual uint Item_1_Id {
            get => GetData<uint>(8);
            set {
                if (GetData<uint>(8) == value) return;
                SetData(8, value, nameof(Item_1_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_1_Id));
            }
        }

        public const string Item_1_Cnt_displayName = "Item 1 Cnt";
        public const int Item_1_Cnt_sortIndex = 150;
        [SortOrder(Item_1_Cnt_sortIndex)]
        [DisplayName(Item_1_Cnt_displayName)]
        public virtual byte Item_1_Cnt {
            get => GetData<byte>(72);
            set {
                if (GetData<byte>(72) == value) return;
                SetData(72, value, nameof(Item_1_Cnt));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_1_Cnt));
            }
        }

        public const string Item_1_Wt_displayName = "Item 1 Wt";
        public const int Item_1_Wt_sortIndex = 200;
        [SortOrder(Item_1_Wt_sortIndex)]
        [DisplayName(Item_1_Wt_displayName)]
        public virtual byte Item_1_Wt {
            get => GetData<byte>(88);
            set {
                if (GetData<byte>(88) == value) return;
                SetData(88, value, nameof(Item_1_Wt));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_1_Wt));
            }
        }

        public const string Item_2_Id_displayName = "Item 2 Id";
        public const int Item_2_Id_sortIndex = 250;
        [SortOrder(Item_2_Id_sortIndex)]
        [DisplayName(Item_2_Id_displayName)]
        public virtual uint Item_2_Id {
            get => GetData<uint>(12);
            set {
                if (GetData<uint>(12) == value) return;
                SetData(12, value, nameof(Item_2_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_2_Id));
            }
        }

        public const string Item_2_Cnt_displayName = "Item 2 Cnt";
        public const int Item_2_Cnt_sortIndex = 300;
        [SortOrder(Item_2_Cnt_sortIndex)]
        [DisplayName(Item_2_Cnt_displayName)]
        public virtual byte Item_2_Cnt {
            get => GetData<byte>(73);
            set {
                if (GetData<byte>(73) == value) return;
                SetData(73, value, nameof(Item_2_Cnt));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_2_Cnt));
            }
        }

        public const string Item_2_Wt_displayName = "Item 2 Wt";
        public const int Item_2_Wt_sortIndex = 350;
        [SortOrder(Item_2_Wt_sortIndex)]
        [DisplayName(Item_2_Wt_displayName)]
        public virtual byte Item_2_Wt {
            get => GetData<byte>(89);
            set {
                if (GetData<byte>(89) == value) return;
                SetData(89, value, nameof(Item_2_Wt));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_2_Wt));
            }
        }

        public const string Item_3_Id_displayName = "Item 3 Id";
        public const int Item_3_Id_sortIndex = 400;
        [SortOrder(Item_3_Id_sortIndex)]
        [DisplayName(Item_3_Id_displayName)]
        public virtual uint Item_3_Id {
            get => GetData<uint>(16);
            set {
                if (GetData<uint>(16) == value) return;
                SetData(16, value, nameof(Item_3_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_3_Id));
            }
        }

        public const string Item_3_Cnt_displayName = "Item 3 Cnt";
        public const int Item_3_Cnt_sortIndex = 450;
        [SortOrder(Item_3_Cnt_sortIndex)]
        [DisplayName(Item_3_Cnt_displayName)]
        public virtual byte Item_3_Cnt {
            get => GetData<byte>(74);
            set {
                if (GetData<byte>(74) == value) return;
                SetData(74, value, nameof(Item_3_Cnt));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_3_Cnt));
            }
        }

        public const string Item_3_Wt_displayName = "Item 3 Wt";
        public const int Item_3_Wt_sortIndex = 500;
        [SortOrder(Item_3_Wt_sortIndex)]
        [DisplayName(Item_3_Wt_displayName)]
        public virtual byte Item_3_Wt {
            get => GetData<byte>(90);
            set {
                if (GetData<byte>(90) == value) return;
                SetData(90, value, nameof(Item_3_Wt));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_3_Wt));
            }
        }

        public const string Item_4_Id_displayName = "Item 4 Id";
        public const int Item_4_Id_sortIndex = 550;
        [SortOrder(Item_4_Id_sortIndex)]
        [DisplayName(Item_4_Id_displayName)]
        public virtual uint Item_4_Id {
            get => GetData<uint>(20);
            set {
                if (GetData<uint>(20) == value) return;
                SetData(20, value, nameof(Item_4_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_4_Id));
            }
        }

        public const string Item_4_Cnt_displayName = "Item 4 Cnt";
        public const int Item_4_Cnt_sortIndex = 600;
        [SortOrder(Item_4_Cnt_sortIndex)]
        [DisplayName(Item_4_Cnt_displayName)]
        public virtual byte Item_4_Cnt {
            get => GetData<byte>(75);
            set {
                if (GetData<byte>(75) == value) return;
                SetData(75, value, nameof(Item_4_Cnt));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_4_Cnt));
            }
        }

        public const string Item_4_Wt_displayName = "Item 4 Wt";
        public const int Item_4_Wt_sortIndex = 650;
        [SortOrder(Item_4_Wt_sortIndex)]
        [DisplayName(Item_4_Wt_displayName)]
        public virtual byte Item_4_Wt {
            get => GetData<byte>(91);
            set {
                if (GetData<byte>(91) == value) return;
                SetData(91, value, nameof(Item_4_Wt));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_4_Wt));
            }
        }

        public const string Item_5_Id_displayName = "Item 5 Id";
        public const int Item_5_Id_sortIndex = 700;
        [SortOrder(Item_5_Id_sortIndex)]
        [DisplayName(Item_5_Id_displayName)]
        public virtual uint Item_5_Id {
            get => GetData<uint>(24);
            set {
                if (GetData<uint>(24) == value) return;
                SetData(24, value, nameof(Item_5_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_5_Id));
            }
        }

        public const string Item_5_Cnt_displayName = "Item 5 Cnt";
        public const int Item_5_Cnt_sortIndex = 750;
        [SortOrder(Item_5_Cnt_sortIndex)]
        [DisplayName(Item_5_Cnt_displayName)]
        public virtual byte Item_5_Cnt {
            get => GetData<byte>(76);
            set {
                if (GetData<byte>(76) == value) return;
                SetData(76, value, nameof(Item_5_Cnt));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_5_Cnt));
            }
        }

        public const string Item_5_Wt_displayName = "Item 5 Wt";
        public const int Item_5_Wt_sortIndex = 800;
        [SortOrder(Item_5_Wt_sortIndex)]
        [DisplayName(Item_5_Wt_displayName)]
        public virtual byte Item_5_Wt {
            get => GetData<byte>(92);
            set {
                if (GetData<byte>(92) == value) return;
                SetData(92, value, nameof(Item_5_Wt));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_5_Wt));
            }
        }

        public const string Item_6_Id_displayName = "Item 6 Id";
        public const int Item_6_Id_sortIndex = 850;
        [SortOrder(Item_6_Id_sortIndex)]
        [DisplayName(Item_6_Id_displayName)]
        public virtual uint Item_6_Id {
            get => GetData<uint>(28);
            set {
                if (GetData<uint>(28) == value) return;
                SetData(28, value, nameof(Item_6_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_6_Id));
            }
        }

        public const string Item_6_Cnt_displayName = "Item 6 Cnt";
        public const int Item_6_Cnt_sortIndex = 900;
        [SortOrder(Item_6_Cnt_sortIndex)]
        [DisplayName(Item_6_Cnt_displayName)]
        public virtual byte Item_6_Cnt {
            get => GetData<byte>(77);
            set {
                if (GetData<byte>(77) == value) return;
                SetData(77, value, nameof(Item_6_Cnt));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_6_Cnt));
            }
        }

        public const string Item_6_Wt_displayName = "Item 6 Wt";
        public const int Item_6_Wt_sortIndex = 950;
        [SortOrder(Item_6_Wt_sortIndex)]
        [DisplayName(Item_6_Wt_displayName)]
        public virtual byte Item_6_Wt {
            get => GetData<byte>(93);
            set {
                if (GetData<byte>(93) == value) return;
                SetData(93, value, nameof(Item_6_Wt));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_6_Wt));
            }
        }

        public const string Item_7_Id_displayName = "Item 7 Id";
        public const int Item_7_Id_sortIndex = 1000;
        [SortOrder(Item_7_Id_sortIndex)]
        [DisplayName(Item_7_Id_displayName)]
        public virtual uint Item_7_Id {
            get => GetData<uint>(32);
            set {
                if (GetData<uint>(32) == value) return;
                SetData(32, value, nameof(Item_7_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_7_Id));
            }
        }

        public const string Item_7_Cnt_displayName = "Item 7 Cnt";
        public const int Item_7_Cnt_sortIndex = 1050;
        [SortOrder(Item_7_Cnt_sortIndex)]
        [DisplayName(Item_7_Cnt_displayName)]
        public virtual byte Item_7_Cnt {
            get => GetData<byte>(78);
            set {
                if (GetData<byte>(78) == value) return;
                SetData(78, value, nameof(Item_7_Cnt));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_7_Cnt));
            }
        }

        public const string Item_7_Wt_displayName = "Item 7 Wt";
        public const int Item_7_Wt_sortIndex = 1100;
        [SortOrder(Item_7_Wt_sortIndex)]
        [DisplayName(Item_7_Wt_displayName)]
        public virtual byte Item_7_Wt {
            get => GetData<byte>(94);
            set {
                if (GetData<byte>(94) == value) return;
                SetData(94, value, nameof(Item_7_Wt));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_7_Wt));
            }
        }

        public const string Item_8_Id_displayName = "Item 8 Id";
        public const int Item_8_Id_sortIndex = 1150;
        [SortOrder(Item_8_Id_sortIndex)]
        [DisplayName(Item_8_Id_displayName)]
        public virtual uint Item_8_Id {
            get => GetData<uint>(36);
            set {
                if (GetData<uint>(36) == value) return;
                SetData(36, value, nameof(Item_8_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_8_Id));
            }
        }

        public const string Item_8_Cnt_displayName = "Item 8 Cnt";
        public const int Item_8_Cnt_sortIndex = 1200;
        [SortOrder(Item_8_Cnt_sortIndex)]
        [DisplayName(Item_8_Cnt_displayName)]
        public virtual byte Item_8_Cnt {
            get => GetData<byte>(79);
            set {
                if (GetData<byte>(79) == value) return;
                SetData(79, value, nameof(Item_8_Cnt));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_8_Cnt));
            }
        }

        public const string Item_8_Wt_displayName = "Item 8 Wt";
        public const int Item_8_Wt_sortIndex = 1250;
        [SortOrder(Item_8_Wt_sortIndex)]
        [DisplayName(Item_8_Wt_displayName)]
        public virtual byte Item_8_Wt {
            get => GetData<byte>(95);
            set {
                if (GetData<byte>(95) == value) return;
                SetData(95, value, nameof(Item_8_Wt));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_8_Wt));
            }
        }

        public const string Item_9_Id_displayName = "Item 9 Id";
        public const int Item_9_Id_sortIndex = 1300;
        [SortOrder(Item_9_Id_sortIndex)]
        [DisplayName(Item_9_Id_displayName)]
        public virtual uint Item_9_Id {
            get => GetData<uint>(40);
            set {
                if (GetData<uint>(40) == value) return;
                SetData(40, value, nameof(Item_9_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_9_Id));
            }
        }

        public const string Item_9_Cnt_displayName = "Item 9 Cnt";
        public const int Item_9_Cnt_sortIndex = 1350;
        [SortOrder(Item_9_Cnt_sortIndex)]
        [DisplayName(Item_9_Cnt_displayName)]
        public virtual byte Item_9_Cnt {
            get => GetData<byte>(80);
            set {
                if (GetData<byte>(80) == value) return;
                SetData(80, value, nameof(Item_9_Cnt));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_9_Cnt));
            }
        }

        public const string Item_9_Wt_displayName = "Item 9 Wt";
        public const int Item_9_Wt_sortIndex = 1400;
        [SortOrder(Item_9_Wt_sortIndex)]
        [DisplayName(Item_9_Wt_displayName)]
        public virtual byte Item_9_Wt {
            get => GetData<byte>(96);
            set {
                if (GetData<byte>(96) == value) return;
                SetData(96, value, nameof(Item_9_Wt));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_9_Wt));
            }
        }

        public const string Item_10_Id_displayName = "Item 10 Id";
        public const int Item_10_Id_sortIndex = 1450;
        [SortOrder(Item_10_Id_sortIndex)]
        [DisplayName(Item_10_Id_displayName)]
        public virtual uint Item_10_Id {
            get => GetData<uint>(44);
            set {
                if (GetData<uint>(44) == value) return;
                SetData(44, value, nameof(Item_10_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_10_Id));
            }
        }

        public const string Item_10_Cnt_displayName = "Item 10 Cnt";
        public const int Item_10_Cnt_sortIndex = 1500;
        [SortOrder(Item_10_Cnt_sortIndex)]
        [DisplayName(Item_10_Cnt_displayName)]
        public virtual byte Item_10_Cnt {
            get => GetData<byte>(81);
            set {
                if (GetData<byte>(81) == value) return;
                SetData(81, value, nameof(Item_10_Cnt));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_10_Cnt));
            }
        }

        public const string Item_10_Wt_displayName = "Item 10 Wt";
        public const int Item_10_Wt_sortIndex = 1550;
        [SortOrder(Item_10_Wt_sortIndex)]
        [DisplayName(Item_10_Wt_displayName)]
        public virtual byte Item_10_Wt {
            get => GetData<byte>(97);
            set {
                if (GetData<byte>(97) == value) return;
                SetData(97, value, nameof(Item_10_Wt));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_10_Wt));
            }
        }

        public const string Item_11_Id_displayName = "Item 11 Id";
        public const int Item_11_Id_sortIndex = 1600;
        [SortOrder(Item_11_Id_sortIndex)]
        [DisplayName(Item_11_Id_displayName)]
        public virtual uint Item_11_Id {
            get => GetData<uint>(48);
            set {
                if (GetData<uint>(48) == value) return;
                SetData(48, value, nameof(Item_11_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_11_Id));
            }
        }

        public const string Item_11_Cnt_displayName = "Item 11 Cnt";
        public const int Item_11_Cnt_sortIndex = 1650;
        [SortOrder(Item_11_Cnt_sortIndex)]
        [DisplayName(Item_11_Cnt_displayName)]
        public virtual byte Item_11_Cnt {
            get => GetData<byte>(82);
            set {
                if (GetData<byte>(82) == value) return;
                SetData(82, value, nameof(Item_11_Cnt));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_11_Cnt));
            }
        }

        public const string Item_11_Wt_displayName = "Item 11 Wt";
        public const int Item_11_Wt_sortIndex = 1700;
        [SortOrder(Item_11_Wt_sortIndex)]
        [DisplayName(Item_11_Wt_displayName)]
        public virtual byte Item_11_Wt {
            get => GetData<byte>(98);
            set {
                if (GetData<byte>(98) == value) return;
                SetData(98, value, nameof(Item_11_Wt));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_11_Wt));
            }
        }

        public const string Item_12_Id_displayName = "Item 12 Id";
        public const int Item_12_Id_sortIndex = 1750;
        [SortOrder(Item_12_Id_sortIndex)]
        [DisplayName(Item_12_Id_displayName)]
        public virtual uint Item_12_Id {
            get => GetData<uint>(52);
            set {
                if (GetData<uint>(52) == value) return;
                SetData(52, value, nameof(Item_12_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_12_Id));
            }
        }

        public const string Item_12_Cnt_displayName = "Item 12 Cnt";
        public const int Item_12_Cnt_sortIndex = 1800;
        [SortOrder(Item_12_Cnt_sortIndex)]
        [DisplayName(Item_12_Cnt_displayName)]
        public virtual byte Item_12_Cnt {
            get => GetData<byte>(83);
            set {
                if (GetData<byte>(83) == value) return;
                SetData(83, value, nameof(Item_12_Cnt));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_12_Cnt));
            }
        }

        public const string Item_12_Wt_displayName = "Item 12 Wt";
        public const int Item_12_Wt_sortIndex = 1850;
        [SortOrder(Item_12_Wt_sortIndex)]
        [DisplayName(Item_12_Wt_displayName)]
        public virtual byte Item_12_Wt {
            get => GetData<byte>(99);
            set {
                if (GetData<byte>(99) == value) return;
                SetData(99, value, nameof(Item_12_Wt));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_12_Wt));
            }
        }

        public const string Item_13_Id_displayName = "Item 13 Id";
        public const int Item_13_Id_sortIndex = 1900;
        [SortOrder(Item_13_Id_sortIndex)]
        [DisplayName(Item_13_Id_displayName)]
        public virtual uint Item_13_Id {
            get => GetData<uint>(56);
            set {
                if (GetData<uint>(56) == value) return;
                SetData(56, value, nameof(Item_13_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_13_Id));
            }
        }

        public const string Item_13_Cnt_displayName = "Item 13 Cnt";
        public const int Item_13_Cnt_sortIndex = 1950;
        [SortOrder(Item_13_Cnt_sortIndex)]
        [DisplayName(Item_13_Cnt_displayName)]
        public virtual byte Item_13_Cnt {
            get => GetData<byte>(84);
            set {
                if (GetData<byte>(84) == value) return;
                SetData(84, value, nameof(Item_13_Cnt));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_13_Cnt));
            }
        }

        public const string Item_13_Wt_displayName = "Item 13 Wt";
        public const int Item_13_Wt_sortIndex = 2000;
        [SortOrder(Item_13_Wt_sortIndex)]
        [DisplayName(Item_13_Wt_displayName)]
        public virtual byte Item_13_Wt {
            get => GetData<byte>(100);
            set {
                if (GetData<byte>(100) == value) return;
                SetData(100, value, nameof(Item_13_Wt));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_13_Wt));
            }
        }

        public const string Item_14_Id_displayName = "Item 14 Id";
        public const int Item_14_Id_sortIndex = 2050;
        [SortOrder(Item_14_Id_sortIndex)]
        [DisplayName(Item_14_Id_displayName)]
        public virtual uint Item_14_Id {
            get => GetData<uint>(60);
            set {
                if (GetData<uint>(60) == value) return;
                SetData(60, value, nameof(Item_14_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_14_Id));
            }
        }

        public const string Item_14_Cnt_displayName = "Item 14 Cnt";
        public const int Item_14_Cnt_sortIndex = 2100;
        [SortOrder(Item_14_Cnt_sortIndex)]
        [DisplayName(Item_14_Cnt_displayName)]
        public virtual byte Item_14_Cnt {
            get => GetData<byte>(85);
            set {
                if (GetData<byte>(85) == value) return;
                SetData(85, value, nameof(Item_14_Cnt));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_14_Cnt));
            }
        }

        public const string Item_14_Wt_displayName = "Item 14 Wt";
        public const int Item_14_Wt_sortIndex = 2150;
        [SortOrder(Item_14_Wt_sortIndex)]
        [DisplayName(Item_14_Wt_displayName)]
        public virtual byte Item_14_Wt {
            get => GetData<byte>(101);
            set {
                if (GetData<byte>(101) == value) return;
                SetData(101, value, nameof(Item_14_Wt));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_14_Wt));
            }
        }

        public const string Item_15_Id_displayName = "Item 15 Id";
        public const int Item_15_Id_sortIndex = 2200;
        [SortOrder(Item_15_Id_sortIndex)]
        [DisplayName(Item_15_Id_displayName)]
        public virtual uint Item_15_Id {
            get => GetData<uint>(64);
            set {
                if (GetData<uint>(64) == value) return;
                SetData(64, value, nameof(Item_15_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_15_Id));
            }
        }

        public const string Item_15_Cnt_displayName = "Item 15 Cnt";
        public const int Item_15_Cnt_sortIndex = 2250;
        [SortOrder(Item_15_Cnt_sortIndex)]
        [DisplayName(Item_15_Cnt_displayName)]
        public virtual byte Item_15_Cnt {
            get => GetData<byte>(86);
            set {
                if (GetData<byte>(86) == value) return;
                SetData(86, value, nameof(Item_15_Cnt));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_15_Cnt));
            }
        }

        public const string Item_15_Wt_displayName = "Item 15 Wt";
        public const int Item_15_Wt_sortIndex = 2300;
        [SortOrder(Item_15_Wt_sortIndex)]
        [DisplayName(Item_15_Wt_displayName)]
        public virtual byte Item_15_Wt {
            get => GetData<byte>(102);
            set {
                if (GetData<byte>(102) == value) return;
                SetData(102, value, nameof(Item_15_Wt));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_15_Wt));
            }
        }

        public const string Item_16_Id_displayName = "Item 16 Id";
        public const int Item_16_Id_sortIndex = 2350;
        [SortOrder(Item_16_Id_sortIndex)]
        [DisplayName(Item_16_Id_displayName)]
        public virtual uint Item_16_Id {
            get => GetData<uint>(68);
            set {
                if (GetData<uint>(68) == value) return;
                SetData(68, value, nameof(Item_16_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_16_Id));
            }
        }

        public const string Item_16_Cnt_displayName = "Item 16 Cnt";
        public const int Item_16_Cnt_sortIndex = 2400;
        [SortOrder(Item_16_Cnt_sortIndex)]
        [DisplayName(Item_16_Cnt_displayName)]
        public virtual byte Item_16_Cnt {
            get => GetData<byte>(87);
            set {
                if (GetData<byte>(87) == value) return;
                SetData(87, value, nameof(Item_16_Cnt));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_16_Cnt));
            }
        }

        public const string Item_16_Wt_displayName = "Item 16 Wt";
        public const int Item_16_Wt_sortIndex = 2450;
        [SortOrder(Item_16_Wt_sortIndex)]
        [DisplayName(Item_16_Wt_displayName)]
        public virtual byte Item_16_Wt {
            get => GetData<byte>(103);
            set {
                if (GetData<byte>(103) == value) return;
                SetData(103, value, nameof(Item_16_Wt));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_16_Wt));
            }
        }

        public const int lastSortIndex = 2500;
    }
}
using System.ComponentModel;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Items {
    public partial class ItemLottery {
        public const uint StructSize = 50;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public const string EncryptionKey = "D7N88VEGEnRl0HEHTO0xMQkbeMb37arJF488lREp90WYojAONkLoxfMt";
        public override string UniqueId => $"{Index}";

        public const string Item_1_Id_displayName = "Item 1 Id";
        public const int Item_1_Id_sortIndex = 50;
        [SortOrder(Item_1_Id_sortIndex)]
        [DisplayName(Item_1_Id_displayName)]
        [DataSource(DataSourceType.Items)]
        public virtual ushort Item_1_Id {
            get => GetData<ushort>(0);
            set {
                if (GetData<ushort>(0) == value) return;
                SetData(0, value, nameof(Item_1_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_1_Id));
                OnPropertyChanged(nameof(Item_1_Id_button));
            }
        }

        public const string Item_1_Cnt_displayName = "Item 1 Cnt";
        public const int Item_1_Cnt_sortIndex = 100;
        [SortOrder(Item_1_Cnt_sortIndex)]
        [DisplayName(Item_1_Cnt_displayName)]
        public virtual byte Item_1_Cnt {
            get => GetData<byte>(20);
            set {
                if (GetData<byte>(20) == value) return;
                SetData(20, value, nameof(Item_1_Cnt));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_1_Cnt));
            }
        }

        public const string Item_1__displayName = "Item 1 %";
        public const int Item_1__sortIndex = 150;
        [SortOrder(Item_1__sortIndex)]
        [DisplayName(Item_1__displayName)]
        public virtual byte Item_1_ {
            get => GetData<byte>(30);
            set {
                if (GetData<byte>(30) == value.Clamp((byte) 0, (byte) 100)) return;
                SetData(30, value.Clamp((byte) 0, (byte) 100), nameof(Item_1_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_1_));
            }
        }

        public const string Item_1_Unk_displayName = "Item 1 Unk";
        public const int Item_1_Unk_sortIndex = 200;
        [SortOrder(Item_1_Unk_sortIndex)]
        [DisplayName(Item_1_Unk_displayName)]
        public virtual byte Item_1_Unk {
            get => GetData<byte>(40);
            set {
                if (GetData<byte>(40) == value) return;
                SetData(40, value, nameof(Item_1_Unk));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_1_Unk));
            }
        }

        public const string Item_2_Id_displayName = "Item 2 Id";
        public const int Item_2_Id_sortIndex = 250;
        [SortOrder(Item_2_Id_sortIndex)]
        [DisplayName(Item_2_Id_displayName)]
        [DataSource(DataSourceType.Items)]
        public virtual ushort Item_2_Id {
            get => GetData<ushort>(2);
            set {
                if (GetData<ushort>(2) == value) return;
                SetData(2, value, nameof(Item_2_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_2_Id));
                OnPropertyChanged(nameof(Item_2_Id_button));
            }
        }

        public const string Item_2_Cnt_displayName = "Item 2 Cnt";
        public const int Item_2_Cnt_sortIndex = 300;
        [SortOrder(Item_2_Cnt_sortIndex)]
        [DisplayName(Item_2_Cnt_displayName)]
        public virtual byte Item_2_Cnt {
            get => GetData<byte>(21);
            set {
                if (GetData<byte>(21) == value) return;
                SetData(21, value, nameof(Item_2_Cnt));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_2_Cnt));
            }
        }

        public const string Item_2__displayName = "Item 2 %";
        public const int Item_2__sortIndex = 350;
        [SortOrder(Item_2__sortIndex)]
        [DisplayName(Item_2__displayName)]
        public virtual byte Item_2_ {
            get => GetData<byte>(31);
            set {
                if (GetData<byte>(31) == value.Clamp((byte) 0, (byte) 100)) return;
                SetData(31, value.Clamp((byte) 0, (byte) 100), nameof(Item_2_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_2_));
            }
        }

        public const string Item_2_Unk_displayName = "Item 2 Unk";
        public const int Item_2_Unk_sortIndex = 400;
        [SortOrder(Item_2_Unk_sortIndex)]
        [DisplayName(Item_2_Unk_displayName)]
        public virtual byte Item_2_Unk {
            get => GetData<byte>(41);
            set {
                if (GetData<byte>(41) == value) return;
                SetData(41, value, nameof(Item_2_Unk));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_2_Unk));
            }
        }

        public const string Item_3_Id_displayName = "Item 3 Id";
        public const int Item_3_Id_sortIndex = 450;
        [SortOrder(Item_3_Id_sortIndex)]
        [DisplayName(Item_3_Id_displayName)]
        [DataSource(DataSourceType.Items)]
        public virtual ushort Item_3_Id {
            get => GetData<ushort>(4);
            set {
                if (GetData<ushort>(4) == value) return;
                SetData(4, value, nameof(Item_3_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_3_Id));
                OnPropertyChanged(nameof(Item_3_Id_button));
            }
        }

        public const string Item_3_Cnt_displayName = "Item 3 Cnt";
        public const int Item_3_Cnt_sortIndex = 500;
        [SortOrder(Item_3_Cnt_sortIndex)]
        [DisplayName(Item_3_Cnt_displayName)]
        public virtual byte Item_3_Cnt {
            get => GetData<byte>(22);
            set {
                if (GetData<byte>(22) == value) return;
                SetData(22, value, nameof(Item_3_Cnt));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_3_Cnt));
            }
        }

        public const string Item_3__displayName = "Item 3 %";
        public const int Item_3__sortIndex = 550;
        [SortOrder(Item_3__sortIndex)]
        [DisplayName(Item_3__displayName)]
        public virtual byte Item_3_ {
            get => GetData<byte>(32);
            set {
                if (GetData<byte>(32) == value.Clamp((byte) 0, (byte) 100)) return;
                SetData(32, value.Clamp((byte) 0, (byte) 100), nameof(Item_3_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_3_));
            }
        }

        public const string Item_3_Unk_displayName = "Item 3 Unk";
        public const int Item_3_Unk_sortIndex = 600;
        [SortOrder(Item_3_Unk_sortIndex)]
        [DisplayName(Item_3_Unk_displayName)]
        public virtual byte Item_3_Unk {
            get => GetData<byte>(42);
            set {
                if (GetData<byte>(42) == value) return;
                SetData(42, value, nameof(Item_3_Unk));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_3_Unk));
            }
        }

        public const string Item_4_Id_displayName = "Item 4 Id";
        public const int Item_4_Id_sortIndex = 650;
        [SortOrder(Item_4_Id_sortIndex)]
        [DisplayName(Item_4_Id_displayName)]
        [DataSource(DataSourceType.Items)]
        public virtual ushort Item_4_Id {
            get => GetData<ushort>(6);
            set {
                if (GetData<ushort>(6) == value) return;
                SetData(6, value, nameof(Item_4_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_4_Id));
                OnPropertyChanged(nameof(Item_4_Id_button));
            }
        }

        public const string Item_4_Cnt_displayName = "Item 4 Cnt";
        public const int Item_4_Cnt_sortIndex = 700;
        [SortOrder(Item_4_Cnt_sortIndex)]
        [DisplayName(Item_4_Cnt_displayName)]
        public virtual byte Item_4_Cnt {
            get => GetData<byte>(23);
            set {
                if (GetData<byte>(23) == value) return;
                SetData(23, value, nameof(Item_4_Cnt));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_4_Cnt));
            }
        }

        public const string Item_4__displayName = "Item 4 %";
        public const int Item_4__sortIndex = 750;
        [SortOrder(Item_4__sortIndex)]
        [DisplayName(Item_4__displayName)]
        public virtual byte Item_4_ {
            get => GetData<byte>(33);
            set {
                if (GetData<byte>(33) == value.Clamp((byte) 0, (byte) 100)) return;
                SetData(33, value.Clamp((byte) 0, (byte) 100), nameof(Item_4_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_4_));
            }
        }

        public const string Item_4_Unk_displayName = "Item 4 Unk";
        public const int Item_4_Unk_sortIndex = 800;
        [SortOrder(Item_4_Unk_sortIndex)]
        [DisplayName(Item_4_Unk_displayName)]
        public virtual byte Item_4_Unk {
            get => GetData<byte>(43);
            set {
                if (GetData<byte>(43) == value) return;
                SetData(43, value, nameof(Item_4_Unk));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_4_Unk));
            }
        }

        public const string Item_5_Id_displayName = "Item 5 Id";
        public const int Item_5_Id_sortIndex = 850;
        [SortOrder(Item_5_Id_sortIndex)]
        [DisplayName(Item_5_Id_displayName)]
        [DataSource(DataSourceType.Items)]
        public virtual ushort Item_5_Id {
            get => GetData<ushort>(8);
            set {
                if (GetData<ushort>(8) == value) return;
                SetData(8, value, nameof(Item_5_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_5_Id));
                OnPropertyChanged(nameof(Item_5_Id_button));
            }
        }

        public const string Item_5_Cnt_displayName = "Item 5 Cnt";
        public const int Item_5_Cnt_sortIndex = 900;
        [SortOrder(Item_5_Cnt_sortIndex)]
        [DisplayName(Item_5_Cnt_displayName)]
        public virtual byte Item_5_Cnt {
            get => GetData<byte>(24);
            set {
                if (GetData<byte>(24) == value) return;
                SetData(24, value, nameof(Item_5_Cnt));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_5_Cnt));
            }
        }

        public const string Item_5__displayName = "Item 5 %";
        public const int Item_5__sortIndex = 950;
        [SortOrder(Item_5__sortIndex)]
        [DisplayName(Item_5__displayName)]
        public virtual byte Item_5_ {
            get => GetData<byte>(34);
            set {
                if (GetData<byte>(34) == value.Clamp((byte) 0, (byte) 100)) return;
                SetData(34, value.Clamp((byte) 0, (byte) 100), nameof(Item_5_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_5_));
            }
        }

        public const string Item_5_Unk_displayName = "Item 5 Unk";
        public const int Item_5_Unk_sortIndex = 1000;
        [SortOrder(Item_5_Unk_sortIndex)]
        [DisplayName(Item_5_Unk_displayName)]
        public virtual byte Item_5_Unk {
            get => GetData<byte>(44);
            set {
                if (GetData<byte>(44) == value) return;
                SetData(44, value, nameof(Item_5_Unk));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_5_Unk));
            }
        }

        public const string Item_6_Id_displayName = "Item 6 Id";
        public const int Item_6_Id_sortIndex = 1050;
        [SortOrder(Item_6_Id_sortIndex)]
        [DisplayName(Item_6_Id_displayName)]
        [DataSource(DataSourceType.Items)]
        public virtual ushort Item_6_Id {
            get => GetData<ushort>(10);
            set {
                if (GetData<ushort>(10) == value) return;
                SetData(10, value, nameof(Item_6_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_6_Id));
                OnPropertyChanged(nameof(Item_6_Id_button));
            }
        }

        public const string Item_6_Cnt_displayName = "Item 6 Cnt";
        public const int Item_6_Cnt_sortIndex = 1100;
        [SortOrder(Item_6_Cnt_sortIndex)]
        [DisplayName(Item_6_Cnt_displayName)]
        public virtual byte Item_6_Cnt {
            get => GetData<byte>(25);
            set {
                if (GetData<byte>(25) == value) return;
                SetData(25, value, nameof(Item_6_Cnt));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_6_Cnt));
            }
        }

        public const string Item_6__displayName = "Item 6 %";
        public const int Item_6__sortIndex = 1150;
        [SortOrder(Item_6__sortIndex)]
        [DisplayName(Item_6__displayName)]
        public virtual byte Item_6_ {
            get => GetData<byte>(35);
            set {
                if (GetData<byte>(35) == value.Clamp((byte) 0, (byte) 100)) return;
                SetData(35, value.Clamp((byte) 0, (byte) 100), nameof(Item_6_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_6_));
            }
        }

        public const string Item_6_Unk_displayName = "Item 6 Unk";
        public const int Item_6_Unk_sortIndex = 1200;
        [SortOrder(Item_6_Unk_sortIndex)]
        [DisplayName(Item_6_Unk_displayName)]
        public virtual byte Item_6_Unk {
            get => GetData<byte>(45);
            set {
                if (GetData<byte>(45) == value) return;
                SetData(45, value, nameof(Item_6_Unk));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_6_Unk));
            }
        }

        public const string Item_7_Id_displayName = "Item 7 Id";
        public const int Item_7_Id_sortIndex = 1250;
        [SortOrder(Item_7_Id_sortIndex)]
        [DisplayName(Item_7_Id_displayName)]
        [DataSource(DataSourceType.Items)]
        public virtual ushort Item_7_Id {
            get => GetData<ushort>(12);
            set {
                if (GetData<ushort>(12) == value) return;
                SetData(12, value, nameof(Item_7_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_7_Id));
                OnPropertyChanged(nameof(Item_7_Id_button));
            }
        }

        public const string Item_7_Cnt_displayName = "Item 7 Cnt";
        public const int Item_7_Cnt_sortIndex = 1300;
        [SortOrder(Item_7_Cnt_sortIndex)]
        [DisplayName(Item_7_Cnt_displayName)]
        public virtual byte Item_7_Cnt {
            get => GetData<byte>(26);
            set {
                if (GetData<byte>(26) == value) return;
                SetData(26, value, nameof(Item_7_Cnt));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_7_Cnt));
            }
        }

        public const string Item_7__displayName = "Item 7 %";
        public const int Item_7__sortIndex = 1350;
        [SortOrder(Item_7__sortIndex)]
        [DisplayName(Item_7__displayName)]
        public virtual byte Item_7_ {
            get => GetData<byte>(36);
            set {
                if (GetData<byte>(36) == value.Clamp((byte) 0, (byte) 100)) return;
                SetData(36, value.Clamp((byte) 0, (byte) 100), nameof(Item_7_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_7_));
            }
        }

        public const string Item_7_Unk_displayName = "Item 7 Unk";
        public const int Item_7_Unk_sortIndex = 1400;
        [SortOrder(Item_7_Unk_sortIndex)]
        [DisplayName(Item_7_Unk_displayName)]
        public virtual byte Item_7_Unk {
            get => GetData<byte>(46);
            set {
                if (GetData<byte>(46) == value) return;
                SetData(46, value, nameof(Item_7_Unk));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_7_Unk));
            }
        }

        public const string Item_8_Id_displayName = "Item 8 Id";
        public const int Item_8_Id_sortIndex = 1450;
        [SortOrder(Item_8_Id_sortIndex)]
        [DisplayName(Item_8_Id_displayName)]
        [DataSource(DataSourceType.Items)]
        public virtual ushort Item_8_Id {
            get => GetData<ushort>(14);
            set {
                if (GetData<ushort>(14) == value) return;
                SetData(14, value, nameof(Item_8_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_8_Id));
                OnPropertyChanged(nameof(Item_8_Id_button));
            }
        }

        public const string Item_8_Cnt_displayName = "Item 8 Cnt";
        public const int Item_8_Cnt_sortIndex = 1500;
        [SortOrder(Item_8_Cnt_sortIndex)]
        [DisplayName(Item_8_Cnt_displayName)]
        public virtual byte Item_8_Cnt {
            get => GetData<byte>(27);
            set {
                if (GetData<byte>(27) == value) return;
                SetData(27, value, nameof(Item_8_Cnt));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_8_Cnt));
            }
        }

        public const string Item_8__displayName = "Item 8 %";
        public const int Item_8__sortIndex = 1550;
        [SortOrder(Item_8__sortIndex)]
        [DisplayName(Item_8__displayName)]
        public virtual byte Item_8_ {
            get => GetData<byte>(37);
            set {
                if (GetData<byte>(37) == value.Clamp((byte) 0, (byte) 100)) return;
                SetData(37, value.Clamp((byte) 0, (byte) 100), nameof(Item_8_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_8_));
            }
        }

        public const string Item_8_Unk_displayName = "Item 8 Unk";
        public const int Item_8_Unk_sortIndex = 1600;
        [SortOrder(Item_8_Unk_sortIndex)]
        [DisplayName(Item_8_Unk_displayName)]
        public virtual byte Item_8_Unk {
            get => GetData<byte>(47);
            set {
                if (GetData<byte>(47) == value) return;
                SetData(47, value, nameof(Item_8_Unk));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_8_Unk));
            }
        }

        public const string Item_9_Id_displayName = "Item 9 Id";
        public const int Item_9_Id_sortIndex = 1650;
        [SortOrder(Item_9_Id_sortIndex)]
        [DisplayName(Item_9_Id_displayName)]
        [DataSource(DataSourceType.Items)]
        public virtual ushort Item_9_Id {
            get => GetData<ushort>(16);
            set {
                if (GetData<ushort>(16) == value) return;
                SetData(16, value, nameof(Item_9_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_9_Id));
                OnPropertyChanged(nameof(Item_9_Id_button));
            }
        }

        public const string Item_9_Cnt_displayName = "Item 9 Cnt";
        public const int Item_9_Cnt_sortIndex = 1700;
        [SortOrder(Item_9_Cnt_sortIndex)]
        [DisplayName(Item_9_Cnt_displayName)]
        public virtual byte Item_9_Cnt {
            get => GetData<byte>(28);
            set {
                if (GetData<byte>(28) == value) return;
                SetData(28, value, nameof(Item_9_Cnt));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_9_Cnt));
            }
        }

        public const string Item_9__displayName = "Item 9 %";
        public const int Item_9__sortIndex = 1750;
        [SortOrder(Item_9__sortIndex)]
        [DisplayName(Item_9__displayName)]
        public virtual byte Item_9_ {
            get => GetData<byte>(38);
            set {
                if (GetData<byte>(38) == value.Clamp((byte) 0, (byte) 100)) return;
                SetData(38, value.Clamp((byte) 0, (byte) 100), nameof(Item_9_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_9_));
            }
        }

        public const string Item_9_Unk_displayName = "Item 9 Unk";
        public const int Item_9_Unk_sortIndex = 1800;
        [SortOrder(Item_9_Unk_sortIndex)]
        [DisplayName(Item_9_Unk_displayName)]
        public virtual byte Item_9_Unk {
            get => GetData<byte>(48);
            set {
                if (GetData<byte>(48) == value) return;
                SetData(48, value, nameof(Item_9_Unk));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_9_Unk));
            }
        }

        public const string Item_10_Id_displayName = "Item 10 Id";
        public const int Item_10_Id_sortIndex = 1850;
        [SortOrder(Item_10_Id_sortIndex)]
        [DisplayName(Item_10_Id_displayName)]
        [DataSource(DataSourceType.Items)]
        public virtual ushort Item_10_Id {
            get => GetData<ushort>(18);
            set {
                if (GetData<ushort>(18) == value) return;
                SetData(18, value, nameof(Item_10_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_10_Id));
                OnPropertyChanged(nameof(Item_10_Id_button));
            }
        }

        public const string Item_10_Cnt_displayName = "Item 10 Cnt";
        public const int Item_10_Cnt_sortIndex = 1900;
        [SortOrder(Item_10_Cnt_sortIndex)]
        [DisplayName(Item_10_Cnt_displayName)]
        public virtual byte Item_10_Cnt {
            get => GetData<byte>(29);
            set {
                if (GetData<byte>(29) == value) return;
                SetData(29, value, nameof(Item_10_Cnt));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_10_Cnt));
            }
        }

        public const string Item_10__displayName = "Item 10 %";
        public const int Item_10__sortIndex = 1950;
        [SortOrder(Item_10__sortIndex)]
        [DisplayName(Item_10__displayName)]
        public virtual byte Item_10_ {
            get => GetData<byte>(39);
            set {
                if (GetData<byte>(39) == value.Clamp((byte) 0, (byte) 100)) return;
                SetData(39, value.Clamp((byte) 0, (byte) 100), nameof(Item_10_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_10_));
            }
        }

        public const string Item_10_Unk_displayName = "Item 10 Unk";
        public const int Item_10_Unk_sortIndex = 2000;
        [SortOrder(Item_10_Unk_sortIndex)]
        [DisplayName(Item_10_Unk_displayName)]
        public virtual byte Item_10_Unk {
            get => GetData<byte>(49);
            set {
                if (GetData<byte>(49) == value) return;
                SetData(49, value, nameof(Item_10_Unk));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_10_Unk));
            }
        }

        public const int lastSortIndex = 2050;
    }
}
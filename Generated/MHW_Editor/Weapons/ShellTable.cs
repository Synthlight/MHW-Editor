
using System.ComponentModel;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Weapons {
    public partial class ShellTable {
        public const uint StructSize = 111;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public const string EncryptionKey = null;

        protected const string Normal_1_Mag_Cnt_displayName = "Normal 1 Mag Cnt";
        protected const int Normal_1_Mag_Cnt_sortIndex = 50;
        [SortOrder(Normal_1_Mag_Cnt_sortIndex)]
        [DisplayName(Normal_1_Mag_Cnt_displayName)]
        public byte Normal_1_Mag_Cnt {
            get => GetData<byte>(0);
            set {
                if (GetData<byte>(0) == value.Clamp((byte) 0, (byte) 10)) return;
                SetData(0, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Normal_1_Mag_Cnt));
            }
        }

        protected const string Normal_1_Rec_Amnt_displayName = "Normal 1 Rec Amnt";
        protected const int Normal_1_Rec_Amnt_sortIndex = 100;
        [SortOrder(Normal_1_Rec_Amnt_sortIndex)]
        [DisplayName(Normal_1_Rec_Amnt_displayName)]
        public byte Normal_1_Rec_Amnt {
            get => GetData<byte>(1);
            set {
                if (GetData<byte>(1) == value) return;
                SetData(1, value);
                OnPropertyChanged(nameof(Normal_1_Rec_Amnt));
            }
        }

        protected const string Normal_1_Rel_Spd_displayName = "Normal 1 Rel Spd";
        protected const int Normal_1_Rel_Spd_sortIndex = 150;
        [SortOrder(Normal_1_Rel_Spd_sortIndex)]
        [DisplayName(Normal_1_Rel_Spd_displayName)]
        public byte Normal_1_Rel_Spd {
            get => GetData<byte>(2);
            set {
                if (GetData<byte>(2) == value) return;
                SetData(2, value);
                OnPropertyChanged(nameof(Normal_1_Rel_Spd));
            }
        }

        protected const string Normal_2_Mag_Cnt_displayName = "Normal 2 Mag Cnt";
        protected const int Normal_2_Mag_Cnt_sortIndex = 200;
        [SortOrder(Normal_2_Mag_Cnt_sortIndex)]
        [DisplayName(Normal_2_Mag_Cnt_displayName)]
        public byte Normal_2_Mag_Cnt {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value.Clamp((byte) 0, (byte) 10)) return;
                SetData(3, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Normal_2_Mag_Cnt));
            }
        }

        protected const string Normal_2_Rec_Amnt_displayName = "Normal 2 Rec Amnt";
        protected const int Normal_2_Rec_Amnt_sortIndex = 250;
        [SortOrder(Normal_2_Rec_Amnt_sortIndex)]
        [DisplayName(Normal_2_Rec_Amnt_displayName)]
        public byte Normal_2_Rec_Amnt {
            get => GetData<byte>(4);
            set {
                if (GetData<byte>(4) == value) return;
                SetData(4, value);
                OnPropertyChanged(nameof(Normal_2_Rec_Amnt));
            }
        }

        protected const string Normal_2_Rel_Spd_displayName = "Normal 2 Rel Spd";
        protected const int Normal_2_Rel_Spd_sortIndex = 300;
        [SortOrder(Normal_2_Rel_Spd_sortIndex)]
        [DisplayName(Normal_2_Rel_Spd_displayName)]
        public byte Normal_2_Rel_Spd {
            get => GetData<byte>(5);
            set {
                if (GetData<byte>(5) == value) return;
                SetData(5, value);
                OnPropertyChanged(nameof(Normal_2_Rel_Spd));
            }
        }

        protected const string Normal_3_Mag_Cnt_displayName = "Normal 3 Mag Cnt";
        protected const int Normal_3_Mag_Cnt_sortIndex = 350;
        [SortOrder(Normal_3_Mag_Cnt_sortIndex)]
        [DisplayName(Normal_3_Mag_Cnt_displayName)]
        public byte Normal_3_Mag_Cnt {
            get => GetData<byte>(6);
            set {
                if (GetData<byte>(6) == value.Clamp((byte) 0, (byte) 10)) return;
                SetData(6, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Normal_3_Mag_Cnt));
            }
        }

        protected const string Normal_3_Rec_Amnt_displayName = "Normal 3 Rec Amnt";
        protected const int Normal_3_Rec_Amnt_sortIndex = 400;
        [SortOrder(Normal_3_Rec_Amnt_sortIndex)]
        [DisplayName(Normal_3_Rec_Amnt_displayName)]
        public byte Normal_3_Rec_Amnt {
            get => GetData<byte>(7);
            set {
                if (GetData<byte>(7) == value) return;
                SetData(7, value);
                OnPropertyChanged(nameof(Normal_3_Rec_Amnt));
            }
        }

        protected const string Normal_3_Rel_Spd_displayName = "Normal 3 Rel Spd";
        protected const int Normal_3_Rel_Spd_sortIndex = 450;
        [SortOrder(Normal_3_Rel_Spd_sortIndex)]
        [DisplayName(Normal_3_Rel_Spd_displayName)]
        public byte Normal_3_Rel_Spd {
            get => GetData<byte>(8);
            set {
                if (GetData<byte>(8) == value) return;
                SetData(8, value);
                OnPropertyChanged(nameof(Normal_3_Rel_Spd));
            }
        }

        protected const string Pierce_1_Mag_Cnt_displayName = "Pierce 1 Mag Cnt";
        protected const int Pierce_1_Mag_Cnt_sortIndex = 500;
        [SortOrder(Pierce_1_Mag_Cnt_sortIndex)]
        [DisplayName(Pierce_1_Mag_Cnt_displayName)]
        public byte Pierce_1_Mag_Cnt {
            get => GetData<byte>(9);
            set {
                if (GetData<byte>(9) == value.Clamp((byte) 0, (byte) 10)) return;
                SetData(9, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Pierce_1_Mag_Cnt));
            }
        }

        protected const string Pierce_1_Rec_Amnt_displayName = "Pierce 1 Rec Amnt";
        protected const int Pierce_1_Rec_Amnt_sortIndex = 550;
        [SortOrder(Pierce_1_Rec_Amnt_sortIndex)]
        [DisplayName(Pierce_1_Rec_Amnt_displayName)]
        public byte Pierce_1_Rec_Amnt {
            get => GetData<byte>(10);
            set {
                if (GetData<byte>(10) == value) return;
                SetData(10, value);
                OnPropertyChanged(nameof(Pierce_1_Rec_Amnt));
            }
        }

        protected const string Pierce_1_Rel_Spd_displayName = "Pierce 1 Rel Spd";
        protected const int Pierce_1_Rel_Spd_sortIndex = 600;
        [SortOrder(Pierce_1_Rel_Spd_sortIndex)]
        [DisplayName(Pierce_1_Rel_Spd_displayName)]
        public byte Pierce_1_Rel_Spd {
            get => GetData<byte>(11);
            set {
                if (GetData<byte>(11) == value) return;
                SetData(11, value);
                OnPropertyChanged(nameof(Pierce_1_Rel_Spd));
            }
        }

        protected const string Pierce_2_Mag_Cnt_displayName = "Pierce 2 Mag Cnt";
        protected const int Pierce_2_Mag_Cnt_sortIndex = 650;
        [SortOrder(Pierce_2_Mag_Cnt_sortIndex)]
        [DisplayName(Pierce_2_Mag_Cnt_displayName)]
        public byte Pierce_2_Mag_Cnt {
            get => GetData<byte>(12);
            set {
                if (GetData<byte>(12) == value.Clamp((byte) 0, (byte) 10)) return;
                SetData(12, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Pierce_2_Mag_Cnt));
            }
        }

        protected const string Pierce_2_Rec_Amnt_displayName = "Pierce 2 Rec Amnt";
        protected const int Pierce_2_Rec_Amnt_sortIndex = 700;
        [SortOrder(Pierce_2_Rec_Amnt_sortIndex)]
        [DisplayName(Pierce_2_Rec_Amnt_displayName)]
        public byte Pierce_2_Rec_Amnt {
            get => GetData<byte>(13);
            set {
                if (GetData<byte>(13) == value) return;
                SetData(13, value);
                OnPropertyChanged(nameof(Pierce_2_Rec_Amnt));
            }
        }

        protected const string Pierce_2_Rel_Spd_displayName = "Pierce 2 Rel Spd";
        protected const int Pierce_2_Rel_Spd_sortIndex = 750;
        [SortOrder(Pierce_2_Rel_Spd_sortIndex)]
        [DisplayName(Pierce_2_Rel_Spd_displayName)]
        public byte Pierce_2_Rel_Spd {
            get => GetData<byte>(14);
            set {
                if (GetData<byte>(14) == value) return;
                SetData(14, value);
                OnPropertyChanged(nameof(Pierce_2_Rel_Spd));
            }
        }

        protected const string Pierce_3_Mag_Cnt_displayName = "Pierce 3 Mag Cnt";
        protected const int Pierce_3_Mag_Cnt_sortIndex = 800;
        [SortOrder(Pierce_3_Mag_Cnt_sortIndex)]
        [DisplayName(Pierce_3_Mag_Cnt_displayName)]
        public byte Pierce_3_Mag_Cnt {
            get => GetData<byte>(15);
            set {
                if (GetData<byte>(15) == value.Clamp((byte) 0, (byte) 10)) return;
                SetData(15, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Pierce_3_Mag_Cnt));
            }
        }

        protected const string Pierce_3_Rec_Amnt_displayName = "Pierce 3 Rec Amnt";
        protected const int Pierce_3_Rec_Amnt_sortIndex = 850;
        [SortOrder(Pierce_3_Rec_Amnt_sortIndex)]
        [DisplayName(Pierce_3_Rec_Amnt_displayName)]
        public byte Pierce_3_Rec_Amnt {
            get => GetData<byte>(16);
            set {
                if (GetData<byte>(16) == value) return;
                SetData(16, value);
                OnPropertyChanged(nameof(Pierce_3_Rec_Amnt));
            }
        }

        protected const string Pierce_3_Rel_Spd_displayName = "Pierce 3 Rel Spd";
        protected const int Pierce_3_Rel_Spd_sortIndex = 900;
        [SortOrder(Pierce_3_Rel_Spd_sortIndex)]
        [DisplayName(Pierce_3_Rel_Spd_displayName)]
        public byte Pierce_3_Rel_Spd {
            get => GetData<byte>(17);
            set {
                if (GetData<byte>(17) == value) return;
                SetData(17, value);
                OnPropertyChanged(nameof(Pierce_3_Rel_Spd));
            }
        }

        protected const string Spread_1_Mag_Cnt_displayName = "Spread 1 Mag Cnt";
        protected const int Spread_1_Mag_Cnt_sortIndex = 950;
        [SortOrder(Spread_1_Mag_Cnt_sortIndex)]
        [DisplayName(Spread_1_Mag_Cnt_displayName)]
        public byte Spread_1_Mag_Cnt {
            get => GetData<byte>(18);
            set {
                if (GetData<byte>(18) == value.Clamp((byte) 0, (byte) 10)) return;
                SetData(18, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Spread_1_Mag_Cnt));
            }
        }

        protected const string Spread_1_Rec_Amnt_displayName = "Spread 1 Rec Amnt";
        protected const int Spread_1_Rec_Amnt_sortIndex = 1000;
        [SortOrder(Spread_1_Rec_Amnt_sortIndex)]
        [DisplayName(Spread_1_Rec_Amnt_displayName)]
        public byte Spread_1_Rec_Amnt {
            get => GetData<byte>(19);
            set {
                if (GetData<byte>(19) == value) return;
                SetData(19, value);
                OnPropertyChanged(nameof(Spread_1_Rec_Amnt));
            }
        }

        protected const string Spread_1_Rel_Spd_displayName = "Spread 1 Rel Spd";
        protected const int Spread_1_Rel_Spd_sortIndex = 1050;
        [SortOrder(Spread_1_Rel_Spd_sortIndex)]
        [DisplayName(Spread_1_Rel_Spd_displayName)]
        public byte Spread_1_Rel_Spd {
            get => GetData<byte>(20);
            set {
                if (GetData<byte>(20) == value) return;
                SetData(20, value);
                OnPropertyChanged(nameof(Spread_1_Rel_Spd));
            }
        }

        protected const string Spread_2_Mag_Cnt_displayName = "Spread 2 Mag Cnt";
        protected const int Spread_2_Mag_Cnt_sortIndex = 1100;
        [SortOrder(Spread_2_Mag_Cnt_sortIndex)]
        [DisplayName(Spread_2_Mag_Cnt_displayName)]
        public byte Spread_2_Mag_Cnt {
            get => GetData<byte>(21);
            set {
                if (GetData<byte>(21) == value.Clamp((byte) 0, (byte) 10)) return;
                SetData(21, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Spread_2_Mag_Cnt));
            }
        }

        protected const string Spread_2_Rec_Amnt_displayName = "Spread 2 Rec Amnt";
        protected const int Spread_2_Rec_Amnt_sortIndex = 1150;
        [SortOrder(Spread_2_Rec_Amnt_sortIndex)]
        [DisplayName(Spread_2_Rec_Amnt_displayName)]
        public byte Spread_2_Rec_Amnt {
            get => GetData<byte>(22);
            set {
                if (GetData<byte>(22) == value) return;
                SetData(22, value);
                OnPropertyChanged(nameof(Spread_2_Rec_Amnt));
            }
        }

        protected const string Spread_2_Rel_Spd_displayName = "Spread 2 Rel Spd";
        protected const int Spread_2_Rel_Spd_sortIndex = 1200;
        [SortOrder(Spread_2_Rel_Spd_sortIndex)]
        [DisplayName(Spread_2_Rel_Spd_displayName)]
        public byte Spread_2_Rel_Spd {
            get => GetData<byte>(23);
            set {
                if (GetData<byte>(23) == value) return;
                SetData(23, value);
                OnPropertyChanged(nameof(Spread_2_Rel_Spd));
            }
        }

        protected const string Spread_3_Mag_Cnt_displayName = "Spread 3 Mag Cnt";
        protected const int Spread_3_Mag_Cnt_sortIndex = 1250;
        [SortOrder(Spread_3_Mag_Cnt_sortIndex)]
        [DisplayName(Spread_3_Mag_Cnt_displayName)]
        public byte Spread_3_Mag_Cnt {
            get => GetData<byte>(24);
            set {
                if (GetData<byte>(24) == value.Clamp((byte) 0, (byte) 10)) return;
                SetData(24, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Spread_3_Mag_Cnt));
            }
        }

        protected const string Spread_3_Rec_Amnt_displayName = "Spread 3 Rec Amnt";
        protected const int Spread_3_Rec_Amnt_sortIndex = 1300;
        [SortOrder(Spread_3_Rec_Amnt_sortIndex)]
        [DisplayName(Spread_3_Rec_Amnt_displayName)]
        public byte Spread_3_Rec_Amnt {
            get => GetData<byte>(25);
            set {
                if (GetData<byte>(25) == value) return;
                SetData(25, value);
                OnPropertyChanged(nameof(Spread_3_Rec_Amnt));
            }
        }

        protected const string Spread_3_Rel_Spd_displayName = "Spread 3 Rel Spd";
        protected const int Spread_3_Rel_Spd_sortIndex = 1350;
        [SortOrder(Spread_3_Rel_Spd_sortIndex)]
        [DisplayName(Spread_3_Rel_Spd_displayName)]
        public byte Spread_3_Rel_Spd {
            get => GetData<byte>(26);
            set {
                if (GetData<byte>(26) == value) return;
                SetData(26, value);
                OnPropertyChanged(nameof(Spread_3_Rel_Spd));
            }
        }

        protected const string Cluster_1_Mag_Cnt_displayName = "Cluster 1 Mag Cnt";
        protected const int Cluster_1_Mag_Cnt_sortIndex = 1400;
        [SortOrder(Cluster_1_Mag_Cnt_sortIndex)]
        [DisplayName(Cluster_1_Mag_Cnt_displayName)]
        public byte Cluster_1_Mag_Cnt {
            get => GetData<byte>(27);
            set {
                if (GetData<byte>(27) == value.Clamp((byte) 0, (byte) 10)) return;
                SetData(27, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Cluster_1_Mag_Cnt));
            }
        }

        protected const string Cluster_1_Rec_Amnt_displayName = "Cluster 1 Rec Amnt";
        protected const int Cluster_1_Rec_Amnt_sortIndex = 1450;
        [SortOrder(Cluster_1_Rec_Amnt_sortIndex)]
        [DisplayName(Cluster_1_Rec_Amnt_displayName)]
        public byte Cluster_1_Rec_Amnt {
            get => GetData<byte>(28);
            set {
                if (GetData<byte>(28) == value) return;
                SetData(28, value);
                OnPropertyChanged(nameof(Cluster_1_Rec_Amnt));
            }
        }

        protected const string Cluster_1_Rel_Spd_displayName = "Cluster 1 Rel Spd";
        protected const int Cluster_1_Rel_Spd_sortIndex = 1500;
        [SortOrder(Cluster_1_Rel_Spd_sortIndex)]
        [DisplayName(Cluster_1_Rel_Spd_displayName)]
        public byte Cluster_1_Rel_Spd {
            get => GetData<byte>(29);
            set {
                if (GetData<byte>(29) == value) return;
                SetData(29, value);
                OnPropertyChanged(nameof(Cluster_1_Rel_Spd));
            }
        }

        protected const string Cluster_2_Mag_Cnt_displayName = "Cluster 2 Mag Cnt";
        protected const int Cluster_2_Mag_Cnt_sortIndex = 1550;
        [SortOrder(Cluster_2_Mag_Cnt_sortIndex)]
        [DisplayName(Cluster_2_Mag_Cnt_displayName)]
        public byte Cluster_2_Mag_Cnt {
            get => GetData<byte>(30);
            set {
                if (GetData<byte>(30) == value.Clamp((byte) 0, (byte) 10)) return;
                SetData(30, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Cluster_2_Mag_Cnt));
            }
        }

        protected const string Cluster_2_Rec_Amnt_displayName = "Cluster 2 Rec Amnt";
        protected const int Cluster_2_Rec_Amnt_sortIndex = 1600;
        [SortOrder(Cluster_2_Rec_Amnt_sortIndex)]
        [DisplayName(Cluster_2_Rec_Amnt_displayName)]
        public byte Cluster_2_Rec_Amnt {
            get => GetData<byte>(31);
            set {
                if (GetData<byte>(31) == value) return;
                SetData(31, value);
                OnPropertyChanged(nameof(Cluster_2_Rec_Amnt));
            }
        }

        protected const string Cluster_2_Rel_Spd_displayName = "Cluster 2 Rel Spd";
        protected const int Cluster_2_Rel_Spd_sortIndex = 1650;
        [SortOrder(Cluster_2_Rel_Spd_sortIndex)]
        [DisplayName(Cluster_2_Rel_Spd_displayName)]
        public byte Cluster_2_Rel_Spd {
            get => GetData<byte>(32);
            set {
                if (GetData<byte>(32) == value) return;
                SetData(32, value);
                OnPropertyChanged(nameof(Cluster_2_Rel_Spd));
            }
        }

        protected const string Cluster_3_Mag_Cnt_displayName = "Cluster 3 Mag Cnt";
        protected const int Cluster_3_Mag_Cnt_sortIndex = 1700;
        [SortOrder(Cluster_3_Mag_Cnt_sortIndex)]
        [DisplayName(Cluster_3_Mag_Cnt_displayName)]
        public byte Cluster_3_Mag_Cnt {
            get => GetData<byte>(33);
            set {
                if (GetData<byte>(33) == value.Clamp((byte) 0, (byte) 10)) return;
                SetData(33, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Cluster_3_Mag_Cnt));
            }
        }

        protected const string Cluster_3_Rec_Amnt_displayName = "Cluster 3 Rec Amnt";
        protected const int Cluster_3_Rec_Amnt_sortIndex = 1750;
        [SortOrder(Cluster_3_Rec_Amnt_sortIndex)]
        [DisplayName(Cluster_3_Rec_Amnt_displayName)]
        public byte Cluster_3_Rec_Amnt {
            get => GetData<byte>(34);
            set {
                if (GetData<byte>(34) == value) return;
                SetData(34, value);
                OnPropertyChanged(nameof(Cluster_3_Rec_Amnt));
            }
        }

        protected const string Cluster_3_Rel_Spd_displayName = "Cluster 3 Rel Spd";
        protected const int Cluster_3_Rel_Spd_sortIndex = 1800;
        [SortOrder(Cluster_3_Rel_Spd_sortIndex)]
        [DisplayName(Cluster_3_Rel_Spd_displayName)]
        public byte Cluster_3_Rel_Spd {
            get => GetData<byte>(35);
            set {
                if (GetData<byte>(35) == value) return;
                SetData(35, value);
                OnPropertyChanged(nameof(Cluster_3_Rel_Spd));
            }
        }

        protected const string Wyvern_Mag_Cnt_displayName = "Wyvern Mag Cnt";
        protected const int Wyvern_Mag_Cnt_sortIndex = 1850;
        [SortOrder(Wyvern_Mag_Cnt_sortIndex)]
        [DisplayName(Wyvern_Mag_Cnt_displayName)]
        public byte Wyvern_Mag_Cnt {
            get => GetData<byte>(36);
            set {
                if (GetData<byte>(36) == value.Clamp((byte) 0, (byte) 10)) return;
                SetData(36, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Wyvern_Mag_Cnt));
            }
        }

        protected const string Wyvern_Rec_Amnt_displayName = "Wyvern Rec Amnt";
        protected const int Wyvern_Rec_Amnt_sortIndex = 1900;
        [SortOrder(Wyvern_Rec_Amnt_sortIndex)]
        [DisplayName(Wyvern_Rec_Amnt_displayName)]
        public byte Wyvern_Rec_Amnt {
            get => GetData<byte>(37);
            set {
                if (GetData<byte>(37) == value) return;
                SetData(37, value);
                OnPropertyChanged(nameof(Wyvern_Rec_Amnt));
            }
        }

        protected const string Wyvern_Rel_Spd_displayName = "Wyvern Rel Spd";
        protected const int Wyvern_Rel_Spd_sortIndex = 1950;
        [SortOrder(Wyvern_Rel_Spd_sortIndex)]
        [DisplayName(Wyvern_Rel_Spd_displayName)]
        public byte Wyvern_Rel_Spd {
            get => GetData<byte>(38);
            set {
                if (GetData<byte>(38) == value) return;
                SetData(38, value);
                OnPropertyChanged(nameof(Wyvern_Rel_Spd));
            }
        }

        protected const string Sticky_1_Mag_Cnt_displayName = "Sticky 1 Mag Cnt";
        protected const int Sticky_1_Mag_Cnt_sortIndex = 2000;
        [SortOrder(Sticky_1_Mag_Cnt_sortIndex)]
        [DisplayName(Sticky_1_Mag_Cnt_displayName)]
        public byte Sticky_1_Mag_Cnt {
            get => GetData<byte>(39);
            set {
                if (GetData<byte>(39) == value.Clamp((byte) 0, (byte) 10)) return;
                SetData(39, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Sticky_1_Mag_Cnt));
            }
        }

        protected const string Sticky_1_Rec_Amnt_displayName = "Sticky 1 Rec Amnt";
        protected const int Sticky_1_Rec_Amnt_sortIndex = 2050;
        [SortOrder(Sticky_1_Rec_Amnt_sortIndex)]
        [DisplayName(Sticky_1_Rec_Amnt_displayName)]
        public byte Sticky_1_Rec_Amnt {
            get => GetData<byte>(40);
            set {
                if (GetData<byte>(40) == value) return;
                SetData(40, value);
                OnPropertyChanged(nameof(Sticky_1_Rec_Amnt));
            }
        }

        protected const string Sticky_1_Rel_Spd_displayName = "Sticky 1 Rel Spd";
        protected const int Sticky_1_Rel_Spd_sortIndex = 2100;
        [SortOrder(Sticky_1_Rel_Spd_sortIndex)]
        [DisplayName(Sticky_1_Rel_Spd_displayName)]
        public byte Sticky_1_Rel_Spd {
            get => GetData<byte>(41);
            set {
                if (GetData<byte>(41) == value) return;
                SetData(41, value);
                OnPropertyChanged(nameof(Sticky_1_Rel_Spd));
            }
        }

        protected const string Sticky_2_Mag_Cnt_displayName = "Sticky 2 Mag Cnt";
        protected const int Sticky_2_Mag_Cnt_sortIndex = 2150;
        [SortOrder(Sticky_2_Mag_Cnt_sortIndex)]
        [DisplayName(Sticky_2_Mag_Cnt_displayName)]
        public byte Sticky_2_Mag_Cnt {
            get => GetData<byte>(42);
            set {
                if (GetData<byte>(42) == value.Clamp((byte) 0, (byte) 10)) return;
                SetData(42, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Sticky_2_Mag_Cnt));
            }
        }

        protected const string Sticky_2_Rec_Amnt_displayName = "Sticky 2 Rec Amnt";
        protected const int Sticky_2_Rec_Amnt_sortIndex = 2200;
        [SortOrder(Sticky_2_Rec_Amnt_sortIndex)]
        [DisplayName(Sticky_2_Rec_Amnt_displayName)]
        public byte Sticky_2_Rec_Amnt {
            get => GetData<byte>(43);
            set {
                if (GetData<byte>(43) == value) return;
                SetData(43, value);
                OnPropertyChanged(nameof(Sticky_2_Rec_Amnt));
            }
        }

        protected const string Sticky_2_Rel_Spd_displayName = "Sticky 2 Rel Spd";
        protected const int Sticky_2_Rel_Spd_sortIndex = 2250;
        [SortOrder(Sticky_2_Rel_Spd_sortIndex)]
        [DisplayName(Sticky_2_Rel_Spd_displayName)]
        public byte Sticky_2_Rel_Spd {
            get => GetData<byte>(44);
            set {
                if (GetData<byte>(44) == value) return;
                SetData(44, value);
                OnPropertyChanged(nameof(Sticky_2_Rel_Spd));
            }
        }

        protected const string Sticky_3_Mag_Cnt_displayName = "Sticky 3 Mag Cnt";
        protected const int Sticky_3_Mag_Cnt_sortIndex = 2300;
        [SortOrder(Sticky_3_Mag_Cnt_sortIndex)]
        [DisplayName(Sticky_3_Mag_Cnt_displayName)]
        public byte Sticky_3_Mag_Cnt {
            get => GetData<byte>(45);
            set {
                if (GetData<byte>(45) == value.Clamp((byte) 0, (byte) 10)) return;
                SetData(45, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Sticky_3_Mag_Cnt));
            }
        }

        protected const string Sticky_3_Rec_Amnt_displayName = "Sticky 3 Rec Amnt";
        protected const int Sticky_3_Rec_Amnt_sortIndex = 2350;
        [SortOrder(Sticky_3_Rec_Amnt_sortIndex)]
        [DisplayName(Sticky_3_Rec_Amnt_displayName)]
        public byte Sticky_3_Rec_Amnt {
            get => GetData<byte>(46);
            set {
                if (GetData<byte>(46) == value) return;
                SetData(46, value);
                OnPropertyChanged(nameof(Sticky_3_Rec_Amnt));
            }
        }

        protected const string Sticky_3_Rel_Spd_displayName = "Sticky 3 Rel Spd";
        protected const int Sticky_3_Rel_Spd_sortIndex = 2400;
        [SortOrder(Sticky_3_Rel_Spd_sortIndex)]
        [DisplayName(Sticky_3_Rel_Spd_displayName)]
        public byte Sticky_3_Rel_Spd {
            get => GetData<byte>(47);
            set {
                if (GetData<byte>(47) == value) return;
                SetData(47, value);
                OnPropertyChanged(nameof(Sticky_3_Rel_Spd));
            }
        }

        protected const string Slicing_Mag_Cnt_displayName = "Slicing Mag Cnt";
        protected const int Slicing_Mag_Cnt_sortIndex = 2450;
        [SortOrder(Slicing_Mag_Cnt_sortIndex)]
        [DisplayName(Slicing_Mag_Cnt_displayName)]
        public byte Slicing_Mag_Cnt {
            get => GetData<byte>(48);
            set {
                if (GetData<byte>(48) == value.Clamp((byte) 0, (byte) 10)) return;
                SetData(48, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Slicing_Mag_Cnt));
            }
        }

        protected const string Slicing_Rec_Amnt_displayName = "Slicing Rec Amnt";
        protected const int Slicing_Rec_Amnt_sortIndex = 2500;
        [SortOrder(Slicing_Rec_Amnt_sortIndex)]
        [DisplayName(Slicing_Rec_Amnt_displayName)]
        public byte Slicing_Rec_Amnt {
            get => GetData<byte>(49);
            set {
                if (GetData<byte>(49) == value) return;
                SetData(49, value);
                OnPropertyChanged(nameof(Slicing_Rec_Amnt));
            }
        }

        protected const string Slicing_Rel_Spd_displayName = "Slicing Rel Spd";
        protected const int Slicing_Rel_Spd_sortIndex = 2550;
        [SortOrder(Slicing_Rel_Spd_sortIndex)]
        [DisplayName(Slicing_Rel_Spd_displayName)]
        public byte Slicing_Rel_Spd {
            get => GetData<byte>(50);
            set {
                if (GetData<byte>(50) == value) return;
                SetData(50, value);
                OnPropertyChanged(nameof(Slicing_Rel_Spd));
            }
        }

        protected const string Flaming_Mag_Cnt_displayName = "Flaming Mag Cnt";
        protected const int Flaming_Mag_Cnt_sortIndex = 2600;
        [SortOrder(Flaming_Mag_Cnt_sortIndex)]
        [DisplayName(Flaming_Mag_Cnt_displayName)]
        public byte Flaming_Mag_Cnt {
            get => GetData<byte>(51);
            set {
                if (GetData<byte>(51) == value.Clamp((byte) 0, (byte) 10)) return;
                SetData(51, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Flaming_Mag_Cnt));
            }
        }

        protected const string Flaming_Rec_Amnt_displayName = "Flaming Rec Amnt";
        protected const int Flaming_Rec_Amnt_sortIndex = 2650;
        [SortOrder(Flaming_Rec_Amnt_sortIndex)]
        [DisplayName(Flaming_Rec_Amnt_displayName)]
        public byte Flaming_Rec_Amnt {
            get => GetData<byte>(52);
            set {
                if (GetData<byte>(52) == value) return;
                SetData(52, value);
                OnPropertyChanged(nameof(Flaming_Rec_Amnt));
            }
        }

        protected const string Flaming_Rel_Spd_displayName = "Flaming Rel Spd";
        protected const int Flaming_Rel_Spd_sortIndex = 2700;
        [SortOrder(Flaming_Rel_Spd_sortIndex)]
        [DisplayName(Flaming_Rel_Spd_displayName)]
        public byte Flaming_Rel_Spd {
            get => GetData<byte>(53);
            set {
                if (GetData<byte>(53) == value) return;
                SetData(53, value);
                OnPropertyChanged(nameof(Flaming_Rel_Spd));
            }
        }

        protected const string Water_Mag_Cnt_displayName = "Water Mag Cnt";
        protected const int Water_Mag_Cnt_sortIndex = 2750;
        [SortOrder(Water_Mag_Cnt_sortIndex)]
        [DisplayName(Water_Mag_Cnt_displayName)]
        public byte Water_Mag_Cnt {
            get => GetData<byte>(54);
            set {
                if (GetData<byte>(54) == value.Clamp((byte) 0, (byte) 10)) return;
                SetData(54, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Water_Mag_Cnt));
            }
        }

        protected const string Water_Rec_Amnt_displayName = "Water Rec Amnt";
        protected const int Water_Rec_Amnt_sortIndex = 2800;
        [SortOrder(Water_Rec_Amnt_sortIndex)]
        [DisplayName(Water_Rec_Amnt_displayName)]
        public byte Water_Rec_Amnt {
            get => GetData<byte>(55);
            set {
                if (GetData<byte>(55) == value) return;
                SetData(55, value);
                OnPropertyChanged(nameof(Water_Rec_Amnt));
            }
        }

        protected const string Water_Rel_Spd_displayName = "Water Rel Spd";
        protected const int Water_Rel_Spd_sortIndex = 2850;
        [SortOrder(Water_Rel_Spd_sortIndex)]
        [DisplayName(Water_Rel_Spd_displayName)]
        public byte Water_Rel_Spd {
            get => GetData<byte>(56);
            set {
                if (GetData<byte>(56) == value) return;
                SetData(56, value);
                OnPropertyChanged(nameof(Water_Rel_Spd));
            }
        }

        protected const string Freeze_Mag_Cnt_displayName = "Freeze Mag Cnt";
        protected const int Freeze_Mag_Cnt_sortIndex = 2900;
        [SortOrder(Freeze_Mag_Cnt_sortIndex)]
        [DisplayName(Freeze_Mag_Cnt_displayName)]
        public byte Freeze_Mag_Cnt {
            get => GetData<byte>(57);
            set {
                if (GetData<byte>(57) == value.Clamp((byte) 0, (byte) 10)) return;
                SetData(57, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Freeze_Mag_Cnt));
            }
        }

        protected const string Freeze_Rec_Amnt_displayName = "Freeze Rec Amnt";
        protected const int Freeze_Rec_Amnt_sortIndex = 2950;
        [SortOrder(Freeze_Rec_Amnt_sortIndex)]
        [DisplayName(Freeze_Rec_Amnt_displayName)]
        public byte Freeze_Rec_Amnt {
            get => GetData<byte>(58);
            set {
                if (GetData<byte>(58) == value) return;
                SetData(58, value);
                OnPropertyChanged(nameof(Freeze_Rec_Amnt));
            }
        }

        protected const string Freeze_Rel_Spd_displayName = "Freeze Rel Spd";
        protected const int Freeze_Rel_Spd_sortIndex = 3000;
        [SortOrder(Freeze_Rel_Spd_sortIndex)]
        [DisplayName(Freeze_Rel_Spd_displayName)]
        public byte Freeze_Rel_Spd {
            get => GetData<byte>(59);
            set {
                if (GetData<byte>(59) == value) return;
                SetData(59, value);
                OnPropertyChanged(nameof(Freeze_Rel_Spd));
            }
        }

        protected const string Thunder_Mag_Cnt_displayName = "Thunder Mag Cnt";
        protected const int Thunder_Mag_Cnt_sortIndex = 3050;
        [SortOrder(Thunder_Mag_Cnt_sortIndex)]
        [DisplayName(Thunder_Mag_Cnt_displayName)]
        public byte Thunder_Mag_Cnt {
            get => GetData<byte>(60);
            set {
                if (GetData<byte>(60) == value.Clamp((byte) 0, (byte) 10)) return;
                SetData(60, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Thunder_Mag_Cnt));
            }
        }

        protected const string Thunder_Rec_Amnt_displayName = "Thunder Rec Amnt";
        protected const int Thunder_Rec_Amnt_sortIndex = 3100;
        [SortOrder(Thunder_Rec_Amnt_sortIndex)]
        [DisplayName(Thunder_Rec_Amnt_displayName)]
        public byte Thunder_Rec_Amnt {
            get => GetData<byte>(61);
            set {
                if (GetData<byte>(61) == value) return;
                SetData(61, value);
                OnPropertyChanged(nameof(Thunder_Rec_Amnt));
            }
        }

        protected const string Thunder_Rel_Spd_displayName = "Thunder Rel Spd";
        protected const int Thunder_Rel_Spd_sortIndex = 3150;
        [SortOrder(Thunder_Rel_Spd_sortIndex)]
        [DisplayName(Thunder_Rel_Spd_displayName)]
        public byte Thunder_Rel_Spd {
            get => GetData<byte>(62);
            set {
                if (GetData<byte>(62) == value) return;
                SetData(62, value);
                OnPropertyChanged(nameof(Thunder_Rel_Spd));
            }
        }

        protected const string Dragon_Mag_Cnt_displayName = "Dragon Mag Cnt";
        protected const int Dragon_Mag_Cnt_sortIndex = 3200;
        [SortOrder(Dragon_Mag_Cnt_sortIndex)]
        [DisplayName(Dragon_Mag_Cnt_displayName)]
        public byte Dragon_Mag_Cnt {
            get => GetData<byte>(63);
            set {
                if (GetData<byte>(63) == value.Clamp((byte) 0, (byte) 10)) return;
                SetData(63, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Dragon_Mag_Cnt));
            }
        }

        protected const string Dragon_Rec_Amnt_displayName = "Dragon Rec Amnt";
        protected const int Dragon_Rec_Amnt_sortIndex = 3250;
        [SortOrder(Dragon_Rec_Amnt_sortIndex)]
        [DisplayName(Dragon_Rec_Amnt_displayName)]
        public byte Dragon_Rec_Amnt {
            get => GetData<byte>(64);
            set {
                if (GetData<byte>(64) == value) return;
                SetData(64, value);
                OnPropertyChanged(nameof(Dragon_Rec_Amnt));
            }
        }

        protected const string Dragon_Rel_Spd_displayName = "Dragon Rel Spd";
        protected const int Dragon_Rel_Spd_sortIndex = 3300;
        [SortOrder(Dragon_Rel_Spd_sortIndex)]
        [DisplayName(Dragon_Rel_Spd_displayName)]
        public byte Dragon_Rel_Spd {
            get => GetData<byte>(65);
            set {
                if (GetData<byte>(65) == value) return;
                SetData(65, value);
                OnPropertyChanged(nameof(Dragon_Rel_Spd));
            }
        }

        protected const string Poison_1_Mag_Cnt_displayName = "Poison 1 Mag Cnt";
        protected const int Poison_1_Mag_Cnt_sortIndex = 3350;
        [SortOrder(Poison_1_Mag_Cnt_sortIndex)]
        [DisplayName(Poison_1_Mag_Cnt_displayName)]
        public byte Poison_1_Mag_Cnt {
            get => GetData<byte>(66);
            set {
                if (GetData<byte>(66) == value.Clamp((byte) 0, (byte) 10)) return;
                SetData(66, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Poison_1_Mag_Cnt));
            }
        }

        protected const string Poison_1_Rec_Amnt_displayName = "Poison 1 Rec Amnt";
        protected const int Poison_1_Rec_Amnt_sortIndex = 3400;
        [SortOrder(Poison_1_Rec_Amnt_sortIndex)]
        [DisplayName(Poison_1_Rec_Amnt_displayName)]
        public byte Poison_1_Rec_Amnt {
            get => GetData<byte>(67);
            set {
                if (GetData<byte>(67) == value) return;
                SetData(67, value);
                OnPropertyChanged(nameof(Poison_1_Rec_Amnt));
            }
        }

        protected const string Poison_1_Rel_Spd_displayName = "Poison 1 Rel Spd";
        protected const int Poison_1_Rel_Spd_sortIndex = 3450;
        [SortOrder(Poison_1_Rel_Spd_sortIndex)]
        [DisplayName(Poison_1_Rel_Spd_displayName)]
        public byte Poison_1_Rel_Spd {
            get => GetData<byte>(68);
            set {
                if (GetData<byte>(68) == value) return;
                SetData(68, value);
                OnPropertyChanged(nameof(Poison_1_Rel_Spd));
            }
        }

        protected const string Poison_2_Mag_Cnt_displayName = "Poison 2 Mag Cnt";
        protected const int Poison_2_Mag_Cnt_sortIndex = 3500;
        [SortOrder(Poison_2_Mag_Cnt_sortIndex)]
        [DisplayName(Poison_2_Mag_Cnt_displayName)]
        public byte Poison_2_Mag_Cnt {
            get => GetData<byte>(69);
            set {
                if (GetData<byte>(69) == value.Clamp((byte) 0, (byte) 10)) return;
                SetData(69, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Poison_2_Mag_Cnt));
            }
        }

        protected const string Poison_2_Rec_Amnt_displayName = "Poison 2 Rec Amnt";
        protected const int Poison_2_Rec_Amnt_sortIndex = 3550;
        [SortOrder(Poison_2_Rec_Amnt_sortIndex)]
        [DisplayName(Poison_2_Rec_Amnt_displayName)]
        public byte Poison_2_Rec_Amnt {
            get => GetData<byte>(70);
            set {
                if (GetData<byte>(70) == value) return;
                SetData(70, value);
                OnPropertyChanged(nameof(Poison_2_Rec_Amnt));
            }
        }

        protected const string Poison_2_Rel_Spd_displayName = "Poison 2 Rel Spd";
        protected const int Poison_2_Rel_Spd_sortIndex = 3600;
        [SortOrder(Poison_2_Rel_Spd_sortIndex)]
        [DisplayName(Poison_2_Rel_Spd_displayName)]
        public byte Poison_2_Rel_Spd {
            get => GetData<byte>(71);
            set {
                if (GetData<byte>(71) == value) return;
                SetData(71, value);
                OnPropertyChanged(nameof(Poison_2_Rel_Spd));
            }
        }

        protected const string Paralysis_1_Mag_Cnt_displayName = "Paralysis 1 Mag Cnt";
        protected const int Paralysis_1_Mag_Cnt_sortIndex = 3650;
        [SortOrder(Paralysis_1_Mag_Cnt_sortIndex)]
        [DisplayName(Paralysis_1_Mag_Cnt_displayName)]
        public byte Paralysis_1_Mag_Cnt {
            get => GetData<byte>(72);
            set {
                if (GetData<byte>(72) == value.Clamp((byte) 0, (byte) 10)) return;
                SetData(72, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Paralysis_1_Mag_Cnt));
            }
        }

        protected const string Paralysis_1_Rec_Amnt_displayName = "Paralysis 1 Rec Amnt";
        protected const int Paralysis_1_Rec_Amnt_sortIndex = 3700;
        [SortOrder(Paralysis_1_Rec_Amnt_sortIndex)]
        [DisplayName(Paralysis_1_Rec_Amnt_displayName)]
        public byte Paralysis_1_Rec_Amnt {
            get => GetData<byte>(73);
            set {
                if (GetData<byte>(73) == value) return;
                SetData(73, value);
                OnPropertyChanged(nameof(Paralysis_1_Rec_Amnt));
            }
        }

        protected const string Paralysis_1_Rel_Spd_displayName = "Paralysis 1 Rel Spd";
        protected const int Paralysis_1_Rel_Spd_sortIndex = 3750;
        [SortOrder(Paralysis_1_Rel_Spd_sortIndex)]
        [DisplayName(Paralysis_1_Rel_Spd_displayName)]
        public byte Paralysis_1_Rel_Spd {
            get => GetData<byte>(74);
            set {
                if (GetData<byte>(74) == value) return;
                SetData(74, value);
                OnPropertyChanged(nameof(Paralysis_1_Rel_Spd));
            }
        }

        protected const string Paralysis_2_Mag_Cnt_displayName = "Paralysis 2 Mag Cnt";
        protected const int Paralysis_2_Mag_Cnt_sortIndex = 3800;
        [SortOrder(Paralysis_2_Mag_Cnt_sortIndex)]
        [DisplayName(Paralysis_2_Mag_Cnt_displayName)]
        public byte Paralysis_2_Mag_Cnt {
            get => GetData<byte>(75);
            set {
                if (GetData<byte>(75) == value.Clamp((byte) 0, (byte) 10)) return;
                SetData(75, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Paralysis_2_Mag_Cnt));
            }
        }

        protected const string Paralysis_2_Rec_Amnt_displayName = "Paralysis 2 Rec Amnt";
        protected const int Paralysis_2_Rec_Amnt_sortIndex = 3850;
        [SortOrder(Paralysis_2_Rec_Amnt_sortIndex)]
        [DisplayName(Paralysis_2_Rec_Amnt_displayName)]
        public byte Paralysis_2_Rec_Amnt {
            get => GetData<byte>(76);
            set {
                if (GetData<byte>(76) == value) return;
                SetData(76, value);
                OnPropertyChanged(nameof(Paralysis_2_Rec_Amnt));
            }
        }

        protected const string Paralysis_2_Rel_Spd_displayName = "Paralysis 2 Rel Spd";
        protected const int Paralysis_2_Rel_Spd_sortIndex = 3900;
        [SortOrder(Paralysis_2_Rel_Spd_sortIndex)]
        [DisplayName(Paralysis_2_Rel_Spd_displayName)]
        public byte Paralysis_2_Rel_Spd {
            get => GetData<byte>(77);
            set {
                if (GetData<byte>(77) == value) return;
                SetData(77, value);
                OnPropertyChanged(nameof(Paralysis_2_Rel_Spd));
            }
        }

        protected const string Sleep_1_Mag_Cnt_displayName = "Sleep 1 Mag Cnt";
        protected const int Sleep_1_Mag_Cnt_sortIndex = 3950;
        [SortOrder(Sleep_1_Mag_Cnt_sortIndex)]
        [DisplayName(Sleep_1_Mag_Cnt_displayName)]
        public byte Sleep_1_Mag_Cnt {
            get => GetData<byte>(78);
            set {
                if (GetData<byte>(78) == value.Clamp((byte) 0, (byte) 10)) return;
                SetData(78, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Sleep_1_Mag_Cnt));
            }
        }

        protected const string Sleep_1_Rec_Amnt_displayName = "Sleep 1 Rec Amnt";
        protected const int Sleep_1_Rec_Amnt_sortIndex = 4000;
        [SortOrder(Sleep_1_Rec_Amnt_sortIndex)]
        [DisplayName(Sleep_1_Rec_Amnt_displayName)]
        public byte Sleep_1_Rec_Amnt {
            get => GetData<byte>(79);
            set {
                if (GetData<byte>(79) == value) return;
                SetData(79, value);
                OnPropertyChanged(nameof(Sleep_1_Rec_Amnt));
            }
        }

        protected const string Sleep_1_Rel_Spd_displayName = "Sleep 1 Rel Spd";
        protected const int Sleep_1_Rel_Spd_sortIndex = 4050;
        [SortOrder(Sleep_1_Rel_Spd_sortIndex)]
        [DisplayName(Sleep_1_Rel_Spd_displayName)]
        public byte Sleep_1_Rel_Spd {
            get => GetData<byte>(80);
            set {
                if (GetData<byte>(80) == value) return;
                SetData(80, value);
                OnPropertyChanged(nameof(Sleep_1_Rel_Spd));
            }
        }

        protected const string Sleep_2_Mag_Cnt_displayName = "Sleep 2 Mag Cnt";
        protected const int Sleep_2_Mag_Cnt_sortIndex = 4100;
        [SortOrder(Sleep_2_Mag_Cnt_sortIndex)]
        [DisplayName(Sleep_2_Mag_Cnt_displayName)]
        public byte Sleep_2_Mag_Cnt {
            get => GetData<byte>(81);
            set {
                if (GetData<byte>(81) == value.Clamp((byte) 0, (byte) 10)) return;
                SetData(81, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Sleep_2_Mag_Cnt));
            }
        }

        protected const string Sleep_2_Rec_Amnt_displayName = "Sleep 2 Rec Amnt";
        protected const int Sleep_2_Rec_Amnt_sortIndex = 4150;
        [SortOrder(Sleep_2_Rec_Amnt_sortIndex)]
        [DisplayName(Sleep_2_Rec_Amnt_displayName)]
        public byte Sleep_2_Rec_Amnt {
            get => GetData<byte>(82);
            set {
                if (GetData<byte>(82) == value) return;
                SetData(82, value);
                OnPropertyChanged(nameof(Sleep_2_Rec_Amnt));
            }
        }

        protected const string Sleep_2_Rel_Spd_displayName = "Sleep 2 Rel Spd";
        protected const int Sleep_2_Rel_Spd_sortIndex = 4200;
        [SortOrder(Sleep_2_Rel_Spd_sortIndex)]
        [DisplayName(Sleep_2_Rel_Spd_displayName)]
        public byte Sleep_2_Rel_Spd {
            get => GetData<byte>(83);
            set {
                if (GetData<byte>(83) == value) return;
                SetData(83, value);
                OnPropertyChanged(nameof(Sleep_2_Rel_Spd));
            }
        }

        protected const string Exhaust_1_Mag_Cnt_displayName = "Exhaust 1 Mag Cnt";
        protected const int Exhaust_1_Mag_Cnt_sortIndex = 4250;
        [SortOrder(Exhaust_1_Mag_Cnt_sortIndex)]
        [DisplayName(Exhaust_1_Mag_Cnt_displayName)]
        public byte Exhaust_1_Mag_Cnt {
            get => GetData<byte>(84);
            set {
                if (GetData<byte>(84) == value.Clamp((byte) 0, (byte) 10)) return;
                SetData(84, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Exhaust_1_Mag_Cnt));
            }
        }

        protected const string Exhaust_1_Rec_Amnt_displayName = "Exhaust 1 Rec Amnt";
        protected const int Exhaust_1_Rec_Amnt_sortIndex = 4300;
        [SortOrder(Exhaust_1_Rec_Amnt_sortIndex)]
        [DisplayName(Exhaust_1_Rec_Amnt_displayName)]
        public byte Exhaust_1_Rec_Amnt {
            get => GetData<byte>(85);
            set {
                if (GetData<byte>(85) == value) return;
                SetData(85, value);
                OnPropertyChanged(nameof(Exhaust_1_Rec_Amnt));
            }
        }

        protected const string Exhaust_1_Rel_Spd_displayName = "Exhaust 1 Rel Spd";
        protected const int Exhaust_1_Rel_Spd_sortIndex = 4350;
        [SortOrder(Exhaust_1_Rel_Spd_sortIndex)]
        [DisplayName(Exhaust_1_Rel_Spd_displayName)]
        public byte Exhaust_1_Rel_Spd {
            get => GetData<byte>(86);
            set {
                if (GetData<byte>(86) == value) return;
                SetData(86, value);
                OnPropertyChanged(nameof(Exhaust_1_Rel_Spd));
            }
        }

        protected const string Exhaust_2_Mag_Cnt_displayName = "Exhaust 2 Mag Cnt";
        protected const int Exhaust_2_Mag_Cnt_sortIndex = 4400;
        [SortOrder(Exhaust_2_Mag_Cnt_sortIndex)]
        [DisplayName(Exhaust_2_Mag_Cnt_displayName)]
        public byte Exhaust_2_Mag_Cnt {
            get => GetData<byte>(87);
            set {
                if (GetData<byte>(87) == value.Clamp((byte) 0, (byte) 10)) return;
                SetData(87, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Exhaust_2_Mag_Cnt));
            }
        }

        protected const string Exhaust_2_Rec_Amnt_displayName = "Exhaust 2 Rec Amnt";
        protected const int Exhaust_2_Rec_Amnt_sortIndex = 4450;
        [SortOrder(Exhaust_2_Rec_Amnt_sortIndex)]
        [DisplayName(Exhaust_2_Rec_Amnt_displayName)]
        public byte Exhaust_2_Rec_Amnt {
            get => GetData<byte>(88);
            set {
                if (GetData<byte>(88) == value) return;
                SetData(88, value);
                OnPropertyChanged(nameof(Exhaust_2_Rec_Amnt));
            }
        }

        protected const string Exhaust_2_Rel_Spd_displayName = "Exhaust 2 Rel Spd";
        protected const int Exhaust_2_Rel_Spd_sortIndex = 4500;
        [SortOrder(Exhaust_2_Rel_Spd_sortIndex)]
        [DisplayName(Exhaust_2_Rel_Spd_displayName)]
        public byte Exhaust_2_Rel_Spd {
            get => GetData<byte>(89);
            set {
                if (GetData<byte>(89) == value) return;
                SetData(89, value);
                OnPropertyChanged(nameof(Exhaust_2_Rel_Spd));
            }
        }

        protected const string Recover_1_Mag_Cnt_displayName = "Recover 1 Mag Cnt";
        protected const int Recover_1_Mag_Cnt_sortIndex = 4550;
        [SortOrder(Recover_1_Mag_Cnt_sortIndex)]
        [DisplayName(Recover_1_Mag_Cnt_displayName)]
        public byte Recover_1_Mag_Cnt {
            get => GetData<byte>(90);
            set {
                if (GetData<byte>(90) == value.Clamp((byte) 0, (byte) 10)) return;
                SetData(90, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Recover_1_Mag_Cnt));
            }
        }

        protected const string Recover_1_Rec_Amnt_displayName = "Recover 1 Rec Amnt";
        protected const int Recover_1_Rec_Amnt_sortIndex = 4600;
        [SortOrder(Recover_1_Rec_Amnt_sortIndex)]
        [DisplayName(Recover_1_Rec_Amnt_displayName)]
        public byte Recover_1_Rec_Amnt {
            get => GetData<byte>(91);
            set {
                if (GetData<byte>(91) == value) return;
                SetData(91, value);
                OnPropertyChanged(nameof(Recover_1_Rec_Amnt));
            }
        }

        protected const string Recover_1_Rel_Spd_displayName = "Recover 1 Rel Spd";
        protected const int Recover_1_Rel_Spd_sortIndex = 4650;
        [SortOrder(Recover_1_Rel_Spd_sortIndex)]
        [DisplayName(Recover_1_Rel_Spd_displayName)]
        public byte Recover_1_Rel_Spd {
            get => GetData<byte>(92);
            set {
                if (GetData<byte>(92) == value) return;
                SetData(92, value);
                OnPropertyChanged(nameof(Recover_1_Rel_Spd));
            }
        }

        protected const string Recover_2_Mag_Cnt_displayName = "Recover 2 Mag Cnt";
        protected const int Recover_2_Mag_Cnt_sortIndex = 4700;
        [SortOrder(Recover_2_Mag_Cnt_sortIndex)]
        [DisplayName(Recover_2_Mag_Cnt_displayName)]
        public byte Recover_2_Mag_Cnt {
            get => GetData<byte>(93);
            set {
                if (GetData<byte>(93) == value.Clamp((byte) 0, (byte) 10)) return;
                SetData(93, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Recover_2_Mag_Cnt));
            }
        }

        protected const string Recover_2_Rec_Amnt_displayName = "Recover 2 Rec Amnt";
        protected const int Recover_2_Rec_Amnt_sortIndex = 4750;
        [SortOrder(Recover_2_Rec_Amnt_sortIndex)]
        [DisplayName(Recover_2_Rec_Amnt_displayName)]
        public byte Recover_2_Rec_Amnt {
            get => GetData<byte>(94);
            set {
                if (GetData<byte>(94) == value) return;
                SetData(94, value);
                OnPropertyChanged(nameof(Recover_2_Rec_Amnt));
            }
        }

        protected const string Recover_2_Rel_Spd_displayName = "Recover 2 Rel Spd";
        protected const int Recover_2_Rel_Spd_sortIndex = 4800;
        [SortOrder(Recover_2_Rel_Spd_sortIndex)]
        [DisplayName(Recover_2_Rel_Spd_displayName)]
        public byte Recover_2_Rel_Spd {
            get => GetData<byte>(95);
            set {
                if (GetData<byte>(95) == value) return;
                SetData(95, value);
                OnPropertyChanged(nameof(Recover_2_Rel_Spd));
            }
        }

        protected const string Demon_Mag_Cnt_displayName = "Demon Mag Cnt";
        protected const int Demon_Mag_Cnt_sortIndex = 4850;
        [SortOrder(Demon_Mag_Cnt_sortIndex)]
        [DisplayName(Demon_Mag_Cnt_displayName)]
        public byte Demon_Mag_Cnt {
            get => GetData<byte>(96);
            set {
                if (GetData<byte>(96) == value.Clamp((byte) 0, (byte) 10)) return;
                SetData(96, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Demon_Mag_Cnt));
            }
        }

        protected const string Demon_Rec_Amnt_displayName = "Demon Rec Amnt";
        protected const int Demon_Rec_Amnt_sortIndex = 4900;
        [SortOrder(Demon_Rec_Amnt_sortIndex)]
        [DisplayName(Demon_Rec_Amnt_displayName)]
        public byte Demon_Rec_Amnt {
            get => GetData<byte>(97);
            set {
                if (GetData<byte>(97) == value) return;
                SetData(97, value);
                OnPropertyChanged(nameof(Demon_Rec_Amnt));
            }
        }

        protected const string Demon_Rel_Spd_displayName = "Demon Rel Spd";
        protected const int Demon_Rel_Spd_sortIndex = 4950;
        [SortOrder(Demon_Rel_Spd_sortIndex)]
        [DisplayName(Demon_Rel_Spd_displayName)]
        public byte Demon_Rel_Spd {
            get => GetData<byte>(98);
            set {
                if (GetData<byte>(98) == value) return;
                SetData(98, value);
                OnPropertyChanged(nameof(Demon_Rel_Spd));
            }
        }

        protected const string Armor_Mag_Cnt_displayName = "Armor Mag Cnt";
        protected const int Armor_Mag_Cnt_sortIndex = 5000;
        [SortOrder(Armor_Mag_Cnt_sortIndex)]
        [DisplayName(Armor_Mag_Cnt_displayName)]
        public byte Armor_Mag_Cnt {
            get => GetData<byte>(99);
            set {
                if (GetData<byte>(99) == value.Clamp((byte) 0, (byte) 10)) return;
                SetData(99, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Armor_Mag_Cnt));
            }
        }

        protected const string Armor_Rec_Amnt_displayName = "Armor Rec Amnt";
        protected const int Armor_Rec_Amnt_sortIndex = 5050;
        [SortOrder(Armor_Rec_Amnt_sortIndex)]
        [DisplayName(Armor_Rec_Amnt_displayName)]
        public byte Armor_Rec_Amnt {
            get => GetData<byte>(100);
            set {
                if (GetData<byte>(100) == value) return;
                SetData(100, value);
                OnPropertyChanged(nameof(Armor_Rec_Amnt));
            }
        }

        protected const string Armor_Rel_Spd_displayName = "Armor Rel Spd";
        protected const int Armor_Rel_Spd_sortIndex = 5100;
        [SortOrder(Armor_Rel_Spd_sortIndex)]
        [DisplayName(Armor_Rel_Spd_displayName)]
        public byte Armor_Rel_Spd {
            get => GetData<byte>(101);
            set {
                if (GetData<byte>(101) == value) return;
                SetData(101, value);
                OnPropertyChanged(nameof(Armor_Rel_Spd));
            }
        }

        protected const string Tranq_Mag_Cnt_displayName = "Tranq Mag Cnt";
        protected const int Tranq_Mag_Cnt_sortIndex = 5150;
        [SortOrder(Tranq_Mag_Cnt_sortIndex)]
        [DisplayName(Tranq_Mag_Cnt_displayName)]
        public byte Tranq_Mag_Cnt {
            get => GetData<byte>(108);
            set {
                if (GetData<byte>(108) == value.Clamp((byte) 0, (byte) 10)) return;
                SetData(108, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Tranq_Mag_Cnt));
            }
        }

        protected const string Tranq_Rec_Amnt_displayName = "Tranq Rec Amnt";
        protected const int Tranq_Rec_Amnt_sortIndex = 5200;
        [SortOrder(Tranq_Rec_Amnt_sortIndex)]
        [DisplayName(Tranq_Rec_Amnt_displayName)]
        public byte Tranq_Rec_Amnt {
            get => GetData<byte>(109);
            set {
                if (GetData<byte>(109) == value) return;
                SetData(109, value);
                OnPropertyChanged(nameof(Tranq_Rec_Amnt));
            }
        }

        protected const string Tranq_Rel_Spd_displayName = "Tranq Rel Spd";
        protected const int Tranq_Rel_Spd_sortIndex = 5250;
        [SortOrder(Tranq_Rel_Spd_sortIndex)]
        [DisplayName(Tranq_Rel_Spd_displayName)]
        public byte Tranq_Rel_Spd {
            get => GetData<byte>(110);
            set {
                if (GetData<byte>(110) == value) return;
                SetData(110, value);
                OnPropertyChanged(nameof(Tranq_Rel_Spd));
            }
        }
    }
}
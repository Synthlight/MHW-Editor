
using System.ComponentModel;
using MHW_Template;

namespace MHW_Editor.Weapons {
    public partial class ShellTable {
        public const uint StructSize = 111;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        [DisplayName("Normal 1 Mag Cnt")]
        public byte Normal_1_Mag_Cnt {
            get => GetData<byte>(0);
            set {
                SetData(0, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Normal_1_Mag_Cnt));
            }
        }
        [DisplayName("Normal 1 Rec Amnt")]
        public byte Normal_1_Rec_Amnt {
            get => GetData<byte>(1);
            set {
                SetData(1, value);
                OnPropertyChanged(nameof(Normal_1_Rec_Amnt));
            }
        }
        [DisplayName("Normal 1 Rel Spd")]
        public byte Normal_1_Rel_Spd {
            get => GetData<byte>(2);
            set {
                SetData(2, value);
                OnPropertyChanged(nameof(Normal_1_Rel_Spd));
            }
        }
        [DisplayName("Normal 2 Mag Cnt")]
        public byte Normal_2_Mag_Cnt {
            get => GetData<byte>(3);
            set {
                SetData(3, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Normal_2_Mag_Cnt));
            }
        }
        [DisplayName("Normal 2 Rec Amnt")]
        public byte Normal_2_Rec_Amnt {
            get => GetData<byte>(4);
            set {
                SetData(4, value);
                OnPropertyChanged(nameof(Normal_2_Rec_Amnt));
            }
        }
        [DisplayName("Normal 2 Rel Spd")]
        public byte Normal_2_Rel_Spd {
            get => GetData<byte>(5);
            set {
                SetData(5, value);
                OnPropertyChanged(nameof(Normal_2_Rel_Spd));
            }
        }
        [DisplayName("Normal 3 Mag Cnt")]
        public byte Normal_3_Mag_Cnt {
            get => GetData<byte>(6);
            set {
                SetData(6, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Normal_3_Mag_Cnt));
            }
        }
        [DisplayName("Normal 3 Rec Amnt")]
        public byte Normal_3_Rec_Amnt {
            get => GetData<byte>(7);
            set {
                SetData(7, value);
                OnPropertyChanged(nameof(Normal_3_Rec_Amnt));
            }
        }
        [DisplayName("Normal 3 Rel Spd")]
        public byte Normal_3_Rel_Spd {
            get => GetData<byte>(8);
            set {
                SetData(8, value);
                OnPropertyChanged(nameof(Normal_3_Rel_Spd));
            }
        }
        [DisplayName("Pierce 1 Mag Cnt")]
        public byte Pierce_1_Mag_Cnt {
            get => GetData<byte>(9);
            set {
                SetData(9, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Pierce_1_Mag_Cnt));
            }
        }
        [DisplayName("Pierce 1 Rec Amnt")]
        public byte Pierce_1_Rec_Amnt {
            get => GetData<byte>(10);
            set {
                SetData(10, value);
                OnPropertyChanged(nameof(Pierce_1_Rec_Amnt));
            }
        }
        [DisplayName("Pierce 1 Rel Spd")]
        public byte Pierce_1_Rel_Spd {
            get => GetData<byte>(11);
            set {
                SetData(11, value);
                OnPropertyChanged(nameof(Pierce_1_Rel_Spd));
            }
        }
        [DisplayName("Pierce 2 Mag Cnt")]
        public byte Pierce_2_Mag_Cnt {
            get => GetData<byte>(12);
            set {
                SetData(12, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Pierce_2_Mag_Cnt));
            }
        }
        [DisplayName("Pierce 2 Rec Amnt")]
        public byte Pierce_2_Rec_Amnt {
            get => GetData<byte>(13);
            set {
                SetData(13, value);
                OnPropertyChanged(nameof(Pierce_2_Rec_Amnt));
            }
        }
        [DisplayName("Pierce 2 Rel Spd")]
        public byte Pierce_2_Rel_Spd {
            get => GetData<byte>(14);
            set {
                SetData(14, value);
                OnPropertyChanged(nameof(Pierce_2_Rel_Spd));
            }
        }
        [DisplayName("Pierce 3 Mag Cnt")]
        public byte Pierce_3_Mag_Cnt {
            get => GetData<byte>(15);
            set {
                SetData(15, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Pierce_3_Mag_Cnt));
            }
        }
        [DisplayName("Pierce 3 Rec Amnt")]
        public byte Pierce_3_Rec_Amnt {
            get => GetData<byte>(16);
            set {
                SetData(16, value);
                OnPropertyChanged(nameof(Pierce_3_Rec_Amnt));
            }
        }
        [DisplayName("Pierce 3 Rel Spd")]
        public byte Pierce_3_Rel_Spd {
            get => GetData<byte>(17);
            set {
                SetData(17, value);
                OnPropertyChanged(nameof(Pierce_3_Rel_Spd));
            }
        }
        [DisplayName("Spread 1 Mag Cnt")]
        public byte Spread_1_Mag_Cnt {
            get => GetData<byte>(18);
            set {
                SetData(18, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Spread_1_Mag_Cnt));
            }
        }
        [DisplayName("Spread 1 Rec Amnt")]
        public byte Spread_1_Rec_Amnt {
            get => GetData<byte>(19);
            set {
                SetData(19, value);
                OnPropertyChanged(nameof(Spread_1_Rec_Amnt));
            }
        }
        [DisplayName("Spread 1 Rel Spd")]
        public byte Spread_1_Rel_Spd {
            get => GetData<byte>(20);
            set {
                SetData(20, value);
                OnPropertyChanged(nameof(Spread_1_Rel_Spd));
            }
        }
        [DisplayName("Spread 2 Mag Cnt")]
        public byte Spread_2_Mag_Cnt {
            get => GetData<byte>(21);
            set {
                SetData(21, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Spread_2_Mag_Cnt));
            }
        }
        [DisplayName("Spread 2 Rec Amnt")]
        public byte Spread_2_Rec_Amnt {
            get => GetData<byte>(22);
            set {
                SetData(22, value);
                OnPropertyChanged(nameof(Spread_2_Rec_Amnt));
            }
        }
        [DisplayName("Spread 2 Rel Spd")]
        public byte Spread_2_Rel_Spd {
            get => GetData<byte>(23);
            set {
                SetData(23, value);
                OnPropertyChanged(nameof(Spread_2_Rel_Spd));
            }
        }
        [DisplayName("Spread 3 Mag Cnt")]
        public byte Spread_3_Mag_Cnt {
            get => GetData<byte>(24);
            set {
                SetData(24, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Spread_3_Mag_Cnt));
            }
        }
        [DisplayName("Spread 3 Rec Amnt")]
        public byte Spread_3_Rec_Amnt {
            get => GetData<byte>(25);
            set {
                SetData(25, value);
                OnPropertyChanged(nameof(Spread_3_Rec_Amnt));
            }
        }
        [DisplayName("Spread 3 Rel Spd")]
        public byte Spread_3_Rel_Spd {
            get => GetData<byte>(26);
            set {
                SetData(26, value);
                OnPropertyChanged(nameof(Spread_3_Rel_Spd));
            }
        }
        [DisplayName("Cluster 1 Mag Cnt")]
        public byte Cluster_1_Mag_Cnt {
            get => GetData<byte>(27);
            set {
                SetData(27, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Cluster_1_Mag_Cnt));
            }
        }
        [DisplayName("Cluster 1 Rec Amnt")]
        public byte Cluster_1_Rec_Amnt {
            get => GetData<byte>(28);
            set {
                SetData(28, value);
                OnPropertyChanged(nameof(Cluster_1_Rec_Amnt));
            }
        }
        [DisplayName("Cluster 1 Rel Spd")]
        public byte Cluster_1_Rel_Spd {
            get => GetData<byte>(29);
            set {
                SetData(29, value);
                OnPropertyChanged(nameof(Cluster_1_Rel_Spd));
            }
        }
        [DisplayName("Cluster 2 Mag Cnt")]
        public byte Cluster_2_Mag_Cnt {
            get => GetData<byte>(30);
            set {
                SetData(30, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Cluster_2_Mag_Cnt));
            }
        }
        [DisplayName("Cluster 2 Rec Amnt")]
        public byte Cluster_2_Rec_Amnt {
            get => GetData<byte>(31);
            set {
                SetData(31, value);
                OnPropertyChanged(nameof(Cluster_2_Rec_Amnt));
            }
        }
        [DisplayName("Cluster 2 Rel Spd")]
        public byte Cluster_2_Rel_Spd {
            get => GetData<byte>(32);
            set {
                SetData(32, value);
                OnPropertyChanged(nameof(Cluster_2_Rel_Spd));
            }
        }
        [DisplayName("Cluster 3 Mag Cnt")]
        public byte Cluster_3_Mag_Cnt {
            get => GetData<byte>(33);
            set {
                SetData(33, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Cluster_3_Mag_Cnt));
            }
        }
        [DisplayName("Cluster 3 Rec Amnt")]
        public byte Cluster_3_Rec_Amnt {
            get => GetData<byte>(34);
            set {
                SetData(34, value);
                OnPropertyChanged(nameof(Cluster_3_Rec_Amnt));
            }
        }
        [DisplayName("Cluster 3 Rel Spd")]
        public byte Cluster_3_Rel_Spd {
            get => GetData<byte>(35);
            set {
                SetData(35, value);
                OnPropertyChanged(nameof(Cluster_3_Rel_Spd));
            }
        }
        [DisplayName("Wyvern Mag Cnt")]
        public byte Wyvern_Mag_Cnt {
            get => GetData<byte>(36);
            set {
                SetData(36, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Wyvern_Mag_Cnt));
            }
        }
        [DisplayName("Wyvern Rec Amnt")]
        public byte Wyvern_Rec_Amnt {
            get => GetData<byte>(37);
            set {
                SetData(37, value);
                OnPropertyChanged(nameof(Wyvern_Rec_Amnt));
            }
        }
        [DisplayName("Wyvern Rel Spd")]
        public byte Wyvern_Rel_Spd {
            get => GetData<byte>(38);
            set {
                SetData(38, value);
                OnPropertyChanged(nameof(Wyvern_Rel_Spd));
            }
        }
        [DisplayName("Sticky 1 Mag Cnt")]
        public byte Sticky_1_Mag_Cnt {
            get => GetData<byte>(39);
            set {
                SetData(39, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Sticky_1_Mag_Cnt));
            }
        }
        [DisplayName("Sticky 1 Rec Amnt")]
        public byte Sticky_1_Rec_Amnt {
            get => GetData<byte>(40);
            set {
                SetData(40, value);
                OnPropertyChanged(nameof(Sticky_1_Rec_Amnt));
            }
        }
        [DisplayName("Sticky 1 Rel Spd")]
        public byte Sticky_1_Rel_Spd {
            get => GetData<byte>(41);
            set {
                SetData(41, value);
                OnPropertyChanged(nameof(Sticky_1_Rel_Spd));
            }
        }
        [DisplayName("Sticky 2 Mag Cnt")]
        public byte Sticky_2_Mag_Cnt {
            get => GetData<byte>(42);
            set {
                SetData(42, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Sticky_2_Mag_Cnt));
            }
        }
        [DisplayName("Sticky 2 Rec Amnt")]
        public byte Sticky_2_Rec_Amnt {
            get => GetData<byte>(43);
            set {
                SetData(43, value);
                OnPropertyChanged(nameof(Sticky_2_Rec_Amnt));
            }
        }
        [DisplayName("Sticky 2 Rel Spd")]
        public byte Sticky_2_Rel_Spd {
            get => GetData<byte>(44);
            set {
                SetData(44, value);
                OnPropertyChanged(nameof(Sticky_2_Rel_Spd));
            }
        }
        [DisplayName("Sticky 3 Mag Cnt")]
        public byte Sticky_3_Mag_Cnt {
            get => GetData<byte>(45);
            set {
                SetData(45, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Sticky_3_Mag_Cnt));
            }
        }
        [DisplayName("Sticky 3 Rec Amnt")]
        public byte Sticky_3_Rec_Amnt {
            get => GetData<byte>(46);
            set {
                SetData(46, value);
                OnPropertyChanged(nameof(Sticky_3_Rec_Amnt));
            }
        }
        [DisplayName("Sticky 3 Rel Spd")]
        public byte Sticky_3_Rel_Spd {
            get => GetData<byte>(47);
            set {
                SetData(47, value);
                OnPropertyChanged(nameof(Sticky_3_Rel_Spd));
            }
        }
        [DisplayName("Slicing Mag Cnt")]
        public byte Slicing_Mag_Cnt {
            get => GetData<byte>(48);
            set {
                SetData(48, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Slicing_Mag_Cnt));
            }
        }
        [DisplayName("Slicing Rec Amnt")]
        public byte Slicing_Rec_Amnt {
            get => GetData<byte>(49);
            set {
                SetData(49, value);
                OnPropertyChanged(nameof(Slicing_Rec_Amnt));
            }
        }
        [DisplayName("Slicing Rel Spd")]
        public byte Slicing_Rel_Spd {
            get => GetData<byte>(50);
            set {
                SetData(50, value);
                OnPropertyChanged(nameof(Slicing_Rel_Spd));
            }
        }
        [DisplayName("Flaming Mag Cnt")]
        public byte Flaming_Mag_Cnt {
            get => GetData<byte>(51);
            set {
                SetData(51, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Flaming_Mag_Cnt));
            }
        }
        [DisplayName("Flaming Rec Amnt")]
        public byte Flaming_Rec_Amnt {
            get => GetData<byte>(52);
            set {
                SetData(52, value);
                OnPropertyChanged(nameof(Flaming_Rec_Amnt));
            }
        }
        [DisplayName("Flaming Rel Spd")]
        public byte Flaming_Rel_Spd {
            get => GetData<byte>(53);
            set {
                SetData(53, value);
                OnPropertyChanged(nameof(Flaming_Rel_Spd));
            }
        }
        [DisplayName("Water Mag Cnt")]
        public byte Water_Mag_Cnt {
            get => GetData<byte>(54);
            set {
                SetData(54, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Water_Mag_Cnt));
            }
        }
        [DisplayName("Water Rec Amnt")]
        public byte Water_Rec_Amnt {
            get => GetData<byte>(55);
            set {
                SetData(55, value);
                OnPropertyChanged(nameof(Water_Rec_Amnt));
            }
        }
        [DisplayName("Water Rel Spd")]
        public byte Water_Rel_Spd {
            get => GetData<byte>(56);
            set {
                SetData(56, value);
                OnPropertyChanged(nameof(Water_Rel_Spd));
            }
        }
        [DisplayName("Freeze Mag Cnt")]
        public byte Freeze_Mag_Cnt {
            get => GetData<byte>(57);
            set {
                SetData(57, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Freeze_Mag_Cnt));
            }
        }
        [DisplayName("Freeze Rec Amnt")]
        public byte Freeze_Rec_Amnt {
            get => GetData<byte>(58);
            set {
                SetData(58, value);
                OnPropertyChanged(nameof(Freeze_Rec_Amnt));
            }
        }
        [DisplayName("Freeze Rel Spd")]
        public byte Freeze_Rel_Spd {
            get => GetData<byte>(59);
            set {
                SetData(59, value);
                OnPropertyChanged(nameof(Freeze_Rel_Spd));
            }
        }
        [DisplayName("Thunder Mag Cnt")]
        public byte Thunder_Mag_Cnt {
            get => GetData<byte>(60);
            set {
                SetData(60, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Thunder_Mag_Cnt));
            }
        }
        [DisplayName("Thunder Rec Amnt")]
        public byte Thunder_Rec_Amnt {
            get => GetData<byte>(61);
            set {
                SetData(61, value);
                OnPropertyChanged(nameof(Thunder_Rec_Amnt));
            }
        }
        [DisplayName("Thunder Rel Spd")]
        public byte Thunder_Rel_Spd {
            get => GetData<byte>(62);
            set {
                SetData(62, value);
                OnPropertyChanged(nameof(Thunder_Rel_Spd));
            }
        }
        [DisplayName("Dragon Mag Cnt")]
        public byte Dragon_Mag_Cnt {
            get => GetData<byte>(63);
            set {
                SetData(63, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Dragon_Mag_Cnt));
            }
        }
        [DisplayName("Dragon Rec Amnt")]
        public byte Dragon_Rec_Amnt {
            get => GetData<byte>(64);
            set {
                SetData(64, value);
                OnPropertyChanged(nameof(Dragon_Rec_Amnt));
            }
        }
        [DisplayName("Dragon Rel Spd")]
        public byte Dragon_Rel_Spd {
            get => GetData<byte>(65);
            set {
                SetData(65, value);
                OnPropertyChanged(nameof(Dragon_Rel_Spd));
            }
        }
        [DisplayName("Poison 1 Mag Cnt")]
        public byte Poison_1_Mag_Cnt {
            get => GetData<byte>(66);
            set {
                SetData(66, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Poison_1_Mag_Cnt));
            }
        }
        [DisplayName("Poison 1 Rec Amnt")]
        public byte Poison_1_Rec_Amnt {
            get => GetData<byte>(67);
            set {
                SetData(67, value);
                OnPropertyChanged(nameof(Poison_1_Rec_Amnt));
            }
        }
        [DisplayName("Poison 1 Rel Spd")]
        public byte Poison_1_Rel_Spd {
            get => GetData<byte>(68);
            set {
                SetData(68, value);
                OnPropertyChanged(nameof(Poison_1_Rel_Spd));
            }
        }
        [DisplayName("Poison 2 Mag Cnt")]
        public byte Poison_2_Mag_Cnt {
            get => GetData<byte>(69);
            set {
                SetData(69, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Poison_2_Mag_Cnt));
            }
        }
        [DisplayName("Poison 2 Rec Amnt")]
        public byte Poison_2_Rec_Amnt {
            get => GetData<byte>(70);
            set {
                SetData(70, value);
                OnPropertyChanged(nameof(Poison_2_Rec_Amnt));
            }
        }
        [DisplayName("Poison 2 Rel Spd")]
        public byte Poison_2_Rel_Spd {
            get => GetData<byte>(71);
            set {
                SetData(71, value);
                OnPropertyChanged(nameof(Poison_2_Rel_Spd));
            }
        }
        [DisplayName("Paralysis 1 Mag Cnt")]
        public byte Paralysis_1_Mag_Cnt {
            get => GetData<byte>(72);
            set {
                SetData(72, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Paralysis_1_Mag_Cnt));
            }
        }
        [DisplayName("Paralysis 1 Rec Amnt")]
        public byte Paralysis_1_Rec_Amnt {
            get => GetData<byte>(73);
            set {
                SetData(73, value);
                OnPropertyChanged(nameof(Paralysis_1_Rec_Amnt));
            }
        }
        [DisplayName("Paralysis 1 Rel Spd")]
        public byte Paralysis_1_Rel_Spd {
            get => GetData<byte>(74);
            set {
                SetData(74, value);
                OnPropertyChanged(nameof(Paralysis_1_Rel_Spd));
            }
        }
        [DisplayName("Paralysis 2 Mag Cnt")]
        public byte Paralysis_2_Mag_Cnt {
            get => GetData<byte>(75);
            set {
                SetData(75, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Paralysis_2_Mag_Cnt));
            }
        }
        [DisplayName("Paralysis 2 Rec Amnt")]
        public byte Paralysis_2_Rec_Amnt {
            get => GetData<byte>(76);
            set {
                SetData(76, value);
                OnPropertyChanged(nameof(Paralysis_2_Rec_Amnt));
            }
        }
        [DisplayName("Paralysis 2 Rel Spd")]
        public byte Paralysis_2_Rel_Spd {
            get => GetData<byte>(77);
            set {
                SetData(77, value);
                OnPropertyChanged(nameof(Paralysis_2_Rel_Spd));
            }
        }
        [DisplayName("Sleep 1 Mag Cnt")]
        public byte Sleep_1_Mag_Cnt {
            get => GetData<byte>(78);
            set {
                SetData(78, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Sleep_1_Mag_Cnt));
            }
        }
        [DisplayName("Sleep 1 Rec Amnt")]
        public byte Sleep_1_Rec_Amnt {
            get => GetData<byte>(79);
            set {
                SetData(79, value);
                OnPropertyChanged(nameof(Sleep_1_Rec_Amnt));
            }
        }
        [DisplayName("Sleep 1 Rel Spd")]
        public byte Sleep_1_Rel_Spd {
            get => GetData<byte>(80);
            set {
                SetData(80, value);
                OnPropertyChanged(nameof(Sleep_1_Rel_Spd));
            }
        }
        [DisplayName("Sleep 2 Mag Cnt")]
        public byte Sleep_2_Mag_Cnt {
            get => GetData<byte>(81);
            set {
                SetData(81, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Sleep_2_Mag_Cnt));
            }
        }
        [DisplayName("Sleep 2 Rec Amnt")]
        public byte Sleep_2_Rec_Amnt {
            get => GetData<byte>(82);
            set {
                SetData(82, value);
                OnPropertyChanged(nameof(Sleep_2_Rec_Amnt));
            }
        }
        [DisplayName("Sleep 2 Rel Spd")]
        public byte Sleep_2_Rel_Spd {
            get => GetData<byte>(83);
            set {
                SetData(83, value);
                OnPropertyChanged(nameof(Sleep_2_Rel_Spd));
            }
        }
        [DisplayName("Exhaust 1 Mag Cnt")]
        public byte Exhaust_1_Mag_Cnt {
            get => GetData<byte>(84);
            set {
                SetData(84, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Exhaust_1_Mag_Cnt));
            }
        }
        [DisplayName("Exhaust 1 Rec Amnt")]
        public byte Exhaust_1_Rec_Amnt {
            get => GetData<byte>(85);
            set {
                SetData(85, value);
                OnPropertyChanged(nameof(Exhaust_1_Rec_Amnt));
            }
        }
        [DisplayName("Exhaust 1 Rel Spd")]
        public byte Exhaust_1_Rel_Spd {
            get => GetData<byte>(86);
            set {
                SetData(86, value);
                OnPropertyChanged(nameof(Exhaust_1_Rel_Spd));
            }
        }
        [DisplayName("Exhaust 2 Mag Cnt")]
        public byte Exhaust_2_Mag_Cnt {
            get => GetData<byte>(87);
            set {
                SetData(87, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Exhaust_2_Mag_Cnt));
            }
        }
        [DisplayName("Exhaust 2 Rec Amnt")]
        public byte Exhaust_2_Rec_Amnt {
            get => GetData<byte>(88);
            set {
                SetData(88, value);
                OnPropertyChanged(nameof(Exhaust_2_Rec_Amnt));
            }
        }
        [DisplayName("Exhaust 2 Rel Spd")]
        public byte Exhaust_2_Rel_Spd {
            get => GetData<byte>(89);
            set {
                SetData(89, value);
                OnPropertyChanged(nameof(Exhaust_2_Rel_Spd));
            }
        }
        [DisplayName("Recover 1 Mag Cnt")]
        public byte Recover_1_Mag_Cnt {
            get => GetData<byte>(90);
            set {
                SetData(90, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Recover_1_Mag_Cnt));
            }
        }
        [DisplayName("Recover 1 Rec Amnt")]
        public byte Recover_1_Rec_Amnt {
            get => GetData<byte>(91);
            set {
                SetData(91, value);
                OnPropertyChanged(nameof(Recover_1_Rec_Amnt));
            }
        }
        [DisplayName("Recover 1 Rel Spd")]
        public byte Recover_1_Rel_Spd {
            get => GetData<byte>(92);
            set {
                SetData(92, value);
                OnPropertyChanged(nameof(Recover_1_Rel_Spd));
            }
        }
        [DisplayName("Recover 2 Mag Cnt")]
        public byte Recover_2_Mag_Cnt {
            get => GetData<byte>(93);
            set {
                SetData(93, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Recover_2_Mag_Cnt));
            }
        }
        [DisplayName("Recover 2 Rec Amnt")]
        public byte Recover_2_Rec_Amnt {
            get => GetData<byte>(94);
            set {
                SetData(94, value);
                OnPropertyChanged(nameof(Recover_2_Rec_Amnt));
            }
        }
        [DisplayName("Recover 2 Rel Spd")]
        public byte Recover_2_Rel_Spd {
            get => GetData<byte>(95);
            set {
                SetData(95, value);
                OnPropertyChanged(nameof(Recover_2_Rel_Spd));
            }
        }
        [DisplayName("Demon Mag Cnt")]
        public byte Demon_Mag_Cnt {
            get => GetData<byte>(96);
            set {
                SetData(96, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Demon_Mag_Cnt));
            }
        }
        [DisplayName("Demon Rec Amnt")]
        public byte Demon_Rec_Amnt {
            get => GetData<byte>(97);
            set {
                SetData(97, value);
                OnPropertyChanged(nameof(Demon_Rec_Amnt));
            }
        }
        [DisplayName("Demon Rel Spd")]
        public byte Demon_Rel_Spd {
            get => GetData<byte>(98);
            set {
                SetData(98, value);
                OnPropertyChanged(nameof(Demon_Rel_Spd));
            }
        }
        [DisplayName("Armor Mag Cnt")]
        public byte Armor_Mag_Cnt {
            get => GetData<byte>(99);
            set {
                SetData(99, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Armor_Mag_Cnt));
            }
        }
        [DisplayName("Armor Rec Amnt")]
        public byte Armor_Rec_Amnt {
            get => GetData<byte>(100);
            set {
                SetData(100, value);
                OnPropertyChanged(nameof(Armor_Rec_Amnt));
            }
        }
        [DisplayName("Armor Rel Spd")]
        public byte Armor_Rel_Spd {
            get => GetData<byte>(101);
            set {
                SetData(101, value);
                OnPropertyChanged(nameof(Armor_Rel_Spd));
            }
        }
        [DisplayName("Tranq Mag Cnt")]
        public byte Tranq_Mag_Cnt {
            get => GetData<byte>(108);
            set {
                SetData(108, value.Clamp((byte) 0, (byte) 10));
                OnPropertyChanged(nameof(Tranq_Mag_Cnt));
            }
        }
        [DisplayName("Tranq Rec Amnt")]
        public byte Tranq_Rec_Amnt {
            get => GetData<byte>(109);
            set {
                SetData(109, value);
                OnPropertyChanged(nameof(Tranq_Rec_Amnt));
            }
        }
        [DisplayName("Tranq Rel Spd")]
        public byte Tranq_Rel_Spd {
            get => GetData<byte>(110);
            set {
                SetData(110, value);
                OnPropertyChanged(nameof(Tranq_Rel_Spd));
            }
        }
    }
}
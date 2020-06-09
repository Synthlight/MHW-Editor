using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.PlData {
    public partial class PlPlayerParam {
        public override string EncryptionKey => "j1P15gEkgVa7NdFxiqwCPitykHctY2nZPjSaElvqb0eSwcLO1cOlTqqv";

        public partial class Header : MhwStructItem {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Header";

            protected char[] PLP_raw;
            public const string PLP_displayName = "PLP";
            public const int PLP_sortIndex = 50;
            [SortOrder(PLP_sortIndex)]
            [DisplayName(PLP_displayName)]
            [IsReadOnly]
            public virtual string PLP {
                get => (string) new string(PLP_raw);
                set {
                    if ((string) new string(PLP_raw) == value) return;
                    PLP_raw = (char[]) value.ToCharArray(0, 3);
                    OnPropertyChanged(nameof(PLP));
                }
            }

            protected uint Magic_1_raw;
            public const string Magic_1_displayName = "Magic 1";
            public const int Magic_1_sortIndex = 100;
            [SortOrder(Magic_1_sortIndex)]
            [DisplayName(Magic_1_displayName)]
            [IsReadOnly]
            public virtual uint Magic_1 {
                get => Magic_1_raw;
                set {
                    if (Magic_1_raw == value) return;
                    Magic_1_raw = value;
                    OnPropertyChanged(nameof(Magic_1));
                }
            }

            public const int lastSortIndex = 150;

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Header LoadData(BinaryReader reader, ulong i) {
                var data = new Header();
                data.Index = i;
                data.PLP_raw = reader.ReadChars(4);
                data.Magic_1_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(PLP_raw);
                writer.Write(Magic_1_raw);
            }
        }

        public partial class Player_Params_1_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView> {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Player Params (1)";

            protected float Gravity_raw;
            public const string Gravity_displayName = "Gravity";
            public const int Gravity_sortIndex = 50;
            [SortOrder(Gravity_sortIndex)]
            [DisplayName(Gravity_displayName)]
            public virtual float Gravity {
                get => Gravity_raw;
                set {
                    if (Gravity_raw == value) return;
                    Gravity_raw = value;
                    OnPropertyChanged(nameof(Gravity));
                }
            }

            protected float Gravity_Speed_Rate_raw;
            public const string Gravity_Speed_Rate_displayName = "Gravity Speed Rate";
            public const int Gravity_Speed_Rate_sortIndex = 100;
            [SortOrder(Gravity_Speed_Rate_sortIndex)]
            [DisplayName(Gravity_Speed_Rate_displayName)]
            public virtual float Gravity_Speed_Rate {
                get => Gravity_Speed_Rate_raw;
                set {
                    if (Gravity_Speed_Rate_raw == value) return;
                    Gravity_Speed_Rate_raw = value;
                    OnPropertyChanged(nameof(Gravity_Speed_Rate));
                }
            }

            protected float Unk_1_raw;
            public const string Unk_1_displayName = "Unk 1";
            public const int Unk_1_sortIndex = 150;
            [SortOrder(Unk_1_sortIndex)]
            [DisplayName(Unk_1_displayName)]
            public virtual float Unk_1 {
                get => Unk_1_raw;
                set {
                    if (Unk_1_raw == value) return;
                    Unk_1_raw = value;
                    OnPropertyChanged(nameof(Unk_1));
                }
            }

            protected float Unk_2_raw;
            public const string Unk_2_displayName = "Unk 2";
            public const int Unk_2_sortIndex = 200;
            [SortOrder(Unk_2_sortIndex)]
            [DisplayName(Unk_2_displayName)]
            public virtual float Unk_2 {
                get => Unk_2_raw;
                set {
                    if (Unk_2_raw == value) return;
                    Unk_2_raw = value;
                    OnPropertyChanged(nameof(Unk_2));
                }
            }

            protected float Unk_3_raw;
            public const string Unk_3_displayName = "Unk 3";
            public const int Unk_3_sortIndex = 250;
            [SortOrder(Unk_3_sortIndex)]
            [DisplayName(Unk_3_displayName)]
            public virtual float Unk_3 {
                get => Unk_3_raw;
                set {
                    if (Unk_3_raw == value) return;
                    Unk_3_raw = value;
                    OnPropertyChanged(nameof(Unk_3));
                }
            }

            protected float Unk_4_raw;
            public const string Unk_4_displayName = "Unk 4";
            public const int Unk_4_sortIndex = 300;
            [SortOrder(Unk_4_sortIndex)]
            [DisplayName(Unk_4_displayName)]
            public virtual float Unk_4 {
                get => Unk_4_raw;
                set {
                    if (Unk_4_raw == value) return;
                    Unk_4_raw = value;
                    OnPropertyChanged(nameof(Unk_4));
                }
            }

            protected float Unk_5_raw;
            public const string Unk_5_displayName = "Unk 5";
            public const int Unk_5_sortIndex = 350;
            [SortOrder(Unk_5_sortIndex)]
            [DisplayName(Unk_5_displayName)]
            public virtual float Unk_5 {
                get => Unk_5_raw;
                set {
                    if (Unk_5_raw == value) return;
                    Unk_5_raw = value;
                    OnPropertyChanged(nameof(Unk_5));
                }
            }

            protected float Unk_6_raw;
            public const string Unk_6_displayName = "Unk 6";
            public const int Unk_6_sortIndex = 400;
            [SortOrder(Unk_6_sortIndex)]
            [DisplayName(Unk_6_displayName)]
            public virtual float Unk_6 {
                get => Unk_6_raw;
                set {
                    if (Unk_6_raw == value) return;
                    Unk_6_raw = value;
                    OnPropertyChanged(nameof(Unk_6));
                }
            }

            protected float Unk_7_raw;
            public const string Unk_7_displayName = "Unk 7";
            public const int Unk_7_sortIndex = 450;
            [SortOrder(Unk_7_sortIndex)]
            [DisplayName(Unk_7_displayName)]
            public virtual float Unk_7 {
                get => Unk_7_raw;
                set {
                    if (Unk_7_raw == value) return;
                    Unk_7_raw = value;
                    OnPropertyChanged(nameof(Unk_7));
                }
            }

            protected float Unk_8_raw;
            public const string Unk_8_displayName = "Unk 8";
            public const int Unk_8_sortIndex = 500;
            [SortOrder(Unk_8_sortIndex)]
            [DisplayName(Unk_8_displayName)]
            public virtual float Unk_8 {
                get => Unk_8_raw;
                set {
                    if (Unk_8_raw == value) return;
                    Unk_8_raw = value;
                    OnPropertyChanged(nameof(Unk_8));
                }
            }

            protected float Unk_9_raw;
            public const string Unk_9_displayName = "Unk 9";
            public const int Unk_9_sortIndex = 550;
            [SortOrder(Unk_9_sortIndex)]
            [DisplayName(Unk_9_displayName)]
            public virtual float Unk_9 {
                get => Unk_9_raw;
                set {
                    if (Unk_9_raw == value) return;
                    Unk_9_raw = value;
                    OnPropertyChanged(nameof(Unk_9));
                }
            }

            protected float Unk_10_raw;
            public const string Unk_10_displayName = "Unk 10";
            public const int Unk_10_sortIndex = 600;
            [SortOrder(Unk_10_sortIndex)]
            [DisplayName(Unk_10_displayName)]
            public virtual float Unk_10 {
                get => Unk_10_raw;
                set {
                    if (Unk_10_raw == value) return;
                    Unk_10_raw = value;
                    OnPropertyChanged(nameof(Unk_10));
                }
            }

            protected float Unk_11_raw;
            public const string Unk_11_displayName = "Unk 11";
            public const int Unk_11_sortIndex = 650;
            [SortOrder(Unk_11_sortIndex)]
            [DisplayName(Unk_11_displayName)]
            public virtual float Unk_11 {
                get => Unk_11_raw;
                set {
                    if (Unk_11_raw == value) return;
                    Unk_11_raw = value;
                    OnPropertyChanged(nameof(Unk_11));
                }
            }

            protected float Unk_12_raw;
            public const string Unk_12_displayName = "Unk 12";
            public const int Unk_12_sortIndex = 700;
            [SortOrder(Unk_12_sortIndex)]
            [DisplayName(Unk_12_displayName)]
            public virtual float Unk_12 {
                get => Unk_12_raw;
                set {
                    if (Unk_12_raw == value) return;
                    Unk_12_raw = value;
                    OnPropertyChanged(nameof(Unk_12));
                }
            }

            protected float Unk_13_raw;
            public const string Unk_13_displayName = "Unk 13";
            public const int Unk_13_sortIndex = 750;
            [SortOrder(Unk_13_sortIndex)]
            [DisplayName(Unk_13_displayName)]
            public virtual float Unk_13 {
                get => Unk_13_raw;
                set {
                    if (Unk_13_raw == value) return;
                    Unk_13_raw = value;
                    OnPropertyChanged(nameof(Unk_13));
                }
            }

            protected float Unk_14_raw;
            public const string Unk_14_displayName = "Unk 14";
            public const int Unk_14_sortIndex = 800;
            [SortOrder(Unk_14_sortIndex)]
            [DisplayName(Unk_14_displayName)]
            public virtual float Unk_14 {
                get => Unk_14_raw;
                set {
                    if (Unk_14_raw == value) return;
                    Unk_14_raw = value;
                    OnPropertyChanged(nameof(Unk_14));
                }
            }

            protected float Unk_15_raw;
            public const string Unk_15_displayName = "Unk 15";
            public const int Unk_15_sortIndex = 850;
            [SortOrder(Unk_15_sortIndex)]
            [DisplayName(Unk_15_displayName)]
            public virtual float Unk_15 {
                get => Unk_15_raw;
                set {
                    if (Unk_15_raw == value) return;
                    Unk_15_raw = value;
                    OnPropertyChanged(nameof(Unk_15));
                }
            }

            protected float Unk_16_raw;
            public const string Unk_16_displayName = "Unk 16";
            public const int Unk_16_sortIndex = 900;
            [SortOrder(Unk_16_sortIndex)]
            [DisplayName(Unk_16_displayName)]
            public virtual float Unk_16 {
                get => Unk_16_raw;
                set {
                    if (Unk_16_raw == value) return;
                    Unk_16_raw = value;
                    OnPropertyChanged(nameof(Unk_16));
                }
            }

            protected float Unk_17_raw;
            public const string Unk_17_displayName = "Unk 17";
            public const int Unk_17_sortIndex = 950;
            [SortOrder(Unk_17_sortIndex)]
            [DisplayName(Unk_17_displayName)]
            public virtual float Unk_17 {
                get => Unk_17_raw;
                set {
                    if (Unk_17_raw == value) return;
                    Unk_17_raw = value;
                    OnPropertyChanged(nameof(Unk_17));
                }
            }

            protected float Unk_18_raw;
            public const string Unk_18_displayName = "Unk 18";
            public const int Unk_18_sortIndex = 1000;
            [SortOrder(Unk_18_sortIndex)]
            [DisplayName(Unk_18_displayName)]
            public virtual float Unk_18 {
                get => Unk_18_raw;
                set {
                    if (Unk_18_raw == value) return;
                    Unk_18_raw = value;
                    OnPropertyChanged(nameof(Unk_18));
                }
            }

            protected float Unk_19_raw;
            public const string Unk_19_displayName = "Unk 19";
            public const int Unk_19_sortIndex = 1050;
            [SortOrder(Unk_19_sortIndex)]
            [DisplayName(Unk_19_displayName)]
            public virtual float Unk_19 {
                get => Unk_19_raw;
                set {
                    if (Unk_19_raw == value) return;
                    Unk_19_raw = value;
                    OnPropertyChanged(nameof(Unk_19));
                }
            }

            protected float Unk_20_raw;
            public const string Unk_20_displayName = "Unk 20";
            public const int Unk_20_sortIndex = 1100;
            [SortOrder(Unk_20_sortIndex)]
            [DisplayName(Unk_20_displayName)]
            public virtual float Unk_20 {
                get => Unk_20_raw;
                set {
                    if (Unk_20_raw == value) return;
                    Unk_20_raw = value;
                    OnPropertyChanged(nameof(Unk_20));
                }
            }

            protected float Unk_21_raw;
            public const string Unk_21_displayName = "Unk 21";
            public const int Unk_21_sortIndex = 1150;
            [SortOrder(Unk_21_sortIndex)]
            [DisplayName(Unk_21_displayName)]
            public virtual float Unk_21 {
                get => Unk_21_raw;
                set {
                    if (Unk_21_raw == value) return;
                    Unk_21_raw = value;
                    OnPropertyChanged(nameof(Unk_21));
                }
            }

            protected float Unk_22_raw;
            public const string Unk_22_displayName = "Unk 22";
            public const int Unk_22_sortIndex = 1200;
            [SortOrder(Unk_22_sortIndex)]
            [DisplayName(Unk_22_displayName)]
            public virtual float Unk_22 {
                get => Unk_22_raw;
                set {
                    if (Unk_22_raw == value) return;
                    Unk_22_raw = value;
                    OnPropertyChanged(nameof(Unk_22));
                }
            }

            protected float Unk_23_raw;
            public const string Unk_23_displayName = "Unk 23";
            public const int Unk_23_sortIndex = 1250;
            [SortOrder(Unk_23_sortIndex)]
            [DisplayName(Unk_23_displayName)]
            public virtual float Unk_23 {
                get => Unk_23_raw;
                set {
                    if (Unk_23_raw == value) return;
                    Unk_23_raw = value;
                    OnPropertyChanged(nameof(Unk_23));
                }
            }

            protected float Unk_24_raw;
            public const string Unk_24_displayName = "Unk 24";
            public const int Unk_24_sortIndex = 1300;
            [SortOrder(Unk_24_sortIndex)]
            [DisplayName(Unk_24_displayName)]
            public virtual float Unk_24 {
                get => Unk_24_raw;
                set {
                    if (Unk_24_raw == value) return;
                    Unk_24_raw = value;
                    OnPropertyChanged(nameof(Unk_24));
                }
            }

            protected float Unk_25_raw;
            public const string Unk_25_displayName = "Unk 25";
            public const int Unk_25_sortIndex = 1350;
            [SortOrder(Unk_25_sortIndex)]
            [DisplayName(Unk_25_displayName)]
            public virtual float Unk_25 {
                get => Unk_25_raw;
                set {
                    if (Unk_25_raw == value) return;
                    Unk_25_raw = value;
                    OnPropertyChanged(nameof(Unk_25));
                }
            }

            protected float Unk_26_raw;
            public const string Unk_26_displayName = "Unk 26";
            public const int Unk_26_sortIndex = 1400;
            [SortOrder(Unk_26_sortIndex)]
            [DisplayName(Unk_26_displayName)]
            public virtual float Unk_26 {
                get => Unk_26_raw;
                set {
                    if (Unk_26_raw == value) return;
                    Unk_26_raw = value;
                    OnPropertyChanged(nameof(Unk_26));
                }
            }

            protected float Unk_27_raw;
            public const string Unk_27_displayName = "Unk 27";
            public const int Unk_27_sortIndex = 1450;
            [SortOrder(Unk_27_sortIndex)]
            [DisplayName(Unk_27_displayName)]
            public virtual float Unk_27 {
                get => Unk_27_raw;
                set {
                    if (Unk_27_raw == value) return;
                    Unk_27_raw = value;
                    OnPropertyChanged(nameof(Unk_27));
                }
            }

            protected float Unk_28_raw;
            public const string Unk_28_displayName = "Unk 28";
            public const int Unk_28_sortIndex = 1500;
            [SortOrder(Unk_28_sortIndex)]
            [DisplayName(Unk_28_displayName)]
            public virtual float Unk_28 {
                get => Unk_28_raw;
                set {
                    if (Unk_28_raw == value) return;
                    Unk_28_raw = value;
                    OnPropertyChanged(nameof(Unk_28));
                }
            }

            protected float Unk_29_raw;
            public const string Unk_29_displayName = "Unk 29";
            public const int Unk_29_sortIndex = 1550;
            [SortOrder(Unk_29_sortIndex)]
            [DisplayName(Unk_29_displayName)]
            public virtual float Unk_29 {
                get => Unk_29_raw;
                set {
                    if (Unk_29_raw == value) return;
                    Unk_29_raw = value;
                    OnPropertyChanged(nameof(Unk_29));
                }
            }

            protected float Unk_30_raw;
            public const string Unk_30_displayName = "Unk 30";
            public const int Unk_30_sortIndex = 1600;
            [SortOrder(Unk_30_sortIndex)]
            [DisplayName(Unk_30_displayName)]
            public virtual float Unk_30 {
                get => Unk_30_raw;
                set {
                    if (Unk_30_raw == value) return;
                    Unk_30_raw = value;
                    OnPropertyChanged(nameof(Unk_30));
                }
            }

            protected float Unk_31_raw;
            public const string Unk_31_displayName = "Unk 31";
            public const int Unk_31_sortIndex = 1650;
            [SortOrder(Unk_31_sortIndex)]
            [DisplayName(Unk_31_displayName)]
            public virtual float Unk_31 {
                get => Unk_31_raw;
                set {
                    if (Unk_31_raw == value) return;
                    Unk_31_raw = value;
                    OnPropertyChanged(nameof(Unk_31));
                }
            }

            protected float Unk_32_raw;
            public const string Unk_32_displayName = "Unk 32";
            public const int Unk_32_sortIndex = 1700;
            [SortOrder(Unk_32_sortIndex)]
            [DisplayName(Unk_32_displayName)]
            public virtual float Unk_32 {
                get => Unk_32_raw;
                set {
                    if (Unk_32_raw == value) return;
                    Unk_32_raw = value;
                    OnPropertyChanged(nameof(Unk_32));
                }
            }

            protected float Unk_33_raw;
            public const string Unk_33_displayName = "Unk 33";
            public const int Unk_33_sortIndex = 1750;
            [SortOrder(Unk_33_sortIndex)]
            [DisplayName(Unk_33_displayName)]
            public virtual float Unk_33 {
                get => Unk_33_raw;
                set {
                    if (Unk_33_raw == value) return;
                    Unk_33_raw = value;
                    OnPropertyChanged(nameof(Unk_33));
                }
            }

            protected float Unk_34_raw;
            public const string Unk_34_displayName = "Unk 34";
            public const int Unk_34_sortIndex = 1800;
            [SortOrder(Unk_34_sortIndex)]
            [DisplayName(Unk_34_displayName)]
            public virtual float Unk_34 {
                get => Unk_34_raw;
                set {
                    if (Unk_34_raw == value) return;
                    Unk_34_raw = value;
                    OnPropertyChanged(nameof(Unk_34));
                }
            }

            protected uint Unk_35_raw;
            public const string Unk_35_displayName = "Unk 35";
            public const int Unk_35_sortIndex = 1850;
            [SortOrder(Unk_35_sortIndex)]
            [DisplayName(Unk_35_displayName)]
            public virtual uint Unk_35 {
                get => Unk_35_raw;
                set {
                    if (Unk_35_raw == value) return;
                    Unk_35_raw = value;
                    OnPropertyChanged(nameof(Unk_35));
                }
            }

            protected uint Unk_36_raw;
            public const string Unk_36_displayName = "Unk 36";
            public const int Unk_36_sortIndex = 1900;
            [SortOrder(Unk_36_sortIndex)]
            [DisplayName(Unk_36_displayName)]
            public virtual uint Unk_36 {
                get => Unk_36_raw;
                set {
                    if (Unk_36_raw == value) return;
                    Unk_36_raw = value;
                    OnPropertyChanged(nameof(Unk_36));
                }
            }

            protected float Unk_37_raw;
            public const string Unk_37_displayName = "Unk 37";
            public const int Unk_37_sortIndex = 1950;
            [SortOrder(Unk_37_sortIndex)]
            [DisplayName(Unk_37_displayName)]
            public virtual float Unk_37 {
                get => Unk_37_raw;
                set {
                    if (Unk_37_raw == value) return;
                    Unk_37_raw = value;
                    OnPropertyChanged(nameof(Unk_37));
                }
            }

            protected float Unk_38_raw;
            public const string Unk_38_displayName = "Unk 38";
            public const int Unk_38_sortIndex = 2000;
            [SortOrder(Unk_38_sortIndex)]
            [DisplayName(Unk_38_displayName)]
            public virtual float Unk_38 {
                get => Unk_38_raw;
                set {
                    if (Unk_38_raw == value) return;
                    Unk_38_raw = value;
                    OnPropertyChanged(nameof(Unk_38));
                }
            }

            protected float Unk_39_raw;
            public const string Unk_39_displayName = "Unk 39";
            public const int Unk_39_sortIndex = 2050;
            [SortOrder(Unk_39_sortIndex)]
            [DisplayName(Unk_39_displayName)]
            public virtual float Unk_39 {
                get => Unk_39_raw;
                set {
                    if (Unk_39_raw == value) return;
                    Unk_39_raw = value;
                    OnPropertyChanged(nameof(Unk_39));
                }
            }

            protected float Unk_40_raw;
            public const string Unk_40_displayName = "Unk 40";
            public const int Unk_40_sortIndex = 2100;
            [SortOrder(Unk_40_sortIndex)]
            [DisplayName(Unk_40_displayName)]
            public virtual float Unk_40 {
                get => Unk_40_raw;
                set {
                    if (Unk_40_raw == value) return;
                    Unk_40_raw = value;
                    OnPropertyChanged(nameof(Unk_40));
                }
            }

            protected float Unk_41_raw;
            public const string Unk_41_displayName = "Unk 41";
            public const int Unk_41_sortIndex = 2150;
            [SortOrder(Unk_41_sortIndex)]
            [DisplayName(Unk_41_displayName)]
            public virtual float Unk_41 {
                get => Unk_41_raw;
                set {
                    if (Unk_41_raw == value) return;
                    Unk_41_raw = value;
                    OnPropertyChanged(nameof(Unk_41));
                }
            }

            protected float Unk_42_raw;
            public const string Unk_42_displayName = "Unk 42";
            public const int Unk_42_sortIndex = 2200;
            [SortOrder(Unk_42_sortIndex)]
            [DisplayName(Unk_42_displayName)]
            public virtual float Unk_42 {
                get => Unk_42_raw;
                set {
                    if (Unk_42_raw == value) return;
                    Unk_42_raw = value;
                    OnPropertyChanged(nameof(Unk_42));
                }
            }

            protected float Unk_43_raw;
            public const string Unk_43_displayName = "Unk 43";
            public const int Unk_43_sortIndex = 2250;
            [SortOrder(Unk_43_sortIndex)]
            [DisplayName(Unk_43_displayName)]
            public virtual float Unk_43 {
                get => Unk_43_raw;
                set {
                    if (Unk_43_raw == value) return;
                    Unk_43_raw = value;
                    OnPropertyChanged(nameof(Unk_43));
                }
            }

            protected float Unk_44_raw;
            public const string Unk_44_displayName = "Unk 44";
            public const int Unk_44_sortIndex = 2300;
            [SortOrder(Unk_44_sortIndex)]
            [DisplayName(Unk_44_displayName)]
            public virtual float Unk_44 {
                get => Unk_44_raw;
                set {
                    if (Unk_44_raw == value) return;
                    Unk_44_raw = value;
                    OnPropertyChanged(nameof(Unk_44));
                }
            }

            protected float Unk_45_raw;
            public const string Unk_45_displayName = "Unk 45";
            public const int Unk_45_sortIndex = 2350;
            [SortOrder(Unk_45_sortIndex)]
            [DisplayName(Unk_45_displayName)]
            public virtual float Unk_45 {
                get => Unk_45_raw;
                set {
                    if (Unk_45_raw == value) return;
                    Unk_45_raw = value;
                    OnPropertyChanged(nameof(Unk_45));
                }
            }

            protected float Unk_46_raw;
            public const string Unk_46_displayName = "Unk 46";
            public const int Unk_46_sortIndex = 2400;
            [SortOrder(Unk_46_sortIndex)]
            [DisplayName(Unk_46_displayName)]
            public virtual float Unk_46 {
                get => Unk_46_raw;
                set {
                    if (Unk_46_raw == value) return;
                    Unk_46_raw = value;
                    OnPropertyChanged(nameof(Unk_46));
                }
            }

            protected float Unk_47_raw;
            public const string Unk_47_displayName = "Unk 47";
            public const int Unk_47_sortIndex = 2450;
            [SortOrder(Unk_47_sortIndex)]
            [DisplayName(Unk_47_displayName)]
            public virtual float Unk_47 {
                get => Unk_47_raw;
                set {
                    if (Unk_47_raw == value) return;
                    Unk_47_raw = value;
                    OnPropertyChanged(nameof(Unk_47));
                }
            }

            protected float Unk_48_raw;
            public const string Unk_48_displayName = "Unk 48";
            public const int Unk_48_sortIndex = 2500;
            [SortOrder(Unk_48_sortIndex)]
            [DisplayName(Unk_48_displayName)]
            public virtual float Unk_48 {
                get => Unk_48_raw;
                set {
                    if (Unk_48_raw == value) return;
                    Unk_48_raw = value;
                    OnPropertyChanged(nameof(Unk_48));
                }
            }

            protected float Unk_49_raw;
            public const string Unk_49_displayName = "Unk 49";
            public const int Unk_49_sortIndex = 2550;
            [SortOrder(Unk_49_sortIndex)]
            [DisplayName(Unk_49_displayName)]
            public virtual float Unk_49 {
                get => Unk_49_raw;
                set {
                    if (Unk_49_raw == value) return;
                    Unk_49_raw = value;
                    OnPropertyChanged(nameof(Unk_49));
                }
            }

            protected float Unk_50_raw;
            public const string Unk_50_displayName = "Unk 50";
            public const int Unk_50_sortIndex = 2600;
            [SortOrder(Unk_50_sortIndex)]
            [DisplayName(Unk_50_displayName)]
            public virtual float Unk_50 {
                get => Unk_50_raw;
                set {
                    if (Unk_50_raw == value) return;
                    Unk_50_raw = value;
                    OnPropertyChanged(nameof(Unk_50));
                }
            }

            protected float Unk_51_raw;
            public const string Unk_51_displayName = "Unk 51";
            public const int Unk_51_sortIndex = 2650;
            [SortOrder(Unk_51_sortIndex)]
            [DisplayName(Unk_51_displayName)]
            public virtual float Unk_51 {
                get => Unk_51_raw;
                set {
                    if (Unk_51_raw == value) return;
                    Unk_51_raw = value;
                    OnPropertyChanged(nameof(Unk_51));
                }
            }

            protected float Unk_52_raw;
            public const string Unk_52_displayName = "Unk 52";
            public const int Unk_52_sortIndex = 2700;
            [SortOrder(Unk_52_sortIndex)]
            [DisplayName(Unk_52_displayName)]
            public virtual float Unk_52 {
                get => Unk_52_raw;
                set {
                    if (Unk_52_raw == value) return;
                    Unk_52_raw = value;
                    OnPropertyChanged(nameof(Unk_52));
                }
            }

            protected float Unk_53_raw;
            public const string Unk_53_displayName = "Unk 53";
            public const int Unk_53_sortIndex = 2750;
            [SortOrder(Unk_53_sortIndex)]
            [DisplayName(Unk_53_displayName)]
            public virtual float Unk_53 {
                get => Unk_53_raw;
                set {
                    if (Unk_53_raw == value) return;
                    Unk_53_raw = value;
                    OnPropertyChanged(nameof(Unk_53));
                }
            }

            protected float Unk_54_raw;
            public const string Unk_54_displayName = "Unk 54";
            public const int Unk_54_sortIndex = 2800;
            [SortOrder(Unk_54_sortIndex)]
            [DisplayName(Unk_54_displayName)]
            public virtual float Unk_54 {
                get => Unk_54_raw;
                set {
                    if (Unk_54_raw == value) return;
                    Unk_54_raw = value;
                    OnPropertyChanged(nameof(Unk_54));
                }
            }

            protected float Unk_55_raw;
            public const string Unk_55_displayName = "Unk 55";
            public const int Unk_55_sortIndex = 2850;
            [SortOrder(Unk_55_sortIndex)]
            [DisplayName(Unk_55_displayName)]
            public virtual float Unk_55 {
                get => Unk_55_raw;
                set {
                    if (Unk_55_raw == value) return;
                    Unk_55_raw = value;
                    OnPropertyChanged(nameof(Unk_55));
                }
            }

            public const int lastSortIndex = 2900;

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Player_Params_1_ LoadData(BinaryReader reader, ulong i) {
                var data = new Player_Params_1_();
                data.Index = i;
                data.Gravity_raw = reader.ReadSingle();
                data.Gravity_Speed_Rate_raw = reader.ReadSingle();
                data.Unk_1_raw = reader.ReadSingle();
                data.Unk_2_raw = reader.ReadSingle();
                data.Unk_3_raw = reader.ReadSingle();
                data.Unk_4_raw = reader.ReadSingle();
                data.Unk_5_raw = reader.ReadSingle();
                data.Unk_6_raw = reader.ReadSingle();
                data.Unk_7_raw = reader.ReadSingle();
                data.Unk_8_raw = reader.ReadSingle();
                data.Unk_9_raw = reader.ReadSingle();
                data.Unk_10_raw = reader.ReadSingle();
                data.Unk_11_raw = reader.ReadSingle();
                data.Unk_12_raw = reader.ReadSingle();
                data.Unk_13_raw = reader.ReadSingle();
                data.Unk_14_raw = reader.ReadSingle();
                data.Unk_15_raw = reader.ReadSingle();
                data.Unk_16_raw = reader.ReadSingle();
                data.Unk_17_raw = reader.ReadSingle();
                data.Unk_18_raw = reader.ReadSingle();
                data.Unk_19_raw = reader.ReadSingle();
                data.Unk_20_raw = reader.ReadSingle();
                data.Unk_21_raw = reader.ReadSingle();
                data.Unk_22_raw = reader.ReadSingle();
                data.Unk_23_raw = reader.ReadSingle();
                data.Unk_24_raw = reader.ReadSingle();
                data.Unk_25_raw = reader.ReadSingle();
                data.Unk_26_raw = reader.ReadSingle();
                data.Unk_27_raw = reader.ReadSingle();
                data.Unk_28_raw = reader.ReadSingle();
                data.Unk_29_raw = reader.ReadSingle();
                data.Unk_30_raw = reader.ReadSingle();
                data.Unk_31_raw = reader.ReadSingle();
                data.Unk_32_raw = reader.ReadSingle();
                data.Unk_33_raw = reader.ReadSingle();
                data.Unk_34_raw = reader.ReadSingle();
                data.Unk_35_raw = reader.ReadUInt32();
                data.Unk_36_raw = reader.ReadUInt32();
                data.Unk_37_raw = reader.ReadSingle();
                data.Unk_38_raw = reader.ReadSingle();
                data.Unk_39_raw = reader.ReadSingle();
                data.Unk_40_raw = reader.ReadSingle();
                data.Unk_41_raw = reader.ReadSingle();
                data.Unk_42_raw = reader.ReadSingle();
                data.Unk_43_raw = reader.ReadSingle();
                data.Unk_44_raw = reader.ReadSingle();
                data.Unk_45_raw = reader.ReadSingle();
                data.Unk_46_raw = reader.ReadSingle();
                data.Unk_47_raw = reader.ReadSingle();
                data.Unk_48_raw = reader.ReadSingle();
                data.Unk_49_raw = reader.ReadSingle();
                data.Unk_50_raw = reader.ReadSingle();
                data.Unk_51_raw = reader.ReadSingle();
                data.Unk_52_raw = reader.ReadSingle();
                data.Unk_53_raw = reader.ReadSingle();
                data.Unk_54_raw = reader.ReadSingle();
                data.Unk_55_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Gravity_raw);
                writer.Write(Gravity_Speed_Rate_raw);
                writer.Write(Unk_1_raw);
                writer.Write(Unk_2_raw);
                writer.Write(Unk_3_raw);
                writer.Write(Unk_4_raw);
                writer.Write(Unk_5_raw);
                writer.Write(Unk_6_raw);
                writer.Write(Unk_7_raw);
                writer.Write(Unk_8_raw);
                writer.Write(Unk_9_raw);
                writer.Write(Unk_10_raw);
                writer.Write(Unk_11_raw);
                writer.Write(Unk_12_raw);
                writer.Write(Unk_13_raw);
                writer.Write(Unk_14_raw);
                writer.Write(Unk_15_raw);
                writer.Write(Unk_16_raw);
                writer.Write(Unk_17_raw);
                writer.Write(Unk_18_raw);
                writer.Write(Unk_19_raw);
                writer.Write(Unk_20_raw);
                writer.Write(Unk_21_raw);
                writer.Write(Unk_22_raw);
                writer.Write(Unk_23_raw);
                writer.Write(Unk_24_raw);
                writer.Write(Unk_25_raw);
                writer.Write(Unk_26_raw);
                writer.Write(Unk_27_raw);
                writer.Write(Unk_28_raw);
                writer.Write(Unk_29_raw);
                writer.Write(Unk_30_raw);
                writer.Write(Unk_31_raw);
                writer.Write(Unk_32_raw);
                writer.Write(Unk_33_raw);
                writer.Write(Unk_34_raw);
                writer.Write(Unk_35_raw);
                writer.Write(Unk_36_raw);
                writer.Write(Unk_37_raw);
                writer.Write(Unk_38_raw);
                writer.Write(Unk_39_raw);
                writer.Write(Unk_40_raw);
                writer.Write(Unk_41_raw);
                writer.Write(Unk_42_raw);
                writer.Write(Unk_43_raw);
                writer.Write(Unk_44_raw);
                writer.Write(Unk_45_raw);
                writer.Write(Unk_46_raw);
                writer.Write(Unk_47_raw);
                writer.Write(Unk_48_raw);
                writer.Write(Unk_49_raw);
                writer.Write(Unk_50_raw);
                writer.Write(Unk_51_raw);
                writer.Write(Unk_52_raw);
                writer.Write(Unk_53_raw);
                writer.Write(Unk_54_raw);
                writer.Write(Unk_55_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Gravity", "Gravity"),
                    new MultiStructItemCustomView(this, "Gravity Speed Rate", "Gravity_Speed_Rate"),
                    new MultiStructItemCustomView(this, "Unk 1", "Unk_1"),
                    new MultiStructItemCustomView(this, "Unk 2", "Unk_2"),
                    new MultiStructItemCustomView(this, "Unk 3", "Unk_3"),
                    new MultiStructItemCustomView(this, "Unk 4", "Unk_4"),
                    new MultiStructItemCustomView(this, "Unk 5", "Unk_5"),
                    new MultiStructItemCustomView(this, "Unk 6", "Unk_6"),
                    new MultiStructItemCustomView(this, "Unk 7", "Unk_7"),
                    new MultiStructItemCustomView(this, "Unk 8", "Unk_8"),
                    new MultiStructItemCustomView(this, "Unk 9", "Unk_9"),
                    new MultiStructItemCustomView(this, "Unk 10", "Unk_10"),
                    new MultiStructItemCustomView(this, "Unk 11", "Unk_11"),
                    new MultiStructItemCustomView(this, "Unk 12", "Unk_12"),
                    new MultiStructItemCustomView(this, "Unk 13", "Unk_13"),
                    new MultiStructItemCustomView(this, "Unk 14", "Unk_14"),
                    new MultiStructItemCustomView(this, "Unk 15", "Unk_15"),
                    new MultiStructItemCustomView(this, "Unk 16", "Unk_16"),
                    new MultiStructItemCustomView(this, "Unk 17", "Unk_17"),
                    new MultiStructItemCustomView(this, "Unk 18", "Unk_18"),
                    new MultiStructItemCustomView(this, "Unk 19", "Unk_19"),
                    new MultiStructItemCustomView(this, "Unk 20", "Unk_20"),
                    new MultiStructItemCustomView(this, "Unk 21", "Unk_21"),
                    new MultiStructItemCustomView(this, "Unk 22", "Unk_22"),
                    new MultiStructItemCustomView(this, "Unk 23", "Unk_23"),
                    new MultiStructItemCustomView(this, "Unk 24", "Unk_24"),
                    new MultiStructItemCustomView(this, "Unk 25", "Unk_25"),
                    new MultiStructItemCustomView(this, "Unk 26", "Unk_26"),
                    new MultiStructItemCustomView(this, "Unk 27", "Unk_27"),
                    new MultiStructItemCustomView(this, "Unk 28", "Unk_28"),
                    new MultiStructItemCustomView(this, "Unk 29", "Unk_29"),
                    new MultiStructItemCustomView(this, "Unk 30", "Unk_30"),
                    new MultiStructItemCustomView(this, "Unk 31", "Unk_31"),
                    new MultiStructItemCustomView(this, "Unk 32", "Unk_32"),
                    new MultiStructItemCustomView(this, "Unk 33", "Unk_33"),
                    new MultiStructItemCustomView(this, "Unk 34", "Unk_34"),
                    new MultiStructItemCustomView(this, "Unk 35", "Unk_35"),
                    new MultiStructItemCustomView(this, "Unk 36", "Unk_36"),
                    new MultiStructItemCustomView(this, "Unk 37", "Unk_37"),
                    new MultiStructItemCustomView(this, "Unk 38", "Unk_38"),
                    new MultiStructItemCustomView(this, "Unk 39", "Unk_39"),
                    new MultiStructItemCustomView(this, "Unk 40", "Unk_40"),
                    new MultiStructItemCustomView(this, "Unk 41", "Unk_41"),
                    new MultiStructItemCustomView(this, "Unk 42", "Unk_42"),
                    new MultiStructItemCustomView(this, "Unk 43", "Unk_43"),
                    new MultiStructItemCustomView(this, "Unk 44", "Unk_44"),
                    new MultiStructItemCustomView(this, "Unk 45", "Unk_45"),
                    new MultiStructItemCustomView(this, "Unk 46", "Unk_46"),
                    new MultiStructItemCustomView(this, "Unk 47", "Unk_47"),
                    new MultiStructItemCustomView(this, "Unk 48", "Unk_48"),
                    new MultiStructItemCustomView(this, "Unk 49", "Unk_49"),
                    new MultiStructItemCustomView(this, "Unk 50", "Unk_50"),
                    new MultiStructItemCustomView(this, "Unk 51", "Unk_51"),
                    new MultiStructItemCustomView(this, "Unk 52", "Unk_52"),
                    new MultiStructItemCustomView(this, "Unk 53", "Unk_53"),
                    new MultiStructItemCustomView(this, "Unk 54", "Unk_54"),
                    new MultiStructItemCustomView(this, "Unk 55", "Unk_55"),
                };
            }
        }

        public partial class Player_Params_2_Unk_Array_1_ : MhwStructItem {
            public const ulong FixedSizeCount = 12;
            public const string GridName = "Player Params (2) - Unk Array (1)";

            protected byte Unk_1_raw;
            public const string Unk_1_displayName = "Unk 1";
            public const int Unk_1_sortIndex = 50;
            [SortOrder(Unk_1_sortIndex)]
            [DisplayName(Unk_1_displayName)]
            public virtual byte Unk_1 {
                get => Unk_1_raw;
                set {
                    if (Unk_1_raw == value) return;
                    Unk_1_raw = value;
                    OnPropertyChanged(nameof(Unk_1));
                }
            }

            protected ushort Unk_2_raw;
            public const string Unk_2_displayName = "Unk 2";
            public const int Unk_2_sortIndex = 100;
            [SortOrder(Unk_2_sortIndex)]
            [DisplayName(Unk_2_displayName)]
            public virtual ushort Unk_2 {
                get => Unk_2_raw;
                set {
                    if (Unk_2_raw == value) return;
                    Unk_2_raw = value;
                    OnPropertyChanged(nameof(Unk_2));
                }
            }

            protected ushort Unk_3_raw;
            public const string Unk_3_displayName = "Unk 3";
            public const int Unk_3_sortIndex = 150;
            [SortOrder(Unk_3_sortIndex)]
            [DisplayName(Unk_3_displayName)]
            public virtual ushort Unk_3 {
                get => Unk_3_raw;
                set {
                    if (Unk_3_raw == value) return;
                    Unk_3_raw = value;
                    OnPropertyChanged(nameof(Unk_3));
                }
            }

            protected float Unk_4_raw;
            public const string Unk_4_displayName = "Unk 4";
            public const int Unk_4_sortIndex = 200;
            [SortOrder(Unk_4_sortIndex)]
            [DisplayName(Unk_4_displayName)]
            public virtual float Unk_4 {
                get => Unk_4_raw;
                set {
                    if (Unk_4_raw == value) return;
                    Unk_4_raw = value;
                    OnPropertyChanged(nameof(Unk_4));
                }
            }

            protected ushort Unk_5_raw;
            public const string Unk_5_displayName = "Unk 5";
            public const int Unk_5_sortIndex = 250;
            [SortOrder(Unk_5_sortIndex)]
            [DisplayName(Unk_5_displayName)]
            public virtual ushort Unk_5 {
                get => Unk_5_raw;
                set {
                    if (Unk_5_raw == value) return;
                    Unk_5_raw = value;
                    OnPropertyChanged(nameof(Unk_5));
                }
            }

            public const int lastSortIndex = 300;

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
                var count = 12UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Player_Params_2_Unk_Array_1_ LoadData(BinaryReader reader, ulong i) {
                var data = new Player_Params_2_Unk_Array_1_();
                data.Index = i;
                data.Unk_1_raw = reader.ReadByte();
                data.Unk_2_raw = reader.ReadUInt16();
                data.Unk_3_raw = reader.ReadUInt16();
                data.Unk_4_raw = reader.ReadSingle();
                data.Unk_5_raw = reader.ReadUInt16();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_1_raw);
                writer.Write(Unk_2_raw);
                writer.Write(Unk_3_raw);
                writer.Write(Unk_4_raw);
                writer.Write(Unk_5_raw);
            }
        }

        public partial class Player_Params_3_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView> {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Player Params (3)";

            protected float Unk_56_raw;
            public const string Unk_56_displayName = "Unk 56";
            public const int Unk_56_sortIndex = 50;
            [SortOrder(Unk_56_sortIndex)]
            [DisplayName(Unk_56_displayName)]
            public virtual float Unk_56 {
                get => Unk_56_raw;
                set {
                    if (Unk_56_raw == value) return;
                    Unk_56_raw = value;
                    OnPropertyChanged(nameof(Unk_56));
                }
            }

            protected uint Unk_57_raw;
            public const string Unk_57_displayName = "Unk 57";
            public const int Unk_57_sortIndex = 100;
            [SortOrder(Unk_57_sortIndex)]
            [DisplayName(Unk_57_displayName)]
            public virtual uint Unk_57 {
                get => Unk_57_raw;
                set {
                    if (Unk_57_raw == value) return;
                    Unk_57_raw = value;
                    OnPropertyChanged(nameof(Unk_57));
                }
            }

            protected uint Unk_58_raw;
            public const string Unk_58_displayName = "Unk 58";
            public const int Unk_58_sortIndex = 150;
            [SortOrder(Unk_58_sortIndex)]
            [DisplayName(Unk_58_displayName)]
            public virtual uint Unk_58 {
                get => Unk_58_raw;
                set {
                    if (Unk_58_raw == value) return;
                    Unk_58_raw = value;
                    OnPropertyChanged(nameof(Unk_58));
                }
            }

            protected float Unk_59_raw;
            public const string Unk_59_displayName = "Unk 59";
            public const int Unk_59_sortIndex = 200;
            [SortOrder(Unk_59_sortIndex)]
            [DisplayName(Unk_59_displayName)]
            public virtual float Unk_59 {
                get => Unk_59_raw;
                set {
                    if (Unk_59_raw == value) return;
                    Unk_59_raw = value;
                    OnPropertyChanged(nameof(Unk_59));
                }
            }

            protected float Unk_60_raw;
            public const string Unk_60_displayName = "Unk 60";
            public const int Unk_60_sortIndex = 250;
            [SortOrder(Unk_60_sortIndex)]
            [DisplayName(Unk_60_displayName)]
            public virtual float Unk_60 {
                get => Unk_60_raw;
                set {
                    if (Unk_60_raw == value) return;
                    Unk_60_raw = value;
                    OnPropertyChanged(nameof(Unk_60));
                }
            }

            protected float Unk_61_raw;
            public const string Unk_61_displayName = "Unk 61";
            public const int Unk_61_sortIndex = 300;
            [SortOrder(Unk_61_sortIndex)]
            [DisplayName(Unk_61_displayName)]
            public virtual float Unk_61 {
                get => Unk_61_raw;
                set {
                    if (Unk_61_raw == value) return;
                    Unk_61_raw = value;
                    OnPropertyChanged(nameof(Unk_61));
                }
            }

            protected float Unk_62_raw;
            public const string Unk_62_displayName = "Unk 62";
            public const int Unk_62_sortIndex = 350;
            [SortOrder(Unk_62_sortIndex)]
            [DisplayName(Unk_62_displayName)]
            public virtual float Unk_62 {
                get => Unk_62_raw;
                set {
                    if (Unk_62_raw == value) return;
                    Unk_62_raw = value;
                    OnPropertyChanged(nameof(Unk_62));
                }
            }

            protected float Unk_63_raw;
            public const string Unk_63_displayName = "Unk 63";
            public const int Unk_63_sortIndex = 400;
            [SortOrder(Unk_63_sortIndex)]
            [DisplayName(Unk_63_displayName)]
            public virtual float Unk_63 {
                get => Unk_63_raw;
                set {
                    if (Unk_63_raw == value) return;
                    Unk_63_raw = value;
                    OnPropertyChanged(nameof(Unk_63));
                }
            }

            protected float Unk_64_raw;
            public const string Unk_64_displayName = "Unk 64";
            public const int Unk_64_sortIndex = 450;
            [SortOrder(Unk_64_sortIndex)]
            [DisplayName(Unk_64_displayName)]
            public virtual float Unk_64 {
                get => Unk_64_raw;
                set {
                    if (Unk_64_raw == value) return;
                    Unk_64_raw = value;
                    OnPropertyChanged(nameof(Unk_64));
                }
            }

            protected float Unk_65_raw;
            public const string Unk_65_displayName = "Unk 65";
            public const int Unk_65_sortIndex = 500;
            [SortOrder(Unk_65_sortIndex)]
            [DisplayName(Unk_65_displayName)]
            public virtual float Unk_65 {
                get => Unk_65_raw;
                set {
                    if (Unk_65_raw == value) return;
                    Unk_65_raw = value;
                    OnPropertyChanged(nameof(Unk_65));
                }
            }

            protected float Health_Initial_Value_raw;
            public const string Health_Initial_Value_displayName = "Health Initial Value";
            public const int Health_Initial_Value_sortIndex = 550;
            [SortOrder(Health_Initial_Value_sortIndex)]
            [DisplayName(Health_Initial_Value_displayName)]
            public virtual float Health_Initial_Value {
                get => Health_Initial_Value_raw;
                set {
                    if (Health_Initial_Value_raw == value) return;
                    Health_Initial_Value_raw = value;
                    OnPropertyChanged(nameof(Health_Initial_Value));
                }
            }

            protected float Health_Max_Value_raw;
            public const string Health_Max_Value_displayName = "Health Max Value";
            public const int Health_Max_Value_sortIndex = 600;
            [SortOrder(Health_Max_Value_sortIndex)]
            [DisplayName(Health_Max_Value_displayName)]
            public virtual float Health_Max_Value {
                get => Health_Max_Value_raw;
                set {
                    if (Health_Max_Value_raw == value) return;
                    Health_Max_Value_raw = value;
                    OnPropertyChanged(nameof(Health_Max_Value));
                }
            }

            protected float Health_Damage_Recovery_Rate_raw;
            public const string Health_Damage_Recovery_Rate_displayName = "Health Damage Recovery Rate";
            public const int Health_Damage_Recovery_Rate_sortIndex = 650;
            [SortOrder(Health_Damage_Recovery_Rate_sortIndex)]
            [DisplayName(Health_Damage_Recovery_Rate_displayName)]
            public virtual float Health_Damage_Recovery_Rate {
                get => Health_Damage_Recovery_Rate_raw;
                set {
                    if (Health_Damage_Recovery_Rate_raw == value) return;
                    Health_Damage_Recovery_Rate_raw = value;
                    OnPropertyChanged(nameof(Health_Damage_Recovery_Rate));
                }
            }

            protected float Health_Damage_Recovery_Wait_Time_raw;
            public const string Health_Damage_Recovery_Wait_Time_displayName = "Health Damage Recovery Wait Time";
            public const int Health_Damage_Recovery_Wait_Time_sortIndex = 700;
            [SortOrder(Health_Damage_Recovery_Wait_Time_sortIndex)]
            [DisplayName(Health_Damage_Recovery_Wait_Time_displayName)]
            public virtual float Health_Damage_Recovery_Wait_Time {
                get => Health_Damage_Recovery_Wait_Time_raw;
                set {
                    if (Health_Damage_Recovery_Wait_Time_raw == value) return;
                    Health_Damage_Recovery_Wait_Time_raw = value;
                    OnPropertyChanged(nameof(Health_Damage_Recovery_Wait_Time));
                }
            }

            protected float Health_Damage_Recovery_Interval_raw;
            public const string Health_Damage_Recovery_Interval_displayName = "Health Damage Recovery Interval";
            public const int Health_Damage_Recovery_Interval_sortIndex = 750;
            [SortOrder(Health_Damage_Recovery_Interval_sortIndex)]
            [DisplayName(Health_Damage_Recovery_Interval_displayName)]
            public virtual float Health_Damage_Recovery_Interval {
                get => Health_Damage_Recovery_Interval_raw;
                set {
                    if (Health_Damage_Recovery_Interval_raw == value) return;
                    Health_Damage_Recovery_Interval_raw = value;
                    OnPropertyChanged(nameof(Health_Damage_Recovery_Interval));
                }
            }

            protected float Health_Damage_Recovery_Value_raw;
            public const string Health_Damage_Recovery_Value_displayName = "Health Damage Recovery Value";
            public const int Health_Damage_Recovery_Value_sortIndex = 800;
            [SortOrder(Health_Damage_Recovery_Value_sortIndex)]
            [DisplayName(Health_Damage_Recovery_Value_displayName)]
            public virtual float Health_Damage_Recovery_Value {
                get => Health_Damage_Recovery_Value_raw;
                set {
                    if (Health_Damage_Recovery_Value_raw == value) return;
                    Health_Damage_Recovery_Value_raw = value;
                    OnPropertyChanged(nameof(Health_Damage_Recovery_Value));
                }
            }

            protected float Stamina_Initial_Value_raw;
            public const string Stamina_Initial_Value_displayName = "Stamina Initial Value";
            public const int Stamina_Initial_Value_sortIndex = 850;
            [SortOrder(Stamina_Initial_Value_sortIndex)]
            [DisplayName(Stamina_Initial_Value_displayName)]
            public virtual float Stamina_Initial_Value {
                get => Stamina_Initial_Value_raw;
                set {
                    if (Stamina_Initial_Value_raw == value) return;
                    Stamina_Initial_Value_raw = value;
                    OnPropertyChanged(nameof(Stamina_Initial_Value));
                }
            }

            protected float Stamina_Max_Value_raw;
            public const string Stamina_Max_Value_displayName = "Stamina Max Value";
            public const int Stamina_Max_Value_sortIndex = 900;
            [SortOrder(Stamina_Max_Value_sortIndex)]
            [DisplayName(Stamina_Max_Value_displayName)]
            public virtual float Stamina_Max_Value {
                get => Stamina_Max_Value_raw;
                set {
                    if (Stamina_Max_Value_raw == value) return;
                    Stamina_Max_Value_raw = value;
                    OnPropertyChanged(nameof(Stamina_Max_Value));
                }
            }

            protected float Stamina_Min_Value_raw;
            public const string Stamina_Min_Value_displayName = "Stamina Min Value";
            public const int Stamina_Min_Value_sortIndex = 950;
            [SortOrder(Stamina_Min_Value_sortIndex)]
            [DisplayName(Stamina_Min_Value_displayName)]
            public virtual float Stamina_Min_Value {
                get => Stamina_Min_Value_raw;
                set {
                    if (Stamina_Min_Value_raw == value) return;
                    Stamina_Min_Value_raw = value;
                    OnPropertyChanged(nameof(Stamina_Min_Value));
                }
            }

            protected float Stamina_Tired_Value_raw;
            public const string Stamina_Tired_Value_displayName = "Stamina Tired Value";
            public const int Stamina_Tired_Value_sortIndex = 1000;
            [SortOrder(Stamina_Tired_Value_sortIndex)]
            [DisplayName(Stamina_Tired_Value_displayName)]
            public virtual float Stamina_Tired_Value {
                get => Stamina_Tired_Value_raw;
                set {
                    if (Stamina_Tired_Value_raw == value) return;
                    Stamina_Tired_Value_raw = value;
                    OnPropertyChanged(nameof(Stamina_Tired_Value));
                }
            }

            protected float Stamina_Auto_Recover_raw;
            public const string Stamina_Auto_Recover_displayName = "Stamina Auto Recover";
            public const int Stamina_Auto_Recover_sortIndex = 1050;
            [SortOrder(Stamina_Auto_Recover_sortIndex)]
            [DisplayName(Stamina_Auto_Recover_displayName)]
            public virtual float Stamina_Auto_Recover {
                get => Stamina_Auto_Recover_raw;
                set {
                    if (Stamina_Auto_Recover_raw == value) return;
                    Stamina_Auto_Recover_raw = value;
                    OnPropertyChanged(nameof(Stamina_Auto_Recover));
                }
            }

            protected float Stamina_Auto_Max_Reduce_raw;
            public const string Stamina_Auto_Max_Reduce_displayName = "Stamina Auto Max Reduce";
            public const int Stamina_Auto_Max_Reduce_sortIndex = 1100;
            [SortOrder(Stamina_Auto_Max_Reduce_sortIndex)]
            [DisplayName(Stamina_Auto_Max_Reduce_displayName)]
            public virtual float Stamina_Auto_Max_Reduce {
                get => Stamina_Auto_Max_Reduce_raw;
                set {
                    if (Stamina_Auto_Max_Reduce_raw == value) return;
                    Stamina_Auto_Max_Reduce_raw = value;
                    OnPropertyChanged(nameof(Stamina_Auto_Max_Reduce));
                }
            }

            protected float Stamina_Auto_Max_Reduce_Time_raw;
            public const string Stamina_Auto_Max_Reduce_Time_displayName = "Stamina Auto Max Reduce Time";
            public const int Stamina_Auto_Max_Reduce_Time_sortIndex = 1150;
            [SortOrder(Stamina_Auto_Max_Reduce_Time_sortIndex)]
            [DisplayName(Stamina_Auto_Max_Reduce_Time_displayName)]
            public virtual float Stamina_Auto_Max_Reduce_Time {
                get => Stamina_Auto_Max_Reduce_Time_raw;
                set {
                    if (Stamina_Auto_Max_Reduce_Time_raw == value) return;
                    Stamina_Auto_Max_Reduce_Time_raw = value;
                    OnPropertyChanged(nameof(Stamina_Auto_Max_Reduce_Time));
                }
            }

            protected float Stamina_IB_Unknown_raw;
            public const string Stamina_IB_Unknown_displayName = "Stamina IB Unknown";
            public const int Stamina_IB_Unknown_sortIndex = 1200;
            [SortOrder(Stamina_IB_Unknown_sortIndex)]
            [DisplayName(Stamina_IB_Unknown_displayName)]
            public virtual float Stamina_IB_Unknown {
                get => Stamina_IB_Unknown_raw;
                set {
                    if (Stamina_IB_Unknown_raw == value) return;
                    Stamina_IB_Unknown_raw = value;
                    OnPropertyChanged(nameof(Stamina_IB_Unknown));
                }
            }

            protected float Stamina_Escape_Dash_Rate_raw;
            public const string Stamina_Escape_Dash_Rate_displayName = "Stamina Escape Dash Rate";
            public const int Stamina_Escape_Dash_Rate_sortIndex = 1250;
            [SortOrder(Stamina_Escape_Dash_Rate_sortIndex)]
            [DisplayName(Stamina_Escape_Dash_Rate_displayName)]
            public virtual float Stamina_Escape_Dash_Rate {
                get => Stamina_Escape_Dash_Rate_raw;
                set {
                    if (Stamina_Escape_Dash_Rate_raw == value) return;
                    Stamina_Escape_Dash_Rate_raw = value;
                    OnPropertyChanged(nameof(Stamina_Escape_Dash_Rate));
                }
            }

            protected float Stamina_Out_of_Battle_Rate_raw;
            public const string Stamina_Out_of_Battle_Rate_displayName = "Stamina Out of Battle Rate";
            public const int Stamina_Out_of_Battle_Rate_sortIndex = 1300;
            [SortOrder(Stamina_Out_of_Battle_Rate_sortIndex)]
            [DisplayName(Stamina_Out_of_Battle_Rate_displayName)]
            public virtual float Stamina_Out_of_Battle_Rate {
                get => Stamina_Out_of_Battle_Rate_raw;
                set {
                    if (Stamina_Out_of_Battle_Rate_raw == value) return;
                    Stamina_Out_of_Battle_Rate_raw = value;
                    OnPropertyChanged(nameof(Stamina_Out_of_Battle_Rate));
                }
            }

            protected float Stamina_Reduce_Rate_Limit_Trigger_raw;
            public const string Stamina_Reduce_Rate_Limit_Trigger_displayName = "Stamina Reduce Rate Limit Trigger";
            public const int Stamina_Reduce_Rate_Limit_Trigger_sortIndex = 1350;
            [SortOrder(Stamina_Reduce_Rate_Limit_Trigger_sortIndex)]
            [DisplayName(Stamina_Reduce_Rate_Limit_Trigger_displayName)]
            public virtual float Stamina_Reduce_Rate_Limit_Trigger {
                get => Stamina_Reduce_Rate_Limit_Trigger_raw;
                set {
                    if (Stamina_Reduce_Rate_Limit_Trigger_raw == value) return;
                    Stamina_Reduce_Rate_Limit_Trigger_raw = value;
                    OnPropertyChanged(nameof(Stamina_Reduce_Rate_Limit_Trigger));
                }
            }

            protected float Stamina_Reduce_Rate_Limit_Time_raw;
            public const string Stamina_Reduce_Rate_Limit_Time_displayName = "Stamina Reduce Rate Limit Time";
            public const int Stamina_Reduce_Rate_Limit_Time_sortIndex = 1400;
            [SortOrder(Stamina_Reduce_Rate_Limit_Time_sortIndex)]
            [DisplayName(Stamina_Reduce_Rate_Limit_Time_displayName)]
            public virtual float Stamina_Reduce_Rate_Limit_Time {
                get => Stamina_Reduce_Rate_Limit_Time_raw;
                set {
                    if (Stamina_Reduce_Rate_Limit_Time_raw == value) return;
                    Stamina_Reduce_Rate_Limit_Time_raw = value;
                    OnPropertyChanged(nameof(Stamina_Reduce_Rate_Limit_Time));
                }
            }

            protected float Stamina_Mount_Endurance_Rate_raw;
            public const string Stamina_Mount_Endurance_Rate_displayName = "Stamina Mount Endurance Rate";
            public const int Stamina_Mount_Endurance_Rate_sortIndex = 1450;
            [SortOrder(Stamina_Mount_Endurance_Rate_sortIndex)]
            [DisplayName(Stamina_Mount_Endurance_Rate_displayName)]
            public virtual float Stamina_Mount_Endurance_Rate {
                get => Stamina_Mount_Endurance_Rate_raw;
                set {
                    if (Stamina_Mount_Endurance_Rate_raw == value) return;
                    Stamina_Mount_Endurance_Rate_raw = value;
                    OnPropertyChanged(nameof(Stamina_Mount_Endurance_Rate));
                }
            }

            protected float Stamina_Consumption_Dodge_raw;
            public const string Stamina_Consumption_Dodge_displayName = "Stamina Consumption: Dodge";
            public const int Stamina_Consumption_Dodge_sortIndex = 1500;
            [SortOrder(Stamina_Consumption_Dodge_sortIndex)]
            [DisplayName(Stamina_Consumption_Dodge_displayName)]
            public virtual float Stamina_Consumption_Dodge {
                get => Stamina_Consumption_Dodge_raw;
                set {
                    if (Stamina_Consumption_Dodge_raw == value) return;
                    Stamina_Consumption_Dodge_raw = value;
                    OnPropertyChanged(nameof(Stamina_Consumption_Dodge));
                }
            }

            protected float Stamina_Consumption_LS_Counter_raw;
            public const string Stamina_Consumption_LS_Counter_displayName = "Stamina Consumption: LS Counter";
            public const int Stamina_Consumption_LS_Counter_sortIndex = 1550;
            [SortOrder(Stamina_Consumption_LS_Counter_sortIndex)]
            [DisplayName(Stamina_Consumption_LS_Counter_displayName)]
            public virtual float Stamina_Consumption_LS_Counter {
                get => Stamina_Consumption_LS_Counter_raw;
                set {
                    if (Stamina_Consumption_LS_Counter_raw == value) return;
                    Stamina_Consumption_LS_Counter_raw = value;
                    OnPropertyChanged(nameof(Stamina_Consumption_LS_Counter));
                }
            }

            protected float Stamina_Consumption_SA_Wild_Swing_raw;
            public const string Stamina_Consumption_SA_Wild_Swing_displayName = "Stamina Consumption: SA Wild Swing";
            public const int Stamina_Consumption_SA_Wild_Swing_sortIndex = 1600;
            [SortOrder(Stamina_Consumption_SA_Wild_Swing_sortIndex)]
            [DisplayName(Stamina_Consumption_SA_Wild_Swing_displayName)]
            public virtual float Stamina_Consumption_SA_Wild_Swing {
                get => Stamina_Consumption_SA_Wild_Swing_raw;
                set {
                    if (Stamina_Consumption_SA_Wild_Swing_raw == value) return;
                    Stamina_Consumption_SA_Wild_Swing_raw = value;
                    OnPropertyChanged(nameof(Stamina_Consumption_SA_Wild_Swing));
                }
            }

            protected float Stamina_Consumption_Unk1_raw;
            public const string Stamina_Consumption_Unk1_displayName = "Stamina Consumption: Unk1";
            public const int Stamina_Consumption_Unk1_sortIndex = 1650;
            [SortOrder(Stamina_Consumption_Unk1_sortIndex)]
            [DisplayName(Stamina_Consumption_Unk1_displayName)]
            public virtual float Stamina_Consumption_Unk1 {
                get => Stamina_Consumption_Unk1_raw;
                set {
                    if (Stamina_Consumption_Unk1_raw == value) return;
                    Stamina_Consumption_Unk1_raw = value;
                    OnPropertyChanged(nameof(Stamina_Consumption_Unk1));
                }
            }

            protected float Stamina_Consumption_Unk2_raw;
            public const string Stamina_Consumption_Unk2_displayName = "Stamina Consumption: Unk2";
            public const int Stamina_Consumption_Unk2_sortIndex = 1700;
            [SortOrder(Stamina_Consumption_Unk2_sortIndex)]
            [DisplayName(Stamina_Consumption_Unk2_displayName)]
            public virtual float Stamina_Consumption_Unk2 {
                get => Stamina_Consumption_Unk2_raw;
                set {
                    if (Stamina_Consumption_Unk2_raw == value) return;
                    Stamina_Consumption_Unk2_raw = value;
                    OnPropertyChanged(nameof(Stamina_Consumption_Unk2));
                }
            }

            protected float Stamina_Consumption_Unk3_raw;
            public const string Stamina_Consumption_Unk3_displayName = "Stamina Consumption: Unk3";
            public const int Stamina_Consumption_Unk3_sortIndex = 1750;
            [SortOrder(Stamina_Consumption_Unk3_sortIndex)]
            [DisplayName(Stamina_Consumption_Unk3_displayName)]
            public virtual float Stamina_Consumption_Unk3 {
                get => Stamina_Consumption_Unk3_raw;
                set {
                    if (Stamina_Consumption_Unk3_raw == value) return;
                    Stamina_Consumption_Unk3_raw = value;
                    OnPropertyChanged(nameof(Stamina_Consumption_Unk3));
                }
            }

            protected float Stamina_Consumption_Bow_Shoot_raw;
            public const string Stamina_Consumption_Bow_Shoot_displayName = "Stamina Consumption: Bow Shoot";
            public const int Stamina_Consumption_Bow_Shoot_sortIndex = 1800;
            [SortOrder(Stamina_Consumption_Bow_Shoot_sortIndex)]
            [DisplayName(Stamina_Consumption_Bow_Shoot_displayName)]
            public virtual float Stamina_Consumption_Bow_Shoot {
                get => Stamina_Consumption_Bow_Shoot_raw;
                set {
                    if (Stamina_Consumption_Bow_Shoot_raw == value) return;
                    Stamina_Consumption_Bow_Shoot_raw = value;
                    OnPropertyChanged(nameof(Stamina_Consumption_Bow_Shoot));
                }
            }

            protected float Stamina_Consumption_Unk4_raw;
            public const string Stamina_Consumption_Unk4_displayName = "Stamina Consumption: Unk4";
            public const int Stamina_Consumption_Unk4_sortIndex = 1850;
            [SortOrder(Stamina_Consumption_Unk4_sortIndex)]
            [DisplayName(Stamina_Consumption_Unk4_displayName)]
            public virtual float Stamina_Consumption_Unk4 {
                get => Stamina_Consumption_Unk4_raw;
                set {
                    if (Stamina_Consumption_Unk4_raw == value) return;
                    Stamina_Consumption_Unk4_raw = value;
                    OnPropertyChanged(nameof(Stamina_Consumption_Unk4));
                }
            }

            protected float Stamina_Consumption_Unk5_raw;
            public const string Stamina_Consumption_Unk5_displayName = "Stamina Consumption: Unk5";
            public const int Stamina_Consumption_Unk5_sortIndex = 1900;
            [SortOrder(Stamina_Consumption_Unk5_sortIndex)]
            [DisplayName(Stamina_Consumption_Unk5_displayName)]
            public virtual float Stamina_Consumption_Unk5 {
                get => Stamina_Consumption_Unk5_raw;
                set {
                    if (Stamina_Consumption_Unk5_raw == value) return;
                    Stamina_Consumption_Unk5_raw = value;
                    OnPropertyChanged(nameof(Stamina_Consumption_Unk5));
                }
            }

            protected float Stamina_Consumption_Unk6_raw;
            public const string Stamina_Consumption_Unk6_displayName = "Stamina Consumption: Unk6";
            public const int Stamina_Consumption_Unk6_sortIndex = 1950;
            [SortOrder(Stamina_Consumption_Unk6_sortIndex)]
            [DisplayName(Stamina_Consumption_Unk6_displayName)]
            public virtual float Stamina_Consumption_Unk6 {
                get => Stamina_Consumption_Unk6_raw;
                set {
                    if (Stamina_Consumption_Unk6_raw == value) return;
                    Stamina_Consumption_Unk6_raw = value;
                    OnPropertyChanged(nameof(Stamina_Consumption_Unk6));
                }
            }

            protected float Stamina_Consumption_Bow_Charge_Step_raw;
            public const string Stamina_Consumption_Bow_Charge_Step_displayName = "Stamina Consumption: Bow Charge Step";
            public const int Stamina_Consumption_Bow_Charge_Step_sortIndex = 2000;
            [SortOrder(Stamina_Consumption_Bow_Charge_Step_sortIndex)]
            [DisplayName(Stamina_Consumption_Bow_Charge_Step_displayName)]
            public virtual float Stamina_Consumption_Bow_Charge_Step {
                get => Stamina_Consumption_Bow_Charge_Step_raw;
                set {
                    if (Stamina_Consumption_Bow_Charge_Step_raw == value) return;
                    Stamina_Consumption_Bow_Charge_Step_raw = value;
                    OnPropertyChanged(nameof(Stamina_Consumption_Bow_Charge_Step));
                }
            }

            protected float Stamina_Consumption_Unk7_raw;
            public const string Stamina_Consumption_Unk7_displayName = "Stamina Consumption: Unk7";
            public const int Stamina_Consumption_Unk7_sortIndex = 2050;
            [SortOrder(Stamina_Consumption_Unk7_sortIndex)]
            [DisplayName(Stamina_Consumption_Unk7_displayName)]
            public virtual float Stamina_Consumption_Unk7 {
                get => Stamina_Consumption_Unk7_raw;
                set {
                    if (Stamina_Consumption_Unk7_raw == value) return;
                    Stamina_Consumption_Unk7_raw = value;
                    OnPropertyChanged(nameof(Stamina_Consumption_Unk7));
                }
            }

            protected float Stamina_Consumption_Claw_Attack_1_raw;
            public const string Stamina_Consumption_Claw_Attack_1_displayName = "Stamina Consumption: Claw Attack 1";
            public const int Stamina_Consumption_Claw_Attack_1_sortIndex = 2100;
            [SortOrder(Stamina_Consumption_Claw_Attack_1_sortIndex)]
            [DisplayName(Stamina_Consumption_Claw_Attack_1_displayName)]
            public virtual float Stamina_Consumption_Claw_Attack_1 {
                get => Stamina_Consumption_Claw_Attack_1_raw;
                set {
                    if (Stamina_Consumption_Claw_Attack_1_raw == value) return;
                    Stamina_Consumption_Claw_Attack_1_raw = value;
                    OnPropertyChanged(nameof(Stamina_Consumption_Claw_Attack_1));
                }
            }

            protected float Stamina_Consumption_Claw_Attack_2_raw;
            public const string Stamina_Consumption_Claw_Attack_2_displayName = "Stamina Consumption: Claw Attack 2";
            public const int Stamina_Consumption_Claw_Attack_2_sortIndex = 2150;
            [SortOrder(Stamina_Consumption_Claw_Attack_2_sortIndex)]
            [DisplayName(Stamina_Consumption_Claw_Attack_2_displayName)]
            public virtual float Stamina_Consumption_Claw_Attack_2 {
                get => Stamina_Consumption_Claw_Attack_2_raw;
                set {
                    if (Stamina_Consumption_Claw_Attack_2_raw == value) return;
                    Stamina_Consumption_Claw_Attack_2_raw = value;
                    OnPropertyChanged(nameof(Stamina_Consumption_Claw_Attack_2));
                }
            }

            protected float Stamina_Consumption_Claw_Attack_3_raw;
            public const string Stamina_Consumption_Claw_Attack_3_displayName = "Stamina Consumption: Claw Attack 3";
            public const int Stamina_Consumption_Claw_Attack_3_sortIndex = 2200;
            [SortOrder(Stamina_Consumption_Claw_Attack_3_sortIndex)]
            [DisplayName(Stamina_Consumption_Claw_Attack_3_displayName)]
            public virtual float Stamina_Consumption_Claw_Attack_3 {
                get => Stamina_Consumption_Claw_Attack_3_raw;
                set {
                    if (Stamina_Consumption_Claw_Attack_3_raw == value) return;
                    Stamina_Consumption_Claw_Attack_3_raw = value;
                    OnPropertyChanged(nameof(Stamina_Consumption_Claw_Attack_3));
                }
            }

            protected float Stamina_Consumption_Claw_Attack_4_raw;
            public const string Stamina_Consumption_Claw_Attack_4_displayName = "Stamina Consumption: Claw Attack 4";
            public const int Stamina_Consumption_Claw_Attack_4_sortIndex = 2250;
            [SortOrder(Stamina_Consumption_Claw_Attack_4_sortIndex)]
            [DisplayName(Stamina_Consumption_Claw_Attack_4_displayName)]
            public virtual float Stamina_Consumption_Claw_Attack_4 {
                get => Stamina_Consumption_Claw_Attack_4_raw;
                set {
                    if (Stamina_Consumption_Claw_Attack_4_raw == value) return;
                    Stamina_Consumption_Claw_Attack_4_raw = value;
                    OnPropertyChanged(nameof(Stamina_Consumption_Claw_Attack_4));
                }
            }

            protected float Stamina_Consumption_Unk8_raw;
            public const string Stamina_Consumption_Unk8_displayName = "Stamina Consumption: Unk8";
            public const int Stamina_Consumption_Unk8_sortIndex = 2300;
            [SortOrder(Stamina_Consumption_Unk8_sortIndex)]
            [DisplayName(Stamina_Consumption_Unk8_displayName)]
            public virtual float Stamina_Consumption_Unk8 {
                get => Stamina_Consumption_Unk8_raw;
                set {
                    if (Stamina_Consumption_Unk8_raw == value) return;
                    Stamina_Consumption_Unk8_raw = value;
                    OnPropertyChanged(nameof(Stamina_Consumption_Unk8));
                }
            }

            protected float Stamina_Consumption_Unk9_raw;
            public const string Stamina_Consumption_Unk9_displayName = "Stamina Consumption: Unk9";
            public const int Stamina_Consumption_Unk9_sortIndex = 2350;
            [SortOrder(Stamina_Consumption_Unk9_sortIndex)]
            [DisplayName(Stamina_Consumption_Unk9_displayName)]
            public virtual float Stamina_Consumption_Unk9 {
                get => Stamina_Consumption_Unk9_raw;
                set {
                    if (Stamina_Consumption_Unk9_raw == value) return;
                    Stamina_Consumption_Unk9_raw = value;
                    OnPropertyChanged(nameof(Stamina_Consumption_Unk9));
                }
            }

            protected float Stamina_Time_Reduce_mCore_Unk1_raw;
            public const string Stamina_Time_Reduce_mCore_Unk1_displayName = "Stamina Time Reduce mCore: Unk1";
            public const int Stamina_Time_Reduce_mCore_Unk1_sortIndex = 2400;
            [SortOrder(Stamina_Time_Reduce_mCore_Unk1_sortIndex)]
            [DisplayName(Stamina_Time_Reduce_mCore_Unk1_displayName)]
            public virtual float Stamina_Time_Reduce_mCore_Unk1 {
                get => Stamina_Time_Reduce_mCore_Unk1_raw;
                set {
                    if (Stamina_Time_Reduce_mCore_Unk1_raw == value) return;
                    Stamina_Time_Reduce_mCore_Unk1_raw = value;
                    OnPropertyChanged(nameof(Stamina_Time_Reduce_mCore_Unk1));
                }
            }

            protected float Stamina_Time_Reduce_mCore_Unk2_raw;
            public const string Stamina_Time_Reduce_mCore_Unk2_displayName = "Stamina Time Reduce mCore: Unk2";
            public const int Stamina_Time_Reduce_mCore_Unk2_sortIndex = 2450;
            [SortOrder(Stamina_Time_Reduce_mCore_Unk2_sortIndex)]
            [DisplayName(Stamina_Time_Reduce_mCore_Unk2_displayName)]
            public virtual float Stamina_Time_Reduce_mCore_Unk2 {
                get => Stamina_Time_Reduce_mCore_Unk2_raw;
                set {
                    if (Stamina_Time_Reduce_mCore_Unk2_raw == value) return;
                    Stamina_Time_Reduce_mCore_Unk2_raw = value;
                    OnPropertyChanged(nameof(Stamina_Time_Reduce_mCore_Unk2));
                }
            }

            protected float Stamina_Time_Reduce_mCore_Unk3_raw;
            public const string Stamina_Time_Reduce_mCore_Unk3_displayName = "Stamina Time Reduce mCore: Unk3";
            public const int Stamina_Time_Reduce_mCore_Unk3_sortIndex = 2500;
            [SortOrder(Stamina_Time_Reduce_mCore_Unk3_sortIndex)]
            [DisplayName(Stamina_Time_Reduce_mCore_Unk3_displayName)]
            public virtual float Stamina_Time_Reduce_mCore_Unk3 {
                get => Stamina_Time_Reduce_mCore_Unk3_raw;
                set {
                    if (Stamina_Time_Reduce_mCore_Unk3_raw == value) return;
                    Stamina_Time_Reduce_mCore_Unk3_raw = value;
                    OnPropertyChanged(nameof(Stamina_Time_Reduce_mCore_Unk3));
                }
            }

            protected float Stamina_Time_Reduce_mCore_Hammer_Bow_Charge_Drain_raw;
            public const string Stamina_Time_Reduce_mCore_Hammer_Bow_Charge_Drain_displayName = "Stamina Time Reduce mCore: Hammer/Bow Charge Drain";
            public const int Stamina_Time_Reduce_mCore_Hammer_Bow_Charge_Drain_sortIndex = 2550;
            [SortOrder(Stamina_Time_Reduce_mCore_Hammer_Bow_Charge_Drain_sortIndex)]
            [DisplayName(Stamina_Time_Reduce_mCore_Hammer_Bow_Charge_Drain_displayName)]
            public virtual float Stamina_Time_Reduce_mCore_Hammer_Bow_Charge_Drain {
                get => Stamina_Time_Reduce_mCore_Hammer_Bow_Charge_Drain_raw;
                set {
                    if (Stamina_Time_Reduce_mCore_Hammer_Bow_Charge_Drain_raw == value) return;
                    Stamina_Time_Reduce_mCore_Hammer_Bow_Charge_Drain_raw = value;
                    OnPropertyChanged(nameof(Stamina_Time_Reduce_mCore_Hammer_Bow_Charge_Drain));
                }
            }

            protected float Stamina_Time_Reduce_mCore_Unk4_raw;
            public const string Stamina_Time_Reduce_mCore_Unk4_displayName = "Stamina Time Reduce mCore: Unk4";
            public const int Stamina_Time_Reduce_mCore_Unk4_sortIndex = 2600;
            [SortOrder(Stamina_Time_Reduce_mCore_Unk4_sortIndex)]
            [DisplayName(Stamina_Time_Reduce_mCore_Unk4_displayName)]
            public virtual float Stamina_Time_Reduce_mCore_Unk4 {
                get => Stamina_Time_Reduce_mCore_Unk4_raw;
                set {
                    if (Stamina_Time_Reduce_mCore_Unk4_raw == value) return;
                    Stamina_Time_Reduce_mCore_Unk4_raw = value;
                    OnPropertyChanged(nameof(Stamina_Time_Reduce_mCore_Unk4));
                }
            }

            protected float Stamina_Time_Reduce_mCore_Unk5_raw;
            public const string Stamina_Time_Reduce_mCore_Unk5_displayName = "Stamina Time Reduce mCore: Unk5";
            public const int Stamina_Time_Reduce_mCore_Unk5_sortIndex = 2650;
            [SortOrder(Stamina_Time_Reduce_mCore_Unk5_sortIndex)]
            [DisplayName(Stamina_Time_Reduce_mCore_Unk5_displayName)]
            public virtual float Stamina_Time_Reduce_mCore_Unk5 {
                get => Stamina_Time_Reduce_mCore_Unk5_raw;
                set {
                    if (Stamina_Time_Reduce_mCore_Unk5_raw == value) return;
                    Stamina_Time_Reduce_mCore_Unk5_raw = value;
                    OnPropertyChanged(nameof(Stamina_Time_Reduce_mCore_Unk5));
                }
            }

            protected float Stamina_Time_Reduce_mCore_Unk6_raw;
            public const string Stamina_Time_Reduce_mCore_Unk6_displayName = "Stamina Time Reduce mCore: Unk6";
            public const int Stamina_Time_Reduce_mCore_Unk6_sortIndex = 2700;
            [SortOrder(Stamina_Time_Reduce_mCore_Unk6_sortIndex)]
            [DisplayName(Stamina_Time_Reduce_mCore_Unk6_displayName)]
            public virtual float Stamina_Time_Reduce_mCore_Unk6 {
                get => Stamina_Time_Reduce_mCore_Unk6_raw;
                set {
                    if (Stamina_Time_Reduce_mCore_Unk6_raw == value) return;
                    Stamina_Time_Reduce_mCore_Unk6_raw = value;
                    OnPropertyChanged(nameof(Stamina_Time_Reduce_mCore_Unk6));
                }
            }

            protected float Stamina_Time_Reduce_mCore_Unk7_raw;
            public const string Stamina_Time_Reduce_mCore_Unk7_displayName = "Stamina Time Reduce mCore: Unk7";
            public const int Stamina_Time_Reduce_mCore_Unk7_sortIndex = 2750;
            [SortOrder(Stamina_Time_Reduce_mCore_Unk7_sortIndex)]
            [DisplayName(Stamina_Time_Reduce_mCore_Unk7_displayName)]
            public virtual float Stamina_Time_Reduce_mCore_Unk7 {
                get => Stamina_Time_Reduce_mCore_Unk7_raw;
                set {
                    if (Stamina_Time_Reduce_mCore_Unk7_raw == value) return;
                    Stamina_Time_Reduce_mCore_Unk7_raw = value;
                    OnPropertyChanged(nameof(Stamina_Time_Reduce_mCore_Unk7));
                }
            }

            protected float Stamina_Time_Reduce_mCore_Lance_s_Power_Guard_raw;
            public const string Stamina_Time_Reduce_mCore_Lance_s_Power_Guard_displayName = "Stamina Time Reduce mCore: Lance's Power Guard";
            public const int Stamina_Time_Reduce_mCore_Lance_s_Power_Guard_sortIndex = 2800;
            [SortOrder(Stamina_Time_Reduce_mCore_Lance_s_Power_Guard_sortIndex)]
            [DisplayName(Stamina_Time_Reduce_mCore_Lance_s_Power_Guard_displayName)]
            public virtual float Stamina_Time_Reduce_mCore_Lance_s_Power_Guard {
                get => Stamina_Time_Reduce_mCore_Lance_s_Power_Guard_raw;
                set {
                    if (Stamina_Time_Reduce_mCore_Lance_s_Power_Guard_raw == value) return;
                    Stamina_Time_Reduce_mCore_Lance_s_Power_Guard_raw = value;
                    OnPropertyChanged(nameof(Stamina_Time_Reduce_mCore_Lance_s_Power_Guard));
                }
            }

            protected float Stamina_Time_Reduce_mCore_Unk8_raw;
            public const string Stamina_Time_Reduce_mCore_Unk8_displayName = "Stamina Time Reduce mCore: Unk8";
            public const int Stamina_Time_Reduce_mCore_Unk8_sortIndex = 2850;
            [SortOrder(Stamina_Time_Reduce_mCore_Unk8_sortIndex)]
            [DisplayName(Stamina_Time_Reduce_mCore_Unk8_displayName)]
            public virtual float Stamina_Time_Reduce_mCore_Unk8 {
                get => Stamina_Time_Reduce_mCore_Unk8_raw;
                set {
                    if (Stamina_Time_Reduce_mCore_Unk8_raw == value) return;
                    Stamina_Time_Reduce_mCore_Unk8_raw = value;
                    OnPropertyChanged(nameof(Stamina_Time_Reduce_mCore_Unk8));
                }
            }

            protected float Stamina_Time_Reduce_mCore_Clutch_Drain_Whilst_Grappled__raw;
            public const string Stamina_Time_Reduce_mCore_Clutch_Drain_Whilst_Grappled__displayName = "Stamina Time Reduce mCore: Clutch Drain (Whilst Grappled)";
            public const int Stamina_Time_Reduce_mCore_Clutch_Drain_Whilst_Grappled__sortIndex = 2900;
            [SortOrder(Stamina_Time_Reduce_mCore_Clutch_Drain_Whilst_Grappled__sortIndex)]
            [DisplayName(Stamina_Time_Reduce_mCore_Clutch_Drain_Whilst_Grappled__displayName)]
            public virtual float Stamina_Time_Reduce_mCore_Clutch_Drain_Whilst_Grappled_ {
                get => Stamina_Time_Reduce_mCore_Clutch_Drain_Whilst_Grappled__raw;
                set {
                    if (Stamina_Time_Reduce_mCore_Clutch_Drain_Whilst_Grappled__raw == value) return;
                    Stamina_Time_Reduce_mCore_Clutch_Drain_Whilst_Grappled__raw = value;
                    OnPropertyChanged(nameof(Stamina_Time_Reduce_mCore_Clutch_Drain_Whilst_Grappled_));
                }
            }

            protected float Stamina_Time_Reduce_mCore_Clutch_Counter_raw;
            public const string Stamina_Time_Reduce_mCore_Clutch_Counter_displayName = "Stamina Time Reduce mCore: Clutch-Counter";
            public const int Stamina_Time_Reduce_mCore_Clutch_Counter_sortIndex = 2950;
            [SortOrder(Stamina_Time_Reduce_mCore_Clutch_Counter_sortIndex)]
            [DisplayName(Stamina_Time_Reduce_mCore_Clutch_Counter_displayName)]
            public virtual float Stamina_Time_Reduce_mCore_Clutch_Counter {
                get => Stamina_Time_Reduce_mCore_Clutch_Counter_raw;
                set {
                    if (Stamina_Time_Reduce_mCore_Clutch_Counter_raw == value) return;
                    Stamina_Time_Reduce_mCore_Clutch_Counter_raw = value;
                    OnPropertyChanged(nameof(Stamina_Time_Reduce_mCore_Clutch_Counter));
                }
            }

            protected float Stamina_Time_Reduce_mCore_Unk9_raw;
            public const string Stamina_Time_Reduce_mCore_Unk9_displayName = "Stamina Time Reduce mCore: Unk9";
            public const int Stamina_Time_Reduce_mCore_Unk9_sortIndex = 3000;
            [SortOrder(Stamina_Time_Reduce_mCore_Unk9_sortIndex)]
            [DisplayName(Stamina_Time_Reduce_mCore_Unk9_displayName)]
            public virtual float Stamina_Time_Reduce_mCore_Unk9 {
                get => Stamina_Time_Reduce_mCore_Unk9_raw;
                set {
                    if (Stamina_Time_Reduce_mCore_Unk9_raw == value) return;
                    Stamina_Time_Reduce_mCore_Unk9_raw = value;
                    OnPropertyChanged(nameof(Stamina_Time_Reduce_mCore_Unk9));
                }
            }

            protected float Stamina_Time_Reduce_mCore_Unk10_raw;
            public const string Stamina_Time_Reduce_mCore_Unk10_displayName = "Stamina Time Reduce mCore: Unk10";
            public const int Stamina_Time_Reduce_mCore_Unk10_sortIndex = 3050;
            [SortOrder(Stamina_Time_Reduce_mCore_Unk10_sortIndex)]
            [DisplayName(Stamina_Time_Reduce_mCore_Unk10_displayName)]
            public virtual float Stamina_Time_Reduce_mCore_Unk10 {
                get => Stamina_Time_Reduce_mCore_Unk10_raw;
                set {
                    if (Stamina_Time_Reduce_mCore_Unk10_raw == value) return;
                    Stamina_Time_Reduce_mCore_Unk10_raw = value;
                    OnPropertyChanged(nameof(Stamina_Time_Reduce_mCore_Unk10));
                }
            }

            protected float Stamina_Time_Reduce_mCore_Unk11_raw;
            public const string Stamina_Time_Reduce_mCore_Unk11_displayName = "Stamina Time Reduce mCore: Unk11";
            public const int Stamina_Time_Reduce_mCore_Unk11_sortIndex = 3100;
            [SortOrder(Stamina_Time_Reduce_mCore_Unk11_sortIndex)]
            [DisplayName(Stamina_Time_Reduce_mCore_Unk11_displayName)]
            public virtual float Stamina_Time_Reduce_mCore_Unk11 {
                get => Stamina_Time_Reduce_mCore_Unk11_raw;
                set {
                    if (Stamina_Time_Reduce_mCore_Unk11_raw == value) return;
                    Stamina_Time_Reduce_mCore_Unk11_raw = value;
                    OnPropertyChanged(nameof(Stamina_Time_Reduce_mCore_Unk11));
                }
            }

            protected float Stamina_Time_Reduce_mCore_Unk12_raw;
            public const string Stamina_Time_Reduce_mCore_Unk12_displayName = "Stamina Time Reduce mCore: Unk12";
            public const int Stamina_Time_Reduce_mCore_Unk12_sortIndex = 3150;
            [SortOrder(Stamina_Time_Reduce_mCore_Unk12_sortIndex)]
            [DisplayName(Stamina_Time_Reduce_mCore_Unk12_displayName)]
            public virtual float Stamina_Time_Reduce_mCore_Unk12 {
                get => Stamina_Time_Reduce_mCore_Unk12_raw;
                set {
                    if (Stamina_Time_Reduce_mCore_Unk12_raw == value) return;
                    Stamina_Time_Reduce_mCore_Unk12_raw = value;
                    OnPropertyChanged(nameof(Stamina_Time_Reduce_mCore_Unk12));
                }
            }

            protected float Stamina_Time_Reduce_mCore_Unk13_raw;
            public const string Stamina_Time_Reduce_mCore_Unk13_displayName = "Stamina Time Reduce mCore: Unk13";
            public const int Stamina_Time_Reduce_mCore_Unk13_sortIndex = 3200;
            [SortOrder(Stamina_Time_Reduce_mCore_Unk13_sortIndex)]
            [DisplayName(Stamina_Time_Reduce_mCore_Unk13_displayName)]
            public virtual float Stamina_Time_Reduce_mCore_Unk13 {
                get => Stamina_Time_Reduce_mCore_Unk13_raw;
                set {
                    if (Stamina_Time_Reduce_mCore_Unk13_raw == value) return;
                    Stamina_Time_Reduce_mCore_Unk13_raw = value;
                    OnPropertyChanged(nameof(Stamina_Time_Reduce_mCore_Unk13));
                }
            }

            protected float Stamina_Time_Reduce_mCore_Unk14_raw;
            public const string Stamina_Time_Reduce_mCore_Unk14_displayName = "Stamina Time Reduce mCore: Unk14";
            public const int Stamina_Time_Reduce_mCore_Unk14_sortIndex = 3250;
            [SortOrder(Stamina_Time_Reduce_mCore_Unk14_sortIndex)]
            [DisplayName(Stamina_Time_Reduce_mCore_Unk14_displayName)]
            public virtual float Stamina_Time_Reduce_mCore_Unk14 {
                get => Stamina_Time_Reduce_mCore_Unk14_raw;
                set {
                    if (Stamina_Time_Reduce_mCore_Unk14_raw == value) return;
                    Stamina_Time_Reduce_mCore_Unk14_raw = value;
                    OnPropertyChanged(nameof(Stamina_Time_Reduce_mCore_Unk14));
                }
            }

            protected float Mount_Reduce_Stamina_mCore_Unk1_raw;
            public const string Mount_Reduce_Stamina_mCore_Unk1_displayName = "Mount Reduce Stamina mCore: Unk1";
            public const int Mount_Reduce_Stamina_mCore_Unk1_sortIndex = 3300;
            [SortOrder(Mount_Reduce_Stamina_mCore_Unk1_sortIndex)]
            [DisplayName(Mount_Reduce_Stamina_mCore_Unk1_displayName)]
            public virtual float Mount_Reduce_Stamina_mCore_Unk1 {
                get => Mount_Reduce_Stamina_mCore_Unk1_raw;
                set {
                    if (Mount_Reduce_Stamina_mCore_Unk1_raw == value) return;
                    Mount_Reduce_Stamina_mCore_Unk1_raw = value;
                    OnPropertyChanged(nameof(Mount_Reduce_Stamina_mCore_Unk1));
                }
            }

            protected float Mount_Reduce_Stamina_mCore_Unk2_raw;
            public const string Mount_Reduce_Stamina_mCore_Unk2_displayName = "Mount Reduce Stamina mCore: Unk2";
            public const int Mount_Reduce_Stamina_mCore_Unk2_sortIndex = 3350;
            [SortOrder(Mount_Reduce_Stamina_mCore_Unk2_sortIndex)]
            [DisplayName(Mount_Reduce_Stamina_mCore_Unk2_displayName)]
            public virtual float Mount_Reduce_Stamina_mCore_Unk2 {
                get => Mount_Reduce_Stamina_mCore_Unk2_raw;
                set {
                    if (Mount_Reduce_Stamina_mCore_Unk2_raw == value) return;
                    Mount_Reduce_Stamina_mCore_Unk2_raw = value;
                    OnPropertyChanged(nameof(Mount_Reduce_Stamina_mCore_Unk2));
                }
            }

            protected float Mount_Life_Reduce_Stamina_mCore_Unk1_raw;
            public const string Mount_Life_Reduce_Stamina_mCore_Unk1_displayName = "Mount Life Reduce Stamina mCore: Unk1";
            public const int Mount_Life_Reduce_Stamina_mCore_Unk1_sortIndex = 3400;
            [SortOrder(Mount_Life_Reduce_Stamina_mCore_Unk1_sortIndex)]
            [DisplayName(Mount_Life_Reduce_Stamina_mCore_Unk1_displayName)]
            public virtual float Mount_Life_Reduce_Stamina_mCore_Unk1 {
                get => Mount_Life_Reduce_Stamina_mCore_Unk1_raw;
                set {
                    if (Mount_Life_Reduce_Stamina_mCore_Unk1_raw == value) return;
                    Mount_Life_Reduce_Stamina_mCore_Unk1_raw = value;
                    OnPropertyChanged(nameof(Mount_Life_Reduce_Stamina_mCore_Unk1));
                }
            }

            protected float Mount_Life_Reduce_Stamina_mCore_Unk2_raw;
            public const string Mount_Life_Reduce_Stamina_mCore_Unk2_displayName = "Mount Life Reduce Stamina mCore: Unk2";
            public const int Mount_Life_Reduce_Stamina_mCore_Unk2_sortIndex = 3450;
            [SortOrder(Mount_Life_Reduce_Stamina_mCore_Unk2_sortIndex)]
            [DisplayName(Mount_Life_Reduce_Stamina_mCore_Unk2_displayName)]
            public virtual float Mount_Life_Reduce_Stamina_mCore_Unk2 {
                get => Mount_Life_Reduce_Stamina_mCore_Unk2_raw;
                set {
                    if (Mount_Life_Reduce_Stamina_mCore_Unk2_raw == value) return;
                    Mount_Life_Reduce_Stamina_mCore_Unk2_raw = value;
                    OnPropertyChanged(nameof(Mount_Life_Reduce_Stamina_mCore_Unk2));
                }
            }

            protected float Mount_Life_Reduce_Stamina_mCore_Unk3_raw;
            public const string Mount_Life_Reduce_Stamina_mCore_Unk3_displayName = "Mount Life Reduce Stamina mCore: Unk3";
            public const int Mount_Life_Reduce_Stamina_mCore_Unk3_sortIndex = 3500;
            [SortOrder(Mount_Life_Reduce_Stamina_mCore_Unk3_sortIndex)]
            [DisplayName(Mount_Life_Reduce_Stamina_mCore_Unk3_displayName)]
            public virtual float Mount_Life_Reduce_Stamina_mCore_Unk3 {
                get => Mount_Life_Reduce_Stamina_mCore_Unk3_raw;
                set {
                    if (Mount_Life_Reduce_Stamina_mCore_Unk3_raw == value) return;
                    Mount_Life_Reduce_Stamina_mCore_Unk3_raw = value;
                    OnPropertyChanged(nameof(Mount_Life_Reduce_Stamina_mCore_Unk3));
                }
            }

            protected float Mount_Life_Reduce_Stamina_mCore_Unk4_raw;
            public const string Mount_Life_Reduce_Stamina_mCore_Unk4_displayName = "Mount Life Reduce Stamina mCore: Unk4";
            public const int Mount_Life_Reduce_Stamina_mCore_Unk4_sortIndex = 3550;
            [SortOrder(Mount_Life_Reduce_Stamina_mCore_Unk4_sortIndex)]
            [DisplayName(Mount_Life_Reduce_Stamina_mCore_Unk4_displayName)]
            public virtual float Mount_Life_Reduce_Stamina_mCore_Unk4 {
                get => Mount_Life_Reduce_Stamina_mCore_Unk4_raw;
                set {
                    if (Mount_Life_Reduce_Stamina_mCore_Unk4_raw == value) return;
                    Mount_Life_Reduce_Stamina_mCore_Unk4_raw = value;
                    OnPropertyChanged(nameof(Mount_Life_Reduce_Stamina_mCore_Unk4));
                }
            }

            protected float Unk_66_raw;
            public const string Unk_66_displayName = "Unk 66";
            public const int Unk_66_sortIndex = 3600;
            [SortOrder(Unk_66_sortIndex)]
            [DisplayName(Unk_66_displayName)]
            public virtual float Unk_66 {
                get => Unk_66_raw;
                set {
                    if (Unk_66_raw == value) return;
                    Unk_66_raw = value;
                    OnPropertyChanged(nameof(Unk_66));
                }
            }

            protected float Unk_67_raw;
            public const string Unk_67_displayName = "Unk 67";
            public const int Unk_67_sortIndex = 3650;
            [SortOrder(Unk_67_sortIndex)]
            [DisplayName(Unk_67_displayName)]
            public virtual float Unk_67 {
                get => Unk_67_raw;
                set {
                    if (Unk_67_raw == value) return;
                    Unk_67_raw = value;
                    OnPropertyChanged(nameof(Unk_67));
                }
            }

            protected float Unk_68_raw;
            public const string Unk_68_displayName = "Unk 68";
            public const int Unk_68_sortIndex = 3700;
            [SortOrder(Unk_68_sortIndex)]
            [DisplayName(Unk_68_displayName)]
            public virtual float Unk_68 {
                get => Unk_68_raw;
                set {
                    if (Unk_68_raw == value) return;
                    Unk_68_raw = value;
                    OnPropertyChanged(nameof(Unk_68));
                }
            }

            protected float Explosive_HR_Fixed_Attack_Rate_raw;
            public const string Explosive_HR_Fixed_Attack_Rate_displayName = "Explosive HR Fixed Attack Rate";
            public const int Explosive_HR_Fixed_Attack_Rate_sortIndex = 3750;
            [SortOrder(Explosive_HR_Fixed_Attack_Rate_sortIndex)]
            [DisplayName(Explosive_HR_Fixed_Attack_Rate_displayName)]
            public virtual float Explosive_HR_Fixed_Attack_Rate {
                get => Explosive_HR_Fixed_Attack_Rate_raw;
                set {
                    if (Explosive_HR_Fixed_Attack_Rate_raw == value) return;
                    Explosive_HR_Fixed_Attack_Rate_raw = value;
                    OnPropertyChanged(nameof(Explosive_HR_Fixed_Attack_Rate));
                }
            }

            protected float Explosive_MR_Fixed_Attack_Rate_raw;
            public const string Explosive_MR_Fixed_Attack_Rate_displayName = "Explosive MR Fixed Attack Rate";
            public const int Explosive_MR_Fixed_Attack_Rate_sortIndex = 3800;
            [SortOrder(Explosive_MR_Fixed_Attack_Rate_sortIndex)]
            [DisplayName(Explosive_MR_Fixed_Attack_Rate_displayName)]
            public virtual float Explosive_MR_Fixed_Attack_Rate {
                get => Explosive_MR_Fixed_Attack_Rate_raw;
                set {
                    if (Explosive_MR_Fixed_Attack_Rate_raw == value) return;
                    Explosive_MR_Fixed_Attack_Rate_raw = value;
                    OnPropertyChanged(nameof(Explosive_MR_Fixed_Attack_Rate));
                }
            }

            protected float Critical_Attack_Rate_raw;
            public const string Critical_Attack_Rate_displayName = "Critical Attack Rate";
            public const int Critical_Attack_Rate_sortIndex = 3850;
            [SortOrder(Critical_Attack_Rate_sortIndex)]
            [DisplayName(Critical_Attack_Rate_displayName)]
            public virtual float Critical_Attack_Rate {
                get => Critical_Attack_Rate_raw;
                set {
                    if (Critical_Attack_Rate_raw == value) return;
                    Critical_Attack_Rate_raw = value;
                    OnPropertyChanged(nameof(Critical_Attack_Rate));
                }
            }

            protected float Bad_Critical_Attack_Rate_raw;
            public const string Bad_Critical_Attack_Rate_displayName = "Bad Critical Attack Rate";
            public const int Bad_Critical_Attack_Rate_sortIndex = 3900;
            [SortOrder(Bad_Critical_Attack_Rate_sortIndex)]
            [DisplayName(Bad_Critical_Attack_Rate_displayName)]
            public virtual float Bad_Critical_Attack_Rate {
                get => Bad_Critical_Attack_Rate_raw;
                set {
                    if (Bad_Critical_Attack_Rate_raw == value) return;
                    Bad_Critical_Attack_Rate_raw = value;
                    OnPropertyChanged(nameof(Bad_Critical_Attack_Rate));
                }
            }

            protected byte Sharpness_Recoil_Reduction__raw;
            public const string Sharpness_Recoil_Reduction__displayName = "Sharpness Recoil Reduction %";
            public const int Sharpness_Recoil_Reduction__sortIndex = 3950;
            [SortOrder(Sharpness_Recoil_Reduction__sortIndex)]
            [DisplayName(Sharpness_Recoil_Reduction__displayName)]
            public virtual byte Sharpness_Recoil_Reduction_ {
                get => Sharpness_Recoil_Reduction__raw;
                set {
                    if (Sharpness_Recoil_Reduction__raw == value) return;
                    Sharpness_Recoil_Reduction__raw = value;
                    OnPropertyChanged(nameof(Sharpness_Recoil_Reduction_));
                }
            }

            protected byte Sharpness_Recoil_Reduction_Value_raw;
            public const string Sharpness_Recoil_Reduction_Value_displayName = "Sharpness Recoil Reduction Value";
            public const int Sharpness_Recoil_Reduction_Value_sortIndex = 4000;
            [SortOrder(Sharpness_Recoil_Reduction_Value_sortIndex)]
            [DisplayName(Sharpness_Recoil_Reduction_Value_displayName)]
            public virtual byte Sharpness_Recoil_Reduction_Value {
                get => Sharpness_Recoil_Reduction_Value_raw;
                set {
                    if (Sharpness_Recoil_Reduction_Value_raw == value) return;
                    Sharpness_Recoil_Reduction_Value_raw = value;
                    OnPropertyChanged(nameof(Sharpness_Recoil_Reduction_Value));
                }
            }

            protected float Unk_69_raw;
            public const string Unk_69_displayName = "Unk 69";
            public const int Unk_69_sortIndex = 4050;
            [SortOrder(Unk_69_sortIndex)]
            [DisplayName(Unk_69_displayName)]
            public virtual float Unk_69 {
                get => Unk_69_raw;
                set {
                    if (Unk_69_raw == value) return;
                    Unk_69_raw = value;
                    OnPropertyChanged(nameof(Unk_69));
                }
            }

            protected float Unk_70_raw;
            public const string Unk_70_displayName = "Unk 70";
            public const int Unk_70_sortIndex = 4100;
            [SortOrder(Unk_70_sortIndex)]
            [DisplayName(Unk_70_displayName)]
            public virtual float Unk_70 {
                get => Unk_70_raw;
                set {
                    if (Unk_70_raw == value) return;
                    Unk_70_raw = value;
                    OnPropertyChanged(nameof(Unk_70));
                }
            }

            protected float Unk_71_raw;
            public const string Unk_71_displayName = "Unk 71";
            public const int Unk_71_sortIndex = 4150;
            [SortOrder(Unk_71_sortIndex)]
            [DisplayName(Unk_71_displayName)]
            public virtual float Unk_71 {
                get => Unk_71_raw;
                set {
                    if (Unk_71_raw == value) return;
                    Unk_71_raw = value;
                    OnPropertyChanged(nameof(Unk_71));
                }
            }

            protected float Unk_72_raw;
            public const string Unk_72_displayName = "Unk 72";
            public const int Unk_72_sortIndex = 4200;
            [SortOrder(Unk_72_sortIndex)]
            [DisplayName(Unk_72_displayName)]
            public virtual float Unk_72 {
                get => Unk_72_raw;
                set {
                    if (Unk_72_raw == value) return;
                    Unk_72_raw = value;
                    OnPropertyChanged(nameof(Unk_72));
                }
            }

            protected uint Unk_73_raw;
            public const string Unk_73_displayName = "Unk 73";
            public const int Unk_73_sortIndex = 4250;
            [SortOrder(Unk_73_sortIndex)]
            [DisplayName(Unk_73_displayName)]
            public virtual uint Unk_73 {
                get => Unk_73_raw;
                set {
                    if (Unk_73_raw == value) return;
                    Unk_73_raw = value;
                    OnPropertyChanged(nameof(Unk_73));
                }
            }

            protected float Physical_Attack_Rate_Limit_raw;
            public const string Physical_Attack_Rate_Limit_displayName = "Physical Attack Rate Limit";
            public const int Physical_Attack_Rate_Limit_sortIndex = 4300;
            [SortOrder(Physical_Attack_Rate_Limit_sortIndex)]
            [DisplayName(Physical_Attack_Rate_Limit_displayName)]
            public virtual float Physical_Attack_Rate_Limit {
                get => Physical_Attack_Rate_Limit_raw;
                set {
                    if (Physical_Attack_Rate_Limit_raw == value) return;
                    Physical_Attack_Rate_Limit_raw = value;
                    OnPropertyChanged(nameof(Physical_Attack_Rate_Limit));
                }
            }

            protected float Elemental_Attack_Rate_Limit_raw;
            public const string Elemental_Attack_Rate_Limit_displayName = "Elemental Attack Rate Limit";
            public const int Elemental_Attack_Rate_Limit_sortIndex = 4350;
            [SortOrder(Elemental_Attack_Rate_Limit_sortIndex)]
            [DisplayName(Elemental_Attack_Rate_Limit_displayName)]
            public virtual float Elemental_Attack_Rate_Limit {
                get => Elemental_Attack_Rate_Limit_raw;
                set {
                    if (Elemental_Attack_Rate_Limit_raw == value) return;
                    Elemental_Attack_Rate_Limit_raw = value;
                    OnPropertyChanged(nameof(Elemental_Attack_Rate_Limit));
                }
            }

            protected float Condition_Elemental_Attack_Flat_Limit_raw;
            public const string Condition_Elemental_Attack_Flat_Limit_displayName = "Condition Elemental Attack Flat Limit";
            public const int Condition_Elemental_Attack_Flat_Limit_sortIndex = 4400;
            [SortOrder(Condition_Elemental_Attack_Flat_Limit_sortIndex)]
            [DisplayName(Condition_Elemental_Attack_Flat_Limit_displayName)]
            public virtual float Condition_Elemental_Attack_Flat_Limit {
                get => Condition_Elemental_Attack_Flat_Limit_raw;
                set {
                    if (Condition_Elemental_Attack_Flat_Limit_raw == value) return;
                    Condition_Elemental_Attack_Flat_Limit_raw = value;
                    OnPropertyChanged(nameof(Condition_Elemental_Attack_Flat_Limit));
                }
            }

            protected float Bowgun_Elemental_Attack_Rate_Limit_raw;
            public const string Bowgun_Elemental_Attack_Rate_Limit_displayName = "Bowgun Elemental Attack Rate Limit";
            public const int Bowgun_Elemental_Attack_Rate_Limit_sortIndex = 4450;
            [SortOrder(Bowgun_Elemental_Attack_Rate_Limit_sortIndex)]
            [DisplayName(Bowgun_Elemental_Attack_Rate_Limit_displayName)]
            public virtual float Bowgun_Elemental_Attack_Rate_Limit {
                get => Bowgun_Elemental_Attack_Rate_Limit_raw;
                set {
                    if (Bowgun_Elemental_Attack_Rate_Limit_raw == value) return;
                    Bowgun_Elemental_Attack_Rate_Limit_raw = value;
                    OnPropertyChanged(nameof(Bowgun_Elemental_Attack_Rate_Limit));
                }
            }

            protected float Condition_Attack_Rate_Limit_raw;
            public const string Condition_Attack_Rate_Limit_displayName = "Condition Attack Rate Limit";
            public const int Condition_Attack_Rate_Limit_sortIndex = 4500;
            [SortOrder(Condition_Attack_Rate_Limit_sortIndex)]
            [DisplayName(Condition_Attack_Rate_Limit_displayName)]
            public virtual float Condition_Attack_Rate_Limit {
                get => Condition_Attack_Rate_Limit_raw;
                set {
                    if (Condition_Attack_Rate_Limit_raw == value) return;
                    Condition_Attack_Rate_Limit_raw = value;
                    OnPropertyChanged(nameof(Condition_Attack_Rate_Limit));
                }
            }

            protected float Stun_Attack_Rate_Limit_raw;
            public const string Stun_Attack_Rate_Limit_displayName = "Stun Attack Rate Limit";
            public const int Stun_Attack_Rate_Limit_sortIndex = 4550;
            [SortOrder(Stun_Attack_Rate_Limit_sortIndex)]
            [DisplayName(Stun_Attack_Rate_Limit_displayName)]
            public virtual float Stun_Attack_Rate_Limit {
                get => Stun_Attack_Rate_Limit_raw;
                set {
                    if (Stun_Attack_Rate_Limit_raw == value) return;
                    Stun_Attack_Rate_Limit_raw = value;
                    OnPropertyChanged(nameof(Stun_Attack_Rate_Limit));
                }
            }

            protected float Stamina_Attack_Rate_Limit_raw;
            public const string Stamina_Attack_Rate_Limit_displayName = "Stamina Attack Rate Limit";
            public const int Stamina_Attack_Rate_Limit_sortIndex = 4600;
            [SortOrder(Stamina_Attack_Rate_Limit_sortIndex)]
            [DisplayName(Stamina_Attack_Rate_Limit_displayName)]
            public virtual float Stamina_Attack_Rate_Limit {
                get => Stamina_Attack_Rate_Limit_raw;
                set {
                    if (Stamina_Attack_Rate_Limit_raw == value) return;
                    Stamina_Attack_Rate_Limit_raw = value;
                    OnPropertyChanged(nameof(Stamina_Attack_Rate_Limit));
                }
            }

            protected float Mount_Attack_Rate_Limit_raw;
            public const string Mount_Attack_Rate_Limit_displayName = "Mount Attack Rate Limit";
            public const int Mount_Attack_Rate_Limit_sortIndex = 4650;
            [SortOrder(Mount_Attack_Rate_Limit_sortIndex)]
            [DisplayName(Mount_Attack_Rate_Limit_displayName)]
            public virtual float Mount_Attack_Rate_Limit {
                get => Mount_Attack_Rate_Limit_raw;
                set {
                    if (Mount_Attack_Rate_Limit_raw == value) return;
                    Mount_Attack_Rate_Limit_raw = value;
                    OnPropertyChanged(nameof(Mount_Attack_Rate_Limit));
                }
            }

            protected float Super_Armor_Stun_Damage_Rate_raw;
            public const string Super_Armor_Stun_Damage_Rate_displayName = "Super Armor Stun Damage Rate";
            public const int Super_Armor_Stun_Damage_Rate_sortIndex = 4700;
            [SortOrder(Super_Armor_Stun_Damage_Rate_sortIndex)]
            [DisplayName(Super_Armor_Stun_Damage_Rate_displayName)]
            public virtual float Super_Armor_Stun_Damage_Rate {
                get => Super_Armor_Stun_Damage_Rate_raw;
                set {
                    if (Super_Armor_Stun_Damage_Rate_raw == value) return;
                    Super_Armor_Stun_Damage_Rate_raw = value;
                    OnPropertyChanged(nameof(Super_Armor_Stun_Damage_Rate));
                }
            }

            protected float Hyper_Armor_Damage_Rate_raw;
            public const string Hyper_Armor_Damage_Rate_displayName = "Hyper Armor Damage Rate";
            public const int Hyper_Armor_Damage_Rate_sortIndex = 4750;
            [SortOrder(Hyper_Armor_Damage_Rate_sortIndex)]
            [DisplayName(Hyper_Armor_Damage_Rate_displayName)]
            public virtual float Hyper_Armor_Damage_Rate {
                get => Hyper_Armor_Damage_Rate_raw;
                set {
                    if (Hyper_Armor_Damage_Rate_raw == value) return;
                    Hyper_Armor_Damage_Rate_raw = value;
                    OnPropertyChanged(nameof(Hyper_Armor_Damage_Rate));
                }
            }

            protected float Hyper_Armor_Stun_Damage_Rate_raw;
            public const string Hyper_Armor_Stun_Damage_Rate_displayName = "Hyper Armor Stun Damage Rate";
            public const int Hyper_Armor_Stun_Damage_Rate_sortIndex = 4800;
            [SortOrder(Hyper_Armor_Stun_Damage_Rate_sortIndex)]
            [DisplayName(Hyper_Armor_Stun_Damage_Rate_displayName)]
            public virtual float Hyper_Armor_Stun_Damage_Rate {
                get => Hyper_Armor_Stun_Damage_Rate_raw;
                set {
                    if (Hyper_Armor_Stun_Damage_Rate_raw == value) return;
                    Hyper_Armor_Stun_Damage_Rate_raw = value;
                    OnPropertyChanged(nameof(Hyper_Armor_Stun_Damage_Rate));
                }
            }

            protected float Gunner_Defense_Rate_raw;
            public const string Gunner_Defense_Rate_displayName = "Gunner Defense Rate";
            public const int Gunner_Defense_Rate_sortIndex = 4850;
            [SortOrder(Gunner_Defense_Rate_sortIndex)]
            [DisplayName(Gunner_Defense_Rate_displayName)]
            public virtual float Gunner_Defense_Rate {
                get => Gunner_Defense_Rate_raw;
                set {
                    if (Gunner_Defense_Rate_raw == value) return;
                    Gunner_Defense_Rate_raw = value;
                    OnPropertyChanged(nameof(Gunner_Defense_Rate));
                }
            }

            protected byte Gunner_Elemental_Resistance_Bonus_raw;
            public const string Gunner_Elemental_Resistance_Bonus_displayName = "Gunner Elemental Resistance Bonus";
            public const int Gunner_Elemental_Resistance_Bonus_sortIndex = 4900;
            [SortOrder(Gunner_Elemental_Resistance_Bonus_sortIndex)]
            [DisplayName(Gunner_Elemental_Resistance_Bonus_displayName)]
            public virtual byte Gunner_Elemental_Resistance_Bonus {
                get => Gunner_Elemental_Resistance_Bonus_raw;
                set {
                    if (Gunner_Elemental_Resistance_Bonus_raw == value) return;
                    Gunner_Elemental_Resistance_Bonus_raw = value;
                    OnPropertyChanged(nameof(Gunner_Elemental_Resistance_Bonus));
                }
            }

            protected float Lava_Damage_Interval_Time_raw;
            public const string Lava_Damage_Interval_Time_displayName = "Lava Damage Interval Time";
            public const int Lava_Damage_Interval_Time_sortIndex = 4950;
            [SortOrder(Lava_Damage_Interval_Time_sortIndex)]
            [DisplayName(Lava_Damage_Interval_Time_displayName)]
            public virtual float Lava_Damage_Interval_Time {
                get => Lava_Damage_Interval_Time_raw;
                set {
                    if (Lava_Damage_Interval_Time_raw == value) return;
                    Lava_Damage_Interval_Time_raw = value;
                    OnPropertyChanged(nameof(Lava_Damage_Interval_Time));
                }
            }

            protected float Lava_Damage_Damage_raw;
            public const string Lava_Damage_Damage_displayName = "Lava Damage Damage";
            public const int Lava_Damage_Damage_sortIndex = 5000;
            [SortOrder(Lava_Damage_Damage_sortIndex)]
            [DisplayName(Lava_Damage_Damage_displayName)]
            public virtual float Lava_Damage_Damage {
                get => Lava_Damage_Damage_raw;
                set {
                    if (Lava_Damage_Damage_raw == value) return;
                    Lava_Damage_Damage_raw = value;
                    OnPropertyChanged(nameof(Lava_Damage_Damage));
                }
            }

            protected float Acid_Damage_Interval_Time_raw;
            public const string Acid_Damage_Interval_Time_displayName = "Acid Damage Interval Time";
            public const int Acid_Damage_Interval_Time_sortIndex = 5050;
            [SortOrder(Acid_Damage_Interval_Time_sortIndex)]
            [DisplayName(Acid_Damage_Interval_Time_displayName)]
            public virtual float Acid_Damage_Interval_Time {
                get => Acid_Damage_Interval_Time_raw;
                set {
                    if (Acid_Damage_Interval_Time_raw == value) return;
                    Acid_Damage_Interval_Time_raw = value;
                    OnPropertyChanged(nameof(Acid_Damage_Interval_Time));
                }
            }

            protected float Acid_Damage_Damage_raw;
            public const string Acid_Damage_Damage_displayName = "Acid Damage Damage";
            public const int Acid_Damage_Damage_sortIndex = 5100;
            [SortOrder(Acid_Damage_Damage_sortIndex)]
            [DisplayName(Acid_Damage_Damage_displayName)]
            public virtual float Acid_Damage_Damage {
                get => Acid_Damage_Damage_raw;
                set {
                    if (Acid_Damage_Damage_raw == value) return;
                    Acid_Damage_Damage_raw = value;
                    OnPropertyChanged(nameof(Acid_Damage_Damage));
                }
            }

            public const int lastSortIndex = 5150;

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Player_Params_3_ LoadData(BinaryReader reader, ulong i) {
                var data = new Player_Params_3_();
                data.Index = i;
                data.Unk_56_raw = reader.ReadSingle();
                data.Unk_57_raw = reader.ReadUInt32();
                data.Unk_58_raw = reader.ReadUInt32();
                data.Unk_59_raw = reader.ReadSingle();
                data.Unk_60_raw = reader.ReadSingle();
                data.Unk_61_raw = reader.ReadSingle();
                data.Unk_62_raw = reader.ReadSingle();
                data.Unk_63_raw = reader.ReadSingle();
                data.Unk_64_raw = reader.ReadSingle();
                data.Unk_65_raw = reader.ReadSingle();
                data.Health_Initial_Value_raw = reader.ReadSingle();
                data.Health_Max_Value_raw = reader.ReadSingle();
                data.Health_Damage_Recovery_Rate_raw = reader.ReadSingle();
                data.Health_Damage_Recovery_Wait_Time_raw = reader.ReadSingle();
                data.Health_Damage_Recovery_Interval_raw = reader.ReadSingle();
                data.Health_Damage_Recovery_Value_raw = reader.ReadSingle();
                data.Stamina_Initial_Value_raw = reader.ReadSingle();
                data.Stamina_Max_Value_raw = reader.ReadSingle();
                data.Stamina_Min_Value_raw = reader.ReadSingle();
                data.Stamina_Tired_Value_raw = reader.ReadSingle();
                data.Stamina_Auto_Recover_raw = reader.ReadSingle();
                data.Stamina_Auto_Max_Reduce_raw = reader.ReadSingle();
                data.Stamina_Auto_Max_Reduce_Time_raw = reader.ReadSingle();
                data.Stamina_IB_Unknown_raw = reader.ReadSingle();
                data.Stamina_Escape_Dash_Rate_raw = reader.ReadSingle();
                data.Stamina_Out_of_Battle_Rate_raw = reader.ReadSingle();
                data.Stamina_Reduce_Rate_Limit_Trigger_raw = reader.ReadSingle();
                data.Stamina_Reduce_Rate_Limit_Time_raw = reader.ReadSingle();
                data.Stamina_Mount_Endurance_Rate_raw = reader.ReadSingle();
                data.Stamina_Consumption_Dodge_raw = reader.ReadSingle();
                data.Stamina_Consumption_LS_Counter_raw = reader.ReadSingle();
                data.Stamina_Consumption_SA_Wild_Swing_raw = reader.ReadSingle();
                data.Stamina_Consumption_Unk1_raw = reader.ReadSingle();
                data.Stamina_Consumption_Unk2_raw = reader.ReadSingle();
                data.Stamina_Consumption_Unk3_raw = reader.ReadSingle();
                data.Stamina_Consumption_Bow_Shoot_raw = reader.ReadSingle();
                data.Stamina_Consumption_Unk4_raw = reader.ReadSingle();
                data.Stamina_Consumption_Unk5_raw = reader.ReadSingle();
                data.Stamina_Consumption_Unk6_raw = reader.ReadSingle();
                data.Stamina_Consumption_Bow_Charge_Step_raw = reader.ReadSingle();
                data.Stamina_Consumption_Unk7_raw = reader.ReadSingle();
                data.Stamina_Consumption_Claw_Attack_1_raw = reader.ReadSingle();
                data.Stamina_Consumption_Claw_Attack_2_raw = reader.ReadSingle();
                data.Stamina_Consumption_Claw_Attack_3_raw = reader.ReadSingle();
                data.Stamina_Consumption_Claw_Attack_4_raw = reader.ReadSingle();
                data.Stamina_Consumption_Unk8_raw = reader.ReadSingle();
                data.Stamina_Consumption_Unk9_raw = reader.ReadSingle();
                data.Stamina_Time_Reduce_mCore_Unk1_raw = reader.ReadSingle();
                data.Stamina_Time_Reduce_mCore_Unk2_raw = reader.ReadSingle();
                data.Stamina_Time_Reduce_mCore_Unk3_raw = reader.ReadSingle();
                data.Stamina_Time_Reduce_mCore_Hammer_Bow_Charge_Drain_raw = reader.ReadSingle();
                data.Stamina_Time_Reduce_mCore_Unk4_raw = reader.ReadSingle();
                data.Stamina_Time_Reduce_mCore_Unk5_raw = reader.ReadSingle();
                data.Stamina_Time_Reduce_mCore_Unk6_raw = reader.ReadSingle();
                data.Stamina_Time_Reduce_mCore_Unk7_raw = reader.ReadSingle();
                data.Stamina_Time_Reduce_mCore_Lance_s_Power_Guard_raw = reader.ReadSingle();
                data.Stamina_Time_Reduce_mCore_Unk8_raw = reader.ReadSingle();
                data.Stamina_Time_Reduce_mCore_Clutch_Drain_Whilst_Grappled__raw = reader.ReadSingle();
                data.Stamina_Time_Reduce_mCore_Clutch_Counter_raw = reader.ReadSingle();
                data.Stamina_Time_Reduce_mCore_Unk9_raw = reader.ReadSingle();
                data.Stamina_Time_Reduce_mCore_Unk10_raw = reader.ReadSingle();
                data.Stamina_Time_Reduce_mCore_Unk11_raw = reader.ReadSingle();
                data.Stamina_Time_Reduce_mCore_Unk12_raw = reader.ReadSingle();
                data.Stamina_Time_Reduce_mCore_Unk13_raw = reader.ReadSingle();
                data.Stamina_Time_Reduce_mCore_Unk14_raw = reader.ReadSingle();
                data.Mount_Reduce_Stamina_mCore_Unk1_raw = reader.ReadSingle();
                data.Mount_Reduce_Stamina_mCore_Unk2_raw = reader.ReadSingle();
                data.Mount_Life_Reduce_Stamina_mCore_Unk1_raw = reader.ReadSingle();
                data.Mount_Life_Reduce_Stamina_mCore_Unk2_raw = reader.ReadSingle();
                data.Mount_Life_Reduce_Stamina_mCore_Unk3_raw = reader.ReadSingle();
                data.Mount_Life_Reduce_Stamina_mCore_Unk4_raw = reader.ReadSingle();
                data.Unk_66_raw = reader.ReadSingle();
                data.Unk_67_raw = reader.ReadSingle();
                data.Unk_68_raw = reader.ReadSingle();
                data.Explosive_HR_Fixed_Attack_Rate_raw = reader.ReadSingle();
                data.Explosive_MR_Fixed_Attack_Rate_raw = reader.ReadSingle();
                data.Critical_Attack_Rate_raw = reader.ReadSingle();
                data.Bad_Critical_Attack_Rate_raw = reader.ReadSingle();
                data.Sharpness_Recoil_Reduction__raw = reader.ReadByte();
                data.Sharpness_Recoil_Reduction_Value_raw = reader.ReadByte();
                data.Unk_69_raw = reader.ReadSingle();
                data.Unk_70_raw = reader.ReadSingle();
                data.Unk_71_raw = reader.ReadSingle();
                data.Unk_72_raw = reader.ReadSingle();
                data.Unk_73_raw = reader.ReadUInt32();
                data.Physical_Attack_Rate_Limit_raw = reader.ReadSingle();
                data.Elemental_Attack_Rate_Limit_raw = reader.ReadSingle();
                data.Condition_Elemental_Attack_Flat_Limit_raw = reader.ReadSingle();
                data.Bowgun_Elemental_Attack_Rate_Limit_raw = reader.ReadSingle();
                data.Condition_Attack_Rate_Limit_raw = reader.ReadSingle();
                data.Stun_Attack_Rate_Limit_raw = reader.ReadSingle();
                data.Stamina_Attack_Rate_Limit_raw = reader.ReadSingle();
                data.Mount_Attack_Rate_Limit_raw = reader.ReadSingle();
                data.Super_Armor_Stun_Damage_Rate_raw = reader.ReadSingle();
                data.Hyper_Armor_Damage_Rate_raw = reader.ReadSingle();
                data.Hyper_Armor_Stun_Damage_Rate_raw = reader.ReadSingle();
                data.Gunner_Defense_Rate_raw = reader.ReadSingle();
                data.Gunner_Elemental_Resistance_Bonus_raw = reader.ReadByte();
                data.Lava_Damage_Interval_Time_raw = reader.ReadSingle();
                data.Lava_Damage_Damage_raw = reader.ReadSingle();
                data.Acid_Damage_Interval_Time_raw = reader.ReadSingle();
                data.Acid_Damage_Damage_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_56_raw);
                writer.Write(Unk_57_raw);
                writer.Write(Unk_58_raw);
                writer.Write(Unk_59_raw);
                writer.Write(Unk_60_raw);
                writer.Write(Unk_61_raw);
                writer.Write(Unk_62_raw);
                writer.Write(Unk_63_raw);
                writer.Write(Unk_64_raw);
                writer.Write(Unk_65_raw);
                writer.Write(Health_Initial_Value_raw);
                writer.Write(Health_Max_Value_raw);
                writer.Write(Health_Damage_Recovery_Rate_raw);
                writer.Write(Health_Damage_Recovery_Wait_Time_raw);
                writer.Write(Health_Damage_Recovery_Interval_raw);
                writer.Write(Health_Damage_Recovery_Value_raw);
                writer.Write(Stamina_Initial_Value_raw);
                writer.Write(Stamina_Max_Value_raw);
                writer.Write(Stamina_Min_Value_raw);
                writer.Write(Stamina_Tired_Value_raw);
                writer.Write(Stamina_Auto_Recover_raw);
                writer.Write(Stamina_Auto_Max_Reduce_raw);
                writer.Write(Stamina_Auto_Max_Reduce_Time_raw);
                writer.Write(Stamina_IB_Unknown_raw);
                writer.Write(Stamina_Escape_Dash_Rate_raw);
                writer.Write(Stamina_Out_of_Battle_Rate_raw);
                writer.Write(Stamina_Reduce_Rate_Limit_Trigger_raw);
                writer.Write(Stamina_Reduce_Rate_Limit_Time_raw);
                writer.Write(Stamina_Mount_Endurance_Rate_raw);
                writer.Write(Stamina_Consumption_Dodge_raw);
                writer.Write(Stamina_Consumption_LS_Counter_raw);
                writer.Write(Stamina_Consumption_SA_Wild_Swing_raw);
                writer.Write(Stamina_Consumption_Unk1_raw);
                writer.Write(Stamina_Consumption_Unk2_raw);
                writer.Write(Stamina_Consumption_Unk3_raw);
                writer.Write(Stamina_Consumption_Bow_Shoot_raw);
                writer.Write(Stamina_Consumption_Unk4_raw);
                writer.Write(Stamina_Consumption_Unk5_raw);
                writer.Write(Stamina_Consumption_Unk6_raw);
                writer.Write(Stamina_Consumption_Bow_Charge_Step_raw);
                writer.Write(Stamina_Consumption_Unk7_raw);
                writer.Write(Stamina_Consumption_Claw_Attack_1_raw);
                writer.Write(Stamina_Consumption_Claw_Attack_2_raw);
                writer.Write(Stamina_Consumption_Claw_Attack_3_raw);
                writer.Write(Stamina_Consumption_Claw_Attack_4_raw);
                writer.Write(Stamina_Consumption_Unk8_raw);
                writer.Write(Stamina_Consumption_Unk9_raw);
                writer.Write(Stamina_Time_Reduce_mCore_Unk1_raw);
                writer.Write(Stamina_Time_Reduce_mCore_Unk2_raw);
                writer.Write(Stamina_Time_Reduce_mCore_Unk3_raw);
                writer.Write(Stamina_Time_Reduce_mCore_Hammer_Bow_Charge_Drain_raw);
                writer.Write(Stamina_Time_Reduce_mCore_Unk4_raw);
                writer.Write(Stamina_Time_Reduce_mCore_Unk5_raw);
                writer.Write(Stamina_Time_Reduce_mCore_Unk6_raw);
                writer.Write(Stamina_Time_Reduce_mCore_Unk7_raw);
                writer.Write(Stamina_Time_Reduce_mCore_Lance_s_Power_Guard_raw);
                writer.Write(Stamina_Time_Reduce_mCore_Unk8_raw);
                writer.Write(Stamina_Time_Reduce_mCore_Clutch_Drain_Whilst_Grappled__raw);
                writer.Write(Stamina_Time_Reduce_mCore_Clutch_Counter_raw);
                writer.Write(Stamina_Time_Reduce_mCore_Unk9_raw);
                writer.Write(Stamina_Time_Reduce_mCore_Unk10_raw);
                writer.Write(Stamina_Time_Reduce_mCore_Unk11_raw);
                writer.Write(Stamina_Time_Reduce_mCore_Unk12_raw);
                writer.Write(Stamina_Time_Reduce_mCore_Unk13_raw);
                writer.Write(Stamina_Time_Reduce_mCore_Unk14_raw);
                writer.Write(Mount_Reduce_Stamina_mCore_Unk1_raw);
                writer.Write(Mount_Reduce_Stamina_mCore_Unk2_raw);
                writer.Write(Mount_Life_Reduce_Stamina_mCore_Unk1_raw);
                writer.Write(Mount_Life_Reduce_Stamina_mCore_Unk2_raw);
                writer.Write(Mount_Life_Reduce_Stamina_mCore_Unk3_raw);
                writer.Write(Mount_Life_Reduce_Stamina_mCore_Unk4_raw);
                writer.Write(Unk_66_raw);
                writer.Write(Unk_67_raw);
                writer.Write(Unk_68_raw);
                writer.Write(Explosive_HR_Fixed_Attack_Rate_raw);
                writer.Write(Explosive_MR_Fixed_Attack_Rate_raw);
                writer.Write(Critical_Attack_Rate_raw);
                writer.Write(Bad_Critical_Attack_Rate_raw);
                writer.Write(Sharpness_Recoil_Reduction__raw);
                writer.Write(Sharpness_Recoil_Reduction_Value_raw);
                writer.Write(Unk_69_raw);
                writer.Write(Unk_70_raw);
                writer.Write(Unk_71_raw);
                writer.Write(Unk_72_raw);
                writer.Write(Unk_73_raw);
                writer.Write(Physical_Attack_Rate_Limit_raw);
                writer.Write(Elemental_Attack_Rate_Limit_raw);
                writer.Write(Condition_Elemental_Attack_Flat_Limit_raw);
                writer.Write(Bowgun_Elemental_Attack_Rate_Limit_raw);
                writer.Write(Condition_Attack_Rate_Limit_raw);
                writer.Write(Stun_Attack_Rate_Limit_raw);
                writer.Write(Stamina_Attack_Rate_Limit_raw);
                writer.Write(Mount_Attack_Rate_Limit_raw);
                writer.Write(Super_Armor_Stun_Damage_Rate_raw);
                writer.Write(Hyper_Armor_Damage_Rate_raw);
                writer.Write(Hyper_Armor_Stun_Damage_Rate_raw);
                writer.Write(Gunner_Defense_Rate_raw);
                writer.Write(Gunner_Elemental_Resistance_Bonus_raw);
                writer.Write(Lava_Damage_Interval_Time_raw);
                writer.Write(Lava_Damage_Damage_raw);
                writer.Write(Acid_Damage_Interval_Time_raw);
                writer.Write(Acid_Damage_Damage_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Unk 56", "Unk_56"),
                    new MultiStructItemCustomView(this, "Unk 57", "Unk_57"),
                    new MultiStructItemCustomView(this, "Unk 58", "Unk_58"),
                    new MultiStructItemCustomView(this, "Unk 59", "Unk_59"),
                    new MultiStructItemCustomView(this, "Unk 60", "Unk_60"),
                    new MultiStructItemCustomView(this, "Unk 61", "Unk_61"),
                    new MultiStructItemCustomView(this, "Unk 62", "Unk_62"),
                    new MultiStructItemCustomView(this, "Unk 63", "Unk_63"),
                    new MultiStructItemCustomView(this, "Unk 64", "Unk_64"),
                    new MultiStructItemCustomView(this, "Unk 65", "Unk_65"),
                    new MultiStructItemCustomView(this, "Health Initial Value", "Health_Initial_Value"),
                    new MultiStructItemCustomView(this, "Health Max Value", "Health_Max_Value"),
                    new MultiStructItemCustomView(this, "Health Damage Recovery Rate", "Health_Damage_Recovery_Rate"),
                    new MultiStructItemCustomView(this, "Health Damage Recovery Wait Time", "Health_Damage_Recovery_Wait_Time"),
                    new MultiStructItemCustomView(this, "Health Damage Recovery Interval", "Health_Damage_Recovery_Interval"),
                    new MultiStructItemCustomView(this, "Health Damage Recovery Value", "Health_Damage_Recovery_Value"),
                    new MultiStructItemCustomView(this, "Stamina Initial Value", "Stamina_Initial_Value"),
                    new MultiStructItemCustomView(this, "Stamina Max Value", "Stamina_Max_Value"),
                    new MultiStructItemCustomView(this, "Stamina Min Value", "Stamina_Min_Value"),
                    new MultiStructItemCustomView(this, "Stamina Tired Value", "Stamina_Tired_Value"),
                    new MultiStructItemCustomView(this, "Stamina Auto Recover", "Stamina_Auto_Recover"),
                    new MultiStructItemCustomView(this, "Stamina Auto Max Reduce", "Stamina_Auto_Max_Reduce"),
                    new MultiStructItemCustomView(this, "Stamina Auto Max Reduce Time", "Stamina_Auto_Max_Reduce_Time"),
                    new MultiStructItemCustomView(this, "Stamina IB Unknown", "Stamina_IB_Unknown"),
                    new MultiStructItemCustomView(this, "Stamina Escape Dash Rate", "Stamina_Escape_Dash_Rate"),
                    new MultiStructItemCustomView(this, "Stamina Out of Battle Rate", "Stamina_Out_of_Battle_Rate"),
                    new MultiStructItemCustomView(this, "Stamina Reduce Rate Limit Trigger", "Stamina_Reduce_Rate_Limit_Trigger"),
                    new MultiStructItemCustomView(this, "Stamina Reduce Rate Limit Time", "Stamina_Reduce_Rate_Limit_Time"),
                    new MultiStructItemCustomView(this, "Stamina Mount Endurance Rate", "Stamina_Mount_Endurance_Rate"),
                    new MultiStructItemCustomView(this, "Stamina Consumption: Dodge", "Stamina_Consumption_Dodge"),
                    new MultiStructItemCustomView(this, "Stamina Consumption: LS Counter", "Stamina_Consumption_LS_Counter"),
                    new MultiStructItemCustomView(this, "Stamina Consumption: SA Wild Swing", "Stamina_Consumption_SA_Wild_Swing"),
                    new MultiStructItemCustomView(this, "Stamina Consumption: Unk1", "Stamina_Consumption_Unk1"),
                    new MultiStructItemCustomView(this, "Stamina Consumption: Unk2", "Stamina_Consumption_Unk2"),
                    new MultiStructItemCustomView(this, "Stamina Consumption: Unk3", "Stamina_Consumption_Unk3"),
                    new MultiStructItemCustomView(this, "Stamina Consumption: Bow Shoot", "Stamina_Consumption_Bow_Shoot"),
                    new MultiStructItemCustomView(this, "Stamina Consumption: Unk4", "Stamina_Consumption_Unk4"),
                    new MultiStructItemCustomView(this, "Stamina Consumption: Unk5", "Stamina_Consumption_Unk5"),
                    new MultiStructItemCustomView(this, "Stamina Consumption: Unk6", "Stamina_Consumption_Unk6"),
                    new MultiStructItemCustomView(this, "Stamina Consumption: Bow Charge Step", "Stamina_Consumption_Bow_Charge_Step"),
                    new MultiStructItemCustomView(this, "Stamina Consumption: Unk7", "Stamina_Consumption_Unk7"),
                    new MultiStructItemCustomView(this, "Stamina Consumption: Claw Attack 1", "Stamina_Consumption_Claw_Attack_1"),
                    new MultiStructItemCustomView(this, "Stamina Consumption: Claw Attack 2", "Stamina_Consumption_Claw_Attack_2"),
                    new MultiStructItemCustomView(this, "Stamina Consumption: Claw Attack 3", "Stamina_Consumption_Claw_Attack_3"),
                    new MultiStructItemCustomView(this, "Stamina Consumption: Claw Attack 4", "Stamina_Consumption_Claw_Attack_4"),
                    new MultiStructItemCustomView(this, "Stamina Consumption: Unk8", "Stamina_Consumption_Unk8"),
                    new MultiStructItemCustomView(this, "Stamina Consumption: Unk9", "Stamina_Consumption_Unk9"),
                    new MultiStructItemCustomView(this, "Stamina Time Reduce mCore: Unk1", "Stamina_Time_Reduce_mCore_Unk1"),
                    new MultiStructItemCustomView(this, "Stamina Time Reduce mCore: Unk2", "Stamina_Time_Reduce_mCore_Unk2"),
                    new MultiStructItemCustomView(this, "Stamina Time Reduce mCore: Unk3", "Stamina_Time_Reduce_mCore_Unk3"),
                    new MultiStructItemCustomView(this, "Stamina Time Reduce mCore: Hammer/Bow Charge Drain", "Stamina_Time_Reduce_mCore_Hammer_Bow_Charge_Drain"),
                    new MultiStructItemCustomView(this, "Stamina Time Reduce mCore: Unk4", "Stamina_Time_Reduce_mCore_Unk4"),
                    new MultiStructItemCustomView(this, "Stamina Time Reduce mCore: Unk5", "Stamina_Time_Reduce_mCore_Unk5"),
                    new MultiStructItemCustomView(this, "Stamina Time Reduce mCore: Unk6", "Stamina_Time_Reduce_mCore_Unk6"),
                    new MultiStructItemCustomView(this, "Stamina Time Reduce mCore: Unk7", "Stamina_Time_Reduce_mCore_Unk7"),
                    new MultiStructItemCustomView(this, "Stamina Time Reduce mCore: Lance's Power Guard", "Stamina_Time_Reduce_mCore_Lance_s_Power_Guard"),
                    new MultiStructItemCustomView(this, "Stamina Time Reduce mCore: Unk8", "Stamina_Time_Reduce_mCore_Unk8"),
                    new MultiStructItemCustomView(this, "Stamina Time Reduce mCore: Clutch Drain (Whilst Grappled)", "Stamina_Time_Reduce_mCore_Clutch_Drain_Whilst_Grappled_"),
                    new MultiStructItemCustomView(this, "Stamina Time Reduce mCore: Clutch-Counter", "Stamina_Time_Reduce_mCore_Clutch_Counter"),
                    new MultiStructItemCustomView(this, "Stamina Time Reduce mCore: Unk9", "Stamina_Time_Reduce_mCore_Unk9"),
                    new MultiStructItemCustomView(this, "Stamina Time Reduce mCore: Unk10", "Stamina_Time_Reduce_mCore_Unk10"),
                    new MultiStructItemCustomView(this, "Stamina Time Reduce mCore: Unk11", "Stamina_Time_Reduce_mCore_Unk11"),
                    new MultiStructItemCustomView(this, "Stamina Time Reduce mCore: Unk12", "Stamina_Time_Reduce_mCore_Unk12"),
                    new MultiStructItemCustomView(this, "Stamina Time Reduce mCore: Unk13", "Stamina_Time_Reduce_mCore_Unk13"),
                    new MultiStructItemCustomView(this, "Stamina Time Reduce mCore: Unk14", "Stamina_Time_Reduce_mCore_Unk14"),
                    new MultiStructItemCustomView(this, "Mount Reduce Stamina mCore: Unk1", "Mount_Reduce_Stamina_mCore_Unk1"),
                    new MultiStructItemCustomView(this, "Mount Reduce Stamina mCore: Unk2", "Mount_Reduce_Stamina_mCore_Unk2"),
                    new MultiStructItemCustomView(this, "Mount Life Reduce Stamina mCore: Unk1", "Mount_Life_Reduce_Stamina_mCore_Unk1"),
                    new MultiStructItemCustomView(this, "Mount Life Reduce Stamina mCore: Unk2", "Mount_Life_Reduce_Stamina_mCore_Unk2"),
                    new MultiStructItemCustomView(this, "Mount Life Reduce Stamina mCore: Unk3", "Mount_Life_Reduce_Stamina_mCore_Unk3"),
                    new MultiStructItemCustomView(this, "Mount Life Reduce Stamina mCore: Unk4", "Mount_Life_Reduce_Stamina_mCore_Unk4"),
                    new MultiStructItemCustomView(this, "Unk 66", "Unk_66"),
                    new MultiStructItemCustomView(this, "Unk 67", "Unk_67"),
                    new MultiStructItemCustomView(this, "Unk 68", "Unk_68"),
                    new MultiStructItemCustomView(this, "Explosive HR Fixed Attack Rate", "Explosive_HR_Fixed_Attack_Rate"),
                    new MultiStructItemCustomView(this, "Explosive MR Fixed Attack Rate", "Explosive_MR_Fixed_Attack_Rate"),
                    new MultiStructItemCustomView(this, "Critical Attack Rate", "Critical_Attack_Rate"),
                    new MultiStructItemCustomView(this, "Bad Critical Attack Rate", "Bad_Critical_Attack_Rate"),
                    new MultiStructItemCustomView(this, "Sharpness Recoil Reduction %", "Sharpness_Recoil_Reduction_"),
                    new MultiStructItemCustomView(this, "Sharpness Recoil Reduction Value", "Sharpness_Recoil_Reduction_Value"),
                    new MultiStructItemCustomView(this, "Unk 69", "Unk_69"),
                    new MultiStructItemCustomView(this, "Unk 70", "Unk_70"),
                    new MultiStructItemCustomView(this, "Unk 71", "Unk_71"),
                    new MultiStructItemCustomView(this, "Unk 72", "Unk_72"),
                    new MultiStructItemCustomView(this, "Unk 73", "Unk_73"),
                    new MultiStructItemCustomView(this, "Physical Attack Rate Limit", "Physical_Attack_Rate_Limit"),
                    new MultiStructItemCustomView(this, "Elemental Attack Rate Limit", "Elemental_Attack_Rate_Limit"),
                    new MultiStructItemCustomView(this, "Condition Elemental Attack Flat Limit", "Condition_Elemental_Attack_Flat_Limit"),
                    new MultiStructItemCustomView(this, "Bowgun Elemental Attack Rate Limit", "Bowgun_Elemental_Attack_Rate_Limit"),
                    new MultiStructItemCustomView(this, "Condition Attack Rate Limit", "Condition_Attack_Rate_Limit"),
                    new MultiStructItemCustomView(this, "Stun Attack Rate Limit", "Stun_Attack_Rate_Limit"),
                    new MultiStructItemCustomView(this, "Stamina Attack Rate Limit", "Stamina_Attack_Rate_Limit"),
                    new MultiStructItemCustomView(this, "Mount Attack Rate Limit", "Mount_Attack_Rate_Limit"),
                    new MultiStructItemCustomView(this, "Super Armor Stun Damage Rate", "Super_Armor_Stun_Damage_Rate"),
                    new MultiStructItemCustomView(this, "Hyper Armor Damage Rate", "Hyper_Armor_Damage_Rate"),
                    new MultiStructItemCustomView(this, "Hyper Armor Stun Damage Rate", "Hyper_Armor_Stun_Damage_Rate"),
                    new MultiStructItemCustomView(this, "Gunner Defense Rate", "Gunner_Defense_Rate"),
                    new MultiStructItemCustomView(this, "Gunner Elemental Resistance Bonus", "Gunner_Elemental_Resistance_Bonus"),
                    new MultiStructItemCustomView(this, "Lava Damage Interval Time", "Lava_Damage_Interval_Time"),
                    new MultiStructItemCustomView(this, "Lava Damage Damage", "Lava_Damage_Damage"),
                    new MultiStructItemCustomView(this, "Acid Damage Interval Time", "Acid_Damage_Interval_Time"),
                    new MultiStructItemCustomView(this, "Acid Damage Damage", "Acid_Damage_Damage"),
                };
            }
        }

        public partial class CD_Block_1_ : MhwStructItem {
            public const ulong FixedSizeCount = 4;
            public const string GridName = "CD Block (1)";
            public const bool IsHidden = true;

            protected uint Unk_raw;
            public const string Unk_displayName = "Unk";
            public const int Unk_sortIndex = 50;
            [SortOrder(Unk_sortIndex)]
            [DisplayName(Unk_displayName)]
            [IsReadOnly]
            public virtual uint Unk {
                get => Unk_raw;
                set {
                    if (Unk_raw == value) return;
                    Unk_raw = value;
                    OnPropertyChanged(nameof(Unk));
                }
            }

            public const int lastSortIndex = 100;

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
                var count = 4UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static CD_Block_1_ LoadData(BinaryReader reader, ulong i) {
                var data = new CD_Block_1_();
                data.Index = i;
                data.Unk_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_raw);
            }
        }

        public partial class Player_Params_4_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView> {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Player Params (4)";

            protected float Unk_74_raw;
            public const string Unk_74_displayName = "Unk 74";
            public const int Unk_74_sortIndex = 50;
            [SortOrder(Unk_74_sortIndex)]
            [DisplayName(Unk_74_displayName)]
            public virtual float Unk_74 {
                get => Unk_74_raw;
                set {
                    if (Unk_74_raw == value) return;
                    Unk_74_raw = value;
                    OnPropertyChanged(nameof(Unk_74));
                }
            }

            protected float Unk_75_raw;
            public const string Unk_75_displayName = "Unk 75";
            public const int Unk_75_sortIndex = 100;
            [SortOrder(Unk_75_sortIndex)]
            [DisplayName(Unk_75_displayName)]
            public virtual float Unk_75 {
                get => Unk_75_raw;
                set {
                    if (Unk_75_raw == value) return;
                    Unk_75_raw = value;
                    OnPropertyChanged(nameof(Unk_75));
                }
            }

            protected float Walk_Turn_Tilt_Bow__raw;
            public const string Walk_Turn_Tilt_Bow__displayName = "Walk Turn Tilt (Bow)";
            public const int Walk_Turn_Tilt_Bow__sortIndex = 150;
            [SortOrder(Walk_Turn_Tilt_Bow__sortIndex)]
            [DisplayName(Walk_Turn_Tilt_Bow__displayName)]
            public virtual float Walk_Turn_Tilt_Bow_ {
                get => Walk_Turn_Tilt_Bow__raw;
                set {
                    if (Walk_Turn_Tilt_Bow__raw == value) return;
                    Walk_Turn_Tilt_Bow__raw = value;
                    OnPropertyChanged(nameof(Walk_Turn_Tilt_Bow_));
                }
            }

            protected float Unk_76_raw;
            public const string Unk_76_displayName = "Unk 76";
            public const int Unk_76_sortIndex = 200;
            [SortOrder(Unk_76_sortIndex)]
            [DisplayName(Unk_76_displayName)]
            public virtual float Unk_76 {
                get => Unk_76_raw;
                set {
                    if (Unk_76_raw == value) return;
                    Unk_76_raw = value;
                    OnPropertyChanged(nameof(Unk_76));
                }
            }

            protected float Unk_77_raw;
            public const string Unk_77_displayName = "Unk 77";
            public const int Unk_77_sortIndex = 250;
            [SortOrder(Unk_77_sortIndex)]
            [DisplayName(Unk_77_displayName)]
            public virtual float Unk_77 {
                get => Unk_77_raw;
                set {
                    if (Unk_77_raw == value) return;
                    Unk_77_raw = value;
                    OnPropertyChanged(nameof(Unk_77));
                }
            }

            protected float Unk_78_raw;
            public const string Unk_78_displayName = "Unk 78";
            public const int Unk_78_sortIndex = 300;
            [SortOrder(Unk_78_sortIndex)]
            [DisplayName(Unk_78_displayName)]
            public virtual float Unk_78 {
                get => Unk_78_raw;
                set {
                    if (Unk_78_raw == value) return;
                    Unk_78_raw = value;
                    OnPropertyChanged(nameof(Unk_78));
                }
            }

            protected float Run_Turn_Tilt_Bow__raw;
            public const string Run_Turn_Tilt_Bow__displayName = "Run Turn Tilt (Bow)";
            public const int Run_Turn_Tilt_Bow__sortIndex = 350;
            [SortOrder(Run_Turn_Tilt_Bow__sortIndex)]
            [DisplayName(Run_Turn_Tilt_Bow__displayName)]
            public virtual float Run_Turn_Tilt_Bow_ {
                get => Run_Turn_Tilt_Bow__raw;
                set {
                    if (Run_Turn_Tilt_Bow__raw == value) return;
                    Run_Turn_Tilt_Bow__raw = value;
                    OnPropertyChanged(nameof(Run_Turn_Tilt_Bow_));
                }
            }

            protected float Run_Turn_Tilt_Head_Bow__raw;
            public const string Run_Turn_Tilt_Head_Bow__displayName = "Run Turn Tilt Head (Bow)";
            public const int Run_Turn_Tilt_Head_Bow__sortIndex = 400;
            [SortOrder(Run_Turn_Tilt_Head_Bow__sortIndex)]
            [DisplayName(Run_Turn_Tilt_Head_Bow__displayName)]
            public virtual float Run_Turn_Tilt_Head_Bow_ {
                get => Run_Turn_Tilt_Head_Bow__raw;
                set {
                    if (Run_Turn_Tilt_Head_Bow__raw == value) return;
                    Run_Turn_Tilt_Head_Bow__raw = value;
                    OnPropertyChanged(nameof(Run_Turn_Tilt_Head_Bow_));
                }
            }

            protected float Unk_79_raw;
            public const string Unk_79_displayName = "Unk 79";
            public const int Unk_79_sortIndex = 450;
            [SortOrder(Unk_79_sortIndex)]
            [DisplayName(Unk_79_displayName)]
            public virtual float Unk_79 {
                get => Unk_79_raw;
                set {
                    if (Unk_79_raw == value) return;
                    Unk_79_raw = value;
                    OnPropertyChanged(nameof(Unk_79));
                }
            }

            protected float Unk_80_raw;
            public const string Unk_80_displayName = "Unk 80";
            public const int Unk_80_sortIndex = 500;
            [SortOrder(Unk_80_sortIndex)]
            [DisplayName(Unk_80_displayName)]
            public virtual float Unk_80 {
                get => Unk_80_raw;
                set {
                    if (Unk_80_raw == value) return;
                    Unk_80_raw = value;
                    OnPropertyChanged(nameof(Unk_80));
                }
            }

            protected float Unk_81_raw;
            public const string Unk_81_displayName = "Unk 81";
            public const int Unk_81_sortIndex = 550;
            [SortOrder(Unk_81_sortIndex)]
            [DisplayName(Unk_81_displayName)]
            public virtual float Unk_81 {
                get => Unk_81_raw;
                set {
                    if (Unk_81_raw == value) return;
                    Unk_81_raw = value;
                    OnPropertyChanged(nameof(Unk_81));
                }
            }

            protected float Unk_82_raw;
            public const string Unk_82_displayName = "Unk 82";
            public const int Unk_82_sortIndex = 600;
            [SortOrder(Unk_82_sortIndex)]
            [DisplayName(Unk_82_displayName)]
            public virtual float Unk_82 {
                get => Unk_82_raw;
                set {
                    if (Unk_82_raw == value) return;
                    Unk_82_raw = value;
                    OnPropertyChanged(nameof(Unk_82));
                }
            }

            protected float Unk_83_raw;
            public const string Unk_83_displayName = "Unk 83";
            public const int Unk_83_sortIndex = 650;
            [SortOrder(Unk_83_sortIndex)]
            [DisplayName(Unk_83_displayName)]
            public virtual float Unk_83 {
                get => Unk_83_raw;
                set {
                    if (Unk_83_raw == value) return;
                    Unk_83_raw = value;
                    OnPropertyChanged(nameof(Unk_83));
                }
            }

            protected float Unk_84_raw;
            public const string Unk_84_displayName = "Unk 84";
            public const int Unk_84_sortIndex = 700;
            [SortOrder(Unk_84_sortIndex)]
            [DisplayName(Unk_84_displayName)]
            public virtual float Unk_84 {
                get => Unk_84_raw;
                set {
                    if (Unk_84_raw == value) return;
                    Unk_84_raw = value;
                    OnPropertyChanged(nameof(Unk_84));
                }
            }

            protected float Unk_85_raw;
            public const string Unk_85_displayName = "Unk 85";
            public const int Unk_85_sortIndex = 750;
            [SortOrder(Unk_85_sortIndex)]
            [DisplayName(Unk_85_displayName)]
            public virtual float Unk_85 {
                get => Unk_85_raw;
                set {
                    if (Unk_85_raw == value) return;
                    Unk_85_raw = value;
                    OnPropertyChanged(nameof(Unk_85));
                }
            }

            protected float Unk_86_raw;
            public const string Unk_86_displayName = "Unk 86";
            public const int Unk_86_sortIndex = 800;
            [SortOrder(Unk_86_sortIndex)]
            [DisplayName(Unk_86_displayName)]
            public virtual float Unk_86 {
                get => Unk_86_raw;
                set {
                    if (Unk_86_raw == value) return;
                    Unk_86_raw = value;
                    OnPropertyChanged(nameof(Unk_86));
                }
            }

            protected float Unk_87_raw;
            public const string Unk_87_displayName = "Unk 87";
            public const int Unk_87_sortIndex = 850;
            [SortOrder(Unk_87_sortIndex)]
            [DisplayName(Unk_87_displayName)]
            public virtual float Unk_87 {
                get => Unk_87_raw;
                set {
                    if (Unk_87_raw == value) return;
                    Unk_87_raw = value;
                    OnPropertyChanged(nameof(Unk_87));
                }
            }

            protected float Unk_88_raw;
            public const string Unk_88_displayName = "Unk 88";
            public const int Unk_88_sortIndex = 900;
            [SortOrder(Unk_88_sortIndex)]
            [DisplayName(Unk_88_displayName)]
            public virtual float Unk_88 {
                get => Unk_88_raw;
                set {
                    if (Unk_88_raw == value) return;
                    Unk_88_raw = value;
                    OnPropertyChanged(nameof(Unk_88));
                }
            }

            protected float Unk_89_raw;
            public const string Unk_89_displayName = "Unk 89";
            public const int Unk_89_sortIndex = 950;
            [SortOrder(Unk_89_sortIndex)]
            [DisplayName(Unk_89_displayName)]
            public virtual float Unk_89 {
                get => Unk_89_raw;
                set {
                    if (Unk_89_raw == value) return;
                    Unk_89_raw = value;
                    OnPropertyChanged(nameof(Unk_89));
                }
            }

            protected float Unk_90_raw;
            public const string Unk_90_displayName = "Unk 90";
            public const int Unk_90_sortIndex = 1000;
            [SortOrder(Unk_90_sortIndex)]
            [DisplayName(Unk_90_displayName)]
            public virtual float Unk_90 {
                get => Unk_90_raw;
                set {
                    if (Unk_90_raw == value) return;
                    Unk_90_raw = value;
                    OnPropertyChanged(nameof(Unk_90));
                }
            }

            protected float Unk_91_raw;
            public const string Unk_91_displayName = "Unk 91";
            public const int Unk_91_sortIndex = 1050;
            [SortOrder(Unk_91_sortIndex)]
            [DisplayName(Unk_91_displayName)]
            public virtual float Unk_91 {
                get => Unk_91_raw;
                set {
                    if (Unk_91_raw == value) return;
                    Unk_91_raw = value;
                    OnPropertyChanged(nameof(Unk_91));
                }
            }

            protected float Unk_92_raw;
            public const string Unk_92_displayName = "Unk 92";
            public const int Unk_92_sortIndex = 1100;
            [SortOrder(Unk_92_sortIndex)]
            [DisplayName(Unk_92_displayName)]
            public virtual float Unk_92 {
                get => Unk_92_raw;
                set {
                    if (Unk_92_raw == value) return;
                    Unk_92_raw = value;
                    OnPropertyChanged(nameof(Unk_92));
                }
            }

            protected float Unk_93_raw;
            public const string Unk_93_displayName = "Unk 93";
            public const int Unk_93_sortIndex = 1150;
            [SortOrder(Unk_93_sortIndex)]
            [DisplayName(Unk_93_displayName)]
            public virtual float Unk_93 {
                get => Unk_93_raw;
                set {
                    if (Unk_93_raw == value) return;
                    Unk_93_raw = value;
                    OnPropertyChanged(nameof(Unk_93));
                }
            }

            protected float Unk_94_raw;
            public const string Unk_94_displayName = "Unk 94";
            public const int Unk_94_sortIndex = 1200;
            [SortOrder(Unk_94_sortIndex)]
            [DisplayName(Unk_94_displayName)]
            public virtual float Unk_94 {
                get => Unk_94_raw;
                set {
                    if (Unk_94_raw == value) return;
                    Unk_94_raw = value;
                    OnPropertyChanged(nameof(Unk_94));
                }
            }

            protected float Unk_95_raw;
            public const string Unk_95_displayName = "Unk 95";
            public const int Unk_95_sortIndex = 1250;
            [SortOrder(Unk_95_sortIndex)]
            [DisplayName(Unk_95_displayName)]
            public virtual float Unk_95 {
                get => Unk_95_raw;
                set {
                    if (Unk_95_raw == value) return;
                    Unk_95_raw = value;
                    OnPropertyChanged(nameof(Unk_95));
                }
            }

            protected float Unk_96_raw;
            public const string Unk_96_displayName = "Unk 96";
            public const int Unk_96_sortIndex = 1300;
            [SortOrder(Unk_96_sortIndex)]
            [DisplayName(Unk_96_displayName)]
            public virtual float Unk_96 {
                get => Unk_96_raw;
                set {
                    if (Unk_96_raw == value) return;
                    Unk_96_raw = value;
                    OnPropertyChanged(nameof(Unk_96));
                }
            }

            protected float Unk_97_raw;
            public const string Unk_97_displayName = "Unk 97";
            public const int Unk_97_sortIndex = 1350;
            [SortOrder(Unk_97_sortIndex)]
            [DisplayName(Unk_97_displayName)]
            public virtual float Unk_97 {
                get => Unk_97_raw;
                set {
                    if (Unk_97_raw == value) return;
                    Unk_97_raw = value;
                    OnPropertyChanged(nameof(Unk_97));
                }
            }

            protected float Unk_98_raw;
            public const string Unk_98_displayName = "Unk 98";
            public const int Unk_98_sortIndex = 1400;
            [SortOrder(Unk_98_sortIndex)]
            [DisplayName(Unk_98_displayName)]
            public virtual float Unk_98 {
                get => Unk_98_raw;
                set {
                    if (Unk_98_raw == value) return;
                    Unk_98_raw = value;
                    OnPropertyChanged(nameof(Unk_98));
                }
            }

            protected float Unk_99_raw;
            public const string Unk_99_displayName = "Unk 99";
            public const int Unk_99_sortIndex = 1450;
            [SortOrder(Unk_99_sortIndex)]
            [DisplayName(Unk_99_displayName)]
            public virtual float Unk_99 {
                get => Unk_99_raw;
                set {
                    if (Unk_99_raw == value) return;
                    Unk_99_raw = value;
                    OnPropertyChanged(nameof(Unk_99));
                }
            }

            protected float Unk_100_raw;
            public const string Unk_100_displayName = "Unk 100";
            public const int Unk_100_sortIndex = 1500;
            [SortOrder(Unk_100_sortIndex)]
            [DisplayName(Unk_100_displayName)]
            public virtual float Unk_100 {
                get => Unk_100_raw;
                set {
                    if (Unk_100_raw == value) return;
                    Unk_100_raw = value;
                    OnPropertyChanged(nameof(Unk_100));
                }
            }

            protected float Unk_101_raw;
            public const string Unk_101_displayName = "Unk 101";
            public const int Unk_101_sortIndex = 1550;
            [SortOrder(Unk_101_sortIndex)]
            [DisplayName(Unk_101_displayName)]
            public virtual float Unk_101 {
                get => Unk_101_raw;
                set {
                    if (Unk_101_raw == value) return;
                    Unk_101_raw = value;
                    OnPropertyChanged(nameof(Unk_101));
                }
            }

            protected float Unk_102_raw;
            public const string Unk_102_displayName = "Unk 102";
            public const int Unk_102_sortIndex = 1600;
            [SortOrder(Unk_102_sortIndex)]
            [DisplayName(Unk_102_displayName)]
            public virtual float Unk_102 {
                get => Unk_102_raw;
                set {
                    if (Unk_102_raw == value) return;
                    Unk_102_raw = value;
                    OnPropertyChanged(nameof(Unk_102));
                }
            }

            protected float Unk_103_raw;
            public const string Unk_103_displayName = "Unk 103";
            public const int Unk_103_sortIndex = 1650;
            [SortOrder(Unk_103_sortIndex)]
            [DisplayName(Unk_103_displayName)]
            public virtual float Unk_103 {
                get => Unk_103_raw;
                set {
                    if (Unk_103_raw == value) return;
                    Unk_103_raw = value;
                    OnPropertyChanged(nameof(Unk_103));
                }
            }

            protected float Unk_104_raw;
            public const string Unk_104_displayName = "Unk 104";
            public const int Unk_104_sortIndex = 1700;
            [SortOrder(Unk_104_sortIndex)]
            [DisplayName(Unk_104_displayName)]
            public virtual float Unk_104 {
                get => Unk_104_raw;
                set {
                    if (Unk_104_raw == value) return;
                    Unk_104_raw = value;
                    OnPropertyChanged(nameof(Unk_104));
                }
            }

            protected float Unk_105_raw;
            public const string Unk_105_displayName = "Unk 105";
            public const int Unk_105_sortIndex = 1750;
            [SortOrder(Unk_105_sortIndex)]
            [DisplayName(Unk_105_displayName)]
            public virtual float Unk_105 {
                get => Unk_105_raw;
                set {
                    if (Unk_105_raw == value) return;
                    Unk_105_raw = value;
                    OnPropertyChanged(nameof(Unk_105));
                }
            }

            protected float Unk_106_raw;
            public const string Unk_106_displayName = "Unk 106";
            public const int Unk_106_sortIndex = 1800;
            [SortOrder(Unk_106_sortIndex)]
            [DisplayName(Unk_106_displayName)]
            public virtual float Unk_106 {
                get => Unk_106_raw;
                set {
                    if (Unk_106_raw == value) return;
                    Unk_106_raw = value;
                    OnPropertyChanged(nameof(Unk_106));
                }
            }

            protected float Unk_107_raw;
            public const string Unk_107_displayName = "Unk 107";
            public const int Unk_107_sortIndex = 1850;
            [SortOrder(Unk_107_sortIndex)]
            [DisplayName(Unk_107_displayName)]
            public virtual float Unk_107 {
                get => Unk_107_raw;
                set {
                    if (Unk_107_raw == value) return;
                    Unk_107_raw = value;
                    OnPropertyChanged(nameof(Unk_107));
                }
            }

            protected float Unk_108_raw;
            public const string Unk_108_displayName = "Unk 108";
            public const int Unk_108_sortIndex = 1900;
            [SortOrder(Unk_108_sortIndex)]
            [DisplayName(Unk_108_displayName)]
            public virtual float Unk_108 {
                get => Unk_108_raw;
                set {
                    if (Unk_108_raw == value) return;
                    Unk_108_raw = value;
                    OnPropertyChanged(nameof(Unk_108));
                }
            }

            protected float Unk_109_raw;
            public const string Unk_109_displayName = "Unk 109";
            public const int Unk_109_sortIndex = 1950;
            [SortOrder(Unk_109_sortIndex)]
            [DisplayName(Unk_109_displayName)]
            public virtual float Unk_109 {
                get => Unk_109_raw;
                set {
                    if (Unk_109_raw == value) return;
                    Unk_109_raw = value;
                    OnPropertyChanged(nameof(Unk_109));
                }
            }

            protected float Unk_110_raw;
            public const string Unk_110_displayName = "Unk 110";
            public const int Unk_110_sortIndex = 2000;
            [SortOrder(Unk_110_sortIndex)]
            [DisplayName(Unk_110_displayName)]
            public virtual float Unk_110 {
                get => Unk_110_raw;
                set {
                    if (Unk_110_raw == value) return;
                    Unk_110_raw = value;
                    OnPropertyChanged(nameof(Unk_110));
                }
            }

            protected byte Unk_111_raw;
            public const string Unk_111_displayName = "Unk 111";
            public const int Unk_111_sortIndex = 2050;
            [SortOrder(Unk_111_sortIndex)]
            [DisplayName(Unk_111_displayName)]
            public virtual byte Unk_111 {
                get => Unk_111_raw;
                set {
                    if (Unk_111_raw == value) return;
                    Unk_111_raw = value;
                    OnPropertyChanged(nameof(Unk_111));
                }
            }

            protected byte Unk_112_raw;
            public const string Unk_112_displayName = "Unk 112";
            public const int Unk_112_sortIndex = 2100;
            [SortOrder(Unk_112_sortIndex)]
            [DisplayName(Unk_112_displayName)]
            public virtual byte Unk_112 {
                get => Unk_112_raw;
                set {
                    if (Unk_112_raw == value) return;
                    Unk_112_raw = value;
                    OnPropertyChanged(nameof(Unk_112));
                }
            }

            protected byte Unk_113_raw;
            public const string Unk_113_displayName = "Unk 113";
            public const int Unk_113_sortIndex = 2150;
            [SortOrder(Unk_113_sortIndex)]
            [DisplayName(Unk_113_displayName)]
            public virtual byte Unk_113 {
                get => Unk_113_raw;
                set {
                    if (Unk_113_raw == value) return;
                    Unk_113_raw = value;
                    OnPropertyChanged(nameof(Unk_113));
                }
            }

            protected byte Unk_114_raw;
            public const string Unk_114_displayName = "Unk 114";
            public const int Unk_114_sortIndex = 2200;
            [SortOrder(Unk_114_sortIndex)]
            [DisplayName(Unk_114_displayName)]
            public virtual byte Unk_114 {
                get => Unk_114_raw;
                set {
                    if (Unk_114_raw == value) return;
                    Unk_114_raw = value;
                    OnPropertyChanged(nameof(Unk_114));
                }
            }

            protected byte Unk_115_raw;
            public const string Unk_115_displayName = "Unk 115";
            public const int Unk_115_sortIndex = 2250;
            [SortOrder(Unk_115_sortIndex)]
            [DisplayName(Unk_115_displayName)]
            public virtual byte Unk_115 {
                get => Unk_115_raw;
                set {
                    if (Unk_115_raw == value) return;
                    Unk_115_raw = value;
                    OnPropertyChanged(nameof(Unk_115));
                }
            }

            protected byte Unk_116_raw;
            public const string Unk_116_displayName = "Unk 116";
            public const int Unk_116_sortIndex = 2300;
            [SortOrder(Unk_116_sortIndex)]
            [DisplayName(Unk_116_displayName)]
            public virtual byte Unk_116 {
                get => Unk_116_raw;
                set {
                    if (Unk_116_raw == value) return;
                    Unk_116_raw = value;
                    OnPropertyChanged(nameof(Unk_116));
                }
            }

            protected byte Unk_117_raw;
            public const string Unk_117_displayName = "Unk 117";
            public const int Unk_117_sortIndex = 2350;
            [SortOrder(Unk_117_sortIndex)]
            [DisplayName(Unk_117_displayName)]
            public virtual byte Unk_117 {
                get => Unk_117_raw;
                set {
                    if (Unk_117_raw == value) return;
                    Unk_117_raw = value;
                    OnPropertyChanged(nameof(Unk_117));
                }
            }

            protected byte Unk_118_raw;
            public const string Unk_118_displayName = "Unk 118";
            public const int Unk_118_sortIndex = 2400;
            [SortOrder(Unk_118_sortIndex)]
            [DisplayName(Unk_118_displayName)]
            public virtual byte Unk_118 {
                get => Unk_118_raw;
                set {
                    if (Unk_118_raw == value) return;
                    Unk_118_raw = value;
                    OnPropertyChanged(nameof(Unk_118));
                }
            }

            protected byte Unk_119_raw;
            public const string Unk_119_displayName = "Unk 119";
            public const int Unk_119_sortIndex = 2450;
            [SortOrder(Unk_119_sortIndex)]
            [DisplayName(Unk_119_displayName)]
            public virtual byte Unk_119 {
                get => Unk_119_raw;
                set {
                    if (Unk_119_raw == value) return;
                    Unk_119_raw = value;
                    OnPropertyChanged(nameof(Unk_119));
                }
            }

            protected byte Unk_120_raw;
            public const string Unk_120_displayName = "Unk 120";
            public const int Unk_120_sortIndex = 2500;
            [SortOrder(Unk_120_sortIndex)]
            [DisplayName(Unk_120_displayName)]
            public virtual byte Unk_120 {
                get => Unk_120_raw;
                set {
                    if (Unk_120_raw == value) return;
                    Unk_120_raw = value;
                    OnPropertyChanged(nameof(Unk_120));
                }
            }

            protected float Walk_Turn_Speed_raw;
            public const string Walk_Turn_Speed_displayName = "Walk Turn Speed";
            public const int Walk_Turn_Speed_sortIndex = 2550;
            [SortOrder(Walk_Turn_Speed_sortIndex)]
            [DisplayName(Walk_Turn_Speed_displayName)]
            public virtual float Walk_Turn_Speed {
                get => Walk_Turn_Speed_raw;
                set {
                    if (Walk_Turn_Speed_raw == value) return;
                    Walk_Turn_Speed_raw = value;
                    OnPropertyChanged(nameof(Walk_Turn_Speed));
                }
            }

            protected float Walk_Turn_Speed_Room__raw;
            public const string Walk_Turn_Speed_Room__displayName = "Walk Turn Speed (Room)";
            public const int Walk_Turn_Speed_Room__sortIndex = 2600;
            [SortOrder(Walk_Turn_Speed_Room__sortIndex)]
            [DisplayName(Walk_Turn_Speed_Room__displayName)]
            public virtual float Walk_Turn_Speed_Room_ {
                get => Walk_Turn_Speed_Room__raw;
                set {
                    if (Walk_Turn_Speed_Room__raw == value) return;
                    Walk_Turn_Speed_Room__raw = value;
                    OnPropertyChanged(nameof(Walk_Turn_Speed_Room_));
                }
            }

            protected float Walk_Stop_Margin_Time_raw;
            public const string Walk_Stop_Margin_Time_displayName = "Walk Stop Margin Time";
            public const int Walk_Stop_Margin_Time_sortIndex = 2650;
            [SortOrder(Walk_Stop_Margin_Time_sortIndex)]
            [DisplayName(Walk_Stop_Margin_Time_displayName)]
            public virtual float Walk_Stop_Margin_Time {
                get => Walk_Stop_Margin_Time_raw;
                set {
                    if (Walk_Stop_Margin_Time_raw == value) return;
                    Walk_Stop_Margin_Time_raw = value;
                    OnPropertyChanged(nameof(Walk_Stop_Margin_Time));
                }
            }

            protected float Female_Motion_Start_Time_raw;
            public const string Female_Motion_Start_Time_displayName = "Female Motion Start Time";
            public const int Female_Motion_Start_Time_sortIndex = 2700;
            [SortOrder(Female_Motion_Start_Time_sortIndex)]
            [DisplayName(Female_Motion_Start_Time_displayName)]
            public virtual float Female_Motion_Start_Time {
                get => Female_Motion_Start_Time_raw;
                set {
                    if (Female_Motion_Start_Time_raw == value) return;
                    Female_Motion_Start_Time_raw = value;
                    OnPropertyChanged(nameof(Female_Motion_Start_Time));
                }
            }

            protected float Unk_121_raw;
            public const string Unk_121_displayName = "Unk 121";
            public const int Unk_121_sortIndex = 2750;
            [SortOrder(Unk_121_sortIndex)]
            [DisplayName(Unk_121_displayName)]
            public virtual float Unk_121 {
                get => Unk_121_raw;
                set {
                    if (Unk_121_raw == value) return;
                    Unk_121_raw = value;
                    OnPropertyChanged(nameof(Unk_121));
                }
            }

            protected float Unk_122_raw;
            public const string Unk_122_displayName = "Unk 122";
            public const int Unk_122_sortIndex = 2800;
            [SortOrder(Unk_122_sortIndex)]
            [DisplayName(Unk_122_displayName)]
            public virtual float Unk_122 {
                get => Unk_122_raw;
                set {
                    if (Unk_122_raw == value) return;
                    Unk_122_raw = value;
                    OnPropertyChanged(nameof(Unk_122));
                }
            }

            protected float Walk_Motion_Speed_Room__raw;
            public const string Walk_Motion_Speed_Room__displayName = "Walk Motion Speed (Room)";
            public const int Walk_Motion_Speed_Room__sortIndex = 2850;
            [SortOrder(Walk_Motion_Speed_Room__sortIndex)]
            [DisplayName(Walk_Motion_Speed_Room__displayName)]
            public virtual float Walk_Motion_Speed_Room_ {
                get => Walk_Motion_Speed_Room__raw;
                set {
                    if (Walk_Motion_Speed_Room__raw == value) return;
                    Walk_Motion_Speed_Room__raw = value;
                    OnPropertyChanged(nameof(Walk_Motion_Speed_Room_));
                }
            }

            protected float Walk_Motion_Speed_raw;
            public const string Walk_Motion_Speed_displayName = "Walk Motion Speed";
            public const int Walk_Motion_Speed_sortIndex = 2900;
            [SortOrder(Walk_Motion_Speed_sortIndex)]
            [DisplayName(Walk_Motion_Speed_displayName)]
            public virtual float Walk_Motion_Speed {
                get => Walk_Motion_Speed_raw;
                set {
                    if (Walk_Motion_Speed_raw == value) return;
                    Walk_Motion_Speed_raw = value;
                    OnPropertyChanged(nameof(Walk_Motion_Speed));
                }
            }

            protected float Run_Stop_Margin_Time_raw;
            public const string Run_Stop_Margin_Time_displayName = "Run Stop Margin Time";
            public const int Run_Stop_Margin_Time_sortIndex = 2950;
            [SortOrder(Run_Stop_Margin_Time_sortIndex)]
            [DisplayName(Run_Stop_Margin_Time_displayName)]
            public virtual float Run_Stop_Margin_Time {
                get => Run_Stop_Margin_Time_raw;
                set {
                    if (Run_Stop_Margin_Time_raw == value) return;
                    Run_Stop_Margin_Time_raw = value;
                    OnPropertyChanged(nameof(Run_Stop_Margin_Time));
                }
            }

            protected float Run_Turn_Speed_raw;
            public const string Run_Turn_Speed_displayName = "Run Turn Speed";
            public const int Run_Turn_Speed_sortIndex = 3000;
            [SortOrder(Run_Turn_Speed_sortIndex)]
            [DisplayName(Run_Turn_Speed_displayName)]
            public virtual float Run_Turn_Speed {
                get => Run_Turn_Speed_raw;
                set {
                    if (Run_Turn_Speed_raw == value) return;
                    Run_Turn_Speed_raw = value;
                    OnPropertyChanged(nameof(Run_Turn_Speed));
                }
            }

            protected float Run_Turn_Lever_Angle_raw;
            public const string Run_Turn_Lever_Angle_displayName = "Run Turn Lever Angle";
            public const int Run_Turn_Lever_Angle_sortIndex = 3050;
            [SortOrder(Run_Turn_Lever_Angle_sortIndex)]
            [DisplayName(Run_Turn_Lever_Angle_displayName)]
            public virtual float Run_Turn_Lever_Angle {
                get => Run_Turn_Lever_Angle_raw;
                set {
                    if (Run_Turn_Lever_Angle_raw == value) return;
                    Run_Turn_Lever_Angle_raw = value;
                    OnPropertyChanged(nameof(Run_Turn_Lever_Angle));
                }
            }

            protected float Run_Female_Motion_Start_Time_raw;
            public const string Run_Female_Motion_Start_Time_displayName = "Run Female Motion Start Time";
            public const int Run_Female_Motion_Start_Time_sortIndex = 3100;
            [SortOrder(Run_Female_Motion_Start_Time_sortIndex)]
            [DisplayName(Run_Female_Motion_Start_Time_displayName)]
            public virtual float Run_Female_Motion_Start_Time {
                get => Run_Female_Motion_Start_Time_raw;
                set {
                    if (Run_Female_Motion_Start_Time_raw == value) return;
                    Run_Female_Motion_Start_Time_raw = value;
                    OnPropertyChanged(nameof(Run_Female_Motion_Start_Time));
                }
            }

            protected float Unk_123_raw;
            public const string Unk_123_displayName = "Unk 123";
            public const int Unk_123_sortIndex = 3150;
            [SortOrder(Unk_123_sortIndex)]
            [DisplayName(Unk_123_displayName)]
            public virtual float Unk_123 {
                get => Unk_123_raw;
                set {
                    if (Unk_123_raw == value) return;
                    Unk_123_raw = value;
                    OnPropertyChanged(nameof(Unk_123));
                }
            }

            protected float Unk_124_raw;
            public const string Unk_124_displayName = "Unk 124";
            public const int Unk_124_sortIndex = 3200;
            [SortOrder(Unk_124_sortIndex)]
            [DisplayName(Unk_124_displayName)]
            public virtual float Unk_124 {
                get => Unk_124_raw;
                set {
                    if (Unk_124_raw == value) return;
                    Unk_124_raw = value;
                    OnPropertyChanged(nameof(Unk_124));
                }
            }

            protected float Run_Motion_Speed_Room__raw;
            public const string Run_Motion_Speed_Room__displayName = "Run Motion Speed (Room)";
            public const int Run_Motion_Speed_Room__sortIndex = 3250;
            [SortOrder(Run_Motion_Speed_Room__sortIndex)]
            [DisplayName(Run_Motion_Speed_Room__displayName)]
            public virtual float Run_Motion_Speed_Room_ {
                get => Run_Motion_Speed_Room__raw;
                set {
                    if (Run_Motion_Speed_Room__raw == value) return;
                    Run_Motion_Speed_Room__raw = value;
                    OnPropertyChanged(nameof(Run_Motion_Speed_Room_));
                }
            }

            protected float Run_Motion_Speed_raw;
            public const string Run_Motion_Speed_displayName = "Run Motion Speed";
            public const int Run_Motion_Speed_sortIndex = 3300;
            [SortOrder(Run_Motion_Speed_sortIndex)]
            [DisplayName(Run_Motion_Speed_displayName)]
            public virtual float Run_Motion_Speed {
                get => Run_Motion_Speed_raw;
                set {
                    if (Run_Motion_Speed_raw == value) return;
                    Run_Motion_Speed_raw = value;
                    OnPropertyChanged(nameof(Run_Motion_Speed));
                }
            }

            protected float Dash_Turn_Speed_raw;
            public const string Dash_Turn_Speed_displayName = "Dash Turn Speed";
            public const int Dash_Turn_Speed_sortIndex = 3350;
            [SortOrder(Dash_Turn_Speed_sortIndex)]
            [DisplayName(Dash_Turn_Speed_displayName)]
            public virtual float Dash_Turn_Speed {
                get => Dash_Turn_Speed_raw;
                set {
                    if (Dash_Turn_Speed_raw == value) return;
                    Dash_Turn_Speed_raw = value;
                    OnPropertyChanged(nameof(Dash_Turn_Speed));
                }
            }

            protected float Dash_Motion_Speed_raw;
            public const string Dash_Motion_Speed_displayName = "Dash Motion Speed";
            public const int Dash_Motion_Speed_sortIndex = 3400;
            [SortOrder(Dash_Motion_Speed_sortIndex)]
            [DisplayName(Dash_Motion_Speed_displayName)]
            public virtual float Dash_Motion_Speed {
                get => Dash_Motion_Speed_raw;
                set {
                    if (Dash_Motion_Speed_raw == value) return;
                    Dash_Motion_Speed_raw = value;
                    OnPropertyChanged(nameof(Dash_Motion_Speed));
                }
            }

            protected float Unk_125_raw;
            public const string Unk_125_displayName = "Unk 125";
            public const int Unk_125_sortIndex = 3450;
            [SortOrder(Unk_125_sortIndex)]
            [DisplayName(Unk_125_displayName)]
            public virtual float Unk_125 {
                get => Unk_125_raw;
                set {
                    if (Unk_125_raw == value) return;
                    Unk_125_raw = value;
                    OnPropertyChanged(nameof(Unk_125));
                }
            }

            protected float Unk_126_raw;
            public const string Unk_126_displayName = "Unk 126";
            public const int Unk_126_sortIndex = 3500;
            [SortOrder(Unk_126_sortIndex)]
            [DisplayName(Unk_126_displayName)]
            public virtual float Unk_126 {
                get => Unk_126_raw;
                set {
                    if (Unk_126_raw == value) return;
                    Unk_126_raw = value;
                    OnPropertyChanged(nameof(Unk_126));
                }
            }

            protected float Unk_127_raw;
            public const string Unk_127_displayName = "Unk 127";
            public const int Unk_127_sortIndex = 3550;
            [SortOrder(Unk_127_sortIndex)]
            [DisplayName(Unk_127_displayName)]
            public virtual float Unk_127 {
                get => Unk_127_raw;
                set {
                    if (Unk_127_raw == value) return;
                    Unk_127_raw = value;
                    OnPropertyChanged(nameof(Unk_127));
                }
            }

            protected float Unk_128_raw;
            public const string Unk_128_displayName = "Unk 128";
            public const int Unk_128_sortIndex = 3600;
            [SortOrder(Unk_128_sortIndex)]
            [DisplayName(Unk_128_displayName)]
            public virtual float Unk_128 {
                get => Unk_128_raw;
                set {
                    if (Unk_128_raw == value) return;
                    Unk_128_raw = value;
                    OnPropertyChanged(nameof(Unk_128));
                }
            }

            protected float Unk_129_raw;
            public const string Unk_129_displayName = "Unk 129";
            public const int Unk_129_sortIndex = 3650;
            [SortOrder(Unk_129_sortIndex)]
            [DisplayName(Unk_129_displayName)]
            public virtual float Unk_129 {
                get => Unk_129_raw;
                set {
                    if (Unk_129_raw == value) return;
                    Unk_129_raw = value;
                    OnPropertyChanged(nameof(Unk_129));
                }
            }

            protected float Unk_130_raw;
            public const string Unk_130_displayName = "Unk 130";
            public const int Unk_130_sortIndex = 3700;
            [SortOrder(Unk_130_sortIndex)]
            [DisplayName(Unk_130_displayName)]
            public virtual float Unk_130 {
                get => Unk_130_raw;
                set {
                    if (Unk_130_raw == value) return;
                    Unk_130_raw = value;
                    OnPropertyChanged(nameof(Unk_130));
                }
            }

            protected float Unk_131_raw;
            public const string Unk_131_displayName = "Unk 131";
            public const int Unk_131_sortIndex = 3750;
            [SortOrder(Unk_131_sortIndex)]
            [DisplayName(Unk_131_displayName)]
            public virtual float Unk_131 {
                get => Unk_131_raw;
                set {
                    if (Unk_131_raw == value) return;
                    Unk_131_raw = value;
                    OnPropertyChanged(nameof(Unk_131));
                }
            }

            protected float Unk_132_raw;
            public const string Unk_132_displayName = "Unk 132";
            public const int Unk_132_sortIndex = 3800;
            [SortOrder(Unk_132_sortIndex)]
            [DisplayName(Unk_132_displayName)]
            public virtual float Unk_132 {
                get => Unk_132_raw;
                set {
                    if (Unk_132_raw == value) return;
                    Unk_132_raw = value;
                    OnPropertyChanged(nameof(Unk_132));
                }
            }

            protected float Unk_133_raw;
            public const string Unk_133_displayName = "Unk 133";
            public const int Unk_133_sortIndex = 3850;
            [SortOrder(Unk_133_sortIndex)]
            [DisplayName(Unk_133_displayName)]
            public virtual float Unk_133 {
                get => Unk_133_raw;
                set {
                    if (Unk_133_raw == value) return;
                    Unk_133_raw = value;
                    OnPropertyChanged(nameof(Unk_133));
                }
            }

            protected float Unk_134_raw;
            public const string Unk_134_displayName = "Unk 134";
            public const int Unk_134_sortIndex = 3900;
            [SortOrder(Unk_134_sortIndex)]
            [DisplayName(Unk_134_displayName)]
            public virtual float Unk_134 {
                get => Unk_134_raw;
                set {
                    if (Unk_134_raw == value) return;
                    Unk_134_raw = value;
                    OnPropertyChanged(nameof(Unk_134));
                }
            }

            protected float Unk_135_raw;
            public const string Unk_135_displayName = "Unk 135";
            public const int Unk_135_sortIndex = 3950;
            [SortOrder(Unk_135_sortIndex)]
            [DisplayName(Unk_135_displayName)]
            public virtual float Unk_135 {
                get => Unk_135_raw;
                set {
                    if (Unk_135_raw == value) return;
                    Unk_135_raw = value;
                    OnPropertyChanged(nameof(Unk_135));
                }
            }

            protected float Unk_136_raw;
            public const string Unk_136_displayName = "Unk 136";
            public const int Unk_136_sortIndex = 4000;
            [SortOrder(Unk_136_sortIndex)]
            [DisplayName(Unk_136_displayName)]
            public virtual float Unk_136 {
                get => Unk_136_raw;
                set {
                    if (Unk_136_raw == value) return;
                    Unk_136_raw = value;
                    OnPropertyChanged(nameof(Unk_136));
                }
            }

            protected float Unk_137_raw;
            public const string Unk_137_displayName = "Unk 137";
            public const int Unk_137_sortIndex = 4050;
            [SortOrder(Unk_137_sortIndex)]
            [DisplayName(Unk_137_displayName)]
            public virtual float Unk_137 {
                get => Unk_137_raw;
                set {
                    if (Unk_137_raw == value) return;
                    Unk_137_raw = value;
                    OnPropertyChanged(nameof(Unk_137));
                }
            }

            protected float Unk_138_raw;
            public const string Unk_138_displayName = "Unk 138";
            public const int Unk_138_sortIndex = 4100;
            [SortOrder(Unk_138_sortIndex)]
            [DisplayName(Unk_138_displayName)]
            public virtual float Unk_138 {
                get => Unk_138_raw;
                set {
                    if (Unk_138_raw == value) return;
                    Unk_138_raw = value;
                    OnPropertyChanged(nameof(Unk_138));
                }
            }

            protected float Unk_139_raw;
            public const string Unk_139_displayName = "Unk 139";
            public const int Unk_139_sortIndex = 4150;
            [SortOrder(Unk_139_sortIndex)]
            [DisplayName(Unk_139_displayName)]
            public virtual float Unk_139 {
                get => Unk_139_raw;
                set {
                    if (Unk_139_raw == value) return;
                    Unk_139_raw = value;
                    OnPropertyChanged(nameof(Unk_139));
                }
            }

            protected float Unk_140_raw;
            public const string Unk_140_displayName = "Unk 140";
            public const int Unk_140_sortIndex = 4200;
            [SortOrder(Unk_140_sortIndex)]
            [DisplayName(Unk_140_displayName)]
            public virtual float Unk_140 {
                get => Unk_140_raw;
                set {
                    if (Unk_140_raw == value) return;
                    Unk_140_raw = value;
                    OnPropertyChanged(nameof(Unk_140));
                }
            }

            protected float Unk_141_raw;
            public const string Unk_141_displayName = "Unk 141";
            public const int Unk_141_sortIndex = 4250;
            [SortOrder(Unk_141_sortIndex)]
            [DisplayName(Unk_141_displayName)]
            public virtual float Unk_141 {
                get => Unk_141_raw;
                set {
                    if (Unk_141_raw == value) return;
                    Unk_141_raw = value;
                    OnPropertyChanged(nameof(Unk_141));
                }
            }

            protected float Unk_142_raw;
            public const string Unk_142_displayName = "Unk 142";
            public const int Unk_142_sortIndex = 4300;
            [SortOrder(Unk_142_sortIndex)]
            [DisplayName(Unk_142_displayName)]
            public virtual float Unk_142 {
                get => Unk_142_raw;
                set {
                    if (Unk_142_raw == value) return;
                    Unk_142_raw = value;
                    OnPropertyChanged(nameof(Unk_142));
                }
            }

            protected float Unk_143_raw;
            public const string Unk_143_displayName = "Unk 143";
            public const int Unk_143_sortIndex = 4350;
            [SortOrder(Unk_143_sortIndex)]
            [DisplayName(Unk_143_displayName)]
            public virtual float Unk_143 {
                get => Unk_143_raw;
                set {
                    if (Unk_143_raw == value) return;
                    Unk_143_raw = value;
                    OnPropertyChanged(nameof(Unk_143));
                }
            }

            protected float Unk_144_raw;
            public const string Unk_144_displayName = "Unk 144";
            public const int Unk_144_sortIndex = 4400;
            [SortOrder(Unk_144_sortIndex)]
            [DisplayName(Unk_144_displayName)]
            public virtual float Unk_144 {
                get => Unk_144_raw;
                set {
                    if (Unk_144_raw == value) return;
                    Unk_144_raw = value;
                    OnPropertyChanged(nameof(Unk_144));
                }
            }

            protected float Unk_145_raw;
            public const string Unk_145_displayName = "Unk 145";
            public const int Unk_145_sortIndex = 4450;
            [SortOrder(Unk_145_sortIndex)]
            [DisplayName(Unk_145_displayName)]
            public virtual float Unk_145 {
                get => Unk_145_raw;
                set {
                    if (Unk_145_raw == value) return;
                    Unk_145_raw = value;
                    OnPropertyChanged(nameof(Unk_145));
                }
            }

            protected float Unk_146_raw;
            public const string Unk_146_displayName = "Unk 146";
            public const int Unk_146_sortIndex = 4500;
            [SortOrder(Unk_146_sortIndex)]
            [DisplayName(Unk_146_displayName)]
            public virtual float Unk_146 {
                get => Unk_146_raw;
                set {
                    if (Unk_146_raw == value) return;
                    Unk_146_raw = value;
                    OnPropertyChanged(nameof(Unk_146));
                }
            }

            protected float Unk_147_raw;
            public const string Unk_147_displayName = "Unk 147";
            public const int Unk_147_sortIndex = 4550;
            [SortOrder(Unk_147_sortIndex)]
            [DisplayName(Unk_147_displayName)]
            public virtual float Unk_147 {
                get => Unk_147_raw;
                set {
                    if (Unk_147_raw == value) return;
                    Unk_147_raw = value;
                    OnPropertyChanged(nameof(Unk_147));
                }
            }

            protected float Unk_148_raw;
            public const string Unk_148_displayName = "Unk 148";
            public const int Unk_148_sortIndex = 4600;
            [SortOrder(Unk_148_sortIndex)]
            [DisplayName(Unk_148_displayName)]
            public virtual float Unk_148 {
                get => Unk_148_raw;
                set {
                    if (Unk_148_raw == value) return;
                    Unk_148_raw = value;
                    OnPropertyChanged(nameof(Unk_148));
                }
            }

            protected float Unk_149_raw;
            public const string Unk_149_displayName = "Unk 149";
            public const int Unk_149_sortIndex = 4650;
            [SortOrder(Unk_149_sortIndex)]
            [DisplayName(Unk_149_displayName)]
            public virtual float Unk_149 {
                get => Unk_149_raw;
                set {
                    if (Unk_149_raw == value) return;
                    Unk_149_raw = value;
                    OnPropertyChanged(nameof(Unk_149));
                }
            }

            protected float Unk_150_raw;
            public const string Unk_150_displayName = "Unk 150";
            public const int Unk_150_sortIndex = 4700;
            [SortOrder(Unk_150_sortIndex)]
            [DisplayName(Unk_150_displayName)]
            public virtual float Unk_150 {
                get => Unk_150_raw;
                set {
                    if (Unk_150_raw == value) return;
                    Unk_150_raw = value;
                    OnPropertyChanged(nameof(Unk_150));
                }
            }

            protected float Unk_151_raw;
            public const string Unk_151_displayName = "Unk 151";
            public const int Unk_151_sortIndex = 4750;
            [SortOrder(Unk_151_sortIndex)]
            [DisplayName(Unk_151_displayName)]
            public virtual float Unk_151 {
                get => Unk_151_raw;
                set {
                    if (Unk_151_raw == value) return;
                    Unk_151_raw = value;
                    OnPropertyChanged(nameof(Unk_151));
                }
            }

            protected float Unk_152_raw;
            public const string Unk_152_displayName = "Unk 152";
            public const int Unk_152_sortIndex = 4800;
            [SortOrder(Unk_152_sortIndex)]
            [DisplayName(Unk_152_displayName)]
            public virtual float Unk_152 {
                get => Unk_152_raw;
                set {
                    if (Unk_152_raw == value) return;
                    Unk_152_raw = value;
                    OnPropertyChanged(nameof(Unk_152));
                }
            }

            protected float Unk_153_raw;
            public const string Unk_153_displayName = "Unk 153";
            public const int Unk_153_sortIndex = 4850;
            [SortOrder(Unk_153_sortIndex)]
            [DisplayName(Unk_153_displayName)]
            public virtual float Unk_153 {
                get => Unk_153_raw;
                set {
                    if (Unk_153_raw == value) return;
                    Unk_153_raw = value;
                    OnPropertyChanged(nameof(Unk_153));
                }
            }

            protected float Unk_154_raw;
            public const string Unk_154_displayName = "Unk 154";
            public const int Unk_154_sortIndex = 4900;
            [SortOrder(Unk_154_sortIndex)]
            [DisplayName(Unk_154_displayName)]
            public virtual float Unk_154 {
                get => Unk_154_raw;
                set {
                    if (Unk_154_raw == value) return;
                    Unk_154_raw = value;
                    OnPropertyChanged(nameof(Unk_154));
                }
            }

            protected float Unk_155_raw;
            public const string Unk_155_displayName = "Unk 155";
            public const int Unk_155_sortIndex = 4950;
            [SortOrder(Unk_155_sortIndex)]
            [DisplayName(Unk_155_displayName)]
            public virtual float Unk_155 {
                get => Unk_155_raw;
                set {
                    if (Unk_155_raw == value) return;
                    Unk_155_raw = value;
                    OnPropertyChanged(nameof(Unk_155));
                }
            }

            protected float Unk_156_raw;
            public const string Unk_156_displayName = "Unk 156";
            public const int Unk_156_sortIndex = 5000;
            [SortOrder(Unk_156_sortIndex)]
            [DisplayName(Unk_156_displayName)]
            public virtual float Unk_156 {
                get => Unk_156_raw;
                set {
                    if (Unk_156_raw == value) return;
                    Unk_156_raw = value;
                    OnPropertyChanged(nameof(Unk_156));
                }
            }

            protected float Unk_157_raw;
            public const string Unk_157_displayName = "Unk 157";
            public const int Unk_157_sortIndex = 5050;
            [SortOrder(Unk_157_sortIndex)]
            [DisplayName(Unk_157_displayName)]
            public virtual float Unk_157 {
                get => Unk_157_raw;
                set {
                    if (Unk_157_raw == value) return;
                    Unk_157_raw = value;
                    OnPropertyChanged(nameof(Unk_157));
                }
            }

            public const int lastSortIndex = 5100;

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Player_Params_4_ LoadData(BinaryReader reader, ulong i) {
                var data = new Player_Params_4_();
                data.Index = i;
                data.Unk_74_raw = reader.ReadSingle();
                data.Unk_75_raw = reader.ReadSingle();
                data.Walk_Turn_Tilt_Bow__raw = reader.ReadSingle();
                data.Unk_76_raw = reader.ReadSingle();
                data.Unk_77_raw = reader.ReadSingle();
                data.Unk_78_raw = reader.ReadSingle();
                data.Run_Turn_Tilt_Bow__raw = reader.ReadSingle();
                data.Run_Turn_Tilt_Head_Bow__raw = reader.ReadSingle();
                data.Unk_79_raw = reader.ReadSingle();
                data.Unk_80_raw = reader.ReadSingle();
                data.Unk_81_raw = reader.ReadSingle();
                data.Unk_82_raw = reader.ReadSingle();
                data.Unk_83_raw = reader.ReadSingle();
                data.Unk_84_raw = reader.ReadSingle();
                data.Unk_85_raw = reader.ReadSingle();
                data.Unk_86_raw = reader.ReadSingle();
                data.Unk_87_raw = reader.ReadSingle();
                data.Unk_88_raw = reader.ReadSingle();
                data.Unk_89_raw = reader.ReadSingle();
                data.Unk_90_raw = reader.ReadSingle();
                data.Unk_91_raw = reader.ReadSingle();
                data.Unk_92_raw = reader.ReadSingle();
                data.Unk_93_raw = reader.ReadSingle();
                data.Unk_94_raw = reader.ReadSingle();
                data.Unk_95_raw = reader.ReadSingle();
                data.Unk_96_raw = reader.ReadSingle();
                data.Unk_97_raw = reader.ReadSingle();
                data.Unk_98_raw = reader.ReadSingle();
                data.Unk_99_raw = reader.ReadSingle();
                data.Unk_100_raw = reader.ReadSingle();
                data.Unk_101_raw = reader.ReadSingle();
                data.Unk_102_raw = reader.ReadSingle();
                data.Unk_103_raw = reader.ReadSingle();
                data.Unk_104_raw = reader.ReadSingle();
                data.Unk_105_raw = reader.ReadSingle();
                data.Unk_106_raw = reader.ReadSingle();
                data.Unk_107_raw = reader.ReadSingle();
                data.Unk_108_raw = reader.ReadSingle();
                data.Unk_109_raw = reader.ReadSingle();
                data.Unk_110_raw = reader.ReadSingle();
                data.Unk_111_raw = reader.ReadByte();
                data.Unk_112_raw = reader.ReadByte();
                data.Unk_113_raw = reader.ReadByte();
                data.Unk_114_raw = reader.ReadByte();
                data.Unk_115_raw = reader.ReadByte();
                data.Unk_116_raw = reader.ReadByte();
                data.Unk_117_raw = reader.ReadByte();
                data.Unk_118_raw = reader.ReadByte();
                data.Unk_119_raw = reader.ReadByte();
                data.Unk_120_raw = reader.ReadByte();
                data.Walk_Turn_Speed_raw = reader.ReadSingle();
                data.Walk_Turn_Speed_Room__raw = reader.ReadSingle();
                data.Walk_Stop_Margin_Time_raw = reader.ReadSingle();
                data.Female_Motion_Start_Time_raw = reader.ReadSingle();
                data.Unk_121_raw = reader.ReadSingle();
                data.Unk_122_raw = reader.ReadSingle();
                data.Walk_Motion_Speed_Room__raw = reader.ReadSingle();
                data.Walk_Motion_Speed_raw = reader.ReadSingle();
                data.Run_Stop_Margin_Time_raw = reader.ReadSingle();
                data.Run_Turn_Speed_raw = reader.ReadSingle();
                data.Run_Turn_Lever_Angle_raw = reader.ReadSingle();
                data.Run_Female_Motion_Start_Time_raw = reader.ReadSingle();
                data.Unk_123_raw = reader.ReadSingle();
                data.Unk_124_raw = reader.ReadSingle();
                data.Run_Motion_Speed_Room__raw = reader.ReadSingle();
                data.Run_Motion_Speed_raw = reader.ReadSingle();
                data.Dash_Turn_Speed_raw = reader.ReadSingle();
                data.Dash_Motion_Speed_raw = reader.ReadSingle();
                data.Unk_125_raw = reader.ReadSingle();
                data.Unk_126_raw = reader.ReadSingle();
                data.Unk_127_raw = reader.ReadSingle();
                data.Unk_128_raw = reader.ReadSingle();
                data.Unk_129_raw = reader.ReadSingle();
                data.Unk_130_raw = reader.ReadSingle();
                data.Unk_131_raw = reader.ReadSingle();
                data.Unk_132_raw = reader.ReadSingle();
                data.Unk_133_raw = reader.ReadSingle();
                data.Unk_134_raw = reader.ReadSingle();
                data.Unk_135_raw = reader.ReadSingle();
                data.Unk_136_raw = reader.ReadSingle();
                data.Unk_137_raw = reader.ReadSingle();
                data.Unk_138_raw = reader.ReadSingle();
                data.Unk_139_raw = reader.ReadSingle();
                data.Unk_140_raw = reader.ReadSingle();
                data.Unk_141_raw = reader.ReadSingle();
                data.Unk_142_raw = reader.ReadSingle();
                data.Unk_143_raw = reader.ReadSingle();
                data.Unk_144_raw = reader.ReadSingle();
                data.Unk_145_raw = reader.ReadSingle();
                data.Unk_146_raw = reader.ReadSingle();
                data.Unk_147_raw = reader.ReadSingle();
                data.Unk_148_raw = reader.ReadSingle();
                data.Unk_149_raw = reader.ReadSingle();
                data.Unk_150_raw = reader.ReadSingle();
                data.Unk_151_raw = reader.ReadSingle();
                data.Unk_152_raw = reader.ReadSingle();
                data.Unk_153_raw = reader.ReadSingle();
                data.Unk_154_raw = reader.ReadSingle();
                data.Unk_155_raw = reader.ReadSingle();
                data.Unk_156_raw = reader.ReadSingle();
                data.Unk_157_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_74_raw);
                writer.Write(Unk_75_raw);
                writer.Write(Walk_Turn_Tilt_Bow__raw);
                writer.Write(Unk_76_raw);
                writer.Write(Unk_77_raw);
                writer.Write(Unk_78_raw);
                writer.Write(Run_Turn_Tilt_Bow__raw);
                writer.Write(Run_Turn_Tilt_Head_Bow__raw);
                writer.Write(Unk_79_raw);
                writer.Write(Unk_80_raw);
                writer.Write(Unk_81_raw);
                writer.Write(Unk_82_raw);
                writer.Write(Unk_83_raw);
                writer.Write(Unk_84_raw);
                writer.Write(Unk_85_raw);
                writer.Write(Unk_86_raw);
                writer.Write(Unk_87_raw);
                writer.Write(Unk_88_raw);
                writer.Write(Unk_89_raw);
                writer.Write(Unk_90_raw);
                writer.Write(Unk_91_raw);
                writer.Write(Unk_92_raw);
                writer.Write(Unk_93_raw);
                writer.Write(Unk_94_raw);
                writer.Write(Unk_95_raw);
                writer.Write(Unk_96_raw);
                writer.Write(Unk_97_raw);
                writer.Write(Unk_98_raw);
                writer.Write(Unk_99_raw);
                writer.Write(Unk_100_raw);
                writer.Write(Unk_101_raw);
                writer.Write(Unk_102_raw);
                writer.Write(Unk_103_raw);
                writer.Write(Unk_104_raw);
                writer.Write(Unk_105_raw);
                writer.Write(Unk_106_raw);
                writer.Write(Unk_107_raw);
                writer.Write(Unk_108_raw);
                writer.Write(Unk_109_raw);
                writer.Write(Unk_110_raw);
                writer.Write(Unk_111_raw);
                writer.Write(Unk_112_raw);
                writer.Write(Unk_113_raw);
                writer.Write(Unk_114_raw);
                writer.Write(Unk_115_raw);
                writer.Write(Unk_116_raw);
                writer.Write(Unk_117_raw);
                writer.Write(Unk_118_raw);
                writer.Write(Unk_119_raw);
                writer.Write(Unk_120_raw);
                writer.Write(Walk_Turn_Speed_raw);
                writer.Write(Walk_Turn_Speed_Room__raw);
                writer.Write(Walk_Stop_Margin_Time_raw);
                writer.Write(Female_Motion_Start_Time_raw);
                writer.Write(Unk_121_raw);
                writer.Write(Unk_122_raw);
                writer.Write(Walk_Motion_Speed_Room__raw);
                writer.Write(Walk_Motion_Speed_raw);
                writer.Write(Run_Stop_Margin_Time_raw);
                writer.Write(Run_Turn_Speed_raw);
                writer.Write(Run_Turn_Lever_Angle_raw);
                writer.Write(Run_Female_Motion_Start_Time_raw);
                writer.Write(Unk_123_raw);
                writer.Write(Unk_124_raw);
                writer.Write(Run_Motion_Speed_Room__raw);
                writer.Write(Run_Motion_Speed_raw);
                writer.Write(Dash_Turn_Speed_raw);
                writer.Write(Dash_Motion_Speed_raw);
                writer.Write(Unk_125_raw);
                writer.Write(Unk_126_raw);
                writer.Write(Unk_127_raw);
                writer.Write(Unk_128_raw);
                writer.Write(Unk_129_raw);
                writer.Write(Unk_130_raw);
                writer.Write(Unk_131_raw);
                writer.Write(Unk_132_raw);
                writer.Write(Unk_133_raw);
                writer.Write(Unk_134_raw);
                writer.Write(Unk_135_raw);
                writer.Write(Unk_136_raw);
                writer.Write(Unk_137_raw);
                writer.Write(Unk_138_raw);
                writer.Write(Unk_139_raw);
                writer.Write(Unk_140_raw);
                writer.Write(Unk_141_raw);
                writer.Write(Unk_142_raw);
                writer.Write(Unk_143_raw);
                writer.Write(Unk_144_raw);
                writer.Write(Unk_145_raw);
                writer.Write(Unk_146_raw);
                writer.Write(Unk_147_raw);
                writer.Write(Unk_148_raw);
                writer.Write(Unk_149_raw);
                writer.Write(Unk_150_raw);
                writer.Write(Unk_151_raw);
                writer.Write(Unk_152_raw);
                writer.Write(Unk_153_raw);
                writer.Write(Unk_154_raw);
                writer.Write(Unk_155_raw);
                writer.Write(Unk_156_raw);
                writer.Write(Unk_157_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Unk 74", "Unk_74"),
                    new MultiStructItemCustomView(this, "Unk 75", "Unk_75"),
                    new MultiStructItemCustomView(this, "Walk Turn Tilt (Bow)", "Walk_Turn_Tilt_Bow_"),
                    new MultiStructItemCustomView(this, "Unk 76", "Unk_76"),
                    new MultiStructItemCustomView(this, "Unk 77", "Unk_77"),
                    new MultiStructItemCustomView(this, "Unk 78", "Unk_78"),
                    new MultiStructItemCustomView(this, "Run Turn Tilt (Bow)", "Run_Turn_Tilt_Bow_"),
                    new MultiStructItemCustomView(this, "Run Turn Tilt Head (Bow)", "Run_Turn_Tilt_Head_Bow_"),
                    new MultiStructItemCustomView(this, "Unk 79", "Unk_79"),
                    new MultiStructItemCustomView(this, "Unk 80", "Unk_80"),
                    new MultiStructItemCustomView(this, "Unk 81", "Unk_81"),
                    new MultiStructItemCustomView(this, "Unk 82", "Unk_82"),
                    new MultiStructItemCustomView(this, "Unk 83", "Unk_83"),
                    new MultiStructItemCustomView(this, "Unk 84", "Unk_84"),
                    new MultiStructItemCustomView(this, "Unk 85", "Unk_85"),
                    new MultiStructItemCustomView(this, "Unk 86", "Unk_86"),
                    new MultiStructItemCustomView(this, "Unk 87", "Unk_87"),
                    new MultiStructItemCustomView(this, "Unk 88", "Unk_88"),
                    new MultiStructItemCustomView(this, "Unk 89", "Unk_89"),
                    new MultiStructItemCustomView(this, "Unk 90", "Unk_90"),
                    new MultiStructItemCustomView(this, "Unk 91", "Unk_91"),
                    new MultiStructItemCustomView(this, "Unk 92", "Unk_92"),
                    new MultiStructItemCustomView(this, "Unk 93", "Unk_93"),
                    new MultiStructItemCustomView(this, "Unk 94", "Unk_94"),
                    new MultiStructItemCustomView(this, "Unk 95", "Unk_95"),
                    new MultiStructItemCustomView(this, "Unk 96", "Unk_96"),
                    new MultiStructItemCustomView(this, "Unk 97", "Unk_97"),
                    new MultiStructItemCustomView(this, "Unk 98", "Unk_98"),
                    new MultiStructItemCustomView(this, "Unk 99", "Unk_99"),
                    new MultiStructItemCustomView(this, "Unk 100", "Unk_100"),
                    new MultiStructItemCustomView(this, "Unk 101", "Unk_101"),
                    new MultiStructItemCustomView(this, "Unk 102", "Unk_102"),
                    new MultiStructItemCustomView(this, "Unk 103", "Unk_103"),
                    new MultiStructItemCustomView(this, "Unk 104", "Unk_104"),
                    new MultiStructItemCustomView(this, "Unk 105", "Unk_105"),
                    new MultiStructItemCustomView(this, "Unk 106", "Unk_106"),
                    new MultiStructItemCustomView(this, "Unk 107", "Unk_107"),
                    new MultiStructItemCustomView(this, "Unk 108", "Unk_108"),
                    new MultiStructItemCustomView(this, "Unk 109", "Unk_109"),
                    new MultiStructItemCustomView(this, "Unk 110", "Unk_110"),
                    new MultiStructItemCustomView(this, "Unk 111", "Unk_111"),
                    new MultiStructItemCustomView(this, "Unk 112", "Unk_112"),
                    new MultiStructItemCustomView(this, "Unk 113", "Unk_113"),
                    new MultiStructItemCustomView(this, "Unk 114", "Unk_114"),
                    new MultiStructItemCustomView(this, "Unk 115", "Unk_115"),
                    new MultiStructItemCustomView(this, "Unk 116", "Unk_116"),
                    new MultiStructItemCustomView(this, "Unk 117", "Unk_117"),
                    new MultiStructItemCustomView(this, "Unk 118", "Unk_118"),
                    new MultiStructItemCustomView(this, "Unk 119", "Unk_119"),
                    new MultiStructItemCustomView(this, "Unk 120", "Unk_120"),
                    new MultiStructItemCustomView(this, "Walk Turn Speed", "Walk_Turn_Speed"),
                    new MultiStructItemCustomView(this, "Walk Turn Speed (Room)", "Walk_Turn_Speed_Room_"),
                    new MultiStructItemCustomView(this, "Walk Stop Margin Time", "Walk_Stop_Margin_Time"),
                    new MultiStructItemCustomView(this, "Female Motion Start Time", "Female_Motion_Start_Time"),
                    new MultiStructItemCustomView(this, "Unk 121", "Unk_121"),
                    new MultiStructItemCustomView(this, "Unk 122", "Unk_122"),
                    new MultiStructItemCustomView(this, "Walk Motion Speed (Room)", "Walk_Motion_Speed_Room_"),
                    new MultiStructItemCustomView(this, "Walk Motion Speed", "Walk_Motion_Speed"),
                    new MultiStructItemCustomView(this, "Run Stop Margin Time", "Run_Stop_Margin_Time"),
                    new MultiStructItemCustomView(this, "Run Turn Speed", "Run_Turn_Speed"),
                    new MultiStructItemCustomView(this, "Run Turn Lever Angle", "Run_Turn_Lever_Angle"),
                    new MultiStructItemCustomView(this, "Run Female Motion Start Time", "Run_Female_Motion_Start_Time"),
                    new MultiStructItemCustomView(this, "Unk 123", "Unk_123"),
                    new MultiStructItemCustomView(this, "Unk 124", "Unk_124"),
                    new MultiStructItemCustomView(this, "Run Motion Speed (Room)", "Run_Motion_Speed_Room_"),
                    new MultiStructItemCustomView(this, "Run Motion Speed", "Run_Motion_Speed"),
                    new MultiStructItemCustomView(this, "Dash Turn Speed", "Dash_Turn_Speed"),
                    new MultiStructItemCustomView(this, "Dash Motion Speed", "Dash_Motion_Speed"),
                    new MultiStructItemCustomView(this, "Unk 125", "Unk_125"),
                    new MultiStructItemCustomView(this, "Unk 126", "Unk_126"),
                    new MultiStructItemCustomView(this, "Unk 127", "Unk_127"),
                    new MultiStructItemCustomView(this, "Unk 128", "Unk_128"),
                    new MultiStructItemCustomView(this, "Unk 129", "Unk_129"),
                    new MultiStructItemCustomView(this, "Unk 130", "Unk_130"),
                    new MultiStructItemCustomView(this, "Unk 131", "Unk_131"),
                    new MultiStructItemCustomView(this, "Unk 132", "Unk_132"),
                    new MultiStructItemCustomView(this, "Unk 133", "Unk_133"),
                    new MultiStructItemCustomView(this, "Unk 134", "Unk_134"),
                    new MultiStructItemCustomView(this, "Unk 135", "Unk_135"),
                    new MultiStructItemCustomView(this, "Unk 136", "Unk_136"),
                    new MultiStructItemCustomView(this, "Unk 137", "Unk_137"),
                    new MultiStructItemCustomView(this, "Unk 138", "Unk_138"),
                    new MultiStructItemCustomView(this, "Unk 139", "Unk_139"),
                    new MultiStructItemCustomView(this, "Unk 140", "Unk_140"),
                    new MultiStructItemCustomView(this, "Unk 141", "Unk_141"),
                    new MultiStructItemCustomView(this, "Unk 142", "Unk_142"),
                    new MultiStructItemCustomView(this, "Unk 143", "Unk_143"),
                    new MultiStructItemCustomView(this, "Unk 144", "Unk_144"),
                    new MultiStructItemCustomView(this, "Unk 145", "Unk_145"),
                    new MultiStructItemCustomView(this, "Unk 146", "Unk_146"),
                    new MultiStructItemCustomView(this, "Unk 147", "Unk_147"),
                    new MultiStructItemCustomView(this, "Unk 148", "Unk_148"),
                    new MultiStructItemCustomView(this, "Unk 149", "Unk_149"),
                    new MultiStructItemCustomView(this, "Unk 150", "Unk_150"),
                    new MultiStructItemCustomView(this, "Unk 151", "Unk_151"),
                    new MultiStructItemCustomView(this, "Unk 152", "Unk_152"),
                    new MultiStructItemCustomView(this, "Unk 153", "Unk_153"),
                    new MultiStructItemCustomView(this, "Unk 154", "Unk_154"),
                    new MultiStructItemCustomView(this, "Unk 155", "Unk_155"),
                    new MultiStructItemCustomView(this, "Unk 156", "Unk_156"),
                    new MultiStructItemCustomView(this, "Unk 157", "Unk_157"),
                };
            }
        }

        public partial class Player_Params_5_Dodge_IFrames : MhwStructItem {
            public const ulong FixedSizeCount = 10;
            public const string GridName = "Player Params (5) - Dodge IFrames";

            protected float Evasion_0_raw;
            public const string Evasion_0_displayName = "Evasion 0";
            public const int Evasion_0_sortIndex = 50;
            [SortOrder(Evasion_0_sortIndex)]
            [DisplayName(Evasion_0_displayName)]
            public virtual float Evasion_0 {
                get => Evasion_0_raw;
                set {
                    if (Evasion_0_raw == value) return;
                    Evasion_0_raw = value;
                    OnPropertyChanged(nameof(Evasion_0));
                }
            }

            protected float Evasion_1_raw;
            public const string Evasion_1_displayName = "Evasion 1";
            public const int Evasion_1_sortIndex = 100;
            [SortOrder(Evasion_1_sortIndex)]
            [DisplayName(Evasion_1_displayName)]
            public virtual float Evasion_1 {
                get => Evasion_1_raw;
                set {
                    if (Evasion_1_raw == value) return;
                    Evasion_1_raw = value;
                    OnPropertyChanged(nameof(Evasion_1));
                }
            }

            protected float Evasion_2_raw;
            public const string Evasion_2_displayName = "Evasion 2";
            public const int Evasion_2_sortIndex = 150;
            [SortOrder(Evasion_2_sortIndex)]
            [DisplayName(Evasion_2_displayName)]
            public virtual float Evasion_2 {
                get => Evasion_2_raw;
                set {
                    if (Evasion_2_raw == value) return;
                    Evasion_2_raw = value;
                    OnPropertyChanged(nameof(Evasion_2));
                }
            }

            protected float Evasion_3_raw;
            public const string Evasion_3_displayName = "Evasion 3";
            public const int Evasion_3_sortIndex = 200;
            [SortOrder(Evasion_3_sortIndex)]
            [DisplayName(Evasion_3_displayName)]
            public virtual float Evasion_3 {
                get => Evasion_3_raw;
                set {
                    if (Evasion_3_raw == value) return;
                    Evasion_3_raw = value;
                    OnPropertyChanged(nameof(Evasion_3));
                }
            }

            protected float Evasion_4_raw;
            public const string Evasion_4_displayName = "Evasion 4";
            public const int Evasion_4_sortIndex = 250;
            [SortOrder(Evasion_4_sortIndex)]
            [DisplayName(Evasion_4_displayName)]
            public virtual float Evasion_4 {
                get => Evasion_4_raw;
                set {
                    if (Evasion_4_raw == value) return;
                    Evasion_4_raw = value;
                    OnPropertyChanged(nameof(Evasion_4));
                }
            }

            protected float Evasion_5_raw;
            public const string Evasion_5_displayName = "Evasion 5";
            public const int Evasion_5_sortIndex = 300;
            [SortOrder(Evasion_5_sortIndex)]
            [DisplayName(Evasion_5_displayName)]
            public virtual float Evasion_5 {
                get => Evasion_5_raw;
                set {
                    if (Evasion_5_raw == value) return;
                    Evasion_5_raw = value;
                    OnPropertyChanged(nameof(Evasion_5));
                }
            }

            protected float Evasion_Mantle_raw;
            public const string Evasion_Mantle_displayName = "Evasion Mantle";
            public const int Evasion_Mantle_sortIndex = 350;
            [SortOrder(Evasion_Mantle_sortIndex)]
            [DisplayName(Evasion_Mantle_displayName)]
            public virtual float Evasion_Mantle {
                get => Evasion_Mantle_raw;
                set {
                    if (Evasion_Mantle_raw == value) return;
                    Evasion_Mantle_raw = value;
                    OnPropertyChanged(nameof(Evasion_Mantle));
                }
            }

            public const int lastSortIndex = 400;

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
                var count = 10UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Player_Params_5_Dodge_IFrames LoadData(BinaryReader reader, ulong i) {
                var data = new Player_Params_5_Dodge_IFrames();
                data.Index = i;
                data.Evasion_0_raw = reader.ReadSingle();
                data.Evasion_1_raw = reader.ReadSingle();
                data.Evasion_2_raw = reader.ReadSingle();
                data.Evasion_3_raw = reader.ReadSingle();
                data.Evasion_4_raw = reader.ReadSingle();
                data.Evasion_5_raw = reader.ReadSingle();
                data.Evasion_Mantle_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Evasion_0_raw);
                writer.Write(Evasion_1_raw);
                writer.Write(Evasion_2_raw);
                writer.Write(Evasion_3_raw);
                writer.Write(Evasion_4_raw);
                writer.Write(Evasion_5_raw);
                writer.Write(Evasion_Mantle_raw);
            }
        }

        public partial class Player_Params_6_Evade_Distance : MhwStructItem {
            public const ulong FixedSizeCount = 11;
            public const string GridName = "Player Params (6) - Evade Distance";

            protected float Distance_1_raw;
            public const string Distance_1_displayName = "Distance 1";
            public const int Distance_1_sortIndex = 50;
            [SortOrder(Distance_1_sortIndex)]
            [DisplayName(Distance_1_displayName)]
            public virtual float Distance_1 {
                get => Distance_1_raw;
                set {
                    if (Distance_1_raw == value) return;
                    Distance_1_raw = value;
                    OnPropertyChanged(nameof(Distance_1));
                }
            }

            protected float Distance_2_raw;
            public const string Distance_2_displayName = "Distance 2";
            public const int Distance_2_sortIndex = 100;
            [SortOrder(Distance_2_sortIndex)]
            [DisplayName(Distance_2_displayName)]
            public virtual float Distance_2 {
                get => Distance_2_raw;
                set {
                    if (Distance_2_raw == value) return;
                    Distance_2_raw = value;
                    OnPropertyChanged(nameof(Distance_2));
                }
            }

            protected float Distance_3_raw;
            public const string Distance_3_displayName = "Distance 3";
            public const int Distance_3_sortIndex = 150;
            [SortOrder(Distance_3_sortIndex)]
            [DisplayName(Distance_3_displayName)]
            public virtual float Distance_3 {
                get => Distance_3_raw;
                set {
                    if (Distance_3_raw == value) return;
                    Distance_3_raw = value;
                    OnPropertyChanged(nameof(Distance_3));
                }
            }

            public const int lastSortIndex = 200;

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
                var count = 11UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Player_Params_6_Evade_Distance LoadData(BinaryReader reader, ulong i) {
                var data = new Player_Params_6_Evade_Distance();
                data.Index = i;
                data.Distance_1_raw = reader.ReadSingle();
                data.Distance_2_raw = reader.ReadSingle();
                data.Distance_3_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Distance_1_raw);
                writer.Write(Distance_2_raw);
                writer.Write(Distance_3_raw);
            }
        }

        public partial class Skipping_Ahead_1_ : MhwStructItem {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Skipping Ahead (1)";

            public partial class Raw_Bytes_1_ : MhwStructItem {
                public const ulong FixedSizeCount = 7014;
                public const string GridName = "Raw Bytes (1)";

                protected byte Byte_raw;
                public const string Byte_displayName = "Byte";
                public const int Byte_sortIndex = 50;
                [SortOrder(Byte_sortIndex)]
                [DisplayName(Byte_displayName)]
                public virtual byte Byte {
                    get => Byte_raw;
                    set {
                        if (Byte_raw == value) return;
                        Byte_raw = value;
                        OnPropertyChanged(nameof(Byte));
                    }
                }

                public const int lastSortIndex = 100;

                public static ObservableCollection<Raw_Bytes_1_> LoadData(BinaryReader reader, Skipping_Ahead_1_ parent) {
                    var list = new ObservableCollection<Raw_Bytes_1_>();
                    var count = 7014UL;
                    for (ulong i = 0; i < count; i++) {
                        list.Add(LoadData(reader, i, parent));
                    }
                    return list;
                }

                public static Raw_Bytes_1_ LoadData(BinaryReader reader, ulong i, Skipping_Ahead_1_ parent) {
                    var data = new Raw_Bytes_1_();
                    data.Index = i;
                    data.Byte_raw = reader.ReadByte();
                    return data;
                }

                public void WriteData(BinaryWriter writer, Skipping_Ahead_1_ parent) {
                    writer.Write(Byte_raw);
                }
            }

            public const string Raw_Bytes_displayName = "Raw Bytes";
            public const int Raw_Bytes_sortIndex = 50;
            [SortOrder(Raw_Bytes_sortIndex)]
            [DisplayName(Raw_Bytes_displayName)]
            public virtual ObservableCollection<Raw_Bytes_1_> Raw_Bytes_raw { get; protected set; }

            public const int lastSortIndex = 100;

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Skipping_Ahead_1_ LoadData(BinaryReader reader, ulong i) {
                var data = new Skipping_Ahead_1_();
                data.Index = i;
                data.Raw_Bytes_raw = Raw_Bytes_1_.LoadData(reader, data);
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                foreach (var obj in Raw_Bytes_raw) {
                    obj.WriteData(writer, this);
                }
            }
        }

        public partial class Player_Params_7_HR_MR_Augment_Params : MhwStructItem, IHasCustomView<MultiStructItemCustomView> {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Player Params (7) - HR/MR Augment Params";

            protected byte Wp_HR_Augment_Attack_Bonus_1__raw;
            public const string Wp_HR_Augment_Attack_Bonus_1__displayName = "Wp HR Augment Attack Bonus (1)";
            public const int Wp_HR_Augment_Attack_Bonus_1__sortIndex = 50;
            [SortOrder(Wp_HR_Augment_Attack_Bonus_1__sortIndex)]
            [DisplayName(Wp_HR_Augment_Attack_Bonus_1__displayName)]
            public virtual byte Wp_HR_Augment_Attack_Bonus_1_ {
                get => Wp_HR_Augment_Attack_Bonus_1__raw;
                set {
                    if (Wp_HR_Augment_Attack_Bonus_1__raw == value) return;
                    Wp_HR_Augment_Attack_Bonus_1__raw = value;
                    OnPropertyChanged(nameof(Wp_HR_Augment_Attack_Bonus_1_));
                }
            }

            protected byte Wp_HR_Augment_Attack_Bonus_2__raw;
            public const string Wp_HR_Augment_Attack_Bonus_2__displayName = "Wp HR Augment Attack Bonus (2)";
            public const int Wp_HR_Augment_Attack_Bonus_2__sortIndex = 100;
            [SortOrder(Wp_HR_Augment_Attack_Bonus_2__sortIndex)]
            [DisplayName(Wp_HR_Augment_Attack_Bonus_2__displayName)]
            public virtual byte Wp_HR_Augment_Attack_Bonus_2_ {
                get => Wp_HR_Augment_Attack_Bonus_2__raw;
                set {
                    if (Wp_HR_Augment_Attack_Bonus_2__raw == value) return;
                    Wp_HR_Augment_Attack_Bonus_2__raw = value;
                    OnPropertyChanged(nameof(Wp_HR_Augment_Attack_Bonus_2_));
                }
            }

            protected byte Wp_HR_Augment_Attack_Bonus_3__raw;
            public const string Wp_HR_Augment_Attack_Bonus_3__displayName = "Wp HR Augment Attack Bonus (3)";
            public const int Wp_HR_Augment_Attack_Bonus_3__sortIndex = 150;
            [SortOrder(Wp_HR_Augment_Attack_Bonus_3__sortIndex)]
            [DisplayName(Wp_HR_Augment_Attack_Bonus_3__displayName)]
            public virtual byte Wp_HR_Augment_Attack_Bonus_3_ {
                get => Wp_HR_Augment_Attack_Bonus_3__raw;
                set {
                    if (Wp_HR_Augment_Attack_Bonus_3__raw == value) return;
                    Wp_HR_Augment_Attack_Bonus_3__raw = value;
                    OnPropertyChanged(nameof(Wp_HR_Augment_Attack_Bonus_3_));
                }
            }

            protected byte Wp_HR_Augment_Critical_Bonus_1__raw;
            public const string Wp_HR_Augment_Critical_Bonus_1__displayName = "Wp HR Augment Critical Bonus (1)";
            public const int Wp_HR_Augment_Critical_Bonus_1__sortIndex = 200;
            [SortOrder(Wp_HR_Augment_Critical_Bonus_1__sortIndex)]
            [DisplayName(Wp_HR_Augment_Critical_Bonus_1__displayName)]
            public virtual byte Wp_HR_Augment_Critical_Bonus_1_ {
                get => Wp_HR_Augment_Critical_Bonus_1__raw;
                set {
                    if (Wp_HR_Augment_Critical_Bonus_1__raw == value) return;
                    Wp_HR_Augment_Critical_Bonus_1__raw = value;
                    OnPropertyChanged(nameof(Wp_HR_Augment_Critical_Bonus_1_));
                }
            }

            protected byte Wp_HR_Augment_Critical_Bonus_2__raw;
            public const string Wp_HR_Augment_Critical_Bonus_2__displayName = "Wp HR Augment Critical Bonus (2)";
            public const int Wp_HR_Augment_Critical_Bonus_2__sortIndex = 250;
            [SortOrder(Wp_HR_Augment_Critical_Bonus_2__sortIndex)]
            [DisplayName(Wp_HR_Augment_Critical_Bonus_2__displayName)]
            public virtual byte Wp_HR_Augment_Critical_Bonus_2_ {
                get => Wp_HR_Augment_Critical_Bonus_2__raw;
                set {
                    if (Wp_HR_Augment_Critical_Bonus_2__raw == value) return;
                    Wp_HR_Augment_Critical_Bonus_2__raw = value;
                    OnPropertyChanged(nameof(Wp_HR_Augment_Critical_Bonus_2_));
                }
            }

            protected byte Wp_HR_Augment_Critical_Bonus_3__raw;
            public const string Wp_HR_Augment_Critical_Bonus_3__displayName = "Wp HR Augment Critical Bonus (3)";
            public const int Wp_HR_Augment_Critical_Bonus_3__sortIndex = 300;
            [SortOrder(Wp_HR_Augment_Critical_Bonus_3__sortIndex)]
            [DisplayName(Wp_HR_Augment_Critical_Bonus_3__displayName)]
            public virtual byte Wp_HR_Augment_Critical_Bonus_3_ {
                get => Wp_HR_Augment_Critical_Bonus_3__raw;
                set {
                    if (Wp_HR_Augment_Critical_Bonus_3__raw == value) return;
                    Wp_HR_Augment_Critical_Bonus_3__raw = value;
                    OnPropertyChanged(nameof(Wp_HR_Augment_Critical_Bonus_3_));
                }
            }

            protected byte Wp_HR_Augment_Defense_Bonus_1__raw;
            public const string Wp_HR_Augment_Defense_Bonus_1__displayName = "Wp HR Augment Defense Bonus (1)";
            public const int Wp_HR_Augment_Defense_Bonus_1__sortIndex = 350;
            [SortOrder(Wp_HR_Augment_Defense_Bonus_1__sortIndex)]
            [DisplayName(Wp_HR_Augment_Defense_Bonus_1__displayName)]
            public virtual byte Wp_HR_Augment_Defense_Bonus_1_ {
                get => Wp_HR_Augment_Defense_Bonus_1__raw;
                set {
                    if (Wp_HR_Augment_Defense_Bonus_1__raw == value) return;
                    Wp_HR_Augment_Defense_Bonus_1__raw = value;
                    OnPropertyChanged(nameof(Wp_HR_Augment_Defense_Bonus_1_));
                }
            }

            protected byte Wp_HR_Augment_Defense_Bonus_2__raw;
            public const string Wp_HR_Augment_Defense_Bonus_2__displayName = "Wp HR Augment Defense Bonus (2)";
            public const int Wp_HR_Augment_Defense_Bonus_2__sortIndex = 400;
            [SortOrder(Wp_HR_Augment_Defense_Bonus_2__sortIndex)]
            [DisplayName(Wp_HR_Augment_Defense_Bonus_2__displayName)]
            public virtual byte Wp_HR_Augment_Defense_Bonus_2_ {
                get => Wp_HR_Augment_Defense_Bonus_2__raw;
                set {
                    if (Wp_HR_Augment_Defense_Bonus_2__raw == value) return;
                    Wp_HR_Augment_Defense_Bonus_2__raw = value;
                    OnPropertyChanged(nameof(Wp_HR_Augment_Defense_Bonus_2_));
                }
            }

            protected byte Wp_HR_Augment_Defense_Bonus_3__raw;
            public const string Wp_HR_Augment_Defense_Bonus_3__displayName = "Wp HR Augment Defense Bonus (3)";
            public const int Wp_HR_Augment_Defense_Bonus_3__sortIndex = 450;
            [SortOrder(Wp_HR_Augment_Defense_Bonus_3__sortIndex)]
            [DisplayName(Wp_HR_Augment_Defense_Bonus_3__displayName)]
            public virtual byte Wp_HR_Augment_Defense_Bonus_3_ {
                get => Wp_HR_Augment_Defense_Bonus_3__raw;
                set {
                    if (Wp_HR_Augment_Defense_Bonus_3__raw == value) return;
                    Wp_HR_Augment_Defense_Bonus_3__raw = value;
                    OnPropertyChanged(nameof(Wp_HR_Augment_Defense_Bonus_3_));
                }
            }

            protected byte Wp_HR_Augment_Defense_Divine_Blessing_Chance_1__raw;
            public const string Wp_HR_Augment_Defense_Divine_Blessing_Chance_1__displayName = "Wp HR Augment Defense: Divine Blessing Chance (1)";
            public const int Wp_HR_Augment_Defense_Divine_Blessing_Chance_1__sortIndex = 500;
            [SortOrder(Wp_HR_Augment_Defense_Divine_Blessing_Chance_1__sortIndex)]
            [DisplayName(Wp_HR_Augment_Defense_Divine_Blessing_Chance_1__displayName)]
            public virtual byte Wp_HR_Augment_Defense_Divine_Blessing_Chance_1_ {
                get => Wp_HR_Augment_Defense_Divine_Blessing_Chance_1__raw;
                set {
                    if (Wp_HR_Augment_Defense_Divine_Blessing_Chance_1__raw == value) return;
                    Wp_HR_Augment_Defense_Divine_Blessing_Chance_1__raw = value;
                    OnPropertyChanged(nameof(Wp_HR_Augment_Defense_Divine_Blessing_Chance_1_));
                }
            }

            protected byte Wp_HR_Augment_Defense_Divine_Blessing_Chance_2__raw;
            public const string Wp_HR_Augment_Defense_Divine_Blessing_Chance_2__displayName = "Wp HR Augment Defense: Divine Blessing Chance (2)";
            public const int Wp_HR_Augment_Defense_Divine_Blessing_Chance_2__sortIndex = 550;
            [SortOrder(Wp_HR_Augment_Defense_Divine_Blessing_Chance_2__sortIndex)]
            [DisplayName(Wp_HR_Augment_Defense_Divine_Blessing_Chance_2__displayName)]
            public virtual byte Wp_HR_Augment_Defense_Divine_Blessing_Chance_2_ {
                get => Wp_HR_Augment_Defense_Divine_Blessing_Chance_2__raw;
                set {
                    if (Wp_HR_Augment_Defense_Divine_Blessing_Chance_2__raw == value) return;
                    Wp_HR_Augment_Defense_Divine_Blessing_Chance_2__raw = value;
                    OnPropertyChanged(nameof(Wp_HR_Augment_Defense_Divine_Blessing_Chance_2_));
                }
            }

            protected byte Wp_HR_Augment_Defense_Divine_Blessing_Chance_3__raw;
            public const string Wp_HR_Augment_Defense_Divine_Blessing_Chance_3__displayName = "Wp HR Augment Defense: Divine Blessing Chance (3)";
            public const int Wp_HR_Augment_Defense_Divine_Blessing_Chance_3__sortIndex = 600;
            [SortOrder(Wp_HR_Augment_Defense_Divine_Blessing_Chance_3__sortIndex)]
            [DisplayName(Wp_HR_Augment_Defense_Divine_Blessing_Chance_3__displayName)]
            public virtual byte Wp_HR_Augment_Defense_Divine_Blessing_Chance_3_ {
                get => Wp_HR_Augment_Defense_Divine_Blessing_Chance_3__raw;
                set {
                    if (Wp_HR_Augment_Defense_Divine_Blessing_Chance_3__raw == value) return;
                    Wp_HR_Augment_Defense_Divine_Blessing_Chance_3__raw = value;
                    OnPropertyChanged(nameof(Wp_HR_Augment_Defense_Divine_Blessing_Chance_3_));
                }
            }

            protected float Wp_HR_Augment_Defense_Divine_Blessing_Reduction_1__raw;
            public const string Wp_HR_Augment_Defense_Divine_Blessing_Reduction_1__displayName = "Wp HR Augment Defense: Divine Blessing Reduction (1)";
            public const int Wp_HR_Augment_Defense_Divine_Blessing_Reduction_1__sortIndex = 650;
            [SortOrder(Wp_HR_Augment_Defense_Divine_Blessing_Reduction_1__sortIndex)]
            [DisplayName(Wp_HR_Augment_Defense_Divine_Blessing_Reduction_1__displayName)]
            public virtual float Wp_HR_Augment_Defense_Divine_Blessing_Reduction_1_ {
                get => Wp_HR_Augment_Defense_Divine_Blessing_Reduction_1__raw;
                set {
                    if (Wp_HR_Augment_Defense_Divine_Blessing_Reduction_1__raw == value) return;
                    Wp_HR_Augment_Defense_Divine_Blessing_Reduction_1__raw = value;
                    OnPropertyChanged(nameof(Wp_HR_Augment_Defense_Divine_Blessing_Reduction_1_));
                }
            }

            protected float Wp_HR_Augment_Defense_Divine_Blessing_Reduction_2__raw;
            public const string Wp_HR_Augment_Defense_Divine_Blessing_Reduction_2__displayName = "Wp HR Augment Defense: Divine Blessing Reduction (2)";
            public const int Wp_HR_Augment_Defense_Divine_Blessing_Reduction_2__sortIndex = 700;
            [SortOrder(Wp_HR_Augment_Defense_Divine_Blessing_Reduction_2__sortIndex)]
            [DisplayName(Wp_HR_Augment_Defense_Divine_Blessing_Reduction_2__displayName)]
            public virtual float Wp_HR_Augment_Defense_Divine_Blessing_Reduction_2_ {
                get => Wp_HR_Augment_Defense_Divine_Blessing_Reduction_2__raw;
                set {
                    if (Wp_HR_Augment_Defense_Divine_Blessing_Reduction_2__raw == value) return;
                    Wp_HR_Augment_Defense_Divine_Blessing_Reduction_2__raw = value;
                    OnPropertyChanged(nameof(Wp_HR_Augment_Defense_Divine_Blessing_Reduction_2_));
                }
            }

            protected float Wp_HR_Augment_Defense_Divine_Blessing_Reduction_3__raw;
            public const string Wp_HR_Augment_Defense_Divine_Blessing_Reduction_3__displayName = "Wp HR Augment Defense: Divine Blessing Reduction (3)";
            public const int Wp_HR_Augment_Defense_Divine_Blessing_Reduction_3__sortIndex = 750;
            [SortOrder(Wp_HR_Augment_Defense_Divine_Blessing_Reduction_3__sortIndex)]
            [DisplayName(Wp_HR_Augment_Defense_Divine_Blessing_Reduction_3__displayName)]
            public virtual float Wp_HR_Augment_Defense_Divine_Blessing_Reduction_3_ {
                get => Wp_HR_Augment_Defense_Divine_Blessing_Reduction_3__raw;
                set {
                    if (Wp_HR_Augment_Defense_Divine_Blessing_Reduction_3__raw == value) return;
                    Wp_HR_Augment_Defense_Divine_Blessing_Reduction_3__raw = value;
                    OnPropertyChanged(nameof(Wp_HR_Augment_Defense_Divine_Blessing_Reduction_3_));
                }
            }

            protected float Wp_HR_Augment_Defense_Heal_Damage_Rate_1__raw;
            public const string Wp_HR_Augment_Defense_Heal_Damage_Rate_1__displayName = "Wp HR Augment Defense Heal Damage Rate (1)";
            public const int Wp_HR_Augment_Defense_Heal_Damage_Rate_1__sortIndex = 800;
            [SortOrder(Wp_HR_Augment_Defense_Heal_Damage_Rate_1__sortIndex)]
            [DisplayName(Wp_HR_Augment_Defense_Heal_Damage_Rate_1__displayName)]
            public virtual float Wp_HR_Augment_Defense_Heal_Damage_Rate_1_ {
                get => Wp_HR_Augment_Defense_Heal_Damage_Rate_1__raw;
                set {
                    if (Wp_HR_Augment_Defense_Heal_Damage_Rate_1__raw == value) return;
                    Wp_HR_Augment_Defense_Heal_Damage_Rate_1__raw = value;
                    OnPropertyChanged(nameof(Wp_HR_Augment_Defense_Heal_Damage_Rate_1_));
                }
            }

            protected float Wp_HR_Augment_Defense_Heal_Damage_Rate_2__raw;
            public const string Wp_HR_Augment_Defense_Heal_Damage_Rate_2__displayName = "Wp HR Augment Defense Heal Damage Rate (2)";
            public const int Wp_HR_Augment_Defense_Heal_Damage_Rate_2__sortIndex = 850;
            [SortOrder(Wp_HR_Augment_Defense_Heal_Damage_Rate_2__sortIndex)]
            [DisplayName(Wp_HR_Augment_Defense_Heal_Damage_Rate_2__displayName)]
            public virtual float Wp_HR_Augment_Defense_Heal_Damage_Rate_2_ {
                get => Wp_HR_Augment_Defense_Heal_Damage_Rate_2__raw;
                set {
                    if (Wp_HR_Augment_Defense_Heal_Damage_Rate_2__raw == value) return;
                    Wp_HR_Augment_Defense_Heal_Damage_Rate_2__raw = value;
                    OnPropertyChanged(nameof(Wp_HR_Augment_Defense_Heal_Damage_Rate_2_));
                }
            }

            protected float Wp_HR_Augment_Defense_Heal_Damage_Rate_3__raw;
            public const string Wp_HR_Augment_Defense_Heal_Damage_Rate_3__displayName = "Wp HR Augment Defense Heal Damage Rate (3)";
            public const int Wp_HR_Augment_Defense_Heal_Damage_Rate_3__sortIndex = 900;
            [SortOrder(Wp_HR_Augment_Defense_Heal_Damage_Rate_3__sortIndex)]
            [DisplayName(Wp_HR_Augment_Defense_Heal_Damage_Rate_3__displayName)]
            public virtual float Wp_HR_Augment_Defense_Heal_Damage_Rate_3_ {
                get => Wp_HR_Augment_Defense_Heal_Damage_Rate_3__raw;
                set {
                    if (Wp_HR_Augment_Defense_Heal_Damage_Rate_3__raw == value) return;
                    Wp_HR_Augment_Defense_Heal_Damage_Rate_3__raw = value;
                    OnPropertyChanged(nameof(Wp_HR_Augment_Defense_Heal_Damage_Rate_3_));
                }
            }

            protected float Wp_HR_Augment_IB_Unk_raw;
            public const string Wp_HR_Augment_IB_Unk_displayName = "Wp HR Augment IB Unk";
            public const int Wp_HR_Augment_IB_Unk_sortIndex = 950;
            [SortOrder(Wp_HR_Augment_IB_Unk_sortIndex)]
            [DisplayName(Wp_HR_Augment_IB_Unk_displayName)]
            public virtual float Wp_HR_Augment_IB_Unk {
                get => Wp_HR_Augment_IB_Unk_raw;
                set {
                    if (Wp_HR_Augment_IB_Unk_raw == value) return;
                    Wp_HR_Augment_IB_Unk_raw = value;
                    OnPropertyChanged(nameof(Wp_HR_Augment_IB_Unk));
                }
            }

            protected float Wp_HR_Augment_Lifesteal_Cooldown_raw;
            public const string Wp_HR_Augment_Lifesteal_Cooldown_displayName = "Wp HR Augment Lifesteal Cooldown";
            public const int Wp_HR_Augment_Lifesteal_Cooldown_sortIndex = 1000;
            [SortOrder(Wp_HR_Augment_Lifesteal_Cooldown_sortIndex)]
            [DisplayName(Wp_HR_Augment_Lifesteal_Cooldown_displayName)]
            public virtual float Wp_HR_Augment_Lifesteal_Cooldown {
                get => Wp_HR_Augment_Lifesteal_Cooldown_raw;
                set {
                    if (Wp_HR_Augment_Lifesteal_Cooldown_raw == value) return;
                    Wp_HR_Augment_Lifesteal_Cooldown_raw = value;
                    OnPropertyChanged(nameof(Wp_HR_Augment_Lifesteal_Cooldown));
                }
            }

            protected byte Wp_MR_Augment_Attack_Bonus_1__raw;
            public const string Wp_MR_Augment_Attack_Bonus_1__displayName = "Wp MR Augment Attack Bonus (1)";
            public const int Wp_MR_Augment_Attack_Bonus_1__sortIndex = 1050;
            [SortOrder(Wp_MR_Augment_Attack_Bonus_1__sortIndex)]
            [DisplayName(Wp_MR_Augment_Attack_Bonus_1__displayName)]
            public virtual byte Wp_MR_Augment_Attack_Bonus_1_ {
                get => Wp_MR_Augment_Attack_Bonus_1__raw;
                set {
                    if (Wp_MR_Augment_Attack_Bonus_1__raw == value) return;
                    Wp_MR_Augment_Attack_Bonus_1__raw = value;
                    OnPropertyChanged(nameof(Wp_MR_Augment_Attack_Bonus_1_));
                }
            }

            protected byte Wp_MR_Augment_Attack_Bonus_2__raw;
            public const string Wp_MR_Augment_Attack_Bonus_2__displayName = "Wp MR Augment Attack Bonus (2)";
            public const int Wp_MR_Augment_Attack_Bonus_2__sortIndex = 1100;
            [SortOrder(Wp_MR_Augment_Attack_Bonus_2__sortIndex)]
            [DisplayName(Wp_MR_Augment_Attack_Bonus_2__displayName)]
            public virtual byte Wp_MR_Augment_Attack_Bonus_2_ {
                get => Wp_MR_Augment_Attack_Bonus_2__raw;
                set {
                    if (Wp_MR_Augment_Attack_Bonus_2__raw == value) return;
                    Wp_MR_Augment_Attack_Bonus_2__raw = value;
                    OnPropertyChanged(nameof(Wp_MR_Augment_Attack_Bonus_2_));
                }
            }

            protected byte Wp_MR_Augment_Attack_Bonus_3__raw;
            public const string Wp_MR_Augment_Attack_Bonus_3__displayName = "Wp MR Augment Attack Bonus (3)";
            public const int Wp_MR_Augment_Attack_Bonus_3__sortIndex = 1150;
            [SortOrder(Wp_MR_Augment_Attack_Bonus_3__sortIndex)]
            [DisplayName(Wp_MR_Augment_Attack_Bonus_3__displayName)]
            public virtual byte Wp_MR_Augment_Attack_Bonus_3_ {
                get => Wp_MR_Augment_Attack_Bonus_3__raw;
                set {
                    if (Wp_MR_Augment_Attack_Bonus_3__raw == value) return;
                    Wp_MR_Augment_Attack_Bonus_3__raw = value;
                    OnPropertyChanged(nameof(Wp_MR_Augment_Attack_Bonus_3_));
                }
            }

            protected byte Wp_MR_Augment_Attack_Bonus_4__raw;
            public const string Wp_MR_Augment_Attack_Bonus_4__displayName = "Wp MR Augment Attack Bonus (4)";
            public const int Wp_MR_Augment_Attack_Bonus_4__sortIndex = 1200;
            [SortOrder(Wp_MR_Augment_Attack_Bonus_4__sortIndex)]
            [DisplayName(Wp_MR_Augment_Attack_Bonus_4__displayName)]
            public virtual byte Wp_MR_Augment_Attack_Bonus_4_ {
                get => Wp_MR_Augment_Attack_Bonus_4__raw;
                set {
                    if (Wp_MR_Augment_Attack_Bonus_4__raw == value) return;
                    Wp_MR_Augment_Attack_Bonus_4__raw = value;
                    OnPropertyChanged(nameof(Wp_MR_Augment_Attack_Bonus_4_));
                }
            }

            protected byte Wp_MR_Augment_Critical_Bonus_1__raw;
            public const string Wp_MR_Augment_Critical_Bonus_1__displayName = "Wp MR Augment Critical Bonus (1)";
            public const int Wp_MR_Augment_Critical_Bonus_1__sortIndex = 1250;
            [SortOrder(Wp_MR_Augment_Critical_Bonus_1__sortIndex)]
            [DisplayName(Wp_MR_Augment_Critical_Bonus_1__displayName)]
            public virtual byte Wp_MR_Augment_Critical_Bonus_1_ {
                get => Wp_MR_Augment_Critical_Bonus_1__raw;
                set {
                    if (Wp_MR_Augment_Critical_Bonus_1__raw == value) return;
                    Wp_MR_Augment_Critical_Bonus_1__raw = value;
                    OnPropertyChanged(nameof(Wp_MR_Augment_Critical_Bonus_1_));
                }
            }

            protected byte Wp_MR_Augment_Critical_Bonus_2__raw;
            public const string Wp_MR_Augment_Critical_Bonus_2__displayName = "Wp MR Augment Critical Bonus (2)";
            public const int Wp_MR_Augment_Critical_Bonus_2__sortIndex = 1300;
            [SortOrder(Wp_MR_Augment_Critical_Bonus_2__sortIndex)]
            [DisplayName(Wp_MR_Augment_Critical_Bonus_2__displayName)]
            public virtual byte Wp_MR_Augment_Critical_Bonus_2_ {
                get => Wp_MR_Augment_Critical_Bonus_2__raw;
                set {
                    if (Wp_MR_Augment_Critical_Bonus_2__raw == value) return;
                    Wp_MR_Augment_Critical_Bonus_2__raw = value;
                    OnPropertyChanged(nameof(Wp_MR_Augment_Critical_Bonus_2_));
                }
            }

            protected byte Wp_MR_Augment_Critical_Bonus_3__raw;
            public const string Wp_MR_Augment_Critical_Bonus_3__displayName = "Wp MR Augment Critical Bonus (3)";
            public const int Wp_MR_Augment_Critical_Bonus_3__sortIndex = 1350;
            [SortOrder(Wp_MR_Augment_Critical_Bonus_3__sortIndex)]
            [DisplayName(Wp_MR_Augment_Critical_Bonus_3__displayName)]
            public virtual byte Wp_MR_Augment_Critical_Bonus_3_ {
                get => Wp_MR_Augment_Critical_Bonus_3__raw;
                set {
                    if (Wp_MR_Augment_Critical_Bonus_3__raw == value) return;
                    Wp_MR_Augment_Critical_Bonus_3__raw = value;
                    OnPropertyChanged(nameof(Wp_MR_Augment_Critical_Bonus_3_));
                }
            }

            protected byte Wp_MR_Augment_Critical_Bonus_4__raw;
            public const string Wp_MR_Augment_Critical_Bonus_4__displayName = "Wp MR Augment Critical Bonus (4)";
            public const int Wp_MR_Augment_Critical_Bonus_4__sortIndex = 1400;
            [SortOrder(Wp_MR_Augment_Critical_Bonus_4__sortIndex)]
            [DisplayName(Wp_MR_Augment_Critical_Bonus_4__displayName)]
            public virtual byte Wp_MR_Augment_Critical_Bonus_4_ {
                get => Wp_MR_Augment_Critical_Bonus_4__raw;
                set {
                    if (Wp_MR_Augment_Critical_Bonus_4__raw == value) return;
                    Wp_MR_Augment_Critical_Bonus_4__raw = value;
                    OnPropertyChanged(nameof(Wp_MR_Augment_Critical_Bonus_4_));
                }
            }

            protected byte Wp_MR_Augment_Defense_Bonus_1__raw;
            public const string Wp_MR_Augment_Defense_Bonus_1__displayName = "Wp MR Augment Defense Bonus (1)";
            public const int Wp_MR_Augment_Defense_Bonus_1__sortIndex = 1450;
            [SortOrder(Wp_MR_Augment_Defense_Bonus_1__sortIndex)]
            [DisplayName(Wp_MR_Augment_Defense_Bonus_1__displayName)]
            public virtual byte Wp_MR_Augment_Defense_Bonus_1_ {
                get => Wp_MR_Augment_Defense_Bonus_1__raw;
                set {
                    if (Wp_MR_Augment_Defense_Bonus_1__raw == value) return;
                    Wp_MR_Augment_Defense_Bonus_1__raw = value;
                    OnPropertyChanged(nameof(Wp_MR_Augment_Defense_Bonus_1_));
                }
            }

            protected byte Wp_MR_Augment_Defense_Bonus_2__raw;
            public const string Wp_MR_Augment_Defense_Bonus_2__displayName = "Wp MR Augment Defense Bonus (2)";
            public const int Wp_MR_Augment_Defense_Bonus_2__sortIndex = 1500;
            [SortOrder(Wp_MR_Augment_Defense_Bonus_2__sortIndex)]
            [DisplayName(Wp_MR_Augment_Defense_Bonus_2__displayName)]
            public virtual byte Wp_MR_Augment_Defense_Bonus_2_ {
                get => Wp_MR_Augment_Defense_Bonus_2__raw;
                set {
                    if (Wp_MR_Augment_Defense_Bonus_2__raw == value) return;
                    Wp_MR_Augment_Defense_Bonus_2__raw = value;
                    OnPropertyChanged(nameof(Wp_MR_Augment_Defense_Bonus_2_));
                }
            }

            protected byte Wp_MR_Augment_Defense_Bonus_3__raw;
            public const string Wp_MR_Augment_Defense_Bonus_3__displayName = "Wp MR Augment Defense Bonus (3)";
            public const int Wp_MR_Augment_Defense_Bonus_3__sortIndex = 1550;
            [SortOrder(Wp_MR_Augment_Defense_Bonus_3__sortIndex)]
            [DisplayName(Wp_MR_Augment_Defense_Bonus_3__displayName)]
            public virtual byte Wp_MR_Augment_Defense_Bonus_3_ {
                get => Wp_MR_Augment_Defense_Bonus_3__raw;
                set {
                    if (Wp_MR_Augment_Defense_Bonus_3__raw == value) return;
                    Wp_MR_Augment_Defense_Bonus_3__raw = value;
                    OnPropertyChanged(nameof(Wp_MR_Augment_Defense_Bonus_3_));
                }
            }

            protected byte Wp_MR_Augment_Defense_Bonus_4__raw;
            public const string Wp_MR_Augment_Defense_Bonus_4__displayName = "Wp MR Augment Defense Bonus (4)";
            public const int Wp_MR_Augment_Defense_Bonus_4__sortIndex = 1600;
            [SortOrder(Wp_MR_Augment_Defense_Bonus_4__sortIndex)]
            [DisplayName(Wp_MR_Augment_Defense_Bonus_4__displayName)]
            public virtual byte Wp_MR_Augment_Defense_Bonus_4_ {
                get => Wp_MR_Augment_Defense_Bonus_4__raw;
                set {
                    if (Wp_MR_Augment_Defense_Bonus_4__raw == value) return;
                    Wp_MR_Augment_Defense_Bonus_4__raw = value;
                    OnPropertyChanged(nameof(Wp_MR_Augment_Defense_Bonus_4_));
                }
            }

            protected byte Wp_MR_Augment_Defense_Divine_Blessing_Chance_1__raw;
            public const string Wp_MR_Augment_Defense_Divine_Blessing_Chance_1__displayName = "Wp MR Augment Defense: Divine Blessing Chance (1)";
            public const int Wp_MR_Augment_Defense_Divine_Blessing_Chance_1__sortIndex = 1650;
            [SortOrder(Wp_MR_Augment_Defense_Divine_Blessing_Chance_1__sortIndex)]
            [DisplayName(Wp_MR_Augment_Defense_Divine_Blessing_Chance_1__displayName)]
            public virtual byte Wp_MR_Augment_Defense_Divine_Blessing_Chance_1_ {
                get => Wp_MR_Augment_Defense_Divine_Blessing_Chance_1__raw;
                set {
                    if (Wp_MR_Augment_Defense_Divine_Blessing_Chance_1__raw == value) return;
                    Wp_MR_Augment_Defense_Divine_Blessing_Chance_1__raw = value;
                    OnPropertyChanged(nameof(Wp_MR_Augment_Defense_Divine_Blessing_Chance_1_));
                }
            }

            protected byte Wp_MR_Augment_Defense_Divine_Blessing_Chance_2__raw;
            public const string Wp_MR_Augment_Defense_Divine_Blessing_Chance_2__displayName = "Wp MR Augment Defense: Divine Blessing Chance (2)";
            public const int Wp_MR_Augment_Defense_Divine_Blessing_Chance_2__sortIndex = 1700;
            [SortOrder(Wp_MR_Augment_Defense_Divine_Blessing_Chance_2__sortIndex)]
            [DisplayName(Wp_MR_Augment_Defense_Divine_Blessing_Chance_2__displayName)]
            public virtual byte Wp_MR_Augment_Defense_Divine_Blessing_Chance_2_ {
                get => Wp_MR_Augment_Defense_Divine_Blessing_Chance_2__raw;
                set {
                    if (Wp_MR_Augment_Defense_Divine_Blessing_Chance_2__raw == value) return;
                    Wp_MR_Augment_Defense_Divine_Blessing_Chance_2__raw = value;
                    OnPropertyChanged(nameof(Wp_MR_Augment_Defense_Divine_Blessing_Chance_2_));
                }
            }

            protected byte Wp_MR_Augment_Defense_Divine_Blessing_Chance_3__raw;
            public const string Wp_MR_Augment_Defense_Divine_Blessing_Chance_3__displayName = "Wp MR Augment Defense: Divine Blessing Chance (3)";
            public const int Wp_MR_Augment_Defense_Divine_Blessing_Chance_3__sortIndex = 1750;
            [SortOrder(Wp_MR_Augment_Defense_Divine_Blessing_Chance_3__sortIndex)]
            [DisplayName(Wp_MR_Augment_Defense_Divine_Blessing_Chance_3__displayName)]
            public virtual byte Wp_MR_Augment_Defense_Divine_Blessing_Chance_3_ {
                get => Wp_MR_Augment_Defense_Divine_Blessing_Chance_3__raw;
                set {
                    if (Wp_MR_Augment_Defense_Divine_Blessing_Chance_3__raw == value) return;
                    Wp_MR_Augment_Defense_Divine_Blessing_Chance_3__raw = value;
                    OnPropertyChanged(nameof(Wp_MR_Augment_Defense_Divine_Blessing_Chance_3_));
                }
            }

            protected byte Wp_MR_Augment_Defense_Divine_Blessing_Chance_4__raw;
            public const string Wp_MR_Augment_Defense_Divine_Blessing_Chance_4__displayName = "Wp MR Augment Defense: Divine Blessing Chance (4)";
            public const int Wp_MR_Augment_Defense_Divine_Blessing_Chance_4__sortIndex = 1800;
            [SortOrder(Wp_MR_Augment_Defense_Divine_Blessing_Chance_4__sortIndex)]
            [DisplayName(Wp_MR_Augment_Defense_Divine_Blessing_Chance_4__displayName)]
            public virtual byte Wp_MR_Augment_Defense_Divine_Blessing_Chance_4_ {
                get => Wp_MR_Augment_Defense_Divine_Blessing_Chance_4__raw;
                set {
                    if (Wp_MR_Augment_Defense_Divine_Blessing_Chance_4__raw == value) return;
                    Wp_MR_Augment_Defense_Divine_Blessing_Chance_4__raw = value;
                    OnPropertyChanged(nameof(Wp_MR_Augment_Defense_Divine_Blessing_Chance_4_));
                }
            }

            protected float Wp_MR_Augment_Defense_Divine_Blessing_Reduction_1__raw;
            public const string Wp_MR_Augment_Defense_Divine_Blessing_Reduction_1__displayName = "Wp MR Augment Defense: Divine Blessing Reduction (1)";
            public const int Wp_MR_Augment_Defense_Divine_Blessing_Reduction_1__sortIndex = 1850;
            [SortOrder(Wp_MR_Augment_Defense_Divine_Blessing_Reduction_1__sortIndex)]
            [DisplayName(Wp_MR_Augment_Defense_Divine_Blessing_Reduction_1__displayName)]
            public virtual float Wp_MR_Augment_Defense_Divine_Blessing_Reduction_1_ {
                get => Wp_MR_Augment_Defense_Divine_Blessing_Reduction_1__raw;
                set {
                    if (Wp_MR_Augment_Defense_Divine_Blessing_Reduction_1__raw == value) return;
                    Wp_MR_Augment_Defense_Divine_Blessing_Reduction_1__raw = value;
                    OnPropertyChanged(nameof(Wp_MR_Augment_Defense_Divine_Blessing_Reduction_1_));
                }
            }

            protected float Wp_MR_Augment_Defense_Divine_Blessing_Reduction_2__raw;
            public const string Wp_MR_Augment_Defense_Divine_Blessing_Reduction_2__displayName = "Wp MR Augment Defense: Divine Blessing Reduction (2)";
            public const int Wp_MR_Augment_Defense_Divine_Blessing_Reduction_2__sortIndex = 1900;
            [SortOrder(Wp_MR_Augment_Defense_Divine_Blessing_Reduction_2__sortIndex)]
            [DisplayName(Wp_MR_Augment_Defense_Divine_Blessing_Reduction_2__displayName)]
            public virtual float Wp_MR_Augment_Defense_Divine_Blessing_Reduction_2_ {
                get => Wp_MR_Augment_Defense_Divine_Blessing_Reduction_2__raw;
                set {
                    if (Wp_MR_Augment_Defense_Divine_Blessing_Reduction_2__raw == value) return;
                    Wp_MR_Augment_Defense_Divine_Blessing_Reduction_2__raw = value;
                    OnPropertyChanged(nameof(Wp_MR_Augment_Defense_Divine_Blessing_Reduction_2_));
                }
            }

            protected float Wp_MR_Augment_Defense_Divine_Blessing_Reduction_3__raw;
            public const string Wp_MR_Augment_Defense_Divine_Blessing_Reduction_3__displayName = "Wp MR Augment Defense: Divine Blessing Reduction (3)";
            public const int Wp_MR_Augment_Defense_Divine_Blessing_Reduction_3__sortIndex = 1950;
            [SortOrder(Wp_MR_Augment_Defense_Divine_Blessing_Reduction_3__sortIndex)]
            [DisplayName(Wp_MR_Augment_Defense_Divine_Blessing_Reduction_3__displayName)]
            public virtual float Wp_MR_Augment_Defense_Divine_Blessing_Reduction_3_ {
                get => Wp_MR_Augment_Defense_Divine_Blessing_Reduction_3__raw;
                set {
                    if (Wp_MR_Augment_Defense_Divine_Blessing_Reduction_3__raw == value) return;
                    Wp_MR_Augment_Defense_Divine_Blessing_Reduction_3__raw = value;
                    OnPropertyChanged(nameof(Wp_MR_Augment_Defense_Divine_Blessing_Reduction_3_));
                }
            }

            protected float Wp_MR_Augment_Defense_Divine_Blessing_Reduction_4__raw;
            public const string Wp_MR_Augment_Defense_Divine_Blessing_Reduction_4__displayName = "Wp MR Augment Defense: Divine Blessing Reduction (4)";
            public const int Wp_MR_Augment_Defense_Divine_Blessing_Reduction_4__sortIndex = 2000;
            [SortOrder(Wp_MR_Augment_Defense_Divine_Blessing_Reduction_4__sortIndex)]
            [DisplayName(Wp_MR_Augment_Defense_Divine_Blessing_Reduction_4__displayName)]
            public virtual float Wp_MR_Augment_Defense_Divine_Blessing_Reduction_4_ {
                get => Wp_MR_Augment_Defense_Divine_Blessing_Reduction_4__raw;
                set {
                    if (Wp_MR_Augment_Defense_Divine_Blessing_Reduction_4__raw == value) return;
                    Wp_MR_Augment_Defense_Divine_Blessing_Reduction_4__raw = value;
                    OnPropertyChanged(nameof(Wp_MR_Augment_Defense_Divine_Blessing_Reduction_4_));
                }
            }

            protected float Wp_MR_Augment_Health_Percent_1__raw;
            public const string Wp_MR_Augment_Health_Percent_1__displayName = "Wp MR Augment Health Percent (1)";
            public const int Wp_MR_Augment_Health_Percent_1__sortIndex = 2050;
            [SortOrder(Wp_MR_Augment_Health_Percent_1__sortIndex)]
            [DisplayName(Wp_MR_Augment_Health_Percent_1__displayName)]
            public virtual float Wp_MR_Augment_Health_Percent_1_ {
                get => Wp_MR_Augment_Health_Percent_1__raw;
                set {
                    if (Wp_MR_Augment_Health_Percent_1__raw == value) return;
                    Wp_MR_Augment_Health_Percent_1__raw = value;
                    OnPropertyChanged(nameof(Wp_MR_Augment_Health_Percent_1_));
                }
            }

            protected float Wp_MR_Augment_Health_Percent_2__raw;
            public const string Wp_MR_Augment_Health_Percent_2__displayName = "Wp MR Augment Health Percent (2)";
            public const int Wp_MR_Augment_Health_Percent_2__sortIndex = 2100;
            [SortOrder(Wp_MR_Augment_Health_Percent_2__sortIndex)]
            [DisplayName(Wp_MR_Augment_Health_Percent_2__displayName)]
            public virtual float Wp_MR_Augment_Health_Percent_2_ {
                get => Wp_MR_Augment_Health_Percent_2__raw;
                set {
                    if (Wp_MR_Augment_Health_Percent_2__raw == value) return;
                    Wp_MR_Augment_Health_Percent_2__raw = value;
                    OnPropertyChanged(nameof(Wp_MR_Augment_Health_Percent_2_));
                }
            }

            protected float Wp_MR_Augment_Health_Percent_3__raw;
            public const string Wp_MR_Augment_Health_Percent_3__displayName = "Wp MR Augment Health Percent (3)";
            public const int Wp_MR_Augment_Health_Percent_3__sortIndex = 2150;
            [SortOrder(Wp_MR_Augment_Health_Percent_3__sortIndex)]
            [DisplayName(Wp_MR_Augment_Health_Percent_3__displayName)]
            public virtual float Wp_MR_Augment_Health_Percent_3_ {
                get => Wp_MR_Augment_Health_Percent_3__raw;
                set {
                    if (Wp_MR_Augment_Health_Percent_3__raw == value) return;
                    Wp_MR_Augment_Health_Percent_3__raw = value;
                    OnPropertyChanged(nameof(Wp_MR_Augment_Health_Percent_3_));
                }
            }

            protected float Wp_MR_Augment_Health_Percent_4__raw;
            public const string Wp_MR_Augment_Health_Percent_4__displayName = "Wp MR Augment Health Percent (4)";
            public const int Wp_MR_Augment_Health_Percent_4__sortIndex = 2200;
            [SortOrder(Wp_MR_Augment_Health_Percent_4__sortIndex)]
            [DisplayName(Wp_MR_Augment_Health_Percent_4__displayName)]
            public virtual float Wp_MR_Augment_Health_Percent_4_ {
                get => Wp_MR_Augment_Health_Percent_4__raw;
                set {
                    if (Wp_MR_Augment_Health_Percent_4__raw == value) return;
                    Wp_MR_Augment_Health_Percent_4__raw = value;
                    OnPropertyChanged(nameof(Wp_MR_Augment_Health_Percent_4_));
                }
            }

            protected float WP_MR_Wyrmstake_Blast_Health_Regen_raw;
            public const string WP_MR_Wyrmstake_Blast_Health_Regen_displayName = "WP MR Wyrmstake Blast Health Regen";
            public const int WP_MR_Wyrmstake_Blast_Health_Regen_sortIndex = 2250;
            [SortOrder(WP_MR_Wyrmstake_Blast_Health_Regen_sortIndex)]
            [DisplayName(WP_MR_Wyrmstake_Blast_Health_Regen_displayName)]
            public virtual float WP_MR_Wyrmstake_Blast_Health_Regen {
                get => WP_MR_Wyrmstake_Blast_Health_Regen_raw;
                set {
                    if (WP_MR_Wyrmstake_Blast_Health_Regen_raw == value) return;
                    WP_MR_Wyrmstake_Blast_Health_Regen_raw = value;
                    OnPropertyChanged(nameof(WP_MR_Wyrmstake_Blast_Health_Regen));
                }
            }

            protected float Wp_MR_Augment_Lifesteal_Cooldown_raw;
            public const string Wp_MR_Augment_Lifesteal_Cooldown_displayName = "Wp MR Augment Lifesteal Cooldown";
            public const int Wp_MR_Augment_Lifesteal_Cooldown_sortIndex = 2300;
            [SortOrder(Wp_MR_Augment_Lifesteal_Cooldown_sortIndex)]
            [DisplayName(Wp_MR_Augment_Lifesteal_Cooldown_displayName)]
            public virtual float Wp_MR_Augment_Lifesteal_Cooldown {
                get => Wp_MR_Augment_Lifesteal_Cooldown_raw;
                set {
                    if (Wp_MR_Augment_Lifesteal_Cooldown_raw == value) return;
                    Wp_MR_Augment_Lifesteal_Cooldown_raw = value;
                    OnPropertyChanged(nameof(Wp_MR_Augment_Lifesteal_Cooldown));
                }
            }

            protected byte Wp_MR_Augment_Element_1__raw;
            public const string Wp_MR_Augment_Element_1__displayName = "Wp MR Augment Element (1)";
            public const int Wp_MR_Augment_Element_1__sortIndex = 2350;
            [SortOrder(Wp_MR_Augment_Element_1__sortIndex)]
            [DisplayName(Wp_MR_Augment_Element_1__displayName)]
            public virtual byte Wp_MR_Augment_Element_1_ {
                get => Wp_MR_Augment_Element_1__raw;
                set {
                    if (Wp_MR_Augment_Element_1__raw == value) return;
                    Wp_MR_Augment_Element_1__raw = value;
                    OnPropertyChanged(nameof(Wp_MR_Augment_Element_1_));
                }
            }

            protected byte Wp_MR_Augment_Element_2__raw;
            public const string Wp_MR_Augment_Element_2__displayName = "Wp MR Augment Element (2)";
            public const int Wp_MR_Augment_Element_2__sortIndex = 2400;
            [SortOrder(Wp_MR_Augment_Element_2__sortIndex)]
            [DisplayName(Wp_MR_Augment_Element_2__displayName)]
            public virtual byte Wp_MR_Augment_Element_2_ {
                get => Wp_MR_Augment_Element_2__raw;
                set {
                    if (Wp_MR_Augment_Element_2__raw == value) return;
                    Wp_MR_Augment_Element_2__raw = value;
                    OnPropertyChanged(nameof(Wp_MR_Augment_Element_2_));
                }
            }

            protected byte Wp_MR_Augment_Element_3__raw;
            public const string Wp_MR_Augment_Element_3__displayName = "Wp MR Augment Element (3)";
            public const int Wp_MR_Augment_Element_3__sortIndex = 2450;
            [SortOrder(Wp_MR_Augment_Element_3__sortIndex)]
            [DisplayName(Wp_MR_Augment_Element_3__displayName)]
            public virtual byte Wp_MR_Augment_Element_3_ {
                get => Wp_MR_Augment_Element_3__raw;
                set {
                    if (Wp_MR_Augment_Element_3__raw == value) return;
                    Wp_MR_Augment_Element_3__raw = value;
                    OnPropertyChanged(nameof(Wp_MR_Augment_Element_3_));
                }
            }

            protected byte Wp_MR_Augment_Element_4__raw;
            public const string Wp_MR_Augment_Element_4__displayName = "Wp MR Augment Element (4)";
            public const int Wp_MR_Augment_Element_4__sortIndex = 2500;
            [SortOrder(Wp_MR_Augment_Element_4__sortIndex)]
            [DisplayName(Wp_MR_Augment_Element_4__displayName)]
            public virtual byte Wp_MR_Augment_Element_4_ {
                get => Wp_MR_Augment_Element_4__raw;
                set {
                    if (Wp_MR_Augment_Element_4__raw == value) return;
                    Wp_MR_Augment_Element_4__raw = value;
                    OnPropertyChanged(nameof(Wp_MR_Augment_Element_4_));
                }
            }

            protected byte Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_1__raw;
            public const string Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_1__displayName = "Wp MR Augment Bowgun Element/Status: Ammo Element Bonus (1)";
            public const int Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_1__sortIndex = 2550;
            [SortOrder(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_1__sortIndex)]
            [DisplayName(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_1__displayName)]
            public virtual byte Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_1_ {
                get => Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_1__raw;
                set {
                    if (Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_1__raw == value) return;
                    Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_1__raw = value;
                    OnPropertyChanged(nameof(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_1_));
                }
            }

            protected byte Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_2__raw;
            public const string Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_2__displayName = "Wp MR Augment Bowgun Element/Status: Ammo Element Bonus (2)";
            public const int Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_2__sortIndex = 2600;
            [SortOrder(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_2__sortIndex)]
            [DisplayName(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_2__displayName)]
            public virtual byte Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_2_ {
                get => Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_2__raw;
                set {
                    if (Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_2__raw == value) return;
                    Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_2__raw = value;
                    OnPropertyChanged(nameof(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_2_));
                }
            }

            protected byte Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_3__raw;
            public const string Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_3__displayName = "Wp MR Augment Bowgun Element/Status: Ammo Element Bonus (3)";
            public const int Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_3__sortIndex = 2650;
            [SortOrder(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_3__sortIndex)]
            [DisplayName(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_3__displayName)]
            public virtual byte Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_3_ {
                get => Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_3__raw;
                set {
                    if (Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_3__raw == value) return;
                    Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_3__raw = value;
                    OnPropertyChanged(nameof(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_3_));
                }
            }

            protected byte Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_4__raw;
            public const string Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_4__displayName = "Wp MR Augment Bowgun Element/Status: Ammo Element Bonus (4)";
            public const int Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_4__sortIndex = 2700;
            [SortOrder(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_4__sortIndex)]
            [DisplayName(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_4__displayName)]
            public virtual byte Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_4_ {
                get => Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_4__raw;
                set {
                    if (Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_4__raw == value) return;
                    Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_4__raw = value;
                    OnPropertyChanged(nameof(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_4_));
                }
            }

            protected byte Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_1__raw;
            public const string Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_1__displayName = "Wp MR Augment Bowgun Element/Status: Ammo Status Bonus (1)";
            public const int Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_1__sortIndex = 2750;
            [SortOrder(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_1__sortIndex)]
            [DisplayName(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_1__displayName)]
            public virtual byte Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_1_ {
                get => Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_1__raw;
                set {
                    if (Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_1__raw == value) return;
                    Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_1__raw = value;
                    OnPropertyChanged(nameof(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_1_));
                }
            }

            protected byte Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_2__raw;
            public const string Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_2__displayName = "Wp MR Augment Bowgun Element/Status: Ammo Status Bonus (2)";
            public const int Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_2__sortIndex = 2800;
            [SortOrder(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_2__sortIndex)]
            [DisplayName(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_2__displayName)]
            public virtual byte Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_2_ {
                get => Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_2__raw;
                set {
                    if (Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_2__raw == value) return;
                    Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_2__raw = value;
                    OnPropertyChanged(nameof(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_2_));
                }
            }

            protected byte Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_3__raw;
            public const string Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_3__displayName = "Wp MR Augment Bowgun Element/Status: Ammo Status Bonus (3)";
            public const int Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_3__sortIndex = 2850;
            [SortOrder(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_3__sortIndex)]
            [DisplayName(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_3__displayName)]
            public virtual byte Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_3_ {
                get => Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_3__raw;
                set {
                    if (Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_3__raw == value) return;
                    Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_3__raw = value;
                    OnPropertyChanged(nameof(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_3_));
                }
            }

            protected byte Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_4__raw;
            public const string Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_4__displayName = "Wp MR Augment Bowgun Element/Status: Ammo Status Bonus (4)";
            public const int Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_4__sortIndex = 2900;
            [SortOrder(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_4__sortIndex)]
            [DisplayName(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_4__displayName)]
            public virtual byte Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_4_ {
                get => Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_4__raw;
                set {
                    if (Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_4__raw == value) return;
                    Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_4__raw = value;
                    OnPropertyChanged(nameof(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_4_));
                }
            }

            protected float Wp_MR_Augment_Great_Sword_Elemental_Multiplier_raw;
            public const string Wp_MR_Augment_Great_Sword_Elemental_Multiplier_displayName = "Wp MR Augment Great Sword Elemental Multiplier";
            public const int Wp_MR_Augment_Great_Sword_Elemental_Multiplier_sortIndex = 2950;
            [SortOrder(Wp_MR_Augment_Great_Sword_Elemental_Multiplier_sortIndex)]
            [DisplayName(Wp_MR_Augment_Great_Sword_Elemental_Multiplier_displayName)]
            public virtual float Wp_MR_Augment_Great_Sword_Elemental_Multiplier {
                get => Wp_MR_Augment_Great_Sword_Elemental_Multiplier_raw;
                set {
                    if (Wp_MR_Augment_Great_Sword_Elemental_Multiplier_raw == value) return;
                    Wp_MR_Augment_Great_Sword_Elemental_Multiplier_raw = value;
                    OnPropertyChanged(nameof(Wp_MR_Augment_Great_Sword_Elemental_Multiplier));
                }
            }

            protected float Wp_MR_Augment_Sword_Shield_Elemental_Multiplier_raw;
            public const string Wp_MR_Augment_Sword_Shield_Elemental_Multiplier_displayName = "Wp MR Augment Sword & Shield Elemental Multiplier";
            public const int Wp_MR_Augment_Sword_Shield_Elemental_Multiplier_sortIndex = 3000;
            [SortOrder(Wp_MR_Augment_Sword_Shield_Elemental_Multiplier_sortIndex)]
            [DisplayName(Wp_MR_Augment_Sword_Shield_Elemental_Multiplier_displayName)]
            public virtual float Wp_MR_Augment_Sword_Shield_Elemental_Multiplier {
                get => Wp_MR_Augment_Sword_Shield_Elemental_Multiplier_raw;
                set {
                    if (Wp_MR_Augment_Sword_Shield_Elemental_Multiplier_raw == value) return;
                    Wp_MR_Augment_Sword_Shield_Elemental_Multiplier_raw = value;
                    OnPropertyChanged(nameof(Wp_MR_Augment_Sword_Shield_Elemental_Multiplier));
                }
            }

            protected float Wp_MR_Augment_Dual_Blades_Elemental_Multiplier_raw;
            public const string Wp_MR_Augment_Dual_Blades_Elemental_Multiplier_displayName = "Wp MR Augment Dual Blades Elemental Multiplier";
            public const int Wp_MR_Augment_Dual_Blades_Elemental_Multiplier_sortIndex = 3050;
            [SortOrder(Wp_MR_Augment_Dual_Blades_Elemental_Multiplier_sortIndex)]
            [DisplayName(Wp_MR_Augment_Dual_Blades_Elemental_Multiplier_displayName)]
            public virtual float Wp_MR_Augment_Dual_Blades_Elemental_Multiplier {
                get => Wp_MR_Augment_Dual_Blades_Elemental_Multiplier_raw;
                set {
                    if (Wp_MR_Augment_Dual_Blades_Elemental_Multiplier_raw == value) return;
                    Wp_MR_Augment_Dual_Blades_Elemental_Multiplier_raw = value;
                    OnPropertyChanged(nameof(Wp_MR_Augment_Dual_Blades_Elemental_Multiplier));
                }
            }

            protected float Wp_MR_Augment_Long_Sword_Elemental_Multiplier_raw;
            public const string Wp_MR_Augment_Long_Sword_Elemental_Multiplier_displayName = "Wp MR Augment Long Sword Elemental Multiplier";
            public const int Wp_MR_Augment_Long_Sword_Elemental_Multiplier_sortIndex = 3100;
            [SortOrder(Wp_MR_Augment_Long_Sword_Elemental_Multiplier_sortIndex)]
            [DisplayName(Wp_MR_Augment_Long_Sword_Elemental_Multiplier_displayName)]
            public virtual float Wp_MR_Augment_Long_Sword_Elemental_Multiplier {
                get => Wp_MR_Augment_Long_Sword_Elemental_Multiplier_raw;
                set {
                    if (Wp_MR_Augment_Long_Sword_Elemental_Multiplier_raw == value) return;
                    Wp_MR_Augment_Long_Sword_Elemental_Multiplier_raw = value;
                    OnPropertyChanged(nameof(Wp_MR_Augment_Long_Sword_Elemental_Multiplier));
                }
            }

            protected float Wp_MR_Augment_Hammer_Elemental_Multiplier_raw;
            public const string Wp_MR_Augment_Hammer_Elemental_Multiplier_displayName = "Wp MR Augment Hammer Elemental Multiplier";
            public const int Wp_MR_Augment_Hammer_Elemental_Multiplier_sortIndex = 3150;
            [SortOrder(Wp_MR_Augment_Hammer_Elemental_Multiplier_sortIndex)]
            [DisplayName(Wp_MR_Augment_Hammer_Elemental_Multiplier_displayName)]
            public virtual float Wp_MR_Augment_Hammer_Elemental_Multiplier {
                get => Wp_MR_Augment_Hammer_Elemental_Multiplier_raw;
                set {
                    if (Wp_MR_Augment_Hammer_Elemental_Multiplier_raw == value) return;
                    Wp_MR_Augment_Hammer_Elemental_Multiplier_raw = value;
                    OnPropertyChanged(nameof(Wp_MR_Augment_Hammer_Elemental_Multiplier));
                }
            }

            protected float Wp_MR_Augment_Hunting_Horn_Elemental_Multiplier_raw;
            public const string Wp_MR_Augment_Hunting_Horn_Elemental_Multiplier_displayName = "Wp MR Augment Hunting Horn Elemental Multiplier";
            public const int Wp_MR_Augment_Hunting_Horn_Elemental_Multiplier_sortIndex = 3200;
            [SortOrder(Wp_MR_Augment_Hunting_Horn_Elemental_Multiplier_sortIndex)]
            [DisplayName(Wp_MR_Augment_Hunting_Horn_Elemental_Multiplier_displayName)]
            public virtual float Wp_MR_Augment_Hunting_Horn_Elemental_Multiplier {
                get => Wp_MR_Augment_Hunting_Horn_Elemental_Multiplier_raw;
                set {
                    if (Wp_MR_Augment_Hunting_Horn_Elemental_Multiplier_raw == value) return;
                    Wp_MR_Augment_Hunting_Horn_Elemental_Multiplier_raw = value;
                    OnPropertyChanged(nameof(Wp_MR_Augment_Hunting_Horn_Elemental_Multiplier));
                }
            }

            protected float Wp_MR_Augment_Lance_Elemental_Multiplier_raw;
            public const string Wp_MR_Augment_Lance_Elemental_Multiplier_displayName = "Wp MR Augment Lance Elemental Multiplier";
            public const int Wp_MR_Augment_Lance_Elemental_Multiplier_sortIndex = 3250;
            [SortOrder(Wp_MR_Augment_Lance_Elemental_Multiplier_sortIndex)]
            [DisplayName(Wp_MR_Augment_Lance_Elemental_Multiplier_displayName)]
            public virtual float Wp_MR_Augment_Lance_Elemental_Multiplier {
                get => Wp_MR_Augment_Lance_Elemental_Multiplier_raw;
                set {
                    if (Wp_MR_Augment_Lance_Elemental_Multiplier_raw == value) return;
                    Wp_MR_Augment_Lance_Elemental_Multiplier_raw = value;
                    OnPropertyChanged(nameof(Wp_MR_Augment_Lance_Elemental_Multiplier));
                }
            }

            protected float Wp_MR_Augment_Gunlance_Elemental_Multiplier_raw;
            public const string Wp_MR_Augment_Gunlance_Elemental_Multiplier_displayName = "Wp MR Augment Gunlance Elemental Multiplier";
            public const int Wp_MR_Augment_Gunlance_Elemental_Multiplier_sortIndex = 3300;
            [SortOrder(Wp_MR_Augment_Gunlance_Elemental_Multiplier_sortIndex)]
            [DisplayName(Wp_MR_Augment_Gunlance_Elemental_Multiplier_displayName)]
            public virtual float Wp_MR_Augment_Gunlance_Elemental_Multiplier {
                get => Wp_MR_Augment_Gunlance_Elemental_Multiplier_raw;
                set {
                    if (Wp_MR_Augment_Gunlance_Elemental_Multiplier_raw == value) return;
                    Wp_MR_Augment_Gunlance_Elemental_Multiplier_raw = value;
                    OnPropertyChanged(nameof(Wp_MR_Augment_Gunlance_Elemental_Multiplier));
                }
            }

            protected float Wp_MR_Augment_Switch_Axe_Elemental_Multiplier_raw;
            public const string Wp_MR_Augment_Switch_Axe_Elemental_Multiplier_displayName = "Wp MR Augment Switch Axe Elemental Multiplier";
            public const int Wp_MR_Augment_Switch_Axe_Elemental_Multiplier_sortIndex = 3350;
            [SortOrder(Wp_MR_Augment_Switch_Axe_Elemental_Multiplier_sortIndex)]
            [DisplayName(Wp_MR_Augment_Switch_Axe_Elemental_Multiplier_displayName)]
            public virtual float Wp_MR_Augment_Switch_Axe_Elemental_Multiplier {
                get => Wp_MR_Augment_Switch_Axe_Elemental_Multiplier_raw;
                set {
                    if (Wp_MR_Augment_Switch_Axe_Elemental_Multiplier_raw == value) return;
                    Wp_MR_Augment_Switch_Axe_Elemental_Multiplier_raw = value;
                    OnPropertyChanged(nameof(Wp_MR_Augment_Switch_Axe_Elemental_Multiplier));
                }
            }

            protected float Wp_MR_Augment_Charge_Blade_Elemental_Multiplier_raw;
            public const string Wp_MR_Augment_Charge_Blade_Elemental_Multiplier_displayName = "Wp MR Augment Charge Blade Elemental Multiplier";
            public const int Wp_MR_Augment_Charge_Blade_Elemental_Multiplier_sortIndex = 3400;
            [SortOrder(Wp_MR_Augment_Charge_Blade_Elemental_Multiplier_sortIndex)]
            [DisplayName(Wp_MR_Augment_Charge_Blade_Elemental_Multiplier_displayName)]
            public virtual float Wp_MR_Augment_Charge_Blade_Elemental_Multiplier {
                get => Wp_MR_Augment_Charge_Blade_Elemental_Multiplier_raw;
                set {
                    if (Wp_MR_Augment_Charge_Blade_Elemental_Multiplier_raw == value) return;
                    Wp_MR_Augment_Charge_Blade_Elemental_Multiplier_raw = value;
                    OnPropertyChanged(nameof(Wp_MR_Augment_Charge_Blade_Elemental_Multiplier));
                }
            }

            protected float Wp_MR_Augment_Insect_Glaive_Elemental_Multiplier_raw;
            public const string Wp_MR_Augment_Insect_Glaive_Elemental_Multiplier_displayName = "Wp MR Augment Insect Glaive Elemental Multiplier";
            public const int Wp_MR_Augment_Insect_Glaive_Elemental_Multiplier_sortIndex = 3450;
            [SortOrder(Wp_MR_Augment_Insect_Glaive_Elemental_Multiplier_sortIndex)]
            [DisplayName(Wp_MR_Augment_Insect_Glaive_Elemental_Multiplier_displayName)]
            public virtual float Wp_MR_Augment_Insect_Glaive_Elemental_Multiplier {
                get => Wp_MR_Augment_Insect_Glaive_Elemental_Multiplier_raw;
                set {
                    if (Wp_MR_Augment_Insect_Glaive_Elemental_Multiplier_raw == value) return;
                    Wp_MR_Augment_Insect_Glaive_Elemental_Multiplier_raw = value;
                    OnPropertyChanged(nameof(Wp_MR_Augment_Insect_Glaive_Elemental_Multiplier));
                }
            }

            protected float Wp_MR_Augment_Bow_Elemental_Multiplier_raw;
            public const string Wp_MR_Augment_Bow_Elemental_Multiplier_displayName = "Wp MR Augment Bow Elemental Multiplier";
            public const int Wp_MR_Augment_Bow_Elemental_Multiplier_sortIndex = 3500;
            [SortOrder(Wp_MR_Augment_Bow_Elemental_Multiplier_sortIndex)]
            [DisplayName(Wp_MR_Augment_Bow_Elemental_Multiplier_displayName)]
            public virtual float Wp_MR_Augment_Bow_Elemental_Multiplier {
                get => Wp_MR_Augment_Bow_Elemental_Multiplier_raw;
                set {
                    if (Wp_MR_Augment_Bow_Elemental_Multiplier_raw == value) return;
                    Wp_MR_Augment_Bow_Elemental_Multiplier_raw = value;
                    OnPropertyChanged(nameof(Wp_MR_Augment_Bow_Elemental_Multiplier));
                }
            }

            protected float Wp_MR_Augment_HBG_Elemental_Multiplier_raw;
            public const string Wp_MR_Augment_HBG_Elemental_Multiplier_displayName = "Wp MR Augment HBG Elemental Multiplier";
            public const int Wp_MR_Augment_HBG_Elemental_Multiplier_sortIndex = 3550;
            [SortOrder(Wp_MR_Augment_HBG_Elemental_Multiplier_sortIndex)]
            [DisplayName(Wp_MR_Augment_HBG_Elemental_Multiplier_displayName)]
            public virtual float Wp_MR_Augment_HBG_Elemental_Multiplier {
                get => Wp_MR_Augment_HBG_Elemental_Multiplier_raw;
                set {
                    if (Wp_MR_Augment_HBG_Elemental_Multiplier_raw == value) return;
                    Wp_MR_Augment_HBG_Elemental_Multiplier_raw = value;
                    OnPropertyChanged(nameof(Wp_MR_Augment_HBG_Elemental_Multiplier));
                }
            }

            protected float Wp_MR_Augment_LBG_Elemental_Multiplier_raw;
            public const string Wp_MR_Augment_LBG_Elemental_Multiplier_displayName = "Wp MR Augment LBG Elemental Multiplier";
            public const int Wp_MR_Augment_LBG_Elemental_Multiplier_sortIndex = 3600;
            [SortOrder(Wp_MR_Augment_LBG_Elemental_Multiplier_sortIndex)]
            [DisplayName(Wp_MR_Augment_LBG_Elemental_Multiplier_displayName)]
            public virtual float Wp_MR_Augment_LBG_Elemental_Multiplier {
                get => Wp_MR_Augment_LBG_Elemental_Multiplier_raw;
                set {
                    if (Wp_MR_Augment_LBG_Elemental_Multiplier_raw == value) return;
                    Wp_MR_Augment_LBG_Elemental_Multiplier_raw = value;
                    OnPropertyChanged(nameof(Wp_MR_Augment_LBG_Elemental_Multiplier));
                }
            }

            protected float Wp_MR_Augment_Bow_Coating_Status_Multiplier_1__raw;
            public const string Wp_MR_Augment_Bow_Coating_Status_Multiplier_1__displayName = "Wp MR Augment Bow Coating Status Multiplier (1)";
            public const int Wp_MR_Augment_Bow_Coating_Status_Multiplier_1__sortIndex = 3650;
            [SortOrder(Wp_MR_Augment_Bow_Coating_Status_Multiplier_1__sortIndex)]
            [DisplayName(Wp_MR_Augment_Bow_Coating_Status_Multiplier_1__displayName)]
            public virtual float Wp_MR_Augment_Bow_Coating_Status_Multiplier_1_ {
                get => Wp_MR_Augment_Bow_Coating_Status_Multiplier_1__raw;
                set {
                    if (Wp_MR_Augment_Bow_Coating_Status_Multiplier_1__raw == value) return;
                    Wp_MR_Augment_Bow_Coating_Status_Multiplier_1__raw = value;
                    OnPropertyChanged(nameof(Wp_MR_Augment_Bow_Coating_Status_Multiplier_1_));
                }
            }

            protected float Wp_MR_Augment_Bow_Coating_Status_Multiplier_2__raw;
            public const string Wp_MR_Augment_Bow_Coating_Status_Multiplier_2__displayName = "Wp MR Augment Bow Coating Status Multiplier (2)";
            public const int Wp_MR_Augment_Bow_Coating_Status_Multiplier_2__sortIndex = 3700;
            [SortOrder(Wp_MR_Augment_Bow_Coating_Status_Multiplier_2__sortIndex)]
            [DisplayName(Wp_MR_Augment_Bow_Coating_Status_Multiplier_2__displayName)]
            public virtual float Wp_MR_Augment_Bow_Coating_Status_Multiplier_2_ {
                get => Wp_MR_Augment_Bow_Coating_Status_Multiplier_2__raw;
                set {
                    if (Wp_MR_Augment_Bow_Coating_Status_Multiplier_2__raw == value) return;
                    Wp_MR_Augment_Bow_Coating_Status_Multiplier_2__raw = value;
                    OnPropertyChanged(nameof(Wp_MR_Augment_Bow_Coating_Status_Multiplier_2_));
                }
            }

            protected float Wp_MR_Augment_Bow_Coating_Status_Multiplier_3__raw;
            public const string Wp_MR_Augment_Bow_Coating_Status_Multiplier_3__displayName = "Wp MR Augment Bow Coating Status Multiplier (3)";
            public const int Wp_MR_Augment_Bow_Coating_Status_Multiplier_3__sortIndex = 3750;
            [SortOrder(Wp_MR_Augment_Bow_Coating_Status_Multiplier_3__sortIndex)]
            [DisplayName(Wp_MR_Augment_Bow_Coating_Status_Multiplier_3__displayName)]
            public virtual float Wp_MR_Augment_Bow_Coating_Status_Multiplier_3_ {
                get => Wp_MR_Augment_Bow_Coating_Status_Multiplier_3__raw;
                set {
                    if (Wp_MR_Augment_Bow_Coating_Status_Multiplier_3__raw == value) return;
                    Wp_MR_Augment_Bow_Coating_Status_Multiplier_3__raw = value;
                    OnPropertyChanged(nameof(Wp_MR_Augment_Bow_Coating_Status_Multiplier_3_));
                }
            }

            protected float Wp_MR_Augment_Bow_Coating_Status_Multiplier_4__raw;
            public const string Wp_MR_Augment_Bow_Coating_Status_Multiplier_4__displayName = "Wp MR Augment Bow Coating Status Multiplier (4)";
            public const int Wp_MR_Augment_Bow_Coating_Status_Multiplier_4__sortIndex = 3800;
            [SortOrder(Wp_MR_Augment_Bow_Coating_Status_Multiplier_4__sortIndex)]
            [DisplayName(Wp_MR_Augment_Bow_Coating_Status_Multiplier_4__displayName)]
            public virtual float Wp_MR_Augment_Bow_Coating_Status_Multiplier_4_ {
                get => Wp_MR_Augment_Bow_Coating_Status_Multiplier_4__raw;
                set {
                    if (Wp_MR_Augment_Bow_Coating_Status_Multiplier_4__raw == value) return;
                    Wp_MR_Augment_Bow_Coating_Status_Multiplier_4__raw = value;
                    OnPropertyChanged(nameof(Wp_MR_Augment_Bow_Coating_Status_Multiplier_4_));
                }
            }

            public const int lastSortIndex = 3850;

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Player_Params_7_HR_MR_Augment_Params LoadData(BinaryReader reader, ulong i) {
                var data = new Player_Params_7_HR_MR_Augment_Params();
                data.Index = i;
                data.Wp_HR_Augment_Attack_Bonus_1__raw = reader.ReadByte();
                data.Wp_HR_Augment_Attack_Bonus_2__raw = reader.ReadByte();
                data.Wp_HR_Augment_Attack_Bonus_3__raw = reader.ReadByte();
                data.Wp_HR_Augment_Critical_Bonus_1__raw = reader.ReadByte();
                data.Wp_HR_Augment_Critical_Bonus_2__raw = reader.ReadByte();
                data.Wp_HR_Augment_Critical_Bonus_3__raw = reader.ReadByte();
                data.Wp_HR_Augment_Defense_Bonus_1__raw = reader.ReadByte();
                data.Wp_HR_Augment_Defense_Bonus_2__raw = reader.ReadByte();
                data.Wp_HR_Augment_Defense_Bonus_3__raw = reader.ReadByte();
                data.Wp_HR_Augment_Defense_Divine_Blessing_Chance_1__raw = reader.ReadByte();
                data.Wp_HR_Augment_Defense_Divine_Blessing_Chance_2__raw = reader.ReadByte();
                data.Wp_HR_Augment_Defense_Divine_Blessing_Chance_3__raw = reader.ReadByte();
                data.Wp_HR_Augment_Defense_Divine_Blessing_Reduction_1__raw = reader.ReadSingle();
                data.Wp_HR_Augment_Defense_Divine_Blessing_Reduction_2__raw = reader.ReadSingle();
                data.Wp_HR_Augment_Defense_Divine_Blessing_Reduction_3__raw = reader.ReadSingle();
                data.Wp_HR_Augment_Defense_Heal_Damage_Rate_1__raw = reader.ReadSingle();
                data.Wp_HR_Augment_Defense_Heal_Damage_Rate_2__raw = reader.ReadSingle();
                data.Wp_HR_Augment_Defense_Heal_Damage_Rate_3__raw = reader.ReadSingle();
                data.Wp_HR_Augment_IB_Unk_raw = reader.ReadSingle();
                data.Wp_HR_Augment_Lifesteal_Cooldown_raw = reader.ReadSingle();
                data.Wp_MR_Augment_Attack_Bonus_1__raw = reader.ReadByte();
                data.Wp_MR_Augment_Attack_Bonus_2__raw = reader.ReadByte();
                data.Wp_MR_Augment_Attack_Bonus_3__raw = reader.ReadByte();
                data.Wp_MR_Augment_Attack_Bonus_4__raw = reader.ReadByte();
                data.Wp_MR_Augment_Critical_Bonus_1__raw = reader.ReadByte();
                data.Wp_MR_Augment_Critical_Bonus_2__raw = reader.ReadByte();
                data.Wp_MR_Augment_Critical_Bonus_3__raw = reader.ReadByte();
                data.Wp_MR_Augment_Critical_Bonus_4__raw = reader.ReadByte();
                data.Wp_MR_Augment_Defense_Bonus_1__raw = reader.ReadByte();
                data.Wp_MR_Augment_Defense_Bonus_2__raw = reader.ReadByte();
                data.Wp_MR_Augment_Defense_Bonus_3__raw = reader.ReadByte();
                data.Wp_MR_Augment_Defense_Bonus_4__raw = reader.ReadByte();
                data.Wp_MR_Augment_Defense_Divine_Blessing_Chance_1__raw = reader.ReadByte();
                data.Wp_MR_Augment_Defense_Divine_Blessing_Chance_2__raw = reader.ReadByte();
                data.Wp_MR_Augment_Defense_Divine_Blessing_Chance_3__raw = reader.ReadByte();
                data.Wp_MR_Augment_Defense_Divine_Blessing_Chance_4__raw = reader.ReadByte();
                data.Wp_MR_Augment_Defense_Divine_Blessing_Reduction_1__raw = reader.ReadSingle();
                data.Wp_MR_Augment_Defense_Divine_Blessing_Reduction_2__raw = reader.ReadSingle();
                data.Wp_MR_Augment_Defense_Divine_Blessing_Reduction_3__raw = reader.ReadSingle();
                data.Wp_MR_Augment_Defense_Divine_Blessing_Reduction_4__raw = reader.ReadSingle();
                data.Wp_MR_Augment_Health_Percent_1__raw = reader.ReadSingle();
                data.Wp_MR_Augment_Health_Percent_2__raw = reader.ReadSingle();
                data.Wp_MR_Augment_Health_Percent_3__raw = reader.ReadSingle();
                data.Wp_MR_Augment_Health_Percent_4__raw = reader.ReadSingle();
                data.WP_MR_Wyrmstake_Blast_Health_Regen_raw = reader.ReadSingle();
                data.Wp_MR_Augment_Lifesteal_Cooldown_raw = reader.ReadSingle();
                data.Wp_MR_Augment_Element_1__raw = reader.ReadByte();
                data.Wp_MR_Augment_Element_2__raw = reader.ReadByte();
                data.Wp_MR_Augment_Element_3__raw = reader.ReadByte();
                data.Wp_MR_Augment_Element_4__raw = reader.ReadByte();
                data.Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_1__raw = reader.ReadByte();
                data.Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_2__raw = reader.ReadByte();
                data.Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_3__raw = reader.ReadByte();
                data.Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_4__raw = reader.ReadByte();
                data.Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_1__raw = reader.ReadByte();
                data.Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_2__raw = reader.ReadByte();
                data.Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_3__raw = reader.ReadByte();
                data.Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_4__raw = reader.ReadByte();
                data.Wp_MR_Augment_Great_Sword_Elemental_Multiplier_raw = reader.ReadSingle();
                data.Wp_MR_Augment_Sword_Shield_Elemental_Multiplier_raw = reader.ReadSingle();
                data.Wp_MR_Augment_Dual_Blades_Elemental_Multiplier_raw = reader.ReadSingle();
                data.Wp_MR_Augment_Long_Sword_Elemental_Multiplier_raw = reader.ReadSingle();
                data.Wp_MR_Augment_Hammer_Elemental_Multiplier_raw = reader.ReadSingle();
                data.Wp_MR_Augment_Hunting_Horn_Elemental_Multiplier_raw = reader.ReadSingle();
                data.Wp_MR_Augment_Lance_Elemental_Multiplier_raw = reader.ReadSingle();
                data.Wp_MR_Augment_Gunlance_Elemental_Multiplier_raw = reader.ReadSingle();
                data.Wp_MR_Augment_Switch_Axe_Elemental_Multiplier_raw = reader.ReadSingle();
                data.Wp_MR_Augment_Charge_Blade_Elemental_Multiplier_raw = reader.ReadSingle();
                data.Wp_MR_Augment_Insect_Glaive_Elemental_Multiplier_raw = reader.ReadSingle();
                data.Wp_MR_Augment_Bow_Elemental_Multiplier_raw = reader.ReadSingle();
                data.Wp_MR_Augment_HBG_Elemental_Multiplier_raw = reader.ReadSingle();
                data.Wp_MR_Augment_LBG_Elemental_Multiplier_raw = reader.ReadSingle();
                data.Wp_MR_Augment_Bow_Coating_Status_Multiplier_1__raw = reader.ReadSingle();
                data.Wp_MR_Augment_Bow_Coating_Status_Multiplier_2__raw = reader.ReadSingle();
                data.Wp_MR_Augment_Bow_Coating_Status_Multiplier_3__raw = reader.ReadSingle();
                data.Wp_MR_Augment_Bow_Coating_Status_Multiplier_4__raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Wp_HR_Augment_Attack_Bonus_1__raw);
                writer.Write(Wp_HR_Augment_Attack_Bonus_2__raw);
                writer.Write(Wp_HR_Augment_Attack_Bonus_3__raw);
                writer.Write(Wp_HR_Augment_Critical_Bonus_1__raw);
                writer.Write(Wp_HR_Augment_Critical_Bonus_2__raw);
                writer.Write(Wp_HR_Augment_Critical_Bonus_3__raw);
                writer.Write(Wp_HR_Augment_Defense_Bonus_1__raw);
                writer.Write(Wp_HR_Augment_Defense_Bonus_2__raw);
                writer.Write(Wp_HR_Augment_Defense_Bonus_3__raw);
                writer.Write(Wp_HR_Augment_Defense_Divine_Blessing_Chance_1__raw);
                writer.Write(Wp_HR_Augment_Defense_Divine_Blessing_Chance_2__raw);
                writer.Write(Wp_HR_Augment_Defense_Divine_Blessing_Chance_3__raw);
                writer.Write(Wp_HR_Augment_Defense_Divine_Blessing_Reduction_1__raw);
                writer.Write(Wp_HR_Augment_Defense_Divine_Blessing_Reduction_2__raw);
                writer.Write(Wp_HR_Augment_Defense_Divine_Blessing_Reduction_3__raw);
                writer.Write(Wp_HR_Augment_Defense_Heal_Damage_Rate_1__raw);
                writer.Write(Wp_HR_Augment_Defense_Heal_Damage_Rate_2__raw);
                writer.Write(Wp_HR_Augment_Defense_Heal_Damage_Rate_3__raw);
                writer.Write(Wp_HR_Augment_IB_Unk_raw);
                writer.Write(Wp_HR_Augment_Lifesteal_Cooldown_raw);
                writer.Write(Wp_MR_Augment_Attack_Bonus_1__raw);
                writer.Write(Wp_MR_Augment_Attack_Bonus_2__raw);
                writer.Write(Wp_MR_Augment_Attack_Bonus_3__raw);
                writer.Write(Wp_MR_Augment_Attack_Bonus_4__raw);
                writer.Write(Wp_MR_Augment_Critical_Bonus_1__raw);
                writer.Write(Wp_MR_Augment_Critical_Bonus_2__raw);
                writer.Write(Wp_MR_Augment_Critical_Bonus_3__raw);
                writer.Write(Wp_MR_Augment_Critical_Bonus_4__raw);
                writer.Write(Wp_MR_Augment_Defense_Bonus_1__raw);
                writer.Write(Wp_MR_Augment_Defense_Bonus_2__raw);
                writer.Write(Wp_MR_Augment_Defense_Bonus_3__raw);
                writer.Write(Wp_MR_Augment_Defense_Bonus_4__raw);
                writer.Write(Wp_MR_Augment_Defense_Divine_Blessing_Chance_1__raw);
                writer.Write(Wp_MR_Augment_Defense_Divine_Blessing_Chance_2__raw);
                writer.Write(Wp_MR_Augment_Defense_Divine_Blessing_Chance_3__raw);
                writer.Write(Wp_MR_Augment_Defense_Divine_Blessing_Chance_4__raw);
                writer.Write(Wp_MR_Augment_Defense_Divine_Blessing_Reduction_1__raw);
                writer.Write(Wp_MR_Augment_Defense_Divine_Blessing_Reduction_2__raw);
                writer.Write(Wp_MR_Augment_Defense_Divine_Blessing_Reduction_3__raw);
                writer.Write(Wp_MR_Augment_Defense_Divine_Blessing_Reduction_4__raw);
                writer.Write(Wp_MR_Augment_Health_Percent_1__raw);
                writer.Write(Wp_MR_Augment_Health_Percent_2__raw);
                writer.Write(Wp_MR_Augment_Health_Percent_3__raw);
                writer.Write(Wp_MR_Augment_Health_Percent_4__raw);
                writer.Write(WP_MR_Wyrmstake_Blast_Health_Regen_raw);
                writer.Write(Wp_MR_Augment_Lifesteal_Cooldown_raw);
                writer.Write(Wp_MR_Augment_Element_1__raw);
                writer.Write(Wp_MR_Augment_Element_2__raw);
                writer.Write(Wp_MR_Augment_Element_3__raw);
                writer.Write(Wp_MR_Augment_Element_4__raw);
                writer.Write(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_1__raw);
                writer.Write(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_2__raw);
                writer.Write(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_3__raw);
                writer.Write(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_4__raw);
                writer.Write(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_1__raw);
                writer.Write(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_2__raw);
                writer.Write(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_3__raw);
                writer.Write(Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_4__raw);
                writer.Write(Wp_MR_Augment_Great_Sword_Elemental_Multiplier_raw);
                writer.Write(Wp_MR_Augment_Sword_Shield_Elemental_Multiplier_raw);
                writer.Write(Wp_MR_Augment_Dual_Blades_Elemental_Multiplier_raw);
                writer.Write(Wp_MR_Augment_Long_Sword_Elemental_Multiplier_raw);
                writer.Write(Wp_MR_Augment_Hammer_Elemental_Multiplier_raw);
                writer.Write(Wp_MR_Augment_Hunting_Horn_Elemental_Multiplier_raw);
                writer.Write(Wp_MR_Augment_Lance_Elemental_Multiplier_raw);
                writer.Write(Wp_MR_Augment_Gunlance_Elemental_Multiplier_raw);
                writer.Write(Wp_MR_Augment_Switch_Axe_Elemental_Multiplier_raw);
                writer.Write(Wp_MR_Augment_Charge_Blade_Elemental_Multiplier_raw);
                writer.Write(Wp_MR_Augment_Insect_Glaive_Elemental_Multiplier_raw);
                writer.Write(Wp_MR_Augment_Bow_Elemental_Multiplier_raw);
                writer.Write(Wp_MR_Augment_HBG_Elemental_Multiplier_raw);
                writer.Write(Wp_MR_Augment_LBG_Elemental_Multiplier_raw);
                writer.Write(Wp_MR_Augment_Bow_Coating_Status_Multiplier_1__raw);
                writer.Write(Wp_MR_Augment_Bow_Coating_Status_Multiplier_2__raw);
                writer.Write(Wp_MR_Augment_Bow_Coating_Status_Multiplier_3__raw);
                writer.Write(Wp_MR_Augment_Bow_Coating_Status_Multiplier_4__raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Wp HR Augment Attack Bonus (1)", "Wp_HR_Augment_Attack_Bonus_1_"),
                    new MultiStructItemCustomView(this, "Wp HR Augment Attack Bonus (2)", "Wp_HR_Augment_Attack_Bonus_2_"),
                    new MultiStructItemCustomView(this, "Wp HR Augment Attack Bonus (3)", "Wp_HR_Augment_Attack_Bonus_3_"),
                    new MultiStructItemCustomView(this, "Wp HR Augment Critical Bonus (1)", "Wp_HR_Augment_Critical_Bonus_1_"),
                    new MultiStructItemCustomView(this, "Wp HR Augment Critical Bonus (2)", "Wp_HR_Augment_Critical_Bonus_2_"),
                    new MultiStructItemCustomView(this, "Wp HR Augment Critical Bonus (3)", "Wp_HR_Augment_Critical_Bonus_3_"),
                    new MultiStructItemCustomView(this, "Wp HR Augment Defense Bonus (1)", "Wp_HR_Augment_Defense_Bonus_1_"),
                    new MultiStructItemCustomView(this, "Wp HR Augment Defense Bonus (2)", "Wp_HR_Augment_Defense_Bonus_2_"),
                    new MultiStructItemCustomView(this, "Wp HR Augment Defense Bonus (3)", "Wp_HR_Augment_Defense_Bonus_3_"),
                    new MultiStructItemCustomView(this, "Wp HR Augment Defense: Divine Blessing Chance (1)", "Wp_HR_Augment_Defense_Divine_Blessing_Chance_1_"),
                    new MultiStructItemCustomView(this, "Wp HR Augment Defense: Divine Blessing Chance (2)", "Wp_HR_Augment_Defense_Divine_Blessing_Chance_2_"),
                    new MultiStructItemCustomView(this, "Wp HR Augment Defense: Divine Blessing Chance (3)", "Wp_HR_Augment_Defense_Divine_Blessing_Chance_3_"),
                    new MultiStructItemCustomView(this, "Wp HR Augment Defense: Divine Blessing Reduction (1)", "Wp_HR_Augment_Defense_Divine_Blessing_Reduction_1_"),
                    new MultiStructItemCustomView(this, "Wp HR Augment Defense: Divine Blessing Reduction (2)", "Wp_HR_Augment_Defense_Divine_Blessing_Reduction_2_"),
                    new MultiStructItemCustomView(this, "Wp HR Augment Defense: Divine Blessing Reduction (3)", "Wp_HR_Augment_Defense_Divine_Blessing_Reduction_3_"),
                    new MultiStructItemCustomView(this, "Wp HR Augment Defense Heal Damage Rate (1)", "Wp_HR_Augment_Defense_Heal_Damage_Rate_1_"),
                    new MultiStructItemCustomView(this, "Wp HR Augment Defense Heal Damage Rate (2)", "Wp_HR_Augment_Defense_Heal_Damage_Rate_2_"),
                    new MultiStructItemCustomView(this, "Wp HR Augment Defense Heal Damage Rate (3)", "Wp_HR_Augment_Defense_Heal_Damage_Rate_3_"),
                    new MultiStructItemCustomView(this, "Wp HR Augment IB Unk", "Wp_HR_Augment_IB_Unk"),
                    new MultiStructItemCustomView(this, "Wp HR Augment Lifesteal Cooldown", "Wp_HR_Augment_Lifesteal_Cooldown"),
                    new MultiStructItemCustomView(this, "Wp MR Augment Attack Bonus (1)", "Wp_MR_Augment_Attack_Bonus_1_"),
                    new MultiStructItemCustomView(this, "Wp MR Augment Attack Bonus (2)", "Wp_MR_Augment_Attack_Bonus_2_"),
                    new MultiStructItemCustomView(this, "Wp MR Augment Attack Bonus (3)", "Wp_MR_Augment_Attack_Bonus_3_"),
                    new MultiStructItemCustomView(this, "Wp MR Augment Attack Bonus (4)", "Wp_MR_Augment_Attack_Bonus_4_"),
                    new MultiStructItemCustomView(this, "Wp MR Augment Critical Bonus (1)", "Wp_MR_Augment_Critical_Bonus_1_"),
                    new MultiStructItemCustomView(this, "Wp MR Augment Critical Bonus (2)", "Wp_MR_Augment_Critical_Bonus_2_"),
                    new MultiStructItemCustomView(this, "Wp MR Augment Critical Bonus (3)", "Wp_MR_Augment_Critical_Bonus_3_"),
                    new MultiStructItemCustomView(this, "Wp MR Augment Critical Bonus (4)", "Wp_MR_Augment_Critical_Bonus_4_"),
                    new MultiStructItemCustomView(this, "Wp MR Augment Defense Bonus (1)", "Wp_MR_Augment_Defense_Bonus_1_"),
                    new MultiStructItemCustomView(this, "Wp MR Augment Defense Bonus (2)", "Wp_MR_Augment_Defense_Bonus_2_"),
                    new MultiStructItemCustomView(this, "Wp MR Augment Defense Bonus (3)", "Wp_MR_Augment_Defense_Bonus_3_"),
                    new MultiStructItemCustomView(this, "Wp MR Augment Defense Bonus (4)", "Wp_MR_Augment_Defense_Bonus_4_"),
                    new MultiStructItemCustomView(this, "Wp MR Augment Defense: Divine Blessing Chance (1)", "Wp_MR_Augment_Defense_Divine_Blessing_Chance_1_"),
                    new MultiStructItemCustomView(this, "Wp MR Augment Defense: Divine Blessing Chance (2)", "Wp_MR_Augment_Defense_Divine_Blessing_Chance_2_"),
                    new MultiStructItemCustomView(this, "Wp MR Augment Defense: Divine Blessing Chance (3)", "Wp_MR_Augment_Defense_Divine_Blessing_Chance_3_"),
                    new MultiStructItemCustomView(this, "Wp MR Augment Defense: Divine Blessing Chance (4)", "Wp_MR_Augment_Defense_Divine_Blessing_Chance_4_"),
                    new MultiStructItemCustomView(this, "Wp MR Augment Defense: Divine Blessing Reduction (1)", "Wp_MR_Augment_Defense_Divine_Blessing_Reduction_1_"),
                    new MultiStructItemCustomView(this, "Wp MR Augment Defense: Divine Blessing Reduction (2)", "Wp_MR_Augment_Defense_Divine_Blessing_Reduction_2_"),
                    new MultiStructItemCustomView(this, "Wp MR Augment Defense: Divine Blessing Reduction (3)", "Wp_MR_Augment_Defense_Divine_Blessing_Reduction_3_"),
                    new MultiStructItemCustomView(this, "Wp MR Augment Defense: Divine Blessing Reduction (4)", "Wp_MR_Augment_Defense_Divine_Blessing_Reduction_4_"),
                    new MultiStructItemCustomView(this, "Wp MR Augment Health Percent (1)", "Wp_MR_Augment_Health_Percent_1_"),
                    new MultiStructItemCustomView(this, "Wp MR Augment Health Percent (2)", "Wp_MR_Augment_Health_Percent_2_"),
                    new MultiStructItemCustomView(this, "Wp MR Augment Health Percent (3)", "Wp_MR_Augment_Health_Percent_3_"),
                    new MultiStructItemCustomView(this, "Wp MR Augment Health Percent (4)", "Wp_MR_Augment_Health_Percent_4_"),
                    new MultiStructItemCustomView(this, "WP MR Wyrmstake Blast Health Regen", "WP_MR_Wyrmstake_Blast_Health_Regen"),
                    new MultiStructItemCustomView(this, "Wp MR Augment Lifesteal Cooldown", "Wp_MR_Augment_Lifesteal_Cooldown"),
                    new MultiStructItemCustomView(this, "Wp MR Augment Element (1)", "Wp_MR_Augment_Element_1_"),
                    new MultiStructItemCustomView(this, "Wp MR Augment Element (2)", "Wp_MR_Augment_Element_2_"),
                    new MultiStructItemCustomView(this, "Wp MR Augment Element (3)", "Wp_MR_Augment_Element_3_"),
                    new MultiStructItemCustomView(this, "Wp MR Augment Element (4)", "Wp_MR_Augment_Element_4_"),
                    new MultiStructItemCustomView(this, "Wp MR Augment Bowgun Element/Status: Ammo Element Bonus (1)", "Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_1_"),
                    new MultiStructItemCustomView(this, "Wp MR Augment Bowgun Element/Status: Ammo Element Bonus (2)", "Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_2_"),
                    new MultiStructItemCustomView(this, "Wp MR Augment Bowgun Element/Status: Ammo Element Bonus (3)", "Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_3_"),
                    new MultiStructItemCustomView(this, "Wp MR Augment Bowgun Element/Status: Ammo Element Bonus (4)", "Wp_MR_Augment_Bowgun_Element_Status_Ammo_Element_Bonus_4_"),
                    new MultiStructItemCustomView(this, "Wp MR Augment Bowgun Element/Status: Ammo Status Bonus (1)", "Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_1_"),
                    new MultiStructItemCustomView(this, "Wp MR Augment Bowgun Element/Status: Ammo Status Bonus (2)", "Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_2_"),
                    new MultiStructItemCustomView(this, "Wp MR Augment Bowgun Element/Status: Ammo Status Bonus (3)", "Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_3_"),
                    new MultiStructItemCustomView(this, "Wp MR Augment Bowgun Element/Status: Ammo Status Bonus (4)", "Wp_MR_Augment_Bowgun_Element_Status_Ammo_Status_Bonus_4_"),
                    new MultiStructItemCustomView(this, "Wp MR Augment Great Sword Elemental Multiplier", "Wp_MR_Augment_Great_Sword_Elemental_Multiplier"),
                    new MultiStructItemCustomView(this, "Wp MR Augment Sword & Shield Elemental Multiplier", "Wp_MR_Augment_Sword_Shield_Elemental_Multiplier"),
                    new MultiStructItemCustomView(this, "Wp MR Augment Dual Blades Elemental Multiplier", "Wp_MR_Augment_Dual_Blades_Elemental_Multiplier"),
                    new MultiStructItemCustomView(this, "Wp MR Augment Long Sword Elemental Multiplier", "Wp_MR_Augment_Long_Sword_Elemental_Multiplier"),
                    new MultiStructItemCustomView(this, "Wp MR Augment Hammer Elemental Multiplier", "Wp_MR_Augment_Hammer_Elemental_Multiplier"),
                    new MultiStructItemCustomView(this, "Wp MR Augment Hunting Horn Elemental Multiplier", "Wp_MR_Augment_Hunting_Horn_Elemental_Multiplier"),
                    new MultiStructItemCustomView(this, "Wp MR Augment Lance Elemental Multiplier", "Wp_MR_Augment_Lance_Elemental_Multiplier"),
                    new MultiStructItemCustomView(this, "Wp MR Augment Gunlance Elemental Multiplier", "Wp_MR_Augment_Gunlance_Elemental_Multiplier"),
                    new MultiStructItemCustomView(this, "Wp MR Augment Switch Axe Elemental Multiplier", "Wp_MR_Augment_Switch_Axe_Elemental_Multiplier"),
                    new MultiStructItemCustomView(this, "Wp MR Augment Charge Blade Elemental Multiplier", "Wp_MR_Augment_Charge_Blade_Elemental_Multiplier"),
                    new MultiStructItemCustomView(this, "Wp MR Augment Insect Glaive Elemental Multiplier", "Wp_MR_Augment_Insect_Glaive_Elemental_Multiplier"),
                    new MultiStructItemCustomView(this, "Wp MR Augment Bow Elemental Multiplier", "Wp_MR_Augment_Bow_Elemental_Multiplier"),
                    new MultiStructItemCustomView(this, "Wp MR Augment HBG Elemental Multiplier", "Wp_MR_Augment_HBG_Elemental_Multiplier"),
                    new MultiStructItemCustomView(this, "Wp MR Augment LBG Elemental Multiplier", "Wp_MR_Augment_LBG_Elemental_Multiplier"),
                    new MultiStructItemCustomView(this, "Wp MR Augment Bow Coating Status Multiplier (1)", "Wp_MR_Augment_Bow_Coating_Status_Multiplier_1_"),
                    new MultiStructItemCustomView(this, "Wp MR Augment Bow Coating Status Multiplier (2)", "Wp_MR_Augment_Bow_Coating_Status_Multiplier_2_"),
                    new MultiStructItemCustomView(this, "Wp MR Augment Bow Coating Status Multiplier (3)", "Wp_MR_Augment_Bow_Coating_Status_Multiplier_3_"),
                    new MultiStructItemCustomView(this, "Wp MR Augment Bow Coating Status Multiplier (4)", "Wp_MR_Augment_Bow_Coating_Status_Multiplier_4_"),
                };
            }
        }

        public partial class Skipping_Ahead_2_ : MhwStructItem {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Skipping Ahead (2)";

            public partial class Raw_Bytes_2_ : MhwStructItem {
                public const ulong FixedSizeCount = 590;
                public const string GridName = "Raw Bytes (2)";

                protected byte Byte_raw;
                public const string Byte_displayName = "Byte";
                public const int Byte_sortIndex = 50;
                [SortOrder(Byte_sortIndex)]
                [DisplayName(Byte_displayName)]
                public virtual byte Byte {
                    get => Byte_raw;
                    set {
                        if (Byte_raw == value) return;
                        Byte_raw = value;
                        OnPropertyChanged(nameof(Byte));
                    }
                }

                public const int lastSortIndex = 100;

                public static ObservableCollection<Raw_Bytes_2_> LoadData(BinaryReader reader, Skipping_Ahead_2_ parent) {
                    var list = new ObservableCollection<Raw_Bytes_2_>();
                    var count = 590UL;
                    for (ulong i = 0; i < count; i++) {
                        list.Add(LoadData(reader, i, parent));
                    }
                    return list;
                }

                public static Raw_Bytes_2_ LoadData(BinaryReader reader, ulong i, Skipping_Ahead_2_ parent) {
                    var data = new Raw_Bytes_2_();
                    data.Index = i;
                    data.Byte_raw = reader.ReadByte();
                    return data;
                }

                public void WriteData(BinaryWriter writer, Skipping_Ahead_2_ parent) {
                    writer.Write(Byte_raw);
                }
            }

            public const string Raw_Bytes_displayName = "Raw Bytes";
            public const int Raw_Bytes_sortIndex = 50;
            [SortOrder(Raw_Bytes_sortIndex)]
            [DisplayName(Raw_Bytes_displayName)]
            public virtual ObservableCollection<Raw_Bytes_2_> Raw_Bytes_raw { get; protected set; }

            public const int lastSortIndex = 100;

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Skipping_Ahead_2_ LoadData(BinaryReader reader, ulong i) {
                var data = new Skipping_Ahead_2_();
                data.Index = i;
                data.Raw_Bytes_raw = Raw_Bytes_2_.LoadData(reader, data);
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                foreach (var obj in Raw_Bytes_raw) {
                    obj.WriteData(writer, this);
                }
            }
        }

        public partial class Player_Params_8_Slinger_Params : MhwStructItem, IHasCustomView<MultiStructItemCustomView> {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Player Params (8) - Slinger Params";

            protected byte Max_Slinger_Capacity_Stone_raw;
            public const string Max_Slinger_Capacity_Stone_displayName = "Max Slinger Capacity: Stone";
            public const int Max_Slinger_Capacity_Stone_sortIndex = 50;
            [SortOrder(Max_Slinger_Capacity_Stone_sortIndex)]
            [DisplayName(Max_Slinger_Capacity_Stone_displayName)]
            public virtual byte Max_Slinger_Capacity_Stone {
                get => Max_Slinger_Capacity_Stone_raw;
                set {
                    if (Max_Slinger_Capacity_Stone_raw == value) return;
                    Max_Slinger_Capacity_Stone_raw = value;
                    OnPropertyChanged(nameof(Max_Slinger_Capacity_Stone));
                }
            }

            protected byte Max_Slinger_Capacity_Redpit_raw;
            public const string Max_Slinger_Capacity_Redpit_displayName = "Max Slinger Capacity: Redpit";
            public const int Max_Slinger_Capacity_Redpit_sortIndex = 100;
            [SortOrder(Max_Slinger_Capacity_Redpit_sortIndex)]
            [DisplayName(Max_Slinger_Capacity_Redpit_displayName)]
            public virtual byte Max_Slinger_Capacity_Redpit {
                get => Max_Slinger_Capacity_Redpit_raw;
                set {
                    if (Max_Slinger_Capacity_Redpit_raw == value) return;
                    Max_Slinger_Capacity_Redpit_raw = value;
                    OnPropertyChanged(nameof(Max_Slinger_Capacity_Redpit));
                }
            }

            protected byte Max_Slinger_Capacity_Brightmoss_raw;
            public const string Max_Slinger_Capacity_Brightmoss_displayName = "Max Slinger Capacity: Brightmoss";
            public const int Max_Slinger_Capacity_Brightmoss_sortIndex = 150;
            [SortOrder(Max_Slinger_Capacity_Brightmoss_sortIndex)]
            [DisplayName(Max_Slinger_Capacity_Brightmoss_displayName)]
            public virtual byte Max_Slinger_Capacity_Brightmoss {
                get => Max_Slinger_Capacity_Brightmoss_raw;
                set {
                    if (Max_Slinger_Capacity_Brightmoss_raw == value) return;
                    Max_Slinger_Capacity_Brightmoss_raw = value;
                    OnPropertyChanged(nameof(Max_Slinger_Capacity_Brightmoss));
                }
            }

            protected byte Max_Slinger_Capacity_Scatternut_raw;
            public const string Max_Slinger_Capacity_Scatternut_displayName = "Max Slinger Capacity: Scatternut";
            public const int Max_Slinger_Capacity_Scatternut_sortIndex = 200;
            [SortOrder(Max_Slinger_Capacity_Scatternut_sortIndex)]
            [DisplayName(Max_Slinger_Capacity_Scatternut_displayName)]
            public virtual byte Max_Slinger_Capacity_Scatternut {
                get => Max_Slinger_Capacity_Scatternut_raw;
                set {
                    if (Max_Slinger_Capacity_Scatternut_raw == value) return;
                    Max_Slinger_Capacity_Scatternut_raw = value;
                    OnPropertyChanged(nameof(Max_Slinger_Capacity_Scatternut));
                }
            }

            protected byte Max_Slinger_Capacity_Unk_1_raw;
            public const string Max_Slinger_Capacity_Unk_1_displayName = "Max Slinger Capacity: Unk 1";
            public const int Max_Slinger_Capacity_Unk_1_sortIndex = 250;
            [SortOrder(Max_Slinger_Capacity_Unk_1_sortIndex)]
            [DisplayName(Max_Slinger_Capacity_Unk_1_displayName)]
            public virtual byte Max_Slinger_Capacity_Unk_1 {
                get => Max_Slinger_Capacity_Unk_1_raw;
                set {
                    if (Max_Slinger_Capacity_Unk_1_raw == value) return;
                    Max_Slinger_Capacity_Unk_1_raw = value;
                    OnPropertyChanged(nameof(Max_Slinger_Capacity_Unk_1));
                }
            }

            protected byte Max_Slinger_Capacity_Unk_2_raw;
            public const string Max_Slinger_Capacity_Unk_2_displayName = "Max Slinger Capacity: Unk 2";
            public const int Max_Slinger_Capacity_Unk_2_sortIndex = 300;
            [SortOrder(Max_Slinger_Capacity_Unk_2_sortIndex)]
            [DisplayName(Max_Slinger_Capacity_Unk_2_displayName)]
            public virtual byte Max_Slinger_Capacity_Unk_2 {
                get => Max_Slinger_Capacity_Unk_2_raw;
                set {
                    if (Max_Slinger_Capacity_Unk_2_raw == value) return;
                    Max_Slinger_Capacity_Unk_2_raw = value;
                    OnPropertyChanged(nameof(Max_Slinger_Capacity_Unk_2));
                }
            }

            protected byte Max_Slinger_Capacity_Unk_3_raw;
            public const string Max_Slinger_Capacity_Unk_3_displayName = "Max Slinger Capacity: Unk 3";
            public const int Max_Slinger_Capacity_Unk_3_sortIndex = 350;
            [SortOrder(Max_Slinger_Capacity_Unk_3_sortIndex)]
            [DisplayName(Max_Slinger_Capacity_Unk_3_displayName)]
            public virtual byte Max_Slinger_Capacity_Unk_3 {
                get => Max_Slinger_Capacity_Unk_3_raw;
                set {
                    if (Max_Slinger_Capacity_Unk_3_raw == value) return;
                    Max_Slinger_Capacity_Unk_3_raw = value;
                    OnPropertyChanged(nameof(Max_Slinger_Capacity_Unk_3));
                }
            }

            protected byte Max_Slinger_Capacity_Unk_4_raw;
            public const string Max_Slinger_Capacity_Unk_4_displayName = "Max Slinger Capacity: Unk 4";
            public const int Max_Slinger_Capacity_Unk_4_sortIndex = 400;
            [SortOrder(Max_Slinger_Capacity_Unk_4_sortIndex)]
            [DisplayName(Max_Slinger_Capacity_Unk_4_displayName)]
            public virtual byte Max_Slinger_Capacity_Unk_4 {
                get => Max_Slinger_Capacity_Unk_4_raw;
                set {
                    if (Max_Slinger_Capacity_Unk_4_raw == value) return;
                    Max_Slinger_Capacity_Unk_4_raw = value;
                    OnPropertyChanged(nameof(Max_Slinger_Capacity_Unk_4));
                }
            }

            protected byte Max_Slinger_Capacity_Unk_5_raw;
            public const string Max_Slinger_Capacity_Unk_5_displayName = "Max Slinger Capacity: Unk 5";
            public const int Max_Slinger_Capacity_Unk_5_sortIndex = 450;
            [SortOrder(Max_Slinger_Capacity_Unk_5_sortIndex)]
            [DisplayName(Max_Slinger_Capacity_Unk_5_displayName)]
            public virtual byte Max_Slinger_Capacity_Unk_5 {
                get => Max_Slinger_Capacity_Unk_5_raw;
                set {
                    if (Max_Slinger_Capacity_Unk_5_raw == value) return;
                    Max_Slinger_Capacity_Unk_5_raw = value;
                    OnPropertyChanged(nameof(Max_Slinger_Capacity_Unk_5));
                }
            }

            protected byte Max_Slinger_Capacity_Torch_Pod_raw;
            public const string Max_Slinger_Capacity_Torch_Pod_displayName = "Max Slinger Capacity: Torch Pod";
            public const int Max_Slinger_Capacity_Torch_Pod_sortIndex = 500;
            [SortOrder(Max_Slinger_Capacity_Torch_Pod_sortIndex)]
            [DisplayName(Max_Slinger_Capacity_Torch_Pod_displayName)]
            public virtual byte Max_Slinger_Capacity_Torch_Pod {
                get => Max_Slinger_Capacity_Torch_Pod_raw;
                set {
                    if (Max_Slinger_Capacity_Torch_Pod_raw == value) return;
                    Max_Slinger_Capacity_Torch_Pod_raw = value;
                    OnPropertyChanged(nameof(Max_Slinger_Capacity_Torch_Pod));
                }
            }

            protected byte Max_Slinger_Capacity_Unk_6_raw;
            public const string Max_Slinger_Capacity_Unk_6_displayName = "Max Slinger Capacity: Unk 6";
            public const int Max_Slinger_Capacity_Unk_6_sortIndex = 550;
            [SortOrder(Max_Slinger_Capacity_Unk_6_sortIndex)]
            [DisplayName(Max_Slinger_Capacity_Unk_6_displayName)]
            public virtual byte Max_Slinger_Capacity_Unk_6 {
                get => Max_Slinger_Capacity_Unk_6_raw;
                set {
                    if (Max_Slinger_Capacity_Unk_6_raw == value) return;
                    Max_Slinger_Capacity_Unk_6_raw = value;
                    OnPropertyChanged(nameof(Max_Slinger_Capacity_Unk_6));
                }
            }

            protected byte Max_Slinger_Capacity_Unk_7_raw;
            public const string Max_Slinger_Capacity_Unk_7_displayName = "Max Slinger Capacity: Unk 7";
            public const int Max_Slinger_Capacity_Unk_7_sortIndex = 600;
            [SortOrder(Max_Slinger_Capacity_Unk_7_sortIndex)]
            [DisplayName(Max_Slinger_Capacity_Unk_7_displayName)]
            public virtual byte Max_Slinger_Capacity_Unk_7 {
                get => Max_Slinger_Capacity_Unk_7_raw;
                set {
                    if (Max_Slinger_Capacity_Unk_7_raw == value) return;
                    Max_Slinger_Capacity_Unk_7_raw = value;
                    OnPropertyChanged(nameof(Max_Slinger_Capacity_Unk_7));
                }
            }

            protected byte Max_Slinger_Capacity_Unk_8_raw;
            public const string Max_Slinger_Capacity_Unk_8_displayName = "Max Slinger Capacity: Unk 8";
            public const int Max_Slinger_Capacity_Unk_8_sortIndex = 650;
            [SortOrder(Max_Slinger_Capacity_Unk_8_sortIndex)]
            [DisplayName(Max_Slinger_Capacity_Unk_8_displayName)]
            public virtual byte Max_Slinger_Capacity_Unk_8 {
                get => Max_Slinger_Capacity_Unk_8_raw;
                set {
                    if (Max_Slinger_Capacity_Unk_8_raw == value) return;
                    Max_Slinger_Capacity_Unk_8_raw = value;
                    OnPropertyChanged(nameof(Max_Slinger_Capacity_Unk_8));
                }
            }

            protected byte Max_Slinger_Capacity_Unk_9_raw;
            public const string Max_Slinger_Capacity_Unk_9_displayName = "Max Slinger Capacity: Unk 9";
            public const int Max_Slinger_Capacity_Unk_9_sortIndex = 700;
            [SortOrder(Max_Slinger_Capacity_Unk_9_sortIndex)]
            [DisplayName(Max_Slinger_Capacity_Unk_9_displayName)]
            public virtual byte Max_Slinger_Capacity_Unk_9 {
                get => Max_Slinger_Capacity_Unk_9_raw;
                set {
                    if (Max_Slinger_Capacity_Unk_9_raw == value) return;
                    Max_Slinger_Capacity_Unk_9_raw = value;
                    OnPropertyChanged(nameof(Max_Slinger_Capacity_Unk_9));
                }
            }

            protected byte Max_Slinger_Capacity_Bomb_Pod_raw;
            public const string Max_Slinger_Capacity_Bomb_Pod_displayName = "Max Slinger Capacity: Bomb Pod";
            public const int Max_Slinger_Capacity_Bomb_Pod_sortIndex = 750;
            [SortOrder(Max_Slinger_Capacity_Bomb_Pod_sortIndex)]
            [DisplayName(Max_Slinger_Capacity_Bomb_Pod_displayName)]
            public virtual byte Max_Slinger_Capacity_Bomb_Pod {
                get => Max_Slinger_Capacity_Bomb_Pod_raw;
                set {
                    if (Max_Slinger_Capacity_Bomb_Pod_raw == value) return;
                    Max_Slinger_Capacity_Bomb_Pod_raw = value;
                    OnPropertyChanged(nameof(Max_Slinger_Capacity_Bomb_Pod));
                }
            }

            protected byte Max_Slinger_Capacity_Piercing_Pod_raw;
            public const string Max_Slinger_Capacity_Piercing_Pod_displayName = "Max Slinger Capacity: Piercing Pod";
            public const int Max_Slinger_Capacity_Piercing_Pod_sortIndex = 800;
            [SortOrder(Max_Slinger_Capacity_Piercing_Pod_sortIndex)]
            [DisplayName(Max_Slinger_Capacity_Piercing_Pod_displayName)]
            public virtual byte Max_Slinger_Capacity_Piercing_Pod {
                get => Max_Slinger_Capacity_Piercing_Pod_raw;
                set {
                    if (Max_Slinger_Capacity_Piercing_Pod_raw == value) return;
                    Max_Slinger_Capacity_Piercing_Pod_raw = value;
                    OnPropertyChanged(nameof(Max_Slinger_Capacity_Piercing_Pod));
                }
            }

            protected byte Max_Slinger_Capacity_Slinger_Thorn_raw;
            public const string Max_Slinger_Capacity_Slinger_Thorn_displayName = "Max Slinger Capacity: Slinger Thorn";
            public const int Max_Slinger_Capacity_Slinger_Thorn_sortIndex = 850;
            [SortOrder(Max_Slinger_Capacity_Slinger_Thorn_sortIndex)]
            [DisplayName(Max_Slinger_Capacity_Slinger_Thorn_displayName)]
            public virtual byte Max_Slinger_Capacity_Slinger_Thorn {
                get => Max_Slinger_Capacity_Slinger_Thorn_raw;
                set {
                    if (Max_Slinger_Capacity_Slinger_Thorn_raw == value) return;
                    Max_Slinger_Capacity_Slinger_Thorn_raw = value;
                    OnPropertyChanged(nameof(Max_Slinger_Capacity_Slinger_Thorn));
                }
            }

            protected byte Max_Slinger_Capacity_Dragon_Pod_raw;
            public const string Max_Slinger_Capacity_Dragon_Pod_displayName = "Max Slinger Capacity: Dragon Pod";
            public const int Max_Slinger_Capacity_Dragon_Pod_sortIndex = 900;
            [SortOrder(Max_Slinger_Capacity_Dragon_Pod_sortIndex)]
            [DisplayName(Max_Slinger_Capacity_Dragon_Pod_displayName)]
            public virtual byte Max_Slinger_Capacity_Dragon_Pod {
                get => Max_Slinger_Capacity_Dragon_Pod_raw;
                set {
                    if (Max_Slinger_Capacity_Dragon_Pod_raw == value) return;
                    Max_Slinger_Capacity_Dragon_Pod_raw = value;
                    OnPropertyChanged(nameof(Max_Slinger_Capacity_Dragon_Pod));
                }
            }

            protected byte Max_Slinger_Capacity_Unk_10_raw;
            public const string Max_Slinger_Capacity_Unk_10_displayName = "Max Slinger Capacity: Unk 10";
            public const int Max_Slinger_Capacity_Unk_10_sortIndex = 950;
            [SortOrder(Max_Slinger_Capacity_Unk_10_sortIndex)]
            [DisplayName(Max_Slinger_Capacity_Unk_10_displayName)]
            public virtual byte Max_Slinger_Capacity_Unk_10 {
                get => Max_Slinger_Capacity_Unk_10_raw;
                set {
                    if (Max_Slinger_Capacity_Unk_10_raw == value) return;
                    Max_Slinger_Capacity_Unk_10_raw = value;
                    OnPropertyChanged(nameof(Max_Slinger_Capacity_Unk_10));
                }
            }

            protected byte Max_Slinger_Capacity_Unk_11_raw;
            public const string Max_Slinger_Capacity_Unk_11_displayName = "Max Slinger Capacity: Unk 11";
            public const int Max_Slinger_Capacity_Unk_11_sortIndex = 1000;
            [SortOrder(Max_Slinger_Capacity_Unk_11_sortIndex)]
            [DisplayName(Max_Slinger_Capacity_Unk_11_displayName)]
            public virtual byte Max_Slinger_Capacity_Unk_11 {
                get => Max_Slinger_Capacity_Unk_11_raw;
                set {
                    if (Max_Slinger_Capacity_Unk_11_raw == value) return;
                    Max_Slinger_Capacity_Unk_11_raw = value;
                    OnPropertyChanged(nameof(Max_Slinger_Capacity_Unk_11));
                }
            }

            protected byte Max_Slinger_Capacity_Unk_12_raw;
            public const string Max_Slinger_Capacity_Unk_12_displayName = "Max Slinger Capacity: Unk 12";
            public const int Max_Slinger_Capacity_Unk_12_sortIndex = 1050;
            [SortOrder(Max_Slinger_Capacity_Unk_12_sortIndex)]
            [DisplayName(Max_Slinger_Capacity_Unk_12_displayName)]
            public virtual byte Max_Slinger_Capacity_Unk_12 {
                get => Max_Slinger_Capacity_Unk_12_raw;
                set {
                    if (Max_Slinger_Capacity_Unk_12_raw == value) return;
                    Max_Slinger_Capacity_Unk_12_raw = value;
                    OnPropertyChanged(nameof(Max_Slinger_Capacity_Unk_12));
                }
            }

            protected byte Max_Slinger_Capacity_Unk_13_raw;
            public const string Max_Slinger_Capacity_Unk_13_displayName = "Max Slinger Capacity: Unk 13";
            public const int Max_Slinger_Capacity_Unk_13_sortIndex = 1100;
            [SortOrder(Max_Slinger_Capacity_Unk_13_sortIndex)]
            [DisplayName(Max_Slinger_Capacity_Unk_13_displayName)]
            public virtual byte Max_Slinger_Capacity_Unk_13 {
                get => Max_Slinger_Capacity_Unk_13_raw;
                set {
                    if (Max_Slinger_Capacity_Unk_13_raw == value) return;
                    Max_Slinger_Capacity_Unk_13_raw = value;
                    OnPropertyChanged(nameof(Max_Slinger_Capacity_Unk_13));
                }
            }

            protected byte Max_Slinger_Capacity_Unk_14_raw;
            public const string Max_Slinger_Capacity_Unk_14_displayName = "Max Slinger Capacity: Unk 14";
            public const int Max_Slinger_Capacity_Unk_14_sortIndex = 1150;
            [SortOrder(Max_Slinger_Capacity_Unk_14_sortIndex)]
            [DisplayName(Max_Slinger_Capacity_Unk_14_displayName)]
            public virtual byte Max_Slinger_Capacity_Unk_14 {
                get => Max_Slinger_Capacity_Unk_14_raw;
                set {
                    if (Max_Slinger_Capacity_Unk_14_raw == value) return;
                    Max_Slinger_Capacity_Unk_14_raw = value;
                    OnPropertyChanged(nameof(Max_Slinger_Capacity_Unk_14));
                }
            }

            protected byte Max_Slinger_Capacity_Unk_15_raw;
            public const string Max_Slinger_Capacity_Unk_15_displayName = "Max Slinger Capacity: Unk 15";
            public const int Max_Slinger_Capacity_Unk_15_sortIndex = 1200;
            [SortOrder(Max_Slinger_Capacity_Unk_15_sortIndex)]
            [DisplayName(Max_Slinger_Capacity_Unk_15_displayName)]
            public virtual byte Max_Slinger_Capacity_Unk_15 {
                get => Max_Slinger_Capacity_Unk_15_raw;
                set {
                    if (Max_Slinger_Capacity_Unk_15_raw == value) return;
                    Max_Slinger_Capacity_Unk_15_raw = value;
                    OnPropertyChanged(nameof(Max_Slinger_Capacity_Unk_15));
                }
            }

            protected byte Max_Slinger_Capacity_Unk_16_raw;
            public const string Max_Slinger_Capacity_Unk_16_displayName = "Max Slinger Capacity: Unk 16";
            public const int Max_Slinger_Capacity_Unk_16_sortIndex = 1250;
            [SortOrder(Max_Slinger_Capacity_Unk_16_sortIndex)]
            [DisplayName(Max_Slinger_Capacity_Unk_16_displayName)]
            public virtual byte Max_Slinger_Capacity_Unk_16 {
                get => Max_Slinger_Capacity_Unk_16_raw;
                set {
                    if (Max_Slinger_Capacity_Unk_16_raw == value) return;
                    Max_Slinger_Capacity_Unk_16_raw = value;
                    OnPropertyChanged(nameof(Max_Slinger_Capacity_Unk_16));
                }
            }

            protected byte Max_Slinger_Capacity_Unk_17_raw;
            public const string Max_Slinger_Capacity_Unk_17_displayName = "Max Slinger Capacity: Unk 17";
            public const int Max_Slinger_Capacity_Unk_17_sortIndex = 1300;
            [SortOrder(Max_Slinger_Capacity_Unk_17_sortIndex)]
            [DisplayName(Max_Slinger_Capacity_Unk_17_displayName)]
            public virtual byte Max_Slinger_Capacity_Unk_17 {
                get => Max_Slinger_Capacity_Unk_17_raw;
                set {
                    if (Max_Slinger_Capacity_Unk_17_raw == value) return;
                    Max_Slinger_Capacity_Unk_17_raw = value;
                    OnPropertyChanged(nameof(Max_Slinger_Capacity_Unk_17));
                }
            }

            protected byte Max_Slinger_Capacity_Crystalburst_raw;
            public const string Max_Slinger_Capacity_Crystalburst_displayName = "Max Slinger Capacity: Crystalburst";
            public const int Max_Slinger_Capacity_Crystalburst_sortIndex = 1350;
            [SortOrder(Max_Slinger_Capacity_Crystalburst_sortIndex)]
            [DisplayName(Max_Slinger_Capacity_Crystalburst_displayName)]
            public virtual byte Max_Slinger_Capacity_Crystalburst {
                get => Max_Slinger_Capacity_Crystalburst_raw;
                set {
                    if (Max_Slinger_Capacity_Crystalburst_raw == value) return;
                    Max_Slinger_Capacity_Crystalburst_raw = value;
                    OnPropertyChanged(nameof(Max_Slinger_Capacity_Crystalburst));
                }
            }

            protected byte Max_Slinger_Capacity_Puddle_Pod_raw;
            public const string Max_Slinger_Capacity_Puddle_Pod_displayName = "Max Slinger Capacity: Puddle Pod";
            public const int Max_Slinger_Capacity_Puddle_Pod_sortIndex = 1400;
            [SortOrder(Max_Slinger_Capacity_Puddle_Pod_sortIndex)]
            [DisplayName(Max_Slinger_Capacity_Puddle_Pod_displayName)]
            public virtual byte Max_Slinger_Capacity_Puddle_Pod {
                get => Max_Slinger_Capacity_Puddle_Pod_raw;
                set {
                    if (Max_Slinger_Capacity_Puddle_Pod_raw == value) return;
                    Max_Slinger_Capacity_Puddle_Pod_raw = value;
                    OnPropertyChanged(nameof(Max_Slinger_Capacity_Puddle_Pod));
                }
            }

            protected byte Max_Slinger_Capacity_Unk_18_raw;
            public const string Max_Slinger_Capacity_Unk_18_displayName = "Max Slinger Capacity: Unk 18";
            public const int Max_Slinger_Capacity_Unk_18_sortIndex = 1450;
            [SortOrder(Max_Slinger_Capacity_Unk_18_sortIndex)]
            [DisplayName(Max_Slinger_Capacity_Unk_18_displayName)]
            public virtual byte Max_Slinger_Capacity_Unk_18 {
                get => Max_Slinger_Capacity_Unk_18_raw;
                set {
                    if (Max_Slinger_Capacity_Unk_18_raw == value) return;
                    Max_Slinger_Capacity_Unk_18_raw = value;
                    OnPropertyChanged(nameof(Max_Slinger_Capacity_Unk_18));
                }
            }

            protected byte Max_Slinger_Capacity_Unk_19_raw;
            public const string Max_Slinger_Capacity_Unk_19_displayName = "Max Slinger Capacity: Unk 19";
            public const int Max_Slinger_Capacity_Unk_19_sortIndex = 1500;
            [SortOrder(Max_Slinger_Capacity_Unk_19_sortIndex)]
            [DisplayName(Max_Slinger_Capacity_Unk_19_displayName)]
            public virtual byte Max_Slinger_Capacity_Unk_19 {
                get => Max_Slinger_Capacity_Unk_19_raw;
                set {
                    if (Max_Slinger_Capacity_Unk_19_raw == value) return;
                    Max_Slinger_Capacity_Unk_19_raw = value;
                    OnPropertyChanged(nameof(Max_Slinger_Capacity_Unk_19));
                }
            }

            protected byte Max_Slinger_Capacity_Unk_20_raw;
            public const string Max_Slinger_Capacity_Unk_20_displayName = "Max Slinger Capacity: Unk 20";
            public const int Max_Slinger_Capacity_Unk_20_sortIndex = 1550;
            [SortOrder(Max_Slinger_Capacity_Unk_20_sortIndex)]
            [DisplayName(Max_Slinger_Capacity_Unk_20_displayName)]
            public virtual byte Max_Slinger_Capacity_Unk_20 {
                get => Max_Slinger_Capacity_Unk_20_raw;
                set {
                    if (Max_Slinger_Capacity_Unk_20_raw == value) return;
                    Max_Slinger_Capacity_Unk_20_raw = value;
                    OnPropertyChanged(nameof(Max_Slinger_Capacity_Unk_20));
                }
            }

            public const int lastSortIndex = 1600;

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Player_Params_8_Slinger_Params LoadData(BinaryReader reader, ulong i) {
                var data = new Player_Params_8_Slinger_Params();
                data.Index = i;
                data.Max_Slinger_Capacity_Stone_raw = reader.ReadByte();
                data.Max_Slinger_Capacity_Redpit_raw = reader.ReadByte();
                data.Max_Slinger_Capacity_Brightmoss_raw = reader.ReadByte();
                data.Max_Slinger_Capacity_Scatternut_raw = reader.ReadByte();
                data.Max_Slinger_Capacity_Unk_1_raw = reader.ReadByte();
                data.Max_Slinger_Capacity_Unk_2_raw = reader.ReadByte();
                data.Max_Slinger_Capacity_Unk_3_raw = reader.ReadByte();
                data.Max_Slinger_Capacity_Unk_4_raw = reader.ReadByte();
                data.Max_Slinger_Capacity_Unk_5_raw = reader.ReadByte();
                data.Max_Slinger_Capacity_Torch_Pod_raw = reader.ReadByte();
                data.Max_Slinger_Capacity_Unk_6_raw = reader.ReadByte();
                data.Max_Slinger_Capacity_Unk_7_raw = reader.ReadByte();
                data.Max_Slinger_Capacity_Unk_8_raw = reader.ReadByte();
                data.Max_Slinger_Capacity_Unk_9_raw = reader.ReadByte();
                data.Max_Slinger_Capacity_Bomb_Pod_raw = reader.ReadByte();
                data.Max_Slinger_Capacity_Piercing_Pod_raw = reader.ReadByte();
                data.Max_Slinger_Capacity_Slinger_Thorn_raw = reader.ReadByte();
                data.Max_Slinger_Capacity_Dragon_Pod_raw = reader.ReadByte();
                data.Max_Slinger_Capacity_Unk_10_raw = reader.ReadByte();
                data.Max_Slinger_Capacity_Unk_11_raw = reader.ReadByte();
                data.Max_Slinger_Capacity_Unk_12_raw = reader.ReadByte();
                data.Max_Slinger_Capacity_Unk_13_raw = reader.ReadByte();
                data.Max_Slinger_Capacity_Unk_14_raw = reader.ReadByte();
                data.Max_Slinger_Capacity_Unk_15_raw = reader.ReadByte();
                data.Max_Slinger_Capacity_Unk_16_raw = reader.ReadByte();
                data.Max_Slinger_Capacity_Unk_17_raw = reader.ReadByte();
                data.Max_Slinger_Capacity_Crystalburst_raw = reader.ReadByte();
                data.Max_Slinger_Capacity_Puddle_Pod_raw = reader.ReadByte();
                data.Max_Slinger_Capacity_Unk_18_raw = reader.ReadByte();
                data.Max_Slinger_Capacity_Unk_19_raw = reader.ReadByte();
                data.Max_Slinger_Capacity_Unk_20_raw = reader.ReadByte();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Max_Slinger_Capacity_Stone_raw);
                writer.Write(Max_Slinger_Capacity_Redpit_raw);
                writer.Write(Max_Slinger_Capacity_Brightmoss_raw);
                writer.Write(Max_Slinger_Capacity_Scatternut_raw);
                writer.Write(Max_Slinger_Capacity_Unk_1_raw);
                writer.Write(Max_Slinger_Capacity_Unk_2_raw);
                writer.Write(Max_Slinger_Capacity_Unk_3_raw);
                writer.Write(Max_Slinger_Capacity_Unk_4_raw);
                writer.Write(Max_Slinger_Capacity_Unk_5_raw);
                writer.Write(Max_Slinger_Capacity_Torch_Pod_raw);
                writer.Write(Max_Slinger_Capacity_Unk_6_raw);
                writer.Write(Max_Slinger_Capacity_Unk_7_raw);
                writer.Write(Max_Slinger_Capacity_Unk_8_raw);
                writer.Write(Max_Slinger_Capacity_Unk_9_raw);
                writer.Write(Max_Slinger_Capacity_Bomb_Pod_raw);
                writer.Write(Max_Slinger_Capacity_Piercing_Pod_raw);
                writer.Write(Max_Slinger_Capacity_Slinger_Thorn_raw);
                writer.Write(Max_Slinger_Capacity_Dragon_Pod_raw);
                writer.Write(Max_Slinger_Capacity_Unk_10_raw);
                writer.Write(Max_Slinger_Capacity_Unk_11_raw);
                writer.Write(Max_Slinger_Capacity_Unk_12_raw);
                writer.Write(Max_Slinger_Capacity_Unk_13_raw);
                writer.Write(Max_Slinger_Capacity_Unk_14_raw);
                writer.Write(Max_Slinger_Capacity_Unk_15_raw);
                writer.Write(Max_Slinger_Capacity_Unk_16_raw);
                writer.Write(Max_Slinger_Capacity_Unk_17_raw);
                writer.Write(Max_Slinger_Capacity_Crystalburst_raw);
                writer.Write(Max_Slinger_Capacity_Puddle_Pod_raw);
                writer.Write(Max_Slinger_Capacity_Unk_18_raw);
                writer.Write(Max_Slinger_Capacity_Unk_19_raw);
                writer.Write(Max_Slinger_Capacity_Unk_20_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Max Slinger Capacity: Stone", "Max_Slinger_Capacity_Stone"),
                    new MultiStructItemCustomView(this, "Max Slinger Capacity: Redpit", "Max_Slinger_Capacity_Redpit"),
                    new MultiStructItemCustomView(this, "Max Slinger Capacity: Brightmoss", "Max_Slinger_Capacity_Brightmoss"),
                    new MultiStructItemCustomView(this, "Max Slinger Capacity: Scatternut", "Max_Slinger_Capacity_Scatternut"),
                    new MultiStructItemCustomView(this, "Max Slinger Capacity: Unk 1", "Max_Slinger_Capacity_Unk_1"),
                    new MultiStructItemCustomView(this, "Max Slinger Capacity: Unk 2", "Max_Slinger_Capacity_Unk_2"),
                    new MultiStructItemCustomView(this, "Max Slinger Capacity: Unk 3", "Max_Slinger_Capacity_Unk_3"),
                    new MultiStructItemCustomView(this, "Max Slinger Capacity: Unk 4", "Max_Slinger_Capacity_Unk_4"),
                    new MultiStructItemCustomView(this, "Max Slinger Capacity: Unk 5", "Max_Slinger_Capacity_Unk_5"),
                    new MultiStructItemCustomView(this, "Max Slinger Capacity: Torch Pod", "Max_Slinger_Capacity_Torch_Pod"),
                    new MultiStructItemCustomView(this, "Max Slinger Capacity: Unk 6", "Max_Slinger_Capacity_Unk_6"),
                    new MultiStructItemCustomView(this, "Max Slinger Capacity: Unk 7", "Max_Slinger_Capacity_Unk_7"),
                    new MultiStructItemCustomView(this, "Max Slinger Capacity: Unk 8", "Max_Slinger_Capacity_Unk_8"),
                    new MultiStructItemCustomView(this, "Max Slinger Capacity: Unk 9", "Max_Slinger_Capacity_Unk_9"),
                    new MultiStructItemCustomView(this, "Max Slinger Capacity: Bomb Pod", "Max_Slinger_Capacity_Bomb_Pod"),
                    new MultiStructItemCustomView(this, "Max Slinger Capacity: Piercing Pod", "Max_Slinger_Capacity_Piercing_Pod"),
                    new MultiStructItemCustomView(this, "Max Slinger Capacity: Slinger Thorn", "Max_Slinger_Capacity_Slinger_Thorn"),
                    new MultiStructItemCustomView(this, "Max Slinger Capacity: Dragon Pod", "Max_Slinger_Capacity_Dragon_Pod"),
                    new MultiStructItemCustomView(this, "Max Slinger Capacity: Unk 10", "Max_Slinger_Capacity_Unk_10"),
                    new MultiStructItemCustomView(this, "Max Slinger Capacity: Unk 11", "Max_Slinger_Capacity_Unk_11"),
                    new MultiStructItemCustomView(this, "Max Slinger Capacity: Unk 12", "Max_Slinger_Capacity_Unk_12"),
                    new MultiStructItemCustomView(this, "Max Slinger Capacity: Unk 13", "Max_Slinger_Capacity_Unk_13"),
                    new MultiStructItemCustomView(this, "Max Slinger Capacity: Unk 14", "Max_Slinger_Capacity_Unk_14"),
                    new MultiStructItemCustomView(this, "Max Slinger Capacity: Unk 15", "Max_Slinger_Capacity_Unk_15"),
                    new MultiStructItemCustomView(this, "Max Slinger Capacity: Unk 16", "Max_Slinger_Capacity_Unk_16"),
                    new MultiStructItemCustomView(this, "Max Slinger Capacity: Unk 17", "Max_Slinger_Capacity_Unk_17"),
                    new MultiStructItemCustomView(this, "Max Slinger Capacity: Crystalburst", "Max_Slinger_Capacity_Crystalburst"),
                    new MultiStructItemCustomView(this, "Max Slinger Capacity: Puddle Pod", "Max_Slinger_Capacity_Puddle_Pod"),
                    new MultiStructItemCustomView(this, "Max Slinger Capacity: Unk 18", "Max_Slinger_Capacity_Unk_18"),
                    new MultiStructItemCustomView(this, "Max Slinger Capacity: Unk 19", "Max_Slinger_Capacity_Unk_19"),
                    new MultiStructItemCustomView(this, "Max Slinger Capacity: Unk 20", "Max_Slinger_Capacity_Unk_20"),
                };
            }
        }

        public partial class The_Rest : MhwStructItem {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "The Rest";

            public partial class End_Junk : MhwStructItem {
                public const ulong FixedSizeCount = 0;
                public const string GridName = "End Junk";

                protected byte Unk_raw;
                public const string Unk_displayName = "Unk";
                public const int Unk_sortIndex = 50;
                [SortOrder(Unk_sortIndex)]
                [DisplayName(Unk_displayName)]
                [IsReadOnly]
                public virtual byte Unk {
                    get => Unk_raw;
                    set {
                        if (Unk_raw == value) return;
                        Unk_raw = value;
                        OnPropertyChanged(nameof(Unk));
                    }
                }

                public const int lastSortIndex = 100;

                public void WriteData(BinaryWriter writer, The_Rest parent) {
                    writer.Write(Unk_raw);
                }
            }

            public const string The_rest_of_the_file_as_bytes__displayName = "The rest of the file as bytes.";
            public const int The_rest_of_the_file_as_bytes__sortIndex = 50;
            [SortOrder(The_rest_of_the_file_as_bytes__sortIndex)]
            [DisplayName(The_rest_of_the_file_as_bytes__displayName)]
            public virtual ObservableCollection<End_Junk> The_rest_of_the_file_as_bytes__raw { get; protected set; }

            public const int lastSortIndex = 100;

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static The_Rest LoadData(BinaryReader reader, ulong i) {
                var data = new The_Rest();
                data.Index = i;
                data.The_rest_of_the_file_as_bytes__raw = End_Junk.LoadData(reader, data);
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                foreach (var obj in The_rest_of_the_file_as_bytes__raw) {
                    obj.WriteData(writer, this);
                }
            }
        }

        public override void LoadFile(string targetFile) {
            using var reader = new BinaryReader(OpenFile(targetFile, EncryptionKey), Encoding.UTF8);
            data = new LinkedList<MhwStructDataContainer>();
            var Header_ = new MhwStructDataContainer(Header.LoadData(reader, null), typeof(Header));
            data.AddLast(Header_);
            var Player_Params_1__ = new MhwStructDataContainer(Player_Params_1_.LoadData(reader, null), typeof(Player_Params_1_));
            data.AddLast(Player_Params_1__);
            var Player_Params_2_Unk_Array_1__ = new MhwStructDataContainer(Player_Params_2_Unk_Array_1_.LoadData(reader, null), typeof(Player_Params_2_Unk_Array_1_));
            data.AddLast(Player_Params_2_Unk_Array_1__);
            var Player_Params_3__ = new MhwStructDataContainer(Player_Params_3_.LoadData(reader, null), typeof(Player_Params_3_));
            data.AddLast(Player_Params_3__);
            var CD_Block_1__ = new MhwStructDataContainer(CD_Block_1_.LoadData(reader, null), typeof(CD_Block_1_));
            data.AddLast(CD_Block_1__);
            var Player_Params_4__ = new MhwStructDataContainer(Player_Params_4_.LoadData(reader, null), typeof(Player_Params_4_));
            data.AddLast(Player_Params_4__);
            var Player_Params_5_Dodge_IFrames_ = new MhwStructDataContainer(Player_Params_5_Dodge_IFrames.LoadData(reader, null), typeof(Player_Params_5_Dodge_IFrames));
            data.AddLast(Player_Params_5_Dodge_IFrames_);
            var Player_Params_6_Evade_Distance_ = new MhwStructDataContainer(Player_Params_6_Evade_Distance.LoadData(reader, null), typeof(Player_Params_6_Evade_Distance));
            data.AddLast(Player_Params_6_Evade_Distance_);
            var Skipping_Ahead_1__ = new MhwStructDataContainer(Skipping_Ahead_1_.LoadData(reader, null), typeof(Skipping_Ahead_1_));
            data.AddLast(Skipping_Ahead_1__);
            var Player_Params_7_HR_MR_Augment_Params_ = new MhwStructDataContainer(Player_Params_7_HR_MR_Augment_Params.LoadData(reader, null), typeof(Player_Params_7_HR_MR_Augment_Params));
            data.AddLast(Player_Params_7_HR_MR_Augment_Params_);
            var Skipping_Ahead_2__ = new MhwStructDataContainer(Skipping_Ahead_2_.LoadData(reader, null), typeof(Skipping_Ahead_2_));
            data.AddLast(Skipping_Ahead_2__);
            var Player_Params_8_Slinger_Params_ = new MhwStructDataContainer(Player_Params_8_Slinger_Params.LoadData(reader, null), typeof(Player_Params_8_Slinger_Params));
            data.AddLast(Player_Params_8_Slinger_Params_);
            var The_Rest_ = new MhwStructDataContainer(The_Rest.LoadData(reader, null), typeof(The_Rest));
            data.AddLast(The_Rest_);
        }
    }
}
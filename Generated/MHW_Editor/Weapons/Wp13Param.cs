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

namespace MHW_Editor.Weapons {
    public partial class Wp13Param {
        public override string EncryptionKey => "j1P15gEkgVa7NdFxiqwCPitykHctY2nZPjSaElvqb0eSwcLO1cOlTqqv";

        public partial class W13p_Params_1_Shared_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView> {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W13p Params (1, Shared)";

            protected char[] Weapon_raw;
            public const string Weapon_displayName = "Weapon";
            public const int Weapon_sortIndex = 50;
            [SortOrder(Weapon_sortIndex)]
            [DisplayName(Weapon_displayName)]
            [IsReadOnly]
            public virtual string Weapon {
                get => (string) new string(Weapon_raw);
                set {
                    if ((string) new string(Weapon_raw) == value) return;
                    Weapon_raw = (char[]) value.ToCharArray(0, 3);
                    OnPropertyChanged(nameof(Weapon));
                }
            }

            protected uint Unk_1_raw;
            public const string Unk_1_displayName = "Unk 1";
            public const int Unk_1_sortIndex = 100;
            [SortOrder(Unk_1_sortIndex)]
            [DisplayName(Unk_1_displayName)]
            public virtual uint Unk_1 {
                get => Unk_1_raw;
                set {
                    if (Unk_1_raw == value) return;
                    Unk_1_raw = value;
                    OnPropertyChanged(nameof(Unk_1));
                }
            }

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W13p_Params_1_Shared_ LoadData(BinaryReader reader, ulong i) {
                var data = new W13p_Params_1_Shared_();
                data.Index = i;
                data.Weapon_raw = reader.ReadChars(4);
                data.Unk_1_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Weapon_raw);
                writer.Write(Unk_1_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Weapon", "Weapon"),
                    new MultiStructItemCustomView(this, "Unk 1", "Unk_1"),
                };
            }
        }

        public partial class Unk_Arr_1_Shared_ : MhwStructItem {
            public const ulong FixedSizeCount = 20;
            public const string GridName = "Unk Arr 1 (Shared)";

            protected float Unk_1_raw;
            public const string Unk_1_displayName = "Unk 1";
            public const int Unk_1_sortIndex = 50;
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
            public const int Unk_2_sortIndex = 100;
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
            public const int Unk_3_sortIndex = 150;
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

            protected byte Unk_4_raw;
            public const string Unk_4_displayName = "Unk 4";
            public const int Unk_4_sortIndex = 200;
            [SortOrder(Unk_4_sortIndex)]
            [DisplayName(Unk_4_displayName)]
            public virtual bool Unk_4 {
                get => (bool) Convert.ToBoolean(Unk_4_raw);
                set {
                    if (Convert.ToBoolean(Unk_4_raw) == value) return;
                    Unk_4_raw = Convert.ToByte(value);
                    OnPropertyChanged(nameof(Unk_4));
                }
            }

            protected float Unk_5_raw;
            public const string Unk_5_displayName = "Unk 5";
            public const int Unk_5_sortIndex = 250;
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

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
                var count = 20UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Unk_Arr_1_Shared_ LoadData(BinaryReader reader, ulong i) {
                var data = new Unk_Arr_1_Shared_();
                data.Index = i;
                data.Unk_1_raw = reader.ReadSingle();
                data.Unk_2_raw = reader.ReadSingle();
                data.Unk_3_raw = reader.ReadSingle();
                data.Unk_4_raw = reader.ReadByte();
                data.Unk_5_raw = reader.ReadSingle();
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

        public partial class W13p_Params_2_Shared_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView> {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W13p Params (2, Shared)";

            protected float Unk_2_raw;
            public const string Unk_2_displayName = "Unk 2";
            public const int Unk_2_sortIndex = 50;
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
            public const int Unk_3_sortIndex = 100;
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
            public const int Unk_4_sortIndex = 150;
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
            public const int Unk_5_sortIndex = 200;
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
            public const int Unk_6_sortIndex = 250;
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
            public const int Unk_7_sortIndex = 300;
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
            public const int Unk_8_sortIndex = 350;
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
            public const int Unk_9_sortIndex = 400;
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
            public const int Unk_10_sortIndex = 450;
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
            public const int Unk_11_sortIndex = 500;
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
            public const int Unk_12_sortIndex = 550;
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
            public const int Unk_13_sortIndex = 600;
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
            public const int Unk_14_sortIndex = 650;
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
            public const int Unk_15_sortIndex = 700;
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
            public const int Unk_16_sortIndex = 750;
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
            public const int Unk_17_sortIndex = 800;
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

            protected byte Unk_18_raw;
            public const string Unk_18_displayName = "Unk 18";
            public const int Unk_18_sortIndex = 850;
            [SortOrder(Unk_18_sortIndex)]
            [DisplayName(Unk_18_displayName)]
            public virtual byte Unk_18 {
                get => Unk_18_raw;
                set {
                    if (Unk_18_raw == value) return;
                    Unk_18_raw = value;
                    OnPropertyChanged(nameof(Unk_18));
                }
            }

            protected byte Unk_19_raw;
            public const string Unk_19_displayName = "Unk 19";
            public const int Unk_19_sortIndex = 900;
            [SortOrder(Unk_19_sortIndex)]
            [DisplayName(Unk_19_displayName)]
            public virtual byte Unk_19 {
                get => Unk_19_raw;
                set {
                    if (Unk_19_raw == value) return;
                    Unk_19_raw = value;
                    OnPropertyChanged(nameof(Unk_19));
                }
            }

            protected byte Unk_20_raw;
            public const string Unk_20_displayName = "Unk 20";
            public const int Unk_20_sortIndex = 950;
            [SortOrder(Unk_20_sortIndex)]
            [DisplayName(Unk_20_displayName)]
            public virtual byte Unk_20 {
                get => Unk_20_raw;
                set {
                    if (Unk_20_raw == value) return;
                    Unk_20_raw = value;
                    OnPropertyChanged(nameof(Unk_20));
                }
            }

            protected byte Unk_21_raw;
            public const string Unk_21_displayName = "Unk 21";
            public const int Unk_21_sortIndex = 1000;
            [SortOrder(Unk_21_sortIndex)]
            [DisplayName(Unk_21_displayName)]
            public virtual byte Unk_21 {
                get => Unk_21_raw;
                set {
                    if (Unk_21_raw == value) return;
                    Unk_21_raw = value;
                    OnPropertyChanged(nameof(Unk_21));
                }
            }

            protected float Weapon_Sweet_spot_raw;
            public const string Weapon_Sweet_spot_displayName = "Weapon Sweet-spot";
            public const int Weapon_Sweet_spot_sortIndex = 1050;
            [SortOrder(Weapon_Sweet_spot_sortIndex)]
            [DisplayName(Weapon_Sweet_spot_displayName)]
            public virtual float Weapon_Sweet_spot {
                get => Weapon_Sweet_spot_raw;
                set {
                    if (Weapon_Sweet_spot_raw == value) return;
                    Weapon_Sweet_spot_raw = value;
                    OnPropertyChanged(nameof(Weapon_Sweet_spot));
                }
            }

            protected float Unk_23_raw;
            public const string Unk_23_displayName = "Unk 23";
            public const int Unk_23_sortIndex = 1100;
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
            public const int Unk_24_sortIndex = 1150;
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

            protected float Elderseal_Modifier__raw;
            public const string Elderseal_Modifier__displayName = "Elderseal Modifier?";
            public const int Elderseal_Modifier__sortIndex = 1200;
            [SortOrder(Elderseal_Modifier__sortIndex)]
            [DisplayName(Elderseal_Modifier__displayName)]
            public virtual float Elderseal_Modifier_ {
                get => Elderseal_Modifier__raw;
                set {
                    if (Elderseal_Modifier__raw == value) return;
                    Elderseal_Modifier__raw = value;
                    OnPropertyChanged(nameof(Elderseal_Modifier_));
                }
            }

            protected byte Unk_26_raw;
            public const string Unk_26_displayName = "Unk 26";
            public const int Unk_26_sortIndex = 1250;
            [SortOrder(Unk_26_sortIndex)]
            [DisplayName(Unk_26_displayName)]
            public virtual byte Unk_26 {
                get => Unk_26_raw;
                set {
                    if (Unk_26_raw == value) return;
                    Unk_26_raw = value;
                    OnPropertyChanged(nameof(Unk_26));
                }
            }

            protected float Unk_27_raw;
            public const string Unk_27_displayName = "Unk 27";
            public const int Unk_27_sortIndex = 1300;
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

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W13p_Params_2_Shared_ LoadData(BinaryReader reader, ulong i) {
                var data = new W13p_Params_2_Shared_();
                data.Index = i;
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
                data.Unk_18_raw = reader.ReadByte();
                data.Unk_19_raw = reader.ReadByte();
                data.Unk_20_raw = reader.ReadByte();
                data.Unk_21_raw = reader.ReadByte();
                data.Weapon_Sweet_spot_raw = reader.ReadSingle();
                data.Unk_23_raw = reader.ReadSingle();
                data.Unk_24_raw = reader.ReadSingle();
                data.Elderseal_Modifier__raw = reader.ReadSingle();
                data.Unk_26_raw = reader.ReadByte();
                data.Unk_27_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
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
                writer.Write(Weapon_Sweet_spot_raw);
                writer.Write(Unk_23_raw);
                writer.Write(Unk_24_raw);
                writer.Write(Elderseal_Modifier__raw);
                writer.Write(Unk_26_raw);
                writer.Write(Unk_27_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
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
                    new MultiStructItemCustomView(this, "Weapon Sweet-spot", "Weapon_Sweet_spot"),
                    new MultiStructItemCustomView(this, "Unk 23", "Unk_23"),
                    new MultiStructItemCustomView(this, "Unk 24", "Unk_24"),
                    new MultiStructItemCustomView(this, "Elderseal Modifier?", "Elderseal_Modifier_"),
                    new MultiStructItemCustomView(this, "Unk 26", "Unk_26"),
                    new MultiStructItemCustomView(this, "Unk 27", "Unk_27"),
                };
            }
        }

        public partial class Guard_Angles_Shared_ : MhwStructItem {
            public const ulong FixedSizeCount = 2;
            public const string GridName = "Guard Angles (Shared)";

            protected float Guard_Angle_Both_Sides__raw;
            public const string Guard_Angle_Both_Sides__displayName = "Guard Angle (Both Sides)";
            public const int Guard_Angle_Both_Sides__sortIndex = 50;
            [SortOrder(Guard_Angle_Both_Sides__sortIndex)]
            [DisplayName(Guard_Angle_Both_Sides__displayName)]
            public virtual float Guard_Angle_Both_Sides_ {
                get => Guard_Angle_Both_Sides__raw;
                set {
                    if (Guard_Angle_Both_Sides__raw == value) return;
                    Guard_Angle_Both_Sides__raw = value;
                    OnPropertyChanged(nameof(Guard_Angle_Both_Sides_));
                }
            }

            protected byte Knockback_Threshold_Small_raw;
            public const string Knockback_Threshold_Small_displayName = "Knockback Threshold Small";
            public const int Knockback_Threshold_Small_sortIndex = 100;
            [SortOrder(Knockback_Threshold_Small_sortIndex)]
            [DisplayName(Knockback_Threshold_Small_displayName)]
            public virtual byte Knockback_Threshold_Small {
                get => Knockback_Threshold_Small_raw;
                set {
                    if (Knockback_Threshold_Small_raw == value) return;
                    Knockback_Threshold_Small_raw = value;
                    OnPropertyChanged(nameof(Knockback_Threshold_Small));
                }
            }

            protected byte Knockback_Threshold_Medium_raw;
            public const string Knockback_Threshold_Medium_displayName = "Knockback Threshold Medium";
            public const int Knockback_Threshold_Medium_sortIndex = 150;
            [SortOrder(Knockback_Threshold_Medium_sortIndex)]
            [DisplayName(Knockback_Threshold_Medium_displayName)]
            public virtual byte Knockback_Threshold_Medium {
                get => Knockback_Threshold_Medium_raw;
                set {
                    if (Knockback_Threshold_Medium_raw == value) return;
                    Knockback_Threshold_Medium_raw = value;
                    OnPropertyChanged(nameof(Knockback_Threshold_Medium));
                }
            }

            protected byte Knockback_Threshold_Large_raw;
            public const string Knockback_Threshold_Large_displayName = "Knockback Threshold Large";
            public const int Knockback_Threshold_Large_sortIndex = 200;
            [SortOrder(Knockback_Threshold_Large_sortIndex)]
            [DisplayName(Knockback_Threshold_Large_displayName)]
            public virtual byte Knockback_Threshold_Large {
                get => Knockback_Threshold_Large_raw;
                set {
                    if (Knockback_Threshold_Large_raw == value) return;
                    Knockback_Threshold_Large_raw = value;
                    OnPropertyChanged(nameof(Knockback_Threshold_Large));
                }
            }

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
                var count = 2UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Guard_Angles_Shared_ LoadData(BinaryReader reader, ulong i) {
                var data = new Guard_Angles_Shared_();
                data.Index = i;
                data.Guard_Angle_Both_Sides__raw = reader.ReadSingle();
                data.Knockback_Threshold_Small_raw = reader.ReadByte();
                data.Knockback_Threshold_Medium_raw = reader.ReadByte();
                data.Knockback_Threshold_Large_raw = reader.ReadByte();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Guard_Angle_Both_Sides__raw);
                writer.Write(Knockback_Threshold_Small_raw);
                writer.Write(Knockback_Threshold_Medium_raw);
                writer.Write(Knockback_Threshold_Large_raw);
            }
        }

        public partial class W13p_Params_3_Shared_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView> {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W13p Params (3, Shared)";

            protected float Unk_28_raw;
            public const string Unk_28_displayName = "Unk 28";
            public const int Unk_28_sortIndex = 50;
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
            public const int Unk_29_sortIndex = 100;
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
            public const int Unk_30_sortIndex = 150;
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
            public const int Unk_31_sortIndex = 200;
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
            public const int Unk_32_sortIndex = 250;
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
            public const int Unk_33_sortIndex = 300;
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
            public const int Unk_34_sortIndex = 350;
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

            protected float Unk_35_raw;
            public const string Unk_35_displayName = "Unk 35";
            public const int Unk_35_sortIndex = 400;
            [SortOrder(Unk_35_sortIndex)]
            [DisplayName(Unk_35_displayName)]
            public virtual float Unk_35 {
                get => Unk_35_raw;
                set {
                    if (Unk_35_raw == value) return;
                    Unk_35_raw = value;
                    OnPropertyChanged(nameof(Unk_35));
                }
            }

            protected float Unk_36_raw;
            public const string Unk_36_displayName = "Unk 36";
            public const int Unk_36_sortIndex = 450;
            [SortOrder(Unk_36_sortIndex)]
            [DisplayName(Unk_36_displayName)]
            public virtual float Unk_36 {
                get => Unk_36_raw;
                set {
                    if (Unk_36_raw == value) return;
                    Unk_36_raw = value;
                    OnPropertyChanged(nameof(Unk_36));
                }
            }

            protected float Unk_37_raw;
            public const string Unk_37_displayName = "Unk 37";
            public const int Unk_37_sortIndex = 500;
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
            public const int Unk_38_sortIndex = 550;
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
            public const int Unk_39_sortIndex = 600;
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
            public const int Unk_40_sortIndex = 650;
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
            public const int Unk_41_sortIndex = 700;
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
            public const int Unk_42_sortIndex = 750;
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
            public const int Unk_43_sortIndex = 800;
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
            public const int Unk_44_sortIndex = 850;
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
            public const int Unk_45_sortIndex = 900;
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
            public const int Unk_46_sortIndex = 950;
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
            public const int Unk_47_sortIndex = 1000;
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
            public const int Unk_48_sortIndex = 1050;
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

            protected uint Unk_49_raw;
            public const string Unk_49_displayName = "Unk 49";
            public const int Unk_49_sortIndex = 1100;
            [SortOrder(Unk_49_sortIndex)]
            [DisplayName(Unk_49_displayName)]
            public virtual uint Unk_49 {
                get => Unk_49_raw;
                set {
                    if (Unk_49_raw == value) return;
                    Unk_49_raw = value;
                    OnPropertyChanged(nameof(Unk_49));
                }
            }

            protected uint Unk_50_raw;
            public const string Unk_50_displayName = "Unk 50";
            public const int Unk_50_sortIndex = 1150;
            [SortOrder(Unk_50_sortIndex)]
            [DisplayName(Unk_50_displayName)]
            public virtual uint Unk_50 {
                get => Unk_50_raw;
                set {
                    if (Unk_50_raw == value) return;
                    Unk_50_raw = value;
                    OnPropertyChanged(nameof(Unk_50));
                }
            }

            protected float Unk_51_raw;
            public const string Unk_51_displayName = "Unk 51";
            public const int Unk_51_sortIndex = 1200;
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
            public const int Unk_52_sortIndex = 1250;
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
            public const int Unk_53_sortIndex = 1300;
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
            public const int Unk_54_sortIndex = 1350;
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
            public const int Unk_55_sortIndex = 1400;
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

            protected float Unk_56_raw;
            public const string Unk_56_displayName = "Unk 56";
            public const int Unk_56_sortIndex = 1450;
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

            protected float Unk_57_raw;
            public const string Unk_57_displayName = "Unk 57";
            public const int Unk_57_sortIndex = 1500;
            [SortOrder(Unk_57_sortIndex)]
            [DisplayName(Unk_57_displayName)]
            public virtual float Unk_57 {
                get => Unk_57_raw;
                set {
                    if (Unk_57_raw == value) return;
                    Unk_57_raw = value;
                    OnPropertyChanged(nameof(Unk_57));
                }
            }

            protected float Unk_58_raw;
            public const string Unk_58_displayName = "Unk 58";
            public const int Unk_58_sortIndex = 1550;
            [SortOrder(Unk_58_sortIndex)]
            [DisplayName(Unk_58_displayName)]
            public virtual float Unk_58 {
                get => Unk_58_raw;
                set {
                    if (Unk_58_raw == value) return;
                    Unk_58_raw = value;
                    OnPropertyChanged(nameof(Unk_58));
                }
            }

            protected float Unk_59_raw;
            public const string Unk_59_displayName = "Unk 59";
            public const int Unk_59_sortIndex = 1600;
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
            public const int Unk_60_sortIndex = 1650;
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
            public const int Unk_61_sortIndex = 1700;
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
            public const int Unk_62_sortIndex = 1750;
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
            public const int Unk_63_sortIndex = 1800;
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
            public const int Unk_64_sortIndex = 1850;
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
            public const int Unk_65_sortIndex = 1900;
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

            protected float Unk_66_raw;
            public const string Unk_66_displayName = "Unk 66";
            public const int Unk_66_sortIndex = 1950;
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
            public const int Unk_67_sortIndex = 2000;
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
            public const int Unk_68_sortIndex = 2050;
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

            protected float Unk_69_raw;
            public const string Unk_69_displayName = "Unk 69";
            public const int Unk_69_sortIndex = 2100;
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
            public const int Unk_70_sortIndex = 2150;
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
            public const int Unk_71_sortIndex = 2200;
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

            protected byte Unk_72_raw;
            public const string Unk_72_displayName = "Unk 72";
            public const int Unk_72_sortIndex = 2250;
            [SortOrder(Unk_72_sortIndex)]
            [DisplayName(Unk_72_displayName)]
            public virtual byte Unk_72 {
                get => Unk_72_raw;
                set {
                    if (Unk_72_raw == value) return;
                    Unk_72_raw = value;
                    OnPropertyChanged(nameof(Unk_72));
                }
            }

            protected uint Unk_73_raw;
            public const string Unk_73_displayName = "Unk 73";
            public const int Unk_73_sortIndex = 2300;
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

            protected float Unk_74_raw;
            public const string Unk_74_displayName = "Unk 74";
            public const int Unk_74_sortIndex = 2350;
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
            public const int Unk_75_sortIndex = 2400;
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

            protected float Unk_76_raw;
            public const string Unk_76_displayName = "Unk 76";
            public const int Unk_76_sortIndex = 2450;
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

            protected byte Unk_77_raw;
            public const string Unk_77_displayName = "Unk 77";
            public const int Unk_77_sortIndex = 2500;
            [SortOrder(Unk_77_sortIndex)]
            [DisplayName(Unk_77_displayName)]
            public virtual byte Unk_77 {
                get => Unk_77_raw;
                set {
                    if (Unk_77_raw == value) return;
                    Unk_77_raw = value;
                    OnPropertyChanged(nameof(Unk_77));
                }
            }

            protected int Unk_78_raw;
            public const string Unk_78_displayName = "Unk 78";
            public const int Unk_78_sortIndex = 2550;
            [SortOrder(Unk_78_sortIndex)]
            [DisplayName(Unk_78_displayName)]
            public virtual int Unk_78 {
                get => Unk_78_raw;
                set {
                    if (Unk_78_raw == value) return;
                    Unk_78_raw = value;
                    OnPropertyChanged(nameof(Unk_78));
                }
            }

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W13p_Params_3_Shared_ LoadData(BinaryReader reader, ulong i) {
                var data = new W13p_Params_3_Shared_();
                data.Index = i;
                data.Unk_28_raw = reader.ReadSingle();
                data.Unk_29_raw = reader.ReadSingle();
                data.Unk_30_raw = reader.ReadSingle();
                data.Unk_31_raw = reader.ReadSingle();
                data.Unk_32_raw = reader.ReadSingle();
                data.Unk_33_raw = reader.ReadSingle();
                data.Unk_34_raw = reader.ReadSingle();
                data.Unk_35_raw = reader.ReadSingle();
                data.Unk_36_raw = reader.ReadSingle();
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
                data.Unk_49_raw = reader.ReadUInt32();
                data.Unk_50_raw = reader.ReadUInt32();
                data.Unk_51_raw = reader.ReadSingle();
                data.Unk_52_raw = reader.ReadSingle();
                data.Unk_53_raw = reader.ReadSingle();
                data.Unk_54_raw = reader.ReadSingle();
                data.Unk_55_raw = reader.ReadSingle();
                data.Unk_56_raw = reader.ReadSingle();
                data.Unk_57_raw = reader.ReadSingle();
                data.Unk_58_raw = reader.ReadSingle();
                data.Unk_59_raw = reader.ReadSingle();
                data.Unk_60_raw = reader.ReadSingle();
                data.Unk_61_raw = reader.ReadSingle();
                data.Unk_62_raw = reader.ReadSingle();
                data.Unk_63_raw = reader.ReadSingle();
                data.Unk_64_raw = reader.ReadSingle();
                data.Unk_65_raw = reader.ReadSingle();
                data.Unk_66_raw = reader.ReadSingle();
                data.Unk_67_raw = reader.ReadSingle();
                data.Unk_68_raw = reader.ReadSingle();
                data.Unk_69_raw = reader.ReadSingle();
                data.Unk_70_raw = reader.ReadSingle();
                data.Unk_71_raw = reader.ReadSingle();
                data.Unk_72_raw = reader.ReadByte();
                data.Unk_73_raw = reader.ReadUInt32();
                data.Unk_74_raw = reader.ReadSingle();
                data.Unk_75_raw = reader.ReadSingle();
                data.Unk_76_raw = reader.ReadSingle();
                data.Unk_77_raw = reader.ReadByte();
                data.Unk_78_raw = reader.ReadInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
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
                writer.Write(Unk_66_raw);
                writer.Write(Unk_67_raw);
                writer.Write(Unk_68_raw);
                writer.Write(Unk_69_raw);
                writer.Write(Unk_70_raw);
                writer.Write(Unk_71_raw);
                writer.Write(Unk_72_raw);
                writer.Write(Unk_73_raw);
                writer.Write(Unk_74_raw);
                writer.Write(Unk_75_raw);
                writer.Write(Unk_76_raw);
                writer.Write(Unk_77_raw);
                writer.Write(Unk_78_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
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
                    new MultiStructItemCustomView(this, "Unk 66", "Unk_66"),
                    new MultiStructItemCustomView(this, "Unk 67", "Unk_67"),
                    new MultiStructItemCustomView(this, "Unk 68", "Unk_68"),
                    new MultiStructItemCustomView(this, "Unk 69", "Unk_69"),
                    new MultiStructItemCustomView(this, "Unk 70", "Unk_70"),
                    new MultiStructItemCustomView(this, "Unk 71", "Unk_71"),
                    new MultiStructItemCustomView(this, "Unk 72", "Unk_72"),
                    new MultiStructItemCustomView(this, "Unk 73", "Unk_73"),
                    new MultiStructItemCustomView(this, "Unk 74", "Unk_74"),
                    new MultiStructItemCustomView(this, "Unk 75", "Unk_75"),
                    new MultiStructItemCustomView(this, "Unk 76", "Unk_76"),
                    new MultiStructItemCustomView(this, "Unk 77", "Unk_77"),
                    new MultiStructItemCustomView(this, "Unk 78", "Unk_78"),
                };
            }
        }

        public partial class Unk_Arr_2_Shared_ : MhwStructItem {
            public const ulong FixedSizeCount = 8;
            public const string GridName = "Unk Arr 2 (Shared)";

            protected float Unk_1_raw;
            public const string Unk_1_displayName = "Unk 1";
            public const int Unk_1_sortIndex = 50;
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
            public const int Unk_2_sortIndex = 100;
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
            public const int Unk_3_sortIndex = 150;
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

            protected float Unk_5_raw;
            public const string Unk_5_displayName = "Unk 5";
            public const int Unk_5_sortIndex = 250;
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
            public const int Unk_6_sortIndex = 300;
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
            public const int Unk_7_sortIndex = 350;
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
            public const int Unk_8_sortIndex = 400;
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
            public const int Unk_9_sortIndex = 450;
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
            public const int Unk_10_sortIndex = 500;
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
            public const int Unk_11_sortIndex = 550;
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
            public const int Unk_12_sortIndex = 600;
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
            public const int Unk_13_sortIndex = 650;
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

            protected byte Unk_14_raw;
            public const string Unk_14_displayName = "Unk 14";
            public const int Unk_14_sortIndex = 700;
            [SortOrder(Unk_14_sortIndex)]
            [DisplayName(Unk_14_displayName)]
            public virtual byte Unk_14 {
                get => Unk_14_raw;
                set {
                    if (Unk_14_raw == value) return;
                    Unk_14_raw = value;
                    OnPropertyChanged(nameof(Unk_14));
                }
            }

            protected int Unk_15_raw;
            public const string Unk_15_displayName = "Unk 15";
            public const int Unk_15_sortIndex = 750;
            [SortOrder(Unk_15_sortIndex)]
            [DisplayName(Unk_15_displayName)]
            public virtual int Unk_15 {
                get => Unk_15_raw;
                set {
                    if (Unk_15_raw == value) return;
                    Unk_15_raw = value;
                    OnPropertyChanged(nameof(Unk_15));
                }
            }

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
                var count = 8UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Unk_Arr_2_Shared_ LoadData(BinaryReader reader, ulong i) {
                var data = new Unk_Arr_2_Shared_();
                data.Index = i;
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
                data.Unk_14_raw = reader.ReadByte();
                data.Unk_15_raw = reader.ReadInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
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
            }
        }

        public partial class W13p_Params_4_Shared_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView> {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W13p Params (4, Shared)";

            protected float Unk_79_raw;
            public const string Unk_79_displayName = "Unk 79";
            public const int Unk_79_sortIndex = 50;
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
            public const int Unk_80_sortIndex = 100;
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
            public const int Unk_81_sortIndex = 150;
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
            public const int Unk_82_sortIndex = 200;
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
            public const int Unk_83_sortIndex = 250;
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
            public const int Unk_84_sortIndex = 300;
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
            public const int Unk_85_sortIndex = 350;
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
            public const int Unk_86_sortIndex = 400;
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
            public const int Unk_87_sortIndex = 450;
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
            public const int Unk_88_sortIndex = 500;
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
            public const int Unk_89_sortIndex = 550;
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
            public const int Unk_90_sortIndex = 600;
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

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W13p_Params_4_Shared_ LoadData(BinaryReader reader, ulong i) {
                var data = new W13p_Params_4_Shared_();
                data.Index = i;
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
                return data;
            }

            public void WriteData(BinaryWriter writer) {
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
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
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
                };
            }
        }

        public partial class W13p_Params_5_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView> {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W13p Params (5)";

            protected float Unk_91_raw;
            public const string Unk_91_displayName = "Unk 91";
            public const int Unk_91_sortIndex = 50;
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
            public const int Unk_92_sortIndex = 100;
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
            public const int Unk_93_sortIndex = 150;
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
            public const int Unk_94_sortIndex = 200;
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
            public const int Unk_95_sortIndex = 250;
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
            public const int Unk_96_sortIndex = 300;
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
            public const int Unk_97_sortIndex = 350;
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
            public const int Unk_98_sortIndex = 400;
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
            public const int Unk_99_sortIndex = 450;
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

            protected uint Unk_100_raw;
            public const string Unk_100_displayName = "Unk 100";
            public const int Unk_100_sortIndex = 500;
            [SortOrder(Unk_100_sortIndex)]
            [DisplayName(Unk_100_displayName)]
            public virtual uint Unk_100 {
                get => Unk_100_raw;
                set {
                    if (Unk_100_raw == value) return;
                    Unk_100_raw = value;
                    OnPropertyChanged(nameof(Unk_100));
                }
            }

            protected float Unk_101_raw;
            public const string Unk_101_displayName = "Unk 101";
            public const int Unk_101_sortIndex = 550;
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

            protected uint Unk_102_raw;
            public const string Unk_102_displayName = "Unk 102";
            public const int Unk_102_sortIndex = 600;
            [SortOrder(Unk_102_sortIndex)]
            [DisplayName(Unk_102_displayName)]
            public virtual uint Unk_102 {
                get => Unk_102_raw;
                set {
                    if (Unk_102_raw == value) return;
                    Unk_102_raw = value;
                    OnPropertyChanged(nameof(Unk_102));
                }
            }

            protected float Unk_103_raw;
            public const string Unk_103_displayName = "Unk 103";
            public const int Unk_103_sortIndex = 650;
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

            protected uint Unk_104_raw;
            public const string Unk_104_displayName = "Unk 104";
            public const int Unk_104_sortIndex = 700;
            [SortOrder(Unk_104_sortIndex)]
            [DisplayName(Unk_104_displayName)]
            public virtual uint Unk_104 {
                get => Unk_104_raw;
                set {
                    if (Unk_104_raw == value) return;
                    Unk_104_raw = value;
                    OnPropertyChanged(nameof(Unk_104));
                }
            }

            protected float Unk_105_raw;
            public const string Unk_105_displayName = "Unk 105";
            public const int Unk_105_sortIndex = 750;
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

            protected uint Unk_106_raw;
            public const string Unk_106_displayName = "Unk 106";
            public const int Unk_106_sortIndex = 800;
            [SortOrder(Unk_106_sortIndex)]
            [DisplayName(Unk_106_displayName)]
            public virtual uint Unk_106 {
                get => Unk_106_raw;
                set {
                    if (Unk_106_raw == value) return;
                    Unk_106_raw = value;
                    OnPropertyChanged(nameof(Unk_106));
                }
            }

            protected float Unk_107_raw;
            public const string Unk_107_displayName = "Unk 107";
            public const int Unk_107_sortIndex = 850;
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
            public const int Unk_108_sortIndex = 900;
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
            public const int Unk_109_sortIndex = 950;
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
            public const int Unk_110_sortIndex = 1000;
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

            protected float Unk_111_raw;
            public const string Unk_111_displayName = "Unk 111";
            public const int Unk_111_sortIndex = 1050;
            [SortOrder(Unk_111_sortIndex)]
            [DisplayName(Unk_111_displayName)]
            public virtual float Unk_111 {
                get => Unk_111_raw;
                set {
                    if (Unk_111_raw == value) return;
                    Unk_111_raw = value;
                    OnPropertyChanged(nameof(Unk_111));
                }
            }

            protected float Unk_112_raw;
            public const string Unk_112_displayName = "Unk 112";
            public const int Unk_112_sortIndex = 1100;
            [SortOrder(Unk_112_sortIndex)]
            [DisplayName(Unk_112_displayName)]
            public virtual float Unk_112 {
                get => Unk_112_raw;
                set {
                    if (Unk_112_raw == value) return;
                    Unk_112_raw = value;
                    OnPropertyChanged(nameof(Unk_112));
                }
            }

            protected float Unk_113_raw;
            public const string Unk_113_displayName = "Unk 113";
            public const int Unk_113_sortIndex = 1150;
            [SortOrder(Unk_113_sortIndex)]
            [DisplayName(Unk_113_displayName)]
            public virtual float Unk_113 {
                get => Unk_113_raw;
                set {
                    if (Unk_113_raw == value) return;
                    Unk_113_raw = value;
                    OnPropertyChanged(nameof(Unk_113));
                }
            }

            protected float Unk_114_raw;
            public const string Unk_114_displayName = "Unk 114";
            public const int Unk_114_sortIndex = 1200;
            [SortOrder(Unk_114_sortIndex)]
            [DisplayName(Unk_114_displayName)]
            public virtual float Unk_114 {
                get => Unk_114_raw;
                set {
                    if (Unk_114_raw == value) return;
                    Unk_114_raw = value;
                    OnPropertyChanged(nameof(Unk_114));
                }
            }

            protected float Unk_115_raw;
            public const string Unk_115_displayName = "Unk 115";
            public const int Unk_115_sortIndex = 1250;
            [SortOrder(Unk_115_sortIndex)]
            [DisplayName(Unk_115_displayName)]
            public virtual float Unk_115 {
                get => Unk_115_raw;
                set {
                    if (Unk_115_raw == value) return;
                    Unk_115_raw = value;
                    OnPropertyChanged(nameof(Unk_115));
                }
            }

            protected float Unk_116_raw;
            public const string Unk_116_displayName = "Unk 116";
            public const int Unk_116_sortIndex = 1300;
            [SortOrder(Unk_116_sortIndex)]
            [DisplayName(Unk_116_displayName)]
            public virtual float Unk_116 {
                get => Unk_116_raw;
                set {
                    if (Unk_116_raw == value) return;
                    Unk_116_raw = value;
                    OnPropertyChanged(nameof(Unk_116));
                }
            }

            protected float Unk_117_raw;
            public const string Unk_117_displayName = "Unk 117";
            public const int Unk_117_sortIndex = 1350;
            [SortOrder(Unk_117_sortIndex)]
            [DisplayName(Unk_117_displayName)]
            public virtual float Unk_117 {
                get => Unk_117_raw;
                set {
                    if (Unk_117_raw == value) return;
                    Unk_117_raw = value;
                    OnPropertyChanged(nameof(Unk_117));
                }
            }

            protected float Unk_118_raw;
            public const string Unk_118_displayName = "Unk 118";
            public const int Unk_118_sortIndex = 1400;
            [SortOrder(Unk_118_sortIndex)]
            [DisplayName(Unk_118_displayName)]
            public virtual float Unk_118 {
                get => Unk_118_raw;
                set {
                    if (Unk_118_raw == value) return;
                    Unk_118_raw = value;
                    OnPropertyChanged(nameof(Unk_118));
                }
            }

            protected float Unk_119_raw;
            public const string Unk_119_displayName = "Unk 119";
            public const int Unk_119_sortIndex = 1450;
            [SortOrder(Unk_119_sortIndex)]
            [DisplayName(Unk_119_displayName)]
            public virtual float Unk_119 {
                get => Unk_119_raw;
                set {
                    if (Unk_119_raw == value) return;
                    Unk_119_raw = value;
                    OnPropertyChanged(nameof(Unk_119));
                }
            }

            protected float Unk_120_raw;
            public const string Unk_120_displayName = "Unk 120";
            public const int Unk_120_sortIndex = 1500;
            [SortOrder(Unk_120_sortIndex)]
            [DisplayName(Unk_120_displayName)]
            public virtual float Unk_120 {
                get => Unk_120_raw;
                set {
                    if (Unk_120_raw == value) return;
                    Unk_120_raw = value;
                    OnPropertyChanged(nameof(Unk_120));
                }
            }

            protected float Unk_121_raw;
            public const string Unk_121_displayName = "Unk 121";
            public const int Unk_121_sortIndex = 1550;
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
            public const int Unk_122_sortIndex = 1600;
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

            protected float Unk_123_raw;
            public const string Unk_123_displayName = "Unk 123";
            public const int Unk_123_sortIndex = 1650;
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
            public const int Unk_124_sortIndex = 1700;
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

            protected float Unk_125_raw;
            public const string Unk_125_displayName = "Unk 125";
            public const int Unk_125_sortIndex = 1750;
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
            public const int Unk_126_sortIndex = 1800;
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
            public const int Unk_127_sortIndex = 1850;
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
            public const int Unk_128_sortIndex = 1900;
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
            public const int Unk_129_sortIndex = 1950;
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
            public const int Unk_130_sortIndex = 2000;
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
            public const int Unk_131_sortIndex = 2050;
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
            public const int Unk_132_sortIndex = 2100;
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
            public const int Unk_133_sortIndex = 2150;
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
            public const int Unk_134_sortIndex = 2200;
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
            public const int Unk_135_sortIndex = 2250;
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
            public const int Unk_136_sortIndex = 2300;
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
            public const int Unk_137_sortIndex = 2350;
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
            public const int Unk_138_sortIndex = 2400;
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
            public const int Unk_139_sortIndex = 2450;
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
            public const int Unk_140_sortIndex = 2500;
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
            public const int Unk_141_sortIndex = 2550;
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
            public const int Unk_142_sortIndex = 2600;
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
            public const int Unk_143_sortIndex = 2650;
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
            public const int Unk_144_sortIndex = 2700;
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
            public const int Unk_145_sortIndex = 2750;
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
            public const int Unk_146_sortIndex = 2800;
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
            public const int Unk_147_sortIndex = 2850;
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
            public const int Unk_148_sortIndex = 2900;
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
            public const int Unk_149_sortIndex = 2950;
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
            public const int Unk_150_sortIndex = 3000;
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
            public const int Unk_151_sortIndex = 3050;
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
            public const int Unk_152_sortIndex = 3100;
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
            public const int Unk_153_sortIndex = 3150;
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
            public const int Unk_154_sortIndex = 3200;
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
            public const int Unk_155_sortIndex = 3250;
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
            public const int Unk_156_sortIndex = 3300;
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
            public const int Unk_157_sortIndex = 3350;
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

            protected float Unk_158_raw;
            public const string Unk_158_displayName = "Unk 158";
            public const int Unk_158_sortIndex = 3400;
            [SortOrder(Unk_158_sortIndex)]
            [DisplayName(Unk_158_displayName)]
            public virtual float Unk_158 {
                get => Unk_158_raw;
                set {
                    if (Unk_158_raw == value) return;
                    Unk_158_raw = value;
                    OnPropertyChanged(nameof(Unk_158));
                }
            }

            protected float Unk_159_raw;
            public const string Unk_159_displayName = "Unk 159";
            public const int Unk_159_sortIndex = 3450;
            [SortOrder(Unk_159_sortIndex)]
            [DisplayName(Unk_159_displayName)]
            public virtual float Unk_159 {
                get => Unk_159_raw;
                set {
                    if (Unk_159_raw == value) return;
                    Unk_159_raw = value;
                    OnPropertyChanged(nameof(Unk_159));
                }
            }

            protected float Unk_160_raw;
            public const string Unk_160_displayName = "Unk 160";
            public const int Unk_160_sortIndex = 3500;
            [SortOrder(Unk_160_sortIndex)]
            [DisplayName(Unk_160_displayName)]
            public virtual float Unk_160 {
                get => Unk_160_raw;
                set {
                    if (Unk_160_raw == value) return;
                    Unk_160_raw = value;
                    OnPropertyChanged(nameof(Unk_160));
                }
            }

            protected float Unk_161_raw;
            public const string Unk_161_displayName = "Unk 161";
            public const int Unk_161_sortIndex = 3550;
            [SortOrder(Unk_161_sortIndex)]
            [DisplayName(Unk_161_displayName)]
            public virtual float Unk_161 {
                get => Unk_161_raw;
                set {
                    if (Unk_161_raw == value) return;
                    Unk_161_raw = value;
                    OnPropertyChanged(nameof(Unk_161));
                }
            }

            protected float Unk_162_raw;
            public const string Unk_162_displayName = "Unk 162";
            public const int Unk_162_sortIndex = 3600;
            [SortOrder(Unk_162_sortIndex)]
            [DisplayName(Unk_162_displayName)]
            public virtual float Unk_162 {
                get => Unk_162_raw;
                set {
                    if (Unk_162_raw == value) return;
                    Unk_162_raw = value;
                    OnPropertyChanged(nameof(Unk_162));
                }
            }

            protected float Unk_163_raw;
            public const string Unk_163_displayName = "Unk 163";
            public const int Unk_163_sortIndex = 3650;
            [SortOrder(Unk_163_sortIndex)]
            [DisplayName(Unk_163_displayName)]
            public virtual float Unk_163 {
                get => Unk_163_raw;
                set {
                    if (Unk_163_raw == value) return;
                    Unk_163_raw = value;
                    OnPropertyChanged(nameof(Unk_163));
                }
            }

            protected float Unk_164_raw;
            public const string Unk_164_displayName = "Unk 164";
            public const int Unk_164_sortIndex = 3700;
            [SortOrder(Unk_164_sortIndex)]
            [DisplayName(Unk_164_displayName)]
            public virtual float Unk_164 {
                get => Unk_164_raw;
                set {
                    if (Unk_164_raw == value) return;
                    Unk_164_raw = value;
                    OnPropertyChanged(nameof(Unk_164));
                }
            }

            protected float Unk_165_raw;
            public const string Unk_165_displayName = "Unk 165";
            public const int Unk_165_sortIndex = 3750;
            [SortOrder(Unk_165_sortIndex)]
            [DisplayName(Unk_165_displayName)]
            public virtual float Unk_165 {
                get => Unk_165_raw;
                set {
                    if (Unk_165_raw == value) return;
                    Unk_165_raw = value;
                    OnPropertyChanged(nameof(Unk_165));
                }
            }

            protected float Unk_166_raw;
            public const string Unk_166_displayName = "Unk 166";
            public const int Unk_166_sortIndex = 3800;
            [SortOrder(Unk_166_sortIndex)]
            [DisplayName(Unk_166_displayName)]
            public virtual float Unk_166 {
                get => Unk_166_raw;
                set {
                    if (Unk_166_raw == value) return;
                    Unk_166_raw = value;
                    OnPropertyChanged(nameof(Unk_166));
                }
            }

            protected float Unk_167_raw;
            public const string Unk_167_displayName = "Unk 167";
            public const int Unk_167_sortIndex = 3850;
            [SortOrder(Unk_167_sortIndex)]
            [DisplayName(Unk_167_displayName)]
            public virtual float Unk_167 {
                get => Unk_167_raw;
                set {
                    if (Unk_167_raw == value) return;
                    Unk_167_raw = value;
                    OnPropertyChanged(nameof(Unk_167));
                }
            }

            protected float Unk_168_raw;
            public const string Unk_168_displayName = "Unk 168";
            public const int Unk_168_sortIndex = 3900;
            [SortOrder(Unk_168_sortIndex)]
            [DisplayName(Unk_168_displayName)]
            public virtual float Unk_168 {
                get => Unk_168_raw;
                set {
                    if (Unk_168_raw == value) return;
                    Unk_168_raw = value;
                    OnPropertyChanged(nameof(Unk_168));
                }
            }

            protected float Unk_169_raw;
            public const string Unk_169_displayName = "Unk 169";
            public const int Unk_169_sortIndex = 3950;
            [SortOrder(Unk_169_sortIndex)]
            [DisplayName(Unk_169_displayName)]
            public virtual float Unk_169 {
                get => Unk_169_raw;
                set {
                    if (Unk_169_raw == value) return;
                    Unk_169_raw = value;
                    OnPropertyChanged(nameof(Unk_169));
                }
            }

            protected float Unk_170_raw;
            public const string Unk_170_displayName = "Unk 170";
            public const int Unk_170_sortIndex = 4000;
            [SortOrder(Unk_170_sortIndex)]
            [DisplayName(Unk_170_displayName)]
            public virtual float Unk_170 {
                get => Unk_170_raw;
                set {
                    if (Unk_170_raw == value) return;
                    Unk_170_raw = value;
                    OnPropertyChanged(nameof(Unk_170));
                }
            }

            protected float Unk_171_raw;
            public const string Unk_171_displayName = "Unk 171";
            public const int Unk_171_sortIndex = 4050;
            [SortOrder(Unk_171_sortIndex)]
            [DisplayName(Unk_171_displayName)]
            public virtual float Unk_171 {
                get => Unk_171_raw;
                set {
                    if (Unk_171_raw == value) return;
                    Unk_171_raw = value;
                    OnPropertyChanged(nameof(Unk_171));
                }
            }

            protected float Unk_172_raw;
            public const string Unk_172_displayName = "Unk 172";
            public const int Unk_172_sortIndex = 4100;
            [SortOrder(Unk_172_sortIndex)]
            [DisplayName(Unk_172_displayName)]
            public virtual float Unk_172 {
                get => Unk_172_raw;
                set {
                    if (Unk_172_raw == value) return;
                    Unk_172_raw = value;
                    OnPropertyChanged(nameof(Unk_172));
                }
            }

            protected float Unk_173_raw;
            public const string Unk_173_displayName = "Unk 173";
            public const int Unk_173_sortIndex = 4150;
            [SortOrder(Unk_173_sortIndex)]
            [DisplayName(Unk_173_displayName)]
            public virtual float Unk_173 {
                get => Unk_173_raw;
                set {
                    if (Unk_173_raw == value) return;
                    Unk_173_raw = value;
                    OnPropertyChanged(nameof(Unk_173));
                }
            }

            protected byte Unk_174_raw;
            public const string Unk_174_displayName = "Unk 174";
            public const int Unk_174_sortIndex = 4200;
            [SortOrder(Unk_174_sortIndex)]
            [DisplayName(Unk_174_displayName)]
            public virtual byte Unk_174 {
                get => Unk_174_raw;
                set {
                    if (Unk_174_raw == value) return;
                    Unk_174_raw = value;
                    OnPropertyChanged(nameof(Unk_174));
                }
            }

            protected byte Unk_175_raw;
            public const string Unk_175_displayName = "Unk 175";
            public const int Unk_175_sortIndex = 4250;
            [SortOrder(Unk_175_sortIndex)]
            [DisplayName(Unk_175_displayName)]
            public virtual byte Unk_175 {
                get => Unk_175_raw;
                set {
                    if (Unk_175_raw == value) return;
                    Unk_175_raw = value;
                    OnPropertyChanged(nameof(Unk_175));
                }
            }

            protected byte Unk_176_raw;
            public const string Unk_176_displayName = "Unk 176";
            public const int Unk_176_sortIndex = 4300;
            [SortOrder(Unk_176_sortIndex)]
            [DisplayName(Unk_176_displayName)]
            public virtual byte Unk_176 {
                get => Unk_176_raw;
                set {
                    if (Unk_176_raw == value) return;
                    Unk_176_raw = value;
                    OnPropertyChanged(nameof(Unk_176));
                }
            }

            protected byte Unk_177_raw;
            public const string Unk_177_displayName = "Unk 177";
            public const int Unk_177_sortIndex = 4350;
            [SortOrder(Unk_177_sortIndex)]
            [DisplayName(Unk_177_displayName)]
            public virtual byte Unk_177 {
                get => Unk_177_raw;
                set {
                    if (Unk_177_raw == value) return;
                    Unk_177_raw = value;
                    OnPropertyChanged(nameof(Unk_177));
                }
            }

            protected ushort Unk_178_raw;
            public const string Unk_178_displayName = "Unk 178";
            public const int Unk_178_sortIndex = 4400;
            [SortOrder(Unk_178_sortIndex)]
            [DisplayName(Unk_178_displayName)]
            public virtual ushort Unk_178 {
                get => Unk_178_raw;
                set {
                    if (Unk_178_raw == value) return;
                    Unk_178_raw = value;
                    OnPropertyChanged(nameof(Unk_178));
                }
            }

            protected ushort Unk_179_raw;
            public const string Unk_179_displayName = "Unk 179";
            public const int Unk_179_sortIndex = 4450;
            [SortOrder(Unk_179_sortIndex)]
            [DisplayName(Unk_179_displayName)]
            public virtual ushort Unk_179 {
                get => Unk_179_raw;
                set {
                    if (Unk_179_raw == value) return;
                    Unk_179_raw = value;
                    OnPropertyChanged(nameof(Unk_179));
                }
            }

            protected ushort Unk_180_raw;
            public const string Unk_180_displayName = "Unk 180";
            public const int Unk_180_sortIndex = 4500;
            [SortOrder(Unk_180_sortIndex)]
            [DisplayName(Unk_180_displayName)]
            public virtual ushort Unk_180 {
                get => Unk_180_raw;
                set {
                    if (Unk_180_raw == value) return;
                    Unk_180_raw = value;
                    OnPropertyChanged(nameof(Unk_180));
                }
            }

            protected ushort Unk_181_raw;
            public const string Unk_181_displayName = "Unk 181";
            public const int Unk_181_sortIndex = 4550;
            [SortOrder(Unk_181_sortIndex)]
            [DisplayName(Unk_181_displayName)]
            public virtual ushort Unk_181 {
                get => Unk_181_raw;
                set {
                    if (Unk_181_raw == value) return;
                    Unk_181_raw = value;
                    OnPropertyChanged(nameof(Unk_181));
                }
            }

            protected ushort Unk_182_raw;
            public const string Unk_182_displayName = "Unk 182";
            public const int Unk_182_sortIndex = 4600;
            [SortOrder(Unk_182_sortIndex)]
            [DisplayName(Unk_182_displayName)]
            public virtual ushort Unk_182 {
                get => Unk_182_raw;
                set {
                    if (Unk_182_raw == value) return;
                    Unk_182_raw = value;
                    OnPropertyChanged(nameof(Unk_182));
                }
            }

            protected ushort Unk_183_raw;
            public const string Unk_183_displayName = "Unk 183";
            public const int Unk_183_sortIndex = 4650;
            [SortOrder(Unk_183_sortIndex)]
            [DisplayName(Unk_183_displayName)]
            public virtual ushort Unk_183 {
                get => Unk_183_raw;
                set {
                    if (Unk_183_raw == value) return;
                    Unk_183_raw = value;
                    OnPropertyChanged(nameof(Unk_183));
                }
            }

            protected ushort Unk_184_raw;
            public const string Unk_184_displayName = "Unk 184";
            public const int Unk_184_sortIndex = 4700;
            [SortOrder(Unk_184_sortIndex)]
            [DisplayName(Unk_184_displayName)]
            public virtual ushort Unk_184 {
                get => Unk_184_raw;
                set {
                    if (Unk_184_raw == value) return;
                    Unk_184_raw = value;
                    OnPropertyChanged(nameof(Unk_184));
                }
            }

            protected ushort Unk_185_raw;
            public const string Unk_185_displayName = "Unk 185";
            public const int Unk_185_sortIndex = 4750;
            [SortOrder(Unk_185_sortIndex)]
            [DisplayName(Unk_185_displayName)]
            public virtual ushort Unk_185 {
                get => Unk_185_raw;
                set {
                    if (Unk_185_raw == value) return;
                    Unk_185_raw = value;
                    OnPropertyChanged(nameof(Unk_185));
                }
            }

            protected ushort Unk_186_raw;
            public const string Unk_186_displayName = "Unk 186";
            public const int Unk_186_sortIndex = 4800;
            [SortOrder(Unk_186_sortIndex)]
            [DisplayName(Unk_186_displayName)]
            public virtual ushort Unk_186 {
                get => Unk_186_raw;
                set {
                    if (Unk_186_raw == value) return;
                    Unk_186_raw = value;
                    OnPropertyChanged(nameof(Unk_186));
                }
            }

            protected ushort Unk_187_raw;
            public const string Unk_187_displayName = "Unk 187";
            public const int Unk_187_sortIndex = 4850;
            [SortOrder(Unk_187_sortIndex)]
            [DisplayName(Unk_187_displayName)]
            public virtual ushort Unk_187 {
                get => Unk_187_raw;
                set {
                    if (Unk_187_raw == value) return;
                    Unk_187_raw = value;
                    OnPropertyChanged(nameof(Unk_187));
                }
            }

            protected byte Unk_188_raw;
            public const string Unk_188_displayName = "Unk 188";
            public const int Unk_188_sortIndex = 4900;
            [SortOrder(Unk_188_sortIndex)]
            [DisplayName(Unk_188_displayName)]
            public virtual byte Unk_188 {
                get => Unk_188_raw;
                set {
                    if (Unk_188_raw == value) return;
                    Unk_188_raw = value;
                    OnPropertyChanged(nameof(Unk_188));
                }
            }

            protected byte Unk_189_raw;
            public const string Unk_189_displayName = "Unk 189";
            public const int Unk_189_sortIndex = 4950;
            [SortOrder(Unk_189_sortIndex)]
            [DisplayName(Unk_189_displayName)]
            public virtual byte Unk_189 {
                get => Unk_189_raw;
                set {
                    if (Unk_189_raw == value) return;
                    Unk_189_raw = value;
                    OnPropertyChanged(nameof(Unk_189));
                }
            }

            protected byte Unk_190_raw;
            public const string Unk_190_displayName = "Unk 190";
            public const int Unk_190_sortIndex = 5000;
            [SortOrder(Unk_190_sortIndex)]
            [DisplayName(Unk_190_displayName)]
            public virtual byte Unk_190 {
                get => Unk_190_raw;
                set {
                    if (Unk_190_raw == value) return;
                    Unk_190_raw = value;
                    OnPropertyChanged(nameof(Unk_190));
                }
            }

            protected byte Unk_191_raw;
            public const string Unk_191_displayName = "Unk 191";
            public const int Unk_191_sortIndex = 5050;
            [SortOrder(Unk_191_sortIndex)]
            [DisplayName(Unk_191_displayName)]
            public virtual byte Unk_191 {
                get => Unk_191_raw;
                set {
                    if (Unk_191_raw == value) return;
                    Unk_191_raw = value;
                    OnPropertyChanged(nameof(Unk_191));
                }
            }

            protected ushort Unk_192_raw;
            public const string Unk_192_displayName = "Unk 192";
            public const int Unk_192_sortIndex = 5100;
            [SortOrder(Unk_192_sortIndex)]
            [DisplayName(Unk_192_displayName)]
            public virtual ushort Unk_192 {
                get => Unk_192_raw;
                set {
                    if (Unk_192_raw == value) return;
                    Unk_192_raw = value;
                    OnPropertyChanged(nameof(Unk_192));
                }
            }

            protected ushort Unk_193_raw;
            public const string Unk_193_displayName = "Unk 193";
            public const int Unk_193_sortIndex = 5150;
            [SortOrder(Unk_193_sortIndex)]
            [DisplayName(Unk_193_displayName)]
            public virtual ushort Unk_193 {
                get => Unk_193_raw;
                set {
                    if (Unk_193_raw == value) return;
                    Unk_193_raw = value;
                    OnPropertyChanged(nameof(Unk_193));
                }
            }

            protected ushort Unk_194_raw;
            public const string Unk_194_displayName = "Unk 194";
            public const int Unk_194_sortIndex = 5200;
            [SortOrder(Unk_194_sortIndex)]
            [DisplayName(Unk_194_displayName)]
            public virtual ushort Unk_194 {
                get => Unk_194_raw;
                set {
                    if (Unk_194_raw == value) return;
                    Unk_194_raw = value;
                    OnPropertyChanged(nameof(Unk_194));
                }
            }

            protected ushort Unk_195_raw;
            public const string Unk_195_displayName = "Unk 195";
            public const int Unk_195_sortIndex = 5250;
            [SortOrder(Unk_195_sortIndex)]
            [DisplayName(Unk_195_displayName)]
            public virtual ushort Unk_195 {
                get => Unk_195_raw;
                set {
                    if (Unk_195_raw == value) return;
                    Unk_195_raw = value;
                    OnPropertyChanged(nameof(Unk_195));
                }
            }

            protected ushort Unk_196_raw;
            public const string Unk_196_displayName = "Unk 196";
            public const int Unk_196_sortIndex = 5300;
            [SortOrder(Unk_196_sortIndex)]
            [DisplayName(Unk_196_displayName)]
            public virtual ushort Unk_196 {
                get => Unk_196_raw;
                set {
                    if (Unk_196_raw == value) return;
                    Unk_196_raw = value;
                    OnPropertyChanged(nameof(Unk_196));
                }
            }

            protected ushort Unk_197_raw;
            public const string Unk_197_displayName = "Unk 197";
            public const int Unk_197_sortIndex = 5350;
            [SortOrder(Unk_197_sortIndex)]
            [DisplayName(Unk_197_displayName)]
            public virtual ushort Unk_197 {
                get => Unk_197_raw;
                set {
                    if (Unk_197_raw == value) return;
                    Unk_197_raw = value;
                    OnPropertyChanged(nameof(Unk_197));
                }
            }

            protected ushort Unk_198_raw;
            public const string Unk_198_displayName = "Unk 198";
            public const int Unk_198_sortIndex = 5400;
            [SortOrder(Unk_198_sortIndex)]
            [DisplayName(Unk_198_displayName)]
            public virtual ushort Unk_198 {
                get => Unk_198_raw;
                set {
                    if (Unk_198_raw == value) return;
                    Unk_198_raw = value;
                    OnPropertyChanged(nameof(Unk_198));
                }
            }

            protected ushort Unk_199_raw;
            public const string Unk_199_displayName = "Unk 199";
            public const int Unk_199_sortIndex = 5450;
            [SortOrder(Unk_199_sortIndex)]
            [DisplayName(Unk_199_displayName)]
            public virtual ushort Unk_199 {
                get => Unk_199_raw;
                set {
                    if (Unk_199_raw == value) return;
                    Unk_199_raw = value;
                    OnPropertyChanged(nameof(Unk_199));
                }
            }

            protected ushort Unk_200_raw;
            public const string Unk_200_displayName = "Unk 200";
            public const int Unk_200_sortIndex = 5500;
            [SortOrder(Unk_200_sortIndex)]
            [DisplayName(Unk_200_displayName)]
            public virtual ushort Unk_200 {
                get => Unk_200_raw;
                set {
                    if (Unk_200_raw == value) return;
                    Unk_200_raw = value;
                    OnPropertyChanged(nameof(Unk_200));
                }
            }

            protected ushort Unk_201_raw;
            public const string Unk_201_displayName = "Unk 201";
            public const int Unk_201_sortIndex = 5550;
            [SortOrder(Unk_201_sortIndex)]
            [DisplayName(Unk_201_displayName)]
            public virtual ushort Unk_201 {
                get => Unk_201_raw;
                set {
                    if (Unk_201_raw == value) return;
                    Unk_201_raw = value;
                    OnPropertyChanged(nameof(Unk_201));
                }
            }

            protected ushort Unk_202_raw;
            public const string Unk_202_displayName = "Unk 202";
            public const int Unk_202_sortIndex = 5600;
            [SortOrder(Unk_202_sortIndex)]
            [DisplayName(Unk_202_displayName)]
            public virtual ushort Unk_202 {
                get => Unk_202_raw;
                set {
                    if (Unk_202_raw == value) return;
                    Unk_202_raw = value;
                    OnPropertyChanged(nameof(Unk_202));
                }
            }

            protected ushort Unk_203_raw;
            public const string Unk_203_displayName = "Unk 203";
            public const int Unk_203_sortIndex = 5650;
            [SortOrder(Unk_203_sortIndex)]
            [DisplayName(Unk_203_displayName)]
            public virtual ushort Unk_203 {
                get => Unk_203_raw;
                set {
                    if (Unk_203_raw == value) return;
                    Unk_203_raw = value;
                    OnPropertyChanged(nameof(Unk_203));
                }
            }

            protected ushort Unk_204_raw;
            public const string Unk_204_displayName = "Unk 204";
            public const int Unk_204_sortIndex = 5700;
            [SortOrder(Unk_204_sortIndex)]
            [DisplayName(Unk_204_displayName)]
            public virtual ushort Unk_204 {
                get => Unk_204_raw;
                set {
                    if (Unk_204_raw == value) return;
                    Unk_204_raw = value;
                    OnPropertyChanged(nameof(Unk_204));
                }
            }

            protected ushort Unk_205_raw;
            public const string Unk_205_displayName = "Unk 205";
            public const int Unk_205_sortIndex = 5750;
            [SortOrder(Unk_205_sortIndex)]
            [DisplayName(Unk_205_displayName)]
            public virtual ushort Unk_205 {
                get => Unk_205_raw;
                set {
                    if (Unk_205_raw == value) return;
                    Unk_205_raw = value;
                    OnPropertyChanged(nameof(Unk_205));
                }
            }

            protected ushort Unk_206_raw;
            public const string Unk_206_displayName = "Unk 206";
            public const int Unk_206_sortIndex = 5800;
            [SortOrder(Unk_206_sortIndex)]
            [DisplayName(Unk_206_displayName)]
            public virtual ushort Unk_206 {
                get => Unk_206_raw;
                set {
                    if (Unk_206_raw == value) return;
                    Unk_206_raw = value;
                    OnPropertyChanged(nameof(Unk_206));
                }
            }

            protected ushort Unk_207_raw;
            public const string Unk_207_displayName = "Unk 207";
            public const int Unk_207_sortIndex = 5850;
            [SortOrder(Unk_207_sortIndex)]
            [DisplayName(Unk_207_displayName)]
            public virtual ushort Unk_207 {
                get => Unk_207_raw;
                set {
                    if (Unk_207_raw == value) return;
                    Unk_207_raw = value;
                    OnPropertyChanged(nameof(Unk_207));
                }
            }

            protected ushort Unk_208_raw;
            public const string Unk_208_displayName = "Unk 208";
            public const int Unk_208_sortIndex = 5900;
            [SortOrder(Unk_208_sortIndex)]
            [DisplayName(Unk_208_displayName)]
            public virtual ushort Unk_208 {
                get => Unk_208_raw;
                set {
                    if (Unk_208_raw == value) return;
                    Unk_208_raw = value;
                    OnPropertyChanged(nameof(Unk_208));
                }
            }

            protected ushort Unk_209_raw;
            public const string Unk_209_displayName = "Unk 209";
            public const int Unk_209_sortIndex = 5950;
            [SortOrder(Unk_209_sortIndex)]
            [DisplayName(Unk_209_displayName)]
            public virtual ushort Unk_209 {
                get => Unk_209_raw;
                set {
                    if (Unk_209_raw == value) return;
                    Unk_209_raw = value;
                    OnPropertyChanged(nameof(Unk_209));
                }
            }

            protected ushort Unk_210_raw;
            public const string Unk_210_displayName = "Unk 210";
            public const int Unk_210_sortIndex = 6000;
            [SortOrder(Unk_210_sortIndex)]
            [DisplayName(Unk_210_displayName)]
            public virtual ushort Unk_210 {
                get => Unk_210_raw;
                set {
                    if (Unk_210_raw == value) return;
                    Unk_210_raw = value;
                    OnPropertyChanged(nameof(Unk_210));
                }
            }

            protected ushort Unk_211_raw;
            public const string Unk_211_displayName = "Unk 211";
            public const int Unk_211_sortIndex = 6050;
            [SortOrder(Unk_211_sortIndex)]
            [DisplayName(Unk_211_displayName)]
            public virtual ushort Unk_211 {
                get => Unk_211_raw;
                set {
                    if (Unk_211_raw == value) return;
                    Unk_211_raw = value;
                    OnPropertyChanged(nameof(Unk_211));
                }
            }

            protected byte Unk_212_raw;
            public const string Unk_212_displayName = "Unk 212";
            public const int Unk_212_sortIndex = 6100;
            [SortOrder(Unk_212_sortIndex)]
            [DisplayName(Unk_212_displayName)]
            public virtual byte Unk_212 {
                get => Unk_212_raw;
                set {
                    if (Unk_212_raw == value) return;
                    Unk_212_raw = value;
                    OnPropertyChanged(nameof(Unk_212));
                }
            }

            protected ushort Unk_213_raw;
            public const string Unk_213_displayName = "Unk 213";
            public const int Unk_213_sortIndex = 6150;
            [SortOrder(Unk_213_sortIndex)]
            [DisplayName(Unk_213_displayName)]
            public virtual ushort Unk_213 {
                get => Unk_213_raw;
                set {
                    if (Unk_213_raw == value) return;
                    Unk_213_raw = value;
                    OnPropertyChanged(nameof(Unk_213));
                }
            }

            protected ushort Unk_214_raw;
            public const string Unk_214_displayName = "Unk 214";
            public const int Unk_214_sortIndex = 6200;
            [SortOrder(Unk_214_sortIndex)]
            [DisplayName(Unk_214_displayName)]
            public virtual ushort Unk_214 {
                get => Unk_214_raw;
                set {
                    if (Unk_214_raw == value) return;
                    Unk_214_raw = value;
                    OnPropertyChanged(nameof(Unk_214));
                }
            }

            protected float Unk_215_raw;
            public const string Unk_215_displayName = "Unk 215";
            public const int Unk_215_sortIndex = 6250;
            [SortOrder(Unk_215_sortIndex)]
            [DisplayName(Unk_215_displayName)]
            public virtual float Unk_215 {
                get => Unk_215_raw;
                set {
                    if (Unk_215_raw == value) return;
                    Unk_215_raw = value;
                    OnPropertyChanged(nameof(Unk_215));
                }
            }

            protected ushort Unk_216_raw;
            public const string Unk_216_displayName = "Unk 216";
            public const int Unk_216_sortIndex = 6300;
            [SortOrder(Unk_216_sortIndex)]
            [DisplayName(Unk_216_displayName)]
            public virtual ushort Unk_216 {
                get => Unk_216_raw;
                set {
                    if (Unk_216_raw == value) return;
                    Unk_216_raw = value;
                    OnPropertyChanged(nameof(Unk_216));
                }
            }

            protected float Unk_217_raw;
            public const string Unk_217_displayName = "Unk 217";
            public const int Unk_217_sortIndex = 6350;
            [SortOrder(Unk_217_sortIndex)]
            [DisplayName(Unk_217_displayName)]
            public virtual float Unk_217 {
                get => Unk_217_raw;
                set {
                    if (Unk_217_raw == value) return;
                    Unk_217_raw = value;
                    OnPropertyChanged(nameof(Unk_217));
                }
            }

            protected float Unk_218_raw;
            public const string Unk_218_displayName = "Unk 218";
            public const int Unk_218_sortIndex = 6400;
            [SortOrder(Unk_218_sortIndex)]
            [DisplayName(Unk_218_displayName)]
            public virtual float Unk_218 {
                get => Unk_218_raw;
                set {
                    if (Unk_218_raw == value) return;
                    Unk_218_raw = value;
                    OnPropertyChanged(nameof(Unk_218));
                }
            }

            protected float Unk_219_raw;
            public const string Unk_219_displayName = "Unk 219";
            public const int Unk_219_sortIndex = 6450;
            [SortOrder(Unk_219_sortIndex)]
            [DisplayName(Unk_219_displayName)]
            public virtual float Unk_219 {
                get => Unk_219_raw;
                set {
                    if (Unk_219_raw == value) return;
                    Unk_219_raw = value;
                    OnPropertyChanged(nameof(Unk_219));
                }
            }

            protected float Unk_220_raw;
            public const string Unk_220_displayName = "Unk 220";
            public const int Unk_220_sortIndex = 6500;
            [SortOrder(Unk_220_sortIndex)]
            [DisplayName(Unk_220_displayName)]
            public virtual float Unk_220 {
                get => Unk_220_raw;
                set {
                    if (Unk_220_raw == value) return;
                    Unk_220_raw = value;
                    OnPropertyChanged(nameof(Unk_220));
                }
            }

            protected float Unk_221_raw;
            public const string Unk_221_displayName = "Unk 221";
            public const int Unk_221_sortIndex = 6550;
            [SortOrder(Unk_221_sortIndex)]
            [DisplayName(Unk_221_displayName)]
            public virtual float Unk_221 {
                get => Unk_221_raw;
                set {
                    if (Unk_221_raw == value) return;
                    Unk_221_raw = value;
                    OnPropertyChanged(nameof(Unk_221));
                }
            }

            protected float Unk_222_raw;
            public const string Unk_222_displayName = "Unk 222";
            public const int Unk_222_sortIndex = 6600;
            [SortOrder(Unk_222_sortIndex)]
            [DisplayName(Unk_222_displayName)]
            public virtual float Unk_222 {
                get => Unk_222_raw;
                set {
                    if (Unk_222_raw == value) return;
                    Unk_222_raw = value;
                    OnPropertyChanged(nameof(Unk_222));
                }
            }

            protected float Unk_223_raw;
            public const string Unk_223_displayName = "Unk 223";
            public const int Unk_223_sortIndex = 6650;
            [SortOrder(Unk_223_sortIndex)]
            [DisplayName(Unk_223_displayName)]
            public virtual float Unk_223 {
                get => Unk_223_raw;
                set {
                    if (Unk_223_raw == value) return;
                    Unk_223_raw = value;
                    OnPropertyChanged(nameof(Unk_223));
                }
            }

            protected float Unk_224_raw;
            public const string Unk_224_displayName = "Unk 224";
            public const int Unk_224_sortIndex = 6700;
            [SortOrder(Unk_224_sortIndex)]
            [DisplayName(Unk_224_displayName)]
            public virtual float Unk_224 {
                get => Unk_224_raw;
                set {
                    if (Unk_224_raw == value) return;
                    Unk_224_raw = value;
                    OnPropertyChanged(nameof(Unk_224));
                }
            }

            protected float Unk_225_raw;
            public const string Unk_225_displayName = "Unk 225";
            public const int Unk_225_sortIndex = 6750;
            [SortOrder(Unk_225_sortIndex)]
            [DisplayName(Unk_225_displayName)]
            public virtual float Unk_225 {
                get => Unk_225_raw;
                set {
                    if (Unk_225_raw == value) return;
                    Unk_225_raw = value;
                    OnPropertyChanged(nameof(Unk_225));
                }
            }

            protected float Unk_226_raw;
            public const string Unk_226_displayName = "Unk 226";
            public const int Unk_226_sortIndex = 6800;
            [SortOrder(Unk_226_sortIndex)]
            [DisplayName(Unk_226_displayName)]
            public virtual float Unk_226 {
                get => Unk_226_raw;
                set {
                    if (Unk_226_raw == value) return;
                    Unk_226_raw = value;
                    OnPropertyChanged(nameof(Unk_226));
                }
            }

            protected float Unk_227_raw;
            public const string Unk_227_displayName = "Unk 227";
            public const int Unk_227_sortIndex = 6850;
            [SortOrder(Unk_227_sortIndex)]
            [DisplayName(Unk_227_displayName)]
            public virtual float Unk_227 {
                get => Unk_227_raw;
                set {
                    if (Unk_227_raw == value) return;
                    Unk_227_raw = value;
                    OnPropertyChanged(nameof(Unk_227));
                }
            }

            protected float Unk_228_raw;
            public const string Unk_228_displayName = "Unk 228";
            public const int Unk_228_sortIndex = 6900;
            [SortOrder(Unk_228_sortIndex)]
            [DisplayName(Unk_228_displayName)]
            public virtual float Unk_228 {
                get => Unk_228_raw;
                set {
                    if (Unk_228_raw == value) return;
                    Unk_228_raw = value;
                    OnPropertyChanged(nameof(Unk_228));
                }
            }

            protected float Unk_229_raw;
            public const string Unk_229_displayName = "Unk 229";
            public const int Unk_229_sortIndex = 6950;
            [SortOrder(Unk_229_sortIndex)]
            [DisplayName(Unk_229_displayName)]
            public virtual float Unk_229 {
                get => Unk_229_raw;
                set {
                    if (Unk_229_raw == value) return;
                    Unk_229_raw = value;
                    OnPropertyChanged(nameof(Unk_229));
                }
            }

            protected float Unk_230_raw;
            public const string Unk_230_displayName = "Unk 230";
            public const int Unk_230_sortIndex = 7000;
            [SortOrder(Unk_230_sortIndex)]
            [DisplayName(Unk_230_displayName)]
            public virtual float Unk_230 {
                get => Unk_230_raw;
                set {
                    if (Unk_230_raw == value) return;
                    Unk_230_raw = value;
                    OnPropertyChanged(nameof(Unk_230));
                }
            }

            protected byte Unk_231_raw;
            public const string Unk_231_displayName = "Unk 231";
            public const int Unk_231_sortIndex = 7050;
            [SortOrder(Unk_231_sortIndex)]
            [DisplayName(Unk_231_displayName)]
            public virtual byte Unk_231 {
                get => Unk_231_raw;
                set {
                    if (Unk_231_raw == value) return;
                    Unk_231_raw = value;
                    OnPropertyChanged(nameof(Unk_231));
                }
            }

            protected float Unk_232_raw;
            public const string Unk_232_displayName = "Unk 232";
            public const int Unk_232_sortIndex = 7100;
            [SortOrder(Unk_232_sortIndex)]
            [DisplayName(Unk_232_displayName)]
            public virtual float Unk_232 {
                get => Unk_232_raw;
                set {
                    if (Unk_232_raw == value) return;
                    Unk_232_raw = value;
                    OnPropertyChanged(nameof(Unk_232));
                }
            }

            protected byte Unk_233_raw;
            public const string Unk_233_displayName = "Unk 233";
            public const int Unk_233_sortIndex = 7150;
            [SortOrder(Unk_233_sortIndex)]
            [DisplayName(Unk_233_displayName)]
            public virtual byte Unk_233 {
                get => Unk_233_raw;
                set {
                    if (Unk_233_raw == value) return;
                    Unk_233_raw = value;
                    OnPropertyChanged(nameof(Unk_233));
                }
            }

            protected byte Unk_234_raw;
            public const string Unk_234_displayName = "Unk 234";
            public const int Unk_234_sortIndex = 7200;
            [SortOrder(Unk_234_sortIndex)]
            [DisplayName(Unk_234_displayName)]
            public virtual byte Unk_234 {
                get => Unk_234_raw;
                set {
                    if (Unk_234_raw == value) return;
                    Unk_234_raw = value;
                    OnPropertyChanged(nameof(Unk_234));
                }
            }

            protected byte Unk_235_raw;
            public const string Unk_235_displayName = "Unk 235";
            public const int Unk_235_sortIndex = 7250;
            [SortOrder(Unk_235_sortIndex)]
            [DisplayName(Unk_235_displayName)]
            public virtual byte Unk_235 {
                get => Unk_235_raw;
                set {
                    if (Unk_235_raw == value) return;
                    Unk_235_raw = value;
                    OnPropertyChanged(nameof(Unk_235));
                }
            }

            protected float Unk_236_raw;
            public const string Unk_236_displayName = "Unk 236";
            public const int Unk_236_sortIndex = 7300;
            [SortOrder(Unk_236_sortIndex)]
            [DisplayName(Unk_236_displayName)]
            public virtual float Unk_236 {
                get => Unk_236_raw;
                set {
                    if (Unk_236_raw == value) return;
                    Unk_236_raw = value;
                    OnPropertyChanged(nameof(Unk_236));
                }
            }

            protected float Unk_237_raw;
            public const string Unk_237_displayName = "Unk 237";
            public const int Unk_237_sortIndex = 7350;
            [SortOrder(Unk_237_sortIndex)]
            [DisplayName(Unk_237_displayName)]
            public virtual float Unk_237 {
                get => Unk_237_raw;
                set {
                    if (Unk_237_raw == value) return;
                    Unk_237_raw = value;
                    OnPropertyChanged(nameof(Unk_237));
                }
            }

            protected uint Unk_238_raw;
            public const string Unk_238_displayName = "Unk 238";
            public const int Unk_238_sortIndex = 7400;
            [SortOrder(Unk_238_sortIndex)]
            [DisplayName(Unk_238_displayName)]
            public virtual uint Unk_238 {
                get => Unk_238_raw;
                set {
                    if (Unk_238_raw == value) return;
                    Unk_238_raw = value;
                    OnPropertyChanged(nameof(Unk_238));
                }
            }

            protected short Unk_239_raw;
            public const string Unk_239_displayName = "Unk 239";
            public const int Unk_239_sortIndex = 7450;
            [SortOrder(Unk_239_sortIndex)]
            [DisplayName(Unk_239_displayName)]
            public virtual short Unk_239 {
                get => Unk_239_raw;
                set {
                    if (Unk_239_raw == value) return;
                    Unk_239_raw = value;
                    OnPropertyChanged(nameof(Unk_239));
                }
            }

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W13p_Params_5_ LoadData(BinaryReader reader, ulong i) {
                var data = new W13p_Params_5_();
                data.Index = i;
                data.Unk_91_raw = reader.ReadSingle();
                data.Unk_92_raw = reader.ReadSingle();
                data.Unk_93_raw = reader.ReadSingle();
                data.Unk_94_raw = reader.ReadSingle();
                data.Unk_95_raw = reader.ReadSingle();
                data.Unk_96_raw = reader.ReadSingle();
                data.Unk_97_raw = reader.ReadSingle();
                data.Unk_98_raw = reader.ReadSingle();
                data.Unk_99_raw = reader.ReadSingle();
                data.Unk_100_raw = reader.ReadUInt32();
                data.Unk_101_raw = reader.ReadSingle();
                data.Unk_102_raw = reader.ReadUInt32();
                data.Unk_103_raw = reader.ReadSingle();
                data.Unk_104_raw = reader.ReadUInt32();
                data.Unk_105_raw = reader.ReadSingle();
                data.Unk_106_raw = reader.ReadUInt32();
                data.Unk_107_raw = reader.ReadSingle();
                data.Unk_108_raw = reader.ReadSingle();
                data.Unk_109_raw = reader.ReadSingle();
                data.Unk_110_raw = reader.ReadSingle();
                data.Unk_111_raw = reader.ReadSingle();
                data.Unk_112_raw = reader.ReadSingle();
                data.Unk_113_raw = reader.ReadSingle();
                data.Unk_114_raw = reader.ReadSingle();
                data.Unk_115_raw = reader.ReadSingle();
                data.Unk_116_raw = reader.ReadSingle();
                data.Unk_117_raw = reader.ReadSingle();
                data.Unk_118_raw = reader.ReadSingle();
                data.Unk_119_raw = reader.ReadSingle();
                data.Unk_120_raw = reader.ReadSingle();
                data.Unk_121_raw = reader.ReadSingle();
                data.Unk_122_raw = reader.ReadSingle();
                data.Unk_123_raw = reader.ReadSingle();
                data.Unk_124_raw = reader.ReadSingle();
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
                data.Unk_158_raw = reader.ReadSingle();
                data.Unk_159_raw = reader.ReadSingle();
                data.Unk_160_raw = reader.ReadSingle();
                data.Unk_161_raw = reader.ReadSingle();
                data.Unk_162_raw = reader.ReadSingle();
                data.Unk_163_raw = reader.ReadSingle();
                data.Unk_164_raw = reader.ReadSingle();
                data.Unk_165_raw = reader.ReadSingle();
                data.Unk_166_raw = reader.ReadSingle();
                data.Unk_167_raw = reader.ReadSingle();
                data.Unk_168_raw = reader.ReadSingle();
                data.Unk_169_raw = reader.ReadSingle();
                data.Unk_170_raw = reader.ReadSingle();
                data.Unk_171_raw = reader.ReadSingle();
                data.Unk_172_raw = reader.ReadSingle();
                data.Unk_173_raw = reader.ReadSingle();
                data.Unk_174_raw = reader.ReadByte();
                data.Unk_175_raw = reader.ReadByte();
                data.Unk_176_raw = reader.ReadByte();
                data.Unk_177_raw = reader.ReadByte();
                data.Unk_178_raw = reader.ReadUInt16();
                data.Unk_179_raw = reader.ReadUInt16();
                data.Unk_180_raw = reader.ReadUInt16();
                data.Unk_181_raw = reader.ReadUInt16();
                data.Unk_182_raw = reader.ReadUInt16();
                data.Unk_183_raw = reader.ReadUInt16();
                data.Unk_184_raw = reader.ReadUInt16();
                data.Unk_185_raw = reader.ReadUInt16();
                data.Unk_186_raw = reader.ReadUInt16();
                data.Unk_187_raw = reader.ReadUInt16();
                data.Unk_188_raw = reader.ReadByte();
                data.Unk_189_raw = reader.ReadByte();
                data.Unk_190_raw = reader.ReadByte();
                data.Unk_191_raw = reader.ReadByte();
                data.Unk_192_raw = reader.ReadUInt16();
                data.Unk_193_raw = reader.ReadUInt16();
                data.Unk_194_raw = reader.ReadUInt16();
                data.Unk_195_raw = reader.ReadUInt16();
                data.Unk_196_raw = reader.ReadUInt16();
                data.Unk_197_raw = reader.ReadUInt16();
                data.Unk_198_raw = reader.ReadUInt16();
                data.Unk_199_raw = reader.ReadUInt16();
                data.Unk_200_raw = reader.ReadUInt16();
                data.Unk_201_raw = reader.ReadUInt16();
                data.Unk_202_raw = reader.ReadUInt16();
                data.Unk_203_raw = reader.ReadUInt16();
                data.Unk_204_raw = reader.ReadUInt16();
                data.Unk_205_raw = reader.ReadUInt16();
                data.Unk_206_raw = reader.ReadUInt16();
                data.Unk_207_raw = reader.ReadUInt16();
                data.Unk_208_raw = reader.ReadUInt16();
                data.Unk_209_raw = reader.ReadUInt16();
                data.Unk_210_raw = reader.ReadUInt16();
                data.Unk_211_raw = reader.ReadUInt16();
                data.Unk_212_raw = reader.ReadByte();
                data.Unk_213_raw = reader.ReadUInt16();
                data.Unk_214_raw = reader.ReadUInt16();
                data.Unk_215_raw = reader.ReadSingle();
                data.Unk_216_raw = reader.ReadUInt16();
                data.Unk_217_raw = reader.ReadSingle();
                data.Unk_218_raw = reader.ReadSingle();
                data.Unk_219_raw = reader.ReadSingle();
                data.Unk_220_raw = reader.ReadSingle();
                data.Unk_221_raw = reader.ReadSingle();
                data.Unk_222_raw = reader.ReadSingle();
                data.Unk_223_raw = reader.ReadSingle();
                data.Unk_224_raw = reader.ReadSingle();
                data.Unk_225_raw = reader.ReadSingle();
                data.Unk_226_raw = reader.ReadSingle();
                data.Unk_227_raw = reader.ReadSingle();
                data.Unk_228_raw = reader.ReadSingle();
                data.Unk_229_raw = reader.ReadSingle();
                data.Unk_230_raw = reader.ReadSingle();
                data.Unk_231_raw = reader.ReadByte();
                data.Unk_232_raw = reader.ReadSingle();
                data.Unk_233_raw = reader.ReadByte();
                data.Unk_234_raw = reader.ReadByte();
                data.Unk_235_raw = reader.ReadByte();
                data.Unk_236_raw = reader.ReadSingle();
                data.Unk_237_raw = reader.ReadSingle();
                data.Unk_238_raw = reader.ReadUInt32();
                data.Unk_239_raw = reader.ReadInt16();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
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
                writer.Write(Unk_121_raw);
                writer.Write(Unk_122_raw);
                writer.Write(Unk_123_raw);
                writer.Write(Unk_124_raw);
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
                writer.Write(Unk_158_raw);
                writer.Write(Unk_159_raw);
                writer.Write(Unk_160_raw);
                writer.Write(Unk_161_raw);
                writer.Write(Unk_162_raw);
                writer.Write(Unk_163_raw);
                writer.Write(Unk_164_raw);
                writer.Write(Unk_165_raw);
                writer.Write(Unk_166_raw);
                writer.Write(Unk_167_raw);
                writer.Write(Unk_168_raw);
                writer.Write(Unk_169_raw);
                writer.Write(Unk_170_raw);
                writer.Write(Unk_171_raw);
                writer.Write(Unk_172_raw);
                writer.Write(Unk_173_raw);
                writer.Write(Unk_174_raw);
                writer.Write(Unk_175_raw);
                writer.Write(Unk_176_raw);
                writer.Write(Unk_177_raw);
                writer.Write(Unk_178_raw);
                writer.Write(Unk_179_raw);
                writer.Write(Unk_180_raw);
                writer.Write(Unk_181_raw);
                writer.Write(Unk_182_raw);
                writer.Write(Unk_183_raw);
                writer.Write(Unk_184_raw);
                writer.Write(Unk_185_raw);
                writer.Write(Unk_186_raw);
                writer.Write(Unk_187_raw);
                writer.Write(Unk_188_raw);
                writer.Write(Unk_189_raw);
                writer.Write(Unk_190_raw);
                writer.Write(Unk_191_raw);
                writer.Write(Unk_192_raw);
                writer.Write(Unk_193_raw);
                writer.Write(Unk_194_raw);
                writer.Write(Unk_195_raw);
                writer.Write(Unk_196_raw);
                writer.Write(Unk_197_raw);
                writer.Write(Unk_198_raw);
                writer.Write(Unk_199_raw);
                writer.Write(Unk_200_raw);
                writer.Write(Unk_201_raw);
                writer.Write(Unk_202_raw);
                writer.Write(Unk_203_raw);
                writer.Write(Unk_204_raw);
                writer.Write(Unk_205_raw);
                writer.Write(Unk_206_raw);
                writer.Write(Unk_207_raw);
                writer.Write(Unk_208_raw);
                writer.Write(Unk_209_raw);
                writer.Write(Unk_210_raw);
                writer.Write(Unk_211_raw);
                writer.Write(Unk_212_raw);
                writer.Write(Unk_213_raw);
                writer.Write(Unk_214_raw);
                writer.Write(Unk_215_raw);
                writer.Write(Unk_216_raw);
                writer.Write(Unk_217_raw);
                writer.Write(Unk_218_raw);
                writer.Write(Unk_219_raw);
                writer.Write(Unk_220_raw);
                writer.Write(Unk_221_raw);
                writer.Write(Unk_222_raw);
                writer.Write(Unk_223_raw);
                writer.Write(Unk_224_raw);
                writer.Write(Unk_225_raw);
                writer.Write(Unk_226_raw);
                writer.Write(Unk_227_raw);
                writer.Write(Unk_228_raw);
                writer.Write(Unk_229_raw);
                writer.Write(Unk_230_raw);
                writer.Write(Unk_231_raw);
                writer.Write(Unk_232_raw);
                writer.Write(Unk_233_raw);
                writer.Write(Unk_234_raw);
                writer.Write(Unk_235_raw);
                writer.Write(Unk_236_raw);
                writer.Write(Unk_237_raw);
                writer.Write(Unk_238_raw);
                writer.Write(Unk_239_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
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
                    new MultiStructItemCustomView(this, "Unk 121", "Unk_121"),
                    new MultiStructItemCustomView(this, "Unk 122", "Unk_122"),
                    new MultiStructItemCustomView(this, "Unk 123", "Unk_123"),
                    new MultiStructItemCustomView(this, "Unk 124", "Unk_124"),
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
                    new MultiStructItemCustomView(this, "Unk 158", "Unk_158"),
                    new MultiStructItemCustomView(this, "Unk 159", "Unk_159"),
                    new MultiStructItemCustomView(this, "Unk 160", "Unk_160"),
                    new MultiStructItemCustomView(this, "Unk 161", "Unk_161"),
                    new MultiStructItemCustomView(this, "Unk 162", "Unk_162"),
                    new MultiStructItemCustomView(this, "Unk 163", "Unk_163"),
                    new MultiStructItemCustomView(this, "Unk 164", "Unk_164"),
                    new MultiStructItemCustomView(this, "Unk 165", "Unk_165"),
                    new MultiStructItemCustomView(this, "Unk 166", "Unk_166"),
                    new MultiStructItemCustomView(this, "Unk 167", "Unk_167"),
                    new MultiStructItemCustomView(this, "Unk 168", "Unk_168"),
                    new MultiStructItemCustomView(this, "Unk 169", "Unk_169"),
                    new MultiStructItemCustomView(this, "Unk 170", "Unk_170"),
                    new MultiStructItemCustomView(this, "Unk 171", "Unk_171"),
                    new MultiStructItemCustomView(this, "Unk 172", "Unk_172"),
                    new MultiStructItemCustomView(this, "Unk 173", "Unk_173"),
                    new MultiStructItemCustomView(this, "Unk 174", "Unk_174"),
                    new MultiStructItemCustomView(this, "Unk 175", "Unk_175"),
                    new MultiStructItemCustomView(this, "Unk 176", "Unk_176"),
                    new MultiStructItemCustomView(this, "Unk 177", "Unk_177"),
                    new MultiStructItemCustomView(this, "Unk 178", "Unk_178"),
                    new MultiStructItemCustomView(this, "Unk 179", "Unk_179"),
                    new MultiStructItemCustomView(this, "Unk 180", "Unk_180"),
                    new MultiStructItemCustomView(this, "Unk 181", "Unk_181"),
                    new MultiStructItemCustomView(this, "Unk 182", "Unk_182"),
                    new MultiStructItemCustomView(this, "Unk 183", "Unk_183"),
                    new MultiStructItemCustomView(this, "Unk 184", "Unk_184"),
                    new MultiStructItemCustomView(this, "Unk 185", "Unk_185"),
                    new MultiStructItemCustomView(this, "Unk 186", "Unk_186"),
                    new MultiStructItemCustomView(this, "Unk 187", "Unk_187"),
                    new MultiStructItemCustomView(this, "Unk 188", "Unk_188"),
                    new MultiStructItemCustomView(this, "Unk 189", "Unk_189"),
                    new MultiStructItemCustomView(this, "Unk 190", "Unk_190"),
                    new MultiStructItemCustomView(this, "Unk 191", "Unk_191"),
                    new MultiStructItemCustomView(this, "Unk 192", "Unk_192"),
                    new MultiStructItemCustomView(this, "Unk 193", "Unk_193"),
                    new MultiStructItemCustomView(this, "Unk 194", "Unk_194"),
                    new MultiStructItemCustomView(this, "Unk 195", "Unk_195"),
                    new MultiStructItemCustomView(this, "Unk 196", "Unk_196"),
                    new MultiStructItemCustomView(this, "Unk 197", "Unk_197"),
                    new MultiStructItemCustomView(this, "Unk 198", "Unk_198"),
                    new MultiStructItemCustomView(this, "Unk 199", "Unk_199"),
                    new MultiStructItemCustomView(this, "Unk 200", "Unk_200"),
                    new MultiStructItemCustomView(this, "Unk 201", "Unk_201"),
                    new MultiStructItemCustomView(this, "Unk 202", "Unk_202"),
                    new MultiStructItemCustomView(this, "Unk 203", "Unk_203"),
                    new MultiStructItemCustomView(this, "Unk 204", "Unk_204"),
                    new MultiStructItemCustomView(this, "Unk 205", "Unk_205"),
                    new MultiStructItemCustomView(this, "Unk 206", "Unk_206"),
                    new MultiStructItemCustomView(this, "Unk 207", "Unk_207"),
                    new MultiStructItemCustomView(this, "Unk 208", "Unk_208"),
                    new MultiStructItemCustomView(this, "Unk 209", "Unk_209"),
                    new MultiStructItemCustomView(this, "Unk 210", "Unk_210"),
                    new MultiStructItemCustomView(this, "Unk 211", "Unk_211"),
                    new MultiStructItemCustomView(this, "Unk 212", "Unk_212"),
                    new MultiStructItemCustomView(this, "Unk 213", "Unk_213"),
                    new MultiStructItemCustomView(this, "Unk 214", "Unk_214"),
                    new MultiStructItemCustomView(this, "Unk 215", "Unk_215"),
                    new MultiStructItemCustomView(this, "Unk 216", "Unk_216"),
                    new MultiStructItemCustomView(this, "Unk 217", "Unk_217"),
                    new MultiStructItemCustomView(this, "Unk 218", "Unk_218"),
                    new MultiStructItemCustomView(this, "Unk 219", "Unk_219"),
                    new MultiStructItemCustomView(this, "Unk 220", "Unk_220"),
                    new MultiStructItemCustomView(this, "Unk 221", "Unk_221"),
                    new MultiStructItemCustomView(this, "Unk 222", "Unk_222"),
                    new MultiStructItemCustomView(this, "Unk 223", "Unk_223"),
                    new MultiStructItemCustomView(this, "Unk 224", "Unk_224"),
                    new MultiStructItemCustomView(this, "Unk 225", "Unk_225"),
                    new MultiStructItemCustomView(this, "Unk 226", "Unk_226"),
                    new MultiStructItemCustomView(this, "Unk 227", "Unk_227"),
                    new MultiStructItemCustomView(this, "Unk 228", "Unk_228"),
                    new MultiStructItemCustomView(this, "Unk 229", "Unk_229"),
                    new MultiStructItemCustomView(this, "Unk 230", "Unk_230"),
                    new MultiStructItemCustomView(this, "Unk 231", "Unk_231"),
                    new MultiStructItemCustomView(this, "Unk 232", "Unk_232"),
                    new MultiStructItemCustomView(this, "Unk 233", "Unk_233"),
                    new MultiStructItemCustomView(this, "Unk 234", "Unk_234"),
                    new MultiStructItemCustomView(this, "Unk 235", "Unk_235"),
                    new MultiStructItemCustomView(this, "Unk 236", "Unk_236"),
                    new MultiStructItemCustomView(this, "Unk 237", "Unk_237"),
                    new MultiStructItemCustomView(this, "Unk 238", "Unk_238"),
                    new MultiStructItemCustomView(this, "Unk 239", "Unk_239"),
                };
            }
        }

        public partial class Unk_Arr_3 : MhwStructItem {
            public const ulong FixedSizeCount = 16;
            public const string GridName = "Unk Arr 3";

            protected float Unk_1_raw;
            public const string Unk_1_displayName = "Unk 1";
            public const int Unk_1_sortIndex = 50;
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
            public const int Unk_2_sortIndex = 100;
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
            public const int Unk_3_sortIndex = 150;
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

            protected float Unk_5_raw;
            public const string Unk_5_displayName = "Unk 5";
            public const int Unk_5_sortIndex = 250;
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

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
                var count = 16UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Unk_Arr_3 LoadData(BinaryReader reader, ulong i) {
                var data = new Unk_Arr_3();
                data.Index = i;
                data.Unk_1_raw = reader.ReadSingle();
                data.Unk_2_raw = reader.ReadSingle();
                data.Unk_3_raw = reader.ReadSingle();
                data.Unk_4_raw = reader.ReadSingle();
                data.Unk_5_raw = reader.ReadSingle();
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

        public partial class Unk_Arr_4 : MhwStructItem {
            public const ulong FixedSizeCount = 4;
            public const string GridName = "Unk Arr 4";

            protected float Unk_1_raw;
            public const string Unk_1_displayName = "Unk 1";
            public const int Unk_1_sortIndex = 50;
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

            protected uint Unk_2_raw;
            public const string Unk_2_displayName = "Unk 2";
            public const int Unk_2_sortIndex = 100;
            [SortOrder(Unk_2_sortIndex)]
            [DisplayName(Unk_2_displayName)]
            public virtual uint Unk_2 {
                get => Unk_2_raw;
                set {
                    if (Unk_2_raw == value) return;
                    Unk_2_raw = value;
                    OnPropertyChanged(nameof(Unk_2));
                }
            }

            protected float Unk_3_raw;
            public const string Unk_3_displayName = "Unk 3";
            public const int Unk_3_sortIndex = 150;
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

            protected float Unk_5_raw;
            public const string Unk_5_displayName = "Unk 5";
            public const int Unk_5_sortIndex = 250;
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
            public const int Unk_6_sortIndex = 300;
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

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
                var count = 4UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Unk_Arr_4 LoadData(BinaryReader reader, ulong i) {
                var data = new Unk_Arr_4();
                data.Index = i;
                data.Unk_1_raw = reader.ReadSingle();
                data.Unk_2_raw = reader.ReadUInt32();
                data.Unk_3_raw = reader.ReadSingle();
                data.Unk_4_raw = reader.ReadSingle();
                data.Unk_5_raw = reader.ReadSingle();
                data.Unk_6_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_1_raw);
                writer.Write(Unk_2_raw);
                writer.Write(Unk_3_raw);
                writer.Write(Unk_4_raw);
                writer.Write(Unk_5_raw);
                writer.Write(Unk_6_raw);
            }
        }

        public partial class W13p_Params_6_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView> {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W13p Params (6)";

            protected float Unk_240_raw;
            public const string Unk_240_displayName = "Unk 240";
            public const int Unk_240_sortIndex = 50;
            [SortOrder(Unk_240_sortIndex)]
            [DisplayName(Unk_240_displayName)]
            public virtual float Unk_240 {
                get => Unk_240_raw;
                set {
                    if (Unk_240_raw == value) return;
                    Unk_240_raw = value;
                    OnPropertyChanged(nameof(Unk_240));
                }
            }

            protected float Unk_241_raw;
            public const string Unk_241_displayName = "Unk 241";
            public const int Unk_241_sortIndex = 100;
            [SortOrder(Unk_241_sortIndex)]
            [DisplayName(Unk_241_displayName)]
            public virtual float Unk_241 {
                get => Unk_241_raw;
                set {
                    if (Unk_241_raw == value) return;
                    Unk_241_raw = value;
                    OnPropertyChanged(nameof(Unk_241));
                }
            }

            protected float Unk_242_raw;
            public const string Unk_242_displayName = "Unk 242";
            public const int Unk_242_sortIndex = 150;
            [SortOrder(Unk_242_sortIndex)]
            [DisplayName(Unk_242_displayName)]
            public virtual float Unk_242 {
                get => Unk_242_raw;
                set {
                    if (Unk_242_raw == value) return;
                    Unk_242_raw = value;
                    OnPropertyChanged(nameof(Unk_242));
                }
            }

            protected float Unk_243_raw;
            public const string Unk_243_displayName = "Unk 243";
            public const int Unk_243_sortIndex = 200;
            [SortOrder(Unk_243_sortIndex)]
            [DisplayName(Unk_243_displayName)]
            public virtual float Unk_243 {
                get => Unk_243_raw;
                set {
                    if (Unk_243_raw == value) return;
                    Unk_243_raw = value;
                    OnPropertyChanged(nameof(Unk_243));
                }
            }

            protected float Unk_244_raw;
            public const string Unk_244_displayName = "Unk 244";
            public const int Unk_244_sortIndex = 250;
            [SortOrder(Unk_244_sortIndex)]
            [DisplayName(Unk_244_displayName)]
            public virtual float Unk_244 {
                get => Unk_244_raw;
                set {
                    if (Unk_244_raw == value) return;
                    Unk_244_raw = value;
                    OnPropertyChanged(nameof(Unk_244));
                }
            }

            protected float Unk_245_raw;
            public const string Unk_245_displayName = "Unk 245";
            public const int Unk_245_sortIndex = 300;
            [SortOrder(Unk_245_sortIndex)]
            [DisplayName(Unk_245_displayName)]
            public virtual float Unk_245 {
                get => Unk_245_raw;
                set {
                    if (Unk_245_raw == value) return;
                    Unk_245_raw = value;
                    OnPropertyChanged(nameof(Unk_245));
                }
            }

            protected float Unk_246_raw;
            public const string Unk_246_displayName = "Unk 246";
            public const int Unk_246_sortIndex = 350;
            [SortOrder(Unk_246_sortIndex)]
            [DisplayName(Unk_246_displayName)]
            public virtual float Unk_246 {
                get => Unk_246_raw;
                set {
                    if (Unk_246_raw == value) return;
                    Unk_246_raw = value;
                    OnPropertyChanged(nameof(Unk_246));
                }
            }

            protected float Unk_247_raw;
            public const string Unk_247_displayName = "Unk 247";
            public const int Unk_247_sortIndex = 400;
            [SortOrder(Unk_247_sortIndex)]
            [DisplayName(Unk_247_displayName)]
            public virtual float Unk_247 {
                get => Unk_247_raw;
                set {
                    if (Unk_247_raw == value) return;
                    Unk_247_raw = value;
                    OnPropertyChanged(nameof(Unk_247));
                }
            }

            protected float Unk_248_raw;
            public const string Unk_248_displayName = "Unk 248";
            public const int Unk_248_sortIndex = 450;
            [SortOrder(Unk_248_sortIndex)]
            [DisplayName(Unk_248_displayName)]
            public virtual float Unk_248 {
                get => Unk_248_raw;
                set {
                    if (Unk_248_raw == value) return;
                    Unk_248_raw = value;
                    OnPropertyChanged(nameof(Unk_248));
                }
            }

            protected float Unk_249_raw;
            public const string Unk_249_displayName = "Unk 249";
            public const int Unk_249_sortIndex = 500;
            [SortOrder(Unk_249_sortIndex)]
            [DisplayName(Unk_249_displayName)]
            public virtual float Unk_249 {
                get => Unk_249_raw;
                set {
                    if (Unk_249_raw == value) return;
                    Unk_249_raw = value;
                    OnPropertyChanged(nameof(Unk_249));
                }
            }

            protected float Unk_250_raw;
            public const string Unk_250_displayName = "Unk 250";
            public const int Unk_250_sortIndex = 550;
            [SortOrder(Unk_250_sortIndex)]
            [DisplayName(Unk_250_displayName)]
            public virtual float Unk_250 {
                get => Unk_250_raw;
                set {
                    if (Unk_250_raw == value) return;
                    Unk_250_raw = value;
                    OnPropertyChanged(nameof(Unk_250));
                }
            }

            protected float Unk_251_raw;
            public const string Unk_251_displayName = "Unk 251";
            public const int Unk_251_sortIndex = 600;
            [SortOrder(Unk_251_sortIndex)]
            [DisplayName(Unk_251_displayName)]
            public virtual float Unk_251 {
                get => Unk_251_raw;
                set {
                    if (Unk_251_raw == value) return;
                    Unk_251_raw = value;
                    OnPropertyChanged(nameof(Unk_251));
                }
            }

            protected float Unk_252_raw;
            public const string Unk_252_displayName = "Unk 252";
            public const int Unk_252_sortIndex = 650;
            [SortOrder(Unk_252_sortIndex)]
            [DisplayName(Unk_252_displayName)]
            public virtual float Unk_252 {
                get => Unk_252_raw;
                set {
                    if (Unk_252_raw == value) return;
                    Unk_252_raw = value;
                    OnPropertyChanged(nameof(Unk_252));
                }
            }

            protected float Unk_253_raw;
            public const string Unk_253_displayName = "Unk 253";
            public const int Unk_253_sortIndex = 700;
            [SortOrder(Unk_253_sortIndex)]
            [DisplayName(Unk_253_displayName)]
            public virtual float Unk_253 {
                get => Unk_253_raw;
                set {
                    if (Unk_253_raw == value) return;
                    Unk_253_raw = value;
                    OnPropertyChanged(nameof(Unk_253));
                }
            }

            protected float Unk_254_raw;
            public const string Unk_254_displayName = "Unk 254";
            public const int Unk_254_sortIndex = 750;
            [SortOrder(Unk_254_sortIndex)]
            [DisplayName(Unk_254_displayName)]
            public virtual float Unk_254 {
                get => Unk_254_raw;
                set {
                    if (Unk_254_raw == value) return;
                    Unk_254_raw = value;
                    OnPropertyChanged(nameof(Unk_254));
                }
            }

            protected float Unk_255_raw;
            public const string Unk_255_displayName = "Unk 255";
            public const int Unk_255_sortIndex = 800;
            [SortOrder(Unk_255_sortIndex)]
            [DisplayName(Unk_255_displayName)]
            public virtual float Unk_255 {
                get => Unk_255_raw;
                set {
                    if (Unk_255_raw == value) return;
                    Unk_255_raw = value;
                    OnPropertyChanged(nameof(Unk_255));
                }
            }

            protected float Unk_256_raw;
            public const string Unk_256_displayName = "Unk 256";
            public const int Unk_256_sortIndex = 850;
            [SortOrder(Unk_256_sortIndex)]
            [DisplayName(Unk_256_displayName)]
            public virtual float Unk_256 {
                get => Unk_256_raw;
                set {
                    if (Unk_256_raw == value) return;
                    Unk_256_raw = value;
                    OnPropertyChanged(nameof(Unk_256));
                }
            }

            protected float Unk_257_raw;
            public const string Unk_257_displayName = "Unk 257";
            public const int Unk_257_sortIndex = 900;
            [SortOrder(Unk_257_sortIndex)]
            [DisplayName(Unk_257_displayName)]
            public virtual float Unk_257 {
                get => Unk_257_raw;
                set {
                    if (Unk_257_raw == value) return;
                    Unk_257_raw = value;
                    OnPropertyChanged(nameof(Unk_257));
                }
            }

            protected float Unk_258_raw;
            public const string Unk_258_displayName = "Unk 258";
            public const int Unk_258_sortIndex = 950;
            [SortOrder(Unk_258_sortIndex)]
            [DisplayName(Unk_258_displayName)]
            public virtual float Unk_258 {
                get => Unk_258_raw;
                set {
                    if (Unk_258_raw == value) return;
                    Unk_258_raw = value;
                    OnPropertyChanged(nameof(Unk_258));
                }
            }

            protected float Unk_259_raw;
            public const string Unk_259_displayName = "Unk 259";
            public const int Unk_259_sortIndex = 1000;
            [SortOrder(Unk_259_sortIndex)]
            [DisplayName(Unk_259_displayName)]
            public virtual float Unk_259 {
                get => Unk_259_raw;
                set {
                    if (Unk_259_raw == value) return;
                    Unk_259_raw = value;
                    OnPropertyChanged(nameof(Unk_259));
                }
            }

            protected float Unk_260_raw;
            public const string Unk_260_displayName = "Unk 260";
            public const int Unk_260_sortIndex = 1050;
            [SortOrder(Unk_260_sortIndex)]
            [DisplayName(Unk_260_displayName)]
            public virtual float Unk_260 {
                get => Unk_260_raw;
                set {
                    if (Unk_260_raw == value) return;
                    Unk_260_raw = value;
                    OnPropertyChanged(nameof(Unk_260));
                }
            }

            protected float Unk_261_raw;
            public const string Unk_261_displayName = "Unk 261";
            public const int Unk_261_sortIndex = 1100;
            [SortOrder(Unk_261_sortIndex)]
            [DisplayName(Unk_261_displayName)]
            public virtual float Unk_261 {
                get => Unk_261_raw;
                set {
                    if (Unk_261_raw == value) return;
                    Unk_261_raw = value;
                    OnPropertyChanged(nameof(Unk_261));
                }
            }

            protected float Unk_262_raw;
            public const string Unk_262_displayName = "Unk 262";
            public const int Unk_262_sortIndex = 1150;
            [SortOrder(Unk_262_sortIndex)]
            [DisplayName(Unk_262_displayName)]
            public virtual float Unk_262 {
                get => Unk_262_raw;
                set {
                    if (Unk_262_raw == value) return;
                    Unk_262_raw = value;
                    OnPropertyChanged(nameof(Unk_262));
                }
            }

            protected float Unk_263_raw;
            public const string Unk_263_displayName = "Unk 263";
            public const int Unk_263_sortIndex = 1200;
            [SortOrder(Unk_263_sortIndex)]
            [DisplayName(Unk_263_displayName)]
            public virtual float Unk_263 {
                get => Unk_263_raw;
                set {
                    if (Unk_263_raw == value) return;
                    Unk_263_raw = value;
                    OnPropertyChanged(nameof(Unk_263));
                }
            }

            protected float Unk_264_raw;
            public const string Unk_264_displayName = "Unk 264";
            public const int Unk_264_sortIndex = 1250;
            [SortOrder(Unk_264_sortIndex)]
            [DisplayName(Unk_264_displayName)]
            public virtual float Unk_264 {
                get => Unk_264_raw;
                set {
                    if (Unk_264_raw == value) return;
                    Unk_264_raw = value;
                    OnPropertyChanged(nameof(Unk_264));
                }
            }

            protected float Unk_265_raw;
            public const string Unk_265_displayName = "Unk 265";
            public const int Unk_265_sortIndex = 1300;
            [SortOrder(Unk_265_sortIndex)]
            [DisplayName(Unk_265_displayName)]
            public virtual float Unk_265 {
                get => Unk_265_raw;
                set {
                    if (Unk_265_raw == value) return;
                    Unk_265_raw = value;
                    OnPropertyChanged(nameof(Unk_265));
                }
            }

            protected float Unk_266_raw;
            public const string Unk_266_displayName = "Unk 266";
            public const int Unk_266_sortIndex = 1350;
            [SortOrder(Unk_266_sortIndex)]
            [DisplayName(Unk_266_displayName)]
            public virtual float Unk_266 {
                get => Unk_266_raw;
                set {
                    if (Unk_266_raw == value) return;
                    Unk_266_raw = value;
                    OnPropertyChanged(nameof(Unk_266));
                }
            }

            protected float Unk_267_raw;
            public const string Unk_267_displayName = "Unk 267";
            public const int Unk_267_sortIndex = 1400;
            [SortOrder(Unk_267_sortIndex)]
            [DisplayName(Unk_267_displayName)]
            public virtual float Unk_267 {
                get => Unk_267_raw;
                set {
                    if (Unk_267_raw == value) return;
                    Unk_267_raw = value;
                    OnPropertyChanged(nameof(Unk_267));
                }
            }

            protected float Unk_268_raw;
            public const string Unk_268_displayName = "Unk 268";
            public const int Unk_268_sortIndex = 1450;
            [SortOrder(Unk_268_sortIndex)]
            [DisplayName(Unk_268_displayName)]
            public virtual float Unk_268 {
                get => Unk_268_raw;
                set {
                    if (Unk_268_raw == value) return;
                    Unk_268_raw = value;
                    OnPropertyChanged(nameof(Unk_268));
                }
            }

            protected float Unk_269_raw;
            public const string Unk_269_displayName = "Unk 269";
            public const int Unk_269_sortIndex = 1500;
            [SortOrder(Unk_269_sortIndex)]
            [DisplayName(Unk_269_displayName)]
            public virtual float Unk_269 {
                get => Unk_269_raw;
                set {
                    if (Unk_269_raw == value) return;
                    Unk_269_raw = value;
                    OnPropertyChanged(nameof(Unk_269));
                }
            }

            protected float Unk_270_raw;
            public const string Unk_270_displayName = "Unk 270";
            public const int Unk_270_sortIndex = 1550;
            [SortOrder(Unk_270_sortIndex)]
            [DisplayName(Unk_270_displayName)]
            public virtual float Unk_270 {
                get => Unk_270_raw;
                set {
                    if (Unk_270_raw == value) return;
                    Unk_270_raw = value;
                    OnPropertyChanged(nameof(Unk_270));
                }
            }

            protected float Unk_271_raw;
            public const string Unk_271_displayName = "Unk 271";
            public const int Unk_271_sortIndex = 1600;
            [SortOrder(Unk_271_sortIndex)]
            [DisplayName(Unk_271_displayName)]
            public virtual float Unk_271 {
                get => Unk_271_raw;
                set {
                    if (Unk_271_raw == value) return;
                    Unk_271_raw = value;
                    OnPropertyChanged(nameof(Unk_271));
                }
            }

            protected float Unk_272_raw;
            public const string Unk_272_displayName = "Unk 272";
            public const int Unk_272_sortIndex = 1650;
            [SortOrder(Unk_272_sortIndex)]
            [DisplayName(Unk_272_displayName)]
            public virtual float Unk_272 {
                get => Unk_272_raw;
                set {
                    if (Unk_272_raw == value) return;
                    Unk_272_raw = value;
                    OnPropertyChanged(nameof(Unk_272));
                }
            }

            protected float Unk_273_raw;
            public const string Unk_273_displayName = "Unk 273";
            public const int Unk_273_sortIndex = 1700;
            [SortOrder(Unk_273_sortIndex)]
            [DisplayName(Unk_273_displayName)]
            public virtual float Unk_273 {
                get => Unk_273_raw;
                set {
                    if (Unk_273_raw == value) return;
                    Unk_273_raw = value;
                    OnPropertyChanged(nameof(Unk_273));
                }
            }

            protected float Close_range_Up_active_range_1_raw;
            public const string Close_range_Up_active_range_1_displayName = "Close range Up active range 1";
            public const int Close_range_Up_active_range_1_sortIndex = 1750;
            [SortOrder(Close_range_Up_active_range_1_sortIndex)]
            [DisplayName(Close_range_Up_active_range_1_displayName)]
            public virtual float Close_range_Up_active_range_1 {
                get => Close_range_Up_active_range_1_raw;
                set {
                    if (Close_range_Up_active_range_1_raw == value) return;
                    Close_range_Up_active_range_1_raw = value;
                    OnPropertyChanged(nameof(Close_range_Up_active_range_1));
                }
            }

            protected float Close_range_Up_active_range_2_raw;
            public const string Close_range_Up_active_range_2_displayName = "Close range Up active range 2";
            public const int Close_range_Up_active_range_2_sortIndex = 1800;
            [SortOrder(Close_range_Up_active_range_2_sortIndex)]
            [DisplayName(Close_range_Up_active_range_2_displayName)]
            public virtual float Close_range_Up_active_range_2 {
                get => Close_range_Up_active_range_2_raw;
                set {
                    if (Close_range_Up_active_range_2_raw == value) return;
                    Close_range_Up_active_range_2_raw = value;
                    OnPropertyChanged(nameof(Close_range_Up_active_range_2));
                }
            }

            protected float Close_range_Up_active_range_3_raw;
            public const string Close_range_Up_active_range_3_displayName = "Close range Up active range 3";
            public const int Close_range_Up_active_range_3_sortIndex = 1850;
            [SortOrder(Close_range_Up_active_range_3_sortIndex)]
            [DisplayName(Close_range_Up_active_range_3_displayName)]
            public virtual float Close_range_Up_active_range_3 {
                get => Close_range_Up_active_range_3_raw;
                set {
                    if (Close_range_Up_active_range_3_raw == value) return;
                    Close_range_Up_active_range_3_raw = value;
                    OnPropertyChanged(nameof(Close_range_Up_active_range_3));
                }
            }

            protected float Close_range_Up_active_range_4_raw;
            public const string Close_range_Up_active_range_4_displayName = "Close range Up active range 4";
            public const int Close_range_Up_active_range_4_sortIndex = 1900;
            [SortOrder(Close_range_Up_active_range_4_sortIndex)]
            [DisplayName(Close_range_Up_active_range_4_displayName)]
            public virtual float Close_range_Up_active_range_4 {
                get => Close_range_Up_active_range_4_raw;
                set {
                    if (Close_range_Up_active_range_4_raw == value) return;
                    Close_range_Up_active_range_4_raw = value;
                    OnPropertyChanged(nameof(Close_range_Up_active_range_4));
                }
            }

            protected float Close_range_Up_Modifier_1_raw;
            public const string Close_range_Up_Modifier_1_displayName = "Close range Up Modifier 1";
            public const int Close_range_Up_Modifier_1_sortIndex = 1950;
            [SortOrder(Close_range_Up_Modifier_1_sortIndex)]
            [DisplayName(Close_range_Up_Modifier_1_displayName)]
            public virtual float Close_range_Up_Modifier_1 {
                get => Close_range_Up_Modifier_1_raw;
                set {
                    if (Close_range_Up_Modifier_1_raw == value) return;
                    Close_range_Up_Modifier_1_raw = value;
                    OnPropertyChanged(nameof(Close_range_Up_Modifier_1));
                }
            }

            protected float Close_range_Up_Modifier_2_raw;
            public const string Close_range_Up_Modifier_2_displayName = "Close range Up Modifier 2";
            public const int Close_range_Up_Modifier_2_sortIndex = 2000;
            [SortOrder(Close_range_Up_Modifier_2_sortIndex)]
            [DisplayName(Close_range_Up_Modifier_2_displayName)]
            public virtual float Close_range_Up_Modifier_2 {
                get => Close_range_Up_Modifier_2_raw;
                set {
                    if (Close_range_Up_Modifier_2_raw == value) return;
                    Close_range_Up_Modifier_2_raw = value;
                    OnPropertyChanged(nameof(Close_range_Up_Modifier_2));
                }
            }

            protected float Close_range_Up_Modifier_3_raw;
            public const string Close_range_Up_Modifier_3_displayName = "Close range Up Modifier 3";
            public const int Close_range_Up_Modifier_3_sortIndex = 2050;
            [SortOrder(Close_range_Up_Modifier_3_sortIndex)]
            [DisplayName(Close_range_Up_Modifier_3_displayName)]
            public virtual float Close_range_Up_Modifier_3 {
                get => Close_range_Up_Modifier_3_raw;
                set {
                    if (Close_range_Up_Modifier_3_raw == value) return;
                    Close_range_Up_Modifier_3_raw = value;
                    OnPropertyChanged(nameof(Close_range_Up_Modifier_3));
                }
            }

            protected float Close_range_Up_Modifier_4_raw;
            public const string Close_range_Up_Modifier_4_displayName = "Close range Up Modifier 4";
            public const int Close_range_Up_Modifier_4_sortIndex = 2100;
            [SortOrder(Close_range_Up_Modifier_4_sortIndex)]
            [DisplayName(Close_range_Up_Modifier_4_displayName)]
            public virtual float Close_range_Up_Modifier_4 {
                get => Close_range_Up_Modifier_4_raw;
                set {
                    if (Close_range_Up_Modifier_4_raw == value) return;
                    Close_range_Up_Modifier_4_raw = value;
                    OnPropertyChanged(nameof(Close_range_Up_Modifier_4));
                }
            }

            protected float Ranged_Attack_Up_active_distance_1_raw;
            public const string Ranged_Attack_Up_active_distance_1_displayName = "Ranged Attack Up active distance 1";
            public const int Ranged_Attack_Up_active_distance_1_sortIndex = 2150;
            [SortOrder(Ranged_Attack_Up_active_distance_1_sortIndex)]
            [DisplayName(Ranged_Attack_Up_active_distance_1_displayName)]
            public virtual float Ranged_Attack_Up_active_distance_1 {
                get => Ranged_Attack_Up_active_distance_1_raw;
                set {
                    if (Ranged_Attack_Up_active_distance_1_raw == value) return;
                    Ranged_Attack_Up_active_distance_1_raw = value;
                    OnPropertyChanged(nameof(Ranged_Attack_Up_active_distance_1));
                }
            }

            protected float Ranged_Attack_Up_active_distance_2_raw;
            public const string Ranged_Attack_Up_active_distance_2_displayName = "Ranged Attack Up active distance 2";
            public const int Ranged_Attack_Up_active_distance_2_sortIndex = 2200;
            [SortOrder(Ranged_Attack_Up_active_distance_2_sortIndex)]
            [DisplayName(Ranged_Attack_Up_active_distance_2_displayName)]
            public virtual float Ranged_Attack_Up_active_distance_2 {
                get => Ranged_Attack_Up_active_distance_2_raw;
                set {
                    if (Ranged_Attack_Up_active_distance_2_raw == value) return;
                    Ranged_Attack_Up_active_distance_2_raw = value;
                    OnPropertyChanged(nameof(Ranged_Attack_Up_active_distance_2));
                }
            }

            protected float Ranged_Attack_Up_active_distance_3_raw;
            public const string Ranged_Attack_Up_active_distance_3_displayName = "Ranged Attack Up active distance 3";
            public const int Ranged_Attack_Up_active_distance_3_sortIndex = 2250;
            [SortOrder(Ranged_Attack_Up_active_distance_3_sortIndex)]
            [DisplayName(Ranged_Attack_Up_active_distance_3_displayName)]
            public virtual float Ranged_Attack_Up_active_distance_3 {
                get => Ranged_Attack_Up_active_distance_3_raw;
                set {
                    if (Ranged_Attack_Up_active_distance_3_raw == value) return;
                    Ranged_Attack_Up_active_distance_3_raw = value;
                    OnPropertyChanged(nameof(Ranged_Attack_Up_active_distance_3));
                }
            }

            protected float Ranged_Attack_Up_active_distance_4_raw;
            public const string Ranged_Attack_Up_active_distance_4_displayName = "Ranged Attack Up active distance 4";
            public const int Ranged_Attack_Up_active_distance_4_sortIndex = 2300;
            [SortOrder(Ranged_Attack_Up_active_distance_4_sortIndex)]
            [DisplayName(Ranged_Attack_Up_active_distance_4_displayName)]
            public virtual float Ranged_Attack_Up_active_distance_4 {
                get => Ranged_Attack_Up_active_distance_4_raw;
                set {
                    if (Ranged_Attack_Up_active_distance_4_raw == value) return;
                    Ranged_Attack_Up_active_distance_4_raw = value;
                    OnPropertyChanged(nameof(Ranged_Attack_Up_active_distance_4));
                }
            }

            protected float Ranged_Attack_Up_Modifier_1_raw;
            public const string Ranged_Attack_Up_Modifier_1_displayName = "Ranged Attack Up Modifier 1";
            public const int Ranged_Attack_Up_Modifier_1_sortIndex = 2350;
            [SortOrder(Ranged_Attack_Up_Modifier_1_sortIndex)]
            [DisplayName(Ranged_Attack_Up_Modifier_1_displayName)]
            public virtual float Ranged_Attack_Up_Modifier_1 {
                get => Ranged_Attack_Up_Modifier_1_raw;
                set {
                    if (Ranged_Attack_Up_Modifier_1_raw == value) return;
                    Ranged_Attack_Up_Modifier_1_raw = value;
                    OnPropertyChanged(nameof(Ranged_Attack_Up_Modifier_1));
                }
            }

            protected float Ranged_Attack_Up_Modifier_2_raw;
            public const string Ranged_Attack_Up_Modifier_2_displayName = "Ranged Attack Up Modifier 2";
            public const int Ranged_Attack_Up_Modifier_2_sortIndex = 2400;
            [SortOrder(Ranged_Attack_Up_Modifier_2_sortIndex)]
            [DisplayName(Ranged_Attack_Up_Modifier_2_displayName)]
            public virtual float Ranged_Attack_Up_Modifier_2 {
                get => Ranged_Attack_Up_Modifier_2_raw;
                set {
                    if (Ranged_Attack_Up_Modifier_2_raw == value) return;
                    Ranged_Attack_Up_Modifier_2_raw = value;
                    OnPropertyChanged(nameof(Ranged_Attack_Up_Modifier_2));
                }
            }

            protected float Ranged_Attack_Up_Modifier_3_raw;
            public const string Ranged_Attack_Up_Modifier_3_displayName = "Ranged Attack Up Modifier 3";
            public const int Ranged_Attack_Up_Modifier_3_sortIndex = 2450;
            [SortOrder(Ranged_Attack_Up_Modifier_3_sortIndex)]
            [DisplayName(Ranged_Attack_Up_Modifier_3_displayName)]
            public virtual float Ranged_Attack_Up_Modifier_3 {
                get => Ranged_Attack_Up_Modifier_3_raw;
                set {
                    if (Ranged_Attack_Up_Modifier_3_raw == value) return;
                    Ranged_Attack_Up_Modifier_3_raw = value;
                    OnPropertyChanged(nameof(Ranged_Attack_Up_Modifier_3));
                }
            }

            protected float Ranged_Attack_Up_Modifier_4_raw;
            public const string Ranged_Attack_Up_Modifier_4_displayName = "Ranged Attack Up Modifier 4";
            public const int Ranged_Attack_Up_Modifier_4_sortIndex = 2500;
            [SortOrder(Ranged_Attack_Up_Modifier_4_sortIndex)]
            [DisplayName(Ranged_Attack_Up_Modifier_4_displayName)]
            public virtual float Ranged_Attack_Up_Modifier_4 {
                get => Ranged_Attack_Up_Modifier_4_raw;
                set {
                    if (Ranged_Attack_Up_Modifier_4_raw == value) return;
                    Ranged_Attack_Up_Modifier_4_raw = value;
                    OnPropertyChanged(nameof(Ranged_Attack_Up_Modifier_4));
                }
            }

            protected float Guard_Angle_Both_Sides__raw;
            public const string Guard_Angle_Both_Sides__displayName = "Guard Angle (Both Sides)";
            public const int Guard_Angle_Both_Sides__sortIndex = 2550;
            [SortOrder(Guard_Angle_Both_Sides__sortIndex)]
            [DisplayName(Guard_Angle_Both_Sides__displayName)]
            public virtual float Guard_Angle_Both_Sides_ {
                get => Guard_Angle_Both_Sides__raw;
                set {
                    if (Guard_Angle_Both_Sides__raw == value) return;
                    Guard_Angle_Both_Sides__raw = value;
                    OnPropertyChanged(nameof(Guard_Angle_Both_Sides_));
                }
            }

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W13p_Params_6_ LoadData(BinaryReader reader, ulong i) {
                var data = new W13p_Params_6_();
                data.Index = i;
                data.Unk_240_raw = reader.ReadSingle();
                data.Unk_241_raw = reader.ReadSingle();
                data.Unk_242_raw = reader.ReadSingle();
                data.Unk_243_raw = reader.ReadSingle();
                data.Unk_244_raw = reader.ReadSingle();
                data.Unk_245_raw = reader.ReadSingle();
                data.Unk_246_raw = reader.ReadSingle();
                data.Unk_247_raw = reader.ReadSingle();
                data.Unk_248_raw = reader.ReadSingle();
                data.Unk_249_raw = reader.ReadSingle();
                data.Unk_250_raw = reader.ReadSingle();
                data.Unk_251_raw = reader.ReadSingle();
                data.Unk_252_raw = reader.ReadSingle();
                data.Unk_253_raw = reader.ReadSingle();
                data.Unk_254_raw = reader.ReadSingle();
                data.Unk_255_raw = reader.ReadSingle();
                data.Unk_256_raw = reader.ReadSingle();
                data.Unk_257_raw = reader.ReadSingle();
                data.Unk_258_raw = reader.ReadSingle();
                data.Unk_259_raw = reader.ReadSingle();
                data.Unk_260_raw = reader.ReadSingle();
                data.Unk_261_raw = reader.ReadSingle();
                data.Unk_262_raw = reader.ReadSingle();
                data.Unk_263_raw = reader.ReadSingle();
                data.Unk_264_raw = reader.ReadSingle();
                data.Unk_265_raw = reader.ReadSingle();
                data.Unk_266_raw = reader.ReadSingle();
                data.Unk_267_raw = reader.ReadSingle();
                data.Unk_268_raw = reader.ReadSingle();
                data.Unk_269_raw = reader.ReadSingle();
                data.Unk_270_raw = reader.ReadSingle();
                data.Unk_271_raw = reader.ReadSingle();
                data.Unk_272_raw = reader.ReadSingle();
                data.Unk_273_raw = reader.ReadSingle();
                data.Close_range_Up_active_range_1_raw = reader.ReadSingle();
                data.Close_range_Up_active_range_2_raw = reader.ReadSingle();
                data.Close_range_Up_active_range_3_raw = reader.ReadSingle();
                data.Close_range_Up_active_range_4_raw = reader.ReadSingle();
                data.Close_range_Up_Modifier_1_raw = reader.ReadSingle();
                data.Close_range_Up_Modifier_2_raw = reader.ReadSingle();
                data.Close_range_Up_Modifier_3_raw = reader.ReadSingle();
                data.Close_range_Up_Modifier_4_raw = reader.ReadSingle();
                data.Ranged_Attack_Up_active_distance_1_raw = reader.ReadSingle();
                data.Ranged_Attack_Up_active_distance_2_raw = reader.ReadSingle();
                data.Ranged_Attack_Up_active_distance_3_raw = reader.ReadSingle();
                data.Ranged_Attack_Up_active_distance_4_raw = reader.ReadSingle();
                data.Ranged_Attack_Up_Modifier_1_raw = reader.ReadSingle();
                data.Ranged_Attack_Up_Modifier_2_raw = reader.ReadSingle();
                data.Ranged_Attack_Up_Modifier_3_raw = reader.ReadSingle();
                data.Ranged_Attack_Up_Modifier_4_raw = reader.ReadSingle();
                data.Guard_Angle_Both_Sides__raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_240_raw);
                writer.Write(Unk_241_raw);
                writer.Write(Unk_242_raw);
                writer.Write(Unk_243_raw);
                writer.Write(Unk_244_raw);
                writer.Write(Unk_245_raw);
                writer.Write(Unk_246_raw);
                writer.Write(Unk_247_raw);
                writer.Write(Unk_248_raw);
                writer.Write(Unk_249_raw);
                writer.Write(Unk_250_raw);
                writer.Write(Unk_251_raw);
                writer.Write(Unk_252_raw);
                writer.Write(Unk_253_raw);
                writer.Write(Unk_254_raw);
                writer.Write(Unk_255_raw);
                writer.Write(Unk_256_raw);
                writer.Write(Unk_257_raw);
                writer.Write(Unk_258_raw);
                writer.Write(Unk_259_raw);
                writer.Write(Unk_260_raw);
                writer.Write(Unk_261_raw);
                writer.Write(Unk_262_raw);
                writer.Write(Unk_263_raw);
                writer.Write(Unk_264_raw);
                writer.Write(Unk_265_raw);
                writer.Write(Unk_266_raw);
                writer.Write(Unk_267_raw);
                writer.Write(Unk_268_raw);
                writer.Write(Unk_269_raw);
                writer.Write(Unk_270_raw);
                writer.Write(Unk_271_raw);
                writer.Write(Unk_272_raw);
                writer.Write(Unk_273_raw);
                writer.Write(Close_range_Up_active_range_1_raw);
                writer.Write(Close_range_Up_active_range_2_raw);
                writer.Write(Close_range_Up_active_range_3_raw);
                writer.Write(Close_range_Up_active_range_4_raw);
                writer.Write(Close_range_Up_Modifier_1_raw);
                writer.Write(Close_range_Up_Modifier_2_raw);
                writer.Write(Close_range_Up_Modifier_3_raw);
                writer.Write(Close_range_Up_Modifier_4_raw);
                writer.Write(Ranged_Attack_Up_active_distance_1_raw);
                writer.Write(Ranged_Attack_Up_active_distance_2_raw);
                writer.Write(Ranged_Attack_Up_active_distance_3_raw);
                writer.Write(Ranged_Attack_Up_active_distance_4_raw);
                writer.Write(Ranged_Attack_Up_Modifier_1_raw);
                writer.Write(Ranged_Attack_Up_Modifier_2_raw);
                writer.Write(Ranged_Attack_Up_Modifier_3_raw);
                writer.Write(Ranged_Attack_Up_Modifier_4_raw);
                writer.Write(Guard_Angle_Both_Sides__raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Unk 240", "Unk_240"),
                    new MultiStructItemCustomView(this, "Unk 241", "Unk_241"),
                    new MultiStructItemCustomView(this, "Unk 242", "Unk_242"),
                    new MultiStructItemCustomView(this, "Unk 243", "Unk_243"),
                    new MultiStructItemCustomView(this, "Unk 244", "Unk_244"),
                    new MultiStructItemCustomView(this, "Unk 245", "Unk_245"),
                    new MultiStructItemCustomView(this, "Unk 246", "Unk_246"),
                    new MultiStructItemCustomView(this, "Unk 247", "Unk_247"),
                    new MultiStructItemCustomView(this, "Unk 248", "Unk_248"),
                    new MultiStructItemCustomView(this, "Unk 249", "Unk_249"),
                    new MultiStructItemCustomView(this, "Unk 250", "Unk_250"),
                    new MultiStructItemCustomView(this, "Unk 251", "Unk_251"),
                    new MultiStructItemCustomView(this, "Unk 252", "Unk_252"),
                    new MultiStructItemCustomView(this, "Unk 253", "Unk_253"),
                    new MultiStructItemCustomView(this, "Unk 254", "Unk_254"),
                    new MultiStructItemCustomView(this, "Unk 255", "Unk_255"),
                    new MultiStructItemCustomView(this, "Unk 256", "Unk_256"),
                    new MultiStructItemCustomView(this, "Unk 257", "Unk_257"),
                    new MultiStructItemCustomView(this, "Unk 258", "Unk_258"),
                    new MultiStructItemCustomView(this, "Unk 259", "Unk_259"),
                    new MultiStructItemCustomView(this, "Unk 260", "Unk_260"),
                    new MultiStructItemCustomView(this, "Unk 261", "Unk_261"),
                    new MultiStructItemCustomView(this, "Unk 262", "Unk_262"),
                    new MultiStructItemCustomView(this, "Unk 263", "Unk_263"),
                    new MultiStructItemCustomView(this, "Unk 264", "Unk_264"),
                    new MultiStructItemCustomView(this, "Unk 265", "Unk_265"),
                    new MultiStructItemCustomView(this, "Unk 266", "Unk_266"),
                    new MultiStructItemCustomView(this, "Unk 267", "Unk_267"),
                    new MultiStructItemCustomView(this, "Unk 268", "Unk_268"),
                    new MultiStructItemCustomView(this, "Unk 269", "Unk_269"),
                    new MultiStructItemCustomView(this, "Unk 270", "Unk_270"),
                    new MultiStructItemCustomView(this, "Unk 271", "Unk_271"),
                    new MultiStructItemCustomView(this, "Unk 272", "Unk_272"),
                    new MultiStructItemCustomView(this, "Unk 273", "Unk_273"),
                    new MultiStructItemCustomView(this, "Close range Up active range 1", "Close_range_Up_active_range_1"),
                    new MultiStructItemCustomView(this, "Close range Up active range 2", "Close_range_Up_active_range_2"),
                    new MultiStructItemCustomView(this, "Close range Up active range 3", "Close_range_Up_active_range_3"),
                    new MultiStructItemCustomView(this, "Close range Up active range 4", "Close_range_Up_active_range_4"),
                    new MultiStructItemCustomView(this, "Close range Up Modifier 1", "Close_range_Up_Modifier_1"),
                    new MultiStructItemCustomView(this, "Close range Up Modifier 2", "Close_range_Up_Modifier_2"),
                    new MultiStructItemCustomView(this, "Close range Up Modifier 3", "Close_range_Up_Modifier_3"),
                    new MultiStructItemCustomView(this, "Close range Up Modifier 4", "Close_range_Up_Modifier_4"),
                    new MultiStructItemCustomView(this, "Ranged Attack Up active distance 1", "Ranged_Attack_Up_active_distance_1"),
                    new MultiStructItemCustomView(this, "Ranged Attack Up active distance 2", "Ranged_Attack_Up_active_distance_2"),
                    new MultiStructItemCustomView(this, "Ranged Attack Up active distance 3", "Ranged_Attack_Up_active_distance_3"),
                    new MultiStructItemCustomView(this, "Ranged Attack Up active distance 4", "Ranged_Attack_Up_active_distance_4"),
                    new MultiStructItemCustomView(this, "Ranged Attack Up Modifier 1", "Ranged_Attack_Up_Modifier_1"),
                    new MultiStructItemCustomView(this, "Ranged Attack Up Modifier 2", "Ranged_Attack_Up_Modifier_2"),
                    new MultiStructItemCustomView(this, "Ranged Attack Up Modifier 3", "Ranged_Attack_Up_Modifier_3"),
                    new MultiStructItemCustomView(this, "Ranged Attack Up Modifier 4", "Ranged_Attack_Up_Modifier_4"),
                    new MultiStructItemCustomView(this, "Guard Angle (Both Sides)", "Guard_Angle_Both_Sides_"),
                };
            }
        }

        public partial class Number_of_Shield_Mods_Struct : MhwStructItem {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Number of Shield Mods Struct";
            public const bool IsHidden = true;

            protected uint Number_of_Shield_Mods_raw;
            public const string Number_of_Shield_Mods_displayName = "Number of Shield Mods";
            public const int Number_of_Shield_Mods_sortIndex = 50;
            [SortOrder(Number_of_Shield_Mods_sortIndex)]
            [DisplayName(Number_of_Shield_Mods_displayName)]
            public virtual uint Number_of_Shield_Mods {
                get => Number_of_Shield_Mods_raw;
                set {
                    if (Number_of_Shield_Mods_raw == value) return;
                    Number_of_Shield_Mods_raw = value;
                    OnPropertyChanged(nameof(Number_of_Shield_Mods));
                }
            }

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Number_of_Shield_Mods_Struct LoadData(BinaryReader reader, ulong i) {
                var data = new Number_of_Shield_Mods_Struct();
                data.Index = i;
                data.Number_of_Shield_Mods_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Number_of_Shield_Mods_raw);
            }
        }

        public partial class Shield_Mods : MhwStructItem {
            public const ulong FixedSizeCount = 0;
            public const string GridName = "Shield Mods";
            public const bool IsAddingAllowed = true;

            [SortOrder(-1)]
            [IsReadOnly]
            [DisplayName("X")]
            public string Delete => "X";

            protected byte Small_raw;
            public const string Small_displayName = "Small";
            public const int Small_sortIndex = 50;
            [SortOrder(Small_sortIndex)]
            [DisplayName(Small_displayName)]
            public virtual byte Small {
                get => Small_raw;
                set {
                    if (Small_raw == value) return;
                    Small_raw = value;
                    OnPropertyChanged(nameof(Small));
                }
            }

            protected byte Medium_raw;
            public const string Medium_displayName = "Medium";
            public const int Medium_sortIndex = 100;
            [SortOrder(Medium_sortIndex)]
            [DisplayName(Medium_displayName)]
            public virtual byte Medium {
                get => Medium_raw;
                set {
                    if (Medium_raw == value) return;
                    Medium_raw = value;
                    OnPropertyChanged(nameof(Medium));
                }
            }

            protected byte Large_raw;
            public const string Large_displayName = "Large";
            public const int Large_sortIndex = 150;
            [SortOrder(Large_sortIndex)]
            [DisplayName(Large_displayName)]
            public virtual byte Large {
                get => Large_raw;
                set {
                    if (Large_raw == value) return;
                    Large_raw = value;
                    OnPropertyChanged(nameof(Large));
                }
            }

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
                var countTarget = (Number_of_Shield_Mods_Struct) lastStruct.Last();
                var count = (ulong) countTarget.Number_of_Shield_Mods;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Shield_Mods LoadData(BinaryReader reader, ulong i) {
                var data = new Shield_Mods();
                data.Index = i;
                data.Small_raw = reader.ReadByte();
                data.Medium_raw = reader.ReadByte();
                data.Large_raw = reader.ReadByte();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Small_raw);
                writer.Write(Medium_raw);
                writer.Write(Large_raw);
            }
        }

        public partial class W13p_Params_7_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView> {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W13p Params (7)";

            protected float Unk_274_raw;
            public const string Unk_274_displayName = "Unk 274";
            public const int Unk_274_sortIndex = 50;
            [SortOrder(Unk_274_sortIndex)]
            [DisplayName(Unk_274_displayName)]
            public virtual float Unk_274 {
                get => Unk_274_raw;
                set {
                    if (Unk_274_raw == value) return;
                    Unk_274_raw = value;
                    OnPropertyChanged(nameof(Unk_274));
                }
            }

            protected float Unk_275_raw;
            public const string Unk_275_displayName = "Unk 275";
            public const int Unk_275_sortIndex = 100;
            [SortOrder(Unk_275_sortIndex)]
            [DisplayName(Unk_275_displayName)]
            public virtual float Unk_275 {
                get => Unk_275_raw;
                set {
                    if (Unk_275_raw == value) return;
                    Unk_275_raw = value;
                    OnPropertyChanged(nameof(Unk_275));
                }
            }

            protected float Unk_276_raw;
            public const string Unk_276_displayName = "Unk 276";
            public const int Unk_276_sortIndex = 150;
            [SortOrder(Unk_276_sortIndex)]
            [DisplayName(Unk_276_displayName)]
            public virtual float Unk_276 {
                get => Unk_276_raw;
                set {
                    if (Unk_276_raw == value) return;
                    Unk_276_raw = value;
                    OnPropertyChanged(nameof(Unk_276));
                }
            }

            protected float Unk_277_raw;
            public const string Unk_277_displayName = "Unk 277";
            public const int Unk_277_sortIndex = 200;
            [SortOrder(Unk_277_sortIndex)]
            [DisplayName(Unk_277_displayName)]
            public virtual float Unk_277 {
                get => Unk_277_raw;
                set {
                    if (Unk_277_raw == value) return;
                    Unk_277_raw = value;
                    OnPropertyChanged(nameof(Unk_277));
                }
            }

            protected float Unk_278_raw;
            public const string Unk_278_displayName = "Unk 278";
            public const int Unk_278_sortIndex = 250;
            [SortOrder(Unk_278_sortIndex)]
            [DisplayName(Unk_278_displayName)]
            public virtual float Unk_278 {
                get => Unk_278_raw;
                set {
                    if (Unk_278_raw == value) return;
                    Unk_278_raw = value;
                    OnPropertyChanged(nameof(Unk_278));
                }
            }

            protected float Unk_279_raw;
            public const string Unk_279_displayName = "Unk 279";
            public const int Unk_279_sortIndex = 300;
            [SortOrder(Unk_279_sortIndex)]
            [DisplayName(Unk_279_displayName)]
            public virtual float Unk_279 {
                get => Unk_279_raw;
                set {
                    if (Unk_279_raw == value) return;
                    Unk_279_raw = value;
                    OnPropertyChanged(nameof(Unk_279));
                }
            }

            protected float Unk_280_raw;
            public const string Unk_280_displayName = "Unk 280";
            public const int Unk_280_sortIndex = 350;
            [SortOrder(Unk_280_sortIndex)]
            [DisplayName(Unk_280_displayName)]
            public virtual float Unk_280 {
                get => Unk_280_raw;
                set {
                    if (Unk_280_raw == value) return;
                    Unk_280_raw = value;
                    OnPropertyChanged(nameof(Unk_280));
                }
            }

            protected float Unk_281_raw;
            public const string Unk_281_displayName = "Unk 281";
            public const int Unk_281_sortIndex = 400;
            [SortOrder(Unk_281_sortIndex)]
            [DisplayName(Unk_281_displayName)]
            public virtual float Unk_281 {
                get => Unk_281_raw;
                set {
                    if (Unk_281_raw == value) return;
                    Unk_281_raw = value;
                    OnPropertyChanged(nameof(Unk_281));
                }
            }

            protected float Unk_282_raw;
            public const string Unk_282_displayName = "Unk 282";
            public const int Unk_282_sortIndex = 450;
            [SortOrder(Unk_282_sortIndex)]
            [DisplayName(Unk_282_displayName)]
            public virtual float Unk_282 {
                get => Unk_282_raw;
                set {
                    if (Unk_282_raw == value) return;
                    Unk_282_raw = value;
                    OnPropertyChanged(nameof(Unk_282));
                }
            }

            protected float Unk_283_raw;
            public const string Unk_283_displayName = "Unk 283";
            public const int Unk_283_sortIndex = 500;
            [SortOrder(Unk_283_sortIndex)]
            [DisplayName(Unk_283_displayName)]
            public virtual float Unk_283 {
                get => Unk_283_raw;
                set {
                    if (Unk_283_raw == value) return;
                    Unk_283_raw = value;
                    OnPropertyChanged(nameof(Unk_283));
                }
            }

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W13p_Params_7_ LoadData(BinaryReader reader, ulong i) {
                var data = new W13p_Params_7_();
                data.Index = i;
                data.Unk_274_raw = reader.ReadSingle();
                data.Unk_275_raw = reader.ReadSingle();
                data.Unk_276_raw = reader.ReadSingle();
                data.Unk_277_raw = reader.ReadSingle();
                data.Unk_278_raw = reader.ReadSingle();
                data.Unk_279_raw = reader.ReadSingle();
                data.Unk_280_raw = reader.ReadSingle();
                data.Unk_281_raw = reader.ReadSingle();
                data.Unk_282_raw = reader.ReadSingle();
                data.Unk_283_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_274_raw);
                writer.Write(Unk_275_raw);
                writer.Write(Unk_276_raw);
                writer.Write(Unk_277_raw);
                writer.Write(Unk_278_raw);
                writer.Write(Unk_279_raw);
                writer.Write(Unk_280_raw);
                writer.Write(Unk_281_raw);
                writer.Write(Unk_282_raw);
                writer.Write(Unk_283_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Unk 274", "Unk_274"),
                    new MultiStructItemCustomView(this, "Unk 275", "Unk_275"),
                    new MultiStructItemCustomView(this, "Unk 276", "Unk_276"),
                    new MultiStructItemCustomView(this, "Unk 277", "Unk_277"),
                    new MultiStructItemCustomView(this, "Unk 278", "Unk_278"),
                    new MultiStructItemCustomView(this, "Unk 279", "Unk_279"),
                    new MultiStructItemCustomView(this, "Unk 280", "Unk_280"),
                    new MultiStructItemCustomView(this, "Unk 281", "Unk_281"),
                    new MultiStructItemCustomView(this, "Unk 282", "Unk_282"),
                    new MultiStructItemCustomView(this, "Unk 283", "Unk_283"),
                };
            }
        }

        public partial class Unk_Arr_5 : MhwStructItem {
            public const ulong FixedSizeCount = 50;
            public const string GridName = "Unk Arr 5";

            protected float Unk_1_raw;
            public const string Unk_1_displayName = "Unk 1";
            public const int Unk_1_sortIndex = 50;
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
            public const int Unk_2_sortIndex = 100;
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
            public const int Unk_3_sortIndex = 150;
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

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
                var count = 50UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Unk_Arr_5 LoadData(BinaryReader reader, ulong i) {
                var data = new Unk_Arr_5();
                data.Index = i;
                data.Unk_1_raw = reader.ReadSingle();
                data.Unk_2_raw = reader.ReadSingle();
                data.Unk_3_raw = reader.ReadSingle();
                data.Unk_4_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_1_raw);
                writer.Write(Unk_2_raw);
                writer.Write(Unk_3_raw);
                writer.Write(Unk_4_raw);
            }
        }

        public partial class W13p_Params_8_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView> {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W13p Params (8)";

            protected ushort Unk_284_raw;
            public const string Unk_284_displayName = "Unk 284";
            public const int Unk_284_sortIndex = 50;
            [SortOrder(Unk_284_sortIndex)]
            [DisplayName(Unk_284_displayName)]
            public virtual ushort Unk_284 {
                get => Unk_284_raw;
                set {
                    if (Unk_284_raw == value) return;
                    Unk_284_raw = value;
                    OnPropertyChanged(nameof(Unk_284));
                }
            }

            protected ushort Unk_285_raw;
            public const string Unk_285_displayName = "Unk 285";
            public const int Unk_285_sortIndex = 100;
            [SortOrder(Unk_285_sortIndex)]
            [DisplayName(Unk_285_displayName)]
            public virtual ushort Unk_285 {
                get => Unk_285_raw;
                set {
                    if (Unk_285_raw == value) return;
                    Unk_285_raw = value;
                    OnPropertyChanged(nameof(Unk_285));
                }
            }

            protected ushort Unk_286_raw;
            public const string Unk_286_displayName = "Unk 286";
            public const int Unk_286_sortIndex = 150;
            [SortOrder(Unk_286_sortIndex)]
            [DisplayName(Unk_286_displayName)]
            public virtual ushort Unk_286 {
                get => Unk_286_raw;
                set {
                    if (Unk_286_raw == value) return;
                    Unk_286_raw = value;
                    OnPropertyChanged(nameof(Unk_286));
                }
            }

            protected ushort Unk_287_raw;
            public const string Unk_287_displayName = "Unk 287";
            public const int Unk_287_sortIndex = 200;
            [SortOrder(Unk_287_sortIndex)]
            [DisplayName(Unk_287_displayName)]
            public virtual ushort Unk_287 {
                get => Unk_287_raw;
                set {
                    if (Unk_287_raw == value) return;
                    Unk_287_raw = value;
                    OnPropertyChanged(nameof(Unk_287));
                }
            }

            protected ushort Unk_288_raw;
            public const string Unk_288_displayName = "Unk 288";
            public const int Unk_288_sortIndex = 250;
            [SortOrder(Unk_288_sortIndex)]
            [DisplayName(Unk_288_displayName)]
            public virtual ushort Unk_288 {
                get => Unk_288_raw;
                set {
                    if (Unk_288_raw == value) return;
                    Unk_288_raw = value;
                    OnPropertyChanged(nameof(Unk_288));
                }
            }

            protected ushort Unk_289_raw;
            public const string Unk_289_displayName = "Unk 289";
            public const int Unk_289_sortIndex = 300;
            [SortOrder(Unk_289_sortIndex)]
            [DisplayName(Unk_289_displayName)]
            public virtual ushort Unk_289 {
                get => Unk_289_raw;
                set {
                    if (Unk_289_raw == value) return;
                    Unk_289_raw = value;
                    OnPropertyChanged(nameof(Unk_289));
                }
            }

            protected short Unk_290_raw;
            public const string Unk_290_displayName = "Unk 290";
            public const int Unk_290_sortIndex = 350;
            [SortOrder(Unk_290_sortIndex)]
            [DisplayName(Unk_290_displayName)]
            public virtual short Unk_290 {
                get => Unk_290_raw;
                set {
                    if (Unk_290_raw == value) return;
                    Unk_290_raw = value;
                    OnPropertyChanged(nameof(Unk_290));
                }
            }

            protected short Unk_291_raw;
            public const string Unk_291_displayName = "Unk 291";
            public const int Unk_291_sortIndex = 400;
            [SortOrder(Unk_291_sortIndex)]
            [DisplayName(Unk_291_displayName)]
            public virtual short Unk_291 {
                get => Unk_291_raw;
                set {
                    if (Unk_291_raw == value) return;
                    Unk_291_raw = value;
                    OnPropertyChanged(nameof(Unk_291));
                }
            }

            protected ushort Unk_292_raw;
            public const string Unk_292_displayName = "Unk 292";
            public const int Unk_292_sortIndex = 450;
            [SortOrder(Unk_292_sortIndex)]
            [DisplayName(Unk_292_displayName)]
            public virtual ushort Unk_292 {
                get => Unk_292_raw;
                set {
                    if (Unk_292_raw == value) return;
                    Unk_292_raw = value;
                    OnPropertyChanged(nameof(Unk_292));
                }
            }

            protected ushort Unk_293_raw;
            public const string Unk_293_displayName = "Unk 293";
            public const int Unk_293_sortIndex = 500;
            [SortOrder(Unk_293_sortIndex)]
            [DisplayName(Unk_293_displayName)]
            public virtual ushort Unk_293 {
                get => Unk_293_raw;
                set {
                    if (Unk_293_raw == value) return;
                    Unk_293_raw = value;
                    OnPropertyChanged(nameof(Unk_293));
                }
            }

            protected ushort Unk_294_raw;
            public const string Unk_294_displayName = "Unk 294";
            public const int Unk_294_sortIndex = 550;
            [SortOrder(Unk_294_sortIndex)]
            [DisplayName(Unk_294_displayName)]
            public virtual ushort Unk_294 {
                get => Unk_294_raw;
                set {
                    if (Unk_294_raw == value) return;
                    Unk_294_raw = value;
                    OnPropertyChanged(nameof(Unk_294));
                }
            }

            protected ushort Unk_295_raw;
            public const string Unk_295_displayName = "Unk 295";
            public const int Unk_295_sortIndex = 600;
            [SortOrder(Unk_295_sortIndex)]
            [DisplayName(Unk_295_displayName)]
            public virtual ushort Unk_295 {
                get => Unk_295_raw;
                set {
                    if (Unk_295_raw == value) return;
                    Unk_295_raw = value;
                    OnPropertyChanged(nameof(Unk_295));
                }
            }

            protected ushort Unk_296_raw;
            public const string Unk_296_displayName = "Unk 296";
            public const int Unk_296_sortIndex = 650;
            [SortOrder(Unk_296_sortIndex)]
            [DisplayName(Unk_296_displayName)]
            public virtual ushort Unk_296 {
                get => Unk_296_raw;
                set {
                    if (Unk_296_raw == value) return;
                    Unk_296_raw = value;
                    OnPropertyChanged(nameof(Unk_296));
                }
            }

            protected ushort Unk_297_raw;
            public const string Unk_297_displayName = "Unk 297";
            public const int Unk_297_sortIndex = 700;
            [SortOrder(Unk_297_sortIndex)]
            [DisplayName(Unk_297_displayName)]
            public virtual ushort Unk_297 {
                get => Unk_297_raw;
                set {
                    if (Unk_297_raw == value) return;
                    Unk_297_raw = value;
                    OnPropertyChanged(nameof(Unk_297));
                }
            }

            protected short Unk_298_raw;
            public const string Unk_298_displayName = "Unk 298";
            public const int Unk_298_sortIndex = 750;
            [SortOrder(Unk_298_sortIndex)]
            [DisplayName(Unk_298_displayName)]
            public virtual short Unk_298 {
                get => Unk_298_raw;
                set {
                    if (Unk_298_raw == value) return;
                    Unk_298_raw = value;
                    OnPropertyChanged(nameof(Unk_298));
                }
            }

            protected short Unk_299_raw;
            public const string Unk_299_displayName = "Unk 299";
            public const int Unk_299_sortIndex = 800;
            [SortOrder(Unk_299_sortIndex)]
            [DisplayName(Unk_299_displayName)]
            public virtual short Unk_299 {
                get => Unk_299_raw;
                set {
                    if (Unk_299_raw == value) return;
                    Unk_299_raw = value;
                    OnPropertyChanged(nameof(Unk_299));
                }
            }

            protected ushort Unk_300_raw;
            public const string Unk_300_displayName = "Unk 300";
            public const int Unk_300_sortIndex = 850;
            [SortOrder(Unk_300_sortIndex)]
            [DisplayName(Unk_300_displayName)]
            public virtual ushort Unk_300 {
                get => Unk_300_raw;
                set {
                    if (Unk_300_raw == value) return;
                    Unk_300_raw = value;
                    OnPropertyChanged(nameof(Unk_300));
                }
            }

            protected ushort Unk_301_raw;
            public const string Unk_301_displayName = "Unk 301";
            public const int Unk_301_sortIndex = 900;
            [SortOrder(Unk_301_sortIndex)]
            [DisplayName(Unk_301_displayName)]
            public virtual ushort Unk_301 {
                get => Unk_301_raw;
                set {
                    if (Unk_301_raw == value) return;
                    Unk_301_raw = value;
                    OnPropertyChanged(nameof(Unk_301));
                }
            }

            protected ushort Unk_302_raw;
            public const string Unk_302_displayName = "Unk 302";
            public const int Unk_302_sortIndex = 950;
            [SortOrder(Unk_302_sortIndex)]
            [DisplayName(Unk_302_displayName)]
            public virtual ushort Unk_302 {
                get => Unk_302_raw;
                set {
                    if (Unk_302_raw == value) return;
                    Unk_302_raw = value;
                    OnPropertyChanged(nameof(Unk_302));
                }
            }

            protected ushort Unk_303_raw;
            public const string Unk_303_displayName = "Unk 303";
            public const int Unk_303_sortIndex = 1000;
            [SortOrder(Unk_303_sortIndex)]
            [DisplayName(Unk_303_displayName)]
            public virtual ushort Unk_303 {
                get => Unk_303_raw;
                set {
                    if (Unk_303_raw == value) return;
                    Unk_303_raw = value;
                    OnPropertyChanged(nameof(Unk_303));
                }
            }

            protected short Unk_304_raw;
            public const string Unk_304_displayName = "Unk 304";
            public const int Unk_304_sortIndex = 1050;
            [SortOrder(Unk_304_sortIndex)]
            [DisplayName(Unk_304_displayName)]
            public virtual short Unk_304 {
                get => Unk_304_raw;
                set {
                    if (Unk_304_raw == value) return;
                    Unk_304_raw = value;
                    OnPropertyChanged(nameof(Unk_304));
                }
            }

            protected short Unk_305_raw;
            public const string Unk_305_displayName = "Unk 305";
            public const int Unk_305_sortIndex = 1100;
            [SortOrder(Unk_305_sortIndex)]
            [DisplayName(Unk_305_displayName)]
            public virtual short Unk_305 {
                get => Unk_305_raw;
                set {
                    if (Unk_305_raw == value) return;
                    Unk_305_raw = value;
                    OnPropertyChanged(nameof(Unk_305));
                }
            }

            protected short Unk_306_raw;
            public const string Unk_306_displayName = "Unk 306";
            public const int Unk_306_sortIndex = 1150;
            [SortOrder(Unk_306_sortIndex)]
            [DisplayName(Unk_306_displayName)]
            public virtual short Unk_306 {
                get => Unk_306_raw;
                set {
                    if (Unk_306_raw == value) return;
                    Unk_306_raw = value;
                    OnPropertyChanged(nameof(Unk_306));
                }
            }

            protected short Unk_307_raw;
            public const string Unk_307_displayName = "Unk 307";
            public const int Unk_307_sortIndex = 1200;
            [SortOrder(Unk_307_sortIndex)]
            [DisplayName(Unk_307_displayName)]
            public virtual short Unk_307 {
                get => Unk_307_raw;
                set {
                    if (Unk_307_raw == value) return;
                    Unk_307_raw = value;
                    OnPropertyChanged(nameof(Unk_307));
                }
            }

            protected ushort Unk_308_raw;
            public const string Unk_308_displayName = "Unk 308";
            public const int Unk_308_sortIndex = 1250;
            [SortOrder(Unk_308_sortIndex)]
            [DisplayName(Unk_308_displayName)]
            public virtual ushort Unk_308 {
                get => Unk_308_raw;
                set {
                    if (Unk_308_raw == value) return;
                    Unk_308_raw = value;
                    OnPropertyChanged(nameof(Unk_308));
                }
            }

            protected ushort Unk_309_raw;
            public const string Unk_309_displayName = "Unk 309";
            public const int Unk_309_sortIndex = 1300;
            [SortOrder(Unk_309_sortIndex)]
            [DisplayName(Unk_309_displayName)]
            public virtual ushort Unk_309 {
                get => Unk_309_raw;
                set {
                    if (Unk_309_raw == value) return;
                    Unk_309_raw = value;
                    OnPropertyChanged(nameof(Unk_309));
                }
            }

            protected ushort Unk_310_raw;
            public const string Unk_310_displayName = "Unk 310";
            public const int Unk_310_sortIndex = 1350;
            [SortOrder(Unk_310_sortIndex)]
            [DisplayName(Unk_310_displayName)]
            public virtual ushort Unk_310 {
                get => Unk_310_raw;
                set {
                    if (Unk_310_raw == value) return;
                    Unk_310_raw = value;
                    OnPropertyChanged(nameof(Unk_310));
                }
            }

            protected ushort Unk_311_raw;
            public const string Unk_311_displayName = "Unk 311";
            public const int Unk_311_sortIndex = 1400;
            [SortOrder(Unk_311_sortIndex)]
            [DisplayName(Unk_311_displayName)]
            public virtual ushort Unk_311 {
                get => Unk_311_raw;
                set {
                    if (Unk_311_raw == value) return;
                    Unk_311_raw = value;
                    OnPropertyChanged(nameof(Unk_311));
                }
            }

            protected ushort Unk_312_raw;
            public const string Unk_312_displayName = "Unk 312";
            public const int Unk_312_sortIndex = 1450;
            [SortOrder(Unk_312_sortIndex)]
            [DisplayName(Unk_312_displayName)]
            public virtual ushort Unk_312 {
                get => Unk_312_raw;
                set {
                    if (Unk_312_raw == value) return;
                    Unk_312_raw = value;
                    OnPropertyChanged(nameof(Unk_312));
                }
            }

            protected ushort Unk_313_raw;
            public const string Unk_313_displayName = "Unk 313";
            public const int Unk_313_sortIndex = 1500;
            [SortOrder(Unk_313_sortIndex)]
            [DisplayName(Unk_313_displayName)]
            public virtual ushort Unk_313 {
                get => Unk_313_raw;
                set {
                    if (Unk_313_raw == value) return;
                    Unk_313_raw = value;
                    OnPropertyChanged(nameof(Unk_313));
                }
            }

            protected ushort Unk_314_raw;
            public const string Unk_314_displayName = "Unk 314";
            public const int Unk_314_sortIndex = 1550;
            [SortOrder(Unk_314_sortIndex)]
            [DisplayName(Unk_314_displayName)]
            public virtual ushort Unk_314 {
                get => Unk_314_raw;
                set {
                    if (Unk_314_raw == value) return;
                    Unk_314_raw = value;
                    OnPropertyChanged(nameof(Unk_314));
                }
            }

            protected ushort Unk_315_raw;
            public const string Unk_315_displayName = "Unk 315";
            public const int Unk_315_sortIndex = 1600;
            [SortOrder(Unk_315_sortIndex)]
            [DisplayName(Unk_315_displayName)]
            public virtual ushort Unk_315 {
                get => Unk_315_raw;
                set {
                    if (Unk_315_raw == value) return;
                    Unk_315_raw = value;
                    OnPropertyChanged(nameof(Unk_315));
                }
            }

            protected float Unk_316_raw;
            public const string Unk_316_displayName = "Unk 316";
            public const int Unk_316_sortIndex = 1650;
            [SortOrder(Unk_316_sortIndex)]
            [DisplayName(Unk_316_displayName)]
            public virtual float Unk_316 {
                get => Unk_316_raw;
                set {
                    if (Unk_316_raw == value) return;
                    Unk_316_raw = value;
                    OnPropertyChanged(nameof(Unk_316));
                }
            }

            protected float Unk_317_raw;
            public const string Unk_317_displayName = "Unk 317";
            public const int Unk_317_sortIndex = 1700;
            [SortOrder(Unk_317_sortIndex)]
            [DisplayName(Unk_317_displayName)]
            public virtual float Unk_317 {
                get => Unk_317_raw;
                set {
                    if (Unk_317_raw == value) return;
                    Unk_317_raw = value;
                    OnPropertyChanged(nameof(Unk_317));
                }
            }

            protected float Unk_318_raw;
            public const string Unk_318_displayName = "Unk 318";
            public const int Unk_318_sortIndex = 1750;
            [SortOrder(Unk_318_sortIndex)]
            [DisplayName(Unk_318_displayName)]
            public virtual float Unk_318 {
                get => Unk_318_raw;
                set {
                    if (Unk_318_raw == value) return;
                    Unk_318_raw = value;
                    OnPropertyChanged(nameof(Unk_318));
                }
            }

            protected float Unk_319_raw;
            public const string Unk_319_displayName = "Unk 319";
            public const int Unk_319_sortIndex = 1800;
            [SortOrder(Unk_319_sortIndex)]
            [DisplayName(Unk_319_displayName)]
            public virtual float Unk_319 {
                get => Unk_319_raw;
                set {
                    if (Unk_319_raw == value) return;
                    Unk_319_raw = value;
                    OnPropertyChanged(nameof(Unk_319));
                }
            }

            protected float Unk_320_raw;
            public const string Unk_320_displayName = "Unk 320";
            public const int Unk_320_sortIndex = 1850;
            [SortOrder(Unk_320_sortIndex)]
            [DisplayName(Unk_320_displayName)]
            public virtual float Unk_320 {
                get => Unk_320_raw;
                set {
                    if (Unk_320_raw == value) return;
                    Unk_320_raw = value;
                    OnPropertyChanged(nameof(Unk_320));
                }
            }

            protected float Unk_321_raw;
            public const string Unk_321_displayName = "Unk 321";
            public const int Unk_321_sortIndex = 1900;
            [SortOrder(Unk_321_sortIndex)]
            [DisplayName(Unk_321_displayName)]
            public virtual float Unk_321 {
                get => Unk_321_raw;
                set {
                    if (Unk_321_raw == value) return;
                    Unk_321_raw = value;
                    OnPropertyChanged(nameof(Unk_321));
                }
            }

            protected float Unk_322_raw;
            public const string Unk_322_displayName = "Unk 322";
            public const int Unk_322_sortIndex = 1950;
            [SortOrder(Unk_322_sortIndex)]
            [DisplayName(Unk_322_displayName)]
            public virtual float Unk_322 {
                get => Unk_322_raw;
                set {
                    if (Unk_322_raw == value) return;
                    Unk_322_raw = value;
                    OnPropertyChanged(nameof(Unk_322));
                }
            }

            protected float Unk_323_raw;
            public const string Unk_323_displayName = "Unk 323";
            public const int Unk_323_sortIndex = 2000;
            [SortOrder(Unk_323_sortIndex)]
            [DisplayName(Unk_323_displayName)]
            public virtual float Unk_323 {
                get => Unk_323_raw;
                set {
                    if (Unk_323_raw == value) return;
                    Unk_323_raw = value;
                    OnPropertyChanged(nameof(Unk_323));
                }
            }

            protected byte Unk_324_raw;
            public const string Unk_324_displayName = "Unk 324";
            public const int Unk_324_sortIndex = 2050;
            [SortOrder(Unk_324_sortIndex)]
            [DisplayName(Unk_324_displayName)]
            public virtual byte Unk_324 {
                get => Unk_324_raw;
                set {
                    if (Unk_324_raw == value) return;
                    Unk_324_raw = value;
                    OnPropertyChanged(nameof(Unk_324));
                }
            }

            protected byte Unk_325_raw;
            public const string Unk_325_displayName = "Unk 325";
            public const int Unk_325_sortIndex = 2100;
            [SortOrder(Unk_325_sortIndex)]
            [DisplayName(Unk_325_displayName)]
            public virtual byte Unk_325 {
                get => Unk_325_raw;
                set {
                    if (Unk_325_raw == value) return;
                    Unk_325_raw = value;
                    OnPropertyChanged(nameof(Unk_325));
                }
            }

            protected byte Unk_326_raw;
            public const string Unk_326_displayName = "Unk 326";
            public const int Unk_326_sortIndex = 2150;
            [SortOrder(Unk_326_sortIndex)]
            [DisplayName(Unk_326_displayName)]
            public virtual byte Unk_326 {
                get => Unk_326_raw;
                set {
                    if (Unk_326_raw == value) return;
                    Unk_326_raw = value;
                    OnPropertyChanged(nameof(Unk_326));
                }
            }

            protected byte Unk_327_raw;
            public const string Unk_327_displayName = "Unk 327";
            public const int Unk_327_sortIndex = 2200;
            [SortOrder(Unk_327_sortIndex)]
            [DisplayName(Unk_327_displayName)]
            public virtual byte Unk_327 {
                get => Unk_327_raw;
                set {
                    if (Unk_327_raw == value) return;
                    Unk_327_raw = value;
                    OnPropertyChanged(nameof(Unk_327));
                }
            }

            protected byte Unk_328_raw;
            public const string Unk_328_displayName = "Unk 328";
            public const int Unk_328_sortIndex = 2250;
            [SortOrder(Unk_328_sortIndex)]
            [DisplayName(Unk_328_displayName)]
            public virtual byte Unk_328 {
                get => Unk_328_raw;
                set {
                    if (Unk_328_raw == value) return;
                    Unk_328_raw = value;
                    OnPropertyChanged(nameof(Unk_328));
                }
            }

            protected ushort Unk_329_raw;
            public const string Unk_329_displayName = "Unk 329";
            public const int Unk_329_sortIndex = 2300;
            [SortOrder(Unk_329_sortIndex)]
            [DisplayName(Unk_329_displayName)]
            public virtual ushort Unk_329 {
                get => Unk_329_raw;
                set {
                    if (Unk_329_raw == value) return;
                    Unk_329_raw = value;
                    OnPropertyChanged(nameof(Unk_329));
                }
            }

            protected float Unk_330_raw;
            public const string Unk_330_displayName = "Unk 330";
            public const int Unk_330_sortIndex = 2350;
            [SortOrder(Unk_330_sortIndex)]
            [DisplayName(Unk_330_displayName)]
            public virtual float Unk_330 {
                get => Unk_330_raw;
                set {
                    if (Unk_330_raw == value) return;
                    Unk_330_raw = value;
                    OnPropertyChanged(nameof(Unk_330));
                }
            }

            protected byte Unk_331_raw;
            public const string Unk_331_displayName = "Unk 331";
            public const int Unk_331_sortIndex = 2400;
            [SortOrder(Unk_331_sortIndex)]
            [DisplayName(Unk_331_displayName)]
            public virtual byte Unk_331 {
                get => Unk_331_raw;
                set {
                    if (Unk_331_raw == value) return;
                    Unk_331_raw = value;
                    OnPropertyChanged(nameof(Unk_331));
                }
            }

            protected float Unk_332_raw;
            public const string Unk_332_displayName = "Unk 332";
            public const int Unk_332_sortIndex = 2450;
            [SortOrder(Unk_332_sortIndex)]
            [DisplayName(Unk_332_displayName)]
            public virtual float Unk_332 {
                get => Unk_332_raw;
                set {
                    if (Unk_332_raw == value) return;
                    Unk_332_raw = value;
                    OnPropertyChanged(nameof(Unk_332));
                }
            }

            protected float Unk_333_raw;
            public const string Unk_333_displayName = "Unk 333";
            public const int Unk_333_sortIndex = 2500;
            [SortOrder(Unk_333_sortIndex)]
            [DisplayName(Unk_333_displayName)]
            public virtual float Unk_333 {
                get => Unk_333_raw;
                set {
                    if (Unk_333_raw == value) return;
                    Unk_333_raw = value;
                    OnPropertyChanged(nameof(Unk_333));
                }
            }

            protected float Unk_334_raw;
            public const string Unk_334_displayName = "Unk 334";
            public const int Unk_334_sortIndex = 2550;
            [SortOrder(Unk_334_sortIndex)]
            [DisplayName(Unk_334_displayName)]
            public virtual float Unk_334 {
                get => Unk_334_raw;
                set {
                    if (Unk_334_raw == value) return;
                    Unk_334_raw = value;
                    OnPropertyChanged(nameof(Unk_334));
                }
            }

            protected float Unk_335_raw;
            public const string Unk_335_displayName = "Unk 335";
            public const int Unk_335_sortIndex = 2600;
            [SortOrder(Unk_335_sortIndex)]
            [DisplayName(Unk_335_displayName)]
            public virtual float Unk_335 {
                get => Unk_335_raw;
                set {
                    if (Unk_335_raw == value) return;
                    Unk_335_raw = value;
                    OnPropertyChanged(nameof(Unk_335));
                }
            }

            protected float Unk_336_raw;
            public const string Unk_336_displayName = "Unk 336";
            public const int Unk_336_sortIndex = 2650;
            [SortOrder(Unk_336_sortIndex)]
            [DisplayName(Unk_336_displayName)]
            public virtual float Unk_336 {
                get => Unk_336_raw;
                set {
                    if (Unk_336_raw == value) return;
                    Unk_336_raw = value;
                    OnPropertyChanged(nameof(Unk_336));
                }
            }

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W13p_Params_8_ LoadData(BinaryReader reader, ulong i) {
                var data = new W13p_Params_8_();
                data.Index = i;
                data.Unk_284_raw = reader.ReadUInt16();
                data.Unk_285_raw = reader.ReadUInt16();
                data.Unk_286_raw = reader.ReadUInt16();
                data.Unk_287_raw = reader.ReadUInt16();
                data.Unk_288_raw = reader.ReadUInt16();
                data.Unk_289_raw = reader.ReadUInt16();
                data.Unk_290_raw = reader.ReadInt16();
                data.Unk_291_raw = reader.ReadInt16();
                data.Unk_292_raw = reader.ReadUInt16();
                data.Unk_293_raw = reader.ReadUInt16();
                data.Unk_294_raw = reader.ReadUInt16();
                data.Unk_295_raw = reader.ReadUInt16();
                data.Unk_296_raw = reader.ReadUInt16();
                data.Unk_297_raw = reader.ReadUInt16();
                data.Unk_298_raw = reader.ReadInt16();
                data.Unk_299_raw = reader.ReadInt16();
                data.Unk_300_raw = reader.ReadUInt16();
                data.Unk_301_raw = reader.ReadUInt16();
                data.Unk_302_raw = reader.ReadUInt16();
                data.Unk_303_raw = reader.ReadUInt16();
                data.Unk_304_raw = reader.ReadInt16();
                data.Unk_305_raw = reader.ReadInt16();
                data.Unk_306_raw = reader.ReadInt16();
                data.Unk_307_raw = reader.ReadInt16();
                data.Unk_308_raw = reader.ReadUInt16();
                data.Unk_309_raw = reader.ReadUInt16();
                data.Unk_310_raw = reader.ReadUInt16();
                data.Unk_311_raw = reader.ReadUInt16();
                data.Unk_312_raw = reader.ReadUInt16();
                data.Unk_313_raw = reader.ReadUInt16();
                data.Unk_314_raw = reader.ReadUInt16();
                data.Unk_315_raw = reader.ReadUInt16();
                data.Unk_316_raw = reader.ReadSingle();
                data.Unk_317_raw = reader.ReadSingle();
                data.Unk_318_raw = reader.ReadSingle();
                data.Unk_319_raw = reader.ReadSingle();
                data.Unk_320_raw = reader.ReadSingle();
                data.Unk_321_raw = reader.ReadSingle();
                data.Unk_322_raw = reader.ReadSingle();
                data.Unk_323_raw = reader.ReadSingle();
                data.Unk_324_raw = reader.ReadByte();
                data.Unk_325_raw = reader.ReadByte();
                data.Unk_326_raw = reader.ReadByte();
                data.Unk_327_raw = reader.ReadByte();
                data.Unk_328_raw = reader.ReadByte();
                data.Unk_329_raw = reader.ReadUInt16();
                data.Unk_330_raw = reader.ReadSingle();
                data.Unk_331_raw = reader.ReadByte();
                data.Unk_332_raw = reader.ReadSingle();
                data.Unk_333_raw = reader.ReadSingle();
                data.Unk_334_raw = reader.ReadSingle();
                data.Unk_335_raw = reader.ReadSingle();
                data.Unk_336_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_284_raw);
                writer.Write(Unk_285_raw);
                writer.Write(Unk_286_raw);
                writer.Write(Unk_287_raw);
                writer.Write(Unk_288_raw);
                writer.Write(Unk_289_raw);
                writer.Write(Unk_290_raw);
                writer.Write(Unk_291_raw);
                writer.Write(Unk_292_raw);
                writer.Write(Unk_293_raw);
                writer.Write(Unk_294_raw);
                writer.Write(Unk_295_raw);
                writer.Write(Unk_296_raw);
                writer.Write(Unk_297_raw);
                writer.Write(Unk_298_raw);
                writer.Write(Unk_299_raw);
                writer.Write(Unk_300_raw);
                writer.Write(Unk_301_raw);
                writer.Write(Unk_302_raw);
                writer.Write(Unk_303_raw);
                writer.Write(Unk_304_raw);
                writer.Write(Unk_305_raw);
                writer.Write(Unk_306_raw);
                writer.Write(Unk_307_raw);
                writer.Write(Unk_308_raw);
                writer.Write(Unk_309_raw);
                writer.Write(Unk_310_raw);
                writer.Write(Unk_311_raw);
                writer.Write(Unk_312_raw);
                writer.Write(Unk_313_raw);
                writer.Write(Unk_314_raw);
                writer.Write(Unk_315_raw);
                writer.Write(Unk_316_raw);
                writer.Write(Unk_317_raw);
                writer.Write(Unk_318_raw);
                writer.Write(Unk_319_raw);
                writer.Write(Unk_320_raw);
                writer.Write(Unk_321_raw);
                writer.Write(Unk_322_raw);
                writer.Write(Unk_323_raw);
                writer.Write(Unk_324_raw);
                writer.Write(Unk_325_raw);
                writer.Write(Unk_326_raw);
                writer.Write(Unk_327_raw);
                writer.Write(Unk_328_raw);
                writer.Write(Unk_329_raw);
                writer.Write(Unk_330_raw);
                writer.Write(Unk_331_raw);
                writer.Write(Unk_332_raw);
                writer.Write(Unk_333_raw);
                writer.Write(Unk_334_raw);
                writer.Write(Unk_335_raw);
                writer.Write(Unk_336_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Unk 284", "Unk_284"),
                    new MultiStructItemCustomView(this, "Unk 285", "Unk_285"),
                    new MultiStructItemCustomView(this, "Unk 286", "Unk_286"),
                    new MultiStructItemCustomView(this, "Unk 287", "Unk_287"),
                    new MultiStructItemCustomView(this, "Unk 288", "Unk_288"),
                    new MultiStructItemCustomView(this, "Unk 289", "Unk_289"),
                    new MultiStructItemCustomView(this, "Unk 290", "Unk_290"),
                    new MultiStructItemCustomView(this, "Unk 291", "Unk_291"),
                    new MultiStructItemCustomView(this, "Unk 292", "Unk_292"),
                    new MultiStructItemCustomView(this, "Unk 293", "Unk_293"),
                    new MultiStructItemCustomView(this, "Unk 294", "Unk_294"),
                    new MultiStructItemCustomView(this, "Unk 295", "Unk_295"),
                    new MultiStructItemCustomView(this, "Unk 296", "Unk_296"),
                    new MultiStructItemCustomView(this, "Unk 297", "Unk_297"),
                    new MultiStructItemCustomView(this, "Unk 298", "Unk_298"),
                    new MultiStructItemCustomView(this, "Unk 299", "Unk_299"),
                    new MultiStructItemCustomView(this, "Unk 300", "Unk_300"),
                    new MultiStructItemCustomView(this, "Unk 301", "Unk_301"),
                    new MultiStructItemCustomView(this, "Unk 302", "Unk_302"),
                    new MultiStructItemCustomView(this, "Unk 303", "Unk_303"),
                    new MultiStructItemCustomView(this, "Unk 304", "Unk_304"),
                    new MultiStructItemCustomView(this, "Unk 305", "Unk_305"),
                    new MultiStructItemCustomView(this, "Unk 306", "Unk_306"),
                    new MultiStructItemCustomView(this, "Unk 307", "Unk_307"),
                    new MultiStructItemCustomView(this, "Unk 308", "Unk_308"),
                    new MultiStructItemCustomView(this, "Unk 309", "Unk_309"),
                    new MultiStructItemCustomView(this, "Unk 310", "Unk_310"),
                    new MultiStructItemCustomView(this, "Unk 311", "Unk_311"),
                    new MultiStructItemCustomView(this, "Unk 312", "Unk_312"),
                    new MultiStructItemCustomView(this, "Unk 313", "Unk_313"),
                    new MultiStructItemCustomView(this, "Unk 314", "Unk_314"),
                    new MultiStructItemCustomView(this, "Unk 315", "Unk_315"),
                    new MultiStructItemCustomView(this, "Unk 316", "Unk_316"),
                    new MultiStructItemCustomView(this, "Unk 317", "Unk_317"),
                    new MultiStructItemCustomView(this, "Unk 318", "Unk_318"),
                    new MultiStructItemCustomView(this, "Unk 319", "Unk_319"),
                    new MultiStructItemCustomView(this, "Unk 320", "Unk_320"),
                    new MultiStructItemCustomView(this, "Unk 321", "Unk_321"),
                    new MultiStructItemCustomView(this, "Unk 322", "Unk_322"),
                    new MultiStructItemCustomView(this, "Unk 323", "Unk_323"),
                    new MultiStructItemCustomView(this, "Unk 324", "Unk_324"),
                    new MultiStructItemCustomView(this, "Unk 325", "Unk_325"),
                    new MultiStructItemCustomView(this, "Unk 326", "Unk_326"),
                    new MultiStructItemCustomView(this, "Unk 327", "Unk_327"),
                    new MultiStructItemCustomView(this, "Unk 328", "Unk_328"),
                    new MultiStructItemCustomView(this, "Unk 329", "Unk_329"),
                    new MultiStructItemCustomView(this, "Unk 330", "Unk_330"),
                    new MultiStructItemCustomView(this, "Unk 331", "Unk_331"),
                    new MultiStructItemCustomView(this, "Unk 332", "Unk_332"),
                    new MultiStructItemCustomView(this, "Unk 333", "Unk_333"),
                    new MultiStructItemCustomView(this, "Unk 334", "Unk_334"),
                    new MultiStructItemCustomView(this, "Unk 335", "Unk_335"),
                    new MultiStructItemCustomView(this, "Unk 336", "Unk_336"),
                };
            }
        }

        public partial class HZD_Ammo_Guage_Levels : MhwStructItem {
            public const ulong FixedSizeCount = 9;
            public const string GridName = "HZD Ammo Guage Levels";

            protected float Unk_1_raw;
            public const string Unk_1_displayName = "Unk 1";
            public const int Unk_1_sortIndex = 50;
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
            public const int Unk_2_sortIndex = 100;
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
            public const int Unk_3_sortIndex = 150;
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

            protected float HP_Red_raw;
            public const string HP_Red_displayName = "HP Red";
            public const int HP_Red_sortIndex = 200;
            [SortOrder(HP_Red_sortIndex)]
            [DisplayName(HP_Red_displayName)]
            public virtual float HP_Red {
                get => HP_Red_raw;
                set {
                    if (HP_Red_raw == value) return;
                    HP_Red_raw = value;
                    OnPropertyChanged(nameof(HP_Red));
                }
            }

            protected float Unk_4_raw;
            public const string Unk_4_displayName = "Unk 4";
            public const int Unk_4_sortIndex = 250;
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

            protected float Physical_Multiplier_raw;
            public const string Physical_Multiplier_displayName = "Physical Multiplier";
            public const int Physical_Multiplier_sortIndex = 300;
            [SortOrder(Physical_Multiplier_sortIndex)]
            [DisplayName(Physical_Multiplier_displayName)]
            public virtual float Physical_Multiplier {
                get => Physical_Multiplier_raw;
                set {
                    if (Physical_Multiplier_raw == value) return;
                    Physical_Multiplier_raw = value;
                    OnPropertyChanged(nameof(Physical_Multiplier));
                }
            }

            protected float Element_Multiplier_raw;
            public const string Element_Multiplier_displayName = "Element Multiplier";
            public const int Element_Multiplier_sortIndex = 350;
            [SortOrder(Element_Multiplier_sortIndex)]
            [DisplayName(Element_Multiplier_displayName)]
            public virtual float Element_Multiplier {
                get => Element_Multiplier_raw;
                set {
                    if (Element_Multiplier_raw == value) return;
                    Element_Multiplier_raw = value;
                    OnPropertyChanged(nameof(Element_Multiplier));
                }
            }

            protected byte Unk_5_raw;
            public const string Unk_5_displayName = "Unk 5";
            public const int Unk_5_sortIndex = 400;
            [SortOrder(Unk_5_sortIndex)]
            [DisplayName(Unk_5_displayName)]
            public virtual byte Unk_5 {
                get => Unk_5_raw;
                set {
                    if (Unk_5_raw == value) return;
                    Unk_5_raw = value;
                    OnPropertyChanged(nameof(Unk_5));
                }
            }

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
                var count = 9UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static HZD_Ammo_Guage_Levels LoadData(BinaryReader reader, ulong i) {
                var data = new HZD_Ammo_Guage_Levels();
                data.Index = i;
                data.Unk_1_raw = reader.ReadSingle();
                data.Unk_2_raw = reader.ReadSingle();
                data.Unk_3_raw = reader.ReadSingle();
                data.HP_Red_raw = reader.ReadSingle();
                data.Unk_4_raw = reader.ReadSingle();
                data.Physical_Multiplier_raw = reader.ReadSingle();
                data.Element_Multiplier_raw = reader.ReadSingle();
                data.Unk_5_raw = reader.ReadByte();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_1_raw);
                writer.Write(Unk_2_raw);
                writer.Write(Unk_3_raw);
                writer.Write(HP_Red_raw);
                writer.Write(Unk_4_raw);
                writer.Write(Physical_Multiplier_raw);
                writer.Write(Element_Multiplier_raw);
                writer.Write(Unk_5_raw);
            }
        }

        public override void LoadFile(string targetFile) {
            using var reader = new BinaryReader(OpenFile(targetFile, EncryptionKey), Encoding.UTF8);
            data = new LinkedList<MhwStructDataContainer>();
            var W13p_Params_1_Shared__ = new MhwStructDataContainer(W13p_Params_1_Shared_.LoadData(reader, null), typeof(W13p_Params_1_Shared_));
            data.AddLast(W13p_Params_1_Shared__);
            var Unk_Arr_1_Shared__ = new MhwStructDataContainer(Unk_Arr_1_Shared_.LoadData(reader, null), typeof(Unk_Arr_1_Shared_));
            data.AddLast(Unk_Arr_1_Shared__);
            var W13p_Params_2_Shared__ = new MhwStructDataContainer(W13p_Params_2_Shared_.LoadData(reader, null), typeof(W13p_Params_2_Shared_));
            data.AddLast(W13p_Params_2_Shared__);
            var Guard_Angles_Shared__ = new MhwStructDataContainer(Guard_Angles_Shared_.LoadData(reader, null), typeof(Guard_Angles_Shared_));
            data.AddLast(Guard_Angles_Shared__);
            var W13p_Params_3_Shared__ = new MhwStructDataContainer(W13p_Params_3_Shared_.LoadData(reader, null), typeof(W13p_Params_3_Shared_));
            data.AddLast(W13p_Params_3_Shared__);
            var Unk_Arr_2_Shared__ = new MhwStructDataContainer(Unk_Arr_2_Shared_.LoadData(reader, null), typeof(Unk_Arr_2_Shared_));
            data.AddLast(Unk_Arr_2_Shared__);
            var W13p_Params_4_Shared__ = new MhwStructDataContainer(W13p_Params_4_Shared_.LoadData(reader, null), typeof(W13p_Params_4_Shared_));
            data.AddLast(W13p_Params_4_Shared__);
            var W13p_Params_5__ = new MhwStructDataContainer(W13p_Params_5_.LoadData(reader, null), typeof(W13p_Params_5_));
            data.AddLast(W13p_Params_5__);
            var Unk_Arr_3_ = new MhwStructDataContainer(Unk_Arr_3.LoadData(reader, null), typeof(Unk_Arr_3));
            data.AddLast(Unk_Arr_3_);
            var Unk_Arr_4_ = new MhwStructDataContainer(Unk_Arr_4.LoadData(reader, null), typeof(Unk_Arr_4));
            data.AddLast(Unk_Arr_4_);
            var W13p_Params_6__ = new MhwStructDataContainer(W13p_Params_6_.LoadData(reader, null), typeof(W13p_Params_6_));
            data.AddLast(W13p_Params_6__);
            var Number_of_Shield_Mods_Struct_ = new MhwStructDataContainer(Number_of_Shield_Mods_Struct.LoadData(reader, null), typeof(Number_of_Shield_Mods_Struct));
            data.AddLast(Number_of_Shield_Mods_Struct_);
            var Shield_Mods_ = new MhwStructDataContainer(Shield_Mods.LoadData(reader, Number_of_Shield_Mods_Struct_.list), typeof(Shield_Mods));
            Shield_Mods_.SetCountTargetToUpdate(Number_of_Shield_Mods_Struct_, -1, "Number_of_Shield_Mods");
            data.AddLast(Shield_Mods_);
            var W13p_Params_7__ = new MhwStructDataContainer(W13p_Params_7_.LoadData(reader, null), typeof(W13p_Params_7_));
            data.AddLast(W13p_Params_7__);
            var Unk_Arr_5_ = new MhwStructDataContainer(Unk_Arr_5.LoadData(reader, null), typeof(Unk_Arr_5));
            data.AddLast(Unk_Arr_5_);
            var W13p_Params_8__ = new MhwStructDataContainer(W13p_Params_8_.LoadData(reader, null), typeof(W13p_Params_8_));
            data.AddLast(W13p_Params_8__);
            var HZD_Ammo_Guage_Levels_ = new MhwStructDataContainer(HZD_Ammo_Guage_Levels.LoadData(reader, null), typeof(HZD_Ammo_Guage_Levels));
            data.AddLast(HZD_Ammo_Guage_Levels_);
        }
    }
}
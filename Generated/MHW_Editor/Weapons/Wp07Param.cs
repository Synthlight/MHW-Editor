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
    public partial class Wp07Param {
        public override string EncryptionKey => "j1P15gEkgVa7NdFxiqwCPitykHctY2nZPjSaElvqb0eSwcLO1cOlTqqv";

        public partial class W07p_Params_1_Shared_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView> {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W07p Params (1, Shared)";

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

            public static W07p_Params_1_Shared_ LoadData(BinaryReader reader, ulong i) {
                var data = new W07p_Params_1_Shared_();
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

        public partial class W07p_Params_2_Shared_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView> {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W07p Params (2, Shared)";

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

            protected byte Sharpness_Consumed_Melee_Only__raw;
            public const string Sharpness_Consumed_Melee_Only__displayName = "Sharpness Consumed (Melee Only)";
            public const int Sharpness_Consumed_Melee_Only__sortIndex = 850;
            [SortOrder(Sharpness_Consumed_Melee_Only__sortIndex)]
            [DisplayName(Sharpness_Consumed_Melee_Only__displayName)]
            public virtual byte Sharpness_Consumed_Melee_Only_ {
                get => Sharpness_Consumed_Melee_Only__raw;
                set {
                    if (Sharpness_Consumed_Melee_Only__raw == value) return;
                    Sharpness_Consumed_Melee_Only__raw = value;
                    OnPropertyChanged(nameof(Sharpness_Consumed_Melee_Only_));
                }
            }

            protected byte Guard_Knockback_Sharpness_Usage_Small_raw;
            public const string Guard_Knockback_Sharpness_Usage_Small_displayName = "Guard Knockback Sharpness Usage: Small";
            public const int Guard_Knockback_Sharpness_Usage_Small_sortIndex = 900;
            [SortOrder(Guard_Knockback_Sharpness_Usage_Small_sortIndex)]
            [DisplayName(Guard_Knockback_Sharpness_Usage_Small_displayName)]
            public virtual byte Guard_Knockback_Sharpness_Usage_Small {
                get => Guard_Knockback_Sharpness_Usage_Small_raw;
                set {
                    if (Guard_Knockback_Sharpness_Usage_Small_raw == value) return;
                    Guard_Knockback_Sharpness_Usage_Small_raw = value;
                    OnPropertyChanged(nameof(Guard_Knockback_Sharpness_Usage_Small));
                }
            }

            protected byte Guard_Knockback_Sharpness_Usage_Medium_raw;
            public const string Guard_Knockback_Sharpness_Usage_Medium_displayName = "Guard Knockback Sharpness Usage: Medium";
            public const int Guard_Knockback_Sharpness_Usage_Medium_sortIndex = 950;
            [SortOrder(Guard_Knockback_Sharpness_Usage_Medium_sortIndex)]
            [DisplayName(Guard_Knockback_Sharpness_Usage_Medium_displayName)]
            public virtual byte Guard_Knockback_Sharpness_Usage_Medium {
                get => Guard_Knockback_Sharpness_Usage_Medium_raw;
                set {
                    if (Guard_Knockback_Sharpness_Usage_Medium_raw == value) return;
                    Guard_Knockback_Sharpness_Usage_Medium_raw = value;
                    OnPropertyChanged(nameof(Guard_Knockback_Sharpness_Usage_Medium));
                }
            }

            protected byte Guard_Knockback_Sharpness_Usage_Large_raw;
            public const string Guard_Knockback_Sharpness_Usage_Large_displayName = "Guard Knockback Sharpness Usage: Large";
            public const int Guard_Knockback_Sharpness_Usage_Large_sortIndex = 1000;
            [SortOrder(Guard_Knockback_Sharpness_Usage_Large_sortIndex)]
            [DisplayName(Guard_Knockback_Sharpness_Usage_Large_displayName)]
            public virtual byte Guard_Knockback_Sharpness_Usage_Large {
                get => Guard_Knockback_Sharpness_Usage_Large_raw;
                set {
                    if (Guard_Knockback_Sharpness_Usage_Large_raw == value) return;
                    Guard_Knockback_Sharpness_Usage_Large_raw = value;
                    OnPropertyChanged(nameof(Guard_Knockback_Sharpness_Usage_Large));
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

            public static W07p_Params_2_Shared_ LoadData(BinaryReader reader, ulong i) {
                var data = new W07p_Params_2_Shared_();
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
                data.Sharpness_Consumed_Melee_Only__raw = reader.ReadByte();
                data.Guard_Knockback_Sharpness_Usage_Small_raw = reader.ReadByte();
                data.Guard_Knockback_Sharpness_Usage_Medium_raw = reader.ReadByte();
                data.Guard_Knockback_Sharpness_Usage_Large_raw = reader.ReadByte();
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
                writer.Write(Sharpness_Consumed_Melee_Only__raw);
                writer.Write(Guard_Knockback_Sharpness_Usage_Small_raw);
                writer.Write(Guard_Knockback_Sharpness_Usage_Medium_raw);
                writer.Write(Guard_Knockback_Sharpness_Usage_Large_raw);
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
                    new MultiStructItemCustomView(this, "Sharpness Consumed (Melee Only)", "Sharpness_Consumed_Melee_Only_"),
                    new MultiStructItemCustomView(this, "Guard Knockback Sharpness Usage: Small", "Guard_Knockback_Sharpness_Usage_Small"),
                    new MultiStructItemCustomView(this, "Guard Knockback Sharpness Usage: Medium", "Guard_Knockback_Sharpness_Usage_Medium"),
                    new MultiStructItemCustomView(this, "Guard Knockback Sharpness Usage: Large", "Guard_Knockback_Sharpness_Usage_Large"),
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

        public partial class W07p_Params_3_Shared_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView> {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W07p Params (3, Shared)";

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

            public static W07p_Params_3_Shared_ LoadData(BinaryReader reader, ulong i) {
                var data = new W07p_Params_3_Shared_();
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

        public partial class W07p_Params_4_Shared_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView> {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W07p Params (4, Shared)";

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

            public static W07p_Params_4_Shared_ LoadData(BinaryReader reader, ulong i) {
                var data = new W07p_Params_4_Shared_();
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

        public partial class W07p_Params_5_Shelling_Params : MhwStructItem, IHasCustomView<MultiStructItemCustomView> {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W07p Params (5) - Shelling Params";

            protected uint Normal_Shell_raw;
            public const string Normal_Shell_displayName = "Normal Shell";
            public const int Normal_Shell_sortIndex = 50;
            [SortOrder(Normal_Shell_sortIndex)]
            [DisplayName(Normal_Shell_displayName)]
            public virtual uint Normal_Shell {
                get => Normal_Shell_raw;
                set {
                    if (Normal_Shell_raw == value) return;
                    Normal_Shell_raw = value;
                    OnPropertyChanged(nameof(Normal_Shell));
                }
            }

            protected uint Wide_Shell_raw;
            public const string Wide_Shell_displayName = "Wide Shell";
            public const int Wide_Shell_sortIndex = 100;
            [SortOrder(Wide_Shell_sortIndex)]
            [DisplayName(Wide_Shell_displayName)]
            public virtual uint Wide_Shell {
                get => Wide_Shell_raw;
                set {
                    if (Wide_Shell_raw == value) return;
                    Wide_Shell_raw = value;
                    OnPropertyChanged(nameof(Wide_Shell));
                }
            }

            protected uint Long_Shell_raw;
            public const string Long_Shell_displayName = "Long Shell";
            public const int Long_Shell_sortIndex = 150;
            [SortOrder(Long_Shell_sortIndex)]
            [DisplayName(Long_Shell_displayName)]
            public virtual uint Long_Shell {
                get => Long_Shell_raw;
                set {
                    if (Long_Shell_raw == value) return;
                    Long_Shell_raw = value;
                    OnPropertyChanged(nameof(Long_Shell));
                }
            }

            protected float Shelling_Charge_Delay_Seconds__raw;
            public const string Shelling_Charge_Delay_Seconds__displayName = "Shelling Charge Delay (Seconds)";
            public const int Shelling_Charge_Delay_Seconds__sortIndex = 200;
            [SortOrder(Shelling_Charge_Delay_Seconds__sortIndex)]
            [DisplayName(Shelling_Charge_Delay_Seconds__displayName)]
            public virtual float Shelling_Charge_Delay_Seconds_ {
                get => Shelling_Charge_Delay_Seconds__raw;
                set {
                    if (Shelling_Charge_Delay_Seconds__raw == value) return;
                    Shelling_Charge_Delay_Seconds__raw = value;
                    OnPropertyChanged(nameof(Shelling_Charge_Delay_Seconds_));
                }
            }

            protected float Shelling_Charge_Recoil_Distance_Multiplier_raw;
            public const string Shelling_Charge_Recoil_Distance_Multiplier_displayName = "Shelling Charge Recoil Distance Multiplier";
            public const int Shelling_Charge_Recoil_Distance_Multiplier_sortIndex = 250;
            [SortOrder(Shelling_Charge_Recoil_Distance_Multiplier_sortIndex)]
            [DisplayName(Shelling_Charge_Recoil_Distance_Multiplier_displayName)]
            public virtual float Shelling_Charge_Recoil_Distance_Multiplier {
                get => Shelling_Charge_Recoil_Distance_Multiplier_raw;
                set {
                    if (Shelling_Charge_Recoil_Distance_Multiplier_raw == value) return;
                    Shelling_Charge_Recoil_Distance_Multiplier_raw = value;
                    OnPropertyChanged(nameof(Shelling_Charge_Recoil_Distance_Multiplier));
                }
            }

            protected float Wyvernfire_Charging_Time_Seconds__raw;
            public const string Wyvernfire_Charging_Time_Seconds__displayName = "Wyvernfire Charging Time (Seconds)";
            public const int Wyvernfire_Charging_Time_Seconds__sortIndex = 300;
            [SortOrder(Wyvernfire_Charging_Time_Seconds__sortIndex)]
            [DisplayName(Wyvernfire_Charging_Time_Seconds__displayName)]
            public virtual float Wyvernfire_Charging_Time_Seconds_ {
                get => Wyvernfire_Charging_Time_Seconds__raw;
                set {
                    if (Wyvernfire_Charging_Time_Seconds__raw == value) return;
                    Wyvernfire_Charging_Time_Seconds__raw = value;
                    OnPropertyChanged(nameof(Wyvernfire_Charging_Time_Seconds_));
                }
            }

            protected float Wyvernfire_Cooldown_Time_Seconds__raw;
            public const string Wyvernfire_Cooldown_Time_Seconds__displayName = "Wyvernfire Cooldown Time (Seconds)";
            public const int Wyvernfire_Cooldown_Time_Seconds__sortIndex = 350;
            [SortOrder(Wyvernfire_Cooldown_Time_Seconds__sortIndex)]
            [DisplayName(Wyvernfire_Cooldown_Time_Seconds__displayName)]
            public virtual float Wyvernfire_Cooldown_Time_Seconds_ {
                get => Wyvernfire_Cooldown_Time_Seconds__raw;
                set {
                    if (Wyvernfire_Cooldown_Time_Seconds__raw == value) return;
                    Wyvernfire_Cooldown_Time_Seconds__raw = value;
                    OnPropertyChanged(nameof(Wyvernfire_Cooldown_Time_Seconds_));
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

            protected float Unk_100_raw;
            public const string Unk_100_displayName = "Unk 100";
            public const int Unk_100_sortIndex = 500;
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

            protected uint Shelling_Count_for_Shelling_N_Times_Wyrmstake_e_g_2_Shelling_Twice_Then_Wyrmstake__raw;
            public const string Shelling_Count_for_Shelling_N_Times_Wyrmstake_e_g_2_Shelling_Twice_Then_Wyrmstake__displayName = "Shelling Count for [Shelling (N Times) -> Wyrmstake] (e.g. 2: Shelling (Twice), Then Wyrmstake)";
            public const int Shelling_Count_for_Shelling_N_Times_Wyrmstake_e_g_2_Shelling_Twice_Then_Wyrmstake__sortIndex = 550;
            [SortOrder(Shelling_Count_for_Shelling_N_Times_Wyrmstake_e_g_2_Shelling_Twice_Then_Wyrmstake__sortIndex)]
            [DisplayName(Shelling_Count_for_Shelling_N_Times_Wyrmstake_e_g_2_Shelling_Twice_Then_Wyrmstake__displayName)]
            public virtual uint Shelling_Count_for_Shelling_N_Times_Wyrmstake_e_g_2_Shelling_Twice_Then_Wyrmstake_ {
                get => Shelling_Count_for_Shelling_N_Times_Wyrmstake_e_g_2_Shelling_Twice_Then_Wyrmstake__raw;
                set {
                    if (Shelling_Count_for_Shelling_N_Times_Wyrmstake_e_g_2_Shelling_Twice_Then_Wyrmstake__raw == value) return;
                    Shelling_Count_for_Shelling_N_Times_Wyrmstake_e_g_2_Shelling_Twice_Then_Wyrmstake__raw = value;
                    OnPropertyChanged(nameof(Shelling_Count_for_Shelling_N_Times_Wyrmstake_e_g_2_Shelling_Twice_Then_Wyrmstake_));
                }
            }

            protected float Unk_102_raw;
            public const string Unk_102_displayName = "Unk 102";
            public const int Unk_102_sortIndex = 600;
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

            protected float Unk_104_raw;
            public const string Unk_104_displayName = "Unk 104";
            public const int Unk_104_sortIndex = 700;
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

            protected float Unk_106_raw;
            public const string Unk_106_displayName = "Unk 106";
            public const int Unk_106_sortIndex = 800;
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

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W07p_Params_5_Shelling_Params LoadData(BinaryReader reader, ulong i) {
                var data = new W07p_Params_5_Shelling_Params();
                data.Index = i;
                data.Normal_Shell_raw = reader.ReadUInt32();
                data.Wide_Shell_raw = reader.ReadUInt32();
                data.Long_Shell_raw = reader.ReadUInt32();
                data.Shelling_Charge_Delay_Seconds__raw = reader.ReadSingle();
                data.Shelling_Charge_Recoil_Distance_Multiplier_raw = reader.ReadSingle();
                data.Wyvernfire_Charging_Time_Seconds__raw = reader.ReadSingle();
                data.Wyvernfire_Cooldown_Time_Seconds__raw = reader.ReadSingle();
                data.Unk_98_raw = reader.ReadSingle();
                data.Unk_99_raw = reader.ReadSingle();
                data.Unk_100_raw = reader.ReadSingle();
                data.Shelling_Count_for_Shelling_N_Times_Wyrmstake_e_g_2_Shelling_Twice_Then_Wyrmstake__raw = reader.ReadUInt32();
                data.Unk_102_raw = reader.ReadSingle();
                data.Unk_103_raw = reader.ReadSingle();
                data.Unk_104_raw = reader.ReadSingle();
                data.Unk_105_raw = reader.ReadSingle();
                data.Unk_106_raw = reader.ReadSingle();
                data.Unk_107_raw = reader.ReadSingle();
                data.Unk_108_raw = reader.ReadSingle();
                data.Unk_109_raw = reader.ReadSingle();
                data.Unk_110_raw = reader.ReadSingle();
                data.Unk_111_raw = reader.ReadSingle();
                data.Unk_112_raw = reader.ReadSingle();
                data.Unk_113_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Normal_Shell_raw);
                writer.Write(Wide_Shell_raw);
                writer.Write(Long_Shell_raw);
                writer.Write(Shelling_Charge_Delay_Seconds__raw);
                writer.Write(Shelling_Charge_Recoil_Distance_Multiplier_raw);
                writer.Write(Wyvernfire_Charging_Time_Seconds__raw);
                writer.Write(Wyvernfire_Cooldown_Time_Seconds__raw);
                writer.Write(Unk_98_raw);
                writer.Write(Unk_99_raw);
                writer.Write(Unk_100_raw);
                writer.Write(Shelling_Count_for_Shelling_N_Times_Wyrmstake_e_g_2_Shelling_Twice_Then_Wyrmstake__raw);
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
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Normal Shell", "Normal_Shell"),
                    new MultiStructItemCustomView(this, "Wide Shell", "Wide_Shell"),
                    new MultiStructItemCustomView(this, "Long Shell", "Long_Shell"),
                    new MultiStructItemCustomView(this, "Shelling Charge Delay (Seconds)", "Shelling_Charge_Delay_Seconds_"),
                    new MultiStructItemCustomView(this, "Shelling Charge Recoil Distance Multiplier", "Shelling_Charge_Recoil_Distance_Multiplier"),
                    new MultiStructItemCustomView(this, "Wyvernfire Charging Time (Seconds)", "Wyvernfire_Charging_Time_Seconds_"),
                    new MultiStructItemCustomView(this, "Wyvernfire Cooldown Time (Seconds)", "Wyvernfire_Cooldown_Time_Seconds_"),
                    new MultiStructItemCustomView(this, "Unk 98", "Unk_98"),
                    new MultiStructItemCustomView(this, "Unk 99", "Unk_99"),
                    new MultiStructItemCustomView(this, "Unk 100", "Unk_100"),
                    new MultiStructItemCustomView(this, "Shelling Count for [Shelling (N Times) -> Wyrmstake] (e.g. 2: Shelling (Twice), Then Wyrmstake)", "Shelling_Count_for_Shelling_N_Times_Wyrmstake_e_g_2_Shelling_Twice_Then_Wyrmstake_"),
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
                };
            }
        }

        public partial class Shell_Ammo_Params : MhwStructItem {
            public const ulong FixedSizeCount = 3;
            public const string GridName = "Shell/Ammo Params";

            public partial class Shell_Damage : MhwStructItem, IHasCustomView<MultiStructItemCustomView> {
                public const ulong FixedSizeCount = 1;
                public const string GridName = "Shell Damage";

                protected float Shell_Damage_1_raw;
                public const string Shell_Damage_1_displayName = "Shell Damage 1";
                public const int Shell_Damage_1_sortIndex = 50;
                [SortOrder(Shell_Damage_1_sortIndex)]
                [DisplayName(Shell_Damage_1_displayName)]
                public virtual float Shell_Damage_1 {
                    get => Shell_Damage_1_raw;
                    set {
                        if (Shell_Damage_1_raw == value) return;
                        Shell_Damage_1_raw = value;
                        OnPropertyChanged(nameof(Shell_Damage_1));
                    }
                }

                protected float Shell_Damage_2_raw;
                public const string Shell_Damage_2_displayName = "Shell Damage 2";
                public const int Shell_Damage_2_sortIndex = 100;
                [SortOrder(Shell_Damage_2_sortIndex)]
                [DisplayName(Shell_Damage_2_displayName)]
                public virtual float Shell_Damage_2 {
                    get => Shell_Damage_2_raw;
                    set {
                        if (Shell_Damage_2_raw == value) return;
                        Shell_Damage_2_raw = value;
                        OnPropertyChanged(nameof(Shell_Damage_2));
                    }
                }

                protected float Shell_Damage_3_raw;
                public const string Shell_Damage_3_displayName = "Shell Damage 3";
                public const int Shell_Damage_3_sortIndex = 150;
                [SortOrder(Shell_Damage_3_sortIndex)]
                [DisplayName(Shell_Damage_3_displayName)]
                public virtual float Shell_Damage_3 {
                    get => Shell_Damage_3_raw;
                    set {
                        if (Shell_Damage_3_raw == value) return;
                        Shell_Damage_3_raw = value;
                        OnPropertyChanged(nameof(Shell_Damage_3));
                    }
                }

                protected float Shell_Damage_4_raw;
                public const string Shell_Damage_4_displayName = "Shell Damage 4";
                public const int Shell_Damage_4_sortIndex = 200;
                [SortOrder(Shell_Damage_4_sortIndex)]
                [DisplayName(Shell_Damage_4_displayName)]
                public virtual float Shell_Damage_4 {
                    get => Shell_Damage_4_raw;
                    set {
                        if (Shell_Damage_4_raw == value) return;
                        Shell_Damage_4_raw = value;
                        OnPropertyChanged(nameof(Shell_Damage_4));
                    }
                }

                protected float Shell_Damage_5_raw;
                public const string Shell_Damage_5_displayName = "Shell Damage 5";
                public const int Shell_Damage_5_sortIndex = 250;
                [SortOrder(Shell_Damage_5_sortIndex)]
                [DisplayName(Shell_Damage_5_displayName)]
                public virtual float Shell_Damage_5 {
                    get => Shell_Damage_5_raw;
                    set {
                        if (Shell_Damage_5_raw == value) return;
                        Shell_Damage_5_raw = value;
                        OnPropertyChanged(nameof(Shell_Damage_5));
                    }
                }

                protected float Shell_Damage_6_raw;
                public const string Shell_Damage_6_displayName = "Shell Damage 6";
                public const int Shell_Damage_6_sortIndex = 300;
                [SortOrder(Shell_Damage_6_sortIndex)]
                [DisplayName(Shell_Damage_6_displayName)]
                public virtual float Shell_Damage_6 {
                    get => Shell_Damage_6_raw;
                    set {
                        if (Shell_Damage_6_raw == value) return;
                        Shell_Damage_6_raw = value;
                        OnPropertyChanged(nameof(Shell_Damage_6));
                    }
                }

                protected float Shell_Damage_7_raw;
                public const string Shell_Damage_7_displayName = "Shell Damage 7";
                public const int Shell_Damage_7_sortIndex = 350;
                [SortOrder(Shell_Damage_7_sortIndex)]
                [DisplayName(Shell_Damage_7_displayName)]
                public virtual float Shell_Damage_7 {
                    get => Shell_Damage_7_raw;
                    set {
                        if (Shell_Damage_7_raw == value) return;
                        Shell_Damage_7_raw = value;
                        OnPropertyChanged(nameof(Shell_Damage_7));
                    }
                }

                public static ObservableCollection<Shell_Damage> LoadData(BinaryReader reader, Shell_Ammo_Params parent) {
                    var list = new ObservableCollection<Shell_Damage>();
                    var count = 1UL;
                    for (ulong i = 0; i < count; i++) {
                        list.Add(LoadData(reader, i, parent));
                    }
                    return list;
                }

                public static Shell_Damage LoadData(BinaryReader reader, ulong i, Shell_Ammo_Params parent) {
                    var data = new Shell_Damage();
                    data.Index = i;
                    data.Shell_Damage_1_raw = reader.ReadSingle();
                    data.Shell_Damage_2_raw = reader.ReadSingle();
                    data.Shell_Damage_3_raw = reader.ReadSingle();
                    data.Shell_Damage_4_raw = reader.ReadSingle();
                    data.Shell_Damage_5_raw = reader.ReadSingle();
                    data.Shell_Damage_6_raw = reader.ReadSingle();
                    data.Shell_Damage_7_raw = reader.ReadSingle();
                    return data;
                }

                public void WriteData(BinaryWriter writer, Shell_Ammo_Params parent) {
                    writer.Write(Shell_Damage_1_raw);
                    writer.Write(Shell_Damage_2_raw);
                    writer.Write(Shell_Damage_3_raw);
                    writer.Write(Shell_Damage_4_raw);
                    writer.Write(Shell_Damage_5_raw);
                    writer.Write(Shell_Damage_6_raw);
                    writer.Write(Shell_Damage_7_raw);
                }

                public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                    return new ObservableCollection<MultiStructItemCustomView> {
                        new MultiStructItemCustomView(this, "Shell Damage 1", "Shell_Damage_1"),
                        new MultiStructItemCustomView(this, "Shell Damage 2", "Shell_Damage_2"),
                        new MultiStructItemCustomView(this, "Shell Damage 3", "Shell_Damage_3"),
                        new MultiStructItemCustomView(this, "Shell Damage 4", "Shell_Damage_4"),
                        new MultiStructItemCustomView(this, "Shell Damage 5", "Shell_Damage_5"),
                        new MultiStructItemCustomView(this, "Shell Damage 6", "Shell_Damage_6"),
                        new MultiStructItemCustomView(this, "Shell Damage 7", "Shell_Damage_7"),
                    };
                }
            }

            public const string Shell_Damage_displayName = "Shell Damage";
            public const int Shell_Damage_sortIndex = 50;
            [SortOrder(Shell_Damage_sortIndex)]
            [DisplayName(Shell_Damage_displayName)]
            public virtual ObservableCollection<Shell_Damage> Shell_Damage_raw { get; protected set; }

            public partial class Shell_Fire_Damage : MhwStructItem, IHasCustomView<MultiStructItemCustomView> {
                public const ulong FixedSizeCount = 1;
                public const string GridName = "Shell Fire Damage";

                protected float Shell_Fire_Damage_1_raw;
                public const string Shell_Fire_Damage_1_displayName = "Shell Fire Damage 1";
                public const int Shell_Fire_Damage_1_sortIndex = 50;
                [SortOrder(Shell_Fire_Damage_1_sortIndex)]
                [DisplayName(Shell_Fire_Damage_1_displayName)]
                public virtual float Shell_Fire_Damage_1 {
                    get => Shell_Fire_Damage_1_raw;
                    set {
                        if (Shell_Fire_Damage_1_raw == value) return;
                        Shell_Fire_Damage_1_raw = value;
                        OnPropertyChanged(nameof(Shell_Fire_Damage_1));
                    }
                }

                protected float Shell_Fire_Damage_2_raw;
                public const string Shell_Fire_Damage_2_displayName = "Shell Fire Damage 2";
                public const int Shell_Fire_Damage_2_sortIndex = 100;
                [SortOrder(Shell_Fire_Damage_2_sortIndex)]
                [DisplayName(Shell_Fire_Damage_2_displayName)]
                public virtual float Shell_Fire_Damage_2 {
                    get => Shell_Fire_Damage_2_raw;
                    set {
                        if (Shell_Fire_Damage_2_raw == value) return;
                        Shell_Fire_Damage_2_raw = value;
                        OnPropertyChanged(nameof(Shell_Fire_Damage_2));
                    }
                }

                protected float Shell_Fire_Damage_3_raw;
                public const string Shell_Fire_Damage_3_displayName = "Shell Fire Damage 3";
                public const int Shell_Fire_Damage_3_sortIndex = 150;
                [SortOrder(Shell_Fire_Damage_3_sortIndex)]
                [DisplayName(Shell_Fire_Damage_3_displayName)]
                public virtual float Shell_Fire_Damage_3 {
                    get => Shell_Fire_Damage_3_raw;
                    set {
                        if (Shell_Fire_Damage_3_raw == value) return;
                        Shell_Fire_Damage_3_raw = value;
                        OnPropertyChanged(nameof(Shell_Fire_Damage_3));
                    }
                }

                protected float Shell_Fire_Damage_4_raw;
                public const string Shell_Fire_Damage_4_displayName = "Shell Fire Damage 4";
                public const int Shell_Fire_Damage_4_sortIndex = 200;
                [SortOrder(Shell_Fire_Damage_4_sortIndex)]
                [DisplayName(Shell_Fire_Damage_4_displayName)]
                public virtual float Shell_Fire_Damage_4 {
                    get => Shell_Fire_Damage_4_raw;
                    set {
                        if (Shell_Fire_Damage_4_raw == value) return;
                        Shell_Fire_Damage_4_raw = value;
                        OnPropertyChanged(nameof(Shell_Fire_Damage_4));
                    }
                }

                protected float Shell_Fire_Damage_5_raw;
                public const string Shell_Fire_Damage_5_displayName = "Shell Fire Damage 5";
                public const int Shell_Fire_Damage_5_sortIndex = 250;
                [SortOrder(Shell_Fire_Damage_5_sortIndex)]
                [DisplayName(Shell_Fire_Damage_5_displayName)]
                public virtual float Shell_Fire_Damage_5 {
                    get => Shell_Fire_Damage_5_raw;
                    set {
                        if (Shell_Fire_Damage_5_raw == value) return;
                        Shell_Fire_Damage_5_raw = value;
                        OnPropertyChanged(nameof(Shell_Fire_Damage_5));
                    }
                }

                protected float Shell_Fire_Damage_6_raw;
                public const string Shell_Fire_Damage_6_displayName = "Shell Fire Damage 6";
                public const int Shell_Fire_Damage_6_sortIndex = 300;
                [SortOrder(Shell_Fire_Damage_6_sortIndex)]
                [DisplayName(Shell_Fire_Damage_6_displayName)]
                public virtual float Shell_Fire_Damage_6 {
                    get => Shell_Fire_Damage_6_raw;
                    set {
                        if (Shell_Fire_Damage_6_raw == value) return;
                        Shell_Fire_Damage_6_raw = value;
                        OnPropertyChanged(nameof(Shell_Fire_Damage_6));
                    }
                }

                protected float Shell_Fire_Damage_7_raw;
                public const string Shell_Fire_Damage_7_displayName = "Shell Fire Damage 7";
                public const int Shell_Fire_Damage_7_sortIndex = 350;
                [SortOrder(Shell_Fire_Damage_7_sortIndex)]
                [DisplayName(Shell_Fire_Damage_7_displayName)]
                public virtual float Shell_Fire_Damage_7 {
                    get => Shell_Fire_Damage_7_raw;
                    set {
                        if (Shell_Fire_Damage_7_raw == value) return;
                        Shell_Fire_Damage_7_raw = value;
                        OnPropertyChanged(nameof(Shell_Fire_Damage_7));
                    }
                }

                public static ObservableCollection<Shell_Fire_Damage> LoadData(BinaryReader reader, Shell_Ammo_Params parent) {
                    var list = new ObservableCollection<Shell_Fire_Damage>();
                    var count = 1UL;
                    for (ulong i = 0; i < count; i++) {
                        list.Add(LoadData(reader, i, parent));
                    }
                    return list;
                }

                public static Shell_Fire_Damage LoadData(BinaryReader reader, ulong i, Shell_Ammo_Params parent) {
                    var data = new Shell_Fire_Damage();
                    data.Index = i;
                    data.Shell_Fire_Damage_1_raw = reader.ReadSingle();
                    data.Shell_Fire_Damage_2_raw = reader.ReadSingle();
                    data.Shell_Fire_Damage_3_raw = reader.ReadSingle();
                    data.Shell_Fire_Damage_4_raw = reader.ReadSingle();
                    data.Shell_Fire_Damage_5_raw = reader.ReadSingle();
                    data.Shell_Fire_Damage_6_raw = reader.ReadSingle();
                    data.Shell_Fire_Damage_7_raw = reader.ReadSingle();
                    return data;
                }

                public void WriteData(BinaryWriter writer, Shell_Ammo_Params parent) {
                    writer.Write(Shell_Fire_Damage_1_raw);
                    writer.Write(Shell_Fire_Damage_2_raw);
                    writer.Write(Shell_Fire_Damage_3_raw);
                    writer.Write(Shell_Fire_Damage_4_raw);
                    writer.Write(Shell_Fire_Damage_5_raw);
                    writer.Write(Shell_Fire_Damage_6_raw);
                    writer.Write(Shell_Fire_Damage_7_raw);
                }

                public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                    return new ObservableCollection<MultiStructItemCustomView> {
                        new MultiStructItemCustomView(this, "Shell Fire Damage 1", "Shell_Fire_Damage_1"),
                        new MultiStructItemCustomView(this, "Shell Fire Damage 2", "Shell_Fire_Damage_2"),
                        new MultiStructItemCustomView(this, "Shell Fire Damage 3", "Shell_Fire_Damage_3"),
                        new MultiStructItemCustomView(this, "Shell Fire Damage 4", "Shell_Fire_Damage_4"),
                        new MultiStructItemCustomView(this, "Shell Fire Damage 5", "Shell_Fire_Damage_5"),
                        new MultiStructItemCustomView(this, "Shell Fire Damage 6", "Shell_Fire_Damage_6"),
                        new MultiStructItemCustomView(this, "Shell Fire Damage 7", "Shell_Fire_Damage_7"),
                    };
                }
            }

            public const string Shell_Fire_Damage_displayName = "Shell Fire Damage";
            public const int Shell_Fire_Damage_sortIndex = 100;
            [SortOrder(Shell_Fire_Damage_sortIndex)]
            [DisplayName(Shell_Fire_Damage_displayName)]
            public virtual ObservableCollection<Shell_Fire_Damage> Shell_Fire_Damage_raw { get; protected set; }

            protected float Shell_Charged_Multiplier_raw;
            public const string Shell_Charged_Multiplier_displayName = "Shell Charged Multiplier";
            public const int Shell_Charged_Multiplier_sortIndex = 150;
            [SortOrder(Shell_Charged_Multiplier_sortIndex)]
            [DisplayName(Shell_Charged_Multiplier_displayName)]
            public virtual float Shell_Charged_Multiplier {
                get => Shell_Charged_Multiplier_raw;
                set {
                    if (Shell_Charged_Multiplier_raw == value) return;
                    Shell_Charged_Multiplier_raw = value;
                    OnPropertyChanged(nameof(Shell_Charged_Multiplier));
                }
            }

            protected float Full_burst_Multiplier_raw;
            public const string Full_burst_Multiplier_displayName = "Full-burst Multiplier";
            public const int Full_burst_Multiplier_sortIndex = 200;
            [SortOrder(Full_burst_Multiplier_sortIndex)]
            [DisplayName(Full_burst_Multiplier_displayName)]
            public virtual float Full_burst_Multiplier {
                get => Full_burst_Multiplier_raw;
                set {
                    if (Full_burst_Multiplier_raw == value) return;
                    Full_burst_Multiplier_raw = value;
                    OnPropertyChanged(nameof(Full_burst_Multiplier));
                }
            }

            protected float Shell_Unk_1_raw;
            public const string Shell_Unk_1_displayName = "Shell Unk 1";
            public const int Shell_Unk_1_sortIndex = 250;
            [SortOrder(Shell_Unk_1_sortIndex)]
            [DisplayName(Shell_Unk_1_displayName)]
            public virtual float Shell_Unk_1 {
                get => Shell_Unk_1_raw;
                set {
                    if (Shell_Unk_1_raw == value) return;
                    Shell_Unk_1_raw = value;
                    OnPropertyChanged(nameof(Shell_Unk_1));
                }
            }

            public partial class Wyvernfire_Damage : MhwStructItem, IHasCustomView<MultiStructItemCustomView> {
                public const ulong FixedSizeCount = 1;
                public const string GridName = "Wyvernfire Damage";

                protected float Wyvernfire_Damage_1_raw;
                public const string Wyvernfire_Damage_1_displayName = "Wyvernfire Damage 1";
                public const int Wyvernfire_Damage_1_sortIndex = 50;
                [SortOrder(Wyvernfire_Damage_1_sortIndex)]
                [DisplayName(Wyvernfire_Damage_1_displayName)]
                public virtual float Wyvernfire_Damage_1 {
                    get => Wyvernfire_Damage_1_raw;
                    set {
                        if (Wyvernfire_Damage_1_raw == value) return;
                        Wyvernfire_Damage_1_raw = value;
                        OnPropertyChanged(nameof(Wyvernfire_Damage_1));
                    }
                }

                protected float Wyvernfire_Damage_2_raw;
                public const string Wyvernfire_Damage_2_displayName = "Wyvernfire Damage 2";
                public const int Wyvernfire_Damage_2_sortIndex = 100;
                [SortOrder(Wyvernfire_Damage_2_sortIndex)]
                [DisplayName(Wyvernfire_Damage_2_displayName)]
                public virtual float Wyvernfire_Damage_2 {
                    get => Wyvernfire_Damage_2_raw;
                    set {
                        if (Wyvernfire_Damage_2_raw == value) return;
                        Wyvernfire_Damage_2_raw = value;
                        OnPropertyChanged(nameof(Wyvernfire_Damage_2));
                    }
                }

                protected float Wyvernfire_Damage_3_raw;
                public const string Wyvernfire_Damage_3_displayName = "Wyvernfire Damage 3";
                public const int Wyvernfire_Damage_3_sortIndex = 150;
                [SortOrder(Wyvernfire_Damage_3_sortIndex)]
                [DisplayName(Wyvernfire_Damage_3_displayName)]
                public virtual float Wyvernfire_Damage_3 {
                    get => Wyvernfire_Damage_3_raw;
                    set {
                        if (Wyvernfire_Damage_3_raw == value) return;
                        Wyvernfire_Damage_3_raw = value;
                        OnPropertyChanged(nameof(Wyvernfire_Damage_3));
                    }
                }

                protected float Wyvernfire_Damage_4_raw;
                public const string Wyvernfire_Damage_4_displayName = "Wyvernfire Damage 4";
                public const int Wyvernfire_Damage_4_sortIndex = 200;
                [SortOrder(Wyvernfire_Damage_4_sortIndex)]
                [DisplayName(Wyvernfire_Damage_4_displayName)]
                public virtual float Wyvernfire_Damage_4 {
                    get => Wyvernfire_Damage_4_raw;
                    set {
                        if (Wyvernfire_Damage_4_raw == value) return;
                        Wyvernfire_Damage_4_raw = value;
                        OnPropertyChanged(nameof(Wyvernfire_Damage_4));
                    }
                }

                protected float Wyvernfire_Damage_5_raw;
                public const string Wyvernfire_Damage_5_displayName = "Wyvernfire Damage 5";
                public const int Wyvernfire_Damage_5_sortIndex = 250;
                [SortOrder(Wyvernfire_Damage_5_sortIndex)]
                [DisplayName(Wyvernfire_Damage_5_displayName)]
                public virtual float Wyvernfire_Damage_5 {
                    get => Wyvernfire_Damage_5_raw;
                    set {
                        if (Wyvernfire_Damage_5_raw == value) return;
                        Wyvernfire_Damage_5_raw = value;
                        OnPropertyChanged(nameof(Wyvernfire_Damage_5));
                    }
                }

                protected float Wyvernfire_Damage_6_raw;
                public const string Wyvernfire_Damage_6_displayName = "Wyvernfire Damage 6";
                public const int Wyvernfire_Damage_6_sortIndex = 300;
                [SortOrder(Wyvernfire_Damage_6_sortIndex)]
                [DisplayName(Wyvernfire_Damage_6_displayName)]
                public virtual float Wyvernfire_Damage_6 {
                    get => Wyvernfire_Damage_6_raw;
                    set {
                        if (Wyvernfire_Damage_6_raw == value) return;
                        Wyvernfire_Damage_6_raw = value;
                        OnPropertyChanged(nameof(Wyvernfire_Damage_6));
                    }
                }

                protected float Wyvernfire_Damage_7_raw;
                public const string Wyvernfire_Damage_7_displayName = "Wyvernfire Damage 7";
                public const int Wyvernfire_Damage_7_sortIndex = 350;
                [SortOrder(Wyvernfire_Damage_7_sortIndex)]
                [DisplayName(Wyvernfire_Damage_7_displayName)]
                public virtual float Wyvernfire_Damage_7 {
                    get => Wyvernfire_Damage_7_raw;
                    set {
                        if (Wyvernfire_Damage_7_raw == value) return;
                        Wyvernfire_Damage_7_raw = value;
                        OnPropertyChanged(nameof(Wyvernfire_Damage_7));
                    }
                }

                public static ObservableCollection<Wyvernfire_Damage> LoadData(BinaryReader reader, Shell_Ammo_Params parent) {
                    var list = new ObservableCollection<Wyvernfire_Damage>();
                    var count = 1UL;
                    for (ulong i = 0; i < count; i++) {
                        list.Add(LoadData(reader, i, parent));
                    }
                    return list;
                }

                public static Wyvernfire_Damage LoadData(BinaryReader reader, ulong i, Shell_Ammo_Params parent) {
                    var data = new Wyvernfire_Damage();
                    data.Index = i;
                    data.Wyvernfire_Damage_1_raw = reader.ReadSingle();
                    data.Wyvernfire_Damage_2_raw = reader.ReadSingle();
                    data.Wyvernfire_Damage_3_raw = reader.ReadSingle();
                    data.Wyvernfire_Damage_4_raw = reader.ReadSingle();
                    data.Wyvernfire_Damage_5_raw = reader.ReadSingle();
                    data.Wyvernfire_Damage_6_raw = reader.ReadSingle();
                    data.Wyvernfire_Damage_7_raw = reader.ReadSingle();
                    return data;
                }

                public void WriteData(BinaryWriter writer, Shell_Ammo_Params parent) {
                    writer.Write(Wyvernfire_Damage_1_raw);
                    writer.Write(Wyvernfire_Damage_2_raw);
                    writer.Write(Wyvernfire_Damage_3_raw);
                    writer.Write(Wyvernfire_Damage_4_raw);
                    writer.Write(Wyvernfire_Damage_5_raw);
                    writer.Write(Wyvernfire_Damage_6_raw);
                    writer.Write(Wyvernfire_Damage_7_raw);
                }

                public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                    return new ObservableCollection<MultiStructItemCustomView> {
                        new MultiStructItemCustomView(this, "Wyvernfire Damage 1", "Wyvernfire_Damage_1"),
                        new MultiStructItemCustomView(this, "Wyvernfire Damage 2", "Wyvernfire_Damage_2"),
                        new MultiStructItemCustomView(this, "Wyvernfire Damage 3", "Wyvernfire_Damage_3"),
                        new MultiStructItemCustomView(this, "Wyvernfire Damage 4", "Wyvernfire_Damage_4"),
                        new MultiStructItemCustomView(this, "Wyvernfire Damage 5", "Wyvernfire_Damage_5"),
                        new MultiStructItemCustomView(this, "Wyvernfire Damage 6", "Wyvernfire_Damage_6"),
                        new MultiStructItemCustomView(this, "Wyvernfire Damage 7", "Wyvernfire_Damage_7"),
                    };
                }
            }

            public const string Wyvernfire_Damage_displayName = "Wyvernfire Damage";
            public const int Wyvernfire_Damage_sortIndex = 300;
            [SortOrder(Wyvernfire_Damage_sortIndex)]
            [DisplayName(Wyvernfire_Damage_displayName)]
            public virtual ObservableCollection<Wyvernfire_Damage> Wyvernfire_Damage_raw { get; protected set; }

            public partial class Wyvernfire_Fire_Damage : MhwStructItem, IHasCustomView<MultiStructItemCustomView> {
                public const ulong FixedSizeCount = 1;
                public const string GridName = "Wyvernfire Fire Damage";

                protected float Wyvernfire_Fire_Damage_1_raw;
                public const string Wyvernfire_Fire_Damage_1_displayName = "Wyvernfire Fire Damage 1";
                public const int Wyvernfire_Fire_Damage_1_sortIndex = 50;
                [SortOrder(Wyvernfire_Fire_Damage_1_sortIndex)]
                [DisplayName(Wyvernfire_Fire_Damage_1_displayName)]
                public virtual float Wyvernfire_Fire_Damage_1 {
                    get => Wyvernfire_Fire_Damage_1_raw;
                    set {
                        if (Wyvernfire_Fire_Damage_1_raw == value) return;
                        Wyvernfire_Fire_Damage_1_raw = value;
                        OnPropertyChanged(nameof(Wyvernfire_Fire_Damage_1));
                    }
                }

                protected float Wyvernfire_Fire_Damage_2_raw;
                public const string Wyvernfire_Fire_Damage_2_displayName = "Wyvernfire Fire Damage 2";
                public const int Wyvernfire_Fire_Damage_2_sortIndex = 100;
                [SortOrder(Wyvernfire_Fire_Damage_2_sortIndex)]
                [DisplayName(Wyvernfire_Fire_Damage_2_displayName)]
                public virtual float Wyvernfire_Fire_Damage_2 {
                    get => Wyvernfire_Fire_Damage_2_raw;
                    set {
                        if (Wyvernfire_Fire_Damage_2_raw == value) return;
                        Wyvernfire_Fire_Damage_2_raw = value;
                        OnPropertyChanged(nameof(Wyvernfire_Fire_Damage_2));
                    }
                }

                protected float Wyvernfire_Fire_Damage_3_raw;
                public const string Wyvernfire_Fire_Damage_3_displayName = "Wyvernfire Fire Damage 3";
                public const int Wyvernfire_Fire_Damage_3_sortIndex = 150;
                [SortOrder(Wyvernfire_Fire_Damage_3_sortIndex)]
                [DisplayName(Wyvernfire_Fire_Damage_3_displayName)]
                public virtual float Wyvernfire_Fire_Damage_3 {
                    get => Wyvernfire_Fire_Damage_3_raw;
                    set {
                        if (Wyvernfire_Fire_Damage_3_raw == value) return;
                        Wyvernfire_Fire_Damage_3_raw = value;
                        OnPropertyChanged(nameof(Wyvernfire_Fire_Damage_3));
                    }
                }

                protected float Wyvernfire_Fire_Damage_4_raw;
                public const string Wyvernfire_Fire_Damage_4_displayName = "Wyvernfire Fire Damage 4";
                public const int Wyvernfire_Fire_Damage_4_sortIndex = 200;
                [SortOrder(Wyvernfire_Fire_Damage_4_sortIndex)]
                [DisplayName(Wyvernfire_Fire_Damage_4_displayName)]
                public virtual float Wyvernfire_Fire_Damage_4 {
                    get => Wyvernfire_Fire_Damage_4_raw;
                    set {
                        if (Wyvernfire_Fire_Damage_4_raw == value) return;
                        Wyvernfire_Fire_Damage_4_raw = value;
                        OnPropertyChanged(nameof(Wyvernfire_Fire_Damage_4));
                    }
                }

                protected float Wyvernfire_Fire_Damage_5_raw;
                public const string Wyvernfire_Fire_Damage_5_displayName = "Wyvernfire Fire Damage 5";
                public const int Wyvernfire_Fire_Damage_5_sortIndex = 250;
                [SortOrder(Wyvernfire_Fire_Damage_5_sortIndex)]
                [DisplayName(Wyvernfire_Fire_Damage_5_displayName)]
                public virtual float Wyvernfire_Fire_Damage_5 {
                    get => Wyvernfire_Fire_Damage_5_raw;
                    set {
                        if (Wyvernfire_Fire_Damage_5_raw == value) return;
                        Wyvernfire_Fire_Damage_5_raw = value;
                        OnPropertyChanged(nameof(Wyvernfire_Fire_Damage_5));
                    }
                }

                protected float Wyvernfire_Fire_Damage_6_raw;
                public const string Wyvernfire_Fire_Damage_6_displayName = "Wyvernfire Fire Damage 6";
                public const int Wyvernfire_Fire_Damage_6_sortIndex = 300;
                [SortOrder(Wyvernfire_Fire_Damage_6_sortIndex)]
                [DisplayName(Wyvernfire_Fire_Damage_6_displayName)]
                public virtual float Wyvernfire_Fire_Damage_6 {
                    get => Wyvernfire_Fire_Damage_6_raw;
                    set {
                        if (Wyvernfire_Fire_Damage_6_raw == value) return;
                        Wyvernfire_Fire_Damage_6_raw = value;
                        OnPropertyChanged(nameof(Wyvernfire_Fire_Damage_6));
                    }
                }

                protected float Wyvernfire_Fire_Damage_7_raw;
                public const string Wyvernfire_Fire_Damage_7_displayName = "Wyvernfire Fire Damage 7";
                public const int Wyvernfire_Fire_Damage_7_sortIndex = 350;
                [SortOrder(Wyvernfire_Fire_Damage_7_sortIndex)]
                [DisplayName(Wyvernfire_Fire_Damage_7_displayName)]
                public virtual float Wyvernfire_Fire_Damage_7 {
                    get => Wyvernfire_Fire_Damage_7_raw;
                    set {
                        if (Wyvernfire_Fire_Damage_7_raw == value) return;
                        Wyvernfire_Fire_Damage_7_raw = value;
                        OnPropertyChanged(nameof(Wyvernfire_Fire_Damage_7));
                    }
                }

                public static ObservableCollection<Wyvernfire_Fire_Damage> LoadData(BinaryReader reader, Shell_Ammo_Params parent) {
                    var list = new ObservableCollection<Wyvernfire_Fire_Damage>();
                    var count = 1UL;
                    for (ulong i = 0; i < count; i++) {
                        list.Add(LoadData(reader, i, parent));
                    }
                    return list;
                }

                public static Wyvernfire_Fire_Damage LoadData(BinaryReader reader, ulong i, Shell_Ammo_Params parent) {
                    var data = new Wyvernfire_Fire_Damage();
                    data.Index = i;
                    data.Wyvernfire_Fire_Damage_1_raw = reader.ReadSingle();
                    data.Wyvernfire_Fire_Damage_2_raw = reader.ReadSingle();
                    data.Wyvernfire_Fire_Damage_3_raw = reader.ReadSingle();
                    data.Wyvernfire_Fire_Damage_4_raw = reader.ReadSingle();
                    data.Wyvernfire_Fire_Damage_5_raw = reader.ReadSingle();
                    data.Wyvernfire_Fire_Damage_6_raw = reader.ReadSingle();
                    data.Wyvernfire_Fire_Damage_7_raw = reader.ReadSingle();
                    return data;
                }

                public void WriteData(BinaryWriter writer, Shell_Ammo_Params parent) {
                    writer.Write(Wyvernfire_Fire_Damage_1_raw);
                    writer.Write(Wyvernfire_Fire_Damage_2_raw);
                    writer.Write(Wyvernfire_Fire_Damage_3_raw);
                    writer.Write(Wyvernfire_Fire_Damage_4_raw);
                    writer.Write(Wyvernfire_Fire_Damage_5_raw);
                    writer.Write(Wyvernfire_Fire_Damage_6_raw);
                    writer.Write(Wyvernfire_Fire_Damage_7_raw);
                }

                public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                    return new ObservableCollection<MultiStructItemCustomView> {
                        new MultiStructItemCustomView(this, "Wyvernfire Fire Damage 1", "Wyvernfire_Fire_Damage_1"),
                        new MultiStructItemCustomView(this, "Wyvernfire Fire Damage 2", "Wyvernfire_Fire_Damage_2"),
                        new MultiStructItemCustomView(this, "Wyvernfire Fire Damage 3", "Wyvernfire_Fire_Damage_3"),
                        new MultiStructItemCustomView(this, "Wyvernfire Fire Damage 4", "Wyvernfire_Fire_Damage_4"),
                        new MultiStructItemCustomView(this, "Wyvernfire Fire Damage 5", "Wyvernfire_Fire_Damage_5"),
                        new MultiStructItemCustomView(this, "Wyvernfire Fire Damage 6", "Wyvernfire_Fire_Damage_6"),
                        new MultiStructItemCustomView(this, "Wyvernfire Fire Damage 7", "Wyvernfire_Fire_Damage_7"),
                    };
                }
            }

            public const string Wyvernfire_Fire_Damage_displayName = "Wyvernfire Fire Damage";
            public const int Wyvernfire_Fire_Damage_sortIndex = 350;
            [SortOrder(Wyvernfire_Fire_Damage_sortIndex)]
            [DisplayName(Wyvernfire_Fire_Damage_displayName)]
            public virtual ObservableCollection<Wyvernfire_Fire_Damage> Wyvernfire_Fire_Damage_raw { get; protected set; }

            public partial class Wyrmstake_Tick_Raw_Damage : MhwStructItem, IHasCustomView<MultiStructItemCustomView> {
                public const ulong FixedSizeCount = 1;
                public const string GridName = "Wyrmstake Tick Raw Damage";

                protected float Wyrmstake_Tick_Raw_Damage_1_raw;
                public const string Wyrmstake_Tick_Raw_Damage_1_displayName = "Wyrmstake Tick Raw Damage 1";
                public const int Wyrmstake_Tick_Raw_Damage_1_sortIndex = 50;
                [SortOrder(Wyrmstake_Tick_Raw_Damage_1_sortIndex)]
                [DisplayName(Wyrmstake_Tick_Raw_Damage_1_displayName)]
                public virtual float Wyrmstake_Tick_Raw_Damage_1 {
                    get => Wyrmstake_Tick_Raw_Damage_1_raw;
                    set {
                        if (Wyrmstake_Tick_Raw_Damage_1_raw == value) return;
                        Wyrmstake_Tick_Raw_Damage_1_raw = value;
                        OnPropertyChanged(nameof(Wyrmstake_Tick_Raw_Damage_1));
                    }
                }

                protected float Wyrmstake_Tick_Raw_Damage_2_raw;
                public const string Wyrmstake_Tick_Raw_Damage_2_displayName = "Wyrmstake Tick Raw Damage 2";
                public const int Wyrmstake_Tick_Raw_Damage_2_sortIndex = 100;
                [SortOrder(Wyrmstake_Tick_Raw_Damage_2_sortIndex)]
                [DisplayName(Wyrmstake_Tick_Raw_Damage_2_displayName)]
                public virtual float Wyrmstake_Tick_Raw_Damage_2 {
                    get => Wyrmstake_Tick_Raw_Damage_2_raw;
                    set {
                        if (Wyrmstake_Tick_Raw_Damage_2_raw == value) return;
                        Wyrmstake_Tick_Raw_Damage_2_raw = value;
                        OnPropertyChanged(nameof(Wyrmstake_Tick_Raw_Damage_2));
                    }
                }

                protected float Wyrmstake_Tick_Raw_Damage_3_raw;
                public const string Wyrmstake_Tick_Raw_Damage_3_displayName = "Wyrmstake Tick Raw Damage 3";
                public const int Wyrmstake_Tick_Raw_Damage_3_sortIndex = 150;
                [SortOrder(Wyrmstake_Tick_Raw_Damage_3_sortIndex)]
                [DisplayName(Wyrmstake_Tick_Raw_Damage_3_displayName)]
                public virtual float Wyrmstake_Tick_Raw_Damage_3 {
                    get => Wyrmstake_Tick_Raw_Damage_3_raw;
                    set {
                        if (Wyrmstake_Tick_Raw_Damage_3_raw == value) return;
                        Wyrmstake_Tick_Raw_Damage_3_raw = value;
                        OnPropertyChanged(nameof(Wyrmstake_Tick_Raw_Damage_3));
                    }
                }

                protected float Wyrmstake_Tick_Raw_Damage_4_raw;
                public const string Wyrmstake_Tick_Raw_Damage_4_displayName = "Wyrmstake Tick Raw Damage 4";
                public const int Wyrmstake_Tick_Raw_Damage_4_sortIndex = 200;
                [SortOrder(Wyrmstake_Tick_Raw_Damage_4_sortIndex)]
                [DisplayName(Wyrmstake_Tick_Raw_Damage_4_displayName)]
                public virtual float Wyrmstake_Tick_Raw_Damage_4 {
                    get => Wyrmstake_Tick_Raw_Damage_4_raw;
                    set {
                        if (Wyrmstake_Tick_Raw_Damage_4_raw == value) return;
                        Wyrmstake_Tick_Raw_Damage_4_raw = value;
                        OnPropertyChanged(nameof(Wyrmstake_Tick_Raw_Damage_4));
                    }
                }

                protected float Wyrmstake_Tick_Raw_Damage_5_raw;
                public const string Wyrmstake_Tick_Raw_Damage_5_displayName = "Wyrmstake Tick Raw Damage 5";
                public const int Wyrmstake_Tick_Raw_Damage_5_sortIndex = 250;
                [SortOrder(Wyrmstake_Tick_Raw_Damage_5_sortIndex)]
                [DisplayName(Wyrmstake_Tick_Raw_Damage_5_displayName)]
                public virtual float Wyrmstake_Tick_Raw_Damage_5 {
                    get => Wyrmstake_Tick_Raw_Damage_5_raw;
                    set {
                        if (Wyrmstake_Tick_Raw_Damage_5_raw == value) return;
                        Wyrmstake_Tick_Raw_Damage_5_raw = value;
                        OnPropertyChanged(nameof(Wyrmstake_Tick_Raw_Damage_5));
                    }
                }

                protected float Wyrmstake_Tick_Raw_Damage_6_raw;
                public const string Wyrmstake_Tick_Raw_Damage_6_displayName = "Wyrmstake Tick Raw Damage 6";
                public const int Wyrmstake_Tick_Raw_Damage_6_sortIndex = 300;
                [SortOrder(Wyrmstake_Tick_Raw_Damage_6_sortIndex)]
                [DisplayName(Wyrmstake_Tick_Raw_Damage_6_displayName)]
                public virtual float Wyrmstake_Tick_Raw_Damage_6 {
                    get => Wyrmstake_Tick_Raw_Damage_6_raw;
                    set {
                        if (Wyrmstake_Tick_Raw_Damage_6_raw == value) return;
                        Wyrmstake_Tick_Raw_Damage_6_raw = value;
                        OnPropertyChanged(nameof(Wyrmstake_Tick_Raw_Damage_6));
                    }
                }

                protected float Wyrmstake_Tick_Raw_Damage_7_raw;
                public const string Wyrmstake_Tick_Raw_Damage_7_displayName = "Wyrmstake Tick Raw Damage 7";
                public const int Wyrmstake_Tick_Raw_Damage_7_sortIndex = 350;
                [SortOrder(Wyrmstake_Tick_Raw_Damage_7_sortIndex)]
                [DisplayName(Wyrmstake_Tick_Raw_Damage_7_displayName)]
                public virtual float Wyrmstake_Tick_Raw_Damage_7 {
                    get => Wyrmstake_Tick_Raw_Damage_7_raw;
                    set {
                        if (Wyrmstake_Tick_Raw_Damage_7_raw == value) return;
                        Wyrmstake_Tick_Raw_Damage_7_raw = value;
                        OnPropertyChanged(nameof(Wyrmstake_Tick_Raw_Damage_7));
                    }
                }

                public static ObservableCollection<Wyrmstake_Tick_Raw_Damage> LoadData(BinaryReader reader, Shell_Ammo_Params parent) {
                    var list = new ObservableCollection<Wyrmstake_Tick_Raw_Damage>();
                    var count = 1UL;
                    for (ulong i = 0; i < count; i++) {
                        list.Add(LoadData(reader, i, parent));
                    }
                    return list;
                }

                public static Wyrmstake_Tick_Raw_Damage LoadData(BinaryReader reader, ulong i, Shell_Ammo_Params parent) {
                    var data = new Wyrmstake_Tick_Raw_Damage();
                    data.Index = i;
                    data.Wyrmstake_Tick_Raw_Damage_1_raw = reader.ReadSingle();
                    data.Wyrmstake_Tick_Raw_Damage_2_raw = reader.ReadSingle();
                    data.Wyrmstake_Tick_Raw_Damage_3_raw = reader.ReadSingle();
                    data.Wyrmstake_Tick_Raw_Damage_4_raw = reader.ReadSingle();
                    data.Wyrmstake_Tick_Raw_Damage_5_raw = reader.ReadSingle();
                    data.Wyrmstake_Tick_Raw_Damage_6_raw = reader.ReadSingle();
                    data.Wyrmstake_Tick_Raw_Damage_7_raw = reader.ReadSingle();
                    return data;
                }

                public void WriteData(BinaryWriter writer, Shell_Ammo_Params parent) {
                    writer.Write(Wyrmstake_Tick_Raw_Damage_1_raw);
                    writer.Write(Wyrmstake_Tick_Raw_Damage_2_raw);
                    writer.Write(Wyrmstake_Tick_Raw_Damage_3_raw);
                    writer.Write(Wyrmstake_Tick_Raw_Damage_4_raw);
                    writer.Write(Wyrmstake_Tick_Raw_Damage_5_raw);
                    writer.Write(Wyrmstake_Tick_Raw_Damage_6_raw);
                    writer.Write(Wyrmstake_Tick_Raw_Damage_7_raw);
                }

                public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                    return new ObservableCollection<MultiStructItemCustomView> {
                        new MultiStructItemCustomView(this, "Wyrmstake Tick Raw Damage 1", "Wyrmstake_Tick_Raw_Damage_1"),
                        new MultiStructItemCustomView(this, "Wyrmstake Tick Raw Damage 2", "Wyrmstake_Tick_Raw_Damage_2"),
                        new MultiStructItemCustomView(this, "Wyrmstake Tick Raw Damage 3", "Wyrmstake_Tick_Raw_Damage_3"),
                        new MultiStructItemCustomView(this, "Wyrmstake Tick Raw Damage 4", "Wyrmstake_Tick_Raw_Damage_4"),
                        new MultiStructItemCustomView(this, "Wyrmstake Tick Raw Damage 5", "Wyrmstake_Tick_Raw_Damage_5"),
                        new MultiStructItemCustomView(this, "Wyrmstake Tick Raw Damage 6", "Wyrmstake_Tick_Raw_Damage_6"),
                        new MultiStructItemCustomView(this, "Wyrmstake Tick Raw Damage 7", "Wyrmstake_Tick_Raw_Damage_7"),
                    };
                }
            }

            public const string Wyrmstake_Tick_Raw_Damage_displayName = "Wyrmstake Tick Raw Damage";
            public const int Wyrmstake_Tick_Raw_Damage_sortIndex = 400;
            [SortOrder(Wyrmstake_Tick_Raw_Damage_sortIndex)]
            [DisplayName(Wyrmstake_Tick_Raw_Damage_displayName)]
            public virtual ObservableCollection<Wyrmstake_Tick_Raw_Damage> Wyrmstake_Tick_Raw_Damage_raw { get; protected set; }

            public partial class Wyrmstake_Fixed_Blast_Damage : MhwStructItem, IHasCustomView<MultiStructItemCustomView> {
                public const ulong FixedSizeCount = 1;
                public const string GridName = "Wyrmstake Fixed Blast Damage";

                protected float Wyrmstake_Fixed_Blast_Damage_1_raw;
                public const string Wyrmstake_Fixed_Blast_Damage_1_displayName = "Wyrmstake Fixed Blast Damage 1";
                public const int Wyrmstake_Fixed_Blast_Damage_1_sortIndex = 50;
                [SortOrder(Wyrmstake_Fixed_Blast_Damage_1_sortIndex)]
                [DisplayName(Wyrmstake_Fixed_Blast_Damage_1_displayName)]
                public virtual float Wyrmstake_Fixed_Blast_Damage_1 {
                    get => Wyrmstake_Fixed_Blast_Damage_1_raw;
                    set {
                        if (Wyrmstake_Fixed_Blast_Damage_1_raw == value) return;
                        Wyrmstake_Fixed_Blast_Damage_1_raw = value;
                        OnPropertyChanged(nameof(Wyrmstake_Fixed_Blast_Damage_1));
                    }
                }

                protected float Wyrmstake_Fixed_Blast_Damage_2_raw;
                public const string Wyrmstake_Fixed_Blast_Damage_2_displayName = "Wyrmstake Fixed Blast Damage 2";
                public const int Wyrmstake_Fixed_Blast_Damage_2_sortIndex = 100;
                [SortOrder(Wyrmstake_Fixed_Blast_Damage_2_sortIndex)]
                [DisplayName(Wyrmstake_Fixed_Blast_Damage_2_displayName)]
                public virtual float Wyrmstake_Fixed_Blast_Damage_2 {
                    get => Wyrmstake_Fixed_Blast_Damage_2_raw;
                    set {
                        if (Wyrmstake_Fixed_Blast_Damage_2_raw == value) return;
                        Wyrmstake_Fixed_Blast_Damage_2_raw = value;
                        OnPropertyChanged(nameof(Wyrmstake_Fixed_Blast_Damage_2));
                    }
                }

                protected float Wyrmstake_Fixed_Blast_Damage_3_raw;
                public const string Wyrmstake_Fixed_Blast_Damage_3_displayName = "Wyrmstake Fixed Blast Damage 3";
                public const int Wyrmstake_Fixed_Blast_Damage_3_sortIndex = 150;
                [SortOrder(Wyrmstake_Fixed_Blast_Damage_3_sortIndex)]
                [DisplayName(Wyrmstake_Fixed_Blast_Damage_3_displayName)]
                public virtual float Wyrmstake_Fixed_Blast_Damage_3 {
                    get => Wyrmstake_Fixed_Blast_Damage_3_raw;
                    set {
                        if (Wyrmstake_Fixed_Blast_Damage_3_raw == value) return;
                        Wyrmstake_Fixed_Blast_Damage_3_raw = value;
                        OnPropertyChanged(nameof(Wyrmstake_Fixed_Blast_Damage_3));
                    }
                }

                protected float Wyrmstake_Fixed_Blast_Damage_4_raw;
                public const string Wyrmstake_Fixed_Blast_Damage_4_displayName = "Wyrmstake Fixed Blast Damage 4";
                public const int Wyrmstake_Fixed_Blast_Damage_4_sortIndex = 200;
                [SortOrder(Wyrmstake_Fixed_Blast_Damage_4_sortIndex)]
                [DisplayName(Wyrmstake_Fixed_Blast_Damage_4_displayName)]
                public virtual float Wyrmstake_Fixed_Blast_Damage_4 {
                    get => Wyrmstake_Fixed_Blast_Damage_4_raw;
                    set {
                        if (Wyrmstake_Fixed_Blast_Damage_4_raw == value) return;
                        Wyrmstake_Fixed_Blast_Damage_4_raw = value;
                        OnPropertyChanged(nameof(Wyrmstake_Fixed_Blast_Damage_4));
                    }
                }

                protected float Wyrmstake_Fixed_Blast_Damage_5_raw;
                public const string Wyrmstake_Fixed_Blast_Damage_5_displayName = "Wyrmstake Fixed Blast Damage 5";
                public const int Wyrmstake_Fixed_Blast_Damage_5_sortIndex = 250;
                [SortOrder(Wyrmstake_Fixed_Blast_Damage_5_sortIndex)]
                [DisplayName(Wyrmstake_Fixed_Blast_Damage_5_displayName)]
                public virtual float Wyrmstake_Fixed_Blast_Damage_5 {
                    get => Wyrmstake_Fixed_Blast_Damage_5_raw;
                    set {
                        if (Wyrmstake_Fixed_Blast_Damage_5_raw == value) return;
                        Wyrmstake_Fixed_Blast_Damage_5_raw = value;
                        OnPropertyChanged(nameof(Wyrmstake_Fixed_Blast_Damage_5));
                    }
                }

                protected float Wyrmstake_Fixed_Blast_Damage_6_raw;
                public const string Wyrmstake_Fixed_Blast_Damage_6_displayName = "Wyrmstake Fixed Blast Damage 6";
                public const int Wyrmstake_Fixed_Blast_Damage_6_sortIndex = 300;
                [SortOrder(Wyrmstake_Fixed_Blast_Damage_6_sortIndex)]
                [DisplayName(Wyrmstake_Fixed_Blast_Damage_6_displayName)]
                public virtual float Wyrmstake_Fixed_Blast_Damage_6 {
                    get => Wyrmstake_Fixed_Blast_Damage_6_raw;
                    set {
                        if (Wyrmstake_Fixed_Blast_Damage_6_raw == value) return;
                        Wyrmstake_Fixed_Blast_Damage_6_raw = value;
                        OnPropertyChanged(nameof(Wyrmstake_Fixed_Blast_Damage_6));
                    }
                }

                protected float Wyrmstake_Fixed_Blast_Damage_7_raw;
                public const string Wyrmstake_Fixed_Blast_Damage_7_displayName = "Wyrmstake Fixed Blast Damage 7";
                public const int Wyrmstake_Fixed_Blast_Damage_7_sortIndex = 350;
                [SortOrder(Wyrmstake_Fixed_Blast_Damage_7_sortIndex)]
                [DisplayName(Wyrmstake_Fixed_Blast_Damage_7_displayName)]
                public virtual float Wyrmstake_Fixed_Blast_Damage_7 {
                    get => Wyrmstake_Fixed_Blast_Damage_7_raw;
                    set {
                        if (Wyrmstake_Fixed_Blast_Damage_7_raw == value) return;
                        Wyrmstake_Fixed_Blast_Damage_7_raw = value;
                        OnPropertyChanged(nameof(Wyrmstake_Fixed_Blast_Damage_7));
                    }
                }

                public static ObservableCollection<Wyrmstake_Fixed_Blast_Damage> LoadData(BinaryReader reader, Shell_Ammo_Params parent) {
                    var list = new ObservableCollection<Wyrmstake_Fixed_Blast_Damage>();
                    var count = 1UL;
                    for (ulong i = 0; i < count; i++) {
                        list.Add(LoadData(reader, i, parent));
                    }
                    return list;
                }

                public static Wyrmstake_Fixed_Blast_Damage LoadData(BinaryReader reader, ulong i, Shell_Ammo_Params parent) {
                    var data = new Wyrmstake_Fixed_Blast_Damage();
                    data.Index = i;
                    data.Wyrmstake_Fixed_Blast_Damage_1_raw = reader.ReadSingle();
                    data.Wyrmstake_Fixed_Blast_Damage_2_raw = reader.ReadSingle();
                    data.Wyrmstake_Fixed_Blast_Damage_3_raw = reader.ReadSingle();
                    data.Wyrmstake_Fixed_Blast_Damage_4_raw = reader.ReadSingle();
                    data.Wyrmstake_Fixed_Blast_Damage_5_raw = reader.ReadSingle();
                    data.Wyrmstake_Fixed_Blast_Damage_6_raw = reader.ReadSingle();
                    data.Wyrmstake_Fixed_Blast_Damage_7_raw = reader.ReadSingle();
                    return data;
                }

                public void WriteData(BinaryWriter writer, Shell_Ammo_Params parent) {
                    writer.Write(Wyrmstake_Fixed_Blast_Damage_1_raw);
                    writer.Write(Wyrmstake_Fixed_Blast_Damage_2_raw);
                    writer.Write(Wyrmstake_Fixed_Blast_Damage_3_raw);
                    writer.Write(Wyrmstake_Fixed_Blast_Damage_4_raw);
                    writer.Write(Wyrmstake_Fixed_Blast_Damage_5_raw);
                    writer.Write(Wyrmstake_Fixed_Blast_Damage_6_raw);
                    writer.Write(Wyrmstake_Fixed_Blast_Damage_7_raw);
                }

                public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                    return new ObservableCollection<MultiStructItemCustomView> {
                        new MultiStructItemCustomView(this, "Wyrmstake Fixed Blast Damage 1", "Wyrmstake_Fixed_Blast_Damage_1"),
                        new MultiStructItemCustomView(this, "Wyrmstake Fixed Blast Damage 2", "Wyrmstake_Fixed_Blast_Damage_2"),
                        new MultiStructItemCustomView(this, "Wyrmstake Fixed Blast Damage 3", "Wyrmstake_Fixed_Blast_Damage_3"),
                        new MultiStructItemCustomView(this, "Wyrmstake Fixed Blast Damage 4", "Wyrmstake_Fixed_Blast_Damage_4"),
                        new MultiStructItemCustomView(this, "Wyrmstake Fixed Blast Damage 5", "Wyrmstake_Fixed_Blast_Damage_5"),
                        new MultiStructItemCustomView(this, "Wyrmstake Fixed Blast Damage 6", "Wyrmstake_Fixed_Blast_Damage_6"),
                        new MultiStructItemCustomView(this, "Wyrmstake Fixed Blast Damage 7", "Wyrmstake_Fixed_Blast_Damage_7"),
                    };
                }
            }

            public const string Wyrmstake_Fixed_Blast_Damage_displayName = "Wyrmstake Fixed Blast Damage";
            public const int Wyrmstake_Fixed_Blast_Damage_sortIndex = 450;
            [SortOrder(Wyrmstake_Fixed_Blast_Damage_sortIndex)]
            [DisplayName(Wyrmstake_Fixed_Blast_Damage_displayName)]
            public virtual ObservableCollection<Wyrmstake_Fixed_Blast_Damage> Wyrmstake_Fixed_Blast_Damage_raw { get; protected set; }

            public partial class Wyrmstake_Fire_Damage : MhwStructItem, IHasCustomView<MultiStructItemCustomView> {
                public const ulong FixedSizeCount = 1;
                public const string GridName = "Wyrmstake Fire Damage";

                protected float Wyrmstake_Fire_Damage_1_raw;
                public const string Wyrmstake_Fire_Damage_1_displayName = "Wyrmstake Fire Damage 1";
                public const int Wyrmstake_Fire_Damage_1_sortIndex = 50;
                [SortOrder(Wyrmstake_Fire_Damage_1_sortIndex)]
                [DisplayName(Wyrmstake_Fire_Damage_1_displayName)]
                public virtual float Wyrmstake_Fire_Damage_1 {
                    get => Wyrmstake_Fire_Damage_1_raw;
                    set {
                        if (Wyrmstake_Fire_Damage_1_raw == value) return;
                        Wyrmstake_Fire_Damage_1_raw = value;
                        OnPropertyChanged(nameof(Wyrmstake_Fire_Damage_1));
                    }
                }

                protected float Wyrmstake_Fire_Damage_2_raw;
                public const string Wyrmstake_Fire_Damage_2_displayName = "Wyrmstake Fire Damage 2";
                public const int Wyrmstake_Fire_Damage_2_sortIndex = 100;
                [SortOrder(Wyrmstake_Fire_Damage_2_sortIndex)]
                [DisplayName(Wyrmstake_Fire_Damage_2_displayName)]
                public virtual float Wyrmstake_Fire_Damage_2 {
                    get => Wyrmstake_Fire_Damage_2_raw;
                    set {
                        if (Wyrmstake_Fire_Damage_2_raw == value) return;
                        Wyrmstake_Fire_Damage_2_raw = value;
                        OnPropertyChanged(nameof(Wyrmstake_Fire_Damage_2));
                    }
                }

                protected float Wyrmstake_Fire_Damage_3_raw;
                public const string Wyrmstake_Fire_Damage_3_displayName = "Wyrmstake Fire Damage 3";
                public const int Wyrmstake_Fire_Damage_3_sortIndex = 150;
                [SortOrder(Wyrmstake_Fire_Damage_3_sortIndex)]
                [DisplayName(Wyrmstake_Fire_Damage_3_displayName)]
                public virtual float Wyrmstake_Fire_Damage_3 {
                    get => Wyrmstake_Fire_Damage_3_raw;
                    set {
                        if (Wyrmstake_Fire_Damage_3_raw == value) return;
                        Wyrmstake_Fire_Damage_3_raw = value;
                        OnPropertyChanged(nameof(Wyrmstake_Fire_Damage_3));
                    }
                }

                protected float Wyrmstake_Fire_Damage_4_raw;
                public const string Wyrmstake_Fire_Damage_4_displayName = "Wyrmstake Fire Damage 4";
                public const int Wyrmstake_Fire_Damage_4_sortIndex = 200;
                [SortOrder(Wyrmstake_Fire_Damage_4_sortIndex)]
                [DisplayName(Wyrmstake_Fire_Damage_4_displayName)]
                public virtual float Wyrmstake_Fire_Damage_4 {
                    get => Wyrmstake_Fire_Damage_4_raw;
                    set {
                        if (Wyrmstake_Fire_Damage_4_raw == value) return;
                        Wyrmstake_Fire_Damage_4_raw = value;
                        OnPropertyChanged(nameof(Wyrmstake_Fire_Damage_4));
                    }
                }

                protected float Wyrmstake_Fire_Damage_5_raw;
                public const string Wyrmstake_Fire_Damage_5_displayName = "Wyrmstake Fire Damage 5";
                public const int Wyrmstake_Fire_Damage_5_sortIndex = 250;
                [SortOrder(Wyrmstake_Fire_Damage_5_sortIndex)]
                [DisplayName(Wyrmstake_Fire_Damage_5_displayName)]
                public virtual float Wyrmstake_Fire_Damage_5 {
                    get => Wyrmstake_Fire_Damage_5_raw;
                    set {
                        if (Wyrmstake_Fire_Damage_5_raw == value) return;
                        Wyrmstake_Fire_Damage_5_raw = value;
                        OnPropertyChanged(nameof(Wyrmstake_Fire_Damage_5));
                    }
                }

                protected float Wyrmstake_Fire_Damage_6_raw;
                public const string Wyrmstake_Fire_Damage_6_displayName = "Wyrmstake Fire Damage 6";
                public const int Wyrmstake_Fire_Damage_6_sortIndex = 300;
                [SortOrder(Wyrmstake_Fire_Damage_6_sortIndex)]
                [DisplayName(Wyrmstake_Fire_Damage_6_displayName)]
                public virtual float Wyrmstake_Fire_Damage_6 {
                    get => Wyrmstake_Fire_Damage_6_raw;
                    set {
                        if (Wyrmstake_Fire_Damage_6_raw == value) return;
                        Wyrmstake_Fire_Damage_6_raw = value;
                        OnPropertyChanged(nameof(Wyrmstake_Fire_Damage_6));
                    }
                }

                protected float Wyrmstake_Fire_Damage_7_raw;
                public const string Wyrmstake_Fire_Damage_7_displayName = "Wyrmstake Fire Damage 7";
                public const int Wyrmstake_Fire_Damage_7_sortIndex = 350;
                [SortOrder(Wyrmstake_Fire_Damage_7_sortIndex)]
                [DisplayName(Wyrmstake_Fire_Damage_7_displayName)]
                public virtual float Wyrmstake_Fire_Damage_7 {
                    get => Wyrmstake_Fire_Damage_7_raw;
                    set {
                        if (Wyrmstake_Fire_Damage_7_raw == value) return;
                        Wyrmstake_Fire_Damage_7_raw = value;
                        OnPropertyChanged(nameof(Wyrmstake_Fire_Damage_7));
                    }
                }

                public static ObservableCollection<Wyrmstake_Fire_Damage> LoadData(BinaryReader reader, Shell_Ammo_Params parent) {
                    var list = new ObservableCollection<Wyrmstake_Fire_Damage>();
                    var count = 1UL;
                    for (ulong i = 0; i < count; i++) {
                        list.Add(LoadData(reader, i, parent));
                    }
                    return list;
                }

                public static Wyrmstake_Fire_Damage LoadData(BinaryReader reader, ulong i, Shell_Ammo_Params parent) {
                    var data = new Wyrmstake_Fire_Damage();
                    data.Index = i;
                    data.Wyrmstake_Fire_Damage_1_raw = reader.ReadSingle();
                    data.Wyrmstake_Fire_Damage_2_raw = reader.ReadSingle();
                    data.Wyrmstake_Fire_Damage_3_raw = reader.ReadSingle();
                    data.Wyrmstake_Fire_Damage_4_raw = reader.ReadSingle();
                    data.Wyrmstake_Fire_Damage_5_raw = reader.ReadSingle();
                    data.Wyrmstake_Fire_Damage_6_raw = reader.ReadSingle();
                    data.Wyrmstake_Fire_Damage_7_raw = reader.ReadSingle();
                    return data;
                }

                public void WriteData(BinaryWriter writer, Shell_Ammo_Params parent) {
                    writer.Write(Wyrmstake_Fire_Damage_1_raw);
                    writer.Write(Wyrmstake_Fire_Damage_2_raw);
                    writer.Write(Wyrmstake_Fire_Damage_3_raw);
                    writer.Write(Wyrmstake_Fire_Damage_4_raw);
                    writer.Write(Wyrmstake_Fire_Damage_5_raw);
                    writer.Write(Wyrmstake_Fire_Damage_6_raw);
                    writer.Write(Wyrmstake_Fire_Damage_7_raw);
                }

                public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                    return new ObservableCollection<MultiStructItemCustomView> {
                        new MultiStructItemCustomView(this, "Wyrmstake Fire Damage 1", "Wyrmstake_Fire_Damage_1"),
                        new MultiStructItemCustomView(this, "Wyrmstake Fire Damage 2", "Wyrmstake_Fire_Damage_2"),
                        new MultiStructItemCustomView(this, "Wyrmstake Fire Damage 3", "Wyrmstake_Fire_Damage_3"),
                        new MultiStructItemCustomView(this, "Wyrmstake Fire Damage 4", "Wyrmstake_Fire_Damage_4"),
                        new MultiStructItemCustomView(this, "Wyrmstake Fire Damage 5", "Wyrmstake_Fire_Damage_5"),
                        new MultiStructItemCustomView(this, "Wyrmstake Fire Damage 6", "Wyrmstake_Fire_Damage_6"),
                        new MultiStructItemCustomView(this, "Wyrmstake Fire Damage 7", "Wyrmstake_Fire_Damage_7"),
                    };
                }
            }

            public const string Wyrmstake_Fire_Damage_displayName = "Wyrmstake Fire Damage";
            public const int Wyrmstake_Fire_Damage_sortIndex = 500;
            [SortOrder(Wyrmstake_Fire_Damage_sortIndex)]
            [DisplayName(Wyrmstake_Fire_Damage_displayName)]
            public virtual ObservableCollection<Wyrmstake_Fire_Damage> Wyrmstake_Fire_Damage_raw { get; protected set; }

            public partial class Wyrmstake_Add_Damage : MhwStructItem, IHasCustomView<MultiStructItemCustomView> {
                public const ulong FixedSizeCount = 1;
                public const string GridName = "Wyrmstake Add Damage";

                protected float Wyrmstake_Add_Damage_1_raw;
                public const string Wyrmstake_Add_Damage_1_displayName = "Wyrmstake Add Damage 1";
                public const int Wyrmstake_Add_Damage_1_sortIndex = 50;
                [SortOrder(Wyrmstake_Add_Damage_1_sortIndex)]
                [DisplayName(Wyrmstake_Add_Damage_1_displayName)]
                public virtual float Wyrmstake_Add_Damage_1 {
                    get => Wyrmstake_Add_Damage_1_raw;
                    set {
                        if (Wyrmstake_Add_Damage_1_raw == value) return;
                        Wyrmstake_Add_Damage_1_raw = value;
                        OnPropertyChanged(nameof(Wyrmstake_Add_Damage_1));
                    }
                }

                protected float Wyrmstake_Add_Damage_2_raw;
                public const string Wyrmstake_Add_Damage_2_displayName = "Wyrmstake Add Damage 2";
                public const int Wyrmstake_Add_Damage_2_sortIndex = 100;
                [SortOrder(Wyrmstake_Add_Damage_2_sortIndex)]
                [DisplayName(Wyrmstake_Add_Damage_2_displayName)]
                public virtual float Wyrmstake_Add_Damage_2 {
                    get => Wyrmstake_Add_Damage_2_raw;
                    set {
                        if (Wyrmstake_Add_Damage_2_raw == value) return;
                        Wyrmstake_Add_Damage_2_raw = value;
                        OnPropertyChanged(nameof(Wyrmstake_Add_Damage_2));
                    }
                }

                protected float Wyrmstake_Add_Damage_3_raw;
                public const string Wyrmstake_Add_Damage_3_displayName = "Wyrmstake Add Damage 3";
                public const int Wyrmstake_Add_Damage_3_sortIndex = 150;
                [SortOrder(Wyrmstake_Add_Damage_3_sortIndex)]
                [DisplayName(Wyrmstake_Add_Damage_3_displayName)]
                public virtual float Wyrmstake_Add_Damage_3 {
                    get => Wyrmstake_Add_Damage_3_raw;
                    set {
                        if (Wyrmstake_Add_Damage_3_raw == value) return;
                        Wyrmstake_Add_Damage_3_raw = value;
                        OnPropertyChanged(nameof(Wyrmstake_Add_Damage_3));
                    }
                }

                protected float Wyrmstake_Add_Damage_4_raw;
                public const string Wyrmstake_Add_Damage_4_displayName = "Wyrmstake Add Damage 4";
                public const int Wyrmstake_Add_Damage_4_sortIndex = 200;
                [SortOrder(Wyrmstake_Add_Damage_4_sortIndex)]
                [DisplayName(Wyrmstake_Add_Damage_4_displayName)]
                public virtual float Wyrmstake_Add_Damage_4 {
                    get => Wyrmstake_Add_Damage_4_raw;
                    set {
                        if (Wyrmstake_Add_Damage_4_raw == value) return;
                        Wyrmstake_Add_Damage_4_raw = value;
                        OnPropertyChanged(nameof(Wyrmstake_Add_Damage_4));
                    }
                }

                protected float Wyrmstake_Add_Damage_5_raw;
                public const string Wyrmstake_Add_Damage_5_displayName = "Wyrmstake Add Damage 5";
                public const int Wyrmstake_Add_Damage_5_sortIndex = 250;
                [SortOrder(Wyrmstake_Add_Damage_5_sortIndex)]
                [DisplayName(Wyrmstake_Add_Damage_5_displayName)]
                public virtual float Wyrmstake_Add_Damage_5 {
                    get => Wyrmstake_Add_Damage_5_raw;
                    set {
                        if (Wyrmstake_Add_Damage_5_raw == value) return;
                        Wyrmstake_Add_Damage_5_raw = value;
                        OnPropertyChanged(nameof(Wyrmstake_Add_Damage_5));
                    }
                }

                protected float Wyrmstake_Add_Damage_6_raw;
                public const string Wyrmstake_Add_Damage_6_displayName = "Wyrmstake Add Damage 6";
                public const int Wyrmstake_Add_Damage_6_sortIndex = 300;
                [SortOrder(Wyrmstake_Add_Damage_6_sortIndex)]
                [DisplayName(Wyrmstake_Add_Damage_6_displayName)]
                public virtual float Wyrmstake_Add_Damage_6 {
                    get => Wyrmstake_Add_Damage_6_raw;
                    set {
                        if (Wyrmstake_Add_Damage_6_raw == value) return;
                        Wyrmstake_Add_Damage_6_raw = value;
                        OnPropertyChanged(nameof(Wyrmstake_Add_Damage_6));
                    }
                }

                protected float Wyrmstake_Add_Damage_7_raw;
                public const string Wyrmstake_Add_Damage_7_displayName = "Wyrmstake Add Damage 7";
                public const int Wyrmstake_Add_Damage_7_sortIndex = 350;
                [SortOrder(Wyrmstake_Add_Damage_7_sortIndex)]
                [DisplayName(Wyrmstake_Add_Damage_7_displayName)]
                public virtual float Wyrmstake_Add_Damage_7 {
                    get => Wyrmstake_Add_Damage_7_raw;
                    set {
                        if (Wyrmstake_Add_Damage_7_raw == value) return;
                        Wyrmstake_Add_Damage_7_raw = value;
                        OnPropertyChanged(nameof(Wyrmstake_Add_Damage_7));
                    }
                }

                public static ObservableCollection<Wyrmstake_Add_Damage> LoadData(BinaryReader reader, Shell_Ammo_Params parent) {
                    var list = new ObservableCollection<Wyrmstake_Add_Damage>();
                    var count = 1UL;
                    for (ulong i = 0; i < count; i++) {
                        list.Add(LoadData(reader, i, parent));
                    }
                    return list;
                }

                public static Wyrmstake_Add_Damage LoadData(BinaryReader reader, ulong i, Shell_Ammo_Params parent) {
                    var data = new Wyrmstake_Add_Damage();
                    data.Index = i;
                    data.Wyrmstake_Add_Damage_1_raw = reader.ReadSingle();
                    data.Wyrmstake_Add_Damage_2_raw = reader.ReadSingle();
                    data.Wyrmstake_Add_Damage_3_raw = reader.ReadSingle();
                    data.Wyrmstake_Add_Damage_4_raw = reader.ReadSingle();
                    data.Wyrmstake_Add_Damage_5_raw = reader.ReadSingle();
                    data.Wyrmstake_Add_Damage_6_raw = reader.ReadSingle();
                    data.Wyrmstake_Add_Damage_7_raw = reader.ReadSingle();
                    return data;
                }

                public void WriteData(BinaryWriter writer, Shell_Ammo_Params parent) {
                    writer.Write(Wyrmstake_Add_Damage_1_raw);
                    writer.Write(Wyrmstake_Add_Damage_2_raw);
                    writer.Write(Wyrmstake_Add_Damage_3_raw);
                    writer.Write(Wyrmstake_Add_Damage_4_raw);
                    writer.Write(Wyrmstake_Add_Damage_5_raw);
                    writer.Write(Wyrmstake_Add_Damage_6_raw);
                    writer.Write(Wyrmstake_Add_Damage_7_raw);
                }

                public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                    return new ObservableCollection<MultiStructItemCustomView> {
                        new MultiStructItemCustomView(this, "Wyrmstake Add Damage 1", "Wyrmstake_Add_Damage_1"),
                        new MultiStructItemCustomView(this, "Wyrmstake Add Damage 2", "Wyrmstake_Add_Damage_2"),
                        new MultiStructItemCustomView(this, "Wyrmstake Add Damage 3", "Wyrmstake_Add_Damage_3"),
                        new MultiStructItemCustomView(this, "Wyrmstake Add Damage 4", "Wyrmstake_Add_Damage_4"),
                        new MultiStructItemCustomView(this, "Wyrmstake Add Damage 5", "Wyrmstake_Add_Damage_5"),
                        new MultiStructItemCustomView(this, "Wyrmstake Add Damage 6", "Wyrmstake_Add_Damage_6"),
                        new MultiStructItemCustomView(this, "Wyrmstake Add Damage 7", "Wyrmstake_Add_Damage_7"),
                    };
                }
            }

            public const string Wyrmstake_Add_Damage_displayName = "Wyrmstake Add Damage";
            public const int Wyrmstake_Add_Damage_sortIndex = 550;
            [SortOrder(Wyrmstake_Add_Damage_sortIndex)]
            [DisplayName(Wyrmstake_Add_Damage_displayName)]
            public virtual ObservableCollection<Wyrmstake_Add_Damage> Wyrmstake_Add_Damage_raw { get; protected set; }

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
                var count = 3UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Shell_Ammo_Params LoadData(BinaryReader reader, ulong i) {
                var data = new Shell_Ammo_Params();
                data.Index = i;
                data.Shell_Damage_raw = Shell_Damage.LoadData(reader, data);
                data.Shell_Fire_Damage_raw = Shell_Fire_Damage.LoadData(reader, data);
                data.Shell_Charged_Multiplier_raw = reader.ReadSingle();
                data.Full_burst_Multiplier_raw = reader.ReadSingle();
                data.Shell_Unk_1_raw = reader.ReadSingle();
                data.Wyvernfire_Damage_raw = Wyvernfire_Damage.LoadData(reader, data);
                data.Wyvernfire_Fire_Damage_raw = Wyvernfire_Fire_Damage.LoadData(reader, data);
                data.Wyrmstake_Tick_Raw_Damage_raw = Wyrmstake_Tick_Raw_Damage.LoadData(reader, data);
                data.Wyrmstake_Fixed_Blast_Damage_raw = Wyrmstake_Fixed_Blast_Damage.LoadData(reader, data);
                data.Wyrmstake_Fire_Damage_raw = Wyrmstake_Fire_Damage.LoadData(reader, data);
                data.Wyrmstake_Add_Damage_raw = Wyrmstake_Add_Damage.LoadData(reader, data);
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                foreach (var obj in Shell_Damage_raw) {
                    obj.WriteData(writer, this);
                }
                foreach (var obj in Shell_Fire_Damage_raw) {
                    obj.WriteData(writer, this);
                }
                writer.Write(Shell_Charged_Multiplier_raw);
                writer.Write(Full_burst_Multiplier_raw);
                writer.Write(Shell_Unk_1_raw);
                foreach (var obj in Wyvernfire_Damage_raw) {
                    obj.WriteData(writer, this);
                }
                foreach (var obj in Wyvernfire_Fire_Damage_raw) {
                    obj.WriteData(writer, this);
                }
                foreach (var obj in Wyrmstake_Tick_Raw_Damage_raw) {
                    obj.WriteData(writer, this);
                }
                foreach (var obj in Wyrmstake_Fixed_Blast_Damage_raw) {
                    obj.WriteData(writer, this);
                }
                foreach (var obj in Wyrmstake_Fire_Damage_raw) {
                    obj.WriteData(writer, this);
                }
                foreach (var obj in Wyrmstake_Add_Damage_raw) {
                    obj.WriteData(writer, this);
                }
            }
        }

        public partial class W07p_Params_6_Shelling_Params : MhwStructItem, IHasCustomView<MultiStructItemCustomView> {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W07p Params (6) - Shelling Params";

            protected float Yellow_Gauge_Debuff_raw;
            public const string Yellow_Gauge_Debuff_displayName = "Yellow Gauge Debuff";
            public const int Yellow_Gauge_Debuff_sortIndex = 50;
            [SortOrder(Yellow_Gauge_Debuff_sortIndex)]
            [DisplayName(Yellow_Gauge_Debuff_displayName)]
            public virtual float Yellow_Gauge_Debuff {
                get => Yellow_Gauge_Debuff_raw;
                set {
                    if (Yellow_Gauge_Debuff_raw == value) return;
                    Yellow_Gauge_Debuff_raw = value;
                    OnPropertyChanged(nameof(Yellow_Gauge_Debuff));
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

            public static W07p_Params_6_Shelling_Params LoadData(BinaryReader reader, ulong i) {
                var data = new W07p_Params_6_Shelling_Params();
                data.Index = i;
                data.Yellow_Gauge_Debuff_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Yellow_Gauge_Debuff_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Yellow Gauge Debuff", "Yellow_Gauge_Debuff"),
                };
            }
        }

        public partial class Shelling_Sharpness_Usage : MhwStructItem {
            public const ulong FixedSizeCount = 3;
            public const string GridName = "Shelling Sharpness Usage";

            protected uint Shell_raw;
            public const string Shell_displayName = "Shell";
            public const int Shell_sortIndex = 50;
            [SortOrder(Shell_sortIndex)]
            [DisplayName(Shell_displayName)]
            public virtual uint Shell {
                get => Shell_raw;
                set {
                    if (Shell_raw == value) return;
                    Shell_raw = value;
                    OnPropertyChanged(nameof(Shell));
                }
            }

            protected uint Charged_Shell_raw;
            public const string Charged_Shell_displayName = "Charged Shell";
            public const int Charged_Shell_sortIndex = 100;
            [SortOrder(Charged_Shell_sortIndex)]
            [DisplayName(Charged_Shell_displayName)]
            public virtual uint Charged_Shell {
                get => Charged_Shell_raw;
                set {
                    if (Charged_Shell_raw == value) return;
                    Charged_Shell_raw = value;
                    OnPropertyChanged(nameof(Charged_Shell));
                }
            }

            protected uint Full_Burst_Per_Shell__raw;
            public const string Full_Burst_Per_Shell__displayName = "Full Burst (Per Shell)";
            public const int Full_Burst_Per_Shell__sortIndex = 150;
            [SortOrder(Full_Burst_Per_Shell__sortIndex)]
            [DisplayName(Full_Burst_Per_Shell__displayName)]
            public virtual uint Full_Burst_Per_Shell_ {
                get => Full_Burst_Per_Shell__raw;
                set {
                    if (Full_Burst_Per_Shell__raw == value) return;
                    Full_Burst_Per_Shell__raw = value;
                    OnPropertyChanged(nameof(Full_Burst_Per_Shell_));
                }
            }

            protected uint Wyvernfire_raw;
            public const string Wyvernfire_displayName = "Wyvernfire";
            public const int Wyvernfire_sortIndex = 200;
            [SortOrder(Wyvernfire_sortIndex)]
            [DisplayName(Wyvernfire_displayName)]
            public virtual uint Wyvernfire {
                get => Wyvernfire_raw;
                set {
                    if (Wyvernfire_raw == value) return;
                    Wyvernfire_raw = value;
                    OnPropertyChanged(nameof(Wyvernfire));
                }
            }

            protected uint Wyrmstake_raw;
            public const string Wyrmstake_displayName = "Wyrmstake";
            public const int Wyrmstake_sortIndex = 250;
            [SortOrder(Wyrmstake_sortIndex)]
            [DisplayName(Wyrmstake_displayName)]
            public virtual uint Wyrmstake {
                get => Wyrmstake_raw;
                set {
                    if (Wyrmstake_raw == value) return;
                    Wyrmstake_raw = value;
                    OnPropertyChanged(nameof(Wyrmstake));
                }
            }

            protected uint Unk_6_raw;
            public const string Unk_6_displayName = "Unk 6";
            public const int Unk_6_sortIndex = 300;
            [SortOrder(Unk_6_sortIndex)]
            [DisplayName(Unk_6_displayName)]
            public virtual uint Unk_6 {
                get => Unk_6_raw;
                set {
                    if (Unk_6_raw == value) return;
                    Unk_6_raw = value;
                    OnPropertyChanged(nameof(Unk_6));
                }
            }

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
                var count = 3UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Shelling_Sharpness_Usage LoadData(BinaryReader reader, ulong i) {
                var data = new Shelling_Sharpness_Usage();
                data.Index = i;
                data.Shell_raw = reader.ReadUInt32();
                data.Charged_Shell_raw = reader.ReadUInt32();
                data.Full_Burst_Per_Shell__raw = reader.ReadUInt32();
                data.Wyvernfire_raw = reader.ReadUInt32();
                data.Wyrmstake_raw = reader.ReadUInt32();
                data.Unk_6_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Shell_raw);
                writer.Write(Charged_Shell_raw);
                writer.Write(Full_Burst_Per_Shell__raw);
                writer.Write(Wyvernfire_raw);
                writer.Write(Wyrmstake_raw);
                writer.Write(Unk_6_raw);
            }
        }

        public partial class W07p_Params_7_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView> {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W07p Params (7)";

            protected float Unk_292_raw;
            public const string Unk_292_displayName = "Unk 292";
            public const int Unk_292_sortIndex = 50;
            [SortOrder(Unk_292_sortIndex)]
            [DisplayName(Unk_292_displayName)]
            public virtual float Unk_292 {
                get => Unk_292_raw;
                set {
                    if (Unk_292_raw == value) return;
                    Unk_292_raw = value;
                    OnPropertyChanged(nameof(Unk_292));
                }
            }

            protected float Unk_293_raw;
            public const string Unk_293_displayName = "Unk 293";
            public const int Unk_293_sortIndex = 100;
            [SortOrder(Unk_293_sortIndex)]
            [DisplayName(Unk_293_displayName)]
            public virtual float Unk_293 {
                get => Unk_293_raw;
                set {
                    if (Unk_293_raw == value) return;
                    Unk_293_raw = value;
                    OnPropertyChanged(nameof(Unk_293));
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

            public static W07p_Params_7_ LoadData(BinaryReader reader, ulong i) {
                var data = new W07p_Params_7_();
                data.Index = i;
                data.Unk_292_raw = reader.ReadSingle();
                data.Unk_293_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_292_raw);
                writer.Write(Unk_293_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Unk 292", "Unk_292"),
                    new MultiStructItemCustomView(this, "Unk 293", "Unk_293"),
                };
            }
        }

        public partial class Action_Param_1 : MhwStructItem {
            public const ulong FixedSizeCount = 10;
            public const string GridName = "Action Param 1";

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

            protected float G_Rate_raw;
            public const string G_Rate_displayName = "G Rate";
            public const int G_Rate_sortIndex = 100;
            [SortOrder(G_Rate_sortIndex)]
            [DisplayName(G_Rate_displayName)]
            public virtual float G_Rate {
                get => G_Rate_raw;
                set {
                    if (G_Rate_raw == value) return;
                    G_Rate_raw = value;
                    OnPropertyChanged(nameof(G_Rate));
                }
            }

            protected float Momentum_raw;
            public const string Momentum_displayName = "Momentum";
            public const int Momentum_sortIndex = 150;
            [SortOrder(Momentum_sortIndex)]
            [DisplayName(Momentum_displayName)]
            public virtual float Momentum {
                get => Momentum_raw;
                set {
                    if (Momentum_raw == value) return;
                    Momentum_raw = value;
                    OnPropertyChanged(nameof(Momentum));
                }
            }

            protected float V_Offset_raw;
            public const string V_Offset_displayName = "V Offset";
            public const int V_Offset_sortIndex = 200;
            [SortOrder(V_Offset_sortIndex)]
            [DisplayName(V_Offset_displayName)]
            public virtual float V_Offset {
                get => V_Offset_raw;
                set {
                    if (V_Offset_raw == value) return;
                    V_Offset_raw = value;
                    OnPropertyChanged(nameof(V_Offset));
                }
            }

            protected float H_Offset_raw;
            public const string H_Offset_displayName = "H Offset";
            public const int H_Offset_sortIndex = 250;
            [SortOrder(H_Offset_sortIndex)]
            [DisplayName(H_Offset_displayName)]
            public virtual float H_Offset {
                get => H_Offset_raw;
                set {
                    if (H_Offset_raw == value) return;
                    H_Offset_raw = value;
                    OnPropertyChanged(nameof(H_Offset));
                }
            }

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
                var count = 10UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Action_Param_1 LoadData(BinaryReader reader, ulong i) {
                var data = new Action_Param_1();
                data.Index = i;
                data.Gravity_raw = reader.ReadSingle();
                data.G_Rate_raw = reader.ReadSingle();
                data.Momentum_raw = reader.ReadSingle();
                data.V_Offset_raw = reader.ReadSingle();
                data.H_Offset_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Gravity_raw);
                writer.Write(G_Rate_raw);
                writer.Write(Momentum_raw);
                writer.Write(V_Offset_raw);
                writer.Write(H_Offset_raw);
            }
        }

        public partial class W07p_Params_8_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView> {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W07p Params (8)";

            protected float Unk_294_raw;
            public const string Unk_294_displayName = "Unk 294";
            public const int Unk_294_sortIndex = 50;
            [SortOrder(Unk_294_sortIndex)]
            [DisplayName(Unk_294_displayName)]
            public virtual float Unk_294 {
                get => Unk_294_raw;
                set {
                    if (Unk_294_raw == value) return;
                    Unk_294_raw = value;
                    OnPropertyChanged(nameof(Unk_294));
                }
            }

            protected float Unk_295_raw;
            public const string Unk_295_displayName = "Unk 295";
            public const int Unk_295_sortIndex = 100;
            [SortOrder(Unk_295_sortIndex)]
            [DisplayName(Unk_295_displayName)]
            public virtual float Unk_295 {
                get => Unk_295_raw;
                set {
                    if (Unk_295_raw == value) return;
                    Unk_295_raw = value;
                    OnPropertyChanged(nameof(Unk_295));
                }
            }

            protected float Unk_296_raw;
            public const string Unk_296_displayName = "Unk 296";
            public const int Unk_296_sortIndex = 150;
            [SortOrder(Unk_296_sortIndex)]
            [DisplayName(Unk_296_displayName)]
            public virtual float Unk_296 {
                get => Unk_296_raw;
                set {
                    if (Unk_296_raw == value) return;
                    Unk_296_raw = value;
                    OnPropertyChanged(nameof(Unk_296));
                }
            }

            protected float Unk_297_raw;
            public const string Unk_297_displayName = "Unk 297";
            public const int Unk_297_sortIndex = 200;
            [SortOrder(Unk_297_sortIndex)]
            [DisplayName(Unk_297_displayName)]
            public virtual float Unk_297 {
                get => Unk_297_raw;
                set {
                    if (Unk_297_raw == value) return;
                    Unk_297_raw = value;
                    OnPropertyChanged(nameof(Unk_297));
                }
            }

            protected float Unk_298_raw;
            public const string Unk_298_displayName = "Unk 298";
            public const int Unk_298_sortIndex = 250;
            [SortOrder(Unk_298_sortIndex)]
            [DisplayName(Unk_298_displayName)]
            public virtual float Unk_298 {
                get => Unk_298_raw;
                set {
                    if (Unk_298_raw == value) return;
                    Unk_298_raw = value;
                    OnPropertyChanged(nameof(Unk_298));
                }
            }

            protected float Unk_299_raw;
            public const string Unk_299_displayName = "Unk 299";
            public const int Unk_299_sortIndex = 300;
            [SortOrder(Unk_299_sortIndex)]
            [DisplayName(Unk_299_displayName)]
            public virtual float Unk_299 {
                get => Unk_299_raw;
                set {
                    if (Unk_299_raw == value) return;
                    Unk_299_raw = value;
                    OnPropertyChanged(nameof(Unk_299));
                }
            }

            protected float Unk_300_raw;
            public const string Unk_300_displayName = "Unk 300";
            public const int Unk_300_sortIndex = 350;
            [SortOrder(Unk_300_sortIndex)]
            [DisplayName(Unk_300_displayName)]
            public virtual float Unk_300 {
                get => Unk_300_raw;
                set {
                    if (Unk_300_raw == value) return;
                    Unk_300_raw = value;
                    OnPropertyChanged(nameof(Unk_300));
                }
            }

            protected float Unk_301_raw;
            public const string Unk_301_displayName = "Unk 301";
            public const int Unk_301_sortIndex = 400;
            [SortOrder(Unk_301_sortIndex)]
            [DisplayName(Unk_301_displayName)]
            public virtual float Unk_301 {
                get => Unk_301_raw;
                set {
                    if (Unk_301_raw == value) return;
                    Unk_301_raw = value;
                    OnPropertyChanged(nameof(Unk_301));
                }
            }

            protected float Unk_302_raw;
            public const string Unk_302_displayName = "Unk 302";
            public const int Unk_302_sortIndex = 450;
            [SortOrder(Unk_302_sortIndex)]
            [DisplayName(Unk_302_displayName)]
            public virtual float Unk_302 {
                get => Unk_302_raw;
                set {
                    if (Unk_302_raw == value) return;
                    Unk_302_raw = value;
                    OnPropertyChanged(nameof(Unk_302));
                }
            }

            protected float Unk_303_raw;
            public const string Unk_303_displayName = "Unk 303";
            public const int Unk_303_sortIndex = 500;
            [SortOrder(Unk_303_sortIndex)]
            [DisplayName(Unk_303_displayName)]
            public virtual float Unk_303 {
                get => Unk_303_raw;
                set {
                    if (Unk_303_raw == value) return;
                    Unk_303_raw = value;
                    OnPropertyChanged(nameof(Unk_303));
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

            public static W07p_Params_8_ LoadData(BinaryReader reader, ulong i) {
                var data = new W07p_Params_8_();
                data.Index = i;
                data.Unk_294_raw = reader.ReadSingle();
                data.Unk_295_raw = reader.ReadSingle();
                data.Unk_296_raw = reader.ReadSingle();
                data.Unk_297_raw = reader.ReadSingle();
                data.Unk_298_raw = reader.ReadSingle();
                data.Unk_299_raw = reader.ReadSingle();
                data.Unk_300_raw = reader.ReadSingle();
                data.Unk_301_raw = reader.ReadSingle();
                data.Unk_302_raw = reader.ReadSingle();
                data.Unk_303_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
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
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
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
                };
            }
        }

        public partial class Action_Param_2 : MhwStructItem {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Action Param 2";

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

            protected float G_Rate_raw;
            public const string G_Rate_displayName = "G Rate";
            public const int G_Rate_sortIndex = 100;
            [SortOrder(G_Rate_sortIndex)]
            [DisplayName(G_Rate_displayName)]
            public virtual float G_Rate {
                get => G_Rate_raw;
                set {
                    if (G_Rate_raw == value) return;
                    G_Rate_raw = value;
                    OnPropertyChanged(nameof(G_Rate));
                }
            }

            protected float Momentum_raw;
            public const string Momentum_displayName = "Momentum";
            public const int Momentum_sortIndex = 150;
            [SortOrder(Momentum_sortIndex)]
            [DisplayName(Momentum_displayName)]
            public virtual float Momentum {
                get => Momentum_raw;
                set {
                    if (Momentum_raw == value) return;
                    Momentum_raw = value;
                    OnPropertyChanged(nameof(Momentum));
                }
            }

            protected float V_Offset_raw;
            public const string V_Offset_displayName = "V Offset";
            public const int V_Offset_sortIndex = 200;
            [SortOrder(V_Offset_sortIndex)]
            [DisplayName(V_Offset_displayName)]
            public virtual float V_Offset {
                get => V_Offset_raw;
                set {
                    if (V_Offset_raw == value) return;
                    V_Offset_raw = value;
                    OnPropertyChanged(nameof(V_Offset));
                }
            }

            protected float H_Offset_raw;
            public const string H_Offset_displayName = "H Offset";
            public const int H_Offset_sortIndex = 250;
            [SortOrder(H_Offset_sortIndex)]
            [DisplayName(H_Offset_displayName)]
            public virtual float H_Offset {
                get => H_Offset_raw;
                set {
                    if (H_Offset_raw == value) return;
                    H_Offset_raw = value;
                    OnPropertyChanged(nameof(H_Offset));
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

            public static Action_Param_2 LoadData(BinaryReader reader, ulong i) {
                var data = new Action_Param_2();
                data.Index = i;
                data.Gravity_raw = reader.ReadSingle();
                data.G_Rate_raw = reader.ReadSingle();
                data.Momentum_raw = reader.ReadSingle();
                data.V_Offset_raw = reader.ReadSingle();
                data.H_Offset_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Gravity_raw);
                writer.Write(G_Rate_raw);
                writer.Write(Momentum_raw);
                writer.Write(V_Offset_raw);
                writer.Write(H_Offset_raw);
            }
        }

        public partial class W07p_Params_9_Wyrmstake_Blast_Params : MhwStructItem, IHasCustomView<MultiStructItemCustomView> {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W07p Params (9) - Wyrmstake Blast Params";

            protected float Unk_304_raw;
            public const string Unk_304_displayName = "Unk 304";
            public const int Unk_304_sortIndex = 50;
            [SortOrder(Unk_304_sortIndex)]
            [DisplayName(Unk_304_displayName)]
            public virtual float Unk_304 {
                get => Unk_304_raw;
                set {
                    if (Unk_304_raw == value) return;
                    Unk_304_raw = value;
                    OnPropertyChanged(nameof(Unk_304));
                }
            }

            protected float Unk_305_raw;
            public const string Unk_305_displayName = "Unk 305";
            public const int Unk_305_sortIndex = 100;
            [SortOrder(Unk_305_sortIndex)]
            [DisplayName(Unk_305_displayName)]
            public virtual float Unk_305 {
                get => Unk_305_raw;
                set {
                    if (Unk_305_raw == value) return;
                    Unk_305_raw = value;
                    OnPropertyChanged(nameof(Unk_305));
                }
            }

            protected float Unk_306_raw;
            public const string Unk_306_displayName = "Unk 306";
            public const int Unk_306_sortIndex = 150;
            [SortOrder(Unk_306_sortIndex)]
            [DisplayName(Unk_306_displayName)]
            public virtual float Unk_306 {
                get => Unk_306_raw;
                set {
                    if (Unk_306_raw == value) return;
                    Unk_306_raw = value;
                    OnPropertyChanged(nameof(Unk_306));
                }
            }

            protected float Unk_307_raw;
            public const string Unk_307_displayName = "Unk 307";
            public const int Unk_307_sortIndex = 200;
            [SortOrder(Unk_307_sortIndex)]
            [DisplayName(Unk_307_displayName)]
            public virtual float Unk_307 {
                get => Unk_307_raw;
                set {
                    if (Unk_307_raw == value) return;
                    Unk_307_raw = value;
                    OnPropertyChanged(nameof(Unk_307));
                }
            }

            protected float Unk_308_raw;
            public const string Unk_308_displayName = "Unk 308";
            public const int Unk_308_sortIndex = 250;
            [SortOrder(Unk_308_sortIndex)]
            [DisplayName(Unk_308_displayName)]
            public virtual float Unk_308 {
                get => Unk_308_raw;
                set {
                    if (Unk_308_raw == value) return;
                    Unk_308_raw = value;
                    OnPropertyChanged(nameof(Unk_308));
                }
            }

            protected float Unk_309_raw;
            public const string Unk_309_displayName = "Unk 309";
            public const int Unk_309_sortIndex = 300;
            [SortOrder(Unk_309_sortIndex)]
            [DisplayName(Unk_309_displayName)]
            public virtual float Unk_309 {
                get => Unk_309_raw;
                set {
                    if (Unk_309_raw == value) return;
                    Unk_309_raw = value;
                    OnPropertyChanged(nameof(Unk_309));
                }
            }

            protected float Unk_310_raw;
            public const string Unk_310_displayName = "Unk 310";
            public const int Unk_310_sortIndex = 350;
            [SortOrder(Unk_310_sortIndex)]
            [DisplayName(Unk_310_displayName)]
            public virtual float Unk_310 {
                get => Unk_310_raw;
                set {
                    if (Unk_310_raw == value) return;
                    Unk_310_raw = value;
                    OnPropertyChanged(nameof(Unk_310));
                }
            }

            protected float Unk_311_raw;
            public const string Unk_311_displayName = "Unk 311";
            public const int Unk_311_sortIndex = 400;
            [SortOrder(Unk_311_sortIndex)]
            [DisplayName(Unk_311_displayName)]
            public virtual float Unk_311 {
                get => Unk_311_raw;
                set {
                    if (Unk_311_raw == value) return;
                    Unk_311_raw = value;
                    OnPropertyChanged(nameof(Unk_311));
                }
            }

            protected float Unk_312_raw;
            public const string Unk_312_displayName = "Unk 312";
            public const int Unk_312_sortIndex = 450;
            [SortOrder(Unk_312_sortIndex)]
            [DisplayName(Unk_312_displayName)]
            public virtual float Unk_312 {
                get => Unk_312_raw;
                set {
                    if (Unk_312_raw == value) return;
                    Unk_312_raw = value;
                    OnPropertyChanged(nameof(Unk_312));
                }
            }

            protected float Unk_313_raw;
            public const string Unk_313_displayName = "Unk 313";
            public const int Unk_313_sortIndex = 500;
            [SortOrder(Unk_313_sortIndex)]
            [DisplayName(Unk_313_displayName)]
            public virtual float Unk_313 {
                get => Unk_313_raw;
                set {
                    if (Unk_313_raw == value) return;
                    Unk_313_raw = value;
                    OnPropertyChanged(nameof(Unk_313));
                }
            }

            protected float Unk_314_raw;
            public const string Unk_314_displayName = "Unk 314";
            public const int Unk_314_sortIndex = 550;
            [SortOrder(Unk_314_sortIndex)]
            [DisplayName(Unk_314_displayName)]
            public virtual float Unk_314 {
                get => Unk_314_raw;
                set {
                    if (Unk_314_raw == value) return;
                    Unk_314_raw = value;
                    OnPropertyChanged(nameof(Unk_314));
                }
            }

            protected float Unk_315_raw;
            public const string Unk_315_displayName = "Unk 315";
            public const int Unk_315_sortIndex = 600;
            [SortOrder(Unk_315_sortIndex)]
            [DisplayName(Unk_315_displayName)]
            public virtual float Unk_315 {
                get => Unk_315_raw;
                set {
                    if (Unk_315_raw == value) return;
                    Unk_315_raw = value;
                    OnPropertyChanged(nameof(Unk_315));
                }
            }

            protected float Unk_316_raw;
            public const string Unk_316_displayName = "Unk 316";
            public const int Unk_316_sortIndex = 650;
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
            public const int Unk_317_sortIndex = 700;
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
            public const int Unk_318_sortIndex = 750;
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
            public const int Unk_319_sortIndex = 800;
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
            public const int Unk_320_sortIndex = 850;
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
            public const int Unk_321_sortIndex = 900;
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
            public const int Unk_322_sortIndex = 950;
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

            protected float Full_burst_Damage_Multiplier_raw;
            public const string Full_burst_Damage_Multiplier_displayName = "Full-burst Damage Multiplier";
            public const int Full_burst_Damage_Multiplier_sortIndex = 1000;
            [SortOrder(Full_burst_Damage_Multiplier_sortIndex)]
            [DisplayName(Full_burst_Damage_Multiplier_displayName)]
            public virtual float Full_burst_Damage_Multiplier {
                get => Full_burst_Damage_Multiplier_raw;
                set {
                    if (Full_burst_Damage_Multiplier_raw == value) return;
                    Full_burst_Damage_Multiplier_raw = value;
                    OnPropertyChanged(nameof(Full_burst_Damage_Multiplier));
                }
            }

            protected float Charge_Shell_Damage_Multiplier_raw;
            public const string Charge_Shell_Damage_Multiplier_displayName = "Charge Shell Damage Multiplier";
            public const int Charge_Shell_Damage_Multiplier_sortIndex = 1050;
            [SortOrder(Charge_Shell_Damage_Multiplier_sortIndex)]
            [DisplayName(Charge_Shell_Damage_Multiplier_displayName)]
            public virtual float Charge_Shell_Damage_Multiplier {
                get => Charge_Shell_Damage_Multiplier_raw;
                set {
                    if (Charge_Shell_Damage_Multiplier_raw == value) return;
                    Charge_Shell_Damage_Multiplier_raw = value;
                    OnPropertyChanged(nameof(Charge_Shell_Damage_Multiplier));
                }
            }

            protected float Wyvernfire_Damage_Multiplier_raw;
            public const string Wyvernfire_Damage_Multiplier_displayName = "Wyvernfire Damage Multiplier";
            public const int Wyvernfire_Damage_Multiplier_sortIndex = 1100;
            [SortOrder(Wyvernfire_Damage_Multiplier_sortIndex)]
            [DisplayName(Wyvernfire_Damage_Multiplier_displayName)]
            public virtual float Wyvernfire_Damage_Multiplier {
                get => Wyvernfire_Damage_Multiplier_raw;
                set {
                    if (Wyvernfire_Damage_Multiplier_raw == value) return;
                    Wyvernfire_Damage_Multiplier_raw = value;
                    OnPropertyChanged(nameof(Wyvernfire_Damage_Multiplier));
                }
            }

            protected float Wyrmstake_Explosion_Damage_Multiplier_raw;
            public const string Wyrmstake_Explosion_Damage_Multiplier_displayName = "Wyrmstake Explosion Damage Multiplier";
            public const int Wyrmstake_Explosion_Damage_Multiplier_sortIndex = 1150;
            [SortOrder(Wyrmstake_Explosion_Damage_Multiplier_sortIndex)]
            [DisplayName(Wyrmstake_Explosion_Damage_Multiplier_displayName)]
            public virtual float Wyrmstake_Explosion_Damage_Multiplier {
                get => Wyrmstake_Explosion_Damage_Multiplier_raw;
                set {
                    if (Wyrmstake_Explosion_Damage_Multiplier_raw == value) return;
                    Wyrmstake_Explosion_Damage_Multiplier_raw = value;
                    OnPropertyChanged(nameof(Wyrmstake_Explosion_Damage_Multiplier));
                }
            }

            protected float Ally_Attack_Trigger_Explosion_raw;
            public const string Ally_Attack_Trigger_Explosion_displayName = "Ally Attack Trigger Explosion";
            public const int Ally_Attack_Trigger_Explosion_sortIndex = 1200;
            [SortOrder(Ally_Attack_Trigger_Explosion_sortIndex)]
            [DisplayName(Ally_Attack_Trigger_Explosion_displayName)]
            public virtual float Ally_Attack_Trigger_Explosion {
                get => Ally_Attack_Trigger_Explosion_raw;
                set {
                    if (Ally_Attack_Trigger_Explosion_raw == value) return;
                    Ally_Attack_Trigger_Explosion_raw = value;
                    OnPropertyChanged(nameof(Ally_Attack_Trigger_Explosion));
                }
            }

            protected float Thorn_Pod_Base_Duration_raw;
            public const string Thorn_Pod_Base_Duration_displayName = "Thorn Pod Base Duration";
            public const int Thorn_Pod_Base_Duration_sortIndex = 1250;
            [SortOrder(Thorn_Pod_Base_Duration_sortIndex)]
            [DisplayName(Thorn_Pod_Base_Duration_displayName)]
            public virtual float Thorn_Pod_Base_Duration {
                get => Thorn_Pod_Base_Duration_raw;
                set {
                    if (Thorn_Pod_Base_Duration_raw == value) return;
                    Thorn_Pod_Base_Duration_raw = value;
                    OnPropertyChanged(nameof(Thorn_Pod_Base_Duration));
                }
            }

            protected float Thorn_Pod_Extra_Duration_raw;
            public const string Thorn_Pod_Extra_Duration_displayName = "Thorn Pod Extra Duration";
            public const int Thorn_Pod_Extra_Duration_sortIndex = 1300;
            [SortOrder(Thorn_Pod_Extra_Duration_sortIndex)]
            [DisplayName(Thorn_Pod_Extra_Duration_displayName)]
            public virtual float Thorn_Pod_Extra_Duration {
                get => Thorn_Pod_Extra_Duration_raw;
                set {
                    if (Thorn_Pod_Extra_Duration_raw == value) return;
                    Thorn_Pod_Extra_Duration_raw = value;
                    OnPropertyChanged(nameof(Thorn_Pod_Extra_Duration));
                }
            }

            protected float Bomb_Pierce_Pod_Base_Duration_raw;
            public const string Bomb_Pierce_Pod_Base_Duration_displayName = "Bomb/Pierce Pod Base Duration";
            public const int Bomb_Pierce_Pod_Base_Duration_sortIndex = 1350;
            [SortOrder(Bomb_Pierce_Pod_Base_Duration_sortIndex)]
            [DisplayName(Bomb_Pierce_Pod_Base_Duration_displayName)]
            public virtual float Bomb_Pierce_Pod_Base_Duration {
                get => Bomb_Pierce_Pod_Base_Duration_raw;
                set {
                    if (Bomb_Pierce_Pod_Base_Duration_raw == value) return;
                    Bomb_Pierce_Pod_Base_Duration_raw = value;
                    OnPropertyChanged(nameof(Bomb_Pierce_Pod_Base_Duration));
                }
            }

            protected float Bomb_Pierce_Pod_Extra_Duration_raw;
            public const string Bomb_Pierce_Pod_Extra_Duration_displayName = "Bomb/Pierce Pod Extra Duration";
            public const int Bomb_Pierce_Pod_Extra_Duration_sortIndex = 1400;
            [SortOrder(Bomb_Pierce_Pod_Extra_Duration_sortIndex)]
            [DisplayName(Bomb_Pierce_Pod_Extra_Duration_displayName)]
            public virtual float Bomb_Pierce_Pod_Extra_Duration {
                get => Bomb_Pierce_Pod_Extra_Duration_raw;
                set {
                    if (Bomb_Pierce_Pod_Extra_Duration_raw == value) return;
                    Bomb_Pierce_Pod_Extra_Duration_raw = value;
                    OnPropertyChanged(nameof(Bomb_Pierce_Pod_Extra_Duration));
                }
            }

            protected float Scatternut_Crystalburst_Torch_Pod_Brightmoss_Base_Duration_raw;
            public const string Scatternut_Crystalburst_Torch_Pod_Brightmoss_Base_Duration_displayName = "Scatternut/Crystalburst/Torch Pod/Brightmoss Base Duration";
            public const int Scatternut_Crystalburst_Torch_Pod_Brightmoss_Base_Duration_sortIndex = 1450;
            [SortOrder(Scatternut_Crystalburst_Torch_Pod_Brightmoss_Base_Duration_sortIndex)]
            [DisplayName(Scatternut_Crystalburst_Torch_Pod_Brightmoss_Base_Duration_displayName)]
            public virtual float Scatternut_Crystalburst_Torch_Pod_Brightmoss_Base_Duration {
                get => Scatternut_Crystalburst_Torch_Pod_Brightmoss_Base_Duration_raw;
                set {
                    if (Scatternut_Crystalburst_Torch_Pod_Brightmoss_Base_Duration_raw == value) return;
                    Scatternut_Crystalburst_Torch_Pod_Brightmoss_Base_Duration_raw = value;
                    OnPropertyChanged(nameof(Scatternut_Crystalburst_Torch_Pod_Brightmoss_Base_Duration));
                }
            }

            protected float Scatternut_Crystalburst_Torch_Pod_Brightmoss_Extra_Duration_raw;
            public const string Scatternut_Crystalburst_Torch_Pod_Brightmoss_Extra_Duration_displayName = "Scatternut/Crystalburst/Torch Pod/Brightmoss Extra Duration";
            public const int Scatternut_Crystalburst_Torch_Pod_Brightmoss_Extra_Duration_sortIndex = 1500;
            [SortOrder(Scatternut_Crystalburst_Torch_Pod_Brightmoss_Extra_Duration_sortIndex)]
            [DisplayName(Scatternut_Crystalburst_Torch_Pod_Brightmoss_Extra_Duration_displayName)]
            public virtual float Scatternut_Crystalburst_Torch_Pod_Brightmoss_Extra_Duration {
                get => Scatternut_Crystalburst_Torch_Pod_Brightmoss_Extra_Duration_raw;
                set {
                    if (Scatternut_Crystalburst_Torch_Pod_Brightmoss_Extra_Duration_raw == value) return;
                    Scatternut_Crystalburst_Torch_Pod_Brightmoss_Extra_Duration_raw = value;
                    OnPropertyChanged(nameof(Scatternut_Crystalburst_Torch_Pod_Brightmoss_Extra_Duration));
                }
            }

            protected float Puddle_Dragon_Base_Duration_raw;
            public const string Puddle_Dragon_Base_Duration_displayName = "Puddle/Dragon Base Duration";
            public const int Puddle_Dragon_Base_Duration_sortIndex = 1550;
            [SortOrder(Puddle_Dragon_Base_Duration_sortIndex)]
            [DisplayName(Puddle_Dragon_Base_Duration_displayName)]
            public virtual float Puddle_Dragon_Base_Duration {
                get => Puddle_Dragon_Base_Duration_raw;
                set {
                    if (Puddle_Dragon_Base_Duration_raw == value) return;
                    Puddle_Dragon_Base_Duration_raw = value;
                    OnPropertyChanged(nameof(Puddle_Dragon_Base_Duration));
                }
            }

            protected float Puddle_Dragon_Pod_Extra_Duration_raw;
            public const string Puddle_Dragon_Pod_Extra_Duration_displayName = "Puddle/Dragon Pod Extra Duration";
            public const int Puddle_Dragon_Pod_Extra_Duration_sortIndex = 1600;
            [SortOrder(Puddle_Dragon_Pod_Extra_Duration_sortIndex)]
            [DisplayName(Puddle_Dragon_Pod_Extra_Duration_displayName)]
            public virtual float Puddle_Dragon_Pod_Extra_Duration {
                get => Puddle_Dragon_Pod_Extra_Duration_raw;
                set {
                    if (Puddle_Dragon_Pod_Extra_Duration_raw == value) return;
                    Puddle_Dragon_Pod_Extra_Duration_raw = value;
                    OnPropertyChanged(nameof(Puddle_Dragon_Pod_Extra_Duration));
                }
            }

            protected float Unk_336_raw;
            public const string Unk_336_displayName = "Unk 336";
            public const int Unk_336_sortIndex = 1650;
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

            protected float Unk_337_raw;
            public const string Unk_337_displayName = "Unk 337";
            public const int Unk_337_sortIndex = 1700;
            [SortOrder(Unk_337_sortIndex)]
            [DisplayName(Unk_337_displayName)]
            public virtual float Unk_337 {
                get => Unk_337_raw;
                set {
                    if (Unk_337_raw == value) return;
                    Unk_337_raw = value;
                    OnPropertyChanged(nameof(Unk_337));
                }
            }

            protected float Redpit_Base_Duration_raw;
            public const string Redpit_Base_Duration_displayName = "Redpit Base Duration";
            public const int Redpit_Base_Duration_sortIndex = 1750;
            [SortOrder(Redpit_Base_Duration_sortIndex)]
            [DisplayName(Redpit_Base_Duration_displayName)]
            public virtual float Redpit_Base_Duration {
                get => Redpit_Base_Duration_raw;
                set {
                    if (Redpit_Base_Duration_raw == value) return;
                    Redpit_Base_Duration_raw = value;
                    OnPropertyChanged(nameof(Redpit_Base_Duration));
                }
            }

            protected float Redpit_Extra_Duration_raw;
            public const string Redpit_Extra_Duration_displayName = "Redpit Extra Duration";
            public const int Redpit_Extra_Duration_sortIndex = 1800;
            [SortOrder(Redpit_Extra_Duration_sortIndex)]
            [DisplayName(Redpit_Extra_Duration_displayName)]
            public virtual float Redpit_Extra_Duration {
                get => Redpit_Extra_Duration_raw;
                set {
                    if (Redpit_Extra_Duration_raw == value) return;
                    Redpit_Extra_Duration_raw = value;
                    OnPropertyChanged(nameof(Redpit_Extra_Duration));
                }
            }

            protected float Stone_Base_Duration_raw;
            public const string Stone_Base_Duration_displayName = "Stone Base Duration";
            public const int Stone_Base_Duration_sortIndex = 1850;
            [SortOrder(Stone_Base_Duration_sortIndex)]
            [DisplayName(Stone_Base_Duration_displayName)]
            public virtual float Stone_Base_Duration {
                get => Stone_Base_Duration_raw;
                set {
                    if (Stone_Base_Duration_raw == value) return;
                    Stone_Base_Duration_raw = value;
                    OnPropertyChanged(nameof(Stone_Base_Duration));
                }
            }

            protected float Stone_Extra_Duration_raw;
            public const string Stone_Extra_Duration_displayName = "Stone Extra Duration";
            public const int Stone_Extra_Duration_sortIndex = 1900;
            [SortOrder(Stone_Extra_Duration_sortIndex)]
            [DisplayName(Stone_Extra_Duration_displayName)]
            public virtual float Stone_Extra_Duration {
                get => Stone_Extra_Duration_raw;
                set {
                    if (Stone_Extra_Duration_raw == value) return;
                    Stone_Extra_Duration_raw = value;
                    OnPropertyChanged(nameof(Stone_Extra_Duration));
                }
            }

            protected float Unk_342_raw;
            public const string Unk_342_displayName = "Unk 342";
            public const int Unk_342_sortIndex = 1950;
            [SortOrder(Unk_342_sortIndex)]
            [DisplayName(Unk_342_displayName)]
            public virtual float Unk_342 {
                get => Unk_342_raw;
                set {
                    if (Unk_342_raw == value) return;
                    Unk_342_raw = value;
                    OnPropertyChanged(nameof(Unk_342));
                }
            }

            protected float Unk_343_raw;
            public const string Unk_343_displayName = "Unk 343";
            public const int Unk_343_sortIndex = 2000;
            [SortOrder(Unk_343_sortIndex)]
            [DisplayName(Unk_343_displayName)]
            public virtual float Unk_343 {
                get => Unk_343_raw;
                set {
                    if (Unk_343_raw == value) return;
                    Unk_343_raw = value;
                    OnPropertyChanged(nameof(Unk_343));
                }
            }

            protected float Unk_344_raw;
            public const string Unk_344_displayName = "Unk 344";
            public const int Unk_344_sortIndex = 2050;
            [SortOrder(Unk_344_sortIndex)]
            [DisplayName(Unk_344_displayName)]
            public virtual float Unk_344 {
                get => Unk_344_raw;
                set {
                    if (Unk_344_raw == value) return;
                    Unk_344_raw = value;
                    OnPropertyChanged(nameof(Unk_344));
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

            public static W07p_Params_9_Wyrmstake_Blast_Params LoadData(BinaryReader reader, ulong i) {
                var data = new W07p_Params_9_Wyrmstake_Blast_Params();
                data.Index = i;
                data.Unk_304_raw = reader.ReadSingle();
                data.Unk_305_raw = reader.ReadSingle();
                data.Unk_306_raw = reader.ReadSingle();
                data.Unk_307_raw = reader.ReadSingle();
                data.Unk_308_raw = reader.ReadSingle();
                data.Unk_309_raw = reader.ReadSingle();
                data.Unk_310_raw = reader.ReadSingle();
                data.Unk_311_raw = reader.ReadSingle();
                data.Unk_312_raw = reader.ReadSingle();
                data.Unk_313_raw = reader.ReadSingle();
                data.Unk_314_raw = reader.ReadSingle();
                data.Unk_315_raw = reader.ReadSingle();
                data.Unk_316_raw = reader.ReadSingle();
                data.Unk_317_raw = reader.ReadSingle();
                data.Unk_318_raw = reader.ReadSingle();
                data.Unk_319_raw = reader.ReadSingle();
                data.Unk_320_raw = reader.ReadSingle();
                data.Unk_321_raw = reader.ReadSingle();
                data.Unk_322_raw = reader.ReadSingle();
                data.Full_burst_Damage_Multiplier_raw = reader.ReadSingle();
                data.Charge_Shell_Damage_Multiplier_raw = reader.ReadSingle();
                data.Wyvernfire_Damage_Multiplier_raw = reader.ReadSingle();
                data.Wyrmstake_Explosion_Damage_Multiplier_raw = reader.ReadSingle();
                data.Ally_Attack_Trigger_Explosion_raw = reader.ReadSingle();
                data.Thorn_Pod_Base_Duration_raw = reader.ReadSingle();
                data.Thorn_Pod_Extra_Duration_raw = reader.ReadSingle();
                data.Bomb_Pierce_Pod_Base_Duration_raw = reader.ReadSingle();
                data.Bomb_Pierce_Pod_Extra_Duration_raw = reader.ReadSingle();
                data.Scatternut_Crystalburst_Torch_Pod_Brightmoss_Base_Duration_raw = reader.ReadSingle();
                data.Scatternut_Crystalburst_Torch_Pod_Brightmoss_Extra_Duration_raw = reader.ReadSingle();
                data.Puddle_Dragon_Base_Duration_raw = reader.ReadSingle();
                data.Puddle_Dragon_Pod_Extra_Duration_raw = reader.ReadSingle();
                data.Unk_336_raw = reader.ReadSingle();
                data.Unk_337_raw = reader.ReadSingle();
                data.Redpit_Base_Duration_raw = reader.ReadSingle();
                data.Redpit_Extra_Duration_raw = reader.ReadSingle();
                data.Stone_Base_Duration_raw = reader.ReadSingle();
                data.Stone_Extra_Duration_raw = reader.ReadSingle();
                data.Unk_342_raw = reader.ReadSingle();
                data.Unk_343_raw = reader.ReadSingle();
                data.Unk_344_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
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
                writer.Write(Full_burst_Damage_Multiplier_raw);
                writer.Write(Charge_Shell_Damage_Multiplier_raw);
                writer.Write(Wyvernfire_Damage_Multiplier_raw);
                writer.Write(Wyrmstake_Explosion_Damage_Multiplier_raw);
                writer.Write(Ally_Attack_Trigger_Explosion_raw);
                writer.Write(Thorn_Pod_Base_Duration_raw);
                writer.Write(Thorn_Pod_Extra_Duration_raw);
                writer.Write(Bomb_Pierce_Pod_Base_Duration_raw);
                writer.Write(Bomb_Pierce_Pod_Extra_Duration_raw);
                writer.Write(Scatternut_Crystalburst_Torch_Pod_Brightmoss_Base_Duration_raw);
                writer.Write(Scatternut_Crystalburst_Torch_Pod_Brightmoss_Extra_Duration_raw);
                writer.Write(Puddle_Dragon_Base_Duration_raw);
                writer.Write(Puddle_Dragon_Pod_Extra_Duration_raw);
                writer.Write(Unk_336_raw);
                writer.Write(Unk_337_raw);
                writer.Write(Redpit_Base_Duration_raw);
                writer.Write(Redpit_Extra_Duration_raw);
                writer.Write(Stone_Base_Duration_raw);
                writer.Write(Stone_Extra_Duration_raw);
                writer.Write(Unk_342_raw);
                writer.Write(Unk_343_raw);
                writer.Write(Unk_344_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
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
                    new MultiStructItemCustomView(this, "Full-burst Damage Multiplier", "Full_burst_Damage_Multiplier"),
                    new MultiStructItemCustomView(this, "Charge Shell Damage Multiplier", "Charge_Shell_Damage_Multiplier"),
                    new MultiStructItemCustomView(this, "Wyvernfire Damage Multiplier", "Wyvernfire_Damage_Multiplier"),
                    new MultiStructItemCustomView(this, "Wyrmstake Explosion Damage Multiplier", "Wyrmstake_Explosion_Damage_Multiplier"),
                    new MultiStructItemCustomView(this, "Ally Attack Trigger Explosion", "Ally_Attack_Trigger_Explosion"),
                    new MultiStructItemCustomView(this, "Thorn Pod Base Duration", "Thorn_Pod_Base_Duration"),
                    new MultiStructItemCustomView(this, "Thorn Pod Extra Duration", "Thorn_Pod_Extra_Duration"),
                    new MultiStructItemCustomView(this, "Bomb/Pierce Pod Base Duration", "Bomb_Pierce_Pod_Base_Duration"),
                    new MultiStructItemCustomView(this, "Bomb/Pierce Pod Extra Duration", "Bomb_Pierce_Pod_Extra_Duration"),
                    new MultiStructItemCustomView(this, "Scatternut/Crystalburst/Torch Pod/Brightmoss Base Duration", "Scatternut_Crystalburst_Torch_Pod_Brightmoss_Base_Duration"),
                    new MultiStructItemCustomView(this, "Scatternut/Crystalburst/Torch Pod/Brightmoss Extra Duration", "Scatternut_Crystalburst_Torch_Pod_Brightmoss_Extra_Duration"),
                    new MultiStructItemCustomView(this, "Puddle/Dragon Base Duration", "Puddle_Dragon_Base_Duration"),
                    new MultiStructItemCustomView(this, "Puddle/Dragon Pod Extra Duration", "Puddle_Dragon_Pod_Extra_Duration"),
                    new MultiStructItemCustomView(this, "Unk 336", "Unk_336"),
                    new MultiStructItemCustomView(this, "Unk 337", "Unk_337"),
                    new MultiStructItemCustomView(this, "Redpit Base Duration", "Redpit_Base_Duration"),
                    new MultiStructItemCustomView(this, "Redpit Extra Duration", "Redpit_Extra_Duration"),
                    new MultiStructItemCustomView(this, "Stone Base Duration", "Stone_Base_Duration"),
                    new MultiStructItemCustomView(this, "Stone Extra Duration", "Stone_Extra_Duration"),
                    new MultiStructItemCustomView(this, "Unk 342", "Unk_342"),
                    new MultiStructItemCustomView(this, "Unk 343", "Unk_343"),
                    new MultiStructItemCustomView(this, "Unk 344", "Unk_344"),
                };
            }
        }

        public partial class Action_Param_3 : MhwStructItem {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Action Param 3";

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

            protected float G_Rate_raw;
            public const string G_Rate_displayName = "G Rate";
            public const int G_Rate_sortIndex = 100;
            [SortOrder(G_Rate_sortIndex)]
            [DisplayName(G_Rate_displayName)]
            public virtual float G_Rate {
                get => G_Rate_raw;
                set {
                    if (G_Rate_raw == value) return;
                    G_Rate_raw = value;
                    OnPropertyChanged(nameof(G_Rate));
                }
            }

            protected float Momentum_raw;
            public const string Momentum_displayName = "Momentum";
            public const int Momentum_sortIndex = 150;
            [SortOrder(Momentum_sortIndex)]
            [DisplayName(Momentum_displayName)]
            public virtual float Momentum {
                get => Momentum_raw;
                set {
                    if (Momentum_raw == value) return;
                    Momentum_raw = value;
                    OnPropertyChanged(nameof(Momentum));
                }
            }

            protected float V_Offset_raw;
            public const string V_Offset_displayName = "V Offset";
            public const int V_Offset_sortIndex = 200;
            [SortOrder(V_Offset_sortIndex)]
            [DisplayName(V_Offset_displayName)]
            public virtual float V_Offset {
                get => V_Offset_raw;
                set {
                    if (V_Offset_raw == value) return;
                    V_Offset_raw = value;
                    OnPropertyChanged(nameof(V_Offset));
                }
            }

            protected float H_Offset_raw;
            public const string H_Offset_displayName = "H Offset";
            public const int H_Offset_sortIndex = 250;
            [SortOrder(H_Offset_sortIndex)]
            [DisplayName(H_Offset_displayName)]
            public virtual float H_Offset {
                get => H_Offset_raw;
                set {
                    if (H_Offset_raw == value) return;
                    H_Offset_raw = value;
                    OnPropertyChanged(nameof(H_Offset));
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

            public static Action_Param_3 LoadData(BinaryReader reader, ulong i) {
                var data = new Action_Param_3();
                data.Index = i;
                data.Gravity_raw = reader.ReadSingle();
                data.G_Rate_raw = reader.ReadSingle();
                data.Momentum_raw = reader.ReadSingle();
                data.V_Offset_raw = reader.ReadSingle();
                data.H_Offset_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Gravity_raw);
                writer.Write(G_Rate_raw);
                writer.Write(Momentum_raw);
                writer.Write(V_Offset_raw);
                writer.Write(H_Offset_raw);
            }
        }

        public partial class W07p_Params_10_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView> {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W07p Params (10)";

            protected float Shelling_Multiplier_raw;
            public const string Shelling_Multiplier_displayName = "Shelling Multiplier";
            public const int Shelling_Multiplier_sortIndex = 50;
            [SortOrder(Shelling_Multiplier_sortIndex)]
            [DisplayName(Shelling_Multiplier_displayName)]
            public virtual float Shelling_Multiplier {
                get => Shelling_Multiplier_raw;
                set {
                    if (Shelling_Multiplier_raw == value) return;
                    Shelling_Multiplier_raw = value;
                    OnPropertyChanged(nameof(Shelling_Multiplier));
                }
            }

            protected float Unk_346_raw;
            public const string Unk_346_displayName = "Unk 346";
            public const int Unk_346_sortIndex = 100;
            [SortOrder(Unk_346_sortIndex)]
            [DisplayName(Unk_346_displayName)]
            public virtual float Unk_346 {
                get => Unk_346_raw;
                set {
                    if (Unk_346_raw == value) return;
                    Unk_346_raw = value;
                    OnPropertyChanged(nameof(Unk_346));
                }
            }

            protected float Unk_347_raw;
            public const string Unk_347_displayName = "Unk 347";
            public const int Unk_347_sortIndex = 150;
            [SortOrder(Unk_347_sortIndex)]
            [DisplayName(Unk_347_displayName)]
            public virtual float Unk_347 {
                get => Unk_347_raw;
                set {
                    if (Unk_347_raw == value) return;
                    Unk_347_raw = value;
                    OnPropertyChanged(nameof(Unk_347));
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

            public static W07p_Params_10_ LoadData(BinaryReader reader, ulong i) {
                var data = new W07p_Params_10_();
                data.Index = i;
                data.Shelling_Multiplier_raw = reader.ReadSingle();
                data.Unk_346_raw = reader.ReadSingle();
                data.Unk_347_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Shelling_Multiplier_raw);
                writer.Write(Unk_346_raw);
                writer.Write(Unk_347_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Shelling Multiplier", "Shelling_Multiplier"),
                    new MultiStructItemCustomView(this, "Unk 346", "Unk_346"),
                    new MultiStructItemCustomView(this, "Unk 347", "Unk_347"),
                };
            }
        }

        public override void LoadFile(string targetFile) {
            using var reader = new BinaryReader(OpenFile(targetFile, EncryptionKey), Encoding.UTF8);
            data = new LinkedList<MhwStructDataContainer>();
            var W07p_Params_1_Shared__ = new MhwStructDataContainer(W07p_Params_1_Shared_.LoadData(reader, null), typeof(W07p_Params_1_Shared_));
            data.AddLast(W07p_Params_1_Shared__);
            var Unk_Arr_1_Shared__ = new MhwStructDataContainer(Unk_Arr_1_Shared_.LoadData(reader, null), typeof(Unk_Arr_1_Shared_));
            data.AddLast(Unk_Arr_1_Shared__);
            var W07p_Params_2_Shared__ = new MhwStructDataContainer(W07p_Params_2_Shared_.LoadData(reader, null), typeof(W07p_Params_2_Shared_));
            data.AddLast(W07p_Params_2_Shared__);
            var Guard_Angles_Shared__ = new MhwStructDataContainer(Guard_Angles_Shared_.LoadData(reader, null), typeof(Guard_Angles_Shared_));
            data.AddLast(Guard_Angles_Shared__);
            var W07p_Params_3_Shared__ = new MhwStructDataContainer(W07p_Params_3_Shared_.LoadData(reader, null), typeof(W07p_Params_3_Shared_));
            data.AddLast(W07p_Params_3_Shared__);
            var Unk_Arr_2_Shared__ = new MhwStructDataContainer(Unk_Arr_2_Shared_.LoadData(reader, null), typeof(Unk_Arr_2_Shared_));
            data.AddLast(Unk_Arr_2_Shared__);
            var W07p_Params_4_Shared__ = new MhwStructDataContainer(W07p_Params_4_Shared_.LoadData(reader, null), typeof(W07p_Params_4_Shared_));
            data.AddLast(W07p_Params_4_Shared__);
            var W07p_Params_5_Shelling_Params_ = new MhwStructDataContainer(W07p_Params_5_Shelling_Params.LoadData(reader, null), typeof(W07p_Params_5_Shelling_Params));
            data.AddLast(W07p_Params_5_Shelling_Params_);
            var Shell_Ammo_Params_ = new MhwStructDataContainer(Shell_Ammo_Params.LoadData(reader, null), typeof(Shell_Ammo_Params));
            data.AddLast(Shell_Ammo_Params_);
            var W07p_Params_6_Shelling_Params_ = new MhwStructDataContainer(W07p_Params_6_Shelling_Params.LoadData(reader, null), typeof(W07p_Params_6_Shelling_Params));
            data.AddLast(W07p_Params_6_Shelling_Params_);
            var Shelling_Sharpness_Usage_ = new MhwStructDataContainer(Shelling_Sharpness_Usage.LoadData(reader, null), typeof(Shelling_Sharpness_Usage));
            data.AddLast(Shelling_Sharpness_Usage_);
            var W07p_Params_7__ = new MhwStructDataContainer(W07p_Params_7_.LoadData(reader, null), typeof(W07p_Params_7_));
            data.AddLast(W07p_Params_7__);
            var Action_Param_1_ = new MhwStructDataContainer(Action_Param_1.LoadData(reader, null), typeof(Action_Param_1));
            data.AddLast(Action_Param_1_);
            var W07p_Params_8__ = new MhwStructDataContainer(W07p_Params_8_.LoadData(reader, null), typeof(W07p_Params_8_));
            data.AddLast(W07p_Params_8__);
            var Action_Param_2_ = new MhwStructDataContainer(Action_Param_2.LoadData(reader, null), typeof(Action_Param_2));
            data.AddLast(Action_Param_2_);
            var W07p_Params_9_Wyrmstake_Blast_Params_ = new MhwStructDataContainer(W07p_Params_9_Wyrmstake_Blast_Params.LoadData(reader, null), typeof(W07p_Params_9_Wyrmstake_Blast_Params));
            data.AddLast(W07p_Params_9_Wyrmstake_Blast_Params_);
            var Action_Param_3_ = new MhwStructDataContainer(Action_Param_3.LoadData(reader, null), typeof(Action_Param_3));
            data.AddLast(Action_Param_3_);
            var W07p_Params_10__ = new MhwStructDataContainer(W07p_Params_10_.LoadData(reader, null), typeof(W07p_Params_10_));
            data.AddLast(W07p_Params_10__);
        }
    }
}
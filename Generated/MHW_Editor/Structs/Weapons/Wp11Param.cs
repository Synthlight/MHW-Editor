using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using MHW_Editor.Assets;
using MHW_Editor.Controls.Models;
using MHW_Editor.Models;
using MHW_Editor.Windows;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Structs.Weapons {
    public partial class Wp11Param {
        public override string EncryptionKey => "j1P15gEkgVa7NdFxiqwCPitykHctY2nZPjSaElvqb0eSwcLO1cOlTqqv";

        public partial class W11p_Params_1_Shared_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W11p Params (1, Shared)";

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

            public const int lastSortIndex = 150;

            public static ObservableMhwStructCollection<W11p_Params_1_Shared_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<W11p_Params_1_Shared_>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W11p_Params_1_Shared_ LoadData(BinaryReader reader, ulong i) {
                var data = new W11p_Params_1_Shared_();
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

        public partial class Unk_Arr_1_Shared_ : MhwStructItem, IWriteData {
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

            public const int lastSortIndex = 300;

            public static ObservableMhwStructCollection<Unk_Arr_1_Shared_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Unk_Arr_1_Shared_>();
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

        public partial class W11p_Params_2_Shared_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W11p Params (2, Shared)";

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

            public const int lastSortIndex = 1350;

            public static ObservableMhwStructCollection<W11p_Params_2_Shared_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<W11p_Params_2_Shared_>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W11p_Params_2_Shared_ LoadData(BinaryReader reader, ulong i) {
                var data = new W11p_Params_2_Shared_();
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

        public partial class Guard_Angles_Shared_ : MhwStructItem, IWriteData {
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

            public const int lastSortIndex = 250;

            public static ObservableMhwStructCollection<Guard_Angles_Shared_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Guard_Angles_Shared_>();
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

        public partial class W11p_Params_3_Shared_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W11p Params (3, Shared)";

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

            public const int lastSortIndex = 2500;

            public static ObservableMhwStructCollection<W11p_Params_3_Shared_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<W11p_Params_3_Shared_>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W11p_Params_3_Shared_ LoadData(BinaryReader reader, ulong i) {
                var data = new W11p_Params_3_Shared_();
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
                };
            }
        }

        public partial class Unk_Arr_2_Shared_ : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 8;
            public const string GridName = "Unk Arr 2 (Shared)";

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

            protected int Unk_2_raw;
            public const string Unk_2_displayName = "Unk 2";
            public const int Unk_2_sortIndex = 100;
            [SortOrder(Unk_2_sortIndex)]
            [DisplayName(Unk_2_displayName)]
            public virtual int Unk_2 {
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

            protected float Unk_14_raw;
            public const string Unk_14_displayName = "Unk 14";
            public const int Unk_14_sortIndex = 700;
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
            public const int Unk_15_sortIndex = 750;
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

            public const int lastSortIndex = 800;

            public static ObservableMhwStructCollection<Unk_Arr_2_Shared_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Unk_Arr_2_Shared_>();
                var count = 8UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Unk_Arr_2_Shared_ LoadData(BinaryReader reader, ulong i) {
                var data = new Unk_Arr_2_Shared_();
                data.Index = i;
                data.Unk_1_raw = reader.ReadByte();
                data.Unk_2_raw = reader.ReadInt32();
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

        public partial class W11p_Params_4_Shared_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W11p Params (4, Shared)";

            protected byte Unk_77_raw;
            public const string Unk_77_displayName = "Unk 77";
            public const int Unk_77_sortIndex = 50;
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
            public const int Unk_78_sortIndex = 100;
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

            protected float Unk_79_raw;
            public const string Unk_79_displayName = "Unk 79";
            public const int Unk_79_sortIndex = 150;
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
            public const int Unk_80_sortIndex = 200;
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
            public const int Unk_81_sortIndex = 250;
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
            public const int Unk_82_sortIndex = 300;
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
            public const int Unk_83_sortIndex = 350;
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
            public const int Unk_84_sortIndex = 400;
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
            public const int Unk_85_sortIndex = 450;
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
            public const int Unk_86_sortIndex = 500;
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
            public const int Unk_87_sortIndex = 550;
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
            public const int Unk_88_sortIndex = 600;
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
            public const int Unk_89_sortIndex = 650;
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
            public const int Unk_90_sortIndex = 700;
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

            public const int lastSortIndex = 750;

            public static ObservableMhwStructCollection<W11p_Params_4_Shared_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<W11p_Params_4_Shared_>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W11p_Params_4_Shared_ LoadData(BinaryReader reader, ulong i) {
                var data = new W11p_Params_4_Shared_();
                data.Index = i;
                data.Unk_77_raw = reader.ReadByte();
                data.Unk_78_raw = reader.ReadInt32();
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
                writer.Write(Unk_77_raw);
                writer.Write(Unk_78_raw);
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
                    new MultiStructItemCustomView(this, "Unk 77", "Unk_77"),
                    new MultiStructItemCustomView(this, "Unk 78", "Unk_78"),
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

        public partial class Bow_Charge : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 2;
            public const string GridName = "Bow Charge";

            protected float Level_1_raw;
            public const string Level_1_displayName = "Level 1";
            public const int Level_1_sortIndex = 50;
            [SortOrder(Level_1_sortIndex)]
            [DisplayName(Level_1_displayName)]
            public virtual float Level_1 {
                get => Level_1_raw;
                set {
                    if (Level_1_raw == value) return;
                    Level_1_raw = value;
                    OnPropertyChanged(nameof(Level_1));
                }
            }

            protected float Level_2_raw;
            public const string Level_2_displayName = "Level 2";
            public const int Level_2_sortIndex = 100;
            [SortOrder(Level_2_sortIndex)]
            [DisplayName(Level_2_displayName)]
            public virtual float Level_2 {
                get => Level_2_raw;
                set {
                    if (Level_2_raw == value) return;
                    Level_2_raw = value;
                    OnPropertyChanged(nameof(Level_2));
                }
            }

            protected float Level_3_raw;
            public const string Level_3_displayName = "Level 3";
            public const int Level_3_sortIndex = 150;
            [SortOrder(Level_3_sortIndex)]
            [DisplayName(Level_3_displayName)]
            public virtual float Level_3 {
                get => Level_3_raw;
                set {
                    if (Level_3_raw == value) return;
                    Level_3_raw = value;
                    OnPropertyChanged(nameof(Level_3));
                }
            }

            protected float Level_4_raw;
            public const string Level_4_displayName = "Level 4";
            public const int Level_4_sortIndex = 200;
            [SortOrder(Level_4_sortIndex)]
            [DisplayName(Level_4_displayName)]
            public virtual float Level_4 {
                get => Level_4_raw;
                set {
                    if (Level_4_raw == value) return;
                    Level_4_raw = value;
                    OnPropertyChanged(nameof(Level_4));
                }
            }

            public const int lastSortIndex = 250;

            public static ObservableMhwStructCollection<Bow_Charge> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Bow_Charge>();
                var count = 2UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Bow_Charge LoadData(BinaryReader reader, ulong i) {
                var data = new Bow_Charge();
                data.Index = i;
                data.Level_1_raw = reader.ReadSingle();
                data.Level_2_raw = reader.ReadSingle();
                data.Level_3_raw = reader.ReadSingle();
                data.Level_4_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Level_1_raw);
                writer.Write(Level_2_raw);
                writer.Write(Level_3_raw);
                writer.Write(Level_4_raw);
            }
        }

        public partial class Event_Pad_Vib : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 4;
            public const string GridName = "Event Pad Vib";

            protected byte B_raw;
            public const string B_displayName = "B";
            public const int B_sortIndex = 50;
            [SortOrder(B_sortIndex)]
            [DisplayName(B_displayName)]
            public virtual byte B {
                get => B_raw;
                set {
                    if (B_raw == value) return;
                    B_raw = value;
                    OnPropertyChanged(nameof(B));
                }
            }

            protected ushort X_raw;
            public const string X_displayName = "X";
            public const int X_sortIndex = 100;
            [SortOrder(X_sortIndex)]
            [DisplayName(X_displayName)]
            public virtual ushort X {
                get => X_raw;
                set {
                    if (X_raw == value) return;
                    X_raw = value;
                    OnPropertyChanged(nameof(X));
                }
            }

            protected ushort Y_raw;
            public const string Y_displayName = "Y";
            public const int Y_sortIndex = 150;
            [SortOrder(Y_sortIndex)]
            [DisplayName(Y_displayName)]
            public virtual ushort Y {
                get => Y_raw;
                set {
                    if (Y_raw == value) return;
                    Y_raw = value;
                    OnPropertyChanged(nameof(Y));
                }
            }

            protected float Time_raw;
            public const string Time_displayName = "Time";
            public const int Time_sortIndex = 200;
            [SortOrder(Time_sortIndex)]
            [DisplayName(Time_displayName)]
            public virtual float Time {
                get => Time_raw;
                set {
                    if (Time_raw == value) return;
                    Time_raw = value;
                    OnPropertyChanged(nameof(Time));
                }
            }

            protected ushort P_raw;
            public const string P_displayName = "P";
            public const int P_sortIndex = 250;
            [SortOrder(P_sortIndex)]
            [DisplayName(P_displayName)]
            public virtual ushort P {
                get => P_raw;
                set {
                    if (P_raw == value) return;
                    P_raw = value;
                    OnPropertyChanged(nameof(P));
                }
            }

            public const int lastSortIndex = 300;

            public static ObservableMhwStructCollection<Event_Pad_Vib> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Event_Pad_Vib>();
                var count = 4UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Event_Pad_Vib LoadData(BinaryReader reader, ulong i) {
                var data = new Event_Pad_Vib();
                data.Index = i;
                data.B_raw = reader.ReadByte();
                data.X_raw = reader.ReadUInt16();
                data.Y_raw = reader.ReadUInt16();
                data.Time_raw = reader.ReadSingle();
                data.P_raw = reader.ReadUInt16();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(B_raw);
                writer.Write(X_raw);
                writer.Write(Y_raw);
                writer.Write(Time_raw);
                writer.Write(P_raw);
            }
        }

        public partial class W11p_Params_5_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W11p Params (5)";

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

            protected float Dragonpiercer_X1_raw;
            public const string Dragonpiercer_X1_displayName = "Dragonpiercer X1";
            public const int Dragonpiercer_X1_sortIndex = 1100;
            [SortOrder(Dragonpiercer_X1_sortIndex)]
            [DisplayName(Dragonpiercer_X1_displayName)]
            public virtual float Dragonpiercer_X1 {
                get => Dragonpiercer_X1_raw;
                set {
                    if (Dragonpiercer_X1_raw == value) return;
                    Dragonpiercer_X1_raw = value;
                    OnPropertyChanged(nameof(Dragonpiercer_X1));
                }
            }

            protected float Dragonpiercer_Y1_raw;
            public const string Dragonpiercer_Y1_displayName = "Dragonpiercer Y1";
            public const int Dragonpiercer_Y1_sortIndex = 1150;
            [SortOrder(Dragonpiercer_Y1_sortIndex)]
            [DisplayName(Dragonpiercer_Y1_displayName)]
            public virtual float Dragonpiercer_Y1 {
                get => Dragonpiercer_Y1_raw;
                set {
                    if (Dragonpiercer_Y1_raw == value) return;
                    Dragonpiercer_Y1_raw = value;
                    OnPropertyChanged(nameof(Dragonpiercer_Y1));
                }
            }

            protected float Dragonpiercer_X2_raw;
            public const string Dragonpiercer_X2_displayName = "Dragonpiercer X2";
            public const int Dragonpiercer_X2_sortIndex = 1200;
            [SortOrder(Dragonpiercer_X2_sortIndex)]
            [DisplayName(Dragonpiercer_X2_displayName)]
            public virtual float Dragonpiercer_X2 {
                get => Dragonpiercer_X2_raw;
                set {
                    if (Dragonpiercer_X2_raw == value) return;
                    Dragonpiercer_X2_raw = value;
                    OnPropertyChanged(nameof(Dragonpiercer_X2));
                }
            }

            protected float Dragonpiercer_Y2_raw;
            public const string Dragonpiercer_Y2_displayName = "Dragonpiercer Y2";
            public const int Dragonpiercer_Y2_sortIndex = 1250;
            [SortOrder(Dragonpiercer_Y2_sortIndex)]
            [DisplayName(Dragonpiercer_Y2_displayName)]
            public virtual float Dragonpiercer_Y2 {
                get => Dragonpiercer_Y2_raw;
                set {
                    if (Dragonpiercer_Y2_raw == value) return;
                    Dragonpiercer_Y2_raw = value;
                    OnPropertyChanged(nameof(Dragonpiercer_Y2));
                }
            }

            public const int lastSortIndex = 1300;

            public static ObservableMhwStructCollection<W11p_Params_5_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<W11p_Params_5_>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W11p_Params_5_ LoadData(BinaryReader reader, ulong i) {
                var data = new W11p_Params_5_();
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
                data.Unk_111_raw = reader.ReadSingle();
                data.Dragonpiercer_X1_raw = reader.ReadSingle();
                data.Dragonpiercer_Y1_raw = reader.ReadSingle();
                data.Dragonpiercer_X2_raw = reader.ReadSingle();
                data.Dragonpiercer_Y2_raw = reader.ReadSingle();
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
                writer.Write(Dragonpiercer_X1_raw);
                writer.Write(Dragonpiercer_Y1_raw);
                writer.Write(Dragonpiercer_X2_raw);
                writer.Write(Dragonpiercer_Y2_raw);
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
                    new MultiStructItemCustomView(this, "Dragonpiercer X1", "Dragonpiercer_X1"),
                    new MultiStructItemCustomView(this, "Dragonpiercer Y1", "Dragonpiercer_Y1"),
                    new MultiStructItemCustomView(this, "Dragonpiercer X2", "Dragonpiercer_X2"),
                    new MultiStructItemCustomView(this, "Dragonpiercer Y2", "Dragonpiercer_Y2"),
                };
            }
        }

        public partial class Arrows_Shot : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 3;
            public const string GridName = "Arrows Shot";

            protected uint Level_1_raw;
            public const string Level_1_displayName = "Level 1";
            public const int Level_1_sortIndex = 50;
            [SortOrder(Level_1_sortIndex)]
            [DisplayName(Level_1_displayName)]
            public virtual uint Level_1 {
                get => Level_1_raw;
                set {
                    if (Level_1_raw == value) return;
                    Level_1_raw = value;
                    OnPropertyChanged(nameof(Level_1));
                }
            }

            protected uint Level_2_raw;
            public const string Level_2_displayName = "Level 2";
            public const int Level_2_sortIndex = 100;
            [SortOrder(Level_2_sortIndex)]
            [DisplayName(Level_2_displayName)]
            public virtual uint Level_2 {
                get => Level_2_raw;
                set {
                    if (Level_2_raw == value) return;
                    Level_2_raw = value;
                    OnPropertyChanged(nameof(Level_2));
                }
            }

            protected uint Level_3_raw;
            public const string Level_3_displayName = "Level 3";
            public const int Level_3_sortIndex = 150;
            [SortOrder(Level_3_sortIndex)]
            [DisplayName(Level_3_displayName)]
            public virtual uint Level_3 {
                get => Level_3_raw;
                set {
                    if (Level_3_raw == value) return;
                    Level_3_raw = value;
                    OnPropertyChanged(nameof(Level_3));
                }
            }

            protected uint Level_4_raw;
            public const string Level_4_displayName = "Level 4";
            public const int Level_4_sortIndex = 200;
            [SortOrder(Level_4_sortIndex)]
            [DisplayName(Level_4_displayName)]
            public virtual uint Level_4 {
                get => Level_4_raw;
                set {
                    if (Level_4_raw == value) return;
                    Level_4_raw = value;
                    OnPropertyChanged(nameof(Level_4));
                }
            }

            public const int lastSortIndex = 250;

            public static ObservableMhwStructCollection<Arrows_Shot> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Arrows_Shot>();
                var count = 3UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Arrows_Shot LoadData(BinaryReader reader, ulong i) {
                var data = new Arrows_Shot();
                data.Index = i;
                data.Level_1_raw = reader.ReadUInt32();
                data.Level_2_raw = reader.ReadUInt32();
                data.Level_3_raw = reader.ReadUInt32();
                data.Level_4_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Level_1_raw);
                writer.Write(Level_2_raw);
                writer.Write(Level_3_raw);
                writer.Write(Level_4_raw);
            }
        }

        public partial class Unk_Arr_5 : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 12;
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

            protected float Unk_14_raw;
            public const string Unk_14_displayName = "Unk 14";
            public const int Unk_14_sortIndex = 700;
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

            public const int lastSortIndex = 750;

            public static ObservableMhwStructCollection<Unk_Arr_5> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Unk_Arr_5>();
                var count = 12UL;
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
            }
        }

        public partial class Action_Param_1 : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 2;
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

            protected float Speed_Rate_raw;
            public const string Speed_Rate_displayName = "Speed Rate";
            public const int Speed_Rate_sortIndex = 100;
            [SortOrder(Speed_Rate_sortIndex)]
            [DisplayName(Speed_Rate_displayName)]
            public virtual float Speed_Rate {
                get => Speed_Rate_raw;
                set {
                    if (Speed_Rate_raw == value) return;
                    Speed_Rate_raw = value;
                    OnPropertyChanged(nameof(Speed_Rate));
                }
            }

            protected float X_Offset_raw;
            public const string X_Offset_displayName = "X Offset";
            public const int X_Offset_sortIndex = 150;
            [SortOrder(X_Offset_sortIndex)]
            [DisplayName(X_Offset_displayName)]
            public virtual float X_Offset {
                get => X_Offset_raw;
                set {
                    if (X_Offset_raw == value) return;
                    X_Offset_raw = value;
                    OnPropertyChanged(nameof(X_Offset));
                }
            }

            protected float Y_Offset_raw;
            public const string Y_Offset_displayName = "Y Offset";
            public const int Y_Offset_sortIndex = 200;
            [SortOrder(Y_Offset_sortIndex)]
            [DisplayName(Y_Offset_displayName)]
            public virtual float Y_Offset {
                get => Y_Offset_raw;
                set {
                    if (Y_Offset_raw == value) return;
                    Y_Offset_raw = value;
                    OnPropertyChanged(nameof(Y_Offset));
                }
            }

            protected float Z_Offset_raw;
            public const string Z_Offset_displayName = "Z Offset";
            public const int Z_Offset_sortIndex = 250;
            [SortOrder(Z_Offset_sortIndex)]
            [DisplayName(Z_Offset_displayName)]
            public virtual float Z_Offset {
                get => Z_Offset_raw;
                set {
                    if (Z_Offset_raw == value) return;
                    Z_Offset_raw = value;
                    OnPropertyChanged(nameof(Z_Offset));
                }
            }

            public const int lastSortIndex = 300;

            public static ObservableMhwStructCollection<Action_Param_1> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Action_Param_1>();
                var count = 2UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Action_Param_1 LoadData(BinaryReader reader, ulong i) {
                var data = new Action_Param_1();
                data.Index = i;
                data.Gravity_raw = reader.ReadSingle();
                data.Speed_Rate_raw = reader.ReadSingle();
                data.X_Offset_raw = reader.ReadSingle();
                data.Y_Offset_raw = reader.ReadSingle();
                data.Z_Offset_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Gravity_raw);
                writer.Write(Speed_Rate_raw);
                writer.Write(X_Offset_raw);
                writer.Write(Y_Offset_raw);
                writer.Write(Z_Offset_raw);
            }
        }

        public partial class W11p_Params_6_Bow_Coating_Params : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W11p Params (6) - Bow Coating Params";

            protected sbyte Level_Charge_per_Shot_Dash_Normal_Shot_raw;
            public const string Level_Charge_per_Shot_Dash_Normal_Shot_displayName = "Level Charge per Shot/Dash: Normal Shot";
            public const int Level_Charge_per_Shot_Dash_Normal_Shot_sortIndex = 50;
            [SortOrder(Level_Charge_per_Shot_Dash_Normal_Shot_sortIndex)]
            [DisplayName(Level_Charge_per_Shot_Dash_Normal_Shot_displayName)]
            public virtual sbyte Level_Charge_per_Shot_Dash_Normal_Shot {
                get => Level_Charge_per_Shot_Dash_Normal_Shot_raw;
                set {
                    if (Level_Charge_per_Shot_Dash_Normal_Shot_raw == value) return;
                    Level_Charge_per_Shot_Dash_Normal_Shot_raw = value;
                    OnPropertyChanged(nameof(Level_Charge_per_Shot_Dash_Normal_Shot));
                }
            }

            protected sbyte Level_Charge_per_Shot_Dash_Quick_Shot_raw;
            public const string Level_Charge_per_Shot_Dash_Quick_Shot_displayName = "Level Charge per Shot/Dash: Quick Shot";
            public const int Level_Charge_per_Shot_Dash_Quick_Shot_sortIndex = 100;
            [SortOrder(Level_Charge_per_Shot_Dash_Quick_Shot_sortIndex)]
            [DisplayName(Level_Charge_per_Shot_Dash_Quick_Shot_displayName)]
            public virtual sbyte Level_Charge_per_Shot_Dash_Quick_Shot {
                get => Level_Charge_per_Shot_Dash_Quick_Shot_raw;
                set {
                    if (Level_Charge_per_Shot_Dash_Quick_Shot_raw == value) return;
                    Level_Charge_per_Shot_Dash_Quick_Shot_raw = value;
                    OnPropertyChanged(nameof(Level_Charge_per_Shot_Dash_Quick_Shot));
                }
            }

            protected sbyte Level_Charge_per_Shot_Dash_Power_Shot_raw;
            public const string Level_Charge_per_Shot_Dash_Power_Shot_displayName = "Level Charge per Shot/Dash: Power Shot";
            public const int Level_Charge_per_Shot_Dash_Power_Shot_sortIndex = 150;
            [SortOrder(Level_Charge_per_Shot_Dash_Power_Shot_sortIndex)]
            [DisplayName(Level_Charge_per_Shot_Dash_Power_Shot_displayName)]
            public virtual sbyte Level_Charge_per_Shot_Dash_Power_Shot {
                get => Level_Charge_per_Shot_Dash_Power_Shot_raw;
                set {
                    if (Level_Charge_per_Shot_Dash_Power_Shot_raw == value) return;
                    Level_Charge_per_Shot_Dash_Power_Shot_raw = value;
                    OnPropertyChanged(nameof(Level_Charge_per_Shot_Dash_Power_Shot));
                }
            }

            protected sbyte Level_Charge_per_Shot_Dash_Arc_Shot_raw;
            public const string Level_Charge_per_Shot_Dash_Arc_Shot_displayName = "Level Charge per Shot/Dash: Arc Shot";
            public const int Level_Charge_per_Shot_Dash_Arc_Shot_sortIndex = 200;
            [SortOrder(Level_Charge_per_Shot_Dash_Arc_Shot_sortIndex)]
            [DisplayName(Level_Charge_per_Shot_Dash_Arc_Shot_displayName)]
            public virtual sbyte Level_Charge_per_Shot_Dash_Arc_Shot {
                get => Level_Charge_per_Shot_Dash_Arc_Shot_raw;
                set {
                    if (Level_Charge_per_Shot_Dash_Arc_Shot_raw == value) return;
                    Level_Charge_per_Shot_Dash_Arc_Shot_raw = value;
                    OnPropertyChanged(nameof(Level_Charge_per_Shot_Dash_Arc_Shot));
                }
            }

            protected sbyte Level_Charge_per_Shot_Dash_Unk_1_raw;
            public const string Level_Charge_per_Shot_Dash_Unk_1_displayName = "Level Charge per Shot/Dash: Unk 1";
            public const int Level_Charge_per_Shot_Dash_Unk_1_sortIndex = 250;
            [SortOrder(Level_Charge_per_Shot_Dash_Unk_1_sortIndex)]
            [DisplayName(Level_Charge_per_Shot_Dash_Unk_1_displayName)]
            public virtual sbyte Level_Charge_per_Shot_Dash_Unk_1 {
                get => Level_Charge_per_Shot_Dash_Unk_1_raw;
                set {
                    if (Level_Charge_per_Shot_Dash_Unk_1_raw == value) return;
                    Level_Charge_per_Shot_Dash_Unk_1_raw = value;
                    OnPropertyChanged(nameof(Level_Charge_per_Shot_Dash_Unk_1));
                }
            }

            protected sbyte Level_Charge_per_Shot_Dash_Side_Step_raw;
            public const string Level_Charge_per_Shot_Dash_Side_Step_displayName = "Level Charge per Shot/Dash: Side Step";
            public const int Level_Charge_per_Shot_Dash_Side_Step_sortIndex = 300;
            [SortOrder(Level_Charge_per_Shot_Dash_Side_Step_sortIndex)]
            [DisplayName(Level_Charge_per_Shot_Dash_Side_Step_displayName)]
            public virtual sbyte Level_Charge_per_Shot_Dash_Side_Step {
                get => Level_Charge_per_Shot_Dash_Side_Step_raw;
                set {
                    if (Level_Charge_per_Shot_Dash_Side_Step_raw == value) return;
                    Level_Charge_per_Shot_Dash_Side_Step_raw = value;
                    OnPropertyChanged(nameof(Level_Charge_per_Shot_Dash_Side_Step));
                }
            }

            protected sbyte Level_Charge_per_Shot_Dash_Unk_2_raw;
            public const string Level_Charge_per_Shot_Dash_Unk_2_displayName = "Level Charge per Shot/Dash: Unk 2";
            public const int Level_Charge_per_Shot_Dash_Unk_2_sortIndex = 350;
            [SortOrder(Level_Charge_per_Shot_Dash_Unk_2_sortIndex)]
            [DisplayName(Level_Charge_per_Shot_Dash_Unk_2_displayName)]
            public virtual sbyte Level_Charge_per_Shot_Dash_Unk_2 {
                get => Level_Charge_per_Shot_Dash_Unk_2_raw;
                set {
                    if (Level_Charge_per_Shot_Dash_Unk_2_raw == value) return;
                    Level_Charge_per_Shot_Dash_Unk_2_raw = value;
                    OnPropertyChanged(nameof(Level_Charge_per_Shot_Dash_Unk_2));
                }
            }

            protected float Close_Range_Coating_Critical_End_Multiplier_raw;
            public const string Close_Range_Coating_Critical_End_Multiplier_displayName = "Close Range Coating Critical End Multiplier";
            public const int Close_Range_Coating_Critical_End_Multiplier_sortIndex = 400;
            [SortOrder(Close_Range_Coating_Critical_End_Multiplier_sortIndex)]
            [DisplayName(Close_Range_Coating_Critical_End_Multiplier_displayName)]
            public virtual float Close_Range_Coating_Critical_End_Multiplier {
                get => Close_Range_Coating_Critical_End_Multiplier_raw;
                set {
                    if (Close_Range_Coating_Critical_End_Multiplier_raw == value) return;
                    Close_Range_Coating_Critical_End_Multiplier_raw = value;
                    OnPropertyChanged(nameof(Close_Range_Coating_Critical_End_Multiplier));
                }
            }

            protected float Close_Range_Coating_Critical_Start_Multiplier_raw;
            public const string Close_Range_Coating_Critical_Start_Multiplier_displayName = "Close Range Coating Critical Start Multiplier";
            public const int Close_Range_Coating_Critical_Start_Multiplier_sortIndex = 450;
            [SortOrder(Close_Range_Coating_Critical_Start_Multiplier_sortIndex)]
            [DisplayName(Close_Range_Coating_Critical_Start_Multiplier_displayName)]
            public virtual float Close_Range_Coating_Critical_Start_Multiplier {
                get => Close_Range_Coating_Critical_Start_Multiplier_raw;
                set {
                    if (Close_Range_Coating_Critical_Start_Multiplier_raw == value) return;
                    Close_Range_Coating_Critical_Start_Multiplier_raw = value;
                    OnPropertyChanged(nameof(Close_Range_Coating_Critical_Start_Multiplier));
                }
            }

            protected float Unk_121_raw;
            public const string Unk_121_displayName = "Unk 121";
            public const int Unk_121_sortIndex = 500;
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

            protected float Close_Range_Coating_Damage_raw;
            public const string Close_Range_Coating_Damage_displayName = "Close Range Coating Damage";
            public const int Close_Range_Coating_Damage_sortIndex = 550;
            [SortOrder(Close_Range_Coating_Damage_sortIndex)]
            [DisplayName(Close_Range_Coating_Damage_displayName)]
            public virtual float Close_Range_Coating_Damage {
                get => Close_Range_Coating_Damage_raw;
                set {
                    if (Close_Range_Coating_Damage_raw == value) return;
                    Close_Range_Coating_Damage_raw = value;
                    OnPropertyChanged(nameof(Close_Range_Coating_Damage));
                }
            }

            protected float Unk_123_raw;
            public const string Unk_123_displayName = "Unk 123";
            public const int Unk_123_sortIndex = 600;
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
            public const int Unk_124_sortIndex = 650;
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

            protected float Power_Coating_Damage_raw;
            public const string Power_Coating_Damage_displayName = "Power Coating Damage";
            public const int Power_Coating_Damage_sortIndex = 700;
            [SortOrder(Power_Coating_Damage_sortIndex)]
            [DisplayName(Power_Coating_Damage_displayName)]
            public virtual float Power_Coating_Damage {
                get => Power_Coating_Damage_raw;
                set {
                    if (Power_Coating_Damage_raw == value) return;
                    Power_Coating_Damage_raw = value;
                    OnPropertyChanged(nameof(Power_Coating_Damage));
                }
            }

            protected float Unk_126_raw;
            public const string Unk_126_displayName = "Unk 126";
            public const int Unk_126_sortIndex = 750;
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

            protected short Paralysis_Coating_Damage_raw;
            public const string Paralysis_Coating_Damage_displayName = "Paralysis Coating Damage";
            public const int Paralysis_Coating_Damage_sortIndex = 800;
            [SortOrder(Paralysis_Coating_Damage_sortIndex)]
            [DisplayName(Paralysis_Coating_Damage_displayName)]
            public virtual short Paralysis_Coating_Damage {
                get => Paralysis_Coating_Damage_raw;
                set {
                    if (Paralysis_Coating_Damage_raw == value) return;
                    Paralysis_Coating_Damage_raw = value;
                    OnPropertyChanged(nameof(Paralysis_Coating_Damage));
                }
            }

            protected short Paralysis_CoatingPlus_Damage_raw;
            public const string Paralysis_CoatingPlus_Damage_displayName = "Paralysis Coating+ Damage";
            public const int Paralysis_CoatingPlus_Damage_sortIndex = 850;
            [SortOrder(Paralysis_CoatingPlus_Damage_sortIndex)]
            [DisplayName(Paralysis_CoatingPlus_Damage_displayName)]
            public virtual short Paralysis_CoatingPlus_Damage {
                get => Paralysis_CoatingPlus_Damage_raw;
                set {
                    if (Paralysis_CoatingPlus_Damage_raw == value) return;
                    Paralysis_CoatingPlus_Damage_raw = value;
                    OnPropertyChanged(nameof(Paralysis_CoatingPlus_Damage));
                }
            }

            protected short Poison_Coating_Damage_raw;
            public const string Poison_Coating_Damage_displayName = "Poison Coating Damage";
            public const int Poison_Coating_Damage_sortIndex = 900;
            [SortOrder(Poison_Coating_Damage_sortIndex)]
            [DisplayName(Poison_Coating_Damage_displayName)]
            public virtual short Poison_Coating_Damage {
                get => Poison_Coating_Damage_raw;
                set {
                    if (Poison_Coating_Damage_raw == value) return;
                    Poison_Coating_Damage_raw = value;
                    OnPropertyChanged(nameof(Poison_Coating_Damage));
                }
            }

            protected short Poison_CoatingPlus_Damage_raw;
            public const string Poison_CoatingPlus_Damage_displayName = "Poison Coating+ Damage";
            public const int Poison_CoatingPlus_Damage_sortIndex = 950;
            [SortOrder(Poison_CoatingPlus_Damage_sortIndex)]
            [DisplayName(Poison_CoatingPlus_Damage_displayName)]
            public virtual short Poison_CoatingPlus_Damage {
                get => Poison_CoatingPlus_Damage_raw;
                set {
                    if (Poison_CoatingPlus_Damage_raw == value) return;
                    Poison_CoatingPlus_Damage_raw = value;
                    OnPropertyChanged(nameof(Poison_CoatingPlus_Damage));
                }
            }

            protected short Sleep_Coating_Damage_raw;
            public const string Sleep_Coating_Damage_displayName = "Sleep Coating Damage";
            public const int Sleep_Coating_Damage_sortIndex = 1000;
            [SortOrder(Sleep_Coating_Damage_sortIndex)]
            [DisplayName(Sleep_Coating_Damage_displayName)]
            public virtual short Sleep_Coating_Damage {
                get => Sleep_Coating_Damage_raw;
                set {
                    if (Sleep_Coating_Damage_raw == value) return;
                    Sleep_Coating_Damage_raw = value;
                    OnPropertyChanged(nameof(Sleep_Coating_Damage));
                }
            }

            protected short Sleep_CoatingPlus_Damage_raw;
            public const string Sleep_CoatingPlus_Damage_displayName = "Sleep Coating+ Damage";
            public const int Sleep_CoatingPlus_Damage_sortIndex = 1050;
            [SortOrder(Sleep_CoatingPlus_Damage_sortIndex)]
            [DisplayName(Sleep_CoatingPlus_Damage_displayName)]
            public virtual short Sleep_CoatingPlus_Damage {
                get => Sleep_CoatingPlus_Damage_raw;
                set {
                    if (Sleep_CoatingPlus_Damage_raw == value) return;
                    Sleep_CoatingPlus_Damage_raw = value;
                    OnPropertyChanged(nameof(Sleep_CoatingPlus_Damage));
                }
            }

            protected short Blast_Coating_Damage_raw;
            public const string Blast_Coating_Damage_displayName = "Blast Coating Damage";
            public const int Blast_Coating_Damage_sortIndex = 1100;
            [SortOrder(Blast_Coating_Damage_sortIndex)]
            [DisplayName(Blast_Coating_Damage_displayName)]
            public virtual short Blast_Coating_Damage {
                get => Blast_Coating_Damage_raw;
                set {
                    if (Blast_Coating_Damage_raw == value) return;
                    Blast_Coating_Damage_raw = value;
                    OnPropertyChanged(nameof(Blast_Coating_Damage));
                }
            }

            protected short Blast_CoatingPlus_Damage_raw;
            public const string Blast_CoatingPlus_Damage_displayName = "Blast Coating+ Damage";
            public const int Blast_CoatingPlus_Damage_sortIndex = 1150;
            [SortOrder(Blast_CoatingPlus_Damage_sortIndex)]
            [DisplayName(Blast_CoatingPlus_Damage_displayName)]
            public virtual short Blast_CoatingPlus_Damage {
                get => Blast_CoatingPlus_Damage_raw;
                set {
                    if (Blast_CoatingPlus_Damage_raw == value) return;
                    Blast_CoatingPlus_Damage_raw = value;
                    OnPropertyChanged(nameof(Blast_CoatingPlus_Damage));
                }
            }

            protected float Unk_135_raw;
            public const string Unk_135_displayName = "Unk 135";
            public const int Unk_135_sortIndex = 1200;
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

            public const int lastSortIndex = 1250;

            public static ObservableMhwStructCollection<W11p_Params_6_Bow_Coating_Params> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<W11p_Params_6_Bow_Coating_Params>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W11p_Params_6_Bow_Coating_Params LoadData(BinaryReader reader, ulong i) {
                var data = new W11p_Params_6_Bow_Coating_Params();
                data.Index = i;
                data.Level_Charge_per_Shot_Dash_Normal_Shot_raw = reader.ReadSByte();
                data.Level_Charge_per_Shot_Dash_Quick_Shot_raw = reader.ReadSByte();
                data.Level_Charge_per_Shot_Dash_Power_Shot_raw = reader.ReadSByte();
                data.Level_Charge_per_Shot_Dash_Arc_Shot_raw = reader.ReadSByte();
                data.Level_Charge_per_Shot_Dash_Unk_1_raw = reader.ReadSByte();
                data.Level_Charge_per_Shot_Dash_Side_Step_raw = reader.ReadSByte();
                data.Level_Charge_per_Shot_Dash_Unk_2_raw = reader.ReadSByte();
                data.Close_Range_Coating_Critical_End_Multiplier_raw = reader.ReadSingle();
                data.Close_Range_Coating_Critical_Start_Multiplier_raw = reader.ReadSingle();
                data.Unk_121_raw = reader.ReadSingle();
                data.Close_Range_Coating_Damage_raw = reader.ReadSingle();
                data.Unk_123_raw = reader.ReadSingle();
                data.Unk_124_raw = reader.ReadSingle();
                data.Power_Coating_Damage_raw = reader.ReadSingle();
                data.Unk_126_raw = reader.ReadSingle();
                data.Paralysis_Coating_Damage_raw = reader.ReadInt16();
                data.Paralysis_CoatingPlus_Damage_raw = reader.ReadInt16();
                data.Poison_Coating_Damage_raw = reader.ReadInt16();
                data.Poison_CoatingPlus_Damage_raw = reader.ReadInt16();
                data.Sleep_Coating_Damage_raw = reader.ReadInt16();
                data.Sleep_CoatingPlus_Damage_raw = reader.ReadInt16();
                data.Blast_Coating_Damage_raw = reader.ReadInt16();
                data.Blast_CoatingPlus_Damage_raw = reader.ReadInt16();
                data.Unk_135_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Level_Charge_per_Shot_Dash_Normal_Shot_raw);
                writer.Write(Level_Charge_per_Shot_Dash_Quick_Shot_raw);
                writer.Write(Level_Charge_per_Shot_Dash_Power_Shot_raw);
                writer.Write(Level_Charge_per_Shot_Dash_Arc_Shot_raw);
                writer.Write(Level_Charge_per_Shot_Dash_Unk_1_raw);
                writer.Write(Level_Charge_per_Shot_Dash_Side_Step_raw);
                writer.Write(Level_Charge_per_Shot_Dash_Unk_2_raw);
                writer.Write(Close_Range_Coating_Critical_End_Multiplier_raw);
                writer.Write(Close_Range_Coating_Critical_Start_Multiplier_raw);
                writer.Write(Unk_121_raw);
                writer.Write(Close_Range_Coating_Damage_raw);
                writer.Write(Unk_123_raw);
                writer.Write(Unk_124_raw);
                writer.Write(Power_Coating_Damage_raw);
                writer.Write(Unk_126_raw);
                writer.Write(Paralysis_Coating_Damage_raw);
                writer.Write(Paralysis_CoatingPlus_Damage_raw);
                writer.Write(Poison_Coating_Damage_raw);
                writer.Write(Poison_CoatingPlus_Damage_raw);
                writer.Write(Sleep_Coating_Damage_raw);
                writer.Write(Sleep_CoatingPlus_Damage_raw);
                writer.Write(Blast_Coating_Damage_raw);
                writer.Write(Blast_CoatingPlus_Damage_raw);
                writer.Write(Unk_135_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Level Charge per Shot/Dash: Normal Shot", "Level_Charge_per_Shot_Dash_Normal_Shot"),
                    new MultiStructItemCustomView(this, "Level Charge per Shot/Dash: Quick Shot", "Level_Charge_per_Shot_Dash_Quick_Shot"),
                    new MultiStructItemCustomView(this, "Level Charge per Shot/Dash: Power Shot", "Level_Charge_per_Shot_Dash_Power_Shot"),
                    new MultiStructItemCustomView(this, "Level Charge per Shot/Dash: Arc Shot", "Level_Charge_per_Shot_Dash_Arc_Shot"),
                    new MultiStructItemCustomView(this, "Level Charge per Shot/Dash: Unk 1", "Level_Charge_per_Shot_Dash_Unk_1"),
                    new MultiStructItemCustomView(this, "Level Charge per Shot/Dash: Side Step", "Level_Charge_per_Shot_Dash_Side_Step"),
                    new MultiStructItemCustomView(this, "Level Charge per Shot/Dash: Unk 2", "Level_Charge_per_Shot_Dash_Unk_2"),
                    new MultiStructItemCustomView(this, "Close Range Coating Critical End Multiplier", "Close_Range_Coating_Critical_End_Multiplier"),
                    new MultiStructItemCustomView(this, "Close Range Coating Critical Start Multiplier", "Close_Range_Coating_Critical_Start_Multiplier"),
                    new MultiStructItemCustomView(this, "Unk 121", "Unk_121"),
                    new MultiStructItemCustomView(this, "Close Range Coating Damage", "Close_Range_Coating_Damage"),
                    new MultiStructItemCustomView(this, "Unk 123", "Unk_123"),
                    new MultiStructItemCustomView(this, "Unk 124", "Unk_124"),
                    new MultiStructItemCustomView(this, "Power Coating Damage", "Power_Coating_Damage"),
                    new MultiStructItemCustomView(this, "Unk 126", "Unk_126"),
                    new MultiStructItemCustomView(this, "Paralysis Coating Damage", "Paralysis_Coating_Damage"),
                    new MultiStructItemCustomView(this, "Paralysis Coating+ Damage", "Paralysis_CoatingPlus_Damage"),
                    new MultiStructItemCustomView(this, "Poison Coating Damage", "Poison_Coating_Damage"),
                    new MultiStructItemCustomView(this, "Poison Coating+ Damage", "Poison_CoatingPlus_Damage"),
                    new MultiStructItemCustomView(this, "Sleep Coating Damage", "Sleep_Coating_Damage"),
                    new MultiStructItemCustomView(this, "Sleep Coating+ Damage", "Sleep_CoatingPlus_Damage"),
                    new MultiStructItemCustomView(this, "Blast Coating Damage", "Blast_Coating_Damage"),
                    new MultiStructItemCustomView(this, "Blast Coating+ Damage", "Blast_CoatingPlus_Damage"),
                    new MultiStructItemCustomView(this, "Unk 135", "Unk_135"),
                };
            }
        }

        public partial class Action_Param_2 : MhwStructItem, IWriteData {
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

            protected float Speed_Rate_raw;
            public const string Speed_Rate_displayName = "Speed Rate";
            public const int Speed_Rate_sortIndex = 100;
            [SortOrder(Speed_Rate_sortIndex)]
            [DisplayName(Speed_Rate_displayName)]
            public virtual float Speed_Rate {
                get => Speed_Rate_raw;
                set {
                    if (Speed_Rate_raw == value) return;
                    Speed_Rate_raw = value;
                    OnPropertyChanged(nameof(Speed_Rate));
                }
            }

            protected float X_Offset_raw;
            public const string X_Offset_displayName = "X Offset";
            public const int X_Offset_sortIndex = 150;
            [SortOrder(X_Offset_sortIndex)]
            [DisplayName(X_Offset_displayName)]
            public virtual float X_Offset {
                get => X_Offset_raw;
                set {
                    if (X_Offset_raw == value) return;
                    X_Offset_raw = value;
                    OnPropertyChanged(nameof(X_Offset));
                }
            }

            protected float Y_Offset_raw;
            public const string Y_Offset_displayName = "Y Offset";
            public const int Y_Offset_sortIndex = 200;
            [SortOrder(Y_Offset_sortIndex)]
            [DisplayName(Y_Offset_displayName)]
            public virtual float Y_Offset {
                get => Y_Offset_raw;
                set {
                    if (Y_Offset_raw == value) return;
                    Y_Offset_raw = value;
                    OnPropertyChanged(nameof(Y_Offset));
                }
            }

            protected float Z_Offset_raw;
            public const string Z_Offset_displayName = "Z Offset";
            public const int Z_Offset_sortIndex = 250;
            [SortOrder(Z_Offset_sortIndex)]
            [DisplayName(Z_Offset_displayName)]
            public virtual float Z_Offset {
                get => Z_Offset_raw;
                set {
                    if (Z_Offset_raw == value) return;
                    Z_Offset_raw = value;
                    OnPropertyChanged(nameof(Z_Offset));
                }
            }

            public const int lastSortIndex = 300;

            public static ObservableMhwStructCollection<Action_Param_2> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Action_Param_2>();
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
                data.Speed_Rate_raw = reader.ReadSingle();
                data.X_Offset_raw = reader.ReadSingle();
                data.Y_Offset_raw = reader.ReadSingle();
                data.Z_Offset_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Gravity_raw);
                writer.Write(Speed_Rate_raw);
                writer.Write(X_Offset_raw);
                writer.Write(Y_Offset_raw);
                writer.Write(Z_Offset_raw);
            }
        }

        public partial class W11p_Params_7_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W11p Params (7)";

            protected float Unk_136_raw;
            public const string Unk_136_displayName = "Unk 136";
            public const int Unk_136_sortIndex = 50;
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
            public const int Unk_137_sortIndex = 100;
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
            public const int Unk_138_sortIndex = 150;
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

            protected uint Unk_139_raw;
            public const string Unk_139_displayName = "Unk 139";
            public const int Unk_139_sortIndex = 200;
            [SortOrder(Unk_139_sortIndex)]
            [DisplayName(Unk_139_displayName)]
            public virtual uint Unk_139 {
                get => Unk_139_raw;
                set {
                    if (Unk_139_raw == value) return;
                    Unk_139_raw = value;
                    OnPropertyChanged(nameof(Unk_139));
                }
            }

            protected uint Unk_140_raw;
            public const string Unk_140_displayName = "Unk 140";
            public const int Unk_140_sortIndex = 250;
            [SortOrder(Unk_140_sortIndex)]
            [DisplayName(Unk_140_displayName)]
            public virtual uint Unk_140 {
                get => Unk_140_raw;
                set {
                    if (Unk_140_raw == value) return;
                    Unk_140_raw = value;
                    OnPropertyChanged(nameof(Unk_140));
                }
            }

            protected uint Unk_141_raw;
            public const string Unk_141_displayName = "Unk 141";
            public const int Unk_141_sortIndex = 300;
            [SortOrder(Unk_141_sortIndex)]
            [DisplayName(Unk_141_displayName)]
            public virtual uint Unk_141 {
                get => Unk_141_raw;
                set {
                    if (Unk_141_raw == value) return;
                    Unk_141_raw = value;
                    OnPropertyChanged(nameof(Unk_141));
                }
            }

            protected uint Unk_142_raw;
            public const string Unk_142_displayName = "Unk 142";
            public const int Unk_142_sortIndex = 350;
            [SortOrder(Unk_142_sortIndex)]
            [DisplayName(Unk_142_displayName)]
            public virtual uint Unk_142 {
                get => Unk_142_raw;
                set {
                    if (Unk_142_raw == value) return;
                    Unk_142_raw = value;
                    OnPropertyChanged(nameof(Unk_142));
                }
            }

            protected float Unk_143_raw;
            public const string Unk_143_displayName = "Unk 143";
            public const int Unk_143_sortIndex = 400;
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
            public const int Unk_144_sortIndex = 450;
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
            public const int Unk_145_sortIndex = 500;
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
            public const int Unk_146_sortIndex = 550;
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
            public const int Unk_147_sortIndex = 600;
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
            public const int Unk_148_sortIndex = 650;
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
            public const int Unk_149_sortIndex = 700;
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
            public const int Unk_150_sortIndex = 750;
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
            public const int Unk_151_sortIndex = 800;
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
            public const int Unk_152_sortIndex = 850;
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
            public const int Unk_153_sortIndex = 900;
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
            public const int Unk_154_sortIndex = 950;
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
            public const int Unk_155_sortIndex = 1000;
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
            public const int Unk_156_sortIndex = 1050;
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
            public const int Unk_157_sortIndex = 1100;
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
            public const int Unk_158_sortIndex = 1150;
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
            public const int Unk_159_sortIndex = 1200;
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
            public const int Unk_160_sortIndex = 1250;
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
            public const int Unk_161_sortIndex = 1300;
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
            public const int Unk_162_sortIndex = 1350;
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
            public const int Unk_163_sortIndex = 1400;
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
            public const int Unk_164_sortIndex = 1450;
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
            public const int Unk_165_sortIndex = 1500;
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
            public const int Unk_166_sortIndex = 1550;
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
            public const int Unk_167_sortIndex = 1600;
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
            public const int Unk_168_sortIndex = 1650;
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
            public const int Unk_169_sortIndex = 1700;
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
            public const int Unk_170_sortIndex = 1750;
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
            public const int Unk_171_sortIndex = 1800;
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
            public const int Unk_172_sortIndex = 1850;
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
            public const int Unk_173_sortIndex = 1900;
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

            protected float Unk_174_raw;
            public const string Unk_174_displayName = "Unk 174";
            public const int Unk_174_sortIndex = 1950;
            [SortOrder(Unk_174_sortIndex)]
            [DisplayName(Unk_174_displayName)]
            public virtual float Unk_174 {
                get => Unk_174_raw;
                set {
                    if (Unk_174_raw == value) return;
                    Unk_174_raw = value;
                    OnPropertyChanged(nameof(Unk_174));
                }
            }

            protected float Unk_175_raw;
            public const string Unk_175_displayName = "Unk 175";
            public const int Unk_175_sortIndex = 2000;
            [SortOrder(Unk_175_sortIndex)]
            [DisplayName(Unk_175_displayName)]
            public virtual float Unk_175 {
                get => Unk_175_raw;
                set {
                    if (Unk_175_raw == value) return;
                    Unk_175_raw = value;
                    OnPropertyChanged(nameof(Unk_175));
                }
            }

            protected float Unk_176_raw;
            public const string Unk_176_displayName = "Unk 176";
            public const int Unk_176_sortIndex = 2050;
            [SortOrder(Unk_176_sortIndex)]
            [DisplayName(Unk_176_displayName)]
            public virtual float Unk_176 {
                get => Unk_176_raw;
                set {
                    if (Unk_176_raw == value) return;
                    Unk_176_raw = value;
                    OnPropertyChanged(nameof(Unk_176));
                }
            }

            protected float Unk_177_raw;
            public const string Unk_177_displayName = "Unk 177";
            public const int Unk_177_sortIndex = 2100;
            [SortOrder(Unk_177_sortIndex)]
            [DisplayName(Unk_177_displayName)]
            public virtual float Unk_177 {
                get => Unk_177_raw;
                set {
                    if (Unk_177_raw == value) return;
                    Unk_177_raw = value;
                    OnPropertyChanged(nameof(Unk_177));
                }
            }

            protected float Unk_178_raw;
            public const string Unk_178_displayName = "Unk 178";
            public const int Unk_178_sortIndex = 2150;
            [SortOrder(Unk_178_sortIndex)]
            [DisplayName(Unk_178_displayName)]
            public virtual float Unk_178 {
                get => Unk_178_raw;
                set {
                    if (Unk_178_raw == value) return;
                    Unk_178_raw = value;
                    OnPropertyChanged(nameof(Unk_178));
                }
            }

            protected float Unk_179_raw;
            public const string Unk_179_displayName = "Unk 179";
            public const int Unk_179_sortIndex = 2200;
            [SortOrder(Unk_179_sortIndex)]
            [DisplayName(Unk_179_displayName)]
            public virtual float Unk_179 {
                get => Unk_179_raw;
                set {
                    if (Unk_179_raw == value) return;
                    Unk_179_raw = value;
                    OnPropertyChanged(nameof(Unk_179));
                }
            }

            protected float Unk_180_raw;
            public const string Unk_180_displayName = "Unk 180";
            public const int Unk_180_sortIndex = 2250;
            [SortOrder(Unk_180_sortIndex)]
            [DisplayName(Unk_180_displayName)]
            public virtual float Unk_180 {
                get => Unk_180_raw;
                set {
                    if (Unk_180_raw == value) return;
                    Unk_180_raw = value;
                    OnPropertyChanged(nameof(Unk_180));
                }
            }

            protected float Unk_181_raw;
            public const string Unk_181_displayName = "Unk 181";
            public const int Unk_181_sortIndex = 2300;
            [SortOrder(Unk_181_sortIndex)]
            [DisplayName(Unk_181_displayName)]
            public virtual float Unk_181 {
                get => Unk_181_raw;
                set {
                    if (Unk_181_raw == value) return;
                    Unk_181_raw = value;
                    OnPropertyChanged(nameof(Unk_181));
                }
            }

            protected float Unk_182_raw;
            public const string Unk_182_displayName = "Unk 182";
            public const int Unk_182_sortIndex = 2350;
            [SortOrder(Unk_182_sortIndex)]
            [DisplayName(Unk_182_displayName)]
            public virtual float Unk_182 {
                get => Unk_182_raw;
                set {
                    if (Unk_182_raw == value) return;
                    Unk_182_raw = value;
                    OnPropertyChanged(nameof(Unk_182));
                }
            }

            protected float Unk_183_raw;
            public const string Unk_183_displayName = "Unk 183";
            public const int Unk_183_sortIndex = 2400;
            [SortOrder(Unk_183_sortIndex)]
            [DisplayName(Unk_183_displayName)]
            public virtual float Unk_183 {
                get => Unk_183_raw;
                set {
                    if (Unk_183_raw == value) return;
                    Unk_183_raw = value;
                    OnPropertyChanged(nameof(Unk_183));
                }
            }

            protected float Unk_184_raw;
            public const string Unk_184_displayName = "Unk 184";
            public const int Unk_184_sortIndex = 2450;
            [SortOrder(Unk_184_sortIndex)]
            [DisplayName(Unk_184_displayName)]
            public virtual float Unk_184 {
                get => Unk_184_raw;
                set {
                    if (Unk_184_raw == value) return;
                    Unk_184_raw = value;
                    OnPropertyChanged(nameof(Unk_184));
                }
            }

            protected float Unk_185_raw;
            public const string Unk_185_displayName = "Unk 185";
            public const int Unk_185_sortIndex = 2500;
            [SortOrder(Unk_185_sortIndex)]
            [DisplayName(Unk_185_displayName)]
            public virtual float Unk_185 {
                get => Unk_185_raw;
                set {
                    if (Unk_185_raw == value) return;
                    Unk_185_raw = value;
                    OnPropertyChanged(nameof(Unk_185));
                }
            }

            protected float Unk_186_raw;
            public const string Unk_186_displayName = "Unk 186";
            public const int Unk_186_sortIndex = 2550;
            [SortOrder(Unk_186_sortIndex)]
            [DisplayName(Unk_186_displayName)]
            public virtual float Unk_186 {
                get => Unk_186_raw;
                set {
                    if (Unk_186_raw == value) return;
                    Unk_186_raw = value;
                    OnPropertyChanged(nameof(Unk_186));
                }
            }

            protected float Unk_187_raw;
            public const string Unk_187_displayName = "Unk 187";
            public const int Unk_187_sortIndex = 2600;
            [SortOrder(Unk_187_sortIndex)]
            [DisplayName(Unk_187_displayName)]
            public virtual float Unk_187 {
                get => Unk_187_raw;
                set {
                    if (Unk_187_raw == value) return;
                    Unk_187_raw = value;
                    OnPropertyChanged(nameof(Unk_187));
                }
            }

            protected float Unk_188_raw;
            public const string Unk_188_displayName = "Unk 188";
            public const int Unk_188_sortIndex = 2650;
            [SortOrder(Unk_188_sortIndex)]
            [DisplayName(Unk_188_displayName)]
            public virtual float Unk_188 {
                get => Unk_188_raw;
                set {
                    if (Unk_188_raw == value) return;
                    Unk_188_raw = value;
                    OnPropertyChanged(nameof(Unk_188));
                }
            }

            protected float Unk_189_raw;
            public const string Unk_189_displayName = "Unk 189";
            public const int Unk_189_sortIndex = 2700;
            [SortOrder(Unk_189_sortIndex)]
            [DisplayName(Unk_189_displayName)]
            public virtual float Unk_189 {
                get => Unk_189_raw;
                set {
                    if (Unk_189_raw == value) return;
                    Unk_189_raw = value;
                    OnPropertyChanged(nameof(Unk_189));
                }
            }

            protected float Unk_190_raw;
            public const string Unk_190_displayName = "Unk 190";
            public const int Unk_190_sortIndex = 2750;
            [SortOrder(Unk_190_sortIndex)]
            [DisplayName(Unk_190_displayName)]
            public virtual float Unk_190 {
                get => Unk_190_raw;
                set {
                    if (Unk_190_raw == value) return;
                    Unk_190_raw = value;
                    OnPropertyChanged(nameof(Unk_190));
                }
            }

            protected float Unk_191_raw;
            public const string Unk_191_displayName = "Unk 191";
            public const int Unk_191_sortIndex = 2800;
            [SortOrder(Unk_191_sortIndex)]
            [DisplayName(Unk_191_displayName)]
            public virtual float Unk_191 {
                get => Unk_191_raw;
                set {
                    if (Unk_191_raw == value) return;
                    Unk_191_raw = value;
                    OnPropertyChanged(nameof(Unk_191));
                }
            }

            protected float Unk_192_raw;
            public const string Unk_192_displayName = "Unk 192";
            public const int Unk_192_sortIndex = 2850;
            [SortOrder(Unk_192_sortIndex)]
            [DisplayName(Unk_192_displayName)]
            public virtual float Unk_192 {
                get => Unk_192_raw;
                set {
                    if (Unk_192_raw == value) return;
                    Unk_192_raw = value;
                    OnPropertyChanged(nameof(Unk_192));
                }
            }

            protected float Unk_193_raw;
            public const string Unk_193_displayName = "Unk 193";
            public const int Unk_193_sortIndex = 2900;
            [SortOrder(Unk_193_sortIndex)]
            [DisplayName(Unk_193_displayName)]
            public virtual float Unk_193 {
                get => Unk_193_raw;
                set {
                    if (Unk_193_raw == value) return;
                    Unk_193_raw = value;
                    OnPropertyChanged(nameof(Unk_193));
                }
            }

            protected float Unk_194_raw;
            public const string Unk_194_displayName = "Unk 194";
            public const int Unk_194_sortIndex = 2950;
            [SortOrder(Unk_194_sortIndex)]
            [DisplayName(Unk_194_displayName)]
            public virtual float Unk_194 {
                get => Unk_194_raw;
                set {
                    if (Unk_194_raw == value) return;
                    Unk_194_raw = value;
                    OnPropertyChanged(nameof(Unk_194));
                }
            }

            protected float Unk_195_raw;
            public const string Unk_195_displayName = "Unk 195";
            public const int Unk_195_sortIndex = 3000;
            [SortOrder(Unk_195_sortIndex)]
            [DisplayName(Unk_195_displayName)]
            public virtual float Unk_195 {
                get => Unk_195_raw;
                set {
                    if (Unk_195_raw == value) return;
                    Unk_195_raw = value;
                    OnPropertyChanged(nameof(Unk_195));
                }
            }

            protected float Unk_196_raw;
            public const string Unk_196_displayName = "Unk 196";
            public const int Unk_196_sortIndex = 3050;
            [SortOrder(Unk_196_sortIndex)]
            [DisplayName(Unk_196_displayName)]
            public virtual float Unk_196 {
                get => Unk_196_raw;
                set {
                    if (Unk_196_raw == value) return;
                    Unk_196_raw = value;
                    OnPropertyChanged(nameof(Unk_196));
                }
            }

            protected float Unk_197_raw;
            public const string Unk_197_displayName = "Unk 197";
            public const int Unk_197_sortIndex = 3100;
            [SortOrder(Unk_197_sortIndex)]
            [DisplayName(Unk_197_displayName)]
            public virtual float Unk_197 {
                get => Unk_197_raw;
                set {
                    if (Unk_197_raw == value) return;
                    Unk_197_raw = value;
                    OnPropertyChanged(nameof(Unk_197));
                }
            }

            protected float Unk_198_raw;
            public const string Unk_198_displayName = "Unk 198";
            public const int Unk_198_sortIndex = 3150;
            [SortOrder(Unk_198_sortIndex)]
            [DisplayName(Unk_198_displayName)]
            public virtual float Unk_198 {
                get => Unk_198_raw;
                set {
                    if (Unk_198_raw == value) return;
                    Unk_198_raw = value;
                    OnPropertyChanged(nameof(Unk_198));
                }
            }

            public const int lastSortIndex = 3200;

            public static ObservableMhwStructCollection<W11p_Params_7_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<W11p_Params_7_>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W11p_Params_7_ LoadData(BinaryReader reader, ulong i) {
                var data = new W11p_Params_7_();
                data.Index = i;
                data.Unk_136_raw = reader.ReadSingle();
                data.Unk_137_raw = reader.ReadSingle();
                data.Unk_138_raw = reader.ReadSingle();
                data.Unk_139_raw = reader.ReadUInt32();
                data.Unk_140_raw = reader.ReadUInt32();
                data.Unk_141_raw = reader.ReadUInt32();
                data.Unk_142_raw = reader.ReadUInt32();
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
                data.Unk_174_raw = reader.ReadSingle();
                data.Unk_175_raw = reader.ReadSingle();
                data.Unk_176_raw = reader.ReadSingle();
                data.Unk_177_raw = reader.ReadSingle();
                data.Unk_178_raw = reader.ReadSingle();
                data.Unk_179_raw = reader.ReadSingle();
                data.Unk_180_raw = reader.ReadSingle();
                data.Unk_181_raw = reader.ReadSingle();
                data.Unk_182_raw = reader.ReadSingle();
                data.Unk_183_raw = reader.ReadSingle();
                data.Unk_184_raw = reader.ReadSingle();
                data.Unk_185_raw = reader.ReadSingle();
                data.Unk_186_raw = reader.ReadSingle();
                data.Unk_187_raw = reader.ReadSingle();
                data.Unk_188_raw = reader.ReadSingle();
                data.Unk_189_raw = reader.ReadSingle();
                data.Unk_190_raw = reader.ReadSingle();
                data.Unk_191_raw = reader.ReadSingle();
                data.Unk_192_raw = reader.ReadSingle();
                data.Unk_193_raw = reader.ReadSingle();
                data.Unk_194_raw = reader.ReadSingle();
                data.Unk_195_raw = reader.ReadSingle();
                data.Unk_196_raw = reader.ReadSingle();
                data.Unk_197_raw = reader.ReadSingle();
                data.Unk_198_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
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
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
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
                };
            }
        }

        public partial class Action_Param_3 : MhwStructItem, IWriteData {
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

            protected float Speed_Rate_raw;
            public const string Speed_Rate_displayName = "Speed Rate";
            public const int Speed_Rate_sortIndex = 100;
            [SortOrder(Speed_Rate_sortIndex)]
            [DisplayName(Speed_Rate_displayName)]
            public virtual float Speed_Rate {
                get => Speed_Rate_raw;
                set {
                    if (Speed_Rate_raw == value) return;
                    Speed_Rate_raw = value;
                    OnPropertyChanged(nameof(Speed_Rate));
                }
            }

            protected float X_Offset_raw;
            public const string X_Offset_displayName = "X Offset";
            public const int X_Offset_sortIndex = 150;
            [SortOrder(X_Offset_sortIndex)]
            [DisplayName(X_Offset_displayName)]
            public virtual float X_Offset {
                get => X_Offset_raw;
                set {
                    if (X_Offset_raw == value) return;
                    X_Offset_raw = value;
                    OnPropertyChanged(nameof(X_Offset));
                }
            }

            protected float Y_Offset_raw;
            public const string Y_Offset_displayName = "Y Offset";
            public const int Y_Offset_sortIndex = 200;
            [SortOrder(Y_Offset_sortIndex)]
            [DisplayName(Y_Offset_displayName)]
            public virtual float Y_Offset {
                get => Y_Offset_raw;
                set {
                    if (Y_Offset_raw == value) return;
                    Y_Offset_raw = value;
                    OnPropertyChanged(nameof(Y_Offset));
                }
            }

            protected float Z_Offset_raw;
            public const string Z_Offset_displayName = "Z Offset";
            public const int Z_Offset_sortIndex = 250;
            [SortOrder(Z_Offset_sortIndex)]
            [DisplayName(Z_Offset_displayName)]
            public virtual float Z_Offset {
                get => Z_Offset_raw;
                set {
                    if (Z_Offset_raw == value) return;
                    Z_Offset_raw = value;
                    OnPropertyChanged(nameof(Z_Offset));
                }
            }

            public const int lastSortIndex = 300;

            public static ObservableMhwStructCollection<Action_Param_3> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Action_Param_3>();
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
                data.Speed_Rate_raw = reader.ReadSingle();
                data.X_Offset_raw = reader.ReadSingle();
                data.Y_Offset_raw = reader.ReadSingle();
                data.Z_Offset_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Gravity_raw);
                writer.Write(Speed_Rate_raw);
                writer.Write(X_Offset_raw);
                writer.Write(Y_Offset_raw);
                writer.Write(Z_Offset_raw);
            }
        }

        public partial class W11p_Params_8_Thousand_Dragons : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W11p Params (8) - Thousand Dragons";

            protected float Critical_Range_End_Multiplier__raw;
            public const string Critical_Range_End_Multiplier__displayName = "Critical Range End Multiplier?";
            public const int Critical_Range_End_Multiplier__sortIndex = 50;
            [SortOrder(Critical_Range_End_Multiplier__sortIndex)]
            [DisplayName(Critical_Range_End_Multiplier__displayName)]
            public virtual float Critical_Range_End_Multiplier_ {
                get => Critical_Range_End_Multiplier__raw;
                set {
                    if (Critical_Range_End_Multiplier__raw == value) return;
                    Critical_Range_End_Multiplier__raw = value;
                    OnPropertyChanged(nameof(Critical_Range_End_Multiplier_));
                }
            }

            protected float Critical_Range_Start_Multiplier__raw;
            public const string Critical_Range_Start_Multiplier__displayName = "Critical Range Start Multiplier?";
            public const int Critical_Range_Start_Multiplier__sortIndex = 100;
            [SortOrder(Critical_Range_Start_Multiplier__sortIndex)]
            [DisplayName(Critical_Range_Start_Multiplier__displayName)]
            public virtual float Critical_Range_Start_Multiplier_ {
                get => Critical_Range_Start_Multiplier__raw;
                set {
                    if (Critical_Range_Start_Multiplier__raw == value) return;
                    Critical_Range_Start_Multiplier__raw = value;
                    OnPropertyChanged(nameof(Critical_Range_Start_Multiplier_));
                }
            }

            protected byte Unk_201_raw;
            public const string Unk_201_displayName = "Unk 201";
            public const int Unk_201_sortIndex = 150;
            [SortOrder(Unk_201_sortIndex)]
            [DisplayName(Unk_201_displayName)]
            public virtual byte Unk_201 {
                get => Unk_201_raw;
                set {
                    if (Unk_201_raw == value) return;
                    Unk_201_raw = value;
                    OnPropertyChanged(nameof(Unk_201));
                }
            }

            protected float Main_Arrow_Spread_Angle__raw;
            public const string Main_Arrow_Spread_Angle__displayName = "Main Arrow Spread Angle?";
            public const int Main_Arrow_Spread_Angle__sortIndex = 200;
            [SortOrder(Main_Arrow_Spread_Angle__sortIndex)]
            [DisplayName(Main_Arrow_Spread_Angle__displayName)]
            public virtual float Main_Arrow_Spread_Angle_ {
                get => Main_Arrow_Spread_Angle__raw;
                set {
                    if (Main_Arrow_Spread_Angle__raw == value) return;
                    Main_Arrow_Spread_Angle__raw = value;
                    OnPropertyChanged(nameof(Main_Arrow_Spread_Angle_));
                }
            }

            protected uint Number_of_Arrows_Shot_raw;
            public const string Number_of_Arrows_Shot_displayName = "Number of Arrows Shot";
            public const int Number_of_Arrows_Shot_sortIndex = 250;
            [SortOrder(Number_of_Arrows_Shot_sortIndex)]
            [DisplayName(Number_of_Arrows_Shot_displayName)]
            public virtual uint Number_of_Arrows_Shot {
                get => Number_of_Arrows_Shot_raw;
                set {
                    if (Number_of_Arrows_Shot_raw == value) return;
                    Number_of_Arrows_Shot_raw = value;
                    OnPropertyChanged(nameof(Number_of_Arrows_Shot));
                }
            }

            public const int lastSortIndex = 300;

            public static ObservableMhwStructCollection<W11p_Params_8_Thousand_Dragons> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<W11p_Params_8_Thousand_Dragons>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W11p_Params_8_Thousand_Dragons LoadData(BinaryReader reader, ulong i) {
                var data = new W11p_Params_8_Thousand_Dragons();
                data.Index = i;
                data.Critical_Range_End_Multiplier__raw = reader.ReadSingle();
                data.Critical_Range_Start_Multiplier__raw = reader.ReadSingle();
                data.Unk_201_raw = reader.ReadByte();
                data.Main_Arrow_Spread_Angle__raw = reader.ReadSingle();
                data.Number_of_Arrows_Shot_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Critical_Range_End_Multiplier__raw);
                writer.Write(Critical_Range_Start_Multiplier__raw);
                writer.Write(Unk_201_raw);
                writer.Write(Main_Arrow_Spread_Angle__raw);
                writer.Write(Number_of_Arrows_Shot_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Critical Range End Multiplier?", "Critical_Range_End_Multiplier_"),
                    new MultiStructItemCustomView(this, "Critical Range Start Multiplier?", "Critical_Range_Start_Multiplier_"),
                    new MultiStructItemCustomView(this, "Unk 201", "Unk_201"),
                    new MultiStructItemCustomView(this, "Main Arrow Spread Angle?", "Main_Arrow_Spread_Angle_"),
                    new MultiStructItemCustomView(this, "Number of Arrows Shot", "Number_of_Arrows_Shot"),
                };
            }
        }

        public partial class Unk_Arr_6 : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 7;
            public const string GridName = "Unk Arr 6";

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

            protected byte Unk_2_raw;
            public const string Unk_2_displayName = "Unk 2";
            public const int Unk_2_sortIndex = 100;
            [SortOrder(Unk_2_sortIndex)]
            [DisplayName(Unk_2_displayName)]
            public virtual byte Unk_2 {
                get => Unk_2_raw;
                set {
                    if (Unk_2_raw == value) return;
                    Unk_2_raw = value;
                    OnPropertyChanged(nameof(Unk_2));
                }
            }

            protected byte Unk_3_raw;
            public const string Unk_3_displayName = "Unk 3";
            public const int Unk_3_sortIndex = 150;
            [SortOrder(Unk_3_sortIndex)]
            [DisplayName(Unk_3_displayName)]
            public virtual byte Unk_3 {
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
            public virtual byte Unk_4 {
                get => Unk_4_raw;
                set {
                    if (Unk_4_raw == value) return;
                    Unk_4_raw = value;
                    OnPropertyChanged(nameof(Unk_4));
                }
            }

            protected uint Unk_5_raw;
            public const string Unk_5_displayName = "Unk 5";
            public const int Unk_5_sortIndex = 250;
            [SortOrder(Unk_5_sortIndex)]
            [DisplayName(Unk_5_displayName)]
            public virtual uint Unk_5 {
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

            public const int lastSortIndex = 400;

            public static ObservableMhwStructCollection<Unk_Arr_6> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Unk_Arr_6>();
                var count = 7UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Unk_Arr_6 LoadData(BinaryReader reader, ulong i) {
                var data = new Unk_Arr_6();
                data.Index = i;
                data.Unk_1_raw = reader.ReadByte();
                data.Unk_2_raw = reader.ReadByte();
                data.Unk_3_raw = reader.ReadByte();
                data.Unk_4_raw = reader.ReadByte();
                data.Unk_5_raw = reader.ReadUInt32();
                data.Unk_6_raw = reader.ReadSingle();
                data.Unk_7_raw = reader.ReadSingle();
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
            }
        }

        public partial class W11p_Params_9_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W11p Params (9)";

            protected float Thousand_Dragons_X1_raw;
            public const string Thousand_Dragons_X1_displayName = "Thousand Dragons X1";
            public const int Thousand_Dragons_X1_sortIndex = 50;
            [SortOrder(Thousand_Dragons_X1_sortIndex)]
            [DisplayName(Thousand_Dragons_X1_displayName)]
            public virtual float Thousand_Dragons_X1 {
                get => Thousand_Dragons_X1_raw;
                set {
                    if (Thousand_Dragons_X1_raw == value) return;
                    Thousand_Dragons_X1_raw = value;
                    OnPropertyChanged(nameof(Thousand_Dragons_X1));
                }
            }

            protected float Thousand_Dragons_Y1_raw;
            public const string Thousand_Dragons_Y1_displayName = "Thousand Dragons Y1";
            public const int Thousand_Dragons_Y1_sortIndex = 100;
            [SortOrder(Thousand_Dragons_Y1_sortIndex)]
            [DisplayName(Thousand_Dragons_Y1_displayName)]
            public virtual float Thousand_Dragons_Y1 {
                get => Thousand_Dragons_Y1_raw;
                set {
                    if (Thousand_Dragons_Y1_raw == value) return;
                    Thousand_Dragons_Y1_raw = value;
                    OnPropertyChanged(nameof(Thousand_Dragons_Y1));
                }
            }

            protected float Thousand_Dragons_X2_raw;
            public const string Thousand_Dragons_X2_displayName = "Thousand Dragons X2";
            public const int Thousand_Dragons_X2_sortIndex = 150;
            [SortOrder(Thousand_Dragons_X2_sortIndex)]
            [DisplayName(Thousand_Dragons_X2_displayName)]
            public virtual float Thousand_Dragons_X2 {
                get => Thousand_Dragons_X2_raw;
                set {
                    if (Thousand_Dragons_X2_raw == value) return;
                    Thousand_Dragons_X2_raw = value;
                    OnPropertyChanged(nameof(Thousand_Dragons_X2));
                }
            }

            protected float Thousand_Dragons_Y2_raw;
            public const string Thousand_Dragons_Y2_displayName = "Thousand Dragons Y2";
            public const int Thousand_Dragons_Y2_sortIndex = 200;
            [SortOrder(Thousand_Dragons_Y2_sortIndex)]
            [DisplayName(Thousand_Dragons_Y2_displayName)]
            public virtual float Thousand_Dragons_Y2 {
                get => Thousand_Dragons_Y2_raw;
                set {
                    if (Thousand_Dragons_Y2_raw == value) return;
                    Thousand_Dragons_Y2_raw = value;
                    OnPropertyChanged(nameof(Thousand_Dragons_Y2));
                }
            }

            protected float For_Every_Stone_Attack_raw;
            public const string For_Every_Stone_Attack_displayName = "For Every Stone Attack";
            public const int For_Every_Stone_Attack_sortIndex = 250;
            [SortOrder(For_Every_Stone_Attack_sortIndex)]
            [DisplayName(For_Every_Stone_Attack_displayName)]
            public virtual float For_Every_Stone_Attack {
                get => For_Every_Stone_Attack_raw;
                set {
                    if (For_Every_Stone_Attack_raw == value) return;
                    For_Every_Stone_Attack_raw = value;
                    OnPropertyChanged(nameof(For_Every_Stone_Attack));
                }
            }

            protected float For_Every_Stone_Exhaust_raw;
            public const string For_Every_Stone_Exhaust_displayName = "For Every Stone Exhaust";
            public const int For_Every_Stone_Exhaust_sortIndex = 300;
            [SortOrder(For_Every_Stone_Exhaust_sortIndex)]
            [DisplayName(For_Every_Stone_Exhaust_displayName)]
            public virtual float For_Every_Stone_Exhaust {
                get => For_Every_Stone_Exhaust_raw;
                set {
                    if (For_Every_Stone_Exhaust_raw == value) return;
                    For_Every_Stone_Exhaust_raw = value;
                    OnPropertyChanged(nameof(For_Every_Stone_Exhaust));
                }
            }

            protected float For_Every_Stone_Stun_raw;
            public const string For_Every_Stone_Stun_displayName = "For Every Stone Stun";
            public const int For_Every_Stone_Stun_sortIndex = 350;
            [SortOrder(For_Every_Stone_Stun_sortIndex)]
            [DisplayName(For_Every_Stone_Stun_displayName)]
            public virtual float For_Every_Stone_Stun {
                get => For_Every_Stone_Stun_raw;
                set {
                    if (For_Every_Stone_Stun_raw == value) return;
                    For_Every_Stone_Stun_raw = value;
                    OnPropertyChanged(nameof(For_Every_Stone_Stun));
                }
            }

            protected uint For_Every_Stone_Attack_Type_raw;
            public const string For_Every_Stone_Attack_Type_displayName = "For Every Stone Attack Type";
            public const int For_Every_Stone_Attack_Type_sortIndex = 400;
            [SortOrder(For_Every_Stone_Attack_Type_sortIndex)]
            [DisplayName(For_Every_Stone_Attack_Type_displayName)]
            public virtual uint For_Every_Stone_Attack_Type {
                get => For_Every_Stone_Attack_Type_raw;
                set {
                    if (For_Every_Stone_Attack_Type_raw == value) return;
                    For_Every_Stone_Attack_Type_raw = value;
                    OnPropertyChanged(nameof(For_Every_Stone_Attack_Type));
                }
            }

            protected float For_Every_Redpit_Attack_raw;
            public const string For_Every_Redpit_Attack_displayName = "For Every Redpit Attack";
            public const int For_Every_Redpit_Attack_sortIndex = 450;
            [SortOrder(For_Every_Redpit_Attack_sortIndex)]
            [DisplayName(For_Every_Redpit_Attack_displayName)]
            public virtual float For_Every_Redpit_Attack {
                get => For_Every_Redpit_Attack_raw;
                set {
                    if (For_Every_Redpit_Attack_raw == value) return;
                    For_Every_Redpit_Attack_raw = value;
                    OnPropertyChanged(nameof(For_Every_Redpit_Attack));
                }
            }

            protected float For_Every_Redpit_Exhaust_raw;
            public const string For_Every_Redpit_Exhaust_displayName = "For Every Redpit Exhaust";
            public const int For_Every_Redpit_Exhaust_sortIndex = 500;
            [SortOrder(For_Every_Redpit_Exhaust_sortIndex)]
            [DisplayName(For_Every_Redpit_Exhaust_displayName)]
            public virtual float For_Every_Redpit_Exhaust {
                get => For_Every_Redpit_Exhaust_raw;
                set {
                    if (For_Every_Redpit_Exhaust_raw == value) return;
                    For_Every_Redpit_Exhaust_raw = value;
                    OnPropertyChanged(nameof(For_Every_Redpit_Exhaust));
                }
            }

            protected float For_Every_Redpit_Stun_raw;
            public const string For_Every_Redpit_Stun_displayName = "For Every Redpit Stun";
            public const int For_Every_Redpit_Stun_sortIndex = 550;
            [SortOrder(For_Every_Redpit_Stun_sortIndex)]
            [DisplayName(For_Every_Redpit_Stun_displayName)]
            public virtual float For_Every_Redpit_Stun {
                get => For_Every_Redpit_Stun_raw;
                set {
                    if (For_Every_Redpit_Stun_raw == value) return;
                    For_Every_Redpit_Stun_raw = value;
                    OnPropertyChanged(nameof(For_Every_Redpit_Stun));
                }
            }

            protected uint For_Every_Redpit_Attack_Type_raw;
            public const string For_Every_Redpit_Attack_Type_displayName = "For Every Redpit Attack Type";
            public const int For_Every_Redpit_Attack_Type_sortIndex = 600;
            [SortOrder(For_Every_Redpit_Attack_Type_sortIndex)]
            [DisplayName(For_Every_Redpit_Attack_Type_displayName)]
            public virtual uint For_Every_Redpit_Attack_Type {
                get => For_Every_Redpit_Attack_Type_raw;
                set {
                    if (For_Every_Redpit_Attack_Type_raw == value) return;
                    For_Every_Redpit_Attack_Type_raw = value;
                    OnPropertyChanged(nameof(For_Every_Redpit_Attack_Type));
                }
            }

            protected float For_Every_Brightmoss_Attack_raw;
            public const string For_Every_Brightmoss_Attack_displayName = "For Every Brightmoss Attack";
            public const int For_Every_Brightmoss_Attack_sortIndex = 650;
            [SortOrder(For_Every_Brightmoss_Attack_sortIndex)]
            [DisplayName(For_Every_Brightmoss_Attack_displayName)]
            public virtual float For_Every_Brightmoss_Attack {
                get => For_Every_Brightmoss_Attack_raw;
                set {
                    if (For_Every_Brightmoss_Attack_raw == value) return;
                    For_Every_Brightmoss_Attack_raw = value;
                    OnPropertyChanged(nameof(For_Every_Brightmoss_Attack));
                }
            }

            protected float For_Every_Brightmoss_Element_raw;
            public const string For_Every_Brightmoss_Element_displayName = "For Every Brightmoss Element";
            public const int For_Every_Brightmoss_Element_sortIndex = 700;
            [SortOrder(For_Every_Brightmoss_Element_sortIndex)]
            [DisplayName(For_Every_Brightmoss_Element_displayName)]
            public virtual float For_Every_Brightmoss_Element {
                get => For_Every_Brightmoss_Element_raw;
                set {
                    if (For_Every_Brightmoss_Element_raw == value) return;
                    For_Every_Brightmoss_Element_raw = value;
                    OnPropertyChanged(nameof(For_Every_Brightmoss_Element));
                }
            }

            protected uint For_Every_Brightmoss_Attack_Type_raw;
            public const string For_Every_Brightmoss_Attack_Type_displayName = "For Every Brightmoss Attack Type";
            public const int For_Every_Brightmoss_Attack_Type_sortIndex = 750;
            [SortOrder(For_Every_Brightmoss_Attack_Type_sortIndex)]
            [DisplayName(For_Every_Brightmoss_Attack_Type_displayName)]
            public virtual uint For_Every_Brightmoss_Attack_Type {
                get => For_Every_Brightmoss_Attack_Type_raw;
                set {
                    if (For_Every_Brightmoss_Attack_Type_raw == value) return;
                    For_Every_Brightmoss_Attack_Type_raw = value;
                    OnPropertyChanged(nameof(For_Every_Brightmoss_Attack_Type));
                }
            }

            protected float For_Every_Scatternut_Crystalburst_Attack_raw;
            public const string For_Every_Scatternut_Crystalburst_Attack_displayName = "For Every Scatternut/Crystalburst Attack";
            public const int For_Every_Scatternut_Crystalburst_Attack_sortIndex = 800;
            [SortOrder(For_Every_Scatternut_Crystalburst_Attack_sortIndex)]
            [DisplayName(For_Every_Scatternut_Crystalburst_Attack_displayName)]
            public virtual float For_Every_Scatternut_Crystalburst_Attack {
                get => For_Every_Scatternut_Crystalburst_Attack_raw;
                set {
                    if (For_Every_Scatternut_Crystalburst_Attack_raw == value) return;
                    For_Every_Scatternut_Crystalburst_Attack_raw = value;
                    OnPropertyChanged(nameof(For_Every_Scatternut_Crystalburst_Attack));
                }
            }

            protected float For_Every_Scatternut_Crystalburst__raw;
            public const string For_Every_Scatternut_Crystalburst__displayName = "For Every Scatternut/Crystalburst?";
            public const int For_Every_Scatternut_Crystalburst__sortIndex = 850;
            [SortOrder(For_Every_Scatternut_Crystalburst__sortIndex)]
            [DisplayName(For_Every_Scatternut_Crystalburst__displayName)]
            public virtual float For_Every_Scatternut_Crystalburst_ {
                get => For_Every_Scatternut_Crystalburst__raw;
                set {
                    if (For_Every_Scatternut_Crystalburst__raw == value) return;
                    For_Every_Scatternut_Crystalburst__raw = value;
                    OnPropertyChanged(nameof(For_Every_Scatternut_Crystalburst_));
                }
            }

            protected float For_Every_Scatternut_Crystalburst_Exhaust_raw;
            public const string For_Every_Scatternut_Crystalburst_Exhaust_displayName = "For Every Scatternut/Crystalburst Exhaust";
            public const int For_Every_Scatternut_Crystalburst_Exhaust_sortIndex = 900;
            [SortOrder(For_Every_Scatternut_Crystalburst_Exhaust_sortIndex)]
            [DisplayName(For_Every_Scatternut_Crystalburst_Exhaust_displayName)]
            public virtual float For_Every_Scatternut_Crystalburst_Exhaust {
                get => For_Every_Scatternut_Crystalburst_Exhaust_raw;
                set {
                    if (For_Every_Scatternut_Crystalburst_Exhaust_raw == value) return;
                    For_Every_Scatternut_Crystalburst_Exhaust_raw = value;
                    OnPropertyChanged(nameof(For_Every_Scatternut_Crystalburst_Exhaust));
                }
            }

            protected uint For_Every_Scatternut_Crystalburst_Attack_Type_raw;
            public const string For_Every_Scatternut_Crystalburst_Attack_Type_displayName = "For Every Scatternut/Crystalburst Attack Type";
            public const int For_Every_Scatternut_Crystalburst_Attack_Type_sortIndex = 950;
            [SortOrder(For_Every_Scatternut_Crystalburst_Attack_Type_sortIndex)]
            [DisplayName(For_Every_Scatternut_Crystalburst_Attack_Type_displayName)]
            public virtual uint For_Every_Scatternut_Crystalburst_Attack_Type {
                get => For_Every_Scatternut_Crystalburst_Attack_Type_raw;
                set {
                    if (For_Every_Scatternut_Crystalburst_Attack_Type_raw == value) return;
                    For_Every_Scatternut_Crystalburst_Attack_Type_raw = value;
                    OnPropertyChanged(nameof(For_Every_Scatternut_Crystalburst_Attack_Type));
                }
            }

            protected float For_Every_Torch_Pod_Attack_raw;
            public const string For_Every_Torch_Pod_Attack_displayName = "For Every Torch Pod Attack";
            public const int For_Every_Torch_Pod_Attack_sortIndex = 1000;
            [SortOrder(For_Every_Torch_Pod_Attack_sortIndex)]
            [DisplayName(For_Every_Torch_Pod_Attack_displayName)]
            public virtual float For_Every_Torch_Pod_Attack {
                get => For_Every_Torch_Pod_Attack_raw;
                set {
                    if (For_Every_Torch_Pod_Attack_raw == value) return;
                    For_Every_Torch_Pod_Attack_raw = value;
                    OnPropertyChanged(nameof(For_Every_Torch_Pod_Attack));
                }
            }

            protected float For_Every_Torch_Pod_Element_raw;
            public const string For_Every_Torch_Pod_Element_displayName = "For Every Torch Pod Element";
            public const int For_Every_Torch_Pod_Element_sortIndex = 1050;
            [SortOrder(For_Every_Torch_Pod_Element_sortIndex)]
            [DisplayName(For_Every_Torch_Pod_Element_displayName)]
            public virtual float For_Every_Torch_Pod_Element {
                get => For_Every_Torch_Pod_Element_raw;
                set {
                    if (For_Every_Torch_Pod_Element_raw == value) return;
                    For_Every_Torch_Pod_Element_raw = value;
                    OnPropertyChanged(nameof(For_Every_Torch_Pod_Element));
                }
            }

            protected uint For_Every_Torch_Pod_Attack_Type_raw;
            public const string For_Every_Torch_Pod_Attack_Type_displayName = "For Every Torch Pod Attack Type";
            public const int For_Every_Torch_Pod_Attack_Type_sortIndex = 1100;
            [SortOrder(For_Every_Torch_Pod_Attack_Type_sortIndex)]
            [DisplayName(For_Every_Torch_Pod_Attack_Type_displayName)]
            public virtual uint For_Every_Torch_Pod_Attack_Type {
                get => For_Every_Torch_Pod_Attack_Type_raw;
                set {
                    if (For_Every_Torch_Pod_Attack_Type_raw == value) return;
                    For_Every_Torch_Pod_Attack_Type_raw = value;
                    OnPropertyChanged(nameof(For_Every_Torch_Pod_Attack_Type));
                }
            }

            protected float For_Every_Bomb_Pod_Attack_raw;
            public const string For_Every_Bomb_Pod_Attack_displayName = "For Every Bomb Pod Attack";
            public const int For_Every_Bomb_Pod_Attack_sortIndex = 1150;
            [SortOrder(For_Every_Bomb_Pod_Attack_sortIndex)]
            [DisplayName(For_Every_Bomb_Pod_Attack_displayName)]
            public virtual float For_Every_Bomb_Pod_Attack {
                get => For_Every_Bomb_Pod_Attack_raw;
                set {
                    if (For_Every_Bomb_Pod_Attack_raw == value) return;
                    For_Every_Bomb_Pod_Attack_raw = value;
                    OnPropertyChanged(nameof(For_Every_Bomb_Pod_Attack));
                }
            }

            protected float For_Every_Bomb_Pod_Element_raw;
            public const string For_Every_Bomb_Pod_Element_displayName = "For Every Bomb Pod Element";
            public const int For_Every_Bomb_Pod_Element_sortIndex = 1200;
            [SortOrder(For_Every_Bomb_Pod_Element_sortIndex)]
            [DisplayName(For_Every_Bomb_Pod_Element_displayName)]
            public virtual float For_Every_Bomb_Pod_Element {
                get => For_Every_Bomb_Pod_Element_raw;
                set {
                    if (For_Every_Bomb_Pod_Element_raw == value) return;
                    For_Every_Bomb_Pod_Element_raw = value;
                    OnPropertyChanged(nameof(For_Every_Bomb_Pod_Element));
                }
            }

            protected float For_Every_Bomb_Pod_1__raw;
            public const string For_Every_Bomb_Pod_1__displayName = "For Every Bomb Pod 1?";
            public const int For_Every_Bomb_Pod_1__sortIndex = 1250;
            [SortOrder(For_Every_Bomb_Pod_1__sortIndex)]
            [DisplayName(For_Every_Bomb_Pod_1__displayName)]
            public virtual float For_Every_Bomb_Pod_1_ {
                get => For_Every_Bomb_Pod_1__raw;
                set {
                    if (For_Every_Bomb_Pod_1__raw == value) return;
                    For_Every_Bomb_Pod_1__raw = value;
                    OnPropertyChanged(nameof(For_Every_Bomb_Pod_1_));
                }
            }

            protected float For_Every_Bomb_Pod_2__raw;
            public const string For_Every_Bomb_Pod_2__displayName = "For Every Bomb Pod 2?";
            public const int For_Every_Bomb_Pod_2__sortIndex = 1300;
            [SortOrder(For_Every_Bomb_Pod_2__sortIndex)]
            [DisplayName(For_Every_Bomb_Pod_2__displayName)]
            public virtual float For_Every_Bomb_Pod_2_ {
                get => For_Every_Bomb_Pod_2__raw;
                set {
                    if (For_Every_Bomb_Pod_2__raw == value) return;
                    For_Every_Bomb_Pod_2__raw = value;
                    OnPropertyChanged(nameof(For_Every_Bomb_Pod_2_));
                }
            }

            protected uint For_Every_Bomb_Pod_Attack_Type_raw;
            public const string For_Every_Bomb_Pod_Attack_Type_displayName = "For Every Bomb Pod Attack Type";
            public const int For_Every_Bomb_Pod_Attack_Type_sortIndex = 1350;
            [SortOrder(For_Every_Bomb_Pod_Attack_Type_sortIndex)]
            [DisplayName(For_Every_Bomb_Pod_Attack_Type_displayName)]
            public virtual uint For_Every_Bomb_Pod_Attack_Type {
                get => For_Every_Bomb_Pod_Attack_Type_raw;
                set {
                    if (For_Every_Bomb_Pod_Attack_Type_raw == value) return;
                    For_Every_Bomb_Pod_Attack_Type_raw = value;
                    OnPropertyChanged(nameof(For_Every_Bomb_Pod_Attack_Type));
                }
            }

            protected float For_Every_Piercing_Pod_Attack_raw;
            public const string For_Every_Piercing_Pod_Attack_displayName = "For Every Piercing Pod Attack";
            public const int For_Every_Piercing_Pod_Attack_sortIndex = 1400;
            [SortOrder(For_Every_Piercing_Pod_Attack_sortIndex)]
            [DisplayName(For_Every_Piercing_Pod_Attack_displayName)]
            public virtual float For_Every_Piercing_Pod_Attack {
                get => For_Every_Piercing_Pod_Attack_raw;
                set {
                    if (For_Every_Piercing_Pod_Attack_raw == value) return;
                    For_Every_Piercing_Pod_Attack_raw = value;
                    OnPropertyChanged(nameof(For_Every_Piercing_Pod_Attack));
                }
            }

            protected uint For_Every_Piercing_Pod_Attack_Type_raw;
            public const string For_Every_Piercing_Pod_Attack_Type_displayName = "For Every Piercing Pod Attack Type";
            public const int For_Every_Piercing_Pod_Attack_Type_sortIndex = 1450;
            [SortOrder(For_Every_Piercing_Pod_Attack_Type_sortIndex)]
            [DisplayName(For_Every_Piercing_Pod_Attack_Type_displayName)]
            public virtual uint For_Every_Piercing_Pod_Attack_Type {
                get => For_Every_Piercing_Pod_Attack_Type_raw;
                set {
                    if (For_Every_Piercing_Pod_Attack_Type_raw == value) return;
                    For_Every_Piercing_Pod_Attack_Type_raw = value;
                    OnPropertyChanged(nameof(For_Every_Piercing_Pod_Attack_Type));
                }
            }

            protected float For_Every_Thorn_Pod_Attack_raw;
            public const string For_Every_Thorn_Pod_Attack_displayName = "For Every Thorn Pod Attack";
            public const int For_Every_Thorn_Pod_Attack_sortIndex = 1500;
            [SortOrder(For_Every_Thorn_Pod_Attack_sortIndex)]
            [DisplayName(For_Every_Thorn_Pod_Attack_displayName)]
            public virtual float For_Every_Thorn_Pod_Attack {
                get => For_Every_Thorn_Pod_Attack_raw;
                set {
                    if (For_Every_Thorn_Pod_Attack_raw == value) return;
                    For_Every_Thorn_Pod_Attack_raw = value;
                    OnPropertyChanged(nameof(For_Every_Thorn_Pod_Attack));
                }
            }

            protected float For_Every_Thorn_Pod_Exhaust_raw;
            public const string For_Every_Thorn_Pod_Exhaust_displayName = "For Every Thorn Pod Exhaust";
            public const int For_Every_Thorn_Pod_Exhaust_sortIndex = 1550;
            [SortOrder(For_Every_Thorn_Pod_Exhaust_sortIndex)]
            [DisplayName(For_Every_Thorn_Pod_Exhaust_displayName)]
            public virtual float For_Every_Thorn_Pod_Exhaust {
                get => For_Every_Thorn_Pod_Exhaust_raw;
                set {
                    if (For_Every_Thorn_Pod_Exhaust_raw == value) return;
                    For_Every_Thorn_Pod_Exhaust_raw = value;
                    OnPropertyChanged(nameof(For_Every_Thorn_Pod_Exhaust));
                }
            }

            protected float For_Every_Thorn_Pod_Stun_raw;
            public const string For_Every_Thorn_Pod_Stun_displayName = "For Every Thorn Pod Stun";
            public const int For_Every_Thorn_Pod_Stun_sortIndex = 1600;
            [SortOrder(For_Every_Thorn_Pod_Stun_sortIndex)]
            [DisplayName(For_Every_Thorn_Pod_Stun_displayName)]
            public virtual float For_Every_Thorn_Pod_Stun {
                get => For_Every_Thorn_Pod_Stun_raw;
                set {
                    if (For_Every_Thorn_Pod_Stun_raw == value) return;
                    For_Every_Thorn_Pod_Stun_raw = value;
                    OnPropertyChanged(nameof(For_Every_Thorn_Pod_Stun));
                }
            }

            protected uint For_Every_Thorn_Pod_Attack_Type_raw;
            public const string For_Every_Thorn_Pod_Attack_Type_displayName = "For Every Thorn Pod Attack Type";
            public const int For_Every_Thorn_Pod_Attack_Type_sortIndex = 1650;
            [SortOrder(For_Every_Thorn_Pod_Attack_Type_sortIndex)]
            [DisplayName(For_Every_Thorn_Pod_Attack_Type_displayName)]
            public virtual uint For_Every_Thorn_Pod_Attack_Type {
                get => For_Every_Thorn_Pod_Attack_Type_raw;
                set {
                    if (For_Every_Thorn_Pod_Attack_Type_raw == value) return;
                    For_Every_Thorn_Pod_Attack_Type_raw = value;
                    OnPropertyChanged(nameof(For_Every_Thorn_Pod_Attack_Type));
                }
            }

            protected float For_Every_Dragon_Pod_Attack_raw;
            public const string For_Every_Dragon_Pod_Attack_displayName = "For Every Dragon Pod Attack";
            public const int For_Every_Dragon_Pod_Attack_sortIndex = 1700;
            [SortOrder(For_Every_Dragon_Pod_Attack_sortIndex)]
            [DisplayName(For_Every_Dragon_Pod_Attack_displayName)]
            public virtual float For_Every_Dragon_Pod_Attack {
                get => For_Every_Dragon_Pod_Attack_raw;
                set {
                    if (For_Every_Dragon_Pod_Attack_raw == value) return;
                    For_Every_Dragon_Pod_Attack_raw = value;
                    OnPropertyChanged(nameof(For_Every_Dragon_Pod_Attack));
                }
            }

            protected float For_Every_Dragon_Pod_Element_raw;
            public const string For_Every_Dragon_Pod_Element_displayName = "For Every Dragon Pod Element";
            public const int For_Every_Dragon_Pod_Element_sortIndex = 1750;
            [SortOrder(For_Every_Dragon_Pod_Element_sortIndex)]
            [DisplayName(For_Every_Dragon_Pod_Element_displayName)]
            public virtual float For_Every_Dragon_Pod_Element {
                get => For_Every_Dragon_Pod_Element_raw;
                set {
                    if (For_Every_Dragon_Pod_Element_raw == value) return;
                    For_Every_Dragon_Pod_Element_raw = value;
                    OnPropertyChanged(nameof(For_Every_Dragon_Pod_Element));
                }
            }

            protected uint For_Every_Dragon_Pod_Attack_Type_raw;
            public const string For_Every_Dragon_Pod_Attack_Type_displayName = "For Every Dragon Pod Attack Type";
            public const int For_Every_Dragon_Pod_Attack_Type_sortIndex = 1800;
            [SortOrder(For_Every_Dragon_Pod_Attack_Type_sortIndex)]
            [DisplayName(For_Every_Dragon_Pod_Attack_Type_displayName)]
            public virtual uint For_Every_Dragon_Pod_Attack_Type {
                get => For_Every_Dragon_Pod_Attack_Type_raw;
                set {
                    if (For_Every_Dragon_Pod_Attack_Type_raw == value) return;
                    For_Every_Dragon_Pod_Attack_Type_raw = value;
                    OnPropertyChanged(nameof(For_Every_Dragon_Pod_Attack_Type));
                }
            }

            protected float For_Every_Puddle_Pod_Attack_raw;
            public const string For_Every_Puddle_Pod_Attack_displayName = "For Every Puddle Pod Attack";
            public const int For_Every_Puddle_Pod_Attack_sortIndex = 1850;
            [SortOrder(For_Every_Puddle_Pod_Attack_sortIndex)]
            [DisplayName(For_Every_Puddle_Pod_Attack_displayName)]
            public virtual float For_Every_Puddle_Pod_Attack {
                get => For_Every_Puddle_Pod_Attack_raw;
                set {
                    if (For_Every_Puddle_Pod_Attack_raw == value) return;
                    For_Every_Puddle_Pod_Attack_raw = value;
                    OnPropertyChanged(nameof(For_Every_Puddle_Pod_Attack));
                }
            }

            protected float For_Every_Puddle_Pod_Element_raw;
            public const string For_Every_Puddle_Pod_Element_displayName = "For Every Puddle Pod Element";
            public const int For_Every_Puddle_Pod_Element_sortIndex = 1900;
            [SortOrder(For_Every_Puddle_Pod_Element_sortIndex)]
            [DisplayName(For_Every_Puddle_Pod_Element_displayName)]
            public virtual float For_Every_Puddle_Pod_Element {
                get => For_Every_Puddle_Pod_Element_raw;
                set {
                    if (For_Every_Puddle_Pod_Element_raw == value) return;
                    For_Every_Puddle_Pod_Element_raw = value;
                    OnPropertyChanged(nameof(For_Every_Puddle_Pod_Element));
                }
            }

            protected uint For_Every_Puddle_Pod_Attack_Type_raw;
            public const string For_Every_Puddle_Pod_Attack_Type_displayName = "For Every Puddle Pod Attack Type";
            public const int For_Every_Puddle_Pod_Attack_Type_sortIndex = 1950;
            [SortOrder(For_Every_Puddle_Pod_Attack_Type_sortIndex)]
            [DisplayName(For_Every_Puddle_Pod_Attack_Type_displayName)]
            public virtual uint For_Every_Puddle_Pod_Attack_Type {
                get => For_Every_Puddle_Pod_Attack_Type_raw;
                set {
                    if (For_Every_Puddle_Pod_Attack_Type_raw == value) return;
                    For_Every_Puddle_Pod_Attack_Type_raw = value;
                    OnPropertyChanged(nameof(For_Every_Puddle_Pod_Attack_Type));
                }
            }

            protected float Unk_239_raw;
            public const string Unk_239_displayName = "Unk 239";
            public const int Unk_239_sortIndex = 2000;
            [SortOrder(Unk_239_sortIndex)]
            [DisplayName(Unk_239_displayName)]
            public virtual float Unk_239 {
                get => Unk_239_raw;
                set {
                    if (Unk_239_raw == value) return;
                    Unk_239_raw = value;
                    OnPropertyChanged(nameof(Unk_239));
                }
            }

            protected float Unk_240_raw;
            public const string Unk_240_displayName = "Unk 240";
            public const int Unk_240_sortIndex = 2050;
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

            public const int lastSortIndex = 2100;

            public static ObservableMhwStructCollection<W11p_Params_9_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<W11p_Params_9_>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W11p_Params_9_ LoadData(BinaryReader reader, ulong i) {
                var data = new W11p_Params_9_();
                data.Index = i;
                data.Thousand_Dragons_X1_raw = reader.ReadSingle();
                data.Thousand_Dragons_Y1_raw = reader.ReadSingle();
                data.Thousand_Dragons_X2_raw = reader.ReadSingle();
                data.Thousand_Dragons_Y2_raw = reader.ReadSingle();
                data.For_Every_Stone_Attack_raw = reader.ReadSingle();
                data.For_Every_Stone_Exhaust_raw = reader.ReadSingle();
                data.For_Every_Stone_Stun_raw = reader.ReadSingle();
                data.For_Every_Stone_Attack_Type_raw = reader.ReadUInt32();
                data.For_Every_Redpit_Attack_raw = reader.ReadSingle();
                data.For_Every_Redpit_Exhaust_raw = reader.ReadSingle();
                data.For_Every_Redpit_Stun_raw = reader.ReadSingle();
                data.For_Every_Redpit_Attack_Type_raw = reader.ReadUInt32();
                data.For_Every_Brightmoss_Attack_raw = reader.ReadSingle();
                data.For_Every_Brightmoss_Element_raw = reader.ReadSingle();
                data.For_Every_Brightmoss_Attack_Type_raw = reader.ReadUInt32();
                data.For_Every_Scatternut_Crystalburst_Attack_raw = reader.ReadSingle();
                data.For_Every_Scatternut_Crystalburst__raw = reader.ReadSingle();
                data.For_Every_Scatternut_Crystalburst_Exhaust_raw = reader.ReadSingle();
                data.For_Every_Scatternut_Crystalburst_Attack_Type_raw = reader.ReadUInt32();
                data.For_Every_Torch_Pod_Attack_raw = reader.ReadSingle();
                data.For_Every_Torch_Pod_Element_raw = reader.ReadSingle();
                data.For_Every_Torch_Pod_Attack_Type_raw = reader.ReadUInt32();
                data.For_Every_Bomb_Pod_Attack_raw = reader.ReadSingle();
                data.For_Every_Bomb_Pod_Element_raw = reader.ReadSingle();
                data.For_Every_Bomb_Pod_1__raw = reader.ReadSingle();
                data.For_Every_Bomb_Pod_2__raw = reader.ReadSingle();
                data.For_Every_Bomb_Pod_Attack_Type_raw = reader.ReadUInt32();
                data.For_Every_Piercing_Pod_Attack_raw = reader.ReadSingle();
                data.For_Every_Piercing_Pod_Attack_Type_raw = reader.ReadUInt32();
                data.For_Every_Thorn_Pod_Attack_raw = reader.ReadSingle();
                data.For_Every_Thorn_Pod_Exhaust_raw = reader.ReadSingle();
                data.For_Every_Thorn_Pod_Stun_raw = reader.ReadSingle();
                data.For_Every_Thorn_Pod_Attack_Type_raw = reader.ReadUInt32();
                data.For_Every_Dragon_Pod_Attack_raw = reader.ReadSingle();
                data.For_Every_Dragon_Pod_Element_raw = reader.ReadSingle();
                data.For_Every_Dragon_Pod_Attack_Type_raw = reader.ReadUInt32();
                data.For_Every_Puddle_Pod_Attack_raw = reader.ReadSingle();
                data.For_Every_Puddle_Pod_Element_raw = reader.ReadSingle();
                data.For_Every_Puddle_Pod_Attack_Type_raw = reader.ReadUInt32();
                data.Unk_239_raw = reader.ReadSingle();
                data.Unk_240_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Thousand_Dragons_X1_raw);
                writer.Write(Thousand_Dragons_Y1_raw);
                writer.Write(Thousand_Dragons_X2_raw);
                writer.Write(Thousand_Dragons_Y2_raw);
                writer.Write(For_Every_Stone_Attack_raw);
                writer.Write(For_Every_Stone_Exhaust_raw);
                writer.Write(For_Every_Stone_Stun_raw);
                writer.Write(For_Every_Stone_Attack_Type_raw);
                writer.Write(For_Every_Redpit_Attack_raw);
                writer.Write(For_Every_Redpit_Exhaust_raw);
                writer.Write(For_Every_Redpit_Stun_raw);
                writer.Write(For_Every_Redpit_Attack_Type_raw);
                writer.Write(For_Every_Brightmoss_Attack_raw);
                writer.Write(For_Every_Brightmoss_Element_raw);
                writer.Write(For_Every_Brightmoss_Attack_Type_raw);
                writer.Write(For_Every_Scatternut_Crystalburst_Attack_raw);
                writer.Write(For_Every_Scatternut_Crystalburst__raw);
                writer.Write(For_Every_Scatternut_Crystalburst_Exhaust_raw);
                writer.Write(For_Every_Scatternut_Crystalburst_Attack_Type_raw);
                writer.Write(For_Every_Torch_Pod_Attack_raw);
                writer.Write(For_Every_Torch_Pod_Element_raw);
                writer.Write(For_Every_Torch_Pod_Attack_Type_raw);
                writer.Write(For_Every_Bomb_Pod_Attack_raw);
                writer.Write(For_Every_Bomb_Pod_Element_raw);
                writer.Write(For_Every_Bomb_Pod_1__raw);
                writer.Write(For_Every_Bomb_Pod_2__raw);
                writer.Write(For_Every_Bomb_Pod_Attack_Type_raw);
                writer.Write(For_Every_Piercing_Pod_Attack_raw);
                writer.Write(For_Every_Piercing_Pod_Attack_Type_raw);
                writer.Write(For_Every_Thorn_Pod_Attack_raw);
                writer.Write(For_Every_Thorn_Pod_Exhaust_raw);
                writer.Write(For_Every_Thorn_Pod_Stun_raw);
                writer.Write(For_Every_Thorn_Pod_Attack_Type_raw);
                writer.Write(For_Every_Dragon_Pod_Attack_raw);
                writer.Write(For_Every_Dragon_Pod_Element_raw);
                writer.Write(For_Every_Dragon_Pod_Attack_Type_raw);
                writer.Write(For_Every_Puddle_Pod_Attack_raw);
                writer.Write(For_Every_Puddle_Pod_Element_raw);
                writer.Write(For_Every_Puddle_Pod_Attack_Type_raw);
                writer.Write(Unk_239_raw);
                writer.Write(Unk_240_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Thousand Dragons X1", "Thousand_Dragons_X1"),
                    new MultiStructItemCustomView(this, "Thousand Dragons Y1", "Thousand_Dragons_Y1"),
                    new MultiStructItemCustomView(this, "Thousand Dragons X2", "Thousand_Dragons_X2"),
                    new MultiStructItemCustomView(this, "Thousand Dragons Y2", "Thousand_Dragons_Y2"),
                    new MultiStructItemCustomView(this, "For Every Stone Attack", "For_Every_Stone_Attack"),
                    new MultiStructItemCustomView(this, "For Every Stone Exhaust", "For_Every_Stone_Exhaust"),
                    new MultiStructItemCustomView(this, "For Every Stone Stun", "For_Every_Stone_Stun"),
                    new MultiStructItemCustomView(this, "For Every Stone Attack Type", "For_Every_Stone_Attack_Type"),
                    new MultiStructItemCustomView(this, "For Every Redpit Attack", "For_Every_Redpit_Attack"),
                    new MultiStructItemCustomView(this, "For Every Redpit Exhaust", "For_Every_Redpit_Exhaust"),
                    new MultiStructItemCustomView(this, "For Every Redpit Stun", "For_Every_Redpit_Stun"),
                    new MultiStructItemCustomView(this, "For Every Redpit Attack Type", "For_Every_Redpit_Attack_Type"),
                    new MultiStructItemCustomView(this, "For Every Brightmoss Attack", "For_Every_Brightmoss_Attack"),
                    new MultiStructItemCustomView(this, "For Every Brightmoss Element", "For_Every_Brightmoss_Element"),
                    new MultiStructItemCustomView(this, "For Every Brightmoss Attack Type", "For_Every_Brightmoss_Attack_Type"),
                    new MultiStructItemCustomView(this, "For Every Scatternut/Crystalburst Attack", "For_Every_Scatternut_Crystalburst_Attack"),
                    new MultiStructItemCustomView(this, "For Every Scatternut/Crystalburst?", "For_Every_Scatternut_Crystalburst_"),
                    new MultiStructItemCustomView(this, "For Every Scatternut/Crystalburst Exhaust", "For_Every_Scatternut_Crystalburst_Exhaust"),
                    new MultiStructItemCustomView(this, "For Every Scatternut/Crystalburst Attack Type", "For_Every_Scatternut_Crystalburst_Attack_Type"),
                    new MultiStructItemCustomView(this, "For Every Torch Pod Attack", "For_Every_Torch_Pod_Attack"),
                    new MultiStructItemCustomView(this, "For Every Torch Pod Element", "For_Every_Torch_Pod_Element"),
                    new MultiStructItemCustomView(this, "For Every Torch Pod Attack Type", "For_Every_Torch_Pod_Attack_Type"),
                    new MultiStructItemCustomView(this, "For Every Bomb Pod Attack", "For_Every_Bomb_Pod_Attack"),
                    new MultiStructItemCustomView(this, "For Every Bomb Pod Element", "For_Every_Bomb_Pod_Element"),
                    new MultiStructItemCustomView(this, "For Every Bomb Pod 1?", "For_Every_Bomb_Pod_1_"),
                    new MultiStructItemCustomView(this, "For Every Bomb Pod 2?", "For_Every_Bomb_Pod_2_"),
                    new MultiStructItemCustomView(this, "For Every Bomb Pod Attack Type", "For_Every_Bomb_Pod_Attack_Type"),
                    new MultiStructItemCustomView(this, "For Every Piercing Pod Attack", "For_Every_Piercing_Pod_Attack"),
                    new MultiStructItemCustomView(this, "For Every Piercing Pod Attack Type", "For_Every_Piercing_Pod_Attack_Type"),
                    new MultiStructItemCustomView(this, "For Every Thorn Pod Attack", "For_Every_Thorn_Pod_Attack"),
                    new MultiStructItemCustomView(this, "For Every Thorn Pod Exhaust", "For_Every_Thorn_Pod_Exhaust"),
                    new MultiStructItemCustomView(this, "For Every Thorn Pod Stun", "For_Every_Thorn_Pod_Stun"),
                    new MultiStructItemCustomView(this, "For Every Thorn Pod Attack Type", "For_Every_Thorn_Pod_Attack_Type"),
                    new MultiStructItemCustomView(this, "For Every Dragon Pod Attack", "For_Every_Dragon_Pod_Attack"),
                    new MultiStructItemCustomView(this, "For Every Dragon Pod Element", "For_Every_Dragon_Pod_Element"),
                    new MultiStructItemCustomView(this, "For Every Dragon Pod Attack Type", "For_Every_Dragon_Pod_Attack_Type"),
                    new MultiStructItemCustomView(this, "For Every Puddle Pod Attack", "For_Every_Puddle_Pod_Attack"),
                    new MultiStructItemCustomView(this, "For Every Puddle Pod Element", "For_Every_Puddle_Pod_Element"),
                    new MultiStructItemCustomView(this, "For Every Puddle Pod Attack Type", "For_Every_Puddle_Pod_Attack_Type"),
                    new MultiStructItemCustomView(this, "Unk 239", "Unk_239"),
                    new MultiStructItemCustomView(this, "Unk 240", "Unk_240"),
                };
            }
        }

        public override void LoadFile(string targetFile) {
            using var reader = new BinaryReader(OpenFile(targetFile, EncryptionKey), Encoding.UTF8);
            data = new LinkedList<MhwStructDataContainer>();
            var W11p_Params_1_Shared__ = new MhwStructDataContainer<W11p_Params_1_Shared_>(W11p_Params_1_Shared_.LoadData(reader), typeof(W11p_Params_1_Shared_));
            data.AddLast(W11p_Params_1_Shared__);
            var Unk_Arr_1_Shared__ = new MhwStructDataContainer<Unk_Arr_1_Shared_>(Unk_Arr_1_Shared_.LoadData(reader), typeof(Unk_Arr_1_Shared_));
            data.AddLast(Unk_Arr_1_Shared__);
            var W11p_Params_2_Shared__ = new MhwStructDataContainer<W11p_Params_2_Shared_>(W11p_Params_2_Shared_.LoadData(reader), typeof(W11p_Params_2_Shared_));
            data.AddLast(W11p_Params_2_Shared__);
            var Guard_Angles_Shared__ = new MhwStructDataContainer<Guard_Angles_Shared_>(Guard_Angles_Shared_.LoadData(reader), typeof(Guard_Angles_Shared_));
            data.AddLast(Guard_Angles_Shared__);
            var W11p_Params_3_Shared__ = new MhwStructDataContainer<W11p_Params_3_Shared_>(W11p_Params_3_Shared_.LoadData(reader), typeof(W11p_Params_3_Shared_));
            data.AddLast(W11p_Params_3_Shared__);
            var Unk_Arr_2_Shared__ = new MhwStructDataContainer<Unk_Arr_2_Shared_>(Unk_Arr_2_Shared_.LoadData(reader), typeof(Unk_Arr_2_Shared_));
            data.AddLast(Unk_Arr_2_Shared__);
            var W11p_Params_4_Shared__ = new MhwStructDataContainer<W11p_Params_4_Shared_>(W11p_Params_4_Shared_.LoadData(reader), typeof(W11p_Params_4_Shared_));
            data.AddLast(W11p_Params_4_Shared__);
            var Bow_Charge_ = new MhwStructDataContainer<Bow_Charge>(Bow_Charge.LoadData(reader), typeof(Bow_Charge));
            data.AddLast(Bow_Charge_);
            var Event_Pad_Vib_ = new MhwStructDataContainer<Event_Pad_Vib>(Event_Pad_Vib.LoadData(reader), typeof(Event_Pad_Vib));
            data.AddLast(Event_Pad_Vib_);
            var W11p_Params_5__ = new MhwStructDataContainer<W11p_Params_5_>(W11p_Params_5_.LoadData(reader), typeof(W11p_Params_5_));
            data.AddLast(W11p_Params_5__);
            var Arrows_Shot_ = new MhwStructDataContainer<Arrows_Shot>(Arrows_Shot.LoadData(reader), typeof(Arrows_Shot));
            data.AddLast(Arrows_Shot_);
            var Unk_Arr_5_ = new MhwStructDataContainer<Unk_Arr_5>(Unk_Arr_5.LoadData(reader), typeof(Unk_Arr_5));
            data.AddLast(Unk_Arr_5_);
            var Action_Param_1_ = new MhwStructDataContainer<Action_Param_1>(Action_Param_1.LoadData(reader), typeof(Action_Param_1));
            data.AddLast(Action_Param_1_);
            var W11p_Params_6_Bow_Coating_Params_ = new MhwStructDataContainer<W11p_Params_6_Bow_Coating_Params>(W11p_Params_6_Bow_Coating_Params.LoadData(reader), typeof(W11p_Params_6_Bow_Coating_Params));
            data.AddLast(W11p_Params_6_Bow_Coating_Params_);
            var Action_Param_2_ = new MhwStructDataContainer<Action_Param_2>(Action_Param_2.LoadData(reader), typeof(Action_Param_2));
            data.AddLast(Action_Param_2_);
            var W11p_Params_7__ = new MhwStructDataContainer<W11p_Params_7_>(W11p_Params_7_.LoadData(reader), typeof(W11p_Params_7_));
            data.AddLast(W11p_Params_7__);
            var Action_Param_3_ = new MhwStructDataContainer<Action_Param_3>(Action_Param_3.LoadData(reader), typeof(Action_Param_3));
            data.AddLast(Action_Param_3_);
            var W11p_Params_8_Thousand_Dragons_ = new MhwStructDataContainer<W11p_Params_8_Thousand_Dragons>(W11p_Params_8_Thousand_Dragons.LoadData(reader), typeof(W11p_Params_8_Thousand_Dragons));
            data.AddLast(W11p_Params_8_Thousand_Dragons_);
            var Unk_Arr_6_ = new MhwStructDataContainer<Unk_Arr_6>(Unk_Arr_6.LoadData(reader), typeof(Unk_Arr_6));
            data.AddLast(Unk_Arr_6_);
            var W11p_Params_9__ = new MhwStructDataContainer<W11p_Params_9_>(W11p_Params_9_.LoadData(reader), typeof(W11p_Params_9_));
            data.AddLast(W11p_Params_9__);
        }
    }
}
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
    public partial class Wp13Param {
        public override string EncryptionKey => "j1P15gEkgVa7NdFxiqwCPitykHctY2nZPjSaElvqb0eSwcLO1cOlTqqv";

        public partial class W13p_Params_1_Shared_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
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
                    ChangedItems.Add(nameof(Weapon));
                    OnPropertyChanged(nameof(Weapon));
                }
            }

            [DisplayName("Offset")]
            public long Weapon_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_1));
                    OnPropertyChanged(nameof(Unk_1));
                }
            }

            [DisplayName("Offset")]
            public long Unk_1_offset { get; private set; }

            public const int lastSortIndex = 150;

            public static ObservableMhwStructCollection<W13p_Params_1_Shared_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<W13p_Params_1_Shared_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W13p_Params_1_Shared_ LoadData(BinaryReader reader, ulong i) {
                var data = new W13p_Params_1_Shared_();
                data.Index = i;
                data.Weapon_offset = reader.BaseStream.Position;
                data.Weapon_raw = reader.ReadChars(4);
                data.Unk_1_offset = reader.BaseStream.Position;
                data.Unk_1_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Weapon_raw);
                writer.Write(Unk_1_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Weapon", "Weapon", "Weapon_offset"),
                    new MultiStructItemCustomView(this, "Unk 1", "Unk_1", "Unk_1_offset"),
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
                    ChangedItems.Add(nameof(Unk_1));
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
                    ChangedItems.Add(nameof(Unk_2));
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
                    ChangedItems.Add(nameof(Unk_3));
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
                    ChangedItems.Add(nameof(Unk_4));
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
                    ChangedItems.Add(nameof(Unk_5));
                    OnPropertyChanged(nameof(Unk_5));
                }
            }

            public const int lastSortIndex = 300;

            public static ObservableMhwStructCollection<Unk_Arr_1_Shared_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Unk_Arr_1_Shared_>();
                const ulong count = 20UL;
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

        public partial class W13p_Params_2_Shared_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
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
                    ChangedItems.Add(nameof(Unk_2));
                    OnPropertyChanged(nameof(Unk_2));
                }
            }

            [DisplayName("Offset")]
            public long Unk_2_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_3));
                    OnPropertyChanged(nameof(Unk_3));
                }
            }

            [DisplayName("Offset")]
            public long Unk_3_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_4));
                    OnPropertyChanged(nameof(Unk_4));
                }
            }

            [DisplayName("Offset")]
            public long Unk_4_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_5));
                    OnPropertyChanged(nameof(Unk_5));
                }
            }

            [DisplayName("Offset")]
            public long Unk_5_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_6));
                    OnPropertyChanged(nameof(Unk_6));
                }
            }

            [DisplayName("Offset")]
            public long Unk_6_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_7));
                    OnPropertyChanged(nameof(Unk_7));
                }
            }

            [DisplayName("Offset")]
            public long Unk_7_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_8));
                    OnPropertyChanged(nameof(Unk_8));
                }
            }

            [DisplayName("Offset")]
            public long Unk_8_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_9));
                    OnPropertyChanged(nameof(Unk_9));
                }
            }

            [DisplayName("Offset")]
            public long Unk_9_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_10));
                    OnPropertyChanged(nameof(Unk_10));
                }
            }

            [DisplayName("Offset")]
            public long Unk_10_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_11));
                    OnPropertyChanged(nameof(Unk_11));
                }
            }

            [DisplayName("Offset")]
            public long Unk_11_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_12));
                    OnPropertyChanged(nameof(Unk_12));
                }
            }

            [DisplayName("Offset")]
            public long Unk_12_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_13));
                    OnPropertyChanged(nameof(Unk_13));
                }
            }

            [DisplayName("Offset")]
            public long Unk_13_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_14));
                    OnPropertyChanged(nameof(Unk_14));
                }
            }

            [DisplayName("Offset")]
            public long Unk_14_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_15));
                    OnPropertyChanged(nameof(Unk_15));
                }
            }

            [DisplayName("Offset")]
            public long Unk_15_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_16));
                    OnPropertyChanged(nameof(Unk_16));
                }
            }

            [DisplayName("Offset")]
            public long Unk_16_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_17));
                    OnPropertyChanged(nameof(Unk_17));
                }
            }

            [DisplayName("Offset")]
            public long Unk_17_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Sharpness_Consumed_Melee_Only_));
                    OnPropertyChanged(nameof(Sharpness_Consumed_Melee_Only_));
                }
            }

            [DisplayName("Offset")]
            public long Sharpness_Consumed_Melee_Only__offset { get; private set; }

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
                    ChangedItems.Add(nameof(Guard_Knockback_Sharpness_Usage_Small));
                    OnPropertyChanged(nameof(Guard_Knockback_Sharpness_Usage_Small));
                }
            }

            [DisplayName("Offset")]
            public long Guard_Knockback_Sharpness_Usage_Small_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Guard_Knockback_Sharpness_Usage_Medium));
                    OnPropertyChanged(nameof(Guard_Knockback_Sharpness_Usage_Medium));
                }
            }

            [DisplayName("Offset")]
            public long Guard_Knockback_Sharpness_Usage_Medium_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Guard_Knockback_Sharpness_Usage_Large));
                    OnPropertyChanged(nameof(Guard_Knockback_Sharpness_Usage_Large));
                }
            }

            [DisplayName("Offset")]
            public long Guard_Knockback_Sharpness_Usage_Large_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Weapon_Sweet_spot));
                    OnPropertyChanged(nameof(Weapon_Sweet_spot));
                }
            }

            [DisplayName("Offset")]
            public long Weapon_Sweet_spot_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_23));
                    OnPropertyChanged(nameof(Unk_23));
                }
            }

            [DisplayName("Offset")]
            public long Unk_23_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_24));
                    OnPropertyChanged(nameof(Unk_24));
                }
            }

            [DisplayName("Offset")]
            public long Unk_24_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Elderseal_Modifier_));
                    OnPropertyChanged(nameof(Elderseal_Modifier_));
                }
            }

            [DisplayName("Offset")]
            public long Elderseal_Modifier__offset { get; private set; }

            protected byte Limit_Until_The_Tic_Damage_Decreases_1shot_e_g_Pierce_Slice_Ammo__raw;
            public const string Limit_Until_The_Tic_Damage_Decreases_1shot_e_g_Pierce_Slice_Ammo__displayName = "Limit Until The Tic Damage Decreases 1shot (e.g. Pierce / Slice Ammo)";
            public const int Limit_Until_The_Tic_Damage_Decreases_1shot_e_g_Pierce_Slice_Ammo__sortIndex = 1250;
            [SortOrder(Limit_Until_The_Tic_Damage_Decreases_1shot_e_g_Pierce_Slice_Ammo__sortIndex)]
            [DisplayName(Limit_Until_The_Tic_Damage_Decreases_1shot_e_g_Pierce_Slice_Ammo__displayName)]
            public virtual byte Limit_Until_The_Tic_Damage_Decreases_1shot_e_g_Pierce_Slice_Ammo_ {
                get => Limit_Until_The_Tic_Damage_Decreases_1shot_e_g_Pierce_Slice_Ammo__raw;
                set {
                    if (Limit_Until_The_Tic_Damage_Decreases_1shot_e_g_Pierce_Slice_Ammo__raw == value) return;
                    Limit_Until_The_Tic_Damage_Decreases_1shot_e_g_Pierce_Slice_Ammo__raw = value;
                    ChangedItems.Add(nameof(Limit_Until_The_Tic_Damage_Decreases_1shot_e_g_Pierce_Slice_Ammo_));
                    OnPropertyChanged(nameof(Limit_Until_The_Tic_Damage_Decreases_1shot_e_g_Pierce_Slice_Ammo_));
                }
            }

            [DisplayName("Offset")]
            public long Limit_Until_The_Tic_Damage_Decreases_1shot_e_g_Pierce_Slice_Ammo__offset { get; private set; }

            protected float Decreases_Tic_Damage_Over_The_Limit_raw;
            public const string Decreases_Tic_Damage_Over_The_Limit_displayName = "Decreases Tic Damage Over The Limit";
            public const int Decreases_Tic_Damage_Over_The_Limit_sortIndex = 1300;
            [SortOrder(Decreases_Tic_Damage_Over_The_Limit_sortIndex)]
            [DisplayName(Decreases_Tic_Damage_Over_The_Limit_displayName)]
            public virtual float Decreases_Tic_Damage_Over_The_Limit {
                get => Decreases_Tic_Damage_Over_The_Limit_raw;
                set {
                    if (Decreases_Tic_Damage_Over_The_Limit_raw == value) return;
                    Decreases_Tic_Damage_Over_The_Limit_raw = value;
                    ChangedItems.Add(nameof(Decreases_Tic_Damage_Over_The_Limit));
                    OnPropertyChanged(nameof(Decreases_Tic_Damage_Over_The_Limit));
                }
            }

            [DisplayName("Offset")]
            public long Decreases_Tic_Damage_Over_The_Limit_offset { get; private set; }

            public const int lastSortIndex = 1350;

            public static ObservableMhwStructCollection<W13p_Params_2_Shared_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<W13p_Params_2_Shared_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W13p_Params_2_Shared_ LoadData(BinaryReader reader, ulong i) {
                var data = new W13p_Params_2_Shared_();
                data.Index = i;
                data.Unk_2_offset = reader.BaseStream.Position;
                data.Unk_2_raw = reader.ReadSingle();
                data.Unk_3_offset = reader.BaseStream.Position;
                data.Unk_3_raw = reader.ReadSingle();
                data.Unk_4_offset = reader.BaseStream.Position;
                data.Unk_4_raw = reader.ReadSingle();
                data.Unk_5_offset = reader.BaseStream.Position;
                data.Unk_5_raw = reader.ReadSingle();
                data.Unk_6_offset = reader.BaseStream.Position;
                data.Unk_6_raw = reader.ReadSingle();
                data.Unk_7_offset = reader.BaseStream.Position;
                data.Unk_7_raw = reader.ReadSingle();
                data.Unk_8_offset = reader.BaseStream.Position;
                data.Unk_8_raw = reader.ReadSingle();
                data.Unk_9_offset = reader.BaseStream.Position;
                data.Unk_9_raw = reader.ReadSingle();
                data.Unk_10_offset = reader.BaseStream.Position;
                data.Unk_10_raw = reader.ReadSingle();
                data.Unk_11_offset = reader.BaseStream.Position;
                data.Unk_11_raw = reader.ReadSingle();
                data.Unk_12_offset = reader.BaseStream.Position;
                data.Unk_12_raw = reader.ReadSingle();
                data.Unk_13_offset = reader.BaseStream.Position;
                data.Unk_13_raw = reader.ReadSingle();
                data.Unk_14_offset = reader.BaseStream.Position;
                data.Unk_14_raw = reader.ReadSingle();
                data.Unk_15_offset = reader.BaseStream.Position;
                data.Unk_15_raw = reader.ReadSingle();
                data.Unk_16_offset = reader.BaseStream.Position;
                data.Unk_16_raw = reader.ReadSingle();
                data.Unk_17_offset = reader.BaseStream.Position;
                data.Unk_17_raw = reader.ReadSingle();
                data.Sharpness_Consumed_Melee_Only__offset = reader.BaseStream.Position;
                data.Sharpness_Consumed_Melee_Only__raw = reader.ReadByte();
                data.Guard_Knockback_Sharpness_Usage_Small_offset = reader.BaseStream.Position;
                data.Guard_Knockback_Sharpness_Usage_Small_raw = reader.ReadByte();
                data.Guard_Knockback_Sharpness_Usage_Medium_offset = reader.BaseStream.Position;
                data.Guard_Knockback_Sharpness_Usage_Medium_raw = reader.ReadByte();
                data.Guard_Knockback_Sharpness_Usage_Large_offset = reader.BaseStream.Position;
                data.Guard_Knockback_Sharpness_Usage_Large_raw = reader.ReadByte();
                data.Weapon_Sweet_spot_offset = reader.BaseStream.Position;
                data.Weapon_Sweet_spot_raw = reader.ReadSingle();
                data.Unk_23_offset = reader.BaseStream.Position;
                data.Unk_23_raw = reader.ReadSingle();
                data.Unk_24_offset = reader.BaseStream.Position;
                data.Unk_24_raw = reader.ReadSingle();
                data.Elderseal_Modifier__offset = reader.BaseStream.Position;
                data.Elderseal_Modifier__raw = reader.ReadSingle();
                data.Limit_Until_The_Tic_Damage_Decreases_1shot_e_g_Pierce_Slice_Ammo__offset = reader.BaseStream.Position;
                data.Limit_Until_The_Tic_Damage_Decreases_1shot_e_g_Pierce_Slice_Ammo__raw = reader.ReadByte();
                data.Decreases_Tic_Damage_Over_The_Limit_offset = reader.BaseStream.Position;
                data.Decreases_Tic_Damage_Over_The_Limit_raw = reader.ReadSingle();
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
                writer.Write(Limit_Until_The_Tic_Damage_Decreases_1shot_e_g_Pierce_Slice_Ammo__raw);
                writer.Write(Decreases_Tic_Damage_Over_The_Limit_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Unk 2", "Unk_2", "Unk_2_offset"),
                    new MultiStructItemCustomView(this, "Unk 3", "Unk_3", "Unk_3_offset"),
                    new MultiStructItemCustomView(this, "Unk 4", "Unk_4", "Unk_4_offset"),
                    new MultiStructItemCustomView(this, "Unk 5", "Unk_5", "Unk_5_offset"),
                    new MultiStructItemCustomView(this, "Unk 6", "Unk_6", "Unk_6_offset"),
                    new MultiStructItemCustomView(this, "Unk 7", "Unk_7", "Unk_7_offset"),
                    new MultiStructItemCustomView(this, "Unk 8", "Unk_8", "Unk_8_offset"),
                    new MultiStructItemCustomView(this, "Unk 9", "Unk_9", "Unk_9_offset"),
                    new MultiStructItemCustomView(this, "Unk 10", "Unk_10", "Unk_10_offset"),
                    new MultiStructItemCustomView(this, "Unk 11", "Unk_11", "Unk_11_offset"),
                    new MultiStructItemCustomView(this, "Unk 12", "Unk_12", "Unk_12_offset"),
                    new MultiStructItemCustomView(this, "Unk 13", "Unk_13", "Unk_13_offset"),
                    new MultiStructItemCustomView(this, "Unk 14", "Unk_14", "Unk_14_offset"),
                    new MultiStructItemCustomView(this, "Unk 15", "Unk_15", "Unk_15_offset"),
                    new MultiStructItemCustomView(this, "Unk 16", "Unk_16", "Unk_16_offset"),
                    new MultiStructItemCustomView(this, "Unk 17", "Unk_17", "Unk_17_offset"),
                    new MultiStructItemCustomView(this, "Sharpness Consumed (Melee Only)", "Sharpness_Consumed_Melee_Only_", "Sharpness_Consumed_Melee_Only__offset"),
                    new MultiStructItemCustomView(this, "Guard Knockback Sharpness Usage: Small", "Guard_Knockback_Sharpness_Usage_Small", "Guard_Knockback_Sharpness_Usage_Small_offset"),
                    new MultiStructItemCustomView(this, "Guard Knockback Sharpness Usage: Medium", "Guard_Knockback_Sharpness_Usage_Medium", "Guard_Knockback_Sharpness_Usage_Medium_offset"),
                    new MultiStructItemCustomView(this, "Guard Knockback Sharpness Usage: Large", "Guard_Knockback_Sharpness_Usage_Large", "Guard_Knockback_Sharpness_Usage_Large_offset"),
                    new MultiStructItemCustomView(this, "Weapon Sweet-spot", "Weapon_Sweet_spot", "Weapon_Sweet_spot_offset"),
                    new MultiStructItemCustomView(this, "Unk 23", "Unk_23", "Unk_23_offset"),
                    new MultiStructItemCustomView(this, "Unk 24", "Unk_24", "Unk_24_offset"),
                    new MultiStructItemCustomView(this, "Elderseal Modifier?", "Elderseal_Modifier_", "Elderseal_Modifier__offset"),
                    new MultiStructItemCustomView(this, "Limit Until The Tic Damage Decreases 1shot (e.g. Pierce / Slice Ammo)", "Limit_Until_The_Tic_Damage_Decreases_1shot_e_g_Pierce_Slice_Ammo_", "Limit_Until_The_Tic_Damage_Decreases_1shot_e_g_Pierce_Slice_Ammo__offset"),
                    new MultiStructItemCustomView(this, "Decreases Tic Damage Over The Limit", "Decreases_Tic_Damage_Over_The_Limit", "Decreases_Tic_Damage_Over_The_Limit_offset"),
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
                    ChangedItems.Add(nameof(Guard_Angle_Both_Sides_));
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
                    ChangedItems.Add(nameof(Knockback_Threshold_Small));
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
                    ChangedItems.Add(nameof(Knockback_Threshold_Medium));
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
                    ChangedItems.Add(nameof(Knockback_Threshold_Large));
                    OnPropertyChanged(nameof(Knockback_Threshold_Large));
                }
            }

            public const int lastSortIndex = 250;

            public static ObservableMhwStructCollection<Guard_Angles_Shared_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Guard_Angles_Shared_>();
                const ulong count = 2UL;
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

        public partial class W13p_Params_3_Shared_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
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
                    ChangedItems.Add(nameof(Unk_28));
                    OnPropertyChanged(nameof(Unk_28));
                }
            }

            [DisplayName("Offset")]
            public long Unk_28_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_29));
                    OnPropertyChanged(nameof(Unk_29));
                }
            }

            [DisplayName("Offset")]
            public long Unk_29_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_30));
                    OnPropertyChanged(nameof(Unk_30));
                }
            }

            [DisplayName("Offset")]
            public long Unk_30_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_31));
                    OnPropertyChanged(nameof(Unk_31));
                }
            }

            [DisplayName("Offset")]
            public long Unk_31_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_32));
                    OnPropertyChanged(nameof(Unk_32));
                }
            }

            [DisplayName("Offset")]
            public long Unk_32_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_33));
                    OnPropertyChanged(nameof(Unk_33));
                }
            }

            [DisplayName("Offset")]
            public long Unk_33_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_34));
                    OnPropertyChanged(nameof(Unk_34));
                }
            }

            [DisplayName("Offset")]
            public long Unk_34_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_35));
                    OnPropertyChanged(nameof(Unk_35));
                }
            }

            [DisplayName("Offset")]
            public long Unk_35_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_36));
                    OnPropertyChanged(nameof(Unk_36));
                }
            }

            [DisplayName("Offset")]
            public long Unk_36_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_37));
                    OnPropertyChanged(nameof(Unk_37));
                }
            }

            [DisplayName("Offset")]
            public long Unk_37_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_38));
                    OnPropertyChanged(nameof(Unk_38));
                }
            }

            [DisplayName("Offset")]
            public long Unk_38_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_39));
                    OnPropertyChanged(nameof(Unk_39));
                }
            }

            [DisplayName("Offset")]
            public long Unk_39_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_40));
                    OnPropertyChanged(nameof(Unk_40));
                }
            }

            [DisplayName("Offset")]
            public long Unk_40_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_41));
                    OnPropertyChanged(nameof(Unk_41));
                }
            }

            [DisplayName("Offset")]
            public long Unk_41_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_42));
                    OnPropertyChanged(nameof(Unk_42));
                }
            }

            [DisplayName("Offset")]
            public long Unk_42_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_43));
                    OnPropertyChanged(nameof(Unk_43));
                }
            }

            [DisplayName("Offset")]
            public long Unk_43_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_44));
                    OnPropertyChanged(nameof(Unk_44));
                }
            }

            [DisplayName("Offset")]
            public long Unk_44_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_45));
                    OnPropertyChanged(nameof(Unk_45));
                }
            }

            [DisplayName("Offset")]
            public long Unk_45_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_46));
                    OnPropertyChanged(nameof(Unk_46));
                }
            }

            [DisplayName("Offset")]
            public long Unk_46_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_47));
                    OnPropertyChanged(nameof(Unk_47));
                }
            }

            [DisplayName("Offset")]
            public long Unk_47_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_48));
                    OnPropertyChanged(nameof(Unk_48));
                }
            }

            [DisplayName("Offset")]
            public long Unk_48_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_49));
                    OnPropertyChanged(nameof(Unk_49));
                }
            }

            [DisplayName("Offset")]
            public long Unk_49_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_50));
                    OnPropertyChanged(nameof(Unk_50));
                }
            }

            [DisplayName("Offset")]
            public long Unk_50_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_51));
                    OnPropertyChanged(nameof(Unk_51));
                }
            }

            [DisplayName("Offset")]
            public long Unk_51_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_52));
                    OnPropertyChanged(nameof(Unk_52));
                }
            }

            [DisplayName("Offset")]
            public long Unk_52_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_53));
                    OnPropertyChanged(nameof(Unk_53));
                }
            }

            [DisplayName("Offset")]
            public long Unk_53_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_54));
                    OnPropertyChanged(nameof(Unk_54));
                }
            }

            [DisplayName("Offset")]
            public long Unk_54_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_55));
                    OnPropertyChanged(nameof(Unk_55));
                }
            }

            [DisplayName("Offset")]
            public long Unk_55_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_56));
                    OnPropertyChanged(nameof(Unk_56));
                }
            }

            [DisplayName("Offset")]
            public long Unk_56_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_57));
                    OnPropertyChanged(nameof(Unk_57));
                }
            }

            [DisplayName("Offset")]
            public long Unk_57_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_58));
                    OnPropertyChanged(nameof(Unk_58));
                }
            }

            [DisplayName("Offset")]
            public long Unk_58_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_59));
                    OnPropertyChanged(nameof(Unk_59));
                }
            }

            [DisplayName("Offset")]
            public long Unk_59_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_60));
                    OnPropertyChanged(nameof(Unk_60));
                }
            }

            [DisplayName("Offset")]
            public long Unk_60_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_61));
                    OnPropertyChanged(nameof(Unk_61));
                }
            }

            [DisplayName("Offset")]
            public long Unk_61_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_62));
                    OnPropertyChanged(nameof(Unk_62));
                }
            }

            [DisplayName("Offset")]
            public long Unk_62_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_63));
                    OnPropertyChanged(nameof(Unk_63));
                }
            }

            [DisplayName("Offset")]
            public long Unk_63_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_64));
                    OnPropertyChanged(nameof(Unk_64));
                }
            }

            [DisplayName("Offset")]
            public long Unk_64_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_65));
                    OnPropertyChanged(nameof(Unk_65));
                }
            }

            [DisplayName("Offset")]
            public long Unk_65_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_66));
                    OnPropertyChanged(nameof(Unk_66));
                }
            }

            [DisplayName("Offset")]
            public long Unk_66_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_67));
                    OnPropertyChanged(nameof(Unk_67));
                }
            }

            [DisplayName("Offset")]
            public long Unk_67_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_68));
                    OnPropertyChanged(nameof(Unk_68));
                }
            }

            [DisplayName("Offset")]
            public long Unk_68_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_69));
                    OnPropertyChanged(nameof(Unk_69));
                }
            }

            [DisplayName("Offset")]
            public long Unk_69_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_70));
                    OnPropertyChanged(nameof(Unk_70));
                }
            }

            [DisplayName("Offset")]
            public long Unk_70_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_71));
                    OnPropertyChanged(nameof(Unk_71));
                }
            }

            [DisplayName("Offset")]
            public long Unk_71_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_72));
                    OnPropertyChanged(nameof(Unk_72));
                }
            }

            [DisplayName("Offset")]
            public long Unk_72_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_73));
                    OnPropertyChanged(nameof(Unk_73));
                }
            }

            [DisplayName("Offset")]
            public long Unk_73_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_74));
                    OnPropertyChanged(nameof(Unk_74));
                }
            }

            [DisplayName("Offset")]
            public long Unk_74_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_75));
                    OnPropertyChanged(nameof(Unk_75));
                }
            }

            [DisplayName("Offset")]
            public long Unk_75_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_76));
                    OnPropertyChanged(nameof(Unk_76));
                }
            }

            [DisplayName("Offset")]
            public long Unk_76_offset { get; private set; }

            public const int lastSortIndex = 2500;

            public static ObservableMhwStructCollection<W13p_Params_3_Shared_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<W13p_Params_3_Shared_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W13p_Params_3_Shared_ LoadData(BinaryReader reader, ulong i) {
                var data = new W13p_Params_3_Shared_();
                data.Index = i;
                data.Unk_28_offset = reader.BaseStream.Position;
                data.Unk_28_raw = reader.ReadSingle();
                data.Unk_29_offset = reader.BaseStream.Position;
                data.Unk_29_raw = reader.ReadSingle();
                data.Unk_30_offset = reader.BaseStream.Position;
                data.Unk_30_raw = reader.ReadSingle();
                data.Unk_31_offset = reader.BaseStream.Position;
                data.Unk_31_raw = reader.ReadSingle();
                data.Unk_32_offset = reader.BaseStream.Position;
                data.Unk_32_raw = reader.ReadSingle();
                data.Unk_33_offset = reader.BaseStream.Position;
                data.Unk_33_raw = reader.ReadSingle();
                data.Unk_34_offset = reader.BaseStream.Position;
                data.Unk_34_raw = reader.ReadSingle();
                data.Unk_35_offset = reader.BaseStream.Position;
                data.Unk_35_raw = reader.ReadSingle();
                data.Unk_36_offset = reader.BaseStream.Position;
                data.Unk_36_raw = reader.ReadSingle();
                data.Unk_37_offset = reader.BaseStream.Position;
                data.Unk_37_raw = reader.ReadSingle();
                data.Unk_38_offset = reader.BaseStream.Position;
                data.Unk_38_raw = reader.ReadSingle();
                data.Unk_39_offset = reader.BaseStream.Position;
                data.Unk_39_raw = reader.ReadSingle();
                data.Unk_40_offset = reader.BaseStream.Position;
                data.Unk_40_raw = reader.ReadSingle();
                data.Unk_41_offset = reader.BaseStream.Position;
                data.Unk_41_raw = reader.ReadSingle();
                data.Unk_42_offset = reader.BaseStream.Position;
                data.Unk_42_raw = reader.ReadSingle();
                data.Unk_43_offset = reader.BaseStream.Position;
                data.Unk_43_raw = reader.ReadSingle();
                data.Unk_44_offset = reader.BaseStream.Position;
                data.Unk_44_raw = reader.ReadSingle();
                data.Unk_45_offset = reader.BaseStream.Position;
                data.Unk_45_raw = reader.ReadSingle();
                data.Unk_46_offset = reader.BaseStream.Position;
                data.Unk_46_raw = reader.ReadSingle();
                data.Unk_47_offset = reader.BaseStream.Position;
                data.Unk_47_raw = reader.ReadSingle();
                data.Unk_48_offset = reader.BaseStream.Position;
                data.Unk_48_raw = reader.ReadSingle();
                data.Unk_49_offset = reader.BaseStream.Position;
                data.Unk_49_raw = reader.ReadUInt32();
                data.Unk_50_offset = reader.BaseStream.Position;
                data.Unk_50_raw = reader.ReadUInt32();
                data.Unk_51_offset = reader.BaseStream.Position;
                data.Unk_51_raw = reader.ReadSingle();
                data.Unk_52_offset = reader.BaseStream.Position;
                data.Unk_52_raw = reader.ReadSingle();
                data.Unk_53_offset = reader.BaseStream.Position;
                data.Unk_53_raw = reader.ReadSingle();
                data.Unk_54_offset = reader.BaseStream.Position;
                data.Unk_54_raw = reader.ReadSingle();
                data.Unk_55_offset = reader.BaseStream.Position;
                data.Unk_55_raw = reader.ReadSingle();
                data.Unk_56_offset = reader.BaseStream.Position;
                data.Unk_56_raw = reader.ReadSingle();
                data.Unk_57_offset = reader.BaseStream.Position;
                data.Unk_57_raw = reader.ReadSingle();
                data.Unk_58_offset = reader.BaseStream.Position;
                data.Unk_58_raw = reader.ReadSingle();
                data.Unk_59_offset = reader.BaseStream.Position;
                data.Unk_59_raw = reader.ReadSingle();
                data.Unk_60_offset = reader.BaseStream.Position;
                data.Unk_60_raw = reader.ReadSingle();
                data.Unk_61_offset = reader.BaseStream.Position;
                data.Unk_61_raw = reader.ReadSingle();
                data.Unk_62_offset = reader.BaseStream.Position;
                data.Unk_62_raw = reader.ReadSingle();
                data.Unk_63_offset = reader.BaseStream.Position;
                data.Unk_63_raw = reader.ReadSingle();
                data.Unk_64_offset = reader.BaseStream.Position;
                data.Unk_64_raw = reader.ReadSingle();
                data.Unk_65_offset = reader.BaseStream.Position;
                data.Unk_65_raw = reader.ReadSingle();
                data.Unk_66_offset = reader.BaseStream.Position;
                data.Unk_66_raw = reader.ReadSingle();
                data.Unk_67_offset = reader.BaseStream.Position;
                data.Unk_67_raw = reader.ReadSingle();
                data.Unk_68_offset = reader.BaseStream.Position;
                data.Unk_68_raw = reader.ReadSingle();
                data.Unk_69_offset = reader.BaseStream.Position;
                data.Unk_69_raw = reader.ReadSingle();
                data.Unk_70_offset = reader.BaseStream.Position;
                data.Unk_70_raw = reader.ReadSingle();
                data.Unk_71_offset = reader.BaseStream.Position;
                data.Unk_71_raw = reader.ReadSingle();
                data.Unk_72_offset = reader.BaseStream.Position;
                data.Unk_72_raw = reader.ReadByte();
                data.Unk_73_offset = reader.BaseStream.Position;
                data.Unk_73_raw = reader.ReadUInt32();
                data.Unk_74_offset = reader.BaseStream.Position;
                data.Unk_74_raw = reader.ReadSingle();
                data.Unk_75_offset = reader.BaseStream.Position;
                data.Unk_75_raw = reader.ReadSingle();
                data.Unk_76_offset = reader.BaseStream.Position;
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
                    new MultiStructItemCustomView(this, "Unk 28", "Unk_28", "Unk_28_offset"),
                    new MultiStructItemCustomView(this, "Unk 29", "Unk_29", "Unk_29_offset"),
                    new MultiStructItemCustomView(this, "Unk 30", "Unk_30", "Unk_30_offset"),
                    new MultiStructItemCustomView(this, "Unk 31", "Unk_31", "Unk_31_offset"),
                    new MultiStructItemCustomView(this, "Unk 32", "Unk_32", "Unk_32_offset"),
                    new MultiStructItemCustomView(this, "Unk 33", "Unk_33", "Unk_33_offset"),
                    new MultiStructItemCustomView(this, "Unk 34", "Unk_34", "Unk_34_offset"),
                    new MultiStructItemCustomView(this, "Unk 35", "Unk_35", "Unk_35_offset"),
                    new MultiStructItemCustomView(this, "Unk 36", "Unk_36", "Unk_36_offset"),
                    new MultiStructItemCustomView(this, "Unk 37", "Unk_37", "Unk_37_offset"),
                    new MultiStructItemCustomView(this, "Unk 38", "Unk_38", "Unk_38_offset"),
                    new MultiStructItemCustomView(this, "Unk 39", "Unk_39", "Unk_39_offset"),
                    new MultiStructItemCustomView(this, "Unk 40", "Unk_40", "Unk_40_offset"),
                    new MultiStructItemCustomView(this, "Unk 41", "Unk_41", "Unk_41_offset"),
                    new MultiStructItemCustomView(this, "Unk 42", "Unk_42", "Unk_42_offset"),
                    new MultiStructItemCustomView(this, "Unk 43", "Unk_43", "Unk_43_offset"),
                    new MultiStructItemCustomView(this, "Unk 44", "Unk_44", "Unk_44_offset"),
                    new MultiStructItemCustomView(this, "Unk 45", "Unk_45", "Unk_45_offset"),
                    new MultiStructItemCustomView(this, "Unk 46", "Unk_46", "Unk_46_offset"),
                    new MultiStructItemCustomView(this, "Unk 47", "Unk_47", "Unk_47_offset"),
                    new MultiStructItemCustomView(this, "Unk 48", "Unk_48", "Unk_48_offset"),
                    new MultiStructItemCustomView(this, "Unk 49", "Unk_49", "Unk_49_offset"),
                    new MultiStructItemCustomView(this, "Unk 50", "Unk_50", "Unk_50_offset"),
                    new MultiStructItemCustomView(this, "Unk 51", "Unk_51", "Unk_51_offset"),
                    new MultiStructItemCustomView(this, "Unk 52", "Unk_52", "Unk_52_offset"),
                    new MultiStructItemCustomView(this, "Unk 53", "Unk_53", "Unk_53_offset"),
                    new MultiStructItemCustomView(this, "Unk 54", "Unk_54", "Unk_54_offset"),
                    new MultiStructItemCustomView(this, "Unk 55", "Unk_55", "Unk_55_offset"),
                    new MultiStructItemCustomView(this, "Unk 56", "Unk_56", "Unk_56_offset"),
                    new MultiStructItemCustomView(this, "Unk 57", "Unk_57", "Unk_57_offset"),
                    new MultiStructItemCustomView(this, "Unk 58", "Unk_58", "Unk_58_offset"),
                    new MultiStructItemCustomView(this, "Unk 59", "Unk_59", "Unk_59_offset"),
                    new MultiStructItemCustomView(this, "Unk 60", "Unk_60", "Unk_60_offset"),
                    new MultiStructItemCustomView(this, "Unk 61", "Unk_61", "Unk_61_offset"),
                    new MultiStructItemCustomView(this, "Unk 62", "Unk_62", "Unk_62_offset"),
                    new MultiStructItemCustomView(this, "Unk 63", "Unk_63", "Unk_63_offset"),
                    new MultiStructItemCustomView(this, "Unk 64", "Unk_64", "Unk_64_offset"),
                    new MultiStructItemCustomView(this, "Unk 65", "Unk_65", "Unk_65_offset"),
                    new MultiStructItemCustomView(this, "Unk 66", "Unk_66", "Unk_66_offset"),
                    new MultiStructItemCustomView(this, "Unk 67", "Unk_67", "Unk_67_offset"),
                    new MultiStructItemCustomView(this, "Unk 68", "Unk_68", "Unk_68_offset"),
                    new MultiStructItemCustomView(this, "Unk 69", "Unk_69", "Unk_69_offset"),
                    new MultiStructItemCustomView(this, "Unk 70", "Unk_70", "Unk_70_offset"),
                    new MultiStructItemCustomView(this, "Unk 71", "Unk_71", "Unk_71_offset"),
                    new MultiStructItemCustomView(this, "Unk 72", "Unk_72", "Unk_72_offset"),
                    new MultiStructItemCustomView(this, "Unk 73", "Unk_73", "Unk_73_offset"),
                    new MultiStructItemCustomView(this, "Unk 74", "Unk_74", "Unk_74_offset"),
                    new MultiStructItemCustomView(this, "Unk 75", "Unk_75", "Unk_75_offset"),
                    new MultiStructItemCustomView(this, "Unk 76", "Unk_76", "Unk_76_offset"),
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
                    ChangedItems.Add(nameof(Unk_1));
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
                    ChangedItems.Add(nameof(Unk_2));
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
                    ChangedItems.Add(nameof(Unk_3));
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
                    ChangedItems.Add(nameof(Unk_4));
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
                    ChangedItems.Add(nameof(Unk_5));
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
                    ChangedItems.Add(nameof(Unk_6));
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
                    ChangedItems.Add(nameof(Unk_7));
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
                    ChangedItems.Add(nameof(Unk_8));
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
                    ChangedItems.Add(nameof(Unk_9));
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
                    ChangedItems.Add(nameof(Unk_10));
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
                    ChangedItems.Add(nameof(Unk_11));
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
                    ChangedItems.Add(nameof(Unk_12));
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
                    ChangedItems.Add(nameof(Unk_13));
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
                    ChangedItems.Add(nameof(Unk_14));
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
                    ChangedItems.Add(nameof(Unk_15));
                    OnPropertyChanged(nameof(Unk_15));
                }
            }

            public const int lastSortIndex = 800;

            public static ObservableMhwStructCollection<Unk_Arr_2_Shared_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Unk_Arr_2_Shared_>();
                const ulong count = 8UL;
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

        public partial class W13p_Params_4_Shared_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W13p Params (4, Shared)";

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
                    ChangedItems.Add(nameof(Unk_77));
                    OnPropertyChanged(nameof(Unk_77));
                }
            }

            [DisplayName("Offset")]
            public long Unk_77_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_78));
                    OnPropertyChanged(nameof(Unk_78));
                }
            }

            [DisplayName("Offset")]
            public long Unk_78_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_79));
                    OnPropertyChanged(nameof(Unk_79));
                }
            }

            [DisplayName("Offset")]
            public long Unk_79_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_80));
                    OnPropertyChanged(nameof(Unk_80));
                }
            }

            [DisplayName("Offset")]
            public long Unk_80_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_81));
                    OnPropertyChanged(nameof(Unk_81));
                }
            }

            [DisplayName("Offset")]
            public long Unk_81_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_82));
                    OnPropertyChanged(nameof(Unk_82));
                }
            }

            [DisplayName("Offset")]
            public long Unk_82_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_83));
                    OnPropertyChanged(nameof(Unk_83));
                }
            }

            [DisplayName("Offset")]
            public long Unk_83_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_84));
                    OnPropertyChanged(nameof(Unk_84));
                }
            }

            [DisplayName("Offset")]
            public long Unk_84_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_85));
                    OnPropertyChanged(nameof(Unk_85));
                }
            }

            [DisplayName("Offset")]
            public long Unk_85_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_86));
                    OnPropertyChanged(nameof(Unk_86));
                }
            }

            [DisplayName("Offset")]
            public long Unk_86_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_87));
                    OnPropertyChanged(nameof(Unk_87));
                }
            }

            [DisplayName("Offset")]
            public long Unk_87_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_88));
                    OnPropertyChanged(nameof(Unk_88));
                }
            }

            [DisplayName("Offset")]
            public long Unk_88_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_89));
                    OnPropertyChanged(nameof(Unk_89));
                }
            }

            [DisplayName("Offset")]
            public long Unk_89_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_90));
                    OnPropertyChanged(nameof(Unk_90));
                }
            }

            [DisplayName("Offset")]
            public long Unk_90_offset { get; private set; }

            protected float Unk_15_10_1_raw;
            public const string Unk_15_10_1_displayName = "Unk (15.10) 1";
            public const int Unk_15_10_1_sortIndex = 750;
            [SortOrder(Unk_15_10_1_sortIndex)]
            [DisplayName(Unk_15_10_1_displayName)]
            public virtual float Unk_15_10_1 {
                get => Unk_15_10_1_raw;
                set {
                    if (Unk_15_10_1_raw == value) return;
                    Unk_15_10_1_raw = value;
                    ChangedItems.Add(nameof(Unk_15_10_1));
                    OnPropertyChanged(nameof(Unk_15_10_1));
                }
            }

            [DisplayName("Offset")]
            public long Unk_15_10_1_offset { get; private set; }

            protected float Unk_15_10_2_raw;
            public const string Unk_15_10_2_displayName = "Unk (15.10) 2";
            public const int Unk_15_10_2_sortIndex = 800;
            [SortOrder(Unk_15_10_2_sortIndex)]
            [DisplayName(Unk_15_10_2_displayName)]
            public virtual float Unk_15_10_2 {
                get => Unk_15_10_2_raw;
                set {
                    if (Unk_15_10_2_raw == value) return;
                    Unk_15_10_2_raw = value;
                    ChangedItems.Add(nameof(Unk_15_10_2));
                    OnPropertyChanged(nameof(Unk_15_10_2));
                }
            }

            [DisplayName("Offset")]
            public long Unk_15_10_2_offset { get; private set; }

            protected float Unk_15_10_3_raw;
            public const string Unk_15_10_3_displayName = "Unk (15.10) 3";
            public const int Unk_15_10_3_sortIndex = 850;
            [SortOrder(Unk_15_10_3_sortIndex)]
            [DisplayName(Unk_15_10_3_displayName)]
            public virtual float Unk_15_10_3 {
                get => Unk_15_10_3_raw;
                set {
                    if (Unk_15_10_3_raw == value) return;
                    Unk_15_10_3_raw = value;
                    ChangedItems.Add(nameof(Unk_15_10_3));
                    OnPropertyChanged(nameof(Unk_15_10_3));
                }
            }

            [DisplayName("Offset")]
            public long Unk_15_10_3_offset { get; private set; }

            protected float Unk_15_10_4_raw;
            public const string Unk_15_10_4_displayName = "Unk (15.10) 4";
            public const int Unk_15_10_4_sortIndex = 900;
            [SortOrder(Unk_15_10_4_sortIndex)]
            [DisplayName(Unk_15_10_4_displayName)]
            public virtual float Unk_15_10_4 {
                get => Unk_15_10_4_raw;
                set {
                    if (Unk_15_10_4_raw == value) return;
                    Unk_15_10_4_raw = value;
                    ChangedItems.Add(nameof(Unk_15_10_4));
                    OnPropertyChanged(nameof(Unk_15_10_4));
                }
            }

            [DisplayName("Offset")]
            public long Unk_15_10_4_offset { get; private set; }

            protected float Unk_15_10_5_raw;
            public const string Unk_15_10_5_displayName = "Unk (15.10) 5";
            public const int Unk_15_10_5_sortIndex = 950;
            [SortOrder(Unk_15_10_5_sortIndex)]
            [DisplayName(Unk_15_10_5_displayName)]
            public virtual float Unk_15_10_5 {
                get => Unk_15_10_5_raw;
                set {
                    if (Unk_15_10_5_raw == value) return;
                    Unk_15_10_5_raw = value;
                    ChangedItems.Add(nameof(Unk_15_10_5));
                    OnPropertyChanged(nameof(Unk_15_10_5));
                }
            }

            [DisplayName("Offset")]
            public long Unk_15_10_5_offset { get; private set; }

            protected float Unk_15_10_6_raw;
            public const string Unk_15_10_6_displayName = "Unk (15.10) 6";
            public const int Unk_15_10_6_sortIndex = 1000;
            [SortOrder(Unk_15_10_6_sortIndex)]
            [DisplayName(Unk_15_10_6_displayName)]
            public virtual float Unk_15_10_6 {
                get => Unk_15_10_6_raw;
                set {
                    if (Unk_15_10_6_raw == value) return;
                    Unk_15_10_6_raw = value;
                    ChangedItems.Add(nameof(Unk_15_10_6));
                    OnPropertyChanged(nameof(Unk_15_10_6));
                }
            }

            [DisplayName("Offset")]
            public long Unk_15_10_6_offset { get; private set; }

            public const int lastSortIndex = 1050;

            public static ObservableMhwStructCollection<W13p_Params_4_Shared_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<W13p_Params_4_Shared_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W13p_Params_4_Shared_ LoadData(BinaryReader reader, ulong i) {
                var data = new W13p_Params_4_Shared_();
                data.Index = i;
                data.Unk_77_offset = reader.BaseStream.Position;
                data.Unk_77_raw = reader.ReadByte();
                data.Unk_78_offset = reader.BaseStream.Position;
                data.Unk_78_raw = reader.ReadInt32();
                data.Unk_79_offset = reader.BaseStream.Position;
                data.Unk_79_raw = reader.ReadSingle();
                data.Unk_80_offset = reader.BaseStream.Position;
                data.Unk_80_raw = reader.ReadSingle();
                data.Unk_81_offset = reader.BaseStream.Position;
                data.Unk_81_raw = reader.ReadSingle();
                data.Unk_82_offset = reader.BaseStream.Position;
                data.Unk_82_raw = reader.ReadSingle();
                data.Unk_83_offset = reader.BaseStream.Position;
                data.Unk_83_raw = reader.ReadSingle();
                data.Unk_84_offset = reader.BaseStream.Position;
                data.Unk_84_raw = reader.ReadSingle();
                data.Unk_85_offset = reader.BaseStream.Position;
                data.Unk_85_raw = reader.ReadSingle();
                data.Unk_86_offset = reader.BaseStream.Position;
                data.Unk_86_raw = reader.ReadSingle();
                data.Unk_87_offset = reader.BaseStream.Position;
                data.Unk_87_raw = reader.ReadSingle();
                data.Unk_88_offset = reader.BaseStream.Position;
                data.Unk_88_raw = reader.ReadSingle();
                data.Unk_89_offset = reader.BaseStream.Position;
                data.Unk_89_raw = reader.ReadSingle();
                data.Unk_90_offset = reader.BaseStream.Position;
                data.Unk_90_raw = reader.ReadSingle();
                data.Unk_15_10_1_offset = reader.BaseStream.Position;
                data.Unk_15_10_1_raw = reader.ReadSingle();
                data.Unk_15_10_2_offset = reader.BaseStream.Position;
                data.Unk_15_10_2_raw = reader.ReadSingle();
                data.Unk_15_10_3_offset = reader.BaseStream.Position;
                data.Unk_15_10_3_raw = reader.ReadSingle();
                data.Unk_15_10_4_offset = reader.BaseStream.Position;
                data.Unk_15_10_4_raw = reader.ReadSingle();
                data.Unk_15_10_5_offset = reader.BaseStream.Position;
                data.Unk_15_10_5_raw = reader.ReadSingle();
                data.Unk_15_10_6_offset = reader.BaseStream.Position;
                data.Unk_15_10_6_raw = reader.ReadSingle();
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
                writer.Write(Unk_15_10_1_raw);
                writer.Write(Unk_15_10_2_raw);
                writer.Write(Unk_15_10_3_raw);
                writer.Write(Unk_15_10_4_raw);
                writer.Write(Unk_15_10_5_raw);
                writer.Write(Unk_15_10_6_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Unk 77", "Unk_77", "Unk_77_offset"),
                    new MultiStructItemCustomView(this, "Unk 78", "Unk_78", "Unk_78_offset"),
                    new MultiStructItemCustomView(this, "Unk 79", "Unk_79", "Unk_79_offset"),
                    new MultiStructItemCustomView(this, "Unk 80", "Unk_80", "Unk_80_offset"),
                    new MultiStructItemCustomView(this, "Unk 81", "Unk_81", "Unk_81_offset"),
                    new MultiStructItemCustomView(this, "Unk 82", "Unk_82", "Unk_82_offset"),
                    new MultiStructItemCustomView(this, "Unk 83", "Unk_83", "Unk_83_offset"),
                    new MultiStructItemCustomView(this, "Unk 84", "Unk_84", "Unk_84_offset"),
                    new MultiStructItemCustomView(this, "Unk 85", "Unk_85", "Unk_85_offset"),
                    new MultiStructItemCustomView(this, "Unk 86", "Unk_86", "Unk_86_offset"),
                    new MultiStructItemCustomView(this, "Unk 87", "Unk_87", "Unk_87_offset"),
                    new MultiStructItemCustomView(this, "Unk 88", "Unk_88", "Unk_88_offset"),
                    new MultiStructItemCustomView(this, "Unk 89", "Unk_89", "Unk_89_offset"),
                    new MultiStructItemCustomView(this, "Unk 90", "Unk_90", "Unk_90_offset"),
                    new MultiStructItemCustomView(this, "Unk (15.10) 1", "Unk_15_10_1", "Unk_15_10_1_offset"),
                    new MultiStructItemCustomView(this, "Unk (15.10) 2", "Unk_15_10_2", "Unk_15_10_2_offset"),
                    new MultiStructItemCustomView(this, "Unk (15.10) 3", "Unk_15_10_3", "Unk_15_10_3_offset"),
                    new MultiStructItemCustomView(this, "Unk (15.10) 4", "Unk_15_10_4", "Unk_15_10_4_offset"),
                    new MultiStructItemCustomView(this, "Unk (15.10) 5", "Unk_15_10_5", "Unk_15_10_5_offset"),
                    new MultiStructItemCustomView(this, "Unk (15.10) 6", "Unk_15_10_6", "Unk_15_10_6_offset"),
                };
            }
        }

        public partial class W13p_Params_5_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
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
                    ChangedItems.Add(nameof(Unk_91));
                    OnPropertyChanged(nameof(Unk_91));
                }
            }

            [DisplayName("Offset")]
            public long Unk_91_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_92));
                    OnPropertyChanged(nameof(Unk_92));
                }
            }

            [DisplayName("Offset")]
            public long Unk_92_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_93));
                    OnPropertyChanged(nameof(Unk_93));
                }
            }

            [DisplayName("Offset")]
            public long Unk_93_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_94));
                    OnPropertyChanged(nameof(Unk_94));
                }
            }

            [DisplayName("Offset")]
            public long Unk_94_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_95));
                    OnPropertyChanged(nameof(Unk_95));
                }
            }

            [DisplayName("Offset")]
            public long Unk_95_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_96));
                    OnPropertyChanged(nameof(Unk_96));
                }
            }

            [DisplayName("Offset")]
            public long Unk_96_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_97));
                    OnPropertyChanged(nameof(Unk_97));
                }
            }

            [DisplayName("Offset")]
            public long Unk_97_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_98));
                    OnPropertyChanged(nameof(Unk_98));
                }
            }

            [DisplayName("Offset")]
            public long Unk_98_offset { get; private set; }

            protected float Delay_Between_Shots_Rapid_Fire_Plus1_raw;
            public const string Delay_Between_Shots_Rapid_Fire_Plus1_displayName = "Delay Between Shots: Rapid Fire +1";
            public const int Delay_Between_Shots_Rapid_Fire_Plus1_sortIndex = 450;
            [SortOrder(Delay_Between_Shots_Rapid_Fire_Plus1_sortIndex)]
            [DisplayName(Delay_Between_Shots_Rapid_Fire_Plus1_displayName)]
            public virtual float Delay_Between_Shots_Rapid_Fire_Plus1 {
                get => Delay_Between_Shots_Rapid_Fire_Plus1_raw;
                set {
                    if (Delay_Between_Shots_Rapid_Fire_Plus1_raw == value) return;
                    Delay_Between_Shots_Rapid_Fire_Plus1_raw = value;
                    ChangedItems.Add(nameof(Delay_Between_Shots_Rapid_Fire_Plus1));
                    OnPropertyChanged(nameof(Delay_Between_Shots_Rapid_Fire_Plus1));
                }
            }

            [DisplayName("Offset")]
            public long Delay_Between_Shots_Rapid_Fire_Plus1_offset { get; private set; }

            protected uint Extra_Bullets_Rapid_Fire_Plus1_raw;
            public const string Extra_Bullets_Rapid_Fire_Plus1_displayName = "Extra Bullets: Rapid Fire +1";
            public const int Extra_Bullets_Rapid_Fire_Plus1_sortIndex = 500;
            [SortOrder(Extra_Bullets_Rapid_Fire_Plus1_sortIndex)]
            [DisplayName(Extra_Bullets_Rapid_Fire_Plus1_displayName)]
            public virtual uint Extra_Bullets_Rapid_Fire_Plus1 {
                get => Extra_Bullets_Rapid_Fire_Plus1_raw;
                set {
                    if (Extra_Bullets_Rapid_Fire_Plus1_raw == value) return;
                    Extra_Bullets_Rapid_Fire_Plus1_raw = value;
                    ChangedItems.Add(nameof(Extra_Bullets_Rapid_Fire_Plus1));
                    OnPropertyChanged(nameof(Extra_Bullets_Rapid_Fire_Plus1));
                }
            }

            [DisplayName("Offset")]
            public long Extra_Bullets_Rapid_Fire_Plus1_offset { get; private set; }

            protected float Delay_Between_Shots_Rapid_Fire_Plus2_raw;
            public const string Delay_Between_Shots_Rapid_Fire_Plus2_displayName = "Delay Between Shots: Rapid Fire +2";
            public const int Delay_Between_Shots_Rapid_Fire_Plus2_sortIndex = 550;
            [SortOrder(Delay_Between_Shots_Rapid_Fire_Plus2_sortIndex)]
            [DisplayName(Delay_Between_Shots_Rapid_Fire_Plus2_displayName)]
            public virtual float Delay_Between_Shots_Rapid_Fire_Plus2 {
                get => Delay_Between_Shots_Rapid_Fire_Plus2_raw;
                set {
                    if (Delay_Between_Shots_Rapid_Fire_Plus2_raw == value) return;
                    Delay_Between_Shots_Rapid_Fire_Plus2_raw = value;
                    ChangedItems.Add(nameof(Delay_Between_Shots_Rapid_Fire_Plus2));
                    OnPropertyChanged(nameof(Delay_Between_Shots_Rapid_Fire_Plus2));
                }
            }

            [DisplayName("Offset")]
            public long Delay_Between_Shots_Rapid_Fire_Plus2_offset { get; private set; }

            protected uint Extra_Bullets_Rapid_Fire_Plus2_raw;
            public const string Extra_Bullets_Rapid_Fire_Plus2_displayName = "Extra Bullets: Rapid Fire +2";
            public const int Extra_Bullets_Rapid_Fire_Plus2_sortIndex = 600;
            [SortOrder(Extra_Bullets_Rapid_Fire_Plus2_sortIndex)]
            [DisplayName(Extra_Bullets_Rapid_Fire_Plus2_displayName)]
            public virtual uint Extra_Bullets_Rapid_Fire_Plus2 {
                get => Extra_Bullets_Rapid_Fire_Plus2_raw;
                set {
                    if (Extra_Bullets_Rapid_Fire_Plus2_raw == value) return;
                    Extra_Bullets_Rapid_Fire_Plus2_raw = value;
                    ChangedItems.Add(nameof(Extra_Bullets_Rapid_Fire_Plus2));
                    OnPropertyChanged(nameof(Extra_Bullets_Rapid_Fire_Plus2));
                }
            }

            [DisplayName("Offset")]
            public long Extra_Bullets_Rapid_Fire_Plus2_offset { get; private set; }

            protected float Delay_Between_Shots_Rapid_Fire_Plus3_raw;
            public const string Delay_Between_Shots_Rapid_Fire_Plus3_displayName = "Delay Between Shots: Rapid Fire +3";
            public const int Delay_Between_Shots_Rapid_Fire_Plus3_sortIndex = 650;
            [SortOrder(Delay_Between_Shots_Rapid_Fire_Plus3_sortIndex)]
            [DisplayName(Delay_Between_Shots_Rapid_Fire_Plus3_displayName)]
            public virtual float Delay_Between_Shots_Rapid_Fire_Plus3 {
                get => Delay_Between_Shots_Rapid_Fire_Plus3_raw;
                set {
                    if (Delay_Between_Shots_Rapid_Fire_Plus3_raw == value) return;
                    Delay_Between_Shots_Rapid_Fire_Plus3_raw = value;
                    ChangedItems.Add(nameof(Delay_Between_Shots_Rapid_Fire_Plus3));
                    OnPropertyChanged(nameof(Delay_Between_Shots_Rapid_Fire_Plus3));
                }
            }

            [DisplayName("Offset")]
            public long Delay_Between_Shots_Rapid_Fire_Plus3_offset { get; private set; }

            protected uint Extra_Bullets_Rapid_Fire_Plus3_raw;
            public const string Extra_Bullets_Rapid_Fire_Plus3_displayName = "Extra Bullets: Rapid Fire +3";
            public const int Extra_Bullets_Rapid_Fire_Plus3_sortIndex = 700;
            [SortOrder(Extra_Bullets_Rapid_Fire_Plus3_sortIndex)]
            [DisplayName(Extra_Bullets_Rapid_Fire_Plus3_displayName)]
            public virtual uint Extra_Bullets_Rapid_Fire_Plus3 {
                get => Extra_Bullets_Rapid_Fire_Plus3_raw;
                set {
                    if (Extra_Bullets_Rapid_Fire_Plus3_raw == value) return;
                    Extra_Bullets_Rapid_Fire_Plus3_raw = value;
                    ChangedItems.Add(nameof(Extra_Bullets_Rapid_Fire_Plus3));
                    OnPropertyChanged(nameof(Extra_Bullets_Rapid_Fire_Plus3));
                }
            }

            [DisplayName("Offset")]
            public long Extra_Bullets_Rapid_Fire_Plus3_offset { get; private set; }

            protected float Delay_Between_Shots_Rapid_Fire_Plus4_raw;
            public const string Delay_Between_Shots_Rapid_Fire_Plus4_displayName = "Delay Between Shots: Rapid Fire +4";
            public const int Delay_Between_Shots_Rapid_Fire_Plus4_sortIndex = 750;
            [SortOrder(Delay_Between_Shots_Rapid_Fire_Plus4_sortIndex)]
            [DisplayName(Delay_Between_Shots_Rapid_Fire_Plus4_displayName)]
            public virtual float Delay_Between_Shots_Rapid_Fire_Plus4 {
                get => Delay_Between_Shots_Rapid_Fire_Plus4_raw;
                set {
                    if (Delay_Between_Shots_Rapid_Fire_Plus4_raw == value) return;
                    Delay_Between_Shots_Rapid_Fire_Plus4_raw = value;
                    ChangedItems.Add(nameof(Delay_Between_Shots_Rapid_Fire_Plus4));
                    OnPropertyChanged(nameof(Delay_Between_Shots_Rapid_Fire_Plus4));
                }
            }

            [DisplayName("Offset")]
            public long Delay_Between_Shots_Rapid_Fire_Plus4_offset { get; private set; }

            protected uint Extra_Bullets_Rapid_Fire_Plus4_raw;
            public const string Extra_Bullets_Rapid_Fire_Plus4_displayName = "Extra Bullets: Rapid Fire +4";
            public const int Extra_Bullets_Rapid_Fire_Plus4_sortIndex = 800;
            [SortOrder(Extra_Bullets_Rapid_Fire_Plus4_sortIndex)]
            [DisplayName(Extra_Bullets_Rapid_Fire_Plus4_displayName)]
            public virtual uint Extra_Bullets_Rapid_Fire_Plus4 {
                get => Extra_Bullets_Rapid_Fire_Plus4_raw;
                set {
                    if (Extra_Bullets_Rapid_Fire_Plus4_raw == value) return;
                    Extra_Bullets_Rapid_Fire_Plus4_raw = value;
                    ChangedItems.Add(nameof(Extra_Bullets_Rapid_Fire_Plus4));
                    OnPropertyChanged(nameof(Extra_Bullets_Rapid_Fire_Plus4));
                }
            }

            [DisplayName("Offset")]
            public long Extra_Bullets_Rapid_Fire_Plus4_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_107));
                    OnPropertyChanged(nameof(Unk_107));
                }
            }

            [DisplayName("Offset")]
            public long Unk_107_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_108));
                    OnPropertyChanged(nameof(Unk_108));
                }
            }

            [DisplayName("Offset")]
            public long Unk_108_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_109));
                    OnPropertyChanged(nameof(Unk_109));
                }
            }

            [DisplayName("Offset")]
            public long Unk_109_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_110));
                    OnPropertyChanged(nameof(Unk_110));
                }
            }

            [DisplayName("Offset")]
            public long Unk_110_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_111));
                    OnPropertyChanged(nameof(Unk_111));
                }
            }

            [DisplayName("Offset")]
            public long Unk_111_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_112));
                    OnPropertyChanged(nameof(Unk_112));
                }
            }

            [DisplayName("Offset")]
            public long Unk_112_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_113));
                    OnPropertyChanged(nameof(Unk_113));
                }
            }

            [DisplayName("Offset")]
            public long Unk_113_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_114));
                    OnPropertyChanged(nameof(Unk_114));
                }
            }

            [DisplayName("Offset")]
            public long Unk_114_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_115));
                    OnPropertyChanged(nameof(Unk_115));
                }
            }

            [DisplayName("Offset")]
            public long Unk_115_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_116));
                    OnPropertyChanged(nameof(Unk_116));
                }
            }

            [DisplayName("Offset")]
            public long Unk_116_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_117));
                    OnPropertyChanged(nameof(Unk_117));
                }
            }

            [DisplayName("Offset")]
            public long Unk_117_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_118));
                    OnPropertyChanged(nameof(Unk_118));
                }
            }

            [DisplayName("Offset")]
            public long Unk_118_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_119));
                    OnPropertyChanged(nameof(Unk_119));
                }
            }

            [DisplayName("Offset")]
            public long Unk_119_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_120));
                    OnPropertyChanged(nameof(Unk_120));
                }
            }

            [DisplayName("Offset")]
            public long Unk_120_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_121));
                    OnPropertyChanged(nameof(Unk_121));
                }
            }

            [DisplayName("Offset")]
            public long Unk_121_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_122));
                    OnPropertyChanged(nameof(Unk_122));
                }
            }

            [DisplayName("Offset")]
            public long Unk_122_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_123));
                    OnPropertyChanged(nameof(Unk_123));
                }
            }

            [DisplayName("Offset")]
            public long Unk_123_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_124));
                    OnPropertyChanged(nameof(Unk_124));
                }
            }

            [DisplayName("Offset")]
            public long Unk_124_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_125));
                    OnPropertyChanged(nameof(Unk_125));
                }
            }

            [DisplayName("Offset")]
            public long Unk_125_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_126));
                    OnPropertyChanged(nameof(Unk_126));
                }
            }

            [DisplayName("Offset")]
            public long Unk_126_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_127));
                    OnPropertyChanged(nameof(Unk_127));
                }
            }

            [DisplayName("Offset")]
            public long Unk_127_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_128));
                    OnPropertyChanged(nameof(Unk_128));
                }
            }

            [DisplayName("Offset")]
            public long Unk_128_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_129));
                    OnPropertyChanged(nameof(Unk_129));
                }
            }

            [DisplayName("Offset")]
            public long Unk_129_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_130));
                    OnPropertyChanged(nameof(Unk_130));
                }
            }

            [DisplayName("Offset")]
            public long Unk_130_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_131));
                    OnPropertyChanged(nameof(Unk_131));
                }
            }

            [DisplayName("Offset")]
            public long Unk_131_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_132));
                    OnPropertyChanged(nameof(Unk_132));
                }
            }

            [DisplayName("Offset")]
            public long Unk_132_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_133));
                    OnPropertyChanged(nameof(Unk_133));
                }
            }

            [DisplayName("Offset")]
            public long Unk_133_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_134));
                    OnPropertyChanged(nameof(Unk_134));
                }
            }

            [DisplayName("Offset")]
            public long Unk_134_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_135));
                    OnPropertyChanged(nameof(Unk_135));
                }
            }

            [DisplayName("Offset")]
            public long Unk_135_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_136));
                    OnPropertyChanged(nameof(Unk_136));
                }
            }

            [DisplayName("Offset")]
            public long Unk_136_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_137));
                    OnPropertyChanged(nameof(Unk_137));
                }
            }

            [DisplayName("Offset")]
            public long Unk_137_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_138));
                    OnPropertyChanged(nameof(Unk_138));
                }
            }

            [DisplayName("Offset")]
            public long Unk_138_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_139));
                    OnPropertyChanged(nameof(Unk_139));
                }
            }

            [DisplayName("Offset")]
            public long Unk_139_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_140));
                    OnPropertyChanged(nameof(Unk_140));
                }
            }

            [DisplayName("Offset")]
            public long Unk_140_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_141));
                    OnPropertyChanged(nameof(Unk_141));
                }
            }

            [DisplayName("Offset")]
            public long Unk_141_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_142));
                    OnPropertyChanged(nameof(Unk_142));
                }
            }

            [DisplayName("Offset")]
            public long Unk_142_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_143));
                    OnPropertyChanged(nameof(Unk_143));
                }
            }

            [DisplayName("Offset")]
            public long Unk_143_offset { get; private set; }

            protected float Rapid_Fire_Extra_Round_Damage_Multiplier_raw;
            public const string Rapid_Fire_Extra_Round_Damage_Multiplier_displayName = "Rapid Fire Extra Round Damage Multiplier";
            public const int Rapid_Fire_Extra_Round_Damage_Multiplier_sortIndex = 2700;
            [SortOrder(Rapid_Fire_Extra_Round_Damage_Multiplier_sortIndex)]
            [DisplayName(Rapid_Fire_Extra_Round_Damage_Multiplier_displayName)]
            public virtual float Rapid_Fire_Extra_Round_Damage_Multiplier {
                get => Rapid_Fire_Extra_Round_Damage_Multiplier_raw;
                set {
                    if (Rapid_Fire_Extra_Round_Damage_Multiplier_raw == value) return;
                    Rapid_Fire_Extra_Round_Damage_Multiplier_raw = value;
                    ChangedItems.Add(nameof(Rapid_Fire_Extra_Round_Damage_Multiplier));
                    OnPropertyChanged(nameof(Rapid_Fire_Extra_Round_Damage_Multiplier));
                }
            }

            [DisplayName("Offset")]
            public long Rapid_Fire_Extra_Round_Damage_Multiplier_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_145));
                    OnPropertyChanged(nameof(Unk_145));
                }
            }

            [DisplayName("Offset")]
            public long Unk_145_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_146));
                    OnPropertyChanged(nameof(Unk_146));
                }
            }

            [DisplayName("Offset")]
            public long Unk_146_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_147));
                    OnPropertyChanged(nameof(Unk_147));
                }
            }

            [DisplayName("Offset")]
            public long Unk_147_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_148));
                    OnPropertyChanged(nameof(Unk_148));
                }
            }

            [DisplayName("Offset")]
            public long Unk_148_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_149));
                    OnPropertyChanged(nameof(Unk_149));
                }
            }

            [DisplayName("Offset")]
            public long Unk_149_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_150));
                    OnPropertyChanged(nameof(Unk_150));
                }
            }

            [DisplayName("Offset")]
            public long Unk_150_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_151));
                    OnPropertyChanged(nameof(Unk_151));
                }
            }

            [DisplayName("Offset")]
            public long Unk_151_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_152));
                    OnPropertyChanged(nameof(Unk_152));
                }
            }

            [DisplayName("Offset")]
            public long Unk_152_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_153));
                    OnPropertyChanged(nameof(Unk_153));
                }
            }

            [DisplayName("Offset")]
            public long Unk_153_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_154));
                    OnPropertyChanged(nameof(Unk_154));
                }
            }

            [DisplayName("Offset")]
            public long Unk_154_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_155));
                    OnPropertyChanged(nameof(Unk_155));
                }
            }

            [DisplayName("Offset")]
            public long Unk_155_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_156));
                    OnPropertyChanged(nameof(Unk_156));
                }
            }

            [DisplayName("Offset")]
            public long Unk_156_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_157));
                    OnPropertyChanged(nameof(Unk_157));
                }
            }

            [DisplayName("Offset")]
            public long Unk_157_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_158));
                    OnPropertyChanged(nameof(Unk_158));
                }
            }

            [DisplayName("Offset")]
            public long Unk_158_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_159));
                    OnPropertyChanged(nameof(Unk_159));
                }
            }

            [DisplayName("Offset")]
            public long Unk_159_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_160));
                    OnPropertyChanged(nameof(Unk_160));
                }
            }

            [DisplayName("Offset")]
            public long Unk_160_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_161));
                    OnPropertyChanged(nameof(Unk_161));
                }
            }

            [DisplayName("Offset")]
            public long Unk_161_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_162));
                    OnPropertyChanged(nameof(Unk_162));
                }
            }

            [DisplayName("Offset")]
            public long Unk_162_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_163));
                    OnPropertyChanged(nameof(Unk_163));
                }
            }

            [DisplayName("Offset")]
            public long Unk_163_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_164));
                    OnPropertyChanged(nameof(Unk_164));
                }
            }

            [DisplayName("Offset")]
            public long Unk_164_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_165));
                    OnPropertyChanged(nameof(Unk_165));
                }
            }

            [DisplayName("Offset")]
            public long Unk_165_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_166));
                    OnPropertyChanged(nameof(Unk_166));
                }
            }

            [DisplayName("Offset")]
            public long Unk_166_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_167));
                    OnPropertyChanged(nameof(Unk_167));
                }
            }

            [DisplayName("Offset")]
            public long Unk_167_offset { get; private set; }

            protected float Wyvernheart_Ammo_Cap_raw;
            public const string Wyvernheart_Ammo_Cap_displayName = "Wyvernheart Ammo Cap";
            public const int Wyvernheart_Ammo_Cap_sortIndex = 3900;
            [SortOrder(Wyvernheart_Ammo_Cap_sortIndex)]
            [DisplayName(Wyvernheart_Ammo_Cap_displayName)]
            public virtual float Wyvernheart_Ammo_Cap {
                get => Wyvernheart_Ammo_Cap_raw;
                set {
                    if (Wyvernheart_Ammo_Cap_raw == value) return;
                    Wyvernheart_Ammo_Cap_raw = value;
                    ChangedItems.Add(nameof(Wyvernheart_Ammo_Cap));
                    OnPropertyChanged(nameof(Wyvernheart_Ammo_Cap));
                }
            }

            [DisplayName("Offset")]
            public long Wyvernheart_Ammo_Cap_offset { get; private set; }

            protected float Delay_Between_Shots_raw;
            public const string Delay_Between_Shots_displayName = "Delay Between Shots";
            public const int Delay_Between_Shots_sortIndex = 3950;
            [SortOrder(Delay_Between_Shots_sortIndex)]
            [DisplayName(Delay_Between_Shots_displayName)]
            public virtual float Delay_Between_Shots {
                get => Delay_Between_Shots_raw;
                set {
                    if (Delay_Between_Shots_raw == value) return;
                    Delay_Between_Shots_raw = value;
                    ChangedItems.Add(nameof(Delay_Between_Shots));
                    OnPropertyChanged(nameof(Delay_Between_Shots));
                }
            }

            [DisplayName("Offset")]
            public long Delay_Between_Shots_offset { get; private set; }

            protected float Wyvernheart_Ammo_Consumption_raw;
            public const string Wyvernheart_Ammo_Consumption_displayName = "Wyvernheart Ammo Consumption";
            public const int Wyvernheart_Ammo_Consumption_sortIndex = 4000;
            [SortOrder(Wyvernheart_Ammo_Consumption_sortIndex)]
            [DisplayName(Wyvernheart_Ammo_Consumption_displayName)]
            public virtual float Wyvernheart_Ammo_Consumption {
                get => Wyvernheart_Ammo_Consumption_raw;
                set {
                    if (Wyvernheart_Ammo_Consumption_raw == value) return;
                    Wyvernheart_Ammo_Consumption_raw = value;
                    ChangedItems.Add(nameof(Wyvernheart_Ammo_Consumption));
                    OnPropertyChanged(nameof(Wyvernheart_Ammo_Consumption));
                }
            }

            [DisplayName("Offset")]
            public long Wyvernheart_Ammo_Consumption_offset { get; private set; }

            protected float Wyvernheart_Ammo_Recharge_raw;
            public const string Wyvernheart_Ammo_Recharge_displayName = "Wyvernheart Ammo Recharge";
            public const int Wyvernheart_Ammo_Recharge_sortIndex = 4050;
            [SortOrder(Wyvernheart_Ammo_Recharge_sortIndex)]
            [DisplayName(Wyvernheart_Ammo_Recharge_displayName)]
            public virtual float Wyvernheart_Ammo_Recharge {
                get => Wyvernheart_Ammo_Recharge_raw;
                set {
                    if (Wyvernheart_Ammo_Recharge_raw == value) return;
                    Wyvernheart_Ammo_Recharge_raw = value;
                    ChangedItems.Add(nameof(Wyvernheart_Ammo_Recharge));
                    OnPropertyChanged(nameof(Wyvernheart_Ammo_Recharge));
                }
            }

            [DisplayName("Offset")]
            public long Wyvernheart_Ammo_Recharge_offset { get; private set; }

            protected float Wyvernheart_Vertical_Deviation_raw;
            public const string Wyvernheart_Vertical_Deviation_displayName = "Wyvernheart Vertical Deviation";
            public const int Wyvernheart_Vertical_Deviation_sortIndex = 4100;
            [SortOrder(Wyvernheart_Vertical_Deviation_sortIndex)]
            [DisplayName(Wyvernheart_Vertical_Deviation_displayName)]
            public virtual float Wyvernheart_Vertical_Deviation {
                get => Wyvernheart_Vertical_Deviation_raw;
                set {
                    if (Wyvernheart_Vertical_Deviation_raw == value) return;
                    Wyvernheart_Vertical_Deviation_raw = value;
                    ChangedItems.Add(nameof(Wyvernheart_Vertical_Deviation));
                    OnPropertyChanged(nameof(Wyvernheart_Vertical_Deviation));
                }
            }

            [DisplayName("Offset")]
            public long Wyvernheart_Vertical_Deviation_offset { get; private set; }

            protected float Wyvernheart_Horizontal_Deviation_raw;
            public const string Wyvernheart_Horizontal_Deviation_displayName = "Wyvernheart Horizontal Deviation";
            public const int Wyvernheart_Horizontal_Deviation_sortIndex = 4150;
            [SortOrder(Wyvernheart_Horizontal_Deviation_sortIndex)]
            [DisplayName(Wyvernheart_Horizontal_Deviation_displayName)]
            public virtual float Wyvernheart_Horizontal_Deviation {
                get => Wyvernheart_Horizontal_Deviation_raw;
                set {
                    if (Wyvernheart_Horizontal_Deviation_raw == value) return;
                    Wyvernheart_Horizontal_Deviation_raw = value;
                    ChangedItems.Add(nameof(Wyvernheart_Horizontal_Deviation));
                    OnPropertyChanged(nameof(Wyvernheart_Horizontal_Deviation));
                }
            }

            [DisplayName("Offset")]
            public long Wyvernheart_Horizontal_Deviation_offset { get; private set; }

            protected byte Wyvernheart_Hit_Count_Per_Actual_Hit_raw;
            public const string Wyvernheart_Hit_Count_Per_Actual_Hit_displayName = "Wyvernheart Hit Count Per Actual Hit";
            public const int Wyvernheart_Hit_Count_Per_Actual_Hit_sortIndex = 4200;
            [SortOrder(Wyvernheart_Hit_Count_Per_Actual_Hit_sortIndex)]
            [DisplayName(Wyvernheart_Hit_Count_Per_Actual_Hit_displayName)]
            public virtual byte Wyvernheart_Hit_Count_Per_Actual_Hit {
                get => Wyvernheart_Hit_Count_Per_Actual_Hit_raw;
                set {
                    if (Wyvernheart_Hit_Count_Per_Actual_Hit_raw == value) return;
                    Wyvernheart_Hit_Count_Per_Actual_Hit_raw = value;
                    ChangedItems.Add(nameof(Wyvernheart_Hit_Count_Per_Actual_Hit));
                    OnPropertyChanged(nameof(Wyvernheart_Hit_Count_Per_Actual_Hit));
                }
            }

            [DisplayName("Offset")]
            public long Wyvernheart_Hit_Count_Per_Actual_Hit_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_175));
                    OnPropertyChanged(nameof(Unk_175));
                }
            }

            [DisplayName("Offset")]
            public long Unk_175_offset { get; private set; }

            protected byte Wyvernheart_Hit_Count_Loss_Per_Every_Actual_Loss_Hit_raw;
            public const string Wyvernheart_Hit_Count_Loss_Per_Every_Actual_Loss_Hit_displayName = "Wyvernheart Hit Count Loss Per Every Actual Loss Hit";
            public const int Wyvernheart_Hit_Count_Loss_Per_Every_Actual_Loss_Hit_sortIndex = 4300;
            [SortOrder(Wyvernheart_Hit_Count_Loss_Per_Every_Actual_Loss_Hit_sortIndex)]
            [DisplayName(Wyvernheart_Hit_Count_Loss_Per_Every_Actual_Loss_Hit_displayName)]
            public virtual byte Wyvernheart_Hit_Count_Loss_Per_Every_Actual_Loss_Hit {
                get => Wyvernheart_Hit_Count_Loss_Per_Every_Actual_Loss_Hit_raw;
                set {
                    if (Wyvernheart_Hit_Count_Loss_Per_Every_Actual_Loss_Hit_raw == value) return;
                    Wyvernheart_Hit_Count_Loss_Per_Every_Actual_Loss_Hit_raw = value;
                    ChangedItems.Add(nameof(Wyvernheart_Hit_Count_Loss_Per_Every_Actual_Loss_Hit));
                    OnPropertyChanged(nameof(Wyvernheart_Hit_Count_Loss_Per_Every_Actual_Loss_Hit));
                }
            }

            [DisplayName("Offset")]
            public long Wyvernheart_Hit_Count_Loss_Per_Every_Actual_Loss_Hit_offset { get; private set; }

            protected byte Wyvernheart_Hit_Count_for_Damage_Bonus_raw;
            public const string Wyvernheart_Hit_Count_for_Damage_Bonus_displayName = "Wyvernheart Hit Count for Damage Bonus";
            public const int Wyvernheart_Hit_Count_for_Damage_Bonus_sortIndex = 4350;
            [SortOrder(Wyvernheart_Hit_Count_for_Damage_Bonus_sortIndex)]
            [DisplayName(Wyvernheart_Hit_Count_for_Damage_Bonus_displayName)]
            public virtual byte Wyvernheart_Hit_Count_for_Damage_Bonus {
                get => Wyvernheart_Hit_Count_for_Damage_Bonus_raw;
                set {
                    if (Wyvernheart_Hit_Count_for_Damage_Bonus_raw == value) return;
                    Wyvernheart_Hit_Count_for_Damage_Bonus_raw = value;
                    ChangedItems.Add(nameof(Wyvernheart_Hit_Count_for_Damage_Bonus));
                    OnPropertyChanged(nameof(Wyvernheart_Hit_Count_for_Damage_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long Wyvernheart_Hit_Count_for_Damage_Bonus_offset { get; private set; }

            protected ushort Hit_for_1st_Damage_Bonus_raw;
            public const string Hit_for_1st_Damage_Bonus_displayName = "Hit for 1st Damage Bonus";
            public const int Hit_for_1st_Damage_Bonus_sortIndex = 4400;
            [SortOrder(Hit_for_1st_Damage_Bonus_sortIndex)]
            [DisplayName(Hit_for_1st_Damage_Bonus_displayName)]
            public virtual ushort Hit_for_1st_Damage_Bonus {
                get => Hit_for_1st_Damage_Bonus_raw;
                set {
                    if (Hit_for_1st_Damage_Bonus_raw == value) return;
                    Hit_for_1st_Damage_Bonus_raw = value;
                    ChangedItems.Add(nameof(Hit_for_1st_Damage_Bonus));
                    OnPropertyChanged(nameof(Hit_for_1st_Damage_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long Hit_for_1st_Damage_Bonus_offset { get; private set; }

            protected ushort _1st_Damage_Bonus_raw;
            public const string _1st_Damage_Bonus_displayName = "(1st) Damage Bonus";
            public const int _1st_Damage_Bonus_sortIndex = 4450;
            [SortOrder(_1st_Damage_Bonus_sortIndex)]
            [DisplayName(_1st_Damage_Bonus_displayName)]
            public virtual ushort _1st_Damage_Bonus {
                get => _1st_Damage_Bonus_raw;
                set {
                    if (_1st_Damage_Bonus_raw == value) return;
                    _1st_Damage_Bonus_raw = value;
                    ChangedItems.Add(nameof(_1st_Damage_Bonus));
                    OnPropertyChanged(nameof(_1st_Damage_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long _1st_Damage_Bonus_offset { get; private set; }

            protected ushort Hit_for_2nd_Damage_Bonus_raw;
            public const string Hit_for_2nd_Damage_Bonus_displayName = "Hit for 2nd Damage Bonus";
            public const int Hit_for_2nd_Damage_Bonus_sortIndex = 4500;
            [SortOrder(Hit_for_2nd_Damage_Bonus_sortIndex)]
            [DisplayName(Hit_for_2nd_Damage_Bonus_displayName)]
            public virtual ushort Hit_for_2nd_Damage_Bonus {
                get => Hit_for_2nd_Damage_Bonus_raw;
                set {
                    if (Hit_for_2nd_Damage_Bonus_raw == value) return;
                    Hit_for_2nd_Damage_Bonus_raw = value;
                    ChangedItems.Add(nameof(Hit_for_2nd_Damage_Bonus));
                    OnPropertyChanged(nameof(Hit_for_2nd_Damage_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long Hit_for_2nd_Damage_Bonus_offset { get; private set; }

            protected ushort _2nd_Damage_Bonus_raw;
            public const string _2nd_Damage_Bonus_displayName = "(2nd) Damage Bonus";
            public const int _2nd_Damage_Bonus_sortIndex = 4550;
            [SortOrder(_2nd_Damage_Bonus_sortIndex)]
            [DisplayName(_2nd_Damage_Bonus_displayName)]
            public virtual ushort _2nd_Damage_Bonus {
                get => _2nd_Damage_Bonus_raw;
                set {
                    if (_2nd_Damage_Bonus_raw == value) return;
                    _2nd_Damage_Bonus_raw = value;
                    ChangedItems.Add(nameof(_2nd_Damage_Bonus));
                    OnPropertyChanged(nameof(_2nd_Damage_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long _2nd_Damage_Bonus_offset { get; private set; }

            protected ushort Hit_for_3rd_Damage_Bonus_raw;
            public const string Hit_for_3rd_Damage_Bonus_displayName = "Hit for 3rd Damage Bonus";
            public const int Hit_for_3rd_Damage_Bonus_sortIndex = 4600;
            [SortOrder(Hit_for_3rd_Damage_Bonus_sortIndex)]
            [DisplayName(Hit_for_3rd_Damage_Bonus_displayName)]
            public virtual ushort Hit_for_3rd_Damage_Bonus {
                get => Hit_for_3rd_Damage_Bonus_raw;
                set {
                    if (Hit_for_3rd_Damage_Bonus_raw == value) return;
                    Hit_for_3rd_Damage_Bonus_raw = value;
                    ChangedItems.Add(nameof(Hit_for_3rd_Damage_Bonus));
                    OnPropertyChanged(nameof(Hit_for_3rd_Damage_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long Hit_for_3rd_Damage_Bonus_offset { get; private set; }

            protected ushort _3rd_Damage_Bonus_raw;
            public const string _3rd_Damage_Bonus_displayName = "(3rd) Damage Bonus";
            public const int _3rd_Damage_Bonus_sortIndex = 4650;
            [SortOrder(_3rd_Damage_Bonus_sortIndex)]
            [DisplayName(_3rd_Damage_Bonus_displayName)]
            public virtual ushort _3rd_Damage_Bonus {
                get => _3rd_Damage_Bonus_raw;
                set {
                    if (_3rd_Damage_Bonus_raw == value) return;
                    _3rd_Damage_Bonus_raw = value;
                    ChangedItems.Add(nameof(_3rd_Damage_Bonus));
                    OnPropertyChanged(nameof(_3rd_Damage_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long _3rd_Damage_Bonus_offset { get; private set; }

            protected ushort Hit_for_4th_Damage_Bonus_raw;
            public const string Hit_for_4th_Damage_Bonus_displayName = "Hit for 4th Damage Bonus";
            public const int Hit_for_4th_Damage_Bonus_sortIndex = 4700;
            [SortOrder(Hit_for_4th_Damage_Bonus_sortIndex)]
            [DisplayName(Hit_for_4th_Damage_Bonus_displayName)]
            public virtual ushort Hit_for_4th_Damage_Bonus {
                get => Hit_for_4th_Damage_Bonus_raw;
                set {
                    if (Hit_for_4th_Damage_Bonus_raw == value) return;
                    Hit_for_4th_Damage_Bonus_raw = value;
                    ChangedItems.Add(nameof(Hit_for_4th_Damage_Bonus));
                    OnPropertyChanged(nameof(Hit_for_4th_Damage_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long Hit_for_4th_Damage_Bonus_offset { get; private set; }

            protected ushort _4th_Damage_Bonus_raw;
            public const string _4th_Damage_Bonus_displayName = "(4th) Damage Bonus";
            public const int _4th_Damage_Bonus_sortIndex = 4750;
            [SortOrder(_4th_Damage_Bonus_sortIndex)]
            [DisplayName(_4th_Damage_Bonus_displayName)]
            public virtual ushort _4th_Damage_Bonus {
                get => _4th_Damage_Bonus_raw;
                set {
                    if (_4th_Damage_Bonus_raw == value) return;
                    _4th_Damage_Bonus_raw = value;
                    ChangedItems.Add(nameof(_4th_Damage_Bonus));
                    OnPropertyChanged(nameof(_4th_Damage_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long _4th_Damage_Bonus_offset { get; private set; }

            protected ushort Hit_for_5th_Damage_Bonus_raw;
            public const string Hit_for_5th_Damage_Bonus_displayName = "Hit for 5th Damage Bonus";
            public const int Hit_for_5th_Damage_Bonus_sortIndex = 4800;
            [SortOrder(Hit_for_5th_Damage_Bonus_sortIndex)]
            [DisplayName(Hit_for_5th_Damage_Bonus_displayName)]
            public virtual ushort Hit_for_5th_Damage_Bonus {
                get => Hit_for_5th_Damage_Bonus_raw;
                set {
                    if (Hit_for_5th_Damage_Bonus_raw == value) return;
                    Hit_for_5th_Damage_Bonus_raw = value;
                    ChangedItems.Add(nameof(Hit_for_5th_Damage_Bonus));
                    OnPropertyChanged(nameof(Hit_for_5th_Damage_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long Hit_for_5th_Damage_Bonus_offset { get; private set; }

            protected ushort _5th_Damage_Bonus_raw;
            public const string _5th_Damage_Bonus_displayName = "(5th) Damage Bonus";
            public const int _5th_Damage_Bonus_sortIndex = 4850;
            [SortOrder(_5th_Damage_Bonus_sortIndex)]
            [DisplayName(_5th_Damage_Bonus_displayName)]
            public virtual ushort _5th_Damage_Bonus {
                get => _5th_Damage_Bonus_raw;
                set {
                    if (_5th_Damage_Bonus_raw == value) return;
                    _5th_Damage_Bonus_raw = value;
                    ChangedItems.Add(nameof(_5th_Damage_Bonus));
                    OnPropertyChanged(nameof(_5th_Damage_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long _5th_Damage_Bonus_offset { get; private set; }

            protected byte Wyvernheart_Mod_Hit_Count_Per_Actual_Hit_raw;
            public const string Wyvernheart_Mod_Hit_Count_Per_Actual_Hit_displayName = "Wyvernheart Mod Hit Count Per Actual Hit";
            public const int Wyvernheart_Mod_Hit_Count_Per_Actual_Hit_sortIndex = 4900;
            [SortOrder(Wyvernheart_Mod_Hit_Count_Per_Actual_Hit_sortIndex)]
            [DisplayName(Wyvernheart_Mod_Hit_Count_Per_Actual_Hit_displayName)]
            public virtual byte Wyvernheart_Mod_Hit_Count_Per_Actual_Hit {
                get => Wyvernheart_Mod_Hit_Count_Per_Actual_Hit_raw;
                set {
                    if (Wyvernheart_Mod_Hit_Count_Per_Actual_Hit_raw == value) return;
                    Wyvernheart_Mod_Hit_Count_Per_Actual_Hit_raw = value;
                    ChangedItems.Add(nameof(Wyvernheart_Mod_Hit_Count_Per_Actual_Hit));
                    OnPropertyChanged(nameof(Wyvernheart_Mod_Hit_Count_Per_Actual_Hit));
                }
            }

            [DisplayName("Offset")]
            public long Wyvernheart_Mod_Hit_Count_Per_Actual_Hit_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_189));
                    OnPropertyChanged(nameof(Unk_189));
                }
            }

            [DisplayName("Offset")]
            public long Unk_189_offset { get; private set; }

            protected byte Wyvernheart_Mod_Hit_Count_Loss_Per_Actual_Hit_Loss_raw;
            public const string Wyvernheart_Mod_Hit_Count_Loss_Per_Actual_Hit_Loss_displayName = "Wyvernheart Mod Hit Count Loss Per Actual Hit Loss";
            public const int Wyvernheart_Mod_Hit_Count_Loss_Per_Actual_Hit_Loss_sortIndex = 5000;
            [SortOrder(Wyvernheart_Mod_Hit_Count_Loss_Per_Actual_Hit_Loss_sortIndex)]
            [DisplayName(Wyvernheart_Mod_Hit_Count_Loss_Per_Actual_Hit_Loss_displayName)]
            public virtual byte Wyvernheart_Mod_Hit_Count_Loss_Per_Actual_Hit_Loss {
                get => Wyvernheart_Mod_Hit_Count_Loss_Per_Actual_Hit_Loss_raw;
                set {
                    if (Wyvernheart_Mod_Hit_Count_Loss_Per_Actual_Hit_Loss_raw == value) return;
                    Wyvernheart_Mod_Hit_Count_Loss_Per_Actual_Hit_Loss_raw = value;
                    ChangedItems.Add(nameof(Wyvernheart_Mod_Hit_Count_Loss_Per_Actual_Hit_Loss));
                    OnPropertyChanged(nameof(Wyvernheart_Mod_Hit_Count_Loss_Per_Actual_Hit_Loss));
                }
            }

            [DisplayName("Offset")]
            public long Wyvernheart_Mod_Hit_Count_Loss_Per_Actual_Hit_Loss_offset { get; private set; }

            protected byte Wyvernheart_Mod_Hit_Count_for_Damage_Bonus_raw;
            public const string Wyvernheart_Mod_Hit_Count_for_Damage_Bonus_displayName = "Wyvernheart Mod Hit Count for Damage Bonus";
            public const int Wyvernheart_Mod_Hit_Count_for_Damage_Bonus_sortIndex = 5050;
            [SortOrder(Wyvernheart_Mod_Hit_Count_for_Damage_Bonus_sortIndex)]
            [DisplayName(Wyvernheart_Mod_Hit_Count_for_Damage_Bonus_displayName)]
            public virtual byte Wyvernheart_Mod_Hit_Count_for_Damage_Bonus {
                get => Wyvernheart_Mod_Hit_Count_for_Damage_Bonus_raw;
                set {
                    if (Wyvernheart_Mod_Hit_Count_for_Damage_Bonus_raw == value) return;
                    Wyvernheart_Mod_Hit_Count_for_Damage_Bonus_raw = value;
                    ChangedItems.Add(nameof(Wyvernheart_Mod_Hit_Count_for_Damage_Bonus));
                    OnPropertyChanged(nameof(Wyvernheart_Mod_Hit_Count_for_Damage_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long Wyvernheart_Mod_Hit_Count_for_Damage_Bonus_offset { get; private set; }

            protected ushort _Mod_Hit_for_1st_Damage_Bonus_raw;
            public const string _Mod_Hit_for_1st_Damage_Bonus_displayName = "(Mod) Hit for 1st Damage Bonus";
            public const int _Mod_Hit_for_1st_Damage_Bonus_sortIndex = 5100;
            [SortOrder(_Mod_Hit_for_1st_Damage_Bonus_sortIndex)]
            [DisplayName(_Mod_Hit_for_1st_Damage_Bonus_displayName)]
            public virtual ushort _Mod_Hit_for_1st_Damage_Bonus {
                get => _Mod_Hit_for_1st_Damage_Bonus_raw;
                set {
                    if (_Mod_Hit_for_1st_Damage_Bonus_raw == value) return;
                    _Mod_Hit_for_1st_Damage_Bonus_raw = value;
                    ChangedItems.Add(nameof(_Mod_Hit_for_1st_Damage_Bonus));
                    OnPropertyChanged(nameof(_Mod_Hit_for_1st_Damage_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long _Mod_Hit_for_1st_Damage_Bonus_offset { get; private set; }

            protected ushort _Mod_1st_Damage_Bonus_raw;
            public const string _Mod_1st_Damage_Bonus_displayName = "(Mod, 1st) Damage Bonus";
            public const int _Mod_1st_Damage_Bonus_sortIndex = 5150;
            [SortOrder(_Mod_1st_Damage_Bonus_sortIndex)]
            [DisplayName(_Mod_1st_Damage_Bonus_displayName)]
            public virtual ushort _Mod_1st_Damage_Bonus {
                get => _Mod_1st_Damage_Bonus_raw;
                set {
                    if (_Mod_1st_Damage_Bonus_raw == value) return;
                    _Mod_1st_Damage_Bonus_raw = value;
                    ChangedItems.Add(nameof(_Mod_1st_Damage_Bonus));
                    OnPropertyChanged(nameof(_Mod_1st_Damage_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long _Mod_1st_Damage_Bonus_offset { get; private set; }

            protected ushort _Mod_Hit_for_2nd_Damage_Bonus_raw;
            public const string _Mod_Hit_for_2nd_Damage_Bonus_displayName = "(Mod) Hit for 2nd Damage Bonus";
            public const int _Mod_Hit_for_2nd_Damage_Bonus_sortIndex = 5200;
            [SortOrder(_Mod_Hit_for_2nd_Damage_Bonus_sortIndex)]
            [DisplayName(_Mod_Hit_for_2nd_Damage_Bonus_displayName)]
            public virtual ushort _Mod_Hit_for_2nd_Damage_Bonus {
                get => _Mod_Hit_for_2nd_Damage_Bonus_raw;
                set {
                    if (_Mod_Hit_for_2nd_Damage_Bonus_raw == value) return;
                    _Mod_Hit_for_2nd_Damage_Bonus_raw = value;
                    ChangedItems.Add(nameof(_Mod_Hit_for_2nd_Damage_Bonus));
                    OnPropertyChanged(nameof(_Mod_Hit_for_2nd_Damage_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long _Mod_Hit_for_2nd_Damage_Bonus_offset { get; private set; }

            protected ushort _Mod_2nd_Damage_Bonus_raw;
            public const string _Mod_2nd_Damage_Bonus_displayName = "(Mod, 2nd) Damage Bonus";
            public const int _Mod_2nd_Damage_Bonus_sortIndex = 5250;
            [SortOrder(_Mod_2nd_Damage_Bonus_sortIndex)]
            [DisplayName(_Mod_2nd_Damage_Bonus_displayName)]
            public virtual ushort _Mod_2nd_Damage_Bonus {
                get => _Mod_2nd_Damage_Bonus_raw;
                set {
                    if (_Mod_2nd_Damage_Bonus_raw == value) return;
                    _Mod_2nd_Damage_Bonus_raw = value;
                    ChangedItems.Add(nameof(_Mod_2nd_Damage_Bonus));
                    OnPropertyChanged(nameof(_Mod_2nd_Damage_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long _Mod_2nd_Damage_Bonus_offset { get; private set; }

            protected ushort _Mod_Hit_for_3rd_Damage_Bonus_raw;
            public const string _Mod_Hit_for_3rd_Damage_Bonus_displayName = "(Mod) Hit for 3rd Damage Bonus";
            public const int _Mod_Hit_for_3rd_Damage_Bonus_sortIndex = 5300;
            [SortOrder(_Mod_Hit_for_3rd_Damage_Bonus_sortIndex)]
            [DisplayName(_Mod_Hit_for_3rd_Damage_Bonus_displayName)]
            public virtual ushort _Mod_Hit_for_3rd_Damage_Bonus {
                get => _Mod_Hit_for_3rd_Damage_Bonus_raw;
                set {
                    if (_Mod_Hit_for_3rd_Damage_Bonus_raw == value) return;
                    _Mod_Hit_for_3rd_Damage_Bonus_raw = value;
                    ChangedItems.Add(nameof(_Mod_Hit_for_3rd_Damage_Bonus));
                    OnPropertyChanged(nameof(_Mod_Hit_for_3rd_Damage_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long _Mod_Hit_for_3rd_Damage_Bonus_offset { get; private set; }

            protected ushort _Mod_3rd_Damage_Bonus_raw;
            public const string _Mod_3rd_Damage_Bonus_displayName = "(Mod, 3rd) Damage Bonus";
            public const int _Mod_3rd_Damage_Bonus_sortIndex = 5350;
            [SortOrder(_Mod_3rd_Damage_Bonus_sortIndex)]
            [DisplayName(_Mod_3rd_Damage_Bonus_displayName)]
            public virtual ushort _Mod_3rd_Damage_Bonus {
                get => _Mod_3rd_Damage_Bonus_raw;
                set {
                    if (_Mod_3rd_Damage_Bonus_raw == value) return;
                    _Mod_3rd_Damage_Bonus_raw = value;
                    ChangedItems.Add(nameof(_Mod_3rd_Damage_Bonus));
                    OnPropertyChanged(nameof(_Mod_3rd_Damage_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long _Mod_3rd_Damage_Bonus_offset { get; private set; }

            protected ushort _Mod_Hit_for_4th_Damage_Bonus_raw;
            public const string _Mod_Hit_for_4th_Damage_Bonus_displayName = "(Mod) Hit for 4th Damage Bonus";
            public const int _Mod_Hit_for_4th_Damage_Bonus_sortIndex = 5400;
            [SortOrder(_Mod_Hit_for_4th_Damage_Bonus_sortIndex)]
            [DisplayName(_Mod_Hit_for_4th_Damage_Bonus_displayName)]
            public virtual ushort _Mod_Hit_for_4th_Damage_Bonus {
                get => _Mod_Hit_for_4th_Damage_Bonus_raw;
                set {
                    if (_Mod_Hit_for_4th_Damage_Bonus_raw == value) return;
                    _Mod_Hit_for_4th_Damage_Bonus_raw = value;
                    ChangedItems.Add(nameof(_Mod_Hit_for_4th_Damage_Bonus));
                    OnPropertyChanged(nameof(_Mod_Hit_for_4th_Damage_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long _Mod_Hit_for_4th_Damage_Bonus_offset { get; private set; }

            protected ushort _Mod_4th_Damage_Bonus_raw;
            public const string _Mod_4th_Damage_Bonus_displayName = "(Mod, 4th) Damage Bonus";
            public const int _Mod_4th_Damage_Bonus_sortIndex = 5450;
            [SortOrder(_Mod_4th_Damage_Bonus_sortIndex)]
            [DisplayName(_Mod_4th_Damage_Bonus_displayName)]
            public virtual ushort _Mod_4th_Damage_Bonus {
                get => _Mod_4th_Damage_Bonus_raw;
                set {
                    if (_Mod_4th_Damage_Bonus_raw == value) return;
                    _Mod_4th_Damage_Bonus_raw = value;
                    ChangedItems.Add(nameof(_Mod_4th_Damage_Bonus));
                    OnPropertyChanged(nameof(_Mod_4th_Damage_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long _Mod_4th_Damage_Bonus_offset { get; private set; }

            protected ushort _Mod_Hit_for_5th_Damage_Bonus_raw;
            public const string _Mod_Hit_for_5th_Damage_Bonus_displayName = "(Mod) Hit for 5th Damage Bonus";
            public const int _Mod_Hit_for_5th_Damage_Bonus_sortIndex = 5500;
            [SortOrder(_Mod_Hit_for_5th_Damage_Bonus_sortIndex)]
            [DisplayName(_Mod_Hit_for_5th_Damage_Bonus_displayName)]
            public virtual ushort _Mod_Hit_for_5th_Damage_Bonus {
                get => _Mod_Hit_for_5th_Damage_Bonus_raw;
                set {
                    if (_Mod_Hit_for_5th_Damage_Bonus_raw == value) return;
                    _Mod_Hit_for_5th_Damage_Bonus_raw = value;
                    ChangedItems.Add(nameof(_Mod_Hit_for_5th_Damage_Bonus));
                    OnPropertyChanged(nameof(_Mod_Hit_for_5th_Damage_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long _Mod_Hit_for_5th_Damage_Bonus_offset { get; private set; }

            protected ushort _Mod_5th_Damage_Bonus_raw;
            public const string _Mod_5th_Damage_Bonus_displayName = "(Mod, 5th) Damage Bonus";
            public const int _Mod_5th_Damage_Bonus_sortIndex = 5550;
            [SortOrder(_Mod_5th_Damage_Bonus_sortIndex)]
            [DisplayName(_Mod_5th_Damage_Bonus_displayName)]
            public virtual ushort _Mod_5th_Damage_Bonus {
                get => _Mod_5th_Damage_Bonus_raw;
                set {
                    if (_Mod_5th_Damage_Bonus_raw == value) return;
                    _Mod_5th_Damage_Bonus_raw = value;
                    ChangedItems.Add(nameof(_Mod_5th_Damage_Bonus));
                    OnPropertyChanged(nameof(_Mod_5th_Damage_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long _Mod_5th_Damage_Bonus_offset { get; private set; }

            protected ushort _Mod_Hit_for_6th_Damage_Bonus_raw;
            public const string _Mod_Hit_for_6th_Damage_Bonus_displayName = "(Mod) Hit for 6th Damage Bonus";
            public const int _Mod_Hit_for_6th_Damage_Bonus_sortIndex = 5600;
            [SortOrder(_Mod_Hit_for_6th_Damage_Bonus_sortIndex)]
            [DisplayName(_Mod_Hit_for_6th_Damage_Bonus_displayName)]
            public virtual ushort _Mod_Hit_for_6th_Damage_Bonus {
                get => _Mod_Hit_for_6th_Damage_Bonus_raw;
                set {
                    if (_Mod_Hit_for_6th_Damage_Bonus_raw == value) return;
                    _Mod_Hit_for_6th_Damage_Bonus_raw = value;
                    ChangedItems.Add(nameof(_Mod_Hit_for_6th_Damage_Bonus));
                    OnPropertyChanged(nameof(_Mod_Hit_for_6th_Damage_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long _Mod_Hit_for_6th_Damage_Bonus_offset { get; private set; }

            protected ushort _Mod_6th_Damage_Bonus_raw;
            public const string _Mod_6th_Damage_Bonus_displayName = "(Mod, 6th) Damage Bonus";
            public const int _Mod_6th_Damage_Bonus_sortIndex = 5650;
            [SortOrder(_Mod_6th_Damage_Bonus_sortIndex)]
            [DisplayName(_Mod_6th_Damage_Bonus_displayName)]
            public virtual ushort _Mod_6th_Damage_Bonus {
                get => _Mod_6th_Damage_Bonus_raw;
                set {
                    if (_Mod_6th_Damage_Bonus_raw == value) return;
                    _Mod_6th_Damage_Bonus_raw = value;
                    ChangedItems.Add(nameof(_Mod_6th_Damage_Bonus));
                    OnPropertyChanged(nameof(_Mod_6th_Damage_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long _Mod_6th_Damage_Bonus_offset { get; private set; }

            protected ushort _Mod_Hit_for_7th_Damage_Bonus_raw;
            public const string _Mod_Hit_for_7th_Damage_Bonus_displayName = "(Mod) Hit for 7th Damage Bonus";
            public const int _Mod_Hit_for_7th_Damage_Bonus_sortIndex = 5700;
            [SortOrder(_Mod_Hit_for_7th_Damage_Bonus_sortIndex)]
            [DisplayName(_Mod_Hit_for_7th_Damage_Bonus_displayName)]
            public virtual ushort _Mod_Hit_for_7th_Damage_Bonus {
                get => _Mod_Hit_for_7th_Damage_Bonus_raw;
                set {
                    if (_Mod_Hit_for_7th_Damage_Bonus_raw == value) return;
                    _Mod_Hit_for_7th_Damage_Bonus_raw = value;
                    ChangedItems.Add(nameof(_Mod_Hit_for_7th_Damage_Bonus));
                    OnPropertyChanged(nameof(_Mod_Hit_for_7th_Damage_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long _Mod_Hit_for_7th_Damage_Bonus_offset { get; private set; }

            protected ushort _Mod_7th_Damage_Bonus_raw;
            public const string _Mod_7th_Damage_Bonus_displayName = "(Mod, 7th) Damage Bonus";
            public const int _Mod_7th_Damage_Bonus_sortIndex = 5750;
            [SortOrder(_Mod_7th_Damage_Bonus_sortIndex)]
            [DisplayName(_Mod_7th_Damage_Bonus_displayName)]
            public virtual ushort _Mod_7th_Damage_Bonus {
                get => _Mod_7th_Damage_Bonus_raw;
                set {
                    if (_Mod_7th_Damage_Bonus_raw == value) return;
                    _Mod_7th_Damage_Bonus_raw = value;
                    ChangedItems.Add(nameof(_Mod_7th_Damage_Bonus));
                    OnPropertyChanged(nameof(_Mod_7th_Damage_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long _Mod_7th_Damage_Bonus_offset { get; private set; }

            protected ushort _Mod_Hit_for_8th_Damage_Bonus_raw;
            public const string _Mod_Hit_for_8th_Damage_Bonus_displayName = "(Mod) Hit for 8th Damage Bonus";
            public const int _Mod_Hit_for_8th_Damage_Bonus_sortIndex = 5800;
            [SortOrder(_Mod_Hit_for_8th_Damage_Bonus_sortIndex)]
            [DisplayName(_Mod_Hit_for_8th_Damage_Bonus_displayName)]
            public virtual ushort _Mod_Hit_for_8th_Damage_Bonus {
                get => _Mod_Hit_for_8th_Damage_Bonus_raw;
                set {
                    if (_Mod_Hit_for_8th_Damage_Bonus_raw == value) return;
                    _Mod_Hit_for_8th_Damage_Bonus_raw = value;
                    ChangedItems.Add(nameof(_Mod_Hit_for_8th_Damage_Bonus));
                    OnPropertyChanged(nameof(_Mod_Hit_for_8th_Damage_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long _Mod_Hit_for_8th_Damage_Bonus_offset { get; private set; }

            protected ushort _Mod_8th_Damage_Bonus_raw;
            public const string _Mod_8th_Damage_Bonus_displayName = "(Mod, 8th) Damage Bonus";
            public const int _Mod_8th_Damage_Bonus_sortIndex = 5850;
            [SortOrder(_Mod_8th_Damage_Bonus_sortIndex)]
            [DisplayName(_Mod_8th_Damage_Bonus_displayName)]
            public virtual ushort _Mod_8th_Damage_Bonus {
                get => _Mod_8th_Damage_Bonus_raw;
                set {
                    if (_Mod_8th_Damage_Bonus_raw == value) return;
                    _Mod_8th_Damage_Bonus_raw = value;
                    ChangedItems.Add(nameof(_Mod_8th_Damage_Bonus));
                    OnPropertyChanged(nameof(_Mod_8th_Damage_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long _Mod_8th_Damage_Bonus_offset { get; private set; }

            protected ushort _Mod_Hit_for_9th_Damage_Bonus_raw;
            public const string _Mod_Hit_for_9th_Damage_Bonus_displayName = "(Mod) Hit for 9th Damage Bonus";
            public const int _Mod_Hit_for_9th_Damage_Bonus_sortIndex = 5900;
            [SortOrder(_Mod_Hit_for_9th_Damage_Bonus_sortIndex)]
            [DisplayName(_Mod_Hit_for_9th_Damage_Bonus_displayName)]
            public virtual ushort _Mod_Hit_for_9th_Damage_Bonus {
                get => _Mod_Hit_for_9th_Damage_Bonus_raw;
                set {
                    if (_Mod_Hit_for_9th_Damage_Bonus_raw == value) return;
                    _Mod_Hit_for_9th_Damage_Bonus_raw = value;
                    ChangedItems.Add(nameof(_Mod_Hit_for_9th_Damage_Bonus));
                    OnPropertyChanged(nameof(_Mod_Hit_for_9th_Damage_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long _Mod_Hit_for_9th_Damage_Bonus_offset { get; private set; }

            protected ushort _Mod_9th_Damage_Bonus_raw;
            public const string _Mod_9th_Damage_Bonus_displayName = "(Mod, 9th) Damage Bonus";
            public const int _Mod_9th_Damage_Bonus_sortIndex = 5950;
            [SortOrder(_Mod_9th_Damage_Bonus_sortIndex)]
            [DisplayName(_Mod_9th_Damage_Bonus_displayName)]
            public virtual ushort _Mod_9th_Damage_Bonus {
                get => _Mod_9th_Damage_Bonus_raw;
                set {
                    if (_Mod_9th_Damage_Bonus_raw == value) return;
                    _Mod_9th_Damage_Bonus_raw = value;
                    ChangedItems.Add(nameof(_Mod_9th_Damage_Bonus));
                    OnPropertyChanged(nameof(_Mod_9th_Damage_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long _Mod_9th_Damage_Bonus_offset { get; private set; }

            protected ushort _Mod_Hit_for_10th_Damage_Bonus_raw;
            public const string _Mod_Hit_for_10th_Damage_Bonus_displayName = "(Mod) Hit for 10th Damage Bonus";
            public const int _Mod_Hit_for_10th_Damage_Bonus_sortIndex = 6000;
            [SortOrder(_Mod_Hit_for_10th_Damage_Bonus_sortIndex)]
            [DisplayName(_Mod_Hit_for_10th_Damage_Bonus_displayName)]
            public virtual ushort _Mod_Hit_for_10th_Damage_Bonus {
                get => _Mod_Hit_for_10th_Damage_Bonus_raw;
                set {
                    if (_Mod_Hit_for_10th_Damage_Bonus_raw == value) return;
                    _Mod_Hit_for_10th_Damage_Bonus_raw = value;
                    ChangedItems.Add(nameof(_Mod_Hit_for_10th_Damage_Bonus));
                    OnPropertyChanged(nameof(_Mod_Hit_for_10th_Damage_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long _Mod_Hit_for_10th_Damage_Bonus_offset { get; private set; }

            protected ushort _Mod_10th_Damage_Bonus_raw;
            public const string _Mod_10th_Damage_Bonus_displayName = "(Mod, 10th) Damage Bonus";
            public const int _Mod_10th_Damage_Bonus_sortIndex = 6050;
            [SortOrder(_Mod_10th_Damage_Bonus_sortIndex)]
            [DisplayName(_Mod_10th_Damage_Bonus_displayName)]
            public virtual ushort _Mod_10th_Damage_Bonus {
                get => _Mod_10th_Damage_Bonus_raw;
                set {
                    if (_Mod_10th_Damage_Bonus_raw == value) return;
                    _Mod_10th_Damage_Bonus_raw = value;
                    ChangedItems.Add(nameof(_Mod_10th_Damage_Bonus));
                    OnPropertyChanged(nameof(_Mod_10th_Damage_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long _Mod_10th_Damage_Bonus_offset { get; private set; }

            public const int lastSortIndex = 6100;

            public static ObservableMhwStructCollection<W13p_Params_5_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<W13p_Params_5_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W13p_Params_5_ LoadData(BinaryReader reader, ulong i) {
                var data = new W13p_Params_5_();
                data.Index = i;
                data.Unk_91_offset = reader.BaseStream.Position;
                data.Unk_91_raw = reader.ReadSingle();
                data.Unk_92_offset = reader.BaseStream.Position;
                data.Unk_92_raw = reader.ReadSingle();
                data.Unk_93_offset = reader.BaseStream.Position;
                data.Unk_93_raw = reader.ReadSingle();
                data.Unk_94_offset = reader.BaseStream.Position;
                data.Unk_94_raw = reader.ReadSingle();
                data.Unk_95_offset = reader.BaseStream.Position;
                data.Unk_95_raw = reader.ReadSingle();
                data.Unk_96_offset = reader.BaseStream.Position;
                data.Unk_96_raw = reader.ReadSingle();
                data.Unk_97_offset = reader.BaseStream.Position;
                data.Unk_97_raw = reader.ReadSingle();
                data.Unk_98_offset = reader.BaseStream.Position;
                data.Unk_98_raw = reader.ReadSingle();
                data.Delay_Between_Shots_Rapid_Fire_Plus1_offset = reader.BaseStream.Position;
                data.Delay_Between_Shots_Rapid_Fire_Plus1_raw = reader.ReadSingle();
                data.Extra_Bullets_Rapid_Fire_Plus1_offset = reader.BaseStream.Position;
                data.Extra_Bullets_Rapid_Fire_Plus1_raw = reader.ReadUInt32();
                data.Delay_Between_Shots_Rapid_Fire_Plus2_offset = reader.BaseStream.Position;
                data.Delay_Between_Shots_Rapid_Fire_Plus2_raw = reader.ReadSingle();
                data.Extra_Bullets_Rapid_Fire_Plus2_offset = reader.BaseStream.Position;
                data.Extra_Bullets_Rapid_Fire_Plus2_raw = reader.ReadUInt32();
                data.Delay_Between_Shots_Rapid_Fire_Plus3_offset = reader.BaseStream.Position;
                data.Delay_Between_Shots_Rapid_Fire_Plus3_raw = reader.ReadSingle();
                data.Extra_Bullets_Rapid_Fire_Plus3_offset = reader.BaseStream.Position;
                data.Extra_Bullets_Rapid_Fire_Plus3_raw = reader.ReadUInt32();
                data.Delay_Between_Shots_Rapid_Fire_Plus4_offset = reader.BaseStream.Position;
                data.Delay_Between_Shots_Rapid_Fire_Plus4_raw = reader.ReadSingle();
                data.Extra_Bullets_Rapid_Fire_Plus4_offset = reader.BaseStream.Position;
                data.Extra_Bullets_Rapid_Fire_Plus4_raw = reader.ReadUInt32();
                data.Unk_107_offset = reader.BaseStream.Position;
                data.Unk_107_raw = reader.ReadSingle();
                data.Unk_108_offset = reader.BaseStream.Position;
                data.Unk_108_raw = reader.ReadSingle();
                data.Unk_109_offset = reader.BaseStream.Position;
                data.Unk_109_raw = reader.ReadSingle();
                data.Unk_110_offset = reader.BaseStream.Position;
                data.Unk_110_raw = reader.ReadSingle();
                data.Unk_111_offset = reader.BaseStream.Position;
                data.Unk_111_raw = reader.ReadSingle();
                data.Unk_112_offset = reader.BaseStream.Position;
                data.Unk_112_raw = reader.ReadSingle();
                data.Unk_113_offset = reader.BaseStream.Position;
                data.Unk_113_raw = reader.ReadSingle();
                data.Unk_114_offset = reader.BaseStream.Position;
                data.Unk_114_raw = reader.ReadSingle();
                data.Unk_115_offset = reader.BaseStream.Position;
                data.Unk_115_raw = reader.ReadSingle();
                data.Unk_116_offset = reader.BaseStream.Position;
                data.Unk_116_raw = reader.ReadSingle();
                data.Unk_117_offset = reader.BaseStream.Position;
                data.Unk_117_raw = reader.ReadSingle();
                data.Unk_118_offset = reader.BaseStream.Position;
                data.Unk_118_raw = reader.ReadSingle();
                data.Unk_119_offset = reader.BaseStream.Position;
                data.Unk_119_raw = reader.ReadSingle();
                data.Unk_120_offset = reader.BaseStream.Position;
                data.Unk_120_raw = reader.ReadSingle();
                data.Unk_121_offset = reader.BaseStream.Position;
                data.Unk_121_raw = reader.ReadSingle();
                data.Unk_122_offset = reader.BaseStream.Position;
                data.Unk_122_raw = reader.ReadSingle();
                data.Unk_123_offset = reader.BaseStream.Position;
                data.Unk_123_raw = reader.ReadSingle();
                data.Unk_124_offset = reader.BaseStream.Position;
                data.Unk_124_raw = reader.ReadSingle();
                data.Unk_125_offset = reader.BaseStream.Position;
                data.Unk_125_raw = reader.ReadSingle();
                data.Unk_126_offset = reader.BaseStream.Position;
                data.Unk_126_raw = reader.ReadSingle();
                data.Unk_127_offset = reader.BaseStream.Position;
                data.Unk_127_raw = reader.ReadSingle();
                data.Unk_128_offset = reader.BaseStream.Position;
                data.Unk_128_raw = reader.ReadSingle();
                data.Unk_129_offset = reader.BaseStream.Position;
                data.Unk_129_raw = reader.ReadSingle();
                data.Unk_130_offset = reader.BaseStream.Position;
                data.Unk_130_raw = reader.ReadSingle();
                data.Unk_131_offset = reader.BaseStream.Position;
                data.Unk_131_raw = reader.ReadSingle();
                data.Unk_132_offset = reader.BaseStream.Position;
                data.Unk_132_raw = reader.ReadSingle();
                data.Unk_133_offset = reader.BaseStream.Position;
                data.Unk_133_raw = reader.ReadSingle();
                data.Unk_134_offset = reader.BaseStream.Position;
                data.Unk_134_raw = reader.ReadSingle();
                data.Unk_135_offset = reader.BaseStream.Position;
                data.Unk_135_raw = reader.ReadSingle();
                data.Unk_136_offset = reader.BaseStream.Position;
                data.Unk_136_raw = reader.ReadSingle();
                data.Unk_137_offset = reader.BaseStream.Position;
                data.Unk_137_raw = reader.ReadSingle();
                data.Unk_138_offset = reader.BaseStream.Position;
                data.Unk_138_raw = reader.ReadSingle();
                data.Unk_139_offset = reader.BaseStream.Position;
                data.Unk_139_raw = reader.ReadSingle();
                data.Unk_140_offset = reader.BaseStream.Position;
                data.Unk_140_raw = reader.ReadSingle();
                data.Unk_141_offset = reader.BaseStream.Position;
                data.Unk_141_raw = reader.ReadSingle();
                data.Unk_142_offset = reader.BaseStream.Position;
                data.Unk_142_raw = reader.ReadSingle();
                data.Unk_143_offset = reader.BaseStream.Position;
                data.Unk_143_raw = reader.ReadSingle();
                data.Rapid_Fire_Extra_Round_Damage_Multiplier_offset = reader.BaseStream.Position;
                data.Rapid_Fire_Extra_Round_Damage_Multiplier_raw = reader.ReadSingle();
                data.Unk_145_offset = reader.BaseStream.Position;
                data.Unk_145_raw = reader.ReadSingle();
                data.Unk_146_offset = reader.BaseStream.Position;
                data.Unk_146_raw = reader.ReadSingle();
                data.Unk_147_offset = reader.BaseStream.Position;
                data.Unk_147_raw = reader.ReadSingle();
                data.Unk_148_offset = reader.BaseStream.Position;
                data.Unk_148_raw = reader.ReadSingle();
                data.Unk_149_offset = reader.BaseStream.Position;
                data.Unk_149_raw = reader.ReadSingle();
                data.Unk_150_offset = reader.BaseStream.Position;
                data.Unk_150_raw = reader.ReadSingle();
                data.Unk_151_offset = reader.BaseStream.Position;
                data.Unk_151_raw = reader.ReadSingle();
                data.Unk_152_offset = reader.BaseStream.Position;
                data.Unk_152_raw = reader.ReadSingle();
                data.Unk_153_offset = reader.BaseStream.Position;
                data.Unk_153_raw = reader.ReadSingle();
                data.Unk_154_offset = reader.BaseStream.Position;
                data.Unk_154_raw = reader.ReadSingle();
                data.Unk_155_offset = reader.BaseStream.Position;
                data.Unk_155_raw = reader.ReadSingle();
                data.Unk_156_offset = reader.BaseStream.Position;
                data.Unk_156_raw = reader.ReadSingle();
                data.Unk_157_offset = reader.BaseStream.Position;
                data.Unk_157_raw = reader.ReadSingle();
                data.Unk_158_offset = reader.BaseStream.Position;
                data.Unk_158_raw = reader.ReadSingle();
                data.Unk_159_offset = reader.BaseStream.Position;
                data.Unk_159_raw = reader.ReadSingle();
                data.Unk_160_offset = reader.BaseStream.Position;
                data.Unk_160_raw = reader.ReadSingle();
                data.Unk_161_offset = reader.BaseStream.Position;
                data.Unk_161_raw = reader.ReadSingle();
                data.Unk_162_offset = reader.BaseStream.Position;
                data.Unk_162_raw = reader.ReadSingle();
                data.Unk_163_offset = reader.BaseStream.Position;
                data.Unk_163_raw = reader.ReadSingle();
                data.Unk_164_offset = reader.BaseStream.Position;
                data.Unk_164_raw = reader.ReadSingle();
                data.Unk_165_offset = reader.BaseStream.Position;
                data.Unk_165_raw = reader.ReadSingle();
                data.Unk_166_offset = reader.BaseStream.Position;
                data.Unk_166_raw = reader.ReadSingle();
                data.Unk_167_offset = reader.BaseStream.Position;
                data.Unk_167_raw = reader.ReadSingle();
                data.Wyvernheart_Ammo_Cap_offset = reader.BaseStream.Position;
                data.Wyvernheart_Ammo_Cap_raw = reader.ReadSingle();
                data.Delay_Between_Shots_offset = reader.BaseStream.Position;
                data.Delay_Between_Shots_raw = reader.ReadSingle();
                data.Wyvernheart_Ammo_Consumption_offset = reader.BaseStream.Position;
                data.Wyvernheart_Ammo_Consumption_raw = reader.ReadSingle();
                data.Wyvernheart_Ammo_Recharge_offset = reader.BaseStream.Position;
                data.Wyvernheart_Ammo_Recharge_raw = reader.ReadSingle();
                data.Wyvernheart_Vertical_Deviation_offset = reader.BaseStream.Position;
                data.Wyvernheart_Vertical_Deviation_raw = reader.ReadSingle();
                data.Wyvernheart_Horizontal_Deviation_offset = reader.BaseStream.Position;
                data.Wyvernheart_Horizontal_Deviation_raw = reader.ReadSingle();
                data.Wyvernheart_Hit_Count_Per_Actual_Hit_offset = reader.BaseStream.Position;
                data.Wyvernheart_Hit_Count_Per_Actual_Hit_raw = reader.ReadByte();
                data.Unk_175_offset = reader.BaseStream.Position;
                data.Unk_175_raw = reader.ReadByte();
                data.Wyvernheart_Hit_Count_Loss_Per_Every_Actual_Loss_Hit_offset = reader.BaseStream.Position;
                data.Wyvernheart_Hit_Count_Loss_Per_Every_Actual_Loss_Hit_raw = reader.ReadByte();
                data.Wyvernheart_Hit_Count_for_Damage_Bonus_offset = reader.BaseStream.Position;
                data.Wyvernheart_Hit_Count_for_Damage_Bonus_raw = reader.ReadByte();
                data.Hit_for_1st_Damage_Bonus_offset = reader.BaseStream.Position;
                data.Hit_for_1st_Damage_Bonus_raw = reader.ReadUInt16();
                data._1st_Damage_Bonus_offset = reader.BaseStream.Position;
                data._1st_Damage_Bonus_raw = reader.ReadUInt16();
                data.Hit_for_2nd_Damage_Bonus_offset = reader.BaseStream.Position;
                data.Hit_for_2nd_Damage_Bonus_raw = reader.ReadUInt16();
                data._2nd_Damage_Bonus_offset = reader.BaseStream.Position;
                data._2nd_Damage_Bonus_raw = reader.ReadUInt16();
                data.Hit_for_3rd_Damage_Bonus_offset = reader.BaseStream.Position;
                data.Hit_for_3rd_Damage_Bonus_raw = reader.ReadUInt16();
                data._3rd_Damage_Bonus_offset = reader.BaseStream.Position;
                data._3rd_Damage_Bonus_raw = reader.ReadUInt16();
                data.Hit_for_4th_Damage_Bonus_offset = reader.BaseStream.Position;
                data.Hit_for_4th_Damage_Bonus_raw = reader.ReadUInt16();
                data._4th_Damage_Bonus_offset = reader.BaseStream.Position;
                data._4th_Damage_Bonus_raw = reader.ReadUInt16();
                data.Hit_for_5th_Damage_Bonus_offset = reader.BaseStream.Position;
                data.Hit_for_5th_Damage_Bonus_raw = reader.ReadUInt16();
                data._5th_Damage_Bonus_offset = reader.BaseStream.Position;
                data._5th_Damage_Bonus_raw = reader.ReadUInt16();
                data.Wyvernheart_Mod_Hit_Count_Per_Actual_Hit_offset = reader.BaseStream.Position;
                data.Wyvernheart_Mod_Hit_Count_Per_Actual_Hit_raw = reader.ReadByte();
                data.Unk_189_offset = reader.BaseStream.Position;
                data.Unk_189_raw = reader.ReadByte();
                data.Wyvernheart_Mod_Hit_Count_Loss_Per_Actual_Hit_Loss_offset = reader.BaseStream.Position;
                data.Wyvernheart_Mod_Hit_Count_Loss_Per_Actual_Hit_Loss_raw = reader.ReadByte();
                data.Wyvernheart_Mod_Hit_Count_for_Damage_Bonus_offset = reader.BaseStream.Position;
                data.Wyvernheart_Mod_Hit_Count_for_Damage_Bonus_raw = reader.ReadByte();
                data._Mod_Hit_for_1st_Damage_Bonus_offset = reader.BaseStream.Position;
                data._Mod_Hit_for_1st_Damage_Bonus_raw = reader.ReadUInt16();
                data._Mod_1st_Damage_Bonus_offset = reader.BaseStream.Position;
                data._Mod_1st_Damage_Bonus_raw = reader.ReadUInt16();
                data._Mod_Hit_for_2nd_Damage_Bonus_offset = reader.BaseStream.Position;
                data._Mod_Hit_for_2nd_Damage_Bonus_raw = reader.ReadUInt16();
                data._Mod_2nd_Damage_Bonus_offset = reader.BaseStream.Position;
                data._Mod_2nd_Damage_Bonus_raw = reader.ReadUInt16();
                data._Mod_Hit_for_3rd_Damage_Bonus_offset = reader.BaseStream.Position;
                data._Mod_Hit_for_3rd_Damage_Bonus_raw = reader.ReadUInt16();
                data._Mod_3rd_Damage_Bonus_offset = reader.BaseStream.Position;
                data._Mod_3rd_Damage_Bonus_raw = reader.ReadUInt16();
                data._Mod_Hit_for_4th_Damage_Bonus_offset = reader.BaseStream.Position;
                data._Mod_Hit_for_4th_Damage_Bonus_raw = reader.ReadUInt16();
                data._Mod_4th_Damage_Bonus_offset = reader.BaseStream.Position;
                data._Mod_4th_Damage_Bonus_raw = reader.ReadUInt16();
                data._Mod_Hit_for_5th_Damage_Bonus_offset = reader.BaseStream.Position;
                data._Mod_Hit_for_5th_Damage_Bonus_raw = reader.ReadUInt16();
                data._Mod_5th_Damage_Bonus_offset = reader.BaseStream.Position;
                data._Mod_5th_Damage_Bonus_raw = reader.ReadUInt16();
                data._Mod_Hit_for_6th_Damage_Bonus_offset = reader.BaseStream.Position;
                data._Mod_Hit_for_6th_Damage_Bonus_raw = reader.ReadUInt16();
                data._Mod_6th_Damage_Bonus_offset = reader.BaseStream.Position;
                data._Mod_6th_Damage_Bonus_raw = reader.ReadUInt16();
                data._Mod_Hit_for_7th_Damage_Bonus_offset = reader.BaseStream.Position;
                data._Mod_Hit_for_7th_Damage_Bonus_raw = reader.ReadUInt16();
                data._Mod_7th_Damage_Bonus_offset = reader.BaseStream.Position;
                data._Mod_7th_Damage_Bonus_raw = reader.ReadUInt16();
                data._Mod_Hit_for_8th_Damage_Bonus_offset = reader.BaseStream.Position;
                data._Mod_Hit_for_8th_Damage_Bonus_raw = reader.ReadUInt16();
                data._Mod_8th_Damage_Bonus_offset = reader.BaseStream.Position;
                data._Mod_8th_Damage_Bonus_raw = reader.ReadUInt16();
                data._Mod_Hit_for_9th_Damage_Bonus_offset = reader.BaseStream.Position;
                data._Mod_Hit_for_9th_Damage_Bonus_raw = reader.ReadUInt16();
                data._Mod_9th_Damage_Bonus_offset = reader.BaseStream.Position;
                data._Mod_9th_Damage_Bonus_raw = reader.ReadUInt16();
                data._Mod_Hit_for_10th_Damage_Bonus_offset = reader.BaseStream.Position;
                data._Mod_Hit_for_10th_Damage_Bonus_raw = reader.ReadUInt16();
                data._Mod_10th_Damage_Bonus_offset = reader.BaseStream.Position;
                data._Mod_10th_Damage_Bonus_raw = reader.ReadUInt16();
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
                writer.Write(Delay_Between_Shots_Rapid_Fire_Plus1_raw);
                writer.Write(Extra_Bullets_Rapid_Fire_Plus1_raw);
                writer.Write(Delay_Between_Shots_Rapid_Fire_Plus2_raw);
                writer.Write(Extra_Bullets_Rapid_Fire_Plus2_raw);
                writer.Write(Delay_Between_Shots_Rapid_Fire_Plus3_raw);
                writer.Write(Extra_Bullets_Rapid_Fire_Plus3_raw);
                writer.Write(Delay_Between_Shots_Rapid_Fire_Plus4_raw);
                writer.Write(Extra_Bullets_Rapid_Fire_Plus4_raw);
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
                writer.Write(Rapid_Fire_Extra_Round_Damage_Multiplier_raw);
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
                writer.Write(Wyvernheart_Ammo_Cap_raw);
                writer.Write(Delay_Between_Shots_raw);
                writer.Write(Wyvernheart_Ammo_Consumption_raw);
                writer.Write(Wyvernheart_Ammo_Recharge_raw);
                writer.Write(Wyvernheart_Vertical_Deviation_raw);
                writer.Write(Wyvernheart_Horizontal_Deviation_raw);
                writer.Write(Wyvernheart_Hit_Count_Per_Actual_Hit_raw);
                writer.Write(Unk_175_raw);
                writer.Write(Wyvernheart_Hit_Count_Loss_Per_Every_Actual_Loss_Hit_raw);
                writer.Write(Wyvernheart_Hit_Count_for_Damage_Bonus_raw);
                writer.Write(Hit_for_1st_Damage_Bonus_raw);
                writer.Write(_1st_Damage_Bonus_raw);
                writer.Write(Hit_for_2nd_Damage_Bonus_raw);
                writer.Write(_2nd_Damage_Bonus_raw);
                writer.Write(Hit_for_3rd_Damage_Bonus_raw);
                writer.Write(_3rd_Damage_Bonus_raw);
                writer.Write(Hit_for_4th_Damage_Bonus_raw);
                writer.Write(_4th_Damage_Bonus_raw);
                writer.Write(Hit_for_5th_Damage_Bonus_raw);
                writer.Write(_5th_Damage_Bonus_raw);
                writer.Write(Wyvernheart_Mod_Hit_Count_Per_Actual_Hit_raw);
                writer.Write(Unk_189_raw);
                writer.Write(Wyvernheart_Mod_Hit_Count_Loss_Per_Actual_Hit_Loss_raw);
                writer.Write(Wyvernheart_Mod_Hit_Count_for_Damage_Bonus_raw);
                writer.Write(_Mod_Hit_for_1st_Damage_Bonus_raw);
                writer.Write(_Mod_1st_Damage_Bonus_raw);
                writer.Write(_Mod_Hit_for_2nd_Damage_Bonus_raw);
                writer.Write(_Mod_2nd_Damage_Bonus_raw);
                writer.Write(_Mod_Hit_for_3rd_Damage_Bonus_raw);
                writer.Write(_Mod_3rd_Damage_Bonus_raw);
                writer.Write(_Mod_Hit_for_4th_Damage_Bonus_raw);
                writer.Write(_Mod_4th_Damage_Bonus_raw);
                writer.Write(_Mod_Hit_for_5th_Damage_Bonus_raw);
                writer.Write(_Mod_5th_Damage_Bonus_raw);
                writer.Write(_Mod_Hit_for_6th_Damage_Bonus_raw);
                writer.Write(_Mod_6th_Damage_Bonus_raw);
                writer.Write(_Mod_Hit_for_7th_Damage_Bonus_raw);
                writer.Write(_Mod_7th_Damage_Bonus_raw);
                writer.Write(_Mod_Hit_for_8th_Damage_Bonus_raw);
                writer.Write(_Mod_8th_Damage_Bonus_raw);
                writer.Write(_Mod_Hit_for_9th_Damage_Bonus_raw);
                writer.Write(_Mod_9th_Damage_Bonus_raw);
                writer.Write(_Mod_Hit_for_10th_Damage_Bonus_raw);
                writer.Write(_Mod_10th_Damage_Bonus_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Unk 91", "Unk_91", "Unk_91_offset"),
                    new MultiStructItemCustomView(this, "Unk 92", "Unk_92", "Unk_92_offset"),
                    new MultiStructItemCustomView(this, "Unk 93", "Unk_93", "Unk_93_offset"),
                    new MultiStructItemCustomView(this, "Unk 94", "Unk_94", "Unk_94_offset"),
                    new MultiStructItemCustomView(this, "Unk 95", "Unk_95", "Unk_95_offset"),
                    new MultiStructItemCustomView(this, "Unk 96", "Unk_96", "Unk_96_offset"),
                    new MultiStructItemCustomView(this, "Unk 97", "Unk_97", "Unk_97_offset"),
                    new MultiStructItemCustomView(this, "Unk 98", "Unk_98", "Unk_98_offset"),
                    new MultiStructItemCustomView(this, "Delay Between Shots: Rapid Fire +1", "Delay_Between_Shots_Rapid_Fire_Plus1", "Delay_Between_Shots_Rapid_Fire_Plus1_offset"),
                    new MultiStructItemCustomView(this, "Extra Bullets: Rapid Fire +1", "Extra_Bullets_Rapid_Fire_Plus1", "Extra_Bullets_Rapid_Fire_Plus1_offset"),
                    new MultiStructItemCustomView(this, "Delay Between Shots: Rapid Fire +2", "Delay_Between_Shots_Rapid_Fire_Plus2", "Delay_Between_Shots_Rapid_Fire_Plus2_offset"),
                    new MultiStructItemCustomView(this, "Extra Bullets: Rapid Fire +2", "Extra_Bullets_Rapid_Fire_Plus2", "Extra_Bullets_Rapid_Fire_Plus2_offset"),
                    new MultiStructItemCustomView(this, "Delay Between Shots: Rapid Fire +3", "Delay_Between_Shots_Rapid_Fire_Plus3", "Delay_Between_Shots_Rapid_Fire_Plus3_offset"),
                    new MultiStructItemCustomView(this, "Extra Bullets: Rapid Fire +3", "Extra_Bullets_Rapid_Fire_Plus3", "Extra_Bullets_Rapid_Fire_Plus3_offset"),
                    new MultiStructItemCustomView(this, "Delay Between Shots: Rapid Fire +4", "Delay_Between_Shots_Rapid_Fire_Plus4", "Delay_Between_Shots_Rapid_Fire_Plus4_offset"),
                    new MultiStructItemCustomView(this, "Extra Bullets: Rapid Fire +4", "Extra_Bullets_Rapid_Fire_Plus4", "Extra_Bullets_Rapid_Fire_Plus4_offset"),
                    new MultiStructItemCustomView(this, "Unk 107", "Unk_107", "Unk_107_offset"),
                    new MultiStructItemCustomView(this, "Unk 108", "Unk_108", "Unk_108_offset"),
                    new MultiStructItemCustomView(this, "Unk 109", "Unk_109", "Unk_109_offset"),
                    new MultiStructItemCustomView(this, "Unk 110", "Unk_110", "Unk_110_offset"),
                    new MultiStructItemCustomView(this, "Unk 111", "Unk_111", "Unk_111_offset"),
                    new MultiStructItemCustomView(this, "Unk 112", "Unk_112", "Unk_112_offset"),
                    new MultiStructItemCustomView(this, "Unk 113", "Unk_113", "Unk_113_offset"),
                    new MultiStructItemCustomView(this, "Unk 114", "Unk_114", "Unk_114_offset"),
                    new MultiStructItemCustomView(this, "Unk 115", "Unk_115", "Unk_115_offset"),
                    new MultiStructItemCustomView(this, "Unk 116", "Unk_116", "Unk_116_offset"),
                    new MultiStructItemCustomView(this, "Unk 117", "Unk_117", "Unk_117_offset"),
                    new MultiStructItemCustomView(this, "Unk 118", "Unk_118", "Unk_118_offset"),
                    new MultiStructItemCustomView(this, "Unk 119", "Unk_119", "Unk_119_offset"),
                    new MultiStructItemCustomView(this, "Unk 120", "Unk_120", "Unk_120_offset"),
                    new MultiStructItemCustomView(this, "Unk 121", "Unk_121", "Unk_121_offset"),
                    new MultiStructItemCustomView(this, "Unk 122", "Unk_122", "Unk_122_offset"),
                    new MultiStructItemCustomView(this, "Unk 123", "Unk_123", "Unk_123_offset"),
                    new MultiStructItemCustomView(this, "Unk 124", "Unk_124", "Unk_124_offset"),
                    new MultiStructItemCustomView(this, "Unk 125", "Unk_125", "Unk_125_offset"),
                    new MultiStructItemCustomView(this, "Unk 126", "Unk_126", "Unk_126_offset"),
                    new MultiStructItemCustomView(this, "Unk 127", "Unk_127", "Unk_127_offset"),
                    new MultiStructItemCustomView(this, "Unk 128", "Unk_128", "Unk_128_offset"),
                    new MultiStructItemCustomView(this, "Unk 129", "Unk_129", "Unk_129_offset"),
                    new MultiStructItemCustomView(this, "Unk 130", "Unk_130", "Unk_130_offset"),
                    new MultiStructItemCustomView(this, "Unk 131", "Unk_131", "Unk_131_offset"),
                    new MultiStructItemCustomView(this, "Unk 132", "Unk_132", "Unk_132_offset"),
                    new MultiStructItemCustomView(this, "Unk 133", "Unk_133", "Unk_133_offset"),
                    new MultiStructItemCustomView(this, "Unk 134", "Unk_134", "Unk_134_offset"),
                    new MultiStructItemCustomView(this, "Unk 135", "Unk_135", "Unk_135_offset"),
                    new MultiStructItemCustomView(this, "Unk 136", "Unk_136", "Unk_136_offset"),
                    new MultiStructItemCustomView(this, "Unk 137", "Unk_137", "Unk_137_offset"),
                    new MultiStructItemCustomView(this, "Unk 138", "Unk_138", "Unk_138_offset"),
                    new MultiStructItemCustomView(this, "Unk 139", "Unk_139", "Unk_139_offset"),
                    new MultiStructItemCustomView(this, "Unk 140", "Unk_140", "Unk_140_offset"),
                    new MultiStructItemCustomView(this, "Unk 141", "Unk_141", "Unk_141_offset"),
                    new MultiStructItemCustomView(this, "Unk 142", "Unk_142", "Unk_142_offset"),
                    new MultiStructItemCustomView(this, "Unk 143", "Unk_143", "Unk_143_offset"),
                    new MultiStructItemCustomView(this, "Rapid Fire Extra Round Damage Multiplier", "Rapid_Fire_Extra_Round_Damage_Multiplier", "Rapid_Fire_Extra_Round_Damage_Multiplier_offset"),
                    new MultiStructItemCustomView(this, "Unk 145", "Unk_145", "Unk_145_offset"),
                    new MultiStructItemCustomView(this, "Unk 146", "Unk_146", "Unk_146_offset"),
                    new MultiStructItemCustomView(this, "Unk 147", "Unk_147", "Unk_147_offset"),
                    new MultiStructItemCustomView(this, "Unk 148", "Unk_148", "Unk_148_offset"),
                    new MultiStructItemCustomView(this, "Unk 149", "Unk_149", "Unk_149_offset"),
                    new MultiStructItemCustomView(this, "Unk 150", "Unk_150", "Unk_150_offset"),
                    new MultiStructItemCustomView(this, "Unk 151", "Unk_151", "Unk_151_offset"),
                    new MultiStructItemCustomView(this, "Unk 152", "Unk_152", "Unk_152_offset"),
                    new MultiStructItemCustomView(this, "Unk 153", "Unk_153", "Unk_153_offset"),
                    new MultiStructItemCustomView(this, "Unk 154", "Unk_154", "Unk_154_offset"),
                    new MultiStructItemCustomView(this, "Unk 155", "Unk_155", "Unk_155_offset"),
                    new MultiStructItemCustomView(this, "Unk 156", "Unk_156", "Unk_156_offset"),
                    new MultiStructItemCustomView(this, "Unk 157", "Unk_157", "Unk_157_offset"),
                    new MultiStructItemCustomView(this, "Unk 158", "Unk_158", "Unk_158_offset"),
                    new MultiStructItemCustomView(this, "Unk 159", "Unk_159", "Unk_159_offset"),
                    new MultiStructItemCustomView(this, "Unk 160", "Unk_160", "Unk_160_offset"),
                    new MultiStructItemCustomView(this, "Unk 161", "Unk_161", "Unk_161_offset"),
                    new MultiStructItemCustomView(this, "Unk 162", "Unk_162", "Unk_162_offset"),
                    new MultiStructItemCustomView(this, "Unk 163", "Unk_163", "Unk_163_offset"),
                    new MultiStructItemCustomView(this, "Unk 164", "Unk_164", "Unk_164_offset"),
                    new MultiStructItemCustomView(this, "Unk 165", "Unk_165", "Unk_165_offset"),
                    new MultiStructItemCustomView(this, "Unk 166", "Unk_166", "Unk_166_offset"),
                    new MultiStructItemCustomView(this, "Unk 167", "Unk_167", "Unk_167_offset"),
                    new MultiStructItemCustomView(this, "Wyvernheart Ammo Cap", "Wyvernheart_Ammo_Cap", "Wyvernheart_Ammo_Cap_offset"),
                    new MultiStructItemCustomView(this, "Delay Between Shots", "Delay_Between_Shots", "Delay_Between_Shots_offset"),
                    new MultiStructItemCustomView(this, "Wyvernheart Ammo Consumption", "Wyvernheart_Ammo_Consumption", "Wyvernheart_Ammo_Consumption_offset"),
                    new MultiStructItemCustomView(this, "Wyvernheart Ammo Recharge", "Wyvernheart_Ammo_Recharge", "Wyvernheart_Ammo_Recharge_offset"),
                    new MultiStructItemCustomView(this, "Wyvernheart Vertical Deviation", "Wyvernheart_Vertical_Deviation", "Wyvernheart_Vertical_Deviation_offset"),
                    new MultiStructItemCustomView(this, "Wyvernheart Horizontal Deviation", "Wyvernheart_Horizontal_Deviation", "Wyvernheart_Horizontal_Deviation_offset"),
                    new MultiStructItemCustomView(this, "Wyvernheart Hit Count Per Actual Hit", "Wyvernheart_Hit_Count_Per_Actual_Hit", "Wyvernheart_Hit_Count_Per_Actual_Hit_offset"),
                    new MultiStructItemCustomView(this, "Unk 175", "Unk_175", "Unk_175_offset"),
                    new MultiStructItemCustomView(this, "Wyvernheart Hit Count Loss Per Every Actual Loss Hit", "Wyvernheart_Hit_Count_Loss_Per_Every_Actual_Loss_Hit", "Wyvernheart_Hit_Count_Loss_Per_Every_Actual_Loss_Hit_offset"),
                    new MultiStructItemCustomView(this, "Wyvernheart Hit Count for Damage Bonus", "Wyvernheart_Hit_Count_for_Damage_Bonus", "Wyvernheart_Hit_Count_for_Damage_Bonus_offset"),
                    new MultiStructItemCustomView(this, "Hit for 1st Damage Bonus", "Hit_for_1st_Damage_Bonus", "Hit_for_1st_Damage_Bonus_offset"),
                    new MultiStructItemCustomView(this, "(1st) Damage Bonus", "_1st_Damage_Bonus", "_1st_Damage_Bonus_offset"),
                    new MultiStructItemCustomView(this, "Hit for 2nd Damage Bonus", "Hit_for_2nd_Damage_Bonus", "Hit_for_2nd_Damage_Bonus_offset"),
                    new MultiStructItemCustomView(this, "(2nd) Damage Bonus", "_2nd_Damage_Bonus", "_2nd_Damage_Bonus_offset"),
                    new MultiStructItemCustomView(this, "Hit for 3rd Damage Bonus", "Hit_for_3rd_Damage_Bonus", "Hit_for_3rd_Damage_Bonus_offset"),
                    new MultiStructItemCustomView(this, "(3rd) Damage Bonus", "_3rd_Damage_Bonus", "_3rd_Damage_Bonus_offset"),
                    new MultiStructItemCustomView(this, "Hit for 4th Damage Bonus", "Hit_for_4th_Damage_Bonus", "Hit_for_4th_Damage_Bonus_offset"),
                    new MultiStructItemCustomView(this, "(4th) Damage Bonus", "_4th_Damage_Bonus", "_4th_Damage_Bonus_offset"),
                    new MultiStructItemCustomView(this, "Hit for 5th Damage Bonus", "Hit_for_5th_Damage_Bonus", "Hit_for_5th_Damage_Bonus_offset"),
                    new MultiStructItemCustomView(this, "(5th) Damage Bonus", "_5th_Damage_Bonus", "_5th_Damage_Bonus_offset"),
                    new MultiStructItemCustomView(this, "Wyvernheart Mod Hit Count Per Actual Hit", "Wyvernheart_Mod_Hit_Count_Per_Actual_Hit", "Wyvernheart_Mod_Hit_Count_Per_Actual_Hit_offset"),
                    new MultiStructItemCustomView(this, "Unk 189", "Unk_189", "Unk_189_offset"),
                    new MultiStructItemCustomView(this, "Wyvernheart Mod Hit Count Loss Per Actual Hit Loss", "Wyvernheart_Mod_Hit_Count_Loss_Per_Actual_Hit_Loss", "Wyvernheart_Mod_Hit_Count_Loss_Per_Actual_Hit_Loss_offset"),
                    new MultiStructItemCustomView(this, "Wyvernheart Mod Hit Count for Damage Bonus", "Wyvernheart_Mod_Hit_Count_for_Damage_Bonus", "Wyvernheart_Mod_Hit_Count_for_Damage_Bonus_offset"),
                    new MultiStructItemCustomView(this, "(Mod) Hit for 1st Damage Bonus", "_Mod_Hit_for_1st_Damage_Bonus", "_Mod_Hit_for_1st_Damage_Bonus_offset"),
                    new MultiStructItemCustomView(this, "(Mod, 1st) Damage Bonus", "_Mod_1st_Damage_Bonus", "_Mod_1st_Damage_Bonus_offset"),
                    new MultiStructItemCustomView(this, "(Mod) Hit for 2nd Damage Bonus", "_Mod_Hit_for_2nd_Damage_Bonus", "_Mod_Hit_for_2nd_Damage_Bonus_offset"),
                    new MultiStructItemCustomView(this, "(Mod, 2nd) Damage Bonus", "_Mod_2nd_Damage_Bonus", "_Mod_2nd_Damage_Bonus_offset"),
                    new MultiStructItemCustomView(this, "(Mod) Hit for 3rd Damage Bonus", "_Mod_Hit_for_3rd_Damage_Bonus", "_Mod_Hit_for_3rd_Damage_Bonus_offset"),
                    new MultiStructItemCustomView(this, "(Mod, 3rd) Damage Bonus", "_Mod_3rd_Damage_Bonus", "_Mod_3rd_Damage_Bonus_offset"),
                    new MultiStructItemCustomView(this, "(Mod) Hit for 4th Damage Bonus", "_Mod_Hit_for_4th_Damage_Bonus", "_Mod_Hit_for_4th_Damage_Bonus_offset"),
                    new MultiStructItemCustomView(this, "(Mod, 4th) Damage Bonus", "_Mod_4th_Damage_Bonus", "_Mod_4th_Damage_Bonus_offset"),
                    new MultiStructItemCustomView(this, "(Mod) Hit for 5th Damage Bonus", "_Mod_Hit_for_5th_Damage_Bonus", "_Mod_Hit_for_5th_Damage_Bonus_offset"),
                    new MultiStructItemCustomView(this, "(Mod, 5th) Damage Bonus", "_Mod_5th_Damage_Bonus", "_Mod_5th_Damage_Bonus_offset"),
                    new MultiStructItemCustomView(this, "(Mod) Hit for 6th Damage Bonus", "_Mod_Hit_for_6th_Damage_Bonus", "_Mod_Hit_for_6th_Damage_Bonus_offset"),
                    new MultiStructItemCustomView(this, "(Mod, 6th) Damage Bonus", "_Mod_6th_Damage_Bonus", "_Mod_6th_Damage_Bonus_offset"),
                    new MultiStructItemCustomView(this, "(Mod) Hit for 7th Damage Bonus", "_Mod_Hit_for_7th_Damage_Bonus", "_Mod_Hit_for_7th_Damage_Bonus_offset"),
                    new MultiStructItemCustomView(this, "(Mod, 7th) Damage Bonus", "_Mod_7th_Damage_Bonus", "_Mod_7th_Damage_Bonus_offset"),
                    new MultiStructItemCustomView(this, "(Mod) Hit for 8th Damage Bonus", "_Mod_Hit_for_8th_Damage_Bonus", "_Mod_Hit_for_8th_Damage_Bonus_offset"),
                    new MultiStructItemCustomView(this, "(Mod, 8th) Damage Bonus", "_Mod_8th_Damage_Bonus", "_Mod_8th_Damage_Bonus_offset"),
                    new MultiStructItemCustomView(this, "(Mod) Hit for 9th Damage Bonus", "_Mod_Hit_for_9th_Damage_Bonus", "_Mod_Hit_for_9th_Damage_Bonus_offset"),
                    new MultiStructItemCustomView(this, "(Mod, 9th) Damage Bonus", "_Mod_9th_Damage_Bonus", "_Mod_9th_Damage_Bonus_offset"),
                    new MultiStructItemCustomView(this, "(Mod) Hit for 10th Damage Bonus", "_Mod_Hit_for_10th_Damage_Bonus", "_Mod_Hit_for_10th_Damage_Bonus_offset"),
                    new MultiStructItemCustomView(this, "(Mod, 10th) Damage Bonus", "_Mod_10th_Damage_Bonus", "_Mod_10th_Damage_Bonus_offset"),
                };
            }
        }

        public partial class Event_Pad_Vib : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 1;
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
                    ChangedItems.Add(nameof(B));
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
                    ChangedItems.Add(nameof(X));
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
                    ChangedItems.Add(nameof(Y));
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
                    ChangedItems.Add(nameof(Time));
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
                    ChangedItems.Add(nameof(P));
                    OnPropertyChanged(nameof(P));
                }
            }

            public const int lastSortIndex = 300;

            public static ObservableMhwStructCollection<Event_Pad_Vib> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Event_Pad_Vib>();
                const ulong count = 1UL;
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

        public partial class W13p_Params_5_1_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W13p Params (5.1)";

            protected float Wyvernsnipe_Prone_Movement_Params_1_raw;
            public const string Wyvernsnipe_Prone_Movement_Params_1_displayName = "Wyvernsnipe Prone Movement Params 1";
            public const int Wyvernsnipe_Prone_Movement_Params_1_sortIndex = 50;
            [SortOrder(Wyvernsnipe_Prone_Movement_Params_1_sortIndex)]
            [DisplayName(Wyvernsnipe_Prone_Movement_Params_1_displayName)]
            public virtual float Wyvernsnipe_Prone_Movement_Params_1 {
                get => Wyvernsnipe_Prone_Movement_Params_1_raw;
                set {
                    if (Wyvernsnipe_Prone_Movement_Params_1_raw == value) return;
                    Wyvernsnipe_Prone_Movement_Params_1_raw = value;
                    ChangedItems.Add(nameof(Wyvernsnipe_Prone_Movement_Params_1));
                    OnPropertyChanged(nameof(Wyvernsnipe_Prone_Movement_Params_1));
                }
            }

            [DisplayName("Offset")]
            public long Wyvernsnipe_Prone_Movement_Params_1_offset { get; private set; }

            protected float Wyvernsnipe_Prone_Movement_Params_2_raw;
            public const string Wyvernsnipe_Prone_Movement_Params_2_displayName = "Wyvernsnipe Prone Movement Params 2";
            public const int Wyvernsnipe_Prone_Movement_Params_2_sortIndex = 100;
            [SortOrder(Wyvernsnipe_Prone_Movement_Params_2_sortIndex)]
            [DisplayName(Wyvernsnipe_Prone_Movement_Params_2_displayName)]
            public virtual float Wyvernsnipe_Prone_Movement_Params_2 {
                get => Wyvernsnipe_Prone_Movement_Params_2_raw;
                set {
                    if (Wyvernsnipe_Prone_Movement_Params_2_raw == value) return;
                    Wyvernsnipe_Prone_Movement_Params_2_raw = value;
                    ChangedItems.Add(nameof(Wyvernsnipe_Prone_Movement_Params_2));
                    OnPropertyChanged(nameof(Wyvernsnipe_Prone_Movement_Params_2));
                }
            }

            [DisplayName("Offset")]
            public long Wyvernsnipe_Prone_Movement_Params_2_offset { get; private set; }

            protected float Wyvernsnipe_Prone_Movement_Params_3_raw;
            public const string Wyvernsnipe_Prone_Movement_Params_3_displayName = "Wyvernsnipe Prone Movement Params 3";
            public const int Wyvernsnipe_Prone_Movement_Params_3_sortIndex = 150;
            [SortOrder(Wyvernsnipe_Prone_Movement_Params_3_sortIndex)]
            [DisplayName(Wyvernsnipe_Prone_Movement_Params_3_displayName)]
            public virtual float Wyvernsnipe_Prone_Movement_Params_3 {
                get => Wyvernsnipe_Prone_Movement_Params_3_raw;
                set {
                    if (Wyvernsnipe_Prone_Movement_Params_3_raw == value) return;
                    Wyvernsnipe_Prone_Movement_Params_3_raw = value;
                    ChangedItems.Add(nameof(Wyvernsnipe_Prone_Movement_Params_3));
                    OnPropertyChanged(nameof(Wyvernsnipe_Prone_Movement_Params_3));
                }
            }

            [DisplayName("Offset")]
            public long Wyvernsnipe_Prone_Movement_Params_3_offset { get; private set; }

            protected float Wyvernsnipe_Prone_Movement_Params_4_raw;
            public const string Wyvernsnipe_Prone_Movement_Params_4_displayName = "Wyvernsnipe Prone Movement Params 4";
            public const int Wyvernsnipe_Prone_Movement_Params_4_sortIndex = 200;
            [SortOrder(Wyvernsnipe_Prone_Movement_Params_4_sortIndex)]
            [DisplayName(Wyvernsnipe_Prone_Movement_Params_4_displayName)]
            public virtual float Wyvernsnipe_Prone_Movement_Params_4 {
                get => Wyvernsnipe_Prone_Movement_Params_4_raw;
                set {
                    if (Wyvernsnipe_Prone_Movement_Params_4_raw == value) return;
                    Wyvernsnipe_Prone_Movement_Params_4_raw = value;
                    ChangedItems.Add(nameof(Wyvernsnipe_Prone_Movement_Params_4));
                    OnPropertyChanged(nameof(Wyvernsnipe_Prone_Movement_Params_4));
                }
            }

            [DisplayName("Offset")]
            public long Wyvernsnipe_Prone_Movement_Params_4_offset { get; private set; }

            protected float Wyvernsnipe_Prone_Movement_Params_5_raw;
            public const string Wyvernsnipe_Prone_Movement_Params_5_displayName = "Wyvernsnipe Prone Movement Params 5";
            public const int Wyvernsnipe_Prone_Movement_Params_5_sortIndex = 250;
            [SortOrder(Wyvernsnipe_Prone_Movement_Params_5_sortIndex)]
            [DisplayName(Wyvernsnipe_Prone_Movement_Params_5_displayName)]
            public virtual float Wyvernsnipe_Prone_Movement_Params_5 {
                get => Wyvernsnipe_Prone_Movement_Params_5_raw;
                set {
                    if (Wyvernsnipe_Prone_Movement_Params_5_raw == value) return;
                    Wyvernsnipe_Prone_Movement_Params_5_raw = value;
                    ChangedItems.Add(nameof(Wyvernsnipe_Prone_Movement_Params_5));
                    OnPropertyChanged(nameof(Wyvernsnipe_Prone_Movement_Params_5));
                }
            }

            [DisplayName("Offset")]
            public long Wyvernsnipe_Prone_Movement_Params_5_offset { get; private set; }

            protected float Wyvernsnipe_Prone_Movement_Params_6_raw;
            public const string Wyvernsnipe_Prone_Movement_Params_6_displayName = "Wyvernsnipe Prone Movement Params 6";
            public const int Wyvernsnipe_Prone_Movement_Params_6_sortIndex = 300;
            [SortOrder(Wyvernsnipe_Prone_Movement_Params_6_sortIndex)]
            [DisplayName(Wyvernsnipe_Prone_Movement_Params_6_displayName)]
            public virtual float Wyvernsnipe_Prone_Movement_Params_6 {
                get => Wyvernsnipe_Prone_Movement_Params_6_raw;
                set {
                    if (Wyvernsnipe_Prone_Movement_Params_6_raw == value) return;
                    Wyvernsnipe_Prone_Movement_Params_6_raw = value;
                    ChangedItems.Add(nameof(Wyvernsnipe_Prone_Movement_Params_6));
                    OnPropertyChanged(nameof(Wyvernsnipe_Prone_Movement_Params_6));
                }
            }

            [DisplayName("Offset")]
            public long Wyvernsnipe_Prone_Movement_Params_6_offset { get; private set; }

            protected float Wyvernsnipe_Prone_Movement_Params_7_raw;
            public const string Wyvernsnipe_Prone_Movement_Params_7_displayName = "Wyvernsnipe Prone Movement Params 7";
            public const int Wyvernsnipe_Prone_Movement_Params_7_sortIndex = 350;
            [SortOrder(Wyvernsnipe_Prone_Movement_Params_7_sortIndex)]
            [DisplayName(Wyvernsnipe_Prone_Movement_Params_7_displayName)]
            public virtual float Wyvernsnipe_Prone_Movement_Params_7 {
                get => Wyvernsnipe_Prone_Movement_Params_7_raw;
                set {
                    if (Wyvernsnipe_Prone_Movement_Params_7_raw == value) return;
                    Wyvernsnipe_Prone_Movement_Params_7_raw = value;
                    ChangedItems.Add(nameof(Wyvernsnipe_Prone_Movement_Params_7));
                    OnPropertyChanged(nameof(Wyvernsnipe_Prone_Movement_Params_7));
                }
            }

            [DisplayName("Offset")]
            public long Wyvernsnipe_Prone_Movement_Params_7_offset { get; private set; }

            protected float Wyvernsnipe_Prone_Movement_Params_8_raw;
            public const string Wyvernsnipe_Prone_Movement_Params_8_displayName = "Wyvernsnipe Prone Movement Params 8";
            public const int Wyvernsnipe_Prone_Movement_Params_8_sortIndex = 400;
            [SortOrder(Wyvernsnipe_Prone_Movement_Params_8_sortIndex)]
            [DisplayName(Wyvernsnipe_Prone_Movement_Params_8_displayName)]
            public virtual float Wyvernsnipe_Prone_Movement_Params_8 {
                get => Wyvernsnipe_Prone_Movement_Params_8_raw;
                set {
                    if (Wyvernsnipe_Prone_Movement_Params_8_raw == value) return;
                    Wyvernsnipe_Prone_Movement_Params_8_raw = value;
                    ChangedItems.Add(nameof(Wyvernsnipe_Prone_Movement_Params_8));
                    OnPropertyChanged(nameof(Wyvernsnipe_Prone_Movement_Params_8));
                }
            }

            [DisplayName("Offset")]
            public long Wyvernsnipe_Prone_Movement_Params_8_offset { get; private set; }

            protected float Wyvernsnipe_Prone_Movement_Params_9_raw;
            public const string Wyvernsnipe_Prone_Movement_Params_9_displayName = "Wyvernsnipe Prone Movement Params 9";
            public const int Wyvernsnipe_Prone_Movement_Params_9_sortIndex = 450;
            [SortOrder(Wyvernsnipe_Prone_Movement_Params_9_sortIndex)]
            [DisplayName(Wyvernsnipe_Prone_Movement_Params_9_displayName)]
            public virtual float Wyvernsnipe_Prone_Movement_Params_9 {
                get => Wyvernsnipe_Prone_Movement_Params_9_raw;
                set {
                    if (Wyvernsnipe_Prone_Movement_Params_9_raw == value) return;
                    Wyvernsnipe_Prone_Movement_Params_9_raw = value;
                    ChangedItems.Add(nameof(Wyvernsnipe_Prone_Movement_Params_9));
                    OnPropertyChanged(nameof(Wyvernsnipe_Prone_Movement_Params_9));
                }
            }

            [DisplayName("Offset")]
            public long Wyvernsnipe_Prone_Movement_Params_9_offset { get; private set; }

            protected float Wyvernsnipe_Prone_Movement_Params_10_raw;
            public const string Wyvernsnipe_Prone_Movement_Params_10_displayName = "Wyvernsnipe Prone Movement Params 10";
            public const int Wyvernsnipe_Prone_Movement_Params_10_sortIndex = 500;
            [SortOrder(Wyvernsnipe_Prone_Movement_Params_10_sortIndex)]
            [DisplayName(Wyvernsnipe_Prone_Movement_Params_10_displayName)]
            public virtual float Wyvernsnipe_Prone_Movement_Params_10 {
                get => Wyvernsnipe_Prone_Movement_Params_10_raw;
                set {
                    if (Wyvernsnipe_Prone_Movement_Params_10_raw == value) return;
                    Wyvernsnipe_Prone_Movement_Params_10_raw = value;
                    ChangedItems.Add(nameof(Wyvernsnipe_Prone_Movement_Params_10));
                    OnPropertyChanged(nameof(Wyvernsnipe_Prone_Movement_Params_10));
                }
            }

            [DisplayName("Offset")]
            public long Wyvernsnipe_Prone_Movement_Params_10_offset { get; private set; }

            protected float Wyvernsnipe_Prone_Movement_Params_11_raw;
            public const string Wyvernsnipe_Prone_Movement_Params_11_displayName = "Wyvernsnipe Prone Movement Params 11";
            public const int Wyvernsnipe_Prone_Movement_Params_11_sortIndex = 550;
            [SortOrder(Wyvernsnipe_Prone_Movement_Params_11_sortIndex)]
            [DisplayName(Wyvernsnipe_Prone_Movement_Params_11_displayName)]
            public virtual float Wyvernsnipe_Prone_Movement_Params_11 {
                get => Wyvernsnipe_Prone_Movement_Params_11_raw;
                set {
                    if (Wyvernsnipe_Prone_Movement_Params_11_raw == value) return;
                    Wyvernsnipe_Prone_Movement_Params_11_raw = value;
                    ChangedItems.Add(nameof(Wyvernsnipe_Prone_Movement_Params_11));
                    OnPropertyChanged(nameof(Wyvernsnipe_Prone_Movement_Params_11));
                }
            }

            [DisplayName("Offset")]
            public long Wyvernsnipe_Prone_Movement_Params_11_offset { get; private set; }

            protected float Wyvernsnipe_Prone_Movement_Params_12_raw;
            public const string Wyvernsnipe_Prone_Movement_Params_12_displayName = "Wyvernsnipe Prone Movement Params 12";
            public const int Wyvernsnipe_Prone_Movement_Params_12_sortIndex = 600;
            [SortOrder(Wyvernsnipe_Prone_Movement_Params_12_sortIndex)]
            [DisplayName(Wyvernsnipe_Prone_Movement_Params_12_displayName)]
            public virtual float Wyvernsnipe_Prone_Movement_Params_12 {
                get => Wyvernsnipe_Prone_Movement_Params_12_raw;
                set {
                    if (Wyvernsnipe_Prone_Movement_Params_12_raw == value) return;
                    Wyvernsnipe_Prone_Movement_Params_12_raw = value;
                    ChangedItems.Add(nameof(Wyvernsnipe_Prone_Movement_Params_12));
                    OnPropertyChanged(nameof(Wyvernsnipe_Prone_Movement_Params_12));
                }
            }

            [DisplayName("Offset")]
            public long Wyvernsnipe_Prone_Movement_Params_12_offset { get; private set; }

            protected float Wyvernsnipe_Prone_Movement_Params_13_raw;
            public const string Wyvernsnipe_Prone_Movement_Params_13_displayName = "Wyvernsnipe Prone Movement Params 13";
            public const int Wyvernsnipe_Prone_Movement_Params_13_sortIndex = 650;
            [SortOrder(Wyvernsnipe_Prone_Movement_Params_13_sortIndex)]
            [DisplayName(Wyvernsnipe_Prone_Movement_Params_13_displayName)]
            public virtual float Wyvernsnipe_Prone_Movement_Params_13 {
                get => Wyvernsnipe_Prone_Movement_Params_13_raw;
                set {
                    if (Wyvernsnipe_Prone_Movement_Params_13_raw == value) return;
                    Wyvernsnipe_Prone_Movement_Params_13_raw = value;
                    ChangedItems.Add(nameof(Wyvernsnipe_Prone_Movement_Params_13));
                    OnPropertyChanged(nameof(Wyvernsnipe_Prone_Movement_Params_13));
                }
            }

            [DisplayName("Offset")]
            public long Wyvernsnipe_Prone_Movement_Params_13_offset { get; private set; }

            protected float Wyvernsnipe_Prone_Movement_Params_14_raw;
            public const string Wyvernsnipe_Prone_Movement_Params_14_displayName = "Wyvernsnipe Prone Movement Params 14";
            public const int Wyvernsnipe_Prone_Movement_Params_14_sortIndex = 700;
            [SortOrder(Wyvernsnipe_Prone_Movement_Params_14_sortIndex)]
            [DisplayName(Wyvernsnipe_Prone_Movement_Params_14_displayName)]
            public virtual float Wyvernsnipe_Prone_Movement_Params_14 {
                get => Wyvernsnipe_Prone_Movement_Params_14_raw;
                set {
                    if (Wyvernsnipe_Prone_Movement_Params_14_raw == value) return;
                    Wyvernsnipe_Prone_Movement_Params_14_raw = value;
                    ChangedItems.Add(nameof(Wyvernsnipe_Prone_Movement_Params_14));
                    OnPropertyChanged(nameof(Wyvernsnipe_Prone_Movement_Params_14));
                }
            }

            [DisplayName("Offset")]
            public long Wyvernsnipe_Prone_Movement_Params_14_offset { get; private set; }

            protected byte Wyrmsnipe_Capacity_raw;
            public const string Wyrmsnipe_Capacity_displayName = "Wyrmsnipe Capacity";
            public const int Wyrmsnipe_Capacity_sortIndex = 750;
            [SortOrder(Wyrmsnipe_Capacity_sortIndex)]
            [DisplayName(Wyrmsnipe_Capacity_displayName)]
            public virtual byte Wyrmsnipe_Capacity {
                get => Wyrmsnipe_Capacity_raw;
                set {
                    if (Wyrmsnipe_Capacity_raw == value) return;
                    Wyrmsnipe_Capacity_raw = value;
                    ChangedItems.Add(nameof(Wyrmsnipe_Capacity));
                    OnPropertyChanged(nameof(Wyrmsnipe_Capacity));
                }
            }

            [DisplayName("Offset")]
            public long Wyrmsnipe_Capacity_offset { get; private set; }

            protected float Wyrmsnipe_Cooldown_raw;
            public const string Wyrmsnipe_Cooldown_displayName = "Wyrmsnipe Cooldown";
            public const int Wyrmsnipe_Cooldown_sortIndex = 800;
            [SortOrder(Wyrmsnipe_Cooldown_sortIndex)]
            [DisplayName(Wyrmsnipe_Cooldown_displayName)]
            public virtual float Wyrmsnipe_Cooldown {
                get => Wyrmsnipe_Cooldown_raw;
                set {
                    if (Wyrmsnipe_Cooldown_raw == value) return;
                    Wyrmsnipe_Cooldown_raw = value;
                    ChangedItems.Add(nameof(Wyrmsnipe_Cooldown));
                    OnPropertyChanged(nameof(Wyrmsnipe_Cooldown));
                }
            }

            [DisplayName("Offset")]
            public long Wyrmsnipe_Cooldown_offset { get; private set; }

            protected byte Wyvernsnipe_Number_of_Medium_Explosions__raw;
            public const string Wyvernsnipe_Number_of_Medium_Explosions__displayName = "Wyvernsnipe Number of Medium Explosions?";
            public const int Wyvernsnipe_Number_of_Medium_Explosions__sortIndex = 850;
            [SortOrder(Wyvernsnipe_Number_of_Medium_Explosions__sortIndex)]
            [DisplayName(Wyvernsnipe_Number_of_Medium_Explosions__displayName)]
            public virtual byte Wyvernsnipe_Number_of_Medium_Explosions_ {
                get => Wyvernsnipe_Number_of_Medium_Explosions__raw;
                set {
                    if (Wyvernsnipe_Number_of_Medium_Explosions__raw == value) return;
                    Wyvernsnipe_Number_of_Medium_Explosions__raw = value;
                    ChangedItems.Add(nameof(Wyvernsnipe_Number_of_Medium_Explosions_));
                    OnPropertyChanged(nameof(Wyvernsnipe_Number_of_Medium_Explosions_));
                }
            }

            [DisplayName("Offset")]
            public long Wyvernsnipe_Number_of_Medium_Explosions__offset { get; private set; }

            protected byte Wyvernsnipe_Number_of_Larger_Explosions__raw;
            public const string Wyvernsnipe_Number_of_Larger_Explosions__displayName = "Wyvernsnipe Number of Larger Explosions?";
            public const int Wyvernsnipe_Number_of_Larger_Explosions__sortIndex = 900;
            [SortOrder(Wyvernsnipe_Number_of_Larger_Explosions__sortIndex)]
            [DisplayName(Wyvernsnipe_Number_of_Larger_Explosions__displayName)]
            public virtual byte Wyvernsnipe_Number_of_Larger_Explosions_ {
                get => Wyvernsnipe_Number_of_Larger_Explosions__raw;
                set {
                    if (Wyvernsnipe_Number_of_Larger_Explosions__raw == value) return;
                    Wyvernsnipe_Number_of_Larger_Explosions__raw = value;
                    ChangedItems.Add(nameof(Wyvernsnipe_Number_of_Larger_Explosions_));
                    OnPropertyChanged(nameof(Wyvernsnipe_Number_of_Larger_Explosions_));
                }
            }

            [DisplayName("Offset")]
            public long Wyvernsnipe_Number_of_Larger_Explosions__offset { get; private set; }

            protected byte Wyvernsnipe_Number_of_End_Explosions__raw;
            public const string Wyvernsnipe_Number_of_End_Explosions__displayName = "Wyvernsnipe Number of End Explosions?";
            public const int Wyvernsnipe_Number_of_End_Explosions__sortIndex = 950;
            [SortOrder(Wyvernsnipe_Number_of_End_Explosions__sortIndex)]
            [DisplayName(Wyvernsnipe_Number_of_End_Explosions__displayName)]
            public virtual byte Wyvernsnipe_Number_of_End_Explosions_ {
                get => Wyvernsnipe_Number_of_End_Explosions__raw;
                set {
                    if (Wyvernsnipe_Number_of_End_Explosions__raw == value) return;
                    Wyvernsnipe_Number_of_End_Explosions__raw = value;
                    ChangedItems.Add(nameof(Wyvernsnipe_Number_of_End_Explosions_));
                    OnPropertyChanged(nameof(Wyvernsnipe_Number_of_End_Explosions_));
                }
            }

            [DisplayName("Offset")]
            public long Wyvernsnipe_Number_of_End_Explosions__offset { get; private set; }

            protected float Unk_236_raw;
            public const string Unk_236_displayName = "Unk 236";
            public const int Unk_236_sortIndex = 1000;
            [SortOrder(Unk_236_sortIndex)]
            [DisplayName(Unk_236_displayName)]
            public virtual float Unk_236 {
                get => Unk_236_raw;
                set {
                    if (Unk_236_raw == value) return;
                    Unk_236_raw = value;
                    ChangedItems.Add(nameof(Unk_236));
                    OnPropertyChanged(nameof(Unk_236));
                }
            }

            [DisplayName("Offset")]
            public long Unk_236_offset { get; private set; }

            protected float Unk_237_raw;
            public const string Unk_237_displayName = "Unk 237";
            public const int Unk_237_sortIndex = 1050;
            [SortOrder(Unk_237_sortIndex)]
            [DisplayName(Unk_237_displayName)]
            public virtual float Unk_237 {
                get => Unk_237_raw;
                set {
                    if (Unk_237_raw == value) return;
                    Unk_237_raw = value;
                    ChangedItems.Add(nameof(Unk_237));
                    OnPropertyChanged(nameof(Unk_237));
                }
            }

            [DisplayName("Offset")]
            public long Unk_237_offset { get; private set; }

            protected uint Unk_238_raw;
            public const string Unk_238_displayName = "Unk 238";
            public const int Unk_238_sortIndex = 1100;
            [SortOrder(Unk_238_sortIndex)]
            [DisplayName(Unk_238_displayName)]
            public virtual uint Unk_238 {
                get => Unk_238_raw;
                set {
                    if (Unk_238_raw == value) return;
                    Unk_238_raw = value;
                    ChangedItems.Add(nameof(Unk_238));
                    OnPropertyChanged(nameof(Unk_238));
                }
            }

            [DisplayName("Offset")]
            public long Unk_238_offset { get; private set; }

            protected short Unk_239_raw;
            public const string Unk_239_displayName = "Unk 239";
            public const int Unk_239_sortIndex = 1150;
            [SortOrder(Unk_239_sortIndex)]
            [DisplayName(Unk_239_displayName)]
            public virtual short Unk_239 {
                get => Unk_239_raw;
                set {
                    if (Unk_239_raw == value) return;
                    Unk_239_raw = value;
                    ChangedItems.Add(nameof(Unk_239));
                    OnPropertyChanged(nameof(Unk_239));
                }
            }

            [DisplayName("Offset")]
            public long Unk_239_offset { get; private set; }

            public const int lastSortIndex = 1200;

            public static ObservableMhwStructCollection<W13p_Params_5_1_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<W13p_Params_5_1_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W13p_Params_5_1_ LoadData(BinaryReader reader, ulong i) {
                var data = new W13p_Params_5_1_();
                data.Index = i;
                data.Wyvernsnipe_Prone_Movement_Params_1_offset = reader.BaseStream.Position;
                data.Wyvernsnipe_Prone_Movement_Params_1_raw = reader.ReadSingle();
                data.Wyvernsnipe_Prone_Movement_Params_2_offset = reader.BaseStream.Position;
                data.Wyvernsnipe_Prone_Movement_Params_2_raw = reader.ReadSingle();
                data.Wyvernsnipe_Prone_Movement_Params_3_offset = reader.BaseStream.Position;
                data.Wyvernsnipe_Prone_Movement_Params_3_raw = reader.ReadSingle();
                data.Wyvernsnipe_Prone_Movement_Params_4_offset = reader.BaseStream.Position;
                data.Wyvernsnipe_Prone_Movement_Params_4_raw = reader.ReadSingle();
                data.Wyvernsnipe_Prone_Movement_Params_5_offset = reader.BaseStream.Position;
                data.Wyvernsnipe_Prone_Movement_Params_5_raw = reader.ReadSingle();
                data.Wyvernsnipe_Prone_Movement_Params_6_offset = reader.BaseStream.Position;
                data.Wyvernsnipe_Prone_Movement_Params_6_raw = reader.ReadSingle();
                data.Wyvernsnipe_Prone_Movement_Params_7_offset = reader.BaseStream.Position;
                data.Wyvernsnipe_Prone_Movement_Params_7_raw = reader.ReadSingle();
                data.Wyvernsnipe_Prone_Movement_Params_8_offset = reader.BaseStream.Position;
                data.Wyvernsnipe_Prone_Movement_Params_8_raw = reader.ReadSingle();
                data.Wyvernsnipe_Prone_Movement_Params_9_offset = reader.BaseStream.Position;
                data.Wyvernsnipe_Prone_Movement_Params_9_raw = reader.ReadSingle();
                data.Wyvernsnipe_Prone_Movement_Params_10_offset = reader.BaseStream.Position;
                data.Wyvernsnipe_Prone_Movement_Params_10_raw = reader.ReadSingle();
                data.Wyvernsnipe_Prone_Movement_Params_11_offset = reader.BaseStream.Position;
                data.Wyvernsnipe_Prone_Movement_Params_11_raw = reader.ReadSingle();
                data.Wyvernsnipe_Prone_Movement_Params_12_offset = reader.BaseStream.Position;
                data.Wyvernsnipe_Prone_Movement_Params_12_raw = reader.ReadSingle();
                data.Wyvernsnipe_Prone_Movement_Params_13_offset = reader.BaseStream.Position;
                data.Wyvernsnipe_Prone_Movement_Params_13_raw = reader.ReadSingle();
                data.Wyvernsnipe_Prone_Movement_Params_14_offset = reader.BaseStream.Position;
                data.Wyvernsnipe_Prone_Movement_Params_14_raw = reader.ReadSingle();
                data.Wyrmsnipe_Capacity_offset = reader.BaseStream.Position;
                data.Wyrmsnipe_Capacity_raw = reader.ReadByte();
                data.Wyrmsnipe_Cooldown_offset = reader.BaseStream.Position;
                data.Wyrmsnipe_Cooldown_raw = reader.ReadSingle();
                data.Wyvernsnipe_Number_of_Medium_Explosions__offset = reader.BaseStream.Position;
                data.Wyvernsnipe_Number_of_Medium_Explosions__raw = reader.ReadByte();
                data.Wyvernsnipe_Number_of_Larger_Explosions__offset = reader.BaseStream.Position;
                data.Wyvernsnipe_Number_of_Larger_Explosions__raw = reader.ReadByte();
                data.Wyvernsnipe_Number_of_End_Explosions__offset = reader.BaseStream.Position;
                data.Wyvernsnipe_Number_of_End_Explosions__raw = reader.ReadByte();
                data.Unk_236_offset = reader.BaseStream.Position;
                data.Unk_236_raw = reader.ReadSingle();
                data.Unk_237_offset = reader.BaseStream.Position;
                data.Unk_237_raw = reader.ReadSingle();
                data.Unk_238_offset = reader.BaseStream.Position;
                data.Unk_238_raw = reader.ReadUInt32();
                data.Unk_239_offset = reader.BaseStream.Position;
                data.Unk_239_raw = reader.ReadInt16();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Wyvernsnipe_Prone_Movement_Params_1_raw);
                writer.Write(Wyvernsnipe_Prone_Movement_Params_2_raw);
                writer.Write(Wyvernsnipe_Prone_Movement_Params_3_raw);
                writer.Write(Wyvernsnipe_Prone_Movement_Params_4_raw);
                writer.Write(Wyvernsnipe_Prone_Movement_Params_5_raw);
                writer.Write(Wyvernsnipe_Prone_Movement_Params_6_raw);
                writer.Write(Wyvernsnipe_Prone_Movement_Params_7_raw);
                writer.Write(Wyvernsnipe_Prone_Movement_Params_8_raw);
                writer.Write(Wyvernsnipe_Prone_Movement_Params_9_raw);
                writer.Write(Wyvernsnipe_Prone_Movement_Params_10_raw);
                writer.Write(Wyvernsnipe_Prone_Movement_Params_11_raw);
                writer.Write(Wyvernsnipe_Prone_Movement_Params_12_raw);
                writer.Write(Wyvernsnipe_Prone_Movement_Params_13_raw);
                writer.Write(Wyvernsnipe_Prone_Movement_Params_14_raw);
                writer.Write(Wyrmsnipe_Capacity_raw);
                writer.Write(Wyrmsnipe_Cooldown_raw);
                writer.Write(Wyvernsnipe_Number_of_Medium_Explosions__raw);
                writer.Write(Wyvernsnipe_Number_of_Larger_Explosions__raw);
                writer.Write(Wyvernsnipe_Number_of_End_Explosions__raw);
                writer.Write(Unk_236_raw);
                writer.Write(Unk_237_raw);
                writer.Write(Unk_238_raw);
                writer.Write(Unk_239_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Wyvernsnipe Prone Movement Params 1", "Wyvernsnipe_Prone_Movement_Params_1", "Wyvernsnipe_Prone_Movement_Params_1_offset"),
                    new MultiStructItemCustomView(this, "Wyvernsnipe Prone Movement Params 2", "Wyvernsnipe_Prone_Movement_Params_2", "Wyvernsnipe_Prone_Movement_Params_2_offset"),
                    new MultiStructItemCustomView(this, "Wyvernsnipe Prone Movement Params 3", "Wyvernsnipe_Prone_Movement_Params_3", "Wyvernsnipe_Prone_Movement_Params_3_offset"),
                    new MultiStructItemCustomView(this, "Wyvernsnipe Prone Movement Params 4", "Wyvernsnipe_Prone_Movement_Params_4", "Wyvernsnipe_Prone_Movement_Params_4_offset"),
                    new MultiStructItemCustomView(this, "Wyvernsnipe Prone Movement Params 5", "Wyvernsnipe_Prone_Movement_Params_5", "Wyvernsnipe_Prone_Movement_Params_5_offset"),
                    new MultiStructItemCustomView(this, "Wyvernsnipe Prone Movement Params 6", "Wyvernsnipe_Prone_Movement_Params_6", "Wyvernsnipe_Prone_Movement_Params_6_offset"),
                    new MultiStructItemCustomView(this, "Wyvernsnipe Prone Movement Params 7", "Wyvernsnipe_Prone_Movement_Params_7", "Wyvernsnipe_Prone_Movement_Params_7_offset"),
                    new MultiStructItemCustomView(this, "Wyvernsnipe Prone Movement Params 8", "Wyvernsnipe_Prone_Movement_Params_8", "Wyvernsnipe_Prone_Movement_Params_8_offset"),
                    new MultiStructItemCustomView(this, "Wyvernsnipe Prone Movement Params 9", "Wyvernsnipe_Prone_Movement_Params_9", "Wyvernsnipe_Prone_Movement_Params_9_offset"),
                    new MultiStructItemCustomView(this, "Wyvernsnipe Prone Movement Params 10", "Wyvernsnipe_Prone_Movement_Params_10", "Wyvernsnipe_Prone_Movement_Params_10_offset"),
                    new MultiStructItemCustomView(this, "Wyvernsnipe Prone Movement Params 11", "Wyvernsnipe_Prone_Movement_Params_11", "Wyvernsnipe_Prone_Movement_Params_11_offset"),
                    new MultiStructItemCustomView(this, "Wyvernsnipe Prone Movement Params 12", "Wyvernsnipe_Prone_Movement_Params_12", "Wyvernsnipe_Prone_Movement_Params_12_offset"),
                    new MultiStructItemCustomView(this, "Wyvernsnipe Prone Movement Params 13", "Wyvernsnipe_Prone_Movement_Params_13", "Wyvernsnipe_Prone_Movement_Params_13_offset"),
                    new MultiStructItemCustomView(this, "Wyvernsnipe Prone Movement Params 14", "Wyvernsnipe_Prone_Movement_Params_14", "Wyvernsnipe_Prone_Movement_Params_14_offset"),
                    new MultiStructItemCustomView(this, "Wyrmsnipe Capacity", "Wyrmsnipe_Capacity", "Wyrmsnipe_Capacity_offset"),
                    new MultiStructItemCustomView(this, "Wyrmsnipe Cooldown", "Wyrmsnipe_Cooldown", "Wyrmsnipe_Cooldown_offset"),
                    new MultiStructItemCustomView(this, "Wyvernsnipe Number of Medium Explosions?", "Wyvernsnipe_Number_of_Medium_Explosions_", "Wyvernsnipe_Number_of_Medium_Explosions__offset"),
                    new MultiStructItemCustomView(this, "Wyvernsnipe Number of Larger Explosions?", "Wyvernsnipe_Number_of_Larger_Explosions_", "Wyvernsnipe_Number_of_Larger_Explosions__offset"),
                    new MultiStructItemCustomView(this, "Wyvernsnipe Number of End Explosions?", "Wyvernsnipe_Number_of_End_Explosions_", "Wyvernsnipe_Number_of_End_Explosions__offset"),
                    new MultiStructItemCustomView(this, "Unk 236", "Unk_236", "Unk_236_offset"),
                    new MultiStructItemCustomView(this, "Unk 237", "Unk_237", "Unk_237_offset"),
                    new MultiStructItemCustomView(this, "Unk 238", "Unk_238", "Unk_238_offset"),
                    new MultiStructItemCustomView(this, "Unk 239", "Unk_239", "Unk_239_offset"),
                };
            }
        }

        public partial class Unk_Arr_3 : MhwStructItem, IWriteData {
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
                    ChangedItems.Add(nameof(Unk_1));
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
                    ChangedItems.Add(nameof(Unk_2));
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
                    ChangedItems.Add(nameof(Unk_3));
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
                    ChangedItems.Add(nameof(Unk_4));
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
                    ChangedItems.Add(nameof(Unk_5));
                    OnPropertyChanged(nameof(Unk_5));
                }
            }

            public const int lastSortIndex = 300;

            public static ObservableMhwStructCollection<Unk_Arr_3> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Unk_Arr_3>();
                const ulong count = 16UL;
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

        public partial class Bowgun_Deviation_Last_One_Maybe_High_Plus_Felyne_Meal_ : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 4;
            public const string GridName = "Bowgun Deviation (Last One Maybe High + Felyne Meal)";

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
                    ChangedItems.Add(nameof(Unk_1));
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
                    ChangedItems.Add(nameof(Unk_2));
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
                    ChangedItems.Add(nameof(Unk_3));
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
                    ChangedItems.Add(nameof(Unk_4));
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
                    ChangedItems.Add(nameof(Unk_5));
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
                    ChangedItems.Add(nameof(Unk_6));
                    OnPropertyChanged(nameof(Unk_6));
                }
            }

            public const int lastSortIndex = 350;

            public static ObservableMhwStructCollection<Bowgun_Deviation_Last_One_Maybe_High_Plus_Felyne_Meal_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Bowgun_Deviation_Last_One_Maybe_High_Plus_Felyne_Meal_>();
                const ulong count = 4UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Bowgun_Deviation_Last_One_Maybe_High_Plus_Felyne_Meal_ LoadData(BinaryReader reader, ulong i) {
                var data = new Bowgun_Deviation_Last_One_Maybe_High_Plus_Felyne_Meal_();
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

        public partial class Ammo_Shifting : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 17;
            public const string GridName = "Ammo Shifting";

            protected float Vertical_raw;
            public const string Vertical_displayName = "Vertical";
            public const int Vertical_sortIndex = 50;
            [SortOrder(Vertical_sortIndex)]
            [DisplayName(Vertical_displayName)]
            public virtual float Vertical {
                get => Vertical_raw;
                set {
                    if (Vertical_raw == value) return;
                    Vertical_raw = value;
                    ChangedItems.Add(nameof(Vertical));
                    OnPropertyChanged(nameof(Vertical));
                }
            }

            protected float Horizontal_raw;
            public const string Horizontal_displayName = "Horizontal";
            public const int Horizontal_sortIndex = 100;
            [SortOrder(Horizontal_sortIndex)]
            [DisplayName(Horizontal_displayName)]
            public virtual float Horizontal {
                get => Horizontal_raw;
                set {
                    if (Horizontal_raw == value) return;
                    Horizontal_raw = value;
                    ChangedItems.Add(nameof(Horizontal));
                    OnPropertyChanged(nameof(Horizontal));
                }
            }

            public const int lastSortIndex = 150;

            public static ObservableMhwStructCollection<Ammo_Shifting> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Ammo_Shifting>();
                const ulong count = 17UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Ammo_Shifting LoadData(BinaryReader reader, ulong i) {
                var data = new Ammo_Shifting();
                data.Index = i;
                data.Vertical_raw = reader.ReadSingle();
                data.Horizontal_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Vertical_raw);
                writer.Write(Horizontal_raw);
            }
        }

        public partial class W13p_Params_6_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W13p Params (6)";

            protected float Close_range_Up_active_range_1_raw;
            public const string Close_range_Up_active_range_1_displayName = "Close range Up active range 1";
            public const int Close_range_Up_active_range_1_sortIndex = 50;
            [SortOrder(Close_range_Up_active_range_1_sortIndex)]
            [DisplayName(Close_range_Up_active_range_1_displayName)]
            public virtual float Close_range_Up_active_range_1 {
                get => Close_range_Up_active_range_1_raw;
                set {
                    if (Close_range_Up_active_range_1_raw == value) return;
                    Close_range_Up_active_range_1_raw = value;
                    ChangedItems.Add(nameof(Close_range_Up_active_range_1));
                    OnPropertyChanged(nameof(Close_range_Up_active_range_1));
                }
            }

            [DisplayName("Offset")]
            public long Close_range_Up_active_range_1_offset { get; private set; }

            protected float Close_range_Up_active_range_2_raw;
            public const string Close_range_Up_active_range_2_displayName = "Close range Up active range 2";
            public const int Close_range_Up_active_range_2_sortIndex = 100;
            [SortOrder(Close_range_Up_active_range_2_sortIndex)]
            [DisplayName(Close_range_Up_active_range_2_displayName)]
            public virtual float Close_range_Up_active_range_2 {
                get => Close_range_Up_active_range_2_raw;
                set {
                    if (Close_range_Up_active_range_2_raw == value) return;
                    Close_range_Up_active_range_2_raw = value;
                    ChangedItems.Add(nameof(Close_range_Up_active_range_2));
                    OnPropertyChanged(nameof(Close_range_Up_active_range_2));
                }
            }

            [DisplayName("Offset")]
            public long Close_range_Up_active_range_2_offset { get; private set; }

            protected float Close_range_Up_active_range_3_raw;
            public const string Close_range_Up_active_range_3_displayName = "Close range Up active range 3";
            public const int Close_range_Up_active_range_3_sortIndex = 150;
            [SortOrder(Close_range_Up_active_range_3_sortIndex)]
            [DisplayName(Close_range_Up_active_range_3_displayName)]
            public virtual float Close_range_Up_active_range_3 {
                get => Close_range_Up_active_range_3_raw;
                set {
                    if (Close_range_Up_active_range_3_raw == value) return;
                    Close_range_Up_active_range_3_raw = value;
                    ChangedItems.Add(nameof(Close_range_Up_active_range_3));
                    OnPropertyChanged(nameof(Close_range_Up_active_range_3));
                }
            }

            [DisplayName("Offset")]
            public long Close_range_Up_active_range_3_offset { get; private set; }

            protected float Close_range_Up_active_range_4_raw;
            public const string Close_range_Up_active_range_4_displayName = "Close range Up active range 4";
            public const int Close_range_Up_active_range_4_sortIndex = 200;
            [SortOrder(Close_range_Up_active_range_4_sortIndex)]
            [DisplayName(Close_range_Up_active_range_4_displayName)]
            public virtual float Close_range_Up_active_range_4 {
                get => Close_range_Up_active_range_4_raw;
                set {
                    if (Close_range_Up_active_range_4_raw == value) return;
                    Close_range_Up_active_range_4_raw = value;
                    ChangedItems.Add(nameof(Close_range_Up_active_range_4));
                    OnPropertyChanged(nameof(Close_range_Up_active_range_4));
                }
            }

            [DisplayName("Offset")]
            public long Close_range_Up_active_range_4_offset { get; private set; }

            protected float Close_range_Up_Modifier_1_raw;
            public const string Close_range_Up_Modifier_1_displayName = "Close range Up Modifier 1";
            public const int Close_range_Up_Modifier_1_sortIndex = 250;
            [SortOrder(Close_range_Up_Modifier_1_sortIndex)]
            [DisplayName(Close_range_Up_Modifier_1_displayName)]
            public virtual float Close_range_Up_Modifier_1 {
                get => Close_range_Up_Modifier_1_raw;
                set {
                    if (Close_range_Up_Modifier_1_raw == value) return;
                    Close_range_Up_Modifier_1_raw = value;
                    ChangedItems.Add(nameof(Close_range_Up_Modifier_1));
                    OnPropertyChanged(nameof(Close_range_Up_Modifier_1));
                }
            }

            [DisplayName("Offset")]
            public long Close_range_Up_Modifier_1_offset { get; private set; }

            protected float Close_range_Up_Modifier_2_raw;
            public const string Close_range_Up_Modifier_2_displayName = "Close range Up Modifier 2";
            public const int Close_range_Up_Modifier_2_sortIndex = 300;
            [SortOrder(Close_range_Up_Modifier_2_sortIndex)]
            [DisplayName(Close_range_Up_Modifier_2_displayName)]
            public virtual float Close_range_Up_Modifier_2 {
                get => Close_range_Up_Modifier_2_raw;
                set {
                    if (Close_range_Up_Modifier_2_raw == value) return;
                    Close_range_Up_Modifier_2_raw = value;
                    ChangedItems.Add(nameof(Close_range_Up_Modifier_2));
                    OnPropertyChanged(nameof(Close_range_Up_Modifier_2));
                }
            }

            [DisplayName("Offset")]
            public long Close_range_Up_Modifier_2_offset { get; private set; }

            protected float Close_range_Up_Modifier_3_raw;
            public const string Close_range_Up_Modifier_3_displayName = "Close range Up Modifier 3";
            public const int Close_range_Up_Modifier_3_sortIndex = 350;
            [SortOrder(Close_range_Up_Modifier_3_sortIndex)]
            [DisplayName(Close_range_Up_Modifier_3_displayName)]
            public virtual float Close_range_Up_Modifier_3 {
                get => Close_range_Up_Modifier_3_raw;
                set {
                    if (Close_range_Up_Modifier_3_raw == value) return;
                    Close_range_Up_Modifier_3_raw = value;
                    ChangedItems.Add(nameof(Close_range_Up_Modifier_3));
                    OnPropertyChanged(nameof(Close_range_Up_Modifier_3));
                }
            }

            [DisplayName("Offset")]
            public long Close_range_Up_Modifier_3_offset { get; private set; }

            protected float Close_range_Up_Modifier_4_raw;
            public const string Close_range_Up_Modifier_4_displayName = "Close range Up Modifier 4";
            public const int Close_range_Up_Modifier_4_sortIndex = 400;
            [SortOrder(Close_range_Up_Modifier_4_sortIndex)]
            [DisplayName(Close_range_Up_Modifier_4_displayName)]
            public virtual float Close_range_Up_Modifier_4 {
                get => Close_range_Up_Modifier_4_raw;
                set {
                    if (Close_range_Up_Modifier_4_raw == value) return;
                    Close_range_Up_Modifier_4_raw = value;
                    ChangedItems.Add(nameof(Close_range_Up_Modifier_4));
                    OnPropertyChanged(nameof(Close_range_Up_Modifier_4));
                }
            }

            [DisplayName("Offset")]
            public long Close_range_Up_Modifier_4_offset { get; private set; }

            protected float Ranged_Attack_Up_Active_Distance_1_raw;
            public const string Ranged_Attack_Up_Active_Distance_1_displayName = "Ranged Attack Up Active Distance 1";
            public const int Ranged_Attack_Up_Active_Distance_1_sortIndex = 450;
            [SortOrder(Ranged_Attack_Up_Active_Distance_1_sortIndex)]
            [DisplayName(Ranged_Attack_Up_Active_Distance_1_displayName)]
            public virtual float Ranged_Attack_Up_Active_Distance_1 {
                get => Ranged_Attack_Up_Active_Distance_1_raw;
                set {
                    if (Ranged_Attack_Up_Active_Distance_1_raw == value) return;
                    Ranged_Attack_Up_Active_Distance_1_raw = value;
                    ChangedItems.Add(nameof(Ranged_Attack_Up_Active_Distance_1));
                    OnPropertyChanged(nameof(Ranged_Attack_Up_Active_Distance_1));
                }
            }

            [DisplayName("Offset")]
            public long Ranged_Attack_Up_Active_Distance_1_offset { get; private set; }

            protected float Ranged_Attack_Up_Active_Distance_2_raw;
            public const string Ranged_Attack_Up_Active_Distance_2_displayName = "Ranged Attack Up Active Distance 2";
            public const int Ranged_Attack_Up_Active_Distance_2_sortIndex = 500;
            [SortOrder(Ranged_Attack_Up_Active_Distance_2_sortIndex)]
            [DisplayName(Ranged_Attack_Up_Active_Distance_2_displayName)]
            public virtual float Ranged_Attack_Up_Active_Distance_2 {
                get => Ranged_Attack_Up_Active_Distance_2_raw;
                set {
                    if (Ranged_Attack_Up_Active_Distance_2_raw == value) return;
                    Ranged_Attack_Up_Active_Distance_2_raw = value;
                    ChangedItems.Add(nameof(Ranged_Attack_Up_Active_Distance_2));
                    OnPropertyChanged(nameof(Ranged_Attack_Up_Active_Distance_2));
                }
            }

            [DisplayName("Offset")]
            public long Ranged_Attack_Up_Active_Distance_2_offset { get; private set; }

            protected float Ranged_Attack_Up_Active_Distance_3_raw;
            public const string Ranged_Attack_Up_Active_Distance_3_displayName = "Ranged Attack Up Active Distance 3";
            public const int Ranged_Attack_Up_Active_Distance_3_sortIndex = 550;
            [SortOrder(Ranged_Attack_Up_Active_Distance_3_sortIndex)]
            [DisplayName(Ranged_Attack_Up_Active_Distance_3_displayName)]
            public virtual float Ranged_Attack_Up_Active_Distance_3 {
                get => Ranged_Attack_Up_Active_Distance_3_raw;
                set {
                    if (Ranged_Attack_Up_Active_Distance_3_raw == value) return;
                    Ranged_Attack_Up_Active_Distance_3_raw = value;
                    ChangedItems.Add(nameof(Ranged_Attack_Up_Active_Distance_3));
                    OnPropertyChanged(nameof(Ranged_Attack_Up_Active_Distance_3));
                }
            }

            [DisplayName("Offset")]
            public long Ranged_Attack_Up_Active_Distance_3_offset { get; private set; }

            protected float Ranged_Attack_Up_Active_Distance_4_raw;
            public const string Ranged_Attack_Up_Active_Distance_4_displayName = "Ranged Attack Up Active Distance 4";
            public const int Ranged_Attack_Up_Active_Distance_4_sortIndex = 600;
            [SortOrder(Ranged_Attack_Up_Active_Distance_4_sortIndex)]
            [DisplayName(Ranged_Attack_Up_Active_Distance_4_displayName)]
            public virtual float Ranged_Attack_Up_Active_Distance_4 {
                get => Ranged_Attack_Up_Active_Distance_4_raw;
                set {
                    if (Ranged_Attack_Up_Active_Distance_4_raw == value) return;
                    Ranged_Attack_Up_Active_Distance_4_raw = value;
                    ChangedItems.Add(nameof(Ranged_Attack_Up_Active_Distance_4));
                    OnPropertyChanged(nameof(Ranged_Attack_Up_Active_Distance_4));
                }
            }

            [DisplayName("Offset")]
            public long Ranged_Attack_Up_Active_Distance_4_offset { get; private set; }

            protected float Ranged_Attack_Up_Modifier_1_raw;
            public const string Ranged_Attack_Up_Modifier_1_displayName = "Ranged Attack Up Modifier 1";
            public const int Ranged_Attack_Up_Modifier_1_sortIndex = 650;
            [SortOrder(Ranged_Attack_Up_Modifier_1_sortIndex)]
            [DisplayName(Ranged_Attack_Up_Modifier_1_displayName)]
            public virtual float Ranged_Attack_Up_Modifier_1 {
                get => Ranged_Attack_Up_Modifier_1_raw;
                set {
                    if (Ranged_Attack_Up_Modifier_1_raw == value) return;
                    Ranged_Attack_Up_Modifier_1_raw = value;
                    ChangedItems.Add(nameof(Ranged_Attack_Up_Modifier_1));
                    OnPropertyChanged(nameof(Ranged_Attack_Up_Modifier_1));
                }
            }

            [DisplayName("Offset")]
            public long Ranged_Attack_Up_Modifier_1_offset { get; private set; }

            protected float Ranged_Attack_Up_Modifier_2_raw;
            public const string Ranged_Attack_Up_Modifier_2_displayName = "Ranged Attack Up Modifier 2";
            public const int Ranged_Attack_Up_Modifier_2_sortIndex = 700;
            [SortOrder(Ranged_Attack_Up_Modifier_2_sortIndex)]
            [DisplayName(Ranged_Attack_Up_Modifier_2_displayName)]
            public virtual float Ranged_Attack_Up_Modifier_2 {
                get => Ranged_Attack_Up_Modifier_2_raw;
                set {
                    if (Ranged_Attack_Up_Modifier_2_raw == value) return;
                    Ranged_Attack_Up_Modifier_2_raw = value;
                    ChangedItems.Add(nameof(Ranged_Attack_Up_Modifier_2));
                    OnPropertyChanged(nameof(Ranged_Attack_Up_Modifier_2));
                }
            }

            [DisplayName("Offset")]
            public long Ranged_Attack_Up_Modifier_2_offset { get; private set; }

            protected float Ranged_Attack_Up_Modifier_3_raw;
            public const string Ranged_Attack_Up_Modifier_3_displayName = "Ranged Attack Up Modifier 3";
            public const int Ranged_Attack_Up_Modifier_3_sortIndex = 750;
            [SortOrder(Ranged_Attack_Up_Modifier_3_sortIndex)]
            [DisplayName(Ranged_Attack_Up_Modifier_3_displayName)]
            public virtual float Ranged_Attack_Up_Modifier_3 {
                get => Ranged_Attack_Up_Modifier_3_raw;
                set {
                    if (Ranged_Attack_Up_Modifier_3_raw == value) return;
                    Ranged_Attack_Up_Modifier_3_raw = value;
                    ChangedItems.Add(nameof(Ranged_Attack_Up_Modifier_3));
                    OnPropertyChanged(nameof(Ranged_Attack_Up_Modifier_3));
                }
            }

            [DisplayName("Offset")]
            public long Ranged_Attack_Up_Modifier_3_offset { get; private set; }

            protected float Ranged_Attack_Up_Modifier_4_raw;
            public const string Ranged_Attack_Up_Modifier_4_displayName = "Ranged Attack Up Modifier 4";
            public const int Ranged_Attack_Up_Modifier_4_sortIndex = 800;
            [SortOrder(Ranged_Attack_Up_Modifier_4_sortIndex)]
            [DisplayName(Ranged_Attack_Up_Modifier_4_displayName)]
            public virtual float Ranged_Attack_Up_Modifier_4 {
                get => Ranged_Attack_Up_Modifier_4_raw;
                set {
                    if (Ranged_Attack_Up_Modifier_4_raw == value) return;
                    Ranged_Attack_Up_Modifier_4_raw = value;
                    ChangedItems.Add(nameof(Ranged_Attack_Up_Modifier_4));
                    OnPropertyChanged(nameof(Ranged_Attack_Up_Modifier_4));
                }
            }

            [DisplayName("Offset")]
            public long Ranged_Attack_Up_Modifier_4_offset { get; private set; }

            protected float Guard_Angle_Both_Sides__raw;
            public const string Guard_Angle_Both_Sides__displayName = "Guard Angle (Both Sides)";
            public const int Guard_Angle_Both_Sides__sortIndex = 850;
            [SortOrder(Guard_Angle_Both_Sides__sortIndex)]
            [DisplayName(Guard_Angle_Both_Sides__displayName)]
            public virtual float Guard_Angle_Both_Sides_ {
                get => Guard_Angle_Both_Sides__raw;
                set {
                    if (Guard_Angle_Both_Sides__raw == value) return;
                    Guard_Angle_Both_Sides__raw = value;
                    ChangedItems.Add(nameof(Guard_Angle_Both_Sides_));
                    OnPropertyChanged(nameof(Guard_Angle_Both_Sides_));
                }
            }

            [DisplayName("Offset")]
            public long Guard_Angle_Both_Sides__offset { get; private set; }

            public const int lastSortIndex = 900;

            public static ObservableMhwStructCollection<W13p_Params_6_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<W13p_Params_6_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W13p_Params_6_ LoadData(BinaryReader reader, ulong i) {
                var data = new W13p_Params_6_();
                data.Index = i;
                data.Close_range_Up_active_range_1_offset = reader.BaseStream.Position;
                data.Close_range_Up_active_range_1_raw = reader.ReadSingle();
                data.Close_range_Up_active_range_2_offset = reader.BaseStream.Position;
                data.Close_range_Up_active_range_2_raw = reader.ReadSingle();
                data.Close_range_Up_active_range_3_offset = reader.BaseStream.Position;
                data.Close_range_Up_active_range_3_raw = reader.ReadSingle();
                data.Close_range_Up_active_range_4_offset = reader.BaseStream.Position;
                data.Close_range_Up_active_range_4_raw = reader.ReadSingle();
                data.Close_range_Up_Modifier_1_offset = reader.BaseStream.Position;
                data.Close_range_Up_Modifier_1_raw = reader.ReadSingle();
                data.Close_range_Up_Modifier_2_offset = reader.BaseStream.Position;
                data.Close_range_Up_Modifier_2_raw = reader.ReadSingle();
                data.Close_range_Up_Modifier_3_offset = reader.BaseStream.Position;
                data.Close_range_Up_Modifier_3_raw = reader.ReadSingle();
                data.Close_range_Up_Modifier_4_offset = reader.BaseStream.Position;
                data.Close_range_Up_Modifier_4_raw = reader.ReadSingle();
                data.Ranged_Attack_Up_Active_Distance_1_offset = reader.BaseStream.Position;
                data.Ranged_Attack_Up_Active_Distance_1_raw = reader.ReadSingle();
                data.Ranged_Attack_Up_Active_Distance_2_offset = reader.BaseStream.Position;
                data.Ranged_Attack_Up_Active_Distance_2_raw = reader.ReadSingle();
                data.Ranged_Attack_Up_Active_Distance_3_offset = reader.BaseStream.Position;
                data.Ranged_Attack_Up_Active_Distance_3_raw = reader.ReadSingle();
                data.Ranged_Attack_Up_Active_Distance_4_offset = reader.BaseStream.Position;
                data.Ranged_Attack_Up_Active_Distance_4_raw = reader.ReadSingle();
                data.Ranged_Attack_Up_Modifier_1_offset = reader.BaseStream.Position;
                data.Ranged_Attack_Up_Modifier_1_raw = reader.ReadSingle();
                data.Ranged_Attack_Up_Modifier_2_offset = reader.BaseStream.Position;
                data.Ranged_Attack_Up_Modifier_2_raw = reader.ReadSingle();
                data.Ranged_Attack_Up_Modifier_3_offset = reader.BaseStream.Position;
                data.Ranged_Attack_Up_Modifier_3_raw = reader.ReadSingle();
                data.Ranged_Attack_Up_Modifier_4_offset = reader.BaseStream.Position;
                data.Ranged_Attack_Up_Modifier_4_raw = reader.ReadSingle();
                data.Guard_Angle_Both_Sides__offset = reader.BaseStream.Position;
                data.Guard_Angle_Both_Sides__raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Close_range_Up_active_range_1_raw);
                writer.Write(Close_range_Up_active_range_2_raw);
                writer.Write(Close_range_Up_active_range_3_raw);
                writer.Write(Close_range_Up_active_range_4_raw);
                writer.Write(Close_range_Up_Modifier_1_raw);
                writer.Write(Close_range_Up_Modifier_2_raw);
                writer.Write(Close_range_Up_Modifier_3_raw);
                writer.Write(Close_range_Up_Modifier_4_raw);
                writer.Write(Ranged_Attack_Up_Active_Distance_1_raw);
                writer.Write(Ranged_Attack_Up_Active_Distance_2_raw);
                writer.Write(Ranged_Attack_Up_Active_Distance_3_raw);
                writer.Write(Ranged_Attack_Up_Active_Distance_4_raw);
                writer.Write(Ranged_Attack_Up_Modifier_1_raw);
                writer.Write(Ranged_Attack_Up_Modifier_2_raw);
                writer.Write(Ranged_Attack_Up_Modifier_3_raw);
                writer.Write(Ranged_Attack_Up_Modifier_4_raw);
                writer.Write(Guard_Angle_Both_Sides__raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Close range Up active range 1", "Close_range_Up_active_range_1", "Close_range_Up_active_range_1_offset"),
                    new MultiStructItemCustomView(this, "Close range Up active range 2", "Close_range_Up_active_range_2", "Close_range_Up_active_range_2_offset"),
                    new MultiStructItemCustomView(this, "Close range Up active range 3", "Close_range_Up_active_range_3", "Close_range_Up_active_range_3_offset"),
                    new MultiStructItemCustomView(this, "Close range Up active range 4", "Close_range_Up_active_range_4", "Close_range_Up_active_range_4_offset"),
                    new MultiStructItemCustomView(this, "Close range Up Modifier 1", "Close_range_Up_Modifier_1", "Close_range_Up_Modifier_1_offset"),
                    new MultiStructItemCustomView(this, "Close range Up Modifier 2", "Close_range_Up_Modifier_2", "Close_range_Up_Modifier_2_offset"),
                    new MultiStructItemCustomView(this, "Close range Up Modifier 3", "Close_range_Up_Modifier_3", "Close_range_Up_Modifier_3_offset"),
                    new MultiStructItemCustomView(this, "Close range Up Modifier 4", "Close_range_Up_Modifier_4", "Close_range_Up_Modifier_4_offset"),
                    new MultiStructItemCustomView(this, "Ranged Attack Up Active Distance 1", "Ranged_Attack_Up_Active_Distance_1", "Ranged_Attack_Up_Active_Distance_1_offset"),
                    new MultiStructItemCustomView(this, "Ranged Attack Up Active Distance 2", "Ranged_Attack_Up_Active_Distance_2", "Ranged_Attack_Up_Active_Distance_2_offset"),
                    new MultiStructItemCustomView(this, "Ranged Attack Up Active Distance 3", "Ranged_Attack_Up_Active_Distance_3", "Ranged_Attack_Up_Active_Distance_3_offset"),
                    new MultiStructItemCustomView(this, "Ranged Attack Up Active Distance 4", "Ranged_Attack_Up_Active_Distance_4", "Ranged_Attack_Up_Active_Distance_4_offset"),
                    new MultiStructItemCustomView(this, "Ranged Attack Up Modifier 1", "Ranged_Attack_Up_Modifier_1", "Ranged_Attack_Up_Modifier_1_offset"),
                    new MultiStructItemCustomView(this, "Ranged Attack Up Modifier 2", "Ranged_Attack_Up_Modifier_2", "Ranged_Attack_Up_Modifier_2_offset"),
                    new MultiStructItemCustomView(this, "Ranged Attack Up Modifier 3", "Ranged_Attack_Up_Modifier_3", "Ranged_Attack_Up_Modifier_3_offset"),
                    new MultiStructItemCustomView(this, "Ranged Attack Up Modifier 4", "Ranged_Attack_Up_Modifier_4", "Ranged_Attack_Up_Modifier_4_offset"),
                    new MultiStructItemCustomView(this, "Guard Angle (Both Sides)", "Guard_Angle_Both_Sides_", "Guard_Angle_Both_Sides__offset"),
                };
            }
        }

        public partial class Number_of_Shield_Mods_Struct : MhwStructItem, IWriteData {
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
                    ChangedItems.Add(nameof(Number_of_Shield_Mods));
                    OnPropertyChanged(nameof(Number_of_Shield_Mods));
                }
            }

            public const int lastSortIndex = 100;

            public static ObservableMhwStructCollection<Number_of_Shield_Mods_Struct> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Number_of_Shield_Mods_Struct>();
                const ulong count = 1UL;
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

        public partial class Shield_Mods : MhwStructItem, IWriteData {
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
                    ChangedItems.Add(nameof(Small));
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
                    ChangedItems.Add(nameof(Medium));
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
                    ChangedItems.Add(nameof(Large));
                    OnPropertyChanged(nameof(Large));
                }
            }

            public const int lastSortIndex = 200;

            public static ObservableMhwStructCollection<Shield_Mods> LoadData(BinaryReader reader, ObservableMhwStructCollection<Number_of_Shield_Mods_Struct> lastStruct) {
                var list = new ObservableMhwStructCollection<Shield_Mods>();
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

        public partial class W13p_Params_Special_Scope_Params_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W13p Params (Special Scope Params)";

            protected float Special_Scope_FoV_Multiplier_From_Base_3rd_Person_FoV__raw;
            public const string Special_Scope_FoV_Multiplier_From_Base_3rd_Person_FoV__displayName = "Special Scope: FoV Multiplier (From Base 3rd Person FoV)";
            public const int Special_Scope_FoV_Multiplier_From_Base_3rd_Person_FoV__sortIndex = 50;
            [SortOrder(Special_Scope_FoV_Multiplier_From_Base_3rd_Person_FoV__sortIndex)]
            [DisplayName(Special_Scope_FoV_Multiplier_From_Base_3rd_Person_FoV__displayName)]
            public virtual float Special_Scope_FoV_Multiplier_From_Base_3rd_Person_FoV_ {
                get => Special_Scope_FoV_Multiplier_From_Base_3rd_Person_FoV__raw;
                set {
                    if (Special_Scope_FoV_Multiplier_From_Base_3rd_Person_FoV__raw == value) return;
                    Special_Scope_FoV_Multiplier_From_Base_3rd_Person_FoV__raw = value;
                    ChangedItems.Add(nameof(Special_Scope_FoV_Multiplier_From_Base_3rd_Person_FoV_));
                    OnPropertyChanged(nameof(Special_Scope_FoV_Multiplier_From_Base_3rd_Person_FoV_));
                }
            }

            [DisplayName("Offset")]
            public long Special_Scope_FoV_Multiplier_From_Base_3rd_Person_FoV__offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_275));
                    OnPropertyChanged(nameof(Unk_275));
                }
            }

            [DisplayName("Offset")]
            public long Unk_275_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_276));
                    OnPropertyChanged(nameof(Unk_276));
                }
            }

            [DisplayName("Offset")]
            public long Unk_276_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_277));
                    OnPropertyChanged(nameof(Unk_277));
                }
            }

            [DisplayName("Offset")]
            public long Unk_277_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_278));
                    OnPropertyChanged(nameof(Unk_278));
                }
            }

            [DisplayName("Offset")]
            public long Unk_278_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_279));
                    OnPropertyChanged(nameof(Unk_279));
                }
            }

            [DisplayName("Offset")]
            public long Unk_279_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_280));
                    OnPropertyChanged(nameof(Unk_280));
                }
            }

            [DisplayName("Offset")]
            public long Unk_280_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_281));
                    OnPropertyChanged(nameof(Unk_281));
                }
            }

            [DisplayName("Offset")]
            public long Unk_281_offset { get; private set; }

            protected float Special_Scope_Zoom_Ratio_When_Focusing_1_raw;
            public const string Special_Scope_Zoom_Ratio_When_Focusing_1_displayName = "Special Scope: Zoom Ratio When Focusing 1";
            public const int Special_Scope_Zoom_Ratio_When_Focusing_1_sortIndex = 450;
            [SortOrder(Special_Scope_Zoom_Ratio_When_Focusing_1_sortIndex)]
            [DisplayName(Special_Scope_Zoom_Ratio_When_Focusing_1_displayName)]
            public virtual float Special_Scope_Zoom_Ratio_When_Focusing_1 {
                get => Special_Scope_Zoom_Ratio_When_Focusing_1_raw;
                set {
                    if (Special_Scope_Zoom_Ratio_When_Focusing_1_raw == value) return;
                    Special_Scope_Zoom_Ratio_When_Focusing_1_raw = value;
                    ChangedItems.Add(nameof(Special_Scope_Zoom_Ratio_When_Focusing_1));
                    OnPropertyChanged(nameof(Special_Scope_Zoom_Ratio_When_Focusing_1));
                }
            }

            [DisplayName("Offset")]
            public long Special_Scope_Zoom_Ratio_When_Focusing_1_offset { get; private set; }

            protected float Special_Scope_Zoom_Ratio_When_Focusing_2_raw;
            public const string Special_Scope_Zoom_Ratio_When_Focusing_2_displayName = "Special Scope: Zoom Ratio When Focusing 2";
            public const int Special_Scope_Zoom_Ratio_When_Focusing_2_sortIndex = 500;
            [SortOrder(Special_Scope_Zoom_Ratio_When_Focusing_2_sortIndex)]
            [DisplayName(Special_Scope_Zoom_Ratio_When_Focusing_2_displayName)]
            public virtual float Special_Scope_Zoom_Ratio_When_Focusing_2 {
                get => Special_Scope_Zoom_Ratio_When_Focusing_2_raw;
                set {
                    if (Special_Scope_Zoom_Ratio_When_Focusing_2_raw == value) return;
                    Special_Scope_Zoom_Ratio_When_Focusing_2_raw = value;
                    ChangedItems.Add(nameof(Special_Scope_Zoom_Ratio_When_Focusing_2));
                    OnPropertyChanged(nameof(Special_Scope_Zoom_Ratio_When_Focusing_2));
                }
            }

            [DisplayName("Offset")]
            public long Special_Scope_Zoom_Ratio_When_Focusing_2_offset { get; private set; }

            public const int lastSortIndex = 550;

            public static ObservableMhwStructCollection<W13p_Params_Special_Scope_Params_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<W13p_Params_Special_Scope_Params_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W13p_Params_Special_Scope_Params_ LoadData(BinaryReader reader, ulong i) {
                var data = new W13p_Params_Special_Scope_Params_();
                data.Index = i;
                data.Special_Scope_FoV_Multiplier_From_Base_3rd_Person_FoV__offset = reader.BaseStream.Position;
                data.Special_Scope_FoV_Multiplier_From_Base_3rd_Person_FoV__raw = reader.ReadSingle();
                data.Unk_275_offset = reader.BaseStream.Position;
                data.Unk_275_raw = reader.ReadSingle();
                data.Unk_276_offset = reader.BaseStream.Position;
                data.Unk_276_raw = reader.ReadSingle();
                data.Unk_277_offset = reader.BaseStream.Position;
                data.Unk_277_raw = reader.ReadSingle();
                data.Unk_278_offset = reader.BaseStream.Position;
                data.Unk_278_raw = reader.ReadSingle();
                data.Unk_279_offset = reader.BaseStream.Position;
                data.Unk_279_raw = reader.ReadSingle();
                data.Unk_280_offset = reader.BaseStream.Position;
                data.Unk_280_raw = reader.ReadSingle();
                data.Unk_281_offset = reader.BaseStream.Position;
                data.Unk_281_raw = reader.ReadSingle();
                data.Special_Scope_Zoom_Ratio_When_Focusing_1_offset = reader.BaseStream.Position;
                data.Special_Scope_Zoom_Ratio_When_Focusing_1_raw = reader.ReadSingle();
                data.Special_Scope_Zoom_Ratio_When_Focusing_2_offset = reader.BaseStream.Position;
                data.Special_Scope_Zoom_Ratio_When_Focusing_2_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Special_Scope_FoV_Multiplier_From_Base_3rd_Person_FoV__raw);
                writer.Write(Unk_275_raw);
                writer.Write(Unk_276_raw);
                writer.Write(Unk_277_raw);
                writer.Write(Unk_278_raw);
                writer.Write(Unk_279_raw);
                writer.Write(Unk_280_raw);
                writer.Write(Unk_281_raw);
                writer.Write(Special_Scope_Zoom_Ratio_When_Focusing_1_raw);
                writer.Write(Special_Scope_Zoom_Ratio_When_Focusing_2_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Special Scope: FoV Multiplier (From Base 3rd Person FoV)", "Special_Scope_FoV_Multiplier_From_Base_3rd_Person_FoV_", "Special_Scope_FoV_Multiplier_From_Base_3rd_Person_FoV__offset"),
                    new MultiStructItemCustomView(this, "Unk 275", "Unk_275", "Unk_275_offset"),
                    new MultiStructItemCustomView(this, "Unk 276", "Unk_276", "Unk_276_offset"),
                    new MultiStructItemCustomView(this, "Unk 277", "Unk_277", "Unk_277_offset"),
                    new MultiStructItemCustomView(this, "Unk 278", "Unk_278", "Unk_278_offset"),
                    new MultiStructItemCustomView(this, "Unk 279", "Unk_279", "Unk_279_offset"),
                    new MultiStructItemCustomView(this, "Unk 280", "Unk_280", "Unk_280_offset"),
                    new MultiStructItemCustomView(this, "Unk 281", "Unk_281", "Unk_281_offset"),
                    new MultiStructItemCustomView(this, "Special Scope: Zoom Ratio When Focusing 1", "Special_Scope_Zoom_Ratio_When_Focusing_1", "Special_Scope_Zoom_Ratio_When_Focusing_1_offset"),
                    new MultiStructItemCustomView(this, "Special Scope: Zoom Ratio When Focusing 2", "Special_Scope_Zoom_Ratio_When_Focusing_2", "Special_Scope_Zoom_Ratio_When_Focusing_2_offset"),
                };
            }
        }

        public partial class Power_Long_Mod_Params : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 25;
            public const string GridName = "Power/Long Mod Params";

            protected float Power_Mod_Unk_1_raw;
            public const string Power_Mod_Unk_1_displayName = "Power Mod: Unk 1";
            public const int Power_Mod_Unk_1_sortIndex = 50;
            [SortOrder(Power_Mod_Unk_1_sortIndex)]
            [DisplayName(Power_Mod_Unk_1_displayName)]
            public virtual float Power_Mod_Unk_1 {
                get => Power_Mod_Unk_1_raw;
                set {
                    if (Power_Mod_Unk_1_raw == value) return;
                    Power_Mod_Unk_1_raw = value;
                    ChangedItems.Add(nameof(Power_Mod_Unk_1));
                    OnPropertyChanged(nameof(Power_Mod_Unk_1));
                }
            }

            protected float Power_Mod_Unk_2_raw;
            public const string Power_Mod_Unk_2_displayName = "Power Mod: Unk 2";
            public const int Power_Mod_Unk_2_sortIndex = 100;
            [SortOrder(Power_Mod_Unk_2_sortIndex)]
            [DisplayName(Power_Mod_Unk_2_displayName)]
            public virtual float Power_Mod_Unk_2 {
                get => Power_Mod_Unk_2_raw;
                set {
                    if (Power_Mod_Unk_2_raw == value) return;
                    Power_Mod_Unk_2_raw = value;
                    ChangedItems.Add(nameof(Power_Mod_Unk_2));
                    OnPropertyChanged(nameof(Power_Mod_Unk_2));
                }
            }

            protected float Power_Mod_Unk_3_raw;
            public const string Power_Mod_Unk_3_displayName = "Power Mod: Unk 3";
            public const int Power_Mod_Unk_3_sortIndex = 150;
            [SortOrder(Power_Mod_Unk_3_sortIndex)]
            [DisplayName(Power_Mod_Unk_3_displayName)]
            public virtual float Power_Mod_Unk_3 {
                get => Power_Mod_Unk_3_raw;
                set {
                    if (Power_Mod_Unk_3_raw == value) return;
                    Power_Mod_Unk_3_raw = value;
                    ChangedItems.Add(nameof(Power_Mod_Unk_3));
                    OnPropertyChanged(nameof(Power_Mod_Unk_3));
                }
            }

            protected float Power_Mod_Unk_4_raw;
            public const string Power_Mod_Unk_4_displayName = "Power Mod: Unk 4";
            public const int Power_Mod_Unk_4_sortIndex = 200;
            [SortOrder(Power_Mod_Unk_4_sortIndex)]
            [DisplayName(Power_Mod_Unk_4_displayName)]
            public virtual float Power_Mod_Unk_4 {
                get => Power_Mod_Unk_4_raw;
                set {
                    if (Power_Mod_Unk_4_raw == value) return;
                    Power_Mod_Unk_4_raw = value;
                    ChangedItems.Add(nameof(Power_Mod_Unk_4));
                    OnPropertyChanged(nameof(Power_Mod_Unk_4));
                }
            }

            protected float Long_Mod_Unk_1_raw;
            public const string Long_Mod_Unk_1_displayName = "Long Mod: Unk 1";
            public const int Long_Mod_Unk_1_sortIndex = 250;
            [SortOrder(Long_Mod_Unk_1_sortIndex)]
            [DisplayName(Long_Mod_Unk_1_displayName)]
            public virtual float Long_Mod_Unk_1 {
                get => Long_Mod_Unk_1_raw;
                set {
                    if (Long_Mod_Unk_1_raw == value) return;
                    Long_Mod_Unk_1_raw = value;
                    ChangedItems.Add(nameof(Long_Mod_Unk_1));
                    OnPropertyChanged(nameof(Long_Mod_Unk_1));
                }
            }

            protected float Long_Mod_Unk_2_raw;
            public const string Long_Mod_Unk_2_displayName = "Long Mod: Unk 2";
            public const int Long_Mod_Unk_2_sortIndex = 300;
            [SortOrder(Long_Mod_Unk_2_sortIndex)]
            [DisplayName(Long_Mod_Unk_2_displayName)]
            public virtual float Long_Mod_Unk_2 {
                get => Long_Mod_Unk_2_raw;
                set {
                    if (Long_Mod_Unk_2_raw == value) return;
                    Long_Mod_Unk_2_raw = value;
                    ChangedItems.Add(nameof(Long_Mod_Unk_2));
                    OnPropertyChanged(nameof(Long_Mod_Unk_2));
                }
            }

            protected float Long_Mod_Unk_3_raw;
            public const string Long_Mod_Unk_3_displayName = "Long Mod: Unk 3";
            public const int Long_Mod_Unk_3_sortIndex = 350;
            [SortOrder(Long_Mod_Unk_3_sortIndex)]
            [DisplayName(Long_Mod_Unk_3_displayName)]
            public virtual float Long_Mod_Unk_3 {
                get => Long_Mod_Unk_3_raw;
                set {
                    if (Long_Mod_Unk_3_raw == value) return;
                    Long_Mod_Unk_3_raw = value;
                    ChangedItems.Add(nameof(Long_Mod_Unk_3));
                    OnPropertyChanged(nameof(Long_Mod_Unk_3));
                }
            }

            protected float Long_Mod_Unk_4_raw;
            public const string Long_Mod_Unk_4_displayName = "Long Mod: Unk 4";
            public const int Long_Mod_Unk_4_sortIndex = 400;
            [SortOrder(Long_Mod_Unk_4_sortIndex)]
            [DisplayName(Long_Mod_Unk_4_displayName)]
            public virtual float Long_Mod_Unk_4 {
                get => Long_Mod_Unk_4_raw;
                set {
                    if (Long_Mod_Unk_4_raw == value) return;
                    Long_Mod_Unk_4_raw = value;
                    ChangedItems.Add(nameof(Long_Mod_Unk_4));
                    OnPropertyChanged(nameof(Long_Mod_Unk_4));
                }
            }

            public const int lastSortIndex = 450;

            public static ObservableMhwStructCollection<Power_Long_Mod_Params> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Power_Long_Mod_Params>();
                const ulong count = 25UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Power_Long_Mod_Params LoadData(BinaryReader reader, ulong i) {
                var data = new Power_Long_Mod_Params();
                data.Index = i;
                data.Power_Mod_Unk_1_raw = reader.ReadSingle();
                data.Power_Mod_Unk_2_raw = reader.ReadSingle();
                data.Power_Mod_Unk_3_raw = reader.ReadSingle();
                data.Power_Mod_Unk_4_raw = reader.ReadSingle();
                data.Long_Mod_Unk_1_raw = reader.ReadSingle();
                data.Long_Mod_Unk_2_raw = reader.ReadSingle();
                data.Long_Mod_Unk_3_raw = reader.ReadSingle();
                data.Long_Mod_Unk_4_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Power_Mod_Unk_1_raw);
                writer.Write(Power_Mod_Unk_2_raw);
                writer.Write(Power_Mod_Unk_3_raw);
                writer.Write(Power_Mod_Unk_4_raw);
                writer.Write(Long_Mod_Unk_1_raw);
                writer.Write(Long_Mod_Unk_2_raw);
                writer.Write(Long_Mod_Unk_3_raw);
                writer.Write(Long_Mod_Unk_4_raw);
            }
        }

        public partial class W13p_Params_7_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W13p Params (7)";

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
                    ChangedItems.Add(nameof(Unk_284));
                    OnPropertyChanged(nameof(Unk_284));
                }
            }

            [DisplayName("Offset")]
            public long Unk_284_offset { get; private set; }

            protected ushort Wyvernblast_S_Charge_Consumption_raw;
            public const string Wyvernblast_S_Charge_Consumption_displayName = "Wyvernblast (S) Charge Consumption";
            public const int Wyvernblast_S_Charge_Consumption_sortIndex = 100;
            [SortOrder(Wyvernblast_S_Charge_Consumption_sortIndex)]
            [DisplayName(Wyvernblast_S_Charge_Consumption_displayName)]
            public virtual ushort Wyvernblast_S_Charge_Consumption {
                get => Wyvernblast_S_Charge_Consumption_raw;
                set {
                    if (Wyvernblast_S_Charge_Consumption_raw == value) return;
                    Wyvernblast_S_Charge_Consumption_raw = value;
                    ChangedItems.Add(nameof(Wyvernblast_S_Charge_Consumption));
                    OnPropertyChanged(nameof(Wyvernblast_S_Charge_Consumption));
                }
            }

            [DisplayName("Offset")]
            public long Wyvernblast_S_Charge_Consumption_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_286));
                    OnPropertyChanged(nameof(Unk_286));
                }
            }

            [DisplayName("Offset")]
            public long Unk_286_offset { get; private set; }

            protected ushort Wyvernblast_M_Charge_Consumption_raw;
            public const string Wyvernblast_M_Charge_Consumption_displayName = "Wyvernblast (M) Charge Consumption";
            public const int Wyvernblast_M_Charge_Consumption_sortIndex = 200;
            [SortOrder(Wyvernblast_M_Charge_Consumption_sortIndex)]
            [DisplayName(Wyvernblast_M_Charge_Consumption_displayName)]
            public virtual ushort Wyvernblast_M_Charge_Consumption {
                get => Wyvernblast_M_Charge_Consumption_raw;
                set {
                    if (Wyvernblast_M_Charge_Consumption_raw == value) return;
                    Wyvernblast_M_Charge_Consumption_raw = value;
                    ChangedItems.Add(nameof(Wyvernblast_M_Charge_Consumption));
                    OnPropertyChanged(nameof(Wyvernblast_M_Charge_Consumption));
                }
            }

            [DisplayName("Offset")]
            public long Wyvernblast_M_Charge_Consumption_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_288));
                    OnPropertyChanged(nameof(Unk_288));
                }
            }

            [DisplayName("Offset")]
            public long Unk_288_offset { get; private set; }

            protected ushort Wyvernblast_L_Charge_Consumption_raw;
            public const string Wyvernblast_L_Charge_Consumption_displayName = "Wyvernblast (L) Charge Consumption";
            public const int Wyvernblast_L_Charge_Consumption_sortIndex = 300;
            [SortOrder(Wyvernblast_L_Charge_Consumption_sortIndex)]
            [DisplayName(Wyvernblast_L_Charge_Consumption_displayName)]
            public virtual ushort Wyvernblast_L_Charge_Consumption {
                get => Wyvernblast_L_Charge_Consumption_raw;
                set {
                    if (Wyvernblast_L_Charge_Consumption_raw == value) return;
                    Wyvernblast_L_Charge_Consumption_raw = value;
                    ChangedItems.Add(nameof(Wyvernblast_L_Charge_Consumption));
                    OnPropertyChanged(nameof(Wyvernblast_L_Charge_Consumption));
                }
            }

            [DisplayName("Offset")]
            public long Wyvernblast_L_Charge_Consumption_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_290));
                    OnPropertyChanged(nameof(Unk_290));
                }
            }

            [DisplayName("Offset")]
            public long Unk_290_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_291));
                    OnPropertyChanged(nameof(Unk_291));
                }
            }

            [DisplayName("Offset")]
            public long Unk_291_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_292));
                    OnPropertyChanged(nameof(Unk_292));
                }
            }

            [DisplayName("Offset")]
            public long Unk_292_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_293));
                    OnPropertyChanged(nameof(Unk_293));
                }
            }

            [DisplayName("Offset")]
            public long Unk_293_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_294));
                    OnPropertyChanged(nameof(Unk_294));
                }
            }

            [DisplayName("Offset")]
            public long Unk_294_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_295));
                    OnPropertyChanged(nameof(Unk_295));
                }
            }

            [DisplayName("Offset")]
            public long Unk_295_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_296));
                    OnPropertyChanged(nameof(Unk_296));
                }
            }

            [DisplayName("Offset")]
            public long Unk_296_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_297));
                    OnPropertyChanged(nameof(Unk_297));
                }
            }

            [DisplayName("Offset")]
            public long Unk_297_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_298));
                    OnPropertyChanged(nameof(Unk_298));
                }
            }

            [DisplayName("Offset")]
            public long Unk_298_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_299));
                    OnPropertyChanged(nameof(Unk_299));
                }
            }

            [DisplayName("Offset")]
            public long Unk_299_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_300));
                    OnPropertyChanged(nameof(Unk_300));
                }
            }

            [DisplayName("Offset")]
            public long Unk_300_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_301));
                    OnPropertyChanged(nameof(Unk_301));
                }
            }

            [DisplayName("Offset")]
            public long Unk_301_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_302));
                    OnPropertyChanged(nameof(Unk_302));
                }
            }

            [DisplayName("Offset")]
            public long Unk_302_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_303));
                    OnPropertyChanged(nameof(Unk_303));
                }
            }

            [DisplayName("Offset")]
            public long Unk_303_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_304));
                    OnPropertyChanged(nameof(Unk_304));
                }
            }

            [DisplayName("Offset")]
            public long Unk_304_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_305));
                    OnPropertyChanged(nameof(Unk_305));
                }
            }

            [DisplayName("Offset")]
            public long Unk_305_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_306));
                    OnPropertyChanged(nameof(Unk_306));
                }
            }

            [DisplayName("Offset")]
            public long Unk_306_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_307));
                    OnPropertyChanged(nameof(Unk_307));
                }
            }

            [DisplayName("Offset")]
            public long Unk_307_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_308));
                    OnPropertyChanged(nameof(Unk_308));
                }
            }

            [DisplayName("Offset")]
            public long Unk_308_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_309));
                    OnPropertyChanged(nameof(Unk_309));
                }
            }

            [DisplayName("Offset")]
            public long Unk_309_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_310));
                    OnPropertyChanged(nameof(Unk_310));
                }
            }

            [DisplayName("Offset")]
            public long Unk_310_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_311));
                    OnPropertyChanged(nameof(Unk_311));
                }
            }

            [DisplayName("Offset")]
            public long Unk_311_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_312));
                    OnPropertyChanged(nameof(Unk_312));
                }
            }

            [DisplayName("Offset")]
            public long Unk_312_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_313));
                    OnPropertyChanged(nameof(Unk_313));
                }
            }

            [DisplayName("Offset")]
            public long Unk_313_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_314));
                    OnPropertyChanged(nameof(Unk_314));
                }
            }

            [DisplayName("Offset")]
            public long Unk_314_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_315));
                    OnPropertyChanged(nameof(Unk_315));
                }
            }

            [DisplayName("Offset")]
            public long Unk_315_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_316));
                    OnPropertyChanged(nameof(Unk_316));
                }
            }

            [DisplayName("Offset")]
            public long Unk_316_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_317));
                    OnPropertyChanged(nameof(Unk_317));
                }
            }

            [DisplayName("Offset")]
            public long Unk_317_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_318));
                    OnPropertyChanged(nameof(Unk_318));
                }
            }

            [DisplayName("Offset")]
            public long Unk_318_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_319));
                    OnPropertyChanged(nameof(Unk_319));
                }
            }

            [DisplayName("Offset")]
            public long Unk_319_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_320));
                    OnPropertyChanged(nameof(Unk_320));
                }
            }

            [DisplayName("Offset")]
            public long Unk_320_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_321));
                    OnPropertyChanged(nameof(Unk_321));
                }
            }

            [DisplayName("Offset")]
            public long Unk_321_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_322));
                    OnPropertyChanged(nameof(Unk_322));
                }
            }

            [DisplayName("Offset")]
            public long Unk_322_offset { get; private set; }

            protected float Wyvernblast_Cooldown_raw;
            public const string Wyvernblast_Cooldown_displayName = "Wyvernblast Cooldown";
            public const int Wyvernblast_Cooldown_sortIndex = 2000;
            [SortOrder(Wyvernblast_Cooldown_sortIndex)]
            [DisplayName(Wyvernblast_Cooldown_displayName)]
            public virtual float Wyvernblast_Cooldown {
                get => Wyvernblast_Cooldown_raw;
                set {
                    if (Wyvernblast_Cooldown_raw == value) return;
                    Wyvernblast_Cooldown_raw = value;
                    ChangedItems.Add(nameof(Wyvernblast_Cooldown));
                    OnPropertyChanged(nameof(Wyvernblast_Cooldown));
                }
            }

            [DisplayName("Offset")]
            public long Wyvernblast_Cooldown_offset { get; private set; }

            protected byte Wyvernblast_Capacity_raw;
            public const string Wyvernblast_Capacity_displayName = "Wyvernblast Capacity";
            public const int Wyvernblast_Capacity_sortIndex = 2050;
            [SortOrder(Wyvernblast_Capacity_sortIndex)]
            [DisplayName(Wyvernblast_Capacity_displayName)]
            public virtual byte Wyvernblast_Capacity {
                get => Wyvernblast_Capacity_raw;
                set {
                    if (Wyvernblast_Capacity_raw == value) return;
                    Wyvernblast_Capacity_raw = value;
                    ChangedItems.Add(nameof(Wyvernblast_Capacity));
                    OnPropertyChanged(nameof(Wyvernblast_Capacity));
                }
            }

            [DisplayName("Offset")]
            public long Wyvernblast_Capacity_offset { get; private set; }

            protected byte Wyvernblast_Initial_Charges_raw;
            public const string Wyvernblast_Initial_Charges_displayName = "Wyvernblast Initial Charges";
            public const int Wyvernblast_Initial_Charges_sortIndex = 2100;
            [SortOrder(Wyvernblast_Initial_Charges_sortIndex)]
            [DisplayName(Wyvernblast_Initial_Charges_displayName)]
            public virtual byte Wyvernblast_Initial_Charges {
                get => Wyvernblast_Initial_Charges_raw;
                set {
                    if (Wyvernblast_Initial_Charges_raw == value) return;
                    Wyvernblast_Initial_Charges_raw = value;
                    ChangedItems.Add(nameof(Wyvernblast_Initial_Charges));
                    OnPropertyChanged(nameof(Wyvernblast_Initial_Charges));
                }
            }

            [DisplayName("Offset")]
            public long Wyvernblast_Initial_Charges_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_326));
                    OnPropertyChanged(nameof(Unk_326));
                }
            }

            [DisplayName("Offset")]
            public long Unk_326_offset { get; private set; }

            protected byte Wyvernblast_Lifespan_raw;
            public const string Wyvernblast_Lifespan_displayName = "Wyvernblast Lifespan";
            public const int Wyvernblast_Lifespan_sortIndex = 2200;
            [SortOrder(Wyvernblast_Lifespan_sortIndex)]
            [DisplayName(Wyvernblast_Lifespan_displayName)]
            public virtual byte Wyvernblast_Lifespan {
                get => Wyvernblast_Lifespan_raw;
                set {
                    if (Wyvernblast_Lifespan_raw == value) return;
                    Wyvernblast_Lifespan_raw = value;
                    ChangedItems.Add(nameof(Wyvernblast_Lifespan));
                    OnPropertyChanged(nameof(Wyvernblast_Lifespan));
                }
            }

            [DisplayName("Offset")]
            public long Wyvernblast_Lifespan_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_328));
                    OnPropertyChanged(nameof(Unk_328));
                }
            }

            [DisplayName("Offset")]
            public long Unk_328_offset { get; private set; }

            protected ushort Wyvernblast_Counter_Explosion_Lifespan__raw;
            public const string Wyvernblast_Counter_Explosion_Lifespan__displayName = "Wyvernblast Counter Explosion Lifespan?";
            public const int Wyvernblast_Counter_Explosion_Lifespan__sortIndex = 2300;
            [SortOrder(Wyvernblast_Counter_Explosion_Lifespan__sortIndex)]
            [DisplayName(Wyvernblast_Counter_Explosion_Lifespan__displayName)]
            public virtual ushort Wyvernblast_Counter_Explosion_Lifespan_ {
                get => Wyvernblast_Counter_Explosion_Lifespan__raw;
                set {
                    if (Wyvernblast_Counter_Explosion_Lifespan__raw == value) return;
                    Wyvernblast_Counter_Explosion_Lifespan__raw = value;
                    ChangedItems.Add(nameof(Wyvernblast_Counter_Explosion_Lifespan_));
                    OnPropertyChanged(nameof(Wyvernblast_Counter_Explosion_Lifespan_));
                }
            }

            [DisplayName("Offset")]
            public long Wyvernblast_Counter_Explosion_Lifespan__offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_330));
                    OnPropertyChanged(nameof(Unk_330));
                }
            }

            [DisplayName("Offset")]
            public long Unk_330_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_331));
                    OnPropertyChanged(nameof(Unk_331));
                }
            }

            [DisplayName("Offset")]
            public long Unk_331_offset { get; private set; }

            public const int lastSortIndex = 2450;

            public static ObservableMhwStructCollection<W13p_Params_7_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<W13p_Params_7_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W13p_Params_7_ LoadData(BinaryReader reader, ulong i) {
                var data = new W13p_Params_7_();
                data.Index = i;
                data.Unk_284_offset = reader.BaseStream.Position;
                data.Unk_284_raw = reader.ReadUInt16();
                data.Wyvernblast_S_Charge_Consumption_offset = reader.BaseStream.Position;
                data.Wyvernblast_S_Charge_Consumption_raw = reader.ReadUInt16();
                data.Unk_286_offset = reader.BaseStream.Position;
                data.Unk_286_raw = reader.ReadUInt16();
                data.Wyvernblast_M_Charge_Consumption_offset = reader.BaseStream.Position;
                data.Wyvernblast_M_Charge_Consumption_raw = reader.ReadUInt16();
                data.Unk_288_offset = reader.BaseStream.Position;
                data.Unk_288_raw = reader.ReadUInt16();
                data.Wyvernblast_L_Charge_Consumption_offset = reader.BaseStream.Position;
                data.Wyvernblast_L_Charge_Consumption_raw = reader.ReadUInt16();
                data.Unk_290_offset = reader.BaseStream.Position;
                data.Unk_290_raw = reader.ReadInt16();
                data.Unk_291_offset = reader.BaseStream.Position;
                data.Unk_291_raw = reader.ReadInt16();
                data.Unk_292_offset = reader.BaseStream.Position;
                data.Unk_292_raw = reader.ReadUInt16();
                data.Unk_293_offset = reader.BaseStream.Position;
                data.Unk_293_raw = reader.ReadUInt16();
                data.Unk_294_offset = reader.BaseStream.Position;
                data.Unk_294_raw = reader.ReadUInt16();
                data.Unk_295_offset = reader.BaseStream.Position;
                data.Unk_295_raw = reader.ReadUInt16();
                data.Unk_296_offset = reader.BaseStream.Position;
                data.Unk_296_raw = reader.ReadUInt16();
                data.Unk_297_offset = reader.BaseStream.Position;
                data.Unk_297_raw = reader.ReadUInt16();
                data.Unk_298_offset = reader.BaseStream.Position;
                data.Unk_298_raw = reader.ReadInt16();
                data.Unk_299_offset = reader.BaseStream.Position;
                data.Unk_299_raw = reader.ReadInt16();
                data.Unk_300_offset = reader.BaseStream.Position;
                data.Unk_300_raw = reader.ReadUInt16();
                data.Unk_301_offset = reader.BaseStream.Position;
                data.Unk_301_raw = reader.ReadUInt16();
                data.Unk_302_offset = reader.BaseStream.Position;
                data.Unk_302_raw = reader.ReadUInt16();
                data.Unk_303_offset = reader.BaseStream.Position;
                data.Unk_303_raw = reader.ReadUInt16();
                data.Unk_304_offset = reader.BaseStream.Position;
                data.Unk_304_raw = reader.ReadInt16();
                data.Unk_305_offset = reader.BaseStream.Position;
                data.Unk_305_raw = reader.ReadInt16();
                data.Unk_306_offset = reader.BaseStream.Position;
                data.Unk_306_raw = reader.ReadInt16();
                data.Unk_307_offset = reader.BaseStream.Position;
                data.Unk_307_raw = reader.ReadInt16();
                data.Unk_308_offset = reader.BaseStream.Position;
                data.Unk_308_raw = reader.ReadUInt16();
                data.Unk_309_offset = reader.BaseStream.Position;
                data.Unk_309_raw = reader.ReadUInt16();
                data.Unk_310_offset = reader.BaseStream.Position;
                data.Unk_310_raw = reader.ReadUInt16();
                data.Unk_311_offset = reader.BaseStream.Position;
                data.Unk_311_raw = reader.ReadUInt16();
                data.Unk_312_offset = reader.BaseStream.Position;
                data.Unk_312_raw = reader.ReadUInt16();
                data.Unk_313_offset = reader.BaseStream.Position;
                data.Unk_313_raw = reader.ReadUInt16();
                data.Unk_314_offset = reader.BaseStream.Position;
                data.Unk_314_raw = reader.ReadUInt16();
                data.Unk_315_offset = reader.BaseStream.Position;
                data.Unk_315_raw = reader.ReadUInt16();
                data.Unk_316_offset = reader.BaseStream.Position;
                data.Unk_316_raw = reader.ReadSingle();
                data.Unk_317_offset = reader.BaseStream.Position;
                data.Unk_317_raw = reader.ReadSingle();
                data.Unk_318_offset = reader.BaseStream.Position;
                data.Unk_318_raw = reader.ReadSingle();
                data.Unk_319_offset = reader.BaseStream.Position;
                data.Unk_319_raw = reader.ReadSingle();
                data.Unk_320_offset = reader.BaseStream.Position;
                data.Unk_320_raw = reader.ReadSingle();
                data.Unk_321_offset = reader.BaseStream.Position;
                data.Unk_321_raw = reader.ReadSingle();
                data.Unk_322_offset = reader.BaseStream.Position;
                data.Unk_322_raw = reader.ReadSingle();
                data.Wyvernblast_Cooldown_offset = reader.BaseStream.Position;
                data.Wyvernblast_Cooldown_raw = reader.ReadSingle();
                data.Wyvernblast_Capacity_offset = reader.BaseStream.Position;
                data.Wyvernblast_Capacity_raw = reader.ReadByte();
                data.Wyvernblast_Initial_Charges_offset = reader.BaseStream.Position;
                data.Wyvernblast_Initial_Charges_raw = reader.ReadByte();
                data.Unk_326_offset = reader.BaseStream.Position;
                data.Unk_326_raw = reader.ReadByte();
                data.Wyvernblast_Lifespan_offset = reader.BaseStream.Position;
                data.Wyvernblast_Lifespan_raw = reader.ReadByte();
                data.Unk_328_offset = reader.BaseStream.Position;
                data.Unk_328_raw = reader.ReadByte();
                data.Wyvernblast_Counter_Explosion_Lifespan__offset = reader.BaseStream.Position;
                data.Wyvernblast_Counter_Explosion_Lifespan__raw = reader.ReadUInt16();
                data.Unk_330_offset = reader.BaseStream.Position;
                data.Unk_330_raw = reader.ReadSingle();
                data.Unk_331_offset = reader.BaseStream.Position;
                data.Unk_331_raw = reader.ReadByte();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_284_raw);
                writer.Write(Wyvernblast_S_Charge_Consumption_raw);
                writer.Write(Unk_286_raw);
                writer.Write(Wyvernblast_M_Charge_Consumption_raw);
                writer.Write(Unk_288_raw);
                writer.Write(Wyvernblast_L_Charge_Consumption_raw);
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
                writer.Write(Wyvernblast_Cooldown_raw);
                writer.Write(Wyvernblast_Capacity_raw);
                writer.Write(Wyvernblast_Initial_Charges_raw);
                writer.Write(Unk_326_raw);
                writer.Write(Wyvernblast_Lifespan_raw);
                writer.Write(Unk_328_raw);
                writer.Write(Wyvernblast_Counter_Explosion_Lifespan__raw);
                writer.Write(Unk_330_raw);
                writer.Write(Unk_331_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Unk 284", "Unk_284", "Unk_284_offset"),
                    new MultiStructItemCustomView(this, "Wyvernblast (S) Charge Consumption", "Wyvernblast_S_Charge_Consumption", "Wyvernblast_S_Charge_Consumption_offset"),
                    new MultiStructItemCustomView(this, "Unk 286", "Unk_286", "Unk_286_offset"),
                    new MultiStructItemCustomView(this, "Wyvernblast (M) Charge Consumption", "Wyvernblast_M_Charge_Consumption", "Wyvernblast_M_Charge_Consumption_offset"),
                    new MultiStructItemCustomView(this, "Unk 288", "Unk_288", "Unk_288_offset"),
                    new MultiStructItemCustomView(this, "Wyvernblast (L) Charge Consumption", "Wyvernblast_L_Charge_Consumption", "Wyvernblast_L_Charge_Consumption_offset"),
                    new MultiStructItemCustomView(this, "Unk 290", "Unk_290", "Unk_290_offset"),
                    new MultiStructItemCustomView(this, "Unk 291", "Unk_291", "Unk_291_offset"),
                    new MultiStructItemCustomView(this, "Unk 292", "Unk_292", "Unk_292_offset"),
                    new MultiStructItemCustomView(this, "Unk 293", "Unk_293", "Unk_293_offset"),
                    new MultiStructItemCustomView(this, "Unk 294", "Unk_294", "Unk_294_offset"),
                    new MultiStructItemCustomView(this, "Unk 295", "Unk_295", "Unk_295_offset"),
                    new MultiStructItemCustomView(this, "Unk 296", "Unk_296", "Unk_296_offset"),
                    new MultiStructItemCustomView(this, "Unk 297", "Unk_297", "Unk_297_offset"),
                    new MultiStructItemCustomView(this, "Unk 298", "Unk_298", "Unk_298_offset"),
                    new MultiStructItemCustomView(this, "Unk 299", "Unk_299", "Unk_299_offset"),
                    new MultiStructItemCustomView(this, "Unk 300", "Unk_300", "Unk_300_offset"),
                    new MultiStructItemCustomView(this, "Unk 301", "Unk_301", "Unk_301_offset"),
                    new MultiStructItemCustomView(this, "Unk 302", "Unk_302", "Unk_302_offset"),
                    new MultiStructItemCustomView(this, "Unk 303", "Unk_303", "Unk_303_offset"),
                    new MultiStructItemCustomView(this, "Unk 304", "Unk_304", "Unk_304_offset"),
                    new MultiStructItemCustomView(this, "Unk 305", "Unk_305", "Unk_305_offset"),
                    new MultiStructItemCustomView(this, "Unk 306", "Unk_306", "Unk_306_offset"),
                    new MultiStructItemCustomView(this, "Unk 307", "Unk_307", "Unk_307_offset"),
                    new MultiStructItemCustomView(this, "Unk 308", "Unk_308", "Unk_308_offset"),
                    new MultiStructItemCustomView(this, "Unk 309", "Unk_309", "Unk_309_offset"),
                    new MultiStructItemCustomView(this, "Unk 310", "Unk_310", "Unk_310_offset"),
                    new MultiStructItemCustomView(this, "Unk 311", "Unk_311", "Unk_311_offset"),
                    new MultiStructItemCustomView(this, "Unk 312", "Unk_312", "Unk_312_offset"),
                    new MultiStructItemCustomView(this, "Unk 313", "Unk_313", "Unk_313_offset"),
                    new MultiStructItemCustomView(this, "Unk 314", "Unk_314", "Unk_314_offset"),
                    new MultiStructItemCustomView(this, "Unk 315", "Unk_315", "Unk_315_offset"),
                    new MultiStructItemCustomView(this, "Unk 316", "Unk_316", "Unk_316_offset"),
                    new MultiStructItemCustomView(this, "Unk 317", "Unk_317", "Unk_317_offset"),
                    new MultiStructItemCustomView(this, "Unk 318", "Unk_318", "Unk_318_offset"),
                    new MultiStructItemCustomView(this, "Unk 319", "Unk_319", "Unk_319_offset"),
                    new MultiStructItemCustomView(this, "Unk 320", "Unk_320", "Unk_320_offset"),
                    new MultiStructItemCustomView(this, "Unk 321", "Unk_321", "Unk_321_offset"),
                    new MultiStructItemCustomView(this, "Unk 322", "Unk_322", "Unk_322_offset"),
                    new MultiStructItemCustomView(this, "Wyvernblast Cooldown", "Wyvernblast_Cooldown", "Wyvernblast_Cooldown_offset"),
                    new MultiStructItemCustomView(this, "Wyvernblast Capacity", "Wyvernblast_Capacity", "Wyvernblast_Capacity_offset"),
                    new MultiStructItemCustomView(this, "Wyvernblast Initial Charges", "Wyvernblast_Initial_Charges", "Wyvernblast_Initial_Charges_offset"),
                    new MultiStructItemCustomView(this, "Unk 326", "Unk_326", "Unk_326_offset"),
                    new MultiStructItemCustomView(this, "Wyvernblast Lifespan", "Wyvernblast_Lifespan", "Wyvernblast_Lifespan_offset"),
                    new MultiStructItemCustomView(this, "Unk 328", "Unk_328", "Unk_328_offset"),
                    new MultiStructItemCustomView(this, "Wyvernblast Counter Explosion Lifespan?", "Wyvernblast_Counter_Explosion_Lifespan_", "Wyvernblast_Counter_Explosion_Lifespan__offset"),
                    new MultiStructItemCustomView(this, "Unk 330", "Unk_330", "Unk_330_offset"),
                    new MultiStructItemCustomView(this, "Unk 331", "Unk_331", "Unk_331_offset"),
                };
            }
        }

        public partial class Action_Param_1 : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 1;
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
                    ChangedItems.Add(nameof(Gravity));
                    OnPropertyChanged(nameof(Gravity));
                }
            }

            protected float Time_Rate_raw;
            public const string Time_Rate_displayName = "Time Rate";
            public const int Time_Rate_sortIndex = 100;
            [SortOrder(Time_Rate_sortIndex)]
            [DisplayName(Time_Rate_displayName)]
            public virtual float Time_Rate {
                get => Time_Rate_raw;
                set {
                    if (Time_Rate_raw == value) return;
                    Time_Rate_raw = value;
                    ChangedItems.Add(nameof(Time_Rate));
                    OnPropertyChanged(nameof(Time_Rate));
                }
            }

            protected float Initial_X_Velocity_raw;
            public const string Initial_X_Velocity_displayName = "Initial X Velocity";
            public const int Initial_X_Velocity_sortIndex = 150;
            [SortOrder(Initial_X_Velocity_sortIndex)]
            [DisplayName(Initial_X_Velocity_displayName)]
            public virtual float Initial_X_Velocity {
                get => Initial_X_Velocity_raw;
                set {
                    if (Initial_X_Velocity_raw == value) return;
                    Initial_X_Velocity_raw = value;
                    ChangedItems.Add(nameof(Initial_X_Velocity));
                    OnPropertyChanged(nameof(Initial_X_Velocity));
                }
            }

            protected float Initial_Y_Velocity_raw;
            public const string Initial_Y_Velocity_displayName = "Initial Y Velocity";
            public const int Initial_Y_Velocity_sortIndex = 200;
            [SortOrder(Initial_Y_Velocity_sortIndex)]
            [DisplayName(Initial_Y_Velocity_displayName)]
            public virtual float Initial_Y_Velocity {
                get => Initial_Y_Velocity_raw;
                set {
                    if (Initial_Y_Velocity_raw == value) return;
                    Initial_Y_Velocity_raw = value;
                    ChangedItems.Add(nameof(Initial_Y_Velocity));
                    OnPropertyChanged(nameof(Initial_Y_Velocity));
                }
            }

            protected float Initial_Z_Velocity_raw;
            public const string Initial_Z_Velocity_displayName = "Initial Z Velocity";
            public const int Initial_Z_Velocity_sortIndex = 250;
            [SortOrder(Initial_Z_Velocity_sortIndex)]
            [DisplayName(Initial_Z_Velocity_displayName)]
            public virtual float Initial_Z_Velocity {
                get => Initial_Z_Velocity_raw;
                set {
                    if (Initial_Z_Velocity_raw == value) return;
                    Initial_Z_Velocity_raw = value;
                    ChangedItems.Add(nameof(Initial_Z_Velocity));
                    OnPropertyChanged(nameof(Initial_Z_Velocity));
                }
            }

            public const int lastSortIndex = 300;

            public static ObservableMhwStructCollection<Action_Param_1> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Action_Param_1>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Action_Param_1 LoadData(BinaryReader reader, ulong i) {
                var data = new Action_Param_1();
                data.Index = i;
                data.Gravity_raw = reader.ReadSingle();
                data.Time_Rate_raw = reader.ReadSingle();
                data.Initial_X_Velocity_raw = reader.ReadSingle();
                data.Initial_Y_Velocity_raw = reader.ReadSingle();
                data.Initial_Z_Velocity_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Gravity_raw);
                writer.Write(Time_Rate_raw);
                writer.Write(Initial_X_Velocity_raw);
                writer.Write(Initial_Y_Velocity_raw);
                writer.Write(Initial_Z_Velocity_raw);
            }
        }

        public partial class HZD_Ammo_Gauge_Levels : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 9;
            public const string GridName = "HZD Ammo Gauge Levels";

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
                    ChangedItems.Add(nameof(Unk_1));
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
                    ChangedItems.Add(nameof(Unk_2));
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
                    ChangedItems.Add(nameof(Unk_3));
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
                    ChangedItems.Add(nameof(HP_Red));
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
                    ChangedItems.Add(nameof(Unk_4));
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
                    ChangedItems.Add(nameof(Physical_Multiplier));
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
                    ChangedItems.Add(nameof(Element_Multiplier));
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
                    ChangedItems.Add(nameof(Unk_5));
                    OnPropertyChanged(nameof(Unk_5));
                }
            }

            public const int lastSortIndex = 450;

            public static ObservableMhwStructCollection<HZD_Ammo_Gauge_Levels> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<HZD_Ammo_Gauge_Levels>();
                const ulong count = 9UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static HZD_Ammo_Gauge_Levels LoadData(BinaryReader reader, ulong i) {
                var data = new HZD_Ammo_Gauge_Levels();
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
            var W13p_Params_1_Shared__ = new MhwStructDataContainer<W13p_Params_1_Shared_>(W13p_Params_1_Shared_.LoadData(reader), typeof(W13p_Params_1_Shared_));
            data.AddLast(W13p_Params_1_Shared__);
            var Unk_Arr_1_Shared__ = new MhwStructDataContainer<Unk_Arr_1_Shared_>(Unk_Arr_1_Shared_.LoadData(reader), typeof(Unk_Arr_1_Shared_));
            data.AddLast(Unk_Arr_1_Shared__);
            var W13p_Params_2_Shared__ = new MhwStructDataContainer<W13p_Params_2_Shared_>(W13p_Params_2_Shared_.LoadData(reader), typeof(W13p_Params_2_Shared_));
            data.AddLast(W13p_Params_2_Shared__);
            var Guard_Angles_Shared__ = new MhwStructDataContainer<Guard_Angles_Shared_>(Guard_Angles_Shared_.LoadData(reader), typeof(Guard_Angles_Shared_));
            data.AddLast(Guard_Angles_Shared__);
            var W13p_Params_3_Shared__ = new MhwStructDataContainer<W13p_Params_3_Shared_>(W13p_Params_3_Shared_.LoadData(reader), typeof(W13p_Params_3_Shared_));
            data.AddLast(W13p_Params_3_Shared__);
            var Unk_Arr_2_Shared__ = new MhwStructDataContainer<Unk_Arr_2_Shared_>(Unk_Arr_2_Shared_.LoadData(reader), typeof(Unk_Arr_2_Shared_));
            data.AddLast(Unk_Arr_2_Shared__);
            var W13p_Params_4_Shared__ = new MhwStructDataContainer<W13p_Params_4_Shared_>(W13p_Params_4_Shared_.LoadData(reader), typeof(W13p_Params_4_Shared_));
            data.AddLast(W13p_Params_4_Shared__);
            var W13p_Params_5__ = new MhwStructDataContainer<W13p_Params_5_>(W13p_Params_5_.LoadData(reader), typeof(W13p_Params_5_));
            data.AddLast(W13p_Params_5__);
            var Event_Pad_Vib_ = new MhwStructDataContainer<Event_Pad_Vib>(Event_Pad_Vib.LoadData(reader), typeof(Event_Pad_Vib));
            data.AddLast(Event_Pad_Vib_);
            var W13p_Params_5_1__ = new MhwStructDataContainer<W13p_Params_5_1_>(W13p_Params_5_1_.LoadData(reader), typeof(W13p_Params_5_1_));
            data.AddLast(W13p_Params_5_1__);
            var Unk_Arr_3_ = new MhwStructDataContainer<Unk_Arr_3>(Unk_Arr_3.LoadData(reader), typeof(Unk_Arr_3));
            data.AddLast(Unk_Arr_3_);
            var Bowgun_Deviation_Last_One_Maybe_High_Plus_Felyne_Meal__ = new MhwStructDataContainer<Bowgun_Deviation_Last_One_Maybe_High_Plus_Felyne_Meal_>(Bowgun_Deviation_Last_One_Maybe_High_Plus_Felyne_Meal_.LoadData(reader), typeof(Bowgun_Deviation_Last_One_Maybe_High_Plus_Felyne_Meal_));
            data.AddLast(Bowgun_Deviation_Last_One_Maybe_High_Plus_Felyne_Meal__);
            var Ammo_Shifting_ = new MhwStructDataContainer<Ammo_Shifting>(Ammo_Shifting.LoadData(reader), typeof(Ammo_Shifting));
            data.AddLast(Ammo_Shifting_);
            var W13p_Params_6__ = new MhwStructDataContainer<W13p_Params_6_>(W13p_Params_6_.LoadData(reader), typeof(W13p_Params_6_));
            data.AddLast(W13p_Params_6__);
            var Number_of_Shield_Mods_Struct_ = new MhwStructDataContainer<Number_of_Shield_Mods_Struct>(Number_of_Shield_Mods_Struct.LoadData(reader), typeof(Number_of_Shield_Mods_Struct));
            data.AddLast(Number_of_Shield_Mods_Struct_);
            var Shield_Mods_ = new MhwStructDataContainer<Shield_Mods, Number_of_Shield_Mods_Struct>(Shield_Mods.LoadData(reader, Number_of_Shield_Mods_Struct_.list), typeof(Shield_Mods));
            Shield_Mods_.SetCountTargetToUpdate(Number_of_Shield_Mods_Struct_, -1, "Number_of_Shield_Mods");
            data.AddLast(Shield_Mods_);
            var W13p_Params_Special_Scope_Params__ = new MhwStructDataContainer<W13p_Params_Special_Scope_Params_>(W13p_Params_Special_Scope_Params_.LoadData(reader), typeof(W13p_Params_Special_Scope_Params_));
            data.AddLast(W13p_Params_Special_Scope_Params__);
            var Power_Long_Mod_Params_ = new MhwStructDataContainer<Power_Long_Mod_Params>(Power_Long_Mod_Params.LoadData(reader), typeof(Power_Long_Mod_Params));
            data.AddLast(Power_Long_Mod_Params_);
            var W13p_Params_7__ = new MhwStructDataContainer<W13p_Params_7_>(W13p_Params_7_.LoadData(reader), typeof(W13p_Params_7_));
            data.AddLast(W13p_Params_7__);
            var Action_Param_1_ = new MhwStructDataContainer<Action_Param_1>(Action_Param_1.LoadData(reader), typeof(Action_Param_1));
            data.AddLast(Action_Param_1_);
            var HZD_Ammo_Gauge_Levels_ = new MhwStructDataContainer<HZD_Ammo_Gauge_Levels>(HZD_Ammo_Gauge_Levels.LoadData(reader), typeof(HZD_Ammo_Gauge_Levels));
            data.AddLast(HZD_Ammo_Gauge_Levels_);
        }
    }
}
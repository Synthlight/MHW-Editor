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
    public partial class Wp12Param {
        public override string EncryptionKey => "j1P15gEkgVa7NdFxiqwCPitykHctY2nZPjSaElvqb0eSwcLO1cOlTqqv";

        public partial class W12p_Params_1_Shared_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W12p Params (1, Shared)";

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

            public static ObservableMhwStructCollection<W12p_Params_1_Shared_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<W12p_Params_1_Shared_>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W12p_Params_1_Shared_ LoadData(BinaryReader reader, ulong i) {
                var data = new W12p_Params_1_Shared_();
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

        public partial class W12p_Params_2_Shared_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W12p Params (2, Shared)";

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

            public static ObservableMhwStructCollection<W12p_Params_2_Shared_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<W12p_Params_2_Shared_>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W12p_Params_2_Shared_ LoadData(BinaryReader reader, ulong i) {
                var data = new W12p_Params_2_Shared_();
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

        public partial class W12p_Params_3_Shared_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W12p Params (3, Shared)";

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

            public static ObservableMhwStructCollection<W12p_Params_3_Shared_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<W12p_Params_3_Shared_>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W12p_Params_3_Shared_ LoadData(BinaryReader reader, ulong i) {
                var data = new W12p_Params_3_Shared_();
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

        public partial class W12p_Params_4_Shared_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W12p Params (4, Shared)";

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

            public const int lastSortIndex = 750;

            public static ObservableMhwStructCollection<W12p_Params_4_Shared_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<W12p_Params_4_Shared_>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W12p_Params_4_Shared_ LoadData(BinaryReader reader, ulong i) {
                var data = new W12p_Params_4_Shared_();
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
                };
            }
        }

        public partial class W12p_Params_5_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W12p Params (5)";

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
                    ChangedItems.Add(nameof(Unk_170));
                    OnPropertyChanged(nameof(Unk_170));
                }
            }

            [DisplayName("Offset")]
            public long Unk_170_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_172));
                    OnPropertyChanged(nameof(Unk_172));
                }
            }

            [DisplayName("Offset")]
            public long Unk_172_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_173));
                    OnPropertyChanged(nameof(Unk_173));
                }
            }

            [DisplayName("Offset")]
            public long Unk_173_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_174));
                    OnPropertyChanged(nameof(Unk_174));
                }
            }

            [DisplayName("Offset")]
            public long Unk_174_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_176));
                    OnPropertyChanged(nameof(Unk_176));
                }
            }

            [DisplayName("Offset")]
            public long Unk_176_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_188));
                    OnPropertyChanged(nameof(Unk_188));
                }
            }

            [DisplayName("Offset")]
            public long Unk_188_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_190));
                    OnPropertyChanged(nameof(Unk_190));
                }
            }

            [DisplayName("Offset")]
            public long Unk_190_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_212));
                    OnPropertyChanged(nameof(Unk_212));
                }
            }

            [DisplayName("Offset")]
            public long Unk_212_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_213));
                    OnPropertyChanged(nameof(Unk_213));
                }
            }

            [DisplayName("Offset")]
            public long Unk_213_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_214));
                    OnPropertyChanged(nameof(Unk_214));
                }
            }

            [DisplayName("Offset")]
            public long Unk_214_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_215));
                    OnPropertyChanged(nameof(Unk_215));
                }
            }

            [DisplayName("Offset")]
            public long Unk_215_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_216));
                    OnPropertyChanged(nameof(Unk_216));
                }
            }

            [DisplayName("Offset")]
            public long Unk_216_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_217));
                    OnPropertyChanged(nameof(Unk_217));
                }
            }

            [DisplayName("Offset")]
            public long Unk_217_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_218));
                    OnPropertyChanged(nameof(Unk_218));
                }
            }

            [DisplayName("Offset")]
            public long Unk_218_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_219));
                    OnPropertyChanged(nameof(Unk_219));
                }
            }

            [DisplayName("Offset")]
            public long Unk_219_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_220));
                    OnPropertyChanged(nameof(Unk_220));
                }
            }

            [DisplayName("Offset")]
            public long Unk_220_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_221));
                    OnPropertyChanged(nameof(Unk_221));
                }
            }

            [DisplayName("Offset")]
            public long Unk_221_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_222));
                    OnPropertyChanged(nameof(Unk_222));
                }
            }

            [DisplayName("Offset")]
            public long Unk_222_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_223));
                    OnPropertyChanged(nameof(Unk_223));
                }
            }

            [DisplayName("Offset")]
            public long Unk_223_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_224));
                    OnPropertyChanged(nameof(Unk_224));
                }
            }

            [DisplayName("Offset")]
            public long Unk_224_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_225));
                    OnPropertyChanged(nameof(Unk_225));
                }
            }

            [DisplayName("Offset")]
            public long Unk_225_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_226));
                    OnPropertyChanged(nameof(Unk_226));
                }
            }

            [DisplayName("Offset")]
            public long Unk_226_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_227));
                    OnPropertyChanged(nameof(Unk_227));
                }
            }

            [DisplayName("Offset")]
            public long Unk_227_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_228));
                    OnPropertyChanged(nameof(Unk_228));
                }
            }

            [DisplayName("Offset")]
            public long Unk_228_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_229));
                    OnPropertyChanged(nameof(Unk_229));
                }
            }

            [DisplayName("Offset")]
            public long Unk_229_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_230));
                    OnPropertyChanged(nameof(Unk_230));
                }
            }

            [DisplayName("Offset")]
            public long Unk_230_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_231));
                    OnPropertyChanged(nameof(Unk_231));
                }
            }

            [DisplayName("Offset")]
            public long Unk_231_offset { get; private set; }

            protected float Wyrmsnipe_Cooldown_raw;
            public const string Wyrmsnipe_Cooldown_displayName = "Wyrmsnipe Cooldown";
            public const int Wyrmsnipe_Cooldown_sortIndex = 7100;
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
                    ChangedItems.Add(nameof(Unk_233));
                    OnPropertyChanged(nameof(Unk_233));
                }
            }

            [DisplayName("Offset")]
            public long Unk_233_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_234));
                    OnPropertyChanged(nameof(Unk_234));
                }
            }

            [DisplayName("Offset")]
            public long Unk_234_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_235));
                    OnPropertyChanged(nameof(Unk_235));
                }
            }

            [DisplayName("Offset")]
            public long Unk_235_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_236));
                    OnPropertyChanged(nameof(Unk_236));
                }
            }

            [DisplayName("Offset")]
            public long Unk_236_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_237));
                    OnPropertyChanged(nameof(Unk_237));
                }
            }

            [DisplayName("Offset")]
            public long Unk_237_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_238));
                    OnPropertyChanged(nameof(Unk_238));
                }
            }

            [DisplayName("Offset")]
            public long Unk_238_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_239));
                    OnPropertyChanged(nameof(Unk_239));
                }
            }

            [DisplayName("Offset")]
            public long Unk_239_offset { get; private set; }

            public const int lastSortIndex = 7500;

            public static ObservableMhwStructCollection<W12p_Params_5_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<W12p_Params_5_>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W12p_Params_5_ LoadData(BinaryReader reader, ulong i) {
                var data = new W12p_Params_5_();
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
                data.Unk_170_offset = reader.BaseStream.Position;
                data.Unk_170_raw = reader.ReadSingle();
                data.Wyvernheart_Ammo_Recharge_offset = reader.BaseStream.Position;
                data.Wyvernheart_Ammo_Recharge_raw = reader.ReadSingle();
                data.Unk_172_offset = reader.BaseStream.Position;
                data.Unk_172_raw = reader.ReadSingle();
                data.Unk_173_offset = reader.BaseStream.Position;
                data.Unk_173_raw = reader.ReadSingle();
                data.Unk_174_offset = reader.BaseStream.Position;
                data.Unk_174_raw = reader.ReadByte();
                data.Unk_175_offset = reader.BaseStream.Position;
                data.Unk_175_raw = reader.ReadByte();
                data.Unk_176_offset = reader.BaseStream.Position;
                data.Unk_176_raw = reader.ReadByte();
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
                data.Unk_188_offset = reader.BaseStream.Position;
                data.Unk_188_raw = reader.ReadByte();
                data.Unk_189_offset = reader.BaseStream.Position;
                data.Unk_189_raw = reader.ReadByte();
                data.Unk_190_offset = reader.BaseStream.Position;
                data.Unk_190_raw = reader.ReadByte();
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
                data.Unk_212_offset = reader.BaseStream.Position;
                data.Unk_212_raw = reader.ReadByte();
                data.Unk_213_offset = reader.BaseStream.Position;
                data.Unk_213_raw = reader.ReadUInt16();
                data.Unk_214_offset = reader.BaseStream.Position;
                data.Unk_214_raw = reader.ReadUInt16();
                data.Unk_215_offset = reader.BaseStream.Position;
                data.Unk_215_raw = reader.ReadSingle();
                data.Unk_216_offset = reader.BaseStream.Position;
                data.Unk_216_raw = reader.ReadUInt16();
                data.Unk_217_offset = reader.BaseStream.Position;
                data.Unk_217_raw = reader.ReadSingle();
                data.Unk_218_offset = reader.BaseStream.Position;
                data.Unk_218_raw = reader.ReadSingle();
                data.Unk_219_offset = reader.BaseStream.Position;
                data.Unk_219_raw = reader.ReadSingle();
                data.Unk_220_offset = reader.BaseStream.Position;
                data.Unk_220_raw = reader.ReadSingle();
                data.Unk_221_offset = reader.BaseStream.Position;
                data.Unk_221_raw = reader.ReadSingle();
                data.Unk_222_offset = reader.BaseStream.Position;
                data.Unk_222_raw = reader.ReadSingle();
                data.Unk_223_offset = reader.BaseStream.Position;
                data.Unk_223_raw = reader.ReadSingle();
                data.Unk_224_offset = reader.BaseStream.Position;
                data.Unk_224_raw = reader.ReadSingle();
                data.Unk_225_offset = reader.BaseStream.Position;
                data.Unk_225_raw = reader.ReadSingle();
                data.Unk_226_offset = reader.BaseStream.Position;
                data.Unk_226_raw = reader.ReadSingle();
                data.Unk_227_offset = reader.BaseStream.Position;
                data.Unk_227_raw = reader.ReadSingle();
                data.Unk_228_offset = reader.BaseStream.Position;
                data.Unk_228_raw = reader.ReadSingle();
                data.Unk_229_offset = reader.BaseStream.Position;
                data.Unk_229_raw = reader.ReadSingle();
                data.Unk_230_offset = reader.BaseStream.Position;
                data.Unk_230_raw = reader.ReadSingle();
                data.Unk_231_offset = reader.BaseStream.Position;
                data.Unk_231_raw = reader.ReadByte();
                data.Wyrmsnipe_Cooldown_offset = reader.BaseStream.Position;
                data.Wyrmsnipe_Cooldown_raw = reader.ReadSingle();
                data.Unk_233_offset = reader.BaseStream.Position;
                data.Unk_233_raw = reader.ReadByte();
                data.Unk_234_offset = reader.BaseStream.Position;
                data.Unk_234_raw = reader.ReadByte();
                data.Unk_235_offset = reader.BaseStream.Position;
                data.Unk_235_raw = reader.ReadByte();
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
                writer.Write(Unk_170_raw);
                writer.Write(Wyvernheart_Ammo_Recharge_raw);
                writer.Write(Unk_172_raw);
                writer.Write(Unk_173_raw);
                writer.Write(Unk_174_raw);
                writer.Write(Unk_175_raw);
                writer.Write(Unk_176_raw);
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
                writer.Write(Unk_188_raw);
                writer.Write(Unk_189_raw);
                writer.Write(Unk_190_raw);
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
                writer.Write(Wyrmsnipe_Cooldown_raw);
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
                    new MultiStructItemCustomView(this, "Unk 170", "Unk_170", "Unk_170_offset"),
                    new MultiStructItemCustomView(this, "Wyvernheart Ammo Recharge", "Wyvernheart_Ammo_Recharge", "Wyvernheart_Ammo_Recharge_offset"),
                    new MultiStructItemCustomView(this, "Unk 172", "Unk_172", "Unk_172_offset"),
                    new MultiStructItemCustomView(this, "Unk 173", "Unk_173", "Unk_173_offset"),
                    new MultiStructItemCustomView(this, "Unk 174", "Unk_174", "Unk_174_offset"),
                    new MultiStructItemCustomView(this, "Unk 175", "Unk_175", "Unk_175_offset"),
                    new MultiStructItemCustomView(this, "Unk 176", "Unk_176", "Unk_176_offset"),
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
                    new MultiStructItemCustomView(this, "Unk 188", "Unk_188", "Unk_188_offset"),
                    new MultiStructItemCustomView(this, "Unk 189", "Unk_189", "Unk_189_offset"),
                    new MultiStructItemCustomView(this, "Unk 190", "Unk_190", "Unk_190_offset"),
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
                    new MultiStructItemCustomView(this, "Unk 212", "Unk_212", "Unk_212_offset"),
                    new MultiStructItemCustomView(this, "Unk 213", "Unk_213", "Unk_213_offset"),
                    new MultiStructItemCustomView(this, "Unk 214", "Unk_214", "Unk_214_offset"),
                    new MultiStructItemCustomView(this, "Unk 215", "Unk_215", "Unk_215_offset"),
                    new MultiStructItemCustomView(this, "Unk 216", "Unk_216", "Unk_216_offset"),
                    new MultiStructItemCustomView(this, "Unk 217", "Unk_217", "Unk_217_offset"),
                    new MultiStructItemCustomView(this, "Unk 218", "Unk_218", "Unk_218_offset"),
                    new MultiStructItemCustomView(this, "Unk 219", "Unk_219", "Unk_219_offset"),
                    new MultiStructItemCustomView(this, "Unk 220", "Unk_220", "Unk_220_offset"),
                    new MultiStructItemCustomView(this, "Unk 221", "Unk_221", "Unk_221_offset"),
                    new MultiStructItemCustomView(this, "Unk 222", "Unk_222", "Unk_222_offset"),
                    new MultiStructItemCustomView(this, "Unk 223", "Unk_223", "Unk_223_offset"),
                    new MultiStructItemCustomView(this, "Unk 224", "Unk_224", "Unk_224_offset"),
                    new MultiStructItemCustomView(this, "Unk 225", "Unk_225", "Unk_225_offset"),
                    new MultiStructItemCustomView(this, "Unk 226", "Unk_226", "Unk_226_offset"),
                    new MultiStructItemCustomView(this, "Unk 227", "Unk_227", "Unk_227_offset"),
                    new MultiStructItemCustomView(this, "Unk 228", "Unk_228", "Unk_228_offset"),
                    new MultiStructItemCustomView(this, "Unk 229", "Unk_229", "Unk_229_offset"),
                    new MultiStructItemCustomView(this, "Unk 230", "Unk_230", "Unk_230_offset"),
                    new MultiStructItemCustomView(this, "Unk 231", "Unk_231", "Unk_231_offset"),
                    new MultiStructItemCustomView(this, "Wyrmsnipe Cooldown", "Wyrmsnipe_Cooldown", "Wyrmsnipe_Cooldown_offset"),
                    new MultiStructItemCustomView(this, "Unk 233", "Unk_233", "Unk_233_offset"),
                    new MultiStructItemCustomView(this, "Unk 234", "Unk_234", "Unk_234_offset"),
                    new MultiStructItemCustomView(this, "Unk 235", "Unk_235", "Unk_235_offset"),
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

        public partial class Unk_Arr_4 : MhwStructItem, IWriteData {
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

            public static ObservableMhwStructCollection<Unk_Arr_4> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Unk_Arr_4>();
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

        public partial class W12p_Params_6_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W12p Params (6)";

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
                    ChangedItems.Add(nameof(Unk_240));
                    OnPropertyChanged(nameof(Unk_240));
                }
            }

            [DisplayName("Offset")]
            public long Unk_240_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_241));
                    OnPropertyChanged(nameof(Unk_241));
                }
            }

            [DisplayName("Offset")]
            public long Unk_241_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_242));
                    OnPropertyChanged(nameof(Unk_242));
                }
            }

            [DisplayName("Offset")]
            public long Unk_242_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_243));
                    OnPropertyChanged(nameof(Unk_243));
                }
            }

            [DisplayName("Offset")]
            public long Unk_243_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_244));
                    OnPropertyChanged(nameof(Unk_244));
                }
            }

            [DisplayName("Offset")]
            public long Unk_244_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_245));
                    OnPropertyChanged(nameof(Unk_245));
                }
            }

            [DisplayName("Offset")]
            public long Unk_245_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_246));
                    OnPropertyChanged(nameof(Unk_246));
                }
            }

            [DisplayName("Offset")]
            public long Unk_246_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_247));
                    OnPropertyChanged(nameof(Unk_247));
                }
            }

            [DisplayName("Offset")]
            public long Unk_247_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_248));
                    OnPropertyChanged(nameof(Unk_248));
                }
            }

            [DisplayName("Offset")]
            public long Unk_248_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_249));
                    OnPropertyChanged(nameof(Unk_249));
                }
            }

            [DisplayName("Offset")]
            public long Unk_249_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_250));
                    OnPropertyChanged(nameof(Unk_250));
                }
            }

            [DisplayName("Offset")]
            public long Unk_250_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_251));
                    OnPropertyChanged(nameof(Unk_251));
                }
            }

            [DisplayName("Offset")]
            public long Unk_251_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_252));
                    OnPropertyChanged(nameof(Unk_252));
                }
            }

            [DisplayName("Offset")]
            public long Unk_252_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_253));
                    OnPropertyChanged(nameof(Unk_253));
                }
            }

            [DisplayName("Offset")]
            public long Unk_253_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_254));
                    OnPropertyChanged(nameof(Unk_254));
                }
            }

            [DisplayName("Offset")]
            public long Unk_254_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_255));
                    OnPropertyChanged(nameof(Unk_255));
                }
            }

            [DisplayName("Offset")]
            public long Unk_255_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_256));
                    OnPropertyChanged(nameof(Unk_256));
                }
            }

            [DisplayName("Offset")]
            public long Unk_256_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_257));
                    OnPropertyChanged(nameof(Unk_257));
                }
            }

            [DisplayName("Offset")]
            public long Unk_257_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_258));
                    OnPropertyChanged(nameof(Unk_258));
                }
            }

            [DisplayName("Offset")]
            public long Unk_258_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_259));
                    OnPropertyChanged(nameof(Unk_259));
                }
            }

            [DisplayName("Offset")]
            public long Unk_259_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_260));
                    OnPropertyChanged(nameof(Unk_260));
                }
            }

            [DisplayName("Offset")]
            public long Unk_260_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_261));
                    OnPropertyChanged(nameof(Unk_261));
                }
            }

            [DisplayName("Offset")]
            public long Unk_261_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_262));
                    OnPropertyChanged(nameof(Unk_262));
                }
            }

            [DisplayName("Offset")]
            public long Unk_262_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_263));
                    OnPropertyChanged(nameof(Unk_263));
                }
            }

            [DisplayName("Offset")]
            public long Unk_263_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_264));
                    OnPropertyChanged(nameof(Unk_264));
                }
            }

            [DisplayName("Offset")]
            public long Unk_264_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_265));
                    OnPropertyChanged(nameof(Unk_265));
                }
            }

            [DisplayName("Offset")]
            public long Unk_265_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_266));
                    OnPropertyChanged(nameof(Unk_266));
                }
            }

            [DisplayName("Offset")]
            public long Unk_266_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_267));
                    OnPropertyChanged(nameof(Unk_267));
                }
            }

            [DisplayName("Offset")]
            public long Unk_267_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_268));
                    OnPropertyChanged(nameof(Unk_268));
                }
            }

            [DisplayName("Offset")]
            public long Unk_268_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_269));
                    OnPropertyChanged(nameof(Unk_269));
                }
            }

            [DisplayName("Offset")]
            public long Unk_269_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_270));
                    OnPropertyChanged(nameof(Unk_270));
                }
            }

            [DisplayName("Offset")]
            public long Unk_270_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_271));
                    OnPropertyChanged(nameof(Unk_271));
                }
            }

            [DisplayName("Offset")]
            public long Unk_271_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_272));
                    OnPropertyChanged(nameof(Unk_272));
                }
            }

            [DisplayName("Offset")]
            public long Unk_272_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_273));
                    OnPropertyChanged(nameof(Unk_273));
                }
            }

            [DisplayName("Offset")]
            public long Unk_273_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Close_range_Up_active_range_1));
                    OnPropertyChanged(nameof(Close_range_Up_active_range_1));
                }
            }

            [DisplayName("Offset")]
            public long Close_range_Up_active_range_1_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Close_range_Up_active_range_2));
                    OnPropertyChanged(nameof(Close_range_Up_active_range_2));
                }
            }

            [DisplayName("Offset")]
            public long Close_range_Up_active_range_2_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Close_range_Up_active_range_3));
                    OnPropertyChanged(nameof(Close_range_Up_active_range_3));
                }
            }

            [DisplayName("Offset")]
            public long Close_range_Up_active_range_3_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Close_range_Up_active_range_4));
                    OnPropertyChanged(nameof(Close_range_Up_active_range_4));
                }
            }

            [DisplayName("Offset")]
            public long Close_range_Up_active_range_4_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Close_range_Up_Modifier_1));
                    OnPropertyChanged(nameof(Close_range_Up_Modifier_1));
                }
            }

            [DisplayName("Offset")]
            public long Close_range_Up_Modifier_1_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Close_range_Up_Modifier_2));
                    OnPropertyChanged(nameof(Close_range_Up_Modifier_2));
                }
            }

            [DisplayName("Offset")]
            public long Close_range_Up_Modifier_2_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Close_range_Up_Modifier_3));
                    OnPropertyChanged(nameof(Close_range_Up_Modifier_3));
                }
            }

            [DisplayName("Offset")]
            public long Close_range_Up_Modifier_3_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Close_range_Up_Modifier_4));
                    OnPropertyChanged(nameof(Close_range_Up_Modifier_4));
                }
            }

            [DisplayName("Offset")]
            public long Close_range_Up_Modifier_4_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Ranged_Attack_Up_active_distance_1));
                    OnPropertyChanged(nameof(Ranged_Attack_Up_active_distance_1));
                }
            }

            [DisplayName("Offset")]
            public long Ranged_Attack_Up_active_distance_1_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Ranged_Attack_Up_active_distance_2));
                    OnPropertyChanged(nameof(Ranged_Attack_Up_active_distance_2));
                }
            }

            [DisplayName("Offset")]
            public long Ranged_Attack_Up_active_distance_2_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Ranged_Attack_Up_active_distance_3));
                    OnPropertyChanged(nameof(Ranged_Attack_Up_active_distance_3));
                }
            }

            [DisplayName("Offset")]
            public long Ranged_Attack_Up_active_distance_3_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Ranged_Attack_Up_active_distance_4));
                    OnPropertyChanged(nameof(Ranged_Attack_Up_active_distance_4));
                }
            }

            [DisplayName("Offset")]
            public long Ranged_Attack_Up_active_distance_4_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Ranged_Attack_Up_Modifier_1));
                    OnPropertyChanged(nameof(Ranged_Attack_Up_Modifier_1));
                }
            }

            [DisplayName("Offset")]
            public long Ranged_Attack_Up_Modifier_1_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Ranged_Attack_Up_Modifier_2));
                    OnPropertyChanged(nameof(Ranged_Attack_Up_Modifier_2));
                }
            }

            [DisplayName("Offset")]
            public long Ranged_Attack_Up_Modifier_2_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Ranged_Attack_Up_Modifier_3));
                    OnPropertyChanged(nameof(Ranged_Attack_Up_Modifier_3));
                }
            }

            [DisplayName("Offset")]
            public long Ranged_Attack_Up_Modifier_3_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Ranged_Attack_Up_Modifier_4));
                    OnPropertyChanged(nameof(Ranged_Attack_Up_Modifier_4));
                }
            }

            [DisplayName("Offset")]
            public long Ranged_Attack_Up_Modifier_4_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Guard_Angle_Both_Sides_));
                    OnPropertyChanged(nameof(Guard_Angle_Both_Sides_));
                }
            }

            [DisplayName("Offset")]
            public long Guard_Angle_Both_Sides__offset { get; private set; }

            public const int lastSortIndex = 2600;

            public static ObservableMhwStructCollection<W12p_Params_6_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<W12p_Params_6_>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W12p_Params_6_ LoadData(BinaryReader reader, ulong i) {
                var data = new W12p_Params_6_();
                data.Index = i;
                data.Unk_240_offset = reader.BaseStream.Position;
                data.Unk_240_raw = reader.ReadSingle();
                data.Unk_241_offset = reader.BaseStream.Position;
                data.Unk_241_raw = reader.ReadSingle();
                data.Unk_242_offset = reader.BaseStream.Position;
                data.Unk_242_raw = reader.ReadSingle();
                data.Unk_243_offset = reader.BaseStream.Position;
                data.Unk_243_raw = reader.ReadSingle();
                data.Unk_244_offset = reader.BaseStream.Position;
                data.Unk_244_raw = reader.ReadSingle();
                data.Unk_245_offset = reader.BaseStream.Position;
                data.Unk_245_raw = reader.ReadSingle();
                data.Unk_246_offset = reader.BaseStream.Position;
                data.Unk_246_raw = reader.ReadSingle();
                data.Unk_247_offset = reader.BaseStream.Position;
                data.Unk_247_raw = reader.ReadSingle();
                data.Unk_248_offset = reader.BaseStream.Position;
                data.Unk_248_raw = reader.ReadSingle();
                data.Unk_249_offset = reader.BaseStream.Position;
                data.Unk_249_raw = reader.ReadSingle();
                data.Unk_250_offset = reader.BaseStream.Position;
                data.Unk_250_raw = reader.ReadSingle();
                data.Unk_251_offset = reader.BaseStream.Position;
                data.Unk_251_raw = reader.ReadSingle();
                data.Unk_252_offset = reader.BaseStream.Position;
                data.Unk_252_raw = reader.ReadSingle();
                data.Unk_253_offset = reader.BaseStream.Position;
                data.Unk_253_raw = reader.ReadSingle();
                data.Unk_254_offset = reader.BaseStream.Position;
                data.Unk_254_raw = reader.ReadSingle();
                data.Unk_255_offset = reader.BaseStream.Position;
                data.Unk_255_raw = reader.ReadSingle();
                data.Unk_256_offset = reader.BaseStream.Position;
                data.Unk_256_raw = reader.ReadSingle();
                data.Unk_257_offset = reader.BaseStream.Position;
                data.Unk_257_raw = reader.ReadSingle();
                data.Unk_258_offset = reader.BaseStream.Position;
                data.Unk_258_raw = reader.ReadSingle();
                data.Unk_259_offset = reader.BaseStream.Position;
                data.Unk_259_raw = reader.ReadSingle();
                data.Unk_260_offset = reader.BaseStream.Position;
                data.Unk_260_raw = reader.ReadSingle();
                data.Unk_261_offset = reader.BaseStream.Position;
                data.Unk_261_raw = reader.ReadSingle();
                data.Unk_262_offset = reader.BaseStream.Position;
                data.Unk_262_raw = reader.ReadSingle();
                data.Unk_263_offset = reader.BaseStream.Position;
                data.Unk_263_raw = reader.ReadSingle();
                data.Unk_264_offset = reader.BaseStream.Position;
                data.Unk_264_raw = reader.ReadSingle();
                data.Unk_265_offset = reader.BaseStream.Position;
                data.Unk_265_raw = reader.ReadSingle();
                data.Unk_266_offset = reader.BaseStream.Position;
                data.Unk_266_raw = reader.ReadSingle();
                data.Unk_267_offset = reader.BaseStream.Position;
                data.Unk_267_raw = reader.ReadSingle();
                data.Unk_268_offset = reader.BaseStream.Position;
                data.Unk_268_raw = reader.ReadSingle();
                data.Unk_269_offset = reader.BaseStream.Position;
                data.Unk_269_raw = reader.ReadSingle();
                data.Unk_270_offset = reader.BaseStream.Position;
                data.Unk_270_raw = reader.ReadSingle();
                data.Unk_271_offset = reader.BaseStream.Position;
                data.Unk_271_raw = reader.ReadSingle();
                data.Unk_272_offset = reader.BaseStream.Position;
                data.Unk_272_raw = reader.ReadSingle();
                data.Unk_273_offset = reader.BaseStream.Position;
                data.Unk_273_raw = reader.ReadSingle();
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
                data.Ranged_Attack_Up_active_distance_1_offset = reader.BaseStream.Position;
                data.Ranged_Attack_Up_active_distance_1_raw = reader.ReadSingle();
                data.Ranged_Attack_Up_active_distance_2_offset = reader.BaseStream.Position;
                data.Ranged_Attack_Up_active_distance_2_raw = reader.ReadSingle();
                data.Ranged_Attack_Up_active_distance_3_offset = reader.BaseStream.Position;
                data.Ranged_Attack_Up_active_distance_3_raw = reader.ReadSingle();
                data.Ranged_Attack_Up_active_distance_4_offset = reader.BaseStream.Position;
                data.Ranged_Attack_Up_active_distance_4_raw = reader.ReadSingle();
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
                    new MultiStructItemCustomView(this, "Unk 240", "Unk_240", "Unk_240_offset"),
                    new MultiStructItemCustomView(this, "Unk 241", "Unk_241", "Unk_241_offset"),
                    new MultiStructItemCustomView(this, "Unk 242", "Unk_242", "Unk_242_offset"),
                    new MultiStructItemCustomView(this, "Unk 243", "Unk_243", "Unk_243_offset"),
                    new MultiStructItemCustomView(this, "Unk 244", "Unk_244", "Unk_244_offset"),
                    new MultiStructItemCustomView(this, "Unk 245", "Unk_245", "Unk_245_offset"),
                    new MultiStructItemCustomView(this, "Unk 246", "Unk_246", "Unk_246_offset"),
                    new MultiStructItemCustomView(this, "Unk 247", "Unk_247", "Unk_247_offset"),
                    new MultiStructItemCustomView(this, "Unk 248", "Unk_248", "Unk_248_offset"),
                    new MultiStructItemCustomView(this, "Unk 249", "Unk_249", "Unk_249_offset"),
                    new MultiStructItemCustomView(this, "Unk 250", "Unk_250", "Unk_250_offset"),
                    new MultiStructItemCustomView(this, "Unk 251", "Unk_251", "Unk_251_offset"),
                    new MultiStructItemCustomView(this, "Unk 252", "Unk_252", "Unk_252_offset"),
                    new MultiStructItemCustomView(this, "Unk 253", "Unk_253", "Unk_253_offset"),
                    new MultiStructItemCustomView(this, "Unk 254", "Unk_254", "Unk_254_offset"),
                    new MultiStructItemCustomView(this, "Unk 255", "Unk_255", "Unk_255_offset"),
                    new MultiStructItemCustomView(this, "Unk 256", "Unk_256", "Unk_256_offset"),
                    new MultiStructItemCustomView(this, "Unk 257", "Unk_257", "Unk_257_offset"),
                    new MultiStructItemCustomView(this, "Unk 258", "Unk_258", "Unk_258_offset"),
                    new MultiStructItemCustomView(this, "Unk 259", "Unk_259", "Unk_259_offset"),
                    new MultiStructItemCustomView(this, "Unk 260", "Unk_260", "Unk_260_offset"),
                    new MultiStructItemCustomView(this, "Unk 261", "Unk_261", "Unk_261_offset"),
                    new MultiStructItemCustomView(this, "Unk 262", "Unk_262", "Unk_262_offset"),
                    new MultiStructItemCustomView(this, "Unk 263", "Unk_263", "Unk_263_offset"),
                    new MultiStructItemCustomView(this, "Unk 264", "Unk_264", "Unk_264_offset"),
                    new MultiStructItemCustomView(this, "Unk 265", "Unk_265", "Unk_265_offset"),
                    new MultiStructItemCustomView(this, "Unk 266", "Unk_266", "Unk_266_offset"),
                    new MultiStructItemCustomView(this, "Unk 267", "Unk_267", "Unk_267_offset"),
                    new MultiStructItemCustomView(this, "Unk 268", "Unk_268", "Unk_268_offset"),
                    new MultiStructItemCustomView(this, "Unk 269", "Unk_269", "Unk_269_offset"),
                    new MultiStructItemCustomView(this, "Unk 270", "Unk_270", "Unk_270_offset"),
                    new MultiStructItemCustomView(this, "Unk 271", "Unk_271", "Unk_271_offset"),
                    new MultiStructItemCustomView(this, "Unk 272", "Unk_272", "Unk_272_offset"),
                    new MultiStructItemCustomView(this, "Unk 273", "Unk_273", "Unk_273_offset"),
                    new MultiStructItemCustomView(this, "Close range Up active range 1", "Close_range_Up_active_range_1", "Close_range_Up_active_range_1_offset"),
                    new MultiStructItemCustomView(this, "Close range Up active range 2", "Close_range_Up_active_range_2", "Close_range_Up_active_range_2_offset"),
                    new MultiStructItemCustomView(this, "Close range Up active range 3", "Close_range_Up_active_range_3", "Close_range_Up_active_range_3_offset"),
                    new MultiStructItemCustomView(this, "Close range Up active range 4", "Close_range_Up_active_range_4", "Close_range_Up_active_range_4_offset"),
                    new MultiStructItemCustomView(this, "Close range Up Modifier 1", "Close_range_Up_Modifier_1", "Close_range_Up_Modifier_1_offset"),
                    new MultiStructItemCustomView(this, "Close range Up Modifier 2", "Close_range_Up_Modifier_2", "Close_range_Up_Modifier_2_offset"),
                    new MultiStructItemCustomView(this, "Close range Up Modifier 3", "Close_range_Up_Modifier_3", "Close_range_Up_Modifier_3_offset"),
                    new MultiStructItemCustomView(this, "Close range Up Modifier 4", "Close_range_Up_Modifier_4", "Close_range_Up_Modifier_4_offset"),
                    new MultiStructItemCustomView(this, "Ranged Attack Up active distance 1", "Ranged_Attack_Up_active_distance_1", "Ranged_Attack_Up_active_distance_1_offset"),
                    new MultiStructItemCustomView(this, "Ranged Attack Up active distance 2", "Ranged_Attack_Up_active_distance_2", "Ranged_Attack_Up_active_distance_2_offset"),
                    new MultiStructItemCustomView(this, "Ranged Attack Up active distance 3", "Ranged_Attack_Up_active_distance_3", "Ranged_Attack_Up_active_distance_3_offset"),
                    new MultiStructItemCustomView(this, "Ranged Attack Up active distance 4", "Ranged_Attack_Up_active_distance_4", "Ranged_Attack_Up_active_distance_4_offset"),
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

        public partial class W12p_Params_7_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W12p Params (7)";

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
                    ChangedItems.Add(nameof(Unk_274));
                    OnPropertyChanged(nameof(Unk_274));
                }
            }

            [DisplayName("Offset")]
            public long Unk_274_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_282));
                    OnPropertyChanged(nameof(Unk_282));
                }
            }

            [DisplayName("Offset")]
            public long Unk_282_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_283));
                    OnPropertyChanged(nameof(Unk_283));
                }
            }

            [DisplayName("Offset")]
            public long Unk_283_offset { get; private set; }

            public const int lastSortIndex = 550;

            public static ObservableMhwStructCollection<W12p_Params_7_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<W12p_Params_7_>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W12p_Params_7_ LoadData(BinaryReader reader, ulong i) {
                var data = new W12p_Params_7_();
                data.Index = i;
                data.Unk_274_offset = reader.BaseStream.Position;
                data.Unk_274_raw = reader.ReadSingle();
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
                data.Unk_282_offset = reader.BaseStream.Position;
                data.Unk_282_raw = reader.ReadSingle();
                data.Unk_283_offset = reader.BaseStream.Position;
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
                    new MultiStructItemCustomView(this, "Unk 274", "Unk_274", "Unk_274_offset"),
                    new MultiStructItemCustomView(this, "Unk 275", "Unk_275", "Unk_275_offset"),
                    new MultiStructItemCustomView(this, "Unk 276", "Unk_276", "Unk_276_offset"),
                    new MultiStructItemCustomView(this, "Unk 277", "Unk_277", "Unk_277_offset"),
                    new MultiStructItemCustomView(this, "Unk 278", "Unk_278", "Unk_278_offset"),
                    new MultiStructItemCustomView(this, "Unk 279", "Unk_279", "Unk_279_offset"),
                    new MultiStructItemCustomView(this, "Unk 280", "Unk_280", "Unk_280_offset"),
                    new MultiStructItemCustomView(this, "Unk 281", "Unk_281", "Unk_281_offset"),
                    new MultiStructItemCustomView(this, "Unk 282", "Unk_282", "Unk_282_offset"),
                    new MultiStructItemCustomView(this, "Unk 283", "Unk_283", "Unk_283_offset"),
                };
            }
        }

        public partial class Unk_Arr_5 : MhwStructItem, IWriteData {
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

            public const int lastSortIndex = 250;

            public static ObservableMhwStructCollection<Unk_Arr_5> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Unk_Arr_5>();
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

        public partial class W12p_Params_8_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W12p Params (8)";

            protected float Unk_284_raw;
            public const string Unk_284_displayName = "Unk 284";
            public const int Unk_284_sortIndex = 50;
            [SortOrder(Unk_284_sortIndex)]
            [DisplayName(Unk_284_displayName)]
            public virtual float Unk_284 {
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

            protected float Unk_285_raw;
            public const string Unk_285_displayName = "Unk 285";
            public const int Unk_285_sortIndex = 100;
            [SortOrder(Unk_285_sortIndex)]
            [DisplayName(Unk_285_displayName)]
            public virtual float Unk_285 {
                get => Unk_285_raw;
                set {
                    if (Unk_285_raw == value) return;
                    Unk_285_raw = value;
                    ChangedItems.Add(nameof(Unk_285));
                    OnPropertyChanged(nameof(Unk_285));
                }
            }

            [DisplayName("Offset")]
            public long Unk_285_offset { get; private set; }

            protected float Unk_286_raw;
            public const string Unk_286_displayName = "Unk 286";
            public const int Unk_286_sortIndex = 150;
            [SortOrder(Unk_286_sortIndex)]
            [DisplayName(Unk_286_displayName)]
            public virtual float Unk_286 {
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

            protected float Unk_287_raw;
            public const string Unk_287_displayName = "Unk 287";
            public const int Unk_287_sortIndex = 200;
            [SortOrder(Unk_287_sortIndex)]
            [DisplayName(Unk_287_displayName)]
            public virtual float Unk_287 {
                get => Unk_287_raw;
                set {
                    if (Unk_287_raw == value) return;
                    Unk_287_raw = value;
                    ChangedItems.Add(nameof(Unk_287));
                    OnPropertyChanged(nameof(Unk_287));
                }
            }

            [DisplayName("Offset")]
            public long Unk_287_offset { get; private set; }

            protected float Unk_288_raw;
            public const string Unk_288_displayName = "Unk 288";
            public const int Unk_288_sortIndex = 250;
            [SortOrder(Unk_288_sortIndex)]
            [DisplayName(Unk_288_displayName)]
            public virtual float Unk_288 {
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

            protected float Unk_289_raw;
            public const string Unk_289_displayName = "Unk 289";
            public const int Unk_289_sortIndex = 300;
            [SortOrder(Unk_289_sortIndex)]
            [DisplayName(Unk_289_displayName)]
            public virtual float Unk_289 {
                get => Unk_289_raw;
                set {
                    if (Unk_289_raw == value) return;
                    Unk_289_raw = value;
                    ChangedItems.Add(nameof(Unk_289));
                    OnPropertyChanged(nameof(Unk_289));
                }
            }

            [DisplayName("Offset")]
            public long Unk_289_offset { get; private set; }

            public const int lastSortIndex = 350;

            public static ObservableMhwStructCollection<W12p_Params_8_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<W12p_Params_8_>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W12p_Params_8_ LoadData(BinaryReader reader, ulong i) {
                var data = new W12p_Params_8_();
                data.Index = i;
                data.Unk_284_offset = reader.BaseStream.Position;
                data.Unk_284_raw = reader.ReadSingle();
                data.Unk_285_offset = reader.BaseStream.Position;
                data.Unk_285_raw = reader.ReadSingle();
                data.Unk_286_offset = reader.BaseStream.Position;
                data.Unk_286_raw = reader.ReadSingle();
                data.Unk_287_offset = reader.BaseStream.Position;
                data.Unk_287_raw = reader.ReadSingle();
                data.Unk_288_offset = reader.BaseStream.Position;
                data.Unk_288_raw = reader.ReadSingle();
                data.Unk_289_offset = reader.BaseStream.Position;
                data.Unk_289_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_284_raw);
                writer.Write(Unk_285_raw);
                writer.Write(Unk_286_raw);
                writer.Write(Unk_287_raw);
                writer.Write(Unk_288_raw);
                writer.Write(Unk_289_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Unk 284", "Unk_284", "Unk_284_offset"),
                    new MultiStructItemCustomView(this, "Unk 285", "Unk_285", "Unk_285_offset"),
                    new MultiStructItemCustomView(this, "Unk 286", "Unk_286", "Unk_286_offset"),
                    new MultiStructItemCustomView(this, "Unk 287", "Unk_287", "Unk_287_offset"),
                    new MultiStructItemCustomView(this, "Unk 288", "Unk_288", "Unk_288_offset"),
                    new MultiStructItemCustomView(this, "Unk 289", "Unk_289", "Unk_289_offset"),
                };
            }
        }

        public override void LoadFile(string targetFile) {
            using var reader = new BinaryReader(OpenFile(targetFile, EncryptionKey), Encoding.UTF8);
            data = new LinkedList<MhwStructDataContainer>();
            var W12p_Params_1_Shared__ = new MhwStructDataContainer<W12p_Params_1_Shared_>(W12p_Params_1_Shared_.LoadData(reader), typeof(W12p_Params_1_Shared_));
            data.AddLast(W12p_Params_1_Shared__);
            var Unk_Arr_1_Shared__ = new MhwStructDataContainer<Unk_Arr_1_Shared_>(Unk_Arr_1_Shared_.LoadData(reader), typeof(Unk_Arr_1_Shared_));
            data.AddLast(Unk_Arr_1_Shared__);
            var W12p_Params_2_Shared__ = new MhwStructDataContainer<W12p_Params_2_Shared_>(W12p_Params_2_Shared_.LoadData(reader), typeof(W12p_Params_2_Shared_));
            data.AddLast(W12p_Params_2_Shared__);
            var Guard_Angles_Shared__ = new MhwStructDataContainer<Guard_Angles_Shared_>(Guard_Angles_Shared_.LoadData(reader), typeof(Guard_Angles_Shared_));
            data.AddLast(Guard_Angles_Shared__);
            var W12p_Params_3_Shared__ = new MhwStructDataContainer<W12p_Params_3_Shared_>(W12p_Params_3_Shared_.LoadData(reader), typeof(W12p_Params_3_Shared_));
            data.AddLast(W12p_Params_3_Shared__);
            var Unk_Arr_2_Shared__ = new MhwStructDataContainer<Unk_Arr_2_Shared_>(Unk_Arr_2_Shared_.LoadData(reader), typeof(Unk_Arr_2_Shared_));
            data.AddLast(Unk_Arr_2_Shared__);
            var W12p_Params_4_Shared__ = new MhwStructDataContainer<W12p_Params_4_Shared_>(W12p_Params_4_Shared_.LoadData(reader), typeof(W12p_Params_4_Shared_));
            data.AddLast(W12p_Params_4_Shared__);
            var W12p_Params_5__ = new MhwStructDataContainer<W12p_Params_5_>(W12p_Params_5_.LoadData(reader), typeof(W12p_Params_5_));
            data.AddLast(W12p_Params_5__);
            var Unk_Arr_3_ = new MhwStructDataContainer<Unk_Arr_3>(Unk_Arr_3.LoadData(reader), typeof(Unk_Arr_3));
            data.AddLast(Unk_Arr_3_);
            var Unk_Arr_4_ = new MhwStructDataContainer<Unk_Arr_4>(Unk_Arr_4.LoadData(reader), typeof(Unk_Arr_4));
            data.AddLast(Unk_Arr_4_);
            var W12p_Params_6__ = new MhwStructDataContainer<W12p_Params_6_>(W12p_Params_6_.LoadData(reader), typeof(W12p_Params_6_));
            data.AddLast(W12p_Params_6__);
            var Number_of_Shield_Mods_Struct_ = new MhwStructDataContainer<Number_of_Shield_Mods_Struct>(Number_of_Shield_Mods_Struct.LoadData(reader), typeof(Number_of_Shield_Mods_Struct));
            data.AddLast(Number_of_Shield_Mods_Struct_);
            var Shield_Mods_ = new MhwStructDataContainer<Shield_Mods, Number_of_Shield_Mods_Struct>(Shield_Mods.LoadData(reader, Number_of_Shield_Mods_Struct_.list), typeof(Shield_Mods));
            Shield_Mods_.SetCountTargetToUpdate(Number_of_Shield_Mods_Struct_, -1, "Number_of_Shield_Mods");
            data.AddLast(Shield_Mods_);
            var W12p_Params_7__ = new MhwStructDataContainer<W12p_Params_7_>(W12p_Params_7_.LoadData(reader), typeof(W12p_Params_7_));
            data.AddLast(W12p_Params_7__);
            var Unk_Arr_5_ = new MhwStructDataContainer<Unk_Arr_5>(Unk_Arr_5.LoadData(reader), typeof(Unk_Arr_5));
            data.AddLast(Unk_Arr_5_);
            var W12p_Params_8__ = new MhwStructDataContainer<W12p_Params_8_>(W12p_Params_8_.LoadData(reader), typeof(W12p_Params_8_));
            data.AddLast(W12p_Params_8__);
        }
    }
}
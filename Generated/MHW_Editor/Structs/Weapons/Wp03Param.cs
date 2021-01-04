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
    public partial class Wp03Param {
        public override string EncryptionKey => "j1P15gEkgVa7NdFxiqwCPitykHctY2nZPjSaElvqb0eSwcLO1cOlTqqv";

        public partial class W03p_Params_1_Shared_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W03p Params (1, Shared)";

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

            public static ObservableMhwStructCollection<W03p_Params_1_Shared_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<W03p_Params_1_Shared_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W03p_Params_1_Shared_ LoadData(BinaryReader reader, ulong i) {
                var data = new W03p_Params_1_Shared_();
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

        public partial class W03p_Params_2_Shared_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W03p Params (2, Shared)";

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

            public static ObservableMhwStructCollection<W03p_Params_2_Shared_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<W03p_Params_2_Shared_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W03p_Params_2_Shared_ LoadData(BinaryReader reader, ulong i) {
                var data = new W03p_Params_2_Shared_();
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

        public partial class W03p_Params_3_Shared_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W03p Params (3, Shared)";

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

            public static ObservableMhwStructCollection<W03p_Params_3_Shared_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<W03p_Params_3_Shared_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W03p_Params_3_Shared_ LoadData(BinaryReader reader, ulong i) {
                var data = new W03p_Params_3_Shared_();
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

        public partial class W03p_Params_4_Shared_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W03p Params (4, Shared)";

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

            public static ObservableMhwStructCollection<W03p_Params_4_Shared_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<W03p_Params_4_Shared_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W03p_Params_4_Shared_ LoadData(BinaryReader reader, ulong i) {
                var data = new W03p_Params_4_Shared_();
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

        public partial class W03p_Params_5_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W03p Params (5)";

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

            protected float Spirit_Gauge_Decay_raw;
            public const string Spirit_Gauge_Decay_displayName = "Spirit Gauge Decay";
            public const int Spirit_Gauge_Decay_sortIndex = 100;
            [SortOrder(Spirit_Gauge_Decay_sortIndex)]
            [DisplayName(Spirit_Gauge_Decay_displayName)]
            public virtual float Spirit_Gauge_Decay {
                get => Spirit_Gauge_Decay_raw;
                set {
                    if (Spirit_Gauge_Decay_raw == value) return;
                    Spirit_Gauge_Decay_raw = value;
                    ChangedItems.Add(nameof(Spirit_Gauge_Decay));
                    OnPropertyChanged(nameof(Spirit_Gauge_Decay));
                }
            }

            [DisplayName("Offset")]
            public long Spirit_Gauge_Decay_offset { get; private set; }

            protected float Spirit_Blade_1_Cost_raw;
            public const string Spirit_Blade_1_Cost_displayName = "Spirit Blade 1 Cost";
            public const int Spirit_Blade_1_Cost_sortIndex = 150;
            [SortOrder(Spirit_Blade_1_Cost_sortIndex)]
            [DisplayName(Spirit_Blade_1_Cost_displayName)]
            public virtual float Spirit_Blade_1_Cost {
                get => Spirit_Blade_1_Cost_raw;
                set {
                    if (Spirit_Blade_1_Cost_raw == value) return;
                    Spirit_Blade_1_Cost_raw = value;
                    ChangedItems.Add(nameof(Spirit_Blade_1_Cost));
                    OnPropertyChanged(nameof(Spirit_Blade_1_Cost));
                }
            }

            [DisplayName("Offset")]
            public long Spirit_Blade_1_Cost_offset { get; private set; }

            protected float Spirit_Blade_2_Cost_raw;
            public const string Spirit_Blade_2_Cost_displayName = "Spirit Blade 2 Cost";
            public const int Spirit_Blade_2_Cost_sortIndex = 200;
            [SortOrder(Spirit_Blade_2_Cost_sortIndex)]
            [DisplayName(Spirit_Blade_2_Cost_displayName)]
            public virtual float Spirit_Blade_2_Cost {
                get => Spirit_Blade_2_Cost_raw;
                set {
                    if (Spirit_Blade_2_Cost_raw == value) return;
                    Spirit_Blade_2_Cost_raw = value;
                    ChangedItems.Add(nameof(Spirit_Blade_2_Cost));
                    OnPropertyChanged(nameof(Spirit_Blade_2_Cost));
                }
            }

            [DisplayName("Offset")]
            public long Spirit_Blade_2_Cost_offset { get; private set; }

            protected float Spirit_Blade_3_Cost_raw;
            public const string Spirit_Blade_3_Cost_displayName = "Spirit Blade 3 Cost";
            public const int Spirit_Blade_3_Cost_sortIndex = 250;
            [SortOrder(Spirit_Blade_3_Cost_sortIndex)]
            [DisplayName(Spirit_Blade_3_Cost_displayName)]
            public virtual float Spirit_Blade_3_Cost {
                get => Spirit_Blade_3_Cost_raw;
                set {
                    if (Spirit_Blade_3_Cost_raw == value) return;
                    Spirit_Blade_3_Cost_raw = value;
                    ChangedItems.Add(nameof(Spirit_Blade_3_Cost));
                    OnPropertyChanged(nameof(Spirit_Blade_3_Cost));
                }
            }

            [DisplayName("Offset")]
            public long Spirit_Blade_3_Cost_offset { get; private set; }

            protected float Spirit_Round_Slash_Cost_raw;
            public const string Spirit_Round_Slash_Cost_displayName = "Spirit Round Slash Cost";
            public const int Spirit_Round_Slash_Cost_sortIndex = 300;
            [SortOrder(Spirit_Round_Slash_Cost_sortIndex)]
            [DisplayName(Spirit_Round_Slash_Cost_displayName)]
            public virtual float Spirit_Round_Slash_Cost {
                get => Spirit_Round_Slash_Cost_raw;
                set {
                    if (Spirit_Round_Slash_Cost_raw == value) return;
                    Spirit_Round_Slash_Cost_raw = value;
                    ChangedItems.Add(nameof(Spirit_Round_Slash_Cost));
                    OnPropertyChanged(nameof(Spirit_Round_Slash_Cost));
                }
            }

            [DisplayName("Offset")]
            public long Spirit_Round_Slash_Cost_offset { get; private set; }

            protected float Spirit_Jumping_Slash_Cost_raw;
            public const string Spirit_Jumping_Slash_Cost_displayName = "Spirit Jumping Slash Cost";
            public const int Spirit_Jumping_Slash_Cost_sortIndex = 350;
            [SortOrder(Spirit_Jumping_Slash_Cost_sortIndex)]
            [DisplayName(Spirit_Jumping_Slash_Cost_displayName)]
            public virtual float Spirit_Jumping_Slash_Cost {
                get => Spirit_Jumping_Slash_Cost_raw;
                set {
                    if (Spirit_Jumping_Slash_Cost_raw == value) return;
                    Spirit_Jumping_Slash_Cost_raw = value;
                    ChangedItems.Add(nameof(Spirit_Jumping_Slash_Cost));
                    OnPropertyChanged(nameof(Spirit_Jumping_Slash_Cost));
                }
            }

            [DisplayName("Offset")]
            public long Spirit_Jumping_Slash_Cost_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_99));
                    OnPropertyChanged(nameof(Unk_99));
                }
            }

            [DisplayName("Offset")]
            public long Unk_99_offset { get; private set; }

            protected float Jumping_Spirit_Blade_Cost_raw;
            public const string Jumping_Spirit_Blade_Cost_displayName = "Jumping Spirit Blade Cost";
            public const int Jumping_Spirit_Blade_Cost_sortIndex = 500;
            [SortOrder(Jumping_Spirit_Blade_Cost_sortIndex)]
            [DisplayName(Jumping_Spirit_Blade_Cost_displayName)]
            public virtual float Jumping_Spirit_Blade_Cost {
                get => Jumping_Spirit_Blade_Cost_raw;
                set {
                    if (Jumping_Spirit_Blade_Cost_raw == value) return;
                    Jumping_Spirit_Blade_Cost_raw = value;
                    ChangedItems.Add(nameof(Jumping_Spirit_Blade_Cost));
                    OnPropertyChanged(nameof(Jumping_Spirit_Blade_Cost));
                }
            }

            [DisplayName("Offset")]
            public long Jumping_Spirit_Blade_Cost_offset { get; private set; }

            protected float Jumping_Spirit_Blade_II_III_1st_Hit_Cost_raw;
            public const string Jumping_Spirit_Blade_II_III_1st_Hit_Cost_displayName = "Jumping Spirit Blade II / III (1st Hit) Cost";
            public const int Jumping_Spirit_Blade_II_III_1st_Hit_Cost_sortIndex = 550;
            [SortOrder(Jumping_Spirit_Blade_II_III_1st_Hit_Cost_sortIndex)]
            [DisplayName(Jumping_Spirit_Blade_II_III_1st_Hit_Cost_displayName)]
            public virtual float Jumping_Spirit_Blade_II_III_1st_Hit_Cost {
                get => Jumping_Spirit_Blade_II_III_1st_Hit_Cost_raw;
                set {
                    if (Jumping_Spirit_Blade_II_III_1st_Hit_Cost_raw == value) return;
                    Jumping_Spirit_Blade_II_III_1st_Hit_Cost_raw = value;
                    ChangedItems.Add(nameof(Jumping_Spirit_Blade_II_III_1st_Hit_Cost));
                    OnPropertyChanged(nameof(Jumping_Spirit_Blade_II_III_1st_Hit_Cost));
                }
            }

            [DisplayName("Offset")]
            public long Jumping_Spirit_Blade_II_III_1st_Hit_Cost_offset { get; private set; }

            protected float Gauge_Required_to_Active_Foresight_That_Gives_45_I_Frames_raw;
            public const string Gauge_Required_to_Active_Foresight_That_Gives_45_I_Frames_displayName = "Gauge Required to Active Foresight That Gives 45 I-Frames";
            public const int Gauge_Required_to_Active_Foresight_That_Gives_45_I_Frames_sortIndex = 600;
            [SortOrder(Gauge_Required_to_Active_Foresight_That_Gives_45_I_Frames_sortIndex)]
            [DisplayName(Gauge_Required_to_Active_Foresight_That_Gives_45_I_Frames_displayName)]
            public virtual float Gauge_Required_to_Active_Foresight_That_Gives_45_I_Frames {
                get => Gauge_Required_to_Active_Foresight_That_Gives_45_I_Frames_raw;
                set {
                    if (Gauge_Required_to_Active_Foresight_That_Gives_45_I_Frames_raw == value) return;
                    Gauge_Required_to_Active_Foresight_That_Gives_45_I_Frames_raw = value;
                    ChangedItems.Add(nameof(Gauge_Required_to_Active_Foresight_That_Gives_45_I_Frames));
                    OnPropertyChanged(nameof(Gauge_Required_to_Active_Foresight_That_Gives_45_I_Frames));
                }
            }

            [DisplayName("Offset")]
            public long Gauge_Required_to_Active_Foresight_That_Gives_45_I_Frames_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_103));
                    OnPropertyChanged(nameof(Unk_103));
                }
            }

            [DisplayName("Offset")]
            public long Unk_103_offset { get; private set; }

            protected float Aerial_Draw_Spirit_Blade_Cost_raw;
            public const string Aerial_Draw_Spirit_Blade_Cost_displayName = "Aerial Draw Spirit Blade Cost";
            public const int Aerial_Draw_Spirit_Blade_Cost_sortIndex = 700;
            [SortOrder(Aerial_Draw_Spirit_Blade_Cost_sortIndex)]
            [DisplayName(Aerial_Draw_Spirit_Blade_Cost_displayName)]
            public virtual float Aerial_Draw_Spirit_Blade_Cost {
                get => Aerial_Draw_Spirit_Blade_Cost_raw;
                set {
                    if (Aerial_Draw_Spirit_Blade_Cost_raw == value) return;
                    Aerial_Draw_Spirit_Blade_Cost_raw = value;
                    ChangedItems.Add(nameof(Aerial_Draw_Spirit_Blade_Cost));
                    OnPropertyChanged(nameof(Aerial_Draw_Spirit_Blade_Cost));
                }
            }

            [DisplayName("Offset")]
            public long Aerial_Draw_Spirit_Blade_Cost_offset { get; private set; }

            protected float Spirit_Regeneration_Duration_After_Helm_Breaker_In_Seconds__raw;
            public const string Spirit_Regeneration_Duration_After_Helm_Breaker_In_Seconds__displayName = "Spirit Regeneration Duration After Helm Breaker (In Seconds)";
            public const int Spirit_Regeneration_Duration_After_Helm_Breaker_In_Seconds__sortIndex = 750;
            [SortOrder(Spirit_Regeneration_Duration_After_Helm_Breaker_In_Seconds__sortIndex)]
            [DisplayName(Spirit_Regeneration_Duration_After_Helm_Breaker_In_Seconds__displayName)]
            public virtual float Spirit_Regeneration_Duration_After_Helm_Breaker_In_Seconds_ {
                get => Spirit_Regeneration_Duration_After_Helm_Breaker_In_Seconds__raw;
                set {
                    if (Spirit_Regeneration_Duration_After_Helm_Breaker_In_Seconds__raw == value) return;
                    Spirit_Regeneration_Duration_After_Helm_Breaker_In_Seconds__raw = value;
                    ChangedItems.Add(nameof(Spirit_Regeneration_Duration_After_Helm_Breaker_In_Seconds_));
                    OnPropertyChanged(nameof(Spirit_Regeneration_Duration_After_Helm_Breaker_In_Seconds_));
                }
            }

            [DisplayName("Offset")]
            public long Spirit_Regeneration_Duration_After_Helm_Breaker_In_Seconds__offset { get; private set; }

            protected float Spirit_Regeneration_After_Red_Gauge_Spirit_Helm_Breaker_Duration_in_Seconds__raw;
            public const string Spirit_Regeneration_After_Red_Gauge_Spirit_Helm_Breaker_Duration_in_Seconds__displayName = "Spirit Regeneration After: [Red Gauge] Spirit Helm Breaker (Duration in Seconds)";
            public const int Spirit_Regeneration_After_Red_Gauge_Spirit_Helm_Breaker_Duration_in_Seconds__sortIndex = 800;
            [SortOrder(Spirit_Regeneration_After_Red_Gauge_Spirit_Helm_Breaker_Duration_in_Seconds__sortIndex)]
            [DisplayName(Spirit_Regeneration_After_Red_Gauge_Spirit_Helm_Breaker_Duration_in_Seconds__displayName)]
            public virtual float Spirit_Regeneration_After_Red_Gauge_Spirit_Helm_Breaker_Duration_in_Seconds_ {
                get => Spirit_Regeneration_After_Red_Gauge_Spirit_Helm_Breaker_Duration_in_Seconds__raw;
                set {
                    if (Spirit_Regeneration_After_Red_Gauge_Spirit_Helm_Breaker_Duration_in_Seconds__raw == value) return;
                    Spirit_Regeneration_After_Red_Gauge_Spirit_Helm_Breaker_Duration_in_Seconds__raw = value;
                    ChangedItems.Add(nameof(Spirit_Regeneration_After_Red_Gauge_Spirit_Helm_Breaker_Duration_in_Seconds_));
                    OnPropertyChanged(nameof(Spirit_Regeneration_After_Red_Gauge_Spirit_Helm_Breaker_Duration_in_Seconds_));
                }
            }

            [DisplayName("Offset")]
            public long Spirit_Regeneration_After_Red_Gauge_Spirit_Helm_Breaker_Duration_in_Seconds__offset { get; private set; }

            protected float Spirit_Regeneration_After_Yellow_White_Gauge_Spirit_Helm_Breaker_Regen_Lower_Values_are_Faster__raw;
            public const string Spirit_Regeneration_After_Yellow_White_Gauge_Spirit_Helm_Breaker_Regen_Lower_Values_are_Faster__displayName = "Spirit Regeneration After: [Yellow & White Gauge] Spirit Helm Breaker (Regen, Lower Values are Faster)";
            public const int Spirit_Regeneration_After_Yellow_White_Gauge_Spirit_Helm_Breaker_Regen_Lower_Values_are_Faster__sortIndex = 850;
            [SortOrder(Spirit_Regeneration_After_Yellow_White_Gauge_Spirit_Helm_Breaker_Regen_Lower_Values_are_Faster__sortIndex)]
            [DisplayName(Spirit_Regeneration_After_Yellow_White_Gauge_Spirit_Helm_Breaker_Regen_Lower_Values_are_Faster__displayName)]
            public virtual float Spirit_Regeneration_After_Yellow_White_Gauge_Spirit_Helm_Breaker_Regen_Lower_Values_are_Faster_ {
                get => Spirit_Regeneration_After_Yellow_White_Gauge_Spirit_Helm_Breaker_Regen_Lower_Values_are_Faster__raw;
                set {
                    if (Spirit_Regeneration_After_Yellow_White_Gauge_Spirit_Helm_Breaker_Regen_Lower_Values_are_Faster__raw == value) return;
                    Spirit_Regeneration_After_Yellow_White_Gauge_Spirit_Helm_Breaker_Regen_Lower_Values_are_Faster__raw = value;
                    ChangedItems.Add(nameof(Spirit_Regeneration_After_Yellow_White_Gauge_Spirit_Helm_Breaker_Regen_Lower_Values_are_Faster_));
                    OnPropertyChanged(nameof(Spirit_Regeneration_After_Yellow_White_Gauge_Spirit_Helm_Breaker_Regen_Lower_Values_are_Faster_));
                }
            }

            [DisplayName("Offset")]
            public long Spirit_Regeneration_After_Yellow_White_Gauge_Spirit_Helm_Breaker_Regen_Lower_Values_are_Faster__offset { get; private set; }

            protected float Spirit_Regeneration_After_Red_Gauge_Spirit_Helm_Breaker_Regen_Lower_Values_are_Faster__raw;
            public const string Spirit_Regeneration_After_Red_Gauge_Spirit_Helm_Breaker_Regen_Lower_Values_are_Faster__displayName = "Spirit Regeneration After: [Red Gauge] Spirit Helm Breaker (Regen, Lower Values are Faster)";
            public const int Spirit_Regeneration_After_Red_Gauge_Spirit_Helm_Breaker_Regen_Lower_Values_are_Faster__sortIndex = 900;
            [SortOrder(Spirit_Regeneration_After_Red_Gauge_Spirit_Helm_Breaker_Regen_Lower_Values_are_Faster__sortIndex)]
            [DisplayName(Spirit_Regeneration_After_Red_Gauge_Spirit_Helm_Breaker_Regen_Lower_Values_are_Faster__displayName)]
            public virtual float Spirit_Regeneration_After_Red_Gauge_Spirit_Helm_Breaker_Regen_Lower_Values_are_Faster_ {
                get => Spirit_Regeneration_After_Red_Gauge_Spirit_Helm_Breaker_Regen_Lower_Values_are_Faster__raw;
                set {
                    if (Spirit_Regeneration_After_Red_Gauge_Spirit_Helm_Breaker_Regen_Lower_Values_are_Faster__raw == value) return;
                    Spirit_Regeneration_After_Red_Gauge_Spirit_Helm_Breaker_Regen_Lower_Values_are_Faster__raw = value;
                    ChangedItems.Add(nameof(Spirit_Regeneration_After_Red_Gauge_Spirit_Helm_Breaker_Regen_Lower_Values_are_Faster_));
                    OnPropertyChanged(nameof(Spirit_Regeneration_After_Red_Gauge_Spirit_Helm_Breaker_Regen_Lower_Values_are_Faster_));
                }
            }

            [DisplayName("Offset")]
            public long Spirit_Regeneration_After_Red_Gauge_Spirit_Helm_Breaker_Regen_Lower_Values_are_Faster__offset { get; private set; }

            protected float Spirit_Regeneration_After_Iai_Slash_Duration_in_Seconds__raw;
            public const string Spirit_Regeneration_After_Iai_Slash_Duration_in_Seconds__displayName = "Spirit Regeneration After: Iai Slash (Duration in Seconds)";
            public const int Spirit_Regeneration_After_Iai_Slash_Duration_in_Seconds__sortIndex = 950;
            [SortOrder(Spirit_Regeneration_After_Iai_Slash_Duration_in_Seconds__sortIndex)]
            [DisplayName(Spirit_Regeneration_After_Iai_Slash_Duration_in_Seconds__displayName)]
            public virtual float Spirit_Regeneration_After_Iai_Slash_Duration_in_Seconds_ {
                get => Spirit_Regeneration_After_Iai_Slash_Duration_in_Seconds__raw;
                set {
                    if (Spirit_Regeneration_After_Iai_Slash_Duration_in_Seconds__raw == value) return;
                    Spirit_Regeneration_After_Iai_Slash_Duration_in_Seconds__raw = value;
                    ChangedItems.Add(nameof(Spirit_Regeneration_After_Iai_Slash_Duration_in_Seconds_));
                    OnPropertyChanged(nameof(Spirit_Regeneration_After_Iai_Slash_Duration_in_Seconds_));
                }
            }

            [DisplayName("Offset")]
            public long Spirit_Regeneration_After_Iai_Slash_Duration_in_Seconds__offset { get; private set; }

            protected float Spirit_Regeneration_After_Timed_Iai_Slash_Duration_in_Seconds__raw;
            public const string Spirit_Regeneration_After_Timed_Iai_Slash_Duration_in_Seconds__displayName = "Spirit Regeneration After: Timed Iai Slash (Duration in Seconds)";
            public const int Spirit_Regeneration_After_Timed_Iai_Slash_Duration_in_Seconds__sortIndex = 1000;
            [SortOrder(Spirit_Regeneration_After_Timed_Iai_Slash_Duration_in_Seconds__sortIndex)]
            [DisplayName(Spirit_Regeneration_After_Timed_Iai_Slash_Duration_in_Seconds__displayName)]
            public virtual float Spirit_Regeneration_After_Timed_Iai_Slash_Duration_in_Seconds_ {
                get => Spirit_Regeneration_After_Timed_Iai_Slash_Duration_in_Seconds__raw;
                set {
                    if (Spirit_Regeneration_After_Timed_Iai_Slash_Duration_in_Seconds__raw == value) return;
                    Spirit_Regeneration_After_Timed_Iai_Slash_Duration_in_Seconds__raw = value;
                    ChangedItems.Add(nameof(Spirit_Regeneration_After_Timed_Iai_Slash_Duration_in_Seconds_));
                    OnPropertyChanged(nameof(Spirit_Regeneration_After_Timed_Iai_Slash_Duration_in_Seconds_));
                }
            }

            [DisplayName("Offset")]
            public long Spirit_Regeneration_After_Timed_Iai_Slash_Duration_in_Seconds__offset { get; private set; }

            protected float Spirit_Regeneration_After_Iai_Slash_Regen_Lower_Values_are_Faster__raw;
            public const string Spirit_Regeneration_After_Iai_Slash_Regen_Lower_Values_are_Faster__displayName = "Spirit Regeneration After: Iai Slash (Regen, Lower Values are Faster)";
            public const int Spirit_Regeneration_After_Iai_Slash_Regen_Lower_Values_are_Faster__sortIndex = 1050;
            [SortOrder(Spirit_Regeneration_After_Iai_Slash_Regen_Lower_Values_are_Faster__sortIndex)]
            [DisplayName(Spirit_Regeneration_After_Iai_Slash_Regen_Lower_Values_are_Faster__displayName)]
            public virtual float Spirit_Regeneration_After_Iai_Slash_Regen_Lower_Values_are_Faster_ {
                get => Spirit_Regeneration_After_Iai_Slash_Regen_Lower_Values_are_Faster__raw;
                set {
                    if (Spirit_Regeneration_After_Iai_Slash_Regen_Lower_Values_are_Faster__raw == value) return;
                    Spirit_Regeneration_After_Iai_Slash_Regen_Lower_Values_are_Faster__raw = value;
                    ChangedItems.Add(nameof(Spirit_Regeneration_After_Iai_Slash_Regen_Lower_Values_are_Faster_));
                    OnPropertyChanged(nameof(Spirit_Regeneration_After_Iai_Slash_Regen_Lower_Values_are_Faster_));
                }
            }

            [DisplayName("Offset")]
            public long Spirit_Regeneration_After_Iai_Slash_Regen_Lower_Values_are_Faster__offset { get; private set; }

            protected float Spirit_Regeneration_After_Timed_Iai_Slash_Regen_Lower_Values_are_Faster__raw;
            public const string Spirit_Regeneration_After_Timed_Iai_Slash_Regen_Lower_Values_are_Faster__displayName = "Spirit Regeneration After: Timed Iai Slash (Regen, Lower Values are Faster)";
            public const int Spirit_Regeneration_After_Timed_Iai_Slash_Regen_Lower_Values_are_Faster__sortIndex = 1100;
            [SortOrder(Spirit_Regeneration_After_Timed_Iai_Slash_Regen_Lower_Values_are_Faster__sortIndex)]
            [DisplayName(Spirit_Regeneration_After_Timed_Iai_Slash_Regen_Lower_Values_are_Faster__displayName)]
            public virtual float Spirit_Regeneration_After_Timed_Iai_Slash_Regen_Lower_Values_are_Faster_ {
                get => Spirit_Regeneration_After_Timed_Iai_Slash_Regen_Lower_Values_are_Faster__raw;
                set {
                    if (Spirit_Regeneration_After_Timed_Iai_Slash_Regen_Lower_Values_are_Faster__raw == value) return;
                    Spirit_Regeneration_After_Timed_Iai_Slash_Regen_Lower_Values_are_Faster__raw = value;
                    ChangedItems.Add(nameof(Spirit_Regeneration_After_Timed_Iai_Slash_Regen_Lower_Values_are_Faster_));
                    OnPropertyChanged(nameof(Spirit_Regeneration_After_Timed_Iai_Slash_Regen_Lower_Values_are_Faster_));
                }
            }

            [DisplayName("Offset")]
            public long Spirit_Regeneration_After_Timed_Iai_Slash_Regen_Lower_Values_are_Faster__offset { get; private set; }

            protected float Gauge_Duration_White_raw;
            public const string Gauge_Duration_White_displayName = "Gauge Duration: White";
            public const int Gauge_Duration_White_sortIndex = 1150;
            [SortOrder(Gauge_Duration_White_sortIndex)]
            [DisplayName(Gauge_Duration_White_displayName)]
            public virtual float Gauge_Duration_White {
                get => Gauge_Duration_White_raw;
                set {
                    if (Gauge_Duration_White_raw == value) return;
                    Gauge_Duration_White_raw = value;
                    ChangedItems.Add(nameof(Gauge_Duration_White));
                    OnPropertyChanged(nameof(Gauge_Duration_White));
                }
            }

            [DisplayName("Offset")]
            public long Gauge_Duration_White_offset { get; private set; }

            protected float Gauge_Duration_Yellow_raw;
            public const string Gauge_Duration_Yellow_displayName = "Gauge Duration: Yellow";
            public const int Gauge_Duration_Yellow_sortIndex = 1200;
            [SortOrder(Gauge_Duration_Yellow_sortIndex)]
            [DisplayName(Gauge_Duration_Yellow_displayName)]
            public virtual float Gauge_Duration_Yellow {
                get => Gauge_Duration_Yellow_raw;
                set {
                    if (Gauge_Duration_Yellow_raw == value) return;
                    Gauge_Duration_Yellow_raw = value;
                    ChangedItems.Add(nameof(Gauge_Duration_Yellow));
                    OnPropertyChanged(nameof(Gauge_Duration_Yellow));
                }
            }

            [DisplayName("Offset")]
            public long Gauge_Duration_Yellow_offset { get; private set; }

            protected float Gauge_Duration_Red_raw;
            public const string Gauge_Duration_Red_displayName = "Gauge Duration: Red";
            public const int Gauge_Duration_Red_sortIndex = 1250;
            [SortOrder(Gauge_Duration_Red_sortIndex)]
            [DisplayName(Gauge_Duration_Red_displayName)]
            public virtual float Gauge_Duration_Red {
                get => Gauge_Duration_Red_raw;
                set {
                    if (Gauge_Duration_Red_raw == value) return;
                    Gauge_Duration_Red_raw = value;
                    ChangedItems.Add(nameof(Gauge_Duration_Red));
                    OnPropertyChanged(nameof(Gauge_Duration_Red));
                }
            }

            [DisplayName("Offset")]
            public long Gauge_Duration_Red_offset { get; private set; }

            protected uint Gauge_Consumption_for_Helm_Plus_Iai_Spirit_Slash_raw;
            public const string Gauge_Consumption_for_Helm_Plus_Iai_Spirit_Slash_displayName = "Gauge Consumption for Helm + Iai Spirit Slash";
            public const int Gauge_Consumption_for_Helm_Plus_Iai_Spirit_Slash_sortIndex = 1300;
            [SortOrder(Gauge_Consumption_for_Helm_Plus_Iai_Spirit_Slash_sortIndex)]
            [DisplayName(Gauge_Consumption_for_Helm_Plus_Iai_Spirit_Slash_displayName)]
            public virtual uint Gauge_Consumption_for_Helm_Plus_Iai_Spirit_Slash {
                get => Gauge_Consumption_for_Helm_Plus_Iai_Spirit_Slash_raw;
                set {
                    if (Gauge_Consumption_for_Helm_Plus_Iai_Spirit_Slash_raw == value) return;
                    Gauge_Consumption_for_Helm_Plus_Iai_Spirit_Slash_raw = value;
                    ChangedItems.Add(nameof(Gauge_Consumption_for_Helm_Plus_Iai_Spirit_Slash));
                    OnPropertyChanged(nameof(Gauge_Consumption_for_Helm_Plus_Iai_Spirit_Slash));
                }
            }

            [DisplayName("Offset")]
            public long Gauge_Consumption_for_Helm_Plus_Iai_Spirit_Slash_offset { get; private set; }

            protected float Gauge_Damage_Buff_White_raw;
            public const string Gauge_Damage_Buff_White_displayName = "Gauge Damage Buff: White";
            public const int Gauge_Damage_Buff_White_sortIndex = 1350;
            [SortOrder(Gauge_Damage_Buff_White_sortIndex)]
            [DisplayName(Gauge_Damage_Buff_White_displayName)]
            public virtual float Gauge_Damage_Buff_White {
                get => Gauge_Damage_Buff_White_raw;
                set {
                    if (Gauge_Damage_Buff_White_raw == value) return;
                    Gauge_Damage_Buff_White_raw = value;
                    ChangedItems.Add(nameof(Gauge_Damage_Buff_White));
                    OnPropertyChanged(nameof(Gauge_Damage_Buff_White));
                }
            }

            [DisplayName("Offset")]
            public long Gauge_Damage_Buff_White_offset { get; private set; }

            protected float Gauge_Damage_Buff_Yellow_raw;
            public const string Gauge_Damage_Buff_Yellow_displayName = "Gauge Damage Buff: Yellow";
            public const int Gauge_Damage_Buff_Yellow_sortIndex = 1400;
            [SortOrder(Gauge_Damage_Buff_Yellow_sortIndex)]
            [DisplayName(Gauge_Damage_Buff_Yellow_displayName)]
            public virtual float Gauge_Damage_Buff_Yellow {
                get => Gauge_Damage_Buff_Yellow_raw;
                set {
                    if (Gauge_Damage_Buff_Yellow_raw == value) return;
                    Gauge_Damage_Buff_Yellow_raw = value;
                    ChangedItems.Add(nameof(Gauge_Damage_Buff_Yellow));
                    OnPropertyChanged(nameof(Gauge_Damage_Buff_Yellow));
                }
            }

            [DisplayName("Offset")]
            public long Gauge_Damage_Buff_Yellow_offset { get; private set; }

            protected float Gauge_Damage_Buff_Red_raw;
            public const string Gauge_Damage_Buff_Red_displayName = "Gauge Damage Buff: Red";
            public const int Gauge_Damage_Buff_Red_sortIndex = 1450;
            [SortOrder(Gauge_Damage_Buff_Red_sortIndex)]
            [DisplayName(Gauge_Damage_Buff_Red_displayName)]
            public virtual float Gauge_Damage_Buff_Red {
                get => Gauge_Damage_Buff_Red_raw;
                set {
                    if (Gauge_Damage_Buff_Red_raw == value) return;
                    Gauge_Damage_Buff_Red_raw = value;
                    ChangedItems.Add(nameof(Gauge_Damage_Buff_Red));
                    OnPropertyChanged(nameof(Gauge_Damage_Buff_Red));
                }
            }

            [DisplayName("Offset")]
            public long Gauge_Damage_Buff_Red_offset { get; private set; }

            protected float Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_1_raw;
            public const string Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_1_displayName = "Spirit Gen Multiplier Varies HZV After Applying Sharpness 1";
            public const int Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_1_sortIndex = 1500;
            [SortOrder(Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_1_sortIndex)]
            [DisplayName(Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_1_displayName)]
            public virtual float Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_1 {
                get => Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_1_raw;
                set {
                    if (Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_1_raw == value) return;
                    Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_1_raw = value;
                    ChangedItems.Add(nameof(Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_1));
                    OnPropertyChanged(nameof(Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_1));
                }
            }

            [DisplayName("Offset")]
            public long Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_1_offset { get; private set; }

            protected float Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_2_raw;
            public const string Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_2_displayName = "Spirit Gen Multiplier Varies HZV After Applying Sharpness 2";
            public const int Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_2_sortIndex = 1550;
            [SortOrder(Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_2_sortIndex)]
            [DisplayName(Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_2_displayName)]
            public virtual float Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_2 {
                get => Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_2_raw;
                set {
                    if (Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_2_raw == value) return;
                    Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_2_raw = value;
                    ChangedItems.Add(nameof(Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_2));
                    OnPropertyChanged(nameof(Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_2));
                }
            }

            [DisplayName("Offset")]
            public long Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_2_offset { get; private set; }

            protected float Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_3_raw;
            public const string Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_3_displayName = "Spirit Gen Multiplier Varies HZV After Applying Sharpness 3";
            public const int Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_3_sortIndex = 1600;
            [SortOrder(Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_3_sortIndex)]
            [DisplayName(Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_3_displayName)]
            public virtual float Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_3 {
                get => Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_3_raw;
                set {
                    if (Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_3_raw == value) return;
                    Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_3_raw = value;
                    ChangedItems.Add(nameof(Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_3));
                    OnPropertyChanged(nameof(Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_3));
                }
            }

            [DisplayName("Offset")]
            public long Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_3_offset { get; private set; }

            protected float Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_4_raw;
            public const string Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_4_displayName = "Spirit Gen Multiplier Varies HZV After Applying Sharpness 4";
            public const int Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_4_sortIndex = 1650;
            [SortOrder(Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_4_sortIndex)]
            [DisplayName(Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_4_displayName)]
            public virtual float Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_4 {
                get => Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_4_raw;
                set {
                    if (Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_4_raw == value) return;
                    Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_4_raw = value;
                    ChangedItems.Add(nameof(Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_4));
                    OnPropertyChanged(nameof(Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_4));
                }
            }

            [DisplayName("Offset")]
            public long Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_4_offset { get; private set; }

            protected float Gauge_No_Decay_Time_after_Spirit_Gauge_Upgrade_raw;
            public const string Gauge_No_Decay_Time_after_Spirit_Gauge_Upgrade_displayName = "Gauge No-Decay Time after Spirit Gauge Upgrade";
            public const int Gauge_No_Decay_Time_after_Spirit_Gauge_Upgrade_sortIndex = 1700;
            [SortOrder(Gauge_No_Decay_Time_after_Spirit_Gauge_Upgrade_sortIndex)]
            [DisplayName(Gauge_No_Decay_Time_after_Spirit_Gauge_Upgrade_displayName)]
            public virtual float Gauge_No_Decay_Time_after_Spirit_Gauge_Upgrade {
                get => Gauge_No_Decay_Time_after_Spirit_Gauge_Upgrade_raw;
                set {
                    if (Gauge_No_Decay_Time_after_Spirit_Gauge_Upgrade_raw == value) return;
                    Gauge_No_Decay_Time_after_Spirit_Gauge_Upgrade_raw = value;
                    ChangedItems.Add(nameof(Gauge_No_Decay_Time_after_Spirit_Gauge_Upgrade));
                    OnPropertyChanged(nameof(Gauge_No_Decay_Time_after_Spirit_Gauge_Upgrade));
                }
            }

            [DisplayName("Offset")]
            public long Gauge_No_Decay_Time_after_Spirit_Gauge_Upgrade_offset { get; private set; }

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

            protected float Foresight_Slash_Damage_Multiplier_on_Successful_Evasion_raw;
            public const string Foresight_Slash_Damage_Multiplier_on_Successful_Evasion_displayName = "Foresight Slash Damage Multiplier on Successful Evasion";
            public const int Foresight_Slash_Damage_Multiplier_on_Successful_Evasion_sortIndex = 1800;
            [SortOrder(Foresight_Slash_Damage_Multiplier_on_Successful_Evasion_sortIndex)]
            [DisplayName(Foresight_Slash_Damage_Multiplier_on_Successful_Evasion_displayName)]
            public virtual float Foresight_Slash_Damage_Multiplier_on_Successful_Evasion {
                get => Foresight_Slash_Damage_Multiplier_on_Successful_Evasion_raw;
                set {
                    if (Foresight_Slash_Damage_Multiplier_on_Successful_Evasion_raw == value) return;
                    Foresight_Slash_Damage_Multiplier_on_Successful_Evasion_raw = value;
                    ChangedItems.Add(nameof(Foresight_Slash_Damage_Multiplier_on_Successful_Evasion));
                    OnPropertyChanged(nameof(Foresight_Slash_Damage_Multiplier_on_Successful_Evasion));
                }
            }

            [DisplayName("Offset")]
            public long Foresight_Slash_Damage_Multiplier_on_Successful_Evasion_offset { get; private set; }

            protected byte Unk_127_raw;
            public const string Unk_127_displayName = "Unk 127";
            public const int Unk_127_sortIndex = 1850;
            [SortOrder(Unk_127_sortIndex)]
            [DisplayName(Unk_127_displayName)]
            public virtual byte Unk_127 {
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

            protected uint Unk_128_raw;
            public const string Unk_128_displayName = "Unk 128";
            public const int Unk_128_sortIndex = 1900;
            [SortOrder(Unk_128_sortIndex)]
            [DisplayName(Unk_128_displayName)]
            public virtual uint Unk_128 {
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

            protected ushort Unk_130_raw;
            public const string Unk_130_displayName = "Unk 130";
            public const int Unk_130_sortIndex = 2000;
            [SortOrder(Unk_130_sortIndex)]
            [DisplayName(Unk_130_displayName)]
            public virtual ushort Unk_130 {
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

            protected float Foresight_Slash_Super_Armor_Time_on_Successful_Evasion_raw;
            public const string Foresight_Slash_Super_Armor_Time_on_Successful_Evasion_displayName = "Foresight Slash Super Armor Time on Successful Evasion";
            public const int Foresight_Slash_Super_Armor_Time_on_Successful_Evasion_sortIndex = 2050;
            [SortOrder(Foresight_Slash_Super_Armor_Time_on_Successful_Evasion_sortIndex)]
            [DisplayName(Foresight_Slash_Super_Armor_Time_on_Successful_Evasion_displayName)]
            public virtual float Foresight_Slash_Super_Armor_Time_on_Successful_Evasion {
                get => Foresight_Slash_Super_Armor_Time_on_Successful_Evasion_raw;
                set {
                    if (Foresight_Slash_Super_Armor_Time_on_Successful_Evasion_raw == value) return;
                    Foresight_Slash_Super_Armor_Time_on_Successful_Evasion_raw = value;
                    ChangedItems.Add(nameof(Foresight_Slash_Super_Armor_Time_on_Successful_Evasion));
                    OnPropertyChanged(nameof(Foresight_Slash_Super_Armor_Time_on_Successful_Evasion));
                }
            }

            [DisplayName("Offset")]
            public long Foresight_Slash_Super_Armor_Time_on_Successful_Evasion_offset { get; private set; }

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

            protected float Iai_Move_Speed_Higher_Value_Make_Skill_Faster__raw;
            public const string Iai_Move_Speed_Higher_Value_Make_Skill_Faster__displayName = "Iai Move Speed (Higher Value Make Skill Faster)";
            public const int Iai_Move_Speed_Higher_Value_Make_Skill_Faster__sortIndex = 2150;
            [SortOrder(Iai_Move_Speed_Higher_Value_Make_Skill_Faster__sortIndex)]
            [DisplayName(Iai_Move_Speed_Higher_Value_Make_Skill_Faster__displayName)]
            public virtual float Iai_Move_Speed_Higher_Value_Make_Skill_Faster_ {
                get => Iai_Move_Speed_Higher_Value_Make_Skill_Faster__raw;
                set {
                    if (Iai_Move_Speed_Higher_Value_Make_Skill_Faster__raw == value) return;
                    Iai_Move_Speed_Higher_Value_Make_Skill_Faster__raw = value;
                    ChangedItems.Add(nameof(Iai_Move_Speed_Higher_Value_Make_Skill_Faster_));
                    OnPropertyChanged(nameof(Iai_Move_Speed_Higher_Value_Make_Skill_Faster_));
                }
            }

            [DisplayName("Offset")]
            public long Iai_Move_Speed_Higher_Value_Make_Skill_Faster__offset { get; private set; }

            protected float Iai_Sheathe_Time_raw;
            public const string Iai_Sheathe_Time_displayName = "Iai Sheathe Time";
            public const int Iai_Sheathe_Time_sortIndex = 2200;
            [SortOrder(Iai_Sheathe_Time_sortIndex)]
            [DisplayName(Iai_Sheathe_Time_displayName)]
            public virtual float Iai_Sheathe_Time {
                get => Iai_Sheathe_Time_raw;
                set {
                    if (Iai_Sheathe_Time_raw == value) return;
                    Iai_Sheathe_Time_raw = value;
                    ChangedItems.Add(nameof(Iai_Sheathe_Time));
                    OnPropertyChanged(nameof(Iai_Sheathe_Time));
                }
            }

            [DisplayName("Offset")]
            public long Iai_Sheathe_Time_offset { get; private set; }

            protected float Iai_Super_Armor_on_Successful_Counter_raw;
            public const string Iai_Super_Armor_on_Successful_Counter_displayName = "Iai Super Armor on Successful Counter";
            public const int Iai_Super_Armor_on_Successful_Counter_sortIndex = 2250;
            [SortOrder(Iai_Super_Armor_on_Successful_Counter_sortIndex)]
            [DisplayName(Iai_Super_Armor_on_Successful_Counter_displayName)]
            public virtual float Iai_Super_Armor_on_Successful_Counter {
                get => Iai_Super_Armor_on_Successful_Counter_raw;
                set {
                    if (Iai_Super_Armor_on_Successful_Counter_raw == value) return;
                    Iai_Super_Armor_on_Successful_Counter_raw = value;
                    ChangedItems.Add(nameof(Iai_Super_Armor_on_Successful_Counter));
                    OnPropertyChanged(nameof(Iai_Super_Armor_on_Successful_Counter));
                }
            }

            [DisplayName("Offset")]
            public long Iai_Super_Armor_on_Successful_Counter_offset { get; private set; }

            protected float Iai_Spirit_Slash_Second_Hit_Part_Damage_on_Successful_Counter_raw;
            public const string Iai_Spirit_Slash_Second_Hit_Part_Damage_on_Successful_Counter_displayName = "Iai Spirit Slash Second Hit Part Damage on Successful Counter";
            public const int Iai_Spirit_Slash_Second_Hit_Part_Damage_on_Successful_Counter_sortIndex = 2300;
            [SortOrder(Iai_Spirit_Slash_Second_Hit_Part_Damage_on_Successful_Counter_sortIndex)]
            [DisplayName(Iai_Spirit_Slash_Second_Hit_Part_Damage_on_Successful_Counter_displayName)]
            public virtual float Iai_Spirit_Slash_Second_Hit_Part_Damage_on_Successful_Counter {
                get => Iai_Spirit_Slash_Second_Hit_Part_Damage_on_Successful_Counter_raw;
                set {
                    if (Iai_Spirit_Slash_Second_Hit_Part_Damage_on_Successful_Counter_raw == value) return;
                    Iai_Spirit_Slash_Second_Hit_Part_Damage_on_Successful_Counter_raw = value;
                    ChangedItems.Add(nameof(Iai_Spirit_Slash_Second_Hit_Part_Damage_on_Successful_Counter));
                    OnPropertyChanged(nameof(Iai_Spirit_Slash_Second_Hit_Part_Damage_on_Successful_Counter));
                }
            }

            [DisplayName("Offset")]
            public long Iai_Spirit_Slash_Second_Hit_Part_Damage_on_Successful_Counter_offset { get; private set; }

            protected float Iai_Spirit_Slash_Second_Hit_Time_Delay_raw;
            public const string Iai_Spirit_Slash_Second_Hit_Time_Delay_displayName = "Iai Spirit Slash Second Hit Time Delay";
            public const int Iai_Spirit_Slash_Second_Hit_Time_Delay_sortIndex = 2350;
            [SortOrder(Iai_Spirit_Slash_Second_Hit_Time_Delay_sortIndex)]
            [DisplayName(Iai_Spirit_Slash_Second_Hit_Time_Delay_displayName)]
            public virtual float Iai_Spirit_Slash_Second_Hit_Time_Delay {
                get => Iai_Spirit_Slash_Second_Hit_Time_Delay_raw;
                set {
                    if (Iai_Spirit_Slash_Second_Hit_Time_Delay_raw == value) return;
                    Iai_Spirit_Slash_Second_Hit_Time_Delay_raw = value;
                    ChangedItems.Add(nameof(Iai_Spirit_Slash_Second_Hit_Time_Delay));
                    OnPropertyChanged(nameof(Iai_Spirit_Slash_Second_Hit_Time_Delay));
                }
            }

            [DisplayName("Offset")]
            public long Iai_Spirit_Slash_Second_Hit_Time_Delay_offset { get; private set; }

            public const int lastSortIndex = 2400;

            public static ObservableMhwStructCollection<W03p_Params_5_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<W03p_Params_5_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W03p_Params_5_ LoadData(BinaryReader reader, ulong i) {
                var data = new W03p_Params_5_();
                data.Index = i;
                data.Unk_91_offset = reader.BaseStream.Position;
                data.Unk_91_raw = reader.ReadSingle();
                data.Spirit_Gauge_Decay_offset = reader.BaseStream.Position;
                data.Spirit_Gauge_Decay_raw = reader.ReadSingle();
                data.Spirit_Blade_1_Cost_offset = reader.BaseStream.Position;
                data.Spirit_Blade_1_Cost_raw = reader.ReadSingle();
                data.Spirit_Blade_2_Cost_offset = reader.BaseStream.Position;
                data.Spirit_Blade_2_Cost_raw = reader.ReadSingle();
                data.Spirit_Blade_3_Cost_offset = reader.BaseStream.Position;
                data.Spirit_Blade_3_Cost_raw = reader.ReadSingle();
                data.Spirit_Round_Slash_Cost_offset = reader.BaseStream.Position;
                data.Spirit_Round_Slash_Cost_raw = reader.ReadSingle();
                data.Spirit_Jumping_Slash_Cost_offset = reader.BaseStream.Position;
                data.Spirit_Jumping_Slash_Cost_raw = reader.ReadSingle();
                data.Unk_98_offset = reader.BaseStream.Position;
                data.Unk_98_raw = reader.ReadSingle();
                data.Unk_99_offset = reader.BaseStream.Position;
                data.Unk_99_raw = reader.ReadSingle();
                data.Jumping_Spirit_Blade_Cost_offset = reader.BaseStream.Position;
                data.Jumping_Spirit_Blade_Cost_raw = reader.ReadSingle();
                data.Jumping_Spirit_Blade_II_III_1st_Hit_Cost_offset = reader.BaseStream.Position;
                data.Jumping_Spirit_Blade_II_III_1st_Hit_Cost_raw = reader.ReadSingle();
                data.Gauge_Required_to_Active_Foresight_That_Gives_45_I_Frames_offset = reader.BaseStream.Position;
                data.Gauge_Required_to_Active_Foresight_That_Gives_45_I_Frames_raw = reader.ReadSingle();
                data.Unk_103_offset = reader.BaseStream.Position;
                data.Unk_103_raw = reader.ReadSingle();
                data.Aerial_Draw_Spirit_Blade_Cost_offset = reader.BaseStream.Position;
                data.Aerial_Draw_Spirit_Blade_Cost_raw = reader.ReadSingle();
                data.Spirit_Regeneration_Duration_After_Helm_Breaker_In_Seconds__offset = reader.BaseStream.Position;
                data.Spirit_Regeneration_Duration_After_Helm_Breaker_In_Seconds__raw = reader.ReadSingle();
                data.Spirit_Regeneration_After_Red_Gauge_Spirit_Helm_Breaker_Duration_in_Seconds__offset = reader.BaseStream.Position;
                data.Spirit_Regeneration_After_Red_Gauge_Spirit_Helm_Breaker_Duration_in_Seconds__raw = reader.ReadSingle();
                data.Spirit_Regeneration_After_Yellow_White_Gauge_Spirit_Helm_Breaker_Regen_Lower_Values_are_Faster__offset = reader.BaseStream.Position;
                data.Spirit_Regeneration_After_Yellow_White_Gauge_Spirit_Helm_Breaker_Regen_Lower_Values_are_Faster__raw = reader.ReadSingle();
                data.Spirit_Regeneration_After_Red_Gauge_Spirit_Helm_Breaker_Regen_Lower_Values_are_Faster__offset = reader.BaseStream.Position;
                data.Spirit_Regeneration_After_Red_Gauge_Spirit_Helm_Breaker_Regen_Lower_Values_are_Faster__raw = reader.ReadSingle();
                data.Spirit_Regeneration_After_Iai_Slash_Duration_in_Seconds__offset = reader.BaseStream.Position;
                data.Spirit_Regeneration_After_Iai_Slash_Duration_in_Seconds__raw = reader.ReadSingle();
                data.Spirit_Regeneration_After_Timed_Iai_Slash_Duration_in_Seconds__offset = reader.BaseStream.Position;
                data.Spirit_Regeneration_After_Timed_Iai_Slash_Duration_in_Seconds__raw = reader.ReadSingle();
                data.Spirit_Regeneration_After_Iai_Slash_Regen_Lower_Values_are_Faster__offset = reader.BaseStream.Position;
                data.Spirit_Regeneration_After_Iai_Slash_Regen_Lower_Values_are_Faster__raw = reader.ReadSingle();
                data.Spirit_Regeneration_After_Timed_Iai_Slash_Regen_Lower_Values_are_Faster__offset = reader.BaseStream.Position;
                data.Spirit_Regeneration_After_Timed_Iai_Slash_Regen_Lower_Values_are_Faster__raw = reader.ReadSingle();
                data.Gauge_Duration_White_offset = reader.BaseStream.Position;
                data.Gauge_Duration_White_raw = reader.ReadSingle();
                data.Gauge_Duration_Yellow_offset = reader.BaseStream.Position;
                data.Gauge_Duration_Yellow_raw = reader.ReadSingle();
                data.Gauge_Duration_Red_offset = reader.BaseStream.Position;
                data.Gauge_Duration_Red_raw = reader.ReadSingle();
                data.Gauge_Consumption_for_Helm_Plus_Iai_Spirit_Slash_offset = reader.BaseStream.Position;
                data.Gauge_Consumption_for_Helm_Plus_Iai_Spirit_Slash_raw = reader.ReadUInt32();
                data.Gauge_Damage_Buff_White_offset = reader.BaseStream.Position;
                data.Gauge_Damage_Buff_White_raw = reader.ReadSingle();
                data.Gauge_Damage_Buff_Yellow_offset = reader.BaseStream.Position;
                data.Gauge_Damage_Buff_Yellow_raw = reader.ReadSingle();
                data.Gauge_Damage_Buff_Red_offset = reader.BaseStream.Position;
                data.Gauge_Damage_Buff_Red_raw = reader.ReadSingle();
                data.Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_1_offset = reader.BaseStream.Position;
                data.Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_1_raw = reader.ReadSingle();
                data.Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_2_offset = reader.BaseStream.Position;
                data.Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_2_raw = reader.ReadSingle();
                data.Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_3_offset = reader.BaseStream.Position;
                data.Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_3_raw = reader.ReadSingle();
                data.Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_4_offset = reader.BaseStream.Position;
                data.Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_4_raw = reader.ReadSingle();
                data.Gauge_No_Decay_Time_after_Spirit_Gauge_Upgrade_offset = reader.BaseStream.Position;
                data.Gauge_No_Decay_Time_after_Spirit_Gauge_Upgrade_raw = reader.ReadSingle();
                data.Unk_125_offset = reader.BaseStream.Position;
                data.Unk_125_raw = reader.ReadSingle();
                data.Foresight_Slash_Damage_Multiplier_on_Successful_Evasion_offset = reader.BaseStream.Position;
                data.Foresight_Slash_Damage_Multiplier_on_Successful_Evasion_raw = reader.ReadSingle();
                data.Unk_127_offset = reader.BaseStream.Position;
                data.Unk_127_raw = reader.ReadByte();
                data.Unk_128_offset = reader.BaseStream.Position;
                data.Unk_128_raw = reader.ReadUInt32();
                data.Unk_129_offset = reader.BaseStream.Position;
                data.Unk_129_raw = reader.ReadSingle();
                data.Unk_130_offset = reader.BaseStream.Position;
                data.Unk_130_raw = reader.ReadUInt16();
                data.Foresight_Slash_Super_Armor_Time_on_Successful_Evasion_offset = reader.BaseStream.Position;
                data.Foresight_Slash_Super_Armor_Time_on_Successful_Evasion_raw = reader.ReadSingle();
                data.Unk_132_offset = reader.BaseStream.Position;
                data.Unk_132_raw = reader.ReadSingle();
                data.Iai_Move_Speed_Higher_Value_Make_Skill_Faster__offset = reader.BaseStream.Position;
                data.Iai_Move_Speed_Higher_Value_Make_Skill_Faster__raw = reader.ReadSingle();
                data.Iai_Sheathe_Time_offset = reader.BaseStream.Position;
                data.Iai_Sheathe_Time_raw = reader.ReadSingle();
                data.Iai_Super_Armor_on_Successful_Counter_offset = reader.BaseStream.Position;
                data.Iai_Super_Armor_on_Successful_Counter_raw = reader.ReadSingle();
                data.Iai_Spirit_Slash_Second_Hit_Part_Damage_on_Successful_Counter_offset = reader.BaseStream.Position;
                data.Iai_Spirit_Slash_Second_Hit_Part_Damage_on_Successful_Counter_raw = reader.ReadSingle();
                data.Iai_Spirit_Slash_Second_Hit_Time_Delay_offset = reader.BaseStream.Position;
                data.Iai_Spirit_Slash_Second_Hit_Time_Delay_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_91_raw);
                writer.Write(Spirit_Gauge_Decay_raw);
                writer.Write(Spirit_Blade_1_Cost_raw);
                writer.Write(Spirit_Blade_2_Cost_raw);
                writer.Write(Spirit_Blade_3_Cost_raw);
                writer.Write(Spirit_Round_Slash_Cost_raw);
                writer.Write(Spirit_Jumping_Slash_Cost_raw);
                writer.Write(Unk_98_raw);
                writer.Write(Unk_99_raw);
                writer.Write(Jumping_Spirit_Blade_Cost_raw);
                writer.Write(Jumping_Spirit_Blade_II_III_1st_Hit_Cost_raw);
                writer.Write(Gauge_Required_to_Active_Foresight_That_Gives_45_I_Frames_raw);
                writer.Write(Unk_103_raw);
                writer.Write(Aerial_Draw_Spirit_Blade_Cost_raw);
                writer.Write(Spirit_Regeneration_Duration_After_Helm_Breaker_In_Seconds__raw);
                writer.Write(Spirit_Regeneration_After_Red_Gauge_Spirit_Helm_Breaker_Duration_in_Seconds__raw);
                writer.Write(Spirit_Regeneration_After_Yellow_White_Gauge_Spirit_Helm_Breaker_Regen_Lower_Values_are_Faster__raw);
                writer.Write(Spirit_Regeneration_After_Red_Gauge_Spirit_Helm_Breaker_Regen_Lower_Values_are_Faster__raw);
                writer.Write(Spirit_Regeneration_After_Iai_Slash_Duration_in_Seconds__raw);
                writer.Write(Spirit_Regeneration_After_Timed_Iai_Slash_Duration_in_Seconds__raw);
                writer.Write(Spirit_Regeneration_After_Iai_Slash_Regen_Lower_Values_are_Faster__raw);
                writer.Write(Spirit_Regeneration_After_Timed_Iai_Slash_Regen_Lower_Values_are_Faster__raw);
                writer.Write(Gauge_Duration_White_raw);
                writer.Write(Gauge_Duration_Yellow_raw);
                writer.Write(Gauge_Duration_Red_raw);
                writer.Write(Gauge_Consumption_for_Helm_Plus_Iai_Spirit_Slash_raw);
                writer.Write(Gauge_Damage_Buff_White_raw);
                writer.Write(Gauge_Damage_Buff_Yellow_raw);
                writer.Write(Gauge_Damage_Buff_Red_raw);
                writer.Write(Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_1_raw);
                writer.Write(Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_2_raw);
                writer.Write(Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_3_raw);
                writer.Write(Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_4_raw);
                writer.Write(Gauge_No_Decay_Time_after_Spirit_Gauge_Upgrade_raw);
                writer.Write(Unk_125_raw);
                writer.Write(Foresight_Slash_Damage_Multiplier_on_Successful_Evasion_raw);
                writer.Write(Unk_127_raw);
                writer.Write(Unk_128_raw);
                writer.Write(Unk_129_raw);
                writer.Write(Unk_130_raw);
                writer.Write(Foresight_Slash_Super_Armor_Time_on_Successful_Evasion_raw);
                writer.Write(Unk_132_raw);
                writer.Write(Iai_Move_Speed_Higher_Value_Make_Skill_Faster__raw);
                writer.Write(Iai_Sheathe_Time_raw);
                writer.Write(Iai_Super_Armor_on_Successful_Counter_raw);
                writer.Write(Iai_Spirit_Slash_Second_Hit_Part_Damage_on_Successful_Counter_raw);
                writer.Write(Iai_Spirit_Slash_Second_Hit_Time_Delay_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Unk 91", "Unk_91", "Unk_91_offset"),
                    new MultiStructItemCustomView(this, "Spirit Gauge Decay", "Spirit_Gauge_Decay", "Spirit_Gauge_Decay_offset"),
                    new MultiStructItemCustomView(this, "Spirit Blade 1 Cost", "Spirit_Blade_1_Cost", "Spirit_Blade_1_Cost_offset"),
                    new MultiStructItemCustomView(this, "Spirit Blade 2 Cost", "Spirit_Blade_2_Cost", "Spirit_Blade_2_Cost_offset"),
                    new MultiStructItemCustomView(this, "Spirit Blade 3 Cost", "Spirit_Blade_3_Cost", "Spirit_Blade_3_Cost_offset"),
                    new MultiStructItemCustomView(this, "Spirit Round Slash Cost", "Spirit_Round_Slash_Cost", "Spirit_Round_Slash_Cost_offset"),
                    new MultiStructItemCustomView(this, "Spirit Jumping Slash Cost", "Spirit_Jumping_Slash_Cost", "Spirit_Jumping_Slash_Cost_offset"),
                    new MultiStructItemCustomView(this, "Unk 98", "Unk_98", "Unk_98_offset"),
                    new MultiStructItemCustomView(this, "Unk 99", "Unk_99", "Unk_99_offset"),
                    new MultiStructItemCustomView(this, "Jumping Spirit Blade Cost", "Jumping_Spirit_Blade_Cost", "Jumping_Spirit_Blade_Cost_offset"),
                    new MultiStructItemCustomView(this, "Jumping Spirit Blade II / III (1st Hit) Cost", "Jumping_Spirit_Blade_II_III_1st_Hit_Cost", "Jumping_Spirit_Blade_II_III_1st_Hit_Cost_offset"),
                    new MultiStructItemCustomView(this, "Gauge Required to Active Foresight That Gives 45 I-Frames", "Gauge_Required_to_Active_Foresight_That_Gives_45_I_Frames", "Gauge_Required_to_Active_Foresight_That_Gives_45_I_Frames_offset"),
                    new MultiStructItemCustomView(this, "Unk 103", "Unk_103", "Unk_103_offset"),
                    new MultiStructItemCustomView(this, "Aerial Draw Spirit Blade Cost", "Aerial_Draw_Spirit_Blade_Cost", "Aerial_Draw_Spirit_Blade_Cost_offset"),
                    new MultiStructItemCustomView(this, "Spirit Regeneration Duration After Helm Breaker (In Seconds)", "Spirit_Regeneration_Duration_After_Helm_Breaker_In_Seconds_", "Spirit_Regeneration_Duration_After_Helm_Breaker_In_Seconds__offset"),
                    new MultiStructItemCustomView(this, "Spirit Regeneration After: [Red Gauge] Spirit Helm Breaker (Duration in Seconds)", "Spirit_Regeneration_After_Red_Gauge_Spirit_Helm_Breaker_Duration_in_Seconds_", "Spirit_Regeneration_After_Red_Gauge_Spirit_Helm_Breaker_Duration_in_Seconds__offset"),
                    new MultiStructItemCustomView(this, "Spirit Regeneration After: [Yellow & White Gauge] Spirit Helm Breaker (Regen, Lower Values are Faster)", "Spirit_Regeneration_After_Yellow_White_Gauge_Spirit_Helm_Breaker_Regen_Lower_Values_are_Faster_", "Spirit_Regeneration_After_Yellow_White_Gauge_Spirit_Helm_Breaker_Regen_Lower_Values_are_Faster__offset"),
                    new MultiStructItemCustomView(this, "Spirit Regeneration After: [Red Gauge] Spirit Helm Breaker (Regen, Lower Values are Faster)", "Spirit_Regeneration_After_Red_Gauge_Spirit_Helm_Breaker_Regen_Lower_Values_are_Faster_", "Spirit_Regeneration_After_Red_Gauge_Spirit_Helm_Breaker_Regen_Lower_Values_are_Faster__offset"),
                    new MultiStructItemCustomView(this, "Spirit Regeneration After: Iai Slash (Duration in Seconds)", "Spirit_Regeneration_After_Iai_Slash_Duration_in_Seconds_", "Spirit_Regeneration_After_Iai_Slash_Duration_in_Seconds__offset"),
                    new MultiStructItemCustomView(this, "Spirit Regeneration After: Timed Iai Slash (Duration in Seconds)", "Spirit_Regeneration_After_Timed_Iai_Slash_Duration_in_Seconds_", "Spirit_Regeneration_After_Timed_Iai_Slash_Duration_in_Seconds__offset"),
                    new MultiStructItemCustomView(this, "Spirit Regeneration After: Iai Slash (Regen, Lower Values are Faster)", "Spirit_Regeneration_After_Iai_Slash_Regen_Lower_Values_are_Faster_", "Spirit_Regeneration_After_Iai_Slash_Regen_Lower_Values_are_Faster__offset"),
                    new MultiStructItemCustomView(this, "Spirit Regeneration After: Timed Iai Slash (Regen, Lower Values are Faster)", "Spirit_Regeneration_After_Timed_Iai_Slash_Regen_Lower_Values_are_Faster_", "Spirit_Regeneration_After_Timed_Iai_Slash_Regen_Lower_Values_are_Faster__offset"),
                    new MultiStructItemCustomView(this, "Gauge Duration: White", "Gauge_Duration_White", "Gauge_Duration_White_offset"),
                    new MultiStructItemCustomView(this, "Gauge Duration: Yellow", "Gauge_Duration_Yellow", "Gauge_Duration_Yellow_offset"),
                    new MultiStructItemCustomView(this, "Gauge Duration: Red", "Gauge_Duration_Red", "Gauge_Duration_Red_offset"),
                    new MultiStructItemCustomView(this, "Gauge Consumption for Helm + Iai Spirit Slash", "Gauge_Consumption_for_Helm_Plus_Iai_Spirit_Slash", "Gauge_Consumption_for_Helm_Plus_Iai_Spirit_Slash_offset"),
                    new MultiStructItemCustomView(this, "Gauge Damage Buff: White", "Gauge_Damage_Buff_White", "Gauge_Damage_Buff_White_offset"),
                    new MultiStructItemCustomView(this, "Gauge Damage Buff: Yellow", "Gauge_Damage_Buff_Yellow", "Gauge_Damage_Buff_Yellow_offset"),
                    new MultiStructItemCustomView(this, "Gauge Damage Buff: Red", "Gauge_Damage_Buff_Red", "Gauge_Damage_Buff_Red_offset"),
                    new MultiStructItemCustomView(this, "Spirit Gen Multiplier Varies HZV After Applying Sharpness 1", "Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_1", "Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_1_offset"),
                    new MultiStructItemCustomView(this, "Spirit Gen Multiplier Varies HZV After Applying Sharpness 2", "Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_2", "Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_2_offset"),
                    new MultiStructItemCustomView(this, "Spirit Gen Multiplier Varies HZV After Applying Sharpness 3", "Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_3", "Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_3_offset"),
                    new MultiStructItemCustomView(this, "Spirit Gen Multiplier Varies HZV After Applying Sharpness 4", "Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_4", "Spirit_Gen_Multiplier_Varies_HZV_After_Applying_Sharpness_4_offset"),
                    new MultiStructItemCustomView(this, "Gauge No-Decay Time after Spirit Gauge Upgrade", "Gauge_No_Decay_Time_after_Spirit_Gauge_Upgrade", "Gauge_No_Decay_Time_after_Spirit_Gauge_Upgrade_offset"),
                    new MultiStructItemCustomView(this, "Unk 125", "Unk_125", "Unk_125_offset"),
                    new MultiStructItemCustomView(this, "Foresight Slash Damage Multiplier on Successful Evasion", "Foresight_Slash_Damage_Multiplier_on_Successful_Evasion", "Foresight_Slash_Damage_Multiplier_on_Successful_Evasion_offset"),
                    new MultiStructItemCustomView(this, "Unk 127", "Unk_127", "Unk_127_offset"),
                    new MultiStructItemCustomView(this, "Unk 128", "Unk_128", "Unk_128_offset"),
                    new MultiStructItemCustomView(this, "Unk 129", "Unk_129", "Unk_129_offset"),
                    new MultiStructItemCustomView(this, "Unk 130", "Unk_130", "Unk_130_offset"),
                    new MultiStructItemCustomView(this, "Foresight Slash Super Armor Time on Successful Evasion", "Foresight_Slash_Super_Armor_Time_on_Successful_Evasion", "Foresight_Slash_Super_Armor_Time_on_Successful_Evasion_offset"),
                    new MultiStructItemCustomView(this, "Unk 132", "Unk_132", "Unk_132_offset"),
                    new MultiStructItemCustomView(this, "Iai Move Speed (Higher Value Make Skill Faster)", "Iai_Move_Speed_Higher_Value_Make_Skill_Faster_", "Iai_Move_Speed_Higher_Value_Make_Skill_Faster__offset"),
                    new MultiStructItemCustomView(this, "Iai Sheathe Time", "Iai_Sheathe_Time", "Iai_Sheathe_Time_offset"),
                    new MultiStructItemCustomView(this, "Iai Super Armor on Successful Counter", "Iai_Super_Armor_on_Successful_Counter", "Iai_Super_Armor_on_Successful_Counter_offset"),
                    new MultiStructItemCustomView(this, "Iai Spirit Slash Second Hit Part Damage on Successful Counter", "Iai_Spirit_Slash_Second_Hit_Part_Damage_on_Successful_Counter", "Iai_Spirit_Slash_Second_Hit_Part_Damage_on_Successful_Counter_offset"),
                    new MultiStructItemCustomView(this, "Iai Spirit Slash Second Hit Time Delay", "Iai_Spirit_Slash_Second_Hit_Time_Delay", "Iai_Spirit_Slash_Second_Hit_Time_Delay_offset"),
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
                    ChangedItems.Add(nameof(Speed_Rate));
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
                    ChangedItems.Add(nameof(X_Offset));
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
                    ChangedItems.Add(nameof(Y_Offset));
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
                    ChangedItems.Add(nameof(Z_Offset));
                    OnPropertyChanged(nameof(Z_Offset));
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

        public partial class W03p_Params_6_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W03p Params (6)";

            protected float Unk_138_raw;
            public const string Unk_138_displayName = "Unk 138";
            public const int Unk_138_sortIndex = 50;
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
            public const int Unk_139_sortIndex = 100;
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

            public const int lastSortIndex = 150;

            public static ObservableMhwStructCollection<W03p_Params_6_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<W03p_Params_6_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W03p_Params_6_ LoadData(BinaryReader reader, ulong i) {
                var data = new W03p_Params_6_();
                data.Index = i;
                data.Unk_138_offset = reader.BaseStream.Position;
                data.Unk_138_raw = reader.ReadSingle();
                data.Unk_139_offset = reader.BaseStream.Position;
                data.Unk_139_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_138_raw);
                writer.Write(Unk_139_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Unk 138", "Unk_138", "Unk_138_offset"),
                    new MultiStructItemCustomView(this, "Unk 139", "Unk_139", "Unk_139_offset"),
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
                    ChangedItems.Add(nameof(Gravity));
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
                    ChangedItems.Add(nameof(Speed_Rate));
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
                    ChangedItems.Add(nameof(X_Offset));
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
                    ChangedItems.Add(nameof(Y_Offset));
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
                    ChangedItems.Add(nameof(Z_Offset));
                    OnPropertyChanged(nameof(Z_Offset));
                }
            }

            public const int lastSortIndex = 300;

            public static ObservableMhwStructCollection<Action_Param_2> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Action_Param_2>();
                const ulong count = 1UL;
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

        public partial class W03p_Params_7_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W03p Params (7)";

            protected float Unk_140_raw;
            public const string Unk_140_displayName = "Unk 140";
            public const int Unk_140_sortIndex = 50;
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

            public const int lastSortIndex = 100;

            public static ObservableMhwStructCollection<W03p_Params_7_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<W03p_Params_7_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W03p_Params_7_ LoadData(BinaryReader reader, ulong i) {
                var data = new W03p_Params_7_();
                data.Index = i;
                data.Unk_140_offset = reader.BaseStream.Position;
                data.Unk_140_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_140_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Unk 140", "Unk_140", "Unk_140_offset"),
                };
            }
        }

        public partial class Action_Param_3 : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 3;
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
                    ChangedItems.Add(nameof(Gravity));
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
                    ChangedItems.Add(nameof(Speed_Rate));
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
                    ChangedItems.Add(nameof(X_Offset));
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
                    ChangedItems.Add(nameof(Y_Offset));
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
                    ChangedItems.Add(nameof(Z_Offset));
                    OnPropertyChanged(nameof(Z_Offset));
                }
            }

            public const int lastSortIndex = 300;

            public static ObservableMhwStructCollection<Action_Param_3> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Action_Param_3>();
                const ulong count = 3UL;
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

        public partial class W03p_Params_8_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W03p Params (8)";

            protected float Unk_141_raw;
            public const string Unk_141_displayName = "Unk 141";
            public const int Unk_141_sortIndex = 50;
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

            public const int lastSortIndex = 100;

            public static ObservableMhwStructCollection<W03p_Params_8_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<W03p_Params_8_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W03p_Params_8_ LoadData(BinaryReader reader, ulong i) {
                var data = new W03p_Params_8_();
                data.Index = i;
                data.Unk_141_offset = reader.BaseStream.Position;
                data.Unk_141_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_141_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Unk 141", "Unk_141", "Unk_141_offset"),
                };
            }
        }

        public partial class Action_Param_4 : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 2;
            public const string GridName = "Action Param 4";

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
                    ChangedItems.Add(nameof(Speed_Rate));
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
                    ChangedItems.Add(nameof(X_Offset));
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
                    ChangedItems.Add(nameof(Y_Offset));
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
                    ChangedItems.Add(nameof(Z_Offset));
                    OnPropertyChanged(nameof(Z_Offset));
                }
            }

            public const int lastSortIndex = 300;

            public static ObservableMhwStructCollection<Action_Param_4> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Action_Param_4>();
                const ulong count = 2UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Action_Param_4 LoadData(BinaryReader reader, ulong i) {
                var data = new Action_Param_4();
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

        public partial class W03p_Params_9_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W03p Params (9)";
            public const string Description = "For Helmbreaker Hit Delay, some situations, like low or unstable fps, may cause less than 7 hits if the hit delays are <= 0.";

            protected float Unk_142_raw;
            public const string Unk_142_displayName = "Unk 142";
            public const int Unk_142_sortIndex = 50;
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
            public const int Unk_143_sortIndex = 100;
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

            protected float Unk_144_raw;
            public const string Unk_144_displayName = "Unk 144";
            public const int Unk_144_sortIndex = 150;
            [SortOrder(Unk_144_sortIndex)]
            [DisplayName(Unk_144_displayName)]
            public virtual float Unk_144 {
                get => Unk_144_raw;
                set {
                    if (Unk_144_raw == value) return;
                    Unk_144_raw = value;
                    ChangedItems.Add(nameof(Unk_144));
                    OnPropertyChanged(nameof(Unk_144));
                }
            }

            [DisplayName("Offset")]
            public long Unk_144_offset { get; private set; }

            protected float Helmbreaker_Hit_Delay_of_First_Hit_raw;
            public const string Helmbreaker_Hit_Delay_of_First_Hit_displayName = "Helmbreaker Hit Delay of First Hit";
            public const int Helmbreaker_Hit_Delay_of_First_Hit_sortIndex = 200;
            [SortOrder(Helmbreaker_Hit_Delay_of_First_Hit_sortIndex)]
            [DisplayName(Helmbreaker_Hit_Delay_of_First_Hit_displayName)]
            public virtual float Helmbreaker_Hit_Delay_of_First_Hit {
                get => Helmbreaker_Hit_Delay_of_First_Hit_raw;
                set {
                    if (Helmbreaker_Hit_Delay_of_First_Hit_raw == value) return;
                    Helmbreaker_Hit_Delay_of_First_Hit_raw = value;
                    ChangedItems.Add(nameof(Helmbreaker_Hit_Delay_of_First_Hit));
                    OnPropertyChanged(nameof(Helmbreaker_Hit_Delay_of_First_Hit));
                }
            }

            [DisplayName("Offset")]
            public long Helmbreaker_Hit_Delay_of_First_Hit_offset { get; private set; }

            protected float Helmbreaker_Hit_Delay_of_Hits_Between_First_Last_raw;
            public const string Helmbreaker_Hit_Delay_of_Hits_Between_First_Last_displayName = "Helmbreaker Hit Delay of Hits Between First & Last";
            public const int Helmbreaker_Hit_Delay_of_Hits_Between_First_Last_sortIndex = 250;
            [SortOrder(Helmbreaker_Hit_Delay_of_Hits_Between_First_Last_sortIndex)]
            [DisplayName(Helmbreaker_Hit_Delay_of_Hits_Between_First_Last_displayName)]
            public virtual float Helmbreaker_Hit_Delay_of_Hits_Between_First_Last {
                get => Helmbreaker_Hit_Delay_of_Hits_Between_First_Last_raw;
                set {
                    if (Helmbreaker_Hit_Delay_of_Hits_Between_First_Last_raw == value) return;
                    Helmbreaker_Hit_Delay_of_Hits_Between_First_Last_raw = value;
                    ChangedItems.Add(nameof(Helmbreaker_Hit_Delay_of_Hits_Between_First_Last));
                    OnPropertyChanged(nameof(Helmbreaker_Hit_Delay_of_Hits_Between_First_Last));
                }
            }

            [DisplayName("Offset")]
            public long Helmbreaker_Hit_Delay_of_Hits_Between_First_Last_offset { get; private set; }

            protected float Helmbreaker_Hit_Delay_of_Last_Hit_raw;
            public const string Helmbreaker_Hit_Delay_of_Last_Hit_displayName = "Helmbreaker Hit Delay of Last Hit";
            public const int Helmbreaker_Hit_Delay_of_Last_Hit_sortIndex = 300;
            [SortOrder(Helmbreaker_Hit_Delay_of_Last_Hit_sortIndex)]
            [DisplayName(Helmbreaker_Hit_Delay_of_Last_Hit_displayName)]
            public virtual float Helmbreaker_Hit_Delay_of_Last_Hit {
                get => Helmbreaker_Hit_Delay_of_Last_Hit_raw;
                set {
                    if (Helmbreaker_Hit_Delay_of_Last_Hit_raw == value) return;
                    Helmbreaker_Hit_Delay_of_Last_Hit_raw = value;
                    ChangedItems.Add(nameof(Helmbreaker_Hit_Delay_of_Last_Hit));
                    OnPropertyChanged(nameof(Helmbreaker_Hit_Delay_of_Last_Hit));
                }
            }

            [DisplayName("Offset")]
            public long Helmbreaker_Hit_Delay_of_Last_Hit_offset { get; private set; }

            protected uint Helmbreaker_Hit_Limit_raw;
            public const string Helmbreaker_Hit_Limit_displayName = "Helmbreaker Hit Limit";
            public const int Helmbreaker_Hit_Limit_sortIndex = 350;
            [SortOrder(Helmbreaker_Hit_Limit_sortIndex)]
            [DisplayName(Helmbreaker_Hit_Limit_displayName)]
            public virtual uint Helmbreaker_Hit_Limit {
                get => Helmbreaker_Hit_Limit_raw;
                set {
                    if (Helmbreaker_Hit_Limit_raw == value) return;
                    Helmbreaker_Hit_Limit_raw = value;
                    ChangedItems.Add(nameof(Helmbreaker_Hit_Limit));
                    OnPropertyChanged(nameof(Helmbreaker_Hit_Limit));
                }
            }

            [DisplayName("Offset")]
            public long Helmbreaker_Hit_Limit_offset { get; private set; }

            protected float Helmbreaker_Unk_raw;
            public const string Helmbreaker_Unk_displayName = "Helmbreaker Unk";
            public const int Helmbreaker_Unk_sortIndex = 400;
            [SortOrder(Helmbreaker_Unk_sortIndex)]
            [DisplayName(Helmbreaker_Unk_displayName)]
            public virtual float Helmbreaker_Unk {
                get => Helmbreaker_Unk_raw;
                set {
                    if (Helmbreaker_Unk_raw == value) return;
                    Helmbreaker_Unk_raw = value;
                    ChangedItems.Add(nameof(Helmbreaker_Unk));
                    OnPropertyChanged(nameof(Helmbreaker_Unk));
                }
            }

            [DisplayName("Offset")]
            public long Helmbreaker_Unk_offset { get; private set; }

            protected float Helmbreaker_Red_Line_Delay_raw;
            public const string Helmbreaker_Red_Line_Delay_displayName = "Helmbreaker Red Line Delay";
            public const int Helmbreaker_Red_Line_Delay_sortIndex = 450;
            [SortOrder(Helmbreaker_Red_Line_Delay_sortIndex)]
            [DisplayName(Helmbreaker_Red_Line_Delay_displayName)]
            public virtual float Helmbreaker_Red_Line_Delay {
                get => Helmbreaker_Red_Line_Delay_raw;
                set {
                    if (Helmbreaker_Red_Line_Delay_raw == value) return;
                    Helmbreaker_Red_Line_Delay_raw = value;
                    ChangedItems.Add(nameof(Helmbreaker_Red_Line_Delay));
                    OnPropertyChanged(nameof(Helmbreaker_Red_Line_Delay));
                }
            }

            [DisplayName("Offset")]
            public long Helmbreaker_Red_Line_Delay_offset { get; private set; }

            public const int lastSortIndex = 500;

            public static ObservableMhwStructCollection<W03p_Params_9_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<W03p_Params_9_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static W03p_Params_9_ LoadData(BinaryReader reader, ulong i) {
                var data = new W03p_Params_9_();
                data.Index = i;
                data.Unk_142_offset = reader.BaseStream.Position;
                data.Unk_142_raw = reader.ReadSingle();
                data.Unk_143_offset = reader.BaseStream.Position;
                data.Unk_143_raw = reader.ReadSingle();
                data.Unk_144_offset = reader.BaseStream.Position;
                data.Unk_144_raw = reader.ReadSingle();
                data.Helmbreaker_Hit_Delay_of_First_Hit_offset = reader.BaseStream.Position;
                data.Helmbreaker_Hit_Delay_of_First_Hit_raw = reader.ReadSingle();
                data.Helmbreaker_Hit_Delay_of_Hits_Between_First_Last_offset = reader.BaseStream.Position;
                data.Helmbreaker_Hit_Delay_of_Hits_Between_First_Last_raw = reader.ReadSingle();
                data.Helmbreaker_Hit_Delay_of_Last_Hit_offset = reader.BaseStream.Position;
                data.Helmbreaker_Hit_Delay_of_Last_Hit_raw = reader.ReadSingle();
                data.Helmbreaker_Hit_Limit_offset = reader.BaseStream.Position;
                data.Helmbreaker_Hit_Limit_raw = reader.ReadUInt32();
                data.Helmbreaker_Unk_offset = reader.BaseStream.Position;
                data.Helmbreaker_Unk_raw = reader.ReadSingle();
                data.Helmbreaker_Red_Line_Delay_offset = reader.BaseStream.Position;
                data.Helmbreaker_Red_Line_Delay_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_142_raw);
                writer.Write(Unk_143_raw);
                writer.Write(Unk_144_raw);
                writer.Write(Helmbreaker_Hit_Delay_of_First_Hit_raw);
                writer.Write(Helmbreaker_Hit_Delay_of_Hits_Between_First_Last_raw);
                writer.Write(Helmbreaker_Hit_Delay_of_Last_Hit_raw);
                writer.Write(Helmbreaker_Hit_Limit_raw);
                writer.Write(Helmbreaker_Unk_raw);
                writer.Write(Helmbreaker_Red_Line_Delay_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Unk 142", "Unk_142", "Unk_142_offset"),
                    new MultiStructItemCustomView(this, "Unk 143", "Unk_143", "Unk_143_offset"),
                    new MultiStructItemCustomView(this, "Unk 144", "Unk_144", "Unk_144_offset"),
                    new MultiStructItemCustomView(this, "Helmbreaker Hit Delay of First Hit", "Helmbreaker_Hit_Delay_of_First_Hit", "Helmbreaker_Hit_Delay_of_First_Hit_offset"),
                    new MultiStructItemCustomView(this, "Helmbreaker Hit Delay of Hits Between First & Last", "Helmbreaker_Hit_Delay_of_Hits_Between_First_Last", "Helmbreaker_Hit_Delay_of_Hits_Between_First_Last_offset"),
                    new MultiStructItemCustomView(this, "Helmbreaker Hit Delay of Last Hit", "Helmbreaker_Hit_Delay_of_Last_Hit", "Helmbreaker_Hit_Delay_of_Last_Hit_offset"),
                    new MultiStructItemCustomView(this, "Helmbreaker Hit Limit", "Helmbreaker_Hit_Limit", "Helmbreaker_Hit_Limit_offset"),
                    new MultiStructItemCustomView(this, "Helmbreaker Unk", "Helmbreaker_Unk", "Helmbreaker_Unk_offset"),
                    new MultiStructItemCustomView(this, "Helmbreaker Red Line Delay", "Helmbreaker_Red_Line_Delay", "Helmbreaker_Red_Line_Delay_offset"),
                };
            }
        }

        public partial class Action_Param_5 : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Action Param 5";

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
                    ChangedItems.Add(nameof(Speed_Rate));
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
                    ChangedItems.Add(nameof(X_Offset));
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
                    ChangedItems.Add(nameof(Y_Offset));
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
                    ChangedItems.Add(nameof(Z_Offset));
                    OnPropertyChanged(nameof(Z_Offset));
                }
            }

            public const int lastSortIndex = 300;

            public static ObservableMhwStructCollection<Action_Param_5> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Action_Param_5>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Action_Param_5 LoadData(BinaryReader reader, ulong i) {
                var data = new Action_Param_5();
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

        public override void LoadFile(string targetFile) {
            using var reader = new BinaryReader(OpenFile(targetFile, EncryptionKey), Encoding.UTF8);
            data = new LinkedList<MhwStructDataContainer>();
            var W03p_Params_1_Shared__ = new MhwStructDataContainer<W03p_Params_1_Shared_>(W03p_Params_1_Shared_.LoadData(reader), typeof(W03p_Params_1_Shared_));
            data.AddLast(W03p_Params_1_Shared__);
            var Unk_Arr_1_Shared__ = new MhwStructDataContainer<Unk_Arr_1_Shared_>(Unk_Arr_1_Shared_.LoadData(reader), typeof(Unk_Arr_1_Shared_));
            data.AddLast(Unk_Arr_1_Shared__);
            var W03p_Params_2_Shared__ = new MhwStructDataContainer<W03p_Params_2_Shared_>(W03p_Params_2_Shared_.LoadData(reader), typeof(W03p_Params_2_Shared_));
            data.AddLast(W03p_Params_2_Shared__);
            var Guard_Angles_Shared__ = new MhwStructDataContainer<Guard_Angles_Shared_>(Guard_Angles_Shared_.LoadData(reader), typeof(Guard_Angles_Shared_));
            data.AddLast(Guard_Angles_Shared__);
            var W03p_Params_3_Shared__ = new MhwStructDataContainer<W03p_Params_3_Shared_>(W03p_Params_3_Shared_.LoadData(reader), typeof(W03p_Params_3_Shared_));
            data.AddLast(W03p_Params_3_Shared__);
            var Unk_Arr_2_Shared__ = new MhwStructDataContainer<Unk_Arr_2_Shared_>(Unk_Arr_2_Shared_.LoadData(reader), typeof(Unk_Arr_2_Shared_));
            data.AddLast(Unk_Arr_2_Shared__);
            var W03p_Params_4_Shared__ = new MhwStructDataContainer<W03p_Params_4_Shared_>(W03p_Params_4_Shared_.LoadData(reader), typeof(W03p_Params_4_Shared_));
            data.AddLast(W03p_Params_4_Shared__);
            var W03p_Params_5__ = new MhwStructDataContainer<W03p_Params_5_>(W03p_Params_5_.LoadData(reader), typeof(W03p_Params_5_));
            data.AddLast(W03p_Params_5__);
            var Action_Param_1_ = new MhwStructDataContainer<Action_Param_1>(Action_Param_1.LoadData(reader), typeof(Action_Param_1));
            data.AddLast(Action_Param_1_);
            var W03p_Params_6__ = new MhwStructDataContainer<W03p_Params_6_>(W03p_Params_6_.LoadData(reader), typeof(W03p_Params_6_));
            data.AddLast(W03p_Params_6__);
            var Action_Param_2_ = new MhwStructDataContainer<Action_Param_2>(Action_Param_2.LoadData(reader), typeof(Action_Param_2));
            data.AddLast(Action_Param_2_);
            var W03p_Params_7__ = new MhwStructDataContainer<W03p_Params_7_>(W03p_Params_7_.LoadData(reader), typeof(W03p_Params_7_));
            data.AddLast(W03p_Params_7__);
            var Action_Param_3_ = new MhwStructDataContainer<Action_Param_3>(Action_Param_3.LoadData(reader), typeof(Action_Param_3));
            data.AddLast(Action_Param_3_);
            var W03p_Params_8__ = new MhwStructDataContainer<W03p_Params_8_>(W03p_Params_8_.LoadData(reader), typeof(W03p_Params_8_));
            data.AddLast(W03p_Params_8__);
            var Action_Param_4_ = new MhwStructDataContainer<Action_Param_4>(Action_Param_4.LoadData(reader), typeof(Action_Param_4));
            data.AddLast(Action_Param_4_);
            var W03p_Params_9__ = new MhwStructDataContainer<W03p_Params_9_>(W03p_Params_9_.LoadData(reader), typeof(W03p_Params_9_));
            data.AddLast(W03p_Params_9__);
            var Action_Param_5_ = new MhwStructDataContainer<Action_Param_5>(Action_Param_5.LoadData(reader), typeof(Action_Param_5));
            data.AddLast(Action_Param_5_);
        }
    }
}
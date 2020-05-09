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

namespace MHW_Editor.Monsters {
    public partial class MonsterClawGrab {
        public override string EncryptionKey => null;

        public partial class Monster_Claw_Grab : MhwStructItem {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Monster Claw Grab";

            protected uint Magic_1_raw;
            public const string Magic_1_displayName = "Magic 1";
            public const int Magic_1_sortIndex = 50;
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

            protected uint Magic_2_raw;
            public const string Magic_2_displayName = "Magic 2";
            public const int Magic_2_sortIndex = 100;
            [SortOrder(Magic_2_sortIndex)]
            [DisplayName(Magic_2_displayName)]
            [IsReadOnly]
            public virtual uint Magic_2 {
                get => Magic_2_raw;
                set {
                    if (Magic_2_raw == value) return;
                    Magic_2_raw = value;
                    OnPropertyChanged(nameof(Magic_2));
                }
            }

            protected uint Number_of_Claggers_raw;
            public const string Number_of_Claggers_displayName = "Number of Claggers";
            public const int Number_of_Claggers_sortIndex = 150;
            [SortOrder(Number_of_Claggers_sortIndex)]
            [DisplayName(Number_of_Claggers_displayName)]
            [IsReadOnly]
            public virtual uint Number_of_Claggers {
                get => Number_of_Claggers_raw;
                set {
                    if (Number_of_Claggers_raw == value) return;
                    Number_of_Claggers_raw = value;
                    OnPropertyChanged(nameof(Number_of_Claggers));
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

            public static Monster_Claw_Grab LoadData(BinaryReader reader, ulong i) {
                var data = new Monster_Claw_Grab();
                data.Index = i;
                data.Magic_1_raw = reader.ReadUInt32();
                data.Magic_2_raw = reader.ReadUInt32();
                data.Number_of_Claggers_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Magic_1_raw);
                writer.Write(Magic_2_raw);
                writer.Write(Number_of_Claggers_raw);
            }
        }

        public partial class Clagger_Params : MhwStructItem {
            public const ulong FixedSizeCount = 0;
            public const string GridName = "Clagger Params";
            public const bool IsAddingAllowed = true;

            [SortOrder(-1)]
            [IsReadOnly]
            [DisplayName("X")]
            public string Delete => "X";

            protected float Unk_f32__raw;
            public const string Unk_f32__displayName = "Unk (f32)";
            public const int Unk_f32__sortIndex = 50;
            [SortOrder(Unk_f32__sortIndex)]
            [DisplayName(Unk_f32__displayName)]
            public virtual float Unk_f32_ {
                get => Unk_f32__raw;
                set {
                    if (Unk_f32__raw == value) return;
                    Unk_f32__raw = value;
                    OnPropertyChanged(nameof(Unk_f32_));
                }
            }

            protected float Normal_raw;
            public const string Normal_displayName = "Normal";
            public const int Normal_sortIndex = 100;
            [SortOrder(Normal_sortIndex)]
            [DisplayName(Normal_displayName)]
            public virtual float Normal {
                get => Normal_raw;
                set {
                    if (Normal_raw == value) return;
                    Normal_raw = value;
                    OnPropertyChanged(nameof(Normal));
                }
            }

            protected float Enraged_raw;
            public const string Enraged_displayName = "Enraged";
            public const int Enraged_sortIndex = 150;
            [SortOrder(Enraged_sortIndex)]
            [DisplayName(Enraged_displayName)]
            public virtual float Enraged {
                get => Enraged_raw;
                set {
                    if (Enraged_raw == value) return;
                    Enraged_raw = value;
                    OnPropertyChanged(nameof(Enraged));
                }
            }

            protected float Tired_raw;
            public const string Tired_displayName = "Tired";
            public const int Tired_sortIndex = 200;
            [SortOrder(Tired_sortIndex)]
            [DisplayName(Tired_displayName)]
            public virtual float Tired {
                get => Tired_raw;
                set {
                    if (Tired_raw == value) return;
                    Tired_raw = value;
                    OnPropertyChanged(nameof(Tired));
                }
            }

            protected float Build_by_HP_90_100_raw;
            public const string Build_by_HP_90_100_displayName = "Build by HP%: 90-100";
            public const int Build_by_HP_90_100_sortIndex = 250;
            [SortOrder(Build_by_HP_90_100_sortIndex)]
            [DisplayName(Build_by_HP_90_100_displayName)]
            public virtual float Build_by_HP_90_100 {
                get => Build_by_HP_90_100_raw;
                set {
                    if (Build_by_HP_90_100_raw == value) return;
                    Build_by_HP_90_100_raw = value;
                    OnPropertyChanged(nameof(Build_by_HP_90_100));
                }
            }

            protected float Build_by_HP_80_90_raw;
            public const string Build_by_HP_80_90_displayName = "Build by HP%: 80-90";
            public const int Build_by_HP_80_90_sortIndex = 300;
            [SortOrder(Build_by_HP_80_90_sortIndex)]
            [DisplayName(Build_by_HP_80_90_displayName)]
            public virtual float Build_by_HP_80_90 {
                get => Build_by_HP_80_90_raw;
                set {
                    if (Build_by_HP_80_90_raw == value) return;
                    Build_by_HP_80_90_raw = value;
                    OnPropertyChanged(nameof(Build_by_HP_80_90));
                }
            }

            protected float Build_by_HP_70_80_raw;
            public const string Build_by_HP_70_80_displayName = "Build by HP%: 70-80";
            public const int Build_by_HP_70_80_sortIndex = 350;
            [SortOrder(Build_by_HP_70_80_sortIndex)]
            [DisplayName(Build_by_HP_70_80_displayName)]
            public virtual float Build_by_HP_70_80 {
                get => Build_by_HP_70_80_raw;
                set {
                    if (Build_by_HP_70_80_raw == value) return;
                    Build_by_HP_70_80_raw = value;
                    OnPropertyChanged(nameof(Build_by_HP_70_80));
                }
            }

            protected float Build_by_HP_60_70_raw;
            public const string Build_by_HP_60_70_displayName = "Build by HP%: 60-70";
            public const int Build_by_HP_60_70_sortIndex = 400;
            [SortOrder(Build_by_HP_60_70_sortIndex)]
            [DisplayName(Build_by_HP_60_70_displayName)]
            public virtual float Build_by_HP_60_70 {
                get => Build_by_HP_60_70_raw;
                set {
                    if (Build_by_HP_60_70_raw == value) return;
                    Build_by_HP_60_70_raw = value;
                    OnPropertyChanged(nameof(Build_by_HP_60_70));
                }
            }

            protected float Build_by_HP_50_60_raw;
            public const string Build_by_HP_50_60_displayName = "Build by HP%: 50-60";
            public const int Build_by_HP_50_60_sortIndex = 450;
            [SortOrder(Build_by_HP_50_60_sortIndex)]
            [DisplayName(Build_by_HP_50_60_displayName)]
            public virtual float Build_by_HP_50_60 {
                get => Build_by_HP_50_60_raw;
                set {
                    if (Build_by_HP_50_60_raw == value) return;
                    Build_by_HP_50_60_raw = value;
                    OnPropertyChanged(nameof(Build_by_HP_50_60));
                }
            }

            protected float Build_by_HP_40_50_raw;
            public const string Build_by_HP_40_50_displayName = "Build by HP%: 40-50";
            public const int Build_by_HP_40_50_sortIndex = 500;
            [SortOrder(Build_by_HP_40_50_sortIndex)]
            [DisplayName(Build_by_HP_40_50_displayName)]
            public virtual float Build_by_HP_40_50 {
                get => Build_by_HP_40_50_raw;
                set {
                    if (Build_by_HP_40_50_raw == value) return;
                    Build_by_HP_40_50_raw = value;
                    OnPropertyChanged(nameof(Build_by_HP_40_50));
                }
            }

            protected float Build_by_HP_30_40_raw;
            public const string Build_by_HP_30_40_displayName = "Build by HP%: 30-40";
            public const int Build_by_HP_30_40_sortIndex = 550;
            [SortOrder(Build_by_HP_30_40_sortIndex)]
            [DisplayName(Build_by_HP_30_40_displayName)]
            public virtual float Build_by_HP_30_40 {
                get => Build_by_HP_30_40_raw;
                set {
                    if (Build_by_HP_30_40_raw == value) return;
                    Build_by_HP_30_40_raw = value;
                    OnPropertyChanged(nameof(Build_by_HP_30_40));
                }
            }

            protected float Build_by_HP_20_30_raw;
            public const string Build_by_HP_20_30_displayName = "Build by HP%: 20-30";
            public const int Build_by_HP_20_30_sortIndex = 600;
            [SortOrder(Build_by_HP_20_30_sortIndex)]
            [DisplayName(Build_by_HP_20_30_displayName)]
            public virtual float Build_by_HP_20_30 {
                get => Build_by_HP_20_30_raw;
                set {
                    if (Build_by_HP_20_30_raw == value) return;
                    Build_by_HP_20_30_raw = value;
                    OnPropertyChanged(nameof(Build_by_HP_20_30));
                }
            }

            protected float Build_by_HP_10_20_raw;
            public const string Build_by_HP_10_20_displayName = "Build by HP%: 10-20";
            public const int Build_by_HP_10_20_sortIndex = 650;
            [SortOrder(Build_by_HP_10_20_sortIndex)]
            [DisplayName(Build_by_HP_10_20_displayName)]
            public virtual float Build_by_HP_10_20 {
                get => Build_by_HP_10_20_raw;
                set {
                    if (Build_by_HP_10_20_raw == value) return;
                    Build_by_HP_10_20_raw = value;
                    OnPropertyChanged(nameof(Build_by_HP_10_20));
                }
            }

            protected float Build_by_HP_0_10_raw;
            public const string Build_by_HP_0_10_displayName = "Build by HP%: 0-10";
            public const int Build_by_HP_0_10_sortIndex = 700;
            [SortOrder(Build_by_HP_0_10_sortIndex)]
            [DisplayName(Build_by_HP_0_10_displayName)]
            public virtual float Build_by_HP_0_10 {
                get => Build_by_HP_0_10_raw;
                set {
                    if (Build_by_HP_0_10_raw == value) return;
                    Build_by_HP_0_10_raw = value;
                    OnPropertyChanged(nameof(Build_by_HP_0_10));
                }
            }

            protected float Tenderize_Lv_State_LR_raw;
            public const string Tenderize_Lv_State_LR_displayName = "Tenderize Lv State LR";
            public const int Tenderize_Lv_State_LR_sortIndex = 750;
            [SortOrder(Tenderize_Lv_State_LR_sortIndex)]
            [DisplayName(Tenderize_Lv_State_LR_displayName)]
            public virtual float Tenderize_Lv_State_LR {
                get => Tenderize_Lv_State_LR_raw;
                set {
                    if (Tenderize_Lv_State_LR_raw == value) return;
                    Tenderize_Lv_State_LR_raw = value;
                    OnPropertyChanged(nameof(Tenderize_Lv_State_LR));
                }
            }

            protected float Tenderize_Lv_State_HR_raw;
            public const string Tenderize_Lv_State_HR_displayName = "Tenderize Lv State HR";
            public const int Tenderize_Lv_State_HR_sortIndex = 800;
            [SortOrder(Tenderize_Lv_State_HR_sortIndex)]
            [DisplayName(Tenderize_Lv_State_HR_displayName)]
            public virtual float Tenderize_Lv_State_HR {
                get => Tenderize_Lv_State_HR_raw;
                set {
                    if (Tenderize_Lv_State_HR_raw == value) return;
                    Tenderize_Lv_State_HR_raw = value;
                    OnPropertyChanged(nameof(Tenderize_Lv_State_HR));
                }
            }

            protected float Tenderize_Lv_State_MR_raw;
            public const string Tenderize_Lv_State_MR_displayName = "Tenderize Lv State MR";
            public const int Tenderize_Lv_State_MR_sortIndex = 850;
            [SortOrder(Tenderize_Lv_State_MR_sortIndex)]
            [DisplayName(Tenderize_Lv_State_MR_displayName)]
            public virtual float Tenderize_Lv_State_MR {
                get => Tenderize_Lv_State_MR_raw;
                set {
                    if (Tenderize_Lv_State_MR_raw == value) return;
                    Tenderize_Lv_State_MR_raw = value;
                    OnPropertyChanged(nameof(Tenderize_Lv_State_MR));
                }
            }

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
                var countTarget = (Monster_Claw_Grab) lastStruct.Last();
                var count = (ulong) countTarget.Number_of_Claggers;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Clagger_Params LoadData(BinaryReader reader, ulong i) {
                var data = new Clagger_Params();
                data.Index = i;
                data.Unk_f32__raw = reader.ReadSingle();
                data.Normal_raw = reader.ReadSingle();
                data.Enraged_raw = reader.ReadSingle();
                data.Tired_raw = reader.ReadSingle();
                data.Build_by_HP_90_100_raw = reader.ReadSingle();
                data.Build_by_HP_80_90_raw = reader.ReadSingle();
                data.Build_by_HP_70_80_raw = reader.ReadSingle();
                data.Build_by_HP_60_70_raw = reader.ReadSingle();
                data.Build_by_HP_50_60_raw = reader.ReadSingle();
                data.Build_by_HP_40_50_raw = reader.ReadSingle();
                data.Build_by_HP_30_40_raw = reader.ReadSingle();
                data.Build_by_HP_20_30_raw = reader.ReadSingle();
                data.Build_by_HP_10_20_raw = reader.ReadSingle();
                data.Build_by_HP_0_10_raw = reader.ReadSingle();
                data.Tenderize_Lv_State_LR_raw = reader.ReadSingle();
                data.Tenderize_Lv_State_HR_raw = reader.ReadSingle();
                data.Tenderize_Lv_State_MR_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_f32__raw);
                writer.Write(Normal_raw);
                writer.Write(Enraged_raw);
                writer.Write(Tired_raw);
                writer.Write(Build_by_HP_90_100_raw);
                writer.Write(Build_by_HP_80_90_raw);
                writer.Write(Build_by_HP_70_80_raw);
                writer.Write(Build_by_HP_60_70_raw);
                writer.Write(Build_by_HP_50_60_raw);
                writer.Write(Build_by_HP_40_50_raw);
                writer.Write(Build_by_HP_30_40_raw);
                writer.Write(Build_by_HP_20_30_raw);
                writer.Write(Build_by_HP_10_20_raw);
                writer.Write(Build_by_HP_0_10_raw);
                writer.Write(Tenderize_Lv_State_LR_raw);
                writer.Write(Tenderize_Lv_State_HR_raw);
                writer.Write(Tenderize_Lv_State_MR_raw);
            }
        }

        public partial class Claw_Chance_Params : MhwStructItem, IHasCustomView<MultiStructItemCustomView> {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Claw Chance Params";

            protected uint Gimmick_Breaker_Collision_Unique_Id_Small_raw;
            public const string Gimmick_Breaker_Collision_Unique_Id_Small_displayName = "Gimmick Breaker Collision Unique Id Small";
            public const int Gimmick_Breaker_Collision_Unique_Id_Small_sortIndex = 50;
            [SortOrder(Gimmick_Breaker_Collision_Unique_Id_Small_sortIndex)]
            [DisplayName(Gimmick_Breaker_Collision_Unique_Id_Small_displayName)]
            public virtual uint Gimmick_Breaker_Collision_Unique_Id_Small {
                get => Gimmick_Breaker_Collision_Unique_Id_Small_raw;
                set {
                    if (Gimmick_Breaker_Collision_Unique_Id_Small_raw == value) return;
                    Gimmick_Breaker_Collision_Unique_Id_Small_raw = value;
                    OnPropertyChanged(nameof(Gimmick_Breaker_Collision_Unique_Id_Small));
                }
            }

            protected uint Gimmick_Breaker_Collision_Unique_Id_Middle_raw;
            public const string Gimmick_Breaker_Collision_Unique_Id_Middle_displayName = "Gimmick Breaker Collision Unique Id Middle";
            public const int Gimmick_Breaker_Collision_Unique_Id_Middle_sortIndex = 100;
            [SortOrder(Gimmick_Breaker_Collision_Unique_Id_Middle_sortIndex)]
            [DisplayName(Gimmick_Breaker_Collision_Unique_Id_Middle_displayName)]
            public virtual uint Gimmick_Breaker_Collision_Unique_Id_Middle {
                get => Gimmick_Breaker_Collision_Unique_Id_Middle_raw;
                set {
                    if (Gimmick_Breaker_Collision_Unique_Id_Middle_raw == value) return;
                    Gimmick_Breaker_Collision_Unique_Id_Middle_raw = value;
                    OnPropertyChanged(nameof(Gimmick_Breaker_Collision_Unique_Id_Middle));
                }
            }

            protected uint Gimmick_Breaker_Collision_Unique_Id_Large_raw;
            public const string Gimmick_Breaker_Collision_Unique_Id_Large_displayName = "Gimmick Breaker Collision Unique Id Large";
            public const int Gimmick_Breaker_Collision_Unique_Id_Large_sortIndex = 150;
            [SortOrder(Gimmick_Breaker_Collision_Unique_Id_Large_sortIndex)]
            [DisplayName(Gimmick_Breaker_Collision_Unique_Id_Large_displayName)]
            public virtual uint Gimmick_Breaker_Collision_Unique_Id_Large {
                get => Gimmick_Breaker_Collision_Unique_Id_Large_raw;
                set {
                    if (Gimmick_Breaker_Collision_Unique_Id_Large_raw == value) return;
                    Gimmick_Breaker_Collision_Unique_Id_Large_raw = value;
                    OnPropertyChanged(nameof(Gimmick_Breaker_Collision_Unique_Id_Large));
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

            public static Claw_Chance_Params LoadData(BinaryReader reader, ulong i) {
                var data = new Claw_Chance_Params();
                data.Index = i;
                data.Gimmick_Breaker_Collision_Unique_Id_Small_raw = reader.ReadUInt32();
                data.Gimmick_Breaker_Collision_Unique_Id_Middle_raw = reader.ReadUInt32();
                data.Gimmick_Breaker_Collision_Unique_Id_Large_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Gimmick_Breaker_Collision_Unique_Id_Small_raw);
                writer.Write(Gimmick_Breaker_Collision_Unique_Id_Middle_raw);
                writer.Write(Gimmick_Breaker_Collision_Unique_Id_Large_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Gimmick Breaker Collision Unique Id Small", "Gimmick_Breaker_Collision_Unique_Id_Small"),
                    new MultiStructItemCustomView(this, "Gimmick Breaker Collision Unique Id Middle", "Gimmick_Breaker_Collision_Unique_Id_Middle"),
                    new MultiStructItemCustomView(this, "Gimmick Breaker Collision Unique Id Large", "Gimmick_Breaker_Collision_Unique_Id_Large"),
                };
            }
        }

        public override void LoadFile(string targetFile) {
            using var reader = new BinaryReader(OpenFile(targetFile, EncryptionKey), Encoding.UTF8);
            data = new LinkedList<MhwStructDataContainer>();
            var Monster_Claw_Grab_ = new MhwStructDataContainer(Monster_Claw_Grab.LoadData(reader, null), typeof(Monster_Claw_Grab));
            data.AddLast(Monster_Claw_Grab_);
            var Clagger_Params_ = new MhwStructDataContainer(Clagger_Params.LoadData(reader, Monster_Claw_Grab_.list), typeof(Clagger_Params));
            Clagger_Params_.SetCountTargetToUpdate(Monster_Claw_Grab_, -1, "Number_of_Claggers");
            data.AddLast(Clagger_Params_);
            var Claw_Chance_Params_ = new MhwStructDataContainer(Claw_Chance_Params.LoadData(reader, null), typeof(Claw_Chance_Params));
            data.AddLast(Claw_Chance_Params_);
        }
    }
}
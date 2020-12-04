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

namespace MHW_Editor.Structs.Monsters {
    public partial class MonsterEnrage {
        public override string EncryptionKey => null;

        public partial class Monster_Rage : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Monster Rage";

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
                    ChangedItems.Add(nameof(Magic_1));
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
                    ChangedItems.Add(nameof(Magic_2));
                    OnPropertyChanged(nameof(Magic_2));
                }
            }

            protected uint Monster_Id_raw;
            public const string Monster_Id_displayName = "Monster Id";
            public const int Monster_Id_sortIndex = 150;
            [SortOrder(Monster_Id_sortIndex)]
            [DisplayName(Monster_Id_displayName)]
            [DataSource(DataSourceType.Monsters)]
            [IsReadOnly]
            public virtual uint Monster_Id {
                get => Monster_Id_raw;
                set {
                    if (Monster_Id_raw == value) return;
                    Monster_Id_raw = value;
                    ChangedItems.Add(nameof(Monster_Id));
                    OnPropertyChanged(nameof(Monster_Id));
                    OnPropertyChanged(nameof(Monster_Id_button));
                }
            }

            [SortOrder(Monster_Id_sortIndex)]
            [DisplayName(Monster_Id_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Monster_Id_button => DataHelper.monsterNames[MainWindow.locale].TryGet(Monster_Id).ToStringWithId(Monster_Id);

            protected uint Magic_3_raw;
            public const string Magic_3_displayName = "Magic 3";
            public const int Magic_3_sortIndex = 200;
            [SortOrder(Magic_3_sortIndex)]
            [DisplayName(Magic_3_displayName)]
            [IsReadOnly]
            public virtual uint Magic_3 {
                get => Magic_3_raw;
                set {
                    if (Magic_3_raw == value) return;
                    Magic_3_raw = value;
                    ChangedItems.Add(nameof(Magic_3));
                    OnPropertyChanged(nameof(Magic_3));
                }
            }

            public const int lastSortIndex = 250;

            public static ObservableMhwStructCollection<Monster_Rage> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Monster_Rage>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Monster_Rage LoadData(BinaryReader reader, ulong i) {
                var data = new Monster_Rage();
                data.Index = i;
                data.Magic_1_raw = reader.ReadUInt32();
                data.Magic_2_raw = reader.ReadUInt32();
                data.Monster_Id_raw = reader.ReadUInt32();
                data.Magic_3_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Magic_1_raw);
                writer.Write(Magic_2_raw);
                writer.Write(Monster_Id_raw);
                writer.Write(Magic_3_raw);
            }
        }

        public partial class Rage_Stats : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 2;
            public const string GridName = "Rage Stats";

            protected int Build_to_Trigger_raw;
            public const string Build_to_Trigger_displayName = "Build to Trigger";
            public const int Build_to_Trigger_sortIndex = 50;
            [SortOrder(Build_to_Trigger_sortIndex)]
            [DisplayName(Build_to_Trigger_displayName)]
            public virtual int Build_to_Trigger {
                get => Build_to_Trigger_raw;
                set {
                    if (Build_to_Trigger_raw == value.Clamp((int) -1, (int) int.MaxValue)) return;
                    Build_to_Trigger_raw = value.Clamp((int) -1, (int) int.MaxValue);
                    ChangedItems.Add(nameof(Build_to_Trigger));
                    OnPropertyChanged(nameof(Build_to_Trigger));
                }
            }

            protected float Duration_raw;
            public const string Duration_displayName = "Duration";
            public const int Duration_sortIndex = 100;
            [SortOrder(Duration_sortIndex)]
            [DisplayName(Duration_displayName)]
            public virtual float Duration {
                get => Duration_raw;
                set {
                    if (Duration_raw == value) return;
                    Duration_raw = value;
                    ChangedItems.Add(nameof(Duration));
                    OnPropertyChanged(nameof(Duration));
                }
            }

            protected float Speed_Modifier_raw;
            public const string Speed_Modifier_displayName = "Speed Modifier";
            public const int Speed_Modifier_sortIndex = 150;
            [SortOrder(Speed_Modifier_sortIndex)]
            [DisplayName(Speed_Modifier_displayName)]
            public virtual float Speed_Modifier {
                get => Speed_Modifier_raw;
                set {
                    if (Speed_Modifier_raw == value) return;
                    Speed_Modifier_raw = value;
                    ChangedItems.Add(nameof(Speed_Modifier));
                    OnPropertyChanged(nameof(Speed_Modifier));
                }
            }

            protected float Damage_Modifier_raw;
            public const string Damage_Modifier_displayName = "Damage Modifier";
            public const int Damage_Modifier_sortIndex = 200;
            [SortOrder(Damage_Modifier_sortIndex)]
            [DisplayName(Damage_Modifier_displayName)]
            public virtual float Damage_Modifier {
                get => Damage_Modifier_raw;
                set {
                    if (Damage_Modifier_raw == value) return;
                    Damage_Modifier_raw = value;
                    ChangedItems.Add(nameof(Damage_Modifier));
                    OnPropertyChanged(nameof(Damage_Modifier));
                }
            }

            protected float Player_Damage_Modifier_raw;
            public const string Player_Damage_Modifier_displayName = "Player Damage Modifier";
            public const int Player_Damage_Modifier_sortIndex = 250;
            [SortOrder(Player_Damage_Modifier_sortIndex)]
            [DisplayName(Player_Damage_Modifier_displayName)]
            public virtual float Player_Damage_Modifier {
                get => Player_Damage_Modifier_raw;
                set {
                    if (Player_Damage_Modifier_raw == value) return;
                    Player_Damage_Modifier_raw = value;
                    ChangedItems.Add(nameof(Player_Damage_Modifier));
                    OnPropertyChanged(nameof(Player_Damage_Modifier));
                }
            }

            protected float Build_Multiplier_by_HP_100__raw;
            public const string Build_Multiplier_by_HP_100__displayName = "Build Multiplier by HP (100%)";
            public const int Build_Multiplier_by_HP_100__sortIndex = 300;
            [SortOrder(Build_Multiplier_by_HP_100__sortIndex)]
            [DisplayName(Build_Multiplier_by_HP_100__displayName)]
            public virtual float Build_Multiplier_by_HP_100_ {
                get => Build_Multiplier_by_HP_100__raw;
                set {
                    if (Build_Multiplier_by_HP_100__raw == value) return;
                    Build_Multiplier_by_HP_100__raw = value;
                    ChangedItems.Add(nameof(Build_Multiplier_by_HP_100_));
                    OnPropertyChanged(nameof(Build_Multiplier_by_HP_100_));
                }
            }

            protected float Build_Multiplier_by_HP_88_99__raw;
            public const string Build_Multiplier_by_HP_88_99__displayName = "Build Multiplier by HP (88%-99%)";
            public const int Build_Multiplier_by_HP_88_99__sortIndex = 350;
            [SortOrder(Build_Multiplier_by_HP_88_99__sortIndex)]
            [DisplayName(Build_Multiplier_by_HP_88_99__displayName)]
            public virtual float Build_Multiplier_by_HP_88_99_ {
                get => Build_Multiplier_by_HP_88_99__raw;
                set {
                    if (Build_Multiplier_by_HP_88_99__raw == value) return;
                    Build_Multiplier_by_HP_88_99__raw = value;
                    ChangedItems.Add(nameof(Build_Multiplier_by_HP_88_99_));
                    OnPropertyChanged(nameof(Build_Multiplier_by_HP_88_99_));
                }
            }

            protected float Build_Multiplier_by_HP_77_88__raw;
            public const string Build_Multiplier_by_HP_77_88__displayName = "Build Multiplier by HP (77%-88%)";
            public const int Build_Multiplier_by_HP_77_88__sortIndex = 400;
            [SortOrder(Build_Multiplier_by_HP_77_88__sortIndex)]
            [DisplayName(Build_Multiplier_by_HP_77_88__displayName)]
            public virtual float Build_Multiplier_by_HP_77_88_ {
                get => Build_Multiplier_by_HP_77_88__raw;
                set {
                    if (Build_Multiplier_by_HP_77_88__raw == value) return;
                    Build_Multiplier_by_HP_77_88__raw = value;
                    ChangedItems.Add(nameof(Build_Multiplier_by_HP_77_88_));
                    OnPropertyChanged(nameof(Build_Multiplier_by_HP_77_88_));
                }
            }

            protected float Build_Multiplier_by_HP_66_77__raw;
            public const string Build_Multiplier_by_HP_66_77__displayName = "Build Multiplier by HP (66%-77%)";
            public const int Build_Multiplier_by_HP_66_77__sortIndex = 450;
            [SortOrder(Build_Multiplier_by_HP_66_77__sortIndex)]
            [DisplayName(Build_Multiplier_by_HP_66_77__displayName)]
            public virtual float Build_Multiplier_by_HP_66_77_ {
                get => Build_Multiplier_by_HP_66_77__raw;
                set {
                    if (Build_Multiplier_by_HP_66_77__raw == value) return;
                    Build_Multiplier_by_HP_66_77__raw = value;
                    ChangedItems.Add(nameof(Build_Multiplier_by_HP_66_77_));
                    OnPropertyChanged(nameof(Build_Multiplier_by_HP_66_77_));
                }
            }

            protected float Build_Multiplier_by_HP_55_66__raw;
            public const string Build_Multiplier_by_HP_55_66__displayName = "Build Multiplier by HP (55%-66%)";
            public const int Build_Multiplier_by_HP_55_66__sortIndex = 500;
            [SortOrder(Build_Multiplier_by_HP_55_66__sortIndex)]
            [DisplayName(Build_Multiplier_by_HP_55_66__displayName)]
            public virtual float Build_Multiplier_by_HP_55_66_ {
                get => Build_Multiplier_by_HP_55_66__raw;
                set {
                    if (Build_Multiplier_by_HP_55_66__raw == value) return;
                    Build_Multiplier_by_HP_55_66__raw = value;
                    ChangedItems.Add(nameof(Build_Multiplier_by_HP_55_66_));
                    OnPropertyChanged(nameof(Build_Multiplier_by_HP_55_66_));
                }
            }

            protected float Build_Multiplier_by_HP_44_55__raw;
            public const string Build_Multiplier_by_HP_44_55__displayName = "Build Multiplier by HP (44%-55%)";
            public const int Build_Multiplier_by_HP_44_55__sortIndex = 550;
            [SortOrder(Build_Multiplier_by_HP_44_55__sortIndex)]
            [DisplayName(Build_Multiplier_by_HP_44_55__displayName)]
            public virtual float Build_Multiplier_by_HP_44_55_ {
                get => Build_Multiplier_by_HP_44_55__raw;
                set {
                    if (Build_Multiplier_by_HP_44_55__raw == value) return;
                    Build_Multiplier_by_HP_44_55__raw = value;
                    ChangedItems.Add(nameof(Build_Multiplier_by_HP_44_55_));
                    OnPropertyChanged(nameof(Build_Multiplier_by_HP_44_55_));
                }
            }

            protected float Build_Multiplier_by_HP_33_44__raw;
            public const string Build_Multiplier_by_HP_33_44__displayName = "Build Multiplier by HP (33%-44%)";
            public const int Build_Multiplier_by_HP_33_44__sortIndex = 600;
            [SortOrder(Build_Multiplier_by_HP_33_44__sortIndex)]
            [DisplayName(Build_Multiplier_by_HP_33_44__displayName)]
            public virtual float Build_Multiplier_by_HP_33_44_ {
                get => Build_Multiplier_by_HP_33_44__raw;
                set {
                    if (Build_Multiplier_by_HP_33_44__raw == value) return;
                    Build_Multiplier_by_HP_33_44__raw = value;
                    ChangedItems.Add(nameof(Build_Multiplier_by_HP_33_44_));
                    OnPropertyChanged(nameof(Build_Multiplier_by_HP_33_44_));
                }
            }

            protected float Build_Multiplier_by_HP_22_33__raw;
            public const string Build_Multiplier_by_HP_22_33__displayName = "Build Multiplier by HP (22%-33%)";
            public const int Build_Multiplier_by_HP_22_33__sortIndex = 650;
            [SortOrder(Build_Multiplier_by_HP_22_33__sortIndex)]
            [DisplayName(Build_Multiplier_by_HP_22_33__displayName)]
            public virtual float Build_Multiplier_by_HP_22_33_ {
                get => Build_Multiplier_by_HP_22_33__raw;
                set {
                    if (Build_Multiplier_by_HP_22_33__raw == value) return;
                    Build_Multiplier_by_HP_22_33__raw = value;
                    ChangedItems.Add(nameof(Build_Multiplier_by_HP_22_33_));
                    OnPropertyChanged(nameof(Build_Multiplier_by_HP_22_33_));
                }
            }

            protected float Build_Multiplier_by_HP_11_22__raw;
            public const string Build_Multiplier_by_HP_11_22__displayName = "Build Multiplier by HP (11%-22%)";
            public const int Build_Multiplier_by_HP_11_22__sortIndex = 700;
            [SortOrder(Build_Multiplier_by_HP_11_22__sortIndex)]
            [DisplayName(Build_Multiplier_by_HP_11_22__displayName)]
            public virtual float Build_Multiplier_by_HP_11_22_ {
                get => Build_Multiplier_by_HP_11_22__raw;
                set {
                    if (Build_Multiplier_by_HP_11_22__raw == value) return;
                    Build_Multiplier_by_HP_11_22__raw = value;
                    ChangedItems.Add(nameof(Build_Multiplier_by_HP_11_22_));
                    OnPropertyChanged(nameof(Build_Multiplier_by_HP_11_22_));
                }
            }

            protected float Build_Multiplier_by_HP_0_11__raw;
            public const string Build_Multiplier_by_HP_0_11__displayName = "Build Multiplier by HP (0%-11%)";
            public const int Build_Multiplier_by_HP_0_11__sortIndex = 750;
            [SortOrder(Build_Multiplier_by_HP_0_11__sortIndex)]
            [DisplayName(Build_Multiplier_by_HP_0_11__displayName)]
            public virtual float Build_Multiplier_by_HP_0_11_ {
                get => Build_Multiplier_by_HP_0_11__raw;
                set {
                    if (Build_Multiplier_by_HP_0_11__raw == value) return;
                    Build_Multiplier_by_HP_0_11__raw = value;
                    ChangedItems.Add(nameof(Build_Multiplier_by_HP_0_11_));
                    OnPropertyChanged(nameof(Build_Multiplier_by_HP_0_11_));
                }
            }

            protected float Out_of_Combat_Decay_Multiplier_raw;
            public const string Out_of_Combat_Decay_Multiplier_displayName = "Out of Combat Decay Multiplier";
            public const int Out_of_Combat_Decay_Multiplier_sortIndex = 800;
            [SortOrder(Out_of_Combat_Decay_Multiplier_sortIndex)]
            [DisplayName(Out_of_Combat_Decay_Multiplier_displayName)]
            public virtual float Out_of_Combat_Decay_Multiplier {
                get => Out_of_Combat_Decay_Multiplier_raw;
                set {
                    if (Out_of_Combat_Decay_Multiplier_raw == value) return;
                    Out_of_Combat_Decay_Multiplier_raw = value;
                    ChangedItems.Add(nameof(Out_of_Combat_Decay_Multiplier));
                    OnPropertyChanged(nameof(Out_of_Combat_Decay_Multiplier));
                }
            }

            public const int lastSortIndex = 850;

            public static ObservableMhwStructCollection<Rage_Stats> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Rage_Stats>();
                const ulong count = 2UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Rage_Stats LoadData(BinaryReader reader, ulong i) {
                var data = new Rage_Stats();
                data.Index = i;
                data.Build_to_Trigger_raw = reader.ReadInt32();
                data.Duration_raw = reader.ReadSingle();
                data.Speed_Modifier_raw = reader.ReadSingle();
                data.Damage_Modifier_raw = reader.ReadSingle();
                data.Player_Damage_Modifier_raw = reader.ReadSingle();
                data.Build_Multiplier_by_HP_100__raw = reader.ReadSingle();
                data.Build_Multiplier_by_HP_88_99__raw = reader.ReadSingle();
                data.Build_Multiplier_by_HP_77_88__raw = reader.ReadSingle();
                data.Build_Multiplier_by_HP_66_77__raw = reader.ReadSingle();
                data.Build_Multiplier_by_HP_55_66__raw = reader.ReadSingle();
                data.Build_Multiplier_by_HP_44_55__raw = reader.ReadSingle();
                data.Build_Multiplier_by_HP_33_44__raw = reader.ReadSingle();
                data.Build_Multiplier_by_HP_22_33__raw = reader.ReadSingle();
                data.Build_Multiplier_by_HP_11_22__raw = reader.ReadSingle();
                data.Build_Multiplier_by_HP_0_11__raw = reader.ReadSingle();
                data.Out_of_Combat_Decay_Multiplier_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Build_to_Trigger_raw);
                writer.Write(Duration_raw);
                writer.Write(Speed_Modifier_raw);
                writer.Write(Damage_Modifier_raw);
                writer.Write(Player_Damage_Modifier_raw);
                writer.Write(Build_Multiplier_by_HP_100__raw);
                writer.Write(Build_Multiplier_by_HP_88_99__raw);
                writer.Write(Build_Multiplier_by_HP_77_88__raw);
                writer.Write(Build_Multiplier_by_HP_66_77__raw);
                writer.Write(Build_Multiplier_by_HP_55_66__raw);
                writer.Write(Build_Multiplier_by_HP_44_55__raw);
                writer.Write(Build_Multiplier_by_HP_33_44__raw);
                writer.Write(Build_Multiplier_by_HP_22_33__raw);
                writer.Write(Build_Multiplier_by_HP_11_22__raw);
                writer.Write(Build_Multiplier_by_HP_0_11__raw);
                writer.Write(Out_of_Combat_Decay_Multiplier_raw);
            }
        }

        public override void LoadFile(string targetFile) {
            using var reader = new BinaryReader(OpenFile(targetFile, EncryptionKey), Encoding.UTF8);
            data = new LinkedList<MhwStructDataContainer>();
            var Monster_Rage_ = new MhwStructDataContainer<Monster_Rage>(Monster_Rage.LoadData(reader), typeof(Monster_Rage));
            data.AddLast(Monster_Rage_);
            var Rage_Stats_ = new MhwStructDataContainer<Rage_Stats>(Rage_Stats.LoadData(reader), typeof(Rage_Stats));
            data.AddLast(Rage_Stats_);
        }
    }
}
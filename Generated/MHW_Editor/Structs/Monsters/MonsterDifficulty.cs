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
    public partial class MonsterDifficulty {
        public override string EncryptionKey => null;

        public partial class Monster_Difficulty : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Monster Difficulty";

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

            public const int lastSortIndex = 150;

            public static ObservableMhwStructCollection<Monster_Difficulty> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Monster_Difficulty>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Monster_Difficulty LoadData(BinaryReader reader, ulong i) {
                var data = new Monster_Difficulty();
                data.Index = i;
                data.Magic_1_raw = reader.ReadUInt32();
                data.Magic_2_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Magic_1_raw);
                writer.Write(Magic_2_raw);
            }
        }

        public partial class Solo_Stats : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 1000;
            public const string GridName = "Solo Stats";

            protected float Monster_HP_Multiplier_raw;
            public const string Monster_HP_Multiplier_displayName = "Monster HP Multiplier";
            public const int Monster_HP_Multiplier_sortIndex = 50;
            [SortOrder(Monster_HP_Multiplier_sortIndex)]
            [DisplayName(Monster_HP_Multiplier_displayName)]
            public virtual float Monster_HP_Multiplier {
                get => Monster_HP_Multiplier_raw;
                set {
                    if (Monster_HP_Multiplier_raw == value) return;
                    Monster_HP_Multiplier_raw = value;
                    ChangedItems.Add(nameof(Monster_HP_Multiplier));
                    OnPropertyChanged(nameof(Monster_HP_Multiplier));
                }
            }

            protected float Monster_Damage_Multiplier_raw;
            public const string Monster_Damage_Multiplier_displayName = "Monster Damage Multiplier";
            public const int Monster_Damage_Multiplier_sortIndex = 100;
            [SortOrder(Monster_Damage_Multiplier_sortIndex)]
            [DisplayName(Monster_Damage_Multiplier_displayName)]
            public virtual float Monster_Damage_Multiplier {
                get => Monster_Damage_Multiplier_raw;
                set {
                    if (Monster_Damage_Multiplier_raw == value) return;
                    Monster_Damage_Multiplier_raw = value;
                    ChangedItems.Add(nameof(Monster_Damage_Multiplier));
                    OnPropertyChanged(nameof(Monster_Damage_Multiplier));
                }
            }

            protected float Player_Damage_Multiplier_raw;
            public const string Player_Damage_Multiplier_displayName = "Player Damage Multiplier";
            public const int Player_Damage_Multiplier_sortIndex = 150;
            [SortOrder(Player_Damage_Multiplier_sortIndex)]
            [DisplayName(Player_Damage_Multiplier_displayName)]
            public virtual float Player_Damage_Multiplier {
                get => Player_Damage_Multiplier_raw;
                set {
                    if (Player_Damage_Multiplier_raw == value) return;
                    Player_Damage_Multiplier_raw = value;
                    ChangedItems.Add(nameof(Player_Damage_Multiplier));
                    OnPropertyChanged(nameof(Player_Damage_Multiplier));
                }
            }

            protected float Monster_Part_HP_raw;
            public const string Monster_Part_HP_displayName = "Monster Part HP";
            public const int Monster_Part_HP_sortIndex = 200;
            [SortOrder(Monster_Part_HP_sortIndex)]
            [DisplayName(Monster_Part_HP_displayName)]
            public virtual float Monster_Part_HP {
                get => Monster_Part_HP_raw;
                set {
                    if (Monster_Part_HP_raw == value) return;
                    Monster_Part_HP_raw = value;
                    ChangedItems.Add(nameof(Monster_Part_HP));
                    OnPropertyChanged(nameof(Monster_Part_HP));
                }
            }

            protected float Monster_Status_Base_raw;
            public const string Monster_Status_Base_displayName = "Monster Status Base";
            public const int Monster_Status_Base_sortIndex = 250;
            [SortOrder(Monster_Status_Base_sortIndex)]
            [DisplayName(Monster_Status_Base_displayName)]
            public virtual float Monster_Status_Base {
                get => Monster_Status_Base_raw;
                set {
                    if (Monster_Status_Base_raw == value) return;
                    Monster_Status_Base_raw = value;
                    ChangedItems.Add(nameof(Monster_Status_Base));
                    OnPropertyChanged(nameof(Monster_Status_Base));
                }
            }

            protected float Monster_Status_Buildup_raw;
            public const string Monster_Status_Buildup_displayName = "Monster Status Buildup";
            public const int Monster_Status_Buildup_sortIndex = 300;
            [SortOrder(Monster_Status_Buildup_sortIndex)]
            [DisplayName(Monster_Status_Buildup_displayName)]
            public virtual float Monster_Status_Buildup {
                get => Monster_Status_Buildup_raw;
                set {
                    if (Monster_Status_Buildup_raw == value) return;
                    Monster_Status_Buildup_raw = value;
                    ChangedItems.Add(nameof(Monster_Status_Buildup));
                    OnPropertyChanged(nameof(Monster_Status_Buildup));
                }
            }

            protected float Monster_Stun_raw;
            public const string Monster_Stun_displayName = "Monster Stun";
            public const int Monster_Stun_sortIndex = 350;
            [SortOrder(Monster_Stun_sortIndex)]
            [DisplayName(Monster_Stun_displayName)]
            public virtual float Monster_Stun {
                get => Monster_Stun_raw;
                set {
                    if (Monster_Stun_raw == value) return;
                    Monster_Stun_raw = value;
                    ChangedItems.Add(nameof(Monster_Stun));
                    OnPropertyChanged(nameof(Monster_Stun));
                }
            }

            protected float Monster_Exhaust_raw;
            public const string Monster_Exhaust_displayName = "Monster Exhaust";
            public const int Monster_Exhaust_sortIndex = 400;
            [SortOrder(Monster_Exhaust_sortIndex)]
            [DisplayName(Monster_Exhaust_displayName)]
            public virtual float Monster_Exhaust {
                get => Monster_Exhaust_raw;
                set {
                    if (Monster_Exhaust_raw == value) return;
                    Monster_Exhaust_raw = value;
                    ChangedItems.Add(nameof(Monster_Exhaust));
                    OnPropertyChanged(nameof(Monster_Exhaust));
                }
            }

            protected float Monster_Mount_raw;
            public const string Monster_Mount_displayName = "Monster Mount";
            public const int Monster_Mount_sortIndex = 450;
            [SortOrder(Monster_Mount_sortIndex)]
            [DisplayName(Monster_Mount_displayName)]
            public virtual float Monster_Mount {
                get => Monster_Mount_raw;
                set {
                    if (Monster_Mount_raw == value) return;
                    Monster_Mount_raw = value;
                    ChangedItems.Add(nameof(Monster_Mount));
                    OnPropertyChanged(nameof(Monster_Mount));
                }
            }

            public const int lastSortIndex = 500;

            public static ObservableMhwStructCollection<Solo_Stats> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Solo_Stats>();
                var count = 1000UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Solo_Stats LoadData(BinaryReader reader, ulong i) {
                var data = new Solo_Stats();
                data.Index = i;
                data.Monster_HP_Multiplier_raw = reader.ReadSingle();
                data.Monster_Damage_Multiplier_raw = reader.ReadSingle();
                data.Player_Damage_Multiplier_raw = reader.ReadSingle();
                data.Monster_Part_HP_raw = reader.ReadSingle();
                data.Monster_Status_Base_raw = reader.ReadSingle();
                data.Monster_Status_Buildup_raw = reader.ReadSingle();
                data.Monster_Stun_raw = reader.ReadSingle();
                data.Monster_Exhaust_raw = reader.ReadSingle();
                data.Monster_Mount_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Monster_HP_Multiplier_raw);
                writer.Write(Monster_Damage_Multiplier_raw);
                writer.Write(Player_Damage_Multiplier_raw);
                writer.Write(Monster_Part_HP_raw);
                writer.Write(Monster_Status_Base_raw);
                writer.Write(Monster_Status_Buildup_raw);
                writer.Write(Monster_Stun_raw);
                writer.Write(Monster_Exhaust_raw);
                writer.Write(Monster_Mount_raw);
            }
        }

        public partial class Multi_Stats : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 1000;
            public const string GridName = "Multi Stats";

            protected float Monster_HP_Multiplier_raw;
            public const string Monster_HP_Multiplier_displayName = "Monster HP Multiplier";
            public const int Monster_HP_Multiplier_sortIndex = 50;
            [SortOrder(Monster_HP_Multiplier_sortIndex)]
            [DisplayName(Monster_HP_Multiplier_displayName)]
            public virtual float Monster_HP_Multiplier {
                get => Monster_HP_Multiplier_raw;
                set {
                    if (Monster_HP_Multiplier_raw == value) return;
                    Monster_HP_Multiplier_raw = value;
                    ChangedItems.Add(nameof(Monster_HP_Multiplier));
                    OnPropertyChanged(nameof(Monster_HP_Multiplier));
                }
            }

            protected float Monster_Damage_Multiplier_raw;
            public const string Monster_Damage_Multiplier_displayName = "Monster Damage Multiplier";
            public const int Monster_Damage_Multiplier_sortIndex = 100;
            [SortOrder(Monster_Damage_Multiplier_sortIndex)]
            [DisplayName(Monster_Damage_Multiplier_displayName)]
            public virtual float Monster_Damage_Multiplier {
                get => Monster_Damage_Multiplier_raw;
                set {
                    if (Monster_Damage_Multiplier_raw == value) return;
                    Monster_Damage_Multiplier_raw = value;
                    ChangedItems.Add(nameof(Monster_Damage_Multiplier));
                    OnPropertyChanged(nameof(Monster_Damage_Multiplier));
                }
            }

            protected float Player_Damage_Multiplier_raw;
            public const string Player_Damage_Multiplier_displayName = "Player Damage Multiplier";
            public const int Player_Damage_Multiplier_sortIndex = 150;
            [SortOrder(Player_Damage_Multiplier_sortIndex)]
            [DisplayName(Player_Damage_Multiplier_displayName)]
            public virtual float Player_Damage_Multiplier {
                get => Player_Damage_Multiplier_raw;
                set {
                    if (Player_Damage_Multiplier_raw == value) return;
                    Player_Damage_Multiplier_raw = value;
                    ChangedItems.Add(nameof(Player_Damage_Multiplier));
                    OnPropertyChanged(nameof(Player_Damage_Multiplier));
                }
            }

            protected float Monster_Part_HP_raw;
            public const string Monster_Part_HP_displayName = "Monster Part HP";
            public const int Monster_Part_HP_sortIndex = 200;
            [SortOrder(Monster_Part_HP_sortIndex)]
            [DisplayName(Monster_Part_HP_displayName)]
            public virtual float Monster_Part_HP {
                get => Monster_Part_HP_raw;
                set {
                    if (Monster_Part_HP_raw == value) return;
                    Monster_Part_HP_raw = value;
                    ChangedItems.Add(nameof(Monster_Part_HP));
                    OnPropertyChanged(nameof(Monster_Part_HP));
                }
            }

            protected float Monster_Status_Base_raw;
            public const string Monster_Status_Base_displayName = "Monster Status Base";
            public const int Monster_Status_Base_sortIndex = 250;
            [SortOrder(Monster_Status_Base_sortIndex)]
            [DisplayName(Monster_Status_Base_displayName)]
            public virtual float Monster_Status_Base {
                get => Monster_Status_Base_raw;
                set {
                    if (Monster_Status_Base_raw == value) return;
                    Monster_Status_Base_raw = value;
                    ChangedItems.Add(nameof(Monster_Status_Base));
                    OnPropertyChanged(nameof(Monster_Status_Base));
                }
            }

            protected float Monster_Status_Buildup_raw;
            public const string Monster_Status_Buildup_displayName = "Monster Status Buildup";
            public const int Monster_Status_Buildup_sortIndex = 300;
            [SortOrder(Monster_Status_Buildup_sortIndex)]
            [DisplayName(Monster_Status_Buildup_displayName)]
            public virtual float Monster_Status_Buildup {
                get => Monster_Status_Buildup_raw;
                set {
                    if (Monster_Status_Buildup_raw == value) return;
                    Monster_Status_Buildup_raw = value;
                    ChangedItems.Add(nameof(Monster_Status_Buildup));
                    OnPropertyChanged(nameof(Monster_Status_Buildup));
                }
            }

            protected float Monster_Stun_raw;
            public const string Monster_Stun_displayName = "Monster Stun";
            public const int Monster_Stun_sortIndex = 350;
            [SortOrder(Monster_Stun_sortIndex)]
            [DisplayName(Monster_Stun_displayName)]
            public virtual float Monster_Stun {
                get => Monster_Stun_raw;
                set {
                    if (Monster_Stun_raw == value) return;
                    Monster_Stun_raw = value;
                    ChangedItems.Add(nameof(Monster_Stun));
                    OnPropertyChanged(nameof(Monster_Stun));
                }
            }

            protected float Monster_Exhaust_raw;
            public const string Monster_Exhaust_displayName = "Monster Exhaust";
            public const int Monster_Exhaust_sortIndex = 400;
            [SortOrder(Monster_Exhaust_sortIndex)]
            [DisplayName(Monster_Exhaust_displayName)]
            public virtual float Monster_Exhaust {
                get => Monster_Exhaust_raw;
                set {
                    if (Monster_Exhaust_raw == value) return;
                    Monster_Exhaust_raw = value;
                    ChangedItems.Add(nameof(Monster_Exhaust));
                    OnPropertyChanged(nameof(Monster_Exhaust));
                }
            }

            protected float Monster_Mount_raw;
            public const string Monster_Mount_displayName = "Monster Mount";
            public const int Monster_Mount_sortIndex = 450;
            [SortOrder(Monster_Mount_sortIndex)]
            [DisplayName(Monster_Mount_displayName)]
            public virtual float Monster_Mount {
                get => Monster_Mount_raw;
                set {
                    if (Monster_Mount_raw == value) return;
                    Monster_Mount_raw = value;
                    ChangedItems.Add(nameof(Monster_Mount));
                    OnPropertyChanged(nameof(Monster_Mount));
                }
            }

            public const int lastSortIndex = 500;

            public static ObservableMhwStructCollection<Multi_Stats> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Multi_Stats>();
                var count = 1000UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Multi_Stats LoadData(BinaryReader reader, ulong i) {
                var data = new Multi_Stats();
                data.Index = i;
                data.Monster_HP_Multiplier_raw = reader.ReadSingle();
                data.Monster_Damage_Multiplier_raw = reader.ReadSingle();
                data.Player_Damage_Multiplier_raw = reader.ReadSingle();
                data.Monster_Part_HP_raw = reader.ReadSingle();
                data.Monster_Status_Base_raw = reader.ReadSingle();
                data.Monster_Status_Buildup_raw = reader.ReadSingle();
                data.Monster_Stun_raw = reader.ReadSingle();
                data.Monster_Exhaust_raw = reader.ReadSingle();
                data.Monster_Mount_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Monster_HP_Multiplier_raw);
                writer.Write(Monster_Damage_Multiplier_raw);
                writer.Write(Player_Damage_Multiplier_raw);
                writer.Write(Monster_Part_HP_raw);
                writer.Write(Monster_Status_Base_raw);
                writer.Write(Monster_Status_Buildup_raw);
                writer.Write(Monster_Stun_raw);
                writer.Write(Monster_Exhaust_raw);
                writer.Write(Monster_Mount_raw);
            }
        }

        public partial class Unknown : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Unknown";

            protected uint Unk_1_raw;
            public const string Unk_1_displayName = "Unk 1";
            public const int Unk_1_sortIndex = 50;
            [SortOrder(Unk_1_sortIndex)]
            [DisplayName(Unk_1_displayName)]
            [IsReadOnly]
            public virtual uint Unk_1 {
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
            [IsReadOnly]
            public virtual uint Unk_2 {
                get => Unk_2_raw;
                set {
                    if (Unk_2_raw == value) return;
                    Unk_2_raw = value;
                    ChangedItems.Add(nameof(Unk_2));
                    OnPropertyChanged(nameof(Unk_2));
                }
            }

            protected uint Unk_3_raw;
            public const string Unk_3_displayName = "Unk 3";
            public const int Unk_3_sortIndex = 150;
            [SortOrder(Unk_3_sortIndex)]
            [DisplayName(Unk_3_displayName)]
            [IsReadOnly]
            public virtual uint Unk_3 {
                get => Unk_3_raw;
                set {
                    if (Unk_3_raw == value) return;
                    Unk_3_raw = value;
                    ChangedItems.Add(nameof(Unk_3));
                    OnPropertyChanged(nameof(Unk_3));
                }
            }

            protected uint Unk_4_raw;
            public const string Unk_4_displayName = "Unk 4";
            public const int Unk_4_sortIndex = 200;
            [SortOrder(Unk_4_sortIndex)]
            [DisplayName(Unk_4_displayName)]
            [IsReadOnly]
            public virtual uint Unk_4 {
                get => Unk_4_raw;
                set {
                    if (Unk_4_raw == value) return;
                    Unk_4_raw = value;
                    ChangedItems.Add(nameof(Unk_4));
                    OnPropertyChanged(nameof(Unk_4));
                }
            }

            protected uint Unk_5_raw;
            public const string Unk_5_displayName = "Unk 5";
            public const int Unk_5_sortIndex = 250;
            [SortOrder(Unk_5_sortIndex)]
            [DisplayName(Unk_5_displayName)]
            [IsReadOnly]
            public virtual uint Unk_5 {
                get => Unk_5_raw;
                set {
                    if (Unk_5_raw == value) return;
                    Unk_5_raw = value;
                    ChangedItems.Add(nameof(Unk_5));
                    OnPropertyChanged(nameof(Unk_5));
                }
            }

            protected uint Unk_6_raw;
            public const string Unk_6_displayName = "Unk 6";
            public const int Unk_6_sortIndex = 300;
            [SortOrder(Unk_6_sortIndex)]
            [DisplayName(Unk_6_displayName)]
            [IsReadOnly]
            public virtual uint Unk_6 {
                get => Unk_6_raw;
                set {
                    if (Unk_6_raw == value) return;
                    Unk_6_raw = value;
                    ChangedItems.Add(nameof(Unk_6));
                    OnPropertyChanged(nameof(Unk_6));
                }
            }

            protected uint Unk_7_raw;
            public const string Unk_7_displayName = "Unk 7";
            public const int Unk_7_sortIndex = 350;
            [SortOrder(Unk_7_sortIndex)]
            [DisplayName(Unk_7_displayName)]
            [IsReadOnly]
            public virtual uint Unk_7 {
                get => Unk_7_raw;
                set {
                    if (Unk_7_raw == value) return;
                    Unk_7_raw = value;
                    ChangedItems.Add(nameof(Unk_7));
                    OnPropertyChanged(nameof(Unk_7));
                }
            }

            public const int lastSortIndex = 400;

            public static ObservableMhwStructCollection<Unknown> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Unknown>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Unknown LoadData(BinaryReader reader, ulong i) {
                var data = new Unknown();
                data.Index = i;
                data.Unk_1_raw = reader.ReadUInt32();
                data.Unk_2_raw = reader.ReadUInt32();
                data.Unk_3_raw = reader.ReadUInt32();
                data.Unk_4_raw = reader.ReadUInt32();
                data.Unk_5_raw = reader.ReadUInt32();
                data.Unk_6_raw = reader.ReadUInt32();
                data.Unk_7_raw = reader.ReadUInt32();
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

        public override void LoadFile(string targetFile) {
            using var reader = new BinaryReader(OpenFile(targetFile, EncryptionKey), Encoding.UTF8);
            data = new LinkedList<MhwStructDataContainer>();
            var Monster_Difficulty_ = new MhwStructDataContainer<Monster_Difficulty>(Monster_Difficulty.LoadData(reader), typeof(Monster_Difficulty));
            data.AddLast(Monster_Difficulty_);
            var Solo_Stats_ = new MhwStructDataContainer<Solo_Stats>(Solo_Stats.LoadData(reader), typeof(Solo_Stats));
            data.AddLast(Solo_Stats_);
            var Multi_Stats_ = new MhwStructDataContainer<Multi_Stats>(Multi_Stats.LoadData(reader), typeof(Multi_Stats));
            data.AddLast(Multi_Stats_);
            var Unknown_ = new MhwStructDataContainer<Unknown>(Unknown.LoadData(reader), typeof(Unknown));
            data.AddLast(Unknown_);
        }
    }
}
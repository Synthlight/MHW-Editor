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
    public partial class MonsterDamageAttributes {
        public override string EncryptionKey => "Fqkpg1xx1cMlvg3AtKOCLxFgVFBwHkCbjizBRV49hWmEe5lOAaNOTm7m";

        public partial class Monster_Damage_Attributes_1_ : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Monster Damage Attributes (1)";

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

            public static ObservableMhwStructCollection<Monster_Damage_Attributes_1_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Monster_Damage_Attributes_1_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Monster_Damage_Attributes_1_ LoadData(BinaryReader reader, ulong i) {
                var data = new Monster_Damage_Attributes_1_();
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

        public partial class Status_Buildup_Poison : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Status Buildup: Poison";

            protected uint Base_raw;
            public const string Base_displayName = "Base";
            public const int Base_sortIndex = 50;
            [SortOrder(Base_sortIndex)]
            [DisplayName(Base_displayName)]
            public virtual uint Base {
                get => Base_raw;
                set {
                    if (Base_raw == value) return;
                    Base_raw = value;
                    ChangedItems.Add(nameof(Base));
                    OnPropertyChanged(nameof(Base));
                }
            }

            protected uint Buildup_raw;
            public const string Buildup_displayName = "Buildup";
            public const int Buildup_sortIndex = 100;
            [SortOrder(Buildup_sortIndex)]
            [DisplayName(Buildup_displayName)]
            public virtual uint Buildup {
                get => Buildup_raw;
                set {
                    if (Buildup_raw == value) return;
                    Buildup_raw = value;
                    ChangedItems.Add(nameof(Buildup));
                    OnPropertyChanged(nameof(Buildup));
                }
            }

            protected uint Max_Cap_raw;
            public const string Max_Cap_displayName = "Max Cap";
            public const int Max_Cap_sortIndex = 150;
            [SortOrder(Max_Cap_sortIndex)]
            [DisplayName(Max_Cap_displayName)]
            public virtual uint Max_Cap {
                get => Max_Cap_raw;
                set {
                    if (Max_Cap_raw == value) return;
                    Max_Cap_raw = value;
                    ChangedItems.Add(nameof(Max_Cap));
                    OnPropertyChanged(nameof(Max_Cap));
                }
            }

            protected float Drain_Time_raw;
            public const string Drain_Time_displayName = "Drain Time";
            public const int Drain_Time_sortIndex = 200;
            [SortOrder(Drain_Time_sortIndex)]
            [DisplayName(Drain_Time_displayName)]
            public virtual float Drain_Time {
                get => Drain_Time_raw;
                set {
                    if (Drain_Time_raw == value) return;
                    Drain_Time_raw = value;
                    ChangedItems.Add(nameof(Drain_Time));
                    OnPropertyChanged(nameof(Drain_Time));
                }
            }

            protected uint Drain_Value_raw;
            public const string Drain_Value_displayName = "Drain Value";
            public const int Drain_Value_sortIndex = 250;
            [SortOrder(Drain_Value_sortIndex)]
            [DisplayName(Drain_Value_displayName)]
            public virtual uint Drain_Value {
                get => Drain_Value_raw;
                set {
                    if (Drain_Value_raw == value) return;
                    Drain_Value_raw = value;
                    ChangedItems.Add(nameof(Drain_Value));
                    OnPropertyChanged(nameof(Drain_Value));
                }
            }

            protected float Duration_raw;
            public const string Duration_displayName = "Duration";
            public const int Duration_sortIndex = 300;
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

            protected float Duration_Decrease_Per_Use_raw;
            public const string Duration_Decrease_Per_Use_displayName = "Duration Decrease Per Use";
            public const int Duration_Decrease_Per_Use_sortIndex = 350;
            [SortOrder(Duration_Decrease_Per_Use_sortIndex)]
            [DisplayName(Duration_Decrease_Per_Use_displayName)]
            public virtual float Duration_Decrease_Per_Use {
                get => Duration_Decrease_Per_Use_raw;
                set {
                    if (Duration_Decrease_Per_Use_raw == value) return;
                    Duration_Decrease_Per_Use_raw = value;
                    ChangedItems.Add(nameof(Duration_Decrease_Per_Use));
                    OnPropertyChanged(nameof(Duration_Decrease_Per_Use));
                }
            }

            protected float Duration_Minimum_raw;
            public const string Duration_Minimum_displayName = "Duration Minimum";
            public const int Duration_Minimum_sortIndex = 400;
            [SortOrder(Duration_Minimum_sortIndex)]
            [DisplayName(Duration_Minimum_displayName)]
            public virtual float Duration_Minimum {
                get => Duration_Minimum_raw;
                set {
                    if (Duration_Minimum_raw == value) return;
                    Duration_Minimum_raw = value;
                    ChangedItems.Add(nameof(Duration_Minimum));
                    OnPropertyChanged(nameof(Duration_Minimum));
                }
            }

            public const int lastSortIndex = 450;

            public static ObservableMhwStructCollection<Status_Buildup_Poison> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Status_Buildup_Poison>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Status_Buildup_Poison LoadData(BinaryReader reader, ulong i) {
                var data = new Status_Buildup_Poison();
                data.Index = i;
                data.Base_raw = reader.ReadUInt32();
                data.Buildup_raw = reader.ReadUInt32();
                data.Max_Cap_raw = reader.ReadUInt32();
                data.Drain_Time_raw = reader.ReadSingle();
                data.Drain_Value_raw = reader.ReadUInt32();
                data.Duration_raw = reader.ReadSingle();
                data.Duration_Decrease_Per_Use_raw = reader.ReadSingle();
                data.Duration_Minimum_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Base_raw);
                writer.Write(Buildup_raw);
                writer.Write(Max_Cap_raw);
                writer.Write(Drain_Time_raw);
                writer.Write(Drain_Value_raw);
                writer.Write(Duration_raw);
                writer.Write(Duration_Decrease_Per_Use_raw);
                writer.Write(Duration_Minimum_raw);
            }
        }

        public partial class Monster_Damage_Attributes_2_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Monster Damage Attributes (2)";

            protected uint Poison_Damage_raw;
            public const string Poison_Damage_displayName = "Poison Damage";
            public const int Poison_Damage_sortIndex = 50;
            [SortOrder(Poison_Damage_sortIndex)]
            [DisplayName(Poison_Damage_displayName)]
            public virtual uint Poison_Damage {
                get => Poison_Damage_raw;
                set {
                    if (Poison_Damage_raw == value) return;
                    Poison_Damage_raw = value;
                    ChangedItems.Add(nameof(Poison_Damage));
                    OnPropertyChanged(nameof(Poison_Damage));
                }
            }

            [DisplayName("Offset")]
            public long Poison_Damage_offset { get; private set; }

            protected float Poison_Interval_raw;
            public const string Poison_Interval_displayName = "Poison Interval";
            public const int Poison_Interval_sortIndex = 100;
            [SortOrder(Poison_Interval_sortIndex)]
            [DisplayName(Poison_Interval_displayName)]
            public virtual float Poison_Interval {
                get => Poison_Interval_raw;
                set {
                    if (Poison_Interval_raw == value) return;
                    Poison_Interval_raw = value;
                    ChangedItems.Add(nameof(Poison_Interval));
                    OnPropertyChanged(nameof(Poison_Interval));
                }
            }

            [DisplayName("Offset")]
            public long Poison_Interval_offset { get; private set; }

            public const int lastSortIndex = 150;

            public static ObservableMhwStructCollection<Monster_Damage_Attributes_2_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Monster_Damage_Attributes_2_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Monster_Damage_Attributes_2_ LoadData(BinaryReader reader, ulong i) {
                var data = new Monster_Damage_Attributes_2_();
                data.Index = i;
                data.Poison_Damage_offset = reader.BaseStream.Position;
                data.Poison_Damage_raw = reader.ReadUInt32();
                data.Poison_Interval_offset = reader.BaseStream.Position;
                data.Poison_Interval_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Poison_Damage_raw);
                writer.Write(Poison_Interval_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Poison Damage", "Poison_Damage", "Poison_Damage_offset"),
                    new MultiStructItemCustomView(this, "Poison Interval", "Poison_Interval", "Poison_Interval_offset"),
                };
            }
        }

        public partial class Status_Buildup_Sleep_Paralysis_Stun_Exhaustion : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 4;
            public const string GridName = "Status Buildup: Sleep/Paralysis/Stun/Exhaustion";

            protected uint Base_raw;
            public const string Base_displayName = "Base";
            public const int Base_sortIndex = 50;
            [SortOrder(Base_sortIndex)]
            [DisplayName(Base_displayName)]
            public virtual uint Base {
                get => Base_raw;
                set {
                    if (Base_raw == value) return;
                    Base_raw = value;
                    ChangedItems.Add(nameof(Base));
                    OnPropertyChanged(nameof(Base));
                }
            }

            protected uint Buildup_raw;
            public const string Buildup_displayName = "Buildup";
            public const int Buildup_sortIndex = 100;
            [SortOrder(Buildup_sortIndex)]
            [DisplayName(Buildup_displayName)]
            public virtual uint Buildup {
                get => Buildup_raw;
                set {
                    if (Buildup_raw == value) return;
                    Buildup_raw = value;
                    ChangedItems.Add(nameof(Buildup));
                    OnPropertyChanged(nameof(Buildup));
                }
            }

            protected uint Max_Cap_raw;
            public const string Max_Cap_displayName = "Max Cap";
            public const int Max_Cap_sortIndex = 150;
            [SortOrder(Max_Cap_sortIndex)]
            [DisplayName(Max_Cap_displayName)]
            public virtual uint Max_Cap {
                get => Max_Cap_raw;
                set {
                    if (Max_Cap_raw == value) return;
                    Max_Cap_raw = value;
                    ChangedItems.Add(nameof(Max_Cap));
                    OnPropertyChanged(nameof(Max_Cap));
                }
            }

            protected float Drain_Time_raw;
            public const string Drain_Time_displayName = "Drain Time";
            public const int Drain_Time_sortIndex = 200;
            [SortOrder(Drain_Time_sortIndex)]
            [DisplayName(Drain_Time_displayName)]
            public virtual float Drain_Time {
                get => Drain_Time_raw;
                set {
                    if (Drain_Time_raw == value) return;
                    Drain_Time_raw = value;
                    ChangedItems.Add(nameof(Drain_Time));
                    OnPropertyChanged(nameof(Drain_Time));
                }
            }

            protected uint Drain_Value_raw;
            public const string Drain_Value_displayName = "Drain Value";
            public const int Drain_Value_sortIndex = 250;
            [SortOrder(Drain_Value_sortIndex)]
            [DisplayName(Drain_Value_displayName)]
            public virtual uint Drain_Value {
                get => Drain_Value_raw;
                set {
                    if (Drain_Value_raw == value) return;
                    Drain_Value_raw = value;
                    ChangedItems.Add(nameof(Drain_Value));
                    OnPropertyChanged(nameof(Drain_Value));
                }
            }

            protected float Duration_raw;
            public const string Duration_displayName = "Duration";
            public const int Duration_sortIndex = 300;
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

            protected float Duration_Decrease_Per_Use_raw;
            public const string Duration_Decrease_Per_Use_displayName = "Duration Decrease Per Use";
            public const int Duration_Decrease_Per_Use_sortIndex = 350;
            [SortOrder(Duration_Decrease_Per_Use_sortIndex)]
            [DisplayName(Duration_Decrease_Per_Use_displayName)]
            public virtual float Duration_Decrease_Per_Use {
                get => Duration_Decrease_Per_Use_raw;
                set {
                    if (Duration_Decrease_Per_Use_raw == value) return;
                    Duration_Decrease_Per_Use_raw = value;
                    ChangedItems.Add(nameof(Duration_Decrease_Per_Use));
                    OnPropertyChanged(nameof(Duration_Decrease_Per_Use));
                }
            }

            protected float Duration_Minimum_raw;
            public const string Duration_Minimum_displayName = "Duration Minimum";
            public const int Duration_Minimum_sortIndex = 400;
            [SortOrder(Duration_Minimum_sortIndex)]
            [DisplayName(Duration_Minimum_displayName)]
            public virtual float Duration_Minimum {
                get => Duration_Minimum_raw;
                set {
                    if (Duration_Minimum_raw == value) return;
                    Duration_Minimum_raw = value;
                    ChangedItems.Add(nameof(Duration_Minimum));
                    OnPropertyChanged(nameof(Duration_Minimum));
                }
            }

            public const int lastSortIndex = 450;

            public static ObservableMhwStructCollection<Status_Buildup_Sleep_Paralysis_Stun_Exhaustion> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Status_Buildup_Sleep_Paralysis_Stun_Exhaustion>();
                const ulong count = 4UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Status_Buildup_Sleep_Paralysis_Stun_Exhaustion LoadData(BinaryReader reader, ulong i) {
                var data = new Status_Buildup_Sleep_Paralysis_Stun_Exhaustion();
                data.Index = i;
                data.Base_raw = reader.ReadUInt32();
                data.Buildup_raw = reader.ReadUInt32();
                data.Max_Cap_raw = reader.ReadUInt32();
                data.Drain_Time_raw = reader.ReadSingle();
                data.Drain_Value_raw = reader.ReadUInt32();
                data.Duration_raw = reader.ReadSingle();
                data.Duration_Decrease_Per_Use_raw = reader.ReadSingle();
                data.Duration_Minimum_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Base_raw);
                writer.Write(Buildup_raw);
                writer.Write(Max_Cap_raw);
                writer.Write(Drain_Time_raw);
                writer.Write(Drain_Value_raw);
                writer.Write(Duration_raw);
                writer.Write(Duration_Decrease_Per_Use_raw);
                writer.Write(Duration_Minimum_raw);
            }
        }

        public partial class Monster_Damage_Attributes_3_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Monster Damage Attributes (3)";

            protected uint Unk_1_raw;
            public const string Unk_1_displayName = "Unk 1";
            public const int Unk_1_sortIndex = 50;
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

            protected float Exhaustion_Damage_raw;
            public const string Exhaustion_Damage_displayName = "Exhaustion Damage";
            public const int Exhaustion_Damage_sortIndex = 100;
            [SortOrder(Exhaustion_Damage_sortIndex)]
            [DisplayName(Exhaustion_Damage_displayName)]
            public virtual float Exhaustion_Damage {
                get => Exhaustion_Damage_raw;
                set {
                    if (Exhaustion_Damage_raw == value) return;
                    Exhaustion_Damage_raw = value;
                    ChangedItems.Add(nameof(Exhaustion_Damage));
                    OnPropertyChanged(nameof(Exhaustion_Damage));
                }
            }

            [DisplayName("Offset")]
            public long Exhaustion_Damage_offset { get; private set; }

            public const int lastSortIndex = 150;

            public static ObservableMhwStructCollection<Monster_Damage_Attributes_3_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Monster_Damage_Attributes_3_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Monster_Damage_Attributes_3_ LoadData(BinaryReader reader, ulong i) {
                var data = new Monster_Damage_Attributes_3_();
                data.Index = i;
                data.Unk_1_offset = reader.BaseStream.Position;
                data.Unk_1_raw = reader.ReadUInt32();
                data.Exhaustion_Damage_offset = reader.BaseStream.Position;
                data.Exhaustion_Damage_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_1_raw);
                writer.Write(Exhaustion_Damage_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Unk 1", "Unk_1", "Unk_1_offset"),
                    new MultiStructItemCustomView(this, "Exhaustion Damage", "Exhaustion_Damage", "Exhaustion_Damage_offset"),
                };
            }
        }

        public partial class Status_Buildup_Mount_Blastblight : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 2;
            public const string GridName = "Status Buildup: Mount/Blastblight";

            protected uint Base_raw;
            public const string Base_displayName = "Base";
            public const int Base_sortIndex = 50;
            [SortOrder(Base_sortIndex)]
            [DisplayName(Base_displayName)]
            public virtual uint Base {
                get => Base_raw;
                set {
                    if (Base_raw == value) return;
                    Base_raw = value;
                    ChangedItems.Add(nameof(Base));
                    OnPropertyChanged(nameof(Base));
                }
            }

            protected uint Buildup_raw;
            public const string Buildup_displayName = "Buildup";
            public const int Buildup_sortIndex = 100;
            [SortOrder(Buildup_sortIndex)]
            [DisplayName(Buildup_displayName)]
            public virtual uint Buildup {
                get => Buildup_raw;
                set {
                    if (Buildup_raw == value) return;
                    Buildup_raw = value;
                    ChangedItems.Add(nameof(Buildup));
                    OnPropertyChanged(nameof(Buildup));
                }
            }

            protected uint Max_Cap_raw;
            public const string Max_Cap_displayName = "Max Cap";
            public const int Max_Cap_sortIndex = 150;
            [SortOrder(Max_Cap_sortIndex)]
            [DisplayName(Max_Cap_displayName)]
            public virtual uint Max_Cap {
                get => Max_Cap_raw;
                set {
                    if (Max_Cap_raw == value) return;
                    Max_Cap_raw = value;
                    ChangedItems.Add(nameof(Max_Cap));
                    OnPropertyChanged(nameof(Max_Cap));
                }
            }

            protected float Drain_Time_raw;
            public const string Drain_Time_displayName = "Drain Time";
            public const int Drain_Time_sortIndex = 200;
            [SortOrder(Drain_Time_sortIndex)]
            [DisplayName(Drain_Time_displayName)]
            public virtual float Drain_Time {
                get => Drain_Time_raw;
                set {
                    if (Drain_Time_raw == value) return;
                    Drain_Time_raw = value;
                    ChangedItems.Add(nameof(Drain_Time));
                    OnPropertyChanged(nameof(Drain_Time));
                }
            }

            protected uint Drain_Value_raw;
            public const string Drain_Value_displayName = "Drain Value";
            public const int Drain_Value_sortIndex = 250;
            [SortOrder(Drain_Value_sortIndex)]
            [DisplayName(Drain_Value_displayName)]
            public virtual uint Drain_Value {
                get => Drain_Value_raw;
                set {
                    if (Drain_Value_raw == value) return;
                    Drain_Value_raw = value;
                    ChangedItems.Add(nameof(Drain_Value));
                    OnPropertyChanged(nameof(Drain_Value));
                }
            }

            protected float Duration_raw;
            public const string Duration_displayName = "Duration";
            public const int Duration_sortIndex = 300;
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

            protected float Duration_Decrease_Per_Use_raw;
            public const string Duration_Decrease_Per_Use_displayName = "Duration Decrease Per Use";
            public const int Duration_Decrease_Per_Use_sortIndex = 350;
            [SortOrder(Duration_Decrease_Per_Use_sortIndex)]
            [DisplayName(Duration_Decrease_Per_Use_displayName)]
            public virtual float Duration_Decrease_Per_Use {
                get => Duration_Decrease_Per_Use_raw;
                set {
                    if (Duration_Decrease_Per_Use_raw == value) return;
                    Duration_Decrease_Per_Use_raw = value;
                    ChangedItems.Add(nameof(Duration_Decrease_Per_Use));
                    OnPropertyChanged(nameof(Duration_Decrease_Per_Use));
                }
            }

            protected float Duration_Minimum_raw;
            public const string Duration_Minimum_displayName = "Duration Minimum";
            public const int Duration_Minimum_sortIndex = 400;
            [SortOrder(Duration_Minimum_sortIndex)]
            [DisplayName(Duration_Minimum_displayName)]
            public virtual float Duration_Minimum {
                get => Duration_Minimum_raw;
                set {
                    if (Duration_Minimum_raw == value) return;
                    Duration_Minimum_raw = value;
                    ChangedItems.Add(nameof(Duration_Minimum));
                    OnPropertyChanged(nameof(Duration_Minimum));
                }
            }

            public const int lastSortIndex = 450;

            public static ObservableMhwStructCollection<Status_Buildup_Mount_Blastblight> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Status_Buildup_Mount_Blastblight>();
                const ulong count = 2UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Status_Buildup_Mount_Blastblight LoadData(BinaryReader reader, ulong i) {
                var data = new Status_Buildup_Mount_Blastblight();
                data.Index = i;
                data.Base_raw = reader.ReadUInt32();
                data.Buildup_raw = reader.ReadUInt32();
                data.Max_Cap_raw = reader.ReadUInt32();
                data.Drain_Time_raw = reader.ReadSingle();
                data.Drain_Value_raw = reader.ReadUInt32();
                data.Duration_raw = reader.ReadSingle();
                data.Duration_Decrease_Per_Use_raw = reader.ReadSingle();
                data.Duration_Minimum_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Base_raw);
                writer.Write(Buildup_raw);
                writer.Write(Max_Cap_raw);
                writer.Write(Drain_Time_raw);
                writer.Write(Drain_Value_raw);
                writer.Write(Duration_raw);
                writer.Write(Duration_Decrease_Per_Use_raw);
                writer.Write(Duration_Minimum_raw);
            }
        }

        public partial class Monster_Damage_Attributes_4_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Monster Damage Attributes (4)";

            protected uint Blastblight_Damage_raw;
            public const string Blastblight_Damage_displayName = "Blastblight Damage";
            public const int Blastblight_Damage_sortIndex = 50;
            [SortOrder(Blastblight_Damage_sortIndex)]
            [DisplayName(Blastblight_Damage_displayName)]
            public virtual uint Blastblight_Damage {
                get => Blastblight_Damage_raw;
                set {
                    if (Blastblight_Damage_raw == value) return;
                    Blastblight_Damage_raw = value;
                    ChangedItems.Add(nameof(Blastblight_Damage));
                    OnPropertyChanged(nameof(Blastblight_Damage));
                }
            }

            [DisplayName("Offset")]
            public long Blastblight_Damage_offset { get; private set; }

            public const int lastSortIndex = 100;

            public static ObservableMhwStructCollection<Monster_Damage_Attributes_4_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Monster_Damage_Attributes_4_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Monster_Damage_Attributes_4_ LoadData(BinaryReader reader, ulong i) {
                var data = new Monster_Damage_Attributes_4_();
                data.Index = i;
                data.Blastblight_Damage_offset = reader.BaseStream.Position;
                data.Blastblight_Damage_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Blastblight_Damage_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Blastblight Damage", "Blastblight_Damage", "Blastblight_Damage_offset"),
                };
            }
        }

        public partial class Status_Buildup_Capture : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Status Buildup: Capture";

            protected uint Base_raw;
            public const string Base_displayName = "Base";
            public const int Base_sortIndex = 50;
            [SortOrder(Base_sortIndex)]
            [DisplayName(Base_displayName)]
            public virtual uint Base {
                get => Base_raw;
                set {
                    if (Base_raw == value) return;
                    Base_raw = value;
                    ChangedItems.Add(nameof(Base));
                    OnPropertyChanged(nameof(Base));
                }
            }

            protected uint Buildup_raw;
            public const string Buildup_displayName = "Buildup";
            public const int Buildup_sortIndex = 100;
            [SortOrder(Buildup_sortIndex)]
            [DisplayName(Buildup_displayName)]
            public virtual uint Buildup {
                get => Buildup_raw;
                set {
                    if (Buildup_raw == value) return;
                    Buildup_raw = value;
                    ChangedItems.Add(nameof(Buildup));
                    OnPropertyChanged(nameof(Buildup));
                }
            }

            protected uint Max_Cap_raw;
            public const string Max_Cap_displayName = "Max Cap";
            public const int Max_Cap_sortIndex = 150;
            [SortOrder(Max_Cap_sortIndex)]
            [DisplayName(Max_Cap_displayName)]
            public virtual uint Max_Cap {
                get => Max_Cap_raw;
                set {
                    if (Max_Cap_raw == value) return;
                    Max_Cap_raw = value;
                    ChangedItems.Add(nameof(Max_Cap));
                    OnPropertyChanged(nameof(Max_Cap));
                }
            }

            protected float Drain_Time_raw;
            public const string Drain_Time_displayName = "Drain Time";
            public const int Drain_Time_sortIndex = 200;
            [SortOrder(Drain_Time_sortIndex)]
            [DisplayName(Drain_Time_displayName)]
            public virtual float Drain_Time {
                get => Drain_Time_raw;
                set {
                    if (Drain_Time_raw == value) return;
                    Drain_Time_raw = value;
                    ChangedItems.Add(nameof(Drain_Time));
                    OnPropertyChanged(nameof(Drain_Time));
                }
            }

            protected uint Drain_Value_raw;
            public const string Drain_Value_displayName = "Drain Value";
            public const int Drain_Value_sortIndex = 250;
            [SortOrder(Drain_Value_sortIndex)]
            [DisplayName(Drain_Value_displayName)]
            public virtual uint Drain_Value {
                get => Drain_Value_raw;
                set {
                    if (Drain_Value_raw == value) return;
                    Drain_Value_raw = value;
                    ChangedItems.Add(nameof(Drain_Value));
                    OnPropertyChanged(nameof(Drain_Value));
                }
            }

            protected float Duration_raw;
            public const string Duration_displayName = "Duration";
            public const int Duration_sortIndex = 300;
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

            protected float Duration_Decrease_Per_Use_raw;
            public const string Duration_Decrease_Per_Use_displayName = "Duration Decrease Per Use";
            public const int Duration_Decrease_Per_Use_sortIndex = 350;
            [SortOrder(Duration_Decrease_Per_Use_sortIndex)]
            [DisplayName(Duration_Decrease_Per_Use_displayName)]
            public virtual float Duration_Decrease_Per_Use {
                get => Duration_Decrease_Per_Use_raw;
                set {
                    if (Duration_Decrease_Per_Use_raw == value) return;
                    Duration_Decrease_Per_Use_raw = value;
                    ChangedItems.Add(nameof(Duration_Decrease_Per_Use));
                    OnPropertyChanged(nameof(Duration_Decrease_Per_Use));
                }
            }

            protected float Duration_Minimum_raw;
            public const string Duration_Minimum_displayName = "Duration Minimum";
            public const int Duration_Minimum_sortIndex = 400;
            [SortOrder(Duration_Minimum_sortIndex)]
            [DisplayName(Duration_Minimum_displayName)]
            public virtual float Duration_Minimum {
                get => Duration_Minimum_raw;
                set {
                    if (Duration_Minimum_raw == value) return;
                    Duration_Minimum_raw = value;
                    ChangedItems.Add(nameof(Duration_Minimum));
                    OnPropertyChanged(nameof(Duration_Minimum));
                }
            }

            public const int lastSortIndex = 450;

            public static ObservableMhwStructCollection<Status_Buildup_Capture> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Status_Buildup_Capture>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Status_Buildup_Capture LoadData(BinaryReader reader, ulong i) {
                var data = new Status_Buildup_Capture();
                data.Index = i;
                data.Base_raw = reader.ReadUInt32();
                data.Buildup_raw = reader.ReadUInt32();
                data.Max_Cap_raw = reader.ReadUInt32();
                data.Drain_Time_raw = reader.ReadSingle();
                data.Drain_Value_raw = reader.ReadUInt32();
                data.Duration_raw = reader.ReadSingle();
                data.Duration_Decrease_Per_Use_raw = reader.ReadSingle();
                data.Duration_Minimum_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Base_raw);
                writer.Write(Buildup_raw);
                writer.Write(Max_Cap_raw);
                writer.Write(Drain_Time_raw);
                writer.Write(Drain_Value_raw);
                writer.Write(Duration_raw);
                writer.Write(Duration_Decrease_Per_Use_raw);
                writer.Write(Duration_Minimum_raw);
            }
        }

        public partial class Monster_Damage_Attributes_5_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Monster Damage Attributes (5)";

            protected uint Capture_LR_HR_raw;
            public const string Capture_LR_HR_displayName = "Capture LR/HR";
            public const int Capture_LR_HR_sortIndex = 50;
            [SortOrder(Capture_LR_HR_sortIndex)]
            [DisplayName(Capture_LR_HR_displayName)]
            public virtual uint Capture_LR_HR {
                get => Capture_LR_HR_raw;
                set {
                    if (Capture_LR_HR_raw == value) return;
                    Capture_LR_HR_raw = value;
                    ChangedItems.Add(nameof(Capture_LR_HR));
                    OnPropertyChanged(nameof(Capture_LR_HR));
                }
            }

            [DisplayName("Offset")]
            public long Capture_LR_HR_offset { get; private set; }

            protected uint Capture_MR_raw;
            public const string Capture_MR_displayName = "Capture MR";
            public const int Capture_MR_sortIndex = 100;
            [SortOrder(Capture_MR_sortIndex)]
            [DisplayName(Capture_MR_displayName)]
            public virtual uint Capture_MR {
                get => Capture_MR_raw;
                set {
                    if (Capture_MR_raw == value) return;
                    Capture_MR_raw = value;
                    ChangedItems.Add(nameof(Capture_MR));
                    OnPropertyChanged(nameof(Capture_MR));
                }
            }

            [DisplayName("Offset")]
            public long Capture_MR_offset { get; private set; }

            public const int lastSortIndex = 150;

            public static ObservableMhwStructCollection<Monster_Damage_Attributes_5_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Monster_Damage_Attributes_5_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Monster_Damage_Attributes_5_ LoadData(BinaryReader reader, ulong i) {
                var data = new Monster_Damage_Attributes_5_();
                data.Index = i;
                data.Capture_LR_HR_offset = reader.BaseStream.Position;
                data.Capture_LR_HR_raw = reader.ReadUInt32();
                data.Capture_MR_offset = reader.BaseStream.Position;
                data.Capture_MR_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Capture_LR_HR_raw);
                writer.Write(Capture_MR_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Capture LR/HR", "Capture_LR_HR", "Capture_LR_HR_offset"),
                    new MultiStructItemCustomView(this, "Capture MR", "Capture_MR", "Capture_MR_offset"),
                };
            }
        }

        public partial class Status_Buildup_Dizziness_LR_HR : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Status Buildup: Dizziness LR/HR";

            protected uint Base_raw;
            public const string Base_displayName = "Base";
            public const int Base_sortIndex = 50;
            [SortOrder(Base_sortIndex)]
            [DisplayName(Base_displayName)]
            public virtual uint Base {
                get => Base_raw;
                set {
                    if (Base_raw == value) return;
                    Base_raw = value;
                    ChangedItems.Add(nameof(Base));
                    OnPropertyChanged(nameof(Base));
                }
            }

            protected uint Buildup_raw;
            public const string Buildup_displayName = "Buildup";
            public const int Buildup_sortIndex = 100;
            [SortOrder(Buildup_sortIndex)]
            [DisplayName(Buildup_displayName)]
            public virtual uint Buildup {
                get => Buildup_raw;
                set {
                    if (Buildup_raw == value) return;
                    Buildup_raw = value;
                    ChangedItems.Add(nameof(Buildup));
                    OnPropertyChanged(nameof(Buildup));
                }
            }

            protected uint Max_Cap_raw;
            public const string Max_Cap_displayName = "Max Cap";
            public const int Max_Cap_sortIndex = 150;
            [SortOrder(Max_Cap_sortIndex)]
            [DisplayName(Max_Cap_displayName)]
            public virtual uint Max_Cap {
                get => Max_Cap_raw;
                set {
                    if (Max_Cap_raw == value) return;
                    Max_Cap_raw = value;
                    ChangedItems.Add(nameof(Max_Cap));
                    OnPropertyChanged(nameof(Max_Cap));
                }
            }

            protected float Drain_Time_raw;
            public const string Drain_Time_displayName = "Drain Time";
            public const int Drain_Time_sortIndex = 200;
            [SortOrder(Drain_Time_sortIndex)]
            [DisplayName(Drain_Time_displayName)]
            public virtual float Drain_Time {
                get => Drain_Time_raw;
                set {
                    if (Drain_Time_raw == value) return;
                    Drain_Time_raw = value;
                    ChangedItems.Add(nameof(Drain_Time));
                    OnPropertyChanged(nameof(Drain_Time));
                }
            }

            protected uint Drain_Value_raw;
            public const string Drain_Value_displayName = "Drain Value";
            public const int Drain_Value_sortIndex = 250;
            [SortOrder(Drain_Value_sortIndex)]
            [DisplayName(Drain_Value_displayName)]
            public virtual uint Drain_Value {
                get => Drain_Value_raw;
                set {
                    if (Drain_Value_raw == value) return;
                    Drain_Value_raw = value;
                    ChangedItems.Add(nameof(Drain_Value));
                    OnPropertyChanged(nameof(Drain_Value));
                }
            }

            protected float Duration_raw;
            public const string Duration_displayName = "Duration";
            public const int Duration_sortIndex = 300;
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

            protected float Duration_Decrease_Per_Use_raw;
            public const string Duration_Decrease_Per_Use_displayName = "Duration Decrease Per Use";
            public const int Duration_Decrease_Per_Use_sortIndex = 350;
            [SortOrder(Duration_Decrease_Per_Use_sortIndex)]
            [DisplayName(Duration_Decrease_Per_Use_displayName)]
            public virtual float Duration_Decrease_Per_Use {
                get => Duration_Decrease_Per_Use_raw;
                set {
                    if (Duration_Decrease_Per_Use_raw == value) return;
                    Duration_Decrease_Per_Use_raw = value;
                    ChangedItems.Add(nameof(Duration_Decrease_Per_Use));
                    OnPropertyChanged(nameof(Duration_Decrease_Per_Use));
                }
            }

            protected float Duration_Minimum_raw;
            public const string Duration_Minimum_displayName = "Duration Minimum";
            public const int Duration_Minimum_sortIndex = 400;
            [SortOrder(Duration_Minimum_sortIndex)]
            [DisplayName(Duration_Minimum_displayName)]
            public virtual float Duration_Minimum {
                get => Duration_Minimum_raw;
                set {
                    if (Duration_Minimum_raw == value) return;
                    Duration_Minimum_raw = value;
                    ChangedItems.Add(nameof(Duration_Minimum));
                    OnPropertyChanged(nameof(Duration_Minimum));
                }
            }

            public const int lastSortIndex = 450;

            public static ObservableMhwStructCollection<Status_Buildup_Dizziness_LR_HR> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Status_Buildup_Dizziness_LR_HR>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Status_Buildup_Dizziness_LR_HR LoadData(BinaryReader reader, ulong i) {
                var data = new Status_Buildup_Dizziness_LR_HR();
                data.Index = i;
                data.Base_raw = reader.ReadUInt32();
                data.Buildup_raw = reader.ReadUInt32();
                data.Max_Cap_raw = reader.ReadUInt32();
                data.Drain_Time_raw = reader.ReadSingle();
                data.Drain_Value_raw = reader.ReadUInt32();
                data.Duration_raw = reader.ReadSingle();
                data.Duration_Decrease_Per_Use_raw = reader.ReadSingle();
                data.Duration_Minimum_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Base_raw);
                writer.Write(Buildup_raw);
                writer.Write(Max_Cap_raw);
                writer.Write(Drain_Time_raw);
                writer.Write(Drain_Value_raw);
                writer.Write(Duration_raw);
                writer.Write(Duration_Decrease_Per_Use_raw);
                writer.Write(Duration_Minimum_raw);
            }
        }

        public partial class Monster_Damage_Attributes_6_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Monster Damage Attributes (6)";

            protected uint Unk_1_raw;
            public const string Unk_1_displayName = "Unk 1";
            public const int Unk_1_sortIndex = 50;
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

            public const int lastSortIndex = 100;

            public static ObservableMhwStructCollection<Monster_Damage_Attributes_6_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Monster_Damage_Attributes_6_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Monster_Damage_Attributes_6_ LoadData(BinaryReader reader, ulong i) {
                var data = new Monster_Damage_Attributes_6_();
                data.Index = i;
                data.Unk_1_offset = reader.BaseStream.Position;
                data.Unk_1_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_1_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Unk 1", "Unk_1", "Unk_1_offset"),
                };
            }
        }

        public partial class Status_Buildup_Dizziness_MR : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Status Buildup: Dizziness MR";

            protected uint Base_raw;
            public const string Base_displayName = "Base";
            public const int Base_sortIndex = 50;
            [SortOrder(Base_sortIndex)]
            [DisplayName(Base_displayName)]
            public virtual uint Base {
                get => Base_raw;
                set {
                    if (Base_raw == value) return;
                    Base_raw = value;
                    ChangedItems.Add(nameof(Base));
                    OnPropertyChanged(nameof(Base));
                }
            }

            protected uint Buildup_raw;
            public const string Buildup_displayName = "Buildup";
            public const int Buildup_sortIndex = 100;
            [SortOrder(Buildup_sortIndex)]
            [DisplayName(Buildup_displayName)]
            public virtual uint Buildup {
                get => Buildup_raw;
                set {
                    if (Buildup_raw == value) return;
                    Buildup_raw = value;
                    ChangedItems.Add(nameof(Buildup));
                    OnPropertyChanged(nameof(Buildup));
                }
            }

            protected uint Max_Cap_raw;
            public const string Max_Cap_displayName = "Max Cap";
            public const int Max_Cap_sortIndex = 150;
            [SortOrder(Max_Cap_sortIndex)]
            [DisplayName(Max_Cap_displayName)]
            public virtual uint Max_Cap {
                get => Max_Cap_raw;
                set {
                    if (Max_Cap_raw == value) return;
                    Max_Cap_raw = value;
                    ChangedItems.Add(nameof(Max_Cap));
                    OnPropertyChanged(nameof(Max_Cap));
                }
            }

            protected float Drain_Time_raw;
            public const string Drain_Time_displayName = "Drain Time";
            public const int Drain_Time_sortIndex = 200;
            [SortOrder(Drain_Time_sortIndex)]
            [DisplayName(Drain_Time_displayName)]
            public virtual float Drain_Time {
                get => Drain_Time_raw;
                set {
                    if (Drain_Time_raw == value) return;
                    Drain_Time_raw = value;
                    ChangedItems.Add(nameof(Drain_Time));
                    OnPropertyChanged(nameof(Drain_Time));
                }
            }

            protected uint Drain_Value_raw;
            public const string Drain_Value_displayName = "Drain Value";
            public const int Drain_Value_sortIndex = 250;
            [SortOrder(Drain_Value_sortIndex)]
            [DisplayName(Drain_Value_displayName)]
            public virtual uint Drain_Value {
                get => Drain_Value_raw;
                set {
                    if (Drain_Value_raw == value) return;
                    Drain_Value_raw = value;
                    ChangedItems.Add(nameof(Drain_Value));
                    OnPropertyChanged(nameof(Drain_Value));
                }
            }

            protected float Duration_raw;
            public const string Duration_displayName = "Duration";
            public const int Duration_sortIndex = 300;
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

            protected float Duration_Decrease_Per_Use_raw;
            public const string Duration_Decrease_Per_Use_displayName = "Duration Decrease Per Use";
            public const int Duration_Decrease_Per_Use_sortIndex = 350;
            [SortOrder(Duration_Decrease_Per_Use_sortIndex)]
            [DisplayName(Duration_Decrease_Per_Use_displayName)]
            public virtual float Duration_Decrease_Per_Use {
                get => Duration_Decrease_Per_Use_raw;
                set {
                    if (Duration_Decrease_Per_Use_raw == value) return;
                    Duration_Decrease_Per_Use_raw = value;
                    ChangedItems.Add(nameof(Duration_Decrease_Per_Use));
                    OnPropertyChanged(nameof(Duration_Decrease_Per_Use));
                }
            }

            protected float Duration_Minimum_raw;
            public const string Duration_Minimum_displayName = "Duration Minimum";
            public const int Duration_Minimum_sortIndex = 400;
            [SortOrder(Duration_Minimum_sortIndex)]
            [DisplayName(Duration_Minimum_displayName)]
            public virtual float Duration_Minimum {
                get => Duration_Minimum_raw;
                set {
                    if (Duration_Minimum_raw == value) return;
                    Duration_Minimum_raw = value;
                    ChangedItems.Add(nameof(Duration_Minimum));
                    OnPropertyChanged(nameof(Duration_Minimum));
                }
            }

            public const int lastSortIndex = 450;

            public static ObservableMhwStructCollection<Status_Buildup_Dizziness_MR> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Status_Buildup_Dizziness_MR>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Status_Buildup_Dizziness_MR LoadData(BinaryReader reader, ulong i) {
                var data = new Status_Buildup_Dizziness_MR();
                data.Index = i;
                data.Base_raw = reader.ReadUInt32();
                data.Buildup_raw = reader.ReadUInt32();
                data.Max_Cap_raw = reader.ReadUInt32();
                data.Drain_Time_raw = reader.ReadSingle();
                data.Drain_Value_raw = reader.ReadUInt32();
                data.Duration_raw = reader.ReadSingle();
                data.Duration_Decrease_Per_Use_raw = reader.ReadSingle();
                data.Duration_Minimum_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Base_raw);
                writer.Write(Buildup_raw);
                writer.Write(Max_Cap_raw);
                writer.Write(Drain_Time_raw);
                writer.Write(Drain_Value_raw);
                writer.Write(Duration_raw);
                writer.Write(Duration_Decrease_Per_Use_raw);
                writer.Write(Duration_Minimum_raw);
            }
        }

        public partial class Monster_Damage_Attributes_7_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Monster Damage Attributes (7)";

            protected float Dizziness_MR_Buildup_raw;
            public const string Dizziness_MR_Buildup_displayName = "Dizziness MR Buildup";
            public const int Dizziness_MR_Buildup_sortIndex = 50;
            [SortOrder(Dizziness_MR_Buildup_sortIndex)]
            [DisplayName(Dizziness_MR_Buildup_displayName)]
            public virtual float Dizziness_MR_Buildup {
                get => Dizziness_MR_Buildup_raw;
                set {
                    if (Dizziness_MR_Buildup_raw == value) return;
                    Dizziness_MR_Buildup_raw = value;
                    ChangedItems.Add(nameof(Dizziness_MR_Buildup));
                    OnPropertyChanged(nameof(Dizziness_MR_Buildup));
                }
            }

            [DisplayName("Offset")]
            public long Dizziness_MR_Buildup_offset { get; private set; }

            protected float Dizziness_MR_Max_Cap_raw;
            public const string Dizziness_MR_Max_Cap_displayName = "Dizziness MR Max Cap";
            public const int Dizziness_MR_Max_Cap_sortIndex = 100;
            [SortOrder(Dizziness_MR_Max_Cap_sortIndex)]
            [DisplayName(Dizziness_MR_Max_Cap_displayName)]
            public virtual float Dizziness_MR_Max_Cap {
                get => Dizziness_MR_Max_Cap_raw;
                set {
                    if (Dizziness_MR_Max_Cap_raw == value) return;
                    Dizziness_MR_Max_Cap_raw = value;
                    ChangedItems.Add(nameof(Dizziness_MR_Max_Cap));
                    OnPropertyChanged(nameof(Dizziness_MR_Max_Cap));
                }
            }

            [DisplayName("Offset")]
            public long Dizziness_MR_Max_Cap_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_1));
                    OnPropertyChanged(nameof(Unk_1));
                }
            }

            [DisplayName("Offset")]
            public long Unk_1_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_2));
                    OnPropertyChanged(nameof(Unk_2));
                }
            }

            [DisplayName("Offset")]
            public long Unk_2_offset { get; private set; }

            protected float Dizziness_MR_Recharge_Timer_raw;
            public const string Dizziness_MR_Recharge_Timer_displayName = "Dizziness MR Recharge Timer";
            public const int Dizziness_MR_Recharge_Timer_sortIndex = 250;
            [SortOrder(Dizziness_MR_Recharge_Timer_sortIndex)]
            [DisplayName(Dizziness_MR_Recharge_Timer_displayName)]
            public virtual float Dizziness_MR_Recharge_Timer {
                get => Dizziness_MR_Recharge_Timer_raw;
                set {
                    if (Dizziness_MR_Recharge_Timer_raw == value) return;
                    Dizziness_MR_Recharge_Timer_raw = value;
                    ChangedItems.Add(nameof(Dizziness_MR_Recharge_Timer));
                    OnPropertyChanged(nameof(Dizziness_MR_Recharge_Timer));
                }
            }

            [DisplayName("Offset")]
            public long Dizziness_MR_Recharge_Timer_offset { get; private set; }

            protected float Unk_3_raw;
            public const string Unk_3_displayName = "Unk 3";
            public const int Unk_3_sortIndex = 300;
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

            protected float Dizziness_MR_Duration_Re_occuring_Use_raw;
            public const string Dizziness_MR_Duration_Re_occuring_Use_displayName = "Dizziness MR Duration Re-occuring Use";
            public const int Dizziness_MR_Duration_Re_occuring_Use_sortIndex = 350;
            [SortOrder(Dizziness_MR_Duration_Re_occuring_Use_sortIndex)]
            [DisplayName(Dizziness_MR_Duration_Re_occuring_Use_displayName)]
            public virtual float Dizziness_MR_Duration_Re_occuring_Use {
                get => Dizziness_MR_Duration_Re_occuring_Use_raw;
                set {
                    if (Dizziness_MR_Duration_Re_occuring_Use_raw == value) return;
                    Dizziness_MR_Duration_Re_occuring_Use_raw = value;
                    ChangedItems.Add(nameof(Dizziness_MR_Duration_Re_occuring_Use));
                    OnPropertyChanged(nameof(Dizziness_MR_Duration_Re_occuring_Use));
                }
            }

            [DisplayName("Offset")]
            public long Dizziness_MR_Duration_Re_occuring_Use_offset { get; private set; }

            protected float Dizziness_MR_Duration_Initial_Use_raw;
            public const string Dizziness_MR_Duration_Initial_Use_displayName = "Dizziness MR Duration Initial Use";
            public const int Dizziness_MR_Duration_Initial_Use_sortIndex = 400;
            [SortOrder(Dizziness_MR_Duration_Initial_Use_sortIndex)]
            [DisplayName(Dizziness_MR_Duration_Initial_Use_displayName)]
            public virtual float Dizziness_MR_Duration_Initial_Use {
                get => Dizziness_MR_Duration_Initial_Use_raw;
                set {
                    if (Dizziness_MR_Duration_Initial_Use_raw == value) return;
                    Dizziness_MR_Duration_Initial_Use_raw = value;
                    ChangedItems.Add(nameof(Dizziness_MR_Duration_Initial_Use));
                    OnPropertyChanged(nameof(Dizziness_MR_Duration_Initial_Use));
                }
            }

            [DisplayName("Offset")]
            public long Dizziness_MR_Duration_Initial_Use_offset { get; private set; }

            public const int lastSortIndex = 450;

            public static ObservableMhwStructCollection<Monster_Damage_Attributes_7_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Monster_Damage_Attributes_7_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Monster_Damage_Attributes_7_ LoadData(BinaryReader reader, ulong i) {
                var data = new Monster_Damage_Attributes_7_();
                data.Index = i;
                data.Dizziness_MR_Buildup_offset = reader.BaseStream.Position;
                data.Dizziness_MR_Buildup_raw = reader.ReadSingle();
                data.Dizziness_MR_Max_Cap_offset = reader.BaseStream.Position;
                data.Dizziness_MR_Max_Cap_raw = reader.ReadSingle();
                data.Unk_1_offset = reader.BaseStream.Position;
                data.Unk_1_raw = reader.ReadSingle();
                data.Unk_2_offset = reader.BaseStream.Position;
                data.Unk_2_raw = reader.ReadSingle();
                data.Dizziness_MR_Recharge_Timer_offset = reader.BaseStream.Position;
                data.Dizziness_MR_Recharge_Timer_raw = reader.ReadSingle();
                data.Unk_3_offset = reader.BaseStream.Position;
                data.Unk_3_raw = reader.ReadSingle();
                data.Dizziness_MR_Duration_Re_occuring_Use_offset = reader.BaseStream.Position;
                data.Dizziness_MR_Duration_Re_occuring_Use_raw = reader.ReadSingle();
                data.Dizziness_MR_Duration_Initial_Use_offset = reader.BaseStream.Position;
                data.Dizziness_MR_Duration_Initial_Use_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Dizziness_MR_Buildup_raw);
                writer.Write(Dizziness_MR_Max_Cap_raw);
                writer.Write(Unk_1_raw);
                writer.Write(Unk_2_raw);
                writer.Write(Dizziness_MR_Recharge_Timer_raw);
                writer.Write(Unk_3_raw);
                writer.Write(Dizziness_MR_Duration_Re_occuring_Use_raw);
                writer.Write(Dizziness_MR_Duration_Initial_Use_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Dizziness MR Buildup", "Dizziness_MR_Buildup", "Dizziness_MR_Buildup_offset"),
                    new MultiStructItemCustomView(this, "Dizziness MR Max Cap", "Dizziness_MR_Max_Cap", "Dizziness_MR_Max_Cap_offset"),
                    new MultiStructItemCustomView(this, "Unk 1", "Unk_1", "Unk_1_offset"),
                    new MultiStructItemCustomView(this, "Unk 2", "Unk_2", "Unk_2_offset"),
                    new MultiStructItemCustomView(this, "Dizziness MR Recharge Timer", "Dizziness_MR_Recharge_Timer", "Dizziness_MR_Recharge_Timer_offset"),
                    new MultiStructItemCustomView(this, "Unk 3", "Unk_3", "Unk_3_offset"),
                    new MultiStructItemCustomView(this, "Dizziness MR Duration Re-occuring Use", "Dizziness_MR_Duration_Re_occuring_Use", "Dizziness_MR_Duration_Re_occuring_Use_offset"),
                    new MultiStructItemCustomView(this, "Dizziness MR Duration Initial Use", "Dizziness_MR_Duration_Initial_Use", "Dizziness_MR_Duration_Initial_Use_offset"),
                };
            }
        }

        public partial class Status_Buildup_Mount_Knock_Down : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Status Buildup: Mount Knock Down";

            protected uint Base_raw;
            public const string Base_displayName = "Base";
            public const int Base_sortIndex = 50;
            [SortOrder(Base_sortIndex)]
            [DisplayName(Base_displayName)]
            public virtual uint Base {
                get => Base_raw;
                set {
                    if (Base_raw == value) return;
                    Base_raw = value;
                    ChangedItems.Add(nameof(Base));
                    OnPropertyChanged(nameof(Base));
                }
            }

            protected uint Buildup_raw;
            public const string Buildup_displayName = "Buildup";
            public const int Buildup_sortIndex = 100;
            [SortOrder(Buildup_sortIndex)]
            [DisplayName(Buildup_displayName)]
            public virtual uint Buildup {
                get => Buildup_raw;
                set {
                    if (Buildup_raw == value) return;
                    Buildup_raw = value;
                    ChangedItems.Add(nameof(Buildup));
                    OnPropertyChanged(nameof(Buildup));
                }
            }

            protected uint Max_Cap_raw;
            public const string Max_Cap_displayName = "Max Cap";
            public const int Max_Cap_sortIndex = 150;
            [SortOrder(Max_Cap_sortIndex)]
            [DisplayName(Max_Cap_displayName)]
            public virtual uint Max_Cap {
                get => Max_Cap_raw;
                set {
                    if (Max_Cap_raw == value) return;
                    Max_Cap_raw = value;
                    ChangedItems.Add(nameof(Max_Cap));
                    OnPropertyChanged(nameof(Max_Cap));
                }
            }

            protected float Drain_Time_raw;
            public const string Drain_Time_displayName = "Drain Time";
            public const int Drain_Time_sortIndex = 200;
            [SortOrder(Drain_Time_sortIndex)]
            [DisplayName(Drain_Time_displayName)]
            public virtual float Drain_Time {
                get => Drain_Time_raw;
                set {
                    if (Drain_Time_raw == value) return;
                    Drain_Time_raw = value;
                    ChangedItems.Add(nameof(Drain_Time));
                    OnPropertyChanged(nameof(Drain_Time));
                }
            }

            protected uint Drain_Value_raw;
            public const string Drain_Value_displayName = "Drain Value";
            public const int Drain_Value_sortIndex = 250;
            [SortOrder(Drain_Value_sortIndex)]
            [DisplayName(Drain_Value_displayName)]
            public virtual uint Drain_Value {
                get => Drain_Value_raw;
                set {
                    if (Drain_Value_raw == value) return;
                    Drain_Value_raw = value;
                    ChangedItems.Add(nameof(Drain_Value));
                    OnPropertyChanged(nameof(Drain_Value));
                }
            }

            protected float Duration_raw;
            public const string Duration_displayName = "Duration";
            public const int Duration_sortIndex = 300;
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

            protected float Duration_Decrease_Per_Use_raw;
            public const string Duration_Decrease_Per_Use_displayName = "Duration Decrease Per Use";
            public const int Duration_Decrease_Per_Use_sortIndex = 350;
            [SortOrder(Duration_Decrease_Per_Use_sortIndex)]
            [DisplayName(Duration_Decrease_Per_Use_displayName)]
            public virtual float Duration_Decrease_Per_Use {
                get => Duration_Decrease_Per_Use_raw;
                set {
                    if (Duration_Decrease_Per_Use_raw == value) return;
                    Duration_Decrease_Per_Use_raw = value;
                    ChangedItems.Add(nameof(Duration_Decrease_Per_Use));
                    OnPropertyChanged(nameof(Duration_Decrease_Per_Use));
                }
            }

            protected float Duration_Minimum_raw;
            public const string Duration_Minimum_displayName = "Duration Minimum";
            public const int Duration_Minimum_sortIndex = 400;
            [SortOrder(Duration_Minimum_sortIndex)]
            [DisplayName(Duration_Minimum_displayName)]
            public virtual float Duration_Minimum {
                get => Duration_Minimum_raw;
                set {
                    if (Duration_Minimum_raw == value) return;
                    Duration_Minimum_raw = value;
                    ChangedItems.Add(nameof(Duration_Minimum));
                    OnPropertyChanged(nameof(Duration_Minimum));
                }
            }

            public const int lastSortIndex = 450;

            public static ObservableMhwStructCollection<Status_Buildup_Mount_Knock_Down> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Status_Buildup_Mount_Knock_Down>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Status_Buildup_Mount_Knock_Down LoadData(BinaryReader reader, ulong i) {
                var data = new Status_Buildup_Mount_Knock_Down();
                data.Index = i;
                data.Base_raw = reader.ReadUInt32();
                data.Buildup_raw = reader.ReadUInt32();
                data.Max_Cap_raw = reader.ReadUInt32();
                data.Drain_Time_raw = reader.ReadSingle();
                data.Drain_Value_raw = reader.ReadUInt32();
                data.Duration_raw = reader.ReadSingle();
                data.Duration_Decrease_Per_Use_raw = reader.ReadSingle();
                data.Duration_Minimum_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Base_raw);
                writer.Write(Buildup_raw);
                writer.Write(Max_Cap_raw);
                writer.Write(Drain_Time_raw);
                writer.Write(Drain_Value_raw);
                writer.Write(Duration_raw);
                writer.Write(Duration_Decrease_Per_Use_raw);
                writer.Write(Duration_Minimum_raw);
            }
        }

        public partial class Monster_Damage_Attributes_8_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Monster Damage Attributes (8)";

            protected uint Mount_Knock_Down_Damage_raw;
            public const string Mount_Knock_Down_Damage_displayName = "Mount Knock Down Damage";
            public const int Mount_Knock_Down_Damage_sortIndex = 50;
            [SortOrder(Mount_Knock_Down_Damage_sortIndex)]
            [DisplayName(Mount_Knock_Down_Damage_displayName)]
            public virtual uint Mount_Knock_Down_Damage {
                get => Mount_Knock_Down_Damage_raw;
                set {
                    if (Mount_Knock_Down_Damage_raw == value) return;
                    Mount_Knock_Down_Damage_raw = value;
                    ChangedItems.Add(nameof(Mount_Knock_Down_Damage));
                    OnPropertyChanged(nameof(Mount_Knock_Down_Damage));
                }
            }

            [DisplayName("Offset")]
            public long Mount_Knock_Down_Damage_offset { get; private set; }

            public const int lastSortIndex = 100;

            public static ObservableMhwStructCollection<Monster_Damage_Attributes_8_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Monster_Damage_Attributes_8_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Monster_Damage_Attributes_8_ LoadData(BinaryReader reader, ulong i) {
                var data = new Monster_Damage_Attributes_8_();
                data.Index = i;
                data.Mount_Knock_Down_Damage_offset = reader.BaseStream.Position;
                data.Mount_Knock_Down_Damage_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Mount_Knock_Down_Damage_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Mount Knock Down Damage", "Mount_Knock_Down_Damage", "Mount_Knock_Down_Damage_offset"),
                };
            }
        }

        public partial class Status_Buildup_Dung : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Status Buildup: Dung";

            protected uint Base_raw;
            public const string Base_displayName = "Base";
            public const int Base_sortIndex = 50;
            [SortOrder(Base_sortIndex)]
            [DisplayName(Base_displayName)]
            public virtual uint Base {
                get => Base_raw;
                set {
                    if (Base_raw == value) return;
                    Base_raw = value;
                    ChangedItems.Add(nameof(Base));
                    OnPropertyChanged(nameof(Base));
                }
            }

            protected uint Buildup_raw;
            public const string Buildup_displayName = "Buildup";
            public const int Buildup_sortIndex = 100;
            [SortOrder(Buildup_sortIndex)]
            [DisplayName(Buildup_displayName)]
            public virtual uint Buildup {
                get => Buildup_raw;
                set {
                    if (Buildup_raw == value) return;
                    Buildup_raw = value;
                    ChangedItems.Add(nameof(Buildup));
                    OnPropertyChanged(nameof(Buildup));
                }
            }

            protected uint Max_Cap_raw;
            public const string Max_Cap_displayName = "Max Cap";
            public const int Max_Cap_sortIndex = 150;
            [SortOrder(Max_Cap_sortIndex)]
            [DisplayName(Max_Cap_displayName)]
            public virtual uint Max_Cap {
                get => Max_Cap_raw;
                set {
                    if (Max_Cap_raw == value) return;
                    Max_Cap_raw = value;
                    ChangedItems.Add(nameof(Max_Cap));
                    OnPropertyChanged(nameof(Max_Cap));
                }
            }

            protected float Drain_Time_raw;
            public const string Drain_Time_displayName = "Drain Time";
            public const int Drain_Time_sortIndex = 200;
            [SortOrder(Drain_Time_sortIndex)]
            [DisplayName(Drain_Time_displayName)]
            public virtual float Drain_Time {
                get => Drain_Time_raw;
                set {
                    if (Drain_Time_raw == value) return;
                    Drain_Time_raw = value;
                    ChangedItems.Add(nameof(Drain_Time));
                    OnPropertyChanged(nameof(Drain_Time));
                }
            }

            protected uint Drain_Value_raw;
            public const string Drain_Value_displayName = "Drain Value";
            public const int Drain_Value_sortIndex = 250;
            [SortOrder(Drain_Value_sortIndex)]
            [DisplayName(Drain_Value_displayName)]
            public virtual uint Drain_Value {
                get => Drain_Value_raw;
                set {
                    if (Drain_Value_raw == value) return;
                    Drain_Value_raw = value;
                    ChangedItems.Add(nameof(Drain_Value));
                    OnPropertyChanged(nameof(Drain_Value));
                }
            }

            protected float Duration_raw;
            public const string Duration_displayName = "Duration";
            public const int Duration_sortIndex = 300;
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

            protected float Duration_Decrease_Per_Use_raw;
            public const string Duration_Decrease_Per_Use_displayName = "Duration Decrease Per Use";
            public const int Duration_Decrease_Per_Use_sortIndex = 350;
            [SortOrder(Duration_Decrease_Per_Use_sortIndex)]
            [DisplayName(Duration_Decrease_Per_Use_displayName)]
            public virtual float Duration_Decrease_Per_Use {
                get => Duration_Decrease_Per_Use_raw;
                set {
                    if (Duration_Decrease_Per_Use_raw == value) return;
                    Duration_Decrease_Per_Use_raw = value;
                    ChangedItems.Add(nameof(Duration_Decrease_Per_Use));
                    OnPropertyChanged(nameof(Duration_Decrease_Per_Use));
                }
            }

            protected float Duration_Minimum_raw;
            public const string Duration_Minimum_displayName = "Duration Minimum";
            public const int Duration_Minimum_sortIndex = 400;
            [SortOrder(Duration_Minimum_sortIndex)]
            [DisplayName(Duration_Minimum_displayName)]
            public virtual float Duration_Minimum {
                get => Duration_Minimum_raw;
                set {
                    if (Duration_Minimum_raw == value) return;
                    Duration_Minimum_raw = value;
                    ChangedItems.Add(nameof(Duration_Minimum));
                    OnPropertyChanged(nameof(Duration_Minimum));
                }
            }

            public const int lastSortIndex = 450;

            public static ObservableMhwStructCollection<Status_Buildup_Dung> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Status_Buildup_Dung>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Status_Buildup_Dung LoadData(BinaryReader reader, ulong i) {
                var data = new Status_Buildup_Dung();
                data.Index = i;
                data.Base_raw = reader.ReadUInt32();
                data.Buildup_raw = reader.ReadUInt32();
                data.Max_Cap_raw = reader.ReadUInt32();
                data.Drain_Time_raw = reader.ReadSingle();
                data.Drain_Value_raw = reader.ReadUInt32();
                data.Duration_raw = reader.ReadSingle();
                data.Duration_Decrease_Per_Use_raw = reader.ReadSingle();
                data.Duration_Minimum_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Base_raw);
                writer.Write(Buildup_raw);
                writer.Write(Max_Cap_raw);
                writer.Write(Drain_Time_raw);
                writer.Write(Drain_Value_raw);
                writer.Write(Duration_raw);
                writer.Write(Duration_Decrease_Per_Use_raw);
                writer.Write(Duration_Minimum_raw);
            }
        }

        public partial class Monster_Damage_Attributes_9_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Monster Damage Attributes (9)";

            protected uint Unk_1_raw;
            public const string Unk_1_displayName = "Unk 1";
            public const int Unk_1_sortIndex = 50;
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

            [DisplayName("Offset")]
            public long Unk_2_offset { get; private set; }

            public const int lastSortIndex = 150;

            public static ObservableMhwStructCollection<Monster_Damage_Attributes_9_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Monster_Damage_Attributes_9_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Monster_Damage_Attributes_9_ LoadData(BinaryReader reader, ulong i) {
                var data = new Monster_Damage_Attributes_9_();
                data.Index = i;
                data.Unk_1_offset = reader.BaseStream.Position;
                data.Unk_1_raw = reader.ReadUInt32();
                data.Unk_2_offset = reader.BaseStream.Position;
                data.Unk_2_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_1_raw);
                writer.Write(Unk_2_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Unk 1", "Unk_1", "Unk_1_offset"),
                    new MultiStructItemCustomView(this, "Unk 2", "Unk_2", "Unk_2_offset"),
                };
            }
        }

        public partial class Status_Buildup_Shock_Trap_Pitfall_Trap_Ivy_Trap_Unk : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 4;
            public const string GridName = "Status Buildup: Shock Trap/Pitfall Trap/Ivy Trap/Unk";

            protected uint Base_raw;
            public const string Base_displayName = "Base";
            public const int Base_sortIndex = 50;
            [SortOrder(Base_sortIndex)]
            [DisplayName(Base_displayName)]
            public virtual uint Base {
                get => Base_raw;
                set {
                    if (Base_raw == value) return;
                    Base_raw = value;
                    ChangedItems.Add(nameof(Base));
                    OnPropertyChanged(nameof(Base));
                }
            }

            protected uint Buildup_raw;
            public const string Buildup_displayName = "Buildup";
            public const int Buildup_sortIndex = 100;
            [SortOrder(Buildup_sortIndex)]
            [DisplayName(Buildup_displayName)]
            public virtual uint Buildup {
                get => Buildup_raw;
                set {
                    if (Buildup_raw == value) return;
                    Buildup_raw = value;
                    ChangedItems.Add(nameof(Buildup));
                    OnPropertyChanged(nameof(Buildup));
                }
            }

            protected uint Max_Cap_raw;
            public const string Max_Cap_displayName = "Max Cap";
            public const int Max_Cap_sortIndex = 150;
            [SortOrder(Max_Cap_sortIndex)]
            [DisplayName(Max_Cap_displayName)]
            public virtual uint Max_Cap {
                get => Max_Cap_raw;
                set {
                    if (Max_Cap_raw == value) return;
                    Max_Cap_raw = value;
                    ChangedItems.Add(nameof(Max_Cap));
                    OnPropertyChanged(nameof(Max_Cap));
                }
            }

            protected float Drain_Time_raw;
            public const string Drain_Time_displayName = "Drain Time";
            public const int Drain_Time_sortIndex = 200;
            [SortOrder(Drain_Time_sortIndex)]
            [DisplayName(Drain_Time_displayName)]
            public virtual float Drain_Time {
                get => Drain_Time_raw;
                set {
                    if (Drain_Time_raw == value) return;
                    Drain_Time_raw = value;
                    ChangedItems.Add(nameof(Drain_Time));
                    OnPropertyChanged(nameof(Drain_Time));
                }
            }

            protected uint Drain_Value_raw;
            public const string Drain_Value_displayName = "Drain Value";
            public const int Drain_Value_sortIndex = 250;
            [SortOrder(Drain_Value_sortIndex)]
            [DisplayName(Drain_Value_displayName)]
            public virtual uint Drain_Value {
                get => Drain_Value_raw;
                set {
                    if (Drain_Value_raw == value) return;
                    Drain_Value_raw = value;
                    ChangedItems.Add(nameof(Drain_Value));
                    OnPropertyChanged(nameof(Drain_Value));
                }
            }

            protected float Duration_raw;
            public const string Duration_displayName = "Duration";
            public const int Duration_sortIndex = 300;
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

            protected float Duration_Decrease_Per_Use_raw;
            public const string Duration_Decrease_Per_Use_displayName = "Duration Decrease Per Use";
            public const int Duration_Decrease_Per_Use_sortIndex = 350;
            [SortOrder(Duration_Decrease_Per_Use_sortIndex)]
            [DisplayName(Duration_Decrease_Per_Use_displayName)]
            public virtual float Duration_Decrease_Per_Use {
                get => Duration_Decrease_Per_Use_raw;
                set {
                    if (Duration_Decrease_Per_Use_raw == value) return;
                    Duration_Decrease_Per_Use_raw = value;
                    ChangedItems.Add(nameof(Duration_Decrease_Per_Use));
                    OnPropertyChanged(nameof(Duration_Decrease_Per_Use));
                }
            }

            protected float Duration_Minimum_raw;
            public const string Duration_Minimum_displayName = "Duration Minimum";
            public const int Duration_Minimum_sortIndex = 400;
            [SortOrder(Duration_Minimum_sortIndex)]
            [DisplayName(Duration_Minimum_displayName)]
            public virtual float Duration_Minimum {
                get => Duration_Minimum_raw;
                set {
                    if (Duration_Minimum_raw == value) return;
                    Duration_Minimum_raw = value;
                    ChangedItems.Add(nameof(Duration_Minimum));
                    OnPropertyChanged(nameof(Duration_Minimum));
                }
            }

            public const int lastSortIndex = 450;

            public static ObservableMhwStructCollection<Status_Buildup_Shock_Trap_Pitfall_Trap_Ivy_Trap_Unk> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Status_Buildup_Shock_Trap_Pitfall_Trap_Ivy_Trap_Unk>();
                const ulong count = 4UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Status_Buildup_Shock_Trap_Pitfall_Trap_Ivy_Trap_Unk LoadData(BinaryReader reader, ulong i) {
                var data = new Status_Buildup_Shock_Trap_Pitfall_Trap_Ivy_Trap_Unk();
                data.Index = i;
                data.Base_raw = reader.ReadUInt32();
                data.Buildup_raw = reader.ReadUInt32();
                data.Max_Cap_raw = reader.ReadUInt32();
                data.Drain_Time_raw = reader.ReadSingle();
                data.Drain_Value_raw = reader.ReadUInt32();
                data.Duration_raw = reader.ReadSingle();
                data.Duration_Decrease_Per_Use_raw = reader.ReadSingle();
                data.Duration_Minimum_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Base_raw);
                writer.Write(Buildup_raw);
                writer.Write(Max_Cap_raw);
                writer.Write(Drain_Time_raw);
                writer.Write(Drain_Value_raw);
                writer.Write(Duration_raw);
                writer.Write(Duration_Decrease_Per_Use_raw);
                writer.Write(Duration_Minimum_raw);
            }
        }

        public partial class Monster_Damage_Attributes_10_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Monster Damage Attributes (10)";

            protected uint Unk_1_raw;
            public const string Unk_1_displayName = "Unk 1";
            public const int Unk_1_sortIndex = 50;
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

            [DisplayName("Offset")]
            public long Unk_2_offset { get; private set; }

            public const int lastSortIndex = 150;

            public static ObservableMhwStructCollection<Monster_Damage_Attributes_10_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Monster_Damage_Attributes_10_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Monster_Damage_Attributes_10_ LoadData(BinaryReader reader, ulong i) {
                var data = new Monster_Damage_Attributes_10_();
                data.Index = i;
                data.Unk_1_offset = reader.BaseStream.Position;
                data.Unk_1_raw = reader.ReadUInt32();
                data.Unk_2_offset = reader.BaseStream.Position;
                data.Unk_2_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_1_raw);
                writer.Write(Unk_2_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Unk 1", "Unk_1", "Unk_1_offset"),
                    new MultiStructItemCustomView(this, "Unk 2", "Unk_2", "Unk_2_offset"),
                };
            }
        }

        public partial class Status_Buildup_Dragonseal : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Status Buildup: Dragonseal";

            protected uint Base_raw;
            public const string Base_displayName = "Base";
            public const int Base_sortIndex = 50;
            [SortOrder(Base_sortIndex)]
            [DisplayName(Base_displayName)]
            public virtual uint Base {
                get => Base_raw;
                set {
                    if (Base_raw == value) return;
                    Base_raw = value;
                    ChangedItems.Add(nameof(Base));
                    OnPropertyChanged(nameof(Base));
                }
            }

            protected uint Buildup_raw;
            public const string Buildup_displayName = "Buildup";
            public const int Buildup_sortIndex = 100;
            [SortOrder(Buildup_sortIndex)]
            [DisplayName(Buildup_displayName)]
            public virtual uint Buildup {
                get => Buildup_raw;
                set {
                    if (Buildup_raw == value) return;
                    Buildup_raw = value;
                    ChangedItems.Add(nameof(Buildup));
                    OnPropertyChanged(nameof(Buildup));
                }
            }

            protected uint Max_Cap_raw;
            public const string Max_Cap_displayName = "Max Cap";
            public const int Max_Cap_sortIndex = 150;
            [SortOrder(Max_Cap_sortIndex)]
            [DisplayName(Max_Cap_displayName)]
            public virtual uint Max_Cap {
                get => Max_Cap_raw;
                set {
                    if (Max_Cap_raw == value) return;
                    Max_Cap_raw = value;
                    ChangedItems.Add(nameof(Max_Cap));
                    OnPropertyChanged(nameof(Max_Cap));
                }
            }

            protected float Drain_Time_raw;
            public const string Drain_Time_displayName = "Drain Time";
            public const int Drain_Time_sortIndex = 200;
            [SortOrder(Drain_Time_sortIndex)]
            [DisplayName(Drain_Time_displayName)]
            public virtual float Drain_Time {
                get => Drain_Time_raw;
                set {
                    if (Drain_Time_raw == value) return;
                    Drain_Time_raw = value;
                    ChangedItems.Add(nameof(Drain_Time));
                    OnPropertyChanged(nameof(Drain_Time));
                }
            }

            protected uint Drain_Value_raw;
            public const string Drain_Value_displayName = "Drain Value";
            public const int Drain_Value_sortIndex = 250;
            [SortOrder(Drain_Value_sortIndex)]
            [DisplayName(Drain_Value_displayName)]
            public virtual uint Drain_Value {
                get => Drain_Value_raw;
                set {
                    if (Drain_Value_raw == value) return;
                    Drain_Value_raw = value;
                    ChangedItems.Add(nameof(Drain_Value));
                    OnPropertyChanged(nameof(Drain_Value));
                }
            }

            protected float Duration_raw;
            public const string Duration_displayName = "Duration";
            public const int Duration_sortIndex = 300;
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

            protected float Duration_Decrease_Per_Use_raw;
            public const string Duration_Decrease_Per_Use_displayName = "Duration Decrease Per Use";
            public const int Duration_Decrease_Per_Use_sortIndex = 350;
            [SortOrder(Duration_Decrease_Per_Use_sortIndex)]
            [DisplayName(Duration_Decrease_Per_Use_displayName)]
            public virtual float Duration_Decrease_Per_Use {
                get => Duration_Decrease_Per_Use_raw;
                set {
                    if (Duration_Decrease_Per_Use_raw == value) return;
                    Duration_Decrease_Per_Use_raw = value;
                    ChangedItems.Add(nameof(Duration_Decrease_Per_Use));
                    OnPropertyChanged(nameof(Duration_Decrease_Per_Use));
                }
            }

            protected float Duration_Minimum_raw;
            public const string Duration_Minimum_displayName = "Duration Minimum";
            public const int Duration_Minimum_sortIndex = 400;
            [SortOrder(Duration_Minimum_sortIndex)]
            [DisplayName(Duration_Minimum_displayName)]
            public virtual float Duration_Minimum {
                get => Duration_Minimum_raw;
                set {
                    if (Duration_Minimum_raw == value) return;
                    Duration_Minimum_raw = value;
                    ChangedItems.Add(nameof(Duration_Minimum));
                    OnPropertyChanged(nameof(Duration_Minimum));
                }
            }

            public const int lastSortIndex = 450;

            public static ObservableMhwStructCollection<Status_Buildup_Dragonseal> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Status_Buildup_Dragonseal>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Status_Buildup_Dragonseal LoadData(BinaryReader reader, ulong i) {
                var data = new Status_Buildup_Dragonseal();
                data.Index = i;
                data.Base_raw = reader.ReadUInt32();
                data.Buildup_raw = reader.ReadUInt32();
                data.Max_Cap_raw = reader.ReadUInt32();
                data.Drain_Time_raw = reader.ReadSingle();
                data.Drain_Value_raw = reader.ReadUInt32();
                data.Duration_raw = reader.ReadSingle();
                data.Duration_Decrease_Per_Use_raw = reader.ReadSingle();
                data.Duration_Minimum_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Base_raw);
                writer.Write(Buildup_raw);
                writer.Write(Max_Cap_raw);
                writer.Write(Drain_Time_raw);
                writer.Write(Drain_Value_raw);
                writer.Write(Duration_raw);
                writer.Write(Duration_Decrease_Per_Use_raw);
                writer.Write(Duration_Minimum_raw);
            }
        }

        public partial class Monster_Damage_Attributes_11_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Monster Damage Attributes (11)";

            protected uint Dragonseal_Aura_raw;
            public const string Dragonseal_Aura_displayName = "Dragonseal Aura";
            public const int Dragonseal_Aura_sortIndex = 50;
            [SortOrder(Dragonseal_Aura_sortIndex)]
            [DisplayName(Dragonseal_Aura_displayName)]
            public virtual uint Dragonseal_Aura {
                get => Dragonseal_Aura_raw;
                set {
                    if (Dragonseal_Aura_raw == value) return;
                    Dragonseal_Aura_raw = value;
                    ChangedItems.Add(nameof(Dragonseal_Aura));
                    OnPropertyChanged(nameof(Dragonseal_Aura));
                }
            }

            [DisplayName("Offset")]
            public long Dragonseal_Aura_offset { get; private set; }

            public const int lastSortIndex = 100;

            public static ObservableMhwStructCollection<Monster_Damage_Attributes_11_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Monster_Damage_Attributes_11_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Monster_Damage_Attributes_11_ LoadData(BinaryReader reader, ulong i) {
                var data = new Monster_Damage_Attributes_11_();
                data.Index = i;
                data.Dragonseal_Aura_offset = reader.BaseStream.Position;
                data.Dragonseal_Aura_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Dragonseal_Aura_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Dragonseal Aura", "Dragonseal_Aura", "Dragonseal_Aura_offset"),
                };
            }
        }

        public partial class Status_Buildup_Unk : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 2;
            public const string GridName = "Status Buildup: Unk";

            protected uint Base_raw;
            public const string Base_displayName = "Base";
            public const int Base_sortIndex = 50;
            [SortOrder(Base_sortIndex)]
            [DisplayName(Base_displayName)]
            public virtual uint Base {
                get => Base_raw;
                set {
                    if (Base_raw == value) return;
                    Base_raw = value;
                    ChangedItems.Add(nameof(Base));
                    OnPropertyChanged(nameof(Base));
                }
            }

            protected uint Buildup_raw;
            public const string Buildup_displayName = "Buildup";
            public const int Buildup_sortIndex = 100;
            [SortOrder(Buildup_sortIndex)]
            [DisplayName(Buildup_displayName)]
            public virtual uint Buildup {
                get => Buildup_raw;
                set {
                    if (Buildup_raw == value) return;
                    Buildup_raw = value;
                    ChangedItems.Add(nameof(Buildup));
                    OnPropertyChanged(nameof(Buildup));
                }
            }

            protected uint Max_Cap_raw;
            public const string Max_Cap_displayName = "Max Cap";
            public const int Max_Cap_sortIndex = 150;
            [SortOrder(Max_Cap_sortIndex)]
            [DisplayName(Max_Cap_displayName)]
            public virtual uint Max_Cap {
                get => Max_Cap_raw;
                set {
                    if (Max_Cap_raw == value) return;
                    Max_Cap_raw = value;
                    ChangedItems.Add(nameof(Max_Cap));
                    OnPropertyChanged(nameof(Max_Cap));
                }
            }

            protected float Drain_Time_raw;
            public const string Drain_Time_displayName = "Drain Time";
            public const int Drain_Time_sortIndex = 200;
            [SortOrder(Drain_Time_sortIndex)]
            [DisplayName(Drain_Time_displayName)]
            public virtual float Drain_Time {
                get => Drain_Time_raw;
                set {
                    if (Drain_Time_raw == value) return;
                    Drain_Time_raw = value;
                    ChangedItems.Add(nameof(Drain_Time));
                    OnPropertyChanged(nameof(Drain_Time));
                }
            }

            protected uint Drain_Value_raw;
            public const string Drain_Value_displayName = "Drain Value";
            public const int Drain_Value_sortIndex = 250;
            [SortOrder(Drain_Value_sortIndex)]
            [DisplayName(Drain_Value_displayName)]
            public virtual uint Drain_Value {
                get => Drain_Value_raw;
                set {
                    if (Drain_Value_raw == value) return;
                    Drain_Value_raw = value;
                    ChangedItems.Add(nameof(Drain_Value));
                    OnPropertyChanged(nameof(Drain_Value));
                }
            }

            protected float Duration_raw;
            public const string Duration_displayName = "Duration";
            public const int Duration_sortIndex = 300;
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

            protected float Duration_Decrease_Per_Use_raw;
            public const string Duration_Decrease_Per_Use_displayName = "Duration Decrease Per Use";
            public const int Duration_Decrease_Per_Use_sortIndex = 350;
            [SortOrder(Duration_Decrease_Per_Use_sortIndex)]
            [DisplayName(Duration_Decrease_Per_Use_displayName)]
            public virtual float Duration_Decrease_Per_Use {
                get => Duration_Decrease_Per_Use_raw;
                set {
                    if (Duration_Decrease_Per_Use_raw == value) return;
                    Duration_Decrease_Per_Use_raw = value;
                    ChangedItems.Add(nameof(Duration_Decrease_Per_Use));
                    OnPropertyChanged(nameof(Duration_Decrease_Per_Use));
                }
            }

            protected float Duration_Minimum_raw;
            public const string Duration_Minimum_displayName = "Duration Minimum";
            public const int Duration_Minimum_sortIndex = 400;
            [SortOrder(Duration_Minimum_sortIndex)]
            [DisplayName(Duration_Minimum_displayName)]
            public virtual float Duration_Minimum {
                get => Duration_Minimum_raw;
                set {
                    if (Duration_Minimum_raw == value) return;
                    Duration_Minimum_raw = value;
                    ChangedItems.Add(nameof(Duration_Minimum));
                    OnPropertyChanged(nameof(Duration_Minimum));
                }
            }

            public const int lastSortIndex = 450;

            public static ObservableMhwStructCollection<Status_Buildup_Unk> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Status_Buildup_Unk>();
                const ulong count = 2UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Status_Buildup_Unk LoadData(BinaryReader reader, ulong i) {
                var data = new Status_Buildup_Unk();
                data.Index = i;
                data.Base_raw = reader.ReadUInt32();
                data.Buildup_raw = reader.ReadUInt32();
                data.Max_Cap_raw = reader.ReadUInt32();
                data.Drain_Time_raw = reader.ReadSingle();
                data.Drain_Value_raw = reader.ReadUInt32();
                data.Duration_raw = reader.ReadSingle();
                data.Duration_Decrease_Per_Use_raw = reader.ReadSingle();
                data.Duration_Minimum_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Base_raw);
                writer.Write(Buildup_raw);
                writer.Write(Max_Cap_raw);
                writer.Write(Drain_Time_raw);
                writer.Write(Drain_Value_raw);
                writer.Write(Duration_raw);
                writer.Write(Duration_Decrease_Per_Use_raw);
                writer.Write(Duration_Minimum_raw);
            }
        }

        public partial class Unk_Array : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 6;
            public const string GridName = "Unk Array";

            protected int Unk_1_raw;
            public const string Unk_1_displayName = "Unk 1";
            public const int Unk_1_sortIndex = 50;
            [SortOrder(Unk_1_sortIndex)]
            [DisplayName(Unk_1_displayName)]
            public virtual int Unk_1 {
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

            protected int Unk_3_raw;
            public const string Unk_3_displayName = "Unk 3";
            public const int Unk_3_sortIndex = 150;
            [SortOrder(Unk_3_sortIndex)]
            [DisplayName(Unk_3_displayName)]
            public virtual int Unk_3 {
                get => Unk_3_raw;
                set {
                    if (Unk_3_raw == value) return;
                    Unk_3_raw = value;
                    ChangedItems.Add(nameof(Unk_3));
                    OnPropertyChanged(nameof(Unk_3));
                }
            }

            public const int lastSortIndex = 200;

            public static ObservableMhwStructCollection<Unk_Array> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Unk_Array>();
                const ulong count = 6UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Unk_Array LoadData(BinaryReader reader, ulong i) {
                var data = new Unk_Array();
                data.Index = i;
                data.Unk_1_raw = reader.ReadInt32();
                data.Unk_2_raw = reader.ReadInt32();
                data.Unk_3_raw = reader.ReadInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_1_raw);
                writer.Write(Unk_2_raw);
                writer.Write(Unk_3_raw);
            }
        }

        public partial class Status_Buildup_Concussion : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Status Buildup: Concussion";

            protected uint Base_raw;
            public const string Base_displayName = "Base";
            public const int Base_sortIndex = 50;
            [SortOrder(Base_sortIndex)]
            [DisplayName(Base_displayName)]
            public virtual uint Base {
                get => Base_raw;
                set {
                    if (Base_raw == value) return;
                    Base_raw = value;
                    ChangedItems.Add(nameof(Base));
                    OnPropertyChanged(nameof(Base));
                }
            }

            protected uint Buildup_raw;
            public const string Buildup_displayName = "Buildup";
            public const int Buildup_sortIndex = 100;
            [SortOrder(Buildup_sortIndex)]
            [DisplayName(Buildup_displayName)]
            public virtual uint Buildup {
                get => Buildup_raw;
                set {
                    if (Buildup_raw == value) return;
                    Buildup_raw = value;
                    ChangedItems.Add(nameof(Buildup));
                    OnPropertyChanged(nameof(Buildup));
                }
            }

            protected uint Max_Cap_raw;
            public const string Max_Cap_displayName = "Max Cap";
            public const int Max_Cap_sortIndex = 150;
            [SortOrder(Max_Cap_sortIndex)]
            [DisplayName(Max_Cap_displayName)]
            public virtual uint Max_Cap {
                get => Max_Cap_raw;
                set {
                    if (Max_Cap_raw == value) return;
                    Max_Cap_raw = value;
                    ChangedItems.Add(nameof(Max_Cap));
                    OnPropertyChanged(nameof(Max_Cap));
                }
            }

            protected float Drain_Time_raw;
            public const string Drain_Time_displayName = "Drain Time";
            public const int Drain_Time_sortIndex = 200;
            [SortOrder(Drain_Time_sortIndex)]
            [DisplayName(Drain_Time_displayName)]
            public virtual float Drain_Time {
                get => Drain_Time_raw;
                set {
                    if (Drain_Time_raw == value) return;
                    Drain_Time_raw = value;
                    ChangedItems.Add(nameof(Drain_Time));
                    OnPropertyChanged(nameof(Drain_Time));
                }
            }

            protected uint Drain_Value_raw;
            public const string Drain_Value_displayName = "Drain Value";
            public const int Drain_Value_sortIndex = 250;
            [SortOrder(Drain_Value_sortIndex)]
            [DisplayName(Drain_Value_displayName)]
            public virtual uint Drain_Value {
                get => Drain_Value_raw;
                set {
                    if (Drain_Value_raw == value) return;
                    Drain_Value_raw = value;
                    ChangedItems.Add(nameof(Drain_Value));
                    OnPropertyChanged(nameof(Drain_Value));
                }
            }

            protected float Duration_raw;
            public const string Duration_displayName = "Duration";
            public const int Duration_sortIndex = 300;
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

            protected float Duration_Decrease_Per_Use_raw;
            public const string Duration_Decrease_Per_Use_displayName = "Duration Decrease Per Use";
            public const int Duration_Decrease_Per_Use_sortIndex = 350;
            [SortOrder(Duration_Decrease_Per_Use_sortIndex)]
            [DisplayName(Duration_Decrease_Per_Use_displayName)]
            public virtual float Duration_Decrease_Per_Use {
                get => Duration_Decrease_Per_Use_raw;
                set {
                    if (Duration_Decrease_Per_Use_raw == value) return;
                    Duration_Decrease_Per_Use_raw = value;
                    ChangedItems.Add(nameof(Duration_Decrease_Per_Use));
                    OnPropertyChanged(nameof(Duration_Decrease_Per_Use));
                }
            }

            protected float Duration_Minimum_raw;
            public const string Duration_Minimum_displayName = "Duration Minimum";
            public const int Duration_Minimum_sortIndex = 400;
            [SortOrder(Duration_Minimum_sortIndex)]
            [DisplayName(Duration_Minimum_displayName)]
            public virtual float Duration_Minimum {
                get => Duration_Minimum_raw;
                set {
                    if (Duration_Minimum_raw == value) return;
                    Duration_Minimum_raw = value;
                    ChangedItems.Add(nameof(Duration_Minimum));
                    OnPropertyChanged(nameof(Duration_Minimum));
                }
            }

            public const int lastSortIndex = 450;

            public static ObservableMhwStructCollection<Status_Buildup_Concussion> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Status_Buildup_Concussion>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Status_Buildup_Concussion LoadData(BinaryReader reader, ulong i) {
                var data = new Status_Buildup_Concussion();
                data.Index = i;
                data.Base_raw = reader.ReadUInt32();
                data.Buildup_raw = reader.ReadUInt32();
                data.Max_Cap_raw = reader.ReadUInt32();
                data.Drain_Time_raw = reader.ReadSingle();
                data.Drain_Value_raw = reader.ReadUInt32();
                data.Duration_raw = reader.ReadSingle();
                data.Duration_Decrease_Per_Use_raw = reader.ReadSingle();
                data.Duration_Minimum_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Base_raw);
                writer.Write(Buildup_raw);
                writer.Write(Max_Cap_raw);
                writer.Write(Drain_Time_raw);
                writer.Write(Drain_Value_raw);
                writer.Write(Duration_raw);
                writer.Write(Duration_Decrease_Per_Use_raw);
                writer.Write(Duration_Minimum_raw);
            }
        }

        public partial class Rage_Build_Up : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 2;
            public const string GridName = "Rage Build Up";

            protected float Claw_Flinch_Shot_raw;
            public const string Claw_Flinch_Shot_displayName = "Claw Flinch Shot";
            public const int Claw_Flinch_Shot_sortIndex = 50;
            [SortOrder(Claw_Flinch_Shot_sortIndex)]
            [DisplayName(Claw_Flinch_Shot_displayName)]
            public virtual float Claw_Flinch_Shot {
                get => Claw_Flinch_Shot_raw;
                set {
                    if (Claw_Flinch_Shot_raw == value) return;
                    Claw_Flinch_Shot_raw = value;
                    ChangedItems.Add(nameof(Claw_Flinch_Shot));
                    OnPropertyChanged(nameof(Claw_Flinch_Shot));
                }
            }

            protected float Claw_Flinch_Shot_No_Wall__raw;
            public const string Claw_Flinch_Shot_No_Wall__displayName = "Claw Flinch Shot (No Wall)";
            public const int Claw_Flinch_Shot_No_Wall__sortIndex = 100;
            [SortOrder(Claw_Flinch_Shot_No_Wall__sortIndex)]
            [DisplayName(Claw_Flinch_Shot_No_Wall__displayName)]
            public virtual float Claw_Flinch_Shot_No_Wall_ {
                get => Claw_Flinch_Shot_No_Wall__raw;
                set {
                    if (Claw_Flinch_Shot_No_Wall__raw == value) return;
                    Claw_Flinch_Shot_No_Wall__raw = value;
                    ChangedItems.Add(nameof(Claw_Flinch_Shot_No_Wall_));
                    OnPropertyChanged(nameof(Claw_Flinch_Shot_No_Wall_));
                }
            }

            protected float Claw_Attack_raw;
            public const string Claw_Attack_displayName = "Claw Attack";
            public const int Claw_Attack_sortIndex = 150;
            [SortOrder(Claw_Attack_sortIndex)]
            [DisplayName(Claw_Attack_displayName)]
            public virtual float Claw_Attack {
                get => Claw_Attack_raw;
                set {
                    if (Claw_Attack_raw == value) return;
                    Claw_Attack_raw = value;
                    ChangedItems.Add(nameof(Claw_Attack));
                    OnPropertyChanged(nameof(Claw_Attack));
                }
            }

            protected float Claw_Flinch_Shot_Wall__raw;
            public const string Claw_Flinch_Shot_Wall__displayName = "Claw Flinch Shot (Wall)";
            public const int Claw_Flinch_Shot_Wall__sortIndex = 200;
            [SortOrder(Claw_Flinch_Shot_Wall__sortIndex)]
            [DisplayName(Claw_Flinch_Shot_Wall__displayName)]
            public virtual float Claw_Flinch_Shot_Wall_ {
                get => Claw_Flinch_Shot_Wall__raw;
                set {
                    if (Claw_Flinch_Shot_Wall__raw == value) return;
                    Claw_Flinch_Shot_Wall__raw = value;
                    ChangedItems.Add(nameof(Claw_Flinch_Shot_Wall_));
                    OnPropertyChanged(nameof(Claw_Flinch_Shot_Wall_));
                }
            }

            protected float Claw_Flinch_Shot_Ledge__raw;
            public const string Claw_Flinch_Shot_Ledge__displayName = "Claw Flinch Shot (Ledge)";
            public const int Claw_Flinch_Shot_Ledge__sortIndex = 250;
            [SortOrder(Claw_Flinch_Shot_Ledge__sortIndex)]
            [DisplayName(Claw_Flinch_Shot_Ledge__displayName)]
            public virtual float Claw_Flinch_Shot_Ledge_ {
                get => Claw_Flinch_Shot_Ledge__raw;
                set {
                    if (Claw_Flinch_Shot_Ledge__raw == value) return;
                    Claw_Flinch_Shot_Ledge__raw = value;
                    ChangedItems.Add(nameof(Claw_Flinch_Shot_Ledge_));
                    OnPropertyChanged(nameof(Claw_Flinch_Shot_Ledge_));
                }
            }

            public const int lastSortIndex = 300;

            public static ObservableMhwStructCollection<Rage_Build_Up> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Rage_Build_Up>();
                const ulong count = 2UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Rage_Build_Up LoadData(BinaryReader reader, ulong i) {
                var data = new Rage_Build_Up();
                data.Index = i;
                data.Claw_Flinch_Shot_raw = reader.ReadSingle();
                data.Claw_Flinch_Shot_No_Wall__raw = reader.ReadSingle();
                data.Claw_Attack_raw = reader.ReadSingle();
                data.Claw_Flinch_Shot_Wall__raw = reader.ReadSingle();
                data.Claw_Flinch_Shot_Ledge__raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Claw_Flinch_Shot_raw);
                writer.Write(Claw_Flinch_Shot_No_Wall__raw);
                writer.Write(Claw_Attack_raw);
                writer.Write(Claw_Flinch_Shot_Wall__raw);
                writer.Write(Claw_Flinch_Shot_Ledge__raw);
            }
        }

        public partial class Status_Buildup_Clagger : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Status Buildup: Clagger";

            protected uint Base_raw;
            public const string Base_displayName = "Base";
            public const int Base_sortIndex = 50;
            [SortOrder(Base_sortIndex)]
            [DisplayName(Base_displayName)]
            public virtual uint Base {
                get => Base_raw;
                set {
                    if (Base_raw == value) return;
                    Base_raw = value;
                    ChangedItems.Add(nameof(Base));
                    OnPropertyChanged(nameof(Base));
                }
            }

            protected uint Buildup_raw;
            public const string Buildup_displayName = "Buildup";
            public const int Buildup_sortIndex = 100;
            [SortOrder(Buildup_sortIndex)]
            [DisplayName(Buildup_displayName)]
            public virtual uint Buildup {
                get => Buildup_raw;
                set {
                    if (Buildup_raw == value) return;
                    Buildup_raw = value;
                    ChangedItems.Add(nameof(Buildup));
                    OnPropertyChanged(nameof(Buildup));
                }
            }

            protected uint Max_Cap_raw;
            public const string Max_Cap_displayName = "Max Cap";
            public const int Max_Cap_sortIndex = 150;
            [SortOrder(Max_Cap_sortIndex)]
            [DisplayName(Max_Cap_displayName)]
            public virtual uint Max_Cap {
                get => Max_Cap_raw;
                set {
                    if (Max_Cap_raw == value) return;
                    Max_Cap_raw = value;
                    ChangedItems.Add(nameof(Max_Cap));
                    OnPropertyChanged(nameof(Max_Cap));
                }
            }

            protected float Drain_Time_raw;
            public const string Drain_Time_displayName = "Drain Time";
            public const int Drain_Time_sortIndex = 200;
            [SortOrder(Drain_Time_sortIndex)]
            [DisplayName(Drain_Time_displayName)]
            public virtual float Drain_Time {
                get => Drain_Time_raw;
                set {
                    if (Drain_Time_raw == value) return;
                    Drain_Time_raw = value;
                    ChangedItems.Add(nameof(Drain_Time));
                    OnPropertyChanged(nameof(Drain_Time));
                }
            }

            protected uint Drain_Value_raw;
            public const string Drain_Value_displayName = "Drain Value";
            public const int Drain_Value_sortIndex = 250;
            [SortOrder(Drain_Value_sortIndex)]
            [DisplayName(Drain_Value_displayName)]
            public virtual uint Drain_Value {
                get => Drain_Value_raw;
                set {
                    if (Drain_Value_raw == value) return;
                    Drain_Value_raw = value;
                    ChangedItems.Add(nameof(Drain_Value));
                    OnPropertyChanged(nameof(Drain_Value));
                }
            }

            protected float Duration_raw;
            public const string Duration_displayName = "Duration";
            public const int Duration_sortIndex = 300;
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

            protected float Duration_Decrease_Per_Use_raw;
            public const string Duration_Decrease_Per_Use_displayName = "Duration Decrease Per Use";
            public const int Duration_Decrease_Per_Use_sortIndex = 350;
            [SortOrder(Duration_Decrease_Per_Use_sortIndex)]
            [DisplayName(Duration_Decrease_Per_Use_displayName)]
            public virtual float Duration_Decrease_Per_Use {
                get => Duration_Decrease_Per_Use_raw;
                set {
                    if (Duration_Decrease_Per_Use_raw == value) return;
                    Duration_Decrease_Per_Use_raw = value;
                    ChangedItems.Add(nameof(Duration_Decrease_Per_Use));
                    OnPropertyChanged(nameof(Duration_Decrease_Per_Use));
                }
            }

            protected float Duration_Minimum_raw;
            public const string Duration_Minimum_displayName = "Duration Minimum";
            public const int Duration_Minimum_sortIndex = 400;
            [SortOrder(Duration_Minimum_sortIndex)]
            [DisplayName(Duration_Minimum_displayName)]
            public virtual float Duration_Minimum {
                get => Duration_Minimum_raw;
                set {
                    if (Duration_Minimum_raw == value) return;
                    Duration_Minimum_raw = value;
                    ChangedItems.Add(nameof(Duration_Minimum));
                    OnPropertyChanged(nameof(Duration_Minimum));
                }
            }

            public const int lastSortIndex = 450;

            public static ObservableMhwStructCollection<Status_Buildup_Clagger> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Status_Buildup_Clagger>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Status_Buildup_Clagger LoadData(BinaryReader reader, ulong i) {
                var data = new Status_Buildup_Clagger();
                data.Index = i;
                data.Base_raw = reader.ReadUInt32();
                data.Buildup_raw = reader.ReadUInt32();
                data.Max_Cap_raw = reader.ReadUInt32();
                data.Drain_Time_raw = reader.ReadSingle();
                data.Drain_Value_raw = reader.ReadUInt32();
                data.Duration_raw = reader.ReadSingle();
                data.Duration_Decrease_Per_Use_raw = reader.ReadSingle();
                data.Duration_Minimum_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Base_raw);
                writer.Write(Buildup_raw);
                writer.Write(Max_Cap_raw);
                writer.Write(Drain_Time_raw);
                writer.Write(Drain_Value_raw);
                writer.Write(Duration_raw);
                writer.Write(Duration_Decrease_Per_Use_raw);
                writer.Write(Duration_Minimum_raw);
            }
        }

        public override void LoadFile(string targetFile) {
            using var reader = new BinaryReader(OpenFile(targetFile, EncryptionKey), Encoding.UTF8);
            data = new LinkedList<MhwStructDataContainer>();
            var Monster_Damage_Attributes_1__ = new MhwStructDataContainer<Monster_Damage_Attributes_1_>(Monster_Damage_Attributes_1_.LoadData(reader), typeof(Monster_Damage_Attributes_1_));
            data.AddLast(Monster_Damage_Attributes_1__);
            var Status_Buildup_Poison_ = new MhwStructDataContainer<Status_Buildup_Poison>(Status_Buildup_Poison.LoadData(reader), typeof(Status_Buildup_Poison));
            data.AddLast(Status_Buildup_Poison_);
            var Monster_Damage_Attributes_2__ = new MhwStructDataContainer<Monster_Damage_Attributes_2_>(Monster_Damage_Attributes_2_.LoadData(reader), typeof(Monster_Damage_Attributes_2_));
            data.AddLast(Monster_Damage_Attributes_2__);
            var Status_Buildup_Sleep_Paralysis_Stun_Exhaustion_ = new MhwStructDataContainer<Status_Buildup_Sleep_Paralysis_Stun_Exhaustion>(Status_Buildup_Sleep_Paralysis_Stun_Exhaustion.LoadData(reader), typeof(Status_Buildup_Sleep_Paralysis_Stun_Exhaustion));
            data.AddLast(Status_Buildup_Sleep_Paralysis_Stun_Exhaustion_);
            var Monster_Damage_Attributes_3__ = new MhwStructDataContainer<Monster_Damage_Attributes_3_>(Monster_Damage_Attributes_3_.LoadData(reader), typeof(Monster_Damage_Attributes_3_));
            data.AddLast(Monster_Damage_Attributes_3__);
            var Status_Buildup_Mount_Blastblight_ = new MhwStructDataContainer<Status_Buildup_Mount_Blastblight>(Status_Buildup_Mount_Blastblight.LoadData(reader), typeof(Status_Buildup_Mount_Blastblight));
            data.AddLast(Status_Buildup_Mount_Blastblight_);
            var Monster_Damage_Attributes_4__ = new MhwStructDataContainer<Monster_Damage_Attributes_4_>(Monster_Damage_Attributes_4_.LoadData(reader), typeof(Monster_Damage_Attributes_4_));
            data.AddLast(Monster_Damage_Attributes_4__);
            var Status_Buildup_Capture_ = new MhwStructDataContainer<Status_Buildup_Capture>(Status_Buildup_Capture.LoadData(reader), typeof(Status_Buildup_Capture));
            data.AddLast(Status_Buildup_Capture_);
            var Monster_Damage_Attributes_5__ = new MhwStructDataContainer<Monster_Damage_Attributes_5_>(Monster_Damage_Attributes_5_.LoadData(reader), typeof(Monster_Damage_Attributes_5_));
            data.AddLast(Monster_Damage_Attributes_5__);
            var Status_Buildup_Dizziness_LR_HR_ = new MhwStructDataContainer<Status_Buildup_Dizziness_LR_HR>(Status_Buildup_Dizziness_LR_HR.LoadData(reader), typeof(Status_Buildup_Dizziness_LR_HR));
            data.AddLast(Status_Buildup_Dizziness_LR_HR_);
            var Monster_Damage_Attributes_6__ = new MhwStructDataContainer<Monster_Damage_Attributes_6_>(Monster_Damage_Attributes_6_.LoadData(reader), typeof(Monster_Damage_Attributes_6_));
            data.AddLast(Monster_Damage_Attributes_6__);
            var Status_Buildup_Dizziness_MR_ = new MhwStructDataContainer<Status_Buildup_Dizziness_MR>(Status_Buildup_Dizziness_MR.LoadData(reader), typeof(Status_Buildup_Dizziness_MR));
            data.AddLast(Status_Buildup_Dizziness_MR_);
            var Monster_Damage_Attributes_7__ = new MhwStructDataContainer<Monster_Damage_Attributes_7_>(Monster_Damage_Attributes_7_.LoadData(reader), typeof(Monster_Damage_Attributes_7_));
            data.AddLast(Monster_Damage_Attributes_7__);
            var Status_Buildup_Mount_Knock_Down_ = new MhwStructDataContainer<Status_Buildup_Mount_Knock_Down>(Status_Buildup_Mount_Knock_Down.LoadData(reader), typeof(Status_Buildup_Mount_Knock_Down));
            data.AddLast(Status_Buildup_Mount_Knock_Down_);
            var Monster_Damage_Attributes_8__ = new MhwStructDataContainer<Monster_Damage_Attributes_8_>(Monster_Damage_Attributes_8_.LoadData(reader), typeof(Monster_Damage_Attributes_8_));
            data.AddLast(Monster_Damage_Attributes_8__);
            var Status_Buildup_Dung_ = new MhwStructDataContainer<Status_Buildup_Dung>(Status_Buildup_Dung.LoadData(reader), typeof(Status_Buildup_Dung));
            data.AddLast(Status_Buildup_Dung_);
            var Monster_Damage_Attributes_9__ = new MhwStructDataContainer<Monster_Damage_Attributes_9_>(Monster_Damage_Attributes_9_.LoadData(reader), typeof(Monster_Damage_Attributes_9_));
            data.AddLast(Monster_Damage_Attributes_9__);
            var Status_Buildup_Shock_Trap_Pitfall_Trap_Ivy_Trap_Unk_ = new MhwStructDataContainer<Status_Buildup_Shock_Trap_Pitfall_Trap_Ivy_Trap_Unk>(Status_Buildup_Shock_Trap_Pitfall_Trap_Ivy_Trap_Unk.LoadData(reader), typeof(Status_Buildup_Shock_Trap_Pitfall_Trap_Ivy_Trap_Unk));
            data.AddLast(Status_Buildup_Shock_Trap_Pitfall_Trap_Ivy_Trap_Unk_);
            var Monster_Damage_Attributes_10__ = new MhwStructDataContainer<Monster_Damage_Attributes_10_>(Monster_Damage_Attributes_10_.LoadData(reader), typeof(Monster_Damage_Attributes_10_));
            data.AddLast(Monster_Damage_Attributes_10__);
            var Status_Buildup_Dragonseal_ = new MhwStructDataContainer<Status_Buildup_Dragonseal>(Status_Buildup_Dragonseal.LoadData(reader), typeof(Status_Buildup_Dragonseal));
            data.AddLast(Status_Buildup_Dragonseal_);
            var Monster_Damage_Attributes_11__ = new MhwStructDataContainer<Monster_Damage_Attributes_11_>(Monster_Damage_Attributes_11_.LoadData(reader), typeof(Monster_Damage_Attributes_11_));
            data.AddLast(Monster_Damage_Attributes_11__);
            var Status_Buildup_Unk_ = new MhwStructDataContainer<Status_Buildup_Unk>(Status_Buildup_Unk.LoadData(reader), typeof(Status_Buildup_Unk));
            data.AddLast(Status_Buildup_Unk_);
            var Unk_Array_ = new MhwStructDataContainer<Unk_Array>(Unk_Array.LoadData(reader), typeof(Unk_Array));
            data.AddLast(Unk_Array_);
            var Status_Buildup_Concussion_ = new MhwStructDataContainer<Status_Buildup_Concussion>(Status_Buildup_Concussion.LoadData(reader), typeof(Status_Buildup_Concussion));
            data.AddLast(Status_Buildup_Concussion_);
            var Rage_Build_Up_ = new MhwStructDataContainer<Rage_Build_Up>(Rage_Build_Up.LoadData(reader), typeof(Rage_Build_Up));
            data.AddLast(Rage_Build_Up_);
            var Status_Buildup_Clagger_ = new MhwStructDataContainer<Status_Buildup_Clagger>(Status_Buildup_Clagger.LoadData(reader), typeof(Status_Buildup_Clagger));
            data.AddLast(Status_Buildup_Clagger_);
        }
    }
}
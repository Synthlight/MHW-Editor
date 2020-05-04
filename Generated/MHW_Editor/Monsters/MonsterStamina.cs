using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Monsters {
    public partial class MonsterStamina {
        public override string EncryptionKey => null;

        public partial class Monster_Stamina_1_ : MhwStructItem {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Monster Stamina (1)";

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
                    OnPropertyChanged(nameof(Magic_3));
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

            public static Monster_Stamina_1_ LoadData(BinaryReader reader, ulong i) {
                var data = new Monster_Stamina_1_();
                data.Index = i;
                data.Magic_1_raw = reader.ReadUInt32();
                data.Magic_2_raw = reader.ReadUInt32();
                data.Monster_Id_raw = reader.ReadUInt32();
                data.Magic_3_raw = reader.ReadUInt32();
                return data;
            }

            public override void WriteData(BinaryWriter writer) {
                writer.Write(Magic_1_raw);
                writer.Write(Magic_2_raw);
                writer.Write(Monster_Id_raw);
                writer.Write(Magic_3_raw);
            }
        }

        public partial class Fatigue_LR_ : MhwStructItem {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Fatigue (LR)";

            protected float Duration_raw;
            public const string Duration_displayName = "Duration";
            public const int Duration_sortIndex = 50;
            [SortOrder(Duration_sortIndex)]
            [DisplayName(Duration_displayName)]
            public virtual float Duration {
                get => Duration_raw;
                set {
                    if (Duration_raw == value) return;
                    Duration_raw = value;
                    OnPropertyChanged(nameof(Duration));
                }
            }

            protected uint Stamina_Min_raw;
            public const string Stamina_Min_displayName = "Stamina Min";
            public const int Stamina_Min_sortIndex = 100;
            [SortOrder(Stamina_Min_sortIndex)]
            [DisplayName(Stamina_Min_displayName)]
            public virtual uint Stamina_Min {
                get => Stamina_Min_raw;
                set {
                    if (Stamina_Min_raw == value) return;
                    Stamina_Min_raw = value;
                    OnPropertyChanged(nameof(Stamina_Min));
                }
            }

            protected uint Stamina_Max_raw;
            public const string Stamina_Max_displayName = "Stamina Max";
            public const int Stamina_Max_sortIndex = 150;
            [SortOrder(Stamina_Max_sortIndex)]
            [DisplayName(Stamina_Max_displayName)]
            public virtual uint Stamina_Max {
                get => Stamina_Max_raw;
                set {
                    if (Stamina_Max_raw == value) return;
                    Stamina_Max_raw = value;
                    OnPropertyChanged(nameof(Stamina_Max));
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

            public static Fatigue_LR_ LoadData(BinaryReader reader, ulong i) {
                var data = new Fatigue_LR_();
                data.Index = i;
                data.Duration_raw = reader.ReadSingle();
                data.Stamina_Min_raw = reader.ReadUInt32();
                data.Stamina_Max_raw = reader.ReadUInt32();
                return data;
            }

            public override void WriteData(BinaryWriter writer) {
                writer.Write(Duration_raw);
                writer.Write(Stamina_Min_raw);
                writer.Write(Stamina_Max_raw);
            }
        }

        public partial class Stamina_Count_LR_ : MhwStructItem {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Stamina Count (LR)";
            public const bool IsHidden = true;

            protected uint Number_of_Stamina_Entries_raw;
            public const string Number_of_Stamina_Entries_displayName = "Number of Stamina Entries";
            public const int Number_of_Stamina_Entries_sortIndex = 50;
            [SortOrder(Number_of_Stamina_Entries_sortIndex)]
            [DisplayName(Number_of_Stamina_Entries_displayName)]
            [IsReadOnly]
            public virtual uint Number_of_Stamina_Entries {
                get => Number_of_Stamina_Entries_raw;
                set {
                    if (Number_of_Stamina_Entries_raw == value) return;
                    Number_of_Stamina_Entries_raw = value;
                    OnPropertyChanged(nameof(Number_of_Stamina_Entries));
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

            public static Stamina_Count_LR_ LoadData(BinaryReader reader, ulong i) {
                var data = new Stamina_Count_LR_();
                data.Index = i;
                data.Number_of_Stamina_Entries_raw = reader.ReadUInt32();
                return data;
            }

            public override void WriteData(BinaryWriter writer) {
                writer.Write(Number_of_Stamina_Entries_raw);
            }
        }

        public partial class Stamina_LR_ : MhwStructItem {
            public const ulong FixedSizeCount = 0;
            public const string GridName = "Stamina (LR)";
            public const bool IsAddingAllowed = true;

            [SortOrder(-1)]
            [IsReadOnly]
            [DisplayName("X")]
            public string Delete => "X";

            protected uint Unk_raw;
            public const string Unk_displayName = "Unk";
            public const int Unk_sortIndex = 50;
            [SortOrder(Unk_sortIndex)]
            [DisplayName(Unk_displayName)]
            public virtual uint Unk {
                get => Unk_raw;
                set {
                    if (Unk_raw == value) return;
                    Unk_raw = value;
                    OnPropertyChanged(nameof(Unk));
                }
            }

            protected uint Base_raw;
            public const string Base_displayName = "Base";
            public const int Base_sortIndex = 100;
            [SortOrder(Base_sortIndex)]
            [DisplayName(Base_displayName)]
            public virtual uint Base {
                get => Base_raw;
                set {
                    if (Base_raw == value) return;
                    Base_raw = value;
                    OnPropertyChanged(nameof(Base));
                }
            }

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
                var countTarget = (Stamina_Count_LR_) lastStruct.Last();
                var count = (ulong) countTarget.Number_of_Stamina_Entries;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Stamina_LR_ LoadData(BinaryReader reader, ulong i) {
                var data = new Stamina_LR_();
                data.Index = i;
                data.Unk_raw = reader.ReadUInt32();
                data.Base_raw = reader.ReadUInt32();
                return data;
            }

            public override void WriteData(BinaryWriter writer) {
                writer.Write(Unk_raw);
                writer.Write(Base_raw);
            }
        }

        public partial class Fatigue_HR_ : MhwStructItem {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Fatigue (HR)";

            protected float Duration_raw;
            public const string Duration_displayName = "Duration";
            public const int Duration_sortIndex = 50;
            [SortOrder(Duration_sortIndex)]
            [DisplayName(Duration_displayName)]
            public virtual float Duration {
                get => Duration_raw;
                set {
                    if (Duration_raw == value) return;
                    Duration_raw = value;
                    OnPropertyChanged(nameof(Duration));
                }
            }

            protected uint Stamina_Min_raw;
            public const string Stamina_Min_displayName = "Stamina Min";
            public const int Stamina_Min_sortIndex = 100;
            [SortOrder(Stamina_Min_sortIndex)]
            [DisplayName(Stamina_Min_displayName)]
            public virtual uint Stamina_Min {
                get => Stamina_Min_raw;
                set {
                    if (Stamina_Min_raw == value) return;
                    Stamina_Min_raw = value;
                    OnPropertyChanged(nameof(Stamina_Min));
                }
            }

            protected uint Stamina_Max_raw;
            public const string Stamina_Max_displayName = "Stamina Max";
            public const int Stamina_Max_sortIndex = 150;
            [SortOrder(Stamina_Max_sortIndex)]
            [DisplayName(Stamina_Max_displayName)]
            public virtual uint Stamina_Max {
                get => Stamina_Max_raw;
                set {
                    if (Stamina_Max_raw == value) return;
                    Stamina_Max_raw = value;
                    OnPropertyChanged(nameof(Stamina_Max));
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

            public static Fatigue_HR_ LoadData(BinaryReader reader, ulong i) {
                var data = new Fatigue_HR_();
                data.Index = i;
                data.Duration_raw = reader.ReadSingle();
                data.Stamina_Min_raw = reader.ReadUInt32();
                data.Stamina_Max_raw = reader.ReadUInt32();
                return data;
            }

            public override void WriteData(BinaryWriter writer) {
                writer.Write(Duration_raw);
                writer.Write(Stamina_Min_raw);
                writer.Write(Stamina_Max_raw);
            }
        }

        public partial class Stamina_Count_HR_ : MhwStructItem {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Stamina Count (HR)";
            public const bool IsHidden = true;

            protected uint Number_of_Stamina_Entries_raw;
            public const string Number_of_Stamina_Entries_displayName = "Number of Stamina Entries";
            public const int Number_of_Stamina_Entries_sortIndex = 50;
            [SortOrder(Number_of_Stamina_Entries_sortIndex)]
            [DisplayName(Number_of_Stamina_Entries_displayName)]
            [IsReadOnly]
            public virtual uint Number_of_Stamina_Entries {
                get => Number_of_Stamina_Entries_raw;
                set {
                    if (Number_of_Stamina_Entries_raw == value) return;
                    Number_of_Stamina_Entries_raw = value;
                    OnPropertyChanged(nameof(Number_of_Stamina_Entries));
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

            public static Stamina_Count_HR_ LoadData(BinaryReader reader, ulong i) {
                var data = new Stamina_Count_HR_();
                data.Index = i;
                data.Number_of_Stamina_Entries_raw = reader.ReadUInt32();
                return data;
            }

            public override void WriteData(BinaryWriter writer) {
                writer.Write(Number_of_Stamina_Entries_raw);
            }
        }

        public partial class Stamina_HR_ : MhwStructItem {
            public const ulong FixedSizeCount = 0;
            public const string GridName = "Stamina (HR)";
            public const bool IsAddingAllowed = true;

            [SortOrder(-1)]
            [IsReadOnly]
            [DisplayName("X")]
            public string Delete => "X";

            protected uint Unk_raw;
            public const string Unk_displayName = "Unk";
            public const int Unk_sortIndex = 50;
            [SortOrder(Unk_sortIndex)]
            [DisplayName(Unk_displayName)]
            public virtual uint Unk {
                get => Unk_raw;
                set {
                    if (Unk_raw == value) return;
                    Unk_raw = value;
                    OnPropertyChanged(nameof(Unk));
                }
            }

            protected uint Base_raw;
            public const string Base_displayName = "Base";
            public const int Base_sortIndex = 100;
            [SortOrder(Base_sortIndex)]
            [DisplayName(Base_displayName)]
            public virtual uint Base {
                get => Base_raw;
                set {
                    if (Base_raw == value) return;
                    Base_raw = value;
                    OnPropertyChanged(nameof(Base));
                }
            }

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
                var countTarget = (Stamina_Count_HR_) lastStruct.Last();
                var count = (ulong) countTarget.Number_of_Stamina_Entries;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Stamina_HR_ LoadData(BinaryReader reader, ulong i) {
                var data = new Stamina_HR_();
                data.Index = i;
                data.Unk_raw = reader.ReadUInt32();
                data.Base_raw = reader.ReadUInt32();
                return data;
            }

            public override void WriteData(BinaryWriter writer) {
                writer.Write(Unk_raw);
                writer.Write(Base_raw);
            }
        }

        public partial class Fatigue_MR_ : MhwStructItem {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Fatigue (MR)";

            protected float Duration_raw;
            public const string Duration_displayName = "Duration";
            public const int Duration_sortIndex = 50;
            [SortOrder(Duration_sortIndex)]
            [DisplayName(Duration_displayName)]
            public virtual float Duration {
                get => Duration_raw;
                set {
                    if (Duration_raw == value) return;
                    Duration_raw = value;
                    OnPropertyChanged(nameof(Duration));
                }
            }

            protected uint Stamina_Min_raw;
            public const string Stamina_Min_displayName = "Stamina Min";
            public const int Stamina_Min_sortIndex = 100;
            [SortOrder(Stamina_Min_sortIndex)]
            [DisplayName(Stamina_Min_displayName)]
            public virtual uint Stamina_Min {
                get => Stamina_Min_raw;
                set {
                    if (Stamina_Min_raw == value) return;
                    Stamina_Min_raw = value;
                    OnPropertyChanged(nameof(Stamina_Min));
                }
            }

            protected uint Stamina_Max_raw;
            public const string Stamina_Max_displayName = "Stamina Max";
            public const int Stamina_Max_sortIndex = 150;
            [SortOrder(Stamina_Max_sortIndex)]
            [DisplayName(Stamina_Max_displayName)]
            public virtual uint Stamina_Max {
                get => Stamina_Max_raw;
                set {
                    if (Stamina_Max_raw == value) return;
                    Stamina_Max_raw = value;
                    OnPropertyChanged(nameof(Stamina_Max));
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

            public static Fatigue_MR_ LoadData(BinaryReader reader, ulong i) {
                var data = new Fatigue_MR_();
                data.Index = i;
                data.Duration_raw = reader.ReadSingle();
                data.Stamina_Min_raw = reader.ReadUInt32();
                data.Stamina_Max_raw = reader.ReadUInt32();
                return data;
            }

            public override void WriteData(BinaryWriter writer) {
                writer.Write(Duration_raw);
                writer.Write(Stamina_Min_raw);
                writer.Write(Stamina_Max_raw);
            }
        }

        public partial class Stamina_Count_MR_ : MhwStructItem {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Stamina Count (MR)";
            public const bool IsHidden = true;

            protected uint Number_of_Stamina_Entries_raw;
            public const string Number_of_Stamina_Entries_displayName = "Number of Stamina Entries";
            public const int Number_of_Stamina_Entries_sortIndex = 50;
            [SortOrder(Number_of_Stamina_Entries_sortIndex)]
            [DisplayName(Number_of_Stamina_Entries_displayName)]
            [IsReadOnly]
            public virtual uint Number_of_Stamina_Entries {
                get => Number_of_Stamina_Entries_raw;
                set {
                    if (Number_of_Stamina_Entries_raw == value) return;
                    Number_of_Stamina_Entries_raw = value;
                    OnPropertyChanged(nameof(Number_of_Stamina_Entries));
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

            public static Stamina_Count_MR_ LoadData(BinaryReader reader, ulong i) {
                var data = new Stamina_Count_MR_();
                data.Index = i;
                data.Number_of_Stamina_Entries_raw = reader.ReadUInt32();
                return data;
            }

            public override void WriteData(BinaryWriter writer) {
                writer.Write(Number_of_Stamina_Entries_raw);
            }
        }

        public partial class Stamina_MR_ : MhwStructItem {
            public const ulong FixedSizeCount = 0;
            public const string GridName = "Stamina (MR)";
            public const bool IsAddingAllowed = true;

            [SortOrder(-1)]
            [IsReadOnly]
            [DisplayName("X")]
            public string Delete => "X";

            protected uint Unk_raw;
            public const string Unk_displayName = "Unk";
            public const int Unk_sortIndex = 50;
            [SortOrder(Unk_sortIndex)]
            [DisplayName(Unk_displayName)]
            public virtual uint Unk {
                get => Unk_raw;
                set {
                    if (Unk_raw == value) return;
                    Unk_raw = value;
                    OnPropertyChanged(nameof(Unk));
                }
            }

            protected uint Base_raw;
            public const string Base_displayName = "Base";
            public const int Base_sortIndex = 100;
            [SortOrder(Base_sortIndex)]
            [DisplayName(Base_displayName)]
            public virtual uint Base {
                get => Base_raw;
                set {
                    if (Base_raw == value) return;
                    Base_raw = value;
                    OnPropertyChanged(nameof(Base));
                }
            }

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
                var countTarget = (Stamina_Count_MR_) lastStruct.Last();
                var count = (ulong) countTarget.Number_of_Stamina_Entries;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Stamina_MR_ LoadData(BinaryReader reader, ulong i) {
                var data = new Stamina_MR_();
                data.Index = i;
                data.Unk_raw = reader.ReadUInt32();
                data.Base_raw = reader.ReadUInt32();
                return data;
            }

            public override void WriteData(BinaryWriter writer) {
                writer.Write(Unk_raw);
                writer.Write(Base_raw);
            }
        }

        public partial class Monster_Stamina_2_ : MhwStructItem {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Monster Stamina (2)";

            protected float Fatigue_Speed_raw;
            public const string Fatigue_Speed_displayName = "Fatigue Speed";
            public const int Fatigue_Speed_sortIndex = 50;
            [SortOrder(Fatigue_Speed_sortIndex)]
            [DisplayName(Fatigue_Speed_displayName)]
            public virtual float Fatigue_Speed {
                get => Fatigue_Speed_raw;
                set {
                    if (Fatigue_Speed_raw == value) return;
                    Fatigue_Speed_raw = value;
                    OnPropertyChanged(nameof(Fatigue_Speed));
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

            public static Monster_Stamina_2_ LoadData(BinaryReader reader, ulong i) {
                var data = new Monster_Stamina_2_();
                data.Index = i;
                data.Fatigue_Speed_raw = reader.ReadSingle();
                return data;
            }

            public override void WriteData(BinaryWriter writer) {
                writer.Write(Fatigue_Speed_raw);
            }
        }

        public override void LoadFile(string targetFile) {
            using var reader = new BinaryReader(OpenFile(targetFile, EncryptionKey));
            data = new LinkedList<MhwStructDataContainer>();
            var Monster_Stamina_1__ = new MhwStructDataContainer(Monster_Stamina_1_.LoadData(reader, null), typeof(Monster_Stamina_1_));
            data.AddLast(Monster_Stamina_1__);
            var Fatigue_LR__ = new MhwStructDataContainer(Fatigue_LR_.LoadData(reader, null), typeof(Fatigue_LR_));
            data.AddLast(Fatigue_LR__);
            var Stamina_Count_LR__ = new MhwStructDataContainer(Stamina_Count_LR_.LoadData(reader, null), typeof(Stamina_Count_LR_));
            data.AddLast(Stamina_Count_LR__);
            var Stamina_LR__ = new MhwStructDataContainer(Stamina_LR_.LoadData(reader, Stamina_Count_LR__.list), typeof(Stamina_LR_));
            Stamina_LR__.SetCountTargetToUpdate(Stamina_Count_LR__, -1, "Number_of_Stamina_Entries");
            data.AddLast(Stamina_LR__);
            var Fatigue_HR__ = new MhwStructDataContainer(Fatigue_HR_.LoadData(reader, null), typeof(Fatigue_HR_));
            data.AddLast(Fatigue_HR__);
            var Stamina_Count_HR__ = new MhwStructDataContainer(Stamina_Count_HR_.LoadData(reader, null), typeof(Stamina_Count_HR_));
            data.AddLast(Stamina_Count_HR__);
            var Stamina_HR__ = new MhwStructDataContainer(Stamina_HR_.LoadData(reader, Stamina_Count_HR__.list), typeof(Stamina_HR_));
            Stamina_HR__.SetCountTargetToUpdate(Stamina_Count_HR__, -1, "Number_of_Stamina_Entries");
            data.AddLast(Stamina_HR__);
            var Fatigue_MR__ = new MhwStructDataContainer(Fatigue_MR_.LoadData(reader, null), typeof(Fatigue_MR_));
            data.AddLast(Fatigue_MR__);
            var Stamina_Count_MR__ = new MhwStructDataContainer(Stamina_Count_MR_.LoadData(reader, null), typeof(Stamina_Count_MR_));
            data.AddLast(Stamina_Count_MR__);
            var Stamina_MR__ = new MhwStructDataContainer(Stamina_MR_.LoadData(reader, Stamina_Count_MR__.list), typeof(Stamina_MR_));
            Stamina_MR__.SetCountTargetToUpdate(Stamina_Count_MR__, -1, "Number_of_Stamina_Entries");
            data.AddLast(Stamina_MR__);
            var Monster_Stamina_2__ = new MhwStructDataContainer(Monster_Stamina_2_.LoadData(reader, null), typeof(Monster_Stamina_2_));
            data.AddLast(Monster_Stamina_2__);
        }
    }
}
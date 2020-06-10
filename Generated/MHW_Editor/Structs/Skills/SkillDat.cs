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

namespace MHW_Editor.Structs.Skills {
    public partial class SkillDat {
        public override string EncryptionKey => null;

        public partial class Header : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Header";

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

            protected ushort Magic_2_raw;
            public const string Magic_2_displayName = "Magic 2";
            public const int Magic_2_sortIndex = 100;
            [SortOrder(Magic_2_sortIndex)]
            [DisplayName(Magic_2_displayName)]
            [IsReadOnly]
            public virtual ushort Magic_2 {
                get => Magic_2_raw;
                set {
                    if (Magic_2_raw == value) return;
                    Magic_2_raw = value;
                    OnPropertyChanged(nameof(Magic_2));
                }
            }

            protected uint Entry_Count_raw;
            public const string Entry_Count_displayName = "Entry Count";
            public const int Entry_Count_sortIndex = 150;
            [SortOrder(Entry_Count_sortIndex)]
            [DisplayName(Entry_Count_displayName)]
            [IsReadOnly]
            public virtual uint Entry_Count {
                get => Entry_Count_raw;
                set {
                    if (Entry_Count_raw == value) return;
                    Entry_Count_raw = value;
                    OnPropertyChanged(nameof(Entry_Count));
                }
            }

            public const int lastSortIndex = 200;

            public static ObservableMhwStructCollection<Header> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Header>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Header LoadData(BinaryReader reader, ulong i) {
                var data = new Header();
                data.Index = i;
                data.Magic_1_raw = reader.ReadUInt32();
                data.Magic_2_raw = reader.ReadUInt16();
                data.Entry_Count_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Magic_1_raw);
                writer.Write(Magic_2_raw);
                writer.Write(Entry_Count_raw);
            }
        }

        public partial class Entries : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 0;
            public const string GridName = "Entries";
            public override string UniqueId => $"{Id}|{Level}";

            protected ushort Id_raw;
            public const string Id_displayName = "Id";
            public const int Id_sortIndex = 50;
            [SortOrder(Id_sortIndex)]
            [DisplayName(Id_displayName)]
            [IsReadOnly]
            public virtual ushort Id {
                get => Id_raw;
                set {
                    if (Id_raw == value) return;
                    Id_raw = value;
                    OnPropertyChanged(nameof(Id));
                }
            }

            protected byte Level_raw;
            public const string Level_displayName = "Level";
            public const int Level_sortIndex = 100;
            [SortOrder(Level_sortIndex)]
            [DisplayName(Level_displayName)]
            [IsReadOnly]
            public virtual byte Level {
                get => Level_raw;
                set {
                    if (Level_raw == value) return;
                    Level_raw = value;
                    OnPropertyChanged(nameof(Level));
                }
            }

            protected uint Unlock_Skill_1_raw;
            public const string Unlock_Skill_1_displayName = "Unlock Skill 1";
            public const int Unlock_Skill_1_sortIndex = 150;
            [SortOrder(Unlock_Skill_1_sortIndex)]
            [DisplayName(Unlock_Skill_1_displayName)]
            [DataSource(DataSourceType.SkillDat)]
            public virtual uint Unlock_Skill_1 {
                get => Unlock_Skill_1_raw;
                set {
                    if (Unlock_Skill_1_raw == value) return;
                    Unlock_Skill_1_raw = value;
                    OnPropertyChanged(nameof(Unlock_Skill_1));
                    OnPropertyChanged(nameof(Unlock_Skill_1_button));
                }
            }

            [SortOrder(Unlock_Skill_1_sortIndex)]
            [DisplayName(Unlock_Skill_1_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Unlock_Skill_1_button => MainWindow.skillDatLookup[MainWindow.locale].TryGet(Unlock_Skill_1).ToStringWithId(Unlock_Skill_1);

            protected uint Unlock_Skill_2_raw;
            public const string Unlock_Skill_2_displayName = "Unlock Skill 2";
            public const int Unlock_Skill_2_sortIndex = 200;
            [SortOrder(Unlock_Skill_2_sortIndex)]
            [DisplayName(Unlock_Skill_2_displayName)]
            [DataSource(DataSourceType.SkillDat)]
            public virtual uint Unlock_Skill_2 {
                get => Unlock_Skill_2_raw;
                set {
                    if (Unlock_Skill_2_raw == value) return;
                    Unlock_Skill_2_raw = value;
                    OnPropertyChanged(nameof(Unlock_Skill_2));
                    OnPropertyChanged(nameof(Unlock_Skill_2_button));
                }
            }

            [SortOrder(Unlock_Skill_2_sortIndex)]
            [DisplayName(Unlock_Skill_2_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Unlock_Skill_2_button => MainWindow.skillDatLookup[MainWindow.locale].TryGet(Unlock_Skill_2).ToStringWithId(Unlock_Skill_2);

            protected uint Unlock_Skill_3_raw;
            public const string Unlock_Skill_3_displayName = "Unlock Skill 3";
            public const int Unlock_Skill_3_sortIndex = 250;
            [SortOrder(Unlock_Skill_3_sortIndex)]
            [DisplayName(Unlock_Skill_3_displayName)]
            [DataSource(DataSourceType.SkillDat)]
            public virtual uint Unlock_Skill_3 {
                get => Unlock_Skill_3_raw;
                set {
                    if (Unlock_Skill_3_raw == value) return;
                    Unlock_Skill_3_raw = value;
                    OnPropertyChanged(nameof(Unlock_Skill_3));
                    OnPropertyChanged(nameof(Unlock_Skill_3_button));
                }
            }

            [SortOrder(Unlock_Skill_3_sortIndex)]
            [DisplayName(Unlock_Skill_3_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Unlock_Skill_3_button => MainWindow.skillDatLookup[MainWindow.locale].TryGet(Unlock_Skill_3).ToStringWithId(Unlock_Skill_3);

            protected uint Unlock_Skill_4_raw;
            public const string Unlock_Skill_4_displayName = "Unlock Skill 4";
            public const int Unlock_Skill_4_sortIndex = 300;
            [SortOrder(Unlock_Skill_4_sortIndex)]
            [DisplayName(Unlock_Skill_4_displayName)]
            [DataSource(DataSourceType.SkillDat)]
            public virtual uint Unlock_Skill_4 {
                get => Unlock_Skill_4_raw;
                set {
                    if (Unlock_Skill_4_raw == value) return;
                    Unlock_Skill_4_raw = value;
                    OnPropertyChanged(nameof(Unlock_Skill_4));
                    OnPropertyChanged(nameof(Unlock_Skill_4_button));
                }
            }

            [SortOrder(Unlock_Skill_4_sortIndex)]
            [DisplayName(Unlock_Skill_4_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Unlock_Skill_4_button => MainWindow.skillDatLookup[MainWindow.locale].TryGet(Unlock_Skill_4).ToStringWithId(Unlock_Skill_4);

            protected ushort Param_5_raw;
            public const string Param_5_displayName = "Param 5";
            public const int Param_5_sortIndex = 350;
            [SortOrder(Param_5_sortIndex)]
            [DisplayName(Param_5_displayName)]
            public virtual ushort Param_5 {
                get => Param_5_raw;
                set {
                    if (Param_5_raw == value) return;
                    Param_5_raw = value;
                    OnPropertyChanged(nameof(Param_5));
                }
            }

            protected ushort Param_6_raw;
            public const string Param_6_displayName = "Param 6";
            public const int Param_6_sortIndex = 400;
            [SortOrder(Param_6_sortIndex)]
            [DisplayName(Param_6_displayName)]
            public virtual ushort Param_6 {
                get => Param_6_raw;
                set {
                    if (Param_6_raw == value) return;
                    Param_6_raw = value;
                    OnPropertyChanged(nameof(Param_6));
                }
            }

            protected ushort Param_7_raw;
            public const string Param_7_displayName = "Param 7";
            public const int Param_7_sortIndex = 450;
            [SortOrder(Param_7_sortIndex)]
            [DisplayName(Param_7_displayName)]
            public virtual ushort Param_7 {
                get => Param_7_raw;
                set {
                    if (Param_7_raw == value) return;
                    Param_7_raw = value;
                    OnPropertyChanged(nameof(Param_7));
                }
            }

            protected ushort Param_8_raw;
            public const string Param_8_displayName = "Param 8";
            public const int Param_8_sortIndex = 500;
            [SortOrder(Param_8_sortIndex)]
            [DisplayName(Param_8_displayName)]
            public virtual ushort Param_8 {
                get => Param_8_raw;
                set {
                    if (Param_8_raw == value) return;
                    Param_8_raw = value;
                    OnPropertyChanged(nameof(Param_8));
                }
            }

            public const int lastSortIndex = 550;

            public static ObservableMhwStructCollection<Entries> LoadData(BinaryReader reader, ObservableMhwStructCollection<Header> lastStruct) {
                var list = new ObservableMhwStructCollection<Entries>();
                var countTarget = (Header) lastStruct.Last();
                var count = (ulong) countTarget.Entry_Count;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Entries LoadData(BinaryReader reader, ulong i) {
                var data = new Entries();
                data.Index = i;
                data.Id_raw = reader.ReadUInt16();
                data.Level_raw = reader.ReadByte();
                data.Unlock_Skill_1_raw = reader.ReadUInt32();
                data.Unlock_Skill_2_raw = reader.ReadUInt32();
                data.Unlock_Skill_3_raw = reader.ReadUInt32();
                data.Unlock_Skill_4_raw = reader.ReadUInt32();
                data.Param_5_raw = reader.ReadUInt16();
                data.Param_6_raw = reader.ReadUInt16();
                data.Param_7_raw = reader.ReadUInt16();
                data.Param_8_raw = reader.ReadUInt16();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Id_raw);
                writer.Write(Level_raw);
                writer.Write(Unlock_Skill_1_raw);
                writer.Write(Unlock_Skill_2_raw);
                writer.Write(Unlock_Skill_3_raw);
                writer.Write(Unlock_Skill_4_raw);
                writer.Write(Param_5_raw);
                writer.Write(Param_6_raw);
                writer.Write(Param_7_raw);
                writer.Write(Param_8_raw);
            }
        }

        public override void LoadFile(string targetFile) {
            using var reader = new BinaryReader(OpenFile(targetFile, EncryptionKey), Encoding.UTF8);
            data = new LinkedList<MhwStructDataContainer>();
            var Header_ = new MhwStructDataContainer<Header>(Header.LoadData(reader), typeof(Header));
            data.AddLast(Header_);
            var Entries_ = new MhwStructDataContainer<Entries, Header>(Entries.LoadData(reader, Header_.list), typeof(Entries));
            Entries_.SetCountTargetToUpdate(Header_, -1, "Entry_Count");
            data.AddLast(Entries_);
        }
    }
}
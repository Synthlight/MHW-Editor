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

namespace MHW_Editor.Structs.Gems {
    public partial class Gem {
        public override string EncryptionKey => null;

        public partial class Header : MhwStructItem {
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

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
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

        public partial class Entries : MhwStructItem {
            public const ulong FixedSizeCount = 0;
            public const string GridName = "Entries";
            public override string UniqueId => "{Id}";

            protected uint Id_raw;
            public const string Id_displayName = "Id";
            public const int Id_sortIndex = 50;
            [SortOrder(Id_sortIndex)]
            [DisplayName(Id_displayName)]
            [DataSource(DataSourceType.Items)]
            [IsReadOnly]
            public virtual uint Id {
                get => Id_raw;
                set {
                    if (Id_raw == value) return;
                    Id_raw = value;
                    OnPropertyChanged(nameof(Id));
                    OnPropertyChanged(nameof(Id_button));
                }
            }

            [SortOrder(Id_sortIndex)]
            [DisplayName(Id_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Id_button => DataHelper.itemNames[MainWindow.locale].TryGet(Id).ToStringWithId(Id);

            protected uint Index_raw;
            public const string Index_displayName = "Index";
            [SortOrder(Index_sortIndex)]
            [DisplayName(Index_displayName)]
            [IsReadOnly]
            public override ulong Index {
                get => (ulong) Index_raw;
                set {
                    if ((ulong) Index_raw == value) return;
                    Index_raw = (uint) value;
                    OnPropertyChanged(nameof(Index));
                }
            }

            protected uint Size_raw;
            public const string Size_displayName = "Size";
            public const int Size_sortIndex = 150;
            [SortOrder(Size_sortIndex)]
            [DisplayName(Size_displayName)]
            public virtual uint Size {
                get => Size_raw;
                set {
                    if (Size_raw == value) return;
                    Size_raw = value;
                    OnPropertyChanged(nameof(Size));
                }
            }

            protected uint Skill_1_raw;
            public const string Skill_1_displayName = "Skill 1";
            public const int Skill_1_sortIndex = 200;
            [SortOrder(Skill_1_sortIndex)]
            [DisplayName(Skill_1_displayName)]
            [DataSource(DataSourceType.Skills)]
            public virtual uint Skill_1 {
                get => Skill_1_raw;
                set {
                    if (Skill_1_raw == value) return;
                    Skill_1_raw = value;
                    OnPropertyChanged(nameof(Skill_1));
                    OnPropertyChanged(nameof(Skill_1_button));
                }
            }

            [SortOrder(Skill_1_sortIndex)]
            [DisplayName(Skill_1_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Skill_1_button => DataHelper.skillNames[MainWindow.locale].TryGet(Skill_1).ToStringWithId(Skill_1);

            protected uint Skill_1_Level_raw;
            public const string Skill_1_Level_displayName = "Skill 1 Level";
            public const int Skill_1_Level_sortIndex = 250;
            [SortOrder(Skill_1_Level_sortIndex)]
            [DisplayName(Skill_1_Level_displayName)]
            public virtual uint Skill_1_Level {
                get => Skill_1_Level_raw;
                set {
                    if (Skill_1_Level_raw == value) return;
                    Skill_1_Level_raw = value;
                    OnPropertyChanged(nameof(Skill_1_Level));
                }
            }

            protected uint Skill_2_raw;
            public const string Skill_2_displayName = "Skill 2";
            public const int Skill_2_sortIndex = 300;
            [SortOrder(Skill_2_sortIndex)]
            [DisplayName(Skill_2_displayName)]
            [DataSource(DataSourceType.Skills)]
            public virtual uint Skill_2 {
                get => Skill_2_raw;
                set {
                    if (Skill_2_raw == value) return;
                    Skill_2_raw = value;
                    OnPropertyChanged(nameof(Skill_2));
                    OnPropertyChanged(nameof(Skill_2_button));
                }
            }

            [SortOrder(Skill_2_sortIndex)]
            [DisplayName(Skill_2_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Skill_2_button => DataHelper.skillNames[MainWindow.locale].TryGet(Skill_2).ToStringWithId(Skill_2);

            protected uint Skill_2_Level_raw;
            public const string Skill_2_Level_displayName = "Skill 2 Level";
            public const int Skill_2_Level_sortIndex = 350;
            [SortOrder(Skill_2_Level_sortIndex)]
            [DisplayName(Skill_2_Level_displayName)]
            public virtual uint Skill_2_Level {
                get => Skill_2_Level_raw;
                set {
                    if (Skill_2_Level_raw == value) return;
                    Skill_2_Level_raw = value;
                    OnPropertyChanged(nameof(Skill_2_Level));
                }
            }

            public const int lastSortIndex = 400;

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
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
                data.Id_raw = reader.ReadUInt32();
                data.Index_raw = reader.ReadUInt32();
                data.Size_raw = reader.ReadUInt32();
                data.Skill_1_raw = reader.ReadUInt32();
                data.Skill_1_Level_raw = reader.ReadUInt32();
                data.Skill_2_raw = reader.ReadUInt32();
                data.Skill_2_Level_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Id_raw);
                writer.Write(Index_raw);
                writer.Write(Size_raw);
                writer.Write(Skill_1_raw);
                writer.Write(Skill_1_Level_raw);
                writer.Write(Skill_2_raw);
                writer.Write(Skill_2_Level_raw);
            }
        }

        public override void LoadFile(string targetFile) {
            using var reader = new BinaryReader(OpenFile(targetFile, EncryptionKey), Encoding.UTF8);
            data = new LinkedList<MhwStructDataContainer>();
            var Header_ = new MhwStructDataContainer(Header.LoadData(reader, null), typeof(Header));
            data.AddLast(Header_);
            var Entries_ = new MhwStructDataContainer(Entries.LoadData(reader, Header_.list), typeof(Entries));
            Entries_.SetCountTargetToUpdate(Header_, -1, "Entry_Count");
            data.AddLast(Entries_);
        }
    }
}
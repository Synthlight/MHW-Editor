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
    public partial class WeaponWhistle {
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
                    ChangedItems.Add(nameof(Magic_1));
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
                    ChangedItems.Add(nameof(Magic_2));
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
                    ChangedItems.Add(nameof(Entry_Count));
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
            public override string UniqueId => $"{Id}";

            protected uint Id_raw;
            public const string Id_displayName = "Id";
            public const int Id_sortIndex = 50;
            [SortOrder(Id_sortIndex)]
            [DisplayName(Id_displayName)]
            [IsReadOnly]
            public virtual uint Id {
                get => Id_raw;
                set {
                    if (Id_raw == value) return;
                    Id_raw = value;
                    ChangedItems.Add(nameof(Id));
                    OnPropertyChanged(nameof(Id));
                }
            }

            protected byte Note_1_raw;
            public const string Note_1_displayName = "Note 1";
            public const int Note_1_sortIndex = 100;
            [SortOrder(Note_1_sortIndex)]
            [DisplayName(Note_1_displayName)]
            public virtual MHW_Template.Weapons.NoteColor Note_1 {
                get => (MHW_Template.Weapons.NoteColor) Note_1_raw;
                set {
                    if ((MHW_Template.Weapons.NoteColor) Note_1_raw == value) return;
                    Note_1_raw = (byte) value;
                    ChangedItems.Add(nameof(Note_1));
                    OnPropertyChanged(nameof(Note_1));
                }
            }

            protected byte Note_2_raw;
            public const string Note_2_displayName = "Note 2";
            public const int Note_2_sortIndex = 150;
            [SortOrder(Note_2_sortIndex)]
            [DisplayName(Note_2_displayName)]
            public virtual MHW_Template.Weapons.NoteColor Note_2 {
                get => (MHW_Template.Weapons.NoteColor) Note_2_raw;
                set {
                    if ((MHW_Template.Weapons.NoteColor) Note_2_raw == value) return;
                    Note_2_raw = (byte) value;
                    ChangedItems.Add(nameof(Note_2));
                    OnPropertyChanged(nameof(Note_2));
                }
            }

            protected byte Note_3_raw;
            public const string Note_3_displayName = "Note 3";
            public const int Note_3_sortIndex = 200;
            [SortOrder(Note_3_sortIndex)]
            [DisplayName(Note_3_displayName)]
            public virtual MHW_Template.Weapons.NoteColor Note_3 {
                get => (MHW_Template.Weapons.NoteColor) Note_3_raw;
                set {
                    if ((MHW_Template.Weapons.NoteColor) Note_3_raw == value) return;
                    Note_3_raw = (byte) value;
                    ChangedItems.Add(nameof(Note_3));
                    OnPropertyChanged(nameof(Note_3));
                }
            }

            public const int lastSortIndex = 250;

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
                data.Id_raw = reader.ReadUInt32();
                data.Note_1_raw = reader.ReadByte();
                data.Note_2_raw = reader.ReadByte();
                data.Note_3_raw = reader.ReadByte();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Id_raw);
                writer.Write(Note_1_raw);
                writer.Write(Note_2_raw);
                writer.Write(Note_3_raw);
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
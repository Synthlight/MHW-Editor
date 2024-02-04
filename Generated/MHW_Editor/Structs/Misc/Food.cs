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

namespace MHW_Editor.Structs.Misc {
    public partial class Food {
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
                const ulong count = 1UL;
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

            protected uint Page_raw;
            public const string Page_displayName = "Page";
            public const int Page_sortIndex = 50;
            [SortOrder(Page_sortIndex)]
            [DisplayName(Page_displayName)]
            public virtual MHW_Template.Misc.FoodPage Page {
                get => (MHW_Template.Misc.FoodPage) Page_raw;
                set {
                    if ((MHW_Template.Misc.FoodPage) Page_raw == value) return;
                    Page_raw = (uint) value;
                    ChangedItems.Add(nameof(Page));
                    OnPropertyChanged(nameof(Page));
                }
            }

            protected uint Column_raw;
            public const string Column_displayName = "Column";
            public const int Column_sortIndex = 100;
            [SortOrder(Column_sortIndex)]
            [DisplayName(Column_displayName)]
            public virtual uint Column {
                get => Column_raw;
                set {
                    if (Column_raw == value) return;
                    Column_raw = value;
                    ChangedItems.Add(nameof(Column));
                    OnPropertyChanged(nameof(Column));
                }
            }

            protected uint Unk_3_raw;
            public const string Unk_3_displayName = "Unk 3";
            public const int Unk_3_sortIndex = 150;
            [SortOrder(Unk_3_sortIndex)]
            [DisplayName(Unk_3_displayName)]
            public virtual uint Unk_3 {
                get => Unk_3_raw;
                set {
                    if (Unk_3_raw == value) return;
                    Unk_3_raw = value;
                    ChangedItems.Add(nameof(Unk_3));
                    OnPropertyChanged(nameof(Unk_3));
                }
            }

            protected uint Story_Flag_raw;
            public const string Story_Flag_displayName = "Story Flag";
            public const int Story_Flag_sortIndex = 200;
            [SortOrder(Story_Flag_sortIndex)]
            [DisplayName(Story_Flag_displayName)]
            public virtual uint Story_Flag {
                get => Story_Flag_raw;
                set {
                    if (Story_Flag_raw == value) return;
                    Story_Flag_raw = value;
                    ChangedItems.Add(nameof(Story_Flag));
                    OnPropertyChanged(nameof(Story_Flag));
                }
            }

            protected uint Color_raw;
            public const string Color_displayName = "Color";
            public const int Color_sortIndex = 250;
            [SortOrder(Color_sortIndex)]
            [DisplayName(Color_displayName)]
            public virtual uint Color {
                get => Color_raw;
                set {
                    if (Color_raw == value) return;
                    Color_raw = value;
                    ChangedItems.Add(nameof(Color));
                    OnPropertyChanged(nameof(Color));
                }
            }

            public const int lastSortIndex = 300;

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
                data.Page_raw = reader.ReadUInt32();
                data.Column_raw = reader.ReadUInt32();
                data.Unk_3_raw = reader.ReadUInt32();
                data.Story_Flag_raw = reader.ReadUInt32();
                data.Color_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Page_raw);
                writer.Write(Column_raw);
                writer.Write(Unk_3_raw);
                writer.Write(Story_Flag_raw);
                writer.Write(Color_raw);
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
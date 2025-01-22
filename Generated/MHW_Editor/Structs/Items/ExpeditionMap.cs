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

namespace MHW_Editor.Structs.Items {
    public partial class ExpeditionMap {
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

            protected uint Unk_1_uint__raw;
            public const string Unk_1_uint__displayName = "Unk 1 (uint)";
            public const int Unk_1_uint__sortIndex = 50;
            [SortOrder(Unk_1_uint__sortIndex)]
            [DisplayName(Unk_1_uint__displayName)]
            public virtual uint Unk_1_uint_ {
                get => Unk_1_uint__raw;
                set {
                    if (Unk_1_uint__raw == value) return;
                    Unk_1_uint__raw = value;
                    ChangedItems.Add(nameof(Unk_1_uint_));
                    OnPropertyChanged(nameof(Unk_1_uint_));
                }
            }

            protected uint Unk_2_uint__raw;
            public const string Unk_2_uint__displayName = "Unk 2 (uint)";
            public const int Unk_2_uint__sortIndex = 100;
            [SortOrder(Unk_2_uint__sortIndex)]
            [DisplayName(Unk_2_uint__displayName)]
            public virtual uint Unk_2_uint_ {
                get => Unk_2_uint__raw;
                set {
                    if (Unk_2_uint__raw == value) return;
                    Unk_2_uint__raw = value;
                    ChangedItems.Add(nameof(Unk_2_uint_));
                    OnPropertyChanged(nameof(Unk_2_uint_));
                }
            }

            protected byte Unk_3_byte__raw;
            public const string Unk_3_byte__displayName = "Unk 3 (byte)";
            public const int Unk_3_byte__sortIndex = 150;
            [SortOrder(Unk_3_byte__sortIndex)]
            [DisplayName(Unk_3_byte__displayName)]
            public virtual byte Unk_3_byte_ {
                get => Unk_3_byte__raw;
                set {
                    if (Unk_3_byte__raw == value) return;
                    Unk_3_byte__raw = value;
                    ChangedItems.Add(nameof(Unk_3_byte_));
                    OnPropertyChanged(nameof(Unk_3_byte_));
                }
            }

            protected byte Unk_4_byte__raw;
            public const string Unk_4_byte__displayName = "Unk 4 (byte)";
            public const int Unk_4_byte__sortIndex = 200;
            [SortOrder(Unk_4_byte__sortIndex)]
            [DisplayName(Unk_4_byte__displayName)]
            public virtual byte Unk_4_byte_ {
                get => Unk_4_byte__raw;
                set {
                    if (Unk_4_byte__raw == value) return;
                    Unk_4_byte__raw = value;
                    ChangedItems.Add(nameof(Unk_4_byte_));
                    OnPropertyChanged(nameof(Unk_4_byte_));
                }
            }

            protected byte Unk_5_byte__raw;
            public const string Unk_5_byte__displayName = "Unk 5 (byte)";
            public const int Unk_5_byte__sortIndex = 250;
            [SortOrder(Unk_5_byte__sortIndex)]
            [DisplayName(Unk_5_byte__displayName)]
            public virtual byte Unk_5_byte_ {
                get => Unk_5_byte__raw;
                set {
                    if (Unk_5_byte__raw == value) return;
                    Unk_5_byte__raw = value;
                    ChangedItems.Add(nameof(Unk_5_byte_));
                    OnPropertyChanged(nameof(Unk_5_byte_));
                }
            }

            protected byte Unk_6_byte__raw;
            public const string Unk_6_byte__displayName = "Unk 6 (byte)";
            public const int Unk_6_byte__sortIndex = 300;
            [SortOrder(Unk_6_byte__sortIndex)]
            [DisplayName(Unk_6_byte__displayName)]
            public virtual byte Unk_6_byte_ {
                get => Unk_6_byte__raw;
                set {
                    if (Unk_6_byte__raw == value) return;
                    Unk_6_byte__raw = value;
                    ChangedItems.Add(nameof(Unk_6_byte_));
                    OnPropertyChanged(nameof(Unk_6_byte_));
                }
            }

            protected byte Unk_7_byte__raw;
            public const string Unk_7_byte__displayName = "Unk 7 (byte)";
            public const int Unk_7_byte__sortIndex = 350;
            [SortOrder(Unk_7_byte__sortIndex)]
            [DisplayName(Unk_7_byte__displayName)]
            public virtual byte Unk_7_byte_ {
                get => Unk_7_byte__raw;
                set {
                    if (Unk_7_byte__raw == value) return;
                    Unk_7_byte__raw = value;
                    ChangedItems.Add(nameof(Unk_7_byte_));
                    OnPropertyChanged(nameof(Unk_7_byte_));
                }
            }

            protected byte Unk_8_byte__raw;
            public const string Unk_8_byte__displayName = "Unk 8 (byte)";
            public const int Unk_8_byte__sortIndex = 400;
            [SortOrder(Unk_8_byte__sortIndex)]
            [DisplayName(Unk_8_byte__displayName)]
            public virtual byte Unk_8_byte_ {
                get => Unk_8_byte__raw;
                set {
                    if (Unk_8_byte__raw == value) return;
                    Unk_8_byte__raw = value;
                    ChangedItems.Add(nameof(Unk_8_byte_));
                    OnPropertyChanged(nameof(Unk_8_byte_));
                }
            }

            protected byte Unk_9_byte__raw;
            public const string Unk_9_byte__displayName = "Unk 9 (byte)";
            public const int Unk_9_byte__sortIndex = 450;
            [SortOrder(Unk_9_byte__sortIndex)]
            [DisplayName(Unk_9_byte__displayName)]
            public virtual byte Unk_9_byte_ {
                get => Unk_9_byte__raw;
                set {
                    if (Unk_9_byte__raw == value) return;
                    Unk_9_byte__raw = value;
                    ChangedItems.Add(nameof(Unk_9_byte_));
                    OnPropertyChanged(nameof(Unk_9_byte_));
                }
            }

            protected byte Unk_10_byte__raw;
            public const string Unk_10_byte__displayName = "Unk 10 (byte)";
            public const int Unk_10_byte__sortIndex = 500;
            [SortOrder(Unk_10_byte__sortIndex)]
            [DisplayName(Unk_10_byte__displayName)]
            public virtual byte Unk_10_byte_ {
                get => Unk_10_byte__raw;
                set {
                    if (Unk_10_byte__raw == value) return;
                    Unk_10_byte__raw = value;
                    ChangedItems.Add(nameof(Unk_10_byte_));
                    OnPropertyChanged(nameof(Unk_10_byte_));
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
                data.Unk_1_uint__raw = reader.ReadUInt32();
                data.Unk_2_uint__raw = reader.ReadUInt32();
                data.Unk_3_byte__raw = reader.ReadByte();
                data.Unk_4_byte__raw = reader.ReadByte();
                data.Unk_5_byte__raw = reader.ReadByte();
                data.Unk_6_byte__raw = reader.ReadByte();
                data.Unk_7_byte__raw = reader.ReadByte();
                data.Unk_8_byte__raw = reader.ReadByte();
                data.Unk_9_byte__raw = reader.ReadByte();
                data.Unk_10_byte__raw = reader.ReadByte();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_1_uint__raw);
                writer.Write(Unk_2_uint__raw);
                writer.Write(Unk_3_byte__raw);
                writer.Write(Unk_4_byte__raw);
                writer.Write(Unk_5_byte__raw);
                writer.Write(Unk_6_byte__raw);
                writer.Write(Unk_7_byte__raw);
                writer.Write(Unk_8_byte__raw);
                writer.Write(Unk_9_byte__raw);
                writer.Write(Unk_10_byte__raw);
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
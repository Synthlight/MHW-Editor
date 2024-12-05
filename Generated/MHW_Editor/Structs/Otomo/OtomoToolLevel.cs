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

namespace MHW_Editor.Structs.Otomo {
    public partial class OtomoToolLevel {
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

            protected ushort Unk_1_ushort__raw;
            public const string Unk_1_ushort__displayName = "Unk 1 (ushort)";
            public const int Unk_1_ushort__sortIndex = 50;
            [SortOrder(Unk_1_ushort__sortIndex)]
            [DisplayName(Unk_1_ushort__displayName)]
            public virtual ushort Unk_1_ushort_ {
                get => Unk_1_ushort__raw;
                set {
                    if (Unk_1_ushort__raw == value) return;
                    Unk_1_ushort__raw = value;
                    ChangedItems.Add(nameof(Unk_1_ushort_));
                    OnPropertyChanged(nameof(Unk_1_ushort_));
                }
            }

            protected ushort Unk_2_ushort__raw;
            public const string Unk_2_ushort__displayName = "Unk 2 (ushort)";
            public const int Unk_2_ushort__sortIndex = 100;
            [SortOrder(Unk_2_ushort__sortIndex)]
            [DisplayName(Unk_2_ushort__displayName)]
            public virtual ushort Unk_2_ushort_ {
                get => Unk_2_ushort__raw;
                set {
                    if (Unk_2_ushort__raw == value) return;
                    Unk_2_ushort__raw = value;
                    ChangedItems.Add(nameof(Unk_2_ushort_));
                    OnPropertyChanged(nameof(Unk_2_ushort_));
                }
            }

            protected ushort Unk_3_ushort__raw;
            public const string Unk_3_ushort__displayName = "Unk 3 (ushort)";
            public const int Unk_3_ushort__sortIndex = 150;
            [SortOrder(Unk_3_ushort__sortIndex)]
            [DisplayName(Unk_3_ushort__displayName)]
            public virtual ushort Unk_3_ushort_ {
                get => Unk_3_ushort__raw;
                set {
                    if (Unk_3_ushort__raw == value) return;
                    Unk_3_ushort__raw = value;
                    ChangedItems.Add(nameof(Unk_3_ushort_));
                    OnPropertyChanged(nameof(Unk_3_ushort_));
                }
            }

            protected ushort Unk_4_ushort__raw;
            public const string Unk_4_ushort__displayName = "Unk 4 (ushort)";
            public const int Unk_4_ushort__sortIndex = 200;
            [SortOrder(Unk_4_ushort__sortIndex)]
            [DisplayName(Unk_4_ushort__displayName)]
            public virtual ushort Unk_4_ushort_ {
                get => Unk_4_ushort__raw;
                set {
                    if (Unk_4_ushort__raw == value) return;
                    Unk_4_ushort__raw = value;
                    ChangedItems.Add(nameof(Unk_4_ushort_));
                    OnPropertyChanged(nameof(Unk_4_ushort_));
                }
            }

            protected ushort Unk_5_ushort__raw;
            public const string Unk_5_ushort__displayName = "Unk 5 (ushort)";
            public const int Unk_5_ushort__sortIndex = 250;
            [SortOrder(Unk_5_ushort__sortIndex)]
            [DisplayName(Unk_5_ushort__displayName)]
            public virtual ushort Unk_5_ushort_ {
                get => Unk_5_ushort__raw;
                set {
                    if (Unk_5_ushort__raw == value) return;
                    Unk_5_ushort__raw = value;
                    ChangedItems.Add(nameof(Unk_5_ushort_));
                    OnPropertyChanged(nameof(Unk_5_ushort_));
                }
            }

            protected ushort Unk_6_ushort__raw;
            public const string Unk_6_ushort__displayName = "Unk 6 (ushort)";
            public const int Unk_6_ushort__sortIndex = 300;
            [SortOrder(Unk_6_ushort__sortIndex)]
            [DisplayName(Unk_6_ushort__displayName)]
            public virtual ushort Unk_6_ushort_ {
                get => Unk_6_ushort__raw;
                set {
                    if (Unk_6_ushort__raw == value) return;
                    Unk_6_ushort__raw = value;
                    ChangedItems.Add(nameof(Unk_6_ushort_));
                    OnPropertyChanged(nameof(Unk_6_ushort_));
                }
            }

            protected ushort Unk_7_ushort__raw;
            public const string Unk_7_ushort__displayName = "Unk 7 (ushort)";
            public const int Unk_7_ushort__sortIndex = 350;
            [SortOrder(Unk_7_ushort__sortIndex)]
            [DisplayName(Unk_7_ushort__displayName)]
            public virtual ushort Unk_7_ushort_ {
                get => Unk_7_ushort__raw;
                set {
                    if (Unk_7_ushort__raw == value) return;
                    Unk_7_ushort__raw = value;
                    ChangedItems.Add(nameof(Unk_7_ushort_));
                    OnPropertyChanged(nameof(Unk_7_ushort_));
                }
            }

            protected ushort Unk_8_ushort__raw;
            public const string Unk_8_ushort__displayName = "Unk 8 (ushort)";
            public const int Unk_8_ushort__sortIndex = 400;
            [SortOrder(Unk_8_ushort__sortIndex)]
            [DisplayName(Unk_8_ushort__displayName)]
            public virtual ushort Unk_8_ushort_ {
                get => Unk_8_ushort__raw;
                set {
                    if (Unk_8_ushort__raw == value) return;
                    Unk_8_ushort__raw = value;
                    ChangedItems.Add(nameof(Unk_8_ushort_));
                    OnPropertyChanged(nameof(Unk_8_ushort_));
                }
            }

            protected ushort Unk_9_ushort__raw;
            public const string Unk_9_ushort__displayName = "Unk 9 (ushort)";
            public const int Unk_9_ushort__sortIndex = 450;
            [SortOrder(Unk_9_ushort__sortIndex)]
            [DisplayName(Unk_9_ushort__displayName)]
            public virtual ushort Unk_9_ushort_ {
                get => Unk_9_ushort__raw;
                set {
                    if (Unk_9_ushort__raw == value) return;
                    Unk_9_ushort__raw = value;
                    ChangedItems.Add(nameof(Unk_9_ushort_));
                    OnPropertyChanged(nameof(Unk_9_ushort_));
                }
            }

            protected ushort Unk_10_ushort__raw;
            public const string Unk_10_ushort__displayName = "Unk 10 (ushort)";
            public const int Unk_10_ushort__sortIndex = 500;
            [SortOrder(Unk_10_ushort__sortIndex)]
            [DisplayName(Unk_10_ushort__displayName)]
            public virtual ushort Unk_10_ushort_ {
                get => Unk_10_ushort__raw;
                set {
                    if (Unk_10_ushort__raw == value) return;
                    Unk_10_ushort__raw = value;
                    ChangedItems.Add(nameof(Unk_10_ushort_));
                    OnPropertyChanged(nameof(Unk_10_ushort_));
                }
            }

            protected ushort Unk_11_ushort__raw;
            public const string Unk_11_ushort__displayName = "Unk 11 (ushort)";
            public const int Unk_11_ushort__sortIndex = 550;
            [SortOrder(Unk_11_ushort__sortIndex)]
            [DisplayName(Unk_11_ushort__displayName)]
            public virtual ushort Unk_11_ushort_ {
                get => Unk_11_ushort__raw;
                set {
                    if (Unk_11_ushort__raw == value) return;
                    Unk_11_ushort__raw = value;
                    ChangedItems.Add(nameof(Unk_11_ushort_));
                    OnPropertyChanged(nameof(Unk_11_ushort_));
                }
            }

            protected ushort Unk_12_ushort__raw;
            public const string Unk_12_ushort__displayName = "Unk 12 (ushort)";
            public const int Unk_12_ushort__sortIndex = 600;
            [SortOrder(Unk_12_ushort__sortIndex)]
            [DisplayName(Unk_12_ushort__displayName)]
            public virtual ushort Unk_12_ushort_ {
                get => Unk_12_ushort__raw;
                set {
                    if (Unk_12_ushort__raw == value) return;
                    Unk_12_ushort__raw = value;
                    ChangedItems.Add(nameof(Unk_12_ushort_));
                    OnPropertyChanged(nameof(Unk_12_ushort_));
                }
            }

            protected ushort Unk_13_ushort__raw;
            public const string Unk_13_ushort__displayName = "Unk 13 (ushort)";
            public const int Unk_13_ushort__sortIndex = 650;
            [SortOrder(Unk_13_ushort__sortIndex)]
            [DisplayName(Unk_13_ushort__displayName)]
            public virtual ushort Unk_13_ushort_ {
                get => Unk_13_ushort__raw;
                set {
                    if (Unk_13_ushort__raw == value) return;
                    Unk_13_ushort__raw = value;
                    ChangedItems.Add(nameof(Unk_13_ushort_));
                    OnPropertyChanged(nameof(Unk_13_ushort_));
                }
            }

            protected uint Unk_14_uint__raw;
            public const string Unk_14_uint__displayName = "Unk 14 (uint)";
            public const int Unk_14_uint__sortIndex = 700;
            [SortOrder(Unk_14_uint__sortIndex)]
            [DisplayName(Unk_14_uint__displayName)]
            public virtual uint Unk_14_uint_ {
                get => Unk_14_uint__raw;
                set {
                    if (Unk_14_uint__raw == value) return;
                    Unk_14_uint__raw = value;
                    ChangedItems.Add(nameof(Unk_14_uint_));
                    OnPropertyChanged(nameof(Unk_14_uint_));
                }
            }

            public const int lastSortIndex = 750;

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
                data.Unk_1_ushort__raw = reader.ReadUInt16();
                data.Unk_2_ushort__raw = reader.ReadUInt16();
                data.Unk_3_ushort__raw = reader.ReadUInt16();
                data.Unk_4_ushort__raw = reader.ReadUInt16();
                data.Unk_5_ushort__raw = reader.ReadUInt16();
                data.Unk_6_ushort__raw = reader.ReadUInt16();
                data.Unk_7_ushort__raw = reader.ReadUInt16();
                data.Unk_8_ushort__raw = reader.ReadUInt16();
                data.Unk_9_ushort__raw = reader.ReadUInt16();
                data.Unk_10_ushort__raw = reader.ReadUInt16();
                data.Unk_11_ushort__raw = reader.ReadUInt16();
                data.Unk_12_ushort__raw = reader.ReadUInt16();
                data.Unk_13_ushort__raw = reader.ReadUInt16();
                data.Unk_14_uint__raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_1_ushort__raw);
                writer.Write(Unk_2_ushort__raw);
                writer.Write(Unk_3_ushort__raw);
                writer.Write(Unk_4_ushort__raw);
                writer.Write(Unk_5_ushort__raw);
                writer.Write(Unk_6_ushort__raw);
                writer.Write(Unk_7_ushort__raw);
                writer.Write(Unk_8_ushort__raw);
                writer.Write(Unk_9_ushort__raw);
                writer.Write(Unk_10_ushort__raw);
                writer.Write(Unk_11_ushort__raw);
                writer.Write(Unk_12_ushort__raw);
                writer.Write(Unk_13_ushort__raw);
                writer.Write(Unk_14_uint__raw);
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
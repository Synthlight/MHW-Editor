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

namespace MHW_Editor.Structs.Armors {
    public partial class Opst {
        public override string EncryptionKey => null;

        public partial class Header : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Header";

            protected uint Iceborne_Identifier_raw;
            public const string Iceborne_Identifier_displayName = "Iceborne Identifier";
            public const int Iceborne_Identifier_sortIndex = 50;
            [SortOrder(Iceborne_Identifier_sortIndex)]
            [DisplayName(Iceborne_Identifier_displayName)]
            [IsReadOnly]
            public virtual uint Iceborne_Identifier {
                get => Iceborne_Identifier_raw;
                set {
                    if (Iceborne_Identifier_raw == value) return;
                    Iceborne_Identifier_raw = value;
                    ChangedItems.Add(nameof(Iceborne_Identifier));
                    OnPropertyChanged(nameof(Iceborne_Identifier));
                }
            }

            protected uint Magic_raw;
            public const string Magic_displayName = "Magic";
            public const int Magic_sortIndex = 100;
            [SortOrder(Magic_sortIndex)]
            [DisplayName(Magic_displayName)]
            [IsReadOnly]
            public virtual uint Magic {
                get => Magic_raw;
                set {
                    if (Magic_raw == value) return;
                    Magic_raw = value;
                    ChangedItems.Add(nameof(Magic));
                    OnPropertyChanged(nameof(Magic));
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
                data.Iceborne_Identifier_raw = reader.ReadUInt32();
                data.Magic_raw = reader.ReadUInt32();
                data.Entry_Count_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Iceborne_Identifier_raw);
                writer.Write(Magic_raw);
                writer.Write(Entry_Count_raw);
            }
        }

        public partial class Entries : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 0;
            public const string GridName = "Entries";

            protected byte Bit_Flags_1_Raw_raw;
            public const string Bit_Flags_1_Raw_displayName = "Bit Flags 1 Raw";
            public const int Bit_Flags_1_Raw_sortIndex = 50;
            [SortOrder(Bit_Flags_1_Raw_sortIndex)]
            [DisplayName(Bit_Flags_1_Raw_displayName)]
            private MHW_Template.Armors.Opst1Flags Bit_Flags_1_Raw {
                get => (MHW_Template.Armors.Opst1Flags) Bit_Flags_1_Raw_raw;
                set {
                    if ((MHW_Template.Armors.Opst1Flags) Bit_Flags_1_Raw_raw == value) return;
                    Bit_Flags_1_Raw_raw = (byte) value;
                    ChangedItems.Add(nameof(Bit_Flags_1_Raw));
                    OnPropertyChanged(nameof(Bit_Flags_1_Raw));
                }
            }

            protected byte Bit_Flags_2_Raw_raw;
            public const string Bit_Flags_2_Raw_displayName = "Bit Flags 2 Raw";
            public const int Bit_Flags_2_Raw_sortIndex = 100;
            [SortOrder(Bit_Flags_2_Raw_sortIndex)]
            [DisplayName(Bit_Flags_2_Raw_displayName)]
            private MHW_Template.Armors.Opst2Flags Bit_Flags_2_Raw {
                get => (MHW_Template.Armors.Opst2Flags) Bit_Flags_2_Raw_raw;
                set {
                    if ((MHW_Template.Armors.Opst2Flags) Bit_Flags_2_Raw_raw == value) return;
                    Bit_Flags_2_Raw_raw = (byte) value;
                    ChangedItems.Add(nameof(Bit_Flags_2_Raw));
                    OnPropertyChanged(nameof(Bit_Flags_2_Raw));
                }
            }

            protected byte Bit_Flags_3_raw;
            public const string Bit_Flags_3_displayName = "Bit Flags 3";
            public const int Bit_Flags_3_sortIndex = 150;
            [SortOrder(Bit_Flags_3_sortIndex)]
            [DisplayName(Bit_Flags_3_displayName)]
            public virtual byte Bit_Flags_3 {
                get => Bit_Flags_3_raw;
                set {
                    if (Bit_Flags_3_raw == value) return;
                    Bit_Flags_3_raw = value;
                    ChangedItems.Add(nameof(Bit_Flags_3));
                    OnPropertyChanged(nameof(Bit_Flags_3));
                }
            }

            protected byte Bit_Flags_4_raw;
            public const string Bit_Flags_4_displayName = "Bit Flags 4";
            public const int Bit_Flags_4_sortIndex = 200;
            [SortOrder(Bit_Flags_4_sortIndex)]
            [DisplayName(Bit_Flags_4_displayName)]
            public virtual byte Bit_Flags_4 {
                get => Bit_Flags_4_raw;
                set {
                    if (Bit_Flags_4_raw == value) return;
                    Bit_Flags_4_raw = value;
                    ChangedItems.Add(nameof(Bit_Flags_4));
                    OnPropertyChanged(nameof(Bit_Flags_4));
                }
            }

            protected byte Bit_Flags_5_raw;
            public const string Bit_Flags_5_displayName = "Bit Flags 5";
            public const int Bit_Flags_5_sortIndex = 250;
            [SortOrder(Bit_Flags_5_sortIndex)]
            [DisplayName(Bit_Flags_5_displayName)]
            public virtual bool Bit_Flags_5 {
                get => (bool) Convert.ToBoolean(Bit_Flags_5_raw);
                set {
                    if (Convert.ToBoolean(Bit_Flags_5_raw) == value) return;
                    Bit_Flags_5_raw = Convert.ToByte(value);
                    ChangedItems.Add(nameof(Bit_Flags_5));
                    OnPropertyChanged(nameof(Bit_Flags_5));
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
                data.Bit_Flags_1_Raw_raw = reader.ReadByte();
                data.Bit_Flags_2_Raw_raw = reader.ReadByte();
                data.Bit_Flags_3_raw = reader.ReadByte();
                data.Bit_Flags_4_raw = reader.ReadByte();
                data.Bit_Flags_5_raw = reader.ReadByte();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Bit_Flags_1_Raw_raw);
                writer.Write(Bit_Flags_2_Raw_raw);
                writer.Write(Bit_Flags_3_raw);
                writer.Write(Bit_Flags_4_raw);
                writer.Write(Bit_Flags_5_raw);
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
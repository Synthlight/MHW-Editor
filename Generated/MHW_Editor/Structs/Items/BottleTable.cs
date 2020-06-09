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
    public partial class BottleTable {
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

            protected byte Close_Range_raw;
            public const string Close_Range_displayName = "Close Range";
            public const int Close_Range_sortIndex = 50;
            [SortOrder(Close_Range_sortIndex)]
            [DisplayName(Close_Range_displayName)]
            public virtual MHW_Template.Weapons.CoatingType Close_Range {
                get => (MHW_Template.Weapons.CoatingType) Close_Range_raw;
                set {
                    if ((MHW_Template.Weapons.CoatingType) Close_Range_raw == value) return;
                    Close_Range_raw = (byte) value;
                    OnPropertyChanged(nameof(Close_Range));
                }
            }

            protected byte Power_raw;
            public const string Power_displayName = "Power";
            public const int Power_sortIndex = 100;
            [SortOrder(Power_sortIndex)]
            [DisplayName(Power_displayName)]
            public virtual MHW_Template.Weapons.CoatingType Power {
                get => (MHW_Template.Weapons.CoatingType) Power_raw;
                set {
                    if ((MHW_Template.Weapons.CoatingType) Power_raw == value) return;
                    Power_raw = (byte) value;
                    OnPropertyChanged(nameof(Power));
                }
            }

            protected byte Paralysis_raw;
            public const string Paralysis_displayName = "Paralysis";
            public const int Paralysis_sortIndex = 150;
            [SortOrder(Paralysis_sortIndex)]
            [DisplayName(Paralysis_displayName)]
            public virtual MHW_Template.Weapons.CoatingType Paralysis {
                get => (MHW_Template.Weapons.CoatingType) Paralysis_raw;
                set {
                    if ((MHW_Template.Weapons.CoatingType) Paralysis_raw == value) return;
                    Paralysis_raw = (byte) value;
                    OnPropertyChanged(nameof(Paralysis));
                }
            }

            protected byte Poison_raw;
            public const string Poison_displayName = "Poison";
            public const int Poison_sortIndex = 200;
            [SortOrder(Poison_sortIndex)]
            [DisplayName(Poison_displayName)]
            public virtual MHW_Template.Weapons.CoatingType Poison {
                get => (MHW_Template.Weapons.CoatingType) Poison_raw;
                set {
                    if ((MHW_Template.Weapons.CoatingType) Poison_raw == value) return;
                    Poison_raw = (byte) value;
                    OnPropertyChanged(nameof(Poison));
                }
            }

            protected byte Sleep_raw;
            public const string Sleep_displayName = "Sleep";
            public const int Sleep_sortIndex = 250;
            [SortOrder(Sleep_sortIndex)]
            [DisplayName(Sleep_displayName)]
            public virtual MHW_Template.Weapons.CoatingType Sleep {
                get => (MHW_Template.Weapons.CoatingType) Sleep_raw;
                set {
                    if ((MHW_Template.Weapons.CoatingType) Sleep_raw == value) return;
                    Sleep_raw = (byte) value;
                    OnPropertyChanged(nameof(Sleep));
                }
            }

            protected byte Blast_raw;
            public const string Blast_displayName = "Blast";
            public const int Blast_sortIndex = 300;
            [SortOrder(Blast_sortIndex)]
            [DisplayName(Blast_displayName)]
            public virtual MHW_Template.Weapons.CoatingType Blast {
                get => (MHW_Template.Weapons.CoatingType) Blast_raw;
                set {
                    if ((MHW_Template.Weapons.CoatingType) Blast_raw == value) return;
                    Blast_raw = (byte) value;
                    OnPropertyChanged(nameof(Blast));
                }
            }

            public const int lastSortIndex = 350;

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
                data.Close_Range_raw = reader.ReadByte();
                data.Power_raw = reader.ReadByte();
                data.Paralysis_raw = reader.ReadByte();
                data.Poison_raw = reader.ReadByte();
                data.Sleep_raw = reader.ReadByte();
                data.Blast_raw = reader.ReadByte();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Close_Range_raw);
                writer.Write(Power_raw);
                writer.Write(Paralysis_raw);
                writer.Write(Poison_raw);
                writer.Write(Sleep_raw);
                writer.Write(Blast_raw);
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
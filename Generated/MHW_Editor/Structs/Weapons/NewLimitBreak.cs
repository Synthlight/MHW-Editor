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
    public partial class NewLimitBreak {
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
            public override string UniqueId => $"{Aug_Category}|{Aug_Level}";

            protected uint Aug_Category_raw;
            public const string Aug_Category_displayName = "Aug Category";
            public const int Aug_Category_sortIndex = 50;
            [SortOrder(Aug_Category_sortIndex)]
            [DisplayName(Aug_Category_displayName)]
            [IsReadOnly]
            public virtual MHW_Template.Weapons.AugmentationCategory Aug_Category {
                get => (MHW_Template.Weapons.AugmentationCategory) Aug_Category_raw;
                set {
                    if ((MHW_Template.Weapons.AugmentationCategory) Aug_Category_raw == value) return;
                    Aug_Category_raw = (uint) value;
                    ChangedItems.Add(nameof(Aug_Category));
                    OnPropertyChanged(nameof(Aug_Category));
                }
            }

            protected uint Aug_Level_raw;
            public const string Aug_Level_displayName = "Aug Level";
            public const int Aug_Level_sortIndex = 100;
            [SortOrder(Aug_Level_sortIndex)]
            [DisplayName(Aug_Level_displayName)]
            [IsReadOnly]
            public virtual uint Aug_Level {
                get => Aug_Level_raw;
                set {
                    if (Aug_Level_raw == value) return;
                    Aug_Level_raw = value;
                    ChangedItems.Add(nameof(Aug_Level));
                    OnPropertyChanged(nameof(Aug_Level));
                }
            }

            protected uint Aug_Slot_Cost_raw;
            public const string Aug_Slot_Cost_displayName = "Aug Slot Cost";
            public const int Aug_Slot_Cost_sortIndex = 150;
            [SortOrder(Aug_Slot_Cost_sortIndex)]
            [DisplayName(Aug_Slot_Cost_displayName)]
            public virtual uint Aug_Slot_Cost {
                get => Aug_Slot_Cost_raw;
                set {
                    if (Aug_Slot_Cost_raw == value) return;
                    Aug_Slot_Cost_raw = value;
                    ChangedItems.Add(nameof(Aug_Slot_Cost));
                    OnPropertyChanged(nameof(Aug_Slot_Cost));
                }
            }

            protected uint Research_Cost_r10__raw;
            public const string Research_Cost_r10__displayName = "Research Cost (r10)";
            public const int Research_Cost_r10__sortIndex = 200;
            [SortOrder(Research_Cost_r10__sortIndex)]
            [DisplayName(Research_Cost_r10__displayName)]
            public virtual uint Research_Cost_r10_ {
                get => Research_Cost_r10__raw;
                set {
                    if (Research_Cost_r10__raw == value) return;
                    Research_Cost_r10__raw = value;
                    ChangedItems.Add(nameof(Research_Cost_r10_));
                    OnPropertyChanged(nameof(Research_Cost_r10_));
                }
            }

            protected uint Research_Cost_r11__raw;
            public const string Research_Cost_r11__displayName = "Research Cost (r11)";
            public const int Research_Cost_r11__sortIndex = 250;
            [SortOrder(Research_Cost_r11__sortIndex)]
            [DisplayName(Research_Cost_r11__displayName)]
            public virtual uint Research_Cost_r11_ {
                get => Research_Cost_r11__raw;
                set {
                    if (Research_Cost_r11__raw == value) return;
                    Research_Cost_r11__raw = value;
                    ChangedItems.Add(nameof(Research_Cost_r11_));
                    OnPropertyChanged(nameof(Research_Cost_r11_));
                }
            }

            protected uint Research_Cost_r12__raw;
            public const string Research_Cost_r12__displayName = "Research Cost (r12)";
            public const int Research_Cost_r12__sortIndex = 300;
            [SortOrder(Research_Cost_r12__sortIndex)]
            [DisplayName(Research_Cost_r12__displayName)]
            public virtual uint Research_Cost_r12_ {
                get => Research_Cost_r12__raw;
                set {
                    if (Research_Cost_r12__raw == value) return;
                    Research_Cost_r12__raw = value;
                    ChangedItems.Add(nameof(Research_Cost_r12_));
                    OnPropertyChanged(nameof(Research_Cost_r12_));
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
                data.Aug_Category_raw = reader.ReadUInt32();
                data.Aug_Level_raw = reader.ReadUInt32();
                data.Aug_Slot_Cost_raw = reader.ReadUInt32();
                data.Research_Cost_r10__raw = reader.ReadUInt32();
                data.Research_Cost_r11__raw = reader.ReadUInt32();
                data.Research_Cost_r12__raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Aug_Category_raw);
                writer.Write(Aug_Level_raw);
                writer.Write(Aug_Slot_Cost_raw);
                writer.Write(Research_Cost_r10__raw);
                writer.Write(Research_Cost_r11__raw);
                writer.Write(Research_Cost_r12__raw);
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
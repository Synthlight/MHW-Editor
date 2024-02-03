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
    public partial class FestivalSchedule {
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

            protected uint Festival_raw;
            public const string Festival_displayName = "Festival";
            public const int Festival_sortIndex = 50;
            [SortOrder(Festival_sortIndex)]
            [DisplayName(Festival_displayName)]
            public virtual MHW_Template.Misc.Festival Festival {
                get => (MHW_Template.Misc.Festival) Festival_raw;
                set {
                    if ((MHW_Template.Misc.Festival) Festival_raw == value) return;
                    Festival_raw = (uint) value;
                    ChangedItems.Add(nameof(Festival));
                    OnPropertyChanged(nameof(Festival));
                }
            }

            protected uint Enable_Event_Quests_raw;
            public const string Enable_Event_Quests_displayName = "Enable Event Quests";
            public const int Enable_Event_Quests_sortIndex = 100;
            [SortOrder(Enable_Event_Quests_sortIndex)]
            [DisplayName(Enable_Event_Quests_displayName)]
            public virtual uint Enable_Event_Quests {
                get => Enable_Event_Quests_raw;
                set {
                    if (Enable_Event_Quests_raw == value) return;
                    Enable_Event_Quests_raw = value;
                    ChangedItems.Add(nameof(Enable_Event_Quests));
                    OnPropertyChanged(nameof(Enable_Event_Quests));
                }
            }

            protected uint Resource_Unknown_High_No_raw;
            public const string Resource_Unknown_High_No_displayName = "Resource Unknown High No";
            public const int Resource_Unknown_High_No_sortIndex = 150;
            [SortOrder(Resource_Unknown_High_No_sortIndex)]
            [DisplayName(Resource_Unknown_High_No_displayName)]
            public virtual uint Resource_Unknown_High_No {
                get => Resource_Unknown_High_No_raw;
                set {
                    if (Resource_Unknown_High_No_raw == value) return;
                    Resource_Unknown_High_No_raw = value;
                    ChangedItems.Add(nameof(Resource_Unknown_High_No));
                    OnPropertyChanged(nameof(Resource_Unknown_High_No));
                }
            }

            protected uint Resource_Unknown_Low_No_raw;
            public const string Resource_Unknown_Low_No_displayName = "Resource Unknown Low No";
            public const int Resource_Unknown_Low_No_sortIndex = 200;
            [SortOrder(Resource_Unknown_Low_No_sortIndex)]
            [DisplayName(Resource_Unknown_Low_No_displayName)]
            public virtual uint Resource_Unknown_Low_No {
                get => Resource_Unknown_Low_No_raw;
                set {
                    if (Resource_Unknown_Low_No_raw == value) return;
                    Resource_Unknown_Low_No_raw = value;
                    ChangedItems.Add(nameof(Resource_Unknown_Low_No));
                    OnPropertyChanged(nameof(Resource_Unknown_Low_No));
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
                data.Festival_raw = reader.ReadUInt32();
                data.Enable_Event_Quests_raw = reader.ReadUInt32();
                data.Resource_Unknown_High_No_raw = reader.ReadUInt32();
                data.Resource_Unknown_Low_No_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Festival_raw);
                writer.Write(Enable_Event_Quests_raw);
                writer.Write(Resource_Unknown_High_No_raw);
                writer.Write(Resource_Unknown_Low_No_raw);
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
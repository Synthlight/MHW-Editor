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
    public partial class MelderItem {
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

            protected uint Result_Item_Id_raw;
            public const string Result_Item_Id_displayName = "Result Item Id";
            public const int Result_Item_Id_sortIndex = 50;
            [SortOrder(Result_Item_Id_sortIndex)]
            [DisplayName(Result_Item_Id_displayName)]
            [DataSource(DataSourceType.Items)]
            public virtual uint Result_Item_Id {
                get => Result_Item_Id_raw;
                set {
                    if (Result_Item_Id_raw == value) return;
                    Result_Item_Id_raw = value;
                    OnPropertyChanged(nameof(Result_Item_Id));
                    OnPropertyChanged(nameof(Result_Item_Id_button));
                }
            }

            [SortOrder(Result_Item_Id_sortIndex)]
            [DisplayName(Result_Item_Id_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Result_Item_Id_button => DataHelper.itemNames[MainWindow.locale].TryGet(Result_Item_Id).ToStringWithId(Result_Item_Id);

            protected uint Research_Points_raw;
            public const string Research_Points_displayName = "Research Points";
            public const int Research_Points_sortIndex = 100;
            [SortOrder(Research_Points_sortIndex)]
            [DisplayName(Research_Points_displayName)]
            public virtual uint Research_Points {
                get => Research_Points_raw;
                set {
                    if (Research_Points_raw == value) return;
                    Research_Points_raw = value;
                    OnPropertyChanged(nameof(Research_Points));
                }
            }

            protected uint Melding_Points_raw;
            public const string Melding_Points_displayName = "Melding Points";
            public const int Melding_Points_sortIndex = 150;
            [SortOrder(Melding_Points_sortIndex)]
            [DisplayName(Melding_Points_displayName)]
            public virtual uint Melding_Points {
                get => Melding_Points_raw;
                set {
                    if (Melding_Points_raw == value) return;
                    Melding_Points_raw = value;
                    OnPropertyChanged(nameof(Melding_Points));
                }
            }

            protected uint Category_raw;
            public const string Category_displayName = "Category";
            public const int Category_sortIndex = 200;
            [SortOrder(Category_sortIndex)]
            [DisplayName(Category_displayName)]
            public virtual MHW_Template.Items.ItemCategory Category {
                get => (MHW_Template.Items.ItemCategory) Category_raw;
                set {
                    if ((MHW_Template.Items.ItemCategory) Category_raw == value) return;
                    Category_raw = (uint) value;
                    OnPropertyChanged(nameof(Category));
                }
            }

            protected uint Unlock_Flag_raw;
            public const string Unlock_Flag_displayName = "Unlock Flag";
            public const int Unlock_Flag_sortIndex = 250;
            [SortOrder(Unlock_Flag_sortIndex)]
            [DisplayName(Unlock_Flag_displayName)]
            public virtual uint Unlock_Flag {
                get => Unlock_Flag_raw;
                set {
                    if (Unlock_Flag_raw == value) return;
                    Unlock_Flag_raw = value;
                    OnPropertyChanged(nameof(Unlock_Flag));
                }
            }

            protected byte Unknown_uint8__raw;
            public const string Unknown_uint8__displayName = "Unknown (uint8)";
            public const int Unknown_uint8__sortIndex = 300;
            [SortOrder(Unknown_uint8__sortIndex)]
            [DisplayName(Unknown_uint8__displayName)]
            public virtual byte Unknown_uint8_ {
                get => Unknown_uint8__raw;
                set {
                    if (Unknown_uint8__raw == value) return;
                    Unknown_uint8__raw = value;
                    OnPropertyChanged(nameof(Unknown_uint8_));
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
                data.Result_Item_Id_raw = reader.ReadUInt32();
                data.Research_Points_raw = reader.ReadUInt32();
                data.Melding_Points_raw = reader.ReadUInt32();
                data.Category_raw = reader.ReadUInt32();
                data.Unlock_Flag_raw = reader.ReadUInt32();
                data.Unknown_uint8__raw = reader.ReadByte();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Result_Item_Id_raw);
                writer.Write(Research_Points_raw);
                writer.Write(Melding_Points_raw);
                writer.Write(Category_raw);
                writer.Write(Unlock_Flag_raw);
                writer.Write(Unknown_uint8__raw);
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
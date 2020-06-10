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
    public partial class MelderExchange {
        public override string EncryptionKey => null;

        public partial class Melder_Exchange : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Melder Exchange";

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

            public static ObservableMhwStructCollection<Melder_Exchange> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Melder_Exchange>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Melder_Exchange LoadData(BinaryReader reader, ulong i) {
                var data = new Melder_Exchange();
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

        public partial class Item_Box : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 0;
            public const string GridName = "Item Box";
            public const bool IsAddingAllowed = true;

            [SortOrder(-1)]
            [IsReadOnly]
            [DisplayName("X")]
            public string Delete => "X";

            protected uint Source_Item_Id_raw;
            public const string Source_Item_Id_displayName = "Source Item Id";
            public const int Source_Item_Id_sortIndex = 50;
            [SortOrder(Source_Item_Id_sortIndex)]
            [DisplayName(Source_Item_Id_displayName)]
            [DataSource(DataSourceType.Items)]
            public virtual uint Source_Item_Id {
                get => Source_Item_Id_raw;
                set {
                    if (Source_Item_Id_raw == value) return;
                    Source_Item_Id_raw = value;
                    ChangedItems.Add(nameof(Source_Item_Id));
                    OnPropertyChanged(nameof(Source_Item_Id));
                    OnPropertyChanged(nameof(Source_Item_Id_button));
                }
            }

            [SortOrder(Source_Item_Id_sortIndex)]
            [DisplayName(Source_Item_Id_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Source_Item_Id_button => DataHelper.itemNames[MainWindow.locale].TryGet(Source_Item_Id).ToStringWithId(Source_Item_Id);

            protected uint Unk_1_raw;
            public const string Unk_1_displayName = "Unk 1";
            public const int Unk_1_sortIndex = 100;
            [SortOrder(Unk_1_sortIndex)]
            [DisplayName(Unk_1_displayName)]
            public virtual uint Unk_1 {
                get => Unk_1_raw;
                set {
                    if (Unk_1_raw == value) return;
                    Unk_1_raw = value;
                    ChangedItems.Add(nameof(Unk_1));
                    OnPropertyChanged(nameof(Unk_1));
                }
            }

            public partial class Items : MhwStructItem, IWriteDataInner<Item_Box> {
                public const ulong FixedSizeCount = 215;
                public const string GridName = "Items";

                protected ushort Unk_raw;
                public const string Unk_displayName = "Unk";
                public const int Unk_sortIndex = 50;
                [SortOrder(Unk_sortIndex)]
                [DisplayName(Unk_displayName)]
                public virtual ushort Unk {
                    get => Unk_raw;
                    set {
                        if (Unk_raw == value) return;
                        Unk_raw = value;
                        ChangedItems.Add(nameof(Unk));
                        OnPropertyChanged(nameof(Unk));
                    }
                }

                public const int lastSortIndex = 100;

                public static ObservableMhwStructCollection<Items> LoadData(BinaryReader reader, Item_Box parent) {
                    var list = new ObservableMhwStructCollection<Items>();
                    var count = 215UL;
                    for (ulong i = 0; i < count; i++) {
                        list.Add(LoadData(reader, i, parent));
                    }
                    return list;
                }

                public static Items LoadData(BinaryReader reader, ulong i, Item_Box parent) {
                    var data = new Items();
                    data.Index = i;
                    data.Unk_raw = reader.ReadUInt16();
                    return data;
                }

                public void WriteData(BinaryWriter writer, Item_Box parent) {
                    writer.Write(Unk_raw);
                }
            }

            public const string Items_displayName = "Items";
            public const int Items_sortIndex = 150;
            [SortOrder(Items_sortIndex)]
            [DisplayName(Items_displayName)]
            public virtual ObservableCollection<Items> Items_raw { get; protected set; }

            public const int lastSortIndex = 200;

            public static ObservableMhwStructCollection<Item_Box> LoadData(BinaryReader reader, ObservableMhwStructCollection<Melder_Exchange> lastStruct) {
                var list = new ObservableMhwStructCollection<Item_Box>();
                var countTarget = (Melder_Exchange) lastStruct.Last();
                var count = (ulong) countTarget.Entry_Count;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Item_Box LoadData(BinaryReader reader, ulong i) {
                var data = new Item_Box();
                data.Index = i;
                data.Source_Item_Id_raw = reader.ReadUInt32();
                data.Unk_1_raw = reader.ReadUInt32();
                data.Items_raw = Items.LoadData(reader, data);
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Source_Item_Id_raw);
                writer.Write(Unk_1_raw);
                foreach (var obj in Items_raw) {
                    obj.WriteData(writer, this);
                }
            }
        }

        public override void LoadFile(string targetFile) {
            using var reader = new BinaryReader(OpenFile(targetFile, EncryptionKey), Encoding.UTF8);
            data = new LinkedList<MhwStructDataContainer>();
            var Melder_Exchange_ = new MhwStructDataContainer<Melder_Exchange>(Melder_Exchange.LoadData(reader), typeof(Melder_Exchange));
            data.AddLast(Melder_Exchange_);
            var Item_Box_ = new MhwStructDataContainer<Item_Box, Melder_Exchange>(Item_Box.LoadData(reader, Melder_Exchange_.list), typeof(Item_Box));
            Item_Box_.SetCountTargetToUpdate(Melder_Exchange_, -1, "Entry_Count");
            data.AddLast(Item_Box_);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Items {
    public partial class ShopList {
        public override string EncryptionKey => null;

        public partial class Shop_List : MhwStructItem {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Shop List";

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

            protected uint Item_Count_raw;
            public const string Item_Count_displayName = "Item Count";
            public const int Item_Count_sortIndex = 150;
            [SortOrder(Item_Count_sortIndex)]
            [DisplayName(Item_Count_displayName)]
            [IsReadOnly]
            public virtual uint Item_Count {
                get => Item_Count_raw;
                set {
                    if (Item_Count_raw == value) return;
                    Item_Count_raw = value;
                    OnPropertyChanged(nameof(Item_Count));
                }
            }

            public static Shop_List LoadData(BinaryReader reader) {
                var data = new Shop_List();
                data.Magic_1_raw = reader.ReadUInt32();
                data.Magic_2_raw = reader.ReadUInt16();
                data.Item_Count_raw = reader.ReadUInt32();
                return data;
            }

            public override void WriteData(BinaryWriter writer) {
                writer.Write(Magic_1_raw);
                writer.Write(Magic_2_raw);
                writer.Write(Item_Count_raw);
            }
        }

        public partial class Entries : MhwStructItem {
            public const ulong FixedSizeCount = 0;
            public const string GridName = "Entries";
            public const bool IsAddingAllowed = true;

            [SortOrder(-1)]
            [IsReadOnly]
            [DisplayName("X")]
            public string Delete => "X";

            protected uint Index_raw;
            public const string Index_displayName = "Index";
            public const int Index_sortIndex = 50;
            [SortOrder(Index_sortIndex)]
            [DisplayName(Index_displayName)]
            public override ulong Index {
                get => (ulong) Index_raw;
                set {
                    if ((ulong) Index_raw == value) return;
                    Index_raw = (uint) value;
                    OnPropertyChanged(nameof(Index));
                }
            }

            protected uint Item_Id_raw;
            public const string Item_Id_displayName = "Item Id";
            public const int Item_Id_sortIndex = 100;
            [SortOrder(Item_Id_sortIndex)]
            [DisplayName(Item_Id_displayName)]
            [DataSource(DataSourceType.Items)]
            public virtual uint Item_Id {
                get => Item_Id_raw;
                set {
                    if (Item_Id_raw == value) return;
                    Item_Id_raw = value;
                    OnPropertyChanged(nameof(Item_Id));
                    OnPropertyChanged(nameof(Item_Id_button));
                }
            }

            [SortOrder(Item_Id_sortIndex)]
            [DisplayName(Item_Id_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Item_Id_button => DataHelper.itemNames[MainWindow.locale].TryGet(Item_Id).ToStringWithId(Item_Id);

            protected uint Story_Unlock_raw;
            public const string Story_Unlock_displayName = "Story Unlock";
            public const int Story_Unlock_sortIndex = 150;
            [SortOrder(Story_Unlock_sortIndex)]
            [DisplayName(Story_Unlock_displayName)]
            public virtual uint Story_Unlock {
                get => Story_Unlock_raw;
                set {
                    if (Story_Unlock_raw == value) return;
                    Story_Unlock_raw = value;
                    OnPropertyChanged(nameof(Story_Unlock));
                }
            }

            protected ushort Unk_raw;
            public const string Unk_displayName = "Unk";
            public const int Unk_sortIndex = 200;
            [SortOrder(Unk_sortIndex)]
            [DisplayName(Unk_displayName)]
            public virtual ushort Unk {
                get => Unk_raw;
                set {
                    if (Unk_raw == value) return;
                    Unk_raw = value;
                    OnPropertyChanged(nameof(Unk));
                }
            }

            public static Entries LoadData(BinaryReader reader) {
                var data = new Entries();
                data.Index_raw = reader.ReadUInt32();
                data.Item_Id_raw = reader.ReadUInt32();
                data.Story_Unlock_raw = reader.ReadUInt32();
                data.Unk_raw = reader.ReadUInt16();
                return data;
            }

            public override void WriteData(BinaryWriter writer) {
                writer.Write(Index_raw);
                writer.Write(Item_Id_raw);
                writer.Write(Story_Unlock_raw);
                writer.Write(Unk_raw);
            }
        }

        public override void LoadFile(string targetFile) {
            using var reader = new BinaryReader(OpenFile(targetFile, EncryptionKey));
            data = new List<MhwStructDataContainer>();
            dataByType = new Dictionary<Type, MhwStructDataContainer>();

            var Shop_List_list = new ObservableCollection<object>();
            for (ulong i = 0; i < GetEntryCount(typeof(Shop_List)); i++) {
                var item = Shop_List.LoadData(reader);
                item.Index = i;
                Shop_List_list.Add(item);
            }
            var Shop_List_container = new MhwStructDataContainer(Shop_List_list, typeof(Shop_List));
            data.Add(Shop_List_container);
            dataByType[typeof(Shop_List)] = Shop_List_container;

            var Entries_list = new ObservableCollection<object>();
            for (ulong i = 0; i < GetEntryCount(typeof(Entries)); i++) {
                var item = Entries.LoadData(reader);
                item.Index = i;
                Entries_list.Add(item);
            }
            var Entries_container = new MhwStructDataContainer(Entries_list, typeof(Entries));
            data.Add(Entries_container);
            dataByType[typeof(Entries)] = Entries_container;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Items {
    public partial class SupplyData {
        public override string EncryptionKey => null;

        public partial class Supply_Data : MhwStructItem {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Supply Data";

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

            protected uint Magic_2_raw;
            public const string Magic_2_displayName = "Magic 2";
            public const int Magic_2_sortIndex = 100;
            [SortOrder(Magic_2_sortIndex)]
            [DisplayName(Magic_2_displayName)]
            [IsReadOnly]
            public virtual uint Magic_2 {
                get => Magic_2_raw;
                set {
                    if (Magic_2_raw == value) return;
                    Magic_2_raw = value;
                    OnPropertyChanged(nameof(Magic_2));
                }
            }

            protected ushort Magic_3_raw;
            public const string Magic_3_displayName = "Magic 3";
            public const int Magic_3_sortIndex = 150;
            [SortOrder(Magic_3_sortIndex)]
            [DisplayName(Magic_3_displayName)]
            [IsReadOnly]
            public virtual ushort Magic_3 {
                get => Magic_3_raw;
                set {
                    if (Magic_3_raw == value) return;
                    Magic_3_raw = value;
                    OnPropertyChanged(nameof(Magic_3));
                }
            }

            protected uint Supply_Id_raw;
            public const string Supply_Id_displayName = "Supply Id";
            public const int Supply_Id_sortIndex = 200;
            [SortOrder(Supply_Id_sortIndex)]
            [DisplayName(Supply_Id_displayName)]
            public virtual uint Supply_Id {
                get => Supply_Id_raw;
                set {
                    if (Supply_Id_raw == value) return;
                    Supply_Id_raw = value;
                    OnPropertyChanged(nameof(Supply_Id));
                }
            }

            public const int lastSortIndex = 250;

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Supply_Data LoadData(BinaryReader reader, ulong i) {
                var data = new Supply_Data();
                data.Index = i;
                data.Magic_1_raw = reader.ReadUInt32();
                data.Magic_2_raw = reader.ReadUInt32();
                data.Magic_3_raw = reader.ReadUInt16();
                data.Supply_Id_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Magic_1_raw);
                writer.Write(Magic_2_raw);
                writer.Write(Magic_3_raw);
                writer.Write(Supply_Id_raw);
            }
        }

        public partial class Item_Box : MhwStructItem {
            public const ulong FixedSizeCount = 24;
            public const string GridName = "Item Box";

            protected ushort Item_Id_raw;
            public const string Item_Id_displayName = "Item Id";
            public const int Item_Id_sortIndex = 50;
            [SortOrder(Item_Id_sortIndex)]
            [DisplayName(Item_Id_displayName)]
            [DataSource(DataSourceType.Items)]
            public virtual ushort Item_Id {
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

            protected ushort Item_Count_raw;
            public const string Item_Count_displayName = "Item Count";
            public const int Item_Count_sortIndex = 100;
            [SortOrder(Item_Count_sortIndex)]
            [DisplayName(Item_Count_displayName)]
            public virtual ushort Item_Count {
                get => Item_Count_raw;
                set {
                    if (Item_Count_raw == value) return;
                    Item_Count_raw = value;
                    OnPropertyChanged(nameof(Item_Count));
                }
            }

            public const int lastSortIndex = 150;

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
                var count = 24UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Item_Box LoadData(BinaryReader reader, ulong i) {
                var data = new Item_Box();
                data.Index = i;
                data.Item_Id_raw = reader.ReadUInt16();
                data.Item_Count_raw = reader.ReadUInt16();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Item_Id_raw);
                writer.Write(Item_Count_raw);
            }
        }

        public partial class Item_Box_Scaling : MhwStructItem {
            public const ulong FixedSizeCount = 3;
            public const string GridName = "Item Box Scaling";

            protected byte Items_to_Show_raw;
            public const string Items_to_Show_displayName = "Items to Show";
            public const int Items_to_Show_sortIndex = 50;
            [SortOrder(Items_to_Show_sortIndex)]
            [DisplayName(Items_to_Show_displayName)]
            public virtual byte Items_to_Show {
                get => Items_to_Show_raw;
                set {
                    if (Items_to_Show_raw == value) return;
                    Items_to_Show_raw = value;
                    OnPropertyChanged(nameof(Items_to_Show));
                }
            }

            public const int lastSortIndex = 100;

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
                var count = 3UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Item_Box_Scaling LoadData(BinaryReader reader, ulong i) {
                var data = new Item_Box_Scaling();
                data.Index = i;
                data.Items_to_Show_raw = reader.ReadByte();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Items_to_Show_raw);
            }
        }

        public partial class Ammo_Box : MhwStructItem {
            public const ulong FixedSizeCount = 16;
            public const string GridName = "Ammo Box";

            protected ushort Ammo_Id_raw;
            public const string Ammo_Id_displayName = "Ammo Id";
            public const int Ammo_Id_sortIndex = 50;
            [SortOrder(Ammo_Id_sortIndex)]
            [DisplayName(Ammo_Id_displayName)]
            [DataSource(DataSourceType.Items)]
            public virtual ushort Ammo_Id {
                get => Ammo_Id_raw;
                set {
                    if (Ammo_Id_raw == value) return;
                    Ammo_Id_raw = value;
                    OnPropertyChanged(nameof(Ammo_Id));
                    OnPropertyChanged(nameof(Ammo_Id_button));
                }
            }

            [SortOrder(Ammo_Id_sortIndex)]
            [DisplayName(Ammo_Id_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Ammo_Id_button => DataHelper.itemNames[MainWindow.locale].TryGet(Ammo_Id).ToStringWithId(Ammo_Id);

            protected ushort Ammo_Count_raw;
            public const string Ammo_Count_displayName = "Ammo Count";
            public const int Ammo_Count_sortIndex = 100;
            [SortOrder(Ammo_Count_sortIndex)]
            [DisplayName(Ammo_Count_displayName)]
            public virtual ushort Ammo_Count {
                get => Ammo_Count_raw;
                set {
                    if (Ammo_Count_raw == value) return;
                    Ammo_Count_raw = value;
                    OnPropertyChanged(nameof(Ammo_Count));
                }
            }

            public const int lastSortIndex = 150;

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
                var count = 16UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Ammo_Box LoadData(BinaryReader reader, ulong i) {
                var data = new Ammo_Box();
                data.Index = i;
                data.Ammo_Id_raw = reader.ReadUInt16();
                data.Ammo_Count_raw = reader.ReadUInt16();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Ammo_Id_raw);
                writer.Write(Ammo_Count_raw);
            }
        }

        public partial class Ammo_Box_Scaling : MhwStructItem {
            public const ulong FixedSizeCount = 3;
            public const string GridName = "Ammo Box Scaling";

            protected byte Ammo_Items_to_Show_raw;
            public const string Ammo_Items_to_Show_displayName = "Ammo Items to Show";
            public const int Ammo_Items_to_Show_sortIndex = 50;
            [SortOrder(Ammo_Items_to_Show_sortIndex)]
            [DisplayName(Ammo_Items_to_Show_displayName)]
            public virtual byte Ammo_Items_to_Show {
                get => Ammo_Items_to_Show_raw;
                set {
                    if (Ammo_Items_to_Show_raw == value) return;
                    Ammo_Items_to_Show_raw = value;
                    OnPropertyChanged(nameof(Ammo_Items_to_Show));
                }
            }

            public const int lastSortIndex = 100;

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
                var count = 3UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Ammo_Box_Scaling LoadData(BinaryReader reader, ulong i) {
                var data = new Ammo_Box_Scaling();
                data.Index = i;
                data.Ammo_Items_to_Show_raw = reader.ReadByte();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Ammo_Items_to_Show_raw);
            }
        }

        public override void LoadFile(string targetFile) {
            using var reader = new BinaryReader(OpenFile(targetFile, EncryptionKey), Encoding.UTF8);
            data = new LinkedList<MhwStructDataContainer>();
            var Supply_Data_ = new MhwStructDataContainer(Supply_Data.LoadData(reader, null), typeof(Supply_Data));
            data.AddLast(Supply_Data_);
            var Item_Box_ = new MhwStructDataContainer(Item_Box.LoadData(reader, null), typeof(Item_Box));
            data.AddLast(Item_Box_);
            var Item_Box_Scaling_ = new MhwStructDataContainer(Item_Box_Scaling.LoadData(reader, null), typeof(Item_Box_Scaling));
            data.AddLast(Item_Box_Scaling_);
            var Ammo_Box_ = new MhwStructDataContainer(Ammo_Box.LoadData(reader, null), typeof(Ammo_Box));
            data.AddLast(Ammo_Box_);
            var Ammo_Box_Scaling_ = new MhwStructDataContainer(Ammo_Box_Scaling.LoadData(reader, null), typeof(Ammo_Box_Scaling));
            data.AddLast(Ammo_Box_Scaling_);
        }
    }
}
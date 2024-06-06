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
    public partial class BonusReward {
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
                    ChangedItems.Add(nameof(Magic_2));
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
                    ChangedItems.Add(nameof(Magic_3));
                    OnPropertyChanged(nameof(Magic_3));
                }
            }

            protected uint Monster_Ingame_Id_raw;
            public const string Monster_Ingame_Id_displayName = "Monster Ingame Id";
            public const int Monster_Ingame_Id_sortIndex = 200;
            [SortOrder(Monster_Ingame_Id_sortIndex)]
            [DisplayName(Monster_Ingame_Id_displayName)]
            [IsReadOnly]
            public virtual uint Monster_Ingame_Id {
                get => Monster_Ingame_Id_raw;
                set {
                    if (Monster_Ingame_Id_raw == value) return;
                    Monster_Ingame_Id_raw = value;
                    ChangedItems.Add(nameof(Monster_Ingame_Id));
                    OnPropertyChanged(nameof(Monster_Ingame_Id));
                }
            }

            protected byte Part_Id__raw;
            public const string Part_Id__displayName = "Part Id (?)";
            public const int Part_Id__sortIndex = 250;
            [SortOrder(Part_Id__sortIndex)]
            [DisplayName(Part_Id__displayName)]
            [IsReadOnly]
            public virtual byte Part_Id_ {
                get => Part_Id__raw;
                set {
                    if (Part_Id__raw == value) return;
                    Part_Id__raw = value;
                    ChangedItems.Add(nameof(Part_Id_));
                    OnPropertyChanged(nameof(Part_Id_));
                }
            }

            protected uint Magic_4_raw;
            public const string Magic_4_displayName = "Magic 4";
            public const int Magic_4_sortIndex = 300;
            [SortOrder(Magic_4_sortIndex)]
            [DisplayName(Magic_4_displayName)]
            [IsReadOnly]
            public virtual uint Magic_4 {
                get => Magic_4_raw;
                set {
                    if (Magic_4_raw == value) return;
                    Magic_4_raw = value;
                    ChangedItems.Add(nameof(Magic_4));
                    OnPropertyChanged(nameof(Magic_4));
                }
            }

            public const int lastSortIndex = 350;

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
                data.Magic_2_raw = reader.ReadUInt32();
                data.Magic_3_raw = reader.ReadUInt16();
                data.Monster_Ingame_Id_raw = reader.ReadUInt32();
                data.Part_Id__raw = reader.ReadByte();
                data.Magic_4_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Magic_1_raw);
                writer.Write(Magic_2_raw);
                writer.Write(Magic_3_raw);
                writer.Write(Monster_Ingame_Id_raw);
                writer.Write(Part_Id__raw);
                writer.Write(Magic_4_raw);
            }
        }

        public partial class Items : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 8;
            public const string GridName = "Items";

            protected uint Item_Id_raw;
            public const string Item_Id_displayName = "Item Id";
            public const int Item_Id_sortIndex = 50;
            [SortOrder(Item_Id_sortIndex)]
            [DisplayName(Item_Id_displayName)]
            [DataSource(DataSourceType.Items)]
            public virtual uint Item_Id {
                get => Item_Id_raw;
                set {
                    if (Item_Id_raw == value) return;
                    Item_Id_raw = value;
                    ChangedItems.Add(nameof(Item_Id));
                    OnPropertyChanged(nameof(Item_Id));
                    OnPropertyChanged(nameof(Item_Id_button));
                }
            }

            [SortOrder(Item_Id_sortIndex)]
            [DisplayName(Item_Id_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Item_Id_button => DataHelper.itemNames[MainWindow.locale].TryGet(Item_Id).ToStringWithId(Item_Id);

            public const int lastSortIndex = 100;

            public static ObservableMhwStructCollection<Items> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Items>();
                const ulong count = 8UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Items LoadData(BinaryReader reader, ulong i) {
                var data = new Items();
                data.Index = i;
                data.Item_Id_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Item_Id_raw);
            }
        }

        public partial class Counts : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 8;
            public const string GridName = "Counts";

            protected byte Item_Count_raw;
            public const string Item_Count_displayName = "Item Count";
            public const int Item_Count_sortIndex = 50;
            [SortOrder(Item_Count_sortIndex)]
            [DisplayName(Item_Count_displayName)]
            public virtual byte Item_Count {
                get => Item_Count_raw;
                set {
                    if (Item_Count_raw == value) return;
                    Item_Count_raw = value;
                    ChangedItems.Add(nameof(Item_Count));
                    OnPropertyChanged(nameof(Item_Count));
                }
            }

            public const int lastSortIndex = 100;

            public static ObservableMhwStructCollection<Counts> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Counts>();
                const ulong count = 8UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Counts LoadData(BinaryReader reader, ulong i) {
                var data = new Counts();
                data.Index = i;
                data.Item_Count_raw = reader.ReadByte();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Item_Count_raw);
            }
        }

        public partial class Weights : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 8;
            public const string GridName = "Weights";

            protected byte Item_Weight_raw;
            public const string Item_Weight_displayName = "Item Weight";
            public const int Item_Weight_sortIndex = 50;
            [SortOrder(Item_Weight_sortIndex)]
            [DisplayName(Item_Weight_displayName)]
            public virtual byte Item_Weight {
                get => Item_Weight_raw;
                set {
                    if (Item_Weight_raw == value) return;
                    Item_Weight_raw = value;
                    ChangedItems.Add(nameof(Item_Weight));
                    OnPropertyChanged(nameof(Item_Weight));
                }
            }

            public const int lastSortIndex = 100;

            public static ObservableMhwStructCollection<Weights> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Weights>();
                const ulong count = 8UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Weights LoadData(BinaryReader reader, ulong i) {
                var data = new Weights();
                data.Index = i;
                data.Item_Weight_raw = reader.ReadByte();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Item_Weight_raw);
            }
        }

        public override void LoadFile(string targetFile) {
            using var reader = new BinaryReader(OpenFile(targetFile, EncryptionKey), Encoding.UTF8);
            data = new LinkedList<MhwStructDataContainer>();
            var Header_ = new MhwStructDataContainer<Header>(Header.LoadData(reader), typeof(Header));
            data.AddLast(Header_);
            var Items_ = new MhwStructDataContainer<Items>(Items.LoadData(reader), typeof(Items));
            data.AddLast(Items_);
            var Counts_ = new MhwStructDataContainer<Counts>(Counts.LoadData(reader), typeof(Counts));
            data.AddLast(Counts_);
            var Weights_ = new MhwStructDataContainer<Weights>(Weights.LoadData(reader), typeof(Weights));
            data.AddLast(Weights_);
        }
    }
}
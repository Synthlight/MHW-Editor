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
    public partial class ItemMake {
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
            public override string UniqueId => $"{Id}";
            public const bool IsAddingAllowed = true;

            [SortOrder(-1)]
            [IsReadOnly]
            [DisplayName("X")]
            public string Delete => "X";

            protected uint Id_raw;
            public const string Id_displayName = "Id";
            public const int Id_sortIndex = 50;
            [SortOrder(Id_sortIndex)]
            [DisplayName(Id_displayName)]
            [IsReadOnly]
            public virtual uint Id {
                get => Id_raw;
                set {
                    if (Id_raw == value) return;
                    Id_raw = value;
                    ChangedItems.Add(nameof(Id));
                    OnPropertyChanged(nameof(Id));
                }
            }

            protected ushort Unk1_raw;
            public const string Unk1_displayName = "Unk1";
            public const int Unk1_sortIndex = 100;
            [SortOrder(Unk1_sortIndex)]
            [DisplayName(Unk1_displayName)]
            public virtual ushort Unk1 {
                get => Unk1_raw;
                set {
                    if (Unk1_raw == value) return;
                    Unk1_raw = value;
                    ChangedItems.Add(nameof(Unk1));
                    OnPropertyChanged(nameof(Unk1));
                }
            }

            protected uint Mat_1_Id_raw;
            public const string Mat_1_Id_displayName = "Mat 1 Id";
            public const int Mat_1_Id_sortIndex = 150;
            [SortOrder(Mat_1_Id_sortIndex)]
            [DisplayName(Mat_1_Id_displayName)]
            [DataSource(DataSourceType.Items)]
            public virtual uint Mat_1_Id {
                get => Mat_1_Id_raw;
                set {
                    if (Mat_1_Id_raw == value) return;
                    Mat_1_Id_raw = value;
                    ChangedItems.Add(nameof(Mat_1_Id));
                    OnPropertyChanged(nameof(Mat_1_Id));
                    OnPropertyChanged(nameof(Mat_1_Id_button));
                }
            }

            [SortOrder(Mat_1_Id_sortIndex)]
            [DisplayName(Mat_1_Id_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Mat_1_Id_button => DataHelper.itemNames[MainWindow.locale].TryGet(Mat_1_Id).ToStringWithId(Mat_1_Id);

            protected uint Mat_2_Id_raw;
            public const string Mat_2_Id_displayName = "Mat 2 Id";
            public const int Mat_2_Id_sortIndex = 200;
            [SortOrder(Mat_2_Id_sortIndex)]
            [DisplayName(Mat_2_Id_displayName)]
            [DataSource(DataSourceType.Items)]
            public virtual uint Mat_2_Id {
                get => Mat_2_Id_raw;
                set {
                    if (Mat_2_Id_raw == value) return;
                    Mat_2_Id_raw = value;
                    ChangedItems.Add(nameof(Mat_2_Id));
                    OnPropertyChanged(nameof(Mat_2_Id));
                    OnPropertyChanged(nameof(Mat_2_Id_button));
                }
            }

            [SortOrder(Mat_2_Id_sortIndex)]
            [DisplayName(Mat_2_Id_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Mat_2_Id_button => DataHelper.itemNames[MainWindow.locale].TryGet(Mat_2_Id).ToStringWithId(Mat_2_Id);

            protected uint Result_Id_raw;
            public const string Result_Id_displayName = "Result Id";
            public const int Result_Id_sortIndex = 250;
            [SortOrder(Result_Id_sortIndex)]
            [DisplayName(Result_Id_displayName)]
            [DataSource(DataSourceType.Items)]
            public virtual uint Result_Id {
                get => Result_Id_raw;
                set {
                    if (Result_Id_raw == value) return;
                    Result_Id_raw = value;
                    ChangedItems.Add(nameof(Result_Id));
                    OnPropertyChanged(nameof(Result_Id));
                    OnPropertyChanged(nameof(Result_Id_button));
                }
            }

            [SortOrder(Result_Id_sortIndex)]
            [DisplayName(Result_Id_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Result_Id_button => DataHelper.itemNames[MainWindow.locale].TryGet(Result_Id).ToStringWithId(Result_Id);

            protected uint Quantity_raw;
            public const string Quantity_displayName = "Quantity";
            public const int Quantity_sortIndex = 300;
            [SortOrder(Quantity_sortIndex)]
            [DisplayName(Quantity_displayName)]
            public virtual uint Quantity {
                get => Quantity_raw;
                set {
                    if (Quantity_raw == value) return;
                    Quantity_raw = value;
                    ChangedItems.Add(nameof(Quantity));
                    OnPropertyChanged(nameof(Quantity));
                }
            }

            protected uint Unk2_raw;
            public const string Unk2_displayName = "Unk2";
            public const int Unk2_sortIndex = 350;
            [SortOrder(Unk2_sortIndex)]
            [DisplayName(Unk2_displayName)]
            public virtual uint Unk2 {
                get => Unk2_raw;
                set {
                    if (Unk2_raw == value) return;
                    Unk2_raw = value;
                    ChangedItems.Add(nameof(Unk2));
                    OnPropertyChanged(nameof(Unk2));
                }
            }

            protected uint Category_raw;
            public const string Category_displayName = "Category";
            public const int Category_sortIndex = 400;
            [SortOrder(Category_sortIndex)]
            [DisplayName(Category_displayName)]
            public virtual MHW_Template.Items.ItemCategory Category {
                get => (MHW_Template.Items.ItemCategory) Category_raw;
                set {
                    if ((MHW_Template.Items.ItemCategory) Category_raw == value) return;
                    Category_raw = (uint) value;
                    ChangedItems.Add(nameof(Category));
                    OnPropertyChanged(nameof(Category));
                }
            }

            protected byte Can_Auto_Craft_raw;
            public const string Can_Auto_Craft_displayName = "Can Auto-Craft";
            public const int Can_Auto_Craft_sortIndex = 450;
            [SortOrder(Can_Auto_Craft_sortIndex)]
            [DisplayName(Can_Auto_Craft_displayName)]
            public virtual bool Can_Auto_Craft {
                get => (bool) Convert.ToBoolean(Can_Auto_Craft_raw);
                set {
                    if (Convert.ToBoolean(Can_Auto_Craft_raw) == value) return;
                    Can_Auto_Craft_raw = Convert.ToByte(value);
                    ChangedItems.Add(nameof(Can_Auto_Craft));
                    OnPropertyChanged(nameof(Can_Auto_Craft));
                }
            }

            public const int lastSortIndex = 500;

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
                data.Id_raw = reader.ReadUInt32();
                data.Unk1_raw = reader.ReadUInt16();
                data.Mat_1_Id_raw = reader.ReadUInt32();
                data.Mat_2_Id_raw = reader.ReadUInt32();
                data.Result_Id_raw = reader.ReadUInt32();
                data.Quantity_raw = reader.ReadUInt32();
                data.Unk2_raw = reader.ReadUInt32();
                data.Category_raw = reader.ReadUInt32();
                data.Can_Auto_Craft_raw = reader.ReadByte();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Id_raw);
                writer.Write(Unk1_raw);
                writer.Write(Mat_1_Id_raw);
                writer.Write(Mat_2_Id_raw);
                writer.Write(Result_Id_raw);
                writer.Write(Quantity_raw);
                writer.Write(Unk2_raw);
                writer.Write(Category_raw);
                writer.Write(Can_Auto_Craft_raw);
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
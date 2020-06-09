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
    public partial class NewLimitBreakR {
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
            public override string UniqueId => "{Id_1}|{Id_2}";

            protected ushort Id_1_raw;
            public const string Id_1_displayName = "Id 1";
            public const int Id_1_sortIndex = 50;
            [SortOrder(Id_1_sortIndex)]
            [DisplayName(Id_1_displayName)]
            [IsReadOnly]
            public virtual ushort Id_1 {
                get => Id_1_raw;
                set {
                    if (Id_1_raw == value) return;
                    Id_1_raw = value;
                    OnPropertyChanged(nameof(Id_1));
                }
            }

            protected ushort Id_2_raw;
            public const string Id_2_displayName = "Id 2";
            public const int Id_2_sortIndex = 100;
            [SortOrder(Id_2_sortIndex)]
            [DisplayName(Id_2_displayName)]
            [IsReadOnly]
            public virtual ushort Id_2 {
                get => Id_2_raw;
                set {
                    if (Id_2_raw == value) return;
                    Id_2_raw = value;
                    OnPropertyChanged(nameof(Id_2));
                }
            }

            protected ushort Needed_Item_Id_to_Unlock_raw;
            public const string Needed_Item_Id_to_Unlock_displayName = "Needed Item Id to Unlock";
            public const int Needed_Item_Id_to_Unlock_sortIndex = 150;
            [SortOrder(Needed_Item_Id_to_Unlock_sortIndex)]
            [DisplayName(Needed_Item_Id_to_Unlock_displayName)]
            [DataSource(DataSourceType.Items)]
            public virtual ushort Needed_Item_Id_to_Unlock {
                get => Needed_Item_Id_to_Unlock_raw;
                set {
                    if (Needed_Item_Id_to_Unlock_raw == value) return;
                    Needed_Item_Id_to_Unlock_raw = value;
                    OnPropertyChanged(nameof(Needed_Item_Id_to_Unlock));
                    OnPropertyChanged(nameof(Needed_Item_Id_to_Unlock_button));
                }
            }

            [SortOrder(Needed_Item_Id_to_Unlock_sortIndex)]
            [DisplayName(Needed_Item_Id_to_Unlock_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Needed_Item_Id_to_Unlock_button => DataHelper.itemNames[MainWindow.locale].TryGet(Needed_Item_Id_to_Unlock).ToStringWithId(Needed_Item_Id_to_Unlock);

            protected int Unk_1_raw;
            public const string Unk_1_displayName = "Unk 1";
            public const int Unk_1_sortIndex = 200;
            [SortOrder(Unk_1_sortIndex)]
            [DisplayName(Unk_1_displayName)]
            public virtual int Unk_1 {
                get => Unk_1_raw;
                set {
                    if (Unk_1_raw == value) return;
                    Unk_1_raw = value;
                    OnPropertyChanged(nameof(Unk_1));
                }
            }

            protected int Unk_2_raw;
            public const string Unk_2_displayName = "Unk 2";
            public const int Unk_2_sortIndex = 250;
            [SortOrder(Unk_2_sortIndex)]
            [DisplayName(Unk_2_displayName)]
            public virtual int Unk_2 {
                get => Unk_2_raw;
                set {
                    if (Unk_2_raw == value) return;
                    Unk_2_raw = value;
                    OnPropertyChanged(nameof(Unk_2));
                }
            }

            protected ushort Mat_1_Id_raw;
            public const string Mat_1_Id_displayName = "Mat 1 Id";
            public const int Mat_1_Id_sortIndex = 300;
            [SortOrder(Mat_1_Id_sortIndex)]
            [DisplayName(Mat_1_Id_displayName)]
            [DataSource(DataSourceType.Items)]
            public virtual ushort Mat_1_Id {
                get => Mat_1_Id_raw;
                set {
                    if (Mat_1_Id_raw == value) return;
                    Mat_1_Id_raw = value;
                    OnPropertyChanged(nameof(Mat_1_Id));
                    OnPropertyChanged(nameof(Mat_1_Id_button));
                }
            }

            [SortOrder(Mat_1_Id_sortIndex)]
            [DisplayName(Mat_1_Id_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Mat_1_Id_button => DataHelper.itemNames[MainWindow.locale].TryGet(Mat_1_Id).ToStringWithId(Mat_1_Id);

            protected byte Mat_1_Count_raw;
            public const string Mat_1_Count_displayName = "Mat 1 Count";
            public const int Mat_1_Count_sortIndex = 350;
            [SortOrder(Mat_1_Count_sortIndex)]
            [DisplayName(Mat_1_Count_displayName)]
            public virtual byte Mat_1_Count {
                get => Mat_1_Count_raw;
                set {
                    if (Mat_1_Count_raw == value) return;
                    Mat_1_Count_raw = value;
                    OnPropertyChanged(nameof(Mat_1_Count));
                }
            }

            protected ushort Mat_2_Id_raw;
            public const string Mat_2_Id_displayName = "Mat 2 Id";
            public const int Mat_2_Id_sortIndex = 400;
            [SortOrder(Mat_2_Id_sortIndex)]
            [DisplayName(Mat_2_Id_displayName)]
            [DataSource(DataSourceType.Items)]
            public virtual ushort Mat_2_Id {
                get => Mat_2_Id_raw;
                set {
                    if (Mat_2_Id_raw == value) return;
                    Mat_2_Id_raw = value;
                    OnPropertyChanged(nameof(Mat_2_Id));
                    OnPropertyChanged(nameof(Mat_2_Id_button));
                }
            }

            [SortOrder(Mat_2_Id_sortIndex)]
            [DisplayName(Mat_2_Id_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Mat_2_Id_button => DataHelper.itemNames[MainWindow.locale].TryGet(Mat_2_Id).ToStringWithId(Mat_2_Id);

            protected byte Mat_2_Count_raw;
            public const string Mat_2_Count_displayName = "Mat 2 Count";
            public const int Mat_2_Count_sortIndex = 450;
            [SortOrder(Mat_2_Count_sortIndex)]
            [DisplayName(Mat_2_Count_displayName)]
            public virtual byte Mat_2_Count {
                get => Mat_2_Count_raw;
                set {
                    if (Mat_2_Count_raw == value) return;
                    Mat_2_Count_raw = value;
                    OnPropertyChanged(nameof(Mat_2_Count));
                }
            }

            protected ushort Mat_3_Id_raw;
            public const string Mat_3_Id_displayName = "Mat 3 Id";
            public const int Mat_3_Id_sortIndex = 500;
            [SortOrder(Mat_3_Id_sortIndex)]
            [DisplayName(Mat_3_Id_displayName)]
            [DataSource(DataSourceType.Items)]
            public virtual ushort Mat_3_Id {
                get => Mat_3_Id_raw;
                set {
                    if (Mat_3_Id_raw == value) return;
                    Mat_3_Id_raw = value;
                    OnPropertyChanged(nameof(Mat_3_Id));
                    OnPropertyChanged(nameof(Mat_3_Id_button));
                }
            }

            [SortOrder(Mat_3_Id_sortIndex)]
            [DisplayName(Mat_3_Id_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Mat_3_Id_button => DataHelper.itemNames[MainWindow.locale].TryGet(Mat_3_Id).ToStringWithId(Mat_3_Id);

            protected byte Mat_3_Count_raw;
            public const string Mat_3_Count_displayName = "Mat 3 Count";
            public const int Mat_3_Count_sortIndex = 550;
            [SortOrder(Mat_3_Count_sortIndex)]
            [DisplayName(Mat_3_Count_displayName)]
            public virtual byte Mat_3_Count {
                get => Mat_3_Count_raw;
                set {
                    if (Mat_3_Count_raw == value) return;
                    Mat_3_Count_raw = value;
                    OnPropertyChanged(nameof(Mat_3_Count));
                }
            }

            protected ushort Mat_4_Id_raw;
            public const string Mat_4_Id_displayName = "Mat 4 Id";
            public const int Mat_4_Id_sortIndex = 600;
            [SortOrder(Mat_4_Id_sortIndex)]
            [DisplayName(Mat_4_Id_displayName)]
            [DataSource(DataSourceType.Items)]
            public virtual ushort Mat_4_Id {
                get => Mat_4_Id_raw;
                set {
                    if (Mat_4_Id_raw == value) return;
                    Mat_4_Id_raw = value;
                    OnPropertyChanged(nameof(Mat_4_Id));
                    OnPropertyChanged(nameof(Mat_4_Id_button));
                }
            }

            [SortOrder(Mat_4_Id_sortIndex)]
            [DisplayName(Mat_4_Id_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Mat_4_Id_button => DataHelper.itemNames[MainWindow.locale].TryGet(Mat_4_Id).ToStringWithId(Mat_4_Id);

            protected byte Mat_4_Count_raw;
            public const string Mat_4_Count_displayName = "Mat 4 Count";
            public const int Mat_4_Count_sortIndex = 650;
            [SortOrder(Mat_4_Count_sortIndex)]
            [DisplayName(Mat_4_Count_displayName)]
            public virtual byte Mat_4_Count {
                get => Mat_4_Count_raw;
                set {
                    if (Mat_4_Count_raw == value) return;
                    Mat_4_Count_raw = value;
                    OnPropertyChanged(nameof(Mat_4_Count));
                }
            }

            protected uint Unk_3_raw;
            public const string Unk_3_displayName = "Unk 3";
            public const int Unk_3_sortIndex = 700;
            [SortOrder(Unk_3_sortIndex)]
            [DisplayName(Unk_3_displayName)]
            public virtual uint Unk_3 {
                get => Unk_3_raw;
                set {
                    if (Unk_3_raw == value) return;
                    Unk_3_raw = value;
                    OnPropertyChanged(nameof(Unk_3));
                }
            }

            protected uint Unk_4_raw;
            public const string Unk_4_displayName = "Unk 4";
            public const int Unk_4_sortIndex = 750;
            [SortOrder(Unk_4_sortIndex)]
            [DisplayName(Unk_4_displayName)]
            public virtual uint Unk_4 {
                get => Unk_4_raw;
                set {
                    if (Unk_4_raw == value) return;
                    Unk_4_raw = value;
                    OnPropertyChanged(nameof(Unk_4));
                }
            }

            protected ushort Unk_5_raw;
            public const string Unk_5_displayName = "Unk 5";
            public const int Unk_5_sortIndex = 800;
            [SortOrder(Unk_5_sortIndex)]
            [DisplayName(Unk_5_displayName)]
            public virtual ushort Unk_5 {
                get => Unk_5_raw;
                set {
                    if (Unk_5_raw == value) return;
                    Unk_5_raw = value;
                    OnPropertyChanged(nameof(Unk_5));
                }
            }

            protected byte Unk_6_raw;
            public const string Unk_6_displayName = "Unk 6";
            public const int Unk_6_sortIndex = 850;
            [SortOrder(Unk_6_sortIndex)]
            [DisplayName(Unk_6_displayName)]
            public virtual byte Unk_6 {
                get => Unk_6_raw;
                set {
                    if (Unk_6_raw == value) return;
                    Unk_6_raw = value;
                    OnPropertyChanged(nameof(Unk_6));
                }
            }

            protected byte Unk_7_raw;
            public const string Unk_7_displayName = "Unk 7";
            public const int Unk_7_sortIndex = 900;
            [SortOrder(Unk_7_sortIndex)]
            [DisplayName(Unk_7_displayName)]
            public virtual byte Unk_7 {
                get => Unk_7_raw;
                set {
                    if (Unk_7_raw == value) return;
                    Unk_7_raw = value;
                    OnPropertyChanged(nameof(Unk_7));
                }
            }

            public const int lastSortIndex = 950;

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
                data.Id_1_raw = reader.ReadUInt16();
                data.Id_2_raw = reader.ReadUInt16();
                data.Needed_Item_Id_to_Unlock_raw = reader.ReadUInt16();
                data.Unk_1_raw = reader.ReadInt32();
                data.Unk_2_raw = reader.ReadInt32();
                data.Mat_1_Id_raw = reader.ReadUInt16();
                data.Mat_1_Count_raw = reader.ReadByte();
                data.Mat_2_Id_raw = reader.ReadUInt16();
                data.Mat_2_Count_raw = reader.ReadByte();
                data.Mat_3_Id_raw = reader.ReadUInt16();
                data.Mat_3_Count_raw = reader.ReadByte();
                data.Mat_4_Id_raw = reader.ReadUInt16();
                data.Mat_4_Count_raw = reader.ReadByte();
                data.Unk_3_raw = reader.ReadUInt32();
                data.Unk_4_raw = reader.ReadUInt32();
                data.Unk_5_raw = reader.ReadUInt16();
                data.Unk_6_raw = reader.ReadByte();
                data.Unk_7_raw = reader.ReadByte();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Id_1_raw);
                writer.Write(Id_2_raw);
                writer.Write(Needed_Item_Id_to_Unlock_raw);
                writer.Write(Unk_1_raw);
                writer.Write(Unk_2_raw);
                writer.Write(Mat_1_Id_raw);
                writer.Write(Mat_1_Count_raw);
                writer.Write(Mat_2_Id_raw);
                writer.Write(Mat_2_Count_raw);
                writer.Write(Mat_3_Id_raw);
                writer.Write(Mat_3_Count_raw);
                writer.Write(Mat_4_Id_raw);
                writer.Write(Mat_4_Count_raw);
                writer.Write(Unk_3_raw);
                writer.Write(Unk_4_raw);
                writer.Write(Unk_5_raw);
                writer.Write(Unk_6_raw);
                writer.Write(Unk_7_raw);
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
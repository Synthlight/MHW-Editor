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

namespace MHW_Editor.Structs.Armors {
    public partial class ASkill {
        public override string EncryptionKey => null;

        public partial class Header : MhwStructItem {
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

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
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

        public partial class Entries : MhwStructItem {
            public const ulong FixedSizeCount = 0;
            public const string GridName = "Entries";
            public override string UniqueId => "{Mantle_Id}";

            protected uint Icon_Id_raw;
            public const string Icon_Id_displayName = "Icon Id";
            public const int Icon_Id_sortIndex = 50;
            [SortOrder(Icon_Id_sortIndex)]
            [DisplayName(Icon_Id_displayName)]
            public virtual uint Icon_Id {
                get => Icon_Id_raw;
                set {
                    if (Icon_Id_raw == value) return;
                    Icon_Id_raw = value;
                    OnPropertyChanged(nameof(Icon_Id));
                }
            }

            protected uint Color_raw;
            public const string Color_displayName = "Color";
            public const int Color_sortIndex = 100;
            [SortOrder(Color_sortIndex)]
            [DisplayName(Color_displayName)]
            public virtual uint Color {
                get => Color_raw;
                set {
                    if (Color_raw == value) return;
                    Color_raw = value;
                    OnPropertyChanged(nameof(Color));
                }
            }

            protected uint Sort_Order_raw;
            public const string Sort_Order_displayName = "Sort Order";
            public const int Sort_Order_sortIndex = 150;
            [SortOrder(Sort_Order_sortIndex)]
            [DisplayName(Sort_Order_displayName)]
            public virtual uint Sort_Order {
                get => Sort_Order_raw;
                set {
                    if (Sort_Order_raw == value) return;
                    Sort_Order_raw = value;
                    OnPropertyChanged(nameof(Sort_Order));
                }
            }

            protected uint Mantle_Item_Id_raw;
            public const string Mantle_Item_Id_displayName = "Mantle Item Id";
            public const int Mantle_Item_Id_sortIndex = 200;
            [SortOrder(Mantle_Item_Id_sortIndex)]
            [DisplayName(Mantle_Item_Id_displayName)]
            [DataSource(DataSourceType.Items)]
            public virtual uint Mantle_Item_Id {
                get => Mantle_Item_Id_raw;
                set {
                    if (Mantle_Item_Id_raw == value) return;
                    Mantle_Item_Id_raw = value;
                    OnPropertyChanged(nameof(Mantle_Item_Id));
                    OnPropertyChanged(nameof(Mantle_Item_Id_button));
                }
            }

            [SortOrder(Mantle_Item_Id_sortIndex)]
            [DisplayName(Mantle_Item_Id_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Mantle_Item_Id_button => DataHelper.itemNames[MainWindow.locale].TryGet(Mantle_Item_Id).ToStringWithId(Mantle_Item_Id);

            protected uint Mantle_Id_raw;
            public const string Mantle_Id_displayName = "Mantle Id";
            [SortOrder(Mantle_Id_sortIndex)]
            [DisplayName(Mantle_Id_displayName)]
            [IsReadOnly]
            public virtual uint Mantle_Id {
                get => Mantle_Id_raw;
                set {
                    if (Mantle_Id_raw == value) return;
                    Mantle_Id_raw = value;
                    OnPropertyChanged(nameof(Mantle_Id));
                }
            }

            protected uint Unlock_Flag_or_Item_Id__raw;
            public const string Unlock_Flag_or_Item_Id__displayName = "Unlock Flag or Item Id?";
            public const int Unlock_Flag_or_Item_Id__sortIndex = 300;
            [SortOrder(Unlock_Flag_or_Item_Id__sortIndex)]
            [DisplayName(Unlock_Flag_or_Item_Id__displayName)]
            public virtual uint Unlock_Flag_or_Item_Id_ {
                get => Unlock_Flag_or_Item_Id__raw;
                set {
                    if (Unlock_Flag_or_Item_Id__raw == value) return;
                    Unlock_Flag_or_Item_Id__raw = value;
                    OnPropertyChanged(nameof(Unlock_Flag_or_Item_Id_));
                }
            }

            protected byte Deco_Count_raw;
            public const string Deco_Count_displayName = "Deco Count";
            public const int Deco_Count_sortIndex = 350;
            [SortOrder(Deco_Count_sortIndex)]
            [DisplayName(Deco_Count_displayName)]
            public virtual byte Deco_Count {
                get => Deco_Count_raw;
                set {
                    if (Deco_Count_raw == value) return;
                    Deco_Count_raw = value;
                    OnPropertyChanged(nameof(Deco_Count));
                }
            }

            protected byte Deco_Lvl_1_raw;
            public const string Deco_Lvl_1_displayName = "Deco Lvl 1";
            public const int Deco_Lvl_1_sortIndex = 400;
            [SortOrder(Deco_Lvl_1_sortIndex)]
            [DisplayName(Deco_Lvl_1_displayName)]
            public virtual byte Deco_Lvl_1 {
                get => Deco_Lvl_1_raw;
                set {
                    if (Deco_Lvl_1_raw == value) return;
                    Deco_Lvl_1_raw = value;
                    OnPropertyChanged(nameof(Deco_Lvl_1));
                }
            }

            protected byte Deco_Lvl_2_raw;
            public const string Deco_Lvl_2_displayName = "Deco Lvl 2";
            public const int Deco_Lvl_2_sortIndex = 450;
            [SortOrder(Deco_Lvl_2_sortIndex)]
            [DisplayName(Deco_Lvl_2_displayName)]
            public virtual byte Deco_Lvl_2 {
                get => Deco_Lvl_2_raw;
                set {
                    if (Deco_Lvl_2_raw == value) return;
                    Deco_Lvl_2_raw = value;
                    OnPropertyChanged(nameof(Deco_Lvl_2));
                }
            }

            protected byte Deco_Lvl_3_raw;
            public const string Deco_Lvl_3_displayName = "Deco Lvl 3";
            public const int Deco_Lvl_3_sortIndex = 500;
            [SortOrder(Deco_Lvl_3_sortIndex)]
            [DisplayName(Deco_Lvl_3_displayName)]
            public virtual byte Deco_Lvl_3 {
                get => Deco_Lvl_3_raw;
                set {
                    if (Deco_Lvl_3_raw == value) return;
                    Deco_Lvl_3_raw = value;
                    OnPropertyChanged(nameof(Deco_Lvl_3));
                }
            }

            public const int lastSortIndex = 550;

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
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
                data.Icon_Id_raw = reader.ReadUInt32();
                data.Color_raw = reader.ReadUInt32();
                data.Sort_Order_raw = reader.ReadUInt32();
                data.Mantle_Item_Id_raw = reader.ReadUInt32();
                data.Mantle_Id_raw = reader.ReadUInt32();
                data.Unlock_Flag_or_Item_Id__raw = reader.ReadUInt32();
                data.Deco_Count_raw = reader.ReadByte();
                data.Deco_Lvl_1_raw = reader.ReadByte();
                data.Deco_Lvl_2_raw = reader.ReadByte();
                data.Deco_Lvl_3_raw = reader.ReadByte();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Icon_Id_raw);
                writer.Write(Color_raw);
                writer.Write(Sort_Order_raw);
                writer.Write(Mantle_Item_Id_raw);
                writer.Write(Mantle_Id_raw);
                writer.Write(Unlock_Flag_or_Item_Id__raw);
                writer.Write(Deco_Count_raw);
                writer.Write(Deco_Lvl_1_raw);
                writer.Write(Deco_Lvl_2_raw);
                writer.Write(Deco_Lvl_3_raw);
            }
        }

        public override void LoadFile(string targetFile) {
            using var reader = new BinaryReader(OpenFile(targetFile, EncryptionKey), Encoding.UTF8);
            data = new LinkedList<MhwStructDataContainer>();
            var Header_ = new MhwStructDataContainer(Header.LoadData(reader, null), typeof(Header));
            data.AddLast(Header_);
            var Entries_ = new MhwStructDataContainer(Entries.LoadData(reader, Header_.list), typeof(Entries));
            Entries_.SetCountTargetToUpdate(Header_, -1, "Entry_Count");
            data.AddLast(Entries_);
        }
    }
}
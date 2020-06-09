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
    public partial class LimitBreakMaterialBase {
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

            protected byte Rarity_raw;
            public const string Rarity_displayName = "Rarity";
            public const int Rarity_sortIndex = 50;
            [SortOrder(Rarity_sortIndex)]
            [DisplayName(Rarity_displayName)]
            public virtual byte Rarity {
                get => Rarity_raw;
                set {
                    if (Rarity_raw == value) return;
                    Rarity_raw = value;
                    OnPropertyChanged(nameof(Rarity));
                }
            }

            protected byte Equip_Type_raw;
            public const string Equip_Type_displayName = "Equip Type";
            public const int Equip_Type_sortIndex = 100;
            [SortOrder(Equip_Type_sortIndex)]
            [DisplayName(Equip_Type_displayName)]
            public virtual MHW_Template.Weapons.WeaponType Equip_Type {
                get => (MHW_Template.Weapons.WeaponType) Equip_Type_raw;
                set {
                    if ((MHW_Template.Weapons.WeaponType) Equip_Type_raw == value) return;
                    Equip_Type_raw = (byte) value;
                    OnPropertyChanged(nameof(Equip_Type));
                }
            }

            protected uint Cost_raw;
            public const string Cost_displayName = "Cost";
            public const int Cost_sortIndex = 150;
            [SortOrder(Cost_sortIndex)]
            [DisplayName(Cost_displayName)]
            public virtual uint Cost {
                get => Cost_raw;
                set {
                    if (Cost_raw == value) return;
                    Cost_raw = value;
                    OnPropertyChanged(nameof(Cost));
                }
            }

            protected ushort Item_1_Id_raw;
            public const string Item_1_Id_displayName = "Item 1 Id";
            public const int Item_1_Id_sortIndex = 200;
            [SortOrder(Item_1_Id_sortIndex)]
            [DisplayName(Item_1_Id_displayName)]
            [DataSource(DataSourceType.Items)]
            public virtual ushort Item_1_Id {
                get => Item_1_Id_raw;
                set {
                    if (Item_1_Id_raw == value) return;
                    Item_1_Id_raw = value;
                    OnPropertyChanged(nameof(Item_1_Id));
                    OnPropertyChanged(nameof(Item_1_Id_button));
                }
            }

            [SortOrder(Item_1_Id_sortIndex)]
            [DisplayName(Item_1_Id_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Item_1_Id_button => DataHelper.itemNames[MainWindow.locale].TryGet(Item_1_Id).ToStringWithId(Item_1_Id);

            protected ushort Item_1_Cnt_raw;
            public const string Item_1_Cnt_displayName = "Item 1 Cnt";
            public const int Item_1_Cnt_sortIndex = 250;
            [SortOrder(Item_1_Cnt_sortIndex)]
            [DisplayName(Item_1_Cnt_displayName)]
            public virtual ushort Item_1_Cnt {
                get => Item_1_Cnt_raw;
                set {
                    if (Item_1_Cnt_raw == value) return;
                    Item_1_Cnt_raw = value;
                    OnPropertyChanged(nameof(Item_1_Cnt));
                }
            }

            protected ushort Item_2_Id_raw;
            public const string Item_2_Id_displayName = "Item 2 Id";
            public const int Item_2_Id_sortIndex = 300;
            [SortOrder(Item_2_Id_sortIndex)]
            [DisplayName(Item_2_Id_displayName)]
            [DataSource(DataSourceType.Items)]
            public virtual ushort Item_2_Id {
                get => Item_2_Id_raw;
                set {
                    if (Item_2_Id_raw == value) return;
                    Item_2_Id_raw = value;
                    OnPropertyChanged(nameof(Item_2_Id));
                    OnPropertyChanged(nameof(Item_2_Id_button));
                }
            }

            [SortOrder(Item_2_Id_sortIndex)]
            [DisplayName(Item_2_Id_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Item_2_Id_button => DataHelper.itemNames[MainWindow.locale].TryGet(Item_2_Id).ToStringWithId(Item_2_Id);

            protected ushort Item_2_Cnt_raw;
            public const string Item_2_Cnt_displayName = "Item 2 Cnt";
            public const int Item_2_Cnt_sortIndex = 350;
            [SortOrder(Item_2_Cnt_sortIndex)]
            [DisplayName(Item_2_Cnt_displayName)]
            public virtual ushort Item_2_Cnt {
                get => Item_2_Cnt_raw;
                set {
                    if (Item_2_Cnt_raw == value) return;
                    Item_2_Cnt_raw = value;
                    OnPropertyChanged(nameof(Item_2_Cnt));
                }
            }

            public const int lastSortIndex = 400;

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
                data.Rarity_raw = reader.ReadByte();
                data.Equip_Type_raw = reader.ReadByte();
                data.Cost_raw = reader.ReadUInt32();
                data.Item_1_Id_raw = reader.ReadUInt16();
                data.Item_1_Cnt_raw = reader.ReadUInt16();
                data.Item_2_Id_raw = reader.ReadUInt16();
                data.Item_2_Cnt_raw = reader.ReadUInt16();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Rarity_raw);
                writer.Write(Equip_Type_raw);
                writer.Write(Cost_raw);
                writer.Write(Item_1_Id_raw);
                writer.Write(Item_1_Cnt_raw);
                writer.Write(Item_2_Id_raw);
                writer.Write(Item_2_Cnt_raw);
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
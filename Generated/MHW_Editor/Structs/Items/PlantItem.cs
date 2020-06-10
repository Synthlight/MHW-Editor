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
    public partial class PlantItem {
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
            public override string UniqueId => $"{Item}";

            protected uint Cultivation_category_raw;
            public const string Cultivation_category_displayName = "Cultivation category";
            public const int Cultivation_category_sortIndex = 50;
            [SortOrder(Cultivation_category_sortIndex)]
            [DisplayName(Cultivation_category_displayName)]
            public virtual MHW_Template.Items.CultivationCategory Cultivation_category {
                get => (MHW_Template.Items.CultivationCategory) Cultivation_category_raw;
                set {
                    if ((MHW_Template.Items.CultivationCategory) Cultivation_category_raw == value) return;
                    Cultivation_category_raw = (uint) value;
                    ChangedItems.Add(nameof(Cultivation_category));
                    OnPropertyChanged(nameof(Cultivation_category));
                }
            }

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

            protected byte Unlocked_from_start_raw;
            public const string Unlocked_from_start_displayName = "Unlocked from start";
            public const int Unlocked_from_start_sortIndex = 150;
            [SortOrder(Unlocked_from_start_sortIndex)]
            [DisplayName(Unlocked_from_start_displayName)]
            public virtual bool Unlocked_from_start {
                get => (bool) Convert.ToBoolean(Unlocked_from_start_raw);
                set {
                    if (Convert.ToBoolean(Unlocked_from_start_raw) == value) return;
                    Unlocked_from_start_raw = Convert.ToByte(value);
                    ChangedItems.Add(nameof(Unlocked_from_start));
                    OnPropertyChanged(nameof(Unlocked_from_start));
                }
            }

            protected uint Item_raw;
            public const string Item_displayName = "Item";
            public const int Item_sortIndex = 200;
            [SortOrder(Item_sortIndex)]
            [DisplayName(Item_displayName)]
            [DataSource(DataSourceType.Items)]
            public virtual uint Item {
                get => Item_raw;
                set {
                    if (Item_raw == value) return;
                    Item_raw = value;
                    ChangedItems.Add(nameof(Item));
                    OnPropertyChanged(nameof(Item));
                    OnPropertyChanged(nameof(Item_button));
                }
            }

            [SortOrder(Item_sortIndex)]
            [DisplayName(Item_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Item_button => DataHelper.itemNames[MainWindow.locale].TryGet(Item).ToStringWithId(Item);

            protected uint Required_time_raw;
            public const string Required_time_displayName = "Required time";
            public const int Required_time_sortIndex = 250;
            [SortOrder(Required_time_sortIndex)]
            [DisplayName(Required_time_displayName)]
            public virtual uint Required_time {
                get => Required_time_raw;
                set {
                    if (Required_time_raw == value) return;
                    Required_time_raw = value;
                    ChangedItems.Add(nameof(Required_time));
                    OnPropertyChanged(nameof(Required_time));
                }
            }

            protected uint Catalyst_time_bonus_raw;
            public const string Catalyst_time_bonus_displayName = "Catalyst time bonus";
            public const int Catalyst_time_bonus_sortIndex = 300;
            [SortOrder(Catalyst_time_bonus_sortIndex)]
            [DisplayName(Catalyst_time_bonus_displayName)]
            public virtual uint Catalyst_time_bonus {
                get => Catalyst_time_bonus_raw;
                set {
                    if (Catalyst_time_bonus_raw == value) return;
                    Catalyst_time_bonus_raw = value;
                    ChangedItems.Add(nameof(Catalyst_time_bonus));
                    OnPropertyChanged(nameof(Catalyst_time_bonus));
                }
            }

            protected uint Unk_2_raw;
            public const string Unk_2_displayName = "Unk 2";
            public const int Unk_2_sortIndex = 350;
            [SortOrder(Unk_2_sortIndex)]
            [DisplayName(Unk_2_displayName)]
            public virtual uint Unk_2 {
                get => Unk_2_raw;
                set {
                    if (Unk_2_raw == value) return;
                    Unk_2_raw = value;
                    ChangedItems.Add(nameof(Unk_2));
                    OnPropertyChanged(nameof(Unk_2));
                }
            }

            protected uint Amount_Base__raw;
            public const string Amount_Base__displayName = "Amount (Base)";
            public const int Amount_Base__sortIndex = 400;
            [SortOrder(Amount_Base__sortIndex)]
            [DisplayName(Amount_Base__displayName)]
            public virtual uint Amount_Base_ {
                get => Amount_Base__raw;
                set {
                    if (Amount_Base__raw == value) return;
                    Amount_Base__raw = value;
                    ChangedItems.Add(nameof(Amount_Base_));
                    OnPropertyChanged(nameof(Amount_Base_));
                }
            }

            protected uint Amount_Plus1__raw;
            public const string Amount_Plus1__displayName = "Amount (+1)";
            public const int Amount_Plus1__sortIndex = 450;
            [SortOrder(Amount_Plus1__sortIndex)]
            [DisplayName(Amount_Plus1__displayName)]
            public virtual uint Amount_Plus1_ {
                get => Amount_Plus1__raw;
                set {
                    if (Amount_Plus1__raw == value) return;
                    Amount_Plus1__raw = value;
                    ChangedItems.Add(nameof(Amount_Plus1_));
                    OnPropertyChanged(nameof(Amount_Plus1_));
                }
            }

            protected uint Amount_Plus2__raw;
            public const string Amount_Plus2__displayName = "Amount (+2)";
            public const int Amount_Plus2__sortIndex = 500;
            [SortOrder(Amount_Plus2__sortIndex)]
            [DisplayName(Amount_Plus2__displayName)]
            public virtual uint Amount_Plus2_ {
                get => Amount_Plus2__raw;
                set {
                    if (Amount_Plus2__raw == value) return;
                    Amount_Plus2__raw = value;
                    ChangedItems.Add(nameof(Amount_Plus2_));
                    OnPropertyChanged(nameof(Amount_Plus2_));
                }
            }

            public const int lastSortIndex = 550;

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
                data.Cultivation_category_raw = reader.ReadUInt32();
                data.Unk_1_raw = reader.ReadUInt32();
                data.Unlocked_from_start_raw = reader.ReadByte();
                data.Item_raw = reader.ReadUInt32();
                data.Required_time_raw = reader.ReadUInt32();
                data.Catalyst_time_bonus_raw = reader.ReadUInt32();
                data.Unk_2_raw = reader.ReadUInt32();
                data.Amount_Base__raw = reader.ReadUInt32();
                data.Amount_Plus1__raw = reader.ReadUInt32();
                data.Amount_Plus2__raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Cultivation_category_raw);
                writer.Write(Unk_1_raw);
                writer.Write(Unlocked_from_start_raw);
                writer.Write(Item_raw);
                writer.Write(Required_time_raw);
                writer.Write(Catalyst_time_bonus_raw);
                writer.Write(Unk_2_raw);
                writer.Write(Amount_Base__raw);
                writer.Write(Amount_Plus1__raw);
                writer.Write(Amount_Plus2__raw);
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
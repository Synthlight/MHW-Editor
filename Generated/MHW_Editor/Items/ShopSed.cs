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
    public partial class ShopSed {
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

            protected uint Equip_Type_raw;
            public const string Equip_Type_displayName = "Equip Type";
            public const int Equip_Type_sortIndex = 50;
            [SortOrder(Equip_Type_sortIndex)]
            [DisplayName(Equip_Type_displayName)]
            public virtual MHW_Template.Items.EquipmentType Equip_Type {
                get => (MHW_Template.Items.EquipmentType) Equip_Type_raw;
                set {
                    if ((MHW_Template.Items.EquipmentType) Equip_Type_raw == value) return;
                    Equip_Type_raw = (uint) value;
                    OnPropertyChanged(nameof(Equip_Type));
                }
            }

            protected uint Equip_Id_raw;
            public const string Equip_Id_displayName = "Equip Id";
            public const int Equip_Id_sortIndex = 100;
            [SortOrder(Equip_Id_sortIndex)]
            [DisplayName(Equip_Id_displayName)]
            [DataSource(DataSourceType.EquipmentById)]
            public virtual uint Equip_Id {
                get => Equip_Id_raw;
                set {
                    if (Equip_Id_raw == value) return;
                    Equip_Id_raw = value;
                    OnPropertyChanged(nameof(Equip_Id));
                    OnPropertyChanged(nameof(Equip_Id_button));
                }
            }

            [SortOrder(Equip_Id_sortIndex)]
            [DisplayName(Equip_Id_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Equip_Id_button => DataHelper.equipmentIdNameLookup[GetEquipmentType()][MainWindow.locale].TryGet(Equip_Id).ToStringWithId(Equip_Id);

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

            public const int lastSortIndex = 200;

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
                data.Equip_Type_raw = reader.ReadUInt32();
                data.Equip_Id_raw = reader.ReadUInt32();
                data.Story_Unlock_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Equip_Type_raw);
                writer.Write(Equip_Id_raw);
                writer.Write(Story_Unlock_raw);
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
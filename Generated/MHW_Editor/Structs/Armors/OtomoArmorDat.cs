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
    public partial class OtomoArmorDat {
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
            public override string UniqueId => "{Set_Id}|{Variant}|{Equip_Slot}";

            protected uint Index_raw;
            public const string Index_displayName = "Index";
            public const int Index_sortIndex = 50;
            [SortOrder(Index_sortIndex)]
            [DisplayName(Index_displayName)]
            [IsReadOnly]
            public override ulong Index {
                get => (ulong) Index_raw;
                set {
                    if ((ulong) Index_raw == value) return;
                    Index_raw = (uint) value;
                    OnPropertyChanged(nameof(Index));
                }
            }

            protected ushort Set_Id_raw;
            public const string Set_Id_displayName = "Set Id";
            public const int Set_Id_sortIndex = 100;
            [SortOrder(Set_Id_sortIndex)]
            [DisplayName(Set_Id_displayName)]
            [IsReadOnly]
            public virtual ushort Set_Id {
                get => Set_Id_raw;
                set {
                    if (Set_Id_raw == value) return;
                    Set_Id_raw = value;
                    OnPropertyChanged(nameof(Set_Id));
                }
            }

            protected byte Equip_Slot_raw;
            public const string Equip_Slot_displayName = "Equip Slot";
            public const int Equip_Slot_sortIndex = 150;
            [SortOrder(Equip_Slot_sortIndex)]
            [DisplayName(Equip_Slot_displayName)]
            [IsReadOnly]
            public virtual MHW_Template.Armors.ArmorType Equip_Slot {
                get => (MHW_Template.Armors.ArmorType) Equip_Slot_raw;
                set {
                    if ((MHW_Template.Armors.ArmorType) Equip_Slot_raw == value) return;
                    Equip_Slot_raw = (byte) value;
                    OnPropertyChanged(nameof(Equip_Slot));
                }
            }

            protected byte Is_Full_Set_raw;
            public const string Is_Full_Set_displayName = "Is Full Set";
            public const int Is_Full_Set_sortIndex = 200;
            [SortOrder(Is_Full_Set_sortIndex)]
            [DisplayName(Is_Full_Set_displayName)]
            public virtual bool Is_Full_Set {
                get => (bool) Convert.ToBoolean(Is_Full_Set_raw);
                set {
                    if (Convert.ToBoolean(Is_Full_Set_raw) == value) return;
                    Is_Full_Set_raw = Convert.ToByte(value);
                    OnPropertyChanged(nameof(Is_Full_Set));
                }
            }

            protected uint Defense_raw;
            public const string Defense_displayName = "Defense";
            public const int Defense_sortIndex = 250;
            [SortOrder(Defense_sortIndex)]
            [DisplayName(Defense_displayName)]
            public virtual uint Defense {
                get => Defense_raw;
                set {
                    if (Defense_raw == value) return;
                    Defense_raw = value;
                    OnPropertyChanged(nameof(Defense));
                }
            }

            protected byte Rarity_raw;
            public const string Rarity_displayName = "Rarity";
            public const int Rarity_sortIndex = 300;
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

            protected ushort Order_raw;
            public const string Order_displayName = "Order";
            public const int Order_sortIndex = 350;
            [SortOrder(Order_sortIndex)]
            [DisplayName(Order_displayName)]
            public virtual ushort Order {
                get => Order_raw;
                set {
                    if (Order_raw == value) return;
                    Order_raw = value;
                    OnPropertyChanged(nameof(Order));
                }
            }

            protected uint Model_Id_raw;
            public const string Model_Id_displayName = "Model Id";
            public const int Model_Id_sortIndex = 400;
            [SortOrder(Model_Id_sortIndex)]
            [DisplayName(Model_Id_displayName)]
            public virtual uint Model_Id {
                get => Model_Id_raw;
                set {
                    if (Model_Id_raw == value) return;
                    Model_Id_raw = value;
                    OnPropertyChanged(nameof(Model_Id));
                }
            }

            protected uint Cost_raw;
            public const string Cost_displayName = "Cost";
            public const int Cost_sortIndex = 450;
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

            protected uint Variant_raw;
            public const string Variant_displayName = "Variant";
            public const int Variant_sortIndex = 500;
            [SortOrder(Variant_sortIndex)]
            [DisplayName(Variant_displayName)]
            public virtual MHW_Template.Armors.Variant Variant {
                get => (MHW_Template.Armors.Variant) Variant_raw;
                set {
                    if ((MHW_Template.Armors.Variant) Variant_raw == value) return;
                    Variant_raw = (uint) value;
                    OnPropertyChanged(nameof(Variant));
                }
            }

            protected sbyte Fire_Res_raw;
            public const string Fire_Res_displayName = "Fire Res";
            public const int Fire_Res_sortIndex = 550;
            [SortOrder(Fire_Res_sortIndex)]
            [DisplayName(Fire_Res_displayName)]
            public virtual sbyte Fire_Res {
                get => Fire_Res_raw;
                set {
                    if (Fire_Res_raw == value) return;
                    Fire_Res_raw = value;
                    OnPropertyChanged(nameof(Fire_Res));
                }
            }

            protected sbyte Water_Res_raw;
            public const string Water_Res_displayName = "Water Res";
            public const int Water_Res_sortIndex = 600;
            [SortOrder(Water_Res_sortIndex)]
            [DisplayName(Water_Res_displayName)]
            public virtual sbyte Water_Res {
                get => Water_Res_raw;
                set {
                    if (Water_Res_raw == value) return;
                    Water_Res_raw = value;
                    OnPropertyChanged(nameof(Water_Res));
                }
            }

            protected sbyte Ice_Res_raw;
            public const string Ice_Res_displayName = "Ice Res";
            public const int Ice_Res_sortIndex = 650;
            [SortOrder(Ice_Res_sortIndex)]
            [DisplayName(Ice_Res_displayName)]
            public virtual sbyte Ice_Res {
                get => Ice_Res_raw;
                set {
                    if (Ice_Res_raw == value) return;
                    Ice_Res_raw = value;
                    OnPropertyChanged(nameof(Ice_Res));
                }
            }

            protected sbyte Thunder_Res_raw;
            public const string Thunder_Res_displayName = "Thunder Res";
            public const int Thunder_Res_sortIndex = 700;
            [SortOrder(Thunder_Res_sortIndex)]
            [DisplayName(Thunder_Res_displayName)]
            public virtual sbyte Thunder_Res {
                get => Thunder_Res_raw;
                set {
                    if (Thunder_Res_raw == value) return;
                    Thunder_Res_raw = value;
                    OnPropertyChanged(nameof(Thunder_Res));
                }
            }

            protected sbyte Dragon_Res_raw;
            public const string Dragon_Res_displayName = "Dragon Res";
            public const int Dragon_Res_sortIndex = 750;
            [SortOrder(Dragon_Res_sortIndex)]
            [DisplayName(Dragon_Res_displayName)]
            public virtual sbyte Dragon_Res {
                get => Dragon_Res_raw;
                set {
                    if (Dragon_Res_raw == value) return;
                    Dragon_Res_raw = value;
                    OnPropertyChanged(nameof(Dragon_Res));
                }
            }

            protected uint Unk_raw;
            public const string Unk_displayName = "Unk";
            public const int Unk_sortIndex = 800;
            [SortOrder(Unk_sortIndex)]
            [DisplayName(Unk_displayName)]
            public virtual uint Unk {
                get => Unk_raw;
                set {
                    if (Unk_raw == value) return;
                    Unk_raw = value;
                    OnPropertyChanged(nameof(Unk));
                }
            }

            protected ushort Set_Group_raw;
            public const string Set_Group_displayName = "Set Group";
            public const int Set_Group_sortIndex = 850;
            [SortOrder(Set_Group_sortIndex)]
            [DisplayName(Set_Group_displayName)]
            public virtual ushort Set_Group {
                get => Set_Group_raw;
                set {
                    if (Set_Group_raw == value) return;
                    Set_Group_raw = value;
                    OnPropertyChanged(nameof(Set_Group));
                }
            }

            protected ushort GMD_Name_Index_raw;
            public const string GMD_Name_Index_displayName = "GMD Name Index";
            public const int GMD_Name_Index_sortIndex = 900;
            [SortOrder(GMD_Name_Index_sortIndex)]
            [DisplayName(GMD_Name_Index_displayName)]
            [IsReadOnly]
            public virtual ushort GMD_Name_Index {
                get => GMD_Name_Index_raw;
                set {
                    if (GMD_Name_Index_raw == value) return;
                    GMD_Name_Index_raw = value;
                    OnPropertyChanged(nameof(GMD_Name_Index));
                }
            }

            protected ushort GMD_Description_Index_raw;
            public const string GMD_Description_Index_displayName = "GMD Description Index";
            public const int GMD_Description_Index_sortIndex = 950;
            [SortOrder(GMD_Description_Index_sortIndex)]
            [DisplayName(GMD_Description_Index_displayName)]
            [IsReadOnly]
            public virtual ushort GMD_Description_Index {
                get => GMD_Description_Index_raw;
                set {
                    if (GMD_Description_Index_raw == value) return;
                    GMD_Description_Index_raw = value;
                    OnPropertyChanged(nameof(GMD_Description_Index));
                }
            }

            public const int lastSortIndex = 1000;

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
                data.Index_raw = reader.ReadUInt32();
                data.Set_Id_raw = reader.ReadUInt16();
                data.Equip_Slot_raw = reader.ReadByte();
                data.Is_Full_Set_raw = reader.ReadByte();
                data.Defense_raw = reader.ReadUInt32();
                data.Rarity_raw = reader.ReadByte();
                data.Order_raw = reader.ReadUInt16();
                data.Model_Id_raw = reader.ReadUInt32();
                data.Cost_raw = reader.ReadUInt32();
                data.Variant_raw = reader.ReadUInt32();
                data.Fire_Res_raw = reader.ReadSByte();
                data.Water_Res_raw = reader.ReadSByte();
                data.Ice_Res_raw = reader.ReadSByte();
                data.Thunder_Res_raw = reader.ReadSByte();
                data.Dragon_Res_raw = reader.ReadSByte();
                data.Unk_raw = reader.ReadUInt32();
                data.Set_Group_raw = reader.ReadUInt16();
                data.GMD_Name_Index_raw = reader.ReadUInt16();
                data.GMD_Description_Index_raw = reader.ReadUInt16();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Index_raw);
                writer.Write(Set_Id_raw);
                writer.Write(Equip_Slot_raw);
                writer.Write(Is_Full_Set_raw);
                writer.Write(Defense_raw);
                writer.Write(Rarity_raw);
                writer.Write(Order_raw);
                writer.Write(Model_Id_raw);
                writer.Write(Cost_raw);
                writer.Write(Variant_raw);
                writer.Write(Fire_Res_raw);
                writer.Write(Water_Res_raw);
                writer.Write(Ice_Res_raw);
                writer.Write(Thunder_Res_raw);
                writer.Write(Dragon_Res_raw);
                writer.Write(Unk_raw);
                writer.Write(Set_Group_raw);
                writer.Write(GMD_Name_Index_raw);
                writer.Write(GMD_Description_Index_raw);
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
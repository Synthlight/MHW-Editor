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
    public partial class Armor {
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
            public override string UniqueId => $"{Set_Group}|{Variant}|{Type}|{Equip_Slot}";

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
                    ChangedItems.Add(nameof(Index));
                    OnPropertyChanged(nameof(Index));
                }
            }

            protected ushort Order_raw;
            public const string Order_displayName = "Order";
            public const int Order_sortIndex = 100;
            [SortOrder(Order_sortIndex)]
            [DisplayName(Order_displayName)]
            public virtual ushort Order {
                get => Order_raw;
                set {
                    if (Order_raw == value) return;
                    Order_raw = value;
                    ChangedItems.Add(nameof(Order));
                    OnPropertyChanged(nameof(Order));
                }
            }

            protected byte Variant_raw;
            public const string Variant_displayName = "Variant";
            public const int Variant_sortIndex = 150;
            [SortOrder(Variant_sortIndex)]
            [DisplayName(Variant_displayName)]
            [IsReadOnly]
            public virtual MHW_Template.Armors.Variant Variant {
                get => (MHW_Template.Armors.Variant) Variant_raw;
                set {
                    if ((MHW_Template.Armors.Variant) Variant_raw == value) return;
                    Variant_raw = (byte) value;
                    ChangedItems.Add(nameof(Variant));
                    OnPropertyChanged(nameof(Variant));
                }
            }

            protected ushort Set_Layered_Id_raw;
            public const string Set_Layered_Id_displayName = "Set (Layered) Id";
            public const int Set_Layered_Id_sortIndex = 200;
            [SortOrder(Set_Layered_Id_sortIndex)]
            [DisplayName(Set_Layered_Id_displayName)]
            [IsReadOnly]
            public virtual ushort Set_Layered_Id {
                get => Set_Layered_Id_raw;
                set {
                    if (Set_Layered_Id_raw == value) return;
                    Set_Layered_Id_raw = value;
                    ChangedItems.Add(nameof(Set_Layered_Id));
                    OnPropertyChanged(nameof(Set_Layered_Id));
                }
            }

            protected byte Type_raw;
            public const string Type_displayName = "Type";
            public const int Type_sortIndex = 250;
            [SortOrder(Type_sortIndex)]
            [DisplayName(Type_displayName)]
            [IsReadOnly]
            public virtual MHW_Template.Armors.ArmorSetType Type {
                get => (MHW_Template.Armors.ArmorSetType) Type_raw;
                set {
                    if ((MHW_Template.Armors.ArmorSetType) Type_raw == value) return;
                    Type_raw = (byte) value;
                    ChangedItems.Add(nameof(Type));
                    OnPropertyChanged(nameof(Type));
                }
            }

            protected byte Equip_Slot_raw;
            public const string Equip_Slot_displayName = "Equip Slot";
            public const int Equip_Slot_sortIndex = 300;
            [SortOrder(Equip_Slot_sortIndex)]
            [DisplayName(Equip_Slot_displayName)]
            [IsReadOnly]
            public virtual MHW_Template.Armors.ArmorType Equip_Slot {
                get => (MHW_Template.Armors.ArmorType) Equip_Slot_raw;
                set {
                    if ((MHW_Template.Armors.ArmorType) Equip_Slot_raw == value) return;
                    Equip_Slot_raw = (byte) value;
                    ChangedItems.Add(nameof(Equip_Slot));
                    OnPropertyChanged(nameof(Equip_Slot));
                }
            }

            protected ushort Defense_raw;
            public const string Defense_displayName = "Defense";
            public const int Defense_sortIndex = 350;
            [SortOrder(Defense_sortIndex)]
            [DisplayName(Defense_displayName)]
            public virtual ushort Defense {
                get => Defense_raw;
                set {
                    if (Defense_raw == value) return;
                    Defense_raw = value;
                    ChangedItems.Add(nameof(Defense));
                    OnPropertyChanged(nameof(Defense));
                }
            }

            protected ushort Model_Id_1_raw;
            public const string Model_Id_1_displayName = "Model Id 1";
            public const int Model_Id_1_sortIndex = 400;
            [SortOrder(Model_Id_1_sortIndex)]
            [DisplayName(Model_Id_1_displayName)]
            public virtual ushort Model_Id_1 {
                get => Model_Id_1_raw;
                set {
                    if (Model_Id_1_raw == value) return;
                    Model_Id_1_raw = value;
                    ChangedItems.Add(nameof(Model_Id_1));
                    OnPropertyChanged(nameof(Model_Id_1));
                }
            }

            protected ushort Model_Id_2_raw;
            public const string Model_Id_2_displayName = "Model Id 2";
            public const int Model_Id_2_sortIndex = 450;
            [SortOrder(Model_Id_2_sortIndex)]
            [DisplayName(Model_Id_2_displayName)]
            public virtual ushort Model_Id_2 {
                get => Model_Id_2_raw;
                set {
                    if (Model_Id_2_raw == value) return;
                    Model_Id_2_raw = value;
                    ChangedItems.Add(nameof(Model_Id_2));
                    OnPropertyChanged(nameof(Model_Id_2));
                }
            }

            protected ushort Icon_Color_raw;
            public const string Icon_Color_displayName = "Icon Color";
            public const int Icon_Color_sortIndex = 500;
            [SortOrder(Icon_Color_sortIndex)]
            [DisplayName(Icon_Color_displayName)]
            public virtual ushort Icon_Color {
                get => Icon_Color_raw;
                set {
                    if (Icon_Color_raw == value) return;
                    Icon_Color_raw = value;
                    ChangedItems.Add(nameof(Icon_Color));
                    OnPropertyChanged(nameof(Icon_Color));
                }
            }

            protected byte Icon_Effect_raw;
            public const string Icon_Effect_displayName = "Icon Effect";
            public const int Icon_Effect_sortIndex = 550;
            [SortOrder(Icon_Effect_sortIndex)]
            [DisplayName(Icon_Effect_displayName)]
            public virtual byte Icon_Effect {
                get => Icon_Effect_raw;
                set {
                    if (Icon_Effect_raw == value) return;
                    Icon_Effect_raw = value;
                    ChangedItems.Add(nameof(Icon_Effect));
                    OnPropertyChanged(nameof(Icon_Effect));
                }
            }

            protected byte Rarity_raw;
            public const string Rarity_displayName = "Rarity";
            public const int Rarity_sortIndex = 600;
            [SortOrder(Rarity_sortIndex)]
            [DisplayName(Rarity_displayName)]
            public virtual byte Rarity {
                get => Rarity_raw;
                set {
                    if (Rarity_raw == value) return;
                    Rarity_raw = value;
                    ChangedItems.Add(nameof(Rarity));
                    OnPropertyChanged(nameof(Rarity));
                }
            }

            protected uint Cost_raw;
            public const string Cost_displayName = "Cost";
            public const int Cost_sortIndex = 650;
            [SortOrder(Cost_sortIndex)]
            [DisplayName(Cost_displayName)]
            public virtual uint Cost {
                get => Cost_raw;
                set {
                    if (Cost_raw == value) return;
                    Cost_raw = value;
                    ChangedItems.Add(nameof(Cost));
                    OnPropertyChanged(nameof(Cost));
                }
            }

            protected sbyte Fire_Res_raw;
            public const string Fire_Res_displayName = "Fire Res";
            public const int Fire_Res_sortIndex = 700;
            [SortOrder(Fire_Res_sortIndex)]
            [DisplayName(Fire_Res_displayName)]
            public virtual sbyte Fire_Res {
                get => Fire_Res_raw;
                set {
                    if (Fire_Res_raw == value) return;
                    Fire_Res_raw = value;
                    ChangedItems.Add(nameof(Fire_Res));
                    OnPropertyChanged(nameof(Fire_Res));
                }
            }

            protected sbyte Water_Res_raw;
            public const string Water_Res_displayName = "Water Res";
            public const int Water_Res_sortIndex = 750;
            [SortOrder(Water_Res_sortIndex)]
            [DisplayName(Water_Res_displayName)]
            public virtual sbyte Water_Res {
                get => Water_Res_raw;
                set {
                    if (Water_Res_raw == value) return;
                    Water_Res_raw = value;
                    ChangedItems.Add(nameof(Water_Res));
                    OnPropertyChanged(nameof(Water_Res));
                }
            }

            protected sbyte Ice_Res_raw;
            public const string Ice_Res_displayName = "Ice Res";
            public const int Ice_Res_sortIndex = 800;
            [SortOrder(Ice_Res_sortIndex)]
            [DisplayName(Ice_Res_displayName)]
            public virtual sbyte Ice_Res {
                get => Ice_Res_raw;
                set {
                    if (Ice_Res_raw == value) return;
                    Ice_Res_raw = value;
                    ChangedItems.Add(nameof(Ice_Res));
                    OnPropertyChanged(nameof(Ice_Res));
                }
            }

            protected sbyte Thunder_Res_raw;
            public const string Thunder_Res_displayName = "Thunder Res";
            public const int Thunder_Res_sortIndex = 850;
            [SortOrder(Thunder_Res_sortIndex)]
            [DisplayName(Thunder_Res_displayName)]
            public virtual sbyte Thunder_Res {
                get => Thunder_Res_raw;
                set {
                    if (Thunder_Res_raw == value) return;
                    Thunder_Res_raw = value;
                    ChangedItems.Add(nameof(Thunder_Res));
                    OnPropertyChanged(nameof(Thunder_Res));
                }
            }

            protected sbyte Dragon_Res_raw;
            public const string Dragon_Res_displayName = "Dragon Res";
            public const int Dragon_Res_sortIndex = 900;
            [SortOrder(Dragon_Res_sortIndex)]
            [DisplayName(Dragon_Res_displayName)]
            public virtual sbyte Dragon_Res {
                get => Dragon_Res_raw;
                set {
                    if (Dragon_Res_raw == value) return;
                    Dragon_Res_raw = value;
                    ChangedItems.Add(nameof(Dragon_Res));
                    OnPropertyChanged(nameof(Dragon_Res));
                }
            }

            protected byte Slot_Count_raw;
            public const string Slot_Count_displayName = "Slot Count";
            public const int Slot_Count_sortIndex = 950;
            [SortOrder(Slot_Count_sortIndex)]
            [DisplayName(Slot_Count_displayName)]
            public virtual byte Slot_Count {
                get => Slot_Count_raw;
                set {
                    if (Slot_Count_raw == value) return;
                    Slot_Count_raw = value;
                    ChangedItems.Add(nameof(Slot_Count));
                    OnPropertyChanged(nameof(Slot_Count));
                }
            }

            protected byte Slot_1_Size_raw;
            public const string Slot_1_Size_displayName = "Slot 1 Size";
            public const int Slot_1_Size_sortIndex = 1000;
            [SortOrder(Slot_1_Size_sortIndex)]
            [DisplayName(Slot_1_Size_displayName)]
            public virtual byte Slot_1_Size {
                get => Slot_1_Size_raw;
                set {
                    if (Slot_1_Size_raw == value) return;
                    Slot_1_Size_raw = value;
                    ChangedItems.Add(nameof(Slot_1_Size));
                    OnPropertyChanged(nameof(Slot_1_Size));
                }
            }

            protected byte Slot_2_Size_raw;
            public const string Slot_2_Size_displayName = "Slot 2 Size";
            public const int Slot_2_Size_sortIndex = 1050;
            [SortOrder(Slot_2_Size_sortIndex)]
            [DisplayName(Slot_2_Size_displayName)]
            public virtual byte Slot_2_Size {
                get => Slot_2_Size_raw;
                set {
                    if (Slot_2_Size_raw == value) return;
                    Slot_2_Size_raw = value;
                    ChangedItems.Add(nameof(Slot_2_Size));
                    OnPropertyChanged(nameof(Slot_2_Size));
                }
            }

            protected byte Slot_3_Size_raw;
            public const string Slot_3_Size_displayName = "Slot 3 Size";
            public const int Slot_3_Size_sortIndex = 1100;
            [SortOrder(Slot_3_Size_sortIndex)]
            [DisplayName(Slot_3_Size_displayName)]
            public virtual byte Slot_3_Size {
                get => Slot_3_Size_raw;
                set {
                    if (Slot_3_Size_raw == value) return;
                    Slot_3_Size_raw = value;
                    ChangedItems.Add(nameof(Slot_3_Size));
                    OnPropertyChanged(nameof(Slot_3_Size));
                }
            }

            protected ushort Set_Skill_1_raw;
            public const string Set_Skill_1_displayName = "Set Skill 1";
            public const int Set_Skill_1_sortIndex = 1150;
            [SortOrder(Set_Skill_1_sortIndex)]
            [DisplayName(Set_Skill_1_displayName)]
            [DataSource(DataSourceType.Skills)]
            public virtual ushort Set_Skill_1 {
                get => Set_Skill_1_raw;
                set {
                    if (Set_Skill_1_raw == value) return;
                    Set_Skill_1_raw = value;
                    ChangedItems.Add(nameof(Set_Skill_1));
                    OnPropertyChanged(nameof(Set_Skill_1));
                    OnPropertyChanged(nameof(Set_Skill_1_button));
                }
            }

            [SortOrder(Set_Skill_1_sortIndex)]
            [DisplayName(Set_Skill_1_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Set_Skill_1_button => DataHelper.skillNames[MainWindow.locale].TryGet(Set_Skill_1).ToStringWithId(Set_Skill_1);

            protected byte Set_Skill_1_Level_raw;
            public const string Set_Skill_1_Level_displayName = "Set Skill 1 Level";
            public const int Set_Skill_1_Level_sortIndex = 1200;
            [SortOrder(Set_Skill_1_Level_sortIndex)]
            [DisplayName(Set_Skill_1_Level_displayName)]
            public virtual byte Set_Skill_1_Level {
                get => Set_Skill_1_Level_raw;
                set {
                    if (Set_Skill_1_Level_raw == value) return;
                    Set_Skill_1_Level_raw = value;
                    ChangedItems.Add(nameof(Set_Skill_1_Level));
                    OnPropertyChanged(nameof(Set_Skill_1_Level));
                }
            }

            protected ushort Hidden_Skill_raw;
            public const string Hidden_Skill_displayName = "Hidden Skill";
            public const int Hidden_Skill_sortIndex = 1250;
            [SortOrder(Hidden_Skill_sortIndex)]
            [DisplayName(Hidden_Skill_displayName)]
            [DataSource(DataSourceType.Skills)]
            public virtual ushort Hidden_Skill {
                get => Hidden_Skill_raw;
                set {
                    if (Hidden_Skill_raw == value) return;
                    Hidden_Skill_raw = value;
                    ChangedItems.Add(nameof(Hidden_Skill));
                    OnPropertyChanged(nameof(Hidden_Skill));
                    OnPropertyChanged(nameof(Hidden_Skill_button));
                }
            }

            [SortOrder(Hidden_Skill_sortIndex)]
            [DisplayName(Hidden_Skill_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Hidden_Skill_button => DataHelper.skillNames[MainWindow.locale].TryGet(Hidden_Skill).ToStringWithId(Hidden_Skill);

            protected byte Hidden_Skill_Level_raw;
            public const string Hidden_Skill_Level_displayName = "Hidden Skill Level";
            public const int Hidden_Skill_Level_sortIndex = 1300;
            [SortOrder(Hidden_Skill_Level_sortIndex)]
            [DisplayName(Hidden_Skill_Level_displayName)]
            public virtual byte Hidden_Skill_Level {
                get => Hidden_Skill_Level_raw;
                set {
                    if (Hidden_Skill_Level_raw == value) return;
                    Hidden_Skill_Level_raw = value;
                    ChangedItems.Add(nameof(Hidden_Skill_Level));
                    OnPropertyChanged(nameof(Hidden_Skill_Level));
                }
            }

            protected ushort Skill_1_raw;
            public const string Skill_1_displayName = "Skill 1";
            public const int Skill_1_sortIndex = 1350;
            [SortOrder(Skill_1_sortIndex)]
            [DisplayName(Skill_1_displayName)]
            [DataSource(DataSourceType.Skills)]
            public virtual ushort Skill_1 {
                get => Skill_1_raw;
                set {
                    if (Skill_1_raw == value) return;
                    Skill_1_raw = value;
                    ChangedItems.Add(nameof(Skill_1));
                    OnPropertyChanged(nameof(Skill_1));
                    OnPropertyChanged(nameof(Skill_1_button));
                }
            }

            [SortOrder(Skill_1_sortIndex)]
            [DisplayName(Skill_1_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Skill_1_button => DataHelper.skillNames[MainWindow.locale].TryGet(Skill_1).ToStringWithId(Skill_1);

            protected byte Skill_1_Level_raw;
            public const string Skill_1_Level_displayName = "Skill 1 Level";
            public const int Skill_1_Level_sortIndex = 1400;
            [SortOrder(Skill_1_Level_sortIndex)]
            [DisplayName(Skill_1_Level_displayName)]
            public virtual byte Skill_1_Level {
                get => Skill_1_Level_raw;
                set {
                    if (Skill_1_Level_raw == value) return;
                    Skill_1_Level_raw = value;
                    ChangedItems.Add(nameof(Skill_1_Level));
                    OnPropertyChanged(nameof(Skill_1_Level));
                }
            }

            protected ushort Skill_2_raw;
            public const string Skill_2_displayName = "Skill 2";
            public const int Skill_2_sortIndex = 1450;
            [SortOrder(Skill_2_sortIndex)]
            [DisplayName(Skill_2_displayName)]
            [DataSource(DataSourceType.Skills)]
            public virtual ushort Skill_2 {
                get => Skill_2_raw;
                set {
                    if (Skill_2_raw == value) return;
                    Skill_2_raw = value;
                    ChangedItems.Add(nameof(Skill_2));
                    OnPropertyChanged(nameof(Skill_2));
                    OnPropertyChanged(nameof(Skill_2_button));
                }
            }

            [SortOrder(Skill_2_sortIndex)]
            [DisplayName(Skill_2_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Skill_2_button => DataHelper.skillNames[MainWindow.locale].TryGet(Skill_2).ToStringWithId(Skill_2);

            protected byte Skill_2_Level_raw;
            public const string Skill_2_Level_displayName = "Skill 2 Level";
            public const int Skill_2_Level_sortIndex = 1500;
            [SortOrder(Skill_2_Level_sortIndex)]
            [DisplayName(Skill_2_Level_displayName)]
            public virtual byte Skill_2_Level {
                get => Skill_2_Level_raw;
                set {
                    if (Skill_2_Level_raw == value) return;
                    Skill_2_Level_raw = value;
                    ChangedItems.Add(nameof(Skill_2_Level));
                    OnPropertyChanged(nameof(Skill_2_Level));
                }
            }

            protected ushort Skill_3_raw;
            public const string Skill_3_displayName = "Skill 3";
            public const int Skill_3_sortIndex = 1550;
            [SortOrder(Skill_3_sortIndex)]
            [DisplayName(Skill_3_displayName)]
            [DataSource(DataSourceType.Skills)]
            public virtual ushort Skill_3 {
                get => Skill_3_raw;
                set {
                    if (Skill_3_raw == value) return;
                    Skill_3_raw = value;
                    ChangedItems.Add(nameof(Skill_3));
                    OnPropertyChanged(nameof(Skill_3));
                    OnPropertyChanged(nameof(Skill_3_button));
                }
            }

            [SortOrder(Skill_3_sortIndex)]
            [DisplayName(Skill_3_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Skill_3_button => DataHelper.skillNames[MainWindow.locale].TryGet(Skill_3).ToStringWithId(Skill_3);

            protected byte Skill_3_Level_raw;
            public const string Skill_3_Level_displayName = "Skill 3 Level";
            public const int Skill_3_Level_sortIndex = 1600;
            [SortOrder(Skill_3_Level_sortIndex)]
            [DisplayName(Skill_3_Level_displayName)]
            public virtual byte Skill_3_Level {
                get => Skill_3_Level_raw;
                set {
                    if (Skill_3_Level_raw == value) return;
                    Skill_3_Level_raw = value;
                    ChangedItems.Add(nameof(Skill_3_Level));
                    OnPropertyChanged(nameof(Skill_3_Level));
                }
            }

            protected uint Gender_raw;
            public const string Gender_displayName = "Gender";
            public const int Gender_sortIndex = 1650;
            [SortOrder(Gender_sortIndex)]
            [DisplayName(Gender_displayName)]
            public virtual MHW_Template.Armors.Gender Gender {
                get => (MHW_Template.Armors.Gender) Gender_raw;
                set {
                    if ((MHW_Template.Armors.Gender) Gender_raw == value) return;
                    Gender_raw = (uint) value;
                    ChangedItems.Add(nameof(Gender));
                    OnPropertyChanged(nameof(Gender));
                }
            }

            protected ushort Set_Group_raw;
            public const string Set_Group_displayName = "Set Group";
            public const int Set_Group_sortIndex = 1700;
            [SortOrder(Set_Group_sortIndex)]
            [DisplayName(Set_Group_displayName)]
            [IsReadOnly]
            public virtual ushort Set_Group {
                get => Set_Group_raw;
                set {
                    if (Set_Group_raw == value) return;
                    Set_Group_raw = value;
                    ChangedItems.Add(nameof(Set_Group));
                    OnPropertyChanged(nameof(Set_Group));
                }
            }

            protected ushort GMD_Name_Index_raw;
            public const string GMD_Name_Index_displayName = "GMD Name Index";
            public const int GMD_Name_Index_sortIndex = 1750;
            [SortOrder(GMD_Name_Index_sortIndex)]
            [DisplayName(GMD_Name_Index_displayName)]
            [IsReadOnly]
            public virtual ushort GMD_Name_Index {
                get => GMD_Name_Index_raw;
                set {
                    if (GMD_Name_Index_raw == value) return;
                    GMD_Name_Index_raw = value;
                    ChangedItems.Add(nameof(GMD_Name_Index));
                    OnPropertyChanged(nameof(GMD_Name_Index));
                }
            }

            protected ushort GMD_Description_Index_raw;
            public const string GMD_Description_Index_displayName = "GMD Description Index";
            public const int GMD_Description_Index_sortIndex = 1800;
            [SortOrder(GMD_Description_Index_sortIndex)]
            [DisplayName(GMD_Description_Index_displayName)]
            [IsReadOnly]
            public virtual ushort GMD_Description_Index {
                get => GMD_Description_Index_raw;
                set {
                    if (GMD_Description_Index_raw == value) return;
                    GMD_Description_Index_raw = value;
                    ChangedItems.Add(nameof(GMD_Description_Index));
                    OnPropertyChanged(nameof(GMD_Description_Index));
                }
            }

            protected byte Is_Permanent_raw;
            public const string Is_Permanent_displayName = "Is Permanent";
            public const int Is_Permanent_sortIndex = 1850;
            [SortOrder(Is_Permanent_sortIndex)]
            [DisplayName(Is_Permanent_displayName)]
            public virtual bool Is_Permanent {
                get => (bool) Convert.ToBoolean(Is_Permanent_raw);
                set {
                    if (Convert.ToBoolean(Is_Permanent_raw) == value) return;
                    Is_Permanent_raw = Convert.ToByte(value);
                    ChangedItems.Add(nameof(Is_Permanent));
                    OnPropertyChanged(nameof(Is_Permanent));
                }
            }

            public const int lastSortIndex = 1900;

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
                data.Index_raw = reader.ReadUInt32();
                data.Order_raw = reader.ReadUInt16();
                data.Variant_raw = reader.ReadByte();
                data.Set_Layered_Id_raw = reader.ReadUInt16();
                data.Type_raw = reader.ReadByte();
                data.Equip_Slot_raw = reader.ReadByte();
                data.Defense_raw = reader.ReadUInt16();
                data.Model_Id_1_raw = reader.ReadUInt16();
                data.Model_Id_2_raw = reader.ReadUInt16();
                data.Icon_Color_raw = reader.ReadUInt16();
                data.Icon_Effect_raw = reader.ReadByte();
                data.Rarity_raw = reader.ReadByte();
                data.Cost_raw = reader.ReadUInt32();
                data.Fire_Res_raw = reader.ReadSByte();
                data.Water_Res_raw = reader.ReadSByte();
                data.Ice_Res_raw = reader.ReadSByte();
                data.Thunder_Res_raw = reader.ReadSByte();
                data.Dragon_Res_raw = reader.ReadSByte();
                data.Slot_Count_raw = reader.ReadByte();
                data.Slot_1_Size_raw = reader.ReadByte();
                data.Slot_2_Size_raw = reader.ReadByte();
                data.Slot_3_Size_raw = reader.ReadByte();
                data.Set_Skill_1_raw = reader.ReadUInt16();
                data.Set_Skill_1_Level_raw = reader.ReadByte();
                data.Hidden_Skill_raw = reader.ReadUInt16();
                data.Hidden_Skill_Level_raw = reader.ReadByte();
                data.Skill_1_raw = reader.ReadUInt16();
                data.Skill_1_Level_raw = reader.ReadByte();
                data.Skill_2_raw = reader.ReadUInt16();
                data.Skill_2_Level_raw = reader.ReadByte();
                data.Skill_3_raw = reader.ReadUInt16();
                data.Skill_3_Level_raw = reader.ReadByte();
                data.Gender_raw = reader.ReadUInt32();
                data.Set_Group_raw = reader.ReadUInt16();
                data.GMD_Name_Index_raw = reader.ReadUInt16();
                data.GMD_Description_Index_raw = reader.ReadUInt16();
                data.Is_Permanent_raw = reader.ReadByte();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Index_raw);
                writer.Write(Order_raw);
                writer.Write(Variant_raw);
                writer.Write(Set_Layered_Id_raw);
                writer.Write(Type_raw);
                writer.Write(Equip_Slot_raw);
                writer.Write(Defense_raw);
                writer.Write(Model_Id_1_raw);
                writer.Write(Model_Id_2_raw);
                writer.Write(Icon_Color_raw);
                writer.Write(Icon_Effect_raw);
                writer.Write(Rarity_raw);
                writer.Write(Cost_raw);
                writer.Write(Fire_Res_raw);
                writer.Write(Water_Res_raw);
                writer.Write(Ice_Res_raw);
                writer.Write(Thunder_Res_raw);
                writer.Write(Dragon_Res_raw);
                writer.Write(Slot_Count_raw);
                writer.Write(Slot_1_Size_raw);
                writer.Write(Slot_2_Size_raw);
                writer.Write(Slot_3_Size_raw);
                writer.Write(Set_Skill_1_raw);
                writer.Write(Set_Skill_1_Level_raw);
                writer.Write(Hidden_Skill_raw);
                writer.Write(Hidden_Skill_Level_raw);
                writer.Write(Skill_1_raw);
                writer.Write(Skill_1_Level_raw);
                writer.Write(Skill_2_raw);
                writer.Write(Skill_2_Level_raw);
                writer.Write(Skill_3_raw);
                writer.Write(Skill_3_Level_raw);
                writer.Write(Gender_raw);
                writer.Write(Set_Group_raw);
                writer.Write(GMD_Name_Index_raw);
                writer.Write(GMD_Description_Index_raw);
                writer.Write(Is_Permanent_raw);
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
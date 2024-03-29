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
    public partial class ArenaEquipment {
        public override string EncryptionKey => "b71AMFJuw63cUTlDt5ntSAtaAvwLKizNtapy4W0QAsC39QXPr6b78Asz";

        public partial class Aeq : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Aeq";

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

            public static ObservableMhwStructCollection<Aeq> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Aeq>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Aeq LoadData(BinaryReader reader, ulong i) {
                var data = new Aeq();
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

        public partial class Entries : MhwStructItem, IWriteData, IHasChildren {
            public const ulong FixedSizeCount = 0;
            public const string GridName = "Entries";
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
            public virtual uint Id {
                get => Id_raw;
                set {
                    if (Id_raw == value) return;
                    Id_raw = value;
                    ChangedItems.Add(nameof(Id));
                    OnPropertyChanged(nameof(Id));
                }
            }

            protected uint Weapon_Type_raw;
            public const string Weapon_Type_displayName = "Weapon Type";
            public const int Weapon_Type_sortIndex = 100;
            [SortOrder(Weapon_Type_sortIndex)]
            [DisplayName(Weapon_Type_displayName)]
            public virtual MHW_Template.Weapons.WeaponType Weapon_Type {
                get => (MHW_Template.Weapons.WeaponType) Weapon_Type_raw;
                set {
                    if ((MHW_Template.Weapons.WeaponType) Weapon_Type_raw == value) return;
                    Weapon_Type_raw = (uint) value;
                    ChangedItems.Add(nameof(Weapon_Type));
                    OnPropertyChanged(nameof(Weapon_Type));
                }
            }

            protected uint Weapon_Id_raw;
            public const string Weapon_Id_displayName = "Weapon Id";
            public const int Weapon_Id_sortIndex = 150;
            [SortOrder(Weapon_Id_sortIndex)]
            [DisplayName(Weapon_Id_displayName)]
            [DataSource(DataSourceType.WeaponsByIndex)]
            public virtual uint Weapon_Id {
                get => Weapon_Id_raw;
                set {
                    if (Weapon_Id_raw == value) return;
                    Weapon_Id_raw = value;
                    ChangedItems.Add(nameof(Weapon_Id));
                    OnPropertyChanged(nameof(Weapon_Id));
                    OnPropertyChanged(nameof(Weapon_Id_button));
                }
            }

            [SortOrder(Weapon_Id_sortIndex)]
            [DisplayName(Weapon_Id_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Weapon_Id_button => DataHelper.weaponIndexNameLookup[GetWeaponType()][MainWindow.locale].TryGet(Weapon_Id).ToStringWithId(Weapon_Id);

            public partial class Custom_Mods : MhwStructItem, IWriteDataInner<Entries> {
                public const ulong FixedSizeCount = 5;
                public const string GridName = "Custom Mods";

                protected int Mod_raw;
                public const string Mod_displayName = "Mod";
                public const int Mod_sortIndex = 50;
                [SortOrder(Mod_sortIndex)]
                [DisplayName(Mod_displayName)]
                public virtual int Mod {
                    get => Mod_raw;
                    set {
                        if (Mod_raw == value) return;
                        Mod_raw = value;
                        ChangedItems.Add(nameof(Mod));
                        OnPropertyChanged(nameof(Mod));
                    }
                }

                public const int lastSortIndex = 100;

                public static ObservableMhwStructCollection<Custom_Mods> LoadData(BinaryReader reader, Entries parent) {
                    var list = new ObservableMhwStructCollection<Custom_Mods>();
                    const ulong count = 5UL;
                    for (ulong i = 0; i < count; i++) {
                        list.Add(LoadData(reader, i, parent));
                    }
                    return list;
                }

                public static Custom_Mods LoadData(BinaryReader reader, ulong i, Entries parent) {
                    var data = new Custom_Mods();
                    data.Index = i;
                    data.Mod_raw = reader.ReadInt32();
                    return data;
                }

                public void WriteData(BinaryWriter writer, Entries parent) {
                    writer.Write(Mod_raw);
                }
            }

            public const string Custom_Mods_displayName = "Custom Mods";
            public const int Custom_Mods_sortIndex = 200;
            [SortOrder(Custom_Mods_sortIndex)]
            [DisplayName(Custom_Mods_displayName)]
            public virtual ObservableCollection<Custom_Mods> Custom_Mods_raw { get; protected set; }

            public partial class Armors : MhwStructItem, IWriteDataInner<Entries> {
                public const ulong FixedSizeCount = 6;
                public const string GridName = "Armors";

                protected int Armor_Id_raw;
                public const string Armor_Id_displayName = "Armor Id";
                public const int Armor_Id_sortIndex = 50;
                [SortOrder(Armor_Id_sortIndex)]
                [DisplayName(Armor_Id_displayName)]
                [DataSource(DataSourceType.ArmorByFileIndexNeg)]
                public virtual int Armor_Id {
                    get => Armor_Id_raw;
                    set {
                        if (Armor_Id_raw == value) return;
                        Armor_Id_raw = value;
                        ChangedItems.Add(nameof(Armor_Id));
                        OnPropertyChanged(nameof(Armor_Id));
                        OnPropertyChanged(nameof(Armor_Id_button));
                    }
                }

                [SortOrder(Armor_Id_sortIndex)]
                [DisplayName(Armor_Id_displayName)]
                [CustomSorter(typeof(ButtonSorter))]
                public string Armor_Id_button => DataHelper.armorFileIndexNegNameLookup[MainWindow.locale].TryGet(Armor_Id).ToStringWithId(Armor_Id);

                public const int lastSortIndex = 100;

                public static ObservableMhwStructCollection<Armors> LoadData(BinaryReader reader, Entries parent) {
                    var list = new ObservableMhwStructCollection<Armors>();
                    const ulong count = 6UL;
                    for (ulong i = 0; i < count; i++) {
                        list.Add(LoadData(reader, i, parent));
                    }
                    return list;
                }

                public static Armors LoadData(BinaryReader reader, ulong i, Entries parent) {
                    var data = new Armors();
                    data.Index = i;
                    data.Armor_Id_raw = reader.ReadInt32();
                    return data;
                }

                public void WriteData(BinaryWriter writer, Entries parent) {
                    writer.Write(Armor_Id_raw);
                }
            }

            public const string Armors_displayName = "Armors";
            public const int Armors_sortIndex = 250;
            [SortOrder(Armors_sortIndex)]
            [DisplayName(Armors_displayName)]
            public virtual ObservableCollection<Armors> Armors_raw { get; protected set; }

            public partial class Mantles : MhwStructItem, IWriteDataInner<Entries> {
                public const ulong FixedSizeCount = 2;
                public const string GridName = "Mantles";

                protected int Mantle_Id_raw;
                public const string Mantle_Id_displayName = "Mantle Id";
                public const int Mantle_Id_sortIndex = 50;
                [SortOrder(Mantle_Id_sortIndex)]
                [DisplayName(Mantle_Id_displayName)]
                [DataSource(DataSourceType.MantleByIdNeg)]
                public virtual int Mantle_Id {
                    get => Mantle_Id_raw;
                    set {
                        if (Mantle_Id_raw == value) return;
                        Mantle_Id_raw = value;
                        ChangedItems.Add(nameof(Mantle_Id));
                        OnPropertyChanged(nameof(Mantle_Id));
                        OnPropertyChanged(nameof(Mantle_Id_button));
                    }
                }

                [SortOrder(Mantle_Id_sortIndex)]
                [DisplayName(Mantle_Id_displayName)]
                [CustomSorter(typeof(ButtonSorter))]
                public string Mantle_Id_button => DataHelper.mantleNamesNeg[MainWindow.locale].TryGet(Mantle_Id).ToStringWithId(Mantle_Id);

                public const int lastSortIndex = 100;

                public static ObservableMhwStructCollection<Mantles> LoadData(BinaryReader reader, Entries parent) {
                    var list = new ObservableMhwStructCollection<Mantles>();
                    const ulong count = 2UL;
                    for (ulong i = 0; i < count; i++) {
                        list.Add(LoadData(reader, i, parent));
                    }
                    return list;
                }

                public static Mantles LoadData(BinaryReader reader, ulong i, Entries parent) {
                    var data = new Mantles();
                    data.Index = i;
                    data.Mantle_Id_raw = reader.ReadInt32();
                    return data;
                }

                public void WriteData(BinaryWriter writer, Entries parent) {
                    writer.Write(Mantle_Id_raw);
                }
            }

            public const string Mantles_displayName = "Mantles";
            public const int Mantles_sortIndex = 300;
            [SortOrder(Mantles_sortIndex)]
            [DisplayName(Mantles_displayName)]
            public virtual ObservableCollection<Mantles> Mantles_raw { get; protected set; }

            public partial class Armor_Level : MhwStructItem, IWriteDataInner<Entries> {
                public const ulong FixedSizeCount = 5;
                public const string GridName = "Armor Level";

                protected uint Armor_Lvl_raw;
                public const string Armor_Lvl_displayName = "Armor Lvl";
                public const int Armor_Lvl_sortIndex = 50;
                [SortOrder(Armor_Lvl_sortIndex)]
                [DisplayName(Armor_Lvl_displayName)]
                public virtual uint Armor_Lvl {
                    get => Armor_Lvl_raw;
                    set {
                        if (Armor_Lvl_raw == value) return;
                        Armor_Lvl_raw = value;
                        ChangedItems.Add(nameof(Armor_Lvl));
                        OnPropertyChanged(nameof(Armor_Lvl));
                    }
                }

                public const int lastSortIndex = 100;

                public static ObservableMhwStructCollection<Armor_Level> LoadData(BinaryReader reader, Entries parent) {
                    var list = new ObservableMhwStructCollection<Armor_Level>();
                    const ulong count = 5UL;
                    for (ulong i = 0; i < count; i++) {
                        list.Add(LoadData(reader, i, parent));
                    }
                    return list;
                }

                public static Armor_Level LoadData(BinaryReader reader, ulong i, Entries parent) {
                    var data = new Armor_Level();
                    data.Index = i;
                    data.Armor_Lvl_raw = reader.ReadUInt32();
                    return data;
                }

                public void WriteData(BinaryWriter writer, Entries parent) {
                    writer.Write(Armor_Lvl_raw);
                }
            }

            public const string Armor_Level_displayName = "Armor Level";
            public const int Armor_Level_sortIndex = 350;
            [SortOrder(Armor_Level_sortIndex)]
            [DisplayName(Armor_Level_displayName)]
            public virtual ObservableCollection<Armor_Level> Armor_Level_raw { get; protected set; }

            protected byte Mantle_1_Upgraded__raw;
            public const string Mantle_1_Upgraded__displayName = "Mantle 1 Upgraded?";
            public const int Mantle_1_Upgraded__sortIndex = 400;
            [SortOrder(Mantle_1_Upgraded__sortIndex)]
            [DisplayName(Mantle_1_Upgraded__displayName)]
            public virtual MHW_Template.Items.MantleUpgrades Mantle_1_Upgraded_ {
                get => (MHW_Template.Items.MantleUpgrades) Mantle_1_Upgraded__raw;
                set {
                    if ((MHW_Template.Items.MantleUpgrades) Mantle_1_Upgraded__raw == value) return;
                    Mantle_1_Upgraded__raw = (byte) value;
                    ChangedItems.Add(nameof(Mantle_1_Upgraded_));
                    OnPropertyChanged(nameof(Mantle_1_Upgraded_));
                }
            }

            protected byte Mantle_2_Upgraded__raw;
            public const string Mantle_2_Upgraded__displayName = "Mantle 2 Upgraded?";
            public const int Mantle_2_Upgraded__sortIndex = 450;
            [SortOrder(Mantle_2_Upgraded__sortIndex)]
            [DisplayName(Mantle_2_Upgraded__displayName)]
            public virtual MHW_Template.Items.MantleUpgrades Mantle_2_Upgraded_ {
                get => (MHW_Template.Items.MantleUpgrades) Mantle_2_Upgraded__raw;
                set {
                    if ((MHW_Template.Items.MantleUpgrades) Mantle_2_Upgraded__raw == value) return;
                    Mantle_2_Upgraded__raw = (byte) value;
                    ChangedItems.Add(nameof(Mantle_2_Upgraded_));
                    OnPropertyChanged(nameof(Mantle_2_Upgraded_));
                }
            }

            public partial class Decorations : MhwStructItem, IWriteDataInner<Entries> {
                public const ulong FixedSizeCount = 9;
                public const string GridName = "Decorations";

                protected uint Deco_1_raw;
                public const string Deco_1_displayName = "Deco 1";
                public const int Deco_1_sortIndex = 50;
                [SortOrder(Deco_1_sortIndex)]
                [DisplayName(Deco_1_displayName)]
                [DataSource(DataSourceType.Items)]
                public virtual uint Deco_1 {
                    get => Deco_1_raw;
                    set {
                        if (Deco_1_raw == value) return;
                        Deco_1_raw = value;
                        ChangedItems.Add(nameof(Deco_1));
                        OnPropertyChanged(nameof(Deco_1));
                        OnPropertyChanged(nameof(Deco_1_button));
                    }
                }

                [SortOrder(Deco_1_sortIndex)]
                [DisplayName(Deco_1_displayName)]
                [CustomSorter(typeof(ButtonSorter))]
                public string Deco_1_button => DataHelper.itemNames[MainWindow.locale].TryGet(Deco_1).ToStringWithId(Deco_1);

                protected uint Deco_2_raw;
                public const string Deco_2_displayName = "Deco 2";
                public const int Deco_2_sortIndex = 100;
                [SortOrder(Deco_2_sortIndex)]
                [DisplayName(Deco_2_displayName)]
                [DataSource(DataSourceType.Items)]
                public virtual uint Deco_2 {
                    get => Deco_2_raw;
                    set {
                        if (Deco_2_raw == value) return;
                        Deco_2_raw = value;
                        ChangedItems.Add(nameof(Deco_2));
                        OnPropertyChanged(nameof(Deco_2));
                        OnPropertyChanged(nameof(Deco_2_button));
                    }
                }

                [SortOrder(Deco_2_sortIndex)]
                [DisplayName(Deco_2_displayName)]
                [CustomSorter(typeof(ButtonSorter))]
                public string Deco_2_button => DataHelper.itemNames[MainWindow.locale].TryGet(Deco_2).ToStringWithId(Deco_2);

                protected uint Deco_3_raw;
                public const string Deco_3_displayName = "Deco 3";
                public const int Deco_3_sortIndex = 150;
                [SortOrder(Deco_3_sortIndex)]
                [DisplayName(Deco_3_displayName)]
                [DataSource(DataSourceType.Items)]
                public virtual uint Deco_3 {
                    get => Deco_3_raw;
                    set {
                        if (Deco_3_raw == value) return;
                        Deco_3_raw = value;
                        ChangedItems.Add(nameof(Deco_3));
                        OnPropertyChanged(nameof(Deco_3));
                        OnPropertyChanged(nameof(Deco_3_button));
                    }
                }

                [SortOrder(Deco_3_sortIndex)]
                [DisplayName(Deco_3_displayName)]
                [CustomSorter(typeof(ButtonSorter))]
                public string Deco_3_button => DataHelper.itemNames[MainWindow.locale].TryGet(Deco_3).ToStringWithId(Deco_3);

                public const int lastSortIndex = 200;

                public static ObservableMhwStructCollection<Decorations> LoadData(BinaryReader reader, Entries parent) {
                    var list = new ObservableMhwStructCollection<Decorations>();
                    const ulong count = 9UL;
                    for (ulong i = 0; i < count; i++) {
                        list.Add(LoadData(reader, i, parent));
                    }
                    return list;
                }

                public static Decorations LoadData(BinaryReader reader, ulong i, Entries parent) {
                    var data = new Decorations();
                    data.Index = i;
                    data.Deco_1_raw = reader.ReadUInt32();
                    data.Deco_2_raw = reader.ReadUInt32();
                    data.Deco_3_raw = reader.ReadUInt32();
                    return data;
                }

                public void WriteData(BinaryWriter writer, Entries parent) {
                    writer.Write(Deco_1_raw);
                    writer.Write(Deco_2_raw);
                    writer.Write(Deco_3_raw);
                }
            }

            public const string Decorations_displayName = "Decorations";
            public const int Decorations_sortIndex = 500;
            [SortOrder(Decorations_sortIndex)]
            [DisplayName(Decorations_displayName)]
            public virtual ObservableCollection<Decorations> Decorations_raw { get; protected set; }

            protected uint Kinsect_Id_for_IG_raw;
            public const string Kinsect_Id_for_IG_displayName = "Kinsect Id for IG";
            public const int Kinsect_Id_for_IG_sortIndex = 550;
            [SortOrder(Kinsect_Id_for_IG_sortIndex)]
            [DisplayName(Kinsect_Id_for_IG_displayName)]
            public virtual uint Kinsect_Id_for_IG {
                get => Kinsect_Id_for_IG_raw;
                set {
                    if (Kinsect_Id_for_IG_raw == value) return;
                    Kinsect_Id_for_IG_raw = value;
                    ChangedItems.Add(nameof(Kinsect_Id_for_IG));
                    OnPropertyChanged(nameof(Kinsect_Id_for_IG));
                }
            }

            protected uint Kinsect_Lvl_for_IG_raw;
            public const string Kinsect_Lvl_for_IG_displayName = "Kinsect Lvl for IG";
            public const int Kinsect_Lvl_for_IG_sortIndex = 600;
            [SortOrder(Kinsect_Lvl_for_IG_sortIndex)]
            [DisplayName(Kinsect_Lvl_for_IG_displayName)]
            public virtual uint Kinsect_Lvl_for_IG {
                get => Kinsect_Lvl_for_IG_raw;
                set {
                    if (Kinsect_Lvl_for_IG_raw == value) return;
                    Kinsect_Lvl_for_IG_raw = value;
                    ChangedItems.Add(nameof(Kinsect_Lvl_for_IG));
                    OnPropertyChanged(nameof(Kinsect_Lvl_for_IG));
                }
            }

            protected uint Unk_4_raw;
            public const string Unk_4_displayName = "Unk 4";
            public const int Unk_4_sortIndex = 650;
            [SortOrder(Unk_4_sortIndex)]
            [DisplayName(Unk_4_displayName)]
            public virtual uint Unk_4 {
                get => Unk_4_raw;
                set {
                    if (Unk_4_raw == value) return;
                    Unk_4_raw = value;
                    ChangedItems.Add(nameof(Unk_4));
                    OnPropertyChanged(nameof(Unk_4));
                }
            }

            protected uint Unk_5_raw;
            public const string Unk_5_displayName = "Unk 5";
            public const int Unk_5_sortIndex = 700;
            [SortOrder(Unk_5_sortIndex)]
            [DisplayName(Unk_5_displayName)]
            public virtual uint Unk_5 {
                get => Unk_5_raw;
                set {
                    if (Unk_5_raw == value) return;
                    Unk_5_raw = value;
                    ChangedItems.Add(nameof(Unk_5));
                    OnPropertyChanged(nameof(Unk_5));
                }
            }

            protected uint Unk_6_raw;
            public const string Unk_6_displayName = "Unk 6";
            public const int Unk_6_sortIndex = 750;
            [SortOrder(Unk_6_sortIndex)]
            [DisplayName(Unk_6_displayName)]
            public virtual uint Unk_6 {
                get => Unk_6_raw;
                set {
                    if (Unk_6_raw == value) return;
                    Unk_6_raw = value;
                    ChangedItems.Add(nameof(Unk_6));
                    OnPropertyChanged(nameof(Unk_6));
                }
            }

            protected byte Augment_Augment_Slot_raw;
            public const string Augment_Augment_Slot_displayName = "Augment: Augment Slot";
            public const int Augment_Augment_Slot_sortIndex = 800;
            [SortOrder(Augment_Augment_Slot_sortIndex)]
            [DisplayName(Augment_Augment_Slot_displayName)]
            public virtual MHW_Template.Items.AugmentSlotAugment Augment_Augment_Slot {
                get => (MHW_Template.Items.AugmentSlotAugment) Augment_Augment_Slot_raw;
                set {
                    if ((MHW_Template.Items.AugmentSlotAugment) Augment_Augment_Slot_raw == value) return;
                    Augment_Augment_Slot_raw = (byte) value;
                    ChangedItems.Add(nameof(Augment_Augment_Slot));
                    OnPropertyChanged(nameof(Augment_Augment_Slot));
                }
            }

            protected byte Augment_Attack_raw;
            public const string Augment_Attack_displayName = "Augment: Attack";
            public const int Augment_Attack_sortIndex = 850;
            [SortOrder(Augment_Attack_sortIndex)]
            [DisplayName(Augment_Attack_displayName)]
            public virtual MHW_Template.Items.AttackAugment Augment_Attack {
                get => (MHW_Template.Items.AttackAugment) Augment_Attack_raw;
                set {
                    if ((MHW_Template.Items.AttackAugment) Augment_Attack_raw == value) return;
                    Augment_Attack_raw = (byte) value;
                    ChangedItems.Add(nameof(Augment_Attack));
                    OnPropertyChanged(nameof(Augment_Attack));
                }
            }

            protected byte Augment_Affinity_raw;
            public const string Augment_Affinity_displayName = "Augment: Affinity";
            public const int Augment_Affinity_sortIndex = 900;
            [SortOrder(Augment_Affinity_sortIndex)]
            [DisplayName(Augment_Affinity_displayName)]
            public virtual MHW_Template.Items.AffinityAugment Augment_Affinity {
                get => (MHW_Template.Items.AffinityAugment) Augment_Affinity_raw;
                set {
                    if ((MHW_Template.Items.AffinityAugment) Augment_Affinity_raw == value) return;
                    Augment_Affinity_raw = (byte) value;
                    ChangedItems.Add(nameof(Augment_Affinity));
                    OnPropertyChanged(nameof(Augment_Affinity));
                }
            }

            protected byte Augment_Defense_raw;
            public const string Augment_Defense_displayName = "Augment: Defense";
            public const int Augment_Defense_sortIndex = 950;
            [SortOrder(Augment_Defense_sortIndex)]
            [DisplayName(Augment_Defense_displayName)]
            public virtual MHW_Template.Items.DefenseAugment Augment_Defense {
                get => (MHW_Template.Items.DefenseAugment) Augment_Defense_raw;
                set {
                    if ((MHW_Template.Items.DefenseAugment) Augment_Defense_raw == value) return;
                    Augment_Defense_raw = (byte) value;
                    ChangedItems.Add(nameof(Augment_Defense));
                    OnPropertyChanged(nameof(Augment_Defense));
                }
            }

            protected byte Augment_Deco_Slot_raw;
            public const string Augment_Deco_Slot_displayName = "Augment: Deco Slot";
            public const int Augment_Deco_Slot_sortIndex = 1000;
            [SortOrder(Augment_Deco_Slot_sortIndex)]
            [DisplayName(Augment_Deco_Slot_displayName)]
            public virtual MHW_Template.Items.DecoSlotAugment Augment_Deco_Slot {
                get => (MHW_Template.Items.DecoSlotAugment) Augment_Deco_Slot_raw;
                set {
                    if ((MHW_Template.Items.DecoSlotAugment) Augment_Deco_Slot_raw == value) return;
                    Augment_Deco_Slot_raw = (byte) value;
                    ChangedItems.Add(nameof(Augment_Deco_Slot));
                    OnPropertyChanged(nameof(Augment_Deco_Slot));
                }
            }

            protected byte Augment_Health_raw;
            public const string Augment_Health_displayName = "Augment: Health";
            public const int Augment_Health_sortIndex = 1050;
            [SortOrder(Augment_Health_sortIndex)]
            [DisplayName(Augment_Health_displayName)]
            public virtual MHW_Template.Items.HealthAugment Augment_Health {
                get => (MHW_Template.Items.HealthAugment) Augment_Health_raw;
                set {
                    if ((MHW_Template.Items.HealthAugment) Augment_Health_raw == value) return;
                    Augment_Health_raw = (byte) value;
                    ChangedItems.Add(nameof(Augment_Health));
                    OnPropertyChanged(nameof(Augment_Health));
                }
            }

            protected byte Augment_Element_Status_raw;
            public const string Augment_Element_Status_displayName = "Augment: Element/Status";
            public const int Augment_Element_Status_sortIndex = 1100;
            [SortOrder(Augment_Element_Status_sortIndex)]
            [DisplayName(Augment_Element_Status_displayName)]
            public virtual MHW_Template.Items.ElementAugment Augment_Element_Status {
                get => (MHW_Template.Items.ElementAugment) Augment_Element_Status_raw;
                set {
                    if ((MHW_Template.Items.ElementAugment) Augment_Element_Status_raw == value) return;
                    Augment_Element_Status_raw = (byte) value;
                    ChangedItems.Add(nameof(Augment_Element_Status));
                    OnPropertyChanged(nameof(Augment_Element_Status));
                }
            }

            protected byte Unk_raw;
            public const string Unk_displayName = "Unk";
            public const int Unk_sortIndex = 1150;
            [SortOrder(Unk_sortIndex)]
            [DisplayName(Unk_displayName)]
            public virtual byte Unk {
                get => Unk_raw;
                set {
                    if (Unk_raw == value) return;
                    Unk_raw = value;
                    ChangedItems.Add(nameof(Unk));
                    OnPropertyChanged(nameof(Unk));
                }
            }

            public partial class Items : MhwStructItem, IWriteDataInner<Entries> {
                public const ulong FixedSizeCount = 24;
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

                protected uint Item_Cnt_raw;
                public const string Item_Cnt_displayName = "Item Cnt";
                public const int Item_Cnt_sortIndex = 100;
                [SortOrder(Item_Cnt_sortIndex)]
                [DisplayName(Item_Cnt_displayName)]
                public virtual uint Item_Cnt {
                    get => Item_Cnt_raw;
                    set {
                        if (Item_Cnt_raw == value) return;
                        Item_Cnt_raw = value;
                        ChangedItems.Add(nameof(Item_Cnt));
                        OnPropertyChanged(nameof(Item_Cnt));
                    }
                }

                public const int lastSortIndex = 150;

                public static ObservableMhwStructCollection<Items> LoadData(BinaryReader reader, Entries parent) {
                    var list = new ObservableMhwStructCollection<Items>();
                    const ulong count = 24UL;
                    for (ulong i = 0; i < count; i++) {
                        list.Add(LoadData(reader, i, parent));
                    }
                    return list;
                }

                public static Items LoadData(BinaryReader reader, ulong i, Entries parent) {
                    var data = new Items();
                    data.Index = i;
                    data.Item_Id_raw = reader.ReadUInt32();
                    data.Item_Cnt_raw = reader.ReadUInt32();
                    return data;
                }

                public void WriteData(BinaryWriter writer, Entries parent) {
                    writer.Write(Item_Id_raw);
                    writer.Write(Item_Cnt_raw);
                }
            }

            public const string Items_displayName = "Items";
            public const int Items_sortIndex = 1200;
            [SortOrder(Items_sortIndex)]
            [DisplayName(Items_displayName)]
            public virtual ObservableCollection<Items> Items_raw { get; protected set; }

            public partial class Ammo : MhwStructItem, IWriteDataInner<Entries> {
                public const ulong FixedSizeCount = 16;
                public const string GridName = "Ammo";

                protected uint Ammo_Id_raw;
                public const string Ammo_Id_displayName = "Ammo Id";
                public const int Ammo_Id_sortIndex = 50;
                [SortOrder(Ammo_Id_sortIndex)]
                [DisplayName(Ammo_Id_displayName)]
                [DataSource(DataSourceType.Items)]
                public virtual uint Ammo_Id {
                    get => Ammo_Id_raw;
                    set {
                        if (Ammo_Id_raw == value) return;
                        Ammo_Id_raw = value;
                        ChangedItems.Add(nameof(Ammo_Id));
                        OnPropertyChanged(nameof(Ammo_Id));
                        OnPropertyChanged(nameof(Ammo_Id_button));
                    }
                }

                [SortOrder(Ammo_Id_sortIndex)]
                [DisplayName(Ammo_Id_displayName)]
                [CustomSorter(typeof(ButtonSorter))]
                public string Ammo_Id_button => DataHelper.itemNames[MainWindow.locale].TryGet(Ammo_Id).ToStringWithId(Ammo_Id);

                protected uint Ammo_Cnt_raw;
                public const string Ammo_Cnt_displayName = "Ammo Cnt";
                public const int Ammo_Cnt_sortIndex = 100;
                [SortOrder(Ammo_Cnt_sortIndex)]
                [DisplayName(Ammo_Cnt_displayName)]
                public virtual uint Ammo_Cnt {
                    get => Ammo_Cnt_raw;
                    set {
                        if (Ammo_Cnt_raw == value) return;
                        Ammo_Cnt_raw = value;
                        ChangedItems.Add(nameof(Ammo_Cnt));
                        OnPropertyChanged(nameof(Ammo_Cnt));
                    }
                }

                public const int lastSortIndex = 150;

                public static ObservableMhwStructCollection<Ammo> LoadData(BinaryReader reader, Entries parent) {
                    var list = new ObservableMhwStructCollection<Ammo>();
                    const ulong count = 16UL;
                    for (ulong i = 0; i < count; i++) {
                        list.Add(LoadData(reader, i, parent));
                    }
                    return list;
                }

                public static Ammo LoadData(BinaryReader reader, ulong i, Entries parent) {
                    var data = new Ammo();
                    data.Index = i;
                    data.Ammo_Id_raw = reader.ReadUInt32();
                    data.Ammo_Cnt_raw = reader.ReadUInt32();
                    return data;
                }

                public void WriteData(BinaryWriter writer, Entries parent) {
                    writer.Write(Ammo_Id_raw);
                    writer.Write(Ammo_Cnt_raw);
                }
            }

            public const string Ammo_displayName = "Ammo";
            public const int Ammo_sortIndex = 1250;
            [SortOrder(Ammo_sortIndex)]
            [DisplayName(Ammo_displayName)]
            public virtual ObservableCollection<Ammo> Ammo_raw { get; protected set; }

            public const int lastSortIndex = 1300;

            public IEnumerable<F> GetAllEnumerableChildrenOfType<F>() {
                if (typeof(Custom_Mods).Is(typeof(F)) || typeof(Custom_Mods).IsGeneric(typeof(F))) {
                    foreach (var item in Custom_Mods_raw.Cast<F>()) {
                        yield return item;
                    }
                }
                if (typeof(Armors).Is(typeof(F)) || typeof(Armors).IsGeneric(typeof(F))) {
                    foreach (var item in Armors_raw.Cast<F>()) {
                        yield return item;
                    }
                }
                if (typeof(Mantles).Is(typeof(F)) || typeof(Mantles).IsGeneric(typeof(F))) {
                    foreach (var item in Mantles_raw.Cast<F>()) {
                        yield return item;
                    }
                }
                if (typeof(Armor_Level).Is(typeof(F)) || typeof(Armor_Level).IsGeneric(typeof(F))) {
                    foreach (var item in Armor_Level_raw.Cast<F>()) {
                        yield return item;
                    }
                }
                if (typeof(Decorations).Is(typeof(F)) || typeof(Decorations).IsGeneric(typeof(F))) {
                    foreach (var item in Decorations_raw.Cast<F>()) {
                        yield return item;
                    }
                }
                if (typeof(Items).Is(typeof(F)) || typeof(Items).IsGeneric(typeof(F))) {
                    foreach (var item in Items_raw.Cast<F>()) {
                        yield return item;
                    }
                }
                if (typeof(Ammo).Is(typeof(F)) || typeof(Ammo).IsGeneric(typeof(F))) {
                    foreach (var item in Ammo_raw.Cast<F>()) {
                        yield return item;
                    }
                }
            }

            public static ObservableMhwStructCollection<Entries> LoadData(BinaryReader reader, ObservableMhwStructCollection<Aeq> lastStruct) {
                var list = new ObservableMhwStructCollection<Entries>();
                var countTarget = (Aeq) lastStruct.Last();
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
                data.Weapon_Type_raw = reader.ReadUInt32();
                data.Weapon_Id_raw = reader.ReadUInt32();
                data.Custom_Mods_raw = Custom_Mods.LoadData(reader, data);
                data.Armors_raw = Armors.LoadData(reader, data);
                data.Mantles_raw = Mantles.LoadData(reader, data);
                data.Armor_Level_raw = Armor_Level.LoadData(reader, data);
                data.Mantle_1_Upgraded__raw = reader.ReadByte();
                data.Mantle_2_Upgraded__raw = reader.ReadByte();
                data.Decorations_raw = Decorations.LoadData(reader, data);
                data.Kinsect_Id_for_IG_raw = reader.ReadUInt32();
                data.Kinsect_Lvl_for_IG_raw = reader.ReadUInt32();
                data.Unk_4_raw = reader.ReadUInt32();
                data.Unk_5_raw = reader.ReadUInt32();
                data.Unk_6_raw = reader.ReadUInt32();
                data.Augment_Augment_Slot_raw = reader.ReadByte();
                data.Augment_Attack_raw = reader.ReadByte();
                data.Augment_Affinity_raw = reader.ReadByte();
                data.Augment_Defense_raw = reader.ReadByte();
                data.Augment_Deco_Slot_raw = reader.ReadByte();
                data.Augment_Health_raw = reader.ReadByte();
                data.Augment_Element_Status_raw = reader.ReadByte();
                data.Unk_raw = reader.ReadByte();
                data.Items_raw = Items.LoadData(reader, data);
                data.Ammo_raw = Ammo.LoadData(reader, data);
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Id_raw);
                writer.Write(Weapon_Type_raw);
                writer.Write(Weapon_Id_raw);
                foreach (var obj in Custom_Mods_raw) {
                    obj.WriteData(writer, this);
                }
                foreach (var obj in Armors_raw) {
                    obj.WriteData(writer, this);
                }
                foreach (var obj in Mantles_raw) {
                    obj.WriteData(writer, this);
                }
                foreach (var obj in Armor_Level_raw) {
                    obj.WriteData(writer, this);
                }
                writer.Write(Mantle_1_Upgraded__raw);
                writer.Write(Mantle_2_Upgraded__raw);
                foreach (var obj in Decorations_raw) {
                    obj.WriteData(writer, this);
                }
                writer.Write(Kinsect_Id_for_IG_raw);
                writer.Write(Kinsect_Lvl_for_IG_raw);
                writer.Write(Unk_4_raw);
                writer.Write(Unk_5_raw);
                writer.Write(Unk_6_raw);
                writer.Write(Augment_Augment_Slot_raw);
                writer.Write(Augment_Attack_raw);
                writer.Write(Augment_Affinity_raw);
                writer.Write(Augment_Defense_raw);
                writer.Write(Augment_Deco_Slot_raw);
                writer.Write(Augment_Health_raw);
                writer.Write(Augment_Element_Status_raw);
                writer.Write(Unk_raw);
                foreach (var obj in Items_raw) {
                    obj.WriteData(writer, this);
                }
                foreach (var obj in Ammo_raw) {
                    obj.WriteData(writer, this);
                }
            }
        }

        public override void LoadFile(string targetFile) {
            using var reader = new BinaryReader(OpenFile(targetFile, EncryptionKey), Encoding.UTF8);
            data = new LinkedList<MhwStructDataContainer>();
            var Aeq_ = new MhwStructDataContainer<Aeq>(Aeq.LoadData(reader), typeof(Aeq));
            data.AddLast(Aeq_);
            var Entries_ = new MhwStructDataContainer<Entries, Aeq>(Entries.LoadData(reader, Aeq_.list), typeof(Entries));
            Entries_.SetCountTargetToUpdate(Aeq_, -1, "Entry_Count");
            data.AddLast(Entries_);
        }
    }
}
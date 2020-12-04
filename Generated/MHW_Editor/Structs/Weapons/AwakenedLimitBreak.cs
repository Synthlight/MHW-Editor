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
    public partial class AwakenedLimitBreak {
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

            protected ushort Skill_Id_raw;
            public const string Skill_Id_displayName = "Skill Id";
            public const int Skill_Id_sortIndex = 50;
            [SortOrder(Skill_Id_sortIndex)]
            [DisplayName(Skill_Id_displayName)]
            [DataSource(DataSourceType.Skills)]
            public virtual ushort Skill_Id {
                get => Skill_Id_raw;
                set {
                    if (Skill_Id_raw == value) return;
                    Skill_Id_raw = value;
                    ChangedItems.Add(nameof(Skill_Id));
                    OnPropertyChanged(nameof(Skill_Id));
                    OnPropertyChanged(nameof(Skill_Id_button));
                }
            }

            [SortOrder(Skill_Id_sortIndex)]
            [DisplayName(Skill_Id_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Skill_Id_button => DataHelper.skillNames[MainWindow.locale].TryGet(Skill_Id).ToStringWithId(Skill_Id);

            protected uint Group_Id_raw;
            public const string Group_Id_displayName = "Group Id";
            public const int Group_Id_sortIndex = 100;
            [SortOrder(Group_Id_sortIndex)]
            [DisplayName(Group_Id_displayName)]
            public virtual uint Group_Id {
                get => Group_Id_raw;
                set {
                    if (Group_Id_raw == value) return;
                    Group_Id_raw = value;
                    ChangedItems.Add(nameof(Group_Id));
                    OnPropertyChanged(nameof(Group_Id));
                }
            }

            protected uint Rarity_raw;
            public const string Rarity_displayName = "Rarity";
            public const int Rarity_sortIndex = 150;
            [SortOrder(Rarity_sortIndex)]
            [DisplayName(Rarity_displayName)]
            public virtual uint Rarity {
                get => Rarity_raw;
                set {
                    if (Rarity_raw == value) return;
                    Rarity_raw = value;
                    ChangedItems.Add(nameof(Rarity));
                    OnPropertyChanged(nameof(Rarity));
                }
            }

            protected uint Unk_raw;
            public const string Unk_displayName = "Unk";
            public const int Unk_sortIndex = 200;
            [SortOrder(Unk_sortIndex)]
            [DisplayName(Unk_displayName)]
            public virtual uint Unk {
                get => Unk_raw;
                set {
                    if (Unk_raw == value) return;
                    Unk_raw = value;
                    ChangedItems.Add(nameof(Unk));
                    OnPropertyChanged(nameof(Unk));
                }
            }

            protected byte Has_Upgrade_raw;
            public const string Has_Upgrade_displayName = "Has Upgrade";
            public const int Has_Upgrade_sortIndex = 250;
            [SortOrder(Has_Upgrade_sortIndex)]
            [DisplayName(Has_Upgrade_displayName)]
            public virtual bool Has_Upgrade {
                get => (bool) Convert.ToBoolean(Has_Upgrade_raw);
                set {
                    if (Convert.ToBoolean(Has_Upgrade_raw) == value) return;
                    Has_Upgrade_raw = Convert.ToByte(value);
                    ChangedItems.Add(nameof(Has_Upgrade));
                    OnPropertyChanged(nameof(Has_Upgrade));
                }
            }

            protected ushort Previous_Upgrade_Id_When_Max_Lvl_raw;
            public const string Previous_Upgrade_Id_When_Max_Lvl_displayName = "Previous Upgrade Id When Max Lvl";
            public const int Previous_Upgrade_Id_When_Max_Lvl_sortIndex = 300;
            [SortOrder(Previous_Upgrade_Id_When_Max_Lvl_sortIndex)]
            [DisplayName(Previous_Upgrade_Id_When_Max_Lvl_displayName)]
            public virtual ushort Previous_Upgrade_Id_When_Max_Lvl {
                get => Previous_Upgrade_Id_When_Max_Lvl_raw;
                set {
                    if (Previous_Upgrade_Id_When_Max_Lvl_raw == value) return;
                    Previous_Upgrade_Id_When_Max_Lvl_raw = value;
                    ChangedItems.Add(nameof(Previous_Upgrade_Id_When_Max_Lvl));
                    OnPropertyChanged(nameof(Previous_Upgrade_Id_When_Max_Lvl));
                }
            }

            protected ushort Next_Upgrade_Id_raw;
            public const string Next_Upgrade_Id_displayName = "Next Upgrade Id";
            public const int Next_Upgrade_Id_sortIndex = 350;
            [SortOrder(Next_Upgrade_Id_sortIndex)]
            [DisplayName(Next_Upgrade_Id_displayName)]
            public virtual ushort Next_Upgrade_Id {
                get => Next_Upgrade_Id_raw;
                set {
                    if (Next_Upgrade_Id_raw == value) return;
                    Next_Upgrade_Id_raw = value;
                    ChangedItems.Add(nameof(Next_Upgrade_Id));
                    OnPropertyChanged(nameof(Next_Upgrade_Id));
                }
            }

            protected byte Can_Stack_raw;
            public const string Can_Stack_displayName = "Can Stack";
            public const int Can_Stack_sortIndex = 400;
            [SortOrder(Can_Stack_sortIndex)]
            [DisplayName(Can_Stack_displayName)]
            public virtual bool Can_Stack {
                get => (bool) Convert.ToBoolean(Can_Stack_raw);
                set {
                    if (Convert.ToBoolean(Can_Stack_raw) == value) return;
                    Can_Stack_raw = Convert.ToByte(value);
                    ChangedItems.Add(nameof(Can_Stack));
                    OnPropertyChanged(nameof(Can_Stack));
                }
            }

            protected byte Unk8_raw;
            public const string Unk8_displayName = "Unk8";
            public const int Unk8_sortIndex = 450;
            [SortOrder(Unk8_sortIndex)]
            [DisplayName(Unk8_displayName)]
            public virtual bool Unk8 {
                get => (bool) Convert.ToBoolean(Unk8_raw);
                set {
                    if (Convert.ToBoolean(Unk8_raw) == value) return;
                    Unk8_raw = Convert.ToByte(value);
                    ChangedItems.Add(nameof(Unk8));
                    OnPropertyChanged(nameof(Unk8));
                }
            }

            protected ushort Lvl_1_Id_raw;
            public const string Lvl_1_Id_displayName = "Lvl 1 Id";
            public const int Lvl_1_Id_sortIndex = 500;
            [SortOrder(Lvl_1_Id_sortIndex)]
            [DisplayName(Lvl_1_Id_displayName)]
            public virtual ushort Lvl_1_Id {
                get => Lvl_1_Id_raw;
                set {
                    if (Lvl_1_Id_raw == value) return;
                    Lvl_1_Id_raw = value;
                    ChangedItems.Add(nameof(Lvl_1_Id));
                    OnPropertyChanged(nameof(Lvl_1_Id));
                }
            }

            protected ushort Lvl_2_Id_raw;
            public const string Lvl_2_Id_displayName = "Lvl 2 Id";
            public const int Lvl_2_Id_sortIndex = 550;
            [SortOrder(Lvl_2_Id_sortIndex)]
            [DisplayName(Lvl_2_Id_displayName)]
            public virtual ushort Lvl_2_Id {
                get => Lvl_2_Id_raw;
                set {
                    if (Lvl_2_Id_raw == value) return;
                    Lvl_2_Id_raw = value;
                    ChangedItems.Add(nameof(Lvl_2_Id));
                    OnPropertyChanged(nameof(Lvl_2_Id));
                }
            }

            protected ushort Lvl_3_Id_raw;
            public const string Lvl_3_Id_displayName = "Lvl 3 Id";
            public const int Lvl_3_Id_sortIndex = 600;
            [SortOrder(Lvl_3_Id_sortIndex)]
            [DisplayName(Lvl_3_Id_displayName)]
            public virtual ushort Lvl_3_Id {
                get => Lvl_3_Id_raw;
                set {
                    if (Lvl_3_Id_raw == value) return;
                    Lvl_3_Id_raw = value;
                    ChangedItems.Add(nameof(Lvl_3_Id));
                    OnPropertyChanged(nameof(Lvl_3_Id));
                }
            }

            protected ushort Lvl_4_Id_raw;
            public const string Lvl_4_Id_displayName = "Lvl 4 Id";
            public const int Lvl_4_Id_sortIndex = 650;
            [SortOrder(Lvl_4_Id_sortIndex)]
            [DisplayName(Lvl_4_Id_displayName)]
            public virtual ushort Lvl_4_Id {
                get => Lvl_4_Id_raw;
                set {
                    if (Lvl_4_Id_raw == value) return;
                    Lvl_4_Id_raw = value;
                    ChangedItems.Add(nameof(Lvl_4_Id));
                    OnPropertyChanged(nameof(Lvl_4_Id));
                }
            }

            protected ushort Lvl_5_Id_raw;
            public const string Lvl_5_Id_displayName = "Lvl 5 Id";
            public const int Lvl_5_Id_sortIndex = 700;
            [SortOrder(Lvl_5_Id_sortIndex)]
            [DisplayName(Lvl_5_Id_displayName)]
            public virtual ushort Lvl_5_Id {
                get => Lvl_5_Id_raw;
                set {
                    if (Lvl_5_Id_raw == value) return;
                    Lvl_5_Id_raw = value;
                    ChangedItems.Add(nameof(Lvl_5_Id));
                    OnPropertyChanged(nameof(Lvl_5_Id));
                }
            }

            protected byte Works_on_Great_Sword_raw;
            public const string Works_on_Great_Sword_displayName = "Works on Great Sword";
            public const int Works_on_Great_Sword_sortIndex = 750;
            [SortOrder(Works_on_Great_Sword_sortIndex)]
            [DisplayName(Works_on_Great_Sword_displayName)]
            public virtual bool Works_on_Great_Sword {
                get => (bool) Convert.ToBoolean(Works_on_Great_Sword_raw);
                set {
                    if (Convert.ToBoolean(Works_on_Great_Sword_raw) == value) return;
                    Works_on_Great_Sword_raw = Convert.ToByte(value);
                    ChangedItems.Add(nameof(Works_on_Great_Sword));
                    OnPropertyChanged(nameof(Works_on_Great_Sword));
                }
            }

            protected byte Works_on_Sword_Shield_raw;
            public const string Works_on_Sword_Shield_displayName = "Works on Sword & Shield";
            public const int Works_on_Sword_Shield_sortIndex = 800;
            [SortOrder(Works_on_Sword_Shield_sortIndex)]
            [DisplayName(Works_on_Sword_Shield_displayName)]
            public virtual bool Works_on_Sword_Shield {
                get => (bool) Convert.ToBoolean(Works_on_Sword_Shield_raw);
                set {
                    if (Convert.ToBoolean(Works_on_Sword_Shield_raw) == value) return;
                    Works_on_Sword_Shield_raw = Convert.ToByte(value);
                    ChangedItems.Add(nameof(Works_on_Sword_Shield));
                    OnPropertyChanged(nameof(Works_on_Sword_Shield));
                }
            }

            protected byte Works_on_Dual_Blades_raw;
            public const string Works_on_Dual_Blades_displayName = "Works on Dual Blades";
            public const int Works_on_Dual_Blades_sortIndex = 850;
            [SortOrder(Works_on_Dual_Blades_sortIndex)]
            [DisplayName(Works_on_Dual_Blades_displayName)]
            public virtual bool Works_on_Dual_Blades {
                get => (bool) Convert.ToBoolean(Works_on_Dual_Blades_raw);
                set {
                    if (Convert.ToBoolean(Works_on_Dual_Blades_raw) == value) return;
                    Works_on_Dual_Blades_raw = Convert.ToByte(value);
                    ChangedItems.Add(nameof(Works_on_Dual_Blades));
                    OnPropertyChanged(nameof(Works_on_Dual_Blades));
                }
            }

            protected byte Works_on_Long_Sword_raw;
            public const string Works_on_Long_Sword_displayName = "Works on Long Sword";
            public const int Works_on_Long_Sword_sortIndex = 900;
            [SortOrder(Works_on_Long_Sword_sortIndex)]
            [DisplayName(Works_on_Long_Sword_displayName)]
            public virtual bool Works_on_Long_Sword {
                get => (bool) Convert.ToBoolean(Works_on_Long_Sword_raw);
                set {
                    if (Convert.ToBoolean(Works_on_Long_Sword_raw) == value) return;
                    Works_on_Long_Sword_raw = Convert.ToByte(value);
                    ChangedItems.Add(nameof(Works_on_Long_Sword));
                    OnPropertyChanged(nameof(Works_on_Long_Sword));
                }
            }

            protected byte Works_on_Hammer_raw;
            public const string Works_on_Hammer_displayName = "Works on Hammer";
            public const int Works_on_Hammer_sortIndex = 950;
            [SortOrder(Works_on_Hammer_sortIndex)]
            [DisplayName(Works_on_Hammer_displayName)]
            public virtual bool Works_on_Hammer {
                get => (bool) Convert.ToBoolean(Works_on_Hammer_raw);
                set {
                    if (Convert.ToBoolean(Works_on_Hammer_raw) == value) return;
                    Works_on_Hammer_raw = Convert.ToByte(value);
                    ChangedItems.Add(nameof(Works_on_Hammer));
                    OnPropertyChanged(nameof(Works_on_Hammer));
                }
            }

            protected byte Works_on_Hunting_Horn_raw;
            public const string Works_on_Hunting_Horn_displayName = "Works on Hunting Horn";
            public const int Works_on_Hunting_Horn_sortIndex = 1000;
            [SortOrder(Works_on_Hunting_Horn_sortIndex)]
            [DisplayName(Works_on_Hunting_Horn_displayName)]
            public virtual bool Works_on_Hunting_Horn {
                get => (bool) Convert.ToBoolean(Works_on_Hunting_Horn_raw);
                set {
                    if (Convert.ToBoolean(Works_on_Hunting_Horn_raw) == value) return;
                    Works_on_Hunting_Horn_raw = Convert.ToByte(value);
                    ChangedItems.Add(nameof(Works_on_Hunting_Horn));
                    OnPropertyChanged(nameof(Works_on_Hunting_Horn));
                }
            }

            protected byte Works_on_Lance_raw;
            public const string Works_on_Lance_displayName = "Works on Lance";
            public const int Works_on_Lance_sortIndex = 1050;
            [SortOrder(Works_on_Lance_sortIndex)]
            [DisplayName(Works_on_Lance_displayName)]
            public virtual bool Works_on_Lance {
                get => (bool) Convert.ToBoolean(Works_on_Lance_raw);
                set {
                    if (Convert.ToBoolean(Works_on_Lance_raw) == value) return;
                    Works_on_Lance_raw = Convert.ToByte(value);
                    ChangedItems.Add(nameof(Works_on_Lance));
                    OnPropertyChanged(nameof(Works_on_Lance));
                }
            }

            protected byte Works_on_Gunlance_raw;
            public const string Works_on_Gunlance_displayName = "Works on Gunlance";
            public const int Works_on_Gunlance_sortIndex = 1100;
            [SortOrder(Works_on_Gunlance_sortIndex)]
            [DisplayName(Works_on_Gunlance_displayName)]
            public virtual bool Works_on_Gunlance {
                get => (bool) Convert.ToBoolean(Works_on_Gunlance_raw);
                set {
                    if (Convert.ToBoolean(Works_on_Gunlance_raw) == value) return;
                    Works_on_Gunlance_raw = Convert.ToByte(value);
                    ChangedItems.Add(nameof(Works_on_Gunlance));
                    OnPropertyChanged(nameof(Works_on_Gunlance));
                }
            }

            protected byte Works_on_Switch_Axe_raw;
            public const string Works_on_Switch_Axe_displayName = "Works on Switch Axe";
            public const int Works_on_Switch_Axe_sortIndex = 1150;
            [SortOrder(Works_on_Switch_Axe_sortIndex)]
            [DisplayName(Works_on_Switch_Axe_displayName)]
            public virtual bool Works_on_Switch_Axe {
                get => (bool) Convert.ToBoolean(Works_on_Switch_Axe_raw);
                set {
                    if (Convert.ToBoolean(Works_on_Switch_Axe_raw) == value) return;
                    Works_on_Switch_Axe_raw = Convert.ToByte(value);
                    ChangedItems.Add(nameof(Works_on_Switch_Axe));
                    OnPropertyChanged(nameof(Works_on_Switch_Axe));
                }
            }

            protected byte Works_on_Charge_Blade_raw;
            public const string Works_on_Charge_Blade_displayName = "Works on Charge Blade";
            public const int Works_on_Charge_Blade_sortIndex = 1200;
            [SortOrder(Works_on_Charge_Blade_sortIndex)]
            [DisplayName(Works_on_Charge_Blade_displayName)]
            public virtual bool Works_on_Charge_Blade {
                get => (bool) Convert.ToBoolean(Works_on_Charge_Blade_raw);
                set {
                    if (Convert.ToBoolean(Works_on_Charge_Blade_raw) == value) return;
                    Works_on_Charge_Blade_raw = Convert.ToByte(value);
                    ChangedItems.Add(nameof(Works_on_Charge_Blade));
                    OnPropertyChanged(nameof(Works_on_Charge_Blade));
                }
            }

            protected byte Works_on_Insect_Glaive_raw;
            public const string Works_on_Insect_Glaive_displayName = "Works on Insect Glaive";
            public const int Works_on_Insect_Glaive_sortIndex = 1250;
            [SortOrder(Works_on_Insect_Glaive_sortIndex)]
            [DisplayName(Works_on_Insect_Glaive_displayName)]
            public virtual bool Works_on_Insect_Glaive {
                get => (bool) Convert.ToBoolean(Works_on_Insect_Glaive_raw);
                set {
                    if (Convert.ToBoolean(Works_on_Insect_Glaive_raw) == value) return;
                    Works_on_Insect_Glaive_raw = Convert.ToByte(value);
                    ChangedItems.Add(nameof(Works_on_Insect_Glaive));
                    OnPropertyChanged(nameof(Works_on_Insect_Glaive));
                }
            }

            protected byte Works_on_Bow_raw;
            public const string Works_on_Bow_displayName = "Works on Bow";
            public const int Works_on_Bow_sortIndex = 1300;
            [SortOrder(Works_on_Bow_sortIndex)]
            [DisplayName(Works_on_Bow_displayName)]
            public virtual bool Works_on_Bow {
                get => (bool) Convert.ToBoolean(Works_on_Bow_raw);
                set {
                    if (Convert.ToBoolean(Works_on_Bow_raw) == value) return;
                    Works_on_Bow_raw = Convert.ToByte(value);
                    ChangedItems.Add(nameof(Works_on_Bow));
                    OnPropertyChanged(nameof(Works_on_Bow));
                }
            }

            protected byte Works_on_HBG_raw;
            public const string Works_on_HBG_displayName = "Works on HBG";
            public const int Works_on_HBG_sortIndex = 1350;
            [SortOrder(Works_on_HBG_sortIndex)]
            [DisplayName(Works_on_HBG_displayName)]
            public virtual bool Works_on_HBG {
                get => (bool) Convert.ToBoolean(Works_on_HBG_raw);
                set {
                    if (Convert.ToBoolean(Works_on_HBG_raw) == value) return;
                    Works_on_HBG_raw = Convert.ToByte(value);
                    ChangedItems.Add(nameof(Works_on_HBG));
                    OnPropertyChanged(nameof(Works_on_HBG));
                }
            }

            protected byte Works_on_LBG_raw;
            public const string Works_on_LBG_displayName = "Works on LBG";
            public const int Works_on_LBG_sortIndex = 1400;
            [SortOrder(Works_on_LBG_sortIndex)]
            [DisplayName(Works_on_LBG_displayName)]
            public virtual bool Works_on_LBG {
                get => (bool) Convert.ToBoolean(Works_on_LBG_raw);
                set {
                    if (Convert.ToBoolean(Works_on_LBG_raw) == value) return;
                    Works_on_LBG_raw = Convert.ToByte(value);
                    ChangedItems.Add(nameof(Works_on_LBG));
                    OnPropertyChanged(nameof(Works_on_LBG));
                }
            }

            protected byte Unk_1_raw;
            public const string Unk_1_displayName = "Unk 1";
            public const int Unk_1_sortIndex = 1450;
            [SortOrder(Unk_1_sortIndex)]
            [DisplayName(Unk_1_displayName)]
            public virtual byte Unk_1 {
                get => Unk_1_raw;
                set {
                    if (Unk_1_raw == value) return;
                    Unk_1_raw = value;
                    ChangedItems.Add(nameof(Unk_1));
                    OnPropertyChanged(nameof(Unk_1));
                }
            }

            protected byte Unk_2_raw;
            public const string Unk_2_displayName = "Unk 2";
            public const int Unk_2_sortIndex = 1500;
            [SortOrder(Unk_2_sortIndex)]
            [DisplayName(Unk_2_displayName)]
            public virtual byte Unk_2 {
                get => Unk_2_raw;
                set {
                    if (Unk_2_raw == value) return;
                    Unk_2_raw = value;
                    ChangedItems.Add(nameof(Unk_2));
                    OnPropertyChanged(nameof(Unk_2));
                }
            }

            protected byte Unk_3_raw;
            public const string Unk_3_displayName = "Unk 3";
            public const int Unk_3_sortIndex = 1550;
            [SortOrder(Unk_3_sortIndex)]
            [DisplayName(Unk_3_displayName)]
            public virtual byte Unk_3 {
                get => Unk_3_raw;
                set {
                    if (Unk_3_raw == value) return;
                    Unk_3_raw = value;
                    ChangedItems.Add(nameof(Unk_3));
                    OnPropertyChanged(nameof(Unk_3));
                }
            }

            protected byte Unk_4_raw;
            public const string Unk_4_displayName = "Unk 4";
            public const int Unk_4_sortIndex = 1600;
            [SortOrder(Unk_4_sortIndex)]
            [DisplayName(Unk_4_displayName)]
            public virtual byte Unk_4 {
                get => Unk_4_raw;
                set {
                    if (Unk_4_raw == value) return;
                    Unk_4_raw = value;
                    ChangedItems.Add(nameof(Unk_4));
                    OnPropertyChanged(nameof(Unk_4));
                }
            }

            public const int lastSortIndex = 1650;

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
                data.Skill_Id_raw = reader.ReadUInt16();
                data.Group_Id_raw = reader.ReadUInt32();
                data.Rarity_raw = reader.ReadUInt32();
                data.Unk_raw = reader.ReadUInt32();
                data.Has_Upgrade_raw = reader.ReadByte();
                data.Previous_Upgrade_Id_When_Max_Lvl_raw = reader.ReadUInt16();
                data.Next_Upgrade_Id_raw = reader.ReadUInt16();
                data.Can_Stack_raw = reader.ReadByte();
                data.Unk8_raw = reader.ReadByte();
                data.Lvl_1_Id_raw = reader.ReadUInt16();
                data.Lvl_2_Id_raw = reader.ReadUInt16();
                data.Lvl_3_Id_raw = reader.ReadUInt16();
                data.Lvl_4_Id_raw = reader.ReadUInt16();
                data.Lvl_5_Id_raw = reader.ReadUInt16();
                data.Works_on_Great_Sword_raw = reader.ReadByte();
                data.Works_on_Sword_Shield_raw = reader.ReadByte();
                data.Works_on_Dual_Blades_raw = reader.ReadByte();
                data.Works_on_Long_Sword_raw = reader.ReadByte();
                data.Works_on_Hammer_raw = reader.ReadByte();
                data.Works_on_Hunting_Horn_raw = reader.ReadByte();
                data.Works_on_Lance_raw = reader.ReadByte();
                data.Works_on_Gunlance_raw = reader.ReadByte();
                data.Works_on_Switch_Axe_raw = reader.ReadByte();
                data.Works_on_Charge_Blade_raw = reader.ReadByte();
                data.Works_on_Insect_Glaive_raw = reader.ReadByte();
                data.Works_on_Bow_raw = reader.ReadByte();
                data.Works_on_HBG_raw = reader.ReadByte();
                data.Works_on_LBG_raw = reader.ReadByte();
                data.Unk_1_raw = reader.ReadByte();
                data.Unk_2_raw = reader.ReadByte();
                data.Unk_3_raw = reader.ReadByte();
                data.Unk_4_raw = reader.ReadByte();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Skill_Id_raw);
                writer.Write(Group_Id_raw);
                writer.Write(Rarity_raw);
                writer.Write(Unk_raw);
                writer.Write(Has_Upgrade_raw);
                writer.Write(Previous_Upgrade_Id_When_Max_Lvl_raw);
                writer.Write(Next_Upgrade_Id_raw);
                writer.Write(Can_Stack_raw);
                writer.Write(Unk8_raw);
                writer.Write(Lvl_1_Id_raw);
                writer.Write(Lvl_2_Id_raw);
                writer.Write(Lvl_3_Id_raw);
                writer.Write(Lvl_4_Id_raw);
                writer.Write(Lvl_5_Id_raw);
                writer.Write(Works_on_Great_Sword_raw);
                writer.Write(Works_on_Sword_Shield_raw);
                writer.Write(Works_on_Dual_Blades_raw);
                writer.Write(Works_on_Long_Sword_raw);
                writer.Write(Works_on_Hammer_raw);
                writer.Write(Works_on_Hunting_Horn_raw);
                writer.Write(Works_on_Lance_raw);
                writer.Write(Works_on_Gunlance_raw);
                writer.Write(Works_on_Switch_Axe_raw);
                writer.Write(Works_on_Charge_Blade_raw);
                writer.Write(Works_on_Insect_Glaive_raw);
                writer.Write(Works_on_Bow_raw);
                writer.Write(Works_on_HBG_raw);
                writer.Write(Works_on_LBG_raw);
                writer.Write(Unk_1_raw);
                writer.Write(Unk_2_raw);
                writer.Write(Unk_3_raw);
                writer.Write(Unk_4_raw);
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
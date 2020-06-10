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
    public partial class RodInsect {
        public override string EncryptionKey => "SFghFQVFJycHnypExurPwut98ZZq1cwvm7lpDpASeP4biRhstQgULzlb";

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

            protected byte Attack_Type_raw;
            public const string Attack_Type_displayName = "Attack Type";
            public const int Attack_Type_sortIndex = 100;
            [SortOrder(Attack_Type_sortIndex)]
            [DisplayName(Attack_Type_displayName)]
            public virtual MHW_Template.Weapons.AttackType Attack_Type {
                get => (MHW_Template.Weapons.AttackType) Attack_Type_raw;
                set {
                    if ((MHW_Template.Weapons.AttackType) Attack_Type_raw == value) return;
                    Attack_Type_raw = (byte) value;
                    ChangedItems.Add(nameof(Attack_Type));
                    OnPropertyChanged(nameof(Attack_Type));
                }
            }

            protected byte Id_raw;
            public const string Id_displayName = "Id";
            public const int Id_sortIndex = 150;
            [SortOrder(Id_sortIndex)]
            [DisplayName(Id_displayName)]
            [IsReadOnly]
            public virtual byte Id {
                get => Id_raw;
                set {
                    if (Id_raw == value) return;
                    Id_raw = value;
                    ChangedItems.Add(nameof(Id));
                    OnPropertyChanged(nameof(Id));
                }
            }

            protected byte Tree_Position_Id_raw;
            public const string Tree_Position_Id_displayName = "Tree Position Id";
            [SortOrder(Tree_Position_Id_sortIndex)]
            [DisplayName(Tree_Position_Id_displayName)]
            public virtual byte Tree_Position_Id {
                get => Tree_Position_Id_raw;
                set {
                    if (Tree_Position_Id_raw == value) return;
                    Tree_Position_Id_raw = value;
                    ChangedItems.Add(nameof(Tree_Position_Id));
                    OnPropertyChanged(nameof(Tree_Position_Id));
                }
            }

            protected ushort Base_Model_Id_raw;
            public const string Base_Model_Id_displayName = "Base Model Id";
            public const int Base_Model_Id_sortIndex = 250;
            [SortOrder(Base_Model_Id_sortIndex)]
            [DisplayName(Base_Model_Id_displayName)]
            public virtual ushort Base_Model_Id {
                get => Base_Model_Id_raw;
                set {
                    if (Base_Model_Id_raw == value) return;
                    Base_Model_Id_raw = value;
                    ChangedItems.Add(nameof(Base_Model_Id));
                    OnPropertyChanged(nameof(Base_Model_Id));
                }
            }

            protected byte Tree_Id_raw;
            public const string Tree_Id_displayName = "Tree Id";
            [SortOrder(Tree_Id_sortIndex)]
            [DisplayName(Tree_Id_displayName)]
            public virtual byte Tree_Id {
                get => Tree_Id_raw;
                set {
                    if (Tree_Id_raw == value) return;
                    Tree_Id_raw = value;
                    ChangedItems.Add(nameof(Tree_Id));
                    OnPropertyChanged(nameof(Tree_Id));
                }
            }

            protected uint Craft_Cost_raw;
            public const string Craft_Cost_displayName = "Craft Cost";
            public const int Craft_Cost_sortIndex = 350;
            [SortOrder(Craft_Cost_sortIndex)]
            [DisplayName(Craft_Cost_displayName)]
            public virtual uint Craft_Cost {
                get => Craft_Cost_raw;
                set {
                    if (Craft_Cost_raw == value) return;
                    Craft_Cost_raw = value;
                    ChangedItems.Add(nameof(Craft_Cost));
                    OnPropertyChanged(nameof(Craft_Cost));
                }
            }

            protected byte Rarity_raw;
            public const string Rarity_displayName = "Rarity";
            public const int Rarity_sortIndex = 400;
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

            protected ushort Power_raw;
            public const string Power_displayName = "Power";
            public const int Power_sortIndex = 450;
            [SortOrder(Power_sortIndex)]
            [DisplayName(Power_displayName)]
            public virtual ushort Power {
                get => Power_raw;
                set {
                    if (Power_raw == value) return;
                    Power_raw = value;
                    ChangedItems.Add(nameof(Power));
                    OnPropertyChanged(nameof(Power));
                }
            }

            protected ushort Speed_raw;
            public const string Speed_displayName = "Speed";
            public const int Speed_sortIndex = 500;
            [SortOrder(Speed_sortIndex)]
            [DisplayName(Speed_displayName)]
            public virtual ushort Speed {
                get => Speed_raw;
                set {
                    if (Speed_raw == value) return;
                    Speed_raw = value;
                    ChangedItems.Add(nameof(Speed));
                    OnPropertyChanged(nameof(Speed));
                }
            }

            protected ushort Heal_raw;
            public const string Heal_displayName = "Heal";
            public const int Heal_sortIndex = 550;
            [SortOrder(Heal_sortIndex)]
            [DisplayName(Heal_displayName)]
            public virtual ushort Heal {
                get => Heal_raw;
                set {
                    if (Heal_raw == value) return;
                    Heal_raw = value;
                    ChangedItems.Add(nameof(Heal));
                    OnPropertyChanged(nameof(Heal));
                }
            }

            protected ushort Element_raw;
            public const string Element_displayName = "Element";
            public const int Element_sortIndex = 600;
            [SortOrder(Element_sortIndex)]
            [DisplayName(Element_displayName)]
            public virtual ushort Element {
                get => Element_raw;
                set {
                    if (Element_raw == value) return;
                    Element_raw = value;
                    ChangedItems.Add(nameof(Element));
                    OnPropertyChanged(nameof(Element));
                }
            }

            protected ushort Dust_Effect_raw;
            public const string Dust_Effect_displayName = "Dust Effect";
            public const int Dust_Effect_sortIndex = 650;
            [SortOrder(Dust_Effect_sortIndex)]
            [DisplayName(Dust_Effect_displayName)]
            public virtual MHW_Template.Weapons.DustEffect Dust_Effect {
                get => (MHW_Template.Weapons.DustEffect) Dust_Effect_raw;
                set {
                    if ((MHW_Template.Weapons.DustEffect) Dust_Effect_raw == value) return;
                    Dust_Effect_raw = (ushort) value;
                    ChangedItems.Add(nameof(Dust_Effect));
                    OnPropertyChanged(nameof(Dust_Effect));
                }
            }

            protected byte Tree_Position_raw;
            public const string Tree_Position_displayName = "Tree Position";
            public const int Tree_Position_sortIndex = 700;
            [SortOrder(Tree_Position_sortIndex)]
            [DisplayName(Tree_Position_displayName)]
            public virtual byte Tree_Position {
                get => Tree_Position_raw;
                set {
                    if (Tree_Position_raw == value) return;
                    Tree_Position_raw = value;
                    ChangedItems.Add(nameof(Tree_Position));
                    OnPropertyChanged(nameof(Tree_Position));
                }
            }

            protected ushort Equip_Id_raw;
            public const string Equip_Id_displayName = "Equip Id";
            public const int Equip_Id_sortIndex = 750;
            [SortOrder(Equip_Id_sortIndex)]
            [DisplayName(Equip_Id_displayName)]
            public virtual ushort Equip_Id {
                get => Equip_Id_raw;
                set {
                    if (Equip_Id_raw == value) return;
                    Equip_Id_raw = value;
                    ChangedItems.Add(nameof(Equip_Id));
                    OnPropertyChanged(nameof(Equip_Id));
                }
            }

            public const int lastSortIndex = 800;

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
                data.Attack_Type_raw = reader.ReadByte();
                data.Id_raw = reader.ReadByte();
                data.Tree_Position_Id_raw = reader.ReadByte();
                data.Base_Model_Id_raw = reader.ReadUInt16();
                data.Tree_Id_raw = reader.ReadByte();
                data.Craft_Cost_raw = reader.ReadUInt32();
                data.Rarity_raw = reader.ReadByte();
                data.Power_raw = reader.ReadUInt16();
                data.Speed_raw = reader.ReadUInt16();
                data.Heal_raw = reader.ReadUInt16();
                data.Element_raw = reader.ReadUInt16();
                data.Dust_Effect_raw = reader.ReadUInt16();
                data.Tree_Position_raw = reader.ReadByte();
                data.Equip_Id_raw = reader.ReadUInt16();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Index_raw);
                writer.Write(Attack_Type_raw);
                writer.Write(Id_raw);
                writer.Write(Tree_Position_Id_raw);
                writer.Write(Base_Model_Id_raw);
                writer.Write(Tree_Id_raw);
                writer.Write(Craft_Cost_raw);
                writer.Write(Rarity_raw);
                writer.Write(Power_raw);
                writer.Write(Speed_raw);
                writer.Write(Heal_raw);
                writer.Write(Element_raw);
                writer.Write(Dust_Effect_raw);
                writer.Write(Tree_Position_raw);
                writer.Write(Equip_Id_raw);
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
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
    public partial class OtomoWeaponDat {
        public override string EncryptionKey => "FZoS8QLyOyeFmkdrz73P9Fh2N4NcTwy3QQPjc1YRII5KWovK6yFuU8SL";

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
            public override string UniqueId => "{Id}";

            protected uint Index_raw;
            public const string Index_displayName = "Index";
            public const int Index_sortIndex = 50;
            [SortOrder(Index_sortIndex)]
            [DisplayName(Index_displayName)]
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
            public virtual ushort Set_Id {
                get => Set_Id_raw;
                set {
                    if (Set_Id_raw == value) return;
                    Set_Id_raw = value;
                    OnPropertyChanged(nameof(Set_Id));
                }
            }

            protected byte Element_raw;
            public const string Element_displayName = "Element";
            public const int Element_sortIndex = 150;
            [SortOrder(Element_sortIndex)]
            [DisplayName(Element_displayName)]
            public virtual MHW_Template.Weapons.Element Element {
                get => (MHW_Template.Weapons.Element) Element_raw;
                set {
                    if ((MHW_Template.Weapons.Element) Element_raw == value) return;
                    Element_raw = (byte) value;
                    OnPropertyChanged(nameof(Element));
                }
            }

            protected ushort Attack_Type_raw;
            public const string Attack_Type_displayName = "Attack Type";
            public const int Attack_Type_sortIndex = 200;
            [SortOrder(Attack_Type_sortIndex)]
            [DisplayName(Attack_Type_displayName)]
            public virtual MHW_Template.Weapons.AttackType Attack_Type {
                get => (MHW_Template.Weapons.AttackType) Attack_Type_raw;
                set {
                    if ((MHW_Template.Weapons.AttackType) Attack_Type_raw == value) return;
                    Attack_Type_raw = (ushort) value;
                    OnPropertyChanged(nameof(Attack_Type));
                }
            }

            protected ushort Melee_Damage_raw;
            public const string Melee_Damage_displayName = "Melee Damage";
            public const int Melee_Damage_sortIndex = 250;
            [SortOrder(Melee_Damage_sortIndex)]
            [DisplayName(Melee_Damage_displayName)]
            public virtual ushort Melee_Damage {
                get => Melee_Damage_raw;
                set {
                    if (Melee_Damage_raw == value) return;
                    Melee_Damage_raw = value;
                    OnPropertyChanged(nameof(Melee_Damage));
                }
            }

            protected ushort Ranged_Damage_raw;
            public const string Ranged_Damage_displayName = "Ranged Damage";
            public const int Ranged_Damage_sortIndex = 300;
            [SortOrder(Ranged_Damage_sortIndex)]
            [DisplayName(Ranged_Damage_displayName)]
            public virtual ushort Ranged_Damage {
                get => Ranged_Damage_raw;
                set {
                    if (Ranged_Damage_raw == value) return;
                    Ranged_Damage_raw = value;
                    OnPropertyChanged(nameof(Ranged_Damage));
                }
            }

            protected ushort Elemental_Damage_raw;
            public const string Elemental_Damage_displayName = "Elemental Damage";
            public const int Elemental_Damage_sortIndex = 350;
            [SortOrder(Elemental_Damage_sortIndex)]
            [DisplayName(Elemental_Damage_displayName)]
            public virtual ushort Elemental_Damage {
                get => Elemental_Damage_raw;
                set {
                    if (Elemental_Damage_raw == value) return;
                    Elemental_Damage_raw = value;
                    OnPropertyChanged(nameof(Elemental_Damage));
                }
            }

            protected short Affinity_raw;
            public const string Affinity_displayName = "Affinity";
            public const int Affinity_sortIndex = 400;
            [SortOrder(Affinity_sortIndex)]
            [DisplayName(Affinity_displayName)]
            public virtual short Affinity {
                get => Affinity_raw;
                set {
                    if (Affinity_raw == value) return;
                    Affinity_raw = value;
                    OnPropertyChanged(nameof(Affinity));
                }
            }

            protected ushort Defense_raw;
            public const string Defense_displayName = "Defense";
            public const int Defense_sortIndex = 450;
            [SortOrder(Defense_sortIndex)]
            [DisplayName(Defense_displayName)]
            public virtual ushort Defense {
                get => Defense_raw;
                set {
                    if (Defense_raw == value) return;
                    Defense_raw = value;
                    OnPropertyChanged(nameof(Defense));
                }
            }

            protected byte Elderseal_raw;
            public const string Elderseal_displayName = "Elderseal";
            public const int Elderseal_sortIndex = 500;
            [SortOrder(Elderseal_sortIndex)]
            [DisplayName(Elderseal_displayName)]
            public virtual byte Elderseal {
                get => Elderseal_raw;
                set {
                    if (Elderseal_raw == value) return;
                    Elderseal_raw = value;
                    OnPropertyChanged(nameof(Elderseal));
                }
            }

            protected byte Rarity_raw;
            public const string Rarity_displayName = "Rarity";
            public const int Rarity_sortIndex = 550;
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
            public const int Order_sortIndex = 600;
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

            protected uint Unk_raw;
            public const string Unk_displayName = "Unk";
            public const int Unk_sortIndex = 650;
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

            protected uint Cost_raw;
            public const string Cost_displayName = "Cost";
            public const int Cost_sortIndex = 700;
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

            protected byte Unknown_byte_1_raw;
            public const string Unknown_byte_1_displayName = "Unknown (byte) 1";
            public const int Unknown_byte_1_sortIndex = 750;
            [SortOrder(Unknown_byte_1_sortIndex)]
            [DisplayName(Unknown_byte_1_displayName)]
            public virtual byte Unknown_byte_1 {
                get => Unknown_byte_1_raw;
                set {
                    if (Unknown_byte_1_raw == value) return;
                    Unknown_byte_1_raw = value;
                    OnPropertyChanged(nameof(Unknown_byte_1));
                }
            }

            protected ushort Id_raw;
            public const string Id_displayName = "Id";
            [SortOrder(Id_sortIndex)]
            [DisplayName(Id_displayName)]
            public virtual ushort Id {
                get => Id_raw;
                set {
                    if (Id_raw == value) return;
                    Id_raw = value;
                    OnPropertyChanged(nameof(Id));
                }
            }

            protected ushort GMD_Name_Index_raw;
            public const string GMD_Name_Index_displayName = "GMD Name Index";
            public const int GMD_Name_Index_sortIndex = 850;
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
            public const int GMD_Description_Index_sortIndex = 900;
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
                data.Index_raw = reader.ReadUInt32();
                data.Set_Id_raw = reader.ReadUInt16();
                data.Element_raw = reader.ReadByte();
                data.Attack_Type_raw = reader.ReadUInt16();
                data.Melee_Damage_raw = reader.ReadUInt16();
                data.Ranged_Damage_raw = reader.ReadUInt16();
                data.Elemental_Damage_raw = reader.ReadUInt16();
                data.Affinity_raw = reader.ReadInt16();
                data.Defense_raw = reader.ReadUInt16();
                data.Elderseal_raw = reader.ReadByte();
                data.Rarity_raw = reader.ReadByte();
                data.Order_raw = reader.ReadUInt16();
                data.Unk_raw = reader.ReadUInt32();
                data.Cost_raw = reader.ReadUInt32();
                data.Unknown_byte_1_raw = reader.ReadByte();
                data.Id_raw = reader.ReadUInt16();
                data.GMD_Name_Index_raw = reader.ReadUInt16();
                data.GMD_Description_Index_raw = reader.ReadUInt16();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Index_raw);
                writer.Write(Set_Id_raw);
                writer.Write(Element_raw);
                writer.Write(Attack_Type_raw);
                writer.Write(Melee_Damage_raw);
                writer.Write(Ranged_Damage_raw);
                writer.Write(Elemental_Damage_raw);
                writer.Write(Affinity_raw);
                writer.Write(Defense_raw);
                writer.Write(Elderseal_raw);
                writer.Write(Rarity_raw);
                writer.Write(Order_raw);
                writer.Write(Unk_raw);
                writer.Write(Cost_raw);
                writer.Write(Unknown_byte_1_raw);
                writer.Write(Id_raw);
                writer.Write(GMD_Name_Index_raw);
                writer.Write(GMD_Description_Index_raw);
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
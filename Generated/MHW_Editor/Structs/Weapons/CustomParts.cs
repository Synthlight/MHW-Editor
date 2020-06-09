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
    public partial class CustomParts {
        public override string EncryptionKey => "PCEBFfRCbwIdy6AZIoNA5lXV6FEki0yBEyW4FPXZUyWgeauqY8PYeZkM";

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
            public override string UniqueId => "{Id}|{Weapon_Type}";

            protected uint Id_raw;
            public const string Id_displayName = "Id";
            public const int Id_sortIndex = 50;
            [SortOrder(Id_sortIndex)]
            [DisplayName(Id_displayName)]
            [IsReadOnly]
            public virtual uint Id {
                get => Id_raw;
                set {
                    if (Id_raw == value) return;
                    Id_raw = value;
                    OnPropertyChanged(nameof(Id));
                }
            }

            protected uint Weapon_Type_raw;
            public const string Weapon_Type_displayName = "Weapon Type";
            public const int Weapon_Type_sortIndex = 100;
            [SortOrder(Weapon_Type_sortIndex)]
            [DisplayName(Weapon_Type_displayName)]
            [IsReadOnly]
            public virtual MHW_Template.Weapons.WeaponType Weapon_Type {
                get => (MHW_Template.Weapons.WeaponType) Weapon_Type_raw;
                set {
                    if ((MHW_Template.Weapons.WeaponType) Weapon_Type_raw == value) return;
                    Weapon_Type_raw = (uint) value;
                    OnPropertyChanged(nameof(Weapon_Type));
                }
            }

            protected uint Part_1_Id_raw;
            public const string Part_1_Id_displayName = "Part 1 Id";
            public const int Part_1_Id_sortIndex = 150;
            [SortOrder(Part_1_Id_sortIndex)]
            [DisplayName(Part_1_Id_displayName)]
            public virtual uint Part_1_Id {
                get => Part_1_Id_raw;
                set {
                    if (Part_1_Id_raw == value) return;
                    Part_1_Id_raw = value;
                    OnPropertyChanged(nameof(Part_1_Id));
                }
            }

            protected byte Unk_uint8__raw;
            public const string Unk_uint8__displayName = "Unk (uint8)";
            public const int Unk_uint8__sortIndex = 200;
            [SortOrder(Unk_uint8__sortIndex)]
            [DisplayName(Unk_uint8__displayName)]
            public virtual byte Unk_uint8_ {
                get => Unk_uint8__raw;
                set {
                    if (Unk_uint8__raw == value) return;
                    Unk_uint8__raw = value;
                    OnPropertyChanged(nameof(Unk_uint8_));
                }
            }

            protected uint Craft_Cost_raw;
            public const string Craft_Cost_displayName = "Craft Cost";
            public const int Craft_Cost_sortIndex = 250;
            [SortOrder(Craft_Cost_sortIndex)]
            [DisplayName(Craft_Cost_displayName)]
            public virtual uint Craft_Cost {
                get => Craft_Cost_raw;
                set {
                    if (Craft_Cost_raw == value) return;
                    Craft_Cost_raw = value;
                    OnPropertyChanged(nameof(Craft_Cost));
                }
            }

            protected ushort Attack_raw;
            public const string Attack_displayName = "Attack";
            public const int Attack_sortIndex = 300;
            [SortOrder(Attack_sortIndex)]
            [DisplayName(Attack_displayName)]
            public virtual ushort Attack {
                get => Attack_raw;
                set {
                    if (Attack_raw == value) return;
                    Attack_raw = value;
                    OnPropertyChanged(nameof(Attack));
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
                    OnPropertyChanged(nameof(Defense));
                }
            }

            protected byte Affinity_raw;
            public const string Affinity_displayName = "Affinity";
            public const int Affinity_sortIndex = 400;
            [SortOrder(Affinity_sortIndex)]
            [DisplayName(Affinity_displayName)]
            public virtual byte Affinity {
                get => Affinity_raw;
                set {
                    if (Affinity_raw == value) return;
                    Affinity_raw = value;
                    OnPropertyChanged(nameof(Affinity));
                }
            }

            protected ushort Element_raw;
            public const string Element_displayName = "Element";
            public const int Element_sortIndex = 450;
            [SortOrder(Element_sortIndex)]
            [DisplayName(Element_displayName)]
            public virtual ushort Element {
                get => Element_raw;
                set {
                    if (Element_raw == value) return;
                    Element_raw = value;
                    OnPropertyChanged(nameof(Element));
                }
            }

            protected byte Sharpness_raw;
            public const string Sharpness_displayName = "Sharpness";
            public const int Sharpness_sortIndex = 500;
            [SortOrder(Sharpness_sortIndex)]
            [DisplayName(Sharpness_displayName)]
            public virtual byte Sharpness {
                get => Sharpness_raw;
                set {
                    if (Sharpness_raw == value) return;
                    Sharpness_raw = value;
                    OnPropertyChanged(nameof(Sharpness));
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
                data.Id_raw = reader.ReadUInt32();
                data.Weapon_Type_raw = reader.ReadUInt32();
                data.Part_1_Id_raw = reader.ReadUInt32();
                data.Unk_uint8__raw = reader.ReadByte();
                data.Craft_Cost_raw = reader.ReadUInt32();
                data.Attack_raw = reader.ReadUInt16();
                data.Defense_raw = reader.ReadUInt16();
                data.Affinity_raw = reader.ReadByte();
                data.Element_raw = reader.ReadUInt16();
                data.Sharpness_raw = reader.ReadByte();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Id_raw);
                writer.Write(Weapon_Type_raw);
                writer.Write(Part_1_Id_raw);
                writer.Write(Unk_uint8__raw);
                writer.Write(Craft_Cost_raw);
                writer.Write(Attack_raw);
                writer.Write(Defense_raw);
                writer.Write(Affinity_raw);
                writer.Write(Element_raw);
                writer.Write(Sharpness_raw);
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
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
    public partial class KulveItemLottery {
        public override string EncryptionKey => null;

        public partial class Header : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Header";

            protected ushort Magic_1_raw;
            public const string Magic_1_displayName = "Magic 1";
            public const int Magic_1_sortIndex = 50;
            [SortOrder(Magic_1_sortIndex)]
            [DisplayName(Magic_1_displayName)]
            [IsReadOnly]
            public virtual ushort Magic_1 {
                get => Magic_1_raw;
                set {
                    if (Magic_1_raw == value) return;
                    Magic_1_raw = value;
                    ChangedItems.Add(nameof(Magic_1));
                    OnPropertyChanged(nameof(Magic_1));
                }
            }

            protected uint Entry_Count_raw;
            public const string Entry_Count_displayName = "Entry Count";
            public const int Entry_Count_sortIndex = 100;
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

            public const int lastSortIndex = 150;

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
                data.Magic_1_raw = reader.ReadUInt16();
                data.Entry_Count_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Magic_1_raw);
                writer.Write(Entry_Count_raw);
            }
        }

        public partial class Entries : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 0;
            public const string GridName = "Entries";

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
                    ChangedItems.Add(nameof(Index));
                    OnPropertyChanged(nameof(Index));
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
                    OnPropertyChanged(nameof(Weapon_Id_button));
                }
            }

            protected uint Weapon_Id_raw;
            public const string Weapon_Id_displayName = "Weapon Id";
            public const int Weapon_Id_sortIndex = 150;
            [SortOrder(Weapon_Id_sortIndex)]
            [DisplayName(Weapon_Id_displayName)]
            [DataSource(DataSourceType.WeaponsById)]
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
            public string Weapon_Id_button => DataHelper.weaponIdNameLookup[GetWeaponType()][MainWindow.locale].TryGet(Weapon_Id).ToStringWithId(Weapon_Id);

            protected uint Grade_1_raw;
            public const string Grade_1_displayName = "Grade 1";
            public const int Grade_1_sortIndex = 200;
            [SortOrder(Grade_1_sortIndex)]
            [DisplayName(Grade_1_displayName)]
            public virtual uint Grade_1 {
                get => Grade_1_raw;
                set {
                    if (Grade_1_raw == value) return;
                    Grade_1_raw = value;
                    ChangedItems.Add(nameof(Grade_1));
                    OnPropertyChanged(nameof(Grade_1));
                }
            }

            protected uint Grade_2_raw;
            public const string Grade_2_displayName = "Grade 2";
            public const int Grade_2_sortIndex = 250;
            [SortOrder(Grade_2_sortIndex)]
            [DisplayName(Grade_2_displayName)]
            public virtual uint Grade_2 {
                get => Grade_2_raw;
                set {
                    if (Grade_2_raw == value) return;
                    Grade_2_raw = value;
                    ChangedItems.Add(nameof(Grade_2));
                    OnPropertyChanged(nameof(Grade_2));
                }
            }

            protected uint Grade_3_raw;
            public const string Grade_3_displayName = "Grade 3";
            public const int Grade_3_sortIndex = 300;
            [SortOrder(Grade_3_sortIndex)]
            [DisplayName(Grade_3_displayName)]
            public virtual uint Grade_3 {
                get => Grade_3_raw;
                set {
                    if (Grade_3_raw == value) return;
                    Grade_3_raw = value;
                    ChangedItems.Add(nameof(Grade_3));
                    OnPropertyChanged(nameof(Grade_3));
                }
            }

            protected uint Grade_4_raw;
            public const string Grade_4_displayName = "Grade 4";
            public const int Grade_4_sortIndex = 350;
            [SortOrder(Grade_4_sortIndex)]
            [DisplayName(Grade_4_displayName)]
            public virtual uint Grade_4 {
                get => Grade_4_raw;
                set {
                    if (Grade_4_raw == value) return;
                    Grade_4_raw = value;
                    ChangedItems.Add(nameof(Grade_4));
                    OnPropertyChanged(nameof(Grade_4));
                }
            }

            protected uint Grade_5_raw;
            public const string Grade_5_displayName = "Grade 5";
            public const int Grade_5_sortIndex = 400;
            [SortOrder(Grade_5_sortIndex)]
            [DisplayName(Grade_5_displayName)]
            public virtual uint Grade_5 {
                get => Grade_5_raw;
                set {
                    if (Grade_5_raw == value) return;
                    Grade_5_raw = value;
                    ChangedItems.Add(nameof(Grade_5));
                    OnPropertyChanged(nameof(Grade_5));
                }
            }

            public const int lastSortIndex = 450;

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
                data.Weapon_Type_raw = reader.ReadUInt32();
                data.Weapon_Id_raw = reader.ReadUInt32();
                data.Grade_1_raw = reader.ReadUInt32();
                data.Grade_2_raw = reader.ReadUInt32();
                data.Grade_3_raw = reader.ReadUInt32();
                data.Grade_4_raw = reader.ReadUInt32();
                data.Grade_5_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Index_raw);
                writer.Write(Weapon_Type_raw);
                writer.Write(Weapon_Id_raw);
                writer.Write(Grade_1_raw);
                writer.Write(Grade_2_raw);
                writer.Write(Grade_3_raw);
                writer.Write(Grade_4_raw);
                writer.Write(Grade_5_raw);
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
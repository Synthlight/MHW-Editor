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
    public partial class GunnerShoot {
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
            public override string UniqueId => $"{Id}";

            protected byte No_Mods_raw;
            public const string No_Mods_displayName = "No Mods";
            public const int No_Mods_sortIndex = 50;
            [SortOrder(No_Mods_sortIndex)]
            [DisplayName(No_Mods_displayName)]
            [DataSource(DataSourceType.GunnerRecoil)]
            public virtual byte No_Mods {
                get => No_Mods_raw;
                set {
                    if (No_Mods_raw == value) return;
                    No_Mods_raw = value;
                    ChangedItems.Add(nameof(No_Mods));
                    OnPropertyChanged(nameof(No_Mods));
                    OnPropertyChanged(nameof(No_Mods_button));
                }
            }

            [SortOrder(No_Mods_sortIndex)]
            [DisplayName(No_Mods_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string No_Mods_button => GunnerShoot.recoilLookup.TryGet(No_Mods).ToStringWithId(No_Mods);

            protected byte Mod_1_raw;
            public const string Mod_1_displayName = "Mod 1";
            public const int Mod_1_sortIndex = 100;
            [SortOrder(Mod_1_sortIndex)]
            [DisplayName(Mod_1_displayName)]
            [DataSource(DataSourceType.GunnerRecoil)]
            public virtual byte Mod_1 {
                get => Mod_1_raw;
                set {
                    if (Mod_1_raw == value) return;
                    Mod_1_raw = value;
                    ChangedItems.Add(nameof(Mod_1));
                    OnPropertyChanged(nameof(Mod_1));
                    OnPropertyChanged(nameof(Mod_1_button));
                }
            }

            [SortOrder(Mod_1_sortIndex)]
            [DisplayName(Mod_1_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Mod_1_button => GunnerShoot.recoilLookup.TryGet(Mod_1).ToStringWithId(Mod_1);

            protected byte Mod_2_raw;
            public const string Mod_2_displayName = "Mod 2";
            public const int Mod_2_sortIndex = 150;
            [SortOrder(Mod_2_sortIndex)]
            [DisplayName(Mod_2_displayName)]
            [DataSource(DataSourceType.GunnerRecoil)]
            public virtual byte Mod_2 {
                get => Mod_2_raw;
                set {
                    if (Mod_2_raw == value) return;
                    Mod_2_raw = value;
                    ChangedItems.Add(nameof(Mod_2));
                    OnPropertyChanged(nameof(Mod_2));
                    OnPropertyChanged(nameof(Mod_2_button));
                }
            }

            [SortOrder(Mod_2_sortIndex)]
            [DisplayName(Mod_2_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Mod_2_button => GunnerShoot.recoilLookup.TryGet(Mod_2).ToStringWithId(Mod_2);

            protected byte Mod_3_raw;
            public const string Mod_3_displayName = "Mod 3";
            public const int Mod_3_sortIndex = 200;
            [SortOrder(Mod_3_sortIndex)]
            [DisplayName(Mod_3_displayName)]
            [DataSource(DataSourceType.GunnerRecoil)]
            public virtual byte Mod_3 {
                get => Mod_3_raw;
                set {
                    if (Mod_3_raw == value) return;
                    Mod_3_raw = value;
                    ChangedItems.Add(nameof(Mod_3));
                    OnPropertyChanged(nameof(Mod_3));
                    OnPropertyChanged(nameof(Mod_3_button));
                }
            }

            [SortOrder(Mod_3_sortIndex)]
            [DisplayName(Mod_3_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Mod_3_button => GunnerShoot.recoilLookup.TryGet(Mod_3).ToStringWithId(Mod_3);

            protected byte Mod_4_raw;
            public const string Mod_4_displayName = "Mod 4";
            public const int Mod_4_sortIndex = 250;
            [SortOrder(Mod_4_sortIndex)]
            [DisplayName(Mod_4_displayName)]
            [DataSource(DataSourceType.GunnerRecoil)]
            public virtual byte Mod_4 {
                get => Mod_4_raw;
                set {
                    if (Mod_4_raw == value) return;
                    Mod_4_raw = value;
                    ChangedItems.Add(nameof(Mod_4));
                    OnPropertyChanged(nameof(Mod_4));
                    OnPropertyChanged(nameof(Mod_4_button));
                }
            }

            [SortOrder(Mod_4_sortIndex)]
            [DisplayName(Mod_4_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Mod_4_button => GunnerShoot.recoilLookup.TryGet(Mod_4).ToStringWithId(Mod_4);

            public const int lastSortIndex = 300;

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
                data.No_Mods_raw = reader.ReadByte();
                data.Mod_1_raw = reader.ReadByte();
                data.Mod_2_raw = reader.ReadByte();
                data.Mod_3_raw = reader.ReadByte();
                data.Mod_4_raw = reader.ReadByte();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(No_Mods_raw);
                writer.Write(Mod_1_raw);
                writer.Write(Mod_2_raw);
                writer.Write(Mod_3_raw);
                writer.Write(Mod_4_raw);
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
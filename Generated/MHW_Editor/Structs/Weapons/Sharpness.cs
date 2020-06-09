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
    public partial class Sharpness {
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

            protected ushort Red_raw;
            public const string Red_displayName = "Red";
            public const int Red_sortIndex = 100;
            [SortOrder(Red_sortIndex)]
            [DisplayName(Red_displayName)]
            public virtual ushort Red {
                get => Red_raw;
                set {
                    if (Red_raw == value.Clamp((ushort) 0, (ushort) 400)) return;
                    Red_raw = value.Clamp((ushort) 0, (ushort) 400);
                    OnPropertyChanged(nameof(Red));
                }
            }

            protected ushort Orange_raw;
            public const string Orange_displayName = "Orange";
            public const int Orange_sortIndex = 150;
            [SortOrder(Orange_sortIndex)]
            [DisplayName(Orange_displayName)]
            public virtual ushort Orange {
                get => Orange_raw;
                set {
                    if (Orange_raw == value.Clamp((ushort) 0, (ushort) 400)) return;
                    Orange_raw = value.Clamp((ushort) 0, (ushort) 400);
                    OnPropertyChanged(nameof(Orange));
                }
            }

            protected ushort Yellow_raw;
            public const string Yellow_displayName = "Yellow";
            public const int Yellow_sortIndex = 200;
            [SortOrder(Yellow_sortIndex)]
            [DisplayName(Yellow_displayName)]
            public virtual ushort Yellow {
                get => Yellow_raw;
                set {
                    if (Yellow_raw == value.Clamp((ushort) 0, (ushort) 400)) return;
                    Yellow_raw = value.Clamp((ushort) 0, (ushort) 400);
                    OnPropertyChanged(nameof(Yellow));
                }
            }

            protected ushort Green_raw;
            public const string Green_displayName = "Green";
            public const int Green_sortIndex = 250;
            [SortOrder(Green_sortIndex)]
            [DisplayName(Green_displayName)]
            public virtual ushort Green {
                get => Green_raw;
                set {
                    if (Green_raw == value.Clamp((ushort) 0, (ushort) 400)) return;
                    Green_raw = value.Clamp((ushort) 0, (ushort) 400);
                    OnPropertyChanged(nameof(Green));
                }
            }

            protected ushort Blue_raw;
            public const string Blue_displayName = "Blue";
            public const int Blue_sortIndex = 300;
            [SortOrder(Blue_sortIndex)]
            [DisplayName(Blue_displayName)]
            public virtual ushort Blue {
                get => Blue_raw;
                set {
                    if (Blue_raw == value.Clamp((ushort) 0, (ushort) 400)) return;
                    Blue_raw = value.Clamp((ushort) 0, (ushort) 400);
                    OnPropertyChanged(nameof(Blue));
                }
            }

            protected ushort White_raw;
            public const string White_displayName = "White";
            public const int White_sortIndex = 350;
            [SortOrder(White_sortIndex)]
            [DisplayName(White_displayName)]
            public virtual ushort White {
                get => White_raw;
                set {
                    if (White_raw == value.Clamp((ushort) 0, (ushort) 400)) return;
                    White_raw = value.Clamp((ushort) 0, (ushort) 400);
                    OnPropertyChanged(nameof(White));
                }
            }

            protected ushort Purple_raw;
            public const string Purple_displayName = "Purple";
            public const int Purple_sortIndex = 400;
            [SortOrder(Purple_sortIndex)]
            [DisplayName(Purple_displayName)]
            public virtual ushort Purple {
                get => Purple_raw;
                set {
                    if (Purple_raw == value.Clamp((ushort) 0, (ushort) 400)) return;
                    Purple_raw = value.Clamp((ushort) 0, (ushort) 400);
                    OnPropertyChanged(nameof(Purple));
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
                data.Id_raw = reader.ReadUInt32();
                data.Red_raw = reader.ReadUInt16();
                data.Orange_raw = reader.ReadUInt16();
                data.Yellow_raw = reader.ReadUInt16();
                data.Green_raw = reader.ReadUInt16();
                data.Blue_raw = reader.ReadUInt16();
                data.White_raw = reader.ReadUInt16();
                data.Purple_raw = reader.ReadUInt16();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Id_raw);
                writer.Write(Red_raw);
                writer.Write(Orange_raw);
                writer.Write(Yellow_raw);
                writer.Write(Green_raw);
                writer.Write(Blue_raw);
                writer.Write(White_raw);
                writer.Write(Purple_raw);
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
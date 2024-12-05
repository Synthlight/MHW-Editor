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

namespace MHW_Editor.Structs.Misc {
    public partial class EquipColor {
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

            protected char[] EVSC_raw;
            public const string EVSC_displayName = "EVSC";
            public const int EVSC_sortIndex = 100;
            [SortOrder(EVSC_sortIndex)]
            [DisplayName(EVSC_displayName)]
            [IsReadOnly]
            public virtual string EVSC {
                get => (string) new string(EVSC_raw);
                set {
                    if ((string) new string(EVSC_raw) == value) return;
                    EVSC_raw = (char[]) value.ToCharArray(0, 3);
                    ChangedItems.Add(nameof(EVSC));
                    OnPropertyChanged(nameof(EVSC));
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
                data.EVSC_raw = reader.ReadChars(4);
                data.Entry_Count_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Magic_1_raw);
                writer.Write(EVSC_raw);
                writer.Write(Entry_Count_raw);
            }
        }

        public partial class Parts : MhwStructItem, IWriteData, IHasChildren {
            public const ulong FixedSizeCount = 0;
            public const string GridName = "Parts";

            protected uint Array_Count_raw;
            public const string Array_Count_displayName = "Array Count";
            public const int Array_Count_sortIndex = 50;
            [SortOrder(Array_Count_sortIndex)]
            [DisplayName(Array_Count_displayName)]
            [IsReadOnly]
            public virtual uint Array_Count {
                get => Array_Count_raw;
                set {
                    if (Array_Count_raw == value) return;
                    Array_Count_raw = value;
                    ChangedItems.Add(nameof(Array_Count));
                    OnPropertyChanged(nameof(Array_Count));
                }
            }

            public partial class Part : MhwStructItem, IWriteDataInner<Parts> {
                public const ulong FixedSizeCount = 0;
                public const string GridName = "Part";

                protected byte Unk_1_byte__raw;
                public const string Unk_1_byte__displayName = "Unk 1 (byte)";
                public const int Unk_1_byte__sortIndex = 50;
                [SortOrder(Unk_1_byte__sortIndex)]
                [DisplayName(Unk_1_byte__displayName)]
                public virtual byte Unk_1_byte_ {
                    get => Unk_1_byte__raw;
                    set {
                        if (Unk_1_byte__raw == value) return;
                        Unk_1_byte__raw = value;
                        ChangedItems.Add(nameof(Unk_1_byte_));
                        OnPropertyChanged(nameof(Unk_1_byte_));
                    }
                }

                protected byte Unk_2_byte__raw;
                public const string Unk_2_byte__displayName = "Unk 2 (byte)";
                public const int Unk_2_byte__sortIndex = 100;
                [SortOrder(Unk_2_byte__sortIndex)]
                [DisplayName(Unk_2_byte__displayName)]
                public virtual byte Unk_2_byte_ {
                    get => Unk_2_byte__raw;
                    set {
                        if (Unk_2_byte__raw == value) return;
                        Unk_2_byte__raw = value;
                        ChangedItems.Add(nameof(Unk_2_byte_));
                        OnPropertyChanged(nameof(Unk_2_byte_));
                    }
                }

                protected byte Unk_3_byte__raw;
                public const string Unk_3_byte__displayName = "Unk 3 (byte)";
                public const int Unk_3_byte__sortIndex = 150;
                [SortOrder(Unk_3_byte__sortIndex)]
                [DisplayName(Unk_3_byte__displayName)]
                public virtual byte Unk_3_byte_ {
                    get => Unk_3_byte__raw;
                    set {
                        if (Unk_3_byte__raw == value) return;
                        Unk_3_byte__raw = value;
                        ChangedItems.Add(nameof(Unk_3_byte_));
                        OnPropertyChanged(nameof(Unk_3_byte_));
                    }
                }

                protected byte Unk_4_byte__raw;
                public const string Unk_4_byte__displayName = "Unk 4 (byte)";
                public const int Unk_4_byte__sortIndex = 200;
                [SortOrder(Unk_4_byte__sortIndex)]
                [DisplayName(Unk_4_byte__displayName)]
                public virtual byte Unk_4_byte_ {
                    get => Unk_4_byte__raw;
                    set {
                        if (Unk_4_byte__raw == value) return;
                        Unk_4_byte__raw = value;
                        ChangedItems.Add(nameof(Unk_4_byte_));
                        OnPropertyChanged(nameof(Unk_4_byte_));
                    }
                }

                protected uint Unk_5_uint__raw;
                public const string Unk_5_uint__displayName = "Unk 5 (uint)";
                public const int Unk_5_uint__sortIndex = 250;
                [SortOrder(Unk_5_uint__sortIndex)]
                [DisplayName(Unk_5_uint__displayName)]
                public virtual uint Unk_5_uint_ {
                    get => Unk_5_uint__raw;
                    set {
                        if (Unk_5_uint__raw == value) return;
                        Unk_5_uint__raw = value;
                        ChangedItems.Add(nameof(Unk_5_uint_));
                        OnPropertyChanged(nameof(Unk_5_uint_));
                    }
                }

                protected float Unk_6_float__raw;
                public const string Unk_6_float__displayName = "Unk 6 (float)";
                public const int Unk_6_float__sortIndex = 300;
                [SortOrder(Unk_6_float__sortIndex)]
                [DisplayName(Unk_6_float__displayName)]
                public virtual float Unk_6_float_ {
                    get => Unk_6_float__raw;
                    set {
                        if (Unk_6_float__raw == value) return;
                        Unk_6_float__raw = value;
                        ChangedItems.Add(nameof(Unk_6_float_));
                        OnPropertyChanged(nameof(Unk_6_float_));
                    }
                }

                protected float Unk_7_float__raw;
                public const string Unk_7_float__displayName = "Unk 7 (float)";
                public const int Unk_7_float__sortIndex = 350;
                [SortOrder(Unk_7_float__sortIndex)]
                [DisplayName(Unk_7_float__displayName)]
                public virtual float Unk_7_float_ {
                    get => Unk_7_float__raw;
                    set {
                        if (Unk_7_float__raw == value) return;
                        Unk_7_float__raw = value;
                        ChangedItems.Add(nameof(Unk_7_float_));
                        OnPropertyChanged(nameof(Unk_7_float_));
                    }
                }

                protected float Unk_8_float__raw;
                public const string Unk_8_float__displayName = "Unk 8 (float)";
                public const int Unk_8_float__sortIndex = 400;
                [SortOrder(Unk_8_float__sortIndex)]
                [DisplayName(Unk_8_float__displayName)]
                public virtual float Unk_8_float_ {
                    get => Unk_8_float__raw;
                    set {
                        if (Unk_8_float__raw == value) return;
                        Unk_8_float__raw = value;
                        ChangedItems.Add(nameof(Unk_8_float_));
                        OnPropertyChanged(nameof(Unk_8_float_));
                    }
                }

                protected float Unk_9_float__raw;
                public const string Unk_9_float__displayName = "Unk 9 (float)";
                public const int Unk_9_float__sortIndex = 450;
                [SortOrder(Unk_9_float__sortIndex)]
                [DisplayName(Unk_9_float__displayName)]
                public virtual float Unk_9_float_ {
                    get => Unk_9_float__raw;
                    set {
                        if (Unk_9_float__raw == value) return;
                        Unk_9_float__raw = value;
                        ChangedItems.Add(nameof(Unk_9_float_));
                        OnPropertyChanged(nameof(Unk_9_float_));
                    }
                }

                protected float Unk_10_float__raw;
                public const string Unk_10_float__displayName = "Unk 10 (float)";
                public const int Unk_10_float__sortIndex = 500;
                [SortOrder(Unk_10_float__sortIndex)]
                [DisplayName(Unk_10_float__displayName)]
                public virtual float Unk_10_float_ {
                    get => Unk_10_float__raw;
                    set {
                        if (Unk_10_float__raw == value) return;
                        Unk_10_float__raw = value;
                        ChangedItems.Add(nameof(Unk_10_float_));
                        OnPropertyChanged(nameof(Unk_10_float_));
                    }
                }

                protected float Unk_11_float__raw;
                public const string Unk_11_float__displayName = "Unk 11 (float)";
                public const int Unk_11_float__sortIndex = 550;
                [SortOrder(Unk_11_float__sortIndex)]
                [DisplayName(Unk_11_float__displayName)]
                public virtual float Unk_11_float_ {
                    get => Unk_11_float__raw;
                    set {
                        if (Unk_11_float__raw == value) return;
                        Unk_11_float__raw = value;
                        ChangedItems.Add(nameof(Unk_11_float_));
                        OnPropertyChanged(nameof(Unk_11_float_));
                    }
                }

                protected float Unk_12_float__raw;
                public const string Unk_12_float__displayName = "Unk 12 (float)";
                public const int Unk_12_float__sortIndex = 600;
                [SortOrder(Unk_12_float__sortIndex)]
                [DisplayName(Unk_12_float__displayName)]
                public virtual float Unk_12_float_ {
                    get => Unk_12_float__raw;
                    set {
                        if (Unk_12_float__raw == value) return;
                        Unk_12_float__raw = value;
                        ChangedItems.Add(nameof(Unk_12_float_));
                        OnPropertyChanged(nameof(Unk_12_float_));
                    }
                }

                protected float Unk_13_float__raw;
                public const string Unk_13_float__displayName = "Unk 13 (float)";
                public const int Unk_13_float__sortIndex = 650;
                [SortOrder(Unk_13_float__sortIndex)]
                [DisplayName(Unk_13_float__displayName)]
                public virtual float Unk_13_float_ {
                    get => Unk_13_float__raw;
                    set {
                        if (Unk_13_float__raw == value) return;
                        Unk_13_float__raw = value;
                        ChangedItems.Add(nameof(Unk_13_float_));
                        OnPropertyChanged(nameof(Unk_13_float_));
                    }
                }

                protected float Unk_14_float__raw;
                public const string Unk_14_float__displayName = "Unk 14 (float)";
                public const int Unk_14_float__sortIndex = 700;
                [SortOrder(Unk_14_float__sortIndex)]
                [DisplayName(Unk_14_float__displayName)]
                public virtual float Unk_14_float_ {
                    get => Unk_14_float__raw;
                    set {
                        if (Unk_14_float__raw == value) return;
                        Unk_14_float__raw = value;
                        ChangedItems.Add(nameof(Unk_14_float_));
                        OnPropertyChanged(nameof(Unk_14_float_));
                    }
                }

                public const int lastSortIndex = 750;

                public static ObservableMhwStructCollection<Part> LoadData(BinaryReader reader, Parts parent) {
                    var list = new ObservableMhwStructCollection<Part>();
                    var count = (ulong) parent.Array_Count;
                    for (ulong i = 0; i < count; i++) {
                        list.Add(LoadData(reader, i, parent));
                    }
                    return list;
                }

                public static Part LoadData(BinaryReader reader, ulong i, Parts parent) {
                    var data = new Part();
                    data.Index = i;
                    data.Unk_1_byte__raw = reader.ReadByte();
                    data.Unk_2_byte__raw = reader.ReadByte();
                    data.Unk_3_byte__raw = reader.ReadByte();
                    data.Unk_4_byte__raw = reader.ReadByte();
                    data.Unk_5_uint__raw = reader.ReadUInt32();
                    data.Unk_6_float__raw = reader.ReadSingle();
                    data.Unk_7_float__raw = reader.ReadSingle();
                    data.Unk_8_float__raw = reader.ReadSingle();
                    data.Unk_9_float__raw = reader.ReadSingle();
                    data.Unk_10_float__raw = reader.ReadSingle();
                    data.Unk_11_float__raw = reader.ReadSingle();
                    data.Unk_12_float__raw = reader.ReadSingle();
                    data.Unk_13_float__raw = reader.ReadSingle();
                    data.Unk_14_float__raw = reader.ReadSingle();
                    return data;
                }

                public void WriteData(BinaryWriter writer, Parts parent) {
                    writer.Write(Unk_1_byte__raw);
                    writer.Write(Unk_2_byte__raw);
                    writer.Write(Unk_3_byte__raw);
                    writer.Write(Unk_4_byte__raw);
                    writer.Write(Unk_5_uint__raw);
                    writer.Write(Unk_6_float__raw);
                    writer.Write(Unk_7_float__raw);
                    writer.Write(Unk_8_float__raw);
                    writer.Write(Unk_9_float__raw);
                    writer.Write(Unk_10_float__raw);
                    writer.Write(Unk_11_float__raw);
                    writer.Write(Unk_12_float__raw);
                    writer.Write(Unk_13_float__raw);
                    writer.Write(Unk_14_float__raw);
                }
            }

            public const string Part_displayName = "Part";
            public const int Part_sortIndex = 100;
            [SortOrder(Part_sortIndex)]
            [DisplayName(Part_displayName)]
            public virtual ObservableCollection<Part> Part_raw { get; protected set; }

            public const int lastSortIndex = 150;

            public IEnumerable<F> GetAllEnumerableChildrenOfType<F>() {
                if (typeof(Part).Is(typeof(F)) || typeof(Part).IsGeneric(typeof(F))) {
                    foreach (var item in Part_raw.Cast<F>()) {
                        yield return item;
                    }
                }
            }

            public static ObservableMhwStructCollection<Parts> LoadData(BinaryReader reader, ObservableMhwStructCollection<Header> lastStruct) {
                var list = new ObservableMhwStructCollection<Parts>();
                var countTarget = (Header) lastStruct.Last();
                var count = (ulong) countTarget.Entry_Count;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Parts LoadData(BinaryReader reader, ulong i) {
                var data = new Parts();
                data.Index = i;
                data.Array_Count_raw = reader.ReadUInt32();
                data.Part_raw = Part.LoadData(reader, data);
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                Array_Count = (uint) Part_raw.Count;
                writer.Write(Array_Count_raw);
                foreach (var obj in Part_raw) {
                    obj.WriteData(writer, this);
                }
            }
        }

        public override void LoadFile(string targetFile) {
            using var reader = new BinaryReader(OpenFile(targetFile, EncryptionKey), Encoding.UTF8);
            data = new LinkedList<MhwStructDataContainer>();
            var Header_ = new MhwStructDataContainer<Header>(Header.LoadData(reader), typeof(Header));
            data.AddLast(Header_);
            var Parts_ = new MhwStructDataContainer<Parts, Header>(Parts.LoadData(reader, Header_.list), typeof(Parts));
            Parts_.SetCountTargetToUpdate(Header_, -1, "Entry_Count");
            data.AddLast(Parts_);
        }
    }
}
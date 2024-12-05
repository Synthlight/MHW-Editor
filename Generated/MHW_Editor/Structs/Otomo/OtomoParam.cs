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

namespace MHW_Editor.Structs.Otomo {
    public partial class OtomoParam {
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

            protected char[] OPRM_raw;
            public const string OPRM_displayName = "OPRM";
            public const int OPRM_sortIndex = 100;
            [SortOrder(OPRM_sortIndex)]
            [DisplayName(OPRM_displayName)]
            [IsReadOnly]
            public virtual string OPRM {
                get => (string) new string(OPRM_raw);
                set {
                    if ((string) new string(OPRM_raw) == value) return;
                    OPRM_raw = (char[]) value.ToCharArray(0, 3);
                    ChangedItems.Add(nameof(OPRM));
                    OnPropertyChanged(nameof(OPRM));
                }
            }

            protected uint Unk_1_raw;
            public const string Unk_1_displayName = "Unk 1";
            public const int Unk_1_sortIndex = 150;
            [SortOrder(Unk_1_sortIndex)]
            [DisplayName(Unk_1_displayName)]
            public virtual uint Unk_1 {
                get => Unk_1_raw;
                set {
                    if (Unk_1_raw == value) return;
                    Unk_1_raw = value;
                    ChangedItems.Add(nameof(Unk_1));
                    OnPropertyChanged(nameof(Unk_1));
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
                data.OPRM_raw = reader.ReadChars(4);
                data.Unk_1_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Magic_1_raw);
                writer.Write(OPRM_raw);
                writer.Write(Unk_1_raw);
            }
        }

        public partial class Params_1_ : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 37;
            public const string GridName = "Params (1)";

            protected float Unk_1_float__raw;
            public const string Unk_1_float__displayName = "Unk 1 (float)";
            public const int Unk_1_float__sortIndex = 50;
            [SortOrder(Unk_1_float__sortIndex)]
            [DisplayName(Unk_1_float__displayName)]
            public virtual float Unk_1_float_ {
                get => Unk_1_float__raw;
                set {
                    if (Unk_1_float__raw == value) return;
                    Unk_1_float__raw = value;
                    ChangedItems.Add(nameof(Unk_1_float_));
                    OnPropertyChanged(nameof(Unk_1_float_));
                }
            }

            protected float Unk_2_float__raw;
            public const string Unk_2_float__displayName = "Unk 2 (float)";
            public const int Unk_2_float__sortIndex = 100;
            [SortOrder(Unk_2_float__sortIndex)]
            [DisplayName(Unk_2_float__displayName)]
            public virtual float Unk_2_float_ {
                get => Unk_2_float__raw;
                set {
                    if (Unk_2_float__raw == value) return;
                    Unk_2_float__raw = value;
                    ChangedItems.Add(nameof(Unk_2_float_));
                    OnPropertyChanged(nameof(Unk_2_float_));
                }
            }

            protected float Unk_3_float__raw;
            public const string Unk_3_float__displayName = "Unk 3 (float)";
            public const int Unk_3_float__sortIndex = 150;
            [SortOrder(Unk_3_float__sortIndex)]
            [DisplayName(Unk_3_float__displayName)]
            public virtual float Unk_3_float_ {
                get => Unk_3_float__raw;
                set {
                    if (Unk_3_float__raw == value) return;
                    Unk_3_float__raw = value;
                    ChangedItems.Add(nameof(Unk_3_float_));
                    OnPropertyChanged(nameof(Unk_3_float_));
                }
            }

            protected float Unk_4_float__raw;
            public const string Unk_4_float__displayName = "Unk 4 (float)";
            public const int Unk_4_float__sortIndex = 200;
            [SortOrder(Unk_4_float__sortIndex)]
            [DisplayName(Unk_4_float__displayName)]
            public virtual float Unk_4_float_ {
                get => Unk_4_float__raw;
                set {
                    if (Unk_4_float__raw == value) return;
                    Unk_4_float__raw = value;
                    ChangedItems.Add(nameof(Unk_4_float_));
                    OnPropertyChanged(nameof(Unk_4_float_));
                }
            }

            protected float Unk_5_float__raw;
            public const string Unk_5_float__displayName = "Unk 5 (float)";
            public const int Unk_5_float__sortIndex = 250;
            [SortOrder(Unk_5_float__sortIndex)]
            [DisplayName(Unk_5_float__displayName)]
            public virtual float Unk_5_float_ {
                get => Unk_5_float__raw;
                set {
                    if (Unk_5_float__raw == value) return;
                    Unk_5_float__raw = value;
                    ChangedItems.Add(nameof(Unk_5_float_));
                    OnPropertyChanged(nameof(Unk_5_float_));
                }
            }

            public const int lastSortIndex = 300;

            public static ObservableMhwStructCollection<Params_1_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Params_1_>();
                const ulong count = 37UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Params_1_ LoadData(BinaryReader reader, ulong i) {
                var data = new Params_1_();
                data.Index = i;
                data.Unk_1_float__raw = reader.ReadSingle();
                data.Unk_2_float__raw = reader.ReadSingle();
                data.Unk_3_float__raw = reader.ReadSingle();
                data.Unk_4_float__raw = reader.ReadSingle();
                data.Unk_5_float__raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_1_float__raw);
                writer.Write(Unk_2_float__raw);
                writer.Write(Unk_3_float__raw);
                writer.Write(Unk_4_float__raw);
                writer.Write(Unk_5_float__raw);
            }
        }

        public partial class Params_2_ : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 4;
            public const string GridName = "Params (2)";

            protected uint Unk_1_float__raw;
            public const string Unk_1_float__displayName = "Unk 1 (float)";
            public const int Unk_1_float__sortIndex = 50;
            [SortOrder(Unk_1_float__sortIndex)]
            [DisplayName(Unk_1_float__displayName)]
            public virtual uint Unk_1_float_ {
                get => Unk_1_float__raw;
                set {
                    if (Unk_1_float__raw == value) return;
                    Unk_1_float__raw = value;
                    ChangedItems.Add(nameof(Unk_1_float_));
                    OnPropertyChanged(nameof(Unk_1_float_));
                }
            }

            public const int lastSortIndex = 100;

            public static ObservableMhwStructCollection<Params_2_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Params_2_>();
                const ulong count = 4UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Params_2_ LoadData(BinaryReader reader, ulong i) {
                var data = new Params_2_();
                data.Index = i;
                data.Unk_1_float__raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_1_float__raw);
            }
        }

        public partial class Params_3_ : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 5;
            public const string GridName = "Params (3)";

            protected uint Unk_1_uint__raw;
            public const string Unk_1_uint__displayName = "Unk 1 (uint)";
            public const int Unk_1_uint__sortIndex = 50;
            [SortOrder(Unk_1_uint__sortIndex)]
            [DisplayName(Unk_1_uint__displayName)]
            public virtual uint Unk_1_uint_ {
                get => Unk_1_uint__raw;
                set {
                    if (Unk_1_uint__raw == value) return;
                    Unk_1_uint__raw = value;
                    ChangedItems.Add(nameof(Unk_1_uint_));
                    OnPropertyChanged(nameof(Unk_1_uint_));
                }
            }

            protected uint Unk_2_uint__raw;
            public const string Unk_2_uint__displayName = "Unk 2 (uint)";
            public const int Unk_2_uint__sortIndex = 100;
            [SortOrder(Unk_2_uint__sortIndex)]
            [DisplayName(Unk_2_uint__displayName)]
            public virtual uint Unk_2_uint_ {
                get => Unk_2_uint__raw;
                set {
                    if (Unk_2_uint__raw == value) return;
                    Unk_2_uint__raw = value;
                    ChangedItems.Add(nameof(Unk_2_uint_));
                    OnPropertyChanged(nameof(Unk_2_uint_));
                }
            }

            protected uint Unk_3_uint__raw;
            public const string Unk_3_uint__displayName = "Unk 3 (uint)";
            public const int Unk_3_uint__sortIndex = 150;
            [SortOrder(Unk_3_uint__sortIndex)]
            [DisplayName(Unk_3_uint__displayName)]
            public virtual uint Unk_3_uint_ {
                get => Unk_3_uint__raw;
                set {
                    if (Unk_3_uint__raw == value) return;
                    Unk_3_uint__raw = value;
                    ChangedItems.Add(nameof(Unk_3_uint_));
                    OnPropertyChanged(nameof(Unk_3_uint_));
                }
            }

            protected uint Unk_4_uint__raw;
            public const string Unk_4_uint__displayName = "Unk 4 (uint)";
            public const int Unk_4_uint__sortIndex = 200;
            [SortOrder(Unk_4_uint__sortIndex)]
            [DisplayName(Unk_4_uint__displayName)]
            public virtual uint Unk_4_uint_ {
                get => Unk_4_uint__raw;
                set {
                    if (Unk_4_uint__raw == value) return;
                    Unk_4_uint__raw = value;
                    ChangedItems.Add(nameof(Unk_4_uint_));
                    OnPropertyChanged(nameof(Unk_4_uint_));
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

            protected uint Unk_6_uint__raw;
            public const string Unk_6_uint__displayName = "Unk 6 (uint)";
            public const int Unk_6_uint__sortIndex = 300;
            [SortOrder(Unk_6_uint__sortIndex)]
            [DisplayName(Unk_6_uint__displayName)]
            public virtual uint Unk_6_uint_ {
                get => Unk_6_uint__raw;
                set {
                    if (Unk_6_uint__raw == value) return;
                    Unk_6_uint__raw = value;
                    ChangedItems.Add(nameof(Unk_6_uint_));
                    OnPropertyChanged(nameof(Unk_6_uint_));
                }
            }

            protected uint Unk_7_uint__raw;
            public const string Unk_7_uint__displayName = "Unk 7 (uint)";
            public const int Unk_7_uint__sortIndex = 350;
            [SortOrder(Unk_7_uint__sortIndex)]
            [DisplayName(Unk_7_uint__displayName)]
            public virtual uint Unk_7_uint_ {
                get => Unk_7_uint__raw;
                set {
                    if (Unk_7_uint__raw == value) return;
                    Unk_7_uint__raw = value;
                    ChangedItems.Add(nameof(Unk_7_uint_));
                    OnPropertyChanged(nameof(Unk_7_uint_));
                }
            }

            protected uint Unk_8_uint__raw;
            public const string Unk_8_uint__displayName = "Unk 8 (uint)";
            public const int Unk_8_uint__sortIndex = 400;
            [SortOrder(Unk_8_uint__sortIndex)]
            [DisplayName(Unk_8_uint__displayName)]
            public virtual uint Unk_8_uint_ {
                get => Unk_8_uint__raw;
                set {
                    if (Unk_8_uint__raw == value) return;
                    Unk_8_uint__raw = value;
                    ChangedItems.Add(nameof(Unk_8_uint_));
                    OnPropertyChanged(nameof(Unk_8_uint_));
                }
            }

            protected uint Unk_9_uint__raw;
            public const string Unk_9_uint__displayName = "Unk 9 (uint)";
            public const int Unk_9_uint__sortIndex = 450;
            [SortOrder(Unk_9_uint__sortIndex)]
            [DisplayName(Unk_9_uint__displayName)]
            public virtual uint Unk_9_uint_ {
                get => Unk_9_uint__raw;
                set {
                    if (Unk_9_uint__raw == value) return;
                    Unk_9_uint__raw = value;
                    ChangedItems.Add(nameof(Unk_9_uint_));
                    OnPropertyChanged(nameof(Unk_9_uint_));
                }
            }

            public const int lastSortIndex = 500;

            public static ObservableMhwStructCollection<Params_3_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Params_3_>();
                const ulong count = 5UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Params_3_ LoadData(BinaryReader reader, ulong i) {
                var data = new Params_3_();
                data.Index = i;
                data.Unk_1_uint__raw = reader.ReadUInt32();
                data.Unk_2_uint__raw = reader.ReadUInt32();
                data.Unk_3_uint__raw = reader.ReadUInt32();
                data.Unk_4_uint__raw = reader.ReadUInt32();
                data.Unk_5_uint__raw = reader.ReadUInt32();
                data.Unk_6_uint__raw = reader.ReadUInt32();
                data.Unk_7_uint__raw = reader.ReadUInt32();
                data.Unk_8_uint__raw = reader.ReadUInt32();
                data.Unk_9_uint__raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_1_uint__raw);
                writer.Write(Unk_2_uint__raw);
                writer.Write(Unk_3_uint__raw);
                writer.Write(Unk_4_uint__raw);
                writer.Write(Unk_5_uint__raw);
                writer.Write(Unk_6_uint__raw);
                writer.Write(Unk_7_uint__raw);
                writer.Write(Unk_8_uint__raw);
                writer.Write(Unk_9_uint__raw);
            }
        }

        public partial class Params_4_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Params (4)";

            protected float Unk_1_float__raw;
            public const string Unk_1_float__displayName = "Unk 1 (float)";
            public const int Unk_1_float__sortIndex = 50;
            [SortOrder(Unk_1_float__sortIndex)]
            [DisplayName(Unk_1_float__displayName)]
            public virtual float Unk_1_float_ {
                get => Unk_1_float__raw;
                set {
                    if (Unk_1_float__raw == value) return;
                    Unk_1_float__raw = value;
                    ChangedItems.Add(nameof(Unk_1_float_));
                    OnPropertyChanged(nameof(Unk_1_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_1_float__offset { get; private set; }

            protected float Unk_2_float__raw;
            public const string Unk_2_float__displayName = "Unk 2 (float)";
            public const int Unk_2_float__sortIndex = 100;
            [SortOrder(Unk_2_float__sortIndex)]
            [DisplayName(Unk_2_float__displayName)]
            public virtual float Unk_2_float_ {
                get => Unk_2_float__raw;
                set {
                    if (Unk_2_float__raw == value) return;
                    Unk_2_float__raw = value;
                    ChangedItems.Add(nameof(Unk_2_float_));
                    OnPropertyChanged(nameof(Unk_2_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_2_float__offset { get; private set; }

            protected float Unk_3_float__raw;
            public const string Unk_3_float__displayName = "Unk 3 (float)";
            public const int Unk_3_float__sortIndex = 150;
            [SortOrder(Unk_3_float__sortIndex)]
            [DisplayName(Unk_3_float__displayName)]
            public virtual float Unk_3_float_ {
                get => Unk_3_float__raw;
                set {
                    if (Unk_3_float__raw == value) return;
                    Unk_3_float__raw = value;
                    ChangedItems.Add(nameof(Unk_3_float_));
                    OnPropertyChanged(nameof(Unk_3_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_3_float__offset { get; private set; }

            protected float Unk_4_float__raw;
            public const string Unk_4_float__displayName = "Unk 4 (float)";
            public const int Unk_4_float__sortIndex = 200;
            [SortOrder(Unk_4_float__sortIndex)]
            [DisplayName(Unk_4_float__displayName)]
            public virtual float Unk_4_float_ {
                get => Unk_4_float__raw;
                set {
                    if (Unk_4_float__raw == value) return;
                    Unk_4_float__raw = value;
                    ChangedItems.Add(nameof(Unk_4_float_));
                    OnPropertyChanged(nameof(Unk_4_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_4_float__offset { get; private set; }

            protected float Unk_5_float__raw;
            public const string Unk_5_float__displayName = "Unk 5 (float)";
            public const int Unk_5_float__sortIndex = 250;
            [SortOrder(Unk_5_float__sortIndex)]
            [DisplayName(Unk_5_float__displayName)]
            public virtual float Unk_5_float_ {
                get => Unk_5_float__raw;
                set {
                    if (Unk_5_float__raw == value) return;
                    Unk_5_float__raw = value;
                    ChangedItems.Add(nameof(Unk_5_float_));
                    OnPropertyChanged(nameof(Unk_5_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_5_float__offset { get; private set; }

            protected uint Unk_6_uint__raw;
            public const string Unk_6_uint__displayName = "Unk 6 (uint)";
            public const int Unk_6_uint__sortIndex = 300;
            [SortOrder(Unk_6_uint__sortIndex)]
            [DisplayName(Unk_6_uint__displayName)]
            public virtual uint Unk_6_uint_ {
                get => Unk_6_uint__raw;
                set {
                    if (Unk_6_uint__raw == value) return;
                    Unk_6_uint__raw = value;
                    ChangedItems.Add(nameof(Unk_6_uint_));
                    OnPropertyChanged(nameof(Unk_6_uint_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_6_uint__offset { get; private set; }

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

            [DisplayName("Offset")]
            public long Unk_7_float__offset { get; private set; }

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

            [DisplayName("Offset")]
            public long Unk_8_float__offset { get; private set; }

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

            [DisplayName("Offset")]
            public long Unk_9_float__offset { get; private set; }

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

            [DisplayName("Offset")]
            public long Unk_10_float__offset { get; private set; }

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

            [DisplayName("Offset")]
            public long Unk_11_float__offset { get; private set; }

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

            [DisplayName("Offset")]
            public long Unk_12_float__offset { get; private set; }

            protected uint Unk_13_uint__raw;
            public const string Unk_13_uint__displayName = "Unk 13 (uint)";
            public const int Unk_13_uint__sortIndex = 650;
            [SortOrder(Unk_13_uint__sortIndex)]
            [DisplayName(Unk_13_uint__displayName)]
            public virtual uint Unk_13_uint_ {
                get => Unk_13_uint__raw;
                set {
                    if (Unk_13_uint__raw == value) return;
                    Unk_13_uint__raw = value;
                    ChangedItems.Add(nameof(Unk_13_uint_));
                    OnPropertyChanged(nameof(Unk_13_uint_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_13_uint__offset { get; private set; }

            protected uint Unk_14_uint__raw;
            public const string Unk_14_uint__displayName = "Unk 14 (uint)";
            public const int Unk_14_uint__sortIndex = 700;
            [SortOrder(Unk_14_uint__sortIndex)]
            [DisplayName(Unk_14_uint__displayName)]
            public virtual uint Unk_14_uint_ {
                get => Unk_14_uint__raw;
                set {
                    if (Unk_14_uint__raw == value) return;
                    Unk_14_uint__raw = value;
                    ChangedItems.Add(nameof(Unk_14_uint_));
                    OnPropertyChanged(nameof(Unk_14_uint_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_14_uint__offset { get; private set; }

            protected float Unk_15_float__raw;
            public const string Unk_15_float__displayName = "Unk 15 (float)";
            public const int Unk_15_float__sortIndex = 750;
            [SortOrder(Unk_15_float__sortIndex)]
            [DisplayName(Unk_15_float__displayName)]
            public virtual float Unk_15_float_ {
                get => Unk_15_float__raw;
                set {
                    if (Unk_15_float__raw == value) return;
                    Unk_15_float__raw = value;
                    ChangedItems.Add(nameof(Unk_15_float_));
                    OnPropertyChanged(nameof(Unk_15_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_15_float__offset { get; private set; }

            protected float Unk_16_float__raw;
            public const string Unk_16_float__displayName = "Unk 16 (float)";
            public const int Unk_16_float__sortIndex = 800;
            [SortOrder(Unk_16_float__sortIndex)]
            [DisplayName(Unk_16_float__displayName)]
            public virtual float Unk_16_float_ {
                get => Unk_16_float__raw;
                set {
                    if (Unk_16_float__raw == value) return;
                    Unk_16_float__raw = value;
                    ChangedItems.Add(nameof(Unk_16_float_));
                    OnPropertyChanged(nameof(Unk_16_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_16_float__offset { get; private set; }

            protected float Unk_17_float__raw;
            public const string Unk_17_float__displayName = "Unk 17 (float)";
            public const int Unk_17_float__sortIndex = 850;
            [SortOrder(Unk_17_float__sortIndex)]
            [DisplayName(Unk_17_float__displayName)]
            public virtual float Unk_17_float_ {
                get => Unk_17_float__raw;
                set {
                    if (Unk_17_float__raw == value) return;
                    Unk_17_float__raw = value;
                    ChangedItems.Add(nameof(Unk_17_float_));
                    OnPropertyChanged(nameof(Unk_17_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_17_float__offset { get; private set; }

            protected uint Unk_18_float__raw;
            public const string Unk_18_float__displayName = "Unk 18 (float)";
            public const int Unk_18_float__sortIndex = 900;
            [SortOrder(Unk_18_float__sortIndex)]
            [DisplayName(Unk_18_float__displayName)]
            public virtual uint Unk_18_float_ {
                get => Unk_18_float__raw;
                set {
                    if (Unk_18_float__raw == value) return;
                    Unk_18_float__raw = value;
                    ChangedItems.Add(nameof(Unk_18_float_));
                    OnPropertyChanged(nameof(Unk_18_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_18_float__offset { get; private set; }

            protected float Unk_19_float__raw;
            public const string Unk_19_float__displayName = "Unk 19 (float)";
            public const int Unk_19_float__sortIndex = 950;
            [SortOrder(Unk_19_float__sortIndex)]
            [DisplayName(Unk_19_float__displayName)]
            public virtual float Unk_19_float_ {
                get => Unk_19_float__raw;
                set {
                    if (Unk_19_float__raw == value) return;
                    Unk_19_float__raw = value;
                    ChangedItems.Add(nameof(Unk_19_float_));
                    OnPropertyChanged(nameof(Unk_19_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_19_float__offset { get; private set; }

            protected float Unk_20_float__raw;
            public const string Unk_20_float__displayName = "Unk 20 (float)";
            public const int Unk_20_float__sortIndex = 1000;
            [SortOrder(Unk_20_float__sortIndex)]
            [DisplayName(Unk_20_float__displayName)]
            public virtual float Unk_20_float_ {
                get => Unk_20_float__raw;
                set {
                    if (Unk_20_float__raw == value) return;
                    Unk_20_float__raw = value;
                    ChangedItems.Add(nameof(Unk_20_float_));
                    OnPropertyChanged(nameof(Unk_20_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_20_float__offset { get; private set; }

            protected float Unk_21_float__raw;
            public const string Unk_21_float__displayName = "Unk 21 (float)";
            public const int Unk_21_float__sortIndex = 1050;
            [SortOrder(Unk_21_float__sortIndex)]
            [DisplayName(Unk_21_float__displayName)]
            public virtual float Unk_21_float_ {
                get => Unk_21_float__raw;
                set {
                    if (Unk_21_float__raw == value) return;
                    Unk_21_float__raw = value;
                    ChangedItems.Add(nameof(Unk_21_float_));
                    OnPropertyChanged(nameof(Unk_21_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_21_float__offset { get; private set; }

            protected float Unk_22_float__raw;
            public const string Unk_22_float__displayName = "Unk 22 (float)";
            public const int Unk_22_float__sortIndex = 1100;
            [SortOrder(Unk_22_float__sortIndex)]
            [DisplayName(Unk_22_float__displayName)]
            public virtual float Unk_22_float_ {
                get => Unk_22_float__raw;
                set {
                    if (Unk_22_float__raw == value) return;
                    Unk_22_float__raw = value;
                    ChangedItems.Add(nameof(Unk_22_float_));
                    OnPropertyChanged(nameof(Unk_22_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_22_float__offset { get; private set; }

            protected float Unk_23_float__raw;
            public const string Unk_23_float__displayName = "Unk 23 (float)";
            public const int Unk_23_float__sortIndex = 1150;
            [SortOrder(Unk_23_float__sortIndex)]
            [DisplayName(Unk_23_float__displayName)]
            public virtual float Unk_23_float_ {
                get => Unk_23_float__raw;
                set {
                    if (Unk_23_float__raw == value) return;
                    Unk_23_float__raw = value;
                    ChangedItems.Add(nameof(Unk_23_float_));
                    OnPropertyChanged(nameof(Unk_23_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_23_float__offset { get; private set; }

            protected float Unk_24_float__raw;
            public const string Unk_24_float__displayName = "Unk 24 (float)";
            public const int Unk_24_float__sortIndex = 1200;
            [SortOrder(Unk_24_float__sortIndex)]
            [DisplayName(Unk_24_float__displayName)]
            public virtual float Unk_24_float_ {
                get => Unk_24_float__raw;
                set {
                    if (Unk_24_float__raw == value) return;
                    Unk_24_float__raw = value;
                    ChangedItems.Add(nameof(Unk_24_float_));
                    OnPropertyChanged(nameof(Unk_24_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_24_float__offset { get; private set; }

            protected float Unk_25_float__raw;
            public const string Unk_25_float__displayName = "Unk 25 (float)";
            public const int Unk_25_float__sortIndex = 1250;
            [SortOrder(Unk_25_float__sortIndex)]
            [DisplayName(Unk_25_float__displayName)]
            public virtual float Unk_25_float_ {
                get => Unk_25_float__raw;
                set {
                    if (Unk_25_float__raw == value) return;
                    Unk_25_float__raw = value;
                    ChangedItems.Add(nameof(Unk_25_float_));
                    OnPropertyChanged(nameof(Unk_25_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_25_float__offset { get; private set; }

            protected byte Unk_26_float__raw;
            public const string Unk_26_float__displayName = "Unk 26 (float)";
            public const int Unk_26_float__sortIndex = 1300;
            [SortOrder(Unk_26_float__sortIndex)]
            [DisplayName(Unk_26_float__displayName)]
            public virtual byte Unk_26_float_ {
                get => Unk_26_float__raw;
                set {
                    if (Unk_26_float__raw == value) return;
                    Unk_26_float__raw = value;
                    ChangedItems.Add(nameof(Unk_26_float_));
                    OnPropertyChanged(nameof(Unk_26_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_26_float__offset { get; private set; }

            protected byte Unk_27_float__raw;
            public const string Unk_27_float__displayName = "Unk 27 (float)";
            public const int Unk_27_float__sortIndex = 1350;
            [SortOrder(Unk_27_float__sortIndex)]
            [DisplayName(Unk_27_float__displayName)]
            public virtual byte Unk_27_float_ {
                get => Unk_27_float__raw;
                set {
                    if (Unk_27_float__raw == value) return;
                    Unk_27_float__raw = value;
                    ChangedItems.Add(nameof(Unk_27_float_));
                    OnPropertyChanged(nameof(Unk_27_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_27_float__offset { get; private set; }

            protected float Unk_28_float__raw;
            public const string Unk_28_float__displayName = "Unk 28 (float)";
            public const int Unk_28_float__sortIndex = 1400;
            [SortOrder(Unk_28_float__sortIndex)]
            [DisplayName(Unk_28_float__displayName)]
            public virtual float Unk_28_float_ {
                get => Unk_28_float__raw;
                set {
                    if (Unk_28_float__raw == value) return;
                    Unk_28_float__raw = value;
                    ChangedItems.Add(nameof(Unk_28_float_));
                    OnPropertyChanged(nameof(Unk_28_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_28_float__offset { get; private set; }

            protected float Unk_29_float__raw;
            public const string Unk_29_float__displayName = "Unk 29 (float)";
            public const int Unk_29_float__sortIndex = 1450;
            [SortOrder(Unk_29_float__sortIndex)]
            [DisplayName(Unk_29_float__displayName)]
            public virtual float Unk_29_float_ {
                get => Unk_29_float__raw;
                set {
                    if (Unk_29_float__raw == value) return;
                    Unk_29_float__raw = value;
                    ChangedItems.Add(nameof(Unk_29_float_));
                    OnPropertyChanged(nameof(Unk_29_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_29_float__offset { get; private set; }

            protected byte Unk_30_float__raw;
            public const string Unk_30_float__displayName = "Unk 30 (float)";
            public const int Unk_30_float__sortIndex = 1500;
            [SortOrder(Unk_30_float__sortIndex)]
            [DisplayName(Unk_30_float__displayName)]
            public virtual byte Unk_30_float_ {
                get => Unk_30_float__raw;
                set {
                    if (Unk_30_float__raw == value) return;
                    Unk_30_float__raw = value;
                    ChangedItems.Add(nameof(Unk_30_float_));
                    OnPropertyChanged(nameof(Unk_30_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_30_float__offset { get; private set; }

            protected byte Unk_31_float__raw;
            public const string Unk_31_float__displayName = "Unk 31 (float)";
            public const int Unk_31_float__sortIndex = 1550;
            [SortOrder(Unk_31_float__sortIndex)]
            [DisplayName(Unk_31_float__displayName)]
            public virtual byte Unk_31_float_ {
                get => Unk_31_float__raw;
                set {
                    if (Unk_31_float__raw == value) return;
                    Unk_31_float__raw = value;
                    ChangedItems.Add(nameof(Unk_31_float_));
                    OnPropertyChanged(nameof(Unk_31_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_31_float__offset { get; private set; }

            protected byte Unk_32_float__raw;
            public const string Unk_32_float__displayName = "Unk 32 (float)";
            public const int Unk_32_float__sortIndex = 1600;
            [SortOrder(Unk_32_float__sortIndex)]
            [DisplayName(Unk_32_float__displayName)]
            public virtual byte Unk_32_float_ {
                get => Unk_32_float__raw;
                set {
                    if (Unk_32_float__raw == value) return;
                    Unk_32_float__raw = value;
                    ChangedItems.Add(nameof(Unk_32_float_));
                    OnPropertyChanged(nameof(Unk_32_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_32_float__offset { get; private set; }

            protected byte Unk_33_float__raw;
            public const string Unk_33_float__displayName = "Unk 33 (float)";
            public const int Unk_33_float__sortIndex = 1650;
            [SortOrder(Unk_33_float__sortIndex)]
            [DisplayName(Unk_33_float__displayName)]
            public virtual byte Unk_33_float_ {
                get => Unk_33_float__raw;
                set {
                    if (Unk_33_float__raw == value) return;
                    Unk_33_float__raw = value;
                    ChangedItems.Add(nameof(Unk_33_float_));
                    OnPropertyChanged(nameof(Unk_33_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_33_float__offset { get; private set; }

            protected float Unk_34_float__raw;
            public const string Unk_34_float__displayName = "Unk 34 (float)";
            public const int Unk_34_float__sortIndex = 1700;
            [SortOrder(Unk_34_float__sortIndex)]
            [DisplayName(Unk_34_float__displayName)]
            public virtual float Unk_34_float_ {
                get => Unk_34_float__raw;
                set {
                    if (Unk_34_float__raw == value) return;
                    Unk_34_float__raw = value;
                    ChangedItems.Add(nameof(Unk_34_float_));
                    OnPropertyChanged(nameof(Unk_34_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_34_float__offset { get; private set; }

            protected float Unk_35_float__raw;
            public const string Unk_35_float__displayName = "Unk 35 (float)";
            public const int Unk_35_float__sortIndex = 1750;
            [SortOrder(Unk_35_float__sortIndex)]
            [DisplayName(Unk_35_float__displayName)]
            public virtual float Unk_35_float_ {
                get => Unk_35_float__raw;
                set {
                    if (Unk_35_float__raw == value) return;
                    Unk_35_float__raw = value;
                    ChangedItems.Add(nameof(Unk_35_float_));
                    OnPropertyChanged(nameof(Unk_35_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_35_float__offset { get; private set; }

            protected float Unk_36_float__raw;
            public const string Unk_36_float__displayName = "Unk 36 (float)";
            public const int Unk_36_float__sortIndex = 1800;
            [SortOrder(Unk_36_float__sortIndex)]
            [DisplayName(Unk_36_float__displayName)]
            public virtual float Unk_36_float_ {
                get => Unk_36_float__raw;
                set {
                    if (Unk_36_float__raw == value) return;
                    Unk_36_float__raw = value;
                    ChangedItems.Add(nameof(Unk_36_float_));
                    OnPropertyChanged(nameof(Unk_36_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_36_float__offset { get; private set; }

            protected byte Unk_37_float__raw;
            public const string Unk_37_float__displayName = "Unk 37 (float)";
            public const int Unk_37_float__sortIndex = 1850;
            [SortOrder(Unk_37_float__sortIndex)]
            [DisplayName(Unk_37_float__displayName)]
            public virtual byte Unk_37_float_ {
                get => Unk_37_float__raw;
                set {
                    if (Unk_37_float__raw == value) return;
                    Unk_37_float__raw = value;
                    ChangedItems.Add(nameof(Unk_37_float_));
                    OnPropertyChanged(nameof(Unk_37_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_37_float__offset { get; private set; }

            protected byte Unk_38_float__raw;
            public const string Unk_38_float__displayName = "Unk 38 (float)";
            public const int Unk_38_float__sortIndex = 1900;
            [SortOrder(Unk_38_float__sortIndex)]
            [DisplayName(Unk_38_float__displayName)]
            public virtual byte Unk_38_float_ {
                get => Unk_38_float__raw;
                set {
                    if (Unk_38_float__raw == value) return;
                    Unk_38_float__raw = value;
                    ChangedItems.Add(nameof(Unk_38_float_));
                    OnPropertyChanged(nameof(Unk_38_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_38_float__offset { get; private set; }

            protected float Unk_39_float__raw;
            public const string Unk_39_float__displayName = "Unk 39 (float)";
            public const int Unk_39_float__sortIndex = 1950;
            [SortOrder(Unk_39_float__sortIndex)]
            [DisplayName(Unk_39_float__displayName)]
            public virtual float Unk_39_float_ {
                get => Unk_39_float__raw;
                set {
                    if (Unk_39_float__raw == value) return;
                    Unk_39_float__raw = value;
                    ChangedItems.Add(nameof(Unk_39_float_));
                    OnPropertyChanged(nameof(Unk_39_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_39_float__offset { get; private set; }

            protected float Unk_40_float__raw;
            public const string Unk_40_float__displayName = "Unk 40 (float)";
            public const int Unk_40_float__sortIndex = 2000;
            [SortOrder(Unk_40_float__sortIndex)]
            [DisplayName(Unk_40_float__displayName)]
            public virtual float Unk_40_float_ {
                get => Unk_40_float__raw;
                set {
                    if (Unk_40_float__raw == value) return;
                    Unk_40_float__raw = value;
                    ChangedItems.Add(nameof(Unk_40_float_));
                    OnPropertyChanged(nameof(Unk_40_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_40_float__offset { get; private set; }

            protected float Unk_41_float__raw;
            public const string Unk_41_float__displayName = "Unk 41 (float)";
            public const int Unk_41_float__sortIndex = 2050;
            [SortOrder(Unk_41_float__sortIndex)]
            [DisplayName(Unk_41_float__displayName)]
            public virtual float Unk_41_float_ {
                get => Unk_41_float__raw;
                set {
                    if (Unk_41_float__raw == value) return;
                    Unk_41_float__raw = value;
                    ChangedItems.Add(nameof(Unk_41_float_));
                    OnPropertyChanged(nameof(Unk_41_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_41_float__offset { get; private set; }

            protected float Unk_42_float__raw;
            public const string Unk_42_float__displayName = "Unk 42 (float)";
            public const int Unk_42_float__sortIndex = 2100;
            [SortOrder(Unk_42_float__sortIndex)]
            [DisplayName(Unk_42_float__displayName)]
            public virtual float Unk_42_float_ {
                get => Unk_42_float__raw;
                set {
                    if (Unk_42_float__raw == value) return;
                    Unk_42_float__raw = value;
                    ChangedItems.Add(nameof(Unk_42_float_));
                    OnPropertyChanged(nameof(Unk_42_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_42_float__offset { get; private set; }

            protected float Unk_43_float__raw;
            public const string Unk_43_float__displayName = "Unk 43 (float)";
            public const int Unk_43_float__sortIndex = 2150;
            [SortOrder(Unk_43_float__sortIndex)]
            [DisplayName(Unk_43_float__displayName)]
            public virtual float Unk_43_float_ {
                get => Unk_43_float__raw;
                set {
                    if (Unk_43_float__raw == value) return;
                    Unk_43_float__raw = value;
                    ChangedItems.Add(nameof(Unk_43_float_));
                    OnPropertyChanged(nameof(Unk_43_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_43_float__offset { get; private set; }

            protected float Unk_44_float__raw;
            public const string Unk_44_float__displayName = "Unk 44 (float)";
            public const int Unk_44_float__sortIndex = 2200;
            [SortOrder(Unk_44_float__sortIndex)]
            [DisplayName(Unk_44_float__displayName)]
            public virtual float Unk_44_float_ {
                get => Unk_44_float__raw;
                set {
                    if (Unk_44_float__raw == value) return;
                    Unk_44_float__raw = value;
                    ChangedItems.Add(nameof(Unk_44_float_));
                    OnPropertyChanged(nameof(Unk_44_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_44_float__offset { get; private set; }

            protected float Unk_45_float__raw;
            public const string Unk_45_float__displayName = "Unk 45 (float)";
            public const int Unk_45_float__sortIndex = 2250;
            [SortOrder(Unk_45_float__sortIndex)]
            [DisplayName(Unk_45_float__displayName)]
            public virtual float Unk_45_float_ {
                get => Unk_45_float__raw;
                set {
                    if (Unk_45_float__raw == value) return;
                    Unk_45_float__raw = value;
                    ChangedItems.Add(nameof(Unk_45_float_));
                    OnPropertyChanged(nameof(Unk_45_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_45_float__offset { get; private set; }

            protected float Unk_46_float__raw;
            public const string Unk_46_float__displayName = "Unk 46 (float)";
            public const int Unk_46_float__sortIndex = 2300;
            [SortOrder(Unk_46_float__sortIndex)]
            [DisplayName(Unk_46_float__displayName)]
            public virtual float Unk_46_float_ {
                get => Unk_46_float__raw;
                set {
                    if (Unk_46_float__raw == value) return;
                    Unk_46_float__raw = value;
                    ChangedItems.Add(nameof(Unk_46_float_));
                    OnPropertyChanged(nameof(Unk_46_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_46_float__offset { get; private set; }

            protected float Unk_47_float__raw;
            public const string Unk_47_float__displayName = "Unk 47 (float)";
            public const int Unk_47_float__sortIndex = 2350;
            [SortOrder(Unk_47_float__sortIndex)]
            [DisplayName(Unk_47_float__displayName)]
            public virtual float Unk_47_float_ {
                get => Unk_47_float__raw;
                set {
                    if (Unk_47_float__raw == value) return;
                    Unk_47_float__raw = value;
                    ChangedItems.Add(nameof(Unk_47_float_));
                    OnPropertyChanged(nameof(Unk_47_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_47_float__offset { get; private set; }

            protected float Unk_48_float__raw;
            public const string Unk_48_float__displayName = "Unk 48 (float)";
            public const int Unk_48_float__sortIndex = 2400;
            [SortOrder(Unk_48_float__sortIndex)]
            [DisplayName(Unk_48_float__displayName)]
            public virtual float Unk_48_float_ {
                get => Unk_48_float__raw;
                set {
                    if (Unk_48_float__raw == value) return;
                    Unk_48_float__raw = value;
                    ChangedItems.Add(nameof(Unk_48_float_));
                    OnPropertyChanged(nameof(Unk_48_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_48_float__offset { get; private set; }

            protected float Unk_49_float__raw;
            public const string Unk_49_float__displayName = "Unk 49 (float)";
            public const int Unk_49_float__sortIndex = 2450;
            [SortOrder(Unk_49_float__sortIndex)]
            [DisplayName(Unk_49_float__displayName)]
            public virtual float Unk_49_float_ {
                get => Unk_49_float__raw;
                set {
                    if (Unk_49_float__raw == value) return;
                    Unk_49_float__raw = value;
                    ChangedItems.Add(nameof(Unk_49_float_));
                    OnPropertyChanged(nameof(Unk_49_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_49_float__offset { get; private set; }

            protected float Unk_50_float__raw;
            public const string Unk_50_float__displayName = "Unk 50 (float)";
            public const int Unk_50_float__sortIndex = 2500;
            [SortOrder(Unk_50_float__sortIndex)]
            [DisplayName(Unk_50_float__displayName)]
            public virtual float Unk_50_float_ {
                get => Unk_50_float__raw;
                set {
                    if (Unk_50_float__raw == value) return;
                    Unk_50_float__raw = value;
                    ChangedItems.Add(nameof(Unk_50_float_));
                    OnPropertyChanged(nameof(Unk_50_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_50_float__offset { get; private set; }

            protected float Unk_51_float__raw;
            public const string Unk_51_float__displayName = "Unk 51 (float)";
            public const int Unk_51_float__sortIndex = 2550;
            [SortOrder(Unk_51_float__sortIndex)]
            [DisplayName(Unk_51_float__displayName)]
            public virtual float Unk_51_float_ {
                get => Unk_51_float__raw;
                set {
                    if (Unk_51_float__raw == value) return;
                    Unk_51_float__raw = value;
                    ChangedItems.Add(nameof(Unk_51_float_));
                    OnPropertyChanged(nameof(Unk_51_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_51_float__offset { get; private set; }

            protected float Unk_52_float__raw;
            public const string Unk_52_float__displayName = "Unk 52 (float)";
            public const int Unk_52_float__sortIndex = 2600;
            [SortOrder(Unk_52_float__sortIndex)]
            [DisplayName(Unk_52_float__displayName)]
            public virtual float Unk_52_float_ {
                get => Unk_52_float__raw;
                set {
                    if (Unk_52_float__raw == value) return;
                    Unk_52_float__raw = value;
                    ChangedItems.Add(nameof(Unk_52_float_));
                    OnPropertyChanged(nameof(Unk_52_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_52_float__offset { get; private set; }

            protected float Unk_53_float__raw;
            public const string Unk_53_float__displayName = "Unk 53 (float)";
            public const int Unk_53_float__sortIndex = 2650;
            [SortOrder(Unk_53_float__sortIndex)]
            [DisplayName(Unk_53_float__displayName)]
            public virtual float Unk_53_float_ {
                get => Unk_53_float__raw;
                set {
                    if (Unk_53_float__raw == value) return;
                    Unk_53_float__raw = value;
                    ChangedItems.Add(nameof(Unk_53_float_));
                    OnPropertyChanged(nameof(Unk_53_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_53_float__offset { get; private set; }

            protected float Unk_54_float__raw;
            public const string Unk_54_float__displayName = "Unk 54 (float)";
            public const int Unk_54_float__sortIndex = 2700;
            [SortOrder(Unk_54_float__sortIndex)]
            [DisplayName(Unk_54_float__displayName)]
            public virtual float Unk_54_float_ {
                get => Unk_54_float__raw;
                set {
                    if (Unk_54_float__raw == value) return;
                    Unk_54_float__raw = value;
                    ChangedItems.Add(nameof(Unk_54_float_));
                    OnPropertyChanged(nameof(Unk_54_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_54_float__offset { get; private set; }

            protected float Unk_55_float__raw;
            public const string Unk_55_float__displayName = "Unk 55 (float)";
            public const int Unk_55_float__sortIndex = 2750;
            [SortOrder(Unk_55_float__sortIndex)]
            [DisplayName(Unk_55_float__displayName)]
            public virtual float Unk_55_float_ {
                get => Unk_55_float__raw;
                set {
                    if (Unk_55_float__raw == value) return;
                    Unk_55_float__raw = value;
                    ChangedItems.Add(nameof(Unk_55_float_));
                    OnPropertyChanged(nameof(Unk_55_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_55_float__offset { get; private set; }

            protected float Unk_56_float__raw;
            public const string Unk_56_float__displayName = "Unk 56 (float)";
            public const int Unk_56_float__sortIndex = 2800;
            [SortOrder(Unk_56_float__sortIndex)]
            [DisplayName(Unk_56_float__displayName)]
            public virtual float Unk_56_float_ {
                get => Unk_56_float__raw;
                set {
                    if (Unk_56_float__raw == value) return;
                    Unk_56_float__raw = value;
                    ChangedItems.Add(nameof(Unk_56_float_));
                    OnPropertyChanged(nameof(Unk_56_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_56_float__offset { get; private set; }

            protected float Unk_57_float__raw;
            public const string Unk_57_float__displayName = "Unk 57 (float)";
            public const int Unk_57_float__sortIndex = 2850;
            [SortOrder(Unk_57_float__sortIndex)]
            [DisplayName(Unk_57_float__displayName)]
            public virtual float Unk_57_float_ {
                get => Unk_57_float__raw;
                set {
                    if (Unk_57_float__raw == value) return;
                    Unk_57_float__raw = value;
                    ChangedItems.Add(nameof(Unk_57_float_));
                    OnPropertyChanged(nameof(Unk_57_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_57_float__offset { get; private set; }

            protected uint Unk_58_float__raw;
            public const string Unk_58_float__displayName = "Unk 58 (float)";
            public const int Unk_58_float__sortIndex = 2900;
            [SortOrder(Unk_58_float__sortIndex)]
            [DisplayName(Unk_58_float__displayName)]
            public virtual uint Unk_58_float_ {
                get => Unk_58_float__raw;
                set {
                    if (Unk_58_float__raw == value) return;
                    Unk_58_float__raw = value;
                    ChangedItems.Add(nameof(Unk_58_float_));
                    OnPropertyChanged(nameof(Unk_58_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_58_float__offset { get; private set; }

            protected float Unk_59_float__raw;
            public const string Unk_59_float__displayName = "Unk 59 (float)";
            public const int Unk_59_float__sortIndex = 2950;
            [SortOrder(Unk_59_float__sortIndex)]
            [DisplayName(Unk_59_float__displayName)]
            public virtual float Unk_59_float_ {
                get => Unk_59_float__raw;
                set {
                    if (Unk_59_float__raw == value) return;
                    Unk_59_float__raw = value;
                    ChangedItems.Add(nameof(Unk_59_float_));
                    OnPropertyChanged(nameof(Unk_59_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_59_float__offset { get; private set; }

            protected float Unk_60_float__raw;
            public const string Unk_60_float__displayName = "Unk 60 (float)";
            public const int Unk_60_float__sortIndex = 3000;
            [SortOrder(Unk_60_float__sortIndex)]
            [DisplayName(Unk_60_float__displayName)]
            public virtual float Unk_60_float_ {
                get => Unk_60_float__raw;
                set {
                    if (Unk_60_float__raw == value) return;
                    Unk_60_float__raw = value;
                    ChangedItems.Add(nameof(Unk_60_float_));
                    OnPropertyChanged(nameof(Unk_60_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_60_float__offset { get; private set; }

            protected uint Unk_61_float__raw;
            public const string Unk_61_float__displayName = "Unk 61 (float)";
            public const int Unk_61_float__sortIndex = 3050;
            [SortOrder(Unk_61_float__sortIndex)]
            [DisplayName(Unk_61_float__displayName)]
            public virtual uint Unk_61_float_ {
                get => Unk_61_float__raw;
                set {
                    if (Unk_61_float__raw == value) return;
                    Unk_61_float__raw = value;
                    ChangedItems.Add(nameof(Unk_61_float_));
                    OnPropertyChanged(nameof(Unk_61_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_61_float__offset { get; private set; }

            protected float Unk_62_float__raw;
            public const string Unk_62_float__displayName = "Unk 62 (float)";
            public const int Unk_62_float__sortIndex = 3100;
            [SortOrder(Unk_62_float__sortIndex)]
            [DisplayName(Unk_62_float__displayName)]
            public virtual float Unk_62_float_ {
                get => Unk_62_float__raw;
                set {
                    if (Unk_62_float__raw == value) return;
                    Unk_62_float__raw = value;
                    ChangedItems.Add(nameof(Unk_62_float_));
                    OnPropertyChanged(nameof(Unk_62_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_62_float__offset { get; private set; }

            protected float Unk_63_float__raw;
            public const string Unk_63_float__displayName = "Unk 63 (float)";
            public const int Unk_63_float__sortIndex = 3150;
            [SortOrder(Unk_63_float__sortIndex)]
            [DisplayName(Unk_63_float__displayName)]
            public virtual float Unk_63_float_ {
                get => Unk_63_float__raw;
                set {
                    if (Unk_63_float__raw == value) return;
                    Unk_63_float__raw = value;
                    ChangedItems.Add(nameof(Unk_63_float_));
                    OnPropertyChanged(nameof(Unk_63_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_63_float__offset { get; private set; }

            protected float Unk_64_float__raw;
            public const string Unk_64_float__displayName = "Unk 64 (float)";
            public const int Unk_64_float__sortIndex = 3200;
            [SortOrder(Unk_64_float__sortIndex)]
            [DisplayName(Unk_64_float__displayName)]
            public virtual float Unk_64_float_ {
                get => Unk_64_float__raw;
                set {
                    if (Unk_64_float__raw == value) return;
                    Unk_64_float__raw = value;
                    ChangedItems.Add(nameof(Unk_64_float_));
                    OnPropertyChanged(nameof(Unk_64_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_64_float__offset { get; private set; }

            protected float Unk_65_float__raw;
            public const string Unk_65_float__displayName = "Unk 65 (float)";
            public const int Unk_65_float__sortIndex = 3250;
            [SortOrder(Unk_65_float__sortIndex)]
            [DisplayName(Unk_65_float__displayName)]
            public virtual float Unk_65_float_ {
                get => Unk_65_float__raw;
                set {
                    if (Unk_65_float__raw == value) return;
                    Unk_65_float__raw = value;
                    ChangedItems.Add(nameof(Unk_65_float_));
                    OnPropertyChanged(nameof(Unk_65_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_65_float__offset { get; private set; }

            protected float Unk_66_float__raw;
            public const string Unk_66_float__displayName = "Unk 66 (float)";
            public const int Unk_66_float__sortIndex = 3300;
            [SortOrder(Unk_66_float__sortIndex)]
            [DisplayName(Unk_66_float__displayName)]
            public virtual float Unk_66_float_ {
                get => Unk_66_float__raw;
                set {
                    if (Unk_66_float__raw == value) return;
                    Unk_66_float__raw = value;
                    ChangedItems.Add(nameof(Unk_66_float_));
                    OnPropertyChanged(nameof(Unk_66_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_66_float__offset { get; private set; }

            protected float Unk_67_float__raw;
            public const string Unk_67_float__displayName = "Unk 67 (float)";
            public const int Unk_67_float__sortIndex = 3350;
            [SortOrder(Unk_67_float__sortIndex)]
            [DisplayName(Unk_67_float__displayName)]
            public virtual float Unk_67_float_ {
                get => Unk_67_float__raw;
                set {
                    if (Unk_67_float__raw == value) return;
                    Unk_67_float__raw = value;
                    ChangedItems.Add(nameof(Unk_67_float_));
                    OnPropertyChanged(nameof(Unk_67_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_67_float__offset { get; private set; }

            protected float Unk_68_float__raw;
            public const string Unk_68_float__displayName = "Unk 68 (float)";
            public const int Unk_68_float__sortIndex = 3400;
            [SortOrder(Unk_68_float__sortIndex)]
            [DisplayName(Unk_68_float__displayName)]
            public virtual float Unk_68_float_ {
                get => Unk_68_float__raw;
                set {
                    if (Unk_68_float__raw == value) return;
                    Unk_68_float__raw = value;
                    ChangedItems.Add(nameof(Unk_68_float_));
                    OnPropertyChanged(nameof(Unk_68_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_68_float__offset { get; private set; }

            protected float Unk_69_float__raw;
            public const string Unk_69_float__displayName = "Unk 69 (float)";
            public const int Unk_69_float__sortIndex = 3450;
            [SortOrder(Unk_69_float__sortIndex)]
            [DisplayName(Unk_69_float__displayName)]
            public virtual float Unk_69_float_ {
                get => Unk_69_float__raw;
                set {
                    if (Unk_69_float__raw == value) return;
                    Unk_69_float__raw = value;
                    ChangedItems.Add(nameof(Unk_69_float_));
                    OnPropertyChanged(nameof(Unk_69_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_69_float__offset { get; private set; }

            protected float Unk_70_float__raw;
            public const string Unk_70_float__displayName = "Unk 70 (float)";
            public const int Unk_70_float__sortIndex = 3500;
            [SortOrder(Unk_70_float__sortIndex)]
            [DisplayName(Unk_70_float__displayName)]
            public virtual float Unk_70_float_ {
                get => Unk_70_float__raw;
                set {
                    if (Unk_70_float__raw == value) return;
                    Unk_70_float__raw = value;
                    ChangedItems.Add(nameof(Unk_70_float_));
                    OnPropertyChanged(nameof(Unk_70_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_70_float__offset { get; private set; }

            protected float Unk_71_float__raw;
            public const string Unk_71_float__displayName = "Unk 71 (float)";
            public const int Unk_71_float__sortIndex = 3550;
            [SortOrder(Unk_71_float__sortIndex)]
            [DisplayName(Unk_71_float__displayName)]
            public virtual float Unk_71_float_ {
                get => Unk_71_float__raw;
                set {
                    if (Unk_71_float__raw == value) return;
                    Unk_71_float__raw = value;
                    ChangedItems.Add(nameof(Unk_71_float_));
                    OnPropertyChanged(nameof(Unk_71_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_71_float__offset { get; private set; }

            protected float Unk_72_float__raw;
            public const string Unk_72_float__displayName = "Unk 72 (float)";
            public const int Unk_72_float__sortIndex = 3600;
            [SortOrder(Unk_72_float__sortIndex)]
            [DisplayName(Unk_72_float__displayName)]
            public virtual float Unk_72_float_ {
                get => Unk_72_float__raw;
                set {
                    if (Unk_72_float__raw == value) return;
                    Unk_72_float__raw = value;
                    ChangedItems.Add(nameof(Unk_72_float_));
                    OnPropertyChanged(nameof(Unk_72_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_72_float__offset { get; private set; }

            protected float Unk_73_float__raw;
            public const string Unk_73_float__displayName = "Unk 73 (float)";
            public const int Unk_73_float__sortIndex = 3650;
            [SortOrder(Unk_73_float__sortIndex)]
            [DisplayName(Unk_73_float__displayName)]
            public virtual float Unk_73_float_ {
                get => Unk_73_float__raw;
                set {
                    if (Unk_73_float__raw == value) return;
                    Unk_73_float__raw = value;
                    ChangedItems.Add(nameof(Unk_73_float_));
                    OnPropertyChanged(nameof(Unk_73_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_73_float__offset { get; private set; }

            protected float Unk_74_float__raw;
            public const string Unk_74_float__displayName = "Unk 74 (float)";
            public const int Unk_74_float__sortIndex = 3700;
            [SortOrder(Unk_74_float__sortIndex)]
            [DisplayName(Unk_74_float__displayName)]
            public virtual float Unk_74_float_ {
                get => Unk_74_float__raw;
                set {
                    if (Unk_74_float__raw == value) return;
                    Unk_74_float__raw = value;
                    ChangedItems.Add(nameof(Unk_74_float_));
                    OnPropertyChanged(nameof(Unk_74_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_74_float__offset { get; private set; }

            protected float Unk_75_float__raw;
            public const string Unk_75_float__displayName = "Unk 75 (float)";
            public const int Unk_75_float__sortIndex = 3750;
            [SortOrder(Unk_75_float__sortIndex)]
            [DisplayName(Unk_75_float__displayName)]
            public virtual float Unk_75_float_ {
                get => Unk_75_float__raw;
                set {
                    if (Unk_75_float__raw == value) return;
                    Unk_75_float__raw = value;
                    ChangedItems.Add(nameof(Unk_75_float_));
                    OnPropertyChanged(nameof(Unk_75_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_75_float__offset { get; private set; }

            protected float Unk_76_float__raw;
            public const string Unk_76_float__displayName = "Unk 76 (float)";
            public const int Unk_76_float__sortIndex = 3800;
            [SortOrder(Unk_76_float__sortIndex)]
            [DisplayName(Unk_76_float__displayName)]
            public virtual float Unk_76_float_ {
                get => Unk_76_float__raw;
                set {
                    if (Unk_76_float__raw == value) return;
                    Unk_76_float__raw = value;
                    ChangedItems.Add(nameof(Unk_76_float_));
                    OnPropertyChanged(nameof(Unk_76_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_76_float__offset { get; private set; }

            protected float Unk_77_float__raw;
            public const string Unk_77_float__displayName = "Unk 77 (float)";
            public const int Unk_77_float__sortIndex = 3850;
            [SortOrder(Unk_77_float__sortIndex)]
            [DisplayName(Unk_77_float__displayName)]
            public virtual float Unk_77_float_ {
                get => Unk_77_float__raw;
                set {
                    if (Unk_77_float__raw == value) return;
                    Unk_77_float__raw = value;
                    ChangedItems.Add(nameof(Unk_77_float_));
                    OnPropertyChanged(nameof(Unk_77_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_77_float__offset { get; private set; }

            protected float Unk_78_float__raw;
            public const string Unk_78_float__displayName = "Unk 78 (float)";
            public const int Unk_78_float__sortIndex = 3900;
            [SortOrder(Unk_78_float__sortIndex)]
            [DisplayName(Unk_78_float__displayName)]
            public virtual float Unk_78_float_ {
                get => Unk_78_float__raw;
                set {
                    if (Unk_78_float__raw == value) return;
                    Unk_78_float__raw = value;
                    ChangedItems.Add(nameof(Unk_78_float_));
                    OnPropertyChanged(nameof(Unk_78_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_78_float__offset { get; private set; }

            protected float Unk_79_float__raw;
            public const string Unk_79_float__displayName = "Unk 79 (float)";
            public const int Unk_79_float__sortIndex = 3950;
            [SortOrder(Unk_79_float__sortIndex)]
            [DisplayName(Unk_79_float__displayName)]
            public virtual float Unk_79_float_ {
                get => Unk_79_float__raw;
                set {
                    if (Unk_79_float__raw == value) return;
                    Unk_79_float__raw = value;
                    ChangedItems.Add(nameof(Unk_79_float_));
                    OnPropertyChanged(nameof(Unk_79_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_79_float__offset { get; private set; }

            protected float Unk_80_float__raw;
            public const string Unk_80_float__displayName = "Unk 80 (float)";
            public const int Unk_80_float__sortIndex = 4000;
            [SortOrder(Unk_80_float__sortIndex)]
            [DisplayName(Unk_80_float__displayName)]
            public virtual float Unk_80_float_ {
                get => Unk_80_float__raw;
                set {
                    if (Unk_80_float__raw == value) return;
                    Unk_80_float__raw = value;
                    ChangedItems.Add(nameof(Unk_80_float_));
                    OnPropertyChanged(nameof(Unk_80_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_80_float__offset { get; private set; }

            protected float Unk_81_float__raw;
            public const string Unk_81_float__displayName = "Unk 81 (float)";
            public const int Unk_81_float__sortIndex = 4050;
            [SortOrder(Unk_81_float__sortIndex)]
            [DisplayName(Unk_81_float__displayName)]
            public virtual float Unk_81_float_ {
                get => Unk_81_float__raw;
                set {
                    if (Unk_81_float__raw == value) return;
                    Unk_81_float__raw = value;
                    ChangedItems.Add(nameof(Unk_81_float_));
                    OnPropertyChanged(nameof(Unk_81_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_81_float__offset { get; private set; }

            protected float Unk_82_float__raw;
            public const string Unk_82_float__displayName = "Unk 82 (float)";
            public const int Unk_82_float__sortIndex = 4100;
            [SortOrder(Unk_82_float__sortIndex)]
            [DisplayName(Unk_82_float__displayName)]
            public virtual float Unk_82_float_ {
                get => Unk_82_float__raw;
                set {
                    if (Unk_82_float__raw == value) return;
                    Unk_82_float__raw = value;
                    ChangedItems.Add(nameof(Unk_82_float_));
                    OnPropertyChanged(nameof(Unk_82_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_82_float__offset { get; private set; }

            protected float Unk_83_float__raw;
            public const string Unk_83_float__displayName = "Unk 83 (float)";
            public const int Unk_83_float__sortIndex = 4150;
            [SortOrder(Unk_83_float__sortIndex)]
            [DisplayName(Unk_83_float__displayName)]
            public virtual float Unk_83_float_ {
                get => Unk_83_float__raw;
                set {
                    if (Unk_83_float__raw == value) return;
                    Unk_83_float__raw = value;
                    ChangedItems.Add(nameof(Unk_83_float_));
                    OnPropertyChanged(nameof(Unk_83_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_83_float__offset { get; private set; }

            protected float Unk_84_float__raw;
            public const string Unk_84_float__displayName = "Unk 84 (float)";
            public const int Unk_84_float__sortIndex = 4200;
            [SortOrder(Unk_84_float__sortIndex)]
            [DisplayName(Unk_84_float__displayName)]
            public virtual float Unk_84_float_ {
                get => Unk_84_float__raw;
                set {
                    if (Unk_84_float__raw == value) return;
                    Unk_84_float__raw = value;
                    ChangedItems.Add(nameof(Unk_84_float_));
                    OnPropertyChanged(nameof(Unk_84_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_84_float__offset { get; private set; }

            protected float Unk_85_float__raw;
            public const string Unk_85_float__displayName = "Unk 85 (float)";
            public const int Unk_85_float__sortIndex = 4250;
            [SortOrder(Unk_85_float__sortIndex)]
            [DisplayName(Unk_85_float__displayName)]
            public virtual float Unk_85_float_ {
                get => Unk_85_float__raw;
                set {
                    if (Unk_85_float__raw == value) return;
                    Unk_85_float__raw = value;
                    ChangedItems.Add(nameof(Unk_85_float_));
                    OnPropertyChanged(nameof(Unk_85_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_85_float__offset { get; private set; }

            protected float Unk_86_float__raw;
            public const string Unk_86_float__displayName = "Unk 86 (float)";
            public const int Unk_86_float__sortIndex = 4300;
            [SortOrder(Unk_86_float__sortIndex)]
            [DisplayName(Unk_86_float__displayName)]
            public virtual float Unk_86_float_ {
                get => Unk_86_float__raw;
                set {
                    if (Unk_86_float__raw == value) return;
                    Unk_86_float__raw = value;
                    ChangedItems.Add(nameof(Unk_86_float_));
                    OnPropertyChanged(nameof(Unk_86_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_86_float__offset { get; private set; }

            protected float Unk_87_float__raw;
            public const string Unk_87_float__displayName = "Unk 87 (float)";
            public const int Unk_87_float__sortIndex = 4350;
            [SortOrder(Unk_87_float__sortIndex)]
            [DisplayName(Unk_87_float__displayName)]
            public virtual float Unk_87_float_ {
                get => Unk_87_float__raw;
                set {
                    if (Unk_87_float__raw == value) return;
                    Unk_87_float__raw = value;
                    ChangedItems.Add(nameof(Unk_87_float_));
                    OnPropertyChanged(nameof(Unk_87_float_));
                }
            }

            [DisplayName("Offset")]
            public long Unk_87_float__offset { get; private set; }

            public const int lastSortIndex = 4400;

            public static ObservableMhwStructCollection<Params_4_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Params_4_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Params_4_ LoadData(BinaryReader reader, ulong i) {
                var data = new Params_4_();
                data.Index = i;
                data.Unk_1_float__offset = reader.BaseStream.Position;
                data.Unk_1_float__raw = reader.ReadSingle();
                data.Unk_2_float__offset = reader.BaseStream.Position;
                data.Unk_2_float__raw = reader.ReadSingle();
                data.Unk_3_float__offset = reader.BaseStream.Position;
                data.Unk_3_float__raw = reader.ReadSingle();
                data.Unk_4_float__offset = reader.BaseStream.Position;
                data.Unk_4_float__raw = reader.ReadSingle();
                data.Unk_5_float__offset = reader.BaseStream.Position;
                data.Unk_5_float__raw = reader.ReadSingle();
                data.Unk_6_uint__offset = reader.BaseStream.Position;
                data.Unk_6_uint__raw = reader.ReadUInt32();
                data.Unk_7_float__offset = reader.BaseStream.Position;
                data.Unk_7_float__raw = reader.ReadSingle();
                data.Unk_8_float__offset = reader.BaseStream.Position;
                data.Unk_8_float__raw = reader.ReadSingle();
                data.Unk_9_float__offset = reader.BaseStream.Position;
                data.Unk_9_float__raw = reader.ReadSingle();
                data.Unk_10_float__offset = reader.BaseStream.Position;
                data.Unk_10_float__raw = reader.ReadSingle();
                data.Unk_11_float__offset = reader.BaseStream.Position;
                data.Unk_11_float__raw = reader.ReadSingle();
                data.Unk_12_float__offset = reader.BaseStream.Position;
                data.Unk_12_float__raw = reader.ReadSingle();
                data.Unk_13_uint__offset = reader.BaseStream.Position;
                data.Unk_13_uint__raw = reader.ReadUInt32();
                data.Unk_14_uint__offset = reader.BaseStream.Position;
                data.Unk_14_uint__raw = reader.ReadUInt32();
                data.Unk_15_float__offset = reader.BaseStream.Position;
                data.Unk_15_float__raw = reader.ReadSingle();
                data.Unk_16_float__offset = reader.BaseStream.Position;
                data.Unk_16_float__raw = reader.ReadSingle();
                data.Unk_17_float__offset = reader.BaseStream.Position;
                data.Unk_17_float__raw = reader.ReadSingle();
                data.Unk_18_float__offset = reader.BaseStream.Position;
                data.Unk_18_float__raw = reader.ReadUInt32();
                data.Unk_19_float__offset = reader.BaseStream.Position;
                data.Unk_19_float__raw = reader.ReadSingle();
                data.Unk_20_float__offset = reader.BaseStream.Position;
                data.Unk_20_float__raw = reader.ReadSingle();
                data.Unk_21_float__offset = reader.BaseStream.Position;
                data.Unk_21_float__raw = reader.ReadSingle();
                data.Unk_22_float__offset = reader.BaseStream.Position;
                data.Unk_22_float__raw = reader.ReadSingle();
                data.Unk_23_float__offset = reader.BaseStream.Position;
                data.Unk_23_float__raw = reader.ReadSingle();
                data.Unk_24_float__offset = reader.BaseStream.Position;
                data.Unk_24_float__raw = reader.ReadSingle();
                data.Unk_25_float__offset = reader.BaseStream.Position;
                data.Unk_25_float__raw = reader.ReadSingle();
                data.Unk_26_float__offset = reader.BaseStream.Position;
                data.Unk_26_float__raw = reader.ReadByte();
                data.Unk_27_float__offset = reader.BaseStream.Position;
                data.Unk_27_float__raw = reader.ReadByte();
                data.Unk_28_float__offset = reader.BaseStream.Position;
                data.Unk_28_float__raw = reader.ReadSingle();
                data.Unk_29_float__offset = reader.BaseStream.Position;
                data.Unk_29_float__raw = reader.ReadSingle();
                data.Unk_30_float__offset = reader.BaseStream.Position;
                data.Unk_30_float__raw = reader.ReadByte();
                data.Unk_31_float__offset = reader.BaseStream.Position;
                data.Unk_31_float__raw = reader.ReadByte();
                data.Unk_32_float__offset = reader.BaseStream.Position;
                data.Unk_32_float__raw = reader.ReadByte();
                data.Unk_33_float__offset = reader.BaseStream.Position;
                data.Unk_33_float__raw = reader.ReadByte();
                data.Unk_34_float__offset = reader.BaseStream.Position;
                data.Unk_34_float__raw = reader.ReadSingle();
                data.Unk_35_float__offset = reader.BaseStream.Position;
                data.Unk_35_float__raw = reader.ReadSingle();
                data.Unk_36_float__offset = reader.BaseStream.Position;
                data.Unk_36_float__raw = reader.ReadSingle();
                data.Unk_37_float__offset = reader.BaseStream.Position;
                data.Unk_37_float__raw = reader.ReadByte();
                data.Unk_38_float__offset = reader.BaseStream.Position;
                data.Unk_38_float__raw = reader.ReadByte();
                data.Unk_39_float__offset = reader.BaseStream.Position;
                data.Unk_39_float__raw = reader.ReadSingle();
                data.Unk_40_float__offset = reader.BaseStream.Position;
                data.Unk_40_float__raw = reader.ReadSingle();
                data.Unk_41_float__offset = reader.BaseStream.Position;
                data.Unk_41_float__raw = reader.ReadSingle();
                data.Unk_42_float__offset = reader.BaseStream.Position;
                data.Unk_42_float__raw = reader.ReadSingle();
                data.Unk_43_float__offset = reader.BaseStream.Position;
                data.Unk_43_float__raw = reader.ReadSingle();
                data.Unk_44_float__offset = reader.BaseStream.Position;
                data.Unk_44_float__raw = reader.ReadSingle();
                data.Unk_45_float__offset = reader.BaseStream.Position;
                data.Unk_45_float__raw = reader.ReadSingle();
                data.Unk_46_float__offset = reader.BaseStream.Position;
                data.Unk_46_float__raw = reader.ReadSingle();
                data.Unk_47_float__offset = reader.BaseStream.Position;
                data.Unk_47_float__raw = reader.ReadSingle();
                data.Unk_48_float__offset = reader.BaseStream.Position;
                data.Unk_48_float__raw = reader.ReadSingle();
                data.Unk_49_float__offset = reader.BaseStream.Position;
                data.Unk_49_float__raw = reader.ReadSingle();
                data.Unk_50_float__offset = reader.BaseStream.Position;
                data.Unk_50_float__raw = reader.ReadSingle();
                data.Unk_51_float__offset = reader.BaseStream.Position;
                data.Unk_51_float__raw = reader.ReadSingle();
                data.Unk_52_float__offset = reader.BaseStream.Position;
                data.Unk_52_float__raw = reader.ReadSingle();
                data.Unk_53_float__offset = reader.BaseStream.Position;
                data.Unk_53_float__raw = reader.ReadSingle();
                data.Unk_54_float__offset = reader.BaseStream.Position;
                data.Unk_54_float__raw = reader.ReadSingle();
                data.Unk_55_float__offset = reader.BaseStream.Position;
                data.Unk_55_float__raw = reader.ReadSingle();
                data.Unk_56_float__offset = reader.BaseStream.Position;
                data.Unk_56_float__raw = reader.ReadSingle();
                data.Unk_57_float__offset = reader.BaseStream.Position;
                data.Unk_57_float__raw = reader.ReadSingle();
                data.Unk_58_float__offset = reader.BaseStream.Position;
                data.Unk_58_float__raw = reader.ReadUInt32();
                data.Unk_59_float__offset = reader.BaseStream.Position;
                data.Unk_59_float__raw = reader.ReadSingle();
                data.Unk_60_float__offset = reader.BaseStream.Position;
                data.Unk_60_float__raw = reader.ReadSingle();
                data.Unk_61_float__offset = reader.BaseStream.Position;
                data.Unk_61_float__raw = reader.ReadUInt32();
                data.Unk_62_float__offset = reader.BaseStream.Position;
                data.Unk_62_float__raw = reader.ReadSingle();
                data.Unk_63_float__offset = reader.BaseStream.Position;
                data.Unk_63_float__raw = reader.ReadSingle();
                data.Unk_64_float__offset = reader.BaseStream.Position;
                data.Unk_64_float__raw = reader.ReadSingle();
                data.Unk_65_float__offset = reader.BaseStream.Position;
                data.Unk_65_float__raw = reader.ReadSingle();
                data.Unk_66_float__offset = reader.BaseStream.Position;
                data.Unk_66_float__raw = reader.ReadSingle();
                data.Unk_67_float__offset = reader.BaseStream.Position;
                data.Unk_67_float__raw = reader.ReadSingle();
                data.Unk_68_float__offset = reader.BaseStream.Position;
                data.Unk_68_float__raw = reader.ReadSingle();
                data.Unk_69_float__offset = reader.BaseStream.Position;
                data.Unk_69_float__raw = reader.ReadSingle();
                data.Unk_70_float__offset = reader.BaseStream.Position;
                data.Unk_70_float__raw = reader.ReadSingle();
                data.Unk_71_float__offset = reader.BaseStream.Position;
                data.Unk_71_float__raw = reader.ReadSingle();
                data.Unk_72_float__offset = reader.BaseStream.Position;
                data.Unk_72_float__raw = reader.ReadSingle();
                data.Unk_73_float__offset = reader.BaseStream.Position;
                data.Unk_73_float__raw = reader.ReadSingle();
                data.Unk_74_float__offset = reader.BaseStream.Position;
                data.Unk_74_float__raw = reader.ReadSingle();
                data.Unk_75_float__offset = reader.BaseStream.Position;
                data.Unk_75_float__raw = reader.ReadSingle();
                data.Unk_76_float__offset = reader.BaseStream.Position;
                data.Unk_76_float__raw = reader.ReadSingle();
                data.Unk_77_float__offset = reader.BaseStream.Position;
                data.Unk_77_float__raw = reader.ReadSingle();
                data.Unk_78_float__offset = reader.BaseStream.Position;
                data.Unk_78_float__raw = reader.ReadSingle();
                data.Unk_79_float__offset = reader.BaseStream.Position;
                data.Unk_79_float__raw = reader.ReadSingle();
                data.Unk_80_float__offset = reader.BaseStream.Position;
                data.Unk_80_float__raw = reader.ReadSingle();
                data.Unk_81_float__offset = reader.BaseStream.Position;
                data.Unk_81_float__raw = reader.ReadSingle();
                data.Unk_82_float__offset = reader.BaseStream.Position;
                data.Unk_82_float__raw = reader.ReadSingle();
                data.Unk_83_float__offset = reader.BaseStream.Position;
                data.Unk_83_float__raw = reader.ReadSingle();
                data.Unk_84_float__offset = reader.BaseStream.Position;
                data.Unk_84_float__raw = reader.ReadSingle();
                data.Unk_85_float__offset = reader.BaseStream.Position;
                data.Unk_85_float__raw = reader.ReadSingle();
                data.Unk_86_float__offset = reader.BaseStream.Position;
                data.Unk_86_float__raw = reader.ReadSingle();
                data.Unk_87_float__offset = reader.BaseStream.Position;
                data.Unk_87_float__raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_1_float__raw);
                writer.Write(Unk_2_float__raw);
                writer.Write(Unk_3_float__raw);
                writer.Write(Unk_4_float__raw);
                writer.Write(Unk_5_float__raw);
                writer.Write(Unk_6_uint__raw);
                writer.Write(Unk_7_float__raw);
                writer.Write(Unk_8_float__raw);
                writer.Write(Unk_9_float__raw);
                writer.Write(Unk_10_float__raw);
                writer.Write(Unk_11_float__raw);
                writer.Write(Unk_12_float__raw);
                writer.Write(Unk_13_uint__raw);
                writer.Write(Unk_14_uint__raw);
                writer.Write(Unk_15_float__raw);
                writer.Write(Unk_16_float__raw);
                writer.Write(Unk_17_float__raw);
                writer.Write(Unk_18_float__raw);
                writer.Write(Unk_19_float__raw);
                writer.Write(Unk_20_float__raw);
                writer.Write(Unk_21_float__raw);
                writer.Write(Unk_22_float__raw);
                writer.Write(Unk_23_float__raw);
                writer.Write(Unk_24_float__raw);
                writer.Write(Unk_25_float__raw);
                writer.Write(Unk_26_float__raw);
                writer.Write(Unk_27_float__raw);
                writer.Write(Unk_28_float__raw);
                writer.Write(Unk_29_float__raw);
                writer.Write(Unk_30_float__raw);
                writer.Write(Unk_31_float__raw);
                writer.Write(Unk_32_float__raw);
                writer.Write(Unk_33_float__raw);
                writer.Write(Unk_34_float__raw);
                writer.Write(Unk_35_float__raw);
                writer.Write(Unk_36_float__raw);
                writer.Write(Unk_37_float__raw);
                writer.Write(Unk_38_float__raw);
                writer.Write(Unk_39_float__raw);
                writer.Write(Unk_40_float__raw);
                writer.Write(Unk_41_float__raw);
                writer.Write(Unk_42_float__raw);
                writer.Write(Unk_43_float__raw);
                writer.Write(Unk_44_float__raw);
                writer.Write(Unk_45_float__raw);
                writer.Write(Unk_46_float__raw);
                writer.Write(Unk_47_float__raw);
                writer.Write(Unk_48_float__raw);
                writer.Write(Unk_49_float__raw);
                writer.Write(Unk_50_float__raw);
                writer.Write(Unk_51_float__raw);
                writer.Write(Unk_52_float__raw);
                writer.Write(Unk_53_float__raw);
                writer.Write(Unk_54_float__raw);
                writer.Write(Unk_55_float__raw);
                writer.Write(Unk_56_float__raw);
                writer.Write(Unk_57_float__raw);
                writer.Write(Unk_58_float__raw);
                writer.Write(Unk_59_float__raw);
                writer.Write(Unk_60_float__raw);
                writer.Write(Unk_61_float__raw);
                writer.Write(Unk_62_float__raw);
                writer.Write(Unk_63_float__raw);
                writer.Write(Unk_64_float__raw);
                writer.Write(Unk_65_float__raw);
                writer.Write(Unk_66_float__raw);
                writer.Write(Unk_67_float__raw);
                writer.Write(Unk_68_float__raw);
                writer.Write(Unk_69_float__raw);
                writer.Write(Unk_70_float__raw);
                writer.Write(Unk_71_float__raw);
                writer.Write(Unk_72_float__raw);
                writer.Write(Unk_73_float__raw);
                writer.Write(Unk_74_float__raw);
                writer.Write(Unk_75_float__raw);
                writer.Write(Unk_76_float__raw);
                writer.Write(Unk_77_float__raw);
                writer.Write(Unk_78_float__raw);
                writer.Write(Unk_79_float__raw);
                writer.Write(Unk_80_float__raw);
                writer.Write(Unk_81_float__raw);
                writer.Write(Unk_82_float__raw);
                writer.Write(Unk_83_float__raw);
                writer.Write(Unk_84_float__raw);
                writer.Write(Unk_85_float__raw);
                writer.Write(Unk_86_float__raw);
                writer.Write(Unk_87_float__raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Unk 1 (float)", "Unk_1_float_", "Unk_1_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 2 (float)", "Unk_2_float_", "Unk_2_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 3 (float)", "Unk_3_float_", "Unk_3_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 4 (float)", "Unk_4_float_", "Unk_4_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 5 (float)", "Unk_5_float_", "Unk_5_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 6 (uint)", "Unk_6_uint_", "Unk_6_uint__offset"),
                    new MultiStructItemCustomView(this, "Unk 7 (float)", "Unk_7_float_", "Unk_7_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 8 (float)", "Unk_8_float_", "Unk_8_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 9 (float)", "Unk_9_float_", "Unk_9_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 10 (float)", "Unk_10_float_", "Unk_10_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 11 (float)", "Unk_11_float_", "Unk_11_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 12 (float)", "Unk_12_float_", "Unk_12_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 13 (uint)", "Unk_13_uint_", "Unk_13_uint__offset"),
                    new MultiStructItemCustomView(this, "Unk 14 (uint)", "Unk_14_uint_", "Unk_14_uint__offset"),
                    new MultiStructItemCustomView(this, "Unk 15 (float)", "Unk_15_float_", "Unk_15_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 16 (float)", "Unk_16_float_", "Unk_16_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 17 (float)", "Unk_17_float_", "Unk_17_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 18 (float)", "Unk_18_float_", "Unk_18_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 19 (float)", "Unk_19_float_", "Unk_19_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 20 (float)", "Unk_20_float_", "Unk_20_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 21 (float)", "Unk_21_float_", "Unk_21_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 22 (float)", "Unk_22_float_", "Unk_22_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 23 (float)", "Unk_23_float_", "Unk_23_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 24 (float)", "Unk_24_float_", "Unk_24_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 25 (float)", "Unk_25_float_", "Unk_25_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 26 (float)", "Unk_26_float_", "Unk_26_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 27 (float)", "Unk_27_float_", "Unk_27_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 28 (float)", "Unk_28_float_", "Unk_28_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 29 (float)", "Unk_29_float_", "Unk_29_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 30 (float)", "Unk_30_float_", "Unk_30_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 31 (float)", "Unk_31_float_", "Unk_31_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 32 (float)", "Unk_32_float_", "Unk_32_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 33 (float)", "Unk_33_float_", "Unk_33_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 34 (float)", "Unk_34_float_", "Unk_34_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 35 (float)", "Unk_35_float_", "Unk_35_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 36 (float)", "Unk_36_float_", "Unk_36_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 37 (float)", "Unk_37_float_", "Unk_37_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 38 (float)", "Unk_38_float_", "Unk_38_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 39 (float)", "Unk_39_float_", "Unk_39_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 40 (float)", "Unk_40_float_", "Unk_40_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 41 (float)", "Unk_41_float_", "Unk_41_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 42 (float)", "Unk_42_float_", "Unk_42_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 43 (float)", "Unk_43_float_", "Unk_43_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 44 (float)", "Unk_44_float_", "Unk_44_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 45 (float)", "Unk_45_float_", "Unk_45_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 46 (float)", "Unk_46_float_", "Unk_46_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 47 (float)", "Unk_47_float_", "Unk_47_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 48 (float)", "Unk_48_float_", "Unk_48_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 49 (float)", "Unk_49_float_", "Unk_49_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 50 (float)", "Unk_50_float_", "Unk_50_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 51 (float)", "Unk_51_float_", "Unk_51_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 52 (float)", "Unk_52_float_", "Unk_52_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 53 (float)", "Unk_53_float_", "Unk_53_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 54 (float)", "Unk_54_float_", "Unk_54_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 55 (float)", "Unk_55_float_", "Unk_55_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 56 (float)", "Unk_56_float_", "Unk_56_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 57 (float)", "Unk_57_float_", "Unk_57_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 58 (float)", "Unk_58_float_", "Unk_58_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 59 (float)", "Unk_59_float_", "Unk_59_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 60 (float)", "Unk_60_float_", "Unk_60_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 61 (float)", "Unk_61_float_", "Unk_61_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 62 (float)", "Unk_62_float_", "Unk_62_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 63 (float)", "Unk_63_float_", "Unk_63_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 64 (float)", "Unk_64_float_", "Unk_64_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 65 (float)", "Unk_65_float_", "Unk_65_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 66 (float)", "Unk_66_float_", "Unk_66_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 67 (float)", "Unk_67_float_", "Unk_67_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 68 (float)", "Unk_68_float_", "Unk_68_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 69 (float)", "Unk_69_float_", "Unk_69_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 70 (float)", "Unk_70_float_", "Unk_70_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 71 (float)", "Unk_71_float_", "Unk_71_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 72 (float)", "Unk_72_float_", "Unk_72_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 73 (float)", "Unk_73_float_", "Unk_73_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 74 (float)", "Unk_74_float_", "Unk_74_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 75 (float)", "Unk_75_float_", "Unk_75_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 76 (float)", "Unk_76_float_", "Unk_76_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 77 (float)", "Unk_77_float_", "Unk_77_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 78 (float)", "Unk_78_float_", "Unk_78_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 79 (float)", "Unk_79_float_", "Unk_79_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 80 (float)", "Unk_80_float_", "Unk_80_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 81 (float)", "Unk_81_float_", "Unk_81_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 82 (float)", "Unk_82_float_", "Unk_82_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 83 (float)", "Unk_83_float_", "Unk_83_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 84 (float)", "Unk_84_float_", "Unk_84_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 85 (float)", "Unk_85_float_", "Unk_85_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 86 (float)", "Unk_86_float_", "Unk_86_float__offset"),
                    new MultiStructItemCustomView(this, "Unk 87 (float)", "Unk_87_float_", "Unk_87_float__offset"),
                };
            }
        }

        public override void LoadFile(string targetFile) {
            using var reader = new BinaryReader(OpenFile(targetFile, EncryptionKey), Encoding.UTF8);
            data = new LinkedList<MhwStructDataContainer>();
            var Header_ = new MhwStructDataContainer<Header>(Header.LoadData(reader), typeof(Header));
            data.AddLast(Header_);
            var Params_1__ = new MhwStructDataContainer<Params_1_>(Params_1_.LoadData(reader), typeof(Params_1_));
            data.AddLast(Params_1__);
            var Params_2__ = new MhwStructDataContainer<Params_2_>(Params_2_.LoadData(reader), typeof(Params_2_));
            data.AddLast(Params_2__);
            var Params_3__ = new MhwStructDataContainer<Params_3_>(Params_3_.LoadData(reader), typeof(Params_3_));
            data.AddLast(Params_3__);
            var Params_4__ = new MhwStructDataContainer<Params_4_>(Params_4_.LoadData(reader), typeof(Params_4_));
            data.AddLast(Params_4__);
        }
    }
}
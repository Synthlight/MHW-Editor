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

namespace MHW_Editor.Structs.Monsters {
    public partial class MonsterCommonParam {
        public override string EncryptionKey => null;

        public partial class Monster_Common_Params_1_ : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Monster Common Params (1)";

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

            protected char[] ECP_raw;
            public const string ECP_displayName = "ECP";
            public const int ECP_sortIndex = 100;
            [SortOrder(ECP_sortIndex)]
            [DisplayName(ECP_displayName)]
            [IsReadOnly]
            public virtual string ECP {
                get => (string) new string(ECP_raw);
                set {
                    if ((string) new string(ECP_raw) == value) return;
                    ECP_raw = (char[]) value.ToCharArray(0, 3);
                    ChangedItems.Add(nameof(ECP));
                    OnPropertyChanged(nameof(ECP));
                }
            }

            protected uint Unk_1_raw;
            public const string Unk_1_displayName = "Unk 1";
            public const int Unk_1_sortIndex = 150;
            [SortOrder(Unk_1_sortIndex)]
            [DisplayName(Unk_1_displayName)]
            [IsReadOnly]
            public virtual uint Unk_1 {
                get => Unk_1_raw;
                set {
                    if (Unk_1_raw == value) return;
                    Unk_1_raw = value;
                    ChangedItems.Add(nameof(Unk_1));
                    OnPropertyChanged(nameof(Unk_1));
                }
            }

            protected float Unk_2_raw;
            public const string Unk_2_displayName = "Unk 2";
            public const int Unk_2_sortIndex = 200;
            [SortOrder(Unk_2_sortIndex)]
            [DisplayName(Unk_2_displayName)]
            public virtual float Unk_2 {
                get => Unk_2_raw;
                set {
                    if (Unk_2_raw == value) return;
                    Unk_2_raw = value;
                    ChangedItems.Add(nameof(Unk_2));
                    OnPropertyChanged(nameof(Unk_2));
                }
            }

            public const int lastSortIndex = 250;

            public static ObservableMhwStructCollection<Monster_Common_Params_1_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Monster_Common_Params_1_>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Monster_Common_Params_1_ LoadData(BinaryReader reader, ulong i) {
                var data = new Monster_Common_Params_1_();
                data.Index = i;
                data.Magic_1_raw = reader.ReadUInt32();
                data.ECP_raw = reader.ReadChars(4);
                data.Unk_1_raw = reader.ReadUInt32();
                data.Unk_2_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Magic_1_raw);
                writer.Write(ECP_raw);
                writer.Write(Unk_1_raw);
                writer.Write(Unk_2_raw);
            }
        }

        public partial class Sharpness_Multipliers : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 7;
            public const string GridName = "Sharpness Multipliers";

            protected float Red_raw;
            public const string Red_displayName = "Red";
            public const int Red_sortIndex = 50;
            [SortOrder(Red_sortIndex)]
            [DisplayName(Red_displayName)]
            public virtual float Red {
                get => Red_raw;
                set {
                    if (Red_raw == value) return;
                    Red_raw = value;
                    ChangedItems.Add(nameof(Red));
                    OnPropertyChanged(nameof(Red));
                }
            }

            protected float Orange_raw;
            public const string Orange_displayName = "Orange";
            public const int Orange_sortIndex = 100;
            [SortOrder(Orange_sortIndex)]
            [DisplayName(Orange_displayName)]
            public virtual float Orange {
                get => Orange_raw;
                set {
                    if (Orange_raw == value) return;
                    Orange_raw = value;
                    ChangedItems.Add(nameof(Orange));
                    OnPropertyChanged(nameof(Orange));
                }
            }

            protected float Yellow_raw;
            public const string Yellow_displayName = "Yellow";
            public const int Yellow_sortIndex = 150;
            [SortOrder(Yellow_sortIndex)]
            [DisplayName(Yellow_displayName)]
            public virtual float Yellow {
                get => Yellow_raw;
                set {
                    if (Yellow_raw == value) return;
                    Yellow_raw = value;
                    ChangedItems.Add(nameof(Yellow));
                    OnPropertyChanged(nameof(Yellow));
                }
            }

            protected float Green_raw;
            public const string Green_displayName = "Green";
            public const int Green_sortIndex = 200;
            [SortOrder(Green_sortIndex)]
            [DisplayName(Green_displayName)]
            public virtual float Green {
                get => Green_raw;
                set {
                    if (Green_raw == value) return;
                    Green_raw = value;
                    ChangedItems.Add(nameof(Green));
                    OnPropertyChanged(nameof(Green));
                }
            }

            protected float Blue_raw;
            public const string Blue_displayName = "Blue";
            public const int Blue_sortIndex = 250;
            [SortOrder(Blue_sortIndex)]
            [DisplayName(Blue_displayName)]
            public virtual float Blue {
                get => Blue_raw;
                set {
                    if (Blue_raw == value) return;
                    Blue_raw = value;
                    ChangedItems.Add(nameof(Blue));
                    OnPropertyChanged(nameof(Blue));
                }
            }

            protected float White_raw;
            public const string White_displayName = "White";
            public const int White_sortIndex = 300;
            [SortOrder(White_sortIndex)]
            [DisplayName(White_displayName)]
            public virtual float White {
                get => White_raw;
                set {
                    if (White_raw == value) return;
                    White_raw = value;
                    ChangedItems.Add(nameof(White));
                    OnPropertyChanged(nameof(White));
                }
            }

            protected float Purple_raw;
            public const string Purple_displayName = "Purple";
            public const int Purple_sortIndex = 350;
            [SortOrder(Purple_sortIndex)]
            [DisplayName(Purple_displayName)]
            public virtual float Purple {
                get => Purple_raw;
                set {
                    if (Purple_raw == value) return;
                    Purple_raw = value;
                    ChangedItems.Add(nameof(Purple));
                    OnPropertyChanged(nameof(Purple));
                }
            }

            public const int lastSortIndex = 400;

            public static ObservableMhwStructCollection<Sharpness_Multipliers> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Sharpness_Multipliers>();
                var count = 7UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Sharpness_Multipliers LoadData(BinaryReader reader, ulong i) {
                var data = new Sharpness_Multipliers();
                data.Index = i;
                data.Red_raw = reader.ReadSingle();
                data.Orange_raw = reader.ReadSingle();
                data.Yellow_raw = reader.ReadSingle();
                data.Green_raw = reader.ReadSingle();
                data.Blue_raw = reader.ReadSingle();
                data.White_raw = reader.ReadSingle();
                data.Purple_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Red_raw);
                writer.Write(Orange_raw);
                writer.Write(Yellow_raw);
                writer.Write(Green_raw);
                writer.Write(Blue_raw);
                writer.Write(White_raw);
                writer.Write(Purple_raw);
            }
        }

        public partial class Monster_Common_Params_2_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Monster Common Params (2)";

            protected float Unk_3_raw;
            public const string Unk_3_displayName = "Unk 3";
            public const int Unk_3_sortIndex = 50;
            [SortOrder(Unk_3_sortIndex)]
            [DisplayName(Unk_3_displayName)]
            public virtual float Unk_3 {
                get => Unk_3_raw;
                set {
                    if (Unk_3_raw == value) return;
                    Unk_3_raw = value;
                    ChangedItems.Add(nameof(Unk_3));
                    OnPropertyChanged(nameof(Unk_3));
                }
            }

            protected float Unk_4_raw;
            public const string Unk_4_displayName = "Unk 4";
            public const int Unk_4_sortIndex = 100;
            [SortOrder(Unk_4_sortIndex)]
            [DisplayName(Unk_4_displayName)]
            public virtual float Unk_4 {
                get => Unk_4_raw;
                set {
                    if (Unk_4_raw == value) return;
                    Unk_4_raw = value;
                    ChangedItems.Add(nameof(Unk_4));
                    OnPropertyChanged(nameof(Unk_4));
                }
            }

            protected float Unk_5_raw;
            public const string Unk_5_displayName = "Unk 5";
            public const int Unk_5_sortIndex = 150;
            [SortOrder(Unk_5_sortIndex)]
            [DisplayName(Unk_5_displayName)]
            public virtual float Unk_5 {
                get => Unk_5_raw;
                set {
                    if (Unk_5_raw == value) return;
                    Unk_5_raw = value;
                    ChangedItems.Add(nameof(Unk_5));
                    OnPropertyChanged(nameof(Unk_5));
                }
            }

            protected float Unk_6_raw;
            public const string Unk_6_displayName = "Unk 6";
            public const int Unk_6_sortIndex = 200;
            [SortOrder(Unk_6_sortIndex)]
            [DisplayName(Unk_6_displayName)]
            public virtual float Unk_6 {
                get => Unk_6_raw;
                set {
                    if (Unk_6_raw == value) return;
                    Unk_6_raw = value;
                    ChangedItems.Add(nameof(Unk_6));
                    OnPropertyChanged(nameof(Unk_6));
                }
            }

            protected float Unk_7_raw;
            public const string Unk_7_displayName = "Unk 7";
            public const int Unk_7_sortIndex = 250;
            [SortOrder(Unk_7_sortIndex)]
            [DisplayName(Unk_7_displayName)]
            public virtual float Unk_7 {
                get => Unk_7_raw;
                set {
                    if (Unk_7_raw == value) return;
                    Unk_7_raw = value;
                    ChangedItems.Add(nameof(Unk_7));
                    OnPropertyChanged(nameof(Unk_7));
                }
            }

            protected float Unk_8_raw;
            public const string Unk_8_displayName = "Unk 8";
            public const int Unk_8_sortIndex = 300;
            [SortOrder(Unk_8_sortIndex)]
            [DisplayName(Unk_8_displayName)]
            public virtual float Unk_8 {
                get => Unk_8_raw;
                set {
                    if (Unk_8_raw == value) return;
                    Unk_8_raw = value;
                    ChangedItems.Add(nameof(Unk_8));
                    OnPropertyChanged(nameof(Unk_8));
                }
            }

            protected float Unk_9_raw;
            public const string Unk_9_displayName = "Unk 9";
            public const int Unk_9_sortIndex = 350;
            [SortOrder(Unk_9_sortIndex)]
            [DisplayName(Unk_9_displayName)]
            public virtual float Unk_9 {
                get => Unk_9_raw;
                set {
                    if (Unk_9_raw == value) return;
                    Unk_9_raw = value;
                    ChangedItems.Add(nameof(Unk_9));
                    OnPropertyChanged(nameof(Unk_9));
                }
            }

            protected float Unk_10_raw;
            public const string Unk_10_displayName = "Unk 10";
            public const int Unk_10_sortIndex = 400;
            [SortOrder(Unk_10_sortIndex)]
            [DisplayName(Unk_10_displayName)]
            public virtual float Unk_10 {
                get => Unk_10_raw;
                set {
                    if (Unk_10_raw == value) return;
                    Unk_10_raw = value;
                    ChangedItems.Add(nameof(Unk_10));
                    OnPropertyChanged(nameof(Unk_10));
                }
            }

            protected float Unk_11_raw;
            public const string Unk_11_displayName = "Unk 11";
            public const int Unk_11_sortIndex = 450;
            [SortOrder(Unk_11_sortIndex)]
            [DisplayName(Unk_11_displayName)]
            public virtual float Unk_11 {
                get => Unk_11_raw;
                set {
                    if (Unk_11_raw == value) return;
                    Unk_11_raw = value;
                    ChangedItems.Add(nameof(Unk_11));
                    OnPropertyChanged(nameof(Unk_11));
                }
            }

            protected float Unk_12_raw;
            public const string Unk_12_displayName = "Unk 12";
            public const int Unk_12_sortIndex = 500;
            [SortOrder(Unk_12_sortIndex)]
            [DisplayName(Unk_12_displayName)]
            public virtual float Unk_12 {
                get => Unk_12_raw;
                set {
                    if (Unk_12_raw == value) return;
                    Unk_12_raw = value;
                    ChangedItems.Add(nameof(Unk_12));
                    OnPropertyChanged(nameof(Unk_12));
                }
            }

            protected float Unk_13_raw;
            public const string Unk_13_displayName = "Unk 13";
            public const int Unk_13_sortIndex = 550;
            [SortOrder(Unk_13_sortIndex)]
            [DisplayName(Unk_13_displayName)]
            public virtual float Unk_13 {
                get => Unk_13_raw;
                set {
                    if (Unk_13_raw == value) return;
                    Unk_13_raw = value;
                    ChangedItems.Add(nameof(Unk_13));
                    OnPropertyChanged(nameof(Unk_13));
                }
            }

            protected float Unk_14_raw;
            public const string Unk_14_displayName = "Unk 14";
            public const int Unk_14_sortIndex = 600;
            [SortOrder(Unk_14_sortIndex)]
            [DisplayName(Unk_14_displayName)]
            public virtual float Unk_14 {
                get => Unk_14_raw;
                set {
                    if (Unk_14_raw == value) return;
                    Unk_14_raw = value;
                    ChangedItems.Add(nameof(Unk_14));
                    OnPropertyChanged(nameof(Unk_14));
                }
            }

            protected float Unk_15_raw;
            public const string Unk_15_displayName = "Unk 15";
            public const int Unk_15_sortIndex = 650;
            [SortOrder(Unk_15_sortIndex)]
            [DisplayName(Unk_15_displayName)]
            public virtual float Unk_15 {
                get => Unk_15_raw;
                set {
                    if (Unk_15_raw == value) return;
                    Unk_15_raw = value;
                    ChangedItems.Add(nameof(Unk_15));
                    OnPropertyChanged(nameof(Unk_15));
                }
            }

            protected float Unk_16_raw;
            public const string Unk_16_displayName = "Unk 16";
            public const int Unk_16_sortIndex = 700;
            [SortOrder(Unk_16_sortIndex)]
            [DisplayName(Unk_16_displayName)]
            public virtual float Unk_16 {
                get => Unk_16_raw;
                set {
                    if (Unk_16_raw == value) return;
                    Unk_16_raw = value;
                    ChangedItems.Add(nameof(Unk_16));
                    OnPropertyChanged(nameof(Unk_16));
                }
            }

            protected float Unk_17_raw;
            public const string Unk_17_displayName = "Unk 17";
            public const int Unk_17_sortIndex = 750;
            [SortOrder(Unk_17_sortIndex)]
            [DisplayName(Unk_17_displayName)]
            public virtual float Unk_17 {
                get => Unk_17_raw;
                set {
                    if (Unk_17_raw == value) return;
                    Unk_17_raw = value;
                    ChangedItems.Add(nameof(Unk_17));
                    OnPropertyChanged(nameof(Unk_17));
                }
            }

            protected float Unk_18_raw;
            public const string Unk_18_displayName = "Unk 18";
            public const int Unk_18_sortIndex = 800;
            [SortOrder(Unk_18_sortIndex)]
            [DisplayName(Unk_18_displayName)]
            public virtual float Unk_18 {
                get => Unk_18_raw;
                set {
                    if (Unk_18_raw == value) return;
                    Unk_18_raw = value;
                    ChangedItems.Add(nameof(Unk_18));
                    OnPropertyChanged(nameof(Unk_18));
                }
            }

            protected uint Unk_19_raw;
            public const string Unk_19_displayName = "Unk 19";
            public const int Unk_19_sortIndex = 850;
            [SortOrder(Unk_19_sortIndex)]
            [DisplayName(Unk_19_displayName)]
            public virtual uint Unk_19 {
                get => Unk_19_raw;
                set {
                    if (Unk_19_raw == value) return;
                    Unk_19_raw = value;
                    ChangedItems.Add(nameof(Unk_19));
                    OnPropertyChanged(nameof(Unk_19));
                }
            }

            protected uint Unk_20_raw;
            public const string Unk_20_displayName = "Unk 20";
            public const int Unk_20_sortIndex = 900;
            [SortOrder(Unk_20_sortIndex)]
            [DisplayName(Unk_20_displayName)]
            public virtual uint Unk_20 {
                get => Unk_20_raw;
                set {
                    if (Unk_20_raw == value) return;
                    Unk_20_raw = value;
                    ChangedItems.Add(nameof(Unk_20));
                    OnPropertyChanged(nameof(Unk_20));
                }
            }

            protected float Unk_21_raw;
            public const string Unk_21_displayName = "Unk 21";
            public const int Unk_21_sortIndex = 950;
            [SortOrder(Unk_21_sortIndex)]
            [DisplayName(Unk_21_displayName)]
            public virtual float Unk_21 {
                get => Unk_21_raw;
                set {
                    if (Unk_21_raw == value) return;
                    Unk_21_raw = value;
                    ChangedItems.Add(nameof(Unk_21));
                    OnPropertyChanged(nameof(Unk_21));
                }
            }

            protected float Unk_22_raw;
            public const string Unk_22_displayName = "Unk 22";
            public const int Unk_22_sortIndex = 1000;
            [SortOrder(Unk_22_sortIndex)]
            [DisplayName(Unk_22_displayName)]
            public virtual float Unk_22 {
                get => Unk_22_raw;
                set {
                    if (Unk_22_raw == value) return;
                    Unk_22_raw = value;
                    ChangedItems.Add(nameof(Unk_22));
                    OnPropertyChanged(nameof(Unk_22));
                }
            }

            protected float Unk_23_raw;
            public const string Unk_23_displayName = "Unk 23";
            public const int Unk_23_sortIndex = 1050;
            [SortOrder(Unk_23_sortIndex)]
            [DisplayName(Unk_23_displayName)]
            public virtual float Unk_23 {
                get => Unk_23_raw;
                set {
                    if (Unk_23_raw == value) return;
                    Unk_23_raw = value;
                    ChangedItems.Add(nameof(Unk_23));
                    OnPropertyChanged(nameof(Unk_23));
                }
            }

            protected float Unk_24_raw;
            public const string Unk_24_displayName = "Unk 24";
            public const int Unk_24_sortIndex = 1100;
            [SortOrder(Unk_24_sortIndex)]
            [DisplayName(Unk_24_displayName)]
            public virtual float Unk_24 {
                get => Unk_24_raw;
                set {
                    if (Unk_24_raw == value) return;
                    Unk_24_raw = value;
                    ChangedItems.Add(nameof(Unk_24));
                    OnPropertyChanged(nameof(Unk_24));
                }
            }

            protected float Unk_25_raw;
            public const string Unk_25_displayName = "Unk 25";
            public const int Unk_25_sortIndex = 1150;
            [SortOrder(Unk_25_sortIndex)]
            [DisplayName(Unk_25_displayName)]
            public virtual float Unk_25 {
                get => Unk_25_raw;
                set {
                    if (Unk_25_raw == value) return;
                    Unk_25_raw = value;
                    ChangedItems.Add(nameof(Unk_25));
                    OnPropertyChanged(nameof(Unk_25));
                }
            }

            protected float Unk_26_raw;
            public const string Unk_26_displayName = "Unk 26";
            public const int Unk_26_sortIndex = 1200;
            [SortOrder(Unk_26_sortIndex)]
            [DisplayName(Unk_26_displayName)]
            public virtual float Unk_26 {
                get => Unk_26_raw;
                set {
                    if (Unk_26_raw == value) return;
                    Unk_26_raw = value;
                    ChangedItems.Add(nameof(Unk_26));
                    OnPropertyChanged(nameof(Unk_26));
                }
            }

            protected float Unk_27_raw;
            public const string Unk_27_displayName = "Unk 27";
            public const int Unk_27_sortIndex = 1250;
            [SortOrder(Unk_27_sortIndex)]
            [DisplayName(Unk_27_displayName)]
            public virtual float Unk_27 {
                get => Unk_27_raw;
                set {
                    if (Unk_27_raw == value) return;
                    Unk_27_raw = value;
                    ChangedItems.Add(nameof(Unk_27));
                    OnPropertyChanged(nameof(Unk_27));
                }
            }

            protected float Unk_28_raw;
            public const string Unk_28_displayName = "Unk 28";
            public const int Unk_28_sortIndex = 1300;
            [SortOrder(Unk_28_sortIndex)]
            [DisplayName(Unk_28_displayName)]
            public virtual float Unk_28 {
                get => Unk_28_raw;
                set {
                    if (Unk_28_raw == value) return;
                    Unk_28_raw = value;
                    ChangedItems.Add(nameof(Unk_28));
                    OnPropertyChanged(nameof(Unk_28));
                }
            }

            protected float Unk_29_raw;
            public const string Unk_29_displayName = "Unk 29";
            public const int Unk_29_sortIndex = 1350;
            [SortOrder(Unk_29_sortIndex)]
            [DisplayName(Unk_29_displayName)]
            public virtual float Unk_29 {
                get => Unk_29_raw;
                set {
                    if (Unk_29_raw == value) return;
                    Unk_29_raw = value;
                    ChangedItems.Add(nameof(Unk_29));
                    OnPropertyChanged(nameof(Unk_29));
                }
            }

            public const int lastSortIndex = 1400;

            public static ObservableMhwStructCollection<Monster_Common_Params_2_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Monster_Common_Params_2_>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Monster_Common_Params_2_ LoadData(BinaryReader reader, ulong i) {
                var data = new Monster_Common_Params_2_();
                data.Index = i;
                data.Unk_3_raw = reader.ReadSingle();
                data.Unk_4_raw = reader.ReadSingle();
                data.Unk_5_raw = reader.ReadSingle();
                data.Unk_6_raw = reader.ReadSingle();
                data.Unk_7_raw = reader.ReadSingle();
                data.Unk_8_raw = reader.ReadSingle();
                data.Unk_9_raw = reader.ReadSingle();
                data.Unk_10_raw = reader.ReadSingle();
                data.Unk_11_raw = reader.ReadSingle();
                data.Unk_12_raw = reader.ReadSingle();
                data.Unk_13_raw = reader.ReadSingle();
                data.Unk_14_raw = reader.ReadSingle();
                data.Unk_15_raw = reader.ReadSingle();
                data.Unk_16_raw = reader.ReadSingle();
                data.Unk_17_raw = reader.ReadSingle();
                data.Unk_18_raw = reader.ReadSingle();
                data.Unk_19_raw = reader.ReadUInt32();
                data.Unk_20_raw = reader.ReadUInt32();
                data.Unk_21_raw = reader.ReadSingle();
                data.Unk_22_raw = reader.ReadSingle();
                data.Unk_23_raw = reader.ReadSingle();
                data.Unk_24_raw = reader.ReadSingle();
                data.Unk_25_raw = reader.ReadSingle();
                data.Unk_26_raw = reader.ReadSingle();
                data.Unk_27_raw = reader.ReadSingle();
                data.Unk_28_raw = reader.ReadSingle();
                data.Unk_29_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_3_raw);
                writer.Write(Unk_4_raw);
                writer.Write(Unk_5_raw);
                writer.Write(Unk_6_raw);
                writer.Write(Unk_7_raw);
                writer.Write(Unk_8_raw);
                writer.Write(Unk_9_raw);
                writer.Write(Unk_10_raw);
                writer.Write(Unk_11_raw);
                writer.Write(Unk_12_raw);
                writer.Write(Unk_13_raw);
                writer.Write(Unk_14_raw);
                writer.Write(Unk_15_raw);
                writer.Write(Unk_16_raw);
                writer.Write(Unk_17_raw);
                writer.Write(Unk_18_raw);
                writer.Write(Unk_19_raw);
                writer.Write(Unk_20_raw);
                writer.Write(Unk_21_raw);
                writer.Write(Unk_22_raw);
                writer.Write(Unk_23_raw);
                writer.Write(Unk_24_raw);
                writer.Write(Unk_25_raw);
                writer.Write(Unk_26_raw);
                writer.Write(Unk_27_raw);
                writer.Write(Unk_28_raw);
                writer.Write(Unk_29_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Unk 3", "Unk_3"),
                    new MultiStructItemCustomView(this, "Unk 4", "Unk_4"),
                    new MultiStructItemCustomView(this, "Unk 5", "Unk_5"),
                    new MultiStructItemCustomView(this, "Unk 6", "Unk_6"),
                    new MultiStructItemCustomView(this, "Unk 7", "Unk_7"),
                    new MultiStructItemCustomView(this, "Unk 8", "Unk_8"),
                    new MultiStructItemCustomView(this, "Unk 9", "Unk_9"),
                    new MultiStructItemCustomView(this, "Unk 10", "Unk_10"),
                    new MultiStructItemCustomView(this, "Unk 11", "Unk_11"),
                    new MultiStructItemCustomView(this, "Unk 12", "Unk_12"),
                    new MultiStructItemCustomView(this, "Unk 13", "Unk_13"),
                    new MultiStructItemCustomView(this, "Unk 14", "Unk_14"),
                    new MultiStructItemCustomView(this, "Unk 15", "Unk_15"),
                    new MultiStructItemCustomView(this, "Unk 16", "Unk_16"),
                    new MultiStructItemCustomView(this, "Unk 17", "Unk_17"),
                    new MultiStructItemCustomView(this, "Unk 18", "Unk_18"),
                    new MultiStructItemCustomView(this, "Unk 19", "Unk_19"),
                    new MultiStructItemCustomView(this, "Unk 20", "Unk_20"),
                    new MultiStructItemCustomView(this, "Unk 21", "Unk_21"),
                    new MultiStructItemCustomView(this, "Unk 22", "Unk_22"),
                    new MultiStructItemCustomView(this, "Unk 23", "Unk_23"),
                    new MultiStructItemCustomView(this, "Unk 24", "Unk_24"),
                    new MultiStructItemCustomView(this, "Unk 25", "Unk_25"),
                    new MultiStructItemCustomView(this, "Unk 26", "Unk_26"),
                    new MultiStructItemCustomView(this, "Unk 27", "Unk_27"),
                    new MultiStructItemCustomView(this, "Unk 28", "Unk_28"),
                    new MultiStructItemCustomView(this, "Unk 29", "Unk_29"),
                };
            }
        }

        public partial class Sharpness_HZV_Threshold : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 4;
            public const string GridName = "Sharpness HZV Threshold";

            protected float T1_raw;
            public const string T1_displayName = "T1";
            public const int T1_sortIndex = 50;
            [SortOrder(T1_sortIndex)]
            [DisplayName(T1_displayName)]
            public virtual float T1 {
                get => T1_raw;
                set {
                    if (T1_raw == value) return;
                    T1_raw = value;
                    ChangedItems.Add(nameof(T1));
                    OnPropertyChanged(nameof(T1));
                }
            }

            protected float T2_raw;
            public const string T2_displayName = "T2";
            public const int T2_sortIndex = 100;
            [SortOrder(T2_sortIndex)]
            [DisplayName(T2_displayName)]
            public virtual float T2 {
                get => T2_raw;
                set {
                    if (T2_raw == value) return;
                    T2_raw = value;
                    ChangedItems.Add(nameof(T2));
                    OnPropertyChanged(nameof(T2));
                }
            }

            protected float T3_raw;
            public const string T3_displayName = "T3";
            public const int T3_sortIndex = 150;
            [SortOrder(T3_sortIndex)]
            [DisplayName(T3_displayName)]
            public virtual float T3 {
                get => T3_raw;
                set {
                    if (T3_raw == value) return;
                    T3_raw = value;
                    ChangedItems.Add(nameof(T3));
                    OnPropertyChanged(nameof(T3));
                }
            }

            protected float T4_raw;
            public const string T4_displayName = "T4";
            public const int T4_sortIndex = 200;
            [SortOrder(T4_sortIndex)]
            [DisplayName(T4_displayName)]
            public virtual float T4 {
                get => T4_raw;
                set {
                    if (T4_raw == value) return;
                    T4_raw = value;
                    ChangedItems.Add(nameof(T4));
                    OnPropertyChanged(nameof(T4));
                }
            }

            public const int lastSortIndex = 250;

            public static ObservableMhwStructCollection<Sharpness_HZV_Threshold> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Sharpness_HZV_Threshold>();
                var count = 4UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Sharpness_HZV_Threshold LoadData(BinaryReader reader, ulong i) {
                var data = new Sharpness_HZV_Threshold();
                data.Index = i;
                data.T1_raw = reader.ReadSingle();
                data.T2_raw = reader.ReadSingle();
                data.T3_raw = reader.ReadSingle();
                data.T4_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(T1_raw);
                writer.Write(T2_raw);
                writer.Write(T3_raw);
                writer.Write(T4_raw);
            }
        }

        public partial class Monster_Common_Params_3_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Monster Common Params (3)";

            protected float Unk_30_raw;
            public const string Unk_30_displayName = "Unk 30";
            public const int Unk_30_sortIndex = 50;
            [SortOrder(Unk_30_sortIndex)]
            [DisplayName(Unk_30_displayName)]
            public virtual float Unk_30 {
                get => Unk_30_raw;
                set {
                    if (Unk_30_raw == value) return;
                    Unk_30_raw = value;
                    ChangedItems.Add(nameof(Unk_30));
                    OnPropertyChanged(nameof(Unk_30));
                }
            }

            protected float Unk_31_raw;
            public const string Unk_31_displayName = "Unk 31";
            public const int Unk_31_sortIndex = 100;
            [SortOrder(Unk_31_sortIndex)]
            [DisplayName(Unk_31_displayName)]
            public virtual float Unk_31 {
                get => Unk_31_raw;
                set {
                    if (Unk_31_raw == value) return;
                    Unk_31_raw = value;
                    ChangedItems.Add(nameof(Unk_31));
                    OnPropertyChanged(nameof(Unk_31));
                }
            }

            protected float Unk_32_raw;
            public const string Unk_32_displayName = "Unk 32";
            public const int Unk_32_sortIndex = 150;
            [SortOrder(Unk_32_sortIndex)]
            [DisplayName(Unk_32_displayName)]
            public virtual float Unk_32 {
                get => Unk_32_raw;
                set {
                    if (Unk_32_raw == value) return;
                    Unk_32_raw = value;
                    ChangedItems.Add(nameof(Unk_32));
                    OnPropertyChanged(nameof(Unk_32));
                }
            }

            protected float Unk_33_raw;
            public const string Unk_33_displayName = "Unk 33";
            public const int Unk_33_sortIndex = 200;
            [SortOrder(Unk_33_sortIndex)]
            [DisplayName(Unk_33_displayName)]
            public virtual float Unk_33 {
                get => Unk_33_raw;
                set {
                    if (Unk_33_raw == value) return;
                    Unk_33_raw = value;
                    ChangedItems.Add(nameof(Unk_33));
                    OnPropertyChanged(nameof(Unk_33));
                }
            }

            protected float Unk_34_raw;
            public const string Unk_34_displayName = "Unk 34";
            public const int Unk_34_sortIndex = 250;
            [SortOrder(Unk_34_sortIndex)]
            [DisplayName(Unk_34_displayName)]
            public virtual float Unk_34 {
                get => Unk_34_raw;
                set {
                    if (Unk_34_raw == value) return;
                    Unk_34_raw = value;
                    ChangedItems.Add(nameof(Unk_34));
                    OnPropertyChanged(nameof(Unk_34));
                }
            }

            protected float Unk_35_raw;
            public const string Unk_35_displayName = "Unk 35";
            public const int Unk_35_sortIndex = 300;
            [SortOrder(Unk_35_sortIndex)]
            [DisplayName(Unk_35_displayName)]
            public virtual float Unk_35 {
                get => Unk_35_raw;
                set {
                    if (Unk_35_raw == value) return;
                    Unk_35_raw = value;
                    ChangedItems.Add(nameof(Unk_35));
                    OnPropertyChanged(nameof(Unk_35));
                }
            }

            protected float Unk_36_raw;
            public const string Unk_36_displayName = "Unk 36";
            public const int Unk_36_sortIndex = 350;
            [SortOrder(Unk_36_sortIndex)]
            [DisplayName(Unk_36_displayName)]
            public virtual float Unk_36 {
                get => Unk_36_raw;
                set {
                    if (Unk_36_raw == value) return;
                    Unk_36_raw = value;
                    ChangedItems.Add(nameof(Unk_36));
                    OnPropertyChanged(nameof(Unk_36));
                }
            }

            protected float Unk_37_raw;
            public const string Unk_37_displayName = "Unk 37";
            public const int Unk_37_sortIndex = 400;
            [SortOrder(Unk_37_sortIndex)]
            [DisplayName(Unk_37_displayName)]
            public virtual float Unk_37 {
                get => Unk_37_raw;
                set {
                    if (Unk_37_raw == value) return;
                    Unk_37_raw = value;
                    ChangedItems.Add(nameof(Unk_37));
                    OnPropertyChanged(nameof(Unk_37));
                }
            }

            protected float Unk_38_raw;
            public const string Unk_38_displayName = "Unk 38";
            public const int Unk_38_sortIndex = 450;
            [SortOrder(Unk_38_sortIndex)]
            [DisplayName(Unk_38_displayName)]
            public virtual float Unk_38 {
                get => Unk_38_raw;
                set {
                    if (Unk_38_raw == value) return;
                    Unk_38_raw = value;
                    ChangedItems.Add(nameof(Unk_38));
                    OnPropertyChanged(nameof(Unk_38));
                }
            }

            protected float Unk_39_raw;
            public const string Unk_39_displayName = "Unk 39";
            public const int Unk_39_sortIndex = 500;
            [SortOrder(Unk_39_sortIndex)]
            [DisplayName(Unk_39_displayName)]
            public virtual float Unk_39 {
                get => Unk_39_raw;
                set {
                    if (Unk_39_raw == value) return;
                    Unk_39_raw = value;
                    ChangedItems.Add(nameof(Unk_39));
                    OnPropertyChanged(nameof(Unk_39));
                }
            }

            protected float Unk_40_raw;
            public const string Unk_40_displayName = "Unk 40";
            public const int Unk_40_sortIndex = 550;
            [SortOrder(Unk_40_sortIndex)]
            [DisplayName(Unk_40_displayName)]
            public virtual float Unk_40 {
                get => Unk_40_raw;
                set {
                    if (Unk_40_raw == value) return;
                    Unk_40_raw = value;
                    ChangedItems.Add(nameof(Unk_40));
                    OnPropertyChanged(nameof(Unk_40));
                }
            }

            protected float Unk_41_raw;
            public const string Unk_41_displayName = "Unk 41";
            public const int Unk_41_sortIndex = 600;
            [SortOrder(Unk_41_sortIndex)]
            [DisplayName(Unk_41_displayName)]
            public virtual float Unk_41 {
                get => Unk_41_raw;
                set {
                    if (Unk_41_raw == value) return;
                    Unk_41_raw = value;
                    ChangedItems.Add(nameof(Unk_41));
                    OnPropertyChanged(nameof(Unk_41));
                }
            }

            protected float Unk_42_raw;
            public const string Unk_42_displayName = "Unk 42";
            public const int Unk_42_sortIndex = 650;
            [SortOrder(Unk_42_sortIndex)]
            [DisplayName(Unk_42_displayName)]
            public virtual float Unk_42 {
                get => Unk_42_raw;
                set {
                    if (Unk_42_raw == value) return;
                    Unk_42_raw = value;
                    ChangedItems.Add(nameof(Unk_42));
                    OnPropertyChanged(nameof(Unk_42));
                }
            }

            protected float Unk_43_raw;
            public const string Unk_43_displayName = "Unk 43";
            public const int Unk_43_sortIndex = 700;
            [SortOrder(Unk_43_sortIndex)]
            [DisplayName(Unk_43_displayName)]
            public virtual float Unk_43 {
                get => Unk_43_raw;
                set {
                    if (Unk_43_raw == value) return;
                    Unk_43_raw = value;
                    ChangedItems.Add(nameof(Unk_43));
                    OnPropertyChanged(nameof(Unk_43));
                }
            }

            protected float Unk_44_raw;
            public const string Unk_44_displayName = "Unk 44";
            public const int Unk_44_sortIndex = 750;
            [SortOrder(Unk_44_sortIndex)]
            [DisplayName(Unk_44_displayName)]
            public virtual float Unk_44 {
                get => Unk_44_raw;
                set {
                    if (Unk_44_raw == value) return;
                    Unk_44_raw = value;
                    ChangedItems.Add(nameof(Unk_44));
                    OnPropertyChanged(nameof(Unk_44));
                }
            }

            protected float Unk_45_raw;
            public const string Unk_45_displayName = "Unk 45";
            public const int Unk_45_sortIndex = 800;
            [SortOrder(Unk_45_sortIndex)]
            [DisplayName(Unk_45_displayName)]
            public virtual float Unk_45 {
                get => Unk_45_raw;
                set {
                    if (Unk_45_raw == value) return;
                    Unk_45_raw = value;
                    ChangedItems.Add(nameof(Unk_45));
                    OnPropertyChanged(nameof(Unk_45));
                }
            }

            protected float Unk_46_raw;
            public const string Unk_46_displayName = "Unk 46";
            public const int Unk_46_sortIndex = 850;
            [SortOrder(Unk_46_sortIndex)]
            [DisplayName(Unk_46_displayName)]
            public virtual float Unk_46 {
                get => Unk_46_raw;
                set {
                    if (Unk_46_raw == value) return;
                    Unk_46_raw = value;
                    ChangedItems.Add(nameof(Unk_46));
                    OnPropertyChanged(nameof(Unk_46));
                }
            }

            protected float Unk_47_raw;
            public const string Unk_47_displayName = "Unk 47";
            public const int Unk_47_sortIndex = 900;
            [SortOrder(Unk_47_sortIndex)]
            [DisplayName(Unk_47_displayName)]
            public virtual float Unk_47 {
                get => Unk_47_raw;
                set {
                    if (Unk_47_raw == value) return;
                    Unk_47_raw = value;
                    ChangedItems.Add(nameof(Unk_47));
                    OnPropertyChanged(nameof(Unk_47));
                }
            }

            protected float Unk_48_raw;
            public const string Unk_48_displayName = "Unk 48";
            public const int Unk_48_sortIndex = 950;
            [SortOrder(Unk_48_sortIndex)]
            [DisplayName(Unk_48_displayName)]
            public virtual float Unk_48 {
                get => Unk_48_raw;
                set {
                    if (Unk_48_raw == value) return;
                    Unk_48_raw = value;
                    ChangedItems.Add(nameof(Unk_48));
                    OnPropertyChanged(nameof(Unk_48));
                }
            }

            protected float Unk_49_raw;
            public const string Unk_49_displayName = "Unk 49";
            public const int Unk_49_sortIndex = 1000;
            [SortOrder(Unk_49_sortIndex)]
            [DisplayName(Unk_49_displayName)]
            public virtual float Unk_49 {
                get => Unk_49_raw;
                set {
                    if (Unk_49_raw == value) return;
                    Unk_49_raw = value;
                    ChangedItems.Add(nameof(Unk_49));
                    OnPropertyChanged(nameof(Unk_49));
                }
            }

            protected float Unk_50_raw;
            public const string Unk_50_displayName = "Unk 50";
            public const int Unk_50_sortIndex = 1050;
            [SortOrder(Unk_50_sortIndex)]
            [DisplayName(Unk_50_displayName)]
            public virtual float Unk_50 {
                get => Unk_50_raw;
                set {
                    if (Unk_50_raw == value) return;
                    Unk_50_raw = value;
                    ChangedItems.Add(nameof(Unk_50));
                    OnPropertyChanged(nameof(Unk_50));
                }
            }

            protected float Unk_51_raw;
            public const string Unk_51_displayName = "Unk 51";
            public const int Unk_51_sortIndex = 1100;
            [SortOrder(Unk_51_sortIndex)]
            [DisplayName(Unk_51_displayName)]
            public virtual float Unk_51 {
                get => Unk_51_raw;
                set {
                    if (Unk_51_raw == value) return;
                    Unk_51_raw = value;
                    ChangedItems.Add(nameof(Unk_51));
                    OnPropertyChanged(nameof(Unk_51));
                }
            }

            protected float Unk_52_raw;
            public const string Unk_52_displayName = "Unk 52";
            public const int Unk_52_sortIndex = 1150;
            [SortOrder(Unk_52_sortIndex)]
            [DisplayName(Unk_52_displayName)]
            public virtual float Unk_52 {
                get => Unk_52_raw;
                set {
                    if (Unk_52_raw == value) return;
                    Unk_52_raw = value;
                    ChangedItems.Add(nameof(Unk_52));
                    OnPropertyChanged(nameof(Unk_52));
                }
            }

            protected float Unk_53_raw;
            public const string Unk_53_displayName = "Unk 53";
            public const int Unk_53_sortIndex = 1200;
            [SortOrder(Unk_53_sortIndex)]
            [DisplayName(Unk_53_displayName)]
            public virtual float Unk_53 {
                get => Unk_53_raw;
                set {
                    if (Unk_53_raw == value) return;
                    Unk_53_raw = value;
                    ChangedItems.Add(nameof(Unk_53));
                    OnPropertyChanged(nameof(Unk_53));
                }
            }

            protected float Unk_54_raw;
            public const string Unk_54_displayName = "Unk 54";
            public const int Unk_54_sortIndex = 1250;
            [SortOrder(Unk_54_sortIndex)]
            [DisplayName(Unk_54_displayName)]
            public virtual float Unk_54 {
                get => Unk_54_raw;
                set {
                    if (Unk_54_raw == value) return;
                    Unk_54_raw = value;
                    ChangedItems.Add(nameof(Unk_54));
                    OnPropertyChanged(nameof(Unk_54));
                }
            }

            protected float Unk_55_raw;
            public const string Unk_55_displayName = "Unk 55";
            public const int Unk_55_sortIndex = 1300;
            [SortOrder(Unk_55_sortIndex)]
            [DisplayName(Unk_55_displayName)]
            public virtual float Unk_55 {
                get => Unk_55_raw;
                set {
                    if (Unk_55_raw == value) return;
                    Unk_55_raw = value;
                    ChangedItems.Add(nameof(Unk_55));
                    OnPropertyChanged(nameof(Unk_55));
                }
            }

            protected float Unk_56_raw;
            public const string Unk_56_displayName = "Unk 56";
            public const int Unk_56_sortIndex = 1350;
            [SortOrder(Unk_56_sortIndex)]
            [DisplayName(Unk_56_displayName)]
            public virtual float Unk_56 {
                get => Unk_56_raw;
                set {
                    if (Unk_56_raw == value) return;
                    Unk_56_raw = value;
                    ChangedItems.Add(nameof(Unk_56));
                    OnPropertyChanged(nameof(Unk_56));
                }
            }

            protected float Unk_57_raw;
            public const string Unk_57_displayName = "Unk 57";
            public const int Unk_57_sortIndex = 1400;
            [SortOrder(Unk_57_sortIndex)]
            [DisplayName(Unk_57_displayName)]
            public virtual float Unk_57 {
                get => Unk_57_raw;
                set {
                    if (Unk_57_raw == value) return;
                    Unk_57_raw = value;
                    ChangedItems.Add(nameof(Unk_57));
                    OnPropertyChanged(nameof(Unk_57));
                }
            }

            protected float Unk_58_raw;
            public const string Unk_58_displayName = "Unk 58";
            public const int Unk_58_sortIndex = 1450;
            [SortOrder(Unk_58_sortIndex)]
            [DisplayName(Unk_58_displayName)]
            public virtual float Unk_58 {
                get => Unk_58_raw;
                set {
                    if (Unk_58_raw == value) return;
                    Unk_58_raw = value;
                    ChangedItems.Add(nameof(Unk_58));
                    OnPropertyChanged(nameof(Unk_58));
                }
            }

            protected float Unk_59_raw;
            public const string Unk_59_displayName = "Unk 59";
            public const int Unk_59_sortIndex = 1500;
            [SortOrder(Unk_59_sortIndex)]
            [DisplayName(Unk_59_displayName)]
            public virtual float Unk_59 {
                get => Unk_59_raw;
                set {
                    if (Unk_59_raw == value) return;
                    Unk_59_raw = value;
                    ChangedItems.Add(nameof(Unk_59));
                    OnPropertyChanged(nameof(Unk_59));
                }
            }

            protected float Unk_60_raw;
            public const string Unk_60_displayName = "Unk 60";
            public const int Unk_60_sortIndex = 1550;
            [SortOrder(Unk_60_sortIndex)]
            [DisplayName(Unk_60_displayName)]
            public virtual float Unk_60 {
                get => Unk_60_raw;
                set {
                    if (Unk_60_raw == value) return;
                    Unk_60_raw = value;
                    ChangedItems.Add(nameof(Unk_60));
                    OnPropertyChanged(nameof(Unk_60));
                }
            }

            protected float Unk_61_raw;
            public const string Unk_61_displayName = "Unk 61";
            public const int Unk_61_sortIndex = 1600;
            [SortOrder(Unk_61_sortIndex)]
            [DisplayName(Unk_61_displayName)]
            public virtual float Unk_61 {
                get => Unk_61_raw;
                set {
                    if (Unk_61_raw == value) return;
                    Unk_61_raw = value;
                    ChangedItems.Add(nameof(Unk_61));
                    OnPropertyChanged(nameof(Unk_61));
                }
            }

            protected float Unk_62_raw;
            public const string Unk_62_displayName = "Unk 62";
            public const int Unk_62_sortIndex = 1650;
            [SortOrder(Unk_62_sortIndex)]
            [DisplayName(Unk_62_displayName)]
            public virtual float Unk_62 {
                get => Unk_62_raw;
                set {
                    if (Unk_62_raw == value) return;
                    Unk_62_raw = value;
                    ChangedItems.Add(nameof(Unk_62));
                    OnPropertyChanged(nameof(Unk_62));
                }
            }

            protected float Unk_63_raw;
            public const string Unk_63_displayName = "Unk 63";
            public const int Unk_63_sortIndex = 1700;
            [SortOrder(Unk_63_sortIndex)]
            [DisplayName(Unk_63_displayName)]
            public virtual float Unk_63 {
                get => Unk_63_raw;
                set {
                    if (Unk_63_raw == value) return;
                    Unk_63_raw = value;
                    ChangedItems.Add(nameof(Unk_63));
                    OnPropertyChanged(nameof(Unk_63));
                }
            }

            protected float Unk_64_raw;
            public const string Unk_64_displayName = "Unk 64";
            public const int Unk_64_sortIndex = 1750;
            [SortOrder(Unk_64_sortIndex)]
            [DisplayName(Unk_64_displayName)]
            public virtual float Unk_64 {
                get => Unk_64_raw;
                set {
                    if (Unk_64_raw == value) return;
                    Unk_64_raw = value;
                    ChangedItems.Add(nameof(Unk_64));
                    OnPropertyChanged(nameof(Unk_64));
                }
            }

            protected float Unk_65_raw;
            public const string Unk_65_displayName = "Unk 65";
            public const int Unk_65_sortIndex = 1800;
            [SortOrder(Unk_65_sortIndex)]
            [DisplayName(Unk_65_displayName)]
            public virtual float Unk_65 {
                get => Unk_65_raw;
                set {
                    if (Unk_65_raw == value) return;
                    Unk_65_raw = value;
                    ChangedItems.Add(nameof(Unk_65));
                    OnPropertyChanged(nameof(Unk_65));
                }
            }

            protected float Unk_66_raw;
            public const string Unk_66_displayName = "Unk 66";
            public const int Unk_66_sortIndex = 1850;
            [SortOrder(Unk_66_sortIndex)]
            [DisplayName(Unk_66_displayName)]
            public virtual float Unk_66 {
                get => Unk_66_raw;
                set {
                    if (Unk_66_raw == value) return;
                    Unk_66_raw = value;
                    ChangedItems.Add(nameof(Unk_66));
                    OnPropertyChanged(nameof(Unk_66));
                }
            }

            protected float Unk_67_raw;
            public const string Unk_67_displayName = "Unk 67";
            public const int Unk_67_sortIndex = 1900;
            [SortOrder(Unk_67_sortIndex)]
            [DisplayName(Unk_67_displayName)]
            public virtual float Unk_67 {
                get => Unk_67_raw;
                set {
                    if (Unk_67_raw == value) return;
                    Unk_67_raw = value;
                    ChangedItems.Add(nameof(Unk_67));
                    OnPropertyChanged(nameof(Unk_67));
                }
            }

            protected uint Unk_68_raw;
            public const string Unk_68_displayName = "Unk 68";
            public const int Unk_68_sortIndex = 1950;
            [SortOrder(Unk_68_sortIndex)]
            [DisplayName(Unk_68_displayName)]
            public virtual uint Unk_68 {
                get => Unk_68_raw;
                set {
                    if (Unk_68_raw == value) return;
                    Unk_68_raw = value;
                    ChangedItems.Add(nameof(Unk_68));
                    OnPropertyChanged(nameof(Unk_68));
                }
            }

            protected float Unk_69_raw;
            public const string Unk_69_displayName = "Unk 69";
            public const int Unk_69_sortIndex = 2000;
            [SortOrder(Unk_69_sortIndex)]
            [DisplayName(Unk_69_displayName)]
            public virtual float Unk_69 {
                get => Unk_69_raw;
                set {
                    if (Unk_69_raw == value) return;
                    Unk_69_raw = value;
                    ChangedItems.Add(nameof(Unk_69));
                    OnPropertyChanged(nameof(Unk_69));
                }
            }

            protected float Unk_70_raw;
            public const string Unk_70_displayName = "Unk 70";
            public const int Unk_70_sortIndex = 2050;
            [SortOrder(Unk_70_sortIndex)]
            [DisplayName(Unk_70_displayName)]
            public virtual float Unk_70 {
                get => Unk_70_raw;
                set {
                    if (Unk_70_raw == value) return;
                    Unk_70_raw = value;
                    ChangedItems.Add(nameof(Unk_70));
                    OnPropertyChanged(nameof(Unk_70));
                }
            }

            protected float Unk_71_raw;
            public const string Unk_71_displayName = "Unk 71";
            public const int Unk_71_sortIndex = 2100;
            [SortOrder(Unk_71_sortIndex)]
            [DisplayName(Unk_71_displayName)]
            public virtual float Unk_71 {
                get => Unk_71_raw;
                set {
                    if (Unk_71_raw == value) return;
                    Unk_71_raw = value;
                    ChangedItems.Add(nameof(Unk_71));
                    OnPropertyChanged(nameof(Unk_71));
                }
            }

            protected float Unk_72_raw;
            public const string Unk_72_displayName = "Unk 72";
            public const int Unk_72_sortIndex = 2150;
            [SortOrder(Unk_72_sortIndex)]
            [DisplayName(Unk_72_displayName)]
            public virtual float Unk_72 {
                get => Unk_72_raw;
                set {
                    if (Unk_72_raw == value) return;
                    Unk_72_raw = value;
                    ChangedItems.Add(nameof(Unk_72));
                    OnPropertyChanged(nameof(Unk_72));
                }
            }

            protected float Unk_73_raw;
            public const string Unk_73_displayName = "Unk 73";
            public const int Unk_73_sortIndex = 2200;
            [SortOrder(Unk_73_sortIndex)]
            [DisplayName(Unk_73_displayName)]
            public virtual float Unk_73 {
                get => Unk_73_raw;
                set {
                    if (Unk_73_raw == value) return;
                    Unk_73_raw = value;
                    ChangedItems.Add(nameof(Unk_73));
                    OnPropertyChanged(nameof(Unk_73));
                }
            }

            protected float Unk_74_raw;
            public const string Unk_74_displayName = "Unk 74";
            public const int Unk_74_sortIndex = 2250;
            [SortOrder(Unk_74_sortIndex)]
            [DisplayName(Unk_74_displayName)]
            public virtual float Unk_74 {
                get => Unk_74_raw;
                set {
                    if (Unk_74_raw == value) return;
                    Unk_74_raw = value;
                    ChangedItems.Add(nameof(Unk_74));
                    OnPropertyChanged(nameof(Unk_74));
                }
            }

            protected float Unk_75_raw;
            public const string Unk_75_displayName = "Unk 75";
            public const int Unk_75_sortIndex = 2300;
            [SortOrder(Unk_75_sortIndex)]
            [DisplayName(Unk_75_displayName)]
            public virtual float Unk_75 {
                get => Unk_75_raw;
                set {
                    if (Unk_75_raw == value) return;
                    Unk_75_raw = value;
                    ChangedItems.Add(nameof(Unk_75));
                    OnPropertyChanged(nameof(Unk_75));
                }
            }

            protected float Unk_76_raw;
            public const string Unk_76_displayName = "Unk 76";
            public const int Unk_76_sortIndex = 2350;
            [SortOrder(Unk_76_sortIndex)]
            [DisplayName(Unk_76_displayName)]
            public virtual float Unk_76 {
                get => Unk_76_raw;
                set {
                    if (Unk_76_raw == value) return;
                    Unk_76_raw = value;
                    ChangedItems.Add(nameof(Unk_76));
                    OnPropertyChanged(nameof(Unk_76));
                }
            }

            protected float Unk_77_raw;
            public const string Unk_77_displayName = "Unk 77";
            public const int Unk_77_sortIndex = 2400;
            [SortOrder(Unk_77_sortIndex)]
            [DisplayName(Unk_77_displayName)]
            public virtual float Unk_77 {
                get => Unk_77_raw;
                set {
                    if (Unk_77_raw == value) return;
                    Unk_77_raw = value;
                    ChangedItems.Add(nameof(Unk_77));
                    OnPropertyChanged(nameof(Unk_77));
                }
            }

            protected float Unk_78_raw;
            public const string Unk_78_displayName = "Unk 78";
            public const int Unk_78_sortIndex = 2450;
            [SortOrder(Unk_78_sortIndex)]
            [DisplayName(Unk_78_displayName)]
            public virtual float Unk_78 {
                get => Unk_78_raw;
                set {
                    if (Unk_78_raw == value) return;
                    Unk_78_raw = value;
                    ChangedItems.Add(nameof(Unk_78));
                    OnPropertyChanged(nameof(Unk_78));
                }
            }

            protected float Unk_79_raw;
            public const string Unk_79_displayName = "Unk 79";
            public const int Unk_79_sortIndex = 2500;
            [SortOrder(Unk_79_sortIndex)]
            [DisplayName(Unk_79_displayName)]
            public virtual float Unk_79 {
                get => Unk_79_raw;
                set {
                    if (Unk_79_raw == value) return;
                    Unk_79_raw = value;
                    ChangedItems.Add(nameof(Unk_79));
                    OnPropertyChanged(nameof(Unk_79));
                }
            }

            protected float Unk_80_raw;
            public const string Unk_80_displayName = "Unk 80";
            public const int Unk_80_sortIndex = 2550;
            [SortOrder(Unk_80_sortIndex)]
            [DisplayName(Unk_80_displayName)]
            public virtual float Unk_80 {
                get => Unk_80_raw;
                set {
                    if (Unk_80_raw == value) return;
                    Unk_80_raw = value;
                    ChangedItems.Add(nameof(Unk_80));
                    OnPropertyChanged(nameof(Unk_80));
                }
            }

            protected float Unk_81_raw;
            public const string Unk_81_displayName = "Unk 81";
            public const int Unk_81_sortIndex = 2600;
            [SortOrder(Unk_81_sortIndex)]
            [DisplayName(Unk_81_displayName)]
            public virtual float Unk_81 {
                get => Unk_81_raw;
                set {
                    if (Unk_81_raw == value) return;
                    Unk_81_raw = value;
                    ChangedItems.Add(nameof(Unk_81));
                    OnPropertyChanged(nameof(Unk_81));
                }
            }

            protected float Unk_82_raw;
            public const string Unk_82_displayName = "Unk 82";
            public const int Unk_82_sortIndex = 2650;
            [SortOrder(Unk_82_sortIndex)]
            [DisplayName(Unk_82_displayName)]
            public virtual float Unk_82 {
                get => Unk_82_raw;
                set {
                    if (Unk_82_raw == value) return;
                    Unk_82_raw = value;
                    ChangedItems.Add(nameof(Unk_82));
                    OnPropertyChanged(nameof(Unk_82));
                }
            }

            protected float Unk_83_raw;
            public const string Unk_83_displayName = "Unk 83";
            public const int Unk_83_sortIndex = 2700;
            [SortOrder(Unk_83_sortIndex)]
            [DisplayName(Unk_83_displayName)]
            public virtual float Unk_83 {
                get => Unk_83_raw;
                set {
                    if (Unk_83_raw == value) return;
                    Unk_83_raw = value;
                    ChangedItems.Add(nameof(Unk_83));
                    OnPropertyChanged(nameof(Unk_83));
                }
            }

            protected float Unk_84_raw;
            public const string Unk_84_displayName = "Unk 84";
            public const int Unk_84_sortIndex = 2750;
            [SortOrder(Unk_84_sortIndex)]
            [DisplayName(Unk_84_displayName)]
            public virtual float Unk_84 {
                get => Unk_84_raw;
                set {
                    if (Unk_84_raw == value) return;
                    Unk_84_raw = value;
                    ChangedItems.Add(nameof(Unk_84));
                    OnPropertyChanged(nameof(Unk_84));
                }
            }

            public const int lastSortIndex = 2800;

            public static ObservableMhwStructCollection<Monster_Common_Params_3_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Monster_Common_Params_3_>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Monster_Common_Params_3_ LoadData(BinaryReader reader, ulong i) {
                var data = new Monster_Common_Params_3_();
                data.Index = i;
                data.Unk_30_raw = reader.ReadSingle();
                data.Unk_31_raw = reader.ReadSingle();
                data.Unk_32_raw = reader.ReadSingle();
                data.Unk_33_raw = reader.ReadSingle();
                data.Unk_34_raw = reader.ReadSingle();
                data.Unk_35_raw = reader.ReadSingle();
                data.Unk_36_raw = reader.ReadSingle();
                data.Unk_37_raw = reader.ReadSingle();
                data.Unk_38_raw = reader.ReadSingle();
                data.Unk_39_raw = reader.ReadSingle();
                data.Unk_40_raw = reader.ReadSingle();
                data.Unk_41_raw = reader.ReadSingle();
                data.Unk_42_raw = reader.ReadSingle();
                data.Unk_43_raw = reader.ReadSingle();
                data.Unk_44_raw = reader.ReadSingle();
                data.Unk_45_raw = reader.ReadSingle();
                data.Unk_46_raw = reader.ReadSingle();
                data.Unk_47_raw = reader.ReadSingle();
                data.Unk_48_raw = reader.ReadSingle();
                data.Unk_49_raw = reader.ReadSingle();
                data.Unk_50_raw = reader.ReadSingle();
                data.Unk_51_raw = reader.ReadSingle();
                data.Unk_52_raw = reader.ReadSingle();
                data.Unk_53_raw = reader.ReadSingle();
                data.Unk_54_raw = reader.ReadSingle();
                data.Unk_55_raw = reader.ReadSingle();
                data.Unk_56_raw = reader.ReadSingle();
                data.Unk_57_raw = reader.ReadSingle();
                data.Unk_58_raw = reader.ReadSingle();
                data.Unk_59_raw = reader.ReadSingle();
                data.Unk_60_raw = reader.ReadSingle();
                data.Unk_61_raw = reader.ReadSingle();
                data.Unk_62_raw = reader.ReadSingle();
                data.Unk_63_raw = reader.ReadSingle();
                data.Unk_64_raw = reader.ReadSingle();
                data.Unk_65_raw = reader.ReadSingle();
                data.Unk_66_raw = reader.ReadSingle();
                data.Unk_67_raw = reader.ReadSingle();
                data.Unk_68_raw = reader.ReadUInt32();
                data.Unk_69_raw = reader.ReadSingle();
                data.Unk_70_raw = reader.ReadSingle();
                data.Unk_71_raw = reader.ReadSingle();
                data.Unk_72_raw = reader.ReadSingle();
                data.Unk_73_raw = reader.ReadSingle();
                data.Unk_74_raw = reader.ReadSingle();
                data.Unk_75_raw = reader.ReadSingle();
                data.Unk_76_raw = reader.ReadSingle();
                data.Unk_77_raw = reader.ReadSingle();
                data.Unk_78_raw = reader.ReadSingle();
                data.Unk_79_raw = reader.ReadSingle();
                data.Unk_80_raw = reader.ReadSingle();
                data.Unk_81_raw = reader.ReadSingle();
                data.Unk_82_raw = reader.ReadSingle();
                data.Unk_83_raw = reader.ReadSingle();
                data.Unk_84_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_30_raw);
                writer.Write(Unk_31_raw);
                writer.Write(Unk_32_raw);
                writer.Write(Unk_33_raw);
                writer.Write(Unk_34_raw);
                writer.Write(Unk_35_raw);
                writer.Write(Unk_36_raw);
                writer.Write(Unk_37_raw);
                writer.Write(Unk_38_raw);
                writer.Write(Unk_39_raw);
                writer.Write(Unk_40_raw);
                writer.Write(Unk_41_raw);
                writer.Write(Unk_42_raw);
                writer.Write(Unk_43_raw);
                writer.Write(Unk_44_raw);
                writer.Write(Unk_45_raw);
                writer.Write(Unk_46_raw);
                writer.Write(Unk_47_raw);
                writer.Write(Unk_48_raw);
                writer.Write(Unk_49_raw);
                writer.Write(Unk_50_raw);
                writer.Write(Unk_51_raw);
                writer.Write(Unk_52_raw);
                writer.Write(Unk_53_raw);
                writer.Write(Unk_54_raw);
                writer.Write(Unk_55_raw);
                writer.Write(Unk_56_raw);
                writer.Write(Unk_57_raw);
                writer.Write(Unk_58_raw);
                writer.Write(Unk_59_raw);
                writer.Write(Unk_60_raw);
                writer.Write(Unk_61_raw);
                writer.Write(Unk_62_raw);
                writer.Write(Unk_63_raw);
                writer.Write(Unk_64_raw);
                writer.Write(Unk_65_raw);
                writer.Write(Unk_66_raw);
                writer.Write(Unk_67_raw);
                writer.Write(Unk_68_raw);
                writer.Write(Unk_69_raw);
                writer.Write(Unk_70_raw);
                writer.Write(Unk_71_raw);
                writer.Write(Unk_72_raw);
                writer.Write(Unk_73_raw);
                writer.Write(Unk_74_raw);
                writer.Write(Unk_75_raw);
                writer.Write(Unk_76_raw);
                writer.Write(Unk_77_raw);
                writer.Write(Unk_78_raw);
                writer.Write(Unk_79_raw);
                writer.Write(Unk_80_raw);
                writer.Write(Unk_81_raw);
                writer.Write(Unk_82_raw);
                writer.Write(Unk_83_raw);
                writer.Write(Unk_84_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Unk 30", "Unk_30"),
                    new MultiStructItemCustomView(this, "Unk 31", "Unk_31"),
                    new MultiStructItemCustomView(this, "Unk 32", "Unk_32"),
                    new MultiStructItemCustomView(this, "Unk 33", "Unk_33"),
                    new MultiStructItemCustomView(this, "Unk 34", "Unk_34"),
                    new MultiStructItemCustomView(this, "Unk 35", "Unk_35"),
                    new MultiStructItemCustomView(this, "Unk 36", "Unk_36"),
                    new MultiStructItemCustomView(this, "Unk 37", "Unk_37"),
                    new MultiStructItemCustomView(this, "Unk 38", "Unk_38"),
                    new MultiStructItemCustomView(this, "Unk 39", "Unk_39"),
                    new MultiStructItemCustomView(this, "Unk 40", "Unk_40"),
                    new MultiStructItemCustomView(this, "Unk 41", "Unk_41"),
                    new MultiStructItemCustomView(this, "Unk 42", "Unk_42"),
                    new MultiStructItemCustomView(this, "Unk 43", "Unk_43"),
                    new MultiStructItemCustomView(this, "Unk 44", "Unk_44"),
                    new MultiStructItemCustomView(this, "Unk 45", "Unk_45"),
                    new MultiStructItemCustomView(this, "Unk 46", "Unk_46"),
                    new MultiStructItemCustomView(this, "Unk 47", "Unk_47"),
                    new MultiStructItemCustomView(this, "Unk 48", "Unk_48"),
                    new MultiStructItemCustomView(this, "Unk 49", "Unk_49"),
                    new MultiStructItemCustomView(this, "Unk 50", "Unk_50"),
                    new MultiStructItemCustomView(this, "Unk 51", "Unk_51"),
                    new MultiStructItemCustomView(this, "Unk 52", "Unk_52"),
                    new MultiStructItemCustomView(this, "Unk 53", "Unk_53"),
                    new MultiStructItemCustomView(this, "Unk 54", "Unk_54"),
                    new MultiStructItemCustomView(this, "Unk 55", "Unk_55"),
                    new MultiStructItemCustomView(this, "Unk 56", "Unk_56"),
                    new MultiStructItemCustomView(this, "Unk 57", "Unk_57"),
                    new MultiStructItemCustomView(this, "Unk 58", "Unk_58"),
                    new MultiStructItemCustomView(this, "Unk 59", "Unk_59"),
                    new MultiStructItemCustomView(this, "Unk 60", "Unk_60"),
                    new MultiStructItemCustomView(this, "Unk 61", "Unk_61"),
                    new MultiStructItemCustomView(this, "Unk 62", "Unk_62"),
                    new MultiStructItemCustomView(this, "Unk 63", "Unk_63"),
                    new MultiStructItemCustomView(this, "Unk 64", "Unk_64"),
                    new MultiStructItemCustomView(this, "Unk 65", "Unk_65"),
                    new MultiStructItemCustomView(this, "Unk 66", "Unk_66"),
                    new MultiStructItemCustomView(this, "Unk 67", "Unk_67"),
                    new MultiStructItemCustomView(this, "Unk 68", "Unk_68"),
                    new MultiStructItemCustomView(this, "Unk 69", "Unk_69"),
                    new MultiStructItemCustomView(this, "Unk 70", "Unk_70"),
                    new MultiStructItemCustomView(this, "Unk 71", "Unk_71"),
                    new MultiStructItemCustomView(this, "Unk 72", "Unk_72"),
                    new MultiStructItemCustomView(this, "Unk 73", "Unk_73"),
                    new MultiStructItemCustomView(this, "Unk 74", "Unk_74"),
                    new MultiStructItemCustomView(this, "Unk 75", "Unk_75"),
                    new MultiStructItemCustomView(this, "Unk 76", "Unk_76"),
                    new MultiStructItemCustomView(this, "Unk 77", "Unk_77"),
                    new MultiStructItemCustomView(this, "Unk 78", "Unk_78"),
                    new MultiStructItemCustomView(this, "Unk 79", "Unk_79"),
                    new MultiStructItemCustomView(this, "Unk 80", "Unk_80"),
                    new MultiStructItemCustomView(this, "Unk 81", "Unk_81"),
                    new MultiStructItemCustomView(this, "Unk 82", "Unk_82"),
                    new MultiStructItemCustomView(this, "Unk 83", "Unk_83"),
                    new MultiStructItemCustomView(this, "Unk 84", "Unk_84"),
                };
            }
        }

        public partial class Unk_Arr_1 : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 4;
            public const string GridName = "Unk Arr 1";

            protected uint Unk_1_raw;
            public const string Unk_1_displayName = "Unk 1";
            public const int Unk_1_sortIndex = 50;
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

            protected uint Unk_2_raw;
            public const string Unk_2_displayName = "Unk 2";
            public const int Unk_2_sortIndex = 100;
            [SortOrder(Unk_2_sortIndex)]
            [DisplayName(Unk_2_displayName)]
            public virtual uint Unk_2 {
                get => Unk_2_raw;
                set {
                    if (Unk_2_raw == value) return;
                    Unk_2_raw = value;
                    ChangedItems.Add(nameof(Unk_2));
                    OnPropertyChanged(nameof(Unk_2));
                }
            }

            protected uint Unk_3_raw;
            public const string Unk_3_displayName = "Unk 3";
            public const int Unk_3_sortIndex = 150;
            [SortOrder(Unk_3_sortIndex)]
            [DisplayName(Unk_3_displayName)]
            public virtual uint Unk_3 {
                get => Unk_3_raw;
                set {
                    if (Unk_3_raw == value) return;
                    Unk_3_raw = value;
                    ChangedItems.Add(nameof(Unk_3));
                    OnPropertyChanged(nameof(Unk_3));
                }
            }

            protected uint Unk_4_raw;
            public const string Unk_4_displayName = "Unk 4";
            public const int Unk_4_sortIndex = 200;
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

            public const int lastSortIndex = 250;

            public static ObservableMhwStructCollection<Unk_Arr_1> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Unk_Arr_1>();
                var count = 4UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Unk_Arr_1 LoadData(BinaryReader reader, ulong i) {
                var data = new Unk_Arr_1();
                data.Index = i;
                data.Unk_1_raw = reader.ReadUInt32();
                data.Unk_2_raw = reader.ReadUInt32();
                data.Unk_3_raw = reader.ReadUInt32();
                data.Unk_4_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_1_raw);
                writer.Write(Unk_2_raw);
                writer.Write(Unk_3_raw);
                writer.Write(Unk_4_raw);
            }
        }

        public partial class Monster_Common_Params_4_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Monster Common Params (4)";

            protected float Unk_85_raw;
            public const string Unk_85_displayName = "Unk 85";
            public const int Unk_85_sortIndex = 50;
            [SortOrder(Unk_85_sortIndex)]
            [DisplayName(Unk_85_displayName)]
            public virtual float Unk_85 {
                get => Unk_85_raw;
                set {
                    if (Unk_85_raw == value) return;
                    Unk_85_raw = value;
                    ChangedItems.Add(nameof(Unk_85));
                    OnPropertyChanged(nameof(Unk_85));
                }
            }

            protected float Unk_86_raw;
            public const string Unk_86_displayName = "Unk 86";
            public const int Unk_86_sortIndex = 100;
            [SortOrder(Unk_86_sortIndex)]
            [DisplayName(Unk_86_displayName)]
            public virtual float Unk_86 {
                get => Unk_86_raw;
                set {
                    if (Unk_86_raw == value) return;
                    Unk_86_raw = value;
                    ChangedItems.Add(nameof(Unk_86));
                    OnPropertyChanged(nameof(Unk_86));
                }
            }

            protected float Unk_87_raw;
            public const string Unk_87_displayName = "Unk 87";
            public const int Unk_87_sortIndex = 150;
            [SortOrder(Unk_87_sortIndex)]
            [DisplayName(Unk_87_displayName)]
            public virtual float Unk_87 {
                get => Unk_87_raw;
                set {
                    if (Unk_87_raw == value) return;
                    Unk_87_raw = value;
                    ChangedItems.Add(nameof(Unk_87));
                    OnPropertyChanged(nameof(Unk_87));
                }
            }

            protected float Unk_88_raw;
            public const string Unk_88_displayName = "Unk 88";
            public const int Unk_88_sortIndex = 200;
            [SortOrder(Unk_88_sortIndex)]
            [DisplayName(Unk_88_displayName)]
            public virtual float Unk_88 {
                get => Unk_88_raw;
                set {
                    if (Unk_88_raw == value) return;
                    Unk_88_raw = value;
                    ChangedItems.Add(nameof(Unk_88));
                    OnPropertyChanged(nameof(Unk_88));
                }
            }

            protected float Unk_89_raw;
            public const string Unk_89_displayName = "Unk 89";
            public const int Unk_89_sortIndex = 250;
            [SortOrder(Unk_89_sortIndex)]
            [DisplayName(Unk_89_displayName)]
            public virtual float Unk_89 {
                get => Unk_89_raw;
                set {
                    if (Unk_89_raw == value) return;
                    Unk_89_raw = value;
                    ChangedItems.Add(nameof(Unk_89));
                    OnPropertyChanged(nameof(Unk_89));
                }
            }

            protected float Unk_90_raw;
            public const string Unk_90_displayName = "Unk 90";
            public const int Unk_90_sortIndex = 300;
            [SortOrder(Unk_90_sortIndex)]
            [DisplayName(Unk_90_displayName)]
            public virtual float Unk_90 {
                get => Unk_90_raw;
                set {
                    if (Unk_90_raw == value) return;
                    Unk_90_raw = value;
                    ChangedItems.Add(nameof(Unk_90));
                    OnPropertyChanged(nameof(Unk_90));
                }
            }

            protected float Unk_91_raw;
            public const string Unk_91_displayName = "Unk 91";
            public const int Unk_91_sortIndex = 350;
            [SortOrder(Unk_91_sortIndex)]
            [DisplayName(Unk_91_displayName)]
            public virtual float Unk_91 {
                get => Unk_91_raw;
                set {
                    if (Unk_91_raw == value) return;
                    Unk_91_raw = value;
                    ChangedItems.Add(nameof(Unk_91));
                    OnPropertyChanged(nameof(Unk_91));
                }
            }

            protected float Unk_92_raw;
            public const string Unk_92_displayName = "Unk 92";
            public const int Unk_92_sortIndex = 400;
            [SortOrder(Unk_92_sortIndex)]
            [DisplayName(Unk_92_displayName)]
            public virtual float Unk_92 {
                get => Unk_92_raw;
                set {
                    if (Unk_92_raw == value) return;
                    Unk_92_raw = value;
                    ChangedItems.Add(nameof(Unk_92));
                    OnPropertyChanged(nameof(Unk_92));
                }
            }

            protected float Unk_93_raw;
            public const string Unk_93_displayName = "Unk 93";
            public const int Unk_93_sortIndex = 450;
            [SortOrder(Unk_93_sortIndex)]
            [DisplayName(Unk_93_displayName)]
            public virtual float Unk_93 {
                get => Unk_93_raw;
                set {
                    if (Unk_93_raw == value) return;
                    Unk_93_raw = value;
                    ChangedItems.Add(nameof(Unk_93));
                    OnPropertyChanged(nameof(Unk_93));
                }
            }

            protected float Unk_94_raw;
            public const string Unk_94_displayName = "Unk 94";
            public const int Unk_94_sortIndex = 500;
            [SortOrder(Unk_94_sortIndex)]
            [DisplayName(Unk_94_displayName)]
            public virtual float Unk_94 {
                get => Unk_94_raw;
                set {
                    if (Unk_94_raw == value) return;
                    Unk_94_raw = value;
                    ChangedItems.Add(nameof(Unk_94));
                    OnPropertyChanged(nameof(Unk_94));
                }
            }

            protected float Unk_95_raw;
            public const string Unk_95_displayName = "Unk 95";
            public const int Unk_95_sortIndex = 550;
            [SortOrder(Unk_95_sortIndex)]
            [DisplayName(Unk_95_displayName)]
            public virtual float Unk_95 {
                get => Unk_95_raw;
                set {
                    if (Unk_95_raw == value) return;
                    Unk_95_raw = value;
                    ChangedItems.Add(nameof(Unk_95));
                    OnPropertyChanged(nameof(Unk_95));
                }
            }

            protected float Unk_96_raw;
            public const string Unk_96_displayName = "Unk 96";
            public const int Unk_96_sortIndex = 600;
            [SortOrder(Unk_96_sortIndex)]
            [DisplayName(Unk_96_displayName)]
            public virtual float Unk_96 {
                get => Unk_96_raw;
                set {
                    if (Unk_96_raw == value) return;
                    Unk_96_raw = value;
                    ChangedItems.Add(nameof(Unk_96));
                    OnPropertyChanged(nameof(Unk_96));
                }
            }

            protected float Unk_97_raw;
            public const string Unk_97_displayName = "Unk 97";
            public const int Unk_97_sortIndex = 650;
            [SortOrder(Unk_97_sortIndex)]
            [DisplayName(Unk_97_displayName)]
            public virtual float Unk_97 {
                get => Unk_97_raw;
                set {
                    if (Unk_97_raw == value) return;
                    Unk_97_raw = value;
                    ChangedItems.Add(nameof(Unk_97));
                    OnPropertyChanged(nameof(Unk_97));
                }
            }

            protected float Unk_98_raw;
            public const string Unk_98_displayName = "Unk 98";
            public const int Unk_98_sortIndex = 700;
            [SortOrder(Unk_98_sortIndex)]
            [DisplayName(Unk_98_displayName)]
            public virtual float Unk_98 {
                get => Unk_98_raw;
                set {
                    if (Unk_98_raw == value) return;
                    Unk_98_raw = value;
                    ChangedItems.Add(nameof(Unk_98));
                    OnPropertyChanged(nameof(Unk_98));
                }
            }

            protected float Unk_99_raw;
            public const string Unk_99_displayName = "Unk 99";
            public const int Unk_99_sortIndex = 750;
            [SortOrder(Unk_99_sortIndex)]
            [DisplayName(Unk_99_displayName)]
            public virtual float Unk_99 {
                get => Unk_99_raw;
                set {
                    if (Unk_99_raw == value) return;
                    Unk_99_raw = value;
                    ChangedItems.Add(nameof(Unk_99));
                    OnPropertyChanged(nameof(Unk_99));
                }
            }

            protected float Unk_100_raw;
            public const string Unk_100_displayName = "Unk 100";
            public const int Unk_100_sortIndex = 800;
            [SortOrder(Unk_100_sortIndex)]
            [DisplayName(Unk_100_displayName)]
            public virtual float Unk_100 {
                get => Unk_100_raw;
                set {
                    if (Unk_100_raw == value) return;
                    Unk_100_raw = value;
                    ChangedItems.Add(nameof(Unk_100));
                    OnPropertyChanged(nameof(Unk_100));
                }
            }

            protected float Unk_101_raw;
            public const string Unk_101_displayName = "Unk 101";
            public const int Unk_101_sortIndex = 850;
            [SortOrder(Unk_101_sortIndex)]
            [DisplayName(Unk_101_displayName)]
            public virtual float Unk_101 {
                get => Unk_101_raw;
                set {
                    if (Unk_101_raw == value) return;
                    Unk_101_raw = value;
                    ChangedItems.Add(nameof(Unk_101));
                    OnPropertyChanged(nameof(Unk_101));
                }
            }

            protected float Unk_102_raw;
            public const string Unk_102_displayName = "Unk 102";
            public const int Unk_102_sortIndex = 900;
            [SortOrder(Unk_102_sortIndex)]
            [DisplayName(Unk_102_displayName)]
            public virtual float Unk_102 {
                get => Unk_102_raw;
                set {
                    if (Unk_102_raw == value) return;
                    Unk_102_raw = value;
                    ChangedItems.Add(nameof(Unk_102));
                    OnPropertyChanged(nameof(Unk_102));
                }
            }

            protected float Unk_103_raw;
            public const string Unk_103_displayName = "Unk 103";
            public const int Unk_103_sortIndex = 950;
            [SortOrder(Unk_103_sortIndex)]
            [DisplayName(Unk_103_displayName)]
            public virtual float Unk_103 {
                get => Unk_103_raw;
                set {
                    if (Unk_103_raw == value) return;
                    Unk_103_raw = value;
                    ChangedItems.Add(nameof(Unk_103));
                    OnPropertyChanged(nameof(Unk_103));
                }
            }

            protected float Unk_104_raw;
            public const string Unk_104_displayName = "Unk 104";
            public const int Unk_104_sortIndex = 1000;
            [SortOrder(Unk_104_sortIndex)]
            [DisplayName(Unk_104_displayName)]
            public virtual float Unk_104 {
                get => Unk_104_raw;
                set {
                    if (Unk_104_raw == value) return;
                    Unk_104_raw = value;
                    ChangedItems.Add(nameof(Unk_104));
                    OnPropertyChanged(nameof(Unk_104));
                }
            }

            protected float Unk_105_raw;
            public const string Unk_105_displayName = "Unk 105";
            public const int Unk_105_sortIndex = 1050;
            [SortOrder(Unk_105_sortIndex)]
            [DisplayName(Unk_105_displayName)]
            public virtual float Unk_105 {
                get => Unk_105_raw;
                set {
                    if (Unk_105_raw == value) return;
                    Unk_105_raw = value;
                    ChangedItems.Add(nameof(Unk_105));
                    OnPropertyChanged(nameof(Unk_105));
                }
            }

            protected float Unk_106_raw;
            public const string Unk_106_displayName = "Unk 106";
            public const int Unk_106_sortIndex = 1100;
            [SortOrder(Unk_106_sortIndex)]
            [DisplayName(Unk_106_displayName)]
            public virtual float Unk_106 {
                get => Unk_106_raw;
                set {
                    if (Unk_106_raw == value) return;
                    Unk_106_raw = value;
                    ChangedItems.Add(nameof(Unk_106));
                    OnPropertyChanged(nameof(Unk_106));
                }
            }

            protected float Unk_107_raw;
            public const string Unk_107_displayName = "Unk 107";
            public const int Unk_107_sortIndex = 1150;
            [SortOrder(Unk_107_sortIndex)]
            [DisplayName(Unk_107_displayName)]
            public virtual float Unk_107 {
                get => Unk_107_raw;
                set {
                    if (Unk_107_raw == value) return;
                    Unk_107_raw = value;
                    ChangedItems.Add(nameof(Unk_107));
                    OnPropertyChanged(nameof(Unk_107));
                }
            }

            protected float Unk_108_raw;
            public const string Unk_108_displayName = "Unk 108";
            public const int Unk_108_sortIndex = 1200;
            [SortOrder(Unk_108_sortIndex)]
            [DisplayName(Unk_108_displayName)]
            public virtual float Unk_108 {
                get => Unk_108_raw;
                set {
                    if (Unk_108_raw == value) return;
                    Unk_108_raw = value;
                    ChangedItems.Add(nameof(Unk_108));
                    OnPropertyChanged(nameof(Unk_108));
                }
            }

            protected float Unk_109_raw;
            public const string Unk_109_displayName = "Unk 109";
            public const int Unk_109_sortIndex = 1250;
            [SortOrder(Unk_109_sortIndex)]
            [DisplayName(Unk_109_displayName)]
            public virtual float Unk_109 {
                get => Unk_109_raw;
                set {
                    if (Unk_109_raw == value) return;
                    Unk_109_raw = value;
                    ChangedItems.Add(nameof(Unk_109));
                    OnPropertyChanged(nameof(Unk_109));
                }
            }

            protected float Unk_110_raw;
            public const string Unk_110_displayName = "Unk 110";
            public const int Unk_110_sortIndex = 1300;
            [SortOrder(Unk_110_sortIndex)]
            [DisplayName(Unk_110_displayName)]
            public virtual float Unk_110 {
                get => Unk_110_raw;
                set {
                    if (Unk_110_raw == value) return;
                    Unk_110_raw = value;
                    ChangedItems.Add(nameof(Unk_110));
                    OnPropertyChanged(nameof(Unk_110));
                }
            }

            protected float Unk_111_raw;
            public const string Unk_111_displayName = "Unk 111";
            public const int Unk_111_sortIndex = 1350;
            [SortOrder(Unk_111_sortIndex)]
            [DisplayName(Unk_111_displayName)]
            public virtual float Unk_111 {
                get => Unk_111_raw;
                set {
                    if (Unk_111_raw == value) return;
                    Unk_111_raw = value;
                    ChangedItems.Add(nameof(Unk_111));
                    OnPropertyChanged(nameof(Unk_111));
                }
            }

            protected float Unk_112_raw;
            public const string Unk_112_displayName = "Unk 112";
            public const int Unk_112_sortIndex = 1400;
            [SortOrder(Unk_112_sortIndex)]
            [DisplayName(Unk_112_displayName)]
            public virtual float Unk_112 {
                get => Unk_112_raw;
                set {
                    if (Unk_112_raw == value) return;
                    Unk_112_raw = value;
                    ChangedItems.Add(nameof(Unk_112));
                    OnPropertyChanged(nameof(Unk_112));
                }
            }

            protected float Unk_113_raw;
            public const string Unk_113_displayName = "Unk 113";
            public const int Unk_113_sortIndex = 1450;
            [SortOrder(Unk_113_sortIndex)]
            [DisplayName(Unk_113_displayName)]
            public virtual float Unk_113 {
                get => Unk_113_raw;
                set {
                    if (Unk_113_raw == value) return;
                    Unk_113_raw = value;
                    ChangedItems.Add(nameof(Unk_113));
                    OnPropertyChanged(nameof(Unk_113));
                }
            }

            protected float Unk_114_raw;
            public const string Unk_114_displayName = "Unk 114";
            public const int Unk_114_sortIndex = 1500;
            [SortOrder(Unk_114_sortIndex)]
            [DisplayName(Unk_114_displayName)]
            public virtual float Unk_114 {
                get => Unk_114_raw;
                set {
                    if (Unk_114_raw == value) return;
                    Unk_114_raw = value;
                    ChangedItems.Add(nameof(Unk_114));
                    OnPropertyChanged(nameof(Unk_114));
                }
            }

            protected float Unk_115_raw;
            public const string Unk_115_displayName = "Unk 115";
            public const int Unk_115_sortIndex = 1550;
            [SortOrder(Unk_115_sortIndex)]
            [DisplayName(Unk_115_displayName)]
            public virtual float Unk_115 {
                get => Unk_115_raw;
                set {
                    if (Unk_115_raw == value) return;
                    Unk_115_raw = value;
                    ChangedItems.Add(nameof(Unk_115));
                    OnPropertyChanged(nameof(Unk_115));
                }
            }

            protected float Unk_116_raw;
            public const string Unk_116_displayName = "Unk 116";
            public const int Unk_116_sortIndex = 1600;
            [SortOrder(Unk_116_sortIndex)]
            [DisplayName(Unk_116_displayName)]
            public virtual float Unk_116 {
                get => Unk_116_raw;
                set {
                    if (Unk_116_raw == value) return;
                    Unk_116_raw = value;
                    ChangedItems.Add(nameof(Unk_116));
                    OnPropertyChanged(nameof(Unk_116));
                }
            }

            protected float Unk_117_raw;
            public const string Unk_117_displayName = "Unk 117";
            public const int Unk_117_sortIndex = 1650;
            [SortOrder(Unk_117_sortIndex)]
            [DisplayName(Unk_117_displayName)]
            public virtual float Unk_117 {
                get => Unk_117_raw;
                set {
                    if (Unk_117_raw == value) return;
                    Unk_117_raw = value;
                    ChangedItems.Add(nameof(Unk_117));
                    OnPropertyChanged(nameof(Unk_117));
                }
            }

            protected uint Unk_118_raw;
            public const string Unk_118_displayName = "Unk 118";
            public const int Unk_118_sortIndex = 1700;
            [SortOrder(Unk_118_sortIndex)]
            [DisplayName(Unk_118_displayName)]
            public virtual uint Unk_118 {
                get => Unk_118_raw;
                set {
                    if (Unk_118_raw == value) return;
                    Unk_118_raw = value;
                    ChangedItems.Add(nameof(Unk_118));
                    OnPropertyChanged(nameof(Unk_118));
                }
            }

            protected uint Unk_119_raw;
            public const string Unk_119_displayName = "Unk 119";
            public const int Unk_119_sortIndex = 1750;
            [SortOrder(Unk_119_sortIndex)]
            [DisplayName(Unk_119_displayName)]
            public virtual uint Unk_119 {
                get => Unk_119_raw;
                set {
                    if (Unk_119_raw == value) return;
                    Unk_119_raw = value;
                    ChangedItems.Add(nameof(Unk_119));
                    OnPropertyChanged(nameof(Unk_119));
                }
            }

            protected uint Unk_120_raw;
            public const string Unk_120_displayName = "Unk 120";
            public const int Unk_120_sortIndex = 1800;
            [SortOrder(Unk_120_sortIndex)]
            [DisplayName(Unk_120_displayName)]
            public virtual uint Unk_120 {
                get => Unk_120_raw;
                set {
                    if (Unk_120_raw == value) return;
                    Unk_120_raw = value;
                    ChangedItems.Add(nameof(Unk_120));
                    OnPropertyChanged(nameof(Unk_120));
                }
            }

            protected float Unk_121_raw;
            public const string Unk_121_displayName = "Unk 121";
            public const int Unk_121_sortIndex = 1850;
            [SortOrder(Unk_121_sortIndex)]
            [DisplayName(Unk_121_displayName)]
            public virtual float Unk_121 {
                get => Unk_121_raw;
                set {
                    if (Unk_121_raw == value) return;
                    Unk_121_raw = value;
                    ChangedItems.Add(nameof(Unk_121));
                    OnPropertyChanged(nameof(Unk_121));
                }
            }

            protected float Unk_122_raw;
            public const string Unk_122_displayName = "Unk 122";
            public const int Unk_122_sortIndex = 1900;
            [SortOrder(Unk_122_sortIndex)]
            [DisplayName(Unk_122_displayName)]
            public virtual float Unk_122 {
                get => Unk_122_raw;
                set {
                    if (Unk_122_raw == value) return;
                    Unk_122_raw = value;
                    ChangedItems.Add(nameof(Unk_122));
                    OnPropertyChanged(nameof(Unk_122));
                }
            }

            protected float Unk_123_raw;
            public const string Unk_123_displayName = "Unk 123";
            public const int Unk_123_sortIndex = 1950;
            [SortOrder(Unk_123_sortIndex)]
            [DisplayName(Unk_123_displayName)]
            public virtual float Unk_123 {
                get => Unk_123_raw;
                set {
                    if (Unk_123_raw == value) return;
                    Unk_123_raw = value;
                    ChangedItems.Add(nameof(Unk_123));
                    OnPropertyChanged(nameof(Unk_123));
                }
            }

            protected float Unk_124_raw;
            public const string Unk_124_displayName = "Unk 124";
            public const int Unk_124_sortIndex = 2000;
            [SortOrder(Unk_124_sortIndex)]
            [DisplayName(Unk_124_displayName)]
            public virtual float Unk_124 {
                get => Unk_124_raw;
                set {
                    if (Unk_124_raw == value) return;
                    Unk_124_raw = value;
                    ChangedItems.Add(nameof(Unk_124));
                    OnPropertyChanged(nameof(Unk_124));
                }
            }

            protected float Unk_125_raw;
            public const string Unk_125_displayName = "Unk 125";
            public const int Unk_125_sortIndex = 2050;
            [SortOrder(Unk_125_sortIndex)]
            [DisplayName(Unk_125_displayName)]
            public virtual float Unk_125 {
                get => Unk_125_raw;
                set {
                    if (Unk_125_raw == value) return;
                    Unk_125_raw = value;
                    ChangedItems.Add(nameof(Unk_125));
                    OnPropertyChanged(nameof(Unk_125));
                }
            }

            protected float Unk_126_raw;
            public const string Unk_126_displayName = "Unk 126";
            public const int Unk_126_sortIndex = 2100;
            [SortOrder(Unk_126_sortIndex)]
            [DisplayName(Unk_126_displayName)]
            public virtual float Unk_126 {
                get => Unk_126_raw;
                set {
                    if (Unk_126_raw == value) return;
                    Unk_126_raw = value;
                    ChangedItems.Add(nameof(Unk_126));
                    OnPropertyChanged(nameof(Unk_126));
                }
            }

            protected float Unk_127_raw;
            public const string Unk_127_displayName = "Unk 127";
            public const int Unk_127_sortIndex = 2150;
            [SortOrder(Unk_127_sortIndex)]
            [DisplayName(Unk_127_displayName)]
            public virtual float Unk_127 {
                get => Unk_127_raw;
                set {
                    if (Unk_127_raw == value) return;
                    Unk_127_raw = value;
                    ChangedItems.Add(nameof(Unk_127));
                    OnPropertyChanged(nameof(Unk_127));
                }
            }

            protected float Unk_128_raw;
            public const string Unk_128_displayName = "Unk 128";
            public const int Unk_128_sortIndex = 2200;
            [SortOrder(Unk_128_sortIndex)]
            [DisplayName(Unk_128_displayName)]
            public virtual float Unk_128 {
                get => Unk_128_raw;
                set {
                    if (Unk_128_raw == value) return;
                    Unk_128_raw = value;
                    ChangedItems.Add(nameof(Unk_128));
                    OnPropertyChanged(nameof(Unk_128));
                }
            }

            protected float Unk_129_raw;
            public const string Unk_129_displayName = "Unk 129";
            public const int Unk_129_sortIndex = 2250;
            [SortOrder(Unk_129_sortIndex)]
            [DisplayName(Unk_129_displayName)]
            public virtual float Unk_129 {
                get => Unk_129_raw;
                set {
                    if (Unk_129_raw == value) return;
                    Unk_129_raw = value;
                    ChangedItems.Add(nameof(Unk_129));
                    OnPropertyChanged(nameof(Unk_129));
                }
            }

            protected float Unk_130_raw;
            public const string Unk_130_displayName = "Unk 130";
            public const int Unk_130_sortIndex = 2300;
            [SortOrder(Unk_130_sortIndex)]
            [DisplayName(Unk_130_displayName)]
            public virtual float Unk_130 {
                get => Unk_130_raw;
                set {
                    if (Unk_130_raw == value) return;
                    Unk_130_raw = value;
                    ChangedItems.Add(nameof(Unk_130));
                    OnPropertyChanged(nameof(Unk_130));
                }
            }

            protected float Unk_131_raw;
            public const string Unk_131_displayName = "Unk 131";
            public const int Unk_131_sortIndex = 2350;
            [SortOrder(Unk_131_sortIndex)]
            [DisplayName(Unk_131_displayName)]
            public virtual float Unk_131 {
                get => Unk_131_raw;
                set {
                    if (Unk_131_raw == value) return;
                    Unk_131_raw = value;
                    ChangedItems.Add(nameof(Unk_131));
                    OnPropertyChanged(nameof(Unk_131));
                }
            }

            protected uint Unk_132_raw;
            public const string Unk_132_displayName = "Unk 132";
            public const int Unk_132_sortIndex = 2400;
            [SortOrder(Unk_132_sortIndex)]
            [DisplayName(Unk_132_displayName)]
            public virtual uint Unk_132 {
                get => Unk_132_raw;
                set {
                    if (Unk_132_raw == value) return;
                    Unk_132_raw = value;
                    ChangedItems.Add(nameof(Unk_132));
                    OnPropertyChanged(nameof(Unk_132));
                }
            }

            protected uint Unk_133_raw;
            public const string Unk_133_displayName = "Unk 133";
            public const int Unk_133_sortIndex = 2450;
            [SortOrder(Unk_133_sortIndex)]
            [DisplayName(Unk_133_displayName)]
            public virtual uint Unk_133 {
                get => Unk_133_raw;
                set {
                    if (Unk_133_raw == value) return;
                    Unk_133_raw = value;
                    ChangedItems.Add(nameof(Unk_133));
                    OnPropertyChanged(nameof(Unk_133));
                }
            }

            protected float Unk_134_raw;
            public const string Unk_134_displayName = "Unk 134";
            public const int Unk_134_sortIndex = 2500;
            [SortOrder(Unk_134_sortIndex)]
            [DisplayName(Unk_134_displayName)]
            public virtual float Unk_134 {
                get => Unk_134_raw;
                set {
                    if (Unk_134_raw == value) return;
                    Unk_134_raw = value;
                    ChangedItems.Add(nameof(Unk_134));
                    OnPropertyChanged(nameof(Unk_134));
                }
            }

            protected uint Unk_135_raw;
            public const string Unk_135_displayName = "Unk 135";
            public const int Unk_135_sortIndex = 2550;
            [SortOrder(Unk_135_sortIndex)]
            [DisplayName(Unk_135_displayName)]
            public virtual uint Unk_135 {
                get => Unk_135_raw;
                set {
                    if (Unk_135_raw == value) return;
                    Unk_135_raw = value;
                    ChangedItems.Add(nameof(Unk_135));
                    OnPropertyChanged(nameof(Unk_135));
                }
            }

            protected float Unk_136_raw;
            public const string Unk_136_displayName = "Unk 136";
            public const int Unk_136_sortIndex = 2600;
            [SortOrder(Unk_136_sortIndex)]
            [DisplayName(Unk_136_displayName)]
            public virtual float Unk_136 {
                get => Unk_136_raw;
                set {
                    if (Unk_136_raw == value) return;
                    Unk_136_raw = value;
                    ChangedItems.Add(nameof(Unk_136));
                    OnPropertyChanged(nameof(Unk_136));
                }
            }

            protected uint Unk_137_raw;
            public const string Unk_137_displayName = "Unk 137";
            public const int Unk_137_sortIndex = 2650;
            [SortOrder(Unk_137_sortIndex)]
            [DisplayName(Unk_137_displayName)]
            public virtual uint Unk_137 {
                get => Unk_137_raw;
                set {
                    if (Unk_137_raw == value) return;
                    Unk_137_raw = value;
                    ChangedItems.Add(nameof(Unk_137));
                    OnPropertyChanged(nameof(Unk_137));
                }
            }

            protected float Unk_138_raw;
            public const string Unk_138_displayName = "Unk 138";
            public const int Unk_138_sortIndex = 2700;
            [SortOrder(Unk_138_sortIndex)]
            [DisplayName(Unk_138_displayName)]
            public virtual float Unk_138 {
                get => Unk_138_raw;
                set {
                    if (Unk_138_raw == value) return;
                    Unk_138_raw = value;
                    ChangedItems.Add(nameof(Unk_138));
                    OnPropertyChanged(nameof(Unk_138));
                }
            }

            protected float Unk_139_raw;
            public const string Unk_139_displayName = "Unk 139";
            public const int Unk_139_sortIndex = 2750;
            [SortOrder(Unk_139_sortIndex)]
            [DisplayName(Unk_139_displayName)]
            public virtual float Unk_139 {
                get => Unk_139_raw;
                set {
                    if (Unk_139_raw == value) return;
                    Unk_139_raw = value;
                    ChangedItems.Add(nameof(Unk_139));
                    OnPropertyChanged(nameof(Unk_139));
                }
            }

            protected float Unk_140_raw;
            public const string Unk_140_displayName = "Unk 140";
            public const int Unk_140_sortIndex = 2800;
            [SortOrder(Unk_140_sortIndex)]
            [DisplayName(Unk_140_displayName)]
            public virtual float Unk_140 {
                get => Unk_140_raw;
                set {
                    if (Unk_140_raw == value) return;
                    Unk_140_raw = value;
                    ChangedItems.Add(nameof(Unk_140));
                    OnPropertyChanged(nameof(Unk_140));
                }
            }

            protected float Unk_141_raw;
            public const string Unk_141_displayName = "Unk 141";
            public const int Unk_141_sortIndex = 2850;
            [SortOrder(Unk_141_sortIndex)]
            [DisplayName(Unk_141_displayName)]
            public virtual float Unk_141 {
                get => Unk_141_raw;
                set {
                    if (Unk_141_raw == value) return;
                    Unk_141_raw = value;
                    ChangedItems.Add(nameof(Unk_141));
                    OnPropertyChanged(nameof(Unk_141));
                }
            }

            protected float Unk_142_raw;
            public const string Unk_142_displayName = "Unk 142";
            public const int Unk_142_sortIndex = 2900;
            [SortOrder(Unk_142_sortIndex)]
            [DisplayName(Unk_142_displayName)]
            public virtual float Unk_142 {
                get => Unk_142_raw;
                set {
                    if (Unk_142_raw == value) return;
                    Unk_142_raw = value;
                    ChangedItems.Add(nameof(Unk_142));
                    OnPropertyChanged(nameof(Unk_142));
                }
            }

            protected float Unk_143_raw;
            public const string Unk_143_displayName = "Unk 143";
            public const int Unk_143_sortIndex = 2950;
            [SortOrder(Unk_143_sortIndex)]
            [DisplayName(Unk_143_displayName)]
            public virtual float Unk_143 {
                get => Unk_143_raw;
                set {
                    if (Unk_143_raw == value) return;
                    Unk_143_raw = value;
                    ChangedItems.Add(nameof(Unk_143));
                    OnPropertyChanged(nameof(Unk_143));
                }
            }

            protected float Unk_144_raw;
            public const string Unk_144_displayName = "Unk 144";
            public const int Unk_144_sortIndex = 3000;
            [SortOrder(Unk_144_sortIndex)]
            [DisplayName(Unk_144_displayName)]
            public virtual float Unk_144 {
                get => Unk_144_raw;
                set {
                    if (Unk_144_raw == value) return;
                    Unk_144_raw = value;
                    ChangedItems.Add(nameof(Unk_144));
                    OnPropertyChanged(nameof(Unk_144));
                }
            }

            protected float Unk_145_raw;
            public const string Unk_145_displayName = "Unk 145";
            public const int Unk_145_sortIndex = 3050;
            [SortOrder(Unk_145_sortIndex)]
            [DisplayName(Unk_145_displayName)]
            public virtual float Unk_145 {
                get => Unk_145_raw;
                set {
                    if (Unk_145_raw == value) return;
                    Unk_145_raw = value;
                    ChangedItems.Add(nameof(Unk_145));
                    OnPropertyChanged(nameof(Unk_145));
                }
            }

            protected float Unk_146_raw;
            public const string Unk_146_displayName = "Unk 146";
            public const int Unk_146_sortIndex = 3100;
            [SortOrder(Unk_146_sortIndex)]
            [DisplayName(Unk_146_displayName)]
            public virtual float Unk_146 {
                get => Unk_146_raw;
                set {
                    if (Unk_146_raw == value) return;
                    Unk_146_raw = value;
                    ChangedItems.Add(nameof(Unk_146));
                    OnPropertyChanged(nameof(Unk_146));
                }
            }

            protected float Unk_147_raw;
            public const string Unk_147_displayName = "Unk 147";
            public const int Unk_147_sortIndex = 3150;
            [SortOrder(Unk_147_sortIndex)]
            [DisplayName(Unk_147_displayName)]
            public virtual float Unk_147 {
                get => Unk_147_raw;
                set {
                    if (Unk_147_raw == value) return;
                    Unk_147_raw = value;
                    ChangedItems.Add(nameof(Unk_147));
                    OnPropertyChanged(nameof(Unk_147));
                }
            }

            protected float Unk_148_raw;
            public const string Unk_148_displayName = "Unk 148";
            public const int Unk_148_sortIndex = 3200;
            [SortOrder(Unk_148_sortIndex)]
            [DisplayName(Unk_148_displayName)]
            public virtual float Unk_148 {
                get => Unk_148_raw;
                set {
                    if (Unk_148_raw == value) return;
                    Unk_148_raw = value;
                    ChangedItems.Add(nameof(Unk_148));
                    OnPropertyChanged(nameof(Unk_148));
                }
            }

            protected float Unk_149_raw;
            public const string Unk_149_displayName = "Unk 149";
            public const int Unk_149_sortIndex = 3250;
            [SortOrder(Unk_149_sortIndex)]
            [DisplayName(Unk_149_displayName)]
            public virtual float Unk_149 {
                get => Unk_149_raw;
                set {
                    if (Unk_149_raw == value) return;
                    Unk_149_raw = value;
                    ChangedItems.Add(nameof(Unk_149));
                    OnPropertyChanged(nameof(Unk_149));
                }
            }

            protected float Unk_150_raw;
            public const string Unk_150_displayName = "Unk 150";
            public const int Unk_150_sortIndex = 3300;
            [SortOrder(Unk_150_sortIndex)]
            [DisplayName(Unk_150_displayName)]
            public virtual float Unk_150 {
                get => Unk_150_raw;
                set {
                    if (Unk_150_raw == value) return;
                    Unk_150_raw = value;
                    ChangedItems.Add(nameof(Unk_150));
                    OnPropertyChanged(nameof(Unk_150));
                }
            }

            protected float Unk_151_raw;
            public const string Unk_151_displayName = "Unk 151";
            public const int Unk_151_sortIndex = 3350;
            [SortOrder(Unk_151_sortIndex)]
            [DisplayName(Unk_151_displayName)]
            public virtual float Unk_151 {
                get => Unk_151_raw;
                set {
                    if (Unk_151_raw == value) return;
                    Unk_151_raw = value;
                    ChangedItems.Add(nameof(Unk_151));
                    OnPropertyChanged(nameof(Unk_151));
                }
            }

            protected float Unk_152_raw;
            public const string Unk_152_displayName = "Unk 152";
            public const int Unk_152_sortIndex = 3400;
            [SortOrder(Unk_152_sortIndex)]
            [DisplayName(Unk_152_displayName)]
            public virtual float Unk_152 {
                get => Unk_152_raw;
                set {
                    if (Unk_152_raw == value) return;
                    Unk_152_raw = value;
                    ChangedItems.Add(nameof(Unk_152));
                    OnPropertyChanged(nameof(Unk_152));
                }
            }

            protected float Unk_153_raw;
            public const string Unk_153_displayName = "Unk 153";
            public const int Unk_153_sortIndex = 3450;
            [SortOrder(Unk_153_sortIndex)]
            [DisplayName(Unk_153_displayName)]
            public virtual float Unk_153 {
                get => Unk_153_raw;
                set {
                    if (Unk_153_raw == value) return;
                    Unk_153_raw = value;
                    ChangedItems.Add(nameof(Unk_153));
                    OnPropertyChanged(nameof(Unk_153));
                }
            }

            protected float Unk_154_raw;
            public const string Unk_154_displayName = "Unk 154";
            public const int Unk_154_sortIndex = 3500;
            [SortOrder(Unk_154_sortIndex)]
            [DisplayName(Unk_154_displayName)]
            public virtual float Unk_154 {
                get => Unk_154_raw;
                set {
                    if (Unk_154_raw == value) return;
                    Unk_154_raw = value;
                    ChangedItems.Add(nameof(Unk_154));
                    OnPropertyChanged(nameof(Unk_154));
                }
            }

            protected int Unk_155_raw;
            public const string Unk_155_displayName = "Unk 155";
            public const int Unk_155_sortIndex = 3550;
            [SortOrder(Unk_155_sortIndex)]
            [DisplayName(Unk_155_displayName)]
            public virtual int Unk_155 {
                get => Unk_155_raw;
                set {
                    if (Unk_155_raw == value) return;
                    Unk_155_raw = value;
                    ChangedItems.Add(nameof(Unk_155));
                    OnPropertyChanged(nameof(Unk_155));
                }
            }

            protected float Unk_156_raw;
            public const string Unk_156_displayName = "Unk 156";
            public const int Unk_156_sortIndex = 3600;
            [SortOrder(Unk_156_sortIndex)]
            [DisplayName(Unk_156_displayName)]
            public virtual float Unk_156 {
                get => Unk_156_raw;
                set {
                    if (Unk_156_raw == value) return;
                    Unk_156_raw = value;
                    ChangedItems.Add(nameof(Unk_156));
                    OnPropertyChanged(nameof(Unk_156));
                }
            }

            protected float Unk_157_raw;
            public const string Unk_157_displayName = "Unk 157";
            public const int Unk_157_sortIndex = 3650;
            [SortOrder(Unk_157_sortIndex)]
            [DisplayName(Unk_157_displayName)]
            public virtual float Unk_157 {
                get => Unk_157_raw;
                set {
                    if (Unk_157_raw == value) return;
                    Unk_157_raw = value;
                    ChangedItems.Add(nameof(Unk_157));
                    OnPropertyChanged(nameof(Unk_157));
                }
            }

            public const int lastSortIndex = 3700;

            public static ObservableMhwStructCollection<Monster_Common_Params_4_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Monster_Common_Params_4_>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Monster_Common_Params_4_ LoadData(BinaryReader reader, ulong i) {
                var data = new Monster_Common_Params_4_();
                data.Index = i;
                data.Unk_85_raw = reader.ReadSingle();
                data.Unk_86_raw = reader.ReadSingle();
                data.Unk_87_raw = reader.ReadSingle();
                data.Unk_88_raw = reader.ReadSingle();
                data.Unk_89_raw = reader.ReadSingle();
                data.Unk_90_raw = reader.ReadSingle();
                data.Unk_91_raw = reader.ReadSingle();
                data.Unk_92_raw = reader.ReadSingle();
                data.Unk_93_raw = reader.ReadSingle();
                data.Unk_94_raw = reader.ReadSingle();
                data.Unk_95_raw = reader.ReadSingle();
                data.Unk_96_raw = reader.ReadSingle();
                data.Unk_97_raw = reader.ReadSingle();
                data.Unk_98_raw = reader.ReadSingle();
                data.Unk_99_raw = reader.ReadSingle();
                data.Unk_100_raw = reader.ReadSingle();
                data.Unk_101_raw = reader.ReadSingle();
                data.Unk_102_raw = reader.ReadSingle();
                data.Unk_103_raw = reader.ReadSingle();
                data.Unk_104_raw = reader.ReadSingle();
                data.Unk_105_raw = reader.ReadSingle();
                data.Unk_106_raw = reader.ReadSingle();
                data.Unk_107_raw = reader.ReadSingle();
                data.Unk_108_raw = reader.ReadSingle();
                data.Unk_109_raw = reader.ReadSingle();
                data.Unk_110_raw = reader.ReadSingle();
                data.Unk_111_raw = reader.ReadSingle();
                data.Unk_112_raw = reader.ReadSingle();
                data.Unk_113_raw = reader.ReadSingle();
                data.Unk_114_raw = reader.ReadSingle();
                data.Unk_115_raw = reader.ReadSingle();
                data.Unk_116_raw = reader.ReadSingle();
                data.Unk_117_raw = reader.ReadSingle();
                data.Unk_118_raw = reader.ReadUInt32();
                data.Unk_119_raw = reader.ReadUInt32();
                data.Unk_120_raw = reader.ReadUInt32();
                data.Unk_121_raw = reader.ReadSingle();
                data.Unk_122_raw = reader.ReadSingle();
                data.Unk_123_raw = reader.ReadSingle();
                data.Unk_124_raw = reader.ReadSingle();
                data.Unk_125_raw = reader.ReadSingle();
                data.Unk_126_raw = reader.ReadSingle();
                data.Unk_127_raw = reader.ReadSingle();
                data.Unk_128_raw = reader.ReadSingle();
                data.Unk_129_raw = reader.ReadSingle();
                data.Unk_130_raw = reader.ReadSingle();
                data.Unk_131_raw = reader.ReadSingle();
                data.Unk_132_raw = reader.ReadUInt32();
                data.Unk_133_raw = reader.ReadUInt32();
                data.Unk_134_raw = reader.ReadSingle();
                data.Unk_135_raw = reader.ReadUInt32();
                data.Unk_136_raw = reader.ReadSingle();
                data.Unk_137_raw = reader.ReadUInt32();
                data.Unk_138_raw = reader.ReadSingle();
                data.Unk_139_raw = reader.ReadSingle();
                data.Unk_140_raw = reader.ReadSingle();
                data.Unk_141_raw = reader.ReadSingle();
                data.Unk_142_raw = reader.ReadSingle();
                data.Unk_143_raw = reader.ReadSingle();
                data.Unk_144_raw = reader.ReadSingle();
                data.Unk_145_raw = reader.ReadSingle();
                data.Unk_146_raw = reader.ReadSingle();
                data.Unk_147_raw = reader.ReadSingle();
                data.Unk_148_raw = reader.ReadSingle();
                data.Unk_149_raw = reader.ReadSingle();
                data.Unk_150_raw = reader.ReadSingle();
                data.Unk_151_raw = reader.ReadSingle();
                data.Unk_152_raw = reader.ReadSingle();
                data.Unk_153_raw = reader.ReadSingle();
                data.Unk_154_raw = reader.ReadSingle();
                data.Unk_155_raw = reader.ReadInt32();
                data.Unk_156_raw = reader.ReadSingle();
                data.Unk_157_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_85_raw);
                writer.Write(Unk_86_raw);
                writer.Write(Unk_87_raw);
                writer.Write(Unk_88_raw);
                writer.Write(Unk_89_raw);
                writer.Write(Unk_90_raw);
                writer.Write(Unk_91_raw);
                writer.Write(Unk_92_raw);
                writer.Write(Unk_93_raw);
                writer.Write(Unk_94_raw);
                writer.Write(Unk_95_raw);
                writer.Write(Unk_96_raw);
                writer.Write(Unk_97_raw);
                writer.Write(Unk_98_raw);
                writer.Write(Unk_99_raw);
                writer.Write(Unk_100_raw);
                writer.Write(Unk_101_raw);
                writer.Write(Unk_102_raw);
                writer.Write(Unk_103_raw);
                writer.Write(Unk_104_raw);
                writer.Write(Unk_105_raw);
                writer.Write(Unk_106_raw);
                writer.Write(Unk_107_raw);
                writer.Write(Unk_108_raw);
                writer.Write(Unk_109_raw);
                writer.Write(Unk_110_raw);
                writer.Write(Unk_111_raw);
                writer.Write(Unk_112_raw);
                writer.Write(Unk_113_raw);
                writer.Write(Unk_114_raw);
                writer.Write(Unk_115_raw);
                writer.Write(Unk_116_raw);
                writer.Write(Unk_117_raw);
                writer.Write(Unk_118_raw);
                writer.Write(Unk_119_raw);
                writer.Write(Unk_120_raw);
                writer.Write(Unk_121_raw);
                writer.Write(Unk_122_raw);
                writer.Write(Unk_123_raw);
                writer.Write(Unk_124_raw);
                writer.Write(Unk_125_raw);
                writer.Write(Unk_126_raw);
                writer.Write(Unk_127_raw);
                writer.Write(Unk_128_raw);
                writer.Write(Unk_129_raw);
                writer.Write(Unk_130_raw);
                writer.Write(Unk_131_raw);
                writer.Write(Unk_132_raw);
                writer.Write(Unk_133_raw);
                writer.Write(Unk_134_raw);
                writer.Write(Unk_135_raw);
                writer.Write(Unk_136_raw);
                writer.Write(Unk_137_raw);
                writer.Write(Unk_138_raw);
                writer.Write(Unk_139_raw);
                writer.Write(Unk_140_raw);
                writer.Write(Unk_141_raw);
                writer.Write(Unk_142_raw);
                writer.Write(Unk_143_raw);
                writer.Write(Unk_144_raw);
                writer.Write(Unk_145_raw);
                writer.Write(Unk_146_raw);
                writer.Write(Unk_147_raw);
                writer.Write(Unk_148_raw);
                writer.Write(Unk_149_raw);
                writer.Write(Unk_150_raw);
                writer.Write(Unk_151_raw);
                writer.Write(Unk_152_raw);
                writer.Write(Unk_153_raw);
                writer.Write(Unk_154_raw);
                writer.Write(Unk_155_raw);
                writer.Write(Unk_156_raw);
                writer.Write(Unk_157_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Unk 85", "Unk_85"),
                    new MultiStructItemCustomView(this, "Unk 86", "Unk_86"),
                    new MultiStructItemCustomView(this, "Unk 87", "Unk_87"),
                    new MultiStructItemCustomView(this, "Unk 88", "Unk_88"),
                    new MultiStructItemCustomView(this, "Unk 89", "Unk_89"),
                    new MultiStructItemCustomView(this, "Unk 90", "Unk_90"),
                    new MultiStructItemCustomView(this, "Unk 91", "Unk_91"),
                    new MultiStructItemCustomView(this, "Unk 92", "Unk_92"),
                    new MultiStructItemCustomView(this, "Unk 93", "Unk_93"),
                    new MultiStructItemCustomView(this, "Unk 94", "Unk_94"),
                    new MultiStructItemCustomView(this, "Unk 95", "Unk_95"),
                    new MultiStructItemCustomView(this, "Unk 96", "Unk_96"),
                    new MultiStructItemCustomView(this, "Unk 97", "Unk_97"),
                    new MultiStructItemCustomView(this, "Unk 98", "Unk_98"),
                    new MultiStructItemCustomView(this, "Unk 99", "Unk_99"),
                    new MultiStructItemCustomView(this, "Unk 100", "Unk_100"),
                    new MultiStructItemCustomView(this, "Unk 101", "Unk_101"),
                    new MultiStructItemCustomView(this, "Unk 102", "Unk_102"),
                    new MultiStructItemCustomView(this, "Unk 103", "Unk_103"),
                    new MultiStructItemCustomView(this, "Unk 104", "Unk_104"),
                    new MultiStructItemCustomView(this, "Unk 105", "Unk_105"),
                    new MultiStructItemCustomView(this, "Unk 106", "Unk_106"),
                    new MultiStructItemCustomView(this, "Unk 107", "Unk_107"),
                    new MultiStructItemCustomView(this, "Unk 108", "Unk_108"),
                    new MultiStructItemCustomView(this, "Unk 109", "Unk_109"),
                    new MultiStructItemCustomView(this, "Unk 110", "Unk_110"),
                    new MultiStructItemCustomView(this, "Unk 111", "Unk_111"),
                    new MultiStructItemCustomView(this, "Unk 112", "Unk_112"),
                    new MultiStructItemCustomView(this, "Unk 113", "Unk_113"),
                    new MultiStructItemCustomView(this, "Unk 114", "Unk_114"),
                    new MultiStructItemCustomView(this, "Unk 115", "Unk_115"),
                    new MultiStructItemCustomView(this, "Unk 116", "Unk_116"),
                    new MultiStructItemCustomView(this, "Unk 117", "Unk_117"),
                    new MultiStructItemCustomView(this, "Unk 118", "Unk_118"),
                    new MultiStructItemCustomView(this, "Unk 119", "Unk_119"),
                    new MultiStructItemCustomView(this, "Unk 120", "Unk_120"),
                    new MultiStructItemCustomView(this, "Unk 121", "Unk_121"),
                    new MultiStructItemCustomView(this, "Unk 122", "Unk_122"),
                    new MultiStructItemCustomView(this, "Unk 123", "Unk_123"),
                    new MultiStructItemCustomView(this, "Unk 124", "Unk_124"),
                    new MultiStructItemCustomView(this, "Unk 125", "Unk_125"),
                    new MultiStructItemCustomView(this, "Unk 126", "Unk_126"),
                    new MultiStructItemCustomView(this, "Unk 127", "Unk_127"),
                    new MultiStructItemCustomView(this, "Unk 128", "Unk_128"),
                    new MultiStructItemCustomView(this, "Unk 129", "Unk_129"),
                    new MultiStructItemCustomView(this, "Unk 130", "Unk_130"),
                    new MultiStructItemCustomView(this, "Unk 131", "Unk_131"),
                    new MultiStructItemCustomView(this, "Unk 132", "Unk_132"),
                    new MultiStructItemCustomView(this, "Unk 133", "Unk_133"),
                    new MultiStructItemCustomView(this, "Unk 134", "Unk_134"),
                    new MultiStructItemCustomView(this, "Unk 135", "Unk_135"),
                    new MultiStructItemCustomView(this, "Unk 136", "Unk_136"),
                    new MultiStructItemCustomView(this, "Unk 137", "Unk_137"),
                    new MultiStructItemCustomView(this, "Unk 138", "Unk_138"),
                    new MultiStructItemCustomView(this, "Unk 139", "Unk_139"),
                    new MultiStructItemCustomView(this, "Unk 140", "Unk_140"),
                    new MultiStructItemCustomView(this, "Unk 141", "Unk_141"),
                    new MultiStructItemCustomView(this, "Unk 142", "Unk_142"),
                    new MultiStructItemCustomView(this, "Unk 143", "Unk_143"),
                    new MultiStructItemCustomView(this, "Unk 144", "Unk_144"),
                    new MultiStructItemCustomView(this, "Unk 145", "Unk_145"),
                    new MultiStructItemCustomView(this, "Unk 146", "Unk_146"),
                    new MultiStructItemCustomView(this, "Unk 147", "Unk_147"),
                    new MultiStructItemCustomView(this, "Unk 148", "Unk_148"),
                    new MultiStructItemCustomView(this, "Unk 149", "Unk_149"),
                    new MultiStructItemCustomView(this, "Unk 150", "Unk_150"),
                    new MultiStructItemCustomView(this, "Unk 151", "Unk_151"),
                    new MultiStructItemCustomView(this, "Unk 152", "Unk_152"),
                    new MultiStructItemCustomView(this, "Unk 153", "Unk_153"),
                    new MultiStructItemCustomView(this, "Unk 154", "Unk_154"),
                    new MultiStructItemCustomView(this, "Unk 155", "Unk_155"),
                    new MultiStructItemCustomView(this, "Unk 156", "Unk_156"),
                    new MultiStructItemCustomView(this, "Unk 157", "Unk_157"),
                };
            }
        }

        public partial class Monster_Common_Params_5_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Monster Common Params (5)";

            protected uint Header_raw;
            public const string Header_displayName = "Header";
            public const int Header_sortIndex = 50;
            [SortOrder(Header_sortIndex)]
            [DisplayName(Header_displayName)]
            public virtual uint Header {
                get => Header_raw;
                set {
                    if (Header_raw == value) return;
                    Header_raw = value;
                    ChangedItems.Add(nameof(Header));
                    OnPropertyChanged(nameof(Header));
                }
            }

            protected float Unk_158_raw;
            public const string Unk_158_displayName = "Unk 158";
            public const int Unk_158_sortIndex = 100;
            [SortOrder(Unk_158_sortIndex)]
            [DisplayName(Unk_158_displayName)]
            public virtual float Unk_158 {
                get => Unk_158_raw;
                set {
                    if (Unk_158_raw == value) return;
                    Unk_158_raw = value;
                    ChangedItems.Add(nameof(Unk_158));
                    OnPropertyChanged(nameof(Unk_158));
                }
            }

            protected byte Unk_159_raw;
            public const string Unk_159_displayName = "Unk 159";
            public const int Unk_159_sortIndex = 150;
            [SortOrder(Unk_159_sortIndex)]
            [DisplayName(Unk_159_displayName)]
            public virtual byte Unk_159 {
                get => Unk_159_raw;
                set {
                    if (Unk_159_raw == value) return;
                    Unk_159_raw = value;
                    ChangedItems.Add(nameof(Unk_159));
                    OnPropertyChanged(nameof(Unk_159));
                }
            }

            protected float Unk_160_raw;
            public const string Unk_160_displayName = "Unk 160";
            public const int Unk_160_sortIndex = 200;
            [SortOrder(Unk_160_sortIndex)]
            [DisplayName(Unk_160_displayName)]
            public virtual float Unk_160 {
                get => Unk_160_raw;
                set {
                    if (Unk_160_raw == value) return;
                    Unk_160_raw = value;
                    ChangedItems.Add(nameof(Unk_160));
                    OnPropertyChanged(nameof(Unk_160));
                }
            }

            protected float Unk_161_raw;
            public const string Unk_161_displayName = "Unk 161";
            public const int Unk_161_sortIndex = 250;
            [SortOrder(Unk_161_sortIndex)]
            [DisplayName(Unk_161_displayName)]
            public virtual float Unk_161 {
                get => Unk_161_raw;
                set {
                    if (Unk_161_raw == value) return;
                    Unk_161_raw = value;
                    ChangedItems.Add(nameof(Unk_161));
                    OnPropertyChanged(nameof(Unk_161));
                }
            }

            protected float Unk_162_raw;
            public const string Unk_162_displayName = "Unk 162";
            public const int Unk_162_sortIndex = 300;
            [SortOrder(Unk_162_sortIndex)]
            [DisplayName(Unk_162_displayName)]
            public virtual float Unk_162 {
                get => Unk_162_raw;
                set {
                    if (Unk_162_raw == value) return;
                    Unk_162_raw = value;
                    ChangedItems.Add(nameof(Unk_162));
                    OnPropertyChanged(nameof(Unk_162));
                }
            }

            protected uint Unk_163_raw;
            public const string Unk_163_displayName = "Unk 163";
            public const int Unk_163_sortIndex = 350;
            [SortOrder(Unk_163_sortIndex)]
            [DisplayName(Unk_163_displayName)]
            public virtual uint Unk_163 {
                get => Unk_163_raw;
                set {
                    if (Unk_163_raw == value) return;
                    Unk_163_raw = value;
                    ChangedItems.Add(nameof(Unk_163));
                    OnPropertyChanged(nameof(Unk_163));
                }
            }

            protected float Unk_164_raw;
            public const string Unk_164_displayName = "Unk 164";
            public const int Unk_164_sortIndex = 400;
            [SortOrder(Unk_164_sortIndex)]
            [DisplayName(Unk_164_displayName)]
            public virtual float Unk_164 {
                get => Unk_164_raw;
                set {
                    if (Unk_164_raw == value) return;
                    Unk_164_raw = value;
                    ChangedItems.Add(nameof(Unk_164));
                    OnPropertyChanged(nameof(Unk_164));
                }
            }

            protected float Unk_165_raw;
            public const string Unk_165_displayName = "Unk 165";
            public const int Unk_165_sortIndex = 450;
            [SortOrder(Unk_165_sortIndex)]
            [DisplayName(Unk_165_displayName)]
            public virtual float Unk_165 {
                get => Unk_165_raw;
                set {
                    if (Unk_165_raw == value) return;
                    Unk_165_raw = value;
                    ChangedItems.Add(nameof(Unk_165));
                    OnPropertyChanged(nameof(Unk_165));
                }
            }

            protected float Unk_166_raw;
            public const string Unk_166_displayName = "Unk 166";
            public const int Unk_166_sortIndex = 500;
            [SortOrder(Unk_166_sortIndex)]
            [DisplayName(Unk_166_displayName)]
            public virtual float Unk_166 {
                get => Unk_166_raw;
                set {
                    if (Unk_166_raw == value) return;
                    Unk_166_raw = value;
                    ChangedItems.Add(nameof(Unk_166));
                    OnPropertyChanged(nameof(Unk_166));
                }
            }

            protected float Unk_167_raw;
            public const string Unk_167_displayName = "Unk 167";
            public const int Unk_167_sortIndex = 550;
            [SortOrder(Unk_167_sortIndex)]
            [DisplayName(Unk_167_displayName)]
            public virtual float Unk_167 {
                get => Unk_167_raw;
                set {
                    if (Unk_167_raw == value) return;
                    Unk_167_raw = value;
                    ChangedItems.Add(nameof(Unk_167));
                    OnPropertyChanged(nameof(Unk_167));
                }
            }

            protected float Unk_168_raw;
            public const string Unk_168_displayName = "Unk 168";
            public const int Unk_168_sortIndex = 600;
            [SortOrder(Unk_168_sortIndex)]
            [DisplayName(Unk_168_displayName)]
            public virtual float Unk_168 {
                get => Unk_168_raw;
                set {
                    if (Unk_168_raw == value) return;
                    Unk_168_raw = value;
                    ChangedItems.Add(nameof(Unk_168));
                    OnPropertyChanged(nameof(Unk_168));
                }
            }

            protected float Unk_169_raw;
            public const string Unk_169_displayName = "Unk 169";
            public const int Unk_169_sortIndex = 650;
            [SortOrder(Unk_169_sortIndex)]
            [DisplayName(Unk_169_displayName)]
            public virtual float Unk_169 {
                get => Unk_169_raw;
                set {
                    if (Unk_169_raw == value) return;
                    Unk_169_raw = value;
                    ChangedItems.Add(nameof(Unk_169));
                    OnPropertyChanged(nameof(Unk_169));
                }
            }

            protected float Unk_170_raw;
            public const string Unk_170_displayName = "Unk 170";
            public const int Unk_170_sortIndex = 700;
            [SortOrder(Unk_170_sortIndex)]
            [DisplayName(Unk_170_displayName)]
            public virtual float Unk_170 {
                get => Unk_170_raw;
                set {
                    if (Unk_170_raw == value) return;
                    Unk_170_raw = value;
                    ChangedItems.Add(nameof(Unk_170));
                    OnPropertyChanged(nameof(Unk_170));
                }
            }

            protected float Unk_171_raw;
            public const string Unk_171_displayName = "Unk 171";
            public const int Unk_171_sortIndex = 750;
            [SortOrder(Unk_171_sortIndex)]
            [DisplayName(Unk_171_displayName)]
            public virtual float Unk_171 {
                get => Unk_171_raw;
                set {
                    if (Unk_171_raw == value) return;
                    Unk_171_raw = value;
                    ChangedItems.Add(nameof(Unk_171));
                    OnPropertyChanged(nameof(Unk_171));
                }
            }

            protected float Unk_172_raw;
            public const string Unk_172_displayName = "Unk 172";
            public const int Unk_172_sortIndex = 800;
            [SortOrder(Unk_172_sortIndex)]
            [DisplayName(Unk_172_displayName)]
            public virtual float Unk_172 {
                get => Unk_172_raw;
                set {
                    if (Unk_172_raw == value) return;
                    Unk_172_raw = value;
                    ChangedItems.Add(nameof(Unk_172));
                    OnPropertyChanged(nameof(Unk_172));
                }
            }

            protected float Unk_173_raw;
            public const string Unk_173_displayName = "Unk 173";
            public const int Unk_173_sortIndex = 850;
            [SortOrder(Unk_173_sortIndex)]
            [DisplayName(Unk_173_displayName)]
            public virtual float Unk_173 {
                get => Unk_173_raw;
                set {
                    if (Unk_173_raw == value) return;
                    Unk_173_raw = value;
                    ChangedItems.Add(nameof(Unk_173));
                    OnPropertyChanged(nameof(Unk_173));
                }
            }

            protected float Unk_174_raw;
            public const string Unk_174_displayName = "Unk 174";
            public const int Unk_174_sortIndex = 900;
            [SortOrder(Unk_174_sortIndex)]
            [DisplayName(Unk_174_displayName)]
            public virtual float Unk_174 {
                get => Unk_174_raw;
                set {
                    if (Unk_174_raw == value) return;
                    Unk_174_raw = value;
                    ChangedItems.Add(nameof(Unk_174));
                    OnPropertyChanged(nameof(Unk_174));
                }
            }

            protected float Unk_175_raw;
            public const string Unk_175_displayName = "Unk 175";
            public const int Unk_175_sortIndex = 950;
            [SortOrder(Unk_175_sortIndex)]
            [DisplayName(Unk_175_displayName)]
            public virtual float Unk_175 {
                get => Unk_175_raw;
                set {
                    if (Unk_175_raw == value) return;
                    Unk_175_raw = value;
                    ChangedItems.Add(nameof(Unk_175));
                    OnPropertyChanged(nameof(Unk_175));
                }
            }

            protected float Unk_176_raw;
            public const string Unk_176_displayName = "Unk 176";
            public const int Unk_176_sortIndex = 1000;
            [SortOrder(Unk_176_sortIndex)]
            [DisplayName(Unk_176_displayName)]
            public virtual float Unk_176 {
                get => Unk_176_raw;
                set {
                    if (Unk_176_raw == value) return;
                    Unk_176_raw = value;
                    ChangedItems.Add(nameof(Unk_176));
                    OnPropertyChanged(nameof(Unk_176));
                }
            }

            protected float Unk_177_raw;
            public const string Unk_177_displayName = "Unk 177";
            public const int Unk_177_sortIndex = 1050;
            [SortOrder(Unk_177_sortIndex)]
            [DisplayName(Unk_177_displayName)]
            public virtual float Unk_177 {
                get => Unk_177_raw;
                set {
                    if (Unk_177_raw == value) return;
                    Unk_177_raw = value;
                    ChangedItems.Add(nameof(Unk_177));
                    OnPropertyChanged(nameof(Unk_177));
                }
            }

            protected float Unk_178_raw;
            public const string Unk_178_displayName = "Unk 178";
            public const int Unk_178_sortIndex = 1100;
            [SortOrder(Unk_178_sortIndex)]
            [DisplayName(Unk_178_displayName)]
            public virtual float Unk_178 {
                get => Unk_178_raw;
                set {
                    if (Unk_178_raw == value) return;
                    Unk_178_raw = value;
                    ChangedItems.Add(nameof(Unk_178));
                    OnPropertyChanged(nameof(Unk_178));
                }
            }

            protected float Unk_179_raw;
            public const string Unk_179_displayName = "Unk 179";
            public const int Unk_179_sortIndex = 1150;
            [SortOrder(Unk_179_sortIndex)]
            [DisplayName(Unk_179_displayName)]
            public virtual float Unk_179 {
                get => Unk_179_raw;
                set {
                    if (Unk_179_raw == value) return;
                    Unk_179_raw = value;
                    ChangedItems.Add(nameof(Unk_179));
                    OnPropertyChanged(nameof(Unk_179));
                }
            }

            public const int lastSortIndex = 1200;

            public static ObservableMhwStructCollection<Monster_Common_Params_5_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Monster_Common_Params_5_>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Monster_Common_Params_5_ LoadData(BinaryReader reader, ulong i) {
                var data = new Monster_Common_Params_5_();
                data.Index = i;
                data.Header_raw = reader.ReadUInt32();
                data.Unk_158_raw = reader.ReadSingle();
                data.Unk_159_raw = reader.ReadByte();
                data.Unk_160_raw = reader.ReadSingle();
                data.Unk_161_raw = reader.ReadSingle();
                data.Unk_162_raw = reader.ReadSingle();
                data.Unk_163_raw = reader.ReadUInt32();
                data.Unk_164_raw = reader.ReadSingle();
                data.Unk_165_raw = reader.ReadSingle();
                data.Unk_166_raw = reader.ReadSingle();
                data.Unk_167_raw = reader.ReadSingle();
                data.Unk_168_raw = reader.ReadSingle();
                data.Unk_169_raw = reader.ReadSingle();
                data.Unk_170_raw = reader.ReadSingle();
                data.Unk_171_raw = reader.ReadSingle();
                data.Unk_172_raw = reader.ReadSingle();
                data.Unk_173_raw = reader.ReadSingle();
                data.Unk_174_raw = reader.ReadSingle();
                data.Unk_175_raw = reader.ReadSingle();
                data.Unk_176_raw = reader.ReadSingle();
                data.Unk_177_raw = reader.ReadSingle();
                data.Unk_178_raw = reader.ReadSingle();
                data.Unk_179_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Header_raw);
                writer.Write(Unk_158_raw);
                writer.Write(Unk_159_raw);
                writer.Write(Unk_160_raw);
                writer.Write(Unk_161_raw);
                writer.Write(Unk_162_raw);
                writer.Write(Unk_163_raw);
                writer.Write(Unk_164_raw);
                writer.Write(Unk_165_raw);
                writer.Write(Unk_166_raw);
                writer.Write(Unk_167_raw);
                writer.Write(Unk_168_raw);
                writer.Write(Unk_169_raw);
                writer.Write(Unk_170_raw);
                writer.Write(Unk_171_raw);
                writer.Write(Unk_172_raw);
                writer.Write(Unk_173_raw);
                writer.Write(Unk_174_raw);
                writer.Write(Unk_175_raw);
                writer.Write(Unk_176_raw);
                writer.Write(Unk_177_raw);
                writer.Write(Unk_178_raw);
                writer.Write(Unk_179_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Header", "Header"),
                    new MultiStructItemCustomView(this, "Unk 158", "Unk_158"),
                    new MultiStructItemCustomView(this, "Unk 159", "Unk_159"),
                    new MultiStructItemCustomView(this, "Unk 160", "Unk_160"),
                    new MultiStructItemCustomView(this, "Unk 161", "Unk_161"),
                    new MultiStructItemCustomView(this, "Unk 162", "Unk_162"),
                    new MultiStructItemCustomView(this, "Unk 163", "Unk_163"),
                    new MultiStructItemCustomView(this, "Unk 164", "Unk_164"),
                    new MultiStructItemCustomView(this, "Unk 165", "Unk_165"),
                    new MultiStructItemCustomView(this, "Unk 166", "Unk_166"),
                    new MultiStructItemCustomView(this, "Unk 167", "Unk_167"),
                    new MultiStructItemCustomView(this, "Unk 168", "Unk_168"),
                    new MultiStructItemCustomView(this, "Unk 169", "Unk_169"),
                    new MultiStructItemCustomView(this, "Unk 170", "Unk_170"),
                    new MultiStructItemCustomView(this, "Unk 171", "Unk_171"),
                    new MultiStructItemCustomView(this, "Unk 172", "Unk_172"),
                    new MultiStructItemCustomView(this, "Unk 173", "Unk_173"),
                    new MultiStructItemCustomView(this, "Unk 174", "Unk_174"),
                    new MultiStructItemCustomView(this, "Unk 175", "Unk_175"),
                    new MultiStructItemCustomView(this, "Unk 176", "Unk_176"),
                    new MultiStructItemCustomView(this, "Unk 177", "Unk_177"),
                    new MultiStructItemCustomView(this, "Unk 178", "Unk_178"),
                    new MultiStructItemCustomView(this, "Unk 179", "Unk_179"),
                };
            }
        }

        public partial class Unk_Arr_2 : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 44;
            public const string GridName = "Unk Arr 2";

            protected int Unk_1_raw;
            public const string Unk_1_displayName = "Unk 1";
            public const int Unk_1_sortIndex = 50;
            [SortOrder(Unk_1_sortIndex)]
            [DisplayName(Unk_1_displayName)]
            public virtual int Unk_1 {
                get => Unk_1_raw;
                set {
                    if (Unk_1_raw == value) return;
                    Unk_1_raw = value;
                    ChangedItems.Add(nameof(Unk_1));
                    OnPropertyChanged(nameof(Unk_1));
                }
            }

            protected int Unk_2_raw;
            public const string Unk_2_displayName = "Unk 2";
            public const int Unk_2_sortIndex = 100;
            [SortOrder(Unk_2_sortIndex)]
            [DisplayName(Unk_2_displayName)]
            public virtual int Unk_2 {
                get => Unk_2_raw;
                set {
                    if (Unk_2_raw == value) return;
                    Unk_2_raw = value;
                    ChangedItems.Add(nameof(Unk_2));
                    OnPropertyChanged(nameof(Unk_2));
                }
            }

            public const int lastSortIndex = 150;

            public static ObservableMhwStructCollection<Unk_Arr_2> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Unk_Arr_2>();
                var count = 44UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Unk_Arr_2 LoadData(BinaryReader reader, ulong i) {
                var data = new Unk_Arr_2();
                data.Index = i;
                data.Unk_1_raw = reader.ReadInt32();
                data.Unk_2_raw = reader.ReadInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_1_raw);
                writer.Write(Unk_2_raw);
            }
        }

        public partial class Monster_Common_Params_6_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Monster Common Params (6)";

            protected uint Unk_180_raw;
            public const string Unk_180_displayName = "Unk 180";
            public const int Unk_180_sortIndex = 50;
            [SortOrder(Unk_180_sortIndex)]
            [DisplayName(Unk_180_displayName)]
            public virtual uint Unk_180 {
                get => Unk_180_raw;
                set {
                    if (Unk_180_raw == value) return;
                    Unk_180_raw = value;
                    ChangedItems.Add(nameof(Unk_180));
                    OnPropertyChanged(nameof(Unk_180));
                }
            }

            protected float Unk_181_raw;
            public const string Unk_181_displayName = "Unk 181";
            public const int Unk_181_sortIndex = 100;
            [SortOrder(Unk_181_sortIndex)]
            [DisplayName(Unk_181_displayName)]
            public virtual float Unk_181 {
                get => Unk_181_raw;
                set {
                    if (Unk_181_raw == value) return;
                    Unk_181_raw = value;
                    ChangedItems.Add(nameof(Unk_181));
                    OnPropertyChanged(nameof(Unk_181));
                }
            }

            protected float Unk_182_raw;
            public const string Unk_182_displayName = "Unk 182";
            public const int Unk_182_sortIndex = 150;
            [SortOrder(Unk_182_sortIndex)]
            [DisplayName(Unk_182_displayName)]
            public virtual float Unk_182 {
                get => Unk_182_raw;
                set {
                    if (Unk_182_raw == value) return;
                    Unk_182_raw = value;
                    ChangedItems.Add(nameof(Unk_182));
                    OnPropertyChanged(nameof(Unk_182));
                }
            }

            protected int Unk_183_raw;
            public const string Unk_183_displayName = "Unk 183";
            public const int Unk_183_sortIndex = 200;
            [SortOrder(Unk_183_sortIndex)]
            [DisplayName(Unk_183_displayName)]
            public virtual int Unk_183 {
                get => Unk_183_raw;
                set {
                    if (Unk_183_raw == value) return;
                    Unk_183_raw = value;
                    ChangedItems.Add(nameof(Unk_183));
                    OnPropertyChanged(nameof(Unk_183));
                }
            }

            protected int Unk_184_raw;
            public const string Unk_184_displayName = "Unk 184";
            public const int Unk_184_sortIndex = 250;
            [SortOrder(Unk_184_sortIndex)]
            [DisplayName(Unk_184_displayName)]
            public virtual int Unk_184 {
                get => Unk_184_raw;
                set {
                    if (Unk_184_raw == value) return;
                    Unk_184_raw = value;
                    ChangedItems.Add(nameof(Unk_184));
                    OnPropertyChanged(nameof(Unk_184));
                }
            }

            protected float Unk_185_raw;
            public const string Unk_185_displayName = "Unk 185";
            public const int Unk_185_sortIndex = 300;
            [SortOrder(Unk_185_sortIndex)]
            [DisplayName(Unk_185_displayName)]
            public virtual float Unk_185 {
                get => Unk_185_raw;
                set {
                    if (Unk_185_raw == value) return;
                    Unk_185_raw = value;
                    ChangedItems.Add(nameof(Unk_185));
                    OnPropertyChanged(nameof(Unk_185));
                }
            }

            protected float Unk_186_raw;
            public const string Unk_186_displayName = "Unk 186";
            public const int Unk_186_sortIndex = 350;
            [SortOrder(Unk_186_sortIndex)]
            [DisplayName(Unk_186_displayName)]
            public virtual float Unk_186 {
                get => Unk_186_raw;
                set {
                    if (Unk_186_raw == value) return;
                    Unk_186_raw = value;
                    ChangedItems.Add(nameof(Unk_186));
                    OnPropertyChanged(nameof(Unk_186));
                }
            }

            protected uint Unk_187_raw;
            public const string Unk_187_displayName = "Unk 187";
            public const int Unk_187_sortIndex = 400;
            [SortOrder(Unk_187_sortIndex)]
            [DisplayName(Unk_187_displayName)]
            public virtual uint Unk_187 {
                get => Unk_187_raw;
                set {
                    if (Unk_187_raw == value) return;
                    Unk_187_raw = value;
                    ChangedItems.Add(nameof(Unk_187));
                    OnPropertyChanged(nameof(Unk_187));
                }
            }

            protected float Unk_188_raw;
            public const string Unk_188_displayName = "Unk 188";
            public const int Unk_188_sortIndex = 450;
            [SortOrder(Unk_188_sortIndex)]
            [DisplayName(Unk_188_displayName)]
            public virtual float Unk_188 {
                get => Unk_188_raw;
                set {
                    if (Unk_188_raw == value) return;
                    Unk_188_raw = value;
                    ChangedItems.Add(nameof(Unk_188));
                    OnPropertyChanged(nameof(Unk_188));
                }
            }

            protected float Unk_189_raw;
            public const string Unk_189_displayName = "Unk 189";
            public const int Unk_189_sortIndex = 500;
            [SortOrder(Unk_189_sortIndex)]
            [DisplayName(Unk_189_displayName)]
            public virtual float Unk_189 {
                get => Unk_189_raw;
                set {
                    if (Unk_189_raw == value) return;
                    Unk_189_raw = value;
                    ChangedItems.Add(nameof(Unk_189));
                    OnPropertyChanged(nameof(Unk_189));
                }
            }

            protected float Unk_190_raw;
            public const string Unk_190_displayName = "Unk 190";
            public const int Unk_190_sortIndex = 550;
            [SortOrder(Unk_190_sortIndex)]
            [DisplayName(Unk_190_displayName)]
            public virtual float Unk_190 {
                get => Unk_190_raw;
                set {
                    if (Unk_190_raw == value) return;
                    Unk_190_raw = value;
                    ChangedItems.Add(nameof(Unk_190));
                    OnPropertyChanged(nameof(Unk_190));
                }
            }

            protected float Unk_191_raw;
            public const string Unk_191_displayName = "Unk 191";
            public const int Unk_191_sortIndex = 600;
            [SortOrder(Unk_191_sortIndex)]
            [DisplayName(Unk_191_displayName)]
            public virtual float Unk_191 {
                get => Unk_191_raw;
                set {
                    if (Unk_191_raw == value) return;
                    Unk_191_raw = value;
                    ChangedItems.Add(nameof(Unk_191));
                    OnPropertyChanged(nameof(Unk_191));
                }
            }

            protected float Unk_192_raw;
            public const string Unk_192_displayName = "Unk 192";
            public const int Unk_192_sortIndex = 650;
            [SortOrder(Unk_192_sortIndex)]
            [DisplayName(Unk_192_displayName)]
            public virtual float Unk_192 {
                get => Unk_192_raw;
                set {
                    if (Unk_192_raw == value) return;
                    Unk_192_raw = value;
                    ChangedItems.Add(nameof(Unk_192));
                    OnPropertyChanged(nameof(Unk_192));
                }
            }

            protected float Unk_193_raw;
            public const string Unk_193_displayName = "Unk 193";
            public const int Unk_193_sortIndex = 700;
            [SortOrder(Unk_193_sortIndex)]
            [DisplayName(Unk_193_displayName)]
            public virtual float Unk_193 {
                get => Unk_193_raw;
                set {
                    if (Unk_193_raw == value) return;
                    Unk_193_raw = value;
                    ChangedItems.Add(nameof(Unk_193));
                    OnPropertyChanged(nameof(Unk_193));
                }
            }

            protected float Unk_194_raw;
            public const string Unk_194_displayName = "Unk 194";
            public const int Unk_194_sortIndex = 750;
            [SortOrder(Unk_194_sortIndex)]
            [DisplayName(Unk_194_displayName)]
            public virtual float Unk_194 {
                get => Unk_194_raw;
                set {
                    if (Unk_194_raw == value) return;
                    Unk_194_raw = value;
                    ChangedItems.Add(nameof(Unk_194));
                    OnPropertyChanged(nameof(Unk_194));
                }
            }

            protected float Unk_195_raw;
            public const string Unk_195_displayName = "Unk 195";
            public const int Unk_195_sortIndex = 800;
            [SortOrder(Unk_195_sortIndex)]
            [DisplayName(Unk_195_displayName)]
            public virtual float Unk_195 {
                get => Unk_195_raw;
                set {
                    if (Unk_195_raw == value) return;
                    Unk_195_raw = value;
                    ChangedItems.Add(nameof(Unk_195));
                    OnPropertyChanged(nameof(Unk_195));
                }
            }

            protected float Unk_196_raw;
            public const string Unk_196_displayName = "Unk 196";
            public const int Unk_196_sortIndex = 850;
            [SortOrder(Unk_196_sortIndex)]
            [DisplayName(Unk_196_displayName)]
            public virtual float Unk_196 {
                get => Unk_196_raw;
                set {
                    if (Unk_196_raw == value) return;
                    Unk_196_raw = value;
                    ChangedItems.Add(nameof(Unk_196));
                    OnPropertyChanged(nameof(Unk_196));
                }
            }

            protected float Unk_197_raw;
            public const string Unk_197_displayName = "Unk 197";
            public const int Unk_197_sortIndex = 900;
            [SortOrder(Unk_197_sortIndex)]
            [DisplayName(Unk_197_displayName)]
            public virtual float Unk_197 {
                get => Unk_197_raw;
                set {
                    if (Unk_197_raw == value) return;
                    Unk_197_raw = value;
                    ChangedItems.Add(nameof(Unk_197));
                    OnPropertyChanged(nameof(Unk_197));
                }
            }

            public const int lastSortIndex = 950;

            public static ObservableMhwStructCollection<Monster_Common_Params_6_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Monster_Common_Params_6_>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Monster_Common_Params_6_ LoadData(BinaryReader reader, ulong i) {
                var data = new Monster_Common_Params_6_();
                data.Index = i;
                data.Unk_180_raw = reader.ReadUInt32();
                data.Unk_181_raw = reader.ReadSingle();
                data.Unk_182_raw = reader.ReadSingle();
                data.Unk_183_raw = reader.ReadInt32();
                data.Unk_184_raw = reader.ReadInt32();
                data.Unk_185_raw = reader.ReadSingle();
                data.Unk_186_raw = reader.ReadSingle();
                data.Unk_187_raw = reader.ReadUInt32();
                data.Unk_188_raw = reader.ReadSingle();
                data.Unk_189_raw = reader.ReadSingle();
                data.Unk_190_raw = reader.ReadSingle();
                data.Unk_191_raw = reader.ReadSingle();
                data.Unk_192_raw = reader.ReadSingle();
                data.Unk_193_raw = reader.ReadSingle();
                data.Unk_194_raw = reader.ReadSingle();
                data.Unk_195_raw = reader.ReadSingle();
                data.Unk_196_raw = reader.ReadSingle();
                data.Unk_197_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_180_raw);
                writer.Write(Unk_181_raw);
                writer.Write(Unk_182_raw);
                writer.Write(Unk_183_raw);
                writer.Write(Unk_184_raw);
                writer.Write(Unk_185_raw);
                writer.Write(Unk_186_raw);
                writer.Write(Unk_187_raw);
                writer.Write(Unk_188_raw);
                writer.Write(Unk_189_raw);
                writer.Write(Unk_190_raw);
                writer.Write(Unk_191_raw);
                writer.Write(Unk_192_raw);
                writer.Write(Unk_193_raw);
                writer.Write(Unk_194_raw);
                writer.Write(Unk_195_raw);
                writer.Write(Unk_196_raw);
                writer.Write(Unk_197_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Unk 180", "Unk_180"),
                    new MultiStructItemCustomView(this, "Unk 181", "Unk_181"),
                    new MultiStructItemCustomView(this, "Unk 182", "Unk_182"),
                    new MultiStructItemCustomView(this, "Unk 183", "Unk_183"),
                    new MultiStructItemCustomView(this, "Unk 184", "Unk_184"),
                    new MultiStructItemCustomView(this, "Unk 185", "Unk_185"),
                    new MultiStructItemCustomView(this, "Unk 186", "Unk_186"),
                    new MultiStructItemCustomView(this, "Unk 187", "Unk_187"),
                    new MultiStructItemCustomView(this, "Unk 188", "Unk_188"),
                    new MultiStructItemCustomView(this, "Unk 189", "Unk_189"),
                    new MultiStructItemCustomView(this, "Unk 190", "Unk_190"),
                    new MultiStructItemCustomView(this, "Unk 191", "Unk_191"),
                    new MultiStructItemCustomView(this, "Unk 192", "Unk_192"),
                    new MultiStructItemCustomView(this, "Unk 193", "Unk_193"),
                    new MultiStructItemCustomView(this, "Unk 194", "Unk_194"),
                    new MultiStructItemCustomView(this, "Unk 195", "Unk_195"),
                    new MultiStructItemCustomView(this, "Unk 196", "Unk_196"),
                    new MultiStructItemCustomView(this, "Unk 197", "Unk_197"),
                };
            }
        }

        public partial class Unk_Arr_3 : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 8;
            public const string GridName = "Unk Arr 3";

            protected int Unk_1_raw;
            public const string Unk_1_displayName = "Unk 1";
            public const int Unk_1_sortIndex = 50;
            [SortOrder(Unk_1_sortIndex)]
            [DisplayName(Unk_1_displayName)]
            public virtual int Unk_1 {
                get => Unk_1_raw;
                set {
                    if (Unk_1_raw == value) return;
                    Unk_1_raw = value;
                    ChangedItems.Add(nameof(Unk_1));
                    OnPropertyChanged(nameof(Unk_1));
                }
            }

            protected int Unk_2_raw;
            public const string Unk_2_displayName = "Unk 2";
            public const int Unk_2_sortIndex = 100;
            [SortOrder(Unk_2_sortIndex)]
            [DisplayName(Unk_2_displayName)]
            public virtual int Unk_2 {
                get => Unk_2_raw;
                set {
                    if (Unk_2_raw == value) return;
                    Unk_2_raw = value;
                    ChangedItems.Add(nameof(Unk_2));
                    OnPropertyChanged(nameof(Unk_2));
                }
            }

            public const int lastSortIndex = 150;

            public static ObservableMhwStructCollection<Unk_Arr_3> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Unk_Arr_3>();
                var count = 8UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Unk_Arr_3 LoadData(BinaryReader reader, ulong i) {
                var data = new Unk_Arr_3();
                data.Index = i;
                data.Unk_1_raw = reader.ReadInt32();
                data.Unk_2_raw = reader.ReadInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_1_raw);
                writer.Write(Unk_2_raw);
            }
        }

        public partial class Monster_Common_Params_7_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Monster Common Params (7)";

            protected uint Unk_198_raw;
            public const string Unk_198_displayName = "Unk 198";
            public const int Unk_198_sortIndex = 50;
            [SortOrder(Unk_198_sortIndex)]
            [DisplayName(Unk_198_displayName)]
            public virtual uint Unk_198 {
                get => Unk_198_raw;
                set {
                    if (Unk_198_raw == value) return;
                    Unk_198_raw = value;
                    ChangedItems.Add(nameof(Unk_198));
                    OnPropertyChanged(nameof(Unk_198));
                }
            }

            protected uint Unk_Arr_4_Count_raw;
            public const string Unk_Arr_4_Count_displayName = "Unk Arr 4 Count";
            public const int Unk_Arr_4_Count_sortIndex = 100;
            [SortOrder(Unk_Arr_4_Count_sortIndex)]
            [DisplayName(Unk_Arr_4_Count_displayName)]
            public virtual uint Unk_Arr_4_Count {
                get => Unk_Arr_4_Count_raw;
                set {
                    if (Unk_Arr_4_Count_raw == value) return;
                    Unk_Arr_4_Count_raw = value;
                    ChangedItems.Add(nameof(Unk_Arr_4_Count));
                    OnPropertyChanged(nameof(Unk_Arr_4_Count));
                }
            }

            public const int lastSortIndex = 150;

            public static ObservableMhwStructCollection<Monster_Common_Params_7_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Monster_Common_Params_7_>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Monster_Common_Params_7_ LoadData(BinaryReader reader, ulong i) {
                var data = new Monster_Common_Params_7_();
                data.Index = i;
                data.Unk_198_raw = reader.ReadUInt32();
                data.Unk_Arr_4_Count_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_198_raw);
                writer.Write(Unk_Arr_4_Count_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Unk 198", "Unk_198"),
                    new MultiStructItemCustomView(this, "Unk Arr 4 Count", "Unk_Arr_4_Count"),
                };
            }
        }

        public partial class Unk_Arr_4 : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 0;
            public const string GridName = "Unk Arr 4";
            public const bool IsAddingAllowed = true;

            [SortOrder(-1)]
            [IsReadOnly]
            [DisplayName("X")]
            public string Delete => "X";

            protected int Unk_1_raw;
            public const string Unk_1_displayName = "Unk 1";
            public const int Unk_1_sortIndex = 50;
            [SortOrder(Unk_1_sortIndex)]
            [DisplayName(Unk_1_displayName)]
            public virtual int Unk_1 {
                get => Unk_1_raw;
                set {
                    if (Unk_1_raw == value) return;
                    Unk_1_raw = value;
                    ChangedItems.Add(nameof(Unk_1));
                    OnPropertyChanged(nameof(Unk_1));
                }
            }

            protected uint Header_raw;
            public const string Header_displayName = "Header";
            public const int Header_sortIndex = 100;
            [SortOrder(Header_sortIndex)]
            [DisplayName(Header_displayName)]
            public virtual uint Header {
                get => Header_raw;
                set {
                    if (Header_raw == value) return;
                    Header_raw = value;
                    ChangedItems.Add(nameof(Header));
                    OnPropertyChanged(nameof(Header));
                }
            }

            public const int lastSortIndex = 150;

            public static ObservableMhwStructCollection<Unk_Arr_4> LoadData(BinaryReader reader, ObservableMhwStructCollection<Monster_Common_Params_7_> lastStruct) {
                var list = new ObservableMhwStructCollection<Unk_Arr_4>();
                var countTarget = (Monster_Common_Params_7_) lastStruct.Last();
                var count = (ulong) countTarget.Unk_Arr_4_Count;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Unk_Arr_4 LoadData(BinaryReader reader, ulong i) {
                var data = new Unk_Arr_4();
                data.Index = i;
                data.Unk_1_raw = reader.ReadInt32();
                data.Header_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_1_raw);
                writer.Write(Header_raw);
            }
        }

        public partial class Monster_Common_Params_8_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Monster Common Params (8)";

            protected uint Unk_199_raw;
            public const string Unk_199_displayName = "Unk 199";
            public const int Unk_199_sortIndex = 50;
            [SortOrder(Unk_199_sortIndex)]
            [DisplayName(Unk_199_displayName)]
            public virtual uint Unk_199 {
                get => Unk_199_raw;
                set {
                    if (Unk_199_raw == value) return;
                    Unk_199_raw = value;
                    ChangedItems.Add(nameof(Unk_199));
                    OnPropertyChanged(nameof(Unk_199));
                }
            }

            protected uint Unk_200_raw;
            public const string Unk_200_displayName = "Unk 200";
            public const int Unk_200_sortIndex = 100;
            [SortOrder(Unk_200_sortIndex)]
            [DisplayName(Unk_200_displayName)]
            public virtual uint Unk_200 {
                get => Unk_200_raw;
                set {
                    if (Unk_200_raw == value) return;
                    Unk_200_raw = value;
                    ChangedItems.Add(nameof(Unk_200));
                    OnPropertyChanged(nameof(Unk_200));
                }
            }

            protected uint Unk_201_raw;
            public const string Unk_201_displayName = "Unk 201";
            public const int Unk_201_sortIndex = 150;
            [SortOrder(Unk_201_sortIndex)]
            [DisplayName(Unk_201_displayName)]
            public virtual uint Unk_201 {
                get => Unk_201_raw;
                set {
                    if (Unk_201_raw == value) return;
                    Unk_201_raw = value;
                    ChangedItems.Add(nameof(Unk_201));
                    OnPropertyChanged(nameof(Unk_201));
                }
            }

            protected uint Unk_202_raw;
            public const string Unk_202_displayName = "Unk 202";
            public const int Unk_202_sortIndex = 200;
            [SortOrder(Unk_202_sortIndex)]
            [DisplayName(Unk_202_displayName)]
            public virtual uint Unk_202 {
                get => Unk_202_raw;
                set {
                    if (Unk_202_raw == value) return;
                    Unk_202_raw = value;
                    ChangedItems.Add(nameof(Unk_202));
                    OnPropertyChanged(nameof(Unk_202));
                }
            }

            protected uint Unk_203_raw;
            public const string Unk_203_displayName = "Unk 203";
            public const int Unk_203_sortIndex = 250;
            [SortOrder(Unk_203_sortIndex)]
            [DisplayName(Unk_203_displayName)]
            public virtual uint Unk_203 {
                get => Unk_203_raw;
                set {
                    if (Unk_203_raw == value) return;
                    Unk_203_raw = value;
                    ChangedItems.Add(nameof(Unk_203));
                    OnPropertyChanged(nameof(Unk_203));
                }
            }

            protected uint Unk_204_raw;
            public const string Unk_204_displayName = "Unk 204";
            public const int Unk_204_sortIndex = 300;
            [SortOrder(Unk_204_sortIndex)]
            [DisplayName(Unk_204_displayName)]
            public virtual uint Unk_204 {
                get => Unk_204_raw;
                set {
                    if (Unk_204_raw == value) return;
                    Unk_204_raw = value;
                    ChangedItems.Add(nameof(Unk_204));
                    OnPropertyChanged(nameof(Unk_204));
                }
            }

            protected uint Unk_205_raw;
            public const string Unk_205_displayName = "Unk 205";
            public const int Unk_205_sortIndex = 350;
            [SortOrder(Unk_205_sortIndex)]
            [DisplayName(Unk_205_displayName)]
            public virtual uint Unk_205 {
                get => Unk_205_raw;
                set {
                    if (Unk_205_raw == value) return;
                    Unk_205_raw = value;
                    ChangedItems.Add(nameof(Unk_205));
                    OnPropertyChanged(nameof(Unk_205));
                }
            }

            protected uint Unk_206_raw;
            public const string Unk_206_displayName = "Unk 206";
            public const int Unk_206_sortIndex = 400;
            [SortOrder(Unk_206_sortIndex)]
            [DisplayName(Unk_206_displayName)]
            public virtual uint Unk_206 {
                get => Unk_206_raw;
                set {
                    if (Unk_206_raw == value) return;
                    Unk_206_raw = value;
                    ChangedItems.Add(nameof(Unk_206));
                    OnPropertyChanged(nameof(Unk_206));
                }
            }

            public const int lastSortIndex = 450;

            public static ObservableMhwStructCollection<Monster_Common_Params_8_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Monster_Common_Params_8_>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Monster_Common_Params_8_ LoadData(BinaryReader reader, ulong i) {
                var data = new Monster_Common_Params_8_();
                data.Index = i;
                data.Unk_199_raw = reader.ReadUInt32();
                data.Unk_200_raw = reader.ReadUInt32();
                data.Unk_201_raw = reader.ReadUInt32();
                data.Unk_202_raw = reader.ReadUInt32();
                data.Unk_203_raw = reader.ReadUInt32();
                data.Unk_204_raw = reader.ReadUInt32();
                data.Unk_205_raw = reader.ReadUInt32();
                data.Unk_206_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_199_raw);
                writer.Write(Unk_200_raw);
                writer.Write(Unk_201_raw);
                writer.Write(Unk_202_raw);
                writer.Write(Unk_203_raw);
                writer.Write(Unk_204_raw);
                writer.Write(Unk_205_raw);
                writer.Write(Unk_206_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Unk 199", "Unk_199"),
                    new MultiStructItemCustomView(this, "Unk 200", "Unk_200"),
                    new MultiStructItemCustomView(this, "Unk 201", "Unk_201"),
                    new MultiStructItemCustomView(this, "Unk 202", "Unk_202"),
                    new MultiStructItemCustomView(this, "Unk 203", "Unk_203"),
                    new MultiStructItemCustomView(this, "Unk 204", "Unk_204"),
                    new MultiStructItemCustomView(this, "Unk 205", "Unk_205"),
                    new MultiStructItemCustomView(this, "Unk 206", "Unk_206"),
                };
            }
        }

        public partial class Monster_Common_Params_9_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Monster Common Params (9)";

            protected uint Header_raw;
            public const string Header_displayName = "Header";
            public const int Header_sortIndex = 50;
            [SortOrder(Header_sortIndex)]
            [DisplayName(Header_displayName)]
            public virtual uint Header {
                get => Header_raw;
                set {
                    if (Header_raw == value) return;
                    Header_raw = value;
                    ChangedItems.Add(nameof(Header));
                    OnPropertyChanged(nameof(Header));
                }
            }

            protected uint Unk_207_raw;
            public const string Unk_207_displayName = "Unk 207";
            public const int Unk_207_sortIndex = 100;
            [SortOrder(Unk_207_sortIndex)]
            [DisplayName(Unk_207_displayName)]
            public virtual uint Unk_207 {
                get => Unk_207_raw;
                set {
                    if (Unk_207_raw == value) return;
                    Unk_207_raw = value;
                    ChangedItems.Add(nameof(Unk_207));
                    OnPropertyChanged(nameof(Unk_207));
                }
            }

            protected uint Unk_208_raw;
            public const string Unk_208_displayName = "Unk 208";
            public const int Unk_208_sortIndex = 150;
            [SortOrder(Unk_208_sortIndex)]
            [DisplayName(Unk_208_displayName)]
            public virtual uint Unk_208 {
                get => Unk_208_raw;
                set {
                    if (Unk_208_raw == value) return;
                    Unk_208_raw = value;
                    ChangedItems.Add(nameof(Unk_208));
                    OnPropertyChanged(nameof(Unk_208));
                }
            }

            protected uint Unk_209_raw;
            public const string Unk_209_displayName = "Unk 209";
            public const int Unk_209_sortIndex = 200;
            [SortOrder(Unk_209_sortIndex)]
            [DisplayName(Unk_209_displayName)]
            public virtual uint Unk_209 {
                get => Unk_209_raw;
                set {
                    if (Unk_209_raw == value) return;
                    Unk_209_raw = value;
                    ChangedItems.Add(nameof(Unk_209));
                    OnPropertyChanged(nameof(Unk_209));
                }
            }

            protected uint Unk_210_raw;
            public const string Unk_210_displayName = "Unk 210";
            public const int Unk_210_sortIndex = 250;
            [SortOrder(Unk_210_sortIndex)]
            [DisplayName(Unk_210_displayName)]
            public virtual uint Unk_210 {
                get => Unk_210_raw;
                set {
                    if (Unk_210_raw == value) return;
                    Unk_210_raw = value;
                    ChangedItems.Add(nameof(Unk_210));
                    OnPropertyChanged(nameof(Unk_210));
                }
            }

            protected uint Unk_211_raw;
            public const string Unk_211_displayName = "Unk 211";
            public const int Unk_211_sortIndex = 300;
            [SortOrder(Unk_211_sortIndex)]
            [DisplayName(Unk_211_displayName)]
            public virtual uint Unk_211 {
                get => Unk_211_raw;
                set {
                    if (Unk_211_raw == value) return;
                    Unk_211_raw = value;
                    ChangedItems.Add(nameof(Unk_211));
                    OnPropertyChanged(nameof(Unk_211));
                }
            }

            protected uint Unk_212_raw;
            public const string Unk_212_displayName = "Unk 212";
            public const int Unk_212_sortIndex = 350;
            [SortOrder(Unk_212_sortIndex)]
            [DisplayName(Unk_212_displayName)]
            public virtual uint Unk_212 {
                get => Unk_212_raw;
                set {
                    if (Unk_212_raw == value) return;
                    Unk_212_raw = value;
                    ChangedItems.Add(nameof(Unk_212));
                    OnPropertyChanged(nameof(Unk_212));
                }
            }

            protected uint Unk_213_raw;
            public const string Unk_213_displayName = "Unk 213";
            public const int Unk_213_sortIndex = 400;
            [SortOrder(Unk_213_sortIndex)]
            [DisplayName(Unk_213_displayName)]
            public virtual uint Unk_213 {
                get => Unk_213_raw;
                set {
                    if (Unk_213_raw == value) return;
                    Unk_213_raw = value;
                    ChangedItems.Add(nameof(Unk_213));
                    OnPropertyChanged(nameof(Unk_213));
                }
            }

            protected uint Unk_214_raw;
            public const string Unk_214_displayName = "Unk 214";
            public const int Unk_214_sortIndex = 450;
            [SortOrder(Unk_214_sortIndex)]
            [DisplayName(Unk_214_displayName)]
            public virtual uint Unk_214 {
                get => Unk_214_raw;
                set {
                    if (Unk_214_raw == value) return;
                    Unk_214_raw = value;
                    ChangedItems.Add(nameof(Unk_214));
                    OnPropertyChanged(nameof(Unk_214));
                }
            }

            protected uint Unk_215_raw;
            public const string Unk_215_displayName = "Unk 215";
            public const int Unk_215_sortIndex = 500;
            [SortOrder(Unk_215_sortIndex)]
            [DisplayName(Unk_215_displayName)]
            public virtual uint Unk_215 {
                get => Unk_215_raw;
                set {
                    if (Unk_215_raw == value) return;
                    Unk_215_raw = value;
                    ChangedItems.Add(nameof(Unk_215));
                    OnPropertyChanged(nameof(Unk_215));
                }
            }

            protected uint Unk_216_raw;
            public const string Unk_216_displayName = "Unk 216";
            public const int Unk_216_sortIndex = 550;
            [SortOrder(Unk_216_sortIndex)]
            [DisplayName(Unk_216_displayName)]
            public virtual uint Unk_216 {
                get => Unk_216_raw;
                set {
                    if (Unk_216_raw == value) return;
                    Unk_216_raw = value;
                    ChangedItems.Add(nameof(Unk_216));
                    OnPropertyChanged(nameof(Unk_216));
                }
            }

            protected uint Unk_217_raw;
            public const string Unk_217_displayName = "Unk 217";
            public const int Unk_217_sortIndex = 600;
            [SortOrder(Unk_217_sortIndex)]
            [DisplayName(Unk_217_displayName)]
            public virtual uint Unk_217 {
                get => Unk_217_raw;
                set {
                    if (Unk_217_raw == value) return;
                    Unk_217_raw = value;
                    ChangedItems.Add(nameof(Unk_217));
                    OnPropertyChanged(nameof(Unk_217));
                }
            }

            protected uint Unk_218_raw;
            public const string Unk_218_displayName = "Unk 218";
            public const int Unk_218_sortIndex = 650;
            [SortOrder(Unk_218_sortIndex)]
            [DisplayName(Unk_218_displayName)]
            public virtual uint Unk_218 {
                get => Unk_218_raw;
                set {
                    if (Unk_218_raw == value) return;
                    Unk_218_raw = value;
                    ChangedItems.Add(nameof(Unk_218));
                    OnPropertyChanged(nameof(Unk_218));
                }
            }

            protected uint Unk_219_raw;
            public const string Unk_219_displayName = "Unk 219";
            public const int Unk_219_sortIndex = 700;
            [SortOrder(Unk_219_sortIndex)]
            [DisplayName(Unk_219_displayName)]
            public virtual uint Unk_219 {
                get => Unk_219_raw;
                set {
                    if (Unk_219_raw == value) return;
                    Unk_219_raw = value;
                    ChangedItems.Add(nameof(Unk_219));
                    OnPropertyChanged(nameof(Unk_219));
                }
            }

            protected uint Unk_220_raw;
            public const string Unk_220_displayName = "Unk 220";
            public const int Unk_220_sortIndex = 750;
            [SortOrder(Unk_220_sortIndex)]
            [DisplayName(Unk_220_displayName)]
            public virtual uint Unk_220 {
                get => Unk_220_raw;
                set {
                    if (Unk_220_raw == value) return;
                    Unk_220_raw = value;
                    ChangedItems.Add(nameof(Unk_220));
                    OnPropertyChanged(nameof(Unk_220));
                }
            }

            protected uint Unk_221_raw;
            public const string Unk_221_displayName = "Unk 221";
            public const int Unk_221_sortIndex = 800;
            [SortOrder(Unk_221_sortIndex)]
            [DisplayName(Unk_221_displayName)]
            public virtual uint Unk_221 {
                get => Unk_221_raw;
                set {
                    if (Unk_221_raw == value) return;
                    Unk_221_raw = value;
                    ChangedItems.Add(nameof(Unk_221));
                    OnPropertyChanged(nameof(Unk_221));
                }
            }

            protected uint Unk_222_raw;
            public const string Unk_222_displayName = "Unk 222";
            public const int Unk_222_sortIndex = 850;
            [SortOrder(Unk_222_sortIndex)]
            [DisplayName(Unk_222_displayName)]
            public virtual uint Unk_222 {
                get => Unk_222_raw;
                set {
                    if (Unk_222_raw == value) return;
                    Unk_222_raw = value;
                    ChangedItems.Add(nameof(Unk_222));
                    OnPropertyChanged(nameof(Unk_222));
                }
            }

            protected uint Unk_223_raw;
            public const string Unk_223_displayName = "Unk 223";
            public const int Unk_223_sortIndex = 900;
            [SortOrder(Unk_223_sortIndex)]
            [DisplayName(Unk_223_displayName)]
            public virtual uint Unk_223 {
                get => Unk_223_raw;
                set {
                    if (Unk_223_raw == value) return;
                    Unk_223_raw = value;
                    ChangedItems.Add(nameof(Unk_223));
                    OnPropertyChanged(nameof(Unk_223));
                }
            }

            protected uint Unk_224_raw;
            public const string Unk_224_displayName = "Unk 224";
            public const int Unk_224_sortIndex = 950;
            [SortOrder(Unk_224_sortIndex)]
            [DisplayName(Unk_224_displayName)]
            public virtual uint Unk_224 {
                get => Unk_224_raw;
                set {
                    if (Unk_224_raw == value) return;
                    Unk_224_raw = value;
                    ChangedItems.Add(nameof(Unk_224));
                    OnPropertyChanged(nameof(Unk_224));
                }
            }

            protected uint Unk_225_raw;
            public const string Unk_225_displayName = "Unk 225";
            public const int Unk_225_sortIndex = 1000;
            [SortOrder(Unk_225_sortIndex)]
            [DisplayName(Unk_225_displayName)]
            public virtual uint Unk_225 {
                get => Unk_225_raw;
                set {
                    if (Unk_225_raw == value) return;
                    Unk_225_raw = value;
                    ChangedItems.Add(nameof(Unk_225));
                    OnPropertyChanged(nameof(Unk_225));
                }
            }

            protected uint Unk_226_raw;
            public const string Unk_226_displayName = "Unk 226";
            public const int Unk_226_sortIndex = 1050;
            [SortOrder(Unk_226_sortIndex)]
            [DisplayName(Unk_226_displayName)]
            public virtual uint Unk_226 {
                get => Unk_226_raw;
                set {
                    if (Unk_226_raw == value) return;
                    Unk_226_raw = value;
                    ChangedItems.Add(nameof(Unk_226));
                    OnPropertyChanged(nameof(Unk_226));
                }
            }

            protected uint Unk_227_raw;
            public const string Unk_227_displayName = "Unk 227";
            public const int Unk_227_sortIndex = 1100;
            [SortOrder(Unk_227_sortIndex)]
            [DisplayName(Unk_227_displayName)]
            public virtual uint Unk_227 {
                get => Unk_227_raw;
                set {
                    if (Unk_227_raw == value) return;
                    Unk_227_raw = value;
                    ChangedItems.Add(nameof(Unk_227));
                    OnPropertyChanged(nameof(Unk_227));
                }
            }

            protected uint Unk_228_raw;
            public const string Unk_228_displayName = "Unk 228";
            public const int Unk_228_sortIndex = 1150;
            [SortOrder(Unk_228_sortIndex)]
            [DisplayName(Unk_228_displayName)]
            public virtual uint Unk_228 {
                get => Unk_228_raw;
                set {
                    if (Unk_228_raw == value) return;
                    Unk_228_raw = value;
                    ChangedItems.Add(nameof(Unk_228));
                    OnPropertyChanged(nameof(Unk_228));
                }
            }

            protected uint Unk_229_raw;
            public const string Unk_229_displayName = "Unk 229";
            public const int Unk_229_sortIndex = 1200;
            [SortOrder(Unk_229_sortIndex)]
            [DisplayName(Unk_229_displayName)]
            public virtual uint Unk_229 {
                get => Unk_229_raw;
                set {
                    if (Unk_229_raw == value) return;
                    Unk_229_raw = value;
                    ChangedItems.Add(nameof(Unk_229));
                    OnPropertyChanged(nameof(Unk_229));
                }
            }

            protected uint Unk_230_raw;
            public const string Unk_230_displayName = "Unk 230";
            public const int Unk_230_sortIndex = 1250;
            [SortOrder(Unk_230_sortIndex)]
            [DisplayName(Unk_230_displayName)]
            public virtual uint Unk_230 {
                get => Unk_230_raw;
                set {
                    if (Unk_230_raw == value) return;
                    Unk_230_raw = value;
                    ChangedItems.Add(nameof(Unk_230));
                    OnPropertyChanged(nameof(Unk_230));
                }
            }

            protected uint Unk_231_raw;
            public const string Unk_231_displayName = "Unk 231";
            public const int Unk_231_sortIndex = 1300;
            [SortOrder(Unk_231_sortIndex)]
            [DisplayName(Unk_231_displayName)]
            public virtual uint Unk_231 {
                get => Unk_231_raw;
                set {
                    if (Unk_231_raw == value) return;
                    Unk_231_raw = value;
                    ChangedItems.Add(nameof(Unk_231));
                    OnPropertyChanged(nameof(Unk_231));
                }
            }

            protected uint Unk_232_raw;
            public const string Unk_232_displayName = "Unk 232";
            public const int Unk_232_sortIndex = 1350;
            [SortOrder(Unk_232_sortIndex)]
            [DisplayName(Unk_232_displayName)]
            public virtual uint Unk_232 {
                get => Unk_232_raw;
                set {
                    if (Unk_232_raw == value) return;
                    Unk_232_raw = value;
                    ChangedItems.Add(nameof(Unk_232));
                    OnPropertyChanged(nameof(Unk_232));
                }
            }

            protected uint Unk_233_raw;
            public const string Unk_233_displayName = "Unk 233";
            public const int Unk_233_sortIndex = 1400;
            [SortOrder(Unk_233_sortIndex)]
            [DisplayName(Unk_233_displayName)]
            public virtual uint Unk_233 {
                get => Unk_233_raw;
                set {
                    if (Unk_233_raw == value) return;
                    Unk_233_raw = value;
                    ChangedItems.Add(nameof(Unk_233));
                    OnPropertyChanged(nameof(Unk_233));
                }
            }

            protected uint Unk_234_raw;
            public const string Unk_234_displayName = "Unk 234";
            public const int Unk_234_sortIndex = 1450;
            [SortOrder(Unk_234_sortIndex)]
            [DisplayName(Unk_234_displayName)]
            public virtual uint Unk_234 {
                get => Unk_234_raw;
                set {
                    if (Unk_234_raw == value) return;
                    Unk_234_raw = value;
                    ChangedItems.Add(nameof(Unk_234));
                    OnPropertyChanged(nameof(Unk_234));
                }
            }

            protected uint Unk_235_raw;
            public const string Unk_235_displayName = "Unk 235";
            public const int Unk_235_sortIndex = 1500;
            [SortOrder(Unk_235_sortIndex)]
            [DisplayName(Unk_235_displayName)]
            public virtual uint Unk_235 {
                get => Unk_235_raw;
                set {
                    if (Unk_235_raw == value) return;
                    Unk_235_raw = value;
                    ChangedItems.Add(nameof(Unk_235));
                    OnPropertyChanged(nameof(Unk_235));
                }
            }

            protected uint Unk_236_raw;
            public const string Unk_236_displayName = "Unk 236";
            public const int Unk_236_sortIndex = 1550;
            [SortOrder(Unk_236_sortIndex)]
            [DisplayName(Unk_236_displayName)]
            public virtual uint Unk_236 {
                get => Unk_236_raw;
                set {
                    if (Unk_236_raw == value) return;
                    Unk_236_raw = value;
                    ChangedItems.Add(nameof(Unk_236));
                    OnPropertyChanged(nameof(Unk_236));
                }
            }

            protected uint Unk_237_raw;
            public const string Unk_237_displayName = "Unk 237";
            public const int Unk_237_sortIndex = 1600;
            [SortOrder(Unk_237_sortIndex)]
            [DisplayName(Unk_237_displayName)]
            public virtual uint Unk_237 {
                get => Unk_237_raw;
                set {
                    if (Unk_237_raw == value) return;
                    Unk_237_raw = value;
                    ChangedItems.Add(nameof(Unk_237));
                    OnPropertyChanged(nameof(Unk_237));
                }
            }

            protected uint Unk_238_raw;
            public const string Unk_238_displayName = "Unk 238";
            public const int Unk_238_sortIndex = 1650;
            [SortOrder(Unk_238_sortIndex)]
            [DisplayName(Unk_238_displayName)]
            public virtual uint Unk_238 {
                get => Unk_238_raw;
                set {
                    if (Unk_238_raw == value) return;
                    Unk_238_raw = value;
                    ChangedItems.Add(nameof(Unk_238));
                    OnPropertyChanged(nameof(Unk_238));
                }
            }

            protected uint Unk_239_raw;
            public const string Unk_239_displayName = "Unk 239";
            public const int Unk_239_sortIndex = 1700;
            [SortOrder(Unk_239_sortIndex)]
            [DisplayName(Unk_239_displayName)]
            public virtual uint Unk_239 {
                get => Unk_239_raw;
                set {
                    if (Unk_239_raw == value) return;
                    Unk_239_raw = value;
                    ChangedItems.Add(nameof(Unk_239));
                    OnPropertyChanged(nameof(Unk_239));
                }
            }

            protected uint Unk_240_raw;
            public const string Unk_240_displayName = "Unk 240";
            public const int Unk_240_sortIndex = 1750;
            [SortOrder(Unk_240_sortIndex)]
            [DisplayName(Unk_240_displayName)]
            public virtual uint Unk_240 {
                get => Unk_240_raw;
                set {
                    if (Unk_240_raw == value) return;
                    Unk_240_raw = value;
                    ChangedItems.Add(nameof(Unk_240));
                    OnPropertyChanged(nameof(Unk_240));
                }
            }

            protected uint Unk_241_raw;
            public const string Unk_241_displayName = "Unk 241";
            public const int Unk_241_sortIndex = 1800;
            [SortOrder(Unk_241_sortIndex)]
            [DisplayName(Unk_241_displayName)]
            public virtual uint Unk_241 {
                get => Unk_241_raw;
                set {
                    if (Unk_241_raw == value) return;
                    Unk_241_raw = value;
                    ChangedItems.Add(nameof(Unk_241));
                    OnPropertyChanged(nameof(Unk_241));
                }
            }

            protected uint Unk_242_raw;
            public const string Unk_242_displayName = "Unk 242";
            public const int Unk_242_sortIndex = 1850;
            [SortOrder(Unk_242_sortIndex)]
            [DisplayName(Unk_242_displayName)]
            public virtual uint Unk_242 {
                get => Unk_242_raw;
                set {
                    if (Unk_242_raw == value) return;
                    Unk_242_raw = value;
                    ChangedItems.Add(nameof(Unk_242));
                    OnPropertyChanged(nameof(Unk_242));
                }
            }

            protected uint Unk_243_raw;
            public const string Unk_243_displayName = "Unk 243";
            public const int Unk_243_sortIndex = 1900;
            [SortOrder(Unk_243_sortIndex)]
            [DisplayName(Unk_243_displayName)]
            public virtual uint Unk_243 {
                get => Unk_243_raw;
                set {
                    if (Unk_243_raw == value) return;
                    Unk_243_raw = value;
                    ChangedItems.Add(nameof(Unk_243));
                    OnPropertyChanged(nameof(Unk_243));
                }
            }

            protected uint Unk_244_raw;
            public const string Unk_244_displayName = "Unk 244";
            public const int Unk_244_sortIndex = 1950;
            [SortOrder(Unk_244_sortIndex)]
            [DisplayName(Unk_244_displayName)]
            public virtual uint Unk_244 {
                get => Unk_244_raw;
                set {
                    if (Unk_244_raw == value) return;
                    Unk_244_raw = value;
                    ChangedItems.Add(nameof(Unk_244));
                    OnPropertyChanged(nameof(Unk_244));
                }
            }

            protected uint Unk_245_raw;
            public const string Unk_245_displayName = "Unk 245";
            public const int Unk_245_sortIndex = 2000;
            [SortOrder(Unk_245_sortIndex)]
            [DisplayName(Unk_245_displayName)]
            public virtual uint Unk_245 {
                get => Unk_245_raw;
                set {
                    if (Unk_245_raw == value) return;
                    Unk_245_raw = value;
                    ChangedItems.Add(nameof(Unk_245));
                    OnPropertyChanged(nameof(Unk_245));
                }
            }

            protected uint Unk_246_raw;
            public const string Unk_246_displayName = "Unk 246";
            public const int Unk_246_sortIndex = 2050;
            [SortOrder(Unk_246_sortIndex)]
            [DisplayName(Unk_246_displayName)]
            public virtual uint Unk_246 {
                get => Unk_246_raw;
                set {
                    if (Unk_246_raw == value) return;
                    Unk_246_raw = value;
                    ChangedItems.Add(nameof(Unk_246));
                    OnPropertyChanged(nameof(Unk_246));
                }
            }

            protected uint Unk_247_raw;
            public const string Unk_247_displayName = "Unk 247";
            public const int Unk_247_sortIndex = 2100;
            [SortOrder(Unk_247_sortIndex)]
            [DisplayName(Unk_247_displayName)]
            public virtual uint Unk_247 {
                get => Unk_247_raw;
                set {
                    if (Unk_247_raw == value) return;
                    Unk_247_raw = value;
                    ChangedItems.Add(nameof(Unk_247));
                    OnPropertyChanged(nameof(Unk_247));
                }
            }

            protected uint Unk_248_raw;
            public const string Unk_248_displayName = "Unk 248";
            public const int Unk_248_sortIndex = 2150;
            [SortOrder(Unk_248_sortIndex)]
            [DisplayName(Unk_248_displayName)]
            public virtual uint Unk_248 {
                get => Unk_248_raw;
                set {
                    if (Unk_248_raw == value) return;
                    Unk_248_raw = value;
                    ChangedItems.Add(nameof(Unk_248));
                    OnPropertyChanged(nameof(Unk_248));
                }
            }

            protected uint Unk_249_raw;
            public const string Unk_249_displayName = "Unk 249";
            public const int Unk_249_sortIndex = 2200;
            [SortOrder(Unk_249_sortIndex)]
            [DisplayName(Unk_249_displayName)]
            public virtual uint Unk_249 {
                get => Unk_249_raw;
                set {
                    if (Unk_249_raw == value) return;
                    Unk_249_raw = value;
                    ChangedItems.Add(nameof(Unk_249));
                    OnPropertyChanged(nameof(Unk_249));
                }
            }

            protected uint Unk_250_raw;
            public const string Unk_250_displayName = "Unk 250";
            public const int Unk_250_sortIndex = 2250;
            [SortOrder(Unk_250_sortIndex)]
            [DisplayName(Unk_250_displayName)]
            public virtual uint Unk_250 {
                get => Unk_250_raw;
                set {
                    if (Unk_250_raw == value) return;
                    Unk_250_raw = value;
                    ChangedItems.Add(nameof(Unk_250));
                    OnPropertyChanged(nameof(Unk_250));
                }
            }

            protected uint Unk_251_raw;
            public const string Unk_251_displayName = "Unk 251";
            public const int Unk_251_sortIndex = 2300;
            [SortOrder(Unk_251_sortIndex)]
            [DisplayName(Unk_251_displayName)]
            public virtual uint Unk_251 {
                get => Unk_251_raw;
                set {
                    if (Unk_251_raw == value) return;
                    Unk_251_raw = value;
                    ChangedItems.Add(nameof(Unk_251));
                    OnPropertyChanged(nameof(Unk_251));
                }
            }

            protected uint Unk_252_raw;
            public const string Unk_252_displayName = "Unk 252";
            public const int Unk_252_sortIndex = 2350;
            [SortOrder(Unk_252_sortIndex)]
            [DisplayName(Unk_252_displayName)]
            public virtual uint Unk_252 {
                get => Unk_252_raw;
                set {
                    if (Unk_252_raw == value) return;
                    Unk_252_raw = value;
                    ChangedItems.Add(nameof(Unk_252));
                    OnPropertyChanged(nameof(Unk_252));
                }
            }

            protected uint Unk_253_raw;
            public const string Unk_253_displayName = "Unk 253";
            public const int Unk_253_sortIndex = 2400;
            [SortOrder(Unk_253_sortIndex)]
            [DisplayName(Unk_253_displayName)]
            public virtual uint Unk_253 {
                get => Unk_253_raw;
                set {
                    if (Unk_253_raw == value) return;
                    Unk_253_raw = value;
                    ChangedItems.Add(nameof(Unk_253));
                    OnPropertyChanged(nameof(Unk_253));
                }
            }

            protected uint Unk_254_raw;
            public const string Unk_254_displayName = "Unk 254";
            public const int Unk_254_sortIndex = 2450;
            [SortOrder(Unk_254_sortIndex)]
            [DisplayName(Unk_254_displayName)]
            public virtual uint Unk_254 {
                get => Unk_254_raw;
                set {
                    if (Unk_254_raw == value) return;
                    Unk_254_raw = value;
                    ChangedItems.Add(nameof(Unk_254));
                    OnPropertyChanged(nameof(Unk_254));
                }
            }

            protected uint Unk_255_raw;
            public const string Unk_255_displayName = "Unk 255";
            public const int Unk_255_sortIndex = 2500;
            [SortOrder(Unk_255_sortIndex)]
            [DisplayName(Unk_255_displayName)]
            public virtual uint Unk_255 {
                get => Unk_255_raw;
                set {
                    if (Unk_255_raw == value) return;
                    Unk_255_raw = value;
                    ChangedItems.Add(nameof(Unk_255));
                    OnPropertyChanged(nameof(Unk_255));
                }
            }

            protected uint Unk_256_raw;
            public const string Unk_256_displayName = "Unk 256";
            public const int Unk_256_sortIndex = 2550;
            [SortOrder(Unk_256_sortIndex)]
            [DisplayName(Unk_256_displayName)]
            public virtual uint Unk_256 {
                get => Unk_256_raw;
                set {
                    if (Unk_256_raw == value) return;
                    Unk_256_raw = value;
                    ChangedItems.Add(nameof(Unk_256));
                    OnPropertyChanged(nameof(Unk_256));
                }
            }

            protected uint Unk_257_raw;
            public const string Unk_257_displayName = "Unk 257";
            public const int Unk_257_sortIndex = 2600;
            [SortOrder(Unk_257_sortIndex)]
            [DisplayName(Unk_257_displayName)]
            public virtual uint Unk_257 {
                get => Unk_257_raw;
                set {
                    if (Unk_257_raw == value) return;
                    Unk_257_raw = value;
                    ChangedItems.Add(nameof(Unk_257));
                    OnPropertyChanged(nameof(Unk_257));
                }
            }

            protected uint Unk_258_raw;
            public const string Unk_258_displayName = "Unk 258";
            public const int Unk_258_sortIndex = 2650;
            [SortOrder(Unk_258_sortIndex)]
            [DisplayName(Unk_258_displayName)]
            public virtual uint Unk_258 {
                get => Unk_258_raw;
                set {
                    if (Unk_258_raw == value) return;
                    Unk_258_raw = value;
                    ChangedItems.Add(nameof(Unk_258));
                    OnPropertyChanged(nameof(Unk_258));
                }
            }

            protected uint Unk_259_raw;
            public const string Unk_259_displayName = "Unk 259";
            public const int Unk_259_sortIndex = 2700;
            [SortOrder(Unk_259_sortIndex)]
            [DisplayName(Unk_259_displayName)]
            public virtual uint Unk_259 {
                get => Unk_259_raw;
                set {
                    if (Unk_259_raw == value) return;
                    Unk_259_raw = value;
                    ChangedItems.Add(nameof(Unk_259));
                    OnPropertyChanged(nameof(Unk_259));
                }
            }

            protected uint Unk_260_raw;
            public const string Unk_260_displayName = "Unk 260";
            public const int Unk_260_sortIndex = 2750;
            [SortOrder(Unk_260_sortIndex)]
            [DisplayName(Unk_260_displayName)]
            public virtual uint Unk_260 {
                get => Unk_260_raw;
                set {
                    if (Unk_260_raw == value) return;
                    Unk_260_raw = value;
                    ChangedItems.Add(nameof(Unk_260));
                    OnPropertyChanged(nameof(Unk_260));
                }
            }

            protected uint Unk_261_raw;
            public const string Unk_261_displayName = "Unk 261";
            public const int Unk_261_sortIndex = 2800;
            [SortOrder(Unk_261_sortIndex)]
            [DisplayName(Unk_261_displayName)]
            public virtual uint Unk_261 {
                get => Unk_261_raw;
                set {
                    if (Unk_261_raw == value) return;
                    Unk_261_raw = value;
                    ChangedItems.Add(nameof(Unk_261));
                    OnPropertyChanged(nameof(Unk_261));
                }
            }

            protected uint Unk_262_raw;
            public const string Unk_262_displayName = "Unk 262";
            public const int Unk_262_sortIndex = 2850;
            [SortOrder(Unk_262_sortIndex)]
            [DisplayName(Unk_262_displayName)]
            public virtual uint Unk_262 {
                get => Unk_262_raw;
                set {
                    if (Unk_262_raw == value) return;
                    Unk_262_raw = value;
                    ChangedItems.Add(nameof(Unk_262));
                    OnPropertyChanged(nameof(Unk_262));
                }
            }

            protected uint Unk_263_raw;
            public const string Unk_263_displayName = "Unk 263";
            public const int Unk_263_sortIndex = 2900;
            [SortOrder(Unk_263_sortIndex)]
            [DisplayName(Unk_263_displayName)]
            public virtual uint Unk_263 {
                get => Unk_263_raw;
                set {
                    if (Unk_263_raw == value) return;
                    Unk_263_raw = value;
                    ChangedItems.Add(nameof(Unk_263));
                    OnPropertyChanged(nameof(Unk_263));
                }
            }

            protected uint Unk_264_raw;
            public const string Unk_264_displayName = "Unk 264";
            public const int Unk_264_sortIndex = 2950;
            [SortOrder(Unk_264_sortIndex)]
            [DisplayName(Unk_264_displayName)]
            public virtual uint Unk_264 {
                get => Unk_264_raw;
                set {
                    if (Unk_264_raw == value) return;
                    Unk_264_raw = value;
                    ChangedItems.Add(nameof(Unk_264));
                    OnPropertyChanged(nameof(Unk_264));
                }
            }

            protected uint Unk_265_raw;
            public const string Unk_265_displayName = "Unk 265";
            public const int Unk_265_sortIndex = 3000;
            [SortOrder(Unk_265_sortIndex)]
            [DisplayName(Unk_265_displayName)]
            public virtual uint Unk_265 {
                get => Unk_265_raw;
                set {
                    if (Unk_265_raw == value) return;
                    Unk_265_raw = value;
                    ChangedItems.Add(nameof(Unk_265));
                    OnPropertyChanged(nameof(Unk_265));
                }
            }

            protected uint Unk_266_raw;
            public const string Unk_266_displayName = "Unk 266";
            public const int Unk_266_sortIndex = 3050;
            [SortOrder(Unk_266_sortIndex)]
            [DisplayName(Unk_266_displayName)]
            public virtual uint Unk_266 {
                get => Unk_266_raw;
                set {
                    if (Unk_266_raw == value) return;
                    Unk_266_raw = value;
                    ChangedItems.Add(nameof(Unk_266));
                    OnPropertyChanged(nameof(Unk_266));
                }
            }

            protected uint Unk_267_raw;
            public const string Unk_267_displayName = "Unk 267";
            public const int Unk_267_sortIndex = 3100;
            [SortOrder(Unk_267_sortIndex)]
            [DisplayName(Unk_267_displayName)]
            public virtual uint Unk_267 {
                get => Unk_267_raw;
                set {
                    if (Unk_267_raw == value) return;
                    Unk_267_raw = value;
                    ChangedItems.Add(nameof(Unk_267));
                    OnPropertyChanged(nameof(Unk_267));
                }
            }

            protected uint Unk_268_raw;
            public const string Unk_268_displayName = "Unk 268";
            public const int Unk_268_sortIndex = 3150;
            [SortOrder(Unk_268_sortIndex)]
            [DisplayName(Unk_268_displayName)]
            public virtual uint Unk_268 {
                get => Unk_268_raw;
                set {
                    if (Unk_268_raw == value) return;
                    Unk_268_raw = value;
                    ChangedItems.Add(nameof(Unk_268));
                    OnPropertyChanged(nameof(Unk_268));
                }
            }

            protected uint Unk_269_raw;
            public const string Unk_269_displayName = "Unk 269";
            public const int Unk_269_sortIndex = 3200;
            [SortOrder(Unk_269_sortIndex)]
            [DisplayName(Unk_269_displayName)]
            public virtual uint Unk_269 {
                get => Unk_269_raw;
                set {
                    if (Unk_269_raw == value) return;
                    Unk_269_raw = value;
                    ChangedItems.Add(nameof(Unk_269));
                    OnPropertyChanged(nameof(Unk_269));
                }
            }

            protected uint Unk_270_raw;
            public const string Unk_270_displayName = "Unk 270";
            public const int Unk_270_sortIndex = 3250;
            [SortOrder(Unk_270_sortIndex)]
            [DisplayName(Unk_270_displayName)]
            public virtual uint Unk_270 {
                get => Unk_270_raw;
                set {
                    if (Unk_270_raw == value) return;
                    Unk_270_raw = value;
                    ChangedItems.Add(nameof(Unk_270));
                    OnPropertyChanged(nameof(Unk_270));
                }
            }

            protected uint Unk_271_raw;
            public const string Unk_271_displayName = "Unk 271";
            public const int Unk_271_sortIndex = 3300;
            [SortOrder(Unk_271_sortIndex)]
            [DisplayName(Unk_271_displayName)]
            public virtual uint Unk_271 {
                get => Unk_271_raw;
                set {
                    if (Unk_271_raw == value) return;
                    Unk_271_raw = value;
                    ChangedItems.Add(nameof(Unk_271));
                    OnPropertyChanged(nameof(Unk_271));
                }
            }

            protected float Unk_272_raw;
            public const string Unk_272_displayName = "Unk 272";
            public const int Unk_272_sortIndex = 3350;
            [SortOrder(Unk_272_sortIndex)]
            [DisplayName(Unk_272_displayName)]
            public virtual float Unk_272 {
                get => Unk_272_raw;
                set {
                    if (Unk_272_raw == value) return;
                    Unk_272_raw = value;
                    ChangedItems.Add(nameof(Unk_272));
                    OnPropertyChanged(nameof(Unk_272));
                }
            }

            protected uint Unk_273_raw;
            public const string Unk_273_displayName = "Unk 273";
            public const int Unk_273_sortIndex = 3400;
            [SortOrder(Unk_273_sortIndex)]
            [DisplayName(Unk_273_displayName)]
            public virtual uint Unk_273 {
                get => Unk_273_raw;
                set {
                    if (Unk_273_raw == value) return;
                    Unk_273_raw = value;
                    ChangedItems.Add(nameof(Unk_273));
                    OnPropertyChanged(nameof(Unk_273));
                }
            }

            protected uint Unk_274_raw;
            public const string Unk_274_displayName = "Unk 274";
            public const int Unk_274_sortIndex = 3450;
            [SortOrder(Unk_274_sortIndex)]
            [DisplayName(Unk_274_displayName)]
            public virtual uint Unk_274 {
                get => Unk_274_raw;
                set {
                    if (Unk_274_raw == value) return;
                    Unk_274_raw = value;
                    ChangedItems.Add(nameof(Unk_274));
                    OnPropertyChanged(nameof(Unk_274));
                }
            }

            public const int lastSortIndex = 3500;

            public static ObservableMhwStructCollection<Monster_Common_Params_9_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Monster_Common_Params_9_>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Monster_Common_Params_9_ LoadData(BinaryReader reader, ulong i) {
                var data = new Monster_Common_Params_9_();
                data.Index = i;
                data.Header_raw = reader.ReadUInt32();
                data.Unk_207_raw = reader.ReadUInt32();
                data.Unk_208_raw = reader.ReadUInt32();
                data.Unk_209_raw = reader.ReadUInt32();
                data.Unk_210_raw = reader.ReadUInt32();
                data.Unk_211_raw = reader.ReadUInt32();
                data.Unk_212_raw = reader.ReadUInt32();
                data.Unk_213_raw = reader.ReadUInt32();
                data.Unk_214_raw = reader.ReadUInt32();
                data.Unk_215_raw = reader.ReadUInt32();
                data.Unk_216_raw = reader.ReadUInt32();
                data.Unk_217_raw = reader.ReadUInt32();
                data.Unk_218_raw = reader.ReadUInt32();
                data.Unk_219_raw = reader.ReadUInt32();
                data.Unk_220_raw = reader.ReadUInt32();
                data.Unk_221_raw = reader.ReadUInt32();
                data.Unk_222_raw = reader.ReadUInt32();
                data.Unk_223_raw = reader.ReadUInt32();
                data.Unk_224_raw = reader.ReadUInt32();
                data.Unk_225_raw = reader.ReadUInt32();
                data.Unk_226_raw = reader.ReadUInt32();
                data.Unk_227_raw = reader.ReadUInt32();
                data.Unk_228_raw = reader.ReadUInt32();
                data.Unk_229_raw = reader.ReadUInt32();
                data.Unk_230_raw = reader.ReadUInt32();
                data.Unk_231_raw = reader.ReadUInt32();
                data.Unk_232_raw = reader.ReadUInt32();
                data.Unk_233_raw = reader.ReadUInt32();
                data.Unk_234_raw = reader.ReadUInt32();
                data.Unk_235_raw = reader.ReadUInt32();
                data.Unk_236_raw = reader.ReadUInt32();
                data.Unk_237_raw = reader.ReadUInt32();
                data.Unk_238_raw = reader.ReadUInt32();
                data.Unk_239_raw = reader.ReadUInt32();
                data.Unk_240_raw = reader.ReadUInt32();
                data.Unk_241_raw = reader.ReadUInt32();
                data.Unk_242_raw = reader.ReadUInt32();
                data.Unk_243_raw = reader.ReadUInt32();
                data.Unk_244_raw = reader.ReadUInt32();
                data.Unk_245_raw = reader.ReadUInt32();
                data.Unk_246_raw = reader.ReadUInt32();
                data.Unk_247_raw = reader.ReadUInt32();
                data.Unk_248_raw = reader.ReadUInt32();
                data.Unk_249_raw = reader.ReadUInt32();
                data.Unk_250_raw = reader.ReadUInt32();
                data.Unk_251_raw = reader.ReadUInt32();
                data.Unk_252_raw = reader.ReadUInt32();
                data.Unk_253_raw = reader.ReadUInt32();
                data.Unk_254_raw = reader.ReadUInt32();
                data.Unk_255_raw = reader.ReadUInt32();
                data.Unk_256_raw = reader.ReadUInt32();
                data.Unk_257_raw = reader.ReadUInt32();
                data.Unk_258_raw = reader.ReadUInt32();
                data.Unk_259_raw = reader.ReadUInt32();
                data.Unk_260_raw = reader.ReadUInt32();
                data.Unk_261_raw = reader.ReadUInt32();
                data.Unk_262_raw = reader.ReadUInt32();
                data.Unk_263_raw = reader.ReadUInt32();
                data.Unk_264_raw = reader.ReadUInt32();
                data.Unk_265_raw = reader.ReadUInt32();
                data.Unk_266_raw = reader.ReadUInt32();
                data.Unk_267_raw = reader.ReadUInt32();
                data.Unk_268_raw = reader.ReadUInt32();
                data.Unk_269_raw = reader.ReadUInt32();
                data.Unk_270_raw = reader.ReadUInt32();
                data.Unk_271_raw = reader.ReadUInt32();
                data.Unk_272_raw = reader.ReadSingle();
                data.Unk_273_raw = reader.ReadUInt32();
                data.Unk_274_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Header_raw);
                writer.Write(Unk_207_raw);
                writer.Write(Unk_208_raw);
                writer.Write(Unk_209_raw);
                writer.Write(Unk_210_raw);
                writer.Write(Unk_211_raw);
                writer.Write(Unk_212_raw);
                writer.Write(Unk_213_raw);
                writer.Write(Unk_214_raw);
                writer.Write(Unk_215_raw);
                writer.Write(Unk_216_raw);
                writer.Write(Unk_217_raw);
                writer.Write(Unk_218_raw);
                writer.Write(Unk_219_raw);
                writer.Write(Unk_220_raw);
                writer.Write(Unk_221_raw);
                writer.Write(Unk_222_raw);
                writer.Write(Unk_223_raw);
                writer.Write(Unk_224_raw);
                writer.Write(Unk_225_raw);
                writer.Write(Unk_226_raw);
                writer.Write(Unk_227_raw);
                writer.Write(Unk_228_raw);
                writer.Write(Unk_229_raw);
                writer.Write(Unk_230_raw);
                writer.Write(Unk_231_raw);
                writer.Write(Unk_232_raw);
                writer.Write(Unk_233_raw);
                writer.Write(Unk_234_raw);
                writer.Write(Unk_235_raw);
                writer.Write(Unk_236_raw);
                writer.Write(Unk_237_raw);
                writer.Write(Unk_238_raw);
                writer.Write(Unk_239_raw);
                writer.Write(Unk_240_raw);
                writer.Write(Unk_241_raw);
                writer.Write(Unk_242_raw);
                writer.Write(Unk_243_raw);
                writer.Write(Unk_244_raw);
                writer.Write(Unk_245_raw);
                writer.Write(Unk_246_raw);
                writer.Write(Unk_247_raw);
                writer.Write(Unk_248_raw);
                writer.Write(Unk_249_raw);
                writer.Write(Unk_250_raw);
                writer.Write(Unk_251_raw);
                writer.Write(Unk_252_raw);
                writer.Write(Unk_253_raw);
                writer.Write(Unk_254_raw);
                writer.Write(Unk_255_raw);
                writer.Write(Unk_256_raw);
                writer.Write(Unk_257_raw);
                writer.Write(Unk_258_raw);
                writer.Write(Unk_259_raw);
                writer.Write(Unk_260_raw);
                writer.Write(Unk_261_raw);
                writer.Write(Unk_262_raw);
                writer.Write(Unk_263_raw);
                writer.Write(Unk_264_raw);
                writer.Write(Unk_265_raw);
                writer.Write(Unk_266_raw);
                writer.Write(Unk_267_raw);
                writer.Write(Unk_268_raw);
                writer.Write(Unk_269_raw);
                writer.Write(Unk_270_raw);
                writer.Write(Unk_271_raw);
                writer.Write(Unk_272_raw);
                writer.Write(Unk_273_raw);
                writer.Write(Unk_274_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Header", "Header"),
                    new MultiStructItemCustomView(this, "Unk 207", "Unk_207"),
                    new MultiStructItemCustomView(this, "Unk 208", "Unk_208"),
                    new MultiStructItemCustomView(this, "Unk 209", "Unk_209"),
                    new MultiStructItemCustomView(this, "Unk 210", "Unk_210"),
                    new MultiStructItemCustomView(this, "Unk 211", "Unk_211"),
                    new MultiStructItemCustomView(this, "Unk 212", "Unk_212"),
                    new MultiStructItemCustomView(this, "Unk 213", "Unk_213"),
                    new MultiStructItemCustomView(this, "Unk 214", "Unk_214"),
                    new MultiStructItemCustomView(this, "Unk 215", "Unk_215"),
                    new MultiStructItemCustomView(this, "Unk 216", "Unk_216"),
                    new MultiStructItemCustomView(this, "Unk 217", "Unk_217"),
                    new MultiStructItemCustomView(this, "Unk 218", "Unk_218"),
                    new MultiStructItemCustomView(this, "Unk 219", "Unk_219"),
                    new MultiStructItemCustomView(this, "Unk 220", "Unk_220"),
                    new MultiStructItemCustomView(this, "Unk 221", "Unk_221"),
                    new MultiStructItemCustomView(this, "Unk 222", "Unk_222"),
                    new MultiStructItemCustomView(this, "Unk 223", "Unk_223"),
                    new MultiStructItemCustomView(this, "Unk 224", "Unk_224"),
                    new MultiStructItemCustomView(this, "Unk 225", "Unk_225"),
                    new MultiStructItemCustomView(this, "Unk 226", "Unk_226"),
                    new MultiStructItemCustomView(this, "Unk 227", "Unk_227"),
                    new MultiStructItemCustomView(this, "Unk 228", "Unk_228"),
                    new MultiStructItemCustomView(this, "Unk 229", "Unk_229"),
                    new MultiStructItemCustomView(this, "Unk 230", "Unk_230"),
                    new MultiStructItemCustomView(this, "Unk 231", "Unk_231"),
                    new MultiStructItemCustomView(this, "Unk 232", "Unk_232"),
                    new MultiStructItemCustomView(this, "Unk 233", "Unk_233"),
                    new MultiStructItemCustomView(this, "Unk 234", "Unk_234"),
                    new MultiStructItemCustomView(this, "Unk 235", "Unk_235"),
                    new MultiStructItemCustomView(this, "Unk 236", "Unk_236"),
                    new MultiStructItemCustomView(this, "Unk 237", "Unk_237"),
                    new MultiStructItemCustomView(this, "Unk 238", "Unk_238"),
                    new MultiStructItemCustomView(this, "Unk 239", "Unk_239"),
                    new MultiStructItemCustomView(this, "Unk 240", "Unk_240"),
                    new MultiStructItemCustomView(this, "Unk 241", "Unk_241"),
                    new MultiStructItemCustomView(this, "Unk 242", "Unk_242"),
                    new MultiStructItemCustomView(this, "Unk 243", "Unk_243"),
                    new MultiStructItemCustomView(this, "Unk 244", "Unk_244"),
                    new MultiStructItemCustomView(this, "Unk 245", "Unk_245"),
                    new MultiStructItemCustomView(this, "Unk 246", "Unk_246"),
                    new MultiStructItemCustomView(this, "Unk 247", "Unk_247"),
                    new MultiStructItemCustomView(this, "Unk 248", "Unk_248"),
                    new MultiStructItemCustomView(this, "Unk 249", "Unk_249"),
                    new MultiStructItemCustomView(this, "Unk 250", "Unk_250"),
                    new MultiStructItemCustomView(this, "Unk 251", "Unk_251"),
                    new MultiStructItemCustomView(this, "Unk 252", "Unk_252"),
                    new MultiStructItemCustomView(this, "Unk 253", "Unk_253"),
                    new MultiStructItemCustomView(this, "Unk 254", "Unk_254"),
                    new MultiStructItemCustomView(this, "Unk 255", "Unk_255"),
                    new MultiStructItemCustomView(this, "Unk 256", "Unk_256"),
                    new MultiStructItemCustomView(this, "Unk 257", "Unk_257"),
                    new MultiStructItemCustomView(this, "Unk 258", "Unk_258"),
                    new MultiStructItemCustomView(this, "Unk 259", "Unk_259"),
                    new MultiStructItemCustomView(this, "Unk 260", "Unk_260"),
                    new MultiStructItemCustomView(this, "Unk 261", "Unk_261"),
                    new MultiStructItemCustomView(this, "Unk 262", "Unk_262"),
                    new MultiStructItemCustomView(this, "Unk 263", "Unk_263"),
                    new MultiStructItemCustomView(this, "Unk 264", "Unk_264"),
                    new MultiStructItemCustomView(this, "Unk 265", "Unk_265"),
                    new MultiStructItemCustomView(this, "Unk 266", "Unk_266"),
                    new MultiStructItemCustomView(this, "Unk 267", "Unk_267"),
                    new MultiStructItemCustomView(this, "Unk 268", "Unk_268"),
                    new MultiStructItemCustomView(this, "Unk 269", "Unk_269"),
                    new MultiStructItemCustomView(this, "Unk 270", "Unk_270"),
                    new MultiStructItemCustomView(this, "Unk 271", "Unk_271"),
                    new MultiStructItemCustomView(this, "Unk 272", "Unk_272"),
                    new MultiStructItemCustomView(this, "Unk 273", "Unk_273"),
                    new MultiStructItemCustomView(this, "Unk 274", "Unk_274"),
                };
            }
        }

        public partial class Monster_Common_Params_10_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Monster Common Params (10)";

            protected uint Shell_Header_raw;
            public const string Shell_Header_displayName = "Shell Header";
            public const int Shell_Header_sortIndex = 50;
            [SortOrder(Shell_Header_sortIndex)]
            [DisplayName(Shell_Header_displayName)]
            [IsReadOnly]
            public virtual uint Shell_Header {
                get => Shell_Header_raw;
                set {
                    if (Shell_Header_raw == value) return;
                    Shell_Header_raw = value;
                    ChangedItems.Add(nameof(Shell_Header));
                    OnPropertyChanged(nameof(Shell_Header));
                }
            }

            protected string Shell_raw;
            public const string Shell_displayName = "Shell";
            public const int Shell_sortIndex = 100;
            [SortOrder(Shell_sortIndex)]
            [DisplayName(Shell_displayName)]
            [IsReadOnly]
            public virtual string Shell {
                get => Shell_raw;
                set {
                    if (Shell_raw == value) return;
                    Shell_raw = value;
                    ChangedItems.Add(nameof(Shell));
                    OnPropertyChanged(nameof(Shell));
                }
            }

            protected float Unk_275_raw;
            public const string Unk_275_displayName = "Unk 275";
            public const int Unk_275_sortIndex = 150;
            [SortOrder(Unk_275_sortIndex)]
            [DisplayName(Unk_275_displayName)]
            public virtual float Unk_275 {
                get => Unk_275_raw;
                set {
                    if (Unk_275_raw == value) return;
                    Unk_275_raw = value;
                    ChangedItems.Add(nameof(Unk_275));
                    OnPropertyChanged(nameof(Unk_275));
                }
            }

            protected int Unk_276_raw;
            public const string Unk_276_displayName = "Unk 276";
            public const int Unk_276_sortIndex = 200;
            [SortOrder(Unk_276_sortIndex)]
            [DisplayName(Unk_276_displayName)]
            public virtual int Unk_276 {
                get => Unk_276_raw;
                set {
                    if (Unk_276_raw == value) return;
                    Unk_276_raw = value;
                    ChangedItems.Add(nameof(Unk_276));
                    OnPropertyChanged(nameof(Unk_276));
                }
            }

            protected float Unk_277_raw;
            public const string Unk_277_displayName = "Unk 277";
            public const int Unk_277_sortIndex = 250;
            [SortOrder(Unk_277_sortIndex)]
            [DisplayName(Unk_277_displayName)]
            public virtual float Unk_277 {
                get => Unk_277_raw;
                set {
                    if (Unk_277_raw == value) return;
                    Unk_277_raw = value;
                    ChangedItems.Add(nameof(Unk_277));
                    OnPropertyChanged(nameof(Unk_277));
                }
            }

            protected float Unk_278_raw;
            public const string Unk_278_displayName = "Unk 278";
            public const int Unk_278_sortIndex = 300;
            [SortOrder(Unk_278_sortIndex)]
            [DisplayName(Unk_278_displayName)]
            public virtual float Unk_278 {
                get => Unk_278_raw;
                set {
                    if (Unk_278_raw == value) return;
                    Unk_278_raw = value;
                    ChangedItems.Add(nameof(Unk_278));
                    OnPropertyChanged(nameof(Unk_278));
                }
            }

            protected float Unk_279_raw;
            public const string Unk_279_displayName = "Unk 279";
            public const int Unk_279_sortIndex = 350;
            [SortOrder(Unk_279_sortIndex)]
            [DisplayName(Unk_279_displayName)]
            public virtual float Unk_279 {
                get => Unk_279_raw;
                set {
                    if (Unk_279_raw == value) return;
                    Unk_279_raw = value;
                    ChangedItems.Add(nameof(Unk_279));
                    OnPropertyChanged(nameof(Unk_279));
                }
            }

            protected float Unk_280_raw;
            public const string Unk_280_displayName = "Unk 280";
            public const int Unk_280_sortIndex = 400;
            [SortOrder(Unk_280_sortIndex)]
            [DisplayName(Unk_280_displayName)]
            public virtual float Unk_280 {
                get => Unk_280_raw;
                set {
                    if (Unk_280_raw == value) return;
                    Unk_280_raw = value;
                    ChangedItems.Add(nameof(Unk_280));
                    OnPropertyChanged(nameof(Unk_280));
                }
            }

            protected float Unk_281_raw;
            public const string Unk_281_displayName = "Unk 281";
            public const int Unk_281_sortIndex = 450;
            [SortOrder(Unk_281_sortIndex)]
            [DisplayName(Unk_281_displayName)]
            public virtual float Unk_281 {
                get => Unk_281_raw;
                set {
                    if (Unk_281_raw == value) return;
                    Unk_281_raw = value;
                    ChangedItems.Add(nameof(Unk_281));
                    OnPropertyChanged(nameof(Unk_281));
                }
            }

            protected float Unk_282_raw;
            public const string Unk_282_displayName = "Unk 282";
            public const int Unk_282_sortIndex = 500;
            [SortOrder(Unk_282_sortIndex)]
            [DisplayName(Unk_282_displayName)]
            public virtual float Unk_282 {
                get => Unk_282_raw;
                set {
                    if (Unk_282_raw == value) return;
                    Unk_282_raw = value;
                    ChangedItems.Add(nameof(Unk_282));
                    OnPropertyChanged(nameof(Unk_282));
                }
            }

            protected float Unk_283_raw;
            public const string Unk_283_displayName = "Unk 283";
            public const int Unk_283_sortIndex = 550;
            [SortOrder(Unk_283_sortIndex)]
            [DisplayName(Unk_283_displayName)]
            public virtual float Unk_283 {
                get => Unk_283_raw;
                set {
                    if (Unk_283_raw == value) return;
                    Unk_283_raw = value;
                    ChangedItems.Add(nameof(Unk_283));
                    OnPropertyChanged(nameof(Unk_283));
                }
            }

            protected float Unk_284_raw;
            public const string Unk_284_displayName = "Unk 284";
            public const int Unk_284_sortIndex = 600;
            [SortOrder(Unk_284_sortIndex)]
            [DisplayName(Unk_284_displayName)]
            public virtual float Unk_284 {
                get => Unk_284_raw;
                set {
                    if (Unk_284_raw == value) return;
                    Unk_284_raw = value;
                    ChangedItems.Add(nameof(Unk_284));
                    OnPropertyChanged(nameof(Unk_284));
                }
            }

            protected float Unk_285_raw;
            public const string Unk_285_displayName = "Unk 285";
            public const int Unk_285_sortIndex = 650;
            [SortOrder(Unk_285_sortIndex)]
            [DisplayName(Unk_285_displayName)]
            public virtual float Unk_285 {
                get => Unk_285_raw;
                set {
                    if (Unk_285_raw == value) return;
                    Unk_285_raw = value;
                    ChangedItems.Add(nameof(Unk_285));
                    OnPropertyChanged(nameof(Unk_285));
                }
            }

            protected float Unk_286_raw;
            public const string Unk_286_displayName = "Unk 286";
            public const int Unk_286_sortIndex = 700;
            [SortOrder(Unk_286_sortIndex)]
            [DisplayName(Unk_286_displayName)]
            public virtual float Unk_286 {
                get => Unk_286_raw;
                set {
                    if (Unk_286_raw == value) return;
                    Unk_286_raw = value;
                    ChangedItems.Add(nameof(Unk_286));
                    OnPropertyChanged(nameof(Unk_286));
                }
            }

            protected float Unk_287_raw;
            public const string Unk_287_displayName = "Unk 287";
            public const int Unk_287_sortIndex = 750;
            [SortOrder(Unk_287_sortIndex)]
            [DisplayName(Unk_287_displayName)]
            public virtual float Unk_287 {
                get => Unk_287_raw;
                set {
                    if (Unk_287_raw == value) return;
                    Unk_287_raw = value;
                    ChangedItems.Add(nameof(Unk_287));
                    OnPropertyChanged(nameof(Unk_287));
                }
            }

            protected float Unk_288_raw;
            public const string Unk_288_displayName = "Unk 288";
            public const int Unk_288_sortIndex = 800;
            [SortOrder(Unk_288_sortIndex)]
            [DisplayName(Unk_288_displayName)]
            public virtual float Unk_288 {
                get => Unk_288_raw;
                set {
                    if (Unk_288_raw == value) return;
                    Unk_288_raw = value;
                    ChangedItems.Add(nameof(Unk_288));
                    OnPropertyChanged(nameof(Unk_288));
                }
            }

            protected float Unk_289_raw;
            public const string Unk_289_displayName = "Unk 289";
            public const int Unk_289_sortIndex = 850;
            [SortOrder(Unk_289_sortIndex)]
            [DisplayName(Unk_289_displayName)]
            public virtual float Unk_289 {
                get => Unk_289_raw;
                set {
                    if (Unk_289_raw == value) return;
                    Unk_289_raw = value;
                    ChangedItems.Add(nameof(Unk_289));
                    OnPropertyChanged(nameof(Unk_289));
                }
            }

            protected float Unk_290_raw;
            public const string Unk_290_displayName = "Unk 290";
            public const int Unk_290_sortIndex = 900;
            [SortOrder(Unk_290_sortIndex)]
            [DisplayName(Unk_290_displayName)]
            public virtual float Unk_290 {
                get => Unk_290_raw;
                set {
                    if (Unk_290_raw == value) return;
                    Unk_290_raw = value;
                    ChangedItems.Add(nameof(Unk_290));
                    OnPropertyChanged(nameof(Unk_290));
                }
            }

            protected float Unk_291_raw;
            public const string Unk_291_displayName = "Unk 291";
            public const int Unk_291_sortIndex = 950;
            [SortOrder(Unk_291_sortIndex)]
            [DisplayName(Unk_291_displayName)]
            public virtual float Unk_291 {
                get => Unk_291_raw;
                set {
                    if (Unk_291_raw == value) return;
                    Unk_291_raw = value;
                    ChangedItems.Add(nameof(Unk_291));
                    OnPropertyChanged(nameof(Unk_291));
                }
            }

            protected float Unk_292_raw;
            public const string Unk_292_displayName = "Unk 292";
            public const int Unk_292_sortIndex = 1000;
            [SortOrder(Unk_292_sortIndex)]
            [DisplayName(Unk_292_displayName)]
            public virtual float Unk_292 {
                get => Unk_292_raw;
                set {
                    if (Unk_292_raw == value) return;
                    Unk_292_raw = value;
                    ChangedItems.Add(nameof(Unk_292));
                    OnPropertyChanged(nameof(Unk_292));
                }
            }

            protected float Unk_293_raw;
            public const string Unk_293_displayName = "Unk 293";
            public const int Unk_293_sortIndex = 1050;
            [SortOrder(Unk_293_sortIndex)]
            [DisplayName(Unk_293_displayName)]
            public virtual float Unk_293 {
                get => Unk_293_raw;
                set {
                    if (Unk_293_raw == value) return;
                    Unk_293_raw = value;
                    ChangedItems.Add(nameof(Unk_293));
                    OnPropertyChanged(nameof(Unk_293));
                }
            }

            protected float Unk_294_raw;
            public const string Unk_294_displayName = "Unk 294";
            public const int Unk_294_sortIndex = 1100;
            [SortOrder(Unk_294_sortIndex)]
            [DisplayName(Unk_294_displayName)]
            public virtual float Unk_294 {
                get => Unk_294_raw;
                set {
                    if (Unk_294_raw == value) return;
                    Unk_294_raw = value;
                    ChangedItems.Add(nameof(Unk_294));
                    OnPropertyChanged(nameof(Unk_294));
                }
            }

            protected float Unk_295_raw;
            public const string Unk_295_displayName = "Unk 295";
            public const int Unk_295_sortIndex = 1150;
            [SortOrder(Unk_295_sortIndex)]
            [DisplayName(Unk_295_displayName)]
            public virtual float Unk_295 {
                get => Unk_295_raw;
                set {
                    if (Unk_295_raw == value) return;
                    Unk_295_raw = value;
                    ChangedItems.Add(nameof(Unk_295));
                    OnPropertyChanged(nameof(Unk_295));
                }
            }

            protected float Unk_296_raw;
            public const string Unk_296_displayName = "Unk 296";
            public const int Unk_296_sortIndex = 1200;
            [SortOrder(Unk_296_sortIndex)]
            [DisplayName(Unk_296_displayName)]
            public virtual float Unk_296 {
                get => Unk_296_raw;
                set {
                    if (Unk_296_raw == value) return;
                    Unk_296_raw = value;
                    ChangedItems.Add(nameof(Unk_296));
                    OnPropertyChanged(nameof(Unk_296));
                }
            }

            protected float Unk_297_raw;
            public const string Unk_297_displayName = "Unk 297";
            public const int Unk_297_sortIndex = 1250;
            [SortOrder(Unk_297_sortIndex)]
            [DisplayName(Unk_297_displayName)]
            public virtual float Unk_297 {
                get => Unk_297_raw;
                set {
                    if (Unk_297_raw == value) return;
                    Unk_297_raw = value;
                    ChangedItems.Add(nameof(Unk_297));
                    OnPropertyChanged(nameof(Unk_297));
                }
            }

            protected float Unk_298_raw;
            public const string Unk_298_displayName = "Unk 298";
            public const int Unk_298_sortIndex = 1300;
            [SortOrder(Unk_298_sortIndex)]
            [DisplayName(Unk_298_displayName)]
            public virtual float Unk_298 {
                get => Unk_298_raw;
                set {
                    if (Unk_298_raw == value) return;
                    Unk_298_raw = value;
                    ChangedItems.Add(nameof(Unk_298));
                    OnPropertyChanged(nameof(Unk_298));
                }
            }

            protected float Unk_299_raw;
            public const string Unk_299_displayName = "Unk 299";
            public const int Unk_299_sortIndex = 1350;
            [SortOrder(Unk_299_sortIndex)]
            [DisplayName(Unk_299_displayName)]
            public virtual float Unk_299 {
                get => Unk_299_raw;
                set {
                    if (Unk_299_raw == value) return;
                    Unk_299_raw = value;
                    ChangedItems.Add(nameof(Unk_299));
                    OnPropertyChanged(nameof(Unk_299));
                }
            }

            protected float Unk_300_raw;
            public const string Unk_300_displayName = "Unk 300";
            public const int Unk_300_sortIndex = 1400;
            [SortOrder(Unk_300_sortIndex)]
            [DisplayName(Unk_300_displayName)]
            public virtual float Unk_300 {
                get => Unk_300_raw;
                set {
                    if (Unk_300_raw == value) return;
                    Unk_300_raw = value;
                    ChangedItems.Add(nameof(Unk_300));
                    OnPropertyChanged(nameof(Unk_300));
                }
            }

            protected float Unk_301_raw;
            public const string Unk_301_displayName = "Unk 301";
            public const int Unk_301_sortIndex = 1450;
            [SortOrder(Unk_301_sortIndex)]
            [DisplayName(Unk_301_displayName)]
            public virtual float Unk_301 {
                get => Unk_301_raw;
                set {
                    if (Unk_301_raw == value) return;
                    Unk_301_raw = value;
                    ChangedItems.Add(nameof(Unk_301));
                    OnPropertyChanged(nameof(Unk_301));
                }
            }

            protected float Unk_302_raw;
            public const string Unk_302_displayName = "Unk 302";
            public const int Unk_302_sortIndex = 1500;
            [SortOrder(Unk_302_sortIndex)]
            [DisplayName(Unk_302_displayName)]
            public virtual float Unk_302 {
                get => Unk_302_raw;
                set {
                    if (Unk_302_raw == value) return;
                    Unk_302_raw = value;
                    ChangedItems.Add(nameof(Unk_302));
                    OnPropertyChanged(nameof(Unk_302));
                }
            }

            protected float Unk_303_raw;
            public const string Unk_303_displayName = "Unk 303";
            public const int Unk_303_sortIndex = 1550;
            [SortOrder(Unk_303_sortIndex)]
            [DisplayName(Unk_303_displayName)]
            public virtual float Unk_303 {
                get => Unk_303_raw;
                set {
                    if (Unk_303_raw == value) return;
                    Unk_303_raw = value;
                    ChangedItems.Add(nameof(Unk_303));
                    OnPropertyChanged(nameof(Unk_303));
                }
            }

            protected float Unk_304_raw;
            public const string Unk_304_displayName = "Unk 304";
            public const int Unk_304_sortIndex = 1600;
            [SortOrder(Unk_304_sortIndex)]
            [DisplayName(Unk_304_displayName)]
            public virtual float Unk_304 {
                get => Unk_304_raw;
                set {
                    if (Unk_304_raw == value) return;
                    Unk_304_raw = value;
                    ChangedItems.Add(nameof(Unk_304));
                    OnPropertyChanged(nameof(Unk_304));
                }
            }

            protected float Unk_305_raw;
            public const string Unk_305_displayName = "Unk 305";
            public const int Unk_305_sortIndex = 1650;
            [SortOrder(Unk_305_sortIndex)]
            [DisplayName(Unk_305_displayName)]
            public virtual float Unk_305 {
                get => Unk_305_raw;
                set {
                    if (Unk_305_raw == value) return;
                    Unk_305_raw = value;
                    ChangedItems.Add(nameof(Unk_305));
                    OnPropertyChanged(nameof(Unk_305));
                }
            }

            protected float Unk_306_raw;
            public const string Unk_306_displayName = "Unk 306";
            public const int Unk_306_sortIndex = 1700;
            [SortOrder(Unk_306_sortIndex)]
            [DisplayName(Unk_306_displayName)]
            public virtual float Unk_306 {
                get => Unk_306_raw;
                set {
                    if (Unk_306_raw == value) return;
                    Unk_306_raw = value;
                    ChangedItems.Add(nameof(Unk_306));
                    OnPropertyChanged(nameof(Unk_306));
                }
            }

            protected float Unk_307_raw;
            public const string Unk_307_displayName = "Unk 307";
            public const int Unk_307_sortIndex = 1750;
            [SortOrder(Unk_307_sortIndex)]
            [DisplayName(Unk_307_displayName)]
            public virtual float Unk_307 {
                get => Unk_307_raw;
                set {
                    if (Unk_307_raw == value) return;
                    Unk_307_raw = value;
                    ChangedItems.Add(nameof(Unk_307));
                    OnPropertyChanged(nameof(Unk_307));
                }
            }

            protected float Unk_308_raw;
            public const string Unk_308_displayName = "Unk 308";
            public const int Unk_308_sortIndex = 1800;
            [SortOrder(Unk_308_sortIndex)]
            [DisplayName(Unk_308_displayName)]
            public virtual float Unk_308 {
                get => Unk_308_raw;
                set {
                    if (Unk_308_raw == value) return;
                    Unk_308_raw = value;
                    ChangedItems.Add(nameof(Unk_308));
                    OnPropertyChanged(nameof(Unk_308));
                }
            }

            protected float Unk_309_raw;
            public const string Unk_309_displayName = "Unk 309";
            public const int Unk_309_sortIndex = 1850;
            [SortOrder(Unk_309_sortIndex)]
            [DisplayName(Unk_309_displayName)]
            public virtual float Unk_309 {
                get => Unk_309_raw;
                set {
                    if (Unk_309_raw == value) return;
                    Unk_309_raw = value;
                    ChangedItems.Add(nameof(Unk_309));
                    OnPropertyChanged(nameof(Unk_309));
                }
            }

            protected float Unk_310_raw;
            public const string Unk_310_displayName = "Unk 310";
            public const int Unk_310_sortIndex = 1900;
            [SortOrder(Unk_310_sortIndex)]
            [DisplayName(Unk_310_displayName)]
            public virtual float Unk_310 {
                get => Unk_310_raw;
                set {
                    if (Unk_310_raw == value) return;
                    Unk_310_raw = value;
                    ChangedItems.Add(nameof(Unk_310));
                    OnPropertyChanged(nameof(Unk_310));
                }
            }

            protected float Unk_311_raw;
            public const string Unk_311_displayName = "Unk 311";
            public const int Unk_311_sortIndex = 1950;
            [SortOrder(Unk_311_sortIndex)]
            [DisplayName(Unk_311_displayName)]
            public virtual float Unk_311 {
                get => Unk_311_raw;
                set {
                    if (Unk_311_raw == value) return;
                    Unk_311_raw = value;
                    ChangedItems.Add(nameof(Unk_311));
                    OnPropertyChanged(nameof(Unk_311));
                }
            }

            protected float Unk_312_raw;
            public const string Unk_312_displayName = "Unk 312";
            public const int Unk_312_sortIndex = 2000;
            [SortOrder(Unk_312_sortIndex)]
            [DisplayName(Unk_312_displayName)]
            public virtual float Unk_312 {
                get => Unk_312_raw;
                set {
                    if (Unk_312_raw == value) return;
                    Unk_312_raw = value;
                    ChangedItems.Add(nameof(Unk_312));
                    OnPropertyChanged(nameof(Unk_312));
                }
            }

            protected float Unk_313_raw;
            public const string Unk_313_displayName = "Unk 313";
            public const int Unk_313_sortIndex = 2050;
            [SortOrder(Unk_313_sortIndex)]
            [DisplayName(Unk_313_displayName)]
            public virtual float Unk_313 {
                get => Unk_313_raw;
                set {
                    if (Unk_313_raw == value) return;
                    Unk_313_raw = value;
                    ChangedItems.Add(nameof(Unk_313));
                    OnPropertyChanged(nameof(Unk_313));
                }
            }

            protected float Unk_314_raw;
            public const string Unk_314_displayName = "Unk 314";
            public const int Unk_314_sortIndex = 2100;
            [SortOrder(Unk_314_sortIndex)]
            [DisplayName(Unk_314_displayName)]
            public virtual float Unk_314 {
                get => Unk_314_raw;
                set {
                    if (Unk_314_raw == value) return;
                    Unk_314_raw = value;
                    ChangedItems.Add(nameof(Unk_314));
                    OnPropertyChanged(nameof(Unk_314));
                }
            }

            protected float Unk_315_raw;
            public const string Unk_315_displayName = "Unk 315";
            public const int Unk_315_sortIndex = 2150;
            [SortOrder(Unk_315_sortIndex)]
            [DisplayName(Unk_315_displayName)]
            public virtual float Unk_315 {
                get => Unk_315_raw;
                set {
                    if (Unk_315_raw == value) return;
                    Unk_315_raw = value;
                    ChangedItems.Add(nameof(Unk_315));
                    OnPropertyChanged(nameof(Unk_315));
                }
            }

            protected float Unk_316_raw;
            public const string Unk_316_displayName = "Unk 316";
            public const int Unk_316_sortIndex = 2200;
            [SortOrder(Unk_316_sortIndex)]
            [DisplayName(Unk_316_displayName)]
            public virtual float Unk_316 {
                get => Unk_316_raw;
                set {
                    if (Unk_316_raw == value) return;
                    Unk_316_raw = value;
                    ChangedItems.Add(nameof(Unk_316));
                    OnPropertyChanged(nameof(Unk_316));
                }
            }

            protected float Unk_317_raw;
            public const string Unk_317_displayName = "Unk 317";
            public const int Unk_317_sortIndex = 2250;
            [SortOrder(Unk_317_sortIndex)]
            [DisplayName(Unk_317_displayName)]
            public virtual float Unk_317 {
                get => Unk_317_raw;
                set {
                    if (Unk_317_raw == value) return;
                    Unk_317_raw = value;
                    ChangedItems.Add(nameof(Unk_317));
                    OnPropertyChanged(nameof(Unk_317));
                }
            }

            protected float Unk_318_raw;
            public const string Unk_318_displayName = "Unk 318";
            public const int Unk_318_sortIndex = 2300;
            [SortOrder(Unk_318_sortIndex)]
            [DisplayName(Unk_318_displayName)]
            public virtual float Unk_318 {
                get => Unk_318_raw;
                set {
                    if (Unk_318_raw == value) return;
                    Unk_318_raw = value;
                    ChangedItems.Add(nameof(Unk_318));
                    OnPropertyChanged(nameof(Unk_318));
                }
            }

            protected float Unk_319_raw;
            public const string Unk_319_displayName = "Unk 319";
            public const int Unk_319_sortIndex = 2350;
            [SortOrder(Unk_319_sortIndex)]
            [DisplayName(Unk_319_displayName)]
            public virtual float Unk_319 {
                get => Unk_319_raw;
                set {
                    if (Unk_319_raw == value) return;
                    Unk_319_raw = value;
                    ChangedItems.Add(nameof(Unk_319));
                    OnPropertyChanged(nameof(Unk_319));
                }
            }

            protected float Unk_320_raw;
            public const string Unk_320_displayName = "Unk 320";
            public const int Unk_320_sortIndex = 2400;
            [SortOrder(Unk_320_sortIndex)]
            [DisplayName(Unk_320_displayName)]
            public virtual float Unk_320 {
                get => Unk_320_raw;
                set {
                    if (Unk_320_raw == value) return;
                    Unk_320_raw = value;
                    ChangedItems.Add(nameof(Unk_320));
                    OnPropertyChanged(nameof(Unk_320));
                }
            }

            protected float Unk_321_raw;
            public const string Unk_321_displayName = "Unk 321";
            public const int Unk_321_sortIndex = 2450;
            [SortOrder(Unk_321_sortIndex)]
            [DisplayName(Unk_321_displayName)]
            public virtual float Unk_321 {
                get => Unk_321_raw;
                set {
                    if (Unk_321_raw == value) return;
                    Unk_321_raw = value;
                    ChangedItems.Add(nameof(Unk_321));
                    OnPropertyChanged(nameof(Unk_321));
                }
            }

            protected float Unk_322_raw;
            public const string Unk_322_displayName = "Unk 322";
            public const int Unk_322_sortIndex = 2500;
            [SortOrder(Unk_322_sortIndex)]
            [DisplayName(Unk_322_displayName)]
            public virtual float Unk_322 {
                get => Unk_322_raw;
                set {
                    if (Unk_322_raw == value) return;
                    Unk_322_raw = value;
                    ChangedItems.Add(nameof(Unk_322));
                    OnPropertyChanged(nameof(Unk_322));
                }
            }

            protected float Unk_323_raw;
            public const string Unk_323_displayName = "Unk 323";
            public const int Unk_323_sortIndex = 2550;
            [SortOrder(Unk_323_sortIndex)]
            [DisplayName(Unk_323_displayName)]
            public virtual float Unk_323 {
                get => Unk_323_raw;
                set {
                    if (Unk_323_raw == value) return;
                    Unk_323_raw = value;
                    ChangedItems.Add(nameof(Unk_323));
                    OnPropertyChanged(nameof(Unk_323));
                }
            }

            protected float Unk_324_raw;
            public const string Unk_324_displayName = "Unk 324";
            public const int Unk_324_sortIndex = 2600;
            [SortOrder(Unk_324_sortIndex)]
            [DisplayName(Unk_324_displayName)]
            public virtual float Unk_324 {
                get => Unk_324_raw;
                set {
                    if (Unk_324_raw == value) return;
                    Unk_324_raw = value;
                    ChangedItems.Add(nameof(Unk_324));
                    OnPropertyChanged(nameof(Unk_324));
                }
            }

            protected float Unk_325_raw;
            public const string Unk_325_displayName = "Unk 325";
            public const int Unk_325_sortIndex = 2650;
            [SortOrder(Unk_325_sortIndex)]
            [DisplayName(Unk_325_displayName)]
            public virtual float Unk_325 {
                get => Unk_325_raw;
                set {
                    if (Unk_325_raw == value) return;
                    Unk_325_raw = value;
                    ChangedItems.Add(nameof(Unk_325));
                    OnPropertyChanged(nameof(Unk_325));
                }
            }

            protected float Unk_326_raw;
            public const string Unk_326_displayName = "Unk 326";
            public const int Unk_326_sortIndex = 2700;
            [SortOrder(Unk_326_sortIndex)]
            [DisplayName(Unk_326_displayName)]
            public virtual float Unk_326 {
                get => Unk_326_raw;
                set {
                    if (Unk_326_raw == value) return;
                    Unk_326_raw = value;
                    ChangedItems.Add(nameof(Unk_326));
                    OnPropertyChanged(nameof(Unk_326));
                }
            }

            protected float Unk_327_raw;
            public const string Unk_327_displayName = "Unk 327";
            public const int Unk_327_sortIndex = 2750;
            [SortOrder(Unk_327_sortIndex)]
            [DisplayName(Unk_327_displayName)]
            public virtual float Unk_327 {
                get => Unk_327_raw;
                set {
                    if (Unk_327_raw == value) return;
                    Unk_327_raw = value;
                    ChangedItems.Add(nameof(Unk_327));
                    OnPropertyChanged(nameof(Unk_327));
                }
            }

            protected float Unk_328_raw;
            public const string Unk_328_displayName = "Unk 328";
            public const int Unk_328_sortIndex = 2800;
            [SortOrder(Unk_328_sortIndex)]
            [DisplayName(Unk_328_displayName)]
            public virtual float Unk_328 {
                get => Unk_328_raw;
                set {
                    if (Unk_328_raw == value) return;
                    Unk_328_raw = value;
                    ChangedItems.Add(nameof(Unk_328));
                    OnPropertyChanged(nameof(Unk_328));
                }
            }

            protected float Unk_329_raw;
            public const string Unk_329_displayName = "Unk 329";
            public const int Unk_329_sortIndex = 2850;
            [SortOrder(Unk_329_sortIndex)]
            [DisplayName(Unk_329_displayName)]
            public virtual float Unk_329 {
                get => Unk_329_raw;
                set {
                    if (Unk_329_raw == value) return;
                    Unk_329_raw = value;
                    ChangedItems.Add(nameof(Unk_329));
                    OnPropertyChanged(nameof(Unk_329));
                }
            }

            protected uint Unk_330_raw;
            public const string Unk_330_displayName = "Unk 330";
            public const int Unk_330_sortIndex = 2900;
            [SortOrder(Unk_330_sortIndex)]
            [DisplayName(Unk_330_displayName)]
            public virtual uint Unk_330 {
                get => Unk_330_raw;
                set {
                    if (Unk_330_raw == value) return;
                    Unk_330_raw = value;
                    ChangedItems.Add(nameof(Unk_330));
                    OnPropertyChanged(nameof(Unk_330));
                }
            }

            protected uint Unk_331_raw;
            public const string Unk_331_displayName = "Unk 331";
            public const int Unk_331_sortIndex = 2950;
            [SortOrder(Unk_331_sortIndex)]
            [DisplayName(Unk_331_displayName)]
            public virtual uint Unk_331 {
                get => Unk_331_raw;
                set {
                    if (Unk_331_raw == value) return;
                    Unk_331_raw = value;
                    ChangedItems.Add(nameof(Unk_331));
                    OnPropertyChanged(nameof(Unk_331));
                }
            }

            protected float Unk_332_raw;
            public const string Unk_332_displayName = "Unk 332";
            public const int Unk_332_sortIndex = 3000;
            [SortOrder(Unk_332_sortIndex)]
            [DisplayName(Unk_332_displayName)]
            public virtual float Unk_332 {
                get => Unk_332_raw;
                set {
                    if (Unk_332_raw == value) return;
                    Unk_332_raw = value;
                    ChangedItems.Add(nameof(Unk_332));
                    OnPropertyChanged(nameof(Unk_332));
                }
            }

            protected float Unk_333_raw;
            public const string Unk_333_displayName = "Unk 333";
            public const int Unk_333_sortIndex = 3050;
            [SortOrder(Unk_333_sortIndex)]
            [DisplayName(Unk_333_displayName)]
            public virtual float Unk_333 {
                get => Unk_333_raw;
                set {
                    if (Unk_333_raw == value) return;
                    Unk_333_raw = value;
                    ChangedItems.Add(nameof(Unk_333));
                    OnPropertyChanged(nameof(Unk_333));
                }
            }

            protected float Unk_334_raw;
            public const string Unk_334_displayName = "Unk 334";
            public const int Unk_334_sortIndex = 3100;
            [SortOrder(Unk_334_sortIndex)]
            [DisplayName(Unk_334_displayName)]
            public virtual float Unk_334 {
                get => Unk_334_raw;
                set {
                    if (Unk_334_raw == value) return;
                    Unk_334_raw = value;
                    ChangedItems.Add(nameof(Unk_334));
                    OnPropertyChanged(nameof(Unk_334));
                }
            }

            protected float Unk_335_raw;
            public const string Unk_335_displayName = "Unk 335";
            public const int Unk_335_sortIndex = 3150;
            [SortOrder(Unk_335_sortIndex)]
            [DisplayName(Unk_335_displayName)]
            public virtual float Unk_335 {
                get => Unk_335_raw;
                set {
                    if (Unk_335_raw == value) return;
                    Unk_335_raw = value;
                    ChangedItems.Add(nameof(Unk_335));
                    OnPropertyChanged(nameof(Unk_335));
                }
            }

            protected float Unk_336_raw;
            public const string Unk_336_displayName = "Unk 336";
            public const int Unk_336_sortIndex = 3200;
            [SortOrder(Unk_336_sortIndex)]
            [DisplayName(Unk_336_displayName)]
            public virtual float Unk_336 {
                get => Unk_336_raw;
                set {
                    if (Unk_336_raw == value) return;
                    Unk_336_raw = value;
                    ChangedItems.Add(nameof(Unk_336));
                    OnPropertyChanged(nameof(Unk_336));
                }
            }

            protected float Unk_337_raw;
            public const string Unk_337_displayName = "Unk 337";
            public const int Unk_337_sortIndex = 3250;
            [SortOrder(Unk_337_sortIndex)]
            [DisplayName(Unk_337_displayName)]
            public virtual float Unk_337 {
                get => Unk_337_raw;
                set {
                    if (Unk_337_raw == value) return;
                    Unk_337_raw = value;
                    ChangedItems.Add(nameof(Unk_337));
                    OnPropertyChanged(nameof(Unk_337));
                }
            }

            protected float Unk_338_raw;
            public const string Unk_338_displayName = "Unk 338";
            public const int Unk_338_sortIndex = 3300;
            [SortOrder(Unk_338_sortIndex)]
            [DisplayName(Unk_338_displayName)]
            public virtual float Unk_338 {
                get => Unk_338_raw;
                set {
                    if (Unk_338_raw == value) return;
                    Unk_338_raw = value;
                    ChangedItems.Add(nameof(Unk_338));
                    OnPropertyChanged(nameof(Unk_338));
                }
            }

            protected float Unk_339_raw;
            public const string Unk_339_displayName = "Unk 339";
            public const int Unk_339_sortIndex = 3350;
            [SortOrder(Unk_339_sortIndex)]
            [DisplayName(Unk_339_displayName)]
            public virtual float Unk_339 {
                get => Unk_339_raw;
                set {
                    if (Unk_339_raw == value) return;
                    Unk_339_raw = value;
                    ChangedItems.Add(nameof(Unk_339));
                    OnPropertyChanged(nameof(Unk_339));
                }
            }

            protected float Unk_340_raw;
            public const string Unk_340_displayName = "Unk 340";
            public const int Unk_340_sortIndex = 3400;
            [SortOrder(Unk_340_sortIndex)]
            [DisplayName(Unk_340_displayName)]
            public virtual float Unk_340 {
                get => Unk_340_raw;
                set {
                    if (Unk_340_raw == value) return;
                    Unk_340_raw = value;
                    ChangedItems.Add(nameof(Unk_340));
                    OnPropertyChanged(nameof(Unk_340));
                }
            }

            protected float Unk_341_raw;
            public const string Unk_341_displayName = "Unk 341";
            public const int Unk_341_sortIndex = 3450;
            [SortOrder(Unk_341_sortIndex)]
            [DisplayName(Unk_341_displayName)]
            public virtual float Unk_341 {
                get => Unk_341_raw;
                set {
                    if (Unk_341_raw == value) return;
                    Unk_341_raw = value;
                    ChangedItems.Add(nameof(Unk_341));
                    OnPropertyChanged(nameof(Unk_341));
                }
            }

            protected float Unk_342_raw;
            public const string Unk_342_displayName = "Unk 342";
            public const int Unk_342_sortIndex = 3500;
            [SortOrder(Unk_342_sortIndex)]
            [DisplayName(Unk_342_displayName)]
            public virtual float Unk_342 {
                get => Unk_342_raw;
                set {
                    if (Unk_342_raw == value) return;
                    Unk_342_raw = value;
                    ChangedItems.Add(nameof(Unk_342));
                    OnPropertyChanged(nameof(Unk_342));
                }
            }

            protected float Unk_343_raw;
            public const string Unk_343_displayName = "Unk 343";
            public const int Unk_343_sortIndex = 3550;
            [SortOrder(Unk_343_sortIndex)]
            [DisplayName(Unk_343_displayName)]
            public virtual float Unk_343 {
                get => Unk_343_raw;
                set {
                    if (Unk_343_raw == value) return;
                    Unk_343_raw = value;
                    ChangedItems.Add(nameof(Unk_343));
                    OnPropertyChanged(nameof(Unk_343));
                }
            }

            protected float Unk_344_raw;
            public const string Unk_344_displayName = "Unk 344";
            public const int Unk_344_sortIndex = 3600;
            [SortOrder(Unk_344_sortIndex)]
            [DisplayName(Unk_344_displayName)]
            public virtual float Unk_344 {
                get => Unk_344_raw;
                set {
                    if (Unk_344_raw == value) return;
                    Unk_344_raw = value;
                    ChangedItems.Add(nameof(Unk_344));
                    OnPropertyChanged(nameof(Unk_344));
                }
            }

            protected float Unk_345_raw;
            public const string Unk_345_displayName = "Unk 345";
            public const int Unk_345_sortIndex = 3650;
            [SortOrder(Unk_345_sortIndex)]
            [DisplayName(Unk_345_displayName)]
            public virtual float Unk_345 {
                get => Unk_345_raw;
                set {
                    if (Unk_345_raw == value) return;
                    Unk_345_raw = value;
                    ChangedItems.Add(nameof(Unk_345));
                    OnPropertyChanged(nameof(Unk_345));
                }
            }

            protected float Unk_346_raw;
            public const string Unk_346_displayName = "Unk 346";
            public const int Unk_346_sortIndex = 3700;
            [SortOrder(Unk_346_sortIndex)]
            [DisplayName(Unk_346_displayName)]
            public virtual float Unk_346 {
                get => Unk_346_raw;
                set {
                    if (Unk_346_raw == value) return;
                    Unk_346_raw = value;
                    ChangedItems.Add(nameof(Unk_346));
                    OnPropertyChanged(nameof(Unk_346));
                }
            }

            protected float Unk_347_raw;
            public const string Unk_347_displayName = "Unk 347";
            public const int Unk_347_sortIndex = 3750;
            [SortOrder(Unk_347_sortIndex)]
            [DisplayName(Unk_347_displayName)]
            public virtual float Unk_347 {
                get => Unk_347_raw;
                set {
                    if (Unk_347_raw == value) return;
                    Unk_347_raw = value;
                    ChangedItems.Add(nameof(Unk_347));
                    OnPropertyChanged(nameof(Unk_347));
                }
            }

            protected float Unk_348_raw;
            public const string Unk_348_displayName = "Unk 348";
            public const int Unk_348_sortIndex = 3800;
            [SortOrder(Unk_348_sortIndex)]
            [DisplayName(Unk_348_displayName)]
            public virtual float Unk_348 {
                get => Unk_348_raw;
                set {
                    if (Unk_348_raw == value) return;
                    Unk_348_raw = value;
                    ChangedItems.Add(nameof(Unk_348));
                    OnPropertyChanged(nameof(Unk_348));
                }
            }

            protected float Unk_349_raw;
            public const string Unk_349_displayName = "Unk 349";
            public const int Unk_349_sortIndex = 3850;
            [SortOrder(Unk_349_sortIndex)]
            [DisplayName(Unk_349_displayName)]
            public virtual float Unk_349 {
                get => Unk_349_raw;
                set {
                    if (Unk_349_raw == value) return;
                    Unk_349_raw = value;
                    ChangedItems.Add(nameof(Unk_349));
                    OnPropertyChanged(nameof(Unk_349));
                }
            }

            protected float Unk_350_raw;
            public const string Unk_350_displayName = "Unk 350";
            public const int Unk_350_sortIndex = 3900;
            [SortOrder(Unk_350_sortIndex)]
            [DisplayName(Unk_350_displayName)]
            public virtual float Unk_350 {
                get => Unk_350_raw;
                set {
                    if (Unk_350_raw == value) return;
                    Unk_350_raw = value;
                    ChangedItems.Add(nameof(Unk_350));
                    OnPropertyChanged(nameof(Unk_350));
                }
            }

            protected float Unk_351_raw;
            public const string Unk_351_displayName = "Unk 351";
            public const int Unk_351_sortIndex = 3950;
            [SortOrder(Unk_351_sortIndex)]
            [DisplayName(Unk_351_displayName)]
            public virtual float Unk_351 {
                get => Unk_351_raw;
                set {
                    if (Unk_351_raw == value) return;
                    Unk_351_raw = value;
                    ChangedItems.Add(nameof(Unk_351));
                    OnPropertyChanged(nameof(Unk_351));
                }
            }

            protected float Unk_352_raw;
            public const string Unk_352_displayName = "Unk 352";
            public const int Unk_352_sortIndex = 4000;
            [SortOrder(Unk_352_sortIndex)]
            [DisplayName(Unk_352_displayName)]
            public virtual float Unk_352 {
                get => Unk_352_raw;
                set {
                    if (Unk_352_raw == value) return;
                    Unk_352_raw = value;
                    ChangedItems.Add(nameof(Unk_352));
                    OnPropertyChanged(nameof(Unk_352));
                }
            }

            protected float Unk_353_raw;
            public const string Unk_353_displayName = "Unk 353";
            public const int Unk_353_sortIndex = 4050;
            [SortOrder(Unk_353_sortIndex)]
            [DisplayName(Unk_353_displayName)]
            public virtual float Unk_353 {
                get => Unk_353_raw;
                set {
                    if (Unk_353_raw == value) return;
                    Unk_353_raw = value;
                    ChangedItems.Add(nameof(Unk_353));
                    OnPropertyChanged(nameof(Unk_353));
                }
            }

            protected float Unk_354_raw;
            public const string Unk_354_displayName = "Unk 354";
            public const int Unk_354_sortIndex = 4100;
            [SortOrder(Unk_354_sortIndex)]
            [DisplayName(Unk_354_displayName)]
            public virtual float Unk_354 {
                get => Unk_354_raw;
                set {
                    if (Unk_354_raw == value) return;
                    Unk_354_raw = value;
                    ChangedItems.Add(nameof(Unk_354));
                    OnPropertyChanged(nameof(Unk_354));
                }
            }

            protected float Unk_355_raw;
            public const string Unk_355_displayName = "Unk 355";
            public const int Unk_355_sortIndex = 4150;
            [SortOrder(Unk_355_sortIndex)]
            [DisplayName(Unk_355_displayName)]
            public virtual float Unk_355 {
                get => Unk_355_raw;
                set {
                    if (Unk_355_raw == value) return;
                    Unk_355_raw = value;
                    ChangedItems.Add(nameof(Unk_355));
                    OnPropertyChanged(nameof(Unk_355));
                }
            }

            protected float Unk_356_raw;
            public const string Unk_356_displayName = "Unk 356";
            public const int Unk_356_sortIndex = 4200;
            [SortOrder(Unk_356_sortIndex)]
            [DisplayName(Unk_356_displayName)]
            public virtual float Unk_356 {
                get => Unk_356_raw;
                set {
                    if (Unk_356_raw == value) return;
                    Unk_356_raw = value;
                    ChangedItems.Add(nameof(Unk_356));
                    OnPropertyChanged(nameof(Unk_356));
                }
            }

            protected float Unk_357_raw;
            public const string Unk_357_displayName = "Unk 357";
            public const int Unk_357_sortIndex = 4250;
            [SortOrder(Unk_357_sortIndex)]
            [DisplayName(Unk_357_displayName)]
            public virtual float Unk_357 {
                get => Unk_357_raw;
                set {
                    if (Unk_357_raw == value) return;
                    Unk_357_raw = value;
                    ChangedItems.Add(nameof(Unk_357));
                    OnPropertyChanged(nameof(Unk_357));
                }
            }

            protected float Unk_358_raw;
            public const string Unk_358_displayName = "Unk 358";
            public const int Unk_358_sortIndex = 4300;
            [SortOrder(Unk_358_sortIndex)]
            [DisplayName(Unk_358_displayName)]
            public virtual float Unk_358 {
                get => Unk_358_raw;
                set {
                    if (Unk_358_raw == value) return;
                    Unk_358_raw = value;
                    ChangedItems.Add(nameof(Unk_358));
                    OnPropertyChanged(nameof(Unk_358));
                }
            }

            protected float Unk_359_raw;
            public const string Unk_359_displayName = "Unk 359";
            public const int Unk_359_sortIndex = 4350;
            [SortOrder(Unk_359_sortIndex)]
            [DisplayName(Unk_359_displayName)]
            public virtual float Unk_359 {
                get => Unk_359_raw;
                set {
                    if (Unk_359_raw == value) return;
                    Unk_359_raw = value;
                    ChangedItems.Add(nameof(Unk_359));
                    OnPropertyChanged(nameof(Unk_359));
                }
            }

            protected float Unk_360_raw;
            public const string Unk_360_displayName = "Unk 360";
            public const int Unk_360_sortIndex = 4400;
            [SortOrder(Unk_360_sortIndex)]
            [DisplayName(Unk_360_displayName)]
            public virtual float Unk_360 {
                get => Unk_360_raw;
                set {
                    if (Unk_360_raw == value) return;
                    Unk_360_raw = value;
                    ChangedItems.Add(nameof(Unk_360));
                    OnPropertyChanged(nameof(Unk_360));
                }
            }

            protected float Unk_361_raw;
            public const string Unk_361_displayName = "Unk 361";
            public const int Unk_361_sortIndex = 4450;
            [SortOrder(Unk_361_sortIndex)]
            [DisplayName(Unk_361_displayName)]
            public virtual float Unk_361 {
                get => Unk_361_raw;
                set {
                    if (Unk_361_raw == value) return;
                    Unk_361_raw = value;
                    ChangedItems.Add(nameof(Unk_361));
                    OnPropertyChanged(nameof(Unk_361));
                }
            }

            protected float Unk_362_raw;
            public const string Unk_362_displayName = "Unk 362";
            public const int Unk_362_sortIndex = 4500;
            [SortOrder(Unk_362_sortIndex)]
            [DisplayName(Unk_362_displayName)]
            public virtual float Unk_362 {
                get => Unk_362_raw;
                set {
                    if (Unk_362_raw == value) return;
                    Unk_362_raw = value;
                    ChangedItems.Add(nameof(Unk_362));
                    OnPropertyChanged(nameof(Unk_362));
                }
            }

            protected float Unk_363_raw;
            public const string Unk_363_displayName = "Unk 363";
            public const int Unk_363_sortIndex = 4550;
            [SortOrder(Unk_363_sortIndex)]
            [DisplayName(Unk_363_displayName)]
            public virtual float Unk_363 {
                get => Unk_363_raw;
                set {
                    if (Unk_363_raw == value) return;
                    Unk_363_raw = value;
                    ChangedItems.Add(nameof(Unk_363));
                    OnPropertyChanged(nameof(Unk_363));
                }
            }

            protected float Unk_364_raw;
            public const string Unk_364_displayName = "Unk 364";
            public const int Unk_364_sortIndex = 4600;
            [SortOrder(Unk_364_sortIndex)]
            [DisplayName(Unk_364_displayName)]
            public virtual float Unk_364 {
                get => Unk_364_raw;
                set {
                    if (Unk_364_raw == value) return;
                    Unk_364_raw = value;
                    ChangedItems.Add(nameof(Unk_364));
                    OnPropertyChanged(nameof(Unk_364));
                }
            }

            protected float Unk_365_raw;
            public const string Unk_365_displayName = "Unk 365";
            public const int Unk_365_sortIndex = 4650;
            [SortOrder(Unk_365_sortIndex)]
            [DisplayName(Unk_365_displayName)]
            public virtual float Unk_365 {
                get => Unk_365_raw;
                set {
                    if (Unk_365_raw == value) return;
                    Unk_365_raw = value;
                    ChangedItems.Add(nameof(Unk_365));
                    OnPropertyChanged(nameof(Unk_365));
                }
            }

            protected float Unk_366_raw;
            public const string Unk_366_displayName = "Unk 366";
            public const int Unk_366_sortIndex = 4700;
            [SortOrder(Unk_366_sortIndex)]
            [DisplayName(Unk_366_displayName)]
            public virtual float Unk_366 {
                get => Unk_366_raw;
                set {
                    if (Unk_366_raw == value) return;
                    Unk_366_raw = value;
                    ChangedItems.Add(nameof(Unk_366));
                    OnPropertyChanged(nameof(Unk_366));
                }
            }

            protected float Unk_367_raw;
            public const string Unk_367_displayName = "Unk 367";
            public const int Unk_367_sortIndex = 4750;
            [SortOrder(Unk_367_sortIndex)]
            [DisplayName(Unk_367_displayName)]
            public virtual float Unk_367 {
                get => Unk_367_raw;
                set {
                    if (Unk_367_raw == value) return;
                    Unk_367_raw = value;
                    ChangedItems.Add(nameof(Unk_367));
                    OnPropertyChanged(nameof(Unk_367));
                }
            }

            protected float Unk_368_raw;
            public const string Unk_368_displayName = "Unk 368";
            public const int Unk_368_sortIndex = 4800;
            [SortOrder(Unk_368_sortIndex)]
            [DisplayName(Unk_368_displayName)]
            public virtual float Unk_368 {
                get => Unk_368_raw;
                set {
                    if (Unk_368_raw == value) return;
                    Unk_368_raw = value;
                    ChangedItems.Add(nameof(Unk_368));
                    OnPropertyChanged(nameof(Unk_368));
                }
            }

            protected float Unk_369_raw;
            public const string Unk_369_displayName = "Unk 369";
            public const int Unk_369_sortIndex = 4850;
            [SortOrder(Unk_369_sortIndex)]
            [DisplayName(Unk_369_displayName)]
            public virtual float Unk_369 {
                get => Unk_369_raw;
                set {
                    if (Unk_369_raw == value) return;
                    Unk_369_raw = value;
                    ChangedItems.Add(nameof(Unk_369));
                    OnPropertyChanged(nameof(Unk_369));
                }
            }

            protected float Unk_370_raw;
            public const string Unk_370_displayName = "Unk 370";
            public const int Unk_370_sortIndex = 4900;
            [SortOrder(Unk_370_sortIndex)]
            [DisplayName(Unk_370_displayName)]
            public virtual float Unk_370 {
                get => Unk_370_raw;
                set {
                    if (Unk_370_raw == value) return;
                    Unk_370_raw = value;
                    ChangedItems.Add(nameof(Unk_370));
                    OnPropertyChanged(nameof(Unk_370));
                }
            }

            protected float Unk_371_raw;
            public const string Unk_371_displayName = "Unk 371";
            public const int Unk_371_sortIndex = 4950;
            [SortOrder(Unk_371_sortIndex)]
            [DisplayName(Unk_371_displayName)]
            public virtual float Unk_371 {
                get => Unk_371_raw;
                set {
                    if (Unk_371_raw == value) return;
                    Unk_371_raw = value;
                    ChangedItems.Add(nameof(Unk_371));
                    OnPropertyChanged(nameof(Unk_371));
                }
            }

            protected float Unk_372_raw;
            public const string Unk_372_displayName = "Unk 372";
            public const int Unk_372_sortIndex = 5000;
            [SortOrder(Unk_372_sortIndex)]
            [DisplayName(Unk_372_displayName)]
            public virtual float Unk_372 {
                get => Unk_372_raw;
                set {
                    if (Unk_372_raw == value) return;
                    Unk_372_raw = value;
                    ChangedItems.Add(nameof(Unk_372));
                    OnPropertyChanged(nameof(Unk_372));
                }
            }

            protected float Unk_373_raw;
            public const string Unk_373_displayName = "Unk 373";
            public const int Unk_373_sortIndex = 5050;
            [SortOrder(Unk_373_sortIndex)]
            [DisplayName(Unk_373_displayName)]
            public virtual float Unk_373 {
                get => Unk_373_raw;
                set {
                    if (Unk_373_raw == value) return;
                    Unk_373_raw = value;
                    ChangedItems.Add(nameof(Unk_373));
                    OnPropertyChanged(nameof(Unk_373));
                }
            }

            protected float Unk_374_raw;
            public const string Unk_374_displayName = "Unk 374";
            public const int Unk_374_sortIndex = 5100;
            [SortOrder(Unk_374_sortIndex)]
            [DisplayName(Unk_374_displayName)]
            public virtual float Unk_374 {
                get => Unk_374_raw;
                set {
                    if (Unk_374_raw == value) return;
                    Unk_374_raw = value;
                    ChangedItems.Add(nameof(Unk_374));
                    OnPropertyChanged(nameof(Unk_374));
                }
            }

            protected float Unk_375_raw;
            public const string Unk_375_displayName = "Unk 375";
            public const int Unk_375_sortIndex = 5150;
            [SortOrder(Unk_375_sortIndex)]
            [DisplayName(Unk_375_displayName)]
            public virtual float Unk_375 {
                get => Unk_375_raw;
                set {
                    if (Unk_375_raw == value) return;
                    Unk_375_raw = value;
                    ChangedItems.Add(nameof(Unk_375));
                    OnPropertyChanged(nameof(Unk_375));
                }
            }

            protected float Unk_376_raw;
            public const string Unk_376_displayName = "Unk 376";
            public const int Unk_376_sortIndex = 5200;
            [SortOrder(Unk_376_sortIndex)]
            [DisplayName(Unk_376_displayName)]
            public virtual float Unk_376 {
                get => Unk_376_raw;
                set {
                    if (Unk_376_raw == value) return;
                    Unk_376_raw = value;
                    ChangedItems.Add(nameof(Unk_376));
                    OnPropertyChanged(nameof(Unk_376));
                }
            }

            protected float Unk_377_raw;
            public const string Unk_377_displayName = "Unk 377";
            public const int Unk_377_sortIndex = 5250;
            [SortOrder(Unk_377_sortIndex)]
            [DisplayName(Unk_377_displayName)]
            public virtual float Unk_377 {
                get => Unk_377_raw;
                set {
                    if (Unk_377_raw == value) return;
                    Unk_377_raw = value;
                    ChangedItems.Add(nameof(Unk_377));
                    OnPropertyChanged(nameof(Unk_377));
                }
            }

            protected float Unk_378_raw;
            public const string Unk_378_displayName = "Unk 378";
            public const int Unk_378_sortIndex = 5300;
            [SortOrder(Unk_378_sortIndex)]
            [DisplayName(Unk_378_displayName)]
            public virtual float Unk_378 {
                get => Unk_378_raw;
                set {
                    if (Unk_378_raw == value) return;
                    Unk_378_raw = value;
                    ChangedItems.Add(nameof(Unk_378));
                    OnPropertyChanged(nameof(Unk_378));
                }
            }

            protected float Unk_379_raw;
            public const string Unk_379_displayName = "Unk 379";
            public const int Unk_379_sortIndex = 5350;
            [SortOrder(Unk_379_sortIndex)]
            [DisplayName(Unk_379_displayName)]
            public virtual float Unk_379 {
                get => Unk_379_raw;
                set {
                    if (Unk_379_raw == value) return;
                    Unk_379_raw = value;
                    ChangedItems.Add(nameof(Unk_379));
                    OnPropertyChanged(nameof(Unk_379));
                }
            }

            protected float Unk_380_raw;
            public const string Unk_380_displayName = "Unk 380";
            public const int Unk_380_sortIndex = 5400;
            [SortOrder(Unk_380_sortIndex)]
            [DisplayName(Unk_380_displayName)]
            public virtual float Unk_380 {
                get => Unk_380_raw;
                set {
                    if (Unk_380_raw == value) return;
                    Unk_380_raw = value;
                    ChangedItems.Add(nameof(Unk_380));
                    OnPropertyChanged(nameof(Unk_380));
                }
            }

            protected float Unk_381_raw;
            public const string Unk_381_displayName = "Unk 381";
            public const int Unk_381_sortIndex = 5450;
            [SortOrder(Unk_381_sortIndex)]
            [DisplayName(Unk_381_displayName)]
            public virtual float Unk_381 {
                get => Unk_381_raw;
                set {
                    if (Unk_381_raw == value) return;
                    Unk_381_raw = value;
                    ChangedItems.Add(nameof(Unk_381));
                    OnPropertyChanged(nameof(Unk_381));
                }
            }

            protected float Unk_382_raw;
            public const string Unk_382_displayName = "Unk 382";
            public const int Unk_382_sortIndex = 5500;
            [SortOrder(Unk_382_sortIndex)]
            [DisplayName(Unk_382_displayName)]
            public virtual float Unk_382 {
                get => Unk_382_raw;
                set {
                    if (Unk_382_raw == value) return;
                    Unk_382_raw = value;
                    ChangedItems.Add(nameof(Unk_382));
                    OnPropertyChanged(nameof(Unk_382));
                }
            }

            protected float Unk_383_raw;
            public const string Unk_383_displayName = "Unk 383";
            public const int Unk_383_sortIndex = 5550;
            [SortOrder(Unk_383_sortIndex)]
            [DisplayName(Unk_383_displayName)]
            public virtual float Unk_383 {
                get => Unk_383_raw;
                set {
                    if (Unk_383_raw == value) return;
                    Unk_383_raw = value;
                    ChangedItems.Add(nameof(Unk_383));
                    OnPropertyChanged(nameof(Unk_383));
                }
            }

            protected float Unk_384_raw;
            public const string Unk_384_displayName = "Unk 384";
            public const int Unk_384_sortIndex = 5600;
            [SortOrder(Unk_384_sortIndex)]
            [DisplayName(Unk_384_displayName)]
            public virtual float Unk_384 {
                get => Unk_384_raw;
                set {
                    if (Unk_384_raw == value) return;
                    Unk_384_raw = value;
                    ChangedItems.Add(nameof(Unk_384));
                    OnPropertyChanged(nameof(Unk_384));
                }
            }

            protected uint Unk_385_raw;
            public const string Unk_385_displayName = "Unk 385";
            public const int Unk_385_sortIndex = 5650;
            [SortOrder(Unk_385_sortIndex)]
            [DisplayName(Unk_385_displayName)]
            public virtual uint Unk_385 {
                get => Unk_385_raw;
                set {
                    if (Unk_385_raw == value) return;
                    Unk_385_raw = value;
                    ChangedItems.Add(nameof(Unk_385));
                    OnPropertyChanged(nameof(Unk_385));
                }
            }

            protected float Unk_386_raw;
            public const string Unk_386_displayName = "Unk 386";
            public const int Unk_386_sortIndex = 5700;
            [SortOrder(Unk_386_sortIndex)]
            [DisplayName(Unk_386_displayName)]
            public virtual float Unk_386 {
                get => Unk_386_raw;
                set {
                    if (Unk_386_raw == value) return;
                    Unk_386_raw = value;
                    ChangedItems.Add(nameof(Unk_386));
                    OnPropertyChanged(nameof(Unk_386));
                }
            }

            protected float Unk_387_raw;
            public const string Unk_387_displayName = "Unk 387";
            public const int Unk_387_sortIndex = 5750;
            [SortOrder(Unk_387_sortIndex)]
            [DisplayName(Unk_387_displayName)]
            public virtual float Unk_387 {
                get => Unk_387_raw;
                set {
                    if (Unk_387_raw == value) return;
                    Unk_387_raw = value;
                    ChangedItems.Add(nameof(Unk_387));
                    OnPropertyChanged(nameof(Unk_387));
                }
            }

            protected float Unk_388_raw;
            public const string Unk_388_displayName = "Unk 388";
            public const int Unk_388_sortIndex = 5800;
            [SortOrder(Unk_388_sortIndex)]
            [DisplayName(Unk_388_displayName)]
            public virtual float Unk_388 {
                get => Unk_388_raw;
                set {
                    if (Unk_388_raw == value) return;
                    Unk_388_raw = value;
                    ChangedItems.Add(nameof(Unk_388));
                    OnPropertyChanged(nameof(Unk_388));
                }
            }

            protected float Unk_389_raw;
            public const string Unk_389_displayName = "Unk 389";
            public const int Unk_389_sortIndex = 5850;
            [SortOrder(Unk_389_sortIndex)]
            [DisplayName(Unk_389_displayName)]
            public virtual float Unk_389 {
                get => Unk_389_raw;
                set {
                    if (Unk_389_raw == value) return;
                    Unk_389_raw = value;
                    ChangedItems.Add(nameof(Unk_389));
                    OnPropertyChanged(nameof(Unk_389));
                }
            }

            protected float Unk_390_raw;
            public const string Unk_390_displayName = "Unk 390";
            public const int Unk_390_sortIndex = 5900;
            [SortOrder(Unk_390_sortIndex)]
            [DisplayName(Unk_390_displayName)]
            public virtual float Unk_390 {
                get => Unk_390_raw;
                set {
                    if (Unk_390_raw == value) return;
                    Unk_390_raw = value;
                    ChangedItems.Add(nameof(Unk_390));
                    OnPropertyChanged(nameof(Unk_390));
                }
            }

            protected float Unk_391_raw;
            public const string Unk_391_displayName = "Unk 391";
            public const int Unk_391_sortIndex = 5950;
            [SortOrder(Unk_391_sortIndex)]
            [DisplayName(Unk_391_displayName)]
            public virtual float Unk_391 {
                get => Unk_391_raw;
                set {
                    if (Unk_391_raw == value) return;
                    Unk_391_raw = value;
                    ChangedItems.Add(nameof(Unk_391));
                    OnPropertyChanged(nameof(Unk_391));
                }
            }

            protected float Unk_392_raw;
            public const string Unk_392_displayName = "Unk 392";
            public const int Unk_392_sortIndex = 6000;
            [SortOrder(Unk_392_sortIndex)]
            [DisplayName(Unk_392_displayName)]
            public virtual float Unk_392 {
                get => Unk_392_raw;
                set {
                    if (Unk_392_raw == value) return;
                    Unk_392_raw = value;
                    ChangedItems.Add(nameof(Unk_392));
                    OnPropertyChanged(nameof(Unk_392));
                }
            }

            protected float Unk_393_raw;
            public const string Unk_393_displayName = "Unk 393";
            public const int Unk_393_sortIndex = 6050;
            [SortOrder(Unk_393_sortIndex)]
            [DisplayName(Unk_393_displayName)]
            public virtual float Unk_393 {
                get => Unk_393_raw;
                set {
                    if (Unk_393_raw == value) return;
                    Unk_393_raw = value;
                    ChangedItems.Add(nameof(Unk_393));
                    OnPropertyChanged(nameof(Unk_393));
                }
            }

            protected float Unk_394_raw;
            public const string Unk_394_displayName = "Unk 394";
            public const int Unk_394_sortIndex = 6100;
            [SortOrder(Unk_394_sortIndex)]
            [DisplayName(Unk_394_displayName)]
            public virtual float Unk_394 {
                get => Unk_394_raw;
                set {
                    if (Unk_394_raw == value) return;
                    Unk_394_raw = value;
                    ChangedItems.Add(nameof(Unk_394));
                    OnPropertyChanged(nameof(Unk_394));
                }
            }

            protected float Unk_395_raw;
            public const string Unk_395_displayName = "Unk 395";
            public const int Unk_395_sortIndex = 6150;
            [SortOrder(Unk_395_sortIndex)]
            [DisplayName(Unk_395_displayName)]
            public virtual float Unk_395 {
                get => Unk_395_raw;
                set {
                    if (Unk_395_raw == value) return;
                    Unk_395_raw = value;
                    ChangedItems.Add(nameof(Unk_395));
                    OnPropertyChanged(nameof(Unk_395));
                }
            }

            protected float Unk_396_raw;
            public const string Unk_396_displayName = "Unk 396";
            public const int Unk_396_sortIndex = 6200;
            [SortOrder(Unk_396_sortIndex)]
            [DisplayName(Unk_396_displayName)]
            public virtual float Unk_396 {
                get => Unk_396_raw;
                set {
                    if (Unk_396_raw == value) return;
                    Unk_396_raw = value;
                    ChangedItems.Add(nameof(Unk_396));
                    OnPropertyChanged(nameof(Unk_396));
                }
            }

            protected float Unk_397_raw;
            public const string Unk_397_displayName = "Unk 397";
            public const int Unk_397_sortIndex = 6250;
            [SortOrder(Unk_397_sortIndex)]
            [DisplayName(Unk_397_displayName)]
            public virtual float Unk_397 {
                get => Unk_397_raw;
                set {
                    if (Unk_397_raw == value) return;
                    Unk_397_raw = value;
                    ChangedItems.Add(nameof(Unk_397));
                    OnPropertyChanged(nameof(Unk_397));
                }
            }

            protected float Unk_398_raw;
            public const string Unk_398_displayName = "Unk 398";
            public const int Unk_398_sortIndex = 6300;
            [SortOrder(Unk_398_sortIndex)]
            [DisplayName(Unk_398_displayName)]
            public virtual float Unk_398 {
                get => Unk_398_raw;
                set {
                    if (Unk_398_raw == value) return;
                    Unk_398_raw = value;
                    ChangedItems.Add(nameof(Unk_398));
                    OnPropertyChanged(nameof(Unk_398));
                }
            }

            protected float Unk_399_raw;
            public const string Unk_399_displayName = "Unk 399";
            public const int Unk_399_sortIndex = 6350;
            [SortOrder(Unk_399_sortIndex)]
            [DisplayName(Unk_399_displayName)]
            public virtual float Unk_399 {
                get => Unk_399_raw;
                set {
                    if (Unk_399_raw == value) return;
                    Unk_399_raw = value;
                    ChangedItems.Add(nameof(Unk_399));
                    OnPropertyChanged(nameof(Unk_399));
                }
            }

            protected float Unk_400_raw;
            public const string Unk_400_displayName = "Unk 400";
            public const int Unk_400_sortIndex = 6400;
            [SortOrder(Unk_400_sortIndex)]
            [DisplayName(Unk_400_displayName)]
            public virtual float Unk_400 {
                get => Unk_400_raw;
                set {
                    if (Unk_400_raw == value) return;
                    Unk_400_raw = value;
                    ChangedItems.Add(nameof(Unk_400));
                    OnPropertyChanged(nameof(Unk_400));
                }
            }

            protected float Unk_401_raw;
            public const string Unk_401_displayName = "Unk 401";
            public const int Unk_401_sortIndex = 6450;
            [SortOrder(Unk_401_sortIndex)]
            [DisplayName(Unk_401_displayName)]
            public virtual float Unk_401 {
                get => Unk_401_raw;
                set {
                    if (Unk_401_raw == value) return;
                    Unk_401_raw = value;
                    ChangedItems.Add(nameof(Unk_401));
                    OnPropertyChanged(nameof(Unk_401));
                }
            }

            protected float Unk_402_raw;
            public const string Unk_402_displayName = "Unk 402";
            public const int Unk_402_sortIndex = 6500;
            [SortOrder(Unk_402_sortIndex)]
            [DisplayName(Unk_402_displayName)]
            public virtual float Unk_402 {
                get => Unk_402_raw;
                set {
                    if (Unk_402_raw == value) return;
                    Unk_402_raw = value;
                    ChangedItems.Add(nameof(Unk_402));
                    OnPropertyChanged(nameof(Unk_402));
                }
            }

            protected float Unk_403_raw;
            public const string Unk_403_displayName = "Unk 403";
            public const int Unk_403_sortIndex = 6550;
            [SortOrder(Unk_403_sortIndex)]
            [DisplayName(Unk_403_displayName)]
            public virtual float Unk_403 {
                get => Unk_403_raw;
                set {
                    if (Unk_403_raw == value) return;
                    Unk_403_raw = value;
                    ChangedItems.Add(nameof(Unk_403));
                    OnPropertyChanged(nameof(Unk_403));
                }
            }

            protected float Unk_404_raw;
            public const string Unk_404_displayName = "Unk 404";
            public const int Unk_404_sortIndex = 6600;
            [SortOrder(Unk_404_sortIndex)]
            [DisplayName(Unk_404_displayName)]
            public virtual float Unk_404 {
                get => Unk_404_raw;
                set {
                    if (Unk_404_raw == value) return;
                    Unk_404_raw = value;
                    ChangedItems.Add(nameof(Unk_404));
                    OnPropertyChanged(nameof(Unk_404));
                }
            }

            protected float Unk_405_raw;
            public const string Unk_405_displayName = "Unk 405";
            public const int Unk_405_sortIndex = 6650;
            [SortOrder(Unk_405_sortIndex)]
            [DisplayName(Unk_405_displayName)]
            public virtual float Unk_405 {
                get => Unk_405_raw;
                set {
                    if (Unk_405_raw == value) return;
                    Unk_405_raw = value;
                    ChangedItems.Add(nameof(Unk_405));
                    OnPropertyChanged(nameof(Unk_405));
                }
            }

            protected float Unk_406_raw;
            public const string Unk_406_displayName = "Unk 406";
            public const int Unk_406_sortIndex = 6700;
            [SortOrder(Unk_406_sortIndex)]
            [DisplayName(Unk_406_displayName)]
            public virtual float Unk_406 {
                get => Unk_406_raw;
                set {
                    if (Unk_406_raw == value) return;
                    Unk_406_raw = value;
                    ChangedItems.Add(nameof(Unk_406));
                    OnPropertyChanged(nameof(Unk_406));
                }
            }

            protected float Unk_407_raw;
            public const string Unk_407_displayName = "Unk 407";
            public const int Unk_407_sortIndex = 6750;
            [SortOrder(Unk_407_sortIndex)]
            [DisplayName(Unk_407_displayName)]
            public virtual float Unk_407 {
                get => Unk_407_raw;
                set {
                    if (Unk_407_raw == value) return;
                    Unk_407_raw = value;
                    ChangedItems.Add(nameof(Unk_407));
                    OnPropertyChanged(nameof(Unk_407));
                }
            }

            protected float Unk_408_raw;
            public const string Unk_408_displayName = "Unk 408";
            public const int Unk_408_sortIndex = 6800;
            [SortOrder(Unk_408_sortIndex)]
            [DisplayName(Unk_408_displayName)]
            public virtual float Unk_408 {
                get => Unk_408_raw;
                set {
                    if (Unk_408_raw == value) return;
                    Unk_408_raw = value;
                    ChangedItems.Add(nameof(Unk_408));
                    OnPropertyChanged(nameof(Unk_408));
                }
            }

            protected float Unk_409_raw;
            public const string Unk_409_displayName = "Unk 409";
            public const int Unk_409_sortIndex = 6850;
            [SortOrder(Unk_409_sortIndex)]
            [DisplayName(Unk_409_displayName)]
            public virtual float Unk_409 {
                get => Unk_409_raw;
                set {
                    if (Unk_409_raw == value) return;
                    Unk_409_raw = value;
                    ChangedItems.Add(nameof(Unk_409));
                    OnPropertyChanged(nameof(Unk_409));
                }
            }

            protected float Unk_410_raw;
            public const string Unk_410_displayName = "Unk 410";
            public const int Unk_410_sortIndex = 6900;
            [SortOrder(Unk_410_sortIndex)]
            [DisplayName(Unk_410_displayName)]
            public virtual float Unk_410 {
                get => Unk_410_raw;
                set {
                    if (Unk_410_raw == value) return;
                    Unk_410_raw = value;
                    ChangedItems.Add(nameof(Unk_410));
                    OnPropertyChanged(nameof(Unk_410));
                }
            }

            protected float Unk_411_raw;
            public const string Unk_411_displayName = "Unk 411";
            public const int Unk_411_sortIndex = 6950;
            [SortOrder(Unk_411_sortIndex)]
            [DisplayName(Unk_411_displayName)]
            public virtual float Unk_411 {
                get => Unk_411_raw;
                set {
                    if (Unk_411_raw == value) return;
                    Unk_411_raw = value;
                    ChangedItems.Add(nameof(Unk_411));
                    OnPropertyChanged(nameof(Unk_411));
                }
            }

            protected float Unk_412_raw;
            public const string Unk_412_displayName = "Unk 412";
            public const int Unk_412_sortIndex = 7000;
            [SortOrder(Unk_412_sortIndex)]
            [DisplayName(Unk_412_displayName)]
            public virtual float Unk_412 {
                get => Unk_412_raw;
                set {
                    if (Unk_412_raw == value) return;
                    Unk_412_raw = value;
                    ChangedItems.Add(nameof(Unk_412));
                    OnPropertyChanged(nameof(Unk_412));
                }
            }

            protected float Unk_413_raw;
            public const string Unk_413_displayName = "Unk 413";
            public const int Unk_413_sortIndex = 7050;
            [SortOrder(Unk_413_sortIndex)]
            [DisplayName(Unk_413_displayName)]
            public virtual float Unk_413 {
                get => Unk_413_raw;
                set {
                    if (Unk_413_raw == value) return;
                    Unk_413_raw = value;
                    ChangedItems.Add(nameof(Unk_413));
                    OnPropertyChanged(nameof(Unk_413));
                }
            }

            protected float Unk_414_raw;
            public const string Unk_414_displayName = "Unk 414";
            public const int Unk_414_sortIndex = 7100;
            [SortOrder(Unk_414_sortIndex)]
            [DisplayName(Unk_414_displayName)]
            public virtual float Unk_414 {
                get => Unk_414_raw;
                set {
                    if (Unk_414_raw == value) return;
                    Unk_414_raw = value;
                    ChangedItems.Add(nameof(Unk_414));
                    OnPropertyChanged(nameof(Unk_414));
                }
            }

            protected float Unk_415_raw;
            public const string Unk_415_displayName = "Unk 415";
            public const int Unk_415_sortIndex = 7150;
            [SortOrder(Unk_415_sortIndex)]
            [DisplayName(Unk_415_displayName)]
            public virtual float Unk_415 {
                get => Unk_415_raw;
                set {
                    if (Unk_415_raw == value) return;
                    Unk_415_raw = value;
                    ChangedItems.Add(nameof(Unk_415));
                    OnPropertyChanged(nameof(Unk_415));
                }
            }

            protected float Unk_416_raw;
            public const string Unk_416_displayName = "Unk 416";
            public const int Unk_416_sortIndex = 7200;
            [SortOrder(Unk_416_sortIndex)]
            [DisplayName(Unk_416_displayName)]
            public virtual float Unk_416 {
                get => Unk_416_raw;
                set {
                    if (Unk_416_raw == value) return;
                    Unk_416_raw = value;
                    ChangedItems.Add(nameof(Unk_416));
                    OnPropertyChanged(nameof(Unk_416));
                }
            }

            protected float Unk_417_raw;
            public const string Unk_417_displayName = "Unk 417";
            public const int Unk_417_sortIndex = 7250;
            [SortOrder(Unk_417_sortIndex)]
            [DisplayName(Unk_417_displayName)]
            public virtual float Unk_417 {
                get => Unk_417_raw;
                set {
                    if (Unk_417_raw == value) return;
                    Unk_417_raw = value;
                    ChangedItems.Add(nameof(Unk_417));
                    OnPropertyChanged(nameof(Unk_417));
                }
            }

            protected float Unk_418_raw;
            public const string Unk_418_displayName = "Unk 418";
            public const int Unk_418_sortIndex = 7300;
            [SortOrder(Unk_418_sortIndex)]
            [DisplayName(Unk_418_displayName)]
            public virtual float Unk_418 {
                get => Unk_418_raw;
                set {
                    if (Unk_418_raw == value) return;
                    Unk_418_raw = value;
                    ChangedItems.Add(nameof(Unk_418));
                    OnPropertyChanged(nameof(Unk_418));
                }
            }

            protected float Unk_419_raw;
            public const string Unk_419_displayName = "Unk 419";
            public const int Unk_419_sortIndex = 7350;
            [SortOrder(Unk_419_sortIndex)]
            [DisplayName(Unk_419_displayName)]
            public virtual float Unk_419 {
                get => Unk_419_raw;
                set {
                    if (Unk_419_raw == value) return;
                    Unk_419_raw = value;
                    ChangedItems.Add(nameof(Unk_419));
                    OnPropertyChanged(nameof(Unk_419));
                }
            }

            protected float Unk_420_raw;
            public const string Unk_420_displayName = "Unk 420";
            public const int Unk_420_sortIndex = 7400;
            [SortOrder(Unk_420_sortIndex)]
            [DisplayName(Unk_420_displayName)]
            public virtual float Unk_420 {
                get => Unk_420_raw;
                set {
                    if (Unk_420_raw == value) return;
                    Unk_420_raw = value;
                    ChangedItems.Add(nameof(Unk_420));
                    OnPropertyChanged(nameof(Unk_420));
                }
            }

            protected float Unk_421_raw;
            public const string Unk_421_displayName = "Unk 421";
            public const int Unk_421_sortIndex = 7450;
            [SortOrder(Unk_421_sortIndex)]
            [DisplayName(Unk_421_displayName)]
            public virtual float Unk_421 {
                get => Unk_421_raw;
                set {
                    if (Unk_421_raw == value) return;
                    Unk_421_raw = value;
                    ChangedItems.Add(nameof(Unk_421));
                    OnPropertyChanged(nameof(Unk_421));
                }
            }

            protected float Unk_422_raw;
            public const string Unk_422_displayName = "Unk 422";
            public const int Unk_422_sortIndex = 7500;
            [SortOrder(Unk_422_sortIndex)]
            [DisplayName(Unk_422_displayName)]
            public virtual float Unk_422 {
                get => Unk_422_raw;
                set {
                    if (Unk_422_raw == value) return;
                    Unk_422_raw = value;
                    ChangedItems.Add(nameof(Unk_422));
                    OnPropertyChanged(nameof(Unk_422));
                }
            }

            protected float Unk_423_raw;
            public const string Unk_423_displayName = "Unk 423";
            public const int Unk_423_sortIndex = 7550;
            [SortOrder(Unk_423_sortIndex)]
            [DisplayName(Unk_423_displayName)]
            public virtual float Unk_423 {
                get => Unk_423_raw;
                set {
                    if (Unk_423_raw == value) return;
                    Unk_423_raw = value;
                    ChangedItems.Add(nameof(Unk_423));
                    OnPropertyChanged(nameof(Unk_423));
                }
            }

            protected float Unk_424_raw;
            public const string Unk_424_displayName = "Unk 424";
            public const int Unk_424_sortIndex = 7600;
            [SortOrder(Unk_424_sortIndex)]
            [DisplayName(Unk_424_displayName)]
            public virtual float Unk_424 {
                get => Unk_424_raw;
                set {
                    if (Unk_424_raw == value) return;
                    Unk_424_raw = value;
                    ChangedItems.Add(nameof(Unk_424));
                    OnPropertyChanged(nameof(Unk_424));
                }
            }

            protected float Unk_425_raw;
            public const string Unk_425_displayName = "Unk 425";
            public const int Unk_425_sortIndex = 7650;
            [SortOrder(Unk_425_sortIndex)]
            [DisplayName(Unk_425_displayName)]
            public virtual float Unk_425 {
                get => Unk_425_raw;
                set {
                    if (Unk_425_raw == value) return;
                    Unk_425_raw = value;
                    ChangedItems.Add(nameof(Unk_425));
                    OnPropertyChanged(nameof(Unk_425));
                }
            }

            protected float Unk_426_raw;
            public const string Unk_426_displayName = "Unk 426";
            public const int Unk_426_sortIndex = 7700;
            [SortOrder(Unk_426_sortIndex)]
            [DisplayName(Unk_426_displayName)]
            public virtual float Unk_426 {
                get => Unk_426_raw;
                set {
                    if (Unk_426_raw == value) return;
                    Unk_426_raw = value;
                    ChangedItems.Add(nameof(Unk_426));
                    OnPropertyChanged(nameof(Unk_426));
                }
            }

            protected float Unk_427_raw;
            public const string Unk_427_displayName = "Unk 427";
            public const int Unk_427_sortIndex = 7750;
            [SortOrder(Unk_427_sortIndex)]
            [DisplayName(Unk_427_displayName)]
            public virtual float Unk_427 {
                get => Unk_427_raw;
                set {
                    if (Unk_427_raw == value) return;
                    Unk_427_raw = value;
                    ChangedItems.Add(nameof(Unk_427));
                    OnPropertyChanged(nameof(Unk_427));
                }
            }

            protected float Unk_428_raw;
            public const string Unk_428_displayName = "Unk 428";
            public const int Unk_428_sortIndex = 7800;
            [SortOrder(Unk_428_sortIndex)]
            [DisplayName(Unk_428_displayName)]
            public virtual float Unk_428 {
                get => Unk_428_raw;
                set {
                    if (Unk_428_raw == value) return;
                    Unk_428_raw = value;
                    ChangedItems.Add(nameof(Unk_428));
                    OnPropertyChanged(nameof(Unk_428));
                }
            }

            protected float Unk_429_raw;
            public const string Unk_429_displayName = "Unk 429";
            public const int Unk_429_sortIndex = 7850;
            [SortOrder(Unk_429_sortIndex)]
            [DisplayName(Unk_429_displayName)]
            public virtual float Unk_429 {
                get => Unk_429_raw;
                set {
                    if (Unk_429_raw == value) return;
                    Unk_429_raw = value;
                    ChangedItems.Add(nameof(Unk_429));
                    OnPropertyChanged(nameof(Unk_429));
                }
            }

            protected float Unk_430_raw;
            public const string Unk_430_displayName = "Unk 430";
            public const int Unk_430_sortIndex = 7900;
            [SortOrder(Unk_430_sortIndex)]
            [DisplayName(Unk_430_displayName)]
            public virtual float Unk_430 {
                get => Unk_430_raw;
                set {
                    if (Unk_430_raw == value) return;
                    Unk_430_raw = value;
                    ChangedItems.Add(nameof(Unk_430));
                    OnPropertyChanged(nameof(Unk_430));
                }
            }

            protected float Unk_431_raw;
            public const string Unk_431_displayName = "Unk 431";
            public const int Unk_431_sortIndex = 7950;
            [SortOrder(Unk_431_sortIndex)]
            [DisplayName(Unk_431_displayName)]
            public virtual float Unk_431 {
                get => Unk_431_raw;
                set {
                    if (Unk_431_raw == value) return;
                    Unk_431_raw = value;
                    ChangedItems.Add(nameof(Unk_431));
                    OnPropertyChanged(nameof(Unk_431));
                }
            }

            protected float Unk_432_raw;
            public const string Unk_432_displayName = "Unk 432";
            public const int Unk_432_sortIndex = 8000;
            [SortOrder(Unk_432_sortIndex)]
            [DisplayName(Unk_432_displayName)]
            public virtual float Unk_432 {
                get => Unk_432_raw;
                set {
                    if (Unk_432_raw == value) return;
                    Unk_432_raw = value;
                    ChangedItems.Add(nameof(Unk_432));
                    OnPropertyChanged(nameof(Unk_432));
                }
            }

            protected float Unk_433_raw;
            public const string Unk_433_displayName = "Unk 433";
            public const int Unk_433_sortIndex = 8050;
            [SortOrder(Unk_433_sortIndex)]
            [DisplayName(Unk_433_displayName)]
            public virtual float Unk_433 {
                get => Unk_433_raw;
                set {
                    if (Unk_433_raw == value) return;
                    Unk_433_raw = value;
                    ChangedItems.Add(nameof(Unk_433));
                    OnPropertyChanged(nameof(Unk_433));
                }
            }

            protected float Unk_434_raw;
            public const string Unk_434_displayName = "Unk 434";
            public const int Unk_434_sortIndex = 8100;
            [SortOrder(Unk_434_sortIndex)]
            [DisplayName(Unk_434_displayName)]
            public virtual float Unk_434 {
                get => Unk_434_raw;
                set {
                    if (Unk_434_raw == value) return;
                    Unk_434_raw = value;
                    ChangedItems.Add(nameof(Unk_434));
                    OnPropertyChanged(nameof(Unk_434));
                }
            }

            protected float Unk_435_raw;
            public const string Unk_435_displayName = "Unk 435";
            public const int Unk_435_sortIndex = 8150;
            [SortOrder(Unk_435_sortIndex)]
            [DisplayName(Unk_435_displayName)]
            public virtual float Unk_435 {
                get => Unk_435_raw;
                set {
                    if (Unk_435_raw == value) return;
                    Unk_435_raw = value;
                    ChangedItems.Add(nameof(Unk_435));
                    OnPropertyChanged(nameof(Unk_435));
                }
            }

            protected float Unk_436_raw;
            public const string Unk_436_displayName = "Unk 436";
            public const int Unk_436_sortIndex = 8200;
            [SortOrder(Unk_436_sortIndex)]
            [DisplayName(Unk_436_displayName)]
            public virtual float Unk_436 {
                get => Unk_436_raw;
                set {
                    if (Unk_436_raw == value) return;
                    Unk_436_raw = value;
                    ChangedItems.Add(nameof(Unk_436));
                    OnPropertyChanged(nameof(Unk_436));
                }
            }

            protected float Unk_437_raw;
            public const string Unk_437_displayName = "Unk 437";
            public const int Unk_437_sortIndex = 8250;
            [SortOrder(Unk_437_sortIndex)]
            [DisplayName(Unk_437_displayName)]
            public virtual float Unk_437 {
                get => Unk_437_raw;
                set {
                    if (Unk_437_raw == value) return;
                    Unk_437_raw = value;
                    ChangedItems.Add(nameof(Unk_437));
                    OnPropertyChanged(nameof(Unk_437));
                }
            }

            protected float Unk_438_raw;
            public const string Unk_438_displayName = "Unk 438";
            public const int Unk_438_sortIndex = 8300;
            [SortOrder(Unk_438_sortIndex)]
            [DisplayName(Unk_438_displayName)]
            public virtual float Unk_438 {
                get => Unk_438_raw;
                set {
                    if (Unk_438_raw == value) return;
                    Unk_438_raw = value;
                    ChangedItems.Add(nameof(Unk_438));
                    OnPropertyChanged(nameof(Unk_438));
                }
            }

            protected uint Unk_439_raw;
            public const string Unk_439_displayName = "Unk 439";
            public const int Unk_439_sortIndex = 8350;
            [SortOrder(Unk_439_sortIndex)]
            [DisplayName(Unk_439_displayName)]
            public virtual uint Unk_439 {
                get => Unk_439_raw;
                set {
                    if (Unk_439_raw == value) return;
                    Unk_439_raw = value;
                    ChangedItems.Add(nameof(Unk_439));
                    OnPropertyChanged(nameof(Unk_439));
                }
            }

            protected float Unk_440_raw;
            public const string Unk_440_displayName = "Unk 440";
            public const int Unk_440_sortIndex = 8400;
            [SortOrder(Unk_440_sortIndex)]
            [DisplayName(Unk_440_displayName)]
            public virtual float Unk_440 {
                get => Unk_440_raw;
                set {
                    if (Unk_440_raw == value) return;
                    Unk_440_raw = value;
                    ChangedItems.Add(nameof(Unk_440));
                    OnPropertyChanged(nameof(Unk_440));
                }
            }

            protected float Unk_441_raw;
            public const string Unk_441_displayName = "Unk 441";
            public const int Unk_441_sortIndex = 8450;
            [SortOrder(Unk_441_sortIndex)]
            [DisplayName(Unk_441_displayName)]
            public virtual float Unk_441 {
                get => Unk_441_raw;
                set {
                    if (Unk_441_raw == value) return;
                    Unk_441_raw = value;
                    ChangedItems.Add(nameof(Unk_441));
                    OnPropertyChanged(nameof(Unk_441));
                }
            }

            protected float Unk_442_raw;
            public const string Unk_442_displayName = "Unk 442";
            public const int Unk_442_sortIndex = 8500;
            [SortOrder(Unk_442_sortIndex)]
            [DisplayName(Unk_442_displayName)]
            public virtual float Unk_442 {
                get => Unk_442_raw;
                set {
                    if (Unk_442_raw == value) return;
                    Unk_442_raw = value;
                    ChangedItems.Add(nameof(Unk_442));
                    OnPropertyChanged(nameof(Unk_442));
                }
            }

            protected float Unk_443_raw;
            public const string Unk_443_displayName = "Unk 443";
            public const int Unk_443_sortIndex = 8550;
            [SortOrder(Unk_443_sortIndex)]
            [DisplayName(Unk_443_displayName)]
            public virtual float Unk_443 {
                get => Unk_443_raw;
                set {
                    if (Unk_443_raw == value) return;
                    Unk_443_raw = value;
                    ChangedItems.Add(nameof(Unk_443));
                    OnPropertyChanged(nameof(Unk_443));
                }
            }

            protected float Unk_444_raw;
            public const string Unk_444_displayName = "Unk 444";
            public const int Unk_444_sortIndex = 8600;
            [SortOrder(Unk_444_sortIndex)]
            [DisplayName(Unk_444_displayName)]
            public virtual float Unk_444 {
                get => Unk_444_raw;
                set {
                    if (Unk_444_raw == value) return;
                    Unk_444_raw = value;
                    ChangedItems.Add(nameof(Unk_444));
                    OnPropertyChanged(nameof(Unk_444));
                }
            }

            protected float Unk_445_raw;
            public const string Unk_445_displayName = "Unk 445";
            public const int Unk_445_sortIndex = 8650;
            [SortOrder(Unk_445_sortIndex)]
            [DisplayName(Unk_445_displayName)]
            public virtual float Unk_445 {
                get => Unk_445_raw;
                set {
                    if (Unk_445_raw == value) return;
                    Unk_445_raw = value;
                    ChangedItems.Add(nameof(Unk_445));
                    OnPropertyChanged(nameof(Unk_445));
                }
            }

            protected float Unk_446_raw;
            public const string Unk_446_displayName = "Unk 446";
            public const int Unk_446_sortIndex = 8700;
            [SortOrder(Unk_446_sortIndex)]
            [DisplayName(Unk_446_displayName)]
            public virtual float Unk_446 {
                get => Unk_446_raw;
                set {
                    if (Unk_446_raw == value) return;
                    Unk_446_raw = value;
                    ChangedItems.Add(nameof(Unk_446));
                    OnPropertyChanged(nameof(Unk_446));
                }
            }

            protected float Unk_447_raw;
            public const string Unk_447_displayName = "Unk 447";
            public const int Unk_447_sortIndex = 8750;
            [SortOrder(Unk_447_sortIndex)]
            [DisplayName(Unk_447_displayName)]
            public virtual float Unk_447 {
                get => Unk_447_raw;
                set {
                    if (Unk_447_raw == value) return;
                    Unk_447_raw = value;
                    ChangedItems.Add(nameof(Unk_447));
                    OnPropertyChanged(nameof(Unk_447));
                }
            }

            protected float Unk_448_raw;
            public const string Unk_448_displayName = "Unk 448";
            public const int Unk_448_sortIndex = 8800;
            [SortOrder(Unk_448_sortIndex)]
            [DisplayName(Unk_448_displayName)]
            public virtual float Unk_448 {
                get => Unk_448_raw;
                set {
                    if (Unk_448_raw == value) return;
                    Unk_448_raw = value;
                    ChangedItems.Add(nameof(Unk_448));
                    OnPropertyChanged(nameof(Unk_448));
                }
            }

            protected float Unk_449_raw;
            public const string Unk_449_displayName = "Unk 449";
            public const int Unk_449_sortIndex = 8850;
            [SortOrder(Unk_449_sortIndex)]
            [DisplayName(Unk_449_displayName)]
            public virtual float Unk_449 {
                get => Unk_449_raw;
                set {
                    if (Unk_449_raw == value) return;
                    Unk_449_raw = value;
                    ChangedItems.Add(nameof(Unk_449));
                    OnPropertyChanged(nameof(Unk_449));
                }
            }

            protected float Unk_450_raw;
            public const string Unk_450_displayName = "Unk 450";
            public const int Unk_450_sortIndex = 8900;
            [SortOrder(Unk_450_sortIndex)]
            [DisplayName(Unk_450_displayName)]
            public virtual float Unk_450 {
                get => Unk_450_raw;
                set {
                    if (Unk_450_raw == value) return;
                    Unk_450_raw = value;
                    ChangedItems.Add(nameof(Unk_450));
                    OnPropertyChanged(nameof(Unk_450));
                }
            }

            protected float Unk_451_raw;
            public const string Unk_451_displayName = "Unk 451";
            public const int Unk_451_sortIndex = 8950;
            [SortOrder(Unk_451_sortIndex)]
            [DisplayName(Unk_451_displayName)]
            public virtual float Unk_451 {
                get => Unk_451_raw;
                set {
                    if (Unk_451_raw == value) return;
                    Unk_451_raw = value;
                    ChangedItems.Add(nameof(Unk_451));
                    OnPropertyChanged(nameof(Unk_451));
                }
            }

            protected float Unk_452_raw;
            public const string Unk_452_displayName = "Unk 452";
            public const int Unk_452_sortIndex = 9000;
            [SortOrder(Unk_452_sortIndex)]
            [DisplayName(Unk_452_displayName)]
            public virtual float Unk_452 {
                get => Unk_452_raw;
                set {
                    if (Unk_452_raw == value) return;
                    Unk_452_raw = value;
                    ChangedItems.Add(nameof(Unk_452));
                    OnPropertyChanged(nameof(Unk_452));
                }
            }

            protected float Unk_453_raw;
            public const string Unk_453_displayName = "Unk 453";
            public const int Unk_453_sortIndex = 9050;
            [SortOrder(Unk_453_sortIndex)]
            [DisplayName(Unk_453_displayName)]
            public virtual float Unk_453 {
                get => Unk_453_raw;
                set {
                    if (Unk_453_raw == value) return;
                    Unk_453_raw = value;
                    ChangedItems.Add(nameof(Unk_453));
                    OnPropertyChanged(nameof(Unk_453));
                }
            }

            protected float Unk_454_raw;
            public const string Unk_454_displayName = "Unk 454";
            public const int Unk_454_sortIndex = 9100;
            [SortOrder(Unk_454_sortIndex)]
            [DisplayName(Unk_454_displayName)]
            public virtual float Unk_454 {
                get => Unk_454_raw;
                set {
                    if (Unk_454_raw == value) return;
                    Unk_454_raw = value;
                    ChangedItems.Add(nameof(Unk_454));
                    OnPropertyChanged(nameof(Unk_454));
                }
            }

            protected float Unk_455_raw;
            public const string Unk_455_displayName = "Unk 455";
            public const int Unk_455_sortIndex = 9150;
            [SortOrder(Unk_455_sortIndex)]
            [DisplayName(Unk_455_displayName)]
            public virtual float Unk_455 {
                get => Unk_455_raw;
                set {
                    if (Unk_455_raw == value) return;
                    Unk_455_raw = value;
                    ChangedItems.Add(nameof(Unk_455));
                    OnPropertyChanged(nameof(Unk_455));
                }
            }

            protected float Unk_456_raw;
            public const string Unk_456_displayName = "Unk 456";
            public const int Unk_456_sortIndex = 9200;
            [SortOrder(Unk_456_sortIndex)]
            [DisplayName(Unk_456_displayName)]
            public virtual float Unk_456 {
                get => Unk_456_raw;
                set {
                    if (Unk_456_raw == value) return;
                    Unk_456_raw = value;
                    ChangedItems.Add(nameof(Unk_456));
                    OnPropertyChanged(nameof(Unk_456));
                }
            }

            protected float Unk_457_raw;
            public const string Unk_457_displayName = "Unk 457";
            public const int Unk_457_sortIndex = 9250;
            [SortOrder(Unk_457_sortIndex)]
            [DisplayName(Unk_457_displayName)]
            public virtual float Unk_457 {
                get => Unk_457_raw;
                set {
                    if (Unk_457_raw == value) return;
                    Unk_457_raw = value;
                    ChangedItems.Add(nameof(Unk_457));
                    OnPropertyChanged(nameof(Unk_457));
                }
            }

            protected float Unk_458_raw;
            public const string Unk_458_displayName = "Unk 458";
            public const int Unk_458_sortIndex = 9300;
            [SortOrder(Unk_458_sortIndex)]
            [DisplayName(Unk_458_displayName)]
            public virtual float Unk_458 {
                get => Unk_458_raw;
                set {
                    if (Unk_458_raw == value) return;
                    Unk_458_raw = value;
                    ChangedItems.Add(nameof(Unk_458));
                    OnPropertyChanged(nameof(Unk_458));
                }
            }

            protected float Unk_459_raw;
            public const string Unk_459_displayName = "Unk 459";
            public const int Unk_459_sortIndex = 9350;
            [SortOrder(Unk_459_sortIndex)]
            [DisplayName(Unk_459_displayName)]
            public virtual float Unk_459 {
                get => Unk_459_raw;
                set {
                    if (Unk_459_raw == value) return;
                    Unk_459_raw = value;
                    ChangedItems.Add(nameof(Unk_459));
                    OnPropertyChanged(nameof(Unk_459));
                }
            }

            protected float Unk_460_raw;
            public const string Unk_460_displayName = "Unk 460";
            public const int Unk_460_sortIndex = 9400;
            [SortOrder(Unk_460_sortIndex)]
            [DisplayName(Unk_460_displayName)]
            public virtual float Unk_460 {
                get => Unk_460_raw;
                set {
                    if (Unk_460_raw == value) return;
                    Unk_460_raw = value;
                    ChangedItems.Add(nameof(Unk_460));
                    OnPropertyChanged(nameof(Unk_460));
                }
            }

            protected float Unk_461_raw;
            public const string Unk_461_displayName = "Unk 461";
            public const int Unk_461_sortIndex = 9450;
            [SortOrder(Unk_461_sortIndex)]
            [DisplayName(Unk_461_displayName)]
            public virtual float Unk_461 {
                get => Unk_461_raw;
                set {
                    if (Unk_461_raw == value) return;
                    Unk_461_raw = value;
                    ChangedItems.Add(nameof(Unk_461));
                    OnPropertyChanged(nameof(Unk_461));
                }
            }

            protected float Unk_462_raw;
            public const string Unk_462_displayName = "Unk 462";
            public const int Unk_462_sortIndex = 9500;
            [SortOrder(Unk_462_sortIndex)]
            [DisplayName(Unk_462_displayName)]
            public virtual float Unk_462 {
                get => Unk_462_raw;
                set {
                    if (Unk_462_raw == value) return;
                    Unk_462_raw = value;
                    ChangedItems.Add(nameof(Unk_462));
                    OnPropertyChanged(nameof(Unk_462));
                }
            }

            protected float Unk_463_raw;
            public const string Unk_463_displayName = "Unk 463";
            public const int Unk_463_sortIndex = 9550;
            [SortOrder(Unk_463_sortIndex)]
            [DisplayName(Unk_463_displayName)]
            public virtual float Unk_463 {
                get => Unk_463_raw;
                set {
                    if (Unk_463_raw == value) return;
                    Unk_463_raw = value;
                    ChangedItems.Add(nameof(Unk_463));
                    OnPropertyChanged(nameof(Unk_463));
                }
            }

            protected float Unk_464_raw;
            public const string Unk_464_displayName = "Unk 464";
            public const int Unk_464_sortIndex = 9600;
            [SortOrder(Unk_464_sortIndex)]
            [DisplayName(Unk_464_displayName)]
            public virtual float Unk_464 {
                get => Unk_464_raw;
                set {
                    if (Unk_464_raw == value) return;
                    Unk_464_raw = value;
                    ChangedItems.Add(nameof(Unk_464));
                    OnPropertyChanged(nameof(Unk_464));
                }
            }

            protected float Unk_465_raw;
            public const string Unk_465_displayName = "Unk 465";
            public const int Unk_465_sortIndex = 9650;
            [SortOrder(Unk_465_sortIndex)]
            [DisplayName(Unk_465_displayName)]
            public virtual float Unk_465 {
                get => Unk_465_raw;
                set {
                    if (Unk_465_raw == value) return;
                    Unk_465_raw = value;
                    ChangedItems.Add(nameof(Unk_465));
                    OnPropertyChanged(nameof(Unk_465));
                }
            }

            protected float Unk_466_raw;
            public const string Unk_466_displayName = "Unk 466";
            public const int Unk_466_sortIndex = 9700;
            [SortOrder(Unk_466_sortIndex)]
            [DisplayName(Unk_466_displayName)]
            public virtual float Unk_466 {
                get => Unk_466_raw;
                set {
                    if (Unk_466_raw == value) return;
                    Unk_466_raw = value;
                    ChangedItems.Add(nameof(Unk_466));
                    OnPropertyChanged(nameof(Unk_466));
                }
            }

            protected float Unk_467_raw;
            public const string Unk_467_displayName = "Unk 467";
            public const int Unk_467_sortIndex = 9750;
            [SortOrder(Unk_467_sortIndex)]
            [DisplayName(Unk_467_displayName)]
            public virtual float Unk_467 {
                get => Unk_467_raw;
                set {
                    if (Unk_467_raw == value) return;
                    Unk_467_raw = value;
                    ChangedItems.Add(nameof(Unk_467));
                    OnPropertyChanged(nameof(Unk_467));
                }
            }

            protected float Unk_468_raw;
            public const string Unk_468_displayName = "Unk 468";
            public const int Unk_468_sortIndex = 9800;
            [SortOrder(Unk_468_sortIndex)]
            [DisplayName(Unk_468_displayName)]
            public virtual float Unk_468 {
                get => Unk_468_raw;
                set {
                    if (Unk_468_raw == value) return;
                    Unk_468_raw = value;
                    ChangedItems.Add(nameof(Unk_468));
                    OnPropertyChanged(nameof(Unk_468));
                }
            }

            protected float Unk_469_raw;
            public const string Unk_469_displayName = "Unk 469";
            public const int Unk_469_sortIndex = 9850;
            [SortOrder(Unk_469_sortIndex)]
            [DisplayName(Unk_469_displayName)]
            public virtual float Unk_469 {
                get => Unk_469_raw;
                set {
                    if (Unk_469_raw == value) return;
                    Unk_469_raw = value;
                    ChangedItems.Add(nameof(Unk_469));
                    OnPropertyChanged(nameof(Unk_469));
                }
            }

            protected float Unk_470_raw;
            public const string Unk_470_displayName = "Unk 470";
            public const int Unk_470_sortIndex = 9900;
            [SortOrder(Unk_470_sortIndex)]
            [DisplayName(Unk_470_displayName)]
            public virtual float Unk_470 {
                get => Unk_470_raw;
                set {
                    if (Unk_470_raw == value) return;
                    Unk_470_raw = value;
                    ChangedItems.Add(nameof(Unk_470));
                    OnPropertyChanged(nameof(Unk_470));
                }
            }

            protected float Unk_471_raw;
            public const string Unk_471_displayName = "Unk 471";
            public const int Unk_471_sortIndex = 9950;
            [SortOrder(Unk_471_sortIndex)]
            [DisplayName(Unk_471_displayName)]
            public virtual float Unk_471 {
                get => Unk_471_raw;
                set {
                    if (Unk_471_raw == value) return;
                    Unk_471_raw = value;
                    ChangedItems.Add(nameof(Unk_471));
                    OnPropertyChanged(nameof(Unk_471));
                }
            }

            protected float Unk_472_raw;
            public const string Unk_472_displayName = "Unk 472";
            public const int Unk_472_sortIndex = 10000;
            [SortOrder(Unk_472_sortIndex)]
            [DisplayName(Unk_472_displayName)]
            public virtual float Unk_472 {
                get => Unk_472_raw;
                set {
                    if (Unk_472_raw == value) return;
                    Unk_472_raw = value;
                    ChangedItems.Add(nameof(Unk_472));
                    OnPropertyChanged(nameof(Unk_472));
                }
            }

            protected float Unk_473_raw;
            public const string Unk_473_displayName = "Unk 473";
            public const int Unk_473_sortIndex = 10050;
            [SortOrder(Unk_473_sortIndex)]
            [DisplayName(Unk_473_displayName)]
            public virtual float Unk_473 {
                get => Unk_473_raw;
                set {
                    if (Unk_473_raw == value) return;
                    Unk_473_raw = value;
                    ChangedItems.Add(nameof(Unk_473));
                    OnPropertyChanged(nameof(Unk_473));
                }
            }

            protected float Unk_474_raw;
            public const string Unk_474_displayName = "Unk 474";
            public const int Unk_474_sortIndex = 10100;
            [SortOrder(Unk_474_sortIndex)]
            [DisplayName(Unk_474_displayName)]
            public virtual float Unk_474 {
                get => Unk_474_raw;
                set {
                    if (Unk_474_raw == value) return;
                    Unk_474_raw = value;
                    ChangedItems.Add(nameof(Unk_474));
                    OnPropertyChanged(nameof(Unk_474));
                }
            }

            protected float Unk_475_raw;
            public const string Unk_475_displayName = "Unk 475";
            public const int Unk_475_sortIndex = 10150;
            [SortOrder(Unk_475_sortIndex)]
            [DisplayName(Unk_475_displayName)]
            public virtual float Unk_475 {
                get => Unk_475_raw;
                set {
                    if (Unk_475_raw == value) return;
                    Unk_475_raw = value;
                    ChangedItems.Add(nameof(Unk_475));
                    OnPropertyChanged(nameof(Unk_475));
                }
            }

            protected float Unk_476_raw;
            public const string Unk_476_displayName = "Unk 476";
            public const int Unk_476_sortIndex = 10200;
            [SortOrder(Unk_476_sortIndex)]
            [DisplayName(Unk_476_displayName)]
            public virtual float Unk_476 {
                get => Unk_476_raw;
                set {
                    if (Unk_476_raw == value) return;
                    Unk_476_raw = value;
                    ChangedItems.Add(nameof(Unk_476));
                    OnPropertyChanged(nameof(Unk_476));
                }
            }

            protected float Unk_477_raw;
            public const string Unk_477_displayName = "Unk 477";
            public const int Unk_477_sortIndex = 10250;
            [SortOrder(Unk_477_sortIndex)]
            [DisplayName(Unk_477_displayName)]
            public virtual float Unk_477 {
                get => Unk_477_raw;
                set {
                    if (Unk_477_raw == value) return;
                    Unk_477_raw = value;
                    ChangedItems.Add(nameof(Unk_477));
                    OnPropertyChanged(nameof(Unk_477));
                }
            }

            protected float Unk_478_raw;
            public const string Unk_478_displayName = "Unk 478";
            public const int Unk_478_sortIndex = 10300;
            [SortOrder(Unk_478_sortIndex)]
            [DisplayName(Unk_478_displayName)]
            public virtual float Unk_478 {
                get => Unk_478_raw;
                set {
                    if (Unk_478_raw == value) return;
                    Unk_478_raw = value;
                    ChangedItems.Add(nameof(Unk_478));
                    OnPropertyChanged(nameof(Unk_478));
                }
            }

            protected float Unk_479_raw;
            public const string Unk_479_displayName = "Unk 479";
            public const int Unk_479_sortIndex = 10350;
            [SortOrder(Unk_479_sortIndex)]
            [DisplayName(Unk_479_displayName)]
            public virtual float Unk_479 {
                get => Unk_479_raw;
                set {
                    if (Unk_479_raw == value) return;
                    Unk_479_raw = value;
                    ChangedItems.Add(nameof(Unk_479));
                    OnPropertyChanged(nameof(Unk_479));
                }
            }

            protected float Unk_480_raw;
            public const string Unk_480_displayName = "Unk 480";
            public const int Unk_480_sortIndex = 10400;
            [SortOrder(Unk_480_sortIndex)]
            [DisplayName(Unk_480_displayName)]
            public virtual float Unk_480 {
                get => Unk_480_raw;
                set {
                    if (Unk_480_raw == value) return;
                    Unk_480_raw = value;
                    ChangedItems.Add(nameof(Unk_480));
                    OnPropertyChanged(nameof(Unk_480));
                }
            }

            protected float Unk_481_raw;
            public const string Unk_481_displayName = "Unk 481";
            public const int Unk_481_sortIndex = 10450;
            [SortOrder(Unk_481_sortIndex)]
            [DisplayName(Unk_481_displayName)]
            public virtual float Unk_481 {
                get => Unk_481_raw;
                set {
                    if (Unk_481_raw == value) return;
                    Unk_481_raw = value;
                    ChangedItems.Add(nameof(Unk_481));
                    OnPropertyChanged(nameof(Unk_481));
                }
            }

            protected float Unk_482_raw;
            public const string Unk_482_displayName = "Unk 482";
            public const int Unk_482_sortIndex = 10500;
            [SortOrder(Unk_482_sortIndex)]
            [DisplayName(Unk_482_displayName)]
            public virtual float Unk_482 {
                get => Unk_482_raw;
                set {
                    if (Unk_482_raw == value) return;
                    Unk_482_raw = value;
                    ChangedItems.Add(nameof(Unk_482));
                    OnPropertyChanged(nameof(Unk_482));
                }
            }

            protected float Unk_483_raw;
            public const string Unk_483_displayName = "Unk 483";
            public const int Unk_483_sortIndex = 10550;
            [SortOrder(Unk_483_sortIndex)]
            [DisplayName(Unk_483_displayName)]
            public virtual float Unk_483 {
                get => Unk_483_raw;
                set {
                    if (Unk_483_raw == value) return;
                    Unk_483_raw = value;
                    ChangedItems.Add(nameof(Unk_483));
                    OnPropertyChanged(nameof(Unk_483));
                }
            }

            protected float Unk_484_raw;
            public const string Unk_484_displayName = "Unk 484";
            public const int Unk_484_sortIndex = 10600;
            [SortOrder(Unk_484_sortIndex)]
            [DisplayName(Unk_484_displayName)]
            public virtual float Unk_484 {
                get => Unk_484_raw;
                set {
                    if (Unk_484_raw == value) return;
                    Unk_484_raw = value;
                    ChangedItems.Add(nameof(Unk_484));
                    OnPropertyChanged(nameof(Unk_484));
                }
            }

            protected float Unk_485_raw;
            public const string Unk_485_displayName = "Unk 485";
            public const int Unk_485_sortIndex = 10650;
            [SortOrder(Unk_485_sortIndex)]
            [DisplayName(Unk_485_displayName)]
            public virtual float Unk_485 {
                get => Unk_485_raw;
                set {
                    if (Unk_485_raw == value) return;
                    Unk_485_raw = value;
                    ChangedItems.Add(nameof(Unk_485));
                    OnPropertyChanged(nameof(Unk_485));
                }
            }

            protected float Unk_486_raw;
            public const string Unk_486_displayName = "Unk 486";
            public const int Unk_486_sortIndex = 10700;
            [SortOrder(Unk_486_sortIndex)]
            [DisplayName(Unk_486_displayName)]
            public virtual float Unk_486 {
                get => Unk_486_raw;
                set {
                    if (Unk_486_raw == value) return;
                    Unk_486_raw = value;
                    ChangedItems.Add(nameof(Unk_486));
                    OnPropertyChanged(nameof(Unk_486));
                }
            }

            protected float Unk_487_raw;
            public const string Unk_487_displayName = "Unk 487";
            public const int Unk_487_sortIndex = 10750;
            [SortOrder(Unk_487_sortIndex)]
            [DisplayName(Unk_487_displayName)]
            public virtual float Unk_487 {
                get => Unk_487_raw;
                set {
                    if (Unk_487_raw == value) return;
                    Unk_487_raw = value;
                    ChangedItems.Add(nameof(Unk_487));
                    OnPropertyChanged(nameof(Unk_487));
                }
            }

            protected float Unk_488_raw;
            public const string Unk_488_displayName = "Unk 488";
            public const int Unk_488_sortIndex = 10800;
            [SortOrder(Unk_488_sortIndex)]
            [DisplayName(Unk_488_displayName)]
            public virtual float Unk_488 {
                get => Unk_488_raw;
                set {
                    if (Unk_488_raw == value) return;
                    Unk_488_raw = value;
                    ChangedItems.Add(nameof(Unk_488));
                    OnPropertyChanged(nameof(Unk_488));
                }
            }

            protected float Unk_489_raw;
            public const string Unk_489_displayName = "Unk 489";
            public const int Unk_489_sortIndex = 10850;
            [SortOrder(Unk_489_sortIndex)]
            [DisplayName(Unk_489_displayName)]
            public virtual float Unk_489 {
                get => Unk_489_raw;
                set {
                    if (Unk_489_raw == value) return;
                    Unk_489_raw = value;
                    ChangedItems.Add(nameof(Unk_489));
                    OnPropertyChanged(nameof(Unk_489));
                }
            }

            protected float Unk_490_raw;
            public const string Unk_490_displayName = "Unk 490";
            public const int Unk_490_sortIndex = 10900;
            [SortOrder(Unk_490_sortIndex)]
            [DisplayName(Unk_490_displayName)]
            public virtual float Unk_490 {
                get => Unk_490_raw;
                set {
                    if (Unk_490_raw == value) return;
                    Unk_490_raw = value;
                    ChangedItems.Add(nameof(Unk_490));
                    OnPropertyChanged(nameof(Unk_490));
                }
            }

            protected float Unk_491_raw;
            public const string Unk_491_displayName = "Unk 491";
            public const int Unk_491_sortIndex = 10950;
            [SortOrder(Unk_491_sortIndex)]
            [DisplayName(Unk_491_displayName)]
            public virtual float Unk_491 {
                get => Unk_491_raw;
                set {
                    if (Unk_491_raw == value) return;
                    Unk_491_raw = value;
                    ChangedItems.Add(nameof(Unk_491));
                    OnPropertyChanged(nameof(Unk_491));
                }
            }

            protected float Unk_492_raw;
            public const string Unk_492_displayName = "Unk 492";
            public const int Unk_492_sortIndex = 11000;
            [SortOrder(Unk_492_sortIndex)]
            [DisplayName(Unk_492_displayName)]
            public virtual float Unk_492 {
                get => Unk_492_raw;
                set {
                    if (Unk_492_raw == value) return;
                    Unk_492_raw = value;
                    ChangedItems.Add(nameof(Unk_492));
                    OnPropertyChanged(nameof(Unk_492));
                }
            }

            protected int Unk_493_raw;
            public const string Unk_493_displayName = "Unk 493";
            public const int Unk_493_sortIndex = 11050;
            [SortOrder(Unk_493_sortIndex)]
            [DisplayName(Unk_493_displayName)]
            public virtual int Unk_493 {
                get => Unk_493_raw;
                set {
                    if (Unk_493_raw == value) return;
                    Unk_493_raw = value;
                    ChangedItems.Add(nameof(Unk_493));
                    OnPropertyChanged(nameof(Unk_493));
                }
            }

            public const int lastSortIndex = 11100;

            public static ObservableMhwStructCollection<Monster_Common_Params_10_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Monster_Common_Params_10_>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Monster_Common_Params_10_ LoadData(BinaryReader reader, ulong i) {
                var data = new Monster_Common_Params_10_();
                data.Index = i;
                data.Shell_Header_raw = reader.ReadUInt32();
                data.Shell_raw = reader.ReadNullTermString();
                data.Unk_275_raw = reader.ReadSingle();
                data.Unk_276_raw = reader.ReadInt32();
                data.Unk_277_raw = reader.ReadSingle();
                data.Unk_278_raw = reader.ReadSingle();
                data.Unk_279_raw = reader.ReadSingle();
                data.Unk_280_raw = reader.ReadSingle();
                data.Unk_281_raw = reader.ReadSingle();
                data.Unk_282_raw = reader.ReadSingle();
                data.Unk_283_raw = reader.ReadSingle();
                data.Unk_284_raw = reader.ReadSingle();
                data.Unk_285_raw = reader.ReadSingle();
                data.Unk_286_raw = reader.ReadSingle();
                data.Unk_287_raw = reader.ReadSingle();
                data.Unk_288_raw = reader.ReadSingle();
                data.Unk_289_raw = reader.ReadSingle();
                data.Unk_290_raw = reader.ReadSingle();
                data.Unk_291_raw = reader.ReadSingle();
                data.Unk_292_raw = reader.ReadSingle();
                data.Unk_293_raw = reader.ReadSingle();
                data.Unk_294_raw = reader.ReadSingle();
                data.Unk_295_raw = reader.ReadSingle();
                data.Unk_296_raw = reader.ReadSingle();
                data.Unk_297_raw = reader.ReadSingle();
                data.Unk_298_raw = reader.ReadSingle();
                data.Unk_299_raw = reader.ReadSingle();
                data.Unk_300_raw = reader.ReadSingle();
                data.Unk_301_raw = reader.ReadSingle();
                data.Unk_302_raw = reader.ReadSingle();
                data.Unk_303_raw = reader.ReadSingle();
                data.Unk_304_raw = reader.ReadSingle();
                data.Unk_305_raw = reader.ReadSingle();
                data.Unk_306_raw = reader.ReadSingle();
                data.Unk_307_raw = reader.ReadSingle();
                data.Unk_308_raw = reader.ReadSingle();
                data.Unk_309_raw = reader.ReadSingle();
                data.Unk_310_raw = reader.ReadSingle();
                data.Unk_311_raw = reader.ReadSingle();
                data.Unk_312_raw = reader.ReadSingle();
                data.Unk_313_raw = reader.ReadSingle();
                data.Unk_314_raw = reader.ReadSingle();
                data.Unk_315_raw = reader.ReadSingle();
                data.Unk_316_raw = reader.ReadSingle();
                data.Unk_317_raw = reader.ReadSingle();
                data.Unk_318_raw = reader.ReadSingle();
                data.Unk_319_raw = reader.ReadSingle();
                data.Unk_320_raw = reader.ReadSingle();
                data.Unk_321_raw = reader.ReadSingle();
                data.Unk_322_raw = reader.ReadSingle();
                data.Unk_323_raw = reader.ReadSingle();
                data.Unk_324_raw = reader.ReadSingle();
                data.Unk_325_raw = reader.ReadSingle();
                data.Unk_326_raw = reader.ReadSingle();
                data.Unk_327_raw = reader.ReadSingle();
                data.Unk_328_raw = reader.ReadSingle();
                data.Unk_329_raw = reader.ReadSingle();
                data.Unk_330_raw = reader.ReadUInt32();
                data.Unk_331_raw = reader.ReadUInt32();
                data.Unk_332_raw = reader.ReadSingle();
                data.Unk_333_raw = reader.ReadSingle();
                data.Unk_334_raw = reader.ReadSingle();
                data.Unk_335_raw = reader.ReadSingle();
                data.Unk_336_raw = reader.ReadSingle();
                data.Unk_337_raw = reader.ReadSingle();
                data.Unk_338_raw = reader.ReadSingle();
                data.Unk_339_raw = reader.ReadSingle();
                data.Unk_340_raw = reader.ReadSingle();
                data.Unk_341_raw = reader.ReadSingle();
                data.Unk_342_raw = reader.ReadSingle();
                data.Unk_343_raw = reader.ReadSingle();
                data.Unk_344_raw = reader.ReadSingle();
                data.Unk_345_raw = reader.ReadSingle();
                data.Unk_346_raw = reader.ReadSingle();
                data.Unk_347_raw = reader.ReadSingle();
                data.Unk_348_raw = reader.ReadSingle();
                data.Unk_349_raw = reader.ReadSingle();
                data.Unk_350_raw = reader.ReadSingle();
                data.Unk_351_raw = reader.ReadSingle();
                data.Unk_352_raw = reader.ReadSingle();
                data.Unk_353_raw = reader.ReadSingle();
                data.Unk_354_raw = reader.ReadSingle();
                data.Unk_355_raw = reader.ReadSingle();
                data.Unk_356_raw = reader.ReadSingle();
                data.Unk_357_raw = reader.ReadSingle();
                data.Unk_358_raw = reader.ReadSingle();
                data.Unk_359_raw = reader.ReadSingle();
                data.Unk_360_raw = reader.ReadSingle();
                data.Unk_361_raw = reader.ReadSingle();
                data.Unk_362_raw = reader.ReadSingle();
                data.Unk_363_raw = reader.ReadSingle();
                data.Unk_364_raw = reader.ReadSingle();
                data.Unk_365_raw = reader.ReadSingle();
                data.Unk_366_raw = reader.ReadSingle();
                data.Unk_367_raw = reader.ReadSingle();
                data.Unk_368_raw = reader.ReadSingle();
                data.Unk_369_raw = reader.ReadSingle();
                data.Unk_370_raw = reader.ReadSingle();
                data.Unk_371_raw = reader.ReadSingle();
                data.Unk_372_raw = reader.ReadSingle();
                data.Unk_373_raw = reader.ReadSingle();
                data.Unk_374_raw = reader.ReadSingle();
                data.Unk_375_raw = reader.ReadSingle();
                data.Unk_376_raw = reader.ReadSingle();
                data.Unk_377_raw = reader.ReadSingle();
                data.Unk_378_raw = reader.ReadSingle();
                data.Unk_379_raw = reader.ReadSingle();
                data.Unk_380_raw = reader.ReadSingle();
                data.Unk_381_raw = reader.ReadSingle();
                data.Unk_382_raw = reader.ReadSingle();
                data.Unk_383_raw = reader.ReadSingle();
                data.Unk_384_raw = reader.ReadSingle();
                data.Unk_385_raw = reader.ReadUInt32();
                data.Unk_386_raw = reader.ReadSingle();
                data.Unk_387_raw = reader.ReadSingle();
                data.Unk_388_raw = reader.ReadSingle();
                data.Unk_389_raw = reader.ReadSingle();
                data.Unk_390_raw = reader.ReadSingle();
                data.Unk_391_raw = reader.ReadSingle();
                data.Unk_392_raw = reader.ReadSingle();
                data.Unk_393_raw = reader.ReadSingle();
                data.Unk_394_raw = reader.ReadSingle();
                data.Unk_395_raw = reader.ReadSingle();
                data.Unk_396_raw = reader.ReadSingle();
                data.Unk_397_raw = reader.ReadSingle();
                data.Unk_398_raw = reader.ReadSingle();
                data.Unk_399_raw = reader.ReadSingle();
                data.Unk_400_raw = reader.ReadSingle();
                data.Unk_401_raw = reader.ReadSingle();
                data.Unk_402_raw = reader.ReadSingle();
                data.Unk_403_raw = reader.ReadSingle();
                data.Unk_404_raw = reader.ReadSingle();
                data.Unk_405_raw = reader.ReadSingle();
                data.Unk_406_raw = reader.ReadSingle();
                data.Unk_407_raw = reader.ReadSingle();
                data.Unk_408_raw = reader.ReadSingle();
                data.Unk_409_raw = reader.ReadSingle();
                data.Unk_410_raw = reader.ReadSingle();
                data.Unk_411_raw = reader.ReadSingle();
                data.Unk_412_raw = reader.ReadSingle();
                data.Unk_413_raw = reader.ReadSingle();
                data.Unk_414_raw = reader.ReadSingle();
                data.Unk_415_raw = reader.ReadSingle();
                data.Unk_416_raw = reader.ReadSingle();
                data.Unk_417_raw = reader.ReadSingle();
                data.Unk_418_raw = reader.ReadSingle();
                data.Unk_419_raw = reader.ReadSingle();
                data.Unk_420_raw = reader.ReadSingle();
                data.Unk_421_raw = reader.ReadSingle();
                data.Unk_422_raw = reader.ReadSingle();
                data.Unk_423_raw = reader.ReadSingle();
                data.Unk_424_raw = reader.ReadSingle();
                data.Unk_425_raw = reader.ReadSingle();
                data.Unk_426_raw = reader.ReadSingle();
                data.Unk_427_raw = reader.ReadSingle();
                data.Unk_428_raw = reader.ReadSingle();
                data.Unk_429_raw = reader.ReadSingle();
                data.Unk_430_raw = reader.ReadSingle();
                data.Unk_431_raw = reader.ReadSingle();
                data.Unk_432_raw = reader.ReadSingle();
                data.Unk_433_raw = reader.ReadSingle();
                data.Unk_434_raw = reader.ReadSingle();
                data.Unk_435_raw = reader.ReadSingle();
                data.Unk_436_raw = reader.ReadSingle();
                data.Unk_437_raw = reader.ReadSingle();
                data.Unk_438_raw = reader.ReadSingle();
                data.Unk_439_raw = reader.ReadUInt32();
                data.Unk_440_raw = reader.ReadSingle();
                data.Unk_441_raw = reader.ReadSingle();
                data.Unk_442_raw = reader.ReadSingle();
                data.Unk_443_raw = reader.ReadSingle();
                data.Unk_444_raw = reader.ReadSingle();
                data.Unk_445_raw = reader.ReadSingle();
                data.Unk_446_raw = reader.ReadSingle();
                data.Unk_447_raw = reader.ReadSingle();
                data.Unk_448_raw = reader.ReadSingle();
                data.Unk_449_raw = reader.ReadSingle();
                data.Unk_450_raw = reader.ReadSingle();
                data.Unk_451_raw = reader.ReadSingle();
                data.Unk_452_raw = reader.ReadSingle();
                data.Unk_453_raw = reader.ReadSingle();
                data.Unk_454_raw = reader.ReadSingle();
                data.Unk_455_raw = reader.ReadSingle();
                data.Unk_456_raw = reader.ReadSingle();
                data.Unk_457_raw = reader.ReadSingle();
                data.Unk_458_raw = reader.ReadSingle();
                data.Unk_459_raw = reader.ReadSingle();
                data.Unk_460_raw = reader.ReadSingle();
                data.Unk_461_raw = reader.ReadSingle();
                data.Unk_462_raw = reader.ReadSingle();
                data.Unk_463_raw = reader.ReadSingle();
                data.Unk_464_raw = reader.ReadSingle();
                data.Unk_465_raw = reader.ReadSingle();
                data.Unk_466_raw = reader.ReadSingle();
                data.Unk_467_raw = reader.ReadSingle();
                data.Unk_468_raw = reader.ReadSingle();
                data.Unk_469_raw = reader.ReadSingle();
                data.Unk_470_raw = reader.ReadSingle();
                data.Unk_471_raw = reader.ReadSingle();
                data.Unk_472_raw = reader.ReadSingle();
                data.Unk_473_raw = reader.ReadSingle();
                data.Unk_474_raw = reader.ReadSingle();
                data.Unk_475_raw = reader.ReadSingle();
                data.Unk_476_raw = reader.ReadSingle();
                data.Unk_477_raw = reader.ReadSingle();
                data.Unk_478_raw = reader.ReadSingle();
                data.Unk_479_raw = reader.ReadSingle();
                data.Unk_480_raw = reader.ReadSingle();
                data.Unk_481_raw = reader.ReadSingle();
                data.Unk_482_raw = reader.ReadSingle();
                data.Unk_483_raw = reader.ReadSingle();
                data.Unk_484_raw = reader.ReadSingle();
                data.Unk_485_raw = reader.ReadSingle();
                data.Unk_486_raw = reader.ReadSingle();
                data.Unk_487_raw = reader.ReadSingle();
                data.Unk_488_raw = reader.ReadSingle();
                data.Unk_489_raw = reader.ReadSingle();
                data.Unk_490_raw = reader.ReadSingle();
                data.Unk_491_raw = reader.ReadSingle();
                data.Unk_492_raw = reader.ReadSingle();
                data.Unk_493_raw = reader.ReadInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Shell_Header_raw);
                writer.Write(Shell_raw.ToNullTermCharArray());
                writer.Write(Unk_275_raw);
                writer.Write(Unk_276_raw);
                writer.Write(Unk_277_raw);
                writer.Write(Unk_278_raw);
                writer.Write(Unk_279_raw);
                writer.Write(Unk_280_raw);
                writer.Write(Unk_281_raw);
                writer.Write(Unk_282_raw);
                writer.Write(Unk_283_raw);
                writer.Write(Unk_284_raw);
                writer.Write(Unk_285_raw);
                writer.Write(Unk_286_raw);
                writer.Write(Unk_287_raw);
                writer.Write(Unk_288_raw);
                writer.Write(Unk_289_raw);
                writer.Write(Unk_290_raw);
                writer.Write(Unk_291_raw);
                writer.Write(Unk_292_raw);
                writer.Write(Unk_293_raw);
                writer.Write(Unk_294_raw);
                writer.Write(Unk_295_raw);
                writer.Write(Unk_296_raw);
                writer.Write(Unk_297_raw);
                writer.Write(Unk_298_raw);
                writer.Write(Unk_299_raw);
                writer.Write(Unk_300_raw);
                writer.Write(Unk_301_raw);
                writer.Write(Unk_302_raw);
                writer.Write(Unk_303_raw);
                writer.Write(Unk_304_raw);
                writer.Write(Unk_305_raw);
                writer.Write(Unk_306_raw);
                writer.Write(Unk_307_raw);
                writer.Write(Unk_308_raw);
                writer.Write(Unk_309_raw);
                writer.Write(Unk_310_raw);
                writer.Write(Unk_311_raw);
                writer.Write(Unk_312_raw);
                writer.Write(Unk_313_raw);
                writer.Write(Unk_314_raw);
                writer.Write(Unk_315_raw);
                writer.Write(Unk_316_raw);
                writer.Write(Unk_317_raw);
                writer.Write(Unk_318_raw);
                writer.Write(Unk_319_raw);
                writer.Write(Unk_320_raw);
                writer.Write(Unk_321_raw);
                writer.Write(Unk_322_raw);
                writer.Write(Unk_323_raw);
                writer.Write(Unk_324_raw);
                writer.Write(Unk_325_raw);
                writer.Write(Unk_326_raw);
                writer.Write(Unk_327_raw);
                writer.Write(Unk_328_raw);
                writer.Write(Unk_329_raw);
                writer.Write(Unk_330_raw);
                writer.Write(Unk_331_raw);
                writer.Write(Unk_332_raw);
                writer.Write(Unk_333_raw);
                writer.Write(Unk_334_raw);
                writer.Write(Unk_335_raw);
                writer.Write(Unk_336_raw);
                writer.Write(Unk_337_raw);
                writer.Write(Unk_338_raw);
                writer.Write(Unk_339_raw);
                writer.Write(Unk_340_raw);
                writer.Write(Unk_341_raw);
                writer.Write(Unk_342_raw);
                writer.Write(Unk_343_raw);
                writer.Write(Unk_344_raw);
                writer.Write(Unk_345_raw);
                writer.Write(Unk_346_raw);
                writer.Write(Unk_347_raw);
                writer.Write(Unk_348_raw);
                writer.Write(Unk_349_raw);
                writer.Write(Unk_350_raw);
                writer.Write(Unk_351_raw);
                writer.Write(Unk_352_raw);
                writer.Write(Unk_353_raw);
                writer.Write(Unk_354_raw);
                writer.Write(Unk_355_raw);
                writer.Write(Unk_356_raw);
                writer.Write(Unk_357_raw);
                writer.Write(Unk_358_raw);
                writer.Write(Unk_359_raw);
                writer.Write(Unk_360_raw);
                writer.Write(Unk_361_raw);
                writer.Write(Unk_362_raw);
                writer.Write(Unk_363_raw);
                writer.Write(Unk_364_raw);
                writer.Write(Unk_365_raw);
                writer.Write(Unk_366_raw);
                writer.Write(Unk_367_raw);
                writer.Write(Unk_368_raw);
                writer.Write(Unk_369_raw);
                writer.Write(Unk_370_raw);
                writer.Write(Unk_371_raw);
                writer.Write(Unk_372_raw);
                writer.Write(Unk_373_raw);
                writer.Write(Unk_374_raw);
                writer.Write(Unk_375_raw);
                writer.Write(Unk_376_raw);
                writer.Write(Unk_377_raw);
                writer.Write(Unk_378_raw);
                writer.Write(Unk_379_raw);
                writer.Write(Unk_380_raw);
                writer.Write(Unk_381_raw);
                writer.Write(Unk_382_raw);
                writer.Write(Unk_383_raw);
                writer.Write(Unk_384_raw);
                writer.Write(Unk_385_raw);
                writer.Write(Unk_386_raw);
                writer.Write(Unk_387_raw);
                writer.Write(Unk_388_raw);
                writer.Write(Unk_389_raw);
                writer.Write(Unk_390_raw);
                writer.Write(Unk_391_raw);
                writer.Write(Unk_392_raw);
                writer.Write(Unk_393_raw);
                writer.Write(Unk_394_raw);
                writer.Write(Unk_395_raw);
                writer.Write(Unk_396_raw);
                writer.Write(Unk_397_raw);
                writer.Write(Unk_398_raw);
                writer.Write(Unk_399_raw);
                writer.Write(Unk_400_raw);
                writer.Write(Unk_401_raw);
                writer.Write(Unk_402_raw);
                writer.Write(Unk_403_raw);
                writer.Write(Unk_404_raw);
                writer.Write(Unk_405_raw);
                writer.Write(Unk_406_raw);
                writer.Write(Unk_407_raw);
                writer.Write(Unk_408_raw);
                writer.Write(Unk_409_raw);
                writer.Write(Unk_410_raw);
                writer.Write(Unk_411_raw);
                writer.Write(Unk_412_raw);
                writer.Write(Unk_413_raw);
                writer.Write(Unk_414_raw);
                writer.Write(Unk_415_raw);
                writer.Write(Unk_416_raw);
                writer.Write(Unk_417_raw);
                writer.Write(Unk_418_raw);
                writer.Write(Unk_419_raw);
                writer.Write(Unk_420_raw);
                writer.Write(Unk_421_raw);
                writer.Write(Unk_422_raw);
                writer.Write(Unk_423_raw);
                writer.Write(Unk_424_raw);
                writer.Write(Unk_425_raw);
                writer.Write(Unk_426_raw);
                writer.Write(Unk_427_raw);
                writer.Write(Unk_428_raw);
                writer.Write(Unk_429_raw);
                writer.Write(Unk_430_raw);
                writer.Write(Unk_431_raw);
                writer.Write(Unk_432_raw);
                writer.Write(Unk_433_raw);
                writer.Write(Unk_434_raw);
                writer.Write(Unk_435_raw);
                writer.Write(Unk_436_raw);
                writer.Write(Unk_437_raw);
                writer.Write(Unk_438_raw);
                writer.Write(Unk_439_raw);
                writer.Write(Unk_440_raw);
                writer.Write(Unk_441_raw);
                writer.Write(Unk_442_raw);
                writer.Write(Unk_443_raw);
                writer.Write(Unk_444_raw);
                writer.Write(Unk_445_raw);
                writer.Write(Unk_446_raw);
                writer.Write(Unk_447_raw);
                writer.Write(Unk_448_raw);
                writer.Write(Unk_449_raw);
                writer.Write(Unk_450_raw);
                writer.Write(Unk_451_raw);
                writer.Write(Unk_452_raw);
                writer.Write(Unk_453_raw);
                writer.Write(Unk_454_raw);
                writer.Write(Unk_455_raw);
                writer.Write(Unk_456_raw);
                writer.Write(Unk_457_raw);
                writer.Write(Unk_458_raw);
                writer.Write(Unk_459_raw);
                writer.Write(Unk_460_raw);
                writer.Write(Unk_461_raw);
                writer.Write(Unk_462_raw);
                writer.Write(Unk_463_raw);
                writer.Write(Unk_464_raw);
                writer.Write(Unk_465_raw);
                writer.Write(Unk_466_raw);
                writer.Write(Unk_467_raw);
                writer.Write(Unk_468_raw);
                writer.Write(Unk_469_raw);
                writer.Write(Unk_470_raw);
                writer.Write(Unk_471_raw);
                writer.Write(Unk_472_raw);
                writer.Write(Unk_473_raw);
                writer.Write(Unk_474_raw);
                writer.Write(Unk_475_raw);
                writer.Write(Unk_476_raw);
                writer.Write(Unk_477_raw);
                writer.Write(Unk_478_raw);
                writer.Write(Unk_479_raw);
                writer.Write(Unk_480_raw);
                writer.Write(Unk_481_raw);
                writer.Write(Unk_482_raw);
                writer.Write(Unk_483_raw);
                writer.Write(Unk_484_raw);
                writer.Write(Unk_485_raw);
                writer.Write(Unk_486_raw);
                writer.Write(Unk_487_raw);
                writer.Write(Unk_488_raw);
                writer.Write(Unk_489_raw);
                writer.Write(Unk_490_raw);
                writer.Write(Unk_491_raw);
                writer.Write(Unk_492_raw);
                writer.Write(Unk_493_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Shell Header", "Shell_Header"),
                    new MultiStructItemCustomView(this, "Shell", "Shell"),
                    new MultiStructItemCustomView(this, "Unk 275", "Unk_275"),
                    new MultiStructItemCustomView(this, "Unk 276", "Unk_276"),
                    new MultiStructItemCustomView(this, "Unk 277", "Unk_277"),
                    new MultiStructItemCustomView(this, "Unk 278", "Unk_278"),
                    new MultiStructItemCustomView(this, "Unk 279", "Unk_279"),
                    new MultiStructItemCustomView(this, "Unk 280", "Unk_280"),
                    new MultiStructItemCustomView(this, "Unk 281", "Unk_281"),
                    new MultiStructItemCustomView(this, "Unk 282", "Unk_282"),
                    new MultiStructItemCustomView(this, "Unk 283", "Unk_283"),
                    new MultiStructItemCustomView(this, "Unk 284", "Unk_284"),
                    new MultiStructItemCustomView(this, "Unk 285", "Unk_285"),
                    new MultiStructItemCustomView(this, "Unk 286", "Unk_286"),
                    new MultiStructItemCustomView(this, "Unk 287", "Unk_287"),
                    new MultiStructItemCustomView(this, "Unk 288", "Unk_288"),
                    new MultiStructItemCustomView(this, "Unk 289", "Unk_289"),
                    new MultiStructItemCustomView(this, "Unk 290", "Unk_290"),
                    new MultiStructItemCustomView(this, "Unk 291", "Unk_291"),
                    new MultiStructItemCustomView(this, "Unk 292", "Unk_292"),
                    new MultiStructItemCustomView(this, "Unk 293", "Unk_293"),
                    new MultiStructItemCustomView(this, "Unk 294", "Unk_294"),
                    new MultiStructItemCustomView(this, "Unk 295", "Unk_295"),
                    new MultiStructItemCustomView(this, "Unk 296", "Unk_296"),
                    new MultiStructItemCustomView(this, "Unk 297", "Unk_297"),
                    new MultiStructItemCustomView(this, "Unk 298", "Unk_298"),
                    new MultiStructItemCustomView(this, "Unk 299", "Unk_299"),
                    new MultiStructItemCustomView(this, "Unk 300", "Unk_300"),
                    new MultiStructItemCustomView(this, "Unk 301", "Unk_301"),
                    new MultiStructItemCustomView(this, "Unk 302", "Unk_302"),
                    new MultiStructItemCustomView(this, "Unk 303", "Unk_303"),
                    new MultiStructItemCustomView(this, "Unk 304", "Unk_304"),
                    new MultiStructItemCustomView(this, "Unk 305", "Unk_305"),
                    new MultiStructItemCustomView(this, "Unk 306", "Unk_306"),
                    new MultiStructItemCustomView(this, "Unk 307", "Unk_307"),
                    new MultiStructItemCustomView(this, "Unk 308", "Unk_308"),
                    new MultiStructItemCustomView(this, "Unk 309", "Unk_309"),
                    new MultiStructItemCustomView(this, "Unk 310", "Unk_310"),
                    new MultiStructItemCustomView(this, "Unk 311", "Unk_311"),
                    new MultiStructItemCustomView(this, "Unk 312", "Unk_312"),
                    new MultiStructItemCustomView(this, "Unk 313", "Unk_313"),
                    new MultiStructItemCustomView(this, "Unk 314", "Unk_314"),
                    new MultiStructItemCustomView(this, "Unk 315", "Unk_315"),
                    new MultiStructItemCustomView(this, "Unk 316", "Unk_316"),
                    new MultiStructItemCustomView(this, "Unk 317", "Unk_317"),
                    new MultiStructItemCustomView(this, "Unk 318", "Unk_318"),
                    new MultiStructItemCustomView(this, "Unk 319", "Unk_319"),
                    new MultiStructItemCustomView(this, "Unk 320", "Unk_320"),
                    new MultiStructItemCustomView(this, "Unk 321", "Unk_321"),
                    new MultiStructItemCustomView(this, "Unk 322", "Unk_322"),
                    new MultiStructItemCustomView(this, "Unk 323", "Unk_323"),
                    new MultiStructItemCustomView(this, "Unk 324", "Unk_324"),
                    new MultiStructItemCustomView(this, "Unk 325", "Unk_325"),
                    new MultiStructItemCustomView(this, "Unk 326", "Unk_326"),
                    new MultiStructItemCustomView(this, "Unk 327", "Unk_327"),
                    new MultiStructItemCustomView(this, "Unk 328", "Unk_328"),
                    new MultiStructItemCustomView(this, "Unk 329", "Unk_329"),
                    new MultiStructItemCustomView(this, "Unk 330", "Unk_330"),
                    new MultiStructItemCustomView(this, "Unk 331", "Unk_331"),
                    new MultiStructItemCustomView(this, "Unk 332", "Unk_332"),
                    new MultiStructItemCustomView(this, "Unk 333", "Unk_333"),
                    new MultiStructItemCustomView(this, "Unk 334", "Unk_334"),
                    new MultiStructItemCustomView(this, "Unk 335", "Unk_335"),
                    new MultiStructItemCustomView(this, "Unk 336", "Unk_336"),
                    new MultiStructItemCustomView(this, "Unk 337", "Unk_337"),
                    new MultiStructItemCustomView(this, "Unk 338", "Unk_338"),
                    new MultiStructItemCustomView(this, "Unk 339", "Unk_339"),
                    new MultiStructItemCustomView(this, "Unk 340", "Unk_340"),
                    new MultiStructItemCustomView(this, "Unk 341", "Unk_341"),
                    new MultiStructItemCustomView(this, "Unk 342", "Unk_342"),
                    new MultiStructItemCustomView(this, "Unk 343", "Unk_343"),
                    new MultiStructItemCustomView(this, "Unk 344", "Unk_344"),
                    new MultiStructItemCustomView(this, "Unk 345", "Unk_345"),
                    new MultiStructItemCustomView(this, "Unk 346", "Unk_346"),
                    new MultiStructItemCustomView(this, "Unk 347", "Unk_347"),
                    new MultiStructItemCustomView(this, "Unk 348", "Unk_348"),
                    new MultiStructItemCustomView(this, "Unk 349", "Unk_349"),
                    new MultiStructItemCustomView(this, "Unk 350", "Unk_350"),
                    new MultiStructItemCustomView(this, "Unk 351", "Unk_351"),
                    new MultiStructItemCustomView(this, "Unk 352", "Unk_352"),
                    new MultiStructItemCustomView(this, "Unk 353", "Unk_353"),
                    new MultiStructItemCustomView(this, "Unk 354", "Unk_354"),
                    new MultiStructItemCustomView(this, "Unk 355", "Unk_355"),
                    new MultiStructItemCustomView(this, "Unk 356", "Unk_356"),
                    new MultiStructItemCustomView(this, "Unk 357", "Unk_357"),
                    new MultiStructItemCustomView(this, "Unk 358", "Unk_358"),
                    new MultiStructItemCustomView(this, "Unk 359", "Unk_359"),
                    new MultiStructItemCustomView(this, "Unk 360", "Unk_360"),
                    new MultiStructItemCustomView(this, "Unk 361", "Unk_361"),
                    new MultiStructItemCustomView(this, "Unk 362", "Unk_362"),
                    new MultiStructItemCustomView(this, "Unk 363", "Unk_363"),
                    new MultiStructItemCustomView(this, "Unk 364", "Unk_364"),
                    new MultiStructItemCustomView(this, "Unk 365", "Unk_365"),
                    new MultiStructItemCustomView(this, "Unk 366", "Unk_366"),
                    new MultiStructItemCustomView(this, "Unk 367", "Unk_367"),
                    new MultiStructItemCustomView(this, "Unk 368", "Unk_368"),
                    new MultiStructItemCustomView(this, "Unk 369", "Unk_369"),
                    new MultiStructItemCustomView(this, "Unk 370", "Unk_370"),
                    new MultiStructItemCustomView(this, "Unk 371", "Unk_371"),
                    new MultiStructItemCustomView(this, "Unk 372", "Unk_372"),
                    new MultiStructItemCustomView(this, "Unk 373", "Unk_373"),
                    new MultiStructItemCustomView(this, "Unk 374", "Unk_374"),
                    new MultiStructItemCustomView(this, "Unk 375", "Unk_375"),
                    new MultiStructItemCustomView(this, "Unk 376", "Unk_376"),
                    new MultiStructItemCustomView(this, "Unk 377", "Unk_377"),
                    new MultiStructItemCustomView(this, "Unk 378", "Unk_378"),
                    new MultiStructItemCustomView(this, "Unk 379", "Unk_379"),
                    new MultiStructItemCustomView(this, "Unk 380", "Unk_380"),
                    new MultiStructItemCustomView(this, "Unk 381", "Unk_381"),
                    new MultiStructItemCustomView(this, "Unk 382", "Unk_382"),
                    new MultiStructItemCustomView(this, "Unk 383", "Unk_383"),
                    new MultiStructItemCustomView(this, "Unk 384", "Unk_384"),
                    new MultiStructItemCustomView(this, "Unk 385", "Unk_385"),
                    new MultiStructItemCustomView(this, "Unk 386", "Unk_386"),
                    new MultiStructItemCustomView(this, "Unk 387", "Unk_387"),
                    new MultiStructItemCustomView(this, "Unk 388", "Unk_388"),
                    new MultiStructItemCustomView(this, "Unk 389", "Unk_389"),
                    new MultiStructItemCustomView(this, "Unk 390", "Unk_390"),
                    new MultiStructItemCustomView(this, "Unk 391", "Unk_391"),
                    new MultiStructItemCustomView(this, "Unk 392", "Unk_392"),
                    new MultiStructItemCustomView(this, "Unk 393", "Unk_393"),
                    new MultiStructItemCustomView(this, "Unk 394", "Unk_394"),
                    new MultiStructItemCustomView(this, "Unk 395", "Unk_395"),
                    new MultiStructItemCustomView(this, "Unk 396", "Unk_396"),
                    new MultiStructItemCustomView(this, "Unk 397", "Unk_397"),
                    new MultiStructItemCustomView(this, "Unk 398", "Unk_398"),
                    new MultiStructItemCustomView(this, "Unk 399", "Unk_399"),
                    new MultiStructItemCustomView(this, "Unk 400", "Unk_400"),
                    new MultiStructItemCustomView(this, "Unk 401", "Unk_401"),
                    new MultiStructItemCustomView(this, "Unk 402", "Unk_402"),
                    new MultiStructItemCustomView(this, "Unk 403", "Unk_403"),
                    new MultiStructItemCustomView(this, "Unk 404", "Unk_404"),
                    new MultiStructItemCustomView(this, "Unk 405", "Unk_405"),
                    new MultiStructItemCustomView(this, "Unk 406", "Unk_406"),
                    new MultiStructItemCustomView(this, "Unk 407", "Unk_407"),
                    new MultiStructItemCustomView(this, "Unk 408", "Unk_408"),
                    new MultiStructItemCustomView(this, "Unk 409", "Unk_409"),
                    new MultiStructItemCustomView(this, "Unk 410", "Unk_410"),
                    new MultiStructItemCustomView(this, "Unk 411", "Unk_411"),
                    new MultiStructItemCustomView(this, "Unk 412", "Unk_412"),
                    new MultiStructItemCustomView(this, "Unk 413", "Unk_413"),
                    new MultiStructItemCustomView(this, "Unk 414", "Unk_414"),
                    new MultiStructItemCustomView(this, "Unk 415", "Unk_415"),
                    new MultiStructItemCustomView(this, "Unk 416", "Unk_416"),
                    new MultiStructItemCustomView(this, "Unk 417", "Unk_417"),
                    new MultiStructItemCustomView(this, "Unk 418", "Unk_418"),
                    new MultiStructItemCustomView(this, "Unk 419", "Unk_419"),
                    new MultiStructItemCustomView(this, "Unk 420", "Unk_420"),
                    new MultiStructItemCustomView(this, "Unk 421", "Unk_421"),
                    new MultiStructItemCustomView(this, "Unk 422", "Unk_422"),
                    new MultiStructItemCustomView(this, "Unk 423", "Unk_423"),
                    new MultiStructItemCustomView(this, "Unk 424", "Unk_424"),
                    new MultiStructItemCustomView(this, "Unk 425", "Unk_425"),
                    new MultiStructItemCustomView(this, "Unk 426", "Unk_426"),
                    new MultiStructItemCustomView(this, "Unk 427", "Unk_427"),
                    new MultiStructItemCustomView(this, "Unk 428", "Unk_428"),
                    new MultiStructItemCustomView(this, "Unk 429", "Unk_429"),
                    new MultiStructItemCustomView(this, "Unk 430", "Unk_430"),
                    new MultiStructItemCustomView(this, "Unk 431", "Unk_431"),
                    new MultiStructItemCustomView(this, "Unk 432", "Unk_432"),
                    new MultiStructItemCustomView(this, "Unk 433", "Unk_433"),
                    new MultiStructItemCustomView(this, "Unk 434", "Unk_434"),
                    new MultiStructItemCustomView(this, "Unk 435", "Unk_435"),
                    new MultiStructItemCustomView(this, "Unk 436", "Unk_436"),
                    new MultiStructItemCustomView(this, "Unk 437", "Unk_437"),
                    new MultiStructItemCustomView(this, "Unk 438", "Unk_438"),
                    new MultiStructItemCustomView(this, "Unk 439", "Unk_439"),
                    new MultiStructItemCustomView(this, "Unk 440", "Unk_440"),
                    new MultiStructItemCustomView(this, "Unk 441", "Unk_441"),
                    new MultiStructItemCustomView(this, "Unk 442", "Unk_442"),
                    new MultiStructItemCustomView(this, "Unk 443", "Unk_443"),
                    new MultiStructItemCustomView(this, "Unk 444", "Unk_444"),
                    new MultiStructItemCustomView(this, "Unk 445", "Unk_445"),
                    new MultiStructItemCustomView(this, "Unk 446", "Unk_446"),
                    new MultiStructItemCustomView(this, "Unk 447", "Unk_447"),
                    new MultiStructItemCustomView(this, "Unk 448", "Unk_448"),
                    new MultiStructItemCustomView(this, "Unk 449", "Unk_449"),
                    new MultiStructItemCustomView(this, "Unk 450", "Unk_450"),
                    new MultiStructItemCustomView(this, "Unk 451", "Unk_451"),
                    new MultiStructItemCustomView(this, "Unk 452", "Unk_452"),
                    new MultiStructItemCustomView(this, "Unk 453", "Unk_453"),
                    new MultiStructItemCustomView(this, "Unk 454", "Unk_454"),
                    new MultiStructItemCustomView(this, "Unk 455", "Unk_455"),
                    new MultiStructItemCustomView(this, "Unk 456", "Unk_456"),
                    new MultiStructItemCustomView(this, "Unk 457", "Unk_457"),
                    new MultiStructItemCustomView(this, "Unk 458", "Unk_458"),
                    new MultiStructItemCustomView(this, "Unk 459", "Unk_459"),
                    new MultiStructItemCustomView(this, "Unk 460", "Unk_460"),
                    new MultiStructItemCustomView(this, "Unk 461", "Unk_461"),
                    new MultiStructItemCustomView(this, "Unk 462", "Unk_462"),
                    new MultiStructItemCustomView(this, "Unk 463", "Unk_463"),
                    new MultiStructItemCustomView(this, "Unk 464", "Unk_464"),
                    new MultiStructItemCustomView(this, "Unk 465", "Unk_465"),
                    new MultiStructItemCustomView(this, "Unk 466", "Unk_466"),
                    new MultiStructItemCustomView(this, "Unk 467", "Unk_467"),
                    new MultiStructItemCustomView(this, "Unk 468", "Unk_468"),
                    new MultiStructItemCustomView(this, "Unk 469", "Unk_469"),
                    new MultiStructItemCustomView(this, "Unk 470", "Unk_470"),
                    new MultiStructItemCustomView(this, "Unk 471", "Unk_471"),
                    new MultiStructItemCustomView(this, "Unk 472", "Unk_472"),
                    new MultiStructItemCustomView(this, "Unk 473", "Unk_473"),
                    new MultiStructItemCustomView(this, "Unk 474", "Unk_474"),
                    new MultiStructItemCustomView(this, "Unk 475", "Unk_475"),
                    new MultiStructItemCustomView(this, "Unk 476", "Unk_476"),
                    new MultiStructItemCustomView(this, "Unk 477", "Unk_477"),
                    new MultiStructItemCustomView(this, "Unk 478", "Unk_478"),
                    new MultiStructItemCustomView(this, "Unk 479", "Unk_479"),
                    new MultiStructItemCustomView(this, "Unk 480", "Unk_480"),
                    new MultiStructItemCustomView(this, "Unk 481", "Unk_481"),
                    new MultiStructItemCustomView(this, "Unk 482", "Unk_482"),
                    new MultiStructItemCustomView(this, "Unk 483", "Unk_483"),
                    new MultiStructItemCustomView(this, "Unk 484", "Unk_484"),
                    new MultiStructItemCustomView(this, "Unk 485", "Unk_485"),
                    new MultiStructItemCustomView(this, "Unk 486", "Unk_486"),
                    new MultiStructItemCustomView(this, "Unk 487", "Unk_487"),
                    new MultiStructItemCustomView(this, "Unk 488", "Unk_488"),
                    new MultiStructItemCustomView(this, "Unk 489", "Unk_489"),
                    new MultiStructItemCustomView(this, "Unk 490", "Unk_490"),
                    new MultiStructItemCustomView(this, "Unk 491", "Unk_491"),
                    new MultiStructItemCustomView(this, "Unk 492", "Unk_492"),
                    new MultiStructItemCustomView(this, "Unk 493", "Unk_493"),
                };
            }
        }

        public partial class Monster_Common_Params_11_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Monster Common Params (11)";

            protected uint Header_raw;
            public const string Header_displayName = "Header";
            public const int Header_sortIndex = 50;
            [SortOrder(Header_sortIndex)]
            [DisplayName(Header_displayName)]
            public virtual uint Header {
                get => Header_raw;
                set {
                    if (Header_raw == value) return;
                    Header_raw = value;
                    ChangedItems.Add(nameof(Header));
                    OnPropertyChanged(nameof(Header));
                }
            }

            protected float Unk_494_raw;
            public const string Unk_494_displayName = "Unk 494";
            public const int Unk_494_sortIndex = 100;
            [SortOrder(Unk_494_sortIndex)]
            [DisplayName(Unk_494_displayName)]
            public virtual float Unk_494 {
                get => Unk_494_raw;
                set {
                    if (Unk_494_raw == value) return;
                    Unk_494_raw = value;
                    ChangedItems.Add(nameof(Unk_494));
                    OnPropertyChanged(nameof(Unk_494));
                }
            }

            protected uint Unk_Arr_5_Count_raw;
            public const string Unk_Arr_5_Count_displayName = "Unk Arr 5 Count";
            public const int Unk_Arr_5_Count_sortIndex = 150;
            [SortOrder(Unk_Arr_5_Count_sortIndex)]
            [DisplayName(Unk_Arr_5_Count_displayName)]
            public virtual uint Unk_Arr_5_Count {
                get => Unk_Arr_5_Count_raw;
                set {
                    if (Unk_Arr_5_Count_raw == value) return;
                    Unk_Arr_5_Count_raw = value;
                    ChangedItems.Add(nameof(Unk_Arr_5_Count));
                    OnPropertyChanged(nameof(Unk_Arr_5_Count));
                }
            }

            public const int lastSortIndex = 200;

            public static ObservableMhwStructCollection<Monster_Common_Params_11_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Monster_Common_Params_11_>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Monster_Common_Params_11_ LoadData(BinaryReader reader, ulong i) {
                var data = new Monster_Common_Params_11_();
                data.Index = i;
                data.Header_raw = reader.ReadUInt32();
                data.Unk_494_raw = reader.ReadSingle();
                data.Unk_Arr_5_Count_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Header_raw);
                writer.Write(Unk_494_raw);
                writer.Write(Unk_Arr_5_Count_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Header", "Header"),
                    new MultiStructItemCustomView(this, "Unk 494", "Unk_494"),
                    new MultiStructItemCustomView(this, "Unk Arr 5 Count", "Unk_Arr_5_Count"),
                };
            }
        }

        public partial class Unk_Arr_5 : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 0;
            public const string GridName = "Unk Arr 5";
            public const bool IsAddingAllowed = true;

            [SortOrder(-1)]
            [IsReadOnly]
            [DisplayName("X")]
            public string Delete => "X";

            protected uint Unk_1_raw;
            public const string Unk_1_displayName = "Unk 1";
            public const int Unk_1_sortIndex = 50;
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

            protected uint Header_raw;
            public const string Header_displayName = "Header";
            public const int Header_sortIndex = 100;
            [SortOrder(Header_sortIndex)]
            [DisplayName(Header_displayName)]
            public virtual uint Header {
                get => Header_raw;
                set {
                    if (Header_raw == value) return;
                    Header_raw = value;
                    ChangedItems.Add(nameof(Header));
                    OnPropertyChanged(nameof(Header));
                }
            }

            protected float Unk_3_raw;
            public const string Unk_3_displayName = "Unk 3";
            public const int Unk_3_sortIndex = 150;
            [SortOrder(Unk_3_sortIndex)]
            [DisplayName(Unk_3_displayName)]
            public virtual float Unk_3 {
                get => Unk_3_raw;
                set {
                    if (Unk_3_raw == value) return;
                    Unk_3_raw = value;
                    ChangedItems.Add(nameof(Unk_3));
                    OnPropertyChanged(nameof(Unk_3));
                }
            }

            public const int lastSortIndex = 200;

            public static ObservableMhwStructCollection<Unk_Arr_5> LoadData(BinaryReader reader, ObservableMhwStructCollection<Monster_Common_Params_11_> lastStruct) {
                var list = new ObservableMhwStructCollection<Unk_Arr_5>();
                var countTarget = (Monster_Common_Params_11_) lastStruct.Last();
                var count = (ulong) countTarget.Unk_Arr_5_Count;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Unk_Arr_5 LoadData(BinaryReader reader, ulong i) {
                var data = new Unk_Arr_5();
                data.Index = i;
                data.Unk_1_raw = reader.ReadUInt32();
                data.Header_raw = reader.ReadUInt32();
                data.Unk_3_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_1_raw);
                writer.Write(Header_raw);
                writer.Write(Unk_3_raw);
            }
        }

        public partial class Monster_Common_Params_12_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Monster Common Params (12)";

            protected float Unk_495_raw;
            public const string Unk_495_displayName = "Unk 495";
            public const int Unk_495_sortIndex = 50;
            [SortOrder(Unk_495_sortIndex)]
            [DisplayName(Unk_495_displayName)]
            public virtual float Unk_495 {
                get => Unk_495_raw;
                set {
                    if (Unk_495_raw == value) return;
                    Unk_495_raw = value;
                    ChangedItems.Add(nameof(Unk_495));
                    OnPropertyChanged(nameof(Unk_495));
                }
            }

            protected uint Unk_496_raw;
            public const string Unk_496_displayName = "Unk 496";
            public const int Unk_496_sortIndex = 100;
            [SortOrder(Unk_496_sortIndex)]
            [DisplayName(Unk_496_displayName)]
            public virtual uint Unk_496 {
                get => Unk_496_raw;
                set {
                    if (Unk_496_raw == value) return;
                    Unk_496_raw = value;
                    ChangedItems.Add(nameof(Unk_496));
                    OnPropertyChanged(nameof(Unk_496));
                }
            }

            protected uint Unk_Arr_6_Count_raw;
            public const string Unk_Arr_6_Count_displayName = "Unk Arr 6 Count";
            public const int Unk_Arr_6_Count_sortIndex = 150;
            [SortOrder(Unk_Arr_6_Count_sortIndex)]
            [DisplayName(Unk_Arr_6_Count_displayName)]
            public virtual uint Unk_Arr_6_Count {
                get => Unk_Arr_6_Count_raw;
                set {
                    if (Unk_Arr_6_Count_raw == value) return;
                    Unk_Arr_6_Count_raw = value;
                    ChangedItems.Add(nameof(Unk_Arr_6_Count));
                    OnPropertyChanged(nameof(Unk_Arr_6_Count));
                }
            }

            public const int lastSortIndex = 200;

            public static ObservableMhwStructCollection<Monster_Common_Params_12_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Monster_Common_Params_12_>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Monster_Common_Params_12_ LoadData(BinaryReader reader, ulong i) {
                var data = new Monster_Common_Params_12_();
                data.Index = i;
                data.Unk_495_raw = reader.ReadSingle();
                data.Unk_496_raw = reader.ReadUInt32();
                data.Unk_Arr_6_Count_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_495_raw);
                writer.Write(Unk_496_raw);
                writer.Write(Unk_Arr_6_Count_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Unk 495", "Unk_495"),
                    new MultiStructItemCustomView(this, "Unk 496", "Unk_496"),
                    new MultiStructItemCustomView(this, "Unk Arr 6 Count", "Unk_Arr_6_Count"),
                };
            }
        }

        public partial class Unk_Arr_6 : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 0;
            public const string GridName = "Unk Arr 6";
            public const bool IsAddingAllowed = true;

            [SortOrder(-1)]
            [IsReadOnly]
            [DisplayName("X")]
            public string Delete => "X";

            protected uint Unk_1_raw;
            public const string Unk_1_displayName = "Unk 1";
            public const int Unk_1_sortIndex = 50;
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

            protected uint Unk_2_raw;
            public const string Unk_2_displayName = "Unk 2";
            public const int Unk_2_sortIndex = 100;
            [SortOrder(Unk_2_sortIndex)]
            [DisplayName(Unk_2_displayName)]
            public virtual uint Unk_2 {
                get => Unk_2_raw;
                set {
                    if (Unk_2_raw == value) return;
                    Unk_2_raw = value;
                    ChangedItems.Add(nameof(Unk_2));
                    OnPropertyChanged(nameof(Unk_2));
                }
            }

            public const int lastSortIndex = 150;

            public static ObservableMhwStructCollection<Unk_Arr_6> LoadData(BinaryReader reader, ObservableMhwStructCollection<Monster_Common_Params_12_> lastStruct) {
                var list = new ObservableMhwStructCollection<Unk_Arr_6>();
                var countTarget = (Monster_Common_Params_12_) lastStruct.Last();
                var count = (ulong) countTarget.Unk_Arr_6_Count;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Unk_Arr_6 LoadData(BinaryReader reader, ulong i) {
                var data = new Unk_Arr_6();
                data.Index = i;
                data.Unk_1_raw = reader.ReadUInt32();
                data.Unk_2_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_1_raw);
                writer.Write(Unk_2_raw);
            }
        }

        public partial class Monster_Common_Params_13_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Monster Common Params (13)";

            protected uint Unk_497_raw;
            public const string Unk_497_displayName = "Unk 497";
            public const int Unk_497_sortIndex = 50;
            [SortOrder(Unk_497_sortIndex)]
            [DisplayName(Unk_497_displayName)]
            public virtual uint Unk_497 {
                get => Unk_497_raw;
                set {
                    if (Unk_497_raw == value) return;
                    Unk_497_raw = value;
                    ChangedItems.Add(nameof(Unk_497));
                    OnPropertyChanged(nameof(Unk_497));
                }
            }

            protected uint Unk_498_raw;
            public const string Unk_498_displayName = "Unk 498";
            public const int Unk_498_sortIndex = 100;
            [SortOrder(Unk_498_sortIndex)]
            [DisplayName(Unk_498_displayName)]
            public virtual uint Unk_498 {
                get => Unk_498_raw;
                set {
                    if (Unk_498_raw == value) return;
                    Unk_498_raw = value;
                    ChangedItems.Add(nameof(Unk_498));
                    OnPropertyChanged(nameof(Unk_498));
                }
            }

            protected float Unk_499_raw;
            public const string Unk_499_displayName = "Unk 499";
            public const int Unk_499_sortIndex = 150;
            [SortOrder(Unk_499_sortIndex)]
            [DisplayName(Unk_499_displayName)]
            public virtual float Unk_499 {
                get => Unk_499_raw;
                set {
                    if (Unk_499_raw == value) return;
                    Unk_499_raw = value;
                    ChangedItems.Add(nameof(Unk_499));
                    OnPropertyChanged(nameof(Unk_499));
                }
            }

            protected uint Unk_500_raw;
            public const string Unk_500_displayName = "Unk 500";
            public const int Unk_500_sortIndex = 200;
            [SortOrder(Unk_500_sortIndex)]
            [DisplayName(Unk_500_displayName)]
            public virtual uint Unk_500 {
                get => Unk_500_raw;
                set {
                    if (Unk_500_raw == value) return;
                    Unk_500_raw = value;
                    ChangedItems.Add(nameof(Unk_500));
                    OnPropertyChanged(nameof(Unk_500));
                }
            }

            protected uint Unk_501_raw;
            public const string Unk_501_displayName = "Unk 501";
            public const int Unk_501_sortIndex = 250;
            [SortOrder(Unk_501_sortIndex)]
            [DisplayName(Unk_501_displayName)]
            public virtual uint Unk_501 {
                get => Unk_501_raw;
                set {
                    if (Unk_501_raw == value) return;
                    Unk_501_raw = value;
                    ChangedItems.Add(nameof(Unk_501));
                    OnPropertyChanged(nameof(Unk_501));
                }
            }

            protected int Unk_502_raw;
            public const string Unk_502_displayName = "Unk 502";
            public const int Unk_502_sortIndex = 300;
            [SortOrder(Unk_502_sortIndex)]
            [DisplayName(Unk_502_displayName)]
            public virtual int Unk_502 {
                get => Unk_502_raw;
                set {
                    if (Unk_502_raw == value) return;
                    Unk_502_raw = value;
                    ChangedItems.Add(nameof(Unk_502));
                    OnPropertyChanged(nameof(Unk_502));
                }
            }

            protected uint Unk_503_raw;
            public const string Unk_503_displayName = "Unk 503";
            public const int Unk_503_sortIndex = 350;
            [SortOrder(Unk_503_sortIndex)]
            [DisplayName(Unk_503_displayName)]
            public virtual uint Unk_503 {
                get => Unk_503_raw;
                set {
                    if (Unk_503_raw == value) return;
                    Unk_503_raw = value;
                    ChangedItems.Add(nameof(Unk_503));
                    OnPropertyChanged(nameof(Unk_503));
                }
            }

            protected uint Unk_504_raw;
            public const string Unk_504_displayName = "Unk 504";
            public const int Unk_504_sortIndex = 400;
            [SortOrder(Unk_504_sortIndex)]
            [DisplayName(Unk_504_displayName)]
            public virtual uint Unk_504 {
                get => Unk_504_raw;
                set {
                    if (Unk_504_raw == value) return;
                    Unk_504_raw = value;
                    ChangedItems.Add(nameof(Unk_504));
                    OnPropertyChanged(nameof(Unk_504));
                }
            }

            protected uint Unk_505_raw;
            public const string Unk_505_displayName = "Unk 505";
            public const int Unk_505_sortIndex = 450;
            [SortOrder(Unk_505_sortIndex)]
            [DisplayName(Unk_505_displayName)]
            public virtual uint Unk_505 {
                get => Unk_505_raw;
                set {
                    if (Unk_505_raw == value) return;
                    Unk_505_raw = value;
                    ChangedItems.Add(nameof(Unk_505));
                    OnPropertyChanged(nameof(Unk_505));
                }
            }

            protected uint Unk_506_raw;
            public const string Unk_506_displayName = "Unk 506";
            public const int Unk_506_sortIndex = 500;
            [SortOrder(Unk_506_sortIndex)]
            [DisplayName(Unk_506_displayName)]
            public virtual uint Unk_506 {
                get => Unk_506_raw;
                set {
                    if (Unk_506_raw == value) return;
                    Unk_506_raw = value;
                    ChangedItems.Add(nameof(Unk_506));
                    OnPropertyChanged(nameof(Unk_506));
                }
            }

            protected uint Unk_507_raw;
            public const string Unk_507_displayName = "Unk 507";
            public const int Unk_507_sortIndex = 550;
            [SortOrder(Unk_507_sortIndex)]
            [DisplayName(Unk_507_displayName)]
            public virtual uint Unk_507 {
                get => Unk_507_raw;
                set {
                    if (Unk_507_raw == value) return;
                    Unk_507_raw = value;
                    ChangedItems.Add(nameof(Unk_507));
                    OnPropertyChanged(nameof(Unk_507));
                }
            }

            protected uint Unk_508_raw;
            public const string Unk_508_displayName = "Unk 508";
            public const int Unk_508_sortIndex = 600;
            [SortOrder(Unk_508_sortIndex)]
            [DisplayName(Unk_508_displayName)]
            public virtual uint Unk_508 {
                get => Unk_508_raw;
                set {
                    if (Unk_508_raw == value) return;
                    Unk_508_raw = value;
                    ChangedItems.Add(nameof(Unk_508));
                    OnPropertyChanged(nameof(Unk_508));
                }
            }

            protected float Unk_509_raw;
            public const string Unk_509_displayName = "Unk 509";
            public const int Unk_509_sortIndex = 650;
            [SortOrder(Unk_509_sortIndex)]
            [DisplayName(Unk_509_displayName)]
            public virtual float Unk_509 {
                get => Unk_509_raw;
                set {
                    if (Unk_509_raw == value) return;
                    Unk_509_raw = value;
                    ChangedItems.Add(nameof(Unk_509));
                    OnPropertyChanged(nameof(Unk_509));
                }
            }

            protected uint Unk_510_raw;
            public const string Unk_510_displayName = "Unk 510";
            public const int Unk_510_sortIndex = 700;
            [SortOrder(Unk_510_sortIndex)]
            [DisplayName(Unk_510_displayName)]
            public virtual uint Unk_510 {
                get => Unk_510_raw;
                set {
                    if (Unk_510_raw == value) return;
                    Unk_510_raw = value;
                    ChangedItems.Add(nameof(Unk_510));
                    OnPropertyChanged(nameof(Unk_510));
                }
            }

            protected uint Unk_511_raw;
            public const string Unk_511_displayName = "Unk 511";
            public const int Unk_511_sortIndex = 750;
            [SortOrder(Unk_511_sortIndex)]
            [DisplayName(Unk_511_displayName)]
            public virtual uint Unk_511 {
                get => Unk_511_raw;
                set {
                    if (Unk_511_raw == value) return;
                    Unk_511_raw = value;
                    ChangedItems.Add(nameof(Unk_511));
                    OnPropertyChanged(nameof(Unk_511));
                }
            }

            protected float Unk_512_raw;
            public const string Unk_512_displayName = "Unk 512";
            public const int Unk_512_sortIndex = 800;
            [SortOrder(Unk_512_sortIndex)]
            [DisplayName(Unk_512_displayName)]
            public virtual float Unk_512 {
                get => Unk_512_raw;
                set {
                    if (Unk_512_raw == value) return;
                    Unk_512_raw = value;
                    ChangedItems.Add(nameof(Unk_512));
                    OnPropertyChanged(nameof(Unk_512));
                }
            }

            protected uint Unk_513_raw;
            public const string Unk_513_displayName = "Unk 513";
            public const int Unk_513_sortIndex = 850;
            [SortOrder(Unk_513_sortIndex)]
            [DisplayName(Unk_513_displayName)]
            public virtual uint Unk_513 {
                get => Unk_513_raw;
                set {
                    if (Unk_513_raw == value) return;
                    Unk_513_raw = value;
                    ChangedItems.Add(nameof(Unk_513));
                    OnPropertyChanged(nameof(Unk_513));
                }
            }

            protected uint Unk_514_raw;
            public const string Unk_514_displayName = "Unk 514";
            public const int Unk_514_sortIndex = 900;
            [SortOrder(Unk_514_sortIndex)]
            [DisplayName(Unk_514_displayName)]
            public virtual uint Unk_514 {
                get => Unk_514_raw;
                set {
                    if (Unk_514_raw == value) return;
                    Unk_514_raw = value;
                    ChangedItems.Add(nameof(Unk_514));
                    OnPropertyChanged(nameof(Unk_514));
                }
            }

            protected uint Unk_515_raw;
            public const string Unk_515_displayName = "Unk 515";
            public const int Unk_515_sortIndex = 950;
            [SortOrder(Unk_515_sortIndex)]
            [DisplayName(Unk_515_displayName)]
            public virtual uint Unk_515 {
                get => Unk_515_raw;
                set {
                    if (Unk_515_raw == value) return;
                    Unk_515_raw = value;
                    ChangedItems.Add(nameof(Unk_515));
                    OnPropertyChanged(nameof(Unk_515));
                }
            }

            protected int Unk_516_raw;
            public const string Unk_516_displayName = "Unk 516";
            public const int Unk_516_sortIndex = 1000;
            [SortOrder(Unk_516_sortIndex)]
            [DisplayName(Unk_516_displayName)]
            public virtual int Unk_516 {
                get => Unk_516_raw;
                set {
                    if (Unk_516_raw == value) return;
                    Unk_516_raw = value;
                    ChangedItems.Add(nameof(Unk_516));
                    OnPropertyChanged(nameof(Unk_516));
                }
            }

            protected uint Unk_517_raw;
            public const string Unk_517_displayName = "Unk 517";
            public const int Unk_517_sortIndex = 1050;
            [SortOrder(Unk_517_sortIndex)]
            [DisplayName(Unk_517_displayName)]
            public virtual uint Unk_517 {
                get => Unk_517_raw;
                set {
                    if (Unk_517_raw == value) return;
                    Unk_517_raw = value;
                    ChangedItems.Add(nameof(Unk_517));
                    OnPropertyChanged(nameof(Unk_517));
                }
            }

            protected uint Unk_518_raw;
            public const string Unk_518_displayName = "Unk 518";
            public const int Unk_518_sortIndex = 1100;
            [SortOrder(Unk_518_sortIndex)]
            [DisplayName(Unk_518_displayName)]
            public virtual uint Unk_518 {
                get => Unk_518_raw;
                set {
                    if (Unk_518_raw == value) return;
                    Unk_518_raw = value;
                    ChangedItems.Add(nameof(Unk_518));
                    OnPropertyChanged(nameof(Unk_518));
                }
            }

            protected uint Unk_519_raw;
            public const string Unk_519_displayName = "Unk 519";
            public const int Unk_519_sortIndex = 1150;
            [SortOrder(Unk_519_sortIndex)]
            [DisplayName(Unk_519_displayName)]
            public virtual uint Unk_519 {
                get => Unk_519_raw;
                set {
                    if (Unk_519_raw == value) return;
                    Unk_519_raw = value;
                    ChangedItems.Add(nameof(Unk_519));
                    OnPropertyChanged(nameof(Unk_519));
                }
            }

            protected uint Unk_520_raw;
            public const string Unk_520_displayName = "Unk 520";
            public const int Unk_520_sortIndex = 1200;
            [SortOrder(Unk_520_sortIndex)]
            [DisplayName(Unk_520_displayName)]
            public virtual uint Unk_520 {
                get => Unk_520_raw;
                set {
                    if (Unk_520_raw == value) return;
                    Unk_520_raw = value;
                    ChangedItems.Add(nameof(Unk_520));
                    OnPropertyChanged(nameof(Unk_520));
                }
            }

            protected uint Unk_521_raw;
            public const string Unk_521_displayName = "Unk 521";
            public const int Unk_521_sortIndex = 1250;
            [SortOrder(Unk_521_sortIndex)]
            [DisplayName(Unk_521_displayName)]
            public virtual uint Unk_521 {
                get => Unk_521_raw;
                set {
                    if (Unk_521_raw == value) return;
                    Unk_521_raw = value;
                    ChangedItems.Add(nameof(Unk_521));
                    OnPropertyChanged(nameof(Unk_521));
                }
            }

            protected uint Unk_522_raw;
            public const string Unk_522_displayName = "Unk 522";
            public const int Unk_522_sortIndex = 1300;
            [SortOrder(Unk_522_sortIndex)]
            [DisplayName(Unk_522_displayName)]
            public virtual uint Unk_522 {
                get => Unk_522_raw;
                set {
                    if (Unk_522_raw == value) return;
                    Unk_522_raw = value;
                    ChangedItems.Add(nameof(Unk_522));
                    OnPropertyChanged(nameof(Unk_522));
                }
            }

            protected float Unk_523_raw;
            public const string Unk_523_displayName = "Unk 523";
            public const int Unk_523_sortIndex = 1350;
            [SortOrder(Unk_523_sortIndex)]
            [DisplayName(Unk_523_displayName)]
            public virtual float Unk_523 {
                get => Unk_523_raw;
                set {
                    if (Unk_523_raw == value) return;
                    Unk_523_raw = value;
                    ChangedItems.Add(nameof(Unk_523));
                    OnPropertyChanged(nameof(Unk_523));
                }
            }

            protected uint Unk_524_raw;
            public const string Unk_524_displayName = "Unk 524";
            public const int Unk_524_sortIndex = 1400;
            [SortOrder(Unk_524_sortIndex)]
            [DisplayName(Unk_524_displayName)]
            public virtual uint Unk_524 {
                get => Unk_524_raw;
                set {
                    if (Unk_524_raw == value) return;
                    Unk_524_raw = value;
                    ChangedItems.Add(nameof(Unk_524));
                    OnPropertyChanged(nameof(Unk_524));
                }
            }

            protected uint Unk_525_raw;
            public const string Unk_525_displayName = "Unk 525";
            public const int Unk_525_sortIndex = 1450;
            [SortOrder(Unk_525_sortIndex)]
            [DisplayName(Unk_525_displayName)]
            public virtual uint Unk_525 {
                get => Unk_525_raw;
                set {
                    if (Unk_525_raw == value) return;
                    Unk_525_raw = value;
                    ChangedItems.Add(nameof(Unk_525));
                    OnPropertyChanged(nameof(Unk_525));
                }
            }

            protected float Unk_526_raw;
            public const string Unk_526_displayName = "Unk 526";
            public const int Unk_526_sortIndex = 1500;
            [SortOrder(Unk_526_sortIndex)]
            [DisplayName(Unk_526_displayName)]
            public virtual float Unk_526 {
                get => Unk_526_raw;
                set {
                    if (Unk_526_raw == value) return;
                    Unk_526_raw = value;
                    ChangedItems.Add(nameof(Unk_526));
                    OnPropertyChanged(nameof(Unk_526));
                }
            }

            protected uint Unk_527_raw;
            public const string Unk_527_displayName = "Unk 527";
            public const int Unk_527_sortIndex = 1550;
            [SortOrder(Unk_527_sortIndex)]
            [DisplayName(Unk_527_displayName)]
            public virtual uint Unk_527 {
                get => Unk_527_raw;
                set {
                    if (Unk_527_raw == value) return;
                    Unk_527_raw = value;
                    ChangedItems.Add(nameof(Unk_527));
                    OnPropertyChanged(nameof(Unk_527));
                }
            }

            protected float Unk_528_raw;
            public const string Unk_528_displayName = "Unk 528";
            public const int Unk_528_sortIndex = 1600;
            [SortOrder(Unk_528_sortIndex)]
            [DisplayName(Unk_528_displayName)]
            public virtual float Unk_528 {
                get => Unk_528_raw;
                set {
                    if (Unk_528_raw == value) return;
                    Unk_528_raw = value;
                    ChangedItems.Add(nameof(Unk_528));
                    OnPropertyChanged(nameof(Unk_528));
                }
            }

            protected float Unk_529_raw;
            public const string Unk_529_displayName = "Unk 529";
            public const int Unk_529_sortIndex = 1650;
            [SortOrder(Unk_529_sortIndex)]
            [DisplayName(Unk_529_displayName)]
            public virtual float Unk_529 {
                get => Unk_529_raw;
                set {
                    if (Unk_529_raw == value) return;
                    Unk_529_raw = value;
                    ChangedItems.Add(nameof(Unk_529));
                    OnPropertyChanged(nameof(Unk_529));
                }
            }

            protected float Unk_530_raw;
            public const string Unk_530_displayName = "Unk 530";
            public const int Unk_530_sortIndex = 1700;
            [SortOrder(Unk_530_sortIndex)]
            [DisplayName(Unk_530_displayName)]
            public virtual float Unk_530 {
                get => Unk_530_raw;
                set {
                    if (Unk_530_raw == value) return;
                    Unk_530_raw = value;
                    ChangedItems.Add(nameof(Unk_530));
                    OnPropertyChanged(nameof(Unk_530));
                }
            }

            protected float Unk_531_raw;
            public const string Unk_531_displayName = "Unk 531";
            public const int Unk_531_sortIndex = 1750;
            [SortOrder(Unk_531_sortIndex)]
            [DisplayName(Unk_531_displayName)]
            public virtual float Unk_531 {
                get => Unk_531_raw;
                set {
                    if (Unk_531_raw == value) return;
                    Unk_531_raw = value;
                    ChangedItems.Add(nameof(Unk_531));
                    OnPropertyChanged(nameof(Unk_531));
                }
            }

            protected float Unk_532_raw;
            public const string Unk_532_displayName = "Unk 532";
            public const int Unk_532_sortIndex = 1800;
            [SortOrder(Unk_532_sortIndex)]
            [DisplayName(Unk_532_displayName)]
            public virtual float Unk_532 {
                get => Unk_532_raw;
                set {
                    if (Unk_532_raw == value) return;
                    Unk_532_raw = value;
                    ChangedItems.Add(nameof(Unk_532));
                    OnPropertyChanged(nameof(Unk_532));
                }
            }

            public const int lastSortIndex = 1850;

            public static ObservableMhwStructCollection<Monster_Common_Params_13_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Monster_Common_Params_13_>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Monster_Common_Params_13_ LoadData(BinaryReader reader, ulong i) {
                var data = new Monster_Common_Params_13_();
                data.Index = i;
                data.Unk_497_raw = reader.ReadUInt32();
                data.Unk_498_raw = reader.ReadUInt32();
                data.Unk_499_raw = reader.ReadSingle();
                data.Unk_500_raw = reader.ReadUInt32();
                data.Unk_501_raw = reader.ReadUInt32();
                data.Unk_502_raw = reader.ReadInt32();
                data.Unk_503_raw = reader.ReadUInt32();
                data.Unk_504_raw = reader.ReadUInt32();
                data.Unk_505_raw = reader.ReadUInt32();
                data.Unk_506_raw = reader.ReadUInt32();
                data.Unk_507_raw = reader.ReadUInt32();
                data.Unk_508_raw = reader.ReadUInt32();
                data.Unk_509_raw = reader.ReadSingle();
                data.Unk_510_raw = reader.ReadUInt32();
                data.Unk_511_raw = reader.ReadUInt32();
                data.Unk_512_raw = reader.ReadSingle();
                data.Unk_513_raw = reader.ReadUInt32();
                data.Unk_514_raw = reader.ReadUInt32();
                data.Unk_515_raw = reader.ReadUInt32();
                data.Unk_516_raw = reader.ReadInt32();
                data.Unk_517_raw = reader.ReadUInt32();
                data.Unk_518_raw = reader.ReadUInt32();
                data.Unk_519_raw = reader.ReadUInt32();
                data.Unk_520_raw = reader.ReadUInt32();
                data.Unk_521_raw = reader.ReadUInt32();
                data.Unk_522_raw = reader.ReadUInt32();
                data.Unk_523_raw = reader.ReadSingle();
                data.Unk_524_raw = reader.ReadUInt32();
                data.Unk_525_raw = reader.ReadUInt32();
                data.Unk_526_raw = reader.ReadSingle();
                data.Unk_527_raw = reader.ReadUInt32();
                data.Unk_528_raw = reader.ReadSingle();
                data.Unk_529_raw = reader.ReadSingle();
                data.Unk_530_raw = reader.ReadSingle();
                data.Unk_531_raw = reader.ReadSingle();
                data.Unk_532_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_497_raw);
                writer.Write(Unk_498_raw);
                writer.Write(Unk_499_raw);
                writer.Write(Unk_500_raw);
                writer.Write(Unk_501_raw);
                writer.Write(Unk_502_raw);
                writer.Write(Unk_503_raw);
                writer.Write(Unk_504_raw);
                writer.Write(Unk_505_raw);
                writer.Write(Unk_506_raw);
                writer.Write(Unk_507_raw);
                writer.Write(Unk_508_raw);
                writer.Write(Unk_509_raw);
                writer.Write(Unk_510_raw);
                writer.Write(Unk_511_raw);
                writer.Write(Unk_512_raw);
                writer.Write(Unk_513_raw);
                writer.Write(Unk_514_raw);
                writer.Write(Unk_515_raw);
                writer.Write(Unk_516_raw);
                writer.Write(Unk_517_raw);
                writer.Write(Unk_518_raw);
                writer.Write(Unk_519_raw);
                writer.Write(Unk_520_raw);
                writer.Write(Unk_521_raw);
                writer.Write(Unk_522_raw);
                writer.Write(Unk_523_raw);
                writer.Write(Unk_524_raw);
                writer.Write(Unk_525_raw);
                writer.Write(Unk_526_raw);
                writer.Write(Unk_527_raw);
                writer.Write(Unk_528_raw);
                writer.Write(Unk_529_raw);
                writer.Write(Unk_530_raw);
                writer.Write(Unk_531_raw);
                writer.Write(Unk_532_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Unk 497", "Unk_497"),
                    new MultiStructItemCustomView(this, "Unk 498", "Unk_498"),
                    new MultiStructItemCustomView(this, "Unk 499", "Unk_499"),
                    new MultiStructItemCustomView(this, "Unk 500", "Unk_500"),
                    new MultiStructItemCustomView(this, "Unk 501", "Unk_501"),
                    new MultiStructItemCustomView(this, "Unk 502", "Unk_502"),
                    new MultiStructItemCustomView(this, "Unk 503", "Unk_503"),
                    new MultiStructItemCustomView(this, "Unk 504", "Unk_504"),
                    new MultiStructItemCustomView(this, "Unk 505", "Unk_505"),
                    new MultiStructItemCustomView(this, "Unk 506", "Unk_506"),
                    new MultiStructItemCustomView(this, "Unk 507", "Unk_507"),
                    new MultiStructItemCustomView(this, "Unk 508", "Unk_508"),
                    new MultiStructItemCustomView(this, "Unk 509", "Unk_509"),
                    new MultiStructItemCustomView(this, "Unk 510", "Unk_510"),
                    new MultiStructItemCustomView(this, "Unk 511", "Unk_511"),
                    new MultiStructItemCustomView(this, "Unk 512", "Unk_512"),
                    new MultiStructItemCustomView(this, "Unk 513", "Unk_513"),
                    new MultiStructItemCustomView(this, "Unk 514", "Unk_514"),
                    new MultiStructItemCustomView(this, "Unk 515", "Unk_515"),
                    new MultiStructItemCustomView(this, "Unk 516", "Unk_516"),
                    new MultiStructItemCustomView(this, "Unk 517", "Unk_517"),
                    new MultiStructItemCustomView(this, "Unk 518", "Unk_518"),
                    new MultiStructItemCustomView(this, "Unk 519", "Unk_519"),
                    new MultiStructItemCustomView(this, "Unk 520", "Unk_520"),
                    new MultiStructItemCustomView(this, "Unk 521", "Unk_521"),
                    new MultiStructItemCustomView(this, "Unk 522", "Unk_522"),
                    new MultiStructItemCustomView(this, "Unk 523", "Unk_523"),
                    new MultiStructItemCustomView(this, "Unk 524", "Unk_524"),
                    new MultiStructItemCustomView(this, "Unk 525", "Unk_525"),
                    new MultiStructItemCustomView(this, "Unk 526", "Unk_526"),
                    new MultiStructItemCustomView(this, "Unk 527", "Unk_527"),
                    new MultiStructItemCustomView(this, "Unk 528", "Unk_528"),
                    new MultiStructItemCustomView(this, "Unk 529", "Unk_529"),
                    new MultiStructItemCustomView(this, "Unk 530", "Unk_530"),
                    new MultiStructItemCustomView(this, "Unk 531", "Unk_531"),
                    new MultiStructItemCustomView(this, "Unk 532", "Unk_532"),
                };
            }
        }

        public override void LoadFile(string targetFile) {
            using var reader = new BinaryReader(OpenFile(targetFile, EncryptionKey), Encoding.UTF8);
            data = new LinkedList<MhwStructDataContainer>();
            var Monster_Common_Params_1__ = new MhwStructDataContainer<Monster_Common_Params_1_>(Monster_Common_Params_1_.LoadData(reader), typeof(Monster_Common_Params_1_));
            data.AddLast(Monster_Common_Params_1__);
            var Sharpness_Multipliers_ = new MhwStructDataContainer<Sharpness_Multipliers>(Sharpness_Multipliers.LoadData(reader), typeof(Sharpness_Multipliers));
            data.AddLast(Sharpness_Multipliers_);
            var Monster_Common_Params_2__ = new MhwStructDataContainer<Monster_Common_Params_2_>(Monster_Common_Params_2_.LoadData(reader), typeof(Monster_Common_Params_2_));
            data.AddLast(Monster_Common_Params_2__);
            var Sharpness_HZV_Threshold_ = new MhwStructDataContainer<Sharpness_HZV_Threshold>(Sharpness_HZV_Threshold.LoadData(reader), typeof(Sharpness_HZV_Threshold));
            data.AddLast(Sharpness_HZV_Threshold_);
            var Monster_Common_Params_3__ = new MhwStructDataContainer<Monster_Common_Params_3_>(Monster_Common_Params_3_.LoadData(reader), typeof(Monster_Common_Params_3_));
            data.AddLast(Monster_Common_Params_3__);
            var Unk_Arr_1_ = new MhwStructDataContainer<Unk_Arr_1>(Unk_Arr_1.LoadData(reader), typeof(Unk_Arr_1));
            data.AddLast(Unk_Arr_1_);
            var Monster_Common_Params_4__ = new MhwStructDataContainer<Monster_Common_Params_4_>(Monster_Common_Params_4_.LoadData(reader), typeof(Monster_Common_Params_4_));
            data.AddLast(Monster_Common_Params_4__);
            var Monster_Common_Params_5__ = new MhwStructDataContainer<Monster_Common_Params_5_>(Monster_Common_Params_5_.LoadData(reader), typeof(Monster_Common_Params_5_));
            data.AddLast(Monster_Common_Params_5__);
            var Unk_Arr_2_ = new MhwStructDataContainer<Unk_Arr_2>(Unk_Arr_2.LoadData(reader), typeof(Unk_Arr_2));
            data.AddLast(Unk_Arr_2_);
            var Monster_Common_Params_6__ = new MhwStructDataContainer<Monster_Common_Params_6_>(Monster_Common_Params_6_.LoadData(reader), typeof(Monster_Common_Params_6_));
            data.AddLast(Monster_Common_Params_6__);
            var Unk_Arr_3_ = new MhwStructDataContainer<Unk_Arr_3>(Unk_Arr_3.LoadData(reader), typeof(Unk_Arr_3));
            data.AddLast(Unk_Arr_3_);
            var Monster_Common_Params_7__ = new MhwStructDataContainer<Monster_Common_Params_7_>(Monster_Common_Params_7_.LoadData(reader), typeof(Monster_Common_Params_7_));
            data.AddLast(Monster_Common_Params_7__);
            var Unk_Arr_4_ = new MhwStructDataContainer<Unk_Arr_4, Monster_Common_Params_7_>(Unk_Arr_4.LoadData(reader, Monster_Common_Params_7__.list), typeof(Unk_Arr_4));
            Unk_Arr_4_.SetCountTargetToUpdate(Monster_Common_Params_7__, -1, "Unk_Arr_4_Count");
            data.AddLast(Unk_Arr_4_);
            var Monster_Common_Params_8__ = new MhwStructDataContainer<Monster_Common_Params_8_>(Monster_Common_Params_8_.LoadData(reader), typeof(Monster_Common_Params_8_));
            data.AddLast(Monster_Common_Params_8__);
            var Monster_Common_Params_9__ = new MhwStructDataContainer<Monster_Common_Params_9_>(Monster_Common_Params_9_.LoadData(reader), typeof(Monster_Common_Params_9_));
            data.AddLast(Monster_Common_Params_9__);
            var Monster_Common_Params_10__ = new MhwStructDataContainer<Monster_Common_Params_10_>(Monster_Common_Params_10_.LoadData(reader), typeof(Monster_Common_Params_10_));
            data.AddLast(Monster_Common_Params_10__);
            var Monster_Common_Params_11__ = new MhwStructDataContainer<Monster_Common_Params_11_>(Monster_Common_Params_11_.LoadData(reader), typeof(Monster_Common_Params_11_));
            data.AddLast(Monster_Common_Params_11__);
            var Unk_Arr_5_ = new MhwStructDataContainer<Unk_Arr_5, Monster_Common_Params_11_>(Unk_Arr_5.LoadData(reader, Monster_Common_Params_11__.list), typeof(Unk_Arr_5));
            Unk_Arr_5_.SetCountTargetToUpdate(Monster_Common_Params_11__, -1, "Unk_Arr_5_Count");
            data.AddLast(Unk_Arr_5_);
            var Monster_Common_Params_12__ = new MhwStructDataContainer<Monster_Common_Params_12_>(Monster_Common_Params_12_.LoadData(reader), typeof(Monster_Common_Params_12_));
            data.AddLast(Monster_Common_Params_12__);
            var Unk_Arr_6_ = new MhwStructDataContainer<Unk_Arr_6, Monster_Common_Params_12_>(Unk_Arr_6.LoadData(reader, Monster_Common_Params_12__.list), typeof(Unk_Arr_6));
            Unk_Arr_6_.SetCountTargetToUpdate(Monster_Common_Params_12__, -1, "Unk_Arr_6_Count");
            data.AddLast(Unk_Arr_6_);
            var Monster_Common_Params_13__ = new MhwStructDataContainer<Monster_Common_Params_13_>(Monster_Common_Params_13_.LoadData(reader), typeof(Monster_Common_Params_13_));
            data.AddLast(Monster_Common_Params_13__);
        }
    }
}
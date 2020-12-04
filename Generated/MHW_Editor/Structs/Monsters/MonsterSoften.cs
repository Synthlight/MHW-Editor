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
    public partial class MonsterSoften {
        public override string EncryptionKey => null;

        public partial class Soften_Params : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Soften Params";

            protected uint Magic_raw;
            public const string Magic_displayName = "Magic";
            public const int Magic_sortIndex = 50;
            [SortOrder(Magic_sortIndex)]
            [DisplayName(Magic_displayName)]
            [IsReadOnly]
            public virtual uint Magic {
                get => Magic_raw;
                set {
                    if (Magic_raw == value) return;
                    Magic_raw = value;
                    ChangedItems.Add(nameof(Magic));
                    OnPropertyChanged(nameof(Magic));
                }
            }

            [DisplayName("Offset")]
            public long Magic_offset { get; private set; }

            protected uint Unk_1_raw;
            public const string Unk_1_displayName = "Unk 1";
            public const int Unk_1_sortIndex = 100;
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

            [DisplayName("Offset")]
            public long Unk_1_offset { get; private set; }

            protected uint Unk_2_raw;
            public const string Unk_2_displayName = "Unk 2";
            public const int Unk_2_sortIndex = 150;
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

            [DisplayName("Offset")]
            public long Unk_2_offset { get; private set; }

            protected uint Tender_Duration_raw;
            public const string Tender_Duration_displayName = "Tender Duration";
            public const int Tender_Duration_sortIndex = 200;
            [SortOrder(Tender_Duration_sortIndex)]
            [DisplayName(Tender_Duration_displayName)]
            public virtual uint Tender_Duration {
                get => Tender_Duration_raw;
                set {
                    if (Tender_Duration_raw == value) return;
                    Tender_Duration_raw = value;
                    ChangedItems.Add(nameof(Tender_Duration));
                    OnPropertyChanged(nameof(Tender_Duration));
                }
            }

            [DisplayName("Offset")]
            public long Tender_Duration_offset { get; private set; }

            protected uint Unk_3_raw;
            public const string Unk_3_displayName = "Unk 3";
            public const int Unk_3_sortIndex = 250;
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

            [DisplayName("Offset")]
            public long Unk_3_offset { get; private set; }

            protected uint Unk_4_raw;
            public const string Unk_4_displayName = "Unk 4";
            public const int Unk_4_sortIndex = 300;
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

            [DisplayName("Offset")]
            public long Unk_4_offset { get; private set; }

            protected uint Unk_5_raw;
            public const string Unk_5_displayName = "Unk 5";
            public const int Unk_5_sortIndex = 350;
            [SortOrder(Unk_5_sortIndex)]
            [DisplayName(Unk_5_displayName)]
            public virtual uint Unk_5 {
                get => Unk_5_raw;
                set {
                    if (Unk_5_raw == value) return;
                    Unk_5_raw = value;
                    ChangedItems.Add(nameof(Unk_5));
                    OnPropertyChanged(nameof(Unk_5));
                }
            }

            [DisplayName("Offset")]
            public long Unk_5_offset { get; private set; }

            protected uint Unk_6_raw;
            public const string Unk_6_displayName = "Unk 6";
            public const int Unk_6_sortIndex = 400;
            [SortOrder(Unk_6_sortIndex)]
            [DisplayName(Unk_6_displayName)]
            public virtual uint Unk_6 {
                get => Unk_6_raw;
                set {
                    if (Unk_6_raw == value) return;
                    Unk_6_raw = value;
                    ChangedItems.Add(nameof(Unk_6));
                    OnPropertyChanged(nameof(Unk_6));
                }
            }

            [DisplayName("Offset")]
            public long Unk_6_offset { get; private set; }

            protected uint Unk_7_raw;
            public const string Unk_7_displayName = "Unk 7";
            public const int Unk_7_sortIndex = 450;
            [SortOrder(Unk_7_sortIndex)]
            [DisplayName(Unk_7_displayName)]
            public virtual uint Unk_7 {
                get => Unk_7_raw;
                set {
                    if (Unk_7_raw == value) return;
                    Unk_7_raw = value;
                    ChangedItems.Add(nameof(Unk_7));
                    OnPropertyChanged(nameof(Unk_7));
                }
            }

            [DisplayName("Offset")]
            public long Unk_7_offset { get; private set; }

            protected uint Unk_8_raw;
            public const string Unk_8_displayName = "Unk 8";
            public const int Unk_8_sortIndex = 500;
            [SortOrder(Unk_8_sortIndex)]
            [DisplayName(Unk_8_displayName)]
            public virtual uint Unk_8 {
                get => Unk_8_raw;
                set {
                    if (Unk_8_raw == value) return;
                    Unk_8_raw = value;
                    ChangedItems.Add(nameof(Unk_8));
                    OnPropertyChanged(nameof(Unk_8));
                }
            }

            [DisplayName("Offset")]
            public long Unk_8_offset { get; private set; }

            protected uint Unk_9_raw;
            public const string Unk_9_displayName = "Unk 9";
            public const int Unk_9_sortIndex = 550;
            [SortOrder(Unk_9_sortIndex)]
            [DisplayName(Unk_9_displayName)]
            public virtual uint Unk_9 {
                get => Unk_9_raw;
                set {
                    if (Unk_9_raw == value) return;
                    Unk_9_raw = value;
                    ChangedItems.Add(nameof(Unk_9));
                    OnPropertyChanged(nameof(Unk_9));
                }
            }

            [DisplayName("Offset")]
            public long Unk_9_offset { get; private set; }

            protected uint Unk_10_raw;
            public const string Unk_10_displayName = "Unk 10";
            public const int Unk_10_sortIndex = 600;
            [SortOrder(Unk_10_sortIndex)]
            [DisplayName(Unk_10_displayName)]
            public virtual uint Unk_10 {
                get => Unk_10_raw;
                set {
                    if (Unk_10_raw == value) return;
                    Unk_10_raw = value;
                    ChangedItems.Add(nameof(Unk_10));
                    OnPropertyChanged(nameof(Unk_10));
                }
            }

            [DisplayName("Offset")]
            public long Unk_10_offset { get; private set; }

            protected uint Unk_11_raw;
            public const string Unk_11_displayName = "Unk 11";
            public const int Unk_11_sortIndex = 650;
            [SortOrder(Unk_11_sortIndex)]
            [DisplayName(Unk_11_displayName)]
            public virtual uint Unk_11 {
                get => Unk_11_raw;
                set {
                    if (Unk_11_raw == value) return;
                    Unk_11_raw = value;
                    ChangedItems.Add(nameof(Unk_11));
                    OnPropertyChanged(nameof(Unk_11));
                }
            }

            [DisplayName("Offset")]
            public long Unk_11_offset { get; private set; }

            protected uint Unk_12_raw;
            public const string Unk_12_displayName = "Unk 12";
            public const int Unk_12_sortIndex = 700;
            [SortOrder(Unk_12_sortIndex)]
            [DisplayName(Unk_12_displayName)]
            public virtual uint Unk_12 {
                get => Unk_12_raw;
                set {
                    if (Unk_12_raw == value) return;
                    Unk_12_raw = value;
                    ChangedItems.Add(nameof(Unk_12));
                    OnPropertyChanged(nameof(Unk_12));
                }
            }

            [DisplayName("Offset")]
            public long Unk_12_offset { get; private set; }

            protected uint Unk_13_raw;
            public const string Unk_13_displayName = "Unk 13";
            public const int Unk_13_sortIndex = 750;
            [SortOrder(Unk_13_sortIndex)]
            [DisplayName(Unk_13_displayName)]
            public virtual uint Unk_13 {
                get => Unk_13_raw;
                set {
                    if (Unk_13_raw == value) return;
                    Unk_13_raw = value;
                    ChangedItems.Add(nameof(Unk_13));
                    OnPropertyChanged(nameof(Unk_13));
                }
            }

            [DisplayName("Offset")]
            public long Unk_13_offset { get; private set; }

            protected uint Unk_14_raw;
            public const string Unk_14_displayName = "Unk 14";
            public const int Unk_14_sortIndex = 800;
            [SortOrder(Unk_14_sortIndex)]
            [DisplayName(Unk_14_displayName)]
            public virtual uint Unk_14 {
                get => Unk_14_raw;
                set {
                    if (Unk_14_raw == value) return;
                    Unk_14_raw = value;
                    ChangedItems.Add(nameof(Unk_14));
                    OnPropertyChanged(nameof(Unk_14));
                }
            }

            [DisplayName("Offset")]
            public long Unk_14_offset { get; private set; }

            protected uint Unk_15_raw;
            public const string Unk_15_displayName = "Unk 15";
            public const int Unk_15_sortIndex = 850;
            [SortOrder(Unk_15_sortIndex)]
            [DisplayName(Unk_15_displayName)]
            public virtual uint Unk_15 {
                get => Unk_15_raw;
                set {
                    if (Unk_15_raw == value) return;
                    Unk_15_raw = value;
                    ChangedItems.Add(nameof(Unk_15));
                    OnPropertyChanged(nameof(Unk_15));
                }
            }

            [DisplayName("Offset")]
            public long Unk_15_offset { get; private set; }

            protected uint Unk_16_raw;
            public const string Unk_16_displayName = "Unk 16";
            public const int Unk_16_sortIndex = 900;
            [SortOrder(Unk_16_sortIndex)]
            [DisplayName(Unk_16_displayName)]
            public virtual uint Unk_16 {
                get => Unk_16_raw;
                set {
                    if (Unk_16_raw == value) return;
                    Unk_16_raw = value;
                    ChangedItems.Add(nameof(Unk_16));
                    OnPropertyChanged(nameof(Unk_16));
                }
            }

            [DisplayName("Offset")]
            public long Unk_16_offset { get; private set; }

            protected uint Unk_17_raw;
            public const string Unk_17_displayName = "Unk 17";
            public const int Unk_17_sortIndex = 950;
            [SortOrder(Unk_17_sortIndex)]
            [DisplayName(Unk_17_displayName)]
            public virtual uint Unk_17 {
                get => Unk_17_raw;
                set {
                    if (Unk_17_raw == value) return;
                    Unk_17_raw = value;
                    ChangedItems.Add(nameof(Unk_17));
                    OnPropertyChanged(nameof(Unk_17));
                }
            }

            [DisplayName("Offset")]
            public long Unk_17_offset { get; private set; }

            protected uint Unk_18_raw;
            public const string Unk_18_displayName = "Unk 18";
            public const int Unk_18_sortIndex = 1000;
            [SortOrder(Unk_18_sortIndex)]
            [DisplayName(Unk_18_displayName)]
            public virtual uint Unk_18 {
                get => Unk_18_raw;
                set {
                    if (Unk_18_raw == value) return;
                    Unk_18_raw = value;
                    ChangedItems.Add(nameof(Unk_18));
                    OnPropertyChanged(nameof(Unk_18));
                }
            }

            [DisplayName("Offset")]
            public long Unk_18_offset { get; private set; }

            protected uint Unk_19_raw;
            public const string Unk_19_displayName = "Unk 19";
            public const int Unk_19_sortIndex = 1050;
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

            [DisplayName("Offset")]
            public long Unk_19_offset { get; private set; }

            protected uint Unk_20_raw;
            public const string Unk_20_displayName = "Unk 20";
            public const int Unk_20_sortIndex = 1100;
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

            [DisplayName("Offset")]
            public long Unk_20_offset { get; private set; }

            protected uint Unk_21_raw;
            public const string Unk_21_displayName = "Unk 21";
            public const int Unk_21_sortIndex = 1150;
            [SortOrder(Unk_21_sortIndex)]
            [DisplayName(Unk_21_displayName)]
            public virtual uint Unk_21 {
                get => Unk_21_raw;
                set {
                    if (Unk_21_raw == value) return;
                    Unk_21_raw = value;
                    ChangedItems.Add(nameof(Unk_21));
                    OnPropertyChanged(nameof(Unk_21));
                }
            }

            [DisplayName("Offset")]
            public long Unk_21_offset { get; private set; }

            protected int Unk_22_raw;
            public const string Unk_22_displayName = "Unk 22";
            public const int Unk_22_sortIndex = 1200;
            [SortOrder(Unk_22_sortIndex)]
            [DisplayName(Unk_22_displayName)]
            public virtual int Unk_22 {
                get => Unk_22_raw;
                set {
                    if (Unk_22_raw == value) return;
                    Unk_22_raw = value;
                    ChangedItems.Add(nameof(Unk_22));
                    OnPropertyChanged(nameof(Unk_22));
                }
            }

            [DisplayName("Offset")]
            public long Unk_22_offset { get; private set; }

            protected uint Unk_23_raw;
            public const string Unk_23_displayName = "Unk 23";
            public const int Unk_23_sortIndex = 1250;
            [SortOrder(Unk_23_sortIndex)]
            [DisplayName(Unk_23_displayName)]
            public virtual uint Unk_23 {
                get => Unk_23_raw;
                set {
                    if (Unk_23_raw == value) return;
                    Unk_23_raw = value;
                    ChangedItems.Add(nameof(Unk_23));
                    OnPropertyChanged(nameof(Unk_23));
                }
            }

            [DisplayName("Offset")]
            public long Unk_23_offset { get; private set; }

            protected uint Tender_Duration_Fatalis__raw;
            public const string Tender_Duration_Fatalis__displayName = "Tender Duration (Fatalis)";
            public const int Tender_Duration_Fatalis__sortIndex = 1300;
            [SortOrder(Tender_Duration_Fatalis__sortIndex)]
            [DisplayName(Tender_Duration_Fatalis__displayName)]
            public virtual uint Tender_Duration_Fatalis_ {
                get => Tender_Duration_Fatalis__raw;
                set {
                    if (Tender_Duration_Fatalis__raw == value) return;
                    Tender_Duration_Fatalis__raw = value;
                    ChangedItems.Add(nameof(Tender_Duration_Fatalis_));
                    OnPropertyChanged(nameof(Tender_Duration_Fatalis_));
                }
            }

            [DisplayName("Offset")]
            public long Tender_Duration_Fatalis__offset { get; private set; }

            protected int Unk_24_raw;
            public const string Unk_24_displayName = "Unk 24";
            public const int Unk_24_sortIndex = 1350;
            [SortOrder(Unk_24_sortIndex)]
            [DisplayName(Unk_24_displayName)]
            public virtual int Unk_24 {
                get => Unk_24_raw;
                set {
                    if (Unk_24_raw == value) return;
                    Unk_24_raw = value;
                    ChangedItems.Add(nameof(Unk_24));
                    OnPropertyChanged(nameof(Unk_24));
                }
            }

            [DisplayName("Offset")]
            public long Unk_24_offset { get; private set; }

            protected uint Unk_25_raw;
            public const string Unk_25_displayName = "Unk 25";
            public const int Unk_25_sortIndex = 1400;
            [SortOrder(Unk_25_sortIndex)]
            [DisplayName(Unk_25_displayName)]
            public virtual uint Unk_25 {
                get => Unk_25_raw;
                set {
                    if (Unk_25_raw == value) return;
                    Unk_25_raw = value;
                    ChangedItems.Add(nameof(Unk_25));
                    OnPropertyChanged(nameof(Unk_25));
                }
            }

            [DisplayName("Offset")]
            public long Unk_25_offset { get; private set; }

            protected uint Claw_Max_Swings_To_Tenderize_Claw_goes_up_in_increments_of_20_per_swing_5_swings_100_tenderize__raw;
            public const string Claw_Max_Swings_To_Tenderize_Claw_goes_up_in_increments_of_20_per_swing_5_swings_100_tenderize__displayName = "Claw: Max Swings To Tenderize (Claw goes up in increments of 20 per swing, 5 swings = 100 = tenderize)";
            public const int Claw_Max_Swings_To_Tenderize_Claw_goes_up_in_increments_of_20_per_swing_5_swings_100_tenderize__sortIndex = 1450;
            [SortOrder(Claw_Max_Swings_To_Tenderize_Claw_goes_up_in_increments_of_20_per_swing_5_swings_100_tenderize__sortIndex)]
            [DisplayName(Claw_Max_Swings_To_Tenderize_Claw_goes_up_in_increments_of_20_per_swing_5_swings_100_tenderize__displayName)]
            public virtual uint Claw_Max_Swings_To_Tenderize_Claw_goes_up_in_increments_of_20_per_swing_5_swings_100_tenderize_ {
                get => Claw_Max_Swings_To_Tenderize_Claw_goes_up_in_increments_of_20_per_swing_5_swings_100_tenderize__raw;
                set {
                    if (Claw_Max_Swings_To_Tenderize_Claw_goes_up_in_increments_of_20_per_swing_5_swings_100_tenderize__raw == value) return;
                    Claw_Max_Swings_To_Tenderize_Claw_goes_up_in_increments_of_20_per_swing_5_swings_100_tenderize__raw = value;
                    ChangedItems.Add(nameof(Claw_Max_Swings_To_Tenderize_Claw_goes_up_in_increments_of_20_per_swing_5_swings_100_tenderize_));
                    OnPropertyChanged(nameof(Claw_Max_Swings_To_Tenderize_Claw_goes_up_in_increments_of_20_per_swing_5_swings_100_tenderize_));
                }
            }

            [DisplayName("Offset")]
            public long Claw_Max_Swings_To_Tenderize_Claw_goes_up_in_increments_of_20_per_swing_5_swings_100_tenderize__offset { get; private set; }

            protected uint Unk_26_raw;
            public const string Unk_26_displayName = "Unk 26";
            public const int Unk_26_sortIndex = 1500;
            [SortOrder(Unk_26_sortIndex)]
            [DisplayName(Unk_26_displayName)]
            public virtual uint Unk_26 {
                get => Unk_26_raw;
                set {
                    if (Unk_26_raw == value) return;
                    Unk_26_raw = value;
                    ChangedItems.Add(nameof(Unk_26));
                    OnPropertyChanged(nameof(Unk_26));
                }
            }

            [DisplayName("Offset")]
            public long Unk_26_offset { get; private set; }

            protected uint Unk_27_raw;
            public const string Unk_27_displayName = "Unk 27";
            public const int Unk_27_sortIndex = 1550;
            [SortOrder(Unk_27_sortIndex)]
            [DisplayName(Unk_27_displayName)]
            public virtual uint Unk_27 {
                get => Unk_27_raw;
                set {
                    if (Unk_27_raw == value) return;
                    Unk_27_raw = value;
                    ChangedItems.Add(nameof(Unk_27));
                    OnPropertyChanged(nameof(Unk_27));
                }
            }

            [DisplayName("Offset")]
            public long Unk_27_offset { get; private set; }

            protected uint Unk_28_raw;
            public const string Unk_28_displayName = "Unk 28";
            public const int Unk_28_sortIndex = 1600;
            [SortOrder(Unk_28_sortIndex)]
            [DisplayName(Unk_28_displayName)]
            public virtual uint Unk_28 {
                get => Unk_28_raw;
                set {
                    if (Unk_28_raw == value) return;
                    Unk_28_raw = value;
                    ChangedItems.Add(nameof(Unk_28));
                    OnPropertyChanged(nameof(Unk_28));
                }
            }

            [DisplayName("Offset")]
            public long Unk_28_offset { get; private set; }

            protected float Unk_29_raw;
            public const string Unk_29_displayName = "Unk 29";
            public const int Unk_29_sortIndex = 1650;
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

            [DisplayName("Offset")]
            public long Unk_29_offset { get; private set; }

            public const int lastSortIndex = 1700;

            public static ObservableMhwStructCollection<Soften_Params> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Soften_Params>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Soften_Params LoadData(BinaryReader reader, ulong i) {
                var data = new Soften_Params();
                data.Index = i;
                data.Magic_offset = reader.BaseStream.Position;
                data.Magic_raw = reader.ReadUInt32();
                data.Unk_1_offset = reader.BaseStream.Position;
                data.Unk_1_raw = reader.ReadUInt32();
                data.Unk_2_offset = reader.BaseStream.Position;
                data.Unk_2_raw = reader.ReadUInt32();
                data.Tender_Duration_offset = reader.BaseStream.Position;
                data.Tender_Duration_raw = reader.ReadUInt32();
                data.Unk_3_offset = reader.BaseStream.Position;
                data.Unk_3_raw = reader.ReadUInt32();
                data.Unk_4_offset = reader.BaseStream.Position;
                data.Unk_4_raw = reader.ReadUInt32();
                data.Unk_5_offset = reader.BaseStream.Position;
                data.Unk_5_raw = reader.ReadUInt32();
                data.Unk_6_offset = reader.BaseStream.Position;
                data.Unk_6_raw = reader.ReadUInt32();
                data.Unk_7_offset = reader.BaseStream.Position;
                data.Unk_7_raw = reader.ReadUInt32();
                data.Unk_8_offset = reader.BaseStream.Position;
                data.Unk_8_raw = reader.ReadUInt32();
                data.Unk_9_offset = reader.BaseStream.Position;
                data.Unk_9_raw = reader.ReadUInt32();
                data.Unk_10_offset = reader.BaseStream.Position;
                data.Unk_10_raw = reader.ReadUInt32();
                data.Unk_11_offset = reader.BaseStream.Position;
                data.Unk_11_raw = reader.ReadUInt32();
                data.Unk_12_offset = reader.BaseStream.Position;
                data.Unk_12_raw = reader.ReadUInt32();
                data.Unk_13_offset = reader.BaseStream.Position;
                data.Unk_13_raw = reader.ReadUInt32();
                data.Unk_14_offset = reader.BaseStream.Position;
                data.Unk_14_raw = reader.ReadUInt32();
                data.Unk_15_offset = reader.BaseStream.Position;
                data.Unk_15_raw = reader.ReadUInt32();
                data.Unk_16_offset = reader.BaseStream.Position;
                data.Unk_16_raw = reader.ReadUInt32();
                data.Unk_17_offset = reader.BaseStream.Position;
                data.Unk_17_raw = reader.ReadUInt32();
                data.Unk_18_offset = reader.BaseStream.Position;
                data.Unk_18_raw = reader.ReadUInt32();
                data.Unk_19_offset = reader.BaseStream.Position;
                data.Unk_19_raw = reader.ReadUInt32();
                data.Unk_20_offset = reader.BaseStream.Position;
                data.Unk_20_raw = reader.ReadUInt32();
                data.Unk_21_offset = reader.BaseStream.Position;
                data.Unk_21_raw = reader.ReadUInt32();
                data.Unk_22_offset = reader.BaseStream.Position;
                data.Unk_22_raw = reader.ReadInt32();
                data.Unk_23_offset = reader.BaseStream.Position;
                data.Unk_23_raw = reader.ReadUInt32();
                data.Tender_Duration_Fatalis__offset = reader.BaseStream.Position;
                data.Tender_Duration_Fatalis__raw = reader.ReadUInt32();
                data.Unk_24_offset = reader.BaseStream.Position;
                data.Unk_24_raw = reader.ReadInt32();
                data.Unk_25_offset = reader.BaseStream.Position;
                data.Unk_25_raw = reader.ReadUInt32();
                data.Claw_Max_Swings_To_Tenderize_Claw_goes_up_in_increments_of_20_per_swing_5_swings_100_tenderize__offset = reader.BaseStream.Position;
                data.Claw_Max_Swings_To_Tenderize_Claw_goes_up_in_increments_of_20_per_swing_5_swings_100_tenderize__raw = reader.ReadUInt32();
                data.Unk_26_offset = reader.BaseStream.Position;
                data.Unk_26_raw = reader.ReadUInt32();
                data.Unk_27_offset = reader.BaseStream.Position;
                data.Unk_27_raw = reader.ReadUInt32();
                data.Unk_28_offset = reader.BaseStream.Position;
                data.Unk_28_raw = reader.ReadUInt32();
                data.Unk_29_offset = reader.BaseStream.Position;
                data.Unk_29_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Magic_raw);
                writer.Write(Unk_1_raw);
                writer.Write(Unk_2_raw);
                writer.Write(Tender_Duration_raw);
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
                writer.Write(Tender_Duration_Fatalis__raw);
                writer.Write(Unk_24_raw);
                writer.Write(Unk_25_raw);
                writer.Write(Claw_Max_Swings_To_Tenderize_Claw_goes_up_in_increments_of_20_per_swing_5_swings_100_tenderize__raw);
                writer.Write(Unk_26_raw);
                writer.Write(Unk_27_raw);
                writer.Write(Unk_28_raw);
                writer.Write(Unk_29_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Magic", "Magic", "Magic_offset"),
                    new MultiStructItemCustomView(this, "Unk 1", "Unk_1", "Unk_1_offset"),
                    new MultiStructItemCustomView(this, "Unk 2", "Unk_2", "Unk_2_offset"),
                    new MultiStructItemCustomView(this, "Tender Duration", "Tender_Duration", "Tender_Duration_offset"),
                    new MultiStructItemCustomView(this, "Unk 3", "Unk_3", "Unk_3_offset"),
                    new MultiStructItemCustomView(this, "Unk 4", "Unk_4", "Unk_4_offset"),
                    new MultiStructItemCustomView(this, "Unk 5", "Unk_5", "Unk_5_offset"),
                    new MultiStructItemCustomView(this, "Unk 6", "Unk_6", "Unk_6_offset"),
                    new MultiStructItemCustomView(this, "Unk 7", "Unk_7", "Unk_7_offset"),
                    new MultiStructItemCustomView(this, "Unk 8", "Unk_8", "Unk_8_offset"),
                    new MultiStructItemCustomView(this, "Unk 9", "Unk_9", "Unk_9_offset"),
                    new MultiStructItemCustomView(this, "Unk 10", "Unk_10", "Unk_10_offset"),
                    new MultiStructItemCustomView(this, "Unk 11", "Unk_11", "Unk_11_offset"),
                    new MultiStructItemCustomView(this, "Unk 12", "Unk_12", "Unk_12_offset"),
                    new MultiStructItemCustomView(this, "Unk 13", "Unk_13", "Unk_13_offset"),
                    new MultiStructItemCustomView(this, "Unk 14", "Unk_14", "Unk_14_offset"),
                    new MultiStructItemCustomView(this, "Unk 15", "Unk_15", "Unk_15_offset"),
                    new MultiStructItemCustomView(this, "Unk 16", "Unk_16", "Unk_16_offset"),
                    new MultiStructItemCustomView(this, "Unk 17", "Unk_17", "Unk_17_offset"),
                    new MultiStructItemCustomView(this, "Unk 18", "Unk_18", "Unk_18_offset"),
                    new MultiStructItemCustomView(this, "Unk 19", "Unk_19", "Unk_19_offset"),
                    new MultiStructItemCustomView(this, "Unk 20", "Unk_20", "Unk_20_offset"),
                    new MultiStructItemCustomView(this, "Unk 21", "Unk_21", "Unk_21_offset"),
                    new MultiStructItemCustomView(this, "Unk 22", "Unk_22", "Unk_22_offset"),
                    new MultiStructItemCustomView(this, "Unk 23", "Unk_23", "Unk_23_offset"),
                    new MultiStructItemCustomView(this, "Tender Duration (Fatalis)", "Tender_Duration_Fatalis_", "Tender_Duration_Fatalis__offset"),
                    new MultiStructItemCustomView(this, "Unk 24", "Unk_24", "Unk_24_offset"),
                    new MultiStructItemCustomView(this, "Unk 25", "Unk_25", "Unk_25_offset"),
                    new MultiStructItemCustomView(this, "Claw: Max Swings To Tenderize (Claw goes up in increments of 20 per swing, 5 swings = 100 = tenderize)", "Claw_Max_Swings_To_Tenderize_Claw_goes_up_in_increments_of_20_per_swing_5_swings_100_tenderize_", "Claw_Max_Swings_To_Tenderize_Claw_goes_up_in_increments_of_20_per_swing_5_swings_100_tenderize__offset"),
                    new MultiStructItemCustomView(this, "Unk 26", "Unk_26", "Unk_26_offset"),
                    new MultiStructItemCustomView(this, "Unk 27", "Unk_27", "Unk_27_offset"),
                    new MultiStructItemCustomView(this, "Unk 28", "Unk_28", "Unk_28_offset"),
                    new MultiStructItemCustomView(this, "Unk 29", "Unk_29", "Unk_29_offset"),
                };
            }
        }

        public override void LoadFile(string targetFile) {
            using var reader = new BinaryReader(OpenFile(targetFile, EncryptionKey), Encoding.UTF8);
            data = new LinkedList<MhwStructDataContainer>();
            var Soften_Params_ = new MhwStructDataContainer<Soften_Params>(Soften_Params.LoadData(reader), typeof(Soften_Params));
            data.AddLast(Soften_Params_);
        }
    }
}
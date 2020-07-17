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

namespace MHW_Editor.Structs.PlData {
    public partial class PlItemParam {
        public override string EncryptionKey => "j1P15gEkgVa7NdFxiqwCPitykHctY2nZPjSaElvqb0eSwcLO1cOlTqqv";

        public partial class Header : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Header";

            protected char[] PLI_raw;
            public const string PLI_displayName = "PLI";
            public const int PLI_sortIndex = 50;
            [SortOrder(PLI_sortIndex)]
            [DisplayName(PLI_displayName)]
            [IsReadOnly]
            public virtual string PLI {
                get => (string) new string(PLI_raw);
                set {
                    if ((string) new string(PLI_raw) == value) return;
                    PLI_raw = (char[]) value.ToCharArray(0, 3);
                    ChangedItems.Add(nameof(PLI));
                    OnPropertyChanged(nameof(PLI));
                }
            }

            protected uint Magic_1_raw;
            public const string Magic_1_displayName = "Magic 1";
            public const int Magic_1_sortIndex = 100;
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
                data.PLI_raw = reader.ReadChars(4);
                data.Magic_1_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(PLI_raw);
                writer.Write(Magic_1_raw);
            }
        }

        public partial class Item_Params_1_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Item Params (1)";

            protected float Powder_Radius_raw;
            public const string Powder_Radius_displayName = "Powder Radius";
            public const int Powder_Radius_sortIndex = 50;
            [SortOrder(Powder_Radius_sortIndex)]
            [DisplayName(Powder_Radius_displayName)]
            public virtual float Powder_Radius {
                get => Powder_Radius_raw;
                set {
                    if (Powder_Radius_raw == value) return;
                    Powder_Radius_raw = value;
                    ChangedItems.Add(nameof(Powder_Radius));
                    OnPropertyChanged(nameof(Powder_Radius));
                }
            }

            [DisplayName("Offset")]
            public long Powder_Radius_offset { get; private set; }

            protected uint Potion_Power_raw;
            public const string Potion_Power_displayName = "Potion Power";
            public const int Potion_Power_sortIndex = 100;
            [SortOrder(Potion_Power_sortIndex)]
            [DisplayName(Potion_Power_displayName)]
            public virtual uint Potion_Power {
                get => Potion_Power_raw;
                set {
                    if (Potion_Power_raw == value) return;
                    Potion_Power_raw = value;
                    ChangedItems.Add(nameof(Potion_Power));
                    OnPropertyChanged(nameof(Potion_Power));
                }
            }

            [DisplayName("Offset")]
            public long Potion_Power_offset { get; private set; }

            protected float Unk2_raw;
            public const string Unk2_displayName = "Unk2";
            public const int Unk2_sortIndex = 150;
            [SortOrder(Unk2_sortIndex)]
            [DisplayName(Unk2_displayName)]
            public virtual float Unk2 {
                get => Unk2_raw;
                set {
                    if (Unk2_raw == value) return;
                    Unk2_raw = value;
                    ChangedItems.Add(nameof(Unk2));
                    OnPropertyChanged(nameof(Unk2));
                }
            }

            [DisplayName("Offset")]
            public long Unk2_offset { get; private set; }

            protected float Unk3_raw;
            public const string Unk3_displayName = "Unk3";
            public const int Unk3_sortIndex = 200;
            [SortOrder(Unk3_sortIndex)]
            [DisplayName(Unk3_displayName)]
            public virtual float Unk3 {
                get => Unk3_raw;
                set {
                    if (Unk3_raw == value) return;
                    Unk3_raw = value;
                    ChangedItems.Add(nameof(Unk3));
                    OnPropertyChanged(nameof(Unk3));
                }
            }

            [DisplayName("Offset")]
            public long Unk3_offset { get; private set; }

            protected float Unk4_raw;
            public const string Unk4_displayName = "Unk4";
            public const int Unk4_sortIndex = 250;
            [SortOrder(Unk4_sortIndex)]
            [DisplayName(Unk4_displayName)]
            public virtual float Unk4 {
                get => Unk4_raw;
                set {
                    if (Unk4_raw == value) return;
                    Unk4_raw = value;
                    ChangedItems.Add(nameof(Unk4));
                    OnPropertyChanged(nameof(Unk4));
                }
            }

            [DisplayName("Offset")]
            public long Unk4_offset { get; private set; }

            protected uint Mega_Potion_Power_raw;
            public const string Mega_Potion_Power_displayName = "Mega Potion Power";
            public const int Mega_Potion_Power_sortIndex = 300;
            [SortOrder(Mega_Potion_Power_sortIndex)]
            [DisplayName(Mega_Potion_Power_displayName)]
            public virtual uint Mega_Potion_Power {
                get => Mega_Potion_Power_raw;
                set {
                    if (Mega_Potion_Power_raw == value) return;
                    Mega_Potion_Power_raw = value;
                    ChangedItems.Add(nameof(Mega_Potion_Power));
                    OnPropertyChanged(nameof(Mega_Potion_Power));
                }
            }

            [DisplayName("Offset")]
            public long Mega_Potion_Power_offset { get; private set; }

            protected float Unk5_raw;
            public const string Unk5_displayName = "Unk5";
            public const int Unk5_sortIndex = 350;
            [SortOrder(Unk5_sortIndex)]
            [DisplayName(Unk5_displayName)]
            public virtual float Unk5 {
                get => Unk5_raw;
                set {
                    if (Unk5_raw == value) return;
                    Unk5_raw = value;
                    ChangedItems.Add(nameof(Unk5));
                    OnPropertyChanged(nameof(Unk5));
                }
            }

            [DisplayName("Offset")]
            public long Unk5_offset { get; private set; }

            protected float Unk6_raw;
            public const string Unk6_displayName = "Unk6";
            public const int Unk6_sortIndex = 400;
            [SortOrder(Unk6_sortIndex)]
            [DisplayName(Unk6_displayName)]
            public virtual float Unk6 {
                get => Unk6_raw;
                set {
                    if (Unk6_raw == value) return;
                    Unk6_raw = value;
                    ChangedItems.Add(nameof(Unk6));
                    OnPropertyChanged(nameof(Unk6));
                }
            }

            [DisplayName("Offset")]
            public long Unk6_offset { get; private set; }

            protected float Unk7_raw;
            public const string Unk7_displayName = "Unk7";
            public const int Unk7_sortIndex = 450;
            [SortOrder(Unk7_sortIndex)]
            [DisplayName(Unk7_displayName)]
            public virtual float Unk7 {
                get => Unk7_raw;
                set {
                    if (Unk7_raw == value) return;
                    Unk7_raw = value;
                    ChangedItems.Add(nameof(Unk7));
                    OnPropertyChanged(nameof(Unk7));
                }
            }

            [DisplayName("Offset")]
            public long Unk7_offset { get; private set; }

            protected byte Nutrients_Power_raw;
            public const string Nutrients_Power_displayName = "Nutrients Power";
            public const int Nutrients_Power_sortIndex = 500;
            [SortOrder(Nutrients_Power_sortIndex)]
            [DisplayName(Nutrients_Power_displayName)]
            public virtual byte Nutrients_Power {
                get => Nutrients_Power_raw;
                set {
                    if (Nutrients_Power_raw == value) return;
                    Nutrients_Power_raw = value;
                    ChangedItems.Add(nameof(Nutrients_Power));
                    OnPropertyChanged(nameof(Nutrients_Power));
                }
            }

            [DisplayName("Offset")]
            public long Nutrients_Power_offset { get; private set; }

            protected byte Mega_Nutrients_Power_raw;
            public const string Mega_Nutrients_Power_displayName = "Mega Nutrients Power";
            public const int Mega_Nutrients_Power_sortIndex = 550;
            [SortOrder(Mega_Nutrients_Power_sortIndex)]
            [DisplayName(Mega_Nutrients_Power_displayName)]
            public virtual byte Mega_Nutrients_Power {
                get => Mega_Nutrients_Power_raw;
                set {
                    if (Mega_Nutrients_Power_raw == value) return;
                    Mega_Nutrients_Power_raw = value;
                    ChangedItems.Add(nameof(Mega_Nutrients_Power));
                    OnPropertyChanged(nameof(Mega_Nutrients_Power));
                }
            }

            [DisplayName("Offset")]
            public long Mega_Nutrients_Power_offset { get; private set; }

            protected byte Unk9_raw;
            public const string Unk9_displayName = "Unk9";
            public const int Unk9_sortIndex = 600;
            [SortOrder(Unk9_sortIndex)]
            [DisplayName(Unk9_displayName)]
            public virtual byte Unk9 {
                get => Unk9_raw;
                set {
                    if (Unk9_raw == value) return;
                    Unk9_raw = value;
                    ChangedItems.Add(nameof(Unk9));
                    OnPropertyChanged(nameof(Unk9));
                }
            }

            [DisplayName("Offset")]
            public long Unk9_offset { get; private set; }

            protected float Mega_Dash_Juice_Stamina_Power_raw;
            public const string Mega_Dash_Juice_Stamina_Power_displayName = "Mega Dash Juice Stamina Power";
            public const int Mega_Dash_Juice_Stamina_Power_sortIndex = 650;
            [SortOrder(Mega_Dash_Juice_Stamina_Power_sortIndex)]
            [DisplayName(Mega_Dash_Juice_Stamina_Power_displayName)]
            public virtual float Mega_Dash_Juice_Stamina_Power {
                get => Mega_Dash_Juice_Stamina_Power_raw;
                set {
                    if (Mega_Dash_Juice_Stamina_Power_raw == value) return;
                    Mega_Dash_Juice_Stamina_Power_raw = value;
                    ChangedItems.Add(nameof(Mega_Dash_Juice_Stamina_Power));
                    OnPropertyChanged(nameof(Mega_Dash_Juice_Stamina_Power));
                }
            }

            [DisplayName("Offset")]
            public long Mega_Dash_Juice_Stamina_Power_offset { get; private set; }

            protected float Dash_Juice_Stamina_Power_raw;
            public const string Dash_Juice_Stamina_Power_displayName = "Dash Juice Stamina Power";
            public const int Dash_Juice_Stamina_Power_sortIndex = 700;
            [SortOrder(Dash_Juice_Stamina_Power_sortIndex)]
            [DisplayName(Dash_Juice_Stamina_Power_displayName)]
            public virtual float Dash_Juice_Stamina_Power {
                get => Dash_Juice_Stamina_Power_raw;
                set {
                    if (Dash_Juice_Stamina_Power_raw == value) return;
                    Dash_Juice_Stamina_Power_raw = value;
                    ChangedItems.Add(nameof(Dash_Juice_Stamina_Power));
                    OnPropertyChanged(nameof(Dash_Juice_Stamina_Power));
                }
            }

            [DisplayName("Offset")]
            public long Dash_Juice_Stamina_Power_offset { get; private set; }

            protected ushort Both_Dash_Juice_Duration_raw;
            public const string Both_Dash_Juice_Duration_displayName = "Both Dash Juice Duration";
            public const int Both_Dash_Juice_Duration_sortIndex = 750;
            [SortOrder(Both_Dash_Juice_Duration_sortIndex)]
            [DisplayName(Both_Dash_Juice_Duration_displayName)]
            public virtual ushort Both_Dash_Juice_Duration {
                get => Both_Dash_Juice_Duration_raw;
                set {
                    if (Both_Dash_Juice_Duration_raw == value) return;
                    Both_Dash_Juice_Duration_raw = value;
                    ChangedItems.Add(nameof(Both_Dash_Juice_Duration));
                    OnPropertyChanged(nameof(Both_Dash_Juice_Duration));
                }
            }

            [DisplayName("Offset")]
            public long Both_Dash_Juice_Duration_offset { get; private set; }

            protected byte Both_Dash_Juice_Power_raw;
            public const string Both_Dash_Juice_Power_displayName = "Both Dash Juice Power";
            public const int Both_Dash_Juice_Power_sortIndex = 800;
            [SortOrder(Both_Dash_Juice_Power_sortIndex)]
            [DisplayName(Both_Dash_Juice_Power_displayName)]
            public virtual byte Both_Dash_Juice_Power {
                get => Both_Dash_Juice_Power_raw;
                set {
                    if (Both_Dash_Juice_Power_raw == value) return;
                    Both_Dash_Juice_Power_raw = value;
                    ChangedItems.Add(nameof(Both_Dash_Juice_Power));
                    OnPropertyChanged(nameof(Both_Dash_Juice_Power));
                }
            }

            [DisplayName("Offset")]
            public long Both_Dash_Juice_Power_offset { get; private set; }

            protected float Immunizer_Power_raw;
            public const string Immunizer_Power_displayName = "Immunizer Power";
            public const int Immunizer_Power_sortIndex = 850;
            [SortOrder(Immunizer_Power_sortIndex)]
            [DisplayName(Immunizer_Power_displayName)]
            public virtual float Immunizer_Power {
                get => Immunizer_Power_raw;
                set {
                    if (Immunizer_Power_raw == value) return;
                    Immunizer_Power_raw = value;
                    ChangedItems.Add(nameof(Immunizer_Power));
                    OnPropertyChanged(nameof(Immunizer_Power));
                }
            }

            [DisplayName("Offset")]
            public long Immunizer_Power_offset { get; private set; }

            protected ushort Immunizer_Duration_raw;
            public const string Immunizer_Duration_displayName = "Immunizer Duration";
            public const int Immunizer_Duration_sortIndex = 900;
            [SortOrder(Immunizer_Duration_sortIndex)]
            [DisplayName(Immunizer_Duration_displayName)]
            public virtual ushort Immunizer_Duration {
                get => Immunizer_Duration_raw;
                set {
                    if (Immunizer_Duration_raw == value) return;
                    Immunizer_Duration_raw = value;
                    ChangedItems.Add(nameof(Immunizer_Duration));
                    OnPropertyChanged(nameof(Immunizer_Duration));
                }
            }

            [DisplayName("Offset")]
            public long Immunizer_Duration_offset { get; private set; }

            protected float Astera_Jerky_Power_raw;
            public const string Astera_Jerky_Power_displayName = "Astera Jerky Power";
            public const int Astera_Jerky_Power_sortIndex = 950;
            [SortOrder(Astera_Jerky_Power_sortIndex)]
            [DisplayName(Astera_Jerky_Power_displayName)]
            public virtual float Astera_Jerky_Power {
                get => Astera_Jerky_Power_raw;
                set {
                    if (Astera_Jerky_Power_raw == value) return;
                    Astera_Jerky_Power_raw = value;
                    ChangedItems.Add(nameof(Astera_Jerky_Power));
                    OnPropertyChanged(nameof(Astera_Jerky_Power));
                }
            }

            [DisplayName("Offset")]
            public long Astera_Jerky_Power_offset { get; private set; }

            protected ushort Astera_Jerky_Duration_raw;
            public const string Astera_Jerky_Duration_displayName = "Astera Jerky Duration";
            public const int Astera_Jerky_Duration_sortIndex = 1000;
            [SortOrder(Astera_Jerky_Duration_sortIndex)]
            [DisplayName(Astera_Jerky_Duration_displayName)]
            public virtual ushort Astera_Jerky_Duration {
                get => Astera_Jerky_Duration_raw;
                set {
                    if (Astera_Jerky_Duration_raw == value) return;
                    Astera_Jerky_Duration_raw = value;
                    ChangedItems.Add(nameof(Astera_Jerky_Duration));
                    OnPropertyChanged(nameof(Astera_Jerky_Duration));
                }
            }

            [DisplayName("Offset")]
            public long Astera_Jerky_Duration_offset { get; private set; }

            protected ushort Herbal_Medicine_Power_raw;
            public const string Herbal_Medicine_Power_displayName = "Herbal Medicine Power";
            public const int Herbal_Medicine_Power_sortIndex = 1050;
            [SortOrder(Herbal_Medicine_Power_sortIndex)]
            [DisplayName(Herbal_Medicine_Power_displayName)]
            public virtual ushort Herbal_Medicine_Power {
                get => Herbal_Medicine_Power_raw;
                set {
                    if (Herbal_Medicine_Power_raw == value) return;
                    Herbal_Medicine_Power_raw = value;
                    ChangedItems.Add(nameof(Herbal_Medicine_Power));
                    OnPropertyChanged(nameof(Herbal_Medicine_Power));
                }
            }

            [DisplayName("Offset")]
            public long Herbal_Medicine_Power_offset { get; private set; }

            protected uint Sushifish_Scale_Power_raw;
            public const string Sushifish_Scale_Power_displayName = "Sushifish Scale Power";
            public const int Sushifish_Scale_Power_sortIndex = 1100;
            [SortOrder(Sushifish_Scale_Power_sortIndex)]
            [DisplayName(Sushifish_Scale_Power_displayName)]
            public virtual uint Sushifish_Scale_Power {
                get => Sushifish_Scale_Power_raw;
                set {
                    if (Sushifish_Scale_Power_raw == value) return;
                    Sushifish_Scale_Power_raw = value;
                    ChangedItems.Add(nameof(Sushifish_Scale_Power));
                    OnPropertyChanged(nameof(Sushifish_Scale_Power));
                }
            }

            [DisplayName("Offset")]
            public long Sushifish_Scale_Power_offset { get; private set; }

            protected uint Great_Sushifish_Scale_Power_raw;
            public const string Great_Sushifish_Scale_Power_displayName = "Great Sushifish Scale Power";
            public const int Great_Sushifish_Scale_Power_sortIndex = 1150;
            [SortOrder(Great_Sushifish_Scale_Power_sortIndex)]
            [DisplayName(Great_Sushifish_Scale_Power_displayName)]
            public virtual uint Great_Sushifish_Scale_Power {
                get => Great_Sushifish_Scale_Power_raw;
                set {
                    if (Great_Sushifish_Scale_Power_raw == value) return;
                    Great_Sushifish_Scale_Power_raw = value;
                    ChangedItems.Add(nameof(Great_Sushifish_Scale_Power));
                    OnPropertyChanged(nameof(Great_Sushifish_Scale_Power));
                }
            }

            [DisplayName("Offset")]
            public long Great_Sushifish_Scale_Power_offset { get; private set; }

            protected float Great_Sushifish_Scale_Duration_raw;
            public const string Great_Sushifish_Scale_Duration_displayName = "Great Sushifish Scale Duration";
            public const int Great_Sushifish_Scale_Duration_sortIndex = 1200;
            [SortOrder(Great_Sushifish_Scale_Duration_sortIndex)]
            [DisplayName(Great_Sushifish_Scale_Duration_displayName)]
            public virtual float Great_Sushifish_Scale_Duration {
                get => Great_Sushifish_Scale_Duration_raw;
                set {
                    if (Great_Sushifish_Scale_Duration_raw == value) return;
                    Great_Sushifish_Scale_Duration_raw = value;
                    ChangedItems.Add(nameof(Great_Sushifish_Scale_Duration));
                    OnPropertyChanged(nameof(Great_Sushifish_Scale_Duration));
                }
            }

            [DisplayName("Offset")]
            public long Great_Sushifish_Scale_Duration_offset { get; private set; }

            protected ushort Cool_Drink_Duration_raw;
            public const string Cool_Drink_Duration_displayName = "Cool Drink Duration";
            public const int Cool_Drink_Duration_sortIndex = 1250;
            [SortOrder(Cool_Drink_Duration_sortIndex)]
            [DisplayName(Cool_Drink_Duration_displayName)]
            public virtual ushort Cool_Drink_Duration {
                get => Cool_Drink_Duration_raw;
                set {
                    if (Cool_Drink_Duration_raw == value) return;
                    Cool_Drink_Duration_raw = value;
                    ChangedItems.Add(nameof(Cool_Drink_Duration));
                    OnPropertyChanged(nameof(Cool_Drink_Duration));
                }
            }

            [DisplayName("Offset")]
            public long Cool_Drink_Duration_offset { get; private set; }

            protected ushort Hot_Drink_Duration_raw;
            public const string Hot_Drink_Duration_displayName = "Hot Drink Duration";
            public const int Hot_Drink_Duration_sortIndex = 1300;
            [SortOrder(Hot_Drink_Duration_sortIndex)]
            [DisplayName(Hot_Drink_Duration_displayName)]
            public virtual ushort Hot_Drink_Duration {
                get => Hot_Drink_Duration_raw;
                set {
                    if (Hot_Drink_Duration_raw == value) return;
                    Hot_Drink_Duration_raw = value;
                    ChangedItems.Add(nameof(Hot_Drink_Duration));
                    OnPropertyChanged(nameof(Hot_Drink_Duration));
                }
            }

            [DisplayName("Offset")]
            public long Hot_Drink_Duration_offset { get; private set; }

            protected ushort Might_Seed_Duration_raw;
            public const string Might_Seed_Duration_displayName = "Might Seed Duration";
            public const int Might_Seed_Duration_sortIndex = 1350;
            [SortOrder(Might_Seed_Duration_sortIndex)]
            [DisplayName(Might_Seed_Duration_displayName)]
            public virtual ushort Might_Seed_Duration {
                get => Might_Seed_Duration_raw;
                set {
                    if (Might_Seed_Duration_raw == value) return;
                    Might_Seed_Duration_raw = value;
                    ChangedItems.Add(nameof(Might_Seed_Duration));
                    OnPropertyChanged(nameof(Might_Seed_Duration));
                }
            }

            [DisplayName("Offset")]
            public long Might_Seed_Duration_offset { get; private set; }

            protected ushort Might_Seed_Power_raw;
            public const string Might_Seed_Power_displayName = "Might Seed Power";
            public const int Might_Seed_Power_sortIndex = 1400;
            [SortOrder(Might_Seed_Power_sortIndex)]
            [DisplayName(Might_Seed_Power_displayName)]
            public virtual ushort Might_Seed_Power {
                get => Might_Seed_Power_raw;
                set {
                    if (Might_Seed_Power_raw == value) return;
                    Might_Seed_Power_raw = value;
                    ChangedItems.Add(nameof(Might_Seed_Power));
                    OnPropertyChanged(nameof(Might_Seed_Power));
                }
            }

            [DisplayName("Offset")]
            public long Might_Seed_Power_offset { get; private set; }

            protected ushort Might_Pill_Duration_raw;
            public const string Might_Pill_Duration_displayName = "Might Pill Duration";
            public const int Might_Pill_Duration_sortIndex = 1450;
            [SortOrder(Might_Pill_Duration_sortIndex)]
            [DisplayName(Might_Pill_Duration_displayName)]
            public virtual ushort Might_Pill_Duration {
                get => Might_Pill_Duration_raw;
                set {
                    if (Might_Pill_Duration_raw == value) return;
                    Might_Pill_Duration_raw = value;
                    ChangedItems.Add(nameof(Might_Pill_Duration));
                    OnPropertyChanged(nameof(Might_Pill_Duration));
                }
            }

            [DisplayName("Offset")]
            public long Might_Pill_Duration_offset { get; private set; }

            protected ushort Might_Pill_Power_raw;
            public const string Might_Pill_Power_displayName = "Might Pill Power";
            public const int Might_Pill_Power_sortIndex = 1500;
            [SortOrder(Might_Pill_Power_sortIndex)]
            [DisplayName(Might_Pill_Power_displayName)]
            public virtual ushort Might_Pill_Power {
                get => Might_Pill_Power_raw;
                set {
                    if (Might_Pill_Power_raw == value) return;
                    Might_Pill_Power_raw = value;
                    ChangedItems.Add(nameof(Might_Pill_Power));
                    OnPropertyChanged(nameof(Might_Pill_Power));
                }
            }

            [DisplayName("Offset")]
            public long Might_Pill_Power_offset { get; private set; }

            protected ushort Adamant_Seed_Duration_raw;
            public const string Adamant_Seed_Duration_displayName = "Adamant Seed Duration";
            public const int Adamant_Seed_Duration_sortIndex = 1550;
            [SortOrder(Adamant_Seed_Duration_sortIndex)]
            [DisplayName(Adamant_Seed_Duration_displayName)]
            public virtual ushort Adamant_Seed_Duration {
                get => Adamant_Seed_Duration_raw;
                set {
                    if (Adamant_Seed_Duration_raw == value) return;
                    Adamant_Seed_Duration_raw = value;
                    ChangedItems.Add(nameof(Adamant_Seed_Duration));
                    OnPropertyChanged(nameof(Adamant_Seed_Duration));
                }
            }

            [DisplayName("Offset")]
            public long Adamant_Seed_Duration_offset { get; private set; }

            protected ushort Adamant_Seed_Power_raw;
            public const string Adamant_Seed_Power_displayName = "Adamant Seed Power";
            public const int Adamant_Seed_Power_sortIndex = 1600;
            [SortOrder(Adamant_Seed_Power_sortIndex)]
            [DisplayName(Adamant_Seed_Power_displayName)]
            public virtual ushort Adamant_Seed_Power {
                get => Adamant_Seed_Power_raw;
                set {
                    if (Adamant_Seed_Power_raw == value) return;
                    Adamant_Seed_Power_raw = value;
                    ChangedItems.Add(nameof(Adamant_Seed_Power));
                    OnPropertyChanged(nameof(Adamant_Seed_Power));
                }
            }

            [DisplayName("Offset")]
            public long Adamant_Seed_Power_offset { get; private set; }

            protected ushort Adamant_Pill_Duration_raw;
            public const string Adamant_Pill_Duration_displayName = "Adamant Pill Duration";
            public const int Adamant_Pill_Duration_sortIndex = 1650;
            [SortOrder(Adamant_Pill_Duration_sortIndex)]
            [DisplayName(Adamant_Pill_Duration_displayName)]
            public virtual ushort Adamant_Pill_Duration {
                get => Adamant_Pill_Duration_raw;
                set {
                    if (Adamant_Pill_Duration_raw == value) return;
                    Adamant_Pill_Duration_raw = value;
                    ChangedItems.Add(nameof(Adamant_Pill_Duration));
                    OnPropertyChanged(nameof(Adamant_Pill_Duration));
                }
            }

            [DisplayName("Offset")]
            public long Adamant_Pill_Duration_offset { get; private set; }

            protected float Adamant_Pill_Power_raw;
            public const string Adamant_Pill_Power_displayName = "Adamant Pill Power";
            public const int Adamant_Pill_Power_sortIndex = 1700;
            [SortOrder(Adamant_Pill_Power_sortIndex)]
            [DisplayName(Adamant_Pill_Power_displayName)]
            public virtual float Adamant_Pill_Power {
                get => Adamant_Pill_Power_raw;
                set {
                    if (Adamant_Pill_Power_raw == value) return;
                    Adamant_Pill_Power_raw = value;
                    ChangedItems.Add(nameof(Adamant_Pill_Power));
                    OnPropertyChanged(nameof(Adamant_Pill_Power));
                }
            }

            [DisplayName("Offset")]
            public long Adamant_Pill_Power_offset { get; private set; }

            protected byte Demondrug_Power_raw;
            public const string Demondrug_Power_displayName = "Demondrug Power";
            public const int Demondrug_Power_sortIndex = 1750;
            [SortOrder(Demondrug_Power_sortIndex)]
            [DisplayName(Demondrug_Power_displayName)]
            public virtual byte Demondrug_Power {
                get => Demondrug_Power_raw;
                set {
                    if (Demondrug_Power_raw == value) return;
                    Demondrug_Power_raw = value;
                    ChangedItems.Add(nameof(Demondrug_Power));
                    OnPropertyChanged(nameof(Demondrug_Power));
                }
            }

            [DisplayName("Offset")]
            public long Demondrug_Power_offset { get; private set; }

            protected byte Mega_Demondrug_Power_raw;
            public const string Mega_Demondrug_Power_displayName = "Mega Demondrug Power";
            public const int Mega_Demondrug_Power_sortIndex = 1800;
            [SortOrder(Mega_Demondrug_Power_sortIndex)]
            [DisplayName(Mega_Demondrug_Power_displayName)]
            public virtual byte Mega_Demondrug_Power {
                get => Mega_Demondrug_Power_raw;
                set {
                    if (Mega_Demondrug_Power_raw == value) return;
                    Mega_Demondrug_Power_raw = value;
                    ChangedItems.Add(nameof(Mega_Demondrug_Power));
                    OnPropertyChanged(nameof(Mega_Demondrug_Power));
                }
            }

            [DisplayName("Offset")]
            public long Mega_Demondrug_Power_offset { get; private set; }

            protected byte Armorskin_Power_raw;
            public const string Armorskin_Power_displayName = "Armorskin Power";
            public const int Armorskin_Power_sortIndex = 1850;
            [SortOrder(Armorskin_Power_sortIndex)]
            [DisplayName(Armorskin_Power_displayName)]
            public virtual byte Armorskin_Power {
                get => Armorskin_Power_raw;
                set {
                    if (Armorskin_Power_raw == value) return;
                    Armorskin_Power_raw = value;
                    ChangedItems.Add(nameof(Armorskin_Power));
                    OnPropertyChanged(nameof(Armorskin_Power));
                }
            }

            [DisplayName("Offset")]
            public long Armorskin_Power_offset { get; private set; }

            protected byte Mega_Armorskin_Power_raw;
            public const string Mega_Armorskin_Power_displayName = "Mega Armorskin Power";
            public const int Mega_Armorskin_Power_sortIndex = 1900;
            [SortOrder(Mega_Armorskin_Power_sortIndex)]
            [DisplayName(Mega_Armorskin_Power_displayName)]
            public virtual byte Mega_Armorskin_Power {
                get => Mega_Armorskin_Power_raw;
                set {
                    if (Mega_Armorskin_Power_raw == value) return;
                    Mega_Armorskin_Power_raw = value;
                    ChangedItems.Add(nameof(Mega_Armorskin_Power));
                    OnPropertyChanged(nameof(Mega_Armorskin_Power));
                }
            }

            [DisplayName("Offset")]
            public long Mega_Armorskin_Power_offset { get; private set; }

            protected ushort Unk16_raw;
            public const string Unk16_displayName = "Unk16";
            public const int Unk16_sortIndex = 1950;
            [SortOrder(Unk16_sortIndex)]
            [DisplayName(Unk16_displayName)]
            public virtual ushort Unk16 {
                get => Unk16_raw;
                set {
                    if (Unk16_raw == value) return;
                    Unk16_raw = value;
                    ChangedItems.Add(nameof(Unk16));
                    OnPropertyChanged(nameof(Unk16));
                }
            }

            [DisplayName("Offset")]
            public long Unk16_offset { get; private set; }

            protected ushort Lifepowder_Power_raw;
            public const string Lifepowder_Power_displayName = "Lifepowder Power";
            public const int Lifepowder_Power_sortIndex = 2000;
            [SortOrder(Lifepowder_Power_sortIndex)]
            [DisplayName(Lifepowder_Power_displayName)]
            public virtual ushort Lifepowder_Power {
                get => Lifepowder_Power_raw;
                set {
                    if (Lifepowder_Power_raw == value) return;
                    Lifepowder_Power_raw = value;
                    ChangedItems.Add(nameof(Lifepowder_Power));
                    OnPropertyChanged(nameof(Lifepowder_Power));
                }
            }

            [DisplayName("Offset")]
            public long Lifepowder_Power_offset { get; private set; }

            protected ushort Dust_of_Life_Power_raw;
            public const string Dust_of_Life_Power_displayName = "Dust of Life Power";
            public const int Dust_of_Life_Power_sortIndex = 2050;
            [SortOrder(Dust_of_Life_Power_sortIndex)]
            [DisplayName(Dust_of_Life_Power_displayName)]
            public virtual ushort Dust_of_Life_Power {
                get => Dust_of_Life_Power_raw;
                set {
                    if (Dust_of_Life_Power_raw == value) return;
                    Dust_of_Life_Power_raw = value;
                    ChangedItems.Add(nameof(Dust_of_Life_Power));
                    OnPropertyChanged(nameof(Dust_of_Life_Power));
                }
            }

            [DisplayName("Offset")]
            public long Dust_of_Life_Power_offset { get; private set; }

            protected ushort Herbal_Powder_Power_raw;
            public const string Herbal_Powder_Power_displayName = "Herbal Powder Power";
            public const int Herbal_Powder_Power_sortIndex = 2100;
            [SortOrder(Herbal_Powder_Power_sortIndex)]
            [DisplayName(Herbal_Powder_Power_displayName)]
            public virtual ushort Herbal_Powder_Power {
                get => Herbal_Powder_Power_raw;
                set {
                    if (Herbal_Powder_Power_raw == value) return;
                    Herbal_Powder_Power_raw = value;
                    ChangedItems.Add(nameof(Herbal_Powder_Power));
                    OnPropertyChanged(nameof(Herbal_Powder_Power));
                }
            }

            [DisplayName("Offset")]
            public long Herbal_Powder_Power_offset { get; private set; }

            protected ushort Demon_Powder_Power_raw;
            public const string Demon_Powder_Power_displayName = "Demon Powder Power";
            public const int Demon_Powder_Power_sortIndex = 2150;
            [SortOrder(Demon_Powder_Power_sortIndex)]
            [DisplayName(Demon_Powder_Power_displayName)]
            public virtual ushort Demon_Powder_Power {
                get => Demon_Powder_Power_raw;
                set {
                    if (Demon_Powder_Power_raw == value) return;
                    Demon_Powder_Power_raw = value;
                    ChangedItems.Add(nameof(Demon_Powder_Power));
                    OnPropertyChanged(nameof(Demon_Powder_Power));
                }
            }

            [DisplayName("Offset")]
            public long Demon_Powder_Power_offset { get; private set; }

            protected ushort Demon_Powder_Duration_raw;
            public const string Demon_Powder_Duration_displayName = "Demon Powder Duration";
            public const int Demon_Powder_Duration_sortIndex = 2200;
            [SortOrder(Demon_Powder_Duration_sortIndex)]
            [DisplayName(Demon_Powder_Duration_displayName)]
            public virtual ushort Demon_Powder_Duration {
                get => Demon_Powder_Duration_raw;
                set {
                    if (Demon_Powder_Duration_raw == value) return;
                    Demon_Powder_Duration_raw = value;
                    ChangedItems.Add(nameof(Demon_Powder_Duration));
                    OnPropertyChanged(nameof(Demon_Powder_Duration));
                }
            }

            [DisplayName("Offset")]
            public long Demon_Powder_Duration_offset { get; private set; }

            protected ushort Hardshell_Powder_Power_raw;
            public const string Hardshell_Powder_Power_displayName = "Hardshell Powder Power";
            public const int Hardshell_Powder_Power_sortIndex = 2250;
            [SortOrder(Hardshell_Powder_Power_sortIndex)]
            [DisplayName(Hardshell_Powder_Power_displayName)]
            public virtual ushort Hardshell_Powder_Power {
                get => Hardshell_Powder_Power_raw;
                set {
                    if (Hardshell_Powder_Power_raw == value) return;
                    Hardshell_Powder_Power_raw = value;
                    ChangedItems.Add(nameof(Hardshell_Powder_Power));
                    OnPropertyChanged(nameof(Hardshell_Powder_Power));
                }
            }

            [DisplayName("Offset")]
            public long Hardshell_Powder_Power_offset { get; private set; }

            protected ushort Hardshell_Powder_Duration_raw;
            public const string Hardshell_Powder_Duration_displayName = "Hardshell Powder Duration";
            public const int Hardshell_Powder_Duration_sortIndex = 2300;
            [SortOrder(Hardshell_Powder_Duration_sortIndex)]
            [DisplayName(Hardshell_Powder_Duration_displayName)]
            public virtual ushort Hardshell_Powder_Duration {
                get => Hardshell_Powder_Duration_raw;
                set {
                    if (Hardshell_Powder_Duration_raw == value) return;
                    Hardshell_Powder_Duration_raw = value;
                    ChangedItems.Add(nameof(Hardshell_Powder_Duration));
                    OnPropertyChanged(nameof(Hardshell_Powder_Duration));
                }
            }

            [DisplayName("Offset")]
            public long Hardshell_Powder_Duration_offset { get; private set; }

            protected ushort Demon_Ammo_Power_raw;
            public const string Demon_Ammo_Power_displayName = "Demon Ammo Power";
            public const int Demon_Ammo_Power_sortIndex = 2350;
            [SortOrder(Demon_Ammo_Power_sortIndex)]
            [DisplayName(Demon_Ammo_Power_displayName)]
            public virtual ushort Demon_Ammo_Power {
                get => Demon_Ammo_Power_raw;
                set {
                    if (Demon_Ammo_Power_raw == value) return;
                    Demon_Ammo_Power_raw = value;
                    ChangedItems.Add(nameof(Demon_Ammo_Power));
                    OnPropertyChanged(nameof(Demon_Ammo_Power));
                }
            }

            [DisplayName("Offset")]
            public long Demon_Ammo_Power_offset { get; private set; }

            protected ushort Demon_Ammo_Duration_raw;
            public const string Demon_Ammo_Duration_displayName = "Demon Ammo Duration";
            public const int Demon_Ammo_Duration_sortIndex = 2400;
            [SortOrder(Demon_Ammo_Duration_sortIndex)]
            [DisplayName(Demon_Ammo_Duration_displayName)]
            public virtual ushort Demon_Ammo_Duration {
                get => Demon_Ammo_Duration_raw;
                set {
                    if (Demon_Ammo_Duration_raw == value) return;
                    Demon_Ammo_Duration_raw = value;
                    ChangedItems.Add(nameof(Demon_Ammo_Duration));
                    OnPropertyChanged(nameof(Demon_Ammo_Duration));
                }
            }

            [DisplayName("Offset")]
            public long Demon_Ammo_Duration_offset { get; private set; }

            protected ushort Armor_Ammo_Power_raw;
            public const string Armor_Ammo_Power_displayName = "Armor Ammo Power";
            public const int Armor_Ammo_Power_sortIndex = 2450;
            [SortOrder(Armor_Ammo_Power_sortIndex)]
            [DisplayName(Armor_Ammo_Power_displayName)]
            public virtual ushort Armor_Ammo_Power {
                get => Armor_Ammo_Power_raw;
                set {
                    if (Armor_Ammo_Power_raw == value) return;
                    Armor_Ammo_Power_raw = value;
                    ChangedItems.Add(nameof(Armor_Ammo_Power));
                    OnPropertyChanged(nameof(Armor_Ammo_Power));
                }
            }

            [DisplayName("Offset")]
            public long Armor_Ammo_Power_offset { get; private set; }

            protected ushort Armor_Ammo_Duration_raw;
            public const string Armor_Ammo_Duration_displayName = "Armor Ammo Duration";
            public const int Armor_Ammo_Duration_sortIndex = 2500;
            [SortOrder(Armor_Ammo_Duration_sortIndex)]
            [DisplayName(Armor_Ammo_Duration_displayName)]
            public virtual ushort Armor_Ammo_Duration {
                get => Armor_Ammo_Duration_raw;
                set {
                    if (Armor_Ammo_Duration_raw == value) return;
                    Armor_Ammo_Duration_raw = value;
                    ChangedItems.Add(nameof(Armor_Ammo_Duration));
                    OnPropertyChanged(nameof(Armor_Ammo_Duration));
                }
            }

            [DisplayName("Offset")]
            public long Armor_Ammo_Duration_offset { get; private set; }

            protected ushort Ration_Power_raw;
            public const string Ration_Power_displayName = "Ration Power";
            public const int Ration_Power_sortIndex = 2550;
            [SortOrder(Ration_Power_sortIndex)]
            [DisplayName(Ration_Power_displayName)]
            public virtual ushort Ration_Power {
                get => Ration_Power_raw;
                set {
                    if (Ration_Power_raw == value) return;
                    Ration_Power_raw = value;
                    ChangedItems.Add(nameof(Ration_Power));
                    OnPropertyChanged(nameof(Ration_Power));
                }
            }

            [DisplayName("Offset")]
            public long Ration_Power_offset { get; private set; }

            protected uint Well_Done_Steak_Multiplier_raw;
            public const string Well_Done_Steak_Multiplier_displayName = "Well Done Steak Multiplier";
            public const int Well_Done_Steak_Multiplier_sortIndex = 2600;
            [SortOrder(Well_Done_Steak_Multiplier_sortIndex)]
            [DisplayName(Well_Done_Steak_Multiplier_displayName)]
            public virtual uint Well_Done_Steak_Multiplier {
                get => Well_Done_Steak_Multiplier_raw;
                set {
                    if (Well_Done_Steak_Multiplier_raw == value) return;
                    Well_Done_Steak_Multiplier_raw = value;
                    ChangedItems.Add(nameof(Well_Done_Steak_Multiplier));
                    OnPropertyChanged(nameof(Well_Done_Steak_Multiplier));
                }
            }

            [DisplayName("Offset")]
            public long Well_Done_Steak_Multiplier_offset { get; private set; }

            protected float Well_Done_Steak_Stamina_Bonus_raw;
            public const string Well_Done_Steak_Stamina_Bonus_displayName = "Well Done Steak Stamina Bonus";
            public const int Well_Done_Steak_Stamina_Bonus_sortIndex = 2650;
            [SortOrder(Well_Done_Steak_Stamina_Bonus_sortIndex)]
            [DisplayName(Well_Done_Steak_Stamina_Bonus_displayName)]
            public virtual float Well_Done_Steak_Stamina_Bonus {
                get => Well_Done_Steak_Stamina_Bonus_raw;
                set {
                    if (Well_Done_Steak_Stamina_Bonus_raw == value) return;
                    Well_Done_Steak_Stamina_Bonus_raw = value;
                    ChangedItems.Add(nameof(Well_Done_Steak_Stamina_Bonus));
                    OnPropertyChanged(nameof(Well_Done_Steak_Stamina_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long Well_Done_Steak_Stamina_Bonus_offset { get; private set; }

            protected float Unk23_raw;
            public const string Unk23_displayName = "Unk23";
            public const int Unk23_sortIndex = 2700;
            [SortOrder(Unk23_sortIndex)]
            [DisplayName(Unk23_displayName)]
            public virtual float Unk23 {
                get => Unk23_raw;
                set {
                    if (Unk23_raw == value) return;
                    Unk23_raw = value;
                    ChangedItems.Add(nameof(Unk23));
                    OnPropertyChanged(nameof(Unk23));
                }
            }

            [DisplayName("Offset")]
            public long Unk23_offset { get; private set; }

            protected float Unk24_raw;
            public const string Unk24_displayName = "Unk24";
            public const int Unk24_sortIndex = 2750;
            [SortOrder(Unk24_sortIndex)]
            [DisplayName(Unk24_displayName)]
            public virtual float Unk24 {
                get => Unk24_raw;
                set {
                    if (Unk24_raw == value) return;
                    Unk24_raw = value;
                    ChangedItems.Add(nameof(Unk24));
                    OnPropertyChanged(nameof(Unk24));
                }
            }

            [DisplayName("Offset")]
            public long Unk24_offset { get; private set; }

            protected ushort Burnt_Meat_Stamina_Recovery_raw;
            public const string Burnt_Meat_Stamina_Recovery_displayName = "Burnt Meat Stamina Recovery";
            public const int Burnt_Meat_Stamina_Recovery_sortIndex = 2800;
            [SortOrder(Burnt_Meat_Stamina_Recovery_sortIndex)]
            [DisplayName(Burnt_Meat_Stamina_Recovery_displayName)]
            public virtual ushort Burnt_Meat_Stamina_Recovery {
                get => Burnt_Meat_Stamina_Recovery_raw;
                set {
                    if (Burnt_Meat_Stamina_Recovery_raw == value) return;
                    Burnt_Meat_Stamina_Recovery_raw = value;
                    ChangedItems.Add(nameof(Burnt_Meat_Stamina_Recovery));
                    OnPropertyChanged(nameof(Burnt_Meat_Stamina_Recovery));
                }
            }

            [DisplayName("Offset")]
            public long Burnt_Meat_Stamina_Recovery_offset { get; private set; }

            protected short Unk26_raw;
            public const string Unk26_displayName = "Unk26";
            public const int Unk26_sortIndex = 2850;
            [SortOrder(Unk26_sortIndex)]
            [DisplayName(Unk26_displayName)]
            public virtual short Unk26 {
                get => Unk26_raw;
                set {
                    if (Unk26_raw == value) return;
                    Unk26_raw = value;
                    ChangedItems.Add(nameof(Unk26));
                    OnPropertyChanged(nameof(Unk26));
                }
            }

            [DisplayName("Offset")]
            public long Unk26_offset { get; private set; }

            protected byte Unk27_raw;
            public const string Unk27_displayName = "Unk27";
            public const int Unk27_sortIndex = 2900;
            [SortOrder(Unk27_sortIndex)]
            [DisplayName(Unk27_displayName)]
            public virtual byte Unk27 {
                get => Unk27_raw;
                set {
                    if (Unk27_raw == value) return;
                    Unk27_raw = value;
                    ChangedItems.Add(nameof(Unk27));
                    OnPropertyChanged(nameof(Unk27));
                }
            }

            [DisplayName("Offset")]
            public long Unk27_offset { get; private set; }

            protected float Unk28_raw;
            public const string Unk28_displayName = "Unk28";
            public const int Unk28_sortIndex = 2950;
            [SortOrder(Unk28_sortIndex)]
            [DisplayName(Unk28_displayName)]
            public virtual float Unk28 {
                get => Unk28_raw;
                set {
                    if (Unk28_raw == value) return;
                    Unk28_raw = value;
                    ChangedItems.Add(nameof(Unk28));
                    OnPropertyChanged(nameof(Unk28));
                }
            }

            [DisplayName("Offset")]
            public long Unk28_offset { get; private set; }

            protected float Unk29_raw;
            public const string Unk29_displayName = "Unk29";
            public const int Unk29_sortIndex = 3000;
            [SortOrder(Unk29_sortIndex)]
            [DisplayName(Unk29_displayName)]
            public virtual float Unk29 {
                get => Unk29_raw;
                set {
                    if (Unk29_raw == value) return;
                    Unk29_raw = value;
                    ChangedItems.Add(nameof(Unk29));
                    OnPropertyChanged(nameof(Unk29));
                }
            }

            [DisplayName("Offset")]
            public long Unk29_offset { get; private set; }

            protected float Unk30_raw;
            public const string Unk30_displayName = "Unk30";
            public const int Unk30_sortIndex = 3050;
            [SortOrder(Unk30_sortIndex)]
            [DisplayName(Unk30_displayName)]
            public virtual float Unk30 {
                get => Unk30_raw;
                set {
                    if (Unk30_raw == value) return;
                    Unk30_raw = value;
                    ChangedItems.Add(nameof(Unk30));
                    OnPropertyChanged(nameof(Unk30));
                }
            }

            [DisplayName("Offset")]
            public long Unk30_offset { get; private set; }

            protected float Unk31_raw;
            public const string Unk31_displayName = "Unk31";
            public const int Unk31_sortIndex = 3100;
            [SortOrder(Unk31_sortIndex)]
            [DisplayName(Unk31_displayName)]
            public virtual float Unk31 {
                get => Unk31_raw;
                set {
                    if (Unk31_raw == value) return;
                    Unk31_raw = value;
                    ChangedItems.Add(nameof(Unk31));
                    OnPropertyChanged(nameof(Unk31));
                }
            }

            [DisplayName("Offset")]
            public long Unk31_offset { get; private set; }

            protected float Unk32_raw;
            public const string Unk32_displayName = "Unk32";
            public const int Unk32_sortIndex = 3150;
            [SortOrder(Unk32_sortIndex)]
            [DisplayName(Unk32_displayName)]
            public virtual float Unk32 {
                get => Unk32_raw;
                set {
                    if (Unk32_raw == value) return;
                    Unk32_raw = value;
                    ChangedItems.Add(nameof(Unk32));
                    OnPropertyChanged(nameof(Unk32));
                }
            }

            [DisplayName("Offset")]
            public long Unk32_offset { get; private set; }

            protected float Unk33_raw;
            public const string Unk33_displayName = "Unk33";
            public const int Unk33_sortIndex = 3200;
            [SortOrder(Unk33_sortIndex)]
            [DisplayName(Unk33_displayName)]
            public virtual float Unk33 {
                get => Unk33_raw;
                set {
                    if (Unk33_raw == value) return;
                    Unk33_raw = value;
                    ChangedItems.Add(nameof(Unk33));
                    OnPropertyChanged(nameof(Unk33));
                }
            }

            [DisplayName("Offset")]
            public long Unk33_offset { get; private set; }

            protected float Unk34_raw;
            public const string Unk34_displayName = "Unk34";
            public const int Unk34_sortIndex = 3250;
            [SortOrder(Unk34_sortIndex)]
            [DisplayName(Unk34_displayName)]
            public virtual float Unk34 {
                get => Unk34_raw;
                set {
                    if (Unk34_raw == value) return;
                    Unk34_raw = value;
                    ChangedItems.Add(nameof(Unk34));
                    OnPropertyChanged(nameof(Unk34));
                }
            }

            [DisplayName("Offset")]
            public long Unk34_offset { get; private set; }

            protected float Unk35_raw;
            public const string Unk35_displayName = "Unk35";
            public const int Unk35_sortIndex = 3300;
            [SortOrder(Unk35_sortIndex)]
            [DisplayName(Unk35_displayName)]
            public virtual float Unk35 {
                get => Unk35_raw;
                set {
                    if (Unk35_raw == value) return;
                    Unk35_raw = value;
                    ChangedItems.Add(nameof(Unk35));
                    OnPropertyChanged(nameof(Unk35));
                }
            }

            [DisplayName("Offset")]
            public long Unk35_offset { get; private set; }

            protected float Unk36_raw;
            public const string Unk36_displayName = "Unk36";
            public const int Unk36_sortIndex = 3350;
            [SortOrder(Unk36_sortIndex)]
            [DisplayName(Unk36_displayName)]
            public virtual float Unk36 {
                get => Unk36_raw;
                set {
                    if (Unk36_raw == value) return;
                    Unk36_raw = value;
                    ChangedItems.Add(nameof(Unk36));
                    OnPropertyChanged(nameof(Unk36));
                }
            }

            [DisplayName("Offset")]
            public long Unk36_offset { get; private set; }

            protected float Unk37_raw;
            public const string Unk37_displayName = "Unk37";
            public const int Unk37_sortIndex = 3400;
            [SortOrder(Unk37_sortIndex)]
            [DisplayName(Unk37_displayName)]
            public virtual float Unk37 {
                get => Unk37_raw;
                set {
                    if (Unk37_raw == value) return;
                    Unk37_raw = value;
                    ChangedItems.Add(nameof(Unk37));
                    OnPropertyChanged(nameof(Unk37));
                }
            }

            [DisplayName("Offset")]
            public long Unk37_offset { get; private set; }

            protected float Unk38_raw;
            public const string Unk38_displayName = "Unk38";
            public const int Unk38_sortIndex = 3450;
            [SortOrder(Unk38_sortIndex)]
            [DisplayName(Unk38_displayName)]
            public virtual float Unk38 {
                get => Unk38_raw;
                set {
                    if (Unk38_raw == value) return;
                    Unk38_raw = value;
                    ChangedItems.Add(nameof(Unk38));
                    OnPropertyChanged(nameof(Unk38));
                }
            }

            [DisplayName("Offset")]
            public long Unk38_offset { get; private set; }

            protected uint Whetstone_Sharpness_Restored_raw;
            public const string Whetstone_Sharpness_Restored_displayName = "Whetstone Sharpness Restored";
            public const int Whetstone_Sharpness_Restored_sortIndex = 3500;
            [SortOrder(Whetstone_Sharpness_Restored_sortIndex)]
            [DisplayName(Whetstone_Sharpness_Restored_displayName)]
            public virtual uint Whetstone_Sharpness_Restored {
                get => Whetstone_Sharpness_Restored_raw;
                set {
                    if (Whetstone_Sharpness_Restored_raw == value) return;
                    Whetstone_Sharpness_Restored_raw = value;
                    ChangedItems.Add(nameof(Whetstone_Sharpness_Restored));
                    OnPropertyChanged(nameof(Whetstone_Sharpness_Restored));
                }
            }

            [DisplayName("Offset")]
            public long Whetstone_Sharpness_Restored_offset { get; private set; }

            protected uint Whetstone_Cycles_raw;
            public const string Whetstone_Cycles_displayName = "Whetstone Cycles";
            public const int Whetstone_Cycles_sortIndex = 3550;
            [SortOrder(Whetstone_Cycles_sortIndex)]
            [DisplayName(Whetstone_Cycles_displayName)]
            public virtual uint Whetstone_Cycles {
                get => Whetstone_Cycles_raw;
                set {
                    if (Whetstone_Cycles_raw == value) return;
                    Whetstone_Cycles_raw = value;
                    ChangedItems.Add(nameof(Whetstone_Cycles));
                    OnPropertyChanged(nameof(Whetstone_Cycles));
                }
            }

            [DisplayName("Offset")]
            public long Whetstone_Cycles_offset { get; private set; }

            protected uint Whetfish_Scale_Sharpness_Restored_raw;
            public const string Whetfish_Scale_Sharpness_Restored_displayName = "Whetfish Scale Sharpness Restored";
            public const int Whetfish_Scale_Sharpness_Restored_sortIndex = 3600;
            [SortOrder(Whetfish_Scale_Sharpness_Restored_sortIndex)]
            [DisplayName(Whetfish_Scale_Sharpness_Restored_displayName)]
            public virtual uint Whetfish_Scale_Sharpness_Restored {
                get => Whetfish_Scale_Sharpness_Restored_raw;
                set {
                    if (Whetfish_Scale_Sharpness_Restored_raw == value) return;
                    Whetfish_Scale_Sharpness_Restored_raw = value;
                    ChangedItems.Add(nameof(Whetfish_Scale_Sharpness_Restored));
                    OnPropertyChanged(nameof(Whetfish_Scale_Sharpness_Restored));
                }
            }

            [DisplayName("Offset")]
            public long Whetfish_Scale_Sharpness_Restored_offset { get; private set; }

            protected byte Whetfish_Scale_Cycles_raw;
            public const string Whetfish_Scale_Cycles_displayName = "Whetfish Scale Cycles";
            public const int Whetfish_Scale_Cycles_sortIndex = 3650;
            [SortOrder(Whetfish_Scale_Cycles_sortIndex)]
            [DisplayName(Whetfish_Scale_Cycles_displayName)]
            public virtual byte Whetfish_Scale_Cycles {
                get => Whetfish_Scale_Cycles_raw;
                set {
                    if (Whetfish_Scale_Cycles_raw == value) return;
                    Whetfish_Scale_Cycles_raw = value;
                    ChangedItems.Add(nameof(Whetfish_Scale_Cycles));
                    OnPropertyChanged(nameof(Whetfish_Scale_Cycles));
                }
            }

            [DisplayName("Offset")]
            public long Whetfish_Scale_Cycles_offset { get; private set; }

            protected byte Whetfish_Scale_Plus_Cycles_raw;
            public const string Whetfish_Scale_Plus_Cycles_displayName = "Whetfish Scale Plus Cycles";
            public const int Whetfish_Scale_Plus_Cycles_sortIndex = 3700;
            [SortOrder(Whetfish_Scale_Plus_Cycles_sortIndex)]
            [DisplayName(Whetfish_Scale_Plus_Cycles_displayName)]
            public virtual byte Whetfish_Scale_Plus_Cycles {
                get => Whetfish_Scale_Plus_Cycles_raw;
                set {
                    if (Whetfish_Scale_Plus_Cycles_raw == value) return;
                    Whetfish_Scale_Plus_Cycles_raw = value;
                    ChangedItems.Add(nameof(Whetfish_Scale_Plus_Cycles));
                    OnPropertyChanged(nameof(Whetfish_Scale_Plus_Cycles));
                }
            }

            [DisplayName("Offset")]
            public long Whetfish_Scale_Plus_Cycles_offset { get; private set; }

            protected byte Whetfish_Scale_Consume__raw;
            public const string Whetfish_Scale_Consume__displayName = "Whetfish Scale Consume %";
            public const int Whetfish_Scale_Consume__sortIndex = 3750;
            [SortOrder(Whetfish_Scale_Consume__sortIndex)]
            [DisplayName(Whetfish_Scale_Consume__displayName)]
            public virtual byte Whetfish_Scale_Consume_ {
                get => Whetfish_Scale_Consume__raw;
                set {
                    if (Whetfish_Scale_Consume__raw == value) return;
                    Whetfish_Scale_Consume__raw = value;
                    ChangedItems.Add(nameof(Whetfish_Scale_Consume_));
                    OnPropertyChanged(nameof(Whetfish_Scale_Consume_));
                }
            }

            [DisplayName("Offset")]
            public long Whetfish_Scale_Consume__offset { get; private set; }

            protected byte Powertalon_Power_raw;
            public const string Powertalon_Power_displayName = "Powertalon Power";
            public const int Powertalon_Power_sortIndex = 3800;
            [SortOrder(Powertalon_Power_sortIndex)]
            [DisplayName(Powertalon_Power_displayName)]
            public virtual byte Powertalon_Power {
                get => Powertalon_Power_raw;
                set {
                    if (Powertalon_Power_raw == value) return;
                    Powertalon_Power_raw = value;
                    ChangedItems.Add(nameof(Powertalon_Power));
                    OnPropertyChanged(nameof(Powertalon_Power));
                }
            }

            [DisplayName("Offset")]
            public long Powertalon_Power_offset { get; private set; }

            protected byte Powercharm_Power_raw;
            public const string Powercharm_Power_displayName = "Powercharm Power";
            public const int Powercharm_Power_sortIndex = 3850;
            [SortOrder(Powercharm_Power_sortIndex)]
            [DisplayName(Powercharm_Power_displayName)]
            public virtual byte Powercharm_Power {
                get => Powercharm_Power_raw;
                set {
                    if (Powercharm_Power_raw == value) return;
                    Powercharm_Power_raw = value;
                    ChangedItems.Add(nameof(Powercharm_Power));
                    OnPropertyChanged(nameof(Powercharm_Power));
                }
            }

            [DisplayName("Offset")]
            public long Powercharm_Power_offset { get; private set; }

            protected byte Armortalon_Power_raw;
            public const string Armortalon_Power_displayName = "Armortalon Power";
            public const int Armortalon_Power_sortIndex = 3900;
            [SortOrder(Armortalon_Power_sortIndex)]
            [DisplayName(Armortalon_Power_displayName)]
            public virtual byte Armortalon_Power {
                get => Armortalon_Power_raw;
                set {
                    if (Armortalon_Power_raw == value) return;
                    Armortalon_Power_raw = value;
                    ChangedItems.Add(nameof(Armortalon_Power));
                    OnPropertyChanged(nameof(Armortalon_Power));
                }
            }

            [DisplayName("Offset")]
            public long Armortalon_Power_offset { get; private set; }

            protected byte Armorcharm_Power_raw;
            public const string Armorcharm_Power_displayName = "Armorcharm Power";
            public const int Armorcharm_Power_sortIndex = 3950;
            [SortOrder(Armorcharm_Power_sortIndex)]
            [DisplayName(Armorcharm_Power_displayName)]
            public virtual byte Armorcharm_Power {
                get => Armorcharm_Power_raw;
                set {
                    if (Armorcharm_Power_raw == value) return;
                    Armorcharm_Power_raw = value;
                    ChangedItems.Add(nameof(Armorcharm_Power));
                    OnPropertyChanged(nameof(Armorcharm_Power));
                }
            }

            [DisplayName("Offset")]
            public long Armorcharm_Power_offset { get; private set; }

            protected byte Unk49_raw;
            public const string Unk49_displayName = "Unk49";
            public const int Unk49_sortIndex = 4000;
            [SortOrder(Unk49_sortIndex)]
            [DisplayName(Unk49_displayName)]
            public virtual byte Unk49 {
                get => Unk49_raw;
                set {
                    if (Unk49_raw == value) return;
                    Unk49_raw = value;
                    ChangedItems.Add(nameof(Unk49));
                    OnPropertyChanged(nameof(Unk49));
                }
            }

            [DisplayName("Offset")]
            public long Unk49_offset { get; private set; }

            protected float Unk50_raw;
            public const string Unk50_displayName = "Unk50";
            public const int Unk50_sortIndex = 4050;
            [SortOrder(Unk50_sortIndex)]
            [DisplayName(Unk50_displayName)]
            public virtual float Unk50 {
                get => Unk50_raw;
                set {
                    if (Unk50_raw == value) return;
                    Unk50_raw = value;
                    ChangedItems.Add(nameof(Unk50));
                    OnPropertyChanged(nameof(Unk50));
                }
            }

            [DisplayName("Offset")]
            public long Unk50_offset { get; private set; }

            protected float Unk51_raw;
            public const string Unk51_displayName = "Unk51";
            public const int Unk51_sortIndex = 4100;
            [SortOrder(Unk51_sortIndex)]
            [DisplayName(Unk51_displayName)]
            public virtual float Unk51 {
                get => Unk51_raw;
                set {
                    if (Unk51_raw == value) return;
                    Unk51_raw = value;
                    ChangedItems.Add(nameof(Unk51));
                    OnPropertyChanged(nameof(Unk51));
                }
            }

            [DisplayName("Offset")]
            public long Unk51_offset { get; private set; }

            protected float Unk52_raw;
            public const string Unk52_displayName = "Unk52";
            public const int Unk52_sortIndex = 4150;
            [SortOrder(Unk52_sortIndex)]
            [DisplayName(Unk52_displayName)]
            public virtual float Unk52 {
                get => Unk52_raw;
                set {
                    if (Unk52_raw == value) return;
                    Unk52_raw = value;
                    ChangedItems.Add(nameof(Unk52));
                    OnPropertyChanged(nameof(Unk52));
                }
            }

            [DisplayName("Offset")]
            public long Unk52_offset { get; private set; }

            protected float Unk53_raw;
            public const string Unk53_displayName = "Unk53";
            public const int Unk53_sortIndex = 4200;
            [SortOrder(Unk53_sortIndex)]
            [DisplayName(Unk53_displayName)]
            public virtual float Unk53 {
                get => Unk53_raw;
                set {
                    if (Unk53_raw == value) return;
                    Unk53_raw = value;
                    ChangedItems.Add(nameof(Unk53));
                    OnPropertyChanged(nameof(Unk53));
                }
            }

            [DisplayName("Offset")]
            public long Unk53_offset { get; private set; }

            protected float Unk54_raw;
            public const string Unk54_displayName = "Unk54";
            public const int Unk54_sortIndex = 4250;
            [SortOrder(Unk54_sortIndex)]
            [DisplayName(Unk54_displayName)]
            public virtual float Unk54 {
                get => Unk54_raw;
                set {
                    if (Unk54_raw == value) return;
                    Unk54_raw = value;
                    ChangedItems.Add(nameof(Unk54));
                    OnPropertyChanged(nameof(Unk54));
                }
            }

            [DisplayName("Offset")]
            public long Unk54_offset { get; private set; }

            protected float Unk55_raw;
            public const string Unk55_displayName = "Unk55";
            public const int Unk55_sortIndex = 4300;
            [SortOrder(Unk55_sortIndex)]
            [DisplayName(Unk55_displayName)]
            public virtual float Unk55 {
                get => Unk55_raw;
                set {
                    if (Unk55_raw == value) return;
                    Unk55_raw = value;
                    ChangedItems.Add(nameof(Unk55));
                    OnPropertyChanged(nameof(Unk55));
                }
            }

            [DisplayName("Offset")]
            public long Unk55_offset { get; private set; }

            protected float Unk56_raw;
            public const string Unk56_displayName = "Unk56";
            public const int Unk56_sortIndex = 4350;
            [SortOrder(Unk56_sortIndex)]
            [DisplayName(Unk56_displayName)]
            public virtual float Unk56 {
                get => Unk56_raw;
                set {
                    if (Unk56_raw == value) return;
                    Unk56_raw = value;
                    ChangedItems.Add(nameof(Unk56));
                    OnPropertyChanged(nameof(Unk56));
                }
            }

            [DisplayName("Offset")]
            public long Unk56_offset { get; private set; }

            protected float Unk57_raw;
            public const string Unk57_displayName = "Unk57";
            public const int Unk57_sortIndex = 4400;
            [SortOrder(Unk57_sortIndex)]
            [DisplayName(Unk57_displayName)]
            public virtual float Unk57 {
                get => Unk57_raw;
                set {
                    if (Unk57_raw == value) return;
                    Unk57_raw = value;
                    ChangedItems.Add(nameof(Unk57));
                    OnPropertyChanged(nameof(Unk57));
                }
            }

            [DisplayName("Offset")]
            public long Unk57_offset { get; private set; }

            protected float Unk58_raw;
            public const string Unk58_displayName = "Unk58";
            public const int Unk58_sortIndex = 4450;
            [SortOrder(Unk58_sortIndex)]
            [DisplayName(Unk58_displayName)]
            public virtual float Unk58 {
                get => Unk58_raw;
                set {
                    if (Unk58_raw == value) return;
                    Unk58_raw = value;
                    ChangedItems.Add(nameof(Unk58));
                    OnPropertyChanged(nameof(Unk58));
                }
            }

            [DisplayName("Offset")]
            public long Unk58_offset { get; private set; }

            protected float Unk59_raw;
            public const string Unk59_displayName = "Unk59";
            public const int Unk59_sortIndex = 4500;
            [SortOrder(Unk59_sortIndex)]
            [DisplayName(Unk59_displayName)]
            public virtual float Unk59 {
                get => Unk59_raw;
                set {
                    if (Unk59_raw == value) return;
                    Unk59_raw = value;
                    ChangedItems.Add(nameof(Unk59));
                    OnPropertyChanged(nameof(Unk59));
                }
            }

            [DisplayName("Offset")]
            public long Unk59_offset { get; private set; }

            protected float Unk60_raw;
            public const string Unk60_displayName = "Unk60";
            public const int Unk60_sortIndex = 4550;
            [SortOrder(Unk60_sortIndex)]
            [DisplayName(Unk60_displayName)]
            public virtual float Unk60 {
                get => Unk60_raw;
                set {
                    if (Unk60_raw == value) return;
                    Unk60_raw = value;
                    ChangedItems.Add(nameof(Unk60));
                    OnPropertyChanged(nameof(Unk60));
                }
            }

            [DisplayName("Offset")]
            public long Unk60_offset { get; private set; }

            protected float Unk61_raw;
            public const string Unk61_displayName = "Unk61";
            public const int Unk61_sortIndex = 4600;
            [SortOrder(Unk61_sortIndex)]
            [DisplayName(Unk61_displayName)]
            public virtual float Unk61 {
                get => Unk61_raw;
                set {
                    if (Unk61_raw == value) return;
                    Unk61_raw = value;
                    ChangedItems.Add(nameof(Unk61));
                    OnPropertyChanged(nameof(Unk61));
                }
            }

            [DisplayName("Offset")]
            public long Unk61_offset { get; private set; }

            protected float Unk62_raw;
            public const string Unk62_displayName = "Unk62";
            public const int Unk62_sortIndex = 4650;
            [SortOrder(Unk62_sortIndex)]
            [DisplayName(Unk62_displayName)]
            public virtual float Unk62 {
                get => Unk62_raw;
                set {
                    if (Unk62_raw == value) return;
                    Unk62_raw = value;
                    ChangedItems.Add(nameof(Unk62));
                    OnPropertyChanged(nameof(Unk62));
                }
            }

            [DisplayName("Offset")]
            public long Unk62_offset { get; private set; }

            protected float Unk63_raw;
            public const string Unk63_displayName = "Unk63";
            public const int Unk63_sortIndex = 4700;
            [SortOrder(Unk63_sortIndex)]
            [DisplayName(Unk63_displayName)]
            public virtual float Unk63 {
                get => Unk63_raw;
                set {
                    if (Unk63_raw == value) return;
                    Unk63_raw = value;
                    ChangedItems.Add(nameof(Unk63));
                    OnPropertyChanged(nameof(Unk63));
                }
            }

            [DisplayName("Offset")]
            public long Unk63_offset { get; private set; }

            protected float Unk64_raw;
            public const string Unk64_displayName = "Unk64";
            public const int Unk64_sortIndex = 4750;
            [SortOrder(Unk64_sortIndex)]
            [DisplayName(Unk64_displayName)]
            public virtual float Unk64 {
                get => Unk64_raw;
                set {
                    if (Unk64_raw == value) return;
                    Unk64_raw = value;
                    ChangedItems.Add(nameof(Unk64));
                    OnPropertyChanged(nameof(Unk64));
                }
            }

            [DisplayName("Offset")]
            public long Unk64_offset { get; private set; }

            protected float Unk65_raw;
            public const string Unk65_displayName = "Unk65";
            public const int Unk65_sortIndex = 4800;
            [SortOrder(Unk65_sortIndex)]
            [DisplayName(Unk65_displayName)]
            public virtual float Unk65 {
                get => Unk65_raw;
                set {
                    if (Unk65_raw == value) return;
                    Unk65_raw = value;
                    ChangedItems.Add(nameof(Unk65));
                    OnPropertyChanged(nameof(Unk65));
                }
            }

            [DisplayName("Offset")]
            public long Unk65_offset { get; private set; }

            protected float Unk66_raw;
            public const string Unk66_displayName = "Unk66";
            public const int Unk66_sortIndex = 4850;
            [SortOrder(Unk66_sortIndex)]
            [DisplayName(Unk66_displayName)]
            public virtual float Unk66 {
                get => Unk66_raw;
                set {
                    if (Unk66_raw == value) return;
                    Unk66_raw = value;
                    ChangedItems.Add(nameof(Unk66));
                    OnPropertyChanged(nameof(Unk66));
                }
            }

            [DisplayName("Offset")]
            public long Unk66_offset { get; private set; }

            protected float Unk67_raw;
            public const string Unk67_displayName = "Unk67";
            public const int Unk67_sortIndex = 4900;
            [SortOrder(Unk67_sortIndex)]
            [DisplayName(Unk67_displayName)]
            public virtual float Unk67 {
                get => Unk67_raw;
                set {
                    if (Unk67_raw == value) return;
                    Unk67_raw = value;
                    ChangedItems.Add(nameof(Unk67));
                    OnPropertyChanged(nameof(Unk67));
                }
            }

            [DisplayName("Offset")]
            public long Unk67_offset { get; private set; }

            protected float Unk68_raw;
            public const string Unk68_displayName = "Unk68";
            public const int Unk68_sortIndex = 4950;
            [SortOrder(Unk68_sortIndex)]
            [DisplayName(Unk68_displayName)]
            public virtual float Unk68 {
                get => Unk68_raw;
                set {
                    if (Unk68_raw == value) return;
                    Unk68_raw = value;
                    ChangedItems.Add(nameof(Unk68));
                    OnPropertyChanged(nameof(Unk68));
                }
            }

            [DisplayName("Offset")]
            public long Unk68_offset { get; private set; }

            protected float Unk69_raw;
            public const string Unk69_displayName = "Unk69";
            public const int Unk69_sortIndex = 5000;
            [SortOrder(Unk69_sortIndex)]
            [DisplayName(Unk69_displayName)]
            public virtual float Unk69 {
                get => Unk69_raw;
                set {
                    if (Unk69_raw == value) return;
                    Unk69_raw = value;
                    ChangedItems.Add(nameof(Unk69));
                    OnPropertyChanged(nameof(Unk69));
                }
            }

            [DisplayName("Offset")]
            public long Unk69_offset { get; private set; }

            protected float Unk70_raw;
            public const string Unk70_displayName = "Unk70";
            public const int Unk70_sortIndex = 5050;
            [SortOrder(Unk70_sortIndex)]
            [DisplayName(Unk70_displayName)]
            public virtual float Unk70 {
                get => Unk70_raw;
                set {
                    if (Unk70_raw == value) return;
                    Unk70_raw = value;
                    ChangedItems.Add(nameof(Unk70));
                    OnPropertyChanged(nameof(Unk70));
                }
            }

            [DisplayName("Offset")]
            public long Unk70_offset { get; private set; }

            protected float Unk71_raw;
            public const string Unk71_displayName = "Unk71";
            public const int Unk71_sortIndex = 5100;
            [SortOrder(Unk71_sortIndex)]
            [DisplayName(Unk71_displayName)]
            public virtual float Unk71 {
                get => Unk71_raw;
                set {
                    if (Unk71_raw == value) return;
                    Unk71_raw = value;
                    ChangedItems.Add(nameof(Unk71));
                    OnPropertyChanged(nameof(Unk71));
                }
            }

            [DisplayName("Offset")]
            public long Unk71_offset { get; private set; }

            protected float Unk72_raw;
            public const string Unk72_displayName = "Unk72";
            public const int Unk72_sortIndex = 5150;
            [SortOrder(Unk72_sortIndex)]
            [DisplayName(Unk72_displayName)]
            public virtual float Unk72 {
                get => Unk72_raw;
                set {
                    if (Unk72_raw == value) return;
                    Unk72_raw = value;
                    ChangedItems.Add(nameof(Unk72));
                    OnPropertyChanged(nameof(Unk72));
                }
            }

            [DisplayName("Offset")]
            public long Unk72_offset { get; private set; }

            protected float Unk73_raw;
            public const string Unk73_displayName = "Unk73";
            public const int Unk73_sortIndex = 5200;
            [SortOrder(Unk73_sortIndex)]
            [DisplayName(Unk73_displayName)]
            public virtual float Unk73 {
                get => Unk73_raw;
                set {
                    if (Unk73_raw == value) return;
                    Unk73_raw = value;
                    ChangedItems.Add(nameof(Unk73));
                    OnPropertyChanged(nameof(Unk73));
                }
            }

            [DisplayName("Offset")]
            public long Unk73_offset { get; private set; }

            protected float Unk74_raw;
            public const string Unk74_displayName = "Unk74";
            public const int Unk74_sortIndex = 5250;
            [SortOrder(Unk74_sortIndex)]
            [DisplayName(Unk74_displayName)]
            public virtual float Unk74 {
                get => Unk74_raw;
                set {
                    if (Unk74_raw == value) return;
                    Unk74_raw = value;
                    ChangedItems.Add(nameof(Unk74));
                    OnPropertyChanged(nameof(Unk74));
                }
            }

            [DisplayName("Offset")]
            public long Unk74_offset { get; private set; }

            protected float Unk75_raw;
            public const string Unk75_displayName = "Unk75";
            public const int Unk75_sortIndex = 5300;
            [SortOrder(Unk75_sortIndex)]
            [DisplayName(Unk75_displayName)]
            public virtual float Unk75 {
                get => Unk75_raw;
                set {
                    if (Unk75_raw == value) return;
                    Unk75_raw = value;
                    ChangedItems.Add(nameof(Unk75));
                    OnPropertyChanged(nameof(Unk75));
                }
            }

            [DisplayName("Offset")]
            public long Unk75_offset { get; private set; }

            protected float Unk76_raw;
            public const string Unk76_displayName = "Unk76";
            public const int Unk76_sortIndex = 5350;
            [SortOrder(Unk76_sortIndex)]
            [DisplayName(Unk76_displayName)]
            public virtual float Unk76 {
                get => Unk76_raw;
                set {
                    if (Unk76_raw == value) return;
                    Unk76_raw = value;
                    ChangedItems.Add(nameof(Unk76));
                    OnPropertyChanged(nameof(Unk76));
                }
            }

            [DisplayName("Offset")]
            public long Unk76_offset { get; private set; }

            protected float Unk77_raw;
            public const string Unk77_displayName = "Unk77";
            public const int Unk77_sortIndex = 5400;
            [SortOrder(Unk77_sortIndex)]
            [DisplayName(Unk77_displayName)]
            public virtual float Unk77 {
                get => Unk77_raw;
                set {
                    if (Unk77_raw == value) return;
                    Unk77_raw = value;
                    ChangedItems.Add(nameof(Unk77));
                    OnPropertyChanged(nameof(Unk77));
                }
            }

            [DisplayName("Offset")]
            public long Unk77_offset { get; private set; }

            protected float Unk78_raw;
            public const string Unk78_displayName = "Unk78";
            public const int Unk78_sortIndex = 5450;
            [SortOrder(Unk78_sortIndex)]
            [DisplayName(Unk78_displayName)]
            public virtual float Unk78 {
                get => Unk78_raw;
                set {
                    if (Unk78_raw == value) return;
                    Unk78_raw = value;
                    ChangedItems.Add(nameof(Unk78));
                    OnPropertyChanged(nameof(Unk78));
                }
            }

            [DisplayName("Offset")]
            public long Unk78_offset { get; private set; }

            protected float Unk79_raw;
            public const string Unk79_displayName = "Unk79";
            public const int Unk79_sortIndex = 5500;
            [SortOrder(Unk79_sortIndex)]
            [DisplayName(Unk79_displayName)]
            public virtual float Unk79 {
                get => Unk79_raw;
                set {
                    if (Unk79_raw == value) return;
                    Unk79_raw = value;
                    ChangedItems.Add(nameof(Unk79));
                    OnPropertyChanged(nameof(Unk79));
                }
            }

            [DisplayName("Offset")]
            public long Unk79_offset { get; private set; }

            protected float Unk80_raw;
            public const string Unk80_displayName = "Unk80";
            public const int Unk80_sortIndex = 5550;
            [SortOrder(Unk80_sortIndex)]
            [DisplayName(Unk80_displayName)]
            public virtual float Unk80 {
                get => Unk80_raw;
                set {
                    if (Unk80_raw == value) return;
                    Unk80_raw = value;
                    ChangedItems.Add(nameof(Unk80));
                    OnPropertyChanged(nameof(Unk80));
                }
            }

            [DisplayName("Offset")]
            public long Unk80_offset { get; private set; }

            protected float Unk81_raw;
            public const string Unk81_displayName = "Unk81";
            public const int Unk81_sortIndex = 5600;
            [SortOrder(Unk81_sortIndex)]
            [DisplayName(Unk81_displayName)]
            public virtual float Unk81 {
                get => Unk81_raw;
                set {
                    if (Unk81_raw == value) return;
                    Unk81_raw = value;
                    ChangedItems.Add(nameof(Unk81));
                    OnPropertyChanged(nameof(Unk81));
                }
            }

            [DisplayName("Offset")]
            public long Unk81_offset { get; private set; }

            protected float Unk82_raw;
            public const string Unk82_displayName = "Unk82";
            public const int Unk82_sortIndex = 5650;
            [SortOrder(Unk82_sortIndex)]
            [DisplayName(Unk82_displayName)]
            public virtual float Unk82 {
                get => Unk82_raw;
                set {
                    if (Unk82_raw == value) return;
                    Unk82_raw = value;
                    ChangedItems.Add(nameof(Unk82));
                    OnPropertyChanged(nameof(Unk82));
                }
            }

            [DisplayName("Offset")]
            public long Unk82_offset { get; private set; }

            protected float Unk83_raw;
            public const string Unk83_displayName = "Unk83";
            public const int Unk83_sortIndex = 5700;
            [SortOrder(Unk83_sortIndex)]
            [DisplayName(Unk83_displayName)]
            public virtual float Unk83 {
                get => Unk83_raw;
                set {
                    if (Unk83_raw == value) return;
                    Unk83_raw = value;
                    ChangedItems.Add(nameof(Unk83));
                    OnPropertyChanged(nameof(Unk83));
                }
            }

            [DisplayName("Offset")]
            public long Unk83_offset { get; private set; }

            protected float Unk84_raw;
            public const string Unk84_displayName = "Unk84";
            public const int Unk84_sortIndex = 5750;
            [SortOrder(Unk84_sortIndex)]
            [DisplayName(Unk84_displayName)]
            public virtual float Unk84 {
                get => Unk84_raw;
                set {
                    if (Unk84_raw == value) return;
                    Unk84_raw = value;
                    ChangedItems.Add(nameof(Unk84));
                    OnPropertyChanged(nameof(Unk84));
                }
            }

            [DisplayName("Offset")]
            public long Unk84_offset { get; private set; }

            protected float Unk85_raw;
            public const string Unk85_displayName = "Unk85";
            public const int Unk85_sortIndex = 5800;
            [SortOrder(Unk85_sortIndex)]
            [DisplayName(Unk85_displayName)]
            public virtual float Unk85 {
                get => Unk85_raw;
                set {
                    if (Unk85_raw == value) return;
                    Unk85_raw = value;
                    ChangedItems.Add(nameof(Unk85));
                    OnPropertyChanged(nameof(Unk85));
                }
            }

            [DisplayName("Offset")]
            public long Unk85_offset { get; private set; }

            protected float Unk86_raw;
            public const string Unk86_displayName = "Unk86";
            public const int Unk86_sortIndex = 5850;
            [SortOrder(Unk86_sortIndex)]
            [DisplayName(Unk86_displayName)]
            public virtual float Unk86 {
                get => Unk86_raw;
                set {
                    if (Unk86_raw == value) return;
                    Unk86_raw = value;
                    ChangedItems.Add(nameof(Unk86));
                    OnPropertyChanged(nameof(Unk86));
                }
            }

            [DisplayName("Offset")]
            public long Unk86_offset { get; private set; }

            protected float Unk87_raw;
            public const string Unk87_displayName = "Unk87";
            public const int Unk87_sortIndex = 5900;
            [SortOrder(Unk87_sortIndex)]
            [DisplayName(Unk87_displayName)]
            public virtual float Unk87 {
                get => Unk87_raw;
                set {
                    if (Unk87_raw == value) return;
                    Unk87_raw = value;
                    ChangedItems.Add(nameof(Unk87));
                    OnPropertyChanged(nameof(Unk87));
                }
            }

            [DisplayName("Offset")]
            public long Unk87_offset { get; private set; }

            protected float Unk88_raw;
            public const string Unk88_displayName = "Unk88";
            public const int Unk88_sortIndex = 5950;
            [SortOrder(Unk88_sortIndex)]
            [DisplayName(Unk88_displayName)]
            public virtual float Unk88 {
                get => Unk88_raw;
                set {
                    if (Unk88_raw == value) return;
                    Unk88_raw = value;
                    ChangedItems.Add(nameof(Unk88));
                    OnPropertyChanged(nameof(Unk88));
                }
            }

            [DisplayName("Offset")]
            public long Unk88_offset { get; private set; }

            protected float Unk89_raw;
            public const string Unk89_displayName = "Unk89";
            public const int Unk89_sortIndex = 6000;
            [SortOrder(Unk89_sortIndex)]
            [DisplayName(Unk89_displayName)]
            public virtual float Unk89 {
                get => Unk89_raw;
                set {
                    if (Unk89_raw == value) return;
                    Unk89_raw = value;
                    ChangedItems.Add(nameof(Unk89));
                    OnPropertyChanged(nameof(Unk89));
                }
            }

            [DisplayName("Offset")]
            public long Unk89_offset { get; private set; }

            protected float Unk90_raw;
            public const string Unk90_displayName = "Unk90";
            public const int Unk90_sortIndex = 6050;
            [SortOrder(Unk90_sortIndex)]
            [DisplayName(Unk90_displayName)]
            public virtual float Unk90 {
                get => Unk90_raw;
                set {
                    if (Unk90_raw == value) return;
                    Unk90_raw = value;
                    ChangedItems.Add(nameof(Unk90));
                    OnPropertyChanged(nameof(Unk90));
                }
            }

            [DisplayName("Offset")]
            public long Unk90_offset { get; private set; }

            protected float Unk91_raw;
            public const string Unk91_displayName = "Unk91";
            public const int Unk91_sortIndex = 6100;
            [SortOrder(Unk91_sortIndex)]
            [DisplayName(Unk91_displayName)]
            public virtual float Unk91 {
                get => Unk91_raw;
                set {
                    if (Unk91_raw == value) return;
                    Unk91_raw = value;
                    ChangedItems.Add(nameof(Unk91));
                    OnPropertyChanged(nameof(Unk91));
                }
            }

            [DisplayName("Offset")]
            public long Unk91_offset { get; private set; }

            protected float Unk92_raw;
            public const string Unk92_displayName = "Unk92";
            public const int Unk92_sortIndex = 6150;
            [SortOrder(Unk92_sortIndex)]
            [DisplayName(Unk92_displayName)]
            public virtual float Unk92 {
                get => Unk92_raw;
                set {
                    if (Unk92_raw == value) return;
                    Unk92_raw = value;
                    ChangedItems.Add(nameof(Unk92));
                    OnPropertyChanged(nameof(Unk92));
                }
            }

            [DisplayName("Offset")]
            public long Unk92_offset { get; private set; }

            protected float Unk93_raw;
            public const string Unk93_displayName = "Unk93";
            public const int Unk93_sortIndex = 6200;
            [SortOrder(Unk93_sortIndex)]
            [DisplayName(Unk93_displayName)]
            public virtual float Unk93 {
                get => Unk93_raw;
                set {
                    if (Unk93_raw == value) return;
                    Unk93_raw = value;
                    ChangedItems.Add(nameof(Unk93));
                    OnPropertyChanged(nameof(Unk93));
                }
            }

            [DisplayName("Offset")]
            public long Unk93_offset { get; private set; }

            protected float Unk94_raw;
            public const string Unk94_displayName = "Unk94";
            public const int Unk94_sortIndex = 6250;
            [SortOrder(Unk94_sortIndex)]
            [DisplayName(Unk94_displayName)]
            public virtual float Unk94 {
                get => Unk94_raw;
                set {
                    if (Unk94_raw == value) return;
                    Unk94_raw = value;
                    ChangedItems.Add(nameof(Unk94));
                    OnPropertyChanged(nameof(Unk94));
                }
            }

            [DisplayName("Offset")]
            public long Unk94_offset { get; private set; }

            protected float Unk95_raw;
            public const string Unk95_displayName = "Unk95";
            public const int Unk95_sortIndex = 6300;
            [SortOrder(Unk95_sortIndex)]
            [DisplayName(Unk95_displayName)]
            public virtual float Unk95 {
                get => Unk95_raw;
                set {
                    if (Unk95_raw == value) return;
                    Unk95_raw = value;
                    ChangedItems.Add(nameof(Unk95));
                    OnPropertyChanged(nameof(Unk95));
                }
            }

            [DisplayName("Offset")]
            public long Unk95_offset { get; private set; }

            protected float Unk96_raw;
            public const string Unk96_displayName = "Unk96";
            public const int Unk96_sortIndex = 6350;
            [SortOrder(Unk96_sortIndex)]
            [DisplayName(Unk96_displayName)]
            public virtual float Unk96 {
                get => Unk96_raw;
                set {
                    if (Unk96_raw == value) return;
                    Unk96_raw = value;
                    ChangedItems.Add(nameof(Unk96));
                    OnPropertyChanged(nameof(Unk96));
                }
            }

            [DisplayName("Offset")]
            public long Unk96_offset { get; private set; }

            protected float Unk97_raw;
            public const string Unk97_displayName = "Unk97";
            public const int Unk97_sortIndex = 6400;
            [SortOrder(Unk97_sortIndex)]
            [DisplayName(Unk97_displayName)]
            public virtual float Unk97 {
                get => Unk97_raw;
                set {
                    if (Unk97_raw == value) return;
                    Unk97_raw = value;
                    ChangedItems.Add(nameof(Unk97));
                    OnPropertyChanged(nameof(Unk97));
                }
            }

            [DisplayName("Offset")]
            public long Unk97_offset { get; private set; }

            protected float Unk98_raw;
            public const string Unk98_displayName = "Unk98";
            public const int Unk98_sortIndex = 6450;
            [SortOrder(Unk98_sortIndex)]
            [DisplayName(Unk98_displayName)]
            public virtual float Unk98 {
                get => Unk98_raw;
                set {
                    if (Unk98_raw == value) return;
                    Unk98_raw = value;
                    ChangedItems.Add(nameof(Unk98));
                    OnPropertyChanged(nameof(Unk98));
                }
            }

            [DisplayName("Offset")]
            public long Unk98_offset { get; private set; }

            protected float Unk99_raw;
            public const string Unk99_displayName = "Unk99";
            public const int Unk99_sortIndex = 6500;
            [SortOrder(Unk99_sortIndex)]
            [DisplayName(Unk99_displayName)]
            public virtual float Unk99 {
                get => Unk99_raw;
                set {
                    if (Unk99_raw == value) return;
                    Unk99_raw = value;
                    ChangedItems.Add(nameof(Unk99));
                    OnPropertyChanged(nameof(Unk99));
                }
            }

            [DisplayName("Offset")]
            public long Unk99_offset { get; private set; }

            protected float Unk100_raw;
            public const string Unk100_displayName = "Unk100";
            public const int Unk100_sortIndex = 6550;
            [SortOrder(Unk100_sortIndex)]
            [DisplayName(Unk100_displayName)]
            public virtual float Unk100 {
                get => Unk100_raw;
                set {
                    if (Unk100_raw == value) return;
                    Unk100_raw = value;
                    ChangedItems.Add(nameof(Unk100));
                    OnPropertyChanged(nameof(Unk100));
                }
            }

            [DisplayName("Offset")]
            public long Unk100_offset { get; private set; }

            protected float Unk101_raw;
            public const string Unk101_displayName = "Unk101";
            public const int Unk101_sortIndex = 6600;
            [SortOrder(Unk101_sortIndex)]
            [DisplayName(Unk101_displayName)]
            public virtual float Unk101 {
                get => Unk101_raw;
                set {
                    if (Unk101_raw == value) return;
                    Unk101_raw = value;
                    ChangedItems.Add(nameof(Unk101));
                    OnPropertyChanged(nameof(Unk101));
                }
            }

            [DisplayName("Offset")]
            public long Unk101_offset { get; private set; }

            protected float Unk102_raw;
            public const string Unk102_displayName = "Unk102";
            public const int Unk102_sortIndex = 6650;
            [SortOrder(Unk102_sortIndex)]
            [DisplayName(Unk102_displayName)]
            public virtual float Unk102 {
                get => Unk102_raw;
                set {
                    if (Unk102_raw == value) return;
                    Unk102_raw = value;
                    ChangedItems.Add(nameof(Unk102));
                    OnPropertyChanged(nameof(Unk102));
                }
            }

            [DisplayName("Offset")]
            public long Unk102_offset { get; private set; }

            protected float Unk103_raw;
            public const string Unk103_displayName = "Unk103";
            public const int Unk103_sortIndex = 6700;
            [SortOrder(Unk103_sortIndex)]
            [DisplayName(Unk103_displayName)]
            public virtual float Unk103 {
                get => Unk103_raw;
                set {
                    if (Unk103_raw == value) return;
                    Unk103_raw = value;
                    ChangedItems.Add(nameof(Unk103));
                    OnPropertyChanged(nameof(Unk103));
                }
            }

            [DisplayName("Offset")]
            public long Unk103_offset { get; private set; }

            protected float Unk104_raw;
            public const string Unk104_displayName = "Unk104";
            public const int Unk104_sortIndex = 6750;
            [SortOrder(Unk104_sortIndex)]
            [DisplayName(Unk104_displayName)]
            public virtual float Unk104 {
                get => Unk104_raw;
                set {
                    if (Unk104_raw == value) return;
                    Unk104_raw = value;
                    ChangedItems.Add(nameof(Unk104));
                    OnPropertyChanged(nameof(Unk104));
                }
            }

            [DisplayName("Offset")]
            public long Unk104_offset { get; private set; }

            protected float Unk105_raw;
            public const string Unk105_displayName = "Unk105";
            public const int Unk105_sortIndex = 6800;
            [SortOrder(Unk105_sortIndex)]
            [DisplayName(Unk105_displayName)]
            public virtual float Unk105 {
                get => Unk105_raw;
                set {
                    if (Unk105_raw == value) return;
                    Unk105_raw = value;
                    ChangedItems.Add(nameof(Unk105));
                    OnPropertyChanged(nameof(Unk105));
                }
            }

            [DisplayName("Offset")]
            public long Unk105_offset { get; private set; }

            protected byte Deathcream_Fishing_rumble_starts_here__raw;
            public const string Deathcream_Fishing_rumble_starts_here__displayName = "Deathcream: Fishing rumble starts here.";
            public const int Deathcream_Fishing_rumble_starts_here__sortIndex = 6850;
            [SortOrder(Deathcream_Fishing_rumble_starts_here__sortIndex)]
            [DisplayName(Deathcream_Fishing_rumble_starts_here__displayName)]
            public virtual byte Deathcream_Fishing_rumble_starts_here_ {
                get => Deathcream_Fishing_rumble_starts_here__raw;
                set {
                    if (Deathcream_Fishing_rumble_starts_here__raw == value) return;
                    Deathcream_Fishing_rumble_starts_here__raw = value;
                    ChangedItems.Add(nameof(Deathcream_Fishing_rumble_starts_here_));
                    OnPropertyChanged(nameof(Deathcream_Fishing_rumble_starts_here_));
                }
            }

            [DisplayName("Offset")]
            public long Deathcream_Fishing_rumble_starts_here__offset { get; private set; }

            public const int lastSortIndex = 6900;

            public static ObservableMhwStructCollection<Item_Params_1_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Item_Params_1_>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Item_Params_1_ LoadData(BinaryReader reader, ulong i) {
                var data = new Item_Params_1_();
                data.Index = i;
                data.Powder_Radius_offset = reader.BaseStream.Position;
                data.Powder_Radius_raw = reader.ReadSingle();
                data.Potion_Power_offset = reader.BaseStream.Position;
                data.Potion_Power_raw = reader.ReadUInt32();
                data.Unk2_offset = reader.BaseStream.Position;
                data.Unk2_raw = reader.ReadSingle();
                data.Unk3_offset = reader.BaseStream.Position;
                data.Unk3_raw = reader.ReadSingle();
                data.Unk4_offset = reader.BaseStream.Position;
                data.Unk4_raw = reader.ReadSingle();
                data.Mega_Potion_Power_offset = reader.BaseStream.Position;
                data.Mega_Potion_Power_raw = reader.ReadUInt32();
                data.Unk5_offset = reader.BaseStream.Position;
                data.Unk5_raw = reader.ReadSingle();
                data.Unk6_offset = reader.BaseStream.Position;
                data.Unk6_raw = reader.ReadSingle();
                data.Unk7_offset = reader.BaseStream.Position;
                data.Unk7_raw = reader.ReadSingle();
                data.Nutrients_Power_offset = reader.BaseStream.Position;
                data.Nutrients_Power_raw = reader.ReadByte();
                data.Mega_Nutrients_Power_offset = reader.BaseStream.Position;
                data.Mega_Nutrients_Power_raw = reader.ReadByte();
                data.Unk9_offset = reader.BaseStream.Position;
                data.Unk9_raw = reader.ReadByte();
                data.Mega_Dash_Juice_Stamina_Power_offset = reader.BaseStream.Position;
                data.Mega_Dash_Juice_Stamina_Power_raw = reader.ReadSingle();
                data.Dash_Juice_Stamina_Power_offset = reader.BaseStream.Position;
                data.Dash_Juice_Stamina_Power_raw = reader.ReadSingle();
                data.Both_Dash_Juice_Duration_offset = reader.BaseStream.Position;
                data.Both_Dash_Juice_Duration_raw = reader.ReadUInt16();
                data.Both_Dash_Juice_Power_offset = reader.BaseStream.Position;
                data.Both_Dash_Juice_Power_raw = reader.ReadByte();
                data.Immunizer_Power_offset = reader.BaseStream.Position;
                data.Immunizer_Power_raw = reader.ReadSingle();
                data.Immunizer_Duration_offset = reader.BaseStream.Position;
                data.Immunizer_Duration_raw = reader.ReadUInt16();
                data.Astera_Jerky_Power_offset = reader.BaseStream.Position;
                data.Astera_Jerky_Power_raw = reader.ReadSingle();
                data.Astera_Jerky_Duration_offset = reader.BaseStream.Position;
                data.Astera_Jerky_Duration_raw = reader.ReadUInt16();
                data.Herbal_Medicine_Power_offset = reader.BaseStream.Position;
                data.Herbal_Medicine_Power_raw = reader.ReadUInt16();
                data.Sushifish_Scale_Power_offset = reader.BaseStream.Position;
                data.Sushifish_Scale_Power_raw = reader.ReadUInt32();
                data.Great_Sushifish_Scale_Power_offset = reader.BaseStream.Position;
                data.Great_Sushifish_Scale_Power_raw = reader.ReadUInt32();
                data.Great_Sushifish_Scale_Duration_offset = reader.BaseStream.Position;
                data.Great_Sushifish_Scale_Duration_raw = reader.ReadSingle();
                data.Cool_Drink_Duration_offset = reader.BaseStream.Position;
                data.Cool_Drink_Duration_raw = reader.ReadUInt16();
                data.Hot_Drink_Duration_offset = reader.BaseStream.Position;
                data.Hot_Drink_Duration_raw = reader.ReadUInt16();
                data.Might_Seed_Duration_offset = reader.BaseStream.Position;
                data.Might_Seed_Duration_raw = reader.ReadUInt16();
                data.Might_Seed_Power_offset = reader.BaseStream.Position;
                data.Might_Seed_Power_raw = reader.ReadUInt16();
                data.Might_Pill_Duration_offset = reader.BaseStream.Position;
                data.Might_Pill_Duration_raw = reader.ReadUInt16();
                data.Might_Pill_Power_offset = reader.BaseStream.Position;
                data.Might_Pill_Power_raw = reader.ReadUInt16();
                data.Adamant_Seed_Duration_offset = reader.BaseStream.Position;
                data.Adamant_Seed_Duration_raw = reader.ReadUInt16();
                data.Adamant_Seed_Power_offset = reader.BaseStream.Position;
                data.Adamant_Seed_Power_raw = reader.ReadUInt16();
                data.Adamant_Pill_Duration_offset = reader.BaseStream.Position;
                data.Adamant_Pill_Duration_raw = reader.ReadUInt16();
                data.Adamant_Pill_Power_offset = reader.BaseStream.Position;
                data.Adamant_Pill_Power_raw = reader.ReadSingle();
                data.Demondrug_Power_offset = reader.BaseStream.Position;
                data.Demondrug_Power_raw = reader.ReadByte();
                data.Mega_Demondrug_Power_offset = reader.BaseStream.Position;
                data.Mega_Demondrug_Power_raw = reader.ReadByte();
                data.Armorskin_Power_offset = reader.BaseStream.Position;
                data.Armorskin_Power_raw = reader.ReadByte();
                data.Mega_Armorskin_Power_offset = reader.BaseStream.Position;
                data.Mega_Armorskin_Power_raw = reader.ReadByte();
                data.Unk16_offset = reader.BaseStream.Position;
                data.Unk16_raw = reader.ReadUInt16();
                data.Lifepowder_Power_offset = reader.BaseStream.Position;
                data.Lifepowder_Power_raw = reader.ReadUInt16();
                data.Dust_of_Life_Power_offset = reader.BaseStream.Position;
                data.Dust_of_Life_Power_raw = reader.ReadUInt16();
                data.Herbal_Powder_Power_offset = reader.BaseStream.Position;
                data.Herbal_Powder_Power_raw = reader.ReadUInt16();
                data.Demon_Powder_Power_offset = reader.BaseStream.Position;
                data.Demon_Powder_Power_raw = reader.ReadUInt16();
                data.Demon_Powder_Duration_offset = reader.BaseStream.Position;
                data.Demon_Powder_Duration_raw = reader.ReadUInt16();
                data.Hardshell_Powder_Power_offset = reader.BaseStream.Position;
                data.Hardshell_Powder_Power_raw = reader.ReadUInt16();
                data.Hardshell_Powder_Duration_offset = reader.BaseStream.Position;
                data.Hardshell_Powder_Duration_raw = reader.ReadUInt16();
                data.Demon_Ammo_Power_offset = reader.BaseStream.Position;
                data.Demon_Ammo_Power_raw = reader.ReadUInt16();
                data.Demon_Ammo_Duration_offset = reader.BaseStream.Position;
                data.Demon_Ammo_Duration_raw = reader.ReadUInt16();
                data.Armor_Ammo_Power_offset = reader.BaseStream.Position;
                data.Armor_Ammo_Power_raw = reader.ReadUInt16();
                data.Armor_Ammo_Duration_offset = reader.BaseStream.Position;
                data.Armor_Ammo_Duration_raw = reader.ReadUInt16();
                data.Ration_Power_offset = reader.BaseStream.Position;
                data.Ration_Power_raw = reader.ReadUInt16();
                data.Well_Done_Steak_Multiplier_offset = reader.BaseStream.Position;
                data.Well_Done_Steak_Multiplier_raw = reader.ReadUInt32();
                data.Well_Done_Steak_Stamina_Bonus_offset = reader.BaseStream.Position;
                data.Well_Done_Steak_Stamina_Bonus_raw = reader.ReadSingle();
                data.Unk23_offset = reader.BaseStream.Position;
                data.Unk23_raw = reader.ReadSingle();
                data.Unk24_offset = reader.BaseStream.Position;
                data.Unk24_raw = reader.ReadSingle();
                data.Burnt_Meat_Stamina_Recovery_offset = reader.BaseStream.Position;
                data.Burnt_Meat_Stamina_Recovery_raw = reader.ReadUInt16();
                data.Unk26_offset = reader.BaseStream.Position;
                data.Unk26_raw = reader.ReadInt16();
                data.Unk27_offset = reader.BaseStream.Position;
                data.Unk27_raw = reader.ReadByte();
                data.Unk28_offset = reader.BaseStream.Position;
                data.Unk28_raw = reader.ReadSingle();
                data.Unk29_offset = reader.BaseStream.Position;
                data.Unk29_raw = reader.ReadSingle();
                data.Unk30_offset = reader.BaseStream.Position;
                data.Unk30_raw = reader.ReadSingle();
                data.Unk31_offset = reader.BaseStream.Position;
                data.Unk31_raw = reader.ReadSingle();
                data.Unk32_offset = reader.BaseStream.Position;
                data.Unk32_raw = reader.ReadSingle();
                data.Unk33_offset = reader.BaseStream.Position;
                data.Unk33_raw = reader.ReadSingle();
                data.Unk34_offset = reader.BaseStream.Position;
                data.Unk34_raw = reader.ReadSingle();
                data.Unk35_offset = reader.BaseStream.Position;
                data.Unk35_raw = reader.ReadSingle();
                data.Unk36_offset = reader.BaseStream.Position;
                data.Unk36_raw = reader.ReadSingle();
                data.Unk37_offset = reader.BaseStream.Position;
                data.Unk37_raw = reader.ReadSingle();
                data.Unk38_offset = reader.BaseStream.Position;
                data.Unk38_raw = reader.ReadSingle();
                data.Whetstone_Sharpness_Restored_offset = reader.BaseStream.Position;
                data.Whetstone_Sharpness_Restored_raw = reader.ReadUInt32();
                data.Whetstone_Cycles_offset = reader.BaseStream.Position;
                data.Whetstone_Cycles_raw = reader.ReadUInt32();
                data.Whetfish_Scale_Sharpness_Restored_offset = reader.BaseStream.Position;
                data.Whetfish_Scale_Sharpness_Restored_raw = reader.ReadUInt32();
                data.Whetfish_Scale_Cycles_offset = reader.BaseStream.Position;
                data.Whetfish_Scale_Cycles_raw = reader.ReadByte();
                data.Whetfish_Scale_Plus_Cycles_offset = reader.BaseStream.Position;
                data.Whetfish_Scale_Plus_Cycles_raw = reader.ReadByte();
                data.Whetfish_Scale_Consume__offset = reader.BaseStream.Position;
                data.Whetfish_Scale_Consume__raw = reader.ReadByte();
                data.Powertalon_Power_offset = reader.BaseStream.Position;
                data.Powertalon_Power_raw = reader.ReadByte();
                data.Powercharm_Power_offset = reader.BaseStream.Position;
                data.Powercharm_Power_raw = reader.ReadByte();
                data.Armortalon_Power_offset = reader.BaseStream.Position;
                data.Armortalon_Power_raw = reader.ReadByte();
                data.Armorcharm_Power_offset = reader.BaseStream.Position;
                data.Armorcharm_Power_raw = reader.ReadByte();
                data.Unk49_offset = reader.BaseStream.Position;
                data.Unk49_raw = reader.ReadByte();
                data.Unk50_offset = reader.BaseStream.Position;
                data.Unk50_raw = reader.ReadSingle();
                data.Unk51_offset = reader.BaseStream.Position;
                data.Unk51_raw = reader.ReadSingle();
                data.Unk52_offset = reader.BaseStream.Position;
                data.Unk52_raw = reader.ReadSingle();
                data.Unk53_offset = reader.BaseStream.Position;
                data.Unk53_raw = reader.ReadSingle();
                data.Unk54_offset = reader.BaseStream.Position;
                data.Unk54_raw = reader.ReadSingle();
                data.Unk55_offset = reader.BaseStream.Position;
                data.Unk55_raw = reader.ReadSingle();
                data.Unk56_offset = reader.BaseStream.Position;
                data.Unk56_raw = reader.ReadSingle();
                data.Unk57_offset = reader.BaseStream.Position;
                data.Unk57_raw = reader.ReadSingle();
                data.Unk58_offset = reader.BaseStream.Position;
                data.Unk58_raw = reader.ReadSingle();
                data.Unk59_offset = reader.BaseStream.Position;
                data.Unk59_raw = reader.ReadSingle();
                data.Unk60_offset = reader.BaseStream.Position;
                data.Unk60_raw = reader.ReadSingle();
                data.Unk61_offset = reader.BaseStream.Position;
                data.Unk61_raw = reader.ReadSingle();
                data.Unk62_offset = reader.BaseStream.Position;
                data.Unk62_raw = reader.ReadSingle();
                data.Unk63_offset = reader.BaseStream.Position;
                data.Unk63_raw = reader.ReadSingle();
                data.Unk64_offset = reader.BaseStream.Position;
                data.Unk64_raw = reader.ReadSingle();
                data.Unk65_offset = reader.BaseStream.Position;
                data.Unk65_raw = reader.ReadSingle();
                data.Unk66_offset = reader.BaseStream.Position;
                data.Unk66_raw = reader.ReadSingle();
                data.Unk67_offset = reader.BaseStream.Position;
                data.Unk67_raw = reader.ReadSingle();
                data.Unk68_offset = reader.BaseStream.Position;
                data.Unk68_raw = reader.ReadSingle();
                data.Unk69_offset = reader.BaseStream.Position;
                data.Unk69_raw = reader.ReadSingle();
                data.Unk70_offset = reader.BaseStream.Position;
                data.Unk70_raw = reader.ReadSingle();
                data.Unk71_offset = reader.BaseStream.Position;
                data.Unk71_raw = reader.ReadSingle();
                data.Unk72_offset = reader.BaseStream.Position;
                data.Unk72_raw = reader.ReadSingle();
                data.Unk73_offset = reader.BaseStream.Position;
                data.Unk73_raw = reader.ReadSingle();
                data.Unk74_offset = reader.BaseStream.Position;
                data.Unk74_raw = reader.ReadSingle();
                data.Unk75_offset = reader.BaseStream.Position;
                data.Unk75_raw = reader.ReadSingle();
                data.Unk76_offset = reader.BaseStream.Position;
                data.Unk76_raw = reader.ReadSingle();
                data.Unk77_offset = reader.BaseStream.Position;
                data.Unk77_raw = reader.ReadSingle();
                data.Unk78_offset = reader.BaseStream.Position;
                data.Unk78_raw = reader.ReadSingle();
                data.Unk79_offset = reader.BaseStream.Position;
                data.Unk79_raw = reader.ReadSingle();
                data.Unk80_offset = reader.BaseStream.Position;
                data.Unk80_raw = reader.ReadSingle();
                data.Unk81_offset = reader.BaseStream.Position;
                data.Unk81_raw = reader.ReadSingle();
                data.Unk82_offset = reader.BaseStream.Position;
                data.Unk82_raw = reader.ReadSingle();
                data.Unk83_offset = reader.BaseStream.Position;
                data.Unk83_raw = reader.ReadSingle();
                data.Unk84_offset = reader.BaseStream.Position;
                data.Unk84_raw = reader.ReadSingle();
                data.Unk85_offset = reader.BaseStream.Position;
                data.Unk85_raw = reader.ReadSingle();
                data.Unk86_offset = reader.BaseStream.Position;
                data.Unk86_raw = reader.ReadSingle();
                data.Unk87_offset = reader.BaseStream.Position;
                data.Unk87_raw = reader.ReadSingle();
                data.Unk88_offset = reader.BaseStream.Position;
                data.Unk88_raw = reader.ReadSingle();
                data.Unk89_offset = reader.BaseStream.Position;
                data.Unk89_raw = reader.ReadSingle();
                data.Unk90_offset = reader.BaseStream.Position;
                data.Unk90_raw = reader.ReadSingle();
                data.Unk91_offset = reader.BaseStream.Position;
                data.Unk91_raw = reader.ReadSingle();
                data.Unk92_offset = reader.BaseStream.Position;
                data.Unk92_raw = reader.ReadSingle();
                data.Unk93_offset = reader.BaseStream.Position;
                data.Unk93_raw = reader.ReadSingle();
                data.Unk94_offset = reader.BaseStream.Position;
                data.Unk94_raw = reader.ReadSingle();
                data.Unk95_offset = reader.BaseStream.Position;
                data.Unk95_raw = reader.ReadSingle();
                data.Unk96_offset = reader.BaseStream.Position;
                data.Unk96_raw = reader.ReadSingle();
                data.Unk97_offset = reader.BaseStream.Position;
                data.Unk97_raw = reader.ReadSingle();
                data.Unk98_offset = reader.BaseStream.Position;
                data.Unk98_raw = reader.ReadSingle();
                data.Unk99_offset = reader.BaseStream.Position;
                data.Unk99_raw = reader.ReadSingle();
                data.Unk100_offset = reader.BaseStream.Position;
                data.Unk100_raw = reader.ReadSingle();
                data.Unk101_offset = reader.BaseStream.Position;
                data.Unk101_raw = reader.ReadSingle();
                data.Unk102_offset = reader.BaseStream.Position;
                data.Unk102_raw = reader.ReadSingle();
                data.Unk103_offset = reader.BaseStream.Position;
                data.Unk103_raw = reader.ReadSingle();
                data.Unk104_offset = reader.BaseStream.Position;
                data.Unk104_raw = reader.ReadSingle();
                data.Unk105_offset = reader.BaseStream.Position;
                data.Unk105_raw = reader.ReadSingle();
                data.Deathcream_Fishing_rumble_starts_here__offset = reader.BaseStream.Position;
                data.Deathcream_Fishing_rumble_starts_here__raw = reader.ReadByte();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Powder_Radius_raw);
                writer.Write(Potion_Power_raw);
                writer.Write(Unk2_raw);
                writer.Write(Unk3_raw);
                writer.Write(Unk4_raw);
                writer.Write(Mega_Potion_Power_raw);
                writer.Write(Unk5_raw);
                writer.Write(Unk6_raw);
                writer.Write(Unk7_raw);
                writer.Write(Nutrients_Power_raw);
                writer.Write(Mega_Nutrients_Power_raw);
                writer.Write(Unk9_raw);
                writer.Write(Mega_Dash_Juice_Stamina_Power_raw);
                writer.Write(Dash_Juice_Stamina_Power_raw);
                writer.Write(Both_Dash_Juice_Duration_raw);
                writer.Write(Both_Dash_Juice_Power_raw);
                writer.Write(Immunizer_Power_raw);
                writer.Write(Immunizer_Duration_raw);
                writer.Write(Astera_Jerky_Power_raw);
                writer.Write(Astera_Jerky_Duration_raw);
                writer.Write(Herbal_Medicine_Power_raw);
                writer.Write(Sushifish_Scale_Power_raw);
                writer.Write(Great_Sushifish_Scale_Power_raw);
                writer.Write(Great_Sushifish_Scale_Duration_raw);
                writer.Write(Cool_Drink_Duration_raw);
                writer.Write(Hot_Drink_Duration_raw);
                writer.Write(Might_Seed_Duration_raw);
                writer.Write(Might_Seed_Power_raw);
                writer.Write(Might_Pill_Duration_raw);
                writer.Write(Might_Pill_Power_raw);
                writer.Write(Adamant_Seed_Duration_raw);
                writer.Write(Adamant_Seed_Power_raw);
                writer.Write(Adamant_Pill_Duration_raw);
                writer.Write(Adamant_Pill_Power_raw);
                writer.Write(Demondrug_Power_raw);
                writer.Write(Mega_Demondrug_Power_raw);
                writer.Write(Armorskin_Power_raw);
                writer.Write(Mega_Armorskin_Power_raw);
                writer.Write(Unk16_raw);
                writer.Write(Lifepowder_Power_raw);
                writer.Write(Dust_of_Life_Power_raw);
                writer.Write(Herbal_Powder_Power_raw);
                writer.Write(Demon_Powder_Power_raw);
                writer.Write(Demon_Powder_Duration_raw);
                writer.Write(Hardshell_Powder_Power_raw);
                writer.Write(Hardshell_Powder_Duration_raw);
                writer.Write(Demon_Ammo_Power_raw);
                writer.Write(Demon_Ammo_Duration_raw);
                writer.Write(Armor_Ammo_Power_raw);
                writer.Write(Armor_Ammo_Duration_raw);
                writer.Write(Ration_Power_raw);
                writer.Write(Well_Done_Steak_Multiplier_raw);
                writer.Write(Well_Done_Steak_Stamina_Bonus_raw);
                writer.Write(Unk23_raw);
                writer.Write(Unk24_raw);
                writer.Write(Burnt_Meat_Stamina_Recovery_raw);
                writer.Write(Unk26_raw);
                writer.Write(Unk27_raw);
                writer.Write(Unk28_raw);
                writer.Write(Unk29_raw);
                writer.Write(Unk30_raw);
                writer.Write(Unk31_raw);
                writer.Write(Unk32_raw);
                writer.Write(Unk33_raw);
                writer.Write(Unk34_raw);
                writer.Write(Unk35_raw);
                writer.Write(Unk36_raw);
                writer.Write(Unk37_raw);
                writer.Write(Unk38_raw);
                writer.Write(Whetstone_Sharpness_Restored_raw);
                writer.Write(Whetstone_Cycles_raw);
                writer.Write(Whetfish_Scale_Sharpness_Restored_raw);
                writer.Write(Whetfish_Scale_Cycles_raw);
                writer.Write(Whetfish_Scale_Plus_Cycles_raw);
                writer.Write(Whetfish_Scale_Consume__raw);
                writer.Write(Powertalon_Power_raw);
                writer.Write(Powercharm_Power_raw);
                writer.Write(Armortalon_Power_raw);
                writer.Write(Armorcharm_Power_raw);
                writer.Write(Unk49_raw);
                writer.Write(Unk50_raw);
                writer.Write(Unk51_raw);
                writer.Write(Unk52_raw);
                writer.Write(Unk53_raw);
                writer.Write(Unk54_raw);
                writer.Write(Unk55_raw);
                writer.Write(Unk56_raw);
                writer.Write(Unk57_raw);
                writer.Write(Unk58_raw);
                writer.Write(Unk59_raw);
                writer.Write(Unk60_raw);
                writer.Write(Unk61_raw);
                writer.Write(Unk62_raw);
                writer.Write(Unk63_raw);
                writer.Write(Unk64_raw);
                writer.Write(Unk65_raw);
                writer.Write(Unk66_raw);
                writer.Write(Unk67_raw);
                writer.Write(Unk68_raw);
                writer.Write(Unk69_raw);
                writer.Write(Unk70_raw);
                writer.Write(Unk71_raw);
                writer.Write(Unk72_raw);
                writer.Write(Unk73_raw);
                writer.Write(Unk74_raw);
                writer.Write(Unk75_raw);
                writer.Write(Unk76_raw);
                writer.Write(Unk77_raw);
                writer.Write(Unk78_raw);
                writer.Write(Unk79_raw);
                writer.Write(Unk80_raw);
                writer.Write(Unk81_raw);
                writer.Write(Unk82_raw);
                writer.Write(Unk83_raw);
                writer.Write(Unk84_raw);
                writer.Write(Unk85_raw);
                writer.Write(Unk86_raw);
                writer.Write(Unk87_raw);
                writer.Write(Unk88_raw);
                writer.Write(Unk89_raw);
                writer.Write(Unk90_raw);
                writer.Write(Unk91_raw);
                writer.Write(Unk92_raw);
                writer.Write(Unk93_raw);
                writer.Write(Unk94_raw);
                writer.Write(Unk95_raw);
                writer.Write(Unk96_raw);
                writer.Write(Unk97_raw);
                writer.Write(Unk98_raw);
                writer.Write(Unk99_raw);
                writer.Write(Unk100_raw);
                writer.Write(Unk101_raw);
                writer.Write(Unk102_raw);
                writer.Write(Unk103_raw);
                writer.Write(Unk104_raw);
                writer.Write(Unk105_raw);
                writer.Write(Deathcream_Fishing_rumble_starts_here__raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Powder Radius", "Powder_Radius", "Powder_Radius_offset"),
                    new MultiStructItemCustomView(this, "Potion Power", "Potion_Power", "Potion_Power_offset"),
                    new MultiStructItemCustomView(this, "Unk2", "Unk2", "Unk2_offset"),
                    new MultiStructItemCustomView(this, "Unk3", "Unk3", "Unk3_offset"),
                    new MultiStructItemCustomView(this, "Unk4", "Unk4", "Unk4_offset"),
                    new MultiStructItemCustomView(this, "Mega Potion Power", "Mega_Potion_Power", "Mega_Potion_Power_offset"),
                    new MultiStructItemCustomView(this, "Unk5", "Unk5", "Unk5_offset"),
                    new MultiStructItemCustomView(this, "Unk6", "Unk6", "Unk6_offset"),
                    new MultiStructItemCustomView(this, "Unk7", "Unk7", "Unk7_offset"),
                    new MultiStructItemCustomView(this, "Nutrients Power", "Nutrients_Power", "Nutrients_Power_offset"),
                    new MultiStructItemCustomView(this, "Mega Nutrients Power", "Mega_Nutrients_Power", "Mega_Nutrients_Power_offset"),
                    new MultiStructItemCustomView(this, "Unk9", "Unk9", "Unk9_offset"),
                    new MultiStructItemCustomView(this, "Mega Dash Juice Stamina Power", "Mega_Dash_Juice_Stamina_Power", "Mega_Dash_Juice_Stamina_Power_offset"),
                    new MultiStructItemCustomView(this, "Dash Juice Stamina Power", "Dash_Juice_Stamina_Power", "Dash_Juice_Stamina_Power_offset"),
                    new MultiStructItemCustomView(this, "Both Dash Juice Duration", "Both_Dash_Juice_Duration", "Both_Dash_Juice_Duration_offset"),
                    new MultiStructItemCustomView(this, "Both Dash Juice Power", "Both_Dash_Juice_Power", "Both_Dash_Juice_Power_offset"),
                    new MultiStructItemCustomView(this, "Immunizer Power", "Immunizer_Power", "Immunizer_Power_offset"),
                    new MultiStructItemCustomView(this, "Immunizer Duration", "Immunizer_Duration", "Immunizer_Duration_offset"),
                    new MultiStructItemCustomView(this, "Astera Jerky Power", "Astera_Jerky_Power", "Astera_Jerky_Power_offset"),
                    new MultiStructItemCustomView(this, "Astera Jerky Duration", "Astera_Jerky_Duration", "Astera_Jerky_Duration_offset"),
                    new MultiStructItemCustomView(this, "Herbal Medicine Power", "Herbal_Medicine_Power", "Herbal_Medicine_Power_offset"),
                    new MultiStructItemCustomView(this, "Sushifish Scale Power", "Sushifish_Scale_Power", "Sushifish_Scale_Power_offset"),
                    new MultiStructItemCustomView(this, "Great Sushifish Scale Power", "Great_Sushifish_Scale_Power", "Great_Sushifish_Scale_Power_offset"),
                    new MultiStructItemCustomView(this, "Great Sushifish Scale Duration", "Great_Sushifish_Scale_Duration", "Great_Sushifish_Scale_Duration_offset"),
                    new MultiStructItemCustomView(this, "Cool Drink Duration", "Cool_Drink_Duration", "Cool_Drink_Duration_offset"),
                    new MultiStructItemCustomView(this, "Hot Drink Duration", "Hot_Drink_Duration", "Hot_Drink_Duration_offset"),
                    new MultiStructItemCustomView(this, "Might Seed Duration", "Might_Seed_Duration", "Might_Seed_Duration_offset"),
                    new MultiStructItemCustomView(this, "Might Seed Power", "Might_Seed_Power", "Might_Seed_Power_offset"),
                    new MultiStructItemCustomView(this, "Might Pill Duration", "Might_Pill_Duration", "Might_Pill_Duration_offset"),
                    new MultiStructItemCustomView(this, "Might Pill Power", "Might_Pill_Power", "Might_Pill_Power_offset"),
                    new MultiStructItemCustomView(this, "Adamant Seed Duration", "Adamant_Seed_Duration", "Adamant_Seed_Duration_offset"),
                    new MultiStructItemCustomView(this, "Adamant Seed Power", "Adamant_Seed_Power", "Adamant_Seed_Power_offset"),
                    new MultiStructItemCustomView(this, "Adamant Pill Duration", "Adamant_Pill_Duration", "Adamant_Pill_Duration_offset"),
                    new MultiStructItemCustomView(this, "Adamant Pill Power", "Adamant_Pill_Power", "Adamant_Pill_Power_offset"),
                    new MultiStructItemCustomView(this, "Demondrug Power", "Demondrug_Power", "Demondrug_Power_offset"),
                    new MultiStructItemCustomView(this, "Mega Demondrug Power", "Mega_Demondrug_Power", "Mega_Demondrug_Power_offset"),
                    new MultiStructItemCustomView(this, "Armorskin Power", "Armorskin_Power", "Armorskin_Power_offset"),
                    new MultiStructItemCustomView(this, "Mega Armorskin Power", "Mega_Armorskin_Power", "Mega_Armorskin_Power_offset"),
                    new MultiStructItemCustomView(this, "Unk16", "Unk16", "Unk16_offset"),
                    new MultiStructItemCustomView(this, "Lifepowder Power", "Lifepowder_Power", "Lifepowder_Power_offset"),
                    new MultiStructItemCustomView(this, "Dust of Life Power", "Dust_of_Life_Power", "Dust_of_Life_Power_offset"),
                    new MultiStructItemCustomView(this, "Herbal Powder Power", "Herbal_Powder_Power", "Herbal_Powder_Power_offset"),
                    new MultiStructItemCustomView(this, "Demon Powder Power", "Demon_Powder_Power", "Demon_Powder_Power_offset"),
                    new MultiStructItemCustomView(this, "Demon Powder Duration", "Demon_Powder_Duration", "Demon_Powder_Duration_offset"),
                    new MultiStructItemCustomView(this, "Hardshell Powder Power", "Hardshell_Powder_Power", "Hardshell_Powder_Power_offset"),
                    new MultiStructItemCustomView(this, "Hardshell Powder Duration", "Hardshell_Powder_Duration", "Hardshell_Powder_Duration_offset"),
                    new MultiStructItemCustomView(this, "Demon Ammo Power", "Demon_Ammo_Power", "Demon_Ammo_Power_offset"),
                    new MultiStructItemCustomView(this, "Demon Ammo Duration", "Demon_Ammo_Duration", "Demon_Ammo_Duration_offset"),
                    new MultiStructItemCustomView(this, "Armor Ammo Power", "Armor_Ammo_Power", "Armor_Ammo_Power_offset"),
                    new MultiStructItemCustomView(this, "Armor Ammo Duration", "Armor_Ammo_Duration", "Armor_Ammo_Duration_offset"),
                    new MultiStructItemCustomView(this, "Ration Power", "Ration_Power", "Ration_Power_offset"),
                    new MultiStructItemCustomView(this, "Well Done Steak Multiplier", "Well_Done_Steak_Multiplier", "Well_Done_Steak_Multiplier_offset"),
                    new MultiStructItemCustomView(this, "Well Done Steak Stamina Bonus", "Well_Done_Steak_Stamina_Bonus", "Well_Done_Steak_Stamina_Bonus_offset"),
                    new MultiStructItemCustomView(this, "Unk23", "Unk23", "Unk23_offset"),
                    new MultiStructItemCustomView(this, "Unk24", "Unk24", "Unk24_offset"),
                    new MultiStructItemCustomView(this, "Burnt Meat Stamina Recovery", "Burnt_Meat_Stamina_Recovery", "Burnt_Meat_Stamina_Recovery_offset"),
                    new MultiStructItemCustomView(this, "Unk26", "Unk26", "Unk26_offset"),
                    new MultiStructItemCustomView(this, "Unk27", "Unk27", "Unk27_offset"),
                    new MultiStructItemCustomView(this, "Unk28", "Unk28", "Unk28_offset"),
                    new MultiStructItemCustomView(this, "Unk29", "Unk29", "Unk29_offset"),
                    new MultiStructItemCustomView(this, "Unk30", "Unk30", "Unk30_offset"),
                    new MultiStructItemCustomView(this, "Unk31", "Unk31", "Unk31_offset"),
                    new MultiStructItemCustomView(this, "Unk32", "Unk32", "Unk32_offset"),
                    new MultiStructItemCustomView(this, "Unk33", "Unk33", "Unk33_offset"),
                    new MultiStructItemCustomView(this, "Unk34", "Unk34", "Unk34_offset"),
                    new MultiStructItemCustomView(this, "Unk35", "Unk35", "Unk35_offset"),
                    new MultiStructItemCustomView(this, "Unk36", "Unk36", "Unk36_offset"),
                    new MultiStructItemCustomView(this, "Unk37", "Unk37", "Unk37_offset"),
                    new MultiStructItemCustomView(this, "Unk38", "Unk38", "Unk38_offset"),
                    new MultiStructItemCustomView(this, "Whetstone Sharpness Restored", "Whetstone_Sharpness_Restored", "Whetstone_Sharpness_Restored_offset"),
                    new MultiStructItemCustomView(this, "Whetstone Cycles", "Whetstone_Cycles", "Whetstone_Cycles_offset"),
                    new MultiStructItemCustomView(this, "Whetfish Scale Sharpness Restored", "Whetfish_Scale_Sharpness_Restored", "Whetfish_Scale_Sharpness_Restored_offset"),
                    new MultiStructItemCustomView(this, "Whetfish Scale Cycles", "Whetfish_Scale_Cycles", "Whetfish_Scale_Cycles_offset"),
                    new MultiStructItemCustomView(this, "Whetfish Scale Plus Cycles", "Whetfish_Scale_Plus_Cycles", "Whetfish_Scale_Plus_Cycles_offset"),
                    new MultiStructItemCustomView(this, "Whetfish Scale Consume %", "Whetfish_Scale_Consume_", "Whetfish_Scale_Consume__offset"),
                    new MultiStructItemCustomView(this, "Powertalon Power", "Powertalon_Power", "Powertalon_Power_offset"),
                    new MultiStructItemCustomView(this, "Powercharm Power", "Powercharm_Power", "Powercharm_Power_offset"),
                    new MultiStructItemCustomView(this, "Armortalon Power", "Armortalon_Power", "Armortalon_Power_offset"),
                    new MultiStructItemCustomView(this, "Armorcharm Power", "Armorcharm_Power", "Armorcharm_Power_offset"),
                    new MultiStructItemCustomView(this, "Unk49", "Unk49", "Unk49_offset"),
                    new MultiStructItemCustomView(this, "Unk50", "Unk50", "Unk50_offset"),
                    new MultiStructItemCustomView(this, "Unk51", "Unk51", "Unk51_offset"),
                    new MultiStructItemCustomView(this, "Unk52", "Unk52", "Unk52_offset"),
                    new MultiStructItemCustomView(this, "Unk53", "Unk53", "Unk53_offset"),
                    new MultiStructItemCustomView(this, "Unk54", "Unk54", "Unk54_offset"),
                    new MultiStructItemCustomView(this, "Unk55", "Unk55", "Unk55_offset"),
                    new MultiStructItemCustomView(this, "Unk56", "Unk56", "Unk56_offset"),
                    new MultiStructItemCustomView(this, "Unk57", "Unk57", "Unk57_offset"),
                    new MultiStructItemCustomView(this, "Unk58", "Unk58", "Unk58_offset"),
                    new MultiStructItemCustomView(this, "Unk59", "Unk59", "Unk59_offset"),
                    new MultiStructItemCustomView(this, "Unk60", "Unk60", "Unk60_offset"),
                    new MultiStructItemCustomView(this, "Unk61", "Unk61", "Unk61_offset"),
                    new MultiStructItemCustomView(this, "Unk62", "Unk62", "Unk62_offset"),
                    new MultiStructItemCustomView(this, "Unk63", "Unk63", "Unk63_offset"),
                    new MultiStructItemCustomView(this, "Unk64", "Unk64", "Unk64_offset"),
                    new MultiStructItemCustomView(this, "Unk65", "Unk65", "Unk65_offset"),
                    new MultiStructItemCustomView(this, "Unk66", "Unk66", "Unk66_offset"),
                    new MultiStructItemCustomView(this, "Unk67", "Unk67", "Unk67_offset"),
                    new MultiStructItemCustomView(this, "Unk68", "Unk68", "Unk68_offset"),
                    new MultiStructItemCustomView(this, "Unk69", "Unk69", "Unk69_offset"),
                    new MultiStructItemCustomView(this, "Unk70", "Unk70", "Unk70_offset"),
                    new MultiStructItemCustomView(this, "Unk71", "Unk71", "Unk71_offset"),
                    new MultiStructItemCustomView(this, "Unk72", "Unk72", "Unk72_offset"),
                    new MultiStructItemCustomView(this, "Unk73", "Unk73", "Unk73_offset"),
                    new MultiStructItemCustomView(this, "Unk74", "Unk74", "Unk74_offset"),
                    new MultiStructItemCustomView(this, "Unk75", "Unk75", "Unk75_offset"),
                    new MultiStructItemCustomView(this, "Unk76", "Unk76", "Unk76_offset"),
                    new MultiStructItemCustomView(this, "Unk77", "Unk77", "Unk77_offset"),
                    new MultiStructItemCustomView(this, "Unk78", "Unk78", "Unk78_offset"),
                    new MultiStructItemCustomView(this, "Unk79", "Unk79", "Unk79_offset"),
                    new MultiStructItemCustomView(this, "Unk80", "Unk80", "Unk80_offset"),
                    new MultiStructItemCustomView(this, "Unk81", "Unk81", "Unk81_offset"),
                    new MultiStructItemCustomView(this, "Unk82", "Unk82", "Unk82_offset"),
                    new MultiStructItemCustomView(this, "Unk83", "Unk83", "Unk83_offset"),
                    new MultiStructItemCustomView(this, "Unk84", "Unk84", "Unk84_offset"),
                    new MultiStructItemCustomView(this, "Unk85", "Unk85", "Unk85_offset"),
                    new MultiStructItemCustomView(this, "Unk86", "Unk86", "Unk86_offset"),
                    new MultiStructItemCustomView(this, "Unk87", "Unk87", "Unk87_offset"),
                    new MultiStructItemCustomView(this, "Unk88", "Unk88", "Unk88_offset"),
                    new MultiStructItemCustomView(this, "Unk89", "Unk89", "Unk89_offset"),
                    new MultiStructItemCustomView(this, "Unk90", "Unk90", "Unk90_offset"),
                    new MultiStructItemCustomView(this, "Unk91", "Unk91", "Unk91_offset"),
                    new MultiStructItemCustomView(this, "Unk92", "Unk92", "Unk92_offset"),
                    new MultiStructItemCustomView(this, "Unk93", "Unk93", "Unk93_offset"),
                    new MultiStructItemCustomView(this, "Unk94", "Unk94", "Unk94_offset"),
                    new MultiStructItemCustomView(this, "Unk95", "Unk95", "Unk95_offset"),
                    new MultiStructItemCustomView(this, "Unk96", "Unk96", "Unk96_offset"),
                    new MultiStructItemCustomView(this, "Unk97", "Unk97", "Unk97_offset"),
                    new MultiStructItemCustomView(this, "Unk98", "Unk98", "Unk98_offset"),
                    new MultiStructItemCustomView(this, "Unk99", "Unk99", "Unk99_offset"),
                    new MultiStructItemCustomView(this, "Unk100", "Unk100", "Unk100_offset"),
                    new MultiStructItemCustomView(this, "Unk101", "Unk101", "Unk101_offset"),
                    new MultiStructItemCustomView(this, "Unk102", "Unk102", "Unk102_offset"),
                    new MultiStructItemCustomView(this, "Unk103", "Unk103", "Unk103_offset"),
                    new MultiStructItemCustomView(this, "Unk104", "Unk104", "Unk104_offset"),
                    new MultiStructItemCustomView(this, "Unk105", "Unk105", "Unk105_offset"),
                    new MultiStructItemCustomView(this, "Deathcream: Fishing rumble starts here.", "Deathcream_Fishing_rumble_starts_here_", "Deathcream_Fishing_rumble_starts_here__offset"),
                };
            }
        }

        public partial class The_Rest : MhwStructItem, IWriteData, IHasChildren {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "The Rest";

            public partial class End_Junk : MhwStructItem, IWriteDataInner<The_Rest> {
                public const ulong FixedSizeCount = 0;
                public const string GridName = "End Junk";

                protected byte Unk_raw;
                public const string Unk_displayName = "Unk";
                public const int Unk_sortIndex = 50;
                [SortOrder(Unk_sortIndex)]
                [DisplayName(Unk_displayName)]
                [IsReadOnly]
                public virtual byte Unk {
                    get => Unk_raw;
                    set {
                        if (Unk_raw == value) return;
                        Unk_raw = value;
                        ChangedItems.Add(nameof(Unk));
                        OnPropertyChanged(nameof(Unk));
                    }
                }

                public const int lastSortIndex = 100;

                public void WriteData(BinaryWriter writer, The_Rest parent) {
                    writer.Write(Unk_raw);
                }
            }

            public const string The_rest_of_the_file_as_bytes__displayName = "The rest of the file as bytes.";
            public const int The_rest_of_the_file_as_bytes__sortIndex = 50;
            [SortOrder(The_rest_of_the_file_as_bytes__sortIndex)]
            [DisplayName(The_rest_of_the_file_as_bytes__displayName)]
            public virtual ObservableCollection<End_Junk> The_rest_of_the_file_as_bytes__raw { get; protected set; }

            public const int lastSortIndex = 100;

            public IEnumerable<F> GetAllEnumerableChildrenOfType<F>() {
                if (typeof(End_Junk).Is(typeof(F)) || typeof(End_Junk).IsGeneric(typeof(F))) {
                    foreach (var item in The_rest_of_the_file_as_bytes__raw.Cast<F>()) {
                        yield return item;
                    }
                }
            }

            public static ObservableMhwStructCollection<The_Rest> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<The_Rest>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static The_Rest LoadData(BinaryReader reader, ulong i) {
                var data = new The_Rest();
                data.Index = i;
                data.The_rest_of_the_file_as_bytes__raw = End_Junk.LoadData(reader, data);
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                foreach (var obj in The_rest_of_the_file_as_bytes__raw) {
                    obj.WriteData(writer, this);
                }
            }
        }

        public override void LoadFile(string targetFile) {
            using var reader = new BinaryReader(OpenFile(targetFile, EncryptionKey), Encoding.UTF8);
            data = new LinkedList<MhwStructDataContainer>();
            var Header_ = new MhwStructDataContainer<Header>(Header.LoadData(reader), typeof(Header));
            data.AddLast(Header_);
            var Item_Params_1__ = new MhwStructDataContainer<Item_Params_1_>(Item_Params_1_.LoadData(reader), typeof(Item_Params_1_));
            data.AddLast(Item_Params_1__);
            var The_Rest_ = new MhwStructDataContainer<The_Rest>(The_Rest.LoadData(reader), typeof(The_Rest));
            data.AddLast(The_Rest_);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Weapons {
    public partial class Wp12Param {
        public override string EncryptionKey => "j1P15gEkgVa7NdFxiqwCPitykHctY2nZPjSaElvqb0eSwcLO1cOlTqqv";

        public partial class W12p_Params_1_ : MhwStructItem {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W12p Params (1)";

            protected char[] Weapon_raw;
            public const string Weapon_displayName = "Weapon";
            public const int Weapon_sortIndex = 50;
            [SortOrder(Weapon_sortIndex)]
            [DisplayName(Weapon_displayName)]
            [IsReadOnly]
            public virtual string Weapon {
                get => (string) new string(Weapon_raw);
                set {
                    if ((string) new string(Weapon_raw) == value) return;
                    Weapon_raw = (char[]) value.ToCharArray(0, 3);
                    OnPropertyChanged(nameof(Weapon));
                }
            }

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
                    OnPropertyChanged(nameof(Unk_1));
                }
            }

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
                    OnPropertyChanged(nameof(Unk_2));
                }
            }

            public static W12p_Params_1_ LoadData(BinaryReader reader) {
                var data = new W12p_Params_1_();
                data.Weapon_raw = reader.ReadChars(4);
                data.Unk_1_raw = reader.ReadUInt32();
                data.Unk_2_raw = reader.ReadUInt32();
                return data;
            }

            public override void WriteData(BinaryWriter writer) {
                writer.Write(Weapon_raw);
                writer.Write(Unk_1_raw);
                writer.Write(Unk_2_raw);
            }
        }

        public partial class Unk_Struct_1 : MhwStructItem {
            public const ulong FixedSizeCount = 20;
            public const string GridName = "Unk Struct 1";

            protected float Unk_1_raw;
            public const string Unk_1_displayName = "Unk 1";
            public const int Unk_1_sortIndex = 50;
            [SortOrder(Unk_1_sortIndex)]
            [DisplayName(Unk_1_displayName)]
            public virtual float Unk_1 {
                get => Unk_1_raw;
                set {
                    if (Unk_1_raw == value) return;
                    Unk_1_raw = value;
                    OnPropertyChanged(nameof(Unk_1));
                }
            }

            protected float Unk_2_raw;
            public const string Unk_2_displayName = "Unk 2";
            public const int Unk_2_sortIndex = 100;
            [SortOrder(Unk_2_sortIndex)]
            [DisplayName(Unk_2_displayName)]
            public virtual float Unk_2 {
                get => Unk_2_raw;
                set {
                    if (Unk_2_raw == value) return;
                    Unk_2_raw = value;
                    OnPropertyChanged(nameof(Unk_2));
                }
            }

            protected byte Unk_3_raw;
            public const string Unk_3_displayName = "Unk 3";
            public const int Unk_3_sortIndex = 150;
            [SortOrder(Unk_3_sortIndex)]
            [DisplayName(Unk_3_displayName)]
            public virtual byte Unk_3 {
                get => Unk_3_raw;
                set {
                    if (Unk_3_raw == value) return;
                    Unk_3_raw = value;
                    OnPropertyChanged(nameof(Unk_3));
                }
            }

            protected float Unk_4_raw;
            public const string Unk_4_displayName = "Unk 4";
            public const int Unk_4_sortIndex = 200;
            [SortOrder(Unk_4_sortIndex)]
            [DisplayName(Unk_4_displayName)]
            public virtual float Unk_4 {
                get => Unk_4_raw;
                set {
                    if (Unk_4_raw == value) return;
                    Unk_4_raw = value;
                    OnPropertyChanged(nameof(Unk_4));
                }
            }

            protected float Unk_5_raw;
            public const string Unk_5_displayName = "Unk 5";
            public const int Unk_5_sortIndex = 250;
            [SortOrder(Unk_5_sortIndex)]
            [DisplayName(Unk_5_displayName)]
            public virtual float Unk_5 {
                get => Unk_5_raw;
                set {
                    if (Unk_5_raw == value) return;
                    Unk_5_raw = value;
                    OnPropertyChanged(nameof(Unk_5));
                }
            }

            public static Unk_Struct_1 LoadData(BinaryReader reader) {
                var data = new Unk_Struct_1();
                data.Unk_1_raw = reader.ReadSingle();
                data.Unk_2_raw = reader.ReadSingle();
                data.Unk_3_raw = reader.ReadByte();
                data.Unk_4_raw = reader.ReadSingle();
                data.Unk_5_raw = reader.ReadSingle();
                return data;
            }

            public override void WriteData(BinaryWriter writer) {
                writer.Write(Unk_1_raw);
                writer.Write(Unk_2_raw);
                writer.Write(Unk_3_raw);
                writer.Write(Unk_4_raw);
                writer.Write(Unk_5_raw);
            }
        }

        public partial class W12p_Params_2_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView> {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W12p Params (2)";

            protected float Unk1_raw;
            public const string Unk1_displayName = "Unk1";
            public const int Unk1_sortIndex = 50;
            [SortOrder(Unk1_sortIndex)]
            [DisplayName(Unk1_displayName)]
            public virtual float Unk1 {
                get => Unk1_raw;
                set {
                    if (Unk1_raw == value) return;
                    Unk1_raw = value;
                    OnPropertyChanged(nameof(Unk1));
                }
            }

            protected float Unk2_raw;
            public const string Unk2_displayName = "Unk2";
            public const int Unk2_sortIndex = 100;
            [SortOrder(Unk2_sortIndex)]
            [DisplayName(Unk2_displayName)]
            public virtual float Unk2 {
                get => Unk2_raw;
                set {
                    if (Unk2_raw == value) return;
                    Unk2_raw = value;
                    OnPropertyChanged(nameof(Unk2));
                }
            }

            protected float Unk3_raw;
            public const string Unk3_displayName = "Unk3";
            public const int Unk3_sortIndex = 150;
            [SortOrder(Unk3_sortIndex)]
            [DisplayName(Unk3_displayName)]
            public virtual float Unk3 {
                get => Unk3_raw;
                set {
                    if (Unk3_raw == value) return;
                    Unk3_raw = value;
                    OnPropertyChanged(nameof(Unk3));
                }
            }

            protected float Unk4_raw;
            public const string Unk4_displayName = "Unk4";
            public const int Unk4_sortIndex = 200;
            [SortOrder(Unk4_sortIndex)]
            [DisplayName(Unk4_displayName)]
            public virtual float Unk4 {
                get => Unk4_raw;
                set {
                    if (Unk4_raw == value) return;
                    Unk4_raw = value;
                    OnPropertyChanged(nameof(Unk4));
                }
            }

            protected float Unk5_raw;
            public const string Unk5_displayName = "Unk5";
            public const int Unk5_sortIndex = 250;
            [SortOrder(Unk5_sortIndex)]
            [DisplayName(Unk5_displayName)]
            public virtual float Unk5 {
                get => Unk5_raw;
                set {
                    if (Unk5_raw == value) return;
                    Unk5_raw = value;
                    OnPropertyChanged(nameof(Unk5));
                }
            }

            protected float Unk6_raw;
            public const string Unk6_displayName = "Unk6";
            public const int Unk6_sortIndex = 300;
            [SortOrder(Unk6_sortIndex)]
            [DisplayName(Unk6_displayName)]
            public virtual float Unk6 {
                get => Unk6_raw;
                set {
                    if (Unk6_raw == value) return;
                    Unk6_raw = value;
                    OnPropertyChanged(nameof(Unk6));
                }
            }

            protected float Unk7_raw;
            public const string Unk7_displayName = "Unk7";
            public const int Unk7_sortIndex = 350;
            [SortOrder(Unk7_sortIndex)]
            [DisplayName(Unk7_displayName)]
            public virtual float Unk7 {
                get => Unk7_raw;
                set {
                    if (Unk7_raw == value) return;
                    Unk7_raw = value;
                    OnPropertyChanged(nameof(Unk7));
                }
            }

            protected float Unk8_raw;
            public const string Unk8_displayName = "Unk8";
            public const int Unk8_sortIndex = 400;
            [SortOrder(Unk8_sortIndex)]
            [DisplayName(Unk8_displayName)]
            public virtual float Unk8 {
                get => Unk8_raw;
                set {
                    if (Unk8_raw == value) return;
                    Unk8_raw = value;
                    OnPropertyChanged(nameof(Unk8));
                }
            }

            protected float Unk9_raw;
            public const string Unk9_displayName = "Unk9";
            public const int Unk9_sortIndex = 450;
            [SortOrder(Unk9_sortIndex)]
            [DisplayName(Unk9_displayName)]
            public virtual float Unk9 {
                get => Unk9_raw;
                set {
                    if (Unk9_raw == value) return;
                    Unk9_raw = value;
                    OnPropertyChanged(nameof(Unk9));
                }
            }

            protected float Unk10_raw;
            public const string Unk10_displayName = "Unk10";
            public const int Unk10_sortIndex = 500;
            [SortOrder(Unk10_sortIndex)]
            [DisplayName(Unk10_displayName)]
            public virtual float Unk10 {
                get => Unk10_raw;
                set {
                    if (Unk10_raw == value) return;
                    Unk10_raw = value;
                    OnPropertyChanged(nameof(Unk10));
                }
            }

            protected float Unk11_raw;
            public const string Unk11_displayName = "Unk11";
            public const int Unk11_sortIndex = 550;
            [SortOrder(Unk11_sortIndex)]
            [DisplayName(Unk11_displayName)]
            public virtual float Unk11 {
                get => Unk11_raw;
                set {
                    if (Unk11_raw == value) return;
                    Unk11_raw = value;
                    OnPropertyChanged(nameof(Unk11));
                }
            }

            protected float Unk12_raw;
            public const string Unk12_displayName = "Unk12";
            public const int Unk12_sortIndex = 600;
            [SortOrder(Unk12_sortIndex)]
            [DisplayName(Unk12_displayName)]
            public virtual float Unk12 {
                get => Unk12_raw;
                set {
                    if (Unk12_raw == value) return;
                    Unk12_raw = value;
                    OnPropertyChanged(nameof(Unk12));
                }
            }

            protected float Unk13_raw;
            public const string Unk13_displayName = "Unk13";
            public const int Unk13_sortIndex = 650;
            [SortOrder(Unk13_sortIndex)]
            [DisplayName(Unk13_displayName)]
            public virtual float Unk13 {
                get => Unk13_raw;
                set {
                    if (Unk13_raw == value) return;
                    Unk13_raw = value;
                    OnPropertyChanged(nameof(Unk13));
                }
            }

            protected float Unk14_raw;
            public const string Unk14_displayName = "Unk14";
            public const int Unk14_sortIndex = 700;
            [SortOrder(Unk14_sortIndex)]
            [DisplayName(Unk14_displayName)]
            public virtual float Unk14 {
                get => Unk14_raw;
                set {
                    if (Unk14_raw == value) return;
                    Unk14_raw = value;
                    OnPropertyChanged(nameof(Unk14));
                }
            }

            protected float Unk15_raw;
            public const string Unk15_displayName = "Unk15";
            public const int Unk15_sortIndex = 750;
            [SortOrder(Unk15_sortIndex)]
            [DisplayName(Unk15_displayName)]
            public virtual float Unk15 {
                get => Unk15_raw;
                set {
                    if (Unk15_raw == value) return;
                    Unk15_raw = value;
                    OnPropertyChanged(nameof(Unk15));
                }
            }

            protected uint Unk16_raw;
            public const string Unk16_displayName = "Unk16";
            public const int Unk16_sortIndex = 800;
            [SortOrder(Unk16_sortIndex)]
            [DisplayName(Unk16_displayName)]
            public virtual uint Unk16 {
                get => Unk16_raw;
                set {
                    if (Unk16_raw == value) return;
                    Unk16_raw = value;
                    OnPropertyChanged(nameof(Unk16));
                }
            }

            protected float Unk17_raw;
            public const string Unk17_displayName = "Unk17";
            public const int Unk17_sortIndex = 850;
            [SortOrder(Unk17_sortIndex)]
            [DisplayName(Unk17_displayName)]
            public virtual float Unk17 {
                get => Unk17_raw;
                set {
                    if (Unk17_raw == value) return;
                    Unk17_raw = value;
                    OnPropertyChanged(nameof(Unk17));
                }
            }

            protected float Unk18_raw;
            public const string Unk18_displayName = "Unk18";
            public const int Unk18_sortIndex = 900;
            [SortOrder(Unk18_sortIndex)]
            [DisplayName(Unk18_displayName)]
            public virtual float Unk18 {
                get => Unk18_raw;
                set {
                    if (Unk18_raw == value) return;
                    Unk18_raw = value;
                    OnPropertyChanged(nameof(Unk18));
                }
            }

            protected float Unk19_raw;
            public const string Unk19_displayName = "Unk19";
            public const int Unk19_sortIndex = 950;
            [SortOrder(Unk19_sortIndex)]
            [DisplayName(Unk19_displayName)]
            public virtual float Unk19 {
                get => Unk19_raw;
                set {
                    if (Unk19_raw == value) return;
                    Unk19_raw = value;
                    OnPropertyChanged(nameof(Unk19));
                }
            }

            protected float Unk20_raw;
            public const string Unk20_displayName = "Unk20";
            public const int Unk20_sortIndex = 1000;
            [SortOrder(Unk20_sortIndex)]
            [DisplayName(Unk20_displayName)]
            public virtual float Unk20 {
                get => Unk20_raw;
                set {
                    if (Unk20_raw == value) return;
                    Unk20_raw = value;
                    OnPropertyChanged(nameof(Unk20));
                }
            }

            protected byte Unk21_raw;
            public const string Unk21_displayName = "Unk21";
            public const int Unk21_sortIndex = 1050;
            [SortOrder(Unk21_sortIndex)]
            [DisplayName(Unk21_displayName)]
            public virtual byte Unk21 {
                get => Unk21_raw;
                set {
                    if (Unk21_raw == value) return;
                    Unk21_raw = value;
                    OnPropertyChanged(nameof(Unk21));
                }
            }

            protected float Unk22_raw;
            public const string Unk22_displayName = "Unk22";
            public const int Unk22_sortIndex = 1100;
            [SortOrder(Unk22_sortIndex)]
            [DisplayName(Unk22_displayName)]
            public virtual float Unk22 {
                get => Unk22_raw;
                set {
                    if (Unk22_raw == value) return;
                    Unk22_raw = value;
                    OnPropertyChanged(nameof(Unk22));
                }
            }

            public static W12p_Params_2_ LoadData(BinaryReader reader) {
                var data = new W12p_Params_2_();
                data.Unk1_raw = reader.ReadSingle();
                data.Unk2_raw = reader.ReadSingle();
                data.Unk3_raw = reader.ReadSingle();
                data.Unk4_raw = reader.ReadSingle();
                data.Unk5_raw = reader.ReadSingle();
                data.Unk6_raw = reader.ReadSingle();
                data.Unk7_raw = reader.ReadSingle();
                data.Unk8_raw = reader.ReadSingle();
                data.Unk9_raw = reader.ReadSingle();
                data.Unk10_raw = reader.ReadSingle();
                data.Unk11_raw = reader.ReadSingle();
                data.Unk12_raw = reader.ReadSingle();
                data.Unk13_raw = reader.ReadSingle();
                data.Unk14_raw = reader.ReadSingle();
                data.Unk15_raw = reader.ReadSingle();
                data.Unk16_raw = reader.ReadUInt32();
                data.Unk17_raw = reader.ReadSingle();
                data.Unk18_raw = reader.ReadSingle();
                data.Unk19_raw = reader.ReadSingle();
                data.Unk20_raw = reader.ReadSingle();
                data.Unk21_raw = reader.ReadByte();
                data.Unk22_raw = reader.ReadSingle();
                return data;
            }

            public override void WriteData(BinaryWriter writer) {
                writer.Write(Unk1_raw);
                writer.Write(Unk2_raw);
                writer.Write(Unk3_raw);
                writer.Write(Unk4_raw);
                writer.Write(Unk5_raw);
                writer.Write(Unk6_raw);
                writer.Write(Unk7_raw);
                writer.Write(Unk8_raw);
                writer.Write(Unk9_raw);
                writer.Write(Unk10_raw);
                writer.Write(Unk11_raw);
                writer.Write(Unk12_raw);
                writer.Write(Unk13_raw);
                writer.Write(Unk14_raw);
                writer.Write(Unk15_raw);
                writer.Write(Unk16_raw);
                writer.Write(Unk17_raw);
                writer.Write(Unk18_raw);
                writer.Write(Unk19_raw);
                writer.Write(Unk20_raw);
                writer.Write(Unk21_raw);
                writer.Write(Unk22_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Unk1", "Unk1"),
                    new MultiStructItemCustomView(this, "Unk2", "Unk2"),
                    new MultiStructItemCustomView(this, "Unk3", "Unk3"),
                    new MultiStructItemCustomView(this, "Unk4", "Unk4"),
                    new MultiStructItemCustomView(this, "Unk5", "Unk5"),
                    new MultiStructItemCustomView(this, "Unk6", "Unk6"),
                    new MultiStructItemCustomView(this, "Unk7", "Unk7"),
                    new MultiStructItemCustomView(this, "Unk8", "Unk8"),
                    new MultiStructItemCustomView(this, "Unk9", "Unk9"),
                    new MultiStructItemCustomView(this, "Unk10", "Unk10"),
                    new MultiStructItemCustomView(this, "Unk11", "Unk11"),
                    new MultiStructItemCustomView(this, "Unk12", "Unk12"),
                    new MultiStructItemCustomView(this, "Unk13", "Unk13"),
                    new MultiStructItemCustomView(this, "Unk14", "Unk14"),
                    new MultiStructItemCustomView(this, "Unk15", "Unk15"),
                    new MultiStructItemCustomView(this, "Unk16", "Unk16"),
                    new MultiStructItemCustomView(this, "Unk17", "Unk17"),
                    new MultiStructItemCustomView(this, "Unk18", "Unk18"),
                    new MultiStructItemCustomView(this, "Unk19", "Unk19"),
                    new MultiStructItemCustomView(this, "Unk20", "Unk20"),
                    new MultiStructItemCustomView(this, "Unk21", "Unk21"),
                    new MultiStructItemCustomView(this, "Unk22", "Unk22"),
                };
            }
        }

        public partial class Guard_Angles_ : MhwStructItem {
            public const ulong FixedSizeCount = 2;
            public const string GridName = "Guard Angles?";

            protected float Guard_Angle_Both_Sides__raw;
            public const string Guard_Angle_Both_Sides__displayName = "Guard Angle (Both Sides)";
            public const int Guard_Angle_Both_Sides__sortIndex = 50;
            [SortOrder(Guard_Angle_Both_Sides__sortIndex)]
            [DisplayName(Guard_Angle_Both_Sides__displayName)]
            public virtual float Guard_Angle_Both_Sides_ {
                get => Guard_Angle_Both_Sides__raw;
                set {
                    if (Guard_Angle_Both_Sides__raw == value) return;
                    Guard_Angle_Both_Sides__raw = value;
                    OnPropertyChanged(nameof(Guard_Angle_Both_Sides_));
                }
            }

            protected byte Knockback_Threshold_Small_raw;
            public const string Knockback_Threshold_Small_displayName = "Knockback Threshold Small";
            public const int Knockback_Threshold_Small_sortIndex = 100;
            [SortOrder(Knockback_Threshold_Small_sortIndex)]
            [DisplayName(Knockback_Threshold_Small_displayName)]
            public virtual byte Knockback_Threshold_Small {
                get => Knockback_Threshold_Small_raw;
                set {
                    if (Knockback_Threshold_Small_raw == value) return;
                    Knockback_Threshold_Small_raw = value;
                    OnPropertyChanged(nameof(Knockback_Threshold_Small));
                }
            }

            protected byte Knockback_Threshold_Medium_raw;
            public const string Knockback_Threshold_Medium_displayName = "Knockback Threshold Medium";
            public const int Knockback_Threshold_Medium_sortIndex = 150;
            [SortOrder(Knockback_Threshold_Medium_sortIndex)]
            [DisplayName(Knockback_Threshold_Medium_displayName)]
            public virtual byte Knockback_Threshold_Medium {
                get => Knockback_Threshold_Medium_raw;
                set {
                    if (Knockback_Threshold_Medium_raw == value) return;
                    Knockback_Threshold_Medium_raw = value;
                    OnPropertyChanged(nameof(Knockback_Threshold_Medium));
                }
            }

            protected byte Knockback_Threshold_Large_raw;
            public const string Knockback_Threshold_Large_displayName = "Knockback Threshold Large";
            public const int Knockback_Threshold_Large_sortIndex = 200;
            [SortOrder(Knockback_Threshold_Large_sortIndex)]
            [DisplayName(Knockback_Threshold_Large_displayName)]
            public virtual byte Knockback_Threshold_Large {
                get => Knockback_Threshold_Large_raw;
                set {
                    if (Knockback_Threshold_Large_raw == value) return;
                    Knockback_Threshold_Large_raw = value;
                    OnPropertyChanged(nameof(Knockback_Threshold_Large));
                }
            }

            public static Guard_Angles_ LoadData(BinaryReader reader) {
                var data = new Guard_Angles_();
                data.Guard_Angle_Both_Sides__raw = reader.ReadSingle();
                data.Knockback_Threshold_Small_raw = reader.ReadByte();
                data.Knockback_Threshold_Medium_raw = reader.ReadByte();
                data.Knockback_Threshold_Large_raw = reader.ReadByte();
                return data;
            }

            public override void WriteData(BinaryWriter writer) {
                writer.Write(Guard_Angle_Both_Sides__raw);
                writer.Write(Knockback_Threshold_Small_raw);
                writer.Write(Knockback_Threshold_Medium_raw);
                writer.Write(Knockback_Threshold_Large_raw);
            }
        }

        public partial class W12p_Params_3_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView> {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W12p Params (3)";

            protected float Unk33_raw;
            public const string Unk33_displayName = "Unk33";
            public const int Unk33_sortIndex = 50;
            [SortOrder(Unk33_sortIndex)]
            [DisplayName(Unk33_displayName)]
            public virtual float Unk33 {
                get => Unk33_raw;
                set {
                    if (Unk33_raw == value) return;
                    Unk33_raw = value;
                    OnPropertyChanged(nameof(Unk33));
                }
            }

            protected float Unk34_raw;
            public const string Unk34_displayName = "Unk34";
            public const int Unk34_sortIndex = 100;
            [SortOrder(Unk34_sortIndex)]
            [DisplayName(Unk34_displayName)]
            public virtual float Unk34 {
                get => Unk34_raw;
                set {
                    if (Unk34_raw == value) return;
                    Unk34_raw = value;
                    OnPropertyChanged(nameof(Unk34));
                }
            }

            protected float Unk35_raw;
            public const string Unk35_displayName = "Unk35";
            public const int Unk35_sortIndex = 150;
            [SortOrder(Unk35_sortIndex)]
            [DisplayName(Unk35_displayName)]
            public virtual float Unk35 {
                get => Unk35_raw;
                set {
                    if (Unk35_raw == value) return;
                    Unk35_raw = value;
                    OnPropertyChanged(nameof(Unk35));
                }
            }

            protected float Unk36_raw;
            public const string Unk36_displayName = "Unk36";
            public const int Unk36_sortIndex = 200;
            [SortOrder(Unk36_sortIndex)]
            [DisplayName(Unk36_displayName)]
            public virtual float Unk36 {
                get => Unk36_raw;
                set {
                    if (Unk36_raw == value) return;
                    Unk36_raw = value;
                    OnPropertyChanged(nameof(Unk36));
                }
            }

            protected float Unk37_raw;
            public const string Unk37_displayName = "Unk37";
            public const int Unk37_sortIndex = 250;
            [SortOrder(Unk37_sortIndex)]
            [DisplayName(Unk37_displayName)]
            public virtual float Unk37 {
                get => Unk37_raw;
                set {
                    if (Unk37_raw == value) return;
                    Unk37_raw = value;
                    OnPropertyChanged(nameof(Unk37));
                }
            }

            protected float Unk38_raw;
            public const string Unk38_displayName = "Unk38";
            public const int Unk38_sortIndex = 300;
            [SortOrder(Unk38_sortIndex)]
            [DisplayName(Unk38_displayName)]
            public virtual float Unk38 {
                get => Unk38_raw;
                set {
                    if (Unk38_raw == value) return;
                    Unk38_raw = value;
                    OnPropertyChanged(nameof(Unk38));
                }
            }

            protected float Unk39_raw;
            public const string Unk39_displayName = "Unk39";
            public const int Unk39_sortIndex = 350;
            [SortOrder(Unk39_sortIndex)]
            [DisplayName(Unk39_displayName)]
            public virtual float Unk39 {
                get => Unk39_raw;
                set {
                    if (Unk39_raw == value) return;
                    Unk39_raw = value;
                    OnPropertyChanged(nameof(Unk39));
                }
            }

            protected float Unk40_raw;
            public const string Unk40_displayName = "Unk40";
            public const int Unk40_sortIndex = 400;
            [SortOrder(Unk40_sortIndex)]
            [DisplayName(Unk40_displayName)]
            public virtual float Unk40 {
                get => Unk40_raw;
                set {
                    if (Unk40_raw == value) return;
                    Unk40_raw = value;
                    OnPropertyChanged(nameof(Unk40));
                }
            }

            protected float Unk41_raw;
            public const string Unk41_displayName = "Unk41";
            public const int Unk41_sortIndex = 450;
            [SortOrder(Unk41_sortIndex)]
            [DisplayName(Unk41_displayName)]
            public virtual float Unk41 {
                get => Unk41_raw;
                set {
                    if (Unk41_raw == value) return;
                    Unk41_raw = value;
                    OnPropertyChanged(nameof(Unk41));
                }
            }

            protected float Unk42_raw;
            public const string Unk42_displayName = "Unk42";
            public const int Unk42_sortIndex = 500;
            [SortOrder(Unk42_sortIndex)]
            [DisplayName(Unk42_displayName)]
            public virtual float Unk42 {
                get => Unk42_raw;
                set {
                    if (Unk42_raw == value) return;
                    Unk42_raw = value;
                    OnPropertyChanged(nameof(Unk42));
                }
            }

            protected float Unk43_raw;
            public const string Unk43_displayName = "Unk43";
            public const int Unk43_sortIndex = 550;
            [SortOrder(Unk43_sortIndex)]
            [DisplayName(Unk43_displayName)]
            public virtual float Unk43 {
                get => Unk43_raw;
                set {
                    if (Unk43_raw == value) return;
                    Unk43_raw = value;
                    OnPropertyChanged(nameof(Unk43));
                }
            }

            protected float Unk44_raw;
            public const string Unk44_displayName = "Unk44";
            public const int Unk44_sortIndex = 600;
            [SortOrder(Unk44_sortIndex)]
            [DisplayName(Unk44_displayName)]
            public virtual float Unk44 {
                get => Unk44_raw;
                set {
                    if (Unk44_raw == value) return;
                    Unk44_raw = value;
                    OnPropertyChanged(nameof(Unk44));
                }
            }

            protected float Unk45_raw;
            public const string Unk45_displayName = "Unk45";
            public const int Unk45_sortIndex = 650;
            [SortOrder(Unk45_sortIndex)]
            [DisplayName(Unk45_displayName)]
            public virtual float Unk45 {
                get => Unk45_raw;
                set {
                    if (Unk45_raw == value) return;
                    Unk45_raw = value;
                    OnPropertyChanged(nameof(Unk45));
                }
            }

            protected float Unk46_raw;
            public const string Unk46_displayName = "Unk46";
            public const int Unk46_sortIndex = 700;
            [SortOrder(Unk46_sortIndex)]
            [DisplayName(Unk46_displayName)]
            public virtual float Unk46 {
                get => Unk46_raw;
                set {
                    if (Unk46_raw == value) return;
                    Unk46_raw = value;
                    OnPropertyChanged(nameof(Unk46));
                }
            }

            protected float Unk47_raw;
            public const string Unk47_displayName = "Unk47";
            public const int Unk47_sortIndex = 750;
            [SortOrder(Unk47_sortIndex)]
            [DisplayName(Unk47_displayName)]
            public virtual float Unk47 {
                get => Unk47_raw;
                set {
                    if (Unk47_raw == value) return;
                    Unk47_raw = value;
                    OnPropertyChanged(nameof(Unk47));
                }
            }

            protected float Unk48_raw;
            public const string Unk48_displayName = "Unk48";
            public const int Unk48_sortIndex = 800;
            [SortOrder(Unk48_sortIndex)]
            [DisplayName(Unk48_displayName)]
            public virtual float Unk48 {
                get => Unk48_raw;
                set {
                    if (Unk48_raw == value) return;
                    Unk48_raw = value;
                    OnPropertyChanged(nameof(Unk48));
                }
            }

            protected float Unk49_raw;
            public const string Unk49_displayName = "Unk49";
            public const int Unk49_sortIndex = 850;
            [SortOrder(Unk49_sortIndex)]
            [DisplayName(Unk49_displayName)]
            public virtual float Unk49 {
                get => Unk49_raw;
                set {
                    if (Unk49_raw == value) return;
                    Unk49_raw = value;
                    OnPropertyChanged(nameof(Unk49));
                }
            }

            protected float Unk50_raw;
            public const string Unk50_displayName = "Unk50";
            public const int Unk50_sortIndex = 900;
            [SortOrder(Unk50_sortIndex)]
            [DisplayName(Unk50_displayName)]
            public virtual float Unk50 {
                get => Unk50_raw;
                set {
                    if (Unk50_raw == value) return;
                    Unk50_raw = value;
                    OnPropertyChanged(nameof(Unk50));
                }
            }

            protected float Unk51_raw;
            public const string Unk51_displayName = "Unk51";
            public const int Unk51_sortIndex = 950;
            [SortOrder(Unk51_sortIndex)]
            [DisplayName(Unk51_displayName)]
            public virtual float Unk51 {
                get => Unk51_raw;
                set {
                    if (Unk51_raw == value) return;
                    Unk51_raw = value;
                    OnPropertyChanged(nameof(Unk51));
                }
            }

            protected float Unk52_raw;
            public const string Unk52_displayName = "Unk52";
            public const int Unk52_sortIndex = 1000;
            [SortOrder(Unk52_sortIndex)]
            [DisplayName(Unk52_displayName)]
            public virtual float Unk52 {
                get => Unk52_raw;
                set {
                    if (Unk52_raw == value) return;
                    Unk52_raw = value;
                    OnPropertyChanged(nameof(Unk52));
                }
            }

            protected float Unk53_raw;
            public const string Unk53_displayName = "Unk53";
            public const int Unk53_sortIndex = 1050;
            [SortOrder(Unk53_sortIndex)]
            [DisplayName(Unk53_displayName)]
            public virtual float Unk53 {
                get => Unk53_raw;
                set {
                    if (Unk53_raw == value) return;
                    Unk53_raw = value;
                    OnPropertyChanged(nameof(Unk53));
                }
            }

            protected float Unk54_raw;
            public const string Unk54_displayName = "Unk54";
            public const int Unk54_sortIndex = 1100;
            [SortOrder(Unk54_sortIndex)]
            [DisplayName(Unk54_displayName)]
            public virtual float Unk54 {
                get => Unk54_raw;
                set {
                    if (Unk54_raw == value) return;
                    Unk54_raw = value;
                    OnPropertyChanged(nameof(Unk54));
                }
            }

            protected float Unk55_raw;
            public const string Unk55_displayName = "Unk55";
            public const int Unk55_sortIndex = 1150;
            [SortOrder(Unk55_sortIndex)]
            [DisplayName(Unk55_displayName)]
            public virtual float Unk55 {
                get => Unk55_raw;
                set {
                    if (Unk55_raw == value) return;
                    Unk55_raw = value;
                    OnPropertyChanged(nameof(Unk55));
                }
            }

            protected float Unk56_raw;
            public const string Unk56_displayName = "Unk56";
            public const int Unk56_sortIndex = 1200;
            [SortOrder(Unk56_sortIndex)]
            [DisplayName(Unk56_displayName)]
            public virtual float Unk56 {
                get => Unk56_raw;
                set {
                    if (Unk56_raw == value) return;
                    Unk56_raw = value;
                    OnPropertyChanged(nameof(Unk56));
                }
            }

            protected float Unk57_raw;
            public const string Unk57_displayName = "Unk57";
            public const int Unk57_sortIndex = 1250;
            [SortOrder(Unk57_sortIndex)]
            [DisplayName(Unk57_displayName)]
            public virtual float Unk57 {
                get => Unk57_raw;
                set {
                    if (Unk57_raw == value) return;
                    Unk57_raw = value;
                    OnPropertyChanged(nameof(Unk57));
                }
            }

            protected float Unk58_raw;
            public const string Unk58_displayName = "Unk58";
            public const int Unk58_sortIndex = 1300;
            [SortOrder(Unk58_sortIndex)]
            [DisplayName(Unk58_displayName)]
            public virtual float Unk58 {
                get => Unk58_raw;
                set {
                    if (Unk58_raw == value) return;
                    Unk58_raw = value;
                    OnPropertyChanged(nameof(Unk58));
                }
            }

            protected float Unk59_raw;
            public const string Unk59_displayName = "Unk59";
            public const int Unk59_sortIndex = 1350;
            [SortOrder(Unk59_sortIndex)]
            [DisplayName(Unk59_displayName)]
            public virtual float Unk59 {
                get => Unk59_raw;
                set {
                    if (Unk59_raw == value) return;
                    Unk59_raw = value;
                    OnPropertyChanged(nameof(Unk59));
                }
            }

            protected float Unk60_raw;
            public const string Unk60_displayName = "Unk60";
            public const int Unk60_sortIndex = 1400;
            [SortOrder(Unk60_sortIndex)]
            [DisplayName(Unk60_displayName)]
            public virtual float Unk60 {
                get => Unk60_raw;
                set {
                    if (Unk60_raw == value) return;
                    Unk60_raw = value;
                    OnPropertyChanged(nameof(Unk60));
                }
            }

            protected float Unk61_raw;
            public const string Unk61_displayName = "Unk61";
            public const int Unk61_sortIndex = 1450;
            [SortOrder(Unk61_sortIndex)]
            [DisplayName(Unk61_displayName)]
            public virtual float Unk61 {
                get => Unk61_raw;
                set {
                    if (Unk61_raw == value) return;
                    Unk61_raw = value;
                    OnPropertyChanged(nameof(Unk61));
                }
            }

            protected float Unk62_raw;
            public const string Unk62_displayName = "Unk62";
            public const int Unk62_sortIndex = 1500;
            [SortOrder(Unk62_sortIndex)]
            [DisplayName(Unk62_displayName)]
            public virtual float Unk62 {
                get => Unk62_raw;
                set {
                    if (Unk62_raw == value) return;
                    Unk62_raw = value;
                    OnPropertyChanged(nameof(Unk62));
                }
            }

            protected float Unk63_raw;
            public const string Unk63_displayName = "Unk63";
            public const int Unk63_sortIndex = 1550;
            [SortOrder(Unk63_sortIndex)]
            [DisplayName(Unk63_displayName)]
            public virtual float Unk63 {
                get => Unk63_raw;
                set {
                    if (Unk63_raw == value) return;
                    Unk63_raw = value;
                    OnPropertyChanged(nameof(Unk63));
                }
            }

            protected float Unk64_raw;
            public const string Unk64_displayName = "Unk64";
            public const int Unk64_sortIndex = 1600;
            [SortOrder(Unk64_sortIndex)]
            [DisplayName(Unk64_displayName)]
            public virtual float Unk64 {
                get => Unk64_raw;
                set {
                    if (Unk64_raw == value) return;
                    Unk64_raw = value;
                    OnPropertyChanged(nameof(Unk64));
                }
            }

            protected float Unk65_raw;
            public const string Unk65_displayName = "Unk65";
            public const int Unk65_sortIndex = 1650;
            [SortOrder(Unk65_sortIndex)]
            [DisplayName(Unk65_displayName)]
            public virtual float Unk65 {
                get => Unk65_raw;
                set {
                    if (Unk65_raw == value) return;
                    Unk65_raw = value;
                    OnPropertyChanged(nameof(Unk65));
                }
            }

            protected float Unk66_raw;
            public const string Unk66_displayName = "Unk66";
            public const int Unk66_sortIndex = 1700;
            [SortOrder(Unk66_sortIndex)]
            [DisplayName(Unk66_displayName)]
            public virtual float Unk66 {
                get => Unk66_raw;
                set {
                    if (Unk66_raw == value) return;
                    Unk66_raw = value;
                    OnPropertyChanged(nameof(Unk66));
                }
            }

            protected float Unk67_raw;
            public const string Unk67_displayName = "Unk67";
            public const int Unk67_sortIndex = 1750;
            [SortOrder(Unk67_sortIndex)]
            [DisplayName(Unk67_displayName)]
            public virtual float Unk67 {
                get => Unk67_raw;
                set {
                    if (Unk67_raw == value) return;
                    Unk67_raw = value;
                    OnPropertyChanged(nameof(Unk67));
                }
            }

            protected float Unk68_raw;
            public const string Unk68_displayName = "Unk68";
            public const int Unk68_sortIndex = 1800;
            [SortOrder(Unk68_sortIndex)]
            [DisplayName(Unk68_displayName)]
            public virtual float Unk68 {
                get => Unk68_raw;
                set {
                    if (Unk68_raw == value) return;
                    Unk68_raw = value;
                    OnPropertyChanged(nameof(Unk68));
                }
            }

            protected float Unk69_raw;
            public const string Unk69_displayName = "Unk69";
            public const int Unk69_sortIndex = 1850;
            [SortOrder(Unk69_sortIndex)]
            [DisplayName(Unk69_displayName)]
            public virtual float Unk69 {
                get => Unk69_raw;
                set {
                    if (Unk69_raw == value) return;
                    Unk69_raw = value;
                    OnPropertyChanged(nameof(Unk69));
                }
            }

            protected float Unk70_raw;
            public const string Unk70_displayName = "Unk70";
            public const int Unk70_sortIndex = 1900;
            [SortOrder(Unk70_sortIndex)]
            [DisplayName(Unk70_displayName)]
            public virtual float Unk70 {
                get => Unk70_raw;
                set {
                    if (Unk70_raw == value) return;
                    Unk70_raw = value;
                    OnPropertyChanged(nameof(Unk70));
                }
            }

            protected float Unk71_raw;
            public const string Unk71_displayName = "Unk71";
            public const int Unk71_sortIndex = 1950;
            [SortOrder(Unk71_sortIndex)]
            [DisplayName(Unk71_displayName)]
            public virtual float Unk71 {
                get => Unk71_raw;
                set {
                    if (Unk71_raw == value) return;
                    Unk71_raw = value;
                    OnPropertyChanged(nameof(Unk71));
                }
            }

            protected float Unk72_raw;
            public const string Unk72_displayName = "Unk72";
            public const int Unk72_sortIndex = 2000;
            [SortOrder(Unk72_sortIndex)]
            [DisplayName(Unk72_displayName)]
            public virtual float Unk72 {
                get => Unk72_raw;
                set {
                    if (Unk72_raw == value) return;
                    Unk72_raw = value;
                    OnPropertyChanged(nameof(Unk72));
                }
            }

            protected float Unk73_raw;
            public const string Unk73_displayName = "Unk73";
            public const int Unk73_sortIndex = 2050;
            [SortOrder(Unk73_sortIndex)]
            [DisplayName(Unk73_displayName)]
            public virtual float Unk73 {
                get => Unk73_raw;
                set {
                    if (Unk73_raw == value) return;
                    Unk73_raw = value;
                    OnPropertyChanged(nameof(Unk73));
                }
            }

            protected float Unk74_raw;
            public const string Unk74_displayName = "Unk74";
            public const int Unk74_sortIndex = 2100;
            [SortOrder(Unk74_sortIndex)]
            [DisplayName(Unk74_displayName)]
            public virtual float Unk74 {
                get => Unk74_raw;
                set {
                    if (Unk74_raw == value) return;
                    Unk74_raw = value;
                    OnPropertyChanged(nameof(Unk74));
                }
            }

            protected float Unk75_raw;
            public const string Unk75_displayName = "Unk75";
            public const int Unk75_sortIndex = 2150;
            [SortOrder(Unk75_sortIndex)]
            [DisplayName(Unk75_displayName)]
            public virtual float Unk75 {
                get => Unk75_raw;
                set {
                    if (Unk75_raw == value) return;
                    Unk75_raw = value;
                    OnPropertyChanged(nameof(Unk75));
                }
            }

            protected float Unk76_raw;
            public const string Unk76_displayName = "Unk76";
            public const int Unk76_sortIndex = 2200;
            [SortOrder(Unk76_sortIndex)]
            [DisplayName(Unk76_displayName)]
            public virtual float Unk76 {
                get => Unk76_raw;
                set {
                    if (Unk76_raw == value) return;
                    Unk76_raw = value;
                    OnPropertyChanged(nameof(Unk76));
                }
            }

            protected byte Unk77_raw;
            public const string Unk77_displayName = "Unk77";
            public const int Unk77_sortIndex = 2250;
            [SortOrder(Unk77_sortIndex)]
            [DisplayName(Unk77_displayName)]
            public virtual byte Unk77 {
                get => Unk77_raw;
                set {
                    if (Unk77_raw == value) return;
                    Unk77_raw = value;
                    OnPropertyChanged(nameof(Unk77));
                }
            }

            protected ushort Unk78_raw;
            public const string Unk78_displayName = "Unk78";
            public const int Unk78_sortIndex = 2300;
            [SortOrder(Unk78_sortIndex)]
            [DisplayName(Unk78_displayName)]
            public virtual ushort Unk78 {
                get => Unk78_raw;
                set {
                    if (Unk78_raw == value) return;
                    Unk78_raw = value;
                    OnPropertyChanged(nameof(Unk78));
                }
            }

            protected ushort Unk79_raw;
            public const string Unk79_displayName = "Unk79";
            public const int Unk79_sortIndex = 2350;
            [SortOrder(Unk79_sortIndex)]
            [DisplayName(Unk79_displayName)]
            public virtual ushort Unk79 {
                get => Unk79_raw;
                set {
                    if (Unk79_raw == value) return;
                    Unk79_raw = value;
                    OnPropertyChanged(nameof(Unk79));
                }
            }

            protected float Unk80_raw;
            public const string Unk80_displayName = "Unk80";
            public const int Unk80_sortIndex = 2400;
            [SortOrder(Unk80_sortIndex)]
            [DisplayName(Unk80_displayName)]
            public virtual float Unk80 {
                get => Unk80_raw;
                set {
                    if (Unk80_raw == value) return;
                    Unk80_raw = value;
                    OnPropertyChanged(nameof(Unk80));
                }
            }

            protected float Unk81_raw;
            public const string Unk81_displayName = "Unk81";
            public const int Unk81_sortIndex = 2450;
            [SortOrder(Unk81_sortIndex)]
            [DisplayName(Unk81_displayName)]
            public virtual float Unk81 {
                get => Unk81_raw;
                set {
                    if (Unk81_raw == value) return;
                    Unk81_raw = value;
                    OnPropertyChanged(nameof(Unk81));
                }
            }

            protected float Unk82_raw;
            public const string Unk82_displayName = "Unk82";
            public const int Unk82_sortIndex = 2500;
            [SortOrder(Unk82_sortIndex)]
            [DisplayName(Unk82_displayName)]
            public virtual float Unk82 {
                get => Unk82_raw;
                set {
                    if (Unk82_raw == value) return;
                    Unk82_raw = value;
                    OnPropertyChanged(nameof(Unk82));
                }
            }

            protected byte Unk83_raw;
            public const string Unk83_displayName = "Unk83";
            public const int Unk83_sortIndex = 2550;
            [SortOrder(Unk83_sortIndex)]
            [DisplayName(Unk83_displayName)]
            public virtual byte Unk83 {
                get => Unk83_raw;
                set {
                    if (Unk83_raw == value) return;
                    Unk83_raw = value;
                    OnPropertyChanged(nameof(Unk83));
                }
            }

            protected int Unk84_raw;
            public const string Unk84_displayName = "Unk84";
            public const int Unk84_sortIndex = 2600;
            [SortOrder(Unk84_sortIndex)]
            [DisplayName(Unk84_displayName)]
            public virtual int Unk84 {
                get => Unk84_raw;
                set {
                    if (Unk84_raw == value) return;
                    Unk84_raw = value;
                    OnPropertyChanged(nameof(Unk84));
                }
            }

            public static W12p_Params_3_ LoadData(BinaryReader reader) {
                var data = new W12p_Params_3_();
                data.Unk33_raw = reader.ReadSingle();
                data.Unk34_raw = reader.ReadSingle();
                data.Unk35_raw = reader.ReadSingle();
                data.Unk36_raw = reader.ReadSingle();
                data.Unk37_raw = reader.ReadSingle();
                data.Unk38_raw = reader.ReadSingle();
                data.Unk39_raw = reader.ReadSingle();
                data.Unk40_raw = reader.ReadSingle();
                data.Unk41_raw = reader.ReadSingle();
                data.Unk42_raw = reader.ReadSingle();
                data.Unk43_raw = reader.ReadSingle();
                data.Unk44_raw = reader.ReadSingle();
                data.Unk45_raw = reader.ReadSingle();
                data.Unk46_raw = reader.ReadSingle();
                data.Unk47_raw = reader.ReadSingle();
                data.Unk48_raw = reader.ReadSingle();
                data.Unk49_raw = reader.ReadSingle();
                data.Unk50_raw = reader.ReadSingle();
                data.Unk51_raw = reader.ReadSingle();
                data.Unk52_raw = reader.ReadSingle();
                data.Unk53_raw = reader.ReadSingle();
                data.Unk54_raw = reader.ReadSingle();
                data.Unk55_raw = reader.ReadSingle();
                data.Unk56_raw = reader.ReadSingle();
                data.Unk57_raw = reader.ReadSingle();
                data.Unk58_raw = reader.ReadSingle();
                data.Unk59_raw = reader.ReadSingle();
                data.Unk60_raw = reader.ReadSingle();
                data.Unk61_raw = reader.ReadSingle();
                data.Unk62_raw = reader.ReadSingle();
                data.Unk63_raw = reader.ReadSingle();
                data.Unk64_raw = reader.ReadSingle();
                data.Unk65_raw = reader.ReadSingle();
                data.Unk66_raw = reader.ReadSingle();
                data.Unk67_raw = reader.ReadSingle();
                data.Unk68_raw = reader.ReadSingle();
                data.Unk69_raw = reader.ReadSingle();
                data.Unk70_raw = reader.ReadSingle();
                data.Unk71_raw = reader.ReadSingle();
                data.Unk72_raw = reader.ReadSingle();
                data.Unk73_raw = reader.ReadSingle();
                data.Unk74_raw = reader.ReadSingle();
                data.Unk75_raw = reader.ReadSingle();
                data.Unk76_raw = reader.ReadSingle();
                data.Unk77_raw = reader.ReadByte();
                data.Unk78_raw = reader.ReadUInt16();
                data.Unk79_raw = reader.ReadUInt16();
                data.Unk80_raw = reader.ReadSingle();
                data.Unk81_raw = reader.ReadSingle();
                data.Unk82_raw = reader.ReadSingle();
                data.Unk83_raw = reader.ReadByte();
                data.Unk84_raw = reader.ReadInt32();
                return data;
            }

            public override void WriteData(BinaryWriter writer) {
                writer.Write(Unk33_raw);
                writer.Write(Unk34_raw);
                writer.Write(Unk35_raw);
                writer.Write(Unk36_raw);
                writer.Write(Unk37_raw);
                writer.Write(Unk38_raw);
                writer.Write(Unk39_raw);
                writer.Write(Unk40_raw);
                writer.Write(Unk41_raw);
                writer.Write(Unk42_raw);
                writer.Write(Unk43_raw);
                writer.Write(Unk44_raw);
                writer.Write(Unk45_raw);
                writer.Write(Unk46_raw);
                writer.Write(Unk47_raw);
                writer.Write(Unk48_raw);
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
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Unk33", "Unk33"),
                    new MultiStructItemCustomView(this, "Unk34", "Unk34"),
                    new MultiStructItemCustomView(this, "Unk35", "Unk35"),
                    new MultiStructItemCustomView(this, "Unk36", "Unk36"),
                    new MultiStructItemCustomView(this, "Unk37", "Unk37"),
                    new MultiStructItemCustomView(this, "Unk38", "Unk38"),
                    new MultiStructItemCustomView(this, "Unk39", "Unk39"),
                    new MultiStructItemCustomView(this, "Unk40", "Unk40"),
                    new MultiStructItemCustomView(this, "Unk41", "Unk41"),
                    new MultiStructItemCustomView(this, "Unk42", "Unk42"),
                    new MultiStructItemCustomView(this, "Unk43", "Unk43"),
                    new MultiStructItemCustomView(this, "Unk44", "Unk44"),
                    new MultiStructItemCustomView(this, "Unk45", "Unk45"),
                    new MultiStructItemCustomView(this, "Unk46", "Unk46"),
                    new MultiStructItemCustomView(this, "Unk47", "Unk47"),
                    new MultiStructItemCustomView(this, "Unk48", "Unk48"),
                    new MultiStructItemCustomView(this, "Unk49", "Unk49"),
                    new MultiStructItemCustomView(this, "Unk50", "Unk50"),
                    new MultiStructItemCustomView(this, "Unk51", "Unk51"),
                    new MultiStructItemCustomView(this, "Unk52", "Unk52"),
                    new MultiStructItemCustomView(this, "Unk53", "Unk53"),
                    new MultiStructItemCustomView(this, "Unk54", "Unk54"),
                    new MultiStructItemCustomView(this, "Unk55", "Unk55"),
                    new MultiStructItemCustomView(this, "Unk56", "Unk56"),
                    new MultiStructItemCustomView(this, "Unk57", "Unk57"),
                    new MultiStructItemCustomView(this, "Unk58", "Unk58"),
                    new MultiStructItemCustomView(this, "Unk59", "Unk59"),
                    new MultiStructItemCustomView(this, "Unk60", "Unk60"),
                    new MultiStructItemCustomView(this, "Unk61", "Unk61"),
                    new MultiStructItemCustomView(this, "Unk62", "Unk62"),
                    new MultiStructItemCustomView(this, "Unk63", "Unk63"),
                    new MultiStructItemCustomView(this, "Unk64", "Unk64"),
                    new MultiStructItemCustomView(this, "Unk65", "Unk65"),
                    new MultiStructItemCustomView(this, "Unk66", "Unk66"),
                    new MultiStructItemCustomView(this, "Unk67", "Unk67"),
                    new MultiStructItemCustomView(this, "Unk68", "Unk68"),
                    new MultiStructItemCustomView(this, "Unk69", "Unk69"),
                    new MultiStructItemCustomView(this, "Unk70", "Unk70"),
                    new MultiStructItemCustomView(this, "Unk71", "Unk71"),
                    new MultiStructItemCustomView(this, "Unk72", "Unk72"),
                    new MultiStructItemCustomView(this, "Unk73", "Unk73"),
                    new MultiStructItemCustomView(this, "Unk74", "Unk74"),
                    new MultiStructItemCustomView(this, "Unk75", "Unk75"),
                    new MultiStructItemCustomView(this, "Unk76", "Unk76"),
                    new MultiStructItemCustomView(this, "Unk77", "Unk77"),
                    new MultiStructItemCustomView(this, "Unk78", "Unk78"),
                    new MultiStructItemCustomView(this, "Unk79", "Unk79"),
                    new MultiStructItemCustomView(this, "Unk80", "Unk80"),
                    new MultiStructItemCustomView(this, "Unk81", "Unk81"),
                    new MultiStructItemCustomView(this, "Unk82", "Unk82"),
                    new MultiStructItemCustomView(this, "Unk83", "Unk83"),
                    new MultiStructItemCustomView(this, "Unk84", "Unk84"),
                };
            }
        }

        public partial class Unk_Struct_2 : MhwStructItem {
            public const ulong FixedSizeCount = 8;
            public const string GridName = "Unk Struct 2";

            protected float Unk1_raw;
            public const string Unk1_displayName = "Unk1";
            public const int Unk1_sortIndex = 50;
            [SortOrder(Unk1_sortIndex)]
            [DisplayName(Unk1_displayName)]
            public virtual float Unk1 {
                get => Unk1_raw;
                set {
                    if (Unk1_raw == value) return;
                    Unk1_raw = value;
                    OnPropertyChanged(nameof(Unk1));
                }
            }

            protected float Unk2_raw;
            public const string Unk2_displayName = "Unk2";
            public const int Unk2_sortIndex = 100;
            [SortOrder(Unk2_sortIndex)]
            [DisplayName(Unk2_displayName)]
            public virtual float Unk2 {
                get => Unk2_raw;
                set {
                    if (Unk2_raw == value) return;
                    Unk2_raw = value;
                    OnPropertyChanged(nameof(Unk2));
                }
            }

            protected float Unk3_raw;
            public const string Unk3_displayName = "Unk3";
            public const int Unk3_sortIndex = 150;
            [SortOrder(Unk3_sortIndex)]
            [DisplayName(Unk3_displayName)]
            public virtual float Unk3 {
                get => Unk3_raw;
                set {
                    if (Unk3_raw == value) return;
                    Unk3_raw = value;
                    OnPropertyChanged(nameof(Unk3));
                }
            }

            protected float Unk4_raw;
            public const string Unk4_displayName = "Unk4";
            public const int Unk4_sortIndex = 200;
            [SortOrder(Unk4_sortIndex)]
            [DisplayName(Unk4_displayName)]
            public virtual float Unk4 {
                get => Unk4_raw;
                set {
                    if (Unk4_raw == value) return;
                    Unk4_raw = value;
                    OnPropertyChanged(nameof(Unk4));
                }
            }

            protected float Unk5_raw;
            public const string Unk5_displayName = "Unk5";
            public const int Unk5_sortIndex = 250;
            [SortOrder(Unk5_sortIndex)]
            [DisplayName(Unk5_displayName)]
            public virtual float Unk5 {
                get => Unk5_raw;
                set {
                    if (Unk5_raw == value) return;
                    Unk5_raw = value;
                    OnPropertyChanged(nameof(Unk5));
                }
            }

            protected float Unk6_raw;
            public const string Unk6_displayName = "Unk6";
            public const int Unk6_sortIndex = 300;
            [SortOrder(Unk6_sortIndex)]
            [DisplayName(Unk6_displayName)]
            public virtual float Unk6 {
                get => Unk6_raw;
                set {
                    if (Unk6_raw == value) return;
                    Unk6_raw = value;
                    OnPropertyChanged(nameof(Unk6));
                }
            }

            protected float Unk7_raw;
            public const string Unk7_displayName = "Unk7";
            public const int Unk7_sortIndex = 350;
            [SortOrder(Unk7_sortIndex)]
            [DisplayName(Unk7_displayName)]
            public virtual float Unk7 {
                get => Unk7_raw;
                set {
                    if (Unk7_raw == value) return;
                    Unk7_raw = value;
                    OnPropertyChanged(nameof(Unk7));
                }
            }

            protected float Unk8_raw;
            public const string Unk8_displayName = "Unk8";
            public const int Unk8_sortIndex = 400;
            [SortOrder(Unk8_sortIndex)]
            [DisplayName(Unk8_displayName)]
            public virtual float Unk8 {
                get => Unk8_raw;
                set {
                    if (Unk8_raw == value) return;
                    Unk8_raw = value;
                    OnPropertyChanged(nameof(Unk8));
                }
            }

            protected float Unk9_raw;
            public const string Unk9_displayName = "Unk9";
            public const int Unk9_sortIndex = 450;
            [SortOrder(Unk9_sortIndex)]
            [DisplayName(Unk9_displayName)]
            public virtual float Unk9 {
                get => Unk9_raw;
                set {
                    if (Unk9_raw == value) return;
                    Unk9_raw = value;
                    OnPropertyChanged(nameof(Unk9));
                }
            }

            protected float Unk10_raw;
            public const string Unk10_displayName = "Unk10";
            public const int Unk10_sortIndex = 500;
            [SortOrder(Unk10_sortIndex)]
            [DisplayName(Unk10_displayName)]
            public virtual float Unk10 {
                get => Unk10_raw;
                set {
                    if (Unk10_raw == value) return;
                    Unk10_raw = value;
                    OnPropertyChanged(nameof(Unk10));
                }
            }

            protected float Unk11_raw;
            public const string Unk11_displayName = "Unk11";
            public const int Unk11_sortIndex = 550;
            [SortOrder(Unk11_sortIndex)]
            [DisplayName(Unk11_displayName)]
            public virtual float Unk11 {
                get => Unk11_raw;
                set {
                    if (Unk11_raw == value) return;
                    Unk11_raw = value;
                    OnPropertyChanged(nameof(Unk11));
                }
            }

            protected float Unk12_raw;
            public const string Unk12_displayName = "Unk12";
            public const int Unk12_sortIndex = 600;
            [SortOrder(Unk12_sortIndex)]
            [DisplayName(Unk12_displayName)]
            public virtual float Unk12 {
                get => Unk12_raw;
                set {
                    if (Unk12_raw == value) return;
                    Unk12_raw = value;
                    OnPropertyChanged(nameof(Unk12));
                }
            }

            protected float Unk13_raw;
            public const string Unk13_displayName = "Unk13";
            public const int Unk13_sortIndex = 650;
            [SortOrder(Unk13_sortIndex)]
            [DisplayName(Unk13_displayName)]
            public virtual float Unk13 {
                get => Unk13_raw;
                set {
                    if (Unk13_raw == value) return;
                    Unk13_raw = value;
                    OnPropertyChanged(nameof(Unk13));
                }
            }

            protected byte Unk14_raw;
            public const string Unk14_displayName = "Unk14";
            public const int Unk14_sortIndex = 700;
            [SortOrder(Unk14_sortIndex)]
            [DisplayName(Unk14_displayName)]
            public virtual byte Unk14 {
                get => Unk14_raw;
                set {
                    if (Unk14_raw == value) return;
                    Unk14_raw = value;
                    OnPropertyChanged(nameof(Unk14));
                }
            }

            protected int End_raw;
            public const string End_displayName = "End";
            public const int End_sortIndex = 750;
            [SortOrder(End_sortIndex)]
            [DisplayName(End_displayName)]
            public virtual int End {
                get => End_raw;
                set {
                    if (End_raw == value) return;
                    End_raw = value;
                    OnPropertyChanged(nameof(End));
                }
            }

            public static Unk_Struct_2 LoadData(BinaryReader reader) {
                var data = new Unk_Struct_2();
                data.Unk1_raw = reader.ReadSingle();
                data.Unk2_raw = reader.ReadSingle();
                data.Unk3_raw = reader.ReadSingle();
                data.Unk4_raw = reader.ReadSingle();
                data.Unk5_raw = reader.ReadSingle();
                data.Unk6_raw = reader.ReadSingle();
                data.Unk7_raw = reader.ReadSingle();
                data.Unk8_raw = reader.ReadSingle();
                data.Unk9_raw = reader.ReadSingle();
                data.Unk10_raw = reader.ReadSingle();
                data.Unk11_raw = reader.ReadSingle();
                data.Unk12_raw = reader.ReadSingle();
                data.Unk13_raw = reader.ReadSingle();
                data.Unk14_raw = reader.ReadByte();
                data.End_raw = reader.ReadInt32();
                return data;
            }

            public override void WriteData(BinaryWriter writer) {
                writer.Write(Unk1_raw);
                writer.Write(Unk2_raw);
                writer.Write(Unk3_raw);
                writer.Write(Unk4_raw);
                writer.Write(Unk5_raw);
                writer.Write(Unk6_raw);
                writer.Write(Unk7_raw);
                writer.Write(Unk8_raw);
                writer.Write(Unk9_raw);
                writer.Write(Unk10_raw);
                writer.Write(Unk11_raw);
                writer.Write(Unk12_raw);
                writer.Write(Unk13_raw);
                writer.Write(Unk14_raw);
                writer.Write(End_raw);
            }
        }

        public partial class W12p_Params_4_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView> {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W12p Params (4)";

            protected float Unk85_raw;
            public const string Unk85_displayName = "Unk85";
            public const int Unk85_sortIndex = 50;
            [SortOrder(Unk85_sortIndex)]
            [DisplayName(Unk85_displayName)]
            public virtual float Unk85 {
                get => Unk85_raw;
                set {
                    if (Unk85_raw == value) return;
                    Unk85_raw = value;
                    OnPropertyChanged(nameof(Unk85));
                }
            }

            protected float Unk86_raw;
            public const string Unk86_displayName = "Unk86";
            public const int Unk86_sortIndex = 100;
            [SortOrder(Unk86_sortIndex)]
            [DisplayName(Unk86_displayName)]
            public virtual float Unk86 {
                get => Unk86_raw;
                set {
                    if (Unk86_raw == value) return;
                    Unk86_raw = value;
                    OnPropertyChanged(nameof(Unk86));
                }
            }

            protected float Unk87_raw;
            public const string Unk87_displayName = "Unk87";
            public const int Unk87_sortIndex = 150;
            [SortOrder(Unk87_sortIndex)]
            [DisplayName(Unk87_displayName)]
            public virtual float Unk87 {
                get => Unk87_raw;
                set {
                    if (Unk87_raw == value) return;
                    Unk87_raw = value;
                    OnPropertyChanged(nameof(Unk87));
                }
            }

            protected float Unk88_raw;
            public const string Unk88_displayName = "Unk88";
            public const int Unk88_sortIndex = 200;
            [SortOrder(Unk88_sortIndex)]
            [DisplayName(Unk88_displayName)]
            public virtual float Unk88 {
                get => Unk88_raw;
                set {
                    if (Unk88_raw == value) return;
                    Unk88_raw = value;
                    OnPropertyChanged(nameof(Unk88));
                }
            }

            protected float Unk89_raw;
            public const string Unk89_displayName = "Unk89";
            public const int Unk89_sortIndex = 250;
            [SortOrder(Unk89_sortIndex)]
            [DisplayName(Unk89_displayName)]
            public virtual float Unk89 {
                get => Unk89_raw;
                set {
                    if (Unk89_raw == value) return;
                    Unk89_raw = value;
                    OnPropertyChanged(nameof(Unk89));
                }
            }

            protected float Unk90_raw;
            public const string Unk90_displayName = "Unk90";
            public const int Unk90_sortIndex = 300;
            [SortOrder(Unk90_sortIndex)]
            [DisplayName(Unk90_displayName)]
            public virtual float Unk90 {
                get => Unk90_raw;
                set {
                    if (Unk90_raw == value) return;
                    Unk90_raw = value;
                    OnPropertyChanged(nameof(Unk90));
                }
            }

            protected float Unk91_raw;
            public const string Unk91_displayName = "Unk91";
            public const int Unk91_sortIndex = 350;
            [SortOrder(Unk91_sortIndex)]
            [DisplayName(Unk91_displayName)]
            public virtual float Unk91 {
                get => Unk91_raw;
                set {
                    if (Unk91_raw == value) return;
                    Unk91_raw = value;
                    OnPropertyChanged(nameof(Unk91));
                }
            }

            protected float Unk92_raw;
            public const string Unk92_displayName = "Unk92";
            public const int Unk92_sortIndex = 400;
            [SortOrder(Unk92_sortIndex)]
            [DisplayName(Unk92_displayName)]
            public virtual float Unk92 {
                get => Unk92_raw;
                set {
                    if (Unk92_raw == value) return;
                    Unk92_raw = value;
                    OnPropertyChanged(nameof(Unk92));
                }
            }

            protected float Unk93_raw;
            public const string Unk93_displayName = "Unk93";
            public const int Unk93_sortIndex = 450;
            [SortOrder(Unk93_sortIndex)]
            [DisplayName(Unk93_displayName)]
            public virtual float Unk93 {
                get => Unk93_raw;
                set {
                    if (Unk93_raw == value) return;
                    Unk93_raw = value;
                    OnPropertyChanged(nameof(Unk93));
                }
            }

            protected float Unk94_raw;
            public const string Unk94_displayName = "Unk94";
            public const int Unk94_sortIndex = 500;
            [SortOrder(Unk94_sortIndex)]
            [DisplayName(Unk94_displayName)]
            public virtual float Unk94 {
                get => Unk94_raw;
                set {
                    if (Unk94_raw == value) return;
                    Unk94_raw = value;
                    OnPropertyChanged(nameof(Unk94));
                }
            }

            protected float Unk95_raw;
            public const string Unk95_displayName = "Unk95";
            public const int Unk95_sortIndex = 550;
            [SortOrder(Unk95_sortIndex)]
            [DisplayName(Unk95_displayName)]
            public virtual float Unk95 {
                get => Unk95_raw;
                set {
                    if (Unk95_raw == value) return;
                    Unk95_raw = value;
                    OnPropertyChanged(nameof(Unk95));
                }
            }

            protected float Unk96_raw;
            public const string Unk96_displayName = "Unk96";
            public const int Unk96_sortIndex = 600;
            [SortOrder(Unk96_sortIndex)]
            [DisplayName(Unk96_displayName)]
            public virtual float Unk96 {
                get => Unk96_raw;
                set {
                    if (Unk96_raw == value) return;
                    Unk96_raw = value;
                    OnPropertyChanged(nameof(Unk96));
                }
            }

            protected float Unk97_raw;
            public const string Unk97_displayName = "Unk97";
            public const int Unk97_sortIndex = 650;
            [SortOrder(Unk97_sortIndex)]
            [DisplayName(Unk97_displayName)]
            public virtual float Unk97 {
                get => Unk97_raw;
                set {
                    if (Unk97_raw == value) return;
                    Unk97_raw = value;
                    OnPropertyChanged(nameof(Unk97));
                }
            }

            protected float Unk98_raw;
            public const string Unk98_displayName = "Unk98";
            public const int Unk98_sortIndex = 700;
            [SortOrder(Unk98_sortIndex)]
            [DisplayName(Unk98_displayName)]
            public virtual float Unk98 {
                get => Unk98_raw;
                set {
                    if (Unk98_raw == value) return;
                    Unk98_raw = value;
                    OnPropertyChanged(nameof(Unk98));
                }
            }

            protected float Unk99_raw;
            public const string Unk99_displayName = "Unk99";
            public const int Unk99_sortIndex = 750;
            [SortOrder(Unk99_sortIndex)]
            [DisplayName(Unk99_displayName)]
            public virtual float Unk99 {
                get => Unk99_raw;
                set {
                    if (Unk99_raw == value) return;
                    Unk99_raw = value;
                    OnPropertyChanged(nameof(Unk99));
                }
            }

            protected float Unk100_raw;
            public const string Unk100_displayName = "Unk100";
            public const int Unk100_sortIndex = 800;
            [SortOrder(Unk100_sortIndex)]
            [DisplayName(Unk100_displayName)]
            public virtual float Unk100 {
                get => Unk100_raw;
                set {
                    if (Unk100_raw == value) return;
                    Unk100_raw = value;
                    OnPropertyChanged(nameof(Unk100));
                }
            }

            protected float Unk101_raw;
            public const string Unk101_displayName = "Unk101";
            public const int Unk101_sortIndex = 850;
            [SortOrder(Unk101_sortIndex)]
            [DisplayName(Unk101_displayName)]
            public virtual float Unk101 {
                get => Unk101_raw;
                set {
                    if (Unk101_raw == value) return;
                    Unk101_raw = value;
                    OnPropertyChanged(nameof(Unk101));
                }
            }

            protected float Unk102_raw;
            public const string Unk102_displayName = "Unk102";
            public const int Unk102_sortIndex = 900;
            [SortOrder(Unk102_sortIndex)]
            [DisplayName(Unk102_displayName)]
            public virtual float Unk102 {
                get => Unk102_raw;
                set {
                    if (Unk102_raw == value) return;
                    Unk102_raw = value;
                    OnPropertyChanged(nameof(Unk102));
                }
            }

            protected float Unk103_raw;
            public const string Unk103_displayName = "Unk103";
            public const int Unk103_sortIndex = 950;
            [SortOrder(Unk103_sortIndex)]
            [DisplayName(Unk103_displayName)]
            public virtual float Unk103 {
                get => Unk103_raw;
                set {
                    if (Unk103_raw == value) return;
                    Unk103_raw = value;
                    OnPropertyChanged(nameof(Unk103));
                }
            }

            protected float Unk104_raw;
            public const string Unk104_displayName = "Unk104";
            public const int Unk104_sortIndex = 1000;
            [SortOrder(Unk104_sortIndex)]
            [DisplayName(Unk104_displayName)]
            public virtual float Unk104 {
                get => Unk104_raw;
                set {
                    if (Unk104_raw == value) return;
                    Unk104_raw = value;
                    OnPropertyChanged(nameof(Unk104));
                }
            }

            protected float Unk105_raw;
            public const string Unk105_displayName = "Unk105";
            public const int Unk105_sortIndex = 1050;
            [SortOrder(Unk105_sortIndex)]
            [DisplayName(Unk105_displayName)]
            public virtual float Unk105 {
                get => Unk105_raw;
                set {
                    if (Unk105_raw == value) return;
                    Unk105_raw = value;
                    OnPropertyChanged(nameof(Unk105));
                }
            }

            protected uint Unk106___s____raw;
            public const string Unk106___s____displayName = "Unk106___s___";
            public const int Unk106___s____sortIndex = 1100;
            [SortOrder(Unk106___s____sortIndex)]
            [DisplayName(Unk106___s____displayName)]
            public virtual uint Unk106___s___ {
                get => Unk106___s____raw;
                set {
                    if (Unk106___s____raw == value) return;
                    Unk106___s____raw = value;
                    OnPropertyChanged(nameof(Unk106___s___));
                }
            }

            protected float Unk107_raw;
            public const string Unk107_displayName = "Unk107";
            public const int Unk107_sortIndex = 1150;
            [SortOrder(Unk107_sortIndex)]
            [DisplayName(Unk107_displayName)]
            public virtual float Unk107 {
                get => Unk107_raw;
                set {
                    if (Unk107_raw == value) return;
                    Unk107_raw = value;
                    OnPropertyChanged(nameof(Unk107));
                }
            }

            protected uint Unk108___raw;
            public const string Unk108___displayName = "Unk108__";
            public const int Unk108___sortIndex = 1200;
            [SortOrder(Unk108___sortIndex)]
            [DisplayName(Unk108___displayName)]
            public virtual uint Unk108__ {
                get => Unk108___raw;
                set {
                    if (Unk108___raw == value) return;
                    Unk108___raw = value;
                    OnPropertyChanged(nameof(Unk108__));
                }
            }

            protected float Unk109_raw;
            public const string Unk109_displayName = "Unk109";
            public const int Unk109_sortIndex = 1250;
            [SortOrder(Unk109_sortIndex)]
            [DisplayName(Unk109_displayName)]
            public virtual float Unk109 {
                get => Unk109_raw;
                set {
                    if (Unk109_raw == value) return;
                    Unk109_raw = value;
                    OnPropertyChanged(nameof(Unk109));
                }
            }

            protected uint Unk110___raw;
            public const string Unk110___displayName = "Unk110__";
            public const int Unk110___sortIndex = 1300;
            [SortOrder(Unk110___sortIndex)]
            [DisplayName(Unk110___displayName)]
            public virtual uint Unk110__ {
                get => Unk110___raw;
                set {
                    if (Unk110___raw == value) return;
                    Unk110___raw = value;
                    OnPropertyChanged(nameof(Unk110__));
                }
            }

            protected float Unk111_raw;
            public const string Unk111_displayName = "Unk111";
            public const int Unk111_sortIndex = 1350;
            [SortOrder(Unk111_sortIndex)]
            [DisplayName(Unk111_displayName)]
            public virtual float Unk111 {
                get => Unk111_raw;
                set {
                    if (Unk111_raw == value) return;
                    Unk111_raw = value;
                    OnPropertyChanged(nameof(Unk111));
                }
            }

            protected uint Unk112___raw;
            public const string Unk112___displayName = "Unk112__";
            public const int Unk112___sortIndex = 1400;
            [SortOrder(Unk112___sortIndex)]
            [DisplayName(Unk112___displayName)]
            public virtual uint Unk112__ {
                get => Unk112___raw;
                set {
                    if (Unk112___raw == value) return;
                    Unk112___raw = value;
                    OnPropertyChanged(nameof(Unk112__));
                }
            }

            protected float Unk113___e____raw;
            public const string Unk113___e____displayName = "Unk113___e___";
            public const int Unk113___e____sortIndex = 1450;
            [SortOrder(Unk113___e____sortIndex)]
            [DisplayName(Unk113___e____displayName)]
            public virtual float Unk113___e___ {
                get => Unk113___e____raw;
                set {
                    if (Unk113___e____raw == value) return;
                    Unk113___e____raw = value;
                    OnPropertyChanged(nameof(Unk113___e___));
                }
            }

            protected float Unk114_raw;
            public const string Unk114_displayName = "Unk114";
            public const int Unk114_sortIndex = 1500;
            [SortOrder(Unk114_sortIndex)]
            [DisplayName(Unk114_displayName)]
            public virtual float Unk114 {
                get => Unk114_raw;
                set {
                    if (Unk114_raw == value) return;
                    Unk114_raw = value;
                    OnPropertyChanged(nameof(Unk114));
                }
            }

            protected float Unk115_raw;
            public const string Unk115_displayName = "Unk115";
            public const int Unk115_sortIndex = 1550;
            [SortOrder(Unk115_sortIndex)]
            [DisplayName(Unk115_displayName)]
            public virtual float Unk115 {
                get => Unk115_raw;
                set {
                    if (Unk115_raw == value) return;
                    Unk115_raw = value;
                    OnPropertyChanged(nameof(Unk115));
                }
            }

            protected float Unk116_raw;
            public const string Unk116_displayName = "Unk116";
            public const int Unk116_sortIndex = 1600;
            [SortOrder(Unk116_sortIndex)]
            [DisplayName(Unk116_displayName)]
            public virtual float Unk116 {
                get => Unk116_raw;
                set {
                    if (Unk116_raw == value) return;
                    Unk116_raw = value;
                    OnPropertyChanged(nameof(Unk116));
                }
            }

            protected float Unk117_raw;
            public const string Unk117_displayName = "Unk117";
            public const int Unk117_sortIndex = 1650;
            [SortOrder(Unk117_sortIndex)]
            [DisplayName(Unk117_displayName)]
            public virtual float Unk117 {
                get => Unk117_raw;
                set {
                    if (Unk117_raw == value) return;
                    Unk117_raw = value;
                    OnPropertyChanged(nameof(Unk117));
                }
            }

            protected float Unk118_raw;
            public const string Unk118_displayName = "Unk118";
            public const int Unk118_sortIndex = 1700;
            [SortOrder(Unk118_sortIndex)]
            [DisplayName(Unk118_displayName)]
            public virtual float Unk118 {
                get => Unk118_raw;
                set {
                    if (Unk118_raw == value) return;
                    Unk118_raw = value;
                    OnPropertyChanged(nameof(Unk118));
                }
            }

            protected float Unk119_raw;
            public const string Unk119_displayName = "Unk119";
            public const int Unk119_sortIndex = 1750;
            [SortOrder(Unk119_sortIndex)]
            [DisplayName(Unk119_displayName)]
            public virtual float Unk119 {
                get => Unk119_raw;
                set {
                    if (Unk119_raw == value) return;
                    Unk119_raw = value;
                    OnPropertyChanged(nameof(Unk119));
                }
            }

            protected float Unk120_raw;
            public const string Unk120_displayName = "Unk120";
            public const int Unk120_sortIndex = 1800;
            [SortOrder(Unk120_sortIndex)]
            [DisplayName(Unk120_displayName)]
            public virtual float Unk120 {
                get => Unk120_raw;
                set {
                    if (Unk120_raw == value) return;
                    Unk120_raw = value;
                    OnPropertyChanged(nameof(Unk120));
                }
            }

            protected float Unk121_raw;
            public const string Unk121_displayName = "Unk121";
            public const int Unk121_sortIndex = 1850;
            [SortOrder(Unk121_sortIndex)]
            [DisplayName(Unk121_displayName)]
            public virtual float Unk121 {
                get => Unk121_raw;
                set {
                    if (Unk121_raw == value) return;
                    Unk121_raw = value;
                    OnPropertyChanged(nameof(Unk121));
                }
            }

            protected float Unk122_raw;
            public const string Unk122_displayName = "Unk122";
            public const int Unk122_sortIndex = 1900;
            [SortOrder(Unk122_sortIndex)]
            [DisplayName(Unk122_displayName)]
            public virtual float Unk122 {
                get => Unk122_raw;
                set {
                    if (Unk122_raw == value) return;
                    Unk122_raw = value;
                    OnPropertyChanged(nameof(Unk122));
                }
            }

            protected float Unk123_raw;
            public const string Unk123_displayName = "Unk123";
            public const int Unk123_sortIndex = 1950;
            [SortOrder(Unk123_sortIndex)]
            [DisplayName(Unk123_displayName)]
            public virtual float Unk123 {
                get => Unk123_raw;
                set {
                    if (Unk123_raw == value) return;
                    Unk123_raw = value;
                    OnPropertyChanged(nameof(Unk123));
                }
            }

            protected float Unk124_raw;
            public const string Unk124_displayName = "Unk124";
            public const int Unk124_sortIndex = 2000;
            [SortOrder(Unk124_sortIndex)]
            [DisplayName(Unk124_displayName)]
            public virtual float Unk124 {
                get => Unk124_raw;
                set {
                    if (Unk124_raw == value) return;
                    Unk124_raw = value;
                    OnPropertyChanged(nameof(Unk124));
                }
            }

            protected float Unk125_raw;
            public const string Unk125_displayName = "Unk125";
            public const int Unk125_sortIndex = 2050;
            [SortOrder(Unk125_sortIndex)]
            [DisplayName(Unk125_displayName)]
            public virtual float Unk125 {
                get => Unk125_raw;
                set {
                    if (Unk125_raw == value) return;
                    Unk125_raw = value;
                    OnPropertyChanged(nameof(Unk125));
                }
            }

            protected float Unk126_raw;
            public const string Unk126_displayName = "Unk126";
            public const int Unk126_sortIndex = 2100;
            [SortOrder(Unk126_sortIndex)]
            [DisplayName(Unk126_displayName)]
            public virtual float Unk126 {
                get => Unk126_raw;
                set {
                    if (Unk126_raw == value) return;
                    Unk126_raw = value;
                    OnPropertyChanged(nameof(Unk126));
                }
            }

            protected float Unk127___s____raw;
            public const string Unk127___s____displayName = "Unk127___s___";
            public const int Unk127___s____sortIndex = 2150;
            [SortOrder(Unk127___s____sortIndex)]
            [DisplayName(Unk127___s____displayName)]
            public virtual float Unk127___s___ {
                get => Unk127___s____raw;
                set {
                    if (Unk127___s____raw == value) return;
                    Unk127___s____raw = value;
                    OnPropertyChanged(nameof(Unk127___s___));
                }
            }

            protected float Unk128_raw;
            public const string Unk128_displayName = "Unk128";
            public const int Unk128_sortIndex = 2200;
            [SortOrder(Unk128_sortIndex)]
            [DisplayName(Unk128_displayName)]
            public virtual float Unk128 {
                get => Unk128_raw;
                set {
                    if (Unk128_raw == value) return;
                    Unk128_raw = value;
                    OnPropertyChanged(nameof(Unk128));
                }
            }

            protected float Unk129_raw;
            public const string Unk129_displayName = "Unk129";
            public const int Unk129_sortIndex = 2250;
            [SortOrder(Unk129_sortIndex)]
            [DisplayName(Unk129_displayName)]
            public virtual float Unk129 {
                get => Unk129_raw;
                set {
                    if (Unk129_raw == value) return;
                    Unk129_raw = value;
                    OnPropertyChanged(nameof(Unk129));
                }
            }

            protected float Unk130_raw;
            public const string Unk130_displayName = "Unk130";
            public const int Unk130_sortIndex = 2300;
            [SortOrder(Unk130_sortIndex)]
            [DisplayName(Unk130_displayName)]
            public virtual float Unk130 {
                get => Unk130_raw;
                set {
                    if (Unk130_raw == value) return;
                    Unk130_raw = value;
                    OnPropertyChanged(nameof(Unk130));
                }
            }

            protected float Unk131_raw;
            public const string Unk131_displayName = "Unk131";
            public const int Unk131_sortIndex = 2350;
            [SortOrder(Unk131_sortIndex)]
            [DisplayName(Unk131_displayName)]
            public virtual float Unk131 {
                get => Unk131_raw;
                set {
                    if (Unk131_raw == value) return;
                    Unk131_raw = value;
                    OnPropertyChanged(nameof(Unk131));
                }
            }

            protected float Unk132_raw;
            public const string Unk132_displayName = "Unk132";
            public const int Unk132_sortIndex = 2400;
            [SortOrder(Unk132_sortIndex)]
            [DisplayName(Unk132_displayName)]
            public virtual float Unk132 {
                get => Unk132_raw;
                set {
                    if (Unk132_raw == value) return;
                    Unk132_raw = value;
                    OnPropertyChanged(nameof(Unk132));
                }
            }

            protected float Unk133_raw;
            public const string Unk133_displayName = "Unk133";
            public const int Unk133_sortIndex = 2450;
            [SortOrder(Unk133_sortIndex)]
            [DisplayName(Unk133_displayName)]
            public virtual float Unk133 {
                get => Unk133_raw;
                set {
                    if (Unk133_raw == value) return;
                    Unk133_raw = value;
                    OnPropertyChanged(nameof(Unk133));
                }
            }

            protected float Unk134_raw;
            public const string Unk134_displayName = "Unk134";
            public const int Unk134_sortIndex = 2500;
            [SortOrder(Unk134_sortIndex)]
            [DisplayName(Unk134_displayName)]
            public virtual float Unk134 {
                get => Unk134_raw;
                set {
                    if (Unk134_raw == value) return;
                    Unk134_raw = value;
                    OnPropertyChanged(nameof(Unk134));
                }
            }

            protected float Unk135_raw;
            public const string Unk135_displayName = "Unk135";
            public const int Unk135_sortIndex = 2550;
            [SortOrder(Unk135_sortIndex)]
            [DisplayName(Unk135_displayName)]
            public virtual float Unk135 {
                get => Unk135_raw;
                set {
                    if (Unk135_raw == value) return;
                    Unk135_raw = value;
                    OnPropertyChanged(nameof(Unk135));
                }
            }

            protected float Unk136___raw;
            public const string Unk136___displayName = "Unk136__";
            public const int Unk136___sortIndex = 2600;
            [SortOrder(Unk136___sortIndex)]
            [DisplayName(Unk136___displayName)]
            public virtual float Unk136__ {
                get => Unk136___raw;
                set {
                    if (Unk136___raw == value) return;
                    Unk136___raw = value;
                    OnPropertyChanged(nameof(Unk136__));
                }
            }

            protected float Unk137_raw;
            public const string Unk137_displayName = "Unk137";
            public const int Unk137_sortIndex = 2650;
            [SortOrder(Unk137_sortIndex)]
            [DisplayName(Unk137_displayName)]
            public virtual float Unk137 {
                get => Unk137_raw;
                set {
                    if (Unk137_raw == value) return;
                    Unk137_raw = value;
                    OnPropertyChanged(nameof(Unk137));
                }
            }

            protected float Unk138_raw;
            public const string Unk138_displayName = "Unk138";
            public const int Unk138_sortIndex = 2700;
            [SortOrder(Unk138_sortIndex)]
            [DisplayName(Unk138_displayName)]
            public virtual float Unk138 {
                get => Unk138_raw;
                set {
                    if (Unk138_raw == value) return;
                    Unk138_raw = value;
                    OnPropertyChanged(nameof(Unk138));
                }
            }

            protected float Unk139_raw;
            public const string Unk139_displayName = "Unk139";
            public const int Unk139_sortIndex = 2750;
            [SortOrder(Unk139_sortIndex)]
            [DisplayName(Unk139_displayName)]
            public virtual float Unk139 {
                get => Unk139_raw;
                set {
                    if (Unk139_raw == value) return;
                    Unk139_raw = value;
                    OnPropertyChanged(nameof(Unk139));
                }
            }

            protected float Unk140_raw;
            public const string Unk140_displayName = "Unk140";
            public const int Unk140_sortIndex = 2800;
            [SortOrder(Unk140_sortIndex)]
            [DisplayName(Unk140_displayName)]
            public virtual float Unk140 {
                get => Unk140_raw;
                set {
                    if (Unk140_raw == value) return;
                    Unk140_raw = value;
                    OnPropertyChanged(nameof(Unk140));
                }
            }

            protected float Unk141_raw;
            public const string Unk141_displayName = "Unk141";
            public const int Unk141_sortIndex = 2850;
            [SortOrder(Unk141_sortIndex)]
            [DisplayName(Unk141_displayName)]
            public virtual float Unk141 {
                get => Unk141_raw;
                set {
                    if (Unk141_raw == value) return;
                    Unk141_raw = value;
                    OnPropertyChanged(nameof(Unk141));
                }
            }

            protected float Unk142_raw;
            public const string Unk142_displayName = "Unk142";
            public const int Unk142_sortIndex = 2900;
            [SortOrder(Unk142_sortIndex)]
            [DisplayName(Unk142_displayName)]
            public virtual float Unk142 {
                get => Unk142_raw;
                set {
                    if (Unk142_raw == value) return;
                    Unk142_raw = value;
                    OnPropertyChanged(nameof(Unk142));
                }
            }

            protected float Unk143_raw;
            public const string Unk143_displayName = "Unk143";
            public const int Unk143_sortIndex = 2950;
            [SortOrder(Unk143_sortIndex)]
            [DisplayName(Unk143_displayName)]
            public virtual float Unk143 {
                get => Unk143_raw;
                set {
                    if (Unk143_raw == value) return;
                    Unk143_raw = value;
                    OnPropertyChanged(nameof(Unk143));
                }
            }

            protected float Unk144_raw;
            public const string Unk144_displayName = "Unk144";
            public const int Unk144_sortIndex = 3000;
            [SortOrder(Unk144_sortIndex)]
            [DisplayName(Unk144_displayName)]
            public virtual float Unk144 {
                get => Unk144_raw;
                set {
                    if (Unk144_raw == value) return;
                    Unk144_raw = value;
                    OnPropertyChanged(nameof(Unk144));
                }
            }

            protected float Unk145_raw;
            public const string Unk145_displayName = "Unk145";
            public const int Unk145_sortIndex = 3050;
            [SortOrder(Unk145_sortIndex)]
            [DisplayName(Unk145_displayName)]
            public virtual float Unk145 {
                get => Unk145_raw;
                set {
                    if (Unk145_raw == value) return;
                    Unk145_raw = value;
                    OnPropertyChanged(nameof(Unk145));
                }
            }

            protected float Unk146___e____raw;
            public const string Unk146___e____displayName = "Unk146___e___";
            public const int Unk146___e____sortIndex = 3100;
            [SortOrder(Unk146___e____sortIndex)]
            [DisplayName(Unk146___e____displayName)]
            public virtual float Unk146___e___ {
                get => Unk146___e____raw;
                set {
                    if (Unk146___e____raw == value) return;
                    Unk146___e____raw = value;
                    OnPropertyChanged(nameof(Unk146___e___));
                }
            }

            protected float Unk147_raw;
            public const string Unk147_displayName = "Unk147";
            public const int Unk147_sortIndex = 3150;
            [SortOrder(Unk147_sortIndex)]
            [DisplayName(Unk147_displayName)]
            public virtual float Unk147 {
                get => Unk147_raw;
                set {
                    if (Unk147_raw == value) return;
                    Unk147_raw = value;
                    OnPropertyChanged(nameof(Unk147));
                }
            }

            protected float Unk148_raw;
            public const string Unk148_displayName = "Unk148";
            public const int Unk148_sortIndex = 3200;
            [SortOrder(Unk148_sortIndex)]
            [DisplayName(Unk148_displayName)]
            public virtual float Unk148 {
                get => Unk148_raw;
                set {
                    if (Unk148_raw == value) return;
                    Unk148_raw = value;
                    OnPropertyChanged(nameof(Unk148));
                }
            }

            protected float Unk149_raw;
            public const string Unk149_displayName = "Unk149";
            public const int Unk149_sortIndex = 3250;
            [SortOrder(Unk149_sortIndex)]
            [DisplayName(Unk149_displayName)]
            public virtual float Unk149 {
                get => Unk149_raw;
                set {
                    if (Unk149_raw == value) return;
                    Unk149_raw = value;
                    OnPropertyChanged(nameof(Unk149));
                }
            }

            protected float Unk150_raw;
            public const string Unk150_displayName = "Unk150";
            public const int Unk150_sortIndex = 3300;
            [SortOrder(Unk150_sortIndex)]
            [DisplayName(Unk150_displayName)]
            public virtual float Unk150 {
                get => Unk150_raw;
                set {
                    if (Unk150_raw == value) return;
                    Unk150_raw = value;
                    OnPropertyChanged(nameof(Unk150));
                }
            }

            protected float Unk151_raw;
            public const string Unk151_displayName = "Unk151";
            public const int Unk151_sortIndex = 3350;
            [SortOrder(Unk151_sortIndex)]
            [DisplayName(Unk151_displayName)]
            public virtual float Unk151 {
                get => Unk151_raw;
                set {
                    if (Unk151_raw == value) return;
                    Unk151_raw = value;
                    OnPropertyChanged(nameof(Unk151));
                }
            }

            protected float Unk152_raw;
            public const string Unk152_displayName = "Unk152";
            public const int Unk152_sortIndex = 3400;
            [SortOrder(Unk152_sortIndex)]
            [DisplayName(Unk152_displayName)]
            public virtual float Unk152 {
                get => Unk152_raw;
                set {
                    if (Unk152_raw == value) return;
                    Unk152_raw = value;
                    OnPropertyChanged(nameof(Unk152));
                }
            }

            protected float Unk153_raw;
            public const string Unk153_displayName = "Unk153";
            public const int Unk153_sortIndex = 3450;
            [SortOrder(Unk153_sortIndex)]
            [DisplayName(Unk153_displayName)]
            public virtual float Unk153 {
                get => Unk153_raw;
                set {
                    if (Unk153_raw == value) return;
                    Unk153_raw = value;
                    OnPropertyChanged(nameof(Unk153));
                }
            }

            protected float Unk154_raw;
            public const string Unk154_displayName = "Unk154";
            public const int Unk154_sortIndex = 3500;
            [SortOrder(Unk154_sortIndex)]
            [DisplayName(Unk154_displayName)]
            public virtual float Unk154 {
                get => Unk154_raw;
                set {
                    if (Unk154_raw == value) return;
                    Unk154_raw = value;
                    OnPropertyChanged(nameof(Unk154));
                }
            }

            protected float Unk155_raw;
            public const string Unk155_displayName = "Unk155";
            public const int Unk155_sortIndex = 3550;
            [SortOrder(Unk155_sortIndex)]
            [DisplayName(Unk155_displayName)]
            public virtual float Unk155 {
                get => Unk155_raw;
                set {
                    if (Unk155_raw == value) return;
                    Unk155_raw = value;
                    OnPropertyChanged(nameof(Unk155));
                }
            }

            protected float Unk156_raw;
            public const string Unk156_displayName = "Unk156";
            public const int Unk156_sortIndex = 3600;
            [SortOrder(Unk156_sortIndex)]
            [DisplayName(Unk156_displayName)]
            public virtual float Unk156 {
                get => Unk156_raw;
                set {
                    if (Unk156_raw == value) return;
                    Unk156_raw = value;
                    OnPropertyChanged(nameof(Unk156));
                }
            }

            protected float Unk157_raw;
            public const string Unk157_displayName = "Unk157";
            public const int Unk157_sortIndex = 3650;
            [SortOrder(Unk157_sortIndex)]
            [DisplayName(Unk157_displayName)]
            public virtual float Unk157 {
                get => Unk157_raw;
                set {
                    if (Unk157_raw == value) return;
                    Unk157_raw = value;
                    OnPropertyChanged(nameof(Unk157));
                }
            }

            protected float Unk158_raw;
            public const string Unk158_displayName = "Unk158";
            public const int Unk158_sortIndex = 3700;
            [SortOrder(Unk158_sortIndex)]
            [DisplayName(Unk158_displayName)]
            public virtual float Unk158 {
                get => Unk158_raw;
                set {
                    if (Unk158_raw == value) return;
                    Unk158_raw = value;
                    OnPropertyChanged(nameof(Unk158));
                }
            }

            protected float Unk159_raw;
            public const string Unk159_displayName = "Unk159";
            public const int Unk159_sortIndex = 3750;
            [SortOrder(Unk159_sortIndex)]
            [DisplayName(Unk159_displayName)]
            public virtual float Unk159 {
                get => Unk159_raw;
                set {
                    if (Unk159_raw == value) return;
                    Unk159_raw = value;
                    OnPropertyChanged(nameof(Unk159));
                }
            }

            protected float Unk160_raw;
            public const string Unk160_displayName = "Unk160";
            public const int Unk160_sortIndex = 3800;
            [SortOrder(Unk160_sortIndex)]
            [DisplayName(Unk160_displayName)]
            public virtual float Unk160 {
                get => Unk160_raw;
                set {
                    if (Unk160_raw == value) return;
                    Unk160_raw = value;
                    OnPropertyChanged(nameof(Unk160));
                }
            }

            protected float Unk161_raw;
            public const string Unk161_displayName = "Unk161";
            public const int Unk161_sortIndex = 3850;
            [SortOrder(Unk161_sortIndex)]
            [DisplayName(Unk161_displayName)]
            public virtual float Unk161 {
                get => Unk161_raw;
                set {
                    if (Unk161_raw == value) return;
                    Unk161_raw = value;
                    OnPropertyChanged(nameof(Unk161));
                }
            }

            protected float Unk162_raw;
            public const string Unk162_displayName = "Unk162";
            public const int Unk162_sortIndex = 3900;
            [SortOrder(Unk162_sortIndex)]
            [DisplayName(Unk162_displayName)]
            public virtual float Unk162 {
                get => Unk162_raw;
                set {
                    if (Unk162_raw == value) return;
                    Unk162_raw = value;
                    OnPropertyChanged(nameof(Unk162));
                }
            }

            protected float Unk163_raw;
            public const string Unk163_displayName = "Unk163";
            public const int Unk163_sortIndex = 3950;
            [SortOrder(Unk163_sortIndex)]
            [DisplayName(Unk163_displayName)]
            public virtual float Unk163 {
                get => Unk163_raw;
                set {
                    if (Unk163_raw == value) return;
                    Unk163_raw = value;
                    OnPropertyChanged(nameof(Unk163));
                }
            }

            protected float Unk164_raw;
            public const string Unk164_displayName = "Unk164";
            public const int Unk164_sortIndex = 4000;
            [SortOrder(Unk164_sortIndex)]
            [DisplayName(Unk164_displayName)]
            public virtual float Unk164 {
                get => Unk164_raw;
                set {
                    if (Unk164_raw == value) return;
                    Unk164_raw = value;
                    OnPropertyChanged(nameof(Unk164));
                }
            }

            protected float Unk165_raw;
            public const string Unk165_displayName = "Unk165";
            public const int Unk165_sortIndex = 4050;
            [SortOrder(Unk165_sortIndex)]
            [DisplayName(Unk165_displayName)]
            public virtual float Unk165 {
                get => Unk165_raw;
                set {
                    if (Unk165_raw == value) return;
                    Unk165_raw = value;
                    OnPropertyChanged(nameof(Unk165));
                }
            }

            protected float Unk166_raw;
            public const string Unk166_displayName = "Unk166";
            public const int Unk166_sortIndex = 4100;
            [SortOrder(Unk166_sortIndex)]
            [DisplayName(Unk166_displayName)]
            public virtual float Unk166 {
                get => Unk166_raw;
                set {
                    if (Unk166_raw == value) return;
                    Unk166_raw = value;
                    OnPropertyChanged(nameof(Unk166));
                }
            }

            protected float Unk167_raw;
            public const string Unk167_displayName = "Unk167";
            public const int Unk167_sortIndex = 4150;
            [SortOrder(Unk167_sortIndex)]
            [DisplayName(Unk167_displayName)]
            public virtual float Unk167 {
                get => Unk167_raw;
                set {
                    if (Unk167_raw == value) return;
                    Unk167_raw = value;
                    OnPropertyChanged(nameof(Unk167));
                }
            }

            protected float Unk168_raw;
            public const string Unk168_displayName = "Unk168";
            public const int Unk168_sortIndex = 4200;
            [SortOrder(Unk168_sortIndex)]
            [DisplayName(Unk168_displayName)]
            public virtual float Unk168 {
                get => Unk168_raw;
                set {
                    if (Unk168_raw == value) return;
                    Unk168_raw = value;
                    OnPropertyChanged(nameof(Unk168));
                }
            }

            protected float Unk169_raw;
            public const string Unk169_displayName = "Unk169";
            public const int Unk169_sortIndex = 4250;
            [SortOrder(Unk169_sortIndex)]
            [DisplayName(Unk169_displayName)]
            public virtual float Unk169 {
                get => Unk169_raw;
                set {
                    if (Unk169_raw == value) return;
                    Unk169_raw = value;
                    OnPropertyChanged(nameof(Unk169));
                }
            }

            protected float Unk170_raw;
            public const string Unk170_displayName = "Unk170";
            public const int Unk170_sortIndex = 4300;
            [SortOrder(Unk170_sortIndex)]
            [DisplayName(Unk170_displayName)]
            public virtual float Unk170 {
                get => Unk170_raw;
                set {
                    if (Unk170_raw == value) return;
                    Unk170_raw = value;
                    OnPropertyChanged(nameof(Unk170));
                }
            }

            protected float Unk171_raw;
            public const string Unk171_displayName = "Unk171";
            public const int Unk171_sortIndex = 4350;
            [SortOrder(Unk171_sortIndex)]
            [DisplayName(Unk171_displayName)]
            public virtual float Unk171 {
                get => Unk171_raw;
                set {
                    if (Unk171_raw == value) return;
                    Unk171_raw = value;
                    OnPropertyChanged(nameof(Unk171));
                }
            }

            protected float Unk172_raw;
            public const string Unk172_displayName = "Unk172";
            public const int Unk172_sortIndex = 4400;
            [SortOrder(Unk172_sortIndex)]
            [DisplayName(Unk172_displayName)]
            public virtual float Unk172 {
                get => Unk172_raw;
                set {
                    if (Unk172_raw == value) return;
                    Unk172_raw = value;
                    OnPropertyChanged(nameof(Unk172));
                }
            }

            protected float Unk173_raw;
            public const string Unk173_displayName = "Unk173";
            public const int Unk173_sortIndex = 4450;
            [SortOrder(Unk173_sortIndex)]
            [DisplayName(Unk173_displayName)]
            public virtual float Unk173 {
                get => Unk173_raw;
                set {
                    if (Unk173_raw == value) return;
                    Unk173_raw = value;
                    OnPropertyChanged(nameof(Unk173));
                }
            }

            protected float Unk174_raw;
            public const string Unk174_displayName = "Unk174";
            public const int Unk174_sortIndex = 4500;
            [SortOrder(Unk174_sortIndex)]
            [DisplayName(Unk174_displayName)]
            public virtual float Unk174 {
                get => Unk174_raw;
                set {
                    if (Unk174_raw == value) return;
                    Unk174_raw = value;
                    OnPropertyChanged(nameof(Unk174));
                }
            }

            protected float Unk175_raw;
            public const string Unk175_displayName = "Unk175";
            public const int Unk175_sortIndex = 4550;
            [SortOrder(Unk175_sortIndex)]
            [DisplayName(Unk175_displayName)]
            public virtual float Unk175 {
                get => Unk175_raw;
                set {
                    if (Unk175_raw == value) return;
                    Unk175_raw = value;
                    OnPropertyChanged(nameof(Unk175));
                }
            }

            protected float Unk176_raw;
            public const string Unk176_displayName = "Unk176";
            public const int Unk176_sortIndex = 4600;
            [SortOrder(Unk176_sortIndex)]
            [DisplayName(Unk176_displayName)]
            public virtual float Unk176 {
                get => Unk176_raw;
                set {
                    if (Unk176_raw == value) return;
                    Unk176_raw = value;
                    OnPropertyChanged(nameof(Unk176));
                }
            }

            protected float Unk177_raw;
            public const string Unk177_displayName = "Unk177";
            public const int Unk177_sortIndex = 4650;
            [SortOrder(Unk177_sortIndex)]
            [DisplayName(Unk177_displayName)]
            public virtual float Unk177 {
                get => Unk177_raw;
                set {
                    if (Unk177_raw == value) return;
                    Unk177_raw = value;
                    OnPropertyChanged(nameof(Unk177));
                }
            }

            protected float Unk178_raw;
            public const string Unk178_displayName = "Unk178";
            public const int Unk178_sortIndex = 4700;
            [SortOrder(Unk178_sortIndex)]
            [DisplayName(Unk178_displayName)]
            public virtual float Unk178 {
                get => Unk178_raw;
                set {
                    if (Unk178_raw == value) return;
                    Unk178_raw = value;
                    OnPropertyChanged(nameof(Unk178));
                }
            }

            protected float Unk179_raw;
            public const string Unk179_displayName = "Unk179";
            public const int Unk179_sortIndex = 4750;
            [SortOrder(Unk179_sortIndex)]
            [DisplayName(Unk179_displayName)]
            public virtual float Unk179 {
                get => Unk179_raw;
                set {
                    if (Unk179_raw == value) return;
                    Unk179_raw = value;
                    OnPropertyChanged(nameof(Unk179));
                }
            }

            protected byte Unk180___s____raw;
            public const string Unk180___s____displayName = "Unk180___s___";
            public const int Unk180___s____sortIndex = 4800;
            [SortOrder(Unk180___s____sortIndex)]
            [DisplayName(Unk180___s____displayName)]
            public virtual byte Unk180___s___ {
                get => Unk180___s____raw;
                set {
                    if (Unk180___s____raw == value) return;
                    Unk180___s____raw = value;
                    OnPropertyChanged(nameof(Unk180___s___));
                }
            }

            protected byte Unk180_raw;
            public const string Unk180_displayName = "Unk180";
            public const int Unk180_sortIndex = 4850;
            [SortOrder(Unk180_sortIndex)]
            [DisplayName(Unk180_displayName)]
            public virtual byte Unk180 {
                get => Unk180_raw;
                set {
                    if (Unk180_raw == value) return;
                    Unk180_raw = value;
                    OnPropertyChanged(nameof(Unk180));
                }
            }

            protected byte Unk181_raw;
            public const string Unk181_displayName = "Unk181";
            public const int Unk181_sortIndex = 4900;
            [SortOrder(Unk181_sortIndex)]
            [DisplayName(Unk181_displayName)]
            public virtual byte Unk181 {
                get => Unk181_raw;
                set {
                    if (Unk181_raw == value) return;
                    Unk181_raw = value;
                    OnPropertyChanged(nameof(Unk181));
                }
            }

            protected byte Unk181_1_raw;
            public const string Unk181_1_displayName = "Unk181.1";
            public const int Unk181_1_sortIndex = 4950;
            [SortOrder(Unk181_1_sortIndex)]
            [DisplayName(Unk181_1_displayName)]
            public virtual byte Unk181_1 {
                get => Unk181_1_raw;
                set {
                    if (Unk181_1_raw == value) return;
                    Unk181_1_raw = value;
                    OnPropertyChanged(nameof(Unk181_1));
                }
            }

            protected ushort Unk182_raw;
            public const string Unk182_displayName = "Unk182";
            public const int Unk182_sortIndex = 5000;
            [SortOrder(Unk182_sortIndex)]
            [DisplayName(Unk182_displayName)]
            public virtual ushort Unk182 {
                get => Unk182_raw;
                set {
                    if (Unk182_raw == value) return;
                    Unk182_raw = value;
                    OnPropertyChanged(nameof(Unk182));
                }
            }

            protected ushort Unk183_raw;
            public const string Unk183_displayName = "Unk183";
            public const int Unk183_sortIndex = 5050;
            [SortOrder(Unk183_sortIndex)]
            [DisplayName(Unk183_displayName)]
            public virtual ushort Unk183 {
                get => Unk183_raw;
                set {
                    if (Unk183_raw == value) return;
                    Unk183_raw = value;
                    OnPropertyChanged(nameof(Unk183));
                }
            }

            protected ushort Unk184_raw;
            public const string Unk184_displayName = "Unk184";
            public const int Unk184_sortIndex = 5100;
            [SortOrder(Unk184_sortIndex)]
            [DisplayName(Unk184_displayName)]
            public virtual ushort Unk184 {
                get => Unk184_raw;
                set {
                    if (Unk184_raw == value) return;
                    Unk184_raw = value;
                    OnPropertyChanged(nameof(Unk184));
                }
            }

            protected ushort Unk185_raw;
            public const string Unk185_displayName = "Unk185";
            public const int Unk185_sortIndex = 5150;
            [SortOrder(Unk185_sortIndex)]
            [DisplayName(Unk185_displayName)]
            public virtual ushort Unk185 {
                get => Unk185_raw;
                set {
                    if (Unk185_raw == value) return;
                    Unk185_raw = value;
                    OnPropertyChanged(nameof(Unk185));
                }
            }

            protected ushort Unk186_raw;
            public const string Unk186_displayName = "Unk186";
            public const int Unk186_sortIndex = 5200;
            [SortOrder(Unk186_sortIndex)]
            [DisplayName(Unk186_displayName)]
            public virtual ushort Unk186 {
                get => Unk186_raw;
                set {
                    if (Unk186_raw == value) return;
                    Unk186_raw = value;
                    OnPropertyChanged(nameof(Unk186));
                }
            }

            protected ushort Unk187_raw;
            public const string Unk187_displayName = "Unk187";
            public const int Unk187_sortIndex = 5250;
            [SortOrder(Unk187_sortIndex)]
            [DisplayName(Unk187_displayName)]
            public virtual ushort Unk187 {
                get => Unk187_raw;
                set {
                    if (Unk187_raw == value) return;
                    Unk187_raw = value;
                    OnPropertyChanged(nameof(Unk187));
                }
            }

            protected ushort Unk188_raw;
            public const string Unk188_displayName = "Unk188";
            public const int Unk188_sortIndex = 5300;
            [SortOrder(Unk188_sortIndex)]
            [DisplayName(Unk188_displayName)]
            public virtual ushort Unk188 {
                get => Unk188_raw;
                set {
                    if (Unk188_raw == value) return;
                    Unk188_raw = value;
                    OnPropertyChanged(nameof(Unk188));
                }
            }

            protected ushort Unk189_raw;
            public const string Unk189_displayName = "Unk189";
            public const int Unk189_sortIndex = 5350;
            [SortOrder(Unk189_sortIndex)]
            [DisplayName(Unk189_displayName)]
            public virtual ushort Unk189 {
                get => Unk189_raw;
                set {
                    if (Unk189_raw == value) return;
                    Unk189_raw = value;
                    OnPropertyChanged(nameof(Unk189));
                }
            }

            protected ushort Unk190_raw;
            public const string Unk190_displayName = "Unk190";
            public const int Unk190_sortIndex = 5400;
            [SortOrder(Unk190_sortIndex)]
            [DisplayName(Unk190_displayName)]
            public virtual ushort Unk190 {
                get => Unk190_raw;
                set {
                    if (Unk190_raw == value) return;
                    Unk190_raw = value;
                    OnPropertyChanged(nameof(Unk190));
                }
            }

            protected ushort Unk191___raw;
            public const string Unk191___displayName = "Unk191__";
            public const int Unk191___sortIndex = 5450;
            [SortOrder(Unk191___sortIndex)]
            [DisplayName(Unk191___displayName)]
            public virtual ushort Unk191__ {
                get => Unk191___raw;
                set {
                    if (Unk191___raw == value) return;
                    Unk191___raw = value;
                    OnPropertyChanged(nameof(Unk191__));
                }
            }

            protected byte Unk192_raw;
            public const string Unk192_displayName = "Unk192";
            public const int Unk192_sortIndex = 5500;
            [SortOrder(Unk192_sortIndex)]
            [DisplayName(Unk192_displayName)]
            public virtual byte Unk192 {
                get => Unk192_raw;
                set {
                    if (Unk192_raw == value) return;
                    Unk192_raw = value;
                    OnPropertyChanged(nameof(Unk192));
                }
            }

            protected byte Unk192_1_raw;
            public const string Unk192_1_displayName = "Unk192.1";
            public const int Unk192_1_sortIndex = 5550;
            [SortOrder(Unk192_1_sortIndex)]
            [DisplayName(Unk192_1_displayName)]
            public virtual byte Unk192_1 {
                get => Unk192_1_raw;
                set {
                    if (Unk192_1_raw == value) return;
                    Unk192_1_raw = value;
                    OnPropertyChanged(nameof(Unk192_1));
                }
            }

            protected byte Unk193_raw;
            public const string Unk193_displayName = "Unk193";
            public const int Unk193_sortIndex = 5600;
            [SortOrder(Unk193_sortIndex)]
            [DisplayName(Unk193_displayName)]
            public virtual byte Unk193 {
                get => Unk193_raw;
                set {
                    if (Unk193_raw == value) return;
                    Unk193_raw = value;
                    OnPropertyChanged(nameof(Unk193));
                }
            }

            protected byte Unk193_1_raw;
            public const string Unk193_1_displayName = "Unk193.1";
            public const int Unk193_1_sortIndex = 5650;
            [SortOrder(Unk193_1_sortIndex)]
            [DisplayName(Unk193_1_displayName)]
            public virtual byte Unk193_1 {
                get => Unk193_1_raw;
                set {
                    if (Unk193_1_raw == value) return;
                    Unk193_1_raw = value;
                    OnPropertyChanged(nameof(Unk193_1));
                }
            }

            protected ushort Unk194_raw;
            public const string Unk194_displayName = "Unk194";
            public const int Unk194_sortIndex = 5700;
            [SortOrder(Unk194_sortIndex)]
            [DisplayName(Unk194_displayName)]
            public virtual ushort Unk194 {
                get => Unk194_raw;
                set {
                    if (Unk194_raw == value) return;
                    Unk194_raw = value;
                    OnPropertyChanged(nameof(Unk194));
                }
            }

            protected ushort Unk195_raw;
            public const string Unk195_displayName = "Unk195";
            public const int Unk195_sortIndex = 5750;
            [SortOrder(Unk195_sortIndex)]
            [DisplayName(Unk195_displayName)]
            public virtual ushort Unk195 {
                get => Unk195_raw;
                set {
                    if (Unk195_raw == value) return;
                    Unk195_raw = value;
                    OnPropertyChanged(nameof(Unk195));
                }
            }

            protected ushort Unk196_raw;
            public const string Unk196_displayName = "Unk196";
            public const int Unk196_sortIndex = 5800;
            [SortOrder(Unk196_sortIndex)]
            [DisplayName(Unk196_displayName)]
            public virtual ushort Unk196 {
                get => Unk196_raw;
                set {
                    if (Unk196_raw == value) return;
                    Unk196_raw = value;
                    OnPropertyChanged(nameof(Unk196));
                }
            }

            protected ushort Unk197_raw;
            public const string Unk197_displayName = "Unk197";
            public const int Unk197_sortIndex = 5850;
            [SortOrder(Unk197_sortIndex)]
            [DisplayName(Unk197_displayName)]
            public virtual ushort Unk197 {
                get => Unk197_raw;
                set {
                    if (Unk197_raw == value) return;
                    Unk197_raw = value;
                    OnPropertyChanged(nameof(Unk197));
                }
            }

            protected ushort Unk198_raw;
            public const string Unk198_displayName = "Unk198";
            public const int Unk198_sortIndex = 5900;
            [SortOrder(Unk198_sortIndex)]
            [DisplayName(Unk198_displayName)]
            public virtual ushort Unk198 {
                get => Unk198_raw;
                set {
                    if (Unk198_raw == value) return;
                    Unk198_raw = value;
                    OnPropertyChanged(nameof(Unk198));
                }
            }

            protected ushort Unk199_raw;
            public const string Unk199_displayName = "Unk199";
            public const int Unk199_sortIndex = 5950;
            [SortOrder(Unk199_sortIndex)]
            [DisplayName(Unk199_displayName)]
            public virtual ushort Unk199 {
                get => Unk199_raw;
                set {
                    if (Unk199_raw == value) return;
                    Unk199_raw = value;
                    OnPropertyChanged(nameof(Unk199));
                }
            }

            protected ushort Unk200_raw;
            public const string Unk200_displayName = "Unk200";
            public const int Unk200_sortIndex = 6000;
            [SortOrder(Unk200_sortIndex)]
            [DisplayName(Unk200_displayName)]
            public virtual ushort Unk200 {
                get => Unk200_raw;
                set {
                    if (Unk200_raw == value) return;
                    Unk200_raw = value;
                    OnPropertyChanged(nameof(Unk200));
                }
            }

            protected ushort Unk201_raw;
            public const string Unk201_displayName = "Unk201";
            public const int Unk201_sortIndex = 6050;
            [SortOrder(Unk201_sortIndex)]
            [DisplayName(Unk201_displayName)]
            public virtual ushort Unk201 {
                get => Unk201_raw;
                set {
                    if (Unk201_raw == value) return;
                    Unk201_raw = value;
                    OnPropertyChanged(nameof(Unk201));
                }
            }

            protected ushort Unk202_raw;
            public const string Unk202_displayName = "Unk202";
            public const int Unk202_sortIndex = 6100;
            [SortOrder(Unk202_sortIndex)]
            [DisplayName(Unk202_displayName)]
            public virtual ushort Unk202 {
                get => Unk202_raw;
                set {
                    if (Unk202_raw == value) return;
                    Unk202_raw = value;
                    OnPropertyChanged(nameof(Unk202));
                }
            }

            protected ushort Unk203___e____raw;
            public const string Unk203___e____displayName = "Unk203___e___";
            public const int Unk203___e____sortIndex = 6150;
            [SortOrder(Unk203___e____sortIndex)]
            [DisplayName(Unk203___e____displayName)]
            public virtual ushort Unk203___e___ {
                get => Unk203___e____raw;
                set {
                    if (Unk203___e____raw == value) return;
                    Unk203___e____raw = value;
                    OnPropertyChanged(nameof(Unk203___e___));
                }
            }

            protected ushort Unk204_raw;
            public const string Unk204_displayName = "Unk204";
            public const int Unk204_sortIndex = 6200;
            [SortOrder(Unk204_sortIndex)]
            [DisplayName(Unk204_displayName)]
            public virtual ushort Unk204 {
                get => Unk204_raw;
                set {
                    if (Unk204_raw == value) return;
                    Unk204_raw = value;
                    OnPropertyChanged(nameof(Unk204));
                }
            }

            protected ushort Unk205_raw;
            public const string Unk205_displayName = "Unk205";
            public const int Unk205_sortIndex = 6250;
            [SortOrder(Unk205_sortIndex)]
            [DisplayName(Unk205_displayName)]
            public virtual ushort Unk205 {
                get => Unk205_raw;
                set {
                    if (Unk205_raw == value) return;
                    Unk205_raw = value;
                    OnPropertyChanged(nameof(Unk205));
                }
            }

            protected ushort Unk206_raw;
            public const string Unk206_displayName = "Unk206";
            public const int Unk206_sortIndex = 6300;
            [SortOrder(Unk206_sortIndex)]
            [DisplayName(Unk206_displayName)]
            public virtual ushort Unk206 {
                get => Unk206_raw;
                set {
                    if (Unk206_raw == value) return;
                    Unk206_raw = value;
                    OnPropertyChanged(nameof(Unk206));
                }
            }

            protected ushort Unk207_raw;
            public const string Unk207_displayName = "Unk207";
            public const int Unk207_sortIndex = 6350;
            [SortOrder(Unk207_sortIndex)]
            [DisplayName(Unk207_displayName)]
            public virtual ushort Unk207 {
                get => Unk207_raw;
                set {
                    if (Unk207_raw == value) return;
                    Unk207_raw = value;
                    OnPropertyChanged(nameof(Unk207));
                }
            }

            protected ushort Unk208_raw;
            public const string Unk208_displayName = "Unk208";
            public const int Unk208_sortIndex = 6400;
            [SortOrder(Unk208_sortIndex)]
            [DisplayName(Unk208_displayName)]
            public virtual ushort Unk208 {
                get => Unk208_raw;
                set {
                    if (Unk208_raw == value) return;
                    Unk208_raw = value;
                    OnPropertyChanged(nameof(Unk208));
                }
            }

            protected ushort Unk209_raw;
            public const string Unk209_displayName = "Unk209";
            public const int Unk209_sortIndex = 6450;
            [SortOrder(Unk209_sortIndex)]
            [DisplayName(Unk209_displayName)]
            public virtual ushort Unk209 {
                get => Unk209_raw;
                set {
                    if (Unk209_raw == value) return;
                    Unk209_raw = value;
                    OnPropertyChanged(nameof(Unk209));
                }
            }

            protected ushort Unk210_raw;
            public const string Unk210_displayName = "Unk210";
            public const int Unk210_sortIndex = 6500;
            [SortOrder(Unk210_sortIndex)]
            [DisplayName(Unk210_displayName)]
            public virtual ushort Unk210 {
                get => Unk210_raw;
                set {
                    if (Unk210_raw == value) return;
                    Unk210_raw = value;
                    OnPropertyChanged(nameof(Unk210));
                }
            }

            protected ushort Unk211_raw;
            public const string Unk211_displayName = "Unk211";
            public const int Unk211_sortIndex = 6550;
            [SortOrder(Unk211_sortIndex)]
            [DisplayName(Unk211_displayName)]
            public virtual ushort Unk211 {
                get => Unk211_raw;
                set {
                    if (Unk211_raw == value) return;
                    Unk211_raw = value;
                    OnPropertyChanged(nameof(Unk211));
                }
            }

            protected ushort Unk212_raw;
            public const string Unk212_displayName = "Unk212";
            public const int Unk212_sortIndex = 6600;
            [SortOrder(Unk212_sortIndex)]
            [DisplayName(Unk212_displayName)]
            public virtual ushort Unk212 {
                get => Unk212_raw;
                set {
                    if (Unk212_raw == value) return;
                    Unk212_raw = value;
                    OnPropertyChanged(nameof(Unk212));
                }
            }

            protected ushort Unk213_raw;
            public const string Unk213_displayName = "Unk213";
            public const int Unk213_sortIndex = 6650;
            [SortOrder(Unk213_sortIndex)]
            [DisplayName(Unk213_displayName)]
            public virtual ushort Unk213 {
                get => Unk213_raw;
                set {
                    if (Unk213_raw == value) return;
                    Unk213_raw = value;
                    OnPropertyChanged(nameof(Unk213));
                }
            }

            protected byte Unk214_raw;
            public const string Unk214_displayName = "Unk214";
            public const int Unk214_sortIndex = 6700;
            [SortOrder(Unk214_sortIndex)]
            [DisplayName(Unk214_displayName)]
            public virtual byte Unk214 {
                get => Unk214_raw;
                set {
                    if (Unk214_raw == value) return;
                    Unk214_raw = value;
                    OnPropertyChanged(nameof(Unk214));
                }
            }

            protected ushort Unk215_raw;
            public const string Unk215_displayName = "Unk215";
            public const int Unk215_sortIndex = 6750;
            [SortOrder(Unk215_sortIndex)]
            [DisplayName(Unk215_displayName)]
            public virtual ushort Unk215 {
                get => Unk215_raw;
                set {
                    if (Unk215_raw == value) return;
                    Unk215_raw = value;
                    OnPropertyChanged(nameof(Unk215));
                }
            }

            protected ushort Unk216_raw;
            public const string Unk216_displayName = "Unk216";
            public const int Unk216_sortIndex = 6800;
            [SortOrder(Unk216_sortIndex)]
            [DisplayName(Unk216_displayName)]
            public virtual ushort Unk216 {
                get => Unk216_raw;
                set {
                    if (Unk216_raw == value) return;
                    Unk216_raw = value;
                    OnPropertyChanged(nameof(Unk216));
                }
            }

            protected float Unk217_raw;
            public const string Unk217_displayName = "Unk217";
            public const int Unk217_sortIndex = 6850;
            [SortOrder(Unk217_sortIndex)]
            [DisplayName(Unk217_displayName)]
            public virtual float Unk217 {
                get => Unk217_raw;
                set {
                    if (Unk217_raw == value) return;
                    Unk217_raw = value;
                    OnPropertyChanged(nameof(Unk217));
                }
            }

            protected ushort Unk218_raw;
            public const string Unk218_displayName = "Unk218";
            public const int Unk218_sortIndex = 6900;
            [SortOrder(Unk218_sortIndex)]
            [DisplayName(Unk218_displayName)]
            public virtual ushort Unk218 {
                get => Unk218_raw;
                set {
                    if (Unk218_raw == value) return;
                    Unk218_raw = value;
                    OnPropertyChanged(nameof(Unk218));
                }
            }

            protected float Unk219_raw;
            public const string Unk219_displayName = "Unk219";
            public const int Unk219_sortIndex = 6950;
            [SortOrder(Unk219_sortIndex)]
            [DisplayName(Unk219_displayName)]
            public virtual float Unk219 {
                get => Unk219_raw;
                set {
                    if (Unk219_raw == value) return;
                    Unk219_raw = value;
                    OnPropertyChanged(nameof(Unk219));
                }
            }

            protected float Unk220_raw;
            public const string Unk220_displayName = "Unk220";
            public const int Unk220_sortIndex = 7000;
            [SortOrder(Unk220_sortIndex)]
            [DisplayName(Unk220_displayName)]
            public virtual float Unk220 {
                get => Unk220_raw;
                set {
                    if (Unk220_raw == value) return;
                    Unk220_raw = value;
                    OnPropertyChanged(nameof(Unk220));
                }
            }

            protected float Unk221_raw;
            public const string Unk221_displayName = "Unk221";
            public const int Unk221_sortIndex = 7050;
            [SortOrder(Unk221_sortIndex)]
            [DisplayName(Unk221_displayName)]
            public virtual float Unk221 {
                get => Unk221_raw;
                set {
                    if (Unk221_raw == value) return;
                    Unk221_raw = value;
                    OnPropertyChanged(nameof(Unk221));
                }
            }

            protected float Unk222_raw;
            public const string Unk222_displayName = "Unk222";
            public const int Unk222_sortIndex = 7100;
            [SortOrder(Unk222_sortIndex)]
            [DisplayName(Unk222_displayName)]
            public virtual float Unk222 {
                get => Unk222_raw;
                set {
                    if (Unk222_raw == value) return;
                    Unk222_raw = value;
                    OnPropertyChanged(nameof(Unk222));
                }
            }

            protected float Unk223_raw;
            public const string Unk223_displayName = "Unk223";
            public const int Unk223_sortIndex = 7150;
            [SortOrder(Unk223_sortIndex)]
            [DisplayName(Unk223_displayName)]
            public virtual float Unk223 {
                get => Unk223_raw;
                set {
                    if (Unk223_raw == value) return;
                    Unk223_raw = value;
                    OnPropertyChanged(nameof(Unk223));
                }
            }

            protected float Unk224_raw;
            public const string Unk224_displayName = "Unk224";
            public const int Unk224_sortIndex = 7200;
            [SortOrder(Unk224_sortIndex)]
            [DisplayName(Unk224_displayName)]
            public virtual float Unk224 {
                get => Unk224_raw;
                set {
                    if (Unk224_raw == value) return;
                    Unk224_raw = value;
                    OnPropertyChanged(nameof(Unk224));
                }
            }

            protected float Unk225_raw;
            public const string Unk225_displayName = "Unk225";
            public const int Unk225_sortIndex = 7250;
            [SortOrder(Unk225_sortIndex)]
            [DisplayName(Unk225_displayName)]
            public virtual float Unk225 {
                get => Unk225_raw;
                set {
                    if (Unk225_raw == value) return;
                    Unk225_raw = value;
                    OnPropertyChanged(nameof(Unk225));
                }
            }

            protected float Unk226_raw;
            public const string Unk226_displayName = "Unk226";
            public const int Unk226_sortIndex = 7300;
            [SortOrder(Unk226_sortIndex)]
            [DisplayName(Unk226_displayName)]
            public virtual float Unk226 {
                get => Unk226_raw;
                set {
                    if (Unk226_raw == value) return;
                    Unk226_raw = value;
                    OnPropertyChanged(nameof(Unk226));
                }
            }

            protected float Unk227_raw;
            public const string Unk227_displayName = "Unk227";
            public const int Unk227_sortIndex = 7350;
            [SortOrder(Unk227_sortIndex)]
            [DisplayName(Unk227_displayName)]
            public virtual float Unk227 {
                get => Unk227_raw;
                set {
                    if (Unk227_raw == value) return;
                    Unk227_raw = value;
                    OnPropertyChanged(nameof(Unk227));
                }
            }

            protected float Unk228_raw;
            public const string Unk228_displayName = "Unk228";
            public const int Unk228_sortIndex = 7400;
            [SortOrder(Unk228_sortIndex)]
            [DisplayName(Unk228_displayName)]
            public virtual float Unk228 {
                get => Unk228_raw;
                set {
                    if (Unk228_raw == value) return;
                    Unk228_raw = value;
                    OnPropertyChanged(nameof(Unk228));
                }
            }

            protected float Unk229_raw;
            public const string Unk229_displayName = "Unk229";
            public const int Unk229_sortIndex = 7450;
            [SortOrder(Unk229_sortIndex)]
            [DisplayName(Unk229_displayName)]
            public virtual float Unk229 {
                get => Unk229_raw;
                set {
                    if (Unk229_raw == value) return;
                    Unk229_raw = value;
                    OnPropertyChanged(nameof(Unk229));
                }
            }

            protected float Unk230_raw;
            public const string Unk230_displayName = "Unk230";
            public const int Unk230_sortIndex = 7500;
            [SortOrder(Unk230_sortIndex)]
            [DisplayName(Unk230_displayName)]
            public virtual float Unk230 {
                get => Unk230_raw;
                set {
                    if (Unk230_raw == value) return;
                    Unk230_raw = value;
                    OnPropertyChanged(nameof(Unk230));
                }
            }

            protected float Unk231_raw;
            public const string Unk231_displayName = "Unk231";
            public const int Unk231_sortIndex = 7550;
            [SortOrder(Unk231_sortIndex)]
            [DisplayName(Unk231_displayName)]
            public virtual float Unk231 {
                get => Unk231_raw;
                set {
                    if (Unk231_raw == value) return;
                    Unk231_raw = value;
                    OnPropertyChanged(nameof(Unk231));
                }
            }

            protected float Unk232_raw;
            public const string Unk232_displayName = "Unk232";
            public const int Unk232_sortIndex = 7600;
            [SortOrder(Unk232_sortIndex)]
            [DisplayName(Unk232_displayName)]
            public virtual float Unk232 {
                get => Unk232_raw;
                set {
                    if (Unk232_raw == value) return;
                    Unk232_raw = value;
                    OnPropertyChanged(nameof(Unk232));
                }
            }

            protected byte Unk233_raw;
            public const string Unk233_displayName = "Unk233";
            public const int Unk233_sortIndex = 7650;
            [SortOrder(Unk233_sortIndex)]
            [DisplayName(Unk233_displayName)]
            public virtual byte Unk233 {
                get => Unk233_raw;
                set {
                    if (Unk233_raw == value) return;
                    Unk233_raw = value;
                    OnPropertyChanged(nameof(Unk233));
                }
            }

            protected float Unk234_raw;
            public const string Unk234_displayName = "Unk234";
            public const int Unk234_sortIndex = 7700;
            [SortOrder(Unk234_sortIndex)]
            [DisplayName(Unk234_displayName)]
            public virtual float Unk234 {
                get => Unk234_raw;
                set {
                    if (Unk234_raw == value) return;
                    Unk234_raw = value;
                    OnPropertyChanged(nameof(Unk234));
                }
            }

            protected byte Unk235_raw;
            public const string Unk235_displayName = "Unk235";
            public const int Unk235_sortIndex = 7750;
            [SortOrder(Unk235_sortIndex)]
            [DisplayName(Unk235_displayName)]
            public virtual byte Unk235 {
                get => Unk235_raw;
                set {
                    if (Unk235_raw == value) return;
                    Unk235_raw = value;
                    OnPropertyChanged(nameof(Unk235));
                }
            }

            protected byte Unk236_raw;
            public const string Unk236_displayName = "Unk236";
            public const int Unk236_sortIndex = 7800;
            [SortOrder(Unk236_sortIndex)]
            [DisplayName(Unk236_displayName)]
            public virtual byte Unk236 {
                get => Unk236_raw;
                set {
                    if (Unk236_raw == value) return;
                    Unk236_raw = value;
                    OnPropertyChanged(nameof(Unk236));
                }
            }

            protected byte Unk237_raw;
            public const string Unk237_displayName = "Unk237";
            public const int Unk237_sortIndex = 7850;
            [SortOrder(Unk237_sortIndex)]
            [DisplayName(Unk237_displayName)]
            public virtual byte Unk237 {
                get => Unk237_raw;
                set {
                    if (Unk237_raw == value) return;
                    Unk237_raw = value;
                    OnPropertyChanged(nameof(Unk237));
                }
            }

            protected float Unk238_raw;
            public const string Unk238_displayName = "Unk238";
            public const int Unk238_sortIndex = 7900;
            [SortOrder(Unk238_sortIndex)]
            [DisplayName(Unk238_displayName)]
            public virtual float Unk238 {
                get => Unk238_raw;
                set {
                    if (Unk238_raw == value) return;
                    Unk238_raw = value;
                    OnPropertyChanged(nameof(Unk238));
                }
            }

            protected float Unk239_raw;
            public const string Unk239_displayName = "Unk239";
            public const int Unk239_sortIndex = 7950;
            [SortOrder(Unk239_sortIndex)]
            [DisplayName(Unk239_displayName)]
            public virtual float Unk239 {
                get => Unk239_raw;
                set {
                    if (Unk239_raw == value) return;
                    Unk239_raw = value;
                    OnPropertyChanged(nameof(Unk239));
                }
            }

            protected uint Unk240_raw;
            public const string Unk240_displayName = "Unk240";
            public const int Unk240_sortIndex = 8000;
            [SortOrder(Unk240_sortIndex)]
            [DisplayName(Unk240_displayName)]
            public virtual uint Unk240 {
                get => Unk240_raw;
                set {
                    if (Unk240_raw == value) return;
                    Unk240_raw = value;
                    OnPropertyChanged(nameof(Unk240));
                }
            }

            protected short Unk241_raw;
            public const string Unk241_displayName = "Unk241";
            public const int Unk241_sortIndex = 8050;
            [SortOrder(Unk241_sortIndex)]
            [DisplayName(Unk241_displayName)]
            public virtual short Unk241 {
                get => Unk241_raw;
                set {
                    if (Unk241_raw == value) return;
                    Unk241_raw = value;
                    OnPropertyChanged(nameof(Unk241));
                }
            }

            public static W12p_Params_4_ LoadData(BinaryReader reader) {
                var data = new W12p_Params_4_();
                data.Unk85_raw = reader.ReadSingle();
                data.Unk86_raw = reader.ReadSingle();
                data.Unk87_raw = reader.ReadSingle();
                data.Unk88_raw = reader.ReadSingle();
                data.Unk89_raw = reader.ReadSingle();
                data.Unk90_raw = reader.ReadSingle();
                data.Unk91_raw = reader.ReadSingle();
                data.Unk92_raw = reader.ReadSingle();
                data.Unk93_raw = reader.ReadSingle();
                data.Unk94_raw = reader.ReadSingle();
                data.Unk95_raw = reader.ReadSingle();
                data.Unk96_raw = reader.ReadSingle();
                data.Unk97_raw = reader.ReadSingle();
                data.Unk98_raw = reader.ReadSingle();
                data.Unk99_raw = reader.ReadSingle();
                data.Unk100_raw = reader.ReadSingle();
                data.Unk101_raw = reader.ReadSingle();
                data.Unk102_raw = reader.ReadSingle();
                data.Unk103_raw = reader.ReadSingle();
                data.Unk104_raw = reader.ReadSingle();
                data.Unk105_raw = reader.ReadSingle();
                data.Unk106___s____raw = reader.ReadUInt32();
                data.Unk107_raw = reader.ReadSingle();
                data.Unk108___raw = reader.ReadUInt32();
                data.Unk109_raw = reader.ReadSingle();
                data.Unk110___raw = reader.ReadUInt32();
                data.Unk111_raw = reader.ReadSingle();
                data.Unk112___raw = reader.ReadUInt32();
                data.Unk113___e____raw = reader.ReadSingle();
                data.Unk114_raw = reader.ReadSingle();
                data.Unk115_raw = reader.ReadSingle();
                data.Unk116_raw = reader.ReadSingle();
                data.Unk117_raw = reader.ReadSingle();
                data.Unk118_raw = reader.ReadSingle();
                data.Unk119_raw = reader.ReadSingle();
                data.Unk120_raw = reader.ReadSingle();
                data.Unk121_raw = reader.ReadSingle();
                data.Unk122_raw = reader.ReadSingle();
                data.Unk123_raw = reader.ReadSingle();
                data.Unk124_raw = reader.ReadSingle();
                data.Unk125_raw = reader.ReadSingle();
                data.Unk126_raw = reader.ReadSingle();
                data.Unk127___s____raw = reader.ReadSingle();
                data.Unk128_raw = reader.ReadSingle();
                data.Unk129_raw = reader.ReadSingle();
                data.Unk130_raw = reader.ReadSingle();
                data.Unk131_raw = reader.ReadSingle();
                data.Unk132_raw = reader.ReadSingle();
                data.Unk133_raw = reader.ReadSingle();
                data.Unk134_raw = reader.ReadSingle();
                data.Unk135_raw = reader.ReadSingle();
                data.Unk136___raw = reader.ReadSingle();
                data.Unk137_raw = reader.ReadSingle();
                data.Unk138_raw = reader.ReadSingle();
                data.Unk139_raw = reader.ReadSingle();
                data.Unk140_raw = reader.ReadSingle();
                data.Unk141_raw = reader.ReadSingle();
                data.Unk142_raw = reader.ReadSingle();
                data.Unk143_raw = reader.ReadSingle();
                data.Unk144_raw = reader.ReadSingle();
                data.Unk145_raw = reader.ReadSingle();
                data.Unk146___e____raw = reader.ReadSingle();
                data.Unk147_raw = reader.ReadSingle();
                data.Unk148_raw = reader.ReadSingle();
                data.Unk149_raw = reader.ReadSingle();
                data.Unk150_raw = reader.ReadSingle();
                data.Unk151_raw = reader.ReadSingle();
                data.Unk152_raw = reader.ReadSingle();
                data.Unk153_raw = reader.ReadSingle();
                data.Unk154_raw = reader.ReadSingle();
                data.Unk155_raw = reader.ReadSingle();
                data.Unk156_raw = reader.ReadSingle();
                data.Unk157_raw = reader.ReadSingle();
                data.Unk158_raw = reader.ReadSingle();
                data.Unk159_raw = reader.ReadSingle();
                data.Unk160_raw = reader.ReadSingle();
                data.Unk161_raw = reader.ReadSingle();
                data.Unk162_raw = reader.ReadSingle();
                data.Unk163_raw = reader.ReadSingle();
                data.Unk164_raw = reader.ReadSingle();
                data.Unk165_raw = reader.ReadSingle();
                data.Unk166_raw = reader.ReadSingle();
                data.Unk167_raw = reader.ReadSingle();
                data.Unk168_raw = reader.ReadSingle();
                data.Unk169_raw = reader.ReadSingle();
                data.Unk170_raw = reader.ReadSingle();
                data.Unk171_raw = reader.ReadSingle();
                data.Unk172_raw = reader.ReadSingle();
                data.Unk173_raw = reader.ReadSingle();
                data.Unk174_raw = reader.ReadSingle();
                data.Unk175_raw = reader.ReadSingle();
                data.Unk176_raw = reader.ReadSingle();
                data.Unk177_raw = reader.ReadSingle();
                data.Unk178_raw = reader.ReadSingle();
                data.Unk179_raw = reader.ReadSingle();
                data.Unk180___s____raw = reader.ReadByte();
                data.Unk180_raw = reader.ReadByte();
                data.Unk181_raw = reader.ReadByte();
                data.Unk181_1_raw = reader.ReadByte();
                data.Unk182_raw = reader.ReadUInt16();
                data.Unk183_raw = reader.ReadUInt16();
                data.Unk184_raw = reader.ReadUInt16();
                data.Unk185_raw = reader.ReadUInt16();
                data.Unk186_raw = reader.ReadUInt16();
                data.Unk187_raw = reader.ReadUInt16();
                data.Unk188_raw = reader.ReadUInt16();
                data.Unk189_raw = reader.ReadUInt16();
                data.Unk190_raw = reader.ReadUInt16();
                data.Unk191___raw = reader.ReadUInt16();
                data.Unk192_raw = reader.ReadByte();
                data.Unk192_1_raw = reader.ReadByte();
                data.Unk193_raw = reader.ReadByte();
                data.Unk193_1_raw = reader.ReadByte();
                data.Unk194_raw = reader.ReadUInt16();
                data.Unk195_raw = reader.ReadUInt16();
                data.Unk196_raw = reader.ReadUInt16();
                data.Unk197_raw = reader.ReadUInt16();
                data.Unk198_raw = reader.ReadUInt16();
                data.Unk199_raw = reader.ReadUInt16();
                data.Unk200_raw = reader.ReadUInt16();
                data.Unk201_raw = reader.ReadUInt16();
                data.Unk202_raw = reader.ReadUInt16();
                data.Unk203___e____raw = reader.ReadUInt16();
                data.Unk204_raw = reader.ReadUInt16();
                data.Unk205_raw = reader.ReadUInt16();
                data.Unk206_raw = reader.ReadUInt16();
                data.Unk207_raw = reader.ReadUInt16();
                data.Unk208_raw = reader.ReadUInt16();
                data.Unk209_raw = reader.ReadUInt16();
                data.Unk210_raw = reader.ReadUInt16();
                data.Unk211_raw = reader.ReadUInt16();
                data.Unk212_raw = reader.ReadUInt16();
                data.Unk213_raw = reader.ReadUInt16();
                data.Unk214_raw = reader.ReadByte();
                data.Unk215_raw = reader.ReadUInt16();
                data.Unk216_raw = reader.ReadUInt16();
                data.Unk217_raw = reader.ReadSingle();
                data.Unk218_raw = reader.ReadUInt16();
                data.Unk219_raw = reader.ReadSingle();
                data.Unk220_raw = reader.ReadSingle();
                data.Unk221_raw = reader.ReadSingle();
                data.Unk222_raw = reader.ReadSingle();
                data.Unk223_raw = reader.ReadSingle();
                data.Unk224_raw = reader.ReadSingle();
                data.Unk225_raw = reader.ReadSingle();
                data.Unk226_raw = reader.ReadSingle();
                data.Unk227_raw = reader.ReadSingle();
                data.Unk228_raw = reader.ReadSingle();
                data.Unk229_raw = reader.ReadSingle();
                data.Unk230_raw = reader.ReadSingle();
                data.Unk231_raw = reader.ReadSingle();
                data.Unk232_raw = reader.ReadSingle();
                data.Unk233_raw = reader.ReadByte();
                data.Unk234_raw = reader.ReadSingle();
                data.Unk235_raw = reader.ReadByte();
                data.Unk236_raw = reader.ReadByte();
                data.Unk237_raw = reader.ReadByte();
                data.Unk238_raw = reader.ReadSingle();
                data.Unk239_raw = reader.ReadSingle();
                data.Unk240_raw = reader.ReadUInt32();
                data.Unk241_raw = reader.ReadInt16();
                return data;
            }

            public override void WriteData(BinaryWriter writer) {
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
                writer.Write(Unk106___s____raw);
                writer.Write(Unk107_raw);
                writer.Write(Unk108___raw);
                writer.Write(Unk109_raw);
                writer.Write(Unk110___raw);
                writer.Write(Unk111_raw);
                writer.Write(Unk112___raw);
                writer.Write(Unk113___e____raw);
                writer.Write(Unk114_raw);
                writer.Write(Unk115_raw);
                writer.Write(Unk116_raw);
                writer.Write(Unk117_raw);
                writer.Write(Unk118_raw);
                writer.Write(Unk119_raw);
                writer.Write(Unk120_raw);
                writer.Write(Unk121_raw);
                writer.Write(Unk122_raw);
                writer.Write(Unk123_raw);
                writer.Write(Unk124_raw);
                writer.Write(Unk125_raw);
                writer.Write(Unk126_raw);
                writer.Write(Unk127___s____raw);
                writer.Write(Unk128_raw);
                writer.Write(Unk129_raw);
                writer.Write(Unk130_raw);
                writer.Write(Unk131_raw);
                writer.Write(Unk132_raw);
                writer.Write(Unk133_raw);
                writer.Write(Unk134_raw);
                writer.Write(Unk135_raw);
                writer.Write(Unk136___raw);
                writer.Write(Unk137_raw);
                writer.Write(Unk138_raw);
                writer.Write(Unk139_raw);
                writer.Write(Unk140_raw);
                writer.Write(Unk141_raw);
                writer.Write(Unk142_raw);
                writer.Write(Unk143_raw);
                writer.Write(Unk144_raw);
                writer.Write(Unk145_raw);
                writer.Write(Unk146___e____raw);
                writer.Write(Unk147_raw);
                writer.Write(Unk148_raw);
                writer.Write(Unk149_raw);
                writer.Write(Unk150_raw);
                writer.Write(Unk151_raw);
                writer.Write(Unk152_raw);
                writer.Write(Unk153_raw);
                writer.Write(Unk154_raw);
                writer.Write(Unk155_raw);
                writer.Write(Unk156_raw);
                writer.Write(Unk157_raw);
                writer.Write(Unk158_raw);
                writer.Write(Unk159_raw);
                writer.Write(Unk160_raw);
                writer.Write(Unk161_raw);
                writer.Write(Unk162_raw);
                writer.Write(Unk163_raw);
                writer.Write(Unk164_raw);
                writer.Write(Unk165_raw);
                writer.Write(Unk166_raw);
                writer.Write(Unk167_raw);
                writer.Write(Unk168_raw);
                writer.Write(Unk169_raw);
                writer.Write(Unk170_raw);
                writer.Write(Unk171_raw);
                writer.Write(Unk172_raw);
                writer.Write(Unk173_raw);
                writer.Write(Unk174_raw);
                writer.Write(Unk175_raw);
                writer.Write(Unk176_raw);
                writer.Write(Unk177_raw);
                writer.Write(Unk178_raw);
                writer.Write(Unk179_raw);
                writer.Write(Unk180___s____raw);
                writer.Write(Unk180_raw);
                writer.Write(Unk181_raw);
                writer.Write(Unk181_1_raw);
                writer.Write(Unk182_raw);
                writer.Write(Unk183_raw);
                writer.Write(Unk184_raw);
                writer.Write(Unk185_raw);
                writer.Write(Unk186_raw);
                writer.Write(Unk187_raw);
                writer.Write(Unk188_raw);
                writer.Write(Unk189_raw);
                writer.Write(Unk190_raw);
                writer.Write(Unk191___raw);
                writer.Write(Unk192_raw);
                writer.Write(Unk192_1_raw);
                writer.Write(Unk193_raw);
                writer.Write(Unk193_1_raw);
                writer.Write(Unk194_raw);
                writer.Write(Unk195_raw);
                writer.Write(Unk196_raw);
                writer.Write(Unk197_raw);
                writer.Write(Unk198_raw);
                writer.Write(Unk199_raw);
                writer.Write(Unk200_raw);
                writer.Write(Unk201_raw);
                writer.Write(Unk202_raw);
                writer.Write(Unk203___e____raw);
                writer.Write(Unk204_raw);
                writer.Write(Unk205_raw);
                writer.Write(Unk206_raw);
                writer.Write(Unk207_raw);
                writer.Write(Unk208_raw);
                writer.Write(Unk209_raw);
                writer.Write(Unk210_raw);
                writer.Write(Unk211_raw);
                writer.Write(Unk212_raw);
                writer.Write(Unk213_raw);
                writer.Write(Unk214_raw);
                writer.Write(Unk215_raw);
                writer.Write(Unk216_raw);
                writer.Write(Unk217_raw);
                writer.Write(Unk218_raw);
                writer.Write(Unk219_raw);
                writer.Write(Unk220_raw);
                writer.Write(Unk221_raw);
                writer.Write(Unk222_raw);
                writer.Write(Unk223_raw);
                writer.Write(Unk224_raw);
                writer.Write(Unk225_raw);
                writer.Write(Unk226_raw);
                writer.Write(Unk227_raw);
                writer.Write(Unk228_raw);
                writer.Write(Unk229_raw);
                writer.Write(Unk230_raw);
                writer.Write(Unk231_raw);
                writer.Write(Unk232_raw);
                writer.Write(Unk233_raw);
                writer.Write(Unk234_raw);
                writer.Write(Unk235_raw);
                writer.Write(Unk236_raw);
                writer.Write(Unk237_raw);
                writer.Write(Unk238_raw);
                writer.Write(Unk239_raw);
                writer.Write(Unk240_raw);
                writer.Write(Unk241_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Unk85", "Unk85"),
                    new MultiStructItemCustomView(this, "Unk86", "Unk86"),
                    new MultiStructItemCustomView(this, "Unk87", "Unk87"),
                    new MultiStructItemCustomView(this, "Unk88", "Unk88"),
                    new MultiStructItemCustomView(this, "Unk89", "Unk89"),
                    new MultiStructItemCustomView(this, "Unk90", "Unk90"),
                    new MultiStructItemCustomView(this, "Unk91", "Unk91"),
                    new MultiStructItemCustomView(this, "Unk92", "Unk92"),
                    new MultiStructItemCustomView(this, "Unk93", "Unk93"),
                    new MultiStructItemCustomView(this, "Unk94", "Unk94"),
                    new MultiStructItemCustomView(this, "Unk95", "Unk95"),
                    new MultiStructItemCustomView(this, "Unk96", "Unk96"),
                    new MultiStructItemCustomView(this, "Unk97", "Unk97"),
                    new MultiStructItemCustomView(this, "Unk98", "Unk98"),
                    new MultiStructItemCustomView(this, "Unk99", "Unk99"),
                    new MultiStructItemCustomView(this, "Unk100", "Unk100"),
                    new MultiStructItemCustomView(this, "Unk101", "Unk101"),
                    new MultiStructItemCustomView(this, "Unk102", "Unk102"),
                    new MultiStructItemCustomView(this, "Unk103", "Unk103"),
                    new MultiStructItemCustomView(this, "Unk104", "Unk104"),
                    new MultiStructItemCustomView(this, "Unk105", "Unk105"),
                    new MultiStructItemCustomView(this, "Unk106___s___", "Unk106___s___"),
                    new MultiStructItemCustomView(this, "Unk107", "Unk107"),
                    new MultiStructItemCustomView(this, "Unk108__", "Unk108__"),
                    new MultiStructItemCustomView(this, "Unk109", "Unk109"),
                    new MultiStructItemCustomView(this, "Unk110__", "Unk110__"),
                    new MultiStructItemCustomView(this, "Unk111", "Unk111"),
                    new MultiStructItemCustomView(this, "Unk112__", "Unk112__"),
                    new MultiStructItemCustomView(this, "Unk113___e___", "Unk113___e___"),
                    new MultiStructItemCustomView(this, "Unk114", "Unk114"),
                    new MultiStructItemCustomView(this, "Unk115", "Unk115"),
                    new MultiStructItemCustomView(this, "Unk116", "Unk116"),
                    new MultiStructItemCustomView(this, "Unk117", "Unk117"),
                    new MultiStructItemCustomView(this, "Unk118", "Unk118"),
                    new MultiStructItemCustomView(this, "Unk119", "Unk119"),
                    new MultiStructItemCustomView(this, "Unk120", "Unk120"),
                    new MultiStructItemCustomView(this, "Unk121", "Unk121"),
                    new MultiStructItemCustomView(this, "Unk122", "Unk122"),
                    new MultiStructItemCustomView(this, "Unk123", "Unk123"),
                    new MultiStructItemCustomView(this, "Unk124", "Unk124"),
                    new MultiStructItemCustomView(this, "Unk125", "Unk125"),
                    new MultiStructItemCustomView(this, "Unk126", "Unk126"),
                    new MultiStructItemCustomView(this, "Unk127___s___", "Unk127___s___"),
                    new MultiStructItemCustomView(this, "Unk128", "Unk128"),
                    new MultiStructItemCustomView(this, "Unk129", "Unk129"),
                    new MultiStructItemCustomView(this, "Unk130", "Unk130"),
                    new MultiStructItemCustomView(this, "Unk131", "Unk131"),
                    new MultiStructItemCustomView(this, "Unk132", "Unk132"),
                    new MultiStructItemCustomView(this, "Unk133", "Unk133"),
                    new MultiStructItemCustomView(this, "Unk134", "Unk134"),
                    new MultiStructItemCustomView(this, "Unk135", "Unk135"),
                    new MultiStructItemCustomView(this, "Unk136__", "Unk136__"),
                    new MultiStructItemCustomView(this, "Unk137", "Unk137"),
                    new MultiStructItemCustomView(this, "Unk138", "Unk138"),
                    new MultiStructItemCustomView(this, "Unk139", "Unk139"),
                    new MultiStructItemCustomView(this, "Unk140", "Unk140"),
                    new MultiStructItemCustomView(this, "Unk141", "Unk141"),
                    new MultiStructItemCustomView(this, "Unk142", "Unk142"),
                    new MultiStructItemCustomView(this, "Unk143", "Unk143"),
                    new MultiStructItemCustomView(this, "Unk144", "Unk144"),
                    new MultiStructItemCustomView(this, "Unk145", "Unk145"),
                    new MultiStructItemCustomView(this, "Unk146___e___", "Unk146___e___"),
                    new MultiStructItemCustomView(this, "Unk147", "Unk147"),
                    new MultiStructItemCustomView(this, "Unk148", "Unk148"),
                    new MultiStructItemCustomView(this, "Unk149", "Unk149"),
                    new MultiStructItemCustomView(this, "Unk150", "Unk150"),
                    new MultiStructItemCustomView(this, "Unk151", "Unk151"),
                    new MultiStructItemCustomView(this, "Unk152", "Unk152"),
                    new MultiStructItemCustomView(this, "Unk153", "Unk153"),
                    new MultiStructItemCustomView(this, "Unk154", "Unk154"),
                    new MultiStructItemCustomView(this, "Unk155", "Unk155"),
                    new MultiStructItemCustomView(this, "Unk156", "Unk156"),
                    new MultiStructItemCustomView(this, "Unk157", "Unk157"),
                    new MultiStructItemCustomView(this, "Unk158", "Unk158"),
                    new MultiStructItemCustomView(this, "Unk159", "Unk159"),
                    new MultiStructItemCustomView(this, "Unk160", "Unk160"),
                    new MultiStructItemCustomView(this, "Unk161", "Unk161"),
                    new MultiStructItemCustomView(this, "Unk162", "Unk162"),
                    new MultiStructItemCustomView(this, "Unk163", "Unk163"),
                    new MultiStructItemCustomView(this, "Unk164", "Unk164"),
                    new MultiStructItemCustomView(this, "Unk165", "Unk165"),
                    new MultiStructItemCustomView(this, "Unk166", "Unk166"),
                    new MultiStructItemCustomView(this, "Unk167", "Unk167"),
                    new MultiStructItemCustomView(this, "Unk168", "Unk168"),
                    new MultiStructItemCustomView(this, "Unk169", "Unk169"),
                    new MultiStructItemCustomView(this, "Unk170", "Unk170"),
                    new MultiStructItemCustomView(this, "Unk171", "Unk171"),
                    new MultiStructItemCustomView(this, "Unk172", "Unk172"),
                    new MultiStructItemCustomView(this, "Unk173", "Unk173"),
                    new MultiStructItemCustomView(this, "Unk174", "Unk174"),
                    new MultiStructItemCustomView(this, "Unk175", "Unk175"),
                    new MultiStructItemCustomView(this, "Unk176", "Unk176"),
                    new MultiStructItemCustomView(this, "Unk177", "Unk177"),
                    new MultiStructItemCustomView(this, "Unk178", "Unk178"),
                    new MultiStructItemCustomView(this, "Unk179", "Unk179"),
                    new MultiStructItemCustomView(this, "Unk180___s___", "Unk180___s___"),
                    new MultiStructItemCustomView(this, "Unk180", "Unk180"),
                    new MultiStructItemCustomView(this, "Unk181", "Unk181"),
                    new MultiStructItemCustomView(this, "Unk181.1", "Unk181_1"),
                    new MultiStructItemCustomView(this, "Unk182", "Unk182"),
                    new MultiStructItemCustomView(this, "Unk183", "Unk183"),
                    new MultiStructItemCustomView(this, "Unk184", "Unk184"),
                    new MultiStructItemCustomView(this, "Unk185", "Unk185"),
                    new MultiStructItemCustomView(this, "Unk186", "Unk186"),
                    new MultiStructItemCustomView(this, "Unk187", "Unk187"),
                    new MultiStructItemCustomView(this, "Unk188", "Unk188"),
                    new MultiStructItemCustomView(this, "Unk189", "Unk189"),
                    new MultiStructItemCustomView(this, "Unk190", "Unk190"),
                    new MultiStructItemCustomView(this, "Unk191__", "Unk191__"),
                    new MultiStructItemCustomView(this, "Unk192", "Unk192"),
                    new MultiStructItemCustomView(this, "Unk192.1", "Unk192_1"),
                    new MultiStructItemCustomView(this, "Unk193", "Unk193"),
                    new MultiStructItemCustomView(this, "Unk193.1", "Unk193_1"),
                    new MultiStructItemCustomView(this, "Unk194", "Unk194"),
                    new MultiStructItemCustomView(this, "Unk195", "Unk195"),
                    new MultiStructItemCustomView(this, "Unk196", "Unk196"),
                    new MultiStructItemCustomView(this, "Unk197", "Unk197"),
                    new MultiStructItemCustomView(this, "Unk198", "Unk198"),
                    new MultiStructItemCustomView(this, "Unk199", "Unk199"),
                    new MultiStructItemCustomView(this, "Unk200", "Unk200"),
                    new MultiStructItemCustomView(this, "Unk201", "Unk201"),
                    new MultiStructItemCustomView(this, "Unk202", "Unk202"),
                    new MultiStructItemCustomView(this, "Unk203___e___", "Unk203___e___"),
                    new MultiStructItemCustomView(this, "Unk204", "Unk204"),
                    new MultiStructItemCustomView(this, "Unk205", "Unk205"),
                    new MultiStructItemCustomView(this, "Unk206", "Unk206"),
                    new MultiStructItemCustomView(this, "Unk207", "Unk207"),
                    new MultiStructItemCustomView(this, "Unk208", "Unk208"),
                    new MultiStructItemCustomView(this, "Unk209", "Unk209"),
                    new MultiStructItemCustomView(this, "Unk210", "Unk210"),
                    new MultiStructItemCustomView(this, "Unk211", "Unk211"),
                    new MultiStructItemCustomView(this, "Unk212", "Unk212"),
                    new MultiStructItemCustomView(this, "Unk213", "Unk213"),
                    new MultiStructItemCustomView(this, "Unk214", "Unk214"),
                    new MultiStructItemCustomView(this, "Unk215", "Unk215"),
                    new MultiStructItemCustomView(this, "Unk216", "Unk216"),
                    new MultiStructItemCustomView(this, "Unk217", "Unk217"),
                    new MultiStructItemCustomView(this, "Unk218", "Unk218"),
                    new MultiStructItemCustomView(this, "Unk219", "Unk219"),
                    new MultiStructItemCustomView(this, "Unk220", "Unk220"),
                    new MultiStructItemCustomView(this, "Unk221", "Unk221"),
                    new MultiStructItemCustomView(this, "Unk222", "Unk222"),
                    new MultiStructItemCustomView(this, "Unk223", "Unk223"),
                    new MultiStructItemCustomView(this, "Unk224", "Unk224"),
                    new MultiStructItemCustomView(this, "Unk225", "Unk225"),
                    new MultiStructItemCustomView(this, "Unk226", "Unk226"),
                    new MultiStructItemCustomView(this, "Unk227", "Unk227"),
                    new MultiStructItemCustomView(this, "Unk228", "Unk228"),
                    new MultiStructItemCustomView(this, "Unk229", "Unk229"),
                    new MultiStructItemCustomView(this, "Unk230", "Unk230"),
                    new MultiStructItemCustomView(this, "Unk231", "Unk231"),
                    new MultiStructItemCustomView(this, "Unk232", "Unk232"),
                    new MultiStructItemCustomView(this, "Unk233", "Unk233"),
                    new MultiStructItemCustomView(this, "Unk234", "Unk234"),
                    new MultiStructItemCustomView(this, "Unk235", "Unk235"),
                    new MultiStructItemCustomView(this, "Unk236", "Unk236"),
                    new MultiStructItemCustomView(this, "Unk237", "Unk237"),
                    new MultiStructItemCustomView(this, "Unk238", "Unk238"),
                    new MultiStructItemCustomView(this, "Unk239", "Unk239"),
                    new MultiStructItemCustomView(this, "Unk240", "Unk240"),
                    new MultiStructItemCustomView(this, "Unk241", "Unk241"),
                };
            }
        }

        public partial class Unk_Struct_3 : MhwStructItem {
            public const ulong FixedSizeCount = 16;
            public const string GridName = "Unk Struct 3";

            protected float Unk1_raw;
            public const string Unk1_displayName = "Unk1";
            public const int Unk1_sortIndex = 50;
            [SortOrder(Unk1_sortIndex)]
            [DisplayName(Unk1_displayName)]
            public virtual float Unk1 {
                get => Unk1_raw;
                set {
                    if (Unk1_raw == value) return;
                    Unk1_raw = value;
                    OnPropertyChanged(nameof(Unk1));
                }
            }

            protected float Unk2_raw;
            public const string Unk2_displayName = "Unk2";
            public const int Unk2_sortIndex = 100;
            [SortOrder(Unk2_sortIndex)]
            [DisplayName(Unk2_displayName)]
            public virtual float Unk2 {
                get => Unk2_raw;
                set {
                    if (Unk2_raw == value) return;
                    Unk2_raw = value;
                    OnPropertyChanged(nameof(Unk2));
                }
            }

            protected float Unk3_raw;
            public const string Unk3_displayName = "Unk3";
            public const int Unk3_sortIndex = 150;
            [SortOrder(Unk3_sortIndex)]
            [DisplayName(Unk3_displayName)]
            public virtual float Unk3 {
                get => Unk3_raw;
                set {
                    if (Unk3_raw == value) return;
                    Unk3_raw = value;
                    OnPropertyChanged(nameof(Unk3));
                }
            }

            protected float Unk4_raw;
            public const string Unk4_displayName = "Unk4";
            public const int Unk4_sortIndex = 200;
            [SortOrder(Unk4_sortIndex)]
            [DisplayName(Unk4_displayName)]
            public virtual float Unk4 {
                get => Unk4_raw;
                set {
                    if (Unk4_raw == value) return;
                    Unk4_raw = value;
                    OnPropertyChanged(nameof(Unk4));
                }
            }

            protected float Unk5_raw;
            public const string Unk5_displayName = "Unk5";
            public const int Unk5_sortIndex = 250;
            [SortOrder(Unk5_sortIndex)]
            [DisplayName(Unk5_displayName)]
            public virtual float Unk5 {
                get => Unk5_raw;
                set {
                    if (Unk5_raw == value) return;
                    Unk5_raw = value;
                    OnPropertyChanged(nameof(Unk5));
                }
            }

            public static Unk_Struct_3 LoadData(BinaryReader reader) {
                var data = new Unk_Struct_3();
                data.Unk1_raw = reader.ReadSingle();
                data.Unk2_raw = reader.ReadSingle();
                data.Unk3_raw = reader.ReadSingle();
                data.Unk4_raw = reader.ReadSingle();
                data.Unk5_raw = reader.ReadSingle();
                return data;
            }

            public override void WriteData(BinaryWriter writer) {
                writer.Write(Unk1_raw);
                writer.Write(Unk2_raw);
                writer.Write(Unk3_raw);
                writer.Write(Unk4_raw);
                writer.Write(Unk5_raw);
            }
        }

        public partial class Unk_Struct_4 : MhwStructItem {
            public const ulong FixedSizeCount = 4;
            public const string GridName = "Unk Struct 4";

            protected float Unk1_raw;
            public const string Unk1_displayName = "Unk1";
            public const int Unk1_sortIndex = 50;
            [SortOrder(Unk1_sortIndex)]
            [DisplayName(Unk1_displayName)]
            public virtual float Unk1 {
                get => Unk1_raw;
                set {
                    if (Unk1_raw == value) return;
                    Unk1_raw = value;
                    OnPropertyChanged(nameof(Unk1));
                }
            }

            protected uint Unk2_raw;
            public const string Unk2_displayName = "Unk2";
            public const int Unk2_sortIndex = 100;
            [SortOrder(Unk2_sortIndex)]
            [DisplayName(Unk2_displayName)]
            public virtual uint Unk2 {
                get => Unk2_raw;
                set {
                    if (Unk2_raw == value) return;
                    Unk2_raw = value;
                    OnPropertyChanged(nameof(Unk2));
                }
            }

            protected float Unk3_raw;
            public const string Unk3_displayName = "Unk3";
            public const int Unk3_sortIndex = 150;
            [SortOrder(Unk3_sortIndex)]
            [DisplayName(Unk3_displayName)]
            public virtual float Unk3 {
                get => Unk3_raw;
                set {
                    if (Unk3_raw == value) return;
                    Unk3_raw = value;
                    OnPropertyChanged(nameof(Unk3));
                }
            }

            protected float Unk4_raw;
            public const string Unk4_displayName = "Unk4";
            public const int Unk4_sortIndex = 200;
            [SortOrder(Unk4_sortIndex)]
            [DisplayName(Unk4_displayName)]
            public virtual float Unk4 {
                get => Unk4_raw;
                set {
                    if (Unk4_raw == value) return;
                    Unk4_raw = value;
                    OnPropertyChanged(nameof(Unk4));
                }
            }

            protected float Unk5_raw;
            public const string Unk5_displayName = "Unk5";
            public const int Unk5_sortIndex = 250;
            [SortOrder(Unk5_sortIndex)]
            [DisplayName(Unk5_displayName)]
            public virtual float Unk5 {
                get => Unk5_raw;
                set {
                    if (Unk5_raw == value) return;
                    Unk5_raw = value;
                    OnPropertyChanged(nameof(Unk5));
                }
            }

            protected float Unk6_raw;
            public const string Unk6_displayName = "Unk6";
            public const int Unk6_sortIndex = 300;
            [SortOrder(Unk6_sortIndex)]
            [DisplayName(Unk6_displayName)]
            public virtual float Unk6 {
                get => Unk6_raw;
                set {
                    if (Unk6_raw == value) return;
                    Unk6_raw = value;
                    OnPropertyChanged(nameof(Unk6));
                }
            }

            public static Unk_Struct_4 LoadData(BinaryReader reader) {
                var data = new Unk_Struct_4();
                data.Unk1_raw = reader.ReadSingle();
                data.Unk2_raw = reader.ReadUInt32();
                data.Unk3_raw = reader.ReadSingle();
                data.Unk4_raw = reader.ReadSingle();
                data.Unk5_raw = reader.ReadSingle();
                data.Unk6_raw = reader.ReadSingle();
                return data;
            }

            public override void WriteData(BinaryWriter writer) {
                writer.Write(Unk1_raw);
                writer.Write(Unk2_raw);
                writer.Write(Unk3_raw);
                writer.Write(Unk4_raw);
                writer.Write(Unk5_raw);
                writer.Write(Unk6_raw);
            }
        }

        public partial class W12p_Params_5_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView> {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W12p Params (5)";

            protected float Unk242_raw;
            public const string Unk242_displayName = "Unk242";
            public const int Unk242_sortIndex = 50;
            [SortOrder(Unk242_sortIndex)]
            [DisplayName(Unk242_displayName)]
            public virtual float Unk242 {
                get => Unk242_raw;
                set {
                    if (Unk242_raw == value) return;
                    Unk242_raw = value;
                    OnPropertyChanged(nameof(Unk242));
                }
            }

            protected float Unk243_raw;
            public const string Unk243_displayName = "Unk243";
            public const int Unk243_sortIndex = 100;
            [SortOrder(Unk243_sortIndex)]
            [DisplayName(Unk243_displayName)]
            public virtual float Unk243 {
                get => Unk243_raw;
                set {
                    if (Unk243_raw == value) return;
                    Unk243_raw = value;
                    OnPropertyChanged(nameof(Unk243));
                }
            }

            protected float Unk244_raw;
            public const string Unk244_displayName = "Unk244";
            public const int Unk244_sortIndex = 150;
            [SortOrder(Unk244_sortIndex)]
            [DisplayName(Unk244_displayName)]
            public virtual float Unk244 {
                get => Unk244_raw;
                set {
                    if (Unk244_raw == value) return;
                    Unk244_raw = value;
                    OnPropertyChanged(nameof(Unk244));
                }
            }

            protected float Unk245_raw;
            public const string Unk245_displayName = "Unk245";
            public const int Unk245_sortIndex = 200;
            [SortOrder(Unk245_sortIndex)]
            [DisplayName(Unk245_displayName)]
            public virtual float Unk245 {
                get => Unk245_raw;
                set {
                    if (Unk245_raw == value) return;
                    Unk245_raw = value;
                    OnPropertyChanged(nameof(Unk245));
                }
            }

            protected float Unk246_raw;
            public const string Unk246_displayName = "Unk246";
            public const int Unk246_sortIndex = 250;
            [SortOrder(Unk246_sortIndex)]
            [DisplayName(Unk246_displayName)]
            public virtual float Unk246 {
                get => Unk246_raw;
                set {
                    if (Unk246_raw == value) return;
                    Unk246_raw = value;
                    OnPropertyChanged(nameof(Unk246));
                }
            }

            protected float Unk247_raw;
            public const string Unk247_displayName = "Unk247";
            public const int Unk247_sortIndex = 300;
            [SortOrder(Unk247_sortIndex)]
            [DisplayName(Unk247_displayName)]
            public virtual float Unk247 {
                get => Unk247_raw;
                set {
                    if (Unk247_raw == value) return;
                    Unk247_raw = value;
                    OnPropertyChanged(nameof(Unk247));
                }
            }

            protected float Unk248_raw;
            public const string Unk248_displayName = "Unk248";
            public const int Unk248_sortIndex = 350;
            [SortOrder(Unk248_sortIndex)]
            [DisplayName(Unk248_displayName)]
            public virtual float Unk248 {
                get => Unk248_raw;
                set {
                    if (Unk248_raw == value) return;
                    Unk248_raw = value;
                    OnPropertyChanged(nameof(Unk248));
                }
            }

            protected float Unk249_raw;
            public const string Unk249_displayName = "Unk249";
            public const int Unk249_sortIndex = 400;
            [SortOrder(Unk249_sortIndex)]
            [DisplayName(Unk249_displayName)]
            public virtual float Unk249 {
                get => Unk249_raw;
                set {
                    if (Unk249_raw == value) return;
                    Unk249_raw = value;
                    OnPropertyChanged(nameof(Unk249));
                }
            }

            protected float Unk250_raw;
            public const string Unk250_displayName = "Unk250";
            public const int Unk250_sortIndex = 450;
            [SortOrder(Unk250_sortIndex)]
            [DisplayName(Unk250_displayName)]
            public virtual float Unk250 {
                get => Unk250_raw;
                set {
                    if (Unk250_raw == value) return;
                    Unk250_raw = value;
                    OnPropertyChanged(nameof(Unk250));
                }
            }

            protected float Unk251_raw;
            public const string Unk251_displayName = "Unk251";
            public const int Unk251_sortIndex = 500;
            [SortOrder(Unk251_sortIndex)]
            [DisplayName(Unk251_displayName)]
            public virtual float Unk251 {
                get => Unk251_raw;
                set {
                    if (Unk251_raw == value) return;
                    Unk251_raw = value;
                    OnPropertyChanged(nameof(Unk251));
                }
            }

            protected float Unk252_raw;
            public const string Unk252_displayName = "Unk252";
            public const int Unk252_sortIndex = 550;
            [SortOrder(Unk252_sortIndex)]
            [DisplayName(Unk252_displayName)]
            public virtual float Unk252 {
                get => Unk252_raw;
                set {
                    if (Unk252_raw == value) return;
                    Unk252_raw = value;
                    OnPropertyChanged(nameof(Unk252));
                }
            }

            protected float Unk253_raw;
            public const string Unk253_displayName = "Unk253";
            public const int Unk253_sortIndex = 600;
            [SortOrder(Unk253_sortIndex)]
            [DisplayName(Unk253_displayName)]
            public virtual float Unk253 {
                get => Unk253_raw;
                set {
                    if (Unk253_raw == value) return;
                    Unk253_raw = value;
                    OnPropertyChanged(nameof(Unk253));
                }
            }

            protected float Unk254_raw;
            public const string Unk254_displayName = "Unk254";
            public const int Unk254_sortIndex = 650;
            [SortOrder(Unk254_sortIndex)]
            [DisplayName(Unk254_displayName)]
            public virtual float Unk254 {
                get => Unk254_raw;
                set {
                    if (Unk254_raw == value) return;
                    Unk254_raw = value;
                    OnPropertyChanged(nameof(Unk254));
                }
            }

            protected float Unk255_raw;
            public const string Unk255_displayName = "Unk255";
            public const int Unk255_sortIndex = 700;
            [SortOrder(Unk255_sortIndex)]
            [DisplayName(Unk255_displayName)]
            public virtual float Unk255 {
                get => Unk255_raw;
                set {
                    if (Unk255_raw == value) return;
                    Unk255_raw = value;
                    OnPropertyChanged(nameof(Unk255));
                }
            }

            protected float Unk256_raw;
            public const string Unk256_displayName = "Unk256";
            public const int Unk256_sortIndex = 750;
            [SortOrder(Unk256_sortIndex)]
            [DisplayName(Unk256_displayName)]
            public virtual float Unk256 {
                get => Unk256_raw;
                set {
                    if (Unk256_raw == value) return;
                    Unk256_raw = value;
                    OnPropertyChanged(nameof(Unk256));
                }
            }

            protected float Unk257_raw;
            public const string Unk257_displayName = "Unk257";
            public const int Unk257_sortIndex = 800;
            [SortOrder(Unk257_sortIndex)]
            [DisplayName(Unk257_displayName)]
            public virtual float Unk257 {
                get => Unk257_raw;
                set {
                    if (Unk257_raw == value) return;
                    Unk257_raw = value;
                    OnPropertyChanged(nameof(Unk257));
                }
            }

            protected float Unk258_raw;
            public const string Unk258_displayName = "Unk258";
            public const int Unk258_sortIndex = 850;
            [SortOrder(Unk258_sortIndex)]
            [DisplayName(Unk258_displayName)]
            public virtual float Unk258 {
                get => Unk258_raw;
                set {
                    if (Unk258_raw == value) return;
                    Unk258_raw = value;
                    OnPropertyChanged(nameof(Unk258));
                }
            }

            protected float Unk259_raw;
            public const string Unk259_displayName = "Unk259";
            public const int Unk259_sortIndex = 900;
            [SortOrder(Unk259_sortIndex)]
            [DisplayName(Unk259_displayName)]
            public virtual float Unk259 {
                get => Unk259_raw;
                set {
                    if (Unk259_raw == value) return;
                    Unk259_raw = value;
                    OnPropertyChanged(nameof(Unk259));
                }
            }

            protected float Unk260_raw;
            public const string Unk260_displayName = "Unk260";
            public const int Unk260_sortIndex = 950;
            [SortOrder(Unk260_sortIndex)]
            [DisplayName(Unk260_displayName)]
            public virtual float Unk260 {
                get => Unk260_raw;
                set {
                    if (Unk260_raw == value) return;
                    Unk260_raw = value;
                    OnPropertyChanged(nameof(Unk260));
                }
            }

            protected float Unk261_raw;
            public const string Unk261_displayName = "Unk261";
            public const int Unk261_sortIndex = 1000;
            [SortOrder(Unk261_sortIndex)]
            [DisplayName(Unk261_displayName)]
            public virtual float Unk261 {
                get => Unk261_raw;
                set {
                    if (Unk261_raw == value) return;
                    Unk261_raw = value;
                    OnPropertyChanged(nameof(Unk261));
                }
            }

            protected float Unk262_raw;
            public const string Unk262_displayName = "Unk262";
            public const int Unk262_sortIndex = 1050;
            [SortOrder(Unk262_sortIndex)]
            [DisplayName(Unk262_displayName)]
            public virtual float Unk262 {
                get => Unk262_raw;
                set {
                    if (Unk262_raw == value) return;
                    Unk262_raw = value;
                    OnPropertyChanged(nameof(Unk262));
                }
            }

            protected float Unk263_raw;
            public const string Unk263_displayName = "Unk263";
            public const int Unk263_sortIndex = 1100;
            [SortOrder(Unk263_sortIndex)]
            [DisplayName(Unk263_displayName)]
            public virtual float Unk263 {
                get => Unk263_raw;
                set {
                    if (Unk263_raw == value) return;
                    Unk263_raw = value;
                    OnPropertyChanged(nameof(Unk263));
                }
            }

            protected float Unk264_raw;
            public const string Unk264_displayName = "Unk264";
            public const int Unk264_sortIndex = 1150;
            [SortOrder(Unk264_sortIndex)]
            [DisplayName(Unk264_displayName)]
            public virtual float Unk264 {
                get => Unk264_raw;
                set {
                    if (Unk264_raw == value) return;
                    Unk264_raw = value;
                    OnPropertyChanged(nameof(Unk264));
                }
            }

            protected float Unk265_raw;
            public const string Unk265_displayName = "Unk265";
            public const int Unk265_sortIndex = 1200;
            [SortOrder(Unk265_sortIndex)]
            [DisplayName(Unk265_displayName)]
            public virtual float Unk265 {
                get => Unk265_raw;
                set {
                    if (Unk265_raw == value) return;
                    Unk265_raw = value;
                    OnPropertyChanged(nameof(Unk265));
                }
            }

            protected float Unk266_raw;
            public const string Unk266_displayName = "Unk266";
            public const int Unk266_sortIndex = 1250;
            [SortOrder(Unk266_sortIndex)]
            [DisplayName(Unk266_displayName)]
            public virtual float Unk266 {
                get => Unk266_raw;
                set {
                    if (Unk266_raw == value) return;
                    Unk266_raw = value;
                    OnPropertyChanged(nameof(Unk266));
                }
            }

            protected float Unk267_raw;
            public const string Unk267_displayName = "Unk267";
            public const int Unk267_sortIndex = 1300;
            [SortOrder(Unk267_sortIndex)]
            [DisplayName(Unk267_displayName)]
            public virtual float Unk267 {
                get => Unk267_raw;
                set {
                    if (Unk267_raw == value) return;
                    Unk267_raw = value;
                    OnPropertyChanged(nameof(Unk267));
                }
            }

            protected float Unk268_raw;
            public const string Unk268_displayName = "Unk268";
            public const int Unk268_sortIndex = 1350;
            [SortOrder(Unk268_sortIndex)]
            [DisplayName(Unk268_displayName)]
            public virtual float Unk268 {
                get => Unk268_raw;
                set {
                    if (Unk268_raw == value) return;
                    Unk268_raw = value;
                    OnPropertyChanged(nameof(Unk268));
                }
            }

            protected float Unk269_raw;
            public const string Unk269_displayName = "Unk269";
            public const int Unk269_sortIndex = 1400;
            [SortOrder(Unk269_sortIndex)]
            [DisplayName(Unk269_displayName)]
            public virtual float Unk269 {
                get => Unk269_raw;
                set {
                    if (Unk269_raw == value) return;
                    Unk269_raw = value;
                    OnPropertyChanged(nameof(Unk269));
                }
            }

            protected float Unk270_raw;
            public const string Unk270_displayName = "Unk270";
            public const int Unk270_sortIndex = 1450;
            [SortOrder(Unk270_sortIndex)]
            [DisplayName(Unk270_displayName)]
            public virtual float Unk270 {
                get => Unk270_raw;
                set {
                    if (Unk270_raw == value) return;
                    Unk270_raw = value;
                    OnPropertyChanged(nameof(Unk270));
                }
            }

            protected float Unk271_raw;
            public const string Unk271_displayName = "Unk271";
            public const int Unk271_sortIndex = 1500;
            [SortOrder(Unk271_sortIndex)]
            [DisplayName(Unk271_displayName)]
            public virtual float Unk271 {
                get => Unk271_raw;
                set {
                    if (Unk271_raw == value) return;
                    Unk271_raw = value;
                    OnPropertyChanged(nameof(Unk271));
                }
            }

            protected float Unk272_raw;
            public const string Unk272_displayName = "Unk272";
            public const int Unk272_sortIndex = 1550;
            [SortOrder(Unk272_sortIndex)]
            [DisplayName(Unk272_displayName)]
            public virtual float Unk272 {
                get => Unk272_raw;
                set {
                    if (Unk272_raw == value) return;
                    Unk272_raw = value;
                    OnPropertyChanged(nameof(Unk272));
                }
            }

            protected float Unk273_raw;
            public const string Unk273_displayName = "Unk273";
            public const int Unk273_sortIndex = 1600;
            [SortOrder(Unk273_sortIndex)]
            [DisplayName(Unk273_displayName)]
            public virtual float Unk273 {
                get => Unk273_raw;
                set {
                    if (Unk273_raw == value) return;
                    Unk273_raw = value;
                    OnPropertyChanged(nameof(Unk273));
                }
            }

            protected float Unk274_raw;
            public const string Unk274_displayName = "Unk274";
            public const int Unk274_sortIndex = 1650;
            [SortOrder(Unk274_sortIndex)]
            [DisplayName(Unk274_displayName)]
            public virtual float Unk274 {
                get => Unk274_raw;
                set {
                    if (Unk274_raw == value) return;
                    Unk274_raw = value;
                    OnPropertyChanged(nameof(Unk274));
                }
            }

            protected float Unk275_raw;
            public const string Unk275_displayName = "Unk275";
            public const int Unk275_sortIndex = 1700;
            [SortOrder(Unk275_sortIndex)]
            [DisplayName(Unk275_displayName)]
            public virtual float Unk275 {
                get => Unk275_raw;
                set {
                    if (Unk275_raw == value) return;
                    Unk275_raw = value;
                    OnPropertyChanged(nameof(Unk275));
                }
            }

            protected float Close_range_Up_active_range_1_raw;
            public const string Close_range_Up_active_range_1_displayName = "Close_range_Up_active_range_1";
            public const int Close_range_Up_active_range_1_sortIndex = 1750;
            [SortOrder(Close_range_Up_active_range_1_sortIndex)]
            [DisplayName(Close_range_Up_active_range_1_displayName)]
            public virtual float Close_range_Up_active_range_1 {
                get => Close_range_Up_active_range_1_raw;
                set {
                    if (Close_range_Up_active_range_1_raw == value) return;
                    Close_range_Up_active_range_1_raw = value;
                    OnPropertyChanged(nameof(Close_range_Up_active_range_1));
                }
            }

            protected float Close_range_Up_active_range_2_raw;
            public const string Close_range_Up_active_range_2_displayName = "Close_range_Up_active_range_2";
            public const int Close_range_Up_active_range_2_sortIndex = 1800;
            [SortOrder(Close_range_Up_active_range_2_sortIndex)]
            [DisplayName(Close_range_Up_active_range_2_displayName)]
            public virtual float Close_range_Up_active_range_2 {
                get => Close_range_Up_active_range_2_raw;
                set {
                    if (Close_range_Up_active_range_2_raw == value) return;
                    Close_range_Up_active_range_2_raw = value;
                    OnPropertyChanged(nameof(Close_range_Up_active_range_2));
                }
            }

            protected float Close_range_Up_active_range_3_raw;
            public const string Close_range_Up_active_range_3_displayName = "Close_range_Up_active_range_3";
            public const int Close_range_Up_active_range_3_sortIndex = 1850;
            [SortOrder(Close_range_Up_active_range_3_sortIndex)]
            [DisplayName(Close_range_Up_active_range_3_displayName)]
            public virtual float Close_range_Up_active_range_3 {
                get => Close_range_Up_active_range_3_raw;
                set {
                    if (Close_range_Up_active_range_3_raw == value) return;
                    Close_range_Up_active_range_3_raw = value;
                    OnPropertyChanged(nameof(Close_range_Up_active_range_3));
                }
            }

            protected float Close_range_Up_active_range_4_raw;
            public const string Close_range_Up_active_range_4_displayName = "Close_range_Up_active_range_4";
            public const int Close_range_Up_active_range_4_sortIndex = 1900;
            [SortOrder(Close_range_Up_active_range_4_sortIndex)]
            [DisplayName(Close_range_Up_active_range_4_displayName)]
            public virtual float Close_range_Up_active_range_4 {
                get => Close_range_Up_active_range_4_raw;
                set {
                    if (Close_range_Up_active_range_4_raw == value) return;
                    Close_range_Up_active_range_4_raw = value;
                    OnPropertyChanged(nameof(Close_range_Up_active_range_4));
                }
            }

            protected float Close_range_Up_Modifier_1_raw;
            public const string Close_range_Up_Modifier_1_displayName = "Close_range_Up_Modifier_1";
            public const int Close_range_Up_Modifier_1_sortIndex = 1950;
            [SortOrder(Close_range_Up_Modifier_1_sortIndex)]
            [DisplayName(Close_range_Up_Modifier_1_displayName)]
            public virtual float Close_range_Up_Modifier_1 {
                get => Close_range_Up_Modifier_1_raw;
                set {
                    if (Close_range_Up_Modifier_1_raw == value) return;
                    Close_range_Up_Modifier_1_raw = value;
                    OnPropertyChanged(nameof(Close_range_Up_Modifier_1));
                }
            }

            protected float Close_range_Up_Modifier_2_raw;
            public const string Close_range_Up_Modifier_2_displayName = "Close_range_Up_Modifier_2";
            public const int Close_range_Up_Modifier_2_sortIndex = 2000;
            [SortOrder(Close_range_Up_Modifier_2_sortIndex)]
            [DisplayName(Close_range_Up_Modifier_2_displayName)]
            public virtual float Close_range_Up_Modifier_2 {
                get => Close_range_Up_Modifier_2_raw;
                set {
                    if (Close_range_Up_Modifier_2_raw == value) return;
                    Close_range_Up_Modifier_2_raw = value;
                    OnPropertyChanged(nameof(Close_range_Up_Modifier_2));
                }
            }

            protected float Close_range_Up_Modifier_3_raw;
            public const string Close_range_Up_Modifier_3_displayName = "Close_range_Up_Modifier_3";
            public const int Close_range_Up_Modifier_3_sortIndex = 2050;
            [SortOrder(Close_range_Up_Modifier_3_sortIndex)]
            [DisplayName(Close_range_Up_Modifier_3_displayName)]
            public virtual float Close_range_Up_Modifier_3 {
                get => Close_range_Up_Modifier_3_raw;
                set {
                    if (Close_range_Up_Modifier_3_raw == value) return;
                    Close_range_Up_Modifier_3_raw = value;
                    OnPropertyChanged(nameof(Close_range_Up_Modifier_3));
                }
            }

            protected float Close_range_Up_Modifier_4_raw;
            public const string Close_range_Up_Modifier_4_displayName = "Close_range_Up_Modifier_4";
            public const int Close_range_Up_Modifier_4_sortIndex = 2100;
            [SortOrder(Close_range_Up_Modifier_4_sortIndex)]
            [DisplayName(Close_range_Up_Modifier_4_displayName)]
            public virtual float Close_range_Up_Modifier_4 {
                get => Close_range_Up_Modifier_4_raw;
                set {
                    if (Close_range_Up_Modifier_4_raw == value) return;
                    Close_range_Up_Modifier_4_raw = value;
                    OnPropertyChanged(nameof(Close_range_Up_Modifier_4));
                }
            }

            protected float Ranged_Attack_Up_active_distance_1_raw;
            public const string Ranged_Attack_Up_active_distance_1_displayName = "Ranged_Attack_Up_active_distance_1";
            public const int Ranged_Attack_Up_active_distance_1_sortIndex = 2150;
            [SortOrder(Ranged_Attack_Up_active_distance_1_sortIndex)]
            [DisplayName(Ranged_Attack_Up_active_distance_1_displayName)]
            public virtual float Ranged_Attack_Up_active_distance_1 {
                get => Ranged_Attack_Up_active_distance_1_raw;
                set {
                    if (Ranged_Attack_Up_active_distance_1_raw == value) return;
                    Ranged_Attack_Up_active_distance_1_raw = value;
                    OnPropertyChanged(nameof(Ranged_Attack_Up_active_distance_1));
                }
            }

            protected float Ranged_Attack_Up_active_distance_2_raw;
            public const string Ranged_Attack_Up_active_distance_2_displayName = "Ranged_Attack_Up_active_distance_2";
            public const int Ranged_Attack_Up_active_distance_2_sortIndex = 2200;
            [SortOrder(Ranged_Attack_Up_active_distance_2_sortIndex)]
            [DisplayName(Ranged_Attack_Up_active_distance_2_displayName)]
            public virtual float Ranged_Attack_Up_active_distance_2 {
                get => Ranged_Attack_Up_active_distance_2_raw;
                set {
                    if (Ranged_Attack_Up_active_distance_2_raw == value) return;
                    Ranged_Attack_Up_active_distance_2_raw = value;
                    OnPropertyChanged(nameof(Ranged_Attack_Up_active_distance_2));
                }
            }

            protected float Ranged_Attack_Up_active_distance_3_raw;
            public const string Ranged_Attack_Up_active_distance_3_displayName = "Ranged_Attack_Up_active_distance_3";
            public const int Ranged_Attack_Up_active_distance_3_sortIndex = 2250;
            [SortOrder(Ranged_Attack_Up_active_distance_3_sortIndex)]
            [DisplayName(Ranged_Attack_Up_active_distance_3_displayName)]
            public virtual float Ranged_Attack_Up_active_distance_3 {
                get => Ranged_Attack_Up_active_distance_3_raw;
                set {
                    if (Ranged_Attack_Up_active_distance_3_raw == value) return;
                    Ranged_Attack_Up_active_distance_3_raw = value;
                    OnPropertyChanged(nameof(Ranged_Attack_Up_active_distance_3));
                }
            }

            protected float Ranged_Attack_Up_active_distance_4_raw;
            public const string Ranged_Attack_Up_active_distance_4_displayName = "Ranged_Attack_Up_active_distance_4";
            public const int Ranged_Attack_Up_active_distance_4_sortIndex = 2300;
            [SortOrder(Ranged_Attack_Up_active_distance_4_sortIndex)]
            [DisplayName(Ranged_Attack_Up_active_distance_4_displayName)]
            public virtual float Ranged_Attack_Up_active_distance_4 {
                get => Ranged_Attack_Up_active_distance_4_raw;
                set {
                    if (Ranged_Attack_Up_active_distance_4_raw == value) return;
                    Ranged_Attack_Up_active_distance_4_raw = value;
                    OnPropertyChanged(nameof(Ranged_Attack_Up_active_distance_4));
                }
            }

            protected float Ranged_Attack_Up_Modifier_1_raw;
            public const string Ranged_Attack_Up_Modifier_1_displayName = "Ranged_Attack_Up_Modifier_1";
            public const int Ranged_Attack_Up_Modifier_1_sortIndex = 2350;
            [SortOrder(Ranged_Attack_Up_Modifier_1_sortIndex)]
            [DisplayName(Ranged_Attack_Up_Modifier_1_displayName)]
            public virtual float Ranged_Attack_Up_Modifier_1 {
                get => Ranged_Attack_Up_Modifier_1_raw;
                set {
                    if (Ranged_Attack_Up_Modifier_1_raw == value) return;
                    Ranged_Attack_Up_Modifier_1_raw = value;
                    OnPropertyChanged(nameof(Ranged_Attack_Up_Modifier_1));
                }
            }

            protected float Ranged_Attack_Up_Modifier_2_raw;
            public const string Ranged_Attack_Up_Modifier_2_displayName = "Ranged_Attack_Up_Modifier_2";
            public const int Ranged_Attack_Up_Modifier_2_sortIndex = 2400;
            [SortOrder(Ranged_Attack_Up_Modifier_2_sortIndex)]
            [DisplayName(Ranged_Attack_Up_Modifier_2_displayName)]
            public virtual float Ranged_Attack_Up_Modifier_2 {
                get => Ranged_Attack_Up_Modifier_2_raw;
                set {
                    if (Ranged_Attack_Up_Modifier_2_raw == value) return;
                    Ranged_Attack_Up_Modifier_2_raw = value;
                    OnPropertyChanged(nameof(Ranged_Attack_Up_Modifier_2));
                }
            }

            protected float Ranged_Attack_Up_Modifier_3_raw;
            public const string Ranged_Attack_Up_Modifier_3_displayName = "Ranged_Attack_Up_Modifier_3";
            public const int Ranged_Attack_Up_Modifier_3_sortIndex = 2450;
            [SortOrder(Ranged_Attack_Up_Modifier_3_sortIndex)]
            [DisplayName(Ranged_Attack_Up_Modifier_3_displayName)]
            public virtual float Ranged_Attack_Up_Modifier_3 {
                get => Ranged_Attack_Up_Modifier_3_raw;
                set {
                    if (Ranged_Attack_Up_Modifier_3_raw == value) return;
                    Ranged_Attack_Up_Modifier_3_raw = value;
                    OnPropertyChanged(nameof(Ranged_Attack_Up_Modifier_3));
                }
            }

            protected float Ranged_Attack_Up_Modifier_4_raw;
            public const string Ranged_Attack_Up_Modifier_4_displayName = "Ranged_Attack_Up_Modifier_4";
            public const int Ranged_Attack_Up_Modifier_4_sortIndex = 2500;
            [SortOrder(Ranged_Attack_Up_Modifier_4_sortIndex)]
            [DisplayName(Ranged_Attack_Up_Modifier_4_displayName)]
            public virtual float Ranged_Attack_Up_Modifier_4 {
                get => Ranged_Attack_Up_Modifier_4_raw;
                set {
                    if (Ranged_Attack_Up_Modifier_4_raw == value) return;
                    Ranged_Attack_Up_Modifier_4_raw = value;
                    OnPropertyChanged(nameof(Ranged_Attack_Up_Modifier_4));
                }
            }

            protected float Guard_Angle_Both_Sides__raw;
            public const string Guard_Angle_Both_Sides__displayName = "Guard Angle (Both Sides)";
            public const int Guard_Angle_Both_Sides__sortIndex = 2550;
            [SortOrder(Guard_Angle_Both_Sides__sortIndex)]
            [DisplayName(Guard_Angle_Both_Sides__displayName)]
            public virtual float Guard_Angle_Both_Sides_ {
                get => Guard_Angle_Both_Sides__raw;
                set {
                    if (Guard_Angle_Both_Sides__raw == value) return;
                    Guard_Angle_Both_Sides__raw = value;
                    OnPropertyChanged(nameof(Guard_Angle_Both_Sides_));
                }
            }

            public static W12p_Params_5_ LoadData(BinaryReader reader) {
                var data = new W12p_Params_5_();
                data.Unk242_raw = reader.ReadSingle();
                data.Unk243_raw = reader.ReadSingle();
                data.Unk244_raw = reader.ReadSingle();
                data.Unk245_raw = reader.ReadSingle();
                data.Unk246_raw = reader.ReadSingle();
                data.Unk247_raw = reader.ReadSingle();
                data.Unk248_raw = reader.ReadSingle();
                data.Unk249_raw = reader.ReadSingle();
                data.Unk250_raw = reader.ReadSingle();
                data.Unk251_raw = reader.ReadSingle();
                data.Unk252_raw = reader.ReadSingle();
                data.Unk253_raw = reader.ReadSingle();
                data.Unk254_raw = reader.ReadSingle();
                data.Unk255_raw = reader.ReadSingle();
                data.Unk256_raw = reader.ReadSingle();
                data.Unk257_raw = reader.ReadSingle();
                data.Unk258_raw = reader.ReadSingle();
                data.Unk259_raw = reader.ReadSingle();
                data.Unk260_raw = reader.ReadSingle();
                data.Unk261_raw = reader.ReadSingle();
                data.Unk262_raw = reader.ReadSingle();
                data.Unk263_raw = reader.ReadSingle();
                data.Unk264_raw = reader.ReadSingle();
                data.Unk265_raw = reader.ReadSingle();
                data.Unk266_raw = reader.ReadSingle();
                data.Unk267_raw = reader.ReadSingle();
                data.Unk268_raw = reader.ReadSingle();
                data.Unk269_raw = reader.ReadSingle();
                data.Unk270_raw = reader.ReadSingle();
                data.Unk271_raw = reader.ReadSingle();
                data.Unk272_raw = reader.ReadSingle();
                data.Unk273_raw = reader.ReadSingle();
                data.Unk274_raw = reader.ReadSingle();
                data.Unk275_raw = reader.ReadSingle();
                data.Close_range_Up_active_range_1_raw = reader.ReadSingle();
                data.Close_range_Up_active_range_2_raw = reader.ReadSingle();
                data.Close_range_Up_active_range_3_raw = reader.ReadSingle();
                data.Close_range_Up_active_range_4_raw = reader.ReadSingle();
                data.Close_range_Up_Modifier_1_raw = reader.ReadSingle();
                data.Close_range_Up_Modifier_2_raw = reader.ReadSingle();
                data.Close_range_Up_Modifier_3_raw = reader.ReadSingle();
                data.Close_range_Up_Modifier_4_raw = reader.ReadSingle();
                data.Ranged_Attack_Up_active_distance_1_raw = reader.ReadSingle();
                data.Ranged_Attack_Up_active_distance_2_raw = reader.ReadSingle();
                data.Ranged_Attack_Up_active_distance_3_raw = reader.ReadSingle();
                data.Ranged_Attack_Up_active_distance_4_raw = reader.ReadSingle();
                data.Ranged_Attack_Up_Modifier_1_raw = reader.ReadSingle();
                data.Ranged_Attack_Up_Modifier_2_raw = reader.ReadSingle();
                data.Ranged_Attack_Up_Modifier_3_raw = reader.ReadSingle();
                data.Ranged_Attack_Up_Modifier_4_raw = reader.ReadSingle();
                data.Guard_Angle_Both_Sides__raw = reader.ReadSingle();
                return data;
            }

            public override void WriteData(BinaryWriter writer) {
                writer.Write(Unk242_raw);
                writer.Write(Unk243_raw);
                writer.Write(Unk244_raw);
                writer.Write(Unk245_raw);
                writer.Write(Unk246_raw);
                writer.Write(Unk247_raw);
                writer.Write(Unk248_raw);
                writer.Write(Unk249_raw);
                writer.Write(Unk250_raw);
                writer.Write(Unk251_raw);
                writer.Write(Unk252_raw);
                writer.Write(Unk253_raw);
                writer.Write(Unk254_raw);
                writer.Write(Unk255_raw);
                writer.Write(Unk256_raw);
                writer.Write(Unk257_raw);
                writer.Write(Unk258_raw);
                writer.Write(Unk259_raw);
                writer.Write(Unk260_raw);
                writer.Write(Unk261_raw);
                writer.Write(Unk262_raw);
                writer.Write(Unk263_raw);
                writer.Write(Unk264_raw);
                writer.Write(Unk265_raw);
                writer.Write(Unk266_raw);
                writer.Write(Unk267_raw);
                writer.Write(Unk268_raw);
                writer.Write(Unk269_raw);
                writer.Write(Unk270_raw);
                writer.Write(Unk271_raw);
                writer.Write(Unk272_raw);
                writer.Write(Unk273_raw);
                writer.Write(Unk274_raw);
                writer.Write(Unk275_raw);
                writer.Write(Close_range_Up_active_range_1_raw);
                writer.Write(Close_range_Up_active_range_2_raw);
                writer.Write(Close_range_Up_active_range_3_raw);
                writer.Write(Close_range_Up_active_range_4_raw);
                writer.Write(Close_range_Up_Modifier_1_raw);
                writer.Write(Close_range_Up_Modifier_2_raw);
                writer.Write(Close_range_Up_Modifier_3_raw);
                writer.Write(Close_range_Up_Modifier_4_raw);
                writer.Write(Ranged_Attack_Up_active_distance_1_raw);
                writer.Write(Ranged_Attack_Up_active_distance_2_raw);
                writer.Write(Ranged_Attack_Up_active_distance_3_raw);
                writer.Write(Ranged_Attack_Up_active_distance_4_raw);
                writer.Write(Ranged_Attack_Up_Modifier_1_raw);
                writer.Write(Ranged_Attack_Up_Modifier_2_raw);
                writer.Write(Ranged_Attack_Up_Modifier_3_raw);
                writer.Write(Ranged_Attack_Up_Modifier_4_raw);
                writer.Write(Guard_Angle_Both_Sides__raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Unk242", "Unk242"),
                    new MultiStructItemCustomView(this, "Unk243", "Unk243"),
                    new MultiStructItemCustomView(this, "Unk244", "Unk244"),
                    new MultiStructItemCustomView(this, "Unk245", "Unk245"),
                    new MultiStructItemCustomView(this, "Unk246", "Unk246"),
                    new MultiStructItemCustomView(this, "Unk247", "Unk247"),
                    new MultiStructItemCustomView(this, "Unk248", "Unk248"),
                    new MultiStructItemCustomView(this, "Unk249", "Unk249"),
                    new MultiStructItemCustomView(this, "Unk250", "Unk250"),
                    new MultiStructItemCustomView(this, "Unk251", "Unk251"),
                    new MultiStructItemCustomView(this, "Unk252", "Unk252"),
                    new MultiStructItemCustomView(this, "Unk253", "Unk253"),
                    new MultiStructItemCustomView(this, "Unk254", "Unk254"),
                    new MultiStructItemCustomView(this, "Unk255", "Unk255"),
                    new MultiStructItemCustomView(this, "Unk256", "Unk256"),
                    new MultiStructItemCustomView(this, "Unk257", "Unk257"),
                    new MultiStructItemCustomView(this, "Unk258", "Unk258"),
                    new MultiStructItemCustomView(this, "Unk259", "Unk259"),
                    new MultiStructItemCustomView(this, "Unk260", "Unk260"),
                    new MultiStructItemCustomView(this, "Unk261", "Unk261"),
                    new MultiStructItemCustomView(this, "Unk262", "Unk262"),
                    new MultiStructItemCustomView(this, "Unk263", "Unk263"),
                    new MultiStructItemCustomView(this, "Unk264", "Unk264"),
                    new MultiStructItemCustomView(this, "Unk265", "Unk265"),
                    new MultiStructItemCustomView(this, "Unk266", "Unk266"),
                    new MultiStructItemCustomView(this, "Unk267", "Unk267"),
                    new MultiStructItemCustomView(this, "Unk268", "Unk268"),
                    new MultiStructItemCustomView(this, "Unk269", "Unk269"),
                    new MultiStructItemCustomView(this, "Unk270", "Unk270"),
                    new MultiStructItemCustomView(this, "Unk271", "Unk271"),
                    new MultiStructItemCustomView(this, "Unk272", "Unk272"),
                    new MultiStructItemCustomView(this, "Unk273", "Unk273"),
                    new MultiStructItemCustomView(this, "Unk274", "Unk274"),
                    new MultiStructItemCustomView(this, "Unk275", "Unk275"),
                    new MultiStructItemCustomView(this, "Close_range_Up_active_range_1", "Close_range_Up_active_range_1"),
                    new MultiStructItemCustomView(this, "Close_range_Up_active_range_2", "Close_range_Up_active_range_2"),
                    new MultiStructItemCustomView(this, "Close_range_Up_active_range_3", "Close_range_Up_active_range_3"),
                    new MultiStructItemCustomView(this, "Close_range_Up_active_range_4", "Close_range_Up_active_range_4"),
                    new MultiStructItemCustomView(this, "Close_range_Up_Modifier_1", "Close_range_Up_Modifier_1"),
                    new MultiStructItemCustomView(this, "Close_range_Up_Modifier_2", "Close_range_Up_Modifier_2"),
                    new MultiStructItemCustomView(this, "Close_range_Up_Modifier_3", "Close_range_Up_Modifier_3"),
                    new MultiStructItemCustomView(this, "Close_range_Up_Modifier_4", "Close_range_Up_Modifier_4"),
                    new MultiStructItemCustomView(this, "Ranged_Attack_Up_active_distance_1", "Ranged_Attack_Up_active_distance_1"),
                    new MultiStructItemCustomView(this, "Ranged_Attack_Up_active_distance_2", "Ranged_Attack_Up_active_distance_2"),
                    new MultiStructItemCustomView(this, "Ranged_Attack_Up_active_distance_3", "Ranged_Attack_Up_active_distance_3"),
                    new MultiStructItemCustomView(this, "Ranged_Attack_Up_active_distance_4", "Ranged_Attack_Up_active_distance_4"),
                    new MultiStructItemCustomView(this, "Ranged_Attack_Up_Modifier_1", "Ranged_Attack_Up_Modifier_1"),
                    new MultiStructItemCustomView(this, "Ranged_Attack_Up_Modifier_2", "Ranged_Attack_Up_Modifier_2"),
                    new MultiStructItemCustomView(this, "Ranged_Attack_Up_Modifier_3", "Ranged_Attack_Up_Modifier_3"),
                    new MultiStructItemCustomView(this, "Ranged_Attack_Up_Modifier_4", "Ranged_Attack_Up_Modifier_4"),
                    new MultiStructItemCustomView(this, "Guard Angle (Both Sides)", "Guard_Angle_Both_Sides_"),
                };
            }
        }

        public partial class Number_of_Shield_Mods_Struct : MhwStructItem {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Number of Shield Mods Struct";
            public const bool IsHidden = true;

            protected uint Number_of_Shield_Mods_raw;
            public const string Number_of_Shield_Mods_displayName = "Number of Shield Mods";
            public const int Number_of_Shield_Mods_sortIndex = 50;
            [SortOrder(Number_of_Shield_Mods_sortIndex)]
            [DisplayName(Number_of_Shield_Mods_displayName)]
            public virtual uint Number_of_Shield_Mods {
                get => Number_of_Shield_Mods_raw;
                set {
                    if (Number_of_Shield_Mods_raw == value) return;
                    Number_of_Shield_Mods_raw = value;
                    OnPropertyChanged(nameof(Number_of_Shield_Mods));
                }
            }

            public static Number_of_Shield_Mods_Struct LoadData(BinaryReader reader) {
                var data = new Number_of_Shield_Mods_Struct();
                data.Number_of_Shield_Mods_raw = reader.ReadUInt32();
                return data;
            }

            public override void WriteData(BinaryWriter writer) {
                writer.Write(Number_of_Shield_Mods_raw);
            }
        }

        public partial class Shield_Mods : MhwStructItem {
            public const ulong FixedSizeCount = 0;
            public const string GridName = "Shield Mods";
            public const bool IsAddingAllowed = true;

            protected byte Small_raw;
            public const string Small_displayName = "Small";
            public const int Small_sortIndex = 50;
            [SortOrder(Small_sortIndex)]
            [DisplayName(Small_displayName)]
            public virtual byte Small {
                get => Small_raw;
                set {
                    if (Small_raw == value) return;
                    Small_raw = value;
                    OnPropertyChanged(nameof(Small));
                }
            }

            protected byte Medium_raw;
            public const string Medium_displayName = "Medium";
            public const int Medium_sortIndex = 100;
            [SortOrder(Medium_sortIndex)]
            [DisplayName(Medium_displayName)]
            public virtual byte Medium {
                get => Medium_raw;
                set {
                    if (Medium_raw == value) return;
                    Medium_raw = value;
                    OnPropertyChanged(nameof(Medium));
                }
            }

            protected byte Large_raw;
            public const string Large_displayName = "Large";
            public const int Large_sortIndex = 150;
            [SortOrder(Large_sortIndex)]
            [DisplayName(Large_displayName)]
            public virtual byte Large {
                get => Large_raw;
                set {
                    if (Large_raw == value) return;
                    Large_raw = value;
                    OnPropertyChanged(nameof(Large));
                }
            }

            public static Shield_Mods LoadData(BinaryReader reader) {
                var data = new Shield_Mods();
                data.Small_raw = reader.ReadByte();
                data.Medium_raw = reader.ReadByte();
                data.Large_raw = reader.ReadByte();
                return data;
            }

            public override void WriteData(BinaryWriter writer) {
                writer.Write(Small_raw);
                writer.Write(Medium_raw);
                writer.Write(Large_raw);
            }
        }

        public partial class W12p_Params_6_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView> {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W12p Params (6)";

            protected float Unk277_raw;
            public const string Unk277_displayName = "Unk277";
            public const int Unk277_sortIndex = 50;
            [SortOrder(Unk277_sortIndex)]
            [DisplayName(Unk277_displayName)]
            public virtual float Unk277 {
                get => Unk277_raw;
                set {
                    if (Unk277_raw == value) return;
                    Unk277_raw = value;
                    OnPropertyChanged(nameof(Unk277));
                }
            }

            protected float Unk278_raw;
            public const string Unk278_displayName = "Unk278";
            public const int Unk278_sortIndex = 100;
            [SortOrder(Unk278_sortIndex)]
            [DisplayName(Unk278_displayName)]
            public virtual float Unk278 {
                get => Unk278_raw;
                set {
                    if (Unk278_raw == value) return;
                    Unk278_raw = value;
                    OnPropertyChanged(nameof(Unk278));
                }
            }

            protected float Unk279_raw;
            public const string Unk279_displayName = "Unk279";
            public const int Unk279_sortIndex = 150;
            [SortOrder(Unk279_sortIndex)]
            [DisplayName(Unk279_displayName)]
            public virtual float Unk279 {
                get => Unk279_raw;
                set {
                    if (Unk279_raw == value) return;
                    Unk279_raw = value;
                    OnPropertyChanged(nameof(Unk279));
                }
            }

            protected float Unk280_raw;
            public const string Unk280_displayName = "Unk280";
            public const int Unk280_sortIndex = 200;
            [SortOrder(Unk280_sortIndex)]
            [DisplayName(Unk280_displayName)]
            public virtual float Unk280 {
                get => Unk280_raw;
                set {
                    if (Unk280_raw == value) return;
                    Unk280_raw = value;
                    OnPropertyChanged(nameof(Unk280));
                }
            }

            protected float Unk281_raw;
            public const string Unk281_displayName = "Unk281";
            public const int Unk281_sortIndex = 250;
            [SortOrder(Unk281_sortIndex)]
            [DisplayName(Unk281_displayName)]
            public virtual float Unk281 {
                get => Unk281_raw;
                set {
                    if (Unk281_raw == value) return;
                    Unk281_raw = value;
                    OnPropertyChanged(nameof(Unk281));
                }
            }

            protected float Unk282_raw;
            public const string Unk282_displayName = "Unk282";
            public const int Unk282_sortIndex = 300;
            [SortOrder(Unk282_sortIndex)]
            [DisplayName(Unk282_displayName)]
            public virtual float Unk282 {
                get => Unk282_raw;
                set {
                    if (Unk282_raw == value) return;
                    Unk282_raw = value;
                    OnPropertyChanged(nameof(Unk282));
                }
            }

            protected float Unk283_raw;
            public const string Unk283_displayName = "Unk283";
            public const int Unk283_sortIndex = 350;
            [SortOrder(Unk283_sortIndex)]
            [DisplayName(Unk283_displayName)]
            public virtual float Unk283 {
                get => Unk283_raw;
                set {
                    if (Unk283_raw == value) return;
                    Unk283_raw = value;
                    OnPropertyChanged(nameof(Unk283));
                }
            }

            protected float Unk284_raw;
            public const string Unk284_displayName = "Unk284";
            public const int Unk284_sortIndex = 400;
            [SortOrder(Unk284_sortIndex)]
            [DisplayName(Unk284_displayName)]
            public virtual float Unk284 {
                get => Unk284_raw;
                set {
                    if (Unk284_raw == value) return;
                    Unk284_raw = value;
                    OnPropertyChanged(nameof(Unk284));
                }
            }

            protected float Unk285_raw;
            public const string Unk285_displayName = "Unk285";
            public const int Unk285_sortIndex = 450;
            [SortOrder(Unk285_sortIndex)]
            [DisplayName(Unk285_displayName)]
            public virtual float Unk285 {
                get => Unk285_raw;
                set {
                    if (Unk285_raw == value) return;
                    Unk285_raw = value;
                    OnPropertyChanged(nameof(Unk285));
                }
            }

            protected float Unk286_raw;
            public const string Unk286_displayName = "Unk286";
            public const int Unk286_sortIndex = 500;
            [SortOrder(Unk286_sortIndex)]
            [DisplayName(Unk286_displayName)]
            public virtual float Unk286 {
                get => Unk286_raw;
                set {
                    if (Unk286_raw == value) return;
                    Unk286_raw = value;
                    OnPropertyChanged(nameof(Unk286));
                }
            }

            public static W12p_Params_6_ LoadData(BinaryReader reader) {
                var data = new W12p_Params_6_();
                data.Unk277_raw = reader.ReadSingle();
                data.Unk278_raw = reader.ReadSingle();
                data.Unk279_raw = reader.ReadSingle();
                data.Unk280_raw = reader.ReadSingle();
                data.Unk281_raw = reader.ReadSingle();
                data.Unk282_raw = reader.ReadSingle();
                data.Unk283_raw = reader.ReadSingle();
                data.Unk284_raw = reader.ReadSingle();
                data.Unk285_raw = reader.ReadSingle();
                data.Unk286_raw = reader.ReadSingle();
                return data;
            }

            public override void WriteData(BinaryWriter writer) {
                writer.Write(Unk277_raw);
                writer.Write(Unk278_raw);
                writer.Write(Unk279_raw);
                writer.Write(Unk280_raw);
                writer.Write(Unk281_raw);
                writer.Write(Unk282_raw);
                writer.Write(Unk283_raw);
                writer.Write(Unk284_raw);
                writer.Write(Unk285_raw);
                writer.Write(Unk286_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Unk277", "Unk277"),
                    new MultiStructItemCustomView(this, "Unk278", "Unk278"),
                    new MultiStructItemCustomView(this, "Unk279", "Unk279"),
                    new MultiStructItemCustomView(this, "Unk280", "Unk280"),
                    new MultiStructItemCustomView(this, "Unk281", "Unk281"),
                    new MultiStructItemCustomView(this, "Unk282", "Unk282"),
                    new MultiStructItemCustomView(this, "Unk283", "Unk283"),
                    new MultiStructItemCustomView(this, "Unk284", "Unk284"),
                    new MultiStructItemCustomView(this, "Unk285", "Unk285"),
                    new MultiStructItemCustomView(this, "Unk286", "Unk286"),
                };
            }
        }

        public partial class Unk_Struct_5 : MhwStructItem {
            public const ulong FixedSizeCount = 50;
            public const string GridName = "Unk Struct 5";

            protected float Unk1_raw;
            public const string Unk1_displayName = "Unk1";
            public const int Unk1_sortIndex = 50;
            [SortOrder(Unk1_sortIndex)]
            [DisplayName(Unk1_displayName)]
            public virtual float Unk1 {
                get => Unk1_raw;
                set {
                    if (Unk1_raw == value) return;
                    Unk1_raw = value;
                    OnPropertyChanged(nameof(Unk1));
                }
            }

            protected float Unk2_raw;
            public const string Unk2_displayName = "Unk2";
            public const int Unk2_sortIndex = 100;
            [SortOrder(Unk2_sortIndex)]
            [DisplayName(Unk2_displayName)]
            public virtual float Unk2 {
                get => Unk2_raw;
                set {
                    if (Unk2_raw == value) return;
                    Unk2_raw = value;
                    OnPropertyChanged(nameof(Unk2));
                }
            }

            protected float Unk3_raw;
            public const string Unk3_displayName = "Unk3";
            public const int Unk3_sortIndex = 150;
            [SortOrder(Unk3_sortIndex)]
            [DisplayName(Unk3_displayName)]
            public virtual float Unk3 {
                get => Unk3_raw;
                set {
                    if (Unk3_raw == value) return;
                    Unk3_raw = value;
                    OnPropertyChanged(nameof(Unk3));
                }
            }

            protected float Unk4_raw;
            public const string Unk4_displayName = "Unk4";
            public const int Unk4_sortIndex = 200;
            [SortOrder(Unk4_sortIndex)]
            [DisplayName(Unk4_displayName)]
            public virtual float Unk4 {
                get => Unk4_raw;
                set {
                    if (Unk4_raw == value) return;
                    Unk4_raw = value;
                    OnPropertyChanged(nameof(Unk4));
                }
            }

            public static Unk_Struct_5 LoadData(BinaryReader reader) {
                var data = new Unk_Struct_5();
                data.Unk1_raw = reader.ReadSingle();
                data.Unk2_raw = reader.ReadSingle();
                data.Unk3_raw = reader.ReadSingle();
                data.Unk4_raw = reader.ReadSingle();
                return data;
            }

            public override void WriteData(BinaryWriter writer) {
                writer.Write(Unk1_raw);
                writer.Write(Unk2_raw);
                writer.Write(Unk3_raw);
                writer.Write(Unk4_raw);
            }
        }

        public partial class W12p_Params_7_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView> {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "W12p Params (7)";

            protected float Unk287_raw;
            public const string Unk287_displayName = "Unk287";
            public const int Unk287_sortIndex = 50;
            [SortOrder(Unk287_sortIndex)]
            [DisplayName(Unk287_displayName)]
            public virtual float Unk287 {
                get => Unk287_raw;
                set {
                    if (Unk287_raw == value) return;
                    Unk287_raw = value;
                    OnPropertyChanged(nameof(Unk287));
                }
            }

            protected float Unk288_raw;
            public const string Unk288_displayName = "Unk288";
            public const int Unk288_sortIndex = 100;
            [SortOrder(Unk288_sortIndex)]
            [DisplayName(Unk288_displayName)]
            public virtual float Unk288 {
                get => Unk288_raw;
                set {
                    if (Unk288_raw == value) return;
                    Unk288_raw = value;
                    OnPropertyChanged(nameof(Unk288));
                }
            }

            protected float Unk289_raw;
            public const string Unk289_displayName = "Unk289";
            public const int Unk289_sortIndex = 150;
            [SortOrder(Unk289_sortIndex)]
            [DisplayName(Unk289_displayName)]
            public virtual float Unk289 {
                get => Unk289_raw;
                set {
                    if (Unk289_raw == value) return;
                    Unk289_raw = value;
                    OnPropertyChanged(nameof(Unk289));
                }
            }

            protected float Unk290_raw;
            public const string Unk290_displayName = "Unk290";
            public const int Unk290_sortIndex = 200;
            [SortOrder(Unk290_sortIndex)]
            [DisplayName(Unk290_displayName)]
            public virtual float Unk290 {
                get => Unk290_raw;
                set {
                    if (Unk290_raw == value) return;
                    Unk290_raw = value;
                    OnPropertyChanged(nameof(Unk290));
                }
            }

            protected float Unk291_raw;
            public const string Unk291_displayName = "Unk291";
            public const int Unk291_sortIndex = 250;
            [SortOrder(Unk291_sortIndex)]
            [DisplayName(Unk291_displayName)]
            public virtual float Unk291 {
                get => Unk291_raw;
                set {
                    if (Unk291_raw == value) return;
                    Unk291_raw = value;
                    OnPropertyChanged(nameof(Unk291));
                }
            }

            protected float Unk292_raw;
            public const string Unk292_displayName = "Unk292";
            public const int Unk292_sortIndex = 300;
            [SortOrder(Unk292_sortIndex)]
            [DisplayName(Unk292_displayName)]
            public virtual float Unk292 {
                get => Unk292_raw;
                set {
                    if (Unk292_raw == value) return;
                    Unk292_raw = value;
                    OnPropertyChanged(nameof(Unk292));
                }
            }

            public static W12p_Params_7_ LoadData(BinaryReader reader) {
                var data = new W12p_Params_7_();
                data.Unk287_raw = reader.ReadSingle();
                data.Unk288_raw = reader.ReadSingle();
                data.Unk289_raw = reader.ReadSingle();
                data.Unk290_raw = reader.ReadSingle();
                data.Unk291_raw = reader.ReadSingle();
                data.Unk292_raw = reader.ReadSingle();
                return data;
            }

            public override void WriteData(BinaryWriter writer) {
                writer.Write(Unk287_raw);
                writer.Write(Unk288_raw);
                writer.Write(Unk289_raw);
                writer.Write(Unk290_raw);
                writer.Write(Unk291_raw);
                writer.Write(Unk292_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Unk287", "Unk287"),
                    new MultiStructItemCustomView(this, "Unk288", "Unk288"),
                    new MultiStructItemCustomView(this, "Unk289", "Unk289"),
                    new MultiStructItemCustomView(this, "Unk290", "Unk290"),
                    new MultiStructItemCustomView(this, "Unk291", "Unk291"),
                    new MultiStructItemCustomView(this, "Unk292", "Unk292"),
                };
            }
        }

        public override void LoadFile(string targetFile) {
            using var reader = new BinaryReader(OpenFile(targetFile, EncryptionKey));
            data = new List<MhwStructDataContainer>();
            dataByType = new Dictionary<Type, MhwStructDataContainer>();

            var W12p_Params_1__list = new ObservableCollection<object>();
            for (ulong i = 0; i < GetEntryCount(typeof(W12p_Params_1_)); i++) {
                var item = W12p_Params_1_.LoadData(reader);
                item.Index = i;
                W12p_Params_1__list.Add(item);
            }
            var W12p_Params_1__container = new MhwStructDataContainer(W12p_Params_1__list, typeof(W12p_Params_1_));
            data.Add(W12p_Params_1__container);
            dataByType[typeof(W12p_Params_1_)] = W12p_Params_1__container;

            var Unk_Struct_1_list = new ObservableCollection<object>();
            for (ulong i = 0; i < GetEntryCount(typeof(Unk_Struct_1)); i++) {
                var item = Unk_Struct_1.LoadData(reader);
                item.Index = i;
                Unk_Struct_1_list.Add(item);
            }
            var Unk_Struct_1_container = new MhwStructDataContainer(Unk_Struct_1_list, typeof(Unk_Struct_1));
            data.Add(Unk_Struct_1_container);
            dataByType[typeof(Unk_Struct_1)] = Unk_Struct_1_container;

            var W12p_Params_2__list = new ObservableCollection<object>();
            for (ulong i = 0; i < GetEntryCount(typeof(W12p_Params_2_)); i++) {
                var item = W12p_Params_2_.LoadData(reader);
                item.Index = i;
                W12p_Params_2__list.Add(item);
            }
            var W12p_Params_2__container = new MhwStructDataContainer(W12p_Params_2__list, typeof(W12p_Params_2_));
            data.Add(W12p_Params_2__container);
            dataByType[typeof(W12p_Params_2_)] = W12p_Params_2__container;

            var Guard_Angles__list = new ObservableCollection<object>();
            for (ulong i = 0; i < GetEntryCount(typeof(Guard_Angles_)); i++) {
                var item = Guard_Angles_.LoadData(reader);
                item.Index = i;
                Guard_Angles__list.Add(item);
            }
            var Guard_Angles__container = new MhwStructDataContainer(Guard_Angles__list, typeof(Guard_Angles_));
            data.Add(Guard_Angles__container);
            dataByType[typeof(Guard_Angles_)] = Guard_Angles__container;

            var W12p_Params_3__list = new ObservableCollection<object>();
            for (ulong i = 0; i < GetEntryCount(typeof(W12p_Params_3_)); i++) {
                var item = W12p_Params_3_.LoadData(reader);
                item.Index = i;
                W12p_Params_3__list.Add(item);
            }
            var W12p_Params_3__container = new MhwStructDataContainer(W12p_Params_3__list, typeof(W12p_Params_3_));
            data.Add(W12p_Params_3__container);
            dataByType[typeof(W12p_Params_3_)] = W12p_Params_3__container;

            var Unk_Struct_2_list = new ObservableCollection<object>();
            for (ulong i = 0; i < GetEntryCount(typeof(Unk_Struct_2)); i++) {
                var item = Unk_Struct_2.LoadData(reader);
                item.Index = i;
                Unk_Struct_2_list.Add(item);
            }
            var Unk_Struct_2_container = new MhwStructDataContainer(Unk_Struct_2_list, typeof(Unk_Struct_2));
            data.Add(Unk_Struct_2_container);
            dataByType[typeof(Unk_Struct_2)] = Unk_Struct_2_container;

            var W12p_Params_4__list = new ObservableCollection<object>();
            for (ulong i = 0; i < GetEntryCount(typeof(W12p_Params_4_)); i++) {
                var item = W12p_Params_4_.LoadData(reader);
                item.Index = i;
                W12p_Params_4__list.Add(item);
            }
            var W12p_Params_4__container = new MhwStructDataContainer(W12p_Params_4__list, typeof(W12p_Params_4_));
            data.Add(W12p_Params_4__container);
            dataByType[typeof(W12p_Params_4_)] = W12p_Params_4__container;

            var Unk_Struct_3_list = new ObservableCollection<object>();
            for (ulong i = 0; i < GetEntryCount(typeof(Unk_Struct_3)); i++) {
                var item = Unk_Struct_3.LoadData(reader);
                item.Index = i;
                Unk_Struct_3_list.Add(item);
            }
            var Unk_Struct_3_container = new MhwStructDataContainer(Unk_Struct_3_list, typeof(Unk_Struct_3));
            data.Add(Unk_Struct_3_container);
            dataByType[typeof(Unk_Struct_3)] = Unk_Struct_3_container;

            var Unk_Struct_4_list = new ObservableCollection<object>();
            for (ulong i = 0; i < GetEntryCount(typeof(Unk_Struct_4)); i++) {
                var item = Unk_Struct_4.LoadData(reader);
                item.Index = i;
                Unk_Struct_4_list.Add(item);
            }
            var Unk_Struct_4_container = new MhwStructDataContainer(Unk_Struct_4_list, typeof(Unk_Struct_4));
            data.Add(Unk_Struct_4_container);
            dataByType[typeof(Unk_Struct_4)] = Unk_Struct_4_container;

            var W12p_Params_5__list = new ObservableCollection<object>();
            for (ulong i = 0; i < GetEntryCount(typeof(W12p_Params_5_)); i++) {
                var item = W12p_Params_5_.LoadData(reader);
                item.Index = i;
                W12p_Params_5__list.Add(item);
            }
            var W12p_Params_5__container = new MhwStructDataContainer(W12p_Params_5__list, typeof(W12p_Params_5_));
            data.Add(W12p_Params_5__container);
            dataByType[typeof(W12p_Params_5_)] = W12p_Params_5__container;

            var Number_of_Shield_Mods_Struct_list = new ObservableCollection<object>();
            for (ulong i = 0; i < GetEntryCount(typeof(Number_of_Shield_Mods_Struct)); i++) {
                var item = Number_of_Shield_Mods_Struct.LoadData(reader);
                item.Index = i;
                Number_of_Shield_Mods_Struct_list.Add(item);
            }
            var Number_of_Shield_Mods_Struct_container = new MhwStructDataContainer(Number_of_Shield_Mods_Struct_list, typeof(Number_of_Shield_Mods_Struct));
            data.Add(Number_of_Shield_Mods_Struct_container);
            dataByType[typeof(Number_of_Shield_Mods_Struct)] = Number_of_Shield_Mods_Struct_container;

            var Shield_Mods_list = new ObservableCollection<object>();
            for (ulong i = 0; i < GetEntryCount(typeof(Shield_Mods)); i++) {
                var item = Shield_Mods.LoadData(reader);
                item.Index = i;
                Shield_Mods_list.Add(item);
            }
            var Shield_Mods_container = new MhwStructDataContainer(Shield_Mods_list, typeof(Shield_Mods));
            data.Add(Shield_Mods_container);
            dataByType[typeof(Shield_Mods)] = Shield_Mods_container;

            var W12p_Params_6__list = new ObservableCollection<object>();
            for (ulong i = 0; i < GetEntryCount(typeof(W12p_Params_6_)); i++) {
                var item = W12p_Params_6_.LoadData(reader);
                item.Index = i;
                W12p_Params_6__list.Add(item);
            }
            var W12p_Params_6__container = new MhwStructDataContainer(W12p_Params_6__list, typeof(W12p_Params_6_));
            data.Add(W12p_Params_6__container);
            dataByType[typeof(W12p_Params_6_)] = W12p_Params_6__container;

            var Unk_Struct_5_list = new ObservableCollection<object>();
            for (ulong i = 0; i < GetEntryCount(typeof(Unk_Struct_5)); i++) {
                var item = Unk_Struct_5.LoadData(reader);
                item.Index = i;
                Unk_Struct_5_list.Add(item);
            }
            var Unk_Struct_5_container = new MhwStructDataContainer(Unk_Struct_5_list, typeof(Unk_Struct_5));
            data.Add(Unk_Struct_5_container);
            dataByType[typeof(Unk_Struct_5)] = Unk_Struct_5_container;

            var W12p_Params_7__list = new ObservableCollection<object>();
            for (ulong i = 0; i < GetEntryCount(typeof(W12p_Params_7_)); i++) {
                var item = W12p_Params_7_.LoadData(reader);
                item.Index = i;
                W12p_Params_7__list.Add(item);
            }
            var W12p_Params_7__container = new MhwStructDataContainer(W12p_Params_7__list, typeof(W12p_Params_7_));
            data.Add(W12p_Params_7__container);
            dataByType[typeof(W12p_Params_7_)] = W12p_Params_7__container;
        }
    }
}
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
    public partial class PlSkillParam {
        public override string EncryptionKey => "j1P15gEkgVa7NdFxiqwCPitykHctY2nZPjSaElvqb0eSwcLO1cOlTqqv";

        public partial class Header : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Header";

            protected char[] PLS_raw;
            public const string PLS_displayName = "PLS";
            public const int PLS_sortIndex = 50;
            [SortOrder(PLS_sortIndex)]
            [DisplayName(PLS_displayName)]
            [IsReadOnly]
            public virtual string PLS {
                get => (string) new string(PLS_raw);
                set {
                    if ((string) new string(PLS_raw) == value) return;
                    PLS_raw = (char[]) value.ToCharArray(0, 3);
                    ChangedItems.Add(nameof(PLS));
                    OnPropertyChanged(nameof(PLS));
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
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Header LoadData(BinaryReader reader, ulong i) {
                var data = new Header();
                data.Index = i;
                data.PLS_raw = reader.ReadChars(4);
                data.Magic_1_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(PLS_raw);
                writer.Write(Magic_1_raw);
            }
        }

        public partial class Skill_Params_1_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Skill Params (1)";

            protected float Speed_Eating_1_Drink_Motion_Speed_raw;
            public const string Speed_Eating_1_Drink_Motion_Speed_displayName = "Speed Eating 1 Drink Motion Speed";
            public const int Speed_Eating_1_Drink_Motion_Speed_sortIndex = 50;
            [SortOrder(Speed_Eating_1_Drink_Motion_Speed_sortIndex)]
            [DisplayName(Speed_Eating_1_Drink_Motion_Speed_displayName)]
            public virtual float Speed_Eating_1_Drink_Motion_Speed {
                get => Speed_Eating_1_Drink_Motion_Speed_raw;
                set {
                    if (Speed_Eating_1_Drink_Motion_Speed_raw == value) return;
                    Speed_Eating_1_Drink_Motion_Speed_raw = value;
                    ChangedItems.Add(nameof(Speed_Eating_1_Drink_Motion_Speed));
                    OnPropertyChanged(nameof(Speed_Eating_1_Drink_Motion_Speed));
                }
            }

            [DisplayName("Offset")]
            public long Speed_Eating_1_Drink_Motion_Speed_offset { get; private set; }

            protected float Speed_Eating_2_Drink_Motion_Speed_raw;
            public const string Speed_Eating_2_Drink_Motion_Speed_displayName = "Speed Eating 2 Drink Motion Speed";
            public const int Speed_Eating_2_Drink_Motion_Speed_sortIndex = 100;
            [SortOrder(Speed_Eating_2_Drink_Motion_Speed_sortIndex)]
            [DisplayName(Speed_Eating_2_Drink_Motion_Speed_displayName)]
            public virtual float Speed_Eating_2_Drink_Motion_Speed {
                get => Speed_Eating_2_Drink_Motion_Speed_raw;
                set {
                    if (Speed_Eating_2_Drink_Motion_Speed_raw == value) return;
                    Speed_Eating_2_Drink_Motion_Speed_raw = value;
                    ChangedItems.Add(nameof(Speed_Eating_2_Drink_Motion_Speed));
                    OnPropertyChanged(nameof(Speed_Eating_2_Drink_Motion_Speed));
                }
            }

            [DisplayName("Offset")]
            public long Speed_Eating_2_Drink_Motion_Speed_offset { get; private set; }

            protected float Speed_Eating_3_Drink_Motion_Speed_raw;
            public const string Speed_Eating_3_Drink_Motion_Speed_displayName = "Speed Eating 3 Drink Motion Speed";
            public const int Speed_Eating_3_Drink_Motion_Speed_sortIndex = 150;
            [SortOrder(Speed_Eating_3_Drink_Motion_Speed_sortIndex)]
            [DisplayName(Speed_Eating_3_Drink_Motion_Speed_displayName)]
            public virtual float Speed_Eating_3_Drink_Motion_Speed {
                get => Speed_Eating_3_Drink_Motion_Speed_raw;
                set {
                    if (Speed_Eating_3_Drink_Motion_Speed_raw == value) return;
                    Speed_Eating_3_Drink_Motion_Speed_raw = value;
                    ChangedItems.Add(nameof(Speed_Eating_3_Drink_Motion_Speed));
                    OnPropertyChanged(nameof(Speed_Eating_3_Drink_Motion_Speed));
                }
            }

            [DisplayName("Offset")]
            public long Speed_Eating_3_Drink_Motion_Speed_offset { get; private set; }

            protected float Speed_Eating_1_Drink_End_Frame_raw;
            public const string Speed_Eating_1_Drink_End_Frame_displayName = "Speed Eating 1 Drink End Frame";
            public const int Speed_Eating_1_Drink_End_Frame_sortIndex = 200;
            [SortOrder(Speed_Eating_1_Drink_End_Frame_sortIndex)]
            [DisplayName(Speed_Eating_1_Drink_End_Frame_displayName)]
            public virtual float Speed_Eating_1_Drink_End_Frame {
                get => Speed_Eating_1_Drink_End_Frame_raw;
                set {
                    if (Speed_Eating_1_Drink_End_Frame_raw == value) return;
                    Speed_Eating_1_Drink_End_Frame_raw = value;
                    ChangedItems.Add(nameof(Speed_Eating_1_Drink_End_Frame));
                    OnPropertyChanged(nameof(Speed_Eating_1_Drink_End_Frame));
                }
            }

            [DisplayName("Offset")]
            public long Speed_Eating_1_Drink_End_Frame_offset { get; private set; }

            protected float Speed_Eating_2_Drink_End_Frame_raw;
            public const string Speed_Eating_2_Drink_End_Frame_displayName = "Speed Eating 2 Drink End Frame";
            public const int Speed_Eating_2_Drink_End_Frame_sortIndex = 250;
            [SortOrder(Speed_Eating_2_Drink_End_Frame_sortIndex)]
            [DisplayName(Speed_Eating_2_Drink_End_Frame_displayName)]
            public virtual float Speed_Eating_2_Drink_End_Frame {
                get => Speed_Eating_2_Drink_End_Frame_raw;
                set {
                    if (Speed_Eating_2_Drink_End_Frame_raw == value) return;
                    Speed_Eating_2_Drink_End_Frame_raw = value;
                    ChangedItems.Add(nameof(Speed_Eating_2_Drink_End_Frame));
                    OnPropertyChanged(nameof(Speed_Eating_2_Drink_End_Frame));
                }
            }

            [DisplayName("Offset")]
            public long Speed_Eating_2_Drink_End_Frame_offset { get; private set; }

            protected float Speed_Eating_3_Drink_End_Frame_raw;
            public const string Speed_Eating_3_Drink_End_Frame_displayName = "Speed Eating 3 Drink End Frame";
            public const int Speed_Eating_3_Drink_End_Frame_sortIndex = 300;
            [SortOrder(Speed_Eating_3_Drink_End_Frame_sortIndex)]
            [DisplayName(Speed_Eating_3_Drink_End_Frame_displayName)]
            public virtual float Speed_Eating_3_Drink_End_Frame {
                get => Speed_Eating_3_Drink_End_Frame_raw;
                set {
                    if (Speed_Eating_3_Drink_End_Frame_raw == value) return;
                    Speed_Eating_3_Drink_End_Frame_raw = value;
                    ChangedItems.Add(nameof(Speed_Eating_3_Drink_End_Frame));
                    OnPropertyChanged(nameof(Speed_Eating_3_Drink_End_Frame));
                }
            }

            [DisplayName("Offset")]
            public long Speed_Eating_3_Drink_End_Frame_offset { get; private set; }

            protected float Speed_Eating_1_Heal_Speed_Rate_raw;
            public const string Speed_Eating_1_Heal_Speed_Rate_displayName = "Speed Eating 1 Heal Speed Rate";
            public const int Speed_Eating_1_Heal_Speed_Rate_sortIndex = 350;
            [SortOrder(Speed_Eating_1_Heal_Speed_Rate_sortIndex)]
            [DisplayName(Speed_Eating_1_Heal_Speed_Rate_displayName)]
            public virtual float Speed_Eating_1_Heal_Speed_Rate {
                get => Speed_Eating_1_Heal_Speed_Rate_raw;
                set {
                    if (Speed_Eating_1_Heal_Speed_Rate_raw == value) return;
                    Speed_Eating_1_Heal_Speed_Rate_raw = value;
                    ChangedItems.Add(nameof(Speed_Eating_1_Heal_Speed_Rate));
                    OnPropertyChanged(nameof(Speed_Eating_1_Heal_Speed_Rate));
                }
            }

            [DisplayName("Offset")]
            public long Speed_Eating_1_Heal_Speed_Rate_offset { get; private set; }

            protected float Speed_Eating_2_Heal_Speed_Rate_raw;
            public const string Speed_Eating_2_Heal_Speed_Rate_displayName = "Speed Eating 2 Heal Speed Rate";
            public const int Speed_Eating_2_Heal_Speed_Rate_sortIndex = 400;
            [SortOrder(Speed_Eating_2_Heal_Speed_Rate_sortIndex)]
            [DisplayName(Speed_Eating_2_Heal_Speed_Rate_displayName)]
            public virtual float Speed_Eating_2_Heal_Speed_Rate {
                get => Speed_Eating_2_Heal_Speed_Rate_raw;
                set {
                    if (Speed_Eating_2_Heal_Speed_Rate_raw == value) return;
                    Speed_Eating_2_Heal_Speed_Rate_raw = value;
                    ChangedItems.Add(nameof(Speed_Eating_2_Heal_Speed_Rate));
                    OnPropertyChanged(nameof(Speed_Eating_2_Heal_Speed_Rate));
                }
            }

            [DisplayName("Offset")]
            public long Speed_Eating_2_Heal_Speed_Rate_offset { get; private set; }

            protected float Speed_Eating_3_Heal_Speed_Rate_raw;
            public const string Speed_Eating_3_Heal_Speed_Rate_displayName = "Speed Eating 3 Heal Speed Rate";
            public const int Speed_Eating_3_Heal_Speed_Rate_sortIndex = 450;
            [SortOrder(Speed_Eating_3_Heal_Speed_Rate_sortIndex)]
            [DisplayName(Speed_Eating_3_Heal_Speed_Rate_displayName)]
            public virtual float Speed_Eating_3_Heal_Speed_Rate {
                get => Speed_Eating_3_Heal_Speed_Rate_raw;
                set {
                    if (Speed_Eating_3_Heal_Speed_Rate_raw == value) return;
                    Speed_Eating_3_Heal_Speed_Rate_raw = value;
                    ChangedItems.Add(nameof(Speed_Eating_3_Heal_Speed_Rate));
                    OnPropertyChanged(nameof(Speed_Eating_3_Heal_Speed_Rate));
                }
            }

            [DisplayName("Offset")]
            public long Speed_Eating_3_Heal_Speed_Rate_offset { get; private set; }

            protected float Speed_Eating_1_Meat_Motion_Speed_raw;
            public const string Speed_Eating_1_Meat_Motion_Speed_displayName = "Speed Eating 1 Meat Motion Speed";
            public const int Speed_Eating_1_Meat_Motion_Speed_sortIndex = 500;
            [SortOrder(Speed_Eating_1_Meat_Motion_Speed_sortIndex)]
            [DisplayName(Speed_Eating_1_Meat_Motion_Speed_displayName)]
            public virtual float Speed_Eating_1_Meat_Motion_Speed {
                get => Speed_Eating_1_Meat_Motion_Speed_raw;
                set {
                    if (Speed_Eating_1_Meat_Motion_Speed_raw == value) return;
                    Speed_Eating_1_Meat_Motion_Speed_raw = value;
                    ChangedItems.Add(nameof(Speed_Eating_1_Meat_Motion_Speed));
                    OnPropertyChanged(nameof(Speed_Eating_1_Meat_Motion_Speed));
                }
            }

            [DisplayName("Offset")]
            public long Speed_Eating_1_Meat_Motion_Speed_offset { get; private set; }

            protected float Speed_Eating_2_Meat_Motion_Speed_raw;
            public const string Speed_Eating_2_Meat_Motion_Speed_displayName = "Speed Eating 2 Meat Motion Speed";
            public const int Speed_Eating_2_Meat_Motion_Speed_sortIndex = 550;
            [SortOrder(Speed_Eating_2_Meat_Motion_Speed_sortIndex)]
            [DisplayName(Speed_Eating_2_Meat_Motion_Speed_displayName)]
            public virtual float Speed_Eating_2_Meat_Motion_Speed {
                get => Speed_Eating_2_Meat_Motion_Speed_raw;
                set {
                    if (Speed_Eating_2_Meat_Motion_Speed_raw == value) return;
                    Speed_Eating_2_Meat_Motion_Speed_raw = value;
                    ChangedItems.Add(nameof(Speed_Eating_2_Meat_Motion_Speed));
                    OnPropertyChanged(nameof(Speed_Eating_2_Meat_Motion_Speed));
                }
            }

            [DisplayName("Offset")]
            public long Speed_Eating_2_Meat_Motion_Speed_offset { get; private set; }

            protected float Speed_Eating_3_Meat_Motion_Speed_raw;
            public const string Speed_Eating_3_Meat_Motion_Speed_displayName = "Speed Eating 3 Meat Motion Speed";
            public const int Speed_Eating_3_Meat_Motion_Speed_sortIndex = 600;
            [SortOrder(Speed_Eating_3_Meat_Motion_Speed_sortIndex)]
            [DisplayName(Speed_Eating_3_Meat_Motion_Speed_displayName)]
            public virtual float Speed_Eating_3_Meat_Motion_Speed {
                get => Speed_Eating_3_Meat_Motion_Speed_raw;
                set {
                    if (Speed_Eating_3_Meat_Motion_Speed_raw == value) return;
                    Speed_Eating_3_Meat_Motion_Speed_raw = value;
                    ChangedItems.Add(nameof(Speed_Eating_3_Meat_Motion_Speed));
                    OnPropertyChanged(nameof(Speed_Eating_3_Meat_Motion_Speed));
                }
            }

            [DisplayName("Offset")]
            public long Speed_Eating_3_Meat_Motion_Speed_offset { get; private set; }

            protected byte Speed_Eating_1_Meat_Loop_Count_raw;
            public const string Speed_Eating_1_Meat_Loop_Count_displayName = "Speed Eating 1 Meat Loop Count";
            public const int Speed_Eating_1_Meat_Loop_Count_sortIndex = 650;
            [SortOrder(Speed_Eating_1_Meat_Loop_Count_sortIndex)]
            [DisplayName(Speed_Eating_1_Meat_Loop_Count_displayName)]
            public virtual byte Speed_Eating_1_Meat_Loop_Count {
                get => Speed_Eating_1_Meat_Loop_Count_raw;
                set {
                    if (Speed_Eating_1_Meat_Loop_Count_raw == value) return;
                    Speed_Eating_1_Meat_Loop_Count_raw = value;
                    ChangedItems.Add(nameof(Speed_Eating_1_Meat_Loop_Count));
                    OnPropertyChanged(nameof(Speed_Eating_1_Meat_Loop_Count));
                }
            }

            [DisplayName("Offset")]
            public long Speed_Eating_1_Meat_Loop_Count_offset { get; private set; }

            protected byte Speed_Eating_2_Meat_Loop_Count_raw;
            public const string Speed_Eating_2_Meat_Loop_Count_displayName = "Speed Eating 2 Meat Loop Count";
            public const int Speed_Eating_2_Meat_Loop_Count_sortIndex = 700;
            [SortOrder(Speed_Eating_2_Meat_Loop_Count_sortIndex)]
            [DisplayName(Speed_Eating_2_Meat_Loop_Count_displayName)]
            public virtual byte Speed_Eating_2_Meat_Loop_Count {
                get => Speed_Eating_2_Meat_Loop_Count_raw;
                set {
                    if (Speed_Eating_2_Meat_Loop_Count_raw == value) return;
                    Speed_Eating_2_Meat_Loop_Count_raw = value;
                    ChangedItems.Add(nameof(Speed_Eating_2_Meat_Loop_Count));
                    OnPropertyChanged(nameof(Speed_Eating_2_Meat_Loop_Count));
                }
            }

            [DisplayName("Offset")]
            public long Speed_Eating_2_Meat_Loop_Count_offset { get; private set; }

            protected byte Speed_Eating_3_Meat_Loop_Count_raw;
            public const string Speed_Eating_3_Meat_Loop_Count_displayName = "Speed Eating 3 Meat Loop Count";
            public const int Speed_Eating_3_Meat_Loop_Count_sortIndex = 750;
            [SortOrder(Speed_Eating_3_Meat_Loop_Count_sortIndex)]
            [DisplayName(Speed_Eating_3_Meat_Loop_Count_displayName)]
            public virtual byte Speed_Eating_3_Meat_Loop_Count {
                get => Speed_Eating_3_Meat_Loop_Count_raw;
                set {
                    if (Speed_Eating_3_Meat_Loop_Count_raw == value) return;
                    Speed_Eating_3_Meat_Loop_Count_raw = value;
                    ChangedItems.Add(nameof(Speed_Eating_3_Meat_Loop_Count));
                    OnPropertyChanged(nameof(Speed_Eating_3_Meat_Loop_Count));
                }
            }

            [DisplayName("Offset")]
            public long Speed_Eating_3_Meat_Loop_Count_offset { get; private set; }

            protected float Speed_Eating_1_2_3_Meat_End_Frame_raw;
            public const string Speed_Eating_1_2_3_Meat_End_Frame_displayName = "Speed Eating 1/2/3 Meat End Frame";
            public const int Speed_Eating_1_2_3_Meat_End_Frame_sortIndex = 800;
            [SortOrder(Speed_Eating_1_2_3_Meat_End_Frame_sortIndex)]
            [DisplayName(Speed_Eating_1_2_3_Meat_End_Frame_displayName)]
            public virtual float Speed_Eating_1_2_3_Meat_End_Frame {
                get => Speed_Eating_1_2_3_Meat_End_Frame_raw;
                set {
                    if (Speed_Eating_1_2_3_Meat_End_Frame_raw == value) return;
                    Speed_Eating_1_2_3_Meat_End_Frame_raw = value;
                    ChangedItems.Add(nameof(Speed_Eating_1_2_3_Meat_End_Frame));
                    OnPropertyChanged(nameof(Speed_Eating_1_2_3_Meat_End_Frame));
                }
            }

            [DisplayName("Offset")]
            public long Speed_Eating_1_2_3_Meat_End_Frame_offset { get; private set; }

            protected float Speed_Eating_1_Tablet_Motion_Speed_raw;
            public const string Speed_Eating_1_Tablet_Motion_Speed_displayName = "Speed Eating 1 Tablet Motion Speed";
            public const int Speed_Eating_1_Tablet_Motion_Speed_sortIndex = 850;
            [SortOrder(Speed_Eating_1_Tablet_Motion_Speed_sortIndex)]
            [DisplayName(Speed_Eating_1_Tablet_Motion_Speed_displayName)]
            public virtual float Speed_Eating_1_Tablet_Motion_Speed {
                get => Speed_Eating_1_Tablet_Motion_Speed_raw;
                set {
                    if (Speed_Eating_1_Tablet_Motion_Speed_raw == value) return;
                    Speed_Eating_1_Tablet_Motion_Speed_raw = value;
                    ChangedItems.Add(nameof(Speed_Eating_1_Tablet_Motion_Speed));
                    OnPropertyChanged(nameof(Speed_Eating_1_Tablet_Motion_Speed));
                }
            }

            [DisplayName("Offset")]
            public long Speed_Eating_1_Tablet_Motion_Speed_offset { get; private set; }

            protected float Speed_Eating_2_Tablet_Motion_Speed_raw;
            public const string Speed_Eating_2_Tablet_Motion_Speed_displayName = "Speed Eating 2 Tablet Motion Speed";
            public const int Speed_Eating_2_Tablet_Motion_Speed_sortIndex = 900;
            [SortOrder(Speed_Eating_2_Tablet_Motion_Speed_sortIndex)]
            [DisplayName(Speed_Eating_2_Tablet_Motion_Speed_displayName)]
            public virtual float Speed_Eating_2_Tablet_Motion_Speed {
                get => Speed_Eating_2_Tablet_Motion_Speed_raw;
                set {
                    if (Speed_Eating_2_Tablet_Motion_Speed_raw == value) return;
                    Speed_Eating_2_Tablet_Motion_Speed_raw = value;
                    ChangedItems.Add(nameof(Speed_Eating_2_Tablet_Motion_Speed));
                    OnPropertyChanged(nameof(Speed_Eating_2_Tablet_Motion_Speed));
                }
            }

            [DisplayName("Offset")]
            public long Speed_Eating_2_Tablet_Motion_Speed_offset { get; private set; }

            protected float Speed_Eating_3_Tablet_Motion_Speed_raw;
            public const string Speed_Eating_3_Tablet_Motion_Speed_displayName = "Speed Eating 3 Tablet Motion Speed";
            public const int Speed_Eating_3_Tablet_Motion_Speed_sortIndex = 950;
            [SortOrder(Speed_Eating_3_Tablet_Motion_Speed_sortIndex)]
            [DisplayName(Speed_Eating_3_Tablet_Motion_Speed_displayName)]
            public virtual float Speed_Eating_3_Tablet_Motion_Speed {
                get => Speed_Eating_3_Tablet_Motion_Speed_raw;
                set {
                    if (Speed_Eating_3_Tablet_Motion_Speed_raw == value) return;
                    Speed_Eating_3_Tablet_Motion_Speed_raw = value;
                    ChangedItems.Add(nameof(Speed_Eating_3_Tablet_Motion_Speed));
                    OnPropertyChanged(nameof(Speed_Eating_3_Tablet_Motion_Speed));
                }
            }

            [DisplayName("Offset")]
            public long Speed_Eating_3_Tablet_Motion_Speed_offset { get; private set; }

            protected float Mud_Motion_Speed_raw;
            public const string Mud_Motion_Speed_displayName = "Mud Motion Speed";
            public const int Mud_Motion_Speed_sortIndex = 1000;
            [SortOrder(Mud_Motion_Speed_sortIndex)]
            [DisplayName(Mud_Motion_Speed_displayName)]
            public virtual float Mud_Motion_Speed {
                get => Mud_Motion_Speed_raw;
                set {
                    if (Mud_Motion_Speed_raw == value) return;
                    Mud_Motion_Speed_raw = value;
                    ChangedItems.Add(nameof(Mud_Motion_Speed));
                    OnPropertyChanged(nameof(Mud_Motion_Speed));
                }
            }

            [DisplayName("Offset")]
            public long Mud_Motion_Speed_offset { get; private set; }

            protected float Mud_Trans_Rate_raw;
            public const string Mud_Trans_Rate_displayName = "Mud Trans Rate";
            public const int Mud_Trans_Rate_sortIndex = 1050;
            [SortOrder(Mud_Trans_Rate_sortIndex)]
            [DisplayName(Mud_Trans_Rate_displayName)]
            public virtual float Mud_Trans_Rate {
                get => Mud_Trans_Rate_raw;
                set {
                    if (Mud_Trans_Rate_raw == value) return;
                    Mud_Trans_Rate_raw = value;
                    ChangedItems.Add(nameof(Mud_Trans_Rate));
                    OnPropertyChanged(nameof(Mud_Trans_Rate));
                }
            }

            [DisplayName("Offset")]
            public long Mud_Trans_Rate_offset { get; private set; }

            protected byte Elemental_Damage_Defense__raw;
            public const string Elemental_Damage_Defense__displayName = "Elemental Damage Defense %";
            public const int Elemental_Damage_Defense__sortIndex = 1100;
            [SortOrder(Elemental_Damage_Defense__sortIndex)]
            [DisplayName(Elemental_Damage_Defense__displayName)]
            public virtual byte Elemental_Damage_Defense_ {
                get => Elemental_Damage_Defense__raw;
                set {
                    if (Elemental_Damage_Defense__raw == value) return;
                    Elemental_Damage_Defense__raw = value;
                    ChangedItems.Add(nameof(Elemental_Damage_Defense_));
                    OnPropertyChanged(nameof(Elemental_Damage_Defense_));
                }
            }

            [DisplayName("Offset")]
            public long Elemental_Damage_Defense__offset { get; private set; }

            protected byte Elemental_Damage_Resist__raw;
            public const string Elemental_Damage_Resist__displayName = "Elemental Damage Resist %";
            public const int Elemental_Damage_Resist__sortIndex = 1150;
            [SortOrder(Elemental_Damage_Resist__sortIndex)]
            [DisplayName(Elemental_Damage_Resist__displayName)]
            public virtual byte Elemental_Damage_Resist_ {
                get => Elemental_Damage_Resist__raw;
                set {
                    if (Elemental_Damage_Resist__raw == value) return;
                    Elemental_Damage_Resist__raw = value;
                    ChangedItems.Add(nameof(Elemental_Damage_Resist_));
                    OnPropertyChanged(nameof(Elemental_Damage_Resist_));
                }
            }

            [DisplayName("Offset")]
            public long Elemental_Damage_Resist__offset { get; private set; }

            protected byte Elemental_Damage_Resist_raw;
            public const string Elemental_Damage_Resist_displayName = "Elemental Damage Resist";
            public const int Elemental_Damage_Resist_sortIndex = 1200;
            [SortOrder(Elemental_Damage_Resist_sortIndex)]
            [DisplayName(Elemental_Damage_Resist_displayName)]
            public virtual byte Elemental_Damage_Resist {
                get => Elemental_Damage_Resist_raw;
                set {
                    if (Elemental_Damage_Resist_raw == value) return;
                    Elemental_Damage_Resist_raw = value;
                    ChangedItems.Add(nameof(Elemental_Damage_Resist));
                    OnPropertyChanged(nameof(Elemental_Damage_Resist));
                }
            }

            [DisplayName("Offset")]
            public long Elemental_Damage_Resist_offset { get; private set; }

            protected byte Weakness_Exploit_Hit_Zone_Threshold_raw;
            public const string Weakness_Exploit_Hit_Zone_Threshold_displayName = "Weakness Exploit Hit-Zone Threshold";
            public const int Weakness_Exploit_Hit_Zone_Threshold_sortIndex = 1250;
            [SortOrder(Weakness_Exploit_Hit_Zone_Threshold_sortIndex)]
            [DisplayName(Weakness_Exploit_Hit_Zone_Threshold_displayName)]
            public virtual byte Weakness_Exploit_Hit_Zone_Threshold {
                get => Weakness_Exploit_Hit_Zone_Threshold_raw;
                set {
                    if (Weakness_Exploit_Hit_Zone_Threshold_raw == value) return;
                    Weakness_Exploit_Hit_Zone_Threshold_raw = value;
                    ChangedItems.Add(nameof(Weakness_Exploit_Hit_Zone_Threshold));
                    OnPropertyChanged(nameof(Weakness_Exploit_Hit_Zone_Threshold));
                }
            }

            [DisplayName("Offset")]
            public long Weakness_Exploit_Hit_Zone_Threshold_offset { get; private set; }

            protected ushort Latent_Power_Activation_Time_raw;
            public const string Latent_Power_Activation_Time_displayName = "Latent Power Activation Time";
            public const int Latent_Power_Activation_Time_sortIndex = 1300;
            [SortOrder(Latent_Power_Activation_Time_sortIndex)]
            [DisplayName(Latent_Power_Activation_Time_displayName)]
            public virtual ushort Latent_Power_Activation_Time {
                get => Latent_Power_Activation_Time_raw;
                set {
                    if (Latent_Power_Activation_Time_raw == value) return;
                    Latent_Power_Activation_Time_raw = value;
                    ChangedItems.Add(nameof(Latent_Power_Activation_Time));
                    OnPropertyChanged(nameof(Latent_Power_Activation_Time));
                }
            }

            [DisplayName("Offset")]
            public long Latent_Power_Activation_Time_offset { get; private set; }

            protected ushort Latent_Power_Total_Damage_to_Trigger_raw;
            public const string Latent_Power_Total_Damage_to_Trigger_displayName = "Latent Power Total Damage to Trigger";
            public const int Latent_Power_Total_Damage_to_Trigger_sortIndex = 1350;
            [SortOrder(Latent_Power_Total_Damage_to_Trigger_sortIndex)]
            [DisplayName(Latent_Power_Total_Damage_to_Trigger_displayName)]
            public virtual ushort Latent_Power_Total_Damage_to_Trigger {
                get => Latent_Power_Total_Damage_to_Trigger_raw;
                set {
                    if (Latent_Power_Total_Damage_to_Trigger_raw == value) return;
                    Latent_Power_Total_Damage_to_Trigger_raw = value;
                    ChangedItems.Add(nameof(Latent_Power_Total_Damage_to_Trigger));
                    OnPropertyChanged(nameof(Latent_Power_Total_Damage_to_Trigger));
                }
            }

            [DisplayName("Offset")]
            public long Latent_Power_Total_Damage_to_Trigger_offset { get; private set; }

            protected ushort Latent_Power_Secret_Total_Damage_to_Trigger_raw;
            public const string Latent_Power_Secret_Total_Damage_to_Trigger_displayName = "Latent Power Secret Total Damage to Trigger";
            public const int Latent_Power_Secret_Total_Damage_to_Trigger_sortIndex = 1400;
            [SortOrder(Latent_Power_Secret_Total_Damage_to_Trigger_sortIndex)]
            [DisplayName(Latent_Power_Secret_Total_Damage_to_Trigger_displayName)]
            public virtual ushort Latent_Power_Secret_Total_Damage_to_Trigger {
                get => Latent_Power_Secret_Total_Damage_to_Trigger_raw;
                set {
                    if (Latent_Power_Secret_Total_Damage_to_Trigger_raw == value) return;
                    Latent_Power_Secret_Total_Damage_to_Trigger_raw = value;
                    ChangedItems.Add(nameof(Latent_Power_Secret_Total_Damage_to_Trigger));
                    OnPropertyChanged(nameof(Latent_Power_Secret_Total_Damage_to_Trigger));
                }
            }

            [DisplayName("Offset")]
            public long Latent_Power_Secret_Total_Damage_to_Trigger_offset { get; private set; }

            protected float Heroics_Activation_Health__raw;
            public const string Heroics_Activation_Health__displayName = "Heroics Activation Health %";
            public const int Heroics_Activation_Health__sortIndex = 1450;
            [SortOrder(Heroics_Activation_Health__sortIndex)]
            [DisplayName(Heroics_Activation_Health__displayName)]
            public virtual float Heroics_Activation_Health_ {
                get => Heroics_Activation_Health__raw;
                set {
                    if (Heroics_Activation_Health__raw == value) return;
                    Heroics_Activation_Health__raw = value;
                    ChangedItems.Add(nameof(Heroics_Activation_Health_));
                    OnPropertyChanged(nameof(Heroics_Activation_Health_));
                }
            }

            [DisplayName("Offset")]
            public long Heroics_Activation_Health__offset { get; private set; }

            protected byte Guts_Health_Threshold_raw;
            public const string Guts_Health_Threshold_displayName = "Guts Health Threshold";
            public const int Guts_Health_Threshold_sortIndex = 1500;
            [SortOrder(Guts_Health_Threshold_sortIndex)]
            [DisplayName(Guts_Health_Threshold_displayName)]
            public virtual byte Guts_Health_Threshold {
                get => Guts_Health_Threshold_raw;
                set {
                    if (Guts_Health_Threshold_raw == value) return;
                    Guts_Health_Threshold_raw = value;
                    ChangedItems.Add(nameof(Guts_Health_Threshold));
                    OnPropertyChanged(nameof(Guts_Health_Threshold));
                }
            }

            [DisplayName("Offset")]
            public long Guts_Health_Threshold_offset { get; private set; }

            public const int lastSortIndex = 1550;

            public static ObservableMhwStructCollection<Skill_Params_1_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Skill_Params_1_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Skill_Params_1_ LoadData(BinaryReader reader, ulong i) {
                var data = new Skill_Params_1_();
                data.Index = i;
                data.Speed_Eating_1_Drink_Motion_Speed_offset = reader.BaseStream.Position;
                data.Speed_Eating_1_Drink_Motion_Speed_raw = reader.ReadSingle();
                data.Speed_Eating_2_Drink_Motion_Speed_offset = reader.BaseStream.Position;
                data.Speed_Eating_2_Drink_Motion_Speed_raw = reader.ReadSingle();
                data.Speed_Eating_3_Drink_Motion_Speed_offset = reader.BaseStream.Position;
                data.Speed_Eating_3_Drink_Motion_Speed_raw = reader.ReadSingle();
                data.Speed_Eating_1_Drink_End_Frame_offset = reader.BaseStream.Position;
                data.Speed_Eating_1_Drink_End_Frame_raw = reader.ReadSingle();
                data.Speed_Eating_2_Drink_End_Frame_offset = reader.BaseStream.Position;
                data.Speed_Eating_2_Drink_End_Frame_raw = reader.ReadSingle();
                data.Speed_Eating_3_Drink_End_Frame_offset = reader.BaseStream.Position;
                data.Speed_Eating_3_Drink_End_Frame_raw = reader.ReadSingle();
                data.Speed_Eating_1_Heal_Speed_Rate_offset = reader.BaseStream.Position;
                data.Speed_Eating_1_Heal_Speed_Rate_raw = reader.ReadSingle();
                data.Speed_Eating_2_Heal_Speed_Rate_offset = reader.BaseStream.Position;
                data.Speed_Eating_2_Heal_Speed_Rate_raw = reader.ReadSingle();
                data.Speed_Eating_3_Heal_Speed_Rate_offset = reader.BaseStream.Position;
                data.Speed_Eating_3_Heal_Speed_Rate_raw = reader.ReadSingle();
                data.Speed_Eating_1_Meat_Motion_Speed_offset = reader.BaseStream.Position;
                data.Speed_Eating_1_Meat_Motion_Speed_raw = reader.ReadSingle();
                data.Speed_Eating_2_Meat_Motion_Speed_offset = reader.BaseStream.Position;
                data.Speed_Eating_2_Meat_Motion_Speed_raw = reader.ReadSingle();
                data.Speed_Eating_3_Meat_Motion_Speed_offset = reader.BaseStream.Position;
                data.Speed_Eating_3_Meat_Motion_Speed_raw = reader.ReadSingle();
                data.Speed_Eating_1_Meat_Loop_Count_offset = reader.BaseStream.Position;
                data.Speed_Eating_1_Meat_Loop_Count_raw = reader.ReadByte();
                data.Speed_Eating_2_Meat_Loop_Count_offset = reader.BaseStream.Position;
                data.Speed_Eating_2_Meat_Loop_Count_raw = reader.ReadByte();
                data.Speed_Eating_3_Meat_Loop_Count_offset = reader.BaseStream.Position;
                data.Speed_Eating_3_Meat_Loop_Count_raw = reader.ReadByte();
                data.Speed_Eating_1_2_3_Meat_End_Frame_offset = reader.BaseStream.Position;
                data.Speed_Eating_1_2_3_Meat_End_Frame_raw = reader.ReadSingle();
                data.Speed_Eating_1_Tablet_Motion_Speed_offset = reader.BaseStream.Position;
                data.Speed_Eating_1_Tablet_Motion_Speed_raw = reader.ReadSingle();
                data.Speed_Eating_2_Tablet_Motion_Speed_offset = reader.BaseStream.Position;
                data.Speed_Eating_2_Tablet_Motion_Speed_raw = reader.ReadSingle();
                data.Speed_Eating_3_Tablet_Motion_Speed_offset = reader.BaseStream.Position;
                data.Speed_Eating_3_Tablet_Motion_Speed_raw = reader.ReadSingle();
                data.Mud_Motion_Speed_offset = reader.BaseStream.Position;
                data.Mud_Motion_Speed_raw = reader.ReadSingle();
                data.Mud_Trans_Rate_offset = reader.BaseStream.Position;
                data.Mud_Trans_Rate_raw = reader.ReadSingle();
                data.Elemental_Damage_Defense__offset = reader.BaseStream.Position;
                data.Elemental_Damage_Defense__raw = reader.ReadByte();
                data.Elemental_Damage_Resist__offset = reader.BaseStream.Position;
                data.Elemental_Damage_Resist__raw = reader.ReadByte();
                data.Elemental_Damage_Resist_offset = reader.BaseStream.Position;
                data.Elemental_Damage_Resist_raw = reader.ReadByte();
                data.Weakness_Exploit_Hit_Zone_Threshold_offset = reader.BaseStream.Position;
                data.Weakness_Exploit_Hit_Zone_Threshold_raw = reader.ReadByte();
                data.Latent_Power_Activation_Time_offset = reader.BaseStream.Position;
                data.Latent_Power_Activation_Time_raw = reader.ReadUInt16();
                data.Latent_Power_Total_Damage_to_Trigger_offset = reader.BaseStream.Position;
                data.Latent_Power_Total_Damage_to_Trigger_raw = reader.ReadUInt16();
                data.Latent_Power_Secret_Total_Damage_to_Trigger_offset = reader.BaseStream.Position;
                data.Latent_Power_Secret_Total_Damage_to_Trigger_raw = reader.ReadUInt16();
                data.Heroics_Activation_Health__offset = reader.BaseStream.Position;
                data.Heroics_Activation_Health__raw = reader.ReadSingle();
                data.Guts_Health_Threshold_offset = reader.BaseStream.Position;
                data.Guts_Health_Threshold_raw = reader.ReadByte();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Speed_Eating_1_Drink_Motion_Speed_raw);
                writer.Write(Speed_Eating_2_Drink_Motion_Speed_raw);
                writer.Write(Speed_Eating_3_Drink_Motion_Speed_raw);
                writer.Write(Speed_Eating_1_Drink_End_Frame_raw);
                writer.Write(Speed_Eating_2_Drink_End_Frame_raw);
                writer.Write(Speed_Eating_3_Drink_End_Frame_raw);
                writer.Write(Speed_Eating_1_Heal_Speed_Rate_raw);
                writer.Write(Speed_Eating_2_Heal_Speed_Rate_raw);
                writer.Write(Speed_Eating_3_Heal_Speed_Rate_raw);
                writer.Write(Speed_Eating_1_Meat_Motion_Speed_raw);
                writer.Write(Speed_Eating_2_Meat_Motion_Speed_raw);
                writer.Write(Speed_Eating_3_Meat_Motion_Speed_raw);
                writer.Write(Speed_Eating_1_Meat_Loop_Count_raw);
                writer.Write(Speed_Eating_2_Meat_Loop_Count_raw);
                writer.Write(Speed_Eating_3_Meat_Loop_Count_raw);
                writer.Write(Speed_Eating_1_2_3_Meat_End_Frame_raw);
                writer.Write(Speed_Eating_1_Tablet_Motion_Speed_raw);
                writer.Write(Speed_Eating_2_Tablet_Motion_Speed_raw);
                writer.Write(Speed_Eating_3_Tablet_Motion_Speed_raw);
                writer.Write(Mud_Motion_Speed_raw);
                writer.Write(Mud_Trans_Rate_raw);
                writer.Write(Elemental_Damage_Defense__raw);
                writer.Write(Elemental_Damage_Resist__raw);
                writer.Write(Elemental_Damage_Resist_raw);
                writer.Write(Weakness_Exploit_Hit_Zone_Threshold_raw);
                writer.Write(Latent_Power_Activation_Time_raw);
                writer.Write(Latent_Power_Total_Damage_to_Trigger_raw);
                writer.Write(Latent_Power_Secret_Total_Damage_to_Trigger_raw);
                writer.Write(Heroics_Activation_Health__raw);
                writer.Write(Guts_Health_Threshold_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Speed Eating 1 Drink Motion Speed", "Speed_Eating_1_Drink_Motion_Speed", "Speed_Eating_1_Drink_Motion_Speed_offset"),
                    new MultiStructItemCustomView(this, "Speed Eating 2 Drink Motion Speed", "Speed_Eating_2_Drink_Motion_Speed", "Speed_Eating_2_Drink_Motion_Speed_offset"),
                    new MultiStructItemCustomView(this, "Speed Eating 3 Drink Motion Speed", "Speed_Eating_3_Drink_Motion_Speed", "Speed_Eating_3_Drink_Motion_Speed_offset"),
                    new MultiStructItemCustomView(this, "Speed Eating 1 Drink End Frame", "Speed_Eating_1_Drink_End_Frame", "Speed_Eating_1_Drink_End_Frame_offset"),
                    new MultiStructItemCustomView(this, "Speed Eating 2 Drink End Frame", "Speed_Eating_2_Drink_End_Frame", "Speed_Eating_2_Drink_End_Frame_offset"),
                    new MultiStructItemCustomView(this, "Speed Eating 3 Drink End Frame", "Speed_Eating_3_Drink_End_Frame", "Speed_Eating_3_Drink_End_Frame_offset"),
                    new MultiStructItemCustomView(this, "Speed Eating 1 Heal Speed Rate", "Speed_Eating_1_Heal_Speed_Rate", "Speed_Eating_1_Heal_Speed_Rate_offset"),
                    new MultiStructItemCustomView(this, "Speed Eating 2 Heal Speed Rate", "Speed_Eating_2_Heal_Speed_Rate", "Speed_Eating_2_Heal_Speed_Rate_offset"),
                    new MultiStructItemCustomView(this, "Speed Eating 3 Heal Speed Rate", "Speed_Eating_3_Heal_Speed_Rate", "Speed_Eating_3_Heal_Speed_Rate_offset"),
                    new MultiStructItemCustomView(this, "Speed Eating 1 Meat Motion Speed", "Speed_Eating_1_Meat_Motion_Speed", "Speed_Eating_1_Meat_Motion_Speed_offset"),
                    new MultiStructItemCustomView(this, "Speed Eating 2 Meat Motion Speed", "Speed_Eating_2_Meat_Motion_Speed", "Speed_Eating_2_Meat_Motion_Speed_offset"),
                    new MultiStructItemCustomView(this, "Speed Eating 3 Meat Motion Speed", "Speed_Eating_3_Meat_Motion_Speed", "Speed_Eating_3_Meat_Motion_Speed_offset"),
                    new MultiStructItemCustomView(this, "Speed Eating 1 Meat Loop Count", "Speed_Eating_1_Meat_Loop_Count", "Speed_Eating_1_Meat_Loop_Count_offset"),
                    new MultiStructItemCustomView(this, "Speed Eating 2 Meat Loop Count", "Speed_Eating_2_Meat_Loop_Count", "Speed_Eating_2_Meat_Loop_Count_offset"),
                    new MultiStructItemCustomView(this, "Speed Eating 3 Meat Loop Count", "Speed_Eating_3_Meat_Loop_Count", "Speed_Eating_3_Meat_Loop_Count_offset"),
                    new MultiStructItemCustomView(this, "Speed Eating 1/2/3 Meat End Frame", "Speed_Eating_1_2_3_Meat_End_Frame", "Speed_Eating_1_2_3_Meat_End_Frame_offset"),
                    new MultiStructItemCustomView(this, "Speed Eating 1 Tablet Motion Speed", "Speed_Eating_1_Tablet_Motion_Speed", "Speed_Eating_1_Tablet_Motion_Speed_offset"),
                    new MultiStructItemCustomView(this, "Speed Eating 2 Tablet Motion Speed", "Speed_Eating_2_Tablet_Motion_Speed", "Speed_Eating_2_Tablet_Motion_Speed_offset"),
                    new MultiStructItemCustomView(this, "Speed Eating 3 Tablet Motion Speed", "Speed_Eating_3_Tablet_Motion_Speed", "Speed_Eating_3_Tablet_Motion_Speed_offset"),
                    new MultiStructItemCustomView(this, "Mud Motion Speed", "Mud_Motion_Speed", "Mud_Motion_Speed_offset"),
                    new MultiStructItemCustomView(this, "Mud Trans Rate", "Mud_Trans_Rate", "Mud_Trans_Rate_offset"),
                    new MultiStructItemCustomView(this, "Elemental Damage Defense %", "Elemental_Damage_Defense_", "Elemental_Damage_Defense__offset"),
                    new MultiStructItemCustomView(this, "Elemental Damage Resist %", "Elemental_Damage_Resist_", "Elemental_Damage_Resist__offset"),
                    new MultiStructItemCustomView(this, "Elemental Damage Resist", "Elemental_Damage_Resist", "Elemental_Damage_Resist_offset"),
                    new MultiStructItemCustomView(this, "Weakness Exploit Hit-Zone Threshold", "Weakness_Exploit_Hit_Zone_Threshold", "Weakness_Exploit_Hit_Zone_Threshold_offset"),
                    new MultiStructItemCustomView(this, "Latent Power Activation Time", "Latent_Power_Activation_Time", "Latent_Power_Activation_Time_offset"),
                    new MultiStructItemCustomView(this, "Latent Power Total Damage to Trigger", "Latent_Power_Total_Damage_to_Trigger", "Latent_Power_Total_Damage_to_Trigger_offset"),
                    new MultiStructItemCustomView(this, "Latent Power Secret Total Damage to Trigger", "Latent_Power_Secret_Total_Damage_to_Trigger", "Latent_Power_Secret_Total_Damage_to_Trigger_offset"),
                    new MultiStructItemCustomView(this, "Heroics Activation Health %", "Heroics_Activation_Health_", "Heroics_Activation_Health__offset"),
                    new MultiStructItemCustomView(this, "Guts Health Threshold", "Guts_Health_Threshold", "Guts_Health_Threshold_offset"),
                };
            }
        }

        public partial class Wide_Range : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 2;
            public const string GridName = "Wide Range";

            protected float Level_1_raw;
            public const string Level_1_displayName = "Level 1";
            public const int Level_1_sortIndex = 50;
            [SortOrder(Level_1_sortIndex)]
            [DisplayName(Level_1_displayName)]
            public virtual float Level_1 {
                get => Level_1_raw;
                set {
                    if (Level_1_raw == value) return;
                    Level_1_raw = value;
                    ChangedItems.Add(nameof(Level_1));
                    OnPropertyChanged(nameof(Level_1));
                }
            }

            protected float Level_2_raw;
            public const string Level_2_displayName = "Level 2";
            public const int Level_2_sortIndex = 100;
            [SortOrder(Level_2_sortIndex)]
            [DisplayName(Level_2_displayName)]
            public virtual float Level_2 {
                get => Level_2_raw;
                set {
                    if (Level_2_raw == value) return;
                    Level_2_raw = value;
                    ChangedItems.Add(nameof(Level_2));
                    OnPropertyChanged(nameof(Level_2));
                }
            }

            protected float Level_3_raw;
            public const string Level_3_displayName = "Level 3";
            public const int Level_3_sortIndex = 150;
            [SortOrder(Level_3_sortIndex)]
            [DisplayName(Level_3_displayName)]
            public virtual float Level_3 {
                get => Level_3_raw;
                set {
                    if (Level_3_raw == value) return;
                    Level_3_raw = value;
                    ChangedItems.Add(nameof(Level_3));
                    OnPropertyChanged(nameof(Level_3));
                }
            }

            protected float Level_4_raw;
            public const string Level_4_displayName = "Level 4";
            public const int Level_4_sortIndex = 200;
            [SortOrder(Level_4_sortIndex)]
            [DisplayName(Level_4_displayName)]
            public virtual float Level_4 {
                get => Level_4_raw;
                set {
                    if (Level_4_raw == value) return;
                    Level_4_raw = value;
                    ChangedItems.Add(nameof(Level_4));
                    OnPropertyChanged(nameof(Level_4));
                }
            }

            protected float Level_5_raw;
            public const string Level_5_displayName = "Level 5";
            public const int Level_5_sortIndex = 250;
            [SortOrder(Level_5_sortIndex)]
            [DisplayName(Level_5_displayName)]
            public virtual float Level_5 {
                get => Level_5_raw;
                set {
                    if (Level_5_raw == value) return;
                    Level_5_raw = value;
                    ChangedItems.Add(nameof(Level_5));
                    OnPropertyChanged(nameof(Level_5));
                }
            }

            public const int lastSortIndex = 300;

            public static ObservableMhwStructCollection<Wide_Range> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Wide_Range>();
                const ulong count = 2UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Wide_Range LoadData(BinaryReader reader, ulong i) {
                var data = new Wide_Range();
                data.Index = i;
                data.Level_1_raw = reader.ReadSingle();
                data.Level_2_raw = reader.ReadSingle();
                data.Level_3_raw = reader.ReadSingle();
                data.Level_4_raw = reader.ReadSingle();
                data.Level_5_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Level_1_raw);
                writer.Write(Level_2_raw);
                writer.Write(Level_3_raw);
                writer.Write(Level_4_raw);
                writer.Write(Level_5_raw);
            }
        }

        public partial class Skill_Params_2_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Skill Params (2)";

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
                    ChangedItems.Add(nameof(Unk1));
                    OnPropertyChanged(nameof(Unk1));
                }
            }

            [DisplayName("Offset")]
            public long Unk1_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk2));
                    OnPropertyChanged(nameof(Unk2));
                }
            }

            [DisplayName("Offset")]
            public long Unk2_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk3));
                    OnPropertyChanged(nameof(Unk3));
                }
            }

            [DisplayName("Offset")]
            public long Unk3_offset { get; private set; }

            protected float Master_Mounter_Mount_Multiplier_raw;
            public const string Master_Mounter_Mount_Multiplier_displayName = "Master Mounter: Mount Multiplier";
            public const int Master_Mounter_Mount_Multiplier_sortIndex = 200;
            [SortOrder(Master_Mounter_Mount_Multiplier_sortIndex)]
            [DisplayName(Master_Mounter_Mount_Multiplier_displayName)]
            public virtual float Master_Mounter_Mount_Multiplier {
                get => Master_Mounter_Mount_Multiplier_raw;
                set {
                    if (Master_Mounter_Mount_Multiplier_raw == value) return;
                    Master_Mounter_Mount_Multiplier_raw = value;
                    ChangedItems.Add(nameof(Master_Mounter_Mount_Multiplier));
                    OnPropertyChanged(nameof(Master_Mounter_Mount_Multiplier));
                }
            }

            [DisplayName("Offset")]
            public long Master_Mounter_Mount_Multiplier_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk5));
                    OnPropertyChanged(nameof(Unk5));
                }
            }

            [DisplayName("Offset")]
            public long Unk5_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk6));
                    OnPropertyChanged(nameof(Unk6));
                }
            }

            [DisplayName("Offset")]
            public long Unk6_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk7));
                    OnPropertyChanged(nameof(Unk7));
                }
            }

            [DisplayName("Offset")]
            public long Unk7_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk8));
                    OnPropertyChanged(nameof(Unk8));
                }
            }

            [DisplayName("Offset")]
            public long Unk8_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk9));
                    OnPropertyChanged(nameof(Unk9));
                }
            }

            [DisplayName("Offset")]
            public long Unk9_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk10));
                    OnPropertyChanged(nameof(Unk10));
                }
            }

            [DisplayName("Offset")]
            public long Unk10_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk11));
                    OnPropertyChanged(nameof(Unk11));
                }
            }

            [DisplayName("Offset")]
            public long Unk11_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk12));
                    OnPropertyChanged(nameof(Unk12));
                }
            }

            [DisplayName("Offset")]
            public long Unk12_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk13));
                    OnPropertyChanged(nameof(Unk13));
                }
            }

            [DisplayName("Offset")]
            public long Unk13_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk14));
                    OnPropertyChanged(nameof(Unk14));
                }
            }

            [DisplayName("Offset")]
            public long Unk14_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk15));
                    OnPropertyChanged(nameof(Unk15));
                }
            }

            [DisplayName("Offset")]
            public long Unk15_offset { get; private set; }

            protected float Unk16_raw;
            public const string Unk16_displayName = "Unk16";
            public const int Unk16_sortIndex = 800;
            [SortOrder(Unk16_sortIndex)]
            [DisplayName(Unk16_displayName)]
            public virtual float Unk16 {
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
                    ChangedItems.Add(nameof(Unk17));
                    OnPropertyChanged(nameof(Unk17));
                }
            }

            [DisplayName("Offset")]
            public long Unk17_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk18));
                    OnPropertyChanged(nameof(Unk18));
                }
            }

            [DisplayName("Offset")]
            public long Unk18_offset { get; private set; }

            public const int lastSortIndex = 950;

            public static ObservableMhwStructCollection<Skill_Params_2_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Skill_Params_2_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Skill_Params_2_ LoadData(BinaryReader reader, ulong i) {
                var data = new Skill_Params_2_();
                data.Index = i;
                data.Unk1_offset = reader.BaseStream.Position;
                data.Unk1_raw = reader.ReadSingle();
                data.Unk2_offset = reader.BaseStream.Position;
                data.Unk2_raw = reader.ReadSingle();
                data.Unk3_offset = reader.BaseStream.Position;
                data.Unk3_raw = reader.ReadSingle();
                data.Master_Mounter_Mount_Multiplier_offset = reader.BaseStream.Position;
                data.Master_Mounter_Mount_Multiplier_raw = reader.ReadSingle();
                data.Unk5_offset = reader.BaseStream.Position;
                data.Unk5_raw = reader.ReadSingle();
                data.Unk6_offset = reader.BaseStream.Position;
                data.Unk6_raw = reader.ReadSingle();
                data.Unk7_offset = reader.BaseStream.Position;
                data.Unk7_raw = reader.ReadSingle();
                data.Unk8_offset = reader.BaseStream.Position;
                data.Unk8_raw = reader.ReadSingle();
                data.Unk9_offset = reader.BaseStream.Position;
                data.Unk9_raw = reader.ReadSingle();
                data.Unk10_offset = reader.BaseStream.Position;
                data.Unk10_raw = reader.ReadSingle();
                data.Unk11_offset = reader.BaseStream.Position;
                data.Unk11_raw = reader.ReadSingle();
                data.Unk12_offset = reader.BaseStream.Position;
                data.Unk12_raw = reader.ReadSingle();
                data.Unk13_offset = reader.BaseStream.Position;
                data.Unk13_raw = reader.ReadSingle();
                data.Unk14_offset = reader.BaseStream.Position;
                data.Unk14_raw = reader.ReadSingle();
                data.Unk15_offset = reader.BaseStream.Position;
                data.Unk15_raw = reader.ReadSingle();
                data.Unk16_offset = reader.BaseStream.Position;
                data.Unk16_raw = reader.ReadSingle();
                data.Unk17_offset = reader.BaseStream.Position;
                data.Unk17_raw = reader.ReadSingle();
                data.Unk18_offset = reader.BaseStream.Position;
                data.Unk18_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk1_raw);
                writer.Write(Unk2_raw);
                writer.Write(Unk3_raw);
                writer.Write(Master_Mounter_Mount_Multiplier_raw);
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
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Unk1", "Unk1", "Unk1_offset"),
                    new MultiStructItemCustomView(this, "Unk2", "Unk2", "Unk2_offset"),
                    new MultiStructItemCustomView(this, "Unk3", "Unk3", "Unk3_offset"),
                    new MultiStructItemCustomView(this, "Master Mounter: Mount Multiplier", "Master_Mounter_Mount_Multiplier", "Master_Mounter_Mount_Multiplier_offset"),
                    new MultiStructItemCustomView(this, "Unk5", "Unk5", "Unk5_offset"),
                    new MultiStructItemCustomView(this, "Unk6", "Unk6", "Unk6_offset"),
                    new MultiStructItemCustomView(this, "Unk7", "Unk7", "Unk7_offset"),
                    new MultiStructItemCustomView(this, "Unk8", "Unk8", "Unk8_offset"),
                    new MultiStructItemCustomView(this, "Unk9", "Unk9", "Unk9_offset"),
                    new MultiStructItemCustomView(this, "Unk10", "Unk10", "Unk10_offset"),
                    new MultiStructItemCustomView(this, "Unk11", "Unk11", "Unk11_offset"),
                    new MultiStructItemCustomView(this, "Unk12", "Unk12", "Unk12_offset"),
                    new MultiStructItemCustomView(this, "Unk13", "Unk13", "Unk13_offset"),
                    new MultiStructItemCustomView(this, "Unk14", "Unk14", "Unk14_offset"),
                    new MultiStructItemCustomView(this, "Unk15", "Unk15", "Unk15_offset"),
                    new MultiStructItemCustomView(this, "Unk16", "Unk16", "Unk16_offset"),
                    new MultiStructItemCustomView(this, "Unk17", "Unk17", "Unk17_offset"),
                    new MultiStructItemCustomView(this, "Unk18", "Unk18", "Unk18_offset"),
                };
            }
        }

        public partial class Focus : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 3;
            public const string GridName = "Focus";

            protected float Time_Rate_1_raw;
            public const string Time_Rate_1_displayName = "Time Rate 1";
            public const int Time_Rate_1_sortIndex = 50;
            [SortOrder(Time_Rate_1_sortIndex)]
            [DisplayName(Time_Rate_1_displayName)]
            public virtual float Time_Rate_1 {
                get => Time_Rate_1_raw;
                set {
                    if (Time_Rate_1_raw == value) return;
                    Time_Rate_1_raw = value;
                    ChangedItems.Add(nameof(Time_Rate_1));
                    OnPropertyChanged(nameof(Time_Rate_1));
                }
            }

            protected float Time_Rate_2_raw;
            public const string Time_Rate_2_displayName = "Time Rate 2";
            public const int Time_Rate_2_sortIndex = 100;
            [SortOrder(Time_Rate_2_sortIndex)]
            [DisplayName(Time_Rate_2_displayName)]
            public virtual float Time_Rate_2 {
                get => Time_Rate_2_raw;
                set {
                    if (Time_Rate_2_raw == value) return;
                    Time_Rate_2_raw = value;
                    ChangedItems.Add(nameof(Time_Rate_2));
                    OnPropertyChanged(nameof(Time_Rate_2));
                }
            }

            protected float Time_Rate_3_raw;
            public const string Time_Rate_3_displayName = "Time Rate 3";
            public const int Time_Rate_3_sortIndex = 150;
            [SortOrder(Time_Rate_3_sortIndex)]
            [DisplayName(Time_Rate_3_displayName)]
            public virtual float Time_Rate_3 {
                get => Time_Rate_3_raw;
                set {
                    if (Time_Rate_3_raw == value) return;
                    Time_Rate_3_raw = value;
                    ChangedItems.Add(nameof(Time_Rate_3));
                    OnPropertyChanged(nameof(Time_Rate_3));
                }
            }

            public const int lastSortIndex = 200;

            public static ObservableMhwStructCollection<Focus> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Focus>();
                const ulong count = 3UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Focus LoadData(BinaryReader reader, ulong i) {
                var data = new Focus();
                data.Index = i;
                data.Time_Rate_1_raw = reader.ReadSingle();
                data.Time_Rate_2_raw = reader.ReadSingle();
                data.Time_Rate_3_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Time_Rate_1_raw);
                writer.Write(Time_Rate_2_raw);
                writer.Write(Time_Rate_3_raw);
            }
        }

        public partial class Punishing_Draw : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 14;
            public const string GridName = "Punishing Draw";

            protected ushort Attack_Power_raw;
            public const string Attack_Power_displayName = "Attack Power";
            public const int Attack_Power_sortIndex = 50;
            [SortOrder(Attack_Power_sortIndex)]
            [DisplayName(Attack_Power_displayName)]
            public virtual ushort Attack_Power {
                get => Attack_Power_raw;
                set {
                    if (Attack_Power_raw == value) return;
                    Attack_Power_raw = value;
                    ChangedItems.Add(nameof(Attack_Power));
                    OnPropertyChanged(nameof(Attack_Power));
                }
            }

            protected ushort Stun_raw;
            public const string Stun_displayName = "Stun";
            public const int Stun_sortIndex = 100;
            [SortOrder(Stun_sortIndex)]
            [DisplayName(Stun_displayName)]
            public virtual ushort Stun {
                get => Stun_raw;
                set {
                    if (Stun_raw == value) return;
                    Stun_raw = value;
                    ChangedItems.Add(nameof(Stun));
                    OnPropertyChanged(nameof(Stun));
                }
            }

            protected ushort Exhaust_raw;
            public const string Exhaust_displayName = "Exhaust";
            public const int Exhaust_sortIndex = 150;
            [SortOrder(Exhaust_sortIndex)]
            [DisplayName(Exhaust_displayName)]
            public virtual ushort Exhaust {
                get => Exhaust_raw;
                set {
                    if (Exhaust_raw == value) return;
                    Exhaust_raw = value;
                    ChangedItems.Add(nameof(Exhaust));
                    OnPropertyChanged(nameof(Exhaust));
                }
            }

            protected ushort Param_4_raw;
            public const string Param_4_displayName = "Param 4";
            public const int Param_4_sortIndex = 200;
            [SortOrder(Param_4_sortIndex)]
            [DisplayName(Param_4_displayName)]
            public virtual ushort Param_4 {
                get => Param_4_raw;
                set {
                    if (Param_4_raw == value) return;
                    Param_4_raw = value;
                    ChangedItems.Add(nameof(Param_4));
                    OnPropertyChanged(nameof(Param_4));
                }
            }

            protected ushort Param_5_raw;
            public const string Param_5_displayName = "Param 5";
            public const int Param_5_sortIndex = 250;
            [SortOrder(Param_5_sortIndex)]
            [DisplayName(Param_5_displayName)]
            public virtual ushort Param_5 {
                get => Param_5_raw;
                set {
                    if (Param_5_raw == value) return;
                    Param_5_raw = value;
                    ChangedItems.Add(nameof(Param_5));
                    OnPropertyChanged(nameof(Param_5));
                }
            }

            protected ushort Param_6_raw;
            public const string Param_6_displayName = "Param 6";
            public const int Param_6_sortIndex = 300;
            [SortOrder(Param_6_sortIndex)]
            [DisplayName(Param_6_displayName)]
            public virtual ushort Param_6 {
                get => Param_6_raw;
                set {
                    if (Param_6_raw == value) return;
                    Param_6_raw = value;
                    ChangedItems.Add(nameof(Param_6));
                    OnPropertyChanged(nameof(Param_6));
                }
            }

            public const int lastSortIndex = 350;

            public static ObservableMhwStructCollection<Punishing_Draw> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Punishing_Draw>();
                const ulong count = 14UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Punishing_Draw LoadData(BinaryReader reader, ulong i) {
                var data = new Punishing_Draw();
                data.Index = i;
                data.Attack_Power_raw = reader.ReadUInt16();
                data.Stun_raw = reader.ReadUInt16();
                data.Exhaust_raw = reader.ReadUInt16();
                data.Param_4_raw = reader.ReadUInt16();
                data.Param_5_raw = reader.ReadUInt16();
                data.Param_6_raw = reader.ReadUInt16();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Attack_Power_raw);
                writer.Write(Stun_raw);
                writer.Write(Exhaust_raw);
                writer.Write(Param_4_raw);
                writer.Write(Param_5_raw);
                writer.Write(Param_6_raw);
            }
        }

        public partial class Razor_Sharp : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 2;
            public const string GridName = "Razor Sharp";

            protected byte Sharpness_No_Reduce__raw;
            public const string Sharpness_No_Reduce__displayName = "Sharpness No Reduce %";
            public const int Sharpness_No_Reduce__sortIndex = 50;
            [SortOrder(Sharpness_No_Reduce__sortIndex)]
            [DisplayName(Sharpness_No_Reduce__displayName)]
            public virtual byte Sharpness_No_Reduce_ {
                get => Sharpness_No_Reduce__raw;
                set {
                    if (Sharpness_No_Reduce__raw == value) return;
                    Sharpness_No_Reduce__raw = value;
                    ChangedItems.Add(nameof(Sharpness_No_Reduce_));
                    OnPropertyChanged(nameof(Sharpness_No_Reduce_));
                }
            }

            protected byte Gunlance_Shot_Sub_Value_raw;
            public const string Gunlance_Shot_Sub_Value_displayName = "Gunlance Shot Sub Value";
            public const int Gunlance_Shot_Sub_Value_sortIndex = 100;
            [SortOrder(Gunlance_Shot_Sub_Value_sortIndex)]
            [DisplayName(Gunlance_Shot_Sub_Value_displayName)]
            public virtual byte Gunlance_Shot_Sub_Value {
                get => Gunlance_Shot_Sub_Value_raw;
                set {
                    if (Gunlance_Shot_Sub_Value_raw == value) return;
                    Gunlance_Shot_Sub_Value_raw = value;
                    ChangedItems.Add(nameof(Gunlance_Shot_Sub_Value));
                    OnPropertyChanged(nameof(Gunlance_Shot_Sub_Value));
                }
            }

            protected byte Gunlance_Shot_No_Reduce__raw;
            public const string Gunlance_Shot_No_Reduce__displayName = "Gunlance Shot No Reduce %";
            public const int Gunlance_Shot_No_Reduce__sortIndex = 150;
            [SortOrder(Gunlance_Shot_No_Reduce__sortIndex)]
            [DisplayName(Gunlance_Shot_No_Reduce__displayName)]
            public virtual byte Gunlance_Shot_No_Reduce_ {
                get => Gunlance_Shot_No_Reduce__raw;
                set {
                    if (Gunlance_Shot_No_Reduce__raw == value) return;
                    Gunlance_Shot_No_Reduce__raw = value;
                    ChangedItems.Add(nameof(Gunlance_Shot_No_Reduce_));
                    OnPropertyChanged(nameof(Gunlance_Shot_No_Reduce_));
                }
            }

            protected byte Gun_Ammo_No_Reduce__raw;
            public const string Gun_Ammo_No_Reduce__displayName = "Gun Ammo No Reduce %";
            public const int Gun_Ammo_No_Reduce__sortIndex = 200;
            [SortOrder(Gun_Ammo_No_Reduce__sortIndex)]
            [DisplayName(Gun_Ammo_No_Reduce__displayName)]
            public virtual byte Gun_Ammo_No_Reduce_ {
                get => Gun_Ammo_No_Reduce__raw;
                set {
                    if (Gun_Ammo_No_Reduce__raw == value) return;
                    Gun_Ammo_No_Reduce__raw = value;
                    ChangedItems.Add(nameof(Gun_Ammo_No_Reduce_));
                    OnPropertyChanged(nameof(Gun_Ammo_No_Reduce_));
                }
            }

            protected byte Bow_Coating_No_Reduce__raw;
            public const string Bow_Coating_No_Reduce__displayName = "Bow Coating No Reduce %";
            public const int Bow_Coating_No_Reduce__sortIndex = 250;
            [SortOrder(Bow_Coating_No_Reduce__sortIndex)]
            [DisplayName(Bow_Coating_No_Reduce__displayName)]
            public virtual byte Bow_Coating_No_Reduce_ {
                get => Bow_Coating_No_Reduce__raw;
                set {
                    if (Bow_Coating_No_Reduce__raw == value) return;
                    Bow_Coating_No_Reduce__raw = value;
                    ChangedItems.Add(nameof(Bow_Coating_No_Reduce_));
                    OnPropertyChanged(nameof(Bow_Coating_No_Reduce_));
                }
            }

            protected byte Guard_Consumption__raw;
            public const string Guard_Consumption__displayName = "Guard Consumption %";
            public const int Guard_Consumption__sortIndex = 300;
            [SortOrder(Guard_Consumption__sortIndex)]
            [DisplayName(Guard_Consumption__displayName)]
            public virtual byte Guard_Consumption_ {
                get => Guard_Consumption__raw;
                set {
                    if (Guard_Consumption__raw == value) return;
                    Guard_Consumption__raw = value;
                    ChangedItems.Add(nameof(Guard_Consumption_));
                    OnPropertyChanged(nameof(Guard_Consumption_));
                }
            }

            public const int lastSortIndex = 350;

            public static ObservableMhwStructCollection<Razor_Sharp> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Razor_Sharp>();
                const ulong count = 2UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Razor_Sharp LoadData(BinaryReader reader, ulong i) {
                var data = new Razor_Sharp();
                data.Index = i;
                data.Sharpness_No_Reduce__raw = reader.ReadByte();
                data.Gunlance_Shot_Sub_Value_raw = reader.ReadByte();
                data.Gunlance_Shot_No_Reduce__raw = reader.ReadByte();
                data.Gun_Ammo_No_Reduce__raw = reader.ReadByte();
                data.Bow_Coating_No_Reduce__raw = reader.ReadByte();
                data.Guard_Consumption__raw = reader.ReadByte();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Sharpness_No_Reduce__raw);
                writer.Write(Gunlance_Shot_Sub_Value_raw);
                writer.Write(Gunlance_Shot_No_Reduce__raw);
                writer.Write(Gun_Ammo_No_Reduce__raw);
                writer.Write(Bow_Coating_No_Reduce__raw);
                writer.Write(Guard_Consumption__raw);
            }
        }

        public partial class Minds_Eye_Ballistics : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 2;
            public const string GridName = "Minds Eye / Ballistics";

            protected float Critical_Begin_Wide_Rate_raw;
            public const string Critical_Begin_Wide_Rate_displayName = "Critical Begin Wide Rate";
            public const int Critical_Begin_Wide_Rate_sortIndex = 50;
            [SortOrder(Critical_Begin_Wide_Rate_sortIndex)]
            [DisplayName(Critical_Begin_Wide_Rate_displayName)]
            public virtual float Critical_Begin_Wide_Rate {
                get => Critical_Begin_Wide_Rate_raw;
                set {
                    if (Critical_Begin_Wide_Rate_raw == value) return;
                    Critical_Begin_Wide_Rate_raw = value;
                    ChangedItems.Add(nameof(Critical_Begin_Wide_Rate));
                    OnPropertyChanged(nameof(Critical_Begin_Wide_Rate));
                }
            }

            protected float Critical_End_Wide_Rate_raw;
            public const string Critical_End_Wide_Rate_displayName = "Critical End Wide Rate";
            public const int Critical_End_Wide_Rate_sortIndex = 100;
            [SortOrder(Critical_End_Wide_Rate_sortIndex)]
            [DisplayName(Critical_End_Wide_Rate_displayName)]
            public virtual float Critical_End_Wide_Rate {
                get => Critical_End_Wide_Rate_raw;
                set {
                    if (Critical_End_Wide_Rate_raw == value) return;
                    Critical_End_Wide_Rate_raw = value;
                    ChangedItems.Add(nameof(Critical_End_Wide_Rate));
                    OnPropertyChanged(nameof(Critical_End_Wide_Rate));
                }
            }

            public const int lastSortIndex = 150;

            public static ObservableMhwStructCollection<Minds_Eye_Ballistics> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Minds_Eye_Ballistics>();
                const ulong count = 2UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Minds_Eye_Ballistics LoadData(BinaryReader reader, ulong i) {
                var data = new Minds_Eye_Ballistics();
                data.Index = i;
                data.Critical_Begin_Wide_Rate_raw = reader.ReadSingle();
                data.Critical_End_Wide_Rate_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Critical_Begin_Wide_Rate_raw);
                writer.Write(Critical_End_Wide_Rate_raw);
            }
        }

        public partial class Critical_Element_Multipliers : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 2;
            public const string GridName = "Critical Element Multipliers";

            protected float Great_Sword_raw;
            public const string Great_Sword_displayName = "Great Sword";
            public const int Great_Sword_sortIndex = 50;
            [SortOrder(Great_Sword_sortIndex)]
            [DisplayName(Great_Sword_displayName)]
            public virtual float Great_Sword {
                get => Great_Sword_raw;
                set {
                    if (Great_Sword_raw == value) return;
                    Great_Sword_raw = value;
                    ChangedItems.Add(nameof(Great_Sword));
                    OnPropertyChanged(nameof(Great_Sword));
                }
            }

            protected float Sword_Shield_raw;
            public const string Sword_Shield_displayName = "Sword & Shield";
            public const int Sword_Shield_sortIndex = 100;
            [SortOrder(Sword_Shield_sortIndex)]
            [DisplayName(Sword_Shield_displayName)]
            public virtual float Sword_Shield {
                get => Sword_Shield_raw;
                set {
                    if (Sword_Shield_raw == value) return;
                    Sword_Shield_raw = value;
                    ChangedItems.Add(nameof(Sword_Shield));
                    OnPropertyChanged(nameof(Sword_Shield));
                }
            }

            protected float Dual_Blades_raw;
            public const string Dual_Blades_displayName = "Dual Blades";
            public const int Dual_Blades_sortIndex = 150;
            [SortOrder(Dual_Blades_sortIndex)]
            [DisplayName(Dual_Blades_displayName)]
            public virtual float Dual_Blades {
                get => Dual_Blades_raw;
                set {
                    if (Dual_Blades_raw == value) return;
                    Dual_Blades_raw = value;
                    ChangedItems.Add(nameof(Dual_Blades));
                    OnPropertyChanged(nameof(Dual_Blades));
                }
            }

            protected float Long_Sword_raw;
            public const string Long_Sword_displayName = "Long Sword";
            public const int Long_Sword_sortIndex = 200;
            [SortOrder(Long_Sword_sortIndex)]
            [DisplayName(Long_Sword_displayName)]
            public virtual float Long_Sword {
                get => Long_Sword_raw;
                set {
                    if (Long_Sword_raw == value) return;
                    Long_Sword_raw = value;
                    ChangedItems.Add(nameof(Long_Sword));
                    OnPropertyChanged(nameof(Long_Sword));
                }
            }

            protected float Hammer_raw;
            public const string Hammer_displayName = "Hammer";
            public const int Hammer_sortIndex = 250;
            [SortOrder(Hammer_sortIndex)]
            [DisplayName(Hammer_displayName)]
            public virtual float Hammer {
                get => Hammer_raw;
                set {
                    if (Hammer_raw == value) return;
                    Hammer_raw = value;
                    ChangedItems.Add(nameof(Hammer));
                    OnPropertyChanged(nameof(Hammer));
                }
            }

            protected float Hunting_Horn_raw;
            public const string Hunting_Horn_displayName = "Hunting Horn";
            public const int Hunting_Horn_sortIndex = 300;
            [SortOrder(Hunting_Horn_sortIndex)]
            [DisplayName(Hunting_Horn_displayName)]
            public virtual float Hunting_Horn {
                get => Hunting_Horn_raw;
                set {
                    if (Hunting_Horn_raw == value) return;
                    Hunting_Horn_raw = value;
                    ChangedItems.Add(nameof(Hunting_Horn));
                    OnPropertyChanged(nameof(Hunting_Horn));
                }
            }

            protected float Lance_raw;
            public const string Lance_displayName = "Lance";
            public const int Lance_sortIndex = 350;
            [SortOrder(Lance_sortIndex)]
            [DisplayName(Lance_displayName)]
            public virtual float Lance {
                get => Lance_raw;
                set {
                    if (Lance_raw == value) return;
                    Lance_raw = value;
                    ChangedItems.Add(nameof(Lance));
                    OnPropertyChanged(nameof(Lance));
                }
            }

            protected float Gunlance_raw;
            public const string Gunlance_displayName = "Gunlance";
            public const int Gunlance_sortIndex = 400;
            [SortOrder(Gunlance_sortIndex)]
            [DisplayName(Gunlance_displayName)]
            public virtual float Gunlance {
                get => Gunlance_raw;
                set {
                    if (Gunlance_raw == value) return;
                    Gunlance_raw = value;
                    ChangedItems.Add(nameof(Gunlance));
                    OnPropertyChanged(nameof(Gunlance));
                }
            }

            protected float Switch_Axe_raw;
            public const string Switch_Axe_displayName = "Switch Axe";
            public const int Switch_Axe_sortIndex = 450;
            [SortOrder(Switch_Axe_sortIndex)]
            [DisplayName(Switch_Axe_displayName)]
            public virtual float Switch_Axe {
                get => Switch_Axe_raw;
                set {
                    if (Switch_Axe_raw == value) return;
                    Switch_Axe_raw = value;
                    ChangedItems.Add(nameof(Switch_Axe));
                    OnPropertyChanged(nameof(Switch_Axe));
                }
            }

            protected float Charge_Blade_raw;
            public const string Charge_Blade_displayName = "Charge Blade";
            public const int Charge_Blade_sortIndex = 500;
            [SortOrder(Charge_Blade_sortIndex)]
            [DisplayName(Charge_Blade_displayName)]
            public virtual float Charge_Blade {
                get => Charge_Blade_raw;
                set {
                    if (Charge_Blade_raw == value) return;
                    Charge_Blade_raw = value;
                    ChangedItems.Add(nameof(Charge_Blade));
                    OnPropertyChanged(nameof(Charge_Blade));
                }
            }

            protected float Insect_Glaive_raw;
            public const string Insect_Glaive_displayName = "Insect Glaive";
            public const int Insect_Glaive_sortIndex = 550;
            [SortOrder(Insect_Glaive_sortIndex)]
            [DisplayName(Insect_Glaive_displayName)]
            public virtual float Insect_Glaive {
                get => Insect_Glaive_raw;
                set {
                    if (Insect_Glaive_raw == value) return;
                    Insect_Glaive_raw = value;
                    ChangedItems.Add(nameof(Insect_Glaive));
                    OnPropertyChanged(nameof(Insect_Glaive));
                }
            }

            protected float Bow_raw;
            public const string Bow_displayName = "Bow";
            public const int Bow_sortIndex = 600;
            [SortOrder(Bow_sortIndex)]
            [DisplayName(Bow_displayName)]
            public virtual float Bow {
                get => Bow_raw;
                set {
                    if (Bow_raw == value) return;
                    Bow_raw = value;
                    ChangedItems.Add(nameof(Bow));
                    OnPropertyChanged(nameof(Bow));
                }
            }

            protected float HBG_raw;
            public const string HBG_displayName = "HBG";
            public const int HBG_sortIndex = 650;
            [SortOrder(HBG_sortIndex)]
            [DisplayName(HBG_displayName)]
            public virtual float HBG {
                get => HBG_raw;
                set {
                    if (HBG_raw == value) return;
                    HBG_raw = value;
                    ChangedItems.Add(nameof(HBG));
                    OnPropertyChanged(nameof(HBG));
                }
            }

            protected float LBG_raw;
            public const string LBG_displayName = "LBG";
            public const int LBG_sortIndex = 700;
            [SortOrder(LBG_sortIndex)]
            [DisplayName(LBG_displayName)]
            public virtual float LBG {
                get => LBG_raw;
                set {
                    if (LBG_raw == value) return;
                    LBG_raw = value;
                    ChangedItems.Add(nameof(LBG));
                    OnPropertyChanged(nameof(LBG));
                }
            }

            protected float Dragon_Seal_Rate_raw;
            public const string Dragon_Seal_Rate_displayName = "Dragon Seal Rate";
            public const int Dragon_Seal_Rate_sortIndex = 750;
            [SortOrder(Dragon_Seal_Rate_sortIndex)]
            [DisplayName(Dragon_Seal_Rate_displayName)]
            public virtual float Dragon_Seal_Rate {
                get => Dragon_Seal_Rate_raw;
                set {
                    if (Dragon_Seal_Rate_raw == value) return;
                    Dragon_Seal_Rate_raw = value;
                    ChangedItems.Add(nameof(Dragon_Seal_Rate));
                    OnPropertyChanged(nameof(Dragon_Seal_Rate));
                }
            }

            public const int lastSortIndex = 800;

            public static ObservableMhwStructCollection<Critical_Element_Multipliers> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Critical_Element_Multipliers>();
                const ulong count = 2UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Critical_Element_Multipliers LoadData(BinaryReader reader, ulong i) {
                var data = new Critical_Element_Multipliers();
                data.Index = i;
                data.Great_Sword_raw = reader.ReadSingle();
                data.Sword_Shield_raw = reader.ReadSingle();
                data.Dual_Blades_raw = reader.ReadSingle();
                data.Long_Sword_raw = reader.ReadSingle();
                data.Hammer_raw = reader.ReadSingle();
                data.Hunting_Horn_raw = reader.ReadSingle();
                data.Lance_raw = reader.ReadSingle();
                data.Gunlance_raw = reader.ReadSingle();
                data.Switch_Axe_raw = reader.ReadSingle();
                data.Charge_Blade_raw = reader.ReadSingle();
                data.Insect_Glaive_raw = reader.ReadSingle();
                data.Bow_raw = reader.ReadSingle();
                data.HBG_raw = reader.ReadSingle();
                data.LBG_raw = reader.ReadSingle();
                data.Dragon_Seal_Rate_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Great_Sword_raw);
                writer.Write(Sword_Shield_raw);
                writer.Write(Dual_Blades_raw);
                writer.Write(Long_Sword_raw);
                writer.Write(Hammer_raw);
                writer.Write(Hunting_Horn_raw);
                writer.Write(Lance_raw);
                writer.Write(Gunlance_raw);
                writer.Write(Switch_Axe_raw);
                writer.Write(Charge_Blade_raw);
                writer.Write(Insect_Glaive_raw);
                writer.Write(Bow_raw);
                writer.Write(HBG_raw);
                writer.Write(LBG_raw);
                writer.Write(Dragon_Seal_Rate_raw);
            }
        }

        public partial class Critical_Condition_Multipliers : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 2;
            public const string GridName = "Critical Condition Multipliers";

            protected float Great_Sword_raw;
            public const string Great_Sword_displayName = "Great Sword";
            public const int Great_Sword_sortIndex = 50;
            [SortOrder(Great_Sword_sortIndex)]
            [DisplayName(Great_Sword_displayName)]
            public virtual float Great_Sword {
                get => Great_Sword_raw;
                set {
                    if (Great_Sword_raw == value) return;
                    Great_Sword_raw = value;
                    ChangedItems.Add(nameof(Great_Sword));
                    OnPropertyChanged(nameof(Great_Sword));
                }
            }

            protected float Sword_Shield_raw;
            public const string Sword_Shield_displayName = "Sword & Shield";
            public const int Sword_Shield_sortIndex = 100;
            [SortOrder(Sword_Shield_sortIndex)]
            [DisplayName(Sword_Shield_displayName)]
            public virtual float Sword_Shield {
                get => Sword_Shield_raw;
                set {
                    if (Sword_Shield_raw == value) return;
                    Sword_Shield_raw = value;
                    ChangedItems.Add(nameof(Sword_Shield));
                    OnPropertyChanged(nameof(Sword_Shield));
                }
            }

            protected float Dual_Blades_raw;
            public const string Dual_Blades_displayName = "Dual Blades";
            public const int Dual_Blades_sortIndex = 150;
            [SortOrder(Dual_Blades_sortIndex)]
            [DisplayName(Dual_Blades_displayName)]
            public virtual float Dual_Blades {
                get => Dual_Blades_raw;
                set {
                    if (Dual_Blades_raw == value) return;
                    Dual_Blades_raw = value;
                    ChangedItems.Add(nameof(Dual_Blades));
                    OnPropertyChanged(nameof(Dual_Blades));
                }
            }

            protected float Long_Sword_raw;
            public const string Long_Sword_displayName = "Long Sword";
            public const int Long_Sword_sortIndex = 200;
            [SortOrder(Long_Sword_sortIndex)]
            [DisplayName(Long_Sword_displayName)]
            public virtual float Long_Sword {
                get => Long_Sword_raw;
                set {
                    if (Long_Sword_raw == value) return;
                    Long_Sword_raw = value;
                    ChangedItems.Add(nameof(Long_Sword));
                    OnPropertyChanged(nameof(Long_Sword));
                }
            }

            protected float Hammer_raw;
            public const string Hammer_displayName = "Hammer";
            public const int Hammer_sortIndex = 250;
            [SortOrder(Hammer_sortIndex)]
            [DisplayName(Hammer_displayName)]
            public virtual float Hammer {
                get => Hammer_raw;
                set {
                    if (Hammer_raw == value) return;
                    Hammer_raw = value;
                    ChangedItems.Add(nameof(Hammer));
                    OnPropertyChanged(nameof(Hammer));
                }
            }

            protected float Hunting_Horn_raw;
            public const string Hunting_Horn_displayName = "Hunting Horn";
            public const int Hunting_Horn_sortIndex = 300;
            [SortOrder(Hunting_Horn_sortIndex)]
            [DisplayName(Hunting_Horn_displayName)]
            public virtual float Hunting_Horn {
                get => Hunting_Horn_raw;
                set {
                    if (Hunting_Horn_raw == value) return;
                    Hunting_Horn_raw = value;
                    ChangedItems.Add(nameof(Hunting_Horn));
                    OnPropertyChanged(nameof(Hunting_Horn));
                }
            }

            protected float Lance_raw;
            public const string Lance_displayName = "Lance";
            public const int Lance_sortIndex = 350;
            [SortOrder(Lance_sortIndex)]
            [DisplayName(Lance_displayName)]
            public virtual float Lance {
                get => Lance_raw;
                set {
                    if (Lance_raw == value) return;
                    Lance_raw = value;
                    ChangedItems.Add(nameof(Lance));
                    OnPropertyChanged(nameof(Lance));
                }
            }

            protected float Gunlance_raw;
            public const string Gunlance_displayName = "Gunlance";
            public const int Gunlance_sortIndex = 400;
            [SortOrder(Gunlance_sortIndex)]
            [DisplayName(Gunlance_displayName)]
            public virtual float Gunlance {
                get => Gunlance_raw;
                set {
                    if (Gunlance_raw == value) return;
                    Gunlance_raw = value;
                    ChangedItems.Add(nameof(Gunlance));
                    OnPropertyChanged(nameof(Gunlance));
                }
            }

            protected float Switch_Axe_raw;
            public const string Switch_Axe_displayName = "Switch Axe";
            public const int Switch_Axe_sortIndex = 450;
            [SortOrder(Switch_Axe_sortIndex)]
            [DisplayName(Switch_Axe_displayName)]
            public virtual float Switch_Axe {
                get => Switch_Axe_raw;
                set {
                    if (Switch_Axe_raw == value) return;
                    Switch_Axe_raw = value;
                    ChangedItems.Add(nameof(Switch_Axe));
                    OnPropertyChanged(nameof(Switch_Axe));
                }
            }

            protected float Charge_Blade_raw;
            public const string Charge_Blade_displayName = "Charge Blade";
            public const int Charge_Blade_sortIndex = 500;
            [SortOrder(Charge_Blade_sortIndex)]
            [DisplayName(Charge_Blade_displayName)]
            public virtual float Charge_Blade {
                get => Charge_Blade_raw;
                set {
                    if (Charge_Blade_raw == value) return;
                    Charge_Blade_raw = value;
                    ChangedItems.Add(nameof(Charge_Blade));
                    OnPropertyChanged(nameof(Charge_Blade));
                }
            }

            protected float Insect_Glaive_raw;
            public const string Insect_Glaive_displayName = "Insect Glaive";
            public const int Insect_Glaive_sortIndex = 550;
            [SortOrder(Insect_Glaive_sortIndex)]
            [DisplayName(Insect_Glaive_displayName)]
            public virtual float Insect_Glaive {
                get => Insect_Glaive_raw;
                set {
                    if (Insect_Glaive_raw == value) return;
                    Insect_Glaive_raw = value;
                    ChangedItems.Add(nameof(Insect_Glaive));
                    OnPropertyChanged(nameof(Insect_Glaive));
                }
            }

            protected float Bow_raw;
            public const string Bow_displayName = "Bow";
            public const int Bow_sortIndex = 600;
            [SortOrder(Bow_sortIndex)]
            [DisplayName(Bow_displayName)]
            public virtual float Bow {
                get => Bow_raw;
                set {
                    if (Bow_raw == value) return;
                    Bow_raw = value;
                    ChangedItems.Add(nameof(Bow));
                    OnPropertyChanged(nameof(Bow));
                }
            }

            protected float HBG_raw;
            public const string HBG_displayName = "HBG";
            public const int HBG_sortIndex = 650;
            [SortOrder(HBG_sortIndex)]
            [DisplayName(HBG_displayName)]
            public virtual float HBG {
                get => HBG_raw;
                set {
                    if (HBG_raw == value) return;
                    HBG_raw = value;
                    ChangedItems.Add(nameof(HBG));
                    OnPropertyChanged(nameof(HBG));
                }
            }

            protected float LBG_raw;
            public const string LBG_displayName = "LBG";
            public const int LBG_sortIndex = 700;
            [SortOrder(LBG_sortIndex)]
            [DisplayName(LBG_displayName)]
            public virtual float LBG {
                get => LBG_raw;
                set {
                    if (LBG_raw == value) return;
                    LBG_raw = value;
                    ChangedItems.Add(nameof(LBG));
                    OnPropertyChanged(nameof(LBG));
                }
            }

            public const int lastSortIndex = 750;

            public static ObservableMhwStructCollection<Critical_Condition_Multipliers> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Critical_Condition_Multipliers>();
                const ulong count = 2UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Critical_Condition_Multipliers LoadData(BinaryReader reader, ulong i) {
                var data = new Critical_Condition_Multipliers();
                data.Index = i;
                data.Great_Sword_raw = reader.ReadSingle();
                data.Sword_Shield_raw = reader.ReadSingle();
                data.Dual_Blades_raw = reader.ReadSingle();
                data.Long_Sword_raw = reader.ReadSingle();
                data.Hammer_raw = reader.ReadSingle();
                data.Hunting_Horn_raw = reader.ReadSingle();
                data.Lance_raw = reader.ReadSingle();
                data.Gunlance_raw = reader.ReadSingle();
                data.Switch_Axe_raw = reader.ReadSingle();
                data.Charge_Blade_raw = reader.ReadSingle();
                data.Insect_Glaive_raw = reader.ReadSingle();
                data.Bow_raw = reader.ReadSingle();
                data.HBG_raw = reader.ReadSingle();
                data.LBG_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Great_Sword_raw);
                writer.Write(Sword_Shield_raw);
                writer.Write(Dual_Blades_raw);
                writer.Write(Long_Sword_raw);
                writer.Write(Hammer_raw);
                writer.Write(Hunting_Horn_raw);
                writer.Write(Lance_raw);
                writer.Write(Gunlance_raw);
                writer.Write(Switch_Axe_raw);
                writer.Write(Charge_Blade_raw);
                writer.Write(Insect_Glaive_raw);
                writer.Write(Bow_raw);
                writer.Write(HBG_raw);
                writer.Write(LBG_raw);
            }
        }

        public partial class Skill_Params_3_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Skill Params (3)";

            protected ushort Bludgeoner_Red_Sharpness_Attack_Bonus_BG_Melee__raw;
            public const string Bludgeoner_Red_Sharpness_Attack_Bonus_BG_Melee__displayName = "Bludgeoner: Red Sharpness Attack Bonus (& BG Melee)";
            public const int Bludgeoner_Red_Sharpness_Attack_Bonus_BG_Melee__sortIndex = 50;
            [SortOrder(Bludgeoner_Red_Sharpness_Attack_Bonus_BG_Melee__sortIndex)]
            [DisplayName(Bludgeoner_Red_Sharpness_Attack_Bonus_BG_Melee__displayName)]
            public virtual ushort Bludgeoner_Red_Sharpness_Attack_Bonus_BG_Melee_ {
                get => Bludgeoner_Red_Sharpness_Attack_Bonus_BG_Melee__raw;
                set {
                    if (Bludgeoner_Red_Sharpness_Attack_Bonus_BG_Melee__raw == value) return;
                    Bludgeoner_Red_Sharpness_Attack_Bonus_BG_Melee__raw = value;
                    ChangedItems.Add(nameof(Bludgeoner_Red_Sharpness_Attack_Bonus_BG_Melee_));
                    OnPropertyChanged(nameof(Bludgeoner_Red_Sharpness_Attack_Bonus_BG_Melee_));
                }
            }

            [DisplayName("Offset")]
            public long Bludgeoner_Red_Sharpness_Attack_Bonus_BG_Melee__offset { get; private set; }

            protected ushort Bludgeoner_Orange_Sharpness_Attack_Bonus_raw;
            public const string Bludgeoner_Orange_Sharpness_Attack_Bonus_displayName = "Bludgeoner: Orange Sharpness Attack Bonus";
            public const int Bludgeoner_Orange_Sharpness_Attack_Bonus_sortIndex = 100;
            [SortOrder(Bludgeoner_Orange_Sharpness_Attack_Bonus_sortIndex)]
            [DisplayName(Bludgeoner_Orange_Sharpness_Attack_Bonus_displayName)]
            public virtual ushort Bludgeoner_Orange_Sharpness_Attack_Bonus {
                get => Bludgeoner_Orange_Sharpness_Attack_Bonus_raw;
                set {
                    if (Bludgeoner_Orange_Sharpness_Attack_Bonus_raw == value) return;
                    Bludgeoner_Orange_Sharpness_Attack_Bonus_raw = value;
                    ChangedItems.Add(nameof(Bludgeoner_Orange_Sharpness_Attack_Bonus));
                    OnPropertyChanged(nameof(Bludgeoner_Orange_Sharpness_Attack_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long Bludgeoner_Orange_Sharpness_Attack_Bonus_offset { get; private set; }

            protected ushort Bludgeoner_Yellow_Sharpness_Attack_Bonus_raw;
            public const string Bludgeoner_Yellow_Sharpness_Attack_Bonus_displayName = "Bludgeoner: Yellow Sharpness Attack Bonus";
            public const int Bludgeoner_Yellow_Sharpness_Attack_Bonus_sortIndex = 150;
            [SortOrder(Bludgeoner_Yellow_Sharpness_Attack_Bonus_sortIndex)]
            [DisplayName(Bludgeoner_Yellow_Sharpness_Attack_Bonus_displayName)]
            public virtual ushort Bludgeoner_Yellow_Sharpness_Attack_Bonus {
                get => Bludgeoner_Yellow_Sharpness_Attack_Bonus_raw;
                set {
                    if (Bludgeoner_Yellow_Sharpness_Attack_Bonus_raw == value) return;
                    Bludgeoner_Yellow_Sharpness_Attack_Bonus_raw = value;
                    ChangedItems.Add(nameof(Bludgeoner_Yellow_Sharpness_Attack_Bonus));
                    OnPropertyChanged(nameof(Bludgeoner_Yellow_Sharpness_Attack_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long Bludgeoner_Yellow_Sharpness_Attack_Bonus_offset { get; private set; }

            protected ushort Bludgeoner_Green_Sharpness_Attack_Bonus_raw;
            public const string Bludgeoner_Green_Sharpness_Attack_Bonus_displayName = "Bludgeoner: Green Sharpness Attack Bonus";
            public const int Bludgeoner_Green_Sharpness_Attack_Bonus_sortIndex = 200;
            [SortOrder(Bludgeoner_Green_Sharpness_Attack_Bonus_sortIndex)]
            [DisplayName(Bludgeoner_Green_Sharpness_Attack_Bonus_displayName)]
            public virtual ushort Bludgeoner_Green_Sharpness_Attack_Bonus {
                get => Bludgeoner_Green_Sharpness_Attack_Bonus_raw;
                set {
                    if (Bludgeoner_Green_Sharpness_Attack_Bonus_raw == value) return;
                    Bludgeoner_Green_Sharpness_Attack_Bonus_raw = value;
                    ChangedItems.Add(nameof(Bludgeoner_Green_Sharpness_Attack_Bonus));
                    OnPropertyChanged(nameof(Bludgeoner_Green_Sharpness_Attack_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long Bludgeoner_Green_Sharpness_Attack_Bonus_offset { get; private set; }

            protected ushort Bludgeoner_Blue_Sharpness_Attack_Bonus_raw;
            public const string Bludgeoner_Blue_Sharpness_Attack_Bonus_displayName = "Bludgeoner: Blue Sharpness Attack Bonus";
            public const int Bludgeoner_Blue_Sharpness_Attack_Bonus_sortIndex = 250;
            [SortOrder(Bludgeoner_Blue_Sharpness_Attack_Bonus_sortIndex)]
            [DisplayName(Bludgeoner_Blue_Sharpness_Attack_Bonus_displayName)]
            public virtual ushort Bludgeoner_Blue_Sharpness_Attack_Bonus {
                get => Bludgeoner_Blue_Sharpness_Attack_Bonus_raw;
                set {
                    if (Bludgeoner_Blue_Sharpness_Attack_Bonus_raw == value) return;
                    Bludgeoner_Blue_Sharpness_Attack_Bonus_raw = value;
                    ChangedItems.Add(nameof(Bludgeoner_Blue_Sharpness_Attack_Bonus));
                    OnPropertyChanged(nameof(Bludgeoner_Blue_Sharpness_Attack_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long Bludgeoner_Blue_Sharpness_Attack_Bonus_offset { get; private set; }

            protected ushort Bludgeoner_White_Sharpness_Attack_Bonus_raw;
            public const string Bludgeoner_White_Sharpness_Attack_Bonus_displayName = "Bludgeoner: White Sharpness Attack Bonus";
            public const int Bludgeoner_White_Sharpness_Attack_Bonus_sortIndex = 300;
            [SortOrder(Bludgeoner_White_Sharpness_Attack_Bonus_sortIndex)]
            [DisplayName(Bludgeoner_White_Sharpness_Attack_Bonus_displayName)]
            public virtual ushort Bludgeoner_White_Sharpness_Attack_Bonus {
                get => Bludgeoner_White_Sharpness_Attack_Bonus_raw;
                set {
                    if (Bludgeoner_White_Sharpness_Attack_Bonus_raw == value) return;
                    Bludgeoner_White_Sharpness_Attack_Bonus_raw = value;
                    ChangedItems.Add(nameof(Bludgeoner_White_Sharpness_Attack_Bonus));
                    OnPropertyChanged(nameof(Bludgeoner_White_Sharpness_Attack_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long Bludgeoner_White_Sharpness_Attack_Bonus_offset { get; private set; }

            protected ushort Bludgeoner_Purple_Sharpness_Attack_Bonus_raw;
            public const string Bludgeoner_Purple_Sharpness_Attack_Bonus_displayName = "Bludgeoner: Purple Sharpness Attack Bonus";
            public const int Bludgeoner_Purple_Sharpness_Attack_Bonus_sortIndex = 350;
            [SortOrder(Bludgeoner_Purple_Sharpness_Attack_Bonus_sortIndex)]
            [DisplayName(Bludgeoner_Purple_Sharpness_Attack_Bonus_displayName)]
            public virtual ushort Bludgeoner_Purple_Sharpness_Attack_Bonus {
                get => Bludgeoner_Purple_Sharpness_Attack_Bonus_raw;
                set {
                    if (Bludgeoner_Purple_Sharpness_Attack_Bonus_raw == value) return;
                    Bludgeoner_Purple_Sharpness_Attack_Bonus_raw = value;
                    ChangedItems.Add(nameof(Bludgeoner_Purple_Sharpness_Attack_Bonus));
                    OnPropertyChanged(nameof(Bludgeoner_Purple_Sharpness_Attack_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long Bludgeoner_Purple_Sharpness_Attack_Bonus_offset { get; private set; }

            protected ushort Bludgeoner_Bowgun_Melee_Attack_Stun_Bonus_raw;
            public const string Bludgeoner_Bowgun_Melee_Attack_Stun_Bonus_displayName = "Bludgeoner: Bowgun Melee Attack Stun Bonus";
            public const int Bludgeoner_Bowgun_Melee_Attack_Stun_Bonus_sortIndex = 400;
            [SortOrder(Bludgeoner_Bowgun_Melee_Attack_Stun_Bonus_sortIndex)]
            [DisplayName(Bludgeoner_Bowgun_Melee_Attack_Stun_Bonus_displayName)]
            public virtual ushort Bludgeoner_Bowgun_Melee_Attack_Stun_Bonus {
                get => Bludgeoner_Bowgun_Melee_Attack_Stun_Bonus_raw;
                set {
                    if (Bludgeoner_Bowgun_Melee_Attack_Stun_Bonus_raw == value) return;
                    Bludgeoner_Bowgun_Melee_Attack_Stun_Bonus_raw = value;
                    ChangedItems.Add(nameof(Bludgeoner_Bowgun_Melee_Attack_Stun_Bonus));
                    OnPropertyChanged(nameof(Bludgeoner_Bowgun_Melee_Attack_Stun_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long Bludgeoner_Bowgun_Melee_Attack_Stun_Bonus_offset { get; private set; }

            protected float Non_Elemental_Boost_Attack_Multiplier_raw;
            public const string Non_Elemental_Boost_Attack_Multiplier_displayName = "Non-Elemental Boost: Attack Multiplier";
            public const int Non_Elemental_Boost_Attack_Multiplier_sortIndex = 450;
            [SortOrder(Non_Elemental_Boost_Attack_Multiplier_sortIndex)]
            [DisplayName(Non_Elemental_Boost_Attack_Multiplier_displayName)]
            public virtual float Non_Elemental_Boost_Attack_Multiplier {
                get => Non_Elemental_Boost_Attack_Multiplier_raw;
                set {
                    if (Non_Elemental_Boost_Attack_Multiplier_raw == value) return;
                    Non_Elemental_Boost_Attack_Multiplier_raw = value;
                    ChangedItems.Add(nameof(Non_Elemental_Boost_Attack_Multiplier));
                    OnPropertyChanged(nameof(Non_Elemental_Boost_Attack_Multiplier));
                }
            }

            [DisplayName("Offset")]
            public long Non_Elemental_Boost_Attack_Multiplier_offset { get; private set; }

            protected float Affinity_Slider_Attack_Up_Activate_Time_raw;
            public const string Affinity_Slider_Attack_Up_Activate_Time_displayName = "Affinity Slider: Attack Up Activate Time";
            public const int Affinity_Slider_Attack_Up_Activate_Time_sortIndex = 500;
            [SortOrder(Affinity_Slider_Attack_Up_Activate_Time_sortIndex)]
            [DisplayName(Affinity_Slider_Attack_Up_Activate_Time_displayName)]
            public virtual float Affinity_Slider_Attack_Up_Activate_Time {
                get => Affinity_Slider_Attack_Up_Activate_Time_raw;
                set {
                    if (Affinity_Slider_Attack_Up_Activate_Time_raw == value) return;
                    Affinity_Slider_Attack_Up_Activate_Time_raw = value;
                    ChangedItems.Add(nameof(Affinity_Slider_Attack_Up_Activate_Time));
                    OnPropertyChanged(nameof(Affinity_Slider_Attack_Up_Activate_Time));
                }
            }

            [DisplayName("Offset")]
            public long Affinity_Slider_Attack_Up_Activate_Time_offset { get; private set; }

            protected float Affinity_Slider_Attack_Up_Duration_raw;
            public const string Affinity_Slider_Attack_Up_Duration_displayName = "Affinity Slider: Attack Up Duration";
            public const int Affinity_Slider_Attack_Up_Duration_sortIndex = 550;
            [SortOrder(Affinity_Slider_Attack_Up_Duration_sortIndex)]
            [DisplayName(Affinity_Slider_Attack_Up_Duration_displayName)]
            public virtual float Affinity_Slider_Attack_Up_Duration {
                get => Affinity_Slider_Attack_Up_Duration_raw;
                set {
                    if (Affinity_Slider_Attack_Up_Duration_raw == value) return;
                    Affinity_Slider_Attack_Up_Duration_raw = value;
                    ChangedItems.Add(nameof(Affinity_Slider_Attack_Up_Duration));
                    OnPropertyChanged(nameof(Affinity_Slider_Attack_Up_Duration));
                }
            }

            [DisplayName("Offset")]
            public long Affinity_Slider_Attack_Up_Duration_offset { get; private set; }

            protected byte Affinity_Slider_Attack_Critical_Bonus_raw;
            public const string Affinity_Slider_Attack_Critical_Bonus_displayName = "Affinity Slider: Attack Critical Bonus";
            public const int Affinity_Slider_Attack_Critical_Bonus_sortIndex = 600;
            [SortOrder(Affinity_Slider_Attack_Critical_Bonus_sortIndex)]
            [DisplayName(Affinity_Slider_Attack_Critical_Bonus_displayName)]
            public virtual byte Affinity_Slider_Attack_Critical_Bonus {
                get => Affinity_Slider_Attack_Critical_Bonus_raw;
                set {
                    if (Affinity_Slider_Attack_Critical_Bonus_raw == value) return;
                    Affinity_Slider_Attack_Critical_Bonus_raw = value;
                    ChangedItems.Add(nameof(Affinity_Slider_Attack_Critical_Bonus));
                    OnPropertyChanged(nameof(Affinity_Slider_Attack_Critical_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long Affinity_Slider_Attack_Critical_Bonus_offset { get; private set; }

            public const int lastSortIndex = 650;

            public static ObservableMhwStructCollection<Skill_Params_3_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Skill_Params_3_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Skill_Params_3_ LoadData(BinaryReader reader, ulong i) {
                var data = new Skill_Params_3_();
                data.Index = i;
                data.Bludgeoner_Red_Sharpness_Attack_Bonus_BG_Melee__offset = reader.BaseStream.Position;
                data.Bludgeoner_Red_Sharpness_Attack_Bonus_BG_Melee__raw = reader.ReadUInt16();
                data.Bludgeoner_Orange_Sharpness_Attack_Bonus_offset = reader.BaseStream.Position;
                data.Bludgeoner_Orange_Sharpness_Attack_Bonus_raw = reader.ReadUInt16();
                data.Bludgeoner_Yellow_Sharpness_Attack_Bonus_offset = reader.BaseStream.Position;
                data.Bludgeoner_Yellow_Sharpness_Attack_Bonus_raw = reader.ReadUInt16();
                data.Bludgeoner_Green_Sharpness_Attack_Bonus_offset = reader.BaseStream.Position;
                data.Bludgeoner_Green_Sharpness_Attack_Bonus_raw = reader.ReadUInt16();
                data.Bludgeoner_Blue_Sharpness_Attack_Bonus_offset = reader.BaseStream.Position;
                data.Bludgeoner_Blue_Sharpness_Attack_Bonus_raw = reader.ReadUInt16();
                data.Bludgeoner_White_Sharpness_Attack_Bonus_offset = reader.BaseStream.Position;
                data.Bludgeoner_White_Sharpness_Attack_Bonus_raw = reader.ReadUInt16();
                data.Bludgeoner_Purple_Sharpness_Attack_Bonus_offset = reader.BaseStream.Position;
                data.Bludgeoner_Purple_Sharpness_Attack_Bonus_raw = reader.ReadUInt16();
                data.Bludgeoner_Bowgun_Melee_Attack_Stun_Bonus_offset = reader.BaseStream.Position;
                data.Bludgeoner_Bowgun_Melee_Attack_Stun_Bonus_raw = reader.ReadUInt16();
                data.Non_Elemental_Boost_Attack_Multiplier_offset = reader.BaseStream.Position;
                data.Non_Elemental_Boost_Attack_Multiplier_raw = reader.ReadSingle();
                data.Affinity_Slider_Attack_Up_Activate_Time_offset = reader.BaseStream.Position;
                data.Affinity_Slider_Attack_Up_Activate_Time_raw = reader.ReadSingle();
                data.Affinity_Slider_Attack_Up_Duration_offset = reader.BaseStream.Position;
                data.Affinity_Slider_Attack_Up_Duration_raw = reader.ReadSingle();
                data.Affinity_Slider_Attack_Critical_Bonus_offset = reader.BaseStream.Position;
                data.Affinity_Slider_Attack_Critical_Bonus_raw = reader.ReadByte();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Bludgeoner_Red_Sharpness_Attack_Bonus_BG_Melee__raw);
                writer.Write(Bludgeoner_Orange_Sharpness_Attack_Bonus_raw);
                writer.Write(Bludgeoner_Yellow_Sharpness_Attack_Bonus_raw);
                writer.Write(Bludgeoner_Green_Sharpness_Attack_Bonus_raw);
                writer.Write(Bludgeoner_Blue_Sharpness_Attack_Bonus_raw);
                writer.Write(Bludgeoner_White_Sharpness_Attack_Bonus_raw);
                writer.Write(Bludgeoner_Purple_Sharpness_Attack_Bonus_raw);
                writer.Write(Bludgeoner_Bowgun_Melee_Attack_Stun_Bonus_raw);
                writer.Write(Non_Elemental_Boost_Attack_Multiplier_raw);
                writer.Write(Affinity_Slider_Attack_Up_Activate_Time_raw);
                writer.Write(Affinity_Slider_Attack_Up_Duration_raw);
                writer.Write(Affinity_Slider_Attack_Critical_Bonus_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Bludgeoner: Red Sharpness Attack Bonus (& BG Melee)", "Bludgeoner_Red_Sharpness_Attack_Bonus_BG_Melee_", "Bludgeoner_Red_Sharpness_Attack_Bonus_BG_Melee__offset"),
                    new MultiStructItemCustomView(this, "Bludgeoner: Orange Sharpness Attack Bonus", "Bludgeoner_Orange_Sharpness_Attack_Bonus", "Bludgeoner_Orange_Sharpness_Attack_Bonus_offset"),
                    new MultiStructItemCustomView(this, "Bludgeoner: Yellow Sharpness Attack Bonus", "Bludgeoner_Yellow_Sharpness_Attack_Bonus", "Bludgeoner_Yellow_Sharpness_Attack_Bonus_offset"),
                    new MultiStructItemCustomView(this, "Bludgeoner: Green Sharpness Attack Bonus", "Bludgeoner_Green_Sharpness_Attack_Bonus", "Bludgeoner_Green_Sharpness_Attack_Bonus_offset"),
                    new MultiStructItemCustomView(this, "Bludgeoner: Blue Sharpness Attack Bonus", "Bludgeoner_Blue_Sharpness_Attack_Bonus", "Bludgeoner_Blue_Sharpness_Attack_Bonus_offset"),
                    new MultiStructItemCustomView(this, "Bludgeoner: White Sharpness Attack Bonus", "Bludgeoner_White_Sharpness_Attack_Bonus", "Bludgeoner_White_Sharpness_Attack_Bonus_offset"),
                    new MultiStructItemCustomView(this, "Bludgeoner: Purple Sharpness Attack Bonus", "Bludgeoner_Purple_Sharpness_Attack_Bonus", "Bludgeoner_Purple_Sharpness_Attack_Bonus_offset"),
                    new MultiStructItemCustomView(this, "Bludgeoner: Bowgun Melee Attack Stun Bonus", "Bludgeoner_Bowgun_Melee_Attack_Stun_Bonus", "Bludgeoner_Bowgun_Melee_Attack_Stun_Bonus_offset"),
                    new MultiStructItemCustomView(this, "Non-Elemental Boost: Attack Multiplier", "Non_Elemental_Boost_Attack_Multiplier", "Non_Elemental_Boost_Attack_Multiplier_offset"),
                    new MultiStructItemCustomView(this, "Affinity Slider: Attack Up Activate Time", "Affinity_Slider_Attack_Up_Activate_Time", "Affinity_Slider_Attack_Up_Activate_Time_offset"),
                    new MultiStructItemCustomView(this, "Affinity Slider: Attack Up Duration", "Affinity_Slider_Attack_Up_Duration", "Affinity_Slider_Attack_Up_Duration_offset"),
                    new MultiStructItemCustomView(this, "Affinity Slider: Attack Critical Bonus", "Affinity_Slider_Attack_Critical_Bonus", "Affinity_Slider_Attack_Critical_Bonus_offset"),
                };
            }
        }

        public partial class Artillery : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 9;
            public const string GridName = "Artillery";

            protected float Level_1_raw;
            public const string Level_1_displayName = "Level 1";
            public const int Level_1_sortIndex = 50;
            [SortOrder(Level_1_sortIndex)]
            [DisplayName(Level_1_displayName)]
            public virtual float Level_1 {
                get => Level_1_raw;
                set {
                    if (Level_1_raw == value) return;
                    Level_1_raw = value;
                    ChangedItems.Add(nameof(Level_1));
                    OnPropertyChanged(nameof(Level_1));
                }
            }

            protected float Level_2_raw;
            public const string Level_2_displayName = "Level 2";
            public const int Level_2_sortIndex = 100;
            [SortOrder(Level_2_sortIndex)]
            [DisplayName(Level_2_displayName)]
            public virtual float Level_2 {
                get => Level_2_raw;
                set {
                    if (Level_2_raw == value) return;
                    Level_2_raw = value;
                    ChangedItems.Add(nameof(Level_2));
                    OnPropertyChanged(nameof(Level_2));
                }
            }

            protected float Level_3_raw;
            public const string Level_3_displayName = "Level 3";
            public const int Level_3_sortIndex = 150;
            [SortOrder(Level_3_sortIndex)]
            [DisplayName(Level_3_displayName)]
            public virtual float Level_3 {
                get => Level_3_raw;
                set {
                    if (Level_3_raw == value) return;
                    Level_3_raw = value;
                    ChangedItems.Add(nameof(Level_3));
                    OnPropertyChanged(nameof(Level_3));
                }
            }

            protected float Level_4_raw;
            public const string Level_4_displayName = "Level 4";
            public const int Level_4_sortIndex = 200;
            [SortOrder(Level_4_sortIndex)]
            [DisplayName(Level_4_displayName)]
            public virtual float Level_4 {
                get => Level_4_raw;
                set {
                    if (Level_4_raw == value) return;
                    Level_4_raw = value;
                    ChangedItems.Add(nameof(Level_4));
                    OnPropertyChanged(nameof(Level_4));
                }
            }

            protected float Level_5_raw;
            public const string Level_5_displayName = "Level 5";
            public const int Level_5_sortIndex = 250;
            [SortOrder(Level_5_sortIndex)]
            [DisplayName(Level_5_displayName)]
            public virtual float Level_5 {
                get => Level_5_raw;
                set {
                    if (Level_5_raw == value) return;
                    Level_5_raw = value;
                    ChangedItems.Add(nameof(Level_5));
                    OnPropertyChanged(nameof(Level_5));
                }
            }

            public const int lastSortIndex = 300;

            public static ObservableMhwStructCollection<Artillery> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Artillery>();
                const ulong count = 9UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Artillery LoadData(BinaryReader reader, ulong i) {
                var data = new Artillery();
                data.Index = i;
                data.Level_1_raw = reader.ReadSingle();
                data.Level_2_raw = reader.ReadSingle();
                data.Level_3_raw = reader.ReadSingle();
                data.Level_4_raw = reader.ReadSingle();
                data.Level_5_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Level_1_raw);
                writer.Write(Level_2_raw);
                writer.Write(Level_3_raw);
                writer.Write(Level_4_raw);
                writer.Write(Level_5_raw);
            }
        }

        public partial class Skill_Params_4_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Skill Params (4)";

            protected float Heavy_Artillery_Ballista_Attack_Rate_1_raw;
            public const string Heavy_Artillery_Ballista_Attack_Rate_1_displayName = "Heavy Artillery: Ballista Attack Rate 1";
            public const int Heavy_Artillery_Ballista_Attack_Rate_1_sortIndex = 50;
            [SortOrder(Heavy_Artillery_Ballista_Attack_Rate_1_sortIndex)]
            [DisplayName(Heavy_Artillery_Ballista_Attack_Rate_1_displayName)]
            public virtual float Heavy_Artillery_Ballista_Attack_Rate_1 {
                get => Heavy_Artillery_Ballista_Attack_Rate_1_raw;
                set {
                    if (Heavy_Artillery_Ballista_Attack_Rate_1_raw == value) return;
                    Heavy_Artillery_Ballista_Attack_Rate_1_raw = value;
                    ChangedItems.Add(nameof(Heavy_Artillery_Ballista_Attack_Rate_1));
                    OnPropertyChanged(nameof(Heavy_Artillery_Ballista_Attack_Rate_1));
                }
            }

            [DisplayName("Offset")]
            public long Heavy_Artillery_Ballista_Attack_Rate_1_offset { get; private set; }

            protected float Heavy_Artillery_Ballista_Attack_Rate_2_raw;
            public const string Heavy_Artillery_Ballista_Attack_Rate_2_displayName = "Heavy Artillery: Ballista Attack Rate 2";
            public const int Heavy_Artillery_Ballista_Attack_Rate_2_sortIndex = 100;
            [SortOrder(Heavy_Artillery_Ballista_Attack_Rate_2_sortIndex)]
            [DisplayName(Heavy_Artillery_Ballista_Attack_Rate_2_displayName)]
            public virtual float Heavy_Artillery_Ballista_Attack_Rate_2 {
                get => Heavy_Artillery_Ballista_Attack_Rate_2_raw;
                set {
                    if (Heavy_Artillery_Ballista_Attack_Rate_2_raw == value) return;
                    Heavy_Artillery_Ballista_Attack_Rate_2_raw = value;
                    ChangedItems.Add(nameof(Heavy_Artillery_Ballista_Attack_Rate_2));
                    OnPropertyChanged(nameof(Heavy_Artillery_Ballista_Attack_Rate_2));
                }
            }

            [DisplayName("Offset")]
            public long Heavy_Artillery_Ballista_Attack_Rate_2_offset { get; private set; }

            protected float Heavy_Artillery_Cannon_Attack_Rate_1_raw;
            public const string Heavy_Artillery_Cannon_Attack_Rate_1_displayName = "Heavy Artillery: Cannon Attack Rate 1";
            public const int Heavy_Artillery_Cannon_Attack_Rate_1_sortIndex = 150;
            [SortOrder(Heavy_Artillery_Cannon_Attack_Rate_1_sortIndex)]
            [DisplayName(Heavy_Artillery_Cannon_Attack_Rate_1_displayName)]
            public virtual float Heavy_Artillery_Cannon_Attack_Rate_1 {
                get => Heavy_Artillery_Cannon_Attack_Rate_1_raw;
                set {
                    if (Heavy_Artillery_Cannon_Attack_Rate_1_raw == value) return;
                    Heavy_Artillery_Cannon_Attack_Rate_1_raw = value;
                    ChangedItems.Add(nameof(Heavy_Artillery_Cannon_Attack_Rate_1));
                    OnPropertyChanged(nameof(Heavy_Artillery_Cannon_Attack_Rate_1));
                }
            }

            [DisplayName("Offset")]
            public long Heavy_Artillery_Cannon_Attack_Rate_1_offset { get; private set; }

            protected float Heavy_Artillery_Cannon_Attack_Rate_2_raw;
            public const string Heavy_Artillery_Cannon_Attack_Rate_2_displayName = "Heavy Artillery: Cannon Attack Rate 2";
            public const int Heavy_Artillery_Cannon_Attack_Rate_2_sortIndex = 200;
            [SortOrder(Heavy_Artillery_Cannon_Attack_Rate_2_sortIndex)]
            [DisplayName(Heavy_Artillery_Cannon_Attack_Rate_2_displayName)]
            public virtual float Heavy_Artillery_Cannon_Attack_Rate_2 {
                get => Heavy_Artillery_Cannon_Attack_Rate_2_raw;
                set {
                    if (Heavy_Artillery_Cannon_Attack_Rate_2_raw == value) return;
                    Heavy_Artillery_Cannon_Attack_Rate_2_raw = value;
                    ChangedItems.Add(nameof(Heavy_Artillery_Cannon_Attack_Rate_2));
                    OnPropertyChanged(nameof(Heavy_Artillery_Cannon_Attack_Rate_2));
                }
            }

            [DisplayName("Offset")]
            public long Heavy_Artillery_Cannon_Attack_Rate_2_offset { get; private set; }

            protected float Bombardier_Attack_Rate_1_raw;
            public const string Bombardier_Attack_Rate_1_displayName = "Bombardier: Attack Rate 1";
            public const int Bombardier_Attack_Rate_1_sortIndex = 250;
            [SortOrder(Bombardier_Attack_Rate_1_sortIndex)]
            [DisplayName(Bombardier_Attack_Rate_1_displayName)]
            public virtual float Bombardier_Attack_Rate_1 {
                get => Bombardier_Attack_Rate_1_raw;
                set {
                    if (Bombardier_Attack_Rate_1_raw == value) return;
                    Bombardier_Attack_Rate_1_raw = value;
                    ChangedItems.Add(nameof(Bombardier_Attack_Rate_1));
                    OnPropertyChanged(nameof(Bombardier_Attack_Rate_1));
                }
            }

            [DisplayName("Offset")]
            public long Bombardier_Attack_Rate_1_offset { get; private set; }

            protected float Bombardier_Attack_Rate_2_raw;
            public const string Bombardier_Attack_Rate_2_displayName = "Bombardier: Attack Rate 2";
            public const int Bombardier_Attack_Rate_2_sortIndex = 300;
            [SortOrder(Bombardier_Attack_Rate_2_sortIndex)]
            [DisplayName(Bombardier_Attack_Rate_2_displayName)]
            public virtual float Bombardier_Attack_Rate_2 {
                get => Bombardier_Attack_Rate_2_raw;
                set {
                    if (Bombardier_Attack_Rate_2_raw == value) return;
                    Bombardier_Attack_Rate_2_raw = value;
                    ChangedItems.Add(nameof(Bombardier_Attack_Rate_2));
                    OnPropertyChanged(nameof(Bombardier_Attack_Rate_2));
                }
            }

            [DisplayName("Offset")]
            public long Bombardier_Attack_Rate_2_offset { get; private set; }

            protected float Bombardier_Attack_Rate_3_raw;
            public const string Bombardier_Attack_Rate_3_displayName = "Bombardier: Attack Rate 3";
            public const int Bombardier_Attack_Rate_3_sortIndex = 350;
            [SortOrder(Bombardier_Attack_Rate_3_sortIndex)]
            [DisplayName(Bombardier_Attack_Rate_3_displayName)]
            public virtual float Bombardier_Attack_Rate_3 {
                get => Bombardier_Attack_Rate_3_raw;
                set {
                    if (Bombardier_Attack_Rate_3_raw == value) return;
                    Bombardier_Attack_Rate_3_raw = value;
                    ChangedItems.Add(nameof(Bombardier_Attack_Rate_3));
                    OnPropertyChanged(nameof(Bombardier_Attack_Rate_3));
                }
            }

            [DisplayName("Offset")]
            public long Bombardier_Attack_Rate_3_offset { get; private set; }

            protected float Bombardier_Attack_Rate_4_raw;
            public const string Bombardier_Attack_Rate_4_displayName = "Bombardier: Attack Rate 4";
            public const int Bombardier_Attack_Rate_4_sortIndex = 400;
            [SortOrder(Bombardier_Attack_Rate_4_sortIndex)]
            [DisplayName(Bombardier_Attack_Rate_4_displayName)]
            public virtual float Bombardier_Attack_Rate_4 {
                get => Bombardier_Attack_Rate_4_raw;
                set {
                    if (Bombardier_Attack_Rate_4_raw == value) return;
                    Bombardier_Attack_Rate_4_raw = value;
                    ChangedItems.Add(nameof(Bombardier_Attack_Rate_4));
                    OnPropertyChanged(nameof(Bombardier_Attack_Rate_4));
                }
            }

            [DisplayName("Offset")]
            public long Bombardier_Attack_Rate_4_offset { get; private set; }

            protected float Bombardier_Attack_Rate_5_raw;
            public const string Bombardier_Attack_Rate_5_displayName = "Bombardier: Attack Rate 5";
            public const int Bombardier_Attack_Rate_5_sortIndex = 450;
            [SortOrder(Bombardier_Attack_Rate_5_sortIndex)]
            [DisplayName(Bombardier_Attack_Rate_5_displayName)]
            public virtual float Bombardier_Attack_Rate_5 {
                get => Bombardier_Attack_Rate_5_raw;
                set {
                    if (Bombardier_Attack_Rate_5_raw == value) return;
                    Bombardier_Attack_Rate_5_raw = value;
                    ChangedItems.Add(nameof(Bombardier_Attack_Rate_5));
                    OnPropertyChanged(nameof(Bombardier_Attack_Rate_5));
                }
            }

            [DisplayName("Offset")]
            public long Bombardier_Attack_Rate_5_offset { get; private set; }

            protected byte Capacity_Boost_Gunlance_Normal_Bonus_raw;
            public const string Capacity_Boost_Gunlance_Normal_Bonus_displayName = "Capacity Boost: Gunlance Normal Bonus";
            public const int Capacity_Boost_Gunlance_Normal_Bonus_sortIndex = 500;
            [SortOrder(Capacity_Boost_Gunlance_Normal_Bonus_sortIndex)]
            [DisplayName(Capacity_Boost_Gunlance_Normal_Bonus_displayName)]
            public virtual byte Capacity_Boost_Gunlance_Normal_Bonus {
                get => Capacity_Boost_Gunlance_Normal_Bonus_raw;
                set {
                    if (Capacity_Boost_Gunlance_Normal_Bonus_raw == value) return;
                    Capacity_Boost_Gunlance_Normal_Bonus_raw = value;
                    ChangedItems.Add(nameof(Capacity_Boost_Gunlance_Normal_Bonus));
                    OnPropertyChanged(nameof(Capacity_Boost_Gunlance_Normal_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long Capacity_Boost_Gunlance_Normal_Bonus_offset { get; private set; }

            protected byte Capacity_Boost_Gunlance_Radiation_Bonus_raw;
            public const string Capacity_Boost_Gunlance_Radiation_Bonus_displayName = "Capacity Boost: Gunlance Radiation Bonus";
            public const int Capacity_Boost_Gunlance_Radiation_Bonus_sortIndex = 550;
            [SortOrder(Capacity_Boost_Gunlance_Radiation_Bonus_sortIndex)]
            [DisplayName(Capacity_Boost_Gunlance_Radiation_Bonus_displayName)]
            public virtual byte Capacity_Boost_Gunlance_Radiation_Bonus {
                get => Capacity_Boost_Gunlance_Radiation_Bonus_raw;
                set {
                    if (Capacity_Boost_Gunlance_Radiation_Bonus_raw == value) return;
                    Capacity_Boost_Gunlance_Radiation_Bonus_raw = value;
                    ChangedItems.Add(nameof(Capacity_Boost_Gunlance_Radiation_Bonus));
                    OnPropertyChanged(nameof(Capacity_Boost_Gunlance_Radiation_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long Capacity_Boost_Gunlance_Radiation_Bonus_offset { get; private set; }

            protected byte Capacity_Boost_Gunlance_Scatter_Bonus_raw;
            public const string Capacity_Boost_Gunlance_Scatter_Bonus_displayName = "Capacity Boost: Gunlance Scatter Bonus";
            public const int Capacity_Boost_Gunlance_Scatter_Bonus_sortIndex = 600;
            [SortOrder(Capacity_Boost_Gunlance_Scatter_Bonus_sortIndex)]
            [DisplayName(Capacity_Boost_Gunlance_Scatter_Bonus_displayName)]
            public virtual byte Capacity_Boost_Gunlance_Scatter_Bonus {
                get => Capacity_Boost_Gunlance_Scatter_Bonus_raw;
                set {
                    if (Capacity_Boost_Gunlance_Scatter_Bonus_raw == value) return;
                    Capacity_Boost_Gunlance_Scatter_Bonus_raw = value;
                    ChangedItems.Add(nameof(Capacity_Boost_Gunlance_Scatter_Bonus));
                    OnPropertyChanged(nameof(Capacity_Boost_Gunlance_Scatter_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long Capacity_Boost_Gunlance_Scatter_Bonus_offset { get; private set; }

            protected byte Capacity_Boost_Charge_Blade_Shield_Duration_Bonus_raw;
            public const string Capacity_Boost_Charge_Blade_Shield_Duration_Bonus_displayName = "Capacity Boost: Charge Blade Shield Duration Bonus";
            public const int Capacity_Boost_Charge_Blade_Shield_Duration_Bonus_sortIndex = 650;
            [SortOrder(Capacity_Boost_Charge_Blade_Shield_Duration_Bonus_sortIndex)]
            [DisplayName(Capacity_Boost_Charge_Blade_Shield_Duration_Bonus_displayName)]
            public virtual byte Capacity_Boost_Charge_Blade_Shield_Duration_Bonus {
                get => Capacity_Boost_Charge_Blade_Shield_Duration_Bonus_raw;
                set {
                    if (Capacity_Boost_Charge_Blade_Shield_Duration_Bonus_raw == value) return;
                    Capacity_Boost_Charge_Blade_Shield_Duration_Bonus_raw = value;
                    ChangedItems.Add(nameof(Capacity_Boost_Charge_Blade_Shield_Duration_Bonus));
                    OnPropertyChanged(nameof(Capacity_Boost_Charge_Blade_Shield_Duration_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long Capacity_Boost_Charge_Blade_Shield_Duration_Bonus_offset { get; private set; }

            public const int lastSortIndex = 700;

            public static ObservableMhwStructCollection<Skill_Params_4_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Skill_Params_4_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Skill_Params_4_ LoadData(BinaryReader reader, ulong i) {
                var data = new Skill_Params_4_();
                data.Index = i;
                data.Heavy_Artillery_Ballista_Attack_Rate_1_offset = reader.BaseStream.Position;
                data.Heavy_Artillery_Ballista_Attack_Rate_1_raw = reader.ReadSingle();
                data.Heavy_Artillery_Ballista_Attack_Rate_2_offset = reader.BaseStream.Position;
                data.Heavy_Artillery_Ballista_Attack_Rate_2_raw = reader.ReadSingle();
                data.Heavy_Artillery_Cannon_Attack_Rate_1_offset = reader.BaseStream.Position;
                data.Heavy_Artillery_Cannon_Attack_Rate_1_raw = reader.ReadSingle();
                data.Heavy_Artillery_Cannon_Attack_Rate_2_offset = reader.BaseStream.Position;
                data.Heavy_Artillery_Cannon_Attack_Rate_2_raw = reader.ReadSingle();
                data.Bombardier_Attack_Rate_1_offset = reader.BaseStream.Position;
                data.Bombardier_Attack_Rate_1_raw = reader.ReadSingle();
                data.Bombardier_Attack_Rate_2_offset = reader.BaseStream.Position;
                data.Bombardier_Attack_Rate_2_raw = reader.ReadSingle();
                data.Bombardier_Attack_Rate_3_offset = reader.BaseStream.Position;
                data.Bombardier_Attack_Rate_3_raw = reader.ReadSingle();
                data.Bombardier_Attack_Rate_4_offset = reader.BaseStream.Position;
                data.Bombardier_Attack_Rate_4_raw = reader.ReadSingle();
                data.Bombardier_Attack_Rate_5_offset = reader.BaseStream.Position;
                data.Bombardier_Attack_Rate_5_raw = reader.ReadSingle();
                data.Capacity_Boost_Gunlance_Normal_Bonus_offset = reader.BaseStream.Position;
                data.Capacity_Boost_Gunlance_Normal_Bonus_raw = reader.ReadByte();
                data.Capacity_Boost_Gunlance_Radiation_Bonus_offset = reader.BaseStream.Position;
                data.Capacity_Boost_Gunlance_Radiation_Bonus_raw = reader.ReadByte();
                data.Capacity_Boost_Gunlance_Scatter_Bonus_offset = reader.BaseStream.Position;
                data.Capacity_Boost_Gunlance_Scatter_Bonus_raw = reader.ReadByte();
                data.Capacity_Boost_Charge_Blade_Shield_Duration_Bonus_offset = reader.BaseStream.Position;
                data.Capacity_Boost_Charge_Blade_Shield_Duration_Bonus_raw = reader.ReadByte();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Heavy_Artillery_Ballista_Attack_Rate_1_raw);
                writer.Write(Heavy_Artillery_Ballista_Attack_Rate_2_raw);
                writer.Write(Heavy_Artillery_Cannon_Attack_Rate_1_raw);
                writer.Write(Heavy_Artillery_Cannon_Attack_Rate_2_raw);
                writer.Write(Bombardier_Attack_Rate_1_raw);
                writer.Write(Bombardier_Attack_Rate_2_raw);
                writer.Write(Bombardier_Attack_Rate_3_raw);
                writer.Write(Bombardier_Attack_Rate_4_raw);
                writer.Write(Bombardier_Attack_Rate_5_raw);
                writer.Write(Capacity_Boost_Gunlance_Normal_Bonus_raw);
                writer.Write(Capacity_Boost_Gunlance_Radiation_Bonus_raw);
                writer.Write(Capacity_Boost_Gunlance_Scatter_Bonus_raw);
                writer.Write(Capacity_Boost_Charge_Blade_Shield_Duration_Bonus_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Heavy Artillery: Ballista Attack Rate 1", "Heavy_Artillery_Ballista_Attack_Rate_1", "Heavy_Artillery_Ballista_Attack_Rate_1_offset"),
                    new MultiStructItemCustomView(this, "Heavy Artillery: Ballista Attack Rate 2", "Heavy_Artillery_Ballista_Attack_Rate_2", "Heavy_Artillery_Ballista_Attack_Rate_2_offset"),
                    new MultiStructItemCustomView(this, "Heavy Artillery: Cannon Attack Rate 1", "Heavy_Artillery_Cannon_Attack_Rate_1", "Heavy_Artillery_Cannon_Attack_Rate_1_offset"),
                    new MultiStructItemCustomView(this, "Heavy Artillery: Cannon Attack Rate 2", "Heavy_Artillery_Cannon_Attack_Rate_2", "Heavy_Artillery_Cannon_Attack_Rate_2_offset"),
                    new MultiStructItemCustomView(this, "Bombardier: Attack Rate 1", "Bombardier_Attack_Rate_1", "Bombardier_Attack_Rate_1_offset"),
                    new MultiStructItemCustomView(this, "Bombardier: Attack Rate 2", "Bombardier_Attack_Rate_2", "Bombardier_Attack_Rate_2_offset"),
                    new MultiStructItemCustomView(this, "Bombardier: Attack Rate 3", "Bombardier_Attack_Rate_3", "Bombardier_Attack_Rate_3_offset"),
                    new MultiStructItemCustomView(this, "Bombardier: Attack Rate 4", "Bombardier_Attack_Rate_4", "Bombardier_Attack_Rate_4_offset"),
                    new MultiStructItemCustomView(this, "Bombardier: Attack Rate 5", "Bombardier_Attack_Rate_5", "Bombardier_Attack_Rate_5_offset"),
                    new MultiStructItemCustomView(this, "Capacity Boost: Gunlance Normal Bonus", "Capacity_Boost_Gunlance_Normal_Bonus", "Capacity_Boost_Gunlance_Normal_Bonus_offset"),
                    new MultiStructItemCustomView(this, "Capacity Boost: Gunlance Radiation Bonus", "Capacity_Boost_Gunlance_Radiation_Bonus", "Capacity_Boost_Gunlance_Radiation_Bonus_offset"),
                    new MultiStructItemCustomView(this, "Capacity Boost: Gunlance Scatter Bonus", "Capacity_Boost_Gunlance_Scatter_Bonus", "Capacity_Boost_Gunlance_Scatter_Bonus_offset"),
                    new MultiStructItemCustomView(this, "Capacity Boost: Charge Blade Shield Duration Bonus", "Capacity_Boost_Charge_Blade_Shield_Duration_Bonus", "Capacity_Boost_Charge_Blade_Shield_Duration_Bonus_offset"),
                };
            }
        }

        public partial class Ammo_Up : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 3;
            public const string GridName = "Ammo Up";

            protected sbyte Capacity_1_Limit_raw;
            public const string Capacity_1_Limit_displayName = "Capacity 1 Limit";
            public const int Capacity_1_Limit_sortIndex = 50;
            [SortOrder(Capacity_1_Limit_sortIndex)]
            [DisplayName(Capacity_1_Limit_displayName)]
            public virtual sbyte Capacity_1_Limit {
                get => Capacity_1_Limit_raw;
                set {
                    if (Capacity_1_Limit_raw == value) return;
                    Capacity_1_Limit_raw = value;
                    ChangedItems.Add(nameof(Capacity_1_Limit));
                    OnPropertyChanged(nameof(Capacity_1_Limit));
                }
            }

            protected byte Capacity_1_Bonus_raw;
            public const string Capacity_1_Bonus_displayName = "Capacity 1 Bonus";
            public const int Capacity_1_Bonus_sortIndex = 100;
            [SortOrder(Capacity_1_Bonus_sortIndex)]
            [DisplayName(Capacity_1_Bonus_displayName)]
            public virtual byte Capacity_1_Bonus {
                get => Capacity_1_Bonus_raw;
                set {
                    if (Capacity_1_Bonus_raw == value) return;
                    Capacity_1_Bonus_raw = value;
                    ChangedItems.Add(nameof(Capacity_1_Bonus));
                    OnPropertyChanged(nameof(Capacity_1_Bonus));
                }
            }

            protected sbyte Capacity_2_Limit_raw;
            public const string Capacity_2_Limit_displayName = "Capacity 2 Limit";
            public const int Capacity_2_Limit_sortIndex = 150;
            [SortOrder(Capacity_2_Limit_sortIndex)]
            [DisplayName(Capacity_2_Limit_displayName)]
            public virtual sbyte Capacity_2_Limit {
                get => Capacity_2_Limit_raw;
                set {
                    if (Capacity_2_Limit_raw == value) return;
                    Capacity_2_Limit_raw = value;
                    ChangedItems.Add(nameof(Capacity_2_Limit));
                    OnPropertyChanged(nameof(Capacity_2_Limit));
                }
            }

            protected byte Capacity_2_Bonus_raw;
            public const string Capacity_2_Bonus_displayName = "Capacity 2 Bonus";
            public const int Capacity_2_Bonus_sortIndex = 200;
            [SortOrder(Capacity_2_Bonus_sortIndex)]
            [DisplayName(Capacity_2_Bonus_displayName)]
            public virtual byte Capacity_2_Bonus {
                get => Capacity_2_Bonus_raw;
                set {
                    if (Capacity_2_Bonus_raw == value) return;
                    Capacity_2_Bonus_raw = value;
                    ChangedItems.Add(nameof(Capacity_2_Bonus));
                    OnPropertyChanged(nameof(Capacity_2_Bonus));
                }
            }

            protected sbyte Capacity_3_Limit_raw;
            public const string Capacity_3_Limit_displayName = "Capacity 3 Limit";
            public const int Capacity_3_Limit_sortIndex = 250;
            [SortOrder(Capacity_3_Limit_sortIndex)]
            [DisplayName(Capacity_3_Limit_displayName)]
            public virtual sbyte Capacity_3_Limit {
                get => Capacity_3_Limit_raw;
                set {
                    if (Capacity_3_Limit_raw == value) return;
                    Capacity_3_Limit_raw = value;
                    ChangedItems.Add(nameof(Capacity_3_Limit));
                    OnPropertyChanged(nameof(Capacity_3_Limit));
                }
            }

            protected byte Capacity_3_Bonus_raw;
            public const string Capacity_3_Bonus_displayName = "Capacity 3 Bonus";
            public const int Capacity_3_Bonus_sortIndex = 300;
            [SortOrder(Capacity_3_Bonus_sortIndex)]
            [DisplayName(Capacity_3_Bonus_displayName)]
            public virtual byte Capacity_3_Bonus {
                get => Capacity_3_Bonus_raw;
                set {
                    if (Capacity_3_Bonus_raw == value) return;
                    Capacity_3_Bonus_raw = value;
                    ChangedItems.Add(nameof(Capacity_3_Bonus));
                    OnPropertyChanged(nameof(Capacity_3_Bonus));
                }
            }

            protected sbyte Capacity_4_Limit_raw;
            public const string Capacity_4_Limit_displayName = "Capacity 4 Limit";
            public const int Capacity_4_Limit_sortIndex = 350;
            [SortOrder(Capacity_4_Limit_sortIndex)]
            [DisplayName(Capacity_4_Limit_displayName)]
            public virtual sbyte Capacity_4_Limit {
                get => Capacity_4_Limit_raw;
                set {
                    if (Capacity_4_Limit_raw == value) return;
                    Capacity_4_Limit_raw = value;
                    ChangedItems.Add(nameof(Capacity_4_Limit));
                    OnPropertyChanged(nameof(Capacity_4_Limit));
                }
            }

            protected byte Capacity_4_Bonus_raw;
            public const string Capacity_4_Bonus_displayName = "Capacity 4 Bonus";
            public const int Capacity_4_Bonus_sortIndex = 400;
            [SortOrder(Capacity_4_Bonus_sortIndex)]
            [DisplayName(Capacity_4_Bonus_displayName)]
            public virtual byte Capacity_4_Bonus {
                get => Capacity_4_Bonus_raw;
                set {
                    if (Capacity_4_Bonus_raw == value) return;
                    Capacity_4_Bonus_raw = value;
                    ChangedItems.Add(nameof(Capacity_4_Bonus));
                    OnPropertyChanged(nameof(Capacity_4_Bonus));
                }
            }

            public const int lastSortIndex = 450;

            public static ObservableMhwStructCollection<Ammo_Up> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Ammo_Up>();
                const ulong count = 3UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Ammo_Up LoadData(BinaryReader reader, ulong i) {
                var data = new Ammo_Up();
                data.Index = i;
                data.Capacity_1_Limit_raw = reader.ReadSByte();
                data.Capacity_1_Bonus_raw = reader.ReadByte();
                data.Capacity_2_Limit_raw = reader.ReadSByte();
                data.Capacity_2_Bonus_raw = reader.ReadByte();
                data.Capacity_3_Limit_raw = reader.ReadSByte();
                data.Capacity_3_Bonus_raw = reader.ReadByte();
                data.Capacity_4_Limit_raw = reader.ReadSByte();
                data.Capacity_4_Bonus_raw = reader.ReadByte();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Capacity_1_Limit_raw);
                writer.Write(Capacity_1_Bonus_raw);
                writer.Write(Capacity_2_Limit_raw);
                writer.Write(Capacity_2_Bonus_raw);
                writer.Write(Capacity_3_Limit_raw);
                writer.Write(Capacity_3_Bonus_raw);
                writer.Write(Capacity_4_Limit_raw);
                writer.Write(Capacity_4_Bonus_raw);
            }
        }

        public partial class Power_Prolonger : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 5;
            public const string GridName = "Power Prolonger";

            protected float Level_1_raw;
            public const string Level_1_displayName = "Level 1";
            public const int Level_1_sortIndex = 50;
            [SortOrder(Level_1_sortIndex)]
            [DisplayName(Level_1_displayName)]
            public virtual float Level_1 {
                get => Level_1_raw;
                set {
                    if (Level_1_raw == value) return;
                    Level_1_raw = value;
                    ChangedItems.Add(nameof(Level_1));
                    OnPropertyChanged(nameof(Level_1));
                }
            }

            protected float Level_2_raw;
            public const string Level_2_displayName = "Level 2";
            public const int Level_2_sortIndex = 100;
            [SortOrder(Level_2_sortIndex)]
            [DisplayName(Level_2_displayName)]
            public virtual float Level_2 {
                get => Level_2_raw;
                set {
                    if (Level_2_raw == value) return;
                    Level_2_raw = value;
                    ChangedItems.Add(nameof(Level_2));
                    OnPropertyChanged(nameof(Level_2));
                }
            }

            protected float Level_3_raw;
            public const string Level_3_displayName = "Level 3";
            public const int Level_3_sortIndex = 150;
            [SortOrder(Level_3_sortIndex)]
            [DisplayName(Level_3_displayName)]
            public virtual float Level_3 {
                get => Level_3_raw;
                set {
                    if (Level_3_raw == value) return;
                    Level_3_raw = value;
                    ChangedItems.Add(nameof(Level_3));
                    OnPropertyChanged(nameof(Level_3));
                }
            }

            public const int lastSortIndex = 200;

            public static ObservableMhwStructCollection<Power_Prolonger> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Power_Prolonger>();
                const ulong count = 5UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Power_Prolonger LoadData(BinaryReader reader, ulong i) {
                var data = new Power_Prolonger();
                data.Index = i;
                data.Level_1_raw = reader.ReadSingle();
                data.Level_2_raw = reader.ReadSingle();
                data.Level_3_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Level_1_raw);
                writer.Write(Level_2_raw);
                writer.Write(Level_3_raw);
            }
        }

        public partial class Skill_Params_5_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Skill Params (5)";

            protected float Health_Auto_Recover_Interval_raw;
            public const string Health_Auto_Recover_Interval_displayName = "Health Auto Recover Interval";
            public const int Health_Auto_Recover_Interval_sortIndex = 50;
            [SortOrder(Health_Auto_Recover_Interval_sortIndex)]
            [DisplayName(Health_Auto_Recover_Interval_displayName)]
            public virtual float Health_Auto_Recover_Interval {
                get => Health_Auto_Recover_Interval_raw;
                set {
                    if (Health_Auto_Recover_Interval_raw == value) return;
                    Health_Auto_Recover_Interval_raw = value;
                    ChangedItems.Add(nameof(Health_Auto_Recover_Interval));
                    OnPropertyChanged(nameof(Health_Auto_Recover_Interval));
                }
            }

            [DisplayName("Offset")]
            public long Health_Auto_Recover_Interval_offset { get; private set; }

            protected byte Health_Auto_Recover_Value_raw;
            public const string Health_Auto_Recover_Value_displayName = "Health Auto Recover Value";
            public const int Health_Auto_Recover_Value_sortIndex = 100;
            [SortOrder(Health_Auto_Recover_Value_sortIndex)]
            [DisplayName(Health_Auto_Recover_Value_displayName)]
            public virtual byte Health_Auto_Recover_Value {
                get => Health_Auto_Recover_Value_raw;
                set {
                    if (Health_Auto_Recover_Value_raw == value) return;
                    Health_Auto_Recover_Value_raw = value;
                    ChangedItems.Add(nameof(Health_Auto_Recover_Value));
                    OnPropertyChanged(nameof(Health_Auto_Recover_Value));
                }
            }

            [DisplayName("Offset")]
            public long Health_Auto_Recover_Value_offset { get; private set; }

            protected byte Hasten_Recovery_Great_Sword_Recovery_Health_raw;
            public const string Hasten_Recovery_Great_Sword_Recovery_Health_displayName = "Hasten Recovery: (Great Sword) Recovery Health";
            public const int Hasten_Recovery_Great_Sword_Recovery_Health_sortIndex = 150;
            [SortOrder(Hasten_Recovery_Great_Sword_Recovery_Health_sortIndex)]
            [DisplayName(Hasten_Recovery_Great_Sword_Recovery_Health_displayName)]
            public virtual byte Hasten_Recovery_Great_Sword_Recovery_Health {
                get => Hasten_Recovery_Great_Sword_Recovery_Health_raw;
                set {
                    if (Hasten_Recovery_Great_Sword_Recovery_Health_raw == value) return;
                    Hasten_Recovery_Great_Sword_Recovery_Health_raw = value;
                    ChangedItems.Add(nameof(Hasten_Recovery_Great_Sword_Recovery_Health));
                    OnPropertyChanged(nameof(Hasten_Recovery_Great_Sword_Recovery_Health));
                }
            }

            [DisplayName("Offset")]
            public long Hasten_Recovery_Great_Sword_Recovery_Health_offset { get; private set; }

            protected byte Hasten_Recovery_Sword_Shield_Recovery_Health_raw;
            public const string Hasten_Recovery_Sword_Shield_Recovery_Health_displayName = "Hasten Recovery: (Sword & Shield) Recovery Health";
            public const int Hasten_Recovery_Sword_Shield_Recovery_Health_sortIndex = 200;
            [SortOrder(Hasten_Recovery_Sword_Shield_Recovery_Health_sortIndex)]
            [DisplayName(Hasten_Recovery_Sword_Shield_Recovery_Health_displayName)]
            public virtual byte Hasten_Recovery_Sword_Shield_Recovery_Health {
                get => Hasten_Recovery_Sword_Shield_Recovery_Health_raw;
                set {
                    if (Hasten_Recovery_Sword_Shield_Recovery_Health_raw == value) return;
                    Hasten_Recovery_Sword_Shield_Recovery_Health_raw = value;
                    ChangedItems.Add(nameof(Hasten_Recovery_Sword_Shield_Recovery_Health));
                    OnPropertyChanged(nameof(Hasten_Recovery_Sword_Shield_Recovery_Health));
                }
            }

            [DisplayName("Offset")]
            public long Hasten_Recovery_Sword_Shield_Recovery_Health_offset { get; private set; }

            protected byte Hasten_Recovery_Dual_Blades_Recovery_Health_raw;
            public const string Hasten_Recovery_Dual_Blades_Recovery_Health_displayName = "Hasten Recovery: (Dual Blades) Recovery Health";
            public const int Hasten_Recovery_Dual_Blades_Recovery_Health_sortIndex = 250;
            [SortOrder(Hasten_Recovery_Dual_Blades_Recovery_Health_sortIndex)]
            [DisplayName(Hasten_Recovery_Dual_Blades_Recovery_Health_displayName)]
            public virtual byte Hasten_Recovery_Dual_Blades_Recovery_Health {
                get => Hasten_Recovery_Dual_Blades_Recovery_Health_raw;
                set {
                    if (Hasten_Recovery_Dual_Blades_Recovery_Health_raw == value) return;
                    Hasten_Recovery_Dual_Blades_Recovery_Health_raw = value;
                    ChangedItems.Add(nameof(Hasten_Recovery_Dual_Blades_Recovery_Health));
                    OnPropertyChanged(nameof(Hasten_Recovery_Dual_Blades_Recovery_Health));
                }
            }

            [DisplayName("Offset")]
            public long Hasten_Recovery_Dual_Blades_Recovery_Health_offset { get; private set; }

            protected byte Hasten_Recovery_Long_Sword_Recovery_Health_raw;
            public const string Hasten_Recovery_Long_Sword_Recovery_Health_displayName = "Hasten Recovery: (Long Sword) Recovery Health";
            public const int Hasten_Recovery_Long_Sword_Recovery_Health_sortIndex = 300;
            [SortOrder(Hasten_Recovery_Long_Sword_Recovery_Health_sortIndex)]
            [DisplayName(Hasten_Recovery_Long_Sword_Recovery_Health_displayName)]
            public virtual byte Hasten_Recovery_Long_Sword_Recovery_Health {
                get => Hasten_Recovery_Long_Sword_Recovery_Health_raw;
                set {
                    if (Hasten_Recovery_Long_Sword_Recovery_Health_raw == value) return;
                    Hasten_Recovery_Long_Sword_Recovery_Health_raw = value;
                    ChangedItems.Add(nameof(Hasten_Recovery_Long_Sword_Recovery_Health));
                    OnPropertyChanged(nameof(Hasten_Recovery_Long_Sword_Recovery_Health));
                }
            }

            [DisplayName("Offset")]
            public long Hasten_Recovery_Long_Sword_Recovery_Health_offset { get; private set; }

            protected byte Hasten_Recovery_Hammer_Recovery_Health_raw;
            public const string Hasten_Recovery_Hammer_Recovery_Health_displayName = "Hasten Recovery: (Hammer) Recovery Health";
            public const int Hasten_Recovery_Hammer_Recovery_Health_sortIndex = 350;
            [SortOrder(Hasten_Recovery_Hammer_Recovery_Health_sortIndex)]
            [DisplayName(Hasten_Recovery_Hammer_Recovery_Health_displayName)]
            public virtual byte Hasten_Recovery_Hammer_Recovery_Health {
                get => Hasten_Recovery_Hammer_Recovery_Health_raw;
                set {
                    if (Hasten_Recovery_Hammer_Recovery_Health_raw == value) return;
                    Hasten_Recovery_Hammer_Recovery_Health_raw = value;
                    ChangedItems.Add(nameof(Hasten_Recovery_Hammer_Recovery_Health));
                    OnPropertyChanged(nameof(Hasten_Recovery_Hammer_Recovery_Health));
                }
            }

            [DisplayName("Offset")]
            public long Hasten_Recovery_Hammer_Recovery_Health_offset { get; private set; }

            protected byte Hasten_Recovery_Hunting_Horn_Recovery_Health_raw;
            public const string Hasten_Recovery_Hunting_Horn_Recovery_Health_displayName = "Hasten Recovery: (Hunting Horn) Recovery Health";
            public const int Hasten_Recovery_Hunting_Horn_Recovery_Health_sortIndex = 400;
            [SortOrder(Hasten_Recovery_Hunting_Horn_Recovery_Health_sortIndex)]
            [DisplayName(Hasten_Recovery_Hunting_Horn_Recovery_Health_displayName)]
            public virtual byte Hasten_Recovery_Hunting_Horn_Recovery_Health {
                get => Hasten_Recovery_Hunting_Horn_Recovery_Health_raw;
                set {
                    if (Hasten_Recovery_Hunting_Horn_Recovery_Health_raw == value) return;
                    Hasten_Recovery_Hunting_Horn_Recovery_Health_raw = value;
                    ChangedItems.Add(nameof(Hasten_Recovery_Hunting_Horn_Recovery_Health));
                    OnPropertyChanged(nameof(Hasten_Recovery_Hunting_Horn_Recovery_Health));
                }
            }

            [DisplayName("Offset")]
            public long Hasten_Recovery_Hunting_Horn_Recovery_Health_offset { get; private set; }

            protected byte Hasten_Recovery_Lance_Recovery_Health_raw;
            public const string Hasten_Recovery_Lance_Recovery_Health_displayName = "Hasten Recovery: (Lance) Recovery Health";
            public const int Hasten_Recovery_Lance_Recovery_Health_sortIndex = 450;
            [SortOrder(Hasten_Recovery_Lance_Recovery_Health_sortIndex)]
            [DisplayName(Hasten_Recovery_Lance_Recovery_Health_displayName)]
            public virtual byte Hasten_Recovery_Lance_Recovery_Health {
                get => Hasten_Recovery_Lance_Recovery_Health_raw;
                set {
                    if (Hasten_Recovery_Lance_Recovery_Health_raw == value) return;
                    Hasten_Recovery_Lance_Recovery_Health_raw = value;
                    ChangedItems.Add(nameof(Hasten_Recovery_Lance_Recovery_Health));
                    OnPropertyChanged(nameof(Hasten_Recovery_Lance_Recovery_Health));
                }
            }

            [DisplayName("Offset")]
            public long Hasten_Recovery_Lance_Recovery_Health_offset { get; private set; }

            protected byte Hasten_Recovery_Gunlance_Recovery_Health_raw;
            public const string Hasten_Recovery_Gunlance_Recovery_Health_displayName = "Hasten Recovery: (Gunlance) Recovery Health";
            public const int Hasten_Recovery_Gunlance_Recovery_Health_sortIndex = 500;
            [SortOrder(Hasten_Recovery_Gunlance_Recovery_Health_sortIndex)]
            [DisplayName(Hasten_Recovery_Gunlance_Recovery_Health_displayName)]
            public virtual byte Hasten_Recovery_Gunlance_Recovery_Health {
                get => Hasten_Recovery_Gunlance_Recovery_Health_raw;
                set {
                    if (Hasten_Recovery_Gunlance_Recovery_Health_raw == value) return;
                    Hasten_Recovery_Gunlance_Recovery_Health_raw = value;
                    ChangedItems.Add(nameof(Hasten_Recovery_Gunlance_Recovery_Health));
                    OnPropertyChanged(nameof(Hasten_Recovery_Gunlance_Recovery_Health));
                }
            }

            [DisplayName("Offset")]
            public long Hasten_Recovery_Gunlance_Recovery_Health_offset { get; private set; }

            protected byte Hasten_Recovery_Switch_Axe_Recovery_Health_raw;
            public const string Hasten_Recovery_Switch_Axe_Recovery_Health_displayName = "Hasten Recovery: (Switch Axe) Recovery Health";
            public const int Hasten_Recovery_Switch_Axe_Recovery_Health_sortIndex = 550;
            [SortOrder(Hasten_Recovery_Switch_Axe_Recovery_Health_sortIndex)]
            [DisplayName(Hasten_Recovery_Switch_Axe_Recovery_Health_displayName)]
            public virtual byte Hasten_Recovery_Switch_Axe_Recovery_Health {
                get => Hasten_Recovery_Switch_Axe_Recovery_Health_raw;
                set {
                    if (Hasten_Recovery_Switch_Axe_Recovery_Health_raw == value) return;
                    Hasten_Recovery_Switch_Axe_Recovery_Health_raw = value;
                    ChangedItems.Add(nameof(Hasten_Recovery_Switch_Axe_Recovery_Health));
                    OnPropertyChanged(nameof(Hasten_Recovery_Switch_Axe_Recovery_Health));
                }
            }

            [DisplayName("Offset")]
            public long Hasten_Recovery_Switch_Axe_Recovery_Health_offset { get; private set; }

            protected byte Hasten_Recovery_Charge_Blade_Recovery_Health_raw;
            public const string Hasten_Recovery_Charge_Blade_Recovery_Health_displayName = "Hasten Recovery: (Charge Blade) Recovery Health";
            public const int Hasten_Recovery_Charge_Blade_Recovery_Health_sortIndex = 600;
            [SortOrder(Hasten_Recovery_Charge_Blade_Recovery_Health_sortIndex)]
            [DisplayName(Hasten_Recovery_Charge_Blade_Recovery_Health_displayName)]
            public virtual byte Hasten_Recovery_Charge_Blade_Recovery_Health {
                get => Hasten_Recovery_Charge_Blade_Recovery_Health_raw;
                set {
                    if (Hasten_Recovery_Charge_Blade_Recovery_Health_raw == value) return;
                    Hasten_Recovery_Charge_Blade_Recovery_Health_raw = value;
                    ChangedItems.Add(nameof(Hasten_Recovery_Charge_Blade_Recovery_Health));
                    OnPropertyChanged(nameof(Hasten_Recovery_Charge_Blade_Recovery_Health));
                }
            }

            [DisplayName("Offset")]
            public long Hasten_Recovery_Charge_Blade_Recovery_Health_offset { get; private set; }

            protected byte Hasten_Recovery_Insect_Glaive_Recovery_Health_raw;
            public const string Hasten_Recovery_Insect_Glaive_Recovery_Health_displayName = "Hasten Recovery: (Insect Glaive) Recovery Health";
            public const int Hasten_Recovery_Insect_Glaive_Recovery_Health_sortIndex = 650;
            [SortOrder(Hasten_Recovery_Insect_Glaive_Recovery_Health_sortIndex)]
            [DisplayName(Hasten_Recovery_Insect_Glaive_Recovery_Health_displayName)]
            public virtual byte Hasten_Recovery_Insect_Glaive_Recovery_Health {
                get => Hasten_Recovery_Insect_Glaive_Recovery_Health_raw;
                set {
                    if (Hasten_Recovery_Insect_Glaive_Recovery_Health_raw == value) return;
                    Hasten_Recovery_Insect_Glaive_Recovery_Health_raw = value;
                    ChangedItems.Add(nameof(Hasten_Recovery_Insect_Glaive_Recovery_Health));
                    OnPropertyChanged(nameof(Hasten_Recovery_Insect_Glaive_Recovery_Health));
                }
            }

            [DisplayName("Offset")]
            public long Hasten_Recovery_Insect_Glaive_Recovery_Health_offset { get; private set; }

            protected byte Hasten_Recovery_Bow_Recovery_Health_raw;
            public const string Hasten_Recovery_Bow_Recovery_Health_displayName = "Hasten Recovery: (Bow) Recovery Health";
            public const int Hasten_Recovery_Bow_Recovery_Health_sortIndex = 700;
            [SortOrder(Hasten_Recovery_Bow_Recovery_Health_sortIndex)]
            [DisplayName(Hasten_Recovery_Bow_Recovery_Health_displayName)]
            public virtual byte Hasten_Recovery_Bow_Recovery_Health {
                get => Hasten_Recovery_Bow_Recovery_Health_raw;
                set {
                    if (Hasten_Recovery_Bow_Recovery_Health_raw == value) return;
                    Hasten_Recovery_Bow_Recovery_Health_raw = value;
                    ChangedItems.Add(nameof(Hasten_Recovery_Bow_Recovery_Health));
                    OnPropertyChanged(nameof(Hasten_Recovery_Bow_Recovery_Health));
                }
            }

            [DisplayName("Offset")]
            public long Hasten_Recovery_Bow_Recovery_Health_offset { get; private set; }

            protected byte Hasten_Recovery_HBG_Recovery_Health_raw;
            public const string Hasten_Recovery_HBG_Recovery_Health_displayName = "Hasten Recovery: (HBG) Recovery Health";
            public const int Hasten_Recovery_HBG_Recovery_Health_sortIndex = 750;
            [SortOrder(Hasten_Recovery_HBG_Recovery_Health_sortIndex)]
            [DisplayName(Hasten_Recovery_HBG_Recovery_Health_displayName)]
            public virtual byte Hasten_Recovery_HBG_Recovery_Health {
                get => Hasten_Recovery_HBG_Recovery_Health_raw;
                set {
                    if (Hasten_Recovery_HBG_Recovery_Health_raw == value) return;
                    Hasten_Recovery_HBG_Recovery_Health_raw = value;
                    ChangedItems.Add(nameof(Hasten_Recovery_HBG_Recovery_Health));
                    OnPropertyChanged(nameof(Hasten_Recovery_HBG_Recovery_Health));
                }
            }

            [DisplayName("Offset")]
            public long Hasten_Recovery_HBG_Recovery_Health_offset { get; private set; }

            protected byte Hasten_Recovery_LBG_Recovery_Health_raw;
            public const string Hasten_Recovery_LBG_Recovery_Health_displayName = "Hasten Recovery: (LBG) Recovery Health";
            public const int Hasten_Recovery_LBG_Recovery_Health_sortIndex = 800;
            [SortOrder(Hasten_Recovery_LBG_Recovery_Health_sortIndex)]
            [DisplayName(Hasten_Recovery_LBG_Recovery_Health_displayName)]
            public virtual byte Hasten_Recovery_LBG_Recovery_Health {
                get => Hasten_Recovery_LBG_Recovery_Health_raw;
                set {
                    if (Hasten_Recovery_LBG_Recovery_Health_raw == value) return;
                    Hasten_Recovery_LBG_Recovery_Health_raw = value;
                    ChangedItems.Add(nameof(Hasten_Recovery_LBG_Recovery_Health));
                    OnPropertyChanged(nameof(Hasten_Recovery_LBG_Recovery_Health));
                }
            }

            [DisplayName("Offset")]
            public long Hasten_Recovery_LBG_Recovery_Health_offset { get; private set; }

            protected byte Hasten_Recovery_Success_Combo__raw;
            public const string Hasten_Recovery_Success_Combo__displayName = "Hasten Recovery: Success Combo #";
            public const int Hasten_Recovery_Success_Combo__sortIndex = 850;
            [SortOrder(Hasten_Recovery_Success_Combo__sortIndex)]
            [DisplayName(Hasten_Recovery_Success_Combo__displayName)]
            public virtual byte Hasten_Recovery_Success_Combo_ {
                get => Hasten_Recovery_Success_Combo__raw;
                set {
                    if (Hasten_Recovery_Success_Combo__raw == value) return;
                    Hasten_Recovery_Success_Combo__raw = value;
                    ChangedItems.Add(nameof(Hasten_Recovery_Success_Combo_));
                    OnPropertyChanged(nameof(Hasten_Recovery_Success_Combo_));
                }
            }

            [DisplayName("Offset")]
            public long Hasten_Recovery_Success_Combo__offset { get; private set; }

            protected float Hasten_Recovery_Combo_Duration_raw;
            public const string Hasten_Recovery_Combo_Duration_displayName = "Hasten Recovery: Combo Duration";
            public const int Hasten_Recovery_Combo_Duration_sortIndex = 900;
            [SortOrder(Hasten_Recovery_Combo_Duration_sortIndex)]
            [DisplayName(Hasten_Recovery_Combo_Duration_displayName)]
            public virtual float Hasten_Recovery_Combo_Duration {
                get => Hasten_Recovery_Combo_Duration_raw;
                set {
                    if (Hasten_Recovery_Combo_Duration_raw == value) return;
                    Hasten_Recovery_Combo_Duration_raw = value;
                    ChangedItems.Add(nameof(Hasten_Recovery_Combo_Duration));
                    OnPropertyChanged(nameof(Hasten_Recovery_Combo_Duration));
                }
            }

            [DisplayName("Offset")]
            public long Hasten_Recovery_Combo_Duration_offset { get; private set; }

            protected float Hasten_Recovery_Combo_Ignore_Time_raw;
            public const string Hasten_Recovery_Combo_Ignore_Time_displayName = "Hasten Recovery: Combo Ignore Time";
            public const int Hasten_Recovery_Combo_Ignore_Time_sortIndex = 950;
            [SortOrder(Hasten_Recovery_Combo_Ignore_Time_sortIndex)]
            [DisplayName(Hasten_Recovery_Combo_Ignore_Time_displayName)]
            public virtual float Hasten_Recovery_Combo_Ignore_Time {
                get => Hasten_Recovery_Combo_Ignore_Time_raw;
                set {
                    if (Hasten_Recovery_Combo_Ignore_Time_raw == value) return;
                    Hasten_Recovery_Combo_Ignore_Time_raw = value;
                    ChangedItems.Add(nameof(Hasten_Recovery_Combo_Ignore_Time));
                    OnPropertyChanged(nameof(Hasten_Recovery_Combo_Ignore_Time));
                }
            }

            [DisplayName("Offset")]
            public long Hasten_Recovery_Combo_Ignore_Time_offset { get; private set; }

            protected byte _True_Element_Acceleration_Success_Combo__raw;
            public const string _True_Element_Acceleration_Success_Combo__displayName = "(True) Element Acceleration: Success Combo #";
            public const int _True_Element_Acceleration_Success_Combo__sortIndex = 1000;
            [SortOrder(_True_Element_Acceleration_Success_Combo__sortIndex)]
            [DisplayName(_True_Element_Acceleration_Success_Combo__displayName)]
            public virtual byte _True_Element_Acceleration_Success_Combo_ {
                get => _True_Element_Acceleration_Success_Combo__raw;
                set {
                    if (_True_Element_Acceleration_Success_Combo__raw == value) return;
                    _True_Element_Acceleration_Success_Combo__raw = value;
                    ChangedItems.Add(nameof(_True_Element_Acceleration_Success_Combo_));
                    OnPropertyChanged(nameof(_True_Element_Acceleration_Success_Combo_));
                }
            }

            [DisplayName("Offset")]
            public long _True_Element_Acceleration_Success_Combo__offset { get; private set; }

            protected float _True_Element_Acceleration_Combo_Duration_raw;
            public const string _True_Element_Acceleration_Combo_Duration_displayName = "(True) Element Acceleration: Combo Duration";
            public const int _True_Element_Acceleration_Combo_Duration_sortIndex = 1050;
            [SortOrder(_True_Element_Acceleration_Combo_Duration_sortIndex)]
            [DisplayName(_True_Element_Acceleration_Combo_Duration_displayName)]
            public virtual float _True_Element_Acceleration_Combo_Duration {
                get => _True_Element_Acceleration_Combo_Duration_raw;
                set {
                    if (_True_Element_Acceleration_Combo_Duration_raw == value) return;
                    _True_Element_Acceleration_Combo_Duration_raw = value;
                    ChangedItems.Add(nameof(_True_Element_Acceleration_Combo_Duration));
                    OnPropertyChanged(nameof(_True_Element_Acceleration_Combo_Duration));
                }
            }

            [DisplayName("Offset")]
            public long _True_Element_Acceleration_Combo_Duration_offset { get; private set; }

            protected float _True_Element_Acceleration_Combo_Ignore_Time__raw;
            public const string _True_Element_Acceleration_Combo_Ignore_Time__displayName = "(True) Element Acceleration: Combo Ignore Time)";
            public const int _True_Element_Acceleration_Combo_Ignore_Time__sortIndex = 1100;
            [SortOrder(_True_Element_Acceleration_Combo_Ignore_Time__sortIndex)]
            [DisplayName(_True_Element_Acceleration_Combo_Ignore_Time__displayName)]
            public virtual float _True_Element_Acceleration_Combo_Ignore_Time_ {
                get => _True_Element_Acceleration_Combo_Ignore_Time__raw;
                set {
                    if (_True_Element_Acceleration_Combo_Ignore_Time__raw == value) return;
                    _True_Element_Acceleration_Combo_Ignore_Time__raw = value;
                    ChangedItems.Add(nameof(_True_Element_Acceleration_Combo_Ignore_Time_));
                    OnPropertyChanged(nameof(_True_Element_Acceleration_Combo_Ignore_Time_));
                }
            }

            [DisplayName("Offset")]
            public long _True_Element_Acceleration_Combo_Ignore_Time__offset { get; private set; }

            public const int lastSortIndex = 1150;

            public static ObservableMhwStructCollection<Skill_Params_5_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Skill_Params_5_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Skill_Params_5_ LoadData(BinaryReader reader, ulong i) {
                var data = new Skill_Params_5_();
                data.Index = i;
                data.Health_Auto_Recover_Interval_offset = reader.BaseStream.Position;
                data.Health_Auto_Recover_Interval_raw = reader.ReadSingle();
                data.Health_Auto_Recover_Value_offset = reader.BaseStream.Position;
                data.Health_Auto_Recover_Value_raw = reader.ReadByte();
                data.Hasten_Recovery_Great_Sword_Recovery_Health_offset = reader.BaseStream.Position;
                data.Hasten_Recovery_Great_Sword_Recovery_Health_raw = reader.ReadByte();
                data.Hasten_Recovery_Sword_Shield_Recovery_Health_offset = reader.BaseStream.Position;
                data.Hasten_Recovery_Sword_Shield_Recovery_Health_raw = reader.ReadByte();
                data.Hasten_Recovery_Dual_Blades_Recovery_Health_offset = reader.BaseStream.Position;
                data.Hasten_Recovery_Dual_Blades_Recovery_Health_raw = reader.ReadByte();
                data.Hasten_Recovery_Long_Sword_Recovery_Health_offset = reader.BaseStream.Position;
                data.Hasten_Recovery_Long_Sword_Recovery_Health_raw = reader.ReadByte();
                data.Hasten_Recovery_Hammer_Recovery_Health_offset = reader.BaseStream.Position;
                data.Hasten_Recovery_Hammer_Recovery_Health_raw = reader.ReadByte();
                data.Hasten_Recovery_Hunting_Horn_Recovery_Health_offset = reader.BaseStream.Position;
                data.Hasten_Recovery_Hunting_Horn_Recovery_Health_raw = reader.ReadByte();
                data.Hasten_Recovery_Lance_Recovery_Health_offset = reader.BaseStream.Position;
                data.Hasten_Recovery_Lance_Recovery_Health_raw = reader.ReadByte();
                data.Hasten_Recovery_Gunlance_Recovery_Health_offset = reader.BaseStream.Position;
                data.Hasten_Recovery_Gunlance_Recovery_Health_raw = reader.ReadByte();
                data.Hasten_Recovery_Switch_Axe_Recovery_Health_offset = reader.BaseStream.Position;
                data.Hasten_Recovery_Switch_Axe_Recovery_Health_raw = reader.ReadByte();
                data.Hasten_Recovery_Charge_Blade_Recovery_Health_offset = reader.BaseStream.Position;
                data.Hasten_Recovery_Charge_Blade_Recovery_Health_raw = reader.ReadByte();
                data.Hasten_Recovery_Insect_Glaive_Recovery_Health_offset = reader.BaseStream.Position;
                data.Hasten_Recovery_Insect_Glaive_Recovery_Health_raw = reader.ReadByte();
                data.Hasten_Recovery_Bow_Recovery_Health_offset = reader.BaseStream.Position;
                data.Hasten_Recovery_Bow_Recovery_Health_raw = reader.ReadByte();
                data.Hasten_Recovery_HBG_Recovery_Health_offset = reader.BaseStream.Position;
                data.Hasten_Recovery_HBG_Recovery_Health_raw = reader.ReadByte();
                data.Hasten_Recovery_LBG_Recovery_Health_offset = reader.BaseStream.Position;
                data.Hasten_Recovery_LBG_Recovery_Health_raw = reader.ReadByte();
                data.Hasten_Recovery_Success_Combo__offset = reader.BaseStream.Position;
                data.Hasten_Recovery_Success_Combo__raw = reader.ReadByte();
                data.Hasten_Recovery_Combo_Duration_offset = reader.BaseStream.Position;
                data.Hasten_Recovery_Combo_Duration_raw = reader.ReadSingle();
                data.Hasten_Recovery_Combo_Ignore_Time_offset = reader.BaseStream.Position;
                data.Hasten_Recovery_Combo_Ignore_Time_raw = reader.ReadSingle();
                data._True_Element_Acceleration_Success_Combo__offset = reader.BaseStream.Position;
                data._True_Element_Acceleration_Success_Combo__raw = reader.ReadByte();
                data._True_Element_Acceleration_Combo_Duration_offset = reader.BaseStream.Position;
                data._True_Element_Acceleration_Combo_Duration_raw = reader.ReadSingle();
                data._True_Element_Acceleration_Combo_Ignore_Time__offset = reader.BaseStream.Position;
                data._True_Element_Acceleration_Combo_Ignore_Time__raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Health_Auto_Recover_Interval_raw);
                writer.Write(Health_Auto_Recover_Value_raw);
                writer.Write(Hasten_Recovery_Great_Sword_Recovery_Health_raw);
                writer.Write(Hasten_Recovery_Sword_Shield_Recovery_Health_raw);
                writer.Write(Hasten_Recovery_Dual_Blades_Recovery_Health_raw);
                writer.Write(Hasten_Recovery_Long_Sword_Recovery_Health_raw);
                writer.Write(Hasten_Recovery_Hammer_Recovery_Health_raw);
                writer.Write(Hasten_Recovery_Hunting_Horn_Recovery_Health_raw);
                writer.Write(Hasten_Recovery_Lance_Recovery_Health_raw);
                writer.Write(Hasten_Recovery_Gunlance_Recovery_Health_raw);
                writer.Write(Hasten_Recovery_Switch_Axe_Recovery_Health_raw);
                writer.Write(Hasten_Recovery_Charge_Blade_Recovery_Health_raw);
                writer.Write(Hasten_Recovery_Insect_Glaive_Recovery_Health_raw);
                writer.Write(Hasten_Recovery_Bow_Recovery_Health_raw);
                writer.Write(Hasten_Recovery_HBG_Recovery_Health_raw);
                writer.Write(Hasten_Recovery_LBG_Recovery_Health_raw);
                writer.Write(Hasten_Recovery_Success_Combo__raw);
                writer.Write(Hasten_Recovery_Combo_Duration_raw);
                writer.Write(Hasten_Recovery_Combo_Ignore_Time_raw);
                writer.Write(_True_Element_Acceleration_Success_Combo__raw);
                writer.Write(_True_Element_Acceleration_Combo_Duration_raw);
                writer.Write(_True_Element_Acceleration_Combo_Ignore_Time__raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Health Auto Recover Interval", "Health_Auto_Recover_Interval", "Health_Auto_Recover_Interval_offset"),
                    new MultiStructItemCustomView(this, "Health Auto Recover Value", "Health_Auto_Recover_Value", "Health_Auto_Recover_Value_offset"),
                    new MultiStructItemCustomView(this, "Hasten Recovery: (Great Sword) Recovery Health", "Hasten_Recovery_Great_Sword_Recovery_Health", "Hasten_Recovery_Great_Sword_Recovery_Health_offset"),
                    new MultiStructItemCustomView(this, "Hasten Recovery: (Sword & Shield) Recovery Health", "Hasten_Recovery_Sword_Shield_Recovery_Health", "Hasten_Recovery_Sword_Shield_Recovery_Health_offset"),
                    new MultiStructItemCustomView(this, "Hasten Recovery: (Dual Blades) Recovery Health", "Hasten_Recovery_Dual_Blades_Recovery_Health", "Hasten_Recovery_Dual_Blades_Recovery_Health_offset"),
                    new MultiStructItemCustomView(this, "Hasten Recovery: (Long Sword) Recovery Health", "Hasten_Recovery_Long_Sword_Recovery_Health", "Hasten_Recovery_Long_Sword_Recovery_Health_offset"),
                    new MultiStructItemCustomView(this, "Hasten Recovery: (Hammer) Recovery Health", "Hasten_Recovery_Hammer_Recovery_Health", "Hasten_Recovery_Hammer_Recovery_Health_offset"),
                    new MultiStructItemCustomView(this, "Hasten Recovery: (Hunting Horn) Recovery Health", "Hasten_Recovery_Hunting_Horn_Recovery_Health", "Hasten_Recovery_Hunting_Horn_Recovery_Health_offset"),
                    new MultiStructItemCustomView(this, "Hasten Recovery: (Lance) Recovery Health", "Hasten_Recovery_Lance_Recovery_Health", "Hasten_Recovery_Lance_Recovery_Health_offset"),
                    new MultiStructItemCustomView(this, "Hasten Recovery: (Gunlance) Recovery Health", "Hasten_Recovery_Gunlance_Recovery_Health", "Hasten_Recovery_Gunlance_Recovery_Health_offset"),
                    new MultiStructItemCustomView(this, "Hasten Recovery: (Switch Axe) Recovery Health", "Hasten_Recovery_Switch_Axe_Recovery_Health", "Hasten_Recovery_Switch_Axe_Recovery_Health_offset"),
                    new MultiStructItemCustomView(this, "Hasten Recovery: (Charge Blade) Recovery Health", "Hasten_Recovery_Charge_Blade_Recovery_Health", "Hasten_Recovery_Charge_Blade_Recovery_Health_offset"),
                    new MultiStructItemCustomView(this, "Hasten Recovery: (Insect Glaive) Recovery Health", "Hasten_Recovery_Insect_Glaive_Recovery_Health", "Hasten_Recovery_Insect_Glaive_Recovery_Health_offset"),
                    new MultiStructItemCustomView(this, "Hasten Recovery: (Bow) Recovery Health", "Hasten_Recovery_Bow_Recovery_Health", "Hasten_Recovery_Bow_Recovery_Health_offset"),
                    new MultiStructItemCustomView(this, "Hasten Recovery: (HBG) Recovery Health", "Hasten_Recovery_HBG_Recovery_Health", "Hasten_Recovery_HBG_Recovery_Health_offset"),
                    new MultiStructItemCustomView(this, "Hasten Recovery: (LBG) Recovery Health", "Hasten_Recovery_LBG_Recovery_Health", "Hasten_Recovery_LBG_Recovery_Health_offset"),
                    new MultiStructItemCustomView(this, "Hasten Recovery: Success Combo #", "Hasten_Recovery_Success_Combo_", "Hasten_Recovery_Success_Combo__offset"),
                    new MultiStructItemCustomView(this, "Hasten Recovery: Combo Duration", "Hasten_Recovery_Combo_Duration", "Hasten_Recovery_Combo_Duration_offset"),
                    new MultiStructItemCustomView(this, "Hasten Recovery: Combo Ignore Time", "Hasten_Recovery_Combo_Ignore_Time", "Hasten_Recovery_Combo_Ignore_Time_offset"),
                    new MultiStructItemCustomView(this, "(True) Element Acceleration: Success Combo #", "_True_Element_Acceleration_Success_Combo_", "_True_Element_Acceleration_Success_Combo__offset"),
                    new MultiStructItemCustomView(this, "(True) Element Acceleration: Combo Duration", "_True_Element_Acceleration_Combo_Duration", "_True_Element_Acceleration_Combo_Duration_offset"),
                    new MultiStructItemCustomView(this, "(True) Element Acceleration: Combo Ignore Time)", "_True_Element_Acceleration_Combo_Ignore_Time_", "_True_Element_Acceleration_Combo_Ignore_Time__offset"),
                };
            }
        }

        public partial class Slinger_Up : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 31;
            public const string GridName = "Slinger Up";

            protected byte Level_1_raw;
            public const string Level_1_displayName = "Level 1";
            public const int Level_1_sortIndex = 50;
            [SortOrder(Level_1_sortIndex)]
            [DisplayName(Level_1_displayName)]
            public virtual byte Level_1 {
                get => Level_1_raw;
                set {
                    if (Level_1_raw == value) return;
                    Level_1_raw = value;
                    ChangedItems.Add(nameof(Level_1));
                    OnPropertyChanged(nameof(Level_1));
                }
            }

            protected byte Level_2_raw;
            public const string Level_2_displayName = "Level 2";
            public const int Level_2_sortIndex = 100;
            [SortOrder(Level_2_sortIndex)]
            [DisplayName(Level_2_displayName)]
            public virtual byte Level_2 {
                get => Level_2_raw;
                set {
                    if (Level_2_raw == value) return;
                    Level_2_raw = value;
                    ChangedItems.Add(nameof(Level_2));
                    OnPropertyChanged(nameof(Level_2));
                }
            }

            protected byte Level_3_raw;
            public const string Level_3_displayName = "Level 3";
            public const int Level_3_sortIndex = 150;
            [SortOrder(Level_3_sortIndex)]
            [DisplayName(Level_3_displayName)]
            public virtual byte Level_3 {
                get => Level_3_raw;
                set {
                    if (Level_3_raw == value) return;
                    Level_3_raw = value;
                    ChangedItems.Add(nameof(Level_3));
                    OnPropertyChanged(nameof(Level_3));
                }
            }

            protected byte Level_4_raw;
            public const string Level_4_displayName = "Level 4";
            public const int Level_4_sortIndex = 200;
            [SortOrder(Level_4_sortIndex)]
            [DisplayName(Level_4_displayName)]
            public virtual byte Level_4 {
                get => Level_4_raw;
                set {
                    if (Level_4_raw == value) return;
                    Level_4_raw = value;
                    ChangedItems.Add(nameof(Level_4));
                    OnPropertyChanged(nameof(Level_4));
                }
            }

            protected byte Level_5_raw;
            public const string Level_5_displayName = "Level 5";
            public const int Level_5_sortIndex = 250;
            [SortOrder(Level_5_sortIndex)]
            [DisplayName(Level_5_displayName)]
            public virtual byte Level_5 {
                get => Level_5_raw;
                set {
                    if (Level_5_raw == value) return;
                    Level_5_raw = value;
                    ChangedItems.Add(nameof(Level_5));
                    OnPropertyChanged(nameof(Level_5));
                }
            }

            public const int lastSortIndex = 300;

            public static ObservableMhwStructCollection<Slinger_Up> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Slinger_Up>();
                const ulong count = 31UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Slinger_Up LoadData(BinaryReader reader, ulong i) {
                var data = new Slinger_Up();
                data.Index = i;
                data.Level_1_raw = reader.ReadByte();
                data.Level_2_raw = reader.ReadByte();
                data.Level_3_raw = reader.ReadByte();
                data.Level_4_raw = reader.ReadByte();
                data.Level_5_raw = reader.ReadByte();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Level_1_raw);
                writer.Write(Level_2_raw);
                writer.Write(Level_3_raw);
                writer.Write(Level_4_raw);
                writer.Write(Level_5_raw);
            }
        }

        public partial class Skill_Params_6_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Skill Params (6)";

            protected float Master_Fisher_Add_Hook_Time_raw;
            public const string Master_Fisher_Add_Hook_Time_displayName = "Master Fisher: Add Hook Time";
            public const int Master_Fisher_Add_Hook_Time_sortIndex = 50;
            [SortOrder(Master_Fisher_Add_Hook_Time_sortIndex)]
            [DisplayName(Master_Fisher_Add_Hook_Time_displayName)]
            public virtual float Master_Fisher_Add_Hook_Time {
                get => Master_Fisher_Add_Hook_Time_raw;
                set {
                    if (Master_Fisher_Add_Hook_Time_raw == value) return;
                    Master_Fisher_Add_Hook_Time_raw = value;
                    ChangedItems.Add(nameof(Master_Fisher_Add_Hook_Time));
                    OnPropertyChanged(nameof(Master_Fisher_Add_Hook_Time));
                }
            }

            [DisplayName("Offset")]
            public long Master_Fisher_Add_Hook_Time_offset { get; private set; }

            protected float Master_Fisher_Big_Fish_Catch_Rate_raw;
            public const string Master_Fisher_Big_Fish_Catch_Rate_displayName = "Master Fisher: Big Fish Catch Rate";
            public const int Master_Fisher_Big_Fish_Catch_Rate_sortIndex = 100;
            [SortOrder(Master_Fisher_Big_Fish_Catch_Rate_sortIndex)]
            [DisplayName(Master_Fisher_Big_Fish_Catch_Rate_displayName)]
            public virtual float Master_Fisher_Big_Fish_Catch_Rate {
                get => Master_Fisher_Big_Fish_Catch_Rate_raw;
                set {
                    if (Master_Fisher_Big_Fish_Catch_Rate_raw == value) return;
                    Master_Fisher_Big_Fish_Catch_Rate_raw = value;
                    ChangedItems.Add(nameof(Master_Fisher_Big_Fish_Catch_Rate));
                    OnPropertyChanged(nameof(Master_Fisher_Big_Fish_Catch_Rate));
                }
            }

            [DisplayName("Offset")]
            public long Master_Fisher_Big_Fish_Catch_Rate_offset { get; private set; }

            protected float Adrenaline_Stamina_Rate_raw;
            public const string Adrenaline_Stamina_Rate_displayName = "Adrenaline: Stamina Rate";
            public const int Adrenaline_Stamina_Rate_sortIndex = 150;
            [SortOrder(Adrenaline_Stamina_Rate_sortIndex)]
            [DisplayName(Adrenaline_Stamina_Rate_displayName)]
            public virtual float Adrenaline_Stamina_Rate {
                get => Adrenaline_Stamina_Rate_raw;
                set {
                    if (Adrenaline_Stamina_Rate_raw == value) return;
                    Adrenaline_Stamina_Rate_raw = value;
                    ChangedItems.Add(nameof(Adrenaline_Stamina_Rate));
                    OnPropertyChanged(nameof(Adrenaline_Stamina_Rate));
                }
            }

            [DisplayName("Offset")]
            public long Adrenaline_Stamina_Rate_offset { get; private set; }

            protected float Elemental_Airborne_Great_Sword_Rate_raw;
            public const string Elemental_Airborne_Great_Sword_Rate_displayName = "Elemental Airborne: (Great Sword) Rate";
            public const int Elemental_Airborne_Great_Sword_Rate_sortIndex = 200;
            [SortOrder(Elemental_Airborne_Great_Sword_Rate_sortIndex)]
            [DisplayName(Elemental_Airborne_Great_Sword_Rate_displayName)]
            public virtual float Elemental_Airborne_Great_Sword_Rate {
                get => Elemental_Airborne_Great_Sword_Rate_raw;
                set {
                    if (Elemental_Airborne_Great_Sword_Rate_raw == value) return;
                    Elemental_Airborne_Great_Sword_Rate_raw = value;
                    ChangedItems.Add(nameof(Elemental_Airborne_Great_Sword_Rate));
                    OnPropertyChanged(nameof(Elemental_Airborne_Great_Sword_Rate));
                }
            }

            [DisplayName("Offset")]
            public long Elemental_Airborne_Great_Sword_Rate_offset { get; private set; }

            protected float Elemental_Airborne_Sword_Shield_Rate_raw;
            public const string Elemental_Airborne_Sword_Shield_Rate_displayName = "Elemental Airborne: (Sword & Shield) Rate";
            public const int Elemental_Airborne_Sword_Shield_Rate_sortIndex = 250;
            [SortOrder(Elemental_Airborne_Sword_Shield_Rate_sortIndex)]
            [DisplayName(Elemental_Airborne_Sword_Shield_Rate_displayName)]
            public virtual float Elemental_Airborne_Sword_Shield_Rate {
                get => Elemental_Airborne_Sword_Shield_Rate_raw;
                set {
                    if (Elemental_Airborne_Sword_Shield_Rate_raw == value) return;
                    Elemental_Airborne_Sword_Shield_Rate_raw = value;
                    ChangedItems.Add(nameof(Elemental_Airborne_Sword_Shield_Rate));
                    OnPropertyChanged(nameof(Elemental_Airborne_Sword_Shield_Rate));
                }
            }

            [DisplayName("Offset")]
            public long Elemental_Airborne_Sword_Shield_Rate_offset { get; private set; }

            protected float Elemental_Airborne_Dual_Blades_Rate_raw;
            public const string Elemental_Airborne_Dual_Blades_Rate_displayName = "Elemental Airborne: (Dual Blades) Rate";
            public const int Elemental_Airborne_Dual_Blades_Rate_sortIndex = 300;
            [SortOrder(Elemental_Airborne_Dual_Blades_Rate_sortIndex)]
            [DisplayName(Elemental_Airborne_Dual_Blades_Rate_displayName)]
            public virtual float Elemental_Airborne_Dual_Blades_Rate {
                get => Elemental_Airborne_Dual_Blades_Rate_raw;
                set {
                    if (Elemental_Airborne_Dual_Blades_Rate_raw == value) return;
                    Elemental_Airborne_Dual_Blades_Rate_raw = value;
                    ChangedItems.Add(nameof(Elemental_Airborne_Dual_Blades_Rate));
                    OnPropertyChanged(nameof(Elemental_Airborne_Dual_Blades_Rate));
                }
            }

            [DisplayName("Offset")]
            public long Elemental_Airborne_Dual_Blades_Rate_offset { get; private set; }

            protected float Elemental_Airborne_Long_Sword_Rate_raw;
            public const string Elemental_Airborne_Long_Sword_Rate_displayName = "Elemental Airborne: (Long Sword) Rate";
            public const int Elemental_Airborne_Long_Sword_Rate_sortIndex = 350;
            [SortOrder(Elemental_Airborne_Long_Sword_Rate_sortIndex)]
            [DisplayName(Elemental_Airborne_Long_Sword_Rate_displayName)]
            public virtual float Elemental_Airborne_Long_Sword_Rate {
                get => Elemental_Airborne_Long_Sword_Rate_raw;
                set {
                    if (Elemental_Airborne_Long_Sword_Rate_raw == value) return;
                    Elemental_Airborne_Long_Sword_Rate_raw = value;
                    ChangedItems.Add(nameof(Elemental_Airborne_Long_Sword_Rate));
                    OnPropertyChanged(nameof(Elemental_Airborne_Long_Sword_Rate));
                }
            }

            [DisplayName("Offset")]
            public long Elemental_Airborne_Long_Sword_Rate_offset { get; private set; }

            protected float Elemental_Airborne_Hammer_Rate_raw;
            public const string Elemental_Airborne_Hammer_Rate_displayName = "Elemental Airborne: (Hammer) Rate";
            public const int Elemental_Airborne_Hammer_Rate_sortIndex = 400;
            [SortOrder(Elemental_Airborne_Hammer_Rate_sortIndex)]
            [DisplayName(Elemental_Airborne_Hammer_Rate_displayName)]
            public virtual float Elemental_Airborne_Hammer_Rate {
                get => Elemental_Airborne_Hammer_Rate_raw;
                set {
                    if (Elemental_Airborne_Hammer_Rate_raw == value) return;
                    Elemental_Airborne_Hammer_Rate_raw = value;
                    ChangedItems.Add(nameof(Elemental_Airborne_Hammer_Rate));
                    OnPropertyChanged(nameof(Elemental_Airborne_Hammer_Rate));
                }
            }

            [DisplayName("Offset")]
            public long Elemental_Airborne_Hammer_Rate_offset { get; private set; }

            protected float Elemental_Airborne_Hunting_Horn_Rate_raw;
            public const string Elemental_Airborne_Hunting_Horn_Rate_displayName = "Elemental Airborne: (Hunting Horn) Rate";
            public const int Elemental_Airborne_Hunting_Horn_Rate_sortIndex = 450;
            [SortOrder(Elemental_Airborne_Hunting_Horn_Rate_sortIndex)]
            [DisplayName(Elemental_Airborne_Hunting_Horn_Rate_displayName)]
            public virtual float Elemental_Airborne_Hunting_Horn_Rate {
                get => Elemental_Airborne_Hunting_Horn_Rate_raw;
                set {
                    if (Elemental_Airborne_Hunting_Horn_Rate_raw == value) return;
                    Elemental_Airborne_Hunting_Horn_Rate_raw = value;
                    ChangedItems.Add(nameof(Elemental_Airborne_Hunting_Horn_Rate));
                    OnPropertyChanged(nameof(Elemental_Airborne_Hunting_Horn_Rate));
                }
            }

            [DisplayName("Offset")]
            public long Elemental_Airborne_Hunting_Horn_Rate_offset { get; private set; }

            protected float Elemental_Airborne_Lance_Rate_raw;
            public const string Elemental_Airborne_Lance_Rate_displayName = "Elemental Airborne: (Lance) Rate";
            public const int Elemental_Airborne_Lance_Rate_sortIndex = 500;
            [SortOrder(Elemental_Airborne_Lance_Rate_sortIndex)]
            [DisplayName(Elemental_Airborne_Lance_Rate_displayName)]
            public virtual float Elemental_Airborne_Lance_Rate {
                get => Elemental_Airborne_Lance_Rate_raw;
                set {
                    if (Elemental_Airborne_Lance_Rate_raw == value) return;
                    Elemental_Airborne_Lance_Rate_raw = value;
                    ChangedItems.Add(nameof(Elemental_Airborne_Lance_Rate));
                    OnPropertyChanged(nameof(Elemental_Airborne_Lance_Rate));
                }
            }

            [DisplayName("Offset")]
            public long Elemental_Airborne_Lance_Rate_offset { get; private set; }

            protected float Elemental_Airborne_Gunlance_Rate_raw;
            public const string Elemental_Airborne_Gunlance_Rate_displayName = "Elemental Airborne: (Gunlance) Rate";
            public const int Elemental_Airborne_Gunlance_Rate_sortIndex = 550;
            [SortOrder(Elemental_Airborne_Gunlance_Rate_sortIndex)]
            [DisplayName(Elemental_Airborne_Gunlance_Rate_displayName)]
            public virtual float Elemental_Airborne_Gunlance_Rate {
                get => Elemental_Airborne_Gunlance_Rate_raw;
                set {
                    if (Elemental_Airborne_Gunlance_Rate_raw == value) return;
                    Elemental_Airborne_Gunlance_Rate_raw = value;
                    ChangedItems.Add(nameof(Elemental_Airborne_Gunlance_Rate));
                    OnPropertyChanged(nameof(Elemental_Airborne_Gunlance_Rate));
                }
            }

            [DisplayName("Offset")]
            public long Elemental_Airborne_Gunlance_Rate_offset { get; private set; }

            protected float Elemental_Airborne_Switch_Axe_Rate_raw;
            public const string Elemental_Airborne_Switch_Axe_Rate_displayName = "Elemental Airborne: (Switch Axe) Rate";
            public const int Elemental_Airborne_Switch_Axe_Rate_sortIndex = 600;
            [SortOrder(Elemental_Airborne_Switch_Axe_Rate_sortIndex)]
            [DisplayName(Elemental_Airborne_Switch_Axe_Rate_displayName)]
            public virtual float Elemental_Airborne_Switch_Axe_Rate {
                get => Elemental_Airborne_Switch_Axe_Rate_raw;
                set {
                    if (Elemental_Airborne_Switch_Axe_Rate_raw == value) return;
                    Elemental_Airborne_Switch_Axe_Rate_raw = value;
                    ChangedItems.Add(nameof(Elemental_Airborne_Switch_Axe_Rate));
                    OnPropertyChanged(nameof(Elemental_Airborne_Switch_Axe_Rate));
                }
            }

            [DisplayName("Offset")]
            public long Elemental_Airborne_Switch_Axe_Rate_offset { get; private set; }

            protected float Elemental_Airborne_Charge_Blade_Rate_raw;
            public const string Elemental_Airborne_Charge_Blade_Rate_displayName = "Elemental Airborne: (Charge Blade) Rate";
            public const int Elemental_Airborne_Charge_Blade_Rate_sortIndex = 650;
            [SortOrder(Elemental_Airborne_Charge_Blade_Rate_sortIndex)]
            [DisplayName(Elemental_Airborne_Charge_Blade_Rate_displayName)]
            public virtual float Elemental_Airborne_Charge_Blade_Rate {
                get => Elemental_Airborne_Charge_Blade_Rate_raw;
                set {
                    if (Elemental_Airborne_Charge_Blade_Rate_raw == value) return;
                    Elemental_Airborne_Charge_Blade_Rate_raw = value;
                    ChangedItems.Add(nameof(Elemental_Airborne_Charge_Blade_Rate));
                    OnPropertyChanged(nameof(Elemental_Airborne_Charge_Blade_Rate));
                }
            }

            [DisplayName("Offset")]
            public long Elemental_Airborne_Charge_Blade_Rate_offset { get; private set; }

            protected float Elemental_Airborne_Insect_Glaive_Rate_raw;
            public const string Elemental_Airborne_Insect_Glaive_Rate_displayName = "Elemental Airborne: (Insect Glaive) Rate";
            public const int Elemental_Airborne_Insect_Glaive_Rate_sortIndex = 700;
            [SortOrder(Elemental_Airborne_Insect_Glaive_Rate_sortIndex)]
            [DisplayName(Elemental_Airborne_Insect_Glaive_Rate_displayName)]
            public virtual float Elemental_Airborne_Insect_Glaive_Rate {
                get => Elemental_Airborne_Insect_Glaive_Rate_raw;
                set {
                    if (Elemental_Airborne_Insect_Glaive_Rate_raw == value) return;
                    Elemental_Airborne_Insect_Glaive_Rate_raw = value;
                    ChangedItems.Add(nameof(Elemental_Airborne_Insect_Glaive_Rate));
                    OnPropertyChanged(nameof(Elemental_Airborne_Insect_Glaive_Rate));
                }
            }

            [DisplayName("Offset")]
            public long Elemental_Airborne_Insect_Glaive_Rate_offset { get; private set; }

            protected float Elemental_Airborne_Bow_Rate_raw;
            public const string Elemental_Airborne_Bow_Rate_displayName = "Elemental Airborne: (Bow) Rate";
            public const int Elemental_Airborne_Bow_Rate_sortIndex = 750;
            [SortOrder(Elemental_Airborne_Bow_Rate_sortIndex)]
            [DisplayName(Elemental_Airborne_Bow_Rate_displayName)]
            public virtual float Elemental_Airborne_Bow_Rate {
                get => Elemental_Airborne_Bow_Rate_raw;
                set {
                    if (Elemental_Airborne_Bow_Rate_raw == value) return;
                    Elemental_Airborne_Bow_Rate_raw = value;
                    ChangedItems.Add(nameof(Elemental_Airborne_Bow_Rate));
                    OnPropertyChanged(nameof(Elemental_Airborne_Bow_Rate));
                }
            }

            [DisplayName("Offset")]
            public long Elemental_Airborne_Bow_Rate_offset { get; private set; }

            protected float Elemental_Airborne_HBG_Rate_raw;
            public const string Elemental_Airborne_HBG_Rate_displayName = "Elemental Airborne: (HBG) Rate";
            public const int Elemental_Airborne_HBG_Rate_sortIndex = 800;
            [SortOrder(Elemental_Airborne_HBG_Rate_sortIndex)]
            [DisplayName(Elemental_Airborne_HBG_Rate_displayName)]
            public virtual float Elemental_Airborne_HBG_Rate {
                get => Elemental_Airborne_HBG_Rate_raw;
                set {
                    if (Elemental_Airborne_HBG_Rate_raw == value) return;
                    Elemental_Airborne_HBG_Rate_raw = value;
                    ChangedItems.Add(nameof(Elemental_Airborne_HBG_Rate));
                    OnPropertyChanged(nameof(Elemental_Airborne_HBG_Rate));
                }
            }

            [DisplayName("Offset")]
            public long Elemental_Airborne_HBG_Rate_offset { get; private set; }

            protected float Elemental_Airborne_LBG_Rate_raw;
            public const string Elemental_Airborne_LBG_Rate_displayName = "Elemental Airborne: (LBG) Rate";
            public const int Elemental_Airborne_LBG_Rate_sortIndex = 850;
            [SortOrder(Elemental_Airborne_LBG_Rate_sortIndex)]
            [DisplayName(Elemental_Airborne_LBG_Rate_displayName)]
            public virtual float Elemental_Airborne_LBG_Rate {
                get => Elemental_Airborne_LBG_Rate_raw;
                set {
                    if (Elemental_Airborne_LBG_Rate_raw == value) return;
                    Elemental_Airborne_LBG_Rate_raw = value;
                    ChangedItems.Add(nameof(Elemental_Airborne_LBG_Rate));
                    OnPropertyChanged(nameof(Elemental_Airborne_LBG_Rate));
                }
            }

            [DisplayName("Offset")]
            public long Elemental_Airborne_LBG_Rate_offset { get; private set; }

            protected byte Unk19_raw;
            public const string Unk19_displayName = "Unk19";
            public const int Unk19_sortIndex = 900;
            [SortOrder(Unk19_sortIndex)]
            [DisplayName(Unk19_displayName)]
            public virtual byte Unk19 {
                get => Unk19_raw;
                set {
                    if (Unk19_raw == value) return;
                    Unk19_raw = value;
                    ChangedItems.Add(nameof(Unk19));
                    OnPropertyChanged(nameof(Unk19));
                }
            }

            [DisplayName("Offset")]
            public long Unk19_offset { get; private set; }

            protected byte Unk20_raw;
            public const string Unk20_displayName = "Unk20";
            public const int Unk20_sortIndex = 950;
            [SortOrder(Unk20_sortIndex)]
            [DisplayName(Unk20_displayName)]
            public virtual byte Unk20 {
                get => Unk20_raw;
                set {
                    if (Unk20_raw == value) return;
                    Unk20_raw = value;
                    ChangedItems.Add(nameof(Unk20));
                    OnPropertyChanged(nameof(Unk20));
                }
            }

            [DisplayName("Offset")]
            public long Unk20_offset { get; private set; }

            protected byte Unk21_raw;
            public const string Unk21_displayName = "Unk21";
            public const int Unk21_sortIndex = 1000;
            [SortOrder(Unk21_sortIndex)]
            [DisplayName(Unk21_displayName)]
            public virtual byte Unk21 {
                get => Unk21_raw;
                set {
                    if (Unk21_raw == value) return;
                    Unk21_raw = value;
                    ChangedItems.Add(nameof(Unk21));
                    OnPropertyChanged(nameof(Unk21));
                }
            }

            [DisplayName("Offset")]
            public long Unk21_offset { get; private set; }

            protected byte Unk22_raw;
            public const string Unk22_displayName = "Unk22";
            public const int Unk22_sortIndex = 1050;
            [SortOrder(Unk22_sortIndex)]
            [DisplayName(Unk22_displayName)]
            public virtual byte Unk22 {
                get => Unk22_raw;
                set {
                    if (Unk22_raw == value) return;
                    Unk22_raw = value;
                    ChangedItems.Add(nameof(Unk22));
                    OnPropertyChanged(nameof(Unk22));
                }
            }

            [DisplayName("Offset")]
            public long Unk22_offset { get; private set; }

            protected byte Unk23_raw;
            public const string Unk23_displayName = "Unk23";
            public const int Unk23_sortIndex = 1100;
            [SortOrder(Unk23_sortIndex)]
            [DisplayName(Unk23_displayName)]
            public virtual byte Unk23 {
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

            protected byte Unk24_raw;
            public const string Unk24_displayName = "Unk24";
            public const int Unk24_sortIndex = 1150;
            [SortOrder(Unk24_sortIndex)]
            [DisplayName(Unk24_displayName)]
            public virtual byte Unk24 {
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

            protected byte Unk25_raw;
            public const string Unk25_displayName = "Unk25";
            public const int Unk25_sortIndex = 1200;
            [SortOrder(Unk25_sortIndex)]
            [DisplayName(Unk25_displayName)]
            public virtual byte Unk25 {
                get => Unk25_raw;
                set {
                    if (Unk25_raw == value) return;
                    Unk25_raw = value;
                    ChangedItems.Add(nameof(Unk25));
                    OnPropertyChanged(nameof(Unk25));
                }
            }

            [DisplayName("Offset")]
            public long Unk25_offset { get; private set; }

            protected byte Unk26_raw;
            public const string Unk26_displayName = "Unk26";
            public const int Unk26_sortIndex = 1250;
            [SortOrder(Unk26_sortIndex)]
            [DisplayName(Unk26_displayName)]
            public virtual byte Unk26 {
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
            public const int Unk27_sortIndex = 1300;
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

            protected byte Unk28_raw;
            public const string Unk28_displayName = "Unk28";
            public const int Unk28_sortIndex = 1350;
            [SortOrder(Unk28_sortIndex)]
            [DisplayName(Unk28_displayName)]
            public virtual byte Unk28 {
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
            public const int Unk29_sortIndex = 1400;
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

            public const int lastSortIndex = 1450;

            public static ObservableMhwStructCollection<Skill_Params_6_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Skill_Params_6_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Skill_Params_6_ LoadData(BinaryReader reader, ulong i) {
                var data = new Skill_Params_6_();
                data.Index = i;
                data.Master_Fisher_Add_Hook_Time_offset = reader.BaseStream.Position;
                data.Master_Fisher_Add_Hook_Time_raw = reader.ReadSingle();
                data.Master_Fisher_Big_Fish_Catch_Rate_offset = reader.BaseStream.Position;
                data.Master_Fisher_Big_Fish_Catch_Rate_raw = reader.ReadSingle();
                data.Adrenaline_Stamina_Rate_offset = reader.BaseStream.Position;
                data.Adrenaline_Stamina_Rate_raw = reader.ReadSingle();
                data.Elemental_Airborne_Great_Sword_Rate_offset = reader.BaseStream.Position;
                data.Elemental_Airborne_Great_Sword_Rate_raw = reader.ReadSingle();
                data.Elemental_Airborne_Sword_Shield_Rate_offset = reader.BaseStream.Position;
                data.Elemental_Airborne_Sword_Shield_Rate_raw = reader.ReadSingle();
                data.Elemental_Airborne_Dual_Blades_Rate_offset = reader.BaseStream.Position;
                data.Elemental_Airborne_Dual_Blades_Rate_raw = reader.ReadSingle();
                data.Elemental_Airborne_Long_Sword_Rate_offset = reader.BaseStream.Position;
                data.Elemental_Airborne_Long_Sword_Rate_raw = reader.ReadSingle();
                data.Elemental_Airborne_Hammer_Rate_offset = reader.BaseStream.Position;
                data.Elemental_Airborne_Hammer_Rate_raw = reader.ReadSingle();
                data.Elemental_Airborne_Hunting_Horn_Rate_offset = reader.BaseStream.Position;
                data.Elemental_Airborne_Hunting_Horn_Rate_raw = reader.ReadSingle();
                data.Elemental_Airborne_Lance_Rate_offset = reader.BaseStream.Position;
                data.Elemental_Airborne_Lance_Rate_raw = reader.ReadSingle();
                data.Elemental_Airborne_Gunlance_Rate_offset = reader.BaseStream.Position;
                data.Elemental_Airborne_Gunlance_Rate_raw = reader.ReadSingle();
                data.Elemental_Airborne_Switch_Axe_Rate_offset = reader.BaseStream.Position;
                data.Elemental_Airborne_Switch_Axe_Rate_raw = reader.ReadSingle();
                data.Elemental_Airborne_Charge_Blade_Rate_offset = reader.BaseStream.Position;
                data.Elemental_Airborne_Charge_Blade_Rate_raw = reader.ReadSingle();
                data.Elemental_Airborne_Insect_Glaive_Rate_offset = reader.BaseStream.Position;
                data.Elemental_Airborne_Insect_Glaive_Rate_raw = reader.ReadSingle();
                data.Elemental_Airborne_Bow_Rate_offset = reader.BaseStream.Position;
                data.Elemental_Airborne_Bow_Rate_raw = reader.ReadSingle();
                data.Elemental_Airborne_HBG_Rate_offset = reader.BaseStream.Position;
                data.Elemental_Airborne_HBG_Rate_raw = reader.ReadSingle();
                data.Elemental_Airborne_LBG_Rate_offset = reader.BaseStream.Position;
                data.Elemental_Airborne_LBG_Rate_raw = reader.ReadSingle();
                data.Unk19_offset = reader.BaseStream.Position;
                data.Unk19_raw = reader.ReadByte();
                data.Unk20_offset = reader.BaseStream.Position;
                data.Unk20_raw = reader.ReadByte();
                data.Unk21_offset = reader.BaseStream.Position;
                data.Unk21_raw = reader.ReadByte();
                data.Unk22_offset = reader.BaseStream.Position;
                data.Unk22_raw = reader.ReadByte();
                data.Unk23_offset = reader.BaseStream.Position;
                data.Unk23_raw = reader.ReadByte();
                data.Unk24_offset = reader.BaseStream.Position;
                data.Unk24_raw = reader.ReadByte();
                data.Unk25_offset = reader.BaseStream.Position;
                data.Unk25_raw = reader.ReadByte();
                data.Unk26_offset = reader.BaseStream.Position;
                data.Unk26_raw = reader.ReadByte();
                data.Unk27_offset = reader.BaseStream.Position;
                data.Unk27_raw = reader.ReadByte();
                data.Unk28_offset = reader.BaseStream.Position;
                data.Unk28_raw = reader.ReadByte();
                data.Unk29_offset = reader.BaseStream.Position;
                data.Unk29_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Master_Fisher_Add_Hook_Time_raw);
                writer.Write(Master_Fisher_Big_Fish_Catch_Rate_raw);
                writer.Write(Adrenaline_Stamina_Rate_raw);
                writer.Write(Elemental_Airborne_Great_Sword_Rate_raw);
                writer.Write(Elemental_Airborne_Sword_Shield_Rate_raw);
                writer.Write(Elemental_Airborne_Dual_Blades_Rate_raw);
                writer.Write(Elemental_Airborne_Long_Sword_Rate_raw);
                writer.Write(Elemental_Airborne_Hammer_Rate_raw);
                writer.Write(Elemental_Airborne_Hunting_Horn_Rate_raw);
                writer.Write(Elemental_Airborne_Lance_Rate_raw);
                writer.Write(Elemental_Airborne_Gunlance_Rate_raw);
                writer.Write(Elemental_Airborne_Switch_Axe_Rate_raw);
                writer.Write(Elemental_Airborne_Charge_Blade_Rate_raw);
                writer.Write(Elemental_Airborne_Insect_Glaive_Rate_raw);
                writer.Write(Elemental_Airborne_Bow_Rate_raw);
                writer.Write(Elemental_Airborne_HBG_Rate_raw);
                writer.Write(Elemental_Airborne_LBG_Rate_raw);
                writer.Write(Unk19_raw);
                writer.Write(Unk20_raw);
                writer.Write(Unk21_raw);
                writer.Write(Unk22_raw);
                writer.Write(Unk23_raw);
                writer.Write(Unk24_raw);
                writer.Write(Unk25_raw);
                writer.Write(Unk26_raw);
                writer.Write(Unk27_raw);
                writer.Write(Unk28_raw);
                writer.Write(Unk29_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Master Fisher: Add Hook Time", "Master_Fisher_Add_Hook_Time", "Master_Fisher_Add_Hook_Time_offset"),
                    new MultiStructItemCustomView(this, "Master Fisher: Big Fish Catch Rate", "Master_Fisher_Big_Fish_Catch_Rate", "Master_Fisher_Big_Fish_Catch_Rate_offset"),
                    new MultiStructItemCustomView(this, "Adrenaline: Stamina Rate", "Adrenaline_Stamina_Rate", "Adrenaline_Stamina_Rate_offset"),
                    new MultiStructItemCustomView(this, "Elemental Airborne: (Great Sword) Rate", "Elemental_Airborne_Great_Sword_Rate", "Elemental_Airborne_Great_Sword_Rate_offset"),
                    new MultiStructItemCustomView(this, "Elemental Airborne: (Sword & Shield) Rate", "Elemental_Airborne_Sword_Shield_Rate", "Elemental_Airborne_Sword_Shield_Rate_offset"),
                    new MultiStructItemCustomView(this, "Elemental Airborne: (Dual Blades) Rate", "Elemental_Airborne_Dual_Blades_Rate", "Elemental_Airborne_Dual_Blades_Rate_offset"),
                    new MultiStructItemCustomView(this, "Elemental Airborne: (Long Sword) Rate", "Elemental_Airborne_Long_Sword_Rate", "Elemental_Airborne_Long_Sword_Rate_offset"),
                    new MultiStructItemCustomView(this, "Elemental Airborne: (Hammer) Rate", "Elemental_Airborne_Hammer_Rate", "Elemental_Airborne_Hammer_Rate_offset"),
                    new MultiStructItemCustomView(this, "Elemental Airborne: (Hunting Horn) Rate", "Elemental_Airborne_Hunting_Horn_Rate", "Elemental_Airborne_Hunting_Horn_Rate_offset"),
                    new MultiStructItemCustomView(this, "Elemental Airborne: (Lance) Rate", "Elemental_Airborne_Lance_Rate", "Elemental_Airborne_Lance_Rate_offset"),
                    new MultiStructItemCustomView(this, "Elemental Airborne: (Gunlance) Rate", "Elemental_Airborne_Gunlance_Rate", "Elemental_Airborne_Gunlance_Rate_offset"),
                    new MultiStructItemCustomView(this, "Elemental Airborne: (Switch Axe) Rate", "Elemental_Airborne_Switch_Axe_Rate", "Elemental_Airborne_Switch_Axe_Rate_offset"),
                    new MultiStructItemCustomView(this, "Elemental Airborne: (Charge Blade) Rate", "Elemental_Airborne_Charge_Blade_Rate", "Elemental_Airborne_Charge_Blade_Rate_offset"),
                    new MultiStructItemCustomView(this, "Elemental Airborne: (Insect Glaive) Rate", "Elemental_Airborne_Insect_Glaive_Rate", "Elemental_Airborne_Insect_Glaive_Rate_offset"),
                    new MultiStructItemCustomView(this, "Elemental Airborne: (Bow) Rate", "Elemental_Airborne_Bow_Rate", "Elemental_Airborne_Bow_Rate_offset"),
                    new MultiStructItemCustomView(this, "Elemental Airborne: (HBG) Rate", "Elemental_Airborne_HBG_Rate", "Elemental_Airborne_HBG_Rate_offset"),
                    new MultiStructItemCustomView(this, "Elemental Airborne: (LBG) Rate", "Elemental_Airborne_LBG_Rate", "Elemental_Airborne_LBG_Rate_offset"),
                    new MultiStructItemCustomView(this, "Unk19", "Unk19", "Unk19_offset"),
                    new MultiStructItemCustomView(this, "Unk20", "Unk20", "Unk20_offset"),
                    new MultiStructItemCustomView(this, "Unk21", "Unk21", "Unk21_offset"),
                    new MultiStructItemCustomView(this, "Unk22", "Unk22", "Unk22_offset"),
                    new MultiStructItemCustomView(this, "Unk23", "Unk23", "Unk23_offset"),
                    new MultiStructItemCustomView(this, "Unk24", "Unk24", "Unk24_offset"),
                    new MultiStructItemCustomView(this, "Unk25", "Unk25", "Unk25_offset"),
                    new MultiStructItemCustomView(this, "Unk26", "Unk26", "Unk26_offset"),
                    new MultiStructItemCustomView(this, "Unk27", "Unk27", "Unk27_offset"),
                    new MultiStructItemCustomView(this, "Unk28", "Unk28", "Unk28_offset"),
                    new MultiStructItemCustomView(this, "Unk29", "Unk29", "Unk29_offset"),
                };
            }
        }

        public partial class Frostcraft_1_ : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 14;
            public const string GridName = "Frostcraft (1)";

            protected float Level_Multiplier_0_15__raw;
            public const string Level_Multiplier_0_15__displayName = "Level Multiplier (0-15%)";
            public const int Level_Multiplier_0_15__sortIndex = 50;
            [SortOrder(Level_Multiplier_0_15__sortIndex)]
            [DisplayName(Level_Multiplier_0_15__displayName)]
            public virtual float Level_Multiplier_0_15_ {
                get => Level_Multiplier_0_15__raw;
                set {
                    if (Level_Multiplier_0_15__raw == value) return;
                    Level_Multiplier_0_15__raw = value;
                    ChangedItems.Add(nameof(Level_Multiplier_0_15_));
                    OnPropertyChanged(nameof(Level_Multiplier_0_15_));
                }
            }

            protected float Level_Multiplier_16_45__raw;
            public const string Level_Multiplier_16_45__displayName = "Level Multiplier (16-45%)";
            public const int Level_Multiplier_16_45__sortIndex = 100;
            [SortOrder(Level_Multiplier_16_45__sortIndex)]
            [DisplayName(Level_Multiplier_16_45__displayName)]
            public virtual float Level_Multiplier_16_45_ {
                get => Level_Multiplier_16_45__raw;
                set {
                    if (Level_Multiplier_16_45__raw == value) return;
                    Level_Multiplier_16_45__raw = value;
                    ChangedItems.Add(nameof(Level_Multiplier_16_45_));
                    OnPropertyChanged(nameof(Level_Multiplier_16_45_));
                }
            }

            protected float Level_Multiplier_46_80__raw;
            public const string Level_Multiplier_46_80__displayName = "Level Multiplier (46-80%)";
            public const int Level_Multiplier_46_80__sortIndex = 150;
            [SortOrder(Level_Multiplier_46_80__sortIndex)]
            [DisplayName(Level_Multiplier_46_80__displayName)]
            public virtual float Level_Multiplier_46_80_ {
                get => Level_Multiplier_46_80__raw;
                set {
                    if (Level_Multiplier_46_80__raw == value) return;
                    Level_Multiplier_46_80__raw = value;
                    ChangedItems.Add(nameof(Level_Multiplier_46_80_));
                    OnPropertyChanged(nameof(Level_Multiplier_46_80_));
                }
            }

            protected float Level_Multiplier_81_100__raw;
            public const string Level_Multiplier_81_100__displayName = "Level Multiplier (81-100%)";
            public const int Level_Multiplier_81_100__sortIndex = 200;
            [SortOrder(Level_Multiplier_81_100__sortIndex)]
            [DisplayName(Level_Multiplier_81_100__displayName)]
            public virtual float Level_Multiplier_81_100_ {
                get => Level_Multiplier_81_100__raw;
                set {
                    if (Level_Multiplier_81_100__raw == value) return;
                    Level_Multiplier_81_100__raw = value;
                    ChangedItems.Add(nameof(Level_Multiplier_81_100_));
                    OnPropertyChanged(nameof(Level_Multiplier_81_100_));
                }
            }

            protected float Recovery_Speed_Unsheathed_raw;
            public const string Recovery_Speed_Unsheathed_displayName = "Recovery Speed: Unsheathed";
            public const int Recovery_Speed_Unsheathed_sortIndex = 250;
            [SortOrder(Recovery_Speed_Unsheathed_sortIndex)]
            [DisplayName(Recovery_Speed_Unsheathed_displayName)]
            public virtual float Recovery_Speed_Unsheathed {
                get => Recovery_Speed_Unsheathed_raw;
                set {
                    if (Recovery_Speed_Unsheathed_raw == value) return;
                    Recovery_Speed_Unsheathed_raw = value;
                    ChangedItems.Add(nameof(Recovery_Speed_Unsheathed));
                    OnPropertyChanged(nameof(Recovery_Speed_Unsheathed));
                }
            }

            protected float Recovery_Speed_Sheathed_raw;
            public const string Recovery_Speed_Sheathed_displayName = "Recovery Speed: Sheathed";
            public const int Recovery_Speed_Sheathed_sortIndex = 300;
            [SortOrder(Recovery_Speed_Sheathed_sortIndex)]
            [DisplayName(Recovery_Speed_Sheathed_displayName)]
            public virtual float Recovery_Speed_Sheathed {
                get => Recovery_Speed_Sheathed_raw;
                set {
                    if (Recovery_Speed_Sheathed_raw == value) return;
                    Recovery_Speed_Sheathed_raw = value;
                    ChangedItems.Add(nameof(Recovery_Speed_Sheathed));
                    OnPropertyChanged(nameof(Recovery_Speed_Sheathed));
                }
            }

            protected float Consumption_per_Hit_raw;
            public const string Consumption_per_Hit_displayName = "Consumption per Hit";
            public const int Consumption_per_Hit_sortIndex = 350;
            [SortOrder(Consumption_per_Hit_sortIndex)]
            [DisplayName(Consumption_per_Hit_displayName)]
            public virtual float Consumption_per_Hit {
                get => Consumption_per_Hit_raw;
                set {
                    if (Consumption_per_Hit_raw == value) return;
                    Consumption_per_Hit_raw = value;
                    ChangedItems.Add(nameof(Consumption_per_Hit));
                    OnPropertyChanged(nameof(Consumption_per_Hit));
                }
            }

            public const int lastSortIndex = 400;

            public static ObservableMhwStructCollection<Frostcraft_1_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Frostcraft_1_>();
                const ulong count = 14UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Frostcraft_1_ LoadData(BinaryReader reader, ulong i) {
                var data = new Frostcraft_1_();
                data.Index = i;
                data.Level_Multiplier_0_15__raw = reader.ReadSingle();
                data.Level_Multiplier_16_45__raw = reader.ReadSingle();
                data.Level_Multiplier_46_80__raw = reader.ReadSingle();
                data.Level_Multiplier_81_100__raw = reader.ReadSingle();
                data.Recovery_Speed_Unsheathed_raw = reader.ReadSingle();
                data.Recovery_Speed_Sheathed_raw = reader.ReadSingle();
                data.Consumption_per_Hit_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Level_Multiplier_0_15__raw);
                writer.Write(Level_Multiplier_16_45__raw);
                writer.Write(Level_Multiplier_46_80__raw);
                writer.Write(Level_Multiplier_81_100__raw);
                writer.Write(Recovery_Speed_Unsheathed_raw);
                writer.Write(Recovery_Speed_Sheathed_raw);
                writer.Write(Consumption_per_Hit_raw);
            }
        }

        public partial class Frostcraft_2_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Frostcraft (2)";

            protected byte Unk30_raw;
            public const string Unk30_displayName = "Unk30";
            public const int Unk30_sortIndex = 50;
            [SortOrder(Unk30_sortIndex)]
            [DisplayName(Unk30_displayName)]
            public virtual byte Unk30 {
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

            protected byte Unk31_raw;
            public const string Unk31_displayName = "Unk31";
            public const int Unk31_sortIndex = 100;
            [SortOrder(Unk31_sortIndex)]
            [DisplayName(Unk31_displayName)]
            public virtual byte Unk31 {
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

            protected byte Unk32_raw;
            public const string Unk32_displayName = "Unk32";
            public const int Unk32_sortIndex = 150;
            [SortOrder(Unk32_sortIndex)]
            [DisplayName(Unk32_displayName)]
            public virtual byte Unk32 {
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

            protected byte Frostcraft_Bow_Rapid_Shot_Clutch_Claw_Arrow_Consumption_per_Hit_raw;
            public const string Frostcraft_Bow_Rapid_Shot_Clutch_Claw_Arrow_Consumption_per_Hit_displayName = "Frostcraft: Bow: (Rapid Shot & Clutch Claw Arrow) Consumption per Hit";
            public const int Frostcraft_Bow_Rapid_Shot_Clutch_Claw_Arrow_Consumption_per_Hit_sortIndex = 200;
            [SortOrder(Frostcraft_Bow_Rapid_Shot_Clutch_Claw_Arrow_Consumption_per_Hit_sortIndex)]
            [DisplayName(Frostcraft_Bow_Rapid_Shot_Clutch_Claw_Arrow_Consumption_per_Hit_displayName)]
            public virtual byte Frostcraft_Bow_Rapid_Shot_Clutch_Claw_Arrow_Consumption_per_Hit {
                get => Frostcraft_Bow_Rapid_Shot_Clutch_Claw_Arrow_Consumption_per_Hit_raw;
                set {
                    if (Frostcraft_Bow_Rapid_Shot_Clutch_Claw_Arrow_Consumption_per_Hit_raw == value) return;
                    Frostcraft_Bow_Rapid_Shot_Clutch_Claw_Arrow_Consumption_per_Hit_raw = value;
                    ChangedItems.Add(nameof(Frostcraft_Bow_Rapid_Shot_Clutch_Claw_Arrow_Consumption_per_Hit));
                    OnPropertyChanged(nameof(Frostcraft_Bow_Rapid_Shot_Clutch_Claw_Arrow_Consumption_per_Hit));
                }
            }

            [DisplayName("Offset")]
            public long Frostcraft_Bow_Rapid_Shot_Clutch_Claw_Arrow_Consumption_per_Hit_offset { get; private set; }

            protected byte Frostcraft_Bow_Power_Shot_Consumption_per_Hit_raw;
            public const string Frostcraft_Bow_Power_Shot_Consumption_per_Hit_displayName = "Frostcraft: Bow: (Power Shot) Consumption per Hit";
            public const int Frostcraft_Bow_Power_Shot_Consumption_per_Hit_sortIndex = 250;
            [SortOrder(Frostcraft_Bow_Power_Shot_Consumption_per_Hit_sortIndex)]
            [DisplayName(Frostcraft_Bow_Power_Shot_Consumption_per_Hit_displayName)]
            public virtual byte Frostcraft_Bow_Power_Shot_Consumption_per_Hit {
                get => Frostcraft_Bow_Power_Shot_Consumption_per_Hit_raw;
                set {
                    if (Frostcraft_Bow_Power_Shot_Consumption_per_Hit_raw == value) return;
                    Frostcraft_Bow_Power_Shot_Consumption_per_Hit_raw = value;
                    ChangedItems.Add(nameof(Frostcraft_Bow_Power_Shot_Consumption_per_Hit));
                    OnPropertyChanged(nameof(Frostcraft_Bow_Power_Shot_Consumption_per_Hit));
                }
            }

            [DisplayName("Offset")]
            public long Frostcraft_Bow_Power_Shot_Consumption_per_Hit_offset { get; private set; }

            protected byte Frostcraft_Bow_Arc_Shot_Consumption_per_Hit_raw;
            public const string Frostcraft_Bow_Arc_Shot_Consumption_per_Hit_displayName = "Frostcraft: Bow: (Arc Shot) Consumption per Hit";
            public const int Frostcraft_Bow_Arc_Shot_Consumption_per_Hit_sortIndex = 300;
            [SortOrder(Frostcraft_Bow_Arc_Shot_Consumption_per_Hit_sortIndex)]
            [DisplayName(Frostcraft_Bow_Arc_Shot_Consumption_per_Hit_displayName)]
            public virtual byte Frostcraft_Bow_Arc_Shot_Consumption_per_Hit {
                get => Frostcraft_Bow_Arc_Shot_Consumption_per_Hit_raw;
                set {
                    if (Frostcraft_Bow_Arc_Shot_Consumption_per_Hit_raw == value) return;
                    Frostcraft_Bow_Arc_Shot_Consumption_per_Hit_raw = value;
                    ChangedItems.Add(nameof(Frostcraft_Bow_Arc_Shot_Consumption_per_Hit));
                    OnPropertyChanged(nameof(Frostcraft_Bow_Arc_Shot_Consumption_per_Hit));
                }
            }

            [DisplayName("Offset")]
            public long Frostcraft_Bow_Arc_Shot_Consumption_per_Hit_offset { get; private set; }

            protected byte Frostcraft_Bow_Dragonpiercer_Consumption_per_Hit_raw;
            public const string Frostcraft_Bow_Dragonpiercer_Consumption_per_Hit_displayName = "Frostcraft: Bow: (Dragonpiercer) Consumption per Hit";
            public const int Frostcraft_Bow_Dragonpiercer_Consumption_per_Hit_sortIndex = 350;
            [SortOrder(Frostcraft_Bow_Dragonpiercer_Consumption_per_Hit_sortIndex)]
            [DisplayName(Frostcraft_Bow_Dragonpiercer_Consumption_per_Hit_displayName)]
            public virtual byte Frostcraft_Bow_Dragonpiercer_Consumption_per_Hit {
                get => Frostcraft_Bow_Dragonpiercer_Consumption_per_Hit_raw;
                set {
                    if (Frostcraft_Bow_Dragonpiercer_Consumption_per_Hit_raw == value) return;
                    Frostcraft_Bow_Dragonpiercer_Consumption_per_Hit_raw = value;
                    ChangedItems.Add(nameof(Frostcraft_Bow_Dragonpiercer_Consumption_per_Hit));
                    OnPropertyChanged(nameof(Frostcraft_Bow_Dragonpiercer_Consumption_per_Hit));
                }
            }

            [DisplayName("Offset")]
            public long Frostcraft_Bow_Dragonpiercer_Consumption_per_Hit_offset { get; private set; }

            protected byte Frostcraft_Bow_Thousand_Dragons_Consumption_per_Hit_raw;
            public const string Frostcraft_Bow_Thousand_Dragons_Consumption_per_Hit_displayName = "Frostcraft: Bow: (Thousand Dragons) Consumption per Hit";
            public const int Frostcraft_Bow_Thousand_Dragons_Consumption_per_Hit_sortIndex = 400;
            [SortOrder(Frostcraft_Bow_Thousand_Dragons_Consumption_per_Hit_sortIndex)]
            [DisplayName(Frostcraft_Bow_Thousand_Dragons_Consumption_per_Hit_displayName)]
            public virtual byte Frostcraft_Bow_Thousand_Dragons_Consumption_per_Hit {
                get => Frostcraft_Bow_Thousand_Dragons_Consumption_per_Hit_raw;
                set {
                    if (Frostcraft_Bow_Thousand_Dragons_Consumption_per_Hit_raw == value) return;
                    Frostcraft_Bow_Thousand_Dragons_Consumption_per_Hit_raw = value;
                    ChangedItems.Add(nameof(Frostcraft_Bow_Thousand_Dragons_Consumption_per_Hit));
                    OnPropertyChanged(nameof(Frostcraft_Bow_Thousand_Dragons_Consumption_per_Hit));
                }
            }

            [DisplayName("Offset")]
            public long Frostcraft_Bow_Thousand_Dragons_Consumption_per_Hit_offset { get; private set; }

            protected byte Frostcraft_Bowgun_Normal_Ammo_Consumption_per_Hit_raw;
            public const string Frostcraft_Bowgun_Normal_Ammo_Consumption_per_Hit_displayName = "Frostcraft: Bowgun: (Normal Ammo) Consumption per Hit";
            public const int Frostcraft_Bowgun_Normal_Ammo_Consumption_per_Hit_sortIndex = 450;
            [SortOrder(Frostcraft_Bowgun_Normal_Ammo_Consumption_per_Hit_sortIndex)]
            [DisplayName(Frostcraft_Bowgun_Normal_Ammo_Consumption_per_Hit_displayName)]
            public virtual byte Frostcraft_Bowgun_Normal_Ammo_Consumption_per_Hit {
                get => Frostcraft_Bowgun_Normal_Ammo_Consumption_per_Hit_raw;
                set {
                    if (Frostcraft_Bowgun_Normal_Ammo_Consumption_per_Hit_raw == value) return;
                    Frostcraft_Bowgun_Normal_Ammo_Consumption_per_Hit_raw = value;
                    ChangedItems.Add(nameof(Frostcraft_Bowgun_Normal_Ammo_Consumption_per_Hit));
                    OnPropertyChanged(nameof(Frostcraft_Bowgun_Normal_Ammo_Consumption_per_Hit));
                }
            }

            [DisplayName("Offset")]
            public long Frostcraft_Bowgun_Normal_Ammo_Consumption_per_Hit_offset { get; private set; }

            protected byte Frostcraft_Bowgun_Pierce_Ammo_Consumption_per_Hit_raw;
            public const string Frostcraft_Bowgun_Pierce_Ammo_Consumption_per_Hit_displayName = "Frostcraft: Bowgun: (Pierce Ammo) Consumption per Hit";
            public const int Frostcraft_Bowgun_Pierce_Ammo_Consumption_per_Hit_sortIndex = 500;
            [SortOrder(Frostcraft_Bowgun_Pierce_Ammo_Consumption_per_Hit_sortIndex)]
            [DisplayName(Frostcraft_Bowgun_Pierce_Ammo_Consumption_per_Hit_displayName)]
            public virtual byte Frostcraft_Bowgun_Pierce_Ammo_Consumption_per_Hit {
                get => Frostcraft_Bowgun_Pierce_Ammo_Consumption_per_Hit_raw;
                set {
                    if (Frostcraft_Bowgun_Pierce_Ammo_Consumption_per_Hit_raw == value) return;
                    Frostcraft_Bowgun_Pierce_Ammo_Consumption_per_Hit_raw = value;
                    ChangedItems.Add(nameof(Frostcraft_Bowgun_Pierce_Ammo_Consumption_per_Hit));
                    OnPropertyChanged(nameof(Frostcraft_Bowgun_Pierce_Ammo_Consumption_per_Hit));
                }
            }

            [DisplayName("Offset")]
            public long Frostcraft_Bowgun_Pierce_Ammo_Consumption_per_Hit_offset { get; private set; }

            protected byte Frostcraft_Bowgun_Spread_Ammo_Consumption_per_Hit_raw;
            public const string Frostcraft_Bowgun_Spread_Ammo_Consumption_per_Hit_displayName = "Frostcraft: Bowgun: (Spread Ammo) Consumption per Hit";
            public const int Frostcraft_Bowgun_Spread_Ammo_Consumption_per_Hit_sortIndex = 550;
            [SortOrder(Frostcraft_Bowgun_Spread_Ammo_Consumption_per_Hit_sortIndex)]
            [DisplayName(Frostcraft_Bowgun_Spread_Ammo_Consumption_per_Hit_displayName)]
            public virtual byte Frostcraft_Bowgun_Spread_Ammo_Consumption_per_Hit {
                get => Frostcraft_Bowgun_Spread_Ammo_Consumption_per_Hit_raw;
                set {
                    if (Frostcraft_Bowgun_Spread_Ammo_Consumption_per_Hit_raw == value) return;
                    Frostcraft_Bowgun_Spread_Ammo_Consumption_per_Hit_raw = value;
                    ChangedItems.Add(nameof(Frostcraft_Bowgun_Spread_Ammo_Consumption_per_Hit));
                    OnPropertyChanged(nameof(Frostcraft_Bowgun_Spread_Ammo_Consumption_per_Hit));
                }
            }

            [DisplayName("Offset")]
            public long Frostcraft_Bowgun_Spread_Ammo_Consumption_per_Hit_offset { get; private set; }

            protected byte Frostcraft_Bowgun_Sticky_Ammo_Consumption_per_Hit_raw;
            public const string Frostcraft_Bowgun_Sticky_Ammo_Consumption_per_Hit_displayName = "Frostcraft: Bowgun: (Sticky Ammo) Consumption per Hit";
            public const int Frostcraft_Bowgun_Sticky_Ammo_Consumption_per_Hit_sortIndex = 600;
            [SortOrder(Frostcraft_Bowgun_Sticky_Ammo_Consumption_per_Hit_sortIndex)]
            [DisplayName(Frostcraft_Bowgun_Sticky_Ammo_Consumption_per_Hit_displayName)]
            public virtual byte Frostcraft_Bowgun_Sticky_Ammo_Consumption_per_Hit {
                get => Frostcraft_Bowgun_Sticky_Ammo_Consumption_per_Hit_raw;
                set {
                    if (Frostcraft_Bowgun_Sticky_Ammo_Consumption_per_Hit_raw == value) return;
                    Frostcraft_Bowgun_Sticky_Ammo_Consumption_per_Hit_raw = value;
                    ChangedItems.Add(nameof(Frostcraft_Bowgun_Sticky_Ammo_Consumption_per_Hit));
                    OnPropertyChanged(nameof(Frostcraft_Bowgun_Sticky_Ammo_Consumption_per_Hit));
                }
            }

            [DisplayName("Offset")]
            public long Frostcraft_Bowgun_Sticky_Ammo_Consumption_per_Hit_offset { get; private set; }

            protected byte Frostcraft_Bowgun_Cluster_Ammo_Consumption_per_Hit_raw;
            public const string Frostcraft_Bowgun_Cluster_Ammo_Consumption_per_Hit_displayName = "Frostcraft: Bowgun: (Cluster Ammo) Consumption per Hit";
            public const int Frostcraft_Bowgun_Cluster_Ammo_Consumption_per_Hit_sortIndex = 650;
            [SortOrder(Frostcraft_Bowgun_Cluster_Ammo_Consumption_per_Hit_sortIndex)]
            [DisplayName(Frostcraft_Bowgun_Cluster_Ammo_Consumption_per_Hit_displayName)]
            public virtual byte Frostcraft_Bowgun_Cluster_Ammo_Consumption_per_Hit {
                get => Frostcraft_Bowgun_Cluster_Ammo_Consumption_per_Hit_raw;
                set {
                    if (Frostcraft_Bowgun_Cluster_Ammo_Consumption_per_Hit_raw == value) return;
                    Frostcraft_Bowgun_Cluster_Ammo_Consumption_per_Hit_raw = value;
                    ChangedItems.Add(nameof(Frostcraft_Bowgun_Cluster_Ammo_Consumption_per_Hit));
                    OnPropertyChanged(nameof(Frostcraft_Bowgun_Cluster_Ammo_Consumption_per_Hit));
                }
            }

            [DisplayName("Offset")]
            public long Frostcraft_Bowgun_Cluster_Ammo_Consumption_per_Hit_offset { get; private set; }

            protected byte Frostcraft_Bowgun_Elemental_Ammo_Consumption_per_Hit_raw;
            public const string Frostcraft_Bowgun_Elemental_Ammo_Consumption_per_Hit_displayName = "Frostcraft: Bowgun: (Elemental Ammo) Consumption per Hit";
            public const int Frostcraft_Bowgun_Elemental_Ammo_Consumption_per_Hit_sortIndex = 700;
            [SortOrder(Frostcraft_Bowgun_Elemental_Ammo_Consumption_per_Hit_sortIndex)]
            [DisplayName(Frostcraft_Bowgun_Elemental_Ammo_Consumption_per_Hit_displayName)]
            public virtual byte Frostcraft_Bowgun_Elemental_Ammo_Consumption_per_Hit {
                get => Frostcraft_Bowgun_Elemental_Ammo_Consumption_per_Hit_raw;
                set {
                    if (Frostcraft_Bowgun_Elemental_Ammo_Consumption_per_Hit_raw == value) return;
                    Frostcraft_Bowgun_Elemental_Ammo_Consumption_per_Hit_raw = value;
                    ChangedItems.Add(nameof(Frostcraft_Bowgun_Elemental_Ammo_Consumption_per_Hit));
                    OnPropertyChanged(nameof(Frostcraft_Bowgun_Elemental_Ammo_Consumption_per_Hit));
                }
            }

            [DisplayName("Offset")]
            public long Frostcraft_Bowgun_Elemental_Ammo_Consumption_per_Hit_offset { get; private set; }

            protected byte Frostcraft_Bowgun_Status_Ammo_Consumption_per_Hit_raw;
            public const string Frostcraft_Bowgun_Status_Ammo_Consumption_per_Hit_displayName = "Frostcraft: Bowgun: (Status Ammo) Consumption per Hit";
            public const int Frostcraft_Bowgun_Status_Ammo_Consumption_per_Hit_sortIndex = 750;
            [SortOrder(Frostcraft_Bowgun_Status_Ammo_Consumption_per_Hit_sortIndex)]
            [DisplayName(Frostcraft_Bowgun_Status_Ammo_Consumption_per_Hit_displayName)]
            public virtual byte Frostcraft_Bowgun_Status_Ammo_Consumption_per_Hit {
                get => Frostcraft_Bowgun_Status_Ammo_Consumption_per_Hit_raw;
                set {
                    if (Frostcraft_Bowgun_Status_Ammo_Consumption_per_Hit_raw == value) return;
                    Frostcraft_Bowgun_Status_Ammo_Consumption_per_Hit_raw = value;
                    ChangedItems.Add(nameof(Frostcraft_Bowgun_Status_Ammo_Consumption_per_Hit));
                    OnPropertyChanged(nameof(Frostcraft_Bowgun_Status_Ammo_Consumption_per_Hit));
                }
            }

            [DisplayName("Offset")]
            public long Frostcraft_Bowgun_Status_Ammo_Consumption_per_Hit_offset { get; private set; }

            protected byte Frostcraft_Bowgun_Wyvern_Ammo_Consumption_per_Hit_raw;
            public const string Frostcraft_Bowgun_Wyvern_Ammo_Consumption_per_Hit_displayName = "Frostcraft: Bowgun: (Wyvern Ammo) Consumption per Hit";
            public const int Frostcraft_Bowgun_Wyvern_Ammo_Consumption_per_Hit_sortIndex = 800;
            [SortOrder(Frostcraft_Bowgun_Wyvern_Ammo_Consumption_per_Hit_sortIndex)]
            [DisplayName(Frostcraft_Bowgun_Wyvern_Ammo_Consumption_per_Hit_displayName)]
            public virtual byte Frostcraft_Bowgun_Wyvern_Ammo_Consumption_per_Hit {
                get => Frostcraft_Bowgun_Wyvern_Ammo_Consumption_per_Hit_raw;
                set {
                    if (Frostcraft_Bowgun_Wyvern_Ammo_Consumption_per_Hit_raw == value) return;
                    Frostcraft_Bowgun_Wyvern_Ammo_Consumption_per_Hit_raw = value;
                    ChangedItems.Add(nameof(Frostcraft_Bowgun_Wyvern_Ammo_Consumption_per_Hit));
                    OnPropertyChanged(nameof(Frostcraft_Bowgun_Wyvern_Ammo_Consumption_per_Hit));
                }
            }

            [DisplayName("Offset")]
            public long Frostcraft_Bowgun_Wyvern_Ammo_Consumption_per_Hit_offset { get; private set; }

            protected byte Frostcraft_Bowgun_Slicing_Ammo_Consumption_per_Hit_raw;
            public const string Frostcraft_Bowgun_Slicing_Ammo_Consumption_per_Hit_displayName = "Frostcraft: Bowgun: (Slicing Ammo) Consumption per Hit";
            public const int Frostcraft_Bowgun_Slicing_Ammo_Consumption_per_Hit_sortIndex = 850;
            [SortOrder(Frostcraft_Bowgun_Slicing_Ammo_Consumption_per_Hit_sortIndex)]
            [DisplayName(Frostcraft_Bowgun_Slicing_Ammo_Consumption_per_Hit_displayName)]
            public virtual byte Frostcraft_Bowgun_Slicing_Ammo_Consumption_per_Hit {
                get => Frostcraft_Bowgun_Slicing_Ammo_Consumption_per_Hit_raw;
                set {
                    if (Frostcraft_Bowgun_Slicing_Ammo_Consumption_per_Hit_raw == value) return;
                    Frostcraft_Bowgun_Slicing_Ammo_Consumption_per_Hit_raw = value;
                    ChangedItems.Add(nameof(Frostcraft_Bowgun_Slicing_Ammo_Consumption_per_Hit));
                    OnPropertyChanged(nameof(Frostcraft_Bowgun_Slicing_Ammo_Consumption_per_Hit));
                }
            }

            [DisplayName("Offset")]
            public long Frostcraft_Bowgun_Slicing_Ammo_Consumption_per_Hit_offset { get; private set; }

            protected byte Frostcraft_HBG_Wyvernheart_Consumption_per_Hit_raw;
            public const string Frostcraft_HBG_Wyvernheart_Consumption_per_Hit_displayName = "Frostcraft: HBG: (Wyvernheart) Consumption per Hit";
            public const int Frostcraft_HBG_Wyvernheart_Consumption_per_Hit_sortIndex = 900;
            [SortOrder(Frostcraft_HBG_Wyvernheart_Consumption_per_Hit_sortIndex)]
            [DisplayName(Frostcraft_HBG_Wyvernheart_Consumption_per_Hit_displayName)]
            public virtual byte Frostcraft_HBG_Wyvernheart_Consumption_per_Hit {
                get => Frostcraft_HBG_Wyvernheart_Consumption_per_Hit_raw;
                set {
                    if (Frostcraft_HBG_Wyvernheart_Consumption_per_Hit_raw == value) return;
                    Frostcraft_HBG_Wyvernheart_Consumption_per_Hit_raw = value;
                    ChangedItems.Add(nameof(Frostcraft_HBG_Wyvernheart_Consumption_per_Hit));
                    OnPropertyChanged(nameof(Frostcraft_HBG_Wyvernheart_Consumption_per_Hit));
                }
            }

            [DisplayName("Offset")]
            public long Frostcraft_HBG_Wyvernheart_Consumption_per_Hit_offset { get; private set; }

            protected byte Frostcraft_HBG_Wyvernsnipe_Consumption_per_Hit_raw;
            public const string Frostcraft_HBG_Wyvernsnipe_Consumption_per_Hit_displayName = "Frostcraft: HBG: (Wyvernsnipe) Consumption per Hit";
            public const int Frostcraft_HBG_Wyvernsnipe_Consumption_per_Hit_sortIndex = 950;
            [SortOrder(Frostcraft_HBG_Wyvernsnipe_Consumption_per_Hit_sortIndex)]
            [DisplayName(Frostcraft_HBG_Wyvernsnipe_Consumption_per_Hit_displayName)]
            public virtual byte Frostcraft_HBG_Wyvernsnipe_Consumption_per_Hit {
                get => Frostcraft_HBG_Wyvernsnipe_Consumption_per_Hit_raw;
                set {
                    if (Frostcraft_HBG_Wyvernsnipe_Consumption_per_Hit_raw == value) return;
                    Frostcraft_HBG_Wyvernsnipe_Consumption_per_Hit_raw = value;
                    ChangedItems.Add(nameof(Frostcraft_HBG_Wyvernsnipe_Consumption_per_Hit));
                    OnPropertyChanged(nameof(Frostcraft_HBG_Wyvernsnipe_Consumption_per_Hit));
                }
            }

            [DisplayName("Offset")]
            public long Frostcraft_HBG_Wyvernsnipe_Consumption_per_Hit_offset { get; private set; }

            protected byte Frostcraft_HBG_Wyvernsnipe_Type_2_Consumption_per_Hit_raw;
            public const string Frostcraft_HBG_Wyvernsnipe_Type_2_Consumption_per_Hit_displayName = "Frostcraft: HBG: (Wyvernsnipe Type 2) Consumption per Hit";
            public const int Frostcraft_HBG_Wyvernsnipe_Type_2_Consumption_per_Hit_sortIndex = 1000;
            [SortOrder(Frostcraft_HBG_Wyvernsnipe_Type_2_Consumption_per_Hit_sortIndex)]
            [DisplayName(Frostcraft_HBG_Wyvernsnipe_Type_2_Consumption_per_Hit_displayName)]
            public virtual byte Frostcraft_HBG_Wyvernsnipe_Type_2_Consumption_per_Hit {
                get => Frostcraft_HBG_Wyvernsnipe_Type_2_Consumption_per_Hit_raw;
                set {
                    if (Frostcraft_HBG_Wyvernsnipe_Type_2_Consumption_per_Hit_raw == value) return;
                    Frostcraft_HBG_Wyvernsnipe_Type_2_Consumption_per_Hit_raw = value;
                    ChangedItems.Add(nameof(Frostcraft_HBG_Wyvernsnipe_Type_2_Consumption_per_Hit));
                    OnPropertyChanged(nameof(Frostcraft_HBG_Wyvernsnipe_Type_2_Consumption_per_Hit));
                }
            }

            [DisplayName("Offset")]
            public long Frostcraft_HBG_Wyvernsnipe_Type_2_Consumption_per_Hit_offset { get; private set; }

            protected byte Frostcraft_HBG_Claw_Wyvernheart_Gatling_Consumption_per_Hit_raw;
            public const string Frostcraft_HBG_Claw_Wyvernheart_Gatling_Consumption_per_Hit_displayName = "Frostcraft: HBG: (Claw Wyvernheart Gatling) Consumption per Hit";
            public const int Frostcraft_HBG_Claw_Wyvernheart_Gatling_Consumption_per_Hit_sortIndex = 1050;
            [SortOrder(Frostcraft_HBG_Claw_Wyvernheart_Gatling_Consumption_per_Hit_sortIndex)]
            [DisplayName(Frostcraft_HBG_Claw_Wyvernheart_Gatling_Consumption_per_Hit_displayName)]
            public virtual byte Frostcraft_HBG_Claw_Wyvernheart_Gatling_Consumption_per_Hit {
                get => Frostcraft_HBG_Claw_Wyvernheart_Gatling_Consumption_per_Hit_raw;
                set {
                    if (Frostcraft_HBG_Claw_Wyvernheart_Gatling_Consumption_per_Hit_raw == value) return;
                    Frostcraft_HBG_Claw_Wyvernheart_Gatling_Consumption_per_Hit_raw = value;
                    ChangedItems.Add(nameof(Frostcraft_HBG_Claw_Wyvernheart_Gatling_Consumption_per_Hit));
                    OnPropertyChanged(nameof(Frostcraft_HBG_Claw_Wyvernheart_Gatling_Consumption_per_Hit));
                }
            }

            [DisplayName("Offset")]
            public long Frostcraft_HBG_Claw_Wyvernheart_Gatling_Consumption_per_Hit_offset { get; private set; }

            protected byte Frostcraft_HBG_Claw_Wyvernheart_Finish_Consumption_per_Hit_raw;
            public const string Frostcraft_HBG_Claw_Wyvernheart_Finish_Consumption_per_Hit_displayName = "Frostcraft: HBG: (Claw Wyvernheart Finish) Consumption per Hit";
            public const int Frostcraft_HBG_Claw_Wyvernheart_Finish_Consumption_per_Hit_sortIndex = 1100;
            [SortOrder(Frostcraft_HBG_Claw_Wyvernheart_Finish_Consumption_per_Hit_sortIndex)]
            [DisplayName(Frostcraft_HBG_Claw_Wyvernheart_Finish_Consumption_per_Hit_displayName)]
            public virtual byte Frostcraft_HBG_Claw_Wyvernheart_Finish_Consumption_per_Hit {
                get => Frostcraft_HBG_Claw_Wyvernheart_Finish_Consumption_per_Hit_raw;
                set {
                    if (Frostcraft_HBG_Claw_Wyvernheart_Finish_Consumption_per_Hit_raw == value) return;
                    Frostcraft_HBG_Claw_Wyvernheart_Finish_Consumption_per_Hit_raw = value;
                    ChangedItems.Add(nameof(Frostcraft_HBG_Claw_Wyvernheart_Finish_Consumption_per_Hit));
                    OnPropertyChanged(nameof(Frostcraft_HBG_Claw_Wyvernheart_Finish_Consumption_per_Hit));
                }
            }

            [DisplayName("Offset")]
            public long Frostcraft_HBG_Claw_Wyvernheart_Finish_Consumption_per_Hit_offset { get; private set; }

            protected byte Frostcraft_HBG_Wyvernsnipe_Claw_Consumption_per_Hit_raw;
            public const string Frostcraft_HBG_Wyvernsnipe_Claw_Consumption_per_Hit_displayName = "Frostcraft: HBG: (Wyvernsnipe Claw) Consumption per Hit";
            public const int Frostcraft_HBG_Wyvernsnipe_Claw_Consumption_per_Hit_sortIndex = 1150;
            [SortOrder(Frostcraft_HBG_Wyvernsnipe_Claw_Consumption_per_Hit_sortIndex)]
            [DisplayName(Frostcraft_HBG_Wyvernsnipe_Claw_Consumption_per_Hit_displayName)]
            public virtual byte Frostcraft_HBG_Wyvernsnipe_Claw_Consumption_per_Hit {
                get => Frostcraft_HBG_Wyvernsnipe_Claw_Consumption_per_Hit_raw;
                set {
                    if (Frostcraft_HBG_Wyvernsnipe_Claw_Consumption_per_Hit_raw == value) return;
                    Frostcraft_HBG_Wyvernsnipe_Claw_Consumption_per_Hit_raw = value;
                    ChangedItems.Add(nameof(Frostcraft_HBG_Wyvernsnipe_Claw_Consumption_per_Hit));
                    OnPropertyChanged(nameof(Frostcraft_HBG_Wyvernsnipe_Claw_Consumption_per_Hit));
                }
            }

            [DisplayName("Offset")]
            public long Frostcraft_HBG_Wyvernsnipe_Claw_Consumption_per_Hit_offset { get; private set; }

            protected byte Frostcraft_LBG_Wyvernblast_Consumption_per_Hit_raw;
            public const string Frostcraft_LBG_Wyvernblast_Consumption_per_Hit_displayName = "Frostcraft: LBG: (Wyvernblast) Consumption per Hit";
            public const int Frostcraft_LBG_Wyvernblast_Consumption_per_Hit_sortIndex = 1200;
            [SortOrder(Frostcraft_LBG_Wyvernblast_Consumption_per_Hit_sortIndex)]
            [DisplayName(Frostcraft_LBG_Wyvernblast_Consumption_per_Hit_displayName)]
            public virtual byte Frostcraft_LBG_Wyvernblast_Consumption_per_Hit {
                get => Frostcraft_LBG_Wyvernblast_Consumption_per_Hit_raw;
                set {
                    if (Frostcraft_LBG_Wyvernblast_Consumption_per_Hit_raw == value) return;
                    Frostcraft_LBG_Wyvernblast_Consumption_per_Hit_raw = value;
                    ChangedItems.Add(nameof(Frostcraft_LBG_Wyvernblast_Consumption_per_Hit));
                    OnPropertyChanged(nameof(Frostcraft_LBG_Wyvernblast_Consumption_per_Hit));
                }
            }

            [DisplayName("Offset")]
            public long Frostcraft_LBG_Wyvernblast_Consumption_per_Hit_offset { get; private set; }

            protected byte Frostcraft_LBG_Wyvernblast_Claw_Consumption_per_Hit_raw;
            public const string Frostcraft_LBG_Wyvernblast_Claw_Consumption_per_Hit_displayName = "Frostcraft: LBG: (Wyvernblast Claw) Consumption per Hit";
            public const int Frostcraft_LBG_Wyvernblast_Claw_Consumption_per_Hit_sortIndex = 1250;
            [SortOrder(Frostcraft_LBG_Wyvernblast_Claw_Consumption_per_Hit_sortIndex)]
            [DisplayName(Frostcraft_LBG_Wyvernblast_Claw_Consumption_per_Hit_displayName)]
            public virtual byte Frostcraft_LBG_Wyvernblast_Claw_Consumption_per_Hit {
                get => Frostcraft_LBG_Wyvernblast_Claw_Consumption_per_Hit_raw;
                set {
                    if (Frostcraft_LBG_Wyvernblast_Claw_Consumption_per_Hit_raw == value) return;
                    Frostcraft_LBG_Wyvernblast_Claw_Consumption_per_Hit_raw = value;
                    ChangedItems.Add(nameof(Frostcraft_LBG_Wyvernblast_Claw_Consumption_per_Hit));
                    OnPropertyChanged(nameof(Frostcraft_LBG_Wyvernblast_Claw_Consumption_per_Hit));
                }
            }

            [DisplayName("Offset")]
            public long Frostcraft_LBG_Wyvernblast_Claw_Consumption_per_Hit_offset { get; private set; }

            public const int lastSortIndex = 1300;

            public static ObservableMhwStructCollection<Frostcraft_2_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Frostcraft_2_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Frostcraft_2_ LoadData(BinaryReader reader, ulong i) {
                var data = new Frostcraft_2_();
                data.Index = i;
                data.Unk30_offset = reader.BaseStream.Position;
                data.Unk30_raw = reader.ReadByte();
                data.Unk31_offset = reader.BaseStream.Position;
                data.Unk31_raw = reader.ReadByte();
                data.Unk32_offset = reader.BaseStream.Position;
                data.Unk32_raw = reader.ReadByte();
                data.Frostcraft_Bow_Rapid_Shot_Clutch_Claw_Arrow_Consumption_per_Hit_offset = reader.BaseStream.Position;
                data.Frostcraft_Bow_Rapid_Shot_Clutch_Claw_Arrow_Consumption_per_Hit_raw = reader.ReadByte();
                data.Frostcraft_Bow_Power_Shot_Consumption_per_Hit_offset = reader.BaseStream.Position;
                data.Frostcraft_Bow_Power_Shot_Consumption_per_Hit_raw = reader.ReadByte();
                data.Frostcraft_Bow_Arc_Shot_Consumption_per_Hit_offset = reader.BaseStream.Position;
                data.Frostcraft_Bow_Arc_Shot_Consumption_per_Hit_raw = reader.ReadByte();
                data.Frostcraft_Bow_Dragonpiercer_Consumption_per_Hit_offset = reader.BaseStream.Position;
                data.Frostcraft_Bow_Dragonpiercer_Consumption_per_Hit_raw = reader.ReadByte();
                data.Frostcraft_Bow_Thousand_Dragons_Consumption_per_Hit_offset = reader.BaseStream.Position;
                data.Frostcraft_Bow_Thousand_Dragons_Consumption_per_Hit_raw = reader.ReadByte();
                data.Frostcraft_Bowgun_Normal_Ammo_Consumption_per_Hit_offset = reader.BaseStream.Position;
                data.Frostcraft_Bowgun_Normal_Ammo_Consumption_per_Hit_raw = reader.ReadByte();
                data.Frostcraft_Bowgun_Pierce_Ammo_Consumption_per_Hit_offset = reader.BaseStream.Position;
                data.Frostcraft_Bowgun_Pierce_Ammo_Consumption_per_Hit_raw = reader.ReadByte();
                data.Frostcraft_Bowgun_Spread_Ammo_Consumption_per_Hit_offset = reader.BaseStream.Position;
                data.Frostcraft_Bowgun_Spread_Ammo_Consumption_per_Hit_raw = reader.ReadByte();
                data.Frostcraft_Bowgun_Sticky_Ammo_Consumption_per_Hit_offset = reader.BaseStream.Position;
                data.Frostcraft_Bowgun_Sticky_Ammo_Consumption_per_Hit_raw = reader.ReadByte();
                data.Frostcraft_Bowgun_Cluster_Ammo_Consumption_per_Hit_offset = reader.BaseStream.Position;
                data.Frostcraft_Bowgun_Cluster_Ammo_Consumption_per_Hit_raw = reader.ReadByte();
                data.Frostcraft_Bowgun_Elemental_Ammo_Consumption_per_Hit_offset = reader.BaseStream.Position;
                data.Frostcraft_Bowgun_Elemental_Ammo_Consumption_per_Hit_raw = reader.ReadByte();
                data.Frostcraft_Bowgun_Status_Ammo_Consumption_per_Hit_offset = reader.BaseStream.Position;
                data.Frostcraft_Bowgun_Status_Ammo_Consumption_per_Hit_raw = reader.ReadByte();
                data.Frostcraft_Bowgun_Wyvern_Ammo_Consumption_per_Hit_offset = reader.BaseStream.Position;
                data.Frostcraft_Bowgun_Wyvern_Ammo_Consumption_per_Hit_raw = reader.ReadByte();
                data.Frostcraft_Bowgun_Slicing_Ammo_Consumption_per_Hit_offset = reader.BaseStream.Position;
                data.Frostcraft_Bowgun_Slicing_Ammo_Consumption_per_Hit_raw = reader.ReadByte();
                data.Frostcraft_HBG_Wyvernheart_Consumption_per_Hit_offset = reader.BaseStream.Position;
                data.Frostcraft_HBG_Wyvernheart_Consumption_per_Hit_raw = reader.ReadByte();
                data.Frostcraft_HBG_Wyvernsnipe_Consumption_per_Hit_offset = reader.BaseStream.Position;
                data.Frostcraft_HBG_Wyvernsnipe_Consumption_per_Hit_raw = reader.ReadByte();
                data.Frostcraft_HBG_Wyvernsnipe_Type_2_Consumption_per_Hit_offset = reader.BaseStream.Position;
                data.Frostcraft_HBG_Wyvernsnipe_Type_2_Consumption_per_Hit_raw = reader.ReadByte();
                data.Frostcraft_HBG_Claw_Wyvernheart_Gatling_Consumption_per_Hit_offset = reader.BaseStream.Position;
                data.Frostcraft_HBG_Claw_Wyvernheart_Gatling_Consumption_per_Hit_raw = reader.ReadByte();
                data.Frostcraft_HBG_Claw_Wyvernheart_Finish_Consumption_per_Hit_offset = reader.BaseStream.Position;
                data.Frostcraft_HBG_Claw_Wyvernheart_Finish_Consumption_per_Hit_raw = reader.ReadByte();
                data.Frostcraft_HBG_Wyvernsnipe_Claw_Consumption_per_Hit_offset = reader.BaseStream.Position;
                data.Frostcraft_HBG_Wyvernsnipe_Claw_Consumption_per_Hit_raw = reader.ReadByte();
                data.Frostcraft_LBG_Wyvernblast_Consumption_per_Hit_offset = reader.BaseStream.Position;
                data.Frostcraft_LBG_Wyvernblast_Consumption_per_Hit_raw = reader.ReadByte();
                data.Frostcraft_LBG_Wyvernblast_Claw_Consumption_per_Hit_offset = reader.BaseStream.Position;
                data.Frostcraft_LBG_Wyvernblast_Claw_Consumption_per_Hit_raw = reader.ReadByte();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk30_raw);
                writer.Write(Unk31_raw);
                writer.Write(Unk32_raw);
                writer.Write(Frostcraft_Bow_Rapid_Shot_Clutch_Claw_Arrow_Consumption_per_Hit_raw);
                writer.Write(Frostcraft_Bow_Power_Shot_Consumption_per_Hit_raw);
                writer.Write(Frostcraft_Bow_Arc_Shot_Consumption_per_Hit_raw);
                writer.Write(Frostcraft_Bow_Dragonpiercer_Consumption_per_Hit_raw);
                writer.Write(Frostcraft_Bow_Thousand_Dragons_Consumption_per_Hit_raw);
                writer.Write(Frostcraft_Bowgun_Normal_Ammo_Consumption_per_Hit_raw);
                writer.Write(Frostcraft_Bowgun_Pierce_Ammo_Consumption_per_Hit_raw);
                writer.Write(Frostcraft_Bowgun_Spread_Ammo_Consumption_per_Hit_raw);
                writer.Write(Frostcraft_Bowgun_Sticky_Ammo_Consumption_per_Hit_raw);
                writer.Write(Frostcraft_Bowgun_Cluster_Ammo_Consumption_per_Hit_raw);
                writer.Write(Frostcraft_Bowgun_Elemental_Ammo_Consumption_per_Hit_raw);
                writer.Write(Frostcraft_Bowgun_Status_Ammo_Consumption_per_Hit_raw);
                writer.Write(Frostcraft_Bowgun_Wyvern_Ammo_Consumption_per_Hit_raw);
                writer.Write(Frostcraft_Bowgun_Slicing_Ammo_Consumption_per_Hit_raw);
                writer.Write(Frostcraft_HBG_Wyvernheart_Consumption_per_Hit_raw);
                writer.Write(Frostcraft_HBG_Wyvernsnipe_Consumption_per_Hit_raw);
                writer.Write(Frostcraft_HBG_Wyvernsnipe_Type_2_Consumption_per_Hit_raw);
                writer.Write(Frostcraft_HBG_Claw_Wyvernheart_Gatling_Consumption_per_Hit_raw);
                writer.Write(Frostcraft_HBG_Claw_Wyvernheart_Finish_Consumption_per_Hit_raw);
                writer.Write(Frostcraft_HBG_Wyvernsnipe_Claw_Consumption_per_Hit_raw);
                writer.Write(Frostcraft_LBG_Wyvernblast_Consumption_per_Hit_raw);
                writer.Write(Frostcraft_LBG_Wyvernblast_Claw_Consumption_per_Hit_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Unk30", "Unk30", "Unk30_offset"),
                    new MultiStructItemCustomView(this, "Unk31", "Unk31", "Unk31_offset"),
                    new MultiStructItemCustomView(this, "Unk32", "Unk32", "Unk32_offset"),
                    new MultiStructItemCustomView(this, "Frostcraft: Bow: (Rapid Shot & Clutch Claw Arrow) Consumption per Hit", "Frostcraft_Bow_Rapid_Shot_Clutch_Claw_Arrow_Consumption_per_Hit", "Frostcraft_Bow_Rapid_Shot_Clutch_Claw_Arrow_Consumption_per_Hit_offset"),
                    new MultiStructItemCustomView(this, "Frostcraft: Bow: (Power Shot) Consumption per Hit", "Frostcraft_Bow_Power_Shot_Consumption_per_Hit", "Frostcraft_Bow_Power_Shot_Consumption_per_Hit_offset"),
                    new MultiStructItemCustomView(this, "Frostcraft: Bow: (Arc Shot) Consumption per Hit", "Frostcraft_Bow_Arc_Shot_Consumption_per_Hit", "Frostcraft_Bow_Arc_Shot_Consumption_per_Hit_offset"),
                    new MultiStructItemCustomView(this, "Frostcraft: Bow: (Dragonpiercer) Consumption per Hit", "Frostcraft_Bow_Dragonpiercer_Consumption_per_Hit", "Frostcraft_Bow_Dragonpiercer_Consumption_per_Hit_offset"),
                    new MultiStructItemCustomView(this, "Frostcraft: Bow: (Thousand Dragons) Consumption per Hit", "Frostcraft_Bow_Thousand_Dragons_Consumption_per_Hit", "Frostcraft_Bow_Thousand_Dragons_Consumption_per_Hit_offset"),
                    new MultiStructItemCustomView(this, "Frostcraft: Bowgun: (Normal Ammo) Consumption per Hit", "Frostcraft_Bowgun_Normal_Ammo_Consumption_per_Hit", "Frostcraft_Bowgun_Normal_Ammo_Consumption_per_Hit_offset"),
                    new MultiStructItemCustomView(this, "Frostcraft: Bowgun: (Pierce Ammo) Consumption per Hit", "Frostcraft_Bowgun_Pierce_Ammo_Consumption_per_Hit", "Frostcraft_Bowgun_Pierce_Ammo_Consumption_per_Hit_offset"),
                    new MultiStructItemCustomView(this, "Frostcraft: Bowgun: (Spread Ammo) Consumption per Hit", "Frostcraft_Bowgun_Spread_Ammo_Consumption_per_Hit", "Frostcraft_Bowgun_Spread_Ammo_Consumption_per_Hit_offset"),
                    new MultiStructItemCustomView(this, "Frostcraft: Bowgun: (Sticky Ammo) Consumption per Hit", "Frostcraft_Bowgun_Sticky_Ammo_Consumption_per_Hit", "Frostcraft_Bowgun_Sticky_Ammo_Consumption_per_Hit_offset"),
                    new MultiStructItemCustomView(this, "Frostcraft: Bowgun: (Cluster Ammo) Consumption per Hit", "Frostcraft_Bowgun_Cluster_Ammo_Consumption_per_Hit", "Frostcraft_Bowgun_Cluster_Ammo_Consumption_per_Hit_offset"),
                    new MultiStructItemCustomView(this, "Frostcraft: Bowgun: (Elemental Ammo) Consumption per Hit", "Frostcraft_Bowgun_Elemental_Ammo_Consumption_per_Hit", "Frostcraft_Bowgun_Elemental_Ammo_Consumption_per_Hit_offset"),
                    new MultiStructItemCustomView(this, "Frostcraft: Bowgun: (Status Ammo) Consumption per Hit", "Frostcraft_Bowgun_Status_Ammo_Consumption_per_Hit", "Frostcraft_Bowgun_Status_Ammo_Consumption_per_Hit_offset"),
                    new MultiStructItemCustomView(this, "Frostcraft: Bowgun: (Wyvern Ammo) Consumption per Hit", "Frostcraft_Bowgun_Wyvern_Ammo_Consumption_per_Hit", "Frostcraft_Bowgun_Wyvern_Ammo_Consumption_per_Hit_offset"),
                    new MultiStructItemCustomView(this, "Frostcraft: Bowgun: (Slicing Ammo) Consumption per Hit", "Frostcraft_Bowgun_Slicing_Ammo_Consumption_per_Hit", "Frostcraft_Bowgun_Slicing_Ammo_Consumption_per_Hit_offset"),
                    new MultiStructItemCustomView(this, "Frostcraft: HBG: (Wyvernheart) Consumption per Hit", "Frostcraft_HBG_Wyvernheart_Consumption_per_Hit", "Frostcraft_HBG_Wyvernheart_Consumption_per_Hit_offset"),
                    new MultiStructItemCustomView(this, "Frostcraft: HBG: (Wyvernsnipe) Consumption per Hit", "Frostcraft_HBG_Wyvernsnipe_Consumption_per_Hit", "Frostcraft_HBG_Wyvernsnipe_Consumption_per_Hit_offset"),
                    new MultiStructItemCustomView(this, "Frostcraft: HBG: (Wyvernsnipe Type 2) Consumption per Hit", "Frostcraft_HBG_Wyvernsnipe_Type_2_Consumption_per_Hit", "Frostcraft_HBG_Wyvernsnipe_Type_2_Consumption_per_Hit_offset"),
                    new MultiStructItemCustomView(this, "Frostcraft: HBG: (Claw Wyvernheart Gatling) Consumption per Hit", "Frostcraft_HBG_Claw_Wyvernheart_Gatling_Consumption_per_Hit", "Frostcraft_HBG_Claw_Wyvernheart_Gatling_Consumption_per_Hit_offset"),
                    new MultiStructItemCustomView(this, "Frostcraft: HBG: (Claw Wyvernheart Finish) Consumption per Hit", "Frostcraft_HBG_Claw_Wyvernheart_Finish_Consumption_per_Hit", "Frostcraft_HBG_Claw_Wyvernheart_Finish_Consumption_per_Hit_offset"),
                    new MultiStructItemCustomView(this, "Frostcraft: HBG: (Wyvernsnipe Claw) Consumption per Hit", "Frostcraft_HBG_Wyvernsnipe_Claw_Consumption_per_Hit", "Frostcraft_HBG_Wyvernsnipe_Claw_Consumption_per_Hit_offset"),
                    new MultiStructItemCustomView(this, "Frostcraft: LBG: (Wyvernblast) Consumption per Hit", "Frostcraft_LBG_Wyvernblast_Consumption_per_Hit", "Frostcraft_LBG_Wyvernblast_Consumption_per_Hit_offset"),
                    new MultiStructItemCustomView(this, "Frostcraft: LBG: (Wyvernblast Claw) Consumption per Hit", "Frostcraft_LBG_Wyvernblast_Claw_Consumption_per_Hit", "Frostcraft_LBG_Wyvernblast_Claw_Consumption_per_Hit_offset"),
                };
            }
        }

        public partial class Skill_Params_7_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Skill Params (7)";

            protected byte Unk_Safi_1_raw;
            public const string Unk_Safi_1_displayName = "Unk Safi 1";
            public const int Unk_Safi_1_sortIndex = 50;
            [SortOrder(Unk_Safi_1_sortIndex)]
            [DisplayName(Unk_Safi_1_displayName)]
            public virtual byte Unk_Safi_1 {
                get => Unk_Safi_1_raw;
                set {
                    if (Unk_Safi_1_raw == value) return;
                    Unk_Safi_1_raw = value;
                    ChangedItems.Add(nameof(Unk_Safi_1));
                    OnPropertyChanged(nameof(Unk_Safi_1));
                }
            }

            [DisplayName("Offset")]
            public long Unk_Safi_1_offset { get; private set; }

            protected float Unk33_raw;
            public const string Unk33_displayName = "Unk33";
            public const int Unk33_sortIndex = 100;
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
            public const int Unk34_sortIndex = 150;
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
            public const int Unk35_sortIndex = 200;
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
            public const int Unk36_sortIndex = 250;
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
            public const int Unk37_sortIndex = 300;
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
            public const int Unk38_sortIndex = 350;
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

            protected float Unk39_raw;
            public const string Unk39_displayName = "Unk39";
            public const int Unk39_sortIndex = 400;
            [SortOrder(Unk39_sortIndex)]
            [DisplayName(Unk39_displayName)]
            public virtual float Unk39 {
                get => Unk39_raw;
                set {
                    if (Unk39_raw == value) return;
                    Unk39_raw = value;
                    ChangedItems.Add(nameof(Unk39));
                    OnPropertyChanged(nameof(Unk39));
                }
            }

            [DisplayName("Offset")]
            public long Unk39_offset { get; private set; }

            protected float Unk40_raw;
            public const string Unk40_displayName = "Unk40";
            public const int Unk40_sortIndex = 450;
            [SortOrder(Unk40_sortIndex)]
            [DisplayName(Unk40_displayName)]
            public virtual float Unk40 {
                get => Unk40_raw;
                set {
                    if (Unk40_raw == value) return;
                    Unk40_raw = value;
                    ChangedItems.Add(nameof(Unk40));
                    OnPropertyChanged(nameof(Unk40));
                }
            }

            [DisplayName("Offset")]
            public long Unk40_offset { get; private set; }

            protected float Unk41_raw;
            public const string Unk41_displayName = "Unk41";
            public const int Unk41_sortIndex = 500;
            [SortOrder(Unk41_sortIndex)]
            [DisplayName(Unk41_displayName)]
            public virtual float Unk41 {
                get => Unk41_raw;
                set {
                    if (Unk41_raw == value) return;
                    Unk41_raw = value;
                    ChangedItems.Add(nameof(Unk41));
                    OnPropertyChanged(nameof(Unk41));
                }
            }

            [DisplayName("Offset")]
            public long Unk41_offset { get; private set; }

            protected float Unk42_raw;
            public const string Unk42_displayName = "Unk42";
            public const int Unk42_sortIndex = 550;
            [SortOrder(Unk42_sortIndex)]
            [DisplayName(Unk42_displayName)]
            public virtual float Unk42 {
                get => Unk42_raw;
                set {
                    if (Unk42_raw == value) return;
                    Unk42_raw = value;
                    ChangedItems.Add(nameof(Unk42));
                    OnPropertyChanged(nameof(Unk42));
                }
            }

            [DisplayName("Offset")]
            public long Unk42_offset { get; private set; }

            protected float Unk43_raw;
            public const string Unk43_displayName = "Unk43";
            public const int Unk43_sortIndex = 600;
            [SortOrder(Unk43_sortIndex)]
            [DisplayName(Unk43_displayName)]
            public virtual float Unk43 {
                get => Unk43_raw;
                set {
                    if (Unk43_raw == value) return;
                    Unk43_raw = value;
                    ChangedItems.Add(nameof(Unk43));
                    OnPropertyChanged(nameof(Unk43));
                }
            }

            [DisplayName("Offset")]
            public long Unk43_offset { get; private set; }

            protected float Unk44_raw;
            public const string Unk44_displayName = "Unk44";
            public const int Unk44_sortIndex = 650;
            [SortOrder(Unk44_sortIndex)]
            [DisplayName(Unk44_displayName)]
            public virtual float Unk44 {
                get => Unk44_raw;
                set {
                    if (Unk44_raw == value) return;
                    Unk44_raw = value;
                    ChangedItems.Add(nameof(Unk44));
                    OnPropertyChanged(nameof(Unk44));
                }
            }

            [DisplayName("Offset")]
            public long Unk44_offset { get; private set; }

            protected float Unk45_raw;
            public const string Unk45_displayName = "Unk45";
            public const int Unk45_sortIndex = 700;
            [SortOrder(Unk45_sortIndex)]
            [DisplayName(Unk45_displayName)]
            public virtual float Unk45 {
                get => Unk45_raw;
                set {
                    if (Unk45_raw == value) return;
                    Unk45_raw = value;
                    ChangedItems.Add(nameof(Unk45));
                    OnPropertyChanged(nameof(Unk45));
                }
            }

            [DisplayName("Offset")]
            public long Unk45_offset { get; private set; }

            protected float Unk46_raw;
            public const string Unk46_displayName = "Unk46";
            public const int Unk46_sortIndex = 750;
            [SortOrder(Unk46_sortIndex)]
            [DisplayName(Unk46_displayName)]
            public virtual float Unk46 {
                get => Unk46_raw;
                set {
                    if (Unk46_raw == value) return;
                    Unk46_raw = value;
                    ChangedItems.Add(nameof(Unk46));
                    OnPropertyChanged(nameof(Unk46));
                }
            }

            [DisplayName("Offset")]
            public long Unk46_offset { get; private set; }

            protected float Unk47_raw;
            public const string Unk47_displayName = "Unk47";
            public const int Unk47_sortIndex = 800;
            [SortOrder(Unk47_sortIndex)]
            [DisplayName(Unk47_displayName)]
            public virtual float Unk47 {
                get => Unk47_raw;
                set {
                    if (Unk47_raw == value) return;
                    Unk47_raw = value;
                    ChangedItems.Add(nameof(Unk47));
                    OnPropertyChanged(nameof(Unk47));
                }
            }

            [DisplayName("Offset")]
            public long Unk47_offset { get; private set; }

            protected float Unk48_raw;
            public const string Unk48_displayName = "Unk48";
            public const int Unk48_sortIndex = 850;
            [SortOrder(Unk48_sortIndex)]
            [DisplayName(Unk48_displayName)]
            public virtual float Unk48 {
                get => Unk48_raw;
                set {
                    if (Unk48_raw == value) return;
                    Unk48_raw = value;
                    ChangedItems.Add(nameof(Unk48));
                    OnPropertyChanged(nameof(Unk48));
                }
            }

            [DisplayName("Offset")]
            public long Unk48_offset { get; private set; }

            protected float Unk49_raw;
            public const string Unk49_displayName = "Unk49";
            public const int Unk49_sortIndex = 900;
            [SortOrder(Unk49_sortIndex)]
            [DisplayName(Unk49_displayName)]
            public virtual float Unk49 {
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
            public const int Unk50_sortIndex = 950;
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
            public const int Unk51_sortIndex = 1000;
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
            public const int Unk52_sortIndex = 1050;
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
            public const int Unk53_sortIndex = 1100;
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
            public const int Unk54_sortIndex = 1150;
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
            public const int Unk55_sortIndex = 1200;
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
            public const int Unk56_sortIndex = 1250;
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
            public const int Unk57_sortIndex = 1300;
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
            public const int Unk58_sortIndex = 1350;
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
            public const int Unk59_sortIndex = 1400;
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
            public const int Unk60_sortIndex = 1450;
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
            public const int Unk61_sortIndex = 1500;
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
            public const int Unk62_sortIndex = 1550;
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
            public const int Unk63_sortIndex = 1600;
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
            public const int Unk64_sortIndex = 1650;
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
            public const int Unk65_sortIndex = 1700;
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
            public const int Unk66_sortIndex = 1750;
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
            public const int Unk67_sortIndex = 1800;
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
            public const int Unk68_sortIndex = 1850;
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
            public const int Unk69_sortIndex = 1900;
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
            public const int Unk70_sortIndex = 1950;
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
            public const int Unk71_sortIndex = 2000;
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
            public const int Unk72_sortIndex = 2050;
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
            public const int Unk73_sortIndex = 2100;
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
            public const int Unk74_sortIndex = 2150;
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
            public const int Unk75_sortIndex = 2200;
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
            public const int Unk76_sortIndex = 2250;
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
            public const int Unk77_sortIndex = 2300;
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
            public const int Unk78_sortIndex = 2350;
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

            protected float Offensive_Guard_raw;
            public const string Offensive_Guard_displayName = "Offensive Guard";
            public const int Offensive_Guard_sortIndex = 2400;
            [SortOrder(Offensive_Guard_sortIndex)]
            [DisplayName(Offensive_Guard_displayName)]
            public virtual float Offensive_Guard {
                get => Offensive_Guard_raw;
                set {
                    if (Offensive_Guard_raw == value) return;
                    Offensive_Guard_raw = value;
                    ChangedItems.Add(nameof(Offensive_Guard));
                    OnPropertyChanged(nameof(Offensive_Guard));
                }
            }

            [DisplayName("Offset")]
            public long Offensive_Guard_offset { get; private set; }

            protected float Coalescence_raw;
            public const string Coalescence_displayName = "Coalescence";
            public const int Coalescence_sortIndex = 2450;
            [SortOrder(Coalescence_sortIndex)]
            [DisplayName(Coalescence_displayName)]
            public virtual float Coalescence {
                get => Coalescence_raw;
                set {
                    if (Coalescence_raw == value) return;
                    Coalescence_raw = value;
                    ChangedItems.Add(nameof(Coalescence));
                    OnPropertyChanged(nameof(Coalescence));
                }
            }

            [DisplayName("Offset")]
            public long Coalescence_offset { get; private set; }

            protected float Unk_Safi_2_raw;
            public const string Unk_Safi_2_displayName = "Unk Safi 2";
            public const int Unk_Safi_2_sortIndex = 2500;
            [SortOrder(Unk_Safi_2_sortIndex)]
            [DisplayName(Unk_Safi_2_displayName)]
            public virtual float Unk_Safi_2 {
                get => Unk_Safi_2_raw;
                set {
                    if (Unk_Safi_2_raw == value) return;
                    Unk_Safi_2_raw = value;
                    ChangedItems.Add(nameof(Unk_Safi_2));
                    OnPropertyChanged(nameof(Unk_Safi_2));
                }
            }

            [DisplayName("Offset")]
            public long Unk_Safi_2_offset { get; private set; }

            protected float Unk_Safi_3_raw;
            public const string Unk_Safi_3_displayName = "Unk Safi 3";
            public const int Unk_Safi_3_sortIndex = 2550;
            [SortOrder(Unk_Safi_3_sortIndex)]
            [DisplayName(Unk_Safi_3_displayName)]
            public virtual float Unk_Safi_3 {
                get => Unk_Safi_3_raw;
                set {
                    if (Unk_Safi_3_raw == value) return;
                    Unk_Safi_3_raw = value;
                    ChangedItems.Add(nameof(Unk_Safi_3));
                    OnPropertyChanged(nameof(Unk_Safi_3));
                }
            }

            [DisplayName("Offset")]
            public long Unk_Safi_3_offset { get; private set; }

            protected float Unk_Safi_4_raw;
            public const string Unk_Safi_4_displayName = "Unk Safi 4";
            public const int Unk_Safi_4_sortIndex = 2600;
            [SortOrder(Unk_Safi_4_sortIndex)]
            [DisplayName(Unk_Safi_4_displayName)]
            public virtual float Unk_Safi_4 {
                get => Unk_Safi_4_raw;
                set {
                    if (Unk_Safi_4_raw == value) return;
                    Unk_Safi_4_raw = value;
                    ChangedItems.Add(nameof(Unk_Safi_4));
                    OnPropertyChanged(nameof(Unk_Safi_4));
                }
            }

            [DisplayName("Offset")]
            public long Unk_Safi_4_offset { get; private set; }

            protected uint Unk_Safi_5_raw;
            public const string Unk_Safi_5_displayName = "Unk Safi 5";
            public const int Unk_Safi_5_sortIndex = 2650;
            [SortOrder(Unk_Safi_5_sortIndex)]
            [DisplayName(Unk_Safi_5_displayName)]
            public virtual uint Unk_Safi_5 {
                get => Unk_Safi_5_raw;
                set {
                    if (Unk_Safi_5_raw == value) return;
                    Unk_Safi_5_raw = value;
                    ChangedItems.Add(nameof(Unk_Safi_5));
                    OnPropertyChanged(nameof(Unk_Safi_5));
                }
            }

            [DisplayName("Offset")]
            public long Unk_Safi_5_offset { get; private set; }

            protected uint Unk_Safi_6_raw;
            public const string Unk_Safi_6_displayName = "Unk Safi 6";
            public const int Unk_Safi_6_sortIndex = 2700;
            [SortOrder(Unk_Safi_6_sortIndex)]
            [DisplayName(Unk_Safi_6_displayName)]
            public virtual uint Unk_Safi_6 {
                get => Unk_Safi_6_raw;
                set {
                    if (Unk_Safi_6_raw == value) return;
                    Unk_Safi_6_raw = value;
                    ChangedItems.Add(nameof(Unk_Safi_6));
                    OnPropertyChanged(nameof(Unk_Safi_6));
                }
            }

            [DisplayName("Offset")]
            public long Unk_Safi_6_offset { get; private set; }

            protected float Unk_Safi_7_raw;
            public const string Unk_Safi_7_displayName = "Unk Safi 7";
            public const int Unk_Safi_7_sortIndex = 2750;
            [SortOrder(Unk_Safi_7_sortIndex)]
            [DisplayName(Unk_Safi_7_displayName)]
            public virtual float Unk_Safi_7 {
                get => Unk_Safi_7_raw;
                set {
                    if (Unk_Safi_7_raw == value) return;
                    Unk_Safi_7_raw = value;
                    ChangedItems.Add(nameof(Unk_Safi_7));
                    OnPropertyChanged(nameof(Unk_Safi_7));
                }
            }

            [DisplayName("Offset")]
            public long Unk_Safi_7_offset { get; private set; }

            protected float Set_3_Elemental_Bonus_raw;
            public const string Set_3_Elemental_Bonus_displayName = "Set(3) Elemental Bonus";
            public const int Set_3_Elemental_Bonus_sortIndex = 2800;
            [SortOrder(Set_3_Elemental_Bonus_sortIndex)]
            [DisplayName(Set_3_Elemental_Bonus_displayName)]
            public virtual float Set_3_Elemental_Bonus {
                get => Set_3_Elemental_Bonus_raw;
                set {
                    if (Set_3_Elemental_Bonus_raw == value) return;
                    Set_3_Elemental_Bonus_raw = value;
                    ChangedItems.Add(nameof(Set_3_Elemental_Bonus));
                    OnPropertyChanged(nameof(Set_3_Elemental_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long Set_3_Elemental_Bonus_offset { get; private set; }

            protected float Set_5_Elemental_Bonus_raw;
            public const string Set_5_Elemental_Bonus_displayName = "Set(5) Elemental Bonus";
            public const int Set_5_Elemental_Bonus_sortIndex = 2850;
            [SortOrder(Set_5_Elemental_Bonus_sortIndex)]
            [DisplayName(Set_5_Elemental_Bonus_displayName)]
            public virtual float Set_5_Elemental_Bonus {
                get => Set_5_Elemental_Bonus_raw;
                set {
                    if (Set_5_Elemental_Bonus_raw == value) return;
                    Set_5_Elemental_Bonus_raw = value;
                    ChangedItems.Add(nameof(Set_5_Elemental_Bonus));
                    OnPropertyChanged(nameof(Set_5_Elemental_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long Set_5_Elemental_Bonus_offset { get; private set; }

            protected float Set_3_Status_Bonus_raw;
            public const string Set_3_Status_Bonus_displayName = "Set(3) Status Bonus";
            public const int Set_3_Status_Bonus_sortIndex = 2900;
            [SortOrder(Set_3_Status_Bonus_sortIndex)]
            [DisplayName(Set_3_Status_Bonus_displayName)]
            public virtual float Set_3_Status_Bonus {
                get => Set_3_Status_Bonus_raw;
                set {
                    if (Set_3_Status_Bonus_raw == value) return;
                    Set_3_Status_Bonus_raw = value;
                    ChangedItems.Add(nameof(Set_3_Status_Bonus));
                    OnPropertyChanged(nameof(Set_3_Status_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long Set_3_Status_Bonus_offset { get; private set; }

            protected float Set_5_Status_Bonus_raw;
            public const string Set_5_Status_Bonus_displayName = "Set(5) Status Bonus";
            public const int Set_5_Status_Bonus_sortIndex = 2950;
            [SortOrder(Set_5_Status_Bonus_sortIndex)]
            [DisplayName(Set_5_Status_Bonus_displayName)]
            public virtual float Set_5_Status_Bonus {
                get => Set_5_Status_Bonus_raw;
                set {
                    if (Set_5_Status_Bonus_raw == value) return;
                    Set_5_Status_Bonus_raw = value;
                    ChangedItems.Add(nameof(Set_5_Status_Bonus));
                    OnPropertyChanged(nameof(Set_5_Status_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long Set_5_Status_Bonus_offset { get; private set; }

            protected uint Set_3_Affinity_Bonus_raw;
            public const string Set_3_Affinity_Bonus_displayName = "Set(3) Affinity Bonus";
            public const int Set_3_Affinity_Bonus_sortIndex = 3000;
            [SortOrder(Set_3_Affinity_Bonus_sortIndex)]
            [DisplayName(Set_3_Affinity_Bonus_displayName)]
            public virtual uint Set_3_Affinity_Bonus {
                get => Set_3_Affinity_Bonus_raw;
                set {
                    if (Set_3_Affinity_Bonus_raw == value) return;
                    Set_3_Affinity_Bonus_raw = value;
                    ChangedItems.Add(nameof(Set_3_Affinity_Bonus));
                    OnPropertyChanged(nameof(Set_3_Affinity_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long Set_3_Affinity_Bonus_offset { get; private set; }

            protected uint Set_5_Affinity_Bonus_raw;
            public const string Set_5_Affinity_Bonus_displayName = "Set(5) Affinity Bonus";
            public const int Set_5_Affinity_Bonus_sortIndex = 3050;
            [SortOrder(Set_5_Affinity_Bonus_sortIndex)]
            [DisplayName(Set_5_Affinity_Bonus_displayName)]
            public virtual uint Set_5_Affinity_Bonus {
                get => Set_5_Affinity_Bonus_raw;
                set {
                    if (Set_5_Affinity_Bonus_raw == value) return;
                    Set_5_Affinity_Bonus_raw = value;
                    ChangedItems.Add(nameof(Set_5_Affinity_Bonus));
                    OnPropertyChanged(nameof(Set_5_Affinity_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long Set_5_Affinity_Bonus_offset { get; private set; }

            protected byte Safi_Jiva_Seal_Great_Sword_Hit_Combo_to_Heal_raw;
            public const string Safi_Jiva_Seal_Great_Sword_Hit_Combo_to_Heal_displayName = "Safi'Jiva Seal: (Great Sword) Hit Combo to Heal";
            public const int Safi_Jiva_Seal_Great_Sword_Hit_Combo_to_Heal_sortIndex = 3100;
            [SortOrder(Safi_Jiva_Seal_Great_Sword_Hit_Combo_to_Heal_sortIndex)]
            [DisplayName(Safi_Jiva_Seal_Great_Sword_Hit_Combo_to_Heal_displayName)]
            public virtual byte Safi_Jiva_Seal_Great_Sword_Hit_Combo_to_Heal {
                get => Safi_Jiva_Seal_Great_Sword_Hit_Combo_to_Heal_raw;
                set {
                    if (Safi_Jiva_Seal_Great_Sword_Hit_Combo_to_Heal_raw == value) return;
                    Safi_Jiva_Seal_Great_Sword_Hit_Combo_to_Heal_raw = value;
                    ChangedItems.Add(nameof(Safi_Jiva_Seal_Great_Sword_Hit_Combo_to_Heal));
                    OnPropertyChanged(nameof(Safi_Jiva_Seal_Great_Sword_Hit_Combo_to_Heal));
                }
            }

            [DisplayName("Offset")]
            public long Safi_Jiva_Seal_Great_Sword_Hit_Combo_to_Heal_offset { get; private set; }

            protected byte Safi_Jiva_Seal_Sword_Shield_Hit_Combo_to_Heal_raw;
            public const string Safi_Jiva_Seal_Sword_Shield_Hit_Combo_to_Heal_displayName = "Safi'Jiva Seal: (Sword & Shield) Hit Combo to Heal";
            public const int Safi_Jiva_Seal_Sword_Shield_Hit_Combo_to_Heal_sortIndex = 3150;
            [SortOrder(Safi_Jiva_Seal_Sword_Shield_Hit_Combo_to_Heal_sortIndex)]
            [DisplayName(Safi_Jiva_Seal_Sword_Shield_Hit_Combo_to_Heal_displayName)]
            public virtual byte Safi_Jiva_Seal_Sword_Shield_Hit_Combo_to_Heal {
                get => Safi_Jiva_Seal_Sword_Shield_Hit_Combo_to_Heal_raw;
                set {
                    if (Safi_Jiva_Seal_Sword_Shield_Hit_Combo_to_Heal_raw == value) return;
                    Safi_Jiva_Seal_Sword_Shield_Hit_Combo_to_Heal_raw = value;
                    ChangedItems.Add(nameof(Safi_Jiva_Seal_Sword_Shield_Hit_Combo_to_Heal));
                    OnPropertyChanged(nameof(Safi_Jiva_Seal_Sword_Shield_Hit_Combo_to_Heal));
                }
            }

            [DisplayName("Offset")]
            public long Safi_Jiva_Seal_Sword_Shield_Hit_Combo_to_Heal_offset { get; private set; }

            protected byte Safi_Jiva_Seal_Dual_Blades_Hit_Combo_to_Heal_raw;
            public const string Safi_Jiva_Seal_Dual_Blades_Hit_Combo_to_Heal_displayName = "Safi'Jiva Seal: (Dual Blades) Hit Combo to Heal";
            public const int Safi_Jiva_Seal_Dual_Blades_Hit_Combo_to_Heal_sortIndex = 3200;
            [SortOrder(Safi_Jiva_Seal_Dual_Blades_Hit_Combo_to_Heal_sortIndex)]
            [DisplayName(Safi_Jiva_Seal_Dual_Blades_Hit_Combo_to_Heal_displayName)]
            public virtual byte Safi_Jiva_Seal_Dual_Blades_Hit_Combo_to_Heal {
                get => Safi_Jiva_Seal_Dual_Blades_Hit_Combo_to_Heal_raw;
                set {
                    if (Safi_Jiva_Seal_Dual_Blades_Hit_Combo_to_Heal_raw == value) return;
                    Safi_Jiva_Seal_Dual_Blades_Hit_Combo_to_Heal_raw = value;
                    ChangedItems.Add(nameof(Safi_Jiva_Seal_Dual_Blades_Hit_Combo_to_Heal));
                    OnPropertyChanged(nameof(Safi_Jiva_Seal_Dual_Blades_Hit_Combo_to_Heal));
                }
            }

            [DisplayName("Offset")]
            public long Safi_Jiva_Seal_Dual_Blades_Hit_Combo_to_Heal_offset { get; private set; }

            protected byte Safi_Jiva_Seal_Long_Sword_Hit_Combo_to_Heal_raw;
            public const string Safi_Jiva_Seal_Long_Sword_Hit_Combo_to_Heal_displayName = "Safi'Jiva Seal: (Long Sword) Hit Combo to Heal";
            public const int Safi_Jiva_Seal_Long_Sword_Hit_Combo_to_Heal_sortIndex = 3250;
            [SortOrder(Safi_Jiva_Seal_Long_Sword_Hit_Combo_to_Heal_sortIndex)]
            [DisplayName(Safi_Jiva_Seal_Long_Sword_Hit_Combo_to_Heal_displayName)]
            public virtual byte Safi_Jiva_Seal_Long_Sword_Hit_Combo_to_Heal {
                get => Safi_Jiva_Seal_Long_Sword_Hit_Combo_to_Heal_raw;
                set {
                    if (Safi_Jiva_Seal_Long_Sword_Hit_Combo_to_Heal_raw == value) return;
                    Safi_Jiva_Seal_Long_Sword_Hit_Combo_to_Heal_raw = value;
                    ChangedItems.Add(nameof(Safi_Jiva_Seal_Long_Sword_Hit_Combo_to_Heal));
                    OnPropertyChanged(nameof(Safi_Jiva_Seal_Long_Sword_Hit_Combo_to_Heal));
                }
            }

            [DisplayName("Offset")]
            public long Safi_Jiva_Seal_Long_Sword_Hit_Combo_to_Heal_offset { get; private set; }

            protected byte Safi_Jiva_Seal_Hammer_Hit_Combo_to_Heal_raw;
            public const string Safi_Jiva_Seal_Hammer_Hit_Combo_to_Heal_displayName = "Safi'Jiva Seal: (Hammer) Hit Combo to Heal";
            public const int Safi_Jiva_Seal_Hammer_Hit_Combo_to_Heal_sortIndex = 3300;
            [SortOrder(Safi_Jiva_Seal_Hammer_Hit_Combo_to_Heal_sortIndex)]
            [DisplayName(Safi_Jiva_Seal_Hammer_Hit_Combo_to_Heal_displayName)]
            public virtual byte Safi_Jiva_Seal_Hammer_Hit_Combo_to_Heal {
                get => Safi_Jiva_Seal_Hammer_Hit_Combo_to_Heal_raw;
                set {
                    if (Safi_Jiva_Seal_Hammer_Hit_Combo_to_Heal_raw == value) return;
                    Safi_Jiva_Seal_Hammer_Hit_Combo_to_Heal_raw = value;
                    ChangedItems.Add(nameof(Safi_Jiva_Seal_Hammer_Hit_Combo_to_Heal));
                    OnPropertyChanged(nameof(Safi_Jiva_Seal_Hammer_Hit_Combo_to_Heal));
                }
            }

            [DisplayName("Offset")]
            public long Safi_Jiva_Seal_Hammer_Hit_Combo_to_Heal_offset { get; private set; }

            protected byte Safi_Jiva_Seal_Hunting_Horn_Hit_Combo_to_Heal_raw;
            public const string Safi_Jiva_Seal_Hunting_Horn_Hit_Combo_to_Heal_displayName = "Safi'Jiva Seal: (Hunting Horn) Hit Combo to Heal";
            public const int Safi_Jiva_Seal_Hunting_Horn_Hit_Combo_to_Heal_sortIndex = 3350;
            [SortOrder(Safi_Jiva_Seal_Hunting_Horn_Hit_Combo_to_Heal_sortIndex)]
            [DisplayName(Safi_Jiva_Seal_Hunting_Horn_Hit_Combo_to_Heal_displayName)]
            public virtual byte Safi_Jiva_Seal_Hunting_Horn_Hit_Combo_to_Heal {
                get => Safi_Jiva_Seal_Hunting_Horn_Hit_Combo_to_Heal_raw;
                set {
                    if (Safi_Jiva_Seal_Hunting_Horn_Hit_Combo_to_Heal_raw == value) return;
                    Safi_Jiva_Seal_Hunting_Horn_Hit_Combo_to_Heal_raw = value;
                    ChangedItems.Add(nameof(Safi_Jiva_Seal_Hunting_Horn_Hit_Combo_to_Heal));
                    OnPropertyChanged(nameof(Safi_Jiva_Seal_Hunting_Horn_Hit_Combo_to_Heal));
                }
            }

            [DisplayName("Offset")]
            public long Safi_Jiva_Seal_Hunting_Horn_Hit_Combo_to_Heal_offset { get; private set; }

            protected byte Safi_Jiva_Seal_Lance_Hit_Combo_to_Heal_raw;
            public const string Safi_Jiva_Seal_Lance_Hit_Combo_to_Heal_displayName = "Safi'Jiva Seal: (Lance) Hit Combo to Heal";
            public const int Safi_Jiva_Seal_Lance_Hit_Combo_to_Heal_sortIndex = 3400;
            [SortOrder(Safi_Jiva_Seal_Lance_Hit_Combo_to_Heal_sortIndex)]
            [DisplayName(Safi_Jiva_Seal_Lance_Hit_Combo_to_Heal_displayName)]
            public virtual byte Safi_Jiva_Seal_Lance_Hit_Combo_to_Heal {
                get => Safi_Jiva_Seal_Lance_Hit_Combo_to_Heal_raw;
                set {
                    if (Safi_Jiva_Seal_Lance_Hit_Combo_to_Heal_raw == value) return;
                    Safi_Jiva_Seal_Lance_Hit_Combo_to_Heal_raw = value;
                    ChangedItems.Add(nameof(Safi_Jiva_Seal_Lance_Hit_Combo_to_Heal));
                    OnPropertyChanged(nameof(Safi_Jiva_Seal_Lance_Hit_Combo_to_Heal));
                }
            }

            [DisplayName("Offset")]
            public long Safi_Jiva_Seal_Lance_Hit_Combo_to_Heal_offset { get; private set; }

            protected byte Safi_Jiva_Seal_Gunlance_Hit_Combo_to_Heal_raw;
            public const string Safi_Jiva_Seal_Gunlance_Hit_Combo_to_Heal_displayName = "Safi'Jiva Seal: (Gunlance) Hit Combo to Heal";
            public const int Safi_Jiva_Seal_Gunlance_Hit_Combo_to_Heal_sortIndex = 3450;
            [SortOrder(Safi_Jiva_Seal_Gunlance_Hit_Combo_to_Heal_sortIndex)]
            [DisplayName(Safi_Jiva_Seal_Gunlance_Hit_Combo_to_Heal_displayName)]
            public virtual byte Safi_Jiva_Seal_Gunlance_Hit_Combo_to_Heal {
                get => Safi_Jiva_Seal_Gunlance_Hit_Combo_to_Heal_raw;
                set {
                    if (Safi_Jiva_Seal_Gunlance_Hit_Combo_to_Heal_raw == value) return;
                    Safi_Jiva_Seal_Gunlance_Hit_Combo_to_Heal_raw = value;
                    ChangedItems.Add(nameof(Safi_Jiva_Seal_Gunlance_Hit_Combo_to_Heal));
                    OnPropertyChanged(nameof(Safi_Jiva_Seal_Gunlance_Hit_Combo_to_Heal));
                }
            }

            [DisplayName("Offset")]
            public long Safi_Jiva_Seal_Gunlance_Hit_Combo_to_Heal_offset { get; private set; }

            protected byte Safi_Jiva_Seal_Switch_Axe_Hit_Combo_to_Heal_raw;
            public const string Safi_Jiva_Seal_Switch_Axe_Hit_Combo_to_Heal_displayName = "Safi'Jiva Seal: (Switch Axe) Hit Combo to Heal";
            public const int Safi_Jiva_Seal_Switch_Axe_Hit_Combo_to_Heal_sortIndex = 3500;
            [SortOrder(Safi_Jiva_Seal_Switch_Axe_Hit_Combo_to_Heal_sortIndex)]
            [DisplayName(Safi_Jiva_Seal_Switch_Axe_Hit_Combo_to_Heal_displayName)]
            public virtual byte Safi_Jiva_Seal_Switch_Axe_Hit_Combo_to_Heal {
                get => Safi_Jiva_Seal_Switch_Axe_Hit_Combo_to_Heal_raw;
                set {
                    if (Safi_Jiva_Seal_Switch_Axe_Hit_Combo_to_Heal_raw == value) return;
                    Safi_Jiva_Seal_Switch_Axe_Hit_Combo_to_Heal_raw = value;
                    ChangedItems.Add(nameof(Safi_Jiva_Seal_Switch_Axe_Hit_Combo_to_Heal));
                    OnPropertyChanged(nameof(Safi_Jiva_Seal_Switch_Axe_Hit_Combo_to_Heal));
                }
            }

            [DisplayName("Offset")]
            public long Safi_Jiva_Seal_Switch_Axe_Hit_Combo_to_Heal_offset { get; private set; }

            protected byte Safi_Jiva_Seal_Charge_Blade_Hit_Combo_to_Heal_raw;
            public const string Safi_Jiva_Seal_Charge_Blade_Hit_Combo_to_Heal_displayName = "Safi'Jiva Seal: (Charge Blade) Hit Combo to Heal";
            public const int Safi_Jiva_Seal_Charge_Blade_Hit_Combo_to_Heal_sortIndex = 3550;
            [SortOrder(Safi_Jiva_Seal_Charge_Blade_Hit_Combo_to_Heal_sortIndex)]
            [DisplayName(Safi_Jiva_Seal_Charge_Blade_Hit_Combo_to_Heal_displayName)]
            public virtual byte Safi_Jiva_Seal_Charge_Blade_Hit_Combo_to_Heal {
                get => Safi_Jiva_Seal_Charge_Blade_Hit_Combo_to_Heal_raw;
                set {
                    if (Safi_Jiva_Seal_Charge_Blade_Hit_Combo_to_Heal_raw == value) return;
                    Safi_Jiva_Seal_Charge_Blade_Hit_Combo_to_Heal_raw = value;
                    ChangedItems.Add(nameof(Safi_Jiva_Seal_Charge_Blade_Hit_Combo_to_Heal));
                    OnPropertyChanged(nameof(Safi_Jiva_Seal_Charge_Blade_Hit_Combo_to_Heal));
                }
            }

            [DisplayName("Offset")]
            public long Safi_Jiva_Seal_Charge_Blade_Hit_Combo_to_Heal_offset { get; private set; }

            protected byte Safi_Jiva_Seal_Insect_Glaive_Hit_Combo_to_Heal_raw;
            public const string Safi_Jiva_Seal_Insect_Glaive_Hit_Combo_to_Heal_displayName = "Safi'Jiva Seal: (Insect Glaive) Hit Combo to Heal";
            public const int Safi_Jiva_Seal_Insect_Glaive_Hit_Combo_to_Heal_sortIndex = 3600;
            [SortOrder(Safi_Jiva_Seal_Insect_Glaive_Hit_Combo_to_Heal_sortIndex)]
            [DisplayName(Safi_Jiva_Seal_Insect_Glaive_Hit_Combo_to_Heal_displayName)]
            public virtual byte Safi_Jiva_Seal_Insect_Glaive_Hit_Combo_to_Heal {
                get => Safi_Jiva_Seal_Insect_Glaive_Hit_Combo_to_Heal_raw;
                set {
                    if (Safi_Jiva_Seal_Insect_Glaive_Hit_Combo_to_Heal_raw == value) return;
                    Safi_Jiva_Seal_Insect_Glaive_Hit_Combo_to_Heal_raw = value;
                    ChangedItems.Add(nameof(Safi_Jiva_Seal_Insect_Glaive_Hit_Combo_to_Heal));
                    OnPropertyChanged(nameof(Safi_Jiva_Seal_Insect_Glaive_Hit_Combo_to_Heal));
                }
            }

            [DisplayName("Offset")]
            public long Safi_Jiva_Seal_Insect_Glaive_Hit_Combo_to_Heal_offset { get; private set; }

            protected byte Safi_Jiva_Seal_Bow_Hit_Combo_to_Heal_raw;
            public const string Safi_Jiva_Seal_Bow_Hit_Combo_to_Heal_displayName = "Safi'Jiva Seal: (Bow) Hit Combo to Heal";
            public const int Safi_Jiva_Seal_Bow_Hit_Combo_to_Heal_sortIndex = 3650;
            [SortOrder(Safi_Jiva_Seal_Bow_Hit_Combo_to_Heal_sortIndex)]
            [DisplayName(Safi_Jiva_Seal_Bow_Hit_Combo_to_Heal_displayName)]
            public virtual byte Safi_Jiva_Seal_Bow_Hit_Combo_to_Heal {
                get => Safi_Jiva_Seal_Bow_Hit_Combo_to_Heal_raw;
                set {
                    if (Safi_Jiva_Seal_Bow_Hit_Combo_to_Heal_raw == value) return;
                    Safi_Jiva_Seal_Bow_Hit_Combo_to_Heal_raw = value;
                    ChangedItems.Add(nameof(Safi_Jiva_Seal_Bow_Hit_Combo_to_Heal));
                    OnPropertyChanged(nameof(Safi_Jiva_Seal_Bow_Hit_Combo_to_Heal));
                }
            }

            [DisplayName("Offset")]
            public long Safi_Jiva_Seal_Bow_Hit_Combo_to_Heal_offset { get; private set; }

            protected byte Safi_Jiva_Seal_HBG_Hit_Combo_to_Heal_raw;
            public const string Safi_Jiva_Seal_HBG_Hit_Combo_to_Heal_displayName = "Safi'Jiva Seal: (HBG) Hit Combo to Heal";
            public const int Safi_Jiva_Seal_HBG_Hit_Combo_to_Heal_sortIndex = 3700;
            [SortOrder(Safi_Jiva_Seal_HBG_Hit_Combo_to_Heal_sortIndex)]
            [DisplayName(Safi_Jiva_Seal_HBG_Hit_Combo_to_Heal_displayName)]
            public virtual byte Safi_Jiva_Seal_HBG_Hit_Combo_to_Heal {
                get => Safi_Jiva_Seal_HBG_Hit_Combo_to_Heal_raw;
                set {
                    if (Safi_Jiva_Seal_HBG_Hit_Combo_to_Heal_raw == value) return;
                    Safi_Jiva_Seal_HBG_Hit_Combo_to_Heal_raw = value;
                    ChangedItems.Add(nameof(Safi_Jiva_Seal_HBG_Hit_Combo_to_Heal));
                    OnPropertyChanged(nameof(Safi_Jiva_Seal_HBG_Hit_Combo_to_Heal));
                }
            }

            [DisplayName("Offset")]
            public long Safi_Jiva_Seal_HBG_Hit_Combo_to_Heal_offset { get; private set; }

            protected byte Safi_Jiva_Seal_LBG_Hit_Combo_to_Heal_raw;
            public const string Safi_Jiva_Seal_LBG_Hit_Combo_to_Heal_displayName = "Safi'Jiva Seal: (LBG) Hit Combo to Heal";
            public const int Safi_Jiva_Seal_LBG_Hit_Combo_to_Heal_sortIndex = 3750;
            [SortOrder(Safi_Jiva_Seal_LBG_Hit_Combo_to_Heal_sortIndex)]
            [DisplayName(Safi_Jiva_Seal_LBG_Hit_Combo_to_Heal_displayName)]
            public virtual byte Safi_Jiva_Seal_LBG_Hit_Combo_to_Heal {
                get => Safi_Jiva_Seal_LBG_Hit_Combo_to_Heal_raw;
                set {
                    if (Safi_Jiva_Seal_LBG_Hit_Combo_to_Heal_raw == value) return;
                    Safi_Jiva_Seal_LBG_Hit_Combo_to_Heal_raw = value;
                    ChangedItems.Add(nameof(Safi_Jiva_Seal_LBG_Hit_Combo_to_Heal));
                    OnPropertyChanged(nameof(Safi_Jiva_Seal_LBG_Hit_Combo_to_Heal));
                }
            }

            [DisplayName("Offset")]
            public long Safi_Jiva_Seal_LBG_Hit_Combo_to_Heal_offset { get; private set; }

            protected float Safi_Jiva_Seal_Great_Sword_HP_Lost_Per_Hit_raw;
            public const string Safi_Jiva_Seal_Great_Sword_HP_Lost_Per_Hit_displayName = "Safi'Jiva Seal: (Great Sword) HP Lost Per Hit";
            public const int Safi_Jiva_Seal_Great_Sword_HP_Lost_Per_Hit_sortIndex = 3800;
            [SortOrder(Safi_Jiva_Seal_Great_Sword_HP_Lost_Per_Hit_sortIndex)]
            [DisplayName(Safi_Jiva_Seal_Great_Sword_HP_Lost_Per_Hit_displayName)]
            public virtual float Safi_Jiva_Seal_Great_Sword_HP_Lost_Per_Hit {
                get => Safi_Jiva_Seal_Great_Sword_HP_Lost_Per_Hit_raw;
                set {
                    if (Safi_Jiva_Seal_Great_Sword_HP_Lost_Per_Hit_raw == value) return;
                    Safi_Jiva_Seal_Great_Sword_HP_Lost_Per_Hit_raw = value;
                    ChangedItems.Add(nameof(Safi_Jiva_Seal_Great_Sword_HP_Lost_Per_Hit));
                    OnPropertyChanged(nameof(Safi_Jiva_Seal_Great_Sword_HP_Lost_Per_Hit));
                }
            }

            [DisplayName("Offset")]
            public long Safi_Jiva_Seal_Great_Sword_HP_Lost_Per_Hit_offset { get; private set; }

            protected float Safi_Jiva_Seal_Sword_Shield_HP_Lost_Per_Hit_raw;
            public const string Safi_Jiva_Seal_Sword_Shield_HP_Lost_Per_Hit_displayName = "Safi'Jiva Seal: (Sword & Shield) HP Lost Per Hit";
            public const int Safi_Jiva_Seal_Sword_Shield_HP_Lost_Per_Hit_sortIndex = 3850;
            [SortOrder(Safi_Jiva_Seal_Sword_Shield_HP_Lost_Per_Hit_sortIndex)]
            [DisplayName(Safi_Jiva_Seal_Sword_Shield_HP_Lost_Per_Hit_displayName)]
            public virtual float Safi_Jiva_Seal_Sword_Shield_HP_Lost_Per_Hit {
                get => Safi_Jiva_Seal_Sword_Shield_HP_Lost_Per_Hit_raw;
                set {
                    if (Safi_Jiva_Seal_Sword_Shield_HP_Lost_Per_Hit_raw == value) return;
                    Safi_Jiva_Seal_Sword_Shield_HP_Lost_Per_Hit_raw = value;
                    ChangedItems.Add(nameof(Safi_Jiva_Seal_Sword_Shield_HP_Lost_Per_Hit));
                    OnPropertyChanged(nameof(Safi_Jiva_Seal_Sword_Shield_HP_Lost_Per_Hit));
                }
            }

            [DisplayName("Offset")]
            public long Safi_Jiva_Seal_Sword_Shield_HP_Lost_Per_Hit_offset { get; private set; }

            protected float Safi_Jiva_Seal_Dual_Blades_HP_Lost_Per_Hit_raw;
            public const string Safi_Jiva_Seal_Dual_Blades_HP_Lost_Per_Hit_displayName = "Safi'Jiva Seal: (Dual Blades) HP Lost Per Hit";
            public const int Safi_Jiva_Seal_Dual_Blades_HP_Lost_Per_Hit_sortIndex = 3900;
            [SortOrder(Safi_Jiva_Seal_Dual_Blades_HP_Lost_Per_Hit_sortIndex)]
            [DisplayName(Safi_Jiva_Seal_Dual_Blades_HP_Lost_Per_Hit_displayName)]
            public virtual float Safi_Jiva_Seal_Dual_Blades_HP_Lost_Per_Hit {
                get => Safi_Jiva_Seal_Dual_Blades_HP_Lost_Per_Hit_raw;
                set {
                    if (Safi_Jiva_Seal_Dual_Blades_HP_Lost_Per_Hit_raw == value) return;
                    Safi_Jiva_Seal_Dual_Blades_HP_Lost_Per_Hit_raw = value;
                    ChangedItems.Add(nameof(Safi_Jiva_Seal_Dual_Blades_HP_Lost_Per_Hit));
                    OnPropertyChanged(nameof(Safi_Jiva_Seal_Dual_Blades_HP_Lost_Per_Hit));
                }
            }

            [DisplayName("Offset")]
            public long Safi_Jiva_Seal_Dual_Blades_HP_Lost_Per_Hit_offset { get; private set; }

            protected float Safi_Jiva_Seal_Long_Sword_HP_Lost_Per_Hit_raw;
            public const string Safi_Jiva_Seal_Long_Sword_HP_Lost_Per_Hit_displayName = "Safi'Jiva Seal: (Long Sword) HP Lost Per Hit";
            public const int Safi_Jiva_Seal_Long_Sword_HP_Lost_Per_Hit_sortIndex = 3950;
            [SortOrder(Safi_Jiva_Seal_Long_Sword_HP_Lost_Per_Hit_sortIndex)]
            [DisplayName(Safi_Jiva_Seal_Long_Sword_HP_Lost_Per_Hit_displayName)]
            public virtual float Safi_Jiva_Seal_Long_Sword_HP_Lost_Per_Hit {
                get => Safi_Jiva_Seal_Long_Sword_HP_Lost_Per_Hit_raw;
                set {
                    if (Safi_Jiva_Seal_Long_Sword_HP_Lost_Per_Hit_raw == value) return;
                    Safi_Jiva_Seal_Long_Sword_HP_Lost_Per_Hit_raw = value;
                    ChangedItems.Add(nameof(Safi_Jiva_Seal_Long_Sword_HP_Lost_Per_Hit));
                    OnPropertyChanged(nameof(Safi_Jiva_Seal_Long_Sword_HP_Lost_Per_Hit));
                }
            }

            [DisplayName("Offset")]
            public long Safi_Jiva_Seal_Long_Sword_HP_Lost_Per_Hit_offset { get; private set; }

            protected float Safi_Jiva_Seal_Hammer_HP_Lost_Per_Hit_raw;
            public const string Safi_Jiva_Seal_Hammer_HP_Lost_Per_Hit_displayName = "Safi'Jiva Seal: (Hammer) HP Lost Per Hit";
            public const int Safi_Jiva_Seal_Hammer_HP_Lost_Per_Hit_sortIndex = 4000;
            [SortOrder(Safi_Jiva_Seal_Hammer_HP_Lost_Per_Hit_sortIndex)]
            [DisplayName(Safi_Jiva_Seal_Hammer_HP_Lost_Per_Hit_displayName)]
            public virtual float Safi_Jiva_Seal_Hammer_HP_Lost_Per_Hit {
                get => Safi_Jiva_Seal_Hammer_HP_Lost_Per_Hit_raw;
                set {
                    if (Safi_Jiva_Seal_Hammer_HP_Lost_Per_Hit_raw == value) return;
                    Safi_Jiva_Seal_Hammer_HP_Lost_Per_Hit_raw = value;
                    ChangedItems.Add(nameof(Safi_Jiva_Seal_Hammer_HP_Lost_Per_Hit));
                    OnPropertyChanged(nameof(Safi_Jiva_Seal_Hammer_HP_Lost_Per_Hit));
                }
            }

            [DisplayName("Offset")]
            public long Safi_Jiva_Seal_Hammer_HP_Lost_Per_Hit_offset { get; private set; }

            protected float Safi_Jiva_Seal_Hunting_Horn_HP_Lost_Per_Hit_raw;
            public const string Safi_Jiva_Seal_Hunting_Horn_HP_Lost_Per_Hit_displayName = "Safi'Jiva Seal: (Hunting Horn) HP Lost Per Hit";
            public const int Safi_Jiva_Seal_Hunting_Horn_HP_Lost_Per_Hit_sortIndex = 4050;
            [SortOrder(Safi_Jiva_Seal_Hunting_Horn_HP_Lost_Per_Hit_sortIndex)]
            [DisplayName(Safi_Jiva_Seal_Hunting_Horn_HP_Lost_Per_Hit_displayName)]
            public virtual float Safi_Jiva_Seal_Hunting_Horn_HP_Lost_Per_Hit {
                get => Safi_Jiva_Seal_Hunting_Horn_HP_Lost_Per_Hit_raw;
                set {
                    if (Safi_Jiva_Seal_Hunting_Horn_HP_Lost_Per_Hit_raw == value) return;
                    Safi_Jiva_Seal_Hunting_Horn_HP_Lost_Per_Hit_raw = value;
                    ChangedItems.Add(nameof(Safi_Jiva_Seal_Hunting_Horn_HP_Lost_Per_Hit));
                    OnPropertyChanged(nameof(Safi_Jiva_Seal_Hunting_Horn_HP_Lost_Per_Hit));
                }
            }

            [DisplayName("Offset")]
            public long Safi_Jiva_Seal_Hunting_Horn_HP_Lost_Per_Hit_offset { get; private set; }

            protected float Safi_Jiva_Seal_Lance_HP_Lost_Per_Hit_raw;
            public const string Safi_Jiva_Seal_Lance_HP_Lost_Per_Hit_displayName = "Safi'Jiva Seal: (Lance) HP Lost Per Hit";
            public const int Safi_Jiva_Seal_Lance_HP_Lost_Per_Hit_sortIndex = 4100;
            [SortOrder(Safi_Jiva_Seal_Lance_HP_Lost_Per_Hit_sortIndex)]
            [DisplayName(Safi_Jiva_Seal_Lance_HP_Lost_Per_Hit_displayName)]
            public virtual float Safi_Jiva_Seal_Lance_HP_Lost_Per_Hit {
                get => Safi_Jiva_Seal_Lance_HP_Lost_Per_Hit_raw;
                set {
                    if (Safi_Jiva_Seal_Lance_HP_Lost_Per_Hit_raw == value) return;
                    Safi_Jiva_Seal_Lance_HP_Lost_Per_Hit_raw = value;
                    ChangedItems.Add(nameof(Safi_Jiva_Seal_Lance_HP_Lost_Per_Hit));
                    OnPropertyChanged(nameof(Safi_Jiva_Seal_Lance_HP_Lost_Per_Hit));
                }
            }

            [DisplayName("Offset")]
            public long Safi_Jiva_Seal_Lance_HP_Lost_Per_Hit_offset { get; private set; }

            protected float Safi_Jiva_Seal_Gunlance_HP_Lost_Per_Hit_raw;
            public const string Safi_Jiva_Seal_Gunlance_HP_Lost_Per_Hit_displayName = "Safi'Jiva Seal: (Gunlance) HP Lost Per Hit";
            public const int Safi_Jiva_Seal_Gunlance_HP_Lost_Per_Hit_sortIndex = 4150;
            [SortOrder(Safi_Jiva_Seal_Gunlance_HP_Lost_Per_Hit_sortIndex)]
            [DisplayName(Safi_Jiva_Seal_Gunlance_HP_Lost_Per_Hit_displayName)]
            public virtual float Safi_Jiva_Seal_Gunlance_HP_Lost_Per_Hit {
                get => Safi_Jiva_Seal_Gunlance_HP_Lost_Per_Hit_raw;
                set {
                    if (Safi_Jiva_Seal_Gunlance_HP_Lost_Per_Hit_raw == value) return;
                    Safi_Jiva_Seal_Gunlance_HP_Lost_Per_Hit_raw = value;
                    ChangedItems.Add(nameof(Safi_Jiva_Seal_Gunlance_HP_Lost_Per_Hit));
                    OnPropertyChanged(nameof(Safi_Jiva_Seal_Gunlance_HP_Lost_Per_Hit));
                }
            }

            [DisplayName("Offset")]
            public long Safi_Jiva_Seal_Gunlance_HP_Lost_Per_Hit_offset { get; private set; }

            protected float Safi_Jiva_Seal_Switch_Axe_HP_Lost_Per_Hit_raw;
            public const string Safi_Jiva_Seal_Switch_Axe_HP_Lost_Per_Hit_displayName = "Safi'Jiva Seal: (Switch Axe) HP Lost Per Hit";
            public const int Safi_Jiva_Seal_Switch_Axe_HP_Lost_Per_Hit_sortIndex = 4200;
            [SortOrder(Safi_Jiva_Seal_Switch_Axe_HP_Lost_Per_Hit_sortIndex)]
            [DisplayName(Safi_Jiva_Seal_Switch_Axe_HP_Lost_Per_Hit_displayName)]
            public virtual float Safi_Jiva_Seal_Switch_Axe_HP_Lost_Per_Hit {
                get => Safi_Jiva_Seal_Switch_Axe_HP_Lost_Per_Hit_raw;
                set {
                    if (Safi_Jiva_Seal_Switch_Axe_HP_Lost_Per_Hit_raw == value) return;
                    Safi_Jiva_Seal_Switch_Axe_HP_Lost_Per_Hit_raw = value;
                    ChangedItems.Add(nameof(Safi_Jiva_Seal_Switch_Axe_HP_Lost_Per_Hit));
                    OnPropertyChanged(nameof(Safi_Jiva_Seal_Switch_Axe_HP_Lost_Per_Hit));
                }
            }

            [DisplayName("Offset")]
            public long Safi_Jiva_Seal_Switch_Axe_HP_Lost_Per_Hit_offset { get; private set; }

            protected float Safi_Jiva_Seal_Charge_Blade_HP_Lost_Per_Hit_raw;
            public const string Safi_Jiva_Seal_Charge_Blade_HP_Lost_Per_Hit_displayName = "Safi'Jiva Seal: (Charge Blade) HP Lost Per Hit";
            public const int Safi_Jiva_Seal_Charge_Blade_HP_Lost_Per_Hit_sortIndex = 4250;
            [SortOrder(Safi_Jiva_Seal_Charge_Blade_HP_Lost_Per_Hit_sortIndex)]
            [DisplayName(Safi_Jiva_Seal_Charge_Blade_HP_Lost_Per_Hit_displayName)]
            public virtual float Safi_Jiva_Seal_Charge_Blade_HP_Lost_Per_Hit {
                get => Safi_Jiva_Seal_Charge_Blade_HP_Lost_Per_Hit_raw;
                set {
                    if (Safi_Jiva_Seal_Charge_Blade_HP_Lost_Per_Hit_raw == value) return;
                    Safi_Jiva_Seal_Charge_Blade_HP_Lost_Per_Hit_raw = value;
                    ChangedItems.Add(nameof(Safi_Jiva_Seal_Charge_Blade_HP_Lost_Per_Hit));
                    OnPropertyChanged(nameof(Safi_Jiva_Seal_Charge_Blade_HP_Lost_Per_Hit));
                }
            }

            [DisplayName("Offset")]
            public long Safi_Jiva_Seal_Charge_Blade_HP_Lost_Per_Hit_offset { get; private set; }

            protected float Safi_Jiva_Seal_Insect_Glaive_HP_Lost_Per_Hit_raw;
            public const string Safi_Jiva_Seal_Insect_Glaive_HP_Lost_Per_Hit_displayName = "Safi'Jiva Seal: (Insect Glaive) HP Lost Per Hit";
            public const int Safi_Jiva_Seal_Insect_Glaive_HP_Lost_Per_Hit_sortIndex = 4300;
            [SortOrder(Safi_Jiva_Seal_Insect_Glaive_HP_Lost_Per_Hit_sortIndex)]
            [DisplayName(Safi_Jiva_Seal_Insect_Glaive_HP_Lost_Per_Hit_displayName)]
            public virtual float Safi_Jiva_Seal_Insect_Glaive_HP_Lost_Per_Hit {
                get => Safi_Jiva_Seal_Insect_Glaive_HP_Lost_Per_Hit_raw;
                set {
                    if (Safi_Jiva_Seal_Insect_Glaive_HP_Lost_Per_Hit_raw == value) return;
                    Safi_Jiva_Seal_Insect_Glaive_HP_Lost_Per_Hit_raw = value;
                    ChangedItems.Add(nameof(Safi_Jiva_Seal_Insect_Glaive_HP_Lost_Per_Hit));
                    OnPropertyChanged(nameof(Safi_Jiva_Seal_Insect_Glaive_HP_Lost_Per_Hit));
                }
            }

            [DisplayName("Offset")]
            public long Safi_Jiva_Seal_Insect_Glaive_HP_Lost_Per_Hit_offset { get; private set; }

            protected float Safi_Jiva_Seal_Bow_HP_Lost_Per_Hit_raw;
            public const string Safi_Jiva_Seal_Bow_HP_Lost_Per_Hit_displayName = "Safi'Jiva Seal: (Bow) HP Lost Per Hit";
            public const int Safi_Jiva_Seal_Bow_HP_Lost_Per_Hit_sortIndex = 4350;
            [SortOrder(Safi_Jiva_Seal_Bow_HP_Lost_Per_Hit_sortIndex)]
            [DisplayName(Safi_Jiva_Seal_Bow_HP_Lost_Per_Hit_displayName)]
            public virtual float Safi_Jiva_Seal_Bow_HP_Lost_Per_Hit {
                get => Safi_Jiva_Seal_Bow_HP_Lost_Per_Hit_raw;
                set {
                    if (Safi_Jiva_Seal_Bow_HP_Lost_Per_Hit_raw == value) return;
                    Safi_Jiva_Seal_Bow_HP_Lost_Per_Hit_raw = value;
                    ChangedItems.Add(nameof(Safi_Jiva_Seal_Bow_HP_Lost_Per_Hit));
                    OnPropertyChanged(nameof(Safi_Jiva_Seal_Bow_HP_Lost_Per_Hit));
                }
            }

            [DisplayName("Offset")]
            public long Safi_Jiva_Seal_Bow_HP_Lost_Per_Hit_offset { get; private set; }

            protected float Safi_Jiva_Seal_HBG_HP_Lost_Per_Hit_raw;
            public const string Safi_Jiva_Seal_HBG_HP_Lost_Per_Hit_displayName = "Safi'Jiva Seal: (HBG) HP Lost Per Hit";
            public const int Safi_Jiva_Seal_HBG_HP_Lost_Per_Hit_sortIndex = 4400;
            [SortOrder(Safi_Jiva_Seal_HBG_HP_Lost_Per_Hit_sortIndex)]
            [DisplayName(Safi_Jiva_Seal_HBG_HP_Lost_Per_Hit_displayName)]
            public virtual float Safi_Jiva_Seal_HBG_HP_Lost_Per_Hit {
                get => Safi_Jiva_Seal_HBG_HP_Lost_Per_Hit_raw;
                set {
                    if (Safi_Jiva_Seal_HBG_HP_Lost_Per_Hit_raw == value) return;
                    Safi_Jiva_Seal_HBG_HP_Lost_Per_Hit_raw = value;
                    ChangedItems.Add(nameof(Safi_Jiva_Seal_HBG_HP_Lost_Per_Hit));
                    OnPropertyChanged(nameof(Safi_Jiva_Seal_HBG_HP_Lost_Per_Hit));
                }
            }

            [DisplayName("Offset")]
            public long Safi_Jiva_Seal_HBG_HP_Lost_Per_Hit_offset { get; private set; }

            protected float Safi_Jiva_Seal_LBG_HP_Lost_Per_Hit_raw;
            public const string Safi_Jiva_Seal_LBG_HP_Lost_Per_Hit_displayName = "Safi'Jiva Seal: (LBG) HP Lost Per Hit";
            public const int Safi_Jiva_Seal_LBG_HP_Lost_Per_Hit_sortIndex = 4450;
            [SortOrder(Safi_Jiva_Seal_LBG_HP_Lost_Per_Hit_sortIndex)]
            [DisplayName(Safi_Jiva_Seal_LBG_HP_Lost_Per_Hit_displayName)]
            public virtual float Safi_Jiva_Seal_LBG_HP_Lost_Per_Hit {
                get => Safi_Jiva_Seal_LBG_HP_Lost_Per_Hit_raw;
                set {
                    if (Safi_Jiva_Seal_LBG_HP_Lost_Per_Hit_raw == value) return;
                    Safi_Jiva_Seal_LBG_HP_Lost_Per_Hit_raw = value;
                    ChangedItems.Add(nameof(Safi_Jiva_Seal_LBG_HP_Lost_Per_Hit));
                    OnPropertyChanged(nameof(Safi_Jiva_Seal_LBG_HP_Lost_Per_Hit));
                }
            }

            [DisplayName("Offset")]
            public long Safi_Jiva_Seal_LBG_HP_Lost_Per_Hit_offset { get; private set; }

            protected float Safi_Recovery_Interval_raw;
            public const string Safi_Recovery_Interval_displayName = "Safi: Recovery Interval";
            public const int Safi_Recovery_Interval_sortIndex = 4500;
            [SortOrder(Safi_Recovery_Interval_sortIndex)]
            [DisplayName(Safi_Recovery_Interval_displayName)]
            public virtual float Safi_Recovery_Interval {
                get => Safi_Recovery_Interval_raw;
                set {
                    if (Safi_Recovery_Interval_raw == value) return;
                    Safi_Recovery_Interval_raw = value;
                    ChangedItems.Add(nameof(Safi_Recovery_Interval));
                    OnPropertyChanged(nameof(Safi_Recovery_Interval));
                }
            }

            [DisplayName("Offset")]
            public long Safi_Recovery_Interval_offset { get; private set; }

            protected float Safi_Recovery_Amount_raw;
            public const string Safi_Recovery_Amount_displayName = "Safi: Recovery Amount";
            public const int Safi_Recovery_Amount_sortIndex = 4550;
            [SortOrder(Safi_Recovery_Amount_sortIndex)]
            [DisplayName(Safi_Recovery_Amount_displayName)]
            public virtual float Safi_Recovery_Amount {
                get => Safi_Recovery_Amount_raw;
                set {
                    if (Safi_Recovery_Amount_raw == value) return;
                    Safi_Recovery_Amount_raw = value;
                    ChangedItems.Add(nameof(Safi_Recovery_Amount));
                    OnPropertyChanged(nameof(Safi_Recovery_Amount));
                }
            }

            [DisplayName("Offset")]
            public long Safi_Recovery_Amount_offset { get; private set; }

            protected float Safi_Recovery_Time_raw;
            public const string Safi_Recovery_Time_displayName = "Safi: Recovery Time";
            public const int Safi_Recovery_Time_sortIndex = 4600;
            [SortOrder(Safi_Recovery_Time_sortIndex)]
            [DisplayName(Safi_Recovery_Time_displayName)]
            public virtual float Safi_Recovery_Time {
                get => Safi_Recovery_Time_raw;
                set {
                    if (Safi_Recovery_Time_raw == value) return;
                    Safi_Recovery_Time_raw = value;
                    ChangedItems.Add(nameof(Safi_Recovery_Time));
                    OnPropertyChanged(nameof(Safi_Recovery_Time));
                }
            }

            [DisplayName("Offset")]
            public long Safi_Recovery_Time_offset { get; private set; }

            protected float Unk_Safi_8_raw;
            public const string Unk_Safi_8_displayName = "Unk Safi 8";
            public const int Unk_Safi_8_sortIndex = 4650;
            [SortOrder(Unk_Safi_8_sortIndex)]
            [DisplayName(Unk_Safi_8_displayName)]
            public virtual float Unk_Safi_8 {
                get => Unk_Safi_8_raw;
                set {
                    if (Unk_Safi_8_raw == value) return;
                    Unk_Safi_8_raw = value;
                    ChangedItems.Add(nameof(Unk_Safi_8));
                    OnPropertyChanged(nameof(Unk_Safi_8));
                }
            }

            [DisplayName("Offset")]
            public long Unk_Safi_8_offset { get; private set; }

            protected float Set_3_Elemental_Limit_raw;
            public const string Set_3_Elemental_Limit_displayName = "Set(3) Elemental Limit";
            public const int Set_3_Elemental_Limit_sortIndex = 4700;
            [SortOrder(Set_3_Elemental_Limit_sortIndex)]
            [DisplayName(Set_3_Elemental_Limit_displayName)]
            public virtual float Set_3_Elemental_Limit {
                get => Set_3_Elemental_Limit_raw;
                set {
                    if (Set_3_Elemental_Limit_raw == value) return;
                    Set_3_Elemental_Limit_raw = value;
                    ChangedItems.Add(nameof(Set_3_Elemental_Limit));
                    OnPropertyChanged(nameof(Set_3_Elemental_Limit));
                }
            }

            [DisplayName("Offset")]
            public long Set_3_Elemental_Limit_offset { get; private set; }

            protected float Set_5_Elemental_Limit_raw;
            public const string Set_5_Elemental_Limit_displayName = "Set(5) Elemental Limit";
            public const int Set_5_Elemental_Limit_sortIndex = 4750;
            [SortOrder(Set_5_Elemental_Limit_sortIndex)]
            [DisplayName(Set_5_Elemental_Limit_displayName)]
            public virtual float Set_5_Elemental_Limit {
                get => Set_5_Elemental_Limit_raw;
                set {
                    if (Set_5_Elemental_Limit_raw == value) return;
                    Set_5_Elemental_Limit_raw = value;
                    ChangedItems.Add(nameof(Set_5_Elemental_Limit));
                    OnPropertyChanged(nameof(Set_5_Elemental_Limit));
                }
            }

            [DisplayName("Offset")]
            public long Set_5_Elemental_Limit_offset { get; private set; }

            protected float Set_3_Bowgun_Elemental_Limit_raw;
            public const string Set_3_Bowgun_Elemental_Limit_displayName = "Set(3) Bowgun Elemental Limit";
            public const int Set_3_Bowgun_Elemental_Limit_sortIndex = 4800;
            [SortOrder(Set_3_Bowgun_Elemental_Limit_sortIndex)]
            [DisplayName(Set_3_Bowgun_Elemental_Limit_displayName)]
            public virtual float Set_3_Bowgun_Elemental_Limit {
                get => Set_3_Bowgun_Elemental_Limit_raw;
                set {
                    if (Set_3_Bowgun_Elemental_Limit_raw == value) return;
                    Set_3_Bowgun_Elemental_Limit_raw = value;
                    ChangedItems.Add(nameof(Set_3_Bowgun_Elemental_Limit));
                    OnPropertyChanged(nameof(Set_3_Bowgun_Elemental_Limit));
                }
            }

            [DisplayName("Offset")]
            public long Set_3_Bowgun_Elemental_Limit_offset { get; private set; }

            protected float Set_5_Bowgun_Elemental_Limit_raw;
            public const string Set_5_Bowgun_Elemental_Limit_displayName = "Set(5) Bowgun Elemental Limit";
            public const int Set_5_Bowgun_Elemental_Limit_sortIndex = 4850;
            [SortOrder(Set_5_Bowgun_Elemental_Limit_sortIndex)]
            [DisplayName(Set_5_Bowgun_Elemental_Limit_displayName)]
            public virtual float Set_5_Bowgun_Elemental_Limit {
                get => Set_5_Bowgun_Elemental_Limit_raw;
                set {
                    if (Set_5_Bowgun_Elemental_Limit_raw == value) return;
                    Set_5_Bowgun_Elemental_Limit_raw = value;
                    ChangedItems.Add(nameof(Set_5_Bowgun_Elemental_Limit));
                    OnPropertyChanged(nameof(Set_5_Bowgun_Elemental_Limit));
                }
            }

            [DisplayName("Offset")]
            public long Set_5_Bowgun_Elemental_Limit_offset { get; private set; }

            protected float Set_3_Status_Limit_raw;
            public const string Set_3_Status_Limit_displayName = "Set(3) Status Limit";
            public const int Set_3_Status_Limit_sortIndex = 4900;
            [SortOrder(Set_3_Status_Limit_sortIndex)]
            [DisplayName(Set_3_Status_Limit_displayName)]
            public virtual float Set_3_Status_Limit {
                get => Set_3_Status_Limit_raw;
                set {
                    if (Set_3_Status_Limit_raw == value) return;
                    Set_3_Status_Limit_raw = value;
                    ChangedItems.Add(nameof(Set_3_Status_Limit));
                    OnPropertyChanged(nameof(Set_3_Status_Limit));
                }
            }

            [DisplayName("Offset")]
            public long Set_3_Status_Limit_offset { get; private set; }

            protected float Set_5_Status_Limit_raw;
            public const string Set_5_Status_Limit_displayName = "Set(5) Status Limit";
            public const int Set_5_Status_Limit_sortIndex = 4950;
            [SortOrder(Set_5_Status_Limit_sortIndex)]
            [DisplayName(Set_5_Status_Limit_displayName)]
            public virtual float Set_5_Status_Limit {
                get => Set_5_Status_Limit_raw;
                set {
                    if (Set_5_Status_Limit_raw == value) return;
                    Set_5_Status_Limit_raw = value;
                    ChangedItems.Add(nameof(Set_5_Status_Limit));
                    OnPropertyChanged(nameof(Set_5_Status_Limit));
                }
            }

            [DisplayName("Offset")]
            public long Set_5_Status_Limit_offset { get; private set; }

            public const int lastSortIndex = 5000;

            public static ObservableMhwStructCollection<Skill_Params_7_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Skill_Params_7_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Skill_Params_7_ LoadData(BinaryReader reader, ulong i) {
                var data = new Skill_Params_7_();
                data.Index = i;
                data.Unk_Safi_1_offset = reader.BaseStream.Position;
                data.Unk_Safi_1_raw = reader.ReadByte();
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
                data.Unk39_offset = reader.BaseStream.Position;
                data.Unk39_raw = reader.ReadSingle();
                data.Unk40_offset = reader.BaseStream.Position;
                data.Unk40_raw = reader.ReadSingle();
                data.Unk41_offset = reader.BaseStream.Position;
                data.Unk41_raw = reader.ReadSingle();
                data.Unk42_offset = reader.BaseStream.Position;
                data.Unk42_raw = reader.ReadSingle();
                data.Unk43_offset = reader.BaseStream.Position;
                data.Unk43_raw = reader.ReadSingle();
                data.Unk44_offset = reader.BaseStream.Position;
                data.Unk44_raw = reader.ReadSingle();
                data.Unk45_offset = reader.BaseStream.Position;
                data.Unk45_raw = reader.ReadSingle();
                data.Unk46_offset = reader.BaseStream.Position;
                data.Unk46_raw = reader.ReadSingle();
                data.Unk47_offset = reader.BaseStream.Position;
                data.Unk47_raw = reader.ReadSingle();
                data.Unk48_offset = reader.BaseStream.Position;
                data.Unk48_raw = reader.ReadSingle();
                data.Unk49_offset = reader.BaseStream.Position;
                data.Unk49_raw = reader.ReadSingle();
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
                data.Offensive_Guard_offset = reader.BaseStream.Position;
                data.Offensive_Guard_raw = reader.ReadSingle();
                data.Coalescence_offset = reader.BaseStream.Position;
                data.Coalescence_raw = reader.ReadSingle();
                data.Unk_Safi_2_offset = reader.BaseStream.Position;
                data.Unk_Safi_2_raw = reader.ReadSingle();
                data.Unk_Safi_3_offset = reader.BaseStream.Position;
                data.Unk_Safi_3_raw = reader.ReadSingle();
                data.Unk_Safi_4_offset = reader.BaseStream.Position;
                data.Unk_Safi_4_raw = reader.ReadSingle();
                data.Unk_Safi_5_offset = reader.BaseStream.Position;
                data.Unk_Safi_5_raw = reader.ReadUInt32();
                data.Unk_Safi_6_offset = reader.BaseStream.Position;
                data.Unk_Safi_6_raw = reader.ReadUInt32();
                data.Unk_Safi_7_offset = reader.BaseStream.Position;
                data.Unk_Safi_7_raw = reader.ReadSingle();
                data.Set_3_Elemental_Bonus_offset = reader.BaseStream.Position;
                data.Set_3_Elemental_Bonus_raw = reader.ReadSingle();
                data.Set_5_Elemental_Bonus_offset = reader.BaseStream.Position;
                data.Set_5_Elemental_Bonus_raw = reader.ReadSingle();
                data.Set_3_Status_Bonus_offset = reader.BaseStream.Position;
                data.Set_3_Status_Bonus_raw = reader.ReadSingle();
                data.Set_5_Status_Bonus_offset = reader.BaseStream.Position;
                data.Set_5_Status_Bonus_raw = reader.ReadSingle();
                data.Set_3_Affinity_Bonus_offset = reader.BaseStream.Position;
                data.Set_3_Affinity_Bonus_raw = reader.ReadUInt32();
                data.Set_5_Affinity_Bonus_offset = reader.BaseStream.Position;
                data.Set_5_Affinity_Bonus_raw = reader.ReadUInt32();
                data.Safi_Jiva_Seal_Great_Sword_Hit_Combo_to_Heal_offset = reader.BaseStream.Position;
                data.Safi_Jiva_Seal_Great_Sword_Hit_Combo_to_Heal_raw = reader.ReadByte();
                data.Safi_Jiva_Seal_Sword_Shield_Hit_Combo_to_Heal_offset = reader.BaseStream.Position;
                data.Safi_Jiva_Seal_Sword_Shield_Hit_Combo_to_Heal_raw = reader.ReadByte();
                data.Safi_Jiva_Seal_Dual_Blades_Hit_Combo_to_Heal_offset = reader.BaseStream.Position;
                data.Safi_Jiva_Seal_Dual_Blades_Hit_Combo_to_Heal_raw = reader.ReadByte();
                data.Safi_Jiva_Seal_Long_Sword_Hit_Combo_to_Heal_offset = reader.BaseStream.Position;
                data.Safi_Jiva_Seal_Long_Sword_Hit_Combo_to_Heal_raw = reader.ReadByte();
                data.Safi_Jiva_Seal_Hammer_Hit_Combo_to_Heal_offset = reader.BaseStream.Position;
                data.Safi_Jiva_Seal_Hammer_Hit_Combo_to_Heal_raw = reader.ReadByte();
                data.Safi_Jiva_Seal_Hunting_Horn_Hit_Combo_to_Heal_offset = reader.BaseStream.Position;
                data.Safi_Jiva_Seal_Hunting_Horn_Hit_Combo_to_Heal_raw = reader.ReadByte();
                data.Safi_Jiva_Seal_Lance_Hit_Combo_to_Heal_offset = reader.BaseStream.Position;
                data.Safi_Jiva_Seal_Lance_Hit_Combo_to_Heal_raw = reader.ReadByte();
                data.Safi_Jiva_Seal_Gunlance_Hit_Combo_to_Heal_offset = reader.BaseStream.Position;
                data.Safi_Jiva_Seal_Gunlance_Hit_Combo_to_Heal_raw = reader.ReadByte();
                data.Safi_Jiva_Seal_Switch_Axe_Hit_Combo_to_Heal_offset = reader.BaseStream.Position;
                data.Safi_Jiva_Seal_Switch_Axe_Hit_Combo_to_Heal_raw = reader.ReadByte();
                data.Safi_Jiva_Seal_Charge_Blade_Hit_Combo_to_Heal_offset = reader.BaseStream.Position;
                data.Safi_Jiva_Seal_Charge_Blade_Hit_Combo_to_Heal_raw = reader.ReadByte();
                data.Safi_Jiva_Seal_Insect_Glaive_Hit_Combo_to_Heal_offset = reader.BaseStream.Position;
                data.Safi_Jiva_Seal_Insect_Glaive_Hit_Combo_to_Heal_raw = reader.ReadByte();
                data.Safi_Jiva_Seal_Bow_Hit_Combo_to_Heal_offset = reader.BaseStream.Position;
                data.Safi_Jiva_Seal_Bow_Hit_Combo_to_Heal_raw = reader.ReadByte();
                data.Safi_Jiva_Seal_HBG_Hit_Combo_to_Heal_offset = reader.BaseStream.Position;
                data.Safi_Jiva_Seal_HBG_Hit_Combo_to_Heal_raw = reader.ReadByte();
                data.Safi_Jiva_Seal_LBG_Hit_Combo_to_Heal_offset = reader.BaseStream.Position;
                data.Safi_Jiva_Seal_LBG_Hit_Combo_to_Heal_raw = reader.ReadByte();
                data.Safi_Jiva_Seal_Great_Sword_HP_Lost_Per_Hit_offset = reader.BaseStream.Position;
                data.Safi_Jiva_Seal_Great_Sword_HP_Lost_Per_Hit_raw = reader.ReadSingle();
                data.Safi_Jiva_Seal_Sword_Shield_HP_Lost_Per_Hit_offset = reader.BaseStream.Position;
                data.Safi_Jiva_Seal_Sword_Shield_HP_Lost_Per_Hit_raw = reader.ReadSingle();
                data.Safi_Jiva_Seal_Dual_Blades_HP_Lost_Per_Hit_offset = reader.BaseStream.Position;
                data.Safi_Jiva_Seal_Dual_Blades_HP_Lost_Per_Hit_raw = reader.ReadSingle();
                data.Safi_Jiva_Seal_Long_Sword_HP_Lost_Per_Hit_offset = reader.BaseStream.Position;
                data.Safi_Jiva_Seal_Long_Sword_HP_Lost_Per_Hit_raw = reader.ReadSingle();
                data.Safi_Jiva_Seal_Hammer_HP_Lost_Per_Hit_offset = reader.BaseStream.Position;
                data.Safi_Jiva_Seal_Hammer_HP_Lost_Per_Hit_raw = reader.ReadSingle();
                data.Safi_Jiva_Seal_Hunting_Horn_HP_Lost_Per_Hit_offset = reader.BaseStream.Position;
                data.Safi_Jiva_Seal_Hunting_Horn_HP_Lost_Per_Hit_raw = reader.ReadSingle();
                data.Safi_Jiva_Seal_Lance_HP_Lost_Per_Hit_offset = reader.BaseStream.Position;
                data.Safi_Jiva_Seal_Lance_HP_Lost_Per_Hit_raw = reader.ReadSingle();
                data.Safi_Jiva_Seal_Gunlance_HP_Lost_Per_Hit_offset = reader.BaseStream.Position;
                data.Safi_Jiva_Seal_Gunlance_HP_Lost_Per_Hit_raw = reader.ReadSingle();
                data.Safi_Jiva_Seal_Switch_Axe_HP_Lost_Per_Hit_offset = reader.BaseStream.Position;
                data.Safi_Jiva_Seal_Switch_Axe_HP_Lost_Per_Hit_raw = reader.ReadSingle();
                data.Safi_Jiva_Seal_Charge_Blade_HP_Lost_Per_Hit_offset = reader.BaseStream.Position;
                data.Safi_Jiva_Seal_Charge_Blade_HP_Lost_Per_Hit_raw = reader.ReadSingle();
                data.Safi_Jiva_Seal_Insect_Glaive_HP_Lost_Per_Hit_offset = reader.BaseStream.Position;
                data.Safi_Jiva_Seal_Insect_Glaive_HP_Lost_Per_Hit_raw = reader.ReadSingle();
                data.Safi_Jiva_Seal_Bow_HP_Lost_Per_Hit_offset = reader.BaseStream.Position;
                data.Safi_Jiva_Seal_Bow_HP_Lost_Per_Hit_raw = reader.ReadSingle();
                data.Safi_Jiva_Seal_HBG_HP_Lost_Per_Hit_offset = reader.BaseStream.Position;
                data.Safi_Jiva_Seal_HBG_HP_Lost_Per_Hit_raw = reader.ReadSingle();
                data.Safi_Jiva_Seal_LBG_HP_Lost_Per_Hit_offset = reader.BaseStream.Position;
                data.Safi_Jiva_Seal_LBG_HP_Lost_Per_Hit_raw = reader.ReadSingle();
                data.Safi_Recovery_Interval_offset = reader.BaseStream.Position;
                data.Safi_Recovery_Interval_raw = reader.ReadSingle();
                data.Safi_Recovery_Amount_offset = reader.BaseStream.Position;
                data.Safi_Recovery_Amount_raw = reader.ReadSingle();
                data.Safi_Recovery_Time_offset = reader.BaseStream.Position;
                data.Safi_Recovery_Time_raw = reader.ReadSingle();
                data.Unk_Safi_8_offset = reader.BaseStream.Position;
                data.Unk_Safi_8_raw = reader.ReadSingle();
                data.Set_3_Elemental_Limit_offset = reader.BaseStream.Position;
                data.Set_3_Elemental_Limit_raw = reader.ReadSingle();
                data.Set_5_Elemental_Limit_offset = reader.BaseStream.Position;
                data.Set_5_Elemental_Limit_raw = reader.ReadSingle();
                data.Set_3_Bowgun_Elemental_Limit_offset = reader.BaseStream.Position;
                data.Set_3_Bowgun_Elemental_Limit_raw = reader.ReadSingle();
                data.Set_5_Bowgun_Elemental_Limit_offset = reader.BaseStream.Position;
                data.Set_5_Bowgun_Elemental_Limit_raw = reader.ReadSingle();
                data.Set_3_Status_Limit_offset = reader.BaseStream.Position;
                data.Set_3_Status_Limit_raw = reader.ReadSingle();
                data.Set_5_Status_Limit_offset = reader.BaseStream.Position;
                data.Set_5_Status_Limit_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_Safi_1_raw);
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
                writer.Write(Offensive_Guard_raw);
                writer.Write(Coalescence_raw);
                writer.Write(Unk_Safi_2_raw);
                writer.Write(Unk_Safi_3_raw);
                writer.Write(Unk_Safi_4_raw);
                writer.Write(Unk_Safi_5_raw);
                writer.Write(Unk_Safi_6_raw);
                writer.Write(Unk_Safi_7_raw);
                writer.Write(Set_3_Elemental_Bonus_raw);
                writer.Write(Set_5_Elemental_Bonus_raw);
                writer.Write(Set_3_Status_Bonus_raw);
                writer.Write(Set_5_Status_Bonus_raw);
                writer.Write(Set_3_Affinity_Bonus_raw);
                writer.Write(Set_5_Affinity_Bonus_raw);
                writer.Write(Safi_Jiva_Seal_Great_Sword_Hit_Combo_to_Heal_raw);
                writer.Write(Safi_Jiva_Seal_Sword_Shield_Hit_Combo_to_Heal_raw);
                writer.Write(Safi_Jiva_Seal_Dual_Blades_Hit_Combo_to_Heal_raw);
                writer.Write(Safi_Jiva_Seal_Long_Sword_Hit_Combo_to_Heal_raw);
                writer.Write(Safi_Jiva_Seal_Hammer_Hit_Combo_to_Heal_raw);
                writer.Write(Safi_Jiva_Seal_Hunting_Horn_Hit_Combo_to_Heal_raw);
                writer.Write(Safi_Jiva_Seal_Lance_Hit_Combo_to_Heal_raw);
                writer.Write(Safi_Jiva_Seal_Gunlance_Hit_Combo_to_Heal_raw);
                writer.Write(Safi_Jiva_Seal_Switch_Axe_Hit_Combo_to_Heal_raw);
                writer.Write(Safi_Jiva_Seal_Charge_Blade_Hit_Combo_to_Heal_raw);
                writer.Write(Safi_Jiva_Seal_Insect_Glaive_Hit_Combo_to_Heal_raw);
                writer.Write(Safi_Jiva_Seal_Bow_Hit_Combo_to_Heal_raw);
                writer.Write(Safi_Jiva_Seal_HBG_Hit_Combo_to_Heal_raw);
                writer.Write(Safi_Jiva_Seal_LBG_Hit_Combo_to_Heal_raw);
                writer.Write(Safi_Jiva_Seal_Great_Sword_HP_Lost_Per_Hit_raw);
                writer.Write(Safi_Jiva_Seal_Sword_Shield_HP_Lost_Per_Hit_raw);
                writer.Write(Safi_Jiva_Seal_Dual_Blades_HP_Lost_Per_Hit_raw);
                writer.Write(Safi_Jiva_Seal_Long_Sword_HP_Lost_Per_Hit_raw);
                writer.Write(Safi_Jiva_Seal_Hammer_HP_Lost_Per_Hit_raw);
                writer.Write(Safi_Jiva_Seal_Hunting_Horn_HP_Lost_Per_Hit_raw);
                writer.Write(Safi_Jiva_Seal_Lance_HP_Lost_Per_Hit_raw);
                writer.Write(Safi_Jiva_Seal_Gunlance_HP_Lost_Per_Hit_raw);
                writer.Write(Safi_Jiva_Seal_Switch_Axe_HP_Lost_Per_Hit_raw);
                writer.Write(Safi_Jiva_Seal_Charge_Blade_HP_Lost_Per_Hit_raw);
                writer.Write(Safi_Jiva_Seal_Insect_Glaive_HP_Lost_Per_Hit_raw);
                writer.Write(Safi_Jiva_Seal_Bow_HP_Lost_Per_Hit_raw);
                writer.Write(Safi_Jiva_Seal_HBG_HP_Lost_Per_Hit_raw);
                writer.Write(Safi_Jiva_Seal_LBG_HP_Lost_Per_Hit_raw);
                writer.Write(Safi_Recovery_Interval_raw);
                writer.Write(Safi_Recovery_Amount_raw);
                writer.Write(Safi_Recovery_Time_raw);
                writer.Write(Unk_Safi_8_raw);
                writer.Write(Set_3_Elemental_Limit_raw);
                writer.Write(Set_5_Elemental_Limit_raw);
                writer.Write(Set_3_Bowgun_Elemental_Limit_raw);
                writer.Write(Set_5_Bowgun_Elemental_Limit_raw);
                writer.Write(Set_3_Status_Limit_raw);
                writer.Write(Set_5_Status_Limit_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Unk Safi 1", "Unk_Safi_1", "Unk_Safi_1_offset"),
                    new MultiStructItemCustomView(this, "Unk33", "Unk33", "Unk33_offset"),
                    new MultiStructItemCustomView(this, "Unk34", "Unk34", "Unk34_offset"),
                    new MultiStructItemCustomView(this, "Unk35", "Unk35", "Unk35_offset"),
                    new MultiStructItemCustomView(this, "Unk36", "Unk36", "Unk36_offset"),
                    new MultiStructItemCustomView(this, "Unk37", "Unk37", "Unk37_offset"),
                    new MultiStructItemCustomView(this, "Unk38", "Unk38", "Unk38_offset"),
                    new MultiStructItemCustomView(this, "Unk39", "Unk39", "Unk39_offset"),
                    new MultiStructItemCustomView(this, "Unk40", "Unk40", "Unk40_offset"),
                    new MultiStructItemCustomView(this, "Unk41", "Unk41", "Unk41_offset"),
                    new MultiStructItemCustomView(this, "Unk42", "Unk42", "Unk42_offset"),
                    new MultiStructItemCustomView(this, "Unk43", "Unk43", "Unk43_offset"),
                    new MultiStructItemCustomView(this, "Unk44", "Unk44", "Unk44_offset"),
                    new MultiStructItemCustomView(this, "Unk45", "Unk45", "Unk45_offset"),
                    new MultiStructItemCustomView(this, "Unk46", "Unk46", "Unk46_offset"),
                    new MultiStructItemCustomView(this, "Unk47", "Unk47", "Unk47_offset"),
                    new MultiStructItemCustomView(this, "Unk48", "Unk48", "Unk48_offset"),
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
                    new MultiStructItemCustomView(this, "Offensive Guard", "Offensive_Guard", "Offensive_Guard_offset"),
                    new MultiStructItemCustomView(this, "Coalescence", "Coalescence", "Coalescence_offset"),
                    new MultiStructItemCustomView(this, "Unk Safi 2", "Unk_Safi_2", "Unk_Safi_2_offset"),
                    new MultiStructItemCustomView(this, "Unk Safi 3", "Unk_Safi_3", "Unk_Safi_3_offset"),
                    new MultiStructItemCustomView(this, "Unk Safi 4", "Unk_Safi_4", "Unk_Safi_4_offset"),
                    new MultiStructItemCustomView(this, "Unk Safi 5", "Unk_Safi_5", "Unk_Safi_5_offset"),
                    new MultiStructItemCustomView(this, "Unk Safi 6", "Unk_Safi_6", "Unk_Safi_6_offset"),
                    new MultiStructItemCustomView(this, "Unk Safi 7", "Unk_Safi_7", "Unk_Safi_7_offset"),
                    new MultiStructItemCustomView(this, "Set(3) Elemental Bonus", "Set_3_Elemental_Bonus", "Set_3_Elemental_Bonus_offset"),
                    new MultiStructItemCustomView(this, "Set(5) Elemental Bonus", "Set_5_Elemental_Bonus", "Set_5_Elemental_Bonus_offset"),
                    new MultiStructItemCustomView(this, "Set(3) Status Bonus", "Set_3_Status_Bonus", "Set_3_Status_Bonus_offset"),
                    new MultiStructItemCustomView(this, "Set(5) Status Bonus", "Set_5_Status_Bonus", "Set_5_Status_Bonus_offset"),
                    new MultiStructItemCustomView(this, "Set(3) Affinity Bonus", "Set_3_Affinity_Bonus", "Set_3_Affinity_Bonus_offset"),
                    new MultiStructItemCustomView(this, "Set(5) Affinity Bonus", "Set_5_Affinity_Bonus", "Set_5_Affinity_Bonus_offset"),
                    new MultiStructItemCustomView(this, "Safi'Jiva Seal: (Great Sword) Hit Combo to Heal", "Safi_Jiva_Seal_Great_Sword_Hit_Combo_to_Heal", "Safi_Jiva_Seal_Great_Sword_Hit_Combo_to_Heal_offset"),
                    new MultiStructItemCustomView(this, "Safi'Jiva Seal: (Sword & Shield) Hit Combo to Heal", "Safi_Jiva_Seal_Sword_Shield_Hit_Combo_to_Heal", "Safi_Jiva_Seal_Sword_Shield_Hit_Combo_to_Heal_offset"),
                    new MultiStructItemCustomView(this, "Safi'Jiva Seal: (Dual Blades) Hit Combo to Heal", "Safi_Jiva_Seal_Dual_Blades_Hit_Combo_to_Heal", "Safi_Jiva_Seal_Dual_Blades_Hit_Combo_to_Heal_offset"),
                    new MultiStructItemCustomView(this, "Safi'Jiva Seal: (Long Sword) Hit Combo to Heal", "Safi_Jiva_Seal_Long_Sword_Hit_Combo_to_Heal", "Safi_Jiva_Seal_Long_Sword_Hit_Combo_to_Heal_offset"),
                    new MultiStructItemCustomView(this, "Safi'Jiva Seal: (Hammer) Hit Combo to Heal", "Safi_Jiva_Seal_Hammer_Hit_Combo_to_Heal", "Safi_Jiva_Seal_Hammer_Hit_Combo_to_Heal_offset"),
                    new MultiStructItemCustomView(this, "Safi'Jiva Seal: (Hunting Horn) Hit Combo to Heal", "Safi_Jiva_Seal_Hunting_Horn_Hit_Combo_to_Heal", "Safi_Jiva_Seal_Hunting_Horn_Hit_Combo_to_Heal_offset"),
                    new MultiStructItemCustomView(this, "Safi'Jiva Seal: (Lance) Hit Combo to Heal", "Safi_Jiva_Seal_Lance_Hit_Combo_to_Heal", "Safi_Jiva_Seal_Lance_Hit_Combo_to_Heal_offset"),
                    new MultiStructItemCustomView(this, "Safi'Jiva Seal: (Gunlance) Hit Combo to Heal", "Safi_Jiva_Seal_Gunlance_Hit_Combo_to_Heal", "Safi_Jiva_Seal_Gunlance_Hit_Combo_to_Heal_offset"),
                    new MultiStructItemCustomView(this, "Safi'Jiva Seal: (Switch Axe) Hit Combo to Heal", "Safi_Jiva_Seal_Switch_Axe_Hit_Combo_to_Heal", "Safi_Jiva_Seal_Switch_Axe_Hit_Combo_to_Heal_offset"),
                    new MultiStructItemCustomView(this, "Safi'Jiva Seal: (Charge Blade) Hit Combo to Heal", "Safi_Jiva_Seal_Charge_Blade_Hit_Combo_to_Heal", "Safi_Jiva_Seal_Charge_Blade_Hit_Combo_to_Heal_offset"),
                    new MultiStructItemCustomView(this, "Safi'Jiva Seal: (Insect Glaive) Hit Combo to Heal", "Safi_Jiva_Seal_Insect_Glaive_Hit_Combo_to_Heal", "Safi_Jiva_Seal_Insect_Glaive_Hit_Combo_to_Heal_offset"),
                    new MultiStructItemCustomView(this, "Safi'Jiva Seal: (Bow) Hit Combo to Heal", "Safi_Jiva_Seal_Bow_Hit_Combo_to_Heal", "Safi_Jiva_Seal_Bow_Hit_Combo_to_Heal_offset"),
                    new MultiStructItemCustomView(this, "Safi'Jiva Seal: (HBG) Hit Combo to Heal", "Safi_Jiva_Seal_HBG_Hit_Combo_to_Heal", "Safi_Jiva_Seal_HBG_Hit_Combo_to_Heal_offset"),
                    new MultiStructItemCustomView(this, "Safi'Jiva Seal: (LBG) Hit Combo to Heal", "Safi_Jiva_Seal_LBG_Hit_Combo_to_Heal", "Safi_Jiva_Seal_LBG_Hit_Combo_to_Heal_offset"),
                    new MultiStructItemCustomView(this, "Safi'Jiva Seal: (Great Sword) HP Lost Per Hit", "Safi_Jiva_Seal_Great_Sword_HP_Lost_Per_Hit", "Safi_Jiva_Seal_Great_Sword_HP_Lost_Per_Hit_offset"),
                    new MultiStructItemCustomView(this, "Safi'Jiva Seal: (Sword & Shield) HP Lost Per Hit", "Safi_Jiva_Seal_Sword_Shield_HP_Lost_Per_Hit", "Safi_Jiva_Seal_Sword_Shield_HP_Lost_Per_Hit_offset"),
                    new MultiStructItemCustomView(this, "Safi'Jiva Seal: (Dual Blades) HP Lost Per Hit", "Safi_Jiva_Seal_Dual_Blades_HP_Lost_Per_Hit", "Safi_Jiva_Seal_Dual_Blades_HP_Lost_Per_Hit_offset"),
                    new MultiStructItemCustomView(this, "Safi'Jiva Seal: (Long Sword) HP Lost Per Hit", "Safi_Jiva_Seal_Long_Sword_HP_Lost_Per_Hit", "Safi_Jiva_Seal_Long_Sword_HP_Lost_Per_Hit_offset"),
                    new MultiStructItemCustomView(this, "Safi'Jiva Seal: (Hammer) HP Lost Per Hit", "Safi_Jiva_Seal_Hammer_HP_Lost_Per_Hit", "Safi_Jiva_Seal_Hammer_HP_Lost_Per_Hit_offset"),
                    new MultiStructItemCustomView(this, "Safi'Jiva Seal: (Hunting Horn) HP Lost Per Hit", "Safi_Jiva_Seal_Hunting_Horn_HP_Lost_Per_Hit", "Safi_Jiva_Seal_Hunting_Horn_HP_Lost_Per_Hit_offset"),
                    new MultiStructItemCustomView(this, "Safi'Jiva Seal: (Lance) HP Lost Per Hit", "Safi_Jiva_Seal_Lance_HP_Lost_Per_Hit", "Safi_Jiva_Seal_Lance_HP_Lost_Per_Hit_offset"),
                    new MultiStructItemCustomView(this, "Safi'Jiva Seal: (Gunlance) HP Lost Per Hit", "Safi_Jiva_Seal_Gunlance_HP_Lost_Per_Hit", "Safi_Jiva_Seal_Gunlance_HP_Lost_Per_Hit_offset"),
                    new MultiStructItemCustomView(this, "Safi'Jiva Seal: (Switch Axe) HP Lost Per Hit", "Safi_Jiva_Seal_Switch_Axe_HP_Lost_Per_Hit", "Safi_Jiva_Seal_Switch_Axe_HP_Lost_Per_Hit_offset"),
                    new MultiStructItemCustomView(this, "Safi'Jiva Seal: (Charge Blade) HP Lost Per Hit", "Safi_Jiva_Seal_Charge_Blade_HP_Lost_Per_Hit", "Safi_Jiva_Seal_Charge_Blade_HP_Lost_Per_Hit_offset"),
                    new MultiStructItemCustomView(this, "Safi'Jiva Seal: (Insect Glaive) HP Lost Per Hit", "Safi_Jiva_Seal_Insect_Glaive_HP_Lost_Per_Hit", "Safi_Jiva_Seal_Insect_Glaive_HP_Lost_Per_Hit_offset"),
                    new MultiStructItemCustomView(this, "Safi'Jiva Seal: (Bow) HP Lost Per Hit", "Safi_Jiva_Seal_Bow_HP_Lost_Per_Hit", "Safi_Jiva_Seal_Bow_HP_Lost_Per_Hit_offset"),
                    new MultiStructItemCustomView(this, "Safi'Jiva Seal: (HBG) HP Lost Per Hit", "Safi_Jiva_Seal_HBG_HP_Lost_Per_Hit", "Safi_Jiva_Seal_HBG_HP_Lost_Per_Hit_offset"),
                    new MultiStructItemCustomView(this, "Safi'Jiva Seal: (LBG) HP Lost Per Hit", "Safi_Jiva_Seal_LBG_HP_Lost_Per_Hit", "Safi_Jiva_Seal_LBG_HP_Lost_Per_Hit_offset"),
                    new MultiStructItemCustomView(this, "Safi: Recovery Interval", "Safi_Recovery_Interval", "Safi_Recovery_Interval_offset"),
                    new MultiStructItemCustomView(this, "Safi: Recovery Amount", "Safi_Recovery_Amount", "Safi_Recovery_Amount_offset"),
                    new MultiStructItemCustomView(this, "Safi: Recovery Time", "Safi_Recovery_Time", "Safi_Recovery_Time_offset"),
                    new MultiStructItemCustomView(this, "Unk Safi 8", "Unk_Safi_8", "Unk_Safi_8_offset"),
                    new MultiStructItemCustomView(this, "Set(3) Elemental Limit", "Set_3_Elemental_Limit", "Set_3_Elemental_Limit_offset"),
                    new MultiStructItemCustomView(this, "Set(5) Elemental Limit", "Set_5_Elemental_Limit", "Set_5_Elemental_Limit_offset"),
                    new MultiStructItemCustomView(this, "Set(3) Bowgun Elemental Limit", "Set_3_Bowgun_Elemental_Limit", "Set_3_Bowgun_Elemental_Limit_offset"),
                    new MultiStructItemCustomView(this, "Set(5) Bowgun Elemental Limit", "Set_5_Bowgun_Elemental_Limit", "Set_5_Bowgun_Elemental_Limit_offset"),
                    new MultiStructItemCustomView(this, "Set(3) Status Limit", "Set_3_Status_Limit", "Set_3_Status_Limit_offset"),
                    new MultiStructItemCustomView(this, "Set(5) Status Limit", "Set_5_Status_Limit", "Set_5_Status_Limit_offset"),
                };
            }
        }

        public partial class Clutch_Claw_Boost : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Clutch Claw Boost";

            protected float Tenderizing_Damage_Multiplier_Great_Sword_raw;
            public const string Tenderizing_Damage_Multiplier_Great_Sword_displayName = "Tenderizing Damage % Multiplier: Great Sword";
            public const int Tenderizing_Damage_Multiplier_Great_Sword_sortIndex = 50;
            [SortOrder(Tenderizing_Damage_Multiplier_Great_Sword_sortIndex)]
            [DisplayName(Tenderizing_Damage_Multiplier_Great_Sword_displayName)]
            public virtual float Tenderizing_Damage_Multiplier_Great_Sword {
                get => Tenderizing_Damage_Multiplier_Great_Sword_raw;
                set {
                    if (Tenderizing_Damage_Multiplier_Great_Sword_raw == value) return;
                    Tenderizing_Damage_Multiplier_Great_Sword_raw = value;
                    ChangedItems.Add(nameof(Tenderizing_Damage_Multiplier_Great_Sword));
                    OnPropertyChanged(nameof(Tenderizing_Damage_Multiplier_Great_Sword));
                }
            }

            [DisplayName("Offset")]
            public long Tenderizing_Damage_Multiplier_Great_Sword_offset { get; private set; }

            protected float Tenderizing_Damage_Multiplier_Sword_Shield_raw;
            public const string Tenderizing_Damage_Multiplier_Sword_Shield_displayName = "Tenderizing Damage % Multiplier: Sword & Shield";
            public const int Tenderizing_Damage_Multiplier_Sword_Shield_sortIndex = 100;
            [SortOrder(Tenderizing_Damage_Multiplier_Sword_Shield_sortIndex)]
            [DisplayName(Tenderizing_Damage_Multiplier_Sword_Shield_displayName)]
            public virtual float Tenderizing_Damage_Multiplier_Sword_Shield {
                get => Tenderizing_Damage_Multiplier_Sword_Shield_raw;
                set {
                    if (Tenderizing_Damage_Multiplier_Sword_Shield_raw == value) return;
                    Tenderizing_Damage_Multiplier_Sword_Shield_raw = value;
                    ChangedItems.Add(nameof(Tenderizing_Damage_Multiplier_Sword_Shield));
                    OnPropertyChanged(nameof(Tenderizing_Damage_Multiplier_Sword_Shield));
                }
            }

            [DisplayName("Offset")]
            public long Tenderizing_Damage_Multiplier_Sword_Shield_offset { get; private set; }

            protected float Tenderizing_Damage_Multiplier_Dual_Blades_raw;
            public const string Tenderizing_Damage_Multiplier_Dual_Blades_displayName = "Tenderizing Damage % Multiplier: Dual Blades";
            public const int Tenderizing_Damage_Multiplier_Dual_Blades_sortIndex = 150;
            [SortOrder(Tenderizing_Damage_Multiplier_Dual_Blades_sortIndex)]
            [DisplayName(Tenderizing_Damage_Multiplier_Dual_Blades_displayName)]
            public virtual float Tenderizing_Damage_Multiplier_Dual_Blades {
                get => Tenderizing_Damage_Multiplier_Dual_Blades_raw;
                set {
                    if (Tenderizing_Damage_Multiplier_Dual_Blades_raw == value) return;
                    Tenderizing_Damage_Multiplier_Dual_Blades_raw = value;
                    ChangedItems.Add(nameof(Tenderizing_Damage_Multiplier_Dual_Blades));
                    OnPropertyChanged(nameof(Tenderizing_Damage_Multiplier_Dual_Blades));
                }
            }

            [DisplayName("Offset")]
            public long Tenderizing_Damage_Multiplier_Dual_Blades_offset { get; private set; }

            protected float Tenderizing_Damage_Multiplier_Long_Sword_raw;
            public const string Tenderizing_Damage_Multiplier_Long_Sword_displayName = "Tenderizing Damage % Multiplier: Long Sword";
            public const int Tenderizing_Damage_Multiplier_Long_Sword_sortIndex = 200;
            [SortOrder(Tenderizing_Damage_Multiplier_Long_Sword_sortIndex)]
            [DisplayName(Tenderizing_Damage_Multiplier_Long_Sword_displayName)]
            public virtual float Tenderizing_Damage_Multiplier_Long_Sword {
                get => Tenderizing_Damage_Multiplier_Long_Sword_raw;
                set {
                    if (Tenderizing_Damage_Multiplier_Long_Sword_raw == value) return;
                    Tenderizing_Damage_Multiplier_Long_Sword_raw = value;
                    ChangedItems.Add(nameof(Tenderizing_Damage_Multiplier_Long_Sword));
                    OnPropertyChanged(nameof(Tenderizing_Damage_Multiplier_Long_Sword));
                }
            }

            [DisplayName("Offset")]
            public long Tenderizing_Damage_Multiplier_Long_Sword_offset { get; private set; }

            protected float Tenderizing_Damage_Multiplier_Hammer_raw;
            public const string Tenderizing_Damage_Multiplier_Hammer_displayName = "Tenderizing Damage % Multiplier: Hammer";
            public const int Tenderizing_Damage_Multiplier_Hammer_sortIndex = 250;
            [SortOrder(Tenderizing_Damage_Multiplier_Hammer_sortIndex)]
            [DisplayName(Tenderizing_Damage_Multiplier_Hammer_displayName)]
            public virtual float Tenderizing_Damage_Multiplier_Hammer {
                get => Tenderizing_Damage_Multiplier_Hammer_raw;
                set {
                    if (Tenderizing_Damage_Multiplier_Hammer_raw == value) return;
                    Tenderizing_Damage_Multiplier_Hammer_raw = value;
                    ChangedItems.Add(nameof(Tenderizing_Damage_Multiplier_Hammer));
                    OnPropertyChanged(nameof(Tenderizing_Damage_Multiplier_Hammer));
                }
            }

            [DisplayName("Offset")]
            public long Tenderizing_Damage_Multiplier_Hammer_offset { get; private set; }

            protected float Tenderizing_Damage_Multiplier_Hunting_Horn_raw;
            public const string Tenderizing_Damage_Multiplier_Hunting_Horn_displayName = "Tenderizing Damage % Multiplier: Hunting Horn";
            public const int Tenderizing_Damage_Multiplier_Hunting_Horn_sortIndex = 300;
            [SortOrder(Tenderizing_Damage_Multiplier_Hunting_Horn_sortIndex)]
            [DisplayName(Tenderizing_Damage_Multiplier_Hunting_Horn_displayName)]
            public virtual float Tenderizing_Damage_Multiplier_Hunting_Horn {
                get => Tenderizing_Damage_Multiplier_Hunting_Horn_raw;
                set {
                    if (Tenderizing_Damage_Multiplier_Hunting_Horn_raw == value) return;
                    Tenderizing_Damage_Multiplier_Hunting_Horn_raw = value;
                    ChangedItems.Add(nameof(Tenderizing_Damage_Multiplier_Hunting_Horn));
                    OnPropertyChanged(nameof(Tenderizing_Damage_Multiplier_Hunting_Horn));
                }
            }

            [DisplayName("Offset")]
            public long Tenderizing_Damage_Multiplier_Hunting_Horn_offset { get; private set; }

            protected float Tenderizing_Damage_Multiplier_Lance_raw;
            public const string Tenderizing_Damage_Multiplier_Lance_displayName = "Tenderizing Damage % Multiplier: Lance";
            public const int Tenderizing_Damage_Multiplier_Lance_sortIndex = 350;
            [SortOrder(Tenderizing_Damage_Multiplier_Lance_sortIndex)]
            [DisplayName(Tenderizing_Damage_Multiplier_Lance_displayName)]
            public virtual float Tenderizing_Damage_Multiplier_Lance {
                get => Tenderizing_Damage_Multiplier_Lance_raw;
                set {
                    if (Tenderizing_Damage_Multiplier_Lance_raw == value) return;
                    Tenderizing_Damage_Multiplier_Lance_raw = value;
                    ChangedItems.Add(nameof(Tenderizing_Damage_Multiplier_Lance));
                    OnPropertyChanged(nameof(Tenderizing_Damage_Multiplier_Lance));
                }
            }

            [DisplayName("Offset")]
            public long Tenderizing_Damage_Multiplier_Lance_offset { get; private set; }

            protected float Tenderizing_Damage_Multiplier_Gunlance_raw;
            public const string Tenderizing_Damage_Multiplier_Gunlance_displayName = "Tenderizing Damage % Multiplier: Gunlance";
            public const int Tenderizing_Damage_Multiplier_Gunlance_sortIndex = 400;
            [SortOrder(Tenderizing_Damage_Multiplier_Gunlance_sortIndex)]
            [DisplayName(Tenderizing_Damage_Multiplier_Gunlance_displayName)]
            public virtual float Tenderizing_Damage_Multiplier_Gunlance {
                get => Tenderizing_Damage_Multiplier_Gunlance_raw;
                set {
                    if (Tenderizing_Damage_Multiplier_Gunlance_raw == value) return;
                    Tenderizing_Damage_Multiplier_Gunlance_raw = value;
                    ChangedItems.Add(nameof(Tenderizing_Damage_Multiplier_Gunlance));
                    OnPropertyChanged(nameof(Tenderizing_Damage_Multiplier_Gunlance));
                }
            }

            [DisplayName("Offset")]
            public long Tenderizing_Damage_Multiplier_Gunlance_offset { get; private set; }

            protected float Tenderizing_Damage_Multiplier_Switch_Axe_raw;
            public const string Tenderizing_Damage_Multiplier_Switch_Axe_displayName = "Tenderizing Damage % Multiplier: Switch Axe";
            public const int Tenderizing_Damage_Multiplier_Switch_Axe_sortIndex = 450;
            [SortOrder(Tenderizing_Damage_Multiplier_Switch_Axe_sortIndex)]
            [DisplayName(Tenderizing_Damage_Multiplier_Switch_Axe_displayName)]
            public virtual float Tenderizing_Damage_Multiplier_Switch_Axe {
                get => Tenderizing_Damage_Multiplier_Switch_Axe_raw;
                set {
                    if (Tenderizing_Damage_Multiplier_Switch_Axe_raw == value) return;
                    Tenderizing_Damage_Multiplier_Switch_Axe_raw = value;
                    ChangedItems.Add(nameof(Tenderizing_Damage_Multiplier_Switch_Axe));
                    OnPropertyChanged(nameof(Tenderizing_Damage_Multiplier_Switch_Axe));
                }
            }

            [DisplayName("Offset")]
            public long Tenderizing_Damage_Multiplier_Switch_Axe_offset { get; private set; }

            protected float Tenderizing_Damage_Multiplier_Charge_Blade_raw;
            public const string Tenderizing_Damage_Multiplier_Charge_Blade_displayName = "Tenderizing Damage % Multiplier: Charge Blade";
            public const int Tenderizing_Damage_Multiplier_Charge_Blade_sortIndex = 500;
            [SortOrder(Tenderizing_Damage_Multiplier_Charge_Blade_sortIndex)]
            [DisplayName(Tenderizing_Damage_Multiplier_Charge_Blade_displayName)]
            public virtual float Tenderizing_Damage_Multiplier_Charge_Blade {
                get => Tenderizing_Damage_Multiplier_Charge_Blade_raw;
                set {
                    if (Tenderizing_Damage_Multiplier_Charge_Blade_raw == value) return;
                    Tenderizing_Damage_Multiplier_Charge_Blade_raw = value;
                    ChangedItems.Add(nameof(Tenderizing_Damage_Multiplier_Charge_Blade));
                    OnPropertyChanged(nameof(Tenderizing_Damage_Multiplier_Charge_Blade));
                }
            }

            [DisplayName("Offset")]
            public long Tenderizing_Damage_Multiplier_Charge_Blade_offset { get; private set; }

            protected float Tenderizing_Damage_Multiplier_Insect_Glaive_raw;
            public const string Tenderizing_Damage_Multiplier_Insect_Glaive_displayName = "Tenderizing Damage % Multiplier: Insect Glaive";
            public const int Tenderizing_Damage_Multiplier_Insect_Glaive_sortIndex = 550;
            [SortOrder(Tenderizing_Damage_Multiplier_Insect_Glaive_sortIndex)]
            [DisplayName(Tenderizing_Damage_Multiplier_Insect_Glaive_displayName)]
            public virtual float Tenderizing_Damage_Multiplier_Insect_Glaive {
                get => Tenderizing_Damage_Multiplier_Insect_Glaive_raw;
                set {
                    if (Tenderizing_Damage_Multiplier_Insect_Glaive_raw == value) return;
                    Tenderizing_Damage_Multiplier_Insect_Glaive_raw = value;
                    ChangedItems.Add(nameof(Tenderizing_Damage_Multiplier_Insect_Glaive));
                    OnPropertyChanged(nameof(Tenderizing_Damage_Multiplier_Insect_Glaive));
                }
            }

            [DisplayName("Offset")]
            public long Tenderizing_Damage_Multiplier_Insect_Glaive_offset { get; private set; }

            protected float Tenderizing_Damage_Multiplier_Bow_raw;
            public const string Tenderizing_Damage_Multiplier_Bow_displayName = "Tenderizing Damage % Multiplier: Bow";
            public const int Tenderizing_Damage_Multiplier_Bow_sortIndex = 600;
            [SortOrder(Tenderizing_Damage_Multiplier_Bow_sortIndex)]
            [DisplayName(Tenderizing_Damage_Multiplier_Bow_displayName)]
            public virtual float Tenderizing_Damage_Multiplier_Bow {
                get => Tenderizing_Damage_Multiplier_Bow_raw;
                set {
                    if (Tenderizing_Damage_Multiplier_Bow_raw == value) return;
                    Tenderizing_Damage_Multiplier_Bow_raw = value;
                    ChangedItems.Add(nameof(Tenderizing_Damage_Multiplier_Bow));
                    OnPropertyChanged(nameof(Tenderizing_Damage_Multiplier_Bow));
                }
            }

            [DisplayName("Offset")]
            public long Tenderizing_Damage_Multiplier_Bow_offset { get; private set; }

            protected float Tenderizing_Damage_Multiplier_HBG_raw;
            public const string Tenderizing_Damage_Multiplier_HBG_displayName = "Tenderizing Damage % Multiplier: HBG";
            public const int Tenderizing_Damage_Multiplier_HBG_sortIndex = 650;
            [SortOrder(Tenderizing_Damage_Multiplier_HBG_sortIndex)]
            [DisplayName(Tenderizing_Damage_Multiplier_HBG_displayName)]
            public virtual float Tenderizing_Damage_Multiplier_HBG {
                get => Tenderizing_Damage_Multiplier_HBG_raw;
                set {
                    if (Tenderizing_Damage_Multiplier_HBG_raw == value) return;
                    Tenderizing_Damage_Multiplier_HBG_raw = value;
                    ChangedItems.Add(nameof(Tenderizing_Damage_Multiplier_HBG));
                    OnPropertyChanged(nameof(Tenderizing_Damage_Multiplier_HBG));
                }
            }

            [DisplayName("Offset")]
            public long Tenderizing_Damage_Multiplier_HBG_offset { get; private set; }

            protected float Tenderizing_Damage_Multiplier_LBG_raw;
            public const string Tenderizing_Damage_Multiplier_LBG_displayName = "Tenderizing Damage % Multiplier: LBG";
            public const int Tenderizing_Damage_Multiplier_LBG_sortIndex = 700;
            [SortOrder(Tenderizing_Damage_Multiplier_LBG_sortIndex)]
            [DisplayName(Tenderizing_Damage_Multiplier_LBG_displayName)]
            public virtual float Tenderizing_Damage_Multiplier_LBG {
                get => Tenderizing_Damage_Multiplier_LBG_raw;
                set {
                    if (Tenderizing_Damage_Multiplier_LBG_raw == value) return;
                    Tenderizing_Damage_Multiplier_LBG_raw = value;
                    ChangedItems.Add(nameof(Tenderizing_Damage_Multiplier_LBG));
                    OnPropertyChanged(nameof(Tenderizing_Damage_Multiplier_LBG));
                }
            }

            [DisplayName("Offset")]
            public long Tenderizing_Damage_Multiplier_LBG_offset { get; private set; }

            public const int lastSortIndex = 750;

            public static ObservableMhwStructCollection<Clutch_Claw_Boost> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Clutch_Claw_Boost>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Clutch_Claw_Boost LoadData(BinaryReader reader, ulong i) {
                var data = new Clutch_Claw_Boost();
                data.Index = i;
                data.Tenderizing_Damage_Multiplier_Great_Sword_offset = reader.BaseStream.Position;
                data.Tenderizing_Damage_Multiplier_Great_Sword_raw = reader.ReadSingle();
                data.Tenderizing_Damage_Multiplier_Sword_Shield_offset = reader.BaseStream.Position;
                data.Tenderizing_Damage_Multiplier_Sword_Shield_raw = reader.ReadSingle();
                data.Tenderizing_Damage_Multiplier_Dual_Blades_offset = reader.BaseStream.Position;
                data.Tenderizing_Damage_Multiplier_Dual_Blades_raw = reader.ReadSingle();
                data.Tenderizing_Damage_Multiplier_Long_Sword_offset = reader.BaseStream.Position;
                data.Tenderizing_Damage_Multiplier_Long_Sword_raw = reader.ReadSingle();
                data.Tenderizing_Damage_Multiplier_Hammer_offset = reader.BaseStream.Position;
                data.Tenderizing_Damage_Multiplier_Hammer_raw = reader.ReadSingle();
                data.Tenderizing_Damage_Multiplier_Hunting_Horn_offset = reader.BaseStream.Position;
                data.Tenderizing_Damage_Multiplier_Hunting_Horn_raw = reader.ReadSingle();
                data.Tenderizing_Damage_Multiplier_Lance_offset = reader.BaseStream.Position;
                data.Tenderizing_Damage_Multiplier_Lance_raw = reader.ReadSingle();
                data.Tenderizing_Damage_Multiplier_Gunlance_offset = reader.BaseStream.Position;
                data.Tenderizing_Damage_Multiplier_Gunlance_raw = reader.ReadSingle();
                data.Tenderizing_Damage_Multiplier_Switch_Axe_offset = reader.BaseStream.Position;
                data.Tenderizing_Damage_Multiplier_Switch_Axe_raw = reader.ReadSingle();
                data.Tenderizing_Damage_Multiplier_Charge_Blade_offset = reader.BaseStream.Position;
                data.Tenderizing_Damage_Multiplier_Charge_Blade_raw = reader.ReadSingle();
                data.Tenderizing_Damage_Multiplier_Insect_Glaive_offset = reader.BaseStream.Position;
                data.Tenderizing_Damage_Multiplier_Insect_Glaive_raw = reader.ReadSingle();
                data.Tenderizing_Damage_Multiplier_Bow_offset = reader.BaseStream.Position;
                data.Tenderizing_Damage_Multiplier_Bow_raw = reader.ReadSingle();
                data.Tenderizing_Damage_Multiplier_HBG_offset = reader.BaseStream.Position;
                data.Tenderizing_Damage_Multiplier_HBG_raw = reader.ReadSingle();
                data.Tenderizing_Damage_Multiplier_LBG_offset = reader.BaseStream.Position;
                data.Tenderizing_Damage_Multiplier_LBG_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Tenderizing_Damage_Multiplier_Great_Sword_raw);
                writer.Write(Tenderizing_Damage_Multiplier_Sword_Shield_raw);
                writer.Write(Tenderizing_Damage_Multiplier_Dual_Blades_raw);
                writer.Write(Tenderizing_Damage_Multiplier_Long_Sword_raw);
                writer.Write(Tenderizing_Damage_Multiplier_Hammer_raw);
                writer.Write(Tenderizing_Damage_Multiplier_Hunting_Horn_raw);
                writer.Write(Tenderizing_Damage_Multiplier_Lance_raw);
                writer.Write(Tenderizing_Damage_Multiplier_Gunlance_raw);
                writer.Write(Tenderizing_Damage_Multiplier_Switch_Axe_raw);
                writer.Write(Tenderizing_Damage_Multiplier_Charge_Blade_raw);
                writer.Write(Tenderizing_Damage_Multiplier_Insect_Glaive_raw);
                writer.Write(Tenderizing_Damage_Multiplier_Bow_raw);
                writer.Write(Tenderizing_Damage_Multiplier_HBG_raw);
                writer.Write(Tenderizing_Damage_Multiplier_LBG_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Tenderizing Damage % Multiplier: Great Sword", "Tenderizing_Damage_Multiplier_Great_Sword", "Tenderizing_Damage_Multiplier_Great_Sword_offset"),
                    new MultiStructItemCustomView(this, "Tenderizing Damage % Multiplier: Sword & Shield", "Tenderizing_Damage_Multiplier_Sword_Shield", "Tenderizing_Damage_Multiplier_Sword_Shield_offset"),
                    new MultiStructItemCustomView(this, "Tenderizing Damage % Multiplier: Dual Blades", "Tenderizing_Damage_Multiplier_Dual_Blades", "Tenderizing_Damage_Multiplier_Dual_Blades_offset"),
                    new MultiStructItemCustomView(this, "Tenderizing Damage % Multiplier: Long Sword", "Tenderizing_Damage_Multiplier_Long_Sword", "Tenderizing_Damage_Multiplier_Long_Sword_offset"),
                    new MultiStructItemCustomView(this, "Tenderizing Damage % Multiplier: Hammer", "Tenderizing_Damage_Multiplier_Hammer", "Tenderizing_Damage_Multiplier_Hammer_offset"),
                    new MultiStructItemCustomView(this, "Tenderizing Damage % Multiplier: Hunting Horn", "Tenderizing_Damage_Multiplier_Hunting_Horn", "Tenderizing_Damage_Multiplier_Hunting_Horn_offset"),
                    new MultiStructItemCustomView(this, "Tenderizing Damage % Multiplier: Lance", "Tenderizing_Damage_Multiplier_Lance", "Tenderizing_Damage_Multiplier_Lance_offset"),
                    new MultiStructItemCustomView(this, "Tenderizing Damage % Multiplier: Gunlance", "Tenderizing_Damage_Multiplier_Gunlance", "Tenderizing_Damage_Multiplier_Gunlance_offset"),
                    new MultiStructItemCustomView(this, "Tenderizing Damage % Multiplier: Switch Axe", "Tenderizing_Damage_Multiplier_Switch_Axe", "Tenderizing_Damage_Multiplier_Switch_Axe_offset"),
                    new MultiStructItemCustomView(this, "Tenderizing Damage % Multiplier: Charge Blade", "Tenderizing_Damage_Multiplier_Charge_Blade", "Tenderizing_Damage_Multiplier_Charge_Blade_offset"),
                    new MultiStructItemCustomView(this, "Tenderizing Damage % Multiplier: Insect Glaive", "Tenderizing_Damage_Multiplier_Insect_Glaive", "Tenderizing_Damage_Multiplier_Insect_Glaive_offset"),
                    new MultiStructItemCustomView(this, "Tenderizing Damage % Multiplier: Bow", "Tenderizing_Damage_Multiplier_Bow", "Tenderizing_Damage_Multiplier_Bow_offset"),
                    new MultiStructItemCustomView(this, "Tenderizing Damage % Multiplier: HBG", "Tenderizing_Damage_Multiplier_HBG", "Tenderizing_Damage_Multiplier_HBG_offset"),
                    new MultiStructItemCustomView(this, "Tenderizing Damage % Multiplier: LBG", "Tenderizing_Damage_Multiplier_LBG", "Tenderizing_Damage_Multiplier_LBG_offset"),
                };
            }
        }

        public partial class Food_Effects : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Food Effects";

            protected ushort Food_Effect_Life_Up_1_raw;
            public const string Food_Effect_Life_Up_1_displayName = "Food Effect: Life Up 1";
            public const int Food_Effect_Life_Up_1_sortIndex = 50;
            [SortOrder(Food_Effect_Life_Up_1_sortIndex)]
            [DisplayName(Food_Effect_Life_Up_1_displayName)]
            public virtual ushort Food_Effect_Life_Up_1 {
                get => Food_Effect_Life_Up_1_raw;
                set {
                    if (Food_Effect_Life_Up_1_raw == value) return;
                    Food_Effect_Life_Up_1_raw = value;
                    ChangedItems.Add(nameof(Food_Effect_Life_Up_1));
                    OnPropertyChanged(nameof(Food_Effect_Life_Up_1));
                }
            }

            [DisplayName("Offset")]
            public long Food_Effect_Life_Up_1_offset { get; private set; }

            protected ushort Food_Effect_Life_Up_2_raw;
            public const string Food_Effect_Life_Up_2_displayName = "Food Effect: Life Up 2";
            public const int Food_Effect_Life_Up_2_sortIndex = 100;
            [SortOrder(Food_Effect_Life_Up_2_sortIndex)]
            [DisplayName(Food_Effect_Life_Up_2_displayName)]
            public virtual ushort Food_Effect_Life_Up_2 {
                get => Food_Effect_Life_Up_2_raw;
                set {
                    if (Food_Effect_Life_Up_2_raw == value) return;
                    Food_Effect_Life_Up_2_raw = value;
                    ChangedItems.Add(nameof(Food_Effect_Life_Up_2));
                    OnPropertyChanged(nameof(Food_Effect_Life_Up_2));
                }
            }

            [DisplayName("Offset")]
            public long Food_Effect_Life_Up_2_offset { get; private set; }

            protected ushort Food_Effect_Life_Up_3_raw;
            public const string Food_Effect_Life_Up_3_displayName = "Food Effect: Life Up 3";
            public const int Food_Effect_Life_Up_3_sortIndex = 150;
            [SortOrder(Food_Effect_Life_Up_3_sortIndex)]
            [DisplayName(Food_Effect_Life_Up_3_displayName)]
            public virtual ushort Food_Effect_Life_Up_3 {
                get => Food_Effect_Life_Up_3_raw;
                set {
                    if (Food_Effect_Life_Up_3_raw == value) return;
                    Food_Effect_Life_Up_3_raw = value;
                    ChangedItems.Add(nameof(Food_Effect_Life_Up_3));
                    OnPropertyChanged(nameof(Food_Effect_Life_Up_3));
                }
            }

            [DisplayName("Offset")]
            public long Food_Effect_Life_Up_3_offset { get; private set; }

            protected ushort Food_Effect_Life_Up_4_raw;
            public const string Food_Effect_Life_Up_4_displayName = "Food Effect: Life Up 4";
            public const int Food_Effect_Life_Up_4_sortIndex = 200;
            [SortOrder(Food_Effect_Life_Up_4_sortIndex)]
            [DisplayName(Food_Effect_Life_Up_4_displayName)]
            public virtual ushort Food_Effect_Life_Up_4 {
                get => Food_Effect_Life_Up_4_raw;
                set {
                    if (Food_Effect_Life_Up_4_raw == value) return;
                    Food_Effect_Life_Up_4_raw = value;
                    ChangedItems.Add(nameof(Food_Effect_Life_Up_4));
                    OnPropertyChanged(nameof(Food_Effect_Life_Up_4));
                }
            }

            [DisplayName("Offset")]
            public long Food_Effect_Life_Up_4_offset { get; private set; }

            protected ushort Food_Effect_Life_Up_5_raw;
            public const string Food_Effect_Life_Up_5_displayName = "Food Effect: Life Up 5";
            public const int Food_Effect_Life_Up_5_sortIndex = 250;
            [SortOrder(Food_Effect_Life_Up_5_sortIndex)]
            [DisplayName(Food_Effect_Life_Up_5_displayName)]
            public virtual ushort Food_Effect_Life_Up_5 {
                get => Food_Effect_Life_Up_5_raw;
                set {
                    if (Food_Effect_Life_Up_5_raw == value) return;
                    Food_Effect_Life_Up_5_raw = value;
                    ChangedItems.Add(nameof(Food_Effect_Life_Up_5));
                    OnPropertyChanged(nameof(Food_Effect_Life_Up_5));
                }
            }

            [DisplayName("Offset")]
            public long Food_Effect_Life_Up_5_offset { get; private set; }

            protected ushort Food_Effect_Life_Up_6_raw;
            public const string Food_Effect_Life_Up_6_displayName = "Food Effect: Life Up 6";
            public const int Food_Effect_Life_Up_6_sortIndex = 300;
            [SortOrder(Food_Effect_Life_Up_6_sortIndex)]
            [DisplayName(Food_Effect_Life_Up_6_displayName)]
            public virtual ushort Food_Effect_Life_Up_6 {
                get => Food_Effect_Life_Up_6_raw;
                set {
                    if (Food_Effect_Life_Up_6_raw == value) return;
                    Food_Effect_Life_Up_6_raw = value;
                    ChangedItems.Add(nameof(Food_Effect_Life_Up_6));
                    OnPropertyChanged(nameof(Food_Effect_Life_Up_6));
                }
            }

            [DisplayName("Offset")]
            public long Food_Effect_Life_Up_6_offset { get; private set; }

            protected ushort Food_Effect_Stamina_Up_1_raw;
            public const string Food_Effect_Stamina_Up_1_displayName = "Food Effect: Stamina Up 1";
            public const int Food_Effect_Stamina_Up_1_sortIndex = 350;
            [SortOrder(Food_Effect_Stamina_Up_1_sortIndex)]
            [DisplayName(Food_Effect_Stamina_Up_1_displayName)]
            public virtual ushort Food_Effect_Stamina_Up_1 {
                get => Food_Effect_Stamina_Up_1_raw;
                set {
                    if (Food_Effect_Stamina_Up_1_raw == value) return;
                    Food_Effect_Stamina_Up_1_raw = value;
                    ChangedItems.Add(nameof(Food_Effect_Stamina_Up_1));
                    OnPropertyChanged(nameof(Food_Effect_Stamina_Up_1));
                }
            }

            [DisplayName("Offset")]
            public long Food_Effect_Stamina_Up_1_offset { get; private set; }

            protected ushort Food_Effect_Stamina_Up_2_raw;
            public const string Food_Effect_Stamina_Up_2_displayName = "Food Effect: Stamina Up 2";
            public const int Food_Effect_Stamina_Up_2_sortIndex = 400;
            [SortOrder(Food_Effect_Stamina_Up_2_sortIndex)]
            [DisplayName(Food_Effect_Stamina_Up_2_displayName)]
            public virtual ushort Food_Effect_Stamina_Up_2 {
                get => Food_Effect_Stamina_Up_2_raw;
                set {
                    if (Food_Effect_Stamina_Up_2_raw == value) return;
                    Food_Effect_Stamina_Up_2_raw = value;
                    ChangedItems.Add(nameof(Food_Effect_Stamina_Up_2));
                    OnPropertyChanged(nameof(Food_Effect_Stamina_Up_2));
                }
            }

            [DisplayName("Offset")]
            public long Food_Effect_Stamina_Up_2_offset { get; private set; }

            protected ushort Food_Effect_Stamina_Up_3_raw;
            public const string Food_Effect_Stamina_Up_3_displayName = "Food Effect: Stamina Up 3";
            public const int Food_Effect_Stamina_Up_3_sortIndex = 450;
            [SortOrder(Food_Effect_Stamina_Up_3_sortIndex)]
            [DisplayName(Food_Effect_Stamina_Up_3_displayName)]
            public virtual ushort Food_Effect_Stamina_Up_3 {
                get => Food_Effect_Stamina_Up_3_raw;
                set {
                    if (Food_Effect_Stamina_Up_3_raw == value) return;
                    Food_Effect_Stamina_Up_3_raw = value;
                    ChangedItems.Add(nameof(Food_Effect_Stamina_Up_3));
                    OnPropertyChanged(nameof(Food_Effect_Stamina_Up_3));
                }
            }

            [DisplayName("Offset")]
            public long Food_Effect_Stamina_Up_3_offset { get; private set; }

            protected ushort Food_Effect_Attack_Up_1_raw;
            public const string Food_Effect_Attack_Up_1_displayName = "Food Effect: Attack Up 1";
            public const int Food_Effect_Attack_Up_1_sortIndex = 500;
            [SortOrder(Food_Effect_Attack_Up_1_sortIndex)]
            [DisplayName(Food_Effect_Attack_Up_1_displayName)]
            public virtual ushort Food_Effect_Attack_Up_1 {
                get => Food_Effect_Attack_Up_1_raw;
                set {
                    if (Food_Effect_Attack_Up_1_raw == value) return;
                    Food_Effect_Attack_Up_1_raw = value;
                    ChangedItems.Add(nameof(Food_Effect_Attack_Up_1));
                    OnPropertyChanged(nameof(Food_Effect_Attack_Up_1));
                }
            }

            [DisplayName("Offset")]
            public long Food_Effect_Attack_Up_1_offset { get; private set; }

            protected ushort Food_Effect_Attack_Up_2_raw;
            public const string Food_Effect_Attack_Up_2_displayName = "Food Effect: Attack Up 2";
            public const int Food_Effect_Attack_Up_2_sortIndex = 550;
            [SortOrder(Food_Effect_Attack_Up_2_sortIndex)]
            [DisplayName(Food_Effect_Attack_Up_2_displayName)]
            public virtual ushort Food_Effect_Attack_Up_2 {
                get => Food_Effect_Attack_Up_2_raw;
                set {
                    if (Food_Effect_Attack_Up_2_raw == value) return;
                    Food_Effect_Attack_Up_2_raw = value;
                    ChangedItems.Add(nameof(Food_Effect_Attack_Up_2));
                    OnPropertyChanged(nameof(Food_Effect_Attack_Up_2));
                }
            }

            [DisplayName("Offset")]
            public long Food_Effect_Attack_Up_2_offset { get; private set; }

            protected ushort Food_Effect_Attack_Up_3_raw;
            public const string Food_Effect_Attack_Up_3_displayName = "Food Effect: Attack Up 3";
            public const int Food_Effect_Attack_Up_3_sortIndex = 600;
            [SortOrder(Food_Effect_Attack_Up_3_sortIndex)]
            [DisplayName(Food_Effect_Attack_Up_3_displayName)]
            public virtual ushort Food_Effect_Attack_Up_3 {
                get => Food_Effect_Attack_Up_3_raw;
                set {
                    if (Food_Effect_Attack_Up_3_raw == value) return;
                    Food_Effect_Attack_Up_3_raw = value;
                    ChangedItems.Add(nameof(Food_Effect_Attack_Up_3));
                    OnPropertyChanged(nameof(Food_Effect_Attack_Up_3));
                }
            }

            [DisplayName("Offset")]
            public long Food_Effect_Attack_Up_3_offset { get; private set; }

            protected ushort Food_Effect_Attack_Up_4_raw;
            public const string Food_Effect_Attack_Up_4_displayName = "Food Effect: Attack Up 4";
            public const int Food_Effect_Attack_Up_4_sortIndex = 650;
            [SortOrder(Food_Effect_Attack_Up_4_sortIndex)]
            [DisplayName(Food_Effect_Attack_Up_4_displayName)]
            public virtual ushort Food_Effect_Attack_Up_4 {
                get => Food_Effect_Attack_Up_4_raw;
                set {
                    if (Food_Effect_Attack_Up_4_raw == value) return;
                    Food_Effect_Attack_Up_4_raw = value;
                    ChangedItems.Add(nameof(Food_Effect_Attack_Up_4));
                    OnPropertyChanged(nameof(Food_Effect_Attack_Up_4));
                }
            }

            [DisplayName("Offset")]
            public long Food_Effect_Attack_Up_4_offset { get; private set; }

            protected ushort Food_Effect_Defense_Up_1_raw;
            public const string Food_Effect_Defense_Up_1_displayName = "Food Effect: Defense Up 1";
            public const int Food_Effect_Defense_Up_1_sortIndex = 700;
            [SortOrder(Food_Effect_Defense_Up_1_sortIndex)]
            [DisplayName(Food_Effect_Defense_Up_1_displayName)]
            public virtual ushort Food_Effect_Defense_Up_1 {
                get => Food_Effect_Defense_Up_1_raw;
                set {
                    if (Food_Effect_Defense_Up_1_raw == value) return;
                    Food_Effect_Defense_Up_1_raw = value;
                    ChangedItems.Add(nameof(Food_Effect_Defense_Up_1));
                    OnPropertyChanged(nameof(Food_Effect_Defense_Up_1));
                }
            }

            [DisplayName("Offset")]
            public long Food_Effect_Defense_Up_1_offset { get; private set; }

            protected ushort Food_Effect_Defense_Up_2_raw;
            public const string Food_Effect_Defense_Up_2_displayName = "Food Effect: Defense Up 2";
            public const int Food_Effect_Defense_Up_2_sortIndex = 750;
            [SortOrder(Food_Effect_Defense_Up_2_sortIndex)]
            [DisplayName(Food_Effect_Defense_Up_2_displayName)]
            public virtual ushort Food_Effect_Defense_Up_2 {
                get => Food_Effect_Defense_Up_2_raw;
                set {
                    if (Food_Effect_Defense_Up_2_raw == value) return;
                    Food_Effect_Defense_Up_2_raw = value;
                    ChangedItems.Add(nameof(Food_Effect_Defense_Up_2));
                    OnPropertyChanged(nameof(Food_Effect_Defense_Up_2));
                }
            }

            [DisplayName("Offset")]
            public long Food_Effect_Defense_Up_2_offset { get; private set; }

            protected ushort Food_Effect_Defense_Up_3_raw;
            public const string Food_Effect_Defense_Up_3_displayName = "Food Effect: Defense Up 3";
            public const int Food_Effect_Defense_Up_3_sortIndex = 800;
            [SortOrder(Food_Effect_Defense_Up_3_sortIndex)]
            [DisplayName(Food_Effect_Defense_Up_3_displayName)]
            public virtual ushort Food_Effect_Defense_Up_3 {
                get => Food_Effect_Defense_Up_3_raw;
                set {
                    if (Food_Effect_Defense_Up_3_raw == value) return;
                    Food_Effect_Defense_Up_3_raw = value;
                    ChangedItems.Add(nameof(Food_Effect_Defense_Up_3));
                    OnPropertyChanged(nameof(Food_Effect_Defense_Up_3));
                }
            }

            [DisplayName("Offset")]
            public long Food_Effect_Defense_Up_3_offset { get; private set; }

            protected ushort Food_Effect_Defense_Up_4_raw;
            public const string Food_Effect_Defense_Up_4_displayName = "Food Effect: Defense Up 4";
            public const int Food_Effect_Defense_Up_4_sortIndex = 850;
            [SortOrder(Food_Effect_Defense_Up_4_sortIndex)]
            [DisplayName(Food_Effect_Defense_Up_4_displayName)]
            public virtual ushort Food_Effect_Defense_Up_4 {
                get => Food_Effect_Defense_Up_4_raw;
                set {
                    if (Food_Effect_Defense_Up_4_raw == value) return;
                    Food_Effect_Defense_Up_4_raw = value;
                    ChangedItems.Add(nameof(Food_Effect_Defense_Up_4));
                    OnPropertyChanged(nameof(Food_Effect_Defense_Up_4));
                }
            }

            [DisplayName("Offset")]
            public long Food_Effect_Defense_Up_4_offset { get; private set; }

            protected ushort Food_Effect_All_Resistances_Up_1_raw;
            public const string Food_Effect_All_Resistances_Up_1_displayName = "Food Effect: All Resistances Up 1";
            public const int Food_Effect_All_Resistances_Up_1_sortIndex = 900;
            [SortOrder(Food_Effect_All_Resistances_Up_1_sortIndex)]
            [DisplayName(Food_Effect_All_Resistances_Up_1_displayName)]
            public virtual ushort Food_Effect_All_Resistances_Up_1 {
                get => Food_Effect_All_Resistances_Up_1_raw;
                set {
                    if (Food_Effect_All_Resistances_Up_1_raw == value) return;
                    Food_Effect_All_Resistances_Up_1_raw = value;
                    ChangedItems.Add(nameof(Food_Effect_All_Resistances_Up_1));
                    OnPropertyChanged(nameof(Food_Effect_All_Resistances_Up_1));
                }
            }

            [DisplayName("Offset")]
            public long Food_Effect_All_Resistances_Up_1_offset { get; private set; }

            protected ushort Food_Effect_All_Resistances_Up_2_raw;
            public const string Food_Effect_All_Resistances_Up_2_displayName = "Food Effect: All Resistances Up 2";
            public const int Food_Effect_All_Resistances_Up_2_sortIndex = 950;
            [SortOrder(Food_Effect_All_Resistances_Up_2_sortIndex)]
            [DisplayName(Food_Effect_All_Resistances_Up_2_displayName)]
            public virtual ushort Food_Effect_All_Resistances_Up_2 {
                get => Food_Effect_All_Resistances_Up_2_raw;
                set {
                    if (Food_Effect_All_Resistances_Up_2_raw == value) return;
                    Food_Effect_All_Resistances_Up_2_raw = value;
                    ChangedItems.Add(nameof(Food_Effect_All_Resistances_Up_2));
                    OnPropertyChanged(nameof(Food_Effect_All_Resistances_Up_2));
                }
            }

            [DisplayName("Offset")]
            public long Food_Effect_All_Resistances_Up_2_offset { get; private set; }

            protected ushort Food_Effect_All_Resistances_Up_3_raw;
            public const string Food_Effect_All_Resistances_Up_3_displayName = "Food Effect: All Resistances Up 3";
            public const int Food_Effect_All_Resistances_Up_3_sortIndex = 1000;
            [SortOrder(Food_Effect_All_Resistances_Up_3_sortIndex)]
            [DisplayName(Food_Effect_All_Resistances_Up_3_displayName)]
            public virtual ushort Food_Effect_All_Resistances_Up_3 {
                get => Food_Effect_All_Resistances_Up_3_raw;
                set {
                    if (Food_Effect_All_Resistances_Up_3_raw == value) return;
                    Food_Effect_All_Resistances_Up_3_raw = value;
                    ChangedItems.Add(nameof(Food_Effect_All_Resistances_Up_3));
                    OnPropertyChanged(nameof(Food_Effect_All_Resistances_Up_3));
                }
            }

            [DisplayName("Offset")]
            public long Food_Effect_All_Resistances_Up_3_offset { get; private set; }

            protected ushort Food_Effect_All_Resistances_Up_4_raw;
            public const string Food_Effect_All_Resistances_Up_4_displayName = "Food Effect: All Resistances Up 4";
            public const int Food_Effect_All_Resistances_Up_4_sortIndex = 1050;
            [SortOrder(Food_Effect_All_Resistances_Up_4_sortIndex)]
            [DisplayName(Food_Effect_All_Resistances_Up_4_displayName)]
            public virtual ushort Food_Effect_All_Resistances_Up_4 {
                get => Food_Effect_All_Resistances_Up_4_raw;
                set {
                    if (Food_Effect_All_Resistances_Up_4_raw == value) return;
                    Food_Effect_All_Resistances_Up_4_raw = value;
                    ChangedItems.Add(nameof(Food_Effect_All_Resistances_Up_4));
                    OnPropertyChanged(nameof(Food_Effect_All_Resistances_Up_4));
                }
            }

            [DisplayName("Offset")]
            public long Food_Effect_All_Resistances_Up_4_offset { get; private set; }

            public const int lastSortIndex = 1100;

            public static ObservableMhwStructCollection<Food_Effects> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Food_Effects>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Food_Effects LoadData(BinaryReader reader, ulong i) {
                var data = new Food_Effects();
                data.Index = i;
                data.Food_Effect_Life_Up_1_offset = reader.BaseStream.Position;
                data.Food_Effect_Life_Up_1_raw = reader.ReadUInt16();
                data.Food_Effect_Life_Up_2_offset = reader.BaseStream.Position;
                data.Food_Effect_Life_Up_2_raw = reader.ReadUInt16();
                data.Food_Effect_Life_Up_3_offset = reader.BaseStream.Position;
                data.Food_Effect_Life_Up_3_raw = reader.ReadUInt16();
                data.Food_Effect_Life_Up_4_offset = reader.BaseStream.Position;
                data.Food_Effect_Life_Up_4_raw = reader.ReadUInt16();
                data.Food_Effect_Life_Up_5_offset = reader.BaseStream.Position;
                data.Food_Effect_Life_Up_5_raw = reader.ReadUInt16();
                data.Food_Effect_Life_Up_6_offset = reader.BaseStream.Position;
                data.Food_Effect_Life_Up_6_raw = reader.ReadUInt16();
                data.Food_Effect_Stamina_Up_1_offset = reader.BaseStream.Position;
                data.Food_Effect_Stamina_Up_1_raw = reader.ReadUInt16();
                data.Food_Effect_Stamina_Up_2_offset = reader.BaseStream.Position;
                data.Food_Effect_Stamina_Up_2_raw = reader.ReadUInt16();
                data.Food_Effect_Stamina_Up_3_offset = reader.BaseStream.Position;
                data.Food_Effect_Stamina_Up_3_raw = reader.ReadUInt16();
                data.Food_Effect_Attack_Up_1_offset = reader.BaseStream.Position;
                data.Food_Effect_Attack_Up_1_raw = reader.ReadUInt16();
                data.Food_Effect_Attack_Up_2_offset = reader.BaseStream.Position;
                data.Food_Effect_Attack_Up_2_raw = reader.ReadUInt16();
                data.Food_Effect_Attack_Up_3_offset = reader.BaseStream.Position;
                data.Food_Effect_Attack_Up_3_raw = reader.ReadUInt16();
                data.Food_Effect_Attack_Up_4_offset = reader.BaseStream.Position;
                data.Food_Effect_Attack_Up_4_raw = reader.ReadUInt16();
                data.Food_Effect_Defense_Up_1_offset = reader.BaseStream.Position;
                data.Food_Effect_Defense_Up_1_raw = reader.ReadUInt16();
                data.Food_Effect_Defense_Up_2_offset = reader.BaseStream.Position;
                data.Food_Effect_Defense_Up_2_raw = reader.ReadUInt16();
                data.Food_Effect_Defense_Up_3_offset = reader.BaseStream.Position;
                data.Food_Effect_Defense_Up_3_raw = reader.ReadUInt16();
                data.Food_Effect_Defense_Up_4_offset = reader.BaseStream.Position;
                data.Food_Effect_Defense_Up_4_raw = reader.ReadUInt16();
                data.Food_Effect_All_Resistances_Up_1_offset = reader.BaseStream.Position;
                data.Food_Effect_All_Resistances_Up_1_raw = reader.ReadUInt16();
                data.Food_Effect_All_Resistances_Up_2_offset = reader.BaseStream.Position;
                data.Food_Effect_All_Resistances_Up_2_raw = reader.ReadUInt16();
                data.Food_Effect_All_Resistances_Up_3_offset = reader.BaseStream.Position;
                data.Food_Effect_All_Resistances_Up_3_raw = reader.ReadUInt16();
                data.Food_Effect_All_Resistances_Up_4_offset = reader.BaseStream.Position;
                data.Food_Effect_All_Resistances_Up_4_raw = reader.ReadUInt16();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Food_Effect_Life_Up_1_raw);
                writer.Write(Food_Effect_Life_Up_2_raw);
                writer.Write(Food_Effect_Life_Up_3_raw);
                writer.Write(Food_Effect_Life_Up_4_raw);
                writer.Write(Food_Effect_Life_Up_5_raw);
                writer.Write(Food_Effect_Life_Up_6_raw);
                writer.Write(Food_Effect_Stamina_Up_1_raw);
                writer.Write(Food_Effect_Stamina_Up_2_raw);
                writer.Write(Food_Effect_Stamina_Up_3_raw);
                writer.Write(Food_Effect_Attack_Up_1_raw);
                writer.Write(Food_Effect_Attack_Up_2_raw);
                writer.Write(Food_Effect_Attack_Up_3_raw);
                writer.Write(Food_Effect_Attack_Up_4_raw);
                writer.Write(Food_Effect_Defense_Up_1_raw);
                writer.Write(Food_Effect_Defense_Up_2_raw);
                writer.Write(Food_Effect_Defense_Up_3_raw);
                writer.Write(Food_Effect_Defense_Up_4_raw);
                writer.Write(Food_Effect_All_Resistances_Up_1_raw);
                writer.Write(Food_Effect_All_Resistances_Up_2_raw);
                writer.Write(Food_Effect_All_Resistances_Up_3_raw);
                writer.Write(Food_Effect_All_Resistances_Up_4_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Food Effect: Life Up 1", "Food_Effect_Life_Up_1", "Food_Effect_Life_Up_1_offset"),
                    new MultiStructItemCustomView(this, "Food Effect: Life Up 2", "Food_Effect_Life_Up_2", "Food_Effect_Life_Up_2_offset"),
                    new MultiStructItemCustomView(this, "Food Effect: Life Up 3", "Food_Effect_Life_Up_3", "Food_Effect_Life_Up_3_offset"),
                    new MultiStructItemCustomView(this, "Food Effect: Life Up 4", "Food_Effect_Life_Up_4", "Food_Effect_Life_Up_4_offset"),
                    new MultiStructItemCustomView(this, "Food Effect: Life Up 5", "Food_Effect_Life_Up_5", "Food_Effect_Life_Up_5_offset"),
                    new MultiStructItemCustomView(this, "Food Effect: Life Up 6", "Food_Effect_Life_Up_6", "Food_Effect_Life_Up_6_offset"),
                    new MultiStructItemCustomView(this, "Food Effect: Stamina Up 1", "Food_Effect_Stamina_Up_1", "Food_Effect_Stamina_Up_1_offset"),
                    new MultiStructItemCustomView(this, "Food Effect: Stamina Up 2", "Food_Effect_Stamina_Up_2", "Food_Effect_Stamina_Up_2_offset"),
                    new MultiStructItemCustomView(this, "Food Effect: Stamina Up 3", "Food_Effect_Stamina_Up_3", "Food_Effect_Stamina_Up_3_offset"),
                    new MultiStructItemCustomView(this, "Food Effect: Attack Up 1", "Food_Effect_Attack_Up_1", "Food_Effect_Attack_Up_1_offset"),
                    new MultiStructItemCustomView(this, "Food Effect: Attack Up 2", "Food_Effect_Attack_Up_2", "Food_Effect_Attack_Up_2_offset"),
                    new MultiStructItemCustomView(this, "Food Effect: Attack Up 3", "Food_Effect_Attack_Up_3", "Food_Effect_Attack_Up_3_offset"),
                    new MultiStructItemCustomView(this, "Food Effect: Attack Up 4", "Food_Effect_Attack_Up_4", "Food_Effect_Attack_Up_4_offset"),
                    new MultiStructItemCustomView(this, "Food Effect: Defense Up 1", "Food_Effect_Defense_Up_1", "Food_Effect_Defense_Up_1_offset"),
                    new MultiStructItemCustomView(this, "Food Effect: Defense Up 2", "Food_Effect_Defense_Up_2", "Food_Effect_Defense_Up_2_offset"),
                    new MultiStructItemCustomView(this, "Food Effect: Defense Up 3", "Food_Effect_Defense_Up_3", "Food_Effect_Defense_Up_3_offset"),
                    new MultiStructItemCustomView(this, "Food Effect: Defense Up 4", "Food_Effect_Defense_Up_4", "Food_Effect_Defense_Up_4_offset"),
                    new MultiStructItemCustomView(this, "Food Effect: All Resistances Up 1", "Food_Effect_All_Resistances_Up_1", "Food_Effect_All_Resistances_Up_1_offset"),
                    new MultiStructItemCustomView(this, "Food Effect: All Resistances Up 2", "Food_Effect_All_Resistances_Up_2", "Food_Effect_All_Resistances_Up_2_offset"),
                    new MultiStructItemCustomView(this, "Food Effect: All Resistances Up 3", "Food_Effect_All_Resistances_Up_3", "Food_Effect_All_Resistances_Up_3_offset"),
                    new MultiStructItemCustomView(this, "Food Effect: All Resistances Up 4", "Food_Effect_All_Resistances_Up_4", "Food_Effect_All_Resistances_Up_4_offset"),
                };
            }
        }

        public partial class Feline_Skill : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Feline Skill";

            protected byte Feline_Polisher_1_raw;
            public const string Feline_Polisher_1_displayName = "Feline Polisher: % 1";
            public const int Feline_Polisher_1_sortIndex = 50;
            [SortOrder(Feline_Polisher_1_sortIndex)]
            [DisplayName(Feline_Polisher_1_displayName)]
            public virtual byte Feline_Polisher_1 {
                get => Feline_Polisher_1_raw;
                set {
                    if (Feline_Polisher_1_raw == value) return;
                    Feline_Polisher_1_raw = value;
                    ChangedItems.Add(nameof(Feline_Polisher_1));
                    OnPropertyChanged(nameof(Feline_Polisher_1));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Polisher_1_offset { get; private set; }

            protected byte Feline_Polisher_2_raw;
            public const string Feline_Polisher_2_displayName = "Feline Polisher: % 2";
            public const int Feline_Polisher_2_sortIndex = 100;
            [SortOrder(Feline_Polisher_2_sortIndex)]
            [DisplayName(Feline_Polisher_2_displayName)]
            public virtual byte Feline_Polisher_2 {
                get => Feline_Polisher_2_raw;
                set {
                    if (Feline_Polisher_2_raw == value) return;
                    Feline_Polisher_2_raw = value;
                    ChangedItems.Add(nameof(Feline_Polisher_2));
                    OnPropertyChanged(nameof(Feline_Polisher_2));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Polisher_2_offset { get; private set; }

            protected byte Feline_Polisher_3_raw;
            public const string Feline_Polisher_3_displayName = "Feline Polisher: % 3";
            public const int Feline_Polisher_3_sortIndex = 150;
            [SortOrder(Feline_Polisher_3_sortIndex)]
            [DisplayName(Feline_Polisher_3_displayName)]
            public virtual byte Feline_Polisher_3 {
                get => Feline_Polisher_3_raw;
                set {
                    if (Feline_Polisher_3_raw == value) return;
                    Feline_Polisher_3_raw = value;
                    ChangedItems.Add(nameof(Feline_Polisher_3));
                    OnPropertyChanged(nameof(Feline_Polisher_3));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Polisher_3_offset { get; private set; }

            protected byte Feline_Polisher_Loop_1_raw;
            public const string Feline_Polisher_Loop_1_displayName = "Feline Polisher: Loop # 1";
            public const int Feline_Polisher_Loop_1_sortIndex = 200;
            [SortOrder(Feline_Polisher_Loop_1_sortIndex)]
            [DisplayName(Feline_Polisher_Loop_1_displayName)]
            public virtual byte Feline_Polisher_Loop_1 {
                get => Feline_Polisher_Loop_1_raw;
                set {
                    if (Feline_Polisher_Loop_1_raw == value) return;
                    Feline_Polisher_Loop_1_raw = value;
                    ChangedItems.Add(nameof(Feline_Polisher_Loop_1));
                    OnPropertyChanged(nameof(Feline_Polisher_Loop_1));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Polisher_Loop_1_offset { get; private set; }

            protected byte Feline_Polisher_Loop_2_raw;
            public const string Feline_Polisher_Loop_2_displayName = "Feline Polisher: Loop # 2";
            public const int Feline_Polisher_Loop_2_sortIndex = 250;
            [SortOrder(Feline_Polisher_Loop_2_sortIndex)]
            [DisplayName(Feline_Polisher_Loop_2_displayName)]
            public virtual byte Feline_Polisher_Loop_2 {
                get => Feline_Polisher_Loop_2_raw;
                set {
                    if (Feline_Polisher_Loop_2_raw == value) return;
                    Feline_Polisher_Loop_2_raw = value;
                    ChangedItems.Add(nameof(Feline_Polisher_Loop_2));
                    OnPropertyChanged(nameof(Feline_Polisher_Loop_2));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Polisher_Loop_2_offset { get; private set; }

            protected byte Feline_Polisher_Loop_3_raw;
            public const string Feline_Polisher_Loop_3_displayName = "Feline Polisher: Loop # 3";
            public const int Feline_Polisher_Loop_3_sortIndex = 300;
            [SortOrder(Feline_Polisher_Loop_3_sortIndex)]
            [DisplayName(Feline_Polisher_Loop_3_displayName)]
            public virtual byte Feline_Polisher_Loop_3 {
                get => Feline_Polisher_Loop_3_raw;
                set {
                    if (Feline_Polisher_Loop_3_raw == value) return;
                    Feline_Polisher_Loop_3_raw = value;
                    ChangedItems.Add(nameof(Feline_Polisher_Loop_3));
                    OnPropertyChanged(nameof(Feline_Polisher_Loop_3));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Polisher_Loop_3_offset { get; private set; }

            protected float Feline_Rider_Attack_Rate_raw;
            public const string Feline_Rider_Attack_Rate_displayName = "Feline Rider: Attack Rate";
            public const int Feline_Rider_Attack_Rate_sortIndex = 350;
            [SortOrder(Feline_Rider_Attack_Rate_sortIndex)]
            [DisplayName(Feline_Rider_Attack_Rate_displayName)]
            public virtual float Feline_Rider_Attack_Rate {
                get => Feline_Rider_Attack_Rate_raw;
                set {
                    if (Feline_Rider_Attack_Rate_raw == value) return;
                    Feline_Rider_Attack_Rate_raw = value;
                    ChangedItems.Add(nameof(Feline_Rider_Attack_Rate));
                    OnPropertyChanged(nameof(Feline_Rider_Attack_Rate));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Rider_Attack_Rate_offset { get; private set; }

            protected float Feline_Heroics_Attack_Rate_raw;
            public const string Feline_Heroics_Attack_Rate_displayName = "Feline Heroics: Attack Rate";
            public const int Feline_Heroics_Attack_Rate_sortIndex = 400;
            [SortOrder(Feline_Heroics_Attack_Rate_sortIndex)]
            [DisplayName(Feline_Heroics_Attack_Rate_displayName)]
            public virtual float Feline_Heroics_Attack_Rate {
                get => Feline_Heroics_Attack_Rate_raw;
                set {
                    if (Feline_Heroics_Attack_Rate_raw == value) return;
                    Feline_Heroics_Attack_Rate_raw = value;
                    ChangedItems.Add(nameof(Feline_Heroics_Attack_Rate));
                    OnPropertyChanged(nameof(Feline_Heroics_Attack_Rate));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Heroics_Attack_Rate_offset { get; private set; }

            protected float Feline_Heroics_Defense_Rate_raw;
            public const string Feline_Heroics_Defense_Rate_displayName = "Feline Heroics: Defense Rate";
            public const int Feline_Heroics_Defense_Rate_sortIndex = 450;
            [SortOrder(Feline_Heroics_Defense_Rate_sortIndex)]
            [DisplayName(Feline_Heroics_Defense_Rate_displayName)]
            public virtual float Feline_Heroics_Defense_Rate {
                get => Feline_Heroics_Defense_Rate_raw;
                set {
                    if (Feline_Heroics_Defense_Rate_raw == value) return;
                    Feline_Heroics_Defense_Rate_raw = value;
                    ChangedItems.Add(nameof(Feline_Heroics_Defense_Rate));
                    OnPropertyChanged(nameof(Feline_Heroics_Defense_Rate));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Heroics_Defense_Rate_offset { get; private set; }

            protected byte Feline_Heroics_Life_Activation_Threshold_raw;
            public const string Feline_Heroics_Life_Activation_Threshold_displayName = "Feline Heroics: Life Activation Threshold";
            public const int Feline_Heroics_Life_Activation_Threshold_sortIndex = 500;
            [SortOrder(Feline_Heroics_Life_Activation_Threshold_sortIndex)]
            [DisplayName(Feline_Heroics_Life_Activation_Threshold_displayName)]
            public virtual byte Feline_Heroics_Life_Activation_Threshold {
                get => Feline_Heroics_Life_Activation_Threshold_raw;
                set {
                    if (Feline_Heroics_Life_Activation_Threshold_raw == value) return;
                    Feline_Heroics_Life_Activation_Threshold_raw = value;
                    ChangedItems.Add(nameof(Feline_Heroics_Life_Activation_Threshold));
                    OnPropertyChanged(nameof(Feline_Heroics_Life_Activation_Threshold));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Heroics_Life_Activation_Threshold_offset { get; private set; }

            protected byte Feline_Carving_L_Lottery_1_raw;
            public const string Feline_Carving_L_Lottery_1_displayName = "Feline Carving L: Lottery % 1";
            public const int Feline_Carving_L_Lottery_1_sortIndex = 550;
            [SortOrder(Feline_Carving_L_Lottery_1_sortIndex)]
            [DisplayName(Feline_Carving_L_Lottery_1_displayName)]
            public virtual byte Feline_Carving_L_Lottery_1 {
                get => Feline_Carving_L_Lottery_1_raw;
                set {
                    if (Feline_Carving_L_Lottery_1_raw == value) return;
                    Feline_Carving_L_Lottery_1_raw = value;
                    ChangedItems.Add(nameof(Feline_Carving_L_Lottery_1));
                    OnPropertyChanged(nameof(Feline_Carving_L_Lottery_1));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Carving_L_Lottery_1_offset { get; private set; }

            protected byte Feline_Carving_L_Lottery_2_raw;
            public const string Feline_Carving_L_Lottery_2_displayName = "Feline Carving L: Lottery % 2";
            public const int Feline_Carving_L_Lottery_2_sortIndex = 600;
            [SortOrder(Feline_Carving_L_Lottery_2_sortIndex)]
            [DisplayName(Feline_Carving_L_Lottery_2_displayName)]
            public virtual byte Feline_Carving_L_Lottery_2 {
                get => Feline_Carving_L_Lottery_2_raw;
                set {
                    if (Feline_Carving_L_Lottery_2_raw == value) return;
                    Feline_Carving_L_Lottery_2_raw = value;
                    ChangedItems.Add(nameof(Feline_Carving_L_Lottery_2));
                    OnPropertyChanged(nameof(Feline_Carving_L_Lottery_2));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Carving_L_Lottery_2_offset { get; private set; }

            protected byte Feline_Carving_L_Lottery_3_raw;
            public const string Feline_Carving_L_Lottery_3_displayName = "Feline Carving L: Lottery % 3";
            public const int Feline_Carving_L_Lottery_3_sortIndex = 650;
            [SortOrder(Feline_Carving_L_Lottery_3_sortIndex)]
            [DisplayName(Feline_Carving_L_Lottery_3_displayName)]
            public virtual byte Feline_Carving_L_Lottery_3 {
                get => Feline_Carving_L_Lottery_3_raw;
                set {
                    if (Feline_Carving_L_Lottery_3_raw == value) return;
                    Feline_Carving_L_Lottery_3_raw = value;
                    ChangedItems.Add(nameof(Feline_Carving_L_Lottery_3));
                    OnPropertyChanged(nameof(Feline_Carving_L_Lottery_3));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Carving_L_Lottery_3_offset { get; private set; }

            protected byte Feline_Carving_L_Up_1_raw;
            public const string Feline_Carving_L_Up_1_displayName = "Feline Carving L: Up % 1";
            public const int Feline_Carving_L_Up_1_sortIndex = 700;
            [SortOrder(Feline_Carving_L_Up_1_sortIndex)]
            [DisplayName(Feline_Carving_L_Up_1_displayName)]
            public virtual byte Feline_Carving_L_Up_1 {
                get => Feline_Carving_L_Up_1_raw;
                set {
                    if (Feline_Carving_L_Up_1_raw == value) return;
                    Feline_Carving_L_Up_1_raw = value;
                    ChangedItems.Add(nameof(Feline_Carving_L_Up_1));
                    OnPropertyChanged(nameof(Feline_Carving_L_Up_1));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Carving_L_Up_1_offset { get; private set; }

            protected byte Feline_Carving_L_Up_2_raw;
            public const string Feline_Carving_L_Up_2_displayName = "Feline Carving L: Up % 2";
            public const int Feline_Carving_L_Up_2_sortIndex = 750;
            [SortOrder(Feline_Carving_L_Up_2_sortIndex)]
            [DisplayName(Feline_Carving_L_Up_2_displayName)]
            public virtual byte Feline_Carving_L_Up_2 {
                get => Feline_Carving_L_Up_2_raw;
                set {
                    if (Feline_Carving_L_Up_2_raw == value) return;
                    Feline_Carving_L_Up_2_raw = value;
                    ChangedItems.Add(nameof(Feline_Carving_L_Up_2));
                    OnPropertyChanged(nameof(Feline_Carving_L_Up_2));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Carving_L_Up_2_offset { get; private set; }

            protected byte Feline_Carving_L_Up_3_raw;
            public const string Feline_Carving_L_Up_3_displayName = "Feline Carving L: Up % 3";
            public const int Feline_Carving_L_Up_3_sortIndex = 800;
            [SortOrder(Feline_Carving_L_Up_3_sortIndex)]
            [DisplayName(Feline_Carving_L_Up_3_displayName)]
            public virtual byte Feline_Carving_L_Up_3 {
                get => Feline_Carving_L_Up_3_raw;
                set {
                    if (Feline_Carving_L_Up_3_raw == value) return;
                    Feline_Carving_L_Up_3_raw = value;
                    ChangedItems.Add(nameof(Feline_Carving_L_Up_3));
                    OnPropertyChanged(nameof(Feline_Carving_L_Up_3));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Carving_L_Up_3_offset { get; private set; }

            protected byte Feline_Carving_L_Up_4_raw;
            public const string Feline_Carving_L_Up_4_displayName = "Feline Carving L: Up % 4";
            public const int Feline_Carving_L_Up_4_sortIndex = 850;
            [SortOrder(Feline_Carving_L_Up_4_sortIndex)]
            [DisplayName(Feline_Carving_L_Up_4_displayName)]
            public virtual byte Feline_Carving_L_Up_4 {
                get => Feline_Carving_L_Up_4_raw;
                set {
                    if (Feline_Carving_L_Up_4_raw == value) return;
                    Feline_Carving_L_Up_4_raw = value;
                    ChangedItems.Add(nameof(Feline_Carving_L_Up_4));
                    OnPropertyChanged(nameof(Feline_Carving_L_Up_4));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Carving_L_Up_4_offset { get; private set; }

            protected byte Feline_Carving_S_Lottery__raw;
            public const string Feline_Carving_S_Lottery__displayName = "Feline Carving S: Lottery %";
            public const int Feline_Carving_S_Lottery__sortIndex = 900;
            [SortOrder(Feline_Carving_S_Lottery__sortIndex)]
            [DisplayName(Feline_Carving_S_Lottery__displayName)]
            public virtual byte Feline_Carving_S_Lottery_ {
                get => Feline_Carving_S_Lottery__raw;
                set {
                    if (Feline_Carving_S_Lottery__raw == value) return;
                    Feline_Carving_S_Lottery__raw = value;
                    ChangedItems.Add(nameof(Feline_Carving_S_Lottery_));
                    OnPropertyChanged(nameof(Feline_Carving_S_Lottery_));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Carving_S_Lottery__offset { get; private set; }

            protected byte Feline_Carving_S_Up__raw;
            public const string Feline_Carving_S_Up__displayName = "Feline Carving S: Up %";
            public const int Feline_Carving_S_Up__sortIndex = 950;
            [SortOrder(Feline_Carving_S_Up__sortIndex)]
            [DisplayName(Feline_Carving_S_Up__displayName)]
            public virtual byte Feline_Carving_S_Up_ {
                get => Feline_Carving_S_Up__raw;
                set {
                    if (Feline_Carving_S_Up__raw == value) return;
                    Feline_Carving_S_Up__raw = value;
                    ChangedItems.Add(nameof(Feline_Carving_S_Up_));
                    OnPropertyChanged(nameof(Feline_Carving_S_Up_));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Carving_S_Up__offset { get; private set; }

            protected float Feline_Medic_Heal_Rate_raw;
            public const string Feline_Medic_Heal_Rate_displayName = "Feline Medic: Heal Rate";
            public const int Feline_Medic_Heal_Rate_sortIndex = 1000;
            [SortOrder(Feline_Medic_Heal_Rate_sortIndex)]
            [DisplayName(Feline_Medic_Heal_Rate_displayName)]
            public virtual float Feline_Medic_Heal_Rate {
                get => Feline_Medic_Heal_Rate_raw;
                set {
                    if (Feline_Medic_Heal_Rate_raw == value) return;
                    Feline_Medic_Heal_Rate_raw = value;
                    ChangedItems.Add(nameof(Feline_Medic_Heal_Rate));
                    OnPropertyChanged(nameof(Feline_Medic_Heal_Rate));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Medic_Heal_Rate_offset { get; private set; }

            protected float Feline_Black_Belt_Stamina_Rate_raw;
            public const string Feline_Black_Belt_Stamina_Rate_displayName = "Feline Black Belt: Stamina Rate";
            public const int Feline_Black_Belt_Stamina_Rate_sortIndex = 1050;
            [SortOrder(Feline_Black_Belt_Stamina_Rate_sortIndex)]
            [DisplayName(Feline_Black_Belt_Stamina_Rate_displayName)]
            public virtual float Feline_Black_Belt_Stamina_Rate {
                get => Feline_Black_Belt_Stamina_Rate_raw;
                set {
                    if (Feline_Black_Belt_Stamina_Rate_raw == value) return;
                    Feline_Black_Belt_Stamina_Rate_raw = value;
                    ChangedItems.Add(nameof(Feline_Black_Belt_Stamina_Rate));
                    OnPropertyChanged(nameof(Feline_Black_Belt_Stamina_Rate));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Black_Belt_Stamina_Rate_offset { get; private set; }

            protected ushort Feline_Special_Attack_Condition_Attack_Bonus_raw;
            public const string Feline_Special_Attack_Condition_Attack_Bonus_displayName = "Feline Special Attack: Condition Attack Bonus";
            public const int Feline_Special_Attack_Condition_Attack_Bonus_sortIndex = 1100;
            [SortOrder(Feline_Special_Attack_Condition_Attack_Bonus_sortIndex)]
            [DisplayName(Feline_Special_Attack_Condition_Attack_Bonus_displayName)]
            public virtual ushort Feline_Special_Attack_Condition_Attack_Bonus {
                get => Feline_Special_Attack_Condition_Attack_Bonus_raw;
                set {
                    if (Feline_Special_Attack_Condition_Attack_Bonus_raw == value) return;
                    Feline_Special_Attack_Condition_Attack_Bonus_raw = value;
                    ChangedItems.Add(nameof(Feline_Special_Attack_Condition_Attack_Bonus));
                    OnPropertyChanged(nameof(Feline_Special_Attack_Condition_Attack_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Special_Attack_Condition_Attack_Bonus_offset { get; private set; }

            protected float Feline_Special_Attack_Capture_Attack_Rate_raw;
            public const string Feline_Special_Attack_Capture_Attack_Rate_displayName = "Feline Special Attack: Capture Attack Rate";
            public const int Feline_Special_Attack_Capture_Attack_Rate_sortIndex = 1150;
            [SortOrder(Feline_Special_Attack_Capture_Attack_Rate_sortIndex)]
            [DisplayName(Feline_Special_Attack_Capture_Attack_Rate_displayName)]
            public virtual float Feline_Special_Attack_Capture_Attack_Rate {
                get => Feline_Special_Attack_Capture_Attack_Rate_raw;
                set {
                    if (Feline_Special_Attack_Capture_Attack_Rate_raw == value) return;
                    Feline_Special_Attack_Capture_Attack_Rate_raw = value;
                    ChangedItems.Add(nameof(Feline_Special_Attack_Capture_Attack_Rate));
                    OnPropertyChanged(nameof(Feline_Special_Attack_Capture_Attack_Rate));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Special_Attack_Capture_Attack_Rate_offset { get; private set; }

            protected byte Feline_Defense_S__raw;
            public const string Feline_Defense_S__displayName = "Feline Defense S: %";
            public const int Feline_Defense_S__sortIndex = 1200;
            [SortOrder(Feline_Defense_S__sortIndex)]
            [DisplayName(Feline_Defense_S__displayName)]
            public virtual byte Feline_Defense_S_ {
                get => Feline_Defense_S__raw;
                set {
                    if (Feline_Defense_S__raw == value) return;
                    Feline_Defense_S__raw = value;
                    ChangedItems.Add(nameof(Feline_Defense_S_));
                    OnPropertyChanged(nameof(Feline_Defense_S_));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Defense_S__offset { get; private set; }

            protected byte Feline_Defense_L__raw;
            public const string Feline_Defense_L__displayName = "Feline Defense L: %";
            public const int Feline_Defense_L__sortIndex = 1250;
            [SortOrder(Feline_Defense_L__sortIndex)]
            [DisplayName(Feline_Defense_L__displayName)]
            public virtual byte Feline_Defense_L_ {
                get => Feline_Defense_L__raw;
                set {
                    if (Feline_Defense_L__raw == value) return;
                    Feline_Defense_L__raw = value;
                    ChangedItems.Add(nameof(Feline_Defense_L_));
                    OnPropertyChanged(nameof(Feline_Defense_L_));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Defense_L__offset { get; private set; }

            protected float Feline_Defense_S_Damage_Rate_raw;
            public const string Feline_Defense_S_Damage_Rate_displayName = "Feline Defense S: Damage Rate";
            public const int Feline_Defense_S_Damage_Rate_sortIndex = 1300;
            [SortOrder(Feline_Defense_S_Damage_Rate_sortIndex)]
            [DisplayName(Feline_Defense_S_Damage_Rate_displayName)]
            public virtual float Feline_Defense_S_Damage_Rate {
                get => Feline_Defense_S_Damage_Rate_raw;
                set {
                    if (Feline_Defense_S_Damage_Rate_raw == value) return;
                    Feline_Defense_S_Damage_Rate_raw = value;
                    ChangedItems.Add(nameof(Feline_Defense_S_Damage_Rate));
                    OnPropertyChanged(nameof(Feline_Defense_S_Damage_Rate));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Defense_S_Damage_Rate_offset { get; private set; }

            protected float Feline_Defense_L_Damage_Rate_raw;
            public const string Feline_Defense_L_Damage_Rate_displayName = "Feline Defense L: Damage Rate";
            public const int Feline_Defense_L_Damage_Rate_sortIndex = 1350;
            [SortOrder(Feline_Defense_L_Damage_Rate_sortIndex)]
            [DisplayName(Feline_Defense_L_Damage_Rate_displayName)]
            public virtual float Feline_Defense_L_Damage_Rate {
                get => Feline_Defense_L_Damage_Rate_raw;
                set {
                    if (Feline_Defense_L_Damage_Rate_raw == value) return;
                    Feline_Defense_L_Damage_Rate_raw = value;
                    ChangedItems.Add(nameof(Feline_Defense_L_Damage_Rate));
                    OnPropertyChanged(nameof(Feline_Defense_L_Damage_Rate));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Defense_L_Damage_Rate_offset { get; private set; }

            protected float Feline_Harvest_Cooldown_Multiplier_raw;
            public const string Feline_Harvest_Cooldown_Multiplier_displayName = "Feline Harvest: Cooldown Multiplier";
            public const int Feline_Harvest_Cooldown_Multiplier_sortIndex = 1400;
            [SortOrder(Feline_Harvest_Cooldown_Multiplier_sortIndex)]
            [DisplayName(Feline_Harvest_Cooldown_Multiplier_displayName)]
            public virtual float Feline_Harvest_Cooldown_Multiplier {
                get => Feline_Harvest_Cooldown_Multiplier_raw;
                set {
                    if (Feline_Harvest_Cooldown_Multiplier_raw == value) return;
                    Feline_Harvest_Cooldown_Multiplier_raw = value;
                    ChangedItems.Add(nameof(Feline_Harvest_Cooldown_Multiplier));
                    OnPropertyChanged(nameof(Feline_Harvest_Cooldown_Multiplier));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Harvest_Cooldown_Multiplier_offset { get; private set; }

            protected float Feline_Sharpshooter_Shell_Attack_Rate_raw;
            public const string Feline_Sharpshooter_Shell_Attack_Rate_displayName = "Feline Sharpshooter: Shell Attack Rate";
            public const int Feline_Sharpshooter_Shell_Attack_Rate_sortIndex = 1450;
            [SortOrder(Feline_Sharpshooter_Shell_Attack_Rate_sortIndex)]
            [DisplayName(Feline_Sharpshooter_Shell_Attack_Rate_displayName)]
            public virtual float Feline_Sharpshooter_Shell_Attack_Rate {
                get => Feline_Sharpshooter_Shell_Attack_Rate_raw;
                set {
                    if (Feline_Sharpshooter_Shell_Attack_Rate_raw == value) return;
                    Feline_Sharpshooter_Shell_Attack_Rate_raw = value;
                    ChangedItems.Add(nameof(Feline_Sharpshooter_Shell_Attack_Rate));
                    OnPropertyChanged(nameof(Feline_Sharpshooter_Shell_Attack_Rate));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Sharpshooter_Shell_Attack_Rate_offset { get; private set; }

            protected float Feline_Escape_Artist_Dash_Stamina_Rate_raw;
            public const string Feline_Escape_Artist_Dash_Stamina_Rate_displayName = "Feline Escape Artist: Dash Stamina Rate";
            public const int Feline_Escape_Artist_Dash_Stamina_Rate_sortIndex = 1500;
            [SortOrder(Feline_Escape_Artist_Dash_Stamina_Rate_sortIndex)]
            [DisplayName(Feline_Escape_Artist_Dash_Stamina_Rate_displayName)]
            public virtual float Feline_Escape_Artist_Dash_Stamina_Rate {
                get => Feline_Escape_Artist_Dash_Stamina_Rate_raw;
                set {
                    if (Feline_Escape_Artist_Dash_Stamina_Rate_raw == value) return;
                    Feline_Escape_Artist_Dash_Stamina_Rate_raw = value;
                    ChangedItems.Add(nameof(Feline_Escape_Artist_Dash_Stamina_Rate));
                    OnPropertyChanged(nameof(Feline_Escape_Artist_Dash_Stamina_Rate));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Escape_Artist_Dash_Stamina_Rate_offset { get; private set; }

            protected float Feline_Delivery_Dash_Stamina_Rate_raw;
            public const string Feline_Delivery_Dash_Stamina_Rate_displayName = "Feline Delivery: Dash Stamina Rate";
            public const int Feline_Delivery_Dash_Stamina_Rate_sortIndex = 1550;
            [SortOrder(Feline_Delivery_Dash_Stamina_Rate_sortIndex)]
            [DisplayName(Feline_Delivery_Dash_Stamina_Rate_displayName)]
            public virtual float Feline_Delivery_Dash_Stamina_Rate {
                get => Feline_Delivery_Dash_Stamina_Rate_raw;
                set {
                    if (Feline_Delivery_Dash_Stamina_Rate_raw == value) return;
                    Feline_Delivery_Dash_Stamina_Rate_raw = value;
                    ChangedItems.Add(nameof(Feline_Delivery_Dash_Stamina_Rate));
                    OnPropertyChanged(nameof(Feline_Delivery_Dash_Stamina_Rate));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Delivery_Dash_Stamina_Rate_offset { get; private set; }

            protected float Feline_Riser_S_IFrames_raw;
            public const string Feline_Riser_S_IFrames_displayName = "Feline Riser S: IFrames";
            public const int Feline_Riser_S_IFrames_sortIndex = 1600;
            [SortOrder(Feline_Riser_S_IFrames_sortIndex)]
            [DisplayName(Feline_Riser_S_IFrames_displayName)]
            public virtual float Feline_Riser_S_IFrames {
                get => Feline_Riser_S_IFrames_raw;
                set {
                    if (Feline_Riser_S_IFrames_raw == value) return;
                    Feline_Riser_S_IFrames_raw = value;
                    ChangedItems.Add(nameof(Feline_Riser_S_IFrames));
                    OnPropertyChanged(nameof(Feline_Riser_S_IFrames));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Riser_S_IFrames_offset { get; private set; }

            protected float Feline_Riser_L_IFrames_raw;
            public const string Feline_Riser_L_IFrames_displayName = "Feline Riser L: IFrames";
            public const int Feline_Riser_L_IFrames_sortIndex = 1650;
            [SortOrder(Feline_Riser_L_IFrames_sortIndex)]
            [DisplayName(Feline_Riser_L_IFrames_displayName)]
            public virtual float Feline_Riser_L_IFrames {
                get => Feline_Riser_L_IFrames_raw;
                set {
                    if (Feline_Riser_L_IFrames_raw == value) return;
                    Feline_Riser_L_IFrames_raw = value;
                    ChangedItems.Add(nameof(Feline_Riser_L_IFrames));
                    OnPropertyChanged(nameof(Feline_Riser_L_IFrames));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Riser_L_IFrames_offset { get; private set; }

            protected float Feline_Temper_Shell_Attack_Rate_raw;
            public const string Feline_Temper_Shell_Attack_Rate_displayName = "Feline Temper: Shell Attack Rate";
            public const int Feline_Temper_Shell_Attack_Rate_sortIndex = 1700;
            [SortOrder(Feline_Temper_Shell_Attack_Rate_sortIndex)]
            [DisplayName(Feline_Temper_Shell_Attack_Rate_displayName)]
            public virtual float Feline_Temper_Shell_Attack_Rate {
                get => Feline_Temper_Shell_Attack_Rate_raw;
                set {
                    if (Feline_Temper_Shell_Attack_Rate_raw == value) return;
                    Feline_Temper_Shell_Attack_Rate_raw = value;
                    ChangedItems.Add(nameof(Feline_Temper_Shell_Attack_Rate));
                    OnPropertyChanged(nameof(Feline_Temper_Shell_Attack_Rate));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Temper_Shell_Attack_Rate_offset { get; private set; }

            protected byte Feline_Temper_Blur_Level_Bonus_raw;
            public const string Feline_Temper_Blur_Level_Bonus_displayName = "Feline Temper: Blur Level Bonus";
            public const int Feline_Temper_Blur_Level_Bonus_sortIndex = 1750;
            [SortOrder(Feline_Temper_Blur_Level_Bonus_sortIndex)]
            [DisplayName(Feline_Temper_Blur_Level_Bonus_displayName)]
            public virtual byte Feline_Temper_Blur_Level_Bonus {
                get => Feline_Temper_Blur_Level_Bonus_raw;
                set {
                    if (Feline_Temper_Blur_Level_Bonus_raw == value) return;
                    Feline_Temper_Blur_Level_Bonus_raw = value;
                    ChangedItems.Add(nameof(Feline_Temper_Blur_Level_Bonus));
                    OnPropertyChanged(nameof(Feline_Temper_Blur_Level_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Temper_Blur_Level_Bonus_offset { get; private set; }

            protected float Feline_Cliffhanger_Stamina_Rate_raw;
            public const string Feline_Cliffhanger_Stamina_Rate_displayName = "Feline Cliffhanger: Stamina Rate";
            public const int Feline_Cliffhanger_Stamina_Rate_sortIndex = 1800;
            [SortOrder(Feline_Cliffhanger_Stamina_Rate_sortIndex)]
            [DisplayName(Feline_Cliffhanger_Stamina_Rate_displayName)]
            public virtual float Feline_Cliffhanger_Stamina_Rate {
                get => Feline_Cliffhanger_Stamina_Rate_raw;
                set {
                    if (Feline_Cliffhanger_Stamina_Rate_raw == value) return;
                    Feline_Cliffhanger_Stamina_Rate_raw = value;
                    ChangedItems.Add(nameof(Feline_Cliffhanger_Stamina_Rate));
                    OnPropertyChanged(nameof(Feline_Cliffhanger_Stamina_Rate));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Cliffhanger_Stamina_Rate_offset { get; private set; }

            protected float Feline_Slugger_Stun_Attack_Rate_raw;
            public const string Feline_Slugger_Stun_Attack_Rate_displayName = "Feline Slugger: Stun Attack Rate";
            public const int Feline_Slugger_Stun_Attack_Rate_sortIndex = 1850;
            [SortOrder(Feline_Slugger_Stun_Attack_Rate_sortIndex)]
            [DisplayName(Feline_Slugger_Stun_Attack_Rate_displayName)]
            public virtual float Feline_Slugger_Stun_Attack_Rate {
                get => Feline_Slugger_Stun_Attack_Rate_raw;
                set {
                    if (Feline_Slugger_Stun_Attack_Rate_raw == value) return;
                    Feline_Slugger_Stun_Attack_Rate_raw = value;
                    ChangedItems.Add(nameof(Feline_Slugger_Stun_Attack_Rate));
                    OnPropertyChanged(nameof(Feline_Slugger_Stun_Attack_Rate));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Slugger_Stun_Attack_Rate_offset { get; private set; }

            protected float Feline_Bombardier_Ballista_Attack_Rate_raw;
            public const string Feline_Bombardier_Ballista_Attack_Rate_displayName = "Feline Bombardier: Ballista Attack Rate";
            public const int Feline_Bombardier_Ballista_Attack_Rate_sortIndex = 1900;
            [SortOrder(Feline_Bombardier_Ballista_Attack_Rate_sortIndex)]
            [DisplayName(Feline_Bombardier_Ballista_Attack_Rate_displayName)]
            public virtual float Feline_Bombardier_Ballista_Attack_Rate {
                get => Feline_Bombardier_Ballista_Attack_Rate_raw;
                set {
                    if (Feline_Bombardier_Ballista_Attack_Rate_raw == value) return;
                    Feline_Bombardier_Ballista_Attack_Rate_raw = value;
                    ChangedItems.Add(nameof(Feline_Bombardier_Ballista_Attack_Rate));
                    OnPropertyChanged(nameof(Feline_Bombardier_Ballista_Attack_Rate));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Bombardier_Ballista_Attack_Rate_offset { get; private set; }

            protected float Feline_Bombardier_Cannon_Attack_Rate_raw;
            public const string Feline_Bombardier_Cannon_Attack_Rate_displayName = "Feline Bombardier: Cannon Attack Rate";
            public const int Feline_Bombardier_Cannon_Attack_Rate_sortIndex = 1950;
            [SortOrder(Feline_Bombardier_Cannon_Attack_Rate_sortIndex)]
            [DisplayName(Feline_Bombardier_Cannon_Attack_Rate_displayName)]
            public virtual float Feline_Bombardier_Cannon_Attack_Rate {
                get => Feline_Bombardier_Cannon_Attack_Rate_raw;
                set {
                    if (Feline_Bombardier_Cannon_Attack_Rate_raw == value) return;
                    Feline_Bombardier_Cannon_Attack_Rate_raw = value;
                    ChangedItems.Add(nameof(Feline_Bombardier_Cannon_Attack_Rate));
                    OnPropertyChanged(nameof(Feline_Bombardier_Cannon_Attack_Rate));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Bombardier_Cannon_Attack_Rate_offset { get; private set; }

            protected float Feline_Bombardier_Gunlance_Shell_Attack_Rate_raw;
            public const string Feline_Bombardier_Gunlance_Shell_Attack_Rate_displayName = "Feline Bombardier: Gunlance Shell Attack Rate";
            public const int Feline_Bombardier_Gunlance_Shell_Attack_Rate_sortIndex = 2000;
            [SortOrder(Feline_Bombardier_Gunlance_Shell_Attack_Rate_sortIndex)]
            [DisplayName(Feline_Bombardier_Gunlance_Shell_Attack_Rate_displayName)]
            public virtual float Feline_Bombardier_Gunlance_Shell_Attack_Rate {
                get => Feline_Bombardier_Gunlance_Shell_Attack_Rate_raw;
                set {
                    if (Feline_Bombardier_Gunlance_Shell_Attack_Rate_raw == value) return;
                    Feline_Bombardier_Gunlance_Shell_Attack_Rate_raw = value;
                    ChangedItems.Add(nameof(Feline_Bombardier_Gunlance_Shell_Attack_Rate));
                    OnPropertyChanged(nameof(Feline_Bombardier_Gunlance_Shell_Attack_Rate));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Bombardier_Gunlance_Shell_Attack_Rate_offset { get; private set; }

            protected float Feline_Bombardier_Gunlance_WyvernFire_Attack_Rate_raw;
            public const string Feline_Bombardier_Gunlance_WyvernFire_Attack_Rate_displayName = "Feline Bombardier: Gunlance WyvernFire Attack Rate";
            public const int Feline_Bombardier_Gunlance_WyvernFire_Attack_Rate_sortIndex = 2050;
            [SortOrder(Feline_Bombardier_Gunlance_WyvernFire_Attack_Rate_sortIndex)]
            [DisplayName(Feline_Bombardier_Gunlance_WyvernFire_Attack_Rate_displayName)]
            public virtual float Feline_Bombardier_Gunlance_WyvernFire_Attack_Rate {
                get => Feline_Bombardier_Gunlance_WyvernFire_Attack_Rate_raw;
                set {
                    if (Feline_Bombardier_Gunlance_WyvernFire_Attack_Rate_raw == value) return;
                    Feline_Bombardier_Gunlance_WyvernFire_Attack_Rate_raw = value;
                    ChangedItems.Add(nameof(Feline_Bombardier_Gunlance_WyvernFire_Attack_Rate));
                    OnPropertyChanged(nameof(Feline_Bombardier_Gunlance_WyvernFire_Attack_Rate));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Bombardier_Gunlance_WyvernFire_Attack_Rate_offset { get; private set; }

            protected float Feline_Bombardier_Gunlance_Wyrmstake_Cannon_Attack_Rate_raw;
            public const string Feline_Bombardier_Gunlance_Wyrmstake_Cannon_Attack_Rate_displayName = "Feline Bombardier: Gunlance Wyrmstake Cannon Attack Rate";
            public const int Feline_Bombardier_Gunlance_Wyrmstake_Cannon_Attack_Rate_sortIndex = 2100;
            [SortOrder(Feline_Bombardier_Gunlance_Wyrmstake_Cannon_Attack_Rate_sortIndex)]
            [DisplayName(Feline_Bombardier_Gunlance_Wyrmstake_Cannon_Attack_Rate_displayName)]
            public virtual float Feline_Bombardier_Gunlance_Wyrmstake_Cannon_Attack_Rate {
                get => Feline_Bombardier_Gunlance_Wyrmstake_Cannon_Attack_Rate_raw;
                set {
                    if (Feline_Bombardier_Gunlance_Wyrmstake_Cannon_Attack_Rate_raw == value) return;
                    Feline_Bombardier_Gunlance_Wyrmstake_Cannon_Attack_Rate_raw = value;
                    ChangedItems.Add(nameof(Feline_Bombardier_Gunlance_Wyrmstake_Cannon_Attack_Rate));
                    OnPropertyChanged(nameof(Feline_Bombardier_Gunlance_Wyrmstake_Cannon_Attack_Rate));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Bombardier_Gunlance_Wyrmstake_Cannon_Attack_Rate_offset { get; private set; }

            protected float Feline_Bombardier_Charge_Blade_Impact_Phial_Attack_Rate_raw;
            public const string Feline_Bombardier_Charge_Blade_Impact_Phial_Attack_Rate_displayName = "Feline Bombardier: Charge Blade Impact Phial Attack Rate";
            public const int Feline_Bombardier_Charge_Blade_Impact_Phial_Attack_Rate_sortIndex = 2150;
            [SortOrder(Feline_Bombardier_Charge_Blade_Impact_Phial_Attack_Rate_sortIndex)]
            [DisplayName(Feline_Bombardier_Charge_Blade_Impact_Phial_Attack_Rate_displayName)]
            public virtual float Feline_Bombardier_Charge_Blade_Impact_Phial_Attack_Rate {
                get => Feline_Bombardier_Charge_Blade_Impact_Phial_Attack_Rate_raw;
                set {
                    if (Feline_Bombardier_Charge_Blade_Impact_Phial_Attack_Rate_raw == value) return;
                    Feline_Bombardier_Charge_Blade_Impact_Phial_Attack_Rate_raw = value;
                    ChangedItems.Add(nameof(Feline_Bombardier_Charge_Blade_Impact_Phial_Attack_Rate));
                    OnPropertyChanged(nameof(Feline_Bombardier_Charge_Blade_Impact_Phial_Attack_Rate));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Bombardier_Charge_Blade_Impact_Phial_Attack_Rate_offset { get; private set; }

            protected float Feline_Bombardier_Bowgun_Sticky_Ammo_Attack_Rate_raw;
            public const string Feline_Bombardier_Bowgun_Sticky_Ammo_Attack_Rate_displayName = "Feline Bombardier: Bowgun Sticky Ammo Attack Rate";
            public const int Feline_Bombardier_Bowgun_Sticky_Ammo_Attack_Rate_sortIndex = 2200;
            [SortOrder(Feline_Bombardier_Bowgun_Sticky_Ammo_Attack_Rate_sortIndex)]
            [DisplayName(Feline_Bombardier_Bowgun_Sticky_Ammo_Attack_Rate_displayName)]
            public virtual float Feline_Bombardier_Bowgun_Sticky_Ammo_Attack_Rate {
                get => Feline_Bombardier_Bowgun_Sticky_Ammo_Attack_Rate_raw;
                set {
                    if (Feline_Bombardier_Bowgun_Sticky_Ammo_Attack_Rate_raw == value) return;
                    Feline_Bombardier_Bowgun_Sticky_Ammo_Attack_Rate_raw = value;
                    ChangedItems.Add(nameof(Feline_Bombardier_Bowgun_Sticky_Ammo_Attack_Rate));
                    OnPropertyChanged(nameof(Feline_Bombardier_Bowgun_Sticky_Ammo_Attack_Rate));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Bombardier_Bowgun_Sticky_Ammo_Attack_Rate_offset { get; private set; }

            protected float Feline_Bombardier_Bowgun_Wyvern_Ammo_Attack_Rate_raw;
            public const string Feline_Bombardier_Bowgun_Wyvern_Ammo_Attack_Rate_displayName = "Feline Bombardier: Bowgun Wyvern Ammo Attack Rate";
            public const int Feline_Bombardier_Bowgun_Wyvern_Ammo_Attack_Rate_sortIndex = 2250;
            [SortOrder(Feline_Bombardier_Bowgun_Wyvern_Ammo_Attack_Rate_sortIndex)]
            [DisplayName(Feline_Bombardier_Bowgun_Wyvern_Ammo_Attack_Rate_displayName)]
            public virtual float Feline_Bombardier_Bowgun_Wyvern_Ammo_Attack_Rate {
                get => Feline_Bombardier_Bowgun_Wyvern_Ammo_Attack_Rate_raw;
                set {
                    if (Feline_Bombardier_Bowgun_Wyvern_Ammo_Attack_Rate_raw == value) return;
                    Feline_Bombardier_Bowgun_Wyvern_Ammo_Attack_Rate_raw = value;
                    ChangedItems.Add(nameof(Feline_Bombardier_Bowgun_Wyvern_Ammo_Attack_Rate));
                    OnPropertyChanged(nameof(Feline_Bombardier_Bowgun_Wyvern_Ammo_Attack_Rate));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Bombardier_Bowgun_Wyvern_Ammo_Attack_Rate_offset { get; private set; }

            protected byte Feline_Moxie_Health_Threshold_raw;
            public const string Feline_Moxie_Health_Threshold_displayName = "Feline Moxie: Health Threshold";
            public const int Feline_Moxie_Health_Threshold_sortIndex = 2300;
            [SortOrder(Feline_Moxie_Health_Threshold_sortIndex)]
            [DisplayName(Feline_Moxie_Health_Threshold_displayName)]
            public virtual byte Feline_Moxie_Health_Threshold {
                get => Feline_Moxie_Health_Threshold_raw;
                set {
                    if (Feline_Moxie_Health_Threshold_raw == value) return;
                    Feline_Moxie_Health_Threshold_raw = value;
                    ChangedItems.Add(nameof(Feline_Moxie_Health_Threshold));
                    OnPropertyChanged(nameof(Feline_Moxie_Health_Threshold));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Moxie_Health_Threshold_offset { get; private set; }

            protected byte Feline_Dungmaster_Escape_Bonus_raw;
            public const string Feline_Dungmaster_Escape_Bonus_displayName = "Feline Dungmaster: Escape % Bonus";
            public const int Feline_Dungmaster_Escape_Bonus_sortIndex = 2350;
            [SortOrder(Feline_Dungmaster_Escape_Bonus_sortIndex)]
            [DisplayName(Feline_Dungmaster_Escape_Bonus_displayName)]
            public virtual byte Feline_Dungmaster_Escape_Bonus {
                get => Feline_Dungmaster_Escape_Bonus_raw;
                set {
                    if (Feline_Dungmaster_Escape_Bonus_raw == value) return;
                    Feline_Dungmaster_Escape_Bonus_raw = value;
                    ChangedItems.Add(nameof(Feline_Dungmaster_Escape_Bonus));
                    OnPropertyChanged(nameof(Feline_Dungmaster_Escape_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Dungmaster_Escape_Bonus_offset { get; private set; }

            protected float Feline_Provoker_Rate_raw;
            public const string Feline_Provoker_Rate_displayName = "Feline Provoker: Rate";
            public const int Feline_Provoker_Rate_sortIndex = 2400;
            [SortOrder(Feline_Provoker_Rate_sortIndex)]
            [DisplayName(Feline_Provoker_Rate_displayName)]
            public virtual float Feline_Provoker_Rate {
                get => Feline_Provoker_Rate_raw;
                set {
                    if (Feline_Provoker_Rate_raw == value) return;
                    Feline_Provoker_Rate_raw = value;
                    ChangedItems.Add(nameof(Feline_Provoker_Rate));
                    OnPropertyChanged(nameof(Feline_Provoker_Rate));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Provoker_Rate_offset { get; private set; }

            protected float Feline_Cool_Cat_Power_UP_Time_Needed_raw;
            public const string Feline_Cool_Cat_Power_UP_Time_Needed_displayName = "Feline Cool Cat: Power UP Time Needed";
            public const int Feline_Cool_Cat_Power_UP_Time_Needed_sortIndex = 2450;
            [SortOrder(Feline_Cool_Cat_Power_UP_Time_Needed_sortIndex)]
            [DisplayName(Feline_Cool_Cat_Power_UP_Time_Needed_displayName)]
            public virtual float Feline_Cool_Cat_Power_UP_Time_Needed {
                get => Feline_Cool_Cat_Power_UP_Time_Needed_raw;
                set {
                    if (Feline_Cool_Cat_Power_UP_Time_Needed_raw == value) return;
                    Feline_Cool_Cat_Power_UP_Time_Needed_raw = value;
                    ChangedItems.Add(nameof(Feline_Cool_Cat_Power_UP_Time_Needed));
                    OnPropertyChanged(nameof(Feline_Cool_Cat_Power_UP_Time_Needed));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Cool_Cat_Power_UP_Time_Needed_offset { get; private set; }

            protected float Feline_Cool_Cat_Power_UP_Duration_raw;
            public const string Feline_Cool_Cat_Power_UP_Duration_displayName = "Feline Cool Cat: Power UP Duration";
            public const int Feline_Cool_Cat_Power_UP_Duration_sortIndex = 2500;
            [SortOrder(Feline_Cool_Cat_Power_UP_Duration_sortIndex)]
            [DisplayName(Feline_Cool_Cat_Power_UP_Duration_displayName)]
            public virtual float Feline_Cool_Cat_Power_UP_Duration {
                get => Feline_Cool_Cat_Power_UP_Duration_raw;
                set {
                    if (Feline_Cool_Cat_Power_UP_Duration_raw == value) return;
                    Feline_Cool_Cat_Power_UP_Duration_raw = value;
                    ChangedItems.Add(nameof(Feline_Cool_Cat_Power_UP_Duration));
                    OnPropertyChanged(nameof(Feline_Cool_Cat_Power_UP_Duration));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Cool_Cat_Power_UP_Duration_offset { get; private set; }

            protected float Feline_Cool_Cat_Attack_Bonus_raw;
            public const string Feline_Cool_Cat_Attack_Bonus_displayName = "Feline Cool Cat: Attack Bonus";
            public const int Feline_Cool_Cat_Attack_Bonus_sortIndex = 2550;
            [SortOrder(Feline_Cool_Cat_Attack_Bonus_sortIndex)]
            [DisplayName(Feline_Cool_Cat_Attack_Bonus_displayName)]
            public virtual float Feline_Cool_Cat_Attack_Bonus {
                get => Feline_Cool_Cat_Attack_Bonus_raw;
                set {
                    if (Feline_Cool_Cat_Attack_Bonus_raw == value) return;
                    Feline_Cool_Cat_Attack_Bonus_raw = value;
                    ChangedItems.Add(nameof(Feline_Cool_Cat_Attack_Bonus));
                    OnPropertyChanged(nameof(Feline_Cool_Cat_Attack_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Cool_Cat_Attack_Bonus_offset { get; private set; }

            protected float Feline_Booster_Attack_Bonus_raw;
            public const string Feline_Booster_Attack_Bonus_displayName = "Feline Booster: Attack Bonus";
            public const int Feline_Booster_Attack_Bonus_sortIndex = 2600;
            [SortOrder(Feline_Booster_Attack_Bonus_sortIndex)]
            [DisplayName(Feline_Booster_Attack_Bonus_displayName)]
            public virtual float Feline_Booster_Attack_Bonus {
                get => Feline_Booster_Attack_Bonus_raw;
                set {
                    if (Feline_Booster_Attack_Bonus_raw == value) return;
                    Feline_Booster_Attack_Bonus_raw = value;
                    ChangedItems.Add(nameof(Feline_Booster_Attack_Bonus));
                    OnPropertyChanged(nameof(Feline_Booster_Attack_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Booster_Attack_Bonus_offset { get; private set; }

            protected float Feline_Booster_Defense_Bonus_raw;
            public const string Feline_Booster_Defense_Bonus_displayName = "Feline Booster: Defense Bonus";
            public const int Feline_Booster_Defense_Bonus_sortIndex = 2650;
            [SortOrder(Feline_Booster_Defense_Bonus_sortIndex)]
            [DisplayName(Feline_Booster_Defense_Bonus_displayName)]
            public virtual float Feline_Booster_Defense_Bonus {
                get => Feline_Booster_Defense_Bonus_raw;
                set {
                    if (Feline_Booster_Defense_Bonus_raw == value) return;
                    Feline_Booster_Defense_Bonus_raw = value;
                    ChangedItems.Add(nameof(Feline_Booster_Defense_Bonus));
                    OnPropertyChanged(nameof(Feline_Booster_Defense_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Booster_Defense_Bonus_offset { get; private set; }

            protected float Feline_Booster_Duration_raw;
            public const string Feline_Booster_Duration_displayName = "Feline Booster: Duration";
            public const int Feline_Booster_Duration_sortIndex = 2700;
            [SortOrder(Feline_Booster_Duration_sortIndex)]
            [DisplayName(Feline_Booster_Duration_displayName)]
            public virtual float Feline_Booster_Duration {
                get => Feline_Booster_Duration_raw;
                set {
                    if (Feline_Booster_Duration_raw == value) return;
                    Feline_Booster_Duration_raw = value;
                    ChangedItems.Add(nameof(Feline_Booster_Duration));
                    OnPropertyChanged(nameof(Feline_Booster_Duration));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Booster_Duration_offset { get; private set; }

            protected float Feline_Groomer_Defense_Down_Duration_Multiplier_raw;
            public const string Feline_Groomer_Defense_Down_Duration_Multiplier_displayName = "Feline Groomer: Defense Down Duration Multiplier";
            public const int Feline_Groomer_Defense_Down_Duration_Multiplier_sortIndex = 2750;
            [SortOrder(Feline_Groomer_Defense_Down_Duration_Multiplier_sortIndex)]
            [DisplayName(Feline_Groomer_Defense_Down_Duration_Multiplier_displayName)]
            public virtual float Feline_Groomer_Defense_Down_Duration_Multiplier {
                get => Feline_Groomer_Defense_Down_Duration_Multiplier_raw;
                set {
                    if (Feline_Groomer_Defense_Down_Duration_Multiplier_raw == value) return;
                    Feline_Groomer_Defense_Down_Duration_Multiplier_raw = value;
                    ChangedItems.Add(nameof(Feline_Groomer_Defense_Down_Duration_Multiplier));
                    OnPropertyChanged(nameof(Feline_Groomer_Defense_Down_Duration_Multiplier));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Groomer_Defense_Down_Duration_Multiplier_offset { get; private set; }

            protected float Feline_Groomer_Element_Blight_Recovery_Multiplier_raw;
            public const string Feline_Groomer_Element_Blight_Recovery_Multiplier_displayName = "Feline Groomer: Element Blight Recovery Multiplier";
            public const int Feline_Groomer_Element_Blight_Recovery_Multiplier_sortIndex = 2800;
            [SortOrder(Feline_Groomer_Element_Blight_Recovery_Multiplier_sortIndex)]
            [DisplayName(Feline_Groomer_Element_Blight_Recovery_Multiplier_displayName)]
            public virtual float Feline_Groomer_Element_Blight_Recovery_Multiplier {
                get => Feline_Groomer_Element_Blight_Recovery_Multiplier_raw;
                set {
                    if (Feline_Groomer_Element_Blight_Recovery_Multiplier_raw == value) return;
                    Feline_Groomer_Element_Blight_Recovery_Multiplier_raw = value;
                    ChangedItems.Add(nameof(Feline_Groomer_Element_Blight_Recovery_Multiplier));
                    OnPropertyChanged(nameof(Feline_Groomer_Element_Blight_Recovery_Multiplier));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Groomer_Element_Blight_Recovery_Multiplier_offset { get; private set; }

            protected float Feline_Parting_Gift_Radius_raw;
            public const string Feline_Parting_Gift_Radius_displayName = "Feline Parting Gift: Radius";
            public const int Feline_Parting_Gift_Radius_sortIndex = 2850;
            [SortOrder(Feline_Parting_Gift_Radius_sortIndex)]
            [DisplayName(Feline_Parting_Gift_Radius_displayName)]
            public virtual float Feline_Parting_Gift_Radius {
                get => Feline_Parting_Gift_Radius_raw;
                set {
                    if (Feline_Parting_Gift_Radius_raw == value) return;
                    Feline_Parting_Gift_Radius_raw = value;
                    ChangedItems.Add(nameof(Feline_Parting_Gift_Radius));
                    OnPropertyChanged(nameof(Feline_Parting_Gift_Radius));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Parting_Gift_Radius_offset { get; private set; }

            protected ushort Feline_Parting_Gift_Recovery_Value_raw;
            public const string Feline_Parting_Gift_Recovery_Value_displayName = "Feline Parting Gift: Recovery Value";
            public const int Feline_Parting_Gift_Recovery_Value_sortIndex = 2900;
            [SortOrder(Feline_Parting_Gift_Recovery_Value_sortIndex)]
            [DisplayName(Feline_Parting_Gift_Recovery_Value_displayName)]
            public virtual ushort Feline_Parting_Gift_Recovery_Value {
                get => Feline_Parting_Gift_Recovery_Value_raw;
                set {
                    if (Feline_Parting_Gift_Recovery_Value_raw == value) return;
                    Feline_Parting_Gift_Recovery_Value_raw = value;
                    ChangedItems.Add(nameof(Feline_Parting_Gift_Recovery_Value));
                    OnPropertyChanged(nameof(Feline_Parting_Gift_Recovery_Value));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Parting_Gift_Recovery_Value_offset { get; private set; }

            protected float Feline_Recoil_Attack_Multiplier_1_raw;
            public const string Feline_Recoil_Attack_Multiplier_1_displayName = "Feline Recoil: Attack Multiplier 1";
            public const int Feline_Recoil_Attack_Multiplier_1_sortIndex = 2950;
            [SortOrder(Feline_Recoil_Attack_Multiplier_1_sortIndex)]
            [DisplayName(Feline_Recoil_Attack_Multiplier_1_displayName)]
            public virtual float Feline_Recoil_Attack_Multiplier_1 {
                get => Feline_Recoil_Attack_Multiplier_1_raw;
                set {
                    if (Feline_Recoil_Attack_Multiplier_1_raw == value) return;
                    Feline_Recoil_Attack_Multiplier_1_raw = value;
                    ChangedItems.Add(nameof(Feline_Recoil_Attack_Multiplier_1));
                    OnPropertyChanged(nameof(Feline_Recoil_Attack_Multiplier_1));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Recoil_Attack_Multiplier_1_offset { get; private set; }

            protected float Feline_Recoil_Attack_Multiplier_2_raw;
            public const string Feline_Recoil_Attack_Multiplier_2_displayName = "Feline Recoil: Attack Multiplier 2";
            public const int Feline_Recoil_Attack_Multiplier_2_sortIndex = 3000;
            [SortOrder(Feline_Recoil_Attack_Multiplier_2_sortIndex)]
            [DisplayName(Feline_Recoil_Attack_Multiplier_2_displayName)]
            public virtual float Feline_Recoil_Attack_Multiplier_2 {
                get => Feline_Recoil_Attack_Multiplier_2_raw;
                set {
                    if (Feline_Recoil_Attack_Multiplier_2_raw == value) return;
                    Feline_Recoil_Attack_Multiplier_2_raw = value;
                    ChangedItems.Add(nameof(Feline_Recoil_Attack_Multiplier_2));
                    OnPropertyChanged(nameof(Feline_Recoil_Attack_Multiplier_2));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Recoil_Attack_Multiplier_2_offset { get; private set; }

            protected float Feline_Recoil_Attack_Multiplier_3_raw;
            public const string Feline_Recoil_Attack_Multiplier_3_displayName = "Feline Recoil: Attack Multiplier 3";
            public const int Feline_Recoil_Attack_Multiplier_3_sortIndex = 3050;
            [SortOrder(Feline_Recoil_Attack_Multiplier_3_sortIndex)]
            [DisplayName(Feline_Recoil_Attack_Multiplier_3_displayName)]
            public virtual float Feline_Recoil_Attack_Multiplier_3 {
                get => Feline_Recoil_Attack_Multiplier_3_raw;
                set {
                    if (Feline_Recoil_Attack_Multiplier_3_raw == value) return;
                    Feline_Recoil_Attack_Multiplier_3_raw = value;
                    ChangedItems.Add(nameof(Feline_Recoil_Attack_Multiplier_3));
                    OnPropertyChanged(nameof(Feline_Recoil_Attack_Multiplier_3));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Recoil_Attack_Multiplier_3_offset { get; private set; }

            protected float Feline_Recoil_Attack_Multiplier_4_raw;
            public const string Feline_Recoil_Attack_Multiplier_4_displayName = "Feline Recoil: Attack Multiplier 4";
            public const int Feline_Recoil_Attack_Multiplier_4_sortIndex = 3100;
            [SortOrder(Feline_Recoil_Attack_Multiplier_4_sortIndex)]
            [DisplayName(Feline_Recoil_Attack_Multiplier_4_displayName)]
            public virtual float Feline_Recoil_Attack_Multiplier_4 {
                get => Feline_Recoil_Attack_Multiplier_4_raw;
                set {
                    if (Feline_Recoil_Attack_Multiplier_4_raw == value) return;
                    Feline_Recoil_Attack_Multiplier_4_raw = value;
                    ChangedItems.Add(nameof(Feline_Recoil_Attack_Multiplier_4));
                    OnPropertyChanged(nameof(Feline_Recoil_Attack_Multiplier_4));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Recoil_Attack_Multiplier_4_offset { get; private set; }

            protected float Feline_Recoil_Attack_Multiplier_5_raw;
            public const string Feline_Recoil_Attack_Multiplier_5_displayName = "Feline Recoil: Attack Multiplier 5";
            public const int Feline_Recoil_Attack_Multiplier_5_sortIndex = 3150;
            [SortOrder(Feline_Recoil_Attack_Multiplier_5_sortIndex)]
            [DisplayName(Feline_Recoil_Attack_Multiplier_5_displayName)]
            public virtual float Feline_Recoil_Attack_Multiplier_5 {
                get => Feline_Recoil_Attack_Multiplier_5_raw;
                set {
                    if (Feline_Recoil_Attack_Multiplier_5_raw == value) return;
                    Feline_Recoil_Attack_Multiplier_5_raw = value;
                    ChangedItems.Add(nameof(Feline_Recoil_Attack_Multiplier_5));
                    OnPropertyChanged(nameof(Feline_Recoil_Attack_Multiplier_5));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Recoil_Attack_Multiplier_5_offset { get; private set; }

            protected float Feline_Tailor_raw;
            public const string Feline_Tailor_displayName = "Feline Tailor";
            public const int Feline_Tailor_sortIndex = 3200;
            [SortOrder(Feline_Tailor_sortIndex)]
            [DisplayName(Feline_Tailor_displayName)]
            public virtual float Feline_Tailor {
                get => Feline_Tailor_raw;
                set {
                    if (Feline_Tailor_raw == value) return;
                    Feline_Tailor_raw = value;
                    ChangedItems.Add(nameof(Feline_Tailor));
                    OnPropertyChanged(nameof(Feline_Tailor));
                }
            }

            [DisplayName("Offset")]
            public long Feline_Tailor_offset { get; private set; }

            public const int lastSortIndex = 3250;

            public static ObservableMhwStructCollection<Feline_Skill> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Feline_Skill>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Feline_Skill LoadData(BinaryReader reader, ulong i) {
                var data = new Feline_Skill();
                data.Index = i;
                data.Feline_Polisher_1_offset = reader.BaseStream.Position;
                data.Feline_Polisher_1_raw = reader.ReadByte();
                data.Feline_Polisher_2_offset = reader.BaseStream.Position;
                data.Feline_Polisher_2_raw = reader.ReadByte();
                data.Feline_Polisher_3_offset = reader.BaseStream.Position;
                data.Feline_Polisher_3_raw = reader.ReadByte();
                data.Feline_Polisher_Loop_1_offset = reader.BaseStream.Position;
                data.Feline_Polisher_Loop_1_raw = reader.ReadByte();
                data.Feline_Polisher_Loop_2_offset = reader.BaseStream.Position;
                data.Feline_Polisher_Loop_2_raw = reader.ReadByte();
                data.Feline_Polisher_Loop_3_offset = reader.BaseStream.Position;
                data.Feline_Polisher_Loop_3_raw = reader.ReadByte();
                data.Feline_Rider_Attack_Rate_offset = reader.BaseStream.Position;
                data.Feline_Rider_Attack_Rate_raw = reader.ReadSingle();
                data.Feline_Heroics_Attack_Rate_offset = reader.BaseStream.Position;
                data.Feline_Heroics_Attack_Rate_raw = reader.ReadSingle();
                data.Feline_Heroics_Defense_Rate_offset = reader.BaseStream.Position;
                data.Feline_Heroics_Defense_Rate_raw = reader.ReadSingle();
                data.Feline_Heroics_Life_Activation_Threshold_offset = reader.BaseStream.Position;
                data.Feline_Heroics_Life_Activation_Threshold_raw = reader.ReadByte();
                data.Feline_Carving_L_Lottery_1_offset = reader.BaseStream.Position;
                data.Feline_Carving_L_Lottery_1_raw = reader.ReadByte();
                data.Feline_Carving_L_Lottery_2_offset = reader.BaseStream.Position;
                data.Feline_Carving_L_Lottery_2_raw = reader.ReadByte();
                data.Feline_Carving_L_Lottery_3_offset = reader.BaseStream.Position;
                data.Feline_Carving_L_Lottery_3_raw = reader.ReadByte();
                data.Feline_Carving_L_Up_1_offset = reader.BaseStream.Position;
                data.Feline_Carving_L_Up_1_raw = reader.ReadByte();
                data.Feline_Carving_L_Up_2_offset = reader.BaseStream.Position;
                data.Feline_Carving_L_Up_2_raw = reader.ReadByte();
                data.Feline_Carving_L_Up_3_offset = reader.BaseStream.Position;
                data.Feline_Carving_L_Up_3_raw = reader.ReadByte();
                data.Feline_Carving_L_Up_4_offset = reader.BaseStream.Position;
                data.Feline_Carving_L_Up_4_raw = reader.ReadByte();
                data.Feline_Carving_S_Lottery__offset = reader.BaseStream.Position;
                data.Feline_Carving_S_Lottery__raw = reader.ReadByte();
                data.Feline_Carving_S_Up__offset = reader.BaseStream.Position;
                data.Feline_Carving_S_Up__raw = reader.ReadByte();
                data.Feline_Medic_Heal_Rate_offset = reader.BaseStream.Position;
                data.Feline_Medic_Heal_Rate_raw = reader.ReadSingle();
                data.Feline_Black_Belt_Stamina_Rate_offset = reader.BaseStream.Position;
                data.Feline_Black_Belt_Stamina_Rate_raw = reader.ReadSingle();
                data.Feline_Special_Attack_Condition_Attack_Bonus_offset = reader.BaseStream.Position;
                data.Feline_Special_Attack_Condition_Attack_Bonus_raw = reader.ReadUInt16();
                data.Feline_Special_Attack_Capture_Attack_Rate_offset = reader.BaseStream.Position;
                data.Feline_Special_Attack_Capture_Attack_Rate_raw = reader.ReadSingle();
                data.Feline_Defense_S__offset = reader.BaseStream.Position;
                data.Feline_Defense_S__raw = reader.ReadByte();
                data.Feline_Defense_L__offset = reader.BaseStream.Position;
                data.Feline_Defense_L__raw = reader.ReadByte();
                data.Feline_Defense_S_Damage_Rate_offset = reader.BaseStream.Position;
                data.Feline_Defense_S_Damage_Rate_raw = reader.ReadSingle();
                data.Feline_Defense_L_Damage_Rate_offset = reader.BaseStream.Position;
                data.Feline_Defense_L_Damage_Rate_raw = reader.ReadSingle();
                data.Feline_Harvest_Cooldown_Multiplier_offset = reader.BaseStream.Position;
                data.Feline_Harvest_Cooldown_Multiplier_raw = reader.ReadSingle();
                data.Feline_Sharpshooter_Shell_Attack_Rate_offset = reader.BaseStream.Position;
                data.Feline_Sharpshooter_Shell_Attack_Rate_raw = reader.ReadSingle();
                data.Feline_Escape_Artist_Dash_Stamina_Rate_offset = reader.BaseStream.Position;
                data.Feline_Escape_Artist_Dash_Stamina_Rate_raw = reader.ReadSingle();
                data.Feline_Delivery_Dash_Stamina_Rate_offset = reader.BaseStream.Position;
                data.Feline_Delivery_Dash_Stamina_Rate_raw = reader.ReadSingle();
                data.Feline_Riser_S_IFrames_offset = reader.BaseStream.Position;
                data.Feline_Riser_S_IFrames_raw = reader.ReadSingle();
                data.Feline_Riser_L_IFrames_offset = reader.BaseStream.Position;
                data.Feline_Riser_L_IFrames_raw = reader.ReadSingle();
                data.Feline_Temper_Shell_Attack_Rate_offset = reader.BaseStream.Position;
                data.Feline_Temper_Shell_Attack_Rate_raw = reader.ReadSingle();
                data.Feline_Temper_Blur_Level_Bonus_offset = reader.BaseStream.Position;
                data.Feline_Temper_Blur_Level_Bonus_raw = reader.ReadByte();
                data.Feline_Cliffhanger_Stamina_Rate_offset = reader.BaseStream.Position;
                data.Feline_Cliffhanger_Stamina_Rate_raw = reader.ReadSingle();
                data.Feline_Slugger_Stun_Attack_Rate_offset = reader.BaseStream.Position;
                data.Feline_Slugger_Stun_Attack_Rate_raw = reader.ReadSingle();
                data.Feline_Bombardier_Ballista_Attack_Rate_offset = reader.BaseStream.Position;
                data.Feline_Bombardier_Ballista_Attack_Rate_raw = reader.ReadSingle();
                data.Feline_Bombardier_Cannon_Attack_Rate_offset = reader.BaseStream.Position;
                data.Feline_Bombardier_Cannon_Attack_Rate_raw = reader.ReadSingle();
                data.Feline_Bombardier_Gunlance_Shell_Attack_Rate_offset = reader.BaseStream.Position;
                data.Feline_Bombardier_Gunlance_Shell_Attack_Rate_raw = reader.ReadSingle();
                data.Feline_Bombardier_Gunlance_WyvernFire_Attack_Rate_offset = reader.BaseStream.Position;
                data.Feline_Bombardier_Gunlance_WyvernFire_Attack_Rate_raw = reader.ReadSingle();
                data.Feline_Bombardier_Gunlance_Wyrmstake_Cannon_Attack_Rate_offset = reader.BaseStream.Position;
                data.Feline_Bombardier_Gunlance_Wyrmstake_Cannon_Attack_Rate_raw = reader.ReadSingle();
                data.Feline_Bombardier_Charge_Blade_Impact_Phial_Attack_Rate_offset = reader.BaseStream.Position;
                data.Feline_Bombardier_Charge_Blade_Impact_Phial_Attack_Rate_raw = reader.ReadSingle();
                data.Feline_Bombardier_Bowgun_Sticky_Ammo_Attack_Rate_offset = reader.BaseStream.Position;
                data.Feline_Bombardier_Bowgun_Sticky_Ammo_Attack_Rate_raw = reader.ReadSingle();
                data.Feline_Bombardier_Bowgun_Wyvern_Ammo_Attack_Rate_offset = reader.BaseStream.Position;
                data.Feline_Bombardier_Bowgun_Wyvern_Ammo_Attack_Rate_raw = reader.ReadSingle();
                data.Feline_Moxie_Health_Threshold_offset = reader.BaseStream.Position;
                data.Feline_Moxie_Health_Threshold_raw = reader.ReadByte();
                data.Feline_Dungmaster_Escape_Bonus_offset = reader.BaseStream.Position;
                data.Feline_Dungmaster_Escape_Bonus_raw = reader.ReadByte();
                data.Feline_Provoker_Rate_offset = reader.BaseStream.Position;
                data.Feline_Provoker_Rate_raw = reader.ReadSingle();
                data.Feline_Cool_Cat_Power_UP_Time_Needed_offset = reader.BaseStream.Position;
                data.Feline_Cool_Cat_Power_UP_Time_Needed_raw = reader.ReadSingle();
                data.Feline_Cool_Cat_Power_UP_Duration_offset = reader.BaseStream.Position;
                data.Feline_Cool_Cat_Power_UP_Duration_raw = reader.ReadSingle();
                data.Feline_Cool_Cat_Attack_Bonus_offset = reader.BaseStream.Position;
                data.Feline_Cool_Cat_Attack_Bonus_raw = reader.ReadSingle();
                data.Feline_Booster_Attack_Bonus_offset = reader.BaseStream.Position;
                data.Feline_Booster_Attack_Bonus_raw = reader.ReadSingle();
                data.Feline_Booster_Defense_Bonus_offset = reader.BaseStream.Position;
                data.Feline_Booster_Defense_Bonus_raw = reader.ReadSingle();
                data.Feline_Booster_Duration_offset = reader.BaseStream.Position;
                data.Feline_Booster_Duration_raw = reader.ReadSingle();
                data.Feline_Groomer_Defense_Down_Duration_Multiplier_offset = reader.BaseStream.Position;
                data.Feline_Groomer_Defense_Down_Duration_Multiplier_raw = reader.ReadSingle();
                data.Feline_Groomer_Element_Blight_Recovery_Multiplier_offset = reader.BaseStream.Position;
                data.Feline_Groomer_Element_Blight_Recovery_Multiplier_raw = reader.ReadSingle();
                data.Feline_Parting_Gift_Radius_offset = reader.BaseStream.Position;
                data.Feline_Parting_Gift_Radius_raw = reader.ReadSingle();
                data.Feline_Parting_Gift_Recovery_Value_offset = reader.BaseStream.Position;
                data.Feline_Parting_Gift_Recovery_Value_raw = reader.ReadUInt16();
                data.Feline_Recoil_Attack_Multiplier_1_offset = reader.BaseStream.Position;
                data.Feline_Recoil_Attack_Multiplier_1_raw = reader.ReadSingle();
                data.Feline_Recoil_Attack_Multiplier_2_offset = reader.BaseStream.Position;
                data.Feline_Recoil_Attack_Multiplier_2_raw = reader.ReadSingle();
                data.Feline_Recoil_Attack_Multiplier_3_offset = reader.BaseStream.Position;
                data.Feline_Recoil_Attack_Multiplier_3_raw = reader.ReadSingle();
                data.Feline_Recoil_Attack_Multiplier_4_offset = reader.BaseStream.Position;
                data.Feline_Recoil_Attack_Multiplier_4_raw = reader.ReadSingle();
                data.Feline_Recoil_Attack_Multiplier_5_offset = reader.BaseStream.Position;
                data.Feline_Recoil_Attack_Multiplier_5_raw = reader.ReadSingle();
                data.Feline_Tailor_offset = reader.BaseStream.Position;
                data.Feline_Tailor_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Feline_Polisher_1_raw);
                writer.Write(Feline_Polisher_2_raw);
                writer.Write(Feline_Polisher_3_raw);
                writer.Write(Feline_Polisher_Loop_1_raw);
                writer.Write(Feline_Polisher_Loop_2_raw);
                writer.Write(Feline_Polisher_Loop_3_raw);
                writer.Write(Feline_Rider_Attack_Rate_raw);
                writer.Write(Feline_Heroics_Attack_Rate_raw);
                writer.Write(Feline_Heroics_Defense_Rate_raw);
                writer.Write(Feline_Heroics_Life_Activation_Threshold_raw);
                writer.Write(Feline_Carving_L_Lottery_1_raw);
                writer.Write(Feline_Carving_L_Lottery_2_raw);
                writer.Write(Feline_Carving_L_Lottery_3_raw);
                writer.Write(Feline_Carving_L_Up_1_raw);
                writer.Write(Feline_Carving_L_Up_2_raw);
                writer.Write(Feline_Carving_L_Up_3_raw);
                writer.Write(Feline_Carving_L_Up_4_raw);
                writer.Write(Feline_Carving_S_Lottery__raw);
                writer.Write(Feline_Carving_S_Up__raw);
                writer.Write(Feline_Medic_Heal_Rate_raw);
                writer.Write(Feline_Black_Belt_Stamina_Rate_raw);
                writer.Write(Feline_Special_Attack_Condition_Attack_Bonus_raw);
                writer.Write(Feline_Special_Attack_Capture_Attack_Rate_raw);
                writer.Write(Feline_Defense_S__raw);
                writer.Write(Feline_Defense_L__raw);
                writer.Write(Feline_Defense_S_Damage_Rate_raw);
                writer.Write(Feline_Defense_L_Damage_Rate_raw);
                writer.Write(Feline_Harvest_Cooldown_Multiplier_raw);
                writer.Write(Feline_Sharpshooter_Shell_Attack_Rate_raw);
                writer.Write(Feline_Escape_Artist_Dash_Stamina_Rate_raw);
                writer.Write(Feline_Delivery_Dash_Stamina_Rate_raw);
                writer.Write(Feline_Riser_S_IFrames_raw);
                writer.Write(Feline_Riser_L_IFrames_raw);
                writer.Write(Feline_Temper_Shell_Attack_Rate_raw);
                writer.Write(Feline_Temper_Blur_Level_Bonus_raw);
                writer.Write(Feline_Cliffhanger_Stamina_Rate_raw);
                writer.Write(Feline_Slugger_Stun_Attack_Rate_raw);
                writer.Write(Feline_Bombardier_Ballista_Attack_Rate_raw);
                writer.Write(Feline_Bombardier_Cannon_Attack_Rate_raw);
                writer.Write(Feline_Bombardier_Gunlance_Shell_Attack_Rate_raw);
                writer.Write(Feline_Bombardier_Gunlance_WyvernFire_Attack_Rate_raw);
                writer.Write(Feline_Bombardier_Gunlance_Wyrmstake_Cannon_Attack_Rate_raw);
                writer.Write(Feline_Bombardier_Charge_Blade_Impact_Phial_Attack_Rate_raw);
                writer.Write(Feline_Bombardier_Bowgun_Sticky_Ammo_Attack_Rate_raw);
                writer.Write(Feline_Bombardier_Bowgun_Wyvern_Ammo_Attack_Rate_raw);
                writer.Write(Feline_Moxie_Health_Threshold_raw);
                writer.Write(Feline_Dungmaster_Escape_Bonus_raw);
                writer.Write(Feline_Provoker_Rate_raw);
                writer.Write(Feline_Cool_Cat_Power_UP_Time_Needed_raw);
                writer.Write(Feline_Cool_Cat_Power_UP_Duration_raw);
                writer.Write(Feline_Cool_Cat_Attack_Bonus_raw);
                writer.Write(Feline_Booster_Attack_Bonus_raw);
                writer.Write(Feline_Booster_Defense_Bonus_raw);
                writer.Write(Feline_Booster_Duration_raw);
                writer.Write(Feline_Groomer_Defense_Down_Duration_Multiplier_raw);
                writer.Write(Feline_Groomer_Element_Blight_Recovery_Multiplier_raw);
                writer.Write(Feline_Parting_Gift_Radius_raw);
                writer.Write(Feline_Parting_Gift_Recovery_Value_raw);
                writer.Write(Feline_Recoil_Attack_Multiplier_1_raw);
                writer.Write(Feline_Recoil_Attack_Multiplier_2_raw);
                writer.Write(Feline_Recoil_Attack_Multiplier_3_raw);
                writer.Write(Feline_Recoil_Attack_Multiplier_4_raw);
                writer.Write(Feline_Recoil_Attack_Multiplier_5_raw);
                writer.Write(Feline_Tailor_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Feline Polisher: % 1", "Feline_Polisher_1", "Feline_Polisher_1_offset"),
                    new MultiStructItemCustomView(this, "Feline Polisher: % 2", "Feline_Polisher_2", "Feline_Polisher_2_offset"),
                    new MultiStructItemCustomView(this, "Feline Polisher: % 3", "Feline_Polisher_3", "Feline_Polisher_3_offset"),
                    new MultiStructItemCustomView(this, "Feline Polisher: Loop # 1", "Feline_Polisher_Loop_1", "Feline_Polisher_Loop_1_offset"),
                    new MultiStructItemCustomView(this, "Feline Polisher: Loop # 2", "Feline_Polisher_Loop_2", "Feline_Polisher_Loop_2_offset"),
                    new MultiStructItemCustomView(this, "Feline Polisher: Loop # 3", "Feline_Polisher_Loop_3", "Feline_Polisher_Loop_3_offset"),
                    new MultiStructItemCustomView(this, "Feline Rider: Attack Rate", "Feline_Rider_Attack_Rate", "Feline_Rider_Attack_Rate_offset"),
                    new MultiStructItemCustomView(this, "Feline Heroics: Attack Rate", "Feline_Heroics_Attack_Rate", "Feline_Heroics_Attack_Rate_offset"),
                    new MultiStructItemCustomView(this, "Feline Heroics: Defense Rate", "Feline_Heroics_Defense_Rate", "Feline_Heroics_Defense_Rate_offset"),
                    new MultiStructItemCustomView(this, "Feline Heroics: Life Activation Threshold", "Feline_Heroics_Life_Activation_Threshold", "Feline_Heroics_Life_Activation_Threshold_offset"),
                    new MultiStructItemCustomView(this, "Feline Carving L: Lottery % 1", "Feline_Carving_L_Lottery_1", "Feline_Carving_L_Lottery_1_offset"),
                    new MultiStructItemCustomView(this, "Feline Carving L: Lottery % 2", "Feline_Carving_L_Lottery_2", "Feline_Carving_L_Lottery_2_offset"),
                    new MultiStructItemCustomView(this, "Feline Carving L: Lottery % 3", "Feline_Carving_L_Lottery_3", "Feline_Carving_L_Lottery_3_offset"),
                    new MultiStructItemCustomView(this, "Feline Carving L: Up % 1", "Feline_Carving_L_Up_1", "Feline_Carving_L_Up_1_offset"),
                    new MultiStructItemCustomView(this, "Feline Carving L: Up % 2", "Feline_Carving_L_Up_2", "Feline_Carving_L_Up_2_offset"),
                    new MultiStructItemCustomView(this, "Feline Carving L: Up % 3", "Feline_Carving_L_Up_3", "Feline_Carving_L_Up_3_offset"),
                    new MultiStructItemCustomView(this, "Feline Carving L: Up % 4", "Feline_Carving_L_Up_4", "Feline_Carving_L_Up_4_offset"),
                    new MultiStructItemCustomView(this, "Feline Carving S: Lottery %", "Feline_Carving_S_Lottery_", "Feline_Carving_S_Lottery__offset"),
                    new MultiStructItemCustomView(this, "Feline Carving S: Up %", "Feline_Carving_S_Up_", "Feline_Carving_S_Up__offset"),
                    new MultiStructItemCustomView(this, "Feline Medic: Heal Rate", "Feline_Medic_Heal_Rate", "Feline_Medic_Heal_Rate_offset"),
                    new MultiStructItemCustomView(this, "Feline Black Belt: Stamina Rate", "Feline_Black_Belt_Stamina_Rate", "Feline_Black_Belt_Stamina_Rate_offset"),
                    new MultiStructItemCustomView(this, "Feline Special Attack: Condition Attack Bonus", "Feline_Special_Attack_Condition_Attack_Bonus", "Feline_Special_Attack_Condition_Attack_Bonus_offset"),
                    new MultiStructItemCustomView(this, "Feline Special Attack: Capture Attack Rate", "Feline_Special_Attack_Capture_Attack_Rate", "Feline_Special_Attack_Capture_Attack_Rate_offset"),
                    new MultiStructItemCustomView(this, "Feline Defense S: %", "Feline_Defense_S_", "Feline_Defense_S__offset"),
                    new MultiStructItemCustomView(this, "Feline Defense L: %", "Feline_Defense_L_", "Feline_Defense_L__offset"),
                    new MultiStructItemCustomView(this, "Feline Defense S: Damage Rate", "Feline_Defense_S_Damage_Rate", "Feline_Defense_S_Damage_Rate_offset"),
                    new MultiStructItemCustomView(this, "Feline Defense L: Damage Rate", "Feline_Defense_L_Damage_Rate", "Feline_Defense_L_Damage_Rate_offset"),
                    new MultiStructItemCustomView(this, "Feline Harvest: Cooldown Multiplier", "Feline_Harvest_Cooldown_Multiplier", "Feline_Harvest_Cooldown_Multiplier_offset"),
                    new MultiStructItemCustomView(this, "Feline Sharpshooter: Shell Attack Rate", "Feline_Sharpshooter_Shell_Attack_Rate", "Feline_Sharpshooter_Shell_Attack_Rate_offset"),
                    new MultiStructItemCustomView(this, "Feline Escape Artist: Dash Stamina Rate", "Feline_Escape_Artist_Dash_Stamina_Rate", "Feline_Escape_Artist_Dash_Stamina_Rate_offset"),
                    new MultiStructItemCustomView(this, "Feline Delivery: Dash Stamina Rate", "Feline_Delivery_Dash_Stamina_Rate", "Feline_Delivery_Dash_Stamina_Rate_offset"),
                    new MultiStructItemCustomView(this, "Feline Riser S: IFrames", "Feline_Riser_S_IFrames", "Feline_Riser_S_IFrames_offset"),
                    new MultiStructItemCustomView(this, "Feline Riser L: IFrames", "Feline_Riser_L_IFrames", "Feline_Riser_L_IFrames_offset"),
                    new MultiStructItemCustomView(this, "Feline Temper: Shell Attack Rate", "Feline_Temper_Shell_Attack_Rate", "Feline_Temper_Shell_Attack_Rate_offset"),
                    new MultiStructItemCustomView(this, "Feline Temper: Blur Level Bonus", "Feline_Temper_Blur_Level_Bonus", "Feline_Temper_Blur_Level_Bonus_offset"),
                    new MultiStructItemCustomView(this, "Feline Cliffhanger: Stamina Rate", "Feline_Cliffhanger_Stamina_Rate", "Feline_Cliffhanger_Stamina_Rate_offset"),
                    new MultiStructItemCustomView(this, "Feline Slugger: Stun Attack Rate", "Feline_Slugger_Stun_Attack_Rate", "Feline_Slugger_Stun_Attack_Rate_offset"),
                    new MultiStructItemCustomView(this, "Feline Bombardier: Ballista Attack Rate", "Feline_Bombardier_Ballista_Attack_Rate", "Feline_Bombardier_Ballista_Attack_Rate_offset"),
                    new MultiStructItemCustomView(this, "Feline Bombardier: Cannon Attack Rate", "Feline_Bombardier_Cannon_Attack_Rate", "Feline_Bombardier_Cannon_Attack_Rate_offset"),
                    new MultiStructItemCustomView(this, "Feline Bombardier: Gunlance Shell Attack Rate", "Feline_Bombardier_Gunlance_Shell_Attack_Rate", "Feline_Bombardier_Gunlance_Shell_Attack_Rate_offset"),
                    new MultiStructItemCustomView(this, "Feline Bombardier: Gunlance WyvernFire Attack Rate", "Feline_Bombardier_Gunlance_WyvernFire_Attack_Rate", "Feline_Bombardier_Gunlance_WyvernFire_Attack_Rate_offset"),
                    new MultiStructItemCustomView(this, "Feline Bombardier: Gunlance Wyrmstake Cannon Attack Rate", "Feline_Bombardier_Gunlance_Wyrmstake_Cannon_Attack_Rate", "Feline_Bombardier_Gunlance_Wyrmstake_Cannon_Attack_Rate_offset"),
                    new MultiStructItemCustomView(this, "Feline Bombardier: Charge Blade Impact Phial Attack Rate", "Feline_Bombardier_Charge_Blade_Impact_Phial_Attack_Rate", "Feline_Bombardier_Charge_Blade_Impact_Phial_Attack_Rate_offset"),
                    new MultiStructItemCustomView(this, "Feline Bombardier: Bowgun Sticky Ammo Attack Rate", "Feline_Bombardier_Bowgun_Sticky_Ammo_Attack_Rate", "Feline_Bombardier_Bowgun_Sticky_Ammo_Attack_Rate_offset"),
                    new MultiStructItemCustomView(this, "Feline Bombardier: Bowgun Wyvern Ammo Attack Rate", "Feline_Bombardier_Bowgun_Wyvern_Ammo_Attack_Rate", "Feline_Bombardier_Bowgun_Wyvern_Ammo_Attack_Rate_offset"),
                    new MultiStructItemCustomView(this, "Feline Moxie: Health Threshold", "Feline_Moxie_Health_Threshold", "Feline_Moxie_Health_Threshold_offset"),
                    new MultiStructItemCustomView(this, "Feline Dungmaster: Escape % Bonus", "Feline_Dungmaster_Escape_Bonus", "Feline_Dungmaster_Escape_Bonus_offset"),
                    new MultiStructItemCustomView(this, "Feline Provoker: Rate", "Feline_Provoker_Rate", "Feline_Provoker_Rate_offset"),
                    new MultiStructItemCustomView(this, "Feline Cool Cat: Power UP Time Needed", "Feline_Cool_Cat_Power_UP_Time_Needed", "Feline_Cool_Cat_Power_UP_Time_Needed_offset"),
                    new MultiStructItemCustomView(this, "Feline Cool Cat: Power UP Duration", "Feline_Cool_Cat_Power_UP_Duration", "Feline_Cool_Cat_Power_UP_Duration_offset"),
                    new MultiStructItemCustomView(this, "Feline Cool Cat: Attack Bonus", "Feline_Cool_Cat_Attack_Bonus", "Feline_Cool_Cat_Attack_Bonus_offset"),
                    new MultiStructItemCustomView(this, "Feline Booster: Attack Bonus", "Feline_Booster_Attack_Bonus", "Feline_Booster_Attack_Bonus_offset"),
                    new MultiStructItemCustomView(this, "Feline Booster: Defense Bonus", "Feline_Booster_Defense_Bonus", "Feline_Booster_Defense_Bonus_offset"),
                    new MultiStructItemCustomView(this, "Feline Booster: Duration", "Feline_Booster_Duration", "Feline_Booster_Duration_offset"),
                    new MultiStructItemCustomView(this, "Feline Groomer: Defense Down Duration Multiplier", "Feline_Groomer_Defense_Down_Duration_Multiplier", "Feline_Groomer_Defense_Down_Duration_Multiplier_offset"),
                    new MultiStructItemCustomView(this, "Feline Groomer: Element Blight Recovery Multiplier", "Feline_Groomer_Element_Blight_Recovery_Multiplier", "Feline_Groomer_Element_Blight_Recovery_Multiplier_offset"),
                    new MultiStructItemCustomView(this, "Feline Parting Gift: Radius", "Feline_Parting_Gift_Radius", "Feline_Parting_Gift_Radius_offset"),
                    new MultiStructItemCustomView(this, "Feline Parting Gift: Recovery Value", "Feline_Parting_Gift_Recovery_Value", "Feline_Parting_Gift_Recovery_Value_offset"),
                    new MultiStructItemCustomView(this, "Feline Recoil: Attack Multiplier 1", "Feline_Recoil_Attack_Multiplier_1", "Feline_Recoil_Attack_Multiplier_1_offset"),
                    new MultiStructItemCustomView(this, "Feline Recoil: Attack Multiplier 2", "Feline_Recoil_Attack_Multiplier_2", "Feline_Recoil_Attack_Multiplier_2_offset"),
                    new MultiStructItemCustomView(this, "Feline Recoil: Attack Multiplier 3", "Feline_Recoil_Attack_Multiplier_3", "Feline_Recoil_Attack_Multiplier_3_offset"),
                    new MultiStructItemCustomView(this, "Feline Recoil: Attack Multiplier 4", "Feline_Recoil_Attack_Multiplier_4", "Feline_Recoil_Attack_Multiplier_4_offset"),
                    new MultiStructItemCustomView(this, "Feline Recoil: Attack Multiplier 5", "Feline_Recoil_Attack_Multiplier_5", "Feline_Recoil_Attack_Multiplier_5_offset"),
                    new MultiStructItemCustomView(this, "Feline Tailor", "Feline_Tailor", "Feline_Tailor_offset"),
                };
            }
        }

        public partial class Skill_Params_8_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Skill Params (8)";

            protected float Music_Skill_Bless_Random_Rate_raw;
            public const string Music_Skill_Bless_Random_Rate_displayName = "Music Skill: Bless: Random Rate";
            public const int Music_Skill_Bless_Random_Rate_sortIndex = 50;
            [SortOrder(Music_Skill_Bless_Random_Rate_sortIndex)]
            [DisplayName(Music_Skill_Bless_Random_Rate_displayName)]
            public virtual float Music_Skill_Bless_Random_Rate {
                get => Music_Skill_Bless_Random_Rate_raw;
                set {
                    if (Music_Skill_Bless_Random_Rate_raw == value) return;
                    Music_Skill_Bless_Random_Rate_raw = value;
                    ChangedItems.Add(nameof(Music_Skill_Bless_Random_Rate));
                    OnPropertyChanged(nameof(Music_Skill_Bless_Random_Rate));
                }
            }

            [DisplayName("Offset")]
            public long Music_Skill_Bless_Random_Rate_offset { get; private set; }

            protected float Music_Skill_Bless_Damage_Cut_Rate_raw;
            public const string Music_Skill_Bless_Damage_Cut_Rate_displayName = "Music Skill: Bless: Damage Cut Rate";
            public const int Music_Skill_Bless_Damage_Cut_Rate_sortIndex = 100;
            [SortOrder(Music_Skill_Bless_Damage_Cut_Rate_sortIndex)]
            [DisplayName(Music_Skill_Bless_Damage_Cut_Rate_displayName)]
            public virtual float Music_Skill_Bless_Damage_Cut_Rate {
                get => Music_Skill_Bless_Damage_Cut_Rate_raw;
                set {
                    if (Music_Skill_Bless_Damage_Cut_Rate_raw == value) return;
                    Music_Skill_Bless_Damage_Cut_Rate_raw = value;
                    ChangedItems.Add(nameof(Music_Skill_Bless_Damage_Cut_Rate));
                    OnPropertyChanged(nameof(Music_Skill_Bless_Damage_Cut_Rate));
                }
            }

            [DisplayName("Offset")]
            public long Music_Skill_Bless_Damage_Cut_Rate_offset { get; private set; }

            protected float Music_Skill_Extend_Time_raw;
            public const string Music_Skill_Extend_Time_displayName = "Music Skill: Extend: Time";
            public const int Music_Skill_Extend_Time_sortIndex = 150;
            [SortOrder(Music_Skill_Extend_Time_sortIndex)]
            [DisplayName(Music_Skill_Extend_Time_displayName)]
            public virtual float Music_Skill_Extend_Time {
                get => Music_Skill_Extend_Time_raw;
                set {
                    if (Music_Skill_Extend_Time_raw == value) return;
                    Music_Skill_Extend_Time_raw = value;
                    ChangedItems.Add(nameof(Music_Skill_Extend_Time));
                    OnPropertyChanged(nameof(Music_Skill_Extend_Time));
                }
            }

            [DisplayName("Offset")]
            public long Music_Skill_Extend_Time_offset { get; private set; }

            protected float Music_Skill_Extend_Time_Master_raw;
            public const string Music_Skill_Extend_Time_Master_displayName = "Music Skill: Extend: Time Master";
            public const int Music_Skill_Extend_Time_Master_sortIndex = 200;
            [SortOrder(Music_Skill_Extend_Time_Master_sortIndex)]
            [DisplayName(Music_Skill_Extend_Time_Master_displayName)]
            public virtual float Music_Skill_Extend_Time_Master {
                get => Music_Skill_Extend_Time_Master_raw;
                set {
                    if (Music_Skill_Extend_Time_Master_raw == value) return;
                    Music_Skill_Extend_Time_Master_raw = value;
                    ChangedItems.Add(nameof(Music_Skill_Extend_Time_Master));
                    OnPropertyChanged(nameof(Music_Skill_Extend_Time_Master));
                }
            }

            [DisplayName("Offset")]
            public long Music_Skill_Extend_Time_Master_offset { get; private set; }

            protected float Music_Skill_Extend_Time_MR_Master_raw;
            public const string Music_Skill_Extend_Time_MR_Master_displayName = "Music Skill: Extend: Time MR Master";
            public const int Music_Skill_Extend_Time_MR_Master_sortIndex = 250;
            [SortOrder(Music_Skill_Extend_Time_MR_Master_sortIndex)]
            [DisplayName(Music_Skill_Extend_Time_MR_Master_displayName)]
            public virtual float Music_Skill_Extend_Time_MR_Master {
                get => Music_Skill_Extend_Time_MR_Master_raw;
                set {
                    if (Music_Skill_Extend_Time_MR_Master_raw == value) return;
                    Music_Skill_Extend_Time_MR_Master_raw = value;
                    ChangedItems.Add(nameof(Music_Skill_Extend_Time_MR_Master));
                    OnPropertyChanged(nameof(Music_Skill_Extend_Time_MR_Master));
                }
            }

            [DisplayName("Offset")]
            public long Music_Skill_Extend_Time_MR_Master_offset { get; private set; }

            protected float Music_Skill_Major_Heal_Rand_Rate_raw;
            public const string Music_Skill_Major_Heal_Rand_Rate_displayName = "Music Skill: Major Heal: Rand Rate";
            public const int Music_Skill_Major_Heal_Rand_Rate_sortIndex = 300;
            [SortOrder(Music_Skill_Major_Heal_Rand_Rate_sortIndex)]
            [DisplayName(Music_Skill_Major_Heal_Rand_Rate_displayName)]
            public virtual float Music_Skill_Major_Heal_Rand_Rate {
                get => Music_Skill_Major_Heal_Rand_Rate_raw;
                set {
                    if (Music_Skill_Major_Heal_Rand_Rate_raw == value) return;
                    Music_Skill_Major_Heal_Rand_Rate_raw = value;
                    ChangedItems.Add(nameof(Music_Skill_Major_Heal_Rand_Rate));
                    OnPropertyChanged(nameof(Music_Skill_Major_Heal_Rand_Rate));
                }
            }

            [DisplayName("Offset")]
            public long Music_Skill_Major_Heal_Rand_Rate_offset { get; private set; }

            protected float Music_Skill_Major_Heal_Rand_Master_Rate_raw;
            public const string Music_Skill_Major_Heal_Rand_Master_Rate_displayName = "Music Skill: Major Heal: Rand Master Rate";
            public const int Music_Skill_Major_Heal_Rand_Master_Rate_sortIndex = 350;
            [SortOrder(Music_Skill_Major_Heal_Rand_Master_Rate_sortIndex)]
            [DisplayName(Music_Skill_Major_Heal_Rand_Master_Rate_displayName)]
            public virtual float Music_Skill_Major_Heal_Rand_Master_Rate {
                get => Music_Skill_Major_Heal_Rand_Master_Rate_raw;
                set {
                    if (Music_Skill_Major_Heal_Rand_Master_Rate_raw == value) return;
                    Music_Skill_Major_Heal_Rand_Master_Rate_raw = value;
                    ChangedItems.Add(nameof(Music_Skill_Major_Heal_Rand_Master_Rate));
                    OnPropertyChanged(nameof(Music_Skill_Major_Heal_Rand_Master_Rate));
                }
            }

            [DisplayName("Offset")]
            public long Music_Skill_Major_Heal_Rand_Master_Rate_offset { get; private set; }

            protected float Music_Skill_Major_Heal_Rand_MR_Master_Rate_raw;
            public const string Music_Skill_Major_Heal_Rand_MR_Master_Rate_displayName = "Music Skill: Major Heal: Rand MR Master Rate";
            public const int Music_Skill_Major_Heal_Rand_MR_Master_Rate_sortIndex = 400;
            [SortOrder(Music_Skill_Major_Heal_Rand_MR_Master_Rate_sortIndex)]
            [DisplayName(Music_Skill_Major_Heal_Rand_MR_Master_Rate_displayName)]
            public virtual float Music_Skill_Major_Heal_Rand_MR_Master_Rate {
                get => Music_Skill_Major_Heal_Rand_MR_Master_Rate_raw;
                set {
                    if (Music_Skill_Major_Heal_Rand_MR_Master_Rate_raw == value) return;
                    Music_Skill_Major_Heal_Rand_MR_Master_Rate_raw = value;
                    ChangedItems.Add(nameof(Music_Skill_Major_Heal_Rand_MR_Master_Rate));
                    OnPropertyChanged(nameof(Music_Skill_Major_Heal_Rand_MR_Master_Rate));
                }
            }

            [DisplayName("Offset")]
            public long Music_Skill_Major_Heal_Rand_MR_Master_Rate_offset { get; private set; }

            protected float Music_Skill_Heal_0_Minor_raw;
            public const string Music_Skill_Heal_0_Minor_displayName = "Music Skill: Heal 0: Minor";
            public const int Music_Skill_Heal_0_Minor_sortIndex = 450;
            [SortOrder(Music_Skill_Heal_0_Minor_sortIndex)]
            [DisplayName(Music_Skill_Heal_0_Minor_displayName)]
            public virtual float Music_Skill_Heal_0_Minor {
                get => Music_Skill_Heal_0_Minor_raw;
                set {
                    if (Music_Skill_Heal_0_Minor_raw == value) return;
                    Music_Skill_Heal_0_Minor_raw = value;
                    ChangedItems.Add(nameof(Music_Skill_Heal_0_Minor));
                    OnPropertyChanged(nameof(Music_Skill_Heal_0_Minor));
                }
            }

            [DisplayName("Offset")]
            public long Music_Skill_Heal_0_Minor_offset { get; private set; }

            protected float Music_Skill_Heal_0_Major_raw;
            public const string Music_Skill_Heal_0_Major_displayName = "Music Skill: Heal 0: Major";
            public const int Music_Skill_Heal_0_Major_sortIndex = 500;
            [SortOrder(Music_Skill_Heal_0_Major_sortIndex)]
            [DisplayName(Music_Skill_Heal_0_Major_displayName)]
            public virtual float Music_Skill_Heal_0_Major {
                get => Music_Skill_Heal_0_Major_raw;
                set {
                    if (Music_Skill_Heal_0_Major_raw == value) return;
                    Music_Skill_Heal_0_Major_raw = value;
                    ChangedItems.Add(nameof(Music_Skill_Heal_0_Major));
                    OnPropertyChanged(nameof(Music_Skill_Heal_0_Major));
                }
            }

            [DisplayName("Offset")]
            public long Music_Skill_Heal_0_Major_offset { get; private set; }

            protected float Music_Skill_Heal_1_Minor_raw;
            public const string Music_Skill_Heal_1_Minor_displayName = "Music Skill: Heal 1: Minor";
            public const int Music_Skill_Heal_1_Minor_sortIndex = 550;
            [SortOrder(Music_Skill_Heal_1_Minor_sortIndex)]
            [DisplayName(Music_Skill_Heal_1_Minor_displayName)]
            public virtual float Music_Skill_Heal_1_Minor {
                get => Music_Skill_Heal_1_Minor_raw;
                set {
                    if (Music_Skill_Heal_1_Minor_raw == value) return;
                    Music_Skill_Heal_1_Minor_raw = value;
                    ChangedItems.Add(nameof(Music_Skill_Heal_1_Minor));
                    OnPropertyChanged(nameof(Music_Skill_Heal_1_Minor));
                }
            }

            [DisplayName("Offset")]
            public long Music_Skill_Heal_1_Minor_offset { get; private set; }

            protected float Music_Skill_Heal_1_Major_raw;
            public const string Music_Skill_Heal_1_Major_displayName = "Music Skill: Heal 1: Major";
            public const int Music_Skill_Heal_1_Major_sortIndex = 600;
            [SortOrder(Music_Skill_Heal_1_Major_sortIndex)]
            [DisplayName(Music_Skill_Heal_1_Major_displayName)]
            public virtual float Music_Skill_Heal_1_Major {
                get => Music_Skill_Heal_1_Major_raw;
                set {
                    if (Music_Skill_Heal_1_Major_raw == value) return;
                    Music_Skill_Heal_1_Major_raw = value;
                    ChangedItems.Add(nameof(Music_Skill_Heal_1_Major));
                    OnPropertyChanged(nameof(Music_Skill_Heal_1_Major));
                }
            }

            [DisplayName("Offset")]
            public long Music_Skill_Heal_1_Major_offset { get; private set; }

            protected float Music_Skill_Heal_2_Minor_raw;
            public const string Music_Skill_Heal_2_Minor_displayName = "Music Skill: Heal 2: Minor";
            public const int Music_Skill_Heal_2_Minor_sortIndex = 650;
            [SortOrder(Music_Skill_Heal_2_Minor_sortIndex)]
            [DisplayName(Music_Skill_Heal_2_Minor_displayName)]
            public virtual float Music_Skill_Heal_2_Minor {
                get => Music_Skill_Heal_2_Minor_raw;
                set {
                    if (Music_Skill_Heal_2_Minor_raw == value) return;
                    Music_Skill_Heal_2_Minor_raw = value;
                    ChangedItems.Add(nameof(Music_Skill_Heal_2_Minor));
                    OnPropertyChanged(nameof(Music_Skill_Heal_2_Minor));
                }
            }

            [DisplayName("Offset")]
            public long Music_Skill_Heal_2_Minor_offset { get; private set; }

            protected float Music_Skill_Heal_2_Major_raw;
            public const string Music_Skill_Heal_2_Major_displayName = "Music Skill: Heal 2: Major";
            public const int Music_Skill_Heal_2_Major_sortIndex = 700;
            [SortOrder(Music_Skill_Heal_2_Major_sortIndex)]
            [DisplayName(Music_Skill_Heal_2_Major_displayName)]
            public virtual float Music_Skill_Heal_2_Major {
                get => Music_Skill_Heal_2_Major_raw;
                set {
                    if (Music_Skill_Heal_2_Major_raw == value) return;
                    Music_Skill_Heal_2_Major_raw = value;
                    ChangedItems.Add(nameof(Music_Skill_Heal_2_Major));
                    OnPropertyChanged(nameof(Music_Skill_Heal_2_Major));
                }
            }

            [DisplayName("Offset")]
            public long Music_Skill_Heal_2_Major_offset { get; private set; }

            protected uint Music_Skill_Hp_Up_0_raw;
            public const string Music_Skill_Hp_Up_0_displayName = "Music Skill: Hp Up 0";
            public const int Music_Skill_Hp_Up_0_sortIndex = 750;
            [SortOrder(Music_Skill_Hp_Up_0_sortIndex)]
            [DisplayName(Music_Skill_Hp_Up_0_displayName)]
            public virtual uint Music_Skill_Hp_Up_0 {
                get => Music_Skill_Hp_Up_0_raw;
                set {
                    if (Music_Skill_Hp_Up_0_raw == value) return;
                    Music_Skill_Hp_Up_0_raw = value;
                    ChangedItems.Add(nameof(Music_Skill_Hp_Up_0));
                    OnPropertyChanged(nameof(Music_Skill_Hp_Up_0));
                }
            }

            [DisplayName("Offset")]
            public long Music_Skill_Hp_Up_0_offset { get; private set; }

            protected uint Music_Skill_Hp_Up_1_raw;
            public const string Music_Skill_Hp_Up_1_displayName = "Music Skill: Hp Up 1";
            public const int Music_Skill_Hp_Up_1_sortIndex = 800;
            [SortOrder(Music_Skill_Hp_Up_1_sortIndex)]
            [DisplayName(Music_Skill_Hp_Up_1_displayName)]
            public virtual uint Music_Skill_Hp_Up_1 {
                get => Music_Skill_Hp_Up_1_raw;
                set {
                    if (Music_Skill_Hp_Up_1_raw == value) return;
                    Music_Skill_Hp_Up_1_raw = value;
                    ChangedItems.Add(nameof(Music_Skill_Hp_Up_1));
                    OnPropertyChanged(nameof(Music_Skill_Hp_Up_1));
                }
            }

            [DisplayName("Offset")]
            public long Music_Skill_Hp_Up_1_offset { get; private set; }

            protected float Music_Skill_Mantle_Duration_raw;
            public const string Music_Skill_Mantle_Duration_displayName = "Music Skill: Mantle Duration";
            public const int Music_Skill_Mantle_Duration_sortIndex = 850;
            [SortOrder(Music_Skill_Mantle_Duration_sortIndex)]
            [DisplayName(Music_Skill_Mantle_Duration_displayName)]
            public virtual float Music_Skill_Mantle_Duration {
                get => Music_Skill_Mantle_Duration_raw;
                set {
                    if (Music_Skill_Mantle_Duration_raw == value) return;
                    Music_Skill_Mantle_Duration_raw = value;
                    ChangedItems.Add(nameof(Music_Skill_Mantle_Duration));
                    OnPropertyChanged(nameof(Music_Skill_Mantle_Duration));
                }
            }

            [DisplayName("Offset")]
            public long Music_Skill_Mantle_Duration_offset { get; private set; }

            protected float Music_Skill_Mantle_Duration_Put_raw;
            public const string Music_Skill_Mantle_Duration_Put_displayName = "Music Skill: Mantle Duration Put";
            public const int Music_Skill_Mantle_Duration_Put_sortIndex = 900;
            [SortOrder(Music_Skill_Mantle_Duration_Put_sortIndex)]
            [DisplayName(Music_Skill_Mantle_Duration_Put_displayName)]
            public virtual float Music_Skill_Mantle_Duration_Put {
                get => Music_Skill_Mantle_Duration_Put_raw;
                set {
                    if (Music_Skill_Mantle_Duration_Put_raw == value) return;
                    Music_Skill_Mantle_Duration_Put_raw = value;
                    ChangedItems.Add(nameof(Music_Skill_Mantle_Duration_Put));
                    OnPropertyChanged(nameof(Music_Skill_Mantle_Duration_Put));
                }
            }

            [DisplayName("Offset")]
            public long Music_Skill_Mantle_Duration_Put_offset { get; private set; }

            protected float Music_Skill_Stamina_Up_Rate_raw;
            public const string Music_Skill_Stamina_Up_Rate_displayName = "Music Skill: Stamina Up Rate";
            public const int Music_Skill_Stamina_Up_Rate_sortIndex = 950;
            [SortOrder(Music_Skill_Stamina_Up_Rate_sortIndex)]
            [DisplayName(Music_Skill_Stamina_Up_Rate_displayName)]
            public virtual float Music_Skill_Stamina_Up_Rate {
                get => Music_Skill_Stamina_Up_Rate_raw;
                set {
                    if (Music_Skill_Stamina_Up_Rate_raw == value) return;
                    Music_Skill_Stamina_Up_Rate_raw = value;
                    ChangedItems.Add(nameof(Music_Skill_Stamina_Up_Rate));
                    OnPropertyChanged(nameof(Music_Skill_Stamina_Up_Rate));
                }
            }

            [DisplayName("Offset")]
            public long Music_Skill_Stamina_Up_Rate_offset { get; private set; }

            protected float Unk79_raw;
            public const string Unk79_displayName = "Unk79";
            public const int Unk79_sortIndex = 1000;
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
            public const int Unk80_sortIndex = 1050;
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

            protected uint Unk81_raw;
            public const string Unk81_displayName = "Unk81";
            public const int Unk81_sortIndex = 1100;
            [SortOrder(Unk81_sortIndex)]
            [DisplayName(Unk81_displayName)]
            public virtual uint Unk81 {
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

            protected uint Unk82_raw;
            public const string Unk82_displayName = "Unk82";
            public const int Unk82_sortIndex = 1150;
            [SortOrder(Unk82_sortIndex)]
            [DisplayName(Unk82_displayName)]
            public virtual uint Unk82 {
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
            public const int Unk83_sortIndex = 1200;
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
            public const int Unk84_sortIndex = 1250;
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
            public const int Unk85_sortIndex = 1300;
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

            protected uint Unk86_raw;
            public const string Unk86_displayName = "Unk86";
            public const int Unk86_sortIndex = 1350;
            [SortOrder(Unk86_sortIndex)]
            [DisplayName(Unk86_displayName)]
            public virtual uint Unk86 {
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

            protected uint Unk87_raw;
            public const string Unk87_displayName = "Unk87";
            public const int Unk87_sortIndex = 1400;
            [SortOrder(Unk87_sortIndex)]
            [DisplayName(Unk87_displayName)]
            public virtual uint Unk87 {
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
            public const int Unk88_sortIndex = 1450;
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
            public const int Unk89_sortIndex = 1500;
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

            public const int lastSortIndex = 1550;

            public static ObservableMhwStructCollection<Skill_Params_8_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Skill_Params_8_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Skill_Params_8_ LoadData(BinaryReader reader, ulong i) {
                var data = new Skill_Params_8_();
                data.Index = i;
                data.Music_Skill_Bless_Random_Rate_offset = reader.BaseStream.Position;
                data.Music_Skill_Bless_Random_Rate_raw = reader.ReadSingle();
                data.Music_Skill_Bless_Damage_Cut_Rate_offset = reader.BaseStream.Position;
                data.Music_Skill_Bless_Damage_Cut_Rate_raw = reader.ReadSingle();
                data.Music_Skill_Extend_Time_offset = reader.BaseStream.Position;
                data.Music_Skill_Extend_Time_raw = reader.ReadSingle();
                data.Music_Skill_Extend_Time_Master_offset = reader.BaseStream.Position;
                data.Music_Skill_Extend_Time_Master_raw = reader.ReadSingle();
                data.Music_Skill_Extend_Time_MR_Master_offset = reader.BaseStream.Position;
                data.Music_Skill_Extend_Time_MR_Master_raw = reader.ReadSingle();
                data.Music_Skill_Major_Heal_Rand_Rate_offset = reader.BaseStream.Position;
                data.Music_Skill_Major_Heal_Rand_Rate_raw = reader.ReadSingle();
                data.Music_Skill_Major_Heal_Rand_Master_Rate_offset = reader.BaseStream.Position;
                data.Music_Skill_Major_Heal_Rand_Master_Rate_raw = reader.ReadSingle();
                data.Music_Skill_Major_Heal_Rand_MR_Master_Rate_offset = reader.BaseStream.Position;
                data.Music_Skill_Major_Heal_Rand_MR_Master_Rate_raw = reader.ReadSingle();
                data.Music_Skill_Heal_0_Minor_offset = reader.BaseStream.Position;
                data.Music_Skill_Heal_0_Minor_raw = reader.ReadSingle();
                data.Music_Skill_Heal_0_Major_offset = reader.BaseStream.Position;
                data.Music_Skill_Heal_0_Major_raw = reader.ReadSingle();
                data.Music_Skill_Heal_1_Minor_offset = reader.BaseStream.Position;
                data.Music_Skill_Heal_1_Minor_raw = reader.ReadSingle();
                data.Music_Skill_Heal_1_Major_offset = reader.BaseStream.Position;
                data.Music_Skill_Heal_1_Major_raw = reader.ReadSingle();
                data.Music_Skill_Heal_2_Minor_offset = reader.BaseStream.Position;
                data.Music_Skill_Heal_2_Minor_raw = reader.ReadSingle();
                data.Music_Skill_Heal_2_Major_offset = reader.BaseStream.Position;
                data.Music_Skill_Heal_2_Major_raw = reader.ReadSingle();
                data.Music_Skill_Hp_Up_0_offset = reader.BaseStream.Position;
                data.Music_Skill_Hp_Up_0_raw = reader.ReadUInt32();
                data.Music_Skill_Hp_Up_1_offset = reader.BaseStream.Position;
                data.Music_Skill_Hp_Up_1_raw = reader.ReadUInt32();
                data.Music_Skill_Mantle_Duration_offset = reader.BaseStream.Position;
                data.Music_Skill_Mantle_Duration_raw = reader.ReadSingle();
                data.Music_Skill_Mantle_Duration_Put_offset = reader.BaseStream.Position;
                data.Music_Skill_Mantle_Duration_Put_raw = reader.ReadSingle();
                data.Music_Skill_Stamina_Up_Rate_offset = reader.BaseStream.Position;
                data.Music_Skill_Stamina_Up_Rate_raw = reader.ReadSingle();
                data.Unk79_offset = reader.BaseStream.Position;
                data.Unk79_raw = reader.ReadSingle();
                data.Unk80_offset = reader.BaseStream.Position;
                data.Unk80_raw = reader.ReadSingle();
                data.Unk81_offset = reader.BaseStream.Position;
                data.Unk81_raw = reader.ReadUInt32();
                data.Unk82_offset = reader.BaseStream.Position;
                data.Unk82_raw = reader.ReadUInt32();
                data.Unk83_offset = reader.BaseStream.Position;
                data.Unk83_raw = reader.ReadSingle();
                data.Unk84_offset = reader.BaseStream.Position;
                data.Unk84_raw = reader.ReadSingle();
                data.Unk85_offset = reader.BaseStream.Position;
                data.Unk85_raw = reader.ReadSingle();
                data.Unk86_offset = reader.BaseStream.Position;
                data.Unk86_raw = reader.ReadUInt32();
                data.Unk87_offset = reader.BaseStream.Position;
                data.Unk87_raw = reader.ReadUInt32();
                data.Unk88_offset = reader.BaseStream.Position;
                data.Unk88_raw = reader.ReadSingle();
                data.Unk89_offset = reader.BaseStream.Position;
                data.Unk89_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Music_Skill_Bless_Random_Rate_raw);
                writer.Write(Music_Skill_Bless_Damage_Cut_Rate_raw);
                writer.Write(Music_Skill_Extend_Time_raw);
                writer.Write(Music_Skill_Extend_Time_Master_raw);
                writer.Write(Music_Skill_Extend_Time_MR_Master_raw);
                writer.Write(Music_Skill_Major_Heal_Rand_Rate_raw);
                writer.Write(Music_Skill_Major_Heal_Rand_Master_Rate_raw);
                writer.Write(Music_Skill_Major_Heal_Rand_MR_Master_Rate_raw);
                writer.Write(Music_Skill_Heal_0_Minor_raw);
                writer.Write(Music_Skill_Heal_0_Major_raw);
                writer.Write(Music_Skill_Heal_1_Minor_raw);
                writer.Write(Music_Skill_Heal_1_Major_raw);
                writer.Write(Music_Skill_Heal_2_Minor_raw);
                writer.Write(Music_Skill_Heal_2_Major_raw);
                writer.Write(Music_Skill_Hp_Up_0_raw);
                writer.Write(Music_Skill_Hp_Up_1_raw);
                writer.Write(Music_Skill_Mantle_Duration_raw);
                writer.Write(Music_Skill_Mantle_Duration_Put_raw);
                writer.Write(Music_Skill_Stamina_Up_Rate_raw);
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
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Music Skill: Bless: Random Rate", "Music_Skill_Bless_Random_Rate", "Music_Skill_Bless_Random_Rate_offset"),
                    new MultiStructItemCustomView(this, "Music Skill: Bless: Damage Cut Rate", "Music_Skill_Bless_Damage_Cut_Rate", "Music_Skill_Bless_Damage_Cut_Rate_offset"),
                    new MultiStructItemCustomView(this, "Music Skill: Extend: Time", "Music_Skill_Extend_Time", "Music_Skill_Extend_Time_offset"),
                    new MultiStructItemCustomView(this, "Music Skill: Extend: Time Master", "Music_Skill_Extend_Time_Master", "Music_Skill_Extend_Time_Master_offset"),
                    new MultiStructItemCustomView(this, "Music Skill: Extend: Time MR Master", "Music_Skill_Extend_Time_MR_Master", "Music_Skill_Extend_Time_MR_Master_offset"),
                    new MultiStructItemCustomView(this, "Music Skill: Major Heal: Rand Rate", "Music_Skill_Major_Heal_Rand_Rate", "Music_Skill_Major_Heal_Rand_Rate_offset"),
                    new MultiStructItemCustomView(this, "Music Skill: Major Heal: Rand Master Rate", "Music_Skill_Major_Heal_Rand_Master_Rate", "Music_Skill_Major_Heal_Rand_Master_Rate_offset"),
                    new MultiStructItemCustomView(this, "Music Skill: Major Heal: Rand MR Master Rate", "Music_Skill_Major_Heal_Rand_MR_Master_Rate", "Music_Skill_Major_Heal_Rand_MR_Master_Rate_offset"),
                    new MultiStructItemCustomView(this, "Music Skill: Heal 0: Minor", "Music_Skill_Heal_0_Minor", "Music_Skill_Heal_0_Minor_offset"),
                    new MultiStructItemCustomView(this, "Music Skill: Heal 0: Major", "Music_Skill_Heal_0_Major", "Music_Skill_Heal_0_Major_offset"),
                    new MultiStructItemCustomView(this, "Music Skill: Heal 1: Minor", "Music_Skill_Heal_1_Minor", "Music_Skill_Heal_1_Minor_offset"),
                    new MultiStructItemCustomView(this, "Music Skill: Heal 1: Major", "Music_Skill_Heal_1_Major", "Music_Skill_Heal_1_Major_offset"),
                    new MultiStructItemCustomView(this, "Music Skill: Heal 2: Minor", "Music_Skill_Heal_2_Minor", "Music_Skill_Heal_2_Minor_offset"),
                    new MultiStructItemCustomView(this, "Music Skill: Heal 2: Major", "Music_Skill_Heal_2_Major", "Music_Skill_Heal_2_Major_offset"),
                    new MultiStructItemCustomView(this, "Music Skill: Hp Up 0", "Music_Skill_Hp_Up_0", "Music_Skill_Hp_Up_0_offset"),
                    new MultiStructItemCustomView(this, "Music Skill: Hp Up 1", "Music_Skill_Hp_Up_1", "Music_Skill_Hp_Up_1_offset"),
                    new MultiStructItemCustomView(this, "Music Skill: Mantle Duration", "Music_Skill_Mantle_Duration", "Music_Skill_Mantle_Duration_offset"),
                    new MultiStructItemCustomView(this, "Music Skill: Mantle Duration Put", "Music_Skill_Mantle_Duration_Put", "Music_Skill_Mantle_Duration_Put_offset"),
                    new MultiStructItemCustomView(this, "Music Skill: Stamina Up Rate", "Music_Skill_Stamina_Up_Rate", "Music_Skill_Stamina_Up_Rate_offset"),
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
                };
            }
        }

        public override void LoadFile(string targetFile) {
            using var reader = new BinaryReader(OpenFile(targetFile, EncryptionKey), Encoding.UTF8);
            data = new LinkedList<MhwStructDataContainer>();
            var Header_ = new MhwStructDataContainer<Header>(Header.LoadData(reader), typeof(Header));
            data.AddLast(Header_);
            var Skill_Params_1__ = new MhwStructDataContainer<Skill_Params_1_>(Skill_Params_1_.LoadData(reader), typeof(Skill_Params_1_));
            data.AddLast(Skill_Params_1__);
            var Wide_Range_ = new MhwStructDataContainer<Wide_Range>(Wide_Range.LoadData(reader), typeof(Wide_Range));
            data.AddLast(Wide_Range_);
            var Skill_Params_2__ = new MhwStructDataContainer<Skill_Params_2_>(Skill_Params_2_.LoadData(reader), typeof(Skill_Params_2_));
            data.AddLast(Skill_Params_2__);
            var Focus_ = new MhwStructDataContainer<Focus>(Focus.LoadData(reader), typeof(Focus));
            data.AddLast(Focus_);
            var Punishing_Draw_ = new MhwStructDataContainer<Punishing_Draw>(Punishing_Draw.LoadData(reader), typeof(Punishing_Draw));
            data.AddLast(Punishing_Draw_);
            var Razor_Sharp_ = new MhwStructDataContainer<Razor_Sharp>(Razor_Sharp.LoadData(reader), typeof(Razor_Sharp));
            data.AddLast(Razor_Sharp_);
            var Minds_Eye_Ballistics_ = new MhwStructDataContainer<Minds_Eye_Ballistics>(Minds_Eye_Ballistics.LoadData(reader), typeof(Minds_Eye_Ballistics));
            data.AddLast(Minds_Eye_Ballistics_);
            var Critical_Element_Multipliers_ = new MhwStructDataContainer<Critical_Element_Multipliers>(Critical_Element_Multipliers.LoadData(reader), typeof(Critical_Element_Multipliers));
            data.AddLast(Critical_Element_Multipliers_);
            var Critical_Condition_Multipliers_ = new MhwStructDataContainer<Critical_Condition_Multipliers>(Critical_Condition_Multipliers.LoadData(reader), typeof(Critical_Condition_Multipliers));
            data.AddLast(Critical_Condition_Multipliers_);
            var Skill_Params_3__ = new MhwStructDataContainer<Skill_Params_3_>(Skill_Params_3_.LoadData(reader), typeof(Skill_Params_3_));
            data.AddLast(Skill_Params_3__);
            var Artillery_ = new MhwStructDataContainer<Artillery>(Artillery.LoadData(reader), typeof(Artillery));
            data.AddLast(Artillery_);
            var Skill_Params_4__ = new MhwStructDataContainer<Skill_Params_4_>(Skill_Params_4_.LoadData(reader), typeof(Skill_Params_4_));
            data.AddLast(Skill_Params_4__);
            var Ammo_Up_ = new MhwStructDataContainer<Ammo_Up>(Ammo_Up.LoadData(reader), typeof(Ammo_Up));
            data.AddLast(Ammo_Up_);
            var Power_Prolonger_ = new MhwStructDataContainer<Power_Prolonger>(Power_Prolonger.LoadData(reader), typeof(Power_Prolonger));
            data.AddLast(Power_Prolonger_);
            var Skill_Params_5__ = new MhwStructDataContainer<Skill_Params_5_>(Skill_Params_5_.LoadData(reader), typeof(Skill_Params_5_));
            data.AddLast(Skill_Params_5__);
            var Slinger_Up_ = new MhwStructDataContainer<Slinger_Up>(Slinger_Up.LoadData(reader), typeof(Slinger_Up));
            data.AddLast(Slinger_Up_);
            var Skill_Params_6__ = new MhwStructDataContainer<Skill_Params_6_>(Skill_Params_6_.LoadData(reader), typeof(Skill_Params_6_));
            data.AddLast(Skill_Params_6__);
            var Frostcraft_1__ = new MhwStructDataContainer<Frostcraft_1_>(Frostcraft_1_.LoadData(reader), typeof(Frostcraft_1_));
            data.AddLast(Frostcraft_1__);
            var Frostcraft_2__ = new MhwStructDataContainer<Frostcraft_2_>(Frostcraft_2_.LoadData(reader), typeof(Frostcraft_2_));
            data.AddLast(Frostcraft_2__);
            var Skill_Params_7__ = new MhwStructDataContainer<Skill_Params_7_>(Skill_Params_7_.LoadData(reader), typeof(Skill_Params_7_));
            data.AddLast(Skill_Params_7__);
            var Clutch_Claw_Boost_ = new MhwStructDataContainer<Clutch_Claw_Boost>(Clutch_Claw_Boost.LoadData(reader), typeof(Clutch_Claw_Boost));
            data.AddLast(Clutch_Claw_Boost_);
            var Food_Effects_ = new MhwStructDataContainer<Food_Effects>(Food_Effects.LoadData(reader), typeof(Food_Effects));
            data.AddLast(Food_Effects_);
            var Feline_Skill_ = new MhwStructDataContainer<Feline_Skill>(Feline_Skill.LoadData(reader), typeof(Feline_Skill));
            data.AddLast(Feline_Skill_);
            var Skill_Params_8__ = new MhwStructDataContainer<Skill_Params_8_>(Skill_Params_8_.LoadData(reader), typeof(Skill_Params_8_));
            data.AddLast(Skill_Params_8__);
        }
    }
}
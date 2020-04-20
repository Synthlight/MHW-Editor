using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Monsters {
    public partial class MonsterRandomSize : MhwMultiStructItem {
        public const ulong InitialOffset = 0;
        public const string EncryptionKey = null;

        public partial class Monster_Random_Sizes : MhwStructItem {
            public const ulong FixedSizeCount = 1;
            public const string DisplayName = "Monster Random Sizes";

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

            protected uint Magic_2_raw;
            public const string Magic_2_displayName = "Magic 2";
            public const int Magic_2_sortIndex = 100;
            [SortOrder(Magic_2_sortIndex)]
            [DisplayName(Magic_2_displayName)]
            [IsReadOnly]
            public virtual uint Magic_2 {
                get => Magic_2_raw;
                set {
                    if (Magic_2_raw == value) return;
                    Magic_2_raw = value;
                    OnPropertyChanged(nameof(Magic_2));
                }
            }

            protected uint Number_of_Monsters_raw;
            public const string Number_of_Monsters_displayName = "Number of Monsters";
            public const int Number_of_Monsters_sortIndex = 150;
            [SortOrder(Number_of_Monsters_sortIndex)]
            [DisplayName(Number_of_Monsters_displayName)]
            [IsReadOnly]
            public virtual uint Number_of_Monsters {
                get => Number_of_Monsters_raw;
                set {
                    if (Number_of_Monsters_raw == value) return;
                    Number_of_Monsters_raw = value;
                    OnPropertyChanged(nameof(Number_of_Monsters));
                }
            }

            public static ulong GetEntryCount(List<List<dynamic>> data) {
                return FixedSizeCount;
            }

            public static Monster_Random_Sizes LoadData(BinaryReader reader) {
                var data = new Monster_Random_Sizes();
                data.Magic_1_raw = reader.ReadUInt32();
                data.Magic_2_raw = reader.ReadUInt32();
                data.Number_of_Monsters_raw = reader.ReadUInt32();
                return data;
            }

            public override void WriteData(BinaryWriter writer) {
                writer.Write(Magic_1_raw);
                writer.Write(Magic_2_raw);
                writer.Write(Number_of_Monsters_raw);
            }
        }

        public partial class Monsters : MhwStructItem {
            public const ulong FixedSizeCount = 0;
            public const string DisplayName = "Monsters";

            protected uint Monster_Id_raw;
            public const string Monster_Id_displayName = "Monster Id";
            public const int Monster_Id_sortIndex = 50;
            [SortOrder(Monster_Id_sortIndex)]
            [DisplayName(Monster_Id_displayName)]
            [IsReadOnly]
            public virtual uint Monster_Id {
                get => Monster_Id_raw;
                set {
                    if (Monster_Id_raw == value) return;
                    Monster_Id_raw = value;
                    OnPropertyChanged(nameof(Monster_Id));
                }
            }

            protected uint Gold_Small_Crown_Limit_raw;
            public const string Gold_Small_Crown_Limit_displayName = "Gold Small Crown Limit";
            public const int Gold_Small_Crown_Limit_sortIndex = 100;
            [SortOrder(Gold_Small_Crown_Limit_sortIndex)]
            [DisplayName(Gold_Small_Crown_Limit_displayName)]
            public virtual uint Gold_Small_Crown_Limit {
                get => Gold_Small_Crown_Limit_raw;
                set {
                    if (Gold_Small_Crown_Limit_raw == value) return;
                    Gold_Small_Crown_Limit_raw = value;
                    OnPropertyChanged(nameof(Gold_Small_Crown_Limit));
                }
            }

            protected uint Silver_Crown_Limit_raw;
            public const string Silver_Crown_Limit_displayName = "Silver Crown Limit";
            public const int Silver_Crown_Limit_sortIndex = 150;
            [SortOrder(Silver_Crown_Limit_sortIndex)]
            [DisplayName(Silver_Crown_Limit_displayName)]
            public virtual uint Silver_Crown_Limit {
                get => Silver_Crown_Limit_raw;
                set {
                    if (Silver_Crown_Limit_raw == value) return;
                    Silver_Crown_Limit_raw = value;
                    OnPropertyChanged(nameof(Silver_Crown_Limit));
                }
            }

            protected uint Gold_Big_Crown_Limit_raw;
            public const string Gold_Big_Crown_Limit_displayName = "Gold Big Crown Limit";
            public const int Gold_Big_Crown_Limit_sortIndex = 200;
            [SortOrder(Gold_Big_Crown_Limit_sortIndex)]
            [DisplayName(Gold_Big_Crown_Limit_displayName)]
            public virtual uint Gold_Big_Crown_Limit {
                get => Gold_Big_Crown_Limit_raw;
                set {
                    if (Gold_Big_Crown_Limit_raw == value) return;
                    Gold_Big_Crown_Limit_raw = value;
                    OnPropertyChanged(nameof(Gold_Big_Crown_Limit));
                }
            }

            protected float Base_Size_raw;
            public const string Base_Size_displayName = "Base Size";
            public const int Base_Size_sortIndex = 250;
            [SortOrder(Base_Size_sortIndex)]
            [DisplayName(Base_Size_displayName)]
            public virtual float Base_Size {
                get => Base_Size_raw;
                set {
                    if (Base_Size_raw == value) return;
                    Base_Size_raw = value;
                    OnPropertyChanged(nameof(Base_Size));
                }
            }

            public static Monsters LoadData(BinaryReader reader) {
                var data = new Monsters();
                data.Monster_Id_raw = reader.ReadUInt32();
                data.Gold_Small_Crown_Limit_raw = reader.ReadUInt32();
                data.Silver_Crown_Limit_raw = reader.ReadUInt32();
                data.Gold_Big_Crown_Limit_raw = reader.ReadUInt32();
                data.Base_Size_raw = reader.ReadSingle();
                return data;
            }

            public override void WriteData(BinaryWriter writer) {
                writer.Write(Monster_Id_raw);
                writer.Write(Gold_Small_Crown_Limit_raw);
                writer.Write(Silver_Crown_Limit_raw);
                writer.Write(Gold_Big_Crown_Limit_raw);
                writer.Write(Base_Size_raw);
            }
        }

        public partial class Crown_Table_Count : MhwStructItem {
            public const ulong FixedSizeCount = 1;
            public const string DisplayName = "Crown Table Count";

            protected uint Number_of_Crown_Tables_raw;
            public const string Number_of_Crown_Tables_displayName = "Number of Crown Tables";
            public const int Number_of_Crown_Tables_sortIndex = 50;
            [SortOrder(Number_of_Crown_Tables_sortIndex)]
            [DisplayName(Number_of_Crown_Tables_displayName)]
            [IsReadOnly]
            public virtual uint Number_of_Crown_Tables {
                get => Number_of_Crown_Tables_raw;
                set {
                    if (Number_of_Crown_Tables_raw == value) return;
                    Number_of_Crown_Tables_raw = value;
                    OnPropertyChanged(nameof(Number_of_Crown_Tables));
                }
            }

            public static ulong GetEntryCount(List<List<dynamic>> data) {
                return FixedSizeCount;
            }

            public static Crown_Table_Count LoadData(BinaryReader reader) {
                var data = new Crown_Table_Count();
                data.Number_of_Crown_Tables_raw = reader.ReadUInt32();
                return data;
            }

            public override void WriteData(BinaryWriter writer) {
                writer.Write(Number_of_Crown_Tables_raw);
            }
        }

        public partial class Crown_Tables : MhwStructItem {
            public const ulong FixedSizeCount = 0;
            public const string DisplayName = "Crown Tables";

            protected string Name_Jap__raw;
            public const string Name_Jap__displayName = "Name (Jap)";
            public const int Name_Jap__sortIndex = 50;
            [SortOrder(Name_Jap__sortIndex)]
            [DisplayName(Name_Jap__displayName)]
            public virtual string Name_Jap_ {
                get => Name_Jap__raw;
                set {
                    if (Name_Jap__raw == value) return;
                    Name_Jap__raw = value;
                    OnPropertyChanged(nameof(Name_Jap_));
                }
            }

            protected int Crown_Size_Multiplier_1_raw;
            public const string Crown_Size_Multiplier_1_displayName = "Crown Size Multiplier 1";
            public const int Crown_Size_Multiplier_1_sortIndex = 100;
            [SortOrder(Crown_Size_Multiplier_1_sortIndex)]
            [DisplayName(Crown_Size_Multiplier_1_displayName)]
            public virtual int Crown_Size_Multiplier_1 {
                get => Crown_Size_Multiplier_1_raw;
                set {
                    if (Crown_Size_Multiplier_1_raw == value) return;
                    Crown_Size_Multiplier_1_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Multiplier_1));
                }
            }

            protected int Crown_Size_Rarity_1_raw;
            public const string Crown_Size_Rarity_1_displayName = "Crown Size Rarity 1";
            public const int Crown_Size_Rarity_1_sortIndex = 150;
            [SortOrder(Crown_Size_Rarity_1_sortIndex)]
            [DisplayName(Crown_Size_Rarity_1_displayName)]
            public virtual int Crown_Size_Rarity_1 {
                get => Crown_Size_Rarity_1_raw;
                set {
                    if (Crown_Size_Rarity_1_raw == value) return;
                    Crown_Size_Rarity_1_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Rarity_1));
                }
            }

            protected int Crown_Size_Multiplier_2_raw;
            public const string Crown_Size_Multiplier_2_displayName = "Crown Size Multiplier 2";
            public const int Crown_Size_Multiplier_2_sortIndex = 200;
            [SortOrder(Crown_Size_Multiplier_2_sortIndex)]
            [DisplayName(Crown_Size_Multiplier_2_displayName)]
            public virtual int Crown_Size_Multiplier_2 {
                get => Crown_Size_Multiplier_2_raw;
                set {
                    if (Crown_Size_Multiplier_2_raw == value) return;
                    Crown_Size_Multiplier_2_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Multiplier_2));
                }
            }

            protected int Crown_Size_Rarity_2_raw;
            public const string Crown_Size_Rarity_2_displayName = "Crown Size Rarity 2";
            public const int Crown_Size_Rarity_2_sortIndex = 250;
            [SortOrder(Crown_Size_Rarity_2_sortIndex)]
            [DisplayName(Crown_Size_Rarity_2_displayName)]
            public virtual int Crown_Size_Rarity_2 {
                get => Crown_Size_Rarity_2_raw;
                set {
                    if (Crown_Size_Rarity_2_raw == value) return;
                    Crown_Size_Rarity_2_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Rarity_2));
                }
            }

            protected int Crown_Size_Multiplier_3_raw;
            public const string Crown_Size_Multiplier_3_displayName = "Crown Size Multiplier 3";
            public const int Crown_Size_Multiplier_3_sortIndex = 300;
            [SortOrder(Crown_Size_Multiplier_3_sortIndex)]
            [DisplayName(Crown_Size_Multiplier_3_displayName)]
            public virtual int Crown_Size_Multiplier_3 {
                get => Crown_Size_Multiplier_3_raw;
                set {
                    if (Crown_Size_Multiplier_3_raw == value) return;
                    Crown_Size_Multiplier_3_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Multiplier_3));
                }
            }

            protected int Crown_Size_Rarity_3_raw;
            public const string Crown_Size_Rarity_3_displayName = "Crown Size Rarity 3";
            public const int Crown_Size_Rarity_3_sortIndex = 350;
            [SortOrder(Crown_Size_Rarity_3_sortIndex)]
            [DisplayName(Crown_Size_Rarity_3_displayName)]
            public virtual int Crown_Size_Rarity_3 {
                get => Crown_Size_Rarity_3_raw;
                set {
                    if (Crown_Size_Rarity_3_raw == value) return;
                    Crown_Size_Rarity_3_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Rarity_3));
                }
            }

            protected int Crown_Size_Multiplier_4_raw;
            public const string Crown_Size_Multiplier_4_displayName = "Crown Size Multiplier 4";
            public const int Crown_Size_Multiplier_4_sortIndex = 400;
            [SortOrder(Crown_Size_Multiplier_4_sortIndex)]
            [DisplayName(Crown_Size_Multiplier_4_displayName)]
            public virtual int Crown_Size_Multiplier_4 {
                get => Crown_Size_Multiplier_4_raw;
                set {
                    if (Crown_Size_Multiplier_4_raw == value) return;
                    Crown_Size_Multiplier_4_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Multiplier_4));
                }
            }

            protected int Crown_Size_Rarity_4_raw;
            public const string Crown_Size_Rarity_4_displayName = "Crown Size Rarity 4";
            public const int Crown_Size_Rarity_4_sortIndex = 450;
            [SortOrder(Crown_Size_Rarity_4_sortIndex)]
            [DisplayName(Crown_Size_Rarity_4_displayName)]
            public virtual int Crown_Size_Rarity_4 {
                get => Crown_Size_Rarity_4_raw;
                set {
                    if (Crown_Size_Rarity_4_raw == value) return;
                    Crown_Size_Rarity_4_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Rarity_4));
                }
            }

            protected int Crown_Size_Multiplier_5_raw;
            public const string Crown_Size_Multiplier_5_displayName = "Crown Size Multiplier 5";
            public const int Crown_Size_Multiplier_5_sortIndex = 500;
            [SortOrder(Crown_Size_Multiplier_5_sortIndex)]
            [DisplayName(Crown_Size_Multiplier_5_displayName)]
            public virtual int Crown_Size_Multiplier_5 {
                get => Crown_Size_Multiplier_5_raw;
                set {
                    if (Crown_Size_Multiplier_5_raw == value) return;
                    Crown_Size_Multiplier_5_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Multiplier_5));
                }
            }

            protected int Crown_Size_Rarity_5_raw;
            public const string Crown_Size_Rarity_5_displayName = "Crown Size Rarity 5";
            public const int Crown_Size_Rarity_5_sortIndex = 550;
            [SortOrder(Crown_Size_Rarity_5_sortIndex)]
            [DisplayName(Crown_Size_Rarity_5_displayName)]
            public virtual int Crown_Size_Rarity_5 {
                get => Crown_Size_Rarity_5_raw;
                set {
                    if (Crown_Size_Rarity_5_raw == value) return;
                    Crown_Size_Rarity_5_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Rarity_5));
                }
            }

            protected int Crown_Size_Multiplier_6_raw;
            public const string Crown_Size_Multiplier_6_displayName = "Crown Size Multiplier 6";
            public const int Crown_Size_Multiplier_6_sortIndex = 600;
            [SortOrder(Crown_Size_Multiplier_6_sortIndex)]
            [DisplayName(Crown_Size_Multiplier_6_displayName)]
            public virtual int Crown_Size_Multiplier_6 {
                get => Crown_Size_Multiplier_6_raw;
                set {
                    if (Crown_Size_Multiplier_6_raw == value) return;
                    Crown_Size_Multiplier_6_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Multiplier_6));
                }
            }

            protected int Crown_Size_Rarity_6_raw;
            public const string Crown_Size_Rarity_6_displayName = "Crown Size Rarity 6";
            public const int Crown_Size_Rarity_6_sortIndex = 650;
            [SortOrder(Crown_Size_Rarity_6_sortIndex)]
            [DisplayName(Crown_Size_Rarity_6_displayName)]
            public virtual int Crown_Size_Rarity_6 {
                get => Crown_Size_Rarity_6_raw;
                set {
                    if (Crown_Size_Rarity_6_raw == value) return;
                    Crown_Size_Rarity_6_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Rarity_6));
                }
            }

            protected int Crown_Size_Multiplier_7_raw;
            public const string Crown_Size_Multiplier_7_displayName = "Crown Size Multiplier 7";
            public const int Crown_Size_Multiplier_7_sortIndex = 700;
            [SortOrder(Crown_Size_Multiplier_7_sortIndex)]
            [DisplayName(Crown_Size_Multiplier_7_displayName)]
            public virtual int Crown_Size_Multiplier_7 {
                get => Crown_Size_Multiplier_7_raw;
                set {
                    if (Crown_Size_Multiplier_7_raw == value) return;
                    Crown_Size_Multiplier_7_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Multiplier_7));
                }
            }

            protected int Crown_Size_Rarity_7_raw;
            public const string Crown_Size_Rarity_7_displayName = "Crown Size Rarity 7";
            public const int Crown_Size_Rarity_7_sortIndex = 750;
            [SortOrder(Crown_Size_Rarity_7_sortIndex)]
            [DisplayName(Crown_Size_Rarity_7_displayName)]
            public virtual int Crown_Size_Rarity_7 {
                get => Crown_Size_Rarity_7_raw;
                set {
                    if (Crown_Size_Rarity_7_raw == value) return;
                    Crown_Size_Rarity_7_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Rarity_7));
                }
            }

            protected int Crown_Size_Multiplier_8_raw;
            public const string Crown_Size_Multiplier_8_displayName = "Crown Size Multiplier 8";
            public const int Crown_Size_Multiplier_8_sortIndex = 800;
            [SortOrder(Crown_Size_Multiplier_8_sortIndex)]
            [DisplayName(Crown_Size_Multiplier_8_displayName)]
            public virtual int Crown_Size_Multiplier_8 {
                get => Crown_Size_Multiplier_8_raw;
                set {
                    if (Crown_Size_Multiplier_8_raw == value) return;
                    Crown_Size_Multiplier_8_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Multiplier_8));
                }
            }

            protected int Crown_Size_Rarity_8_raw;
            public const string Crown_Size_Rarity_8_displayName = "Crown Size Rarity 8";
            public const int Crown_Size_Rarity_8_sortIndex = 850;
            [SortOrder(Crown_Size_Rarity_8_sortIndex)]
            [DisplayName(Crown_Size_Rarity_8_displayName)]
            public virtual int Crown_Size_Rarity_8 {
                get => Crown_Size_Rarity_8_raw;
                set {
                    if (Crown_Size_Rarity_8_raw == value) return;
                    Crown_Size_Rarity_8_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Rarity_8));
                }
            }

            protected int Crown_Size_Multiplier_9_raw;
            public const string Crown_Size_Multiplier_9_displayName = "Crown Size Multiplier 9";
            public const int Crown_Size_Multiplier_9_sortIndex = 900;
            [SortOrder(Crown_Size_Multiplier_9_sortIndex)]
            [DisplayName(Crown_Size_Multiplier_9_displayName)]
            public virtual int Crown_Size_Multiplier_9 {
                get => Crown_Size_Multiplier_9_raw;
                set {
                    if (Crown_Size_Multiplier_9_raw == value) return;
                    Crown_Size_Multiplier_9_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Multiplier_9));
                }
            }

            protected int Crown_Size_Rarity_9_raw;
            public const string Crown_Size_Rarity_9_displayName = "Crown Size Rarity 9";
            public const int Crown_Size_Rarity_9_sortIndex = 950;
            [SortOrder(Crown_Size_Rarity_9_sortIndex)]
            [DisplayName(Crown_Size_Rarity_9_displayName)]
            public virtual int Crown_Size_Rarity_9 {
                get => Crown_Size_Rarity_9_raw;
                set {
                    if (Crown_Size_Rarity_9_raw == value) return;
                    Crown_Size_Rarity_9_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Rarity_9));
                }
            }

            protected int Crown_Size_Multiplier_10_raw;
            public const string Crown_Size_Multiplier_10_displayName = "Crown Size Multiplier 10";
            public const int Crown_Size_Multiplier_10_sortIndex = 1000;
            [SortOrder(Crown_Size_Multiplier_10_sortIndex)]
            [DisplayName(Crown_Size_Multiplier_10_displayName)]
            public virtual int Crown_Size_Multiplier_10 {
                get => Crown_Size_Multiplier_10_raw;
                set {
                    if (Crown_Size_Multiplier_10_raw == value) return;
                    Crown_Size_Multiplier_10_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Multiplier_10));
                }
            }

            protected int Crown_Size_Rarity_10_raw;
            public const string Crown_Size_Rarity_10_displayName = "Crown Size Rarity 10";
            public const int Crown_Size_Rarity_10_sortIndex = 1050;
            [SortOrder(Crown_Size_Rarity_10_sortIndex)]
            [DisplayName(Crown_Size_Rarity_10_displayName)]
            public virtual int Crown_Size_Rarity_10 {
                get => Crown_Size_Rarity_10_raw;
                set {
                    if (Crown_Size_Rarity_10_raw == value) return;
                    Crown_Size_Rarity_10_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Rarity_10));
                }
            }

            protected int Crown_Size_Multiplier_11_raw;
            public const string Crown_Size_Multiplier_11_displayName = "Crown Size Multiplier 11";
            public const int Crown_Size_Multiplier_11_sortIndex = 1100;
            [SortOrder(Crown_Size_Multiplier_11_sortIndex)]
            [DisplayName(Crown_Size_Multiplier_11_displayName)]
            public virtual int Crown_Size_Multiplier_11 {
                get => Crown_Size_Multiplier_11_raw;
                set {
                    if (Crown_Size_Multiplier_11_raw == value) return;
                    Crown_Size_Multiplier_11_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Multiplier_11));
                }
            }

            protected int Crown_Size_Rarity_11_raw;
            public const string Crown_Size_Rarity_11_displayName = "Crown Size Rarity 11";
            public const int Crown_Size_Rarity_11_sortIndex = 1150;
            [SortOrder(Crown_Size_Rarity_11_sortIndex)]
            [DisplayName(Crown_Size_Rarity_11_displayName)]
            public virtual int Crown_Size_Rarity_11 {
                get => Crown_Size_Rarity_11_raw;
                set {
                    if (Crown_Size_Rarity_11_raw == value) return;
                    Crown_Size_Rarity_11_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Rarity_11));
                }
            }

            protected int Crown_Size_Multiplier_12_raw;
            public const string Crown_Size_Multiplier_12_displayName = "Crown Size Multiplier 12";
            public const int Crown_Size_Multiplier_12_sortIndex = 1200;
            [SortOrder(Crown_Size_Multiplier_12_sortIndex)]
            [DisplayName(Crown_Size_Multiplier_12_displayName)]
            public virtual int Crown_Size_Multiplier_12 {
                get => Crown_Size_Multiplier_12_raw;
                set {
                    if (Crown_Size_Multiplier_12_raw == value) return;
                    Crown_Size_Multiplier_12_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Multiplier_12));
                }
            }

            protected int Crown_Size_Rarity_12_raw;
            public const string Crown_Size_Rarity_12_displayName = "Crown Size Rarity 12";
            public const int Crown_Size_Rarity_12_sortIndex = 1250;
            [SortOrder(Crown_Size_Rarity_12_sortIndex)]
            [DisplayName(Crown_Size_Rarity_12_displayName)]
            public virtual int Crown_Size_Rarity_12 {
                get => Crown_Size_Rarity_12_raw;
                set {
                    if (Crown_Size_Rarity_12_raw == value) return;
                    Crown_Size_Rarity_12_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Rarity_12));
                }
            }

            protected int Crown_Size_Multiplier_13_raw;
            public const string Crown_Size_Multiplier_13_displayName = "Crown Size Multiplier 13";
            public const int Crown_Size_Multiplier_13_sortIndex = 1300;
            [SortOrder(Crown_Size_Multiplier_13_sortIndex)]
            [DisplayName(Crown_Size_Multiplier_13_displayName)]
            public virtual int Crown_Size_Multiplier_13 {
                get => Crown_Size_Multiplier_13_raw;
                set {
                    if (Crown_Size_Multiplier_13_raw == value) return;
                    Crown_Size_Multiplier_13_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Multiplier_13));
                }
            }

            protected int Crown_Size_Rarity_13_raw;
            public const string Crown_Size_Rarity_13_displayName = "Crown Size Rarity 13";
            public const int Crown_Size_Rarity_13_sortIndex = 1350;
            [SortOrder(Crown_Size_Rarity_13_sortIndex)]
            [DisplayName(Crown_Size_Rarity_13_displayName)]
            public virtual int Crown_Size_Rarity_13 {
                get => Crown_Size_Rarity_13_raw;
                set {
                    if (Crown_Size_Rarity_13_raw == value) return;
                    Crown_Size_Rarity_13_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Rarity_13));
                }
            }

            protected int Crown_Size_Multiplier_14_raw;
            public const string Crown_Size_Multiplier_14_displayName = "Crown Size Multiplier 14";
            public const int Crown_Size_Multiplier_14_sortIndex = 1400;
            [SortOrder(Crown_Size_Multiplier_14_sortIndex)]
            [DisplayName(Crown_Size_Multiplier_14_displayName)]
            public virtual int Crown_Size_Multiplier_14 {
                get => Crown_Size_Multiplier_14_raw;
                set {
                    if (Crown_Size_Multiplier_14_raw == value) return;
                    Crown_Size_Multiplier_14_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Multiplier_14));
                }
            }

            protected int Crown_Size_Rarity_14_raw;
            public const string Crown_Size_Rarity_14_displayName = "Crown Size Rarity 14";
            public const int Crown_Size_Rarity_14_sortIndex = 1450;
            [SortOrder(Crown_Size_Rarity_14_sortIndex)]
            [DisplayName(Crown_Size_Rarity_14_displayName)]
            public virtual int Crown_Size_Rarity_14 {
                get => Crown_Size_Rarity_14_raw;
                set {
                    if (Crown_Size_Rarity_14_raw == value) return;
                    Crown_Size_Rarity_14_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Rarity_14));
                }
            }

            protected int Crown_Size_Multiplier_15_raw;
            public const string Crown_Size_Multiplier_15_displayName = "Crown Size Multiplier 15";
            public const int Crown_Size_Multiplier_15_sortIndex = 1500;
            [SortOrder(Crown_Size_Multiplier_15_sortIndex)]
            [DisplayName(Crown_Size_Multiplier_15_displayName)]
            public virtual int Crown_Size_Multiplier_15 {
                get => Crown_Size_Multiplier_15_raw;
                set {
                    if (Crown_Size_Multiplier_15_raw == value) return;
                    Crown_Size_Multiplier_15_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Multiplier_15));
                }
            }

            protected int Crown_Size_Rarity_15_raw;
            public const string Crown_Size_Rarity_15_displayName = "Crown Size Rarity 15";
            public const int Crown_Size_Rarity_15_sortIndex = 1550;
            [SortOrder(Crown_Size_Rarity_15_sortIndex)]
            [DisplayName(Crown_Size_Rarity_15_displayName)]
            public virtual int Crown_Size_Rarity_15 {
                get => Crown_Size_Rarity_15_raw;
                set {
                    if (Crown_Size_Rarity_15_raw == value) return;
                    Crown_Size_Rarity_15_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Rarity_15));
                }
            }

            protected int Crown_Size_Multiplier_16_raw;
            public const string Crown_Size_Multiplier_16_displayName = "Crown Size Multiplier 16";
            public const int Crown_Size_Multiplier_16_sortIndex = 1600;
            [SortOrder(Crown_Size_Multiplier_16_sortIndex)]
            [DisplayName(Crown_Size_Multiplier_16_displayName)]
            public virtual int Crown_Size_Multiplier_16 {
                get => Crown_Size_Multiplier_16_raw;
                set {
                    if (Crown_Size_Multiplier_16_raw == value) return;
                    Crown_Size_Multiplier_16_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Multiplier_16));
                }
            }

            protected int Crown_Size_Rarity_16_raw;
            public const string Crown_Size_Rarity_16_displayName = "Crown Size Rarity 16";
            public const int Crown_Size_Rarity_16_sortIndex = 1650;
            [SortOrder(Crown_Size_Rarity_16_sortIndex)]
            [DisplayName(Crown_Size_Rarity_16_displayName)]
            public virtual int Crown_Size_Rarity_16 {
                get => Crown_Size_Rarity_16_raw;
                set {
                    if (Crown_Size_Rarity_16_raw == value) return;
                    Crown_Size_Rarity_16_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Rarity_16));
                }
            }

            protected int Crown_Size_Multiplier_17_raw;
            public const string Crown_Size_Multiplier_17_displayName = "Crown Size Multiplier 17";
            public const int Crown_Size_Multiplier_17_sortIndex = 1700;
            [SortOrder(Crown_Size_Multiplier_17_sortIndex)]
            [DisplayName(Crown_Size_Multiplier_17_displayName)]
            public virtual int Crown_Size_Multiplier_17 {
                get => Crown_Size_Multiplier_17_raw;
                set {
                    if (Crown_Size_Multiplier_17_raw == value) return;
                    Crown_Size_Multiplier_17_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Multiplier_17));
                }
            }

            protected int Crown_Size_Rarity_17_raw;
            public const string Crown_Size_Rarity_17_displayName = "Crown Size Rarity 17";
            public const int Crown_Size_Rarity_17_sortIndex = 1750;
            [SortOrder(Crown_Size_Rarity_17_sortIndex)]
            [DisplayName(Crown_Size_Rarity_17_displayName)]
            public virtual int Crown_Size_Rarity_17 {
                get => Crown_Size_Rarity_17_raw;
                set {
                    if (Crown_Size_Rarity_17_raw == value) return;
                    Crown_Size_Rarity_17_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Rarity_17));
                }
            }

            protected int Crown_Size_Multiplier_18_raw;
            public const string Crown_Size_Multiplier_18_displayName = "Crown Size Multiplier 18";
            public const int Crown_Size_Multiplier_18_sortIndex = 1800;
            [SortOrder(Crown_Size_Multiplier_18_sortIndex)]
            [DisplayName(Crown_Size_Multiplier_18_displayName)]
            public virtual int Crown_Size_Multiplier_18 {
                get => Crown_Size_Multiplier_18_raw;
                set {
                    if (Crown_Size_Multiplier_18_raw == value) return;
                    Crown_Size_Multiplier_18_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Multiplier_18));
                }
            }

            protected int Crown_Size_Rarity_18_raw;
            public const string Crown_Size_Rarity_18_displayName = "Crown Size Rarity 18";
            public const int Crown_Size_Rarity_18_sortIndex = 1850;
            [SortOrder(Crown_Size_Rarity_18_sortIndex)]
            [DisplayName(Crown_Size_Rarity_18_displayName)]
            public virtual int Crown_Size_Rarity_18 {
                get => Crown_Size_Rarity_18_raw;
                set {
                    if (Crown_Size_Rarity_18_raw == value) return;
                    Crown_Size_Rarity_18_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Rarity_18));
                }
            }

            protected int Crown_Size_Multiplier_19_raw;
            public const string Crown_Size_Multiplier_19_displayName = "Crown Size Multiplier 19";
            public const int Crown_Size_Multiplier_19_sortIndex = 1900;
            [SortOrder(Crown_Size_Multiplier_19_sortIndex)]
            [DisplayName(Crown_Size_Multiplier_19_displayName)]
            public virtual int Crown_Size_Multiplier_19 {
                get => Crown_Size_Multiplier_19_raw;
                set {
                    if (Crown_Size_Multiplier_19_raw == value) return;
                    Crown_Size_Multiplier_19_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Multiplier_19));
                }
            }

            protected int Crown_Size_Rarity_19_raw;
            public const string Crown_Size_Rarity_19_displayName = "Crown Size Rarity 19";
            public const int Crown_Size_Rarity_19_sortIndex = 1950;
            [SortOrder(Crown_Size_Rarity_19_sortIndex)]
            [DisplayName(Crown_Size_Rarity_19_displayName)]
            public virtual int Crown_Size_Rarity_19 {
                get => Crown_Size_Rarity_19_raw;
                set {
                    if (Crown_Size_Rarity_19_raw == value) return;
                    Crown_Size_Rarity_19_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Rarity_19));
                }
            }

            protected int Crown_Size_Multiplier_20_raw;
            public const string Crown_Size_Multiplier_20_displayName = "Crown Size Multiplier 20";
            public const int Crown_Size_Multiplier_20_sortIndex = 2000;
            [SortOrder(Crown_Size_Multiplier_20_sortIndex)]
            [DisplayName(Crown_Size_Multiplier_20_displayName)]
            public virtual int Crown_Size_Multiplier_20 {
                get => Crown_Size_Multiplier_20_raw;
                set {
                    if (Crown_Size_Multiplier_20_raw == value) return;
                    Crown_Size_Multiplier_20_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Multiplier_20));
                }
            }

            protected int Crown_Size_Rarity_20_raw;
            public const string Crown_Size_Rarity_20_displayName = "Crown Size Rarity 20";
            public const int Crown_Size_Rarity_20_sortIndex = 2050;
            [SortOrder(Crown_Size_Rarity_20_sortIndex)]
            [DisplayName(Crown_Size_Rarity_20_displayName)]
            public virtual int Crown_Size_Rarity_20 {
                get => Crown_Size_Rarity_20_raw;
                set {
                    if (Crown_Size_Rarity_20_raw == value) return;
                    Crown_Size_Rarity_20_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Rarity_20));
                }
            }

            protected int Crown_Size_Multiplier_21_raw;
            public const string Crown_Size_Multiplier_21_displayName = "Crown Size Multiplier 21";
            public const int Crown_Size_Multiplier_21_sortIndex = 2100;
            [SortOrder(Crown_Size_Multiplier_21_sortIndex)]
            [DisplayName(Crown_Size_Multiplier_21_displayName)]
            public virtual int Crown_Size_Multiplier_21 {
                get => Crown_Size_Multiplier_21_raw;
                set {
                    if (Crown_Size_Multiplier_21_raw == value) return;
                    Crown_Size_Multiplier_21_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Multiplier_21));
                }
            }

            protected int Crown_Size_Rarity_21_raw;
            public const string Crown_Size_Rarity_21_displayName = "Crown Size Rarity 21";
            public const int Crown_Size_Rarity_21_sortIndex = 2150;
            [SortOrder(Crown_Size_Rarity_21_sortIndex)]
            [DisplayName(Crown_Size_Rarity_21_displayName)]
            public virtual int Crown_Size_Rarity_21 {
                get => Crown_Size_Rarity_21_raw;
                set {
                    if (Crown_Size_Rarity_21_raw == value) return;
                    Crown_Size_Rarity_21_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Rarity_21));
                }
            }

            protected int Crown_Size_Multiplier_22_raw;
            public const string Crown_Size_Multiplier_22_displayName = "Crown Size Multiplier 22";
            public const int Crown_Size_Multiplier_22_sortIndex = 2200;
            [SortOrder(Crown_Size_Multiplier_22_sortIndex)]
            [DisplayName(Crown_Size_Multiplier_22_displayName)]
            public virtual int Crown_Size_Multiplier_22 {
                get => Crown_Size_Multiplier_22_raw;
                set {
                    if (Crown_Size_Multiplier_22_raw == value) return;
                    Crown_Size_Multiplier_22_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Multiplier_22));
                }
            }

            protected int Crown_Size_Rarity_22_raw;
            public const string Crown_Size_Rarity_22_displayName = "Crown Size Rarity 22";
            public const int Crown_Size_Rarity_22_sortIndex = 2250;
            [SortOrder(Crown_Size_Rarity_22_sortIndex)]
            [DisplayName(Crown_Size_Rarity_22_displayName)]
            public virtual int Crown_Size_Rarity_22 {
                get => Crown_Size_Rarity_22_raw;
                set {
                    if (Crown_Size_Rarity_22_raw == value) return;
                    Crown_Size_Rarity_22_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Rarity_22));
                }
            }

            protected int Crown_Size_Multiplier_23_raw;
            public const string Crown_Size_Multiplier_23_displayName = "Crown Size Multiplier 23";
            public const int Crown_Size_Multiplier_23_sortIndex = 2300;
            [SortOrder(Crown_Size_Multiplier_23_sortIndex)]
            [DisplayName(Crown_Size_Multiplier_23_displayName)]
            public virtual int Crown_Size_Multiplier_23 {
                get => Crown_Size_Multiplier_23_raw;
                set {
                    if (Crown_Size_Multiplier_23_raw == value) return;
                    Crown_Size_Multiplier_23_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Multiplier_23));
                }
            }

            protected int Crown_Size_Rarity_23_raw;
            public const string Crown_Size_Rarity_23_displayName = "Crown Size Rarity 23";
            public const int Crown_Size_Rarity_23_sortIndex = 2350;
            [SortOrder(Crown_Size_Rarity_23_sortIndex)]
            [DisplayName(Crown_Size_Rarity_23_displayName)]
            public virtual int Crown_Size_Rarity_23 {
                get => Crown_Size_Rarity_23_raw;
                set {
                    if (Crown_Size_Rarity_23_raw == value) return;
                    Crown_Size_Rarity_23_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Rarity_23));
                }
            }

            protected int Crown_Size_Multiplier_24_raw;
            public const string Crown_Size_Multiplier_24_displayName = "Crown Size Multiplier 24";
            public const int Crown_Size_Multiplier_24_sortIndex = 2400;
            [SortOrder(Crown_Size_Multiplier_24_sortIndex)]
            [DisplayName(Crown_Size_Multiplier_24_displayName)]
            public virtual int Crown_Size_Multiplier_24 {
                get => Crown_Size_Multiplier_24_raw;
                set {
                    if (Crown_Size_Multiplier_24_raw == value) return;
                    Crown_Size_Multiplier_24_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Multiplier_24));
                }
            }

            protected int Crown_Size_Rarity_24_raw;
            public const string Crown_Size_Rarity_24_displayName = "Crown Size Rarity 24";
            public const int Crown_Size_Rarity_24_sortIndex = 2450;
            [SortOrder(Crown_Size_Rarity_24_sortIndex)]
            [DisplayName(Crown_Size_Rarity_24_displayName)]
            public virtual int Crown_Size_Rarity_24 {
                get => Crown_Size_Rarity_24_raw;
                set {
                    if (Crown_Size_Rarity_24_raw == value) return;
                    Crown_Size_Rarity_24_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Rarity_24));
                }
            }

            protected int Crown_Size_Multiplier_25_raw;
            public const string Crown_Size_Multiplier_25_displayName = "Crown Size Multiplier 25";
            public const int Crown_Size_Multiplier_25_sortIndex = 2500;
            [SortOrder(Crown_Size_Multiplier_25_sortIndex)]
            [DisplayName(Crown_Size_Multiplier_25_displayName)]
            public virtual int Crown_Size_Multiplier_25 {
                get => Crown_Size_Multiplier_25_raw;
                set {
                    if (Crown_Size_Multiplier_25_raw == value) return;
                    Crown_Size_Multiplier_25_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Multiplier_25));
                }
            }

            protected int Crown_Size_Rarity_25_raw;
            public const string Crown_Size_Rarity_25_displayName = "Crown Size Rarity 25";
            public const int Crown_Size_Rarity_25_sortIndex = 2550;
            [SortOrder(Crown_Size_Rarity_25_sortIndex)]
            [DisplayName(Crown_Size_Rarity_25_displayName)]
            public virtual int Crown_Size_Rarity_25 {
                get => Crown_Size_Rarity_25_raw;
                set {
                    if (Crown_Size_Rarity_25_raw == value) return;
                    Crown_Size_Rarity_25_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Rarity_25));
                }
            }

            protected int Crown_Size_Multiplier_26_raw;
            public const string Crown_Size_Multiplier_26_displayName = "Crown Size Multiplier 26";
            public const int Crown_Size_Multiplier_26_sortIndex = 2600;
            [SortOrder(Crown_Size_Multiplier_26_sortIndex)]
            [DisplayName(Crown_Size_Multiplier_26_displayName)]
            public virtual int Crown_Size_Multiplier_26 {
                get => Crown_Size_Multiplier_26_raw;
                set {
                    if (Crown_Size_Multiplier_26_raw == value) return;
                    Crown_Size_Multiplier_26_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Multiplier_26));
                }
            }

            protected int Crown_Size_Rarity_26_raw;
            public const string Crown_Size_Rarity_26_displayName = "Crown Size Rarity 26";
            public const int Crown_Size_Rarity_26_sortIndex = 2650;
            [SortOrder(Crown_Size_Rarity_26_sortIndex)]
            [DisplayName(Crown_Size_Rarity_26_displayName)]
            public virtual int Crown_Size_Rarity_26 {
                get => Crown_Size_Rarity_26_raw;
                set {
                    if (Crown_Size_Rarity_26_raw == value) return;
                    Crown_Size_Rarity_26_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Rarity_26));
                }
            }

            protected int Crown_Size_Multiplier_27_raw;
            public const string Crown_Size_Multiplier_27_displayName = "Crown Size Multiplier 27";
            public const int Crown_Size_Multiplier_27_sortIndex = 2700;
            [SortOrder(Crown_Size_Multiplier_27_sortIndex)]
            [DisplayName(Crown_Size_Multiplier_27_displayName)]
            public virtual int Crown_Size_Multiplier_27 {
                get => Crown_Size_Multiplier_27_raw;
                set {
                    if (Crown_Size_Multiplier_27_raw == value) return;
                    Crown_Size_Multiplier_27_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Multiplier_27));
                }
            }

            protected int Crown_Size_Rarity_27_raw;
            public const string Crown_Size_Rarity_27_displayName = "Crown Size Rarity 27";
            public const int Crown_Size_Rarity_27_sortIndex = 2750;
            [SortOrder(Crown_Size_Rarity_27_sortIndex)]
            [DisplayName(Crown_Size_Rarity_27_displayName)]
            public virtual int Crown_Size_Rarity_27 {
                get => Crown_Size_Rarity_27_raw;
                set {
                    if (Crown_Size_Rarity_27_raw == value) return;
                    Crown_Size_Rarity_27_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Rarity_27));
                }
            }

            protected int Crown_Size_Multiplier_28_raw;
            public const string Crown_Size_Multiplier_28_displayName = "Crown Size Multiplier 28";
            public const int Crown_Size_Multiplier_28_sortIndex = 2800;
            [SortOrder(Crown_Size_Multiplier_28_sortIndex)]
            [DisplayName(Crown_Size_Multiplier_28_displayName)]
            public virtual int Crown_Size_Multiplier_28 {
                get => Crown_Size_Multiplier_28_raw;
                set {
                    if (Crown_Size_Multiplier_28_raw == value) return;
                    Crown_Size_Multiplier_28_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Multiplier_28));
                }
            }

            protected int Crown_Size_Rarity_28_raw;
            public const string Crown_Size_Rarity_28_displayName = "Crown Size Rarity 28";
            public const int Crown_Size_Rarity_28_sortIndex = 2850;
            [SortOrder(Crown_Size_Rarity_28_sortIndex)]
            [DisplayName(Crown_Size_Rarity_28_displayName)]
            public virtual int Crown_Size_Rarity_28 {
                get => Crown_Size_Rarity_28_raw;
                set {
                    if (Crown_Size_Rarity_28_raw == value) return;
                    Crown_Size_Rarity_28_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Rarity_28));
                }
            }

            protected int Crown_Size_Multiplier_29_raw;
            public const string Crown_Size_Multiplier_29_displayName = "Crown Size Multiplier 29";
            public const int Crown_Size_Multiplier_29_sortIndex = 2900;
            [SortOrder(Crown_Size_Multiplier_29_sortIndex)]
            [DisplayName(Crown_Size_Multiplier_29_displayName)]
            public virtual int Crown_Size_Multiplier_29 {
                get => Crown_Size_Multiplier_29_raw;
                set {
                    if (Crown_Size_Multiplier_29_raw == value) return;
                    Crown_Size_Multiplier_29_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Multiplier_29));
                }
            }

            protected int Crown_Size_Rarity_29_raw;
            public const string Crown_Size_Rarity_29_displayName = "Crown Size Rarity 29";
            public const int Crown_Size_Rarity_29_sortIndex = 2950;
            [SortOrder(Crown_Size_Rarity_29_sortIndex)]
            [DisplayName(Crown_Size_Rarity_29_displayName)]
            public virtual int Crown_Size_Rarity_29 {
                get => Crown_Size_Rarity_29_raw;
                set {
                    if (Crown_Size_Rarity_29_raw == value) return;
                    Crown_Size_Rarity_29_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Rarity_29));
                }
            }

            protected int Crown_Size_Multiplier_30_raw;
            public const string Crown_Size_Multiplier_30_displayName = "Crown Size Multiplier 30";
            public const int Crown_Size_Multiplier_30_sortIndex = 3000;
            [SortOrder(Crown_Size_Multiplier_30_sortIndex)]
            [DisplayName(Crown_Size_Multiplier_30_displayName)]
            public virtual int Crown_Size_Multiplier_30 {
                get => Crown_Size_Multiplier_30_raw;
                set {
                    if (Crown_Size_Multiplier_30_raw == value) return;
                    Crown_Size_Multiplier_30_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Multiplier_30));
                }
            }

            protected int Crown_Size_Rarity_30_raw;
            public const string Crown_Size_Rarity_30_displayName = "Crown Size Rarity 30";
            public const int Crown_Size_Rarity_30_sortIndex = 3050;
            [SortOrder(Crown_Size_Rarity_30_sortIndex)]
            [DisplayName(Crown_Size_Rarity_30_displayName)]
            public virtual int Crown_Size_Rarity_30 {
                get => Crown_Size_Rarity_30_raw;
                set {
                    if (Crown_Size_Rarity_30_raw == value) return;
                    Crown_Size_Rarity_30_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Rarity_30));
                }
            }

            protected int Crown_Size_Multiplier_31_raw;
            public const string Crown_Size_Multiplier_31_displayName = "Crown Size Multiplier 31";
            public const int Crown_Size_Multiplier_31_sortIndex = 3100;
            [SortOrder(Crown_Size_Multiplier_31_sortIndex)]
            [DisplayName(Crown_Size_Multiplier_31_displayName)]
            public virtual int Crown_Size_Multiplier_31 {
                get => Crown_Size_Multiplier_31_raw;
                set {
                    if (Crown_Size_Multiplier_31_raw == value) return;
                    Crown_Size_Multiplier_31_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Multiplier_31));
                }
            }

            protected int Crown_Size_Rarity_31_raw;
            public const string Crown_Size_Rarity_31_displayName = "Crown Size Rarity 31";
            public const int Crown_Size_Rarity_31_sortIndex = 3150;
            [SortOrder(Crown_Size_Rarity_31_sortIndex)]
            [DisplayName(Crown_Size_Rarity_31_displayName)]
            public virtual int Crown_Size_Rarity_31 {
                get => Crown_Size_Rarity_31_raw;
                set {
                    if (Crown_Size_Rarity_31_raw == value) return;
                    Crown_Size_Rarity_31_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Rarity_31));
                }
            }

            protected int Crown_Size_Multiplier_32_raw;
            public const string Crown_Size_Multiplier_32_displayName = "Crown Size Multiplier 32";
            public const int Crown_Size_Multiplier_32_sortIndex = 3200;
            [SortOrder(Crown_Size_Multiplier_32_sortIndex)]
            [DisplayName(Crown_Size_Multiplier_32_displayName)]
            public virtual int Crown_Size_Multiplier_32 {
                get => Crown_Size_Multiplier_32_raw;
                set {
                    if (Crown_Size_Multiplier_32_raw == value) return;
                    Crown_Size_Multiplier_32_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Multiplier_32));
                }
            }

            protected int Crown_Size_Rarity_32_raw;
            public const string Crown_Size_Rarity_32_displayName = "Crown Size Rarity 32";
            public const int Crown_Size_Rarity_32_sortIndex = 3250;
            [SortOrder(Crown_Size_Rarity_32_sortIndex)]
            [DisplayName(Crown_Size_Rarity_32_displayName)]
            public virtual int Crown_Size_Rarity_32 {
                get => Crown_Size_Rarity_32_raw;
                set {
                    if (Crown_Size_Rarity_32_raw == value) return;
                    Crown_Size_Rarity_32_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Rarity_32));
                }
            }

            protected int Crown_Size_Multiplier_33_raw;
            public const string Crown_Size_Multiplier_33_displayName = "Crown Size Multiplier 33";
            public const int Crown_Size_Multiplier_33_sortIndex = 3300;
            [SortOrder(Crown_Size_Multiplier_33_sortIndex)]
            [DisplayName(Crown_Size_Multiplier_33_displayName)]
            public virtual int Crown_Size_Multiplier_33 {
                get => Crown_Size_Multiplier_33_raw;
                set {
                    if (Crown_Size_Multiplier_33_raw == value) return;
                    Crown_Size_Multiplier_33_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Multiplier_33));
                }
            }

            protected int Crown_Size_Rarity_33_raw;
            public const string Crown_Size_Rarity_33_displayName = "Crown Size Rarity 33";
            public const int Crown_Size_Rarity_33_sortIndex = 3350;
            [SortOrder(Crown_Size_Rarity_33_sortIndex)]
            [DisplayName(Crown_Size_Rarity_33_displayName)]
            public virtual int Crown_Size_Rarity_33 {
                get => Crown_Size_Rarity_33_raw;
                set {
                    if (Crown_Size_Rarity_33_raw == value) return;
                    Crown_Size_Rarity_33_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Rarity_33));
                }
            }

            protected int Crown_Size_Multiplier_34_raw;
            public const string Crown_Size_Multiplier_34_displayName = "Crown Size Multiplier 34";
            public const int Crown_Size_Multiplier_34_sortIndex = 3400;
            [SortOrder(Crown_Size_Multiplier_34_sortIndex)]
            [DisplayName(Crown_Size_Multiplier_34_displayName)]
            public virtual int Crown_Size_Multiplier_34 {
                get => Crown_Size_Multiplier_34_raw;
                set {
                    if (Crown_Size_Multiplier_34_raw == value) return;
                    Crown_Size_Multiplier_34_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Multiplier_34));
                }
            }

            protected int Crown_Size_Rarity_34_raw;
            public const string Crown_Size_Rarity_34_displayName = "Crown Size Rarity 34";
            public const int Crown_Size_Rarity_34_sortIndex = 3450;
            [SortOrder(Crown_Size_Rarity_34_sortIndex)]
            [DisplayName(Crown_Size_Rarity_34_displayName)]
            public virtual int Crown_Size_Rarity_34 {
                get => Crown_Size_Rarity_34_raw;
                set {
                    if (Crown_Size_Rarity_34_raw == value) return;
                    Crown_Size_Rarity_34_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Rarity_34));
                }
            }

            protected int Crown_Size_Multiplier_35_raw;
            public const string Crown_Size_Multiplier_35_displayName = "Crown Size Multiplier 35";
            public const int Crown_Size_Multiplier_35_sortIndex = 3500;
            [SortOrder(Crown_Size_Multiplier_35_sortIndex)]
            [DisplayName(Crown_Size_Multiplier_35_displayName)]
            public virtual int Crown_Size_Multiplier_35 {
                get => Crown_Size_Multiplier_35_raw;
                set {
                    if (Crown_Size_Multiplier_35_raw == value) return;
                    Crown_Size_Multiplier_35_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Multiplier_35));
                }
            }

            protected int Crown_Size_Rarity_35_raw;
            public const string Crown_Size_Rarity_35_displayName = "Crown Size Rarity 35";
            public const int Crown_Size_Rarity_35_sortIndex = 3550;
            [SortOrder(Crown_Size_Rarity_35_sortIndex)]
            [DisplayName(Crown_Size_Rarity_35_displayName)]
            public virtual int Crown_Size_Rarity_35 {
                get => Crown_Size_Rarity_35_raw;
                set {
                    if (Crown_Size_Rarity_35_raw == value) return;
                    Crown_Size_Rarity_35_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Rarity_35));
                }
            }

            protected int Crown_Size_Multiplier_36_raw;
            public const string Crown_Size_Multiplier_36_displayName = "Crown Size Multiplier 36";
            public const int Crown_Size_Multiplier_36_sortIndex = 3600;
            [SortOrder(Crown_Size_Multiplier_36_sortIndex)]
            [DisplayName(Crown_Size_Multiplier_36_displayName)]
            public virtual int Crown_Size_Multiplier_36 {
                get => Crown_Size_Multiplier_36_raw;
                set {
                    if (Crown_Size_Multiplier_36_raw == value) return;
                    Crown_Size_Multiplier_36_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Multiplier_36));
                }
            }

            protected int Crown_Size_Rarity_36_raw;
            public const string Crown_Size_Rarity_36_displayName = "Crown Size Rarity 36";
            public const int Crown_Size_Rarity_36_sortIndex = 3650;
            [SortOrder(Crown_Size_Rarity_36_sortIndex)]
            [DisplayName(Crown_Size_Rarity_36_displayName)]
            public virtual int Crown_Size_Rarity_36 {
                get => Crown_Size_Rarity_36_raw;
                set {
                    if (Crown_Size_Rarity_36_raw == value) return;
                    Crown_Size_Rarity_36_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Rarity_36));
                }
            }

            protected int Crown_Size_Multiplier_37_raw;
            public const string Crown_Size_Multiplier_37_displayName = "Crown Size Multiplier 37";
            public const int Crown_Size_Multiplier_37_sortIndex = 3700;
            [SortOrder(Crown_Size_Multiplier_37_sortIndex)]
            [DisplayName(Crown_Size_Multiplier_37_displayName)]
            public virtual int Crown_Size_Multiplier_37 {
                get => Crown_Size_Multiplier_37_raw;
                set {
                    if (Crown_Size_Multiplier_37_raw == value) return;
                    Crown_Size_Multiplier_37_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Multiplier_37));
                }
            }

            protected int Crown_Size_Rarity_37_raw;
            public const string Crown_Size_Rarity_37_displayName = "Crown Size Rarity 37";
            public const int Crown_Size_Rarity_37_sortIndex = 3750;
            [SortOrder(Crown_Size_Rarity_37_sortIndex)]
            [DisplayName(Crown_Size_Rarity_37_displayName)]
            public virtual int Crown_Size_Rarity_37 {
                get => Crown_Size_Rarity_37_raw;
                set {
                    if (Crown_Size_Rarity_37_raw == value) return;
                    Crown_Size_Rarity_37_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Rarity_37));
                }
            }

            protected int Crown_Size_Multiplier_38_raw;
            public const string Crown_Size_Multiplier_38_displayName = "Crown Size Multiplier 38";
            public const int Crown_Size_Multiplier_38_sortIndex = 3800;
            [SortOrder(Crown_Size_Multiplier_38_sortIndex)]
            [DisplayName(Crown_Size_Multiplier_38_displayName)]
            public virtual int Crown_Size_Multiplier_38 {
                get => Crown_Size_Multiplier_38_raw;
                set {
                    if (Crown_Size_Multiplier_38_raw == value) return;
                    Crown_Size_Multiplier_38_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Multiplier_38));
                }
            }

            protected int Crown_Size_Rarity_38_raw;
            public const string Crown_Size_Rarity_38_displayName = "Crown Size Rarity 38";
            public const int Crown_Size_Rarity_38_sortIndex = 3850;
            [SortOrder(Crown_Size_Rarity_38_sortIndex)]
            [DisplayName(Crown_Size_Rarity_38_displayName)]
            public virtual int Crown_Size_Rarity_38 {
                get => Crown_Size_Rarity_38_raw;
                set {
                    if (Crown_Size_Rarity_38_raw == value) return;
                    Crown_Size_Rarity_38_raw = value;
                    OnPropertyChanged(nameof(Crown_Size_Rarity_38));
                }
            }

            public static Crown_Tables LoadData(BinaryReader reader) {
                var data = new Crown_Tables();
                data.Name_Jap__raw = reader.ReadNullTermString();
                data.Crown_Size_Multiplier_1_raw = reader.ReadInt32();
                data.Crown_Size_Rarity_1_raw = reader.ReadInt32();
                data.Crown_Size_Multiplier_2_raw = reader.ReadInt32();
                data.Crown_Size_Rarity_2_raw = reader.ReadInt32();
                data.Crown_Size_Multiplier_3_raw = reader.ReadInt32();
                data.Crown_Size_Rarity_3_raw = reader.ReadInt32();
                data.Crown_Size_Multiplier_4_raw = reader.ReadInt32();
                data.Crown_Size_Rarity_4_raw = reader.ReadInt32();
                data.Crown_Size_Multiplier_5_raw = reader.ReadInt32();
                data.Crown_Size_Rarity_5_raw = reader.ReadInt32();
                data.Crown_Size_Multiplier_6_raw = reader.ReadInt32();
                data.Crown_Size_Rarity_6_raw = reader.ReadInt32();
                data.Crown_Size_Multiplier_7_raw = reader.ReadInt32();
                data.Crown_Size_Rarity_7_raw = reader.ReadInt32();
                data.Crown_Size_Multiplier_8_raw = reader.ReadInt32();
                data.Crown_Size_Rarity_8_raw = reader.ReadInt32();
                data.Crown_Size_Multiplier_9_raw = reader.ReadInt32();
                data.Crown_Size_Rarity_9_raw = reader.ReadInt32();
                data.Crown_Size_Multiplier_10_raw = reader.ReadInt32();
                data.Crown_Size_Rarity_10_raw = reader.ReadInt32();
                data.Crown_Size_Multiplier_11_raw = reader.ReadInt32();
                data.Crown_Size_Rarity_11_raw = reader.ReadInt32();
                data.Crown_Size_Multiplier_12_raw = reader.ReadInt32();
                data.Crown_Size_Rarity_12_raw = reader.ReadInt32();
                data.Crown_Size_Multiplier_13_raw = reader.ReadInt32();
                data.Crown_Size_Rarity_13_raw = reader.ReadInt32();
                data.Crown_Size_Multiplier_14_raw = reader.ReadInt32();
                data.Crown_Size_Rarity_14_raw = reader.ReadInt32();
                data.Crown_Size_Multiplier_15_raw = reader.ReadInt32();
                data.Crown_Size_Rarity_15_raw = reader.ReadInt32();
                data.Crown_Size_Multiplier_16_raw = reader.ReadInt32();
                data.Crown_Size_Rarity_16_raw = reader.ReadInt32();
                data.Crown_Size_Multiplier_17_raw = reader.ReadInt32();
                data.Crown_Size_Rarity_17_raw = reader.ReadInt32();
                data.Crown_Size_Multiplier_18_raw = reader.ReadInt32();
                data.Crown_Size_Rarity_18_raw = reader.ReadInt32();
                data.Crown_Size_Multiplier_19_raw = reader.ReadInt32();
                data.Crown_Size_Rarity_19_raw = reader.ReadInt32();
                data.Crown_Size_Multiplier_20_raw = reader.ReadInt32();
                data.Crown_Size_Rarity_20_raw = reader.ReadInt32();
                data.Crown_Size_Multiplier_21_raw = reader.ReadInt32();
                data.Crown_Size_Rarity_21_raw = reader.ReadInt32();
                data.Crown_Size_Multiplier_22_raw = reader.ReadInt32();
                data.Crown_Size_Rarity_22_raw = reader.ReadInt32();
                data.Crown_Size_Multiplier_23_raw = reader.ReadInt32();
                data.Crown_Size_Rarity_23_raw = reader.ReadInt32();
                data.Crown_Size_Multiplier_24_raw = reader.ReadInt32();
                data.Crown_Size_Rarity_24_raw = reader.ReadInt32();
                data.Crown_Size_Multiplier_25_raw = reader.ReadInt32();
                data.Crown_Size_Rarity_25_raw = reader.ReadInt32();
                data.Crown_Size_Multiplier_26_raw = reader.ReadInt32();
                data.Crown_Size_Rarity_26_raw = reader.ReadInt32();
                data.Crown_Size_Multiplier_27_raw = reader.ReadInt32();
                data.Crown_Size_Rarity_27_raw = reader.ReadInt32();
                data.Crown_Size_Multiplier_28_raw = reader.ReadInt32();
                data.Crown_Size_Rarity_28_raw = reader.ReadInt32();
                data.Crown_Size_Multiplier_29_raw = reader.ReadInt32();
                data.Crown_Size_Rarity_29_raw = reader.ReadInt32();
                data.Crown_Size_Multiplier_30_raw = reader.ReadInt32();
                data.Crown_Size_Rarity_30_raw = reader.ReadInt32();
                data.Crown_Size_Multiplier_31_raw = reader.ReadInt32();
                data.Crown_Size_Rarity_31_raw = reader.ReadInt32();
                data.Crown_Size_Multiplier_32_raw = reader.ReadInt32();
                data.Crown_Size_Rarity_32_raw = reader.ReadInt32();
                data.Crown_Size_Multiplier_33_raw = reader.ReadInt32();
                data.Crown_Size_Rarity_33_raw = reader.ReadInt32();
                data.Crown_Size_Multiplier_34_raw = reader.ReadInt32();
                data.Crown_Size_Rarity_34_raw = reader.ReadInt32();
                data.Crown_Size_Multiplier_35_raw = reader.ReadInt32();
                data.Crown_Size_Rarity_35_raw = reader.ReadInt32();
                data.Crown_Size_Multiplier_36_raw = reader.ReadInt32();
                data.Crown_Size_Rarity_36_raw = reader.ReadInt32();
                data.Crown_Size_Multiplier_37_raw = reader.ReadInt32();
                data.Crown_Size_Rarity_37_raw = reader.ReadInt32();
                data.Crown_Size_Multiplier_38_raw = reader.ReadInt32();
                data.Crown_Size_Rarity_38_raw = reader.ReadInt32();
                return data;
            }

            public override void WriteData(BinaryWriter writer) {
                writer.Write(Name_Jap__raw.ToNullTermCharArray());
                writer.Write(Crown_Size_Multiplier_1_raw);
                writer.Write(Crown_Size_Rarity_1_raw);
                writer.Write(Crown_Size_Multiplier_2_raw);
                writer.Write(Crown_Size_Rarity_2_raw);
                writer.Write(Crown_Size_Multiplier_3_raw);
                writer.Write(Crown_Size_Rarity_3_raw);
                writer.Write(Crown_Size_Multiplier_4_raw);
                writer.Write(Crown_Size_Rarity_4_raw);
                writer.Write(Crown_Size_Multiplier_5_raw);
                writer.Write(Crown_Size_Rarity_5_raw);
                writer.Write(Crown_Size_Multiplier_6_raw);
                writer.Write(Crown_Size_Rarity_6_raw);
                writer.Write(Crown_Size_Multiplier_7_raw);
                writer.Write(Crown_Size_Rarity_7_raw);
                writer.Write(Crown_Size_Multiplier_8_raw);
                writer.Write(Crown_Size_Rarity_8_raw);
                writer.Write(Crown_Size_Multiplier_9_raw);
                writer.Write(Crown_Size_Rarity_9_raw);
                writer.Write(Crown_Size_Multiplier_10_raw);
                writer.Write(Crown_Size_Rarity_10_raw);
                writer.Write(Crown_Size_Multiplier_11_raw);
                writer.Write(Crown_Size_Rarity_11_raw);
                writer.Write(Crown_Size_Multiplier_12_raw);
                writer.Write(Crown_Size_Rarity_12_raw);
                writer.Write(Crown_Size_Multiplier_13_raw);
                writer.Write(Crown_Size_Rarity_13_raw);
                writer.Write(Crown_Size_Multiplier_14_raw);
                writer.Write(Crown_Size_Rarity_14_raw);
                writer.Write(Crown_Size_Multiplier_15_raw);
                writer.Write(Crown_Size_Rarity_15_raw);
                writer.Write(Crown_Size_Multiplier_16_raw);
                writer.Write(Crown_Size_Rarity_16_raw);
                writer.Write(Crown_Size_Multiplier_17_raw);
                writer.Write(Crown_Size_Rarity_17_raw);
                writer.Write(Crown_Size_Multiplier_18_raw);
                writer.Write(Crown_Size_Rarity_18_raw);
                writer.Write(Crown_Size_Multiplier_19_raw);
                writer.Write(Crown_Size_Rarity_19_raw);
                writer.Write(Crown_Size_Multiplier_20_raw);
                writer.Write(Crown_Size_Rarity_20_raw);
                writer.Write(Crown_Size_Multiplier_21_raw);
                writer.Write(Crown_Size_Rarity_21_raw);
                writer.Write(Crown_Size_Multiplier_22_raw);
                writer.Write(Crown_Size_Rarity_22_raw);
                writer.Write(Crown_Size_Multiplier_23_raw);
                writer.Write(Crown_Size_Rarity_23_raw);
                writer.Write(Crown_Size_Multiplier_24_raw);
                writer.Write(Crown_Size_Rarity_24_raw);
                writer.Write(Crown_Size_Multiplier_25_raw);
                writer.Write(Crown_Size_Rarity_25_raw);
                writer.Write(Crown_Size_Multiplier_26_raw);
                writer.Write(Crown_Size_Rarity_26_raw);
                writer.Write(Crown_Size_Multiplier_27_raw);
                writer.Write(Crown_Size_Rarity_27_raw);
                writer.Write(Crown_Size_Multiplier_28_raw);
                writer.Write(Crown_Size_Rarity_28_raw);
                writer.Write(Crown_Size_Multiplier_29_raw);
                writer.Write(Crown_Size_Rarity_29_raw);
                writer.Write(Crown_Size_Multiplier_30_raw);
                writer.Write(Crown_Size_Rarity_30_raw);
                writer.Write(Crown_Size_Multiplier_31_raw);
                writer.Write(Crown_Size_Rarity_31_raw);
                writer.Write(Crown_Size_Multiplier_32_raw);
                writer.Write(Crown_Size_Rarity_32_raw);
                writer.Write(Crown_Size_Multiplier_33_raw);
                writer.Write(Crown_Size_Rarity_33_raw);
                writer.Write(Crown_Size_Multiplier_34_raw);
                writer.Write(Crown_Size_Rarity_34_raw);
                writer.Write(Crown_Size_Multiplier_35_raw);
                writer.Write(Crown_Size_Rarity_35_raw);
                writer.Write(Crown_Size_Multiplier_36_raw);
                writer.Write(Crown_Size_Rarity_36_raw);
                writer.Write(Crown_Size_Multiplier_37_raw);
                writer.Write(Crown_Size_Rarity_37_raw);
                writer.Write(Crown_Size_Multiplier_38_raw);
                writer.Write(Crown_Size_Rarity_38_raw);
            }
        }

        public static void SaveData(List<List<dynamic>> data, string targetFile) {
            SaveData(data, targetFile, EncryptionKey);
        }

        public static List<List<dynamic>> LoadData(string targetFile) {
            using var reader = new BinaryReader(OpenFile(targetFile, EncryptionKey));
            var data = new List<List<dynamic>>();
            var Monster_Random_Sizes_list = new List<dynamic>();
            for (ulong i = 0; i < Monster_Random_Sizes.GetEntryCount(data); i++) {
                var item = Monster_Random_Sizes.LoadData(reader);
                item.index = i;
                Monster_Random_Sizes_list.Add(item);
            }
            data.Add(Monster_Random_Sizes_list);
            var Monsters_list = new List<dynamic>();
            for (ulong i = 0; i < Monsters.GetEntryCount(data); i++) {
                var item = Monsters.LoadData(reader);
                item.index = i;
                Monsters_list.Add(item);
            }
            data.Add(Monsters_list);
            var Crown_Table_Count_list = new List<dynamic>();
            for (ulong i = 0; i < Crown_Table_Count.GetEntryCount(data); i++) {
                var item = Crown_Table_Count.LoadData(reader);
                item.index = i;
                Crown_Table_Count_list.Add(item);
            }
            data.Add(Crown_Table_Count_list);
            var Crown_Tables_list = new List<dynamic>();
            for (ulong i = 0; i < Crown_Tables.GetEntryCount(data); i++) {
                var item = Crown_Tables.LoadData(reader);
                item.index = i;
                Crown_Tables_list.Add(item);
            }
            data.Add(Crown_Tables_list);
            return data;
        }
    }
}
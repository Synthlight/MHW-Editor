using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Monsters {
    public partial class MonsterRandomSize {
        public override string EncryptionKey => null;

        public partial class Monster_Random_Sizes : MhwStructItem {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Monster Random Sizes";

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

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Monster_Random_Sizes LoadData(BinaryReader reader, ulong i) {
                var data = new Monster_Random_Sizes();
                data.Index = i;
                data.Magic_1_raw = reader.ReadUInt32();
                data.Magic_2_raw = reader.ReadUInt32();
                data.Number_of_Monsters_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Magic_1_raw);
                writer.Write(Magic_2_raw);
                writer.Write(Number_of_Monsters_raw);
            }
        }

        public partial class Monsters : MhwStructItem {
            public const ulong FixedSizeCount = 0;
            public const string GridName = "Monsters";
            public const bool IsAddingAllowed = true;

            [SortOrder(-1)]
            [IsReadOnly]
            [DisplayName("X")]
            public string Delete => "X";

            protected uint Monster_Id_raw;
            public const string Monster_Id_displayName = "Monster Id";
            public const int Monster_Id_sortIndex = 50;
            [SortOrder(Monster_Id_sortIndex)]
            [DisplayName(Monster_Id_displayName)]
            [DataSource(DataSourceType.Monsters)]
            [IsReadOnly]
            public virtual uint Monster_Id {
                get => Monster_Id_raw;
                set {
                    if (Monster_Id_raw == value) return;
                    Monster_Id_raw = value;
                    OnPropertyChanged(nameof(Monster_Id));
                    OnPropertyChanged(nameof(Monster_Id_button));
                }
            }

            [SortOrder(Monster_Id_sortIndex)]
            [DisplayName(Monster_Id_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Monster_Id_button => DataHelper.monsterNames[MainWindow.locale].TryGet(Monster_Id).ToStringWithId(Monster_Id);

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

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
                var countTarget = (Monster_Random_Sizes) lastStruct.Last();
                var count = (ulong) countTarget.Number_of_Monsters;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Monsters LoadData(BinaryReader reader, ulong i) {
                var data = new Monsters();
                data.Index = i;
                data.Monster_Id_raw = reader.ReadUInt32();
                data.Gold_Small_Crown_Limit_raw = reader.ReadUInt32();
                data.Silver_Crown_Limit_raw = reader.ReadUInt32();
                data.Gold_Big_Crown_Limit_raw = reader.ReadUInt32();
                data.Base_Size_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Monster_Id_raw);
                writer.Write(Gold_Small_Crown_Limit_raw);
                writer.Write(Silver_Crown_Limit_raw);
                writer.Write(Gold_Big_Crown_Limit_raw);
                writer.Write(Base_Size_raw);
            }
        }

        public partial class Crown_Table_Count : MhwStructItem {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Crown Table Count";
            public const bool IsHidden = true;

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

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Crown_Table_Count LoadData(BinaryReader reader, ulong i) {
                var data = new Crown_Table_Count();
                data.Index = i;
                data.Number_of_Crown_Tables_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Number_of_Crown_Tables_raw);
            }
        }

        public partial class Crown_Tables : MhwStructItem {
            public const ulong FixedSizeCount = 0;
            public const string GridName = "Crown Tables";
            public const bool IsAddingAllowed = true;

            [SortOrder(-1)]
            [IsReadOnly]
            [DisplayName("X")]
            public string Delete => "X";

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

            public partial class Crown_Sizes : MhwStructItem {
                public const ulong FixedSizeCount = 38;
                public const string GridName = "Crown Sizes";

                protected int Crown_Size_Multiplier_raw;
                public const string Crown_Size_Multiplier_displayName = "Crown Size Multiplier";
                public const int Crown_Size_Multiplier_sortIndex = 50;
                [SortOrder(Crown_Size_Multiplier_sortIndex)]
                [DisplayName(Crown_Size_Multiplier_displayName)]
                public virtual int Crown_Size_Multiplier {
                    get => Crown_Size_Multiplier_raw;
                    set {
                        if (Crown_Size_Multiplier_raw == value) return;
                        Crown_Size_Multiplier_raw = value;
                        OnPropertyChanged(nameof(Crown_Size_Multiplier));
                    }
                }

                protected int Crown_Size_Rarity_raw;
                public const string Crown_Size_Rarity_displayName = "Crown Size Rarity";
                public const int Crown_Size_Rarity_sortIndex = 100;
                [SortOrder(Crown_Size_Rarity_sortIndex)]
                [DisplayName(Crown_Size_Rarity_displayName)]
                public virtual int Crown_Size_Rarity {
                    get => Crown_Size_Rarity_raw;
                    set {
                        if (Crown_Size_Rarity_raw == value) return;
                        Crown_Size_Rarity_raw = value;
                        OnPropertyChanged(nameof(Crown_Size_Rarity));
                    }
                }

                public static ObservableCollection<Crown_Sizes> LoadData(BinaryReader reader, Crown_Tables parent) {
                    var list = new ObservableCollection<Crown_Sizes>();
                    var count = 38UL;
                    for (ulong i = 0; i < count; i++) {
                        list.Add(LoadData(reader, i, parent));
                    }
                    return list;
                }

                public static Crown_Sizes LoadData(BinaryReader reader, ulong i, Crown_Tables parent) {
                    var data = new Crown_Sizes();
                    data.Index = i;
                    data.Crown_Size_Multiplier_raw = reader.ReadInt32();
                    data.Crown_Size_Rarity_raw = reader.ReadInt32();
                    return data;
                }

                public void WriteData(BinaryWriter writer, Crown_Tables parent) {
                    writer.Write(Crown_Size_Multiplier_raw);
                    writer.Write(Crown_Size_Rarity_raw);
                }
            }

            public const string Crown_Sizes_displayName = "Crown Sizes";
            public const int Crown_Sizes_sortIndex = 100;
            [SortOrder(Crown_Sizes_sortIndex)]
            [DisplayName(Crown_Sizes_displayName)]
            public virtual ObservableCollection<Crown_Sizes> Crown_Sizes_raw { get; protected set; }

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
                var countTarget = (Crown_Table_Count) lastStruct.Last();
                var count = (ulong) countTarget.Number_of_Crown_Tables;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Crown_Tables LoadData(BinaryReader reader, ulong i) {
                var data = new Crown_Tables();
                data.Index = i;
                data.Name_Jap__raw = reader.ReadNullTermString();
                data.Crown_Sizes_raw = Crown_Sizes.LoadData(reader, data);
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Name_Jap__raw.ToNullTermCharArray());
                foreach (var obj in Crown_Sizes_raw) {
                    obj.WriteData(writer, this);
                }
            }
        }

        public override void LoadFile(string targetFile) {
            using var reader = new BinaryReader(OpenFile(targetFile, EncryptionKey), Encoding.UTF8);
            data = new LinkedList<MhwStructDataContainer>();
            var Monster_Random_Sizes_ = new MhwStructDataContainer(Monster_Random_Sizes.LoadData(reader, null), typeof(Monster_Random_Sizes));
            data.AddLast(Monster_Random_Sizes_);
            var Monsters_ = new MhwStructDataContainer(Monsters.LoadData(reader, Monster_Random_Sizes_.list), typeof(Monsters));
            Monsters_.SetCountTargetToUpdate(Monster_Random_Sizes_, -1, "Number_of_Monsters");
            data.AddLast(Monsters_);
            var Crown_Table_Count_ = new MhwStructDataContainer(Crown_Table_Count.LoadData(reader, null), typeof(Crown_Table_Count));
            data.AddLast(Crown_Table_Count_);
            var Crown_Tables_ = new MhwStructDataContainer(Crown_Tables.LoadData(reader, Crown_Table_Count_.list), typeof(Crown_Tables));
            Crown_Tables_.SetCountTargetToUpdate(Crown_Table_Count_, -1, "Number_of_Crown_Tables");
            data.AddLast(Crown_Tables_);
        }
    }
}
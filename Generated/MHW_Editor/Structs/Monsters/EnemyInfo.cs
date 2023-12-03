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
    public partial class EnemyInfo {
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
                    ChangedItems.Add(nameof(Magic_2));
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

        public partial class Entries : MhwStructItem, IWriteData, IHasChildren {
            public const ulong FixedSizeCount = 0;
            public const string GridName = "Entries";

            protected uint Monster_raw;
            public const string Monster_displayName = "Monster";
            public const int Monster_sortIndex = 50;
            [SortOrder(Monster_sortIndex)]
            [DisplayName(Monster_displayName)]
            [DataSource(DataSourceType.Monsters)]
            public virtual uint Monster {
                get => Monster_raw;
                set {
                    if (Monster_raw == value) return;
                    Monster_raw = value;
                    ChangedItems.Add(nameof(Monster));
                    OnPropertyChanged(nameof(Monster));
                    OnPropertyChanged(nameof(Monster_button));
                }
            }

            [SortOrder(Monster_sortIndex)]
            [DisplayName(Monster_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Monster_button => DataHelper.monsterNames[MainWindow.locale].TryGet(Monster).ToStringWithId(Monster);

            public partial class Available_Stages : MhwStructItem, IWriteDataInner<Entries> {
                public const ulong FixedSizeCount = 1;
                public const string GridName = "Available Stages";

                protected uint Stage_1_raw;
                public const string Stage_1_displayName = "Stage 1";
                public const int Stage_1_sortIndex = 50;
                [SortOrder(Stage_1_sortIndex)]
                [DisplayName(Stage_1_displayName)]
                public virtual MHW_Template.Misc.Stage Stage_1 {
                    get => (MHW_Template.Misc.Stage) Stage_1_raw;
                    set {
                        if ((MHW_Template.Misc.Stage) Stage_1_raw == value) return;
                        Stage_1_raw = (uint) value;
                        ChangedItems.Add(nameof(Stage_1));
                        OnPropertyChanged(nameof(Stage_1));
                    }
                }

                protected uint Stage_2_raw;
                public const string Stage_2_displayName = "Stage 2";
                public const int Stage_2_sortIndex = 100;
                [SortOrder(Stage_2_sortIndex)]
                [DisplayName(Stage_2_displayName)]
                public virtual MHW_Template.Misc.Stage Stage_2 {
                    get => (MHW_Template.Misc.Stage) Stage_2_raw;
                    set {
                        if ((MHW_Template.Misc.Stage) Stage_2_raw == value) return;
                        Stage_2_raw = (uint) value;
                        ChangedItems.Add(nameof(Stage_2));
                        OnPropertyChanged(nameof(Stage_2));
                    }
                }

                protected uint Stage_3_raw;
                public const string Stage_3_displayName = "Stage 3";
                public const int Stage_3_sortIndex = 150;
                [SortOrder(Stage_3_sortIndex)]
                [DisplayName(Stage_3_displayName)]
                public virtual MHW_Template.Misc.Stage Stage_3 {
                    get => (MHW_Template.Misc.Stage) Stage_3_raw;
                    set {
                        if ((MHW_Template.Misc.Stage) Stage_3_raw == value) return;
                        Stage_3_raw = (uint) value;
                        ChangedItems.Add(nameof(Stage_3));
                        OnPropertyChanged(nameof(Stage_3));
                    }
                }

                protected uint Stage_4_raw;
                public const string Stage_4_displayName = "Stage 4";
                public const int Stage_4_sortIndex = 200;
                [SortOrder(Stage_4_sortIndex)]
                [DisplayName(Stage_4_displayName)]
                public virtual MHW_Template.Misc.Stage Stage_4 {
                    get => (MHW_Template.Misc.Stage) Stage_4_raw;
                    set {
                        if ((MHW_Template.Misc.Stage) Stage_4_raw == value) return;
                        Stage_4_raw = (uint) value;
                        ChangedItems.Add(nameof(Stage_4));
                        OnPropertyChanged(nameof(Stage_4));
                    }
                }

                protected uint Stage_5_raw;
                public const string Stage_5_displayName = "Stage 5";
                public const int Stage_5_sortIndex = 250;
                [SortOrder(Stage_5_sortIndex)]
                [DisplayName(Stage_5_displayName)]
                public virtual MHW_Template.Misc.Stage Stage_5 {
                    get => (MHW_Template.Misc.Stage) Stage_5_raw;
                    set {
                        if ((MHW_Template.Misc.Stage) Stage_5_raw == value) return;
                        Stage_5_raw = (uint) value;
                        ChangedItems.Add(nameof(Stage_5));
                        OnPropertyChanged(nameof(Stage_5));
                    }
                }

                protected uint Stage_6_raw;
                public const string Stage_6_displayName = "Stage 6";
                public const int Stage_6_sortIndex = 300;
                [SortOrder(Stage_6_sortIndex)]
                [DisplayName(Stage_6_displayName)]
                public virtual MHW_Template.Misc.Stage Stage_6 {
                    get => (MHW_Template.Misc.Stage) Stage_6_raw;
                    set {
                        if ((MHW_Template.Misc.Stage) Stage_6_raw == value) return;
                        Stage_6_raw = (uint) value;
                        ChangedItems.Add(nameof(Stage_6));
                        OnPropertyChanged(nameof(Stage_6));
                    }
                }

                public const int lastSortIndex = 350;

                public static ObservableMhwStructCollection<Available_Stages> LoadData(BinaryReader reader, Entries parent) {
                    var list = new ObservableMhwStructCollection<Available_Stages>();
                    const ulong count = 1UL;
                    for (ulong i = 0; i < count; i++) {
                        list.Add(LoadData(reader, i, parent));
                    }
                    return list;
                }

                public static Available_Stages LoadData(BinaryReader reader, ulong i, Entries parent) {
                    var data = new Available_Stages();
                    data.Index = i;
                    data.Stage_1_raw = reader.ReadUInt32();
                    data.Stage_2_raw = reader.ReadUInt32();
                    data.Stage_3_raw = reader.ReadUInt32();
                    data.Stage_4_raw = reader.ReadUInt32();
                    data.Stage_5_raw = reader.ReadUInt32();
                    data.Stage_6_raw = reader.ReadUInt32();
                    return data;
                }

                public void WriteData(BinaryWriter writer, Entries parent) {
                    writer.Write(Stage_1_raw);
                    writer.Write(Stage_2_raw);
                    writer.Write(Stage_3_raw);
                    writer.Write(Stage_4_raw);
                    writer.Write(Stage_5_raw);
                    writer.Write(Stage_6_raw);
                }
            }

            public const string Stages_displayName = "Stages";
            public const int Stages_sortIndex = 100;
            [SortOrder(Stages_sortIndex)]
            [DisplayName(Stages_displayName)]
            public virtual ObservableCollection<Available_Stages> Stages_raw { get; protected set; }

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

            protected uint Unk_2_raw;
            public const string Unk_2_displayName = "Unk 2";
            public const int Unk_2_sortIndex = 200;
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

            public partial class Part_Weakness_Cut : MhwStructItem, IWriteDataInner<Entries> {
                public const ulong FixedSizeCount = 1;
                public const string GridName = "Part Weakness: Cut";

                protected uint Modifier_raw;
                public const string Modifier_displayName = "Modifier";
                public const int Modifier_sortIndex = 50;
                [SortOrder(Modifier_sortIndex)]
                [DisplayName(Modifier_displayName)]
                public virtual uint Modifier {
                    get => Modifier_raw;
                    set {
                        if (Modifier_raw == value) return;
                        Modifier_raw = value;
                        ChangedItems.Add(nameof(Modifier));
                        OnPropertyChanged(nameof(Modifier));
                    }
                }

                protected uint Part_1_raw;
                public const string Part_1_displayName = "Part 1";
                public const int Part_1_sortIndex = 100;
                [SortOrder(Part_1_sortIndex)]
                [DisplayName(Part_1_displayName)]
                public virtual uint Part_1 {
                    get => Part_1_raw;
                    set {
                        if (Part_1_raw == value) return;
                        Part_1_raw = value;
                        ChangedItems.Add(nameof(Part_1));
                        OnPropertyChanged(nameof(Part_1));
                    }
                }

                protected uint Part_2_raw;
                public const string Part_2_displayName = "Part 2";
                public const int Part_2_sortIndex = 150;
                [SortOrder(Part_2_sortIndex)]
                [DisplayName(Part_2_displayName)]
                public virtual uint Part_2 {
                    get => Part_2_raw;
                    set {
                        if (Part_2_raw == value) return;
                        Part_2_raw = value;
                        ChangedItems.Add(nameof(Part_2));
                        OnPropertyChanged(nameof(Part_2));
                    }
                }

                protected uint Part_3_raw;
                public const string Part_3_displayName = "Part 3";
                public const int Part_3_sortIndex = 200;
                [SortOrder(Part_3_sortIndex)]
                [DisplayName(Part_3_displayName)]
                public virtual uint Part_3 {
                    get => Part_3_raw;
                    set {
                        if (Part_3_raw == value) return;
                        Part_3_raw = value;
                        ChangedItems.Add(nameof(Part_3));
                        OnPropertyChanged(nameof(Part_3));
                    }
                }

                public const int lastSortIndex = 250;

                public static ObservableMhwStructCollection<Part_Weakness_Cut> LoadData(BinaryReader reader, Entries parent) {
                    var list = new ObservableMhwStructCollection<Part_Weakness_Cut>();
                    const ulong count = 1UL;
                    for (ulong i = 0; i < count; i++) {
                        list.Add(LoadData(reader, i, parent));
                    }
                    return list;
                }

                public static Part_Weakness_Cut LoadData(BinaryReader reader, ulong i, Entries parent) {
                    var data = new Part_Weakness_Cut();
                    data.Index = i;
                    data.Modifier_raw = reader.ReadUInt32();
                    data.Part_1_raw = reader.ReadUInt32();
                    data.Part_2_raw = reader.ReadUInt32();
                    data.Part_3_raw = reader.ReadUInt32();
                    return data;
                }

                public void WriteData(BinaryWriter writer, Entries parent) {
                    writer.Write(Modifier_raw);
                    writer.Write(Part_1_raw);
                    writer.Write(Part_2_raw);
                    writer.Write(Part_3_raw);
                }
            }

            public const string Part_Weakness_Cut_displayName = "Part Weakness: Cut";
            public const int Part_Weakness_Cut_sortIndex = 250;
            [SortOrder(Part_Weakness_Cut_sortIndex)]
            [DisplayName(Part_Weakness_Cut_displayName)]
            public virtual ObservableCollection<Part_Weakness_Cut> Part_Weakness_Cut_raw { get; protected set; }

            public partial class Part_Weakness_Blunt : MhwStructItem, IWriteDataInner<Entries> {
                public const ulong FixedSizeCount = 1;
                public const string GridName = "Part Weakness: Blunt";

                protected uint Modifier_raw;
                public const string Modifier_displayName = "Modifier";
                public const int Modifier_sortIndex = 50;
                [SortOrder(Modifier_sortIndex)]
                [DisplayName(Modifier_displayName)]
                public virtual uint Modifier {
                    get => Modifier_raw;
                    set {
                        if (Modifier_raw == value) return;
                        Modifier_raw = value;
                        ChangedItems.Add(nameof(Modifier));
                        OnPropertyChanged(nameof(Modifier));
                    }
                }

                protected uint Part_1_raw;
                public const string Part_1_displayName = "Part 1";
                public const int Part_1_sortIndex = 100;
                [SortOrder(Part_1_sortIndex)]
                [DisplayName(Part_1_displayName)]
                public virtual uint Part_1 {
                    get => Part_1_raw;
                    set {
                        if (Part_1_raw == value) return;
                        Part_1_raw = value;
                        ChangedItems.Add(nameof(Part_1));
                        OnPropertyChanged(nameof(Part_1));
                    }
                }

                protected uint Part_2_raw;
                public const string Part_2_displayName = "Part 2";
                public const int Part_2_sortIndex = 150;
                [SortOrder(Part_2_sortIndex)]
                [DisplayName(Part_2_displayName)]
                public virtual uint Part_2 {
                    get => Part_2_raw;
                    set {
                        if (Part_2_raw == value) return;
                        Part_2_raw = value;
                        ChangedItems.Add(nameof(Part_2));
                        OnPropertyChanged(nameof(Part_2));
                    }
                }

                protected uint Part_3_raw;
                public const string Part_3_displayName = "Part 3";
                public const int Part_3_sortIndex = 200;
                [SortOrder(Part_3_sortIndex)]
                [DisplayName(Part_3_displayName)]
                public virtual uint Part_3 {
                    get => Part_3_raw;
                    set {
                        if (Part_3_raw == value) return;
                        Part_3_raw = value;
                        ChangedItems.Add(nameof(Part_3));
                        OnPropertyChanged(nameof(Part_3));
                    }
                }

                public const int lastSortIndex = 250;

                public static ObservableMhwStructCollection<Part_Weakness_Blunt> LoadData(BinaryReader reader, Entries parent) {
                    var list = new ObservableMhwStructCollection<Part_Weakness_Blunt>();
                    const ulong count = 1UL;
                    for (ulong i = 0; i < count; i++) {
                        list.Add(LoadData(reader, i, parent));
                    }
                    return list;
                }

                public static Part_Weakness_Blunt LoadData(BinaryReader reader, ulong i, Entries parent) {
                    var data = new Part_Weakness_Blunt();
                    data.Index = i;
                    data.Modifier_raw = reader.ReadUInt32();
                    data.Part_1_raw = reader.ReadUInt32();
                    data.Part_2_raw = reader.ReadUInt32();
                    data.Part_3_raw = reader.ReadUInt32();
                    return data;
                }

                public void WriteData(BinaryWriter writer, Entries parent) {
                    writer.Write(Modifier_raw);
                    writer.Write(Part_1_raw);
                    writer.Write(Part_2_raw);
                    writer.Write(Part_3_raw);
                }
            }

            public const string Part_Weakness_Blunt_displayName = "Part Weakness: Blunt";
            public const int Part_Weakness_Blunt_sortIndex = 300;
            [SortOrder(Part_Weakness_Blunt_sortIndex)]
            [DisplayName(Part_Weakness_Blunt_displayName)]
            public virtual ObservableCollection<Part_Weakness_Blunt> Part_Weakness_Blunt_raw { get; protected set; }

            public partial class Part_Weakness_Shot : MhwStructItem, IWriteDataInner<Entries> {
                public const ulong FixedSizeCount = 1;
                public const string GridName = "Part Weakness: Shot";

                protected uint Modifier_raw;
                public const string Modifier_displayName = "Modifier";
                public const int Modifier_sortIndex = 50;
                [SortOrder(Modifier_sortIndex)]
                [DisplayName(Modifier_displayName)]
                public virtual uint Modifier {
                    get => Modifier_raw;
                    set {
                        if (Modifier_raw == value) return;
                        Modifier_raw = value;
                        ChangedItems.Add(nameof(Modifier));
                        OnPropertyChanged(nameof(Modifier));
                    }
                }

                protected uint Part_1_raw;
                public const string Part_1_displayName = "Part 1";
                public const int Part_1_sortIndex = 100;
                [SortOrder(Part_1_sortIndex)]
                [DisplayName(Part_1_displayName)]
                public virtual uint Part_1 {
                    get => Part_1_raw;
                    set {
                        if (Part_1_raw == value) return;
                        Part_1_raw = value;
                        ChangedItems.Add(nameof(Part_1));
                        OnPropertyChanged(nameof(Part_1));
                    }
                }

                protected uint Part_2_raw;
                public const string Part_2_displayName = "Part 2";
                public const int Part_2_sortIndex = 150;
                [SortOrder(Part_2_sortIndex)]
                [DisplayName(Part_2_displayName)]
                public virtual uint Part_2 {
                    get => Part_2_raw;
                    set {
                        if (Part_2_raw == value) return;
                        Part_2_raw = value;
                        ChangedItems.Add(nameof(Part_2));
                        OnPropertyChanged(nameof(Part_2));
                    }
                }

                protected uint Part_3_raw;
                public const string Part_3_displayName = "Part 3";
                public const int Part_3_sortIndex = 200;
                [SortOrder(Part_3_sortIndex)]
                [DisplayName(Part_3_displayName)]
                public virtual uint Part_3 {
                    get => Part_3_raw;
                    set {
                        if (Part_3_raw == value) return;
                        Part_3_raw = value;
                        ChangedItems.Add(nameof(Part_3));
                        OnPropertyChanged(nameof(Part_3));
                    }
                }

                public const int lastSortIndex = 250;

                public static ObservableMhwStructCollection<Part_Weakness_Shot> LoadData(BinaryReader reader, Entries parent) {
                    var list = new ObservableMhwStructCollection<Part_Weakness_Shot>();
                    const ulong count = 1UL;
                    for (ulong i = 0; i < count; i++) {
                        list.Add(LoadData(reader, i, parent));
                    }
                    return list;
                }

                public static Part_Weakness_Shot LoadData(BinaryReader reader, ulong i, Entries parent) {
                    var data = new Part_Weakness_Shot();
                    data.Index = i;
                    data.Modifier_raw = reader.ReadUInt32();
                    data.Part_1_raw = reader.ReadUInt32();
                    data.Part_2_raw = reader.ReadUInt32();
                    data.Part_3_raw = reader.ReadUInt32();
                    return data;
                }

                public void WriteData(BinaryWriter writer, Entries parent) {
                    writer.Write(Modifier_raw);
                    writer.Write(Part_1_raw);
                    writer.Write(Part_2_raw);
                    writer.Write(Part_3_raw);
                }
            }

            public const string Part_Weakness_Shot_displayName = "Part Weakness: Shot";
            public const int Part_Weakness_Shot_sortIndex = 350;
            [SortOrder(Part_Weakness_Shot_sortIndex)]
            [DisplayName(Part_Weakness_Shot_displayName)]
            public virtual ObservableCollection<Part_Weakness_Shot> Part_Weakness_Shot_raw { get; protected set; }

            public partial class Break_Config_1 : MhwStructItem, IWriteDataInner<Entries> {
                public const ulong FixedSizeCount = 1;
                public const string GridName = "Break Config 1";

                protected uint Name_Displayed_raw;
                public const string Name_Displayed_displayName = "Name Displayed";
                public const int Name_Displayed_sortIndex = 50;
                [SortOrder(Name_Displayed_sortIndex)]
                [DisplayName(Name_Displayed_displayName)]
                public virtual uint Name_Displayed {
                    get => Name_Displayed_raw;
                    set {
                        if (Name_Displayed_raw == value) return;
                        Name_Displayed_raw = value;
                        ChangedItems.Add(nameof(Name_Displayed));
                        OnPropertyChanged(nameof(Name_Displayed));
                    }
                }

                protected int Unk_1_raw;
                public const string Unk_1_displayName = "Unk 1";
                public const int Unk_1_sortIndex = 100;
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
                public const int Unk_2_sortIndex = 150;
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

                public const int lastSortIndex = 200;

                public static ObservableMhwStructCollection<Break_Config_1> LoadData(BinaryReader reader, Entries parent) {
                    var list = new ObservableMhwStructCollection<Break_Config_1>();
                    const ulong count = 1UL;
                    for (ulong i = 0; i < count; i++) {
                        list.Add(LoadData(reader, i, parent));
                    }
                    return list;
                }

                public static Break_Config_1 LoadData(BinaryReader reader, ulong i, Entries parent) {
                    var data = new Break_Config_1();
                    data.Index = i;
                    data.Name_Displayed_raw = reader.ReadUInt32();
                    data.Unk_1_raw = reader.ReadInt32();
                    data.Unk_2_raw = reader.ReadInt32();
                    return data;
                }

                public void WriteData(BinaryWriter writer, Entries parent) {
                    writer.Write(Name_Displayed_raw);
                    writer.Write(Unk_1_raw);
                    writer.Write(Unk_2_raw);
                }
            }

            public const string Break_Config_1_displayName = "Break Config 1";
            public const int Break_Config_1_sortIndex = 400;
            [SortOrder(Break_Config_1_sortIndex)]
            [DisplayName(Break_Config_1_displayName)]
            public virtual ObservableCollection<Break_Config_1> Break_Config_1_raw { get; protected set; }

            public partial class Break_Config_2 : MhwStructItem, IWriteDataInner<Entries> {
                public const ulong FixedSizeCount = 1;
                public const string GridName = "Break Config 2";

                protected uint Name_Displayed_raw;
                public const string Name_Displayed_displayName = "Name Displayed";
                public const int Name_Displayed_sortIndex = 50;
                [SortOrder(Name_Displayed_sortIndex)]
                [DisplayName(Name_Displayed_displayName)]
                public virtual uint Name_Displayed {
                    get => Name_Displayed_raw;
                    set {
                        if (Name_Displayed_raw == value) return;
                        Name_Displayed_raw = value;
                        ChangedItems.Add(nameof(Name_Displayed));
                        OnPropertyChanged(nameof(Name_Displayed));
                    }
                }

                protected int Unk_1_raw;
                public const string Unk_1_displayName = "Unk 1";
                public const int Unk_1_sortIndex = 100;
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
                public const int Unk_2_sortIndex = 150;
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

                public const int lastSortIndex = 200;

                public static ObservableMhwStructCollection<Break_Config_2> LoadData(BinaryReader reader, Entries parent) {
                    var list = new ObservableMhwStructCollection<Break_Config_2>();
                    const ulong count = 1UL;
                    for (ulong i = 0; i < count; i++) {
                        list.Add(LoadData(reader, i, parent));
                    }
                    return list;
                }

                public static Break_Config_2 LoadData(BinaryReader reader, ulong i, Entries parent) {
                    var data = new Break_Config_2();
                    data.Index = i;
                    data.Name_Displayed_raw = reader.ReadUInt32();
                    data.Unk_1_raw = reader.ReadInt32();
                    data.Unk_2_raw = reader.ReadInt32();
                    return data;
                }

                public void WriteData(BinaryWriter writer, Entries parent) {
                    writer.Write(Name_Displayed_raw);
                    writer.Write(Unk_1_raw);
                    writer.Write(Unk_2_raw);
                }
            }

            public const string Break_Config_2_displayName = "Break Config 2";
            public const int Break_Config_2_sortIndex = 450;
            [SortOrder(Break_Config_2_sortIndex)]
            [DisplayName(Break_Config_2_displayName)]
            public virtual ObservableCollection<Break_Config_2> Break_Config_2_raw { get; protected set; }

            public partial class Break_Config_3 : MhwStructItem, IWriteDataInner<Entries> {
                public const ulong FixedSizeCount = 1;
                public const string GridName = "Break Config 3";

                protected uint Name_Displayed_raw;
                public const string Name_Displayed_displayName = "Name Displayed";
                public const int Name_Displayed_sortIndex = 50;
                [SortOrder(Name_Displayed_sortIndex)]
                [DisplayName(Name_Displayed_displayName)]
                public virtual uint Name_Displayed {
                    get => Name_Displayed_raw;
                    set {
                        if (Name_Displayed_raw == value) return;
                        Name_Displayed_raw = value;
                        ChangedItems.Add(nameof(Name_Displayed));
                        OnPropertyChanged(nameof(Name_Displayed));
                    }
                }

                protected int Unk_1_raw;
                public const string Unk_1_displayName = "Unk 1";
                public const int Unk_1_sortIndex = 100;
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
                public const int Unk_2_sortIndex = 150;
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

                public const int lastSortIndex = 200;

                public static ObservableMhwStructCollection<Break_Config_3> LoadData(BinaryReader reader, Entries parent) {
                    var list = new ObservableMhwStructCollection<Break_Config_3>();
                    const ulong count = 1UL;
                    for (ulong i = 0; i < count; i++) {
                        list.Add(LoadData(reader, i, parent));
                    }
                    return list;
                }

                public static Break_Config_3 LoadData(BinaryReader reader, ulong i, Entries parent) {
                    var data = new Break_Config_3();
                    data.Index = i;
                    data.Name_Displayed_raw = reader.ReadUInt32();
                    data.Unk_1_raw = reader.ReadInt32();
                    data.Unk_2_raw = reader.ReadInt32();
                    return data;
                }

                public void WriteData(BinaryWriter writer, Entries parent) {
                    writer.Write(Name_Displayed_raw);
                    writer.Write(Unk_1_raw);
                    writer.Write(Unk_2_raw);
                }
            }

            public const string Break_Config_3_displayName = "Break Config 3";
            public const int Break_Config_3_sortIndex = 500;
            [SortOrder(Break_Config_3_sortIndex)]
            [DisplayName(Break_Config_3_displayName)]
            public virtual ObservableCollection<Break_Config_3> Break_Config_3_raw { get; protected set; }

            protected int Unk_3_raw;
            public const string Unk_3_displayName = "Unk 3";
            public const int Unk_3_sortIndex = 550;
            [SortOrder(Unk_3_sortIndex)]
            [DisplayName(Unk_3_displayName)]
            public virtual int Unk_3 {
                get => Unk_3_raw;
                set {
                    if (Unk_3_raw == value) return;
                    Unk_3_raw = value;
                    ChangedItems.Add(nameof(Unk_3));
                    OnPropertyChanged(nameof(Unk_3));
                }
            }

            protected int Fire_raw;
            public const string Fire_displayName = "Fire";
            public const int Fire_sortIndex = 600;
            [SortOrder(Fire_sortIndex)]
            [DisplayName(Fire_displayName)]
            public virtual int Fire {
                get => Fire_raw;
                set {
                    if (Fire_raw == value) return;
                    Fire_raw = value;
                    ChangedItems.Add(nameof(Fire));
                    OnPropertyChanged(nameof(Fire));
                }
            }

            protected int Water_raw;
            public const string Water_displayName = "Water";
            public const int Water_sortIndex = 650;
            [SortOrder(Water_sortIndex)]
            [DisplayName(Water_displayName)]
            public virtual int Water {
                get => Water_raw;
                set {
                    if (Water_raw == value) return;
                    Water_raw = value;
                    ChangedItems.Add(nameof(Water));
                    OnPropertyChanged(nameof(Water));
                }
            }

            protected int Thunder_raw;
            public const string Thunder_displayName = "Thunder";
            public const int Thunder_sortIndex = 700;
            [SortOrder(Thunder_sortIndex)]
            [DisplayName(Thunder_displayName)]
            public virtual int Thunder {
                get => Thunder_raw;
                set {
                    if (Thunder_raw == value) return;
                    Thunder_raw = value;
                    ChangedItems.Add(nameof(Thunder));
                    OnPropertyChanged(nameof(Thunder));
                }
            }

            protected int Ice_raw;
            public const string Ice_displayName = "Ice";
            public const int Ice_sortIndex = 750;
            [SortOrder(Ice_sortIndex)]
            [DisplayName(Ice_displayName)]
            public virtual int Ice {
                get => Ice_raw;
                set {
                    if (Ice_raw == value) return;
                    Ice_raw = value;
                    ChangedItems.Add(nameof(Ice));
                    OnPropertyChanged(nameof(Ice));
                }
            }

            protected int Dragon_raw;
            public const string Dragon_displayName = "Dragon";
            public const int Dragon_sortIndex = 800;
            [SortOrder(Dragon_sortIndex)]
            [DisplayName(Dragon_displayName)]
            public virtual int Dragon {
                get => Dragon_raw;
                set {
                    if (Dragon_raw == value) return;
                    Dragon_raw = value;
                    ChangedItems.Add(nameof(Dragon));
                    OnPropertyChanged(nameof(Dragon));
                }
            }

            protected int Poison_raw;
            public const string Poison_displayName = "Poison";
            public const int Poison_sortIndex = 850;
            [SortOrder(Poison_sortIndex)]
            [DisplayName(Poison_displayName)]
            public virtual int Poison {
                get => Poison_raw;
                set {
                    if (Poison_raw == value) return;
                    Poison_raw = value;
                    ChangedItems.Add(nameof(Poison));
                    OnPropertyChanged(nameof(Poison));
                }
            }

            protected int Sleep_raw;
            public const string Sleep_displayName = "Sleep";
            public const int Sleep_sortIndex = 900;
            [SortOrder(Sleep_sortIndex)]
            [DisplayName(Sleep_displayName)]
            public virtual int Sleep {
                get => Sleep_raw;
                set {
                    if (Sleep_raw == value) return;
                    Sleep_raw = value;
                    ChangedItems.Add(nameof(Sleep));
                    OnPropertyChanged(nameof(Sleep));
                }
            }

            protected int Paralysis_raw;
            public const string Paralysis_displayName = "Paralysis";
            public const int Paralysis_sortIndex = 950;
            [SortOrder(Paralysis_sortIndex)]
            [DisplayName(Paralysis_displayName)]
            public virtual int Paralysis {
                get => Paralysis_raw;
                set {
                    if (Paralysis_raw == value) return;
                    Paralysis_raw = value;
                    ChangedItems.Add(nameof(Paralysis));
                    OnPropertyChanged(nameof(Paralysis));
                }
            }

            protected int Blast_raw;
            public const string Blast_displayName = "Blast";
            public const int Blast_sortIndex = 1000;
            [SortOrder(Blast_sortIndex)]
            [DisplayName(Blast_displayName)]
            public virtual int Blast {
                get => Blast_raw;
                set {
                    if (Blast_raw == value) return;
                    Blast_raw = value;
                    ChangedItems.Add(nameof(Blast));
                    OnPropertyChanged(nameof(Blast));
                }
            }

            protected int Stun_raw;
            public const string Stun_displayName = "Stun";
            public const int Stun_sortIndex = 1050;
            [SortOrder(Stun_sortIndex)]
            [DisplayName(Stun_displayName)]
            public virtual int Stun {
                get => Stun_raw;
                set {
                    if (Stun_raw == value) return;
                    Stun_raw = value;
                    ChangedItems.Add(nameof(Stun));
                    OnPropertyChanged(nameof(Stun));
                }
            }

            protected int Conditional_Fire_raw;
            public const string Conditional_Fire_displayName = "Conditional Fire";
            public const int Conditional_Fire_sortIndex = 1100;
            [SortOrder(Conditional_Fire_sortIndex)]
            [DisplayName(Conditional_Fire_displayName)]
            public virtual int Conditional_Fire {
                get => Conditional_Fire_raw;
                set {
                    if (Conditional_Fire_raw == value) return;
                    Conditional_Fire_raw = value;
                    ChangedItems.Add(nameof(Conditional_Fire));
                    OnPropertyChanged(nameof(Conditional_Fire));
                }
            }

            protected int Conditional_Water_raw;
            public const string Conditional_Water_displayName = "Conditional Water";
            public const int Conditional_Water_sortIndex = 1150;
            [SortOrder(Conditional_Water_sortIndex)]
            [DisplayName(Conditional_Water_displayName)]
            public virtual int Conditional_Water {
                get => Conditional_Water_raw;
                set {
                    if (Conditional_Water_raw == value) return;
                    Conditional_Water_raw = value;
                    ChangedItems.Add(nameof(Conditional_Water));
                    OnPropertyChanged(nameof(Conditional_Water));
                }
            }

            protected int Conditional_Thunder_raw;
            public const string Conditional_Thunder_displayName = "Conditional Thunder";
            public const int Conditional_Thunder_sortIndex = 1200;
            [SortOrder(Conditional_Thunder_sortIndex)]
            [DisplayName(Conditional_Thunder_displayName)]
            public virtual int Conditional_Thunder {
                get => Conditional_Thunder_raw;
                set {
                    if (Conditional_Thunder_raw == value) return;
                    Conditional_Thunder_raw = value;
                    ChangedItems.Add(nameof(Conditional_Thunder));
                    OnPropertyChanged(nameof(Conditional_Thunder));
                }
            }

            protected int Conditional_Ice_raw;
            public const string Conditional_Ice_displayName = "Conditional Ice";
            public const int Conditional_Ice_sortIndex = 1250;
            [SortOrder(Conditional_Ice_sortIndex)]
            [DisplayName(Conditional_Ice_displayName)]
            public virtual int Conditional_Ice {
                get => Conditional_Ice_raw;
                set {
                    if (Conditional_Ice_raw == value) return;
                    Conditional_Ice_raw = value;
                    ChangedItems.Add(nameof(Conditional_Ice));
                    OnPropertyChanged(nameof(Conditional_Ice));
                }
            }

            protected int Conditional_Dragon_raw;
            public const string Conditional_Dragon_displayName = "Conditional Dragon";
            public const int Conditional_Dragon_sortIndex = 1300;
            [SortOrder(Conditional_Dragon_sortIndex)]
            [DisplayName(Conditional_Dragon_displayName)]
            public virtual int Conditional_Dragon {
                get => Conditional_Dragon_raw;
                set {
                    if (Conditional_Dragon_raw == value) return;
                    Conditional_Dragon_raw = value;
                    ChangedItems.Add(nameof(Conditional_Dragon));
                    OnPropertyChanged(nameof(Conditional_Dragon));
                }
            }

            protected int Condition_raw;
            public const string Condition_displayName = "Condition";
            public const int Condition_sortIndex = 1350;
            [SortOrder(Condition_sortIndex)]
            [DisplayName(Condition_displayName)]
            public virtual MHW_Template.Misc.Condition Condition {
                get => (MHW_Template.Misc.Condition) Condition_raw;
                set {
                    if ((MHW_Template.Misc.Condition) Condition_raw == value) return;
                    Condition_raw = (int) value;
                    ChangedItems.Add(nameof(Condition));
                    OnPropertyChanged(nameof(Condition));
                }
            }

            protected int Skeleton_raw;
            public const string Skeleton_displayName = "Skeleton";
            public const int Skeleton_sortIndex = 1400;
            [SortOrder(Skeleton_sortIndex)]
            [DisplayName(Skeleton_displayName)]
            public virtual int Skeleton {
                get => Skeleton_raw;
                set {
                    if (Skeleton_raw == value) return;
                    Skeleton_raw = value;
                    ChangedItems.Add(nameof(Skeleton));
                    OnPropertyChanged(nameof(Skeleton));
                }
            }

            protected int Rewards_Skeleton_raw;
            public const string Rewards_Skeleton_displayName = "Rewards Skeleton";
            public const int Rewards_Skeleton_sortIndex = 1450;
            [SortOrder(Rewards_Skeleton_sortIndex)]
            [DisplayName(Rewards_Skeleton_displayName)]
            public virtual int Rewards_Skeleton {
                get => Rewards_Skeleton_raw;
                set {
                    if (Rewards_Skeleton_raw == value) return;
                    Rewards_Skeleton_raw = value;
                    ChangedItems.Add(nameof(Rewards_Skeleton));
                    OnPropertyChanged(nameof(Rewards_Skeleton));
                }
            }

            public const int lastSortIndex = 1500;

            public IEnumerable<F> GetAllEnumerableChildrenOfType<F>() {
                if (typeof(Available_Stages).Is(typeof(F)) || typeof(Available_Stages).IsGeneric(typeof(F))) {
                    foreach (var item in Stages_raw.Cast<F>()) {
                        yield return item;
                    }
                }
                if (typeof(Part_Weakness_Cut).Is(typeof(F)) || typeof(Part_Weakness_Cut).IsGeneric(typeof(F))) {
                    foreach (var item in Part_Weakness_Cut_raw.Cast<F>()) {
                        yield return item;
                    }
                }
                if (typeof(Part_Weakness_Blunt).Is(typeof(F)) || typeof(Part_Weakness_Blunt).IsGeneric(typeof(F))) {
                    foreach (var item in Part_Weakness_Blunt_raw.Cast<F>()) {
                        yield return item;
                    }
                }
                if (typeof(Part_Weakness_Shot).Is(typeof(F)) || typeof(Part_Weakness_Shot).IsGeneric(typeof(F))) {
                    foreach (var item in Part_Weakness_Shot_raw.Cast<F>()) {
                        yield return item;
                    }
                }
                if (typeof(Break_Config_1).Is(typeof(F)) || typeof(Break_Config_1).IsGeneric(typeof(F))) {
                    foreach (var item in Break_Config_1_raw.Cast<F>()) {
                        yield return item;
                    }
                }
                if (typeof(Break_Config_2).Is(typeof(F)) || typeof(Break_Config_2).IsGeneric(typeof(F))) {
                    foreach (var item in Break_Config_2_raw.Cast<F>()) {
                        yield return item;
                    }
                }
                if (typeof(Break_Config_3).Is(typeof(F)) || typeof(Break_Config_3).IsGeneric(typeof(F))) {
                    foreach (var item in Break_Config_3_raw.Cast<F>()) {
                        yield return item;
                    }
                }
            }

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
                data.Monster_raw = reader.ReadUInt32();
                data.Stages_raw = Available_Stages.LoadData(reader, data);
                data.Unk_1_raw = reader.ReadUInt32();
                data.Unk_2_raw = reader.ReadUInt32();
                data.Part_Weakness_Cut_raw = Part_Weakness_Cut.LoadData(reader, data);
                data.Part_Weakness_Blunt_raw = Part_Weakness_Blunt.LoadData(reader, data);
                data.Part_Weakness_Shot_raw = Part_Weakness_Shot.LoadData(reader, data);
                data.Break_Config_1_raw = Break_Config_1.LoadData(reader, data);
                data.Break_Config_2_raw = Break_Config_2.LoadData(reader, data);
                data.Break_Config_3_raw = Break_Config_3.LoadData(reader, data);
                data.Unk_3_raw = reader.ReadInt32();
                data.Fire_raw = reader.ReadInt32();
                data.Water_raw = reader.ReadInt32();
                data.Thunder_raw = reader.ReadInt32();
                data.Ice_raw = reader.ReadInt32();
                data.Dragon_raw = reader.ReadInt32();
                data.Poison_raw = reader.ReadInt32();
                data.Sleep_raw = reader.ReadInt32();
                data.Paralysis_raw = reader.ReadInt32();
                data.Blast_raw = reader.ReadInt32();
                data.Stun_raw = reader.ReadInt32();
                data.Conditional_Fire_raw = reader.ReadInt32();
                data.Conditional_Water_raw = reader.ReadInt32();
                data.Conditional_Thunder_raw = reader.ReadInt32();
                data.Conditional_Ice_raw = reader.ReadInt32();
                data.Conditional_Dragon_raw = reader.ReadInt32();
                data.Condition_raw = reader.ReadInt32();
                data.Skeleton_raw = reader.ReadInt32();
                data.Rewards_Skeleton_raw = reader.ReadInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Monster_raw);
                foreach (var obj in Stages_raw) {
                    obj.WriteData(writer, this);
                }
                writer.Write(Unk_1_raw);
                writer.Write(Unk_2_raw);
                foreach (var obj in Part_Weakness_Cut_raw) {
                    obj.WriteData(writer, this);
                }
                foreach (var obj in Part_Weakness_Blunt_raw) {
                    obj.WriteData(writer, this);
                }
                foreach (var obj in Part_Weakness_Shot_raw) {
                    obj.WriteData(writer, this);
                }
                foreach (var obj in Break_Config_1_raw) {
                    obj.WriteData(writer, this);
                }
                foreach (var obj in Break_Config_2_raw) {
                    obj.WriteData(writer, this);
                }
                foreach (var obj in Break_Config_3_raw) {
                    obj.WriteData(writer, this);
                }
                writer.Write(Unk_3_raw);
                writer.Write(Fire_raw);
                writer.Write(Water_raw);
                writer.Write(Thunder_raw);
                writer.Write(Ice_raw);
                writer.Write(Dragon_raw);
                writer.Write(Poison_raw);
                writer.Write(Sleep_raw);
                writer.Write(Paralysis_raw);
                writer.Write(Blast_raw);
                writer.Write(Stun_raw);
                writer.Write(Conditional_Fire_raw);
                writer.Write(Conditional_Water_raw);
                writer.Write(Conditional_Thunder_raw);
                writer.Write(Conditional_Ice_raw);
                writer.Write(Conditional_Dragon_raw);
                writer.Write(Condition_raw);
                writer.Write(Skeleton_raw);
                writer.Write(Rewards_Skeleton_raw);
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
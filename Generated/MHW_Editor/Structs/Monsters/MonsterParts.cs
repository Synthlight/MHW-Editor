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
    public partial class MonsterParts {
        public override string EncryptionKey => "sJV4g7d55gKnQB5nS6XJ9pZ1qZmmQwNnSbidUW1OeAhHrpPd6MKbfsrt";

        public partial class Monster_Parts : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Monster Parts";

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
                    ChangedItems.Add(nameof(Magic_2));
                    OnPropertyChanged(nameof(Magic_2));
                }
            }

            protected uint Monster_Id_raw;
            public const string Monster_Id_displayName = "Monster Id";
            public const int Monster_Id_sortIndex = 150;
            [SortOrder(Monster_Id_sortIndex)]
            [DisplayName(Monster_Id_displayName)]
            [DataSource(DataSourceType.Monsters)]
            [IsReadOnly]
            public virtual uint Monster_Id {
                get => Monster_Id_raw;
                set {
                    if (Monster_Id_raw == value) return;
                    Monster_Id_raw = value;
                    ChangedItems.Add(nameof(Monster_Id));
                    OnPropertyChanged(nameof(Monster_Id));
                    OnPropertyChanged(nameof(Monster_Id_button));
                }
            }

            [SortOrder(Monster_Id_sortIndex)]
            [DisplayName(Monster_Id_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Monster_Id_button => DataHelper.monsterNames[MainWindow.locale].TryGet(Monster_Id).ToStringWithId(Monster_Id);

            protected uint Magic_3_raw;
            public const string Magic_3_displayName = "Magic 3";
            public const int Magic_3_sortIndex = 200;
            [SortOrder(Magic_3_sortIndex)]
            [DisplayName(Magic_3_displayName)]
            [IsReadOnly]
            public virtual uint Magic_3 {
                get => Magic_3_raw;
                set {
                    if (Magic_3_raw == value) return;
                    Magic_3_raw = value;
                    ChangedItems.Add(nameof(Magic_3));
                    OnPropertyChanged(nameof(Magic_3));
                }
            }

            protected uint Health_raw;
            public const string Health_displayName = "Health";
            public const int Health_sortIndex = 250;
            [SortOrder(Health_sortIndex)]
            [DisplayName(Health_displayName)]
            public virtual uint Health {
                get => Health_raw;
                set {
                    if (Health_raw == value) return;
                    Health_raw = value;
                    ChangedItems.Add(nameof(Health));
                    OnPropertyChanged(nameof(Health));
                }
            }

            protected uint Flinches_Count_raw;
            public const string Flinches_Count_displayName = "Flinches Count";
            public const int Flinches_Count_sortIndex = 300;
            [SortOrder(Flinches_Count_sortIndex)]
            [DisplayName(Flinches_Count_displayName)]
            [IsReadOnly]
            public virtual uint Flinches_Count {
                get => Flinches_Count_raw;
                set {
                    if (Flinches_Count_raw == value) return;
                    Flinches_Count_raw = value;
                    ChangedItems.Add(nameof(Flinches_Count));
                    OnPropertyChanged(nameof(Flinches_Count));
                }
            }

            public const int lastSortIndex = 350;

            public static ObservableMhwStructCollection<Monster_Parts> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Monster_Parts>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Monster_Parts LoadData(BinaryReader reader, ulong i) {
                var data = new Monster_Parts();
                data.Index = i;
                data.Magic_1_raw = reader.ReadUInt32();
                data.Magic_2_raw = reader.ReadUInt32();
                data.Monster_Id_raw = reader.ReadUInt32();
                data.Magic_3_raw = reader.ReadUInt32();
                data.Health_raw = reader.ReadUInt32();
                data.Flinches_Count_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Magic_1_raw);
                writer.Write(Magic_2_raw);
                writer.Write(Monster_Id_raw);
                writer.Write(Magic_3_raw);
                writer.Write(Health_raw);
                writer.Write(Flinches_Count_raw);
            }
        }

        public partial class Flinches : MhwStructItem, IWriteData, IHasChildren {
            public const ulong FixedSizeCount = 0;
            public const string GridName = "Flinches";

            protected uint Flinch_Value_raw;
            public const string Flinch_Value_displayName = "Flinch Value";
            public const int Flinch_Value_sortIndex = 50;
            [SortOrder(Flinch_Value_sortIndex)]
            [DisplayName(Flinch_Value_displayName)]
            public virtual uint Flinch_Value {
                get => Flinch_Value_raw;
                set {
                    if (Flinch_Value_raw == value) return;
                    Flinch_Value_raw = value;
                    ChangedItems.Add(nameof(Flinch_Value));
                    OnPropertyChanged(nameof(Flinch_Value));
                }
            }

            protected int Special_Part_1_raw;
            public const string Special_Part_1_displayName = "Special Part 1";
            public const int Special_Part_1_sortIndex = 100;
            [SortOrder(Special_Part_1_sortIndex)]
            [DisplayName(Special_Part_1_displayName)]
            public virtual int Special_Part_1 {
                get => Special_Part_1_raw;
                set {
                    if (Special_Part_1_raw == value) return;
                    Special_Part_1_raw = value;
                    ChangedItems.Add(nameof(Special_Part_1));
                    OnPropertyChanged(nameof(Special_Part_1));
                }
            }

            protected int Special_Part_2_raw;
            public const string Special_Part_2_displayName = "Special Part 2";
            public const int Special_Part_2_sortIndex = 150;
            [SortOrder(Special_Part_2_sortIndex)]
            [DisplayName(Special_Part_2_displayName)]
            public virtual int Special_Part_2 {
                get => Special_Part_2_raw;
                set {
                    if (Special_Part_2_raw == value) return;
                    Special_Part_2_raw = value;
                    ChangedItems.Add(nameof(Special_Part_2));
                    OnPropertyChanged(nameof(Special_Part_2));
                }
            }

            protected int Special_Part_3_raw;
            public const string Special_Part_3_displayName = "Special Part 3";
            public const int Special_Part_3_sortIndex = 200;
            [SortOrder(Special_Part_3_sortIndex)]
            [DisplayName(Special_Part_3_displayName)]
            public virtual int Special_Part_3 {
                get => Special_Part_3_raw;
                set {
                    if (Special_Part_3_raw == value) return;
                    Special_Part_3_raw = value;
                    ChangedItems.Add(nameof(Special_Part_3));
                    OnPropertyChanged(nameof(Special_Part_3));
                }
            }

            protected uint Kinsect_Color_raw;
            public const string Kinsect_Color_displayName = "Kinsect Color";
            public const int Kinsect_Color_sortIndex = 250;
            [SortOrder(Kinsect_Color_sortIndex)]
            [DisplayName(Kinsect_Color_displayName)]
            public virtual MHW_Template.Weapons.KinsectColor Kinsect_Color {
                get => (MHW_Template.Weapons.KinsectColor) Kinsect_Color_raw;
                set {
                    if ((MHW_Template.Weapons.KinsectColor) Kinsect_Color_raw == value) return;
                    Kinsect_Color_raw = (uint) value;
                    ChangedItems.Add(nameof(Kinsect_Color));
                    OnPropertyChanged(nameof(Kinsect_Color));
                }
            }

            protected uint Parts_Type_raw;
            public const string Parts_Type_displayName = "Parts Type";
            public const int Parts_Type_sortIndex = 300;
            [SortOrder(Parts_Type_sortIndex)]
            [DisplayName(Parts_Type_displayName)]
            [IsReadOnly]
            public virtual uint Parts_Type {
                get => Parts_Type_raw;
                set {
                    if (Parts_Type_raw == value) return;
                    Parts_Type_raw = value;
                    ChangedItems.Add(nameof(Parts_Type));
                    OnPropertyChanged(nameof(Parts_Type));
                }
            }

            public partial class Parts1 : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteDataInner<Flinches> {
                public const ulong FixedSizeCount = 1;
                public const string GridName = "Parts1";

                protected int Part_Id_LR_HR1_Normal_raw;
                public const string Part_Id_LR_HR1_Normal_displayName = "Part Id LR/HR1 Normal";
                public const int Part_Id_LR_HR1_Normal_sortIndex = 50;
                [SortOrder(Part_Id_LR_HR1_Normal_sortIndex)]
                [DisplayName(Part_Id_LR_HR1_Normal_displayName)]
                public virtual int Part_Id_LR_HR1_Normal {
                    get => Part_Id_LR_HR1_Normal_raw;
                    set {
                        if (Part_Id_LR_HR1_Normal_raw == value) return;
                        Part_Id_LR_HR1_Normal_raw = value;
                        ChangedItems.Add(nameof(Part_Id_LR_HR1_Normal));
                        OnPropertyChanged(nameof(Part_Id_LR_HR1_Normal));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_LR_HR1_Normal_offset { get; private set; }

                protected int Part_Id_LR_HR1_Wounded_raw;
                public const string Part_Id_LR_HR1_Wounded_displayName = "Part Id LR/HR1 Wounded";
                public const int Part_Id_LR_HR1_Wounded_sortIndex = 100;
                [SortOrder(Part_Id_LR_HR1_Wounded_sortIndex)]
                [DisplayName(Part_Id_LR_HR1_Wounded_displayName)]
                public virtual int Part_Id_LR_HR1_Wounded {
                    get => Part_Id_LR_HR1_Wounded_raw;
                    set {
                        if (Part_Id_LR_HR1_Wounded_raw == value) return;
                        Part_Id_LR_HR1_Wounded_raw = value;
                        ChangedItems.Add(nameof(Part_Id_LR_HR1_Wounded));
                        OnPropertyChanged(nameof(Part_Id_LR_HR1_Wounded));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_LR_HR1_Wounded_offset { get; private set; }

                protected int Part_Id_LR_HR1_Special_Phase_1_raw;
                public const string Part_Id_LR_HR1_Special_Phase_1_displayName = "Part Id LR/HR1 Special Phase 1";
                public const int Part_Id_LR_HR1_Special_Phase_1_sortIndex = 150;
                [SortOrder(Part_Id_LR_HR1_Special_Phase_1_sortIndex)]
                [DisplayName(Part_Id_LR_HR1_Special_Phase_1_displayName)]
                public virtual int Part_Id_LR_HR1_Special_Phase_1 {
                    get => Part_Id_LR_HR1_Special_Phase_1_raw;
                    set {
                        if (Part_Id_LR_HR1_Special_Phase_1_raw == value) return;
                        Part_Id_LR_HR1_Special_Phase_1_raw = value;
                        ChangedItems.Add(nameof(Part_Id_LR_HR1_Special_Phase_1));
                        OnPropertyChanged(nameof(Part_Id_LR_HR1_Special_Phase_1));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_LR_HR1_Special_Phase_1_offset { get; private set; }

                protected int Part_Id_LR_HR1_Special_Phase_2_raw;
                public const string Part_Id_LR_HR1_Special_Phase_2_displayName = "Part Id LR/HR1 Special Phase 2";
                public const int Part_Id_LR_HR1_Special_Phase_2_sortIndex = 200;
                [SortOrder(Part_Id_LR_HR1_Special_Phase_2_sortIndex)]
                [DisplayName(Part_Id_LR_HR1_Special_Phase_2_displayName)]
                public virtual int Part_Id_LR_HR1_Special_Phase_2 {
                    get => Part_Id_LR_HR1_Special_Phase_2_raw;
                    set {
                        if (Part_Id_LR_HR1_Special_Phase_2_raw == value) return;
                        Part_Id_LR_HR1_Special_Phase_2_raw = value;
                        ChangedItems.Add(nameof(Part_Id_LR_HR1_Special_Phase_2));
                        OnPropertyChanged(nameof(Part_Id_LR_HR1_Special_Phase_2));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_LR_HR1_Special_Phase_2_offset { get; private set; }

                protected int Part_Id_LR_HR1_Special_Phase_3_raw;
                public const string Part_Id_LR_HR1_Special_Phase_3_displayName = "Part Id LR/HR1 Special Phase 3";
                public const int Part_Id_LR_HR1_Special_Phase_3_sortIndex = 250;
                [SortOrder(Part_Id_LR_HR1_Special_Phase_3_sortIndex)]
                [DisplayName(Part_Id_LR_HR1_Special_Phase_3_displayName)]
                public virtual int Part_Id_LR_HR1_Special_Phase_3 {
                    get => Part_Id_LR_HR1_Special_Phase_3_raw;
                    set {
                        if (Part_Id_LR_HR1_Special_Phase_3_raw == value) return;
                        Part_Id_LR_HR1_Special_Phase_3_raw = value;
                        ChangedItems.Add(nameof(Part_Id_LR_HR1_Special_Phase_3));
                        OnPropertyChanged(nameof(Part_Id_LR_HR1_Special_Phase_3));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_LR_HR1_Special_Phase_3_offset { get; private set; }

                protected int Part_Id_MR1_Normal_raw;
                public const string Part_Id_MR1_Normal_displayName = "Part Id MR1 Normal";
                public const int Part_Id_MR1_Normal_sortIndex = 300;
                [SortOrder(Part_Id_MR1_Normal_sortIndex)]
                [DisplayName(Part_Id_MR1_Normal_displayName)]
                public virtual int Part_Id_MR1_Normal {
                    get => Part_Id_MR1_Normal_raw;
                    set {
                        if (Part_Id_MR1_Normal_raw == value) return;
                        Part_Id_MR1_Normal_raw = value;
                        ChangedItems.Add(nameof(Part_Id_MR1_Normal));
                        OnPropertyChanged(nameof(Part_Id_MR1_Normal));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_MR1_Normal_offset { get; private set; }

                protected int Part_Id_MR1_Wounded_raw;
                public const string Part_Id_MR1_Wounded_displayName = "Part Id MR1 Wounded";
                public const int Part_Id_MR1_Wounded_sortIndex = 350;
                [SortOrder(Part_Id_MR1_Wounded_sortIndex)]
                [DisplayName(Part_Id_MR1_Wounded_displayName)]
                public virtual int Part_Id_MR1_Wounded {
                    get => Part_Id_MR1_Wounded_raw;
                    set {
                        if (Part_Id_MR1_Wounded_raw == value) return;
                        Part_Id_MR1_Wounded_raw = value;
                        ChangedItems.Add(nameof(Part_Id_MR1_Wounded));
                        OnPropertyChanged(nameof(Part_Id_MR1_Wounded));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_MR1_Wounded_offset { get; private set; }

                protected int Part_Id_MR1_Special_Phase_1_raw;
                public const string Part_Id_MR1_Special_Phase_1_displayName = "Part Id MR1 Special Phase 1";
                public const int Part_Id_MR1_Special_Phase_1_sortIndex = 400;
                [SortOrder(Part_Id_MR1_Special_Phase_1_sortIndex)]
                [DisplayName(Part_Id_MR1_Special_Phase_1_displayName)]
                public virtual int Part_Id_MR1_Special_Phase_1 {
                    get => Part_Id_MR1_Special_Phase_1_raw;
                    set {
                        if (Part_Id_MR1_Special_Phase_1_raw == value) return;
                        Part_Id_MR1_Special_Phase_1_raw = value;
                        ChangedItems.Add(nameof(Part_Id_MR1_Special_Phase_1));
                        OnPropertyChanged(nameof(Part_Id_MR1_Special_Phase_1));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_MR1_Special_Phase_1_offset { get; private set; }

                protected int Part_Id_MR1_Special_Phase_2_raw;
                public const string Part_Id_MR1_Special_Phase_2_displayName = "Part Id MR1 Special Phase 2";
                public const int Part_Id_MR1_Special_Phase_2_sortIndex = 450;
                [SortOrder(Part_Id_MR1_Special_Phase_2_sortIndex)]
                [DisplayName(Part_Id_MR1_Special_Phase_2_displayName)]
                public virtual int Part_Id_MR1_Special_Phase_2 {
                    get => Part_Id_MR1_Special_Phase_2_raw;
                    set {
                        if (Part_Id_MR1_Special_Phase_2_raw == value) return;
                        Part_Id_MR1_Special_Phase_2_raw = value;
                        ChangedItems.Add(nameof(Part_Id_MR1_Special_Phase_2));
                        OnPropertyChanged(nameof(Part_Id_MR1_Special_Phase_2));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_MR1_Special_Phase_2_offset { get; private set; }

                protected int Part_Id_MR1_Special_Phase_3_raw;
                public const string Part_Id_MR1_Special_Phase_3_displayName = "Part Id MR1 Special Phase 3";
                public const int Part_Id_MR1_Special_Phase_3_sortIndex = 500;
                [SortOrder(Part_Id_MR1_Special_Phase_3_sortIndex)]
                [DisplayName(Part_Id_MR1_Special_Phase_3_displayName)]
                public virtual int Part_Id_MR1_Special_Phase_3 {
                    get => Part_Id_MR1_Special_Phase_3_raw;
                    set {
                        if (Part_Id_MR1_Special_Phase_3_raw == value) return;
                        Part_Id_MR1_Special_Phase_3_raw = value;
                        ChangedItems.Add(nameof(Part_Id_MR1_Special_Phase_3));
                        OnPropertyChanged(nameof(Part_Id_MR1_Special_Phase_3));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_MR1_Special_Phase_3_offset { get; private set; }

                protected uint unk9_raw;
                public const string unk9_displayName = "unk9";
                public const int unk9_sortIndex = 550;
                [SortOrder(unk9_sortIndex)]
                [DisplayName(unk9_displayName)]
                public virtual uint unk9 {
                    get => unk9_raw;
                    set {
                        if (unk9_raw == value) return;
                        unk9_raw = value;
                        ChangedItems.Add(nameof(unk9));
                        OnPropertyChanged(nameof(unk9));
                    }
                }

                [DisplayName("Offset")]
                public long unk9_offset { get; private set; }

                protected uint unk10_raw;
                public const string unk10_displayName = "unk10";
                public const int unk10_sortIndex = 600;
                [SortOrder(unk10_sortIndex)]
                [DisplayName(unk10_displayName)]
                public virtual uint unk10 {
                    get => unk10_raw;
                    set {
                        if (unk10_raw == value) return;
                        unk10_raw = value;
                        ChangedItems.Add(nameof(unk10));
                        OnPropertyChanged(nameof(unk10));
                    }
                }

                [DisplayName("Offset")]
                public long unk10_offset { get; private set; }

                protected uint unk11_raw;
                public const string unk11_displayName = "unk11";
                public const int unk11_sortIndex = 650;
                [SortOrder(unk11_sortIndex)]
                [DisplayName(unk11_displayName)]
                public virtual uint unk11 {
                    get => unk11_raw;
                    set {
                        if (unk11_raw == value) return;
                        unk11_raw = value;
                        ChangedItems.Add(nameof(unk11));
                        OnPropertyChanged(nameof(unk11));
                    }
                }

                [DisplayName("Offset")]
                public long unk11_offset { get; private set; }

                protected byte unk12_raw;
                public const string unk12_displayName = "unk12";
                public const int unk12_sortIndex = 700;
                [SortOrder(unk12_sortIndex)]
                [DisplayName(unk12_displayName)]
                public virtual byte unk12 {
                    get => unk12_raw;
                    set {
                        if (unk12_raw == value) return;
                        unk12_raw = value;
                        ChangedItems.Add(nameof(unk12));
                        OnPropertyChanged(nameof(unk12));
                    }
                }

                [DisplayName("Offset")]
                public long unk12_offset { get; private set; }

                protected byte unk13_raw;
                public const string unk13_displayName = "unk13";
                public const int unk13_sortIndex = 750;
                [SortOrder(unk13_sortIndex)]
                [DisplayName(unk13_displayName)]
                public virtual byte unk13 {
                    get => unk13_raw;
                    set {
                        if (unk13_raw == value) return;
                        unk13_raw = value;
                        ChangedItems.Add(nameof(unk13));
                        OnPropertyChanged(nameof(unk13));
                    }
                }

                [DisplayName("Offset")]
                public long unk13_offset { get; private set; }

                public const int lastSortIndex = 800;

                public static ObservableMhwStructCollection<Parts1> LoadData(BinaryReader reader, Flinches parent) {
                    var list = new ObservableMhwStructCollection<Parts1>();
                    const ulong count = 1UL;
                    for (ulong i = 0; i < count; i++) {
                        list.Add(LoadData(reader, i, parent));
                    }
                    return list;
                }

                public static Parts1 LoadData(BinaryReader reader, ulong i, Flinches parent) {
                    var data = new Parts1();
                    data.Index = i;
                    data.Part_Id_LR_HR1_Normal_offset = reader.BaseStream.Position;
                    data.Part_Id_LR_HR1_Normal_raw = reader.ReadInt32();
                    data.Part_Id_LR_HR1_Wounded_offset = reader.BaseStream.Position;
                    data.Part_Id_LR_HR1_Wounded_raw = reader.ReadInt32();
                    data.Part_Id_LR_HR1_Special_Phase_1_offset = reader.BaseStream.Position;
                    data.Part_Id_LR_HR1_Special_Phase_1_raw = reader.ReadInt32();
                    data.Part_Id_LR_HR1_Special_Phase_2_offset = reader.BaseStream.Position;
                    data.Part_Id_LR_HR1_Special_Phase_2_raw = reader.ReadInt32();
                    data.Part_Id_LR_HR1_Special_Phase_3_offset = reader.BaseStream.Position;
                    data.Part_Id_LR_HR1_Special_Phase_3_raw = reader.ReadInt32();
                    data.Part_Id_MR1_Normal_offset = reader.BaseStream.Position;
                    data.Part_Id_MR1_Normal_raw = reader.ReadInt32();
                    data.Part_Id_MR1_Wounded_offset = reader.BaseStream.Position;
                    data.Part_Id_MR1_Wounded_raw = reader.ReadInt32();
                    data.Part_Id_MR1_Special_Phase_1_offset = reader.BaseStream.Position;
                    data.Part_Id_MR1_Special_Phase_1_raw = reader.ReadInt32();
                    data.Part_Id_MR1_Special_Phase_2_offset = reader.BaseStream.Position;
                    data.Part_Id_MR1_Special_Phase_2_raw = reader.ReadInt32();
                    data.Part_Id_MR1_Special_Phase_3_offset = reader.BaseStream.Position;
                    data.Part_Id_MR1_Special_Phase_3_raw = reader.ReadInt32();
                    data.unk9_offset = reader.BaseStream.Position;
                    data.unk9_raw = reader.ReadUInt32();
                    data.unk10_offset = reader.BaseStream.Position;
                    data.unk10_raw = reader.ReadUInt32();
                    data.unk11_offset = reader.BaseStream.Position;
                    data.unk11_raw = reader.ReadUInt32();
                    data.unk12_offset = reader.BaseStream.Position;
                    data.unk12_raw = reader.ReadByte();
                    data.unk13_offset = reader.BaseStream.Position;
                    data.unk13_raw = reader.ReadByte();
                    return data;
                }

                public void WriteData(BinaryWriter writer, Flinches parent) {
                    writer.Write(Part_Id_LR_HR1_Normal_raw);
                    writer.Write(Part_Id_LR_HR1_Wounded_raw);
                    writer.Write(Part_Id_LR_HR1_Special_Phase_1_raw);
                    writer.Write(Part_Id_LR_HR1_Special_Phase_2_raw);
                    writer.Write(Part_Id_LR_HR1_Special_Phase_3_raw);
                    writer.Write(Part_Id_MR1_Normal_raw);
                    writer.Write(Part_Id_MR1_Wounded_raw);
                    writer.Write(Part_Id_MR1_Special_Phase_1_raw);
                    writer.Write(Part_Id_MR1_Special_Phase_2_raw);
                    writer.Write(Part_Id_MR1_Special_Phase_3_raw);
                    writer.Write(unk9_raw);
                    writer.Write(unk10_raw);
                    writer.Write(unk11_raw);
                    writer.Write(unk12_raw);
                    writer.Write(unk13_raw);
                }

                public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                    return new ObservableCollection<MultiStructItemCustomView> {
                        new MultiStructItemCustomView(this, "Part Id LR/HR1 Normal", "Part_Id_LR_HR1_Normal", "Part_Id_LR_HR1_Normal_offset"),
                        new MultiStructItemCustomView(this, "Part Id LR/HR1 Wounded", "Part_Id_LR_HR1_Wounded", "Part_Id_LR_HR1_Wounded_offset"),
                        new MultiStructItemCustomView(this, "Part Id LR/HR1 Special Phase 1", "Part_Id_LR_HR1_Special_Phase_1", "Part_Id_LR_HR1_Special_Phase_1_offset"),
                        new MultiStructItemCustomView(this, "Part Id LR/HR1 Special Phase 2", "Part_Id_LR_HR1_Special_Phase_2", "Part_Id_LR_HR1_Special_Phase_2_offset"),
                        new MultiStructItemCustomView(this, "Part Id LR/HR1 Special Phase 3", "Part_Id_LR_HR1_Special_Phase_3", "Part_Id_LR_HR1_Special_Phase_3_offset"),
                        new MultiStructItemCustomView(this, "Part Id MR1 Normal", "Part_Id_MR1_Normal", "Part_Id_MR1_Normal_offset"),
                        new MultiStructItemCustomView(this, "Part Id MR1 Wounded", "Part_Id_MR1_Wounded", "Part_Id_MR1_Wounded_offset"),
                        new MultiStructItemCustomView(this, "Part Id MR1 Special Phase 1", "Part_Id_MR1_Special_Phase_1", "Part_Id_MR1_Special_Phase_1_offset"),
                        new MultiStructItemCustomView(this, "Part Id MR1 Special Phase 2", "Part_Id_MR1_Special_Phase_2", "Part_Id_MR1_Special_Phase_2_offset"),
                        new MultiStructItemCustomView(this, "Part Id MR1 Special Phase 3", "Part_Id_MR1_Special_Phase_3", "Part_Id_MR1_Special_Phase_3_offset"),
                        new MultiStructItemCustomView(this, "unk9", "unk9", "unk9_offset"),
                        new MultiStructItemCustomView(this, "unk10", "unk10", "unk10_offset"),
                        new MultiStructItemCustomView(this, "unk11", "unk11", "unk11_offset"),
                        new MultiStructItemCustomView(this, "unk12", "unk12", "unk12_offset"),
                        new MultiStructItemCustomView(this, "unk13", "unk13", "unk13_offset"),
                    };
                }
            }

            public const string Parts1_displayName = "Parts1";
            public const int Parts1_sortIndex = 350;
            [SortOrder(Parts1_sortIndex)]
            [DisplayName(Parts1_displayName)]
            protected virtual ObservableCollection<Parts1> Parts1_raw { get; set; }

            public partial class Parts2 : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteDataInner<Flinches> {
                public const ulong FixedSizeCount = 1;
                public const string GridName = "Parts2";

                protected int Part_Id_LR_HR1_Normal_raw;
                public const string Part_Id_LR_HR1_Normal_displayName = "Part Id LR/HR1 Normal";
                public const int Part_Id_LR_HR1_Normal_sortIndex = 50;
                [SortOrder(Part_Id_LR_HR1_Normal_sortIndex)]
                [DisplayName(Part_Id_LR_HR1_Normal_displayName)]
                public virtual int Part_Id_LR_HR1_Normal {
                    get => Part_Id_LR_HR1_Normal_raw;
                    set {
                        if (Part_Id_LR_HR1_Normal_raw == value) return;
                        Part_Id_LR_HR1_Normal_raw = value;
                        ChangedItems.Add(nameof(Part_Id_LR_HR1_Normal));
                        OnPropertyChanged(nameof(Part_Id_LR_HR1_Normal));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_LR_HR1_Normal_offset { get; private set; }

                protected int Part_Id_LR_HR1_Wounded_raw;
                public const string Part_Id_LR_HR1_Wounded_displayName = "Part Id LR/HR1 Wounded";
                public const int Part_Id_LR_HR1_Wounded_sortIndex = 100;
                [SortOrder(Part_Id_LR_HR1_Wounded_sortIndex)]
                [DisplayName(Part_Id_LR_HR1_Wounded_displayName)]
                public virtual int Part_Id_LR_HR1_Wounded {
                    get => Part_Id_LR_HR1_Wounded_raw;
                    set {
                        if (Part_Id_LR_HR1_Wounded_raw == value) return;
                        Part_Id_LR_HR1_Wounded_raw = value;
                        ChangedItems.Add(nameof(Part_Id_LR_HR1_Wounded));
                        OnPropertyChanged(nameof(Part_Id_LR_HR1_Wounded));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_LR_HR1_Wounded_offset { get; private set; }

                protected int Part_Id_LR_HR1_Special_Phase_1_raw;
                public const string Part_Id_LR_HR1_Special_Phase_1_displayName = "Part Id LR/HR1 Special Phase 1";
                public const int Part_Id_LR_HR1_Special_Phase_1_sortIndex = 150;
                [SortOrder(Part_Id_LR_HR1_Special_Phase_1_sortIndex)]
                [DisplayName(Part_Id_LR_HR1_Special_Phase_1_displayName)]
                public virtual int Part_Id_LR_HR1_Special_Phase_1 {
                    get => Part_Id_LR_HR1_Special_Phase_1_raw;
                    set {
                        if (Part_Id_LR_HR1_Special_Phase_1_raw == value) return;
                        Part_Id_LR_HR1_Special_Phase_1_raw = value;
                        ChangedItems.Add(nameof(Part_Id_LR_HR1_Special_Phase_1));
                        OnPropertyChanged(nameof(Part_Id_LR_HR1_Special_Phase_1));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_LR_HR1_Special_Phase_1_offset { get; private set; }

                protected int Part_Id_LR_HR1_Special_Phase_2_raw;
                public const string Part_Id_LR_HR1_Special_Phase_2_displayName = "Part Id LR/HR1 Special Phase 2";
                public const int Part_Id_LR_HR1_Special_Phase_2_sortIndex = 200;
                [SortOrder(Part_Id_LR_HR1_Special_Phase_2_sortIndex)]
                [DisplayName(Part_Id_LR_HR1_Special_Phase_2_displayName)]
                public virtual int Part_Id_LR_HR1_Special_Phase_2 {
                    get => Part_Id_LR_HR1_Special_Phase_2_raw;
                    set {
                        if (Part_Id_LR_HR1_Special_Phase_2_raw == value) return;
                        Part_Id_LR_HR1_Special_Phase_2_raw = value;
                        ChangedItems.Add(nameof(Part_Id_LR_HR1_Special_Phase_2));
                        OnPropertyChanged(nameof(Part_Id_LR_HR1_Special_Phase_2));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_LR_HR1_Special_Phase_2_offset { get; private set; }

                protected int Part_Id_LR_HR1_Special_Phase_3_raw;
                public const string Part_Id_LR_HR1_Special_Phase_3_displayName = "Part Id LR/HR1 Special Phase 3";
                public const int Part_Id_LR_HR1_Special_Phase_3_sortIndex = 250;
                [SortOrder(Part_Id_LR_HR1_Special_Phase_3_sortIndex)]
                [DisplayName(Part_Id_LR_HR1_Special_Phase_3_displayName)]
                public virtual int Part_Id_LR_HR1_Special_Phase_3 {
                    get => Part_Id_LR_HR1_Special_Phase_3_raw;
                    set {
                        if (Part_Id_LR_HR1_Special_Phase_3_raw == value) return;
                        Part_Id_LR_HR1_Special_Phase_3_raw = value;
                        ChangedItems.Add(nameof(Part_Id_LR_HR1_Special_Phase_3));
                        OnPropertyChanged(nameof(Part_Id_LR_HR1_Special_Phase_3));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_LR_HR1_Special_Phase_3_offset { get; private set; }

                protected int Part_Id_MR1_Normal_raw;
                public const string Part_Id_MR1_Normal_displayName = "Part Id MR1 Normal";
                public const int Part_Id_MR1_Normal_sortIndex = 300;
                [SortOrder(Part_Id_MR1_Normal_sortIndex)]
                [DisplayName(Part_Id_MR1_Normal_displayName)]
                public virtual int Part_Id_MR1_Normal {
                    get => Part_Id_MR1_Normal_raw;
                    set {
                        if (Part_Id_MR1_Normal_raw == value) return;
                        Part_Id_MR1_Normal_raw = value;
                        ChangedItems.Add(nameof(Part_Id_MR1_Normal));
                        OnPropertyChanged(nameof(Part_Id_MR1_Normal));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_MR1_Normal_offset { get; private set; }

                protected int Part_Id_MR1_Wounded_raw;
                public const string Part_Id_MR1_Wounded_displayName = "Part Id MR1 Wounded";
                public const int Part_Id_MR1_Wounded_sortIndex = 350;
                [SortOrder(Part_Id_MR1_Wounded_sortIndex)]
                [DisplayName(Part_Id_MR1_Wounded_displayName)]
                public virtual int Part_Id_MR1_Wounded {
                    get => Part_Id_MR1_Wounded_raw;
                    set {
                        if (Part_Id_MR1_Wounded_raw == value) return;
                        Part_Id_MR1_Wounded_raw = value;
                        ChangedItems.Add(nameof(Part_Id_MR1_Wounded));
                        OnPropertyChanged(nameof(Part_Id_MR1_Wounded));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_MR1_Wounded_offset { get; private set; }

                protected int Part_Id_MR1_Special_Phase_1_raw;
                public const string Part_Id_MR1_Special_Phase_1_displayName = "Part Id MR1 Special Phase 1";
                public const int Part_Id_MR1_Special_Phase_1_sortIndex = 400;
                [SortOrder(Part_Id_MR1_Special_Phase_1_sortIndex)]
                [DisplayName(Part_Id_MR1_Special_Phase_1_displayName)]
                public virtual int Part_Id_MR1_Special_Phase_1 {
                    get => Part_Id_MR1_Special_Phase_1_raw;
                    set {
                        if (Part_Id_MR1_Special_Phase_1_raw == value) return;
                        Part_Id_MR1_Special_Phase_1_raw = value;
                        ChangedItems.Add(nameof(Part_Id_MR1_Special_Phase_1));
                        OnPropertyChanged(nameof(Part_Id_MR1_Special_Phase_1));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_MR1_Special_Phase_1_offset { get; private set; }

                protected int Part_Id_MR1_Special_Phase_2_raw;
                public const string Part_Id_MR1_Special_Phase_2_displayName = "Part Id MR1 Special Phase 2";
                public const int Part_Id_MR1_Special_Phase_2_sortIndex = 450;
                [SortOrder(Part_Id_MR1_Special_Phase_2_sortIndex)]
                [DisplayName(Part_Id_MR1_Special_Phase_2_displayName)]
                public virtual int Part_Id_MR1_Special_Phase_2 {
                    get => Part_Id_MR1_Special_Phase_2_raw;
                    set {
                        if (Part_Id_MR1_Special_Phase_2_raw == value) return;
                        Part_Id_MR1_Special_Phase_2_raw = value;
                        ChangedItems.Add(nameof(Part_Id_MR1_Special_Phase_2));
                        OnPropertyChanged(nameof(Part_Id_MR1_Special_Phase_2));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_MR1_Special_Phase_2_offset { get; private set; }

                protected int Part_Id_MR1_Special_Phase_3_raw;
                public const string Part_Id_MR1_Special_Phase_3_displayName = "Part Id MR1 Special Phase 3";
                public const int Part_Id_MR1_Special_Phase_3_sortIndex = 500;
                [SortOrder(Part_Id_MR1_Special_Phase_3_sortIndex)]
                [DisplayName(Part_Id_MR1_Special_Phase_3_displayName)]
                public virtual int Part_Id_MR1_Special_Phase_3 {
                    get => Part_Id_MR1_Special_Phase_3_raw;
                    set {
                        if (Part_Id_MR1_Special_Phase_3_raw == value) return;
                        Part_Id_MR1_Special_Phase_3_raw = value;
                        ChangedItems.Add(nameof(Part_Id_MR1_Special_Phase_3));
                        OnPropertyChanged(nameof(Part_Id_MR1_Special_Phase_3));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_MR1_Special_Phase_3_offset { get; private set; }

                protected int Part_Id_LR_HR2_Normal_raw;
                public const string Part_Id_LR_HR2_Normal_displayName = "Part Id LR/HR2 Normal";
                public const int Part_Id_LR_HR2_Normal_sortIndex = 550;
                [SortOrder(Part_Id_LR_HR2_Normal_sortIndex)]
                [DisplayName(Part_Id_LR_HR2_Normal_displayName)]
                public virtual int Part_Id_LR_HR2_Normal {
                    get => Part_Id_LR_HR2_Normal_raw;
                    set {
                        if (Part_Id_LR_HR2_Normal_raw == value) return;
                        Part_Id_LR_HR2_Normal_raw = value;
                        ChangedItems.Add(nameof(Part_Id_LR_HR2_Normal));
                        OnPropertyChanged(nameof(Part_Id_LR_HR2_Normal));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_LR_HR2_Normal_offset { get; private set; }

                protected int Part_Id_LR_HR2_Wounded_raw;
                public const string Part_Id_LR_HR2_Wounded_displayName = "Part Id LR/HR2 Wounded";
                public const int Part_Id_LR_HR2_Wounded_sortIndex = 600;
                [SortOrder(Part_Id_LR_HR2_Wounded_sortIndex)]
                [DisplayName(Part_Id_LR_HR2_Wounded_displayName)]
                public virtual int Part_Id_LR_HR2_Wounded {
                    get => Part_Id_LR_HR2_Wounded_raw;
                    set {
                        if (Part_Id_LR_HR2_Wounded_raw == value) return;
                        Part_Id_LR_HR2_Wounded_raw = value;
                        ChangedItems.Add(nameof(Part_Id_LR_HR2_Wounded));
                        OnPropertyChanged(nameof(Part_Id_LR_HR2_Wounded));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_LR_HR2_Wounded_offset { get; private set; }

                protected int Part_Id_LR_HR2_Special_Phase_1_raw;
                public const string Part_Id_LR_HR2_Special_Phase_1_displayName = "Part Id LR/HR2 Special Phase 1";
                public const int Part_Id_LR_HR2_Special_Phase_1_sortIndex = 650;
                [SortOrder(Part_Id_LR_HR2_Special_Phase_1_sortIndex)]
                [DisplayName(Part_Id_LR_HR2_Special_Phase_1_displayName)]
                public virtual int Part_Id_LR_HR2_Special_Phase_1 {
                    get => Part_Id_LR_HR2_Special_Phase_1_raw;
                    set {
                        if (Part_Id_LR_HR2_Special_Phase_1_raw == value) return;
                        Part_Id_LR_HR2_Special_Phase_1_raw = value;
                        ChangedItems.Add(nameof(Part_Id_LR_HR2_Special_Phase_1));
                        OnPropertyChanged(nameof(Part_Id_LR_HR2_Special_Phase_1));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_LR_HR2_Special_Phase_1_offset { get; private set; }

                protected int Part_Id_LR_HR2_Special_Phase_2_raw;
                public const string Part_Id_LR_HR2_Special_Phase_2_displayName = "Part Id LR/HR2 Special Phase 2";
                public const int Part_Id_LR_HR2_Special_Phase_2_sortIndex = 700;
                [SortOrder(Part_Id_LR_HR2_Special_Phase_2_sortIndex)]
                [DisplayName(Part_Id_LR_HR2_Special_Phase_2_displayName)]
                public virtual int Part_Id_LR_HR2_Special_Phase_2 {
                    get => Part_Id_LR_HR2_Special_Phase_2_raw;
                    set {
                        if (Part_Id_LR_HR2_Special_Phase_2_raw == value) return;
                        Part_Id_LR_HR2_Special_Phase_2_raw = value;
                        ChangedItems.Add(nameof(Part_Id_LR_HR2_Special_Phase_2));
                        OnPropertyChanged(nameof(Part_Id_LR_HR2_Special_Phase_2));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_LR_HR2_Special_Phase_2_offset { get; private set; }

                protected int Part_Id_LR_HR2_Special_Phase_3_raw;
                public const string Part_Id_LR_HR2_Special_Phase_3_displayName = "Part Id LR/HR2 Special Phase 3";
                public const int Part_Id_LR_HR2_Special_Phase_3_sortIndex = 750;
                [SortOrder(Part_Id_LR_HR2_Special_Phase_3_sortIndex)]
                [DisplayName(Part_Id_LR_HR2_Special_Phase_3_displayName)]
                public virtual int Part_Id_LR_HR2_Special_Phase_3 {
                    get => Part_Id_LR_HR2_Special_Phase_3_raw;
                    set {
                        if (Part_Id_LR_HR2_Special_Phase_3_raw == value) return;
                        Part_Id_LR_HR2_Special_Phase_3_raw = value;
                        ChangedItems.Add(nameof(Part_Id_LR_HR2_Special_Phase_3));
                        OnPropertyChanged(nameof(Part_Id_LR_HR2_Special_Phase_3));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_LR_HR2_Special_Phase_3_offset { get; private set; }

                protected int Part_Id_MR2_Normal_raw;
                public const string Part_Id_MR2_Normal_displayName = "Part Id MR2 Normal";
                public const int Part_Id_MR2_Normal_sortIndex = 800;
                [SortOrder(Part_Id_MR2_Normal_sortIndex)]
                [DisplayName(Part_Id_MR2_Normal_displayName)]
                public virtual int Part_Id_MR2_Normal {
                    get => Part_Id_MR2_Normal_raw;
                    set {
                        if (Part_Id_MR2_Normal_raw == value) return;
                        Part_Id_MR2_Normal_raw = value;
                        ChangedItems.Add(nameof(Part_Id_MR2_Normal));
                        OnPropertyChanged(nameof(Part_Id_MR2_Normal));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_MR2_Normal_offset { get; private set; }

                protected int Part_Id_MR2_Wounded_raw;
                public const string Part_Id_MR2_Wounded_displayName = "Part Id MR2 Wounded";
                public const int Part_Id_MR2_Wounded_sortIndex = 850;
                [SortOrder(Part_Id_MR2_Wounded_sortIndex)]
                [DisplayName(Part_Id_MR2_Wounded_displayName)]
                public virtual int Part_Id_MR2_Wounded {
                    get => Part_Id_MR2_Wounded_raw;
                    set {
                        if (Part_Id_MR2_Wounded_raw == value) return;
                        Part_Id_MR2_Wounded_raw = value;
                        ChangedItems.Add(nameof(Part_Id_MR2_Wounded));
                        OnPropertyChanged(nameof(Part_Id_MR2_Wounded));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_MR2_Wounded_offset { get; private set; }

                protected int Part_Id_MR2_Special_Phase_1_raw;
                public const string Part_Id_MR2_Special_Phase_1_displayName = "Part Id MR2 Special Phase 1";
                public const int Part_Id_MR2_Special_Phase_1_sortIndex = 900;
                [SortOrder(Part_Id_MR2_Special_Phase_1_sortIndex)]
                [DisplayName(Part_Id_MR2_Special_Phase_1_displayName)]
                public virtual int Part_Id_MR2_Special_Phase_1 {
                    get => Part_Id_MR2_Special_Phase_1_raw;
                    set {
                        if (Part_Id_MR2_Special_Phase_1_raw == value) return;
                        Part_Id_MR2_Special_Phase_1_raw = value;
                        ChangedItems.Add(nameof(Part_Id_MR2_Special_Phase_1));
                        OnPropertyChanged(nameof(Part_Id_MR2_Special_Phase_1));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_MR2_Special_Phase_1_offset { get; private set; }

                protected int Part_Id_MR2_Special_Phase_2_raw;
                public const string Part_Id_MR2_Special_Phase_2_displayName = "Part Id MR2 Special Phase 2";
                public const int Part_Id_MR2_Special_Phase_2_sortIndex = 950;
                [SortOrder(Part_Id_MR2_Special_Phase_2_sortIndex)]
                [DisplayName(Part_Id_MR2_Special_Phase_2_displayName)]
                public virtual int Part_Id_MR2_Special_Phase_2 {
                    get => Part_Id_MR2_Special_Phase_2_raw;
                    set {
                        if (Part_Id_MR2_Special_Phase_2_raw == value) return;
                        Part_Id_MR2_Special_Phase_2_raw = value;
                        ChangedItems.Add(nameof(Part_Id_MR2_Special_Phase_2));
                        OnPropertyChanged(nameof(Part_Id_MR2_Special_Phase_2));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_MR2_Special_Phase_2_offset { get; private set; }

                protected int Part_Id_MR2_Special_Phase_3_raw;
                public const string Part_Id_MR2_Special_Phase_3_displayName = "Part Id MR2 Special Phase 3";
                public const int Part_Id_MR2_Special_Phase_3_sortIndex = 1000;
                [SortOrder(Part_Id_MR2_Special_Phase_3_sortIndex)]
                [DisplayName(Part_Id_MR2_Special_Phase_3_displayName)]
                public virtual int Part_Id_MR2_Special_Phase_3 {
                    get => Part_Id_MR2_Special_Phase_3_raw;
                    set {
                        if (Part_Id_MR2_Special_Phase_3_raw == value) return;
                        Part_Id_MR2_Special_Phase_3_raw = value;
                        ChangedItems.Add(nameof(Part_Id_MR2_Special_Phase_3));
                        OnPropertyChanged(nameof(Part_Id_MR2_Special_Phase_3));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_MR2_Special_Phase_3_offset { get; private set; }

                protected uint unk19_raw;
                public const string unk19_displayName = "unk19";
                public const int unk19_sortIndex = 1050;
                [SortOrder(unk19_sortIndex)]
                [DisplayName(unk19_displayName)]
                public virtual uint unk19 {
                    get => unk19_raw;
                    set {
                        if (unk19_raw == value) return;
                        unk19_raw = value;
                        ChangedItems.Add(nameof(unk19));
                        OnPropertyChanged(nameof(unk19));
                    }
                }

                [DisplayName("Offset")]
                public long unk19_offset { get; private set; }

                protected uint unk20_raw;
                public const string unk20_displayName = "unk20";
                public const int unk20_sortIndex = 1100;
                [SortOrder(unk20_sortIndex)]
                [DisplayName(unk20_displayName)]
                public virtual uint unk20 {
                    get => unk20_raw;
                    set {
                        if (unk20_raw == value) return;
                        unk20_raw = value;
                        ChangedItems.Add(nameof(unk20));
                        OnPropertyChanged(nameof(unk20));
                    }
                }

                [DisplayName("Offset")]
                public long unk20_offset { get; private set; }

                protected uint unk21_raw;
                public const string unk21_displayName = "unk21";
                public const int unk21_sortIndex = 1150;
                [SortOrder(unk21_sortIndex)]
                [DisplayName(unk21_displayName)]
                public virtual uint unk21 {
                    get => unk21_raw;
                    set {
                        if (unk21_raw == value) return;
                        unk21_raw = value;
                        ChangedItems.Add(nameof(unk21));
                        OnPropertyChanged(nameof(unk21));
                    }
                }

                [DisplayName("Offset")]
                public long unk21_offset { get; private set; }

                protected byte unk22_raw;
                public const string unk22_displayName = "unk22";
                public const int unk22_sortIndex = 1200;
                [SortOrder(unk22_sortIndex)]
                [DisplayName(unk22_displayName)]
                public virtual byte unk22 {
                    get => unk22_raw;
                    set {
                        if (unk22_raw == value) return;
                        unk22_raw = value;
                        ChangedItems.Add(nameof(unk22));
                        OnPropertyChanged(nameof(unk22));
                    }
                }

                [DisplayName("Offset")]
                public long unk22_offset { get; private set; }

                protected byte unk23_raw;
                public const string unk23_displayName = "unk23";
                public const int unk23_sortIndex = 1250;
                [SortOrder(unk23_sortIndex)]
                [DisplayName(unk23_displayName)]
                public virtual byte unk23 {
                    get => unk23_raw;
                    set {
                        if (unk23_raw == value) return;
                        unk23_raw = value;
                        ChangedItems.Add(nameof(unk23));
                        OnPropertyChanged(nameof(unk23));
                    }
                }

                [DisplayName("Offset")]
                public long unk23_offset { get; private set; }

                public const int lastSortIndex = 1300;

                public static ObservableMhwStructCollection<Parts2> LoadData(BinaryReader reader, Flinches parent) {
                    var list = new ObservableMhwStructCollection<Parts2>();
                    const ulong count = 1UL;
                    for (ulong i = 0; i < count; i++) {
                        list.Add(LoadData(reader, i, parent));
                    }
                    return list;
                }

                public static Parts2 LoadData(BinaryReader reader, ulong i, Flinches parent) {
                    var data = new Parts2();
                    data.Index = i;
                    data.Part_Id_LR_HR1_Normal_offset = reader.BaseStream.Position;
                    data.Part_Id_LR_HR1_Normal_raw = reader.ReadInt32();
                    data.Part_Id_LR_HR1_Wounded_offset = reader.BaseStream.Position;
                    data.Part_Id_LR_HR1_Wounded_raw = reader.ReadInt32();
                    data.Part_Id_LR_HR1_Special_Phase_1_offset = reader.BaseStream.Position;
                    data.Part_Id_LR_HR1_Special_Phase_1_raw = reader.ReadInt32();
                    data.Part_Id_LR_HR1_Special_Phase_2_offset = reader.BaseStream.Position;
                    data.Part_Id_LR_HR1_Special_Phase_2_raw = reader.ReadInt32();
                    data.Part_Id_LR_HR1_Special_Phase_3_offset = reader.BaseStream.Position;
                    data.Part_Id_LR_HR1_Special_Phase_3_raw = reader.ReadInt32();
                    data.Part_Id_MR1_Normal_offset = reader.BaseStream.Position;
                    data.Part_Id_MR1_Normal_raw = reader.ReadInt32();
                    data.Part_Id_MR1_Wounded_offset = reader.BaseStream.Position;
                    data.Part_Id_MR1_Wounded_raw = reader.ReadInt32();
                    data.Part_Id_MR1_Special_Phase_1_offset = reader.BaseStream.Position;
                    data.Part_Id_MR1_Special_Phase_1_raw = reader.ReadInt32();
                    data.Part_Id_MR1_Special_Phase_2_offset = reader.BaseStream.Position;
                    data.Part_Id_MR1_Special_Phase_2_raw = reader.ReadInt32();
                    data.Part_Id_MR1_Special_Phase_3_offset = reader.BaseStream.Position;
                    data.Part_Id_MR1_Special_Phase_3_raw = reader.ReadInt32();
                    data.Part_Id_LR_HR2_Normal_offset = reader.BaseStream.Position;
                    data.Part_Id_LR_HR2_Normal_raw = reader.ReadInt32();
                    data.Part_Id_LR_HR2_Wounded_offset = reader.BaseStream.Position;
                    data.Part_Id_LR_HR2_Wounded_raw = reader.ReadInt32();
                    data.Part_Id_LR_HR2_Special_Phase_1_offset = reader.BaseStream.Position;
                    data.Part_Id_LR_HR2_Special_Phase_1_raw = reader.ReadInt32();
                    data.Part_Id_LR_HR2_Special_Phase_2_offset = reader.BaseStream.Position;
                    data.Part_Id_LR_HR2_Special_Phase_2_raw = reader.ReadInt32();
                    data.Part_Id_LR_HR2_Special_Phase_3_offset = reader.BaseStream.Position;
                    data.Part_Id_LR_HR2_Special_Phase_3_raw = reader.ReadInt32();
                    data.Part_Id_MR2_Normal_offset = reader.BaseStream.Position;
                    data.Part_Id_MR2_Normal_raw = reader.ReadInt32();
                    data.Part_Id_MR2_Wounded_offset = reader.BaseStream.Position;
                    data.Part_Id_MR2_Wounded_raw = reader.ReadInt32();
                    data.Part_Id_MR2_Special_Phase_1_offset = reader.BaseStream.Position;
                    data.Part_Id_MR2_Special_Phase_1_raw = reader.ReadInt32();
                    data.Part_Id_MR2_Special_Phase_2_offset = reader.BaseStream.Position;
                    data.Part_Id_MR2_Special_Phase_2_raw = reader.ReadInt32();
                    data.Part_Id_MR2_Special_Phase_3_offset = reader.BaseStream.Position;
                    data.Part_Id_MR2_Special_Phase_3_raw = reader.ReadInt32();
                    data.unk19_offset = reader.BaseStream.Position;
                    data.unk19_raw = reader.ReadUInt32();
                    data.unk20_offset = reader.BaseStream.Position;
                    data.unk20_raw = reader.ReadUInt32();
                    data.unk21_offset = reader.BaseStream.Position;
                    data.unk21_raw = reader.ReadUInt32();
                    data.unk22_offset = reader.BaseStream.Position;
                    data.unk22_raw = reader.ReadByte();
                    data.unk23_offset = reader.BaseStream.Position;
                    data.unk23_raw = reader.ReadByte();
                    return data;
                }

                public void WriteData(BinaryWriter writer, Flinches parent) {
                    writer.Write(Part_Id_LR_HR1_Normal_raw);
                    writer.Write(Part_Id_LR_HR1_Wounded_raw);
                    writer.Write(Part_Id_LR_HR1_Special_Phase_1_raw);
                    writer.Write(Part_Id_LR_HR1_Special_Phase_2_raw);
                    writer.Write(Part_Id_LR_HR1_Special_Phase_3_raw);
                    writer.Write(Part_Id_MR1_Normal_raw);
                    writer.Write(Part_Id_MR1_Wounded_raw);
                    writer.Write(Part_Id_MR1_Special_Phase_1_raw);
                    writer.Write(Part_Id_MR1_Special_Phase_2_raw);
                    writer.Write(Part_Id_MR1_Special_Phase_3_raw);
                    writer.Write(Part_Id_LR_HR2_Normal_raw);
                    writer.Write(Part_Id_LR_HR2_Wounded_raw);
                    writer.Write(Part_Id_LR_HR2_Special_Phase_1_raw);
                    writer.Write(Part_Id_LR_HR2_Special_Phase_2_raw);
                    writer.Write(Part_Id_LR_HR2_Special_Phase_3_raw);
                    writer.Write(Part_Id_MR2_Normal_raw);
                    writer.Write(Part_Id_MR2_Wounded_raw);
                    writer.Write(Part_Id_MR2_Special_Phase_1_raw);
                    writer.Write(Part_Id_MR2_Special_Phase_2_raw);
                    writer.Write(Part_Id_MR2_Special_Phase_3_raw);
                    writer.Write(unk19_raw);
                    writer.Write(unk20_raw);
                    writer.Write(unk21_raw);
                    writer.Write(unk22_raw);
                    writer.Write(unk23_raw);
                }

                public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                    return new ObservableCollection<MultiStructItemCustomView> {
                        new MultiStructItemCustomView(this, "Part Id LR/HR1 Normal", "Part_Id_LR_HR1_Normal", "Part_Id_LR_HR1_Normal_offset"),
                        new MultiStructItemCustomView(this, "Part Id LR/HR1 Wounded", "Part_Id_LR_HR1_Wounded", "Part_Id_LR_HR1_Wounded_offset"),
                        new MultiStructItemCustomView(this, "Part Id LR/HR1 Special Phase 1", "Part_Id_LR_HR1_Special_Phase_1", "Part_Id_LR_HR1_Special_Phase_1_offset"),
                        new MultiStructItemCustomView(this, "Part Id LR/HR1 Special Phase 2", "Part_Id_LR_HR1_Special_Phase_2", "Part_Id_LR_HR1_Special_Phase_2_offset"),
                        new MultiStructItemCustomView(this, "Part Id LR/HR1 Special Phase 3", "Part_Id_LR_HR1_Special_Phase_3", "Part_Id_LR_HR1_Special_Phase_3_offset"),
                        new MultiStructItemCustomView(this, "Part Id MR1 Normal", "Part_Id_MR1_Normal", "Part_Id_MR1_Normal_offset"),
                        new MultiStructItemCustomView(this, "Part Id MR1 Wounded", "Part_Id_MR1_Wounded", "Part_Id_MR1_Wounded_offset"),
                        new MultiStructItemCustomView(this, "Part Id MR1 Special Phase 1", "Part_Id_MR1_Special_Phase_1", "Part_Id_MR1_Special_Phase_1_offset"),
                        new MultiStructItemCustomView(this, "Part Id MR1 Special Phase 2", "Part_Id_MR1_Special_Phase_2", "Part_Id_MR1_Special_Phase_2_offset"),
                        new MultiStructItemCustomView(this, "Part Id MR1 Special Phase 3", "Part_Id_MR1_Special_Phase_3", "Part_Id_MR1_Special_Phase_3_offset"),
                        new MultiStructItemCustomView(this, "Part Id LR/HR2 Normal", "Part_Id_LR_HR2_Normal", "Part_Id_LR_HR2_Normal_offset"),
                        new MultiStructItemCustomView(this, "Part Id LR/HR2 Wounded", "Part_Id_LR_HR2_Wounded", "Part_Id_LR_HR2_Wounded_offset"),
                        new MultiStructItemCustomView(this, "Part Id LR/HR2 Special Phase 1", "Part_Id_LR_HR2_Special_Phase_1", "Part_Id_LR_HR2_Special_Phase_1_offset"),
                        new MultiStructItemCustomView(this, "Part Id LR/HR2 Special Phase 2", "Part_Id_LR_HR2_Special_Phase_2", "Part_Id_LR_HR2_Special_Phase_2_offset"),
                        new MultiStructItemCustomView(this, "Part Id LR/HR2 Special Phase 3", "Part_Id_LR_HR2_Special_Phase_3", "Part_Id_LR_HR2_Special_Phase_3_offset"),
                        new MultiStructItemCustomView(this, "Part Id MR2 Normal", "Part_Id_MR2_Normal", "Part_Id_MR2_Normal_offset"),
                        new MultiStructItemCustomView(this, "Part Id MR2 Wounded", "Part_Id_MR2_Wounded", "Part_Id_MR2_Wounded_offset"),
                        new MultiStructItemCustomView(this, "Part Id MR2 Special Phase 1", "Part_Id_MR2_Special_Phase_1", "Part_Id_MR2_Special_Phase_1_offset"),
                        new MultiStructItemCustomView(this, "Part Id MR2 Special Phase 2", "Part_Id_MR2_Special_Phase_2", "Part_Id_MR2_Special_Phase_2_offset"),
                        new MultiStructItemCustomView(this, "Part Id MR2 Special Phase 3", "Part_Id_MR2_Special_Phase_3", "Part_Id_MR2_Special_Phase_3_offset"),
                        new MultiStructItemCustomView(this, "unk19", "unk19", "unk19_offset"),
                        new MultiStructItemCustomView(this, "unk20", "unk20", "unk20_offset"),
                        new MultiStructItemCustomView(this, "unk21", "unk21", "unk21_offset"),
                        new MultiStructItemCustomView(this, "unk22", "unk22", "unk22_offset"),
                        new MultiStructItemCustomView(this, "unk23", "unk23", "unk23_offset"),
                    };
                }
            }

            public const string Parts2_displayName = "Parts2";
            public const int Parts2_sortIndex = 400;
            [SortOrder(Parts2_sortIndex)]
            [DisplayName(Parts2_displayName)]
            protected virtual ObservableCollection<Parts2> Parts2_raw { get; set; }

            public partial class Parts3 : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteDataInner<Flinches> {
                public const ulong FixedSizeCount = 1;
                public const string GridName = "Parts3";

                protected int Part_Id_LR_HR1_Normal_raw;
                public const string Part_Id_LR_HR1_Normal_displayName = "Part Id LR/HR1 Normal";
                public const int Part_Id_LR_HR1_Normal_sortIndex = 50;
                [SortOrder(Part_Id_LR_HR1_Normal_sortIndex)]
                [DisplayName(Part_Id_LR_HR1_Normal_displayName)]
                public virtual int Part_Id_LR_HR1_Normal {
                    get => Part_Id_LR_HR1_Normal_raw;
                    set {
                        if (Part_Id_LR_HR1_Normal_raw == value) return;
                        Part_Id_LR_HR1_Normal_raw = value;
                        ChangedItems.Add(nameof(Part_Id_LR_HR1_Normal));
                        OnPropertyChanged(nameof(Part_Id_LR_HR1_Normal));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_LR_HR1_Normal_offset { get; private set; }

                protected int Part_Id_LR_HR1_Wounded_raw;
                public const string Part_Id_LR_HR1_Wounded_displayName = "Part Id LR/HR1 Wounded";
                public const int Part_Id_LR_HR1_Wounded_sortIndex = 100;
                [SortOrder(Part_Id_LR_HR1_Wounded_sortIndex)]
                [DisplayName(Part_Id_LR_HR1_Wounded_displayName)]
                public virtual int Part_Id_LR_HR1_Wounded {
                    get => Part_Id_LR_HR1_Wounded_raw;
                    set {
                        if (Part_Id_LR_HR1_Wounded_raw == value) return;
                        Part_Id_LR_HR1_Wounded_raw = value;
                        ChangedItems.Add(nameof(Part_Id_LR_HR1_Wounded));
                        OnPropertyChanged(nameof(Part_Id_LR_HR1_Wounded));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_LR_HR1_Wounded_offset { get; private set; }

                protected int Part_Id_LR_HR1_Special_Phase_1_raw;
                public const string Part_Id_LR_HR1_Special_Phase_1_displayName = "Part Id LR/HR1 Special Phase 1";
                public const int Part_Id_LR_HR1_Special_Phase_1_sortIndex = 150;
                [SortOrder(Part_Id_LR_HR1_Special_Phase_1_sortIndex)]
                [DisplayName(Part_Id_LR_HR1_Special_Phase_1_displayName)]
                public virtual int Part_Id_LR_HR1_Special_Phase_1 {
                    get => Part_Id_LR_HR1_Special_Phase_1_raw;
                    set {
                        if (Part_Id_LR_HR1_Special_Phase_1_raw == value) return;
                        Part_Id_LR_HR1_Special_Phase_1_raw = value;
                        ChangedItems.Add(nameof(Part_Id_LR_HR1_Special_Phase_1));
                        OnPropertyChanged(nameof(Part_Id_LR_HR1_Special_Phase_1));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_LR_HR1_Special_Phase_1_offset { get; private set; }

                protected int Part_Id_LR_HR1_Special_Phase_2_raw;
                public const string Part_Id_LR_HR1_Special_Phase_2_displayName = "Part Id LR/HR1 Special Phase 2";
                public const int Part_Id_LR_HR1_Special_Phase_2_sortIndex = 200;
                [SortOrder(Part_Id_LR_HR1_Special_Phase_2_sortIndex)]
                [DisplayName(Part_Id_LR_HR1_Special_Phase_2_displayName)]
                public virtual int Part_Id_LR_HR1_Special_Phase_2 {
                    get => Part_Id_LR_HR1_Special_Phase_2_raw;
                    set {
                        if (Part_Id_LR_HR1_Special_Phase_2_raw == value) return;
                        Part_Id_LR_HR1_Special_Phase_2_raw = value;
                        ChangedItems.Add(nameof(Part_Id_LR_HR1_Special_Phase_2));
                        OnPropertyChanged(nameof(Part_Id_LR_HR1_Special_Phase_2));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_LR_HR1_Special_Phase_2_offset { get; private set; }

                protected int Part_Id_LR_HR1_Special_Phase_3_raw;
                public const string Part_Id_LR_HR1_Special_Phase_3_displayName = "Part Id LR/HR1 Special Phase 3";
                public const int Part_Id_LR_HR1_Special_Phase_3_sortIndex = 250;
                [SortOrder(Part_Id_LR_HR1_Special_Phase_3_sortIndex)]
                [DisplayName(Part_Id_LR_HR1_Special_Phase_3_displayName)]
                public virtual int Part_Id_LR_HR1_Special_Phase_3 {
                    get => Part_Id_LR_HR1_Special_Phase_3_raw;
                    set {
                        if (Part_Id_LR_HR1_Special_Phase_3_raw == value) return;
                        Part_Id_LR_HR1_Special_Phase_3_raw = value;
                        ChangedItems.Add(nameof(Part_Id_LR_HR1_Special_Phase_3));
                        OnPropertyChanged(nameof(Part_Id_LR_HR1_Special_Phase_3));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_LR_HR1_Special_Phase_3_offset { get; private set; }

                protected int Part_Id_MR1_Normal_raw;
                public const string Part_Id_MR1_Normal_displayName = "Part Id MR1 Normal";
                public const int Part_Id_MR1_Normal_sortIndex = 300;
                [SortOrder(Part_Id_MR1_Normal_sortIndex)]
                [DisplayName(Part_Id_MR1_Normal_displayName)]
                public virtual int Part_Id_MR1_Normal {
                    get => Part_Id_MR1_Normal_raw;
                    set {
                        if (Part_Id_MR1_Normal_raw == value) return;
                        Part_Id_MR1_Normal_raw = value;
                        ChangedItems.Add(nameof(Part_Id_MR1_Normal));
                        OnPropertyChanged(nameof(Part_Id_MR1_Normal));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_MR1_Normal_offset { get; private set; }

                protected int Part_Id_MR1_Wounded_raw;
                public const string Part_Id_MR1_Wounded_displayName = "Part Id MR1 Wounded";
                public const int Part_Id_MR1_Wounded_sortIndex = 350;
                [SortOrder(Part_Id_MR1_Wounded_sortIndex)]
                [DisplayName(Part_Id_MR1_Wounded_displayName)]
                public virtual int Part_Id_MR1_Wounded {
                    get => Part_Id_MR1_Wounded_raw;
                    set {
                        if (Part_Id_MR1_Wounded_raw == value) return;
                        Part_Id_MR1_Wounded_raw = value;
                        ChangedItems.Add(nameof(Part_Id_MR1_Wounded));
                        OnPropertyChanged(nameof(Part_Id_MR1_Wounded));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_MR1_Wounded_offset { get; private set; }

                protected int Part_Id_MR1_Special_Phase_1_raw;
                public const string Part_Id_MR1_Special_Phase_1_displayName = "Part Id MR1 Special Phase 1";
                public const int Part_Id_MR1_Special_Phase_1_sortIndex = 400;
                [SortOrder(Part_Id_MR1_Special_Phase_1_sortIndex)]
                [DisplayName(Part_Id_MR1_Special_Phase_1_displayName)]
                public virtual int Part_Id_MR1_Special_Phase_1 {
                    get => Part_Id_MR1_Special_Phase_1_raw;
                    set {
                        if (Part_Id_MR1_Special_Phase_1_raw == value) return;
                        Part_Id_MR1_Special_Phase_1_raw = value;
                        ChangedItems.Add(nameof(Part_Id_MR1_Special_Phase_1));
                        OnPropertyChanged(nameof(Part_Id_MR1_Special_Phase_1));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_MR1_Special_Phase_1_offset { get; private set; }

                protected int Part_Id_MR1_Special_Phase_2_raw;
                public const string Part_Id_MR1_Special_Phase_2_displayName = "Part Id MR1 Special Phase 2";
                public const int Part_Id_MR1_Special_Phase_2_sortIndex = 450;
                [SortOrder(Part_Id_MR1_Special_Phase_2_sortIndex)]
                [DisplayName(Part_Id_MR1_Special_Phase_2_displayName)]
                public virtual int Part_Id_MR1_Special_Phase_2 {
                    get => Part_Id_MR1_Special_Phase_2_raw;
                    set {
                        if (Part_Id_MR1_Special_Phase_2_raw == value) return;
                        Part_Id_MR1_Special_Phase_2_raw = value;
                        ChangedItems.Add(nameof(Part_Id_MR1_Special_Phase_2));
                        OnPropertyChanged(nameof(Part_Id_MR1_Special_Phase_2));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_MR1_Special_Phase_2_offset { get; private set; }

                protected int Part_Id_MR1_Special_Phase_3_raw;
                public const string Part_Id_MR1_Special_Phase_3_displayName = "Part Id MR1 Special Phase 3";
                public const int Part_Id_MR1_Special_Phase_3_sortIndex = 500;
                [SortOrder(Part_Id_MR1_Special_Phase_3_sortIndex)]
                [DisplayName(Part_Id_MR1_Special_Phase_3_displayName)]
                public virtual int Part_Id_MR1_Special_Phase_3 {
                    get => Part_Id_MR1_Special_Phase_3_raw;
                    set {
                        if (Part_Id_MR1_Special_Phase_3_raw == value) return;
                        Part_Id_MR1_Special_Phase_3_raw = value;
                        ChangedItems.Add(nameof(Part_Id_MR1_Special_Phase_3));
                        OnPropertyChanged(nameof(Part_Id_MR1_Special_Phase_3));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_MR1_Special_Phase_3_offset { get; private set; }

                protected int Part_Id_LR_HR2_Normal_raw;
                public const string Part_Id_LR_HR2_Normal_displayName = "Part Id LR/HR2 Normal";
                public const int Part_Id_LR_HR2_Normal_sortIndex = 550;
                [SortOrder(Part_Id_LR_HR2_Normal_sortIndex)]
                [DisplayName(Part_Id_LR_HR2_Normal_displayName)]
                public virtual int Part_Id_LR_HR2_Normal {
                    get => Part_Id_LR_HR2_Normal_raw;
                    set {
                        if (Part_Id_LR_HR2_Normal_raw == value) return;
                        Part_Id_LR_HR2_Normal_raw = value;
                        ChangedItems.Add(nameof(Part_Id_LR_HR2_Normal));
                        OnPropertyChanged(nameof(Part_Id_LR_HR2_Normal));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_LR_HR2_Normal_offset { get; private set; }

                protected int Part_Id_LR_HR2_Wounded_raw;
                public const string Part_Id_LR_HR2_Wounded_displayName = "Part Id LR/HR2 Wounded";
                public const int Part_Id_LR_HR2_Wounded_sortIndex = 600;
                [SortOrder(Part_Id_LR_HR2_Wounded_sortIndex)]
                [DisplayName(Part_Id_LR_HR2_Wounded_displayName)]
                public virtual int Part_Id_LR_HR2_Wounded {
                    get => Part_Id_LR_HR2_Wounded_raw;
                    set {
                        if (Part_Id_LR_HR2_Wounded_raw == value) return;
                        Part_Id_LR_HR2_Wounded_raw = value;
                        ChangedItems.Add(nameof(Part_Id_LR_HR2_Wounded));
                        OnPropertyChanged(nameof(Part_Id_LR_HR2_Wounded));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_LR_HR2_Wounded_offset { get; private set; }

                protected int Part_Id_LR_HR2_Special_Phase_1_raw;
                public const string Part_Id_LR_HR2_Special_Phase_1_displayName = "Part Id LR/HR2 Special Phase 1";
                public const int Part_Id_LR_HR2_Special_Phase_1_sortIndex = 650;
                [SortOrder(Part_Id_LR_HR2_Special_Phase_1_sortIndex)]
                [DisplayName(Part_Id_LR_HR2_Special_Phase_1_displayName)]
                public virtual int Part_Id_LR_HR2_Special_Phase_1 {
                    get => Part_Id_LR_HR2_Special_Phase_1_raw;
                    set {
                        if (Part_Id_LR_HR2_Special_Phase_1_raw == value) return;
                        Part_Id_LR_HR2_Special_Phase_1_raw = value;
                        ChangedItems.Add(nameof(Part_Id_LR_HR2_Special_Phase_1));
                        OnPropertyChanged(nameof(Part_Id_LR_HR2_Special_Phase_1));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_LR_HR2_Special_Phase_1_offset { get; private set; }

                protected int Part_Id_LR_HR2_Special_Phase_2_raw;
                public const string Part_Id_LR_HR2_Special_Phase_2_displayName = "Part Id LR/HR2 Special Phase 2";
                public const int Part_Id_LR_HR2_Special_Phase_2_sortIndex = 700;
                [SortOrder(Part_Id_LR_HR2_Special_Phase_2_sortIndex)]
                [DisplayName(Part_Id_LR_HR2_Special_Phase_2_displayName)]
                public virtual int Part_Id_LR_HR2_Special_Phase_2 {
                    get => Part_Id_LR_HR2_Special_Phase_2_raw;
                    set {
                        if (Part_Id_LR_HR2_Special_Phase_2_raw == value) return;
                        Part_Id_LR_HR2_Special_Phase_2_raw = value;
                        ChangedItems.Add(nameof(Part_Id_LR_HR2_Special_Phase_2));
                        OnPropertyChanged(nameof(Part_Id_LR_HR2_Special_Phase_2));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_LR_HR2_Special_Phase_2_offset { get; private set; }

                protected int Part_Id_LR_HR2_Special_Phase_3_raw;
                public const string Part_Id_LR_HR2_Special_Phase_3_displayName = "Part Id LR/HR2 Special Phase 3";
                public const int Part_Id_LR_HR2_Special_Phase_3_sortIndex = 750;
                [SortOrder(Part_Id_LR_HR2_Special_Phase_3_sortIndex)]
                [DisplayName(Part_Id_LR_HR2_Special_Phase_3_displayName)]
                public virtual int Part_Id_LR_HR2_Special_Phase_3 {
                    get => Part_Id_LR_HR2_Special_Phase_3_raw;
                    set {
                        if (Part_Id_LR_HR2_Special_Phase_3_raw == value) return;
                        Part_Id_LR_HR2_Special_Phase_3_raw = value;
                        ChangedItems.Add(nameof(Part_Id_LR_HR2_Special_Phase_3));
                        OnPropertyChanged(nameof(Part_Id_LR_HR2_Special_Phase_3));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_LR_HR2_Special_Phase_3_offset { get; private set; }

                protected int Part_Id_MR2_Normal_raw;
                public const string Part_Id_MR2_Normal_displayName = "Part Id MR2 Normal";
                public const int Part_Id_MR2_Normal_sortIndex = 800;
                [SortOrder(Part_Id_MR2_Normal_sortIndex)]
                [DisplayName(Part_Id_MR2_Normal_displayName)]
                public virtual int Part_Id_MR2_Normal {
                    get => Part_Id_MR2_Normal_raw;
                    set {
                        if (Part_Id_MR2_Normal_raw == value) return;
                        Part_Id_MR2_Normal_raw = value;
                        ChangedItems.Add(nameof(Part_Id_MR2_Normal));
                        OnPropertyChanged(nameof(Part_Id_MR2_Normal));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_MR2_Normal_offset { get; private set; }

                protected int Part_Id_MR2_Wounded_raw;
                public const string Part_Id_MR2_Wounded_displayName = "Part Id MR2 Wounded";
                public const int Part_Id_MR2_Wounded_sortIndex = 850;
                [SortOrder(Part_Id_MR2_Wounded_sortIndex)]
                [DisplayName(Part_Id_MR2_Wounded_displayName)]
                public virtual int Part_Id_MR2_Wounded {
                    get => Part_Id_MR2_Wounded_raw;
                    set {
                        if (Part_Id_MR2_Wounded_raw == value) return;
                        Part_Id_MR2_Wounded_raw = value;
                        ChangedItems.Add(nameof(Part_Id_MR2_Wounded));
                        OnPropertyChanged(nameof(Part_Id_MR2_Wounded));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_MR2_Wounded_offset { get; private set; }

                protected int Part_Id_MR2_Special_Phase_1_raw;
                public const string Part_Id_MR2_Special_Phase_1_displayName = "Part Id MR2 Special Phase 1";
                public const int Part_Id_MR2_Special_Phase_1_sortIndex = 900;
                [SortOrder(Part_Id_MR2_Special_Phase_1_sortIndex)]
                [DisplayName(Part_Id_MR2_Special_Phase_1_displayName)]
                public virtual int Part_Id_MR2_Special_Phase_1 {
                    get => Part_Id_MR2_Special_Phase_1_raw;
                    set {
                        if (Part_Id_MR2_Special_Phase_1_raw == value) return;
                        Part_Id_MR2_Special_Phase_1_raw = value;
                        ChangedItems.Add(nameof(Part_Id_MR2_Special_Phase_1));
                        OnPropertyChanged(nameof(Part_Id_MR2_Special_Phase_1));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_MR2_Special_Phase_1_offset { get; private set; }

                protected int Part_Id_MR2_Special_Phase_2_raw;
                public const string Part_Id_MR2_Special_Phase_2_displayName = "Part Id MR2 Special Phase 2";
                public const int Part_Id_MR2_Special_Phase_2_sortIndex = 950;
                [SortOrder(Part_Id_MR2_Special_Phase_2_sortIndex)]
                [DisplayName(Part_Id_MR2_Special_Phase_2_displayName)]
                public virtual int Part_Id_MR2_Special_Phase_2 {
                    get => Part_Id_MR2_Special_Phase_2_raw;
                    set {
                        if (Part_Id_MR2_Special_Phase_2_raw == value) return;
                        Part_Id_MR2_Special_Phase_2_raw = value;
                        ChangedItems.Add(nameof(Part_Id_MR2_Special_Phase_2));
                        OnPropertyChanged(nameof(Part_Id_MR2_Special_Phase_2));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_MR2_Special_Phase_2_offset { get; private set; }

                protected int Part_Id_MR2_Special_Phase_3_raw;
                public const string Part_Id_MR2_Special_Phase_3_displayName = "Part Id MR2 Special Phase 3";
                public const int Part_Id_MR2_Special_Phase_3_sortIndex = 1000;
                [SortOrder(Part_Id_MR2_Special_Phase_3_sortIndex)]
                [DisplayName(Part_Id_MR2_Special_Phase_3_displayName)]
                public virtual int Part_Id_MR2_Special_Phase_3 {
                    get => Part_Id_MR2_Special_Phase_3_raw;
                    set {
                        if (Part_Id_MR2_Special_Phase_3_raw == value) return;
                        Part_Id_MR2_Special_Phase_3_raw = value;
                        ChangedItems.Add(nameof(Part_Id_MR2_Special_Phase_3));
                        OnPropertyChanged(nameof(Part_Id_MR2_Special_Phase_3));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_MR2_Special_Phase_3_offset { get; private set; }

                protected int Part_Id_LR_HR3_Normal_raw;
                public const string Part_Id_LR_HR3_Normal_displayName = "Part Id LR/HR3 Normal";
                public const int Part_Id_LR_HR3_Normal_sortIndex = 1050;
                [SortOrder(Part_Id_LR_HR3_Normal_sortIndex)]
                [DisplayName(Part_Id_LR_HR3_Normal_displayName)]
                public virtual int Part_Id_LR_HR3_Normal {
                    get => Part_Id_LR_HR3_Normal_raw;
                    set {
                        if (Part_Id_LR_HR3_Normal_raw == value) return;
                        Part_Id_LR_HR3_Normal_raw = value;
                        ChangedItems.Add(nameof(Part_Id_LR_HR3_Normal));
                        OnPropertyChanged(nameof(Part_Id_LR_HR3_Normal));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_LR_HR3_Normal_offset { get; private set; }

                protected int Part_Id_LR_HR3_Wounded_raw;
                public const string Part_Id_LR_HR3_Wounded_displayName = "Part Id LR/HR3 Wounded";
                public const int Part_Id_LR_HR3_Wounded_sortIndex = 1100;
                [SortOrder(Part_Id_LR_HR3_Wounded_sortIndex)]
                [DisplayName(Part_Id_LR_HR3_Wounded_displayName)]
                public virtual int Part_Id_LR_HR3_Wounded {
                    get => Part_Id_LR_HR3_Wounded_raw;
                    set {
                        if (Part_Id_LR_HR3_Wounded_raw == value) return;
                        Part_Id_LR_HR3_Wounded_raw = value;
                        ChangedItems.Add(nameof(Part_Id_LR_HR3_Wounded));
                        OnPropertyChanged(nameof(Part_Id_LR_HR3_Wounded));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_LR_HR3_Wounded_offset { get; private set; }

                protected int Part_Id_LR_HR3_Special_Phase_1_raw;
                public const string Part_Id_LR_HR3_Special_Phase_1_displayName = "Part Id LR/HR3 Special Phase 1";
                public const int Part_Id_LR_HR3_Special_Phase_1_sortIndex = 1150;
                [SortOrder(Part_Id_LR_HR3_Special_Phase_1_sortIndex)]
                [DisplayName(Part_Id_LR_HR3_Special_Phase_1_displayName)]
                public virtual int Part_Id_LR_HR3_Special_Phase_1 {
                    get => Part_Id_LR_HR3_Special_Phase_1_raw;
                    set {
                        if (Part_Id_LR_HR3_Special_Phase_1_raw == value) return;
                        Part_Id_LR_HR3_Special_Phase_1_raw = value;
                        ChangedItems.Add(nameof(Part_Id_LR_HR3_Special_Phase_1));
                        OnPropertyChanged(nameof(Part_Id_LR_HR3_Special_Phase_1));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_LR_HR3_Special_Phase_1_offset { get; private set; }

                protected int Part_Id_LR_HR3_Special_Phase_2_raw;
                public const string Part_Id_LR_HR3_Special_Phase_2_displayName = "Part Id LR/HR3 Special Phase 2";
                public const int Part_Id_LR_HR3_Special_Phase_2_sortIndex = 1200;
                [SortOrder(Part_Id_LR_HR3_Special_Phase_2_sortIndex)]
                [DisplayName(Part_Id_LR_HR3_Special_Phase_2_displayName)]
                public virtual int Part_Id_LR_HR3_Special_Phase_2 {
                    get => Part_Id_LR_HR3_Special_Phase_2_raw;
                    set {
                        if (Part_Id_LR_HR3_Special_Phase_2_raw == value) return;
                        Part_Id_LR_HR3_Special_Phase_2_raw = value;
                        ChangedItems.Add(nameof(Part_Id_LR_HR3_Special_Phase_2));
                        OnPropertyChanged(nameof(Part_Id_LR_HR3_Special_Phase_2));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_LR_HR3_Special_Phase_2_offset { get; private set; }

                protected int Part_Id_LR_HR3_Special_Phase_3_raw;
                public const string Part_Id_LR_HR3_Special_Phase_3_displayName = "Part Id LR/HR3 Special Phase 3";
                public const int Part_Id_LR_HR3_Special_Phase_3_sortIndex = 1250;
                [SortOrder(Part_Id_LR_HR3_Special_Phase_3_sortIndex)]
                [DisplayName(Part_Id_LR_HR3_Special_Phase_3_displayName)]
                public virtual int Part_Id_LR_HR3_Special_Phase_3 {
                    get => Part_Id_LR_HR3_Special_Phase_3_raw;
                    set {
                        if (Part_Id_LR_HR3_Special_Phase_3_raw == value) return;
                        Part_Id_LR_HR3_Special_Phase_3_raw = value;
                        ChangedItems.Add(nameof(Part_Id_LR_HR3_Special_Phase_3));
                        OnPropertyChanged(nameof(Part_Id_LR_HR3_Special_Phase_3));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_LR_HR3_Special_Phase_3_offset { get; private set; }

                protected int Part_Id_MR3_Normal_raw;
                public const string Part_Id_MR3_Normal_displayName = "Part Id MR3 Normal";
                public const int Part_Id_MR3_Normal_sortIndex = 1300;
                [SortOrder(Part_Id_MR3_Normal_sortIndex)]
                [DisplayName(Part_Id_MR3_Normal_displayName)]
                public virtual int Part_Id_MR3_Normal {
                    get => Part_Id_MR3_Normal_raw;
                    set {
                        if (Part_Id_MR3_Normal_raw == value) return;
                        Part_Id_MR3_Normal_raw = value;
                        ChangedItems.Add(nameof(Part_Id_MR3_Normal));
                        OnPropertyChanged(nameof(Part_Id_MR3_Normal));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_MR3_Normal_offset { get; private set; }

                protected int Part_Id_MR3_Wounded_raw;
                public const string Part_Id_MR3_Wounded_displayName = "Part Id MR3 Wounded";
                public const int Part_Id_MR3_Wounded_sortIndex = 1350;
                [SortOrder(Part_Id_MR3_Wounded_sortIndex)]
                [DisplayName(Part_Id_MR3_Wounded_displayName)]
                public virtual int Part_Id_MR3_Wounded {
                    get => Part_Id_MR3_Wounded_raw;
                    set {
                        if (Part_Id_MR3_Wounded_raw == value) return;
                        Part_Id_MR3_Wounded_raw = value;
                        ChangedItems.Add(nameof(Part_Id_MR3_Wounded));
                        OnPropertyChanged(nameof(Part_Id_MR3_Wounded));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_MR3_Wounded_offset { get; private set; }

                protected int Part_Id_MR3_Special_Phase_1_raw;
                public const string Part_Id_MR3_Special_Phase_1_displayName = "Part Id MR3 Special Phase 1";
                public const int Part_Id_MR3_Special_Phase_1_sortIndex = 1400;
                [SortOrder(Part_Id_MR3_Special_Phase_1_sortIndex)]
                [DisplayName(Part_Id_MR3_Special_Phase_1_displayName)]
                public virtual int Part_Id_MR3_Special_Phase_1 {
                    get => Part_Id_MR3_Special_Phase_1_raw;
                    set {
                        if (Part_Id_MR3_Special_Phase_1_raw == value) return;
                        Part_Id_MR3_Special_Phase_1_raw = value;
                        ChangedItems.Add(nameof(Part_Id_MR3_Special_Phase_1));
                        OnPropertyChanged(nameof(Part_Id_MR3_Special_Phase_1));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_MR3_Special_Phase_1_offset { get; private set; }

                protected int Part_Id_MR3_Special_Phase_2_raw;
                public const string Part_Id_MR3_Special_Phase_2_displayName = "Part Id MR3 Special Phase 2";
                public const int Part_Id_MR3_Special_Phase_2_sortIndex = 1450;
                [SortOrder(Part_Id_MR3_Special_Phase_2_sortIndex)]
                [DisplayName(Part_Id_MR3_Special_Phase_2_displayName)]
                public virtual int Part_Id_MR3_Special_Phase_2 {
                    get => Part_Id_MR3_Special_Phase_2_raw;
                    set {
                        if (Part_Id_MR3_Special_Phase_2_raw == value) return;
                        Part_Id_MR3_Special_Phase_2_raw = value;
                        ChangedItems.Add(nameof(Part_Id_MR3_Special_Phase_2));
                        OnPropertyChanged(nameof(Part_Id_MR3_Special_Phase_2));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_MR3_Special_Phase_2_offset { get; private set; }

                protected int Part_Id_MR3_Special_Phase_3_raw;
                public const string Part_Id_MR3_Special_Phase_3_displayName = "Part Id MR3 Special Phase 3";
                public const int Part_Id_MR3_Special_Phase_3_sortIndex = 1500;
                [SortOrder(Part_Id_MR3_Special_Phase_3_sortIndex)]
                [DisplayName(Part_Id_MR3_Special_Phase_3_displayName)]
                public virtual int Part_Id_MR3_Special_Phase_3 {
                    get => Part_Id_MR3_Special_Phase_3_raw;
                    set {
                        if (Part_Id_MR3_Special_Phase_3_raw == value) return;
                        Part_Id_MR3_Special_Phase_3_raw = value;
                        ChangedItems.Add(nameof(Part_Id_MR3_Special_Phase_3));
                        OnPropertyChanged(nameof(Part_Id_MR3_Special_Phase_3));
                    }
                }

                [DisplayName("Offset")]
                public long Part_Id_MR3_Special_Phase_3_offset { get; private set; }

                protected uint unk29_raw;
                public const string unk29_displayName = "unk29";
                public const int unk29_sortIndex = 1550;
                [SortOrder(unk29_sortIndex)]
                [DisplayName(unk29_displayName)]
                public virtual uint unk29 {
                    get => unk29_raw;
                    set {
                        if (unk29_raw == value) return;
                        unk29_raw = value;
                        ChangedItems.Add(nameof(unk29));
                        OnPropertyChanged(nameof(unk29));
                    }
                }

                [DisplayName("Offset")]
                public long unk29_offset { get; private set; }

                protected uint unk30_raw;
                public const string unk30_displayName = "unk30";
                public const int unk30_sortIndex = 1600;
                [SortOrder(unk30_sortIndex)]
                [DisplayName(unk30_displayName)]
                public virtual uint unk30 {
                    get => unk30_raw;
                    set {
                        if (unk30_raw == value) return;
                        unk30_raw = value;
                        ChangedItems.Add(nameof(unk30));
                        OnPropertyChanged(nameof(unk30));
                    }
                }

                [DisplayName("Offset")]
                public long unk30_offset { get; private set; }

                protected uint unk31_raw;
                public const string unk31_displayName = "unk31";
                public const int unk31_sortIndex = 1650;
                [SortOrder(unk31_sortIndex)]
                [DisplayName(unk31_displayName)]
                public virtual uint unk31 {
                    get => unk31_raw;
                    set {
                        if (unk31_raw == value) return;
                        unk31_raw = value;
                        ChangedItems.Add(nameof(unk31));
                        OnPropertyChanged(nameof(unk31));
                    }
                }

                [DisplayName("Offset")]
                public long unk31_offset { get; private set; }

                protected byte unk32_raw;
                public const string unk32_displayName = "unk32";
                public const int unk32_sortIndex = 1700;
                [SortOrder(unk32_sortIndex)]
                [DisplayName(unk32_displayName)]
                public virtual byte unk32 {
                    get => unk32_raw;
                    set {
                        if (unk32_raw == value) return;
                        unk32_raw = value;
                        ChangedItems.Add(nameof(unk32));
                        OnPropertyChanged(nameof(unk32));
                    }
                }

                [DisplayName("Offset")]
                public long unk32_offset { get; private set; }

                protected byte unk33_raw;
                public const string unk33_displayName = "unk33";
                public const int unk33_sortIndex = 1750;
                [SortOrder(unk33_sortIndex)]
                [DisplayName(unk33_displayName)]
                public virtual byte unk33 {
                    get => unk33_raw;
                    set {
                        if (unk33_raw == value) return;
                        unk33_raw = value;
                        ChangedItems.Add(nameof(unk33));
                        OnPropertyChanged(nameof(unk33));
                    }
                }

                [DisplayName("Offset")]
                public long unk33_offset { get; private set; }

                public const int lastSortIndex = 1800;

                public static ObservableMhwStructCollection<Parts3> LoadData(BinaryReader reader, Flinches parent) {
                    var list = new ObservableMhwStructCollection<Parts3>();
                    const ulong count = 1UL;
                    for (ulong i = 0; i < count; i++) {
                        list.Add(LoadData(reader, i, parent));
                    }
                    return list;
                }

                public static Parts3 LoadData(BinaryReader reader, ulong i, Flinches parent) {
                    var data = new Parts3();
                    data.Index = i;
                    data.Part_Id_LR_HR1_Normal_offset = reader.BaseStream.Position;
                    data.Part_Id_LR_HR1_Normal_raw = reader.ReadInt32();
                    data.Part_Id_LR_HR1_Wounded_offset = reader.BaseStream.Position;
                    data.Part_Id_LR_HR1_Wounded_raw = reader.ReadInt32();
                    data.Part_Id_LR_HR1_Special_Phase_1_offset = reader.BaseStream.Position;
                    data.Part_Id_LR_HR1_Special_Phase_1_raw = reader.ReadInt32();
                    data.Part_Id_LR_HR1_Special_Phase_2_offset = reader.BaseStream.Position;
                    data.Part_Id_LR_HR1_Special_Phase_2_raw = reader.ReadInt32();
                    data.Part_Id_LR_HR1_Special_Phase_3_offset = reader.BaseStream.Position;
                    data.Part_Id_LR_HR1_Special_Phase_3_raw = reader.ReadInt32();
                    data.Part_Id_MR1_Normal_offset = reader.BaseStream.Position;
                    data.Part_Id_MR1_Normal_raw = reader.ReadInt32();
                    data.Part_Id_MR1_Wounded_offset = reader.BaseStream.Position;
                    data.Part_Id_MR1_Wounded_raw = reader.ReadInt32();
                    data.Part_Id_MR1_Special_Phase_1_offset = reader.BaseStream.Position;
                    data.Part_Id_MR1_Special_Phase_1_raw = reader.ReadInt32();
                    data.Part_Id_MR1_Special_Phase_2_offset = reader.BaseStream.Position;
                    data.Part_Id_MR1_Special_Phase_2_raw = reader.ReadInt32();
                    data.Part_Id_MR1_Special_Phase_3_offset = reader.BaseStream.Position;
                    data.Part_Id_MR1_Special_Phase_3_raw = reader.ReadInt32();
                    data.Part_Id_LR_HR2_Normal_offset = reader.BaseStream.Position;
                    data.Part_Id_LR_HR2_Normal_raw = reader.ReadInt32();
                    data.Part_Id_LR_HR2_Wounded_offset = reader.BaseStream.Position;
                    data.Part_Id_LR_HR2_Wounded_raw = reader.ReadInt32();
                    data.Part_Id_LR_HR2_Special_Phase_1_offset = reader.BaseStream.Position;
                    data.Part_Id_LR_HR2_Special_Phase_1_raw = reader.ReadInt32();
                    data.Part_Id_LR_HR2_Special_Phase_2_offset = reader.BaseStream.Position;
                    data.Part_Id_LR_HR2_Special_Phase_2_raw = reader.ReadInt32();
                    data.Part_Id_LR_HR2_Special_Phase_3_offset = reader.BaseStream.Position;
                    data.Part_Id_LR_HR2_Special_Phase_3_raw = reader.ReadInt32();
                    data.Part_Id_MR2_Normal_offset = reader.BaseStream.Position;
                    data.Part_Id_MR2_Normal_raw = reader.ReadInt32();
                    data.Part_Id_MR2_Wounded_offset = reader.BaseStream.Position;
                    data.Part_Id_MR2_Wounded_raw = reader.ReadInt32();
                    data.Part_Id_MR2_Special_Phase_1_offset = reader.BaseStream.Position;
                    data.Part_Id_MR2_Special_Phase_1_raw = reader.ReadInt32();
                    data.Part_Id_MR2_Special_Phase_2_offset = reader.BaseStream.Position;
                    data.Part_Id_MR2_Special_Phase_2_raw = reader.ReadInt32();
                    data.Part_Id_MR2_Special_Phase_3_offset = reader.BaseStream.Position;
                    data.Part_Id_MR2_Special_Phase_3_raw = reader.ReadInt32();
                    data.Part_Id_LR_HR3_Normal_offset = reader.BaseStream.Position;
                    data.Part_Id_LR_HR3_Normal_raw = reader.ReadInt32();
                    data.Part_Id_LR_HR3_Wounded_offset = reader.BaseStream.Position;
                    data.Part_Id_LR_HR3_Wounded_raw = reader.ReadInt32();
                    data.Part_Id_LR_HR3_Special_Phase_1_offset = reader.BaseStream.Position;
                    data.Part_Id_LR_HR3_Special_Phase_1_raw = reader.ReadInt32();
                    data.Part_Id_LR_HR3_Special_Phase_2_offset = reader.BaseStream.Position;
                    data.Part_Id_LR_HR3_Special_Phase_2_raw = reader.ReadInt32();
                    data.Part_Id_LR_HR3_Special_Phase_3_offset = reader.BaseStream.Position;
                    data.Part_Id_LR_HR3_Special_Phase_3_raw = reader.ReadInt32();
                    data.Part_Id_MR3_Normal_offset = reader.BaseStream.Position;
                    data.Part_Id_MR3_Normal_raw = reader.ReadInt32();
                    data.Part_Id_MR3_Wounded_offset = reader.BaseStream.Position;
                    data.Part_Id_MR3_Wounded_raw = reader.ReadInt32();
                    data.Part_Id_MR3_Special_Phase_1_offset = reader.BaseStream.Position;
                    data.Part_Id_MR3_Special_Phase_1_raw = reader.ReadInt32();
                    data.Part_Id_MR3_Special_Phase_2_offset = reader.BaseStream.Position;
                    data.Part_Id_MR3_Special_Phase_2_raw = reader.ReadInt32();
                    data.Part_Id_MR3_Special_Phase_3_offset = reader.BaseStream.Position;
                    data.Part_Id_MR3_Special_Phase_3_raw = reader.ReadInt32();
                    data.unk29_offset = reader.BaseStream.Position;
                    data.unk29_raw = reader.ReadUInt32();
                    data.unk30_offset = reader.BaseStream.Position;
                    data.unk30_raw = reader.ReadUInt32();
                    data.unk31_offset = reader.BaseStream.Position;
                    data.unk31_raw = reader.ReadUInt32();
                    data.unk32_offset = reader.BaseStream.Position;
                    data.unk32_raw = reader.ReadByte();
                    data.unk33_offset = reader.BaseStream.Position;
                    data.unk33_raw = reader.ReadByte();
                    return data;
                }

                public void WriteData(BinaryWriter writer, Flinches parent) {
                    writer.Write(Part_Id_LR_HR1_Normal_raw);
                    writer.Write(Part_Id_LR_HR1_Wounded_raw);
                    writer.Write(Part_Id_LR_HR1_Special_Phase_1_raw);
                    writer.Write(Part_Id_LR_HR1_Special_Phase_2_raw);
                    writer.Write(Part_Id_LR_HR1_Special_Phase_3_raw);
                    writer.Write(Part_Id_MR1_Normal_raw);
                    writer.Write(Part_Id_MR1_Wounded_raw);
                    writer.Write(Part_Id_MR1_Special_Phase_1_raw);
                    writer.Write(Part_Id_MR1_Special_Phase_2_raw);
                    writer.Write(Part_Id_MR1_Special_Phase_3_raw);
                    writer.Write(Part_Id_LR_HR2_Normal_raw);
                    writer.Write(Part_Id_LR_HR2_Wounded_raw);
                    writer.Write(Part_Id_LR_HR2_Special_Phase_1_raw);
                    writer.Write(Part_Id_LR_HR2_Special_Phase_2_raw);
                    writer.Write(Part_Id_LR_HR2_Special_Phase_3_raw);
                    writer.Write(Part_Id_MR2_Normal_raw);
                    writer.Write(Part_Id_MR2_Wounded_raw);
                    writer.Write(Part_Id_MR2_Special_Phase_1_raw);
                    writer.Write(Part_Id_MR2_Special_Phase_2_raw);
                    writer.Write(Part_Id_MR2_Special_Phase_3_raw);
                    writer.Write(Part_Id_LR_HR3_Normal_raw);
                    writer.Write(Part_Id_LR_HR3_Wounded_raw);
                    writer.Write(Part_Id_LR_HR3_Special_Phase_1_raw);
                    writer.Write(Part_Id_LR_HR3_Special_Phase_2_raw);
                    writer.Write(Part_Id_LR_HR3_Special_Phase_3_raw);
                    writer.Write(Part_Id_MR3_Normal_raw);
                    writer.Write(Part_Id_MR3_Wounded_raw);
                    writer.Write(Part_Id_MR3_Special_Phase_1_raw);
                    writer.Write(Part_Id_MR3_Special_Phase_2_raw);
                    writer.Write(Part_Id_MR3_Special_Phase_3_raw);
                    writer.Write(unk29_raw);
                    writer.Write(unk30_raw);
                    writer.Write(unk31_raw);
                    writer.Write(unk32_raw);
                    writer.Write(unk33_raw);
                }

                public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                    return new ObservableCollection<MultiStructItemCustomView> {
                        new MultiStructItemCustomView(this, "Part Id LR/HR1 Normal", "Part_Id_LR_HR1_Normal", "Part_Id_LR_HR1_Normal_offset"),
                        new MultiStructItemCustomView(this, "Part Id LR/HR1 Wounded", "Part_Id_LR_HR1_Wounded", "Part_Id_LR_HR1_Wounded_offset"),
                        new MultiStructItemCustomView(this, "Part Id LR/HR1 Special Phase 1", "Part_Id_LR_HR1_Special_Phase_1", "Part_Id_LR_HR1_Special_Phase_1_offset"),
                        new MultiStructItemCustomView(this, "Part Id LR/HR1 Special Phase 2", "Part_Id_LR_HR1_Special_Phase_2", "Part_Id_LR_HR1_Special_Phase_2_offset"),
                        new MultiStructItemCustomView(this, "Part Id LR/HR1 Special Phase 3", "Part_Id_LR_HR1_Special_Phase_3", "Part_Id_LR_HR1_Special_Phase_3_offset"),
                        new MultiStructItemCustomView(this, "Part Id MR1 Normal", "Part_Id_MR1_Normal", "Part_Id_MR1_Normal_offset"),
                        new MultiStructItemCustomView(this, "Part Id MR1 Wounded", "Part_Id_MR1_Wounded", "Part_Id_MR1_Wounded_offset"),
                        new MultiStructItemCustomView(this, "Part Id MR1 Special Phase 1", "Part_Id_MR1_Special_Phase_1", "Part_Id_MR1_Special_Phase_1_offset"),
                        new MultiStructItemCustomView(this, "Part Id MR1 Special Phase 2", "Part_Id_MR1_Special_Phase_2", "Part_Id_MR1_Special_Phase_2_offset"),
                        new MultiStructItemCustomView(this, "Part Id MR1 Special Phase 3", "Part_Id_MR1_Special_Phase_3", "Part_Id_MR1_Special_Phase_3_offset"),
                        new MultiStructItemCustomView(this, "Part Id LR/HR2 Normal", "Part_Id_LR_HR2_Normal", "Part_Id_LR_HR2_Normal_offset"),
                        new MultiStructItemCustomView(this, "Part Id LR/HR2 Wounded", "Part_Id_LR_HR2_Wounded", "Part_Id_LR_HR2_Wounded_offset"),
                        new MultiStructItemCustomView(this, "Part Id LR/HR2 Special Phase 1", "Part_Id_LR_HR2_Special_Phase_1", "Part_Id_LR_HR2_Special_Phase_1_offset"),
                        new MultiStructItemCustomView(this, "Part Id LR/HR2 Special Phase 2", "Part_Id_LR_HR2_Special_Phase_2", "Part_Id_LR_HR2_Special_Phase_2_offset"),
                        new MultiStructItemCustomView(this, "Part Id LR/HR2 Special Phase 3", "Part_Id_LR_HR2_Special_Phase_3", "Part_Id_LR_HR2_Special_Phase_3_offset"),
                        new MultiStructItemCustomView(this, "Part Id MR2 Normal", "Part_Id_MR2_Normal", "Part_Id_MR2_Normal_offset"),
                        new MultiStructItemCustomView(this, "Part Id MR2 Wounded", "Part_Id_MR2_Wounded", "Part_Id_MR2_Wounded_offset"),
                        new MultiStructItemCustomView(this, "Part Id MR2 Special Phase 1", "Part_Id_MR2_Special_Phase_1", "Part_Id_MR2_Special_Phase_1_offset"),
                        new MultiStructItemCustomView(this, "Part Id MR2 Special Phase 2", "Part_Id_MR2_Special_Phase_2", "Part_Id_MR2_Special_Phase_2_offset"),
                        new MultiStructItemCustomView(this, "Part Id MR2 Special Phase 3", "Part_Id_MR2_Special_Phase_3", "Part_Id_MR2_Special_Phase_3_offset"),
                        new MultiStructItemCustomView(this, "Part Id LR/HR3 Normal", "Part_Id_LR_HR3_Normal", "Part_Id_LR_HR3_Normal_offset"),
                        new MultiStructItemCustomView(this, "Part Id LR/HR3 Wounded", "Part_Id_LR_HR3_Wounded", "Part_Id_LR_HR3_Wounded_offset"),
                        new MultiStructItemCustomView(this, "Part Id LR/HR3 Special Phase 1", "Part_Id_LR_HR3_Special_Phase_1", "Part_Id_LR_HR3_Special_Phase_1_offset"),
                        new MultiStructItemCustomView(this, "Part Id LR/HR3 Special Phase 2", "Part_Id_LR_HR3_Special_Phase_2", "Part_Id_LR_HR3_Special_Phase_2_offset"),
                        new MultiStructItemCustomView(this, "Part Id LR/HR3 Special Phase 3", "Part_Id_LR_HR3_Special_Phase_3", "Part_Id_LR_HR3_Special_Phase_3_offset"),
                        new MultiStructItemCustomView(this, "Part Id MR3 Normal", "Part_Id_MR3_Normal", "Part_Id_MR3_Normal_offset"),
                        new MultiStructItemCustomView(this, "Part Id MR3 Wounded", "Part_Id_MR3_Wounded", "Part_Id_MR3_Wounded_offset"),
                        new MultiStructItemCustomView(this, "Part Id MR3 Special Phase 1", "Part_Id_MR3_Special_Phase_1", "Part_Id_MR3_Special_Phase_1_offset"),
                        new MultiStructItemCustomView(this, "Part Id MR3 Special Phase 2", "Part_Id_MR3_Special_Phase_2", "Part_Id_MR3_Special_Phase_2_offset"),
                        new MultiStructItemCustomView(this, "Part Id MR3 Special Phase 3", "Part_Id_MR3_Special_Phase_3", "Part_Id_MR3_Special_Phase_3_offset"),
                        new MultiStructItemCustomView(this, "unk29", "unk29", "unk29_offset"),
                        new MultiStructItemCustomView(this, "unk30", "unk30", "unk30_offset"),
                        new MultiStructItemCustomView(this, "unk31", "unk31", "unk31_offset"),
                        new MultiStructItemCustomView(this, "unk32", "unk32", "unk32_offset"),
                        new MultiStructItemCustomView(this, "unk33", "unk33", "unk33_offset"),
                    };
                }
            }

            public const string Parts3_displayName = "Parts3";
            public const int Parts3_sortIndex = 450;
            [SortOrder(Parts3_sortIndex)]
            [DisplayName(Parts3_displayName)]
            protected virtual ObservableCollection<Parts3> Parts3_raw { get; set; }

            public const int lastSortIndex = 500;

            public IEnumerable<F> GetAllEnumerableChildrenOfType<F>() {
                if (typeof(Parts1).Is(typeof(F)) || typeof(Parts1).IsGeneric(typeof(F))) {
                    foreach (var item in Parts1_raw.Cast<F>()) {
                        yield return item;
                    }
                }
                if (typeof(Parts2).Is(typeof(F)) || typeof(Parts2).IsGeneric(typeof(F))) {
                    foreach (var item in Parts2_raw.Cast<F>()) {
                        yield return item;
                    }
                }
                if (typeof(Parts3).Is(typeof(F)) || typeof(Parts3).IsGeneric(typeof(F))) {
                    foreach (var item in Parts3_raw.Cast<F>()) {
                        yield return item;
                    }
                }
            }

            public static ObservableMhwStructCollection<Flinches> LoadData(BinaryReader reader, ObservableMhwStructCollection<Monster_Parts> lastStruct) {
                var list = new ObservableMhwStructCollection<Flinches>();
                var countTarget = (Monster_Parts) lastStruct.Last();
                var count = (ulong) countTarget.Flinches_Count;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Flinches LoadData(BinaryReader reader, ulong i) {
                var data = new Flinches();
                data.Index = i;
                data.Flinch_Value_raw = reader.ReadUInt32();
                data.Special_Part_1_raw = reader.ReadInt32();
                data.Special_Part_2_raw = reader.ReadInt32();
                data.Special_Part_3_raw = reader.ReadInt32();
                data.Kinsect_Color_raw = reader.ReadUInt32();
                data.Parts_Type_raw = reader.ReadUInt32();
                if (data.Parts_Type_raw == 1) data.Parts1_raw = Parts1.LoadData(reader, data);
                else data.Parts1_raw = new ObservableCollection<Parts1>();
                if (data.Parts_Type_raw == 2) data.Parts2_raw = Parts2.LoadData(reader, data);
                else data.Parts2_raw = new ObservableCollection<Parts2>();
                if (data.Parts_Type_raw == 3) data.Parts3_raw = Parts3.LoadData(reader, data);
                else data.Parts3_raw = new ObservableCollection<Parts3>();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Flinch_Value_raw);
                writer.Write(Special_Part_1_raw);
                writer.Write(Special_Part_2_raw);
                writer.Write(Special_Part_3_raw);
                writer.Write(Kinsect_Color_raw);
                writer.Write(Parts_Type_raw);
                if (Parts_Type_raw == 1) foreach (var obj in Parts1_raw) {
                    obj.WriteData(writer, this);
                }
                if (Parts_Type_raw == 2) foreach (var obj in Parts2_raw) {
                    obj.WriteData(writer, this);
                }
                if (Parts_Type_raw == 3) foreach (var obj in Parts3_raw) {
                    obj.WriteData(writer, this);
                }
            }
        }

        public partial class Hitzone_Header : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Hitzone Header";
            public const bool IsHidden = true;

            protected uint Hitzone_Count_raw;
            public const string Hitzone_Count_displayName = "Hitzone Count";
            public const int Hitzone_Count_sortIndex = 50;
            [SortOrder(Hitzone_Count_sortIndex)]
            [DisplayName(Hitzone_Count_displayName)]
            [IsReadOnly]
            public virtual uint Hitzone_Count {
                get => Hitzone_Count_raw;
                set {
                    if (Hitzone_Count_raw == value) return;
                    Hitzone_Count_raw = value;
                    ChangedItems.Add(nameof(Hitzone_Count));
                    OnPropertyChanged(nameof(Hitzone_Count));
                }
            }

            public const int lastSortIndex = 100;

            public static ObservableMhwStructCollection<Hitzone_Header> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Hitzone_Header>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Hitzone_Header LoadData(BinaryReader reader, ulong i) {
                var data = new Hitzone_Header();
                data.Index = i;
                data.Hitzone_Count_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Hitzone_Count_raw);
            }
        }

        public partial class Hitzones : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 0;
            public const string GridName = "Hitzones";

            protected float Timer_raw;
            public const string Timer_displayName = "Timer";
            public const int Timer_sortIndex = 50;
            [SortOrder(Timer_sortIndex)]
            [DisplayName(Timer_displayName)]
            public virtual float Timer {
                get => Timer_raw;
                set {
                    if (Timer_raw == value) return;
                    Timer_raw = value;
                    ChangedItems.Add(nameof(Timer));
                    OnPropertyChanged(nameof(Timer));
                }
            }

            protected uint Sever_raw;
            public const string Sever_displayName = "Sever";
            public const int Sever_sortIndex = 100;
            [SortOrder(Sever_sortIndex)]
            [DisplayName(Sever_displayName)]
            public virtual uint Sever {
                get => Sever_raw;
                set {
                    if (Sever_raw == value) return;
                    Sever_raw = value;
                    ChangedItems.Add(nameof(Sever));
                    OnPropertyChanged(nameof(Sever));
                }
            }

            protected uint Impact_raw;
            public const string Impact_displayName = "Impact";
            public const int Impact_sortIndex = 150;
            [SortOrder(Impact_sortIndex)]
            [DisplayName(Impact_displayName)]
            public virtual uint Impact {
                get => Impact_raw;
                set {
                    if (Impact_raw == value) return;
                    Impact_raw = value;
                    ChangedItems.Add(nameof(Impact));
                    OnPropertyChanged(nameof(Impact));
                }
            }

            protected uint Shot_raw;
            public const string Shot_displayName = "Shot";
            public const int Shot_sortIndex = 200;
            [SortOrder(Shot_sortIndex)]
            [DisplayName(Shot_displayName)]
            public virtual uint Shot {
                get => Shot_raw;
                set {
                    if (Shot_raw == value) return;
                    Shot_raw = value;
                    ChangedItems.Add(nameof(Shot));
                    OnPropertyChanged(nameof(Shot));
                }
            }

            protected uint Fire_raw;
            public const string Fire_displayName = "Fire";
            public const int Fire_sortIndex = 250;
            [SortOrder(Fire_sortIndex)]
            [DisplayName(Fire_displayName)]
            public virtual uint Fire {
                get => Fire_raw;
                set {
                    if (Fire_raw == value) return;
                    Fire_raw = value;
                    ChangedItems.Add(nameof(Fire));
                    OnPropertyChanged(nameof(Fire));
                }
            }

            protected uint Water_raw;
            public const string Water_displayName = "Water";
            public const int Water_sortIndex = 300;
            [SortOrder(Water_sortIndex)]
            [DisplayName(Water_displayName)]
            public virtual uint Water {
                get => Water_raw;
                set {
                    if (Water_raw == value) return;
                    Water_raw = value;
                    ChangedItems.Add(nameof(Water));
                    OnPropertyChanged(nameof(Water));
                }
            }

            protected uint Ice_raw;
            public const string Ice_displayName = "Ice";
            public const int Ice_sortIndex = 350;
            [SortOrder(Ice_sortIndex)]
            [DisplayName(Ice_displayName)]
            public virtual uint Ice {
                get => Ice_raw;
                set {
                    if (Ice_raw == value) return;
                    Ice_raw = value;
                    ChangedItems.Add(nameof(Ice));
                    OnPropertyChanged(nameof(Ice));
                }
            }

            protected uint Thunder_raw;
            public const string Thunder_displayName = "Thunder";
            public const int Thunder_sortIndex = 400;
            [SortOrder(Thunder_sortIndex)]
            [DisplayName(Thunder_displayName)]
            public virtual uint Thunder {
                get => Thunder_raw;
                set {
                    if (Thunder_raw == value) return;
                    Thunder_raw = value;
                    ChangedItems.Add(nameof(Thunder));
                    OnPropertyChanged(nameof(Thunder));
                }
            }

            protected uint Dragon_raw;
            public const string Dragon_displayName = "Dragon";
            public const int Dragon_sortIndex = 450;
            [SortOrder(Dragon_sortIndex)]
            [DisplayName(Dragon_displayName)]
            public virtual uint Dragon {
                get => Dragon_raw;
                set {
                    if (Dragon_raw == value) return;
                    Dragon_raw = value;
                    ChangedItems.Add(nameof(Dragon));
                    OnPropertyChanged(nameof(Dragon));
                }
            }

            protected uint Stun_raw;
            public const string Stun_displayName = "Stun";
            public const int Stun_sortIndex = 500;
            [SortOrder(Stun_sortIndex)]
            [DisplayName(Stun_displayName)]
            public virtual uint Stun {
                get => Stun_raw;
                set {
                    if (Stun_raw == value) return;
                    Stun_raw = value;
                    ChangedItems.Add(nameof(Stun));
                    OnPropertyChanged(nameof(Stun));
                }
            }

            protected uint Stamina_raw;
            public const string Stamina_displayName = "Stamina";
            public const int Stamina_sortIndex = 550;
            [SortOrder(Stamina_sortIndex)]
            [DisplayName(Stamina_displayName)]
            public virtual uint Stamina {
                get => Stamina_raw;
                set {
                    if (Stamina_raw == value) return;
                    Stamina_raw = value;
                    ChangedItems.Add(nameof(Stamina));
                    OnPropertyChanged(nameof(Stamina));
                }
            }

            public const int lastSortIndex = 600;

            public static ObservableMhwStructCollection<Hitzones> LoadData(BinaryReader reader, ObservableMhwStructCollection<Hitzone_Header> lastStruct) {
                var list = new ObservableMhwStructCollection<Hitzones>();
                var countTarget = (Hitzone_Header) lastStruct.Last();
                var count = (ulong) countTarget.Hitzone_Count;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Hitzones LoadData(BinaryReader reader, ulong i) {
                var data = new Hitzones();
                data.Index = i;
                data.Timer_raw = reader.ReadSingle();
                data.Sever_raw = reader.ReadUInt32();
                data.Impact_raw = reader.ReadUInt32();
                data.Shot_raw = reader.ReadUInt32();
                data.Fire_raw = reader.ReadUInt32();
                data.Water_raw = reader.ReadUInt32();
                data.Ice_raw = reader.ReadUInt32();
                data.Thunder_raw = reader.ReadUInt32();
                data.Dragon_raw = reader.ReadUInt32();
                data.Stun_raw = reader.ReadUInt32();
                data.Stamina_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Timer_raw);
                writer.Write(Sever_raw);
                writer.Write(Impact_raw);
                writer.Write(Shot_raw);
                writer.Write(Fire_raw);
                writer.Write(Water_raw);
                writer.Write(Ice_raw);
                writer.Write(Thunder_raw);
                writer.Write(Dragon_raw);
                writer.Write(Stun_raw);
                writer.Write(Stamina_raw);
            }
        }

        public partial class Sever_Header : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Sever Header";
            public const bool IsHidden = true;

            protected uint Sever_Count_raw;
            public const string Sever_Count_displayName = "Sever Count";
            public const int Sever_Count_sortIndex = 50;
            [SortOrder(Sever_Count_sortIndex)]
            [DisplayName(Sever_Count_displayName)]
            [IsReadOnly]
            public virtual uint Sever_Count {
                get => Sever_Count_raw;
                set {
                    if (Sever_Count_raw == value) return;
                    Sever_Count_raw = value;
                    ChangedItems.Add(nameof(Sever_Count));
                    OnPropertyChanged(nameof(Sever_Count));
                }
            }

            public const int lastSortIndex = 100;

            public static ObservableMhwStructCollection<Sever_Header> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Sever_Header>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Sever_Header LoadData(BinaryReader reader, ulong i) {
                var data = new Sever_Header();
                data.Index = i;
                data.Sever_Count_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Sever_Count_raw);
            }
        }

        public partial class Severs : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 0;
            public const string GridName = "Severs";

            protected uint Damage_raw;
            public const string Damage_displayName = "Damage";
            public const int Damage_sortIndex = 50;
            [SortOrder(Damage_sortIndex)]
            [DisplayName(Damage_displayName)]
            public virtual MHW_Template.Weapons.DamageType Damage {
                get => (MHW_Template.Weapons.DamageType) Damage_raw;
                set {
                    if ((MHW_Template.Weapons.DamageType) Damage_raw == value) return;
                    Damage_raw = (uint) value;
                    ChangedItems.Add(nameof(Damage));
                    OnPropertyChanged(nameof(Damage));
                }
            }

            protected uint unk1_raw;
            public const string unk1_displayName = "unk1";
            public const int unk1_sortIndex = 100;
            [SortOrder(unk1_sortIndex)]
            [DisplayName(unk1_displayName)]
            public virtual uint unk1 {
                get => unk1_raw;
                set {
                    if (unk1_raw == value) return;
                    unk1_raw = value;
                    ChangedItems.Add(nameof(unk1));
                    OnPropertyChanged(nameof(unk1));
                }
            }

            protected uint unk2_raw;
            public const string unk2_displayName = "unk2";
            public const int unk2_sortIndex = 150;
            [SortOrder(unk2_sortIndex)]
            [DisplayName(unk2_displayName)]
            public virtual uint unk2 {
                get => unk2_raw;
                set {
                    if (unk2_raw == value) return;
                    unk2_raw = value;
                    ChangedItems.Add(nameof(unk2));
                    OnPropertyChanged(nameof(unk2));
                }
            }

            protected uint Sever_raw;
            public const string Sever_displayName = "Sever";
            public const int Sever_sortIndex = 200;
            [SortOrder(Sever_sortIndex)]
            [DisplayName(Sever_displayName)]
            public virtual uint Sever {
                get => Sever_raw;
                set {
                    if (Sever_raw == value) return;
                    Sever_raw = value;
                    ChangedItems.Add(nameof(Sever));
                    OnPropertyChanged(nameof(Sever));
                }
            }

            protected int unk5_raw;
            public const string unk5_displayName = "unk5";
            public const int unk5_sortIndex = 250;
            [SortOrder(unk5_sortIndex)]
            [DisplayName(unk5_displayName)]
            public virtual int unk5 {
                get => unk5_raw;
                set {
                    if (unk5_raw == value) return;
                    unk5_raw = value;
                    ChangedItems.Add(nameof(unk5));
                    OnPropertyChanged(nameof(unk5));
                }
            }

            protected byte Special_raw;
            public const string Special_displayName = "Special";
            public const int Special_sortIndex = 300;
            [SortOrder(Special_sortIndex)]
            [DisplayName(Special_displayName)]
            public virtual bool Special {
                get => (bool) Convert.ToBoolean(Special_raw);
                set {
                    if (Convert.ToBoolean(Special_raw) == value) return;
                    Special_raw = Convert.ToByte(value);
                    ChangedItems.Add(nameof(Special));
                    OnPropertyChanged(nameof(Special));
                }
            }

            protected byte Blunt_raw;
            public const string Blunt_displayName = "Blunt";
            public const int Blunt_sortIndex = 350;
            [SortOrder(Blunt_sortIndex)]
            [DisplayName(Blunt_displayName)]
            public virtual bool Blunt {
                get => (bool) Convert.ToBoolean(Blunt_raw);
                set {
                    if (Convert.ToBoolean(Blunt_raw) == value) return;
                    Blunt_raw = Convert.ToByte(value);
                    ChangedItems.Add(nameof(Blunt));
                    OnPropertyChanged(nameof(Blunt));
                }
            }

            protected byte Shot_raw;
            public const string Shot_displayName = "Shot";
            public const int Shot_sortIndex = 400;
            [SortOrder(Shot_sortIndex)]
            [DisplayName(Shot_displayName)]
            public virtual bool Shot {
                get => (bool) Convert.ToBoolean(Shot_raw);
                set {
                    if (Convert.ToBoolean(Shot_raw) == value) return;
                    Shot_raw = Convert.ToByte(value);
                    ChangedItems.Add(nameof(Shot));
                    OnPropertyChanged(nameof(Shot));
                }
            }

            public const int lastSortIndex = 450;

            public static ObservableMhwStructCollection<Severs> LoadData(BinaryReader reader, ObservableMhwStructCollection<Sever_Header> lastStruct) {
                var list = new ObservableMhwStructCollection<Severs>();
                var countTarget = (Sever_Header) lastStruct.Last();
                var count = (ulong) countTarget.Sever_Count;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Severs LoadData(BinaryReader reader, ulong i) {
                var data = new Severs();
                data.Index = i;
                data.Damage_raw = reader.ReadUInt32();
                data.unk1_raw = reader.ReadUInt32();
                data.unk2_raw = reader.ReadUInt32();
                data.Sever_raw = reader.ReadUInt32();
                data.unk5_raw = reader.ReadInt32();
                data.Special_raw = reader.ReadByte();
                data.Blunt_raw = reader.ReadByte();
                data.Shot_raw = reader.ReadByte();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Damage_raw);
                writer.Write(unk1_raw);
                writer.Write(unk2_raw);
                writer.Write(Sever_raw);
                writer.Write(unk5_raw);
                writer.Write(Special_raw);
                writer.Write(Blunt_raw);
                writer.Write(Shot_raw);
            }
        }

        public partial class Unk_Header : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Unk Header";
            public const bool IsHidden = true;

            protected uint Unk_Count_raw;
            public const string Unk_Count_displayName = "Unk Count";
            public const int Unk_Count_sortIndex = 50;
            [SortOrder(Unk_Count_sortIndex)]
            [DisplayName(Unk_Count_displayName)]
            [IsReadOnly]
            public virtual uint Unk_Count {
                get => Unk_Count_raw;
                set {
                    if (Unk_Count_raw == value) return;
                    Unk_Count_raw = value;
                    ChangedItems.Add(nameof(Unk_Count));
                    OnPropertyChanged(nameof(Unk_Count));
                }
            }

            public const int lastSortIndex = 100;

            public static ObservableMhwStructCollection<Unk_Header> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Unk_Header>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Unk_Header LoadData(BinaryReader reader, ulong i) {
                var data = new Unk_Header();
                data.Index = i;
                data.Unk_Count_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_Count_raw);
            }
        }

        public partial class Unknowns : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 0;
            public const string GridName = "Unknowns";

            protected uint unk1_raw;
            public const string unk1_displayName = "unk1";
            public const int unk1_sortIndex = 50;
            [SortOrder(unk1_sortIndex)]
            [DisplayName(unk1_displayName)]
            public virtual uint unk1 {
                get => unk1_raw;
                set {
                    if (unk1_raw == value) return;
                    unk1_raw = value;
                    ChangedItems.Add(nameof(unk1));
                    OnPropertyChanged(nameof(unk1));
                }
            }

            protected uint unk2_raw;
            public const string unk2_displayName = "unk2";
            public const int unk2_sortIndex = 100;
            [SortOrder(unk2_sortIndex)]
            [DisplayName(unk2_displayName)]
            public virtual uint unk2 {
                get => unk2_raw;
                set {
                    if (unk2_raw == value) return;
                    unk2_raw = value;
                    ChangedItems.Add(nameof(unk2));
                    OnPropertyChanged(nameof(unk2));
                }
            }

            protected uint unk3_raw;
            public const string unk3_displayName = "unk3";
            public const int unk3_sortIndex = 150;
            [SortOrder(unk3_sortIndex)]
            [DisplayName(unk3_displayName)]
            public virtual uint unk3 {
                get => unk3_raw;
                set {
                    if (unk3_raw == value) return;
                    unk3_raw = value;
                    ChangedItems.Add(nameof(unk3));
                    OnPropertyChanged(nameof(unk3));
                }
            }

            protected byte unk4_raw;
            public const string unk4_displayName = "unk4";
            public const int unk4_sortIndex = 200;
            [SortOrder(unk4_sortIndex)]
            [DisplayName(unk4_displayName)]
            public virtual byte unk4 {
                get => unk4_raw;
                set {
                    if (unk4_raw == value) return;
                    unk4_raw = value;
                    ChangedItems.Add(nameof(unk4));
                    OnPropertyChanged(nameof(unk4));
                }
            }

            protected uint unk5_raw;
            public const string unk5_displayName = "unk5";
            public const int unk5_sortIndex = 250;
            [SortOrder(unk5_sortIndex)]
            [DisplayName(unk5_displayName)]
            public virtual uint unk5 {
                get => unk5_raw;
                set {
                    if (unk5_raw == value) return;
                    unk5_raw = value;
                    ChangedItems.Add(nameof(unk5));
                    OnPropertyChanged(nameof(unk5));
                }
            }

            protected byte unk6_raw;
            public const string unk6_displayName = "unk6";
            public const int unk6_sortIndex = 300;
            [SortOrder(unk6_sortIndex)]
            [DisplayName(unk6_displayName)]
            public virtual byte unk6 {
                get => unk6_raw;
                set {
                    if (unk6_raw == value) return;
                    unk6_raw = value;
                    ChangedItems.Add(nameof(unk6));
                    OnPropertyChanged(nameof(unk6));
                }
            }

            protected byte unk7_raw;
            public const string unk7_displayName = "unk7";
            public const int unk7_sortIndex = 350;
            [SortOrder(unk7_sortIndex)]
            [DisplayName(unk7_displayName)]
            public virtual byte unk7 {
                get => unk7_raw;
                set {
                    if (unk7_raw == value) return;
                    unk7_raw = value;
                    ChangedItems.Add(nameof(unk7));
                    OnPropertyChanged(nameof(unk7));
                }
            }

            protected int unk8_raw;
            public const string unk8_displayName = "unk8";
            public const int unk8_sortIndex = 400;
            [SortOrder(unk8_sortIndex)]
            [DisplayName(unk8_displayName)]
            public virtual int unk8 {
                get => unk8_raw;
                set {
                    if (unk8_raw == value) return;
                    unk8_raw = value;
                    ChangedItems.Add(nameof(unk8));
                    OnPropertyChanged(nameof(unk8));
                }
            }

            protected byte unk9_raw;
            public const string unk9_displayName = "unk9";
            public const int unk9_sortIndex = 450;
            [SortOrder(unk9_sortIndex)]
            [DisplayName(unk9_displayName)]
            public virtual byte unk9 {
                get => unk9_raw;
                set {
                    if (unk9_raw == value) return;
                    unk9_raw = value;
                    ChangedItems.Add(nameof(unk9));
                    OnPropertyChanged(nameof(unk9));
                }
            }

            protected byte unk10_raw;
            public const string unk10_displayName = "unk10";
            public const int unk10_sortIndex = 500;
            [SortOrder(unk10_sortIndex)]
            [DisplayName(unk10_displayName)]
            public virtual byte unk10 {
                get => unk10_raw;
                set {
                    if (unk10_raw == value) return;
                    unk10_raw = value;
                    ChangedItems.Add(nameof(unk10));
                    OnPropertyChanged(nameof(unk10));
                }
            }

            protected byte unk11_raw;
            public const string unk11_displayName = "unk11";
            public const int unk11_sortIndex = 550;
            [SortOrder(unk11_sortIndex)]
            [DisplayName(unk11_displayName)]
            public virtual byte unk11 {
                get => unk11_raw;
                set {
                    if (unk11_raw == value) return;
                    unk11_raw = value;
                    ChangedItems.Add(nameof(unk11));
                    OnPropertyChanged(nameof(unk11));
                }
            }

            public const int lastSortIndex = 600;

            public static ObservableMhwStructCollection<Unknowns> LoadData(BinaryReader reader, ObservableMhwStructCollection<Unk_Header> lastStruct) {
                var list = new ObservableMhwStructCollection<Unknowns>();
                var countTarget = (Unk_Header) lastStruct.Last();
                var count = (ulong) countTarget.Unk_Count;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Unknowns LoadData(BinaryReader reader, ulong i) {
                var data = new Unknowns();
                data.Index = i;
                data.unk1_raw = reader.ReadUInt32();
                data.unk2_raw = reader.ReadUInt32();
                data.unk3_raw = reader.ReadUInt32();
                data.unk4_raw = reader.ReadByte();
                data.unk5_raw = reader.ReadUInt32();
                data.unk6_raw = reader.ReadByte();
                data.unk7_raw = reader.ReadByte();
                data.unk8_raw = reader.ReadInt32();
                data.unk9_raw = reader.ReadByte();
                data.unk10_raw = reader.ReadByte();
                data.unk11_raw = reader.ReadByte();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(unk1_raw);
                writer.Write(unk2_raw);
                writer.Write(unk3_raw);
                writer.Write(unk4_raw);
                writer.Write(unk5_raw);
                writer.Write(unk6_raw);
                writer.Write(unk7_raw);
                writer.Write(unk8_raw);
                writer.Write(unk9_raw);
                writer.Write(unk10_raw);
                writer.Write(unk11_raw);
            }
        }

        public partial class Unknown : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Unknown";

            protected uint unk1_raw;
            public const string unk1_displayName = "unk1";
            public const int unk1_sortIndex = 50;
            [SortOrder(unk1_sortIndex)]
            [DisplayName(unk1_displayName)]
            public virtual uint unk1 {
                get => unk1_raw;
                set {
                    if (unk1_raw == value) return;
                    unk1_raw = value;
                    ChangedItems.Add(nameof(unk1));
                    OnPropertyChanged(nameof(unk1));
                }
            }

            [DisplayName("Offset")]
            public long unk1_offset { get; private set; }

            protected uint unk2_raw;
            public const string unk2_displayName = "unk2";
            public const int unk2_sortIndex = 100;
            [SortOrder(unk2_sortIndex)]
            [DisplayName(unk2_displayName)]
            public virtual uint unk2 {
                get => unk2_raw;
                set {
                    if (unk2_raw == value) return;
                    unk2_raw = value;
                    ChangedItems.Add(nameof(unk2));
                    OnPropertyChanged(nameof(unk2));
                }
            }

            [DisplayName("Offset")]
            public long unk2_offset { get; private set; }

            public const int lastSortIndex = 150;

            public static ObservableMhwStructCollection<Unknown> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Unknown>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Unknown LoadData(BinaryReader reader, ulong i) {
                var data = new Unknown();
                data.Index = i;
                data.unk1_offset = reader.BaseStream.Position;
                data.unk1_raw = reader.ReadUInt32();
                data.unk2_offset = reader.BaseStream.Position;
                data.unk2_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(unk1_raw);
                writer.Write(unk2_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "unk1", "unk1", "unk1_offset"),
                    new MultiStructItemCustomView(this, "unk2", "unk2", "unk2_offset"),
                };
            }
        }

        public override void LoadFile(string targetFile) {
            using var reader = new BinaryReader(OpenFile(targetFile, EncryptionKey), Encoding.UTF8);
            data = new LinkedList<MhwStructDataContainer>();
            var Monster_Parts_ = new MhwStructDataContainer<Monster_Parts>(Monster_Parts.LoadData(reader), typeof(Monster_Parts));
            data.AddLast(Monster_Parts_);
            var Flinches_ = new MhwStructDataContainer<Flinches, Monster_Parts>(Flinches.LoadData(reader, Monster_Parts_.list), typeof(Flinches));
            Flinches_.SetCountTargetToUpdate(Monster_Parts_, -1, "Flinches_Count");
            data.AddLast(Flinches_);
            var Hitzone_Header_ = new MhwStructDataContainer<Hitzone_Header>(Hitzone_Header.LoadData(reader), typeof(Hitzone_Header));
            data.AddLast(Hitzone_Header_);
            var Hitzones_ = new MhwStructDataContainer<Hitzones, Hitzone_Header>(Hitzones.LoadData(reader, Hitzone_Header_.list), typeof(Hitzones));
            Hitzones_.SetCountTargetToUpdate(Hitzone_Header_, -1, "Hitzone_Count");
            data.AddLast(Hitzones_);
            var Sever_Header_ = new MhwStructDataContainer<Sever_Header>(Sever_Header.LoadData(reader), typeof(Sever_Header));
            data.AddLast(Sever_Header_);
            var Severs_ = new MhwStructDataContainer<Severs, Sever_Header>(Severs.LoadData(reader, Sever_Header_.list), typeof(Severs));
            Severs_.SetCountTargetToUpdate(Sever_Header_, -1, "Sever_Count");
            data.AddLast(Severs_);
            var Unk_Header_ = new MhwStructDataContainer<Unk_Header>(Unk_Header.LoadData(reader), typeof(Unk_Header));
            data.AddLast(Unk_Header_);
            var Unknowns_ = new MhwStructDataContainer<Unknowns, Unk_Header>(Unknowns.LoadData(reader, Unk_Header_.list), typeof(Unknowns));
            Unknowns_.SetCountTargetToUpdate(Unk_Header_, -1, "Unk_Count");
            data.AddLast(Unknowns_);
            var Unknown_ = new MhwStructDataContainer<Unknown>(Unknown.LoadData(reader), typeof(Unknown));
            data.AddLast(Unknown_);
        }
    }
}
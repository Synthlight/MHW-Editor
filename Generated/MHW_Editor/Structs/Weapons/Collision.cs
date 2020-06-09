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

namespace MHW_Editor.Structs.Weapons {
    public partial class Collision {
        public override string EncryptionKey => null;

        public partial class Collisions : MhwStructItem {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Collisions";

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

            protected char[] Name_raw;
            public const string Name_displayName = "Name";
            public const int Name_sortIndex = 100;
            [SortOrder(Name_sortIndex)]
            [DisplayName(Name_displayName)]
            [IsReadOnly]
            public virtual string Name {
                get => (string) new string(Name_raw);
                set {
                    if ((string) new string(Name_raw) == value) return;
                    Name_raw = (char[]) value.ToCharArray(0, 3);
                    OnPropertyChanged(nameof(Name));
                }
            }

            protected uint Magic_2_raw;
            public const string Magic_2_displayName = "Magic 2";
            public const int Magic_2_sortIndex = 150;
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

            protected uint Unk_1_raw;
            public const string Unk_1_displayName = "Unk 1";
            public const int Unk_1_sortIndex = 200;
            [SortOrder(Unk_1_sortIndex)]
            [DisplayName(Unk_1_displayName)]
            [IsReadOnly]
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
            public const int Unk_2_sortIndex = 250;
            [SortOrder(Unk_2_sortIndex)]
            [DisplayName(Unk_2_displayName)]
            [IsReadOnly]
            public virtual uint Unk_2 {
                get => Unk_2_raw;
                set {
                    if (Unk_2_raw == value) return;
                    Unk_2_raw = value;
                    OnPropertyChanged(nameof(Unk_2));
                }
            }

            protected uint Name_Count_raw;
            public const string Name_Count_displayName = "Name Count";
            public const int Name_Count_sortIndex = 300;
            [SortOrder(Name_Count_sortIndex)]
            [DisplayName(Name_Count_displayName)]
            [IsReadOnly]
            public virtual uint Name_Count {
                get => Name_Count_raw;
                set {
                    if (Name_Count_raw == value) return;
                    Name_Count_raw = value;
                    OnPropertyChanged(nameof(Name_Count));
                }
            }

            public const int lastSortIndex = 350;

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Collisions LoadData(BinaryReader reader, ulong i) {
                var data = new Collisions();
                data.Index = i;
                data.Magic_1_raw = reader.ReadUInt32();
                data.Name_raw = reader.ReadChars(4);
                data.Magic_2_raw = reader.ReadUInt32();
                data.Unk_1_raw = reader.ReadUInt32();
                data.Unk_2_raw = reader.ReadUInt32();
                data.Name_Count_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Magic_1_raw);
                writer.Write(Name_raw);
                writer.Write(Magic_2_raw);
                writer.Write(Unk_1_raw);
                writer.Write(Unk_2_raw);
                writer.Write(Name_Count_raw);
            }
        }

        public partial class Names : MhwStructItem {
            public const ulong FixedSizeCount = 0;
            public const string GridName = "Names";

            protected string Name_raw;
            public const string Name_displayName = "Name";
            public const int Name_sortIndex = 50;
            [SortOrder(Name_sortIndex)]
            [DisplayName(Name_displayName)]
            protected virtual string Name {
                get => Name_raw;
                set {
                    if (Name_raw == value) return;
                    Name_raw = value;
                    OnPropertyChanged(nameof(Name));
                }
            }

            protected int CLGM_Id_raw;
            public const string CLGM_Id_displayName = "CLGM Id";
            public const int CLGM_Id_sortIndex = 100;
            [SortOrder(CLGM_Id_sortIndex)]
            [DisplayName(CLGM_Id_displayName)]
            [IsReadOnly]
            public virtual int CLGM_Id {
                get => CLGM_Id_raw;
                set {
                    if (CLGM_Id_raw == value) return;
                    CLGM_Id_raw = value;
                    OnPropertyChanged(nameof(CLGM_Id));
                }
            }

            protected int Move_Id_raw;
            public const string Move_Id_displayName = "Move Id";
            public const int Move_Id_sortIndex = 150;
            [SortOrder(Move_Id_sortIndex)]
            [DisplayName(Move_Id_displayName)]
            [IsReadOnly]
            public virtual int Move_Id {
                get => Move_Id_raw;
                set {
                    if (Move_Id_raw == value) return;
                    Move_Id_raw = value;
                    OnPropertyChanged(nameof(Move_Id));
                }
            }

            protected int Unk_1_raw;
            public const string Unk_1_displayName = "Unk 1";
            public const int Unk_1_sortIndex = 200;
            [SortOrder(Unk_1_sortIndex)]
            [DisplayName(Unk_1_displayName)]
            public virtual int Unk_1 {
                get => Unk_1_raw;
                set {
                    if (Unk_1_raw == value) return;
                    Unk_1_raw = value;
                    OnPropertyChanged(nameof(Unk_1));
                }
            }

            protected ushort Unk_2_raw;
            public const string Unk_2_displayName = "Unk 2";
            public const int Unk_2_sortIndex = 250;
            [SortOrder(Unk_2_sortIndex)]
            [DisplayName(Unk_2_displayName)]
            public virtual ushort Unk_2 {
                get => Unk_2_raw;
                set {
                    if (Unk_2_raw == value) return;
                    Unk_2_raw = value;
                    OnPropertyChanged(nameof(Unk_2));
                }
            }

            protected byte Unk_3_raw;
            public const string Unk_3_displayName = "Unk 3";
            public const int Unk_3_sortIndex = 300;
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

            protected uint Unk_4_raw;
            public const string Unk_4_displayName = "Unk 4";
            public const int Unk_4_sortIndex = 350;
            [SortOrder(Unk_4_sortIndex)]
            [DisplayName(Unk_4_displayName)]
            public virtual uint Unk_4 {
                get => Unk_4_raw;
                set {
                    if (Unk_4_raw == value) return;
                    Unk_4_raw = value;
                    OnPropertyChanged(nameof(Unk_4));
                }
            }

            public const int lastSortIndex = 400;

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
                var countTarget = (Collisions) lastStruct.Last();
                var count = (ulong) countTarget.Name_Count;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Names LoadData(BinaryReader reader, ulong i) {
                var data = new Names();
                data.Index = i;
                data.Name_raw = reader.ReadNullTermString();
                data.CLGM_Id_raw = reader.ReadInt32();
                data.Move_Id_raw = reader.ReadInt32();
                data.Unk_1_raw = reader.ReadInt32();
                data.Unk_2_raw = reader.ReadUInt16();
                data.Unk_3_raw = reader.ReadByte();
                data.Unk_4_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Name_raw.ToNullTermCharArray());
                writer.Write(CLGM_Id_raw);
                writer.Write(Move_Id_raw);
                writer.Write(Unk_1_raw);
                writer.Write(Unk_2_raw);
                writer.Write(Unk_3_raw);
                writer.Write(Unk_4_raw);
            }
        }

        public partial class CLND : MhwStructItem {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "CLND";

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

            protected char[] Name_raw;
            public const string Name_displayName = "Name";
            public const int Name_sortIndex = 100;
            [SortOrder(Name_sortIndex)]
            [DisplayName(Name_displayName)]
            [IsReadOnly]
            public virtual string Name {
                get => (string) new string(Name_raw);
                set {
                    if ((string) new string(Name_raw) == value) return;
                    Name_raw = (char[]) value.ToCharArray(0, 3);
                    OnPropertyChanged(nameof(Name));
                }
            }

            protected uint Magic_2_raw;
            public const string Magic_2_displayName = "Magic 2";
            public const int Magic_2_sortIndex = 150;
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

            protected uint Clgm_Count_raw;
            public const string Clgm_Count_displayName = "Clgm Count";
            public const int Clgm_Count_sortIndex = 200;
            [SortOrder(Clgm_Count_sortIndex)]
            [DisplayName(Clgm_Count_displayName)]
            [IsReadOnly]
            public virtual uint Clgm_Count {
                get => Clgm_Count_raw;
                set {
                    if (Clgm_Count_raw == value) return;
                    Clgm_Count_raw = value;
                    OnPropertyChanged(nameof(Clgm_Count));
                }
            }

            protected uint Clgm_Type_raw;
            public const string Clgm_Type_displayName = "Clgm Type";
            public const int Clgm_Type_sortIndex = 250;
            [SortOrder(Clgm_Type_sortIndex)]
            [DisplayName(Clgm_Type_displayName)]
            [IsReadOnly]
            public virtual uint Clgm_Type {
                get => Clgm_Type_raw;
                set {
                    if (Clgm_Type_raw == value) return;
                    Clgm_Type_raw = value;
                    OnPropertyChanged(nameof(Clgm_Type));
                }
            }

            protected byte Unk_1_raw;
            public const string Unk_1_displayName = "Unk 1";
            public const int Unk_1_sortIndex = 300;
            [SortOrder(Unk_1_sortIndex)]
            [DisplayName(Unk_1_displayName)]
            public virtual byte Unk_1 {
                get => Unk_1_raw;
                set {
                    if (Unk_1_raw == value) return;
                    Unk_1_raw = value;
                    OnPropertyChanged(nameof(Unk_1));
                }
            }

            public partial class CLGMs : MhwStructItem {
                public const ulong FixedSizeCount = 0;
                public const string GridName = "CLGMs";

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

                protected char[] Name_raw;
                public const string Name_displayName = "Name";
                public const int Name_sortIndex = 100;
                [SortOrder(Name_sortIndex)]
                [DisplayName(Name_displayName)]
                [IsReadOnly]
                public virtual string Name {
                    get => (string) new string(Name_raw);
                    set {
                        if ((string) new string(Name_raw) == value) return;
                        Name_raw = (char[]) value.ToCharArray(0, 3);
                        OnPropertyChanged(nameof(Name));
                    }
                }

                protected uint Magic_2_raw;
                public const string Magic_2_displayName = "Magic 2";
                public const int Magic_2_sortIndex = 150;
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

                protected uint Clgm_Inner_Count_raw;
                public const string Clgm_Inner_Count_displayName = "Clgm Inner Count";
                public const int Clgm_Inner_Count_sortIndex = 200;
                [SortOrder(Clgm_Inner_Count_sortIndex)]
                [DisplayName(Clgm_Inner_Count_displayName)]
                [IsReadOnly]
                public virtual uint Clgm_Inner_Count {
                    get => Clgm_Inner_Count_raw;
                    set {
                        if (Clgm_Inner_Count_raw == value) return;
                        Clgm_Inner_Count_raw = value;
                        OnPropertyChanged(nameof(Clgm_Inner_Count));
                    }
                }

                public partial class CLGM_Inner : MhwStructItem {
                    public const ulong FixedSizeCount = 0;
                    public const string GridName = "CLGM Inner";

                    protected byte Unk_1_raw;
                    public const string Unk_1_displayName = "Unk 1";
                    public const int Unk_1_sortIndex = 50;
                    [SortOrder(Unk_1_sortIndex)]
                    [DisplayName(Unk_1_displayName)]
                    public virtual byte Unk_1 {
                        get => Unk_1_raw;
                        set {
                            if (Unk_1_raw == value) return;
                            Unk_1_raw = value;
                            OnPropertyChanged(nameof(Unk_1));
                        }
                    }

                    protected byte Unk_2_raw;
                    public const string Unk_2_displayName = "Unk 2";
                    public const int Unk_2_sortIndex = 100;
                    [SortOrder(Unk_2_sortIndex)]
                    [DisplayName(Unk_2_displayName)]
                    public virtual byte Unk_2 {
                        get => Unk_2_raw;
                        set {
                            if (Unk_2_raw == value) return;
                            Unk_2_raw = value;
                            OnPropertyChanged(nameof(Unk_2));
                        }
                    }

                    protected float Attack_Range_raw;
                    public const string Attack_Range_displayName = "Attack Range";
                    public const int Attack_Range_sortIndex = 150;
                    [SortOrder(Attack_Range_sortIndex)]
                    [DisplayName(Attack_Range_displayName)]
                    public virtual float Attack_Range {
                        get => Attack_Range_raw;
                        set {
                            if (Attack_Range_raw == value) return;
                            Attack_Range_raw = value;
                            OnPropertyChanged(nameof(Attack_Range));
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

                    protected float Unk_6_raw;
                    public const string Unk_6_displayName = "Unk 6";
                    public const int Unk_6_sortIndex = 300;
                    [SortOrder(Unk_6_sortIndex)]
                    [DisplayName(Unk_6_displayName)]
                    public virtual float Unk_6 {
                        get => Unk_6_raw;
                        set {
                            if (Unk_6_raw == value) return;
                            Unk_6_raw = value;
                            OnPropertyChanged(nameof(Unk_6));
                        }
                    }

                    protected short Unk_7_raw;
                    public const string Unk_7_displayName = "Unk 7";
                    public const int Unk_7_sortIndex = 350;
                    [SortOrder(Unk_7_sortIndex)]
                    [DisplayName(Unk_7_displayName)]
                    public virtual short Unk_7 {
                        get => Unk_7_raw;
                        set {
                            if (Unk_7_raw == value) return;
                            Unk_7_raw = value;
                            OnPropertyChanged(nameof(Unk_7));
                        }
                    }

                    protected short Unk_8_raw;
                    public const string Unk_8_displayName = "Unk 8";
                    public const int Unk_8_sortIndex = 400;
                    [SortOrder(Unk_8_sortIndex)]
                    [DisplayName(Unk_8_displayName)]
                    public virtual short Unk_8 {
                        get => Unk_8_raw;
                        set {
                            if (Unk_8_raw == value) return;
                            Unk_8_raw = value;
                            OnPropertyChanged(nameof(Unk_8));
                        }
                    }

                    protected float Unk_9_raw;
                    public const string Unk_9_displayName = "Unk 9";
                    public const int Unk_9_sortIndex = 450;
                    [SortOrder(Unk_9_sortIndex)]
                    [DisplayName(Unk_9_displayName)]
                    public virtual float Unk_9 {
                        get => Unk_9_raw;
                        set {
                            if (Unk_9_raw == value) return;
                            Unk_9_raw = value;
                            OnPropertyChanged(nameof(Unk_9));
                        }
                    }

                    protected float Unk_10_raw;
                    public const string Unk_10_displayName = "Unk 10";
                    public const int Unk_10_sortIndex = 500;
                    [SortOrder(Unk_10_sortIndex)]
                    [DisplayName(Unk_10_displayName)]
                    public virtual float Unk_10 {
                        get => Unk_10_raw;
                        set {
                            if (Unk_10_raw == value) return;
                            Unk_10_raw = value;
                            OnPropertyChanged(nameof(Unk_10));
                        }
                    }

                    protected float Unk_11_raw;
                    public const string Unk_11_displayName = "Unk 11";
                    public const int Unk_11_sortIndex = 550;
                    [SortOrder(Unk_11_sortIndex)]
                    [DisplayName(Unk_11_displayName)]
                    public virtual float Unk_11 {
                        get => Unk_11_raw;
                        set {
                            if (Unk_11_raw == value) return;
                            Unk_11_raw = value;
                            OnPropertyChanged(nameof(Unk_11));
                        }
                    }

                    protected float Unk_12_raw;
                    public const string Unk_12_displayName = "Unk 12";
                    public const int Unk_12_sortIndex = 600;
                    [SortOrder(Unk_12_sortIndex)]
                    [DisplayName(Unk_12_displayName)]
                    public virtual float Unk_12 {
                        get => Unk_12_raw;
                        set {
                            if (Unk_12_raw == value) return;
                            Unk_12_raw = value;
                            OnPropertyChanged(nameof(Unk_12));
                        }
                    }

                    protected float Unk_13_raw;
                    public const string Unk_13_displayName = "Unk 13";
                    public const int Unk_13_sortIndex = 650;
                    [SortOrder(Unk_13_sortIndex)]
                    [DisplayName(Unk_13_displayName)]
                    public virtual float Unk_13 {
                        get => Unk_13_raw;
                        set {
                            if (Unk_13_raw == value) return;
                            Unk_13_raw = value;
                            OnPropertyChanged(nameof(Unk_13));
                        }
                    }

                    protected float Unk_14_raw;
                    public const string Unk_14_displayName = "Unk 14";
                    public const int Unk_14_sortIndex = 700;
                    [SortOrder(Unk_14_sortIndex)]
                    [DisplayName(Unk_14_displayName)]
                    public virtual float Unk_14 {
                        get => Unk_14_raw;
                        set {
                            if (Unk_14_raw == value) return;
                            Unk_14_raw = value;
                            OnPropertyChanged(nameof(Unk_14));
                        }
                    }

                    protected ushort Unk_15_raw;
                    public const string Unk_15_displayName = "Unk 15";
                    public const int Unk_15_sortIndex = 750;
                    [SortOrder(Unk_15_sortIndex)]
                    [DisplayName(Unk_15_displayName)]
                    public virtual ushort Unk_15 {
                        get => Unk_15_raw;
                        set {
                            if (Unk_15_raw == value) return;
                            Unk_15_raw = value;
                            OnPropertyChanged(nameof(Unk_15));
                        }
                    }

                    protected uint Unk_16_raw;
                    public const string Unk_16_displayName = "Unk 16";
                    public const int Unk_16_sortIndex = 800;
                    [SortOrder(Unk_16_sortIndex)]
                    [DisplayName(Unk_16_displayName)]
                    public virtual uint Unk_16 {
                        get => Unk_16_raw;
                        set {
                            if (Unk_16_raw == value) return;
                            Unk_16_raw = value;
                            OnPropertyChanged(nameof(Unk_16));
                        }
                    }

                    protected short Unk_17_raw;
                    public const string Unk_17_displayName = "Unk 17";
                    public const int Unk_17_sortIndex = 850;
                    [SortOrder(Unk_17_sortIndex)]
                    [DisplayName(Unk_17_displayName)]
                    public virtual short Unk_17 {
                        get => Unk_17_raw;
                        set {
                            if (Unk_17_raw == value) return;
                            Unk_17_raw = value;
                            OnPropertyChanged(nameof(Unk_17));
                        }
                    }

                    protected float Unk_18_raw;
                    public const string Unk_18_displayName = "Unk 18";
                    public const int Unk_18_sortIndex = 900;
                    [SortOrder(Unk_18_sortIndex)]
                    [DisplayName(Unk_18_displayName)]
                    public virtual float Unk_18 {
                        get => Unk_18_raw;
                        set {
                            if (Unk_18_raw == value) return;
                            Unk_18_raw = value;
                            OnPropertyChanged(nameof(Unk_18));
                        }
                    }

                    protected float Unk_19_raw;
                    public const string Unk_19_displayName = "Unk 19";
                    public const int Unk_19_sortIndex = 950;
                    [SortOrder(Unk_19_sortIndex)]
                    [DisplayName(Unk_19_displayName)]
                    public virtual float Unk_19 {
                        get => Unk_19_raw;
                        set {
                            if (Unk_19_raw == value) return;
                            Unk_19_raw = value;
                            OnPropertyChanged(nameof(Unk_19));
                        }
                    }

                    protected float Unk_20_raw;
                    public const string Unk_20_displayName = "Unk 20";
                    public const int Unk_20_sortIndex = 1000;
                    [SortOrder(Unk_20_sortIndex)]
                    [DisplayName(Unk_20_displayName)]
                    public virtual float Unk_20 {
                        get => Unk_20_raw;
                        set {
                            if (Unk_20_raw == value) return;
                            Unk_20_raw = value;
                            OnPropertyChanged(nameof(Unk_20));
                        }
                    }

                    protected float Unk_21_raw;
                    public const string Unk_21_displayName = "Unk 21";
                    public const int Unk_21_sortIndex = 1050;
                    [SortOrder(Unk_21_sortIndex)]
                    [DisplayName(Unk_21_displayName)]
                    public virtual float Unk_21 {
                        get => Unk_21_raw;
                        set {
                            if (Unk_21_raw == value) return;
                            Unk_21_raw = value;
                            OnPropertyChanged(nameof(Unk_21));
                        }
                    }

                    protected ushort Unk_22_raw;
                    public const string Unk_22_displayName = "Unk 22";
                    public const int Unk_22_sortIndex = 1100;
                    [SortOrder(Unk_22_sortIndex)]
                    [DisplayName(Unk_22_displayName)]
                    public virtual ushort Unk_22 {
                        get => Unk_22_raw;
                        set {
                            if (Unk_22_raw == value) return;
                            Unk_22_raw = value;
                            OnPropertyChanged(nameof(Unk_22));
                        }
                    }

                    public const int lastSortIndex = 1150;

                    public static ObservableCollection<CLGM_Inner> LoadData(BinaryReader reader, CLGMs parent) {
                        var list = new ObservableCollection<CLGM_Inner>();
                        var count = (ulong) parent.Clgm_Inner_Count;
                        for (ulong i = 0; i < count; i++) {
                            list.Add(LoadData(reader, i, parent));
                        }
                        return list;
                    }

                    public static CLGM_Inner LoadData(BinaryReader reader, ulong i, CLGMs parent) {
                        var data = new CLGM_Inner();
                        data.Index = i;
                        data.Unk_1_raw = reader.ReadByte();
                        data.Unk_2_raw = reader.ReadByte();
                        data.Attack_Range_raw = reader.ReadSingle();
                        data.Unk_4_raw = reader.ReadSingle();
                        data.Unk_5_raw = reader.ReadSingle();
                        data.Unk_6_raw = reader.ReadSingle();
                        data.Unk_7_raw = reader.ReadInt16();
                        data.Unk_8_raw = reader.ReadInt16();
                        data.Unk_9_raw = reader.ReadSingle();
                        data.Unk_10_raw = reader.ReadSingle();
                        data.Unk_11_raw = reader.ReadSingle();
                        data.Unk_12_raw = reader.ReadSingle();
                        data.Unk_13_raw = reader.ReadSingle();
                        data.Unk_14_raw = reader.ReadSingle();
                        data.Unk_15_raw = reader.ReadUInt16();
                        data.Unk_16_raw = reader.ReadUInt32();
                        data.Unk_17_raw = reader.ReadInt16();
                        data.Unk_18_raw = reader.ReadSingle();
                        data.Unk_19_raw = reader.ReadSingle();
                        data.Unk_20_raw = reader.ReadSingle();
                        data.Unk_21_raw = reader.ReadSingle();
                        data.Unk_22_raw = reader.ReadUInt16();
                        return data;
                    }

                    public void WriteData(BinaryWriter writer, CLGMs parent) {
                        writer.Write(Unk_1_raw);
                        writer.Write(Unk_2_raw);
                        writer.Write(Attack_Range_raw);
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
                    }
                }

                public const string CLGM_Inner_displayName = "CLGM Inner";
                public const int CLGM_Inner_sortIndex = 250;
                [SortOrder(CLGM_Inner_sortIndex)]
                [DisplayName(CLGM_Inner_displayName)]
                public virtual ObservableCollection<CLGM_Inner> CLGM_Inner_raw { get; protected set; }

                protected uint Unk_1_raw;
                public const string Unk_1_displayName = "Unk 1";
                public const int Unk_1_sortIndex = 300;
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

                protected uint Attack_Range_if_Unk_1_1__raw;
                public const string Attack_Range_if_Unk_1_1__displayName = "Attack Range (if 'Unk 1' == 1)";
                public const int Attack_Range_if_Unk_1_1__sortIndex = 350;
                [SortOrder(Attack_Range_if_Unk_1_1__sortIndex)]
                [DisplayName(Attack_Range_if_Unk_1_1__displayName)]
                public virtual uint Attack_Range_if_Unk_1_1_ {
                    get => Attack_Range_if_Unk_1_1__raw;
                    set {
                        if (Attack_Range_if_Unk_1_1__raw == value) return;
                        Attack_Range_if_Unk_1_1__raw = value;
                        OnPropertyChanged(nameof(Attack_Range_if_Unk_1_1_));
                    }
                }

                protected byte Unk_2_raw;
                public const string Unk_2_displayName = "Unk 2";
                public const int Unk_2_sortIndex = 400;
                [SortOrder(Unk_2_sortIndex)]
                [DisplayName(Unk_2_displayName)]
                public virtual byte Unk_2 {
                    get => Unk_2_raw;
                    set {
                        if (Unk_2_raw == value) return;
                        Unk_2_raw = value;
                        OnPropertyChanged(nameof(Unk_2));
                    }
                }

                protected byte Unk_3_raw;
                public const string Unk_3_displayName = "Unk 3";
                public const int Unk_3_sortIndex = 450;
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

                protected byte Unk_4_raw;
                public const string Unk_4_displayName = "Unk 4";
                public const int Unk_4_sortIndex = 500;
                [SortOrder(Unk_4_sortIndex)]
                [DisplayName(Unk_4_displayName)]
                public virtual byte Unk_4 {
                    get => Unk_4_raw;
                    set {
                        if (Unk_4_raw == value) return;
                        Unk_4_raw = value;
                        OnPropertyChanged(nameof(Unk_4));
                    }
                }

                protected byte Unk_5_raw;
                public const string Unk_5_displayName = "Unk 5";
                public const int Unk_5_sortIndex = 550;
                [SortOrder(Unk_5_sortIndex)]
                [DisplayName(Unk_5_displayName)]
                public virtual byte Unk_5 {
                    get => Unk_5_raw;
                    set {
                        if (Unk_5_raw == value) return;
                        Unk_5_raw = value;
                        OnPropertyChanged(nameof(Unk_5));
                    }
                }

                protected uint Unk_6_raw;
                public const string Unk_6_displayName = "Unk 6";
                public const int Unk_6_sortIndex = 600;
                [SortOrder(Unk_6_sortIndex)]
                [DisplayName(Unk_6_displayName)]
                public virtual uint Unk_6 {
                    get => Unk_6_raw;
                    set {
                        if (Unk_6_raw == value) return;
                        Unk_6_raw = value;
                        OnPropertyChanged(nameof(Unk_6));
                    }
                }

                protected uint Unk_7_raw;
                public const string Unk_7_displayName = "Unk 7";
                public const int Unk_7_sortIndex = 650;
                [SortOrder(Unk_7_sortIndex)]
                [DisplayName(Unk_7_displayName)]
                public virtual uint Unk_7 {
                    get => Unk_7_raw;
                    set {
                        if (Unk_7_raw == value) return;
                        Unk_7_raw = value;
                        OnPropertyChanged(nameof(Unk_7));
                    }
                }

                protected short Unk_8_raw;
                public const string Unk_8_displayName = "Unk 8";
                public const int Unk_8_sortIndex = 700;
                [SortOrder(Unk_8_sortIndex)]
                [DisplayName(Unk_8_displayName)]
                public virtual short Unk_8 {
                    get => Unk_8_raw;
                    set {
                        if (Unk_8_raw == value) return;
                        Unk_8_raw = value;
                        OnPropertyChanged(nameof(Unk_8));
                    }
                }

                protected ushort Unk_9_raw;
                public const string Unk_9_displayName = "Unk 9";
                public const int Unk_9_sortIndex = 750;
                [SortOrder(Unk_9_sortIndex)]
                [DisplayName(Unk_9_displayName)]
                public virtual ushort Unk_9 {
                    get => Unk_9_raw;
                    set {
                        if (Unk_9_raw == value) return;
                        Unk_9_raw = value;
                        OnPropertyChanged(nameof(Unk_9));
                    }
                }

                protected ushort Unk_10_raw;
                public const string Unk_10_displayName = "Unk 10";
                public const int Unk_10_sortIndex = 800;
                [SortOrder(Unk_10_sortIndex)]
                [DisplayName(Unk_10_displayName)]
                public virtual ushort Unk_10 {
                    get => Unk_10_raw;
                    set {
                        if (Unk_10_raw == value) return;
                        Unk_10_raw = value;
                        OnPropertyChanged(nameof(Unk_10));
                    }
                }

                protected int Unk_11_raw;
                public const string Unk_11_displayName = "Unk 11";
                public const int Unk_11_sortIndex = 850;
                [SortOrder(Unk_11_sortIndex)]
                [DisplayName(Unk_11_displayName)]
                public virtual int Unk_11 {
                    get => Unk_11_raw;
                    set {
                        if (Unk_11_raw == value) return;
                        Unk_11_raw = value;
                        OnPropertyChanged(nameof(Unk_11));
                    }
                }

                protected int Unk_12_raw;
                public const string Unk_12_displayName = "Unk 12";
                public const int Unk_12_sortIndex = 900;
                [SortOrder(Unk_12_sortIndex)]
                [DisplayName(Unk_12_displayName)]
                public virtual int Unk_12 {
                    get => Unk_12_raw;
                    set {
                        if (Unk_12_raw == value) return;
                        Unk_12_raw = value;
                        OnPropertyChanged(nameof(Unk_12));
                    }
                }

                protected int Unk_13_raw;
                public const string Unk_13_displayName = "Unk 13";
                public const int Unk_13_sortIndex = 950;
                [SortOrder(Unk_13_sortIndex)]
                [DisplayName(Unk_13_displayName)]
                public virtual int Unk_13 {
                    get => Unk_13_raw;
                    set {
                        if (Unk_13_raw == value) return;
                        Unk_13_raw = value;
                        OnPropertyChanged(nameof(Unk_13));
                    }
                }

                protected int Unk_14_raw;
                public const string Unk_14_displayName = "Unk 14";
                public const int Unk_14_sortIndex = 1000;
                [SortOrder(Unk_14_sortIndex)]
                [DisplayName(Unk_14_displayName)]
                public virtual int Unk_14 {
                    get => Unk_14_raw;
                    set {
                        if (Unk_14_raw == value) return;
                        Unk_14_raw = value;
                        OnPropertyChanged(nameof(Unk_14));
                    }
                }

                protected int Unk_15_raw;
                public const string Unk_15_displayName = "Unk 15";
                public const int Unk_15_sortIndex = 1050;
                [SortOrder(Unk_15_sortIndex)]
                [DisplayName(Unk_15_displayName)]
                public virtual int Unk_15 {
                    get => Unk_15_raw;
                    set {
                        if (Unk_15_raw == value) return;
                        Unk_15_raw = value;
                        OnPropertyChanged(nameof(Unk_15));
                    }
                }

                protected int Unk_16_raw;
                public const string Unk_16_displayName = "Unk 16";
                public const int Unk_16_sortIndex = 1100;
                [SortOrder(Unk_16_sortIndex)]
                [DisplayName(Unk_16_displayName)]
                public virtual int Unk_16 {
                    get => Unk_16_raw;
                    set {
                        if (Unk_16_raw == value) return;
                        Unk_16_raw = value;
                        OnPropertyChanged(nameof(Unk_16));
                    }
                }

                protected int Unk_17_raw;
                public const string Unk_17_displayName = "Unk 17";
                public const int Unk_17_sortIndex = 1150;
                [SortOrder(Unk_17_sortIndex)]
                [DisplayName(Unk_17_displayName)]
                public virtual int Unk_17 {
                    get => Unk_17_raw;
                    set {
                        if (Unk_17_raw == value) return;
                        Unk_17_raw = value;
                        OnPropertyChanged(nameof(Unk_17));
                    }
                }

                protected int Unk_18_raw;
                public const string Unk_18_displayName = "Unk 18";
                public const int Unk_18_sortIndex = 1200;
                [SortOrder(Unk_18_sortIndex)]
                [DisplayName(Unk_18_displayName)]
                public virtual int Unk_18 {
                    get => Unk_18_raw;
                    set {
                        if (Unk_18_raw == value) return;
                        Unk_18_raw = value;
                        OnPropertyChanged(nameof(Unk_18));
                    }
                }

                protected byte Unk_19_raw;
                public const string Unk_19_displayName = "Unk 19";
                public const int Unk_19_sortIndex = 1250;
                [SortOrder(Unk_19_sortIndex)]
                [DisplayName(Unk_19_displayName)]
                public virtual byte Unk_19 {
                    get => Unk_19_raw;
                    set {
                        if (Unk_19_raw == value) return;
                        Unk_19_raw = value;
                        OnPropertyChanged(nameof(Unk_19));
                    }
                }

                public const int lastSortIndex = 1300;

                public static ObservableCollection<CLGMs> LoadData(BinaryReader reader, CLND parent) {
                    var list = new ObservableCollection<CLGMs>();
                    var count = (ulong) parent.Clgm_Count;
                    for (ulong i = 0; i < count; i++) {
                        list.Add(LoadData(reader, i, parent));
                    }
                    return list;
                }

                public static CLGMs LoadData(BinaryReader reader, ulong i, CLND parent) {
                    var data = new CLGMs();
                    data.Index = i;
                    data.Magic_1_raw = reader.ReadUInt32();
                    data.Name_raw = reader.ReadChars(4);
                    data.Magic_2_raw = reader.ReadUInt32();
                    data.Clgm_Inner_Count_raw = reader.ReadUInt32();
                    data.CLGM_Inner_raw = CLGM_Inner.LoadData(reader, data);
                    data.Unk_1_raw = reader.ReadUInt32();
                    data.Attack_Range_if_Unk_1_1__raw = reader.ReadUInt32();
                    data.Unk_2_raw = reader.ReadByte();
                    data.Unk_3_raw = reader.ReadByte();
                    data.Unk_4_raw = reader.ReadByte();
                    data.Unk_5_raw = reader.ReadByte();
                    data.Unk_6_raw = reader.ReadUInt32();
                    data.Unk_7_raw = reader.ReadUInt32();
                    data.Unk_8_raw = reader.ReadInt16();
                    data.Unk_9_raw = reader.ReadUInt16();
                    data.Unk_10_raw = reader.ReadUInt16();
                    if (parent.Clgm_Type_raw == 2) data.Unk_11_raw = reader.ReadInt32();
                    if (parent.Clgm_Type_raw == 2) data.Unk_12_raw = reader.ReadInt32();
                    if (parent.Clgm_Type_raw == 2) data.Unk_13_raw = reader.ReadInt32();
                    if (parent.Clgm_Type_raw == 2) data.Unk_14_raw = reader.ReadInt32();
                    if (parent.Clgm_Type_raw == 2) data.Unk_15_raw = reader.ReadInt32();
                    if (parent.Clgm_Type_raw == 2) data.Unk_16_raw = reader.ReadInt32();
                    if (parent.Clgm_Type_raw == 2) data.Unk_17_raw = reader.ReadInt32();
                    if (parent.Clgm_Type_raw == 2) data.Unk_18_raw = reader.ReadInt32();
                    data.Unk_19_raw = reader.ReadByte();
                    return data;
                }

                public void WriteData(BinaryWriter writer, CLND parent) {
                    Clgm_Inner_Count = (uint) CLGM_Inner_raw.Count;
                    writer.Write(Magic_1_raw);
                    writer.Write(Name_raw);
                    writer.Write(Magic_2_raw);
                    writer.Write(Clgm_Inner_Count_raw);
                    foreach (var obj in CLGM_Inner_raw) {
                        obj.WriteData(writer, this);
                    }
                    writer.Write(Unk_1_raw);
                    writer.Write(Attack_Range_if_Unk_1_1__raw);
                    writer.Write(Unk_2_raw);
                    writer.Write(Unk_3_raw);
                    writer.Write(Unk_4_raw);
                    writer.Write(Unk_5_raw);
                    writer.Write(Unk_6_raw);
                    writer.Write(Unk_7_raw);
                    writer.Write(Unk_8_raw);
                    writer.Write(Unk_9_raw);
                    writer.Write(Unk_10_raw);
                    if (parent.Clgm_Type_raw == 2) writer.Write(Unk_11_raw);
                    if (parent.Clgm_Type_raw == 2) writer.Write(Unk_12_raw);
                    if (parent.Clgm_Type_raw == 2) writer.Write(Unk_13_raw);
                    if (parent.Clgm_Type_raw == 2) writer.Write(Unk_14_raw);
                    if (parent.Clgm_Type_raw == 2) writer.Write(Unk_15_raw);
                    if (parent.Clgm_Type_raw == 2) writer.Write(Unk_16_raw);
                    if (parent.Clgm_Type_raw == 2) writer.Write(Unk_17_raw);
                    if (parent.Clgm_Type_raw == 2) writer.Write(Unk_18_raw);
                    writer.Write(Unk_19_raw);
                }
            }

            public const string CLGMs_displayName = "CLGMs";
            public const int CLGMs_sortIndex = 350;
            [SortOrder(CLGMs_sortIndex)]
            [DisplayName(CLGMs_displayName)]
            public virtual ObservableCollection<CLGMs> CLGMs_raw { get; protected set; }

            protected byte Unk_2_raw;
            public const string Unk_2_displayName = "Unk 2";
            public const int Unk_2_sortIndex = 400;
            [SortOrder(Unk_2_sortIndex)]
            [DisplayName(Unk_2_displayName)]
            public virtual byte Unk_2 {
                get => Unk_2_raw;
                set {
                    if (Unk_2_raw == value) return;
                    Unk_2_raw = value;
                    OnPropertyChanged(nameof(Unk_2));
                }
            }

            protected byte Unk_3_raw;
            public const string Unk_3_displayName = "Unk 3";
            public const int Unk_3_sortIndex = 450;
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

            protected byte Unk_4_raw;
            public const string Unk_4_displayName = "Unk 4";
            public const int Unk_4_sortIndex = 500;
            [SortOrder(Unk_4_sortIndex)]
            [DisplayName(Unk_4_displayName)]
            public virtual byte Unk_4 {
                get => Unk_4_raw;
                set {
                    if (Unk_4_raw == value) return;
                    Unk_4_raw = value;
                    OnPropertyChanged(nameof(Unk_4));
                }
            }

            public const int lastSortIndex = 550;

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static CLND LoadData(BinaryReader reader, ulong i) {
                var data = new CLND();
                data.Index = i;
                data.Magic_1_raw = reader.ReadUInt32();
                data.Name_raw = reader.ReadChars(4);
                data.Magic_2_raw = reader.ReadUInt32();
                data.Clgm_Count_raw = reader.ReadUInt32();
                data.Clgm_Type_raw = reader.ReadUInt32();
                data.Unk_1_raw = reader.ReadByte();
                data.CLGMs_raw = CLGMs.LoadData(reader, data);
                data.Unk_2_raw = reader.ReadByte();
                data.Unk_3_raw = reader.ReadByte();
                data.Unk_4_raw = reader.ReadByte();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                Clgm_Count = (uint) CLGMs_raw.Count;
                writer.Write(Magic_1_raw);
                writer.Write(Name_raw);
                writer.Write(Magic_2_raw);
                writer.Write(Clgm_Count_raw);
                writer.Write(Clgm_Type_raw);
                writer.Write(Unk_1_raw);
                foreach (var obj in CLGMs_raw) {
                    obj.WriteData(writer, this);
                }
                writer.Write(Unk_2_raw);
                writer.Write(Unk_3_raw);
                writer.Write(Unk_4_raw);
            }
        }

        public partial class Moves : MhwStructItem {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Moves";

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

            protected char[] Name_raw;
            public const string Name_displayName = "Name";
            public const int Name_sortIndex = 100;
            [SortOrder(Name_sortIndex)]
            [DisplayName(Name_displayName)]
            [IsReadOnly]
            public virtual string Name {
                get => (string) new string(Name_raw);
                set {
                    if ((string) new string(Name_raw) == value) return;
                    Name_raw = (char[]) value.ToCharArray(0, 3);
                    OnPropertyChanged(nameof(Name));
                }
            }

            protected uint Magic_2_raw;
            public const string Magic_2_displayName = "Magic 2";
            public const int Magic_2_sortIndex = 150;
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

            protected uint Move_Count_raw;
            public const string Move_Count_displayName = "Move Count";
            public const int Move_Count_sortIndex = 200;
            [SortOrder(Move_Count_sortIndex)]
            [DisplayName(Move_Count_displayName)]
            [IsReadOnly]
            public virtual uint Move_Count {
                get => Move_Count_raw;
                set {
                    if (Move_Count_raw == value) return;
                    Move_Count_raw = value;
                    OnPropertyChanged(nameof(Move_Count));
                }
            }

            protected uint Move_Type_raw;
            public const string Move_Type_displayName = "Move Type";
            public const int Move_Type_sortIndex = 250;
            [SortOrder(Move_Type_sortIndex)]
            [DisplayName(Move_Type_displayName)]
            [IsReadOnly]
            public virtual uint Move_Type {
                get => Move_Type_raw;
                set {
                    if (Move_Type_raw == value) return;
                    Move_Type_raw = value;
                    OnPropertyChanged(nameof(Move_Type));
                }
            }

            public partial class Atk0 : MhwStructItem {
                public const ulong FixedSizeCount = 0;
                public const string GridName = "Atk0";

                protected uint Index_raw;
                public const string Index_displayName = "Index";
                public const int Index_sortIndex = 50;
                [SortOrder(Index_sortIndex)]
                [DisplayName(Index_displayName)]
                public override ulong Index {
                    get => (ulong) Index_raw;
                    set {
                        if ((ulong) Index_raw == value) return;
                        Index_raw = (uint) value;
                        OnPropertyChanged(nameof(Index));
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

                protected float Unk_3_raw;
                public const string Unk_3_displayName = "Unk 3";
                public const int Unk_3_sortIndex = 200;
                [SortOrder(Unk_3_sortIndex)]
                [DisplayName(Unk_3_displayName)]
                public virtual float Unk_3 {
                    get => Unk_3_raw;
                    set {
                        if (Unk_3_raw == value) return;
                        Unk_3_raw = value;
                        OnPropertyChanged(nameof(Unk_3));
                    }
                }

                protected float Unk_4_raw;
                public const string Unk_4_displayName = "Unk 4";
                public const int Unk_4_sortIndex = 250;
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
                public const int Unk_5_sortIndex = 300;
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

                protected uint Unk_6_raw;
                public const string Unk_6_displayName = "Unk 6";
                public const int Unk_6_sortIndex = 350;
                [SortOrder(Unk_6_sortIndex)]
                [DisplayName(Unk_6_displayName)]
                public virtual uint Unk_6 {
                    get => Unk_6_raw;
                    set {
                        if (Unk_6_raw == value) return;
                        Unk_6_raw = value;
                        OnPropertyChanged(nameof(Unk_6));
                    }
                }

                protected uint Unk_7_raw;
                public const string Unk_7_displayName = "Unk 7";
                public const int Unk_7_sortIndex = 400;
                [SortOrder(Unk_7_sortIndex)]
                [DisplayName(Unk_7_displayName)]
                public virtual uint Unk_7 {
                    get => Unk_7_raw;
                    set {
                        if (Unk_7_raw == value) return;
                        Unk_7_raw = value;
                        OnPropertyChanged(nameof(Unk_7));
                    }
                }

                protected uint Unk_8_raw;
                public const string Unk_8_displayName = "Unk 8";
                public const int Unk_8_sortIndex = 450;
                [SortOrder(Unk_8_sortIndex)]
                [DisplayName(Unk_8_displayName)]
                public virtual uint Unk_8 {
                    get => Unk_8_raw;
                    set {
                        if (Unk_8_raw == value) return;
                        Unk_8_raw = value;
                        OnPropertyChanged(nameof(Unk_8));
                    }
                }

                protected uint Unk_9_raw;
                public const string Unk_9_displayName = "Unk 9";
                public const int Unk_9_sortIndex = 500;
                [SortOrder(Unk_9_sortIndex)]
                [DisplayName(Unk_9_displayName)]
                public virtual uint Unk_9 {
                    get => Unk_9_raw;
                    set {
                        if (Unk_9_raw == value) return;
                        Unk_9_raw = value;
                        OnPropertyChanged(nameof(Unk_9));
                    }
                }

                protected uint Unk_10_raw;
                public const string Unk_10_displayName = "Unk 10";
                public const int Unk_10_sortIndex = 550;
                [SortOrder(Unk_10_sortIndex)]
                [DisplayName(Unk_10_displayName)]
                public virtual uint Unk_10 {
                    get => Unk_10_raw;
                    set {
                        if (Unk_10_raw == value) return;
                        Unk_10_raw = value;
                        OnPropertyChanged(nameof(Unk_10));
                    }
                }

                protected uint Unk_11_raw;
                public const string Unk_11_displayName = "Unk 11";
                public const int Unk_11_sortIndex = 600;
                [SortOrder(Unk_11_sortIndex)]
                [DisplayName(Unk_11_displayName)]
                public virtual uint Unk_11 {
                    get => Unk_11_raw;
                    set {
                        if (Unk_11_raw == value) return;
                        Unk_11_raw = value;
                        OnPropertyChanged(nameof(Unk_11));
                    }
                }

                protected uint Unk_12_raw;
                public const string Unk_12_displayName = "Unk 12";
                public const int Unk_12_sortIndex = 650;
                [SortOrder(Unk_12_sortIndex)]
                [DisplayName(Unk_12_displayName)]
                public virtual uint Unk_12 {
                    get => Unk_12_raw;
                    set {
                        if (Unk_12_raw == value) return;
                        Unk_12_raw = value;
                        OnPropertyChanged(nameof(Unk_12));
                    }
                }

                protected uint Unk_13_raw;
                public const string Unk_13_displayName = "Unk 13";
                public const int Unk_13_sortIndex = 700;
                [SortOrder(Unk_13_sortIndex)]
                [DisplayName(Unk_13_displayName)]
                public virtual uint Unk_13 {
                    get => Unk_13_raw;
                    set {
                        if (Unk_13_raw == value) return;
                        Unk_13_raw = value;
                        OnPropertyChanged(nameof(Unk_13));
                    }
                }

                protected uint Unk_14_raw;
                public const string Unk_14_displayName = "Unk 14";
                public const int Unk_14_sortIndex = 750;
                [SortOrder(Unk_14_sortIndex)]
                [DisplayName(Unk_14_displayName)]
                public virtual uint Unk_14 {
                    get => Unk_14_raw;
                    set {
                        if (Unk_14_raw == value) return;
                        Unk_14_raw = value;
                        OnPropertyChanged(nameof(Unk_14));
                    }
                }

                protected uint Unk_15_raw;
                public const string Unk_15_displayName = "Unk 15";
                public const int Unk_15_sortIndex = 800;
                [SortOrder(Unk_15_sortIndex)]
                [DisplayName(Unk_15_displayName)]
                public virtual uint Unk_15 {
                    get => Unk_15_raw;
                    set {
                        if (Unk_15_raw == value) return;
                        Unk_15_raw = value;
                        OnPropertyChanged(nameof(Unk_15));
                    }
                }

                protected uint Unk_16_raw;
                public const string Unk_16_displayName = "Unk 16";
                public const int Unk_16_sortIndex = 850;
                [SortOrder(Unk_16_sortIndex)]
                [DisplayName(Unk_16_displayName)]
                public virtual uint Unk_16 {
                    get => Unk_16_raw;
                    set {
                        if (Unk_16_raw == value) return;
                        Unk_16_raw = value;
                        OnPropertyChanged(nameof(Unk_16));
                    }
                }

                protected uint Unk_17_raw;
                public const string Unk_17_displayName = "Unk 17";
                public const int Unk_17_sortIndex = 900;
                [SortOrder(Unk_17_sortIndex)]
                [DisplayName(Unk_17_displayName)]
                public virtual uint Unk_17 {
                    get => Unk_17_raw;
                    set {
                        if (Unk_17_raw == value) return;
                        Unk_17_raw = value;
                        OnPropertyChanged(nameof(Unk_17));
                    }
                }

                protected uint Unk_18_raw;
                public const string Unk_18_displayName = "Unk 18";
                public const int Unk_18_sortIndex = 950;
                [SortOrder(Unk_18_sortIndex)]
                [DisplayName(Unk_18_displayName)]
                public virtual uint Unk_18 {
                    get => Unk_18_raw;
                    set {
                        if (Unk_18_raw == value) return;
                        Unk_18_raw = value;
                        OnPropertyChanged(nameof(Unk_18));
                    }
                }

                protected uint Unk_19_raw;
                public const string Unk_19_displayName = "Unk 19";
                public const int Unk_19_sortIndex = 1000;
                [SortOrder(Unk_19_sortIndex)]
                [DisplayName(Unk_19_displayName)]
                public virtual uint Unk_19 {
                    get => Unk_19_raw;
                    set {
                        if (Unk_19_raw == value) return;
                        Unk_19_raw = value;
                        OnPropertyChanged(nameof(Unk_19));
                    }
                }

                protected uint Unk_20_raw;
                public const string Unk_20_displayName = "Unk 20";
                public const int Unk_20_sortIndex = 1050;
                [SortOrder(Unk_20_sortIndex)]
                [DisplayName(Unk_20_displayName)]
                public virtual uint Unk_20 {
                    get => Unk_20_raw;
                    set {
                        if (Unk_20_raw == value) return;
                        Unk_20_raw = value;
                        OnPropertyChanged(nameof(Unk_20));
                    }
                }

                protected uint Unk_21_raw;
                public const string Unk_21_displayName = "Unk 21";
                public const int Unk_21_sortIndex = 1100;
                [SortOrder(Unk_21_sortIndex)]
                [DisplayName(Unk_21_displayName)]
                public virtual uint Unk_21 {
                    get => Unk_21_raw;
                    set {
                        if (Unk_21_raw == value) return;
                        Unk_21_raw = value;
                        OnPropertyChanged(nameof(Unk_21));
                    }
                }

                protected uint Unk_22_raw;
                public const string Unk_22_displayName = "Unk 22";
                public const int Unk_22_sortIndex = 1150;
                [SortOrder(Unk_22_sortIndex)]
                [DisplayName(Unk_22_displayName)]
                public virtual uint Unk_22 {
                    get => Unk_22_raw;
                    set {
                        if (Unk_22_raw == value) return;
                        Unk_22_raw = value;
                        OnPropertyChanged(nameof(Unk_22));
                    }
                }

                protected float Unk_23_raw;
                public const string Unk_23_displayName = "Unk 23";
                public const int Unk_23_sortIndex = 1200;
                [SortOrder(Unk_23_sortIndex)]
                [DisplayName(Unk_23_displayName)]
                public virtual float Unk_23 {
                    get => Unk_23_raw;
                    set {
                        if (Unk_23_raw == value) return;
                        Unk_23_raw = value;
                        OnPropertyChanged(nameof(Unk_23));
                    }
                }

                protected float Unk_24_raw;
                public const string Unk_24_displayName = "Unk 24";
                public const int Unk_24_sortIndex = 1250;
                [SortOrder(Unk_24_sortIndex)]
                [DisplayName(Unk_24_displayName)]
                public virtual float Unk_24 {
                    get => Unk_24_raw;
                    set {
                        if (Unk_24_raw == value) return;
                        Unk_24_raw = value;
                        OnPropertyChanged(nameof(Unk_24));
                    }
                }

                protected float Unk_25_raw;
                public const string Unk_25_displayName = "Unk 25";
                public const int Unk_25_sortIndex = 1300;
                [SortOrder(Unk_25_sortIndex)]
                [DisplayName(Unk_25_displayName)]
                public virtual float Unk_25 {
                    get => Unk_25_raw;
                    set {
                        if (Unk_25_raw == value) return;
                        Unk_25_raw = value;
                        OnPropertyChanged(nameof(Unk_25));
                    }
                }

                protected uint Unk_26_raw;
                public const string Unk_26_displayName = "Unk 26";
                public const int Unk_26_sortIndex = 1350;
                [SortOrder(Unk_26_sortIndex)]
                [DisplayName(Unk_26_displayName)]
                public virtual uint Unk_26 {
                    get => Unk_26_raw;
                    set {
                        if (Unk_26_raw == value) return;
                        Unk_26_raw = value;
                        OnPropertyChanged(nameof(Unk_26));
                    }
                }

                protected uint Unk_27_raw;
                public const string Unk_27_displayName = "Unk 27";
                public const int Unk_27_sortIndex = 1400;
                [SortOrder(Unk_27_sortIndex)]
                [DisplayName(Unk_27_displayName)]
                public virtual uint Unk_27 {
                    get => Unk_27_raw;
                    set {
                        if (Unk_27_raw == value) return;
                        Unk_27_raw = value;
                        OnPropertyChanged(nameof(Unk_27));
                    }
                }

                protected uint Unk_28_raw;
                public const string Unk_28_displayName = "Unk 28";
                public const int Unk_28_sortIndex = 1450;
                [SortOrder(Unk_28_sortIndex)]
                [DisplayName(Unk_28_displayName)]
                public virtual uint Unk_28 {
                    get => Unk_28_raw;
                    set {
                        if (Unk_28_raw == value) return;
                        Unk_28_raw = value;
                        OnPropertyChanged(nameof(Unk_28));
                    }
                }

                protected uint Unk_29_raw;
                public const string Unk_29_displayName = "Unk 29";
                public const int Unk_29_sortIndex = 1500;
                [SortOrder(Unk_29_sortIndex)]
                [DisplayName(Unk_29_displayName)]
                public virtual uint Unk_29 {
                    get => Unk_29_raw;
                    set {
                        if (Unk_29_raw == value) return;
                        Unk_29_raw = value;
                        OnPropertyChanged(nameof(Unk_29));
                    }
                }

                protected float Unk_30_raw;
                public const string Unk_30_displayName = "Unk 30";
                public const int Unk_30_sortIndex = 1550;
                [SortOrder(Unk_30_sortIndex)]
                [DisplayName(Unk_30_displayName)]
                public virtual float Unk_30 {
                    get => Unk_30_raw;
                    set {
                        if (Unk_30_raw == value) return;
                        Unk_30_raw = value;
                        OnPropertyChanged(nameof(Unk_30));
                    }
                }

                protected uint Unk_31_raw;
                public const string Unk_31_displayName = "Unk 31";
                public const int Unk_31_sortIndex = 1600;
                [SortOrder(Unk_31_sortIndex)]
                [DisplayName(Unk_31_displayName)]
                public virtual uint Unk_31 {
                    get => Unk_31_raw;
                    set {
                        if (Unk_31_raw == value) return;
                        Unk_31_raw = value;
                        OnPropertyChanged(nameof(Unk_31));
                    }
                }

                protected uint Unk_32_raw;
                public const string Unk_32_displayName = "Unk 32";
                public const int Unk_32_sortIndex = 1650;
                [SortOrder(Unk_32_sortIndex)]
                [DisplayName(Unk_32_displayName)]
                public virtual uint Unk_32 {
                    get => Unk_32_raw;
                    set {
                        if (Unk_32_raw == value) return;
                        Unk_32_raw = value;
                        OnPropertyChanged(nameof(Unk_32));
                    }
                }

                protected byte Unk_33_raw;
                public const string Unk_33_displayName = "Unk 33";
                public const int Unk_33_sortIndex = 1700;
                [SortOrder(Unk_33_sortIndex)]
                [DisplayName(Unk_33_displayName)]
                public virtual byte Unk_33 {
                    get => Unk_33_raw;
                    set {
                        if (Unk_33_raw == value) return;
                        Unk_33_raw = value;
                        OnPropertyChanged(nameof(Unk_33));
                    }
                }

                protected uint Unk_34_raw;
                public const string Unk_34_displayName = "Unk 34";
                public const int Unk_34_sortIndex = 1750;
                [SortOrder(Unk_34_sortIndex)]
                [DisplayName(Unk_34_displayName)]
                public virtual uint Unk_34 {
                    get => Unk_34_raw;
                    set {
                        if (Unk_34_raw == value) return;
                        Unk_34_raw = value;
                        OnPropertyChanged(nameof(Unk_34));
                    }
                }

                protected float Unk_35_raw;
                public const string Unk_35_displayName = "Unk 35";
                public const int Unk_35_sortIndex = 1800;
                [SortOrder(Unk_35_sortIndex)]
                [DisplayName(Unk_35_displayName)]
                public virtual float Unk_35 {
                    get => Unk_35_raw;
                    set {
                        if (Unk_35_raw == value) return;
                        Unk_35_raw = value;
                        OnPropertyChanged(nameof(Unk_35));
                    }
                }

                protected float Unk_36_raw;
                public const string Unk_36_displayName = "Unk 36";
                public const int Unk_36_sortIndex = 1850;
                [SortOrder(Unk_36_sortIndex)]
                [DisplayName(Unk_36_displayName)]
                public virtual float Unk_36 {
                    get => Unk_36_raw;
                    set {
                        if (Unk_36_raw == value) return;
                        Unk_36_raw = value;
                        OnPropertyChanged(nameof(Unk_36));
                    }
                }

                protected uint Unk_37_raw;
                public const string Unk_37_displayName = "Unk 37";
                public const int Unk_37_sortIndex = 1900;
                [SortOrder(Unk_37_sortIndex)]
                [DisplayName(Unk_37_displayName)]
                public virtual uint Unk_37 {
                    get => Unk_37_raw;
                    set {
                        if (Unk_37_raw == value) return;
                        Unk_37_raw = value;
                        OnPropertyChanged(nameof(Unk_37));
                    }
                }

                protected uint Unk_38_raw;
                public const string Unk_38_displayName = "Unk 38";
                public const int Unk_38_sortIndex = 1950;
                [SortOrder(Unk_38_sortIndex)]
                [DisplayName(Unk_38_displayName)]
                public virtual uint Unk_38 {
                    get => Unk_38_raw;
                    set {
                        if (Unk_38_raw == value) return;
                        Unk_38_raw = value;
                        OnPropertyChanged(nameof(Unk_38));
                    }
                }

                protected uint Unk_39_raw;
                public const string Unk_39_displayName = "Unk 39";
                public const int Unk_39_sortIndex = 2000;
                [SortOrder(Unk_39_sortIndex)]
                [DisplayName(Unk_39_displayName)]
                public virtual uint Unk_39 {
                    get => Unk_39_raw;
                    set {
                        if (Unk_39_raw == value) return;
                        Unk_39_raw = value;
                        OnPropertyChanged(nameof(Unk_39));
                    }
                }

                protected uint Unk_40_raw;
                public const string Unk_40_displayName = "Unk 40";
                public const int Unk_40_sortIndex = 2050;
                [SortOrder(Unk_40_sortIndex)]
                [DisplayName(Unk_40_displayName)]
                public virtual uint Unk_40 {
                    get => Unk_40_raw;
                    set {
                        if (Unk_40_raw == value) return;
                        Unk_40_raw = value;
                        OnPropertyChanged(nameof(Unk_40));
                    }
                }

                protected uint Unk_41_raw;
                public const string Unk_41_displayName = "Unk 41";
                public const int Unk_41_sortIndex = 2100;
                [SortOrder(Unk_41_sortIndex)]
                [DisplayName(Unk_41_displayName)]
                public virtual uint Unk_41 {
                    get => Unk_41_raw;
                    set {
                        if (Unk_41_raw == value) return;
                        Unk_41_raw = value;
                        OnPropertyChanged(nameof(Unk_41));
                    }
                }

                protected uint Unk_42_raw;
                public const string Unk_42_displayName = "Unk 42";
                public const int Unk_42_sortIndex = 2150;
                [SortOrder(Unk_42_sortIndex)]
                [DisplayName(Unk_42_displayName)]
                public virtual uint Unk_42 {
                    get => Unk_42_raw;
                    set {
                        if (Unk_42_raw == value) return;
                        Unk_42_raw = value;
                        OnPropertyChanged(nameof(Unk_42));
                    }
                }

                protected uint Unk_43_raw;
                public const string Unk_43_displayName = "Unk 43";
                public const int Unk_43_sortIndex = 2200;
                [SortOrder(Unk_43_sortIndex)]
                [DisplayName(Unk_43_displayName)]
                public virtual uint Unk_43 {
                    get => Unk_43_raw;
                    set {
                        if (Unk_43_raw == value) return;
                        Unk_43_raw = value;
                        OnPropertyChanged(nameof(Unk_43));
                    }
                }

                protected uint Unk_44_raw;
                public const string Unk_44_displayName = "Unk 44";
                public const int Unk_44_sortIndex = 2250;
                [SortOrder(Unk_44_sortIndex)]
                [DisplayName(Unk_44_displayName)]
                public virtual uint Unk_44 {
                    get => Unk_44_raw;
                    set {
                        if (Unk_44_raw == value) return;
                        Unk_44_raw = value;
                        OnPropertyChanged(nameof(Unk_44));
                    }
                }

                protected ushort Unk_45_raw;
                public const string Unk_45_displayName = "Unk 45";
                public const int Unk_45_sortIndex = 2300;
                [SortOrder(Unk_45_sortIndex)]
                [DisplayName(Unk_45_displayName)]
                public virtual ushort Unk_45 {
                    get => Unk_45_raw;
                    set {
                        if (Unk_45_raw == value) return;
                        Unk_45_raw = value;
                        OnPropertyChanged(nameof(Unk_45));
                    }
                }

                public const int lastSortIndex = 2350;

                public static ObservableCollection<Atk0> LoadData(BinaryReader reader, Moves parent) {
                    var list = new ObservableCollection<Atk0>();
                    var count = (ulong) parent.Move_Count;
                    for (ulong i = 0; i < count; i++) {
                        list.Add(LoadData(reader, i, parent));
                    }
                    return list;
                }

                public static Atk0 LoadData(BinaryReader reader, ulong i, Moves parent) {
                    var data = new Atk0();
                    data.Index = i;
                    data.Index_raw = reader.ReadUInt32();
                    data.Unk_1_raw = reader.ReadUInt32();
                    data.Unk_2_raw = reader.ReadUInt32();
                    data.Unk_3_raw = reader.ReadSingle();
                    data.Unk_4_raw = reader.ReadSingle();
                    data.Unk_5_raw = reader.ReadSingle();
                    data.Unk_6_raw = reader.ReadUInt32();
                    data.Unk_7_raw = reader.ReadUInt32();
                    data.Unk_8_raw = reader.ReadUInt32();
                    data.Unk_9_raw = reader.ReadUInt32();
                    data.Unk_10_raw = reader.ReadUInt32();
                    data.Unk_11_raw = reader.ReadUInt32();
                    data.Unk_12_raw = reader.ReadUInt32();
                    data.Unk_13_raw = reader.ReadUInt32();
                    data.Unk_14_raw = reader.ReadUInt32();
                    data.Unk_15_raw = reader.ReadUInt32();
                    data.Unk_16_raw = reader.ReadUInt32();
                    data.Unk_17_raw = reader.ReadUInt32();
                    data.Unk_18_raw = reader.ReadUInt32();
                    data.Unk_19_raw = reader.ReadUInt32();
                    data.Unk_20_raw = reader.ReadUInt32();
                    data.Unk_21_raw = reader.ReadUInt32();
                    data.Unk_22_raw = reader.ReadUInt32();
                    data.Unk_23_raw = reader.ReadSingle();
                    data.Unk_24_raw = reader.ReadSingle();
                    data.Unk_25_raw = reader.ReadSingle();
                    data.Unk_26_raw = reader.ReadUInt32();
                    data.Unk_27_raw = reader.ReadUInt32();
                    data.Unk_28_raw = reader.ReadUInt32();
                    data.Unk_29_raw = reader.ReadUInt32();
                    data.Unk_30_raw = reader.ReadSingle();
                    data.Unk_31_raw = reader.ReadUInt32();
                    data.Unk_32_raw = reader.ReadUInt32();
                    data.Unk_33_raw = reader.ReadByte();
                    data.Unk_34_raw = reader.ReadUInt32();
                    data.Unk_35_raw = reader.ReadSingle();
                    data.Unk_36_raw = reader.ReadSingle();
                    data.Unk_37_raw = reader.ReadUInt32();
                    data.Unk_38_raw = reader.ReadUInt32();
                    data.Unk_39_raw = reader.ReadUInt32();
                    data.Unk_40_raw = reader.ReadUInt32();
                    data.Unk_41_raw = reader.ReadUInt32();
                    data.Unk_42_raw = reader.ReadUInt32();
                    data.Unk_43_raw = reader.ReadUInt32();
                    data.Unk_44_raw = reader.ReadUInt32();
                    data.Unk_45_raw = reader.ReadUInt16();
                    return data;
                }

                public void WriteData(BinaryWriter writer, Moves parent) {
                    writer.Write(Index_raw);
                    writer.Write(Unk_1_raw);
                    writer.Write(Unk_2_raw);
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
                }
            }

            public const string Atk0_displayName = "Atk0";
            public const int Atk0_sortIndex = 300;
            [SortOrder(Atk0_sortIndex)]
            [DisplayName(Atk0_displayName)]
            protected virtual ObservableCollection<Atk0> Atk0_raw { get; set; }

            public partial class Atk1 : MhwStructItem {
                public const ulong FixedSizeCount = 0;
                public const string GridName = "Atk1";

                protected uint Index_raw;
                public const string Index_displayName = "Index";
                public const int Index_sortIndex = 50;
                [SortOrder(Index_sortIndex)]
                [DisplayName(Index_displayName)]
                public override ulong Index {
                    get => (ulong) Index_raw;
                    set {
                        if ((ulong) Index_raw == value) return;
                        Index_raw = (uint) value;
                        OnPropertyChanged(nameof(Index));
                    }
                }

                protected uint Attack_Type_raw;
                public const string Attack_Type_displayName = "Attack Type";
                public const int Attack_Type_sortIndex = 100;
                [SortOrder(Attack_Type_sortIndex)]
                [DisplayName(Attack_Type_displayName)]
                public virtual uint Attack_Type {
                    get => Attack_Type_raw;
                    set {
                        if (Attack_Type_raw == value) return;
                        Attack_Type_raw = value;
                        OnPropertyChanged(nameof(Attack_Type));
                    }
                }

                protected float Motion_Value_raw;
                public const string Motion_Value_displayName = "Motion Value";
                public const int Motion_Value_sortIndex = 150;
                [SortOrder(Motion_Value_sortIndex)]
                [DisplayName(Motion_Value_displayName)]
                public virtual float Motion_Value {
                    get => Motion_Value_raw;
                    set {
                        if (Motion_Value_raw == value) return;
                        Motion_Value_raw = value;
                        OnPropertyChanged(nameof(Motion_Value));
                    }
                }

                protected float Fixed_Damage_raw;
                public const string Fixed_Damage_displayName = "Fixed Damage";
                public const int Fixed_Damage_sortIndex = 200;
                [SortOrder(Fixed_Damage_sortIndex)]
                [DisplayName(Fixed_Damage_displayName)]
                public virtual float Fixed_Damage {
                    get => Fixed_Damage_raw;
                    set {
                        if (Fixed_Damage_raw == value) return;
                        Fixed_Damage_raw = value;
                        OnPropertyChanged(nameof(Fixed_Damage));
                    }
                }

                protected float Part_Modifier_raw;
                public const string Part_Modifier_displayName = "Part Modifier";
                public const int Part_Modifier_sortIndex = 250;
                [SortOrder(Part_Modifier_sortIndex)]
                [DisplayName(Part_Modifier_displayName)]
                public virtual float Part_Modifier {
                    get => Part_Modifier_raw;
                    set {
                        if (Part_Modifier_raw == value) return;
                        Part_Modifier_raw = value;
                        OnPropertyChanged(nameof(Part_Modifier));
                    }
                }

                protected float Elemental_Modifier_raw;
                public const string Elemental_Modifier_displayName = "Elemental Modifier";
                public const int Elemental_Modifier_sortIndex = 300;
                [SortOrder(Elemental_Modifier_sortIndex)]
                [DisplayName(Elemental_Modifier_displayName)]
                public virtual float Elemental_Modifier {
                    get => Elemental_Modifier_raw;
                    set {
                        if (Elemental_Modifier_raw == value) return;
                        Elemental_Modifier_raw = value;
                        OnPropertyChanged(nameof(Elemental_Modifier));
                    }
                }

                protected float Status_Modifier_raw;
                public const string Status_Modifier_displayName = "Status Modifier";
                public const int Status_Modifier_sortIndex = 350;
                [SortOrder(Status_Modifier_sortIndex)]
                [DisplayName(Status_Modifier_displayName)]
                public virtual float Status_Modifier {
                    get => Status_Modifier_raw;
                    set {
                        if (Status_Modifier_raw == value) return;
                        Status_Modifier_raw = value;
                        OnPropertyChanged(nameof(Status_Modifier));
                    }
                }

                protected float Stun_raw;
                public const string Stun_displayName = "Stun";
                public const int Stun_sortIndex = 400;
                [SortOrder(Stun_sortIndex)]
                [DisplayName(Stun_displayName)]
                public virtual float Stun {
                    get => Stun_raw;
                    set {
                        if (Stun_raw == value) return;
                        Stun_raw = value;
                        OnPropertyChanged(nameof(Stun));
                    }
                }

                protected float Exhaust_raw;
                public const string Exhaust_displayName = "Exhaust";
                public const int Exhaust_sortIndex = 450;
                [SortOrder(Exhaust_sortIndex)]
                [DisplayName(Exhaust_displayName)]
                public virtual float Exhaust {
                    get => Exhaust_raw;
                    set {
                        if (Exhaust_raw == value) return;
                        Exhaust_raw = value;
                        OnPropertyChanged(nameof(Exhaust));
                    }
                }

                protected float Mount_raw;
                public const string Mount_displayName = "Mount";
                public const int Mount_sortIndex = 500;
                [SortOrder(Mount_sortIndex)]
                [DisplayName(Mount_displayName)]
                public virtual float Mount {
                    get => Mount_raw;
                    set {
                        if (Mount_raw == value) return;
                        Mount_raw = value;
                        OnPropertyChanged(nameof(Mount));
                    }
                }

                protected float Unk_1_raw;
                public const string Unk_1_displayName = "Unk 1";
                public const int Unk_1_sortIndex = 550;
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
                public const int Unk_2_sortIndex = 600;
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
                public const int Unk_3_sortIndex = 650;
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

                protected float Soften_Value_raw;
                public const string Soften_Value_displayName = "Soften Value";
                public const int Soften_Value_sortIndex = 700;
                [SortOrder(Soften_Value_sortIndex)]
                [DisplayName(Soften_Value_displayName)]
                public virtual float Soften_Value {
                    get => Soften_Value_raw;
                    set {
                        if (Soften_Value_raw == value) return;
                        Soften_Value_raw = value;
                        OnPropertyChanged(nameof(Soften_Value));
                    }
                }

                protected float Unk_4_raw;
                public const string Unk_4_displayName = "Unk 4";
                public const int Unk_4_sortIndex = 750;
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
                public const int Unk_5_sortIndex = 800;
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

                protected float Unk_6_raw;
                public const string Unk_6_displayName = "Unk 6";
                public const int Unk_6_sortIndex = 850;
                [SortOrder(Unk_6_sortIndex)]
                [DisplayName(Unk_6_displayName)]
                public virtual float Unk_6 {
                    get => Unk_6_raw;
                    set {
                        if (Unk_6_raw == value) return;
                        Unk_6_raw = value;
                        OnPropertyChanged(nameof(Unk_6));
                    }
                }

                protected float Unk_7_raw;
                public const string Unk_7_displayName = "Unk 7";
                public const int Unk_7_sortIndex = 900;
                [SortOrder(Unk_7_sortIndex)]
                [DisplayName(Unk_7_displayName)]
                public virtual float Unk_7 {
                    get => Unk_7_raw;
                    set {
                        if (Unk_7_raw == value) return;
                        Unk_7_raw = value;
                        OnPropertyChanged(nameof(Unk_7));
                    }
                }

                protected float Unk_8_raw;
                public const string Unk_8_displayName = "Unk 8";
                public const int Unk_8_sortIndex = 950;
                [SortOrder(Unk_8_sortIndex)]
                [DisplayName(Unk_8_displayName)]
                public virtual float Unk_8 {
                    get => Unk_8_raw;
                    set {
                        if (Unk_8_raw == value) return;
                        Unk_8_raw = value;
                        OnPropertyChanged(nameof(Unk_8));
                    }
                }

                protected float Unk_9_raw;
                public const string Unk_9_displayName = "Unk 9";
                public const int Unk_9_sortIndex = 1000;
                [SortOrder(Unk_9_sortIndex)]
                [DisplayName(Unk_9_displayName)]
                public virtual float Unk_9 {
                    get => Unk_9_raw;
                    set {
                        if (Unk_9_raw == value) return;
                        Unk_9_raw = value;
                        OnPropertyChanged(nameof(Unk_9));
                    }
                }

                protected float Unk_10_raw;
                public const string Unk_10_displayName = "Unk 10";
                public const int Unk_10_sortIndex = 1050;
                [SortOrder(Unk_10_sortIndex)]
                [DisplayName(Unk_10_displayName)]
                public virtual float Unk_10 {
                    get => Unk_10_raw;
                    set {
                        if (Unk_10_raw == value) return;
                        Unk_10_raw = value;
                        OnPropertyChanged(nameof(Unk_10));
                    }
                }

                protected float Unk_11_raw;
                public const string Unk_11_displayName = "Unk 11";
                public const int Unk_11_sortIndex = 1100;
                [SortOrder(Unk_11_sortIndex)]
                [DisplayName(Unk_11_displayName)]
                public virtual float Unk_11 {
                    get => Unk_11_raw;
                    set {
                        if (Unk_11_raw == value) return;
                        Unk_11_raw = value;
                        OnPropertyChanged(nameof(Unk_11));
                    }
                }

                protected uint Flinch_Value_raw;
                public const string Flinch_Value_displayName = "Flinch Value";
                public const int Flinch_Value_sortIndex = 1150;
                [SortOrder(Flinch_Value_sortIndex)]
                [DisplayName(Flinch_Value_displayName)]
                public virtual uint Flinch_Value {
                    get => Flinch_Value_raw;
                    set {
                        if (Flinch_Value_raw == value) return;
                        Flinch_Value_raw = value;
                        OnPropertyChanged(nameof(Flinch_Value));
                    }
                }

                protected uint Unk_12_raw;
                public const string Unk_12_displayName = "Unk 12";
                public const int Unk_12_sortIndex = 1200;
                [SortOrder(Unk_12_sortIndex)]
                [DisplayName(Unk_12_displayName)]
                public virtual uint Unk_12 {
                    get => Unk_12_raw;
                    set {
                        if (Unk_12_raw == value) return;
                        Unk_12_raw = value;
                        OnPropertyChanged(nameof(Unk_12));
                    }
                }

                protected byte Mind_s_Eye_raw;
                public const string Mind_s_Eye_displayName = "Mind's Eye";
                public const int Mind_s_Eye_sortIndex = 1250;
                [SortOrder(Mind_s_Eye_sortIndex)]
                [DisplayName(Mind_s_Eye_displayName)]
                public virtual byte Mind_s_Eye {
                    get => Mind_s_Eye_raw;
                    set {
                        if (Mind_s_Eye_raw == value) return;
                        Mind_s_Eye_raw = value;
                        OnPropertyChanged(nameof(Mind_s_Eye));
                    }
                }

                protected float Unk_13_raw;
                public const string Unk_13_displayName = "Unk 13";
                public const int Unk_13_sortIndex = 1300;
                [SortOrder(Unk_13_sortIndex)]
                [DisplayName(Unk_13_displayName)]
                public virtual float Unk_13 {
                    get => Unk_13_raw;
                    set {
                        if (Unk_13_raw == value) return;
                        Unk_13_raw = value;
                        OnPropertyChanged(nameof(Unk_13));
                    }
                }

                protected float Unk_14_raw;
                public const string Unk_14_displayName = "Unk 14";
                public const int Unk_14_sortIndex = 1350;
                [SortOrder(Unk_14_sortIndex)]
                [DisplayName(Unk_14_displayName)]
                public virtual float Unk_14 {
                    get => Unk_14_raw;
                    set {
                        if (Unk_14_raw == value) return;
                        Unk_14_raw = value;
                        OnPropertyChanged(nameof(Unk_14));
                    }
                }

                protected byte Unk_15_raw;
                public const string Unk_15_displayName = "Unk 15";
                public const int Unk_15_sortIndex = 1400;
                [SortOrder(Unk_15_sortIndex)]
                [DisplayName(Unk_15_displayName)]
                public virtual byte Unk_15 {
                    get => Unk_15_raw;
                    set {
                        if (Unk_15_raw == value) return;
                        Unk_15_raw = value;
                        OnPropertyChanged(nameof(Unk_15));
                    }
                }

                protected float Hit_Lag_Speed_Multiplier_a__raw;
                public const string Hit_Lag_Speed_Multiplier_a__displayName = "Hit Lag Speed Multiplier (a)";
                public const int Hit_Lag_Speed_Multiplier_a__sortIndex = 1450;
                [SortOrder(Hit_Lag_Speed_Multiplier_a__sortIndex)]
                [DisplayName(Hit_Lag_Speed_Multiplier_a__displayName)]
                public virtual float Hit_Lag_Speed_Multiplier_a_ {
                    get => Hit_Lag_Speed_Multiplier_a__raw;
                    set {
                        if (Hit_Lag_Speed_Multiplier_a__raw == value) return;
                        Hit_Lag_Speed_Multiplier_a__raw = value;
                        OnPropertyChanged(nameof(Hit_Lag_Speed_Multiplier_a_));
                    }
                }

                protected float Unk_16_raw;
                public const string Unk_16_displayName = "Unk 16";
                public const int Unk_16_sortIndex = 1500;
                [SortOrder(Unk_16_sortIndex)]
                [DisplayName(Unk_16_displayName)]
                public virtual float Unk_16 {
                    get => Unk_16_raw;
                    set {
                        if (Unk_16_raw == value) return;
                        Unk_16_raw = value;
                        OnPropertyChanged(nameof(Unk_16));
                    }
                }

                protected float Hit_Lag_a__raw;
                public const string Hit_Lag_a__displayName = "Hit Lag (a)";
                public const int Hit_Lag_a__sortIndex = 1550;
                [SortOrder(Hit_Lag_a__sortIndex)]
                [DisplayName(Hit_Lag_a__displayName)]
                public virtual float Hit_Lag_a_ {
                    get => Hit_Lag_a__raw;
                    set {
                        if (Hit_Lag_a__raw == value) return;
                        Hit_Lag_a__raw = value;
                        OnPropertyChanged(nameof(Hit_Lag_a_));
                    }
                }

                protected float Unk_17_raw;
                public const string Unk_17_displayName = "Unk 17";
                public const int Unk_17_sortIndex = 1600;
                [SortOrder(Unk_17_sortIndex)]
                [DisplayName(Unk_17_displayName)]
                public virtual float Unk_17 {
                    get => Unk_17_raw;
                    set {
                        if (Unk_17_raw == value) return;
                        Unk_17_raw = value;
                        OnPropertyChanged(nameof(Unk_17));
                    }
                }

                protected float Unk_18_raw;
                public const string Unk_18_displayName = "Unk 18";
                public const int Unk_18_sortIndex = 1650;
                [SortOrder(Unk_18_sortIndex)]
                [DisplayName(Unk_18_displayName)]
                public virtual float Unk_18 {
                    get => Unk_18_raw;
                    set {
                        if (Unk_18_raw == value) return;
                        Unk_18_raw = value;
                        OnPropertyChanged(nameof(Unk_18));
                    }
                }

                protected float Hit_Lag_Speed_Multiplier_b__raw;
                public const string Hit_Lag_Speed_Multiplier_b__displayName = "Hit Lag Speed Multiplier (b)";
                public const int Hit_Lag_Speed_Multiplier_b__sortIndex = 1700;
                [SortOrder(Hit_Lag_Speed_Multiplier_b__sortIndex)]
                [DisplayName(Hit_Lag_Speed_Multiplier_b__displayName)]
                public virtual float Hit_Lag_Speed_Multiplier_b_ {
                    get => Hit_Lag_Speed_Multiplier_b__raw;
                    set {
                        if (Hit_Lag_Speed_Multiplier_b__raw == value) return;
                        Hit_Lag_Speed_Multiplier_b__raw = value;
                        OnPropertyChanged(nameof(Hit_Lag_Speed_Multiplier_b_));
                    }
                }

                protected float Unk_19_raw;
                public const string Unk_19_displayName = "Unk 19";
                public const int Unk_19_sortIndex = 1750;
                [SortOrder(Unk_19_sortIndex)]
                [DisplayName(Unk_19_displayName)]
                public virtual float Unk_19 {
                    get => Unk_19_raw;
                    set {
                        if (Unk_19_raw == value) return;
                        Unk_19_raw = value;
                        OnPropertyChanged(nameof(Unk_19));
                    }
                }

                protected float Hit_Lag_b__raw;
                public const string Hit_Lag_b__displayName = "Hit Lag (b)";
                public const int Hit_Lag_b__sortIndex = 1800;
                [SortOrder(Hit_Lag_b__sortIndex)]
                [DisplayName(Hit_Lag_b__displayName)]
                public virtual float Hit_Lag_b_ {
                    get => Hit_Lag_b__raw;
                    set {
                        if (Hit_Lag_b__raw == value) return;
                        Hit_Lag_b__raw = value;
                        OnPropertyChanged(nameof(Hit_Lag_b_));
                    }
                }

                protected float Unk_20_raw;
                public const string Unk_20_displayName = "Unk 20";
                public const int Unk_20_sortIndex = 1850;
                [SortOrder(Unk_20_sortIndex)]
                [DisplayName(Unk_20_displayName)]
                public virtual float Unk_20 {
                    get => Unk_20_raw;
                    set {
                        if (Unk_20_raw == value) return;
                        Unk_20_raw = value;
                        OnPropertyChanged(nameof(Unk_20));
                    }
                }

                protected float Unk_21_raw;
                public const string Unk_21_displayName = "Unk 21";
                public const int Unk_21_sortIndex = 1900;
                [SortOrder(Unk_21_sortIndex)]
                [DisplayName(Unk_21_displayName)]
                public virtual float Unk_21 {
                    get => Unk_21_raw;
                    set {
                        if (Unk_21_raw == value) return;
                        Unk_21_raw = value;
                        OnPropertyChanged(nameof(Unk_21));
                    }
                }

                protected uint Unk_22_raw;
                public const string Unk_22_displayName = "Unk 22";
                public const int Unk_22_sortIndex = 1950;
                [SortOrder(Unk_22_sortIndex)]
                [DisplayName(Unk_22_displayName)]
                public virtual uint Unk_22 {
                    get => Unk_22_raw;
                    set {
                        if (Unk_22_raw == value) return;
                        Unk_22_raw = value;
                        OnPropertyChanged(nameof(Unk_22));
                    }
                }

                protected sbyte Unk_23_raw;
                public const string Unk_23_displayName = "Unk 23";
                public const int Unk_23_sortIndex = 2000;
                [SortOrder(Unk_23_sortIndex)]
                [DisplayName(Unk_23_displayName)]
                public virtual sbyte Unk_23 {
                    get => Unk_23_raw;
                    set {
                        if (Unk_23_raw == value) return;
                        Unk_23_raw = value;
                        OnPropertyChanged(nameof(Unk_23));
                    }
                }

                protected byte Unk_24_raw;
                public const string Unk_24_displayName = "Unk 24";
                public const int Unk_24_sortIndex = 2050;
                [SortOrder(Unk_24_sortIndex)]
                [DisplayName(Unk_24_displayName)]
                public virtual byte Unk_24 {
                    get => Unk_24_raw;
                    set {
                        if (Unk_24_raw == value) return;
                        Unk_24_raw = value;
                        OnPropertyChanged(nameof(Unk_24));
                    }
                }

                protected uint Unk_25_raw;
                public const string Unk_25_displayName = "Unk 25";
                public const int Unk_25_sortIndex = 2100;
                [SortOrder(Unk_25_sortIndex)]
                [DisplayName(Unk_25_displayName)]
                public virtual uint Unk_25 {
                    get => Unk_25_raw;
                    set {
                        if (Unk_25_raw == value) return;
                        Unk_25_raw = value;
                        OnPropertyChanged(nameof(Unk_25));
                    }
                }

                protected float Unk_26_raw;
                public const string Unk_26_displayName = "Unk 26";
                public const int Unk_26_sortIndex = 2150;
                [SortOrder(Unk_26_sortIndex)]
                [DisplayName(Unk_26_displayName)]
                public virtual float Unk_26 {
                    get => Unk_26_raw;
                    set {
                        if (Unk_26_raw == value) return;
                        Unk_26_raw = value;
                        OnPropertyChanged(nameof(Unk_26));
                    }
                }

                protected float Unk_27_raw;
                public const string Unk_27_displayName = "Unk 27";
                public const int Unk_27_sortIndex = 2200;
                [SortOrder(Unk_27_sortIndex)]
                [DisplayName(Unk_27_displayName)]
                public virtual float Unk_27 {
                    get => Unk_27_raw;
                    set {
                        if (Unk_27_raw == value) return;
                        Unk_27_raw = value;
                        OnPropertyChanged(nameof(Unk_27));
                    }
                }

                protected float Unk_28_raw;
                public const string Unk_28_displayName = "Unk 28";
                public const int Unk_28_sortIndex = 2250;
                [SortOrder(Unk_28_sortIndex)]
                [DisplayName(Unk_28_displayName)]
                public virtual float Unk_28 {
                    get => Unk_28_raw;
                    set {
                        if (Unk_28_raw == value) return;
                        Unk_28_raw = value;
                        OnPropertyChanged(nameof(Unk_28));
                    }
                }

                protected byte Lingering_Hurtbox_raw;
                public const string Lingering_Hurtbox_displayName = "Lingering Hurtbox";
                public const int Lingering_Hurtbox_sortIndex = 2300;
                [SortOrder(Lingering_Hurtbox_sortIndex)]
                [DisplayName(Lingering_Hurtbox_displayName)]
                public virtual byte Lingering_Hurtbox {
                    get => Lingering_Hurtbox_raw;
                    set {
                        if (Lingering_Hurtbox_raw == value) return;
                        Lingering_Hurtbox_raw = value;
                        OnPropertyChanged(nameof(Lingering_Hurtbox));
                    }
                }

                protected float Frame_Delay_raw;
                public const string Frame_Delay_displayName = "Frame Delay";
                public const int Frame_Delay_sortIndex = 2350;
                [SortOrder(Frame_Delay_sortIndex)]
                [DisplayName(Frame_Delay_displayName)]
                public virtual float Frame_Delay {
                    get => Frame_Delay_raw;
                    set {
                        if (Frame_Delay_raw == value) return;
                        Frame_Delay_raw = value;
                        OnPropertyChanged(nameof(Frame_Delay));
                    }
                }

                protected uint Unk_29_raw;
                public const string Unk_29_displayName = "Unk 29";
                public const int Unk_29_sortIndex = 2400;
                [SortOrder(Unk_29_sortIndex)]
                [DisplayName(Unk_29_displayName)]
                public virtual uint Unk_29 {
                    get => Unk_29_raw;
                    set {
                        if (Unk_29_raw == value) return;
                        Unk_29_raw = value;
                        OnPropertyChanged(nameof(Unk_29));
                    }
                }

                protected ushort Unk_30_raw;
                public const string Unk_30_displayName = "Unk 30";
                public const int Unk_30_sortIndex = 2450;
                [SortOrder(Unk_30_sortIndex)]
                [DisplayName(Unk_30_displayName)]
                public virtual ushort Unk_30 {
                    get => Unk_30_raw;
                    set {
                        if (Unk_30_raw == value) return;
                        Unk_30_raw = value;
                        OnPropertyChanged(nameof(Unk_30));
                    }
                }

                protected float Energy_Gen_raw;
                public const string Energy_Gen_displayName = "Energy Gen";
                public const int Energy_Gen_sortIndex = 2500;
                [SortOrder(Energy_Gen_sortIndex)]
                [DisplayName(Energy_Gen_displayName)]
                public virtual float Energy_Gen {
                    get => Energy_Gen_raw;
                    set {
                        if (Energy_Gen_raw == value) return;
                        Energy_Gen_raw = value;
                        OnPropertyChanged(nameof(Energy_Gen));
                    }
                }

                protected float Conditional_Motion_value_change_replace_raw;
                public const string Conditional_Motion_value_change_replace_displayName = "Conditional Motion value change/replace";
                public const int Conditional_Motion_value_change_replace_sortIndex = 2550;
                [SortOrder(Conditional_Motion_value_change_replace_sortIndex)]
                [DisplayName(Conditional_Motion_value_change_replace_displayName)]
                public virtual float Conditional_Motion_value_change_replace {
                    get => Conditional_Motion_value_change_replace_raw;
                    set {
                        if (Conditional_Motion_value_change_replace_raw == value) return;
                        Conditional_Motion_value_change_replace_raw = value;
                        OnPropertyChanged(nameof(Conditional_Motion_value_change_replace));
                    }
                }

                protected float Conditional_element_modifier_change_replace_raw;
                public const string Conditional_element_modifier_change_replace_displayName = "Conditional element modifier change/replace";
                public const int Conditional_element_modifier_change_replace_sortIndex = 2600;
                [SortOrder(Conditional_element_modifier_change_replace_sortIndex)]
                [DisplayName(Conditional_element_modifier_change_replace_displayName)]
                public virtual float Conditional_element_modifier_change_replace {
                    get => Conditional_element_modifier_change_replace_raw;
                    set {
                        if (Conditional_element_modifier_change_replace_raw == value) return;
                        Conditional_element_modifier_change_replace_raw = value;
                        OnPropertyChanged(nameof(Conditional_element_modifier_change_replace));
                    }
                }

                protected uint Unk_31_raw;
                public const string Unk_31_displayName = "Unk 31";
                public const int Unk_31_sortIndex = 2650;
                [SortOrder(Unk_31_sortIndex)]
                [DisplayName(Unk_31_displayName)]
                public virtual uint Unk_31 {
                    get => Unk_31_raw;
                    set {
                        if (Unk_31_raw == value) return;
                        Unk_31_raw = value;
                        OnPropertyChanged(nameof(Unk_31));
                    }
                }

                protected uint Unk_32_raw;
                public const string Unk_32_displayName = "Unk 32";
                public const int Unk_32_sortIndex = 2700;
                [SortOrder(Unk_32_sortIndex)]
                [DisplayName(Unk_32_displayName)]
                public virtual uint Unk_32 {
                    get => Unk_32_raw;
                    set {
                        if (Unk_32_raw == value) return;
                        Unk_32_raw = value;
                        OnPropertyChanged(nameof(Unk_32));
                    }
                }

                protected uint Unk_33_raw;
                public const string Unk_33_displayName = "Unk 33";
                public const int Unk_33_sortIndex = 2750;
                [SortOrder(Unk_33_sortIndex)]
                [DisplayName(Unk_33_displayName)]
                public virtual uint Unk_33 {
                    get => Unk_33_raw;
                    set {
                        if (Unk_33_raw == value) return;
                        Unk_33_raw = value;
                        OnPropertyChanged(nameof(Unk_33));
                    }
                }

                protected uint Unk_34_raw;
                public const string Unk_34_displayName = "Unk 34";
                public const int Unk_34_sortIndex = 2800;
                [SortOrder(Unk_34_sortIndex)]
                [DisplayName(Unk_34_displayName)]
                public virtual uint Unk_34 {
                    get => Unk_34_raw;
                    set {
                        if (Unk_34_raw == value) return;
                        Unk_34_raw = value;
                        OnPropertyChanged(nameof(Unk_34));
                    }
                }

                protected uint Unk_35_raw;
                public const string Unk_35_displayName = "Unk 35";
                public const int Unk_35_sortIndex = 2850;
                [SortOrder(Unk_35_sortIndex)]
                [DisplayName(Unk_35_displayName)]
                public virtual uint Unk_35 {
                    get => Unk_35_raw;
                    set {
                        if (Unk_35_raw == value) return;
                        Unk_35_raw = value;
                        OnPropertyChanged(nameof(Unk_35));
                    }
                }

                protected uint Unk_36_raw;
                public const string Unk_36_displayName = "Unk 36";
                public const int Unk_36_sortIndex = 2900;
                [SortOrder(Unk_36_sortIndex)]
                [DisplayName(Unk_36_displayName)]
                public virtual uint Unk_36 {
                    get => Unk_36_raw;
                    set {
                        if (Unk_36_raw == value) return;
                        Unk_36_raw = value;
                        OnPropertyChanged(nameof(Unk_36));
                    }
                }

                protected uint Unk_37_raw;
                public const string Unk_37_displayName = "Unk 37";
                public const int Unk_37_sortIndex = 2950;
                [SortOrder(Unk_37_sortIndex)]
                [DisplayName(Unk_37_displayName)]
                public virtual uint Unk_37 {
                    get => Unk_37_raw;
                    set {
                        if (Unk_37_raw == value) return;
                        Unk_37_raw = value;
                        OnPropertyChanged(nameof(Unk_37));
                    }
                }

                protected ushort Unk_38_raw;
                public const string Unk_38_displayName = "Unk 38";
                public const int Unk_38_sortIndex = 3000;
                [SortOrder(Unk_38_sortIndex)]
                [DisplayName(Unk_38_displayName)]
                public virtual ushort Unk_38 {
                    get => Unk_38_raw;
                    set {
                        if (Unk_38_raw == value) return;
                        Unk_38_raw = value;
                        OnPropertyChanged(nameof(Unk_38));
                    }
                }

                public const int lastSortIndex = 3050;

                public static ObservableCollection<Atk1> LoadData(BinaryReader reader, Moves parent) {
                    var list = new ObservableCollection<Atk1>();
                    var count = (ulong) parent.Move_Count;
                    for (ulong i = 0; i < count; i++) {
                        list.Add(LoadData(reader, i, parent));
                    }
                    return list;
                }

                public static Atk1 LoadData(BinaryReader reader, ulong i, Moves parent) {
                    var data = new Atk1();
                    data.Index = i;
                    data.Index_raw = reader.ReadUInt32();
                    data.Attack_Type_raw = reader.ReadUInt32();
                    data.Motion_Value_raw = reader.ReadSingle();
                    data.Fixed_Damage_raw = reader.ReadSingle();
                    data.Part_Modifier_raw = reader.ReadSingle();
                    data.Elemental_Modifier_raw = reader.ReadSingle();
                    data.Status_Modifier_raw = reader.ReadSingle();
                    data.Stun_raw = reader.ReadSingle();
                    data.Exhaust_raw = reader.ReadSingle();
                    data.Mount_raw = reader.ReadSingle();
                    data.Unk_1_raw = reader.ReadSingle();
                    data.Unk_2_raw = reader.ReadSingle();
                    data.Unk_3_raw = reader.ReadByte();
                    data.Soften_Value_raw = reader.ReadSingle();
                    data.Unk_4_raw = reader.ReadSingle();
                    data.Unk_5_raw = reader.ReadSingle();
                    data.Unk_6_raw = reader.ReadSingle();
                    data.Unk_7_raw = reader.ReadSingle();
                    data.Unk_8_raw = reader.ReadSingle();
                    data.Unk_9_raw = reader.ReadSingle();
                    data.Unk_10_raw = reader.ReadSingle();
                    data.Unk_11_raw = reader.ReadSingle();
                    data.Flinch_Value_raw = reader.ReadUInt32();
                    data.Unk_12_raw = reader.ReadUInt32();
                    data.Mind_s_Eye_raw = reader.ReadByte();
                    data.Unk_13_raw = reader.ReadSingle();
                    data.Unk_14_raw = reader.ReadSingle();
                    data.Unk_15_raw = reader.ReadByte();
                    data.Hit_Lag_Speed_Multiplier_a__raw = reader.ReadSingle();
                    data.Unk_16_raw = reader.ReadSingle();
                    data.Hit_Lag_a__raw = reader.ReadSingle();
                    data.Unk_17_raw = reader.ReadSingle();
                    data.Unk_18_raw = reader.ReadSingle();
                    data.Hit_Lag_Speed_Multiplier_b__raw = reader.ReadSingle();
                    data.Unk_19_raw = reader.ReadSingle();
                    data.Hit_Lag_b__raw = reader.ReadSingle();
                    data.Unk_20_raw = reader.ReadSingle();
                    data.Unk_21_raw = reader.ReadSingle();
                    data.Unk_22_raw = reader.ReadUInt32();
                    data.Unk_23_raw = reader.ReadSByte();
                    data.Unk_24_raw = reader.ReadByte();
                    data.Unk_25_raw = reader.ReadUInt32();
                    data.Unk_26_raw = reader.ReadSingle();
                    data.Unk_27_raw = reader.ReadSingle();
                    data.Unk_28_raw = reader.ReadSingle();
                    data.Lingering_Hurtbox_raw = reader.ReadByte();
                    data.Frame_Delay_raw = reader.ReadSingle();
                    data.Unk_29_raw = reader.ReadUInt32();
                    data.Unk_30_raw = reader.ReadUInt16();
                    data.Energy_Gen_raw = reader.ReadSingle();
                    data.Conditional_Motion_value_change_replace_raw = reader.ReadSingle();
                    data.Conditional_element_modifier_change_replace_raw = reader.ReadSingle();
                    data.Unk_31_raw = reader.ReadUInt32();
                    data.Unk_32_raw = reader.ReadUInt32();
                    data.Unk_33_raw = reader.ReadUInt32();
                    data.Unk_34_raw = reader.ReadUInt32();
                    data.Unk_35_raw = reader.ReadUInt32();
                    data.Unk_36_raw = reader.ReadUInt32();
                    data.Unk_37_raw = reader.ReadUInt32();
                    data.Unk_38_raw = reader.ReadUInt16();
                    return data;
                }

                public void WriteData(BinaryWriter writer, Moves parent) {
                    writer.Write(Index_raw);
                    writer.Write(Attack_Type_raw);
                    writer.Write(Motion_Value_raw);
                    writer.Write(Fixed_Damage_raw);
                    writer.Write(Part_Modifier_raw);
                    writer.Write(Elemental_Modifier_raw);
                    writer.Write(Status_Modifier_raw);
                    writer.Write(Stun_raw);
                    writer.Write(Exhaust_raw);
                    writer.Write(Mount_raw);
                    writer.Write(Unk_1_raw);
                    writer.Write(Unk_2_raw);
                    writer.Write(Unk_3_raw);
                    writer.Write(Soften_Value_raw);
                    writer.Write(Unk_4_raw);
                    writer.Write(Unk_5_raw);
                    writer.Write(Unk_6_raw);
                    writer.Write(Unk_7_raw);
                    writer.Write(Unk_8_raw);
                    writer.Write(Unk_9_raw);
                    writer.Write(Unk_10_raw);
                    writer.Write(Unk_11_raw);
                    writer.Write(Flinch_Value_raw);
                    writer.Write(Unk_12_raw);
                    writer.Write(Mind_s_Eye_raw);
                    writer.Write(Unk_13_raw);
                    writer.Write(Unk_14_raw);
                    writer.Write(Unk_15_raw);
                    writer.Write(Hit_Lag_Speed_Multiplier_a__raw);
                    writer.Write(Unk_16_raw);
                    writer.Write(Hit_Lag_a__raw);
                    writer.Write(Unk_17_raw);
                    writer.Write(Unk_18_raw);
                    writer.Write(Hit_Lag_Speed_Multiplier_b__raw);
                    writer.Write(Unk_19_raw);
                    writer.Write(Hit_Lag_b__raw);
                    writer.Write(Unk_20_raw);
                    writer.Write(Unk_21_raw);
                    writer.Write(Unk_22_raw);
                    writer.Write(Unk_23_raw);
                    writer.Write(Unk_24_raw);
                    writer.Write(Unk_25_raw);
                    writer.Write(Unk_26_raw);
                    writer.Write(Unk_27_raw);
                    writer.Write(Unk_28_raw);
                    writer.Write(Lingering_Hurtbox_raw);
                    writer.Write(Frame_Delay_raw);
                    writer.Write(Unk_29_raw);
                    writer.Write(Unk_30_raw);
                    writer.Write(Energy_Gen_raw);
                    writer.Write(Conditional_Motion_value_change_replace_raw);
                    writer.Write(Conditional_element_modifier_change_replace_raw);
                    writer.Write(Unk_31_raw);
                    writer.Write(Unk_32_raw);
                    writer.Write(Unk_33_raw);
                    writer.Write(Unk_34_raw);
                    writer.Write(Unk_35_raw);
                    writer.Write(Unk_36_raw);
                    writer.Write(Unk_37_raw);
                    writer.Write(Unk_38_raw);
                }
            }

            public const string Atk1_displayName = "Atk1";
            public const int Atk1_sortIndex = 350;
            [SortOrder(Atk1_sortIndex)]
            [DisplayName(Atk1_displayName)]
            protected virtual ObservableCollection<Atk1> Atk1_raw { get; set; }

            public partial class Atk2 : MhwStructItem {
                public const ulong FixedSizeCount = 0;
                public const string GridName = "Atk2";

                protected uint Index_raw;
                public const string Index_displayName = "Index";
                public const int Index_sortIndex = 50;
                [SortOrder(Index_sortIndex)]
                [DisplayName(Index_displayName)]
                public override ulong Index {
                    get => (ulong) Index_raw;
                    set {
                        if ((ulong) Index_raw == value) return;
                        Index_raw = (uint) value;
                        OnPropertyChanged(nameof(Index));
                    }
                }

                protected uint Knock_back_Type_raw;
                public const string Knock_back_Type_displayName = "Knock-back Type";
                public const int Knock_back_Type_sortIndex = 100;
                [SortOrder(Knock_back_Type_sortIndex)]
                [DisplayName(Knock_back_Type_displayName)]
                public virtual uint Knock_back_Type {
                    get => Knock_back_Type_raw;
                    set {
                        if (Knock_back_Type_raw == value) return;
                        Knock_back_Type_raw = value;
                        OnPropertyChanged(nameof(Knock_back_Type));
                    }
                }

                protected uint Knock_back_Lvl_raw;
                public const string Knock_back_Lvl_displayName = "Knock-back Lvl";
                public const int Knock_back_Lvl_sortIndex = 150;
                [SortOrder(Knock_back_Lvl_sortIndex)]
                [DisplayName(Knock_back_Lvl_displayName)]
                public virtual uint Knock_back_Lvl {
                    get => Knock_back_Lvl_raw;
                    set {
                        if (Knock_back_Lvl_raw == value) return;
                        Knock_back_Lvl_raw = value;
                        OnPropertyChanged(nameof(Knock_back_Lvl));
                    }
                }

                protected uint Unk_1_raw;
                public const string Unk_1_displayName = "Unk 1";
                public const int Unk_1_sortIndex = 200;
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

                protected float Motion_Value_raw;
                public const string Motion_Value_displayName = "Motion Value";
                public const int Motion_Value_sortIndex = 250;
                [SortOrder(Motion_Value_sortIndex)]
                [DisplayName(Motion_Value_displayName)]
                public virtual float Motion_Value {
                    get => Motion_Value_raw;
                    set {
                        if (Motion_Value_raw == value) return;
                        Motion_Value_raw = value;
                        OnPropertyChanged(nameof(Motion_Value));
                    }
                }

                protected uint Unk_2_raw;
                public const string Unk_2_displayName = "Unk 2";
                public const int Unk_2_sortIndex = 300;
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

                protected uint Unk_3_raw;
                public const string Unk_3_displayName = "Unk 3";
                public const int Unk_3_sortIndex = 350;
                [SortOrder(Unk_3_sortIndex)]
                [DisplayName(Unk_3_displayName)]
                public virtual uint Unk_3 {
                    get => Unk_3_raw;
                    set {
                        if (Unk_3_raw == value) return;
                        Unk_3_raw = value;
                        OnPropertyChanged(nameof(Unk_3));
                    }
                }

                protected float Guard_Stamina_Cost_raw;
                public const string Guard_Stamina_Cost_displayName = "Guard Stamina Cost";
                public const int Guard_Stamina_Cost_sortIndex = 400;
                [SortOrder(Guard_Stamina_Cost_sortIndex)]
                [DisplayName(Guard_Stamina_Cost_displayName)]
                public virtual float Guard_Stamina_Cost {
                    get => Guard_Stamina_Cost_raw;
                    set {
                        if (Guard_Stamina_Cost_raw == value) return;
                        Guard_Stamina_Cost_raw = value;
                        OnPropertyChanged(nameof(Guard_Stamina_Cost));
                    }
                }

                protected uint Guard_Req_raw;
                public const string Guard_Req_displayName = "Guard Req";
                public const int Guard_Req_sortIndex = 450;
                [SortOrder(Guard_Req_sortIndex)]
                [DisplayName(Guard_Req_displayName)]
                public virtual uint Guard_Req {
                    get => Guard_Req_raw;
                    set {
                        if (Guard_Req_raw == value) return;
                        Guard_Req_raw = value;
                        OnPropertyChanged(nameof(Guard_Req));
                    }
                }

                protected uint Element_Id_raw;
                public const string Element_Id_displayName = "Element Id";
                public const int Element_Id_sortIndex = 500;
                [SortOrder(Element_Id_sortIndex)]
                [DisplayName(Element_Id_displayName)]
                public virtual uint Element_Id {
                    get => Element_Id_raw;
                    set {
                        if (Element_Id_raw == value) return;
                        Element_Id_raw = value;
                        OnPropertyChanged(nameof(Element_Id));
                    }
                }

                protected uint Unk_4_raw;
                public const string Unk_4_displayName = "Unk 4";
                public const int Unk_4_sortIndex = 550;
                [SortOrder(Unk_4_sortIndex)]
                [DisplayName(Unk_4_displayName)]
                public virtual uint Unk_4 {
                    get => Unk_4_raw;
                    set {
                        if (Unk_4_raw == value) return;
                        Unk_4_raw = value;
                        OnPropertyChanged(nameof(Unk_4));
                    }
                }

                protected float Element_Dmg_raw;
                public const string Element_Dmg_displayName = "Element Dmg";
                public const int Element_Dmg_sortIndex = 600;
                [SortOrder(Element_Dmg_sortIndex)]
                [DisplayName(Element_Dmg_displayName)]
                public virtual float Element_Dmg {
                    get => Element_Dmg_raw;
                    set {
                        if (Element_Dmg_raw == value) return;
                        Element_Dmg_raw = value;
                        OnPropertyChanged(nameof(Element_Dmg));
                    }
                }

                protected float Unk_5_raw;
                public const string Unk_5_displayName = "Unk 5";
                public const int Unk_5_sortIndex = 650;
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

                protected float Deadly_Poison_raw;
                public const string Deadly_Poison_displayName = "Deadly Poison";
                public const int Deadly_Poison_sortIndex = 700;
                [SortOrder(Deadly_Poison_sortIndex)]
                [DisplayName(Deadly_Poison_displayName)]
                public virtual float Deadly_Poison {
                    get => Deadly_Poison_raw;
                    set {
                        if (Deadly_Poison_raw == value) return;
                        Deadly_Poison_raw = value;
                        OnPropertyChanged(nameof(Deadly_Poison));
                    }
                }

                protected float Paralysis_raw;
                public const string Paralysis_displayName = "Paralysis";
                public const int Paralysis_sortIndex = 750;
                [SortOrder(Paralysis_sortIndex)]
                [DisplayName(Paralysis_displayName)]
                public virtual float Paralysis {
                    get => Paralysis_raw;
                    set {
                        if (Paralysis_raw == value) return;
                        Paralysis_raw = value;
                        OnPropertyChanged(nameof(Paralysis));
                    }
                }

                protected float Sleep_raw;
                public const string Sleep_displayName = "Sleep";
                public const int Sleep_sortIndex = 800;
                [SortOrder(Sleep_sortIndex)]
                [DisplayName(Sleep_displayName)]
                public virtual float Sleep {
                    get => Sleep_raw;
                    set {
                        if (Sleep_raw == value) return;
                        Sleep_raw = value;
                        OnPropertyChanged(nameof(Sleep));
                    }
                }

                protected float Blast_raw;
                public const string Blast_displayName = "Blast";
                public const int Blast_sortIndex = 850;
                [SortOrder(Blast_sortIndex)]
                [DisplayName(Blast_displayName)]
                public virtual float Blast {
                    get => Blast_raw;
                    set {
                        if (Blast_raw == value) return;
                        Blast_raw = value;
                        OnPropertyChanged(nameof(Blast));
                    }
                }

                protected float Blast_Scourge_raw;
                public const string Blast_Scourge_displayName = "Blast Scourge";
                public const int Blast_Scourge_sortIndex = 900;
                [SortOrder(Blast_Scourge_sortIndex)]
                [DisplayName(Blast_Scourge_displayName)]
                public virtual float Blast_Scourge {
                    get => Blast_Scourge_raw;
                    set {
                        if (Blast_Scourge_raw == value) return;
                        Blast_Scourge_raw = value;
                        OnPropertyChanged(nameof(Blast_Scourge));
                    }
                }

                protected float Stun_raw;
                public const string Stun_displayName = "Stun";
                public const int Stun_sortIndex = 950;
                [SortOrder(Stun_sortIndex)]
                [DisplayName(Stun_displayName)]
                public virtual float Stun {
                    get => Stun_raw;
                    set {
                        if (Stun_raw == value) return;
                        Stun_raw = value;
                        OnPropertyChanged(nameof(Stun));
                    }
                }

                protected float Bleed_raw;
                public const string Bleed_displayName = "Bleed";
                public const int Bleed_sortIndex = 1000;
                [SortOrder(Bleed_sortIndex)]
                [DisplayName(Bleed_displayName)]
                public virtual float Bleed {
                    get => Bleed_raw;
                    set {
                        if (Bleed_raw == value) return;
                        Bleed_raw = value;
                        OnPropertyChanged(nameof(Bleed));
                    }
                }

                protected float Miasma_raw;
                public const string Miasma_displayName = "Miasma";
                public const int Miasma_sortIndex = 1050;
                [SortOrder(Miasma_sortIndex)]
                [DisplayName(Miasma_displayName)]
                public virtual float Miasma {
                    get => Miasma_raw;
                    set {
                        if (Miasma_raw == value) return;
                        Miasma_raw = value;
                        OnPropertyChanged(nameof(Miasma));
                    }
                }

                protected byte Ele_Res_Down_Double_raw;
                public const string Ele_Res_Down_Double_displayName = "Ele Res Down Double";
                public const int Ele_Res_Down_Double_sortIndex = 1100;
                [SortOrder(Ele_Res_Down_Double_sortIndex)]
                [DisplayName(Ele_Res_Down_Double_displayName)]
                public virtual byte Ele_Res_Down_Double {
                    get => Ele_Res_Down_Double_raw;
                    set {
                        if (Ele_Res_Down_Double_raw == value) return;
                        Ele_Res_Down_Double_raw = value;
                        OnPropertyChanged(nameof(Ele_Res_Down_Double));
                    }
                }

                protected byte Ele_Res_Down_raw;
                public const string Ele_Res_Down_displayName = "Ele Res Down";
                public const int Ele_Res_Down_sortIndex = 1150;
                [SortOrder(Ele_Res_Down_sortIndex)]
                [DisplayName(Ele_Res_Down_displayName)]
                public virtual byte Ele_Res_Down {
                    get => Ele_Res_Down_raw;
                    set {
                        if (Ele_Res_Down_raw == value) return;
                        Ele_Res_Down_raw = value;
                        OnPropertyChanged(nameof(Ele_Res_Down));
                    }
                }

                protected byte Def_Down_Double_raw;
                public const string Def_Down_Double_displayName = "Def Down Double";
                public const int Def_Down_Double_sortIndex = 1200;
                [SortOrder(Def_Down_Double_sortIndex)]
                [DisplayName(Def_Down_Double_displayName)]
                public virtual byte Def_Down_Double {
                    get => Def_Down_Double_raw;
                    set {
                        if (Def_Down_Double_raw == value) return;
                        Def_Down_Double_raw = value;
                        OnPropertyChanged(nameof(Def_Down_Double));
                    }
                }

                protected byte Def_Down_raw;
                public const string Def_Down_displayName = "Def Down";
                public const int Def_Down_sortIndex = 1250;
                [SortOrder(Def_Down_sortIndex)]
                [DisplayName(Def_Down_displayName)]
                public virtual byte Def_Down {
                    get => Def_Down_raw;
                    set {
                        if (Def_Down_raw == value) return;
                        Def_Down_raw = value;
                        OnPropertyChanged(nameof(Def_Down));
                    }
                }

                protected uint Unk_6_raw;
                public const string Unk_6_displayName = "Unk 6";
                public const int Unk_6_sortIndex = 1300;
                [SortOrder(Unk_6_sortIndex)]
                [DisplayName(Unk_6_displayName)]
                public virtual uint Unk_6 {
                    get => Unk_6_raw;
                    set {
                        if (Unk_6_raw == value) return;
                        Unk_6_raw = value;
                        OnPropertyChanged(nameof(Unk_6));
                    }
                }

                protected uint Unk_7_raw;
                public const string Unk_7_displayName = "Unk 7";
                public const int Unk_7_sortIndex = 1350;
                [SortOrder(Unk_7_sortIndex)]
                [DisplayName(Unk_7_displayName)]
                public virtual uint Unk_7 {
                    get => Unk_7_raw;
                    set {
                        if (Unk_7_raw == value) return;
                        Unk_7_raw = value;
                        OnPropertyChanged(nameof(Unk_7));
                    }
                }

                protected float Unk_8_raw;
                public const string Unk_8_displayName = "Unk 8";
                public const int Unk_8_sortIndex = 1400;
                [SortOrder(Unk_8_sortIndex)]
                [DisplayName(Unk_8_displayName)]
                public virtual float Unk_8 {
                    get => Unk_8_raw;
                    set {
                        if (Unk_8_raw == value) return;
                        Unk_8_raw = value;
                        OnPropertyChanged(nameof(Unk_8));
                    }
                }

                protected float Unk_9_raw;
                public const string Unk_9_displayName = "Unk 9";
                public const int Unk_9_sortIndex = 1450;
                [SortOrder(Unk_9_sortIndex)]
                [DisplayName(Unk_9_displayName)]
                public virtual float Unk_9 {
                    get => Unk_9_raw;
                    set {
                        if (Unk_9_raw == value) return;
                        Unk_9_raw = value;
                        OnPropertyChanged(nameof(Unk_9));
                    }
                }

                protected float Unk_10_raw;
                public const string Unk_10_displayName = "Unk 10";
                public const int Unk_10_sortIndex = 1500;
                [SortOrder(Unk_10_sortIndex)]
                [DisplayName(Unk_10_displayName)]
                public virtual float Unk_10 {
                    get => Unk_10_raw;
                    set {
                        if (Unk_10_raw == value) return;
                        Unk_10_raw = value;
                        OnPropertyChanged(nameof(Unk_10));
                    }
                }

                protected float Unk_11_raw;
                public const string Unk_11_displayName = "Unk 11";
                public const int Unk_11_sortIndex = 1550;
                [SortOrder(Unk_11_sortIndex)]
                [DisplayName(Unk_11_displayName)]
                public virtual float Unk_11 {
                    get => Unk_11_raw;
                    set {
                        if (Unk_11_raw == value) return;
                        Unk_11_raw = value;
                        OnPropertyChanged(nameof(Unk_11));
                    }
                }

                protected float Unk_12_raw;
                public const string Unk_12_displayName = "Unk 12";
                public const int Unk_12_sortIndex = 1600;
                [SortOrder(Unk_12_sortIndex)]
                [DisplayName(Unk_12_displayName)]
                public virtual float Unk_12 {
                    get => Unk_12_raw;
                    set {
                        if (Unk_12_raw == value) return;
                        Unk_12_raw = value;
                        OnPropertyChanged(nameof(Unk_12));
                    }
                }

                protected uint Unk_13_raw;
                public const string Unk_13_displayName = "Unk 13";
                public const int Unk_13_sortIndex = 1650;
                [SortOrder(Unk_13_sortIndex)]
                [DisplayName(Unk_13_displayName)]
                public virtual uint Unk_13 {
                    get => Unk_13_raw;
                    set {
                        if (Unk_13_raw == value) return;
                        Unk_13_raw = value;
                        OnPropertyChanged(nameof(Unk_13));
                    }
                }

                protected uint Unk_14_raw;
                public const string Unk_14_displayName = "Unk 14";
                public const int Unk_14_sortIndex = 1700;
                [SortOrder(Unk_14_sortIndex)]
                [DisplayName(Unk_14_displayName)]
                public virtual uint Unk_14 {
                    get => Unk_14_raw;
                    set {
                        if (Unk_14_raw == value) return;
                        Unk_14_raw = value;
                        OnPropertyChanged(nameof(Unk_14));
                    }
                }

                protected uint Unk_15_raw;
                public const string Unk_15_displayName = "Unk 15";
                public const int Unk_15_sortIndex = 1750;
                [SortOrder(Unk_15_sortIndex)]
                [DisplayName(Unk_15_displayName)]
                public virtual uint Unk_15 {
                    get => Unk_15_raw;
                    set {
                        if (Unk_15_raw == value) return;
                        Unk_15_raw = value;
                        OnPropertyChanged(nameof(Unk_15));
                    }
                }

                protected byte Unk_16_raw;
                public const string Unk_16_displayName = "Unk 16";
                public const int Unk_16_sortIndex = 1800;
                [SortOrder(Unk_16_sortIndex)]
                [DisplayName(Unk_16_displayName)]
                public virtual byte Unk_16 {
                    get => Unk_16_raw;
                    set {
                        if (Unk_16_raw == value) return;
                        Unk_16_raw = value;
                        OnPropertyChanged(nameof(Unk_16));
                    }
                }

                protected float Unk_17_raw;
                public const string Unk_17_displayName = "Unk 17";
                public const int Unk_17_sortIndex = 1850;
                [SortOrder(Unk_17_sortIndex)]
                [DisplayName(Unk_17_displayName)]
                public virtual float Unk_17 {
                    get => Unk_17_raw;
                    set {
                        if (Unk_17_raw == value) return;
                        Unk_17_raw = value;
                        OnPropertyChanged(nameof(Unk_17));
                    }
                }

                protected uint Unk_18_raw;
                public const string Unk_18_displayName = "Unk 18";
                public const int Unk_18_sortIndex = 1900;
                [SortOrder(Unk_18_sortIndex)]
                [DisplayName(Unk_18_displayName)]
                public virtual uint Unk_18 {
                    get => Unk_18_raw;
                    set {
                        if (Unk_18_raw == value) return;
                        Unk_18_raw = value;
                        OnPropertyChanged(nameof(Unk_18));
                    }
                }

                protected uint Unk_19_raw;
                public const string Unk_19_displayName = "Unk 19";
                public const int Unk_19_sortIndex = 1950;
                [SortOrder(Unk_19_sortIndex)]
                [DisplayName(Unk_19_displayName)]
                public virtual uint Unk_19 {
                    get => Unk_19_raw;
                    set {
                        if (Unk_19_raw == value) return;
                        Unk_19_raw = value;
                        OnPropertyChanged(nameof(Unk_19));
                    }
                }

                protected uint Unk_20_raw;
                public const string Unk_20_displayName = "Unk 20";
                public const int Unk_20_sortIndex = 2000;
                [SortOrder(Unk_20_sortIndex)]
                [DisplayName(Unk_20_displayName)]
                public virtual uint Unk_20 {
                    get => Unk_20_raw;
                    set {
                        if (Unk_20_raw == value) return;
                        Unk_20_raw = value;
                        OnPropertyChanged(nameof(Unk_20));
                    }
                }

                protected uint Unk_21_raw;
                public const string Unk_21_displayName = "Unk 21";
                public const int Unk_21_sortIndex = 2050;
                [SortOrder(Unk_21_sortIndex)]
                [DisplayName(Unk_21_displayName)]
                public virtual uint Unk_21 {
                    get => Unk_21_raw;
                    set {
                        if (Unk_21_raw == value) return;
                        Unk_21_raw = value;
                        OnPropertyChanged(nameof(Unk_21));
                    }
                }

                protected uint Unk_22_raw;
                public const string Unk_22_displayName = "Unk 22";
                public const int Unk_22_sortIndex = 2100;
                [SortOrder(Unk_22_sortIndex)]
                [DisplayName(Unk_22_displayName)]
                public virtual uint Unk_22 {
                    get => Unk_22_raw;
                    set {
                        if (Unk_22_raw == value) return;
                        Unk_22_raw = value;
                        OnPropertyChanged(nameof(Unk_22));
                    }
                }

                protected uint Unk_23_raw;
                public const string Unk_23_displayName = "Unk 23";
                public const int Unk_23_sortIndex = 2150;
                [SortOrder(Unk_23_sortIndex)]
                [DisplayName(Unk_23_displayName)]
                public virtual uint Unk_23 {
                    get => Unk_23_raw;
                    set {
                        if (Unk_23_raw == value) return;
                        Unk_23_raw = value;
                        OnPropertyChanged(nameof(Unk_23));
                    }
                }

                protected uint Unk_24_raw;
                public const string Unk_24_displayName = "Unk 24";
                public const int Unk_24_sortIndex = 2200;
                [SortOrder(Unk_24_sortIndex)]
                [DisplayName(Unk_24_displayName)]
                public virtual uint Unk_24 {
                    get => Unk_24_raw;
                    set {
                        if (Unk_24_raw == value) return;
                        Unk_24_raw = value;
                        OnPropertyChanged(nameof(Unk_24));
                    }
                }

                protected uint Unk_25_raw;
                public const string Unk_25_displayName = "Unk 25";
                public const int Unk_25_sortIndex = 2250;
                [SortOrder(Unk_25_sortIndex)]
                [DisplayName(Unk_25_displayName)]
                public virtual uint Unk_25 {
                    get => Unk_25_raw;
                    set {
                        if (Unk_25_raw == value) return;
                        Unk_25_raw = value;
                        OnPropertyChanged(nameof(Unk_25));
                    }
                }

                protected uint Unk_26_raw;
                public const string Unk_26_displayName = "Unk 26";
                public const int Unk_26_sortIndex = 2300;
                [SortOrder(Unk_26_sortIndex)]
                [DisplayName(Unk_26_displayName)]
                public virtual uint Unk_26 {
                    get => Unk_26_raw;
                    set {
                        if (Unk_26_raw == value) return;
                        Unk_26_raw = value;
                        OnPropertyChanged(nameof(Unk_26));
                    }
                }

                protected ushort Unk_27_raw;
                public const string Unk_27_displayName = "Unk 27";
                public const int Unk_27_sortIndex = 2350;
                [SortOrder(Unk_27_sortIndex)]
                [DisplayName(Unk_27_displayName)]
                public virtual ushort Unk_27 {
                    get => Unk_27_raw;
                    set {
                        if (Unk_27_raw == value) return;
                        Unk_27_raw = value;
                        OnPropertyChanged(nameof(Unk_27));
                    }
                }

                public const int lastSortIndex = 2400;

                public static ObservableCollection<Atk2> LoadData(BinaryReader reader, Moves parent) {
                    var list = new ObservableCollection<Atk2>();
                    var count = (ulong) parent.Move_Count;
                    for (ulong i = 0; i < count; i++) {
                        list.Add(LoadData(reader, i, parent));
                    }
                    return list;
                }

                public static Atk2 LoadData(BinaryReader reader, ulong i, Moves parent) {
                    var data = new Atk2();
                    data.Index = i;
                    data.Index_raw = reader.ReadUInt32();
                    data.Knock_back_Type_raw = reader.ReadUInt32();
                    data.Knock_back_Lvl_raw = reader.ReadUInt32();
                    data.Unk_1_raw = reader.ReadUInt32();
                    data.Motion_Value_raw = reader.ReadSingle();
                    data.Unk_2_raw = reader.ReadUInt32();
                    data.Unk_3_raw = reader.ReadUInt32();
                    data.Guard_Stamina_Cost_raw = reader.ReadSingle();
                    data.Guard_Req_raw = reader.ReadUInt32();
                    data.Element_Id_raw = reader.ReadUInt32();
                    data.Unk_4_raw = reader.ReadUInt32();
                    data.Element_Dmg_raw = reader.ReadSingle();
                    data.Unk_5_raw = reader.ReadSingle();
                    data.Deadly_Poison_raw = reader.ReadSingle();
                    data.Paralysis_raw = reader.ReadSingle();
                    data.Sleep_raw = reader.ReadSingle();
                    data.Blast_raw = reader.ReadSingle();
                    data.Blast_Scourge_raw = reader.ReadSingle();
                    data.Stun_raw = reader.ReadSingle();
                    data.Bleed_raw = reader.ReadSingle();
                    data.Miasma_raw = reader.ReadSingle();
                    data.Ele_Res_Down_Double_raw = reader.ReadByte();
                    data.Ele_Res_Down_raw = reader.ReadByte();
                    data.Def_Down_Double_raw = reader.ReadByte();
                    data.Def_Down_raw = reader.ReadByte();
                    data.Unk_6_raw = reader.ReadUInt32();
                    data.Unk_7_raw = reader.ReadUInt32();
                    data.Unk_8_raw = reader.ReadSingle();
                    data.Unk_9_raw = reader.ReadSingle();
                    data.Unk_10_raw = reader.ReadSingle();
                    data.Unk_11_raw = reader.ReadSingle();
                    data.Unk_12_raw = reader.ReadSingle();
                    data.Unk_13_raw = reader.ReadUInt32();
                    data.Unk_14_raw = reader.ReadUInt32();
                    data.Unk_15_raw = reader.ReadUInt32();
                    data.Unk_16_raw = reader.ReadByte();
                    data.Unk_17_raw = reader.ReadSingle();
                    data.Unk_18_raw = reader.ReadUInt32();
                    data.Unk_19_raw = reader.ReadUInt32();
                    data.Unk_20_raw = reader.ReadUInt32();
                    data.Unk_21_raw = reader.ReadUInt32();
                    data.Unk_22_raw = reader.ReadUInt32();
                    data.Unk_23_raw = reader.ReadUInt32();
                    data.Unk_24_raw = reader.ReadUInt32();
                    data.Unk_25_raw = reader.ReadUInt32();
                    data.Unk_26_raw = reader.ReadUInt32();
                    data.Unk_27_raw = reader.ReadUInt16();
                    return data;
                }

                public void WriteData(BinaryWriter writer, Moves parent) {
                    writer.Write(Index_raw);
                    writer.Write(Knock_back_Type_raw);
                    writer.Write(Knock_back_Lvl_raw);
                    writer.Write(Unk_1_raw);
                    writer.Write(Motion_Value_raw);
                    writer.Write(Unk_2_raw);
                    writer.Write(Unk_3_raw);
                    writer.Write(Guard_Stamina_Cost_raw);
                    writer.Write(Guard_Req_raw);
                    writer.Write(Element_Id_raw);
                    writer.Write(Unk_4_raw);
                    writer.Write(Element_Dmg_raw);
                    writer.Write(Unk_5_raw);
                    writer.Write(Deadly_Poison_raw);
                    writer.Write(Paralysis_raw);
                    writer.Write(Sleep_raw);
                    writer.Write(Blast_raw);
                    writer.Write(Blast_Scourge_raw);
                    writer.Write(Stun_raw);
                    writer.Write(Bleed_raw);
                    writer.Write(Miasma_raw);
                    writer.Write(Ele_Res_Down_Double_raw);
                    writer.Write(Ele_Res_Down_raw);
                    writer.Write(Def_Down_Double_raw);
                    writer.Write(Def_Down_raw);
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
                }
            }

            public const string Atk2_displayName = "Atk2";
            public const int Atk2_sortIndex = 400;
            [SortOrder(Atk2_sortIndex)]
            [DisplayName(Atk2_displayName)]
            protected virtual ObservableCollection<Atk2> Atk2_raw { get; set; }

            public partial class Atk3 : MhwStructItem {
                public const ulong FixedSizeCount = 0;
                public const string GridName = "Atk3";

                protected uint Index_raw;
                public const string Index_displayName = "Index";
                public const int Index_sortIndex = 50;
                [SortOrder(Index_sortIndex)]
                [DisplayName(Index_displayName)]
                public override ulong Index {
                    get => (ulong) Index_raw;
                    set {
                        if ((ulong) Index_raw == value) return;
                        Index_raw = (uint) value;
                        OnPropertyChanged(nameof(Index));
                    }
                }

                protected uint Damage_Type_1_raw;
                public const string Damage_Type_1_displayName = "Damage Type 1";
                public const int Damage_Type_1_sortIndex = 100;
                [SortOrder(Damage_Type_1_sortIndex)]
                [DisplayName(Damage_Type_1_displayName)]
                public virtual uint Damage_Type_1 {
                    get => Damage_Type_1_raw;
                    set {
                        if (Damage_Type_1_raw == value) return;
                        Damage_Type_1_raw = value;
                        OnPropertyChanged(nameof(Damage_Type_1));
                    }
                }

                protected uint Damage_Type_2_raw;
                public const string Damage_Type_2_displayName = "Damage Type 2";
                public const int Damage_Type_2_sortIndex = 150;
                [SortOrder(Damage_Type_2_sortIndex)]
                [DisplayName(Damage_Type_2_displayName)]
                public virtual uint Damage_Type_2 {
                    get => Damage_Type_2_raw;
                    set {
                        if (Damage_Type_2_raw == value) return;
                        Damage_Type_2_raw = value;
                        OnPropertyChanged(nameof(Damage_Type_2));
                    }
                }

                protected float Damage_Motion_Value_raw;
                public const string Damage_Motion_Value_displayName = "Damage Motion Value";
                public const int Damage_Motion_Value_sortIndex = 200;
                [SortOrder(Damage_Motion_Value_sortIndex)]
                [DisplayName(Damage_Motion_Value_displayName)]
                public virtual float Damage_Motion_Value {
                    get => Damage_Motion_Value_raw;
                    set {
                        if (Damage_Motion_Value_raw == value) return;
                        Damage_Motion_Value_raw = value;
                        OnPropertyChanged(nameof(Damage_Motion_Value));
                    }
                }

                protected float Fixed_Damage_raw;
                public const string Fixed_Damage_displayName = "Fixed Damage";
                public const int Fixed_Damage_sortIndex = 250;
                [SortOrder(Fixed_Damage_sortIndex)]
                [DisplayName(Fixed_Damage_displayName)]
                public virtual float Fixed_Damage {
                    get => Fixed_Damage_raw;
                    set {
                        if (Fixed_Damage_raw == value) return;
                        Fixed_Damage_raw = value;
                        OnPropertyChanged(nameof(Fixed_Damage));
                    }
                }

                protected float Modifier_PartDamage_raw;
                public const string Modifier_PartDamage_displayName = "Modifier PartDamage";
                public const int Modifier_PartDamage_sortIndex = 300;
                [SortOrder(Modifier_PartDamage_sortIndex)]
                [DisplayName(Modifier_PartDamage_displayName)]
                public virtual float Modifier_PartDamage {
                    get => Modifier_PartDamage_raw;
                    set {
                        if (Modifier_PartDamage_raw == value) return;
                        Modifier_PartDamage_raw = value;
                        OnPropertyChanged(nameof(Modifier_PartDamage));
                    }
                }

                protected uint Element_Type_raw;
                public const string Element_Type_displayName = "Element Type";
                public const int Element_Type_sortIndex = 350;
                [SortOrder(Element_Type_sortIndex)]
                [DisplayName(Element_Type_displayName)]
                public virtual uint Element_Type {
                    get => Element_Type_raw;
                    set {
                        if (Element_Type_raw == value) return;
                        Element_Type_raw = value;
                        OnPropertyChanged(nameof(Element_Type));
                    }
                }

                protected float Fixed_Elemental_Damage_raw;
                public const string Fixed_Elemental_Damage_displayName = "Fixed Elemental Damage";
                public const int Fixed_Elemental_Damage_sortIndex = 400;
                [SortOrder(Fixed_Elemental_Damage_sortIndex)]
                [DisplayName(Fixed_Elemental_Damage_displayName)]
                public virtual float Fixed_Elemental_Damage {
                    get => Fixed_Elemental_Damage_raw;
                    set {
                        if (Fixed_Elemental_Damage_raw == value) return;
                        Fixed_Elemental_Damage_raw = value;
                        OnPropertyChanged(nameof(Fixed_Elemental_Damage));
                    }
                }

                protected float Modifier_Element_raw;
                public const string Modifier_Element_displayName = "Modifier Element";
                public const int Modifier_Element_sortIndex = 450;
                [SortOrder(Modifier_Element_sortIndex)]
                [DisplayName(Modifier_Element_displayName)]
                public virtual float Modifier_Element {
                    get => Modifier_Element_raw;
                    set {
                        if (Modifier_Element_raw == value) return;
                        Modifier_Element_raw = value;
                        OnPropertyChanged(nameof(Modifier_Element));
                    }
                }

                protected float Modifier_Status_raw;
                public const string Modifier_Status_displayName = "Modifier Status";
                public const int Modifier_Status_sortIndex = 500;
                [SortOrder(Modifier_Status_sortIndex)]
                [DisplayName(Modifier_Status_displayName)]
                public virtual float Modifier_Status {
                    get => Modifier_Status_raw;
                    set {
                        if (Modifier_Status_raw == value) return;
                        Modifier_Status_raw = value;
                        OnPropertyChanged(nameof(Modifier_Status));
                    }
                }

                protected float Fixed_Status_Value_Poison_raw;
                public const string Fixed_Status_Value_Poison_displayName = "Fixed Status Value: Poison";
                public const int Fixed_Status_Value_Poison_sortIndex = 550;
                [SortOrder(Fixed_Status_Value_Poison_sortIndex)]
                [DisplayName(Fixed_Status_Value_Poison_displayName)]
                public virtual float Fixed_Status_Value_Poison {
                    get => Fixed_Status_Value_Poison_raw;
                    set {
                        if (Fixed_Status_Value_Poison_raw == value) return;
                        Fixed_Status_Value_Poison_raw = value;
                        OnPropertyChanged(nameof(Fixed_Status_Value_Poison));
                    }
                }

                protected float Fixed_Status_Value_Paralysis_raw;
                public const string Fixed_Status_Value_Paralysis_displayName = "Fixed Status Value: Paralysis";
                public const int Fixed_Status_Value_Paralysis_sortIndex = 600;
                [SortOrder(Fixed_Status_Value_Paralysis_sortIndex)]
                [DisplayName(Fixed_Status_Value_Paralysis_displayName)]
                public virtual float Fixed_Status_Value_Paralysis {
                    get => Fixed_Status_Value_Paralysis_raw;
                    set {
                        if (Fixed_Status_Value_Paralysis_raw == value) return;
                        Fixed_Status_Value_Paralysis_raw = value;
                        OnPropertyChanged(nameof(Fixed_Status_Value_Paralysis));
                    }
                }

                protected float Fixed_Status_Value_Sleep_raw;
                public const string Fixed_Status_Value_Sleep_displayName = "Fixed Status Value: Sleep";
                public const int Fixed_Status_Value_Sleep_sortIndex = 650;
                [SortOrder(Fixed_Status_Value_Sleep_sortIndex)]
                [DisplayName(Fixed_Status_Value_Sleep_displayName)]
                public virtual float Fixed_Status_Value_Sleep {
                    get => Fixed_Status_Value_Sleep_raw;
                    set {
                        if (Fixed_Status_Value_Sleep_raw == value) return;
                        Fixed_Status_Value_Sleep_raw = value;
                        OnPropertyChanged(nameof(Fixed_Status_Value_Sleep));
                    }
                }

                protected float Fixed_Status_Value_Blast_raw;
                public const string Fixed_Status_Value_Blast_displayName = "Fixed Status Value: Blast";
                public const int Fixed_Status_Value_Blast_sortIndex = 700;
                [SortOrder(Fixed_Status_Value_Blast_sortIndex)]
                [DisplayName(Fixed_Status_Value_Blast_displayName)]
                public virtual float Fixed_Status_Value_Blast {
                    get => Fixed_Status_Value_Blast_raw;
                    set {
                        if (Fixed_Status_Value_Blast_raw == value) return;
                        Fixed_Status_Value_Blast_raw = value;
                        OnPropertyChanged(nameof(Fixed_Status_Value_Blast));
                    }
                }

                protected float Extra_Stun_raw;
                public const string Extra_Stun_displayName = "Extra Stun";
                public const int Extra_Stun_sortIndex = 750;
                [SortOrder(Extra_Stun_sortIndex)]
                [DisplayName(Extra_Stun_displayName)]
                public virtual float Extra_Stun {
                    get => Extra_Stun_raw;
                    set {
                        if (Extra_Stun_raw == value) return;
                        Extra_Stun_raw = value;
                        OnPropertyChanged(nameof(Extra_Stun));
                    }
                }

                protected float Extra_Exhaust_raw;
                public const string Extra_Exhaust_displayName = "Extra Exhaust";
                public const int Extra_Exhaust_sortIndex = 800;
                [SortOrder(Extra_Exhaust_sortIndex)]
                [DisplayName(Extra_Exhaust_displayName)]
                public virtual float Extra_Exhaust {
                    get => Extra_Exhaust_raw;
                    set {
                        if (Extra_Exhaust_raw == value) return;
                        Extra_Exhaust_raw = value;
                        OnPropertyChanged(nameof(Extra_Exhaust));
                    }
                }

                protected float Fixed_Status_Value_Traq_raw;
                public const string Fixed_Status_Value_Traq_displayName = "Fixed Status Value: Traq";
                public const int Fixed_Status_Value_Traq_sortIndex = 850;
                [SortOrder(Fixed_Status_Value_Traq_sortIndex)]
                [DisplayName(Fixed_Status_Value_Traq_displayName)]
                public virtual float Fixed_Status_Value_Traq {
                    get => Fixed_Status_Value_Traq_raw;
                    set {
                        if (Fixed_Status_Value_Traq_raw == value) return;
                        Fixed_Status_Value_Traq_raw = value;
                        OnPropertyChanged(nameof(Fixed_Status_Value_Traq));
                    }
                }

                protected float Unk_1_raw;
                public const string Unk_1_displayName = "Unk 1";
                public const int Unk_1_sortIndex = 900;
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
                public const int Unk_2_sortIndex = 950;
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

                protected float Soften_Value_raw;
                public const string Soften_Value_displayName = "Soften Value";
                public const int Soften_Value_sortIndex = 1000;
                [SortOrder(Soften_Value_sortIndex)]
                [DisplayName(Soften_Value_displayName)]
                public virtual float Soften_Value {
                    get => Soften_Value_raw;
                    set {
                        if (Soften_Value_raw == value) return;
                        Soften_Value_raw = value;
                        OnPropertyChanged(nameof(Soften_Value));
                    }
                }

                protected float Unk_3_raw;
                public const string Unk_3_displayName = "Unk 3";
                public const int Unk_3_sortIndex = 1050;
                [SortOrder(Unk_3_sortIndex)]
                [DisplayName(Unk_3_displayName)]
                public virtual float Unk_3 {
                    get => Unk_3_raw;
                    set {
                        if (Unk_3_raw == value) return;
                        Unk_3_raw = value;
                        OnPropertyChanged(nameof(Unk_3));
                    }
                }

                protected float Unk_4_raw;
                public const string Unk_4_displayName = "Unk 4";
                public const int Unk_4_sortIndex = 1100;
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
                public const int Unk_5_sortIndex = 1150;
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

                protected float Unk_6_raw;
                public const string Unk_6_displayName = "Unk 6";
                public const int Unk_6_sortIndex = 1200;
                [SortOrder(Unk_6_sortIndex)]
                [DisplayName(Unk_6_displayName)]
                public virtual float Unk_6 {
                    get => Unk_6_raw;
                    set {
                        if (Unk_6_raw == value) return;
                        Unk_6_raw = value;
                        OnPropertyChanged(nameof(Unk_6));
                    }
                }

                protected float Unk_7_raw;
                public const string Unk_7_displayName = "Unk 7";
                public const int Unk_7_sortIndex = 1250;
                [SortOrder(Unk_7_sortIndex)]
                [DisplayName(Unk_7_displayName)]
                public virtual float Unk_7 {
                    get => Unk_7_raw;
                    set {
                        if (Unk_7_raw == value) return;
                        Unk_7_raw = value;
                        OnPropertyChanged(nameof(Unk_7));
                    }
                }

                protected float Unk_8_raw;
                public const string Unk_8_displayName = "Unk 8";
                public const int Unk_8_sortIndex = 1300;
                [SortOrder(Unk_8_sortIndex)]
                [DisplayName(Unk_8_displayName)]
                public virtual float Unk_8 {
                    get => Unk_8_raw;
                    set {
                        if (Unk_8_raw == value) return;
                        Unk_8_raw = value;
                        OnPropertyChanged(nameof(Unk_8));
                    }
                }

                protected uint Unk_9_raw;
                public const string Unk_9_displayName = "Unk 9";
                public const int Unk_9_sortIndex = 1350;
                [SortOrder(Unk_9_sortIndex)]
                [DisplayName(Unk_9_displayName)]
                public virtual uint Unk_9 {
                    get => Unk_9_raw;
                    set {
                        if (Unk_9_raw == value) return;
                        Unk_9_raw = value;
                        OnPropertyChanged(nameof(Unk_9));
                    }
                }

                protected uint Unk_10_raw;
                public const string Unk_10_displayName = "Unk 10";
                public const int Unk_10_sortIndex = 1400;
                [SortOrder(Unk_10_sortIndex)]
                [DisplayName(Unk_10_displayName)]
                public virtual uint Unk_10 {
                    get => Unk_10_raw;
                    set {
                        if (Unk_10_raw == value) return;
                        Unk_10_raw = value;
                        OnPropertyChanged(nameof(Unk_10));
                    }
                }

                protected uint Unk_11_raw;
                public const string Unk_11_displayName = "Unk 11";
                public const int Unk_11_sortIndex = 1450;
                [SortOrder(Unk_11_sortIndex)]
                [DisplayName(Unk_11_displayName)]
                public virtual uint Unk_11 {
                    get => Unk_11_raw;
                    set {
                        if (Unk_11_raw == value) return;
                        Unk_11_raw = value;
                        OnPropertyChanged(nameof(Unk_11));
                    }
                }

                protected uint Unk_12_raw;
                public const string Unk_12_displayName = "Unk 12";
                public const int Unk_12_sortIndex = 1500;
                [SortOrder(Unk_12_sortIndex)]
                [DisplayName(Unk_12_displayName)]
                public virtual uint Unk_12 {
                    get => Unk_12_raw;
                    set {
                        if (Unk_12_raw == value) return;
                        Unk_12_raw = value;
                        OnPropertyChanged(nameof(Unk_12));
                    }
                }

                protected uint Unk_13_raw;
                public const string Unk_13_displayName = "Unk 13";
                public const int Unk_13_sortIndex = 1550;
                [SortOrder(Unk_13_sortIndex)]
                [DisplayName(Unk_13_displayName)]
                public virtual uint Unk_13 {
                    get => Unk_13_raw;
                    set {
                        if (Unk_13_raw == value) return;
                        Unk_13_raw = value;
                        OnPropertyChanged(nameof(Unk_13));
                    }
                }

                protected uint Unk_14_raw;
                public const string Unk_14_displayName = "Unk 14";
                public const int Unk_14_sortIndex = 1600;
                [SortOrder(Unk_14_sortIndex)]
                [DisplayName(Unk_14_displayName)]
                public virtual uint Unk_14 {
                    get => Unk_14_raw;
                    set {
                        if (Unk_14_raw == value) return;
                        Unk_14_raw = value;
                        OnPropertyChanged(nameof(Unk_14));
                    }
                }

                protected sbyte Unk_15_raw;
                public const string Unk_15_displayName = "Unk 15";
                public const int Unk_15_sortIndex = 1650;
                [SortOrder(Unk_15_sortIndex)]
                [DisplayName(Unk_15_displayName)]
                public virtual sbyte Unk_15 {
                    get => Unk_15_raw;
                    set {
                        if (Unk_15_raw == value) return;
                        Unk_15_raw = value;
                        OnPropertyChanged(nameof(Unk_15));
                    }
                }

                protected byte Unk_16_raw;
                public const string Unk_16_displayName = "Unk 16";
                public const int Unk_16_sortIndex = 1700;
                [SortOrder(Unk_16_sortIndex)]
                [DisplayName(Unk_16_displayName)]
                public virtual byte Unk_16 {
                    get => Unk_16_raw;
                    set {
                        if (Unk_16_raw == value) return;
                        Unk_16_raw = value;
                        OnPropertyChanged(nameof(Unk_16));
                    }
                }

                protected byte Unk_17_raw;
                public const string Unk_17_displayName = "Unk 17";
                public const int Unk_17_sortIndex = 1750;
                [SortOrder(Unk_17_sortIndex)]
                [DisplayName(Unk_17_displayName)]
                public virtual byte Unk_17 {
                    get => Unk_17_raw;
                    set {
                        if (Unk_17_raw == value) return;
                        Unk_17_raw = value;
                        OnPropertyChanged(nameof(Unk_17));
                    }
                }

                protected uint Unk_18_raw;
                public const string Unk_18_displayName = "Unk 18";
                public const int Unk_18_sortIndex = 1800;
                [SortOrder(Unk_18_sortIndex)]
                [DisplayName(Unk_18_displayName)]
                public virtual uint Unk_18 {
                    get => Unk_18_raw;
                    set {
                        if (Unk_18_raw == value) return;
                        Unk_18_raw = value;
                        OnPropertyChanged(nameof(Unk_18));
                    }
                }

                protected uint Unk_19_raw;
                public const string Unk_19_displayName = "Unk 19";
                public const int Unk_19_sortIndex = 1850;
                [SortOrder(Unk_19_sortIndex)]
                [DisplayName(Unk_19_displayName)]
                public virtual uint Unk_19 {
                    get => Unk_19_raw;
                    set {
                        if (Unk_19_raw == value) return;
                        Unk_19_raw = value;
                        OnPropertyChanged(nameof(Unk_19));
                    }
                }

                protected float Unk_20_raw;
                public const string Unk_20_displayName = "Unk 20";
                public const int Unk_20_sortIndex = 1900;
                [SortOrder(Unk_20_sortIndex)]
                [DisplayName(Unk_20_displayName)]
                public virtual float Unk_20 {
                    get => Unk_20_raw;
                    set {
                        if (Unk_20_raw == value) return;
                        Unk_20_raw = value;
                        OnPropertyChanged(nameof(Unk_20));
                    }
                }

                protected uint Unk_21_raw;
                public const string Unk_21_displayName = "Unk 21";
                public const int Unk_21_sortIndex = 1950;
                [SortOrder(Unk_21_sortIndex)]
                [DisplayName(Unk_21_displayName)]
                public virtual uint Unk_21 {
                    get => Unk_21_raw;
                    set {
                        if (Unk_21_raw == value) return;
                        Unk_21_raw = value;
                        OnPropertyChanged(nameof(Unk_21));
                    }
                }

                protected byte Piercing_Attack_raw;
                public const string Piercing_Attack_displayName = "Piercing Attack";
                public const int Piercing_Attack_sortIndex = 2000;
                [SortOrder(Piercing_Attack_sortIndex)]
                [DisplayName(Piercing_Attack_displayName)]
                public virtual byte Piercing_Attack {
                    get => Piercing_Attack_raw;
                    set {
                        if (Piercing_Attack_raw == value) return;
                        Piercing_Attack_raw = value;
                        OnPropertyChanged(nameof(Piercing_Attack));
                    }
                }

                protected float Delay_Between_Attack_Frames_raw;
                public const string Delay_Between_Attack_Frames_displayName = "Delay Between Attack Frames";
                public const int Delay_Between_Attack_Frames_sortIndex = 2050;
                [SortOrder(Delay_Between_Attack_Frames_sortIndex)]
                [DisplayName(Delay_Between_Attack_Frames_displayName)]
                public virtual float Delay_Between_Attack_Frames {
                    get => Delay_Between_Attack_Frames_raw;
                    set {
                        if (Delay_Between_Attack_Frames_raw == value) return;
                        Delay_Between_Attack_Frames_raw = value;
                        OnPropertyChanged(nameof(Delay_Between_Attack_Frames));
                    }
                }

                protected byte Unk_22_raw;
                public const string Unk_22_displayName = "Unk 22";
                public const int Unk_22_sortIndex = 2100;
                [SortOrder(Unk_22_sortIndex)]
                [DisplayName(Unk_22_displayName)]
                public virtual byte Unk_22 {
                    get => Unk_22_raw;
                    set {
                        if (Unk_22_raw == value) return;
                        Unk_22_raw = value;
                        OnPropertyChanged(nameof(Unk_22));
                    }
                }

                protected uint Unk_23_raw;
                public const string Unk_23_displayName = "Unk 23";
                public const int Unk_23_sortIndex = 2150;
                [SortOrder(Unk_23_sortIndex)]
                [DisplayName(Unk_23_displayName)]
                public virtual uint Unk_23 {
                    get => Unk_23_raw;
                    set {
                        if (Unk_23_raw == value) return;
                        Unk_23_raw = value;
                        OnPropertyChanged(nameof(Unk_23));
                    }
                }

                protected uint Unk_24_raw;
                public const string Unk_24_displayName = "Unk 24";
                public const int Unk_24_sortIndex = 2200;
                [SortOrder(Unk_24_sortIndex)]
                [DisplayName(Unk_24_displayName)]
                public virtual uint Unk_24 {
                    get => Unk_24_raw;
                    set {
                        if (Unk_24_raw == value) return;
                        Unk_24_raw = value;
                        OnPropertyChanged(nameof(Unk_24));
                    }
                }

                protected uint Unk_25_raw;
                public const string Unk_25_displayName = "Unk 25";
                public const int Unk_25_sortIndex = 2250;
                [SortOrder(Unk_25_sortIndex)]
                [DisplayName(Unk_25_displayName)]
                public virtual uint Unk_25 {
                    get => Unk_25_raw;
                    set {
                        if (Unk_25_raw == value) return;
                        Unk_25_raw = value;
                        OnPropertyChanged(nameof(Unk_25));
                    }
                }

                protected uint Unk_26_raw;
                public const string Unk_26_displayName = "Unk 26";
                public const int Unk_26_sortIndex = 2300;
                [SortOrder(Unk_26_sortIndex)]
                [DisplayName(Unk_26_displayName)]
                public virtual uint Unk_26 {
                    get => Unk_26_raw;
                    set {
                        if (Unk_26_raw == value) return;
                        Unk_26_raw = value;
                        OnPropertyChanged(nameof(Unk_26));
                    }
                }

                protected uint Unk_27_raw;
                public const string Unk_27_displayName = "Unk 27";
                public const int Unk_27_sortIndex = 2350;
                [SortOrder(Unk_27_sortIndex)]
                [DisplayName(Unk_27_displayName)]
                public virtual uint Unk_27 {
                    get => Unk_27_raw;
                    set {
                        if (Unk_27_raw == value) return;
                        Unk_27_raw = value;
                        OnPropertyChanged(nameof(Unk_27));
                    }
                }

                protected uint Unk_28_raw;
                public const string Unk_28_displayName = "Unk 28";
                public const int Unk_28_sortIndex = 2400;
                [SortOrder(Unk_28_sortIndex)]
                [DisplayName(Unk_28_displayName)]
                public virtual uint Unk_28 {
                    get => Unk_28_raw;
                    set {
                        if (Unk_28_raw == value) return;
                        Unk_28_raw = value;
                        OnPropertyChanged(nameof(Unk_28));
                    }
                }

                protected uint Unk_29_raw;
                public const string Unk_29_displayName = "Unk 29";
                public const int Unk_29_sortIndex = 2450;
                [SortOrder(Unk_29_sortIndex)]
                [DisplayName(Unk_29_displayName)]
                public virtual uint Unk_29 {
                    get => Unk_29_raw;
                    set {
                        if (Unk_29_raw == value) return;
                        Unk_29_raw = value;
                        OnPropertyChanged(nameof(Unk_29));
                    }
                }

                protected uint Unk_30_raw;
                public const string Unk_30_displayName = "Unk 30";
                public const int Unk_30_sortIndex = 2500;
                [SortOrder(Unk_30_sortIndex)]
                [DisplayName(Unk_30_displayName)]
                public virtual uint Unk_30 {
                    get => Unk_30_raw;
                    set {
                        if (Unk_30_raw == value) return;
                        Unk_30_raw = value;
                        OnPropertyChanged(nameof(Unk_30));
                    }
                }

                protected uint Unk_31_raw;
                public const string Unk_31_displayName = "Unk 31";
                public const int Unk_31_sortIndex = 2550;
                [SortOrder(Unk_31_sortIndex)]
                [DisplayName(Unk_31_displayName)]
                public virtual uint Unk_31 {
                    get => Unk_31_raw;
                    set {
                        if (Unk_31_raw == value) return;
                        Unk_31_raw = value;
                        OnPropertyChanged(nameof(Unk_31));
                    }
                }

                protected uint Unk_32_raw;
                public const string Unk_32_displayName = "Unk 32";
                public const int Unk_32_sortIndex = 2600;
                [SortOrder(Unk_32_sortIndex)]
                [DisplayName(Unk_32_displayName)]
                public virtual uint Unk_32 {
                    get => Unk_32_raw;
                    set {
                        if (Unk_32_raw == value) return;
                        Unk_32_raw = value;
                        OnPropertyChanged(nameof(Unk_32));
                    }
                }

                protected uint Unk_33_raw;
                public const string Unk_33_displayName = "Unk 33";
                public const int Unk_33_sortIndex = 2650;
                [SortOrder(Unk_33_sortIndex)]
                [DisplayName(Unk_33_displayName)]
                public virtual uint Unk_33 {
                    get => Unk_33_raw;
                    set {
                        if (Unk_33_raw == value) return;
                        Unk_33_raw = value;
                        OnPropertyChanged(nameof(Unk_33));
                    }
                }

                protected ushort Unk_34_raw;
                public const string Unk_34_displayName = "Unk 34";
                public const int Unk_34_sortIndex = 2700;
                [SortOrder(Unk_34_sortIndex)]
                [DisplayName(Unk_34_displayName)]
                public virtual ushort Unk_34 {
                    get => Unk_34_raw;
                    set {
                        if (Unk_34_raw == value) return;
                        Unk_34_raw = value;
                        OnPropertyChanged(nameof(Unk_34));
                    }
                }

                public const int lastSortIndex = 2750;

                public static ObservableCollection<Atk3> LoadData(BinaryReader reader, Moves parent) {
                    var list = new ObservableCollection<Atk3>();
                    var count = (ulong) parent.Move_Count;
                    for (ulong i = 0; i < count; i++) {
                        list.Add(LoadData(reader, i, parent));
                    }
                    return list;
                }

                public static Atk3 LoadData(BinaryReader reader, ulong i, Moves parent) {
                    var data = new Atk3();
                    data.Index = i;
                    data.Index_raw = reader.ReadUInt32();
                    data.Damage_Type_1_raw = reader.ReadUInt32();
                    data.Damage_Type_2_raw = reader.ReadUInt32();
                    data.Damage_Motion_Value_raw = reader.ReadSingle();
                    data.Fixed_Damage_raw = reader.ReadSingle();
                    data.Modifier_PartDamage_raw = reader.ReadSingle();
                    data.Element_Type_raw = reader.ReadUInt32();
                    data.Fixed_Elemental_Damage_raw = reader.ReadSingle();
                    data.Modifier_Element_raw = reader.ReadSingle();
                    data.Modifier_Status_raw = reader.ReadSingle();
                    data.Fixed_Status_Value_Poison_raw = reader.ReadSingle();
                    data.Fixed_Status_Value_Paralysis_raw = reader.ReadSingle();
                    data.Fixed_Status_Value_Sleep_raw = reader.ReadSingle();
                    data.Fixed_Status_Value_Blast_raw = reader.ReadSingle();
                    data.Extra_Stun_raw = reader.ReadSingle();
                    data.Extra_Exhaust_raw = reader.ReadSingle();
                    data.Fixed_Status_Value_Traq_raw = reader.ReadSingle();
                    data.Unk_1_raw = reader.ReadSingle();
                    data.Unk_2_raw = reader.ReadSingle();
                    data.Soften_Value_raw = reader.ReadSingle();
                    data.Unk_3_raw = reader.ReadSingle();
                    data.Unk_4_raw = reader.ReadSingle();
                    data.Unk_5_raw = reader.ReadSingle();
                    data.Unk_6_raw = reader.ReadSingle();
                    data.Unk_7_raw = reader.ReadSingle();
                    data.Unk_8_raw = reader.ReadSingle();
                    data.Unk_9_raw = reader.ReadUInt32();
                    data.Unk_10_raw = reader.ReadUInt32();
                    data.Unk_11_raw = reader.ReadUInt32();
                    data.Unk_12_raw = reader.ReadUInt32();
                    data.Unk_13_raw = reader.ReadUInt32();
                    data.Unk_14_raw = reader.ReadUInt32();
                    data.Unk_15_raw = reader.ReadSByte();
                    data.Unk_16_raw = reader.ReadByte();
                    data.Unk_17_raw = reader.ReadByte();
                    data.Unk_18_raw = reader.ReadUInt32();
                    data.Unk_19_raw = reader.ReadUInt32();
                    data.Unk_20_raw = reader.ReadSingle();
                    data.Unk_21_raw = reader.ReadUInt32();
                    data.Piercing_Attack_raw = reader.ReadByte();
                    data.Delay_Between_Attack_Frames_raw = reader.ReadSingle();
                    data.Unk_22_raw = reader.ReadByte();
                    data.Unk_23_raw = reader.ReadUInt32();
                    data.Unk_24_raw = reader.ReadUInt32();
                    data.Unk_25_raw = reader.ReadUInt32();
                    data.Unk_26_raw = reader.ReadUInt32();
                    data.Unk_27_raw = reader.ReadUInt32();
                    data.Unk_28_raw = reader.ReadUInt32();
                    data.Unk_29_raw = reader.ReadUInt32();
                    data.Unk_30_raw = reader.ReadUInt32();
                    data.Unk_31_raw = reader.ReadUInt32();
                    data.Unk_32_raw = reader.ReadUInt32();
                    data.Unk_33_raw = reader.ReadUInt32();
                    data.Unk_34_raw = reader.ReadUInt16();
                    return data;
                }

                public void WriteData(BinaryWriter writer, Moves parent) {
                    writer.Write(Index_raw);
                    writer.Write(Damage_Type_1_raw);
                    writer.Write(Damage_Type_2_raw);
                    writer.Write(Damage_Motion_Value_raw);
                    writer.Write(Fixed_Damage_raw);
                    writer.Write(Modifier_PartDamage_raw);
                    writer.Write(Element_Type_raw);
                    writer.Write(Fixed_Elemental_Damage_raw);
                    writer.Write(Modifier_Element_raw);
                    writer.Write(Modifier_Status_raw);
                    writer.Write(Fixed_Status_Value_Poison_raw);
                    writer.Write(Fixed_Status_Value_Paralysis_raw);
                    writer.Write(Fixed_Status_Value_Sleep_raw);
                    writer.Write(Fixed_Status_Value_Blast_raw);
                    writer.Write(Extra_Stun_raw);
                    writer.Write(Extra_Exhaust_raw);
                    writer.Write(Fixed_Status_Value_Traq_raw);
                    writer.Write(Unk_1_raw);
                    writer.Write(Unk_2_raw);
                    writer.Write(Soften_Value_raw);
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
                    writer.Write(Piercing_Attack_raw);
                    writer.Write(Delay_Between_Attack_Frames_raw);
                    writer.Write(Unk_22_raw);
                    writer.Write(Unk_23_raw);
                    writer.Write(Unk_24_raw);
                    writer.Write(Unk_25_raw);
                    writer.Write(Unk_26_raw);
                    writer.Write(Unk_27_raw);
                    writer.Write(Unk_28_raw);
                    writer.Write(Unk_29_raw);
                    writer.Write(Unk_30_raw);
                    writer.Write(Unk_31_raw);
                    writer.Write(Unk_32_raw);
                    writer.Write(Unk_33_raw);
                    writer.Write(Unk_34_raw);
                }
            }

            public const string Atk3_displayName = "Atk3";
            public const int Atk3_sortIndex = 450;
            [SortOrder(Atk3_sortIndex)]
            [DisplayName(Atk3_displayName)]
            protected virtual ObservableCollection<Atk3> Atk3_raw { get; set; }

            public const int lastSortIndex = 500;

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Moves LoadData(BinaryReader reader, ulong i) {
                var data = new Moves();
                data.Index = i;
                data.Magic_1_raw = reader.ReadUInt32();
                data.Name_raw = reader.ReadChars(4);
                data.Magic_2_raw = reader.ReadUInt32();
                data.Move_Count_raw = reader.ReadUInt32();
                data.Move_Type_raw = reader.ReadUInt32();
                if (data.Move_Type_raw == 0) data.Atk0_raw = Atk0.LoadData(reader, data);
                else data.Atk0_raw = new ObservableCollection<Atk0>();
                if (data.Move_Type_raw == 1) data.Atk1_raw = Atk1.LoadData(reader, data);
                else data.Atk1_raw = new ObservableCollection<Atk1>();
                if (data.Move_Type_raw == 2) data.Atk2_raw = Atk2.LoadData(reader, data);
                else data.Atk2_raw = new ObservableCollection<Atk2>();
                if (data.Move_Type_raw == 3) data.Atk3_raw = Atk3.LoadData(reader, data);
                else data.Atk3_raw = new ObservableCollection<Atk3>();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                if (Move_Type_raw == 0) Move_Count = (uint) Atk0_raw.Count;
                if (Move_Type_raw == 1) Move_Count = (uint) Atk1_raw.Count;
                if (Move_Type_raw == 2) Move_Count = (uint) Atk2_raw.Count;
                if (Move_Type_raw == 3) Move_Count = (uint) Atk3_raw.Count;
                writer.Write(Magic_1_raw);
                writer.Write(Name_raw);
                writer.Write(Magic_2_raw);
                writer.Write(Move_Count_raw);
                writer.Write(Move_Type_raw);
                if (Move_Type_raw == 0) foreach (var obj in Atk0_raw) {
                    obj.WriteData(writer, this);
                }
                if (Move_Type_raw == 1) foreach (var obj in Atk1_raw) {
                    obj.WriteData(writer, this);
                }
                if (Move_Type_raw == 2) foreach (var obj in Atk2_raw) {
                    obj.WriteData(writer, this);
                }
                if (Move_Type_raw == 3) foreach (var obj in Atk3_raw) {
                    obj.WriteData(writer, this);
                }
            }
        }

        public partial class OAP : MhwStructItem {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "OAP";

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

            protected char[] Name_raw;
            public const string Name_displayName = "Name";
            public const int Name_sortIndex = 150;
            [SortOrder(Name_sortIndex)]
            [DisplayName(Name_displayName)]
            [IsReadOnly]
            public virtual string Name {
                get => (string) new string(Name_raw);
                set {
                    if ((string) new string(Name_raw) == value) return;
                    Name_raw = (char[]) value.ToCharArray(0, 3);
                    OnPropertyChanged(nameof(Name));
                }
            }

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
                    OnPropertyChanged(nameof(Magic_3));
                }
            }

            public partial class End_Junk : MhwStructItem {
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
                        OnPropertyChanged(nameof(Unk));
                    }
                }

                public const int lastSortIndex = 100;

                public void WriteData(BinaryWriter writer, OAP parent) {
                    writer.Write(Unk_raw);
                }
            }

            public const string The_rest_of_the_file_as_bytes__displayName = "The rest of the file as bytes.";
            public const int The_rest_of_the_file_as_bytes__sortIndex = 250;
            [SortOrder(The_rest_of_the_file_as_bytes__sortIndex)]
            [DisplayName(The_rest_of_the_file_as_bytes__displayName)]
            public virtual ObservableCollection<End_Junk> The_rest_of_the_file_as_bytes__raw { get; protected set; }

            public const int lastSortIndex = 300;

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static OAP LoadData(BinaryReader reader, ulong i) {
                var data = new OAP();
                data.Index = i;
                data.Magic_1_raw = reader.ReadUInt32();
                data.Magic_2_raw = reader.ReadUInt32();
                data.Name_raw = reader.ReadChars(4);
                data.Magic_3_raw = reader.ReadUInt32();
                data.The_rest_of_the_file_as_bytes__raw = End_Junk.LoadData(reader, data);
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Magic_1_raw);
                writer.Write(Magic_2_raw);
                writer.Write(Name_raw);
                writer.Write(Magic_3_raw);
                foreach (var obj in The_rest_of_the_file_as_bytes__raw) {
                    obj.WriteData(writer, this);
                }
            }
        }

        public override void LoadFile(string targetFile) {
            using var reader = new BinaryReader(OpenFile(targetFile, EncryptionKey), Encoding.UTF8);
            data = new LinkedList<MhwStructDataContainer>();
            var Collisions_ = new MhwStructDataContainer(Collisions.LoadData(reader, null), typeof(Collisions));
            data.AddLast(Collisions_);
            var Names_ = new MhwStructDataContainer(Names.LoadData(reader, Collisions_.list), typeof(Names));
            Names_.SetCountTargetToUpdate(Collisions_, -1, "Name_Count");
            data.AddLast(Names_);
            var CLND_ = new MhwStructDataContainer(CLND.LoadData(reader, null), typeof(CLND));
            data.AddLast(CLND_);
            var Moves_ = new MhwStructDataContainer(Moves.LoadData(reader, null), typeof(Moves));
            data.AddLast(Moves_);
            var OAP_ = new MhwStructDataContainer(OAP.LoadData(reader, null), typeof(OAP));
            data.AddLast(OAP_);
        }
    }
}
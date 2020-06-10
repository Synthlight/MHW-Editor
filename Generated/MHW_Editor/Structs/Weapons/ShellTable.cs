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
    public partial class ShellTable {
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
                    OnPropertyChanged(nameof(Entry_Count));
                }
            }

            public const int lastSortIndex = 200;

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

        public partial class Entries : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 0;
            public const string GridName = "Entries";

            protected byte Normal_1_Mag_Cnt_raw;
            public const string Normal_1_Mag_Cnt_displayName = "Normal 1 Mag Cnt";
            public const int Normal_1_Mag_Cnt_sortIndex = 50;
            [SortOrder(Normal_1_Mag_Cnt_sortIndex)]
            [DisplayName(Normal_1_Mag_Cnt_displayName)]
            public virtual byte Normal_1_Mag_Cnt {
                get => Normal_1_Mag_Cnt_raw;
                set {
                    if (Normal_1_Mag_Cnt_raw == value.Clamp((byte) 0, (byte) 10)) return;
                    Normal_1_Mag_Cnt_raw = value.Clamp((byte) 0, (byte) 10);
                    OnPropertyChanged(nameof(Normal_1_Mag_Cnt));
                }
            }

            protected byte Normal_1_Rec_Amnt_raw;
            public const string Normal_1_Rec_Amnt_displayName = "Normal 1 Rec Amnt";
            public const int Normal_1_Rec_Amnt_sortIndex = 100;
            [SortOrder(Normal_1_Rec_Amnt_sortIndex)]
            [DisplayName(Normal_1_Rec_Amnt_displayName)]
            [DataSource(DataSourceType.ShellRecoil)]
            public virtual byte Normal_1_Rec_Amnt {
                get => Normal_1_Rec_Amnt_raw;
                set {
                    if (Normal_1_Rec_Amnt_raw == value) return;
                    Normal_1_Rec_Amnt_raw = value;
                    OnPropertyChanged(nameof(Normal_1_Rec_Amnt));
                    OnPropertyChanged(nameof(Normal_1_Rec_Amnt_button));
                }
            }

            [SortOrder(Normal_1_Rec_Amnt_sortIndex)]
            [DisplayName(Normal_1_Rec_Amnt_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Normal_1_Rec_Amnt_button => ShellTable.recoilLookup.TryGet(Normal_1_Rec_Amnt).ToStringWithId(Normal_1_Rec_Amnt);

            protected byte Normal_1_Rel_Spd_raw;
            public const string Normal_1_Rel_Spd_displayName = "Normal 1 Rel Spd";
            public const int Normal_1_Rel_Spd_sortIndex = 150;
            [SortOrder(Normal_1_Rel_Spd_sortIndex)]
            [DisplayName(Normal_1_Rel_Spd_displayName)]
            [DataSource(DataSourceType.ShellReload)]
            public virtual byte Normal_1_Rel_Spd {
                get => Normal_1_Rel_Spd_raw;
                set {
                    if (Normal_1_Rel_Spd_raw == value) return;
                    Normal_1_Rel_Spd_raw = value;
                    OnPropertyChanged(nameof(Normal_1_Rel_Spd));
                    OnPropertyChanged(nameof(Normal_1_Rel_Spd_button));
                }
            }

            [SortOrder(Normal_1_Rel_Spd_sortIndex)]
            [DisplayName(Normal_1_Rel_Spd_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Normal_1_Rel_Spd_button => ShellTable.reloadLookup.TryGet(Normal_1_Rel_Spd).ToStringWithId(Normal_1_Rel_Spd);

            protected byte Normal_2_Mag_Cnt_raw;
            public const string Normal_2_Mag_Cnt_displayName = "Normal 2 Mag Cnt";
            public const int Normal_2_Mag_Cnt_sortIndex = 200;
            [SortOrder(Normal_2_Mag_Cnt_sortIndex)]
            [DisplayName(Normal_2_Mag_Cnt_displayName)]
            public virtual byte Normal_2_Mag_Cnt {
                get => Normal_2_Mag_Cnt_raw;
                set {
                    if (Normal_2_Mag_Cnt_raw == value.Clamp((byte) 0, (byte) 10)) return;
                    Normal_2_Mag_Cnt_raw = value.Clamp((byte) 0, (byte) 10);
                    OnPropertyChanged(nameof(Normal_2_Mag_Cnt));
                }
            }

            protected byte Normal_2_Rec_Amnt_raw;
            public const string Normal_2_Rec_Amnt_displayName = "Normal 2 Rec Amnt";
            public const int Normal_2_Rec_Amnt_sortIndex = 250;
            [SortOrder(Normal_2_Rec_Amnt_sortIndex)]
            [DisplayName(Normal_2_Rec_Amnt_displayName)]
            [DataSource(DataSourceType.ShellRecoil)]
            public virtual byte Normal_2_Rec_Amnt {
                get => Normal_2_Rec_Amnt_raw;
                set {
                    if (Normal_2_Rec_Amnt_raw == value) return;
                    Normal_2_Rec_Amnt_raw = value;
                    OnPropertyChanged(nameof(Normal_2_Rec_Amnt));
                    OnPropertyChanged(nameof(Normal_2_Rec_Amnt_button));
                }
            }

            [SortOrder(Normal_2_Rec_Amnt_sortIndex)]
            [DisplayName(Normal_2_Rec_Amnt_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Normal_2_Rec_Amnt_button => ShellTable.recoilLookup.TryGet(Normal_2_Rec_Amnt).ToStringWithId(Normal_2_Rec_Amnt);

            protected byte Normal_2_Rel_Spd_raw;
            public const string Normal_2_Rel_Spd_displayName = "Normal 2 Rel Spd";
            public const int Normal_2_Rel_Spd_sortIndex = 300;
            [SortOrder(Normal_2_Rel_Spd_sortIndex)]
            [DisplayName(Normal_2_Rel_Spd_displayName)]
            [DataSource(DataSourceType.ShellReload)]
            public virtual byte Normal_2_Rel_Spd {
                get => Normal_2_Rel_Spd_raw;
                set {
                    if (Normal_2_Rel_Spd_raw == value) return;
                    Normal_2_Rel_Spd_raw = value;
                    OnPropertyChanged(nameof(Normal_2_Rel_Spd));
                    OnPropertyChanged(nameof(Normal_2_Rel_Spd_button));
                }
            }

            [SortOrder(Normal_2_Rel_Spd_sortIndex)]
            [DisplayName(Normal_2_Rel_Spd_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Normal_2_Rel_Spd_button => ShellTable.reloadLookup.TryGet(Normal_2_Rel_Spd).ToStringWithId(Normal_2_Rel_Spd);

            protected byte Normal_3_Mag_Cnt_raw;
            public const string Normal_3_Mag_Cnt_displayName = "Normal 3 Mag Cnt";
            public const int Normal_3_Mag_Cnt_sortIndex = 350;
            [SortOrder(Normal_3_Mag_Cnt_sortIndex)]
            [DisplayName(Normal_3_Mag_Cnt_displayName)]
            public virtual byte Normal_3_Mag_Cnt {
                get => Normal_3_Mag_Cnt_raw;
                set {
                    if (Normal_3_Mag_Cnt_raw == value.Clamp((byte) 0, (byte) 10)) return;
                    Normal_3_Mag_Cnt_raw = value.Clamp((byte) 0, (byte) 10);
                    OnPropertyChanged(nameof(Normal_3_Mag_Cnt));
                }
            }

            protected byte Normal_3_Rec_Amnt_raw;
            public const string Normal_3_Rec_Amnt_displayName = "Normal 3 Rec Amnt";
            public const int Normal_3_Rec_Amnt_sortIndex = 400;
            [SortOrder(Normal_3_Rec_Amnt_sortIndex)]
            [DisplayName(Normal_3_Rec_Amnt_displayName)]
            [DataSource(DataSourceType.ShellRecoil)]
            public virtual byte Normal_3_Rec_Amnt {
                get => Normal_3_Rec_Amnt_raw;
                set {
                    if (Normal_3_Rec_Amnt_raw == value) return;
                    Normal_3_Rec_Amnt_raw = value;
                    OnPropertyChanged(nameof(Normal_3_Rec_Amnt));
                    OnPropertyChanged(nameof(Normal_3_Rec_Amnt_button));
                }
            }

            [SortOrder(Normal_3_Rec_Amnt_sortIndex)]
            [DisplayName(Normal_3_Rec_Amnt_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Normal_3_Rec_Amnt_button => ShellTable.recoilLookup.TryGet(Normal_3_Rec_Amnt).ToStringWithId(Normal_3_Rec_Amnt);

            protected byte Normal_3_Rel_Spd_raw;
            public const string Normal_3_Rel_Spd_displayName = "Normal 3 Rel Spd";
            public const int Normal_3_Rel_Spd_sortIndex = 450;
            [SortOrder(Normal_3_Rel_Spd_sortIndex)]
            [DisplayName(Normal_3_Rel_Spd_displayName)]
            [DataSource(DataSourceType.ShellReload)]
            public virtual byte Normal_3_Rel_Spd {
                get => Normal_3_Rel_Spd_raw;
                set {
                    if (Normal_3_Rel_Spd_raw == value) return;
                    Normal_3_Rel_Spd_raw = value;
                    OnPropertyChanged(nameof(Normal_3_Rel_Spd));
                    OnPropertyChanged(nameof(Normal_3_Rel_Spd_button));
                }
            }

            [SortOrder(Normal_3_Rel_Spd_sortIndex)]
            [DisplayName(Normal_3_Rel_Spd_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Normal_3_Rel_Spd_button => ShellTable.reloadLookup.TryGet(Normal_3_Rel_Spd).ToStringWithId(Normal_3_Rel_Spd);

            protected byte Pierce_1_Mag_Cnt_raw;
            public const string Pierce_1_Mag_Cnt_displayName = "Pierce 1 Mag Cnt";
            public const int Pierce_1_Mag_Cnt_sortIndex = 500;
            [SortOrder(Pierce_1_Mag_Cnt_sortIndex)]
            [DisplayName(Pierce_1_Mag_Cnt_displayName)]
            public virtual byte Pierce_1_Mag_Cnt {
                get => Pierce_1_Mag_Cnt_raw;
                set {
                    if (Pierce_1_Mag_Cnt_raw == value.Clamp((byte) 0, (byte) 10)) return;
                    Pierce_1_Mag_Cnt_raw = value.Clamp((byte) 0, (byte) 10);
                    OnPropertyChanged(nameof(Pierce_1_Mag_Cnt));
                }
            }

            protected byte Pierce_1_Rec_Amnt_raw;
            public const string Pierce_1_Rec_Amnt_displayName = "Pierce 1 Rec Amnt";
            public const int Pierce_1_Rec_Amnt_sortIndex = 550;
            [SortOrder(Pierce_1_Rec_Amnt_sortIndex)]
            [DisplayName(Pierce_1_Rec_Amnt_displayName)]
            [DataSource(DataSourceType.ShellRecoil)]
            public virtual byte Pierce_1_Rec_Amnt {
                get => Pierce_1_Rec_Amnt_raw;
                set {
                    if (Pierce_1_Rec_Amnt_raw == value) return;
                    Pierce_1_Rec_Amnt_raw = value;
                    OnPropertyChanged(nameof(Pierce_1_Rec_Amnt));
                    OnPropertyChanged(nameof(Pierce_1_Rec_Amnt_button));
                }
            }

            [SortOrder(Pierce_1_Rec_Amnt_sortIndex)]
            [DisplayName(Pierce_1_Rec_Amnt_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Pierce_1_Rec_Amnt_button => ShellTable.recoilLookup.TryGet(Pierce_1_Rec_Amnt).ToStringWithId(Pierce_1_Rec_Amnt);

            protected byte Pierce_1_Rel_Spd_raw;
            public const string Pierce_1_Rel_Spd_displayName = "Pierce 1 Rel Spd";
            public const int Pierce_1_Rel_Spd_sortIndex = 600;
            [SortOrder(Pierce_1_Rel_Spd_sortIndex)]
            [DisplayName(Pierce_1_Rel_Spd_displayName)]
            [DataSource(DataSourceType.ShellReload)]
            public virtual byte Pierce_1_Rel_Spd {
                get => Pierce_1_Rel_Spd_raw;
                set {
                    if (Pierce_1_Rel_Spd_raw == value) return;
                    Pierce_1_Rel_Spd_raw = value;
                    OnPropertyChanged(nameof(Pierce_1_Rel_Spd));
                    OnPropertyChanged(nameof(Pierce_1_Rel_Spd_button));
                }
            }

            [SortOrder(Pierce_1_Rel_Spd_sortIndex)]
            [DisplayName(Pierce_1_Rel_Spd_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Pierce_1_Rel_Spd_button => ShellTable.reloadLookup.TryGet(Pierce_1_Rel_Spd).ToStringWithId(Pierce_1_Rel_Spd);

            protected byte Pierce_2_Mag_Cnt_raw;
            public const string Pierce_2_Mag_Cnt_displayName = "Pierce 2 Mag Cnt";
            public const int Pierce_2_Mag_Cnt_sortIndex = 650;
            [SortOrder(Pierce_2_Mag_Cnt_sortIndex)]
            [DisplayName(Pierce_2_Mag_Cnt_displayName)]
            public virtual byte Pierce_2_Mag_Cnt {
                get => Pierce_2_Mag_Cnt_raw;
                set {
                    if (Pierce_2_Mag_Cnt_raw == value.Clamp((byte) 0, (byte) 10)) return;
                    Pierce_2_Mag_Cnt_raw = value.Clamp((byte) 0, (byte) 10);
                    OnPropertyChanged(nameof(Pierce_2_Mag_Cnt));
                }
            }

            protected byte Pierce_2_Rec_Amnt_raw;
            public const string Pierce_2_Rec_Amnt_displayName = "Pierce 2 Rec Amnt";
            public const int Pierce_2_Rec_Amnt_sortIndex = 700;
            [SortOrder(Pierce_2_Rec_Amnt_sortIndex)]
            [DisplayName(Pierce_2_Rec_Amnt_displayName)]
            [DataSource(DataSourceType.ShellRecoil)]
            public virtual byte Pierce_2_Rec_Amnt {
                get => Pierce_2_Rec_Amnt_raw;
                set {
                    if (Pierce_2_Rec_Amnt_raw == value) return;
                    Pierce_2_Rec_Amnt_raw = value;
                    OnPropertyChanged(nameof(Pierce_2_Rec_Amnt));
                    OnPropertyChanged(nameof(Pierce_2_Rec_Amnt_button));
                }
            }

            [SortOrder(Pierce_2_Rec_Amnt_sortIndex)]
            [DisplayName(Pierce_2_Rec_Amnt_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Pierce_2_Rec_Amnt_button => ShellTable.recoilLookup.TryGet(Pierce_2_Rec_Amnt).ToStringWithId(Pierce_2_Rec_Amnt);

            protected byte Pierce_2_Rel_Spd_raw;
            public const string Pierce_2_Rel_Spd_displayName = "Pierce 2 Rel Spd";
            public const int Pierce_2_Rel_Spd_sortIndex = 750;
            [SortOrder(Pierce_2_Rel_Spd_sortIndex)]
            [DisplayName(Pierce_2_Rel_Spd_displayName)]
            [DataSource(DataSourceType.ShellReload)]
            public virtual byte Pierce_2_Rel_Spd {
                get => Pierce_2_Rel_Spd_raw;
                set {
                    if (Pierce_2_Rel_Spd_raw == value) return;
                    Pierce_2_Rel_Spd_raw = value;
                    OnPropertyChanged(nameof(Pierce_2_Rel_Spd));
                    OnPropertyChanged(nameof(Pierce_2_Rel_Spd_button));
                }
            }

            [SortOrder(Pierce_2_Rel_Spd_sortIndex)]
            [DisplayName(Pierce_2_Rel_Spd_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Pierce_2_Rel_Spd_button => ShellTable.reloadLookup.TryGet(Pierce_2_Rel_Spd).ToStringWithId(Pierce_2_Rel_Spd);

            protected byte Pierce_3_Mag_Cnt_raw;
            public const string Pierce_3_Mag_Cnt_displayName = "Pierce 3 Mag Cnt";
            public const int Pierce_3_Mag_Cnt_sortIndex = 800;
            [SortOrder(Pierce_3_Mag_Cnt_sortIndex)]
            [DisplayName(Pierce_3_Mag_Cnt_displayName)]
            public virtual byte Pierce_3_Mag_Cnt {
                get => Pierce_3_Mag_Cnt_raw;
                set {
                    if (Pierce_3_Mag_Cnt_raw == value.Clamp((byte) 0, (byte) 10)) return;
                    Pierce_3_Mag_Cnt_raw = value.Clamp((byte) 0, (byte) 10);
                    OnPropertyChanged(nameof(Pierce_3_Mag_Cnt));
                }
            }

            protected byte Pierce_3_Rec_Amnt_raw;
            public const string Pierce_3_Rec_Amnt_displayName = "Pierce 3 Rec Amnt";
            public const int Pierce_3_Rec_Amnt_sortIndex = 850;
            [SortOrder(Pierce_3_Rec_Amnt_sortIndex)]
            [DisplayName(Pierce_3_Rec_Amnt_displayName)]
            [DataSource(DataSourceType.ShellRecoil)]
            public virtual byte Pierce_3_Rec_Amnt {
                get => Pierce_3_Rec_Amnt_raw;
                set {
                    if (Pierce_3_Rec_Amnt_raw == value) return;
                    Pierce_3_Rec_Amnt_raw = value;
                    OnPropertyChanged(nameof(Pierce_3_Rec_Amnt));
                    OnPropertyChanged(nameof(Pierce_3_Rec_Amnt_button));
                }
            }

            [SortOrder(Pierce_3_Rec_Amnt_sortIndex)]
            [DisplayName(Pierce_3_Rec_Amnt_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Pierce_3_Rec_Amnt_button => ShellTable.recoilLookup.TryGet(Pierce_3_Rec_Amnt).ToStringWithId(Pierce_3_Rec_Amnt);

            protected byte Pierce_3_Rel_Spd_raw;
            public const string Pierce_3_Rel_Spd_displayName = "Pierce 3 Rel Spd";
            public const int Pierce_3_Rel_Spd_sortIndex = 900;
            [SortOrder(Pierce_3_Rel_Spd_sortIndex)]
            [DisplayName(Pierce_3_Rel_Spd_displayName)]
            [DataSource(DataSourceType.ShellReload)]
            public virtual byte Pierce_3_Rel_Spd {
                get => Pierce_3_Rel_Spd_raw;
                set {
                    if (Pierce_3_Rel_Spd_raw == value) return;
                    Pierce_3_Rel_Spd_raw = value;
                    OnPropertyChanged(nameof(Pierce_3_Rel_Spd));
                    OnPropertyChanged(nameof(Pierce_3_Rel_Spd_button));
                }
            }

            [SortOrder(Pierce_3_Rel_Spd_sortIndex)]
            [DisplayName(Pierce_3_Rel_Spd_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Pierce_3_Rel_Spd_button => ShellTable.reloadLookup.TryGet(Pierce_3_Rel_Spd).ToStringWithId(Pierce_3_Rel_Spd);

            protected byte Spread_1_Mag_Cnt_raw;
            public const string Spread_1_Mag_Cnt_displayName = "Spread 1 Mag Cnt";
            public const int Spread_1_Mag_Cnt_sortIndex = 950;
            [SortOrder(Spread_1_Mag_Cnt_sortIndex)]
            [DisplayName(Spread_1_Mag_Cnt_displayName)]
            public virtual byte Spread_1_Mag_Cnt {
                get => Spread_1_Mag_Cnt_raw;
                set {
                    if (Spread_1_Mag_Cnt_raw == value.Clamp((byte) 0, (byte) 10)) return;
                    Spread_1_Mag_Cnt_raw = value.Clamp((byte) 0, (byte) 10);
                    OnPropertyChanged(nameof(Spread_1_Mag_Cnt));
                }
            }

            protected byte Spread_1_Rec_Amnt_raw;
            public const string Spread_1_Rec_Amnt_displayName = "Spread 1 Rec Amnt";
            public const int Spread_1_Rec_Amnt_sortIndex = 1000;
            [SortOrder(Spread_1_Rec_Amnt_sortIndex)]
            [DisplayName(Spread_1_Rec_Amnt_displayName)]
            [DataSource(DataSourceType.ShellRecoil)]
            public virtual byte Spread_1_Rec_Amnt {
                get => Spread_1_Rec_Amnt_raw;
                set {
                    if (Spread_1_Rec_Amnt_raw == value) return;
                    Spread_1_Rec_Amnt_raw = value;
                    OnPropertyChanged(nameof(Spread_1_Rec_Amnt));
                    OnPropertyChanged(nameof(Spread_1_Rec_Amnt_button));
                }
            }

            [SortOrder(Spread_1_Rec_Amnt_sortIndex)]
            [DisplayName(Spread_1_Rec_Amnt_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Spread_1_Rec_Amnt_button => ShellTable.recoilLookup.TryGet(Spread_1_Rec_Amnt).ToStringWithId(Spread_1_Rec_Amnt);

            protected byte Spread_1_Rel_Spd_raw;
            public const string Spread_1_Rel_Spd_displayName = "Spread 1 Rel Spd";
            public const int Spread_1_Rel_Spd_sortIndex = 1050;
            [SortOrder(Spread_1_Rel_Spd_sortIndex)]
            [DisplayName(Spread_1_Rel_Spd_displayName)]
            [DataSource(DataSourceType.ShellReload)]
            public virtual byte Spread_1_Rel_Spd {
                get => Spread_1_Rel_Spd_raw;
                set {
                    if (Spread_1_Rel_Spd_raw == value) return;
                    Spread_1_Rel_Spd_raw = value;
                    OnPropertyChanged(nameof(Spread_1_Rel_Spd));
                    OnPropertyChanged(nameof(Spread_1_Rel_Spd_button));
                }
            }

            [SortOrder(Spread_1_Rel_Spd_sortIndex)]
            [DisplayName(Spread_1_Rel_Spd_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Spread_1_Rel_Spd_button => ShellTable.reloadLookup.TryGet(Spread_1_Rel_Spd).ToStringWithId(Spread_1_Rel_Spd);

            protected byte Spread_2_Mag_Cnt_raw;
            public const string Spread_2_Mag_Cnt_displayName = "Spread 2 Mag Cnt";
            public const int Spread_2_Mag_Cnt_sortIndex = 1100;
            [SortOrder(Spread_2_Mag_Cnt_sortIndex)]
            [DisplayName(Spread_2_Mag_Cnt_displayName)]
            public virtual byte Spread_2_Mag_Cnt {
                get => Spread_2_Mag_Cnt_raw;
                set {
                    if (Spread_2_Mag_Cnt_raw == value.Clamp((byte) 0, (byte) 10)) return;
                    Spread_2_Mag_Cnt_raw = value.Clamp((byte) 0, (byte) 10);
                    OnPropertyChanged(nameof(Spread_2_Mag_Cnt));
                }
            }

            protected byte Spread_2_Rec_Amnt_raw;
            public const string Spread_2_Rec_Amnt_displayName = "Spread 2 Rec Amnt";
            public const int Spread_2_Rec_Amnt_sortIndex = 1150;
            [SortOrder(Spread_2_Rec_Amnt_sortIndex)]
            [DisplayName(Spread_2_Rec_Amnt_displayName)]
            [DataSource(DataSourceType.ShellRecoil)]
            public virtual byte Spread_2_Rec_Amnt {
                get => Spread_2_Rec_Amnt_raw;
                set {
                    if (Spread_2_Rec_Amnt_raw == value) return;
                    Spread_2_Rec_Amnt_raw = value;
                    OnPropertyChanged(nameof(Spread_2_Rec_Amnt));
                    OnPropertyChanged(nameof(Spread_2_Rec_Amnt_button));
                }
            }

            [SortOrder(Spread_2_Rec_Amnt_sortIndex)]
            [DisplayName(Spread_2_Rec_Amnt_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Spread_2_Rec_Amnt_button => ShellTable.recoilLookup.TryGet(Spread_2_Rec_Amnt).ToStringWithId(Spread_2_Rec_Amnt);

            protected byte Spread_2_Rel_Spd_raw;
            public const string Spread_2_Rel_Spd_displayName = "Spread 2 Rel Spd";
            public const int Spread_2_Rel_Spd_sortIndex = 1200;
            [SortOrder(Spread_2_Rel_Spd_sortIndex)]
            [DisplayName(Spread_2_Rel_Spd_displayName)]
            [DataSource(DataSourceType.ShellReload)]
            public virtual byte Spread_2_Rel_Spd {
                get => Spread_2_Rel_Spd_raw;
                set {
                    if (Spread_2_Rel_Spd_raw == value) return;
                    Spread_2_Rel_Spd_raw = value;
                    OnPropertyChanged(nameof(Spread_2_Rel_Spd));
                    OnPropertyChanged(nameof(Spread_2_Rel_Spd_button));
                }
            }

            [SortOrder(Spread_2_Rel_Spd_sortIndex)]
            [DisplayName(Spread_2_Rel_Spd_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Spread_2_Rel_Spd_button => ShellTable.reloadLookup.TryGet(Spread_2_Rel_Spd).ToStringWithId(Spread_2_Rel_Spd);

            protected byte Spread_3_Mag_Cnt_raw;
            public const string Spread_3_Mag_Cnt_displayName = "Spread 3 Mag Cnt";
            public const int Spread_3_Mag_Cnt_sortIndex = 1250;
            [SortOrder(Spread_3_Mag_Cnt_sortIndex)]
            [DisplayName(Spread_3_Mag_Cnt_displayName)]
            public virtual byte Spread_3_Mag_Cnt {
                get => Spread_3_Mag_Cnt_raw;
                set {
                    if (Spread_3_Mag_Cnt_raw == value.Clamp((byte) 0, (byte) 10)) return;
                    Spread_3_Mag_Cnt_raw = value.Clamp((byte) 0, (byte) 10);
                    OnPropertyChanged(nameof(Spread_3_Mag_Cnt));
                }
            }

            protected byte Spread_3_Rec_Amnt_raw;
            public const string Spread_3_Rec_Amnt_displayName = "Spread 3 Rec Amnt";
            public const int Spread_3_Rec_Amnt_sortIndex = 1300;
            [SortOrder(Spread_3_Rec_Amnt_sortIndex)]
            [DisplayName(Spread_3_Rec_Amnt_displayName)]
            [DataSource(DataSourceType.ShellRecoil)]
            public virtual byte Spread_3_Rec_Amnt {
                get => Spread_3_Rec_Amnt_raw;
                set {
                    if (Spread_3_Rec_Amnt_raw == value) return;
                    Spread_3_Rec_Amnt_raw = value;
                    OnPropertyChanged(nameof(Spread_3_Rec_Amnt));
                    OnPropertyChanged(nameof(Spread_3_Rec_Amnt_button));
                }
            }

            [SortOrder(Spread_3_Rec_Amnt_sortIndex)]
            [DisplayName(Spread_3_Rec_Amnt_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Spread_3_Rec_Amnt_button => ShellTable.recoilLookup.TryGet(Spread_3_Rec_Amnt).ToStringWithId(Spread_3_Rec_Amnt);

            protected byte Spread_3_Rel_Spd_raw;
            public const string Spread_3_Rel_Spd_displayName = "Spread 3 Rel Spd";
            public const int Spread_3_Rel_Spd_sortIndex = 1350;
            [SortOrder(Spread_3_Rel_Spd_sortIndex)]
            [DisplayName(Spread_3_Rel_Spd_displayName)]
            [DataSource(DataSourceType.ShellReload)]
            public virtual byte Spread_3_Rel_Spd {
                get => Spread_3_Rel_Spd_raw;
                set {
                    if (Spread_3_Rel_Spd_raw == value) return;
                    Spread_3_Rel_Spd_raw = value;
                    OnPropertyChanged(nameof(Spread_3_Rel_Spd));
                    OnPropertyChanged(nameof(Spread_3_Rel_Spd_button));
                }
            }

            [SortOrder(Spread_3_Rel_Spd_sortIndex)]
            [DisplayName(Spread_3_Rel_Spd_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Spread_3_Rel_Spd_button => ShellTable.reloadLookup.TryGet(Spread_3_Rel_Spd).ToStringWithId(Spread_3_Rel_Spd);

            protected byte Cluster_1_Mag_Cnt_raw;
            public const string Cluster_1_Mag_Cnt_displayName = "Cluster 1 Mag Cnt";
            public const int Cluster_1_Mag_Cnt_sortIndex = 1400;
            [SortOrder(Cluster_1_Mag_Cnt_sortIndex)]
            [DisplayName(Cluster_1_Mag_Cnt_displayName)]
            public virtual byte Cluster_1_Mag_Cnt {
                get => Cluster_1_Mag_Cnt_raw;
                set {
                    if (Cluster_1_Mag_Cnt_raw == value.Clamp((byte) 0, (byte) 10)) return;
                    Cluster_1_Mag_Cnt_raw = value.Clamp((byte) 0, (byte) 10);
                    OnPropertyChanged(nameof(Cluster_1_Mag_Cnt));
                }
            }

            protected byte Cluster_1_Rec_Amnt_raw;
            public const string Cluster_1_Rec_Amnt_displayName = "Cluster 1 Rec Amnt";
            public const int Cluster_1_Rec_Amnt_sortIndex = 1450;
            [SortOrder(Cluster_1_Rec_Amnt_sortIndex)]
            [DisplayName(Cluster_1_Rec_Amnt_displayName)]
            [DataSource(DataSourceType.ShellRecoil)]
            public virtual byte Cluster_1_Rec_Amnt {
                get => Cluster_1_Rec_Amnt_raw;
                set {
                    if (Cluster_1_Rec_Amnt_raw == value) return;
                    Cluster_1_Rec_Amnt_raw = value;
                    OnPropertyChanged(nameof(Cluster_1_Rec_Amnt));
                    OnPropertyChanged(nameof(Cluster_1_Rec_Amnt_button));
                }
            }

            [SortOrder(Cluster_1_Rec_Amnt_sortIndex)]
            [DisplayName(Cluster_1_Rec_Amnt_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Cluster_1_Rec_Amnt_button => ShellTable.recoilLookup.TryGet(Cluster_1_Rec_Amnt).ToStringWithId(Cluster_1_Rec_Amnt);

            protected byte Cluster_1_Rel_Spd_raw;
            public const string Cluster_1_Rel_Spd_displayName = "Cluster 1 Rel Spd";
            public const int Cluster_1_Rel_Spd_sortIndex = 1500;
            [SortOrder(Cluster_1_Rel_Spd_sortIndex)]
            [DisplayName(Cluster_1_Rel_Spd_displayName)]
            [DataSource(DataSourceType.ShellReload)]
            public virtual byte Cluster_1_Rel_Spd {
                get => Cluster_1_Rel_Spd_raw;
                set {
                    if (Cluster_1_Rel_Spd_raw == value) return;
                    Cluster_1_Rel_Spd_raw = value;
                    OnPropertyChanged(nameof(Cluster_1_Rel_Spd));
                    OnPropertyChanged(nameof(Cluster_1_Rel_Spd_button));
                }
            }

            [SortOrder(Cluster_1_Rel_Spd_sortIndex)]
            [DisplayName(Cluster_1_Rel_Spd_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Cluster_1_Rel_Spd_button => ShellTable.reloadLookup.TryGet(Cluster_1_Rel_Spd).ToStringWithId(Cluster_1_Rel_Spd);

            protected byte Cluster_2_Mag_Cnt_raw;
            public const string Cluster_2_Mag_Cnt_displayName = "Cluster 2 Mag Cnt";
            public const int Cluster_2_Mag_Cnt_sortIndex = 1550;
            [SortOrder(Cluster_2_Mag_Cnt_sortIndex)]
            [DisplayName(Cluster_2_Mag_Cnt_displayName)]
            public virtual byte Cluster_2_Mag_Cnt {
                get => Cluster_2_Mag_Cnt_raw;
                set {
                    if (Cluster_2_Mag_Cnt_raw == value.Clamp((byte) 0, (byte) 10)) return;
                    Cluster_2_Mag_Cnt_raw = value.Clamp((byte) 0, (byte) 10);
                    OnPropertyChanged(nameof(Cluster_2_Mag_Cnt));
                }
            }

            protected byte Cluster_2_Rec_Amnt_raw;
            public const string Cluster_2_Rec_Amnt_displayName = "Cluster 2 Rec Amnt";
            public const int Cluster_2_Rec_Amnt_sortIndex = 1600;
            [SortOrder(Cluster_2_Rec_Amnt_sortIndex)]
            [DisplayName(Cluster_2_Rec_Amnt_displayName)]
            [DataSource(DataSourceType.ShellRecoil)]
            public virtual byte Cluster_2_Rec_Amnt {
                get => Cluster_2_Rec_Amnt_raw;
                set {
                    if (Cluster_2_Rec_Amnt_raw == value) return;
                    Cluster_2_Rec_Amnt_raw = value;
                    OnPropertyChanged(nameof(Cluster_2_Rec_Amnt));
                    OnPropertyChanged(nameof(Cluster_2_Rec_Amnt_button));
                }
            }

            [SortOrder(Cluster_2_Rec_Amnt_sortIndex)]
            [DisplayName(Cluster_2_Rec_Amnt_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Cluster_2_Rec_Amnt_button => ShellTable.recoilLookup.TryGet(Cluster_2_Rec_Amnt).ToStringWithId(Cluster_2_Rec_Amnt);

            protected byte Cluster_2_Rel_Spd_raw;
            public const string Cluster_2_Rel_Spd_displayName = "Cluster 2 Rel Spd";
            public const int Cluster_2_Rel_Spd_sortIndex = 1650;
            [SortOrder(Cluster_2_Rel_Spd_sortIndex)]
            [DisplayName(Cluster_2_Rel_Spd_displayName)]
            [DataSource(DataSourceType.ShellReload)]
            public virtual byte Cluster_2_Rel_Spd {
                get => Cluster_2_Rel_Spd_raw;
                set {
                    if (Cluster_2_Rel_Spd_raw == value) return;
                    Cluster_2_Rel_Spd_raw = value;
                    OnPropertyChanged(nameof(Cluster_2_Rel_Spd));
                    OnPropertyChanged(nameof(Cluster_2_Rel_Spd_button));
                }
            }

            [SortOrder(Cluster_2_Rel_Spd_sortIndex)]
            [DisplayName(Cluster_2_Rel_Spd_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Cluster_2_Rel_Spd_button => ShellTable.reloadLookup.TryGet(Cluster_2_Rel_Spd).ToStringWithId(Cluster_2_Rel_Spd);

            protected byte Cluster_3_Mag_Cnt_raw;
            public const string Cluster_3_Mag_Cnt_displayName = "Cluster 3 Mag Cnt";
            public const int Cluster_3_Mag_Cnt_sortIndex = 1700;
            [SortOrder(Cluster_3_Mag_Cnt_sortIndex)]
            [DisplayName(Cluster_3_Mag_Cnt_displayName)]
            public virtual byte Cluster_3_Mag_Cnt {
                get => Cluster_3_Mag_Cnt_raw;
                set {
                    if (Cluster_3_Mag_Cnt_raw == value.Clamp((byte) 0, (byte) 10)) return;
                    Cluster_3_Mag_Cnt_raw = value.Clamp((byte) 0, (byte) 10);
                    OnPropertyChanged(nameof(Cluster_3_Mag_Cnt));
                }
            }

            protected byte Cluster_3_Rec_Amnt_raw;
            public const string Cluster_3_Rec_Amnt_displayName = "Cluster 3 Rec Amnt";
            public const int Cluster_3_Rec_Amnt_sortIndex = 1750;
            [SortOrder(Cluster_3_Rec_Amnt_sortIndex)]
            [DisplayName(Cluster_3_Rec_Amnt_displayName)]
            [DataSource(DataSourceType.ShellRecoil)]
            public virtual byte Cluster_3_Rec_Amnt {
                get => Cluster_3_Rec_Amnt_raw;
                set {
                    if (Cluster_3_Rec_Amnt_raw == value) return;
                    Cluster_3_Rec_Amnt_raw = value;
                    OnPropertyChanged(nameof(Cluster_3_Rec_Amnt));
                    OnPropertyChanged(nameof(Cluster_3_Rec_Amnt_button));
                }
            }

            [SortOrder(Cluster_3_Rec_Amnt_sortIndex)]
            [DisplayName(Cluster_3_Rec_Amnt_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Cluster_3_Rec_Amnt_button => ShellTable.recoilLookup.TryGet(Cluster_3_Rec_Amnt).ToStringWithId(Cluster_3_Rec_Amnt);

            protected byte Cluster_3_Rel_Spd_raw;
            public const string Cluster_3_Rel_Spd_displayName = "Cluster 3 Rel Spd";
            public const int Cluster_3_Rel_Spd_sortIndex = 1800;
            [SortOrder(Cluster_3_Rel_Spd_sortIndex)]
            [DisplayName(Cluster_3_Rel_Spd_displayName)]
            [DataSource(DataSourceType.ShellReload)]
            public virtual byte Cluster_3_Rel_Spd {
                get => Cluster_3_Rel_Spd_raw;
                set {
                    if (Cluster_3_Rel_Spd_raw == value) return;
                    Cluster_3_Rel_Spd_raw = value;
                    OnPropertyChanged(nameof(Cluster_3_Rel_Spd));
                    OnPropertyChanged(nameof(Cluster_3_Rel_Spd_button));
                }
            }

            [SortOrder(Cluster_3_Rel_Spd_sortIndex)]
            [DisplayName(Cluster_3_Rel_Spd_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Cluster_3_Rel_Spd_button => ShellTable.reloadLookup.TryGet(Cluster_3_Rel_Spd).ToStringWithId(Cluster_3_Rel_Spd);

            protected byte Wyvern_Mag_Cnt_raw;
            public const string Wyvern_Mag_Cnt_displayName = "Wyvern Mag Cnt";
            public const int Wyvern_Mag_Cnt_sortIndex = 1850;
            [SortOrder(Wyvern_Mag_Cnt_sortIndex)]
            [DisplayName(Wyvern_Mag_Cnt_displayName)]
            public virtual byte Wyvern_Mag_Cnt {
                get => Wyvern_Mag_Cnt_raw;
                set {
                    if (Wyvern_Mag_Cnt_raw == value.Clamp((byte) 0, (byte) 10)) return;
                    Wyvern_Mag_Cnt_raw = value.Clamp((byte) 0, (byte) 10);
                    OnPropertyChanged(nameof(Wyvern_Mag_Cnt));
                }
            }

            protected byte Wyvern_Rec_Amnt_raw;
            public const string Wyvern_Rec_Amnt_displayName = "Wyvern Rec Amnt";
            public const int Wyvern_Rec_Amnt_sortIndex = 1900;
            [SortOrder(Wyvern_Rec_Amnt_sortIndex)]
            [DisplayName(Wyvern_Rec_Amnt_displayName)]
            [DataSource(DataSourceType.ShellRecoil)]
            public virtual byte Wyvern_Rec_Amnt {
                get => Wyvern_Rec_Amnt_raw;
                set {
                    if (Wyvern_Rec_Amnt_raw == value) return;
                    Wyvern_Rec_Amnt_raw = value;
                    OnPropertyChanged(nameof(Wyvern_Rec_Amnt));
                    OnPropertyChanged(nameof(Wyvern_Rec_Amnt_button));
                }
            }

            [SortOrder(Wyvern_Rec_Amnt_sortIndex)]
            [DisplayName(Wyvern_Rec_Amnt_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Wyvern_Rec_Amnt_button => ShellTable.recoilLookup.TryGet(Wyvern_Rec_Amnt).ToStringWithId(Wyvern_Rec_Amnt);

            protected byte Wyvern_Rel_Spd_raw;
            public const string Wyvern_Rel_Spd_displayName = "Wyvern Rel Spd";
            public const int Wyvern_Rel_Spd_sortIndex = 1950;
            [SortOrder(Wyvern_Rel_Spd_sortIndex)]
            [DisplayName(Wyvern_Rel_Spd_displayName)]
            [DataSource(DataSourceType.ShellReload)]
            public virtual byte Wyvern_Rel_Spd {
                get => Wyvern_Rel_Spd_raw;
                set {
                    if (Wyvern_Rel_Spd_raw == value) return;
                    Wyvern_Rel_Spd_raw = value;
                    OnPropertyChanged(nameof(Wyvern_Rel_Spd));
                    OnPropertyChanged(nameof(Wyvern_Rel_Spd_button));
                }
            }

            [SortOrder(Wyvern_Rel_Spd_sortIndex)]
            [DisplayName(Wyvern_Rel_Spd_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Wyvern_Rel_Spd_button => ShellTable.reloadLookup.TryGet(Wyvern_Rel_Spd).ToStringWithId(Wyvern_Rel_Spd);

            protected byte Sticky_1_Mag_Cnt_raw;
            public const string Sticky_1_Mag_Cnt_displayName = "Sticky 1 Mag Cnt";
            public const int Sticky_1_Mag_Cnt_sortIndex = 2000;
            [SortOrder(Sticky_1_Mag_Cnt_sortIndex)]
            [DisplayName(Sticky_1_Mag_Cnt_displayName)]
            public virtual byte Sticky_1_Mag_Cnt {
                get => Sticky_1_Mag_Cnt_raw;
                set {
                    if (Sticky_1_Mag_Cnt_raw == value.Clamp((byte) 0, (byte) 10)) return;
                    Sticky_1_Mag_Cnt_raw = value.Clamp((byte) 0, (byte) 10);
                    OnPropertyChanged(nameof(Sticky_1_Mag_Cnt));
                }
            }

            protected byte Sticky_1_Rec_Amnt_raw;
            public const string Sticky_1_Rec_Amnt_displayName = "Sticky 1 Rec Amnt";
            public const int Sticky_1_Rec_Amnt_sortIndex = 2050;
            [SortOrder(Sticky_1_Rec_Amnt_sortIndex)]
            [DisplayName(Sticky_1_Rec_Amnt_displayName)]
            [DataSource(DataSourceType.ShellRecoil)]
            public virtual byte Sticky_1_Rec_Amnt {
                get => Sticky_1_Rec_Amnt_raw;
                set {
                    if (Sticky_1_Rec_Amnt_raw == value) return;
                    Sticky_1_Rec_Amnt_raw = value;
                    OnPropertyChanged(nameof(Sticky_1_Rec_Amnt));
                    OnPropertyChanged(nameof(Sticky_1_Rec_Amnt_button));
                }
            }

            [SortOrder(Sticky_1_Rec_Amnt_sortIndex)]
            [DisplayName(Sticky_1_Rec_Amnt_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Sticky_1_Rec_Amnt_button => ShellTable.recoilLookup.TryGet(Sticky_1_Rec_Amnt).ToStringWithId(Sticky_1_Rec_Amnt);

            protected byte Sticky_1_Rel_Spd_raw;
            public const string Sticky_1_Rel_Spd_displayName = "Sticky 1 Rel Spd";
            public const int Sticky_1_Rel_Spd_sortIndex = 2100;
            [SortOrder(Sticky_1_Rel_Spd_sortIndex)]
            [DisplayName(Sticky_1_Rel_Spd_displayName)]
            [DataSource(DataSourceType.ShellReload)]
            public virtual byte Sticky_1_Rel_Spd {
                get => Sticky_1_Rel_Spd_raw;
                set {
                    if (Sticky_1_Rel_Spd_raw == value) return;
                    Sticky_1_Rel_Spd_raw = value;
                    OnPropertyChanged(nameof(Sticky_1_Rel_Spd));
                    OnPropertyChanged(nameof(Sticky_1_Rel_Spd_button));
                }
            }

            [SortOrder(Sticky_1_Rel_Spd_sortIndex)]
            [DisplayName(Sticky_1_Rel_Spd_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Sticky_1_Rel_Spd_button => ShellTable.reloadLookup.TryGet(Sticky_1_Rel_Spd).ToStringWithId(Sticky_1_Rel_Spd);

            protected byte Sticky_2_Mag_Cnt_raw;
            public const string Sticky_2_Mag_Cnt_displayName = "Sticky 2 Mag Cnt";
            public const int Sticky_2_Mag_Cnt_sortIndex = 2150;
            [SortOrder(Sticky_2_Mag_Cnt_sortIndex)]
            [DisplayName(Sticky_2_Mag_Cnt_displayName)]
            public virtual byte Sticky_2_Mag_Cnt {
                get => Sticky_2_Mag_Cnt_raw;
                set {
                    if (Sticky_2_Mag_Cnt_raw == value.Clamp((byte) 0, (byte) 10)) return;
                    Sticky_2_Mag_Cnt_raw = value.Clamp((byte) 0, (byte) 10);
                    OnPropertyChanged(nameof(Sticky_2_Mag_Cnt));
                }
            }

            protected byte Sticky_2_Rec_Amnt_raw;
            public const string Sticky_2_Rec_Amnt_displayName = "Sticky 2 Rec Amnt";
            public const int Sticky_2_Rec_Amnt_sortIndex = 2200;
            [SortOrder(Sticky_2_Rec_Amnt_sortIndex)]
            [DisplayName(Sticky_2_Rec_Amnt_displayName)]
            [DataSource(DataSourceType.ShellRecoil)]
            public virtual byte Sticky_2_Rec_Amnt {
                get => Sticky_2_Rec_Amnt_raw;
                set {
                    if (Sticky_2_Rec_Amnt_raw == value) return;
                    Sticky_2_Rec_Amnt_raw = value;
                    OnPropertyChanged(nameof(Sticky_2_Rec_Amnt));
                    OnPropertyChanged(nameof(Sticky_2_Rec_Amnt_button));
                }
            }

            [SortOrder(Sticky_2_Rec_Amnt_sortIndex)]
            [DisplayName(Sticky_2_Rec_Amnt_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Sticky_2_Rec_Amnt_button => ShellTable.recoilLookup.TryGet(Sticky_2_Rec_Amnt).ToStringWithId(Sticky_2_Rec_Amnt);

            protected byte Sticky_2_Rel_Spd_raw;
            public const string Sticky_2_Rel_Spd_displayName = "Sticky 2 Rel Spd";
            public const int Sticky_2_Rel_Spd_sortIndex = 2250;
            [SortOrder(Sticky_2_Rel_Spd_sortIndex)]
            [DisplayName(Sticky_2_Rel_Spd_displayName)]
            [DataSource(DataSourceType.ShellReload)]
            public virtual byte Sticky_2_Rel_Spd {
                get => Sticky_2_Rel_Spd_raw;
                set {
                    if (Sticky_2_Rel_Spd_raw == value) return;
                    Sticky_2_Rel_Spd_raw = value;
                    OnPropertyChanged(nameof(Sticky_2_Rel_Spd));
                    OnPropertyChanged(nameof(Sticky_2_Rel_Spd_button));
                }
            }

            [SortOrder(Sticky_2_Rel_Spd_sortIndex)]
            [DisplayName(Sticky_2_Rel_Spd_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Sticky_2_Rel_Spd_button => ShellTable.reloadLookup.TryGet(Sticky_2_Rel_Spd).ToStringWithId(Sticky_2_Rel_Spd);

            protected byte Sticky_3_Mag_Cnt_raw;
            public const string Sticky_3_Mag_Cnt_displayName = "Sticky 3 Mag Cnt";
            public const int Sticky_3_Mag_Cnt_sortIndex = 2300;
            [SortOrder(Sticky_3_Mag_Cnt_sortIndex)]
            [DisplayName(Sticky_3_Mag_Cnt_displayName)]
            public virtual byte Sticky_3_Mag_Cnt {
                get => Sticky_3_Mag_Cnt_raw;
                set {
                    if (Sticky_3_Mag_Cnt_raw == value.Clamp((byte) 0, (byte) 10)) return;
                    Sticky_3_Mag_Cnt_raw = value.Clamp((byte) 0, (byte) 10);
                    OnPropertyChanged(nameof(Sticky_3_Mag_Cnt));
                }
            }

            protected byte Sticky_3_Rec_Amnt_raw;
            public const string Sticky_3_Rec_Amnt_displayName = "Sticky 3 Rec Amnt";
            public const int Sticky_3_Rec_Amnt_sortIndex = 2350;
            [SortOrder(Sticky_3_Rec_Amnt_sortIndex)]
            [DisplayName(Sticky_3_Rec_Amnt_displayName)]
            [DataSource(DataSourceType.ShellRecoil)]
            public virtual byte Sticky_3_Rec_Amnt {
                get => Sticky_3_Rec_Amnt_raw;
                set {
                    if (Sticky_3_Rec_Amnt_raw == value) return;
                    Sticky_3_Rec_Amnt_raw = value;
                    OnPropertyChanged(nameof(Sticky_3_Rec_Amnt));
                    OnPropertyChanged(nameof(Sticky_3_Rec_Amnt_button));
                }
            }

            [SortOrder(Sticky_3_Rec_Amnt_sortIndex)]
            [DisplayName(Sticky_3_Rec_Amnt_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Sticky_3_Rec_Amnt_button => ShellTable.recoilLookup.TryGet(Sticky_3_Rec_Amnt).ToStringWithId(Sticky_3_Rec_Amnt);

            protected byte Sticky_3_Rel_Spd_raw;
            public const string Sticky_3_Rel_Spd_displayName = "Sticky 3 Rel Spd";
            public const int Sticky_3_Rel_Spd_sortIndex = 2400;
            [SortOrder(Sticky_3_Rel_Spd_sortIndex)]
            [DisplayName(Sticky_3_Rel_Spd_displayName)]
            [DataSource(DataSourceType.ShellReload)]
            public virtual byte Sticky_3_Rel_Spd {
                get => Sticky_3_Rel_Spd_raw;
                set {
                    if (Sticky_3_Rel_Spd_raw == value) return;
                    Sticky_3_Rel_Spd_raw = value;
                    OnPropertyChanged(nameof(Sticky_3_Rel_Spd));
                    OnPropertyChanged(nameof(Sticky_3_Rel_Spd_button));
                }
            }

            [SortOrder(Sticky_3_Rel_Spd_sortIndex)]
            [DisplayName(Sticky_3_Rel_Spd_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Sticky_3_Rel_Spd_button => ShellTable.reloadLookup.TryGet(Sticky_3_Rel_Spd).ToStringWithId(Sticky_3_Rel_Spd);

            protected byte Slicing_Mag_Cnt_raw;
            public const string Slicing_Mag_Cnt_displayName = "Slicing Mag Cnt";
            public const int Slicing_Mag_Cnt_sortIndex = 2450;
            [SortOrder(Slicing_Mag_Cnt_sortIndex)]
            [DisplayName(Slicing_Mag_Cnt_displayName)]
            public virtual byte Slicing_Mag_Cnt {
                get => Slicing_Mag_Cnt_raw;
                set {
                    if (Slicing_Mag_Cnt_raw == value.Clamp((byte) 0, (byte) 10)) return;
                    Slicing_Mag_Cnt_raw = value.Clamp((byte) 0, (byte) 10);
                    OnPropertyChanged(nameof(Slicing_Mag_Cnt));
                }
            }

            protected byte Slicing_Rec_Amnt_raw;
            public const string Slicing_Rec_Amnt_displayName = "Slicing Rec Amnt";
            public const int Slicing_Rec_Amnt_sortIndex = 2500;
            [SortOrder(Slicing_Rec_Amnt_sortIndex)]
            [DisplayName(Slicing_Rec_Amnt_displayName)]
            [DataSource(DataSourceType.ShellRecoil)]
            public virtual byte Slicing_Rec_Amnt {
                get => Slicing_Rec_Amnt_raw;
                set {
                    if (Slicing_Rec_Amnt_raw == value) return;
                    Slicing_Rec_Amnt_raw = value;
                    OnPropertyChanged(nameof(Slicing_Rec_Amnt));
                    OnPropertyChanged(nameof(Slicing_Rec_Amnt_button));
                }
            }

            [SortOrder(Slicing_Rec_Amnt_sortIndex)]
            [DisplayName(Slicing_Rec_Amnt_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Slicing_Rec_Amnt_button => ShellTable.recoilLookup.TryGet(Slicing_Rec_Amnt).ToStringWithId(Slicing_Rec_Amnt);

            protected byte Slicing_Rel_Spd_raw;
            public const string Slicing_Rel_Spd_displayName = "Slicing Rel Spd";
            public const int Slicing_Rel_Spd_sortIndex = 2550;
            [SortOrder(Slicing_Rel_Spd_sortIndex)]
            [DisplayName(Slicing_Rel_Spd_displayName)]
            [DataSource(DataSourceType.ShellReload)]
            public virtual byte Slicing_Rel_Spd {
                get => Slicing_Rel_Spd_raw;
                set {
                    if (Slicing_Rel_Spd_raw == value) return;
                    Slicing_Rel_Spd_raw = value;
                    OnPropertyChanged(nameof(Slicing_Rel_Spd));
                    OnPropertyChanged(nameof(Slicing_Rel_Spd_button));
                }
            }

            [SortOrder(Slicing_Rel_Spd_sortIndex)]
            [DisplayName(Slicing_Rel_Spd_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Slicing_Rel_Spd_button => ShellTable.reloadLookup.TryGet(Slicing_Rel_Spd).ToStringWithId(Slicing_Rel_Spd);

            protected byte Flaming_Mag_Cnt_raw;
            public const string Flaming_Mag_Cnt_displayName = "Flaming Mag Cnt";
            public const int Flaming_Mag_Cnt_sortIndex = 2600;
            [SortOrder(Flaming_Mag_Cnt_sortIndex)]
            [DisplayName(Flaming_Mag_Cnt_displayName)]
            public virtual byte Flaming_Mag_Cnt {
                get => Flaming_Mag_Cnt_raw;
                set {
                    if (Flaming_Mag_Cnt_raw == value.Clamp((byte) 0, (byte) 10)) return;
                    Flaming_Mag_Cnt_raw = value.Clamp((byte) 0, (byte) 10);
                    OnPropertyChanged(nameof(Flaming_Mag_Cnt));
                }
            }

            protected byte Flaming_Rec_Amnt_raw;
            public const string Flaming_Rec_Amnt_displayName = "Flaming Rec Amnt";
            public const int Flaming_Rec_Amnt_sortIndex = 2650;
            [SortOrder(Flaming_Rec_Amnt_sortIndex)]
            [DisplayName(Flaming_Rec_Amnt_displayName)]
            [DataSource(DataSourceType.ShellRecoil)]
            public virtual byte Flaming_Rec_Amnt {
                get => Flaming_Rec_Amnt_raw;
                set {
                    if (Flaming_Rec_Amnt_raw == value) return;
                    Flaming_Rec_Amnt_raw = value;
                    OnPropertyChanged(nameof(Flaming_Rec_Amnt));
                    OnPropertyChanged(nameof(Flaming_Rec_Amnt_button));
                }
            }

            [SortOrder(Flaming_Rec_Amnt_sortIndex)]
            [DisplayName(Flaming_Rec_Amnt_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Flaming_Rec_Amnt_button => ShellTable.recoilLookup.TryGet(Flaming_Rec_Amnt).ToStringWithId(Flaming_Rec_Amnt);

            protected byte Flaming_Rel_Spd_raw;
            public const string Flaming_Rel_Spd_displayName = "Flaming Rel Spd";
            public const int Flaming_Rel_Spd_sortIndex = 2700;
            [SortOrder(Flaming_Rel_Spd_sortIndex)]
            [DisplayName(Flaming_Rel_Spd_displayName)]
            [DataSource(DataSourceType.ShellReload)]
            public virtual byte Flaming_Rel_Spd {
                get => Flaming_Rel_Spd_raw;
                set {
                    if (Flaming_Rel_Spd_raw == value) return;
                    Flaming_Rel_Spd_raw = value;
                    OnPropertyChanged(nameof(Flaming_Rel_Spd));
                    OnPropertyChanged(nameof(Flaming_Rel_Spd_button));
                }
            }

            [SortOrder(Flaming_Rel_Spd_sortIndex)]
            [DisplayName(Flaming_Rel_Spd_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Flaming_Rel_Spd_button => ShellTable.reloadLookup.TryGet(Flaming_Rel_Spd).ToStringWithId(Flaming_Rel_Spd);

            protected byte Water_Mag_Cnt_raw;
            public const string Water_Mag_Cnt_displayName = "Water Mag Cnt";
            public const int Water_Mag_Cnt_sortIndex = 2750;
            [SortOrder(Water_Mag_Cnt_sortIndex)]
            [DisplayName(Water_Mag_Cnt_displayName)]
            public virtual byte Water_Mag_Cnt {
                get => Water_Mag_Cnt_raw;
                set {
                    if (Water_Mag_Cnt_raw == value.Clamp((byte) 0, (byte) 10)) return;
                    Water_Mag_Cnt_raw = value.Clamp((byte) 0, (byte) 10);
                    OnPropertyChanged(nameof(Water_Mag_Cnt));
                }
            }

            protected byte Water_Rec_Amnt_raw;
            public const string Water_Rec_Amnt_displayName = "Water Rec Amnt";
            public const int Water_Rec_Amnt_sortIndex = 2800;
            [SortOrder(Water_Rec_Amnt_sortIndex)]
            [DisplayName(Water_Rec_Amnt_displayName)]
            [DataSource(DataSourceType.ShellRecoil)]
            public virtual byte Water_Rec_Amnt {
                get => Water_Rec_Amnt_raw;
                set {
                    if (Water_Rec_Amnt_raw == value) return;
                    Water_Rec_Amnt_raw = value;
                    OnPropertyChanged(nameof(Water_Rec_Amnt));
                    OnPropertyChanged(nameof(Water_Rec_Amnt_button));
                }
            }

            [SortOrder(Water_Rec_Amnt_sortIndex)]
            [DisplayName(Water_Rec_Amnt_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Water_Rec_Amnt_button => ShellTable.recoilLookup.TryGet(Water_Rec_Amnt).ToStringWithId(Water_Rec_Amnt);

            protected byte Water_Rel_Spd_raw;
            public const string Water_Rel_Spd_displayName = "Water Rel Spd";
            public const int Water_Rel_Spd_sortIndex = 2850;
            [SortOrder(Water_Rel_Spd_sortIndex)]
            [DisplayName(Water_Rel_Spd_displayName)]
            [DataSource(DataSourceType.ShellReload)]
            public virtual byte Water_Rel_Spd {
                get => Water_Rel_Spd_raw;
                set {
                    if (Water_Rel_Spd_raw == value) return;
                    Water_Rel_Spd_raw = value;
                    OnPropertyChanged(nameof(Water_Rel_Spd));
                    OnPropertyChanged(nameof(Water_Rel_Spd_button));
                }
            }

            [SortOrder(Water_Rel_Spd_sortIndex)]
            [DisplayName(Water_Rel_Spd_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Water_Rel_Spd_button => ShellTable.reloadLookup.TryGet(Water_Rel_Spd).ToStringWithId(Water_Rel_Spd);

            protected byte Freeze_Mag_Cnt_raw;
            public const string Freeze_Mag_Cnt_displayName = "Freeze Mag Cnt";
            public const int Freeze_Mag_Cnt_sortIndex = 2900;
            [SortOrder(Freeze_Mag_Cnt_sortIndex)]
            [DisplayName(Freeze_Mag_Cnt_displayName)]
            public virtual byte Freeze_Mag_Cnt {
                get => Freeze_Mag_Cnt_raw;
                set {
                    if (Freeze_Mag_Cnt_raw == value.Clamp((byte) 0, (byte) 10)) return;
                    Freeze_Mag_Cnt_raw = value.Clamp((byte) 0, (byte) 10);
                    OnPropertyChanged(nameof(Freeze_Mag_Cnt));
                }
            }

            protected byte Freeze_Rec_Amnt_raw;
            public const string Freeze_Rec_Amnt_displayName = "Freeze Rec Amnt";
            public const int Freeze_Rec_Amnt_sortIndex = 2950;
            [SortOrder(Freeze_Rec_Amnt_sortIndex)]
            [DisplayName(Freeze_Rec_Amnt_displayName)]
            [DataSource(DataSourceType.ShellRecoil)]
            public virtual byte Freeze_Rec_Amnt {
                get => Freeze_Rec_Amnt_raw;
                set {
                    if (Freeze_Rec_Amnt_raw == value) return;
                    Freeze_Rec_Amnt_raw = value;
                    OnPropertyChanged(nameof(Freeze_Rec_Amnt));
                    OnPropertyChanged(nameof(Freeze_Rec_Amnt_button));
                }
            }

            [SortOrder(Freeze_Rec_Amnt_sortIndex)]
            [DisplayName(Freeze_Rec_Amnt_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Freeze_Rec_Amnt_button => ShellTable.recoilLookup.TryGet(Freeze_Rec_Amnt).ToStringWithId(Freeze_Rec_Amnt);

            protected byte Freeze_Rel_Spd_raw;
            public const string Freeze_Rel_Spd_displayName = "Freeze Rel Spd";
            public const int Freeze_Rel_Spd_sortIndex = 3000;
            [SortOrder(Freeze_Rel_Spd_sortIndex)]
            [DisplayName(Freeze_Rel_Spd_displayName)]
            [DataSource(DataSourceType.ShellReload)]
            public virtual byte Freeze_Rel_Spd {
                get => Freeze_Rel_Spd_raw;
                set {
                    if (Freeze_Rel_Spd_raw == value) return;
                    Freeze_Rel_Spd_raw = value;
                    OnPropertyChanged(nameof(Freeze_Rel_Spd));
                    OnPropertyChanged(nameof(Freeze_Rel_Spd_button));
                }
            }

            [SortOrder(Freeze_Rel_Spd_sortIndex)]
            [DisplayName(Freeze_Rel_Spd_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Freeze_Rel_Spd_button => ShellTable.reloadLookup.TryGet(Freeze_Rel_Spd).ToStringWithId(Freeze_Rel_Spd);

            protected byte Thunder_Mag_Cnt_raw;
            public const string Thunder_Mag_Cnt_displayName = "Thunder Mag Cnt";
            public const int Thunder_Mag_Cnt_sortIndex = 3050;
            [SortOrder(Thunder_Mag_Cnt_sortIndex)]
            [DisplayName(Thunder_Mag_Cnt_displayName)]
            public virtual byte Thunder_Mag_Cnt {
                get => Thunder_Mag_Cnt_raw;
                set {
                    if (Thunder_Mag_Cnt_raw == value.Clamp((byte) 0, (byte) 10)) return;
                    Thunder_Mag_Cnt_raw = value.Clamp((byte) 0, (byte) 10);
                    OnPropertyChanged(nameof(Thunder_Mag_Cnt));
                }
            }

            protected byte Thunder_Rec_Amnt_raw;
            public const string Thunder_Rec_Amnt_displayName = "Thunder Rec Amnt";
            public const int Thunder_Rec_Amnt_sortIndex = 3100;
            [SortOrder(Thunder_Rec_Amnt_sortIndex)]
            [DisplayName(Thunder_Rec_Amnt_displayName)]
            [DataSource(DataSourceType.ShellRecoil)]
            public virtual byte Thunder_Rec_Amnt {
                get => Thunder_Rec_Amnt_raw;
                set {
                    if (Thunder_Rec_Amnt_raw == value) return;
                    Thunder_Rec_Amnt_raw = value;
                    OnPropertyChanged(nameof(Thunder_Rec_Amnt));
                    OnPropertyChanged(nameof(Thunder_Rec_Amnt_button));
                }
            }

            [SortOrder(Thunder_Rec_Amnt_sortIndex)]
            [DisplayName(Thunder_Rec_Amnt_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Thunder_Rec_Amnt_button => ShellTable.recoilLookup.TryGet(Thunder_Rec_Amnt).ToStringWithId(Thunder_Rec_Amnt);

            protected byte Thunder_Rel_Spd_raw;
            public const string Thunder_Rel_Spd_displayName = "Thunder Rel Spd";
            public const int Thunder_Rel_Spd_sortIndex = 3150;
            [SortOrder(Thunder_Rel_Spd_sortIndex)]
            [DisplayName(Thunder_Rel_Spd_displayName)]
            [DataSource(DataSourceType.ShellReload)]
            public virtual byte Thunder_Rel_Spd {
                get => Thunder_Rel_Spd_raw;
                set {
                    if (Thunder_Rel_Spd_raw == value) return;
                    Thunder_Rel_Spd_raw = value;
                    OnPropertyChanged(nameof(Thunder_Rel_Spd));
                    OnPropertyChanged(nameof(Thunder_Rel_Spd_button));
                }
            }

            [SortOrder(Thunder_Rel_Spd_sortIndex)]
            [DisplayName(Thunder_Rel_Spd_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Thunder_Rel_Spd_button => ShellTable.reloadLookup.TryGet(Thunder_Rel_Spd).ToStringWithId(Thunder_Rel_Spd);

            protected byte Dragon_Mag_Cnt_raw;
            public const string Dragon_Mag_Cnt_displayName = "Dragon Mag Cnt";
            public const int Dragon_Mag_Cnt_sortIndex = 3200;
            [SortOrder(Dragon_Mag_Cnt_sortIndex)]
            [DisplayName(Dragon_Mag_Cnt_displayName)]
            public virtual byte Dragon_Mag_Cnt {
                get => Dragon_Mag_Cnt_raw;
                set {
                    if (Dragon_Mag_Cnt_raw == value.Clamp((byte) 0, (byte) 10)) return;
                    Dragon_Mag_Cnt_raw = value.Clamp((byte) 0, (byte) 10);
                    OnPropertyChanged(nameof(Dragon_Mag_Cnt));
                }
            }

            protected byte Dragon_Rec_Amnt_raw;
            public const string Dragon_Rec_Amnt_displayName = "Dragon Rec Amnt";
            public const int Dragon_Rec_Amnt_sortIndex = 3250;
            [SortOrder(Dragon_Rec_Amnt_sortIndex)]
            [DisplayName(Dragon_Rec_Amnt_displayName)]
            [DataSource(DataSourceType.ShellRecoil)]
            public virtual byte Dragon_Rec_Amnt {
                get => Dragon_Rec_Amnt_raw;
                set {
                    if (Dragon_Rec_Amnt_raw == value) return;
                    Dragon_Rec_Amnt_raw = value;
                    OnPropertyChanged(nameof(Dragon_Rec_Amnt));
                    OnPropertyChanged(nameof(Dragon_Rec_Amnt_button));
                }
            }

            [SortOrder(Dragon_Rec_Amnt_sortIndex)]
            [DisplayName(Dragon_Rec_Amnt_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Dragon_Rec_Amnt_button => ShellTable.recoilLookup.TryGet(Dragon_Rec_Amnt).ToStringWithId(Dragon_Rec_Amnt);

            protected byte Dragon_Rel_Spd_raw;
            public const string Dragon_Rel_Spd_displayName = "Dragon Rel Spd";
            public const int Dragon_Rel_Spd_sortIndex = 3300;
            [SortOrder(Dragon_Rel_Spd_sortIndex)]
            [DisplayName(Dragon_Rel_Spd_displayName)]
            [DataSource(DataSourceType.ShellReload)]
            public virtual byte Dragon_Rel_Spd {
                get => Dragon_Rel_Spd_raw;
                set {
                    if (Dragon_Rel_Spd_raw == value) return;
                    Dragon_Rel_Spd_raw = value;
                    OnPropertyChanged(nameof(Dragon_Rel_Spd));
                    OnPropertyChanged(nameof(Dragon_Rel_Spd_button));
                }
            }

            [SortOrder(Dragon_Rel_Spd_sortIndex)]
            [DisplayName(Dragon_Rel_Spd_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Dragon_Rel_Spd_button => ShellTable.reloadLookup.TryGet(Dragon_Rel_Spd).ToStringWithId(Dragon_Rel_Spd);

            protected byte Poison_1_Mag_Cnt_raw;
            public const string Poison_1_Mag_Cnt_displayName = "Poison 1 Mag Cnt";
            public const int Poison_1_Mag_Cnt_sortIndex = 3350;
            [SortOrder(Poison_1_Mag_Cnt_sortIndex)]
            [DisplayName(Poison_1_Mag_Cnt_displayName)]
            public virtual byte Poison_1_Mag_Cnt {
                get => Poison_1_Mag_Cnt_raw;
                set {
                    if (Poison_1_Mag_Cnt_raw == value.Clamp((byte) 0, (byte) 10)) return;
                    Poison_1_Mag_Cnt_raw = value.Clamp((byte) 0, (byte) 10);
                    OnPropertyChanged(nameof(Poison_1_Mag_Cnt));
                }
            }

            protected byte Poison_1_Rec_Amnt_raw;
            public const string Poison_1_Rec_Amnt_displayName = "Poison 1 Rec Amnt";
            public const int Poison_1_Rec_Amnt_sortIndex = 3400;
            [SortOrder(Poison_1_Rec_Amnt_sortIndex)]
            [DisplayName(Poison_1_Rec_Amnt_displayName)]
            [DataSource(DataSourceType.ShellRecoil)]
            public virtual byte Poison_1_Rec_Amnt {
                get => Poison_1_Rec_Amnt_raw;
                set {
                    if (Poison_1_Rec_Amnt_raw == value) return;
                    Poison_1_Rec_Amnt_raw = value;
                    OnPropertyChanged(nameof(Poison_1_Rec_Amnt));
                    OnPropertyChanged(nameof(Poison_1_Rec_Amnt_button));
                }
            }

            [SortOrder(Poison_1_Rec_Amnt_sortIndex)]
            [DisplayName(Poison_1_Rec_Amnt_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Poison_1_Rec_Amnt_button => ShellTable.recoilLookup.TryGet(Poison_1_Rec_Amnt).ToStringWithId(Poison_1_Rec_Amnt);

            protected byte Poison_1_Rel_Spd_raw;
            public const string Poison_1_Rel_Spd_displayName = "Poison 1 Rel Spd";
            public const int Poison_1_Rel_Spd_sortIndex = 3450;
            [SortOrder(Poison_1_Rel_Spd_sortIndex)]
            [DisplayName(Poison_1_Rel_Spd_displayName)]
            [DataSource(DataSourceType.ShellReload)]
            public virtual byte Poison_1_Rel_Spd {
                get => Poison_1_Rel_Spd_raw;
                set {
                    if (Poison_1_Rel_Spd_raw == value) return;
                    Poison_1_Rel_Spd_raw = value;
                    OnPropertyChanged(nameof(Poison_1_Rel_Spd));
                    OnPropertyChanged(nameof(Poison_1_Rel_Spd_button));
                }
            }

            [SortOrder(Poison_1_Rel_Spd_sortIndex)]
            [DisplayName(Poison_1_Rel_Spd_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Poison_1_Rel_Spd_button => ShellTable.reloadLookup.TryGet(Poison_1_Rel_Spd).ToStringWithId(Poison_1_Rel_Spd);

            protected byte Poison_2_Mag_Cnt_raw;
            public const string Poison_2_Mag_Cnt_displayName = "Poison 2 Mag Cnt";
            public const int Poison_2_Mag_Cnt_sortIndex = 3500;
            [SortOrder(Poison_2_Mag_Cnt_sortIndex)]
            [DisplayName(Poison_2_Mag_Cnt_displayName)]
            public virtual byte Poison_2_Mag_Cnt {
                get => Poison_2_Mag_Cnt_raw;
                set {
                    if (Poison_2_Mag_Cnt_raw == value.Clamp((byte) 0, (byte) 10)) return;
                    Poison_2_Mag_Cnt_raw = value.Clamp((byte) 0, (byte) 10);
                    OnPropertyChanged(nameof(Poison_2_Mag_Cnt));
                }
            }

            protected byte Poison_2_Rec_Amnt_raw;
            public const string Poison_2_Rec_Amnt_displayName = "Poison 2 Rec Amnt";
            public const int Poison_2_Rec_Amnt_sortIndex = 3550;
            [SortOrder(Poison_2_Rec_Amnt_sortIndex)]
            [DisplayName(Poison_2_Rec_Amnt_displayName)]
            [DataSource(DataSourceType.ShellRecoil)]
            public virtual byte Poison_2_Rec_Amnt {
                get => Poison_2_Rec_Amnt_raw;
                set {
                    if (Poison_2_Rec_Amnt_raw == value) return;
                    Poison_2_Rec_Amnt_raw = value;
                    OnPropertyChanged(nameof(Poison_2_Rec_Amnt));
                    OnPropertyChanged(nameof(Poison_2_Rec_Amnt_button));
                }
            }

            [SortOrder(Poison_2_Rec_Amnt_sortIndex)]
            [DisplayName(Poison_2_Rec_Amnt_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Poison_2_Rec_Amnt_button => ShellTable.recoilLookup.TryGet(Poison_2_Rec_Amnt).ToStringWithId(Poison_2_Rec_Amnt);

            protected byte Poison_2_Rel_Spd_raw;
            public const string Poison_2_Rel_Spd_displayName = "Poison 2 Rel Spd";
            public const int Poison_2_Rel_Spd_sortIndex = 3600;
            [SortOrder(Poison_2_Rel_Spd_sortIndex)]
            [DisplayName(Poison_2_Rel_Spd_displayName)]
            [DataSource(DataSourceType.ShellReload)]
            public virtual byte Poison_2_Rel_Spd {
                get => Poison_2_Rel_Spd_raw;
                set {
                    if (Poison_2_Rel_Spd_raw == value) return;
                    Poison_2_Rel_Spd_raw = value;
                    OnPropertyChanged(nameof(Poison_2_Rel_Spd));
                    OnPropertyChanged(nameof(Poison_2_Rel_Spd_button));
                }
            }

            [SortOrder(Poison_2_Rel_Spd_sortIndex)]
            [DisplayName(Poison_2_Rel_Spd_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Poison_2_Rel_Spd_button => ShellTable.reloadLookup.TryGet(Poison_2_Rel_Spd).ToStringWithId(Poison_2_Rel_Spd);

            protected byte Paralysis_1_Mag_Cnt_raw;
            public const string Paralysis_1_Mag_Cnt_displayName = "Paralysis 1 Mag Cnt";
            public const int Paralysis_1_Mag_Cnt_sortIndex = 3650;
            [SortOrder(Paralysis_1_Mag_Cnt_sortIndex)]
            [DisplayName(Paralysis_1_Mag_Cnt_displayName)]
            public virtual byte Paralysis_1_Mag_Cnt {
                get => Paralysis_1_Mag_Cnt_raw;
                set {
                    if (Paralysis_1_Mag_Cnt_raw == value.Clamp((byte) 0, (byte) 10)) return;
                    Paralysis_1_Mag_Cnt_raw = value.Clamp((byte) 0, (byte) 10);
                    OnPropertyChanged(nameof(Paralysis_1_Mag_Cnt));
                }
            }

            protected byte Paralysis_1_Rec_Amnt_raw;
            public const string Paralysis_1_Rec_Amnt_displayName = "Paralysis 1 Rec Amnt";
            public const int Paralysis_1_Rec_Amnt_sortIndex = 3700;
            [SortOrder(Paralysis_1_Rec_Amnt_sortIndex)]
            [DisplayName(Paralysis_1_Rec_Amnt_displayName)]
            [DataSource(DataSourceType.ShellRecoil)]
            public virtual byte Paralysis_1_Rec_Amnt {
                get => Paralysis_1_Rec_Amnt_raw;
                set {
                    if (Paralysis_1_Rec_Amnt_raw == value) return;
                    Paralysis_1_Rec_Amnt_raw = value;
                    OnPropertyChanged(nameof(Paralysis_1_Rec_Amnt));
                    OnPropertyChanged(nameof(Paralysis_1_Rec_Amnt_button));
                }
            }

            [SortOrder(Paralysis_1_Rec_Amnt_sortIndex)]
            [DisplayName(Paralysis_1_Rec_Amnt_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Paralysis_1_Rec_Amnt_button => ShellTable.recoilLookup.TryGet(Paralysis_1_Rec_Amnt).ToStringWithId(Paralysis_1_Rec_Amnt);

            protected byte Paralysis_1_Rel_Spd_raw;
            public const string Paralysis_1_Rel_Spd_displayName = "Paralysis 1 Rel Spd";
            public const int Paralysis_1_Rel_Spd_sortIndex = 3750;
            [SortOrder(Paralysis_1_Rel_Spd_sortIndex)]
            [DisplayName(Paralysis_1_Rel_Spd_displayName)]
            [DataSource(DataSourceType.ShellReload)]
            public virtual byte Paralysis_1_Rel_Spd {
                get => Paralysis_1_Rel_Spd_raw;
                set {
                    if (Paralysis_1_Rel_Spd_raw == value) return;
                    Paralysis_1_Rel_Spd_raw = value;
                    OnPropertyChanged(nameof(Paralysis_1_Rel_Spd));
                    OnPropertyChanged(nameof(Paralysis_1_Rel_Spd_button));
                }
            }

            [SortOrder(Paralysis_1_Rel_Spd_sortIndex)]
            [DisplayName(Paralysis_1_Rel_Spd_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Paralysis_1_Rel_Spd_button => ShellTable.reloadLookup.TryGet(Paralysis_1_Rel_Spd).ToStringWithId(Paralysis_1_Rel_Spd);

            protected byte Paralysis_2_Mag_Cnt_raw;
            public const string Paralysis_2_Mag_Cnt_displayName = "Paralysis 2 Mag Cnt";
            public const int Paralysis_2_Mag_Cnt_sortIndex = 3800;
            [SortOrder(Paralysis_2_Mag_Cnt_sortIndex)]
            [DisplayName(Paralysis_2_Mag_Cnt_displayName)]
            public virtual byte Paralysis_2_Mag_Cnt {
                get => Paralysis_2_Mag_Cnt_raw;
                set {
                    if (Paralysis_2_Mag_Cnt_raw == value.Clamp((byte) 0, (byte) 10)) return;
                    Paralysis_2_Mag_Cnt_raw = value.Clamp((byte) 0, (byte) 10);
                    OnPropertyChanged(nameof(Paralysis_2_Mag_Cnt));
                }
            }

            protected byte Paralysis_2_Rec_Amnt_raw;
            public const string Paralysis_2_Rec_Amnt_displayName = "Paralysis 2 Rec Amnt";
            public const int Paralysis_2_Rec_Amnt_sortIndex = 3850;
            [SortOrder(Paralysis_2_Rec_Amnt_sortIndex)]
            [DisplayName(Paralysis_2_Rec_Amnt_displayName)]
            [DataSource(DataSourceType.ShellRecoil)]
            public virtual byte Paralysis_2_Rec_Amnt {
                get => Paralysis_2_Rec_Amnt_raw;
                set {
                    if (Paralysis_2_Rec_Amnt_raw == value) return;
                    Paralysis_2_Rec_Amnt_raw = value;
                    OnPropertyChanged(nameof(Paralysis_2_Rec_Amnt));
                    OnPropertyChanged(nameof(Paralysis_2_Rec_Amnt_button));
                }
            }

            [SortOrder(Paralysis_2_Rec_Amnt_sortIndex)]
            [DisplayName(Paralysis_2_Rec_Amnt_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Paralysis_2_Rec_Amnt_button => ShellTable.recoilLookup.TryGet(Paralysis_2_Rec_Amnt).ToStringWithId(Paralysis_2_Rec_Amnt);

            protected byte Paralysis_2_Rel_Spd_raw;
            public const string Paralysis_2_Rel_Spd_displayName = "Paralysis 2 Rel Spd";
            public const int Paralysis_2_Rel_Spd_sortIndex = 3900;
            [SortOrder(Paralysis_2_Rel_Spd_sortIndex)]
            [DisplayName(Paralysis_2_Rel_Spd_displayName)]
            [DataSource(DataSourceType.ShellReload)]
            public virtual byte Paralysis_2_Rel_Spd {
                get => Paralysis_2_Rel_Spd_raw;
                set {
                    if (Paralysis_2_Rel_Spd_raw == value) return;
                    Paralysis_2_Rel_Spd_raw = value;
                    OnPropertyChanged(nameof(Paralysis_2_Rel_Spd));
                    OnPropertyChanged(nameof(Paralysis_2_Rel_Spd_button));
                }
            }

            [SortOrder(Paralysis_2_Rel_Spd_sortIndex)]
            [DisplayName(Paralysis_2_Rel_Spd_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Paralysis_2_Rel_Spd_button => ShellTable.reloadLookup.TryGet(Paralysis_2_Rel_Spd).ToStringWithId(Paralysis_2_Rel_Spd);

            protected byte Sleep_1_Mag_Cnt_raw;
            public const string Sleep_1_Mag_Cnt_displayName = "Sleep 1 Mag Cnt";
            public const int Sleep_1_Mag_Cnt_sortIndex = 3950;
            [SortOrder(Sleep_1_Mag_Cnt_sortIndex)]
            [DisplayName(Sleep_1_Mag_Cnt_displayName)]
            public virtual byte Sleep_1_Mag_Cnt {
                get => Sleep_1_Mag_Cnt_raw;
                set {
                    if (Sleep_1_Mag_Cnt_raw == value.Clamp((byte) 0, (byte) 10)) return;
                    Sleep_1_Mag_Cnt_raw = value.Clamp((byte) 0, (byte) 10);
                    OnPropertyChanged(nameof(Sleep_1_Mag_Cnt));
                }
            }

            protected byte Sleep_1_Rec_Amnt_raw;
            public const string Sleep_1_Rec_Amnt_displayName = "Sleep 1 Rec Amnt";
            public const int Sleep_1_Rec_Amnt_sortIndex = 4000;
            [SortOrder(Sleep_1_Rec_Amnt_sortIndex)]
            [DisplayName(Sleep_1_Rec_Amnt_displayName)]
            [DataSource(DataSourceType.ShellRecoil)]
            public virtual byte Sleep_1_Rec_Amnt {
                get => Sleep_1_Rec_Amnt_raw;
                set {
                    if (Sleep_1_Rec_Amnt_raw == value) return;
                    Sleep_1_Rec_Amnt_raw = value;
                    OnPropertyChanged(nameof(Sleep_1_Rec_Amnt));
                    OnPropertyChanged(nameof(Sleep_1_Rec_Amnt_button));
                }
            }

            [SortOrder(Sleep_1_Rec_Amnt_sortIndex)]
            [DisplayName(Sleep_1_Rec_Amnt_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Sleep_1_Rec_Amnt_button => ShellTable.recoilLookup.TryGet(Sleep_1_Rec_Amnt).ToStringWithId(Sleep_1_Rec_Amnt);

            protected byte Sleep_1_Rel_Spd_raw;
            public const string Sleep_1_Rel_Spd_displayName = "Sleep 1 Rel Spd";
            public const int Sleep_1_Rel_Spd_sortIndex = 4050;
            [SortOrder(Sleep_1_Rel_Spd_sortIndex)]
            [DisplayName(Sleep_1_Rel_Spd_displayName)]
            [DataSource(DataSourceType.ShellReload)]
            public virtual byte Sleep_1_Rel_Spd {
                get => Sleep_1_Rel_Spd_raw;
                set {
                    if (Sleep_1_Rel_Spd_raw == value) return;
                    Sleep_1_Rel_Spd_raw = value;
                    OnPropertyChanged(nameof(Sleep_1_Rel_Spd));
                    OnPropertyChanged(nameof(Sleep_1_Rel_Spd_button));
                }
            }

            [SortOrder(Sleep_1_Rel_Spd_sortIndex)]
            [DisplayName(Sleep_1_Rel_Spd_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Sleep_1_Rel_Spd_button => ShellTable.reloadLookup.TryGet(Sleep_1_Rel_Spd).ToStringWithId(Sleep_1_Rel_Spd);

            protected byte Sleep_2_Mag_Cnt_raw;
            public const string Sleep_2_Mag_Cnt_displayName = "Sleep 2 Mag Cnt";
            public const int Sleep_2_Mag_Cnt_sortIndex = 4100;
            [SortOrder(Sleep_2_Mag_Cnt_sortIndex)]
            [DisplayName(Sleep_2_Mag_Cnt_displayName)]
            public virtual byte Sleep_2_Mag_Cnt {
                get => Sleep_2_Mag_Cnt_raw;
                set {
                    if (Sleep_2_Mag_Cnt_raw == value.Clamp((byte) 0, (byte) 10)) return;
                    Sleep_2_Mag_Cnt_raw = value.Clamp((byte) 0, (byte) 10);
                    OnPropertyChanged(nameof(Sleep_2_Mag_Cnt));
                }
            }

            protected byte Sleep_2_Rec_Amnt_raw;
            public const string Sleep_2_Rec_Amnt_displayName = "Sleep 2 Rec Amnt";
            public const int Sleep_2_Rec_Amnt_sortIndex = 4150;
            [SortOrder(Sleep_2_Rec_Amnt_sortIndex)]
            [DisplayName(Sleep_2_Rec_Amnt_displayName)]
            [DataSource(DataSourceType.ShellRecoil)]
            public virtual byte Sleep_2_Rec_Amnt {
                get => Sleep_2_Rec_Amnt_raw;
                set {
                    if (Sleep_2_Rec_Amnt_raw == value) return;
                    Sleep_2_Rec_Amnt_raw = value;
                    OnPropertyChanged(nameof(Sleep_2_Rec_Amnt));
                    OnPropertyChanged(nameof(Sleep_2_Rec_Amnt_button));
                }
            }

            [SortOrder(Sleep_2_Rec_Amnt_sortIndex)]
            [DisplayName(Sleep_2_Rec_Amnt_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Sleep_2_Rec_Amnt_button => ShellTable.recoilLookup.TryGet(Sleep_2_Rec_Amnt).ToStringWithId(Sleep_2_Rec_Amnt);

            protected byte Sleep_2_Rel_Spd_raw;
            public const string Sleep_2_Rel_Spd_displayName = "Sleep 2 Rel Spd";
            public const int Sleep_2_Rel_Spd_sortIndex = 4200;
            [SortOrder(Sleep_2_Rel_Spd_sortIndex)]
            [DisplayName(Sleep_2_Rel_Spd_displayName)]
            [DataSource(DataSourceType.ShellReload)]
            public virtual byte Sleep_2_Rel_Spd {
                get => Sleep_2_Rel_Spd_raw;
                set {
                    if (Sleep_2_Rel_Spd_raw == value) return;
                    Sleep_2_Rel_Spd_raw = value;
                    OnPropertyChanged(nameof(Sleep_2_Rel_Spd));
                    OnPropertyChanged(nameof(Sleep_2_Rel_Spd_button));
                }
            }

            [SortOrder(Sleep_2_Rel_Spd_sortIndex)]
            [DisplayName(Sleep_2_Rel_Spd_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Sleep_2_Rel_Spd_button => ShellTable.reloadLookup.TryGet(Sleep_2_Rel_Spd).ToStringWithId(Sleep_2_Rel_Spd);

            protected byte Exhaust_1_Mag_Cnt_raw;
            public const string Exhaust_1_Mag_Cnt_displayName = "Exhaust 1 Mag Cnt";
            public const int Exhaust_1_Mag_Cnt_sortIndex = 4250;
            [SortOrder(Exhaust_1_Mag_Cnt_sortIndex)]
            [DisplayName(Exhaust_1_Mag_Cnt_displayName)]
            public virtual byte Exhaust_1_Mag_Cnt {
                get => Exhaust_1_Mag_Cnt_raw;
                set {
                    if (Exhaust_1_Mag_Cnt_raw == value.Clamp((byte) 0, (byte) 10)) return;
                    Exhaust_1_Mag_Cnt_raw = value.Clamp((byte) 0, (byte) 10);
                    OnPropertyChanged(nameof(Exhaust_1_Mag_Cnt));
                }
            }

            protected byte Exhaust_1_Rec_Amnt_raw;
            public const string Exhaust_1_Rec_Amnt_displayName = "Exhaust 1 Rec Amnt";
            public const int Exhaust_1_Rec_Amnt_sortIndex = 4300;
            [SortOrder(Exhaust_1_Rec_Amnt_sortIndex)]
            [DisplayName(Exhaust_1_Rec_Amnt_displayName)]
            [DataSource(DataSourceType.ShellRecoil)]
            public virtual byte Exhaust_1_Rec_Amnt {
                get => Exhaust_1_Rec_Amnt_raw;
                set {
                    if (Exhaust_1_Rec_Amnt_raw == value) return;
                    Exhaust_1_Rec_Amnt_raw = value;
                    OnPropertyChanged(nameof(Exhaust_1_Rec_Amnt));
                    OnPropertyChanged(nameof(Exhaust_1_Rec_Amnt_button));
                }
            }

            [SortOrder(Exhaust_1_Rec_Amnt_sortIndex)]
            [DisplayName(Exhaust_1_Rec_Amnt_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Exhaust_1_Rec_Amnt_button => ShellTable.recoilLookup.TryGet(Exhaust_1_Rec_Amnt).ToStringWithId(Exhaust_1_Rec_Amnt);

            protected byte Exhaust_1_Rel_Spd_raw;
            public const string Exhaust_1_Rel_Spd_displayName = "Exhaust 1 Rel Spd";
            public const int Exhaust_1_Rel_Spd_sortIndex = 4350;
            [SortOrder(Exhaust_1_Rel_Spd_sortIndex)]
            [DisplayName(Exhaust_1_Rel_Spd_displayName)]
            [DataSource(DataSourceType.ShellReload)]
            public virtual byte Exhaust_1_Rel_Spd {
                get => Exhaust_1_Rel_Spd_raw;
                set {
                    if (Exhaust_1_Rel_Spd_raw == value) return;
                    Exhaust_1_Rel_Spd_raw = value;
                    OnPropertyChanged(nameof(Exhaust_1_Rel_Spd));
                    OnPropertyChanged(nameof(Exhaust_1_Rel_Spd_button));
                }
            }

            [SortOrder(Exhaust_1_Rel_Spd_sortIndex)]
            [DisplayName(Exhaust_1_Rel_Spd_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Exhaust_1_Rel_Spd_button => ShellTable.reloadLookup.TryGet(Exhaust_1_Rel_Spd).ToStringWithId(Exhaust_1_Rel_Spd);

            protected byte Exhaust_2_Mag_Cnt_raw;
            public const string Exhaust_2_Mag_Cnt_displayName = "Exhaust 2 Mag Cnt";
            public const int Exhaust_2_Mag_Cnt_sortIndex = 4400;
            [SortOrder(Exhaust_2_Mag_Cnt_sortIndex)]
            [DisplayName(Exhaust_2_Mag_Cnt_displayName)]
            public virtual byte Exhaust_2_Mag_Cnt {
                get => Exhaust_2_Mag_Cnt_raw;
                set {
                    if (Exhaust_2_Mag_Cnt_raw == value.Clamp((byte) 0, (byte) 10)) return;
                    Exhaust_2_Mag_Cnt_raw = value.Clamp((byte) 0, (byte) 10);
                    OnPropertyChanged(nameof(Exhaust_2_Mag_Cnt));
                }
            }

            protected byte Exhaust_2_Rec_Amnt_raw;
            public const string Exhaust_2_Rec_Amnt_displayName = "Exhaust 2 Rec Amnt";
            public const int Exhaust_2_Rec_Amnt_sortIndex = 4450;
            [SortOrder(Exhaust_2_Rec_Amnt_sortIndex)]
            [DisplayName(Exhaust_2_Rec_Amnt_displayName)]
            [DataSource(DataSourceType.ShellRecoil)]
            public virtual byte Exhaust_2_Rec_Amnt {
                get => Exhaust_2_Rec_Amnt_raw;
                set {
                    if (Exhaust_2_Rec_Amnt_raw == value) return;
                    Exhaust_2_Rec_Amnt_raw = value;
                    OnPropertyChanged(nameof(Exhaust_2_Rec_Amnt));
                    OnPropertyChanged(nameof(Exhaust_2_Rec_Amnt_button));
                }
            }

            [SortOrder(Exhaust_2_Rec_Amnt_sortIndex)]
            [DisplayName(Exhaust_2_Rec_Amnt_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Exhaust_2_Rec_Amnt_button => ShellTable.recoilLookup.TryGet(Exhaust_2_Rec_Amnt).ToStringWithId(Exhaust_2_Rec_Amnt);

            protected byte Exhaust_2_Rel_Spd_raw;
            public const string Exhaust_2_Rel_Spd_displayName = "Exhaust 2 Rel Spd";
            public const int Exhaust_2_Rel_Spd_sortIndex = 4500;
            [SortOrder(Exhaust_2_Rel_Spd_sortIndex)]
            [DisplayName(Exhaust_2_Rel_Spd_displayName)]
            [DataSource(DataSourceType.ShellReload)]
            public virtual byte Exhaust_2_Rel_Spd {
                get => Exhaust_2_Rel_Spd_raw;
                set {
                    if (Exhaust_2_Rel_Spd_raw == value) return;
                    Exhaust_2_Rel_Spd_raw = value;
                    OnPropertyChanged(nameof(Exhaust_2_Rel_Spd));
                    OnPropertyChanged(nameof(Exhaust_2_Rel_Spd_button));
                }
            }

            [SortOrder(Exhaust_2_Rel_Spd_sortIndex)]
            [DisplayName(Exhaust_2_Rel_Spd_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Exhaust_2_Rel_Spd_button => ShellTable.reloadLookup.TryGet(Exhaust_2_Rel_Spd).ToStringWithId(Exhaust_2_Rel_Spd);

            protected byte Recover_1_Mag_Cnt_raw;
            public const string Recover_1_Mag_Cnt_displayName = "Recover 1 Mag Cnt";
            public const int Recover_1_Mag_Cnt_sortIndex = 4550;
            [SortOrder(Recover_1_Mag_Cnt_sortIndex)]
            [DisplayName(Recover_1_Mag_Cnt_displayName)]
            public virtual byte Recover_1_Mag_Cnt {
                get => Recover_1_Mag_Cnt_raw;
                set {
                    if (Recover_1_Mag_Cnt_raw == value.Clamp((byte) 0, (byte) 10)) return;
                    Recover_1_Mag_Cnt_raw = value.Clamp((byte) 0, (byte) 10);
                    OnPropertyChanged(nameof(Recover_1_Mag_Cnt));
                }
            }

            protected byte Recover_1_Rec_Amnt_raw;
            public const string Recover_1_Rec_Amnt_displayName = "Recover 1 Rec Amnt";
            public const int Recover_1_Rec_Amnt_sortIndex = 4600;
            [SortOrder(Recover_1_Rec_Amnt_sortIndex)]
            [DisplayName(Recover_1_Rec_Amnt_displayName)]
            [DataSource(DataSourceType.ShellRecoil)]
            public virtual byte Recover_1_Rec_Amnt {
                get => Recover_1_Rec_Amnt_raw;
                set {
                    if (Recover_1_Rec_Amnt_raw == value) return;
                    Recover_1_Rec_Amnt_raw = value;
                    OnPropertyChanged(nameof(Recover_1_Rec_Amnt));
                    OnPropertyChanged(nameof(Recover_1_Rec_Amnt_button));
                }
            }

            [SortOrder(Recover_1_Rec_Amnt_sortIndex)]
            [DisplayName(Recover_1_Rec_Amnt_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Recover_1_Rec_Amnt_button => ShellTable.recoilLookup.TryGet(Recover_1_Rec_Amnt).ToStringWithId(Recover_1_Rec_Amnt);

            protected byte Recover_1_Rel_Spd_raw;
            public const string Recover_1_Rel_Spd_displayName = "Recover 1 Rel Spd";
            public const int Recover_1_Rel_Spd_sortIndex = 4650;
            [SortOrder(Recover_1_Rel_Spd_sortIndex)]
            [DisplayName(Recover_1_Rel_Spd_displayName)]
            [DataSource(DataSourceType.ShellReload)]
            public virtual byte Recover_1_Rel_Spd {
                get => Recover_1_Rel_Spd_raw;
                set {
                    if (Recover_1_Rel_Spd_raw == value) return;
                    Recover_1_Rel_Spd_raw = value;
                    OnPropertyChanged(nameof(Recover_1_Rel_Spd));
                    OnPropertyChanged(nameof(Recover_1_Rel_Spd_button));
                }
            }

            [SortOrder(Recover_1_Rel_Spd_sortIndex)]
            [DisplayName(Recover_1_Rel_Spd_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Recover_1_Rel_Spd_button => ShellTable.reloadLookup.TryGet(Recover_1_Rel_Spd).ToStringWithId(Recover_1_Rel_Spd);

            protected byte Recover_2_Mag_Cnt_raw;
            public const string Recover_2_Mag_Cnt_displayName = "Recover 2 Mag Cnt";
            public const int Recover_2_Mag_Cnt_sortIndex = 4700;
            [SortOrder(Recover_2_Mag_Cnt_sortIndex)]
            [DisplayName(Recover_2_Mag_Cnt_displayName)]
            public virtual byte Recover_2_Mag_Cnt {
                get => Recover_2_Mag_Cnt_raw;
                set {
                    if (Recover_2_Mag_Cnt_raw == value.Clamp((byte) 0, (byte) 10)) return;
                    Recover_2_Mag_Cnt_raw = value.Clamp((byte) 0, (byte) 10);
                    OnPropertyChanged(nameof(Recover_2_Mag_Cnt));
                }
            }

            protected byte Recover_2_Rec_Amnt_raw;
            public const string Recover_2_Rec_Amnt_displayName = "Recover 2 Rec Amnt";
            public const int Recover_2_Rec_Amnt_sortIndex = 4750;
            [SortOrder(Recover_2_Rec_Amnt_sortIndex)]
            [DisplayName(Recover_2_Rec_Amnt_displayName)]
            [DataSource(DataSourceType.ShellRecoil)]
            public virtual byte Recover_2_Rec_Amnt {
                get => Recover_2_Rec_Amnt_raw;
                set {
                    if (Recover_2_Rec_Amnt_raw == value) return;
                    Recover_2_Rec_Amnt_raw = value;
                    OnPropertyChanged(nameof(Recover_2_Rec_Amnt));
                    OnPropertyChanged(nameof(Recover_2_Rec_Amnt_button));
                }
            }

            [SortOrder(Recover_2_Rec_Amnt_sortIndex)]
            [DisplayName(Recover_2_Rec_Amnt_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Recover_2_Rec_Amnt_button => ShellTable.recoilLookup.TryGet(Recover_2_Rec_Amnt).ToStringWithId(Recover_2_Rec_Amnt);

            protected byte Recover_2_Rel_Spd_raw;
            public const string Recover_2_Rel_Spd_displayName = "Recover 2 Rel Spd";
            public const int Recover_2_Rel_Spd_sortIndex = 4800;
            [SortOrder(Recover_2_Rel_Spd_sortIndex)]
            [DisplayName(Recover_2_Rel_Spd_displayName)]
            [DataSource(DataSourceType.ShellReload)]
            public virtual byte Recover_2_Rel_Spd {
                get => Recover_2_Rel_Spd_raw;
                set {
                    if (Recover_2_Rel_Spd_raw == value) return;
                    Recover_2_Rel_Spd_raw = value;
                    OnPropertyChanged(nameof(Recover_2_Rel_Spd));
                    OnPropertyChanged(nameof(Recover_2_Rel_Spd_button));
                }
            }

            [SortOrder(Recover_2_Rel_Spd_sortIndex)]
            [DisplayName(Recover_2_Rel_Spd_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Recover_2_Rel_Spd_button => ShellTable.reloadLookup.TryGet(Recover_2_Rel_Spd).ToStringWithId(Recover_2_Rel_Spd);

            protected byte Demon_Mag_Cnt_raw;
            public const string Demon_Mag_Cnt_displayName = "Demon Mag Cnt";
            public const int Demon_Mag_Cnt_sortIndex = 4850;
            [SortOrder(Demon_Mag_Cnt_sortIndex)]
            [DisplayName(Demon_Mag_Cnt_displayName)]
            public virtual byte Demon_Mag_Cnt {
                get => Demon_Mag_Cnt_raw;
                set {
                    if (Demon_Mag_Cnt_raw == value.Clamp((byte) 0, (byte) 10)) return;
                    Demon_Mag_Cnt_raw = value.Clamp((byte) 0, (byte) 10);
                    OnPropertyChanged(nameof(Demon_Mag_Cnt));
                }
            }

            protected byte Demon_Rec_Amnt_raw;
            public const string Demon_Rec_Amnt_displayName = "Demon Rec Amnt";
            public const int Demon_Rec_Amnt_sortIndex = 4900;
            [SortOrder(Demon_Rec_Amnt_sortIndex)]
            [DisplayName(Demon_Rec_Amnt_displayName)]
            [DataSource(DataSourceType.ShellRecoil)]
            public virtual byte Demon_Rec_Amnt {
                get => Demon_Rec_Amnt_raw;
                set {
                    if (Demon_Rec_Amnt_raw == value) return;
                    Demon_Rec_Amnt_raw = value;
                    OnPropertyChanged(nameof(Demon_Rec_Amnt));
                    OnPropertyChanged(nameof(Demon_Rec_Amnt_button));
                }
            }

            [SortOrder(Demon_Rec_Amnt_sortIndex)]
            [DisplayName(Demon_Rec_Amnt_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Demon_Rec_Amnt_button => ShellTable.recoilLookup.TryGet(Demon_Rec_Amnt).ToStringWithId(Demon_Rec_Amnt);

            protected byte Demon_Rel_Spd_raw;
            public const string Demon_Rel_Spd_displayName = "Demon Rel Spd";
            public const int Demon_Rel_Spd_sortIndex = 4950;
            [SortOrder(Demon_Rel_Spd_sortIndex)]
            [DisplayName(Demon_Rel_Spd_displayName)]
            [DataSource(DataSourceType.ShellReload)]
            public virtual byte Demon_Rel_Spd {
                get => Demon_Rel_Spd_raw;
                set {
                    if (Demon_Rel_Spd_raw == value) return;
                    Demon_Rel_Spd_raw = value;
                    OnPropertyChanged(nameof(Demon_Rel_Spd));
                    OnPropertyChanged(nameof(Demon_Rel_Spd_button));
                }
            }

            [SortOrder(Demon_Rel_Spd_sortIndex)]
            [DisplayName(Demon_Rel_Spd_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Demon_Rel_Spd_button => ShellTable.reloadLookup.TryGet(Demon_Rel_Spd).ToStringWithId(Demon_Rel_Spd);

            protected byte Armor_Mag_Cnt_raw;
            public const string Armor_Mag_Cnt_displayName = "Armor Mag Cnt";
            public const int Armor_Mag_Cnt_sortIndex = 5000;
            [SortOrder(Armor_Mag_Cnt_sortIndex)]
            [DisplayName(Armor_Mag_Cnt_displayName)]
            public virtual byte Armor_Mag_Cnt {
                get => Armor_Mag_Cnt_raw;
                set {
                    if (Armor_Mag_Cnt_raw == value.Clamp((byte) 0, (byte) 10)) return;
                    Armor_Mag_Cnt_raw = value.Clamp((byte) 0, (byte) 10);
                    OnPropertyChanged(nameof(Armor_Mag_Cnt));
                }
            }

            protected byte Armor_Rec_Amnt_raw;
            public const string Armor_Rec_Amnt_displayName = "Armor Rec Amnt";
            public const int Armor_Rec_Amnt_sortIndex = 5050;
            [SortOrder(Armor_Rec_Amnt_sortIndex)]
            [DisplayName(Armor_Rec_Amnt_displayName)]
            [DataSource(DataSourceType.ShellRecoil)]
            public virtual byte Armor_Rec_Amnt {
                get => Armor_Rec_Amnt_raw;
                set {
                    if (Armor_Rec_Amnt_raw == value) return;
                    Armor_Rec_Amnt_raw = value;
                    OnPropertyChanged(nameof(Armor_Rec_Amnt));
                    OnPropertyChanged(nameof(Armor_Rec_Amnt_button));
                }
            }

            [SortOrder(Armor_Rec_Amnt_sortIndex)]
            [DisplayName(Armor_Rec_Amnt_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Armor_Rec_Amnt_button => ShellTable.recoilLookup.TryGet(Armor_Rec_Amnt).ToStringWithId(Armor_Rec_Amnt);

            protected byte Armor_Rel_Spd_raw;
            public const string Armor_Rel_Spd_displayName = "Armor Rel Spd";
            public const int Armor_Rel_Spd_sortIndex = 5100;
            [SortOrder(Armor_Rel_Spd_sortIndex)]
            [DisplayName(Armor_Rel_Spd_displayName)]
            [DataSource(DataSourceType.ShellReload)]
            public virtual byte Armor_Rel_Spd {
                get => Armor_Rel_Spd_raw;
                set {
                    if (Armor_Rel_Spd_raw == value) return;
                    Armor_Rel_Spd_raw = value;
                    OnPropertyChanged(nameof(Armor_Rel_Spd));
                    OnPropertyChanged(nameof(Armor_Rel_Spd_button));
                }
            }

            [SortOrder(Armor_Rel_Spd_sortIndex)]
            [DisplayName(Armor_Rel_Spd_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Armor_Rel_Spd_button => ShellTable.reloadLookup.TryGet(Armor_Rel_Spd).ToStringWithId(Armor_Rel_Spd);

            protected byte Unknown_1_Mag_Cnt_raw;
            public const string Unknown_1_Mag_Cnt_displayName = "Unknown 1 Mag Cnt";
            public const int Unknown_1_Mag_Cnt_sortIndex = 5150;
            [SortOrder(Unknown_1_Mag_Cnt_sortIndex)]
            [DisplayName(Unknown_1_Mag_Cnt_displayName)]
            public virtual byte Unknown_1_Mag_Cnt {
                get => Unknown_1_Mag_Cnt_raw;
                set {
                    if (Unknown_1_Mag_Cnt_raw == value.Clamp((byte) 0, (byte) 10)) return;
                    Unknown_1_Mag_Cnt_raw = value.Clamp((byte) 0, (byte) 10);
                    OnPropertyChanged(nameof(Unknown_1_Mag_Cnt));
                }
            }

            protected byte Unknown_1_Rec_Amnt_raw;
            public const string Unknown_1_Rec_Amnt_displayName = "Unknown 1 Rec Amnt";
            public const int Unknown_1_Rec_Amnt_sortIndex = 5200;
            [SortOrder(Unknown_1_Rec_Amnt_sortIndex)]
            [DisplayName(Unknown_1_Rec_Amnt_displayName)]
            [DataSource(DataSourceType.ShellRecoil)]
            public virtual byte Unknown_1_Rec_Amnt {
                get => Unknown_1_Rec_Amnt_raw;
                set {
                    if (Unknown_1_Rec_Amnt_raw == value) return;
                    Unknown_1_Rec_Amnt_raw = value;
                    OnPropertyChanged(nameof(Unknown_1_Rec_Amnt));
                    OnPropertyChanged(nameof(Unknown_1_Rec_Amnt_button));
                }
            }

            [SortOrder(Unknown_1_Rec_Amnt_sortIndex)]
            [DisplayName(Unknown_1_Rec_Amnt_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Unknown_1_Rec_Amnt_button => ShellTable.recoilLookup.TryGet(Unknown_1_Rec_Amnt).ToStringWithId(Unknown_1_Rec_Amnt);

            protected byte Unknown_1_Rel_Spd_raw;
            public const string Unknown_1_Rel_Spd_displayName = "Unknown 1 Rel Spd";
            public const int Unknown_1_Rel_Spd_sortIndex = 5250;
            [SortOrder(Unknown_1_Rel_Spd_sortIndex)]
            [DisplayName(Unknown_1_Rel_Spd_displayName)]
            [DataSource(DataSourceType.ShellReload)]
            public virtual byte Unknown_1_Rel_Spd {
                get => Unknown_1_Rel_Spd_raw;
                set {
                    if (Unknown_1_Rel_Spd_raw == value) return;
                    Unknown_1_Rel_Spd_raw = value;
                    OnPropertyChanged(nameof(Unknown_1_Rel_Spd));
                    OnPropertyChanged(nameof(Unknown_1_Rel_Spd_button));
                }
            }

            [SortOrder(Unknown_1_Rel_Spd_sortIndex)]
            [DisplayName(Unknown_1_Rel_Spd_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Unknown_1_Rel_Spd_button => ShellTable.reloadLookup.TryGet(Unknown_1_Rel_Spd).ToStringWithId(Unknown_1_Rel_Spd);

            protected byte Unknown_2_Mag_Cnt_raw;
            public const string Unknown_2_Mag_Cnt_displayName = "Unknown 2 Mag Cnt";
            public const int Unknown_2_Mag_Cnt_sortIndex = 5300;
            [SortOrder(Unknown_2_Mag_Cnt_sortIndex)]
            [DisplayName(Unknown_2_Mag_Cnt_displayName)]
            public virtual byte Unknown_2_Mag_Cnt {
                get => Unknown_2_Mag_Cnt_raw;
                set {
                    if (Unknown_2_Mag_Cnt_raw == value.Clamp((byte) 0, (byte) 10)) return;
                    Unknown_2_Mag_Cnt_raw = value.Clamp((byte) 0, (byte) 10);
                    OnPropertyChanged(nameof(Unknown_2_Mag_Cnt));
                }
            }

            protected byte Unknown_2_Rec_Amnt_raw;
            public const string Unknown_2_Rec_Amnt_displayName = "Unknown 2 Rec Amnt";
            public const int Unknown_2_Rec_Amnt_sortIndex = 5350;
            [SortOrder(Unknown_2_Rec_Amnt_sortIndex)]
            [DisplayName(Unknown_2_Rec_Amnt_displayName)]
            [DataSource(DataSourceType.ShellRecoil)]
            public virtual byte Unknown_2_Rec_Amnt {
                get => Unknown_2_Rec_Amnt_raw;
                set {
                    if (Unknown_2_Rec_Amnt_raw == value) return;
                    Unknown_2_Rec_Amnt_raw = value;
                    OnPropertyChanged(nameof(Unknown_2_Rec_Amnt));
                    OnPropertyChanged(nameof(Unknown_2_Rec_Amnt_button));
                }
            }

            [SortOrder(Unknown_2_Rec_Amnt_sortIndex)]
            [DisplayName(Unknown_2_Rec_Amnt_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Unknown_2_Rec_Amnt_button => ShellTable.recoilLookup.TryGet(Unknown_2_Rec_Amnt).ToStringWithId(Unknown_2_Rec_Amnt);

            protected byte Unknown_2_Rel_Spd_raw;
            public const string Unknown_2_Rel_Spd_displayName = "Unknown 2 Rel Spd";
            public const int Unknown_2_Rel_Spd_sortIndex = 5400;
            [SortOrder(Unknown_2_Rel_Spd_sortIndex)]
            [DisplayName(Unknown_2_Rel_Spd_displayName)]
            [DataSource(DataSourceType.ShellReload)]
            public virtual byte Unknown_2_Rel_Spd {
                get => Unknown_2_Rel_Spd_raw;
                set {
                    if (Unknown_2_Rel_Spd_raw == value) return;
                    Unknown_2_Rel_Spd_raw = value;
                    OnPropertyChanged(nameof(Unknown_2_Rel_Spd));
                    OnPropertyChanged(nameof(Unknown_2_Rel_Spd_button));
                }
            }

            [SortOrder(Unknown_2_Rel_Spd_sortIndex)]
            [DisplayName(Unknown_2_Rel_Spd_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Unknown_2_Rel_Spd_button => ShellTable.reloadLookup.TryGet(Unknown_2_Rel_Spd).ToStringWithId(Unknown_2_Rel_Spd);

            protected byte Tranq_Mag_Cnt_raw;
            public const string Tranq_Mag_Cnt_displayName = "Tranq Mag Cnt";
            public const int Tranq_Mag_Cnt_sortIndex = 5450;
            [SortOrder(Tranq_Mag_Cnt_sortIndex)]
            [DisplayName(Tranq_Mag_Cnt_displayName)]
            public virtual byte Tranq_Mag_Cnt {
                get => Tranq_Mag_Cnt_raw;
                set {
                    if (Tranq_Mag_Cnt_raw == value.Clamp((byte) 0, (byte) 10)) return;
                    Tranq_Mag_Cnt_raw = value.Clamp((byte) 0, (byte) 10);
                    OnPropertyChanged(nameof(Tranq_Mag_Cnt));
                }
            }

            protected byte Tranq_Rec_Amnt_raw;
            public const string Tranq_Rec_Amnt_displayName = "Tranq Rec Amnt";
            public const int Tranq_Rec_Amnt_sortIndex = 5500;
            [SortOrder(Tranq_Rec_Amnt_sortIndex)]
            [DisplayName(Tranq_Rec_Amnt_displayName)]
            [DataSource(DataSourceType.ShellRecoil)]
            public virtual byte Tranq_Rec_Amnt {
                get => Tranq_Rec_Amnt_raw;
                set {
                    if (Tranq_Rec_Amnt_raw == value) return;
                    Tranq_Rec_Amnt_raw = value;
                    OnPropertyChanged(nameof(Tranq_Rec_Amnt));
                    OnPropertyChanged(nameof(Tranq_Rec_Amnt_button));
                }
            }

            [SortOrder(Tranq_Rec_Amnt_sortIndex)]
            [DisplayName(Tranq_Rec_Amnt_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Tranq_Rec_Amnt_button => ShellTable.recoilLookup.TryGet(Tranq_Rec_Amnt).ToStringWithId(Tranq_Rec_Amnt);

            protected byte Tranq_Rel_Spd_raw;
            public const string Tranq_Rel_Spd_displayName = "Tranq Rel Spd";
            public const int Tranq_Rel_Spd_sortIndex = 5550;
            [SortOrder(Tranq_Rel_Spd_sortIndex)]
            [DisplayName(Tranq_Rel_Spd_displayName)]
            [DataSource(DataSourceType.ShellReload)]
            public virtual byte Tranq_Rel_Spd {
                get => Tranq_Rel_Spd_raw;
                set {
                    if (Tranq_Rel_Spd_raw == value) return;
                    Tranq_Rel_Spd_raw = value;
                    OnPropertyChanged(nameof(Tranq_Rel_Spd));
                    OnPropertyChanged(nameof(Tranq_Rel_Spd_button));
                }
            }

            [SortOrder(Tranq_Rel_Spd_sortIndex)]
            [DisplayName(Tranq_Rel_Spd_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Tranq_Rel_Spd_button => ShellTable.reloadLookup.TryGet(Tranq_Rel_Spd).ToStringWithId(Tranq_Rel_Spd);

            public const int lastSortIndex = 5600;

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
                data.Normal_1_Mag_Cnt_raw = reader.ReadByte();
                data.Normal_1_Rec_Amnt_raw = reader.ReadByte();
                data.Normal_1_Rel_Spd_raw = reader.ReadByte();
                data.Normal_2_Mag_Cnt_raw = reader.ReadByte();
                data.Normal_2_Rec_Amnt_raw = reader.ReadByte();
                data.Normal_2_Rel_Spd_raw = reader.ReadByte();
                data.Normal_3_Mag_Cnt_raw = reader.ReadByte();
                data.Normal_3_Rec_Amnt_raw = reader.ReadByte();
                data.Normal_3_Rel_Spd_raw = reader.ReadByte();
                data.Pierce_1_Mag_Cnt_raw = reader.ReadByte();
                data.Pierce_1_Rec_Amnt_raw = reader.ReadByte();
                data.Pierce_1_Rel_Spd_raw = reader.ReadByte();
                data.Pierce_2_Mag_Cnt_raw = reader.ReadByte();
                data.Pierce_2_Rec_Amnt_raw = reader.ReadByte();
                data.Pierce_2_Rel_Spd_raw = reader.ReadByte();
                data.Pierce_3_Mag_Cnt_raw = reader.ReadByte();
                data.Pierce_3_Rec_Amnt_raw = reader.ReadByte();
                data.Pierce_3_Rel_Spd_raw = reader.ReadByte();
                data.Spread_1_Mag_Cnt_raw = reader.ReadByte();
                data.Spread_1_Rec_Amnt_raw = reader.ReadByte();
                data.Spread_1_Rel_Spd_raw = reader.ReadByte();
                data.Spread_2_Mag_Cnt_raw = reader.ReadByte();
                data.Spread_2_Rec_Amnt_raw = reader.ReadByte();
                data.Spread_2_Rel_Spd_raw = reader.ReadByte();
                data.Spread_3_Mag_Cnt_raw = reader.ReadByte();
                data.Spread_3_Rec_Amnt_raw = reader.ReadByte();
                data.Spread_3_Rel_Spd_raw = reader.ReadByte();
                data.Cluster_1_Mag_Cnt_raw = reader.ReadByte();
                data.Cluster_1_Rec_Amnt_raw = reader.ReadByte();
                data.Cluster_1_Rel_Spd_raw = reader.ReadByte();
                data.Cluster_2_Mag_Cnt_raw = reader.ReadByte();
                data.Cluster_2_Rec_Amnt_raw = reader.ReadByte();
                data.Cluster_2_Rel_Spd_raw = reader.ReadByte();
                data.Cluster_3_Mag_Cnt_raw = reader.ReadByte();
                data.Cluster_3_Rec_Amnt_raw = reader.ReadByte();
                data.Cluster_3_Rel_Spd_raw = reader.ReadByte();
                data.Wyvern_Mag_Cnt_raw = reader.ReadByte();
                data.Wyvern_Rec_Amnt_raw = reader.ReadByte();
                data.Wyvern_Rel_Spd_raw = reader.ReadByte();
                data.Sticky_1_Mag_Cnt_raw = reader.ReadByte();
                data.Sticky_1_Rec_Amnt_raw = reader.ReadByte();
                data.Sticky_1_Rel_Spd_raw = reader.ReadByte();
                data.Sticky_2_Mag_Cnt_raw = reader.ReadByte();
                data.Sticky_2_Rec_Amnt_raw = reader.ReadByte();
                data.Sticky_2_Rel_Spd_raw = reader.ReadByte();
                data.Sticky_3_Mag_Cnt_raw = reader.ReadByte();
                data.Sticky_3_Rec_Amnt_raw = reader.ReadByte();
                data.Sticky_3_Rel_Spd_raw = reader.ReadByte();
                data.Slicing_Mag_Cnt_raw = reader.ReadByte();
                data.Slicing_Rec_Amnt_raw = reader.ReadByte();
                data.Slicing_Rel_Spd_raw = reader.ReadByte();
                data.Flaming_Mag_Cnt_raw = reader.ReadByte();
                data.Flaming_Rec_Amnt_raw = reader.ReadByte();
                data.Flaming_Rel_Spd_raw = reader.ReadByte();
                data.Water_Mag_Cnt_raw = reader.ReadByte();
                data.Water_Rec_Amnt_raw = reader.ReadByte();
                data.Water_Rel_Spd_raw = reader.ReadByte();
                data.Freeze_Mag_Cnt_raw = reader.ReadByte();
                data.Freeze_Rec_Amnt_raw = reader.ReadByte();
                data.Freeze_Rel_Spd_raw = reader.ReadByte();
                data.Thunder_Mag_Cnt_raw = reader.ReadByte();
                data.Thunder_Rec_Amnt_raw = reader.ReadByte();
                data.Thunder_Rel_Spd_raw = reader.ReadByte();
                data.Dragon_Mag_Cnt_raw = reader.ReadByte();
                data.Dragon_Rec_Amnt_raw = reader.ReadByte();
                data.Dragon_Rel_Spd_raw = reader.ReadByte();
                data.Poison_1_Mag_Cnt_raw = reader.ReadByte();
                data.Poison_1_Rec_Amnt_raw = reader.ReadByte();
                data.Poison_1_Rel_Spd_raw = reader.ReadByte();
                data.Poison_2_Mag_Cnt_raw = reader.ReadByte();
                data.Poison_2_Rec_Amnt_raw = reader.ReadByte();
                data.Poison_2_Rel_Spd_raw = reader.ReadByte();
                data.Paralysis_1_Mag_Cnt_raw = reader.ReadByte();
                data.Paralysis_1_Rec_Amnt_raw = reader.ReadByte();
                data.Paralysis_1_Rel_Spd_raw = reader.ReadByte();
                data.Paralysis_2_Mag_Cnt_raw = reader.ReadByte();
                data.Paralysis_2_Rec_Amnt_raw = reader.ReadByte();
                data.Paralysis_2_Rel_Spd_raw = reader.ReadByte();
                data.Sleep_1_Mag_Cnt_raw = reader.ReadByte();
                data.Sleep_1_Rec_Amnt_raw = reader.ReadByte();
                data.Sleep_1_Rel_Spd_raw = reader.ReadByte();
                data.Sleep_2_Mag_Cnt_raw = reader.ReadByte();
                data.Sleep_2_Rec_Amnt_raw = reader.ReadByte();
                data.Sleep_2_Rel_Spd_raw = reader.ReadByte();
                data.Exhaust_1_Mag_Cnt_raw = reader.ReadByte();
                data.Exhaust_1_Rec_Amnt_raw = reader.ReadByte();
                data.Exhaust_1_Rel_Spd_raw = reader.ReadByte();
                data.Exhaust_2_Mag_Cnt_raw = reader.ReadByte();
                data.Exhaust_2_Rec_Amnt_raw = reader.ReadByte();
                data.Exhaust_2_Rel_Spd_raw = reader.ReadByte();
                data.Recover_1_Mag_Cnt_raw = reader.ReadByte();
                data.Recover_1_Rec_Amnt_raw = reader.ReadByte();
                data.Recover_1_Rel_Spd_raw = reader.ReadByte();
                data.Recover_2_Mag_Cnt_raw = reader.ReadByte();
                data.Recover_2_Rec_Amnt_raw = reader.ReadByte();
                data.Recover_2_Rel_Spd_raw = reader.ReadByte();
                data.Demon_Mag_Cnt_raw = reader.ReadByte();
                data.Demon_Rec_Amnt_raw = reader.ReadByte();
                data.Demon_Rel_Spd_raw = reader.ReadByte();
                data.Armor_Mag_Cnt_raw = reader.ReadByte();
                data.Armor_Rec_Amnt_raw = reader.ReadByte();
                data.Armor_Rel_Spd_raw = reader.ReadByte();
                data.Unknown_1_Mag_Cnt_raw = reader.ReadByte();
                data.Unknown_1_Rec_Amnt_raw = reader.ReadByte();
                data.Unknown_1_Rel_Spd_raw = reader.ReadByte();
                data.Unknown_2_Mag_Cnt_raw = reader.ReadByte();
                data.Unknown_2_Rec_Amnt_raw = reader.ReadByte();
                data.Unknown_2_Rel_Spd_raw = reader.ReadByte();
                data.Tranq_Mag_Cnt_raw = reader.ReadByte();
                data.Tranq_Rec_Amnt_raw = reader.ReadByte();
                data.Tranq_Rel_Spd_raw = reader.ReadByte();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Normal_1_Mag_Cnt_raw);
                writer.Write(Normal_1_Rec_Amnt_raw);
                writer.Write(Normal_1_Rel_Spd_raw);
                writer.Write(Normal_2_Mag_Cnt_raw);
                writer.Write(Normal_2_Rec_Amnt_raw);
                writer.Write(Normal_2_Rel_Spd_raw);
                writer.Write(Normal_3_Mag_Cnt_raw);
                writer.Write(Normal_3_Rec_Amnt_raw);
                writer.Write(Normal_3_Rel_Spd_raw);
                writer.Write(Pierce_1_Mag_Cnt_raw);
                writer.Write(Pierce_1_Rec_Amnt_raw);
                writer.Write(Pierce_1_Rel_Spd_raw);
                writer.Write(Pierce_2_Mag_Cnt_raw);
                writer.Write(Pierce_2_Rec_Amnt_raw);
                writer.Write(Pierce_2_Rel_Spd_raw);
                writer.Write(Pierce_3_Mag_Cnt_raw);
                writer.Write(Pierce_3_Rec_Amnt_raw);
                writer.Write(Pierce_3_Rel_Spd_raw);
                writer.Write(Spread_1_Mag_Cnt_raw);
                writer.Write(Spread_1_Rec_Amnt_raw);
                writer.Write(Spread_1_Rel_Spd_raw);
                writer.Write(Spread_2_Mag_Cnt_raw);
                writer.Write(Spread_2_Rec_Amnt_raw);
                writer.Write(Spread_2_Rel_Spd_raw);
                writer.Write(Spread_3_Mag_Cnt_raw);
                writer.Write(Spread_3_Rec_Amnt_raw);
                writer.Write(Spread_3_Rel_Spd_raw);
                writer.Write(Cluster_1_Mag_Cnt_raw);
                writer.Write(Cluster_1_Rec_Amnt_raw);
                writer.Write(Cluster_1_Rel_Spd_raw);
                writer.Write(Cluster_2_Mag_Cnt_raw);
                writer.Write(Cluster_2_Rec_Amnt_raw);
                writer.Write(Cluster_2_Rel_Spd_raw);
                writer.Write(Cluster_3_Mag_Cnt_raw);
                writer.Write(Cluster_3_Rec_Amnt_raw);
                writer.Write(Cluster_3_Rel_Spd_raw);
                writer.Write(Wyvern_Mag_Cnt_raw);
                writer.Write(Wyvern_Rec_Amnt_raw);
                writer.Write(Wyvern_Rel_Spd_raw);
                writer.Write(Sticky_1_Mag_Cnt_raw);
                writer.Write(Sticky_1_Rec_Amnt_raw);
                writer.Write(Sticky_1_Rel_Spd_raw);
                writer.Write(Sticky_2_Mag_Cnt_raw);
                writer.Write(Sticky_2_Rec_Amnt_raw);
                writer.Write(Sticky_2_Rel_Spd_raw);
                writer.Write(Sticky_3_Mag_Cnt_raw);
                writer.Write(Sticky_3_Rec_Amnt_raw);
                writer.Write(Sticky_3_Rel_Spd_raw);
                writer.Write(Slicing_Mag_Cnt_raw);
                writer.Write(Slicing_Rec_Amnt_raw);
                writer.Write(Slicing_Rel_Spd_raw);
                writer.Write(Flaming_Mag_Cnt_raw);
                writer.Write(Flaming_Rec_Amnt_raw);
                writer.Write(Flaming_Rel_Spd_raw);
                writer.Write(Water_Mag_Cnt_raw);
                writer.Write(Water_Rec_Amnt_raw);
                writer.Write(Water_Rel_Spd_raw);
                writer.Write(Freeze_Mag_Cnt_raw);
                writer.Write(Freeze_Rec_Amnt_raw);
                writer.Write(Freeze_Rel_Spd_raw);
                writer.Write(Thunder_Mag_Cnt_raw);
                writer.Write(Thunder_Rec_Amnt_raw);
                writer.Write(Thunder_Rel_Spd_raw);
                writer.Write(Dragon_Mag_Cnt_raw);
                writer.Write(Dragon_Rec_Amnt_raw);
                writer.Write(Dragon_Rel_Spd_raw);
                writer.Write(Poison_1_Mag_Cnt_raw);
                writer.Write(Poison_1_Rec_Amnt_raw);
                writer.Write(Poison_1_Rel_Spd_raw);
                writer.Write(Poison_2_Mag_Cnt_raw);
                writer.Write(Poison_2_Rec_Amnt_raw);
                writer.Write(Poison_2_Rel_Spd_raw);
                writer.Write(Paralysis_1_Mag_Cnt_raw);
                writer.Write(Paralysis_1_Rec_Amnt_raw);
                writer.Write(Paralysis_1_Rel_Spd_raw);
                writer.Write(Paralysis_2_Mag_Cnt_raw);
                writer.Write(Paralysis_2_Rec_Amnt_raw);
                writer.Write(Paralysis_2_Rel_Spd_raw);
                writer.Write(Sleep_1_Mag_Cnt_raw);
                writer.Write(Sleep_1_Rec_Amnt_raw);
                writer.Write(Sleep_1_Rel_Spd_raw);
                writer.Write(Sleep_2_Mag_Cnt_raw);
                writer.Write(Sleep_2_Rec_Amnt_raw);
                writer.Write(Sleep_2_Rel_Spd_raw);
                writer.Write(Exhaust_1_Mag_Cnt_raw);
                writer.Write(Exhaust_1_Rec_Amnt_raw);
                writer.Write(Exhaust_1_Rel_Spd_raw);
                writer.Write(Exhaust_2_Mag_Cnt_raw);
                writer.Write(Exhaust_2_Rec_Amnt_raw);
                writer.Write(Exhaust_2_Rel_Spd_raw);
                writer.Write(Recover_1_Mag_Cnt_raw);
                writer.Write(Recover_1_Rec_Amnt_raw);
                writer.Write(Recover_1_Rel_Spd_raw);
                writer.Write(Recover_2_Mag_Cnt_raw);
                writer.Write(Recover_2_Rec_Amnt_raw);
                writer.Write(Recover_2_Rel_Spd_raw);
                writer.Write(Demon_Mag_Cnt_raw);
                writer.Write(Demon_Rec_Amnt_raw);
                writer.Write(Demon_Rel_Spd_raw);
                writer.Write(Armor_Mag_Cnt_raw);
                writer.Write(Armor_Rec_Amnt_raw);
                writer.Write(Armor_Rel_Spd_raw);
                writer.Write(Unknown_1_Mag_Cnt_raw);
                writer.Write(Unknown_1_Rec_Amnt_raw);
                writer.Write(Unknown_1_Rel_Spd_raw);
                writer.Write(Unknown_2_Mag_Cnt_raw);
                writer.Write(Unknown_2_Rec_Amnt_raw);
                writer.Write(Unknown_2_Rel_Spd_raw);
                writer.Write(Tranq_Mag_Cnt_raw);
                writer.Write(Tranq_Rec_Amnt_raw);
                writer.Write(Tranq_Rel_Spd_raw);
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
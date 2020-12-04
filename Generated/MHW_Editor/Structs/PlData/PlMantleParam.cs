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
    public partial class PlMantleParam {
        public override string EncryptionKey => "Nb06gpPJ9WtbO6FF1ZYqm5NbLREsCzuqAY0G25ug2Ei5XkkAtVXD5Uda";

        public partial class Header : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Header";

            protected char[] ASP_raw;
            public const string ASP_displayName = "ASP";
            public const int ASP_sortIndex = 50;
            [SortOrder(ASP_sortIndex)]
            [DisplayName(ASP_displayName)]
            [IsReadOnly]
            public virtual string ASP {
                get => (string) new string(ASP_raw);
                set {
                    if ((string) new string(ASP_raw) == value) return;
                    ASP_raw = (char[]) value.ToCharArray(0, 3);
                    ChangedItems.Add(nameof(ASP));
                    OnPropertyChanged(nameof(ASP));
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
                data.ASP_raw = reader.ReadChars(4);
                data.Magic_1_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(ASP_raw);
                writer.Write(Magic_1_raw);
            }
        }

        public partial class Mantle_Params_1_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Mantle Params (1)";

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
                    ChangedItems.Add(nameof(Unk_1));
                    OnPropertyChanged(nameof(Unk_1));
                }
            }

            [DisplayName("Offset")]
            public long Unk_1_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_2));
                    OnPropertyChanged(nameof(Unk_2));
                }
            }

            [DisplayName("Offset")]
            public long Unk_2_offset { get; private set; }

            protected float Unk_3_raw;
            public const string Unk_3_displayName = "Unk 3";
            public const int Unk_3_sortIndex = 150;
            [SortOrder(Unk_3_sortIndex)]
            [DisplayName(Unk_3_displayName)]
            public virtual float Unk_3 {
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
                    ChangedItems.Add(nameof(Unk_4));
                    OnPropertyChanged(nameof(Unk_4));
                }
            }

            [DisplayName("Offset")]
            public long Unk_4_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_5));
                    OnPropertyChanged(nameof(Unk_5));
                }
            }

            [DisplayName("Offset")]
            public long Unk_5_offset { get; private set; }

            protected uint Unk_6_raw;
            public const string Unk_6_displayName = "Unk 6";
            public const int Unk_6_sortIndex = 300;
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

            protected float Unk_7_raw;
            public const string Unk_7_displayName = "Unk 7";
            public const int Unk_7_sortIndex = 350;
            [SortOrder(Unk_7_sortIndex)]
            [DisplayName(Unk_7_displayName)]
            public virtual float Unk_7 {
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

            protected float Unk_8_raw;
            public const string Unk_8_displayName = "Unk 8";
            public const int Unk_8_sortIndex = 400;
            [SortOrder(Unk_8_sortIndex)]
            [DisplayName(Unk_8_displayName)]
            public virtual float Unk_8 {
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
                    ChangedItems.Add(nameof(Unk_9));
                    OnPropertyChanged(nameof(Unk_9));
                }
            }

            [DisplayName("Offset")]
            public long Unk_9_offset { get; private set; }

            protected float Ghillie_Mantle_Cooldown_raw;
            public const string Ghillie_Mantle_Cooldown_displayName = "Ghillie Mantle: Cooldown";
            public const int Ghillie_Mantle_Cooldown_sortIndex = 500;
            [SortOrder(Ghillie_Mantle_Cooldown_sortIndex)]
            [DisplayName(Ghillie_Mantle_Cooldown_displayName)]
            public virtual float Ghillie_Mantle_Cooldown {
                get => Ghillie_Mantle_Cooldown_raw;
                set {
                    if (Ghillie_Mantle_Cooldown_raw == value) return;
                    Ghillie_Mantle_Cooldown_raw = value;
                    ChangedItems.Add(nameof(Ghillie_Mantle_Cooldown));
                    OnPropertyChanged(nameof(Ghillie_Mantle_Cooldown));
                }
            }

            [DisplayName("Offset")]
            public long Ghillie_Mantle_Cooldown_offset { get; private set; }

            protected float Ghillie_Mantle_Duration_raw;
            public const string Ghillie_Mantle_Duration_displayName = "Ghillie Mantle: Duration";
            public const int Ghillie_Mantle_Duration_sortIndex = 550;
            [SortOrder(Ghillie_Mantle_Duration_sortIndex)]
            [DisplayName(Ghillie_Mantle_Duration_displayName)]
            public virtual float Ghillie_Mantle_Duration {
                get => Ghillie_Mantle_Duration_raw;
                set {
                    if (Ghillie_Mantle_Duration_raw == value) return;
                    Ghillie_Mantle_Duration_raw = value;
                    ChangedItems.Add(nameof(Ghillie_Mantle_Duration));
                    OnPropertyChanged(nameof(Ghillie_Mantle_Duration));
                }
            }

            [DisplayName("Offset")]
            public long Ghillie_Mantle_Duration_offset { get; private set; }

            protected float Ghillie_Mantle_Unk1_raw;
            public const string Ghillie_Mantle_Unk1_displayName = "Ghillie Mantle: Unk1";
            public const int Ghillie_Mantle_Unk1_sortIndex = 600;
            [SortOrder(Ghillie_Mantle_Unk1_sortIndex)]
            [DisplayName(Ghillie_Mantle_Unk1_displayName)]
            public virtual float Ghillie_Mantle_Unk1 {
                get => Ghillie_Mantle_Unk1_raw;
                set {
                    if (Ghillie_Mantle_Unk1_raw == value) return;
                    Ghillie_Mantle_Unk1_raw = value;
                    ChangedItems.Add(nameof(Ghillie_Mantle_Unk1));
                    OnPropertyChanged(nameof(Ghillie_Mantle_Unk1));
                }
            }

            [DisplayName("Offset")]
            public long Ghillie_Mantle_Unk1_offset { get; private set; }

            protected float Ghillie_Mantle_Unk2_raw;
            public const string Ghillie_Mantle_Unk2_displayName = "Ghillie Mantle: Unk2";
            public const int Ghillie_Mantle_Unk2_sortIndex = 650;
            [SortOrder(Ghillie_Mantle_Unk2_sortIndex)]
            [DisplayName(Ghillie_Mantle_Unk2_displayName)]
            public virtual float Ghillie_Mantle_Unk2 {
                get => Ghillie_Mantle_Unk2_raw;
                set {
                    if (Ghillie_Mantle_Unk2_raw == value) return;
                    Ghillie_Mantle_Unk2_raw = value;
                    ChangedItems.Add(nameof(Ghillie_Mantle_Unk2));
                    OnPropertyChanged(nameof(Ghillie_Mantle_Unk2));
                }
            }

            [DisplayName("Offset")]
            public long Ghillie_Mantle_Unk2_offset { get; private set; }

            protected float Temporal_Mantle_Cooldown_raw;
            public const string Temporal_Mantle_Cooldown_displayName = "Temporal Mantle: Cooldown";
            public const int Temporal_Mantle_Cooldown_sortIndex = 700;
            [SortOrder(Temporal_Mantle_Cooldown_sortIndex)]
            [DisplayName(Temporal_Mantle_Cooldown_displayName)]
            public virtual float Temporal_Mantle_Cooldown {
                get => Temporal_Mantle_Cooldown_raw;
                set {
                    if (Temporal_Mantle_Cooldown_raw == value) return;
                    Temporal_Mantle_Cooldown_raw = value;
                    ChangedItems.Add(nameof(Temporal_Mantle_Cooldown));
                    OnPropertyChanged(nameof(Temporal_Mantle_Cooldown));
                }
            }

            [DisplayName("Offset")]
            public long Temporal_Mantle_Cooldown_offset { get; private set; }

            protected float Temporal_Mantle_Duration_raw;
            public const string Temporal_Mantle_Duration_displayName = "Temporal Mantle: Duration";
            public const int Temporal_Mantle_Duration_sortIndex = 750;
            [SortOrder(Temporal_Mantle_Duration_sortIndex)]
            [DisplayName(Temporal_Mantle_Duration_displayName)]
            public virtual float Temporal_Mantle_Duration {
                get => Temporal_Mantle_Duration_raw;
                set {
                    if (Temporal_Mantle_Duration_raw == value) return;
                    Temporal_Mantle_Duration_raw = value;
                    ChangedItems.Add(nameof(Temporal_Mantle_Duration));
                    OnPropertyChanged(nameof(Temporal_Mantle_Duration));
                }
            }

            [DisplayName("Offset")]
            public long Temporal_Mantle_Duration_offset { get; private set; }

            protected float Temporal_Mantle_Unk1_raw;
            public const string Temporal_Mantle_Unk1_displayName = "Temporal Mantle: Unk1";
            public const int Temporal_Mantle_Unk1_sortIndex = 800;
            [SortOrder(Temporal_Mantle_Unk1_sortIndex)]
            [DisplayName(Temporal_Mantle_Unk1_displayName)]
            public virtual float Temporal_Mantle_Unk1 {
                get => Temporal_Mantle_Unk1_raw;
                set {
                    if (Temporal_Mantle_Unk1_raw == value) return;
                    Temporal_Mantle_Unk1_raw = value;
                    ChangedItems.Add(nameof(Temporal_Mantle_Unk1));
                    OnPropertyChanged(nameof(Temporal_Mantle_Unk1));
                }
            }

            [DisplayName("Offset")]
            public long Temporal_Mantle_Unk1_offset { get; private set; }

            protected float Temporal_Mantle_Unk2_raw;
            public const string Temporal_Mantle_Unk2_displayName = "Temporal Mantle: Unk2";
            public const int Temporal_Mantle_Unk2_sortIndex = 850;
            [SortOrder(Temporal_Mantle_Unk2_sortIndex)]
            [DisplayName(Temporal_Mantle_Unk2_displayName)]
            public virtual float Temporal_Mantle_Unk2 {
                get => Temporal_Mantle_Unk2_raw;
                set {
                    if (Temporal_Mantle_Unk2_raw == value) return;
                    Temporal_Mantle_Unk2_raw = value;
                    ChangedItems.Add(nameof(Temporal_Mantle_Unk2));
                    OnPropertyChanged(nameof(Temporal_Mantle_Unk2));
                }
            }

            [DisplayName("Offset")]
            public long Temporal_Mantle_Unk2_offset { get; private set; }

            protected float Temporal_Mantle_Unk3_raw;
            public const string Temporal_Mantle_Unk3_displayName = "Temporal Mantle: Unk3";
            public const int Temporal_Mantle_Unk3_sortIndex = 900;
            [SortOrder(Temporal_Mantle_Unk3_sortIndex)]
            [DisplayName(Temporal_Mantle_Unk3_displayName)]
            public virtual float Temporal_Mantle_Unk3 {
                get => Temporal_Mantle_Unk3_raw;
                set {
                    if (Temporal_Mantle_Unk3_raw == value) return;
                    Temporal_Mantle_Unk3_raw = value;
                    ChangedItems.Add(nameof(Temporal_Mantle_Unk3));
                    OnPropertyChanged(nameof(Temporal_Mantle_Unk3));
                }
            }

            [DisplayName("Offset")]
            public long Temporal_Mantle_Unk3_offset { get; private set; }

            protected float Temporal_Mantle_Unk4_raw;
            public const string Temporal_Mantle_Unk4_displayName = "Temporal Mantle: Unk4";
            public const int Temporal_Mantle_Unk4_sortIndex = 950;
            [SortOrder(Temporal_Mantle_Unk4_sortIndex)]
            [DisplayName(Temporal_Mantle_Unk4_displayName)]
            public virtual float Temporal_Mantle_Unk4 {
                get => Temporal_Mantle_Unk4_raw;
                set {
                    if (Temporal_Mantle_Unk4_raw == value) return;
                    Temporal_Mantle_Unk4_raw = value;
                    ChangedItems.Add(nameof(Temporal_Mantle_Unk4));
                    OnPropertyChanged(nameof(Temporal_Mantle_Unk4));
                }
            }

            [DisplayName("Offset")]
            public long Temporal_Mantle_Unk4_offset { get; private set; }

            protected float Temporal_Mantle_Unk5_raw;
            public const string Temporal_Mantle_Unk5_displayName = "Temporal Mantle: Unk5";
            public const int Temporal_Mantle_Unk5_sortIndex = 1000;
            [SortOrder(Temporal_Mantle_Unk5_sortIndex)]
            [DisplayName(Temporal_Mantle_Unk5_displayName)]
            public virtual float Temporal_Mantle_Unk5 {
                get => Temporal_Mantle_Unk5_raw;
                set {
                    if (Temporal_Mantle_Unk5_raw == value) return;
                    Temporal_Mantle_Unk5_raw = value;
                    ChangedItems.Add(nameof(Temporal_Mantle_Unk5));
                    OnPropertyChanged(nameof(Temporal_Mantle_Unk5));
                }
            }

            [DisplayName("Offset")]
            public long Temporal_Mantle_Unk5_offset { get; private set; }

            protected float Temporal_Mantle_Unk6_raw;
            public const string Temporal_Mantle_Unk6_displayName = "Temporal Mantle: Unk6";
            public const int Temporal_Mantle_Unk6_sortIndex = 1050;
            [SortOrder(Temporal_Mantle_Unk6_sortIndex)]
            [DisplayName(Temporal_Mantle_Unk6_displayName)]
            public virtual float Temporal_Mantle_Unk6 {
                get => Temporal_Mantle_Unk6_raw;
                set {
                    if (Temporal_Mantle_Unk6_raw == value) return;
                    Temporal_Mantle_Unk6_raw = value;
                    ChangedItems.Add(nameof(Temporal_Mantle_Unk6));
                    OnPropertyChanged(nameof(Temporal_Mantle_Unk6));
                }
            }

            [DisplayName("Offset")]
            public long Temporal_Mantle_Unk6_offset { get; private set; }

            protected float Temporal_Mantle_Unk7_raw;
            public const string Temporal_Mantle_Unk7_displayName = "Temporal Mantle: Unk7";
            public const int Temporal_Mantle_Unk7_sortIndex = 1100;
            [SortOrder(Temporal_Mantle_Unk7_sortIndex)]
            [DisplayName(Temporal_Mantle_Unk7_displayName)]
            public virtual float Temporal_Mantle_Unk7 {
                get => Temporal_Mantle_Unk7_raw;
                set {
                    if (Temporal_Mantle_Unk7_raw == value) return;
                    Temporal_Mantle_Unk7_raw = value;
                    ChangedItems.Add(nameof(Temporal_Mantle_Unk7));
                    OnPropertyChanged(nameof(Temporal_Mantle_Unk7));
                }
            }

            [DisplayName("Offset")]
            public long Temporal_Mantle_Unk7_offset { get; private set; }

            protected float Temporal_Mantle_Unk8_raw;
            public const string Temporal_Mantle_Unk8_displayName = "Temporal Mantle: Unk8";
            public const int Temporal_Mantle_Unk8_sortIndex = 1150;
            [SortOrder(Temporal_Mantle_Unk8_sortIndex)]
            [DisplayName(Temporal_Mantle_Unk8_displayName)]
            public virtual float Temporal_Mantle_Unk8 {
                get => Temporal_Mantle_Unk8_raw;
                set {
                    if (Temporal_Mantle_Unk8_raw == value) return;
                    Temporal_Mantle_Unk8_raw = value;
                    ChangedItems.Add(nameof(Temporal_Mantle_Unk8));
                    OnPropertyChanged(nameof(Temporal_Mantle_Unk8));
                }
            }

            [DisplayName("Offset")]
            public long Temporal_Mantle_Unk8_offset { get; private set; }

            protected float Temporal_Mantle_Unk9_raw;
            public const string Temporal_Mantle_Unk9_displayName = "Temporal Mantle: Unk9";
            public const int Temporal_Mantle_Unk9_sortIndex = 1200;
            [SortOrder(Temporal_Mantle_Unk9_sortIndex)]
            [DisplayName(Temporal_Mantle_Unk9_displayName)]
            public virtual float Temporal_Mantle_Unk9 {
                get => Temporal_Mantle_Unk9_raw;
                set {
                    if (Temporal_Mantle_Unk9_raw == value) return;
                    Temporal_Mantle_Unk9_raw = value;
                    ChangedItems.Add(nameof(Temporal_Mantle_Unk9));
                    OnPropertyChanged(nameof(Temporal_Mantle_Unk9));
                }
            }

            [DisplayName("Offset")]
            public long Temporal_Mantle_Unk9_offset { get; private set; }

            protected float Temporal_Mantle_Unk10_raw;
            public const string Temporal_Mantle_Unk10_displayName = "Temporal Mantle: Unk10";
            public const int Temporal_Mantle_Unk10_sortIndex = 1250;
            [SortOrder(Temporal_Mantle_Unk10_sortIndex)]
            [DisplayName(Temporal_Mantle_Unk10_displayName)]
            public virtual float Temporal_Mantle_Unk10 {
                get => Temporal_Mantle_Unk10_raw;
                set {
                    if (Temporal_Mantle_Unk10_raw == value) return;
                    Temporal_Mantle_Unk10_raw = value;
                    ChangedItems.Add(nameof(Temporal_Mantle_Unk10));
                    OnPropertyChanged(nameof(Temporal_Mantle_Unk10));
                }
            }

            [DisplayName("Offset")]
            public long Temporal_Mantle_Unk10_offset { get; private set; }

            protected float Temporal_Mantle_Unk11_raw;
            public const string Temporal_Mantle_Unk11_displayName = "Temporal Mantle: Unk11";
            public const int Temporal_Mantle_Unk11_sortIndex = 1300;
            [SortOrder(Temporal_Mantle_Unk11_sortIndex)]
            [DisplayName(Temporal_Mantle_Unk11_displayName)]
            public virtual float Temporal_Mantle_Unk11 {
                get => Temporal_Mantle_Unk11_raw;
                set {
                    if (Temporal_Mantle_Unk11_raw == value) return;
                    Temporal_Mantle_Unk11_raw = value;
                    ChangedItems.Add(nameof(Temporal_Mantle_Unk11));
                    OnPropertyChanged(nameof(Temporal_Mantle_Unk11));
                }
            }

            [DisplayName("Offset")]
            public long Temporal_Mantle_Unk11_offset { get; private set; }

            protected float Temporal_Mantle_Unk12_raw;
            public const string Temporal_Mantle_Unk12_displayName = "Temporal Mantle: Unk12";
            public const int Temporal_Mantle_Unk12_sortIndex = 1350;
            [SortOrder(Temporal_Mantle_Unk12_sortIndex)]
            [DisplayName(Temporal_Mantle_Unk12_displayName)]
            public virtual float Temporal_Mantle_Unk12 {
                get => Temporal_Mantle_Unk12_raw;
                set {
                    if (Temporal_Mantle_Unk12_raw == value) return;
                    Temporal_Mantle_Unk12_raw = value;
                    ChangedItems.Add(nameof(Temporal_Mantle_Unk12));
                    OnPropertyChanged(nameof(Temporal_Mantle_Unk12));
                }
            }

            [DisplayName("Offset")]
            public long Temporal_Mantle_Unk12_offset { get; private set; }

            protected float Temporal_Mantle_Duration_Decrease_Per_Hit_raw;
            public const string Temporal_Mantle_Duration_Decrease_Per_Hit_displayName = "Temporal Mantle: Duration Decrease Per Hit";
            public const int Temporal_Mantle_Duration_Decrease_Per_Hit_sortIndex = 1400;
            [SortOrder(Temporal_Mantle_Duration_Decrease_Per_Hit_sortIndex)]
            [DisplayName(Temporal_Mantle_Duration_Decrease_Per_Hit_displayName)]
            public virtual float Temporal_Mantle_Duration_Decrease_Per_Hit {
                get => Temporal_Mantle_Duration_Decrease_Per_Hit_raw;
                set {
                    if (Temporal_Mantle_Duration_Decrease_Per_Hit_raw == value) return;
                    Temporal_Mantle_Duration_Decrease_Per_Hit_raw = value;
                    ChangedItems.Add(nameof(Temporal_Mantle_Duration_Decrease_Per_Hit));
                    OnPropertyChanged(nameof(Temporal_Mantle_Duration_Decrease_Per_Hit));
                }
            }

            [DisplayName("Offset")]
            public long Temporal_Mantle_Duration_Decrease_Per_Hit_offset { get; private set; }

            protected float Health_Booster_Cooldown_raw;
            public const string Health_Booster_Cooldown_displayName = "Health Booster: Cooldown";
            public const int Health_Booster_Cooldown_sortIndex = 1450;
            [SortOrder(Health_Booster_Cooldown_sortIndex)]
            [DisplayName(Health_Booster_Cooldown_displayName)]
            public virtual float Health_Booster_Cooldown {
                get => Health_Booster_Cooldown_raw;
                set {
                    if (Health_Booster_Cooldown_raw == value) return;
                    Health_Booster_Cooldown_raw = value;
                    ChangedItems.Add(nameof(Health_Booster_Cooldown));
                    OnPropertyChanged(nameof(Health_Booster_Cooldown));
                }
            }

            [DisplayName("Offset")]
            public long Health_Booster_Cooldown_offset { get; private set; }

            protected float Health_Booster_Duration_raw;
            public const string Health_Booster_Duration_displayName = "Health Booster: Duration";
            public const int Health_Booster_Duration_sortIndex = 1500;
            [SortOrder(Health_Booster_Duration_sortIndex)]
            [DisplayName(Health_Booster_Duration_displayName)]
            public virtual float Health_Booster_Duration {
                get => Health_Booster_Duration_raw;
                set {
                    if (Health_Booster_Duration_raw == value) return;
                    Health_Booster_Duration_raw = value;
                    ChangedItems.Add(nameof(Health_Booster_Duration));
                    OnPropertyChanged(nameof(Health_Booster_Duration));
                }
            }

            [DisplayName("Offset")]
            public long Health_Booster_Duration_offset { get; private set; }

            protected float Health_Booster_Upgraded_Duration_raw;
            public const string Health_Booster_Upgraded_Duration_displayName = "Health Booster: Upgraded Duration";
            public const int Health_Booster_Upgraded_Duration_sortIndex = 1550;
            [SortOrder(Health_Booster_Upgraded_Duration_sortIndex)]
            [DisplayName(Health_Booster_Upgraded_Duration_displayName)]
            public virtual float Health_Booster_Upgraded_Duration {
                get => Health_Booster_Upgraded_Duration_raw;
                set {
                    if (Health_Booster_Upgraded_Duration_raw == value) return;
                    Health_Booster_Upgraded_Duration_raw = value;
                    ChangedItems.Add(nameof(Health_Booster_Upgraded_Duration));
                    OnPropertyChanged(nameof(Health_Booster_Upgraded_Duration));
                }
            }

            [DisplayName("Offset")]
            public long Health_Booster_Upgraded_Duration_offset { get; private set; }

            protected float Rocksteady_Mantle_Cooldown_raw;
            public const string Rocksteady_Mantle_Cooldown_displayName = "Rocksteady Mantle: Cooldown";
            public const int Rocksteady_Mantle_Cooldown_sortIndex = 1600;
            [SortOrder(Rocksteady_Mantle_Cooldown_sortIndex)]
            [DisplayName(Rocksteady_Mantle_Cooldown_displayName)]
            public virtual float Rocksteady_Mantle_Cooldown {
                get => Rocksteady_Mantle_Cooldown_raw;
                set {
                    if (Rocksteady_Mantle_Cooldown_raw == value) return;
                    Rocksteady_Mantle_Cooldown_raw = value;
                    ChangedItems.Add(nameof(Rocksteady_Mantle_Cooldown));
                    OnPropertyChanged(nameof(Rocksteady_Mantle_Cooldown));
                }
            }

            [DisplayName("Offset")]
            public long Rocksteady_Mantle_Cooldown_offset { get; private set; }

            protected float Rocksteady_Mantle_Duration_raw;
            public const string Rocksteady_Mantle_Duration_displayName = "Rocksteady Mantle: Duration";
            public const int Rocksteady_Mantle_Duration_sortIndex = 1650;
            [SortOrder(Rocksteady_Mantle_Duration_sortIndex)]
            [DisplayName(Rocksteady_Mantle_Duration_displayName)]
            public virtual float Rocksteady_Mantle_Duration {
                get => Rocksteady_Mantle_Duration_raw;
                set {
                    if (Rocksteady_Mantle_Duration_raw == value) return;
                    Rocksteady_Mantle_Duration_raw = value;
                    ChangedItems.Add(nameof(Rocksteady_Mantle_Duration));
                    OnPropertyChanged(nameof(Rocksteady_Mantle_Duration));
                }
            }

            [DisplayName("Offset")]
            public long Rocksteady_Mantle_Duration_offset { get; private set; }

            protected float Rocksteady_Mantle_Unk1_raw;
            public const string Rocksteady_Mantle_Unk1_displayName = "Rocksteady Mantle: Unk1";
            public const int Rocksteady_Mantle_Unk1_sortIndex = 1700;
            [SortOrder(Rocksteady_Mantle_Unk1_sortIndex)]
            [DisplayName(Rocksteady_Mantle_Unk1_displayName)]
            public virtual float Rocksteady_Mantle_Unk1 {
                get => Rocksteady_Mantle_Unk1_raw;
                set {
                    if (Rocksteady_Mantle_Unk1_raw == value) return;
                    Rocksteady_Mantle_Unk1_raw = value;
                    ChangedItems.Add(nameof(Rocksteady_Mantle_Unk1));
                    OnPropertyChanged(nameof(Rocksteady_Mantle_Unk1));
                }
            }

            [DisplayName("Offset")]
            public long Rocksteady_Mantle_Unk1_offset { get; private set; }

            protected float Rocksteady_Mantle_Damage_Resist_raw;
            public const string Rocksteady_Mantle_Damage_Resist_displayName = "Rocksteady Mantle: Damage Resist";
            public const int Rocksteady_Mantle_Damage_Resist_sortIndex = 1750;
            [SortOrder(Rocksteady_Mantle_Damage_Resist_sortIndex)]
            [DisplayName(Rocksteady_Mantle_Damage_Resist_displayName)]
            public virtual float Rocksteady_Mantle_Damage_Resist {
                get => Rocksteady_Mantle_Damage_Resist_raw;
                set {
                    if (Rocksteady_Mantle_Damage_Resist_raw == value) return;
                    Rocksteady_Mantle_Damage_Resist_raw = value;
                    ChangedItems.Add(nameof(Rocksteady_Mantle_Damage_Resist));
                    OnPropertyChanged(nameof(Rocksteady_Mantle_Damage_Resist));
                }
            }

            [DisplayName("Offset")]
            public long Rocksteady_Mantle_Damage_Resist_offset { get; private set; }

            protected float Rocksteady_Mantle_Unk2_raw;
            public const string Rocksteady_Mantle_Unk2_displayName = "Rocksteady Mantle: Unk2";
            public const int Rocksteady_Mantle_Unk2_sortIndex = 1800;
            [SortOrder(Rocksteady_Mantle_Unk2_sortIndex)]
            [DisplayName(Rocksteady_Mantle_Unk2_displayName)]
            public virtual float Rocksteady_Mantle_Unk2 {
                get => Rocksteady_Mantle_Unk2_raw;
                set {
                    if (Rocksteady_Mantle_Unk2_raw == value) return;
                    Rocksteady_Mantle_Unk2_raw = value;
                    ChangedItems.Add(nameof(Rocksteady_Mantle_Unk2));
                    OnPropertyChanged(nameof(Rocksteady_Mantle_Unk2));
                }
            }

            [DisplayName("Offset")]
            public long Rocksteady_Mantle_Unk2_offset { get; private set; }

            protected float Challenger_Mantle_Cooldown_raw;
            public const string Challenger_Mantle_Cooldown_displayName = "Challenger Mantle: Cooldown";
            public const int Challenger_Mantle_Cooldown_sortIndex = 1850;
            [SortOrder(Challenger_Mantle_Cooldown_sortIndex)]
            [DisplayName(Challenger_Mantle_Cooldown_displayName)]
            public virtual float Challenger_Mantle_Cooldown {
                get => Challenger_Mantle_Cooldown_raw;
                set {
                    if (Challenger_Mantle_Cooldown_raw == value) return;
                    Challenger_Mantle_Cooldown_raw = value;
                    ChangedItems.Add(nameof(Challenger_Mantle_Cooldown));
                    OnPropertyChanged(nameof(Challenger_Mantle_Cooldown));
                }
            }

            [DisplayName("Offset")]
            public long Challenger_Mantle_Cooldown_offset { get; private set; }

            protected float Challenger_Mantle_Duration_raw;
            public const string Challenger_Mantle_Duration_displayName = "Challenger Mantle: Duration";
            public const int Challenger_Mantle_Duration_sortIndex = 1900;
            [SortOrder(Challenger_Mantle_Duration_sortIndex)]
            [DisplayName(Challenger_Mantle_Duration_displayName)]
            public virtual float Challenger_Mantle_Duration {
                get => Challenger_Mantle_Duration_raw;
                set {
                    if (Challenger_Mantle_Duration_raw == value) return;
                    Challenger_Mantle_Duration_raw = value;
                    ChangedItems.Add(nameof(Challenger_Mantle_Duration));
                    OnPropertyChanged(nameof(Challenger_Mantle_Duration));
                }
            }

            [DisplayName("Offset")]
            public long Challenger_Mantle_Duration_offset { get; private set; }

            protected float Challenger_Mantle_Unk1_raw;
            public const string Challenger_Mantle_Unk1_displayName = "Challenger Mantle: Unk1";
            public const int Challenger_Mantle_Unk1_sortIndex = 1950;
            [SortOrder(Challenger_Mantle_Unk1_sortIndex)]
            [DisplayName(Challenger_Mantle_Unk1_displayName)]
            public virtual float Challenger_Mantle_Unk1 {
                get => Challenger_Mantle_Unk1_raw;
                set {
                    if (Challenger_Mantle_Unk1_raw == value) return;
                    Challenger_Mantle_Unk1_raw = value;
                    ChangedItems.Add(nameof(Challenger_Mantle_Unk1));
                    OnPropertyChanged(nameof(Challenger_Mantle_Unk1));
                }
            }

            [DisplayName("Offset")]
            public long Challenger_Mantle_Unk1_offset { get; private set; }

            protected float Challenger_Mantle_Unk2_raw;
            public const string Challenger_Mantle_Unk2_displayName = "Challenger Mantle: Unk2";
            public const int Challenger_Mantle_Unk2_sortIndex = 2000;
            [SortOrder(Challenger_Mantle_Unk2_sortIndex)]
            [DisplayName(Challenger_Mantle_Unk2_displayName)]
            public virtual float Challenger_Mantle_Unk2 {
                get => Challenger_Mantle_Unk2_raw;
                set {
                    if (Challenger_Mantle_Unk2_raw == value) return;
                    Challenger_Mantle_Unk2_raw = value;
                    ChangedItems.Add(nameof(Challenger_Mantle_Unk2));
                    OnPropertyChanged(nameof(Challenger_Mantle_Unk2));
                }
            }

            [DisplayName("Offset")]
            public long Challenger_Mantle_Unk2_offset { get; private set; }

            protected float Vitality_Mantle_Cooldown_raw;
            public const string Vitality_Mantle_Cooldown_displayName = "Vitality Mantle: Cooldown";
            public const int Vitality_Mantle_Cooldown_sortIndex = 2050;
            [SortOrder(Vitality_Mantle_Cooldown_sortIndex)]
            [DisplayName(Vitality_Mantle_Cooldown_displayName)]
            public virtual float Vitality_Mantle_Cooldown {
                get => Vitality_Mantle_Cooldown_raw;
                set {
                    if (Vitality_Mantle_Cooldown_raw == value) return;
                    Vitality_Mantle_Cooldown_raw = value;
                    ChangedItems.Add(nameof(Vitality_Mantle_Cooldown));
                    OnPropertyChanged(nameof(Vitality_Mantle_Cooldown));
                }
            }

            [DisplayName("Offset")]
            public long Vitality_Mantle_Cooldown_offset { get; private set; }

            protected float Vitality_Mantle_Duration_raw;
            public const string Vitality_Mantle_Duration_displayName = "Vitality Mantle: Duration";
            public const int Vitality_Mantle_Duration_sortIndex = 2100;
            [SortOrder(Vitality_Mantle_Duration_sortIndex)]
            [DisplayName(Vitality_Mantle_Duration_displayName)]
            public virtual float Vitality_Mantle_Duration {
                get => Vitality_Mantle_Duration_raw;
                set {
                    if (Vitality_Mantle_Duration_raw == value) return;
                    Vitality_Mantle_Duration_raw = value;
                    ChangedItems.Add(nameof(Vitality_Mantle_Duration));
                    OnPropertyChanged(nameof(Vitality_Mantle_Duration));
                }
            }

            [DisplayName("Offset")]
            public long Vitality_Mantle_Duration_offset { get; private set; }

            protected float Vitality_Mantle_Mantle_Health_raw;
            public const string Vitality_Mantle_Mantle_Health_displayName = "Vitality Mantle: Mantle Health";
            public const int Vitality_Mantle_Mantle_Health_sortIndex = 2150;
            [SortOrder(Vitality_Mantle_Mantle_Health_sortIndex)]
            [DisplayName(Vitality_Mantle_Mantle_Health_displayName)]
            public virtual float Vitality_Mantle_Mantle_Health {
                get => Vitality_Mantle_Mantle_Health_raw;
                set {
                    if (Vitality_Mantle_Mantle_Health_raw == value) return;
                    Vitality_Mantle_Mantle_Health_raw = value;
                    ChangedItems.Add(nameof(Vitality_Mantle_Mantle_Health));
                    OnPropertyChanged(nameof(Vitality_Mantle_Mantle_Health));
                }
            }

            [DisplayName("Offset")]
            public long Vitality_Mantle_Mantle_Health_offset { get; private set; }

            public const int lastSortIndex = 2200;

            public static ObservableMhwStructCollection<Mantle_Params_1_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Mantle_Params_1_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Mantle_Params_1_ LoadData(BinaryReader reader, ulong i) {
                var data = new Mantle_Params_1_();
                data.Index = i;
                data.Unk_1_offset = reader.BaseStream.Position;
                data.Unk_1_raw = reader.ReadSingle();
                data.Unk_2_offset = reader.BaseStream.Position;
                data.Unk_2_raw = reader.ReadSingle();
                data.Unk_3_offset = reader.BaseStream.Position;
                data.Unk_3_raw = reader.ReadSingle();
                data.Unk_4_offset = reader.BaseStream.Position;
                data.Unk_4_raw = reader.ReadSingle();
                data.Unk_5_offset = reader.BaseStream.Position;
                data.Unk_5_raw = reader.ReadSingle();
                data.Unk_6_offset = reader.BaseStream.Position;
                data.Unk_6_raw = reader.ReadUInt32();
                data.Unk_7_offset = reader.BaseStream.Position;
                data.Unk_7_raw = reader.ReadSingle();
                data.Unk_8_offset = reader.BaseStream.Position;
                data.Unk_8_raw = reader.ReadSingle();
                data.Unk_9_offset = reader.BaseStream.Position;
                data.Unk_9_raw = reader.ReadSingle();
                data.Ghillie_Mantle_Cooldown_offset = reader.BaseStream.Position;
                data.Ghillie_Mantle_Cooldown_raw = reader.ReadSingle();
                data.Ghillie_Mantle_Duration_offset = reader.BaseStream.Position;
                data.Ghillie_Mantle_Duration_raw = reader.ReadSingle();
                data.Ghillie_Mantle_Unk1_offset = reader.BaseStream.Position;
                data.Ghillie_Mantle_Unk1_raw = reader.ReadSingle();
                data.Ghillie_Mantle_Unk2_offset = reader.BaseStream.Position;
                data.Ghillie_Mantle_Unk2_raw = reader.ReadSingle();
                data.Temporal_Mantle_Cooldown_offset = reader.BaseStream.Position;
                data.Temporal_Mantle_Cooldown_raw = reader.ReadSingle();
                data.Temporal_Mantle_Duration_offset = reader.BaseStream.Position;
                data.Temporal_Mantle_Duration_raw = reader.ReadSingle();
                data.Temporal_Mantle_Unk1_offset = reader.BaseStream.Position;
                data.Temporal_Mantle_Unk1_raw = reader.ReadSingle();
                data.Temporal_Mantle_Unk2_offset = reader.BaseStream.Position;
                data.Temporal_Mantle_Unk2_raw = reader.ReadSingle();
                data.Temporal_Mantle_Unk3_offset = reader.BaseStream.Position;
                data.Temporal_Mantle_Unk3_raw = reader.ReadSingle();
                data.Temporal_Mantle_Unk4_offset = reader.BaseStream.Position;
                data.Temporal_Mantle_Unk4_raw = reader.ReadSingle();
                data.Temporal_Mantle_Unk5_offset = reader.BaseStream.Position;
                data.Temporal_Mantle_Unk5_raw = reader.ReadSingle();
                data.Temporal_Mantle_Unk6_offset = reader.BaseStream.Position;
                data.Temporal_Mantle_Unk6_raw = reader.ReadSingle();
                data.Temporal_Mantle_Unk7_offset = reader.BaseStream.Position;
                data.Temporal_Mantle_Unk7_raw = reader.ReadSingle();
                data.Temporal_Mantle_Unk8_offset = reader.BaseStream.Position;
                data.Temporal_Mantle_Unk8_raw = reader.ReadSingle();
                data.Temporal_Mantle_Unk9_offset = reader.BaseStream.Position;
                data.Temporal_Mantle_Unk9_raw = reader.ReadSingle();
                data.Temporal_Mantle_Unk10_offset = reader.BaseStream.Position;
                data.Temporal_Mantle_Unk10_raw = reader.ReadSingle();
                data.Temporal_Mantle_Unk11_offset = reader.BaseStream.Position;
                data.Temporal_Mantle_Unk11_raw = reader.ReadSingle();
                data.Temporal_Mantle_Unk12_offset = reader.BaseStream.Position;
                data.Temporal_Mantle_Unk12_raw = reader.ReadSingle();
                data.Temporal_Mantle_Duration_Decrease_Per_Hit_offset = reader.BaseStream.Position;
                data.Temporal_Mantle_Duration_Decrease_Per_Hit_raw = reader.ReadSingle();
                data.Health_Booster_Cooldown_offset = reader.BaseStream.Position;
                data.Health_Booster_Cooldown_raw = reader.ReadSingle();
                data.Health_Booster_Duration_offset = reader.BaseStream.Position;
                data.Health_Booster_Duration_raw = reader.ReadSingle();
                data.Health_Booster_Upgraded_Duration_offset = reader.BaseStream.Position;
                data.Health_Booster_Upgraded_Duration_raw = reader.ReadSingle();
                data.Rocksteady_Mantle_Cooldown_offset = reader.BaseStream.Position;
                data.Rocksteady_Mantle_Cooldown_raw = reader.ReadSingle();
                data.Rocksteady_Mantle_Duration_offset = reader.BaseStream.Position;
                data.Rocksteady_Mantle_Duration_raw = reader.ReadSingle();
                data.Rocksteady_Mantle_Unk1_offset = reader.BaseStream.Position;
                data.Rocksteady_Mantle_Unk1_raw = reader.ReadSingle();
                data.Rocksteady_Mantle_Damage_Resist_offset = reader.BaseStream.Position;
                data.Rocksteady_Mantle_Damage_Resist_raw = reader.ReadSingle();
                data.Rocksteady_Mantle_Unk2_offset = reader.BaseStream.Position;
                data.Rocksteady_Mantle_Unk2_raw = reader.ReadSingle();
                data.Challenger_Mantle_Cooldown_offset = reader.BaseStream.Position;
                data.Challenger_Mantle_Cooldown_raw = reader.ReadSingle();
                data.Challenger_Mantle_Duration_offset = reader.BaseStream.Position;
                data.Challenger_Mantle_Duration_raw = reader.ReadSingle();
                data.Challenger_Mantle_Unk1_offset = reader.BaseStream.Position;
                data.Challenger_Mantle_Unk1_raw = reader.ReadSingle();
                data.Challenger_Mantle_Unk2_offset = reader.BaseStream.Position;
                data.Challenger_Mantle_Unk2_raw = reader.ReadSingle();
                data.Vitality_Mantle_Cooldown_offset = reader.BaseStream.Position;
                data.Vitality_Mantle_Cooldown_raw = reader.ReadSingle();
                data.Vitality_Mantle_Duration_offset = reader.BaseStream.Position;
                data.Vitality_Mantle_Duration_raw = reader.ReadSingle();
                data.Vitality_Mantle_Mantle_Health_offset = reader.BaseStream.Position;
                data.Vitality_Mantle_Mantle_Health_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_1_raw);
                writer.Write(Unk_2_raw);
                writer.Write(Unk_3_raw);
                writer.Write(Unk_4_raw);
                writer.Write(Unk_5_raw);
                writer.Write(Unk_6_raw);
                writer.Write(Unk_7_raw);
                writer.Write(Unk_8_raw);
                writer.Write(Unk_9_raw);
                writer.Write(Ghillie_Mantle_Cooldown_raw);
                writer.Write(Ghillie_Mantle_Duration_raw);
                writer.Write(Ghillie_Mantle_Unk1_raw);
                writer.Write(Ghillie_Mantle_Unk2_raw);
                writer.Write(Temporal_Mantle_Cooldown_raw);
                writer.Write(Temporal_Mantle_Duration_raw);
                writer.Write(Temporal_Mantle_Unk1_raw);
                writer.Write(Temporal_Mantle_Unk2_raw);
                writer.Write(Temporal_Mantle_Unk3_raw);
                writer.Write(Temporal_Mantle_Unk4_raw);
                writer.Write(Temporal_Mantle_Unk5_raw);
                writer.Write(Temporal_Mantle_Unk6_raw);
                writer.Write(Temporal_Mantle_Unk7_raw);
                writer.Write(Temporal_Mantle_Unk8_raw);
                writer.Write(Temporal_Mantle_Unk9_raw);
                writer.Write(Temporal_Mantle_Unk10_raw);
                writer.Write(Temporal_Mantle_Unk11_raw);
                writer.Write(Temporal_Mantle_Unk12_raw);
                writer.Write(Temporal_Mantle_Duration_Decrease_Per_Hit_raw);
                writer.Write(Health_Booster_Cooldown_raw);
                writer.Write(Health_Booster_Duration_raw);
                writer.Write(Health_Booster_Upgraded_Duration_raw);
                writer.Write(Rocksteady_Mantle_Cooldown_raw);
                writer.Write(Rocksteady_Mantle_Duration_raw);
                writer.Write(Rocksteady_Mantle_Unk1_raw);
                writer.Write(Rocksteady_Mantle_Damage_Resist_raw);
                writer.Write(Rocksteady_Mantle_Unk2_raw);
                writer.Write(Challenger_Mantle_Cooldown_raw);
                writer.Write(Challenger_Mantle_Duration_raw);
                writer.Write(Challenger_Mantle_Unk1_raw);
                writer.Write(Challenger_Mantle_Unk2_raw);
                writer.Write(Vitality_Mantle_Cooldown_raw);
                writer.Write(Vitality_Mantle_Duration_raw);
                writer.Write(Vitality_Mantle_Mantle_Health_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Unk 1", "Unk_1", "Unk_1_offset"),
                    new MultiStructItemCustomView(this, "Unk 2", "Unk_2", "Unk_2_offset"),
                    new MultiStructItemCustomView(this, "Unk 3", "Unk_3", "Unk_3_offset"),
                    new MultiStructItemCustomView(this, "Unk 4", "Unk_4", "Unk_4_offset"),
                    new MultiStructItemCustomView(this, "Unk 5", "Unk_5", "Unk_5_offset"),
                    new MultiStructItemCustomView(this, "Unk 6", "Unk_6", "Unk_6_offset"),
                    new MultiStructItemCustomView(this, "Unk 7", "Unk_7", "Unk_7_offset"),
                    new MultiStructItemCustomView(this, "Unk 8", "Unk_8", "Unk_8_offset"),
                    new MultiStructItemCustomView(this, "Unk 9", "Unk_9", "Unk_9_offset"),
                    new MultiStructItemCustomView(this, "Ghillie Mantle: Cooldown", "Ghillie_Mantle_Cooldown", "Ghillie_Mantle_Cooldown_offset"),
                    new MultiStructItemCustomView(this, "Ghillie Mantle: Duration", "Ghillie_Mantle_Duration", "Ghillie_Mantle_Duration_offset"),
                    new MultiStructItemCustomView(this, "Ghillie Mantle: Unk1", "Ghillie_Mantle_Unk1", "Ghillie_Mantle_Unk1_offset"),
                    new MultiStructItemCustomView(this, "Ghillie Mantle: Unk2", "Ghillie_Mantle_Unk2", "Ghillie_Mantle_Unk2_offset"),
                    new MultiStructItemCustomView(this, "Temporal Mantle: Cooldown", "Temporal_Mantle_Cooldown", "Temporal_Mantle_Cooldown_offset"),
                    new MultiStructItemCustomView(this, "Temporal Mantle: Duration", "Temporal_Mantle_Duration", "Temporal_Mantle_Duration_offset"),
                    new MultiStructItemCustomView(this, "Temporal Mantle: Unk1", "Temporal_Mantle_Unk1", "Temporal_Mantle_Unk1_offset"),
                    new MultiStructItemCustomView(this, "Temporal Mantle: Unk2", "Temporal_Mantle_Unk2", "Temporal_Mantle_Unk2_offset"),
                    new MultiStructItemCustomView(this, "Temporal Mantle: Unk3", "Temporal_Mantle_Unk3", "Temporal_Mantle_Unk3_offset"),
                    new MultiStructItemCustomView(this, "Temporal Mantle: Unk4", "Temporal_Mantle_Unk4", "Temporal_Mantle_Unk4_offset"),
                    new MultiStructItemCustomView(this, "Temporal Mantle: Unk5", "Temporal_Mantle_Unk5", "Temporal_Mantle_Unk5_offset"),
                    new MultiStructItemCustomView(this, "Temporal Mantle: Unk6", "Temporal_Mantle_Unk6", "Temporal_Mantle_Unk6_offset"),
                    new MultiStructItemCustomView(this, "Temporal Mantle: Unk7", "Temporal_Mantle_Unk7", "Temporal_Mantle_Unk7_offset"),
                    new MultiStructItemCustomView(this, "Temporal Mantle: Unk8", "Temporal_Mantle_Unk8", "Temporal_Mantle_Unk8_offset"),
                    new MultiStructItemCustomView(this, "Temporal Mantle: Unk9", "Temporal_Mantle_Unk9", "Temporal_Mantle_Unk9_offset"),
                    new MultiStructItemCustomView(this, "Temporal Mantle: Unk10", "Temporal_Mantle_Unk10", "Temporal_Mantle_Unk10_offset"),
                    new MultiStructItemCustomView(this, "Temporal Mantle: Unk11", "Temporal_Mantle_Unk11", "Temporal_Mantle_Unk11_offset"),
                    new MultiStructItemCustomView(this, "Temporal Mantle: Unk12", "Temporal_Mantle_Unk12", "Temporal_Mantle_Unk12_offset"),
                    new MultiStructItemCustomView(this, "Temporal Mantle: Duration Decrease Per Hit", "Temporal_Mantle_Duration_Decrease_Per_Hit", "Temporal_Mantle_Duration_Decrease_Per_Hit_offset"),
                    new MultiStructItemCustomView(this, "Health Booster: Cooldown", "Health_Booster_Cooldown", "Health_Booster_Cooldown_offset"),
                    new MultiStructItemCustomView(this, "Health Booster: Duration", "Health_Booster_Duration", "Health_Booster_Duration_offset"),
                    new MultiStructItemCustomView(this, "Health Booster: Upgraded Duration", "Health_Booster_Upgraded_Duration", "Health_Booster_Upgraded_Duration_offset"),
                    new MultiStructItemCustomView(this, "Rocksteady Mantle: Cooldown", "Rocksteady_Mantle_Cooldown", "Rocksteady_Mantle_Cooldown_offset"),
                    new MultiStructItemCustomView(this, "Rocksteady Mantle: Duration", "Rocksteady_Mantle_Duration", "Rocksteady_Mantle_Duration_offset"),
                    new MultiStructItemCustomView(this, "Rocksteady Mantle: Unk1", "Rocksteady_Mantle_Unk1", "Rocksteady_Mantle_Unk1_offset"),
                    new MultiStructItemCustomView(this, "Rocksteady Mantle: Damage Resist", "Rocksteady_Mantle_Damage_Resist", "Rocksteady_Mantle_Damage_Resist_offset"),
                    new MultiStructItemCustomView(this, "Rocksteady Mantle: Unk2", "Rocksteady_Mantle_Unk2", "Rocksteady_Mantle_Unk2_offset"),
                    new MultiStructItemCustomView(this, "Challenger Mantle: Cooldown", "Challenger_Mantle_Cooldown", "Challenger_Mantle_Cooldown_offset"),
                    new MultiStructItemCustomView(this, "Challenger Mantle: Duration", "Challenger_Mantle_Duration", "Challenger_Mantle_Duration_offset"),
                    new MultiStructItemCustomView(this, "Challenger Mantle: Unk1", "Challenger_Mantle_Unk1", "Challenger_Mantle_Unk1_offset"),
                    new MultiStructItemCustomView(this, "Challenger Mantle: Unk2", "Challenger_Mantle_Unk2", "Challenger_Mantle_Unk2_offset"),
                    new MultiStructItemCustomView(this, "Vitality Mantle: Cooldown", "Vitality_Mantle_Cooldown", "Vitality_Mantle_Cooldown_offset"),
                    new MultiStructItemCustomView(this, "Vitality Mantle: Duration", "Vitality_Mantle_Duration", "Vitality_Mantle_Duration_offset"),
                    new MultiStructItemCustomView(this, "Vitality Mantle: Mantle Health", "Vitality_Mantle_Mantle_Health", "Vitality_Mantle_Mantle_Health_offset"),
                };
            }
        }

        public partial class Mantle_Params_2_ : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 5;
            public const string GridName = "Mantle Params (2)";

            protected float Cooldown_raw;
            public const string Cooldown_displayName = "Cooldown";
            public const int Cooldown_sortIndex = 50;
            [SortOrder(Cooldown_sortIndex)]
            [DisplayName(Cooldown_displayName)]
            public virtual float Cooldown {
                get => Cooldown_raw;
                set {
                    if (Cooldown_raw == value) return;
                    Cooldown_raw = value;
                    ChangedItems.Add(nameof(Cooldown));
                    OnPropertyChanged(nameof(Cooldown));
                }
            }

            protected float Duration_raw;
            public const string Duration_displayName = "Duration";
            public const int Duration_sortIndex = 100;
            [SortOrder(Duration_sortIndex)]
            [DisplayName(Duration_displayName)]
            public virtual float Duration {
                get => Duration_raw;
                set {
                    if (Duration_raw == value) return;
                    Duration_raw = value;
                    ChangedItems.Add(nameof(Duration));
                    OnPropertyChanged(nameof(Duration));
                }
            }

            protected float Damage_Reduction__raw;
            public const string Damage_Reduction__displayName = "Damage Reduction %";
            public const int Damage_Reduction__sortIndex = 150;
            [SortOrder(Damage_Reduction__sortIndex)]
            [DisplayName(Damage_Reduction__displayName)]
            public virtual float Damage_Reduction_ {
                get => Damage_Reduction__raw;
                set {
                    if (Damage_Reduction__raw == value) return;
                    Damage_Reduction__raw = value;
                    ChangedItems.Add(nameof(Damage_Reduction_));
                    OnPropertyChanged(nameof(Damage_Reduction_));
                }
            }

            public const int lastSortIndex = 200;

            public static ObservableMhwStructCollection<Mantle_Params_2_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Mantle_Params_2_>();
                const ulong count = 5UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Mantle_Params_2_ LoadData(BinaryReader reader, ulong i) {
                var data = new Mantle_Params_2_();
                data.Index = i;
                data.Cooldown_raw = reader.ReadSingle();
                data.Duration_raw = reader.ReadSingle();
                data.Damage_Reduction__raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Cooldown_raw);
                writer.Write(Duration_raw);
                writer.Write(Damage_Reduction__raw);
            }
        }

        public partial class Mantle_Params_3_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Mantle Params (3)";

            protected float Dragonproof_Mantle_Dragon_Damage_Multiplier_raw;
            public const string Dragonproof_Mantle_Dragon_Damage_Multiplier_displayName = "Dragonproof Mantle: Dragon Damage Multiplier";
            public const int Dragonproof_Mantle_Dragon_Damage_Multiplier_sortIndex = 50;
            [SortOrder(Dragonproof_Mantle_Dragon_Damage_Multiplier_sortIndex)]
            [DisplayName(Dragonproof_Mantle_Dragon_Damage_Multiplier_displayName)]
            public virtual float Dragonproof_Mantle_Dragon_Damage_Multiplier {
                get => Dragonproof_Mantle_Dragon_Damage_Multiplier_raw;
                set {
                    if (Dragonproof_Mantle_Dragon_Damage_Multiplier_raw == value) return;
                    Dragonproof_Mantle_Dragon_Damage_Multiplier_raw = value;
                    ChangedItems.Add(nameof(Dragonproof_Mantle_Dragon_Damage_Multiplier));
                    OnPropertyChanged(nameof(Dragonproof_Mantle_Dragon_Damage_Multiplier));
                }
            }

            [DisplayName("Offset")]
            public long Dragonproof_Mantle_Dragon_Damage_Multiplier_offset { get; private set; }

            protected float Cleanser_Booster_Cooldown_raw;
            public const string Cleanser_Booster_Cooldown_displayName = "Cleanser Booster: Cooldown";
            public const int Cleanser_Booster_Cooldown_sortIndex = 100;
            [SortOrder(Cleanser_Booster_Cooldown_sortIndex)]
            [DisplayName(Cleanser_Booster_Cooldown_displayName)]
            public virtual float Cleanser_Booster_Cooldown {
                get => Cleanser_Booster_Cooldown_raw;
                set {
                    if (Cleanser_Booster_Cooldown_raw == value) return;
                    Cleanser_Booster_Cooldown_raw = value;
                    ChangedItems.Add(nameof(Cleanser_Booster_Cooldown));
                    OnPropertyChanged(nameof(Cleanser_Booster_Cooldown));
                }
            }

            [DisplayName("Offset")]
            public long Cleanser_Booster_Cooldown_offset { get; private set; }

            protected float Cleanser_Booster_Duration_raw;
            public const string Cleanser_Booster_Duration_displayName = "Cleanser Booster: Duration";
            public const int Cleanser_Booster_Duration_sortIndex = 150;
            [SortOrder(Cleanser_Booster_Duration_sortIndex)]
            [DisplayName(Cleanser_Booster_Duration_displayName)]
            public virtual float Cleanser_Booster_Duration {
                get => Cleanser_Booster_Duration_raw;
                set {
                    if (Cleanser_Booster_Duration_raw == value) return;
                    Cleanser_Booster_Duration_raw = value;
                    ChangedItems.Add(nameof(Cleanser_Booster_Duration));
                    OnPropertyChanged(nameof(Cleanser_Booster_Duration));
                }
            }

            [DisplayName("Offset")]
            public long Cleanser_Booster_Duration_offset { get; private set; }

            protected float Cleanser_Booster_Upgraded_Duration_raw;
            public const string Cleanser_Booster_Upgraded_Duration_displayName = "Cleanser Booster: Upgraded Duration";
            public const int Cleanser_Booster_Upgraded_Duration_sortIndex = 200;
            [SortOrder(Cleanser_Booster_Upgraded_Duration_sortIndex)]
            [DisplayName(Cleanser_Booster_Upgraded_Duration_displayName)]
            public virtual float Cleanser_Booster_Upgraded_Duration {
                get => Cleanser_Booster_Upgraded_Duration_raw;
                set {
                    if (Cleanser_Booster_Upgraded_Duration_raw == value) return;
                    Cleanser_Booster_Upgraded_Duration_raw = value;
                    ChangedItems.Add(nameof(Cleanser_Booster_Upgraded_Duration));
                    OnPropertyChanged(nameof(Cleanser_Booster_Upgraded_Duration));
                }
            }

            [DisplayName("Offset")]
            public long Cleanser_Booster_Upgraded_Duration_offset { get; private set; }

            protected float Cleanser_Booster_Unk1_raw;
            public const string Cleanser_Booster_Unk1_displayName = "Cleanser Booster: Unk1";
            public const int Cleanser_Booster_Unk1_sortIndex = 250;
            [SortOrder(Cleanser_Booster_Unk1_sortIndex)]
            [DisplayName(Cleanser_Booster_Unk1_displayName)]
            public virtual float Cleanser_Booster_Unk1 {
                get => Cleanser_Booster_Unk1_raw;
                set {
                    if (Cleanser_Booster_Unk1_raw == value) return;
                    Cleanser_Booster_Unk1_raw = value;
                    ChangedItems.Add(nameof(Cleanser_Booster_Unk1));
                    OnPropertyChanged(nameof(Cleanser_Booster_Unk1));
                }
            }

            [DisplayName("Offset")]
            public long Cleanser_Booster_Unk1_offset { get; private set; }

            protected float Cleanser_Booster_Unk2_raw;
            public const string Cleanser_Booster_Unk2_displayName = "Cleanser Booster: Unk2";
            public const int Cleanser_Booster_Unk2_sortIndex = 300;
            [SortOrder(Cleanser_Booster_Unk2_sortIndex)]
            [DisplayName(Cleanser_Booster_Unk2_displayName)]
            public virtual float Cleanser_Booster_Unk2 {
                get => Cleanser_Booster_Unk2_raw;
                set {
                    if (Cleanser_Booster_Unk2_raw == value) return;
                    Cleanser_Booster_Unk2_raw = value;
                    ChangedItems.Add(nameof(Cleanser_Booster_Unk2));
                    OnPropertyChanged(nameof(Cleanser_Booster_Unk2));
                }
            }

            [DisplayName("Offset")]
            public long Cleanser_Booster_Unk2_offset { get; private set; }

            protected float Cleanser_Booster_Unk3_raw;
            public const string Cleanser_Booster_Unk3_displayName = "Cleanser Booster: Unk3";
            public const int Cleanser_Booster_Unk3_sortIndex = 350;
            [SortOrder(Cleanser_Booster_Unk3_sortIndex)]
            [DisplayName(Cleanser_Booster_Unk3_displayName)]
            public virtual float Cleanser_Booster_Unk3 {
                get => Cleanser_Booster_Unk3_raw;
                set {
                    if (Cleanser_Booster_Unk3_raw == value) return;
                    Cleanser_Booster_Unk3_raw = value;
                    ChangedItems.Add(nameof(Cleanser_Booster_Unk3));
                    OnPropertyChanged(nameof(Cleanser_Booster_Unk3));
                }
            }

            [DisplayName("Offset")]
            public long Cleanser_Booster_Unk3_offset { get; private set; }

            protected float Cleanser_Booster_Unk4_raw;
            public const string Cleanser_Booster_Unk4_displayName = "Cleanser Booster: Unk4";
            public const int Cleanser_Booster_Unk4_sortIndex = 400;
            [SortOrder(Cleanser_Booster_Unk4_sortIndex)]
            [DisplayName(Cleanser_Booster_Unk4_displayName)]
            public virtual float Cleanser_Booster_Unk4 {
                get => Cleanser_Booster_Unk4_raw;
                set {
                    if (Cleanser_Booster_Unk4_raw == value) return;
                    Cleanser_Booster_Unk4_raw = value;
                    ChangedItems.Add(nameof(Cleanser_Booster_Unk4));
                    OnPropertyChanged(nameof(Cleanser_Booster_Unk4));
                }
            }

            [DisplayName("Offset")]
            public long Cleanser_Booster_Unk4_offset { get; private set; }

            protected float Glider_Mantle_Cooldown_raw;
            public const string Glider_Mantle_Cooldown_displayName = "Glider Mantle: Cooldown";
            public const int Glider_Mantle_Cooldown_sortIndex = 450;
            [SortOrder(Glider_Mantle_Cooldown_sortIndex)]
            [DisplayName(Glider_Mantle_Cooldown_displayName)]
            public virtual float Glider_Mantle_Cooldown {
                get => Glider_Mantle_Cooldown_raw;
                set {
                    if (Glider_Mantle_Cooldown_raw == value) return;
                    Glider_Mantle_Cooldown_raw = value;
                    ChangedItems.Add(nameof(Glider_Mantle_Cooldown));
                    OnPropertyChanged(nameof(Glider_Mantle_Cooldown));
                }
            }

            [DisplayName("Offset")]
            public long Glider_Mantle_Cooldown_offset { get; private set; }

            protected float Glider_Mantle_Duration_raw;
            public const string Glider_Mantle_Duration_displayName = "Glider Mantle: Duration";
            public const int Glider_Mantle_Duration_sortIndex = 500;
            [SortOrder(Glider_Mantle_Duration_sortIndex)]
            [DisplayName(Glider_Mantle_Duration_displayName)]
            public virtual float Glider_Mantle_Duration {
                get => Glider_Mantle_Duration_raw;
                set {
                    if (Glider_Mantle_Duration_raw == value) return;
                    Glider_Mantle_Duration_raw = value;
                    ChangedItems.Add(nameof(Glider_Mantle_Duration));
                    OnPropertyChanged(nameof(Glider_Mantle_Duration));
                }
            }

            [DisplayName("Offset")]
            public long Glider_Mantle_Duration_offset { get; private set; }

            protected float Glider_Mantle_Mount_Multiplier_raw;
            public const string Glider_Mantle_Mount_Multiplier_displayName = "Glider Mantle: Mount Multiplier";
            public const int Glider_Mantle_Mount_Multiplier_sortIndex = 550;
            [SortOrder(Glider_Mantle_Mount_Multiplier_sortIndex)]
            [DisplayName(Glider_Mantle_Mount_Multiplier_displayName)]
            public virtual float Glider_Mantle_Mount_Multiplier {
                get => Glider_Mantle_Mount_Multiplier_raw;
                set {
                    if (Glider_Mantle_Mount_Multiplier_raw == value) return;
                    Glider_Mantle_Mount_Multiplier_raw = value;
                    ChangedItems.Add(nameof(Glider_Mantle_Mount_Multiplier));
                    OnPropertyChanged(nameof(Glider_Mantle_Mount_Multiplier));
                }
            }

            [DisplayName("Offset")]
            public long Glider_Mantle_Mount_Multiplier_offset { get; private set; }

            protected float Evasion_Mantle_Cooldown_raw;
            public const string Evasion_Mantle_Cooldown_displayName = "Evasion Mantle: Cooldown";
            public const int Evasion_Mantle_Cooldown_sortIndex = 600;
            [SortOrder(Evasion_Mantle_Cooldown_sortIndex)]
            [DisplayName(Evasion_Mantle_Cooldown_displayName)]
            public virtual float Evasion_Mantle_Cooldown {
                get => Evasion_Mantle_Cooldown_raw;
                set {
                    if (Evasion_Mantle_Cooldown_raw == value) return;
                    Evasion_Mantle_Cooldown_raw = value;
                    ChangedItems.Add(nameof(Evasion_Mantle_Cooldown));
                    OnPropertyChanged(nameof(Evasion_Mantle_Cooldown));
                }
            }

            [DisplayName("Offset")]
            public long Evasion_Mantle_Cooldown_offset { get; private set; }

            protected float Evasion_Mantle_Duration_raw;
            public const string Evasion_Mantle_Duration_displayName = "Evasion Mantle: Duration";
            public const int Evasion_Mantle_Duration_sortIndex = 650;
            [SortOrder(Evasion_Mantle_Duration_sortIndex)]
            [DisplayName(Evasion_Mantle_Duration_displayName)]
            public virtual float Evasion_Mantle_Duration {
                get => Evasion_Mantle_Duration_raw;
                set {
                    if (Evasion_Mantle_Duration_raw == value) return;
                    Evasion_Mantle_Duration_raw = value;
                    ChangedItems.Add(nameof(Evasion_Mantle_Duration));
                    OnPropertyChanged(nameof(Evasion_Mantle_Duration));
                }
            }

            [DisplayName("Offset")]
            public long Evasion_Mantle_Duration_offset { get; private set; }

            protected float Evasion_Mantle_Attack_Boost_Duration_raw;
            public const string Evasion_Mantle_Attack_Boost_Duration_displayName = "Evasion Mantle: Attack Boost Duration";
            public const int Evasion_Mantle_Attack_Boost_Duration_sortIndex = 700;
            [SortOrder(Evasion_Mantle_Attack_Boost_Duration_sortIndex)]
            [DisplayName(Evasion_Mantle_Attack_Boost_Duration_displayName)]
            public virtual float Evasion_Mantle_Attack_Boost_Duration {
                get => Evasion_Mantle_Attack_Boost_Duration_raw;
                set {
                    if (Evasion_Mantle_Attack_Boost_Duration_raw == value) return;
                    Evasion_Mantle_Attack_Boost_Duration_raw = value;
                    ChangedItems.Add(nameof(Evasion_Mantle_Attack_Boost_Duration));
                    OnPropertyChanged(nameof(Evasion_Mantle_Attack_Boost_Duration));
                }
            }

            [DisplayName("Offset")]
            public long Evasion_Mantle_Attack_Boost_Duration_offset { get; private set; }

            protected float Evasion_Mantle_Evasion_Multiplier_raw;
            public const string Evasion_Mantle_Evasion_Multiplier_displayName = "Evasion Mantle: Evasion Multiplier";
            public const int Evasion_Mantle_Evasion_Multiplier_sortIndex = 750;
            [SortOrder(Evasion_Mantle_Evasion_Multiplier_sortIndex)]
            [DisplayName(Evasion_Mantle_Evasion_Multiplier_displayName)]
            public virtual float Evasion_Mantle_Evasion_Multiplier {
                get => Evasion_Mantle_Evasion_Multiplier_raw;
                set {
                    if (Evasion_Mantle_Evasion_Multiplier_raw == value) return;
                    Evasion_Mantle_Evasion_Multiplier_raw = value;
                    ChangedItems.Add(nameof(Evasion_Mantle_Evasion_Multiplier));
                    OnPropertyChanged(nameof(Evasion_Mantle_Evasion_Multiplier));
                }
            }

            [DisplayName("Offset")]
            public long Evasion_Mantle_Evasion_Multiplier_offset { get; private set; }

            protected float Evasion_Mantle_Unk1_raw;
            public const string Evasion_Mantle_Unk1_displayName = "Evasion Mantle: Unk1";
            public const int Evasion_Mantle_Unk1_sortIndex = 800;
            [SortOrder(Evasion_Mantle_Unk1_sortIndex)]
            [DisplayName(Evasion_Mantle_Unk1_displayName)]
            public virtual float Evasion_Mantle_Unk1 {
                get => Evasion_Mantle_Unk1_raw;
                set {
                    if (Evasion_Mantle_Unk1_raw == value) return;
                    Evasion_Mantle_Unk1_raw = value;
                    ChangedItems.Add(nameof(Evasion_Mantle_Unk1));
                    OnPropertyChanged(nameof(Evasion_Mantle_Unk1));
                }
            }

            [DisplayName("Offset")]
            public long Evasion_Mantle_Unk1_offset { get; private set; }

            protected byte Evasion_Mantle_Unk2_raw;
            public const string Evasion_Mantle_Unk2_displayName = "Evasion Mantle: Unk2";
            public const int Evasion_Mantle_Unk2_sortIndex = 850;
            [SortOrder(Evasion_Mantle_Unk2_sortIndex)]
            [DisplayName(Evasion_Mantle_Unk2_displayName)]
            public virtual byte Evasion_Mantle_Unk2 {
                get => Evasion_Mantle_Unk2_raw;
                set {
                    if (Evasion_Mantle_Unk2_raw == value) return;
                    Evasion_Mantle_Unk2_raw = value;
                    ChangedItems.Add(nameof(Evasion_Mantle_Unk2));
                    OnPropertyChanged(nameof(Evasion_Mantle_Unk2));
                }
            }

            [DisplayName("Offset")]
            public long Evasion_Mantle_Unk2_offset { get; private set; }

            protected ushort Evasion_Mantle_Unk3_raw;
            public const string Evasion_Mantle_Unk3_displayName = "Evasion Mantle: Unk3";
            public const int Evasion_Mantle_Unk3_sortIndex = 900;
            [SortOrder(Evasion_Mantle_Unk3_sortIndex)]
            [DisplayName(Evasion_Mantle_Unk3_displayName)]
            public virtual ushort Evasion_Mantle_Unk3 {
                get => Evasion_Mantle_Unk3_raw;
                set {
                    if (Evasion_Mantle_Unk3_raw == value) return;
                    Evasion_Mantle_Unk3_raw = value;
                    ChangedItems.Add(nameof(Evasion_Mantle_Unk3));
                    OnPropertyChanged(nameof(Evasion_Mantle_Unk3));
                }
            }

            [DisplayName("Offset")]
            public long Evasion_Mantle_Unk3_offset { get; private set; }

            protected ushort Evasion_Mantle_Unk4_raw;
            public const string Evasion_Mantle_Unk4_displayName = "Evasion Mantle: Unk4";
            public const int Evasion_Mantle_Unk4_sortIndex = 950;
            [SortOrder(Evasion_Mantle_Unk4_sortIndex)]
            [DisplayName(Evasion_Mantle_Unk4_displayName)]
            public virtual ushort Evasion_Mantle_Unk4 {
                get => Evasion_Mantle_Unk4_raw;
                set {
                    if (Evasion_Mantle_Unk4_raw == value) return;
                    Evasion_Mantle_Unk4_raw = value;
                    ChangedItems.Add(nameof(Evasion_Mantle_Unk4));
                    OnPropertyChanged(nameof(Evasion_Mantle_Unk4));
                }
            }

            [DisplayName("Offset")]
            public long Evasion_Mantle_Unk4_offset { get; private set; }

            protected float Evasion_Mantle_Unk5_raw;
            public const string Evasion_Mantle_Unk5_displayName = "Evasion Mantle: Unk5";
            public const int Evasion_Mantle_Unk5_sortIndex = 1000;
            [SortOrder(Evasion_Mantle_Unk5_sortIndex)]
            [DisplayName(Evasion_Mantle_Unk5_displayName)]
            public virtual float Evasion_Mantle_Unk5 {
                get => Evasion_Mantle_Unk5_raw;
                set {
                    if (Evasion_Mantle_Unk5_raw == value) return;
                    Evasion_Mantle_Unk5_raw = value;
                    ChangedItems.Add(nameof(Evasion_Mantle_Unk5));
                    OnPropertyChanged(nameof(Evasion_Mantle_Unk5));
                }
            }

            [DisplayName("Offset")]
            public long Evasion_Mantle_Unk5_offset { get; private set; }

            protected ushort Evasion_Mantle_Unk6_raw;
            public const string Evasion_Mantle_Unk6_displayName = "Evasion Mantle: Unk6";
            public const int Evasion_Mantle_Unk6_sortIndex = 1050;
            [SortOrder(Evasion_Mantle_Unk6_sortIndex)]
            [DisplayName(Evasion_Mantle_Unk6_displayName)]
            public virtual ushort Evasion_Mantle_Unk6 {
                get => Evasion_Mantle_Unk6_raw;
                set {
                    if (Evasion_Mantle_Unk6_raw == value) return;
                    Evasion_Mantle_Unk6_raw = value;
                    ChangedItems.Add(nameof(Evasion_Mantle_Unk6));
                    OnPropertyChanged(nameof(Evasion_Mantle_Unk6));
                }
            }

            [DisplayName("Offset")]
            public long Evasion_Mantle_Unk6_offset { get; private set; }

            protected float Impact_Mantle_Cooldown_raw;
            public const string Impact_Mantle_Cooldown_displayName = "Impact Mantle: Cooldown";
            public const int Impact_Mantle_Cooldown_sortIndex = 1100;
            [SortOrder(Impact_Mantle_Cooldown_sortIndex)]
            [DisplayName(Impact_Mantle_Cooldown_displayName)]
            public virtual float Impact_Mantle_Cooldown {
                get => Impact_Mantle_Cooldown_raw;
                set {
                    if (Impact_Mantle_Cooldown_raw == value) return;
                    Impact_Mantle_Cooldown_raw = value;
                    ChangedItems.Add(nameof(Impact_Mantle_Cooldown));
                    OnPropertyChanged(nameof(Impact_Mantle_Cooldown));
                }
            }

            [DisplayName("Offset")]
            public long Impact_Mantle_Cooldown_offset { get; private set; }

            protected float Impact_Mantle_Duration_raw;
            public const string Impact_Mantle_Duration_displayName = "Impact Mantle: Duration";
            public const int Impact_Mantle_Duration_sortIndex = 1150;
            [SortOrder(Impact_Mantle_Duration_sortIndex)]
            [DisplayName(Impact_Mantle_Duration_displayName)]
            public virtual float Impact_Mantle_Duration {
                get => Impact_Mantle_Duration_raw;
                set {
                    if (Impact_Mantle_Duration_raw == value) return;
                    Impact_Mantle_Duration_raw = value;
                    ChangedItems.Add(nameof(Impact_Mantle_Duration));
                    OnPropertyChanged(nameof(Impact_Mantle_Duration));
                }
            }

            [DisplayName("Offset")]
            public long Impact_Mantle_Duration_offset { get; private set; }

            protected float Impact_Mantle_Motion_Value_Needed_for_Light_Attack_Stun_Bonus_raw;
            public const string Impact_Mantle_Motion_Value_Needed_for_Light_Attack_Stun_Bonus_displayName = "Impact Mantle: Motion Value Needed for Light Attack Stun Bonus";
            public const int Impact_Mantle_Motion_Value_Needed_for_Light_Attack_Stun_Bonus_sortIndex = 1200;
            [SortOrder(Impact_Mantle_Motion_Value_Needed_for_Light_Attack_Stun_Bonus_sortIndex)]
            [DisplayName(Impact_Mantle_Motion_Value_Needed_for_Light_Attack_Stun_Bonus_displayName)]
            public virtual float Impact_Mantle_Motion_Value_Needed_for_Light_Attack_Stun_Bonus {
                get => Impact_Mantle_Motion_Value_Needed_for_Light_Attack_Stun_Bonus_raw;
                set {
                    if (Impact_Mantle_Motion_Value_Needed_for_Light_Attack_Stun_Bonus_raw == value) return;
                    Impact_Mantle_Motion_Value_Needed_for_Light_Attack_Stun_Bonus_raw = value;
                    ChangedItems.Add(nameof(Impact_Mantle_Motion_Value_Needed_for_Light_Attack_Stun_Bonus));
                    OnPropertyChanged(nameof(Impact_Mantle_Motion_Value_Needed_for_Light_Attack_Stun_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long Impact_Mantle_Motion_Value_Needed_for_Light_Attack_Stun_Bonus_offset { get; private set; }

            protected float Impact_Mantle_Motion_Value_Needed_for_Heavy_Attack_Stun_Bonus_raw;
            public const string Impact_Mantle_Motion_Value_Needed_for_Heavy_Attack_Stun_Bonus_displayName = "Impact Mantle: Motion Value Needed for Heavy Attack Stun Bonus";
            public const int Impact_Mantle_Motion_Value_Needed_for_Heavy_Attack_Stun_Bonus_sortIndex = 1250;
            [SortOrder(Impact_Mantle_Motion_Value_Needed_for_Heavy_Attack_Stun_Bonus_sortIndex)]
            [DisplayName(Impact_Mantle_Motion_Value_Needed_for_Heavy_Attack_Stun_Bonus_displayName)]
            public virtual float Impact_Mantle_Motion_Value_Needed_for_Heavy_Attack_Stun_Bonus {
                get => Impact_Mantle_Motion_Value_Needed_for_Heavy_Attack_Stun_Bonus_raw;
                set {
                    if (Impact_Mantle_Motion_Value_Needed_for_Heavy_Attack_Stun_Bonus_raw == value) return;
                    Impact_Mantle_Motion_Value_Needed_for_Heavy_Attack_Stun_Bonus_raw = value;
                    ChangedItems.Add(nameof(Impact_Mantle_Motion_Value_Needed_for_Heavy_Attack_Stun_Bonus));
                    OnPropertyChanged(nameof(Impact_Mantle_Motion_Value_Needed_for_Heavy_Attack_Stun_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long Impact_Mantle_Motion_Value_Needed_for_Heavy_Attack_Stun_Bonus_offset { get; private set; }

            protected float Impact_Mantle_Motion_Value_Needed_for_Extreme_Attack_Stun_Bonus_raw;
            public const string Impact_Mantle_Motion_Value_Needed_for_Extreme_Attack_Stun_Bonus_displayName = "Impact Mantle: Motion Value Needed for Extreme Attack Stun Bonus";
            public const int Impact_Mantle_Motion_Value_Needed_for_Extreme_Attack_Stun_Bonus_sortIndex = 1300;
            [SortOrder(Impact_Mantle_Motion_Value_Needed_for_Extreme_Attack_Stun_Bonus_sortIndex)]
            [DisplayName(Impact_Mantle_Motion_Value_Needed_for_Extreme_Attack_Stun_Bonus_displayName)]
            public virtual float Impact_Mantle_Motion_Value_Needed_for_Extreme_Attack_Stun_Bonus {
                get => Impact_Mantle_Motion_Value_Needed_for_Extreme_Attack_Stun_Bonus_raw;
                set {
                    if (Impact_Mantle_Motion_Value_Needed_for_Extreme_Attack_Stun_Bonus_raw == value) return;
                    Impact_Mantle_Motion_Value_Needed_for_Extreme_Attack_Stun_Bonus_raw = value;
                    ChangedItems.Add(nameof(Impact_Mantle_Motion_Value_Needed_for_Extreme_Attack_Stun_Bonus));
                    OnPropertyChanged(nameof(Impact_Mantle_Motion_Value_Needed_for_Extreme_Attack_Stun_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long Impact_Mantle_Motion_Value_Needed_for_Extreme_Attack_Stun_Bonus_offset { get; private set; }

            protected float Impact_Mantle_Weak_Attack_Stun_Bonus_raw;
            public const string Impact_Mantle_Weak_Attack_Stun_Bonus_displayName = "Impact Mantle: Weak Attack Stun Bonus";
            public const int Impact_Mantle_Weak_Attack_Stun_Bonus_sortIndex = 1350;
            [SortOrder(Impact_Mantle_Weak_Attack_Stun_Bonus_sortIndex)]
            [DisplayName(Impact_Mantle_Weak_Attack_Stun_Bonus_displayName)]
            public virtual float Impact_Mantle_Weak_Attack_Stun_Bonus {
                get => Impact_Mantle_Weak_Attack_Stun_Bonus_raw;
                set {
                    if (Impact_Mantle_Weak_Attack_Stun_Bonus_raw == value) return;
                    Impact_Mantle_Weak_Attack_Stun_Bonus_raw = value;
                    ChangedItems.Add(nameof(Impact_Mantle_Weak_Attack_Stun_Bonus));
                    OnPropertyChanged(nameof(Impact_Mantle_Weak_Attack_Stun_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long Impact_Mantle_Weak_Attack_Stun_Bonus_offset { get; private set; }

            protected float Impact_Mantle_Light_Attack_Stun_Bonus_raw;
            public const string Impact_Mantle_Light_Attack_Stun_Bonus_displayName = "Impact Mantle: Light Attack Stun Bonus";
            public const int Impact_Mantle_Light_Attack_Stun_Bonus_sortIndex = 1400;
            [SortOrder(Impact_Mantle_Light_Attack_Stun_Bonus_sortIndex)]
            [DisplayName(Impact_Mantle_Light_Attack_Stun_Bonus_displayName)]
            public virtual float Impact_Mantle_Light_Attack_Stun_Bonus {
                get => Impact_Mantle_Light_Attack_Stun_Bonus_raw;
                set {
                    if (Impact_Mantle_Light_Attack_Stun_Bonus_raw == value) return;
                    Impact_Mantle_Light_Attack_Stun_Bonus_raw = value;
                    ChangedItems.Add(nameof(Impact_Mantle_Light_Attack_Stun_Bonus));
                    OnPropertyChanged(nameof(Impact_Mantle_Light_Attack_Stun_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long Impact_Mantle_Light_Attack_Stun_Bonus_offset { get; private set; }

            protected float Impact_Mantle_Heavy_Attack_Stun_Bonus_raw;
            public const string Impact_Mantle_Heavy_Attack_Stun_Bonus_displayName = "Impact Mantle: Heavy Attack Stun Bonus";
            public const int Impact_Mantle_Heavy_Attack_Stun_Bonus_sortIndex = 1450;
            [SortOrder(Impact_Mantle_Heavy_Attack_Stun_Bonus_sortIndex)]
            [DisplayName(Impact_Mantle_Heavy_Attack_Stun_Bonus_displayName)]
            public virtual float Impact_Mantle_Heavy_Attack_Stun_Bonus {
                get => Impact_Mantle_Heavy_Attack_Stun_Bonus_raw;
                set {
                    if (Impact_Mantle_Heavy_Attack_Stun_Bonus_raw == value) return;
                    Impact_Mantle_Heavy_Attack_Stun_Bonus_raw = value;
                    ChangedItems.Add(nameof(Impact_Mantle_Heavy_Attack_Stun_Bonus));
                    OnPropertyChanged(nameof(Impact_Mantle_Heavy_Attack_Stun_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long Impact_Mantle_Heavy_Attack_Stun_Bonus_offset { get; private set; }

            protected float Impact_Mantle_Extreme_Attack_Stun_Bonus_raw;
            public const string Impact_Mantle_Extreme_Attack_Stun_Bonus_displayName = "Impact Mantle: Extreme Attack Stun Bonus";
            public const int Impact_Mantle_Extreme_Attack_Stun_Bonus_sortIndex = 1500;
            [SortOrder(Impact_Mantle_Extreme_Attack_Stun_Bonus_sortIndex)]
            [DisplayName(Impact_Mantle_Extreme_Attack_Stun_Bonus_displayName)]
            public virtual float Impact_Mantle_Extreme_Attack_Stun_Bonus {
                get => Impact_Mantle_Extreme_Attack_Stun_Bonus_raw;
                set {
                    if (Impact_Mantle_Extreme_Attack_Stun_Bonus_raw == value) return;
                    Impact_Mantle_Extreme_Attack_Stun_Bonus_raw = value;
                    ChangedItems.Add(nameof(Impact_Mantle_Extreme_Attack_Stun_Bonus));
                    OnPropertyChanged(nameof(Impact_Mantle_Extreme_Attack_Stun_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long Impact_Mantle_Extreme_Attack_Stun_Bonus_offset { get; private set; }

            protected float Impact_Mantle_Existing_Stun_Multiplier_raw;
            public const string Impact_Mantle_Existing_Stun_Multiplier_displayName = "Impact Mantle: Existing Stun Multiplier";
            public const int Impact_Mantle_Existing_Stun_Multiplier_sortIndex = 1550;
            [SortOrder(Impact_Mantle_Existing_Stun_Multiplier_sortIndex)]
            [DisplayName(Impact_Mantle_Existing_Stun_Multiplier_displayName)]
            public virtual float Impact_Mantle_Existing_Stun_Multiplier {
                get => Impact_Mantle_Existing_Stun_Multiplier_raw;
                set {
                    if (Impact_Mantle_Existing_Stun_Multiplier_raw == value) return;
                    Impact_Mantle_Existing_Stun_Multiplier_raw = value;
                    ChangedItems.Add(nameof(Impact_Mantle_Existing_Stun_Multiplier));
                    OnPropertyChanged(nameof(Impact_Mantle_Existing_Stun_Multiplier));
                }
            }

            [DisplayName("Offset")]
            public long Impact_Mantle_Existing_Stun_Multiplier_offset { get; private set; }

            protected float Impact_Mantle_Motion_Value_Needed_for_Light_Attack_Exhaust_Bonus_raw;
            public const string Impact_Mantle_Motion_Value_Needed_for_Light_Attack_Exhaust_Bonus_displayName = "Impact Mantle: Motion Value Needed for Light Attack Exhaust Bonus";
            public const int Impact_Mantle_Motion_Value_Needed_for_Light_Attack_Exhaust_Bonus_sortIndex = 1600;
            [SortOrder(Impact_Mantle_Motion_Value_Needed_for_Light_Attack_Exhaust_Bonus_sortIndex)]
            [DisplayName(Impact_Mantle_Motion_Value_Needed_for_Light_Attack_Exhaust_Bonus_displayName)]
            public virtual float Impact_Mantle_Motion_Value_Needed_for_Light_Attack_Exhaust_Bonus {
                get => Impact_Mantle_Motion_Value_Needed_for_Light_Attack_Exhaust_Bonus_raw;
                set {
                    if (Impact_Mantle_Motion_Value_Needed_for_Light_Attack_Exhaust_Bonus_raw == value) return;
                    Impact_Mantle_Motion_Value_Needed_for_Light_Attack_Exhaust_Bonus_raw = value;
                    ChangedItems.Add(nameof(Impact_Mantle_Motion_Value_Needed_for_Light_Attack_Exhaust_Bonus));
                    OnPropertyChanged(nameof(Impact_Mantle_Motion_Value_Needed_for_Light_Attack_Exhaust_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long Impact_Mantle_Motion_Value_Needed_for_Light_Attack_Exhaust_Bonus_offset { get; private set; }

            protected float Impact_Mantle_Motion_Value_Needed_for_Heavy_Attack_Exhaust_Bonus_raw;
            public const string Impact_Mantle_Motion_Value_Needed_for_Heavy_Attack_Exhaust_Bonus_displayName = "Impact Mantle: Motion Value Needed for Heavy Attack Exhaust Bonus";
            public const int Impact_Mantle_Motion_Value_Needed_for_Heavy_Attack_Exhaust_Bonus_sortIndex = 1650;
            [SortOrder(Impact_Mantle_Motion_Value_Needed_for_Heavy_Attack_Exhaust_Bonus_sortIndex)]
            [DisplayName(Impact_Mantle_Motion_Value_Needed_for_Heavy_Attack_Exhaust_Bonus_displayName)]
            public virtual float Impact_Mantle_Motion_Value_Needed_for_Heavy_Attack_Exhaust_Bonus {
                get => Impact_Mantle_Motion_Value_Needed_for_Heavy_Attack_Exhaust_Bonus_raw;
                set {
                    if (Impact_Mantle_Motion_Value_Needed_for_Heavy_Attack_Exhaust_Bonus_raw == value) return;
                    Impact_Mantle_Motion_Value_Needed_for_Heavy_Attack_Exhaust_Bonus_raw = value;
                    ChangedItems.Add(nameof(Impact_Mantle_Motion_Value_Needed_for_Heavy_Attack_Exhaust_Bonus));
                    OnPropertyChanged(nameof(Impact_Mantle_Motion_Value_Needed_for_Heavy_Attack_Exhaust_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long Impact_Mantle_Motion_Value_Needed_for_Heavy_Attack_Exhaust_Bonus_offset { get; private set; }

            protected float Impact_Mantle_Motion_Value_Needed_for_Extreme_Attack_Exhaust_Bonus_raw;
            public const string Impact_Mantle_Motion_Value_Needed_for_Extreme_Attack_Exhaust_Bonus_displayName = "Impact Mantle: Motion Value Needed for Extreme Attack Exhaust Bonus";
            public const int Impact_Mantle_Motion_Value_Needed_for_Extreme_Attack_Exhaust_Bonus_sortIndex = 1700;
            [SortOrder(Impact_Mantle_Motion_Value_Needed_for_Extreme_Attack_Exhaust_Bonus_sortIndex)]
            [DisplayName(Impact_Mantle_Motion_Value_Needed_for_Extreme_Attack_Exhaust_Bonus_displayName)]
            public virtual float Impact_Mantle_Motion_Value_Needed_for_Extreme_Attack_Exhaust_Bonus {
                get => Impact_Mantle_Motion_Value_Needed_for_Extreme_Attack_Exhaust_Bonus_raw;
                set {
                    if (Impact_Mantle_Motion_Value_Needed_for_Extreme_Attack_Exhaust_Bonus_raw == value) return;
                    Impact_Mantle_Motion_Value_Needed_for_Extreme_Attack_Exhaust_Bonus_raw = value;
                    ChangedItems.Add(nameof(Impact_Mantle_Motion_Value_Needed_for_Extreme_Attack_Exhaust_Bonus));
                    OnPropertyChanged(nameof(Impact_Mantle_Motion_Value_Needed_for_Extreme_Attack_Exhaust_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long Impact_Mantle_Motion_Value_Needed_for_Extreme_Attack_Exhaust_Bonus_offset { get; private set; }

            protected float Impact_Mantle_Weak_Attack_Exhaust_Bonus_raw;
            public const string Impact_Mantle_Weak_Attack_Exhaust_Bonus_displayName = "Impact Mantle: Weak Attack Exhaust Bonus";
            public const int Impact_Mantle_Weak_Attack_Exhaust_Bonus_sortIndex = 1750;
            [SortOrder(Impact_Mantle_Weak_Attack_Exhaust_Bonus_sortIndex)]
            [DisplayName(Impact_Mantle_Weak_Attack_Exhaust_Bonus_displayName)]
            public virtual float Impact_Mantle_Weak_Attack_Exhaust_Bonus {
                get => Impact_Mantle_Weak_Attack_Exhaust_Bonus_raw;
                set {
                    if (Impact_Mantle_Weak_Attack_Exhaust_Bonus_raw == value) return;
                    Impact_Mantle_Weak_Attack_Exhaust_Bonus_raw = value;
                    ChangedItems.Add(nameof(Impact_Mantle_Weak_Attack_Exhaust_Bonus));
                    OnPropertyChanged(nameof(Impact_Mantle_Weak_Attack_Exhaust_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long Impact_Mantle_Weak_Attack_Exhaust_Bonus_offset { get; private set; }

            protected float Impact_Mantle_Light_Attack_Exhaust_Bonus_raw;
            public const string Impact_Mantle_Light_Attack_Exhaust_Bonus_displayName = "Impact Mantle: Light Attack Exhaust Bonus";
            public const int Impact_Mantle_Light_Attack_Exhaust_Bonus_sortIndex = 1800;
            [SortOrder(Impact_Mantle_Light_Attack_Exhaust_Bonus_sortIndex)]
            [DisplayName(Impact_Mantle_Light_Attack_Exhaust_Bonus_displayName)]
            public virtual float Impact_Mantle_Light_Attack_Exhaust_Bonus {
                get => Impact_Mantle_Light_Attack_Exhaust_Bonus_raw;
                set {
                    if (Impact_Mantle_Light_Attack_Exhaust_Bonus_raw == value) return;
                    Impact_Mantle_Light_Attack_Exhaust_Bonus_raw = value;
                    ChangedItems.Add(nameof(Impact_Mantle_Light_Attack_Exhaust_Bonus));
                    OnPropertyChanged(nameof(Impact_Mantle_Light_Attack_Exhaust_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long Impact_Mantle_Light_Attack_Exhaust_Bonus_offset { get; private set; }

            protected float Impact_Mantle_Heavy_Attack_Exhaust_Bonus_raw;
            public const string Impact_Mantle_Heavy_Attack_Exhaust_Bonus_displayName = "Impact Mantle: Heavy Attack Exhaust Bonus";
            public const int Impact_Mantle_Heavy_Attack_Exhaust_Bonus_sortIndex = 1850;
            [SortOrder(Impact_Mantle_Heavy_Attack_Exhaust_Bonus_sortIndex)]
            [DisplayName(Impact_Mantle_Heavy_Attack_Exhaust_Bonus_displayName)]
            public virtual float Impact_Mantle_Heavy_Attack_Exhaust_Bonus {
                get => Impact_Mantle_Heavy_Attack_Exhaust_Bonus_raw;
                set {
                    if (Impact_Mantle_Heavy_Attack_Exhaust_Bonus_raw == value) return;
                    Impact_Mantle_Heavy_Attack_Exhaust_Bonus_raw = value;
                    ChangedItems.Add(nameof(Impact_Mantle_Heavy_Attack_Exhaust_Bonus));
                    OnPropertyChanged(nameof(Impact_Mantle_Heavy_Attack_Exhaust_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long Impact_Mantle_Heavy_Attack_Exhaust_Bonus_offset { get; private set; }

            protected float Impact_Mantle_Extreme_Attack_Exhaust_Bonus_raw;
            public const string Impact_Mantle_Extreme_Attack_Exhaust_Bonus_displayName = "Impact Mantle: Extreme Attack Exhaust Bonus";
            public const int Impact_Mantle_Extreme_Attack_Exhaust_Bonus_sortIndex = 1900;
            [SortOrder(Impact_Mantle_Extreme_Attack_Exhaust_Bonus_sortIndex)]
            [DisplayName(Impact_Mantle_Extreme_Attack_Exhaust_Bonus_displayName)]
            public virtual float Impact_Mantle_Extreme_Attack_Exhaust_Bonus {
                get => Impact_Mantle_Extreme_Attack_Exhaust_Bonus_raw;
                set {
                    if (Impact_Mantle_Extreme_Attack_Exhaust_Bonus_raw == value) return;
                    Impact_Mantle_Extreme_Attack_Exhaust_Bonus_raw = value;
                    ChangedItems.Add(nameof(Impact_Mantle_Extreme_Attack_Exhaust_Bonus));
                    OnPropertyChanged(nameof(Impact_Mantle_Extreme_Attack_Exhaust_Bonus));
                }
            }

            [DisplayName("Offset")]
            public long Impact_Mantle_Extreme_Attack_Exhaust_Bonus_offset { get; private set; }

            protected float Impact_Mantle_Existing_Exhaust_Multiplier_raw;
            public const string Impact_Mantle_Existing_Exhaust_Multiplier_displayName = "Impact Mantle: Existing Exhaust Multiplier";
            public const int Impact_Mantle_Existing_Exhaust_Multiplier_sortIndex = 1950;
            [SortOrder(Impact_Mantle_Existing_Exhaust_Multiplier_sortIndex)]
            [DisplayName(Impact_Mantle_Existing_Exhaust_Multiplier_displayName)]
            public virtual float Impact_Mantle_Existing_Exhaust_Multiplier {
                get => Impact_Mantle_Existing_Exhaust_Multiplier_raw;
                set {
                    if (Impact_Mantle_Existing_Exhaust_Multiplier_raw == value) return;
                    Impact_Mantle_Existing_Exhaust_Multiplier_raw = value;
                    ChangedItems.Add(nameof(Impact_Mantle_Existing_Exhaust_Multiplier));
                    OnPropertyChanged(nameof(Impact_Mantle_Existing_Exhaust_Multiplier));
                }
            }

            [DisplayName("Offset")]
            public long Impact_Mantle_Existing_Exhaust_Multiplier_offset { get; private set; }

            protected float Apothecary_Mantle_Cooldown_raw;
            public const string Apothecary_Mantle_Cooldown_displayName = "Apothecary Mantle: Cooldown";
            public const int Apothecary_Mantle_Cooldown_sortIndex = 2000;
            [SortOrder(Apothecary_Mantle_Cooldown_sortIndex)]
            [DisplayName(Apothecary_Mantle_Cooldown_displayName)]
            public virtual float Apothecary_Mantle_Cooldown {
                get => Apothecary_Mantle_Cooldown_raw;
                set {
                    if (Apothecary_Mantle_Cooldown_raw == value) return;
                    Apothecary_Mantle_Cooldown_raw = value;
                    ChangedItems.Add(nameof(Apothecary_Mantle_Cooldown));
                    OnPropertyChanged(nameof(Apothecary_Mantle_Cooldown));
                }
            }

            [DisplayName("Offset")]
            public long Apothecary_Mantle_Cooldown_offset { get; private set; }

            protected float Apothecary_Mantle_Duration_raw;
            public const string Apothecary_Mantle_Duration_displayName = "Apothecary Mantle: Duration";
            public const int Apothecary_Mantle_Duration_sortIndex = 2050;
            [SortOrder(Apothecary_Mantle_Duration_sortIndex)]
            [DisplayName(Apothecary_Mantle_Duration_displayName)]
            public virtual float Apothecary_Mantle_Duration {
                get => Apothecary_Mantle_Duration_raw;
                set {
                    if (Apothecary_Mantle_Duration_raw == value) return;
                    Apothecary_Mantle_Duration_raw = value;
                    ChangedItems.Add(nameof(Apothecary_Mantle_Duration));
                    OnPropertyChanged(nameof(Apothecary_Mantle_Duration));
                }
            }

            [DisplayName("Offset")]
            public long Apothecary_Mantle_Duration_offset { get; private set; }

            protected float Apothecary_Mantle_Status_Multiplier_Poison_raw;
            public const string Apothecary_Mantle_Status_Multiplier_Poison_displayName = "Apothecary Mantle: Status Multiplier: Poison";
            public const int Apothecary_Mantle_Status_Multiplier_Poison_sortIndex = 2100;
            [SortOrder(Apothecary_Mantle_Status_Multiplier_Poison_sortIndex)]
            [DisplayName(Apothecary_Mantle_Status_Multiplier_Poison_displayName)]
            public virtual float Apothecary_Mantle_Status_Multiplier_Poison {
                get => Apothecary_Mantle_Status_Multiplier_Poison_raw;
                set {
                    if (Apothecary_Mantle_Status_Multiplier_Poison_raw == value) return;
                    Apothecary_Mantle_Status_Multiplier_Poison_raw = value;
                    ChangedItems.Add(nameof(Apothecary_Mantle_Status_Multiplier_Poison));
                    OnPropertyChanged(nameof(Apothecary_Mantle_Status_Multiplier_Poison));
                }
            }

            [DisplayName("Offset")]
            public long Apothecary_Mantle_Status_Multiplier_Poison_offset { get; private set; }

            protected float Apothecary_Mantle_Status_Multiplier_Para_raw;
            public const string Apothecary_Mantle_Status_Multiplier_Para_displayName = "Apothecary Mantle: Status Multiplier: Para";
            public const int Apothecary_Mantle_Status_Multiplier_Para_sortIndex = 2150;
            [SortOrder(Apothecary_Mantle_Status_Multiplier_Para_sortIndex)]
            [DisplayName(Apothecary_Mantle_Status_Multiplier_Para_displayName)]
            public virtual float Apothecary_Mantle_Status_Multiplier_Para {
                get => Apothecary_Mantle_Status_Multiplier_Para_raw;
                set {
                    if (Apothecary_Mantle_Status_Multiplier_Para_raw == value) return;
                    Apothecary_Mantle_Status_Multiplier_Para_raw = value;
                    ChangedItems.Add(nameof(Apothecary_Mantle_Status_Multiplier_Para));
                    OnPropertyChanged(nameof(Apothecary_Mantle_Status_Multiplier_Para));
                }
            }

            [DisplayName("Offset")]
            public long Apothecary_Mantle_Status_Multiplier_Para_offset { get; private set; }

            protected float Apothecary_Mantle_Status_Multiplier_Sleep_raw;
            public const string Apothecary_Mantle_Status_Multiplier_Sleep_displayName = "Apothecary Mantle: Status Multiplier: Sleep";
            public const int Apothecary_Mantle_Status_Multiplier_Sleep_sortIndex = 2200;
            [SortOrder(Apothecary_Mantle_Status_Multiplier_Sleep_sortIndex)]
            [DisplayName(Apothecary_Mantle_Status_Multiplier_Sleep_displayName)]
            public virtual float Apothecary_Mantle_Status_Multiplier_Sleep {
                get => Apothecary_Mantle_Status_Multiplier_Sleep_raw;
                set {
                    if (Apothecary_Mantle_Status_Multiplier_Sleep_raw == value) return;
                    Apothecary_Mantle_Status_Multiplier_Sleep_raw = value;
                    ChangedItems.Add(nameof(Apothecary_Mantle_Status_Multiplier_Sleep));
                    OnPropertyChanged(nameof(Apothecary_Mantle_Status_Multiplier_Sleep));
                }
            }

            [DisplayName("Offset")]
            public long Apothecary_Mantle_Status_Multiplier_Sleep_offset { get; private set; }

            protected float Apothecary_Mantle_Status_Multiplier_Blast_raw;
            public const string Apothecary_Mantle_Status_Multiplier_Blast_displayName = "Apothecary Mantle: Status Multiplier: Blast";
            public const int Apothecary_Mantle_Status_Multiplier_Blast_sortIndex = 2250;
            [SortOrder(Apothecary_Mantle_Status_Multiplier_Blast_sortIndex)]
            [DisplayName(Apothecary_Mantle_Status_Multiplier_Blast_displayName)]
            public virtual float Apothecary_Mantle_Status_Multiplier_Blast {
                get => Apothecary_Mantle_Status_Multiplier_Blast_raw;
                set {
                    if (Apothecary_Mantle_Status_Multiplier_Blast_raw == value) return;
                    Apothecary_Mantle_Status_Multiplier_Blast_raw = value;
                    ChangedItems.Add(nameof(Apothecary_Mantle_Status_Multiplier_Blast));
                    OnPropertyChanged(nameof(Apothecary_Mantle_Status_Multiplier_Blast));
                }
            }

            [DisplayName("Offset")]
            public long Apothecary_Mantle_Status_Multiplier_Blast_offset { get; private set; }

            protected float Immunity_Mantle_Cooldown_raw;
            public const string Immunity_Mantle_Cooldown_displayName = "Immunity Mantle: Cooldown";
            public const int Immunity_Mantle_Cooldown_sortIndex = 2300;
            [SortOrder(Immunity_Mantle_Cooldown_sortIndex)]
            [DisplayName(Immunity_Mantle_Cooldown_displayName)]
            public virtual float Immunity_Mantle_Cooldown {
                get => Immunity_Mantle_Cooldown_raw;
                set {
                    if (Immunity_Mantle_Cooldown_raw == value) return;
                    Immunity_Mantle_Cooldown_raw = value;
                    ChangedItems.Add(nameof(Immunity_Mantle_Cooldown));
                    OnPropertyChanged(nameof(Immunity_Mantle_Cooldown));
                }
            }

            [DisplayName("Offset")]
            public long Immunity_Mantle_Cooldown_offset { get; private set; }

            protected float Immunity_Mantle_Duration_raw;
            public const string Immunity_Mantle_Duration_displayName = "Immunity Mantle: Duration";
            public const int Immunity_Mantle_Duration_sortIndex = 2350;
            [SortOrder(Immunity_Mantle_Duration_sortIndex)]
            [DisplayName(Immunity_Mantle_Duration_displayName)]
            public virtual float Immunity_Mantle_Duration {
                get => Immunity_Mantle_Duration_raw;
                set {
                    if (Immunity_Mantle_Duration_raw == value) return;
                    Immunity_Mantle_Duration_raw = value;
                    ChangedItems.Add(nameof(Immunity_Mantle_Duration));
                    OnPropertyChanged(nameof(Immunity_Mantle_Duration));
                }
            }

            [DisplayName("Offset")]
            public long Immunity_Mantle_Duration_offset { get; private set; }

            protected float Affinity_Booster_Cooldown_raw;
            public const string Affinity_Booster_Cooldown_displayName = "Affinity Booster: Cooldown";
            public const int Affinity_Booster_Cooldown_sortIndex = 2400;
            [SortOrder(Affinity_Booster_Cooldown_sortIndex)]
            [DisplayName(Affinity_Booster_Cooldown_displayName)]
            public virtual float Affinity_Booster_Cooldown {
                get => Affinity_Booster_Cooldown_raw;
                set {
                    if (Affinity_Booster_Cooldown_raw == value) return;
                    Affinity_Booster_Cooldown_raw = value;
                    ChangedItems.Add(nameof(Affinity_Booster_Cooldown));
                    OnPropertyChanged(nameof(Affinity_Booster_Cooldown));
                }
            }

            [DisplayName("Offset")]
            public long Affinity_Booster_Cooldown_offset { get; private set; }

            protected float Affinity_Booster_Duration_raw;
            public const string Affinity_Booster_Duration_displayName = "Affinity Booster: Duration";
            public const int Affinity_Booster_Duration_sortIndex = 2450;
            [SortOrder(Affinity_Booster_Duration_sortIndex)]
            [DisplayName(Affinity_Booster_Duration_displayName)]
            public virtual float Affinity_Booster_Duration {
                get => Affinity_Booster_Duration_raw;
                set {
                    if (Affinity_Booster_Duration_raw == value) return;
                    Affinity_Booster_Duration_raw = value;
                    ChangedItems.Add(nameof(Affinity_Booster_Duration));
                    OnPropertyChanged(nameof(Affinity_Booster_Duration));
                }
            }

            [DisplayName("Offset")]
            public long Affinity_Booster_Duration_offset { get; private set; }

            protected float Affinity_Booster_Buff_Duration_raw;
            public const string Affinity_Booster_Buff_Duration_displayName = "Affinity Booster: Buff Duration";
            public const int Affinity_Booster_Buff_Duration_sortIndex = 2500;
            [SortOrder(Affinity_Booster_Buff_Duration_sortIndex)]
            [DisplayName(Affinity_Booster_Buff_Duration_displayName)]
            public virtual float Affinity_Booster_Buff_Duration {
                get => Affinity_Booster_Buff_Duration_raw;
                set {
                    if (Affinity_Booster_Buff_Duration_raw == value) return;
                    Affinity_Booster_Buff_Duration_raw = value;
                    ChangedItems.Add(nameof(Affinity_Booster_Buff_Duration));
                    OnPropertyChanged(nameof(Affinity_Booster_Buff_Duration));
                }
            }

            [DisplayName("Offset")]
            public long Affinity_Booster_Buff_Duration_offset { get; private set; }

            protected int Affinity_Booster_Buff_Affinity_raw;
            public const string Affinity_Booster_Buff_Affinity_displayName = "Affinity Booster: Buff Affinity";
            public const int Affinity_Booster_Buff_Affinity_sortIndex = 2550;
            [SortOrder(Affinity_Booster_Buff_Affinity_sortIndex)]
            [DisplayName(Affinity_Booster_Buff_Affinity_displayName)]
            public virtual int Affinity_Booster_Buff_Affinity {
                get => Affinity_Booster_Buff_Affinity_raw;
                set {
                    if (Affinity_Booster_Buff_Affinity_raw == value) return;
                    Affinity_Booster_Buff_Affinity_raw = value;
                    ChangedItems.Add(nameof(Affinity_Booster_Buff_Affinity));
                    OnPropertyChanged(nameof(Affinity_Booster_Buff_Affinity));
                }
            }

            [DisplayName("Offset")]
            public long Affinity_Booster_Buff_Affinity_offset { get; private set; }

            protected float Bandit_Mantle_Cooldown_raw;
            public const string Bandit_Mantle_Cooldown_displayName = "Bandit Mantle: Cooldown";
            public const int Bandit_Mantle_Cooldown_sortIndex = 2600;
            [SortOrder(Bandit_Mantle_Cooldown_sortIndex)]
            [DisplayName(Bandit_Mantle_Cooldown_displayName)]
            public virtual float Bandit_Mantle_Cooldown {
                get => Bandit_Mantle_Cooldown_raw;
                set {
                    if (Bandit_Mantle_Cooldown_raw == value) return;
                    Bandit_Mantle_Cooldown_raw = value;
                    ChangedItems.Add(nameof(Bandit_Mantle_Cooldown));
                    OnPropertyChanged(nameof(Bandit_Mantle_Cooldown));
                }
            }

            [DisplayName("Offset")]
            public long Bandit_Mantle_Cooldown_offset { get; private set; }

            protected float Bandit_Mantle_Duration_raw;
            public const string Bandit_Mantle_Duration_displayName = "Bandit Mantle: Duration";
            public const int Bandit_Mantle_Duration_sortIndex = 2650;
            [SortOrder(Bandit_Mantle_Duration_sortIndex)]
            [DisplayName(Bandit_Mantle_Duration_displayName)]
            public virtual float Bandit_Mantle_Duration {
                get => Bandit_Mantle_Duration_raw;
                set {
                    if (Bandit_Mantle_Duration_raw == value) return;
                    Bandit_Mantle_Duration_raw = value;
                    ChangedItems.Add(nameof(Bandit_Mantle_Duration));
                    OnPropertyChanged(nameof(Bandit_Mantle_Duration));
                }
            }

            [DisplayName("Offset")]
            public long Bandit_Mantle_Duration_offset { get; private set; }

            protected float Bandit_Mantle_Hits_to_Drop_Shiny_raw;
            public const string Bandit_Mantle_Hits_to_Drop_Shiny_displayName = "Bandit Mantle: Hits to Drop Shiny";
            public const int Bandit_Mantle_Hits_to_Drop_Shiny_sortIndex = 2700;
            [SortOrder(Bandit_Mantle_Hits_to_Drop_Shiny_sortIndex)]
            [DisplayName(Bandit_Mantle_Hits_to_Drop_Shiny_displayName)]
            public virtual float Bandit_Mantle_Hits_to_Drop_Shiny {
                get => Bandit_Mantle_Hits_to_Drop_Shiny_raw;
                set {
                    if (Bandit_Mantle_Hits_to_Drop_Shiny_raw == value) return;
                    Bandit_Mantle_Hits_to_Drop_Shiny_raw = value;
                    ChangedItems.Add(nameof(Bandit_Mantle_Hits_to_Drop_Shiny));
                    OnPropertyChanged(nameof(Bandit_Mantle_Hits_to_Drop_Shiny));
                }
            }

            [DisplayName("Offset")]
            public long Bandit_Mantle_Hits_to_Drop_Shiny_offset { get; private set; }

            protected sbyte Bandit_Mantle_Unk1_raw;
            public const string Bandit_Mantle_Unk1_displayName = "Bandit Mantle: Unk1";
            public const int Bandit_Mantle_Unk1_sortIndex = 2750;
            [SortOrder(Bandit_Mantle_Unk1_sortIndex)]
            [DisplayName(Bandit_Mantle_Unk1_displayName)]
            public virtual sbyte Bandit_Mantle_Unk1 {
                get => Bandit_Mantle_Unk1_raw;
                set {
                    if (Bandit_Mantle_Unk1_raw == value) return;
                    Bandit_Mantle_Unk1_raw = value;
                    ChangedItems.Add(nameof(Bandit_Mantle_Unk1));
                    OnPropertyChanged(nameof(Bandit_Mantle_Unk1));
                }
            }

            [DisplayName("Offset")]
            public long Bandit_Mantle_Unk1_offset { get; private set; }

            protected sbyte Bandit_Mantle_Unk2_raw;
            public const string Bandit_Mantle_Unk2_displayName = "Bandit Mantle: Unk2";
            public const int Bandit_Mantle_Unk2_sortIndex = 2800;
            [SortOrder(Bandit_Mantle_Unk2_sortIndex)]
            [DisplayName(Bandit_Mantle_Unk2_displayName)]
            public virtual sbyte Bandit_Mantle_Unk2 {
                get => Bandit_Mantle_Unk2_raw;
                set {
                    if (Bandit_Mantle_Unk2_raw == value) return;
                    Bandit_Mantle_Unk2_raw = value;
                    ChangedItems.Add(nameof(Bandit_Mantle_Unk2));
                    OnPropertyChanged(nameof(Bandit_Mantle_Unk2));
                }
            }

            [DisplayName("Offset")]
            public long Bandit_Mantle_Unk2_offset { get; private set; }

            protected sbyte Bandit_Mantle_Unk3_raw;
            public const string Bandit_Mantle_Unk3_displayName = "Bandit Mantle: Unk3";
            public const int Bandit_Mantle_Unk3_sortIndex = 2850;
            [SortOrder(Bandit_Mantle_Unk3_sortIndex)]
            [DisplayName(Bandit_Mantle_Unk3_displayName)]
            public virtual sbyte Bandit_Mantle_Unk3 {
                get => Bandit_Mantle_Unk3_raw;
                set {
                    if (Bandit_Mantle_Unk3_raw == value) return;
                    Bandit_Mantle_Unk3_raw = value;
                    ChangedItems.Add(nameof(Bandit_Mantle_Unk3));
                    OnPropertyChanged(nameof(Bandit_Mantle_Unk3));
                }
            }

            [DisplayName("Offset")]
            public long Bandit_Mantle_Unk3_offset { get; private set; }

            protected sbyte Bandit_Mantle_Unk4_raw;
            public const string Bandit_Mantle_Unk4_displayName = "Bandit Mantle: Unk4";
            public const int Bandit_Mantle_Unk4_sortIndex = 2900;
            [SortOrder(Bandit_Mantle_Unk4_sortIndex)]
            [DisplayName(Bandit_Mantle_Unk4_displayName)]
            public virtual sbyte Bandit_Mantle_Unk4 {
                get => Bandit_Mantle_Unk4_raw;
                set {
                    if (Bandit_Mantle_Unk4_raw == value) return;
                    Bandit_Mantle_Unk4_raw = value;
                    ChangedItems.Add(nameof(Bandit_Mantle_Unk4));
                    OnPropertyChanged(nameof(Bandit_Mantle_Unk4));
                }
            }

            [DisplayName("Offset")]
            public long Bandit_Mantle_Unk4_offset { get; private set; }

            protected sbyte Bandit_Mantle_Unk5_raw;
            public const string Bandit_Mantle_Unk5_displayName = "Bandit Mantle: Unk5";
            public const int Bandit_Mantle_Unk5_sortIndex = 2950;
            [SortOrder(Bandit_Mantle_Unk5_sortIndex)]
            [DisplayName(Bandit_Mantle_Unk5_displayName)]
            public virtual sbyte Bandit_Mantle_Unk5 {
                get => Bandit_Mantle_Unk5_raw;
                set {
                    if (Bandit_Mantle_Unk5_raw == value) return;
                    Bandit_Mantle_Unk5_raw = value;
                    ChangedItems.Add(nameof(Bandit_Mantle_Unk5));
                    OnPropertyChanged(nameof(Bandit_Mantle_Unk5));
                }
            }

            [DisplayName("Offset")]
            public long Bandit_Mantle_Unk5_offset { get; private set; }

            protected sbyte Bandit_Mantle_Unk6_raw;
            public const string Bandit_Mantle_Unk6_displayName = "Bandit Mantle: Unk6";
            public const int Bandit_Mantle_Unk6_sortIndex = 3000;
            [SortOrder(Bandit_Mantle_Unk6_sortIndex)]
            [DisplayName(Bandit_Mantle_Unk6_displayName)]
            public virtual sbyte Bandit_Mantle_Unk6 {
                get => Bandit_Mantle_Unk6_raw;
                set {
                    if (Bandit_Mantle_Unk6_raw == value) return;
                    Bandit_Mantle_Unk6_raw = value;
                    ChangedItems.Add(nameof(Bandit_Mantle_Unk6));
                    OnPropertyChanged(nameof(Bandit_Mantle_Unk6));
                }
            }

            [DisplayName("Offset")]
            public long Bandit_Mantle_Unk6_offset { get; private set; }

            protected sbyte Bandit_Mantle_Unk7_raw;
            public const string Bandit_Mantle_Unk7_displayName = "Bandit Mantle: Unk7";
            public const int Bandit_Mantle_Unk7_sortIndex = 3050;
            [SortOrder(Bandit_Mantle_Unk7_sortIndex)]
            [DisplayName(Bandit_Mantle_Unk7_displayName)]
            public virtual sbyte Bandit_Mantle_Unk7 {
                get => Bandit_Mantle_Unk7_raw;
                set {
                    if (Bandit_Mantle_Unk7_raw == value) return;
                    Bandit_Mantle_Unk7_raw = value;
                    ChangedItems.Add(nameof(Bandit_Mantle_Unk7));
                    OnPropertyChanged(nameof(Bandit_Mantle_Unk7));
                }
            }

            [DisplayName("Offset")]
            public long Bandit_Mantle_Unk7_offset { get; private set; }

            protected sbyte Bandit_Mantle_Unk8_raw;
            public const string Bandit_Mantle_Unk8_displayName = "Bandit Mantle: Unk8";
            public const int Bandit_Mantle_Unk8_sortIndex = 3100;
            [SortOrder(Bandit_Mantle_Unk8_sortIndex)]
            [DisplayName(Bandit_Mantle_Unk8_displayName)]
            public virtual sbyte Bandit_Mantle_Unk8 {
                get => Bandit_Mantle_Unk8_raw;
                set {
                    if (Bandit_Mantle_Unk8_raw == value) return;
                    Bandit_Mantle_Unk8_raw = value;
                    ChangedItems.Add(nameof(Bandit_Mantle_Unk8));
                    OnPropertyChanged(nameof(Bandit_Mantle_Unk8));
                }
            }

            [DisplayName("Offset")]
            public long Bandit_Mantle_Unk8_offset { get; private set; }

            protected float Assassin_s_Hood_Cooldown_raw;
            public const string Assassin_s_Hood_Cooldown_displayName = "Assassin's Hood: Cooldown";
            public const int Assassin_s_Hood_Cooldown_sortIndex = 3150;
            [SortOrder(Assassin_s_Hood_Cooldown_sortIndex)]
            [DisplayName(Assassin_s_Hood_Cooldown_displayName)]
            public virtual float Assassin_s_Hood_Cooldown {
                get => Assassin_s_Hood_Cooldown_raw;
                set {
                    if (Assassin_s_Hood_Cooldown_raw == value) return;
                    Assassin_s_Hood_Cooldown_raw = value;
                    ChangedItems.Add(nameof(Assassin_s_Hood_Cooldown));
                    OnPropertyChanged(nameof(Assassin_s_Hood_Cooldown));
                }
            }

            [DisplayName("Offset")]
            public long Assassin_s_Hood_Cooldown_offset { get; private set; }

            protected float Assassin_s_Hood_Duration_raw;
            public const string Assassin_s_Hood_Duration_displayName = "Assassin's Hood: Duration";
            public const int Assassin_s_Hood_Duration_sortIndex = 3200;
            [SortOrder(Assassin_s_Hood_Duration_sortIndex)]
            [DisplayName(Assassin_s_Hood_Duration_displayName)]
            public virtual float Assassin_s_Hood_Duration {
                get => Assassin_s_Hood_Duration_raw;
                set {
                    if (Assassin_s_Hood_Duration_raw == value) return;
                    Assassin_s_Hood_Duration_raw = value;
                    ChangedItems.Add(nameof(Assassin_s_Hood_Duration));
                    OnPropertyChanged(nameof(Assassin_s_Hood_Duration));
                }
            }

            [DisplayName("Offset")]
            public long Assassin_s_Hood_Duration_offset { get; private set; }

            protected float Assassin_s_Hood_Sneak_Attack_Multiplier_raw;
            public const string Assassin_s_Hood_Sneak_Attack_Multiplier_displayName = "Assassin's Hood: Sneak Attack Multiplier";
            public const int Assassin_s_Hood_Sneak_Attack_Multiplier_sortIndex = 3250;
            [SortOrder(Assassin_s_Hood_Sneak_Attack_Multiplier_sortIndex)]
            [DisplayName(Assassin_s_Hood_Sneak_Attack_Multiplier_displayName)]
            public virtual float Assassin_s_Hood_Sneak_Attack_Multiplier {
                get => Assassin_s_Hood_Sneak_Attack_Multiplier_raw;
                set {
                    if (Assassin_s_Hood_Sneak_Attack_Multiplier_raw == value) return;
                    Assassin_s_Hood_Sneak_Attack_Multiplier_raw = value;
                    ChangedItems.Add(nameof(Assassin_s_Hood_Sneak_Attack_Multiplier));
                    OnPropertyChanged(nameof(Assassin_s_Hood_Sneak_Attack_Multiplier));
                }
            }

            [DisplayName("Offset")]
            public long Assassin_s_Hood_Sneak_Attack_Multiplier_offset { get; private set; }

            protected float Assassin_s_Hood_Sneak_Attack_Multiplier_Sleeping__raw;
            public const string Assassin_s_Hood_Sneak_Attack_Multiplier_Sleeping__displayName = "Assassin's Hood: Sneak Attack Multiplier (Sleeping)";
            public const int Assassin_s_Hood_Sneak_Attack_Multiplier_Sleeping__sortIndex = 3300;
            [SortOrder(Assassin_s_Hood_Sneak_Attack_Multiplier_Sleeping__sortIndex)]
            [DisplayName(Assassin_s_Hood_Sneak_Attack_Multiplier_Sleeping__displayName)]
            public virtual float Assassin_s_Hood_Sneak_Attack_Multiplier_Sleeping_ {
                get => Assassin_s_Hood_Sneak_Attack_Multiplier_Sleeping__raw;
                set {
                    if (Assassin_s_Hood_Sneak_Attack_Multiplier_Sleeping__raw == value) return;
                    Assassin_s_Hood_Sneak_Attack_Multiplier_Sleeping__raw = value;
                    ChangedItems.Add(nameof(Assassin_s_Hood_Sneak_Attack_Multiplier_Sleeping_));
                    OnPropertyChanged(nameof(Assassin_s_Hood_Sneak_Attack_Multiplier_Sleeping_));
                }
            }

            [DisplayName("Offset")]
            public long Assassin_s_Hood_Sneak_Attack_Multiplier_Sleeping__offset { get; private set; }

            protected float Assassin_s_Hood_Unk1_raw;
            public const string Assassin_s_Hood_Unk1_displayName = "Assassin's Hood: Unk1";
            public const int Assassin_s_Hood_Unk1_sortIndex = 3350;
            [SortOrder(Assassin_s_Hood_Unk1_sortIndex)]
            [DisplayName(Assassin_s_Hood_Unk1_displayName)]
            public virtual float Assassin_s_Hood_Unk1 {
                get => Assassin_s_Hood_Unk1_raw;
                set {
                    if (Assassin_s_Hood_Unk1_raw == value) return;
                    Assassin_s_Hood_Unk1_raw = value;
                    ChangedItems.Add(nameof(Assassin_s_Hood_Unk1));
                    OnPropertyChanged(nameof(Assassin_s_Hood_Unk1));
                }
            }

            [DisplayName("Offset")]
            public long Assassin_s_Hood_Unk1_offset { get; private set; }

            protected float Assassin_s_Hood_Speed_Multiplier_1_raw;
            public const string Assassin_s_Hood_Speed_Multiplier_1_displayName = "Assassin's Hood: Speed Multiplier 1";
            public const int Assassin_s_Hood_Speed_Multiplier_1_sortIndex = 3400;
            [SortOrder(Assassin_s_Hood_Speed_Multiplier_1_sortIndex)]
            [DisplayName(Assassin_s_Hood_Speed_Multiplier_1_displayName)]
            public virtual float Assassin_s_Hood_Speed_Multiplier_1 {
                get => Assassin_s_Hood_Speed_Multiplier_1_raw;
                set {
                    if (Assassin_s_Hood_Speed_Multiplier_1_raw == value) return;
                    Assassin_s_Hood_Speed_Multiplier_1_raw = value;
                    ChangedItems.Add(nameof(Assassin_s_Hood_Speed_Multiplier_1));
                    OnPropertyChanged(nameof(Assassin_s_Hood_Speed_Multiplier_1));
                }
            }

            [DisplayName("Offset")]
            public long Assassin_s_Hood_Speed_Multiplier_1_offset { get; private set; }

            protected float Assassin_s_Hood_Speed_Multiplier_2_raw;
            public const string Assassin_s_Hood_Speed_Multiplier_2_displayName = "Assassin's Hood: Speed Multiplier 2";
            public const int Assassin_s_Hood_Speed_Multiplier_2_sortIndex = 3450;
            [SortOrder(Assassin_s_Hood_Speed_Multiplier_2_sortIndex)]
            [DisplayName(Assassin_s_Hood_Speed_Multiplier_2_displayName)]
            public virtual float Assassin_s_Hood_Speed_Multiplier_2 {
                get => Assassin_s_Hood_Speed_Multiplier_2_raw;
                set {
                    if (Assassin_s_Hood_Speed_Multiplier_2_raw == value) return;
                    Assassin_s_Hood_Speed_Multiplier_2_raw = value;
                    ChangedItems.Add(nameof(Assassin_s_Hood_Speed_Multiplier_2));
                    OnPropertyChanged(nameof(Assassin_s_Hood_Speed_Multiplier_2));
                }
            }

            [DisplayName("Offset")]
            public long Assassin_s_Hood_Speed_Multiplier_2_offset { get; private set; }

            protected float Assassin_s_Hood_Speed_Multiplier_3_raw;
            public const string Assassin_s_Hood_Speed_Multiplier_3_displayName = "Assassin's Hood: Speed Multiplier 3";
            public const int Assassin_s_Hood_Speed_Multiplier_3_sortIndex = 3500;
            [SortOrder(Assassin_s_Hood_Speed_Multiplier_3_sortIndex)]
            [DisplayName(Assassin_s_Hood_Speed_Multiplier_3_displayName)]
            public virtual float Assassin_s_Hood_Speed_Multiplier_3 {
                get => Assassin_s_Hood_Speed_Multiplier_3_raw;
                set {
                    if (Assassin_s_Hood_Speed_Multiplier_3_raw == value) return;
                    Assassin_s_Hood_Speed_Multiplier_3_raw = value;
                    ChangedItems.Add(nameof(Assassin_s_Hood_Speed_Multiplier_3));
                    OnPropertyChanged(nameof(Assassin_s_Hood_Speed_Multiplier_3));
                }
            }

            [DisplayName("Offset")]
            public long Assassin_s_Hood_Speed_Multiplier_3_offset { get; private set; }

            protected float Assassin_s_Hood_Speed_Multiplier_4_raw;
            public const string Assassin_s_Hood_Speed_Multiplier_4_displayName = "Assassin's Hood: Speed Multiplier 4";
            public const int Assassin_s_Hood_Speed_Multiplier_4_sortIndex = 3550;
            [SortOrder(Assassin_s_Hood_Speed_Multiplier_4_sortIndex)]
            [DisplayName(Assassin_s_Hood_Speed_Multiplier_4_displayName)]
            public virtual float Assassin_s_Hood_Speed_Multiplier_4 {
                get => Assassin_s_Hood_Speed_Multiplier_4_raw;
                set {
                    if (Assassin_s_Hood_Speed_Multiplier_4_raw == value) return;
                    Assassin_s_Hood_Speed_Multiplier_4_raw = value;
                    ChangedItems.Add(nameof(Assassin_s_Hood_Speed_Multiplier_4));
                    OnPropertyChanged(nameof(Assassin_s_Hood_Speed_Multiplier_4));
                }
            }

            [DisplayName("Offset")]
            public long Assassin_s_Hood_Speed_Multiplier_4_offset { get; private set; }

            protected float Assassin_s_Hood_Unk2_raw;
            public const string Assassin_s_Hood_Unk2_displayName = "Assassin's Hood: Unk2";
            public const int Assassin_s_Hood_Unk2_sortIndex = 3600;
            [SortOrder(Assassin_s_Hood_Unk2_sortIndex)]
            [DisplayName(Assassin_s_Hood_Unk2_displayName)]
            public virtual float Assassin_s_Hood_Unk2 {
                get => Assassin_s_Hood_Unk2_raw;
                set {
                    if (Assassin_s_Hood_Unk2_raw == value) return;
                    Assassin_s_Hood_Unk2_raw = value;
                    ChangedItems.Add(nameof(Assassin_s_Hood_Unk2));
                    OnPropertyChanged(nameof(Assassin_s_Hood_Unk2));
                }
            }

            [DisplayName("Offset")]
            public long Assassin_s_Hood_Unk2_offset { get; private set; }

            protected float Assassin_s_Hood_Unk3_raw;
            public const string Assassin_s_Hood_Unk3_displayName = "Assassin's Hood: Unk3";
            public const int Assassin_s_Hood_Unk3_sortIndex = 3650;
            [SortOrder(Assassin_s_Hood_Unk3_sortIndex)]
            [DisplayName(Assassin_s_Hood_Unk3_displayName)]
            public virtual float Assassin_s_Hood_Unk3 {
                get => Assassin_s_Hood_Unk3_raw;
                set {
                    if (Assassin_s_Hood_Unk3_raw == value) return;
                    Assassin_s_Hood_Unk3_raw = value;
                    ChangedItems.Add(nameof(Assassin_s_Hood_Unk3));
                    OnPropertyChanged(nameof(Assassin_s_Hood_Unk3));
                }
            }

            [DisplayName("Offset")]
            public long Assassin_s_Hood_Unk3_offset { get; private set; }

            protected float Assassin_s_Hood_Unk4_raw;
            public const string Assassin_s_Hood_Unk4_displayName = "Assassin's Hood: Unk4";
            public const int Assassin_s_Hood_Unk4_sortIndex = 3700;
            [SortOrder(Assassin_s_Hood_Unk4_sortIndex)]
            [DisplayName(Assassin_s_Hood_Unk4_displayName)]
            public virtual float Assassin_s_Hood_Unk4 {
                get => Assassin_s_Hood_Unk4_raw;
                set {
                    if (Assassin_s_Hood_Unk4_raw == value) return;
                    Assassin_s_Hood_Unk4_raw = value;
                    ChangedItems.Add(nameof(Assassin_s_Hood_Unk4));
                    OnPropertyChanged(nameof(Assassin_s_Hood_Unk4));
                }
            }

            [DisplayName("Offset")]
            public long Assassin_s_Hood_Unk4_offset { get; private set; }

            protected float Assassin_s_Hood_Unk5_raw;
            public const string Assassin_s_Hood_Unk5_displayName = "Assassin's Hood: Unk5";
            public const int Assassin_s_Hood_Unk5_sortIndex = 3750;
            [SortOrder(Assassin_s_Hood_Unk5_sortIndex)]
            [DisplayName(Assassin_s_Hood_Unk5_displayName)]
            public virtual float Assassin_s_Hood_Unk5 {
                get => Assassin_s_Hood_Unk5_raw;
                set {
                    if (Assassin_s_Hood_Unk5_raw == value) return;
                    Assassin_s_Hood_Unk5_raw = value;
                    ChangedItems.Add(nameof(Assassin_s_Hood_Unk5));
                    OnPropertyChanged(nameof(Assassin_s_Hood_Unk5));
                }
            }

            [DisplayName("Offset")]
            public long Assassin_s_Hood_Unk5_offset { get; private set; }

            protected float Assassin_s_Hood_Unk6_raw;
            public const string Assassin_s_Hood_Unk6_displayName = "Assassin's Hood: Unk6";
            public const int Assassin_s_Hood_Unk6_sortIndex = 3800;
            [SortOrder(Assassin_s_Hood_Unk6_sortIndex)]
            [DisplayName(Assassin_s_Hood_Unk6_displayName)]
            public virtual float Assassin_s_Hood_Unk6 {
                get => Assassin_s_Hood_Unk6_raw;
                set {
                    if (Assassin_s_Hood_Unk6_raw == value) return;
                    Assassin_s_Hood_Unk6_raw = value;
                    ChangedItems.Add(nameof(Assassin_s_Hood_Unk6));
                    OnPropertyChanged(nameof(Assassin_s_Hood_Unk6));
                }
            }

            [DisplayName("Offset")]
            public long Assassin_s_Hood_Unk6_offset { get; private set; }

            protected float Assassin_s_Hood_Unk7_raw;
            public const string Assassin_s_Hood_Unk7_displayName = "Assassin's Hood: Unk7";
            public const int Assassin_s_Hood_Unk7_sortIndex = 3850;
            [SortOrder(Assassin_s_Hood_Unk7_sortIndex)]
            [DisplayName(Assassin_s_Hood_Unk7_displayName)]
            public virtual float Assassin_s_Hood_Unk7 {
                get => Assassin_s_Hood_Unk7_raw;
                set {
                    if (Assassin_s_Hood_Unk7_raw == value) return;
                    Assassin_s_Hood_Unk7_raw = value;
                    ChangedItems.Add(nameof(Assassin_s_Hood_Unk7));
                    OnPropertyChanged(nameof(Assassin_s_Hood_Unk7));
                }
            }

            [DisplayName("Offset")]
            public long Assassin_s_Hood_Unk7_offset { get; private set; }

            protected float Assassin_s_Hood_Unk8_raw;
            public const string Assassin_s_Hood_Unk8_displayName = "Assassin's Hood: Unk8";
            public const int Assassin_s_Hood_Unk8_sortIndex = 3900;
            [SortOrder(Assassin_s_Hood_Unk8_sortIndex)]
            [DisplayName(Assassin_s_Hood_Unk8_displayName)]
            public virtual float Assassin_s_Hood_Unk8 {
                get => Assassin_s_Hood_Unk8_raw;
                set {
                    if (Assassin_s_Hood_Unk8_raw == value) return;
                    Assassin_s_Hood_Unk8_raw = value;
                    ChangedItems.Add(nameof(Assassin_s_Hood_Unk8));
                    OnPropertyChanged(nameof(Assassin_s_Hood_Unk8));
                }
            }

            [DisplayName("Offset")]
            public long Assassin_s_Hood_Unk8_offset { get; private set; }

            protected float Assassin_s_Hood_Unk9_raw;
            public const string Assassin_s_Hood_Unk9_displayName = "Assassin's Hood: Unk9";
            public const int Assassin_s_Hood_Unk9_sortIndex = 3950;
            [SortOrder(Assassin_s_Hood_Unk9_sortIndex)]
            [DisplayName(Assassin_s_Hood_Unk9_displayName)]
            public virtual float Assassin_s_Hood_Unk9 {
                get => Assassin_s_Hood_Unk9_raw;
                set {
                    if (Assassin_s_Hood_Unk9_raw == value) return;
                    Assassin_s_Hood_Unk9_raw = value;
                    ChangedItems.Add(nameof(Assassin_s_Hood_Unk9));
                    OnPropertyChanged(nameof(Assassin_s_Hood_Unk9));
                }
            }

            [DisplayName("Offset")]
            public long Assassin_s_Hood_Unk9_offset { get; private set; }

            protected float Assassin_s_Hood_Unk10_raw;
            public const string Assassin_s_Hood_Unk10_displayName = "Assassin's Hood: Unk10";
            public const int Assassin_s_Hood_Unk10_sortIndex = 4000;
            [SortOrder(Assassin_s_Hood_Unk10_sortIndex)]
            [DisplayName(Assassin_s_Hood_Unk10_displayName)]
            public virtual float Assassin_s_Hood_Unk10 {
                get => Assassin_s_Hood_Unk10_raw;
                set {
                    if (Assassin_s_Hood_Unk10_raw == value) return;
                    Assassin_s_Hood_Unk10_raw = value;
                    ChangedItems.Add(nameof(Assassin_s_Hood_Unk10));
                    OnPropertyChanged(nameof(Assassin_s_Hood_Unk10));
                }
            }

            [DisplayName("Offset")]
            public long Assassin_s_Hood_Unk10_offset { get; private set; }

            protected float Assassin_s_Hood_Unk11_raw;
            public const string Assassin_s_Hood_Unk11_displayName = "Assassin's Hood: Unk11";
            public const int Assassin_s_Hood_Unk11_sortIndex = 4050;
            [SortOrder(Assassin_s_Hood_Unk11_sortIndex)]
            [DisplayName(Assassin_s_Hood_Unk11_displayName)]
            public virtual float Assassin_s_Hood_Unk11 {
                get => Assassin_s_Hood_Unk11_raw;
                set {
                    if (Assassin_s_Hood_Unk11_raw == value) return;
                    Assassin_s_Hood_Unk11_raw = value;
                    ChangedItems.Add(nameof(Assassin_s_Hood_Unk11));
                    OnPropertyChanged(nameof(Assassin_s_Hood_Unk11));
                }
            }

            [DisplayName("Offset")]
            public long Assassin_s_Hood_Unk11_offset { get; private set; }

            protected float Assassin_s_Hood_Unk12_raw;
            public const string Assassin_s_Hood_Unk12_displayName = "Assassin's Hood: Unk12";
            public const int Assassin_s_Hood_Unk12_sortIndex = 4100;
            [SortOrder(Assassin_s_Hood_Unk12_sortIndex)]
            [DisplayName(Assassin_s_Hood_Unk12_displayName)]
            public virtual float Assassin_s_Hood_Unk12 {
                get => Assassin_s_Hood_Unk12_raw;
                set {
                    if (Assassin_s_Hood_Unk12_raw == value) return;
                    Assassin_s_Hood_Unk12_raw = value;
                    ChangedItems.Add(nameof(Assassin_s_Hood_Unk12));
                    OnPropertyChanged(nameof(Assassin_s_Hood_Unk12));
                }
            }

            [DisplayName("Offset")]
            public long Assassin_s_Hood_Unk12_offset { get; private set; }

            protected float Assassin_s_Hood_Unk13_raw;
            public const string Assassin_s_Hood_Unk13_displayName = "Assassin's Hood: Unk13";
            public const int Assassin_s_Hood_Unk13_sortIndex = 4150;
            [SortOrder(Assassin_s_Hood_Unk13_sortIndex)]
            [DisplayName(Assassin_s_Hood_Unk13_displayName)]
            public virtual float Assassin_s_Hood_Unk13 {
                get => Assassin_s_Hood_Unk13_raw;
                set {
                    if (Assassin_s_Hood_Unk13_raw == value) return;
                    Assassin_s_Hood_Unk13_raw = value;
                    ChangedItems.Add(nameof(Assassin_s_Hood_Unk13));
                    OnPropertyChanged(nameof(Assassin_s_Hood_Unk13));
                }
            }

            [DisplayName("Offset")]
            public long Assassin_s_Hood_Unk13_offset { get; private set; }

            protected float Assassin_s_Hood_Unk14_raw;
            public const string Assassin_s_Hood_Unk14_displayName = "Assassin's Hood: Unk14";
            public const int Assassin_s_Hood_Unk14_sortIndex = 4200;
            [SortOrder(Assassin_s_Hood_Unk14_sortIndex)]
            [DisplayName(Assassin_s_Hood_Unk14_displayName)]
            public virtual float Assassin_s_Hood_Unk14 {
                get => Assassin_s_Hood_Unk14_raw;
                set {
                    if (Assassin_s_Hood_Unk14_raw == value) return;
                    Assassin_s_Hood_Unk14_raw = value;
                    ChangedItems.Add(nameof(Assassin_s_Hood_Unk14));
                    OnPropertyChanged(nameof(Assassin_s_Hood_Unk14));
                }
            }

            [DisplayName("Offset")]
            public long Assassin_s_Hood_Unk14_offset { get; private set; }

            protected float Assassin_s_Hood_Unk15_raw;
            public const string Assassin_s_Hood_Unk15_displayName = "Assassin's Hood: Unk15";
            public const int Assassin_s_Hood_Unk15_sortIndex = 4250;
            [SortOrder(Assassin_s_Hood_Unk15_sortIndex)]
            [DisplayName(Assassin_s_Hood_Unk15_displayName)]
            public virtual float Assassin_s_Hood_Unk15 {
                get => Assassin_s_Hood_Unk15_raw;
                set {
                    if (Assassin_s_Hood_Unk15_raw == value) return;
                    Assassin_s_Hood_Unk15_raw = value;
                    ChangedItems.Add(nameof(Assassin_s_Hood_Unk15));
                    OnPropertyChanged(nameof(Assassin_s_Hood_Unk15));
                }
            }

            [DisplayName("Offset")]
            public long Assassin_s_Hood_Unk15_offset { get; private set; }

            protected float Assassin_s_Hood_Unk16_raw;
            public const string Assassin_s_Hood_Unk16_displayName = "Assassin's Hood: Unk16";
            public const int Assassin_s_Hood_Unk16_sortIndex = 4300;
            [SortOrder(Assassin_s_Hood_Unk16_sortIndex)]
            [DisplayName(Assassin_s_Hood_Unk16_displayName)]
            public virtual float Assassin_s_Hood_Unk16 {
                get => Assassin_s_Hood_Unk16_raw;
                set {
                    if (Assassin_s_Hood_Unk16_raw == value) return;
                    Assassin_s_Hood_Unk16_raw = value;
                    ChangedItems.Add(nameof(Assassin_s_Hood_Unk16));
                    OnPropertyChanged(nameof(Assassin_s_Hood_Unk16));
                }
            }

            [DisplayName("Offset")]
            public long Assassin_s_Hood_Unk16_offset { get; private set; }

            public const int lastSortIndex = 4350;

            public static ObservableMhwStructCollection<Mantle_Params_3_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Mantle_Params_3_>();
                const ulong count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Mantle_Params_3_ LoadData(BinaryReader reader, ulong i) {
                var data = new Mantle_Params_3_();
                data.Index = i;
                data.Dragonproof_Mantle_Dragon_Damage_Multiplier_offset = reader.BaseStream.Position;
                data.Dragonproof_Mantle_Dragon_Damage_Multiplier_raw = reader.ReadSingle();
                data.Cleanser_Booster_Cooldown_offset = reader.BaseStream.Position;
                data.Cleanser_Booster_Cooldown_raw = reader.ReadSingle();
                data.Cleanser_Booster_Duration_offset = reader.BaseStream.Position;
                data.Cleanser_Booster_Duration_raw = reader.ReadSingle();
                data.Cleanser_Booster_Upgraded_Duration_offset = reader.BaseStream.Position;
                data.Cleanser_Booster_Upgraded_Duration_raw = reader.ReadSingle();
                data.Cleanser_Booster_Unk1_offset = reader.BaseStream.Position;
                data.Cleanser_Booster_Unk1_raw = reader.ReadSingle();
                data.Cleanser_Booster_Unk2_offset = reader.BaseStream.Position;
                data.Cleanser_Booster_Unk2_raw = reader.ReadSingle();
                data.Cleanser_Booster_Unk3_offset = reader.BaseStream.Position;
                data.Cleanser_Booster_Unk3_raw = reader.ReadSingle();
                data.Cleanser_Booster_Unk4_offset = reader.BaseStream.Position;
                data.Cleanser_Booster_Unk4_raw = reader.ReadSingle();
                data.Glider_Mantle_Cooldown_offset = reader.BaseStream.Position;
                data.Glider_Mantle_Cooldown_raw = reader.ReadSingle();
                data.Glider_Mantle_Duration_offset = reader.BaseStream.Position;
                data.Glider_Mantle_Duration_raw = reader.ReadSingle();
                data.Glider_Mantle_Mount_Multiplier_offset = reader.BaseStream.Position;
                data.Glider_Mantle_Mount_Multiplier_raw = reader.ReadSingle();
                data.Evasion_Mantle_Cooldown_offset = reader.BaseStream.Position;
                data.Evasion_Mantle_Cooldown_raw = reader.ReadSingle();
                data.Evasion_Mantle_Duration_offset = reader.BaseStream.Position;
                data.Evasion_Mantle_Duration_raw = reader.ReadSingle();
                data.Evasion_Mantle_Attack_Boost_Duration_offset = reader.BaseStream.Position;
                data.Evasion_Mantle_Attack_Boost_Duration_raw = reader.ReadSingle();
                data.Evasion_Mantle_Evasion_Multiplier_offset = reader.BaseStream.Position;
                data.Evasion_Mantle_Evasion_Multiplier_raw = reader.ReadSingle();
                data.Evasion_Mantle_Unk1_offset = reader.BaseStream.Position;
                data.Evasion_Mantle_Unk1_raw = reader.ReadSingle();
                data.Evasion_Mantle_Unk2_offset = reader.BaseStream.Position;
                data.Evasion_Mantle_Unk2_raw = reader.ReadByte();
                data.Evasion_Mantle_Unk3_offset = reader.BaseStream.Position;
                data.Evasion_Mantle_Unk3_raw = reader.ReadUInt16();
                data.Evasion_Mantle_Unk4_offset = reader.BaseStream.Position;
                data.Evasion_Mantle_Unk4_raw = reader.ReadUInt16();
                data.Evasion_Mantle_Unk5_offset = reader.BaseStream.Position;
                data.Evasion_Mantle_Unk5_raw = reader.ReadSingle();
                data.Evasion_Mantle_Unk6_offset = reader.BaseStream.Position;
                data.Evasion_Mantle_Unk6_raw = reader.ReadUInt16();
                data.Impact_Mantle_Cooldown_offset = reader.BaseStream.Position;
                data.Impact_Mantle_Cooldown_raw = reader.ReadSingle();
                data.Impact_Mantle_Duration_offset = reader.BaseStream.Position;
                data.Impact_Mantle_Duration_raw = reader.ReadSingle();
                data.Impact_Mantle_Motion_Value_Needed_for_Light_Attack_Stun_Bonus_offset = reader.BaseStream.Position;
                data.Impact_Mantle_Motion_Value_Needed_for_Light_Attack_Stun_Bonus_raw = reader.ReadSingle();
                data.Impact_Mantle_Motion_Value_Needed_for_Heavy_Attack_Stun_Bonus_offset = reader.BaseStream.Position;
                data.Impact_Mantle_Motion_Value_Needed_for_Heavy_Attack_Stun_Bonus_raw = reader.ReadSingle();
                data.Impact_Mantle_Motion_Value_Needed_for_Extreme_Attack_Stun_Bonus_offset = reader.BaseStream.Position;
                data.Impact_Mantle_Motion_Value_Needed_for_Extreme_Attack_Stun_Bonus_raw = reader.ReadSingle();
                data.Impact_Mantle_Weak_Attack_Stun_Bonus_offset = reader.BaseStream.Position;
                data.Impact_Mantle_Weak_Attack_Stun_Bonus_raw = reader.ReadSingle();
                data.Impact_Mantle_Light_Attack_Stun_Bonus_offset = reader.BaseStream.Position;
                data.Impact_Mantle_Light_Attack_Stun_Bonus_raw = reader.ReadSingle();
                data.Impact_Mantle_Heavy_Attack_Stun_Bonus_offset = reader.BaseStream.Position;
                data.Impact_Mantle_Heavy_Attack_Stun_Bonus_raw = reader.ReadSingle();
                data.Impact_Mantle_Extreme_Attack_Stun_Bonus_offset = reader.BaseStream.Position;
                data.Impact_Mantle_Extreme_Attack_Stun_Bonus_raw = reader.ReadSingle();
                data.Impact_Mantle_Existing_Stun_Multiplier_offset = reader.BaseStream.Position;
                data.Impact_Mantle_Existing_Stun_Multiplier_raw = reader.ReadSingle();
                data.Impact_Mantle_Motion_Value_Needed_for_Light_Attack_Exhaust_Bonus_offset = reader.BaseStream.Position;
                data.Impact_Mantle_Motion_Value_Needed_for_Light_Attack_Exhaust_Bonus_raw = reader.ReadSingle();
                data.Impact_Mantle_Motion_Value_Needed_for_Heavy_Attack_Exhaust_Bonus_offset = reader.BaseStream.Position;
                data.Impact_Mantle_Motion_Value_Needed_for_Heavy_Attack_Exhaust_Bonus_raw = reader.ReadSingle();
                data.Impact_Mantle_Motion_Value_Needed_for_Extreme_Attack_Exhaust_Bonus_offset = reader.BaseStream.Position;
                data.Impact_Mantle_Motion_Value_Needed_for_Extreme_Attack_Exhaust_Bonus_raw = reader.ReadSingle();
                data.Impact_Mantle_Weak_Attack_Exhaust_Bonus_offset = reader.BaseStream.Position;
                data.Impact_Mantle_Weak_Attack_Exhaust_Bonus_raw = reader.ReadSingle();
                data.Impact_Mantle_Light_Attack_Exhaust_Bonus_offset = reader.BaseStream.Position;
                data.Impact_Mantle_Light_Attack_Exhaust_Bonus_raw = reader.ReadSingle();
                data.Impact_Mantle_Heavy_Attack_Exhaust_Bonus_offset = reader.BaseStream.Position;
                data.Impact_Mantle_Heavy_Attack_Exhaust_Bonus_raw = reader.ReadSingle();
                data.Impact_Mantle_Extreme_Attack_Exhaust_Bonus_offset = reader.BaseStream.Position;
                data.Impact_Mantle_Extreme_Attack_Exhaust_Bonus_raw = reader.ReadSingle();
                data.Impact_Mantle_Existing_Exhaust_Multiplier_offset = reader.BaseStream.Position;
                data.Impact_Mantle_Existing_Exhaust_Multiplier_raw = reader.ReadSingle();
                data.Apothecary_Mantle_Cooldown_offset = reader.BaseStream.Position;
                data.Apothecary_Mantle_Cooldown_raw = reader.ReadSingle();
                data.Apothecary_Mantle_Duration_offset = reader.BaseStream.Position;
                data.Apothecary_Mantle_Duration_raw = reader.ReadSingle();
                data.Apothecary_Mantle_Status_Multiplier_Poison_offset = reader.BaseStream.Position;
                data.Apothecary_Mantle_Status_Multiplier_Poison_raw = reader.ReadSingle();
                data.Apothecary_Mantle_Status_Multiplier_Para_offset = reader.BaseStream.Position;
                data.Apothecary_Mantle_Status_Multiplier_Para_raw = reader.ReadSingle();
                data.Apothecary_Mantle_Status_Multiplier_Sleep_offset = reader.BaseStream.Position;
                data.Apothecary_Mantle_Status_Multiplier_Sleep_raw = reader.ReadSingle();
                data.Apothecary_Mantle_Status_Multiplier_Blast_offset = reader.BaseStream.Position;
                data.Apothecary_Mantle_Status_Multiplier_Blast_raw = reader.ReadSingle();
                data.Immunity_Mantle_Cooldown_offset = reader.BaseStream.Position;
                data.Immunity_Mantle_Cooldown_raw = reader.ReadSingle();
                data.Immunity_Mantle_Duration_offset = reader.BaseStream.Position;
                data.Immunity_Mantle_Duration_raw = reader.ReadSingle();
                data.Affinity_Booster_Cooldown_offset = reader.BaseStream.Position;
                data.Affinity_Booster_Cooldown_raw = reader.ReadSingle();
                data.Affinity_Booster_Duration_offset = reader.BaseStream.Position;
                data.Affinity_Booster_Duration_raw = reader.ReadSingle();
                data.Affinity_Booster_Buff_Duration_offset = reader.BaseStream.Position;
                data.Affinity_Booster_Buff_Duration_raw = reader.ReadSingle();
                data.Affinity_Booster_Buff_Affinity_offset = reader.BaseStream.Position;
                data.Affinity_Booster_Buff_Affinity_raw = reader.ReadInt32();
                data.Bandit_Mantle_Cooldown_offset = reader.BaseStream.Position;
                data.Bandit_Mantle_Cooldown_raw = reader.ReadSingle();
                data.Bandit_Mantle_Duration_offset = reader.BaseStream.Position;
                data.Bandit_Mantle_Duration_raw = reader.ReadSingle();
                data.Bandit_Mantle_Hits_to_Drop_Shiny_offset = reader.BaseStream.Position;
                data.Bandit_Mantle_Hits_to_Drop_Shiny_raw = reader.ReadSingle();
                data.Bandit_Mantle_Unk1_offset = reader.BaseStream.Position;
                data.Bandit_Mantle_Unk1_raw = reader.ReadSByte();
                data.Bandit_Mantle_Unk2_offset = reader.BaseStream.Position;
                data.Bandit_Mantle_Unk2_raw = reader.ReadSByte();
                data.Bandit_Mantle_Unk3_offset = reader.BaseStream.Position;
                data.Bandit_Mantle_Unk3_raw = reader.ReadSByte();
                data.Bandit_Mantle_Unk4_offset = reader.BaseStream.Position;
                data.Bandit_Mantle_Unk4_raw = reader.ReadSByte();
                data.Bandit_Mantle_Unk5_offset = reader.BaseStream.Position;
                data.Bandit_Mantle_Unk5_raw = reader.ReadSByte();
                data.Bandit_Mantle_Unk6_offset = reader.BaseStream.Position;
                data.Bandit_Mantle_Unk6_raw = reader.ReadSByte();
                data.Bandit_Mantle_Unk7_offset = reader.BaseStream.Position;
                data.Bandit_Mantle_Unk7_raw = reader.ReadSByte();
                data.Bandit_Mantle_Unk8_offset = reader.BaseStream.Position;
                data.Bandit_Mantle_Unk8_raw = reader.ReadSByte();
                data.Assassin_s_Hood_Cooldown_offset = reader.BaseStream.Position;
                data.Assassin_s_Hood_Cooldown_raw = reader.ReadSingle();
                data.Assassin_s_Hood_Duration_offset = reader.BaseStream.Position;
                data.Assassin_s_Hood_Duration_raw = reader.ReadSingle();
                data.Assassin_s_Hood_Sneak_Attack_Multiplier_offset = reader.BaseStream.Position;
                data.Assassin_s_Hood_Sneak_Attack_Multiplier_raw = reader.ReadSingle();
                data.Assassin_s_Hood_Sneak_Attack_Multiplier_Sleeping__offset = reader.BaseStream.Position;
                data.Assassin_s_Hood_Sneak_Attack_Multiplier_Sleeping__raw = reader.ReadSingle();
                data.Assassin_s_Hood_Unk1_offset = reader.BaseStream.Position;
                data.Assassin_s_Hood_Unk1_raw = reader.ReadSingle();
                data.Assassin_s_Hood_Speed_Multiplier_1_offset = reader.BaseStream.Position;
                data.Assassin_s_Hood_Speed_Multiplier_1_raw = reader.ReadSingle();
                data.Assassin_s_Hood_Speed_Multiplier_2_offset = reader.BaseStream.Position;
                data.Assassin_s_Hood_Speed_Multiplier_2_raw = reader.ReadSingle();
                data.Assassin_s_Hood_Speed_Multiplier_3_offset = reader.BaseStream.Position;
                data.Assassin_s_Hood_Speed_Multiplier_3_raw = reader.ReadSingle();
                data.Assassin_s_Hood_Speed_Multiplier_4_offset = reader.BaseStream.Position;
                data.Assassin_s_Hood_Speed_Multiplier_4_raw = reader.ReadSingle();
                data.Assassin_s_Hood_Unk2_offset = reader.BaseStream.Position;
                data.Assassin_s_Hood_Unk2_raw = reader.ReadSingle();
                data.Assassin_s_Hood_Unk3_offset = reader.BaseStream.Position;
                data.Assassin_s_Hood_Unk3_raw = reader.ReadSingle();
                data.Assassin_s_Hood_Unk4_offset = reader.BaseStream.Position;
                data.Assassin_s_Hood_Unk4_raw = reader.ReadSingle();
                data.Assassin_s_Hood_Unk5_offset = reader.BaseStream.Position;
                data.Assassin_s_Hood_Unk5_raw = reader.ReadSingle();
                data.Assassin_s_Hood_Unk6_offset = reader.BaseStream.Position;
                data.Assassin_s_Hood_Unk6_raw = reader.ReadSingle();
                data.Assassin_s_Hood_Unk7_offset = reader.BaseStream.Position;
                data.Assassin_s_Hood_Unk7_raw = reader.ReadSingle();
                data.Assassin_s_Hood_Unk8_offset = reader.BaseStream.Position;
                data.Assassin_s_Hood_Unk8_raw = reader.ReadSingle();
                data.Assassin_s_Hood_Unk9_offset = reader.BaseStream.Position;
                data.Assassin_s_Hood_Unk9_raw = reader.ReadSingle();
                data.Assassin_s_Hood_Unk10_offset = reader.BaseStream.Position;
                data.Assassin_s_Hood_Unk10_raw = reader.ReadSingle();
                data.Assassin_s_Hood_Unk11_offset = reader.BaseStream.Position;
                data.Assassin_s_Hood_Unk11_raw = reader.ReadSingle();
                data.Assassin_s_Hood_Unk12_offset = reader.BaseStream.Position;
                data.Assassin_s_Hood_Unk12_raw = reader.ReadSingle();
                data.Assassin_s_Hood_Unk13_offset = reader.BaseStream.Position;
                data.Assassin_s_Hood_Unk13_raw = reader.ReadSingle();
                data.Assassin_s_Hood_Unk14_offset = reader.BaseStream.Position;
                data.Assassin_s_Hood_Unk14_raw = reader.ReadSingle();
                data.Assassin_s_Hood_Unk15_offset = reader.BaseStream.Position;
                data.Assassin_s_Hood_Unk15_raw = reader.ReadSingle();
                data.Assassin_s_Hood_Unk16_offset = reader.BaseStream.Position;
                data.Assassin_s_Hood_Unk16_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Dragonproof_Mantle_Dragon_Damage_Multiplier_raw);
                writer.Write(Cleanser_Booster_Cooldown_raw);
                writer.Write(Cleanser_Booster_Duration_raw);
                writer.Write(Cleanser_Booster_Upgraded_Duration_raw);
                writer.Write(Cleanser_Booster_Unk1_raw);
                writer.Write(Cleanser_Booster_Unk2_raw);
                writer.Write(Cleanser_Booster_Unk3_raw);
                writer.Write(Cleanser_Booster_Unk4_raw);
                writer.Write(Glider_Mantle_Cooldown_raw);
                writer.Write(Glider_Mantle_Duration_raw);
                writer.Write(Glider_Mantle_Mount_Multiplier_raw);
                writer.Write(Evasion_Mantle_Cooldown_raw);
                writer.Write(Evasion_Mantle_Duration_raw);
                writer.Write(Evasion_Mantle_Attack_Boost_Duration_raw);
                writer.Write(Evasion_Mantle_Evasion_Multiplier_raw);
                writer.Write(Evasion_Mantle_Unk1_raw);
                writer.Write(Evasion_Mantle_Unk2_raw);
                writer.Write(Evasion_Mantle_Unk3_raw);
                writer.Write(Evasion_Mantle_Unk4_raw);
                writer.Write(Evasion_Mantle_Unk5_raw);
                writer.Write(Evasion_Mantle_Unk6_raw);
                writer.Write(Impact_Mantle_Cooldown_raw);
                writer.Write(Impact_Mantle_Duration_raw);
                writer.Write(Impact_Mantle_Motion_Value_Needed_for_Light_Attack_Stun_Bonus_raw);
                writer.Write(Impact_Mantle_Motion_Value_Needed_for_Heavy_Attack_Stun_Bonus_raw);
                writer.Write(Impact_Mantle_Motion_Value_Needed_for_Extreme_Attack_Stun_Bonus_raw);
                writer.Write(Impact_Mantle_Weak_Attack_Stun_Bonus_raw);
                writer.Write(Impact_Mantle_Light_Attack_Stun_Bonus_raw);
                writer.Write(Impact_Mantle_Heavy_Attack_Stun_Bonus_raw);
                writer.Write(Impact_Mantle_Extreme_Attack_Stun_Bonus_raw);
                writer.Write(Impact_Mantle_Existing_Stun_Multiplier_raw);
                writer.Write(Impact_Mantle_Motion_Value_Needed_for_Light_Attack_Exhaust_Bonus_raw);
                writer.Write(Impact_Mantle_Motion_Value_Needed_for_Heavy_Attack_Exhaust_Bonus_raw);
                writer.Write(Impact_Mantle_Motion_Value_Needed_for_Extreme_Attack_Exhaust_Bonus_raw);
                writer.Write(Impact_Mantle_Weak_Attack_Exhaust_Bonus_raw);
                writer.Write(Impact_Mantle_Light_Attack_Exhaust_Bonus_raw);
                writer.Write(Impact_Mantle_Heavy_Attack_Exhaust_Bonus_raw);
                writer.Write(Impact_Mantle_Extreme_Attack_Exhaust_Bonus_raw);
                writer.Write(Impact_Mantle_Existing_Exhaust_Multiplier_raw);
                writer.Write(Apothecary_Mantle_Cooldown_raw);
                writer.Write(Apothecary_Mantle_Duration_raw);
                writer.Write(Apothecary_Mantle_Status_Multiplier_Poison_raw);
                writer.Write(Apothecary_Mantle_Status_Multiplier_Para_raw);
                writer.Write(Apothecary_Mantle_Status_Multiplier_Sleep_raw);
                writer.Write(Apothecary_Mantle_Status_Multiplier_Blast_raw);
                writer.Write(Immunity_Mantle_Cooldown_raw);
                writer.Write(Immunity_Mantle_Duration_raw);
                writer.Write(Affinity_Booster_Cooldown_raw);
                writer.Write(Affinity_Booster_Duration_raw);
                writer.Write(Affinity_Booster_Buff_Duration_raw);
                writer.Write(Affinity_Booster_Buff_Affinity_raw);
                writer.Write(Bandit_Mantle_Cooldown_raw);
                writer.Write(Bandit_Mantle_Duration_raw);
                writer.Write(Bandit_Mantle_Hits_to_Drop_Shiny_raw);
                writer.Write(Bandit_Mantle_Unk1_raw);
                writer.Write(Bandit_Mantle_Unk2_raw);
                writer.Write(Bandit_Mantle_Unk3_raw);
                writer.Write(Bandit_Mantle_Unk4_raw);
                writer.Write(Bandit_Mantle_Unk5_raw);
                writer.Write(Bandit_Mantle_Unk6_raw);
                writer.Write(Bandit_Mantle_Unk7_raw);
                writer.Write(Bandit_Mantle_Unk8_raw);
                writer.Write(Assassin_s_Hood_Cooldown_raw);
                writer.Write(Assassin_s_Hood_Duration_raw);
                writer.Write(Assassin_s_Hood_Sneak_Attack_Multiplier_raw);
                writer.Write(Assassin_s_Hood_Sneak_Attack_Multiplier_Sleeping__raw);
                writer.Write(Assassin_s_Hood_Unk1_raw);
                writer.Write(Assassin_s_Hood_Speed_Multiplier_1_raw);
                writer.Write(Assassin_s_Hood_Speed_Multiplier_2_raw);
                writer.Write(Assassin_s_Hood_Speed_Multiplier_3_raw);
                writer.Write(Assassin_s_Hood_Speed_Multiplier_4_raw);
                writer.Write(Assassin_s_Hood_Unk2_raw);
                writer.Write(Assassin_s_Hood_Unk3_raw);
                writer.Write(Assassin_s_Hood_Unk4_raw);
                writer.Write(Assassin_s_Hood_Unk5_raw);
                writer.Write(Assassin_s_Hood_Unk6_raw);
                writer.Write(Assassin_s_Hood_Unk7_raw);
                writer.Write(Assassin_s_Hood_Unk8_raw);
                writer.Write(Assassin_s_Hood_Unk9_raw);
                writer.Write(Assassin_s_Hood_Unk10_raw);
                writer.Write(Assassin_s_Hood_Unk11_raw);
                writer.Write(Assassin_s_Hood_Unk12_raw);
                writer.Write(Assassin_s_Hood_Unk13_raw);
                writer.Write(Assassin_s_Hood_Unk14_raw);
                writer.Write(Assassin_s_Hood_Unk15_raw);
                writer.Write(Assassin_s_Hood_Unk16_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Dragonproof Mantle: Dragon Damage Multiplier", "Dragonproof_Mantle_Dragon_Damage_Multiplier", "Dragonproof_Mantle_Dragon_Damage_Multiplier_offset"),
                    new MultiStructItemCustomView(this, "Cleanser Booster: Cooldown", "Cleanser_Booster_Cooldown", "Cleanser_Booster_Cooldown_offset"),
                    new MultiStructItemCustomView(this, "Cleanser Booster: Duration", "Cleanser_Booster_Duration", "Cleanser_Booster_Duration_offset"),
                    new MultiStructItemCustomView(this, "Cleanser Booster: Upgraded Duration", "Cleanser_Booster_Upgraded_Duration", "Cleanser_Booster_Upgraded_Duration_offset"),
                    new MultiStructItemCustomView(this, "Cleanser Booster: Unk1", "Cleanser_Booster_Unk1", "Cleanser_Booster_Unk1_offset"),
                    new MultiStructItemCustomView(this, "Cleanser Booster: Unk2", "Cleanser_Booster_Unk2", "Cleanser_Booster_Unk2_offset"),
                    new MultiStructItemCustomView(this, "Cleanser Booster: Unk3", "Cleanser_Booster_Unk3", "Cleanser_Booster_Unk3_offset"),
                    new MultiStructItemCustomView(this, "Cleanser Booster: Unk4", "Cleanser_Booster_Unk4", "Cleanser_Booster_Unk4_offset"),
                    new MultiStructItemCustomView(this, "Glider Mantle: Cooldown", "Glider_Mantle_Cooldown", "Glider_Mantle_Cooldown_offset"),
                    new MultiStructItemCustomView(this, "Glider Mantle: Duration", "Glider_Mantle_Duration", "Glider_Mantle_Duration_offset"),
                    new MultiStructItemCustomView(this, "Glider Mantle: Mount Multiplier", "Glider_Mantle_Mount_Multiplier", "Glider_Mantle_Mount_Multiplier_offset"),
                    new MultiStructItemCustomView(this, "Evasion Mantle: Cooldown", "Evasion_Mantle_Cooldown", "Evasion_Mantle_Cooldown_offset"),
                    new MultiStructItemCustomView(this, "Evasion Mantle: Duration", "Evasion_Mantle_Duration", "Evasion_Mantle_Duration_offset"),
                    new MultiStructItemCustomView(this, "Evasion Mantle: Attack Boost Duration", "Evasion_Mantle_Attack_Boost_Duration", "Evasion_Mantle_Attack_Boost_Duration_offset"),
                    new MultiStructItemCustomView(this, "Evasion Mantle: Evasion Multiplier", "Evasion_Mantle_Evasion_Multiplier", "Evasion_Mantle_Evasion_Multiplier_offset"),
                    new MultiStructItemCustomView(this, "Evasion Mantle: Unk1", "Evasion_Mantle_Unk1", "Evasion_Mantle_Unk1_offset"),
                    new MultiStructItemCustomView(this, "Evasion Mantle: Unk2", "Evasion_Mantle_Unk2", "Evasion_Mantle_Unk2_offset"),
                    new MultiStructItemCustomView(this, "Evasion Mantle: Unk3", "Evasion_Mantle_Unk3", "Evasion_Mantle_Unk3_offset"),
                    new MultiStructItemCustomView(this, "Evasion Mantle: Unk4", "Evasion_Mantle_Unk4", "Evasion_Mantle_Unk4_offset"),
                    new MultiStructItemCustomView(this, "Evasion Mantle: Unk5", "Evasion_Mantle_Unk5", "Evasion_Mantle_Unk5_offset"),
                    new MultiStructItemCustomView(this, "Evasion Mantle: Unk6", "Evasion_Mantle_Unk6", "Evasion_Mantle_Unk6_offset"),
                    new MultiStructItemCustomView(this, "Impact Mantle: Cooldown", "Impact_Mantle_Cooldown", "Impact_Mantle_Cooldown_offset"),
                    new MultiStructItemCustomView(this, "Impact Mantle: Duration", "Impact_Mantle_Duration", "Impact_Mantle_Duration_offset"),
                    new MultiStructItemCustomView(this, "Impact Mantle: Motion Value Needed for Light Attack Stun Bonus", "Impact_Mantle_Motion_Value_Needed_for_Light_Attack_Stun_Bonus", "Impact_Mantle_Motion_Value_Needed_for_Light_Attack_Stun_Bonus_offset"),
                    new MultiStructItemCustomView(this, "Impact Mantle: Motion Value Needed for Heavy Attack Stun Bonus", "Impact_Mantle_Motion_Value_Needed_for_Heavy_Attack_Stun_Bonus", "Impact_Mantle_Motion_Value_Needed_for_Heavy_Attack_Stun_Bonus_offset"),
                    new MultiStructItemCustomView(this, "Impact Mantle: Motion Value Needed for Extreme Attack Stun Bonus", "Impact_Mantle_Motion_Value_Needed_for_Extreme_Attack_Stun_Bonus", "Impact_Mantle_Motion_Value_Needed_for_Extreme_Attack_Stun_Bonus_offset"),
                    new MultiStructItemCustomView(this, "Impact Mantle: Weak Attack Stun Bonus", "Impact_Mantle_Weak_Attack_Stun_Bonus", "Impact_Mantle_Weak_Attack_Stun_Bonus_offset"),
                    new MultiStructItemCustomView(this, "Impact Mantle: Light Attack Stun Bonus", "Impact_Mantle_Light_Attack_Stun_Bonus", "Impact_Mantle_Light_Attack_Stun_Bonus_offset"),
                    new MultiStructItemCustomView(this, "Impact Mantle: Heavy Attack Stun Bonus", "Impact_Mantle_Heavy_Attack_Stun_Bonus", "Impact_Mantle_Heavy_Attack_Stun_Bonus_offset"),
                    new MultiStructItemCustomView(this, "Impact Mantle: Extreme Attack Stun Bonus", "Impact_Mantle_Extreme_Attack_Stun_Bonus", "Impact_Mantle_Extreme_Attack_Stun_Bonus_offset"),
                    new MultiStructItemCustomView(this, "Impact Mantle: Existing Stun Multiplier", "Impact_Mantle_Existing_Stun_Multiplier", "Impact_Mantle_Existing_Stun_Multiplier_offset"),
                    new MultiStructItemCustomView(this, "Impact Mantle: Motion Value Needed for Light Attack Exhaust Bonus", "Impact_Mantle_Motion_Value_Needed_for_Light_Attack_Exhaust_Bonus", "Impact_Mantle_Motion_Value_Needed_for_Light_Attack_Exhaust_Bonus_offset"),
                    new MultiStructItemCustomView(this, "Impact Mantle: Motion Value Needed for Heavy Attack Exhaust Bonus", "Impact_Mantle_Motion_Value_Needed_for_Heavy_Attack_Exhaust_Bonus", "Impact_Mantle_Motion_Value_Needed_for_Heavy_Attack_Exhaust_Bonus_offset"),
                    new MultiStructItemCustomView(this, "Impact Mantle: Motion Value Needed for Extreme Attack Exhaust Bonus", "Impact_Mantle_Motion_Value_Needed_for_Extreme_Attack_Exhaust_Bonus", "Impact_Mantle_Motion_Value_Needed_for_Extreme_Attack_Exhaust_Bonus_offset"),
                    new MultiStructItemCustomView(this, "Impact Mantle: Weak Attack Exhaust Bonus", "Impact_Mantle_Weak_Attack_Exhaust_Bonus", "Impact_Mantle_Weak_Attack_Exhaust_Bonus_offset"),
                    new MultiStructItemCustomView(this, "Impact Mantle: Light Attack Exhaust Bonus", "Impact_Mantle_Light_Attack_Exhaust_Bonus", "Impact_Mantle_Light_Attack_Exhaust_Bonus_offset"),
                    new MultiStructItemCustomView(this, "Impact Mantle: Heavy Attack Exhaust Bonus", "Impact_Mantle_Heavy_Attack_Exhaust_Bonus", "Impact_Mantle_Heavy_Attack_Exhaust_Bonus_offset"),
                    new MultiStructItemCustomView(this, "Impact Mantle: Extreme Attack Exhaust Bonus", "Impact_Mantle_Extreme_Attack_Exhaust_Bonus", "Impact_Mantle_Extreme_Attack_Exhaust_Bonus_offset"),
                    new MultiStructItemCustomView(this, "Impact Mantle: Existing Exhaust Multiplier", "Impact_Mantle_Existing_Exhaust_Multiplier", "Impact_Mantle_Existing_Exhaust_Multiplier_offset"),
                    new MultiStructItemCustomView(this, "Apothecary Mantle: Cooldown", "Apothecary_Mantle_Cooldown", "Apothecary_Mantle_Cooldown_offset"),
                    new MultiStructItemCustomView(this, "Apothecary Mantle: Duration", "Apothecary_Mantle_Duration", "Apothecary_Mantle_Duration_offset"),
                    new MultiStructItemCustomView(this, "Apothecary Mantle: Status Multiplier: Poison", "Apothecary_Mantle_Status_Multiplier_Poison", "Apothecary_Mantle_Status_Multiplier_Poison_offset"),
                    new MultiStructItemCustomView(this, "Apothecary Mantle: Status Multiplier: Para", "Apothecary_Mantle_Status_Multiplier_Para", "Apothecary_Mantle_Status_Multiplier_Para_offset"),
                    new MultiStructItemCustomView(this, "Apothecary Mantle: Status Multiplier: Sleep", "Apothecary_Mantle_Status_Multiplier_Sleep", "Apothecary_Mantle_Status_Multiplier_Sleep_offset"),
                    new MultiStructItemCustomView(this, "Apothecary Mantle: Status Multiplier: Blast", "Apothecary_Mantle_Status_Multiplier_Blast", "Apothecary_Mantle_Status_Multiplier_Blast_offset"),
                    new MultiStructItemCustomView(this, "Immunity Mantle: Cooldown", "Immunity_Mantle_Cooldown", "Immunity_Mantle_Cooldown_offset"),
                    new MultiStructItemCustomView(this, "Immunity Mantle: Duration", "Immunity_Mantle_Duration", "Immunity_Mantle_Duration_offset"),
                    new MultiStructItemCustomView(this, "Affinity Booster: Cooldown", "Affinity_Booster_Cooldown", "Affinity_Booster_Cooldown_offset"),
                    new MultiStructItemCustomView(this, "Affinity Booster: Duration", "Affinity_Booster_Duration", "Affinity_Booster_Duration_offset"),
                    new MultiStructItemCustomView(this, "Affinity Booster: Buff Duration", "Affinity_Booster_Buff_Duration", "Affinity_Booster_Buff_Duration_offset"),
                    new MultiStructItemCustomView(this, "Affinity Booster: Buff Affinity", "Affinity_Booster_Buff_Affinity", "Affinity_Booster_Buff_Affinity_offset"),
                    new MultiStructItemCustomView(this, "Bandit Mantle: Cooldown", "Bandit_Mantle_Cooldown", "Bandit_Mantle_Cooldown_offset"),
                    new MultiStructItemCustomView(this, "Bandit Mantle: Duration", "Bandit_Mantle_Duration", "Bandit_Mantle_Duration_offset"),
                    new MultiStructItemCustomView(this, "Bandit Mantle: Hits to Drop Shiny", "Bandit_Mantle_Hits_to_Drop_Shiny", "Bandit_Mantle_Hits_to_Drop_Shiny_offset"),
                    new MultiStructItemCustomView(this, "Bandit Mantle: Unk1", "Bandit_Mantle_Unk1", "Bandit_Mantle_Unk1_offset"),
                    new MultiStructItemCustomView(this, "Bandit Mantle: Unk2", "Bandit_Mantle_Unk2", "Bandit_Mantle_Unk2_offset"),
                    new MultiStructItemCustomView(this, "Bandit Mantle: Unk3", "Bandit_Mantle_Unk3", "Bandit_Mantle_Unk3_offset"),
                    new MultiStructItemCustomView(this, "Bandit Mantle: Unk4", "Bandit_Mantle_Unk4", "Bandit_Mantle_Unk4_offset"),
                    new MultiStructItemCustomView(this, "Bandit Mantle: Unk5", "Bandit_Mantle_Unk5", "Bandit_Mantle_Unk5_offset"),
                    new MultiStructItemCustomView(this, "Bandit Mantle: Unk6", "Bandit_Mantle_Unk6", "Bandit_Mantle_Unk6_offset"),
                    new MultiStructItemCustomView(this, "Bandit Mantle: Unk7", "Bandit_Mantle_Unk7", "Bandit_Mantle_Unk7_offset"),
                    new MultiStructItemCustomView(this, "Bandit Mantle: Unk8", "Bandit_Mantle_Unk8", "Bandit_Mantle_Unk8_offset"),
                    new MultiStructItemCustomView(this, "Assassin's Hood: Cooldown", "Assassin_s_Hood_Cooldown", "Assassin_s_Hood_Cooldown_offset"),
                    new MultiStructItemCustomView(this, "Assassin's Hood: Duration", "Assassin_s_Hood_Duration", "Assassin_s_Hood_Duration_offset"),
                    new MultiStructItemCustomView(this, "Assassin's Hood: Sneak Attack Multiplier", "Assassin_s_Hood_Sneak_Attack_Multiplier", "Assassin_s_Hood_Sneak_Attack_Multiplier_offset"),
                    new MultiStructItemCustomView(this, "Assassin's Hood: Sneak Attack Multiplier (Sleeping)", "Assassin_s_Hood_Sneak_Attack_Multiplier_Sleeping_", "Assassin_s_Hood_Sneak_Attack_Multiplier_Sleeping__offset"),
                    new MultiStructItemCustomView(this, "Assassin's Hood: Unk1", "Assassin_s_Hood_Unk1", "Assassin_s_Hood_Unk1_offset"),
                    new MultiStructItemCustomView(this, "Assassin's Hood: Speed Multiplier 1", "Assassin_s_Hood_Speed_Multiplier_1", "Assassin_s_Hood_Speed_Multiplier_1_offset"),
                    new MultiStructItemCustomView(this, "Assassin's Hood: Speed Multiplier 2", "Assassin_s_Hood_Speed_Multiplier_2", "Assassin_s_Hood_Speed_Multiplier_2_offset"),
                    new MultiStructItemCustomView(this, "Assassin's Hood: Speed Multiplier 3", "Assassin_s_Hood_Speed_Multiplier_3", "Assassin_s_Hood_Speed_Multiplier_3_offset"),
                    new MultiStructItemCustomView(this, "Assassin's Hood: Speed Multiplier 4", "Assassin_s_Hood_Speed_Multiplier_4", "Assassin_s_Hood_Speed_Multiplier_4_offset"),
                    new MultiStructItemCustomView(this, "Assassin's Hood: Unk2", "Assassin_s_Hood_Unk2", "Assassin_s_Hood_Unk2_offset"),
                    new MultiStructItemCustomView(this, "Assassin's Hood: Unk3", "Assassin_s_Hood_Unk3", "Assassin_s_Hood_Unk3_offset"),
                    new MultiStructItemCustomView(this, "Assassin's Hood: Unk4", "Assassin_s_Hood_Unk4", "Assassin_s_Hood_Unk4_offset"),
                    new MultiStructItemCustomView(this, "Assassin's Hood: Unk5", "Assassin_s_Hood_Unk5", "Assassin_s_Hood_Unk5_offset"),
                    new MultiStructItemCustomView(this, "Assassin's Hood: Unk6", "Assassin_s_Hood_Unk6", "Assassin_s_Hood_Unk6_offset"),
                    new MultiStructItemCustomView(this, "Assassin's Hood: Unk7", "Assassin_s_Hood_Unk7", "Assassin_s_Hood_Unk7_offset"),
                    new MultiStructItemCustomView(this, "Assassin's Hood: Unk8", "Assassin_s_Hood_Unk8", "Assassin_s_Hood_Unk8_offset"),
                    new MultiStructItemCustomView(this, "Assassin's Hood: Unk9", "Assassin_s_Hood_Unk9", "Assassin_s_Hood_Unk9_offset"),
                    new MultiStructItemCustomView(this, "Assassin's Hood: Unk10", "Assassin_s_Hood_Unk10", "Assassin_s_Hood_Unk10_offset"),
                    new MultiStructItemCustomView(this, "Assassin's Hood: Unk11", "Assassin_s_Hood_Unk11", "Assassin_s_Hood_Unk11_offset"),
                    new MultiStructItemCustomView(this, "Assassin's Hood: Unk12", "Assassin_s_Hood_Unk12", "Assassin_s_Hood_Unk12_offset"),
                    new MultiStructItemCustomView(this, "Assassin's Hood: Unk13", "Assassin_s_Hood_Unk13", "Assassin_s_Hood_Unk13_offset"),
                    new MultiStructItemCustomView(this, "Assassin's Hood: Unk14", "Assassin_s_Hood_Unk14", "Assassin_s_Hood_Unk14_offset"),
                    new MultiStructItemCustomView(this, "Assassin's Hood: Unk15", "Assassin_s_Hood_Unk15", "Assassin_s_Hood_Unk15_offset"),
                    new MultiStructItemCustomView(this, "Assassin's Hood: Unk16", "Assassin_s_Hood_Unk16", "Assassin_s_Hood_Unk16_offset"),
                };
            }
        }

        public override void LoadFile(string targetFile) {
            using var reader = new BinaryReader(OpenFile(targetFile, EncryptionKey), Encoding.UTF8);
            data = new LinkedList<MhwStructDataContainer>();
            var Header_ = new MhwStructDataContainer<Header>(Header.LoadData(reader), typeof(Header));
            data.AddLast(Header_);
            var Mantle_Params_1__ = new MhwStructDataContainer<Mantle_Params_1_>(Mantle_Params_1_.LoadData(reader), typeof(Mantle_Params_1_));
            data.AddLast(Mantle_Params_1__);
            var Mantle_Params_2__ = new MhwStructDataContainer<Mantle_Params_2_>(Mantle_Params_2_.LoadData(reader), typeof(Mantle_Params_2_));
            data.AddLast(Mantle_Params_2__);
            var Mantle_Params_3__ = new MhwStructDataContainer<Mantle_Params_3_>(Mantle_Params_3_.LoadData(reader), typeof(Mantle_Params_3_));
            data.AddLast(Mantle_Params_3__);
        }
    }
}
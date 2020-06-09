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

namespace MHW_Editor.Items {
    public partial class SafiItemLottery {
        public override string EncryptionKey => null;

        public partial class Header : MhwStructItem {
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

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
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

        public partial class Entries : MhwStructItem {
            public const ulong FixedSizeCount = 0;
            public const string GridName = "Entries";

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

            protected uint Weapon_Type_raw;
            public const string Weapon_Type_displayName = "Weapon Type";
            public const int Weapon_Type_sortIndex = 100;
            [SortOrder(Weapon_Type_sortIndex)]
            [DisplayName(Weapon_Type_displayName)]
            public virtual MHW_Template.Weapons.WeaponType Weapon_Type {
                get => (MHW_Template.Weapons.WeaponType) Weapon_Type_raw;
                set {
                    if ((MHW_Template.Weapons.WeaponType) Weapon_Type_raw == value) return;
                    Weapon_Type_raw = (uint) value;
                    OnPropertyChanged(nameof(Weapon_Type));
                    OnPropertyChanged(nameof(Weapon_Id_button));
                }
            }

            protected uint Weapon_Id_raw;
            public const string Weapon_Id_displayName = "Weapon Id";
            public const int Weapon_Id_sortIndex = 150;
            [SortOrder(Weapon_Id_sortIndex)]
            [DisplayName(Weapon_Id_displayName)]
            [DataSource(DataSourceType.WeaponsById)]
            public virtual uint Weapon_Id {
                get => Weapon_Id_raw;
                set {
                    if (Weapon_Id_raw == value) return;
                    Weapon_Id_raw = value;
                    OnPropertyChanged(nameof(Weapon_Id));
                    OnPropertyChanged(nameof(Weapon_Id_button));
                }
            }

            [SortOrder(Weapon_Id_sortIndex)]
            [DisplayName(Weapon_Id_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Weapon_Id_button => DataHelper.weaponIdNameLookup[GetWeaponType()][MainWindow.locale].TryGet(Weapon_Id).ToStringWithId(Weapon_Id);

            protected uint All_Rarity_raw;
            public const string All_Rarity_displayName = "All Rarity";
            public const int All_Rarity_sortIndex = 200;
            [SortOrder(All_Rarity_sortIndex)]
            [DisplayName(All_Rarity_displayName)]
            public virtual uint All_Rarity {
                get => All_Rarity_raw;
                set {
                    if (All_Rarity_raw == value) return;
                    All_Rarity_raw = value;
                    OnPropertyChanged(nameof(All_Rarity));
                }
            }

            protected uint GS_Rarity_raw;
            public const string GS_Rarity_displayName = "GS Rarity";
            public const int GS_Rarity_sortIndex = 250;
            [SortOrder(GS_Rarity_sortIndex)]
            [DisplayName(GS_Rarity_displayName)]
            public virtual uint GS_Rarity {
                get => GS_Rarity_raw;
                set {
                    if (GS_Rarity_raw == value) return;
                    GS_Rarity_raw = value;
                    OnPropertyChanged(nameof(GS_Rarity));
                }
            }

            protected uint LS_Rarity_raw;
            public const string LS_Rarity_displayName = "LS Rarity";
            public const int LS_Rarity_sortIndex = 300;
            [SortOrder(LS_Rarity_sortIndex)]
            [DisplayName(LS_Rarity_displayName)]
            public virtual uint LS_Rarity {
                get => LS_Rarity_raw;
                set {
                    if (LS_Rarity_raw == value) return;
                    LS_Rarity_raw = value;
                    OnPropertyChanged(nameof(LS_Rarity));
                }
            }

            protected uint SnS_Rarity_raw;
            public const string SnS_Rarity_displayName = "SnS Rarity";
            public const int SnS_Rarity_sortIndex = 350;
            [SortOrder(SnS_Rarity_sortIndex)]
            [DisplayName(SnS_Rarity_displayName)]
            public virtual uint SnS_Rarity {
                get => SnS_Rarity_raw;
                set {
                    if (SnS_Rarity_raw == value) return;
                    SnS_Rarity_raw = value;
                    OnPropertyChanged(nameof(SnS_Rarity));
                }
            }

            protected uint DB_Rarity_raw;
            public const string DB_Rarity_displayName = "DB Rarity";
            public const int DB_Rarity_sortIndex = 400;
            [SortOrder(DB_Rarity_sortIndex)]
            [DisplayName(DB_Rarity_displayName)]
            public virtual uint DB_Rarity {
                get => DB_Rarity_raw;
                set {
                    if (DB_Rarity_raw == value) return;
                    DB_Rarity_raw = value;
                    OnPropertyChanged(nameof(DB_Rarity));
                }
            }

            protected uint Lance_Rarity_raw;
            public const string Lance_Rarity_displayName = "Lance Rarity";
            public const int Lance_Rarity_sortIndex = 450;
            [SortOrder(Lance_Rarity_sortIndex)]
            [DisplayName(Lance_Rarity_displayName)]
            public virtual uint Lance_Rarity {
                get => Lance_Rarity_raw;
                set {
                    if (Lance_Rarity_raw == value) return;
                    Lance_Rarity_raw = value;
                    OnPropertyChanged(nameof(Lance_Rarity));
                }
            }

            protected uint GL_Rarity_raw;
            public const string GL_Rarity_displayName = "GL Rarity";
            public const int GL_Rarity_sortIndex = 500;
            [SortOrder(GL_Rarity_sortIndex)]
            [DisplayName(GL_Rarity_displayName)]
            public virtual uint GL_Rarity {
                get => GL_Rarity_raw;
                set {
                    if (GL_Rarity_raw == value) return;
                    GL_Rarity_raw = value;
                    OnPropertyChanged(nameof(GL_Rarity));
                }
            }

            protected uint Hammer_Rarity_raw;
            public const string Hammer_Rarity_displayName = "Hammer Rarity";
            public const int Hammer_Rarity_sortIndex = 550;
            [SortOrder(Hammer_Rarity_sortIndex)]
            [DisplayName(Hammer_Rarity_displayName)]
            public virtual uint Hammer_Rarity {
                get => Hammer_Rarity_raw;
                set {
                    if (Hammer_Rarity_raw == value) return;
                    Hammer_Rarity_raw = value;
                    OnPropertyChanged(nameof(Hammer_Rarity));
                }
            }

            protected uint HH_Rarity_raw;
            public const string HH_Rarity_displayName = "HH Rarity";
            public const int HH_Rarity_sortIndex = 600;
            [SortOrder(HH_Rarity_sortIndex)]
            [DisplayName(HH_Rarity_displayName)]
            public virtual uint HH_Rarity {
                get => HH_Rarity_raw;
                set {
                    if (HH_Rarity_raw == value) return;
                    HH_Rarity_raw = value;
                    OnPropertyChanged(nameof(HH_Rarity));
                }
            }

            protected uint SA_Rarity_raw;
            public const string SA_Rarity_displayName = "SA Rarity";
            public const int SA_Rarity_sortIndex = 650;
            [SortOrder(SA_Rarity_sortIndex)]
            [DisplayName(SA_Rarity_displayName)]
            public virtual uint SA_Rarity {
                get => SA_Rarity_raw;
                set {
                    if (SA_Rarity_raw == value) return;
                    SA_Rarity_raw = value;
                    OnPropertyChanged(nameof(SA_Rarity));
                }
            }

            protected uint CB_Rarity_raw;
            public const string CB_Rarity_displayName = "CB Rarity";
            public const int CB_Rarity_sortIndex = 700;
            [SortOrder(CB_Rarity_sortIndex)]
            [DisplayName(CB_Rarity_displayName)]
            public virtual uint CB_Rarity {
                get => CB_Rarity_raw;
                set {
                    if (CB_Rarity_raw == value) return;
                    CB_Rarity_raw = value;
                    OnPropertyChanged(nameof(CB_Rarity));
                }
            }

            protected uint IG_Rarity_raw;
            public const string IG_Rarity_displayName = "IG Rarity";
            public const int IG_Rarity_sortIndex = 750;
            [SortOrder(IG_Rarity_sortIndex)]
            [DisplayName(IG_Rarity_displayName)]
            public virtual uint IG_Rarity {
                get => IG_Rarity_raw;
                set {
                    if (IG_Rarity_raw == value) return;
                    IG_Rarity_raw = value;
                    OnPropertyChanged(nameof(IG_Rarity));
                }
            }

            protected uint LBG_Rarity_raw;
            public const string LBG_Rarity_displayName = "LBG Rarity";
            public const int LBG_Rarity_sortIndex = 800;
            [SortOrder(LBG_Rarity_sortIndex)]
            [DisplayName(LBG_Rarity_displayName)]
            public virtual uint LBG_Rarity {
                get => LBG_Rarity_raw;
                set {
                    if (LBG_Rarity_raw == value) return;
                    LBG_Rarity_raw = value;
                    OnPropertyChanged(nameof(LBG_Rarity));
                }
            }

            protected uint HBG_Rarity_raw;
            public const string HBG_Rarity_displayName = "HBG Rarity";
            public const int HBG_Rarity_sortIndex = 850;
            [SortOrder(HBG_Rarity_sortIndex)]
            [DisplayName(HBG_Rarity_displayName)]
            public virtual uint HBG_Rarity {
                get => HBG_Rarity_raw;
                set {
                    if (HBG_Rarity_raw == value) return;
                    HBG_Rarity_raw = value;
                    OnPropertyChanged(nameof(HBG_Rarity));
                }
            }

            protected uint Bow_Rarity_raw;
            public const string Bow_Rarity_displayName = "Bow Rarity";
            public const int Bow_Rarity_sortIndex = 900;
            [SortOrder(Bow_Rarity_sortIndex)]
            [DisplayName(Bow_Rarity_displayName)]
            public virtual uint Bow_Rarity {
                get => Bow_Rarity_raw;
                set {
                    if (Bow_Rarity_raw == value) return;
                    Bow_Rarity_raw = value;
                    OnPropertyChanged(nameof(Bow_Rarity));
                }
            }

            public const int lastSortIndex = 950;

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
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
                data.Index_raw = reader.ReadUInt32();
                data.Weapon_Type_raw = reader.ReadUInt32();
                data.Weapon_Id_raw = reader.ReadUInt32();
                data.All_Rarity_raw = reader.ReadUInt32();
                data.GS_Rarity_raw = reader.ReadUInt32();
                data.LS_Rarity_raw = reader.ReadUInt32();
                data.SnS_Rarity_raw = reader.ReadUInt32();
                data.DB_Rarity_raw = reader.ReadUInt32();
                data.Lance_Rarity_raw = reader.ReadUInt32();
                data.GL_Rarity_raw = reader.ReadUInt32();
                data.Hammer_Rarity_raw = reader.ReadUInt32();
                data.HH_Rarity_raw = reader.ReadUInt32();
                data.SA_Rarity_raw = reader.ReadUInt32();
                data.CB_Rarity_raw = reader.ReadUInt32();
                data.IG_Rarity_raw = reader.ReadUInt32();
                data.LBG_Rarity_raw = reader.ReadUInt32();
                data.HBG_Rarity_raw = reader.ReadUInt32();
                data.Bow_Rarity_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Index_raw);
                writer.Write(Weapon_Type_raw);
                writer.Write(Weapon_Id_raw);
                writer.Write(All_Rarity_raw);
                writer.Write(GS_Rarity_raw);
                writer.Write(LS_Rarity_raw);
                writer.Write(SnS_Rarity_raw);
                writer.Write(DB_Rarity_raw);
                writer.Write(Lance_Rarity_raw);
                writer.Write(GL_Rarity_raw);
                writer.Write(Hammer_Rarity_raw);
                writer.Write(HH_Rarity_raw);
                writer.Write(SA_Rarity_raw);
                writer.Write(CB_Rarity_raw);
                writer.Write(IG_Rarity_raw);
                writer.Write(LBG_Rarity_raw);
                writer.Write(HBG_Rarity_raw);
                writer.Write(Bow_Rarity_raw);
            }
        }

        public override void LoadFile(string targetFile) {
            using var reader = new BinaryReader(OpenFile(targetFile, EncryptionKey), Encoding.UTF8);
            data = new LinkedList<MhwStructDataContainer>();
            var Header_ = new MhwStructDataContainer(Header.LoadData(reader, null), typeof(Header));
            data.AddLast(Header_);
            var Entries_ = new MhwStructDataContainer(Entries.LoadData(reader, Header_.list), typeof(Entries));
            Entries_.SetCountTargetToUpdate(Header_, -1, "Entry_Count");
            data.AddLast(Entries_);
        }
    }
}
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

namespace MHW_Editor.Weapons {
    public partial class AwakenedLimitBreakR {
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

            protected ushort Id_raw;
            public const string Id_displayName = "Id";
            public const int Id_sortIndex = 50;
            [SortOrder(Id_sortIndex)]
            [DisplayName(Id_displayName)]
            public virtual ushort Id {
                get => Id_raw;
                set {
                    if (Id_raw == value) return;
                    Id_raw = value;
                    OnPropertyChanged(nameof(Id));
                }
            }

            protected ushort Great_Sword_raw;
            public const string Great_Sword_displayName = "Great Sword";
            public const int Great_Sword_sortIndex = 100;
            [SortOrder(Great_Sword_sortIndex)]
            [DisplayName(Great_Sword_displayName)]
            public virtual ushort Great_Sword {
                get => Great_Sword_raw;
                set {
                    if (Great_Sword_raw == value) return;
                    Great_Sword_raw = value;
                    OnPropertyChanged(nameof(Great_Sword));
                }
            }

            protected ushort Sword_Shield_raw;
            public const string Sword_Shield_displayName = "Sword & Shield";
            public const int Sword_Shield_sortIndex = 150;
            [SortOrder(Sword_Shield_sortIndex)]
            [DisplayName(Sword_Shield_displayName)]
            public virtual ushort Sword_Shield {
                get => Sword_Shield_raw;
                set {
                    if (Sword_Shield_raw == value) return;
                    Sword_Shield_raw = value;
                    OnPropertyChanged(nameof(Sword_Shield));
                }
            }

            protected ushort Dual_Blades_raw;
            public const string Dual_Blades_displayName = "Dual Blades";
            public const int Dual_Blades_sortIndex = 200;
            [SortOrder(Dual_Blades_sortIndex)]
            [DisplayName(Dual_Blades_displayName)]
            public virtual ushort Dual_Blades {
                get => Dual_Blades_raw;
                set {
                    if (Dual_Blades_raw == value) return;
                    Dual_Blades_raw = value;
                    OnPropertyChanged(nameof(Dual_Blades));
                }
            }

            protected ushort Long_Sword_raw;
            public const string Long_Sword_displayName = "Long Sword";
            public const int Long_Sword_sortIndex = 250;
            [SortOrder(Long_Sword_sortIndex)]
            [DisplayName(Long_Sword_displayName)]
            public virtual ushort Long_Sword {
                get => Long_Sword_raw;
                set {
                    if (Long_Sword_raw == value) return;
                    Long_Sword_raw = value;
                    OnPropertyChanged(nameof(Long_Sword));
                }
            }

            protected ushort Hammer_raw;
            public const string Hammer_displayName = "Hammer";
            public const int Hammer_sortIndex = 300;
            [SortOrder(Hammer_sortIndex)]
            [DisplayName(Hammer_displayName)]
            public virtual ushort Hammer {
                get => Hammer_raw;
                set {
                    if (Hammer_raw == value) return;
                    Hammer_raw = value;
                    OnPropertyChanged(nameof(Hammer));
                }
            }

            protected ushort Hunting_Horn_raw;
            public const string Hunting_Horn_displayName = "Hunting Horn";
            public const int Hunting_Horn_sortIndex = 350;
            [SortOrder(Hunting_Horn_sortIndex)]
            [DisplayName(Hunting_Horn_displayName)]
            public virtual ushort Hunting_Horn {
                get => Hunting_Horn_raw;
                set {
                    if (Hunting_Horn_raw == value) return;
                    Hunting_Horn_raw = value;
                    OnPropertyChanged(nameof(Hunting_Horn));
                }
            }

            protected ushort Lance_raw;
            public const string Lance_displayName = "Lance";
            public const int Lance_sortIndex = 400;
            [SortOrder(Lance_sortIndex)]
            [DisplayName(Lance_displayName)]
            public virtual ushort Lance {
                get => Lance_raw;
                set {
                    if (Lance_raw == value) return;
                    Lance_raw = value;
                    OnPropertyChanged(nameof(Lance));
                }
            }

            protected ushort Gunlance_raw;
            public const string Gunlance_displayName = "Gunlance";
            public const int Gunlance_sortIndex = 450;
            [SortOrder(Gunlance_sortIndex)]
            [DisplayName(Gunlance_displayName)]
            public virtual ushort Gunlance {
                get => Gunlance_raw;
                set {
                    if (Gunlance_raw == value) return;
                    Gunlance_raw = value;
                    OnPropertyChanged(nameof(Gunlance));
                }
            }

            protected ushort Switch_Axe_raw;
            public const string Switch_Axe_displayName = "Switch Axe";
            public const int Switch_Axe_sortIndex = 500;
            [SortOrder(Switch_Axe_sortIndex)]
            [DisplayName(Switch_Axe_displayName)]
            public virtual ushort Switch_Axe {
                get => Switch_Axe_raw;
                set {
                    if (Switch_Axe_raw == value) return;
                    Switch_Axe_raw = value;
                    OnPropertyChanged(nameof(Switch_Axe));
                }
            }

            protected ushort Charge_Blade_raw;
            public const string Charge_Blade_displayName = "Charge Blade";
            public const int Charge_Blade_sortIndex = 550;
            [SortOrder(Charge_Blade_sortIndex)]
            [DisplayName(Charge_Blade_displayName)]
            public virtual ushort Charge_Blade {
                get => Charge_Blade_raw;
                set {
                    if (Charge_Blade_raw == value) return;
                    Charge_Blade_raw = value;
                    OnPropertyChanged(nameof(Charge_Blade));
                }
            }

            protected ushort Insect_Glaive_raw;
            public const string Insect_Glaive_displayName = "Insect Glaive";
            public const int Insect_Glaive_sortIndex = 600;
            [SortOrder(Insect_Glaive_sortIndex)]
            [DisplayName(Insect_Glaive_displayName)]
            public virtual ushort Insect_Glaive {
                get => Insect_Glaive_raw;
                set {
                    if (Insect_Glaive_raw == value) return;
                    Insect_Glaive_raw = value;
                    OnPropertyChanged(nameof(Insect_Glaive));
                }
            }

            protected ushort Bow_raw;
            public const string Bow_displayName = "Bow";
            public const int Bow_sortIndex = 650;
            [SortOrder(Bow_sortIndex)]
            [DisplayName(Bow_displayName)]
            public virtual ushort Bow {
                get => Bow_raw;
                set {
                    if (Bow_raw == value) return;
                    Bow_raw = value;
                    OnPropertyChanged(nameof(Bow));
                }
            }

            protected ushort HBG_raw;
            public const string HBG_displayName = "HBG";
            public const int HBG_sortIndex = 700;
            [SortOrder(HBG_sortIndex)]
            [DisplayName(HBG_displayName)]
            public virtual ushort HBG {
                get => HBG_raw;
                set {
                    if (HBG_raw == value) return;
                    HBG_raw = value;
                    OnPropertyChanged(nameof(HBG));
                }
            }

            protected ushort LBG_raw;
            public const string LBG_displayName = "LBG";
            public const int LBG_sortIndex = 750;
            [SortOrder(LBG_sortIndex)]
            [DisplayName(LBG_displayName)]
            public virtual ushort LBG {
                get => LBG_raw;
                set {
                    if (LBG_raw == value) return;
                    LBG_raw = value;
                    OnPropertyChanged(nameof(LBG));
                }
            }

            protected byte Unk_1_raw;
            public const string Unk_1_displayName = "Unk 1";
            public const int Unk_1_sortIndex = 800;
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
            public const int Unk_2_sortIndex = 850;
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
            public const int Unk_3_sortIndex = 900;
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
            public const int Unk_4_sortIndex = 950;
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

            public const int lastSortIndex = 1000;

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
                data.Id_raw = reader.ReadUInt16();
                data.Great_Sword_raw = reader.ReadUInt16();
                data.Sword_Shield_raw = reader.ReadUInt16();
                data.Dual_Blades_raw = reader.ReadUInt16();
                data.Long_Sword_raw = reader.ReadUInt16();
                data.Hammer_raw = reader.ReadUInt16();
                data.Hunting_Horn_raw = reader.ReadUInt16();
                data.Lance_raw = reader.ReadUInt16();
                data.Gunlance_raw = reader.ReadUInt16();
                data.Switch_Axe_raw = reader.ReadUInt16();
                data.Charge_Blade_raw = reader.ReadUInt16();
                data.Insect_Glaive_raw = reader.ReadUInt16();
                data.Bow_raw = reader.ReadUInt16();
                data.HBG_raw = reader.ReadUInt16();
                data.LBG_raw = reader.ReadUInt16();
                data.Unk_1_raw = reader.ReadByte();
                data.Unk_2_raw = reader.ReadByte();
                data.Unk_3_raw = reader.ReadByte();
                data.Unk_4_raw = reader.ReadByte();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Id_raw);
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
                writer.Write(Unk_1_raw);
                writer.Write(Unk_2_raw);
                writer.Write(Unk_3_raw);
                writer.Write(Unk_4_raw);
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
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
    public partial class AnimalSize {
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

            protected uint Endemic_Id_raw;
            public const string Endemic_Id_displayName = "Endemic Id";
            public const int Endemic_Id_sortIndex = 50;
            [SortOrder(Endemic_Id_sortIndex)]
            [DisplayName(Endemic_Id_displayName)]
            public virtual uint Endemic_Id {
                get => Endemic_Id_raw;
                set {
                    if (Endemic_Id_raw == value) return;
                    Endemic_Id_raw = value;
                    OnPropertyChanged(nameof(Endemic_Id));
                }
            }

            protected uint Endemic_Sub_Species_Id_raw;
            public const string Endemic_Sub_Species_Id_displayName = "Endemic Sub Species Id";
            public const int Endemic_Sub_Species_Id_sortIndex = 100;
            [SortOrder(Endemic_Sub_Species_Id_sortIndex)]
            [DisplayName(Endemic_Sub_Species_Id_displayName)]
            public virtual uint Endemic_Sub_Species_Id {
                get => Endemic_Sub_Species_Id_raw;
                set {
                    if (Endemic_Sub_Species_Id_raw == value) return;
                    Endemic_Sub_Species_Id_raw = value;
                    OnPropertyChanged(nameof(Endemic_Sub_Species_Id));
                }
            }

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
                    OnPropertyChanged(nameof(Unk3));
                }
            }

            protected float Unk4_raw;
            public const string Unk4_displayName = "Unk4";
            public const int Unk4_sortIndex = 200;
            [SortOrder(Unk4_sortIndex)]
            [DisplayName(Unk4_displayName)]
            public virtual float Unk4 {
                get => Unk4_raw;
                set {
                    if (Unk4_raw == value) return;
                    Unk4_raw = value;
                    OnPropertyChanged(nameof(Unk4));
                }
            }

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
                    OnPropertyChanged(nameof(Unk5));
                }
            }

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
                    OnPropertyChanged(nameof(Unk6));
                }
            }

            protected float Animal_Base_Size_raw;
            public const string Animal_Base_Size_displayName = "Animal Base Size";
            public const int Animal_Base_Size_sortIndex = 350;
            [SortOrder(Animal_Base_Size_sortIndex)]
            [DisplayName(Animal_Base_Size_displayName)]
            public virtual float Animal_Base_Size {
                get => Animal_Base_Size_raw;
                set {
                    if (Animal_Base_Size_raw == value) return;
                    Animal_Base_Size_raw = value;
                    OnPropertyChanged(nameof(Animal_Base_Size));
                }
            }

            protected float Model_Size_Multi_raw;
            public const string Model_Size_Multi_displayName = "Model Size Multi";
            public const int Model_Size_Multi_sortIndex = 400;
            [SortOrder(Model_Size_Multi_sortIndex)]
            [DisplayName(Model_Size_Multi_displayName)]
            public virtual float Model_Size_Multi {
                get => Model_Size_Multi_raw;
                set {
                    if (Model_Size_Multi_raw == value) return;
                    Model_Size_Multi_raw = value;
                    OnPropertyChanged(nameof(Model_Size_Multi));
                }
            }

            protected float Minimum_Size_Limit_raw;
            public const string Minimum_Size_Limit_displayName = "Minimum Size Limit";
            public const int Minimum_Size_Limit_sortIndex = 450;
            [SortOrder(Minimum_Size_Limit_sortIndex)]
            [DisplayName(Minimum_Size_Limit_displayName)]
            public virtual float Minimum_Size_Limit {
                get => Minimum_Size_Limit_raw;
                set {
                    if (Minimum_Size_Limit_raw == value) return;
                    Minimum_Size_Limit_raw = value;
                    OnPropertyChanged(nameof(Minimum_Size_Limit));
                }
            }

            protected float Maximum_Size_Limit_raw;
            public const string Maximum_Size_Limit_displayName = "Maximum Size Limit";
            public const int Maximum_Size_Limit_sortIndex = 500;
            [SortOrder(Maximum_Size_Limit_sortIndex)]
            [DisplayName(Maximum_Size_Limit_displayName)]
            public virtual float Maximum_Size_Limit {
                get => Maximum_Size_Limit_raw;
                set {
                    if (Maximum_Size_Limit_raw == value) return;
                    Maximum_Size_Limit_raw = value;
                    OnPropertyChanged(nameof(Maximum_Size_Limit));
                }
            }

            protected uint Unk11_raw;
            public const string Unk11_displayName = "Unk11";
            public const int Unk11_sortIndex = 550;
            [SortOrder(Unk11_sortIndex)]
            [DisplayName(Unk11_displayName)]
            public virtual uint Unk11 {
                get => Unk11_raw;
                set {
                    if (Unk11_raw == value) return;
                    Unk11_raw = value;
                    OnPropertyChanged(nameof(Unk11));
                }
            }

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
                    OnPropertyChanged(nameof(Unk12));
                }
            }

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
                    OnPropertyChanged(nameof(Unk13));
                }
            }

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
                    OnPropertyChanged(nameof(Unk14));
                }
            }

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
                    OnPropertyChanged(nameof(Unk15));
                }
            }

            protected uint Unk16_raw;
            public const string Unk16_displayName = "Unk16";
            public const int Unk16_sortIndex = 800;
            [SortOrder(Unk16_sortIndex)]
            [DisplayName(Unk16_displayName)]
            public virtual uint Unk16 {
                get => Unk16_raw;
                set {
                    if (Unk16_raw == value) return;
                    Unk16_raw = value;
                    OnPropertyChanged(nameof(Unk16));
                }
            }

            protected float Small_Gold_Crown_Limit_raw;
            public const string Small_Gold_Crown_Limit_displayName = "Small Gold Crown Limit";
            public const int Small_Gold_Crown_Limit_sortIndex = 850;
            [SortOrder(Small_Gold_Crown_Limit_sortIndex)]
            [DisplayName(Small_Gold_Crown_Limit_displayName)]
            public virtual float Small_Gold_Crown_Limit {
                get => Small_Gold_Crown_Limit_raw;
                set {
                    if (Small_Gold_Crown_Limit_raw == value) return;
                    Small_Gold_Crown_Limit_raw = value;
                    OnPropertyChanged(nameof(Small_Gold_Crown_Limit));
                }
            }

            protected float Big_Gold_Crown_Limit_raw;
            public const string Big_Gold_Crown_Limit_displayName = "Big Gold Crown Limit";
            public const int Big_Gold_Crown_Limit_sortIndex = 900;
            [SortOrder(Big_Gold_Crown_Limit_sortIndex)]
            [DisplayName(Big_Gold_Crown_Limit_displayName)]
            public virtual float Big_Gold_Crown_Limit {
                get => Big_Gold_Crown_Limit_raw;
                set {
                    if (Big_Gold_Crown_Limit_raw == value) return;
                    Big_Gold_Crown_Limit_raw = value;
                    OnPropertyChanged(nameof(Big_Gold_Crown_Limit));
                }
            }

            public const int lastSortIndex = 950;

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
                data.Endemic_Id_raw = reader.ReadUInt32();
                data.Endemic_Sub_Species_Id_raw = reader.ReadUInt32();
                data.Unk3_raw = reader.ReadSingle();
                data.Unk4_raw = reader.ReadSingle();
                data.Unk5_raw = reader.ReadSingle();
                data.Unk6_raw = reader.ReadSingle();
                data.Animal_Base_Size_raw = reader.ReadSingle();
                data.Model_Size_Multi_raw = reader.ReadSingle();
                data.Minimum_Size_Limit_raw = reader.ReadSingle();
                data.Maximum_Size_Limit_raw = reader.ReadSingle();
                data.Unk11_raw = reader.ReadUInt32();
                data.Unk12_raw = reader.ReadSingle();
                data.Unk13_raw = reader.ReadSingle();
                data.Unk14_raw = reader.ReadSingle();
                data.Unk15_raw = reader.ReadSingle();
                data.Unk16_raw = reader.ReadUInt32();
                data.Small_Gold_Crown_Limit_raw = reader.ReadSingle();
                data.Big_Gold_Crown_Limit_raw = reader.ReadSingle();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Endemic_Id_raw);
                writer.Write(Endemic_Sub_Species_Id_raw);
                writer.Write(Unk3_raw);
                writer.Write(Unk4_raw);
                writer.Write(Unk5_raw);
                writer.Write(Unk6_raw);
                writer.Write(Animal_Base_Size_raw);
                writer.Write(Model_Size_Multi_raw);
                writer.Write(Minimum_Size_Limit_raw);
                writer.Write(Maximum_Size_Limit_raw);
                writer.Write(Unk11_raw);
                writer.Write(Unk12_raw);
                writer.Write(Unk13_raw);
                writer.Write(Unk14_raw);
                writer.Write(Unk15_raw);
                writer.Write(Unk16_raw);
                writer.Write(Small_Gold_Crown_Limit_raw);
                writer.Write(Big_Gold_Crown_Limit_raw);
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
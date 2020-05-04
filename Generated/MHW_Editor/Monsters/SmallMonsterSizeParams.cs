using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Monsters {
    public partial class SmallMonsterSizeParams {
        public override string EncryptionKey => null;

        public partial class Small_Monster_Size_Params : MhwStructItem {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Small Monster Size Params";

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

            protected uint Magic_3_raw;
            public const string Magic_3_displayName = "Magic 3";
            public const int Magic_3_sortIndex = 150;
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

            protected uint Number_of_Size_Settings_raw;
            public const string Number_of_Size_Settings_displayName = "Number of Size Settings";
            public const int Number_of_Size_Settings_sortIndex = 200;
            [SortOrder(Number_of_Size_Settings_sortIndex)]
            [DisplayName(Number_of_Size_Settings_displayName)]
            [IsReadOnly]
            public virtual uint Number_of_Size_Settings {
                get => Number_of_Size_Settings_raw;
                set {
                    if (Number_of_Size_Settings_raw == value) return;
                    Number_of_Size_Settings_raw = value;
                    OnPropertyChanged(nameof(Number_of_Size_Settings));
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

            public static MhwStructItem LoadData(BinaryReader reader, ulong i) {
                var data = new Small_Monster_Size_Params();
                data.Index = i;
                data.Magic_1_raw = reader.ReadUInt32();
                data.Magic_2_raw = reader.ReadUInt32();
                data.Magic_3_raw = reader.ReadUInt32();
                data.Number_of_Size_Settings_raw = reader.ReadUInt32();
                return data;
            }

            public override void WriteData(BinaryWriter writer) {
                writer.Write(Magic_1_raw);
                writer.Write(Magic_2_raw);
                writer.Write(Magic_3_raw);
                writer.Write(Number_of_Size_Settings_raw);
            }
        }

        public partial class Size_Settings : MhwStructItem {
            public const ulong FixedSizeCount = 0;
            public const string GridName = "Size Settings";
            public const bool IsAddingAllowed = true;

            [SortOrder(-1)]
            [IsReadOnly]
            [DisplayName("X")]
            public string Delete => "X";

            protected uint Header_raw;
            public const string Header_displayName = "Header";
            public const int Header_sortIndex = 50;
            [SortOrder(Header_sortIndex)]
            [DisplayName(Header_displayName)]
            public virtual uint Header {
                get => Header_raw;
                set {
                    if (Header_raw == value) return;
                    Header_raw = value;
                    OnPropertyChanged(nameof(Header));
                }
            }

            protected float Min_Size_raw;
            public const string Min_Size_displayName = "Min Size";
            public const int Min_Size_sortIndex = 100;
            [SortOrder(Min_Size_sortIndex)]
            [DisplayName(Min_Size_displayName)]
            public virtual float Min_Size {
                get => Min_Size_raw;
                set {
                    if (Min_Size_raw == value) return;
                    Min_Size_raw = value;
                    OnPropertyChanged(nameof(Min_Size));
                }
            }

            protected float Max_Size_raw;
            public const string Max_Size_displayName = "Max Size";
            public const int Max_Size_sortIndex = 150;
            [SortOrder(Max_Size_sortIndex)]
            [DisplayName(Max_Size_displayName)]
            public virtual float Max_Size {
                get => Max_Size_raw;
                set {
                    if (Max_Size_raw == value) return;
                    Max_Size_raw = value;
                    OnPropertyChanged(nameof(Max_Size));
                }
            }

            protected float Unk_f32__raw;
            public const string Unk_f32__displayName = "Unk (f32)";
            public const int Unk_f32__sortIndex = 200;
            [SortOrder(Unk_f32__sortIndex)]
            [DisplayName(Unk_f32__displayName)]
            public virtual float Unk_f32_ {
                get => Unk_f32__raw;
                set {
                    if (Unk_f32__raw == value) return;
                    Unk_f32__raw = value;
                    OnPropertyChanged(nameof(Unk_f32_));
                }
            }

            protected uint Monster_Id_raw;
            public const string Monster_Id_displayName = "Monster Id";
            public const int Monster_Id_sortIndex = 250;
            [SortOrder(Monster_Id_sortIndex)]
            [DisplayName(Monster_Id_displayName)]
            [DataSource(DataSourceType.Monsters)]
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

            public static ObservableCollection<object> LoadData(BinaryReader reader, ObservableCollection<object> lastStruct) {
                var list = new ObservableCollection<object>();
                var countTarget = (Small_Monster_Size_Params) lastStruct.Last();
                var count = (ulong) countTarget.Number_of_Size_Settings;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static MhwStructItem LoadData(BinaryReader reader, ulong i) {
                var data = new Size_Settings();
                data.Index = i;
                data.Header_raw = reader.ReadUInt32();
                data.Min_Size_raw = reader.ReadSingle();
                data.Max_Size_raw = reader.ReadSingle();
                data.Unk_f32__raw = reader.ReadSingle();
                data.Monster_Id_raw = reader.ReadUInt32();
                return data;
            }

            public override void WriteData(BinaryWriter writer) {
                writer.Write(Header_raw);
                writer.Write(Min_Size_raw);
                writer.Write(Max_Size_raw);
                writer.Write(Unk_f32__raw);
                writer.Write(Monster_Id_raw);
            }
        }

        public override void LoadFile(string targetFile) {
            using var reader = new BinaryReader(OpenFile(targetFile, EncryptionKey));
            data = new LinkedList<MhwStructDataContainer>();
            var Small_Monster_Size_Params_ = new MhwStructDataContainer(Small_Monster_Size_Params.LoadData(reader, null), typeof(Small_Monster_Size_Params));
            data.AddLast(Small_Monster_Size_Params_);
            var Size_Settings_ = new MhwStructDataContainer(Size_Settings.LoadData(reader, Small_Monster_Size_Params_.list), typeof(Size_Settings));
            Size_Settings_.SetCountTargetToUpdate(Small_Monster_Size_Params_, -1, "Number_of_Size_Settings");
            data.AddLast(Size_Settings_);
        }
    }
}
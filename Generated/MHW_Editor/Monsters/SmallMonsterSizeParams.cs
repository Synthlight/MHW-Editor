using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
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

            public static Small_Monster_Size_Params LoadData(BinaryReader reader) {
                var data = new Small_Monster_Size_Params();
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
            public virtual uint Monster_Id {
                get => Monster_Id_raw;
                set {
                    if (Monster_Id_raw == value) return;
                    Monster_Id_raw = value;
                    OnPropertyChanged(nameof(Monster_Id));
                }
            }

            public static Size_Settings LoadData(BinaryReader reader) {
                var data = new Size_Settings();
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
            data = new List<MhwStructDataContainer>();
            dataByType = new Dictionary<Type, MhwStructDataContainer>();

            var Small_Monster_Size_Params_list = new ObservableCollection<object>();
            for (ulong i = 0; i < GetEntryCount(typeof(Small_Monster_Size_Params)); i++) {
                var item = Small_Monster_Size_Params.LoadData(reader);
                item.Index = i;
                Small_Monster_Size_Params_list.Add(item);
            }
            var Small_Monster_Size_Params_container = new MhwStructDataContainer(Small_Monster_Size_Params_list, typeof(Small_Monster_Size_Params));
            data.Add(Small_Monster_Size_Params_container);
            dataByType[typeof(Small_Monster_Size_Params)] = Small_Monster_Size_Params_container;

            var Size_Settings_list = new ObservableCollection<object>();
            for (ulong i = 0; i < GetEntryCount(typeof(Size_Settings)); i++) {
                var item = Size_Settings.LoadData(reader);
                item.Index = i;
                Size_Settings_list.Add(item);
            }
            var Size_Settings_container = new MhwStructDataContainer(Size_Settings_list, typeof(Size_Settings));
            data.Add(Size_Settings_container);
            dataByType[typeof(Size_Settings)] = Size_Settings_container;
        }
    }
}
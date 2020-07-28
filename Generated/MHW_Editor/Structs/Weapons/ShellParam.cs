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
    public partial class ShellParam {
        public override string EncryptionKey => "FZoS8QLyOyeFmkdrz73P9Fh2N4NcTwy3QQPjc1YRII5KWovK6yFuU8SL";

        public partial class Shlp : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Shlp";

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

            protected char[] SLP_raw;
            public const string SLP_displayName = "SLP";
            public const int SLP_sortIndex = 100;
            [SortOrder(SLP_sortIndex)]
            [DisplayName(SLP_displayName)]
            [IsReadOnly]
            public virtual string SLP {
                get => (string) new string(SLP_raw);
                set {
                    if ((string) new string(SLP_raw) == value) return;
                    SLP_raw = (char[]) value.ToCharArray(0, 3);
                    ChangedItems.Add(nameof(SLP));
                    OnPropertyChanged(nameof(SLP));
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
                    ChangedItems.Add(nameof(Magic_2));
                    OnPropertyChanged(nameof(Magic_2));
                }
            }

            public const int lastSortIndex = 200;

            public static ObservableMhwStructCollection<Shlp> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Shlp>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Shlp LoadData(BinaryReader reader, ulong i) {
                var data = new Shlp();
                data.Index = i;
                data.Magic_1_raw = reader.ReadUInt32();
                data.SLP_raw = reader.ReadChars(4);
                data.Magic_2_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Magic_1_raw);
                writer.Write(SLP_raw);
                writer.Write(Magic_2_raw);
            }
        }

        public partial class Assets : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 25;
            public const string GridName = "Assets";

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
                    ChangedItems.Add(nameof(Header));
                    OnPropertyChanged(nameof(Header));
                }
            }

            protected string Path_raw;
            public const string Path_displayName = "Path";
            public const int Path_sortIndex = 100;
            [SortOrder(Path_sortIndex)]
            [DisplayName(Path_displayName)]
            public virtual string Path {
                get => Path_raw;
                set {
                    if (Path_raw == value) return;
                    Path_raw = value;
                    ChangedItems.Add(nameof(Path));
                    OnPropertyChanged(nameof(Path));
                }
            }

            public const int lastSortIndex = 150;

            public static ObservableMhwStructCollection<Assets> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Assets>();
                var count = 25UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Assets LoadData(BinaryReader reader, ulong i) {
                var data = new Assets();
                data.Index = i;
                data.Header_raw = reader.ReadUInt32();
                if (data.Header_raw != 0) data.Path_raw = reader.ReadNullTermString();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Header_raw);
                if (Header_raw != 0) writer.Write(Path_raw.ToNullTermCharArray());
            }
        }

        public partial class Shlp_1_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Shlp (1)";

            protected uint Projectile_Body_EPV_Index_raw;
            public const string Projectile_Body_EPV_Index_displayName = "Projectile Body: EPV Index";
            public const int Projectile_Body_EPV_Index_sortIndex = 50;
            [SortOrder(Projectile_Body_EPV_Index_sortIndex)]
            [DisplayName(Projectile_Body_EPV_Index_displayName)]
            public virtual uint Projectile_Body_EPV_Index {
                get => Projectile_Body_EPV_Index_raw;
                set {
                    if (Projectile_Body_EPV_Index_raw == value) return;
                    Projectile_Body_EPV_Index_raw = value;
                    ChangedItems.Add(nameof(Projectile_Body_EPV_Index));
                    OnPropertyChanged(nameof(Projectile_Body_EPV_Index));
                }
            }

            [DisplayName("Offset")]
            public long Projectile_Body_EPV_Index_offset { get; private set; }

            protected uint Projectile_Body_EPV_Element__raw;
            public const string Projectile_Body_EPV_Element__displayName = "Projectile Body: EPV Element #";
            public const int Projectile_Body_EPV_Element__sortIndex = 100;
            [SortOrder(Projectile_Body_EPV_Element__sortIndex)]
            [DisplayName(Projectile_Body_EPV_Element__displayName)]
            public virtual uint Projectile_Body_EPV_Element_ {
                get => Projectile_Body_EPV_Element__raw;
                set {
                    if (Projectile_Body_EPV_Element__raw == value) return;
                    Projectile_Body_EPV_Element__raw = value;
                    ChangedItems.Add(nameof(Projectile_Body_EPV_Element_));
                    OnPropertyChanged(nameof(Projectile_Body_EPV_Element_));
                }
            }

            [DisplayName("Offset")]
            public long Projectile_Body_EPV_Element__offset { get; private set; }

            protected uint Muzzle_EPV_Index_raw;
            public const string Muzzle_EPV_Index_displayName = "Muzzle: EPV Index";
            public const int Muzzle_EPV_Index_sortIndex = 150;
            [SortOrder(Muzzle_EPV_Index_sortIndex)]
            [DisplayName(Muzzle_EPV_Index_displayName)]
            public virtual uint Muzzle_EPV_Index {
                get => Muzzle_EPV_Index_raw;
                set {
                    if (Muzzle_EPV_Index_raw == value) return;
                    Muzzle_EPV_Index_raw = value;
                    ChangedItems.Add(nameof(Muzzle_EPV_Index));
                    OnPropertyChanged(nameof(Muzzle_EPV_Index));
                }
            }

            [DisplayName("Offset")]
            public long Muzzle_EPV_Index_offset { get; private set; }

            protected uint Muzzle_EPV_Element__raw;
            public const string Muzzle_EPV_Element__displayName = "Muzzle: EPV Element #";
            public const int Muzzle_EPV_Element__sortIndex = 200;
            [SortOrder(Muzzle_EPV_Element__sortIndex)]
            [DisplayName(Muzzle_EPV_Element__displayName)]
            public virtual uint Muzzle_EPV_Element_ {
                get => Muzzle_EPV_Element__raw;
                set {
                    if (Muzzle_EPV_Element__raw == value) return;
                    Muzzle_EPV_Element__raw = value;
                    ChangedItems.Add(nameof(Muzzle_EPV_Element_));
                    OnPropertyChanged(nameof(Muzzle_EPV_Element_));
                }
            }

            [DisplayName("Offset")]
            public long Muzzle_EPV_Element__offset { get; private set; }

            protected byte Muzzle_Joint_1_raw;
            public const string Muzzle_Joint_1_displayName = "Muzzle: Joint 1";
            public const int Muzzle_Joint_1_sortIndex = 250;
            [SortOrder(Muzzle_Joint_1_sortIndex)]
            [DisplayName(Muzzle_Joint_1_displayName)]
            public virtual byte Muzzle_Joint_1 {
                get => Muzzle_Joint_1_raw;
                set {
                    if (Muzzle_Joint_1_raw == value) return;
                    Muzzle_Joint_1_raw = value;
                    ChangedItems.Add(nameof(Muzzle_Joint_1));
                    OnPropertyChanged(nameof(Muzzle_Joint_1));
                }
            }

            [DisplayName("Offset")]
            public long Muzzle_Joint_1_offset { get; private set; }

            protected byte Muzzle_Joint_2_raw;
            public const string Muzzle_Joint_2_displayName = "Muzzle: Joint 2";
            public const int Muzzle_Joint_2_sortIndex = 300;
            [SortOrder(Muzzle_Joint_2_sortIndex)]
            [DisplayName(Muzzle_Joint_2_displayName)]
            public virtual byte Muzzle_Joint_2 {
                get => Muzzle_Joint_2_raw;
                set {
                    if (Muzzle_Joint_2_raw == value) return;
                    Muzzle_Joint_2_raw = value;
                    ChangedItems.Add(nameof(Muzzle_Joint_2));
                    OnPropertyChanged(nameof(Muzzle_Joint_2));
                }
            }

            [DisplayName("Offset")]
            public long Muzzle_Joint_2_offset { get; private set; }

            protected byte Muzzle_Joint_3_raw;
            public const string Muzzle_Joint_3_displayName = "Muzzle: Joint 3";
            public const int Muzzle_Joint_3_sortIndex = 350;
            [SortOrder(Muzzle_Joint_3_sortIndex)]
            [DisplayName(Muzzle_Joint_3_displayName)]
            public virtual byte Muzzle_Joint_3 {
                get => Muzzle_Joint_3_raw;
                set {
                    if (Muzzle_Joint_3_raw == value) return;
                    Muzzle_Joint_3_raw = value;
                    ChangedItems.Add(nameof(Muzzle_Joint_3));
                    OnPropertyChanged(nameof(Muzzle_Joint_3));
                }
            }

            [DisplayName("Offset")]
            public long Muzzle_Joint_3_offset { get; private set; }

            protected byte Muzzle_Joint_4_raw;
            public const string Muzzle_Joint_4_displayName = "Muzzle: Joint 4";
            public const int Muzzle_Joint_4_sortIndex = 400;
            [SortOrder(Muzzle_Joint_4_sortIndex)]
            [DisplayName(Muzzle_Joint_4_displayName)]
            public virtual byte Muzzle_Joint_4 {
                get => Muzzle_Joint_4_raw;
                set {
                    if (Muzzle_Joint_4_raw == value) return;
                    Muzzle_Joint_4_raw = value;
                    ChangedItems.Add(nameof(Muzzle_Joint_4));
                    OnPropertyChanged(nameof(Muzzle_Joint_4));
                }
            }

            [DisplayName("Offset")]
            public long Muzzle_Joint_4_offset { get; private set; }

            protected uint Obj_Collision_Header_raw;
            public const string Obj_Collision_Header_displayName = "Obj Collision Header";
            public const int Obj_Collision_Header_sortIndex = 450;
            [SortOrder(Obj_Collision_Header_sortIndex)]
            [DisplayName(Obj_Collision_Header_displayName)]
            public virtual uint Obj_Collision_Header {
                get => Obj_Collision_Header_raw;
                set {
                    if (Obj_Collision_Header_raw == value) return;
                    Obj_Collision_Header_raw = value;
                    ChangedItems.Add(nameof(Obj_Collision_Header));
                    OnPropertyChanged(nameof(Obj_Collision_Header));
                }
            }

            [DisplayName("Offset")]
            public long Obj_Collision_Header_offset { get; private set; }

            protected string Obj_Collision_raw;
            public const string Obj_Collision_displayName = "Obj Collision";
            public const int Obj_Collision_sortIndex = 500;
            [SortOrder(Obj_Collision_sortIndex)]
            [DisplayName(Obj_Collision_displayName)]
            public virtual string Obj_Collision {
                get => Obj_Collision_raw;
                set {
                    if (Obj_Collision_raw == value) return;
                    Obj_Collision_raw = value;
                    ChangedItems.Add(nameof(Obj_Collision));
                    OnPropertyChanged(nameof(Obj_Collision));
                }
            }

            [DisplayName("Offset")]
            public long Obj_Collision_offset { get; private set; }

            protected uint Obj_Collision_Index_raw;
            public const string Obj_Collision_Index_displayName = "Obj Collision Index";
            public const int Obj_Collision_Index_sortIndex = 550;
            [SortOrder(Obj_Collision_Index_sortIndex)]
            [DisplayName(Obj_Collision_Index_displayName)]
            public virtual uint Obj_Collision_Index {
                get => Obj_Collision_Index_raw;
                set {
                    if (Obj_Collision_Index_raw == value) return;
                    Obj_Collision_Index_raw = value;
                    ChangedItems.Add(nameof(Obj_Collision_Index));
                    OnPropertyChanged(nameof(Obj_Collision_Index));
                }
            }

            [DisplayName("Offset")]
            public long Obj_Collision_Index_offset { get; private set; }

            protected uint Timeline_List_Header_raw;
            public const string Timeline_List_Header_displayName = "Timeline List Header";
            public const int Timeline_List_Header_sortIndex = 600;
            [SortOrder(Timeline_List_Header_sortIndex)]
            [DisplayName(Timeline_List_Header_displayName)]
            public virtual uint Timeline_List_Header {
                get => Timeline_List_Header_raw;
                set {
                    if (Timeline_List_Header_raw == value) return;
                    Timeline_List_Header_raw = value;
                    ChangedItems.Add(nameof(Timeline_List_Header));
                    OnPropertyChanged(nameof(Timeline_List_Header));
                }
            }

            [DisplayName("Offset")]
            public long Timeline_List_Header_offset { get; private set; }

            protected string Timeline_List_raw;
            public const string Timeline_List_displayName = "Timeline List";
            public const int Timeline_List_sortIndex = 650;
            [SortOrder(Timeline_List_sortIndex)]
            [DisplayName(Timeline_List_displayName)]
            public virtual string Timeline_List {
                get => Timeline_List_raw;
                set {
                    if (Timeline_List_raw == value) return;
                    Timeline_List_raw = value;
                    ChangedItems.Add(nameof(Timeline_List));
                    OnPropertyChanged(nameof(Timeline_List));
                }
            }

            [DisplayName("Offset")]
            public long Timeline_List_offset { get; private set; }

            protected uint Unk_2_raw;
            public const string Unk_2_displayName = "Unk 2";
            public const int Unk_2_sortIndex = 700;
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

            [DisplayName("Offset")]
            public long Unk_2_offset { get; private set; }

            protected uint Unk_3_raw;
            public const string Unk_3_displayName = "Unk 3";
            public const int Unk_3_sortIndex = 750;
            [SortOrder(Unk_3_sortIndex)]
            [DisplayName(Unk_3_displayName)]
            public virtual uint Unk_3 {
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

            protected uint Unk_4_raw;
            public const string Unk_4_displayName = "Unk 4";
            public const int Unk_4_sortIndex = 800;
            [SortOrder(Unk_4_sortIndex)]
            [DisplayName(Unk_4_displayName)]
            public virtual uint Unk_4 {
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

            protected uint Unk_5_raw;
            public const string Unk_5_displayName = "Unk 5";
            public const int Unk_5_sortIndex = 850;
            [SortOrder(Unk_5_sortIndex)]
            [DisplayName(Unk_5_displayName)]
            public virtual uint Unk_5 {
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
            public const int Unk_6_sortIndex = 900;
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

            public const int lastSortIndex = 950;

            public static ObservableMhwStructCollection<Shlp_1_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Shlp_1_>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Shlp_1_ LoadData(BinaryReader reader, ulong i) {
                var data = new Shlp_1_();
                data.Index = i;
                data.Projectile_Body_EPV_Index_offset = reader.BaseStream.Position;
                data.Projectile_Body_EPV_Index_raw = reader.ReadUInt32();
                data.Projectile_Body_EPV_Element__offset = reader.BaseStream.Position;
                data.Projectile_Body_EPV_Element__raw = reader.ReadUInt32();
                data.Muzzle_EPV_Index_offset = reader.BaseStream.Position;
                data.Muzzle_EPV_Index_raw = reader.ReadUInt32();
                data.Muzzle_EPV_Element__offset = reader.BaseStream.Position;
                data.Muzzle_EPV_Element__raw = reader.ReadUInt32();
                data.Muzzle_Joint_1_offset = reader.BaseStream.Position;
                data.Muzzle_Joint_1_raw = reader.ReadByte();
                data.Muzzle_Joint_2_offset = reader.BaseStream.Position;
                data.Muzzle_Joint_2_raw = reader.ReadByte();
                data.Muzzle_Joint_3_offset = reader.BaseStream.Position;
                data.Muzzle_Joint_3_raw = reader.ReadByte();
                data.Muzzle_Joint_4_offset = reader.BaseStream.Position;
                data.Muzzle_Joint_4_raw = reader.ReadByte();
                data.Obj_Collision_Header_offset = reader.BaseStream.Position;
                data.Obj_Collision_Header_raw = reader.ReadUInt32();
                if (data.Obj_Collision_Header_raw != 0) data.Obj_Collision_offset = reader.BaseStream.Position;
                if (data.Obj_Collision_Header_raw != 0) data.Obj_Collision_raw = reader.ReadNullTermString();
                data.Obj_Collision_Index_offset = reader.BaseStream.Position;
                data.Obj_Collision_Index_raw = reader.ReadUInt32();
                data.Timeline_List_Header_offset = reader.BaseStream.Position;
                data.Timeline_List_Header_raw = reader.ReadUInt32();
                if (data.Timeline_List_Header_raw != 0) data.Timeline_List_offset = reader.BaseStream.Position;
                if (data.Timeline_List_Header_raw != 0) data.Timeline_List_raw = reader.ReadNullTermString();
                data.Unk_2_offset = reader.BaseStream.Position;
                data.Unk_2_raw = reader.ReadUInt32();
                data.Unk_3_offset = reader.BaseStream.Position;
                data.Unk_3_raw = reader.ReadUInt32();
                data.Unk_4_offset = reader.BaseStream.Position;
                data.Unk_4_raw = reader.ReadUInt32();
                data.Unk_5_offset = reader.BaseStream.Position;
                data.Unk_5_raw = reader.ReadUInt32();
                data.Unk_6_offset = reader.BaseStream.Position;
                data.Unk_6_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Projectile_Body_EPV_Index_raw);
                writer.Write(Projectile_Body_EPV_Element__raw);
                writer.Write(Muzzle_EPV_Index_raw);
                writer.Write(Muzzle_EPV_Element__raw);
                writer.Write(Muzzle_Joint_1_raw);
                writer.Write(Muzzle_Joint_2_raw);
                writer.Write(Muzzle_Joint_3_raw);
                writer.Write(Muzzle_Joint_4_raw);
                writer.Write(Obj_Collision_Header_raw);
                if (Obj_Collision_Header_raw != 0) writer.Write(Obj_Collision_raw.ToNullTermCharArray());
                writer.Write(Obj_Collision_Index_raw);
                writer.Write(Timeline_List_Header_raw);
                if (Timeline_List_Header_raw != 0) writer.Write(Timeline_List_raw.ToNullTermCharArray());
                writer.Write(Unk_2_raw);
                writer.Write(Unk_3_raw);
                writer.Write(Unk_4_raw);
                writer.Write(Unk_5_raw);
                writer.Write(Unk_6_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Projectile Body: EPV Index", "Projectile_Body_EPV_Index", "Projectile_Body_EPV_Index_offset"),
                    new MultiStructItemCustomView(this, "Projectile Body: EPV Element #", "Projectile_Body_EPV_Element_", "Projectile_Body_EPV_Element__offset"),
                    new MultiStructItemCustomView(this, "Muzzle: EPV Index", "Muzzle_EPV_Index", "Muzzle_EPV_Index_offset"),
                    new MultiStructItemCustomView(this, "Muzzle: EPV Element #", "Muzzle_EPV_Element_", "Muzzle_EPV_Element__offset"),
                    new MultiStructItemCustomView(this, "Muzzle: Joint 1", "Muzzle_Joint_1", "Muzzle_Joint_1_offset"),
                    new MultiStructItemCustomView(this, "Muzzle: Joint 2", "Muzzle_Joint_2", "Muzzle_Joint_2_offset"),
                    new MultiStructItemCustomView(this, "Muzzle: Joint 3", "Muzzle_Joint_3", "Muzzle_Joint_3_offset"),
                    new MultiStructItemCustomView(this, "Muzzle: Joint 4", "Muzzle_Joint_4", "Muzzle_Joint_4_offset"),
                    new MultiStructItemCustomView(this, "Obj Collision Header", "Obj_Collision_Header", "Obj_Collision_Header_offset"),
                    new MultiStructItemCustomView(this, "Obj Collision", "Obj_Collision", "Obj_Collision_offset"),
                    new MultiStructItemCustomView(this, "Obj Collision Index", "Obj_Collision_Index", "Obj_Collision_Index_offset"),
                    new MultiStructItemCustomView(this, "Timeline List Header", "Timeline_List_Header", "Timeline_List_Header_offset"),
                    new MultiStructItemCustomView(this, "Timeline List", "Timeline_List", "Timeline_List_offset"),
                    new MultiStructItemCustomView(this, "Unk 2", "Unk_2", "Unk_2_offset"),
                    new MultiStructItemCustomView(this, "Unk 3", "Unk_3", "Unk_3_offset"),
                    new MultiStructItemCustomView(this, "Unk 4", "Unk_4", "Unk_4_offset"),
                    new MultiStructItemCustomView(this, "Unk 5", "Unk_5", "Unk_5_offset"),
                    new MultiStructItemCustomView(this, "Unk 6", "Unk_6", "Unk_6_offset"),
                };
            }
        }

        public partial class Number_of_Linked_Shell_Params_Holder : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Number of Linked Shell Params Holder";
            public const bool IsHidden = true;

            protected uint Number_of_Linked_Shell_Params_raw;
            public const string Number_of_Linked_Shell_Params_displayName = "Number of Linked Shell Params";
            public const int Number_of_Linked_Shell_Params_sortIndex = 50;
            [SortOrder(Number_of_Linked_Shell_Params_sortIndex)]
            [DisplayName(Number_of_Linked_Shell_Params_displayName)]
            [IsReadOnly]
            public virtual uint Number_of_Linked_Shell_Params {
                get => Number_of_Linked_Shell_Params_raw;
                set {
                    if (Number_of_Linked_Shell_Params_raw == value) return;
                    Number_of_Linked_Shell_Params_raw = value;
                    ChangedItems.Add(nameof(Number_of_Linked_Shell_Params));
                    OnPropertyChanged(nameof(Number_of_Linked_Shell_Params));
                }
            }

            public const int lastSortIndex = 100;

            public static ObservableMhwStructCollection<Number_of_Linked_Shell_Params_Holder> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Number_of_Linked_Shell_Params_Holder>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Number_of_Linked_Shell_Params_Holder LoadData(BinaryReader reader, ulong i) {
                var data = new Number_of_Linked_Shell_Params_Holder();
                data.Index = i;
                data.Number_of_Linked_Shell_Params_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Number_of_Linked_Shell_Params_raw);
            }
        }

        public partial class Child_Shell_Params : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 0;
            public const string GridName = "Child Shell Params";
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
                    ChangedItems.Add(nameof(Header));
                    OnPropertyChanged(nameof(Header));
                }
            }

            protected string Path_raw;
            public const string Path_displayName = "Path";
            public const int Path_sortIndex = 100;
            [SortOrder(Path_sortIndex)]
            [DisplayName(Path_displayName)]
            public virtual string Path {
                get => Path_raw;
                set {
                    if (Path_raw == value) return;
                    Path_raw = value;
                    ChangedItems.Add(nameof(Path));
                    OnPropertyChanged(nameof(Path));
                }
            }

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

            protected uint Flags_raw;
            public const string Flags_displayName = "Flags";
            public const int Flags_sortIndex = 200;
            [SortOrder(Flags_sortIndex)]
            [DisplayName(Flags_displayName)]
            public virtual uint Flags {
                get => Flags_raw;
                set {
                    if (Flags_raw == value) return;
                    Flags_raw = value;
                    ChangedItems.Add(nameof(Flags));
                    OnPropertyChanged(nameof(Flags));
                }
            }

            protected uint Unk_3_raw;
            public const string Unk_3_displayName = "Unk 3";
            public const int Unk_3_sortIndex = 250;
            [SortOrder(Unk_3_sortIndex)]
            [DisplayName(Unk_3_displayName)]
            public virtual uint Unk_3 {
                get => Unk_3_raw;
                set {
                    if (Unk_3_raw == value) return;
                    Unk_3_raw = value;
                    ChangedItems.Add(nameof(Unk_3));
                    OnPropertyChanged(nameof(Unk_3));
                }
            }

            public const int lastSortIndex = 300;

            public static ObservableMhwStructCollection<Child_Shell_Params> LoadData(BinaryReader reader, ObservableMhwStructCollection<Number_of_Linked_Shell_Params_Holder> lastStruct) {
                var list = new ObservableMhwStructCollection<Child_Shell_Params>();
                var countTarget = (Number_of_Linked_Shell_Params_Holder) lastStruct.Last();
                var count = (ulong) countTarget.Number_of_Linked_Shell_Params;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Child_Shell_Params LoadData(BinaryReader reader, ulong i) {
                var data = new Child_Shell_Params();
                data.Index = i;
                data.Header_raw = reader.ReadUInt32();
                data.Path_raw = reader.ReadNullTermString();
                data.Unk_1_raw = reader.ReadUInt32();
                data.Flags_raw = reader.ReadUInt32();
                data.Unk_3_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Header_raw);
                writer.Write(Path_raw.ToNullTermCharArray());
                writer.Write(Unk_1_raw);
                writer.Write(Flags_raw);
                writer.Write(Unk_3_raw);
            }
        }

        public partial class EPV : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "EPV";

            protected uint Ground_Hit_EPV_Index_raw;
            public const string Ground_Hit_EPV_Index_displayName = "Ground Hit: EPV Index";
            public const int Ground_Hit_EPV_Index_sortIndex = 50;
            [SortOrder(Ground_Hit_EPV_Index_sortIndex)]
            [DisplayName(Ground_Hit_EPV_Index_displayName)]
            public virtual uint Ground_Hit_EPV_Index {
                get => Ground_Hit_EPV_Index_raw;
                set {
                    if (Ground_Hit_EPV_Index_raw == value) return;
                    Ground_Hit_EPV_Index_raw = value;
                    ChangedItems.Add(nameof(Ground_Hit_EPV_Index));
                    OnPropertyChanged(nameof(Ground_Hit_EPV_Index));
                }
            }

            [DisplayName("Offset")]
            public long Ground_Hit_EPV_Index_offset { get; private set; }

            protected uint Ground_Hit_EPV_Element__raw;
            public const string Ground_Hit_EPV_Element__displayName = "Ground Hit: EPV Element #";
            public const int Ground_Hit_EPV_Element__sortIndex = 100;
            [SortOrder(Ground_Hit_EPV_Element__sortIndex)]
            [DisplayName(Ground_Hit_EPV_Element__displayName)]
            public virtual uint Ground_Hit_EPV_Element_ {
                get => Ground_Hit_EPV_Element__raw;
                set {
                    if (Ground_Hit_EPV_Element__raw == value) return;
                    Ground_Hit_EPV_Element__raw = value;
                    ChangedItems.Add(nameof(Ground_Hit_EPV_Element_));
                    OnPropertyChanged(nameof(Ground_Hit_EPV_Element_));
                }
            }

            [DisplayName("Offset")]
            public long Ground_Hit_EPV_Element__offset { get; private set; }

            protected uint Wall_Hit_EPV_Index_raw;
            public const string Wall_Hit_EPV_Index_displayName = "Wall Hit: EPV Index";
            public const int Wall_Hit_EPV_Index_sortIndex = 150;
            [SortOrder(Wall_Hit_EPV_Index_sortIndex)]
            [DisplayName(Wall_Hit_EPV_Index_displayName)]
            public virtual uint Wall_Hit_EPV_Index {
                get => Wall_Hit_EPV_Index_raw;
                set {
                    if (Wall_Hit_EPV_Index_raw == value) return;
                    Wall_Hit_EPV_Index_raw = value;
                    ChangedItems.Add(nameof(Wall_Hit_EPV_Index));
                    OnPropertyChanged(nameof(Wall_Hit_EPV_Index));
                }
            }

            [DisplayName("Offset")]
            public long Wall_Hit_EPV_Index_offset { get; private set; }

            protected uint Wall_Hit_EPV_Element__raw;
            public const string Wall_Hit_EPV_Element__displayName = "Wall Hit: EPV Element #";
            public const int Wall_Hit_EPV_Element__sortIndex = 200;
            [SortOrder(Wall_Hit_EPV_Element__sortIndex)]
            [DisplayName(Wall_Hit_EPV_Element__displayName)]
            public virtual uint Wall_Hit_EPV_Element_ {
                get => Wall_Hit_EPV_Element__raw;
                set {
                    if (Wall_Hit_EPV_Element__raw == value) return;
                    Wall_Hit_EPV_Element__raw = value;
                    ChangedItems.Add(nameof(Wall_Hit_EPV_Element_));
                    OnPropertyChanged(nameof(Wall_Hit_EPV_Element_));
                }
            }

            [DisplayName("Offset")]
            public long Wall_Hit_EPV_Element__offset { get; private set; }

            protected uint Unk_1_raw;
            public const string Unk_1_displayName = "Unk 1";
            public const int Unk_1_sortIndex = 250;
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

            [DisplayName("Offset")]
            public long Unk_1_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_2));
                    OnPropertyChanged(nameof(Unk_2));
                }
            }

            [DisplayName("Offset")]
            public long Unk_2_offset { get; private set; }

            protected uint Obj_Hit_EPV_Index_raw;
            public const string Obj_Hit_EPV_Index_displayName = "Obj Hit: EPV Index";
            public const int Obj_Hit_EPV_Index_sortIndex = 350;
            [SortOrder(Obj_Hit_EPV_Index_sortIndex)]
            [DisplayName(Obj_Hit_EPV_Index_displayName)]
            public virtual uint Obj_Hit_EPV_Index {
                get => Obj_Hit_EPV_Index_raw;
                set {
                    if (Obj_Hit_EPV_Index_raw == value) return;
                    Obj_Hit_EPV_Index_raw = value;
                    ChangedItems.Add(nameof(Obj_Hit_EPV_Index));
                    OnPropertyChanged(nameof(Obj_Hit_EPV_Index));
                }
            }

            [DisplayName("Offset")]
            public long Obj_Hit_EPV_Index_offset { get; private set; }

            protected uint Obj_Hit_EPV_Element__raw;
            public const string Obj_Hit_EPV_Element__displayName = "Obj Hit: EPV Element #";
            public const int Obj_Hit_EPV_Element__sortIndex = 400;
            [SortOrder(Obj_Hit_EPV_Element__sortIndex)]
            [DisplayName(Obj_Hit_EPV_Element__displayName)]
            public virtual uint Obj_Hit_EPV_Element_ {
                get => Obj_Hit_EPV_Element__raw;
                set {
                    if (Obj_Hit_EPV_Element__raw == value) return;
                    Obj_Hit_EPV_Element__raw = value;
                    ChangedItems.Add(nameof(Obj_Hit_EPV_Element_));
                    OnPropertyChanged(nameof(Obj_Hit_EPV_Element_));
                }
            }

            [DisplayName("Offset")]
            public long Obj_Hit_EPV_Element__offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_3));
                    OnPropertyChanged(nameof(Unk_3));
                }
            }

            [DisplayName("Offset")]
            public long Unk_3_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_4));
                    OnPropertyChanged(nameof(Unk_4));
                }
            }

            [DisplayName("Offset")]
            public long Unk_4_offset { get; private set; }

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
                    ChangedItems.Add(nameof(Unk_5));
                    OnPropertyChanged(nameof(Unk_5));
                }
            }

            [DisplayName("Offset")]
            public long Unk_5_offset { get; private set; }

            protected byte Unk_6_raw;
            public const string Unk_6_displayName = "Unk 6";
            public const int Unk_6_sortIndex = 600;
            [SortOrder(Unk_6_sortIndex)]
            [DisplayName(Unk_6_displayName)]
            public virtual byte Unk_6 {
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

            protected byte Unk_7_raw;
            public const string Unk_7_displayName = "Unk 7";
            public const int Unk_7_sortIndex = 650;
            [SortOrder(Unk_7_sortIndex)]
            [DisplayName(Unk_7_displayName)]
            public virtual byte Unk_7 {
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

            protected byte Unk_8_raw;
            public const string Unk_8_displayName = "Unk 8";
            public const int Unk_8_sortIndex = 700;
            [SortOrder(Unk_8_sortIndex)]
            [DisplayName(Unk_8_displayName)]
            public virtual byte Unk_8 {
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

            protected byte Unk_9_raw;
            public const string Unk_9_displayName = "Unk 9";
            public const int Unk_9_sortIndex = 750;
            [SortOrder(Unk_9_sortIndex)]
            [DisplayName(Unk_9_displayName)]
            public virtual byte Unk_9 {
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

            protected byte Unk_10_raw;
            public const string Unk_10_displayName = "Unk 10";
            public const int Unk_10_sortIndex = 800;
            [SortOrder(Unk_10_sortIndex)]
            [DisplayName(Unk_10_displayName)]
            public virtual byte Unk_10 {
                get => Unk_10_raw;
                set {
                    if (Unk_10_raw == value) return;
                    Unk_10_raw = value;
                    ChangedItems.Add(nameof(Unk_10));
                    OnPropertyChanged(nameof(Unk_10));
                }
            }

            [DisplayName("Offset")]
            public long Unk_10_offset { get; private set; }

            protected byte Unk_11_raw;
            public const string Unk_11_displayName = "Unk 11";
            public const int Unk_11_sortIndex = 850;
            [SortOrder(Unk_11_sortIndex)]
            [DisplayName(Unk_11_displayName)]
            public virtual byte Unk_11 {
                get => Unk_11_raw;
                set {
                    if (Unk_11_raw == value) return;
                    Unk_11_raw = value;
                    ChangedItems.Add(nameof(Unk_11));
                    OnPropertyChanged(nameof(Unk_11));
                }
            }

            [DisplayName("Offset")]
            public long Unk_11_offset { get; private set; }

            protected byte Unk_12_raw;
            public const string Unk_12_displayName = "Unk 12";
            public const int Unk_12_sortIndex = 900;
            [SortOrder(Unk_12_sortIndex)]
            [DisplayName(Unk_12_displayName)]
            public virtual byte Unk_12 {
                get => Unk_12_raw;
                set {
                    if (Unk_12_raw == value) return;
                    Unk_12_raw = value;
                    ChangedItems.Add(nameof(Unk_12));
                    OnPropertyChanged(nameof(Unk_12));
                }
            }

            [DisplayName("Offset")]
            public long Unk_12_offset { get; private set; }

            protected byte Unk_13_raw;
            public const string Unk_13_displayName = "Unk 13";
            public const int Unk_13_sortIndex = 950;
            [SortOrder(Unk_13_sortIndex)]
            [DisplayName(Unk_13_displayName)]
            public virtual byte Unk_13 {
                get => Unk_13_raw;
                set {
                    if (Unk_13_raw == value) return;
                    Unk_13_raw = value;
                    ChangedItems.Add(nameof(Unk_13));
                    OnPropertyChanged(nameof(Unk_13));
                }
            }

            [DisplayName("Offset")]
            public long Unk_13_offset { get; private set; }

            protected byte Unk_14_raw;
            public const string Unk_14_displayName = "Unk 14";
            public const int Unk_14_sortIndex = 1000;
            [SortOrder(Unk_14_sortIndex)]
            [DisplayName(Unk_14_displayName)]
            public virtual byte Unk_14 {
                get => Unk_14_raw;
                set {
                    if (Unk_14_raw == value) return;
                    Unk_14_raw = value;
                    ChangedItems.Add(nameof(Unk_14));
                    OnPropertyChanged(nameof(Unk_14));
                }
            }

            [DisplayName("Offset")]
            public long Unk_14_offset { get; private set; }

            protected byte Unk_15_raw;
            public const string Unk_15_displayName = "Unk 15";
            public const int Unk_15_sortIndex = 1050;
            [SortOrder(Unk_15_sortIndex)]
            [DisplayName(Unk_15_displayName)]
            public virtual byte Unk_15 {
                get => Unk_15_raw;
                set {
                    if (Unk_15_raw == value) return;
                    Unk_15_raw = value;
                    ChangedItems.Add(nameof(Unk_15));
                    OnPropertyChanged(nameof(Unk_15));
                }
            }

            [DisplayName("Offset")]
            public long Unk_15_offset { get; private set; }

            protected byte Unk_16_raw;
            public const string Unk_16_displayName = "Unk 16";
            public const int Unk_16_sortIndex = 1100;
            [SortOrder(Unk_16_sortIndex)]
            [DisplayName(Unk_16_displayName)]
            public virtual byte Unk_16 {
                get => Unk_16_raw;
                set {
                    if (Unk_16_raw == value) return;
                    Unk_16_raw = value;
                    ChangedItems.Add(nameof(Unk_16));
                    OnPropertyChanged(nameof(Unk_16));
                }
            }

            [DisplayName("Offset")]
            public long Unk_16_offset { get; private set; }

            protected uint Unk_17_raw;
            public const string Unk_17_displayName = "Unk 17";
            public const int Unk_17_sortIndex = 1150;
            [SortOrder(Unk_17_sortIndex)]
            [DisplayName(Unk_17_displayName)]
            public virtual uint Unk_17 {
                get => Unk_17_raw;
                set {
                    if (Unk_17_raw == value) return;
                    Unk_17_raw = value;
                    ChangedItems.Add(nameof(Unk_17));
                    OnPropertyChanged(nameof(Unk_17));
                }
            }

            [DisplayName("Offset")]
            public long Unk_17_offset { get; private set; }

            protected uint Unk_18_raw;
            public const string Unk_18_displayName = "Unk 18";
            public const int Unk_18_sortIndex = 1200;
            [SortOrder(Unk_18_sortIndex)]
            [DisplayName(Unk_18_displayName)]
            public virtual uint Unk_18 {
                get => Unk_18_raw;
                set {
                    if (Unk_18_raw == value) return;
                    Unk_18_raw = value;
                    ChangedItems.Add(nameof(Unk_18));
                    OnPropertyChanged(nameof(Unk_18));
                }
            }

            [DisplayName("Offset")]
            public long Unk_18_offset { get; private set; }

            protected float Unk_19_raw;
            public const string Unk_19_displayName = "Unk 19";
            public const int Unk_19_sortIndex = 1250;
            [SortOrder(Unk_19_sortIndex)]
            [DisplayName(Unk_19_displayName)]
            public virtual float Unk_19 {
                get => Unk_19_raw;
                set {
                    if (Unk_19_raw == value) return;
                    Unk_19_raw = value;
                    ChangedItems.Add(nameof(Unk_19));
                    OnPropertyChanged(nameof(Unk_19));
                }
            }

            [DisplayName("Offset")]
            public long Unk_19_offset { get; private set; }

            protected uint Unk_20_raw;
            public const string Unk_20_displayName = "Unk 20";
            public const int Unk_20_sortIndex = 1300;
            [SortOrder(Unk_20_sortIndex)]
            [DisplayName(Unk_20_displayName)]
            public virtual uint Unk_20 {
                get => Unk_20_raw;
                set {
                    if (Unk_20_raw == value) return;
                    Unk_20_raw = value;
                    ChangedItems.Add(nameof(Unk_20));
                    OnPropertyChanged(nameof(Unk_20));
                }
            }

            [DisplayName("Offset")]
            public long Unk_20_offset { get; private set; }

            protected uint Unk_21_raw;
            public const string Unk_21_displayName = "Unk 21";
            public const int Unk_21_sortIndex = 1350;
            [SortOrder(Unk_21_sortIndex)]
            [DisplayName(Unk_21_displayName)]
            public virtual uint Unk_21 {
                get => Unk_21_raw;
                set {
                    if (Unk_21_raw == value) return;
                    Unk_21_raw = value;
                    ChangedItems.Add(nameof(Unk_21));
                    OnPropertyChanged(nameof(Unk_21));
                }
            }

            [DisplayName("Offset")]
            public long Unk_21_offset { get; private set; }

            protected int Unk_22_raw;
            public const string Unk_22_displayName = "Unk 22";
            public const int Unk_22_sortIndex = 1400;
            [SortOrder(Unk_22_sortIndex)]
            [DisplayName(Unk_22_displayName)]
            public virtual int Unk_22 {
                get => Unk_22_raw;
                set {
                    if (Unk_22_raw == value) return;
                    Unk_22_raw = value;
                    ChangedItems.Add(nameof(Unk_22));
                    OnPropertyChanged(nameof(Unk_22));
                }
            }

            [DisplayName("Offset")]
            public long Unk_22_offset { get; private set; }

            protected uint Unk_23_raw;
            public const string Unk_23_displayName = "Unk 23";
            public const int Unk_23_sortIndex = 1450;
            [SortOrder(Unk_23_sortIndex)]
            [DisplayName(Unk_23_displayName)]
            public virtual uint Unk_23 {
                get => Unk_23_raw;
                set {
                    if (Unk_23_raw == value) return;
                    Unk_23_raw = value;
                    ChangedItems.Add(nameof(Unk_23));
                    OnPropertyChanged(nameof(Unk_23));
                }
            }

            [DisplayName("Offset")]
            public long Unk_23_offset { get; private set; }

            protected uint Unk_24_raw;
            public const string Unk_24_displayName = "Unk 24";
            public const int Unk_24_sortIndex = 1500;
            [SortOrder(Unk_24_sortIndex)]
            [DisplayName(Unk_24_displayName)]
            public virtual uint Unk_24 {
                get => Unk_24_raw;
                set {
                    if (Unk_24_raw == value) return;
                    Unk_24_raw = value;
                    ChangedItems.Add(nameof(Unk_24));
                    OnPropertyChanged(nameof(Unk_24));
                }
            }

            [DisplayName("Offset")]
            public long Unk_24_offset { get; private set; }

            protected uint Unk_25_raw;
            public const string Unk_25_displayName = "Unk 25";
            public const int Unk_25_sortIndex = 1550;
            [SortOrder(Unk_25_sortIndex)]
            [DisplayName(Unk_25_displayName)]
            public virtual uint Unk_25 {
                get => Unk_25_raw;
                set {
                    if (Unk_25_raw == value) return;
                    Unk_25_raw = value;
                    ChangedItems.Add(nameof(Unk_25));
                    OnPropertyChanged(nameof(Unk_25));
                }
            }

            [DisplayName("Offset")]
            public long Unk_25_offset { get; private set; }

            protected uint Unk_26_raw;
            public const string Unk_26_displayName = "Unk 26";
            public const int Unk_26_sortIndex = 1600;
            [SortOrder(Unk_26_sortIndex)]
            [DisplayName(Unk_26_displayName)]
            public virtual uint Unk_26 {
                get => Unk_26_raw;
                set {
                    if (Unk_26_raw == value) return;
                    Unk_26_raw = value;
                    ChangedItems.Add(nameof(Unk_26));
                    OnPropertyChanged(nameof(Unk_26));
                }
            }

            [DisplayName("Offset")]
            public long Unk_26_offset { get; private set; }

            protected uint Locus_EPV_Index_raw;
            public const string Locus_EPV_Index_displayName = "Locus: EPV Index";
            public const int Locus_EPV_Index_sortIndex = 1650;
            [SortOrder(Locus_EPV_Index_sortIndex)]
            [DisplayName(Locus_EPV_Index_displayName)]
            public virtual uint Locus_EPV_Index {
                get => Locus_EPV_Index_raw;
                set {
                    if (Locus_EPV_Index_raw == value) return;
                    Locus_EPV_Index_raw = value;
                    ChangedItems.Add(nameof(Locus_EPV_Index));
                    OnPropertyChanged(nameof(Locus_EPV_Index));
                }
            }

            [DisplayName("Offset")]
            public long Locus_EPV_Index_offset { get; private set; }

            protected uint Locus_EPV_Element__raw;
            public const string Locus_EPV_Element__displayName = "Locus: EPV Element #";
            public const int Locus_EPV_Element__sortIndex = 1700;
            [SortOrder(Locus_EPV_Element__sortIndex)]
            [DisplayName(Locus_EPV_Element__displayName)]
            public virtual uint Locus_EPV_Element_ {
                get => Locus_EPV_Element__raw;
                set {
                    if (Locus_EPV_Element__raw == value) return;
                    Locus_EPV_Element__raw = value;
                    ChangedItems.Add(nameof(Locus_EPV_Element_));
                    OnPropertyChanged(nameof(Locus_EPV_Element_));
                }
            }

            [DisplayName("Offset")]
            public long Locus_EPV_Element__offset { get; private set; }

            protected uint Unk_27_raw;
            public const string Unk_27_displayName = "Unk 27";
            public const int Unk_27_sortIndex = 1750;
            [SortOrder(Unk_27_sortIndex)]
            [DisplayName(Unk_27_displayName)]
            public virtual uint Unk_27 {
                get => Unk_27_raw;
                set {
                    if (Unk_27_raw == value) return;
                    Unk_27_raw = value;
                    ChangedItems.Add(nameof(Unk_27));
                    OnPropertyChanged(nameof(Unk_27));
                }
            }

            [DisplayName("Offset")]
            public long Unk_27_offset { get; private set; }

            protected uint Unk_28_raw;
            public const string Unk_28_displayName = "Unk 28";
            public const int Unk_28_sortIndex = 1800;
            [SortOrder(Unk_28_sortIndex)]
            [DisplayName(Unk_28_displayName)]
            public virtual uint Unk_28 {
                get => Unk_28_raw;
                set {
                    if (Unk_28_raw == value) return;
                    Unk_28_raw = value;
                    ChangedItems.Add(nameof(Unk_28));
                    OnPropertyChanged(nameof(Unk_28));
                }
            }

            [DisplayName("Offset")]
            public long Unk_28_offset { get; private set; }

            protected uint Unk_29_raw;
            public const string Unk_29_displayName = "Unk 29";
            public const int Unk_29_sortIndex = 1850;
            [SortOrder(Unk_29_sortIndex)]
            [DisplayName(Unk_29_displayName)]
            public virtual uint Unk_29 {
                get => Unk_29_raw;
                set {
                    if (Unk_29_raw == value) return;
                    Unk_29_raw = value;
                    ChangedItems.Add(nameof(Unk_29));
                    OnPropertyChanged(nameof(Unk_29));
                }
            }

            [DisplayName("Offset")]
            public long Unk_29_offset { get; private set; }

            protected uint Unk_30_raw;
            public const string Unk_30_displayName = "Unk 30";
            public const int Unk_30_sortIndex = 1900;
            [SortOrder(Unk_30_sortIndex)]
            [DisplayName(Unk_30_displayName)]
            public virtual uint Unk_30 {
                get => Unk_30_raw;
                set {
                    if (Unk_30_raw == value) return;
                    Unk_30_raw = value;
                    ChangedItems.Add(nameof(Unk_30));
                    OnPropertyChanged(nameof(Unk_30));
                }
            }

            [DisplayName("Offset")]
            public long Unk_30_offset { get; private set; }

            protected uint Unk_31_raw;
            public const string Unk_31_displayName = "Unk 31";
            public const int Unk_31_sortIndex = 1950;
            [SortOrder(Unk_31_sortIndex)]
            [DisplayName(Unk_31_displayName)]
            public virtual uint Unk_31 {
                get => Unk_31_raw;
                set {
                    if (Unk_31_raw == value) return;
                    Unk_31_raw = value;
                    ChangedItems.Add(nameof(Unk_31));
                    OnPropertyChanged(nameof(Unk_31));
                }
            }

            [DisplayName("Offset")]
            public long Unk_31_offset { get; private set; }

            protected uint Unk_32_raw;
            public const string Unk_32_displayName = "Unk 32";
            public const int Unk_32_sortIndex = 2000;
            [SortOrder(Unk_32_sortIndex)]
            [DisplayName(Unk_32_displayName)]
            public virtual uint Unk_32 {
                get => Unk_32_raw;
                set {
                    if (Unk_32_raw == value) return;
                    Unk_32_raw = value;
                    ChangedItems.Add(nameof(Unk_32));
                    OnPropertyChanged(nameof(Unk_32));
                }
            }

            [DisplayName("Offset")]
            public long Unk_32_offset { get; private set; }

            protected uint Unk_33_raw;
            public const string Unk_33_displayName = "Unk 33";
            public const int Unk_33_sortIndex = 2050;
            [SortOrder(Unk_33_sortIndex)]
            [DisplayName(Unk_33_displayName)]
            public virtual uint Unk_33 {
                get => Unk_33_raw;
                set {
                    if (Unk_33_raw == value) return;
                    Unk_33_raw = value;
                    ChangedItems.Add(nameof(Unk_33));
                    OnPropertyChanged(nameof(Unk_33));
                }
            }

            [DisplayName("Offset")]
            public long Unk_33_offset { get; private set; }

            protected uint Unk_34_raw;
            public const string Unk_34_displayName = "Unk 34";
            public const int Unk_34_sortIndex = 2100;
            [SortOrder(Unk_34_sortIndex)]
            [DisplayName(Unk_34_displayName)]
            public virtual uint Unk_34 {
                get => Unk_34_raw;
                set {
                    if (Unk_34_raw == value) return;
                    Unk_34_raw = value;
                    ChangedItems.Add(nameof(Unk_34));
                    OnPropertyChanged(nameof(Unk_34));
                }
            }

            [DisplayName("Offset")]
            public long Unk_34_offset { get; private set; }

            public const int lastSortIndex = 2150;

            public static ObservableMhwStructCollection<EPV> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<EPV>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static EPV LoadData(BinaryReader reader, ulong i) {
                var data = new EPV();
                data.Index = i;
                data.Ground_Hit_EPV_Index_offset = reader.BaseStream.Position;
                data.Ground_Hit_EPV_Index_raw = reader.ReadUInt32();
                data.Ground_Hit_EPV_Element__offset = reader.BaseStream.Position;
                data.Ground_Hit_EPV_Element__raw = reader.ReadUInt32();
                data.Wall_Hit_EPV_Index_offset = reader.BaseStream.Position;
                data.Wall_Hit_EPV_Index_raw = reader.ReadUInt32();
                data.Wall_Hit_EPV_Element__offset = reader.BaseStream.Position;
                data.Wall_Hit_EPV_Element__raw = reader.ReadUInt32();
                data.Unk_1_offset = reader.BaseStream.Position;
                data.Unk_1_raw = reader.ReadUInt32();
                data.Unk_2_offset = reader.BaseStream.Position;
                data.Unk_2_raw = reader.ReadUInt32();
                data.Obj_Hit_EPV_Index_offset = reader.BaseStream.Position;
                data.Obj_Hit_EPV_Index_raw = reader.ReadUInt32();
                data.Obj_Hit_EPV_Element__offset = reader.BaseStream.Position;
                data.Obj_Hit_EPV_Element__raw = reader.ReadUInt32();
                data.Unk_3_offset = reader.BaseStream.Position;
                data.Unk_3_raw = reader.ReadByte();
                data.Unk_4_offset = reader.BaseStream.Position;
                data.Unk_4_raw = reader.ReadByte();
                data.Unk_5_offset = reader.BaseStream.Position;
                data.Unk_5_raw = reader.ReadByte();
                data.Unk_6_offset = reader.BaseStream.Position;
                data.Unk_6_raw = reader.ReadByte();
                data.Unk_7_offset = reader.BaseStream.Position;
                data.Unk_7_raw = reader.ReadByte();
                data.Unk_8_offset = reader.BaseStream.Position;
                data.Unk_8_raw = reader.ReadByte();
                data.Unk_9_offset = reader.BaseStream.Position;
                data.Unk_9_raw = reader.ReadByte();
                data.Unk_10_offset = reader.BaseStream.Position;
                data.Unk_10_raw = reader.ReadByte();
                data.Unk_11_offset = reader.BaseStream.Position;
                data.Unk_11_raw = reader.ReadByte();
                data.Unk_12_offset = reader.BaseStream.Position;
                data.Unk_12_raw = reader.ReadByte();
                data.Unk_13_offset = reader.BaseStream.Position;
                data.Unk_13_raw = reader.ReadByte();
                data.Unk_14_offset = reader.BaseStream.Position;
                data.Unk_14_raw = reader.ReadByte();
                data.Unk_15_offset = reader.BaseStream.Position;
                data.Unk_15_raw = reader.ReadByte();
                data.Unk_16_offset = reader.BaseStream.Position;
                data.Unk_16_raw = reader.ReadByte();
                data.Unk_17_offset = reader.BaseStream.Position;
                data.Unk_17_raw = reader.ReadUInt32();
                data.Unk_18_offset = reader.BaseStream.Position;
                data.Unk_18_raw = reader.ReadUInt32();
                data.Unk_19_offset = reader.BaseStream.Position;
                data.Unk_19_raw = reader.ReadSingle();
                data.Unk_20_offset = reader.BaseStream.Position;
                data.Unk_20_raw = reader.ReadUInt32();
                data.Unk_21_offset = reader.BaseStream.Position;
                data.Unk_21_raw = reader.ReadUInt32();
                data.Unk_22_offset = reader.BaseStream.Position;
                data.Unk_22_raw = reader.ReadInt32();
                data.Unk_23_offset = reader.BaseStream.Position;
                data.Unk_23_raw = reader.ReadUInt32();
                data.Unk_24_offset = reader.BaseStream.Position;
                data.Unk_24_raw = reader.ReadUInt32();
                data.Unk_25_offset = reader.BaseStream.Position;
                data.Unk_25_raw = reader.ReadUInt32();
                data.Unk_26_offset = reader.BaseStream.Position;
                data.Unk_26_raw = reader.ReadUInt32();
                data.Locus_EPV_Index_offset = reader.BaseStream.Position;
                data.Locus_EPV_Index_raw = reader.ReadUInt32();
                data.Locus_EPV_Element__offset = reader.BaseStream.Position;
                data.Locus_EPV_Element__raw = reader.ReadUInt32();
                data.Unk_27_offset = reader.BaseStream.Position;
                data.Unk_27_raw = reader.ReadUInt32();
                data.Unk_28_offset = reader.BaseStream.Position;
                data.Unk_28_raw = reader.ReadUInt32();
                data.Unk_29_offset = reader.BaseStream.Position;
                data.Unk_29_raw = reader.ReadUInt32();
                data.Unk_30_offset = reader.BaseStream.Position;
                data.Unk_30_raw = reader.ReadUInt32();
                data.Unk_31_offset = reader.BaseStream.Position;
                data.Unk_31_raw = reader.ReadUInt32();
                data.Unk_32_offset = reader.BaseStream.Position;
                data.Unk_32_raw = reader.ReadUInt32();
                data.Unk_33_offset = reader.BaseStream.Position;
                data.Unk_33_raw = reader.ReadUInt32();
                data.Unk_34_offset = reader.BaseStream.Position;
                data.Unk_34_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Ground_Hit_EPV_Index_raw);
                writer.Write(Ground_Hit_EPV_Element__raw);
                writer.Write(Wall_Hit_EPV_Index_raw);
                writer.Write(Wall_Hit_EPV_Element__raw);
                writer.Write(Unk_1_raw);
                writer.Write(Unk_2_raw);
                writer.Write(Obj_Hit_EPV_Index_raw);
                writer.Write(Obj_Hit_EPV_Element__raw);
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
                writer.Write(Locus_EPV_Index_raw);
                writer.Write(Locus_EPV_Element__raw);
                writer.Write(Unk_27_raw);
                writer.Write(Unk_28_raw);
                writer.Write(Unk_29_raw);
                writer.Write(Unk_30_raw);
                writer.Write(Unk_31_raw);
                writer.Write(Unk_32_raw);
                writer.Write(Unk_33_raw);
                writer.Write(Unk_34_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Ground Hit: EPV Index", "Ground_Hit_EPV_Index", "Ground_Hit_EPV_Index_offset"),
                    new MultiStructItemCustomView(this, "Ground Hit: EPV Element #", "Ground_Hit_EPV_Element_", "Ground_Hit_EPV_Element__offset"),
                    new MultiStructItemCustomView(this, "Wall Hit: EPV Index", "Wall_Hit_EPV_Index", "Wall_Hit_EPV_Index_offset"),
                    new MultiStructItemCustomView(this, "Wall Hit: EPV Element #", "Wall_Hit_EPV_Element_", "Wall_Hit_EPV_Element__offset"),
                    new MultiStructItemCustomView(this, "Unk 1", "Unk_1", "Unk_1_offset"),
                    new MultiStructItemCustomView(this, "Unk 2", "Unk_2", "Unk_2_offset"),
                    new MultiStructItemCustomView(this, "Obj Hit: EPV Index", "Obj_Hit_EPV_Index", "Obj_Hit_EPV_Index_offset"),
                    new MultiStructItemCustomView(this, "Obj Hit: EPV Element #", "Obj_Hit_EPV_Element_", "Obj_Hit_EPV_Element__offset"),
                    new MultiStructItemCustomView(this, "Unk 3", "Unk_3", "Unk_3_offset"),
                    new MultiStructItemCustomView(this, "Unk 4", "Unk_4", "Unk_4_offset"),
                    new MultiStructItemCustomView(this, "Unk 5", "Unk_5", "Unk_5_offset"),
                    new MultiStructItemCustomView(this, "Unk 6", "Unk_6", "Unk_6_offset"),
                    new MultiStructItemCustomView(this, "Unk 7", "Unk_7", "Unk_7_offset"),
                    new MultiStructItemCustomView(this, "Unk 8", "Unk_8", "Unk_8_offset"),
                    new MultiStructItemCustomView(this, "Unk 9", "Unk_9", "Unk_9_offset"),
                    new MultiStructItemCustomView(this, "Unk 10", "Unk_10", "Unk_10_offset"),
                    new MultiStructItemCustomView(this, "Unk 11", "Unk_11", "Unk_11_offset"),
                    new MultiStructItemCustomView(this, "Unk 12", "Unk_12", "Unk_12_offset"),
                    new MultiStructItemCustomView(this, "Unk 13", "Unk_13", "Unk_13_offset"),
                    new MultiStructItemCustomView(this, "Unk 14", "Unk_14", "Unk_14_offset"),
                    new MultiStructItemCustomView(this, "Unk 15", "Unk_15", "Unk_15_offset"),
                    new MultiStructItemCustomView(this, "Unk 16", "Unk_16", "Unk_16_offset"),
                    new MultiStructItemCustomView(this, "Unk 17", "Unk_17", "Unk_17_offset"),
                    new MultiStructItemCustomView(this, "Unk 18", "Unk_18", "Unk_18_offset"),
                    new MultiStructItemCustomView(this, "Unk 19", "Unk_19", "Unk_19_offset"),
                    new MultiStructItemCustomView(this, "Unk 20", "Unk_20", "Unk_20_offset"),
                    new MultiStructItemCustomView(this, "Unk 21", "Unk_21", "Unk_21_offset"),
                    new MultiStructItemCustomView(this, "Unk 22", "Unk_22", "Unk_22_offset"),
                    new MultiStructItemCustomView(this, "Unk 23", "Unk_23", "Unk_23_offset"),
                    new MultiStructItemCustomView(this, "Unk 24", "Unk_24", "Unk_24_offset"),
                    new MultiStructItemCustomView(this, "Unk 25", "Unk_25", "Unk_25_offset"),
                    new MultiStructItemCustomView(this, "Unk 26", "Unk_26", "Unk_26_offset"),
                    new MultiStructItemCustomView(this, "Locus: EPV Index", "Locus_EPV_Index", "Locus_EPV_Index_offset"),
                    new MultiStructItemCustomView(this, "Locus: EPV Element #", "Locus_EPV_Element_", "Locus_EPV_Element__offset"),
                    new MultiStructItemCustomView(this, "Unk 27", "Unk_27", "Unk_27_offset"),
                    new MultiStructItemCustomView(this, "Unk 28", "Unk_28", "Unk_28_offset"),
                    new MultiStructItemCustomView(this, "Unk 29", "Unk_29", "Unk_29_offset"),
                    new MultiStructItemCustomView(this, "Unk 30", "Unk_30", "Unk_30_offset"),
                    new MultiStructItemCustomView(this, "Unk 31", "Unk_31", "Unk_31_offset"),
                    new MultiStructItemCustomView(this, "Unk 32", "Unk_32", "Unk_32_offset"),
                    new MultiStructItemCustomView(this, "Unk 33", "Unk_33", "Unk_33_offset"),
                    new MultiStructItemCustomView(this, "Unk 34", "Unk_34", "Unk_34_offset"),
                };
            }
        }

        public partial class Sound : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Sound";

            protected uint Wwise_Container_Header_raw;
            public const string Wwise_Container_Header_displayName = "Wwise Container Header";
            public const int Wwise_Container_Header_sortIndex = 50;
            [SortOrder(Wwise_Container_Header_sortIndex)]
            [DisplayName(Wwise_Container_Header_displayName)]
            public virtual uint Wwise_Container_Header {
                get => Wwise_Container_Header_raw;
                set {
                    if (Wwise_Container_Header_raw == value) return;
                    Wwise_Container_Header_raw = value;
                    ChangedItems.Add(nameof(Wwise_Container_Header));
                    OnPropertyChanged(nameof(Wwise_Container_Header));
                }
            }

            [DisplayName("Offset")]
            public long Wwise_Container_Header_offset { get; private set; }

            protected string Wwise_Container_raw;
            public const string Wwise_Container_displayName = "Wwise Container";
            public const int Wwise_Container_sortIndex = 100;
            [SortOrder(Wwise_Container_sortIndex)]
            [DisplayName(Wwise_Container_displayName)]
            public virtual string Wwise_Container {
                get => Wwise_Container_raw;
                set {
                    if (Wwise_Container_raw == value) return;
                    Wwise_Container_raw = value;
                    ChangedItems.Add(nameof(Wwise_Container));
                    OnPropertyChanged(nameof(Wwise_Container));
                }
            }

            [DisplayName("Offset")]
            public long Wwise_Container_offset { get; private set; }

            protected int Sound_Shoot_Header_raw;
            public const string Sound_Shoot_Header_displayName = "Sound: Shoot Header";
            public const int Sound_Shoot_Header_sortIndex = 150;
            [SortOrder(Sound_Shoot_Header_sortIndex)]
            [DisplayName(Sound_Shoot_Header_displayName)]
            public virtual int Sound_Shoot_Header {
                get => Sound_Shoot_Header_raw;
                set {
                    if (Sound_Shoot_Header_raw == value) return;
                    Sound_Shoot_Header_raw = value;
                    ChangedItems.Add(nameof(Sound_Shoot_Header));
                    OnPropertyChanged(nameof(Sound_Shoot_Header));
                }
            }

            [DisplayName("Offset")]
            public long Sound_Shoot_Header_offset { get; private set; }

            protected int Sound_Shoot_raw;
            public const string Sound_Shoot_displayName = "Sound: Shoot";
            public const int Sound_Shoot_sortIndex = 200;
            [SortOrder(Sound_Shoot_sortIndex)]
            [DisplayName(Sound_Shoot_displayName)]
            public virtual int Sound_Shoot {
                get => Sound_Shoot_raw;
                set {
                    if (Sound_Shoot_raw == value) return;
                    Sound_Shoot_raw = value;
                    ChangedItems.Add(nameof(Sound_Shoot));
                    OnPropertyChanged(nameof(Sound_Shoot));
                }
            }

            [DisplayName("Offset")]
            public long Sound_Shoot_offset { get; private set; }

            protected int Sound_Loop_Header_raw;
            public const string Sound_Loop_Header_displayName = "Sound: Loop Header";
            public const int Sound_Loop_Header_sortIndex = 250;
            [SortOrder(Sound_Loop_Header_sortIndex)]
            [DisplayName(Sound_Loop_Header_displayName)]
            public virtual int Sound_Loop_Header {
                get => Sound_Loop_Header_raw;
                set {
                    if (Sound_Loop_Header_raw == value) return;
                    Sound_Loop_Header_raw = value;
                    ChangedItems.Add(nameof(Sound_Loop_Header));
                    OnPropertyChanged(nameof(Sound_Loop_Header));
                }
            }

            [DisplayName("Offset")]
            public long Sound_Loop_Header_offset { get; private set; }

            protected int Sound_Loop_raw;
            public const string Sound_Loop_displayName = "Sound: Loop";
            public const int Sound_Loop_sortIndex = 300;
            [SortOrder(Sound_Loop_sortIndex)]
            [DisplayName(Sound_Loop_displayName)]
            public virtual int Sound_Loop {
                get => Sound_Loop_raw;
                set {
                    if (Sound_Loop_raw == value) return;
                    Sound_Loop_raw = value;
                    ChangedItems.Add(nameof(Sound_Loop));
                    OnPropertyChanged(nameof(Sound_Loop));
                }
            }

            [DisplayName("Offset")]
            public long Sound_Loop_offset { get; private set; }

            protected int Sound_Kill_Header_raw;
            public const string Sound_Kill_Header_displayName = "Sound: Kill Header";
            public const int Sound_Kill_Header_sortIndex = 350;
            [SortOrder(Sound_Kill_Header_sortIndex)]
            [DisplayName(Sound_Kill_Header_displayName)]
            public virtual int Sound_Kill_Header {
                get => Sound_Kill_Header_raw;
                set {
                    if (Sound_Kill_Header_raw == value) return;
                    Sound_Kill_Header_raw = value;
                    ChangedItems.Add(nameof(Sound_Kill_Header));
                    OnPropertyChanged(nameof(Sound_Kill_Header));
                }
            }

            [DisplayName("Offset")]
            public long Sound_Kill_Header_offset { get; private set; }

            protected int Sound_Kill_raw;
            public const string Sound_Kill_displayName = "Sound: Kill";
            public const int Sound_Kill_sortIndex = 400;
            [SortOrder(Sound_Kill_sortIndex)]
            [DisplayName(Sound_Kill_displayName)]
            public virtual int Sound_Kill {
                get => Sound_Kill_raw;
                set {
                    if (Sound_Kill_raw == value) return;
                    Sound_Kill_raw = value;
                    ChangedItems.Add(nameof(Sound_Kill));
                    OnPropertyChanged(nameof(Sound_Kill));
                }
            }

            [DisplayName("Offset")]
            public long Sound_Kill_offset { get; private set; }

            protected int Sound_Wall_Ground_Hit_Header_raw;
            public const string Sound_Wall_Ground_Hit_Header_displayName = "Sound: Wall/Ground Hit Header";
            public const int Sound_Wall_Ground_Hit_Header_sortIndex = 450;
            [SortOrder(Sound_Wall_Ground_Hit_Header_sortIndex)]
            [DisplayName(Sound_Wall_Ground_Hit_Header_displayName)]
            public virtual int Sound_Wall_Ground_Hit_Header {
                get => Sound_Wall_Ground_Hit_Header_raw;
                set {
                    if (Sound_Wall_Ground_Hit_Header_raw == value) return;
                    Sound_Wall_Ground_Hit_Header_raw = value;
                    ChangedItems.Add(nameof(Sound_Wall_Ground_Hit_Header));
                    OnPropertyChanged(nameof(Sound_Wall_Ground_Hit_Header));
                }
            }

            [DisplayName("Offset")]
            public long Sound_Wall_Ground_Hit_Header_offset { get; private set; }

            protected int Sound_Wall_Ground_Hit_raw;
            public const string Sound_Wall_Ground_Hit_displayName = "Sound: Wall/Ground Hit";
            public const int Sound_Wall_Ground_Hit_sortIndex = 500;
            [SortOrder(Sound_Wall_Ground_Hit_sortIndex)]
            [DisplayName(Sound_Wall_Ground_Hit_displayName)]
            public virtual int Sound_Wall_Ground_Hit {
                get => Sound_Wall_Ground_Hit_raw;
                set {
                    if (Sound_Wall_Ground_Hit_raw == value) return;
                    Sound_Wall_Ground_Hit_raw = value;
                    ChangedItems.Add(nameof(Sound_Wall_Ground_Hit));
                    OnPropertyChanged(nameof(Sound_Wall_Ground_Hit));
                }
            }

            [DisplayName("Offset")]
            public long Sound_Wall_Ground_Hit_offset { get; private set; }

            protected int Sound_Water_Hit_Header_raw;
            public const string Sound_Water_Hit_Header_displayName = "Sound: Water Hit Header";
            public const int Sound_Water_Hit_Header_sortIndex = 550;
            [SortOrder(Sound_Water_Hit_Header_sortIndex)]
            [DisplayName(Sound_Water_Hit_Header_displayName)]
            public virtual int Sound_Water_Hit_Header {
                get => Sound_Water_Hit_Header_raw;
                set {
                    if (Sound_Water_Hit_Header_raw == value) return;
                    Sound_Water_Hit_Header_raw = value;
                    ChangedItems.Add(nameof(Sound_Water_Hit_Header));
                    OnPropertyChanged(nameof(Sound_Water_Hit_Header));
                }
            }

            [DisplayName("Offset")]
            public long Sound_Water_Hit_Header_offset { get; private set; }

            protected int Sound_Water_Hit_raw;
            public const string Sound_Water_Hit_displayName = "Sound: Water Hit";
            public const int Sound_Water_Hit_sortIndex = 600;
            [SortOrder(Sound_Water_Hit_sortIndex)]
            [DisplayName(Sound_Water_Hit_displayName)]
            public virtual int Sound_Water_Hit {
                get => Sound_Water_Hit_raw;
                set {
                    if (Sound_Water_Hit_raw == value) return;
                    Sound_Water_Hit_raw = value;
                    ChangedItems.Add(nameof(Sound_Water_Hit));
                    OnPropertyChanged(nameof(Sound_Water_Hit));
                }
            }

            [DisplayName("Offset")]
            public long Sound_Water_Hit_offset { get; private set; }

            protected int Sound_Player_Hit_Header_raw;
            public const string Sound_Player_Hit_Header_displayName = "Sound: Player Hit Header";
            public const int Sound_Player_Hit_Header_sortIndex = 650;
            [SortOrder(Sound_Player_Hit_Header_sortIndex)]
            [DisplayName(Sound_Player_Hit_Header_displayName)]
            public virtual int Sound_Player_Hit_Header {
                get => Sound_Player_Hit_Header_raw;
                set {
                    if (Sound_Player_Hit_Header_raw == value) return;
                    Sound_Player_Hit_Header_raw = value;
                    ChangedItems.Add(nameof(Sound_Player_Hit_Header));
                    OnPropertyChanged(nameof(Sound_Player_Hit_Header));
                }
            }

            [DisplayName("Offset")]
            public long Sound_Player_Hit_Header_offset { get; private set; }

            protected int Sound_Player_Hit_raw;
            public const string Sound_Player_Hit_displayName = "Sound: Player Hit";
            public const int Sound_Player_Hit_sortIndex = 700;
            [SortOrder(Sound_Player_Hit_sortIndex)]
            [DisplayName(Sound_Player_Hit_displayName)]
            public virtual int Sound_Player_Hit {
                get => Sound_Player_Hit_raw;
                set {
                    if (Sound_Player_Hit_raw == value) return;
                    Sound_Player_Hit_raw = value;
                    ChangedItems.Add(nameof(Sound_Player_Hit));
                    OnPropertyChanged(nameof(Sound_Player_Hit));
                }
            }

            [DisplayName("Offset")]
            public long Sound_Player_Hit_offset { get; private set; }

            protected int Sound_Delay_Set_Header_Slinger__raw;
            public const string Sound_Delay_Set_Header_Slinger__displayName = "Sound: Delay Set Header (Slinger)";
            public const int Sound_Delay_Set_Header_Slinger__sortIndex = 750;
            [SortOrder(Sound_Delay_Set_Header_Slinger__sortIndex)]
            [DisplayName(Sound_Delay_Set_Header_Slinger__displayName)]
            public virtual int Sound_Delay_Set_Header_Slinger_ {
                get => Sound_Delay_Set_Header_Slinger__raw;
                set {
                    if (Sound_Delay_Set_Header_Slinger__raw == value) return;
                    Sound_Delay_Set_Header_Slinger__raw = value;
                    ChangedItems.Add(nameof(Sound_Delay_Set_Header_Slinger_));
                    OnPropertyChanged(nameof(Sound_Delay_Set_Header_Slinger_));
                }
            }

            [DisplayName("Offset")]
            public long Sound_Delay_Set_Header_Slinger__offset { get; private set; }

            protected int Sound_Delay_Set_Slinger__raw;
            public const string Sound_Delay_Set_Slinger__displayName = "Sound: Delay Set (Slinger)";
            public const int Sound_Delay_Set_Slinger__sortIndex = 800;
            [SortOrder(Sound_Delay_Set_Slinger__sortIndex)]
            [DisplayName(Sound_Delay_Set_Slinger__displayName)]
            public virtual int Sound_Delay_Set_Slinger_ {
                get => Sound_Delay_Set_Slinger__raw;
                set {
                    if (Sound_Delay_Set_Slinger__raw == value) return;
                    Sound_Delay_Set_Slinger__raw = value;
                    ChangedItems.Add(nameof(Sound_Delay_Set_Slinger_));
                    OnPropertyChanged(nameof(Sound_Delay_Set_Slinger_));
                }
            }

            [DisplayName("Offset")]
            public long Sound_Delay_Set_Slinger__offset { get; private set; }

            protected int Sound_Life_End_Header_Slinger__raw;
            public const string Sound_Life_End_Header_Slinger__displayName = "Sound: Life End Header (Slinger)";
            public const int Sound_Life_End_Header_Slinger__sortIndex = 850;
            [SortOrder(Sound_Life_End_Header_Slinger__sortIndex)]
            [DisplayName(Sound_Life_End_Header_Slinger__displayName)]
            public virtual int Sound_Life_End_Header_Slinger_ {
                get => Sound_Life_End_Header_Slinger__raw;
                set {
                    if (Sound_Life_End_Header_Slinger__raw == value) return;
                    Sound_Life_End_Header_Slinger__raw = value;
                    ChangedItems.Add(nameof(Sound_Life_End_Header_Slinger_));
                    OnPropertyChanged(nameof(Sound_Life_End_Header_Slinger_));
                }
            }

            [DisplayName("Offset")]
            public long Sound_Life_End_Header_Slinger__offset { get; private set; }

            protected int Sound_Life_End_Slinger__raw;
            public const string Sound_Life_End_Slinger__displayName = "Sound: Life End (Slinger)";
            public const int Sound_Life_End_Slinger__sortIndex = 900;
            [SortOrder(Sound_Life_End_Slinger__sortIndex)]
            [DisplayName(Sound_Life_End_Slinger__displayName)]
            public virtual int Sound_Life_End_Slinger_ {
                get => Sound_Life_End_Slinger__raw;
                set {
                    if (Sound_Life_End_Slinger__raw == value) return;
                    Sound_Life_End_Slinger__raw = value;
                    ChangedItems.Add(nameof(Sound_Life_End_Slinger_));
                    OnPropertyChanged(nameof(Sound_Life_End_Slinger_));
                }
            }

            [DisplayName("Offset")]
            public long Sound_Life_End_Slinger__offset { get; private set; }

            protected int Sound_Monster_Reflect_Header_raw;
            public const string Sound_Monster_Reflect_Header_displayName = "Sound: Monster Reflect Header";
            public const int Sound_Monster_Reflect_Header_sortIndex = 950;
            [SortOrder(Sound_Monster_Reflect_Header_sortIndex)]
            [DisplayName(Sound_Monster_Reflect_Header_displayName)]
            public virtual int Sound_Monster_Reflect_Header {
                get => Sound_Monster_Reflect_Header_raw;
                set {
                    if (Sound_Monster_Reflect_Header_raw == value) return;
                    Sound_Monster_Reflect_Header_raw = value;
                    ChangedItems.Add(nameof(Sound_Monster_Reflect_Header));
                    OnPropertyChanged(nameof(Sound_Monster_Reflect_Header));
                }
            }

            [DisplayName("Offset")]
            public long Sound_Monster_Reflect_Header_offset { get; private set; }

            protected int Sound_Monster_Reflect_raw;
            public const string Sound_Monster_Reflect_displayName = "Sound: Monster Reflect";
            public const int Sound_Monster_Reflect_sortIndex = 1000;
            [SortOrder(Sound_Monster_Reflect_sortIndex)]
            [DisplayName(Sound_Monster_Reflect_displayName)]
            public virtual int Sound_Monster_Reflect {
                get => Sound_Monster_Reflect_raw;
                set {
                    if (Sound_Monster_Reflect_raw == value) return;
                    Sound_Monster_Reflect_raw = value;
                    ChangedItems.Add(nameof(Sound_Monster_Reflect));
                    OnPropertyChanged(nameof(Sound_Monster_Reflect));
                }
            }

            [DisplayName("Offset")]
            public long Sound_Monster_Reflect_offset { get; private set; }

            protected int Sound_Custom_Header_1_raw;
            public const string Sound_Custom_Header_1_displayName = "Sound: Custom Header 1";
            public const int Sound_Custom_Header_1_sortIndex = 1050;
            [SortOrder(Sound_Custom_Header_1_sortIndex)]
            [DisplayName(Sound_Custom_Header_1_displayName)]
            public virtual int Sound_Custom_Header_1 {
                get => Sound_Custom_Header_1_raw;
                set {
                    if (Sound_Custom_Header_1_raw == value) return;
                    Sound_Custom_Header_1_raw = value;
                    ChangedItems.Add(nameof(Sound_Custom_Header_1));
                    OnPropertyChanged(nameof(Sound_Custom_Header_1));
                }
            }

            [DisplayName("Offset")]
            public long Sound_Custom_Header_1_offset { get; private set; }

            protected int Sound_Custom_1_raw;
            public const string Sound_Custom_1_displayName = "Sound: Custom 1";
            public const int Sound_Custom_1_sortIndex = 1100;
            [SortOrder(Sound_Custom_1_sortIndex)]
            [DisplayName(Sound_Custom_1_displayName)]
            public virtual int Sound_Custom_1 {
                get => Sound_Custom_1_raw;
                set {
                    if (Sound_Custom_1_raw == value) return;
                    Sound_Custom_1_raw = value;
                    ChangedItems.Add(nameof(Sound_Custom_1));
                    OnPropertyChanged(nameof(Sound_Custom_1));
                }
            }

            [DisplayName("Offset")]
            public long Sound_Custom_1_offset { get; private set; }

            protected int Sound_Custom_Header_2_raw;
            public const string Sound_Custom_Header_2_displayName = "Sound: Custom Header 2";
            public const int Sound_Custom_Header_2_sortIndex = 1150;
            [SortOrder(Sound_Custom_Header_2_sortIndex)]
            [DisplayName(Sound_Custom_Header_2_displayName)]
            public virtual int Sound_Custom_Header_2 {
                get => Sound_Custom_Header_2_raw;
                set {
                    if (Sound_Custom_Header_2_raw == value) return;
                    Sound_Custom_Header_2_raw = value;
                    ChangedItems.Add(nameof(Sound_Custom_Header_2));
                    OnPropertyChanged(nameof(Sound_Custom_Header_2));
                }
            }

            [DisplayName("Offset")]
            public long Sound_Custom_Header_2_offset { get; private set; }

            protected int Sound_Custom_2_raw;
            public const string Sound_Custom_2_displayName = "Sound: Custom 2";
            public const int Sound_Custom_2_sortIndex = 1200;
            [SortOrder(Sound_Custom_2_sortIndex)]
            [DisplayName(Sound_Custom_2_displayName)]
            public virtual int Sound_Custom_2 {
                get => Sound_Custom_2_raw;
                set {
                    if (Sound_Custom_2_raw == value) return;
                    Sound_Custom_2_raw = value;
                    ChangedItems.Add(nameof(Sound_Custom_2));
                    OnPropertyChanged(nameof(Sound_Custom_2));
                }
            }

            [DisplayName("Offset")]
            public long Sound_Custom_2_offset { get; private set; }

            protected int Sound_Custom_Header_3_raw;
            public const string Sound_Custom_Header_3_displayName = "Sound: Custom Header 3";
            public const int Sound_Custom_Header_3_sortIndex = 1250;
            [SortOrder(Sound_Custom_Header_3_sortIndex)]
            [DisplayName(Sound_Custom_Header_3_displayName)]
            public virtual int Sound_Custom_Header_3 {
                get => Sound_Custom_Header_3_raw;
                set {
                    if (Sound_Custom_Header_3_raw == value) return;
                    Sound_Custom_Header_3_raw = value;
                    ChangedItems.Add(nameof(Sound_Custom_Header_3));
                    OnPropertyChanged(nameof(Sound_Custom_Header_3));
                }
            }

            [DisplayName("Offset")]
            public long Sound_Custom_Header_3_offset { get; private set; }

            protected int Sound_Custom_3_raw;
            public const string Sound_Custom_3_displayName = "Sound: Custom 3";
            public const int Sound_Custom_3_sortIndex = 1300;
            [SortOrder(Sound_Custom_3_sortIndex)]
            [DisplayName(Sound_Custom_3_displayName)]
            public virtual int Sound_Custom_3 {
                get => Sound_Custom_3_raw;
                set {
                    if (Sound_Custom_3_raw == value) return;
                    Sound_Custom_3_raw = value;
                    ChangedItems.Add(nameof(Sound_Custom_3));
                    OnPropertyChanged(nameof(Sound_Custom_3));
                }
            }

            [DisplayName("Offset")]
            public long Sound_Custom_3_offset { get; private set; }

            public const int lastSortIndex = 1350;

            public static ObservableMhwStructCollection<Sound> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Sound>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Sound LoadData(BinaryReader reader, ulong i) {
                var data = new Sound();
                data.Index = i;
                data.Wwise_Container_Header_offset = reader.BaseStream.Position;
                data.Wwise_Container_Header_raw = reader.ReadUInt32();
                if (data.Wwise_Container_Header_raw != 0) data.Wwise_Container_offset = reader.BaseStream.Position;
                if (data.Wwise_Container_Header_raw != 0) data.Wwise_Container_raw = reader.ReadNullTermString();
                data.Sound_Shoot_Header_offset = reader.BaseStream.Position;
                data.Sound_Shoot_Header_raw = reader.ReadInt32();
                data.Sound_Shoot_offset = reader.BaseStream.Position;
                data.Sound_Shoot_raw = reader.ReadInt32();
                data.Sound_Loop_Header_offset = reader.BaseStream.Position;
                data.Sound_Loop_Header_raw = reader.ReadInt32();
                data.Sound_Loop_offset = reader.BaseStream.Position;
                data.Sound_Loop_raw = reader.ReadInt32();
                data.Sound_Kill_Header_offset = reader.BaseStream.Position;
                data.Sound_Kill_Header_raw = reader.ReadInt32();
                data.Sound_Kill_offset = reader.BaseStream.Position;
                data.Sound_Kill_raw = reader.ReadInt32();
                data.Sound_Wall_Ground_Hit_Header_offset = reader.BaseStream.Position;
                data.Sound_Wall_Ground_Hit_Header_raw = reader.ReadInt32();
                data.Sound_Wall_Ground_Hit_offset = reader.BaseStream.Position;
                data.Sound_Wall_Ground_Hit_raw = reader.ReadInt32();
                data.Sound_Water_Hit_Header_offset = reader.BaseStream.Position;
                data.Sound_Water_Hit_Header_raw = reader.ReadInt32();
                data.Sound_Water_Hit_offset = reader.BaseStream.Position;
                data.Sound_Water_Hit_raw = reader.ReadInt32();
                data.Sound_Player_Hit_Header_offset = reader.BaseStream.Position;
                data.Sound_Player_Hit_Header_raw = reader.ReadInt32();
                data.Sound_Player_Hit_offset = reader.BaseStream.Position;
                data.Sound_Player_Hit_raw = reader.ReadInt32();
                data.Sound_Delay_Set_Header_Slinger__offset = reader.BaseStream.Position;
                data.Sound_Delay_Set_Header_Slinger__raw = reader.ReadInt32();
                data.Sound_Delay_Set_Slinger__offset = reader.BaseStream.Position;
                data.Sound_Delay_Set_Slinger__raw = reader.ReadInt32();
                data.Sound_Life_End_Header_Slinger__offset = reader.BaseStream.Position;
                data.Sound_Life_End_Header_Slinger__raw = reader.ReadInt32();
                data.Sound_Life_End_Slinger__offset = reader.BaseStream.Position;
                data.Sound_Life_End_Slinger__raw = reader.ReadInt32();
                data.Sound_Monster_Reflect_Header_offset = reader.BaseStream.Position;
                data.Sound_Monster_Reflect_Header_raw = reader.ReadInt32();
                data.Sound_Monster_Reflect_offset = reader.BaseStream.Position;
                data.Sound_Monster_Reflect_raw = reader.ReadInt32();
                data.Sound_Custom_Header_1_offset = reader.BaseStream.Position;
                data.Sound_Custom_Header_1_raw = reader.ReadInt32();
                data.Sound_Custom_1_offset = reader.BaseStream.Position;
                data.Sound_Custom_1_raw = reader.ReadInt32();
                data.Sound_Custom_Header_2_offset = reader.BaseStream.Position;
                data.Sound_Custom_Header_2_raw = reader.ReadInt32();
                data.Sound_Custom_2_offset = reader.BaseStream.Position;
                data.Sound_Custom_2_raw = reader.ReadInt32();
                data.Sound_Custom_Header_3_offset = reader.BaseStream.Position;
                data.Sound_Custom_Header_3_raw = reader.ReadInt32();
                data.Sound_Custom_3_offset = reader.BaseStream.Position;
                data.Sound_Custom_3_raw = reader.ReadInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Wwise_Container_Header_raw);
                if (Wwise_Container_Header_raw != 0) writer.Write(Wwise_Container_raw.ToNullTermCharArray());
                writer.Write(Sound_Shoot_Header_raw);
                writer.Write(Sound_Shoot_raw);
                writer.Write(Sound_Loop_Header_raw);
                writer.Write(Sound_Loop_raw);
                writer.Write(Sound_Kill_Header_raw);
                writer.Write(Sound_Kill_raw);
                writer.Write(Sound_Wall_Ground_Hit_Header_raw);
                writer.Write(Sound_Wall_Ground_Hit_raw);
                writer.Write(Sound_Water_Hit_Header_raw);
                writer.Write(Sound_Water_Hit_raw);
                writer.Write(Sound_Player_Hit_Header_raw);
                writer.Write(Sound_Player_Hit_raw);
                writer.Write(Sound_Delay_Set_Header_Slinger__raw);
                writer.Write(Sound_Delay_Set_Slinger__raw);
                writer.Write(Sound_Life_End_Header_Slinger__raw);
                writer.Write(Sound_Life_End_Slinger__raw);
                writer.Write(Sound_Monster_Reflect_Header_raw);
                writer.Write(Sound_Monster_Reflect_raw);
                writer.Write(Sound_Custom_Header_1_raw);
                writer.Write(Sound_Custom_1_raw);
                writer.Write(Sound_Custom_Header_2_raw);
                writer.Write(Sound_Custom_2_raw);
                writer.Write(Sound_Custom_Header_3_raw);
                writer.Write(Sound_Custom_3_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Wwise Container Header", "Wwise_Container_Header", "Wwise_Container_Header_offset"),
                    new MultiStructItemCustomView(this, "Wwise Container", "Wwise_Container", "Wwise_Container_offset"),
                    new MultiStructItemCustomView(this, "Sound: Shoot Header", "Sound_Shoot_Header", "Sound_Shoot_Header_offset"),
                    new MultiStructItemCustomView(this, "Sound: Shoot", "Sound_Shoot", "Sound_Shoot_offset"),
                    new MultiStructItemCustomView(this, "Sound: Loop Header", "Sound_Loop_Header", "Sound_Loop_Header_offset"),
                    new MultiStructItemCustomView(this, "Sound: Loop", "Sound_Loop", "Sound_Loop_offset"),
                    new MultiStructItemCustomView(this, "Sound: Kill Header", "Sound_Kill_Header", "Sound_Kill_Header_offset"),
                    new MultiStructItemCustomView(this, "Sound: Kill", "Sound_Kill", "Sound_Kill_offset"),
                    new MultiStructItemCustomView(this, "Sound: Wall/Ground Hit Header", "Sound_Wall_Ground_Hit_Header", "Sound_Wall_Ground_Hit_Header_offset"),
                    new MultiStructItemCustomView(this, "Sound: Wall/Ground Hit", "Sound_Wall_Ground_Hit", "Sound_Wall_Ground_Hit_offset"),
                    new MultiStructItemCustomView(this, "Sound: Water Hit Header", "Sound_Water_Hit_Header", "Sound_Water_Hit_Header_offset"),
                    new MultiStructItemCustomView(this, "Sound: Water Hit", "Sound_Water_Hit", "Sound_Water_Hit_offset"),
                    new MultiStructItemCustomView(this, "Sound: Player Hit Header", "Sound_Player_Hit_Header", "Sound_Player_Hit_Header_offset"),
                    new MultiStructItemCustomView(this, "Sound: Player Hit", "Sound_Player_Hit", "Sound_Player_Hit_offset"),
                    new MultiStructItemCustomView(this, "Sound: Delay Set Header (Slinger)", "Sound_Delay_Set_Header_Slinger_", "Sound_Delay_Set_Header_Slinger__offset"),
                    new MultiStructItemCustomView(this, "Sound: Delay Set (Slinger)", "Sound_Delay_Set_Slinger_", "Sound_Delay_Set_Slinger__offset"),
                    new MultiStructItemCustomView(this, "Sound: Life End Header (Slinger)", "Sound_Life_End_Header_Slinger_", "Sound_Life_End_Header_Slinger__offset"),
                    new MultiStructItemCustomView(this, "Sound: Life End (Slinger)", "Sound_Life_End_Slinger_", "Sound_Life_End_Slinger__offset"),
                    new MultiStructItemCustomView(this, "Sound: Monster Reflect Header", "Sound_Monster_Reflect_Header", "Sound_Monster_Reflect_Header_offset"),
                    new MultiStructItemCustomView(this, "Sound: Monster Reflect", "Sound_Monster_Reflect", "Sound_Monster_Reflect_offset"),
                    new MultiStructItemCustomView(this, "Sound: Custom Header 1", "Sound_Custom_Header_1", "Sound_Custom_Header_1_offset"),
                    new MultiStructItemCustomView(this, "Sound: Custom 1", "Sound_Custom_1", "Sound_Custom_1_offset"),
                    new MultiStructItemCustomView(this, "Sound: Custom Header 2", "Sound_Custom_Header_2", "Sound_Custom_Header_2_offset"),
                    new MultiStructItemCustomView(this, "Sound: Custom 2", "Sound_Custom_2", "Sound_Custom_2_offset"),
                    new MultiStructItemCustomView(this, "Sound: Custom Header 3", "Sound_Custom_Header_3", "Sound_Custom_Header_3_offset"),
                    new MultiStructItemCustomView(this, "Sound: Custom 3", "Sound_Custom_3", "Sound_Custom_3_offset"),
                };
            }
        }

        public partial class Shlp_2_ : MhwStructItem, IHasCustomView<MultiStructItemCustomView>, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Shlp (2)";

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
                    ChangedItems.Add(nameof(Header));
                    OnPropertyChanged(nameof(Header));
                }
            }

            [DisplayName("Offset")]
            public long Header_offset { get; private set; }

            protected uint Projectile_Entity_Collider_raw;
            public const string Projectile_Entity_Collider_displayName = "Projectile: Entity Collider";
            public const int Projectile_Entity_Collider_sortIndex = 100;
            [SortOrder(Projectile_Entity_Collider_sortIndex)]
            [DisplayName(Projectile_Entity_Collider_displayName)]
            public virtual uint Projectile_Entity_Collider {
                get => Projectile_Entity_Collider_raw;
                set {
                    if (Projectile_Entity_Collider_raw == value) return;
                    Projectile_Entity_Collider_raw = value;
                    ChangedItems.Add(nameof(Projectile_Entity_Collider));
                    OnPropertyChanged(nameof(Projectile_Entity_Collider));
                }
            }

            [DisplayName("Offset")]
            public long Projectile_Entity_Collider_offset { get; private set; }

            protected float Projectile_Model_Lifespan_raw;
            public const string Projectile_Model_Lifespan_displayName = "Projectile: Model Lifespan";
            public const int Projectile_Model_Lifespan_sortIndex = 150;
            [SortOrder(Projectile_Model_Lifespan_sortIndex)]
            [DisplayName(Projectile_Model_Lifespan_displayName)]
            public virtual float Projectile_Model_Lifespan {
                get => Projectile_Model_Lifespan_raw;
                set {
                    if (Projectile_Model_Lifespan_raw == value) return;
                    Projectile_Model_Lifespan_raw = value;
                    ChangedItems.Add(nameof(Projectile_Model_Lifespan));
                    OnPropertyChanged(nameof(Projectile_Model_Lifespan));
                }
            }

            [DisplayName("Offset")]
            public long Projectile_Model_Lifespan_offset { get; private set; }

            protected int Projectile_Distance_Range_raw;
            public const string Projectile_Distance_Range_displayName = "Projectile: Distance Range";
            public const int Projectile_Distance_Range_sortIndex = 200;
            [SortOrder(Projectile_Distance_Range_sortIndex)]
            [DisplayName(Projectile_Distance_Range_displayName)]
            public virtual int Projectile_Distance_Range {
                get => Projectile_Distance_Range_raw;
                set {
                    if (Projectile_Distance_Range_raw == value) return;
                    Projectile_Distance_Range_raw = value;
                    ChangedItems.Add(nameof(Projectile_Distance_Range));
                    OnPropertyChanged(nameof(Projectile_Distance_Range));
                }
            }

            [DisplayName("Offset")]
            public long Projectile_Distance_Range_offset { get; private set; }

            protected byte Unk_35_raw;
            public const string Unk_35_displayName = "Unk 35";
            public const int Unk_35_sortIndex = 250;
            [SortOrder(Unk_35_sortIndex)]
            [DisplayName(Unk_35_displayName)]
            public virtual byte Unk_35 {
                get => Unk_35_raw;
                set {
                    if (Unk_35_raw == value) return;
                    Unk_35_raw = value;
                    ChangedItems.Add(nameof(Unk_35));
                    OnPropertyChanged(nameof(Unk_35));
                }
            }

            [DisplayName("Offset")]
            public long Unk_35_offset { get; private set; }

            protected byte Unk_36_raw;
            public const string Unk_36_displayName = "Unk 36";
            public const int Unk_36_sortIndex = 300;
            [SortOrder(Unk_36_sortIndex)]
            [DisplayName(Unk_36_displayName)]
            public virtual byte Unk_36 {
                get => Unk_36_raw;
                set {
                    if (Unk_36_raw == value) return;
                    Unk_36_raw = value;
                    ChangedItems.Add(nameof(Unk_36));
                    OnPropertyChanged(nameof(Unk_36));
                }
            }

            [DisplayName("Offset")]
            public long Unk_36_offset { get; private set; }

            protected byte Unk_37_raw;
            public const string Unk_37_displayName = "Unk 37";
            public const int Unk_37_sortIndex = 350;
            [SortOrder(Unk_37_sortIndex)]
            [DisplayName(Unk_37_displayName)]
            public virtual byte Unk_37 {
                get => Unk_37_raw;
                set {
                    if (Unk_37_raw == value) return;
                    Unk_37_raw = value;
                    ChangedItems.Add(nameof(Unk_37));
                    OnPropertyChanged(nameof(Unk_37));
                }
            }

            [DisplayName("Offset")]
            public long Unk_37_offset { get; private set; }

            protected byte Unk_38_raw;
            public const string Unk_38_displayName = "Unk 38";
            public const int Unk_38_sortIndex = 400;
            [SortOrder(Unk_38_sortIndex)]
            [DisplayName(Unk_38_displayName)]
            public virtual byte Unk_38 {
                get => Unk_38_raw;
                set {
                    if (Unk_38_raw == value) return;
                    Unk_38_raw = value;
                    ChangedItems.Add(nameof(Unk_38));
                    OnPropertyChanged(nameof(Unk_38));
                }
            }

            [DisplayName("Offset")]
            public long Unk_38_offset { get; private set; }

            protected uint Unk_39_raw;
            public const string Unk_39_displayName = "Unk 39";
            public const int Unk_39_sortIndex = 450;
            [SortOrder(Unk_39_sortIndex)]
            [DisplayName(Unk_39_displayName)]
            public virtual uint Unk_39 {
                get => Unk_39_raw;
                set {
                    if (Unk_39_raw == value) return;
                    Unk_39_raw = value;
                    ChangedItems.Add(nameof(Unk_39));
                    OnPropertyChanged(nameof(Unk_39));
                }
            }

            [DisplayName("Offset")]
            public long Unk_39_offset { get; private set; }

            protected uint Unk_40_raw;
            public const string Unk_40_displayName = "Unk 40";
            public const int Unk_40_sortIndex = 500;
            [SortOrder(Unk_40_sortIndex)]
            [DisplayName(Unk_40_displayName)]
            public virtual uint Unk_40 {
                get => Unk_40_raw;
                set {
                    if (Unk_40_raw == value) return;
                    Unk_40_raw = value;
                    ChangedItems.Add(nameof(Unk_40));
                    OnPropertyChanged(nameof(Unk_40));
                }
            }

            [DisplayName("Offset")]
            public long Unk_40_offset { get; private set; }

            protected uint Unk_41_raw;
            public const string Unk_41_displayName = "Unk 41";
            public const int Unk_41_sortIndex = 550;
            [SortOrder(Unk_41_sortIndex)]
            [DisplayName(Unk_41_displayName)]
            public virtual uint Unk_41 {
                get => Unk_41_raw;
                set {
                    if (Unk_41_raw == value) return;
                    Unk_41_raw = value;
                    ChangedItems.Add(nameof(Unk_41));
                    OnPropertyChanged(nameof(Unk_41));
                }
            }

            [DisplayName("Offset")]
            public long Unk_41_offset { get; private set; }

            protected float Projectile_Spawn_Pos_Y_raw;
            public const string Projectile_Spawn_Pos_Y_displayName = "Projectile: Spawn Pos Y";
            public const int Projectile_Spawn_Pos_Y_sortIndex = 600;
            [SortOrder(Projectile_Spawn_Pos_Y_sortIndex)]
            [DisplayName(Projectile_Spawn_Pos_Y_displayName)]
            public virtual float Projectile_Spawn_Pos_Y {
                get => Projectile_Spawn_Pos_Y_raw;
                set {
                    if (Projectile_Spawn_Pos_Y_raw == value) return;
                    Projectile_Spawn_Pos_Y_raw = value;
                    ChangedItems.Add(nameof(Projectile_Spawn_Pos_Y));
                    OnPropertyChanged(nameof(Projectile_Spawn_Pos_Y));
                }
            }

            [DisplayName("Offset")]
            public long Projectile_Spawn_Pos_Y_offset { get; private set; }

            protected float Projectile_Spawn_Pos_X_raw;
            public const string Projectile_Spawn_Pos_X_displayName = "Projectile: Spawn Pos X";
            public const int Projectile_Spawn_Pos_X_sortIndex = 650;
            [SortOrder(Projectile_Spawn_Pos_X_sortIndex)]
            [DisplayName(Projectile_Spawn_Pos_X_displayName)]
            public virtual float Projectile_Spawn_Pos_X {
                get => Projectile_Spawn_Pos_X_raw;
                set {
                    if (Projectile_Spawn_Pos_X_raw == value) return;
                    Projectile_Spawn_Pos_X_raw = value;
                    ChangedItems.Add(nameof(Projectile_Spawn_Pos_X));
                    OnPropertyChanged(nameof(Projectile_Spawn_Pos_X));
                }
            }

            [DisplayName("Offset")]
            public long Projectile_Spawn_Pos_X_offset { get; private set; }

            protected float Projectile_Velocity_raw;
            public const string Projectile_Velocity_displayName = "Projectile: Velocity";
            public const int Projectile_Velocity_sortIndex = 700;
            [SortOrder(Projectile_Velocity_sortIndex)]
            [DisplayName(Projectile_Velocity_displayName)]
            public virtual float Projectile_Velocity {
                get => Projectile_Velocity_raw;
                set {
                    if (Projectile_Velocity_raw == value) return;
                    Projectile_Velocity_raw = value;
                    ChangedItems.Add(nameof(Projectile_Velocity));
                    OnPropertyChanged(nameof(Projectile_Velocity));
                }
            }

            [DisplayName("Offset")]
            public long Projectile_Velocity_offset { get; private set; }

            protected float Projectile_Falloff_raw;
            public const string Projectile_Falloff_displayName = "Projectile: Falloff";
            public const int Projectile_Falloff_sortIndex = 750;
            [SortOrder(Projectile_Falloff_sortIndex)]
            [DisplayName(Projectile_Falloff_displayName)]
            public virtual float Projectile_Falloff {
                get => Projectile_Falloff_raw;
                set {
                    if (Projectile_Falloff_raw == value) return;
                    Projectile_Falloff_raw = value;
                    ChangedItems.Add(nameof(Projectile_Falloff));
                    OnPropertyChanged(nameof(Projectile_Falloff));
                }
            }

            [DisplayName("Offset")]
            public long Projectile_Falloff_offset { get; private set; }

            protected float Unk_42_raw;
            public const string Unk_42_displayName = "Unk 42";
            public const int Unk_42_sortIndex = 800;
            [SortOrder(Unk_42_sortIndex)]
            [DisplayName(Unk_42_displayName)]
            public virtual float Unk_42 {
                get => Unk_42_raw;
                set {
                    if (Unk_42_raw == value) return;
                    Unk_42_raw = value;
                    ChangedItems.Add(nameof(Unk_42));
                    OnPropertyChanged(nameof(Unk_42));
                }
            }

            [DisplayName("Offset")]
            public long Unk_42_offset { get; private set; }

            protected float Unk_43_raw;
            public const string Unk_43_displayName = "Unk 43";
            public const int Unk_43_sortIndex = 850;
            [SortOrder(Unk_43_sortIndex)]
            [DisplayName(Unk_43_displayName)]
            public virtual float Unk_43 {
                get => Unk_43_raw;
                set {
                    if (Unk_43_raw == value) return;
                    Unk_43_raw = value;
                    ChangedItems.Add(nameof(Unk_43));
                    OnPropertyChanged(nameof(Unk_43));
                }
            }

            [DisplayName("Offset")]
            public long Unk_43_offset { get; private set; }

            protected float Unk_44_raw;
            public const string Unk_44_displayName = "Unk 44";
            public const int Unk_44_sortIndex = 900;
            [SortOrder(Unk_44_sortIndex)]
            [DisplayName(Unk_44_displayName)]
            public virtual float Unk_44 {
                get => Unk_44_raw;
                set {
                    if (Unk_44_raw == value) return;
                    Unk_44_raw = value;
                    ChangedItems.Add(nameof(Unk_44));
                    OnPropertyChanged(nameof(Unk_44));
                }
            }

            [DisplayName("Offset")]
            public long Unk_44_offset { get; private set; }

            protected float Angle_Unk_1_raw;
            public const string Angle_Unk_1_displayName = "Angle Unk 1";
            public const int Angle_Unk_1_sortIndex = 950;
            [SortOrder(Angle_Unk_1_sortIndex)]
            [DisplayName(Angle_Unk_1_displayName)]
            public virtual float Angle_Unk_1 {
                get => Angle_Unk_1_raw;
                set {
                    if (Angle_Unk_1_raw == value) return;
                    Angle_Unk_1_raw = value;
                    ChangedItems.Add(nameof(Angle_Unk_1));
                    OnPropertyChanged(nameof(Angle_Unk_1));
                }
            }

            [DisplayName("Offset")]
            public long Angle_Unk_1_offset { get; private set; }

            protected float Angle_Unk_2_raw;
            public const string Angle_Unk_2_displayName = "Angle Unk 2";
            public const int Angle_Unk_2_sortIndex = 1000;
            [SortOrder(Angle_Unk_2_sortIndex)]
            [DisplayName(Angle_Unk_2_displayName)]
            public virtual float Angle_Unk_2 {
                get => Angle_Unk_2_raw;
                set {
                    if (Angle_Unk_2_raw == value) return;
                    Angle_Unk_2_raw = value;
                    ChangedItems.Add(nameof(Angle_Unk_2));
                    OnPropertyChanged(nameof(Angle_Unk_2));
                }
            }

            [DisplayName("Offset")]
            public long Angle_Unk_2_offset { get; private set; }

            protected float Angle_Unk_3_raw;
            public const string Angle_Unk_3_displayName = "Angle Unk 3";
            public const int Angle_Unk_3_sortIndex = 1050;
            [SortOrder(Angle_Unk_3_sortIndex)]
            [DisplayName(Angle_Unk_3_displayName)]
            public virtual float Angle_Unk_3 {
                get => Angle_Unk_3_raw;
                set {
                    if (Angle_Unk_3_raw == value) return;
                    Angle_Unk_3_raw = value;
                    ChangedItems.Add(nameof(Angle_Unk_3));
                    OnPropertyChanged(nameof(Angle_Unk_3));
                }
            }

            [DisplayName("Offset")]
            public long Angle_Unk_3_offset { get; private set; }

            protected float Angle_Unk_4_raw;
            public const string Angle_Unk_4_displayName = "Angle Unk 4";
            public const int Angle_Unk_4_sortIndex = 1100;
            [SortOrder(Angle_Unk_4_sortIndex)]
            [DisplayName(Angle_Unk_4_displayName)]
            public virtual float Angle_Unk_4 {
                get => Angle_Unk_4_raw;
                set {
                    if (Angle_Unk_4_raw == value) return;
                    Angle_Unk_4_raw = value;
                    ChangedItems.Add(nameof(Angle_Unk_4));
                    OnPropertyChanged(nameof(Angle_Unk_4));
                }
            }

            [DisplayName("Offset")]
            public long Angle_Unk_4_offset { get; private set; }

            protected float Projectile_Hitbox_Range_raw;
            public const string Projectile_Hitbox_Range_displayName = "Projectile: Hitbox Range";
            public const int Projectile_Hitbox_Range_sortIndex = 1150;
            [SortOrder(Projectile_Hitbox_Range_sortIndex)]
            [DisplayName(Projectile_Hitbox_Range_displayName)]
            public virtual float Projectile_Hitbox_Range {
                get => Projectile_Hitbox_Range_raw;
                set {
                    if (Projectile_Hitbox_Range_raw == value) return;
                    Projectile_Hitbox_Range_raw = value;
                    ChangedItems.Add(nameof(Projectile_Hitbox_Range));
                    OnPropertyChanged(nameof(Projectile_Hitbox_Range));
                }
            }

            [DisplayName("Offset")]
            public long Projectile_Hitbox_Range_offset { get; private set; }

            protected uint Unk_45_raw;
            public const string Unk_45_displayName = "Unk 45";
            public const int Unk_45_sortIndex = 1200;
            [SortOrder(Unk_45_sortIndex)]
            [DisplayName(Unk_45_displayName)]
            public virtual uint Unk_45 {
                get => Unk_45_raw;
                set {
                    if (Unk_45_raw == value) return;
                    Unk_45_raw = value;
                    ChangedItems.Add(nameof(Unk_45));
                    OnPropertyChanged(nameof(Unk_45));
                }
            }

            [DisplayName("Offset")]
            public long Unk_45_offset { get; private set; }

            protected uint Insta_Kill_Trigger_raw;
            public const string Insta_Kill_Trigger_displayName = "Insta-Kill Trigger";
            public const int Insta_Kill_Trigger_sortIndex = 1250;
            [SortOrder(Insta_Kill_Trigger_sortIndex)]
            [DisplayName(Insta_Kill_Trigger_displayName)]
            public virtual uint Insta_Kill_Trigger {
                get => Insta_Kill_Trigger_raw;
                set {
                    if (Insta_Kill_Trigger_raw == value) return;
                    Insta_Kill_Trigger_raw = value;
                    ChangedItems.Add(nameof(Insta_Kill_Trigger));
                    OnPropertyChanged(nameof(Insta_Kill_Trigger));
                }
            }

            [DisplayName("Offset")]
            public long Insta_Kill_Trigger_offset { get; private set; }

            protected uint Unk_46_raw;
            public const string Unk_46_displayName = "Unk 46";
            public const int Unk_46_sortIndex = 1300;
            [SortOrder(Unk_46_sortIndex)]
            [DisplayName(Unk_46_displayName)]
            public virtual uint Unk_46 {
                get => Unk_46_raw;
                set {
                    if (Unk_46_raw == value) return;
                    Unk_46_raw = value;
                    ChangedItems.Add(nameof(Unk_46));
                    OnPropertyChanged(nameof(Unk_46));
                }
            }

            [DisplayName("Offset")]
            public long Unk_46_offset { get; private set; }

            protected ushort Unk_47_raw;
            public const string Unk_47_displayName = "Unk 47";
            public const int Unk_47_sortIndex = 1350;
            [SortOrder(Unk_47_sortIndex)]
            [DisplayName(Unk_47_displayName)]
            public virtual ushort Unk_47 {
                get => Unk_47_raw;
                set {
                    if (Unk_47_raw == value) return;
                    Unk_47_raw = value;
                    ChangedItems.Add(nameof(Unk_47));
                    OnPropertyChanged(nameof(Unk_47));
                }
            }

            [DisplayName("Offset")]
            public long Unk_47_offset { get; private set; }

            protected float Entity_Collide_1_raw;
            public const string Entity_Collide_1_displayName = "Entity: Collide 1";
            public const int Entity_Collide_1_sortIndex = 1400;
            [SortOrder(Entity_Collide_1_sortIndex)]
            [DisplayName(Entity_Collide_1_displayName)]
            public virtual float Entity_Collide_1 {
                get => Entity_Collide_1_raw;
                set {
                    if (Entity_Collide_1_raw == value) return;
                    Entity_Collide_1_raw = value;
                    ChangedItems.Add(nameof(Entity_Collide_1));
                    OnPropertyChanged(nameof(Entity_Collide_1));
                }
            }

            [DisplayName("Offset")]
            public long Entity_Collide_1_offset { get; private set; }

            protected float Unk_48_raw;
            public const string Unk_48_displayName = "Unk 48";
            public const int Unk_48_sortIndex = 1450;
            [SortOrder(Unk_48_sortIndex)]
            [DisplayName(Unk_48_displayName)]
            public virtual float Unk_48 {
                get => Unk_48_raw;
                set {
                    if (Unk_48_raw == value) return;
                    Unk_48_raw = value;
                    ChangedItems.Add(nameof(Unk_48));
                    OnPropertyChanged(nameof(Unk_48));
                }
            }

            [DisplayName("Offset")]
            public long Unk_48_offset { get; private set; }

            protected float Unk_49_raw;
            public const string Unk_49_displayName = "Unk 49";
            public const int Unk_49_sortIndex = 1500;
            [SortOrder(Unk_49_sortIndex)]
            [DisplayName(Unk_49_displayName)]
            public virtual float Unk_49 {
                get => Unk_49_raw;
                set {
                    if (Unk_49_raw == value) return;
                    Unk_49_raw = value;
                    ChangedItems.Add(nameof(Unk_49));
                    OnPropertyChanged(nameof(Unk_49));
                }
            }

            [DisplayName("Offset")]
            public long Unk_49_offset { get; private set; }

            protected byte Entity_Collide_2_raw;
            public const string Entity_Collide_2_displayName = "Entity: Collide 2";
            public const int Entity_Collide_2_sortIndex = 1550;
            [SortOrder(Entity_Collide_2_sortIndex)]
            [DisplayName(Entity_Collide_2_displayName)]
            public virtual byte Entity_Collide_2 {
                get => Entity_Collide_2_raw;
                set {
                    if (Entity_Collide_2_raw == value) return;
                    Entity_Collide_2_raw = value;
                    ChangedItems.Add(nameof(Entity_Collide_2));
                    OnPropertyChanged(nameof(Entity_Collide_2));
                }
            }

            [DisplayName("Offset")]
            public long Entity_Collide_2_offset { get; private set; }

            protected byte Unk_50_raw;
            public const string Unk_50_displayName = "Unk 50";
            public const int Unk_50_sortIndex = 1600;
            [SortOrder(Unk_50_sortIndex)]
            [DisplayName(Unk_50_displayName)]
            public virtual byte Unk_50 {
                get => Unk_50_raw;
                set {
                    if (Unk_50_raw == value) return;
                    Unk_50_raw = value;
                    ChangedItems.Add(nameof(Unk_50));
                    OnPropertyChanged(nameof(Unk_50));
                }
            }

            [DisplayName("Offset")]
            public long Unk_50_offset { get; private set; }

            protected byte Entity_Spawn_Location_raw;
            public const string Entity_Spawn_Location_displayName = "Entity: Spawn Location";
            public const int Entity_Spawn_Location_sortIndex = 1650;
            [SortOrder(Entity_Spawn_Location_sortIndex)]
            [DisplayName(Entity_Spawn_Location_displayName)]
            public virtual byte Entity_Spawn_Location {
                get => Entity_Spawn_Location_raw;
                set {
                    if (Entity_Spawn_Location_raw == value) return;
                    Entity_Spawn_Location_raw = value;
                    ChangedItems.Add(nameof(Entity_Spawn_Location));
                    OnPropertyChanged(nameof(Entity_Spawn_Location));
                }
            }

            [DisplayName("Offset")]
            public long Entity_Spawn_Location_offset { get; private set; }

            protected byte Entity_Range_raw;
            public const string Entity_Range_displayName = "Entity: Range";
            public const int Entity_Range_sortIndex = 1700;
            [SortOrder(Entity_Range_sortIndex)]
            [DisplayName(Entity_Range_displayName)]
            public virtual byte Entity_Range {
                get => Entity_Range_raw;
                set {
                    if (Entity_Range_raw == value) return;
                    Entity_Range_raw = value;
                    ChangedItems.Add(nameof(Entity_Range));
                    OnPropertyChanged(nameof(Entity_Range));
                }
            }

            [DisplayName("Offset")]
            public long Entity_Range_offset { get; private set; }

            protected byte Unk_51_raw;
            public const string Unk_51_displayName = "Unk 51";
            public const int Unk_51_sortIndex = 1750;
            [SortOrder(Unk_51_sortIndex)]
            [DisplayName(Unk_51_displayName)]
            public virtual byte Unk_51 {
                get => Unk_51_raw;
                set {
                    if (Unk_51_raw == value) return;
                    Unk_51_raw = value;
                    ChangedItems.Add(nameof(Unk_51));
                    OnPropertyChanged(nameof(Unk_51));
                }
            }

            [DisplayName("Offset")]
            public long Unk_51_offset { get; private set; }

            protected byte Unk_52_raw;
            public const string Unk_52_displayName = "Unk 52";
            public const int Unk_52_sortIndex = 1800;
            [SortOrder(Unk_52_sortIndex)]
            [DisplayName(Unk_52_displayName)]
            public virtual byte Unk_52 {
                get => Unk_52_raw;
                set {
                    if (Unk_52_raw == value) return;
                    Unk_52_raw = value;
                    ChangedItems.Add(nameof(Unk_52));
                    OnPropertyChanged(nameof(Unk_52));
                }
            }

            [DisplayName("Offset")]
            public long Unk_52_offset { get; private set; }

            protected ushort Unk_53_raw;
            public const string Unk_53_displayName = "Unk 53";
            public const int Unk_53_sortIndex = 1850;
            [SortOrder(Unk_53_sortIndex)]
            [DisplayName(Unk_53_displayName)]
            public virtual ushort Unk_53 {
                get => Unk_53_raw;
                set {
                    if (Unk_53_raw == value) return;
                    Unk_53_raw = value;
                    ChangedItems.Add(nameof(Unk_53));
                    OnPropertyChanged(nameof(Unk_53));
                }
            }

            [DisplayName("Offset")]
            public long Unk_53_offset { get; private set; }

            protected uint Unk_54_raw;
            public const string Unk_54_displayName = "Unk 54";
            public const int Unk_54_sortIndex = 1900;
            [SortOrder(Unk_54_sortIndex)]
            [DisplayName(Unk_54_displayName)]
            public virtual uint Unk_54 {
                get => Unk_54_raw;
                set {
                    if (Unk_54_raw == value) return;
                    Unk_54_raw = value;
                    ChangedItems.Add(nameof(Unk_54));
                    OnPropertyChanged(nameof(Unk_54));
                }
            }

            [DisplayName("Offset")]
            public long Unk_54_offset { get; private set; }

            public const int lastSortIndex = 1950;

            public static ObservableMhwStructCollection<Shlp_2_> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Shlp_2_>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Shlp_2_ LoadData(BinaryReader reader, ulong i) {
                var data = new Shlp_2_();
                data.Index = i;
                data.Header_offset = reader.BaseStream.Position;
                data.Header_raw = reader.ReadUInt32();
                data.Projectile_Entity_Collider_offset = reader.BaseStream.Position;
                data.Projectile_Entity_Collider_raw = reader.ReadUInt32();
                data.Projectile_Model_Lifespan_offset = reader.BaseStream.Position;
                data.Projectile_Model_Lifespan_raw = reader.ReadSingle();
                data.Projectile_Distance_Range_offset = reader.BaseStream.Position;
                data.Projectile_Distance_Range_raw = reader.ReadInt32();
                data.Unk_35_offset = reader.BaseStream.Position;
                data.Unk_35_raw = reader.ReadByte();
                data.Unk_36_offset = reader.BaseStream.Position;
                data.Unk_36_raw = reader.ReadByte();
                data.Unk_37_offset = reader.BaseStream.Position;
                data.Unk_37_raw = reader.ReadByte();
                data.Unk_38_offset = reader.BaseStream.Position;
                data.Unk_38_raw = reader.ReadByte();
                data.Unk_39_offset = reader.BaseStream.Position;
                data.Unk_39_raw = reader.ReadUInt32();
                data.Unk_40_offset = reader.BaseStream.Position;
                data.Unk_40_raw = reader.ReadUInt32();
                data.Unk_41_offset = reader.BaseStream.Position;
                data.Unk_41_raw = reader.ReadUInt32();
                data.Projectile_Spawn_Pos_Y_offset = reader.BaseStream.Position;
                data.Projectile_Spawn_Pos_Y_raw = reader.ReadSingle();
                data.Projectile_Spawn_Pos_X_offset = reader.BaseStream.Position;
                data.Projectile_Spawn_Pos_X_raw = reader.ReadSingle();
                data.Projectile_Velocity_offset = reader.BaseStream.Position;
                data.Projectile_Velocity_raw = reader.ReadSingle();
                data.Projectile_Falloff_offset = reader.BaseStream.Position;
                data.Projectile_Falloff_raw = reader.ReadSingle();
                data.Unk_42_offset = reader.BaseStream.Position;
                data.Unk_42_raw = reader.ReadSingle();
                data.Unk_43_offset = reader.BaseStream.Position;
                data.Unk_43_raw = reader.ReadSingle();
                data.Unk_44_offset = reader.BaseStream.Position;
                data.Unk_44_raw = reader.ReadSingle();
                data.Angle_Unk_1_offset = reader.BaseStream.Position;
                data.Angle_Unk_1_raw = reader.ReadSingle();
                data.Angle_Unk_2_offset = reader.BaseStream.Position;
                data.Angle_Unk_2_raw = reader.ReadSingle();
                data.Angle_Unk_3_offset = reader.BaseStream.Position;
                data.Angle_Unk_3_raw = reader.ReadSingle();
                data.Angle_Unk_4_offset = reader.BaseStream.Position;
                data.Angle_Unk_4_raw = reader.ReadSingle();
                data.Projectile_Hitbox_Range_offset = reader.BaseStream.Position;
                data.Projectile_Hitbox_Range_raw = reader.ReadSingle();
                data.Unk_45_offset = reader.BaseStream.Position;
                data.Unk_45_raw = reader.ReadUInt32();
                data.Insta_Kill_Trigger_offset = reader.BaseStream.Position;
                data.Insta_Kill_Trigger_raw = reader.ReadUInt32();
                data.Unk_46_offset = reader.BaseStream.Position;
                data.Unk_46_raw = reader.ReadUInt32();
                data.Unk_47_offset = reader.BaseStream.Position;
                data.Unk_47_raw = reader.ReadUInt16();
                data.Entity_Collide_1_offset = reader.BaseStream.Position;
                data.Entity_Collide_1_raw = reader.ReadSingle();
                data.Unk_48_offset = reader.BaseStream.Position;
                data.Unk_48_raw = reader.ReadSingle();
                data.Unk_49_offset = reader.BaseStream.Position;
                data.Unk_49_raw = reader.ReadSingle();
                data.Entity_Collide_2_offset = reader.BaseStream.Position;
                data.Entity_Collide_2_raw = reader.ReadByte();
                data.Unk_50_offset = reader.BaseStream.Position;
                data.Unk_50_raw = reader.ReadByte();
                data.Entity_Spawn_Location_offset = reader.BaseStream.Position;
                data.Entity_Spawn_Location_raw = reader.ReadByte();
                data.Entity_Range_offset = reader.BaseStream.Position;
                data.Entity_Range_raw = reader.ReadByte();
                data.Unk_51_offset = reader.BaseStream.Position;
                data.Unk_51_raw = reader.ReadByte();
                data.Unk_52_offset = reader.BaseStream.Position;
                data.Unk_52_raw = reader.ReadByte();
                data.Unk_53_offset = reader.BaseStream.Position;
                data.Unk_53_raw = reader.ReadUInt16();
                data.Unk_54_offset = reader.BaseStream.Position;
                data.Unk_54_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Header_raw);
                writer.Write(Projectile_Entity_Collider_raw);
                writer.Write(Projectile_Model_Lifespan_raw);
                writer.Write(Projectile_Distance_Range_raw);
                writer.Write(Unk_35_raw);
                writer.Write(Unk_36_raw);
                writer.Write(Unk_37_raw);
                writer.Write(Unk_38_raw);
                writer.Write(Unk_39_raw);
                writer.Write(Unk_40_raw);
                writer.Write(Unk_41_raw);
                writer.Write(Projectile_Spawn_Pos_Y_raw);
                writer.Write(Projectile_Spawn_Pos_X_raw);
                writer.Write(Projectile_Velocity_raw);
                writer.Write(Projectile_Falloff_raw);
                writer.Write(Unk_42_raw);
                writer.Write(Unk_43_raw);
                writer.Write(Unk_44_raw);
                writer.Write(Angle_Unk_1_raw);
                writer.Write(Angle_Unk_2_raw);
                writer.Write(Angle_Unk_3_raw);
                writer.Write(Angle_Unk_4_raw);
                writer.Write(Projectile_Hitbox_Range_raw);
                writer.Write(Unk_45_raw);
                writer.Write(Insta_Kill_Trigger_raw);
                writer.Write(Unk_46_raw);
                writer.Write(Unk_47_raw);
                writer.Write(Entity_Collide_1_raw);
                writer.Write(Unk_48_raw);
                writer.Write(Unk_49_raw);
                writer.Write(Entity_Collide_2_raw);
                writer.Write(Unk_50_raw);
                writer.Write(Entity_Spawn_Location_raw);
                writer.Write(Entity_Range_raw);
                writer.Write(Unk_51_raw);
                writer.Write(Unk_52_raw);
                writer.Write(Unk_53_raw);
                writer.Write(Unk_54_raw);
            }

            public ObservableCollection<MultiStructItemCustomView> GetCustomView() {
                return new ObservableCollection<MultiStructItemCustomView> {
                    new MultiStructItemCustomView(this, "Header", "Header", "Header_offset"),
                    new MultiStructItemCustomView(this, "Projectile: Entity Collider", "Projectile_Entity_Collider", "Projectile_Entity_Collider_offset"),
                    new MultiStructItemCustomView(this, "Projectile: Model Lifespan", "Projectile_Model_Lifespan", "Projectile_Model_Lifespan_offset"),
                    new MultiStructItemCustomView(this, "Projectile: Distance Range", "Projectile_Distance_Range", "Projectile_Distance_Range_offset"),
                    new MultiStructItemCustomView(this, "Unk 35", "Unk_35", "Unk_35_offset"),
                    new MultiStructItemCustomView(this, "Unk 36", "Unk_36", "Unk_36_offset"),
                    new MultiStructItemCustomView(this, "Unk 37", "Unk_37", "Unk_37_offset"),
                    new MultiStructItemCustomView(this, "Unk 38", "Unk_38", "Unk_38_offset"),
                    new MultiStructItemCustomView(this, "Unk 39", "Unk_39", "Unk_39_offset"),
                    new MultiStructItemCustomView(this, "Unk 40", "Unk_40", "Unk_40_offset"),
                    new MultiStructItemCustomView(this, "Unk 41", "Unk_41", "Unk_41_offset"),
                    new MultiStructItemCustomView(this, "Projectile: Spawn Pos Y", "Projectile_Spawn_Pos_Y", "Projectile_Spawn_Pos_Y_offset"),
                    new MultiStructItemCustomView(this, "Projectile: Spawn Pos X", "Projectile_Spawn_Pos_X", "Projectile_Spawn_Pos_X_offset"),
                    new MultiStructItemCustomView(this, "Projectile: Velocity", "Projectile_Velocity", "Projectile_Velocity_offset"),
                    new MultiStructItemCustomView(this, "Projectile: Falloff", "Projectile_Falloff", "Projectile_Falloff_offset"),
                    new MultiStructItemCustomView(this, "Unk 42", "Unk_42", "Unk_42_offset"),
                    new MultiStructItemCustomView(this, "Unk 43", "Unk_43", "Unk_43_offset"),
                    new MultiStructItemCustomView(this, "Unk 44", "Unk_44", "Unk_44_offset"),
                    new MultiStructItemCustomView(this, "Angle Unk 1", "Angle_Unk_1", "Angle_Unk_1_offset"),
                    new MultiStructItemCustomView(this, "Angle Unk 2", "Angle_Unk_2", "Angle_Unk_2_offset"),
                    new MultiStructItemCustomView(this, "Angle Unk 3", "Angle_Unk_3", "Angle_Unk_3_offset"),
                    new MultiStructItemCustomView(this, "Angle Unk 4", "Angle_Unk_4", "Angle_Unk_4_offset"),
                    new MultiStructItemCustomView(this, "Projectile: Hitbox Range", "Projectile_Hitbox_Range", "Projectile_Hitbox_Range_offset"),
                    new MultiStructItemCustomView(this, "Unk 45", "Unk_45", "Unk_45_offset"),
                    new MultiStructItemCustomView(this, "Insta-Kill Trigger", "Insta_Kill_Trigger", "Insta_Kill_Trigger_offset"),
                    new MultiStructItemCustomView(this, "Unk 46", "Unk_46", "Unk_46_offset"),
                    new MultiStructItemCustomView(this, "Unk 47", "Unk_47", "Unk_47_offset"),
                    new MultiStructItemCustomView(this, "Entity: Collide 1", "Entity_Collide_1", "Entity_Collide_1_offset"),
                    new MultiStructItemCustomView(this, "Unk 48", "Unk_48", "Unk_48_offset"),
                    new MultiStructItemCustomView(this, "Unk 49", "Unk_49", "Unk_49_offset"),
                    new MultiStructItemCustomView(this, "Entity: Collide 2", "Entity_Collide_2", "Entity_Collide_2_offset"),
                    new MultiStructItemCustomView(this, "Unk 50", "Unk_50", "Unk_50_offset"),
                    new MultiStructItemCustomView(this, "Entity: Spawn Location", "Entity_Spawn_Location", "Entity_Spawn_Location_offset"),
                    new MultiStructItemCustomView(this, "Entity: Range", "Entity_Range", "Entity_Range_offset"),
                    new MultiStructItemCustomView(this, "Unk 51", "Unk_51", "Unk_51_offset"),
                    new MultiStructItemCustomView(this, "Unk 52", "Unk_52", "Unk_52_offset"),
                    new MultiStructItemCustomView(this, "Unk 53", "Unk_53", "Unk_53_offset"),
                    new MultiStructItemCustomView(this, "Unk 54", "Unk_54", "Unk_54_offset"),
                };
            }
        }

        public partial class Number_of_Modifiers_Holder : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Number of Modifiers Holder";
            public const bool IsHidden = true;

            protected uint Number_of_Modifiers_raw;
            public const string Number_of_Modifiers_displayName = "Number of Modifiers";
            public const int Number_of_Modifiers_sortIndex = 50;
            [SortOrder(Number_of_Modifiers_sortIndex)]
            [DisplayName(Number_of_Modifiers_displayName)]
            [IsReadOnly]
            public virtual uint Number_of_Modifiers {
                get => Number_of_Modifiers_raw;
                set {
                    if (Number_of_Modifiers_raw == value) return;
                    Number_of_Modifiers_raw = value;
                    ChangedItems.Add(nameof(Number_of_Modifiers));
                    OnPropertyChanged(nameof(Number_of_Modifiers));
                }
            }

            public const int lastSortIndex = 100;

            public static ObservableMhwStructCollection<Number_of_Modifiers_Holder> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Number_of_Modifiers_Holder>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Number_of_Modifiers_Holder LoadData(BinaryReader reader, ulong i) {
                var data = new Number_of_Modifiers_Holder();
                data.Index = i;
                data.Number_of_Modifiers_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Number_of_Modifiers_raw);
            }
        }

        public partial class Modifiers : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 0;
            public const string GridName = "Modifiers";
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
                    ChangedItems.Add(nameof(Header));
                    OnPropertyChanged(nameof(Header));
                }
            }

            protected sbyte Value_1_if_412627386__raw;
            public const string Value_1_if_412627386__displayName = "Value 1 (if 412627386)";
            public const int Value_1_if_412627386__sortIndex = 100;
            [SortOrder(Value_1_if_412627386__sortIndex)]
            [DisplayName(Value_1_if_412627386__displayName)]
            public virtual sbyte Value_1_if_412627386_ {
                get => Value_1_if_412627386__raw;
                set {
                    if (Value_1_if_412627386__raw == value) return;
                    Value_1_if_412627386__raw = value;
                    ChangedItems.Add(nameof(Value_1_if_412627386_));
                    OnPropertyChanged(nameof(Value_1_if_412627386_));
                }
            }

            protected sbyte Value_2_if_412627386__raw;
            public const string Value_2_if_412627386__displayName = "Value 2 (if 412627386)";
            public const int Value_2_if_412627386__sortIndex = 150;
            [SortOrder(Value_2_if_412627386__sortIndex)]
            [DisplayName(Value_2_if_412627386__displayName)]
            public virtual sbyte Value_2_if_412627386_ {
                get => Value_2_if_412627386__raw;
                set {
                    if (Value_2_if_412627386__raw == value) return;
                    Value_2_if_412627386__raw = value;
                    ChangedItems.Add(nameof(Value_2_if_412627386_));
                    OnPropertyChanged(nameof(Value_2_if_412627386_));
                }
            }

            protected sbyte Value_3_if_412627386__raw;
            public const string Value_3_if_412627386__displayName = "Value 3 (if 412627386)";
            public const int Value_3_if_412627386__sortIndex = 200;
            [SortOrder(Value_3_if_412627386__sortIndex)]
            [DisplayName(Value_3_if_412627386__displayName)]
            public virtual sbyte Value_3_if_412627386_ {
                get => Value_3_if_412627386__raw;
                set {
                    if (Value_3_if_412627386__raw == value) return;
                    Value_3_if_412627386__raw = value;
                    ChangedItems.Add(nameof(Value_3_if_412627386_));
                    OnPropertyChanged(nameof(Value_3_if_412627386_));
                }
            }

            protected sbyte Value_4_if_412627386__raw;
            public const string Value_4_if_412627386__displayName = "Value 4 (if 412627386)";
            public const int Value_4_if_412627386__sortIndex = 250;
            [SortOrder(Value_4_if_412627386__sortIndex)]
            [DisplayName(Value_4_if_412627386__displayName)]
            public virtual sbyte Value_4_if_412627386_ {
                get => Value_4_if_412627386__raw;
                set {
                    if (Value_4_if_412627386__raw == value) return;
                    Value_4_if_412627386__raw = value;
                    ChangedItems.Add(nameof(Value_4_if_412627386_));
                    OnPropertyChanged(nameof(Value_4_if_412627386_));
                }
            }

            protected int Value_if_3289971__raw;
            public const string Value_if_3289971__displayName = "Value (if 3289971)";
            public const int Value_if_3289971__sortIndex = 300;
            [SortOrder(Value_if_3289971__sortIndex)]
            [DisplayName(Value_if_3289971__displayName)]
            public virtual int Value_if_3289971_ {
                get => Value_if_3289971__raw;
                set {
                    if (Value_if_3289971__raw == value) return;
                    Value_if_3289971__raw = value;
                    ChangedItems.Add(nameof(Value_if_3289971_));
                    OnPropertyChanged(nameof(Value_if_3289971_));
                }
            }

            protected float Value_if_79120377__raw;
            public const string Value_if_79120377__displayName = "Value (if 79120377)";
            public const int Value_if_79120377__sortIndex = 350;
            [SortOrder(Value_if_79120377__sortIndex)]
            [DisplayName(Value_if_79120377__displayName)]
            public virtual float Value_if_79120377_ {
                get => Value_if_79120377__raw;
                set {
                    if (Value_if_79120377__raw == value) return;
                    Value_if_79120377__raw = value;
                    ChangedItems.Add(nameof(Value_if_79120377_));
                    OnPropertyChanged(nameof(Value_if_79120377_));
                }
            }

            protected sbyte Value_if_306780182__raw;
            public const string Value_if_306780182__displayName = "Value (if 306780182)";
            public const int Value_if_306780182__sortIndex = 400;
            [SortOrder(Value_if_306780182__sortIndex)]
            [DisplayName(Value_if_306780182__displayName)]
            public virtual sbyte Value_if_306780182_ {
                get => Value_if_306780182__raw;
                set {
                    if (Value_if_306780182__raw == value) return;
                    Value_if_306780182__raw = value;
                    ChangedItems.Add(nameof(Value_if_306780182_));
                    OnPropertyChanged(nameof(Value_if_306780182_));
                }
            }

            protected float Value_X_if_1335056316__raw;
            public const string Value_X_if_1335056316__displayName = "Value X (if 1335056316)";
            public const int Value_X_if_1335056316__sortIndex = 450;
            [SortOrder(Value_X_if_1335056316__sortIndex)]
            [DisplayName(Value_X_if_1335056316__displayName)]
            public virtual float Value_X_if_1335056316_ {
                get => Value_X_if_1335056316__raw;
                set {
                    if (Value_X_if_1335056316__raw == value) return;
                    Value_X_if_1335056316__raw = value;
                    ChangedItems.Add(nameof(Value_X_if_1335056316_));
                    OnPropertyChanged(nameof(Value_X_if_1335056316_));
                }
            }

            protected float Value_Y_if_1335056316__raw;
            public const string Value_Y_if_1335056316__displayName = "Value Y (if 1335056316)";
            public const int Value_Y_if_1335056316__sortIndex = 500;
            [SortOrder(Value_Y_if_1335056316__sortIndex)]
            [DisplayName(Value_Y_if_1335056316__displayName)]
            public virtual float Value_Y_if_1335056316_ {
                get => Value_Y_if_1335056316__raw;
                set {
                    if (Value_Y_if_1335056316__raw == value) return;
                    Value_Y_if_1335056316__raw = value;
                    ChangedItems.Add(nameof(Value_Y_if_1335056316_));
                    OnPropertyChanged(nameof(Value_Y_if_1335056316_));
                }
            }

            protected float Value_Z_if_1335056316__raw;
            public const string Value_Z_if_1335056316__displayName = "Value Z (if 1335056316)";
            public const int Value_Z_if_1335056316__sortIndex = 550;
            [SortOrder(Value_Z_if_1335056316__sortIndex)]
            [DisplayName(Value_Z_if_1335056316__displayName)]
            public virtual float Value_Z_if_1335056316_ {
                get => Value_Z_if_1335056316__raw;
                set {
                    if (Value_Z_if_1335056316__raw == value) return;
                    Value_Z_if_1335056316__raw = value;
                    ChangedItems.Add(nameof(Value_Z_if_1335056316_));
                    OnPropertyChanged(nameof(Value_Z_if_1335056316_));
                }
            }

            protected float Value_Unk_if_1335056316__raw;
            public const string Value_Unk_if_1335056316__displayName = "Value Unk (if 1335056316)";
            public const int Value_Unk_if_1335056316__sortIndex = 600;
            [SortOrder(Value_Unk_if_1335056316__sortIndex)]
            [DisplayName(Value_Unk_if_1335056316__displayName)]
            public virtual float Value_Unk_if_1335056316_ {
                get => Value_Unk_if_1335056316__raw;
                set {
                    if (Value_Unk_if_1335056316__raw == value) return;
                    Value_Unk_if_1335056316__raw = value;
                    ChangedItems.Add(nameof(Value_Unk_if_1335056316_));
                    OnPropertyChanged(nameof(Value_Unk_if_1335056316_));
                }
            }

            protected string Name_raw;
            public const string Name_displayName = "Name";
            public const int Name_sortIndex = 650;
            [SortOrder(Name_sortIndex)]
            [DisplayName(Name_displayName)]
            public virtual string Name {
                get => Name_raw;
                set {
                    if (Name_raw == value) return;
                    Name_raw = value;
                    ChangedItems.Add(nameof(Name));
                    OnPropertyChanged(nameof(Name));
                }
            }

            protected uint Unk_1_raw;
            public const string Unk_1_displayName = "Unk 1";
            public const int Unk_1_sortIndex = 700;
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

            protected string DataType_raw;
            public const string DataType_displayName = "DataType";
            public const int DataType_sortIndex = 750;
            [SortOrder(DataType_sortIndex)]
            [DisplayName(DataType_displayName)]
            public virtual string DataType {
                get => DataType_raw;
                set {
                    if (DataType_raw == value) return;
                    DataType_raw = value;
                    ChangedItems.Add(nameof(DataType));
                    OnPropertyChanged(nameof(DataType));
                }
            }

            protected uint Unk_2_raw;
            public const string Unk_2_displayName = "Unk 2";
            public const int Unk_2_sortIndex = 800;
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

            protected uint Unk_3_raw;
            public const string Unk_3_displayName = "Unk 3";
            public const int Unk_3_sortIndex = 850;
            [SortOrder(Unk_3_sortIndex)]
            [DisplayName(Unk_3_displayName)]
            public virtual uint Unk_3 {
                get => Unk_3_raw;
                set {
                    if (Unk_3_raw == value) return;
                    Unk_3_raw = value;
                    ChangedItems.Add(nameof(Unk_3));
                    OnPropertyChanged(nameof(Unk_3));
                }
            }

            protected uint Unk_4_raw;
            public const string Unk_4_displayName = "Unk 4";
            public const int Unk_4_sortIndex = 900;
            [SortOrder(Unk_4_sortIndex)]
            [DisplayName(Unk_4_displayName)]
            public virtual uint Unk_4 {
                get => Unk_4_raw;
                set {
                    if (Unk_4_raw == value) return;
                    Unk_4_raw = value;
                    ChangedItems.Add(nameof(Unk_4));
                    OnPropertyChanged(nameof(Unk_4));
                }
            }

            protected byte Unk_5_raw;
            public const string Unk_5_displayName = "Unk 5";
            public const int Unk_5_sortIndex = 950;
            [SortOrder(Unk_5_sortIndex)]
            [DisplayName(Unk_5_displayName)]
            public virtual byte Unk_5 {
                get => Unk_5_raw;
                set {
                    if (Unk_5_raw == value) return;
                    Unk_5_raw = value;
                    ChangedItems.Add(nameof(Unk_5));
                    OnPropertyChanged(nameof(Unk_5));
                }
            }

            public const int lastSortIndex = 1000;

            public static ObservableMhwStructCollection<Modifiers> LoadData(BinaryReader reader, ObservableMhwStructCollection<Number_of_Modifiers_Holder> lastStruct) {
                var list = new ObservableMhwStructCollection<Modifiers>();
                var countTarget = (Number_of_Modifiers_Holder) lastStruct.Last();
                var count = (ulong) countTarget.Number_of_Modifiers;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Modifiers LoadData(BinaryReader reader, ulong i) {
                var data = new Modifiers();
                data.Index = i;
                data.Header_raw = reader.ReadUInt32();
                if (data.Header_raw == 412627386) data.Value_1_if_412627386__raw = reader.ReadSByte();
                if (data.Header_raw == 412627386) data.Value_2_if_412627386__raw = reader.ReadSByte();
                if (data.Header_raw == 412627386) data.Value_3_if_412627386__raw = reader.ReadSByte();
                if (data.Header_raw == 412627386) data.Value_4_if_412627386__raw = reader.ReadSByte();
                if (data.Header_raw == 3289971) data.Value_if_3289971__raw = reader.ReadInt32();
                if (data.Header_raw == 79120377) data.Value_if_79120377__raw = reader.ReadSingle();
                if (data.Header_raw == 306780182) data.Value_if_306780182__raw = reader.ReadSByte();
                if (data.Header_raw == 1335056316) data.Value_X_if_1335056316__raw = reader.ReadSingle();
                if (data.Header_raw == 1335056316) data.Value_Y_if_1335056316__raw = reader.ReadSingle();
                if (data.Header_raw == 1335056316) data.Value_Z_if_1335056316__raw = reader.ReadSingle();
                if (data.Header_raw == 1335056316) data.Value_Unk_if_1335056316__raw = reader.ReadSingle();
                data.Name_raw = reader.ReadNullTermString();
                data.Unk_1_raw = reader.ReadUInt32();
                data.DataType_raw = reader.ReadNullTermString();
                data.Unk_2_raw = reader.ReadUInt32();
                data.Unk_3_raw = reader.ReadUInt32();
                data.Unk_4_raw = reader.ReadUInt32();
                data.Unk_5_raw = reader.ReadByte();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Header_raw);
                if (Header_raw == 412627386) writer.Write(Value_1_if_412627386__raw);
                if (Header_raw == 412627386) writer.Write(Value_2_if_412627386__raw);
                if (Header_raw == 412627386) writer.Write(Value_3_if_412627386__raw);
                if (Header_raw == 412627386) writer.Write(Value_4_if_412627386__raw);
                if (Header_raw == 3289971) writer.Write(Value_if_3289971__raw);
                if (Header_raw == 79120377) writer.Write(Value_if_79120377__raw);
                if (Header_raw == 306780182) writer.Write(Value_if_306780182__raw);
                if (Header_raw == 1335056316) writer.Write(Value_X_if_1335056316__raw);
                if (Header_raw == 1335056316) writer.Write(Value_Y_if_1335056316__raw);
                if (Header_raw == 1335056316) writer.Write(Value_Z_if_1335056316__raw);
                if (Header_raw == 1335056316) writer.Write(Value_Unk_if_1335056316__raw);
                writer.Write(Name_raw.ToNullTermCharArray());
                writer.Write(Unk_1_raw);
                writer.Write(DataType_raw.ToNullTermCharArray());
                writer.Write(Unk_2_raw);
                writer.Write(Unk_3_raw);
                writer.Write(Unk_4_raw);
                writer.Write(Unk_5_raw);
            }
        }

        public partial class Unknown : MhwStructItem, IWriteData {
            public const ulong FixedSizeCount = 1;
            public const string GridName = "Unknown";

            protected uint Unk_55_raw;
            public const string Unk_55_displayName = "Unk 55";
            public const int Unk_55_sortIndex = 50;
            [SortOrder(Unk_55_sortIndex)]
            [DisplayName(Unk_55_displayName)]
            public virtual uint Unk_55 {
                get => Unk_55_raw;
                set {
                    if (Unk_55_raw == value) return;
                    Unk_55_raw = value;
                    ChangedItems.Add(nameof(Unk_55));
                    OnPropertyChanged(nameof(Unk_55));
                }
            }

            public const int lastSortIndex = 100;

            public static ObservableMhwStructCollection<Unknown> LoadData(BinaryReader reader) {
                var list = new ObservableMhwStructCollection<Unknown>();
                var count = 1UL;
                for (ulong i = 0; i < count; i++) {
                    list.Add(LoadData(reader, i));
                }
                return list;
            }

            public static Unknown LoadData(BinaryReader reader, ulong i) {
                var data = new Unknown();
                data.Index = i;
                data.Unk_55_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Unk_55_raw);
            }
        }

        public override void LoadFile(string targetFile) {
            using var reader = new BinaryReader(OpenFile(targetFile, EncryptionKey), Encoding.UTF8);
            data = new LinkedList<MhwStructDataContainer>();
            var Shlp_ = new MhwStructDataContainer<Shlp>(Shlp.LoadData(reader), typeof(Shlp));
            data.AddLast(Shlp_);
            var Assets_ = new MhwStructDataContainer<Assets>(Assets.LoadData(reader), typeof(Assets));
            data.AddLast(Assets_);
            var Shlp_1__ = new MhwStructDataContainer<Shlp_1_>(Shlp_1_.LoadData(reader), typeof(Shlp_1_));
            data.AddLast(Shlp_1__);
            var Number_of_Linked_Shell_Params_Holder_ = new MhwStructDataContainer<Number_of_Linked_Shell_Params_Holder>(Number_of_Linked_Shell_Params_Holder.LoadData(reader), typeof(Number_of_Linked_Shell_Params_Holder));
            data.AddLast(Number_of_Linked_Shell_Params_Holder_);
            var Child_Shell_Params_ = new MhwStructDataContainer<Child_Shell_Params, Number_of_Linked_Shell_Params_Holder>(Child_Shell_Params.LoadData(reader, Number_of_Linked_Shell_Params_Holder_.list), typeof(Child_Shell_Params));
            Child_Shell_Params_.SetCountTargetToUpdate(Number_of_Linked_Shell_Params_Holder_, -1, "Number_of_Linked_Shell_Params");
            data.AddLast(Child_Shell_Params_);
            var EPV_ = new MhwStructDataContainer<EPV>(EPV.LoadData(reader), typeof(EPV));
            data.AddLast(EPV_);
            var Sound_ = new MhwStructDataContainer<Sound>(Sound.LoadData(reader), typeof(Sound));
            data.AddLast(Sound_);
            var Shlp_2__ = new MhwStructDataContainer<Shlp_2_>(Shlp_2_.LoadData(reader), typeof(Shlp_2_));
            data.AddLast(Shlp_2__);
            var Number_of_Modifiers_Holder_ = new MhwStructDataContainer<Number_of_Modifiers_Holder>(Number_of_Modifiers_Holder.LoadData(reader), typeof(Number_of_Modifiers_Holder));
            data.AddLast(Number_of_Modifiers_Holder_);
            var Modifiers_ = new MhwStructDataContainer<Modifiers, Number_of_Modifiers_Holder>(Modifiers.LoadData(reader, Number_of_Modifiers_Holder_.list), typeof(Modifiers));
            Modifiers_.SetCountTargetToUpdate(Number_of_Modifiers_Holder_, -1, "Number_of_Modifiers");
            data.AddLast(Modifiers_);
            var Unknown_ = new MhwStructDataContainer<Unknown>(Unknown.LoadData(reader), typeof(Unknown));
            data.AddLast(Unknown_);
        }
    }
}
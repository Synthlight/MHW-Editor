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

namespace MHW_Editor.Structs.Items {
    public partial class Item {
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
            public override string UniqueId => "{Id}";

            protected uint Id_raw;
            public const string Id_displayName = "Id";
            public const int Id_sortIndex = 50;
            [SortOrder(Id_sortIndex)]
            [DisplayName(Id_displayName)]
            [IsReadOnly]
            public virtual uint Id {
                get => Id_raw;
                set {
                    if (Id_raw == value) return;
                    Id_raw = value;
                    OnPropertyChanged(nameof(Id));
                }
            }

            protected byte Sub_Type_raw;
            public const string Sub_Type_displayName = "Sub Type";
            public const int Sub_Type_sortIndex = 100;
            [SortOrder(Sub_Type_sortIndex)]
            [DisplayName(Sub_Type_displayName)]
            public virtual MHW_Template.Items.ItemSubType Sub_Type {
                get => (MHW_Template.Items.ItemSubType) Sub_Type_raw;
                set {
                    if ((MHW_Template.Items.ItemSubType) Sub_Type_raw == value) return;
                    Sub_Type_raw = (byte) value;
                    OnPropertyChanged(nameof(Sub_Type));
                }
            }

            protected uint Type_raw;
            public const string Type_displayName = "Type";
            public const int Type_sortIndex = 150;
            [SortOrder(Type_sortIndex)]
            [DisplayName(Type_displayName)]
            public virtual MHW_Template.Items.ItemType Type {
                get => (MHW_Template.Items.ItemType) Type_raw;
                set {
                    if ((MHW_Template.Items.ItemType) Type_raw == value) return;
                    Type_raw = (uint) value;
                    OnPropertyChanged(nameof(Type));
                }
            }

            protected byte Rarity_raw;
            public const string Rarity_displayName = "Rarity";
            public const int Rarity_sortIndex = 200;
            [SortOrder(Rarity_sortIndex)]
            [DisplayName(Rarity_displayName)]
            public virtual byte Rarity {
                get => Rarity_raw;
                set {
                    if (Rarity_raw == value) return;
                    Rarity_raw = value;
                    OnPropertyChanged(nameof(Rarity));
                }
            }

            protected sbyte Carry_Limit_raw;
            public const string Carry_Limit_displayName = "Carry Limit";
            public const int Carry_Limit_sortIndex = 250;
            [SortOrder(Carry_Limit_sortIndex)]
            [DisplayName(Carry_Limit_displayName)]
            public virtual sbyte Carry_Limit {
                get => Carry_Limit_raw;
                set {
                    if (Carry_Limit_raw == value) return;
                    Carry_Limit_raw = value;
                    OnPropertyChanged(nameof(Carry_Limit));
                }
            }

            protected sbyte Unknown_sint8__raw;
            public const string Unknown_sint8__displayName = "Unknown (sint8)";
            public const int Unknown_sint8__sortIndex = 300;
            [SortOrder(Unknown_sint8__sortIndex)]
            [DisplayName(Unknown_sint8__displayName)]
            public virtual sbyte Unknown_sint8_ {
                get => Unknown_sint8__raw;
                set {
                    if (Unknown_sint8__raw == value) return;
                    Unknown_sint8__raw = value;
                    OnPropertyChanged(nameof(Unknown_sint8_));
                }
            }

            protected ushort Sort_Order_raw;
            public const string Sort_Order_displayName = "Sort Order";
            public const int Sort_Order_sortIndex = 350;
            [SortOrder(Sort_Order_sortIndex)]
            [DisplayName(Sort_Order_displayName)]
            public virtual ushort Sort_Order {
                get => Sort_Order_raw;
                set {
                    if (Sort_Order_raw == value) return;
                    Sort_Order_raw = value;
                    OnPropertyChanged(nameof(Sort_Order));
                }
            }

            protected uint Flags_Raw_raw;
            public const string Flags_Raw_displayName = "Flags Raw";
            [SortOrder(Flags_Raw_sortIndex)]
            [DisplayName(Flags_Raw_displayName)]
            private uint Flags_Raw {
                get => Flags_Raw_raw;
                set {
                    if (Flags_Raw_raw == value) return;
                    Flags_Raw_raw = value;
                    OnPropertyChanged(nameof(Flags_Raw));
                    OnPropertyChanged(nameof(Flags));
                }
            }

            protected uint Icon_Id_raw;
            public const string Icon_Id_displayName = "Icon Id";
            public const int Icon_Id_sortIndex = 450;
            [SortOrder(Icon_Id_sortIndex)]
            [DisplayName(Icon_Id_displayName)]
            public virtual uint Icon_Id {
                get => Icon_Id_raw;
                set {
                    if (Icon_Id_raw == value) return;
                    Icon_Id_raw = value;
                    OnPropertyChanged(nameof(Icon_Id));
                }
            }

            protected ushort Icon_Color_Id_raw;
            public const string Icon_Color_Id_displayName = "Icon Color Id";
            public const int Icon_Color_Id_sortIndex = 500;
            [SortOrder(Icon_Color_Id_sortIndex)]
            [DisplayName(Icon_Color_Id_displayName)]
            public virtual ushort Icon_Color_Id {
                get => Icon_Color_Id_raw;
                set {
                    if (Icon_Color_Id_raw == value) return;
                    Icon_Color_Id_raw = value;
                    OnPropertyChanged(nameof(Icon_Color_Id));
                }
            }

            protected uint Sell_Price_raw;
            public const string Sell_Price_displayName = "Sell Price";
            public const int Sell_Price_sortIndex = 550;
            [SortOrder(Sell_Price_sortIndex)]
            [DisplayName(Sell_Price_displayName)]
            public virtual uint Sell_Price {
                get => Sell_Price_raw;
                set {
                    if (Sell_Price_raw == value) return;
                    Sell_Price_raw = value;
                    OnPropertyChanged(nameof(Sell_Price));
                }
            }

            protected uint Buy_Price_raw;
            public const string Buy_Price_displayName = "Buy Price";
            public const int Buy_Price_sortIndex = 600;
            [SortOrder(Buy_Price_sortIndex)]
            [DisplayName(Buy_Price_displayName)]
            public virtual uint Buy_Price {
                get => Buy_Price_raw;
                set {
                    if (Buy_Price_raw == value) return;
                    Buy_Price_raw = value;
                    OnPropertyChanged(nameof(Buy_Price));
                }
            }

            public const int lastSortIndex = 650;

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
                data.Id_raw = reader.ReadUInt32();
                data.Sub_Type_raw = reader.ReadByte();
                data.Type_raw = reader.ReadUInt32();
                data.Rarity_raw = reader.ReadByte();
                data.Carry_Limit_raw = reader.ReadSByte();
                data.Unknown_sint8__raw = reader.ReadSByte();
                data.Sort_Order_raw = reader.ReadUInt16();
                data.Flags_Raw_raw = reader.ReadUInt32();
                data.Icon_Id_raw = reader.ReadUInt32();
                data.Icon_Color_Id_raw = reader.ReadUInt16();
                data.Sell_Price_raw = reader.ReadUInt32();
                data.Buy_Price_raw = reader.ReadUInt32();
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                writer.Write(Id_raw);
                writer.Write(Sub_Type_raw);
                writer.Write(Type_raw);
                writer.Write(Rarity_raw);
                writer.Write(Carry_Limit_raw);
                writer.Write(Unknown_sint8__raw);
                writer.Write(Sort_Order_raw);
                writer.Write(Flags_Raw_raw);
                writer.Write(Icon_Id_raw);
                writer.Write(Icon_Color_Id_raw);
                writer.Write(Sell_Price_raw);
                writer.Write(Buy_Price_raw);
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
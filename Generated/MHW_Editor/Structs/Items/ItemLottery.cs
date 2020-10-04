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
    public partial class ItemLottery {
        public override string EncryptionKey => "D7N88VEGEnRl0HEHTO0xMQkbeMb37arJF488lREp90WYojAONkLoxfMt";

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
                    ChangedItems.Add(nameof(Magic_1));
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
                    ChangedItems.Add(nameof(Magic_2));
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
                    ChangedItems.Add(nameof(Entry_Count));
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

        public partial class Entries : MhwStructItem, IWriteData, IHasChildren {
            public const ulong FixedSizeCount = 0;
            public const string GridName = "Entries";

            public partial class Items : MhwStructItem, IWriteDataInner<Entries> {
                public const ulong FixedSizeCount = 10;
                public const string GridName = "Items";

                protected ushort Item_Id_raw;
                public const string Item_Id_displayName = "Item Id";
                public const int Item_Id_sortIndex = 50;
                [SortOrder(Item_Id_sortIndex)]
                [DisplayName(Item_Id_displayName)]
                [DataSource(DataSourceType.Items)]
                public virtual ushort Item_Id {
                    get => Item_Id_raw;
                    set {
                        if (Item_Id_raw == value) return;
                        Item_Id_raw = value;
                        ChangedItems.Add(nameof(Item_Id));
                        OnPropertyChanged(nameof(Item_Id));
                        OnPropertyChanged(nameof(Item_Id_button));
                    }
                }

                [SortOrder(Item_Id_sortIndex)]
                [DisplayName(Item_Id_displayName)]
                [CustomSorter(typeof(ButtonSorter))]
                public string Item_Id_button => DataHelper.itemNames[MainWindow.locale].TryGet(Item_Id).ToStringWithId(Item_Id);

                public const int lastSortIndex = 100;

                public static ObservableMhwStructCollection<Items> LoadData(BinaryReader reader, Entries parent) {
                    var list = new ObservableMhwStructCollection<Items>();
                    var count = 10UL;
                    for (ulong i = 0; i < count; i++) {
                        list.Add(LoadData(reader, i, parent));
                    }
                    return list;
                }

                public static Items LoadData(BinaryReader reader, ulong i, Entries parent) {
                    var data = new Items();
                    data.Index = i;
                    data.Item_Id_raw = reader.ReadUInt16();
                    return data;
                }

                public void WriteData(BinaryWriter writer, Entries parent) {
                    writer.Write(Item_Id_raw);
                }
            }

            public const string Items_displayName = "Items";
            public const int Items_sortIndex = 50;
            [SortOrder(Items_sortIndex)]
            [DisplayName(Items_displayName)]
            public virtual ObservableCollection<Items> Items_raw { get; protected set; }

            public partial class Counts : MhwStructItem, IWriteDataInner<Entries> {
                public const ulong FixedSizeCount = 10;
                public const string GridName = "Counts";

                protected byte Item_Count_raw;
                public const string Item_Count_displayName = "Item Count";
                public const int Item_Count_sortIndex = 50;
                [SortOrder(Item_Count_sortIndex)]
                [DisplayName(Item_Count_displayName)]
                public virtual byte Item_Count {
                    get => Item_Count_raw;
                    set {
                        if (Item_Count_raw == value) return;
                        Item_Count_raw = value;
                        ChangedItems.Add(nameof(Item_Count));
                        OnPropertyChanged(nameof(Item_Count));
                    }
                }

                public const int lastSortIndex = 100;

                public static ObservableMhwStructCollection<Counts> LoadData(BinaryReader reader, Entries parent) {
                    var list = new ObservableMhwStructCollection<Counts>();
                    var count = 10UL;
                    for (ulong i = 0; i < count; i++) {
                        list.Add(LoadData(reader, i, parent));
                    }
                    return list;
                }

                public static Counts LoadData(BinaryReader reader, ulong i, Entries parent) {
                    var data = new Counts();
                    data.Index = i;
                    data.Item_Count_raw = reader.ReadByte();
                    return data;
                }

                public void WriteData(BinaryWriter writer, Entries parent) {
                    writer.Write(Item_Count_raw);
                }
            }

            public const string Counts_displayName = "Counts";
            public const int Counts_sortIndex = 100;
            [SortOrder(Counts_sortIndex)]
            [DisplayName(Counts_displayName)]
            public virtual ObservableCollection<Counts> Counts_raw { get; protected set; }

            public partial class Percents : MhwStructItem, IWriteDataInner<Entries> {
                public const ulong FixedSizeCount = 10;
                public const string GridName = "Percents";

                protected byte Item_Weight_raw;
                public const string Item_Weight_displayName = "Item Weight";
                public const int Item_Weight_sortIndex = 50;
                [SortOrder(Item_Weight_sortIndex)]
                [DisplayName(Item_Weight_displayName)]
                public virtual byte Item_Weight {
                    get => Item_Weight_raw;
                    set {
                        if (Item_Weight_raw == value) return;
                        Item_Weight_raw = value;
                        ChangedItems.Add(nameof(Item_Weight));
                        OnPropertyChanged(nameof(Item_Weight));
                    }
                }

                public const int lastSortIndex = 100;

                public static ObservableMhwStructCollection<Percents> LoadData(BinaryReader reader, Entries parent) {
                    var list = new ObservableMhwStructCollection<Percents>();
                    var count = 10UL;
                    for (ulong i = 0; i < count; i++) {
                        list.Add(LoadData(reader, i, parent));
                    }
                    return list;
                }

                public static Percents LoadData(BinaryReader reader, ulong i, Entries parent) {
                    var data = new Percents();
                    data.Index = i;
                    data.Item_Weight_raw = reader.ReadByte();
                    return data;
                }

                public void WriteData(BinaryWriter writer, Entries parent) {
                    writer.Write(Item_Weight_raw);
                }
            }

            public const string Percents_displayName = "Percents";
            public const int Percents_sortIndex = 150;
            [SortOrder(Percents_sortIndex)]
            [DisplayName(Percents_displayName)]
            public virtual ObservableCollection<Percents> Percents_raw { get; protected set; }

            public partial class Carve_Animations : MhwStructItem, IWriteDataInner<Entries> {
                public const ulong FixedSizeCount = 10;
                public const string GridName = "Carve Animations";

                protected byte Item_Carve_Animation_raw;
                public const string Item_Carve_Animation_displayName = "Item Carve Animation";
                public const int Item_Carve_Animation_sortIndex = 50;
                [SortOrder(Item_Carve_Animation_sortIndex)]
                [DisplayName(Item_Carve_Animation_displayName)]
                public virtual MHW_Template.Items.CarveAnimation Item_Carve_Animation {
                    get => (MHW_Template.Items.CarveAnimation) Item_Carve_Animation_raw;
                    set {
                        if ((MHW_Template.Items.CarveAnimation) Item_Carve_Animation_raw == value) return;
                        Item_Carve_Animation_raw = (byte) value;
                        ChangedItems.Add(nameof(Item_Carve_Animation));
                        OnPropertyChanged(nameof(Item_Carve_Animation));
                    }
                }

                public const int lastSortIndex = 100;

                public static ObservableMhwStructCollection<Carve_Animations> LoadData(BinaryReader reader, Entries parent) {
                    var list = new ObservableMhwStructCollection<Carve_Animations>();
                    var count = 10UL;
                    for (ulong i = 0; i < count; i++) {
                        list.Add(LoadData(reader, i, parent));
                    }
                    return list;
                }

                public static Carve_Animations LoadData(BinaryReader reader, ulong i, Entries parent) {
                    var data = new Carve_Animations();
                    data.Index = i;
                    data.Item_Carve_Animation_raw = reader.ReadByte();
                    return data;
                }

                public void WriteData(BinaryWriter writer, Entries parent) {
                    writer.Write(Item_Carve_Animation_raw);
                }
            }

            public const string Carve_Animations_displayName = "Carve Animations";
            public const int Carve_Animations_sortIndex = 200;
            [SortOrder(Carve_Animations_sortIndex)]
            [DisplayName(Carve_Animations_displayName)]
            public virtual ObservableCollection<Carve_Animations> Carve_Animations_raw { get; protected set; }

            public const int lastSortIndex = 250;

            public IEnumerable<F> GetAllEnumerableChildrenOfType<F>() {
                if (typeof(Items).Is(typeof(F)) || typeof(Items).IsGeneric(typeof(F))) {
                    foreach (var item in Items_raw.Cast<F>()) {
                        yield return item;
                    }
                }
                if (typeof(Counts).Is(typeof(F)) || typeof(Counts).IsGeneric(typeof(F))) {
                    foreach (var item in Counts_raw.Cast<F>()) {
                        yield return item;
                    }
                }
                if (typeof(Percents).Is(typeof(F)) || typeof(Percents).IsGeneric(typeof(F))) {
                    foreach (var item in Percents_raw.Cast<F>()) {
                        yield return item;
                    }
                }
                if (typeof(Carve_Animations).Is(typeof(F)) || typeof(Carve_Animations).IsGeneric(typeof(F))) {
                    foreach (var item in Carve_Animations_raw.Cast<F>()) {
                        yield return item;
                    }
                }
            }

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
                data.Items_raw = Items.LoadData(reader, data);
                data.Counts_raw = Counts.LoadData(reader, data);
                data.Percents_raw = Percents.LoadData(reader, data);
                data.Carve_Animations_raw = Carve_Animations.LoadData(reader, data);
                return data;
            }

            public void WriteData(BinaryWriter writer) {
                foreach (var obj in Items_raw) {
                    obj.WriteData(writer, this);
                }
                foreach (var obj in Counts_raw) {
                    obj.WriteData(writer, this);
                }
                foreach (var obj in Percents_raw) {
                    obj.WriteData(writer, this);
                }
                foreach (var obj in Carve_Animations_raw) {
                    obj.WriteData(writer, this);
                }
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
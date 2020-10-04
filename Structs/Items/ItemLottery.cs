using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Controls;
using MHW_Editor.Assets;
using MHW_Editor.Controls.Models;
using MHW_Editor.Models;
using MHW_Editor.Windows;
using MHW_Template;
using MHW_Template.Items;
using MHW_Template.Models;

namespace MHW_Editor.Structs.Items {
    public partial class ItemLottery : MhwMultiStructFile<ItemLottery> {
        public ObservableCollection<ItemPools> mainEntries { get; private set; }

        public override void SetupViews(Grid grid, MainWindow main) {
            mainEntries = new ObservableCollection<ItemPools>();

            foreach (var entry in GetAllEnumerableOfType<Entries>()) {
                var items           = entry.Items_raw;
                var counts          = entry.Counts_raw;
                var weights         = entry.Percents_raw;
                var carveAnimations = entry.Carve_Animations_raw;
                var innerItems      = new ObservableCollection<InnerItem>();

                for (var i = 0; i < items.Count; i++) {
                    innerItems.Add(new InnerItem((ulong) i, items[i], counts[i], weights[i], carveAnimations[i]));
                }

                mainEntries.Add(new ItemPools(entry.Index, innerItems));
            }

            grid.AddControl(new Label {Content = "Item Pools", FontSize = MainWindow.FONT_SIZE});
            main.AddDataGrid(mainEntries);
        }

        public sealed class InnerItem : MhwStructItem {
            private readonly Entries.Items            id;
            private readonly Entries.Counts           count;
            private readonly Entries.Percents         percent;
            private readonly Entries.Carve_Animations carveAnimation;

            public InnerItem(ulong index, Entries.Items id, Entries.Counts count, Entries.Percents percent, Entries.Carve_Animations carveAnimation) {
                Index               = index;
                this.id             = id;
                this.count          = count;
                this.percent        = percent;
                this.carveAnimation = carveAnimation;
            }

            [DisplayName("Item Id")]
            [SortOrder(100)]
            [DataSource(DataSourceType.Items)]
            public ushort itemId {
                get => id.Item_Id;
                set {
                    id.Item_Id = value;
                    OnPropertyChanged(nameof(itemId));
                }
            }

            [SortOrder(101)]
            [DisplayName("Item Id")]
            [CustomSorter(typeof(ButtonSorter))]
            public string itemId_button => DataHelper.itemNames[MainWindow.locale].TryGet(itemId).ToStringWithId(itemId);

            [DisplayName("Item Count")]
            [SortOrder(110)]
            [DataSource(DataSourceType.Items)]
            public byte itemCount {
                get => count.Item_Count;
                set {
                    count.Item_Count = value;
                    OnPropertyChanged(nameof(itemCount));
                }
            }

            [DisplayName("Item Weight")]
            [SortOrder(120)]
            [DataSource(DataSourceType.Items)]
            public byte itemWeight {
                get => percent.Item_Weight;
                set {
                    percent.Item_Weight = value;
                    OnPropertyChanged(nameof(itemWeight));
                }
            }

            private float itemWeightPercent;
            [SortOrder(125)]
            [DisplayName("Item Weight %")]
            public float itemWeight_percent {
                get => itemWeightPercent;
                set {
                    itemWeightPercent = value.Clamp(0f, 100f);
                    OnPropertyChanged(nameof(itemWeight_percent));
                }
            }

            [DisplayName("Item Carve Animation")]
            [SortOrder(130)]
            [DataSource(DataSourceType.Items)]
            public CarveAnimation itemCarveAnimation {
                get => carveAnimation.Item_Carve_Animation;
                set {
                    carveAnimation.Item_Carve_Animation = value;
                    OnPropertyChanged(nameof(itemCarveAnimation));
                }
            }
        }

        public sealed class ItemPools : MhwStructItem {
            public ItemPools(ulong index, ObservableCollection<InnerItem> innerItems) {
                Index           = index;
                this.innerItems = innerItems;
            }

            [SortOrder(100)]
            [DisplayName("Item Pool")]
            public ObservableCollection<InnerItem> innerItems { get; }
        }
    }
}
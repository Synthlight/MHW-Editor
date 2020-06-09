using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Controls;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Items {
    public partial class QuestReward : MhwMultiStructItem<QuestReward> {
        public override void SetupViews(Grid grid, MainWindow main) {
            var customViews = new List<QuestRewardCustomView>((int) Items.FixedSizeCount);
            for (var i = 0; i < (int) Items.FixedSizeCount; i++) {
                customViews.Add(new QuestRewardCustomView());
            }

            foreach (var entry in data) {
                if (!entry.type.Is(typeof(Items), typeof(Counts), typeof(Weights))) continue;

                for (var i = 0; i < (int) Items.FixedSizeCount; i++) {
                    var customView = customViews[i];
                    var entryItem  = entry.list[i];

                    if (entry.type.Is(typeof(Items))) {
                        customView.itemIdEntry = (Items) entryItem;
                    } else if (entry.type.Is(typeof(Counts))) {
                        customView.itemCountEntry = (Counts) entryItem;
                    } else if (entry.type.Is(typeof(Weights))) {
                        customView.itemWeightEntry = (Weights) entryItem;
                    }
                }
            }

            grid.AddControl(new Label {Content = "Quest Rewards", FontSize = MainWindow.FONT_SIZE});
            main.AddDataGrid(customViews);
        }

        public sealed class QuestRewardCustomView : MhwStructItem {
            internal Items   itemIdEntry;
            internal Counts  itemCountEntry;
            internal Weights itemWeightEntry;

            private const int Item_Id_sortIndex = 50;
            [SortOrder(Item_Id_sortIndex)]
            [DisplayName(Items.Item_Id_displayName)]
            [DataSource(DataSourceType.Items)]
            public uint Item_Id {
                get => itemIdEntry.Item_Id;
                set {
                    if (itemIdEntry.Item_Id == value) return;
                    itemIdEntry.Item_Id = value;
                    OnPropertyChanged(nameof(Item_Id));
                    OnPropertyChanged(nameof(Item_Id_button));
                }
            }

            [SortOrder(Item_Id_sortIndex)]
            [DisplayName(Items.Item_Id_displayName)]
            [CustomSorter(typeof(ButtonSorter))]
            public string Item_Id_button => DataHelper.itemNames[MainWindow.locale].TryGet(Item_Id).ToStringWithId(Item_Id);

            public const int Item_Count_sortIndex = 100;
            [SortOrder(Item_Count_sortIndex)]
            [DisplayName(Counts.Item_Count_displayName)]
            public byte Item_Count {
                get => itemCountEntry.Item_Count;
                set {
                    if (itemCountEntry.Item_Count == value) return;
                    itemCountEntry.Item_Count = value;
                    OnPropertyChanged(nameof(Item_Count));
                }
            }

            public const int Item_Weight_sortIndex = 150;
            [SortOrder(Item_Weight_sortIndex)]
            [DisplayName(Weights.Item_Weight_displayName)]
            public byte Item_Weight {
                get => itemWeightEntry.Item_Weight;
                set {
                    if (itemWeightEntry.Item_Weight == value) return;
                    itemWeightEntry.Item_Weight = value;
                    OnPropertyChanged(nameof(Item_Weight));
                }
            }
        }
    }
}
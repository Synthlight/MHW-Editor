﻿using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Controls;
using MHW_Editor.Assets;
using MHW_Editor.Controls.Models;
using MHW_Editor.Models;
using MHW_Editor.Windows;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Structs.Items {
    public partial class BonusReward : MhwMultiStructFile<BonusReward> {
        public override void SetupViews(Grid grid, MainWindow main) {
            var customViews = new List<BonusRewardCustomView>((int) Items.FixedSizeCount);
            for (var i = 0; i < (int) Items.FixedSizeCount; i++) {
                customViews.Add(new BonusRewardCustomView());
            }

            foreach (var entry in data) {
                if (!entry.type.Is(typeof(Items), typeof(Counts), typeof(Weights))) continue;

                for (var i = 0; i < (int) Items.FixedSizeCount; i++) {
                    var customView = customViews[i];
                    var entryItem  = ((dynamic) entry).list[i];

                    if (entry.type.Is(typeof(Items))) {
                        customView.itemIdEntry = (Items) entryItem;
                    } else if (entry.type.Is(typeof(Counts))) {
                        customView.itemCountEntry = (Counts) entryItem;
                    } else if (entry.type.Is(typeof(Weights))) {
                        customView.itemWeightEntry = (Weights) entryItem;
                    }
                }
            }

            grid.AddControl(new Label {Content = "Bonus Rewards", FontSize = MainWindow.FONT_SIZE});
            main.AddDataGrid(customViews);
        }

        /// <summary>
        /// Technically Identical to QuestRewardCustomView, but due to different 
        /// Items, Counts and Weights classes that were generated, this needs to be separate, 
        /// or the "original" one would have to be generic for example.
        /// </summary>
        public sealed class BonusRewardCustomView : MhwStructItem {
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

            [SortOrder(100)]
            [DisplayName(Counts.Item_Count_displayName)]
            public byte Item_Count {
                get => itemCountEntry.Item_Count;
                set {
                    if (itemCountEntry.Item_Count == value) return;
                    itemCountEntry.Item_Count = value;
                    OnPropertyChanged(nameof(Item_Count));
                }
            }

            [SortOrder(150)]
            [DisplayName(Weights.Item_Weight_displayName)]
            public byte Item_Weight {
                get => itemWeightEntry.Item_Weight;
                set {
                    if (itemWeightEntry.Item_Weight == value) return;
                    itemWeightEntry.Item_Weight = value;
                    OnPropertyChanged(nameof(Item_Weight));
                }
            }

            private float itemWeightPercent;
            [SortOrder(200)]
            [DisplayName(Weights.Item_Weight_displayName + "%")]
            public float Item_Weight_percent {
                get => itemWeightPercent;
                set {
                    itemWeightPercent = value.Clamp(0f, 100f);
                    OnPropertyChanged(nameof(Item_Weight_percent));
                }
            }
        }
    }
}
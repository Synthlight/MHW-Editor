using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text.RegularExpressions;
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
        public  ObservableCollection<ItemPools> mainEntries { get; private set; }
        private string                          targetFile;

        [SuppressMessage("ReSharper", "ParameterHidesMember")]
        public void Init(string targetFile) {
            this.targetFile = Path.GetFileNameWithoutExtension(targetFile);
            if (mainEntries == null) return;
            foreach (var entry in mainEntries) {
                entry.Init(targetFile);
            }
        }

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

                mainEntries.Add(new ItemPools(entry.Index, innerItems).Init(targetFile));
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
            private string targetFile;
            private bool   isEmItLot;

            public ItemPools(ulong index, ObservableCollection<InnerItem> innerItems) {
                Index           = index;
                this.innerItems = innerItems;
            }

            [SuppressMessage("ReSharper", "ParameterHidesMember")]
            public ItemPools Init(string targetFile) {
                this.targetFile = targetFile;
                isEmItLot       = new Regex(@"em\d\d\d").Match(targetFile).Success;
                return this;
            }

            [DisplayName("Name")]
            [SortOrder(0)]
            public string name {
                get {
                    if (!isEmItLot) return "Unknown";
                    return Index switch {
                        0 => "(LR) Carve/Cap",
                        1 => "(LR) Tail Carve",
                        2 => "(LR) Dropped",
                        3 => "(LR) Tracks",
                        4 => "(HR) Carve/Cap",
                        5 => "(HR) Tail Carve",
                        6 => "(HR) Dropped",
                        7 => "(HR) Tracks",
                        8 => "(LR) Bandit Mantle",
                        9 => "(HR) Bandit Mantle",
                        10 => "(LR) Plunderblade",
                        11 => "(HR) Plunderblade",
                        12 => "(LR) Gathered By Palico",
                        13 => "(HR) Gathered By Palico",
                        14 => "Bones",
                        15 => "Bones",
                        16 => "Bones",
                        17 => "Bones",
                        18 => "Bones",
                        19 => "Bones",
                        20 => "(LR) Tracks 2",
                        21 => "(HR) Tracks 2",
                        22 => "(MR) Tracks",
                        23 => "(MR) Carve/Cap",
                        24 => "(MR) Tail Carve",
                        25 => "(MR) Dropped",
                        26 => "(MR) Bones",
                        27 => "(MR) Bandit Mantle",
                        28 => "(MR) Plunderblade",
                        29 => "(MR) Gathered By Palico",
                        30 => "(MR) Bones 2",
                        31 => "(MR) Guiding Lands (Low)",
                        32 => "(MR) Guiding Lands (Mid)",
                        33 => "(MR) Guiding Lands (High)",
                        34 => "(MR) Guiding Lands (Tempered)",
                        _ => "Unknown"
                    };
                }
            }

            [SortOrder(100)]
            [DisplayName("Item Pool")]
            public ObservableCollection<InnerItem> innerItems { get; }
        }
    }
}
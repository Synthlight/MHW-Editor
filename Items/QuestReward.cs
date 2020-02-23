using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Items {
    public partial class QuestReward : MhwItem {
        public QuestReward(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => "None";

        public ObservableCollection<QuestRewardInternal> GetCustomView() {
            var itemList = new ObservableCollection<QuestRewardInternal>();

            for (var i = 0; i <= 15; i++) {
                itemList.Add(new QuestRewardInternal(this, i, Bytes, Offset));
            }

            return itemList;
        }

        /// <summary>
        /// Internal override so we display the items in a grid, rather than one long row.
        /// </summary>
        /// <seealso cref="QuestReward" />
        public sealed class QuestRewardInternal : MhwItem {
            private readonly QuestReward parent;
            private readonly int index;

            public QuestRewardInternal(QuestReward parent, int index, byte[] bytes, ulong offset) : base(bytes, offset) {
                this.parent = parent;
                this.index = index;
            }

            public override string UniqueId => null;
            public override string Name => "None";

            private const int idBaseOffset = 8;
            private int idOffset => idBaseOffset + index * 4;

            [SortOrder(100)]
            [DisplayName("Item Id")]
            [DataSource(DataSourceType.Items)]
            public uint Item_Id {
                get => parent.GetData<uint>(idOffset);
                set {
                    if (parent.GetData<uint>(idOffset) == value) return;
                    parent.SetData(idOffset, value, $"Item_{index + 1}_Id");
                    parent.OnPropertyChanged(nameof(Raw_Data));
                    OnPropertyChanged(nameof(Raw_Data));
                    OnPropertyChanged(nameof(Item_Id));
                }
            }

            [SortOrder(100)]
            [DisplayName("Item Id")]
            [CustomSorter(typeof(UInt16Sorter))]
            public string Item_Id_button => DataHelper.itemData[MainWindow.locale].TryGet((ushort) Item_Id, IdNamePair.Unknown((ushort) Item_Id)).ToString();

            private const int countBaseOffset = 72;
            private int countOffset => countBaseOffset + index;

            [SortOrder(150)]
            [DisplayName("Item Count")]
            public byte Item_Count {
                get => parent.GetData<byte>(countOffset);
                set {
                    if (parent.GetData<byte>(countOffset) == value) return;
                    parent.SetData(countOffset, value, $"Item_{index + 1}_Cnt");
                    parent.OnPropertyChanged(nameof(Raw_Data));
                    OnPropertyChanged(nameof(Raw_Data));
                    OnPropertyChanged(nameof(Item_Count));
                }
            }

            private const int weightBaseOffset = 88;
            private int weightOffset => weightBaseOffset + index;

            [SortOrder(200)]
            [DisplayName("Item Weight")]
            public byte Item_Weight {
                get => parent.GetData<byte>(weightOffset);
                set {
                    if (parent.GetData<byte>(weightOffset) == value) return;
                    parent.SetData(weightOffset, value, $"Item_{index + 1}_Wt");
                    parent.OnPropertyChanged(nameof(Raw_Data));
                    OnPropertyChanged(nameof(Raw_Data));
                    OnPropertyChanged(nameof(Item_Weight));
                }
            }
        }
    }
}
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Items;

namespace MHW_Editor.Items {
    public partial class Item : MhwItem {
        public Item(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => DataHelper.itemData[MainWindow.locale].TryGet(Id * 2, "Unknown");

        public uint Flags {
            get => Flags_Raw;
            set {
                Flags_Raw = value;
                OnPropertyChanged(nameof(Is_Infinite_Use));
                OnPropertyChanged(nameof(Is_Account_Item));
            }
        }

        public bool Is_Infinite_Use {
            get => ((ItemFlags) Flags & ItemFlags.Infinite_Use) != 0;
            set {
                if (value) {
                    Flags |= (uint) ItemFlags.Infinite_Use;
                } else {
                    Flags &= ~(uint) ItemFlags.Infinite_Use;
                }

                OnPropertyChanged(nameof(Flags));
            }
        }

        public bool Is_Account_Item {
            get => ((ItemFlags) Flags & ItemFlags.Account_Item) != 0;
            set {
                if (value) {
                    Flags |= (uint) ItemFlags.Account_Item;
                } else {
                    Flags &= ~(uint) ItemFlags.Account_Item;
                }

                OnPropertyChanged(nameof(Flags));
            }
        }
    }
}
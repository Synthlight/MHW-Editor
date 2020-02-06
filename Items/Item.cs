using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Items;

namespace MHW_Editor.Items {
    public partial class Item : MhwItem {
        public Item(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        public override string Name => DataHelper.itemData[MainWindow.locale].TryGet((ushort) Id, IdNamePair.Unknown((ushort) Id)).name;

        [SortOrder(Flags_Raw_sortIndex)]
        public uint Flags {
            get => Flags_Raw;
            set {
                Flags_Raw = value;
                OnPropertyChanged(nameof(Has_Infinity_Symbol));
                OnPropertyChanged(nameof(Is_Supply_Item));
                OnPropertyChanged(nameof(Unknown));
                OnPropertyChanged(nameof(Is_Consumable));
                OnPropertyChanged(nameof(Is_Fey_or_Streamstone));
                OnPropertyChanged(nameof(Is_Infinite_Use));
                OnPropertyChanged(nameof(Has_Star));
                OnPropertyChanged(nameof(Has_New_Palico_Gadget_Symbol));
                OnPropertyChanged(nameof(Is_Level_1));
                OnPropertyChanged(nameof(Is_Level_2));
                OnPropertyChanged(nameof(Is_Level_3));
                OnPropertyChanged(nameof(Is_Shiny));
                OnPropertyChanged(nameof(Is_Huge_Carriable));
                OnPropertyChanged(nameof(Not_Storable_as_an_Item));
            }
        }

        [SortOrder(Flags_Raw_sortIndex + 1)]
        [DisplayName("Has Infinity Symbol")]
        public bool Has_Infinity_Symbol {
            get => ((ItemFlags) Flags & ItemFlags.Infinity_Symbol) != 0;
            set {
                if (value) {
                    Flags |= (uint) ItemFlags.Infinity_Symbol;
                } else {
                    Flags &= ~(uint) ItemFlags.Infinity_Symbol;
                }

                OnPropertyChanged(nameof(Flags));
            }
        }

        [SortOrder(Flags_Raw_sortIndex + 2)]
        [DisplayName("Is Supply Item")]
        public bool Is_Supply_Item {
            get => ((ItemFlags) Flags & ItemFlags.Supply_Item) != 0;
            set {
                if (value) {
                    Flags |= (uint) ItemFlags.Supply_Item;
                } else {
                    Flags &= ~(uint) ItemFlags.Supply_Item;
                }

                OnPropertyChanged(nameof(Flags));
            }
        }

        [SortOrder(Flags_Raw_sortIndex + 3)]
        [DisplayName("Unknown")]
        public bool Unknown {
            get => ((ItemFlags) Flags & ItemFlags.Unknown) != 0;
            set {
                if (value) {
                    Flags |= (uint) ItemFlags.Unknown;
                } else {
                    Flags &= ~(uint) ItemFlags.Unknown;
                }

                OnPropertyChanged(nameof(Flags));
            }
        }

        [SortOrder(Flags_Raw_sortIndex + 4)]
        [DisplayName("Is Consumable")]
        public bool Is_Consumable {
            get => ((ItemFlags) Flags & ItemFlags.Consumable) != 0;
            set {
                if (value) {
                    Flags |= (uint) ItemFlags.Consumable;
                } else {
                    Flags &= ~(uint) ItemFlags.Consumable;
                }

                OnPropertyChanged(nameof(Flags));
            }
        }

        [SortOrder(Flags_Raw_sortIndex + 5)]
        [DisplayName("Is Fey or Streamstone")]
        public bool Is_Fey_or_Streamstone {
            get => ((ItemFlags) Flags & ItemFlags.Fey_or_Streamstone) != 0;
            set {
                if (value) {
                    Flags |= (uint) ItemFlags.Fey_or_Streamstone;
                } else {
                    Flags &= ~(uint) ItemFlags.Fey_or_Streamstone;
                }

                OnPropertyChanged(nameof(Flags));
            }
        }

        [SortOrder(Flags_Raw_sortIndex + 6)]
        [DisplayName("Is Infinite Use")]
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

        [SortOrder(Flags_Raw_sortIndex + 7)]
        [DisplayName("Has Star")]
        public bool Has_Star {
            get => ((ItemFlags) Flags & ItemFlags.Star) != 0;
            set {
                if (value) {
                    Flags |= (uint) ItemFlags.Star;
                } else {
                    Flags &= ~(uint) ItemFlags.Star;
                }

                OnPropertyChanged(nameof(Flags));
            }
        }

        [SortOrder(Flags_Raw_sortIndex + 8)]
        [DisplayName("Has New Palico Gadget Symbol")]
        public bool Has_New_Palico_Gadget_Symbol {
            get => ((ItemFlags) Flags & ItemFlags.New_Palico_Gadget_Symbol) != 0;
            set {
                if (value) {
                    Flags |= (uint) ItemFlags.New_Palico_Gadget_Symbol;
                } else {
                    Flags &= ~(uint) ItemFlags.New_Palico_Gadget_Symbol;
                }

                OnPropertyChanged(nameof(Flags));
            }
        }

        [SortOrder(Flags_Raw_sortIndex + 9)]
        [DisplayName("Is Level 1")]
        public bool Is_Level_1 {
            get => ((ItemFlags) Flags & ItemFlags.Level_1) != 0;
            set {
                if (value) {
                    Flags |= (uint) ItemFlags.Level_1;
                } else {
                    Flags &= ~(uint) ItemFlags.Level_1;
                }

                OnPropertyChanged(nameof(Flags));
            }
        }

        [SortOrder(Flags_Raw_sortIndex + 10)]
        [DisplayName("Is Level 2")]
        public bool Is_Level_2 {
            get => ((ItemFlags) Flags & ItemFlags.Level_2) != 0;
            set {
                if (value) {
                    Flags |= (uint) ItemFlags.Level_2;
                } else {
                    Flags &= ~(uint) ItemFlags.Level_2;
                }

                OnPropertyChanged(nameof(Flags));
            }
        }

        [SortOrder(Flags_Raw_sortIndex + 11)]
        [DisplayName("Is Level 3")]
        public bool Is_Level_3 {
            get => ((ItemFlags) Flags & ItemFlags.Level_3) != 0;
            set {
                if (value) {
                    Flags |= (uint) ItemFlags.Level_3;
                } else {
                    Flags &= ~(uint) ItemFlags.Level_3;
                }

                OnPropertyChanged(nameof(Flags));
            }
        }

        [SortOrder(Flags_Raw_sortIndex + 12)]
        [DisplayName("Is Shiny")]
        public bool Is_Shiny {
            get => ((ItemFlags) Flags & ItemFlags.Shiny) != 0;
            set {
                if (value) {
                    Flags |= (uint) ItemFlags.Shiny;
                } else {
                    Flags &= ~(uint) ItemFlags.Shiny;
                }

                OnPropertyChanged(nameof(Flags));
            }
        }

        [SortOrder(Flags_Raw_sortIndex + 13)]
        [DisplayName("Is Huge Carriable")]
        public bool Is_Huge_Carriable {
            get => ((ItemFlags) Flags & ItemFlags.Huge_Carriable) != 0;
            set {
                if (value) {
                    Flags |= (uint) ItemFlags.Huge_Carriable;
                } else {
                    Flags &= ~(uint) ItemFlags.Huge_Carriable;
                }

                OnPropertyChanged(nameof(Flags));
            }
        }

        [SortOrder(Flags_Raw_sortIndex + 14)]
        [DisplayName("Not Storable as an Item")]
        public bool Not_Storable_as_an_Item {
            get => ((ItemFlags) Flags & ItemFlags.Not_Storable_as_an_Item) != 0;
            set {
                if (value) {
                    Flags |= (uint) ItemFlags.Not_Storable_as_an_Item;
                } else {
                    Flags &= ~(uint) ItemFlags.Not_Storable_as_an_Item;
                }

                OnPropertyChanged(nameof(Flags));
            }
        }
    }
}
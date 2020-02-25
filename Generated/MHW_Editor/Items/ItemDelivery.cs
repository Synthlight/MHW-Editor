using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Items {
    public partial class ItemDelivery {
        public const uint StructSize = 44;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public const string EncryptionKey = null;
        public override string UniqueId => $"{Id}";

        public const string Id_displayName = "Id";
        public const int Id_sortIndex = 50;
        [SortOrder(Id_sortIndex)]
        [DisplayName(Id_displayName)]
        public virtual uint Id {
            get => GetData<uint>(0);
        }

        public const string Unk1_displayName = "Unk1";
        public const int Unk1_sortIndex = 100;
        [SortOrder(Unk1_sortIndex)]
        [DisplayName(Unk1_displayName)]
        public virtual uint Unk1 {
            get => GetData<uint>(4);
            set {
                if (GetData<uint>(4) == value) return;
                SetData(4, value, nameof(Unk1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk1));
            }
        }

        public const string Unk2_displayName = "Unk2";
        public const int Unk2_sortIndex = 150;
        [SortOrder(Unk2_sortIndex)]
        [DisplayName(Unk2_displayName)]
        public virtual uint Unk2 {
            get => GetData<uint>(8);
            set {
                if (GetData<uint>(8) == value) return;
                SetData(8, value, nameof(Unk2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk2));
            }
        }

        public const string Client_Id_displayName = "Client Id";
        public const int Client_Id_sortIndex = 200;
        [SortOrder(Client_Id_sortIndex)]
        [DisplayName(Client_Id_displayName)]
        public virtual int Client_Id {
            get => GetData<int>(12);
            set {
                if (GetData<int>(12) == value) return;
                SetData(12, value, nameof(Client_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Client_Id));
            }
        }

        public const string Decoration_Reward_displayName = "Decoration Reward";
        public const int Decoration_Reward_sortIndex = 250;
        [SortOrder(Decoration_Reward_sortIndex)]
        [DisplayName(Decoration_Reward_displayName)]
        [DataSource(DataSourceType.Items)]
        public virtual uint Decoration_Reward {
            get => GetData<uint>(16);
            set {
                if (GetData<uint>(16) == value) return;
                SetData(16, value, nameof(Decoration_Reward));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Decoration_Reward));
                OnPropertyChanged(nameof(Decoration_Reward_button));
            }
        }

        [SortOrder(Decoration_Reward_sortIndex)]
        [DisplayName(Decoration_Reward_displayName)]
        [CustomSorter(typeof(ButtonSorter))]
        public string Decoration_Reward_button => DataHelper.itemData[MainWindow.locale].TryGet(Decoration_Reward).ToStringWithId(Decoration_Reward);

        public const string Unk3_displayName = "Unk3";
        public const int Unk3_sortIndex = 300;
        [SortOrder(Unk3_sortIndex)]
        [DisplayName(Unk3_displayName)]
        public virtual uint Unk3 {
            get => GetData<uint>(20);
            set {
                if (GetData<uint>(20) == value) return;
                SetData(20, value, nameof(Unk3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk3));
            }
        }

        public const string Cost_displayName = "Cost";
        public const int Cost_sortIndex = 350;
        [SortOrder(Cost_sortIndex)]
        [DisplayName(Cost_displayName)]
        public virtual uint Cost {
            get => GetData<uint>(24);
            set {
                if (GetData<uint>(24) == value) return;
                SetData(24, value, nameof(Cost));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Cost));
            }
        }

        public const string Item_1_Id_displayName = "Item 1 Id";
        public const int Item_1_Id_sortIndex = 400;
        [SortOrder(Item_1_Id_sortIndex)]
        [DisplayName(Item_1_Id_displayName)]
        [DataSource(DataSourceType.Items)]
        public virtual uint Item_1_Id {
            get => GetData<uint>(28);
            set {
                if (GetData<uint>(28) == value) return;
                SetData(28, value, nameof(Item_1_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_1_Id));
                OnPropertyChanged(nameof(Item_1_Id_button));
            }
        }

        [SortOrder(Item_1_Id_sortIndex)]
        [DisplayName(Item_1_Id_displayName)]
        [CustomSorter(typeof(ButtonSorter))]
        public string Item_1_Id_button => DataHelper.itemData[MainWindow.locale].TryGet(Item_1_Id).ToStringWithId(Item_1_Id);

        public const string Item_1_Cnt_displayName = "Item 1 Cnt";
        public const int Item_1_Cnt_sortIndex = 450;
        [SortOrder(Item_1_Cnt_sortIndex)]
        [DisplayName(Item_1_Cnt_displayName)]
        public virtual uint Item_1_Cnt {
            get => GetData<uint>(36);
            set {
                if (GetData<uint>(36) == value) return;
                SetData(36, value, nameof(Item_1_Cnt));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_1_Cnt));
            }
        }

        public const string Item_2_Id_displayName = "Item 2 Id";
        public const int Item_2_Id_sortIndex = 500;
        [SortOrder(Item_2_Id_sortIndex)]
        [DisplayName(Item_2_Id_displayName)]
        [DataSource(DataSourceType.Items)]
        public virtual uint Item_2_Id {
            get => GetData<uint>(32);
            set {
                if (GetData<uint>(32) == value) return;
                SetData(32, value, nameof(Item_2_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_2_Id));
                OnPropertyChanged(nameof(Item_2_Id_button));
            }
        }

        [SortOrder(Item_2_Id_sortIndex)]
        [DisplayName(Item_2_Id_displayName)]
        [CustomSorter(typeof(ButtonSorter))]
        public string Item_2_Id_button => DataHelper.itemData[MainWindow.locale].TryGet(Item_2_Id).ToStringWithId(Item_2_Id);

        public const string Item_2_Cnt_displayName = "Item 2 Cnt";
        public const int Item_2_Cnt_sortIndex = 550;
        [SortOrder(Item_2_Cnt_sortIndex)]
        [DisplayName(Item_2_Cnt_displayName)]
        public virtual uint Item_2_Cnt {
            get => GetData<uint>(40);
            set {
                if (GetData<uint>(40) == value) return;
                SetData(40, value, nameof(Item_2_Cnt));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_2_Cnt));
            }
        }

        public const int lastSortIndex = 600;
    }
}
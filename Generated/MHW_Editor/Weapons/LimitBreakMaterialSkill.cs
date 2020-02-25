using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Weapons {
    public partial class LimitBreakMaterialSkill {
        public const uint StructSize = 10;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public const string EncryptionKey = null;
        public override string UniqueId => $"{Index}";

        public const string Rarity_displayName = "Rarity";
        public const int Rarity_sortIndex = 50;
        [SortOrder(Rarity_sortIndex)]
        [DisplayName(Rarity_displayName)]
        public virtual byte Rarity {
            get => GetData<byte>(0);
            set {
                if (GetData<byte>(0) == value) return;
                SetData(0, value, nameof(Rarity));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Rarity));
            }
        }

        public const string Augment_Type_displayName = "Augment Type";
        public const int Augment_Type_sortIndex = 100;
        [SortOrder(Augment_Type_sortIndex)]
        [DisplayName(Augment_Type_displayName)]
        public virtual MHW_Template.Weapons.AugmentationType Augment_Type {
            get => (MHW_Template.Weapons.AugmentationType) GetData<byte>(1);
            set {
                if ((MHW_Template.Weapons.AugmentationType) GetData<byte>(1) == value) return;
                SetData(1, (byte) value, nameof(Augment_Type));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Augment_Type));
            }
        }

        public const string Item_1_Id_displayName = "Item 1 Id";
        public const int Item_1_Id_sortIndex = 150;
        [SortOrder(Item_1_Id_sortIndex)]
        [DisplayName(Item_1_Id_displayName)]
        [DataSource(DataSourceType.Items)]
        public virtual ushort Item_1_Id {
            get => GetData<ushort>(2);
            set {
                if (GetData<ushort>(2) == value) return;
                SetData(2, value, nameof(Item_1_Id));
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
        public const int Item_1_Cnt_sortIndex = 200;
        [SortOrder(Item_1_Cnt_sortIndex)]
        [DisplayName(Item_1_Cnt_displayName)]
        public virtual ushort Item_1_Cnt {
            get => GetData<ushort>(4);
            set {
                if (GetData<ushort>(4) == value) return;
                SetData(4, value, nameof(Item_1_Cnt));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_1_Cnt));
            }
        }

        public const string Unk_displayName = "Unk";
        public const int Unk_sortIndex = 250;
        [SortOrder(Unk_sortIndex)]
        [DisplayName(Unk_displayName)]
        public virtual uint Unk {
            get => GetData<uint>(6);
            set {
                if (GetData<uint>(6) == value) return;
                SetData(6, value, nameof(Unk));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk));
            }
        }

        public const int lastSortIndex = 300;
    }
}
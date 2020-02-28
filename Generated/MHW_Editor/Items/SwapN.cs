using System;
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Items {
    public partial class SwapN {
        public const uint StructSize = 12;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public const string EncryptionKey = null;
        public override string UniqueId => $"{Index}";

        public const string Unk1_displayName = "Unk1";
        public const int Unk1_sortIndex = 50;
        [SortOrder(Unk1_sortIndex)]
        [DisplayName(Unk1_displayName)]
        public virtual uint Unk1 {
            get => GetData<uint>(0);
            set {
                if (GetData<uint>(0) == value) return;
                SetData(0, value, nameof(Unk1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk1));
            }
        }

        public const string Item_Id_displayName = "Item Id";
        public const int Item_Id_sortIndex = 100;
        [SortOrder(Item_Id_sortIndex)]
        [DisplayName(Item_Id_displayName)]
        [DataSource(DataSourceType.Items)]
        public virtual uint Item_Id {
            get => GetData<uint>(4);
            set {
                if (GetData<uint>(4) == value) return;
                SetData(4, value, nameof(Item_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Item_Id));
                OnPropertyChanged(nameof(Item_Id_button));
            }
        }

        [SortOrder(Item_Id_sortIndex)]
        [DisplayName(Item_Id_displayName)]
        [CustomSorter(typeof(ButtonSorter))]
        public string Item_Id_button => DataHelper.itemNames[MainWindow.locale].TryGet(Item_Id).ToStringWithId(Item_Id);

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

        public const int lastSortIndex = 200;
    }
}
using System;
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Items {
    public partial class ShopSed {
        public const uint StructSize = 12;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public const string EncryptionKey = null;
        public override string UniqueId => $"{Index}";

        public const string Equip_Type_displayName = "Equip Type";
        public const int Equip_Type_sortIndex = 50;
        [SortOrder(Equip_Type_sortIndex)]
        [DisplayName(Equip_Type_displayName)]
        public virtual MHW_Template.Items.EquipmentType Equip_Type {
            get => (MHW_Template.Items.EquipmentType) GetData<uint>(0);
            set {
                if ((MHW_Template.Items.EquipmentType) GetData<uint>(0) == value) return;
                SetData(0, (uint) value, nameof(Equip_Type));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Equip_Type));
            }
        }

        public const string Equip_Id_displayName = "Equip Id";
        public const int Equip_Id_sortIndex = 100;
        [SortOrder(Equip_Id_sortIndex)]
        [DisplayName(Equip_Id_displayName)]
        [DataSource(DataSourceType.EquipmentById)]
        public virtual uint Equip_Id {
            get => GetData<uint>(4);
            set {
                if (GetData<uint>(4) == value) return;
                SetData(4, value, nameof(Equip_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Equip_Id));
                OnPropertyChanged(nameof(Equip_Id_button));
            }
        }

        [SortOrder(Equip_Id_sortIndex)]
        [DisplayName(Equip_Id_displayName)]
        [CustomSorter(typeof(ButtonSorter))]
        public string Equip_Id_button => DataHelper.equipmentIdNameLookup[GetEquipmentType()][MainWindow.locale].TryGet(Equip_Id).ToStringWithId(Equip_Id);

        public const string Story_Unlock_displayName = "Story Unlock";
        public const int Story_Unlock_sortIndex = 150;
        [SortOrder(Story_Unlock_sortIndex)]
        [DisplayName(Story_Unlock_displayName)]
        public virtual uint Story_Unlock {
            get => GetData<uint>(8);
            set {
                if (GetData<uint>(8) == value) return;
                SetData(8, value, nameof(Story_Unlock));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Story_Unlock));
            }
        }

        public const int lastSortIndex = 200;
    }
}
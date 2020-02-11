using System.ComponentModel;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Armors {
    public partial class OtomoArmorDat {
        public const uint StructSize = 42;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public const string EncryptionKey = null;

        public const string Index_displayName = "Index";
        public const int Index_sortIndex = 50;
        [SortOrder(Index_sortIndex)]
        [DisplayName(Index_displayName)]
        public virtual uint Index {
            get => GetData<uint>(0);
        }

        public const string Set_Id_displayName = "Set Id";
        public const int Set_Id_sortIndex = 100;
        [SortOrder(Set_Id_sortIndex)]
        [DisplayName(Set_Id_displayName)]
        public virtual ushort Set_Id {
            get => GetData<ushort>(4);
        }

        public const string Equip_Slot_displayName = "Equip Slot";
        public const int Equip_Slot_sortIndex = 150;
        [SortOrder(Equip_Slot_sortIndex)]
        [DisplayName(Equip_Slot_displayName)]
        public virtual MHW_Template.Armors.EquipSlot Equip_Slot {
            get => (MHW_Template.Armors.EquipSlot) GetData<byte>(6);
        }

        public const string Is_Full_Set_Raw_displayName = "Is Full Set Raw";
        public const int Is_Full_Set_Raw_sortIndex = 200;
        [SortOrder(Is_Full_Set_Raw_sortIndex)]
        [DisplayName(Is_Full_Set_Raw_displayName)]
        private byte Is_Full_Set_Raw {
            get => GetData<byte>(7);
            set {
                if (GetData<byte>(7) == value) return;
                SetData(7, value, nameof(Is_Full_Set_Raw));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Is_Full_Set_Raw));
                OnPropertyChanged(nameof(Is_Full_Set));
            }
        }

        public const string Defense_displayName = "Defense";
        public const int Defense_sortIndex = 250;
        [SortOrder(Defense_sortIndex)]
        [DisplayName(Defense_displayName)]
        public virtual uint Defense {
            get => GetData<uint>(8);
            set {
                if (GetData<uint>(8) == value) return;
                SetData(8, value, nameof(Defense));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Defense));
            }
        }

        public const string Rarity_displayName = "Rarity";
        public const int Rarity_sortIndex = 300;
        [SortOrder(Rarity_sortIndex)]
        [DisplayName(Rarity_displayName)]
        public virtual byte Rarity {
            get => GetData<byte>(12);
            set {
                if (GetData<byte>(12) == value) return;
                SetData(12, value, nameof(Rarity));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Rarity));
            }
        }

        public const string Order_displayName = "Order";
        public const int Order_sortIndex = 350;
        [SortOrder(Order_sortIndex)]
        [DisplayName(Order_displayName)]
        public virtual ushort Order {
            get => GetData<ushort>(13);
            set {
                if (GetData<ushort>(13) == value) return;
                SetData(13, value, nameof(Order));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Order));
            }
        }

        public const string Model_Id_displayName = "Model Id";
        public const int Model_Id_sortIndex = 400;
        [SortOrder(Model_Id_sortIndex)]
        [DisplayName(Model_Id_displayName)]
        public virtual uint Model_Id {
            get => GetData<uint>(15);
            set {
                if (GetData<uint>(15) == value) return;
                SetData(15, value, nameof(Model_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Model_Id));
            }
        }

        public const string Cost_displayName = "Cost";
        public const int Cost_sortIndex = 450;
        [SortOrder(Cost_sortIndex)]
        [DisplayName(Cost_displayName)]
        public virtual uint Cost {
            get => GetData<uint>(19);
            set {
                if (GetData<uint>(19) == value) return;
                SetData(19, value, nameof(Cost));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Cost));
            }
        }

        public const string Variant_displayName = "Variant";
        public const int Variant_sortIndex = 500;
        [SortOrder(Variant_sortIndex)]
        [DisplayName(Variant_displayName)]
        public virtual MHW_Template.Armors.Variant Variant {
            get => (MHW_Template.Armors.Variant) GetData<byte>(23);
            set {
                if ((MHW_Template.Armors.Variant) GetData<byte>(23) == value) return;
                SetData(23, (byte) value, nameof(Variant));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Variant));
            }
        }

        public const string Fire_Res_displayName = "Fire Res";
        public const int Fire_Res_sortIndex = 550;
        [SortOrder(Fire_Res_sortIndex)]
        [DisplayName(Fire_Res_displayName)]
        public virtual sbyte Fire_Res {
            get => GetData<sbyte>(27);
            set {
                if (GetData<sbyte>(27) == value) return;
                SetData(27, value, nameof(Fire_Res));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Fire_Res));
            }
        }

        public const string Water_Res_displayName = "Water Res";
        public const int Water_Res_sortIndex = 600;
        [SortOrder(Water_Res_sortIndex)]
        [DisplayName(Water_Res_displayName)]
        public virtual sbyte Water_Res {
            get => GetData<sbyte>(28);
            set {
                if (GetData<sbyte>(28) == value) return;
                SetData(28, value, nameof(Water_Res));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Water_Res));
            }
        }

        public const string Ice_Res_displayName = "Ice Res";
        public const int Ice_Res_sortIndex = 650;
        [SortOrder(Ice_Res_sortIndex)]
        [DisplayName(Ice_Res_displayName)]
        public virtual sbyte Ice_Res {
            get => GetData<sbyte>(29);
            set {
                if (GetData<sbyte>(29) == value) return;
                SetData(29, value, nameof(Ice_Res));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Ice_Res));
            }
        }

        public const string Thunder_Res_displayName = "Thunder Res";
        public const int Thunder_Res_sortIndex = 700;
        [SortOrder(Thunder_Res_sortIndex)]
        [DisplayName(Thunder_Res_displayName)]
        public virtual sbyte Thunder_Res {
            get => GetData<sbyte>(30);
            set {
                if (GetData<sbyte>(30) == value) return;
                SetData(30, value, nameof(Thunder_Res));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Thunder_Res));
            }
        }

        public const string Dragon_Res_displayName = "Dragon Res";
        public const int Dragon_Res_sortIndex = 750;
        [SortOrder(Dragon_Res_sortIndex)]
        [DisplayName(Dragon_Res_displayName)]
        public virtual sbyte Dragon_Res {
            get => GetData<sbyte>(31);
            set {
                if (GetData<sbyte>(31) == value) return;
                SetData(31, value, nameof(Dragon_Res));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dragon_Res));
            }
        }

        public const string Set_Group_displayName = "Set Group";
        public const int Set_Group_sortIndex = 800;
        [SortOrder(Set_Group_sortIndex)]
        [DisplayName(Set_Group_displayName)]
        public virtual ushort Set_Group {
            get => GetData<ushort>(36);
            set {
                if (GetData<ushort>(36) == value) return;
                SetData(36, value, nameof(Set_Group));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Set_Group));
            }
        }

        public const string GMD_Name_Index_displayName = "GMD Name Index";
        public const int GMD_Name_Index_sortIndex = 850;
        [SortOrder(GMD_Name_Index_sortIndex)]
        [DisplayName(GMD_Name_Index_displayName)]
        public virtual ushort GMD_Name_Index {
            get => GetData<ushort>(38);
        }

        public const string GMD_Description_Index_displayName = "GMD Description Index";
        public const int GMD_Description_Index_sortIndex = 900;
        [SortOrder(GMD_Description_Index_sortIndex)]
        [DisplayName(GMD_Description_Index_displayName)]
        public virtual ushort GMD_Description_Index {
            get => GetData<ushort>(40);
        }

        public const int lastSortIndex = 950;
    }
}
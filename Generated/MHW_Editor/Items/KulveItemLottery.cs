using System;
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Items {
    public partial class KulveItemLottery {
        public const uint StructSize = 32;
        public const ulong InitialOffset = 6;
        public const long EntryCountOffset = 2;
        public const string EncryptionKey = null;
        public override string UniqueId => $"{Index}";

        public const string Index_displayName = "Index";
        public const int Index_sortIndex = 50;
        [SortOrder(Index_sortIndex)]
        [DisplayName(Index_displayName)]
        public virtual uint Index {
            get => GetData<uint>(0);
            set {
                if (GetData<uint>(0) == value) return;
                SetData(0, value, nameof(Index));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Index));
            }
        }

        public const string Weapon_Type_displayName = "Weapon Type";
        public const int Weapon_Type_sortIndex = 100;
        [SortOrder(Weapon_Type_sortIndex)]
        [DisplayName(Weapon_Type_displayName)]
        public virtual MHW_Template.Weapons.WeaponTypeOnlyWeapons Weapon_Type {
            get => (MHW_Template.Weapons.WeaponTypeOnlyWeapons) GetData<uint>(4);
            set {
                if ((MHW_Template.Weapons.WeaponTypeOnlyWeapons) GetData<uint>(4) == value) return;
                SetData(4, (uint) value, nameof(Weapon_Type));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Weapon_Type));
                OnPropertyChanged(nameof(Weapon_Id_button));
            }
        }

        public const string Weapon_Id_displayName = "Weapon Id";
        public const int Weapon_Id_sortIndex = 150;
        [SortOrder(Weapon_Id_sortIndex)]
        [DisplayName(Weapon_Id_displayName)]
        [DataSource(DataSourceType.CategorizedWeapons)]
        public virtual uint Weapon_Id {
            get => GetData<uint>(8);
            set {
                if (GetData<uint>(8) == value) return;
                SetData(8, value, nameof(Weapon_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Weapon_Id));
                OnPropertyChanged(nameof(Weapon_Id_button));
            }
        }

        [SortOrder(Weapon_Id_sortIndex)]
        [DisplayName(Weapon_Id_displayName)]
        [CustomSorter(typeof(ButtonSorter))]
        public string Weapon_Id_button => DataHelper.weaponIdNameLookup[Weapon_Type][MainWindow.locale].TryGet(Weapon_Id).ToStringWithId(Weapon_Id);

        public const string Grade_1_displayName = "Grade 1";
        public const int Grade_1_sortIndex = 200;
        [SortOrder(Grade_1_sortIndex)]
        [DisplayName(Grade_1_displayName)]
        public virtual uint Grade_1 {
            get => GetData<uint>(12);
            set {
                if (GetData<uint>(12) == value) return;
                SetData(12, value, nameof(Grade_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Grade_1));
            }
        }

        public const string Grade_2_displayName = "Grade 2";
        public const int Grade_2_sortIndex = 250;
        [SortOrder(Grade_2_sortIndex)]
        [DisplayName(Grade_2_displayName)]
        public virtual uint Grade_2 {
            get => GetData<uint>(16);
            set {
                if (GetData<uint>(16) == value) return;
                SetData(16, value, nameof(Grade_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Grade_2));
            }
        }

        public const string Grade_3_displayName = "Grade 3";
        public const int Grade_3_sortIndex = 300;
        [SortOrder(Grade_3_sortIndex)]
        [DisplayName(Grade_3_displayName)]
        public virtual uint Grade_3 {
            get => GetData<uint>(20);
            set {
                if (GetData<uint>(20) == value) return;
                SetData(20, value, nameof(Grade_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Grade_3));
            }
        }

        public const string Grade_4_displayName = "Grade 4";
        public const int Grade_4_sortIndex = 350;
        [SortOrder(Grade_4_sortIndex)]
        [DisplayName(Grade_4_displayName)]
        public virtual uint Grade_4 {
            get => GetData<uint>(24);
            set {
                if (GetData<uint>(24) == value) return;
                SetData(24, value, nameof(Grade_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Grade_4));
            }
        }

        public const string Grade_5_displayName = "Grade 5";
        public const int Grade_5_sortIndex = 400;
        [SortOrder(Grade_5_sortIndex)]
        [DisplayName(Grade_5_displayName)]
        public virtual uint Grade_5 {
            get => GetData<uint>(28);
            set {
                if (GetData<uint>(28) == value) return;
                SetData(28, value, nameof(Grade_5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Grade_5));
            }
        }

        public const int lastSortIndex = 450;
    }
}
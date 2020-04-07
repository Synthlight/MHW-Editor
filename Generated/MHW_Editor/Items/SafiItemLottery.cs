using System;
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Items {
    public partial class SafiItemLottery {
        public const uint StructSize = 72;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
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

        public const string All_Rarity_displayName = "All Rarity";
        public const int All_Rarity_sortIndex = 200;
        [SortOrder(All_Rarity_sortIndex)]
        [DisplayName(All_Rarity_displayName)]
        public virtual uint All_Rarity {
            get => GetData<uint>(12);
            set {
                if (GetData<uint>(12) == value) return;
                SetData(12, value, nameof(All_Rarity));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(All_Rarity));
            }
        }

        public const string GS_Rarity_displayName = "GS Rarity";
        public const int GS_Rarity_sortIndex = 250;
        [SortOrder(GS_Rarity_sortIndex)]
        [DisplayName(GS_Rarity_displayName)]
        public virtual uint GS_Rarity {
            get => GetData<uint>(16);
            set {
                if (GetData<uint>(16) == value) return;
                SetData(16, value, nameof(GS_Rarity));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(GS_Rarity));
            }
        }

        public const string LS_Rarity_displayName = "LS Rarity";
        public const int LS_Rarity_sortIndex = 300;
        [SortOrder(LS_Rarity_sortIndex)]
        [DisplayName(LS_Rarity_displayName)]
        public virtual uint LS_Rarity {
            get => GetData<uint>(20);
            set {
                if (GetData<uint>(20) == value) return;
                SetData(20, value, nameof(LS_Rarity));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(LS_Rarity));
            }
        }

        public const string SnS_Rarity_displayName = "SnS Rarity";
        public const int SnS_Rarity_sortIndex = 350;
        [SortOrder(SnS_Rarity_sortIndex)]
        [DisplayName(SnS_Rarity_displayName)]
        public virtual uint SnS_Rarity {
            get => GetData<uint>(24);
            set {
                if (GetData<uint>(24) == value) return;
                SetData(24, value, nameof(SnS_Rarity));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(SnS_Rarity));
            }
        }

        public const string DB_Rarity_displayName = "DB Rarity";
        public const int DB_Rarity_sortIndex = 400;
        [SortOrder(DB_Rarity_sortIndex)]
        [DisplayName(DB_Rarity_displayName)]
        public virtual uint DB_Rarity {
            get => GetData<uint>(28);
            set {
                if (GetData<uint>(28) == value) return;
                SetData(28, value, nameof(DB_Rarity));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(DB_Rarity));
            }
        }

        public const string Lance_Rarity_displayName = "Lance Rarity";
        public const int Lance_Rarity_sortIndex = 450;
        [SortOrder(Lance_Rarity_sortIndex)]
        [DisplayName(Lance_Rarity_displayName)]
        public virtual uint Lance_Rarity {
            get => GetData<uint>(32);
            set {
                if (GetData<uint>(32) == value) return;
                SetData(32, value, nameof(Lance_Rarity));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Lance_Rarity));
            }
        }

        public const string GL_Rarity_displayName = "GL Rarity";
        public const int GL_Rarity_sortIndex = 500;
        [SortOrder(GL_Rarity_sortIndex)]
        [DisplayName(GL_Rarity_displayName)]
        public virtual uint GL_Rarity {
            get => GetData<uint>(36);
            set {
                if (GetData<uint>(36) == value) return;
                SetData(36, value, nameof(GL_Rarity));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(GL_Rarity));
            }
        }

        public const string Hammer_Rarity_displayName = "Hammer Rarity";
        public const int Hammer_Rarity_sortIndex = 550;
        [SortOrder(Hammer_Rarity_sortIndex)]
        [DisplayName(Hammer_Rarity_displayName)]
        public virtual uint Hammer_Rarity {
            get => GetData<uint>(40);
            set {
                if (GetData<uint>(40) == value) return;
                SetData(40, value, nameof(Hammer_Rarity));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Hammer_Rarity));
            }
        }

        public const string HH_Rarity_displayName = "HH Rarity";
        public const int HH_Rarity_sortIndex = 600;
        [SortOrder(HH_Rarity_sortIndex)]
        [DisplayName(HH_Rarity_displayName)]
        public virtual uint HH_Rarity {
            get => GetData<uint>(44);
            set {
                if (GetData<uint>(44) == value) return;
                SetData(44, value, nameof(HH_Rarity));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(HH_Rarity));
            }
        }

        public const string SA_Rarity_displayName = "SA Rarity";
        public const int SA_Rarity_sortIndex = 650;
        [SortOrder(SA_Rarity_sortIndex)]
        [DisplayName(SA_Rarity_displayName)]
        public virtual uint SA_Rarity {
            get => GetData<uint>(48);
            set {
                if (GetData<uint>(48) == value) return;
                SetData(48, value, nameof(SA_Rarity));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(SA_Rarity));
            }
        }

        public const string CB_Rarity_displayName = "CB Rarity";
        public const int CB_Rarity_sortIndex = 700;
        [SortOrder(CB_Rarity_sortIndex)]
        [DisplayName(CB_Rarity_displayName)]
        public virtual uint CB_Rarity {
            get => GetData<uint>(52);
            set {
                if (GetData<uint>(52) == value) return;
                SetData(52, value, nameof(CB_Rarity));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(CB_Rarity));
            }
        }

        public const string IG_Rarity_displayName = "IG Rarity";
        public const int IG_Rarity_sortIndex = 750;
        [SortOrder(IG_Rarity_sortIndex)]
        [DisplayName(IG_Rarity_displayName)]
        public virtual uint IG_Rarity {
            get => GetData<uint>(56);
            set {
                if (GetData<uint>(56) == value) return;
                SetData(56, value, nameof(IG_Rarity));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(IG_Rarity));
            }
        }

        public const string LBG_Rarity_displayName = "LBG Rarity";
        public const int LBG_Rarity_sortIndex = 800;
        [SortOrder(LBG_Rarity_sortIndex)]
        [DisplayName(LBG_Rarity_displayName)]
        public virtual uint LBG_Rarity {
            get => GetData<uint>(60);
            set {
                if (GetData<uint>(60) == value) return;
                SetData(60, value, nameof(LBG_Rarity));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(LBG_Rarity));
            }
        }

        public const string HBG_Rarity_displayName = "HBG Rarity";
        public const int HBG_Rarity_sortIndex = 850;
        [SortOrder(HBG_Rarity_sortIndex)]
        [DisplayName(HBG_Rarity_displayName)]
        public virtual uint HBG_Rarity {
            get => GetData<uint>(64);
            set {
                if (GetData<uint>(64) == value) return;
                SetData(64, value, nameof(HBG_Rarity));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(HBG_Rarity));
            }
        }

        public const string Bow_Rarity_displayName = "Bow Rarity";
        public const int Bow_Rarity_sortIndex = 900;
        [SortOrder(Bow_Rarity_sortIndex)]
        [DisplayName(Bow_Rarity_displayName)]
        public virtual uint Bow_Rarity {
            get => GetData<uint>(68);
            set {
                if (GetData<uint>(68) == value) return;
                SetData(68, value, nameof(Bow_Rarity));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Bow_Rarity));
            }
        }

        public const int lastSortIndex = 950;
    }
}
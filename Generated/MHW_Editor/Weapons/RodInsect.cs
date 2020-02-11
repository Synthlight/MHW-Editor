using System.ComponentModel;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Weapons {
    public partial class RodInsect {
        public const uint StructSize = 28;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public const string EncryptionKey = "SFghFQVFJycHnypExurPwut98ZZq1cwvm7lpDpASeP4biRhstQgULzlb";
        public override string UniqueId => $"{Id}";

        public const string Index_displayName = "Index";
        public const int Index_sortIndex = 50;
        [SortOrder(Index_sortIndex)]
        [DisplayName(Index_displayName)]
        public virtual uint Index {
            get => GetData<uint>(0);
        }

        public const string Attack_Type_displayName = "Attack Type";
        public const int Attack_Type_sortIndex = 100;
        [SortOrder(Attack_Type_sortIndex)]
        [DisplayName(Attack_Type_displayName)]
        public virtual MHW_Template.Weapons.AttackType Attack_Type {
            get => (MHW_Template.Weapons.AttackType) GetData<byte>(4);
            set {
                if ((MHW_Template.Weapons.AttackType) GetData<byte>(4) == value) return;
                SetData(4, (byte) value, nameof(Attack_Type));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Attack_Type));
            }
        }

        public const string Id_displayName = "Id";
        public const int Id_sortIndex = 150;
        [SortOrder(Id_sortIndex)]
        [DisplayName(Id_displayName)]
        public virtual byte Id {
            get => GetData<byte>(5);
        }

        public const string Tree_Position_Id_displayName = "Tree Position Id";
        public const int Tree_Position_Id_sortIndex = 200;
        [SortOrder(Tree_Position_Id_sortIndex)]
        [DisplayName(Tree_Position_Id_displayName)]
        public virtual byte Tree_Position_Id {
            get => GetData<byte>(6);
            set {
                if (GetData<byte>(6) == value) return;
                SetData(6, value, nameof(Tree_Position_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Tree_Position_Id));
            }
        }

        public const string Base_Model_Id_displayName = "Base Model Id";
        public const int Base_Model_Id_sortIndex = 250;
        [SortOrder(Base_Model_Id_sortIndex)]
        [DisplayName(Base_Model_Id_displayName)]
        public virtual ushort Base_Model_Id {
            get => GetData<ushort>(7);
            set {
                if (GetData<ushort>(7) == value) return;
                SetData(7, value, nameof(Base_Model_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Base_Model_Id));
            }
        }

        public const string Tree_Id_displayName = "Tree Id";
        public const int Tree_Id_sortIndex = 300;
        [SortOrder(Tree_Id_sortIndex)]
        [DisplayName(Tree_Id_displayName)]
        public virtual byte Tree_Id {
            get => GetData<byte>(9);
            set {
                if (GetData<byte>(9) == value) return;
                SetData(9, value, nameof(Tree_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Tree_Id));
            }
        }

        public const string Craft_Cost_displayName = "Craft Cost";
        public const int Craft_Cost_sortIndex = 350;
        [SortOrder(Craft_Cost_sortIndex)]
        [DisplayName(Craft_Cost_displayName)]
        public virtual uint Craft_Cost {
            get => GetData<uint>(10);
            set {
                if (GetData<uint>(10) == value) return;
                SetData(10, value, nameof(Craft_Cost));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Craft_Cost));
            }
        }

        public const string Rarity_displayName = "Rarity";
        public const int Rarity_sortIndex = 400;
        [SortOrder(Rarity_sortIndex)]
        [DisplayName(Rarity_displayName)]
        public virtual byte Rarity {
            get => GetData<byte>(14);
            set {
                if (GetData<byte>(14) == value) return;
                SetData(14, value, nameof(Rarity));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Rarity));
            }
        }

        public const string Power_displayName = "Power";
        public const int Power_sortIndex = 450;
        [SortOrder(Power_sortIndex)]
        [DisplayName(Power_displayName)]
        public virtual ushort Power {
            get => GetData<ushort>(15);
            set {
                if (GetData<ushort>(15) == value) return;
                SetData(15, value, nameof(Power));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Power));
            }
        }

        public const string Speed_displayName = "Speed";
        public const int Speed_sortIndex = 500;
        [SortOrder(Speed_sortIndex)]
        [DisplayName(Speed_displayName)]
        public virtual ushort Speed {
            get => GetData<ushort>(17);
            set {
                if (GetData<ushort>(17) == value) return;
                SetData(17, value, nameof(Speed));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Speed));
            }
        }

        public const string Heal_displayName = "Heal";
        public const int Heal_sortIndex = 550;
        [SortOrder(Heal_sortIndex)]
        [DisplayName(Heal_displayName)]
        public virtual ushort Heal {
            get => GetData<ushort>(19);
            set {
                if (GetData<ushort>(19) == value) return;
                SetData(19, value, nameof(Heal));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Heal));
            }
        }

        public const string Element_displayName = "Element";
        public const int Element_sortIndex = 600;
        [SortOrder(Element_sortIndex)]
        [DisplayName(Element_displayName)]
        public virtual ushort Element {
            get => GetData<ushort>(21);
            set {
                if (GetData<ushort>(21) == value) return;
                SetData(21, value, nameof(Element));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Element));
            }
        }

        public const string Dust_Effect_displayName = "Dust Effect";
        public const int Dust_Effect_sortIndex = 650;
        [SortOrder(Dust_Effect_sortIndex)]
        [DisplayName(Dust_Effect_displayName)]
        public virtual MHW_Template.Weapons.DustEffect Dust_Effect {
            get => (MHW_Template.Weapons.DustEffect) GetData<ushort>(23);
            set {
                if ((MHW_Template.Weapons.DustEffect) GetData<ushort>(23) == value) return;
                SetData(23, (ushort) value, nameof(Dust_Effect));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Dust_Effect));
            }
        }

        public const string Tree_Pos_displayName = "Tree Pos";
        public const int Tree_Pos_sortIndex = 700;
        [SortOrder(Tree_Pos_sortIndex)]
        [DisplayName(Tree_Pos_displayName)]
        public virtual byte Tree_Pos {
            get => GetData<byte>(25);
            set {
                if (GetData<byte>(25) == value) return;
                SetData(25, value, nameof(Tree_Pos));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Tree_Pos));
            }
        }

        public const string Equip_Id_displayName = "Equip Id";
        public const int Equip_Id_sortIndex = 750;
        [SortOrder(Equip_Id_sortIndex)]
        [DisplayName(Equip_Id_displayName)]
        public virtual ushort Equip_Id {
            get => GetData<ushort>(26);
            set {
                if (GetData<ushort>(26) == value) return;
                SetData(26, value, nameof(Equip_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Equip_Id));
            }
        }

        public const int lastSortIndex = 800;
    }
}
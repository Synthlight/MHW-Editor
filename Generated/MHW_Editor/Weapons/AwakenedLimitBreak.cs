using System;
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Weapons {
    public partial class AwakenedLimitBreak {
        public const uint StructSize = 45;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public const string EncryptionKey = null;
        public override string UniqueId => $"{Index}";

        public const string Skill_Id_displayName = "Skill Id";
        public const int Skill_Id_sortIndex = 50;
        [SortOrder(Skill_Id_sortIndex)]
        [DisplayName(Skill_Id_displayName)]
        [DataSource(DataSourceType.Skills)]
        public virtual ushort Skill_Id {
            get => GetData<ushort>(0);
            set {
                if (GetData<ushort>(0) == value) return;
                SetData(0, value, nameof(Skill_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Skill_Id));
                OnPropertyChanged(nameof(Skill_Id_button));
            }
        }

        [SortOrder(Skill_Id_sortIndex)]
        [DisplayName(Skill_Id_displayName)]
        [CustomSorter(typeof(ButtonSorter))]
        public string Skill_Id_button => DataHelper.skillNames[MainWindow.locale].TryGet(Skill_Id).ToStringWithId(Skill_Id);

        public const string Group_Id_displayName = "Group Id";
        public const int Group_Id_sortIndex = 100;
        [SortOrder(Group_Id_sortIndex)]
        [DisplayName(Group_Id_displayName)]
        public virtual uint Group_Id {
            get => GetData<uint>(2);
            set {
                if (GetData<uint>(2) == value) return;
                SetData(2, value, nameof(Group_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Group_Id));
            }
        }

        public const string Rarity_displayName = "Rarity";
        public const int Rarity_sortIndex = 150;
        [SortOrder(Rarity_sortIndex)]
        [DisplayName(Rarity_displayName)]
        public virtual uint Rarity {
            get => GetData<uint>(6);
            set {
                if (GetData<uint>(6) == value) return;
                SetData(6, value, nameof(Rarity));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Rarity));
            }
        }

        public const string Has_Upgrade_displayName = "Has Upgrade";
        public const int Has_Upgrade_sortIndex = 200;
        [SortOrder(Has_Upgrade_sortIndex)]
        [DisplayName(Has_Upgrade_displayName)]
        public virtual bool Has_Upgrade {
            get => (bool) Convert.ToBoolean(GetData<byte>(10));
            set {
                if (Convert.ToBoolean(GetData<byte>(10)) == value) return;
                SetData(10, Convert.ToByte(value), nameof(Has_Upgrade));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Has_Upgrade));
            }
        }

        public const string Previous_Upgrade_Id_When_Max_Lvl_displayName = "Previous Upgrade Id When Max Lvl";
        public const int Previous_Upgrade_Id_When_Max_Lvl_sortIndex = 250;
        [SortOrder(Previous_Upgrade_Id_When_Max_Lvl_sortIndex)]
        [DisplayName(Previous_Upgrade_Id_When_Max_Lvl_displayName)]
        public virtual ushort Previous_Upgrade_Id_When_Max_Lvl {
            get => GetData<ushort>(11);
            set {
                if (GetData<ushort>(11) == value) return;
                SetData(11, value, nameof(Previous_Upgrade_Id_When_Max_Lvl));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Previous_Upgrade_Id_When_Max_Lvl));
            }
        }

        public const string Next_Upgrade_Id_displayName = "Next Upgrade Id";
        public const int Next_Upgrade_Id_sortIndex = 300;
        [SortOrder(Next_Upgrade_Id_sortIndex)]
        [DisplayName(Next_Upgrade_Id_displayName)]
        public virtual ushort Next_Upgrade_Id {
            get => GetData<ushort>(13);
            set {
                if (GetData<ushort>(13) == value) return;
                SetData(13, value, nameof(Next_Upgrade_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Next_Upgrade_Id));
            }
        }

        public const string Can_Stack_displayName = "Can Stack";
        public const int Can_Stack_sortIndex = 350;
        [SortOrder(Can_Stack_sortIndex)]
        [DisplayName(Can_Stack_displayName)]
        public virtual bool Can_Stack {
            get => (bool) Convert.ToBoolean(GetData<byte>(15));
            set {
                if (Convert.ToBoolean(GetData<byte>(15)) == value) return;
                SetData(15, Convert.ToByte(value), nameof(Can_Stack));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Can_Stack));
            }
        }

        public const string Unk8_displayName = "Unk8";
        public const int Unk8_sortIndex = 400;
        [SortOrder(Unk8_sortIndex)]
        [DisplayName(Unk8_displayName)]
        public virtual bool Unk8 {
            get => (bool) Convert.ToBoolean(GetData<byte>(16));
            set {
                if (Convert.ToBoolean(GetData<byte>(16)) == value) return;
                SetData(16, Convert.ToByte(value), nameof(Unk8));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk8));
            }
        }

        public const string Lvl_1_Id_displayName = "Lvl 1 Id";
        public const int Lvl_1_Id_sortIndex = 450;
        [SortOrder(Lvl_1_Id_sortIndex)]
        [DisplayName(Lvl_1_Id_displayName)]
        public virtual ushort Lvl_1_Id {
            get => GetData<ushort>(17);
            set {
                if (GetData<ushort>(17) == value) return;
                SetData(17, value, nameof(Lvl_1_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Lvl_1_Id));
            }
        }

        public const string Lvl_2_Id_displayName = "Lvl 2 Id";
        public const int Lvl_2_Id_sortIndex = 500;
        [SortOrder(Lvl_2_Id_sortIndex)]
        [DisplayName(Lvl_2_Id_displayName)]
        public virtual ushort Lvl_2_Id {
            get => GetData<ushort>(19);
            set {
                if (GetData<ushort>(19) == value) return;
                SetData(19, value, nameof(Lvl_2_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Lvl_2_Id));
            }
        }

        public const string Lvl_3_Id_displayName = "Lvl 3 Id";
        public const int Lvl_3_Id_sortIndex = 550;
        [SortOrder(Lvl_3_Id_sortIndex)]
        [DisplayName(Lvl_3_Id_displayName)]
        public virtual ushort Lvl_3_Id {
            get => GetData<ushort>(21);
            set {
                if (GetData<ushort>(21) == value) return;
                SetData(21, value, nameof(Lvl_3_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Lvl_3_Id));
            }
        }

        public const string Lvl_4_Id_displayName = "Lvl 4 Id";
        public const int Lvl_4_Id_sortIndex = 600;
        [SortOrder(Lvl_4_Id_sortIndex)]
        [DisplayName(Lvl_4_Id_displayName)]
        public virtual ushort Lvl_4_Id {
            get => GetData<ushort>(23);
            set {
                if (GetData<ushort>(23) == value) return;
                SetData(23, value, nameof(Lvl_4_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Lvl_4_Id));
            }
        }

        public const string Lvl_5_Id_displayName = "Lvl 5 Id";
        public const int Lvl_5_Id_sortIndex = 650;
        [SortOrder(Lvl_5_Id_sortIndex)]
        [DisplayName(Lvl_5_Id_displayName)]
        public virtual ushort Lvl_5_Id {
            get => GetData<ushort>(25);
            set {
                if (GetData<ushort>(25) == value) return;
                SetData(25, value, nameof(Lvl_5_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Lvl_5_Id));
            }
        }

        public const string Works_on_Great_Sword_displayName = "Works on Great Sword";
        public const int Works_on_Great_Sword_sortIndex = 700;
        [SortOrder(Works_on_Great_Sword_sortIndex)]
        [DisplayName(Works_on_Great_Sword_displayName)]
        public virtual bool Works_on_Great_Sword {
            get => (bool) Convert.ToBoolean(GetData<byte>(27));
            set {
                if (Convert.ToBoolean(GetData<byte>(27)) == value) return;
                SetData(27, Convert.ToByte(value), nameof(Works_on_Great_Sword));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Works_on_Great_Sword));
            }
        }

        public const string Works_on_Sword_Shield_displayName = "Works on Sword & Shield";
        public const int Works_on_Sword_Shield_sortIndex = 750;
        [SortOrder(Works_on_Sword_Shield_sortIndex)]
        [DisplayName(Works_on_Sword_Shield_displayName)]
        public virtual bool Works_on_Sword_Shield {
            get => (bool) Convert.ToBoolean(GetData<byte>(28));
            set {
                if (Convert.ToBoolean(GetData<byte>(28)) == value) return;
                SetData(28, Convert.ToByte(value), nameof(Works_on_Sword_Shield));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Works_on_Sword_Shield));
            }
        }

        public const string Works_on_Dual_Blades_displayName = "Works on Dual Blades";
        public const int Works_on_Dual_Blades_sortIndex = 800;
        [SortOrder(Works_on_Dual_Blades_sortIndex)]
        [DisplayName(Works_on_Dual_Blades_displayName)]
        public virtual bool Works_on_Dual_Blades {
            get => (bool) Convert.ToBoolean(GetData<byte>(29));
            set {
                if (Convert.ToBoolean(GetData<byte>(29)) == value) return;
                SetData(29, Convert.ToByte(value), nameof(Works_on_Dual_Blades));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Works_on_Dual_Blades));
            }
        }

        public const string Works_on_Long_Sword_displayName = "Works on Long Sword";
        public const int Works_on_Long_Sword_sortIndex = 850;
        [SortOrder(Works_on_Long_Sword_sortIndex)]
        [DisplayName(Works_on_Long_Sword_displayName)]
        public virtual bool Works_on_Long_Sword {
            get => (bool) Convert.ToBoolean(GetData<byte>(30));
            set {
                if (Convert.ToBoolean(GetData<byte>(30)) == value) return;
                SetData(30, Convert.ToByte(value), nameof(Works_on_Long_Sword));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Works_on_Long_Sword));
            }
        }

        public const string Works_on_Hammer_displayName = "Works on Hammer";
        public const int Works_on_Hammer_sortIndex = 900;
        [SortOrder(Works_on_Hammer_sortIndex)]
        [DisplayName(Works_on_Hammer_displayName)]
        public virtual bool Works_on_Hammer {
            get => (bool) Convert.ToBoolean(GetData<byte>(31));
            set {
                if (Convert.ToBoolean(GetData<byte>(31)) == value) return;
                SetData(31, Convert.ToByte(value), nameof(Works_on_Hammer));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Works_on_Hammer));
            }
        }

        public const string Works_on_Hunting_Horn_displayName = "Works on Hunting Horn";
        public const int Works_on_Hunting_Horn_sortIndex = 950;
        [SortOrder(Works_on_Hunting_Horn_sortIndex)]
        [DisplayName(Works_on_Hunting_Horn_displayName)]
        public virtual bool Works_on_Hunting_Horn {
            get => (bool) Convert.ToBoolean(GetData<byte>(32));
            set {
                if (Convert.ToBoolean(GetData<byte>(32)) == value) return;
                SetData(32, Convert.ToByte(value), nameof(Works_on_Hunting_Horn));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Works_on_Hunting_Horn));
            }
        }

        public const string Works_on_Lance_displayName = "Works on Lance";
        public const int Works_on_Lance_sortIndex = 1000;
        [SortOrder(Works_on_Lance_sortIndex)]
        [DisplayName(Works_on_Lance_displayName)]
        public virtual bool Works_on_Lance {
            get => (bool) Convert.ToBoolean(GetData<byte>(33));
            set {
                if (Convert.ToBoolean(GetData<byte>(33)) == value) return;
                SetData(33, Convert.ToByte(value), nameof(Works_on_Lance));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Works_on_Lance));
            }
        }

        public const string Works_on_Gunlance_displayName = "Works on Gunlance";
        public const int Works_on_Gunlance_sortIndex = 1050;
        [SortOrder(Works_on_Gunlance_sortIndex)]
        [DisplayName(Works_on_Gunlance_displayName)]
        public virtual bool Works_on_Gunlance {
            get => (bool) Convert.ToBoolean(GetData<byte>(34));
            set {
                if (Convert.ToBoolean(GetData<byte>(34)) == value) return;
                SetData(34, Convert.ToByte(value), nameof(Works_on_Gunlance));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Works_on_Gunlance));
            }
        }

        public const string Works_on_Switch_Axe_displayName = "Works on Switch Axe";
        public const int Works_on_Switch_Axe_sortIndex = 1100;
        [SortOrder(Works_on_Switch_Axe_sortIndex)]
        [DisplayName(Works_on_Switch_Axe_displayName)]
        public virtual bool Works_on_Switch_Axe {
            get => (bool) Convert.ToBoolean(GetData<byte>(35));
            set {
                if (Convert.ToBoolean(GetData<byte>(35)) == value) return;
                SetData(35, Convert.ToByte(value), nameof(Works_on_Switch_Axe));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Works_on_Switch_Axe));
            }
        }

        public const string Works_on_Charge_Blade_displayName = "Works on Charge Blade";
        public const int Works_on_Charge_Blade_sortIndex = 1150;
        [SortOrder(Works_on_Charge_Blade_sortIndex)]
        [DisplayName(Works_on_Charge_Blade_displayName)]
        public virtual bool Works_on_Charge_Blade {
            get => (bool) Convert.ToBoolean(GetData<byte>(36));
            set {
                if (Convert.ToBoolean(GetData<byte>(36)) == value) return;
                SetData(36, Convert.ToByte(value), nameof(Works_on_Charge_Blade));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Works_on_Charge_Blade));
            }
        }

        public const string Works_on_Insect_Glaive_displayName = "Works on Insect Glaive";
        public const int Works_on_Insect_Glaive_sortIndex = 1200;
        [SortOrder(Works_on_Insect_Glaive_sortIndex)]
        [DisplayName(Works_on_Insect_Glaive_displayName)]
        public virtual bool Works_on_Insect_Glaive {
            get => (bool) Convert.ToBoolean(GetData<byte>(37));
            set {
                if (Convert.ToBoolean(GetData<byte>(37)) == value) return;
                SetData(37, Convert.ToByte(value), nameof(Works_on_Insect_Glaive));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Works_on_Insect_Glaive));
            }
        }

        public const string Works_on_Bow_displayName = "Works on Bow";
        public const int Works_on_Bow_sortIndex = 1250;
        [SortOrder(Works_on_Bow_sortIndex)]
        [DisplayName(Works_on_Bow_displayName)]
        public virtual bool Works_on_Bow {
            get => (bool) Convert.ToBoolean(GetData<byte>(38));
            set {
                if (Convert.ToBoolean(GetData<byte>(38)) == value) return;
                SetData(38, Convert.ToByte(value), nameof(Works_on_Bow));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Works_on_Bow));
            }
        }

        public const string Works_on_HBG_displayName = "Works on HBG";
        public const int Works_on_HBG_sortIndex = 1300;
        [SortOrder(Works_on_HBG_sortIndex)]
        [DisplayName(Works_on_HBG_displayName)]
        public virtual bool Works_on_HBG {
            get => (bool) Convert.ToBoolean(GetData<byte>(39));
            set {
                if (Convert.ToBoolean(GetData<byte>(39)) == value) return;
                SetData(39, Convert.ToByte(value), nameof(Works_on_HBG));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Works_on_HBG));
            }
        }

        public const string Works_on_LBG_displayName = "Works on LBG";
        public const int Works_on_LBG_sortIndex = 1350;
        [SortOrder(Works_on_LBG_sortIndex)]
        [DisplayName(Works_on_LBG_displayName)]
        public virtual bool Works_on_LBG {
            get => (bool) Convert.ToBoolean(GetData<byte>(40));
            set {
                if (Convert.ToBoolean(GetData<byte>(40)) == value) return;
                SetData(40, Convert.ToByte(value), nameof(Works_on_LBG));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Works_on_LBG));
            }
        }

        public const string Unk28_displayName = "Unk28";
        public const int Unk28_sortIndex = 1400;
        [SortOrder(Unk28_sortIndex)]
        [DisplayName(Unk28_displayName)]
        public virtual byte Unk28 {
            get => GetData<byte>(44);
            set {
                if (GetData<byte>(44) == value) return;
                SetData(44, value, nameof(Unk28));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk28));
            }
        }

        public const int lastSortIndex = 1450;
    }
}
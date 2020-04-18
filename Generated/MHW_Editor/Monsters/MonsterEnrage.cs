using System;
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Monsters {
    public partial class MonsterEnrage {
        public const uint StructSize = 144;
        public const ulong InitialOffset = 0;
        public const long EntryCountOffset = -1;
        public const string EncryptionKey = null;
        public override string UniqueId => $"0";

        public const string Monster_Id_displayName = "Monster Id";
        public const int Monster_Id_sortIndex = 50;
        [SortOrder(Monster_Id_sortIndex)]
        [DisplayName(Monster_Id_displayName)]
        public virtual uint Monster_Id {
            get => GetData<uint>(8);
            set {
                if (GetData<uint>(8) == value) return;
                SetData(8, value, nameof(Monster_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Monster_Id));
            }
        }

        public const string LR_HR_Build_to_Trigger_displayName = "LR/HR Build to Trigger";
        public const int LR_HR_Build_to_Trigger_sortIndex = 100;
        [SortOrder(LR_HR_Build_to_Trigger_sortIndex)]
        [DisplayName(LR_HR_Build_to_Trigger_displayName)]
        public virtual uint LR_HR_Build_to_Trigger {
            get => GetData<uint>(16);
            set {
                if (GetData<uint>(16) == value) return;
                SetData(16, value, nameof(LR_HR_Build_to_Trigger));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(LR_HR_Build_to_Trigger));
            }
        }

        public const string LR_HR_Duration_displayName = "LR/HR Duration";
        public const int LR_HR_Duration_sortIndex = 150;
        [SortOrder(LR_HR_Duration_sortIndex)]
        [DisplayName(LR_HR_Duration_displayName)]
        public virtual float LR_HR_Duration {
            get => GetData<float>(20);
            set {
                if (GetData<float>(20) == value) return;
                SetData(20, value, nameof(LR_HR_Duration));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(LR_HR_Duration));
            }
        }

        public const string LR_HR_Speed_Modifier_displayName = "LR/HR Speed Modifier";
        public const int LR_HR_Speed_Modifier_sortIndex = 200;
        [SortOrder(LR_HR_Speed_Modifier_sortIndex)]
        [DisplayName(LR_HR_Speed_Modifier_displayName)]
        public virtual float LR_HR_Speed_Modifier {
            get => GetData<float>(24);
            set {
                if (GetData<float>(24) == value) return;
                SetData(24, value, nameof(LR_HR_Speed_Modifier));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(LR_HR_Speed_Modifier));
            }
        }

        public const string LR_HR_Damage_Modifier_displayName = "LR/HR Damage Modifier";
        public const int LR_HR_Damage_Modifier_sortIndex = 250;
        [SortOrder(LR_HR_Damage_Modifier_sortIndex)]
        [DisplayName(LR_HR_Damage_Modifier_displayName)]
        public virtual float LR_HR_Damage_Modifier {
            get => GetData<float>(28);
            set {
                if (GetData<float>(28) == value) return;
                SetData(28, value, nameof(LR_HR_Damage_Modifier));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(LR_HR_Damage_Modifier));
            }
        }

        public const string LR_HR_Player_Damage_Modifier_displayName = "LR/HR Player Damage Modifier";
        public const int LR_HR_Player_Damage_Modifier_sortIndex = 300;
        [SortOrder(LR_HR_Player_Damage_Modifier_sortIndex)]
        [DisplayName(LR_HR_Player_Damage_Modifier_displayName)]
        public virtual float LR_HR_Player_Damage_Modifier {
            get => GetData<float>(32);
            set {
                if (GetData<float>(32) == value) return;
                SetData(32, value, nameof(LR_HR_Player_Damage_Modifier));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(LR_HR_Player_Damage_Modifier));
            }
        }

        public const string LR_HR_Build_Multiplier_by_HP_100__displayName = "LR/HR Build Multiplier by HP (100%)";
        public const int LR_HR_Build_Multiplier_by_HP_100__sortIndex = 350;
        [SortOrder(LR_HR_Build_Multiplier_by_HP_100__sortIndex)]
        [DisplayName(LR_HR_Build_Multiplier_by_HP_100__displayName)]
        public virtual float LR_HR_Build_Multiplier_by_HP_100_ {
            get => GetData<float>(36);
            set {
                if (GetData<float>(36) == value) return;
                SetData(36, value, nameof(LR_HR_Build_Multiplier_by_HP_100_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(LR_HR_Build_Multiplier_by_HP_100_));
            }
        }

        public const string LR_HR_Build_Multiplier_by_HP_88_99__displayName = "LR/HR Build Multiplier by HP (88%-99%)";
        public const int LR_HR_Build_Multiplier_by_HP_88_99__sortIndex = 400;
        [SortOrder(LR_HR_Build_Multiplier_by_HP_88_99__sortIndex)]
        [DisplayName(LR_HR_Build_Multiplier_by_HP_88_99__displayName)]
        public virtual float LR_HR_Build_Multiplier_by_HP_88_99_ {
            get => GetData<float>(40);
            set {
                if (GetData<float>(40) == value) return;
                SetData(40, value, nameof(LR_HR_Build_Multiplier_by_HP_88_99_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(LR_HR_Build_Multiplier_by_HP_88_99_));
            }
        }

        public const string LR_HR_Build_Multiplier_by_HP_77_88__displayName = "LR/HR Build Multiplier by HP (77%-88%)";
        public const int LR_HR_Build_Multiplier_by_HP_77_88__sortIndex = 450;
        [SortOrder(LR_HR_Build_Multiplier_by_HP_77_88__sortIndex)]
        [DisplayName(LR_HR_Build_Multiplier_by_HP_77_88__displayName)]
        public virtual float LR_HR_Build_Multiplier_by_HP_77_88_ {
            get => GetData<float>(44);
            set {
                if (GetData<float>(44) == value) return;
                SetData(44, value, nameof(LR_HR_Build_Multiplier_by_HP_77_88_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(LR_HR_Build_Multiplier_by_HP_77_88_));
            }
        }

        public const string LR_HR_Build_Multiplier_by_HP_66_77__displayName = "LR/HR Build Multiplier by HP (66%-77%)";
        public const int LR_HR_Build_Multiplier_by_HP_66_77__sortIndex = 500;
        [SortOrder(LR_HR_Build_Multiplier_by_HP_66_77__sortIndex)]
        [DisplayName(LR_HR_Build_Multiplier_by_HP_66_77__displayName)]
        public virtual float LR_HR_Build_Multiplier_by_HP_66_77_ {
            get => GetData<float>(48);
            set {
                if (GetData<float>(48) == value) return;
                SetData(48, value, nameof(LR_HR_Build_Multiplier_by_HP_66_77_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(LR_HR_Build_Multiplier_by_HP_66_77_));
            }
        }

        public const string LR_HR_Build_Multiplier_by_HP_55_66__displayName = "LR/HR Build Multiplier by HP (55%-66%)";
        public const int LR_HR_Build_Multiplier_by_HP_55_66__sortIndex = 550;
        [SortOrder(LR_HR_Build_Multiplier_by_HP_55_66__sortIndex)]
        [DisplayName(LR_HR_Build_Multiplier_by_HP_55_66__displayName)]
        public virtual float LR_HR_Build_Multiplier_by_HP_55_66_ {
            get => GetData<float>(52);
            set {
                if (GetData<float>(52) == value) return;
                SetData(52, value, nameof(LR_HR_Build_Multiplier_by_HP_55_66_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(LR_HR_Build_Multiplier_by_HP_55_66_));
            }
        }

        public const string LR_HR_Build_Multiplier_by_HP_44_55__displayName = "LR/HR Build Multiplier by HP (44%-55%)";
        public const int LR_HR_Build_Multiplier_by_HP_44_55__sortIndex = 600;
        [SortOrder(LR_HR_Build_Multiplier_by_HP_44_55__sortIndex)]
        [DisplayName(LR_HR_Build_Multiplier_by_HP_44_55__displayName)]
        public virtual float LR_HR_Build_Multiplier_by_HP_44_55_ {
            get => GetData<float>(56);
            set {
                if (GetData<float>(56) == value) return;
                SetData(56, value, nameof(LR_HR_Build_Multiplier_by_HP_44_55_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(LR_HR_Build_Multiplier_by_HP_44_55_));
            }
        }

        public const string LR_HR_Build_Multiplier_by_HP_33_44__displayName = "LR/HR Build Multiplier by HP (33%-44%)";
        public const int LR_HR_Build_Multiplier_by_HP_33_44__sortIndex = 650;
        [SortOrder(LR_HR_Build_Multiplier_by_HP_33_44__sortIndex)]
        [DisplayName(LR_HR_Build_Multiplier_by_HP_33_44__displayName)]
        public virtual float LR_HR_Build_Multiplier_by_HP_33_44_ {
            get => GetData<float>(60);
            set {
                if (GetData<float>(60) == value) return;
                SetData(60, value, nameof(LR_HR_Build_Multiplier_by_HP_33_44_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(LR_HR_Build_Multiplier_by_HP_33_44_));
            }
        }

        public const string LR_HR_Build_Multiplier_by_HP_22_33__displayName = "LR/HR Build Multiplier by HP (22%-33%)";
        public const int LR_HR_Build_Multiplier_by_HP_22_33__sortIndex = 700;
        [SortOrder(LR_HR_Build_Multiplier_by_HP_22_33__sortIndex)]
        [DisplayName(LR_HR_Build_Multiplier_by_HP_22_33__displayName)]
        public virtual float LR_HR_Build_Multiplier_by_HP_22_33_ {
            get => GetData<float>(64);
            set {
                if (GetData<float>(64) == value) return;
                SetData(64, value, nameof(LR_HR_Build_Multiplier_by_HP_22_33_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(LR_HR_Build_Multiplier_by_HP_22_33_));
            }
        }

        public const string LR_HR_Build_Multiplier_by_HP_11_22__displayName = "LR/HR Build Multiplier by HP (11%-22%)";
        public const int LR_HR_Build_Multiplier_by_HP_11_22__sortIndex = 750;
        [SortOrder(LR_HR_Build_Multiplier_by_HP_11_22__sortIndex)]
        [DisplayName(LR_HR_Build_Multiplier_by_HP_11_22__displayName)]
        public virtual float LR_HR_Build_Multiplier_by_HP_11_22_ {
            get => GetData<float>(68);
            set {
                if (GetData<float>(68) == value) return;
                SetData(68, value, nameof(LR_HR_Build_Multiplier_by_HP_11_22_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(LR_HR_Build_Multiplier_by_HP_11_22_));
            }
        }

        public const string LR_HR_Build_Multiplier_by_HP_0_11__displayName = "LR/HR Build Multiplier by HP (0%-11%)";
        public const int LR_HR_Build_Multiplier_by_HP_0_11__sortIndex = 800;
        [SortOrder(LR_HR_Build_Multiplier_by_HP_0_11__sortIndex)]
        [DisplayName(LR_HR_Build_Multiplier_by_HP_0_11__displayName)]
        public virtual float LR_HR_Build_Multiplier_by_HP_0_11_ {
            get => GetData<float>(72);
            set {
                if (GetData<float>(72) == value) return;
                SetData(72, value, nameof(LR_HR_Build_Multiplier_by_HP_0_11_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(LR_HR_Build_Multiplier_by_HP_0_11_));
            }
        }

        public const string LR_HR_Out_of_Combat_Decay_Multiplier_displayName = "LR/HR Out of Combat Decay Multiplier";
        public const int LR_HR_Out_of_Combat_Decay_Multiplier_sortIndex = 850;
        [SortOrder(LR_HR_Out_of_Combat_Decay_Multiplier_sortIndex)]
        [DisplayName(LR_HR_Out_of_Combat_Decay_Multiplier_displayName)]
        public virtual float LR_HR_Out_of_Combat_Decay_Multiplier {
            get => GetData<float>(76);
            set {
                if (GetData<float>(76) == value) return;
                SetData(76, value, nameof(LR_HR_Out_of_Combat_Decay_Multiplier));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(LR_HR_Out_of_Combat_Decay_Multiplier));
            }
        }

        public const string MR_Build_to_Trigger_displayName = "MR Build to Trigger";
        public const int MR_Build_to_Trigger_sortIndex = 900;
        [SortOrder(MR_Build_to_Trigger_sortIndex)]
        [DisplayName(MR_Build_to_Trigger_displayName)]
        public virtual uint MR_Build_to_Trigger {
            get => GetData<uint>(80);
            set {
                if (GetData<uint>(80) == value) return;
                SetData(80, value, nameof(MR_Build_to_Trigger));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(MR_Build_to_Trigger));
            }
        }

        public const string MR_Duration_displayName = "MR Duration";
        public const int MR_Duration_sortIndex = 950;
        [SortOrder(MR_Duration_sortIndex)]
        [DisplayName(MR_Duration_displayName)]
        public virtual float MR_Duration {
            get => GetData<float>(84);
            set {
                if (GetData<float>(84) == value) return;
                SetData(84, value, nameof(MR_Duration));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(MR_Duration));
            }
        }

        public const string MR_Speed_Modifier_displayName = "MR Speed Modifier";
        public const int MR_Speed_Modifier_sortIndex = 1000;
        [SortOrder(MR_Speed_Modifier_sortIndex)]
        [DisplayName(MR_Speed_Modifier_displayName)]
        public virtual float MR_Speed_Modifier {
            get => GetData<float>(88);
            set {
                if (GetData<float>(88) == value) return;
                SetData(88, value, nameof(MR_Speed_Modifier));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(MR_Speed_Modifier));
            }
        }

        public const string MR_Damage_Modifier_displayName = "MR Damage Modifier";
        public const int MR_Damage_Modifier_sortIndex = 1050;
        [SortOrder(MR_Damage_Modifier_sortIndex)]
        [DisplayName(MR_Damage_Modifier_displayName)]
        public virtual float MR_Damage_Modifier {
            get => GetData<float>(92);
            set {
                if (GetData<float>(92) == value) return;
                SetData(92, value, nameof(MR_Damage_Modifier));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(MR_Damage_Modifier));
            }
        }

        public const string MR_Player_Damage_Modifier_displayName = "MR Player Damage Modifier";
        public const int MR_Player_Damage_Modifier_sortIndex = 1100;
        [SortOrder(MR_Player_Damage_Modifier_sortIndex)]
        [DisplayName(MR_Player_Damage_Modifier_displayName)]
        public virtual float MR_Player_Damage_Modifier {
            get => GetData<float>(96);
            set {
                if (GetData<float>(96) == value) return;
                SetData(96, value, nameof(MR_Player_Damage_Modifier));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(MR_Player_Damage_Modifier));
            }
        }

        public const string MR_Build_Multiplier_by_HP_100__displayName = "MR Build Multiplier by HP (100%)";
        public const int MR_Build_Multiplier_by_HP_100__sortIndex = 1150;
        [SortOrder(MR_Build_Multiplier_by_HP_100__sortIndex)]
        [DisplayName(MR_Build_Multiplier_by_HP_100__displayName)]
        public virtual float MR_Build_Multiplier_by_HP_100_ {
            get => GetData<float>(100);
            set {
                if (GetData<float>(100) == value) return;
                SetData(100, value, nameof(MR_Build_Multiplier_by_HP_100_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(MR_Build_Multiplier_by_HP_100_));
            }
        }

        public const string MR_Build_Multiplier_by_HP_88_99__displayName = "MR Build Multiplier by HP (88%-99%)";
        public const int MR_Build_Multiplier_by_HP_88_99__sortIndex = 1200;
        [SortOrder(MR_Build_Multiplier_by_HP_88_99__sortIndex)]
        [DisplayName(MR_Build_Multiplier_by_HP_88_99__displayName)]
        public virtual float MR_Build_Multiplier_by_HP_88_99_ {
            get => GetData<float>(104);
            set {
                if (GetData<float>(104) == value) return;
                SetData(104, value, nameof(MR_Build_Multiplier_by_HP_88_99_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(MR_Build_Multiplier_by_HP_88_99_));
            }
        }

        public const string MR_Build_Multiplier_by_HP_77_88__displayName = "MR Build Multiplier by HP (77%-88%)";
        public const int MR_Build_Multiplier_by_HP_77_88__sortIndex = 1250;
        [SortOrder(MR_Build_Multiplier_by_HP_77_88__sortIndex)]
        [DisplayName(MR_Build_Multiplier_by_HP_77_88__displayName)]
        public virtual float MR_Build_Multiplier_by_HP_77_88_ {
            get => GetData<float>(108);
            set {
                if (GetData<float>(108) == value) return;
                SetData(108, value, nameof(MR_Build_Multiplier_by_HP_77_88_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(MR_Build_Multiplier_by_HP_77_88_));
            }
        }

        public const string MR_Build_Multiplier_by_HP_66_77__displayName = "MR Build Multiplier by HP (66%-77%)";
        public const int MR_Build_Multiplier_by_HP_66_77__sortIndex = 1300;
        [SortOrder(MR_Build_Multiplier_by_HP_66_77__sortIndex)]
        [DisplayName(MR_Build_Multiplier_by_HP_66_77__displayName)]
        public virtual float MR_Build_Multiplier_by_HP_66_77_ {
            get => GetData<float>(112);
            set {
                if (GetData<float>(112) == value) return;
                SetData(112, value, nameof(MR_Build_Multiplier_by_HP_66_77_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(MR_Build_Multiplier_by_HP_66_77_));
            }
        }

        public const string MR_Build_Multiplier_by_HP_55_66__displayName = "MR Build Multiplier by HP (55%-66%)";
        public const int MR_Build_Multiplier_by_HP_55_66__sortIndex = 1350;
        [SortOrder(MR_Build_Multiplier_by_HP_55_66__sortIndex)]
        [DisplayName(MR_Build_Multiplier_by_HP_55_66__displayName)]
        public virtual float MR_Build_Multiplier_by_HP_55_66_ {
            get => GetData<float>(116);
            set {
                if (GetData<float>(116) == value) return;
                SetData(116, value, nameof(MR_Build_Multiplier_by_HP_55_66_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(MR_Build_Multiplier_by_HP_55_66_));
            }
        }

        public const string MR_Build_Multiplier_by_HP_44_55__displayName = "MR Build Multiplier by HP (44%-55%)";
        public const int MR_Build_Multiplier_by_HP_44_55__sortIndex = 1400;
        [SortOrder(MR_Build_Multiplier_by_HP_44_55__sortIndex)]
        [DisplayName(MR_Build_Multiplier_by_HP_44_55__displayName)]
        public virtual float MR_Build_Multiplier_by_HP_44_55_ {
            get => GetData<float>(120);
            set {
                if (GetData<float>(120) == value) return;
                SetData(120, value, nameof(MR_Build_Multiplier_by_HP_44_55_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(MR_Build_Multiplier_by_HP_44_55_));
            }
        }

        public const string MR_Build_Multiplier_by_HP_33_44__displayName = "MR Build Multiplier by HP (33%-44%)";
        public const int MR_Build_Multiplier_by_HP_33_44__sortIndex = 1450;
        [SortOrder(MR_Build_Multiplier_by_HP_33_44__sortIndex)]
        [DisplayName(MR_Build_Multiplier_by_HP_33_44__displayName)]
        public virtual float MR_Build_Multiplier_by_HP_33_44_ {
            get => GetData<float>(124);
            set {
                if (GetData<float>(124) == value) return;
                SetData(124, value, nameof(MR_Build_Multiplier_by_HP_33_44_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(MR_Build_Multiplier_by_HP_33_44_));
            }
        }

        public const string MR_Build_Multiplier_by_HP_22_33__displayName = "MR Build Multiplier by HP (22%-33%)";
        public const int MR_Build_Multiplier_by_HP_22_33__sortIndex = 1500;
        [SortOrder(MR_Build_Multiplier_by_HP_22_33__sortIndex)]
        [DisplayName(MR_Build_Multiplier_by_HP_22_33__displayName)]
        public virtual float MR_Build_Multiplier_by_HP_22_33_ {
            get => GetData<float>(128);
            set {
                if (GetData<float>(128) == value) return;
                SetData(128, value, nameof(MR_Build_Multiplier_by_HP_22_33_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(MR_Build_Multiplier_by_HP_22_33_));
            }
        }

        public const string MR_Build_Multiplier_by_HP_11_22__displayName = "MR Build Multiplier by HP (11%-22%)";
        public const int MR_Build_Multiplier_by_HP_11_22__sortIndex = 1550;
        [SortOrder(MR_Build_Multiplier_by_HP_11_22__sortIndex)]
        [DisplayName(MR_Build_Multiplier_by_HP_11_22__displayName)]
        public virtual float MR_Build_Multiplier_by_HP_11_22_ {
            get => GetData<float>(132);
            set {
                if (GetData<float>(132) == value) return;
                SetData(132, value, nameof(MR_Build_Multiplier_by_HP_11_22_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(MR_Build_Multiplier_by_HP_11_22_));
            }
        }

        public const string MR_Build_Multiplier_by_HP_0_11__displayName = "MR Build Multiplier by HP (0%-11%)";
        public const int MR_Build_Multiplier_by_HP_0_11__sortIndex = 1600;
        [SortOrder(MR_Build_Multiplier_by_HP_0_11__sortIndex)]
        [DisplayName(MR_Build_Multiplier_by_HP_0_11__displayName)]
        public virtual float MR_Build_Multiplier_by_HP_0_11_ {
            get => GetData<float>(136);
            set {
                if (GetData<float>(136) == value) return;
                SetData(136, value, nameof(MR_Build_Multiplier_by_HP_0_11_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(MR_Build_Multiplier_by_HP_0_11_));
            }
        }

        public const string MR_Out_of_Combat_Decay_Multiplier_displayName = "MR Out of Combat Decay Multiplier";
        public const int MR_Out_of_Combat_Decay_Multiplier_sortIndex = 1650;
        [SortOrder(MR_Out_of_Combat_Decay_Multiplier_sortIndex)]
        [DisplayName(MR_Out_of_Combat_Decay_Multiplier_displayName)]
        public virtual float MR_Out_of_Combat_Decay_Multiplier {
            get => GetData<float>(140);
            set {
                if (GetData<float>(140) == value) return;
                SetData(140, value, nameof(MR_Out_of_Combat_Decay_Multiplier));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(MR_Out_of_Combat_Decay_Multiplier));
            }
        }

        public const int lastSortIndex = 1700;
    }
}
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

        public const string LR_HR_Build_Multiplier_by_HP_90_100__displayName = "LR/HR Build Multiplier by HP (90%-100%)";
        public const int LR_HR_Build_Multiplier_by_HP_90_100__sortIndex = 350;
        [SortOrder(LR_HR_Build_Multiplier_by_HP_90_100__sortIndex)]
        [DisplayName(LR_HR_Build_Multiplier_by_HP_90_100__displayName)]
        public virtual float LR_HR_Build_Multiplier_by_HP_90_100_ {
            get => GetData<float>(36);
            set {
                if (GetData<float>(36) == value) return;
                SetData(36, value, nameof(LR_HR_Build_Multiplier_by_HP_90_100_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(LR_HR_Build_Multiplier_by_HP_90_100_));
            }
        }

        public const string LR_HR_Build_Multiplier_by_HP_80_90__displayName = "LR/HR Build Multiplier by HP (80%-90%)";
        public const int LR_HR_Build_Multiplier_by_HP_80_90__sortIndex = 400;
        [SortOrder(LR_HR_Build_Multiplier_by_HP_80_90__sortIndex)]
        [DisplayName(LR_HR_Build_Multiplier_by_HP_80_90__displayName)]
        public virtual float LR_HR_Build_Multiplier_by_HP_80_90_ {
            get => GetData<float>(40);
            set {
                if (GetData<float>(40) == value) return;
                SetData(40, value, nameof(LR_HR_Build_Multiplier_by_HP_80_90_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(LR_HR_Build_Multiplier_by_HP_80_90_));
            }
        }

        public const string LR_HR_Build_Multiplier_by_HP_70_80__displayName = "LR/HR Build Multiplier by HP (70%-80%)";
        public const int LR_HR_Build_Multiplier_by_HP_70_80__sortIndex = 450;
        [SortOrder(LR_HR_Build_Multiplier_by_HP_70_80__sortIndex)]
        [DisplayName(LR_HR_Build_Multiplier_by_HP_70_80__displayName)]
        public virtual float LR_HR_Build_Multiplier_by_HP_70_80_ {
            get => GetData<float>(44);
            set {
                if (GetData<float>(44) == value) return;
                SetData(44, value, nameof(LR_HR_Build_Multiplier_by_HP_70_80_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(LR_HR_Build_Multiplier_by_HP_70_80_));
            }
        }

        public const string LR_HR_Build_Multiplier_by_HP_60_70__displayName = "LR/HR Build Multiplier by HP (60%-70%)";
        public const int LR_HR_Build_Multiplier_by_HP_60_70__sortIndex = 500;
        [SortOrder(LR_HR_Build_Multiplier_by_HP_60_70__sortIndex)]
        [DisplayName(LR_HR_Build_Multiplier_by_HP_60_70__displayName)]
        public virtual float LR_HR_Build_Multiplier_by_HP_60_70_ {
            get => GetData<float>(48);
            set {
                if (GetData<float>(48) == value) return;
                SetData(48, value, nameof(LR_HR_Build_Multiplier_by_HP_60_70_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(LR_HR_Build_Multiplier_by_HP_60_70_));
            }
        }

        public const string LR_HR_Build_Multiplier_by_HP_50_60__displayName = "LR/HR Build Multiplier by HP (50%-60%)";
        public const int LR_HR_Build_Multiplier_by_HP_50_60__sortIndex = 550;
        [SortOrder(LR_HR_Build_Multiplier_by_HP_50_60__sortIndex)]
        [DisplayName(LR_HR_Build_Multiplier_by_HP_50_60__displayName)]
        public virtual float LR_HR_Build_Multiplier_by_HP_50_60_ {
            get => GetData<float>(52);
            set {
                if (GetData<float>(52) == value) return;
                SetData(52, value, nameof(LR_HR_Build_Multiplier_by_HP_50_60_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(LR_HR_Build_Multiplier_by_HP_50_60_));
            }
        }

        public const string LR_HR_Build_Multiplier_by_HP_40_50__displayName = "LR/HR Build Multiplier by HP (40%-50%)";
        public const int LR_HR_Build_Multiplier_by_HP_40_50__sortIndex = 600;
        [SortOrder(LR_HR_Build_Multiplier_by_HP_40_50__sortIndex)]
        [DisplayName(LR_HR_Build_Multiplier_by_HP_40_50__displayName)]
        public virtual float LR_HR_Build_Multiplier_by_HP_40_50_ {
            get => GetData<float>(56);
            set {
                if (GetData<float>(56) == value) return;
                SetData(56, value, nameof(LR_HR_Build_Multiplier_by_HP_40_50_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(LR_HR_Build_Multiplier_by_HP_40_50_));
            }
        }

        public const string LR_HR_Build_Multiplier_by_HP_30_40__displayName = "LR/HR Build Multiplier by HP (30%-40%)";
        public const int LR_HR_Build_Multiplier_by_HP_30_40__sortIndex = 650;
        [SortOrder(LR_HR_Build_Multiplier_by_HP_30_40__sortIndex)]
        [DisplayName(LR_HR_Build_Multiplier_by_HP_30_40__displayName)]
        public virtual float LR_HR_Build_Multiplier_by_HP_30_40_ {
            get => GetData<float>(60);
            set {
                if (GetData<float>(60) == value) return;
                SetData(60, value, nameof(LR_HR_Build_Multiplier_by_HP_30_40_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(LR_HR_Build_Multiplier_by_HP_30_40_));
            }
        }

        public const string LR_HR_Build_Multiplier_by_HP_20_30__displayName = "LR/HR Build Multiplier by HP (20%-30%)";
        public const int LR_HR_Build_Multiplier_by_HP_20_30__sortIndex = 700;
        [SortOrder(LR_HR_Build_Multiplier_by_HP_20_30__sortIndex)]
        [DisplayName(LR_HR_Build_Multiplier_by_HP_20_30__displayName)]
        public virtual float LR_HR_Build_Multiplier_by_HP_20_30_ {
            get => GetData<float>(64);
            set {
                if (GetData<float>(64) == value) return;
                SetData(64, value, nameof(LR_HR_Build_Multiplier_by_HP_20_30_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(LR_HR_Build_Multiplier_by_HP_20_30_));
            }
        }

        public const string LR_HR_Build_Multiplier_by_HP_10_20__displayName = "LR/HR Build Multiplier by HP (10%-20%)";
        public const int LR_HR_Build_Multiplier_by_HP_10_20__sortIndex = 750;
        [SortOrder(LR_HR_Build_Multiplier_by_HP_10_20__sortIndex)]
        [DisplayName(LR_HR_Build_Multiplier_by_HP_10_20__displayName)]
        public virtual float LR_HR_Build_Multiplier_by_HP_10_20_ {
            get => GetData<float>(68);
            set {
                if (GetData<float>(68) == value) return;
                SetData(68, value, nameof(LR_HR_Build_Multiplier_by_HP_10_20_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(LR_HR_Build_Multiplier_by_HP_10_20_));
            }
        }

        public const string LR_HR_Build_Multiplier_by_HP_0_10__displayName = "LR/HR Build Multiplier by HP (0%-10%)";
        public const int LR_HR_Build_Multiplier_by_HP_0_10__sortIndex = 800;
        [SortOrder(LR_HR_Build_Multiplier_by_HP_0_10__sortIndex)]
        [DisplayName(LR_HR_Build_Multiplier_by_HP_0_10__displayName)]
        public virtual float LR_HR_Build_Multiplier_by_HP_0_10_ {
            get => GetData<float>(72);
            set {
                if (GetData<float>(72) == value) return;
                SetData(72, value, nameof(LR_HR_Build_Multiplier_by_HP_0_10_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(LR_HR_Build_Multiplier_by_HP_0_10_));
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

        public const string MR_Build_Multiplier_by_HP_90_100__displayName = "MR Build Multiplier by HP (90%-100%)";
        public const int MR_Build_Multiplier_by_HP_90_100__sortIndex = 1150;
        [SortOrder(MR_Build_Multiplier_by_HP_90_100__sortIndex)]
        [DisplayName(MR_Build_Multiplier_by_HP_90_100__displayName)]
        public virtual float MR_Build_Multiplier_by_HP_90_100_ {
            get => GetData<float>(100);
            set {
                if (GetData<float>(100) == value) return;
                SetData(100, value, nameof(MR_Build_Multiplier_by_HP_90_100_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(MR_Build_Multiplier_by_HP_90_100_));
            }
        }

        public const string MR_Build_Multiplier_by_HP_80_90__displayName = "MR Build Multiplier by HP (80%-90%)";
        public const int MR_Build_Multiplier_by_HP_80_90__sortIndex = 1200;
        [SortOrder(MR_Build_Multiplier_by_HP_80_90__sortIndex)]
        [DisplayName(MR_Build_Multiplier_by_HP_80_90__displayName)]
        public virtual float MR_Build_Multiplier_by_HP_80_90_ {
            get => GetData<float>(104);
            set {
                if (GetData<float>(104) == value) return;
                SetData(104, value, nameof(MR_Build_Multiplier_by_HP_80_90_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(MR_Build_Multiplier_by_HP_80_90_));
            }
        }

        public const string MR_Build_Multiplier_by_HP_70_80__displayName = "MR Build Multiplier by HP (70%-80%)";
        public const int MR_Build_Multiplier_by_HP_70_80__sortIndex = 1250;
        [SortOrder(MR_Build_Multiplier_by_HP_70_80__sortIndex)]
        [DisplayName(MR_Build_Multiplier_by_HP_70_80__displayName)]
        public virtual float MR_Build_Multiplier_by_HP_70_80_ {
            get => GetData<float>(108);
            set {
                if (GetData<float>(108) == value) return;
                SetData(108, value, nameof(MR_Build_Multiplier_by_HP_70_80_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(MR_Build_Multiplier_by_HP_70_80_));
            }
        }

        public const string MR_Build_Multiplier_by_HP_60_70__displayName = "MR Build Multiplier by HP (60%-70%)";
        public const int MR_Build_Multiplier_by_HP_60_70__sortIndex = 1300;
        [SortOrder(MR_Build_Multiplier_by_HP_60_70__sortIndex)]
        [DisplayName(MR_Build_Multiplier_by_HP_60_70__displayName)]
        public virtual float MR_Build_Multiplier_by_HP_60_70_ {
            get => GetData<float>(112);
            set {
                if (GetData<float>(112) == value) return;
                SetData(112, value, nameof(MR_Build_Multiplier_by_HP_60_70_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(MR_Build_Multiplier_by_HP_60_70_));
            }
        }

        public const string MR_Build_Multiplier_by_HP_50_60__displayName = "MR Build Multiplier by HP (50%-60%)";
        public const int MR_Build_Multiplier_by_HP_50_60__sortIndex = 1350;
        [SortOrder(MR_Build_Multiplier_by_HP_50_60__sortIndex)]
        [DisplayName(MR_Build_Multiplier_by_HP_50_60__displayName)]
        public virtual float MR_Build_Multiplier_by_HP_50_60_ {
            get => GetData<float>(116);
            set {
                if (GetData<float>(116) == value) return;
                SetData(116, value, nameof(MR_Build_Multiplier_by_HP_50_60_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(MR_Build_Multiplier_by_HP_50_60_));
            }
        }

        public const string MR_Build_Multiplier_by_HP_40_50__displayName = "MR Build Multiplier by HP (40%-50%)";
        public const int MR_Build_Multiplier_by_HP_40_50__sortIndex = 1400;
        [SortOrder(MR_Build_Multiplier_by_HP_40_50__sortIndex)]
        [DisplayName(MR_Build_Multiplier_by_HP_40_50__displayName)]
        public virtual float MR_Build_Multiplier_by_HP_40_50_ {
            get => GetData<float>(120);
            set {
                if (GetData<float>(120) == value) return;
                SetData(120, value, nameof(MR_Build_Multiplier_by_HP_40_50_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(MR_Build_Multiplier_by_HP_40_50_));
            }
        }

        public const string MR_Build_Multiplier_by_HP_30_40__displayName = "MR Build Multiplier by HP (30%-40%)";
        public const int MR_Build_Multiplier_by_HP_30_40__sortIndex = 1450;
        [SortOrder(MR_Build_Multiplier_by_HP_30_40__sortIndex)]
        [DisplayName(MR_Build_Multiplier_by_HP_30_40__displayName)]
        public virtual float MR_Build_Multiplier_by_HP_30_40_ {
            get => GetData<float>(124);
            set {
                if (GetData<float>(124) == value) return;
                SetData(124, value, nameof(MR_Build_Multiplier_by_HP_30_40_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(MR_Build_Multiplier_by_HP_30_40_));
            }
        }

        public const string MR_Build_Multiplier_by_HP_20_30__displayName = "MR Build Multiplier by HP (20%-30%)";
        public const int MR_Build_Multiplier_by_HP_20_30__sortIndex = 1500;
        [SortOrder(MR_Build_Multiplier_by_HP_20_30__sortIndex)]
        [DisplayName(MR_Build_Multiplier_by_HP_20_30__displayName)]
        public virtual float MR_Build_Multiplier_by_HP_20_30_ {
            get => GetData<float>(128);
            set {
                if (GetData<float>(128) == value) return;
                SetData(128, value, nameof(MR_Build_Multiplier_by_HP_20_30_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(MR_Build_Multiplier_by_HP_20_30_));
            }
        }

        public const string MR_Build_Multiplier_by_HP_10_20__displayName = "MR Build Multiplier by HP (10%-20%)";
        public const int MR_Build_Multiplier_by_HP_10_20__sortIndex = 1550;
        [SortOrder(MR_Build_Multiplier_by_HP_10_20__sortIndex)]
        [DisplayName(MR_Build_Multiplier_by_HP_10_20__displayName)]
        public virtual float MR_Build_Multiplier_by_HP_10_20_ {
            get => GetData<float>(132);
            set {
                if (GetData<float>(132) == value) return;
                SetData(132, value, nameof(MR_Build_Multiplier_by_HP_10_20_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(MR_Build_Multiplier_by_HP_10_20_));
            }
        }

        public const string MR_Build_Multiplier_by_HP_0_10__displayName = "MR Build Multiplier by HP (0%-10%)";
        public const int MR_Build_Multiplier_by_HP_0_10__sortIndex = 1600;
        [SortOrder(MR_Build_Multiplier_by_HP_0_10__sortIndex)]
        [DisplayName(MR_Build_Multiplier_by_HP_0_10__displayName)]
        public virtual float MR_Build_Multiplier_by_HP_0_10_ {
            get => GetData<float>(136);
            set {
                if (GetData<float>(136) == value) return;
                SetData(136, value, nameof(MR_Build_Multiplier_by_HP_0_10_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(MR_Build_Multiplier_by_HP_0_10_));
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
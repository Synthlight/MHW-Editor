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

        public const string LR_HR_Trigger_Damage_displayName = "LR/HR Trigger Damage";
        public const int LR_HR_Trigger_Damage_sortIndex = 100;
        [SortOrder(LR_HR_Trigger_Damage_sortIndex)]
        [DisplayName(LR_HR_Trigger_Damage_displayName)]
        public virtual uint LR_HR_Trigger_Damage {
            get => GetData<uint>(16);
            set {
                if (GetData<uint>(16) == value) return;
                SetData(16, value, nameof(LR_HR_Trigger_Damage));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(LR_HR_Trigger_Damage));
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

        public const string LR_HR_Speed_displayName = "LR/HR Speed";
        public const int LR_HR_Speed_sortIndex = 200;
        [SortOrder(LR_HR_Speed_sortIndex)]
        [DisplayName(LR_HR_Speed_displayName)]
        public virtual float LR_HR_Speed {
            get => GetData<float>(24);
            set {
                if (GetData<float>(24) == value) return;
                SetData(24, value, nameof(LR_HR_Speed));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(LR_HR_Speed));
            }
        }

        public const string LR_HR_Damage_displayName = "LR/HR Damage";
        public const int LR_HR_Damage_sortIndex = 250;
        [SortOrder(LR_HR_Damage_sortIndex)]
        [DisplayName(LR_HR_Damage_displayName)]
        public virtual float LR_HR_Damage {
            get => GetData<float>(28);
            set {
                if (GetData<float>(28) == value) return;
                SetData(28, value, nameof(LR_HR_Damage));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(LR_HR_Damage));
            }
        }

        public const string LR_HR_Player_Damage_displayName = "LR/HR Player Damage";
        public const int LR_HR_Player_Damage_sortIndex = 300;
        [SortOrder(LR_HR_Player_Damage_sortIndex)]
        [DisplayName(LR_HR_Player_Damage_displayName)]
        public virtual float LR_HR_Player_Damage {
            get => GetData<float>(32);
            set {
                if (GetData<float>(32) == value) return;
                SetData(32, value, nameof(LR_HR_Player_Damage));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(LR_HR_Player_Damage));
            }
        }

        public const string LR_HR_Build_Multiplier_by_HP_1_displayName = "LR/HR Build Multiplier by HP 1";
        public const int LR_HR_Build_Multiplier_by_HP_1_sortIndex = 350;
        [SortOrder(LR_HR_Build_Multiplier_by_HP_1_sortIndex)]
        [DisplayName(LR_HR_Build_Multiplier_by_HP_1_displayName)]
        public virtual float LR_HR_Build_Multiplier_by_HP_1 {
            get => GetData<float>(36);
            set {
                if (GetData<float>(36) == value) return;
                SetData(36, value, nameof(LR_HR_Build_Multiplier_by_HP_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(LR_HR_Build_Multiplier_by_HP_1));
            }
        }

        public const string LR_HR_Build_Multiplier_by_HP_2_displayName = "LR/HR Build Multiplier by HP 2";
        public const int LR_HR_Build_Multiplier_by_HP_2_sortIndex = 400;
        [SortOrder(LR_HR_Build_Multiplier_by_HP_2_sortIndex)]
        [DisplayName(LR_HR_Build_Multiplier_by_HP_2_displayName)]
        public virtual float LR_HR_Build_Multiplier_by_HP_2 {
            get => GetData<float>(40);
            set {
                if (GetData<float>(40) == value) return;
                SetData(40, value, nameof(LR_HR_Build_Multiplier_by_HP_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(LR_HR_Build_Multiplier_by_HP_2));
            }
        }

        public const string LR_HR_Build_Multiplier_by_HP_3_displayName = "LR/HR Build Multiplier by HP 3";
        public const int LR_HR_Build_Multiplier_by_HP_3_sortIndex = 450;
        [SortOrder(LR_HR_Build_Multiplier_by_HP_3_sortIndex)]
        [DisplayName(LR_HR_Build_Multiplier_by_HP_3_displayName)]
        public virtual float LR_HR_Build_Multiplier_by_HP_3 {
            get => GetData<float>(44);
            set {
                if (GetData<float>(44) == value) return;
                SetData(44, value, nameof(LR_HR_Build_Multiplier_by_HP_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(LR_HR_Build_Multiplier_by_HP_3));
            }
        }

        public const string LR_HR_Build_Multiplier_by_HP_4_displayName = "LR/HR Build Multiplier by HP 4";
        public const int LR_HR_Build_Multiplier_by_HP_4_sortIndex = 500;
        [SortOrder(LR_HR_Build_Multiplier_by_HP_4_sortIndex)]
        [DisplayName(LR_HR_Build_Multiplier_by_HP_4_displayName)]
        public virtual float LR_HR_Build_Multiplier_by_HP_4 {
            get => GetData<float>(48);
            set {
                if (GetData<float>(48) == value) return;
                SetData(48, value, nameof(LR_HR_Build_Multiplier_by_HP_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(LR_HR_Build_Multiplier_by_HP_4));
            }
        }

        public const string LR_HR_Build_Multiplier_by_HP_5_displayName = "LR/HR Build Multiplier by HP 5";
        public const int LR_HR_Build_Multiplier_by_HP_5_sortIndex = 550;
        [SortOrder(LR_HR_Build_Multiplier_by_HP_5_sortIndex)]
        [DisplayName(LR_HR_Build_Multiplier_by_HP_5_displayName)]
        public virtual float LR_HR_Build_Multiplier_by_HP_5 {
            get => GetData<float>(52);
            set {
                if (GetData<float>(52) == value) return;
                SetData(52, value, nameof(LR_HR_Build_Multiplier_by_HP_5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(LR_HR_Build_Multiplier_by_HP_5));
            }
        }

        public const string LR_HR_Build_Multiplier_by_HP_6_displayName = "LR/HR Build Multiplier by HP 6";
        public const int LR_HR_Build_Multiplier_by_HP_6_sortIndex = 600;
        [SortOrder(LR_HR_Build_Multiplier_by_HP_6_sortIndex)]
        [DisplayName(LR_HR_Build_Multiplier_by_HP_6_displayName)]
        public virtual float LR_HR_Build_Multiplier_by_HP_6 {
            get => GetData<float>(56);
            set {
                if (GetData<float>(56) == value) return;
                SetData(56, value, nameof(LR_HR_Build_Multiplier_by_HP_6));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(LR_HR_Build_Multiplier_by_HP_6));
            }
        }

        public const string LR_HR_Build_Multiplier_by_HP_7_displayName = "LR/HR Build Multiplier by HP 7";
        public const int LR_HR_Build_Multiplier_by_HP_7_sortIndex = 650;
        [SortOrder(LR_HR_Build_Multiplier_by_HP_7_sortIndex)]
        [DisplayName(LR_HR_Build_Multiplier_by_HP_7_displayName)]
        public virtual float LR_HR_Build_Multiplier_by_HP_7 {
            get => GetData<float>(60);
            set {
                if (GetData<float>(60) == value) return;
                SetData(60, value, nameof(LR_HR_Build_Multiplier_by_HP_7));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(LR_HR_Build_Multiplier_by_HP_7));
            }
        }

        public const string LR_HR_Build_Multiplier_by_HP_8_displayName = "LR/HR Build Multiplier by HP 8";
        public const int LR_HR_Build_Multiplier_by_HP_8_sortIndex = 700;
        [SortOrder(LR_HR_Build_Multiplier_by_HP_8_sortIndex)]
        [DisplayName(LR_HR_Build_Multiplier_by_HP_8_displayName)]
        public virtual float LR_HR_Build_Multiplier_by_HP_8 {
            get => GetData<float>(64);
            set {
                if (GetData<float>(64) == value) return;
                SetData(64, value, nameof(LR_HR_Build_Multiplier_by_HP_8));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(LR_HR_Build_Multiplier_by_HP_8));
            }
        }

        public const string LR_HR_Build_Multiplier_by_HP_9_displayName = "LR/HR Build Multiplier by HP 9";
        public const int LR_HR_Build_Multiplier_by_HP_9_sortIndex = 750;
        [SortOrder(LR_HR_Build_Multiplier_by_HP_9_sortIndex)]
        [DisplayName(LR_HR_Build_Multiplier_by_HP_9_displayName)]
        public virtual float LR_HR_Build_Multiplier_by_HP_9 {
            get => GetData<float>(68);
            set {
                if (GetData<float>(68) == value) return;
                SetData(68, value, nameof(LR_HR_Build_Multiplier_by_HP_9));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(LR_HR_Build_Multiplier_by_HP_9));
            }
        }

        public const string LR_HR_Build_Multiplier_by_HP_10_displayName = "LR/HR Build Multiplier by HP 10";
        public const int LR_HR_Build_Multiplier_by_HP_10_sortIndex = 800;
        [SortOrder(LR_HR_Build_Multiplier_by_HP_10_sortIndex)]
        [DisplayName(LR_HR_Build_Multiplier_by_HP_10_displayName)]
        public virtual float LR_HR_Build_Multiplier_by_HP_10 {
            get => GetData<float>(72);
            set {
                if (GetData<float>(72) == value) return;
                SetData(72, value, nameof(LR_HR_Build_Multiplier_by_HP_10));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(LR_HR_Build_Multiplier_by_HP_10));
            }
        }

        public const string LR_HR_Decay_displayName = "LR/HR Decay";
        public const int LR_HR_Decay_sortIndex = 850;
        [SortOrder(LR_HR_Decay_sortIndex)]
        [DisplayName(LR_HR_Decay_displayName)]
        public virtual float LR_HR_Decay {
            get => GetData<float>(76);
            set {
                if (GetData<float>(76) == value) return;
                SetData(76, value, nameof(LR_HR_Decay));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(LR_HR_Decay));
            }
        }

        public const string MR_Trigger_Damage_displayName = "MR Trigger Damage";
        public const int MR_Trigger_Damage_sortIndex = 900;
        [SortOrder(MR_Trigger_Damage_sortIndex)]
        [DisplayName(MR_Trigger_Damage_displayName)]
        public virtual uint MR_Trigger_Damage {
            get => GetData<uint>(80);
            set {
                if (GetData<uint>(80) == value) return;
                SetData(80, value, nameof(MR_Trigger_Damage));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(MR_Trigger_Damage));
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

        public const string MR_Speed_displayName = "MR Speed";
        public const int MR_Speed_sortIndex = 1000;
        [SortOrder(MR_Speed_sortIndex)]
        [DisplayName(MR_Speed_displayName)]
        public virtual float MR_Speed {
            get => GetData<float>(88);
            set {
                if (GetData<float>(88) == value) return;
                SetData(88, value, nameof(MR_Speed));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(MR_Speed));
            }
        }

        public const string MR_Damage_displayName = "MR Damage";
        public const int MR_Damage_sortIndex = 1050;
        [SortOrder(MR_Damage_sortIndex)]
        [DisplayName(MR_Damage_displayName)]
        public virtual float MR_Damage {
            get => GetData<float>(92);
            set {
                if (GetData<float>(92) == value) return;
                SetData(92, value, nameof(MR_Damage));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(MR_Damage));
            }
        }

        public const string MR_Player_Damage_displayName = "MR Player Damage";
        public const int MR_Player_Damage_sortIndex = 1100;
        [SortOrder(MR_Player_Damage_sortIndex)]
        [DisplayName(MR_Player_Damage_displayName)]
        public virtual float MR_Player_Damage {
            get => GetData<float>(96);
            set {
                if (GetData<float>(96) == value) return;
                SetData(96, value, nameof(MR_Player_Damage));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(MR_Player_Damage));
            }
        }

        public const string MR_Build_Multiplier_by_HP_1_displayName = "MR Build Multiplier by HP 1";
        public const int MR_Build_Multiplier_by_HP_1_sortIndex = 1150;
        [SortOrder(MR_Build_Multiplier_by_HP_1_sortIndex)]
        [DisplayName(MR_Build_Multiplier_by_HP_1_displayName)]
        public virtual float MR_Build_Multiplier_by_HP_1 {
            get => GetData<float>(100);
            set {
                if (GetData<float>(100) == value) return;
                SetData(100, value, nameof(MR_Build_Multiplier_by_HP_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(MR_Build_Multiplier_by_HP_1));
            }
        }

        public const string MR_Build_Multiplier_by_HP_2_displayName = "MR Build Multiplier by HP 2";
        public const int MR_Build_Multiplier_by_HP_2_sortIndex = 1200;
        [SortOrder(MR_Build_Multiplier_by_HP_2_sortIndex)]
        [DisplayName(MR_Build_Multiplier_by_HP_2_displayName)]
        public virtual float MR_Build_Multiplier_by_HP_2 {
            get => GetData<float>(104);
            set {
                if (GetData<float>(104) == value) return;
                SetData(104, value, nameof(MR_Build_Multiplier_by_HP_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(MR_Build_Multiplier_by_HP_2));
            }
        }

        public const string MR_Build_Multiplier_by_HP_3_displayName = "MR Build Multiplier by HP 3";
        public const int MR_Build_Multiplier_by_HP_3_sortIndex = 1250;
        [SortOrder(MR_Build_Multiplier_by_HP_3_sortIndex)]
        [DisplayName(MR_Build_Multiplier_by_HP_3_displayName)]
        public virtual float MR_Build_Multiplier_by_HP_3 {
            get => GetData<float>(108);
            set {
                if (GetData<float>(108) == value) return;
                SetData(108, value, nameof(MR_Build_Multiplier_by_HP_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(MR_Build_Multiplier_by_HP_3));
            }
        }

        public const string MR_Build_Multiplier_by_HP_4_displayName = "MR Build Multiplier by HP 4";
        public const int MR_Build_Multiplier_by_HP_4_sortIndex = 1300;
        [SortOrder(MR_Build_Multiplier_by_HP_4_sortIndex)]
        [DisplayName(MR_Build_Multiplier_by_HP_4_displayName)]
        public virtual float MR_Build_Multiplier_by_HP_4 {
            get => GetData<float>(112);
            set {
                if (GetData<float>(112) == value) return;
                SetData(112, value, nameof(MR_Build_Multiplier_by_HP_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(MR_Build_Multiplier_by_HP_4));
            }
        }

        public const string MR_Build_Multiplier_by_HP_5_displayName = "MR Build Multiplier by HP 5";
        public const int MR_Build_Multiplier_by_HP_5_sortIndex = 1350;
        [SortOrder(MR_Build_Multiplier_by_HP_5_sortIndex)]
        [DisplayName(MR_Build_Multiplier_by_HP_5_displayName)]
        public virtual float MR_Build_Multiplier_by_HP_5 {
            get => GetData<float>(116);
            set {
                if (GetData<float>(116) == value) return;
                SetData(116, value, nameof(MR_Build_Multiplier_by_HP_5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(MR_Build_Multiplier_by_HP_5));
            }
        }

        public const string MR_Build_Multiplier_by_HP_6_displayName = "MR Build Multiplier by HP 6";
        public const int MR_Build_Multiplier_by_HP_6_sortIndex = 1400;
        [SortOrder(MR_Build_Multiplier_by_HP_6_sortIndex)]
        [DisplayName(MR_Build_Multiplier_by_HP_6_displayName)]
        public virtual float MR_Build_Multiplier_by_HP_6 {
            get => GetData<float>(120);
            set {
                if (GetData<float>(120) == value) return;
                SetData(120, value, nameof(MR_Build_Multiplier_by_HP_6));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(MR_Build_Multiplier_by_HP_6));
            }
        }

        public const string MR_Build_Multiplier_by_HP_7_displayName = "MR Build Multiplier by HP 7";
        public const int MR_Build_Multiplier_by_HP_7_sortIndex = 1450;
        [SortOrder(MR_Build_Multiplier_by_HP_7_sortIndex)]
        [DisplayName(MR_Build_Multiplier_by_HP_7_displayName)]
        public virtual float MR_Build_Multiplier_by_HP_7 {
            get => GetData<float>(124);
            set {
                if (GetData<float>(124) == value) return;
                SetData(124, value, nameof(MR_Build_Multiplier_by_HP_7));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(MR_Build_Multiplier_by_HP_7));
            }
        }

        public const string MR_Build_Multiplier_by_HP_8_displayName = "MR Build Multiplier by HP 8";
        public const int MR_Build_Multiplier_by_HP_8_sortIndex = 1500;
        [SortOrder(MR_Build_Multiplier_by_HP_8_sortIndex)]
        [DisplayName(MR_Build_Multiplier_by_HP_8_displayName)]
        public virtual float MR_Build_Multiplier_by_HP_8 {
            get => GetData<float>(128);
            set {
                if (GetData<float>(128) == value) return;
                SetData(128, value, nameof(MR_Build_Multiplier_by_HP_8));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(MR_Build_Multiplier_by_HP_8));
            }
        }

        public const string MR_Build_Multiplier_by_HP_9_displayName = "MR Build Multiplier by HP 9";
        public const int MR_Build_Multiplier_by_HP_9_sortIndex = 1550;
        [SortOrder(MR_Build_Multiplier_by_HP_9_sortIndex)]
        [DisplayName(MR_Build_Multiplier_by_HP_9_displayName)]
        public virtual float MR_Build_Multiplier_by_HP_9 {
            get => GetData<float>(132);
            set {
                if (GetData<float>(132) == value) return;
                SetData(132, value, nameof(MR_Build_Multiplier_by_HP_9));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(MR_Build_Multiplier_by_HP_9));
            }
        }

        public const string MR_Build_Multiplier_by_HP_10_displayName = "MR Build Multiplier by HP 10";
        public const int MR_Build_Multiplier_by_HP_10_sortIndex = 1600;
        [SortOrder(MR_Build_Multiplier_by_HP_10_sortIndex)]
        [DisplayName(MR_Build_Multiplier_by_HP_10_displayName)]
        public virtual float MR_Build_Multiplier_by_HP_10 {
            get => GetData<float>(136);
            set {
                if (GetData<float>(136) == value) return;
                SetData(136, value, nameof(MR_Build_Multiplier_by_HP_10));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(MR_Build_Multiplier_by_HP_10));
            }
        }

        public const string MR_Decay_displayName = "MR Decay";
        public const int MR_Decay_sortIndex = 1650;
        [SortOrder(MR_Decay_sortIndex)]
        [DisplayName(MR_Decay_displayName)]
        public virtual float MR_Decay {
            get => GetData<float>(140);
            set {
                if (GetData<float>(140) == value) return;
                SetData(140, value, nameof(MR_Decay));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(MR_Decay));
            }
        }

        public const int lastSortIndex = 1700;
    }
}
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.PlData {
    public partial class PlSkillParam {
        public const uint StructSize = 2256;
        public const ulong InitialOffset = 0;
        public const long EntryCountOffset = -1;
        public const string EncryptionKey = "j1P15gEkgVa7NdFxiqwCPitykHctY2nZPjSaElvqb0eSwcLO1cOlTqqv";
        public override string UniqueId => $"0";

        public const string Speed_Eating_1_Drink_Motion_Speed_displayName = "Speed Eating 1 Drink Motion Speed";
        public const int Speed_Eating_1_Drink_Motion_Speed_sortIndex = 50;
        [SortOrder(Speed_Eating_1_Drink_Motion_Speed_sortIndex)]
        [DisplayName(Speed_Eating_1_Drink_Motion_Speed_displayName)]
        public virtual float Speed_Eating_1_Drink_Motion_Speed {
            get => GetData<float>(8);
            set {
                if (GetData<float>(8) == value) return;
                SetData(8, value, nameof(Speed_Eating_1_Drink_Motion_Speed));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Speed_Eating_1_Drink_Motion_Speed));
            }
        }

        public const string Speed_Eating_2_Drink_Motion_Speed_displayName = "Speed Eating 2 Drink Motion Speed";
        public const int Speed_Eating_2_Drink_Motion_Speed_sortIndex = 100;
        [SortOrder(Speed_Eating_2_Drink_Motion_Speed_sortIndex)]
        [DisplayName(Speed_Eating_2_Drink_Motion_Speed_displayName)]
        public virtual float Speed_Eating_2_Drink_Motion_Speed {
            get => GetData<float>(12);
            set {
                if (GetData<float>(12) == value) return;
                SetData(12, value, nameof(Speed_Eating_2_Drink_Motion_Speed));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Speed_Eating_2_Drink_Motion_Speed));
            }
        }

        public const string Speed_Eating_3_Drink_Motion_Speed_displayName = "Speed Eating 3 Drink Motion Speed";
        public const int Speed_Eating_3_Drink_Motion_Speed_sortIndex = 150;
        [SortOrder(Speed_Eating_3_Drink_Motion_Speed_sortIndex)]
        [DisplayName(Speed_Eating_3_Drink_Motion_Speed_displayName)]
        public virtual float Speed_Eating_3_Drink_Motion_Speed {
            get => GetData<float>(16);
            set {
                if (GetData<float>(16) == value) return;
                SetData(16, value, nameof(Speed_Eating_3_Drink_Motion_Speed));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Speed_Eating_3_Drink_Motion_Speed));
            }
        }

        public const string Speed_Eating_1_Drink_End_Frame_displayName = "Speed Eating 1 Drink End Frame";
        public const int Speed_Eating_1_Drink_End_Frame_sortIndex = 200;
        [SortOrder(Speed_Eating_1_Drink_End_Frame_sortIndex)]
        [DisplayName(Speed_Eating_1_Drink_End_Frame_displayName)]
        public virtual float Speed_Eating_1_Drink_End_Frame {
            get => GetData<float>(20);
            set {
                if (GetData<float>(20) == value) return;
                SetData(20, value, nameof(Speed_Eating_1_Drink_End_Frame));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Speed_Eating_1_Drink_End_Frame));
            }
        }

        public const string Speed_Eating_2_Drink_End_Frame_displayName = "Speed Eating 2 Drink End Frame";
        public const int Speed_Eating_2_Drink_End_Frame_sortIndex = 250;
        [SortOrder(Speed_Eating_2_Drink_End_Frame_sortIndex)]
        [DisplayName(Speed_Eating_2_Drink_End_Frame_displayName)]
        public virtual float Speed_Eating_2_Drink_End_Frame {
            get => GetData<float>(24);
            set {
                if (GetData<float>(24) == value) return;
                SetData(24, value, nameof(Speed_Eating_2_Drink_End_Frame));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Speed_Eating_2_Drink_End_Frame));
            }
        }

        public const string Speed_Eating_3_Drink_End_Frame_displayName = "Speed Eating 3 Drink End Frame";
        public const int Speed_Eating_3_Drink_End_Frame_sortIndex = 300;
        [SortOrder(Speed_Eating_3_Drink_End_Frame_sortIndex)]
        [DisplayName(Speed_Eating_3_Drink_End_Frame_displayName)]
        public virtual float Speed_Eating_3_Drink_End_Frame {
            get => GetData<float>(28);
            set {
                if (GetData<float>(28) == value) return;
                SetData(28, value, nameof(Speed_Eating_3_Drink_End_Frame));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Speed_Eating_3_Drink_End_Frame));
            }
        }

        public const string Speed_Eating_1_Heal_Speed_Rate_displayName = "Speed Eating 1 Heal Speed Rate";
        public const int Speed_Eating_1_Heal_Speed_Rate_sortIndex = 350;
        [SortOrder(Speed_Eating_1_Heal_Speed_Rate_sortIndex)]
        [DisplayName(Speed_Eating_1_Heal_Speed_Rate_displayName)]
        public virtual float Speed_Eating_1_Heal_Speed_Rate {
            get => GetData<float>(32);
            set {
                if (GetData<float>(32) == value) return;
                SetData(32, value, nameof(Speed_Eating_1_Heal_Speed_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Speed_Eating_1_Heal_Speed_Rate));
            }
        }

        public const string Speed_Eating_2_Heal_Speed_Rate_displayName = "Speed Eating 2 Heal Speed Rate";
        public const int Speed_Eating_2_Heal_Speed_Rate_sortIndex = 400;
        [SortOrder(Speed_Eating_2_Heal_Speed_Rate_sortIndex)]
        [DisplayName(Speed_Eating_2_Heal_Speed_Rate_displayName)]
        public virtual float Speed_Eating_2_Heal_Speed_Rate {
            get => GetData<float>(36);
            set {
                if (GetData<float>(36) == value) return;
                SetData(36, value, nameof(Speed_Eating_2_Heal_Speed_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Speed_Eating_2_Heal_Speed_Rate));
            }
        }

        public const string Speed_Eating_3_Heal_Speed_Rate_displayName = "Speed Eating 3 Heal Speed Rate";
        public const int Speed_Eating_3_Heal_Speed_Rate_sortIndex = 450;
        [SortOrder(Speed_Eating_3_Heal_Speed_Rate_sortIndex)]
        [DisplayName(Speed_Eating_3_Heal_Speed_Rate_displayName)]
        public virtual float Speed_Eating_3_Heal_Speed_Rate {
            get => GetData<float>(40);
            set {
                if (GetData<float>(40) == value) return;
                SetData(40, value, nameof(Speed_Eating_3_Heal_Speed_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Speed_Eating_3_Heal_Speed_Rate));
            }
        }

        public const string Speed_Eating_1_Meat_Motion_Speed_displayName = "Speed Eating 1 Meat Motion Speed";
        public const int Speed_Eating_1_Meat_Motion_Speed_sortIndex = 500;
        [SortOrder(Speed_Eating_1_Meat_Motion_Speed_sortIndex)]
        [DisplayName(Speed_Eating_1_Meat_Motion_Speed_displayName)]
        public virtual float Speed_Eating_1_Meat_Motion_Speed {
            get => GetData<float>(44);
            set {
                if (GetData<float>(44) == value) return;
                SetData(44, value, nameof(Speed_Eating_1_Meat_Motion_Speed));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Speed_Eating_1_Meat_Motion_Speed));
            }
        }

        public const string Speed_Eating_2_Meat_Motion_Speed_displayName = "Speed Eating 2 Meat Motion Speed";
        public const int Speed_Eating_2_Meat_Motion_Speed_sortIndex = 550;
        [SortOrder(Speed_Eating_2_Meat_Motion_Speed_sortIndex)]
        [DisplayName(Speed_Eating_2_Meat_Motion_Speed_displayName)]
        public virtual float Speed_Eating_2_Meat_Motion_Speed {
            get => GetData<float>(48);
            set {
                if (GetData<float>(48) == value) return;
                SetData(48, value, nameof(Speed_Eating_2_Meat_Motion_Speed));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Speed_Eating_2_Meat_Motion_Speed));
            }
        }

        public const string Speed_Eating_3_Meat_Motion_Speed_displayName = "Speed Eating 3 Meat Motion Speed";
        public const int Speed_Eating_3_Meat_Motion_Speed_sortIndex = 600;
        [SortOrder(Speed_Eating_3_Meat_Motion_Speed_sortIndex)]
        [DisplayName(Speed_Eating_3_Meat_Motion_Speed_displayName)]
        public virtual float Speed_Eating_3_Meat_Motion_Speed {
            get => GetData<float>(52);
            set {
                if (GetData<float>(52) == value) return;
                SetData(52, value, nameof(Speed_Eating_3_Meat_Motion_Speed));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Speed_Eating_3_Meat_Motion_Speed));
            }
        }

        public const string Speed_Eating_1_Meat_Loop_Count_displayName = "Speed Eating 1 Meat Loop Count";
        public const int Speed_Eating_1_Meat_Loop_Count_sortIndex = 650;
        [SortOrder(Speed_Eating_1_Meat_Loop_Count_sortIndex)]
        [DisplayName(Speed_Eating_1_Meat_Loop_Count_displayName)]
        public virtual byte Speed_Eating_1_Meat_Loop_Count {
            get => GetData<byte>(56);
            set {
                if (GetData<byte>(56) == value) return;
                SetData(56, value, nameof(Speed_Eating_1_Meat_Loop_Count));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Speed_Eating_1_Meat_Loop_Count));
            }
        }

        public const string Speed_Eating_2_Meat_Loop_Count_displayName = "Speed Eating 2 Meat Loop Count";
        public const int Speed_Eating_2_Meat_Loop_Count_sortIndex = 700;
        [SortOrder(Speed_Eating_2_Meat_Loop_Count_sortIndex)]
        [DisplayName(Speed_Eating_2_Meat_Loop_Count_displayName)]
        public virtual byte Speed_Eating_2_Meat_Loop_Count {
            get => GetData<byte>(57);
            set {
                if (GetData<byte>(57) == value) return;
                SetData(57, value, nameof(Speed_Eating_2_Meat_Loop_Count));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Speed_Eating_2_Meat_Loop_Count));
            }
        }

        public const string Speed_Eating_3_Meat_Loop_Count_displayName = "Speed Eating 3 Meat Loop Count";
        public const int Speed_Eating_3_Meat_Loop_Count_sortIndex = 750;
        [SortOrder(Speed_Eating_3_Meat_Loop_Count_sortIndex)]
        [DisplayName(Speed_Eating_3_Meat_Loop_Count_displayName)]
        public virtual byte Speed_Eating_3_Meat_Loop_Count {
            get => GetData<byte>(58);
            set {
                if (GetData<byte>(58) == value) return;
                SetData(58, value, nameof(Speed_Eating_3_Meat_Loop_Count));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Speed_Eating_3_Meat_Loop_Count));
            }
        }

        public const string Speed_Eating_1_2_3_Meat_End_Frame_displayName = "Speed Eating 1/2/3 Meat End Frame";
        public const int Speed_Eating_1_2_3_Meat_End_Frame_sortIndex = 800;
        [SortOrder(Speed_Eating_1_2_3_Meat_End_Frame_sortIndex)]
        [DisplayName(Speed_Eating_1_2_3_Meat_End_Frame_displayName)]
        public virtual float Speed_Eating_1_2_3_Meat_End_Frame {
            get => GetData<float>(59);
            set {
                if (GetData<float>(59) == value) return;
                SetData(59, value, nameof(Speed_Eating_1_2_3_Meat_End_Frame));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Speed_Eating_1_2_3_Meat_End_Frame));
            }
        }

        public const string Speed_Eating_1_Tablet_Motion_Speed_displayName = "Speed Eating 1 Tablet Motion Speed";
        public const int Speed_Eating_1_Tablet_Motion_Speed_sortIndex = 850;
        [SortOrder(Speed_Eating_1_Tablet_Motion_Speed_sortIndex)]
        [DisplayName(Speed_Eating_1_Tablet_Motion_Speed_displayName)]
        public virtual float Speed_Eating_1_Tablet_Motion_Speed {
            get => GetData<float>(63);
            set {
                if (GetData<float>(63) == value) return;
                SetData(63, value, nameof(Speed_Eating_1_Tablet_Motion_Speed));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Speed_Eating_1_Tablet_Motion_Speed));
            }
        }

        public const string Speed_Eating_2_Tablet_Motion_Speed_displayName = "Speed Eating 2 Tablet Motion Speed";
        public const int Speed_Eating_2_Tablet_Motion_Speed_sortIndex = 900;
        [SortOrder(Speed_Eating_2_Tablet_Motion_Speed_sortIndex)]
        [DisplayName(Speed_Eating_2_Tablet_Motion_Speed_displayName)]
        public virtual float Speed_Eating_2_Tablet_Motion_Speed {
            get => GetData<float>(67);
            set {
                if (GetData<float>(67) == value) return;
                SetData(67, value, nameof(Speed_Eating_2_Tablet_Motion_Speed));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Speed_Eating_2_Tablet_Motion_Speed));
            }
        }

        public const string Speed_Eating_3_Tablet_Motion_Speed_displayName = "Speed Eating 3 Tablet Motion Speed";
        public const int Speed_Eating_3_Tablet_Motion_Speed_sortIndex = 950;
        [SortOrder(Speed_Eating_3_Tablet_Motion_Speed_sortIndex)]
        [DisplayName(Speed_Eating_3_Tablet_Motion_Speed_displayName)]
        public virtual float Speed_Eating_3_Tablet_Motion_Speed {
            get => GetData<float>(71);
            set {
                if (GetData<float>(71) == value) return;
                SetData(71, value, nameof(Speed_Eating_3_Tablet_Motion_Speed));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Speed_Eating_3_Tablet_Motion_Speed));
            }
        }

        public const string __1000_displayName = "-------------------------------------------------------------------------------------------";
        public const int __1000_sortIndex = 1000;
        [SortOrder(__1000_sortIndex)]
        [DisplayName(__1000_displayName)]
        public virtual byte __1000 {
            get => GetData<byte>(3);
        }

        public const string Mud_Motion_Speed_displayName = "Mud Motion Speed";
        public const int Mud_Motion_Speed_sortIndex = 1050;
        [SortOrder(Mud_Motion_Speed_sortIndex)]
        [DisplayName(Mud_Motion_Speed_displayName)]
        public virtual float Mud_Motion_Speed {
            get => GetData<float>(75);
            set {
                if (GetData<float>(75) == value) return;
                SetData(75, value, nameof(Mud_Motion_Speed));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Mud_Motion_Speed));
            }
        }

        public const string Mud_Trans_Rate_displayName = "Mud Trans Rate";
        public const int Mud_Trans_Rate_sortIndex = 1100;
        [SortOrder(Mud_Trans_Rate_sortIndex)]
        [DisplayName(Mud_Trans_Rate_displayName)]
        public virtual float Mud_Trans_Rate {
            get => GetData<float>(79);
            set {
                if (GetData<float>(79) == value) return;
                SetData(79, value, nameof(Mud_Trans_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Mud_Trans_Rate));
            }
        }

        public const string Elemental_Damage_Defense__displayName = "Elemental Damage Defense %";
        public const int Elemental_Damage_Defense__sortIndex = 1150;
        [SortOrder(Elemental_Damage_Defense__sortIndex)]
        [DisplayName(Elemental_Damage_Defense__displayName)]
        public virtual byte Elemental_Damage_Defense_ {
            get => GetData<byte>(83);
            set {
                if (GetData<byte>(83) == value) return;
                SetData(83, value, nameof(Elemental_Damage_Defense_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Elemental_Damage_Defense_));
            }
        }

        public const string Elemental_Damage_Resist__displayName = "Elemental Damage Resist %";
        public const int Elemental_Damage_Resist__sortIndex = 1200;
        [SortOrder(Elemental_Damage_Resist__sortIndex)]
        [DisplayName(Elemental_Damage_Resist__displayName)]
        public virtual byte Elemental_Damage_Resist_ {
            get => GetData<byte>(84);
            set {
                if (GetData<byte>(84) == value) return;
                SetData(84, value, nameof(Elemental_Damage_Resist_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Elemental_Damage_Resist_));
            }
        }

        public const string Elemental_Damage_Resist_displayName = "Elemental Damage Resist";
        public const int Elemental_Damage_Resist_sortIndex = 1250;
        [SortOrder(Elemental_Damage_Resist_sortIndex)]
        [DisplayName(Elemental_Damage_Resist_displayName)]
        public virtual byte Elemental_Damage_Resist {
            get => GetData<byte>(85);
            set {
                if (GetData<byte>(85) == value) return;
                SetData(85, value, nameof(Elemental_Damage_Resist));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Elemental_Damage_Resist));
            }
        }

        public const string Weakness_Exploit_Hitzone_Threshold_displayName = "Weakness Exploit Hitzone Threshold";
        public const int Weakness_Exploit_Hitzone_Threshold_sortIndex = 1300;
        [SortOrder(Weakness_Exploit_Hitzone_Threshold_sortIndex)]
        [DisplayName(Weakness_Exploit_Hitzone_Threshold_displayName)]
        public virtual byte Weakness_Exploit_Hitzone_Threshold {
            get => GetData<byte>(86);
            set {
                if (GetData<byte>(86) == value) return;
                SetData(86, value, nameof(Weakness_Exploit_Hitzone_Threshold));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Weakness_Exploit_Hitzone_Threshold));
            }
        }

        public const string Latent_Power_Activation_Time_displayName = "Latent Power Activation Time";
        public const int Latent_Power_Activation_Time_sortIndex = 1350;
        [SortOrder(Latent_Power_Activation_Time_sortIndex)]
        [DisplayName(Latent_Power_Activation_Time_displayName)]
        public virtual ushort Latent_Power_Activation_Time {
            get => GetData<ushort>(87);
            set {
                if (GetData<ushort>(87) == value) return;
                SetData(87, value, nameof(Latent_Power_Activation_Time));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Latent_Power_Activation_Time));
            }
        }

        public const string Latent_Power_Total_Damage_to_Trigger_displayName = "Latent Power Total Damage to Trigger";
        public const int Latent_Power_Total_Damage_to_Trigger_sortIndex = 1400;
        [SortOrder(Latent_Power_Total_Damage_to_Trigger_sortIndex)]
        [DisplayName(Latent_Power_Total_Damage_to_Trigger_displayName)]
        public virtual ushort Latent_Power_Total_Damage_to_Trigger {
            get => GetData<ushort>(89);
            set {
                if (GetData<ushort>(89) == value) return;
                SetData(89, value, nameof(Latent_Power_Total_Damage_to_Trigger));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Latent_Power_Total_Damage_to_Trigger));
            }
        }

        public const string Latent_Power_Secret_Total_Damage_to_Trigger_displayName = "Latent Power Secret Total Damage to Trigger";
        public const int Latent_Power_Secret_Total_Damage_to_Trigger_sortIndex = 1450;
        [SortOrder(Latent_Power_Secret_Total_Damage_to_Trigger_sortIndex)]
        [DisplayName(Latent_Power_Secret_Total_Damage_to_Trigger_displayName)]
        public virtual ushort Latent_Power_Secret_Total_Damage_to_Trigger {
            get => GetData<ushort>(91);
            set {
                if (GetData<ushort>(91) == value) return;
                SetData(91, value, nameof(Latent_Power_Secret_Total_Damage_to_Trigger));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Latent_Power_Secret_Total_Damage_to_Trigger));
            }
        }

        public const string Heroics_Activation_Health__displayName = "Heroics Activation Health %";
        public const int Heroics_Activation_Health__sortIndex = 1500;
        [SortOrder(Heroics_Activation_Health__sortIndex)]
        [DisplayName(Heroics_Activation_Health__displayName)]
        public virtual float Heroics_Activation_Health_ {
            get => GetData<float>(93);
            set {
                if (GetData<float>(93) == value) return;
                SetData(93, value, nameof(Heroics_Activation_Health_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Heroics_Activation_Health_));
            }
        }

        public const string Guts_Health_Threshold_displayName = "Guts Health Threshold";
        public const int Guts_Health_Threshold_sortIndex = 1550;
        [SortOrder(Guts_Health_Threshold_sortIndex)]
        [DisplayName(Guts_Health_Threshold_displayName)]
        public virtual byte Guts_Health_Threshold {
            get => GetData<byte>(97);
            set {
                if (GetData<byte>(97) == value) return;
                SetData(97, value, nameof(Guts_Health_Threshold));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Guts_Health_Threshold));
            }
        }

        public const string __1600_displayName = "-------------------------------------------------------------------------------------------";
        public const int __1600_sortIndex = 1600;
        [SortOrder(__1600_sortIndex)]
        [DisplayName(__1600_displayName)]
        public virtual byte __1600 {
            get => GetData<byte>(3);
        }

        public const string Wide_Range_1_Efficiency_displayName = "Wide Range 1 Efficiency";
        public const int Wide_Range_1_Efficiency_sortIndex = 1650;
        [SortOrder(Wide_Range_1_Efficiency_sortIndex)]
        [DisplayName(Wide_Range_1_Efficiency_displayName)]
        public virtual float Wide_Range_1_Efficiency {
            get => GetData<float>(98);
            set {
                if (GetData<float>(98) == value) return;
                SetData(98, value, nameof(Wide_Range_1_Efficiency));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wide_Range_1_Efficiency));
            }
        }

        public const string Wide_Range_2_Efficiency_displayName = "Wide Range 2 Efficiency";
        public const int Wide_Range_2_Efficiency_sortIndex = 1700;
        [SortOrder(Wide_Range_2_Efficiency_sortIndex)]
        [DisplayName(Wide_Range_2_Efficiency_displayName)]
        public virtual float Wide_Range_2_Efficiency {
            get => GetData<float>(102);
            set {
                if (GetData<float>(102) == value) return;
                SetData(102, value, nameof(Wide_Range_2_Efficiency));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wide_Range_2_Efficiency));
            }
        }

        public const string Wide_Range_3_Efficiency_displayName = "Wide Range 3 Efficiency";
        public const int Wide_Range_3_Efficiency_sortIndex = 1750;
        [SortOrder(Wide_Range_3_Efficiency_sortIndex)]
        [DisplayName(Wide_Range_3_Efficiency_displayName)]
        public virtual float Wide_Range_3_Efficiency {
            get => GetData<float>(106);
            set {
                if (GetData<float>(106) == value) return;
                SetData(106, value, nameof(Wide_Range_3_Efficiency));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wide_Range_3_Efficiency));
            }
        }

        public const string Wide_Range_4_Efficiency_displayName = "Wide Range 4 Efficiency";
        public const int Wide_Range_4_Efficiency_sortIndex = 1800;
        [SortOrder(Wide_Range_4_Efficiency_sortIndex)]
        [DisplayName(Wide_Range_4_Efficiency_displayName)]
        public virtual float Wide_Range_4_Efficiency {
            get => GetData<float>(110);
            set {
                if (GetData<float>(110) == value) return;
                SetData(110, value, nameof(Wide_Range_4_Efficiency));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wide_Range_4_Efficiency));
            }
        }

        public const string Wide_Range_5_Efficiency_displayName = "Wide Range 5 Efficiency";
        public const int Wide_Range_5_Efficiency_sortIndex = 1850;
        [SortOrder(Wide_Range_5_Efficiency_sortIndex)]
        [DisplayName(Wide_Range_5_Efficiency_displayName)]
        public virtual float Wide_Range_5_Efficiency {
            get => GetData<float>(114);
            set {
                if (GetData<float>(114) == value) return;
                SetData(114, value, nameof(Wide_Range_5_Efficiency));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wide_Range_5_Efficiency));
            }
        }

        public const string Wide_Range_1_Range_displayName = "Wide Range 1 Range";
        public const int Wide_Range_1_Range_sortIndex = 1900;
        [SortOrder(Wide_Range_1_Range_sortIndex)]
        [DisplayName(Wide_Range_1_Range_displayName)]
        public virtual float Wide_Range_1_Range {
            get => GetData<float>(118);
            set {
                if (GetData<float>(118) == value) return;
                SetData(118, value, nameof(Wide_Range_1_Range));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wide_Range_1_Range));
            }
        }

        public const string Wide_Range_2_Range_displayName = "Wide Range 2 Range";
        public const int Wide_Range_2_Range_sortIndex = 1950;
        [SortOrder(Wide_Range_2_Range_sortIndex)]
        [DisplayName(Wide_Range_2_Range_displayName)]
        public virtual float Wide_Range_2_Range {
            get => GetData<float>(122);
            set {
                if (GetData<float>(122) == value) return;
                SetData(122, value, nameof(Wide_Range_2_Range));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wide_Range_2_Range));
            }
        }

        public const string Wide_Range_3_Range_displayName = "Wide Range 3 Range";
        public const int Wide_Range_3_Range_sortIndex = 2000;
        [SortOrder(Wide_Range_3_Range_sortIndex)]
        [DisplayName(Wide_Range_3_Range_displayName)]
        public virtual float Wide_Range_3_Range {
            get => GetData<float>(126);
            set {
                if (GetData<float>(126) == value) return;
                SetData(126, value, nameof(Wide_Range_3_Range));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wide_Range_3_Range));
            }
        }

        public const string Wide_Range_4_Range_displayName = "Wide Range 4 Range";
        public const int Wide_Range_4_Range_sortIndex = 2050;
        [SortOrder(Wide_Range_4_Range_sortIndex)]
        [DisplayName(Wide_Range_4_Range_displayName)]
        public virtual float Wide_Range_4_Range {
            get => GetData<float>(130);
            set {
                if (GetData<float>(130) == value) return;
                SetData(130, value, nameof(Wide_Range_4_Range));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wide_Range_4_Range));
            }
        }

        public const string Wide_Range_5_Range_displayName = "Wide Range 5 Range";
        public const int Wide_Range_5_Range_sortIndex = 2100;
        [SortOrder(Wide_Range_5_Range_sortIndex)]
        [DisplayName(Wide_Range_5_Range_displayName)]
        public virtual float Wide_Range_5_Range {
            get => GetData<float>(134);
            set {
                if (GetData<float>(134) == value) return;
                SetData(134, value, nameof(Wide_Range_5_Range));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Wide_Range_5_Range));
            }
        }

        public const string __2150_displayName = "-------------------------------------------------------------------------------------------";
        public const int __2150_sortIndex = 2150;
        [SortOrder(__2150_sortIndex)]
        [DisplayName(__2150_displayName)]
        public virtual byte __2150 {
            get => GetData<byte>(3);
        }

        public const string Unk1_displayName = "Unk1";
        public const int Unk1_sortIndex = 2200;
        [SortOrder(Unk1_sortIndex)]
        [DisplayName(Unk1_displayName)]
        public virtual float Unk1 {
            get => GetData<float>(138);
            set {
                if (GetData<float>(138) == value) return;
                SetData(138, value, nameof(Unk1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk1));
            }
        }

        public const string Unk2_displayName = "Unk2";
        public const int Unk2_sortIndex = 2250;
        [SortOrder(Unk2_sortIndex)]
        [DisplayName(Unk2_displayName)]
        public virtual float Unk2 {
            get => GetData<float>(142);
            set {
                if (GetData<float>(142) == value) return;
                SetData(142, value, nameof(Unk2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk2));
            }
        }

        public const string Unk3_displayName = "Unk3";
        public const int Unk3_sortIndex = 2300;
        [SortOrder(Unk3_sortIndex)]
        [DisplayName(Unk3_displayName)]
        public virtual float Unk3 {
            get => GetData<float>(146);
            set {
                if (GetData<float>(146) == value) return;
                SetData(146, value, nameof(Unk3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk3));
            }
        }

        public const string Unk4_displayName = "Unk4";
        public const int Unk4_sortIndex = 2350;
        [SortOrder(Unk4_sortIndex)]
        [DisplayName(Unk4_displayName)]
        public virtual float Unk4 {
            get => GetData<float>(150);
            set {
                if (GetData<float>(150) == value) return;
                SetData(150, value, nameof(Unk4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk4));
            }
        }

        public const string Unk5_displayName = "Unk5";
        public const int Unk5_sortIndex = 2400;
        [SortOrder(Unk5_sortIndex)]
        [DisplayName(Unk5_displayName)]
        public virtual float Unk5 {
            get => GetData<float>(154);
            set {
                if (GetData<float>(154) == value) return;
                SetData(154, value, nameof(Unk5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk5));
            }
        }

        public const string Unk6_displayName = "Unk6";
        public const int Unk6_sortIndex = 2450;
        [SortOrder(Unk6_sortIndex)]
        [DisplayName(Unk6_displayName)]
        public virtual float Unk6 {
            get => GetData<float>(158);
            set {
                if (GetData<float>(158) == value) return;
                SetData(158, value, nameof(Unk6));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk6));
            }
        }

        public const string Unk7_displayName = "Unk7";
        public const int Unk7_sortIndex = 2500;
        [SortOrder(Unk7_sortIndex)]
        [DisplayName(Unk7_displayName)]
        public virtual float Unk7 {
            get => GetData<float>(162);
            set {
                if (GetData<float>(162) == value) return;
                SetData(162, value, nameof(Unk7));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk7));
            }
        }

        public const string Unk8_displayName = "Unk8";
        public const int Unk8_sortIndex = 2550;
        [SortOrder(Unk8_sortIndex)]
        [DisplayName(Unk8_displayName)]
        public virtual float Unk8 {
            get => GetData<float>(166);
            set {
                if (GetData<float>(166) == value) return;
                SetData(166, value, nameof(Unk8));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk8));
            }
        }

        public const string Unk9_displayName = "Unk9";
        public const int Unk9_sortIndex = 2600;
        [SortOrder(Unk9_sortIndex)]
        [DisplayName(Unk9_displayName)]
        public virtual float Unk9 {
            get => GetData<float>(170);
            set {
                if (GetData<float>(170) == value) return;
                SetData(170, value, nameof(Unk9));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk9));
            }
        }

        public const string Unk10_displayName = "Unk10";
        public const int Unk10_sortIndex = 2650;
        [SortOrder(Unk10_sortIndex)]
        [DisplayName(Unk10_displayName)]
        public virtual float Unk10 {
            get => GetData<float>(174);
            set {
                if (GetData<float>(174) == value) return;
                SetData(174, value, nameof(Unk10));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk10));
            }
        }

        public const string Unk11_displayName = "Unk11";
        public const int Unk11_sortIndex = 2700;
        [SortOrder(Unk11_sortIndex)]
        [DisplayName(Unk11_displayName)]
        public virtual float Unk11 {
            get => GetData<float>(178);
            set {
                if (GetData<float>(178) == value) return;
                SetData(178, value, nameof(Unk11));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk11));
            }
        }

        public const string Unk12_displayName = "Unk12";
        public const int Unk12_sortIndex = 2750;
        [SortOrder(Unk12_sortIndex)]
        [DisplayName(Unk12_displayName)]
        public virtual float Unk12 {
            get => GetData<float>(182);
            set {
                if (GetData<float>(182) == value) return;
                SetData(182, value, nameof(Unk12));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk12));
            }
        }

        public const string Unk13_displayName = "Unk13";
        public const int Unk13_sortIndex = 2800;
        [SortOrder(Unk13_sortIndex)]
        [DisplayName(Unk13_displayName)]
        public virtual float Unk13 {
            get => GetData<float>(186);
            set {
                if (GetData<float>(186) == value) return;
                SetData(186, value, nameof(Unk13));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk13));
            }
        }

        public const string Unk14_displayName = "Unk14";
        public const int Unk14_sortIndex = 2850;
        [SortOrder(Unk14_sortIndex)]
        [DisplayName(Unk14_displayName)]
        public virtual float Unk14 {
            get => GetData<float>(190);
            set {
                if (GetData<float>(190) == value) return;
                SetData(190, value, nameof(Unk14));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk14));
            }
        }

        public const string Unk15_displayName = "Unk15";
        public const int Unk15_sortIndex = 2900;
        [SortOrder(Unk15_sortIndex)]
        [DisplayName(Unk15_displayName)]
        public virtual float Unk15 {
            get => GetData<float>(194);
            set {
                if (GetData<float>(194) == value) return;
                SetData(194, value, nameof(Unk15));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk15));
            }
        }

        public const string Unk16_displayName = "Unk16";
        public const int Unk16_sortIndex = 2950;
        [SortOrder(Unk16_sortIndex)]
        [DisplayName(Unk16_displayName)]
        public virtual float Unk16 {
            get => GetData<float>(198);
            set {
                if (GetData<float>(198) == value) return;
                SetData(198, value, nameof(Unk16));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk16));
            }
        }

        public const string Unk17_displayName = "Unk17";
        public const int Unk17_sortIndex = 3000;
        [SortOrder(Unk17_sortIndex)]
        [DisplayName(Unk17_displayName)]
        public virtual float Unk17 {
            get => GetData<float>(202);
            set {
                if (GetData<float>(202) == value) return;
                SetData(202, value, nameof(Unk17));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk17));
            }
        }

        public const string Unk18_displayName = "Unk18";
        public const int Unk18_sortIndex = 3050;
        [SortOrder(Unk18_sortIndex)]
        [DisplayName(Unk18_displayName)]
        public virtual float Unk18 {
            get => GetData<float>(202);
            set {
                if (GetData<float>(202) == value) return;
                SetData(202, value, nameof(Unk18));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk18));
            }
        }

        public const string Unk19_displayName = "Unk19";
        public const int Unk19_sortIndex = 3100;
        [SortOrder(Unk19_sortIndex)]
        [DisplayName(Unk19_displayName)]
        public virtual float Unk19 {
            get => GetData<float>(206);
            set {
                if (GetData<float>(206) == value) return;
                SetData(206, value, nameof(Unk19));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk19));
            }
        }

        public const string __3150_displayName = "-------------------------------------------------------------------------------------------";
        public const int __3150_sortIndex = 3150;
        [SortOrder(__3150_sortIndex)]
        [DisplayName(__3150_displayName)]
        public virtual byte __3150 {
            get => GetData<byte>(3);
        }

        public const string Focus_Gunlance_Charge_Shot_Time_Rate_1_displayName = "Focus (Gunlance, Charge Shot) Time Rate 1";
        public const int Focus_Gunlance_Charge_Shot_Time_Rate_1_sortIndex = 3200;
        [SortOrder(Focus_Gunlance_Charge_Shot_Time_Rate_1_sortIndex)]
        [DisplayName(Focus_Gunlance_Charge_Shot_Time_Rate_1_displayName)]
        public virtual float Focus_Gunlance_Charge_Shot_Time_Rate_1 {
            get => GetData<float>(210);
            set {
                if (GetData<float>(210) == value) return;
                SetData(210, value, nameof(Focus_Gunlance_Charge_Shot_Time_Rate_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Focus_Gunlance_Charge_Shot_Time_Rate_1));
            }
        }

        public const string Focus_Gunlance_Charge_Shot_Time_Rate_2_displayName = "Focus (Gunlance, Charge Shot) Time Rate 2";
        public const int Focus_Gunlance_Charge_Shot_Time_Rate_2_sortIndex = 3250;
        [SortOrder(Focus_Gunlance_Charge_Shot_Time_Rate_2_sortIndex)]
        [DisplayName(Focus_Gunlance_Charge_Shot_Time_Rate_2_displayName)]
        public virtual float Focus_Gunlance_Charge_Shot_Time_Rate_2 {
            get => GetData<float>(214);
            set {
                if (GetData<float>(214) == value) return;
                SetData(214, value, nameof(Focus_Gunlance_Charge_Shot_Time_Rate_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Focus_Gunlance_Charge_Shot_Time_Rate_2));
            }
        }

        public const string Focus_Gunlance_Charge_Shot_Time_Rate_3_displayName = "Focus (Gunlance, Charge Shot) Time Rate 3";
        public const int Focus_Gunlance_Charge_Shot_Time_Rate_3_sortIndex = 3300;
        [SortOrder(Focus_Gunlance_Charge_Shot_Time_Rate_3_sortIndex)]
        [DisplayName(Focus_Gunlance_Charge_Shot_Time_Rate_3_displayName)]
        public virtual float Focus_Gunlance_Charge_Shot_Time_Rate_3 {
            get => GetData<float>(218);
            set {
                if (GetData<float>(218) == value) return;
                SetData(218, value, nameof(Focus_Gunlance_Charge_Shot_Time_Rate_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Focus_Gunlance_Charge_Shot_Time_Rate_3));
            }
        }

        public const string Focus_Charge_Blade_Slash_2_Time_Rate_1_displayName = "Focus (Charge Blade, Slash 2) Time Rate 1";
        public const int Focus_Charge_Blade_Slash_2_Time_Rate_1_sortIndex = 3350;
        [SortOrder(Focus_Charge_Blade_Slash_2_Time_Rate_1_sortIndex)]
        [DisplayName(Focus_Charge_Blade_Slash_2_Time_Rate_1_displayName)]
        public virtual float Focus_Charge_Blade_Slash_2_Time_Rate_1 {
            get => GetData<float>(222);
            set {
                if (GetData<float>(222) == value) return;
                SetData(222, value, nameof(Focus_Charge_Blade_Slash_2_Time_Rate_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Focus_Charge_Blade_Slash_2_Time_Rate_1));
            }
        }

        public const string Focus_Charge_Blade_Slash_2_Time_Rate_2_displayName = "Focus (Charge Blade, Slash 2) Time Rate 2";
        public const int Focus_Charge_Blade_Slash_2_Time_Rate_2_sortIndex = 3400;
        [SortOrder(Focus_Charge_Blade_Slash_2_Time_Rate_2_sortIndex)]
        [DisplayName(Focus_Charge_Blade_Slash_2_Time_Rate_2_displayName)]
        public virtual float Focus_Charge_Blade_Slash_2_Time_Rate_2 {
            get => GetData<float>(226);
            set {
                if (GetData<float>(226) == value) return;
                SetData(226, value, nameof(Focus_Charge_Blade_Slash_2_Time_Rate_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Focus_Charge_Blade_Slash_2_Time_Rate_2));
            }
        }

        public const string Focus_Charge_Blade_Slash_2_Time_Rate_3_displayName = "Focus (Charge Blade, Slash 2) Time Rate 3";
        public const int Focus_Charge_Blade_Slash_2_Time_Rate_3_sortIndex = 3450;
        [SortOrder(Focus_Charge_Blade_Slash_2_Time_Rate_3_sortIndex)]
        [DisplayName(Focus_Charge_Blade_Slash_2_Time_Rate_3_displayName)]
        public virtual float Focus_Charge_Blade_Slash_2_Time_Rate_3 {
            get => GetData<float>(230);
            set {
                if (GetData<float>(230) == value) return;
                SetData(230, value, nameof(Focus_Charge_Blade_Slash_2_Time_Rate_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Focus_Charge_Blade_Slash_2_Time_Rate_3));
            }
        }

        public const string Focus_Charge_Blade_Phial_Charge_Slash_Time_Rate_1_displayName = "Focus (Charge Blade, Phial Charge Slash) Time Rate 1";
        public const int Focus_Charge_Blade_Phial_Charge_Slash_Time_Rate_1_sortIndex = 3500;
        [SortOrder(Focus_Charge_Blade_Phial_Charge_Slash_Time_Rate_1_sortIndex)]
        [DisplayName(Focus_Charge_Blade_Phial_Charge_Slash_Time_Rate_1_displayName)]
        public virtual float Focus_Charge_Blade_Phial_Charge_Slash_Time_Rate_1 {
            get => GetData<float>(234);
            set {
                if (GetData<float>(234) == value) return;
                SetData(234, value, nameof(Focus_Charge_Blade_Phial_Charge_Slash_Time_Rate_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Focus_Charge_Blade_Phial_Charge_Slash_Time_Rate_1));
            }
        }

        public const string Focus_Charge_Blade_Phial_Charge_Slash_Time_Rate_2_displayName = "Focus (Charge Blade, Phial Charge Slash) Time Rate 2";
        public const int Focus_Charge_Blade_Phial_Charge_Slash_Time_Rate_2_sortIndex = 3550;
        [SortOrder(Focus_Charge_Blade_Phial_Charge_Slash_Time_Rate_2_sortIndex)]
        [DisplayName(Focus_Charge_Blade_Phial_Charge_Slash_Time_Rate_2_displayName)]
        public virtual float Focus_Charge_Blade_Phial_Charge_Slash_Time_Rate_2 {
            get => GetData<float>(238);
            set {
                if (GetData<float>(238) == value) return;
                SetData(238, value, nameof(Focus_Charge_Blade_Phial_Charge_Slash_Time_Rate_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Focus_Charge_Blade_Phial_Charge_Slash_Time_Rate_2));
            }
        }

        public const string Focus_Charge_Blade_Phial_Charge_Slash_Time_Rate_3_displayName = "Focus (Charge Blade, Phial Charge Slash) Time Rate 3";
        public const int Focus_Charge_Blade_Phial_Charge_Slash_Time_Rate_3_sortIndex = 3600;
        [SortOrder(Focus_Charge_Blade_Phial_Charge_Slash_Time_Rate_3_sortIndex)]
        [DisplayName(Focus_Charge_Blade_Phial_Charge_Slash_Time_Rate_3_displayName)]
        public virtual float Focus_Charge_Blade_Phial_Charge_Slash_Time_Rate_3 {
            get => GetData<float>(242);
            set {
                if (GetData<float>(242) == value) return;
                SetData(242, value, nameof(Focus_Charge_Blade_Phial_Charge_Slash_Time_Rate_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Focus_Charge_Blade_Phial_Charge_Slash_Time_Rate_3));
            }
        }

        public const string __3650_displayName = "-------------------------------------------------------------------------------------------";
        public const int __3650_sortIndex = 3650;
        [SortOrder(__3650_sortIndex)]
        [DisplayName(__3650_displayName)]
        public virtual byte __3650 {
            get => GetData<byte>(3);
        }

        public const string Punishing_Draw_Great_Sword_Attack_Power_displayName = "Punishing Draw (Great Sword) Attack Power";
        public const int Punishing_Draw_Great_Sword_Attack_Power_sortIndex = 3700;
        [SortOrder(Punishing_Draw_Great_Sword_Attack_Power_sortIndex)]
        [DisplayName(Punishing_Draw_Great_Sword_Attack_Power_displayName)]
        public virtual ushort Punishing_Draw_Great_Sword_Attack_Power {
            get => GetData<ushort>(246);
            set {
                if (GetData<ushort>(246) == value) return;
                SetData(246, value, nameof(Punishing_Draw_Great_Sword_Attack_Power));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Great_Sword_Attack_Power));
            }
        }

        public const string Punishing_Draw_Great_Sword_Stun_displayName = "Punishing Draw (Great Sword) Stun";
        public const int Punishing_Draw_Great_Sword_Stun_sortIndex = 3750;
        [SortOrder(Punishing_Draw_Great_Sword_Stun_sortIndex)]
        [DisplayName(Punishing_Draw_Great_Sword_Stun_displayName)]
        public virtual ushort Punishing_Draw_Great_Sword_Stun {
            get => GetData<ushort>(248);
            set {
                if (GetData<ushort>(248) == value) return;
                SetData(248, value, nameof(Punishing_Draw_Great_Sword_Stun));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Great_Sword_Stun));
            }
        }

        public const string Punishing_Draw_Great_Sword_Exhaust_displayName = "Punishing Draw (Great Sword) Exhaust";
        public const int Punishing_Draw_Great_Sword_Exhaust_sortIndex = 3800;
        [SortOrder(Punishing_Draw_Great_Sword_Exhaust_sortIndex)]
        [DisplayName(Punishing_Draw_Great_Sword_Exhaust_displayName)]
        public virtual ushort Punishing_Draw_Great_Sword_Exhaust {
            get => GetData<ushort>(250);
            set {
                if (GetData<ushort>(250) == value) return;
                SetData(250, value, nameof(Punishing_Draw_Great_Sword_Exhaust));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Great_Sword_Exhaust));
            }
        }

        public const string Punishing_Draw_Great_Sword_Param_4_displayName = "Punishing Draw (Great Sword) Param 4";
        public const int Punishing_Draw_Great_Sword_Param_4_sortIndex = 3850;
        [SortOrder(Punishing_Draw_Great_Sword_Param_4_sortIndex)]
        [DisplayName(Punishing_Draw_Great_Sword_Param_4_displayName)]
        public virtual ushort Punishing_Draw_Great_Sword_Param_4 {
            get => GetData<ushort>(252);
            set {
                if (GetData<ushort>(252) == value) return;
                SetData(252, value, nameof(Punishing_Draw_Great_Sword_Param_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Great_Sword_Param_4));
            }
        }

        public const string Punishing_Draw_Great_Sword_Param_5_displayName = "Punishing Draw (Great Sword) Param 5";
        public const int Punishing_Draw_Great_Sword_Param_5_sortIndex = 3900;
        [SortOrder(Punishing_Draw_Great_Sword_Param_5_sortIndex)]
        [DisplayName(Punishing_Draw_Great_Sword_Param_5_displayName)]
        public virtual ushort Punishing_Draw_Great_Sword_Param_5 {
            get => GetData<ushort>(254);
            set {
                if (GetData<ushort>(254) == value) return;
                SetData(254, value, nameof(Punishing_Draw_Great_Sword_Param_5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Great_Sword_Param_5));
            }
        }

        public const string Punishing_Draw_Great_Sword_Param_6_displayName = "Punishing Draw (Great Sword) Param 6";
        public const int Punishing_Draw_Great_Sword_Param_6_sortIndex = 3950;
        [SortOrder(Punishing_Draw_Great_Sword_Param_6_sortIndex)]
        [DisplayName(Punishing_Draw_Great_Sword_Param_6_displayName)]
        public virtual ushort Punishing_Draw_Great_Sword_Param_6 {
            get => GetData<ushort>(256);
            set {
                if (GetData<ushort>(256) == value) return;
                SetData(256, value, nameof(Punishing_Draw_Great_Sword_Param_6));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Great_Sword_Param_6));
            }
        }

        public const string __4000_displayName = "-------------------------------------------------------------------------------------------";
        public const int __4000_sortIndex = 4000;
        [SortOrder(__4000_sortIndex)]
        [DisplayName(__4000_displayName)]
        public virtual byte __4000 {
            get => GetData<byte>(3);
        }

        public const string Punishing_Draw_Sword_Shield_Attack_Power_displayName = "Punishing Draw (Sword & Shield) Attack Power";
        public const int Punishing_Draw_Sword_Shield_Attack_Power_sortIndex = 4050;
        [SortOrder(Punishing_Draw_Sword_Shield_Attack_Power_sortIndex)]
        [DisplayName(Punishing_Draw_Sword_Shield_Attack_Power_displayName)]
        public virtual ushort Punishing_Draw_Sword_Shield_Attack_Power {
            get => GetData<ushort>(258);
            set {
                if (GetData<ushort>(258) == value) return;
                SetData(258, value, nameof(Punishing_Draw_Sword_Shield_Attack_Power));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Sword_Shield_Attack_Power));
            }
        }

        public const string Punishing_Draw_Sword_Shield_Stun_displayName = "Punishing Draw (Sword & Shield) Stun";
        public const int Punishing_Draw_Sword_Shield_Stun_sortIndex = 4100;
        [SortOrder(Punishing_Draw_Sword_Shield_Stun_sortIndex)]
        [DisplayName(Punishing_Draw_Sword_Shield_Stun_displayName)]
        public virtual ushort Punishing_Draw_Sword_Shield_Stun {
            get => GetData<ushort>(260);
            set {
                if (GetData<ushort>(260) == value) return;
                SetData(260, value, nameof(Punishing_Draw_Sword_Shield_Stun));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Sword_Shield_Stun));
            }
        }

        public const string Punishing_Draw_Sword_Shield_Exhaust_displayName = "Punishing Draw (Sword & Shield) Exhaust";
        public const int Punishing_Draw_Sword_Shield_Exhaust_sortIndex = 4150;
        [SortOrder(Punishing_Draw_Sword_Shield_Exhaust_sortIndex)]
        [DisplayName(Punishing_Draw_Sword_Shield_Exhaust_displayName)]
        public virtual ushort Punishing_Draw_Sword_Shield_Exhaust {
            get => GetData<ushort>(262);
            set {
                if (GetData<ushort>(262) == value) return;
                SetData(262, value, nameof(Punishing_Draw_Sword_Shield_Exhaust));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Sword_Shield_Exhaust));
            }
        }

        public const string Punishing_Draw_Sword_Shield_Param_4_displayName = "Punishing Draw (Sword & Shield) Param 4";
        public const int Punishing_Draw_Sword_Shield_Param_4_sortIndex = 4200;
        [SortOrder(Punishing_Draw_Sword_Shield_Param_4_sortIndex)]
        [DisplayName(Punishing_Draw_Sword_Shield_Param_4_displayName)]
        public virtual ushort Punishing_Draw_Sword_Shield_Param_4 {
            get => GetData<ushort>(264);
            set {
                if (GetData<ushort>(264) == value) return;
                SetData(264, value, nameof(Punishing_Draw_Sword_Shield_Param_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Sword_Shield_Param_4));
            }
        }

        public const string Punishing_Draw_Sword_Shield_Param_5_displayName = "Punishing Draw (Sword & Shield) Param 5";
        public const int Punishing_Draw_Sword_Shield_Param_5_sortIndex = 4250;
        [SortOrder(Punishing_Draw_Sword_Shield_Param_5_sortIndex)]
        [DisplayName(Punishing_Draw_Sword_Shield_Param_5_displayName)]
        public virtual ushort Punishing_Draw_Sword_Shield_Param_5 {
            get => GetData<ushort>(266);
            set {
                if (GetData<ushort>(266) == value) return;
                SetData(266, value, nameof(Punishing_Draw_Sword_Shield_Param_5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Sword_Shield_Param_5));
            }
        }

        public const string Punishing_Draw_Sword_Shield_Param_6_displayName = "Punishing Draw (Sword & Shield) Param 6";
        public const int Punishing_Draw_Sword_Shield_Param_6_sortIndex = 4300;
        [SortOrder(Punishing_Draw_Sword_Shield_Param_6_sortIndex)]
        [DisplayName(Punishing_Draw_Sword_Shield_Param_6_displayName)]
        public virtual ushort Punishing_Draw_Sword_Shield_Param_6 {
            get => GetData<ushort>(268);
            set {
                if (GetData<ushort>(268) == value) return;
                SetData(268, value, nameof(Punishing_Draw_Sword_Shield_Param_6));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Sword_Shield_Param_6));
            }
        }

        public const string __4350_displayName = "-------------------------------------------------------------------------------------------";
        public const int __4350_sortIndex = 4350;
        [SortOrder(__4350_sortIndex)]
        [DisplayName(__4350_displayName)]
        public virtual byte __4350 {
            get => GetData<byte>(3);
        }

        public const string Punishing_Draw_Dual_Blades_Attack_Power_displayName = "Punishing Draw (Dual Blades) Attack Power";
        public const int Punishing_Draw_Dual_Blades_Attack_Power_sortIndex = 4400;
        [SortOrder(Punishing_Draw_Dual_Blades_Attack_Power_sortIndex)]
        [DisplayName(Punishing_Draw_Dual_Blades_Attack_Power_displayName)]
        public virtual ushort Punishing_Draw_Dual_Blades_Attack_Power {
            get => GetData<ushort>(270);
            set {
                if (GetData<ushort>(270) == value) return;
                SetData(270, value, nameof(Punishing_Draw_Dual_Blades_Attack_Power));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Dual_Blades_Attack_Power));
            }
        }

        public const string Punishing_Draw_Dual_Blades_Stun_displayName = "Punishing Draw (Dual Blades) Stun";
        public const int Punishing_Draw_Dual_Blades_Stun_sortIndex = 4450;
        [SortOrder(Punishing_Draw_Dual_Blades_Stun_sortIndex)]
        [DisplayName(Punishing_Draw_Dual_Blades_Stun_displayName)]
        public virtual ushort Punishing_Draw_Dual_Blades_Stun {
            get => GetData<ushort>(272);
            set {
                if (GetData<ushort>(272) == value) return;
                SetData(272, value, nameof(Punishing_Draw_Dual_Blades_Stun));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Dual_Blades_Stun));
            }
        }

        public const string Punishing_Draw_Dual_Blades_Exhaust_displayName = "Punishing Draw (Dual Blades) Exhaust";
        public const int Punishing_Draw_Dual_Blades_Exhaust_sortIndex = 4500;
        [SortOrder(Punishing_Draw_Dual_Blades_Exhaust_sortIndex)]
        [DisplayName(Punishing_Draw_Dual_Blades_Exhaust_displayName)]
        public virtual ushort Punishing_Draw_Dual_Blades_Exhaust {
            get => GetData<ushort>(274);
            set {
                if (GetData<ushort>(274) == value) return;
                SetData(274, value, nameof(Punishing_Draw_Dual_Blades_Exhaust));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Dual_Blades_Exhaust));
            }
        }

        public const string Punishing_Draw_Dual_Blades_Param_4_displayName = "Punishing Draw (Dual Blades) Param 4";
        public const int Punishing_Draw_Dual_Blades_Param_4_sortIndex = 4550;
        [SortOrder(Punishing_Draw_Dual_Blades_Param_4_sortIndex)]
        [DisplayName(Punishing_Draw_Dual_Blades_Param_4_displayName)]
        public virtual ushort Punishing_Draw_Dual_Blades_Param_4 {
            get => GetData<ushort>(276);
            set {
                if (GetData<ushort>(276) == value) return;
                SetData(276, value, nameof(Punishing_Draw_Dual_Blades_Param_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Dual_Blades_Param_4));
            }
        }

        public const string Punishing_Draw_Dual_Blades_Param_5_displayName = "Punishing Draw (Dual Blades) Param 5";
        public const int Punishing_Draw_Dual_Blades_Param_5_sortIndex = 4600;
        [SortOrder(Punishing_Draw_Dual_Blades_Param_5_sortIndex)]
        [DisplayName(Punishing_Draw_Dual_Blades_Param_5_displayName)]
        public virtual ushort Punishing_Draw_Dual_Blades_Param_5 {
            get => GetData<ushort>(278);
            set {
                if (GetData<ushort>(278) == value) return;
                SetData(278, value, nameof(Punishing_Draw_Dual_Blades_Param_5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Dual_Blades_Param_5));
            }
        }

        public const string Punishing_Draw_Dual_Blades_Param_6_displayName = "Punishing Draw (Dual Blades) Param 6";
        public const int Punishing_Draw_Dual_Blades_Param_6_sortIndex = 4650;
        [SortOrder(Punishing_Draw_Dual_Blades_Param_6_sortIndex)]
        [DisplayName(Punishing_Draw_Dual_Blades_Param_6_displayName)]
        public virtual ushort Punishing_Draw_Dual_Blades_Param_6 {
            get => GetData<ushort>(280);
            set {
                if (GetData<ushort>(280) == value) return;
                SetData(280, value, nameof(Punishing_Draw_Dual_Blades_Param_6));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Dual_Blades_Param_6));
            }
        }

        public const string __4700_displayName = "-------------------------------------------------------------------------------------------";
        public const int __4700_sortIndex = 4700;
        [SortOrder(__4700_sortIndex)]
        [DisplayName(__4700_displayName)]
        public virtual byte __4700 {
            get => GetData<byte>(3);
        }

        public const string Punishing_Draw_Long_Sword_Attack_Power_displayName = "Punishing Draw (Long Sword) Attack Power";
        public const int Punishing_Draw_Long_Sword_Attack_Power_sortIndex = 4750;
        [SortOrder(Punishing_Draw_Long_Sword_Attack_Power_sortIndex)]
        [DisplayName(Punishing_Draw_Long_Sword_Attack_Power_displayName)]
        public virtual ushort Punishing_Draw_Long_Sword_Attack_Power {
            get => GetData<ushort>(282);
            set {
                if (GetData<ushort>(282) == value) return;
                SetData(282, value, nameof(Punishing_Draw_Long_Sword_Attack_Power));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Long_Sword_Attack_Power));
            }
        }

        public const string Punishing_Draw_Long_Sword_Stun_displayName = "Punishing Draw (Long Sword) Stun";
        public const int Punishing_Draw_Long_Sword_Stun_sortIndex = 4800;
        [SortOrder(Punishing_Draw_Long_Sword_Stun_sortIndex)]
        [DisplayName(Punishing_Draw_Long_Sword_Stun_displayName)]
        public virtual ushort Punishing_Draw_Long_Sword_Stun {
            get => GetData<ushort>(284);
            set {
                if (GetData<ushort>(284) == value) return;
                SetData(284, value, nameof(Punishing_Draw_Long_Sword_Stun));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Long_Sword_Stun));
            }
        }

        public const string Punishing_Draw_Long_Sword_Exhaust_displayName = "Punishing Draw (Long Sword) Exhaust";
        public const int Punishing_Draw_Long_Sword_Exhaust_sortIndex = 4850;
        [SortOrder(Punishing_Draw_Long_Sword_Exhaust_sortIndex)]
        [DisplayName(Punishing_Draw_Long_Sword_Exhaust_displayName)]
        public virtual ushort Punishing_Draw_Long_Sword_Exhaust {
            get => GetData<ushort>(286);
            set {
                if (GetData<ushort>(286) == value) return;
                SetData(286, value, nameof(Punishing_Draw_Long_Sword_Exhaust));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Long_Sword_Exhaust));
            }
        }

        public const string Punishing_Draw_Long_Sword_Param_4_displayName = "Punishing Draw (Long Sword) Param 4";
        public const int Punishing_Draw_Long_Sword_Param_4_sortIndex = 4900;
        [SortOrder(Punishing_Draw_Long_Sword_Param_4_sortIndex)]
        [DisplayName(Punishing_Draw_Long_Sword_Param_4_displayName)]
        public virtual ushort Punishing_Draw_Long_Sword_Param_4 {
            get => GetData<ushort>(288);
            set {
                if (GetData<ushort>(288) == value) return;
                SetData(288, value, nameof(Punishing_Draw_Long_Sword_Param_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Long_Sword_Param_4));
            }
        }

        public const string Punishing_Draw_Long_Sword_Param_5_displayName = "Punishing Draw (Long Sword) Param 5";
        public const int Punishing_Draw_Long_Sword_Param_5_sortIndex = 4950;
        [SortOrder(Punishing_Draw_Long_Sword_Param_5_sortIndex)]
        [DisplayName(Punishing_Draw_Long_Sword_Param_5_displayName)]
        public virtual ushort Punishing_Draw_Long_Sword_Param_5 {
            get => GetData<ushort>(290);
            set {
                if (GetData<ushort>(290) == value) return;
                SetData(290, value, nameof(Punishing_Draw_Long_Sword_Param_5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Long_Sword_Param_5));
            }
        }

        public const string Punishing_Draw_Long_Sword_Param_6_displayName = "Punishing Draw (Long Sword) Param 6";
        public const int Punishing_Draw_Long_Sword_Param_6_sortIndex = 5000;
        [SortOrder(Punishing_Draw_Long_Sword_Param_6_sortIndex)]
        [DisplayName(Punishing_Draw_Long_Sword_Param_6_displayName)]
        public virtual ushort Punishing_Draw_Long_Sword_Param_6 {
            get => GetData<ushort>(292);
            set {
                if (GetData<ushort>(292) == value) return;
                SetData(292, value, nameof(Punishing_Draw_Long_Sword_Param_6));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Long_Sword_Param_6));
            }
        }

        public const string __5050_displayName = "-------------------------------------------------------------------------------------------";
        public const int __5050_sortIndex = 5050;
        [SortOrder(__5050_sortIndex)]
        [DisplayName(__5050_displayName)]
        public virtual byte __5050 {
            get => GetData<byte>(3);
        }

        public const string Punishing_Draw_Hammer_Attack_Power_displayName = "Punishing Draw (Hammer) Attack Power";
        public const int Punishing_Draw_Hammer_Attack_Power_sortIndex = 5100;
        [SortOrder(Punishing_Draw_Hammer_Attack_Power_sortIndex)]
        [DisplayName(Punishing_Draw_Hammer_Attack_Power_displayName)]
        public virtual ushort Punishing_Draw_Hammer_Attack_Power {
            get => GetData<ushort>(294);
            set {
                if (GetData<ushort>(294) == value) return;
                SetData(294, value, nameof(Punishing_Draw_Hammer_Attack_Power));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Hammer_Attack_Power));
            }
        }

        public const string Punishing_Draw_Hammer_Stun_displayName = "Punishing Draw (Hammer) Stun";
        public const int Punishing_Draw_Hammer_Stun_sortIndex = 5150;
        [SortOrder(Punishing_Draw_Hammer_Stun_sortIndex)]
        [DisplayName(Punishing_Draw_Hammer_Stun_displayName)]
        public virtual ushort Punishing_Draw_Hammer_Stun {
            get => GetData<ushort>(296);
            set {
                if (GetData<ushort>(296) == value) return;
                SetData(296, value, nameof(Punishing_Draw_Hammer_Stun));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Hammer_Stun));
            }
        }

        public const string Punishing_Draw_Hammer_Exhaust_displayName = "Punishing Draw (Hammer) Exhaust";
        public const int Punishing_Draw_Hammer_Exhaust_sortIndex = 5200;
        [SortOrder(Punishing_Draw_Hammer_Exhaust_sortIndex)]
        [DisplayName(Punishing_Draw_Hammer_Exhaust_displayName)]
        public virtual ushort Punishing_Draw_Hammer_Exhaust {
            get => GetData<ushort>(298);
            set {
                if (GetData<ushort>(298) == value) return;
                SetData(298, value, nameof(Punishing_Draw_Hammer_Exhaust));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Hammer_Exhaust));
            }
        }

        public const string Punishing_Draw_Hammer_Param_4_displayName = "Punishing Draw (Hammer) Param 4";
        public const int Punishing_Draw_Hammer_Param_4_sortIndex = 5250;
        [SortOrder(Punishing_Draw_Hammer_Param_4_sortIndex)]
        [DisplayName(Punishing_Draw_Hammer_Param_4_displayName)]
        public virtual ushort Punishing_Draw_Hammer_Param_4 {
            get => GetData<ushort>(300);
            set {
                if (GetData<ushort>(300) == value) return;
                SetData(300, value, nameof(Punishing_Draw_Hammer_Param_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Hammer_Param_4));
            }
        }

        public const string Punishing_Draw_Hammer_Param_5_displayName = "Punishing Draw (Hammer) Param 5";
        public const int Punishing_Draw_Hammer_Param_5_sortIndex = 5300;
        [SortOrder(Punishing_Draw_Hammer_Param_5_sortIndex)]
        [DisplayName(Punishing_Draw_Hammer_Param_5_displayName)]
        public virtual ushort Punishing_Draw_Hammer_Param_5 {
            get => GetData<ushort>(302);
            set {
                if (GetData<ushort>(302) == value) return;
                SetData(302, value, nameof(Punishing_Draw_Hammer_Param_5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Hammer_Param_5));
            }
        }

        public const string Punishing_Draw_Hammer_Param_6_displayName = "Punishing Draw (Hammer) Param 6";
        public const int Punishing_Draw_Hammer_Param_6_sortIndex = 5350;
        [SortOrder(Punishing_Draw_Hammer_Param_6_sortIndex)]
        [DisplayName(Punishing_Draw_Hammer_Param_6_displayName)]
        public virtual ushort Punishing_Draw_Hammer_Param_6 {
            get => GetData<ushort>(304);
            set {
                if (GetData<ushort>(304) == value) return;
                SetData(304, value, nameof(Punishing_Draw_Hammer_Param_6));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Hammer_Param_6));
            }
        }

        public const string __5400_displayName = "-------------------------------------------------------------------------------------------";
        public const int __5400_sortIndex = 5400;
        [SortOrder(__5400_sortIndex)]
        [DisplayName(__5400_displayName)]
        public virtual byte __5400 {
            get => GetData<byte>(3);
        }

        public const string Punishing_Draw_Hunting_Horn_Attack_Power_displayName = "Punishing Draw (Hunting Horn) Attack Power";
        public const int Punishing_Draw_Hunting_Horn_Attack_Power_sortIndex = 5450;
        [SortOrder(Punishing_Draw_Hunting_Horn_Attack_Power_sortIndex)]
        [DisplayName(Punishing_Draw_Hunting_Horn_Attack_Power_displayName)]
        public virtual ushort Punishing_Draw_Hunting_Horn_Attack_Power {
            get => GetData<ushort>(306);
            set {
                if (GetData<ushort>(306) == value) return;
                SetData(306, value, nameof(Punishing_Draw_Hunting_Horn_Attack_Power));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Hunting_Horn_Attack_Power));
            }
        }

        public const string Punishing_Draw_Hunting_Horn_Stun_displayName = "Punishing Draw (Hunting Horn) Stun";
        public const int Punishing_Draw_Hunting_Horn_Stun_sortIndex = 5500;
        [SortOrder(Punishing_Draw_Hunting_Horn_Stun_sortIndex)]
        [DisplayName(Punishing_Draw_Hunting_Horn_Stun_displayName)]
        public virtual ushort Punishing_Draw_Hunting_Horn_Stun {
            get => GetData<ushort>(308);
            set {
                if (GetData<ushort>(308) == value) return;
                SetData(308, value, nameof(Punishing_Draw_Hunting_Horn_Stun));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Hunting_Horn_Stun));
            }
        }

        public const string Punishing_Draw_Hunting_Horn_Exhaust_displayName = "Punishing Draw (Hunting Horn) Exhaust";
        public const int Punishing_Draw_Hunting_Horn_Exhaust_sortIndex = 5550;
        [SortOrder(Punishing_Draw_Hunting_Horn_Exhaust_sortIndex)]
        [DisplayName(Punishing_Draw_Hunting_Horn_Exhaust_displayName)]
        public virtual ushort Punishing_Draw_Hunting_Horn_Exhaust {
            get => GetData<ushort>(310);
            set {
                if (GetData<ushort>(310) == value) return;
                SetData(310, value, nameof(Punishing_Draw_Hunting_Horn_Exhaust));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Hunting_Horn_Exhaust));
            }
        }

        public const string Punishing_Draw_Hunting_Horn_Param_4_displayName = "Punishing Draw (Hunting Horn) Param 4";
        public const int Punishing_Draw_Hunting_Horn_Param_4_sortIndex = 5600;
        [SortOrder(Punishing_Draw_Hunting_Horn_Param_4_sortIndex)]
        [DisplayName(Punishing_Draw_Hunting_Horn_Param_4_displayName)]
        public virtual ushort Punishing_Draw_Hunting_Horn_Param_4 {
            get => GetData<ushort>(312);
            set {
                if (GetData<ushort>(312) == value) return;
                SetData(312, value, nameof(Punishing_Draw_Hunting_Horn_Param_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Hunting_Horn_Param_4));
            }
        }

        public const string Punishing_Draw_Hunting_Horn_Param_5_displayName = "Punishing Draw (Hunting Horn) Param 5";
        public const int Punishing_Draw_Hunting_Horn_Param_5_sortIndex = 5650;
        [SortOrder(Punishing_Draw_Hunting_Horn_Param_5_sortIndex)]
        [DisplayName(Punishing_Draw_Hunting_Horn_Param_5_displayName)]
        public virtual ushort Punishing_Draw_Hunting_Horn_Param_5 {
            get => GetData<ushort>(314);
            set {
                if (GetData<ushort>(314) == value) return;
                SetData(314, value, nameof(Punishing_Draw_Hunting_Horn_Param_5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Hunting_Horn_Param_5));
            }
        }

        public const string Punishing_Draw_Hunting_Horn_Param_6_displayName = "Punishing Draw (Hunting Horn) Param 6";
        public const int Punishing_Draw_Hunting_Horn_Param_6_sortIndex = 5700;
        [SortOrder(Punishing_Draw_Hunting_Horn_Param_6_sortIndex)]
        [DisplayName(Punishing_Draw_Hunting_Horn_Param_6_displayName)]
        public virtual ushort Punishing_Draw_Hunting_Horn_Param_6 {
            get => GetData<ushort>(316);
            set {
                if (GetData<ushort>(316) == value) return;
                SetData(316, value, nameof(Punishing_Draw_Hunting_Horn_Param_6));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Hunting_Horn_Param_6));
            }
        }

        public const string __5750_displayName = "-------------------------------------------------------------------------------------------";
        public const int __5750_sortIndex = 5750;
        [SortOrder(__5750_sortIndex)]
        [DisplayName(__5750_displayName)]
        public virtual byte __5750 {
            get => GetData<byte>(3);
        }

        public const string Punishing_Draw_Lance_Attack_Power_displayName = "Punishing Draw (Lance) Attack Power";
        public const int Punishing_Draw_Lance_Attack_Power_sortIndex = 5800;
        [SortOrder(Punishing_Draw_Lance_Attack_Power_sortIndex)]
        [DisplayName(Punishing_Draw_Lance_Attack_Power_displayName)]
        public virtual ushort Punishing_Draw_Lance_Attack_Power {
            get => GetData<ushort>(318);
            set {
                if (GetData<ushort>(318) == value) return;
                SetData(318, value, nameof(Punishing_Draw_Lance_Attack_Power));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Lance_Attack_Power));
            }
        }

        public const string Punishing_Draw_Lance_Stun_displayName = "Punishing Draw (Lance) Stun";
        public const int Punishing_Draw_Lance_Stun_sortIndex = 5850;
        [SortOrder(Punishing_Draw_Lance_Stun_sortIndex)]
        [DisplayName(Punishing_Draw_Lance_Stun_displayName)]
        public virtual ushort Punishing_Draw_Lance_Stun {
            get => GetData<ushort>(320);
            set {
                if (GetData<ushort>(320) == value) return;
                SetData(320, value, nameof(Punishing_Draw_Lance_Stun));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Lance_Stun));
            }
        }

        public const string Punishing_Draw_Lance_Exhaust_displayName = "Punishing Draw (Lance) Exhaust";
        public const int Punishing_Draw_Lance_Exhaust_sortIndex = 5900;
        [SortOrder(Punishing_Draw_Lance_Exhaust_sortIndex)]
        [DisplayName(Punishing_Draw_Lance_Exhaust_displayName)]
        public virtual ushort Punishing_Draw_Lance_Exhaust {
            get => GetData<ushort>(322);
            set {
                if (GetData<ushort>(322) == value) return;
                SetData(322, value, nameof(Punishing_Draw_Lance_Exhaust));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Lance_Exhaust));
            }
        }

        public const string Punishing_Draw_Lance_Param_4_displayName = "Punishing Draw (Lance) Param 4";
        public const int Punishing_Draw_Lance_Param_4_sortIndex = 5950;
        [SortOrder(Punishing_Draw_Lance_Param_4_sortIndex)]
        [DisplayName(Punishing_Draw_Lance_Param_4_displayName)]
        public virtual ushort Punishing_Draw_Lance_Param_4 {
            get => GetData<ushort>(324);
            set {
                if (GetData<ushort>(324) == value) return;
                SetData(324, value, nameof(Punishing_Draw_Lance_Param_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Lance_Param_4));
            }
        }

        public const string Punishing_Draw_Lance_Param_5_displayName = "Punishing Draw (Lance) Param 5";
        public const int Punishing_Draw_Lance_Param_5_sortIndex = 6000;
        [SortOrder(Punishing_Draw_Lance_Param_5_sortIndex)]
        [DisplayName(Punishing_Draw_Lance_Param_5_displayName)]
        public virtual ushort Punishing_Draw_Lance_Param_5 {
            get => GetData<ushort>(326);
            set {
                if (GetData<ushort>(326) == value) return;
                SetData(326, value, nameof(Punishing_Draw_Lance_Param_5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Lance_Param_5));
            }
        }

        public const string Punishing_Draw_Lance_Param_6_displayName = "Punishing Draw (Lance) Param 6";
        public const int Punishing_Draw_Lance_Param_6_sortIndex = 6050;
        [SortOrder(Punishing_Draw_Lance_Param_6_sortIndex)]
        [DisplayName(Punishing_Draw_Lance_Param_6_displayName)]
        public virtual ushort Punishing_Draw_Lance_Param_6 {
            get => GetData<ushort>(328);
            set {
                if (GetData<ushort>(328) == value) return;
                SetData(328, value, nameof(Punishing_Draw_Lance_Param_6));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Lance_Param_6));
            }
        }

        public const string __6100_displayName = "-------------------------------------------------------------------------------------------";
        public const int __6100_sortIndex = 6100;
        [SortOrder(__6100_sortIndex)]
        [DisplayName(__6100_displayName)]
        public virtual byte __6100 {
            get => GetData<byte>(3);
        }

        public const string Punishing_Draw_Gunlance_Attack_Power_displayName = "Punishing Draw (Gunlance) Attack Power";
        public const int Punishing_Draw_Gunlance_Attack_Power_sortIndex = 6150;
        [SortOrder(Punishing_Draw_Gunlance_Attack_Power_sortIndex)]
        [DisplayName(Punishing_Draw_Gunlance_Attack_Power_displayName)]
        public virtual ushort Punishing_Draw_Gunlance_Attack_Power {
            get => GetData<ushort>(330);
            set {
                if (GetData<ushort>(330) == value) return;
                SetData(330, value, nameof(Punishing_Draw_Gunlance_Attack_Power));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Gunlance_Attack_Power));
            }
        }

        public const string Punishing_Draw_Gunlance_Stun_displayName = "Punishing Draw (Gunlance) Stun";
        public const int Punishing_Draw_Gunlance_Stun_sortIndex = 6200;
        [SortOrder(Punishing_Draw_Gunlance_Stun_sortIndex)]
        [DisplayName(Punishing_Draw_Gunlance_Stun_displayName)]
        public virtual ushort Punishing_Draw_Gunlance_Stun {
            get => GetData<ushort>(332);
            set {
                if (GetData<ushort>(332) == value) return;
                SetData(332, value, nameof(Punishing_Draw_Gunlance_Stun));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Gunlance_Stun));
            }
        }

        public const string Punishing_Draw_Gunlance_Exhaust_displayName = "Punishing Draw (Gunlance) Exhaust";
        public const int Punishing_Draw_Gunlance_Exhaust_sortIndex = 6250;
        [SortOrder(Punishing_Draw_Gunlance_Exhaust_sortIndex)]
        [DisplayName(Punishing_Draw_Gunlance_Exhaust_displayName)]
        public virtual ushort Punishing_Draw_Gunlance_Exhaust {
            get => GetData<ushort>(334);
            set {
                if (GetData<ushort>(334) == value) return;
                SetData(334, value, nameof(Punishing_Draw_Gunlance_Exhaust));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Gunlance_Exhaust));
            }
        }

        public const string Punishing_Draw_Gunlance_Param_4_displayName = "Punishing Draw (Gunlance) Param 4";
        public const int Punishing_Draw_Gunlance_Param_4_sortIndex = 6300;
        [SortOrder(Punishing_Draw_Gunlance_Param_4_sortIndex)]
        [DisplayName(Punishing_Draw_Gunlance_Param_4_displayName)]
        public virtual ushort Punishing_Draw_Gunlance_Param_4 {
            get => GetData<ushort>(336);
            set {
                if (GetData<ushort>(336) == value) return;
                SetData(336, value, nameof(Punishing_Draw_Gunlance_Param_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Gunlance_Param_4));
            }
        }

        public const string Punishing_Draw_Gunlance_Param_5_displayName = "Punishing Draw (Gunlance) Param 5";
        public const int Punishing_Draw_Gunlance_Param_5_sortIndex = 6350;
        [SortOrder(Punishing_Draw_Gunlance_Param_5_sortIndex)]
        [DisplayName(Punishing_Draw_Gunlance_Param_5_displayName)]
        public virtual ushort Punishing_Draw_Gunlance_Param_5 {
            get => GetData<ushort>(338);
            set {
                if (GetData<ushort>(338) == value) return;
                SetData(338, value, nameof(Punishing_Draw_Gunlance_Param_5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Gunlance_Param_5));
            }
        }

        public const string Punishing_Draw_Gunlance_Param_6_displayName = "Punishing Draw (Gunlance) Param 6";
        public const int Punishing_Draw_Gunlance_Param_6_sortIndex = 6400;
        [SortOrder(Punishing_Draw_Gunlance_Param_6_sortIndex)]
        [DisplayName(Punishing_Draw_Gunlance_Param_6_displayName)]
        public virtual ushort Punishing_Draw_Gunlance_Param_6 {
            get => GetData<ushort>(340);
            set {
                if (GetData<ushort>(340) == value) return;
                SetData(340, value, nameof(Punishing_Draw_Gunlance_Param_6));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Gunlance_Param_6));
            }
        }

        public const string __6450_displayName = "-------------------------------------------------------------------------------------------";
        public const int __6450_sortIndex = 6450;
        [SortOrder(__6450_sortIndex)]
        [DisplayName(__6450_displayName)]
        public virtual byte __6450 {
            get => GetData<byte>(3);
        }

        public const string Punishing_Draw_Switch_Axe_Attack_Power_displayName = "Punishing Draw (Switch Axe) Attack Power";
        public const int Punishing_Draw_Switch_Axe_Attack_Power_sortIndex = 6500;
        [SortOrder(Punishing_Draw_Switch_Axe_Attack_Power_sortIndex)]
        [DisplayName(Punishing_Draw_Switch_Axe_Attack_Power_displayName)]
        public virtual ushort Punishing_Draw_Switch_Axe_Attack_Power {
            get => GetData<ushort>(342);
            set {
                if (GetData<ushort>(342) == value) return;
                SetData(342, value, nameof(Punishing_Draw_Switch_Axe_Attack_Power));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Switch_Axe_Attack_Power));
            }
        }

        public const string Punishing_Draw_Switch_Axe_Stun_displayName = "Punishing Draw (Switch Axe) Stun";
        public const int Punishing_Draw_Switch_Axe_Stun_sortIndex = 6550;
        [SortOrder(Punishing_Draw_Switch_Axe_Stun_sortIndex)]
        [DisplayName(Punishing_Draw_Switch_Axe_Stun_displayName)]
        public virtual ushort Punishing_Draw_Switch_Axe_Stun {
            get => GetData<ushort>(344);
            set {
                if (GetData<ushort>(344) == value) return;
                SetData(344, value, nameof(Punishing_Draw_Switch_Axe_Stun));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Switch_Axe_Stun));
            }
        }

        public const string Punishing_Draw_Switch_Axe_Exhaust_displayName = "Punishing Draw (Switch Axe) Exhaust";
        public const int Punishing_Draw_Switch_Axe_Exhaust_sortIndex = 6600;
        [SortOrder(Punishing_Draw_Switch_Axe_Exhaust_sortIndex)]
        [DisplayName(Punishing_Draw_Switch_Axe_Exhaust_displayName)]
        public virtual ushort Punishing_Draw_Switch_Axe_Exhaust {
            get => GetData<ushort>(346);
            set {
                if (GetData<ushort>(346) == value) return;
                SetData(346, value, nameof(Punishing_Draw_Switch_Axe_Exhaust));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Switch_Axe_Exhaust));
            }
        }

        public const string Punishing_Draw_Switch_Axe_Param_4_displayName = "Punishing Draw (Switch Axe) Param 4";
        public const int Punishing_Draw_Switch_Axe_Param_4_sortIndex = 6650;
        [SortOrder(Punishing_Draw_Switch_Axe_Param_4_sortIndex)]
        [DisplayName(Punishing_Draw_Switch_Axe_Param_4_displayName)]
        public virtual ushort Punishing_Draw_Switch_Axe_Param_4 {
            get => GetData<ushort>(348);
            set {
                if (GetData<ushort>(348) == value) return;
                SetData(348, value, nameof(Punishing_Draw_Switch_Axe_Param_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Switch_Axe_Param_4));
            }
        }

        public const string Punishing_Draw_Switch_Axe_Param_5_displayName = "Punishing Draw (Switch Axe) Param 5";
        public const int Punishing_Draw_Switch_Axe_Param_5_sortIndex = 6700;
        [SortOrder(Punishing_Draw_Switch_Axe_Param_5_sortIndex)]
        [DisplayName(Punishing_Draw_Switch_Axe_Param_5_displayName)]
        public virtual ushort Punishing_Draw_Switch_Axe_Param_5 {
            get => GetData<ushort>(350);
            set {
                if (GetData<ushort>(350) == value) return;
                SetData(350, value, nameof(Punishing_Draw_Switch_Axe_Param_5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Switch_Axe_Param_5));
            }
        }

        public const string Punishing_Draw_Switch_Axe_Param_6_displayName = "Punishing Draw (Switch Axe) Param 6";
        public const int Punishing_Draw_Switch_Axe_Param_6_sortIndex = 6750;
        [SortOrder(Punishing_Draw_Switch_Axe_Param_6_sortIndex)]
        [DisplayName(Punishing_Draw_Switch_Axe_Param_6_displayName)]
        public virtual ushort Punishing_Draw_Switch_Axe_Param_6 {
            get => GetData<ushort>(352);
            set {
                if (GetData<ushort>(352) == value) return;
                SetData(352, value, nameof(Punishing_Draw_Switch_Axe_Param_6));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Switch_Axe_Param_6));
            }
        }

        public const string __6800_displayName = "-------------------------------------------------------------------------------------------";
        public const int __6800_sortIndex = 6800;
        [SortOrder(__6800_sortIndex)]
        [DisplayName(__6800_displayName)]
        public virtual byte __6800 {
            get => GetData<byte>(3);
        }

        public const string Punishing_Draw_Charge_Blade_Attack_Power_displayName = "Punishing Draw (Charge Blade) Attack Power";
        public const int Punishing_Draw_Charge_Blade_Attack_Power_sortIndex = 6850;
        [SortOrder(Punishing_Draw_Charge_Blade_Attack_Power_sortIndex)]
        [DisplayName(Punishing_Draw_Charge_Blade_Attack_Power_displayName)]
        public virtual ushort Punishing_Draw_Charge_Blade_Attack_Power {
            get => GetData<ushort>(354);
            set {
                if (GetData<ushort>(354) == value) return;
                SetData(354, value, nameof(Punishing_Draw_Charge_Blade_Attack_Power));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Charge_Blade_Attack_Power));
            }
        }

        public const string Punishing_Draw_Charge_Blade_Stun_displayName = "Punishing Draw (Charge Blade) Stun";
        public const int Punishing_Draw_Charge_Blade_Stun_sortIndex = 6900;
        [SortOrder(Punishing_Draw_Charge_Blade_Stun_sortIndex)]
        [DisplayName(Punishing_Draw_Charge_Blade_Stun_displayName)]
        public virtual ushort Punishing_Draw_Charge_Blade_Stun {
            get => GetData<ushort>(356);
            set {
                if (GetData<ushort>(356) == value) return;
                SetData(356, value, nameof(Punishing_Draw_Charge_Blade_Stun));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Charge_Blade_Stun));
            }
        }

        public const string Punishing_Draw_Charge_Blade_Exhaust_displayName = "Punishing Draw (Charge Blade) Exhaust";
        public const int Punishing_Draw_Charge_Blade_Exhaust_sortIndex = 6950;
        [SortOrder(Punishing_Draw_Charge_Blade_Exhaust_sortIndex)]
        [DisplayName(Punishing_Draw_Charge_Blade_Exhaust_displayName)]
        public virtual ushort Punishing_Draw_Charge_Blade_Exhaust {
            get => GetData<ushort>(358);
            set {
                if (GetData<ushort>(358) == value) return;
                SetData(358, value, nameof(Punishing_Draw_Charge_Blade_Exhaust));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Charge_Blade_Exhaust));
            }
        }

        public const string Punishing_Draw_Charge_Blade_Param_4_displayName = "Punishing Draw (Charge Blade) Param 4";
        public const int Punishing_Draw_Charge_Blade_Param_4_sortIndex = 7000;
        [SortOrder(Punishing_Draw_Charge_Blade_Param_4_sortIndex)]
        [DisplayName(Punishing_Draw_Charge_Blade_Param_4_displayName)]
        public virtual ushort Punishing_Draw_Charge_Blade_Param_4 {
            get => GetData<ushort>(360);
            set {
                if (GetData<ushort>(360) == value) return;
                SetData(360, value, nameof(Punishing_Draw_Charge_Blade_Param_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Charge_Blade_Param_4));
            }
        }

        public const string Punishing_Draw_Charge_Blade_Param_5_displayName = "Punishing Draw (Charge Blade) Param 5";
        public const int Punishing_Draw_Charge_Blade_Param_5_sortIndex = 7050;
        [SortOrder(Punishing_Draw_Charge_Blade_Param_5_sortIndex)]
        [DisplayName(Punishing_Draw_Charge_Blade_Param_5_displayName)]
        public virtual ushort Punishing_Draw_Charge_Blade_Param_5 {
            get => GetData<ushort>(362);
            set {
                if (GetData<ushort>(362) == value) return;
                SetData(362, value, nameof(Punishing_Draw_Charge_Blade_Param_5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Charge_Blade_Param_5));
            }
        }

        public const string Punishing_Draw_Charge_Blade_Param_6_displayName = "Punishing Draw (Charge Blade) Param 6";
        public const int Punishing_Draw_Charge_Blade_Param_6_sortIndex = 7100;
        [SortOrder(Punishing_Draw_Charge_Blade_Param_6_sortIndex)]
        [DisplayName(Punishing_Draw_Charge_Blade_Param_6_displayName)]
        public virtual ushort Punishing_Draw_Charge_Blade_Param_6 {
            get => GetData<ushort>(364);
            set {
                if (GetData<ushort>(364) == value) return;
                SetData(364, value, nameof(Punishing_Draw_Charge_Blade_Param_6));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Charge_Blade_Param_6));
            }
        }

        public const string __7150_displayName = "-------------------------------------------------------------------------------------------";
        public const int __7150_sortIndex = 7150;
        [SortOrder(__7150_sortIndex)]
        [DisplayName(__7150_displayName)]
        public virtual byte __7150 {
            get => GetData<byte>(3);
        }

        public const string Punishing_Draw_Insect_Glaive_Attack_Power_displayName = "Punishing Draw (Insect Glaive) Attack Power";
        public const int Punishing_Draw_Insect_Glaive_Attack_Power_sortIndex = 7200;
        [SortOrder(Punishing_Draw_Insect_Glaive_Attack_Power_sortIndex)]
        [DisplayName(Punishing_Draw_Insect_Glaive_Attack_Power_displayName)]
        public virtual ushort Punishing_Draw_Insect_Glaive_Attack_Power {
            get => GetData<ushort>(366);
            set {
                if (GetData<ushort>(366) == value) return;
                SetData(366, value, nameof(Punishing_Draw_Insect_Glaive_Attack_Power));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Insect_Glaive_Attack_Power));
            }
        }

        public const string Punishing_Draw_Insect_Glaive_Stun_displayName = "Punishing Draw (Insect Glaive) Stun";
        public const int Punishing_Draw_Insect_Glaive_Stun_sortIndex = 7250;
        [SortOrder(Punishing_Draw_Insect_Glaive_Stun_sortIndex)]
        [DisplayName(Punishing_Draw_Insect_Glaive_Stun_displayName)]
        public virtual ushort Punishing_Draw_Insect_Glaive_Stun {
            get => GetData<ushort>(368);
            set {
                if (GetData<ushort>(368) == value) return;
                SetData(368, value, nameof(Punishing_Draw_Insect_Glaive_Stun));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Insect_Glaive_Stun));
            }
        }

        public const string Punishing_Draw_Insect_Glaive_Exhaust_displayName = "Punishing Draw (Insect Glaive) Exhaust";
        public const int Punishing_Draw_Insect_Glaive_Exhaust_sortIndex = 7300;
        [SortOrder(Punishing_Draw_Insect_Glaive_Exhaust_sortIndex)]
        [DisplayName(Punishing_Draw_Insect_Glaive_Exhaust_displayName)]
        public virtual ushort Punishing_Draw_Insect_Glaive_Exhaust {
            get => GetData<ushort>(370);
            set {
                if (GetData<ushort>(370) == value) return;
                SetData(370, value, nameof(Punishing_Draw_Insect_Glaive_Exhaust));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Insect_Glaive_Exhaust));
            }
        }

        public const string Punishing_Draw_Insect_Glaive_Param_4_displayName = "Punishing Draw (Insect Glaive) Param 4";
        public const int Punishing_Draw_Insect_Glaive_Param_4_sortIndex = 7350;
        [SortOrder(Punishing_Draw_Insect_Glaive_Param_4_sortIndex)]
        [DisplayName(Punishing_Draw_Insect_Glaive_Param_4_displayName)]
        public virtual ushort Punishing_Draw_Insect_Glaive_Param_4 {
            get => GetData<ushort>(372);
            set {
                if (GetData<ushort>(372) == value) return;
                SetData(372, value, nameof(Punishing_Draw_Insect_Glaive_Param_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Insect_Glaive_Param_4));
            }
        }

        public const string Punishing_Draw_Insect_Glaive_Param_5_displayName = "Punishing Draw (Insect Glaive) Param 5";
        public const int Punishing_Draw_Insect_Glaive_Param_5_sortIndex = 7400;
        [SortOrder(Punishing_Draw_Insect_Glaive_Param_5_sortIndex)]
        [DisplayName(Punishing_Draw_Insect_Glaive_Param_5_displayName)]
        public virtual ushort Punishing_Draw_Insect_Glaive_Param_5 {
            get => GetData<ushort>(374);
            set {
                if (GetData<ushort>(374) == value) return;
                SetData(374, value, nameof(Punishing_Draw_Insect_Glaive_Param_5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Insect_Glaive_Param_5));
            }
        }

        public const string Punishing_Draw_Insect_Glaive_Param_6_displayName = "Punishing Draw (Insect Glaive) Param 6";
        public const int Punishing_Draw_Insect_Glaive_Param_6_sortIndex = 7450;
        [SortOrder(Punishing_Draw_Insect_Glaive_Param_6_sortIndex)]
        [DisplayName(Punishing_Draw_Insect_Glaive_Param_6_displayName)]
        public virtual ushort Punishing_Draw_Insect_Glaive_Param_6 {
            get => GetData<ushort>(376);
            set {
                if (GetData<ushort>(376) == value) return;
                SetData(376, value, nameof(Punishing_Draw_Insect_Glaive_Param_6));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Insect_Glaive_Param_6));
            }
        }

        public const string __7500_displayName = "-------------------------------------------------------------------------------------------";
        public const int __7500_sortIndex = 7500;
        [SortOrder(__7500_sortIndex)]
        [DisplayName(__7500_displayName)]
        public virtual byte __7500 {
            get => GetData<byte>(3);
        }

        public const string Punishing_Draw_Bow_Attack_Power_displayName = "Punishing Draw (Bow) Attack Power";
        public const int Punishing_Draw_Bow_Attack_Power_sortIndex = 7550;
        [SortOrder(Punishing_Draw_Bow_Attack_Power_sortIndex)]
        [DisplayName(Punishing_Draw_Bow_Attack_Power_displayName)]
        public virtual ushort Punishing_Draw_Bow_Attack_Power {
            get => GetData<ushort>(378);
            set {
                if (GetData<ushort>(378) == value) return;
                SetData(378, value, nameof(Punishing_Draw_Bow_Attack_Power));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Bow_Attack_Power));
            }
        }

        public const string Punishing_Draw_Bow_Stun_displayName = "Punishing Draw (Bow) Stun";
        public const int Punishing_Draw_Bow_Stun_sortIndex = 7600;
        [SortOrder(Punishing_Draw_Bow_Stun_sortIndex)]
        [DisplayName(Punishing_Draw_Bow_Stun_displayName)]
        public virtual ushort Punishing_Draw_Bow_Stun {
            get => GetData<ushort>(380);
            set {
                if (GetData<ushort>(380) == value) return;
                SetData(380, value, nameof(Punishing_Draw_Bow_Stun));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Bow_Stun));
            }
        }

        public const string Punishing_Draw_Bow_Exhaust_displayName = "Punishing Draw (Bow) Exhaust";
        public const int Punishing_Draw_Bow_Exhaust_sortIndex = 7650;
        [SortOrder(Punishing_Draw_Bow_Exhaust_sortIndex)]
        [DisplayName(Punishing_Draw_Bow_Exhaust_displayName)]
        public virtual ushort Punishing_Draw_Bow_Exhaust {
            get => GetData<ushort>(382);
            set {
                if (GetData<ushort>(382) == value) return;
                SetData(382, value, nameof(Punishing_Draw_Bow_Exhaust));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Bow_Exhaust));
            }
        }

        public const string Punishing_Draw_Bow_Param_4_displayName = "Punishing Draw (Bow) Param 4";
        public const int Punishing_Draw_Bow_Param_4_sortIndex = 7700;
        [SortOrder(Punishing_Draw_Bow_Param_4_sortIndex)]
        [DisplayName(Punishing_Draw_Bow_Param_4_displayName)]
        public virtual ushort Punishing_Draw_Bow_Param_4 {
            get => GetData<ushort>(384);
            set {
                if (GetData<ushort>(384) == value) return;
                SetData(384, value, nameof(Punishing_Draw_Bow_Param_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Bow_Param_4));
            }
        }

        public const string Punishing_Draw_Bow_Param_5_displayName = "Punishing Draw (Bow) Param 5";
        public const int Punishing_Draw_Bow_Param_5_sortIndex = 7750;
        [SortOrder(Punishing_Draw_Bow_Param_5_sortIndex)]
        [DisplayName(Punishing_Draw_Bow_Param_5_displayName)]
        public virtual ushort Punishing_Draw_Bow_Param_5 {
            get => GetData<ushort>(386);
            set {
                if (GetData<ushort>(386) == value) return;
                SetData(386, value, nameof(Punishing_Draw_Bow_Param_5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Bow_Param_5));
            }
        }

        public const string Punishing_Draw_Bow_Param_6_displayName = "Punishing Draw (Bow) Param 6";
        public const int Punishing_Draw_Bow_Param_6_sortIndex = 7800;
        [SortOrder(Punishing_Draw_Bow_Param_6_sortIndex)]
        [DisplayName(Punishing_Draw_Bow_Param_6_displayName)]
        public virtual ushort Punishing_Draw_Bow_Param_6 {
            get => GetData<ushort>(388);
            set {
                if (GetData<ushort>(388) == value) return;
                SetData(388, value, nameof(Punishing_Draw_Bow_Param_6));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_Bow_Param_6));
            }
        }

        public const string __7850_displayName = "-------------------------------------------------------------------------------------------";
        public const int __7850_sortIndex = 7850;
        [SortOrder(__7850_sortIndex)]
        [DisplayName(__7850_displayName)]
        public virtual byte __7850 {
            get => GetData<byte>(3);
        }

        public const string Punishing_Draw_HBG_Attack_Power_displayName = "Punishing Draw (HBG) Attack Power";
        public const int Punishing_Draw_HBG_Attack_Power_sortIndex = 7900;
        [SortOrder(Punishing_Draw_HBG_Attack_Power_sortIndex)]
        [DisplayName(Punishing_Draw_HBG_Attack_Power_displayName)]
        public virtual ushort Punishing_Draw_HBG_Attack_Power {
            get => GetData<ushort>(390);
            set {
                if (GetData<ushort>(390) == value) return;
                SetData(390, value, nameof(Punishing_Draw_HBG_Attack_Power));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_HBG_Attack_Power));
            }
        }

        public const string Punishing_Draw_HBG_Stun_displayName = "Punishing Draw (HBG) Stun";
        public const int Punishing_Draw_HBG_Stun_sortIndex = 7950;
        [SortOrder(Punishing_Draw_HBG_Stun_sortIndex)]
        [DisplayName(Punishing_Draw_HBG_Stun_displayName)]
        public virtual ushort Punishing_Draw_HBG_Stun {
            get => GetData<ushort>(392);
            set {
                if (GetData<ushort>(392) == value) return;
                SetData(392, value, nameof(Punishing_Draw_HBG_Stun));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_HBG_Stun));
            }
        }

        public const string Punishing_Draw_HBG_Exhaust_displayName = "Punishing Draw (HBG) Exhaust";
        public const int Punishing_Draw_HBG_Exhaust_sortIndex = 8000;
        [SortOrder(Punishing_Draw_HBG_Exhaust_sortIndex)]
        [DisplayName(Punishing_Draw_HBG_Exhaust_displayName)]
        public virtual ushort Punishing_Draw_HBG_Exhaust {
            get => GetData<ushort>(394);
            set {
                if (GetData<ushort>(394) == value) return;
                SetData(394, value, nameof(Punishing_Draw_HBG_Exhaust));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_HBG_Exhaust));
            }
        }

        public const string Punishing_Draw_HBG_Param_4_displayName = "Punishing Draw (HBG) Param 4";
        public const int Punishing_Draw_HBG_Param_4_sortIndex = 8050;
        [SortOrder(Punishing_Draw_HBG_Param_4_sortIndex)]
        [DisplayName(Punishing_Draw_HBG_Param_4_displayName)]
        public virtual ushort Punishing_Draw_HBG_Param_4 {
            get => GetData<ushort>(396);
            set {
                if (GetData<ushort>(396) == value) return;
                SetData(396, value, nameof(Punishing_Draw_HBG_Param_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_HBG_Param_4));
            }
        }

        public const string Punishing_Draw_HBG_Param_5_displayName = "Punishing Draw (HBG) Param 5";
        public const int Punishing_Draw_HBG_Param_5_sortIndex = 8100;
        [SortOrder(Punishing_Draw_HBG_Param_5_sortIndex)]
        [DisplayName(Punishing_Draw_HBG_Param_5_displayName)]
        public virtual ushort Punishing_Draw_HBG_Param_5 {
            get => GetData<ushort>(398);
            set {
                if (GetData<ushort>(398) == value) return;
                SetData(398, value, nameof(Punishing_Draw_HBG_Param_5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_HBG_Param_5));
            }
        }

        public const string Punishing_Draw_HBG_Param_6_displayName = "Punishing Draw (HBG) Param 6";
        public const int Punishing_Draw_HBG_Param_6_sortIndex = 8150;
        [SortOrder(Punishing_Draw_HBG_Param_6_sortIndex)]
        [DisplayName(Punishing_Draw_HBG_Param_6_displayName)]
        public virtual ushort Punishing_Draw_HBG_Param_6 {
            get => GetData<ushort>(400);
            set {
                if (GetData<ushort>(400) == value) return;
                SetData(400, value, nameof(Punishing_Draw_HBG_Param_6));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_HBG_Param_6));
            }
        }

        public const string __8200_displayName = "-------------------------------------------------------------------------------------------";
        public const int __8200_sortIndex = 8200;
        [SortOrder(__8200_sortIndex)]
        [DisplayName(__8200_displayName)]
        public virtual byte __8200 {
            get => GetData<byte>(3);
        }

        public const string Punishing_Draw_LBG_Attack_Power_displayName = "Punishing Draw (LBG) Attack Power";
        public const int Punishing_Draw_LBG_Attack_Power_sortIndex = 8250;
        [SortOrder(Punishing_Draw_LBG_Attack_Power_sortIndex)]
        [DisplayName(Punishing_Draw_LBG_Attack_Power_displayName)]
        public virtual ushort Punishing_Draw_LBG_Attack_Power {
            get => GetData<ushort>(402);
            set {
                if (GetData<ushort>(402) == value) return;
                SetData(402, value, nameof(Punishing_Draw_LBG_Attack_Power));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_LBG_Attack_Power));
            }
        }

        public const string Punishing_Draw_LBG_Stun_displayName = "Punishing Draw (LBG) Stun";
        public const int Punishing_Draw_LBG_Stun_sortIndex = 8300;
        [SortOrder(Punishing_Draw_LBG_Stun_sortIndex)]
        [DisplayName(Punishing_Draw_LBG_Stun_displayName)]
        public virtual ushort Punishing_Draw_LBG_Stun {
            get => GetData<ushort>(404);
            set {
                if (GetData<ushort>(404) == value) return;
                SetData(404, value, nameof(Punishing_Draw_LBG_Stun));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_LBG_Stun));
            }
        }

        public const string Punishing_Draw_LBG_Exhaust_displayName = "Punishing Draw (LBG) Exhaust";
        public const int Punishing_Draw_LBG_Exhaust_sortIndex = 8350;
        [SortOrder(Punishing_Draw_LBG_Exhaust_sortIndex)]
        [DisplayName(Punishing_Draw_LBG_Exhaust_displayName)]
        public virtual ushort Punishing_Draw_LBG_Exhaust {
            get => GetData<ushort>(406);
            set {
                if (GetData<ushort>(406) == value) return;
                SetData(406, value, nameof(Punishing_Draw_LBG_Exhaust));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_LBG_Exhaust));
            }
        }

        public const string Punishing_Draw_LBG_Param_4_displayName = "Punishing Draw (LBG) Param 4";
        public const int Punishing_Draw_LBG_Param_4_sortIndex = 8400;
        [SortOrder(Punishing_Draw_LBG_Param_4_sortIndex)]
        [DisplayName(Punishing_Draw_LBG_Param_4_displayName)]
        public virtual ushort Punishing_Draw_LBG_Param_4 {
            get => GetData<ushort>(408);
            set {
                if (GetData<ushort>(408) == value) return;
                SetData(408, value, nameof(Punishing_Draw_LBG_Param_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_LBG_Param_4));
            }
        }

        public const string Punishing_Draw_LBG_Param_5_displayName = "Punishing Draw (LBG) Param 5";
        public const int Punishing_Draw_LBG_Param_5_sortIndex = 8450;
        [SortOrder(Punishing_Draw_LBG_Param_5_sortIndex)]
        [DisplayName(Punishing_Draw_LBG_Param_5_displayName)]
        public virtual ushort Punishing_Draw_LBG_Param_5 {
            get => GetData<ushort>(410);
            set {
                if (GetData<ushort>(410) == value) return;
                SetData(410, value, nameof(Punishing_Draw_LBG_Param_5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_LBG_Param_5));
            }
        }

        public const string Punishing_Draw_LBG_Param_6_displayName = "Punishing Draw (LBG) Param 6";
        public const int Punishing_Draw_LBG_Param_6_sortIndex = 8500;
        [SortOrder(Punishing_Draw_LBG_Param_6_sortIndex)]
        [DisplayName(Punishing_Draw_LBG_Param_6_displayName)]
        public virtual ushort Punishing_Draw_LBG_Param_6 {
            get => GetData<ushort>(412);
            set {
                if (GetData<ushort>(412) == value) return;
                SetData(412, value, nameof(Punishing_Draw_LBG_Param_6));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Punishing_Draw_LBG_Param_6));
            }
        }

        public const string __8550_displayName = "-------------------------------------------------------------------------------------------";
        public const int __8550_sortIndex = 8550;
        [SortOrder(__8550_sortIndex)]
        [DisplayName(__8550_displayName)]
        public virtual byte __8550 {
            get => GetData<byte>(3);
        }

        public const string Razor_Sharp_Sharpness_No_Reduce__displayName = "Razor Sharp: Sharpness No Reduce %";
        public const int Razor_Sharp_Sharpness_No_Reduce__sortIndex = 8600;
        [SortOrder(Razor_Sharp_Sharpness_No_Reduce__sortIndex)]
        [DisplayName(Razor_Sharp_Sharpness_No_Reduce__displayName)]
        public virtual byte Razor_Sharp_Sharpness_No_Reduce_ {
            get => GetData<byte>(414);
            set {
                if (GetData<byte>(414) == value) return;
                SetData(414, value, nameof(Razor_Sharp_Sharpness_No_Reduce_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Razor_Sharp_Sharpness_No_Reduce_));
            }
        }

        public const string Razor_Sharp_Gunlance_Shot_Sub_Value_displayName = "Razor Sharp: Gunlance Shot Sub Value";
        public const int Razor_Sharp_Gunlance_Shot_Sub_Value_sortIndex = 8650;
        [SortOrder(Razor_Sharp_Gunlance_Shot_Sub_Value_sortIndex)]
        [DisplayName(Razor_Sharp_Gunlance_Shot_Sub_Value_displayName)]
        public virtual byte Razor_Sharp_Gunlance_Shot_Sub_Value {
            get => GetData<byte>(415);
            set {
                if (GetData<byte>(415) == value) return;
                SetData(415, value, nameof(Razor_Sharp_Gunlance_Shot_Sub_Value));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Razor_Sharp_Gunlance_Shot_Sub_Value));
            }
        }

        public const string Razor_Sharp_Gunlance_Shot_No_Reduce__displayName = "Razor Sharp: Gunlance Shot No Reduce %";
        public const int Razor_Sharp_Gunlance_Shot_No_Reduce__sortIndex = 8700;
        [SortOrder(Razor_Sharp_Gunlance_Shot_No_Reduce__sortIndex)]
        [DisplayName(Razor_Sharp_Gunlance_Shot_No_Reduce__displayName)]
        public virtual byte Razor_Sharp_Gunlance_Shot_No_Reduce_ {
            get => GetData<byte>(416);
            set {
                if (GetData<byte>(416) == value) return;
                SetData(416, value, nameof(Razor_Sharp_Gunlance_Shot_No_Reduce_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Razor_Sharp_Gunlance_Shot_No_Reduce_));
            }
        }

        public const string Razor_Sharp_Gun_Ammo_No_Reduce__displayName = "Razor Sharp: Gun Ammo No Reduce %";
        public const int Razor_Sharp_Gun_Ammo_No_Reduce__sortIndex = 8750;
        [SortOrder(Razor_Sharp_Gun_Ammo_No_Reduce__sortIndex)]
        [DisplayName(Razor_Sharp_Gun_Ammo_No_Reduce__displayName)]
        public virtual byte Razor_Sharp_Gun_Ammo_No_Reduce_ {
            get => GetData<byte>(417);
            set {
                if (GetData<byte>(417) == value) return;
                SetData(417, value, nameof(Razor_Sharp_Gun_Ammo_No_Reduce_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Razor_Sharp_Gun_Ammo_No_Reduce_));
            }
        }

        public const string Razor_Sharp_Bow_Coating_No_Reduce__displayName = "Razor Sharp: Bow Coating No Reduce %";
        public const int Razor_Sharp_Bow_Coating_No_Reduce__sortIndex = 8800;
        [SortOrder(Razor_Sharp_Bow_Coating_No_Reduce__sortIndex)]
        [DisplayName(Razor_Sharp_Bow_Coating_No_Reduce__displayName)]
        public virtual byte Razor_Sharp_Bow_Coating_No_Reduce_ {
            get => GetData<byte>(418);
            set {
                if (GetData<byte>(418) == value) return;
                SetData(418, value, nameof(Razor_Sharp_Bow_Coating_No_Reduce_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Razor_Sharp_Bow_Coating_No_Reduce_));
            }
        }

        public const string Razor_Sharp_IB_Unk_displayName = "Razor Sharp: IB Unk";
        public const int Razor_Sharp_IB_Unk_sortIndex = 8850;
        [SortOrder(Razor_Sharp_IB_Unk_sortIndex)]
        [DisplayName(Razor_Sharp_IB_Unk_displayName)]
        public virtual byte Razor_Sharp_IB_Unk {
            get => GetData<byte>(419);
            set {
                if (GetData<byte>(419) == value) return;
                SetData(419, value, nameof(Razor_Sharp_IB_Unk));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Razor_Sharp_IB_Unk));
            }
        }

        public const string __8900_displayName = "-------------------------------------------------------------------------------------------";
        public const int __8900_sortIndex = 8900;
        [SortOrder(__8900_sortIndex)]
        [DisplayName(__8900_displayName)]
        public virtual byte __8900 {
            get => GetData<byte>(3);
        }

        public const string True_Razor_Sharp_Sharpness_No_Reduce__displayName = "True Razor Sharp: Sharpness No Reduce %";
        public const int True_Razor_Sharp_Sharpness_No_Reduce__sortIndex = 8950;
        [SortOrder(True_Razor_Sharp_Sharpness_No_Reduce__sortIndex)]
        [DisplayName(True_Razor_Sharp_Sharpness_No_Reduce__displayName)]
        public virtual byte True_Razor_Sharp_Sharpness_No_Reduce_ {
            get => GetData<byte>(420);
            set {
                if (GetData<byte>(420) == value) return;
                SetData(420, value, nameof(True_Razor_Sharp_Sharpness_No_Reduce_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(True_Razor_Sharp_Sharpness_No_Reduce_));
            }
        }

        public const string True_Razor_Sharp_Gunlance_Shot_Sub_Value_displayName = "True Razor Sharp: Gunlance Shot Sub Value";
        public const int True_Razor_Sharp_Gunlance_Shot_Sub_Value_sortIndex = 9000;
        [SortOrder(True_Razor_Sharp_Gunlance_Shot_Sub_Value_sortIndex)]
        [DisplayName(True_Razor_Sharp_Gunlance_Shot_Sub_Value_displayName)]
        public virtual byte True_Razor_Sharp_Gunlance_Shot_Sub_Value {
            get => GetData<byte>(421);
            set {
                if (GetData<byte>(421) == value) return;
                SetData(421, value, nameof(True_Razor_Sharp_Gunlance_Shot_Sub_Value));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(True_Razor_Sharp_Gunlance_Shot_Sub_Value));
            }
        }

        public const string True_Razor_Sharp_Gunlance_Shot_No_Reduce__displayName = "True Razor Sharp: Gunlance Shot No Reduce %";
        public const int True_Razor_Sharp_Gunlance_Shot_No_Reduce__sortIndex = 9050;
        [SortOrder(True_Razor_Sharp_Gunlance_Shot_No_Reduce__sortIndex)]
        [DisplayName(True_Razor_Sharp_Gunlance_Shot_No_Reduce__displayName)]
        public virtual byte True_Razor_Sharp_Gunlance_Shot_No_Reduce_ {
            get => GetData<byte>(422);
            set {
                if (GetData<byte>(422) == value) return;
                SetData(422, value, nameof(True_Razor_Sharp_Gunlance_Shot_No_Reduce_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(True_Razor_Sharp_Gunlance_Shot_No_Reduce_));
            }
        }

        public const string True_Razor_Sharp_Gun_Ammo_No_Reduce__displayName = "True Razor Sharp: Gun Ammo No Reduce %";
        public const int True_Razor_Sharp_Gun_Ammo_No_Reduce__sortIndex = 9100;
        [SortOrder(True_Razor_Sharp_Gun_Ammo_No_Reduce__sortIndex)]
        [DisplayName(True_Razor_Sharp_Gun_Ammo_No_Reduce__displayName)]
        public virtual byte True_Razor_Sharp_Gun_Ammo_No_Reduce_ {
            get => GetData<byte>(423);
            set {
                if (GetData<byte>(423) == value) return;
                SetData(423, value, nameof(True_Razor_Sharp_Gun_Ammo_No_Reduce_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(True_Razor_Sharp_Gun_Ammo_No_Reduce_));
            }
        }

        public const string True_Razor_Sharp_Bow_Coating_No_Reduce__displayName = "True Razor Sharp: Bow Coating No Reduce %";
        public const int True_Razor_Sharp_Bow_Coating_No_Reduce__sortIndex = 9150;
        [SortOrder(True_Razor_Sharp_Bow_Coating_No_Reduce__sortIndex)]
        [DisplayName(True_Razor_Sharp_Bow_Coating_No_Reduce__displayName)]
        public virtual byte True_Razor_Sharp_Bow_Coating_No_Reduce_ {
            get => GetData<byte>(424);
            set {
                if (GetData<byte>(424) == value) return;
                SetData(424, value, nameof(True_Razor_Sharp_Bow_Coating_No_Reduce_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(True_Razor_Sharp_Bow_Coating_No_Reduce_));
            }
        }

        public const string True_Razor_Sharp_IB_Unk_displayName = "True Razor Sharp: IB Unk";
        public const int True_Razor_Sharp_IB_Unk_sortIndex = 9200;
        [SortOrder(True_Razor_Sharp_IB_Unk_sortIndex)]
        [DisplayName(True_Razor_Sharp_IB_Unk_displayName)]
        public virtual byte True_Razor_Sharp_IB_Unk {
            get => GetData<byte>(425);
            set {
                if (GetData<byte>(425) == value) return;
                SetData(425, value, nameof(True_Razor_Sharp_IB_Unk));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(True_Razor_Sharp_IB_Unk));
            }
        }

        public const string __9250_displayName = "-------------------------------------------------------------------------------------------";
        public const int __9250_sortIndex = 9250;
        [SortOrder(__9250_sortIndex)]
        [DisplayName(__9250_displayName)]
        public virtual byte __9250 {
            get => GetData<byte>(3);
        }

        public const string Minds_Eye_Ballistics_Gun_Critical_Begin_Wide_Rate_displayName = "Minds Eye / Ballistics: Gun Critical Begin Wide Rate";
        public const int Minds_Eye_Ballistics_Gun_Critical_Begin_Wide_Rate_sortIndex = 9300;
        [SortOrder(Minds_Eye_Ballistics_Gun_Critical_Begin_Wide_Rate_sortIndex)]
        [DisplayName(Minds_Eye_Ballistics_Gun_Critical_Begin_Wide_Rate_displayName)]
        public virtual float Minds_Eye_Ballistics_Gun_Critical_Begin_Wide_Rate {
            get => GetData<float>(426);
            set {
                if (GetData<float>(426) == value) return;
                SetData(426, value, nameof(Minds_Eye_Ballistics_Gun_Critical_Begin_Wide_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Minds_Eye_Ballistics_Gun_Critical_Begin_Wide_Rate));
            }
        }

        public const string Minds_Eye_Ballistics_Gun_Critical_End_Wide_Rate_displayName = "Minds Eye / Ballistics: Gun Critical End Wide Rate";
        public const int Minds_Eye_Ballistics_Gun_Critical_End_Wide_Rate_sortIndex = 9350;
        [SortOrder(Minds_Eye_Ballistics_Gun_Critical_End_Wide_Rate_sortIndex)]
        [DisplayName(Minds_Eye_Ballistics_Gun_Critical_End_Wide_Rate_displayName)]
        public virtual float Minds_Eye_Ballistics_Gun_Critical_End_Wide_Rate {
            get => GetData<float>(430);
            set {
                if (GetData<float>(430) == value) return;
                SetData(430, value, nameof(Minds_Eye_Ballistics_Gun_Critical_End_Wide_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Minds_Eye_Ballistics_Gun_Critical_End_Wide_Rate));
            }
        }

        public const string Minds_Eye_Ballistics_Bow_Critical_Begin_Wide_Rate_displayName = "Minds Eye / Ballistics: Bow Critical Begin Wide Rate";
        public const int Minds_Eye_Ballistics_Bow_Critical_Begin_Wide_Rate_sortIndex = 9400;
        [SortOrder(Minds_Eye_Ballistics_Bow_Critical_Begin_Wide_Rate_sortIndex)]
        [DisplayName(Minds_Eye_Ballistics_Bow_Critical_Begin_Wide_Rate_displayName)]
        public virtual float Minds_Eye_Ballistics_Bow_Critical_Begin_Wide_Rate {
            get => GetData<float>(434);
            set {
                if (GetData<float>(434) == value) return;
                SetData(434, value, nameof(Minds_Eye_Ballistics_Bow_Critical_Begin_Wide_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Minds_Eye_Ballistics_Bow_Critical_Begin_Wide_Rate));
            }
        }

        public const string Minds_Eye_Ballistics_Bow_Critical_End_Wide_Rate_displayName = "Minds Eye / Ballistics: Bow Critical End Wide Rate";
        public const int Minds_Eye_Ballistics_Bow_Critical_End_Wide_Rate_sortIndex = 9450;
        [SortOrder(Minds_Eye_Ballistics_Bow_Critical_End_Wide_Rate_sortIndex)]
        [DisplayName(Minds_Eye_Ballistics_Bow_Critical_End_Wide_Rate_displayName)]
        public virtual float Minds_Eye_Ballistics_Bow_Critical_End_Wide_Rate {
            get => GetData<float>(438);
            set {
                if (GetData<float>(438) == value) return;
                SetData(438, value, nameof(Minds_Eye_Ballistics_Bow_Critical_End_Wide_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Minds_Eye_Ballistics_Bow_Critical_End_Wide_Rate));
            }
        }

        public const string __9500_displayName = "-------------------------------------------------------------------------------------------";
        public const int __9500_sortIndex = 9500;
        [SortOrder(__9500_sortIndex)]
        [DisplayName(__9500_displayName)]
        public virtual byte __9500 {
            get => GetData<byte>(3);
        }

        public const string Critical_Element_Great_Sword_Rate_displayName = "Critical Element: (Great Sword) Rate";
        public const int Critical_Element_Great_Sword_Rate_sortIndex = 9550;
        [SortOrder(Critical_Element_Great_Sword_Rate_sortIndex)]
        [DisplayName(Critical_Element_Great_Sword_Rate_displayName)]
        public virtual float Critical_Element_Great_Sword_Rate {
            get => GetData<float>(442);
            set {
                if (GetData<float>(442) == value) return;
                SetData(442, value, nameof(Critical_Element_Great_Sword_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Critical_Element_Great_Sword_Rate));
            }
        }

        public const string Critical_Element_Sword_Shield_Rate_displayName = "Critical Element: (Sword & Shield) Rate";
        public const int Critical_Element_Sword_Shield_Rate_sortIndex = 9600;
        [SortOrder(Critical_Element_Sword_Shield_Rate_sortIndex)]
        [DisplayName(Critical_Element_Sword_Shield_Rate_displayName)]
        public virtual float Critical_Element_Sword_Shield_Rate {
            get => GetData<float>(446);
            set {
                if (GetData<float>(446) == value) return;
                SetData(446, value, nameof(Critical_Element_Sword_Shield_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Critical_Element_Sword_Shield_Rate));
            }
        }

        public const string Critical_Element_Dual_Blades_Rate_displayName = "Critical Element: (Dual Blades) Rate";
        public const int Critical_Element_Dual_Blades_Rate_sortIndex = 9650;
        [SortOrder(Critical_Element_Dual_Blades_Rate_sortIndex)]
        [DisplayName(Critical_Element_Dual_Blades_Rate_displayName)]
        public virtual float Critical_Element_Dual_Blades_Rate {
            get => GetData<float>(450);
            set {
                if (GetData<float>(450) == value) return;
                SetData(450, value, nameof(Critical_Element_Dual_Blades_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Critical_Element_Dual_Blades_Rate));
            }
        }

        public const string Critical_Element_Long_Sword_Rate_displayName = "Critical Element: (Long Sword) Rate";
        public const int Critical_Element_Long_Sword_Rate_sortIndex = 9700;
        [SortOrder(Critical_Element_Long_Sword_Rate_sortIndex)]
        [DisplayName(Critical_Element_Long_Sword_Rate_displayName)]
        public virtual float Critical_Element_Long_Sword_Rate {
            get => GetData<float>(454);
            set {
                if (GetData<float>(454) == value) return;
                SetData(454, value, nameof(Critical_Element_Long_Sword_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Critical_Element_Long_Sword_Rate));
            }
        }

        public const string Critical_Element_Hammer_Rate_displayName = "Critical Element: (Hammer) Rate";
        public const int Critical_Element_Hammer_Rate_sortIndex = 9750;
        [SortOrder(Critical_Element_Hammer_Rate_sortIndex)]
        [DisplayName(Critical_Element_Hammer_Rate_displayName)]
        public virtual float Critical_Element_Hammer_Rate {
            get => GetData<float>(458);
            set {
                if (GetData<float>(458) == value) return;
                SetData(458, value, nameof(Critical_Element_Hammer_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Critical_Element_Hammer_Rate));
            }
        }

        public const string Critical_Element_Hunting_Horn_Rate_displayName = "Critical Element: (Hunting Horn) Rate";
        public const int Critical_Element_Hunting_Horn_Rate_sortIndex = 9800;
        [SortOrder(Critical_Element_Hunting_Horn_Rate_sortIndex)]
        [DisplayName(Critical_Element_Hunting_Horn_Rate_displayName)]
        public virtual float Critical_Element_Hunting_Horn_Rate {
            get => GetData<float>(462);
            set {
                if (GetData<float>(462) == value) return;
                SetData(462, value, nameof(Critical_Element_Hunting_Horn_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Critical_Element_Hunting_Horn_Rate));
            }
        }

        public const string Critical_Element_Lance_Rate_displayName = "Critical Element: (Lance) Rate";
        public const int Critical_Element_Lance_Rate_sortIndex = 9850;
        [SortOrder(Critical_Element_Lance_Rate_sortIndex)]
        [DisplayName(Critical_Element_Lance_Rate_displayName)]
        public virtual float Critical_Element_Lance_Rate {
            get => GetData<float>(466);
            set {
                if (GetData<float>(466) == value) return;
                SetData(466, value, nameof(Critical_Element_Lance_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Critical_Element_Lance_Rate));
            }
        }

        public const string Critical_Element_Gunlance_Rate_displayName = "Critical Element: (Gunlance) Rate";
        public const int Critical_Element_Gunlance_Rate_sortIndex = 9900;
        [SortOrder(Critical_Element_Gunlance_Rate_sortIndex)]
        [DisplayName(Critical_Element_Gunlance_Rate_displayName)]
        public virtual float Critical_Element_Gunlance_Rate {
            get => GetData<float>(470);
            set {
                if (GetData<float>(470) == value) return;
                SetData(470, value, nameof(Critical_Element_Gunlance_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Critical_Element_Gunlance_Rate));
            }
        }

        public const string Critical_Element_Switch_Axe_Rate_displayName = "Critical Element: (Switch Axe) Rate";
        public const int Critical_Element_Switch_Axe_Rate_sortIndex = 9950;
        [SortOrder(Critical_Element_Switch_Axe_Rate_sortIndex)]
        [DisplayName(Critical_Element_Switch_Axe_Rate_displayName)]
        public virtual float Critical_Element_Switch_Axe_Rate {
            get => GetData<float>(474);
            set {
                if (GetData<float>(474) == value) return;
                SetData(474, value, nameof(Critical_Element_Switch_Axe_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Critical_Element_Switch_Axe_Rate));
            }
        }

        public const string Critical_Element_Charge_Blade_Rate_displayName = "Critical Element: (Charge Blade) Rate";
        public const int Critical_Element_Charge_Blade_Rate_sortIndex = 10000;
        [SortOrder(Critical_Element_Charge_Blade_Rate_sortIndex)]
        [DisplayName(Critical_Element_Charge_Blade_Rate_displayName)]
        public virtual float Critical_Element_Charge_Blade_Rate {
            get => GetData<float>(478);
            set {
                if (GetData<float>(478) == value) return;
                SetData(478, value, nameof(Critical_Element_Charge_Blade_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Critical_Element_Charge_Blade_Rate));
            }
        }

        public const string Critical_Element_Insect_Glaive_Rate_displayName = "Critical Element: (Insect Glaive) Rate";
        public const int Critical_Element_Insect_Glaive_Rate_sortIndex = 10050;
        [SortOrder(Critical_Element_Insect_Glaive_Rate_sortIndex)]
        [DisplayName(Critical_Element_Insect_Glaive_Rate_displayName)]
        public virtual float Critical_Element_Insect_Glaive_Rate {
            get => GetData<float>(482);
            set {
                if (GetData<float>(482) == value) return;
                SetData(482, value, nameof(Critical_Element_Insect_Glaive_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Critical_Element_Insect_Glaive_Rate));
            }
        }

        public const string Critical_Element_Bow_Rate_displayName = "Critical Element: (Bow) Rate";
        public const int Critical_Element_Bow_Rate_sortIndex = 10100;
        [SortOrder(Critical_Element_Bow_Rate_sortIndex)]
        [DisplayName(Critical_Element_Bow_Rate_displayName)]
        public virtual float Critical_Element_Bow_Rate {
            get => GetData<float>(486);
            set {
                if (GetData<float>(486) == value) return;
                SetData(486, value, nameof(Critical_Element_Bow_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Critical_Element_Bow_Rate));
            }
        }

        public const string Critical_Element_HBG_Rate_displayName = "Critical Element: (HBG) Rate";
        public const int Critical_Element_HBG_Rate_sortIndex = 10150;
        [SortOrder(Critical_Element_HBG_Rate_sortIndex)]
        [DisplayName(Critical_Element_HBG_Rate_displayName)]
        public virtual float Critical_Element_HBG_Rate {
            get => GetData<float>(490);
            set {
                if (GetData<float>(490) == value) return;
                SetData(490, value, nameof(Critical_Element_HBG_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Critical_Element_HBG_Rate));
            }
        }

        public const string Critical_Element_LBG_Rate_displayName = "Critical Element: (LBG) Rate";
        public const int Critical_Element_LBG_Rate_sortIndex = 10200;
        [SortOrder(Critical_Element_LBG_Rate_sortIndex)]
        [DisplayName(Critical_Element_LBG_Rate_displayName)]
        public virtual float Critical_Element_LBG_Rate {
            get => GetData<float>(494);
            set {
                if (GetData<float>(494) == value) return;
                SetData(494, value, nameof(Critical_Element_LBG_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Critical_Element_LBG_Rate));
            }
        }

        public const string Critical_Element_Dragon_Seal_Rate_displayName = "Critical Element: Dragon Seal Rate";
        public const int Critical_Element_Dragon_Seal_Rate_sortIndex = 10250;
        [SortOrder(Critical_Element_Dragon_Seal_Rate_sortIndex)]
        [DisplayName(Critical_Element_Dragon_Seal_Rate_displayName)]
        public virtual float Critical_Element_Dragon_Seal_Rate {
            get => GetData<float>(498);
            set {
                if (GetData<float>(498) == value) return;
                SetData(498, value, nameof(Critical_Element_Dragon_Seal_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Critical_Element_Dragon_Seal_Rate));
            }
        }

        public const string __10300_displayName = "-------------------------------------------------------------------------------------------";
        public const int __10300_sortIndex = 10300;
        [SortOrder(__10300_sortIndex)]
        [DisplayName(__10300_displayName)]
        public virtual byte __10300 {
            get => GetData<byte>(3);
        }

        public const string True_Critical_Element_Great_Sword_Rate_displayName = "True Critical Element: (Great Sword) Rate";
        public const int True_Critical_Element_Great_Sword_Rate_sortIndex = 10350;
        [SortOrder(True_Critical_Element_Great_Sword_Rate_sortIndex)]
        [DisplayName(True_Critical_Element_Great_Sword_Rate_displayName)]
        public virtual float True_Critical_Element_Great_Sword_Rate {
            get => GetData<float>(502);
            set {
                if (GetData<float>(502) == value) return;
                SetData(502, value, nameof(True_Critical_Element_Great_Sword_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(True_Critical_Element_Great_Sword_Rate));
            }
        }

        public const string True_Critical_Element_Sword_Shield_Rate_displayName = "True Critical Element: (Sword & Shield) Rate";
        public const int True_Critical_Element_Sword_Shield_Rate_sortIndex = 10400;
        [SortOrder(True_Critical_Element_Sword_Shield_Rate_sortIndex)]
        [DisplayName(True_Critical_Element_Sword_Shield_Rate_displayName)]
        public virtual float True_Critical_Element_Sword_Shield_Rate {
            get => GetData<float>(506);
            set {
                if (GetData<float>(506) == value) return;
                SetData(506, value, nameof(True_Critical_Element_Sword_Shield_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(True_Critical_Element_Sword_Shield_Rate));
            }
        }

        public const string True_Critical_Element_Dual_Blades_Rate_displayName = "True Critical Element: (Dual Blades) Rate";
        public const int True_Critical_Element_Dual_Blades_Rate_sortIndex = 10450;
        [SortOrder(True_Critical_Element_Dual_Blades_Rate_sortIndex)]
        [DisplayName(True_Critical_Element_Dual_Blades_Rate_displayName)]
        public virtual float True_Critical_Element_Dual_Blades_Rate {
            get => GetData<float>(510);
            set {
                if (GetData<float>(510) == value) return;
                SetData(510, value, nameof(True_Critical_Element_Dual_Blades_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(True_Critical_Element_Dual_Blades_Rate));
            }
        }

        public const string True_Critical_Element_Long_Sword_Rate_displayName = "True Critical Element: (Long Sword) Rate";
        public const int True_Critical_Element_Long_Sword_Rate_sortIndex = 10500;
        [SortOrder(True_Critical_Element_Long_Sword_Rate_sortIndex)]
        [DisplayName(True_Critical_Element_Long_Sword_Rate_displayName)]
        public virtual float True_Critical_Element_Long_Sword_Rate {
            get => GetData<float>(514);
            set {
                if (GetData<float>(514) == value) return;
                SetData(514, value, nameof(True_Critical_Element_Long_Sword_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(True_Critical_Element_Long_Sword_Rate));
            }
        }

        public const string True_Critical_Element_Hammer_Rate_displayName = "True Critical Element: (Hammer) Rate";
        public const int True_Critical_Element_Hammer_Rate_sortIndex = 10550;
        [SortOrder(True_Critical_Element_Hammer_Rate_sortIndex)]
        [DisplayName(True_Critical_Element_Hammer_Rate_displayName)]
        public virtual float True_Critical_Element_Hammer_Rate {
            get => GetData<float>(518);
            set {
                if (GetData<float>(518) == value) return;
                SetData(518, value, nameof(True_Critical_Element_Hammer_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(True_Critical_Element_Hammer_Rate));
            }
        }

        public const string True_Critical_Element_Hunting_Horn_Rate_displayName = "True Critical Element: (Hunting Horn) Rate";
        public const int True_Critical_Element_Hunting_Horn_Rate_sortIndex = 10600;
        [SortOrder(True_Critical_Element_Hunting_Horn_Rate_sortIndex)]
        [DisplayName(True_Critical_Element_Hunting_Horn_Rate_displayName)]
        public virtual float True_Critical_Element_Hunting_Horn_Rate {
            get => GetData<float>(522);
            set {
                if (GetData<float>(522) == value) return;
                SetData(522, value, nameof(True_Critical_Element_Hunting_Horn_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(True_Critical_Element_Hunting_Horn_Rate));
            }
        }

        public const string True_Critical_Element_Lance_Rate_displayName = "True Critical Element: (Lance) Rate";
        public const int True_Critical_Element_Lance_Rate_sortIndex = 10650;
        [SortOrder(True_Critical_Element_Lance_Rate_sortIndex)]
        [DisplayName(True_Critical_Element_Lance_Rate_displayName)]
        public virtual float True_Critical_Element_Lance_Rate {
            get => GetData<float>(526);
            set {
                if (GetData<float>(526) == value) return;
                SetData(526, value, nameof(True_Critical_Element_Lance_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(True_Critical_Element_Lance_Rate));
            }
        }

        public const string True_Critical_Element_Gunlance_Rate_displayName = "True Critical Element: (Gunlance) Rate";
        public const int True_Critical_Element_Gunlance_Rate_sortIndex = 10700;
        [SortOrder(True_Critical_Element_Gunlance_Rate_sortIndex)]
        [DisplayName(True_Critical_Element_Gunlance_Rate_displayName)]
        public virtual float True_Critical_Element_Gunlance_Rate {
            get => GetData<float>(530);
            set {
                if (GetData<float>(530) == value) return;
                SetData(530, value, nameof(True_Critical_Element_Gunlance_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(True_Critical_Element_Gunlance_Rate));
            }
        }

        public const string True_Critical_Element_Switch_Axe_Rate_displayName = "True Critical Element: (Switch Axe) Rate";
        public const int True_Critical_Element_Switch_Axe_Rate_sortIndex = 10750;
        [SortOrder(True_Critical_Element_Switch_Axe_Rate_sortIndex)]
        [DisplayName(True_Critical_Element_Switch_Axe_Rate_displayName)]
        public virtual float True_Critical_Element_Switch_Axe_Rate {
            get => GetData<float>(534);
            set {
                if (GetData<float>(534) == value) return;
                SetData(534, value, nameof(True_Critical_Element_Switch_Axe_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(True_Critical_Element_Switch_Axe_Rate));
            }
        }

        public const string True_Critical_Element_Charge_Blade_Rate_displayName = "True Critical Element: (Charge Blade) Rate";
        public const int True_Critical_Element_Charge_Blade_Rate_sortIndex = 10800;
        [SortOrder(True_Critical_Element_Charge_Blade_Rate_sortIndex)]
        [DisplayName(True_Critical_Element_Charge_Blade_Rate_displayName)]
        public virtual float True_Critical_Element_Charge_Blade_Rate {
            get => GetData<float>(538);
            set {
                if (GetData<float>(538) == value) return;
                SetData(538, value, nameof(True_Critical_Element_Charge_Blade_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(True_Critical_Element_Charge_Blade_Rate));
            }
        }

        public const string True_Critical_Element_Insect_Glaive_Rate_displayName = "True Critical Element: (Insect Glaive) Rate";
        public const int True_Critical_Element_Insect_Glaive_Rate_sortIndex = 10850;
        [SortOrder(True_Critical_Element_Insect_Glaive_Rate_sortIndex)]
        [DisplayName(True_Critical_Element_Insect_Glaive_Rate_displayName)]
        public virtual float True_Critical_Element_Insect_Glaive_Rate {
            get => GetData<float>(542);
            set {
                if (GetData<float>(542) == value) return;
                SetData(542, value, nameof(True_Critical_Element_Insect_Glaive_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(True_Critical_Element_Insect_Glaive_Rate));
            }
        }

        public const string True_Critical_Element_Bow_Rate_displayName = "True Critical Element: (Bow) Rate";
        public const int True_Critical_Element_Bow_Rate_sortIndex = 10900;
        [SortOrder(True_Critical_Element_Bow_Rate_sortIndex)]
        [DisplayName(True_Critical_Element_Bow_Rate_displayName)]
        public virtual float True_Critical_Element_Bow_Rate {
            get => GetData<float>(546);
            set {
                if (GetData<float>(546) == value) return;
                SetData(546, value, nameof(True_Critical_Element_Bow_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(True_Critical_Element_Bow_Rate));
            }
        }

        public const string True_Critical_Element_HBG_Rate_displayName = "True Critical Element: (HBG) Rate";
        public const int True_Critical_Element_HBG_Rate_sortIndex = 10950;
        [SortOrder(True_Critical_Element_HBG_Rate_sortIndex)]
        [DisplayName(True_Critical_Element_HBG_Rate_displayName)]
        public virtual float True_Critical_Element_HBG_Rate {
            get => GetData<float>(550);
            set {
                if (GetData<float>(550) == value) return;
                SetData(550, value, nameof(True_Critical_Element_HBG_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(True_Critical_Element_HBG_Rate));
            }
        }

        public const string True_Critical_Element_LBG_Rate_displayName = "True Critical Element: (LBG) Rate";
        public const int True_Critical_Element_LBG_Rate_sortIndex = 11000;
        [SortOrder(True_Critical_Element_LBG_Rate_sortIndex)]
        [DisplayName(True_Critical_Element_LBG_Rate_displayName)]
        public virtual float True_Critical_Element_LBG_Rate {
            get => GetData<float>(554);
            set {
                if (GetData<float>(554) == value) return;
                SetData(554, value, nameof(True_Critical_Element_LBG_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(True_Critical_Element_LBG_Rate));
            }
        }

        public const string True_Critical_Element_Dragon_Seal_Rate_displayName = "True Critical Element: Dragon Seal Rate";
        public const int True_Critical_Element_Dragon_Seal_Rate_sortIndex = 11050;
        [SortOrder(True_Critical_Element_Dragon_Seal_Rate_sortIndex)]
        [DisplayName(True_Critical_Element_Dragon_Seal_Rate_displayName)]
        public virtual float True_Critical_Element_Dragon_Seal_Rate {
            get => GetData<float>(558);
            set {
                if (GetData<float>(558) == value) return;
                SetData(558, value, nameof(True_Critical_Element_Dragon_Seal_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(True_Critical_Element_Dragon_Seal_Rate));
            }
        }

        public const string __11100_displayName = "-------------------------------------------------------------------------------------------";
        public const int __11100_sortIndex = 11100;
        [SortOrder(__11100_sortIndex)]
        [DisplayName(__11100_displayName)]
        public virtual byte __11100 {
            get => GetData<byte>(3);
        }

        public const string Critical_Condition_Great_Sword_Rate_displayName = "Critical Condition: (Great Sword) Rate";
        public const int Critical_Condition_Great_Sword_Rate_sortIndex = 11150;
        [SortOrder(Critical_Condition_Great_Sword_Rate_sortIndex)]
        [DisplayName(Critical_Condition_Great_Sword_Rate_displayName)]
        public virtual float Critical_Condition_Great_Sword_Rate {
            get => GetData<float>(562);
            set {
                if (GetData<float>(562) == value) return;
                SetData(562, value, nameof(Critical_Condition_Great_Sword_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Critical_Condition_Great_Sword_Rate));
            }
        }

        public const string Critical_Condition_Sword_Shield_Rate_displayName = "Critical Condition: (Sword & Shield) Rate";
        public const int Critical_Condition_Sword_Shield_Rate_sortIndex = 11200;
        [SortOrder(Critical_Condition_Sword_Shield_Rate_sortIndex)]
        [DisplayName(Critical_Condition_Sword_Shield_Rate_displayName)]
        public virtual float Critical_Condition_Sword_Shield_Rate {
            get => GetData<float>(566);
            set {
                if (GetData<float>(566) == value) return;
                SetData(566, value, nameof(Critical_Condition_Sword_Shield_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Critical_Condition_Sword_Shield_Rate));
            }
        }

        public const string Critical_Condition_Dual_Blades_Rate_displayName = "Critical Condition: (Dual Blades) Rate";
        public const int Critical_Condition_Dual_Blades_Rate_sortIndex = 11250;
        [SortOrder(Critical_Condition_Dual_Blades_Rate_sortIndex)]
        [DisplayName(Critical_Condition_Dual_Blades_Rate_displayName)]
        public virtual float Critical_Condition_Dual_Blades_Rate {
            get => GetData<float>(570);
            set {
                if (GetData<float>(570) == value) return;
                SetData(570, value, nameof(Critical_Condition_Dual_Blades_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Critical_Condition_Dual_Blades_Rate));
            }
        }

        public const string Critical_Condition_Long_Sword_Rate_displayName = "Critical Condition: (Long Sword) Rate";
        public const int Critical_Condition_Long_Sword_Rate_sortIndex = 11300;
        [SortOrder(Critical_Condition_Long_Sword_Rate_sortIndex)]
        [DisplayName(Critical_Condition_Long_Sword_Rate_displayName)]
        public virtual float Critical_Condition_Long_Sword_Rate {
            get => GetData<float>(574);
            set {
                if (GetData<float>(574) == value) return;
                SetData(574, value, nameof(Critical_Condition_Long_Sword_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Critical_Condition_Long_Sword_Rate));
            }
        }

        public const string Critical_Condition_Hammer_Rate_displayName = "Critical Condition: (Hammer) Rate";
        public const int Critical_Condition_Hammer_Rate_sortIndex = 11350;
        [SortOrder(Critical_Condition_Hammer_Rate_sortIndex)]
        [DisplayName(Critical_Condition_Hammer_Rate_displayName)]
        public virtual float Critical_Condition_Hammer_Rate {
            get => GetData<float>(578);
            set {
                if (GetData<float>(578) == value) return;
                SetData(578, value, nameof(Critical_Condition_Hammer_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Critical_Condition_Hammer_Rate));
            }
        }

        public const string Critical_Condition_Hunting_Horn_Rate_displayName = "Critical Condition: (Hunting Horn) Rate";
        public const int Critical_Condition_Hunting_Horn_Rate_sortIndex = 11400;
        [SortOrder(Critical_Condition_Hunting_Horn_Rate_sortIndex)]
        [DisplayName(Critical_Condition_Hunting_Horn_Rate_displayName)]
        public virtual float Critical_Condition_Hunting_Horn_Rate {
            get => GetData<float>(582);
            set {
                if (GetData<float>(582) == value) return;
                SetData(582, value, nameof(Critical_Condition_Hunting_Horn_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Critical_Condition_Hunting_Horn_Rate));
            }
        }

        public const string Critical_Condition_Lance_Rate_displayName = "Critical Condition: (Lance) Rate";
        public const int Critical_Condition_Lance_Rate_sortIndex = 11450;
        [SortOrder(Critical_Condition_Lance_Rate_sortIndex)]
        [DisplayName(Critical_Condition_Lance_Rate_displayName)]
        public virtual float Critical_Condition_Lance_Rate {
            get => GetData<float>(586);
            set {
                if (GetData<float>(586) == value) return;
                SetData(586, value, nameof(Critical_Condition_Lance_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Critical_Condition_Lance_Rate));
            }
        }

        public const string Critical_Condition_Gunlance_Rate_displayName = "Critical Condition: (Gunlance) Rate";
        public const int Critical_Condition_Gunlance_Rate_sortIndex = 11500;
        [SortOrder(Critical_Condition_Gunlance_Rate_sortIndex)]
        [DisplayName(Critical_Condition_Gunlance_Rate_displayName)]
        public virtual float Critical_Condition_Gunlance_Rate {
            get => GetData<float>(590);
            set {
                if (GetData<float>(590) == value) return;
                SetData(590, value, nameof(Critical_Condition_Gunlance_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Critical_Condition_Gunlance_Rate));
            }
        }

        public const string Critical_Condition_Switch_Axe_Rate_displayName = "Critical Condition: (Switch Axe) Rate";
        public const int Critical_Condition_Switch_Axe_Rate_sortIndex = 11550;
        [SortOrder(Critical_Condition_Switch_Axe_Rate_sortIndex)]
        [DisplayName(Critical_Condition_Switch_Axe_Rate_displayName)]
        public virtual float Critical_Condition_Switch_Axe_Rate {
            get => GetData<float>(594);
            set {
                if (GetData<float>(594) == value) return;
                SetData(594, value, nameof(Critical_Condition_Switch_Axe_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Critical_Condition_Switch_Axe_Rate));
            }
        }

        public const string Critical_Condition_Charge_Blade_Rate_displayName = "Critical Condition: (Charge Blade) Rate";
        public const int Critical_Condition_Charge_Blade_Rate_sortIndex = 11600;
        [SortOrder(Critical_Condition_Charge_Blade_Rate_sortIndex)]
        [DisplayName(Critical_Condition_Charge_Blade_Rate_displayName)]
        public virtual float Critical_Condition_Charge_Blade_Rate {
            get => GetData<float>(598);
            set {
                if (GetData<float>(598) == value) return;
                SetData(598, value, nameof(Critical_Condition_Charge_Blade_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Critical_Condition_Charge_Blade_Rate));
            }
        }

        public const string Critical_Condition_Insect_Glaive_Rate_displayName = "Critical Condition: (Insect Glaive) Rate";
        public const int Critical_Condition_Insect_Glaive_Rate_sortIndex = 11650;
        [SortOrder(Critical_Condition_Insect_Glaive_Rate_sortIndex)]
        [DisplayName(Critical_Condition_Insect_Glaive_Rate_displayName)]
        public virtual float Critical_Condition_Insect_Glaive_Rate {
            get => GetData<float>(602);
            set {
                if (GetData<float>(602) == value) return;
                SetData(602, value, nameof(Critical_Condition_Insect_Glaive_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Critical_Condition_Insect_Glaive_Rate));
            }
        }

        public const string Critical_Condition_Bow_Rate_displayName = "Critical Condition: (Bow) Rate";
        public const int Critical_Condition_Bow_Rate_sortIndex = 11700;
        [SortOrder(Critical_Condition_Bow_Rate_sortIndex)]
        [DisplayName(Critical_Condition_Bow_Rate_displayName)]
        public virtual float Critical_Condition_Bow_Rate {
            get => GetData<float>(606);
            set {
                if (GetData<float>(606) == value) return;
                SetData(606, value, nameof(Critical_Condition_Bow_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Critical_Condition_Bow_Rate));
            }
        }

        public const string Critical_Condition_HBG_Rate_displayName = "Critical Condition: (HBG) Rate";
        public const int Critical_Condition_HBG_Rate_sortIndex = 11750;
        [SortOrder(Critical_Condition_HBG_Rate_sortIndex)]
        [DisplayName(Critical_Condition_HBG_Rate_displayName)]
        public virtual float Critical_Condition_HBG_Rate {
            get => GetData<float>(610);
            set {
                if (GetData<float>(610) == value) return;
                SetData(610, value, nameof(Critical_Condition_HBG_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Critical_Condition_HBG_Rate));
            }
        }

        public const string Critical_Condition_LBG_Rate_displayName = "Critical Condition: (LBG) Rate";
        public const int Critical_Condition_LBG_Rate_sortIndex = 11800;
        [SortOrder(Critical_Condition_LBG_Rate_sortIndex)]
        [DisplayName(Critical_Condition_LBG_Rate_displayName)]
        public virtual float Critical_Condition_LBG_Rate {
            get => GetData<float>(614);
            set {
                if (GetData<float>(614) == value) return;
                SetData(614, value, nameof(Critical_Condition_LBG_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Critical_Condition_LBG_Rate));
            }
        }

        public const string __11850_displayName = "-------------------------------------------------------------------------------------------";
        public const int __11850_sortIndex = 11850;
        [SortOrder(__11850_sortIndex)]
        [DisplayName(__11850_displayName)]
        public virtual byte __11850 {
            get => GetData<byte>(3);
        }

        public const string True_Critical_Condition_Great_Sword_Rate_displayName = "True Critical Condition: (Great Sword) Rate";
        public const int True_Critical_Condition_Great_Sword_Rate_sortIndex = 11900;
        [SortOrder(True_Critical_Condition_Great_Sword_Rate_sortIndex)]
        [DisplayName(True_Critical_Condition_Great_Sword_Rate_displayName)]
        public virtual float True_Critical_Condition_Great_Sword_Rate {
            get => GetData<float>(618);
            set {
                if (GetData<float>(618) == value) return;
                SetData(618, value, nameof(True_Critical_Condition_Great_Sword_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(True_Critical_Condition_Great_Sword_Rate));
            }
        }

        public const string True_Critical_Condition_Sword_Shield_Rate_displayName = "True Critical Condition: (Sword & Shield) Rate";
        public const int True_Critical_Condition_Sword_Shield_Rate_sortIndex = 11950;
        [SortOrder(True_Critical_Condition_Sword_Shield_Rate_sortIndex)]
        [DisplayName(True_Critical_Condition_Sword_Shield_Rate_displayName)]
        public virtual float True_Critical_Condition_Sword_Shield_Rate {
            get => GetData<float>(622);
            set {
                if (GetData<float>(622) == value) return;
                SetData(622, value, nameof(True_Critical_Condition_Sword_Shield_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(True_Critical_Condition_Sword_Shield_Rate));
            }
        }

        public const string True_Critical_Condition_Dual_Blades_Rate_displayName = "True Critical Condition: (Dual Blades) Rate";
        public const int True_Critical_Condition_Dual_Blades_Rate_sortIndex = 12000;
        [SortOrder(True_Critical_Condition_Dual_Blades_Rate_sortIndex)]
        [DisplayName(True_Critical_Condition_Dual_Blades_Rate_displayName)]
        public virtual float True_Critical_Condition_Dual_Blades_Rate {
            get => GetData<float>(626);
            set {
                if (GetData<float>(626) == value) return;
                SetData(626, value, nameof(True_Critical_Condition_Dual_Blades_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(True_Critical_Condition_Dual_Blades_Rate));
            }
        }

        public const string True_Critical_Condition_Long_Sword_Rate_displayName = "True Critical Condition: (Long Sword) Rate";
        public const int True_Critical_Condition_Long_Sword_Rate_sortIndex = 12050;
        [SortOrder(True_Critical_Condition_Long_Sword_Rate_sortIndex)]
        [DisplayName(True_Critical_Condition_Long_Sword_Rate_displayName)]
        public virtual float True_Critical_Condition_Long_Sword_Rate {
            get => GetData<float>(630);
            set {
                if (GetData<float>(630) == value) return;
                SetData(630, value, nameof(True_Critical_Condition_Long_Sword_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(True_Critical_Condition_Long_Sword_Rate));
            }
        }

        public const string True_Critical_Condition_Hammer_Rate_displayName = "True Critical Condition: (Hammer) Rate";
        public const int True_Critical_Condition_Hammer_Rate_sortIndex = 12100;
        [SortOrder(True_Critical_Condition_Hammer_Rate_sortIndex)]
        [DisplayName(True_Critical_Condition_Hammer_Rate_displayName)]
        public virtual float True_Critical_Condition_Hammer_Rate {
            get => GetData<float>(634);
            set {
                if (GetData<float>(634) == value) return;
                SetData(634, value, nameof(True_Critical_Condition_Hammer_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(True_Critical_Condition_Hammer_Rate));
            }
        }

        public const string True_Critical_Condition_Hunting_Horn_Rate_displayName = "True Critical Condition: (Hunting Horn) Rate";
        public const int True_Critical_Condition_Hunting_Horn_Rate_sortIndex = 12150;
        [SortOrder(True_Critical_Condition_Hunting_Horn_Rate_sortIndex)]
        [DisplayName(True_Critical_Condition_Hunting_Horn_Rate_displayName)]
        public virtual float True_Critical_Condition_Hunting_Horn_Rate {
            get => GetData<float>(638);
            set {
                if (GetData<float>(638) == value) return;
                SetData(638, value, nameof(True_Critical_Condition_Hunting_Horn_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(True_Critical_Condition_Hunting_Horn_Rate));
            }
        }

        public const string True_Critical_Condition_Lance_Rate_displayName = "True Critical Condition: (Lance) Rate";
        public const int True_Critical_Condition_Lance_Rate_sortIndex = 12200;
        [SortOrder(True_Critical_Condition_Lance_Rate_sortIndex)]
        [DisplayName(True_Critical_Condition_Lance_Rate_displayName)]
        public virtual float True_Critical_Condition_Lance_Rate {
            get => GetData<float>(642);
            set {
                if (GetData<float>(642) == value) return;
                SetData(642, value, nameof(True_Critical_Condition_Lance_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(True_Critical_Condition_Lance_Rate));
            }
        }

        public const string True_Critical_Condition_Gunlance_Rate_displayName = "True Critical Condition: (Gunlance) Rate";
        public const int True_Critical_Condition_Gunlance_Rate_sortIndex = 12250;
        [SortOrder(True_Critical_Condition_Gunlance_Rate_sortIndex)]
        [DisplayName(True_Critical_Condition_Gunlance_Rate_displayName)]
        public virtual float True_Critical_Condition_Gunlance_Rate {
            get => GetData<float>(646);
            set {
                if (GetData<float>(646) == value) return;
                SetData(646, value, nameof(True_Critical_Condition_Gunlance_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(True_Critical_Condition_Gunlance_Rate));
            }
        }

        public const string True_Critical_Condition_Switch_Axe_Rate_displayName = "True Critical Condition: (Switch Axe) Rate";
        public const int True_Critical_Condition_Switch_Axe_Rate_sortIndex = 12300;
        [SortOrder(True_Critical_Condition_Switch_Axe_Rate_sortIndex)]
        [DisplayName(True_Critical_Condition_Switch_Axe_Rate_displayName)]
        public virtual float True_Critical_Condition_Switch_Axe_Rate {
            get => GetData<float>(650);
            set {
                if (GetData<float>(650) == value) return;
                SetData(650, value, nameof(True_Critical_Condition_Switch_Axe_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(True_Critical_Condition_Switch_Axe_Rate));
            }
        }

        public const string True_Critical_Condition_Charge_Blade_Rate_displayName = "True Critical Condition: (Charge Blade) Rate";
        public const int True_Critical_Condition_Charge_Blade_Rate_sortIndex = 12350;
        [SortOrder(True_Critical_Condition_Charge_Blade_Rate_sortIndex)]
        [DisplayName(True_Critical_Condition_Charge_Blade_Rate_displayName)]
        public virtual float True_Critical_Condition_Charge_Blade_Rate {
            get => GetData<float>(654);
            set {
                if (GetData<float>(654) == value) return;
                SetData(654, value, nameof(True_Critical_Condition_Charge_Blade_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(True_Critical_Condition_Charge_Blade_Rate));
            }
        }

        public const string True_Critical_Condition_Insect_Glaive_Rate_displayName = "True Critical Condition: (Insect Glaive) Rate";
        public const int True_Critical_Condition_Insect_Glaive_Rate_sortIndex = 12400;
        [SortOrder(True_Critical_Condition_Insect_Glaive_Rate_sortIndex)]
        [DisplayName(True_Critical_Condition_Insect_Glaive_Rate_displayName)]
        public virtual float True_Critical_Condition_Insect_Glaive_Rate {
            get => GetData<float>(658);
            set {
                if (GetData<float>(658) == value) return;
                SetData(658, value, nameof(True_Critical_Condition_Insect_Glaive_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(True_Critical_Condition_Insect_Glaive_Rate));
            }
        }

        public const string True_Critical_Condition_Bow_Rate_displayName = "True Critical Condition: (Bow) Rate";
        public const int True_Critical_Condition_Bow_Rate_sortIndex = 12450;
        [SortOrder(True_Critical_Condition_Bow_Rate_sortIndex)]
        [DisplayName(True_Critical_Condition_Bow_Rate_displayName)]
        public virtual float True_Critical_Condition_Bow_Rate {
            get => GetData<float>(662);
            set {
                if (GetData<float>(662) == value) return;
                SetData(662, value, nameof(True_Critical_Condition_Bow_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(True_Critical_Condition_Bow_Rate));
            }
        }

        public const string True_Critical_Condition_HBG_Rate_displayName = "True Critical Condition: (HBG) Rate";
        public const int True_Critical_Condition_HBG_Rate_sortIndex = 12500;
        [SortOrder(True_Critical_Condition_HBG_Rate_sortIndex)]
        [DisplayName(True_Critical_Condition_HBG_Rate_displayName)]
        public virtual float True_Critical_Condition_HBG_Rate {
            get => GetData<float>(666);
            set {
                if (GetData<float>(666) == value) return;
                SetData(666, value, nameof(True_Critical_Condition_HBG_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(True_Critical_Condition_HBG_Rate));
            }
        }

        public const string True_Critical_Condition_LBG_Rate_displayName = "True Critical Condition: (LBG) Rate";
        public const int True_Critical_Condition_LBG_Rate_sortIndex = 12550;
        [SortOrder(True_Critical_Condition_LBG_Rate_sortIndex)]
        [DisplayName(True_Critical_Condition_LBG_Rate_displayName)]
        public virtual float True_Critical_Condition_LBG_Rate {
            get => GetData<float>(670);
            set {
                if (GetData<float>(670) == value) return;
                SetData(670, value, nameof(True_Critical_Condition_LBG_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(True_Critical_Condition_LBG_Rate));
            }
        }

        public const string __12600_displayName = "-------------------------------------------------------------------------------------------";
        public const int __12600_sortIndex = 12600;
        [SortOrder(__12600_sortIndex)]
        [DisplayName(__12600_displayName)]
        public virtual byte __12600 {
            get => GetData<byte>(3);
        }

        public const string Bludgeoner_Red_Sharpness_Attack_Bonus_displayName = "Bludgeoner: Red Sharpness Attack Bonus";
        public const int Bludgeoner_Red_Sharpness_Attack_Bonus_sortIndex = 12650;
        [SortOrder(Bludgeoner_Red_Sharpness_Attack_Bonus_sortIndex)]
        [DisplayName(Bludgeoner_Red_Sharpness_Attack_Bonus_displayName)]
        public virtual ushort Bludgeoner_Red_Sharpness_Attack_Bonus {
            get => GetData<ushort>(674);
            set {
                if (GetData<ushort>(674) == value) return;
                SetData(674, value, nameof(Bludgeoner_Red_Sharpness_Attack_Bonus));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Bludgeoner_Red_Sharpness_Attack_Bonus));
            }
        }

        public const string Bludgeoner_Orange_Sharpness_Attack_Bonus_displayName = "Bludgeoner: Orange Sharpness Attack Bonus";
        public const int Bludgeoner_Orange_Sharpness_Attack_Bonus_sortIndex = 12700;
        [SortOrder(Bludgeoner_Orange_Sharpness_Attack_Bonus_sortIndex)]
        [DisplayName(Bludgeoner_Orange_Sharpness_Attack_Bonus_displayName)]
        public virtual ushort Bludgeoner_Orange_Sharpness_Attack_Bonus {
            get => GetData<ushort>(676);
            set {
                if (GetData<ushort>(676) == value) return;
                SetData(676, value, nameof(Bludgeoner_Orange_Sharpness_Attack_Bonus));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Bludgeoner_Orange_Sharpness_Attack_Bonus));
            }
        }

        public const string Bludgeoner_Yellow_Sharpness_Attack_Bonus_displayName = "Bludgeoner: Yellow Sharpness Attack Bonus";
        public const int Bludgeoner_Yellow_Sharpness_Attack_Bonus_sortIndex = 12750;
        [SortOrder(Bludgeoner_Yellow_Sharpness_Attack_Bonus_sortIndex)]
        [DisplayName(Bludgeoner_Yellow_Sharpness_Attack_Bonus_displayName)]
        public virtual ushort Bludgeoner_Yellow_Sharpness_Attack_Bonus {
            get => GetData<ushort>(678);
            set {
                if (GetData<ushort>(678) == value) return;
                SetData(678, value, nameof(Bludgeoner_Yellow_Sharpness_Attack_Bonus));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Bludgeoner_Yellow_Sharpness_Attack_Bonus));
            }
        }

        public const string Bludgeoner_Green_Sharpness_Attack_Bonus_displayName = "Bludgeoner: Green Sharpness Attack Bonus";
        public const int Bludgeoner_Green_Sharpness_Attack_Bonus_sortIndex = 12800;
        [SortOrder(Bludgeoner_Green_Sharpness_Attack_Bonus_sortIndex)]
        [DisplayName(Bludgeoner_Green_Sharpness_Attack_Bonus_displayName)]
        public virtual ushort Bludgeoner_Green_Sharpness_Attack_Bonus {
            get => GetData<ushort>(680);
            set {
                if (GetData<ushort>(680) == value) return;
                SetData(680, value, nameof(Bludgeoner_Green_Sharpness_Attack_Bonus));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Bludgeoner_Green_Sharpness_Attack_Bonus));
            }
        }

        public const string Bludgeoner_Blue_Sharpness_Attack_Bonus_displayName = "Bludgeoner: Blue Sharpness Attack Bonus";
        public const int Bludgeoner_Blue_Sharpness_Attack_Bonus_sortIndex = 12850;
        [SortOrder(Bludgeoner_Blue_Sharpness_Attack_Bonus_sortIndex)]
        [DisplayName(Bludgeoner_Blue_Sharpness_Attack_Bonus_displayName)]
        public virtual ushort Bludgeoner_Blue_Sharpness_Attack_Bonus {
            get => GetData<ushort>(682);
            set {
                if (GetData<ushort>(682) == value) return;
                SetData(682, value, nameof(Bludgeoner_Blue_Sharpness_Attack_Bonus));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Bludgeoner_Blue_Sharpness_Attack_Bonus));
            }
        }

        public const string Bludgeoner_White_Sharpness_Attack_Bonus_displayName = "Bludgeoner: White Sharpness Attack Bonus";
        public const int Bludgeoner_White_Sharpness_Attack_Bonus_sortIndex = 12900;
        [SortOrder(Bludgeoner_White_Sharpness_Attack_Bonus_sortIndex)]
        [DisplayName(Bludgeoner_White_Sharpness_Attack_Bonus_displayName)]
        public virtual ushort Bludgeoner_White_Sharpness_Attack_Bonus {
            get => GetData<ushort>(684);
            set {
                if (GetData<ushort>(684) == value) return;
                SetData(684, value, nameof(Bludgeoner_White_Sharpness_Attack_Bonus));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Bludgeoner_White_Sharpness_Attack_Bonus));
            }
        }

        public const string Bludgeoner_Purple_Sharpness_Attack_Bonus_displayName = "Bludgeoner: Purple Sharpness Attack Bonus";
        public const int Bludgeoner_Purple_Sharpness_Attack_Bonus_sortIndex = 12950;
        [SortOrder(Bludgeoner_Purple_Sharpness_Attack_Bonus_sortIndex)]
        [DisplayName(Bludgeoner_Purple_Sharpness_Attack_Bonus_displayName)]
        public virtual ushort Bludgeoner_Purple_Sharpness_Attack_Bonus {
            get => GetData<ushort>(686);
            set {
                if (GetData<ushort>(686) == value) return;
                SetData(686, value, nameof(Bludgeoner_Purple_Sharpness_Attack_Bonus));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Bludgeoner_Purple_Sharpness_Attack_Bonus));
            }
        }

        public const string Bludgeoner_Bowgun_Melee_Attack_Stun_Bonus_displayName = "Bludgeoner: Bowgun Melee Attack Stun Bonus";
        public const int Bludgeoner_Bowgun_Melee_Attack_Stun_Bonus_sortIndex = 13000;
        [SortOrder(Bludgeoner_Bowgun_Melee_Attack_Stun_Bonus_sortIndex)]
        [DisplayName(Bludgeoner_Bowgun_Melee_Attack_Stun_Bonus_displayName)]
        public virtual ushort Bludgeoner_Bowgun_Melee_Attack_Stun_Bonus {
            get => GetData<ushort>(688);
            set {
                if (GetData<ushort>(688) == value) return;
                SetData(688, value, nameof(Bludgeoner_Bowgun_Melee_Attack_Stun_Bonus));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Bludgeoner_Bowgun_Melee_Attack_Stun_Bonus));
            }
        }

        public const string __13050_displayName = "-------------------------------------------------------------------------------------------";
        public const int __13050_sortIndex = 13050;
        [SortOrder(__13050_sortIndex)]
        [DisplayName(__13050_displayName)]
        public virtual byte __13050 {
            get => GetData<byte>(3);
        }

        public const string Non_Elemental_Boost_Attack_Multiplier_displayName = "Non-Elemental Boost: Attack Multiplier";
        public const int Non_Elemental_Boost_Attack_Multiplier_sortIndex = 13100;
        [SortOrder(Non_Elemental_Boost_Attack_Multiplier_sortIndex)]
        [DisplayName(Non_Elemental_Boost_Attack_Multiplier_displayName)]
        public virtual float Non_Elemental_Boost_Attack_Multiplier {
            get => GetData<float>(690);
            set {
                if (GetData<float>(690) == value) return;
                SetData(690, value, nameof(Non_Elemental_Boost_Attack_Multiplier));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Non_Elemental_Boost_Attack_Multiplier));
            }
        }

        public const string __13150_displayName = "-------------------------------------------------------------------------------------------";
        public const int __13150_sortIndex = 13150;
        [SortOrder(__13150_sortIndex)]
        [DisplayName(__13150_displayName)]
        public virtual byte __13150 {
            get => GetData<byte>(3);
        }

        public const string Affinity_Slider_Attack_Up_Activate_Time_displayName = "Affinity Slider: Attack Up Activate Time";
        public const int Affinity_Slider_Attack_Up_Activate_Time_sortIndex = 13200;
        [SortOrder(Affinity_Slider_Attack_Up_Activate_Time_sortIndex)]
        [DisplayName(Affinity_Slider_Attack_Up_Activate_Time_displayName)]
        public virtual float Affinity_Slider_Attack_Up_Activate_Time {
            get => GetData<float>(694);
            set {
                if (GetData<float>(694) == value) return;
                SetData(694, value, nameof(Affinity_Slider_Attack_Up_Activate_Time));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Affinity_Slider_Attack_Up_Activate_Time));
            }
        }

        public const string Affinity_Slider_Attack_Up_Duration_displayName = "Affinity Slider: Attack Up Duration";
        public const int Affinity_Slider_Attack_Up_Duration_sortIndex = 13250;
        [SortOrder(Affinity_Slider_Attack_Up_Duration_sortIndex)]
        [DisplayName(Affinity_Slider_Attack_Up_Duration_displayName)]
        public virtual float Affinity_Slider_Attack_Up_Duration {
            get => GetData<float>(698);
            set {
                if (GetData<float>(698) == value) return;
                SetData(698, value, nameof(Affinity_Slider_Attack_Up_Duration));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Affinity_Slider_Attack_Up_Duration));
            }
        }

        public const string Affinity_Slider_Attack_Critical_Bonus_displayName = "Affinity Slider: Attack Critical Bonus";
        public const int Affinity_Slider_Attack_Critical_Bonus_sortIndex = 13300;
        [SortOrder(Affinity_Slider_Attack_Critical_Bonus_sortIndex)]
        [DisplayName(Affinity_Slider_Attack_Critical_Bonus_displayName)]
        public virtual byte Affinity_Slider_Attack_Critical_Bonus {
            get => GetData<byte>(702);
            set {
                if (GetData<byte>(702) == value) return;
                SetData(702, value, nameof(Affinity_Slider_Attack_Critical_Bonus));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Affinity_Slider_Attack_Critical_Bonus));
            }
        }

        public const string __13350_displayName = "-------------------------------------------------------------------------------------------";
        public const int __13350_sortIndex = 13350;
        [SortOrder(__13350_sortIndex)]
        [DisplayName(__13350_displayName)]
        public virtual byte __13350 {
            get => GetData<byte>(3);
        }

        public const string Artillery_Gunlance_Shell_Attack_Rate_1_displayName = "Artillery: Gunlance Shell Attack Rate 1";
        public const int Artillery_Gunlance_Shell_Attack_Rate_1_sortIndex = 13400;
        [SortOrder(Artillery_Gunlance_Shell_Attack_Rate_1_sortIndex)]
        [DisplayName(Artillery_Gunlance_Shell_Attack_Rate_1_displayName)]
        public virtual float Artillery_Gunlance_Shell_Attack_Rate_1 {
            get => GetData<float>(703);
            set {
                if (GetData<float>(703) == value) return;
                SetData(703, value, nameof(Artillery_Gunlance_Shell_Attack_Rate_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_Gunlance_Shell_Attack_Rate_1));
            }
        }

        public const string Artillery_Gunlance_Shell_Attack_Rate_2_displayName = "Artillery: Gunlance Shell Attack Rate 2";
        public const int Artillery_Gunlance_Shell_Attack_Rate_2_sortIndex = 13450;
        [SortOrder(Artillery_Gunlance_Shell_Attack_Rate_2_sortIndex)]
        [DisplayName(Artillery_Gunlance_Shell_Attack_Rate_2_displayName)]
        public virtual float Artillery_Gunlance_Shell_Attack_Rate_2 {
            get => GetData<float>(707);
            set {
                if (GetData<float>(707) == value) return;
                SetData(707, value, nameof(Artillery_Gunlance_Shell_Attack_Rate_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_Gunlance_Shell_Attack_Rate_2));
            }
        }

        public const string Artillery_Gunlance_Shell_Attack_Rate_3_displayName = "Artillery: Gunlance Shell Attack Rate 3";
        public const int Artillery_Gunlance_Shell_Attack_Rate_3_sortIndex = 13500;
        [SortOrder(Artillery_Gunlance_Shell_Attack_Rate_3_sortIndex)]
        [DisplayName(Artillery_Gunlance_Shell_Attack_Rate_3_displayName)]
        public virtual float Artillery_Gunlance_Shell_Attack_Rate_3 {
            get => GetData<float>(711);
            set {
                if (GetData<float>(711) == value) return;
                SetData(711, value, nameof(Artillery_Gunlance_Shell_Attack_Rate_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_Gunlance_Shell_Attack_Rate_3));
            }
        }

        public const string Artillery_Gunlance_Shell_Attack_Rate_4_displayName = "Artillery: Gunlance Shell Attack Rate 4";
        public const int Artillery_Gunlance_Shell_Attack_Rate_4_sortIndex = 13550;
        [SortOrder(Artillery_Gunlance_Shell_Attack_Rate_4_sortIndex)]
        [DisplayName(Artillery_Gunlance_Shell_Attack_Rate_4_displayName)]
        public virtual float Artillery_Gunlance_Shell_Attack_Rate_4 {
            get => GetData<float>(715);
            set {
                if (GetData<float>(715) == value) return;
                SetData(715, value, nameof(Artillery_Gunlance_Shell_Attack_Rate_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_Gunlance_Shell_Attack_Rate_4));
            }
        }

        public const string Artillery_Gunlance_Shell_Attack_Rate_5_displayName = "Artillery: Gunlance Shell Attack Rate 5";
        public const int Artillery_Gunlance_Shell_Attack_Rate_5_sortIndex = 13600;
        [SortOrder(Artillery_Gunlance_Shell_Attack_Rate_5_sortIndex)]
        [DisplayName(Artillery_Gunlance_Shell_Attack_Rate_5_displayName)]
        public virtual float Artillery_Gunlance_Shell_Attack_Rate_5 {
            get => GetData<float>(719);
            set {
                if (GetData<float>(719) == value) return;
                SetData(719, value, nameof(Artillery_Gunlance_Shell_Attack_Rate_5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_Gunlance_Shell_Attack_Rate_5));
            }
        }

        public const string __13650_displayName = "-------------------------------------------------------------------------------------------";
        public const int __13650_sortIndex = 13650;
        [SortOrder(__13650_sortIndex)]
        [DisplayName(__13650_displayName)]
        public virtual byte __13650 {
            get => GetData<byte>(3);
        }

        public const string Artillery_Gunlance_WyvernFire_Attack_Rate_1_displayName = "Artillery: Gunlance WyvernFire Attack Rate 1";
        public const int Artillery_Gunlance_WyvernFire_Attack_Rate_1_sortIndex = 13700;
        [SortOrder(Artillery_Gunlance_WyvernFire_Attack_Rate_1_sortIndex)]
        [DisplayName(Artillery_Gunlance_WyvernFire_Attack_Rate_1_displayName)]
        public virtual float Artillery_Gunlance_WyvernFire_Attack_Rate_1 {
            get => GetData<float>(723);
            set {
                if (GetData<float>(723) == value) return;
                SetData(723, value, nameof(Artillery_Gunlance_WyvernFire_Attack_Rate_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_Gunlance_WyvernFire_Attack_Rate_1));
            }
        }

        public const string Artillery_Gunlance_WyvernFire_Attack_Rate_2_displayName = "Artillery: Gunlance WyvernFire Attack Rate 2";
        public const int Artillery_Gunlance_WyvernFire_Attack_Rate_2_sortIndex = 13750;
        [SortOrder(Artillery_Gunlance_WyvernFire_Attack_Rate_2_sortIndex)]
        [DisplayName(Artillery_Gunlance_WyvernFire_Attack_Rate_2_displayName)]
        public virtual float Artillery_Gunlance_WyvernFire_Attack_Rate_2 {
            get => GetData<float>(727);
            set {
                if (GetData<float>(727) == value) return;
                SetData(727, value, nameof(Artillery_Gunlance_WyvernFire_Attack_Rate_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_Gunlance_WyvernFire_Attack_Rate_2));
            }
        }

        public const string Artillery_Gunlance_WyvernFire_Attack_Rate_3_displayName = "Artillery: Gunlance WyvernFire Attack Rate 3";
        public const int Artillery_Gunlance_WyvernFire_Attack_Rate_3_sortIndex = 13800;
        [SortOrder(Artillery_Gunlance_WyvernFire_Attack_Rate_3_sortIndex)]
        [DisplayName(Artillery_Gunlance_WyvernFire_Attack_Rate_3_displayName)]
        public virtual float Artillery_Gunlance_WyvernFire_Attack_Rate_3 {
            get => GetData<float>(731);
            set {
                if (GetData<float>(731) == value) return;
                SetData(731, value, nameof(Artillery_Gunlance_WyvernFire_Attack_Rate_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_Gunlance_WyvernFire_Attack_Rate_3));
            }
        }

        public const string Artillery_Gunlance_WyvernFire_Attack_Rate_4_displayName = "Artillery: Gunlance WyvernFire Attack Rate 4";
        public const int Artillery_Gunlance_WyvernFire_Attack_Rate_4_sortIndex = 13850;
        [SortOrder(Artillery_Gunlance_WyvernFire_Attack_Rate_4_sortIndex)]
        [DisplayName(Artillery_Gunlance_WyvernFire_Attack_Rate_4_displayName)]
        public virtual float Artillery_Gunlance_WyvernFire_Attack_Rate_4 {
            get => GetData<float>(735);
            set {
                if (GetData<float>(735) == value) return;
                SetData(735, value, nameof(Artillery_Gunlance_WyvernFire_Attack_Rate_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_Gunlance_WyvernFire_Attack_Rate_4));
            }
        }

        public const string Artillery_Gunlance_WyvernFire_Attack_Rate_5_displayName = "Artillery: Gunlance WyvernFire Attack Rate 5";
        public const int Artillery_Gunlance_WyvernFire_Attack_Rate_5_sortIndex = 13900;
        [SortOrder(Artillery_Gunlance_WyvernFire_Attack_Rate_5_sortIndex)]
        [DisplayName(Artillery_Gunlance_WyvernFire_Attack_Rate_5_displayName)]
        public virtual float Artillery_Gunlance_WyvernFire_Attack_Rate_5 {
            get => GetData<float>(739);
            set {
                if (GetData<float>(739) == value) return;
                SetData(739, value, nameof(Artillery_Gunlance_WyvernFire_Attack_Rate_5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_Gunlance_WyvernFire_Attack_Rate_5));
            }
        }

        public const string __13950_displayName = "-------------------------------------------------------------------------------------------";
        public const int __13950_sortIndex = 13950;
        [SortOrder(__13950_sortIndex)]
        [DisplayName(__13950_displayName)]
        public virtual byte __13950 {
            get => GetData<byte>(3);
        }

        public const string Artillery_Gunlance_Wyrmstake_Blast_Attack_Rate_1_displayName = "Artillery: Gunlance Wyrmstake Blast Attack Rate 1";
        public const int Artillery_Gunlance_Wyrmstake_Blast_Attack_Rate_1_sortIndex = 14000;
        [SortOrder(Artillery_Gunlance_Wyrmstake_Blast_Attack_Rate_1_sortIndex)]
        [DisplayName(Artillery_Gunlance_Wyrmstake_Blast_Attack_Rate_1_displayName)]
        public virtual float Artillery_Gunlance_Wyrmstake_Blast_Attack_Rate_1 {
            get => GetData<float>(743);
            set {
                if (GetData<float>(743) == value) return;
                SetData(743, value, nameof(Artillery_Gunlance_Wyrmstake_Blast_Attack_Rate_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_Gunlance_Wyrmstake_Blast_Attack_Rate_1));
            }
        }

        public const string Artillery_Gunlance_Wyrmstake_Blast_Attack_Rate_2_displayName = "Artillery: Gunlance Wyrmstake Blast Attack Rate 2";
        public const int Artillery_Gunlance_Wyrmstake_Blast_Attack_Rate_2_sortIndex = 14050;
        [SortOrder(Artillery_Gunlance_Wyrmstake_Blast_Attack_Rate_2_sortIndex)]
        [DisplayName(Artillery_Gunlance_Wyrmstake_Blast_Attack_Rate_2_displayName)]
        public virtual float Artillery_Gunlance_Wyrmstake_Blast_Attack_Rate_2 {
            get => GetData<float>(747);
            set {
                if (GetData<float>(747) == value) return;
                SetData(747, value, nameof(Artillery_Gunlance_Wyrmstake_Blast_Attack_Rate_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_Gunlance_Wyrmstake_Blast_Attack_Rate_2));
            }
        }

        public const string Artillery_Gunlance_Wyrmstake_Blast_Attack_Rate_3_displayName = "Artillery: Gunlance Wyrmstake Blast Attack Rate 3";
        public const int Artillery_Gunlance_Wyrmstake_Blast_Attack_Rate_3_sortIndex = 14100;
        [SortOrder(Artillery_Gunlance_Wyrmstake_Blast_Attack_Rate_3_sortIndex)]
        [DisplayName(Artillery_Gunlance_Wyrmstake_Blast_Attack_Rate_3_displayName)]
        public virtual float Artillery_Gunlance_Wyrmstake_Blast_Attack_Rate_3 {
            get => GetData<float>(751);
            set {
                if (GetData<float>(751) == value) return;
                SetData(751, value, nameof(Artillery_Gunlance_Wyrmstake_Blast_Attack_Rate_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_Gunlance_Wyrmstake_Blast_Attack_Rate_3));
            }
        }

        public const string Artillery_Gunlance_Wyrmstake_Blast_Attack_Rate_4_displayName = "Artillery: Gunlance Wyrmstake Blast Attack Rate 4";
        public const int Artillery_Gunlance_Wyrmstake_Blast_Attack_Rate_4_sortIndex = 14150;
        [SortOrder(Artillery_Gunlance_Wyrmstake_Blast_Attack_Rate_4_sortIndex)]
        [DisplayName(Artillery_Gunlance_Wyrmstake_Blast_Attack_Rate_4_displayName)]
        public virtual float Artillery_Gunlance_Wyrmstake_Blast_Attack_Rate_4 {
            get => GetData<float>(755);
            set {
                if (GetData<float>(755) == value) return;
                SetData(755, value, nameof(Artillery_Gunlance_Wyrmstake_Blast_Attack_Rate_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_Gunlance_Wyrmstake_Blast_Attack_Rate_4));
            }
        }

        public const string Artillery_Gunlance_Wyrmstake_Blast_Attack_Rate_5_displayName = "Artillery: Gunlance Wyrmstake Blast Attack Rate 5";
        public const int Artillery_Gunlance_Wyrmstake_Blast_Attack_Rate_5_sortIndex = 14200;
        [SortOrder(Artillery_Gunlance_Wyrmstake_Blast_Attack_Rate_5_sortIndex)]
        [DisplayName(Artillery_Gunlance_Wyrmstake_Blast_Attack_Rate_5_displayName)]
        public virtual float Artillery_Gunlance_Wyrmstake_Blast_Attack_Rate_5 {
            get => GetData<float>(759);
            set {
                if (GetData<float>(759) == value) return;
                SetData(759, value, nameof(Artillery_Gunlance_Wyrmstake_Blast_Attack_Rate_5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_Gunlance_Wyrmstake_Blast_Attack_Rate_5));
            }
        }

        public const string __14250_displayName = "-------------------------------------------------------------------------------------------";
        public const int __14250_sortIndex = 14250;
        [SortOrder(__14250_sortIndex)]
        [DisplayName(__14250_displayName)]
        public virtual byte __14250 {
            get => GetData<byte>(3);
        }

        public const string Artillery_Gunlance_WyvernFire_Cooldown_Time_Rate_1_displayName = "Artillery: Gunlance WyvernFire Cooldown Time Rate 1";
        public const int Artillery_Gunlance_WyvernFire_Cooldown_Time_Rate_1_sortIndex = 14300;
        [SortOrder(Artillery_Gunlance_WyvernFire_Cooldown_Time_Rate_1_sortIndex)]
        [DisplayName(Artillery_Gunlance_WyvernFire_Cooldown_Time_Rate_1_displayName)]
        public virtual float Artillery_Gunlance_WyvernFire_Cooldown_Time_Rate_1 {
            get => GetData<float>(763);
            set {
                if (GetData<float>(763) == value) return;
                SetData(763, value, nameof(Artillery_Gunlance_WyvernFire_Cooldown_Time_Rate_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_Gunlance_WyvernFire_Cooldown_Time_Rate_1));
            }
        }

        public const string Artillery_Gunlance_WyvernFire_Cooldown_Time_Rate_2_displayName = "Artillery: Gunlance WyvernFire Cooldown Time Rate 2";
        public const int Artillery_Gunlance_WyvernFire_Cooldown_Time_Rate_2_sortIndex = 14350;
        [SortOrder(Artillery_Gunlance_WyvernFire_Cooldown_Time_Rate_2_sortIndex)]
        [DisplayName(Artillery_Gunlance_WyvernFire_Cooldown_Time_Rate_2_displayName)]
        public virtual float Artillery_Gunlance_WyvernFire_Cooldown_Time_Rate_2 {
            get => GetData<float>(767);
            set {
                if (GetData<float>(767) == value) return;
                SetData(767, value, nameof(Artillery_Gunlance_WyvernFire_Cooldown_Time_Rate_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_Gunlance_WyvernFire_Cooldown_Time_Rate_2));
            }
        }

        public const string Artillery_Gunlance_WyvernFire_Cooldown_Time_Rate_3_displayName = "Artillery: Gunlance WyvernFire Cooldown Time Rate 3";
        public const int Artillery_Gunlance_WyvernFire_Cooldown_Time_Rate_3_sortIndex = 14400;
        [SortOrder(Artillery_Gunlance_WyvernFire_Cooldown_Time_Rate_3_sortIndex)]
        [DisplayName(Artillery_Gunlance_WyvernFire_Cooldown_Time_Rate_3_displayName)]
        public virtual float Artillery_Gunlance_WyvernFire_Cooldown_Time_Rate_3 {
            get => GetData<float>(771);
            set {
                if (GetData<float>(771) == value) return;
                SetData(771, value, nameof(Artillery_Gunlance_WyvernFire_Cooldown_Time_Rate_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_Gunlance_WyvernFire_Cooldown_Time_Rate_3));
            }
        }

        public const string Artillery_Gunlance_WyvernFire_Cooldown_Time_Rate_4_displayName = "Artillery: Gunlance WyvernFire Cooldown Time Rate 4";
        public const int Artillery_Gunlance_WyvernFire_Cooldown_Time_Rate_4_sortIndex = 14450;
        [SortOrder(Artillery_Gunlance_WyvernFire_Cooldown_Time_Rate_4_sortIndex)]
        [DisplayName(Artillery_Gunlance_WyvernFire_Cooldown_Time_Rate_4_displayName)]
        public virtual float Artillery_Gunlance_WyvernFire_Cooldown_Time_Rate_4 {
            get => GetData<float>(775);
            set {
                if (GetData<float>(775) == value) return;
                SetData(775, value, nameof(Artillery_Gunlance_WyvernFire_Cooldown_Time_Rate_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_Gunlance_WyvernFire_Cooldown_Time_Rate_4));
            }
        }

        public const string Artillery_Gunlance_WyvernFire_Cooldown_Time_Rate_5_displayName = "Artillery: Gunlance WyvernFire Cooldown Time Rate 5";
        public const int Artillery_Gunlance_WyvernFire_Cooldown_Time_Rate_5_sortIndex = 14500;
        [SortOrder(Artillery_Gunlance_WyvernFire_Cooldown_Time_Rate_5_sortIndex)]
        [DisplayName(Artillery_Gunlance_WyvernFire_Cooldown_Time_Rate_5_displayName)]
        public virtual float Artillery_Gunlance_WyvernFire_Cooldown_Time_Rate_5 {
            get => GetData<float>(779);
            set {
                if (GetData<float>(779) == value) return;
                SetData(779, value, nameof(Artillery_Gunlance_WyvernFire_Cooldown_Time_Rate_5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_Gunlance_WyvernFire_Cooldown_Time_Rate_5));
            }
        }

        public const string __14550_displayName = "-------------------------------------------------------------------------------------------";
        public const int __14550_sortIndex = 14550;
        [SortOrder(__14550_sortIndex)]
        [DisplayName(__14550_displayName)]
        public virtual byte __14550 {
            get => GetData<byte>(3);
        }

        public const string Artillery_Charge_Blade_Impact_Phial_Attack_Rate_1_displayName = "Artillery: Charge Blade Impact Phial Attack Rate 1";
        public const int Artillery_Charge_Blade_Impact_Phial_Attack_Rate_1_sortIndex = 14600;
        [SortOrder(Artillery_Charge_Blade_Impact_Phial_Attack_Rate_1_sortIndex)]
        [DisplayName(Artillery_Charge_Blade_Impact_Phial_Attack_Rate_1_displayName)]
        public virtual float Artillery_Charge_Blade_Impact_Phial_Attack_Rate_1 {
            get => GetData<float>(783);
            set {
                if (GetData<float>(783) == value) return;
                SetData(783, value, nameof(Artillery_Charge_Blade_Impact_Phial_Attack_Rate_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_Charge_Blade_Impact_Phial_Attack_Rate_1));
            }
        }

        public const string Artillery_Charge_Blade_Impact_Phial_Attack_Rate_2_displayName = "Artillery: Charge Blade Impact Phial Attack Rate 2";
        public const int Artillery_Charge_Blade_Impact_Phial_Attack_Rate_2_sortIndex = 14650;
        [SortOrder(Artillery_Charge_Blade_Impact_Phial_Attack_Rate_2_sortIndex)]
        [DisplayName(Artillery_Charge_Blade_Impact_Phial_Attack_Rate_2_displayName)]
        public virtual float Artillery_Charge_Blade_Impact_Phial_Attack_Rate_2 {
            get => GetData<float>(787);
            set {
                if (GetData<float>(787) == value) return;
                SetData(787, value, nameof(Artillery_Charge_Blade_Impact_Phial_Attack_Rate_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_Charge_Blade_Impact_Phial_Attack_Rate_2));
            }
        }

        public const string Artillery_Charge_Blade_Impact_Phial_Attack_Rate_3_displayName = "Artillery: Charge Blade Impact Phial Attack Rate 3";
        public const int Artillery_Charge_Blade_Impact_Phial_Attack_Rate_3_sortIndex = 14700;
        [SortOrder(Artillery_Charge_Blade_Impact_Phial_Attack_Rate_3_sortIndex)]
        [DisplayName(Artillery_Charge_Blade_Impact_Phial_Attack_Rate_3_displayName)]
        public virtual float Artillery_Charge_Blade_Impact_Phial_Attack_Rate_3 {
            get => GetData<float>(791);
            set {
                if (GetData<float>(791) == value) return;
                SetData(791, value, nameof(Artillery_Charge_Blade_Impact_Phial_Attack_Rate_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_Charge_Blade_Impact_Phial_Attack_Rate_3));
            }
        }

        public const string Artillery_Charge_Blade_Impact_Phial_Attack_Rate_4_displayName = "Artillery: Charge Blade Impact Phial Attack Rate 4";
        public const int Artillery_Charge_Blade_Impact_Phial_Attack_Rate_4_sortIndex = 14750;
        [SortOrder(Artillery_Charge_Blade_Impact_Phial_Attack_Rate_4_sortIndex)]
        [DisplayName(Artillery_Charge_Blade_Impact_Phial_Attack_Rate_4_displayName)]
        public virtual float Artillery_Charge_Blade_Impact_Phial_Attack_Rate_4 {
            get => GetData<float>(795);
            set {
                if (GetData<float>(795) == value) return;
                SetData(795, value, nameof(Artillery_Charge_Blade_Impact_Phial_Attack_Rate_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_Charge_Blade_Impact_Phial_Attack_Rate_4));
            }
        }

        public const string Artillery_Charge_Blade_Impact_Phial_Attack_Rate_5_displayName = "Artillery: Charge Blade Impact Phial Attack Rate 5";
        public const int Artillery_Charge_Blade_Impact_Phial_Attack_Rate_5_sortIndex = 14800;
        [SortOrder(Artillery_Charge_Blade_Impact_Phial_Attack_Rate_5_sortIndex)]
        [DisplayName(Artillery_Charge_Blade_Impact_Phial_Attack_Rate_5_displayName)]
        public virtual float Artillery_Charge_Blade_Impact_Phial_Attack_Rate_5 {
            get => GetData<float>(799);
            set {
                if (GetData<float>(799) == value) return;
                SetData(799, value, nameof(Artillery_Charge_Blade_Impact_Phial_Attack_Rate_5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_Charge_Blade_Impact_Phial_Attack_Rate_5));
            }
        }

        public const string __14850_displayName = "-------------------------------------------------------------------------------------------";
        public const int __14850_sortIndex = 14850;
        [SortOrder(__14850_sortIndex)]
        [DisplayName(__14850_displayName)]
        public virtual byte __14850 {
            get => GetData<byte>(3);
        }

        public const string Artillery_Bowgun_Sticky_Ammo_Attack_Rate_1_displayName = "Artillery: Bowgun Sticky Ammo Attack Rate 1";
        public const int Artillery_Bowgun_Sticky_Ammo_Attack_Rate_1_sortIndex = 14900;
        [SortOrder(Artillery_Bowgun_Sticky_Ammo_Attack_Rate_1_sortIndex)]
        [DisplayName(Artillery_Bowgun_Sticky_Ammo_Attack_Rate_1_displayName)]
        public virtual float Artillery_Bowgun_Sticky_Ammo_Attack_Rate_1 {
            get => GetData<float>(803);
            set {
                if (GetData<float>(803) == value) return;
                SetData(803, value, nameof(Artillery_Bowgun_Sticky_Ammo_Attack_Rate_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_Bowgun_Sticky_Ammo_Attack_Rate_1));
            }
        }

        public const string Artillery_Bowgun_Sticky_Ammo_Attack_Rate_2_displayName = "Artillery: Bowgun Sticky Ammo Attack Rate 2";
        public const int Artillery_Bowgun_Sticky_Ammo_Attack_Rate_2_sortIndex = 14950;
        [SortOrder(Artillery_Bowgun_Sticky_Ammo_Attack_Rate_2_sortIndex)]
        [DisplayName(Artillery_Bowgun_Sticky_Ammo_Attack_Rate_2_displayName)]
        public virtual float Artillery_Bowgun_Sticky_Ammo_Attack_Rate_2 {
            get => GetData<float>(807);
            set {
                if (GetData<float>(807) == value) return;
                SetData(807, value, nameof(Artillery_Bowgun_Sticky_Ammo_Attack_Rate_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_Bowgun_Sticky_Ammo_Attack_Rate_2));
            }
        }

        public const string Artillery_Bowgun_Sticky_Ammo_Attack_Rate_3_displayName = "Artillery: Bowgun Sticky Ammo Attack Rate 3";
        public const int Artillery_Bowgun_Sticky_Ammo_Attack_Rate_3_sortIndex = 15000;
        [SortOrder(Artillery_Bowgun_Sticky_Ammo_Attack_Rate_3_sortIndex)]
        [DisplayName(Artillery_Bowgun_Sticky_Ammo_Attack_Rate_3_displayName)]
        public virtual float Artillery_Bowgun_Sticky_Ammo_Attack_Rate_3 {
            get => GetData<float>(811);
            set {
                if (GetData<float>(811) == value) return;
                SetData(811, value, nameof(Artillery_Bowgun_Sticky_Ammo_Attack_Rate_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_Bowgun_Sticky_Ammo_Attack_Rate_3));
            }
        }

        public const string Artillery_Bowgun_Sticky_Ammo_Attack_Rate_4_displayName = "Artillery: Bowgun Sticky Ammo Attack Rate 4";
        public const int Artillery_Bowgun_Sticky_Ammo_Attack_Rate_4_sortIndex = 15050;
        [SortOrder(Artillery_Bowgun_Sticky_Ammo_Attack_Rate_4_sortIndex)]
        [DisplayName(Artillery_Bowgun_Sticky_Ammo_Attack_Rate_4_displayName)]
        public virtual float Artillery_Bowgun_Sticky_Ammo_Attack_Rate_4 {
            get => GetData<float>(815);
            set {
                if (GetData<float>(815) == value) return;
                SetData(815, value, nameof(Artillery_Bowgun_Sticky_Ammo_Attack_Rate_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_Bowgun_Sticky_Ammo_Attack_Rate_4));
            }
        }

        public const string Artillery_Bowgun_Sticky_Ammo_Attack_Rate_5_displayName = "Artillery: Bowgun Sticky Ammo Attack Rate 5";
        public const int Artillery_Bowgun_Sticky_Ammo_Attack_Rate_5_sortIndex = 15100;
        [SortOrder(Artillery_Bowgun_Sticky_Ammo_Attack_Rate_5_sortIndex)]
        [DisplayName(Artillery_Bowgun_Sticky_Ammo_Attack_Rate_5_displayName)]
        public virtual float Artillery_Bowgun_Sticky_Ammo_Attack_Rate_5 {
            get => GetData<float>(819);
            set {
                if (GetData<float>(819) == value) return;
                SetData(819, value, nameof(Artillery_Bowgun_Sticky_Ammo_Attack_Rate_5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_Bowgun_Sticky_Ammo_Attack_Rate_5));
            }
        }

        public const string __15150_displayName = "-------------------------------------------------------------------------------------------";
        public const int __15150_sortIndex = 15150;
        [SortOrder(__15150_sortIndex)]
        [DisplayName(__15150_displayName)]
        public virtual byte __15150 {
            get => GetData<byte>(3);
        }

        public const string Artillery_Bowgun_Kakusan_Attack_Rate_1_displayName = "Artillery: Bowgun Kakusan Attack Rate 1";
        public const int Artillery_Bowgun_Kakusan_Attack_Rate_1_sortIndex = 15200;
        [SortOrder(Artillery_Bowgun_Kakusan_Attack_Rate_1_sortIndex)]
        [DisplayName(Artillery_Bowgun_Kakusan_Attack_Rate_1_displayName)]
        public virtual float Artillery_Bowgun_Kakusan_Attack_Rate_1 {
            get => GetData<float>(823);
            set {
                if (GetData<float>(823) == value) return;
                SetData(823, value, nameof(Artillery_Bowgun_Kakusan_Attack_Rate_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_Bowgun_Kakusan_Attack_Rate_1));
            }
        }

        public const string Artillery_Bowgun_Kakusan_Attack_Rate_2_displayName = "Artillery: Bowgun Kakusan Attack Rate 2";
        public const int Artillery_Bowgun_Kakusan_Attack_Rate_2_sortIndex = 15250;
        [SortOrder(Artillery_Bowgun_Kakusan_Attack_Rate_2_sortIndex)]
        [DisplayName(Artillery_Bowgun_Kakusan_Attack_Rate_2_displayName)]
        public virtual float Artillery_Bowgun_Kakusan_Attack_Rate_2 {
            get => GetData<float>(827);
            set {
                if (GetData<float>(827) == value) return;
                SetData(827, value, nameof(Artillery_Bowgun_Kakusan_Attack_Rate_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_Bowgun_Kakusan_Attack_Rate_2));
            }
        }

        public const string Artillery_Bowgun_Kakusan_Attack_Rate_3_displayName = "Artillery: Bowgun Kakusan Attack Rate 3";
        public const int Artillery_Bowgun_Kakusan_Attack_Rate_3_sortIndex = 15300;
        [SortOrder(Artillery_Bowgun_Kakusan_Attack_Rate_3_sortIndex)]
        [DisplayName(Artillery_Bowgun_Kakusan_Attack_Rate_3_displayName)]
        public virtual float Artillery_Bowgun_Kakusan_Attack_Rate_3 {
            get => GetData<float>(831);
            set {
                if (GetData<float>(831) == value) return;
                SetData(831, value, nameof(Artillery_Bowgun_Kakusan_Attack_Rate_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_Bowgun_Kakusan_Attack_Rate_3));
            }
        }

        public const string Artillery_Bowgun_Kakusan_Attack_Rate_4_displayName = "Artillery: Bowgun Kakusan Attack Rate 4";
        public const int Artillery_Bowgun_Kakusan_Attack_Rate_4_sortIndex = 15350;
        [SortOrder(Artillery_Bowgun_Kakusan_Attack_Rate_4_sortIndex)]
        [DisplayName(Artillery_Bowgun_Kakusan_Attack_Rate_4_displayName)]
        public virtual float Artillery_Bowgun_Kakusan_Attack_Rate_4 {
            get => GetData<float>(835);
            set {
                if (GetData<float>(835) == value) return;
                SetData(835, value, nameof(Artillery_Bowgun_Kakusan_Attack_Rate_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_Bowgun_Kakusan_Attack_Rate_4));
            }
        }

        public const string Artillery_Bowgun_Kakusan_Attack_Rate_5_displayName = "Artillery: Bowgun Kakusan Attack Rate 5";
        public const int Artillery_Bowgun_Kakusan_Attack_Rate_5_sortIndex = 15400;
        [SortOrder(Artillery_Bowgun_Kakusan_Attack_Rate_5_sortIndex)]
        [DisplayName(Artillery_Bowgun_Kakusan_Attack_Rate_5_displayName)]
        public virtual float Artillery_Bowgun_Kakusan_Attack_Rate_5 {
            get => GetData<float>(839);
            set {
                if (GetData<float>(839) == value) return;
                SetData(839, value, nameof(Artillery_Bowgun_Kakusan_Attack_Rate_5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_Bowgun_Kakusan_Attack_Rate_5));
            }
        }

        public const string __15450_displayName = "-------------------------------------------------------------------------------------------";
        public const int __15450_sortIndex = 15450;
        [SortOrder(__15450_sortIndex)]
        [DisplayName(__15450_displayName)]
        public virtual byte __15450 {
            get => GetData<byte>(3);
        }

        public const string Artillery_Bowgun_Wyvern_Attack_Rate_1_displayName = "Artillery: Bowgun Wyvern Attack Rate 1";
        public const int Artillery_Bowgun_Wyvern_Attack_Rate_1_sortIndex = 15500;
        [SortOrder(Artillery_Bowgun_Wyvern_Attack_Rate_1_sortIndex)]
        [DisplayName(Artillery_Bowgun_Wyvern_Attack_Rate_1_displayName)]
        public virtual float Artillery_Bowgun_Wyvern_Attack_Rate_1 {
            get => GetData<float>(843);
            set {
                if (GetData<float>(843) == value) return;
                SetData(843, value, nameof(Artillery_Bowgun_Wyvern_Attack_Rate_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_Bowgun_Wyvern_Attack_Rate_1));
            }
        }

        public const string Artillery_Bowgun_Wyvern_Attack_Rate_2_displayName = "Artillery: Bowgun Wyvern Attack Rate 2";
        public const int Artillery_Bowgun_Wyvern_Attack_Rate_2_sortIndex = 15550;
        [SortOrder(Artillery_Bowgun_Wyvern_Attack_Rate_2_sortIndex)]
        [DisplayName(Artillery_Bowgun_Wyvern_Attack_Rate_2_displayName)]
        public virtual float Artillery_Bowgun_Wyvern_Attack_Rate_2 {
            get => GetData<float>(847);
            set {
                if (GetData<float>(847) == value) return;
                SetData(847, value, nameof(Artillery_Bowgun_Wyvern_Attack_Rate_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_Bowgun_Wyvern_Attack_Rate_2));
            }
        }

        public const string Artillery_Bowgun_Wyvern_Attack_Rate_3_displayName = "Artillery: Bowgun Wyvern Attack Rate 3";
        public const int Artillery_Bowgun_Wyvern_Attack_Rate_3_sortIndex = 15600;
        [SortOrder(Artillery_Bowgun_Wyvern_Attack_Rate_3_sortIndex)]
        [DisplayName(Artillery_Bowgun_Wyvern_Attack_Rate_3_displayName)]
        public virtual float Artillery_Bowgun_Wyvern_Attack_Rate_3 {
            get => GetData<float>(851);
            set {
                if (GetData<float>(851) == value) return;
                SetData(851, value, nameof(Artillery_Bowgun_Wyvern_Attack_Rate_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_Bowgun_Wyvern_Attack_Rate_3));
            }
        }

        public const string Artillery_Bowgun_Wyvern_Attack_Rate_4_displayName = "Artillery: Bowgun Wyvern Attack Rate 4";
        public const int Artillery_Bowgun_Wyvern_Attack_Rate_4_sortIndex = 15650;
        [SortOrder(Artillery_Bowgun_Wyvern_Attack_Rate_4_sortIndex)]
        [DisplayName(Artillery_Bowgun_Wyvern_Attack_Rate_4_displayName)]
        public virtual float Artillery_Bowgun_Wyvern_Attack_Rate_4 {
            get => GetData<float>(855);
            set {
                if (GetData<float>(855) == value) return;
                SetData(855, value, nameof(Artillery_Bowgun_Wyvern_Attack_Rate_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_Bowgun_Wyvern_Attack_Rate_4));
            }
        }

        public const string Artillery_Bowgun_Wyvern_Attack_Rate_5_displayName = "Artillery: Bowgun Wyvern Attack Rate 5";
        public const int Artillery_Bowgun_Wyvern_Attack_Rate_5_sortIndex = 15700;
        [SortOrder(Artillery_Bowgun_Wyvern_Attack_Rate_5_sortIndex)]
        [DisplayName(Artillery_Bowgun_Wyvern_Attack_Rate_5_displayName)]
        public virtual float Artillery_Bowgun_Wyvern_Attack_Rate_5 {
            get => GetData<float>(859);
            set {
                if (GetData<float>(859) == value) return;
                SetData(859, value, nameof(Artillery_Bowgun_Wyvern_Attack_Rate_5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_Bowgun_Wyvern_Attack_Rate_5));
            }
        }

        public const string __15750_displayName = "-------------------------------------------------------------------------------------------";
        public const int __15750_sortIndex = 15750;
        [SortOrder(__15750_sortIndex)]
        [DisplayName(__15750_displayName)]
        public virtual byte __15750 {
            get => GetData<byte>(3);
        }

        public const string Artillery_LBG_Set_Bomb_Attack_Rate_1_displayName = "Artillery: LBG Set Bomb Attack Rate 1";
        public const int Artillery_LBG_Set_Bomb_Attack_Rate_1_sortIndex = 15800;
        [SortOrder(Artillery_LBG_Set_Bomb_Attack_Rate_1_sortIndex)]
        [DisplayName(Artillery_LBG_Set_Bomb_Attack_Rate_1_displayName)]
        public virtual float Artillery_LBG_Set_Bomb_Attack_Rate_1 {
            get => GetData<float>(863);
            set {
                if (GetData<float>(863) == value) return;
                SetData(863, value, nameof(Artillery_LBG_Set_Bomb_Attack_Rate_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_LBG_Set_Bomb_Attack_Rate_1));
            }
        }

        public const string Artillery_LBG_Set_Bomb_Attack_Rate_2_displayName = "Artillery: LBG Set Bomb Attack Rate 2";
        public const int Artillery_LBG_Set_Bomb_Attack_Rate_2_sortIndex = 15850;
        [SortOrder(Artillery_LBG_Set_Bomb_Attack_Rate_2_sortIndex)]
        [DisplayName(Artillery_LBG_Set_Bomb_Attack_Rate_2_displayName)]
        public virtual float Artillery_LBG_Set_Bomb_Attack_Rate_2 {
            get => GetData<float>(867);
            set {
                if (GetData<float>(867) == value) return;
                SetData(867, value, nameof(Artillery_LBG_Set_Bomb_Attack_Rate_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_LBG_Set_Bomb_Attack_Rate_2));
            }
        }

        public const string Artillery_LBG_Set_Bomb_Attack_Rate_3_displayName = "Artillery: LBG Set Bomb Attack Rate 3";
        public const int Artillery_LBG_Set_Bomb_Attack_Rate_3_sortIndex = 15900;
        [SortOrder(Artillery_LBG_Set_Bomb_Attack_Rate_3_sortIndex)]
        [DisplayName(Artillery_LBG_Set_Bomb_Attack_Rate_3_displayName)]
        public virtual float Artillery_LBG_Set_Bomb_Attack_Rate_3 {
            get => GetData<float>(871);
            set {
                if (GetData<float>(871) == value) return;
                SetData(871, value, nameof(Artillery_LBG_Set_Bomb_Attack_Rate_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_LBG_Set_Bomb_Attack_Rate_3));
            }
        }

        public const string Artillery_LBG_Set_Bomb_Attack_Rate_4_displayName = "Artillery: LBG Set Bomb Attack Rate 4";
        public const int Artillery_LBG_Set_Bomb_Attack_Rate_4_sortIndex = 15950;
        [SortOrder(Artillery_LBG_Set_Bomb_Attack_Rate_4_sortIndex)]
        [DisplayName(Artillery_LBG_Set_Bomb_Attack_Rate_4_displayName)]
        public virtual float Artillery_LBG_Set_Bomb_Attack_Rate_4 {
            get => GetData<float>(875);
            set {
                if (GetData<float>(875) == value) return;
                SetData(875, value, nameof(Artillery_LBG_Set_Bomb_Attack_Rate_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_LBG_Set_Bomb_Attack_Rate_4));
            }
        }

        public const string Artillery_LBG_Set_Bomb_Attack_Rate_5_displayName = "Artillery: LBG Set Bomb Attack Rate 5";
        public const int Artillery_LBG_Set_Bomb_Attack_Rate_5_sortIndex = 16000;
        [SortOrder(Artillery_LBG_Set_Bomb_Attack_Rate_5_sortIndex)]
        [DisplayName(Artillery_LBG_Set_Bomb_Attack_Rate_5_displayName)]
        public virtual float Artillery_LBG_Set_Bomb_Attack_Rate_5 {
            get => GetData<float>(879);
            set {
                if (GetData<float>(879) == value) return;
                SetData(879, value, nameof(Artillery_LBG_Set_Bomb_Attack_Rate_5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_LBG_Set_Bomb_Attack_Rate_5));
            }
        }

        public const string __16050_displayName = "-------------------------------------------------------------------------------------------";
        public const int __16050_sortIndex = 16050;
        [SortOrder(__16050_sortIndex)]
        [DisplayName(__16050_displayName)]
        public virtual byte __16050 {
            get => GetData<byte>(3);
        }

        public const string __16100_displayName = "-------------------------------------------------------------------------------------------";
        public const int __16100_sortIndex = 16100;
        [SortOrder(__16100_sortIndex)]
        [DisplayName(__16100_displayName)]
        public virtual byte __16100 {
            get => GetData<byte>(3);
        }

        public const string _Skipping_the_rest__16150_displayName = "------Skipping the rest.";
        public const int _Skipping_the_rest__16150_sortIndex = 16150;
        [SortOrder(_Skipping_the_rest__16150_sortIndex)]
        [DisplayName(_Skipping_the_rest__16150_displayName)]
        public virtual byte _Skipping_the_rest__16150 {
            get => GetData<byte>(3);
        }

        public const int lastSortIndex = 16200;
    }
}
using System;
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.PlData {
    public partial class PlSkillParam {
        public const uint StructSize = 2400;
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
        [IsReadOnly]
        public virtual byte __1000 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__1000));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__1000));
            }
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

        public const string Weakness_Exploit_Hit_Zone_Threshold_displayName = "Weakness Exploit Hit-Zone Threshold";
        public const int Weakness_Exploit_Hit_Zone_Threshold_sortIndex = 1300;
        [SortOrder(Weakness_Exploit_Hit_Zone_Threshold_sortIndex)]
        [DisplayName(Weakness_Exploit_Hit_Zone_Threshold_displayName)]
        public virtual byte Weakness_Exploit_Hit_Zone_Threshold {
            get => GetData<byte>(86);
            set {
                if (GetData<byte>(86) == value) return;
                SetData(86, value, nameof(Weakness_Exploit_Hit_Zone_Threshold));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Weakness_Exploit_Hit_Zone_Threshold));
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
        [IsReadOnly]
        public virtual byte __1600 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__1600));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__1600));
            }
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
        [IsReadOnly]
        public virtual byte __2150 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__2150));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__2150));
            }
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
            get => GetData<float>(206);
            set {
                if (GetData<float>(206) == value) return;
                SetData(206, value, nameof(Unk18));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk18));
            }
        }

        public const string __3100_displayName = "-------------------------------------------------------------------------------------------";
        public const int __3100_sortIndex = 3100;
        [SortOrder(__3100_sortIndex)]
        [DisplayName(__3100_displayName)]
        [IsReadOnly]
        public virtual byte __3100 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__3100));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__3100));
            }
        }

        public const string Focus_Gunlance_Charge_Shot_Time_Rate_1_displayName = "Focus (Gunlance, Charge Shot) Time Rate 1";
        public const int Focus_Gunlance_Charge_Shot_Time_Rate_1_sortIndex = 3150;
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
        public const int Focus_Gunlance_Charge_Shot_Time_Rate_2_sortIndex = 3200;
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
        public const int Focus_Gunlance_Charge_Shot_Time_Rate_3_sortIndex = 3250;
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
        public const int Focus_Charge_Blade_Slash_2_Time_Rate_1_sortIndex = 3300;
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
        public const int Focus_Charge_Blade_Slash_2_Time_Rate_2_sortIndex = 3350;
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
        public const int Focus_Charge_Blade_Slash_2_Time_Rate_3_sortIndex = 3400;
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
        public const int Focus_Charge_Blade_Phial_Charge_Slash_Time_Rate_1_sortIndex = 3450;
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
        public const int Focus_Charge_Blade_Phial_Charge_Slash_Time_Rate_2_sortIndex = 3500;
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
        public const int Focus_Charge_Blade_Phial_Charge_Slash_Time_Rate_3_sortIndex = 3550;
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

        public const string __3600_displayName = "-------------------------------------------------------------------------------------------";
        public const int __3600_sortIndex = 3600;
        [SortOrder(__3600_sortIndex)]
        [DisplayName(__3600_displayName)]
        [IsReadOnly]
        public virtual byte __3600 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__3600));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__3600));
            }
        }

        public const string Punishing_Draw_Great_Sword_Attack_Power_displayName = "Punishing Draw (Great Sword) Attack Power";
        public const int Punishing_Draw_Great_Sword_Attack_Power_sortIndex = 3650;
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
        public const int Punishing_Draw_Great_Sword_Stun_sortIndex = 3700;
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
        public const int Punishing_Draw_Great_Sword_Exhaust_sortIndex = 3750;
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
        public const int Punishing_Draw_Great_Sword_Param_4_sortIndex = 3800;
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
        public const int Punishing_Draw_Great_Sword_Param_5_sortIndex = 3850;
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
        public const int Punishing_Draw_Great_Sword_Param_6_sortIndex = 3900;
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

        public const string __3950_displayName = "-------------------------------------------------------------------------------------------";
        public const int __3950_sortIndex = 3950;
        [SortOrder(__3950_sortIndex)]
        [DisplayName(__3950_displayName)]
        [IsReadOnly]
        public virtual byte __3950 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__3950));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__3950));
            }
        }

        public const string Punishing_Draw_Sword_Shield_Attack_Power_displayName = "Punishing Draw (Sword & Shield) Attack Power";
        public const int Punishing_Draw_Sword_Shield_Attack_Power_sortIndex = 4000;
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
        public const int Punishing_Draw_Sword_Shield_Stun_sortIndex = 4050;
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
        public const int Punishing_Draw_Sword_Shield_Exhaust_sortIndex = 4100;
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
        public const int Punishing_Draw_Sword_Shield_Param_4_sortIndex = 4150;
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
        public const int Punishing_Draw_Sword_Shield_Param_5_sortIndex = 4200;
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
        public const int Punishing_Draw_Sword_Shield_Param_6_sortIndex = 4250;
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

        public const string __4300_displayName = "-------------------------------------------------------------------------------------------";
        public const int __4300_sortIndex = 4300;
        [SortOrder(__4300_sortIndex)]
        [DisplayName(__4300_displayName)]
        [IsReadOnly]
        public virtual byte __4300 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__4300));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__4300));
            }
        }

        public const string Punishing_Draw_Dual_Blades_Attack_Power_displayName = "Punishing Draw (Dual Blades) Attack Power";
        public const int Punishing_Draw_Dual_Blades_Attack_Power_sortIndex = 4350;
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
        public const int Punishing_Draw_Dual_Blades_Stun_sortIndex = 4400;
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
        public const int Punishing_Draw_Dual_Blades_Exhaust_sortIndex = 4450;
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
        public const int Punishing_Draw_Dual_Blades_Param_4_sortIndex = 4500;
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
        public const int Punishing_Draw_Dual_Blades_Param_5_sortIndex = 4550;
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
        public const int Punishing_Draw_Dual_Blades_Param_6_sortIndex = 4600;
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

        public const string __4650_displayName = "-------------------------------------------------------------------------------------------";
        public const int __4650_sortIndex = 4650;
        [SortOrder(__4650_sortIndex)]
        [DisplayName(__4650_displayName)]
        [IsReadOnly]
        public virtual byte __4650 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__4650));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__4650));
            }
        }

        public const string Punishing_Draw_Long_Sword_Attack_Power_displayName = "Punishing Draw (Long Sword) Attack Power";
        public const int Punishing_Draw_Long_Sword_Attack_Power_sortIndex = 4700;
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
        public const int Punishing_Draw_Long_Sword_Stun_sortIndex = 4750;
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
        public const int Punishing_Draw_Long_Sword_Exhaust_sortIndex = 4800;
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
        public const int Punishing_Draw_Long_Sword_Param_4_sortIndex = 4850;
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
        public const int Punishing_Draw_Long_Sword_Param_5_sortIndex = 4900;
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
        public const int Punishing_Draw_Long_Sword_Param_6_sortIndex = 4950;
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

        public const string __5000_displayName = "-------------------------------------------------------------------------------------------";
        public const int __5000_sortIndex = 5000;
        [SortOrder(__5000_sortIndex)]
        [DisplayName(__5000_displayName)]
        [IsReadOnly]
        public virtual byte __5000 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__5000));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__5000));
            }
        }

        public const string Punishing_Draw_Hammer_Attack_Power_displayName = "Punishing Draw (Hammer) Attack Power";
        public const int Punishing_Draw_Hammer_Attack_Power_sortIndex = 5050;
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
        public const int Punishing_Draw_Hammer_Stun_sortIndex = 5100;
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
        public const int Punishing_Draw_Hammer_Exhaust_sortIndex = 5150;
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
        public const int Punishing_Draw_Hammer_Param_4_sortIndex = 5200;
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
        public const int Punishing_Draw_Hammer_Param_5_sortIndex = 5250;
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
        public const int Punishing_Draw_Hammer_Param_6_sortIndex = 5300;
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

        public const string __5350_displayName = "-------------------------------------------------------------------------------------------";
        public const int __5350_sortIndex = 5350;
        [SortOrder(__5350_sortIndex)]
        [DisplayName(__5350_displayName)]
        [IsReadOnly]
        public virtual byte __5350 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__5350));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__5350));
            }
        }

        public const string Punishing_Draw_Hunting_Horn_Attack_Power_displayName = "Punishing Draw (Hunting Horn) Attack Power";
        public const int Punishing_Draw_Hunting_Horn_Attack_Power_sortIndex = 5400;
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
        public const int Punishing_Draw_Hunting_Horn_Stun_sortIndex = 5450;
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
        public const int Punishing_Draw_Hunting_Horn_Exhaust_sortIndex = 5500;
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
        public const int Punishing_Draw_Hunting_Horn_Param_4_sortIndex = 5550;
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
        public const int Punishing_Draw_Hunting_Horn_Param_5_sortIndex = 5600;
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
        public const int Punishing_Draw_Hunting_Horn_Param_6_sortIndex = 5650;
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

        public const string __5700_displayName = "-------------------------------------------------------------------------------------------";
        public const int __5700_sortIndex = 5700;
        [SortOrder(__5700_sortIndex)]
        [DisplayName(__5700_displayName)]
        [IsReadOnly]
        public virtual byte __5700 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__5700));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__5700));
            }
        }

        public const string Punishing_Draw_Lance_Attack_Power_displayName = "Punishing Draw (Lance) Attack Power";
        public const int Punishing_Draw_Lance_Attack_Power_sortIndex = 5750;
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
        public const int Punishing_Draw_Lance_Stun_sortIndex = 5800;
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
        public const int Punishing_Draw_Lance_Exhaust_sortIndex = 5850;
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
        public const int Punishing_Draw_Lance_Param_4_sortIndex = 5900;
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
        public const int Punishing_Draw_Lance_Param_5_sortIndex = 5950;
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
        public const int Punishing_Draw_Lance_Param_6_sortIndex = 6000;
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

        public const string __6050_displayName = "-------------------------------------------------------------------------------------------";
        public const int __6050_sortIndex = 6050;
        [SortOrder(__6050_sortIndex)]
        [DisplayName(__6050_displayName)]
        [IsReadOnly]
        public virtual byte __6050 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__6050));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__6050));
            }
        }

        public const string Punishing_Draw_Gunlance_Attack_Power_displayName = "Punishing Draw (Gunlance) Attack Power";
        public const int Punishing_Draw_Gunlance_Attack_Power_sortIndex = 6100;
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
        public const int Punishing_Draw_Gunlance_Stun_sortIndex = 6150;
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
        public const int Punishing_Draw_Gunlance_Exhaust_sortIndex = 6200;
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
        public const int Punishing_Draw_Gunlance_Param_4_sortIndex = 6250;
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
        public const int Punishing_Draw_Gunlance_Param_5_sortIndex = 6300;
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
        public const int Punishing_Draw_Gunlance_Param_6_sortIndex = 6350;
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

        public const string __6400_displayName = "-------------------------------------------------------------------------------------------";
        public const int __6400_sortIndex = 6400;
        [SortOrder(__6400_sortIndex)]
        [DisplayName(__6400_displayName)]
        [IsReadOnly]
        public virtual byte __6400 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__6400));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__6400));
            }
        }

        public const string Punishing_Draw_Switch_Axe_Attack_Power_displayName = "Punishing Draw (Switch Axe) Attack Power";
        public const int Punishing_Draw_Switch_Axe_Attack_Power_sortIndex = 6450;
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
        public const int Punishing_Draw_Switch_Axe_Stun_sortIndex = 6500;
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
        public const int Punishing_Draw_Switch_Axe_Exhaust_sortIndex = 6550;
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
        public const int Punishing_Draw_Switch_Axe_Param_4_sortIndex = 6600;
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
        public const int Punishing_Draw_Switch_Axe_Param_5_sortIndex = 6650;
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
        public const int Punishing_Draw_Switch_Axe_Param_6_sortIndex = 6700;
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

        public const string __6750_displayName = "-------------------------------------------------------------------------------------------";
        public const int __6750_sortIndex = 6750;
        [SortOrder(__6750_sortIndex)]
        [DisplayName(__6750_displayName)]
        [IsReadOnly]
        public virtual byte __6750 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__6750));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__6750));
            }
        }

        public const string Punishing_Draw_Charge_Blade_Attack_Power_displayName = "Punishing Draw (Charge Blade) Attack Power";
        public const int Punishing_Draw_Charge_Blade_Attack_Power_sortIndex = 6800;
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
        public const int Punishing_Draw_Charge_Blade_Stun_sortIndex = 6850;
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
        public const int Punishing_Draw_Charge_Blade_Exhaust_sortIndex = 6900;
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
        public const int Punishing_Draw_Charge_Blade_Param_4_sortIndex = 6950;
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
        public const int Punishing_Draw_Charge_Blade_Param_5_sortIndex = 7000;
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
        public const int Punishing_Draw_Charge_Blade_Param_6_sortIndex = 7050;
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

        public const string __7100_displayName = "-------------------------------------------------------------------------------------------";
        public const int __7100_sortIndex = 7100;
        [SortOrder(__7100_sortIndex)]
        [DisplayName(__7100_displayName)]
        [IsReadOnly]
        public virtual byte __7100 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__7100));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__7100));
            }
        }

        public const string Punishing_Draw_Insect_Glaive_Attack_Power_displayName = "Punishing Draw (Insect Glaive) Attack Power";
        public const int Punishing_Draw_Insect_Glaive_Attack_Power_sortIndex = 7150;
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
        public const int Punishing_Draw_Insect_Glaive_Stun_sortIndex = 7200;
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
        public const int Punishing_Draw_Insect_Glaive_Exhaust_sortIndex = 7250;
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
        public const int Punishing_Draw_Insect_Glaive_Param_4_sortIndex = 7300;
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
        public const int Punishing_Draw_Insect_Glaive_Param_5_sortIndex = 7350;
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
        public const int Punishing_Draw_Insect_Glaive_Param_6_sortIndex = 7400;
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

        public const string __7450_displayName = "-------------------------------------------------------------------------------------------";
        public const int __7450_sortIndex = 7450;
        [SortOrder(__7450_sortIndex)]
        [DisplayName(__7450_displayName)]
        [IsReadOnly]
        public virtual byte __7450 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__7450));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__7450));
            }
        }

        public const string Punishing_Draw_Bow_Attack_Power_displayName = "Punishing Draw (Bow) Attack Power";
        public const int Punishing_Draw_Bow_Attack_Power_sortIndex = 7500;
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
        public const int Punishing_Draw_Bow_Stun_sortIndex = 7550;
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
        public const int Punishing_Draw_Bow_Exhaust_sortIndex = 7600;
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
        public const int Punishing_Draw_Bow_Param_4_sortIndex = 7650;
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
        public const int Punishing_Draw_Bow_Param_5_sortIndex = 7700;
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
        public const int Punishing_Draw_Bow_Param_6_sortIndex = 7750;
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

        public const string __7800_displayName = "-------------------------------------------------------------------------------------------";
        public const int __7800_sortIndex = 7800;
        [SortOrder(__7800_sortIndex)]
        [DisplayName(__7800_displayName)]
        [IsReadOnly]
        public virtual byte __7800 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__7800));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__7800));
            }
        }

        public const string Punishing_Draw_HBG_Attack_Power_displayName = "Punishing Draw (HBG) Attack Power";
        public const int Punishing_Draw_HBG_Attack_Power_sortIndex = 7850;
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
        public const int Punishing_Draw_HBG_Stun_sortIndex = 7900;
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
        public const int Punishing_Draw_HBG_Exhaust_sortIndex = 7950;
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
        public const int Punishing_Draw_HBG_Param_4_sortIndex = 8000;
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
        public const int Punishing_Draw_HBG_Param_5_sortIndex = 8050;
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
        public const int Punishing_Draw_HBG_Param_6_sortIndex = 8100;
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

        public const string __8150_displayName = "-------------------------------------------------------------------------------------------";
        public const int __8150_sortIndex = 8150;
        [SortOrder(__8150_sortIndex)]
        [DisplayName(__8150_displayName)]
        [IsReadOnly]
        public virtual byte __8150 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__8150));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__8150));
            }
        }

        public const string Punishing_Draw_LBG_Attack_Power_displayName = "Punishing Draw (LBG) Attack Power";
        public const int Punishing_Draw_LBG_Attack_Power_sortIndex = 8200;
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
        public const int Punishing_Draw_LBG_Stun_sortIndex = 8250;
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
        public const int Punishing_Draw_LBG_Exhaust_sortIndex = 8300;
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
        public const int Punishing_Draw_LBG_Param_4_sortIndex = 8350;
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
        public const int Punishing_Draw_LBG_Param_5_sortIndex = 8400;
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
        public const int Punishing_Draw_LBG_Param_6_sortIndex = 8450;
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

        public const string __8500_displayName = "-------------------------------------------------------------------------------------------";
        public const int __8500_sortIndex = 8500;
        [SortOrder(__8500_sortIndex)]
        [DisplayName(__8500_displayName)]
        [IsReadOnly]
        public virtual byte __8500 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__8500));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__8500));
            }
        }

        public const string Razor_Sharp_Sharpness_No_Reduce__displayName = "Razor Sharp: Sharpness No Reduce %";
        public const int Razor_Sharp_Sharpness_No_Reduce__sortIndex = 8550;
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
        public const int Razor_Sharp_Gunlance_Shot_Sub_Value_sortIndex = 8600;
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
        public const int Razor_Sharp_Gunlance_Shot_No_Reduce__sortIndex = 8650;
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
        public const int Razor_Sharp_Gun_Ammo_No_Reduce__sortIndex = 8700;
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
        public const int Razor_Sharp_Bow_Coating_No_Reduce__sortIndex = 8750;
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

        public const string Razor_Sharp_Guard_Consumption__displayName = "Razor Sharp: Guard Consumption %";
        public const int Razor_Sharp_Guard_Consumption__sortIndex = 8800;
        [SortOrder(Razor_Sharp_Guard_Consumption__sortIndex)]
        [DisplayName(Razor_Sharp_Guard_Consumption__displayName)]
        public virtual byte Razor_Sharp_Guard_Consumption_ {
            get => GetData<byte>(419);
            set {
                if (GetData<byte>(419) == value) return;
                SetData(419, value, nameof(Razor_Sharp_Guard_Consumption_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Razor_Sharp_Guard_Consumption_));
            }
        }

        public const string __8850_displayName = "-------------------------------------------------------------------------------------------";
        public const int __8850_sortIndex = 8850;
        [SortOrder(__8850_sortIndex)]
        [DisplayName(__8850_displayName)]
        [IsReadOnly]
        public virtual byte __8850 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__8850));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__8850));
            }
        }

        public const string True_Razor_Sharp_Sharpness_No_Reduce__displayName = "True Razor Sharp: Sharpness No Reduce %";
        public const int True_Razor_Sharp_Sharpness_No_Reduce__sortIndex = 8900;
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
        public const int True_Razor_Sharp_Gunlance_Shot_Sub_Value_sortIndex = 8950;
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
        public const int True_Razor_Sharp_Gunlance_Shot_No_Reduce__sortIndex = 9000;
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
        public const int True_Razor_Sharp_Gun_Ammo_No_Reduce__sortIndex = 9050;
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
        public const int True_Razor_Sharp_Bow_Coating_No_Reduce__sortIndex = 9100;
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

        public const string True_Razor_Sharp_Guard_Consumption__displayName = "True Razor Sharp: Guard Consumption %";
        public const int True_Razor_Sharp_Guard_Consumption__sortIndex = 9150;
        [SortOrder(True_Razor_Sharp_Guard_Consumption__sortIndex)]
        [DisplayName(True_Razor_Sharp_Guard_Consumption__displayName)]
        public virtual byte True_Razor_Sharp_Guard_Consumption_ {
            get => GetData<byte>(425);
            set {
                if (GetData<byte>(425) == value) return;
                SetData(425, value, nameof(True_Razor_Sharp_Guard_Consumption_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(True_Razor_Sharp_Guard_Consumption_));
            }
        }

        public const string __9200_displayName = "-------------------------------------------------------------------------------------------";
        public const int __9200_sortIndex = 9200;
        [SortOrder(__9200_sortIndex)]
        [DisplayName(__9200_displayName)]
        [IsReadOnly]
        public virtual byte __9200 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__9200));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__9200));
            }
        }

        public const string Minds_Eye_Ballistics_Gun_Critical_Begin_Wide_Rate_displayName = "Minds Eye / Ballistics: Gun Critical Begin Wide Rate";
        public const int Minds_Eye_Ballistics_Gun_Critical_Begin_Wide_Rate_sortIndex = 9250;
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
        public const int Minds_Eye_Ballistics_Gun_Critical_End_Wide_Rate_sortIndex = 9300;
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
        public const int Minds_Eye_Ballistics_Bow_Critical_Begin_Wide_Rate_sortIndex = 9350;
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
        public const int Minds_Eye_Ballistics_Bow_Critical_End_Wide_Rate_sortIndex = 9400;
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

        public const string __9450_displayName = "-------------------------------------------------------------------------------------------";
        public const int __9450_sortIndex = 9450;
        [SortOrder(__9450_sortIndex)]
        [DisplayName(__9450_displayName)]
        [IsReadOnly]
        public virtual byte __9450 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__9450));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__9450));
            }
        }

        public const string Critical_Element_Great_Sword_Rate_displayName = "Critical Element: (Great Sword) Rate";
        public const int Critical_Element_Great_Sword_Rate_sortIndex = 9500;
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
        public const int Critical_Element_Sword_Shield_Rate_sortIndex = 9550;
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
        public const int Critical_Element_Dual_Blades_Rate_sortIndex = 9600;
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
        public const int Critical_Element_Long_Sword_Rate_sortIndex = 9650;
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
        public const int Critical_Element_Hammer_Rate_sortIndex = 9700;
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
        public const int Critical_Element_Hunting_Horn_Rate_sortIndex = 9750;
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
        public const int Critical_Element_Lance_Rate_sortIndex = 9800;
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
        public const int Critical_Element_Gunlance_Rate_sortIndex = 9850;
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
        public const int Critical_Element_Switch_Axe_Rate_sortIndex = 9900;
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
        public const int Critical_Element_Charge_Blade_Rate_sortIndex = 9950;
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
        public const int Critical_Element_Insect_Glaive_Rate_sortIndex = 10000;
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
        public const int Critical_Element_Bow_Rate_sortIndex = 10050;
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
        public const int Critical_Element_HBG_Rate_sortIndex = 10100;
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
        public const int Critical_Element_LBG_Rate_sortIndex = 10150;
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
        public const int Critical_Element_Dragon_Seal_Rate_sortIndex = 10200;
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

        public const string __10250_displayName = "-------------------------------------------------------------------------------------------";
        public const int __10250_sortIndex = 10250;
        [SortOrder(__10250_sortIndex)]
        [DisplayName(__10250_displayName)]
        [IsReadOnly]
        public virtual byte __10250 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__10250));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__10250));
            }
        }

        public const string True_Critical_Element_Great_Sword_Rate_displayName = "True Critical Element: (Great Sword) Rate";
        public const int True_Critical_Element_Great_Sword_Rate_sortIndex = 10300;
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
        public const int True_Critical_Element_Sword_Shield_Rate_sortIndex = 10350;
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
        public const int True_Critical_Element_Dual_Blades_Rate_sortIndex = 10400;
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
        public const int True_Critical_Element_Long_Sword_Rate_sortIndex = 10450;
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
        public const int True_Critical_Element_Hammer_Rate_sortIndex = 10500;
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
        public const int True_Critical_Element_Hunting_Horn_Rate_sortIndex = 10550;
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
        public const int True_Critical_Element_Lance_Rate_sortIndex = 10600;
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
        public const int True_Critical_Element_Gunlance_Rate_sortIndex = 10650;
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
        public const int True_Critical_Element_Switch_Axe_Rate_sortIndex = 10700;
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
        public const int True_Critical_Element_Charge_Blade_Rate_sortIndex = 10750;
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
        public const int True_Critical_Element_Insect_Glaive_Rate_sortIndex = 10800;
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
        public const int True_Critical_Element_Bow_Rate_sortIndex = 10850;
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
        public const int True_Critical_Element_HBG_Rate_sortIndex = 10900;
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
        public const int True_Critical_Element_LBG_Rate_sortIndex = 10950;
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
        public const int True_Critical_Element_Dragon_Seal_Rate_sortIndex = 11000;
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

        public const string __11050_displayName = "-------------------------------------------------------------------------------------------";
        public const int __11050_sortIndex = 11050;
        [SortOrder(__11050_sortIndex)]
        [DisplayName(__11050_displayName)]
        [IsReadOnly]
        public virtual byte __11050 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__11050));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__11050));
            }
        }

        public const string Critical_Condition_Great_Sword_Rate_displayName = "Critical Condition: (Great Sword) Rate";
        public const int Critical_Condition_Great_Sword_Rate_sortIndex = 11100;
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
        public const int Critical_Condition_Sword_Shield_Rate_sortIndex = 11150;
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
        public const int Critical_Condition_Dual_Blades_Rate_sortIndex = 11200;
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
        public const int Critical_Condition_Long_Sword_Rate_sortIndex = 11250;
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
        public const int Critical_Condition_Hammer_Rate_sortIndex = 11300;
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
        public const int Critical_Condition_Hunting_Horn_Rate_sortIndex = 11350;
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
        public const int Critical_Condition_Lance_Rate_sortIndex = 11400;
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
        public const int Critical_Condition_Gunlance_Rate_sortIndex = 11450;
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
        public const int Critical_Condition_Switch_Axe_Rate_sortIndex = 11500;
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
        public const int Critical_Condition_Charge_Blade_Rate_sortIndex = 11550;
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
        public const int Critical_Condition_Insect_Glaive_Rate_sortIndex = 11600;
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
        public const int Critical_Condition_Bow_Rate_sortIndex = 11650;
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
        public const int Critical_Condition_HBG_Rate_sortIndex = 11700;
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
        public const int Critical_Condition_LBG_Rate_sortIndex = 11750;
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

        public const string __11800_displayName = "-------------------------------------------------------------------------------------------";
        public const int __11800_sortIndex = 11800;
        [SortOrder(__11800_sortIndex)]
        [DisplayName(__11800_displayName)]
        [IsReadOnly]
        public virtual byte __11800 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__11800));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__11800));
            }
        }

        public const string True_Critical_Condition_Great_Sword_Rate_displayName = "True Critical Condition: (Great Sword) Rate";
        public const int True_Critical_Condition_Great_Sword_Rate_sortIndex = 11850;
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
        public const int True_Critical_Condition_Sword_Shield_Rate_sortIndex = 11900;
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
        public const int True_Critical_Condition_Dual_Blades_Rate_sortIndex = 11950;
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
        public const int True_Critical_Condition_Long_Sword_Rate_sortIndex = 12000;
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
        public const int True_Critical_Condition_Hammer_Rate_sortIndex = 12050;
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
        public const int True_Critical_Condition_Hunting_Horn_Rate_sortIndex = 12100;
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
        public const int True_Critical_Condition_Lance_Rate_sortIndex = 12150;
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
        public const int True_Critical_Condition_Gunlance_Rate_sortIndex = 12200;
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
        public const int True_Critical_Condition_Switch_Axe_Rate_sortIndex = 12250;
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
        public const int True_Critical_Condition_Charge_Blade_Rate_sortIndex = 12300;
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
        public const int True_Critical_Condition_Insect_Glaive_Rate_sortIndex = 12350;
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
        public const int True_Critical_Condition_Bow_Rate_sortIndex = 12400;
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
        public const int True_Critical_Condition_HBG_Rate_sortIndex = 12450;
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
        public const int True_Critical_Condition_LBG_Rate_sortIndex = 12500;
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

        public const string __12550_displayName = "-------------------------------------------------------------------------------------------";
        public const int __12550_sortIndex = 12550;
        [SortOrder(__12550_sortIndex)]
        [DisplayName(__12550_displayName)]
        [IsReadOnly]
        public virtual byte __12550 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__12550));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__12550));
            }
        }

        public const string Bludgeoner_Red_Sharpness_Attack_Bonus_BG_Melee__displayName = "Bludgeoner: Red Sharpness Attack Bonus (& BG Melee)";
        public const int Bludgeoner_Red_Sharpness_Attack_Bonus_BG_Melee__sortIndex = 12600;
        [SortOrder(Bludgeoner_Red_Sharpness_Attack_Bonus_BG_Melee__sortIndex)]
        [DisplayName(Bludgeoner_Red_Sharpness_Attack_Bonus_BG_Melee__displayName)]
        public virtual ushort Bludgeoner_Red_Sharpness_Attack_Bonus_BG_Melee_ {
            get => GetData<ushort>(674);
            set {
                if (GetData<ushort>(674) == value) return;
                SetData(674, value, nameof(Bludgeoner_Red_Sharpness_Attack_Bonus_BG_Melee_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Bludgeoner_Red_Sharpness_Attack_Bonus_BG_Melee_));
            }
        }

        public const string Bludgeoner_Orange_Sharpness_Attack_Bonus_displayName = "Bludgeoner: Orange Sharpness Attack Bonus";
        public const int Bludgeoner_Orange_Sharpness_Attack_Bonus_sortIndex = 12650;
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
        public const int Bludgeoner_Yellow_Sharpness_Attack_Bonus_sortIndex = 12700;
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
        public const int Bludgeoner_Green_Sharpness_Attack_Bonus_sortIndex = 12750;
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
        public const int Bludgeoner_Blue_Sharpness_Attack_Bonus_sortIndex = 12800;
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
        public const int Bludgeoner_White_Sharpness_Attack_Bonus_sortIndex = 12850;
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
        public const int Bludgeoner_Purple_Sharpness_Attack_Bonus_sortIndex = 12900;
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
        public const int Bludgeoner_Bowgun_Melee_Attack_Stun_Bonus_sortIndex = 12950;
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

        public const string __13000_displayName = "-------------------------------------------------------------------------------------------";
        public const int __13000_sortIndex = 13000;
        [SortOrder(__13000_sortIndex)]
        [DisplayName(__13000_displayName)]
        [IsReadOnly]
        public virtual byte __13000 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__13000));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__13000));
            }
        }

        public const string Non_Elemental_Boost_Attack_Multiplier_displayName = "Non-Elemental Boost: Attack Multiplier";
        public const int Non_Elemental_Boost_Attack_Multiplier_sortIndex = 13050;
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

        public const string __13100_displayName = "-------------------------------------------------------------------------------------------";
        public const int __13100_sortIndex = 13100;
        [SortOrder(__13100_sortIndex)]
        [DisplayName(__13100_displayName)]
        [IsReadOnly]
        public virtual byte __13100 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__13100));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__13100));
            }
        }

        public const string Affinity_Slider_Attack_Up_Activate_Time_displayName = "Affinity Slider: Attack Up Activate Time";
        public const int Affinity_Slider_Attack_Up_Activate_Time_sortIndex = 13150;
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
        public const int Affinity_Slider_Attack_Up_Duration_sortIndex = 13200;
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
        public const int Affinity_Slider_Attack_Critical_Bonus_sortIndex = 13250;
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

        public const string __13300_displayName = "-------------------------------------------------------------------------------------------";
        public const int __13300_sortIndex = 13300;
        [SortOrder(__13300_sortIndex)]
        [DisplayName(__13300_displayName)]
        [IsReadOnly]
        public virtual byte __13300 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__13300));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__13300));
            }
        }

        public const string Artillery_Gunlance_Shell_Attack_Rate_1_displayName = "Artillery: Gunlance Shell Attack Rate 1";
        public const int Artillery_Gunlance_Shell_Attack_Rate_1_sortIndex = 13350;
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
        public const int Artillery_Gunlance_Shell_Attack_Rate_2_sortIndex = 13400;
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
        public const int Artillery_Gunlance_Shell_Attack_Rate_3_sortIndex = 13450;
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
        public const int Artillery_Gunlance_Shell_Attack_Rate_4_sortIndex = 13500;
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
        public const int Artillery_Gunlance_Shell_Attack_Rate_5_sortIndex = 13550;
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

        public const string __13600_displayName = "-------------------------------------------------------------------------------------------";
        public const int __13600_sortIndex = 13600;
        [SortOrder(__13600_sortIndex)]
        [DisplayName(__13600_displayName)]
        [IsReadOnly]
        public virtual byte __13600 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__13600));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__13600));
            }
        }

        public const string Artillery_Gunlance_WyvernFire_Attack_Rate_1_displayName = "Artillery: Gunlance WyvernFire Attack Rate 1";
        public const int Artillery_Gunlance_WyvernFire_Attack_Rate_1_sortIndex = 13650;
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
        public const int Artillery_Gunlance_WyvernFire_Attack_Rate_2_sortIndex = 13700;
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
        public const int Artillery_Gunlance_WyvernFire_Attack_Rate_3_sortIndex = 13750;
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
        public const int Artillery_Gunlance_WyvernFire_Attack_Rate_4_sortIndex = 13800;
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
        public const int Artillery_Gunlance_WyvernFire_Attack_Rate_5_sortIndex = 13850;
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

        public const string __13900_displayName = "-------------------------------------------------------------------------------------------";
        public const int __13900_sortIndex = 13900;
        [SortOrder(__13900_sortIndex)]
        [DisplayName(__13900_displayName)]
        [IsReadOnly]
        public virtual byte __13900 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__13900));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__13900));
            }
        }

        public const string Artillery_Gunlance_Wyrmstake_Cannon_Attack_Rate_1_displayName = "Artillery: Gunlance Wyrmstake Cannon Attack Rate 1";
        public const int Artillery_Gunlance_Wyrmstake_Cannon_Attack_Rate_1_sortIndex = 13950;
        [SortOrder(Artillery_Gunlance_Wyrmstake_Cannon_Attack_Rate_1_sortIndex)]
        [DisplayName(Artillery_Gunlance_Wyrmstake_Cannon_Attack_Rate_1_displayName)]
        public virtual float Artillery_Gunlance_Wyrmstake_Cannon_Attack_Rate_1 {
            get => GetData<float>(743);
            set {
                if (GetData<float>(743) == value) return;
                SetData(743, value, nameof(Artillery_Gunlance_Wyrmstake_Cannon_Attack_Rate_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_Gunlance_Wyrmstake_Cannon_Attack_Rate_1));
            }
        }

        public const string Artillery_Gunlance_Wyrmstake_Cannon_Attack_Rate_2_displayName = "Artillery: Gunlance Wyrmstake Cannon Attack Rate 2";
        public const int Artillery_Gunlance_Wyrmstake_Cannon_Attack_Rate_2_sortIndex = 14000;
        [SortOrder(Artillery_Gunlance_Wyrmstake_Cannon_Attack_Rate_2_sortIndex)]
        [DisplayName(Artillery_Gunlance_Wyrmstake_Cannon_Attack_Rate_2_displayName)]
        public virtual float Artillery_Gunlance_Wyrmstake_Cannon_Attack_Rate_2 {
            get => GetData<float>(747);
            set {
                if (GetData<float>(747) == value) return;
                SetData(747, value, nameof(Artillery_Gunlance_Wyrmstake_Cannon_Attack_Rate_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_Gunlance_Wyrmstake_Cannon_Attack_Rate_2));
            }
        }

        public const string Artillery_Gunlance_Wyrmstake_Cannon_Attack_Rate_3_displayName = "Artillery: Gunlance Wyrmstake Cannon Attack Rate 3";
        public const int Artillery_Gunlance_Wyrmstake_Cannon_Attack_Rate_3_sortIndex = 14050;
        [SortOrder(Artillery_Gunlance_Wyrmstake_Cannon_Attack_Rate_3_sortIndex)]
        [DisplayName(Artillery_Gunlance_Wyrmstake_Cannon_Attack_Rate_3_displayName)]
        public virtual float Artillery_Gunlance_Wyrmstake_Cannon_Attack_Rate_3 {
            get => GetData<float>(751);
            set {
                if (GetData<float>(751) == value) return;
                SetData(751, value, nameof(Artillery_Gunlance_Wyrmstake_Cannon_Attack_Rate_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_Gunlance_Wyrmstake_Cannon_Attack_Rate_3));
            }
        }

        public const string Artillery_Gunlance_Wyrmstake_Cannon_Attack_Rate_4_displayName = "Artillery: Gunlance Wyrmstake Cannon Attack Rate 4";
        public const int Artillery_Gunlance_Wyrmstake_Cannon_Attack_Rate_4_sortIndex = 14100;
        [SortOrder(Artillery_Gunlance_Wyrmstake_Cannon_Attack_Rate_4_sortIndex)]
        [DisplayName(Artillery_Gunlance_Wyrmstake_Cannon_Attack_Rate_4_displayName)]
        public virtual float Artillery_Gunlance_Wyrmstake_Cannon_Attack_Rate_4 {
            get => GetData<float>(755);
            set {
                if (GetData<float>(755) == value) return;
                SetData(755, value, nameof(Artillery_Gunlance_Wyrmstake_Cannon_Attack_Rate_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_Gunlance_Wyrmstake_Cannon_Attack_Rate_4));
            }
        }

        public const string Artillery_Gunlance_Wyrmstake_Cannon_Attack_Rate_5_displayName = "Artillery: Gunlance Wyrmstake Cannon Attack Rate 5";
        public const int Artillery_Gunlance_Wyrmstake_Cannon_Attack_Rate_5_sortIndex = 14150;
        [SortOrder(Artillery_Gunlance_Wyrmstake_Cannon_Attack_Rate_5_sortIndex)]
        [DisplayName(Artillery_Gunlance_Wyrmstake_Cannon_Attack_Rate_5_displayName)]
        public virtual float Artillery_Gunlance_Wyrmstake_Cannon_Attack_Rate_5 {
            get => GetData<float>(759);
            set {
                if (GetData<float>(759) == value) return;
                SetData(759, value, nameof(Artillery_Gunlance_Wyrmstake_Cannon_Attack_Rate_5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_Gunlance_Wyrmstake_Cannon_Attack_Rate_5));
            }
        }

        public const string __14200_displayName = "-------------------------------------------------------------------------------------------";
        public const int __14200_sortIndex = 14200;
        [SortOrder(__14200_sortIndex)]
        [DisplayName(__14200_displayName)]
        [IsReadOnly]
        public virtual byte __14200 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__14200));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__14200));
            }
        }

        public const string Artillery_Gunlance_WyvernFire_Cooldown_Time_Rate_1_displayName = "Artillery: Gunlance WyvernFire Cooldown Time Rate 1";
        public const int Artillery_Gunlance_WyvernFire_Cooldown_Time_Rate_1_sortIndex = 14250;
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
        public const int Artillery_Gunlance_WyvernFire_Cooldown_Time_Rate_2_sortIndex = 14300;
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
        public const int Artillery_Gunlance_WyvernFire_Cooldown_Time_Rate_3_sortIndex = 14350;
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
        public const int Artillery_Gunlance_WyvernFire_Cooldown_Time_Rate_4_sortIndex = 14400;
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
        public const int Artillery_Gunlance_WyvernFire_Cooldown_Time_Rate_5_sortIndex = 14450;
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

        public const string __14500_displayName = "-------------------------------------------------------------------------------------------";
        public const int __14500_sortIndex = 14500;
        [SortOrder(__14500_sortIndex)]
        [DisplayName(__14500_displayName)]
        [IsReadOnly]
        public virtual byte __14500 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__14500));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__14500));
            }
        }

        public const string Artillery_Charge_Blade_Impact_Phial_Attack_Rate_1_displayName = "Artillery: Charge Blade Impact Phial Attack Rate 1";
        public const int Artillery_Charge_Blade_Impact_Phial_Attack_Rate_1_sortIndex = 14550;
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
        public const int Artillery_Charge_Blade_Impact_Phial_Attack_Rate_2_sortIndex = 14600;
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
        public const int Artillery_Charge_Blade_Impact_Phial_Attack_Rate_3_sortIndex = 14650;
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
        public const int Artillery_Charge_Blade_Impact_Phial_Attack_Rate_4_sortIndex = 14700;
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
        public const int Artillery_Charge_Blade_Impact_Phial_Attack_Rate_5_sortIndex = 14750;
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

        public const string __14800_displayName = "-------------------------------------------------------------------------------------------";
        public const int __14800_sortIndex = 14800;
        [SortOrder(__14800_sortIndex)]
        [DisplayName(__14800_displayName)]
        [IsReadOnly]
        public virtual byte __14800 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__14800));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__14800));
            }
        }

        public const string Artillery_Bowgun_Sticky_Ammo_Attack_Rate_1_displayName = "Artillery: Bowgun Sticky Ammo Attack Rate 1";
        public const int Artillery_Bowgun_Sticky_Ammo_Attack_Rate_1_sortIndex = 14850;
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
        public const int Artillery_Bowgun_Sticky_Ammo_Attack_Rate_2_sortIndex = 14900;
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
        public const int Artillery_Bowgun_Sticky_Ammo_Attack_Rate_3_sortIndex = 14950;
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
        public const int Artillery_Bowgun_Sticky_Ammo_Attack_Rate_4_sortIndex = 15000;
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
        public const int Artillery_Bowgun_Sticky_Ammo_Attack_Rate_5_sortIndex = 15050;
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

        public const string __15100_displayName = "-------------------------------------------------------------------------------------------";
        public const int __15100_sortIndex = 15100;
        [SortOrder(__15100_sortIndex)]
        [DisplayName(__15100_displayName)]
        [IsReadOnly]
        public virtual byte __15100 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__15100));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__15100));
            }
        }

        public const string Artillery_Bowgun_Kakusan_Attack_Rate_Appears_Unused_1_displayName = "Artillery: Bowgun Kakusan? Attack Rate (Appears Unused?) 1";
        public const int Artillery_Bowgun_Kakusan_Attack_Rate_Appears_Unused_1_sortIndex = 15150;
        [SortOrder(Artillery_Bowgun_Kakusan_Attack_Rate_Appears_Unused_1_sortIndex)]
        [DisplayName(Artillery_Bowgun_Kakusan_Attack_Rate_Appears_Unused_1_displayName)]
        public virtual float Artillery_Bowgun_Kakusan_Attack_Rate_Appears_Unused_1 {
            get => GetData<float>(823);
            set {
                if (GetData<float>(823) == value) return;
                SetData(823, value, nameof(Artillery_Bowgun_Kakusan_Attack_Rate_Appears_Unused_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_Bowgun_Kakusan_Attack_Rate_Appears_Unused_1));
            }
        }

        public const string Artillery_Bowgun_Kakusan_Attack_Rate_Appears_Unused_2_displayName = "Artillery: Bowgun Kakusan? Attack Rate (Appears Unused?) 2";
        public const int Artillery_Bowgun_Kakusan_Attack_Rate_Appears_Unused_2_sortIndex = 15200;
        [SortOrder(Artillery_Bowgun_Kakusan_Attack_Rate_Appears_Unused_2_sortIndex)]
        [DisplayName(Artillery_Bowgun_Kakusan_Attack_Rate_Appears_Unused_2_displayName)]
        public virtual float Artillery_Bowgun_Kakusan_Attack_Rate_Appears_Unused_2 {
            get => GetData<float>(827);
            set {
                if (GetData<float>(827) == value) return;
                SetData(827, value, nameof(Artillery_Bowgun_Kakusan_Attack_Rate_Appears_Unused_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_Bowgun_Kakusan_Attack_Rate_Appears_Unused_2));
            }
        }

        public const string Artillery_Bowgun_Kakusan_Attack_Rate_Appears_Unused_3_displayName = "Artillery: Bowgun Kakusan? Attack Rate (Appears Unused?) 3";
        public const int Artillery_Bowgun_Kakusan_Attack_Rate_Appears_Unused_3_sortIndex = 15250;
        [SortOrder(Artillery_Bowgun_Kakusan_Attack_Rate_Appears_Unused_3_sortIndex)]
        [DisplayName(Artillery_Bowgun_Kakusan_Attack_Rate_Appears_Unused_3_displayName)]
        public virtual float Artillery_Bowgun_Kakusan_Attack_Rate_Appears_Unused_3 {
            get => GetData<float>(831);
            set {
                if (GetData<float>(831) == value) return;
                SetData(831, value, nameof(Artillery_Bowgun_Kakusan_Attack_Rate_Appears_Unused_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_Bowgun_Kakusan_Attack_Rate_Appears_Unused_3));
            }
        }

        public const string Artillery_Bowgun_Kakusan_Attack_Rate_Appears_Unused_4_displayName = "Artillery: Bowgun Kakusan? Attack Rate (Appears Unused?) 4";
        public const int Artillery_Bowgun_Kakusan_Attack_Rate_Appears_Unused_4_sortIndex = 15300;
        [SortOrder(Artillery_Bowgun_Kakusan_Attack_Rate_Appears_Unused_4_sortIndex)]
        [DisplayName(Artillery_Bowgun_Kakusan_Attack_Rate_Appears_Unused_4_displayName)]
        public virtual float Artillery_Bowgun_Kakusan_Attack_Rate_Appears_Unused_4 {
            get => GetData<float>(835);
            set {
                if (GetData<float>(835) == value) return;
                SetData(835, value, nameof(Artillery_Bowgun_Kakusan_Attack_Rate_Appears_Unused_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_Bowgun_Kakusan_Attack_Rate_Appears_Unused_4));
            }
        }

        public const string Artillery_Bowgun_Kakusan_Attack_Rate_Appears_Unused_5_displayName = "Artillery: Bowgun Kakusan? Attack Rate (Appears Unused?) 5";
        public const int Artillery_Bowgun_Kakusan_Attack_Rate_Appears_Unused_5_sortIndex = 15350;
        [SortOrder(Artillery_Bowgun_Kakusan_Attack_Rate_Appears_Unused_5_sortIndex)]
        [DisplayName(Artillery_Bowgun_Kakusan_Attack_Rate_Appears_Unused_5_displayName)]
        public virtual float Artillery_Bowgun_Kakusan_Attack_Rate_Appears_Unused_5 {
            get => GetData<float>(839);
            set {
                if (GetData<float>(839) == value) return;
                SetData(839, value, nameof(Artillery_Bowgun_Kakusan_Attack_Rate_Appears_Unused_5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_Bowgun_Kakusan_Attack_Rate_Appears_Unused_5));
            }
        }

        public const string __15400_displayName = "-------------------------------------------------------------------------------------------";
        public const int __15400_sortIndex = 15400;
        [SortOrder(__15400_sortIndex)]
        [DisplayName(__15400_displayName)]
        [IsReadOnly]
        public virtual byte __15400 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__15400));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__15400));
            }
        }

        public const string Artillery_Bowgun_Wyvern_Ammo_Attack_Rate_1_displayName = "Artillery: Bowgun Wyvern Ammo Attack Rate 1";
        public const int Artillery_Bowgun_Wyvern_Ammo_Attack_Rate_1_sortIndex = 15450;
        [SortOrder(Artillery_Bowgun_Wyvern_Ammo_Attack_Rate_1_sortIndex)]
        [DisplayName(Artillery_Bowgun_Wyvern_Ammo_Attack_Rate_1_displayName)]
        public virtual float Artillery_Bowgun_Wyvern_Ammo_Attack_Rate_1 {
            get => GetData<float>(843);
            set {
                if (GetData<float>(843) == value) return;
                SetData(843, value, nameof(Artillery_Bowgun_Wyvern_Ammo_Attack_Rate_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_Bowgun_Wyvern_Ammo_Attack_Rate_1));
            }
        }

        public const string Artillery_Bowgun_Wyvern_Ammo_Attack_Rate_2_displayName = "Artillery: Bowgun Wyvern Ammo Attack Rate 2";
        public const int Artillery_Bowgun_Wyvern_Ammo_Attack_Rate_2_sortIndex = 15500;
        [SortOrder(Artillery_Bowgun_Wyvern_Ammo_Attack_Rate_2_sortIndex)]
        [DisplayName(Artillery_Bowgun_Wyvern_Ammo_Attack_Rate_2_displayName)]
        public virtual float Artillery_Bowgun_Wyvern_Ammo_Attack_Rate_2 {
            get => GetData<float>(847);
            set {
                if (GetData<float>(847) == value) return;
                SetData(847, value, nameof(Artillery_Bowgun_Wyvern_Ammo_Attack_Rate_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_Bowgun_Wyvern_Ammo_Attack_Rate_2));
            }
        }

        public const string Artillery_Bowgun_Wyvern_Ammo_Attack_Rate_3_displayName = "Artillery: Bowgun Wyvern Ammo Attack Rate 3";
        public const int Artillery_Bowgun_Wyvern_Ammo_Attack_Rate_3_sortIndex = 15550;
        [SortOrder(Artillery_Bowgun_Wyvern_Ammo_Attack_Rate_3_sortIndex)]
        [DisplayName(Artillery_Bowgun_Wyvern_Ammo_Attack_Rate_3_displayName)]
        public virtual float Artillery_Bowgun_Wyvern_Ammo_Attack_Rate_3 {
            get => GetData<float>(851);
            set {
                if (GetData<float>(851) == value) return;
                SetData(851, value, nameof(Artillery_Bowgun_Wyvern_Ammo_Attack_Rate_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_Bowgun_Wyvern_Ammo_Attack_Rate_3));
            }
        }

        public const string Artillery_Bowgun_Wyvern_Ammo_Attack_Rate_4_displayName = "Artillery: Bowgun Wyvern Ammo Attack Rate 4";
        public const int Artillery_Bowgun_Wyvern_Ammo_Attack_Rate_4_sortIndex = 15600;
        [SortOrder(Artillery_Bowgun_Wyvern_Ammo_Attack_Rate_4_sortIndex)]
        [DisplayName(Artillery_Bowgun_Wyvern_Ammo_Attack_Rate_4_displayName)]
        public virtual float Artillery_Bowgun_Wyvern_Ammo_Attack_Rate_4 {
            get => GetData<float>(855);
            set {
                if (GetData<float>(855) == value) return;
                SetData(855, value, nameof(Artillery_Bowgun_Wyvern_Ammo_Attack_Rate_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_Bowgun_Wyvern_Ammo_Attack_Rate_4));
            }
        }

        public const string Artillery_Bowgun_Wyvern_Ammo_Attack_Rate_5_displayName = "Artillery: Bowgun Wyvern Ammo Attack Rate 5";
        public const int Artillery_Bowgun_Wyvern_Ammo_Attack_Rate_5_sortIndex = 15650;
        [SortOrder(Artillery_Bowgun_Wyvern_Ammo_Attack_Rate_5_sortIndex)]
        [DisplayName(Artillery_Bowgun_Wyvern_Ammo_Attack_Rate_5_displayName)]
        public virtual float Artillery_Bowgun_Wyvern_Ammo_Attack_Rate_5 {
            get => GetData<float>(859);
            set {
                if (GetData<float>(859) == value) return;
                SetData(859, value, nameof(Artillery_Bowgun_Wyvern_Ammo_Attack_Rate_5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_Bowgun_Wyvern_Ammo_Attack_Rate_5));
            }
        }

        public const string __15700_displayName = "-------------------------------------------------------------------------------------------";
        public const int __15700_sortIndex = 15700;
        [SortOrder(__15700_sortIndex)]
        [DisplayName(__15700_displayName)]
        [IsReadOnly]
        public virtual byte __15700 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__15700));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__15700));
            }
        }

        public const string Artillery_LBG_Wyvernblast_Attack_Rate_Appears_Unused_1_displayName = "Artillery: LBG Wyvernblast Attack Rate (Appears Unused?) 1";
        public const int Artillery_LBG_Wyvernblast_Attack_Rate_Appears_Unused_1_sortIndex = 15750;
        [SortOrder(Artillery_LBG_Wyvernblast_Attack_Rate_Appears_Unused_1_sortIndex)]
        [DisplayName(Artillery_LBG_Wyvernblast_Attack_Rate_Appears_Unused_1_displayName)]
        public virtual float Artillery_LBG_Wyvernblast_Attack_Rate_Appears_Unused_1 {
            get => GetData<float>(863);
            set {
                if (GetData<float>(863) == value) return;
                SetData(863, value, nameof(Artillery_LBG_Wyvernblast_Attack_Rate_Appears_Unused_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_LBG_Wyvernblast_Attack_Rate_Appears_Unused_1));
            }
        }

        public const string Artillery_LBG_Wyvernblast_Attack_Rate_Appears_Unused_2_displayName = "Artillery: LBG Wyvernblast Attack Rate (Appears Unused?) 2";
        public const int Artillery_LBG_Wyvernblast_Attack_Rate_Appears_Unused_2_sortIndex = 15800;
        [SortOrder(Artillery_LBG_Wyvernblast_Attack_Rate_Appears_Unused_2_sortIndex)]
        [DisplayName(Artillery_LBG_Wyvernblast_Attack_Rate_Appears_Unused_2_displayName)]
        public virtual float Artillery_LBG_Wyvernblast_Attack_Rate_Appears_Unused_2 {
            get => GetData<float>(867);
            set {
                if (GetData<float>(867) == value) return;
                SetData(867, value, nameof(Artillery_LBG_Wyvernblast_Attack_Rate_Appears_Unused_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_LBG_Wyvernblast_Attack_Rate_Appears_Unused_2));
            }
        }

        public const string Artillery_LBG_Wyvernblast_Attack_Rate_Appears_Unused_3_displayName = "Artillery: LBG Wyvernblast Attack Rate (Appears Unused?) 3";
        public const int Artillery_LBG_Wyvernblast_Attack_Rate_Appears_Unused_3_sortIndex = 15850;
        [SortOrder(Artillery_LBG_Wyvernblast_Attack_Rate_Appears_Unused_3_sortIndex)]
        [DisplayName(Artillery_LBG_Wyvernblast_Attack_Rate_Appears_Unused_3_displayName)]
        public virtual float Artillery_LBG_Wyvernblast_Attack_Rate_Appears_Unused_3 {
            get => GetData<float>(871);
            set {
                if (GetData<float>(871) == value) return;
                SetData(871, value, nameof(Artillery_LBG_Wyvernblast_Attack_Rate_Appears_Unused_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_LBG_Wyvernblast_Attack_Rate_Appears_Unused_3));
            }
        }

        public const string Artillery_LBG_Wyvernblast_Attack_Rate_Appears_Unused_4_displayName = "Artillery: LBG Wyvernblast Attack Rate (Appears Unused?) 4";
        public const int Artillery_LBG_Wyvernblast_Attack_Rate_Appears_Unused_4_sortIndex = 15900;
        [SortOrder(Artillery_LBG_Wyvernblast_Attack_Rate_Appears_Unused_4_sortIndex)]
        [DisplayName(Artillery_LBG_Wyvernblast_Attack_Rate_Appears_Unused_4_displayName)]
        public virtual float Artillery_LBG_Wyvernblast_Attack_Rate_Appears_Unused_4 {
            get => GetData<float>(875);
            set {
                if (GetData<float>(875) == value) return;
                SetData(875, value, nameof(Artillery_LBG_Wyvernblast_Attack_Rate_Appears_Unused_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_LBG_Wyvernblast_Attack_Rate_Appears_Unused_4));
            }
        }

        public const string Artillery_LBG_Wyvernblast_Attack_Rate_Appears_Unused_5_displayName = "Artillery: LBG Wyvernblast Attack Rate (Appears Unused?) 5";
        public const int Artillery_LBG_Wyvernblast_Attack_Rate_Appears_Unused_5_sortIndex = 15950;
        [SortOrder(Artillery_LBG_Wyvernblast_Attack_Rate_Appears_Unused_5_sortIndex)]
        [DisplayName(Artillery_LBG_Wyvernblast_Attack_Rate_Appears_Unused_5_displayName)]
        public virtual float Artillery_LBG_Wyvernblast_Attack_Rate_Appears_Unused_5 {
            get => GetData<float>(879);
            set {
                if (GetData<float>(879) == value) return;
                SetData(879, value, nameof(Artillery_LBG_Wyvernblast_Attack_Rate_Appears_Unused_5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Artillery_LBG_Wyvernblast_Attack_Rate_Appears_Unused_5));
            }
        }

        public const string __16000_displayName = "-------------------------------------------------------------------------------------------";
        public const int __16000_sortIndex = 16000;
        [SortOrder(__16000_sortIndex)]
        [DisplayName(__16000_displayName)]
        [IsReadOnly]
        public virtual byte __16000 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__16000));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__16000));
            }
        }

        public const string Heavy_Artillery_Ballista_Attack_Rate_1_displayName = "Heavy Artillery: Ballista Attack Rate 1";
        public const int Heavy_Artillery_Ballista_Attack_Rate_1_sortIndex = 16050;
        [SortOrder(Heavy_Artillery_Ballista_Attack_Rate_1_sortIndex)]
        [DisplayName(Heavy_Artillery_Ballista_Attack_Rate_1_displayName)]
        public virtual float Heavy_Artillery_Ballista_Attack_Rate_1 {
            get => GetData<float>(883);
            set {
                if (GetData<float>(883) == value) return;
                SetData(883, value, nameof(Heavy_Artillery_Ballista_Attack_Rate_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Heavy_Artillery_Ballista_Attack_Rate_1));
            }
        }

        public const string Heavy_Artillery_Ballista_Attack_Rate_2_displayName = "Heavy Artillery: Ballista Attack Rate 2";
        public const int Heavy_Artillery_Ballista_Attack_Rate_2_sortIndex = 16100;
        [SortOrder(Heavy_Artillery_Ballista_Attack_Rate_2_sortIndex)]
        [DisplayName(Heavy_Artillery_Ballista_Attack_Rate_2_displayName)]
        public virtual float Heavy_Artillery_Ballista_Attack_Rate_2 {
            get => GetData<float>(887);
            set {
                if (GetData<float>(887) == value) return;
                SetData(887, value, nameof(Heavy_Artillery_Ballista_Attack_Rate_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Heavy_Artillery_Ballista_Attack_Rate_2));
            }
        }

        public const string Heavy_Artillery_Cannon_Attack_Rate_1_displayName = "Heavy Artillery: Cannon Attack Rate 1";
        public const int Heavy_Artillery_Cannon_Attack_Rate_1_sortIndex = 16150;
        [SortOrder(Heavy_Artillery_Cannon_Attack_Rate_1_sortIndex)]
        [DisplayName(Heavy_Artillery_Cannon_Attack_Rate_1_displayName)]
        public virtual float Heavy_Artillery_Cannon_Attack_Rate_1 {
            get => GetData<float>(891);
            set {
                if (GetData<float>(891) == value) return;
                SetData(891, value, nameof(Heavy_Artillery_Cannon_Attack_Rate_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Heavy_Artillery_Cannon_Attack_Rate_1));
            }
        }

        public const string Heavy_Artillery_Cannon_Attack_Rate_2_displayName = "Heavy Artillery: Cannon Attack Rate 2";
        public const int Heavy_Artillery_Cannon_Attack_Rate_2_sortIndex = 16200;
        [SortOrder(Heavy_Artillery_Cannon_Attack_Rate_2_sortIndex)]
        [DisplayName(Heavy_Artillery_Cannon_Attack_Rate_2_displayName)]
        public virtual float Heavy_Artillery_Cannon_Attack_Rate_2 {
            get => GetData<float>(895);
            set {
                if (GetData<float>(895) == value) return;
                SetData(895, value, nameof(Heavy_Artillery_Cannon_Attack_Rate_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Heavy_Artillery_Cannon_Attack_Rate_2));
            }
        }

        public const string __16250_displayName = "-------------------------------------------------------------------------------------------";
        public const int __16250_sortIndex = 16250;
        [SortOrder(__16250_sortIndex)]
        [DisplayName(__16250_displayName)]
        [IsReadOnly]
        public virtual byte __16250 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__16250));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__16250));
            }
        }

        public const string Bombardier_Attack_Rate_1_displayName = "Bombardier: Attack Rate 1";
        public const int Bombardier_Attack_Rate_1_sortIndex = 16300;
        [SortOrder(Bombardier_Attack_Rate_1_sortIndex)]
        [DisplayName(Bombardier_Attack_Rate_1_displayName)]
        public virtual float Bombardier_Attack_Rate_1 {
            get => GetData<float>(899);
            set {
                if (GetData<float>(899) == value) return;
                SetData(899, value, nameof(Bombardier_Attack_Rate_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Bombardier_Attack_Rate_1));
            }
        }

        public const string Bombardier_Attack_Rate_2_displayName = "Bombardier: Attack Rate 2";
        public const int Bombardier_Attack_Rate_2_sortIndex = 16350;
        [SortOrder(Bombardier_Attack_Rate_2_sortIndex)]
        [DisplayName(Bombardier_Attack_Rate_2_displayName)]
        public virtual float Bombardier_Attack_Rate_2 {
            get => GetData<float>(903);
            set {
                if (GetData<float>(903) == value) return;
                SetData(903, value, nameof(Bombardier_Attack_Rate_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Bombardier_Attack_Rate_2));
            }
        }

        public const string Bombardier_Attack_Rate_3_displayName = "Bombardier: Attack Rate 3";
        public const int Bombardier_Attack_Rate_3_sortIndex = 16400;
        [SortOrder(Bombardier_Attack_Rate_3_sortIndex)]
        [DisplayName(Bombardier_Attack_Rate_3_displayName)]
        public virtual float Bombardier_Attack_Rate_3 {
            get => GetData<float>(907);
            set {
                if (GetData<float>(907) == value) return;
                SetData(907, value, nameof(Bombardier_Attack_Rate_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Bombardier_Attack_Rate_3));
            }
        }

        public const string Bombardier_Attack_Rate_4_displayName = "Bombardier: Attack Rate 4";
        public const int Bombardier_Attack_Rate_4_sortIndex = 16450;
        [SortOrder(Bombardier_Attack_Rate_4_sortIndex)]
        [DisplayName(Bombardier_Attack_Rate_4_displayName)]
        public virtual float Bombardier_Attack_Rate_4 {
            get => GetData<float>(911);
            set {
                if (GetData<float>(911) == value) return;
                SetData(911, value, nameof(Bombardier_Attack_Rate_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Bombardier_Attack_Rate_4));
            }
        }

        public const string Bombardier_Attack_Rate_5_displayName = "Bombardier: Attack Rate 5";
        public const int Bombardier_Attack_Rate_5_sortIndex = 16500;
        [SortOrder(Bombardier_Attack_Rate_5_sortIndex)]
        [DisplayName(Bombardier_Attack_Rate_5_displayName)]
        public virtual float Bombardier_Attack_Rate_5 {
            get => GetData<float>(915);
            set {
                if (GetData<float>(915) == value) return;
                SetData(915, value, nameof(Bombardier_Attack_Rate_5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Bombardier_Attack_Rate_5));
            }
        }

        public const string __16550_displayName = "-------------------------------------------------------------------------------------------";
        public const int __16550_sortIndex = 16550;
        [SortOrder(__16550_sortIndex)]
        [DisplayName(__16550_displayName)]
        [IsReadOnly]
        public virtual byte __16550 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__16550));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__16550));
            }
        }

        public const string Capacity_Boost_Gunlance_Normal_Bonus_displayName = "Capacity Boost: Gunlance Normal Bonus";
        public const int Capacity_Boost_Gunlance_Normal_Bonus_sortIndex = 16600;
        [SortOrder(Capacity_Boost_Gunlance_Normal_Bonus_sortIndex)]
        [DisplayName(Capacity_Boost_Gunlance_Normal_Bonus_displayName)]
        public virtual byte Capacity_Boost_Gunlance_Normal_Bonus {
            get => GetData<byte>(919);
            set {
                if (GetData<byte>(919) == value) return;
                SetData(919, value, nameof(Capacity_Boost_Gunlance_Normal_Bonus));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Capacity_Boost_Gunlance_Normal_Bonus));
            }
        }

        public const string Capacity_Boost_Gunlance_Radiation_Bonus_displayName = "Capacity Boost: Gunlance Radiation Bonus";
        public const int Capacity_Boost_Gunlance_Radiation_Bonus_sortIndex = 16650;
        [SortOrder(Capacity_Boost_Gunlance_Radiation_Bonus_sortIndex)]
        [DisplayName(Capacity_Boost_Gunlance_Radiation_Bonus_displayName)]
        public virtual byte Capacity_Boost_Gunlance_Radiation_Bonus {
            get => GetData<byte>(920);
            set {
                if (GetData<byte>(920) == value) return;
                SetData(920, value, nameof(Capacity_Boost_Gunlance_Radiation_Bonus));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Capacity_Boost_Gunlance_Radiation_Bonus));
            }
        }

        public const string Capacity_Boost_Gunlance_Scatter_Bonus_displayName = "Capacity Boost: Gunlance Scatter Bonus";
        public const int Capacity_Boost_Gunlance_Scatter_Bonus_sortIndex = 16700;
        [SortOrder(Capacity_Boost_Gunlance_Scatter_Bonus_sortIndex)]
        [DisplayName(Capacity_Boost_Gunlance_Scatter_Bonus_displayName)]
        public virtual byte Capacity_Boost_Gunlance_Scatter_Bonus {
            get => GetData<byte>(921);
            set {
                if (GetData<byte>(921) == value) return;
                SetData(921, value, nameof(Capacity_Boost_Gunlance_Scatter_Bonus));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Capacity_Boost_Gunlance_Scatter_Bonus));
            }
        }

        public const string Capacity_Boost_Charge_Blade_Shield_Duration_Bonus_displayName = "Capacity Boost: Charge Blade Shield Duration Bonus";
        public const int Capacity_Boost_Charge_Blade_Shield_Duration_Bonus_sortIndex = 16750;
        [SortOrder(Capacity_Boost_Charge_Blade_Shield_Duration_Bonus_sortIndex)]
        [DisplayName(Capacity_Boost_Charge_Blade_Shield_Duration_Bonus_displayName)]
        public virtual byte Capacity_Boost_Charge_Blade_Shield_Duration_Bonus {
            get => GetData<byte>(922);
            set {
                if (GetData<byte>(922) == value) return;
                SetData(922, value, nameof(Capacity_Boost_Charge_Blade_Shield_Duration_Bonus));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Capacity_Boost_Charge_Blade_Shield_Duration_Bonus));
            }
        }

        public const string __16800_displayName = "-------------------------------------------------------------------------------------------";
        public const int __16800_sortIndex = 16800;
        [SortOrder(__16800_sortIndex)]
        [DisplayName(__16800_displayName)]
        [IsReadOnly]
        public virtual byte __16800 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__16800));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__16800));
            }
        }

        public const string Ammo_Up_1_Capacity_1_Limit_displayName = "Ammo Up 1: Capacity 1 Limit";
        public const int Ammo_Up_1_Capacity_1_Limit_sortIndex = 16850;
        [SortOrder(Ammo_Up_1_Capacity_1_Limit_sortIndex)]
        [DisplayName(Ammo_Up_1_Capacity_1_Limit_displayName)]
        public virtual sbyte Ammo_Up_1_Capacity_1_Limit {
            get => GetData<sbyte>(923);
            set {
                if (GetData<sbyte>(923) == value) return;
                SetData(923, value, nameof(Ammo_Up_1_Capacity_1_Limit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Ammo_Up_1_Capacity_1_Limit));
            }
        }

        public const string Ammo_Up_1_Capacity_1_Bonus_displayName = "Ammo Up 1: Capacity 1 Bonus";
        public const int Ammo_Up_1_Capacity_1_Bonus_sortIndex = 16900;
        [SortOrder(Ammo_Up_1_Capacity_1_Bonus_sortIndex)]
        [DisplayName(Ammo_Up_1_Capacity_1_Bonus_displayName)]
        public virtual byte Ammo_Up_1_Capacity_1_Bonus {
            get => GetData<byte>(924);
            set {
                if (GetData<byte>(924) == value) return;
                SetData(924, value, nameof(Ammo_Up_1_Capacity_1_Bonus));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Ammo_Up_1_Capacity_1_Bonus));
            }
        }

        public const string Ammo_Up_1_Capacity_2_Limit_displayName = "Ammo Up 1: Capacity 2 Limit";
        public const int Ammo_Up_1_Capacity_2_Limit_sortIndex = 16950;
        [SortOrder(Ammo_Up_1_Capacity_2_Limit_sortIndex)]
        [DisplayName(Ammo_Up_1_Capacity_2_Limit_displayName)]
        public virtual sbyte Ammo_Up_1_Capacity_2_Limit {
            get => GetData<sbyte>(925);
            set {
                if (GetData<sbyte>(925) == value) return;
                SetData(925, value, nameof(Ammo_Up_1_Capacity_2_Limit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Ammo_Up_1_Capacity_2_Limit));
            }
        }

        public const string Ammo_Up_1_Capacity_2_Bonus_displayName = "Ammo Up 1: Capacity 2 Bonus";
        public const int Ammo_Up_1_Capacity_2_Bonus_sortIndex = 17000;
        [SortOrder(Ammo_Up_1_Capacity_2_Bonus_sortIndex)]
        [DisplayName(Ammo_Up_1_Capacity_2_Bonus_displayName)]
        public virtual byte Ammo_Up_1_Capacity_2_Bonus {
            get => GetData<byte>(926);
            set {
                if (GetData<byte>(926) == value) return;
                SetData(926, value, nameof(Ammo_Up_1_Capacity_2_Bonus));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Ammo_Up_1_Capacity_2_Bonus));
            }
        }

        public const string Ammo_Up_1_Capacity_3_Limit_displayName = "Ammo Up 1: Capacity 3 Limit";
        public const int Ammo_Up_1_Capacity_3_Limit_sortIndex = 17050;
        [SortOrder(Ammo_Up_1_Capacity_3_Limit_sortIndex)]
        [DisplayName(Ammo_Up_1_Capacity_3_Limit_displayName)]
        public virtual sbyte Ammo_Up_1_Capacity_3_Limit {
            get => GetData<sbyte>(927);
            set {
                if (GetData<sbyte>(927) == value) return;
                SetData(927, value, nameof(Ammo_Up_1_Capacity_3_Limit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Ammo_Up_1_Capacity_3_Limit));
            }
        }

        public const string Ammo_Up_1_Capacity_3_Bonus_displayName = "Ammo Up 1: Capacity 3 Bonus";
        public const int Ammo_Up_1_Capacity_3_Bonus_sortIndex = 17100;
        [SortOrder(Ammo_Up_1_Capacity_3_Bonus_sortIndex)]
        [DisplayName(Ammo_Up_1_Capacity_3_Bonus_displayName)]
        public virtual byte Ammo_Up_1_Capacity_3_Bonus {
            get => GetData<byte>(928);
            set {
                if (GetData<byte>(928) == value) return;
                SetData(928, value, nameof(Ammo_Up_1_Capacity_3_Bonus));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Ammo_Up_1_Capacity_3_Bonus));
            }
        }

        public const string Ammo_Up_1_Capacity_4_Limit_displayName = "Ammo Up 1: Capacity 4 Limit";
        public const int Ammo_Up_1_Capacity_4_Limit_sortIndex = 17150;
        [SortOrder(Ammo_Up_1_Capacity_4_Limit_sortIndex)]
        [DisplayName(Ammo_Up_1_Capacity_4_Limit_displayName)]
        public virtual sbyte Ammo_Up_1_Capacity_4_Limit {
            get => GetData<sbyte>(929);
            set {
                if (GetData<sbyte>(929) == value) return;
                SetData(929, value, nameof(Ammo_Up_1_Capacity_4_Limit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Ammo_Up_1_Capacity_4_Limit));
            }
        }

        public const string Ammo_Up_1_Capacity_4_Bonus_displayName = "Ammo Up 1: Capacity 4 Bonus";
        public const int Ammo_Up_1_Capacity_4_Bonus_sortIndex = 17200;
        [SortOrder(Ammo_Up_1_Capacity_4_Bonus_sortIndex)]
        [DisplayName(Ammo_Up_1_Capacity_4_Bonus_displayName)]
        public virtual byte Ammo_Up_1_Capacity_4_Bonus {
            get => GetData<byte>(930);
            set {
                if (GetData<byte>(930) == value) return;
                SetData(930, value, nameof(Ammo_Up_1_Capacity_4_Bonus));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Ammo_Up_1_Capacity_4_Bonus));
            }
        }

        public const string __17250_displayName = "-------------------------------------------------------------------------------------------";
        public const int __17250_sortIndex = 17250;
        [SortOrder(__17250_sortIndex)]
        [DisplayName(__17250_displayName)]
        [IsReadOnly]
        public virtual byte __17250 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__17250));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__17250));
            }
        }

        public const string Ammo_Up_2_Capacity_1_Limit_displayName = "Ammo Up 2: Capacity 1 Limit";
        public const int Ammo_Up_2_Capacity_1_Limit_sortIndex = 17300;
        [SortOrder(Ammo_Up_2_Capacity_1_Limit_sortIndex)]
        [DisplayName(Ammo_Up_2_Capacity_1_Limit_displayName)]
        public virtual sbyte Ammo_Up_2_Capacity_1_Limit {
            get => GetData<sbyte>(931);
            set {
                if (GetData<sbyte>(931) == value) return;
                SetData(931, value, nameof(Ammo_Up_2_Capacity_1_Limit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Ammo_Up_2_Capacity_1_Limit));
            }
        }

        public const string Ammo_Up_2_Capacity_1_Bonus_displayName = "Ammo Up 2: Capacity 1 Bonus";
        public const int Ammo_Up_2_Capacity_1_Bonus_sortIndex = 17350;
        [SortOrder(Ammo_Up_2_Capacity_1_Bonus_sortIndex)]
        [DisplayName(Ammo_Up_2_Capacity_1_Bonus_displayName)]
        public virtual byte Ammo_Up_2_Capacity_1_Bonus {
            get => GetData<byte>(932);
            set {
                if (GetData<byte>(932) == value) return;
                SetData(932, value, nameof(Ammo_Up_2_Capacity_1_Bonus));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Ammo_Up_2_Capacity_1_Bonus));
            }
        }

        public const string Ammo_Up_2_Capacity_2_Limit_displayName = "Ammo Up 2: Capacity 2 Limit";
        public const int Ammo_Up_2_Capacity_2_Limit_sortIndex = 17400;
        [SortOrder(Ammo_Up_2_Capacity_2_Limit_sortIndex)]
        [DisplayName(Ammo_Up_2_Capacity_2_Limit_displayName)]
        public virtual sbyte Ammo_Up_2_Capacity_2_Limit {
            get => GetData<sbyte>(933);
            set {
                if (GetData<sbyte>(933) == value) return;
                SetData(933, value, nameof(Ammo_Up_2_Capacity_2_Limit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Ammo_Up_2_Capacity_2_Limit));
            }
        }

        public const string Ammo_Up_2_Capacity_2_Bonus_displayName = "Ammo Up 2: Capacity 2 Bonus";
        public const int Ammo_Up_2_Capacity_2_Bonus_sortIndex = 17450;
        [SortOrder(Ammo_Up_2_Capacity_2_Bonus_sortIndex)]
        [DisplayName(Ammo_Up_2_Capacity_2_Bonus_displayName)]
        public virtual byte Ammo_Up_2_Capacity_2_Bonus {
            get => GetData<byte>(934);
            set {
                if (GetData<byte>(934) == value) return;
                SetData(934, value, nameof(Ammo_Up_2_Capacity_2_Bonus));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Ammo_Up_2_Capacity_2_Bonus));
            }
        }

        public const string Ammo_Up_2_Capacity_3_Limit_displayName = "Ammo Up 2: Capacity 3 Limit";
        public const int Ammo_Up_2_Capacity_3_Limit_sortIndex = 17500;
        [SortOrder(Ammo_Up_2_Capacity_3_Limit_sortIndex)]
        [DisplayName(Ammo_Up_2_Capacity_3_Limit_displayName)]
        public virtual sbyte Ammo_Up_2_Capacity_3_Limit {
            get => GetData<sbyte>(935);
            set {
                if (GetData<sbyte>(935) == value) return;
                SetData(935, value, nameof(Ammo_Up_2_Capacity_3_Limit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Ammo_Up_2_Capacity_3_Limit));
            }
        }

        public const string Ammo_Up_2_Capacity_3_Bonus_displayName = "Ammo Up 2: Capacity 3 Bonus";
        public const int Ammo_Up_2_Capacity_3_Bonus_sortIndex = 17550;
        [SortOrder(Ammo_Up_2_Capacity_3_Bonus_sortIndex)]
        [DisplayName(Ammo_Up_2_Capacity_3_Bonus_displayName)]
        public virtual byte Ammo_Up_2_Capacity_3_Bonus {
            get => GetData<byte>(936);
            set {
                if (GetData<byte>(936) == value) return;
                SetData(936, value, nameof(Ammo_Up_2_Capacity_3_Bonus));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Ammo_Up_2_Capacity_3_Bonus));
            }
        }

        public const string Ammo_Up_2_Capacity_4_Limit_displayName = "Ammo Up 2: Capacity 4 Limit";
        public const int Ammo_Up_2_Capacity_4_Limit_sortIndex = 17600;
        [SortOrder(Ammo_Up_2_Capacity_4_Limit_sortIndex)]
        [DisplayName(Ammo_Up_2_Capacity_4_Limit_displayName)]
        public virtual sbyte Ammo_Up_2_Capacity_4_Limit {
            get => GetData<sbyte>(937);
            set {
                if (GetData<sbyte>(937) == value) return;
                SetData(937, value, nameof(Ammo_Up_2_Capacity_4_Limit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Ammo_Up_2_Capacity_4_Limit));
            }
        }

        public const string Ammo_Up_2_Capacity_4_Bonus_displayName = "Ammo Up 2: Capacity 4 Bonus";
        public const int Ammo_Up_2_Capacity_4_Bonus_sortIndex = 17650;
        [SortOrder(Ammo_Up_2_Capacity_4_Bonus_sortIndex)]
        [DisplayName(Ammo_Up_2_Capacity_4_Bonus_displayName)]
        public virtual byte Ammo_Up_2_Capacity_4_Bonus {
            get => GetData<byte>(938);
            set {
                if (GetData<byte>(938) == value) return;
                SetData(938, value, nameof(Ammo_Up_2_Capacity_4_Bonus));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Ammo_Up_2_Capacity_4_Bonus));
            }
        }

        public const string __17700_displayName = "-------------------------------------------------------------------------------------------";
        public const int __17700_sortIndex = 17700;
        [SortOrder(__17700_sortIndex)]
        [DisplayName(__17700_displayName)]
        [IsReadOnly]
        public virtual byte __17700 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__17700));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__17700));
            }
        }

        public const string Ammo_Up_3_Capacity_1_Limit_displayName = "Ammo Up 3: Capacity 1 Limit";
        public const int Ammo_Up_3_Capacity_1_Limit_sortIndex = 17750;
        [SortOrder(Ammo_Up_3_Capacity_1_Limit_sortIndex)]
        [DisplayName(Ammo_Up_3_Capacity_1_Limit_displayName)]
        public virtual sbyte Ammo_Up_3_Capacity_1_Limit {
            get => GetData<sbyte>(939);
            set {
                if (GetData<sbyte>(939) == value) return;
                SetData(939, value, nameof(Ammo_Up_3_Capacity_1_Limit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Ammo_Up_3_Capacity_1_Limit));
            }
        }

        public const string Ammo_Up_3_Capacity_1_Bonus_displayName = "Ammo Up 3: Capacity 1 Bonus";
        public const int Ammo_Up_3_Capacity_1_Bonus_sortIndex = 17800;
        [SortOrder(Ammo_Up_3_Capacity_1_Bonus_sortIndex)]
        [DisplayName(Ammo_Up_3_Capacity_1_Bonus_displayName)]
        public virtual byte Ammo_Up_3_Capacity_1_Bonus {
            get => GetData<byte>(940);
            set {
                if (GetData<byte>(940) == value) return;
                SetData(940, value, nameof(Ammo_Up_3_Capacity_1_Bonus));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Ammo_Up_3_Capacity_1_Bonus));
            }
        }

        public const string Ammo_Up_3_Capacity_2_Limit_displayName = "Ammo Up 3: Capacity 2 Limit";
        public const int Ammo_Up_3_Capacity_2_Limit_sortIndex = 17850;
        [SortOrder(Ammo_Up_3_Capacity_2_Limit_sortIndex)]
        [DisplayName(Ammo_Up_3_Capacity_2_Limit_displayName)]
        public virtual sbyte Ammo_Up_3_Capacity_2_Limit {
            get => GetData<sbyte>(941);
            set {
                if (GetData<sbyte>(941) == value) return;
                SetData(941, value, nameof(Ammo_Up_3_Capacity_2_Limit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Ammo_Up_3_Capacity_2_Limit));
            }
        }

        public const string Ammo_Up_3_Capacity_2_Bonus_displayName = "Ammo Up 3: Capacity 2 Bonus";
        public const int Ammo_Up_3_Capacity_2_Bonus_sortIndex = 17900;
        [SortOrder(Ammo_Up_3_Capacity_2_Bonus_sortIndex)]
        [DisplayName(Ammo_Up_3_Capacity_2_Bonus_displayName)]
        public virtual byte Ammo_Up_3_Capacity_2_Bonus {
            get => GetData<byte>(942);
            set {
                if (GetData<byte>(942) == value) return;
                SetData(942, value, nameof(Ammo_Up_3_Capacity_2_Bonus));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Ammo_Up_3_Capacity_2_Bonus));
            }
        }

        public const string Ammo_Up_3_Capacity_3_Limit_displayName = "Ammo Up 3: Capacity 3 Limit";
        public const int Ammo_Up_3_Capacity_3_Limit_sortIndex = 17950;
        [SortOrder(Ammo_Up_3_Capacity_3_Limit_sortIndex)]
        [DisplayName(Ammo_Up_3_Capacity_3_Limit_displayName)]
        public virtual sbyte Ammo_Up_3_Capacity_3_Limit {
            get => GetData<sbyte>(943);
            set {
                if (GetData<sbyte>(943) == value) return;
                SetData(943, value, nameof(Ammo_Up_3_Capacity_3_Limit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Ammo_Up_3_Capacity_3_Limit));
            }
        }

        public const string Ammo_Up_3_Capacity_3_Bonus_displayName = "Ammo Up 3: Capacity 3 Bonus";
        public const int Ammo_Up_3_Capacity_3_Bonus_sortIndex = 18000;
        [SortOrder(Ammo_Up_3_Capacity_3_Bonus_sortIndex)]
        [DisplayName(Ammo_Up_3_Capacity_3_Bonus_displayName)]
        public virtual byte Ammo_Up_3_Capacity_3_Bonus {
            get => GetData<byte>(944);
            set {
                if (GetData<byte>(944) == value) return;
                SetData(944, value, nameof(Ammo_Up_3_Capacity_3_Bonus));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Ammo_Up_3_Capacity_3_Bonus));
            }
        }

        public const string Ammo_Up_3_Capacity_4_Limit_displayName = "Ammo Up 3: Capacity 4 Limit";
        public const int Ammo_Up_3_Capacity_4_Limit_sortIndex = 18050;
        [SortOrder(Ammo_Up_3_Capacity_4_Limit_sortIndex)]
        [DisplayName(Ammo_Up_3_Capacity_4_Limit_displayName)]
        public virtual sbyte Ammo_Up_3_Capacity_4_Limit {
            get => GetData<sbyte>(945);
            set {
                if (GetData<sbyte>(945) == value) return;
                SetData(945, value, nameof(Ammo_Up_3_Capacity_4_Limit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Ammo_Up_3_Capacity_4_Limit));
            }
        }

        public const string Ammo_Up_3_Capacity_4_Bonus_displayName = "Ammo Up 3: Capacity 4 Bonus";
        public const int Ammo_Up_3_Capacity_4_Bonus_sortIndex = 18100;
        [SortOrder(Ammo_Up_3_Capacity_4_Bonus_sortIndex)]
        [DisplayName(Ammo_Up_3_Capacity_4_Bonus_displayName)]
        public virtual byte Ammo_Up_3_Capacity_4_Bonus {
            get => GetData<byte>(946);
            set {
                if (GetData<byte>(946) == value) return;
                SetData(946, value, nameof(Ammo_Up_3_Capacity_4_Bonus));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Ammo_Up_3_Capacity_4_Bonus));
            }
        }

        public const string __18150_displayName = "-------------------------------------------------------------------------------------------";
        public const int __18150_sortIndex = 18150;
        [SortOrder(__18150_sortIndex)]
        [DisplayName(__18150_displayName)]
        [IsReadOnly]
        public virtual byte __18150 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__18150));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__18150));
            }
        }

        public const string Power_Prolonger_Dual_Blades_1_displayName = "Power Prolonger: Dual Blades 1";
        public const int Power_Prolonger_Dual_Blades_1_sortIndex = 18200;
        [SortOrder(Power_Prolonger_Dual_Blades_1_sortIndex)]
        [DisplayName(Power_Prolonger_Dual_Blades_1_displayName)]
        public virtual float Power_Prolonger_Dual_Blades_1 {
            get => GetData<float>(947);
            set {
                if (GetData<float>(947) == value) return;
                SetData(947, value, nameof(Power_Prolonger_Dual_Blades_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Power_Prolonger_Dual_Blades_1));
            }
        }

        public const string Power_Prolonger_Dual_Blades_2_displayName = "Power Prolonger: Dual Blades 2";
        public const int Power_Prolonger_Dual_Blades_2_sortIndex = 18250;
        [SortOrder(Power_Prolonger_Dual_Blades_2_sortIndex)]
        [DisplayName(Power_Prolonger_Dual_Blades_2_displayName)]
        public virtual float Power_Prolonger_Dual_Blades_2 {
            get => GetData<float>(951);
            set {
                if (GetData<float>(951) == value) return;
                SetData(951, value, nameof(Power_Prolonger_Dual_Blades_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Power_Prolonger_Dual_Blades_2));
            }
        }

        public const string Power_Prolonger_Dual_Blades_3_displayName = "Power Prolonger: Dual Blades 3";
        public const int Power_Prolonger_Dual_Blades_3_sortIndex = 18300;
        [SortOrder(Power_Prolonger_Dual_Blades_3_sortIndex)]
        [DisplayName(Power_Prolonger_Dual_Blades_3_displayName)]
        public virtual float Power_Prolonger_Dual_Blades_3 {
            get => GetData<float>(955);
            set {
                if (GetData<float>(955) == value) return;
                SetData(955, value, nameof(Power_Prolonger_Dual_Blades_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Power_Prolonger_Dual_Blades_3));
            }
        }

        public const string __18350_displayName = "-------------------------------------------------------------------------------------------";
        public const int __18350_sortIndex = 18350;
        [SortOrder(__18350_sortIndex)]
        [DisplayName(__18350_displayName)]
        [IsReadOnly]
        public virtual byte __18350 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__18350));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__18350));
            }
        }

        public const string Power_Prolonger_Long_Sword_1_displayName = "Power Prolonger: Long Sword 1";
        public const int Power_Prolonger_Long_Sword_1_sortIndex = 18400;
        [SortOrder(Power_Prolonger_Long_Sword_1_sortIndex)]
        [DisplayName(Power_Prolonger_Long_Sword_1_displayName)]
        public virtual float Power_Prolonger_Long_Sword_1 {
            get => GetData<float>(959);
            set {
                if (GetData<float>(959) == value) return;
                SetData(959, value, nameof(Power_Prolonger_Long_Sword_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Power_Prolonger_Long_Sword_1));
            }
        }

        public const string Power_Prolonger_Long_Sword_2_displayName = "Power Prolonger: Long Sword 2";
        public const int Power_Prolonger_Long_Sword_2_sortIndex = 18450;
        [SortOrder(Power_Prolonger_Long_Sword_2_sortIndex)]
        [DisplayName(Power_Prolonger_Long_Sword_2_displayName)]
        public virtual float Power_Prolonger_Long_Sword_2 {
            get => GetData<float>(963);
            set {
                if (GetData<float>(963) == value) return;
                SetData(963, value, nameof(Power_Prolonger_Long_Sword_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Power_Prolonger_Long_Sword_2));
            }
        }

        public const string Power_Prolonger_Long_Sword_3_displayName = "Power Prolonger: Long Sword 3";
        public const int Power_Prolonger_Long_Sword_3_sortIndex = 18500;
        [SortOrder(Power_Prolonger_Long_Sword_3_sortIndex)]
        [DisplayName(Power_Prolonger_Long_Sword_3_displayName)]
        public virtual float Power_Prolonger_Long_Sword_3 {
            get => GetData<float>(967);
            set {
                if (GetData<float>(967) == value) return;
                SetData(967, value, nameof(Power_Prolonger_Long_Sword_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Power_Prolonger_Long_Sword_3));
            }
        }

        public const string __18550_displayName = "-------------------------------------------------------------------------------------------";
        public const int __18550_sortIndex = 18550;
        [SortOrder(__18550_sortIndex)]
        [DisplayName(__18550_displayName)]
        [IsReadOnly]
        public virtual byte __18550 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__18550));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__18550));
            }
        }

        public const string Power_Prolonger_Switch_Axe_1_displayName = "Power Prolonger: Switch Axe 1";
        public const int Power_Prolonger_Switch_Axe_1_sortIndex = 18600;
        [SortOrder(Power_Prolonger_Switch_Axe_1_sortIndex)]
        [DisplayName(Power_Prolonger_Switch_Axe_1_displayName)]
        public virtual float Power_Prolonger_Switch_Axe_1 {
            get => GetData<float>(971);
            set {
                if (GetData<float>(971) == value) return;
                SetData(971, value, nameof(Power_Prolonger_Switch_Axe_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Power_Prolonger_Switch_Axe_1));
            }
        }

        public const string Power_Prolonger_Switch_Axe_2_displayName = "Power Prolonger: Switch Axe 2";
        public const int Power_Prolonger_Switch_Axe_2_sortIndex = 18650;
        [SortOrder(Power_Prolonger_Switch_Axe_2_sortIndex)]
        [DisplayName(Power_Prolonger_Switch_Axe_2_displayName)]
        public virtual float Power_Prolonger_Switch_Axe_2 {
            get => GetData<float>(975);
            set {
                if (GetData<float>(975) == value) return;
                SetData(975, value, nameof(Power_Prolonger_Switch_Axe_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Power_Prolonger_Switch_Axe_2));
            }
        }

        public const string Power_Prolonger_Switch_Axe_3_displayName = "Power Prolonger: Switch Axe 3";
        public const int Power_Prolonger_Switch_Axe_3_sortIndex = 18700;
        [SortOrder(Power_Prolonger_Switch_Axe_3_sortIndex)]
        [DisplayName(Power_Prolonger_Switch_Axe_3_displayName)]
        public virtual float Power_Prolonger_Switch_Axe_3 {
            get => GetData<float>(979);
            set {
                if (GetData<float>(979) == value) return;
                SetData(979, value, nameof(Power_Prolonger_Switch_Axe_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Power_Prolonger_Switch_Axe_3));
            }
        }

        public const string __18750_displayName = "-------------------------------------------------------------------------------------------";
        public const int __18750_sortIndex = 18750;
        [SortOrder(__18750_sortIndex)]
        [DisplayName(__18750_displayName)]
        [IsReadOnly]
        public virtual byte __18750 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__18750));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__18750));
            }
        }

        public const string Power_Prolonger_Charge_Blade_1_displayName = "Power Prolonger: Charge Blade 1";
        public const int Power_Prolonger_Charge_Blade_1_sortIndex = 18800;
        [SortOrder(Power_Prolonger_Charge_Blade_1_sortIndex)]
        [DisplayName(Power_Prolonger_Charge_Blade_1_displayName)]
        public virtual float Power_Prolonger_Charge_Blade_1 {
            get => GetData<float>(983);
            set {
                if (GetData<float>(983) == value) return;
                SetData(983, value, nameof(Power_Prolonger_Charge_Blade_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Power_Prolonger_Charge_Blade_1));
            }
        }

        public const string Power_Prolonger_Charge_Blade_2_displayName = "Power Prolonger: Charge Blade 2";
        public const int Power_Prolonger_Charge_Blade_2_sortIndex = 18850;
        [SortOrder(Power_Prolonger_Charge_Blade_2_sortIndex)]
        [DisplayName(Power_Prolonger_Charge_Blade_2_displayName)]
        public virtual float Power_Prolonger_Charge_Blade_2 {
            get => GetData<float>(987);
            set {
                if (GetData<float>(987) == value) return;
                SetData(987, value, nameof(Power_Prolonger_Charge_Blade_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Power_Prolonger_Charge_Blade_2));
            }
        }

        public const string Power_Prolonger_Charge_Blade_3_displayName = "Power Prolonger: Charge Blade 3";
        public const int Power_Prolonger_Charge_Blade_3_sortIndex = 18900;
        [SortOrder(Power_Prolonger_Charge_Blade_3_sortIndex)]
        [DisplayName(Power_Prolonger_Charge_Blade_3_displayName)]
        public virtual float Power_Prolonger_Charge_Blade_3 {
            get => GetData<float>(991);
            set {
                if (GetData<float>(991) == value) return;
                SetData(991, value, nameof(Power_Prolonger_Charge_Blade_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Power_Prolonger_Charge_Blade_3));
            }
        }

        public const string __18950_displayName = "-------------------------------------------------------------------------------------------";
        public const int __18950_sortIndex = 18950;
        [SortOrder(__18950_sortIndex)]
        [DisplayName(__18950_displayName)]
        [IsReadOnly]
        public virtual byte __18950 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__18950));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__18950));
            }
        }

        public const string Power_Prolonger_Insect_Glaive_1_displayName = "Power Prolonger: Insect Glaive 1";
        public const int Power_Prolonger_Insect_Glaive_1_sortIndex = 19000;
        [SortOrder(Power_Prolonger_Insect_Glaive_1_sortIndex)]
        [DisplayName(Power_Prolonger_Insect_Glaive_1_displayName)]
        public virtual float Power_Prolonger_Insect_Glaive_1 {
            get => GetData<float>(995);
            set {
                if (GetData<float>(995) == value) return;
                SetData(995, value, nameof(Power_Prolonger_Insect_Glaive_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Power_Prolonger_Insect_Glaive_1));
            }
        }

        public const string Power_Prolonger_Insect_Glaive_2_displayName = "Power Prolonger: Insect Glaive 2";
        public const int Power_Prolonger_Insect_Glaive_2_sortIndex = 19050;
        [SortOrder(Power_Prolonger_Insect_Glaive_2_sortIndex)]
        [DisplayName(Power_Prolonger_Insect_Glaive_2_displayName)]
        public virtual float Power_Prolonger_Insect_Glaive_2 {
            get => GetData<float>(999);
            set {
                if (GetData<float>(999) == value) return;
                SetData(999, value, nameof(Power_Prolonger_Insect_Glaive_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Power_Prolonger_Insect_Glaive_2));
            }
        }

        public const string Power_Prolonger_Insect_Glaive_3_displayName = "Power Prolonger: Insect Glaive 3";
        public const int Power_Prolonger_Insect_Glaive_3_sortIndex = 19100;
        [SortOrder(Power_Prolonger_Insect_Glaive_3_sortIndex)]
        [DisplayName(Power_Prolonger_Insect_Glaive_3_displayName)]
        public virtual float Power_Prolonger_Insect_Glaive_3 {
            get => GetData<float>(1003);
            set {
                if (GetData<float>(1003) == value) return;
                SetData(1003, value, nameof(Power_Prolonger_Insect_Glaive_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Power_Prolonger_Insect_Glaive_3));
            }
        }

        public const string __19150_displayName = "-------------------------------------------------------------------------------------------";
        public const int __19150_sortIndex = 19150;
        [SortOrder(__19150_sortIndex)]
        [DisplayName(__19150_displayName)]
        [IsReadOnly]
        public virtual byte __19150 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__19150));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__19150));
            }
        }

        public const string Health_Auto_Recover_Interval_displayName = "Health Auto Recover Interval";
        public const int Health_Auto_Recover_Interval_sortIndex = 19200;
        [SortOrder(Health_Auto_Recover_Interval_sortIndex)]
        [DisplayName(Health_Auto_Recover_Interval_displayName)]
        public virtual float Health_Auto_Recover_Interval {
            get => GetData<float>(1007);
            set {
                if (GetData<float>(1007) == value) return;
                SetData(1007, value, nameof(Health_Auto_Recover_Interval));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Health_Auto_Recover_Interval));
            }
        }

        public const string Health_Auto_Recover_Value_displayName = "Health Auto Recover Value";
        public const int Health_Auto_Recover_Value_sortIndex = 19250;
        [SortOrder(Health_Auto_Recover_Value_sortIndex)]
        [DisplayName(Health_Auto_Recover_Value_displayName)]
        public virtual byte Health_Auto_Recover_Value {
            get => GetData<byte>(1011);
            set {
                if (GetData<byte>(1011) == value) return;
                SetData(1011, value, nameof(Health_Auto_Recover_Value));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Health_Auto_Recover_Value));
            }
        }

        public const string __19300_displayName = "-------------------------------------------------------------------------------------------";
        public const int __19300_sortIndex = 19300;
        [SortOrder(__19300_sortIndex)]
        [DisplayName(__19300_displayName)]
        [IsReadOnly]
        public virtual byte __19300 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__19300));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__19300));
            }
        }

        public const string Hasten_Recovery_Great_Sword_Recovery_Health_displayName = "Hasten Recovery: (Great Sword) Recovery Health";
        public const int Hasten_Recovery_Great_Sword_Recovery_Health_sortIndex = 19350;
        [SortOrder(Hasten_Recovery_Great_Sword_Recovery_Health_sortIndex)]
        [DisplayName(Hasten_Recovery_Great_Sword_Recovery_Health_displayName)]
        public virtual byte Hasten_Recovery_Great_Sword_Recovery_Health {
            get => GetData<byte>(1012);
            set {
                if (GetData<byte>(1012) == value) return;
                SetData(1012, value, nameof(Hasten_Recovery_Great_Sword_Recovery_Health));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Hasten_Recovery_Great_Sword_Recovery_Health));
            }
        }

        public const string Hasten_Recovery_Sword_Shield_Recovery_Health_displayName = "Hasten Recovery: (Sword & Shield) Recovery Health";
        public const int Hasten_Recovery_Sword_Shield_Recovery_Health_sortIndex = 19400;
        [SortOrder(Hasten_Recovery_Sword_Shield_Recovery_Health_sortIndex)]
        [DisplayName(Hasten_Recovery_Sword_Shield_Recovery_Health_displayName)]
        public virtual byte Hasten_Recovery_Sword_Shield_Recovery_Health {
            get => GetData<byte>(1013);
            set {
                if (GetData<byte>(1013) == value) return;
                SetData(1013, value, nameof(Hasten_Recovery_Sword_Shield_Recovery_Health));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Hasten_Recovery_Sword_Shield_Recovery_Health));
            }
        }

        public const string Hasten_Recovery_Dual_Blades_Recovery_Health_displayName = "Hasten Recovery: (Dual Blades) Recovery Health";
        public const int Hasten_Recovery_Dual_Blades_Recovery_Health_sortIndex = 19450;
        [SortOrder(Hasten_Recovery_Dual_Blades_Recovery_Health_sortIndex)]
        [DisplayName(Hasten_Recovery_Dual_Blades_Recovery_Health_displayName)]
        public virtual byte Hasten_Recovery_Dual_Blades_Recovery_Health {
            get => GetData<byte>(1014);
            set {
                if (GetData<byte>(1014) == value) return;
                SetData(1014, value, nameof(Hasten_Recovery_Dual_Blades_Recovery_Health));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Hasten_Recovery_Dual_Blades_Recovery_Health));
            }
        }

        public const string Hasten_Recovery_Long_Sword_Recovery_Health_displayName = "Hasten Recovery: (Long Sword) Recovery Health";
        public const int Hasten_Recovery_Long_Sword_Recovery_Health_sortIndex = 19500;
        [SortOrder(Hasten_Recovery_Long_Sword_Recovery_Health_sortIndex)]
        [DisplayName(Hasten_Recovery_Long_Sword_Recovery_Health_displayName)]
        public virtual byte Hasten_Recovery_Long_Sword_Recovery_Health {
            get => GetData<byte>(1015);
            set {
                if (GetData<byte>(1015) == value) return;
                SetData(1015, value, nameof(Hasten_Recovery_Long_Sword_Recovery_Health));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Hasten_Recovery_Long_Sword_Recovery_Health));
            }
        }

        public const string Hasten_Recovery_Hammer_Recovery_Health_displayName = "Hasten Recovery: (Hammer) Recovery Health";
        public const int Hasten_Recovery_Hammer_Recovery_Health_sortIndex = 19550;
        [SortOrder(Hasten_Recovery_Hammer_Recovery_Health_sortIndex)]
        [DisplayName(Hasten_Recovery_Hammer_Recovery_Health_displayName)]
        public virtual byte Hasten_Recovery_Hammer_Recovery_Health {
            get => GetData<byte>(1016);
            set {
                if (GetData<byte>(1016) == value) return;
                SetData(1016, value, nameof(Hasten_Recovery_Hammer_Recovery_Health));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Hasten_Recovery_Hammer_Recovery_Health));
            }
        }

        public const string Hasten_Recovery_Hunting_Horn_Recovery_Health_displayName = "Hasten Recovery: (Hunting Horn) Recovery Health";
        public const int Hasten_Recovery_Hunting_Horn_Recovery_Health_sortIndex = 19600;
        [SortOrder(Hasten_Recovery_Hunting_Horn_Recovery_Health_sortIndex)]
        [DisplayName(Hasten_Recovery_Hunting_Horn_Recovery_Health_displayName)]
        public virtual byte Hasten_Recovery_Hunting_Horn_Recovery_Health {
            get => GetData<byte>(1017);
            set {
                if (GetData<byte>(1017) == value) return;
                SetData(1017, value, nameof(Hasten_Recovery_Hunting_Horn_Recovery_Health));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Hasten_Recovery_Hunting_Horn_Recovery_Health));
            }
        }

        public const string Hasten_Recovery_Lance_Recovery_Health_displayName = "Hasten Recovery: (Lance) Recovery Health";
        public const int Hasten_Recovery_Lance_Recovery_Health_sortIndex = 19650;
        [SortOrder(Hasten_Recovery_Lance_Recovery_Health_sortIndex)]
        [DisplayName(Hasten_Recovery_Lance_Recovery_Health_displayName)]
        public virtual byte Hasten_Recovery_Lance_Recovery_Health {
            get => GetData<byte>(1018);
            set {
                if (GetData<byte>(1018) == value) return;
                SetData(1018, value, nameof(Hasten_Recovery_Lance_Recovery_Health));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Hasten_Recovery_Lance_Recovery_Health));
            }
        }

        public const string Hasten_Recovery_Gunlance_Recovery_Health_displayName = "Hasten Recovery: (Gunlance) Recovery Health";
        public const int Hasten_Recovery_Gunlance_Recovery_Health_sortIndex = 19700;
        [SortOrder(Hasten_Recovery_Gunlance_Recovery_Health_sortIndex)]
        [DisplayName(Hasten_Recovery_Gunlance_Recovery_Health_displayName)]
        public virtual byte Hasten_Recovery_Gunlance_Recovery_Health {
            get => GetData<byte>(1019);
            set {
                if (GetData<byte>(1019) == value) return;
                SetData(1019, value, nameof(Hasten_Recovery_Gunlance_Recovery_Health));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Hasten_Recovery_Gunlance_Recovery_Health));
            }
        }

        public const string Hasten_Recovery_Switch_Axe_Recovery_Health_displayName = "Hasten Recovery: (Switch Axe) Recovery Health";
        public const int Hasten_Recovery_Switch_Axe_Recovery_Health_sortIndex = 19750;
        [SortOrder(Hasten_Recovery_Switch_Axe_Recovery_Health_sortIndex)]
        [DisplayName(Hasten_Recovery_Switch_Axe_Recovery_Health_displayName)]
        public virtual byte Hasten_Recovery_Switch_Axe_Recovery_Health {
            get => GetData<byte>(1020);
            set {
                if (GetData<byte>(1020) == value) return;
                SetData(1020, value, nameof(Hasten_Recovery_Switch_Axe_Recovery_Health));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Hasten_Recovery_Switch_Axe_Recovery_Health));
            }
        }

        public const string Hasten_Recovery_Charge_Blade_Recovery_Health_displayName = "Hasten Recovery: (Charge Blade) Recovery Health";
        public const int Hasten_Recovery_Charge_Blade_Recovery_Health_sortIndex = 19800;
        [SortOrder(Hasten_Recovery_Charge_Blade_Recovery_Health_sortIndex)]
        [DisplayName(Hasten_Recovery_Charge_Blade_Recovery_Health_displayName)]
        public virtual byte Hasten_Recovery_Charge_Blade_Recovery_Health {
            get => GetData<byte>(1021);
            set {
                if (GetData<byte>(1021) == value) return;
                SetData(1021, value, nameof(Hasten_Recovery_Charge_Blade_Recovery_Health));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Hasten_Recovery_Charge_Blade_Recovery_Health));
            }
        }

        public const string Hasten_Recovery_Insect_Glaive_Recovery_Health_displayName = "Hasten Recovery: (Insect Glaive) Recovery Health";
        public const int Hasten_Recovery_Insect_Glaive_Recovery_Health_sortIndex = 19850;
        [SortOrder(Hasten_Recovery_Insect_Glaive_Recovery_Health_sortIndex)]
        [DisplayName(Hasten_Recovery_Insect_Glaive_Recovery_Health_displayName)]
        public virtual byte Hasten_Recovery_Insect_Glaive_Recovery_Health {
            get => GetData<byte>(1022);
            set {
                if (GetData<byte>(1022) == value) return;
                SetData(1022, value, nameof(Hasten_Recovery_Insect_Glaive_Recovery_Health));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Hasten_Recovery_Insect_Glaive_Recovery_Health));
            }
        }

        public const string Hasten_Recovery_Bow_Recovery_Health_displayName = "Hasten Recovery: (Bow) Recovery Health";
        public const int Hasten_Recovery_Bow_Recovery_Health_sortIndex = 19900;
        [SortOrder(Hasten_Recovery_Bow_Recovery_Health_sortIndex)]
        [DisplayName(Hasten_Recovery_Bow_Recovery_Health_displayName)]
        public virtual byte Hasten_Recovery_Bow_Recovery_Health {
            get => GetData<byte>(1023);
            set {
                if (GetData<byte>(1023) == value) return;
                SetData(1023, value, nameof(Hasten_Recovery_Bow_Recovery_Health));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Hasten_Recovery_Bow_Recovery_Health));
            }
        }

        public const string Hasten_Recovery_HBG_Recovery_Health_displayName = "Hasten Recovery: (HBG) Recovery Health";
        public const int Hasten_Recovery_HBG_Recovery_Health_sortIndex = 19950;
        [SortOrder(Hasten_Recovery_HBG_Recovery_Health_sortIndex)]
        [DisplayName(Hasten_Recovery_HBG_Recovery_Health_displayName)]
        public virtual byte Hasten_Recovery_HBG_Recovery_Health {
            get => GetData<byte>(1024);
            set {
                if (GetData<byte>(1024) == value) return;
                SetData(1024, value, nameof(Hasten_Recovery_HBG_Recovery_Health));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Hasten_Recovery_HBG_Recovery_Health));
            }
        }

        public const string Hasten_Recovery_LBG_Recovery_Health_displayName = "Hasten Recovery: (LBG) Recovery Health";
        public const int Hasten_Recovery_LBG_Recovery_Health_sortIndex = 20000;
        [SortOrder(Hasten_Recovery_LBG_Recovery_Health_sortIndex)]
        [DisplayName(Hasten_Recovery_LBG_Recovery_Health_displayName)]
        public virtual byte Hasten_Recovery_LBG_Recovery_Health {
            get => GetData<byte>(1025);
            set {
                if (GetData<byte>(1025) == value) return;
                SetData(1025, value, nameof(Hasten_Recovery_LBG_Recovery_Health));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Hasten_Recovery_LBG_Recovery_Health));
            }
        }

        public const string Hasten_Recovery_Success_Combo__displayName = "Hasten Recovery: Success Combo #";
        public const int Hasten_Recovery_Success_Combo__sortIndex = 20050;
        [SortOrder(Hasten_Recovery_Success_Combo__sortIndex)]
        [DisplayName(Hasten_Recovery_Success_Combo__displayName)]
        public virtual byte Hasten_Recovery_Success_Combo_ {
            get => GetData<byte>(1026);
            set {
                if (GetData<byte>(1026) == value) return;
                SetData(1026, value, nameof(Hasten_Recovery_Success_Combo_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Hasten_Recovery_Success_Combo_));
            }
        }

        public const string Hasten_Recovery_Combo_Duration_displayName = "Hasten Recovery: Combo Duration";
        public const int Hasten_Recovery_Combo_Duration_sortIndex = 20100;
        [SortOrder(Hasten_Recovery_Combo_Duration_sortIndex)]
        [DisplayName(Hasten_Recovery_Combo_Duration_displayName)]
        public virtual float Hasten_Recovery_Combo_Duration {
            get => GetData<float>(1027);
            set {
                if (GetData<float>(1027) == value) return;
                SetData(1027, value, nameof(Hasten_Recovery_Combo_Duration));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Hasten_Recovery_Combo_Duration));
            }
        }

        public const string Hasten_Recovery_Combo_Ignore_Time_displayName = "Hasten Recovery: Combo Ignore Time";
        public const int Hasten_Recovery_Combo_Ignore_Time_sortIndex = 20150;
        [SortOrder(Hasten_Recovery_Combo_Ignore_Time_sortIndex)]
        [DisplayName(Hasten_Recovery_Combo_Ignore_Time_displayName)]
        public virtual float Hasten_Recovery_Combo_Ignore_Time {
            get => GetData<float>(1031);
            set {
                if (GetData<float>(1031) == value) return;
                SetData(1031, value, nameof(Hasten_Recovery_Combo_Ignore_Time));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Hasten_Recovery_Combo_Ignore_Time));
            }
        }

        public const string __20200_displayName = "-------------------------------------------------------------------------------------------";
        public const int __20200_sortIndex = 20200;
        [SortOrder(__20200_sortIndex)]
        [DisplayName(__20200_displayName)]
        [IsReadOnly]
        public virtual byte __20200 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__20200));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__20200));
            }
        }

        public const string Unk19_displayName = "Unk19";
        public const int Unk19_sortIndex = 20250;
        [SortOrder(Unk19_sortIndex)]
        [DisplayName(Unk19_displayName)]
        public virtual byte Unk19 {
            get => GetData<byte>(1035);
            set {
                if (GetData<byte>(1035) == value) return;
                SetData(1035, value, nameof(Unk19));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk19));
            }
        }

        public const string Unk20_displayName = "Unk20";
        public const int Unk20_sortIndex = 20300;
        [SortOrder(Unk20_sortIndex)]
        [DisplayName(Unk20_displayName)]
        public virtual float Unk20 {
            get => GetData<float>(1036);
            set {
                if (GetData<float>(1036) == value) return;
                SetData(1036, value, nameof(Unk20));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk20));
            }
        }

        public const string Unk21_displayName = "Unk21";
        public const int Unk21_sortIndex = 20350;
        [SortOrder(Unk21_sortIndex)]
        [DisplayName(Unk21_displayName)]
        public virtual float Unk21 {
            get => GetData<float>(1040);
            set {
                if (GetData<float>(1040) == value) return;
                SetData(1040, value, nameof(Unk21));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk21));
            }
        }

        public const string __20400_displayName = "-------------------------------------------------------------------------------------------";
        public const int __20400_sortIndex = 20400;
        [SortOrder(__20400_sortIndex)]
        [DisplayName(__20400_displayName)]
        [IsReadOnly]
        public virtual byte __20400 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__20400));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__20400));
            }
        }

        public const string Slinger_Up_1_Stone_displayName = "Slinger Up 1: Stone";
        public const int Slinger_Up_1_Stone_sortIndex = 20450;
        [SortOrder(Slinger_Up_1_Stone_sortIndex)]
        [DisplayName(Slinger_Up_1_Stone_displayName)]
        public virtual byte Slinger_Up_1_Stone {
            get => GetData<byte>(1044);
            set {
                if (GetData<byte>(1044) == value) return;
                SetData(1044, value, nameof(Slinger_Up_1_Stone));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_1_Stone));
            }
        }

        public const string Slinger_Up_2_Stone_displayName = "Slinger Up 2: Stone";
        public const int Slinger_Up_2_Stone_sortIndex = 20500;
        [SortOrder(Slinger_Up_2_Stone_sortIndex)]
        [DisplayName(Slinger_Up_2_Stone_displayName)]
        public virtual byte Slinger_Up_2_Stone {
            get => GetData<byte>(1045);
            set {
                if (GetData<byte>(1045) == value) return;
                SetData(1045, value, nameof(Slinger_Up_2_Stone));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_2_Stone));
            }
        }

        public const string Slinger_Up_3_Stone_displayName = "Slinger Up 3: Stone";
        public const int Slinger_Up_3_Stone_sortIndex = 20550;
        [SortOrder(Slinger_Up_3_Stone_sortIndex)]
        [DisplayName(Slinger_Up_3_Stone_displayName)]
        public virtual byte Slinger_Up_3_Stone {
            get => GetData<byte>(1046);
            set {
                if (GetData<byte>(1046) == value) return;
                SetData(1046, value, nameof(Slinger_Up_3_Stone));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_3_Stone));
            }
        }

        public const string Slinger_Up_4_Stone_displayName = "Slinger Up 4: Stone";
        public const int Slinger_Up_4_Stone_sortIndex = 20600;
        [SortOrder(Slinger_Up_4_Stone_sortIndex)]
        [DisplayName(Slinger_Up_4_Stone_displayName)]
        public virtual byte Slinger_Up_4_Stone {
            get => GetData<byte>(1047);
            set {
                if (GetData<byte>(1047) == value) return;
                SetData(1047, value, nameof(Slinger_Up_4_Stone));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_4_Stone));
            }
        }

        public const string Slinger_Up_5_Stone_displayName = "Slinger Up 5: Stone";
        public const int Slinger_Up_5_Stone_sortIndex = 20650;
        [SortOrder(Slinger_Up_5_Stone_sortIndex)]
        [DisplayName(Slinger_Up_5_Stone_displayName)]
        public virtual byte Slinger_Up_5_Stone {
            get => GetData<byte>(1048);
            set {
                if (GetData<byte>(1048) == value) return;
                SetData(1048, value, nameof(Slinger_Up_5_Stone));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_5_Stone));
            }
        }

        public const string __20700_displayName = "-------------------------------------------------------------------------------------------";
        public const int __20700_sortIndex = 20700;
        [SortOrder(__20700_sortIndex)]
        [DisplayName(__20700_displayName)]
        [IsReadOnly]
        public virtual byte __20700 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__20700));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__20700));
            }
        }

        public const string Slinger_Up_1_Redpit_displayName = "Slinger Up 1: Redpit";
        public const int Slinger_Up_1_Redpit_sortIndex = 20750;
        [SortOrder(Slinger_Up_1_Redpit_sortIndex)]
        [DisplayName(Slinger_Up_1_Redpit_displayName)]
        public virtual byte Slinger_Up_1_Redpit {
            get => GetData<byte>(1049);
            set {
                if (GetData<byte>(1049) == value) return;
                SetData(1049, value, nameof(Slinger_Up_1_Redpit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_1_Redpit));
            }
        }

        public const string Slinger_Up_2_Redpit_displayName = "Slinger Up 2: Redpit";
        public const int Slinger_Up_2_Redpit_sortIndex = 20800;
        [SortOrder(Slinger_Up_2_Redpit_sortIndex)]
        [DisplayName(Slinger_Up_2_Redpit_displayName)]
        public virtual byte Slinger_Up_2_Redpit {
            get => GetData<byte>(1050);
            set {
                if (GetData<byte>(1050) == value) return;
                SetData(1050, value, nameof(Slinger_Up_2_Redpit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_2_Redpit));
            }
        }

        public const string Slinger_Up_3_Redpit_displayName = "Slinger Up 3: Redpit";
        public const int Slinger_Up_3_Redpit_sortIndex = 20850;
        [SortOrder(Slinger_Up_3_Redpit_sortIndex)]
        [DisplayName(Slinger_Up_3_Redpit_displayName)]
        public virtual byte Slinger_Up_3_Redpit {
            get => GetData<byte>(1051);
            set {
                if (GetData<byte>(1051) == value) return;
                SetData(1051, value, nameof(Slinger_Up_3_Redpit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_3_Redpit));
            }
        }

        public const string Slinger_Up_4_Redpit_displayName = "Slinger Up 4: Redpit";
        public const int Slinger_Up_4_Redpit_sortIndex = 20900;
        [SortOrder(Slinger_Up_4_Redpit_sortIndex)]
        [DisplayName(Slinger_Up_4_Redpit_displayName)]
        public virtual byte Slinger_Up_4_Redpit {
            get => GetData<byte>(1052);
            set {
                if (GetData<byte>(1052) == value) return;
                SetData(1052, value, nameof(Slinger_Up_4_Redpit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_4_Redpit));
            }
        }

        public const string Slinger_Up_5_Redpit_displayName = "Slinger Up 5: Redpit";
        public const int Slinger_Up_5_Redpit_sortIndex = 20950;
        [SortOrder(Slinger_Up_5_Redpit_sortIndex)]
        [DisplayName(Slinger_Up_5_Redpit_displayName)]
        public virtual byte Slinger_Up_5_Redpit {
            get => GetData<byte>(1053);
            set {
                if (GetData<byte>(1053) == value) return;
                SetData(1053, value, nameof(Slinger_Up_5_Redpit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_5_Redpit));
            }
        }

        public const string __21000_displayName = "-------------------------------------------------------------------------------------------";
        public const int __21000_sortIndex = 21000;
        [SortOrder(__21000_sortIndex)]
        [DisplayName(__21000_displayName)]
        [IsReadOnly]
        public virtual byte __21000 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__21000));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__21000));
            }
        }

        public const string Slinger_Up_1_Brightmoss_displayName = "Slinger Up 1: Brightmoss";
        public const int Slinger_Up_1_Brightmoss_sortIndex = 21050;
        [SortOrder(Slinger_Up_1_Brightmoss_sortIndex)]
        [DisplayName(Slinger_Up_1_Brightmoss_displayName)]
        public virtual byte Slinger_Up_1_Brightmoss {
            get => GetData<byte>(1054);
            set {
                if (GetData<byte>(1054) == value) return;
                SetData(1054, value, nameof(Slinger_Up_1_Brightmoss));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_1_Brightmoss));
            }
        }

        public const string Slinger_Up_2_Brightmoss_displayName = "Slinger Up 2: Brightmoss";
        public const int Slinger_Up_2_Brightmoss_sortIndex = 21100;
        [SortOrder(Slinger_Up_2_Brightmoss_sortIndex)]
        [DisplayName(Slinger_Up_2_Brightmoss_displayName)]
        public virtual byte Slinger_Up_2_Brightmoss {
            get => GetData<byte>(1055);
            set {
                if (GetData<byte>(1055) == value) return;
                SetData(1055, value, nameof(Slinger_Up_2_Brightmoss));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_2_Brightmoss));
            }
        }

        public const string Slinger_Up_3_Brightmoss_displayName = "Slinger Up 3: Brightmoss";
        public const int Slinger_Up_3_Brightmoss_sortIndex = 21150;
        [SortOrder(Slinger_Up_3_Brightmoss_sortIndex)]
        [DisplayName(Slinger_Up_3_Brightmoss_displayName)]
        public virtual byte Slinger_Up_3_Brightmoss {
            get => GetData<byte>(1056);
            set {
                if (GetData<byte>(1056) == value) return;
                SetData(1056, value, nameof(Slinger_Up_3_Brightmoss));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_3_Brightmoss));
            }
        }

        public const string Slinger_Up_4_Brightmoss_displayName = "Slinger Up 4: Brightmoss";
        public const int Slinger_Up_4_Brightmoss_sortIndex = 21200;
        [SortOrder(Slinger_Up_4_Brightmoss_sortIndex)]
        [DisplayName(Slinger_Up_4_Brightmoss_displayName)]
        public virtual byte Slinger_Up_4_Brightmoss {
            get => GetData<byte>(1057);
            set {
                if (GetData<byte>(1057) == value) return;
                SetData(1057, value, nameof(Slinger_Up_4_Brightmoss));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_4_Brightmoss));
            }
        }

        public const string Slinger_Up_5_Brightmoss_displayName = "Slinger Up 5: Brightmoss";
        public const int Slinger_Up_5_Brightmoss_sortIndex = 21250;
        [SortOrder(Slinger_Up_5_Brightmoss_sortIndex)]
        [DisplayName(Slinger_Up_5_Brightmoss_displayName)]
        public virtual byte Slinger_Up_5_Brightmoss {
            get => GetData<byte>(1058);
            set {
                if (GetData<byte>(1058) == value) return;
                SetData(1058, value, nameof(Slinger_Up_5_Brightmoss));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_5_Brightmoss));
            }
        }

        public const string __21300_displayName = "-------------------------------------------------------------------------------------------";
        public const int __21300_sortIndex = 21300;
        [SortOrder(__21300_sortIndex)]
        [DisplayName(__21300_displayName)]
        [IsReadOnly]
        public virtual byte __21300 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__21300));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__21300));
            }
        }

        public const string Slinger_Up_1_Scatternut_displayName = "Slinger Up 1: Scatternut";
        public const int Slinger_Up_1_Scatternut_sortIndex = 21350;
        [SortOrder(Slinger_Up_1_Scatternut_sortIndex)]
        [DisplayName(Slinger_Up_1_Scatternut_displayName)]
        public virtual byte Slinger_Up_1_Scatternut {
            get => GetData<byte>(1059);
            set {
                if (GetData<byte>(1059) == value) return;
                SetData(1059, value, nameof(Slinger_Up_1_Scatternut));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_1_Scatternut));
            }
        }

        public const string Slinger_Up_2_Scatternut_displayName = "Slinger Up 2: Scatternut";
        public const int Slinger_Up_2_Scatternut_sortIndex = 21400;
        [SortOrder(Slinger_Up_2_Scatternut_sortIndex)]
        [DisplayName(Slinger_Up_2_Scatternut_displayName)]
        public virtual byte Slinger_Up_2_Scatternut {
            get => GetData<byte>(1060);
            set {
                if (GetData<byte>(1060) == value) return;
                SetData(1060, value, nameof(Slinger_Up_2_Scatternut));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_2_Scatternut));
            }
        }

        public const string Slinger_Up_3_Scatternut_displayName = "Slinger Up 3: Scatternut";
        public const int Slinger_Up_3_Scatternut_sortIndex = 21450;
        [SortOrder(Slinger_Up_3_Scatternut_sortIndex)]
        [DisplayName(Slinger_Up_3_Scatternut_displayName)]
        public virtual byte Slinger_Up_3_Scatternut {
            get => GetData<byte>(1061);
            set {
                if (GetData<byte>(1061) == value) return;
                SetData(1061, value, nameof(Slinger_Up_3_Scatternut));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_3_Scatternut));
            }
        }

        public const string Slinger_Up_4_Scatternut_displayName = "Slinger Up 4: Scatternut";
        public const int Slinger_Up_4_Scatternut_sortIndex = 21500;
        [SortOrder(Slinger_Up_4_Scatternut_sortIndex)]
        [DisplayName(Slinger_Up_4_Scatternut_displayName)]
        public virtual byte Slinger_Up_4_Scatternut {
            get => GetData<byte>(1062);
            set {
                if (GetData<byte>(1062) == value) return;
                SetData(1062, value, nameof(Slinger_Up_4_Scatternut));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_4_Scatternut));
            }
        }

        public const string Slinger_Up_5_Scatternut_displayName = "Slinger Up 5: Scatternut";
        public const int Slinger_Up_5_Scatternut_sortIndex = 21550;
        [SortOrder(Slinger_Up_5_Scatternut_sortIndex)]
        [DisplayName(Slinger_Up_5_Scatternut_displayName)]
        public virtual byte Slinger_Up_5_Scatternut {
            get => GetData<byte>(1063);
            set {
                if (GetData<byte>(1063) == value) return;
                SetData(1063, value, nameof(Slinger_Up_5_Scatternut));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_5_Scatternut));
            }
        }

        public const string __21600_displayName = "-------------------------------------------------------------------------------------------";
        public const int __21600_sortIndex = 21600;
        [SortOrder(__21600_sortIndex)]
        [DisplayName(__21600_displayName)]
        [IsReadOnly]
        public virtual byte __21600 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__21600));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__21600));
            }
        }

        public const string Slinger_Up_1_Unk_1_displayName = "Slinger Up 1: Unk 1";
        public const int Slinger_Up_1_Unk_1_sortIndex = 21650;
        [SortOrder(Slinger_Up_1_Unk_1_sortIndex)]
        [DisplayName(Slinger_Up_1_Unk_1_displayName)]
        public virtual byte Slinger_Up_1_Unk_1 {
            get => GetData<byte>(1064);
            set {
                if (GetData<byte>(1064) == value) return;
                SetData(1064, value, nameof(Slinger_Up_1_Unk_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_1_Unk_1));
            }
        }

        public const string Slinger_Up_2_Unk_1_displayName = "Slinger Up 2: Unk 1";
        public const int Slinger_Up_2_Unk_1_sortIndex = 21700;
        [SortOrder(Slinger_Up_2_Unk_1_sortIndex)]
        [DisplayName(Slinger_Up_2_Unk_1_displayName)]
        public virtual byte Slinger_Up_2_Unk_1 {
            get => GetData<byte>(1065);
            set {
                if (GetData<byte>(1065) == value) return;
                SetData(1065, value, nameof(Slinger_Up_2_Unk_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_2_Unk_1));
            }
        }

        public const string Slinger_Up_3_Unk_1_displayName = "Slinger Up 3: Unk 1";
        public const int Slinger_Up_3_Unk_1_sortIndex = 21750;
        [SortOrder(Slinger_Up_3_Unk_1_sortIndex)]
        [DisplayName(Slinger_Up_3_Unk_1_displayName)]
        public virtual byte Slinger_Up_3_Unk_1 {
            get => GetData<byte>(1066);
            set {
                if (GetData<byte>(1066) == value) return;
                SetData(1066, value, nameof(Slinger_Up_3_Unk_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_3_Unk_1));
            }
        }

        public const string Slinger_Up_4_Unk_1_displayName = "Slinger Up 4: Unk 1";
        public const int Slinger_Up_4_Unk_1_sortIndex = 21800;
        [SortOrder(Slinger_Up_4_Unk_1_sortIndex)]
        [DisplayName(Slinger_Up_4_Unk_1_displayName)]
        public virtual byte Slinger_Up_4_Unk_1 {
            get => GetData<byte>(1067);
            set {
                if (GetData<byte>(1067) == value) return;
                SetData(1067, value, nameof(Slinger_Up_4_Unk_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_4_Unk_1));
            }
        }

        public const string Slinger_Up_5_Unk_1_displayName = "Slinger Up 5: Unk 1";
        public const int Slinger_Up_5_Unk_1_sortIndex = 21850;
        [SortOrder(Slinger_Up_5_Unk_1_sortIndex)]
        [DisplayName(Slinger_Up_5_Unk_1_displayName)]
        public virtual byte Slinger_Up_5_Unk_1 {
            get => GetData<byte>(1068);
            set {
                if (GetData<byte>(1068) == value) return;
                SetData(1068, value, nameof(Slinger_Up_5_Unk_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_5_Unk_1));
            }
        }

        public const string __21900_displayName = "-------------------------------------------------------------------------------------------";
        public const int __21900_sortIndex = 21900;
        [SortOrder(__21900_sortIndex)]
        [DisplayName(__21900_displayName)]
        [IsReadOnly]
        public virtual byte __21900 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__21900));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__21900));
            }
        }

        public const string Slinger_Up_1_Unk_2_displayName = "Slinger Up 1: Unk 2";
        public const int Slinger_Up_1_Unk_2_sortIndex = 21950;
        [SortOrder(Slinger_Up_1_Unk_2_sortIndex)]
        [DisplayName(Slinger_Up_1_Unk_2_displayName)]
        public virtual byte Slinger_Up_1_Unk_2 {
            get => GetData<byte>(1069);
            set {
                if (GetData<byte>(1069) == value) return;
                SetData(1069, value, nameof(Slinger_Up_1_Unk_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_1_Unk_2));
            }
        }

        public const string Slinger_Up_2_Unk_2_displayName = "Slinger Up 2: Unk 2";
        public const int Slinger_Up_2_Unk_2_sortIndex = 22000;
        [SortOrder(Slinger_Up_2_Unk_2_sortIndex)]
        [DisplayName(Slinger_Up_2_Unk_2_displayName)]
        public virtual byte Slinger_Up_2_Unk_2 {
            get => GetData<byte>(1070);
            set {
                if (GetData<byte>(1070) == value) return;
                SetData(1070, value, nameof(Slinger_Up_2_Unk_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_2_Unk_2));
            }
        }

        public const string Slinger_Up_3_Unk_2_displayName = "Slinger Up 3: Unk 2";
        public const int Slinger_Up_3_Unk_2_sortIndex = 22050;
        [SortOrder(Slinger_Up_3_Unk_2_sortIndex)]
        [DisplayName(Slinger_Up_3_Unk_2_displayName)]
        public virtual byte Slinger_Up_3_Unk_2 {
            get => GetData<byte>(1071);
            set {
                if (GetData<byte>(1071) == value) return;
                SetData(1071, value, nameof(Slinger_Up_3_Unk_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_3_Unk_2));
            }
        }

        public const string Slinger_Up_4_Unk_2_displayName = "Slinger Up 4: Unk 2";
        public const int Slinger_Up_4_Unk_2_sortIndex = 22100;
        [SortOrder(Slinger_Up_4_Unk_2_sortIndex)]
        [DisplayName(Slinger_Up_4_Unk_2_displayName)]
        public virtual byte Slinger_Up_4_Unk_2 {
            get => GetData<byte>(1072);
            set {
                if (GetData<byte>(1072) == value) return;
                SetData(1072, value, nameof(Slinger_Up_4_Unk_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_4_Unk_2));
            }
        }

        public const string Slinger_Up_5_Unk_2_displayName = "Slinger Up 5: Unk 2";
        public const int Slinger_Up_5_Unk_2_sortIndex = 22150;
        [SortOrder(Slinger_Up_5_Unk_2_sortIndex)]
        [DisplayName(Slinger_Up_5_Unk_2_displayName)]
        public virtual byte Slinger_Up_5_Unk_2 {
            get => GetData<byte>(1073);
            set {
                if (GetData<byte>(1073) == value) return;
                SetData(1073, value, nameof(Slinger_Up_5_Unk_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_5_Unk_2));
            }
        }

        public const string __22200_displayName = "-------------------------------------------------------------------------------------------";
        public const int __22200_sortIndex = 22200;
        [SortOrder(__22200_sortIndex)]
        [DisplayName(__22200_displayName)]
        [IsReadOnly]
        public virtual byte __22200 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__22200));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__22200));
            }
        }

        public const string Slinger_Up_1_Unk_3_displayName = "Slinger Up 1: Unk 3";
        public const int Slinger_Up_1_Unk_3_sortIndex = 22250;
        [SortOrder(Slinger_Up_1_Unk_3_sortIndex)]
        [DisplayName(Slinger_Up_1_Unk_3_displayName)]
        public virtual byte Slinger_Up_1_Unk_3 {
            get => GetData<byte>(1074);
            set {
                if (GetData<byte>(1074) == value) return;
                SetData(1074, value, nameof(Slinger_Up_1_Unk_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_1_Unk_3));
            }
        }

        public const string Slinger_Up_2_Unk_3_displayName = "Slinger Up 2: Unk 3";
        public const int Slinger_Up_2_Unk_3_sortIndex = 22300;
        [SortOrder(Slinger_Up_2_Unk_3_sortIndex)]
        [DisplayName(Slinger_Up_2_Unk_3_displayName)]
        public virtual byte Slinger_Up_2_Unk_3 {
            get => GetData<byte>(1075);
            set {
                if (GetData<byte>(1075) == value) return;
                SetData(1075, value, nameof(Slinger_Up_2_Unk_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_2_Unk_3));
            }
        }

        public const string Slinger_Up_3_Unk_3_displayName = "Slinger Up 3: Unk 3";
        public const int Slinger_Up_3_Unk_3_sortIndex = 22350;
        [SortOrder(Slinger_Up_3_Unk_3_sortIndex)]
        [DisplayName(Slinger_Up_3_Unk_3_displayName)]
        public virtual byte Slinger_Up_3_Unk_3 {
            get => GetData<byte>(1076);
            set {
                if (GetData<byte>(1076) == value) return;
                SetData(1076, value, nameof(Slinger_Up_3_Unk_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_3_Unk_3));
            }
        }

        public const string Slinger_Up_4_Unk_3_displayName = "Slinger Up 4: Unk 3";
        public const int Slinger_Up_4_Unk_3_sortIndex = 22400;
        [SortOrder(Slinger_Up_4_Unk_3_sortIndex)]
        [DisplayName(Slinger_Up_4_Unk_3_displayName)]
        public virtual byte Slinger_Up_4_Unk_3 {
            get => GetData<byte>(1077);
            set {
                if (GetData<byte>(1077) == value) return;
                SetData(1077, value, nameof(Slinger_Up_4_Unk_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_4_Unk_3));
            }
        }

        public const string Slinger_Up_5_Unk_3_displayName = "Slinger Up 5: Unk 3";
        public const int Slinger_Up_5_Unk_3_sortIndex = 22450;
        [SortOrder(Slinger_Up_5_Unk_3_sortIndex)]
        [DisplayName(Slinger_Up_5_Unk_3_displayName)]
        public virtual byte Slinger_Up_5_Unk_3 {
            get => GetData<byte>(1078);
            set {
                if (GetData<byte>(1078) == value) return;
                SetData(1078, value, nameof(Slinger_Up_5_Unk_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_5_Unk_3));
            }
        }

        public const string __22500_displayName = "-------------------------------------------------------------------------------------------";
        public const int __22500_sortIndex = 22500;
        [SortOrder(__22500_sortIndex)]
        [DisplayName(__22500_displayName)]
        [IsReadOnly]
        public virtual byte __22500 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__22500));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__22500));
            }
        }

        public const string Slinger_Up_1_Unk_4_displayName = "Slinger Up 1: Unk 4";
        public const int Slinger_Up_1_Unk_4_sortIndex = 22550;
        [SortOrder(Slinger_Up_1_Unk_4_sortIndex)]
        [DisplayName(Slinger_Up_1_Unk_4_displayName)]
        public virtual byte Slinger_Up_1_Unk_4 {
            get => GetData<byte>(1079);
            set {
                if (GetData<byte>(1079) == value) return;
                SetData(1079, value, nameof(Slinger_Up_1_Unk_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_1_Unk_4));
            }
        }

        public const string Slinger_Up_2_Unk_4_displayName = "Slinger Up 2: Unk 4";
        public const int Slinger_Up_2_Unk_4_sortIndex = 22600;
        [SortOrder(Slinger_Up_2_Unk_4_sortIndex)]
        [DisplayName(Slinger_Up_2_Unk_4_displayName)]
        public virtual byte Slinger_Up_2_Unk_4 {
            get => GetData<byte>(1080);
            set {
                if (GetData<byte>(1080) == value) return;
                SetData(1080, value, nameof(Slinger_Up_2_Unk_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_2_Unk_4));
            }
        }

        public const string Slinger_Up_3_Unk_4_displayName = "Slinger Up 3: Unk 4";
        public const int Slinger_Up_3_Unk_4_sortIndex = 22650;
        [SortOrder(Slinger_Up_3_Unk_4_sortIndex)]
        [DisplayName(Slinger_Up_3_Unk_4_displayName)]
        public virtual byte Slinger_Up_3_Unk_4 {
            get => GetData<byte>(1081);
            set {
                if (GetData<byte>(1081) == value) return;
                SetData(1081, value, nameof(Slinger_Up_3_Unk_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_3_Unk_4));
            }
        }

        public const string Slinger_Up_4_Unk_4_displayName = "Slinger Up 4: Unk 4";
        public const int Slinger_Up_4_Unk_4_sortIndex = 22700;
        [SortOrder(Slinger_Up_4_Unk_4_sortIndex)]
        [DisplayName(Slinger_Up_4_Unk_4_displayName)]
        public virtual byte Slinger_Up_4_Unk_4 {
            get => GetData<byte>(1082);
            set {
                if (GetData<byte>(1082) == value) return;
                SetData(1082, value, nameof(Slinger_Up_4_Unk_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_4_Unk_4));
            }
        }

        public const string Slinger_Up_5_Unk_4_displayName = "Slinger Up 5: Unk 4";
        public const int Slinger_Up_5_Unk_4_sortIndex = 22750;
        [SortOrder(Slinger_Up_5_Unk_4_sortIndex)]
        [DisplayName(Slinger_Up_5_Unk_4_displayName)]
        public virtual byte Slinger_Up_5_Unk_4 {
            get => GetData<byte>(1083);
            set {
                if (GetData<byte>(1083) == value) return;
                SetData(1083, value, nameof(Slinger_Up_5_Unk_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_5_Unk_4));
            }
        }

        public const string __22800_displayName = "-------------------------------------------------------------------------------------------";
        public const int __22800_sortIndex = 22800;
        [SortOrder(__22800_sortIndex)]
        [DisplayName(__22800_displayName)]
        [IsReadOnly]
        public virtual byte __22800 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__22800));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__22800));
            }
        }

        public const string Slinger_Up_1_Unk_5_displayName = "Slinger Up 1: Unk 5";
        public const int Slinger_Up_1_Unk_5_sortIndex = 22850;
        [SortOrder(Slinger_Up_1_Unk_5_sortIndex)]
        [DisplayName(Slinger_Up_1_Unk_5_displayName)]
        public virtual byte Slinger_Up_1_Unk_5 {
            get => GetData<byte>(1084);
            set {
                if (GetData<byte>(1084) == value) return;
                SetData(1084, value, nameof(Slinger_Up_1_Unk_5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_1_Unk_5));
            }
        }

        public const string Slinger_Up_2_Unk_5_displayName = "Slinger Up 2: Unk 5";
        public const int Slinger_Up_2_Unk_5_sortIndex = 22900;
        [SortOrder(Slinger_Up_2_Unk_5_sortIndex)]
        [DisplayName(Slinger_Up_2_Unk_5_displayName)]
        public virtual byte Slinger_Up_2_Unk_5 {
            get => GetData<byte>(1085);
            set {
                if (GetData<byte>(1085) == value) return;
                SetData(1085, value, nameof(Slinger_Up_2_Unk_5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_2_Unk_5));
            }
        }

        public const string Slinger_Up_3_Unk_5_displayName = "Slinger Up 3: Unk 5";
        public const int Slinger_Up_3_Unk_5_sortIndex = 22950;
        [SortOrder(Slinger_Up_3_Unk_5_sortIndex)]
        [DisplayName(Slinger_Up_3_Unk_5_displayName)]
        public virtual byte Slinger_Up_3_Unk_5 {
            get => GetData<byte>(1086);
            set {
                if (GetData<byte>(1086) == value) return;
                SetData(1086, value, nameof(Slinger_Up_3_Unk_5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_3_Unk_5));
            }
        }

        public const string Slinger_Up_4_Unk_5_displayName = "Slinger Up 4: Unk 5";
        public const int Slinger_Up_4_Unk_5_sortIndex = 23000;
        [SortOrder(Slinger_Up_4_Unk_5_sortIndex)]
        [DisplayName(Slinger_Up_4_Unk_5_displayName)]
        public virtual byte Slinger_Up_4_Unk_5 {
            get => GetData<byte>(1087);
            set {
                if (GetData<byte>(1087) == value) return;
                SetData(1087, value, nameof(Slinger_Up_4_Unk_5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_4_Unk_5));
            }
        }

        public const string Slinger_Up_5_Unk_5_displayName = "Slinger Up 5: Unk 5";
        public const int Slinger_Up_5_Unk_5_sortIndex = 23050;
        [SortOrder(Slinger_Up_5_Unk_5_sortIndex)]
        [DisplayName(Slinger_Up_5_Unk_5_displayName)]
        public virtual byte Slinger_Up_5_Unk_5 {
            get => GetData<byte>(1088);
            set {
                if (GetData<byte>(1088) == value) return;
                SetData(1088, value, nameof(Slinger_Up_5_Unk_5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_5_Unk_5));
            }
        }

        public const string __23100_displayName = "-------------------------------------------------------------------------------------------";
        public const int __23100_sortIndex = 23100;
        [SortOrder(__23100_sortIndex)]
        [DisplayName(__23100_displayName)]
        [IsReadOnly]
        public virtual byte __23100 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__23100));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__23100));
            }
        }

        public const string Slinger_Up_1_Torch_Pod_displayName = "Slinger Up 1: Torch Pod";
        public const int Slinger_Up_1_Torch_Pod_sortIndex = 23150;
        [SortOrder(Slinger_Up_1_Torch_Pod_sortIndex)]
        [DisplayName(Slinger_Up_1_Torch_Pod_displayName)]
        public virtual byte Slinger_Up_1_Torch_Pod {
            get => GetData<byte>(1089);
            set {
                if (GetData<byte>(1089) == value) return;
                SetData(1089, value, nameof(Slinger_Up_1_Torch_Pod));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_1_Torch_Pod));
            }
        }

        public const string Slinger_Up_2_Torch_Pod_displayName = "Slinger Up 2: Torch Pod";
        public const int Slinger_Up_2_Torch_Pod_sortIndex = 23200;
        [SortOrder(Slinger_Up_2_Torch_Pod_sortIndex)]
        [DisplayName(Slinger_Up_2_Torch_Pod_displayName)]
        public virtual byte Slinger_Up_2_Torch_Pod {
            get => GetData<byte>(1090);
            set {
                if (GetData<byte>(1090) == value) return;
                SetData(1090, value, nameof(Slinger_Up_2_Torch_Pod));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_2_Torch_Pod));
            }
        }

        public const string Slinger_Up_3_Torch_Pod_displayName = "Slinger Up 3: Torch Pod";
        public const int Slinger_Up_3_Torch_Pod_sortIndex = 23250;
        [SortOrder(Slinger_Up_3_Torch_Pod_sortIndex)]
        [DisplayName(Slinger_Up_3_Torch_Pod_displayName)]
        public virtual byte Slinger_Up_3_Torch_Pod {
            get => GetData<byte>(1091);
            set {
                if (GetData<byte>(1091) == value) return;
                SetData(1091, value, nameof(Slinger_Up_3_Torch_Pod));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_3_Torch_Pod));
            }
        }

        public const string Slinger_Up_4_Torch_Pod_displayName = "Slinger Up 4: Torch Pod";
        public const int Slinger_Up_4_Torch_Pod_sortIndex = 23300;
        [SortOrder(Slinger_Up_4_Torch_Pod_sortIndex)]
        [DisplayName(Slinger_Up_4_Torch_Pod_displayName)]
        public virtual byte Slinger_Up_4_Torch_Pod {
            get => GetData<byte>(1092);
            set {
                if (GetData<byte>(1092) == value) return;
                SetData(1092, value, nameof(Slinger_Up_4_Torch_Pod));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_4_Torch_Pod));
            }
        }

        public const string Slinger_Up_5_Torch_Pod_displayName = "Slinger Up 5: Torch Pod";
        public const int Slinger_Up_5_Torch_Pod_sortIndex = 23350;
        [SortOrder(Slinger_Up_5_Torch_Pod_sortIndex)]
        [DisplayName(Slinger_Up_5_Torch_Pod_displayName)]
        public virtual byte Slinger_Up_5_Torch_Pod {
            get => GetData<byte>(1093);
            set {
                if (GetData<byte>(1093) == value) return;
                SetData(1093, value, nameof(Slinger_Up_5_Torch_Pod));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_5_Torch_Pod));
            }
        }

        public const string __23400_displayName = "-------------------------------------------------------------------------------------------";
        public const int __23400_sortIndex = 23400;
        [SortOrder(__23400_sortIndex)]
        [DisplayName(__23400_displayName)]
        [IsReadOnly]
        public virtual byte __23400 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__23400));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__23400));
            }
        }

        public const string Slinger_Up_1_Unk_6_displayName = "Slinger Up 1: Unk 6";
        public const int Slinger_Up_1_Unk_6_sortIndex = 23450;
        [SortOrder(Slinger_Up_1_Unk_6_sortIndex)]
        [DisplayName(Slinger_Up_1_Unk_6_displayName)]
        public virtual byte Slinger_Up_1_Unk_6 {
            get => GetData<byte>(1094);
            set {
                if (GetData<byte>(1094) == value) return;
                SetData(1094, value, nameof(Slinger_Up_1_Unk_6));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_1_Unk_6));
            }
        }

        public const string Slinger_Up_2_Unk_6_displayName = "Slinger Up 2: Unk 6";
        public const int Slinger_Up_2_Unk_6_sortIndex = 23500;
        [SortOrder(Slinger_Up_2_Unk_6_sortIndex)]
        [DisplayName(Slinger_Up_2_Unk_6_displayName)]
        public virtual byte Slinger_Up_2_Unk_6 {
            get => GetData<byte>(1095);
            set {
                if (GetData<byte>(1095) == value) return;
                SetData(1095, value, nameof(Slinger_Up_2_Unk_6));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_2_Unk_6));
            }
        }

        public const string Slinger_Up_3_Unk_6_displayName = "Slinger Up 3: Unk 6";
        public const int Slinger_Up_3_Unk_6_sortIndex = 23550;
        [SortOrder(Slinger_Up_3_Unk_6_sortIndex)]
        [DisplayName(Slinger_Up_3_Unk_6_displayName)]
        public virtual byte Slinger_Up_3_Unk_6 {
            get => GetData<byte>(1096);
            set {
                if (GetData<byte>(1096) == value) return;
                SetData(1096, value, nameof(Slinger_Up_3_Unk_6));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_3_Unk_6));
            }
        }

        public const string Slinger_Up_4_Unk_6_displayName = "Slinger Up 4: Unk 6";
        public const int Slinger_Up_4_Unk_6_sortIndex = 23600;
        [SortOrder(Slinger_Up_4_Unk_6_sortIndex)]
        [DisplayName(Slinger_Up_4_Unk_6_displayName)]
        public virtual byte Slinger_Up_4_Unk_6 {
            get => GetData<byte>(1097);
            set {
                if (GetData<byte>(1097) == value) return;
                SetData(1097, value, nameof(Slinger_Up_4_Unk_6));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_4_Unk_6));
            }
        }

        public const string Slinger_Up_5_Unk_6_displayName = "Slinger Up 5: Unk 6";
        public const int Slinger_Up_5_Unk_6_sortIndex = 23650;
        [SortOrder(Slinger_Up_5_Unk_6_sortIndex)]
        [DisplayName(Slinger_Up_5_Unk_6_displayName)]
        public virtual byte Slinger_Up_5_Unk_6 {
            get => GetData<byte>(1098);
            set {
                if (GetData<byte>(1098) == value) return;
                SetData(1098, value, nameof(Slinger_Up_5_Unk_6));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_5_Unk_6));
            }
        }

        public const string __23700_displayName = "-------------------------------------------------------------------------------------------";
        public const int __23700_sortIndex = 23700;
        [SortOrder(__23700_sortIndex)]
        [DisplayName(__23700_displayName)]
        [IsReadOnly]
        public virtual byte __23700 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__23700));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__23700));
            }
        }

        public const string Slinger_Up_1_Unk_7_displayName = "Slinger Up 1: Unk 7";
        public const int Slinger_Up_1_Unk_7_sortIndex = 23750;
        [SortOrder(Slinger_Up_1_Unk_7_sortIndex)]
        [DisplayName(Slinger_Up_1_Unk_7_displayName)]
        public virtual byte Slinger_Up_1_Unk_7 {
            get => GetData<byte>(1099);
            set {
                if (GetData<byte>(1099) == value) return;
                SetData(1099, value, nameof(Slinger_Up_1_Unk_7));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_1_Unk_7));
            }
        }

        public const string Slinger_Up_2_Unk_7_displayName = "Slinger Up 2: Unk 7";
        public const int Slinger_Up_2_Unk_7_sortIndex = 23800;
        [SortOrder(Slinger_Up_2_Unk_7_sortIndex)]
        [DisplayName(Slinger_Up_2_Unk_7_displayName)]
        public virtual byte Slinger_Up_2_Unk_7 {
            get => GetData<byte>(1100);
            set {
                if (GetData<byte>(1100) == value) return;
                SetData(1100, value, nameof(Slinger_Up_2_Unk_7));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_2_Unk_7));
            }
        }

        public const string Slinger_Up_3_Unk_7_displayName = "Slinger Up 3: Unk 7";
        public const int Slinger_Up_3_Unk_7_sortIndex = 23850;
        [SortOrder(Slinger_Up_3_Unk_7_sortIndex)]
        [DisplayName(Slinger_Up_3_Unk_7_displayName)]
        public virtual byte Slinger_Up_3_Unk_7 {
            get => GetData<byte>(1101);
            set {
                if (GetData<byte>(1101) == value) return;
                SetData(1101, value, nameof(Slinger_Up_3_Unk_7));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_3_Unk_7));
            }
        }

        public const string Slinger_Up_4_Unk_7_displayName = "Slinger Up 4: Unk 7";
        public const int Slinger_Up_4_Unk_7_sortIndex = 23900;
        [SortOrder(Slinger_Up_4_Unk_7_sortIndex)]
        [DisplayName(Slinger_Up_4_Unk_7_displayName)]
        public virtual byte Slinger_Up_4_Unk_7 {
            get => GetData<byte>(1102);
            set {
                if (GetData<byte>(1102) == value) return;
                SetData(1102, value, nameof(Slinger_Up_4_Unk_7));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_4_Unk_7));
            }
        }

        public const string Slinger_Up_5_Unk_7_displayName = "Slinger Up 5: Unk 7";
        public const int Slinger_Up_5_Unk_7_sortIndex = 23950;
        [SortOrder(Slinger_Up_5_Unk_7_sortIndex)]
        [DisplayName(Slinger_Up_5_Unk_7_displayName)]
        public virtual byte Slinger_Up_5_Unk_7 {
            get => GetData<byte>(1103);
            set {
                if (GetData<byte>(1103) == value) return;
                SetData(1103, value, nameof(Slinger_Up_5_Unk_7));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_5_Unk_7));
            }
        }

        public const string __24000_displayName = "-------------------------------------------------------------------------------------------";
        public const int __24000_sortIndex = 24000;
        [SortOrder(__24000_sortIndex)]
        [DisplayName(__24000_displayName)]
        [IsReadOnly]
        public virtual byte __24000 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__24000));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__24000));
            }
        }

        public const string Slinger_Up_1_Unk_8_displayName = "Slinger Up 1: Unk 8";
        public const int Slinger_Up_1_Unk_8_sortIndex = 24050;
        [SortOrder(Slinger_Up_1_Unk_8_sortIndex)]
        [DisplayName(Slinger_Up_1_Unk_8_displayName)]
        public virtual byte Slinger_Up_1_Unk_8 {
            get => GetData<byte>(1104);
            set {
                if (GetData<byte>(1104) == value) return;
                SetData(1104, value, nameof(Slinger_Up_1_Unk_8));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_1_Unk_8));
            }
        }

        public const string Slinger_Up_2_Unk_8_displayName = "Slinger Up 2: Unk 8";
        public const int Slinger_Up_2_Unk_8_sortIndex = 24100;
        [SortOrder(Slinger_Up_2_Unk_8_sortIndex)]
        [DisplayName(Slinger_Up_2_Unk_8_displayName)]
        public virtual byte Slinger_Up_2_Unk_8 {
            get => GetData<byte>(1105);
            set {
                if (GetData<byte>(1105) == value) return;
                SetData(1105, value, nameof(Slinger_Up_2_Unk_8));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_2_Unk_8));
            }
        }

        public const string Slinger_Up_3_Unk_8_displayName = "Slinger Up 3: Unk 8";
        public const int Slinger_Up_3_Unk_8_sortIndex = 24150;
        [SortOrder(Slinger_Up_3_Unk_8_sortIndex)]
        [DisplayName(Slinger_Up_3_Unk_8_displayName)]
        public virtual byte Slinger_Up_3_Unk_8 {
            get => GetData<byte>(1106);
            set {
                if (GetData<byte>(1106) == value) return;
                SetData(1106, value, nameof(Slinger_Up_3_Unk_8));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_3_Unk_8));
            }
        }

        public const string Slinger_Up_4_Unk_8_displayName = "Slinger Up 4: Unk 8";
        public const int Slinger_Up_4_Unk_8_sortIndex = 24200;
        [SortOrder(Slinger_Up_4_Unk_8_sortIndex)]
        [DisplayName(Slinger_Up_4_Unk_8_displayName)]
        public virtual byte Slinger_Up_4_Unk_8 {
            get => GetData<byte>(1107);
            set {
                if (GetData<byte>(1107) == value) return;
                SetData(1107, value, nameof(Slinger_Up_4_Unk_8));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_4_Unk_8));
            }
        }

        public const string Slinger_Up_5_Unk_8_displayName = "Slinger Up 5: Unk 8";
        public const int Slinger_Up_5_Unk_8_sortIndex = 24250;
        [SortOrder(Slinger_Up_5_Unk_8_sortIndex)]
        [DisplayName(Slinger_Up_5_Unk_8_displayName)]
        public virtual byte Slinger_Up_5_Unk_8 {
            get => GetData<byte>(1108);
            set {
                if (GetData<byte>(1108) == value) return;
                SetData(1108, value, nameof(Slinger_Up_5_Unk_8));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_5_Unk_8));
            }
        }

        public const string __24300_displayName = "-------------------------------------------------------------------------------------------";
        public const int __24300_sortIndex = 24300;
        [SortOrder(__24300_sortIndex)]
        [DisplayName(__24300_displayName)]
        [IsReadOnly]
        public virtual byte __24300 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__24300));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__24300));
            }
        }

        public const string Slinger_Up_1_Unk_9_displayName = "Slinger Up 1: Unk 9";
        public const int Slinger_Up_1_Unk_9_sortIndex = 24350;
        [SortOrder(Slinger_Up_1_Unk_9_sortIndex)]
        [DisplayName(Slinger_Up_1_Unk_9_displayName)]
        public virtual byte Slinger_Up_1_Unk_9 {
            get => GetData<byte>(1109);
            set {
                if (GetData<byte>(1109) == value) return;
                SetData(1109, value, nameof(Slinger_Up_1_Unk_9));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_1_Unk_9));
            }
        }

        public const string Slinger_Up_2_Unk_9_displayName = "Slinger Up 2: Unk 9";
        public const int Slinger_Up_2_Unk_9_sortIndex = 24400;
        [SortOrder(Slinger_Up_2_Unk_9_sortIndex)]
        [DisplayName(Slinger_Up_2_Unk_9_displayName)]
        public virtual byte Slinger_Up_2_Unk_9 {
            get => GetData<byte>(1110);
            set {
                if (GetData<byte>(1110) == value) return;
                SetData(1110, value, nameof(Slinger_Up_2_Unk_9));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_2_Unk_9));
            }
        }

        public const string Slinger_Up_3_Unk_9_displayName = "Slinger Up 3: Unk 9";
        public const int Slinger_Up_3_Unk_9_sortIndex = 24450;
        [SortOrder(Slinger_Up_3_Unk_9_sortIndex)]
        [DisplayName(Slinger_Up_3_Unk_9_displayName)]
        public virtual byte Slinger_Up_3_Unk_9 {
            get => GetData<byte>(1111);
            set {
                if (GetData<byte>(1111) == value) return;
                SetData(1111, value, nameof(Slinger_Up_3_Unk_9));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_3_Unk_9));
            }
        }

        public const string Slinger_Up_4_Unk_9_displayName = "Slinger Up 4: Unk 9";
        public const int Slinger_Up_4_Unk_9_sortIndex = 24500;
        [SortOrder(Slinger_Up_4_Unk_9_sortIndex)]
        [DisplayName(Slinger_Up_4_Unk_9_displayName)]
        public virtual byte Slinger_Up_4_Unk_9 {
            get => GetData<byte>(1112);
            set {
                if (GetData<byte>(1112) == value) return;
                SetData(1112, value, nameof(Slinger_Up_4_Unk_9));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_4_Unk_9));
            }
        }

        public const string Slinger_Up_5_Unk_9_displayName = "Slinger Up 5: Unk 9";
        public const int Slinger_Up_5_Unk_9_sortIndex = 24550;
        [SortOrder(Slinger_Up_5_Unk_9_sortIndex)]
        [DisplayName(Slinger_Up_5_Unk_9_displayName)]
        public virtual byte Slinger_Up_5_Unk_9 {
            get => GetData<byte>(1113);
            set {
                if (GetData<byte>(1113) == value) return;
                SetData(1113, value, nameof(Slinger_Up_5_Unk_9));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_5_Unk_9));
            }
        }

        public const string __24600_displayName = "-------------------------------------------------------------------------------------------";
        public const int __24600_sortIndex = 24600;
        [SortOrder(__24600_sortIndex)]
        [DisplayName(__24600_displayName)]
        [IsReadOnly]
        public virtual byte __24600 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__24600));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__24600));
            }
        }

        public const string Slinger_Up_1_Bomb_Pod_displayName = "Slinger Up 1: Bomb Pod";
        public const int Slinger_Up_1_Bomb_Pod_sortIndex = 24650;
        [SortOrder(Slinger_Up_1_Bomb_Pod_sortIndex)]
        [DisplayName(Slinger_Up_1_Bomb_Pod_displayName)]
        public virtual byte Slinger_Up_1_Bomb_Pod {
            get => GetData<byte>(1114);
            set {
                if (GetData<byte>(1114) == value) return;
                SetData(1114, value, nameof(Slinger_Up_1_Bomb_Pod));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_1_Bomb_Pod));
            }
        }

        public const string Slinger_Up_2_Bomb_Pod_displayName = "Slinger Up 2: Bomb Pod";
        public const int Slinger_Up_2_Bomb_Pod_sortIndex = 24700;
        [SortOrder(Slinger_Up_2_Bomb_Pod_sortIndex)]
        [DisplayName(Slinger_Up_2_Bomb_Pod_displayName)]
        public virtual byte Slinger_Up_2_Bomb_Pod {
            get => GetData<byte>(1115);
            set {
                if (GetData<byte>(1115) == value) return;
                SetData(1115, value, nameof(Slinger_Up_2_Bomb_Pod));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_2_Bomb_Pod));
            }
        }

        public const string Slinger_Up_3_Bomb_Pod_displayName = "Slinger Up 3: Bomb Pod";
        public const int Slinger_Up_3_Bomb_Pod_sortIndex = 24750;
        [SortOrder(Slinger_Up_3_Bomb_Pod_sortIndex)]
        [DisplayName(Slinger_Up_3_Bomb_Pod_displayName)]
        public virtual byte Slinger_Up_3_Bomb_Pod {
            get => GetData<byte>(1116);
            set {
                if (GetData<byte>(1116) == value) return;
                SetData(1116, value, nameof(Slinger_Up_3_Bomb_Pod));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_3_Bomb_Pod));
            }
        }

        public const string Slinger_Up_4_Bomb_Pod_displayName = "Slinger Up 4: Bomb Pod";
        public const int Slinger_Up_4_Bomb_Pod_sortIndex = 24800;
        [SortOrder(Slinger_Up_4_Bomb_Pod_sortIndex)]
        [DisplayName(Slinger_Up_4_Bomb_Pod_displayName)]
        public virtual byte Slinger_Up_4_Bomb_Pod {
            get => GetData<byte>(1117);
            set {
                if (GetData<byte>(1117) == value) return;
                SetData(1117, value, nameof(Slinger_Up_4_Bomb_Pod));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_4_Bomb_Pod));
            }
        }

        public const string Slinger_Up_5_Bomb_Pod_displayName = "Slinger Up 5: Bomb Pod";
        public const int Slinger_Up_5_Bomb_Pod_sortIndex = 24850;
        [SortOrder(Slinger_Up_5_Bomb_Pod_sortIndex)]
        [DisplayName(Slinger_Up_5_Bomb_Pod_displayName)]
        public virtual byte Slinger_Up_5_Bomb_Pod {
            get => GetData<byte>(1118);
            set {
                if (GetData<byte>(1118) == value) return;
                SetData(1118, value, nameof(Slinger_Up_5_Bomb_Pod));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_5_Bomb_Pod));
            }
        }

        public const string __24900_displayName = "-------------------------------------------------------------------------------------------";
        public const int __24900_sortIndex = 24900;
        [SortOrder(__24900_sortIndex)]
        [DisplayName(__24900_displayName)]
        [IsReadOnly]
        public virtual byte __24900 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__24900));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__24900));
            }
        }

        public const string Slinger_Up_1_Piercing_Pod_displayName = "Slinger Up 1: Piercing Pod";
        public const int Slinger_Up_1_Piercing_Pod_sortIndex = 24950;
        [SortOrder(Slinger_Up_1_Piercing_Pod_sortIndex)]
        [DisplayName(Slinger_Up_1_Piercing_Pod_displayName)]
        public virtual byte Slinger_Up_1_Piercing_Pod {
            get => GetData<byte>(1119);
            set {
                if (GetData<byte>(1119) == value) return;
                SetData(1119, value, nameof(Slinger_Up_1_Piercing_Pod));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_1_Piercing_Pod));
            }
        }

        public const string Slinger_Up_2_Piercing_Pod_displayName = "Slinger Up 2: Piercing Pod";
        public const int Slinger_Up_2_Piercing_Pod_sortIndex = 25000;
        [SortOrder(Slinger_Up_2_Piercing_Pod_sortIndex)]
        [DisplayName(Slinger_Up_2_Piercing_Pod_displayName)]
        public virtual byte Slinger_Up_2_Piercing_Pod {
            get => GetData<byte>(1120);
            set {
                if (GetData<byte>(1120) == value) return;
                SetData(1120, value, nameof(Slinger_Up_2_Piercing_Pod));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_2_Piercing_Pod));
            }
        }

        public const string Slinger_Up_3_Piercing_Pod_displayName = "Slinger Up 3: Piercing Pod";
        public const int Slinger_Up_3_Piercing_Pod_sortIndex = 25050;
        [SortOrder(Slinger_Up_3_Piercing_Pod_sortIndex)]
        [DisplayName(Slinger_Up_3_Piercing_Pod_displayName)]
        public virtual byte Slinger_Up_3_Piercing_Pod {
            get => GetData<byte>(1121);
            set {
                if (GetData<byte>(1121) == value) return;
                SetData(1121, value, nameof(Slinger_Up_3_Piercing_Pod));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_3_Piercing_Pod));
            }
        }

        public const string Slinger_Up_4_Piercing_Pod_displayName = "Slinger Up 4: Piercing Pod";
        public const int Slinger_Up_4_Piercing_Pod_sortIndex = 25100;
        [SortOrder(Slinger_Up_4_Piercing_Pod_sortIndex)]
        [DisplayName(Slinger_Up_4_Piercing_Pod_displayName)]
        public virtual byte Slinger_Up_4_Piercing_Pod {
            get => GetData<byte>(1122);
            set {
                if (GetData<byte>(1122) == value) return;
                SetData(1122, value, nameof(Slinger_Up_4_Piercing_Pod));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_4_Piercing_Pod));
            }
        }

        public const string Slinger_Up_5_Piercing_Pod_displayName = "Slinger Up 5: Piercing Pod";
        public const int Slinger_Up_5_Piercing_Pod_sortIndex = 25150;
        [SortOrder(Slinger_Up_5_Piercing_Pod_sortIndex)]
        [DisplayName(Slinger_Up_5_Piercing_Pod_displayName)]
        public virtual byte Slinger_Up_5_Piercing_Pod {
            get => GetData<byte>(1123);
            set {
                if (GetData<byte>(1123) == value) return;
                SetData(1123, value, nameof(Slinger_Up_5_Piercing_Pod));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_5_Piercing_Pod));
            }
        }

        public const string __25200_displayName = "-------------------------------------------------------------------------------------------";
        public const int __25200_sortIndex = 25200;
        [SortOrder(__25200_sortIndex)]
        [DisplayName(__25200_displayName)]
        [IsReadOnly]
        public virtual byte __25200 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__25200));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__25200));
            }
        }

        public const string Slinger_Up_1_Slinger_Thorn_displayName = "Slinger Up 1: Slinger Thorn";
        public const int Slinger_Up_1_Slinger_Thorn_sortIndex = 25250;
        [SortOrder(Slinger_Up_1_Slinger_Thorn_sortIndex)]
        [DisplayName(Slinger_Up_1_Slinger_Thorn_displayName)]
        public virtual byte Slinger_Up_1_Slinger_Thorn {
            get => GetData<byte>(1124);
            set {
                if (GetData<byte>(1124) == value) return;
                SetData(1124, value, nameof(Slinger_Up_1_Slinger_Thorn));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_1_Slinger_Thorn));
            }
        }

        public const string Slinger_Up_2_Slinger_Thorn_displayName = "Slinger Up 2: Slinger Thorn";
        public const int Slinger_Up_2_Slinger_Thorn_sortIndex = 25300;
        [SortOrder(Slinger_Up_2_Slinger_Thorn_sortIndex)]
        [DisplayName(Slinger_Up_2_Slinger_Thorn_displayName)]
        public virtual byte Slinger_Up_2_Slinger_Thorn {
            get => GetData<byte>(1125);
            set {
                if (GetData<byte>(1125) == value) return;
                SetData(1125, value, nameof(Slinger_Up_2_Slinger_Thorn));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_2_Slinger_Thorn));
            }
        }

        public const string Slinger_Up_3_Slinger_Thorn_displayName = "Slinger Up 3: Slinger Thorn";
        public const int Slinger_Up_3_Slinger_Thorn_sortIndex = 25350;
        [SortOrder(Slinger_Up_3_Slinger_Thorn_sortIndex)]
        [DisplayName(Slinger_Up_3_Slinger_Thorn_displayName)]
        public virtual byte Slinger_Up_3_Slinger_Thorn {
            get => GetData<byte>(1126);
            set {
                if (GetData<byte>(1126) == value) return;
                SetData(1126, value, nameof(Slinger_Up_3_Slinger_Thorn));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_3_Slinger_Thorn));
            }
        }

        public const string Slinger_Up_4_Slinger_Thorn_displayName = "Slinger Up 4: Slinger Thorn";
        public const int Slinger_Up_4_Slinger_Thorn_sortIndex = 25400;
        [SortOrder(Slinger_Up_4_Slinger_Thorn_sortIndex)]
        [DisplayName(Slinger_Up_4_Slinger_Thorn_displayName)]
        public virtual byte Slinger_Up_4_Slinger_Thorn {
            get => GetData<byte>(1127);
            set {
                if (GetData<byte>(1127) == value) return;
                SetData(1127, value, nameof(Slinger_Up_4_Slinger_Thorn));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_4_Slinger_Thorn));
            }
        }

        public const string Slinger_Up_5_Slinger_Thorn_displayName = "Slinger Up 5: Slinger Thorn";
        public const int Slinger_Up_5_Slinger_Thorn_sortIndex = 25450;
        [SortOrder(Slinger_Up_5_Slinger_Thorn_sortIndex)]
        [DisplayName(Slinger_Up_5_Slinger_Thorn_displayName)]
        public virtual byte Slinger_Up_5_Slinger_Thorn {
            get => GetData<byte>(1128);
            set {
                if (GetData<byte>(1128) == value) return;
                SetData(1128, value, nameof(Slinger_Up_5_Slinger_Thorn));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_5_Slinger_Thorn));
            }
        }

        public const string __25500_displayName = "-------------------------------------------------------------------------------------------";
        public const int __25500_sortIndex = 25500;
        [SortOrder(__25500_sortIndex)]
        [DisplayName(__25500_displayName)]
        [IsReadOnly]
        public virtual byte __25500 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__25500));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__25500));
            }
        }

        public const string Slinger_Up_1_Dragon_Pod_displayName = "Slinger Up 1: Dragon Pod";
        public const int Slinger_Up_1_Dragon_Pod_sortIndex = 25550;
        [SortOrder(Slinger_Up_1_Dragon_Pod_sortIndex)]
        [DisplayName(Slinger_Up_1_Dragon_Pod_displayName)]
        public virtual byte Slinger_Up_1_Dragon_Pod {
            get => GetData<byte>(1129);
            set {
                if (GetData<byte>(1129) == value) return;
                SetData(1129, value, nameof(Slinger_Up_1_Dragon_Pod));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_1_Dragon_Pod));
            }
        }

        public const string Slinger_Up_2_Dragon_Pod_displayName = "Slinger Up 2: Dragon Pod";
        public const int Slinger_Up_2_Dragon_Pod_sortIndex = 25600;
        [SortOrder(Slinger_Up_2_Dragon_Pod_sortIndex)]
        [DisplayName(Slinger_Up_2_Dragon_Pod_displayName)]
        public virtual byte Slinger_Up_2_Dragon_Pod {
            get => GetData<byte>(1130);
            set {
                if (GetData<byte>(1130) == value) return;
                SetData(1130, value, nameof(Slinger_Up_2_Dragon_Pod));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_2_Dragon_Pod));
            }
        }

        public const string Slinger_Up_3_Dragon_Pod_displayName = "Slinger Up 3: Dragon Pod";
        public const int Slinger_Up_3_Dragon_Pod_sortIndex = 25650;
        [SortOrder(Slinger_Up_3_Dragon_Pod_sortIndex)]
        [DisplayName(Slinger_Up_3_Dragon_Pod_displayName)]
        public virtual byte Slinger_Up_3_Dragon_Pod {
            get => GetData<byte>(1131);
            set {
                if (GetData<byte>(1131) == value) return;
                SetData(1131, value, nameof(Slinger_Up_3_Dragon_Pod));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_3_Dragon_Pod));
            }
        }

        public const string Slinger_Up_4_Dragon_Pod_displayName = "Slinger Up 4: Dragon Pod";
        public const int Slinger_Up_4_Dragon_Pod_sortIndex = 25700;
        [SortOrder(Slinger_Up_4_Dragon_Pod_sortIndex)]
        [DisplayName(Slinger_Up_4_Dragon_Pod_displayName)]
        public virtual byte Slinger_Up_4_Dragon_Pod {
            get => GetData<byte>(1132);
            set {
                if (GetData<byte>(1132) == value) return;
                SetData(1132, value, nameof(Slinger_Up_4_Dragon_Pod));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_4_Dragon_Pod));
            }
        }

        public const string Slinger_Up_5_Dragon_Pod_displayName = "Slinger Up 5: Dragon Pod";
        public const int Slinger_Up_5_Dragon_Pod_sortIndex = 25750;
        [SortOrder(Slinger_Up_5_Dragon_Pod_sortIndex)]
        [DisplayName(Slinger_Up_5_Dragon_Pod_displayName)]
        public virtual byte Slinger_Up_5_Dragon_Pod {
            get => GetData<byte>(1133);
            set {
                if (GetData<byte>(1133) == value) return;
                SetData(1133, value, nameof(Slinger_Up_5_Dragon_Pod));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_5_Dragon_Pod));
            }
        }

        public const string __25800_displayName = "-------------------------------------------------------------------------------------------";
        public const int __25800_sortIndex = 25800;
        [SortOrder(__25800_sortIndex)]
        [DisplayName(__25800_displayName)]
        [IsReadOnly]
        public virtual byte __25800 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__25800));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__25800));
            }
        }

        public const string Slinger_Up_1_Unk_10_displayName = "Slinger Up 1: Unk 10";
        public const int Slinger_Up_1_Unk_10_sortIndex = 25850;
        [SortOrder(Slinger_Up_1_Unk_10_sortIndex)]
        [DisplayName(Slinger_Up_1_Unk_10_displayName)]
        public virtual byte Slinger_Up_1_Unk_10 {
            get => GetData<byte>(1134);
            set {
                if (GetData<byte>(1134) == value) return;
                SetData(1134, value, nameof(Slinger_Up_1_Unk_10));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_1_Unk_10));
            }
        }

        public const string Slinger_Up_2_Unk_10_displayName = "Slinger Up 2: Unk 10";
        public const int Slinger_Up_2_Unk_10_sortIndex = 25900;
        [SortOrder(Slinger_Up_2_Unk_10_sortIndex)]
        [DisplayName(Slinger_Up_2_Unk_10_displayName)]
        public virtual byte Slinger_Up_2_Unk_10 {
            get => GetData<byte>(1135);
            set {
                if (GetData<byte>(1135) == value) return;
                SetData(1135, value, nameof(Slinger_Up_2_Unk_10));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_2_Unk_10));
            }
        }

        public const string Slinger_Up_3_Unk_10_displayName = "Slinger Up 3: Unk 10";
        public const int Slinger_Up_3_Unk_10_sortIndex = 25950;
        [SortOrder(Slinger_Up_3_Unk_10_sortIndex)]
        [DisplayName(Slinger_Up_3_Unk_10_displayName)]
        public virtual byte Slinger_Up_3_Unk_10 {
            get => GetData<byte>(1136);
            set {
                if (GetData<byte>(1136) == value) return;
                SetData(1136, value, nameof(Slinger_Up_3_Unk_10));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_3_Unk_10));
            }
        }

        public const string Slinger_Up_4_Unk_10_displayName = "Slinger Up 4: Unk 10";
        public const int Slinger_Up_4_Unk_10_sortIndex = 26000;
        [SortOrder(Slinger_Up_4_Unk_10_sortIndex)]
        [DisplayName(Slinger_Up_4_Unk_10_displayName)]
        public virtual byte Slinger_Up_4_Unk_10 {
            get => GetData<byte>(1137);
            set {
                if (GetData<byte>(1137) == value) return;
                SetData(1137, value, nameof(Slinger_Up_4_Unk_10));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_4_Unk_10));
            }
        }

        public const string Slinger_Up_5_Unk_10_displayName = "Slinger Up 5: Unk 10";
        public const int Slinger_Up_5_Unk_10_sortIndex = 26050;
        [SortOrder(Slinger_Up_5_Unk_10_sortIndex)]
        [DisplayName(Slinger_Up_5_Unk_10_displayName)]
        public virtual byte Slinger_Up_5_Unk_10 {
            get => GetData<byte>(1138);
            set {
                if (GetData<byte>(1138) == value) return;
                SetData(1138, value, nameof(Slinger_Up_5_Unk_10));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_5_Unk_10));
            }
        }

        public const string __26100_displayName = "-------------------------------------------------------------------------------------------";
        public const int __26100_sortIndex = 26100;
        [SortOrder(__26100_sortIndex)]
        [DisplayName(__26100_displayName)]
        [IsReadOnly]
        public virtual byte __26100 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__26100));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__26100));
            }
        }

        public const string Slinger_Up_1_Unk_11_displayName = "Slinger Up 1: Unk 11";
        public const int Slinger_Up_1_Unk_11_sortIndex = 26150;
        [SortOrder(Slinger_Up_1_Unk_11_sortIndex)]
        [DisplayName(Slinger_Up_1_Unk_11_displayName)]
        public virtual byte Slinger_Up_1_Unk_11 {
            get => GetData<byte>(1139);
            set {
                if (GetData<byte>(1139) == value) return;
                SetData(1139, value, nameof(Slinger_Up_1_Unk_11));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_1_Unk_11));
            }
        }

        public const string Slinger_Up_2_Unk_11_displayName = "Slinger Up 2: Unk 11";
        public const int Slinger_Up_2_Unk_11_sortIndex = 26200;
        [SortOrder(Slinger_Up_2_Unk_11_sortIndex)]
        [DisplayName(Slinger_Up_2_Unk_11_displayName)]
        public virtual byte Slinger_Up_2_Unk_11 {
            get => GetData<byte>(1140);
            set {
                if (GetData<byte>(1140) == value) return;
                SetData(1140, value, nameof(Slinger_Up_2_Unk_11));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_2_Unk_11));
            }
        }

        public const string Slinger_Up_3_Unk_11_displayName = "Slinger Up 3: Unk 11";
        public const int Slinger_Up_3_Unk_11_sortIndex = 26250;
        [SortOrder(Slinger_Up_3_Unk_11_sortIndex)]
        [DisplayName(Slinger_Up_3_Unk_11_displayName)]
        public virtual byte Slinger_Up_3_Unk_11 {
            get => GetData<byte>(1141);
            set {
                if (GetData<byte>(1141) == value) return;
                SetData(1141, value, nameof(Slinger_Up_3_Unk_11));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_3_Unk_11));
            }
        }

        public const string Slinger_Up_4_Unk_11_displayName = "Slinger Up 4: Unk 11";
        public const int Slinger_Up_4_Unk_11_sortIndex = 26300;
        [SortOrder(Slinger_Up_4_Unk_11_sortIndex)]
        [DisplayName(Slinger_Up_4_Unk_11_displayName)]
        public virtual byte Slinger_Up_4_Unk_11 {
            get => GetData<byte>(1142);
            set {
                if (GetData<byte>(1142) == value) return;
                SetData(1142, value, nameof(Slinger_Up_4_Unk_11));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_4_Unk_11));
            }
        }

        public const string Slinger_Up_5_Unk_11_displayName = "Slinger Up 5: Unk 11";
        public const int Slinger_Up_5_Unk_11_sortIndex = 26350;
        [SortOrder(Slinger_Up_5_Unk_11_sortIndex)]
        [DisplayName(Slinger_Up_5_Unk_11_displayName)]
        public virtual byte Slinger_Up_5_Unk_11 {
            get => GetData<byte>(1143);
            set {
                if (GetData<byte>(1143) == value) return;
                SetData(1143, value, nameof(Slinger_Up_5_Unk_11));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_5_Unk_11));
            }
        }

        public const string __26400_displayName = "-------------------------------------------------------------------------------------------";
        public const int __26400_sortIndex = 26400;
        [SortOrder(__26400_sortIndex)]
        [DisplayName(__26400_displayName)]
        [IsReadOnly]
        public virtual byte __26400 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__26400));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__26400));
            }
        }

        public const string Slinger_Up_1_Unk_12_displayName = "Slinger Up 1: Unk 12";
        public const int Slinger_Up_1_Unk_12_sortIndex = 26450;
        [SortOrder(Slinger_Up_1_Unk_12_sortIndex)]
        [DisplayName(Slinger_Up_1_Unk_12_displayName)]
        public virtual byte Slinger_Up_1_Unk_12 {
            get => GetData<byte>(1144);
            set {
                if (GetData<byte>(1144) == value) return;
                SetData(1144, value, nameof(Slinger_Up_1_Unk_12));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_1_Unk_12));
            }
        }

        public const string Slinger_Up_2_Unk_12_displayName = "Slinger Up 2: Unk 12";
        public const int Slinger_Up_2_Unk_12_sortIndex = 26500;
        [SortOrder(Slinger_Up_2_Unk_12_sortIndex)]
        [DisplayName(Slinger_Up_2_Unk_12_displayName)]
        public virtual byte Slinger_Up_2_Unk_12 {
            get => GetData<byte>(1145);
            set {
                if (GetData<byte>(1145) == value) return;
                SetData(1145, value, nameof(Slinger_Up_2_Unk_12));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_2_Unk_12));
            }
        }

        public const string Slinger_Up_3_Unk_12_displayName = "Slinger Up 3: Unk 12";
        public const int Slinger_Up_3_Unk_12_sortIndex = 26550;
        [SortOrder(Slinger_Up_3_Unk_12_sortIndex)]
        [DisplayName(Slinger_Up_3_Unk_12_displayName)]
        public virtual byte Slinger_Up_3_Unk_12 {
            get => GetData<byte>(1146);
            set {
                if (GetData<byte>(1146) == value) return;
                SetData(1146, value, nameof(Slinger_Up_3_Unk_12));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_3_Unk_12));
            }
        }

        public const string Slinger_Up_4_Unk_12_displayName = "Slinger Up 4: Unk 12";
        public const int Slinger_Up_4_Unk_12_sortIndex = 26600;
        [SortOrder(Slinger_Up_4_Unk_12_sortIndex)]
        [DisplayName(Slinger_Up_4_Unk_12_displayName)]
        public virtual byte Slinger_Up_4_Unk_12 {
            get => GetData<byte>(1147);
            set {
                if (GetData<byte>(1147) == value) return;
                SetData(1147, value, nameof(Slinger_Up_4_Unk_12));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_4_Unk_12));
            }
        }

        public const string Slinger_Up_5_Unk_12_displayName = "Slinger Up 5: Unk 12";
        public const int Slinger_Up_5_Unk_12_sortIndex = 26650;
        [SortOrder(Slinger_Up_5_Unk_12_sortIndex)]
        [DisplayName(Slinger_Up_5_Unk_12_displayName)]
        public virtual byte Slinger_Up_5_Unk_12 {
            get => GetData<byte>(1148);
            set {
                if (GetData<byte>(1148) == value) return;
                SetData(1148, value, nameof(Slinger_Up_5_Unk_12));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_5_Unk_12));
            }
        }

        public const string __26700_displayName = "-------------------------------------------------------------------------------------------";
        public const int __26700_sortIndex = 26700;
        [SortOrder(__26700_sortIndex)]
        [DisplayName(__26700_displayName)]
        [IsReadOnly]
        public virtual byte __26700 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__26700));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__26700));
            }
        }

        public const string Slinger_Up_1_Unk_13_displayName = "Slinger Up 1: Unk 13";
        public const int Slinger_Up_1_Unk_13_sortIndex = 26750;
        [SortOrder(Slinger_Up_1_Unk_13_sortIndex)]
        [DisplayName(Slinger_Up_1_Unk_13_displayName)]
        public virtual byte Slinger_Up_1_Unk_13 {
            get => GetData<byte>(1149);
            set {
                if (GetData<byte>(1149) == value) return;
                SetData(1149, value, nameof(Slinger_Up_1_Unk_13));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_1_Unk_13));
            }
        }

        public const string Slinger_Up_2_Unk_13_displayName = "Slinger Up 2: Unk 13";
        public const int Slinger_Up_2_Unk_13_sortIndex = 26800;
        [SortOrder(Slinger_Up_2_Unk_13_sortIndex)]
        [DisplayName(Slinger_Up_2_Unk_13_displayName)]
        public virtual byte Slinger_Up_2_Unk_13 {
            get => GetData<byte>(1150);
            set {
                if (GetData<byte>(1150) == value) return;
                SetData(1150, value, nameof(Slinger_Up_2_Unk_13));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_2_Unk_13));
            }
        }

        public const string Slinger_Up_3_Unk_13_displayName = "Slinger Up 3: Unk 13";
        public const int Slinger_Up_3_Unk_13_sortIndex = 26850;
        [SortOrder(Slinger_Up_3_Unk_13_sortIndex)]
        [DisplayName(Slinger_Up_3_Unk_13_displayName)]
        public virtual byte Slinger_Up_3_Unk_13 {
            get => GetData<byte>(1151);
            set {
                if (GetData<byte>(1151) == value) return;
                SetData(1151, value, nameof(Slinger_Up_3_Unk_13));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_3_Unk_13));
            }
        }

        public const string Slinger_Up_4_Unk_13_displayName = "Slinger Up 4: Unk 13";
        public const int Slinger_Up_4_Unk_13_sortIndex = 26900;
        [SortOrder(Slinger_Up_4_Unk_13_sortIndex)]
        [DisplayName(Slinger_Up_4_Unk_13_displayName)]
        public virtual byte Slinger_Up_4_Unk_13 {
            get => GetData<byte>(1152);
            set {
                if (GetData<byte>(1152) == value) return;
                SetData(1152, value, nameof(Slinger_Up_4_Unk_13));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_4_Unk_13));
            }
        }

        public const string Slinger_Up_5_Unk_13_displayName = "Slinger Up 5: Unk 13";
        public const int Slinger_Up_5_Unk_13_sortIndex = 26950;
        [SortOrder(Slinger_Up_5_Unk_13_sortIndex)]
        [DisplayName(Slinger_Up_5_Unk_13_displayName)]
        public virtual byte Slinger_Up_5_Unk_13 {
            get => GetData<byte>(1153);
            set {
                if (GetData<byte>(1153) == value) return;
                SetData(1153, value, nameof(Slinger_Up_5_Unk_13));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_5_Unk_13));
            }
        }

        public const string __27000_displayName = "-------------------------------------------------------------------------------------------";
        public const int __27000_sortIndex = 27000;
        [SortOrder(__27000_sortIndex)]
        [DisplayName(__27000_displayName)]
        [IsReadOnly]
        public virtual byte __27000 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__27000));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__27000));
            }
        }

        public const string Slinger_Up_1_Unk_14_displayName = "Slinger Up 1: Unk 14";
        public const int Slinger_Up_1_Unk_14_sortIndex = 27050;
        [SortOrder(Slinger_Up_1_Unk_14_sortIndex)]
        [DisplayName(Slinger_Up_1_Unk_14_displayName)]
        public virtual byte Slinger_Up_1_Unk_14 {
            get => GetData<byte>(1154);
            set {
                if (GetData<byte>(1154) == value) return;
                SetData(1154, value, nameof(Slinger_Up_1_Unk_14));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_1_Unk_14));
            }
        }

        public const string Slinger_Up_2_Unk_14_displayName = "Slinger Up 2: Unk 14";
        public const int Slinger_Up_2_Unk_14_sortIndex = 27100;
        [SortOrder(Slinger_Up_2_Unk_14_sortIndex)]
        [DisplayName(Slinger_Up_2_Unk_14_displayName)]
        public virtual byte Slinger_Up_2_Unk_14 {
            get => GetData<byte>(1155);
            set {
                if (GetData<byte>(1155) == value) return;
                SetData(1155, value, nameof(Slinger_Up_2_Unk_14));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_2_Unk_14));
            }
        }

        public const string Slinger_Up_3_Unk_14_displayName = "Slinger Up 3: Unk 14";
        public const int Slinger_Up_3_Unk_14_sortIndex = 27150;
        [SortOrder(Slinger_Up_3_Unk_14_sortIndex)]
        [DisplayName(Slinger_Up_3_Unk_14_displayName)]
        public virtual byte Slinger_Up_3_Unk_14 {
            get => GetData<byte>(1156);
            set {
                if (GetData<byte>(1156) == value) return;
                SetData(1156, value, nameof(Slinger_Up_3_Unk_14));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_3_Unk_14));
            }
        }

        public const string Slinger_Up_4_Unk_14_displayName = "Slinger Up 4: Unk 14";
        public const int Slinger_Up_4_Unk_14_sortIndex = 27200;
        [SortOrder(Slinger_Up_4_Unk_14_sortIndex)]
        [DisplayName(Slinger_Up_4_Unk_14_displayName)]
        public virtual byte Slinger_Up_4_Unk_14 {
            get => GetData<byte>(1157);
            set {
                if (GetData<byte>(1157) == value) return;
                SetData(1157, value, nameof(Slinger_Up_4_Unk_14));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_4_Unk_14));
            }
        }

        public const string Slinger_Up_5_Unk_14_displayName = "Slinger Up 5: Unk 14";
        public const int Slinger_Up_5_Unk_14_sortIndex = 27250;
        [SortOrder(Slinger_Up_5_Unk_14_sortIndex)]
        [DisplayName(Slinger_Up_5_Unk_14_displayName)]
        public virtual byte Slinger_Up_5_Unk_14 {
            get => GetData<byte>(1158);
            set {
                if (GetData<byte>(1158) == value) return;
                SetData(1158, value, nameof(Slinger_Up_5_Unk_14));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_5_Unk_14));
            }
        }

        public const string __27300_displayName = "-------------------------------------------------------------------------------------------";
        public const int __27300_sortIndex = 27300;
        [SortOrder(__27300_sortIndex)]
        [DisplayName(__27300_displayName)]
        [IsReadOnly]
        public virtual byte __27300 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__27300));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__27300));
            }
        }

        public const string Slinger_Up_1_Unk_15_displayName = "Slinger Up 1: Unk 15";
        public const int Slinger_Up_1_Unk_15_sortIndex = 27350;
        [SortOrder(Slinger_Up_1_Unk_15_sortIndex)]
        [DisplayName(Slinger_Up_1_Unk_15_displayName)]
        public virtual byte Slinger_Up_1_Unk_15 {
            get => GetData<byte>(1159);
            set {
                if (GetData<byte>(1159) == value) return;
                SetData(1159, value, nameof(Slinger_Up_1_Unk_15));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_1_Unk_15));
            }
        }

        public const string Slinger_Up_2_Unk_15_displayName = "Slinger Up 2: Unk 15";
        public const int Slinger_Up_2_Unk_15_sortIndex = 27400;
        [SortOrder(Slinger_Up_2_Unk_15_sortIndex)]
        [DisplayName(Slinger_Up_2_Unk_15_displayName)]
        public virtual byte Slinger_Up_2_Unk_15 {
            get => GetData<byte>(1160);
            set {
                if (GetData<byte>(1160) == value) return;
                SetData(1160, value, nameof(Slinger_Up_2_Unk_15));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_2_Unk_15));
            }
        }

        public const string Slinger_Up_3_Unk_15_displayName = "Slinger Up 3: Unk 15";
        public const int Slinger_Up_3_Unk_15_sortIndex = 27450;
        [SortOrder(Slinger_Up_3_Unk_15_sortIndex)]
        [DisplayName(Slinger_Up_3_Unk_15_displayName)]
        public virtual byte Slinger_Up_3_Unk_15 {
            get => GetData<byte>(1161);
            set {
                if (GetData<byte>(1161) == value) return;
                SetData(1161, value, nameof(Slinger_Up_3_Unk_15));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_3_Unk_15));
            }
        }

        public const string Slinger_Up_4_Unk_15_displayName = "Slinger Up 4: Unk 15";
        public const int Slinger_Up_4_Unk_15_sortIndex = 27500;
        [SortOrder(Slinger_Up_4_Unk_15_sortIndex)]
        [DisplayName(Slinger_Up_4_Unk_15_displayName)]
        public virtual byte Slinger_Up_4_Unk_15 {
            get => GetData<byte>(1162);
            set {
                if (GetData<byte>(1162) == value) return;
                SetData(1162, value, nameof(Slinger_Up_4_Unk_15));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_4_Unk_15));
            }
        }

        public const string Slinger_Up_5_Unk_15_displayName = "Slinger Up 5: Unk 15";
        public const int Slinger_Up_5_Unk_15_sortIndex = 27550;
        [SortOrder(Slinger_Up_5_Unk_15_sortIndex)]
        [DisplayName(Slinger_Up_5_Unk_15_displayName)]
        public virtual byte Slinger_Up_5_Unk_15 {
            get => GetData<byte>(1163);
            set {
                if (GetData<byte>(1163) == value) return;
                SetData(1163, value, nameof(Slinger_Up_5_Unk_15));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_5_Unk_15));
            }
        }

        public const string __27600_displayName = "-------------------------------------------------------------------------------------------";
        public const int __27600_sortIndex = 27600;
        [SortOrder(__27600_sortIndex)]
        [DisplayName(__27600_displayName)]
        [IsReadOnly]
        public virtual byte __27600 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__27600));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__27600));
            }
        }

        public const string Slinger_Up_1_Unk_16_displayName = "Slinger Up 1: Unk 16";
        public const int Slinger_Up_1_Unk_16_sortIndex = 27650;
        [SortOrder(Slinger_Up_1_Unk_16_sortIndex)]
        [DisplayName(Slinger_Up_1_Unk_16_displayName)]
        public virtual byte Slinger_Up_1_Unk_16 {
            get => GetData<byte>(1164);
            set {
                if (GetData<byte>(1164) == value) return;
                SetData(1164, value, nameof(Slinger_Up_1_Unk_16));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_1_Unk_16));
            }
        }

        public const string Slinger_Up_2_Unk_16_displayName = "Slinger Up 2: Unk 16";
        public const int Slinger_Up_2_Unk_16_sortIndex = 27700;
        [SortOrder(Slinger_Up_2_Unk_16_sortIndex)]
        [DisplayName(Slinger_Up_2_Unk_16_displayName)]
        public virtual byte Slinger_Up_2_Unk_16 {
            get => GetData<byte>(1165);
            set {
                if (GetData<byte>(1165) == value) return;
                SetData(1165, value, nameof(Slinger_Up_2_Unk_16));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_2_Unk_16));
            }
        }

        public const string Slinger_Up_3_Unk_16_displayName = "Slinger Up 3: Unk 16";
        public const int Slinger_Up_3_Unk_16_sortIndex = 27750;
        [SortOrder(Slinger_Up_3_Unk_16_sortIndex)]
        [DisplayName(Slinger_Up_3_Unk_16_displayName)]
        public virtual byte Slinger_Up_3_Unk_16 {
            get => GetData<byte>(1166);
            set {
                if (GetData<byte>(1166) == value) return;
                SetData(1166, value, nameof(Slinger_Up_3_Unk_16));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_3_Unk_16));
            }
        }

        public const string Slinger_Up_4_Unk_16_displayName = "Slinger Up 4: Unk 16";
        public const int Slinger_Up_4_Unk_16_sortIndex = 27800;
        [SortOrder(Slinger_Up_4_Unk_16_sortIndex)]
        [DisplayName(Slinger_Up_4_Unk_16_displayName)]
        public virtual byte Slinger_Up_4_Unk_16 {
            get => GetData<byte>(1167);
            set {
                if (GetData<byte>(1167) == value) return;
                SetData(1167, value, nameof(Slinger_Up_4_Unk_16));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_4_Unk_16));
            }
        }

        public const string Slinger_Up_5_Unk_16_displayName = "Slinger Up 5: Unk 16";
        public const int Slinger_Up_5_Unk_16_sortIndex = 27850;
        [SortOrder(Slinger_Up_5_Unk_16_sortIndex)]
        [DisplayName(Slinger_Up_5_Unk_16_displayName)]
        public virtual byte Slinger_Up_5_Unk_16 {
            get => GetData<byte>(1168);
            set {
                if (GetData<byte>(1168) == value) return;
                SetData(1168, value, nameof(Slinger_Up_5_Unk_16));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_5_Unk_16));
            }
        }

        public const string __27900_displayName = "-------------------------------------------------------------------------------------------";
        public const int __27900_sortIndex = 27900;
        [SortOrder(__27900_sortIndex)]
        [DisplayName(__27900_displayName)]
        [IsReadOnly]
        public virtual byte __27900 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__27900));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__27900));
            }
        }

        public const string Slinger_Up_1_Unk_17_displayName = "Slinger Up 1: Unk 17";
        public const int Slinger_Up_1_Unk_17_sortIndex = 27950;
        [SortOrder(Slinger_Up_1_Unk_17_sortIndex)]
        [DisplayName(Slinger_Up_1_Unk_17_displayName)]
        public virtual byte Slinger_Up_1_Unk_17 {
            get => GetData<byte>(1169);
            set {
                if (GetData<byte>(1169) == value) return;
                SetData(1169, value, nameof(Slinger_Up_1_Unk_17));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_1_Unk_17));
            }
        }

        public const string Slinger_Up_2_Unk_17_displayName = "Slinger Up 2: Unk 17";
        public const int Slinger_Up_2_Unk_17_sortIndex = 28000;
        [SortOrder(Slinger_Up_2_Unk_17_sortIndex)]
        [DisplayName(Slinger_Up_2_Unk_17_displayName)]
        public virtual byte Slinger_Up_2_Unk_17 {
            get => GetData<byte>(1170);
            set {
                if (GetData<byte>(1170) == value) return;
                SetData(1170, value, nameof(Slinger_Up_2_Unk_17));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_2_Unk_17));
            }
        }

        public const string Slinger_Up_3_Unk_17_displayName = "Slinger Up 3: Unk 17";
        public const int Slinger_Up_3_Unk_17_sortIndex = 28050;
        [SortOrder(Slinger_Up_3_Unk_17_sortIndex)]
        [DisplayName(Slinger_Up_3_Unk_17_displayName)]
        public virtual byte Slinger_Up_3_Unk_17 {
            get => GetData<byte>(1171);
            set {
                if (GetData<byte>(1171) == value) return;
                SetData(1171, value, nameof(Slinger_Up_3_Unk_17));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_3_Unk_17));
            }
        }

        public const string Slinger_Up_4_Unk_17_displayName = "Slinger Up 4: Unk 17";
        public const int Slinger_Up_4_Unk_17_sortIndex = 28100;
        [SortOrder(Slinger_Up_4_Unk_17_sortIndex)]
        [DisplayName(Slinger_Up_4_Unk_17_displayName)]
        public virtual byte Slinger_Up_4_Unk_17 {
            get => GetData<byte>(1172);
            set {
                if (GetData<byte>(1172) == value) return;
                SetData(1172, value, nameof(Slinger_Up_4_Unk_17));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_4_Unk_17));
            }
        }

        public const string Slinger_Up_5_Unk_17_displayName = "Slinger Up 5: Unk 17";
        public const int Slinger_Up_5_Unk_17_sortIndex = 28150;
        [SortOrder(Slinger_Up_5_Unk_17_sortIndex)]
        [DisplayName(Slinger_Up_5_Unk_17_displayName)]
        public virtual byte Slinger_Up_5_Unk_17 {
            get => GetData<byte>(1173);
            set {
                if (GetData<byte>(1173) == value) return;
                SetData(1173, value, nameof(Slinger_Up_5_Unk_17));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_5_Unk_17));
            }
        }

        public const string __28200_displayName = "-------------------------------------------------------------------------------------------";
        public const int __28200_sortIndex = 28200;
        [SortOrder(__28200_sortIndex)]
        [DisplayName(__28200_displayName)]
        [IsReadOnly]
        public virtual byte __28200 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__28200));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__28200));
            }
        }

        public const string Slinger_Up_1_Crystalburst_displayName = "Slinger Up 1: Crystalburst";
        public const int Slinger_Up_1_Crystalburst_sortIndex = 28250;
        [SortOrder(Slinger_Up_1_Crystalburst_sortIndex)]
        [DisplayName(Slinger_Up_1_Crystalburst_displayName)]
        public virtual byte Slinger_Up_1_Crystalburst {
            get => GetData<byte>(1174);
            set {
                if (GetData<byte>(1174) == value) return;
                SetData(1174, value, nameof(Slinger_Up_1_Crystalburst));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_1_Crystalburst));
            }
        }

        public const string Slinger_Up_2_Crystalburst_displayName = "Slinger Up 2: Crystalburst";
        public const int Slinger_Up_2_Crystalburst_sortIndex = 28300;
        [SortOrder(Slinger_Up_2_Crystalburst_sortIndex)]
        [DisplayName(Slinger_Up_2_Crystalburst_displayName)]
        public virtual byte Slinger_Up_2_Crystalburst {
            get => GetData<byte>(1175);
            set {
                if (GetData<byte>(1175) == value) return;
                SetData(1175, value, nameof(Slinger_Up_2_Crystalburst));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_2_Crystalburst));
            }
        }

        public const string Slinger_Up_3_Crystalburst_displayName = "Slinger Up 3: Crystalburst";
        public const int Slinger_Up_3_Crystalburst_sortIndex = 28350;
        [SortOrder(Slinger_Up_3_Crystalburst_sortIndex)]
        [DisplayName(Slinger_Up_3_Crystalburst_displayName)]
        public virtual byte Slinger_Up_3_Crystalburst {
            get => GetData<byte>(1176);
            set {
                if (GetData<byte>(1176) == value) return;
                SetData(1176, value, nameof(Slinger_Up_3_Crystalburst));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_3_Crystalburst));
            }
        }

        public const string Slinger_Up_4_Crystalburst_displayName = "Slinger Up 4: Crystalburst";
        public const int Slinger_Up_4_Crystalburst_sortIndex = 28400;
        [SortOrder(Slinger_Up_4_Crystalburst_sortIndex)]
        [DisplayName(Slinger_Up_4_Crystalburst_displayName)]
        public virtual byte Slinger_Up_4_Crystalburst {
            get => GetData<byte>(1177);
            set {
                if (GetData<byte>(1177) == value) return;
                SetData(1177, value, nameof(Slinger_Up_4_Crystalburst));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_4_Crystalburst));
            }
        }

        public const string Slinger_Up_5_Crystalburst_displayName = "Slinger Up 5: Crystalburst";
        public const int Slinger_Up_5_Crystalburst_sortIndex = 28450;
        [SortOrder(Slinger_Up_5_Crystalburst_sortIndex)]
        [DisplayName(Slinger_Up_5_Crystalburst_displayName)]
        public virtual byte Slinger_Up_5_Crystalburst {
            get => GetData<byte>(1178);
            set {
                if (GetData<byte>(1178) == value) return;
                SetData(1178, value, nameof(Slinger_Up_5_Crystalburst));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_5_Crystalburst));
            }
        }

        public const string __28500_displayName = "-------------------------------------------------------------------------------------------";
        public const int __28500_sortIndex = 28500;
        [SortOrder(__28500_sortIndex)]
        [DisplayName(__28500_displayName)]
        [IsReadOnly]
        public virtual byte __28500 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__28500));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__28500));
            }
        }

        public const string Slinger_Up_1_Puddle_Pod_displayName = "Slinger Up 1: Puddle Pod";
        public const int Slinger_Up_1_Puddle_Pod_sortIndex = 28550;
        [SortOrder(Slinger_Up_1_Puddle_Pod_sortIndex)]
        [DisplayName(Slinger_Up_1_Puddle_Pod_displayName)]
        public virtual byte Slinger_Up_1_Puddle_Pod {
            get => GetData<byte>(1179);
            set {
                if (GetData<byte>(1179) == value) return;
                SetData(1179, value, nameof(Slinger_Up_1_Puddle_Pod));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_1_Puddle_Pod));
            }
        }

        public const string Slinger_Up_2_Puddle_Pod_displayName = "Slinger Up 2: Puddle Pod";
        public const int Slinger_Up_2_Puddle_Pod_sortIndex = 28600;
        [SortOrder(Slinger_Up_2_Puddle_Pod_sortIndex)]
        [DisplayName(Slinger_Up_2_Puddle_Pod_displayName)]
        public virtual byte Slinger_Up_2_Puddle_Pod {
            get => GetData<byte>(1180);
            set {
                if (GetData<byte>(1180) == value) return;
                SetData(1180, value, nameof(Slinger_Up_2_Puddle_Pod));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_2_Puddle_Pod));
            }
        }

        public const string Slinger_Up_3_Puddle_Pod_displayName = "Slinger Up 3: Puddle Pod";
        public const int Slinger_Up_3_Puddle_Pod_sortIndex = 28650;
        [SortOrder(Slinger_Up_3_Puddle_Pod_sortIndex)]
        [DisplayName(Slinger_Up_3_Puddle_Pod_displayName)]
        public virtual byte Slinger_Up_3_Puddle_Pod {
            get => GetData<byte>(1181);
            set {
                if (GetData<byte>(1181) == value) return;
                SetData(1181, value, nameof(Slinger_Up_3_Puddle_Pod));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_3_Puddle_Pod));
            }
        }

        public const string Slinger_Up_4_Puddle_Pod_displayName = "Slinger Up 4: Puddle Pod";
        public const int Slinger_Up_4_Puddle_Pod_sortIndex = 28700;
        [SortOrder(Slinger_Up_4_Puddle_Pod_sortIndex)]
        [DisplayName(Slinger_Up_4_Puddle_Pod_displayName)]
        public virtual byte Slinger_Up_4_Puddle_Pod {
            get => GetData<byte>(1182);
            set {
                if (GetData<byte>(1182) == value) return;
                SetData(1182, value, nameof(Slinger_Up_4_Puddle_Pod));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_4_Puddle_Pod));
            }
        }

        public const string Slinger_Up_5_Puddle_Pod_displayName = "Slinger Up 5: Puddle Pod";
        public const int Slinger_Up_5_Puddle_Pod_sortIndex = 28750;
        [SortOrder(Slinger_Up_5_Puddle_Pod_sortIndex)]
        [DisplayName(Slinger_Up_5_Puddle_Pod_displayName)]
        public virtual byte Slinger_Up_5_Puddle_Pod {
            get => GetData<byte>(1183);
            set {
                if (GetData<byte>(1183) == value) return;
                SetData(1183, value, nameof(Slinger_Up_5_Puddle_Pod));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_5_Puddle_Pod));
            }
        }

        public const string __28800_displayName = "-------------------------------------------------------------------------------------------";
        public const int __28800_sortIndex = 28800;
        [SortOrder(__28800_sortIndex)]
        [DisplayName(__28800_displayName)]
        [IsReadOnly]
        public virtual byte __28800 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__28800));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__28800));
            }
        }

        public const string Slinger_Up_1_Unk_18_displayName = "Slinger Up 1: Unk 18";
        public const int Slinger_Up_1_Unk_18_sortIndex = 28850;
        [SortOrder(Slinger_Up_1_Unk_18_sortIndex)]
        [DisplayName(Slinger_Up_1_Unk_18_displayName)]
        public virtual byte Slinger_Up_1_Unk_18 {
            get => GetData<byte>(1184);
            set {
                if (GetData<byte>(1184) == value) return;
                SetData(1184, value, nameof(Slinger_Up_1_Unk_18));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_1_Unk_18));
            }
        }

        public const string Slinger_Up_2_Unk_18_displayName = "Slinger Up 2: Unk 18";
        public const int Slinger_Up_2_Unk_18_sortIndex = 28900;
        [SortOrder(Slinger_Up_2_Unk_18_sortIndex)]
        [DisplayName(Slinger_Up_2_Unk_18_displayName)]
        public virtual byte Slinger_Up_2_Unk_18 {
            get => GetData<byte>(1185);
            set {
                if (GetData<byte>(1185) == value) return;
                SetData(1185, value, nameof(Slinger_Up_2_Unk_18));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_2_Unk_18));
            }
        }

        public const string Slinger_Up_3_Unk_18_displayName = "Slinger Up 3: Unk 18";
        public const int Slinger_Up_3_Unk_18_sortIndex = 28950;
        [SortOrder(Slinger_Up_3_Unk_18_sortIndex)]
        [DisplayName(Slinger_Up_3_Unk_18_displayName)]
        public virtual byte Slinger_Up_3_Unk_18 {
            get => GetData<byte>(1186);
            set {
                if (GetData<byte>(1186) == value) return;
                SetData(1186, value, nameof(Slinger_Up_3_Unk_18));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_3_Unk_18));
            }
        }

        public const string Slinger_Up_4_Unk_18_displayName = "Slinger Up 4: Unk 18";
        public const int Slinger_Up_4_Unk_18_sortIndex = 29000;
        [SortOrder(Slinger_Up_4_Unk_18_sortIndex)]
        [DisplayName(Slinger_Up_4_Unk_18_displayName)]
        public virtual byte Slinger_Up_4_Unk_18 {
            get => GetData<byte>(1187);
            set {
                if (GetData<byte>(1187) == value) return;
                SetData(1187, value, nameof(Slinger_Up_4_Unk_18));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_4_Unk_18));
            }
        }

        public const string Slinger_Up_5_Unk_18_displayName = "Slinger Up 5: Unk 18";
        public const int Slinger_Up_5_Unk_18_sortIndex = 29050;
        [SortOrder(Slinger_Up_5_Unk_18_sortIndex)]
        [DisplayName(Slinger_Up_5_Unk_18_displayName)]
        public virtual byte Slinger_Up_5_Unk_18 {
            get => GetData<byte>(1188);
            set {
                if (GetData<byte>(1188) == value) return;
                SetData(1188, value, nameof(Slinger_Up_5_Unk_18));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_5_Unk_18));
            }
        }

        public const string __29100_displayName = "-------------------------------------------------------------------------------------------";
        public const int __29100_sortIndex = 29100;
        [SortOrder(__29100_sortIndex)]
        [DisplayName(__29100_displayName)]
        [IsReadOnly]
        public virtual byte __29100 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__29100));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__29100));
            }
        }

        public const string Slinger_Up_1_Unk_19_displayName = "Slinger Up 1: Unk 19";
        public const int Slinger_Up_1_Unk_19_sortIndex = 29150;
        [SortOrder(Slinger_Up_1_Unk_19_sortIndex)]
        [DisplayName(Slinger_Up_1_Unk_19_displayName)]
        public virtual byte Slinger_Up_1_Unk_19 {
            get => GetData<byte>(1189);
            set {
                if (GetData<byte>(1189) == value) return;
                SetData(1189, value, nameof(Slinger_Up_1_Unk_19));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_1_Unk_19));
            }
        }

        public const string Slinger_Up_2_Unk_19_displayName = "Slinger Up 2: Unk 19";
        public const int Slinger_Up_2_Unk_19_sortIndex = 29200;
        [SortOrder(Slinger_Up_2_Unk_19_sortIndex)]
        [DisplayName(Slinger_Up_2_Unk_19_displayName)]
        public virtual byte Slinger_Up_2_Unk_19 {
            get => GetData<byte>(1190);
            set {
                if (GetData<byte>(1190) == value) return;
                SetData(1190, value, nameof(Slinger_Up_2_Unk_19));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_2_Unk_19));
            }
        }

        public const string Slinger_Up_3_Unk_19_displayName = "Slinger Up 3: Unk 19";
        public const int Slinger_Up_3_Unk_19_sortIndex = 29250;
        [SortOrder(Slinger_Up_3_Unk_19_sortIndex)]
        [DisplayName(Slinger_Up_3_Unk_19_displayName)]
        public virtual byte Slinger_Up_3_Unk_19 {
            get => GetData<byte>(1191);
            set {
                if (GetData<byte>(1191) == value) return;
                SetData(1191, value, nameof(Slinger_Up_3_Unk_19));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_3_Unk_19));
            }
        }

        public const string Slinger_Up_4_Unk_19_displayName = "Slinger Up 4: Unk 19";
        public const int Slinger_Up_4_Unk_19_sortIndex = 29300;
        [SortOrder(Slinger_Up_4_Unk_19_sortIndex)]
        [DisplayName(Slinger_Up_4_Unk_19_displayName)]
        public virtual byte Slinger_Up_4_Unk_19 {
            get => GetData<byte>(1192);
            set {
                if (GetData<byte>(1192) == value) return;
                SetData(1192, value, nameof(Slinger_Up_4_Unk_19));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_4_Unk_19));
            }
        }

        public const string Slinger_Up_5_Unk_19_displayName = "Slinger Up 5: Unk 19";
        public const int Slinger_Up_5_Unk_19_sortIndex = 29350;
        [SortOrder(Slinger_Up_5_Unk_19_sortIndex)]
        [DisplayName(Slinger_Up_5_Unk_19_displayName)]
        public virtual byte Slinger_Up_5_Unk_19 {
            get => GetData<byte>(1193);
            set {
                if (GetData<byte>(1193) == value) return;
                SetData(1193, value, nameof(Slinger_Up_5_Unk_19));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_5_Unk_19));
            }
        }

        public const string __29400_displayName = "-------------------------------------------------------------------------------------------";
        public const int __29400_sortIndex = 29400;
        [SortOrder(__29400_sortIndex)]
        [DisplayName(__29400_displayName)]
        [IsReadOnly]
        public virtual byte __29400 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__29400));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__29400));
            }
        }

        public const string Slinger_Up_1_Unk_20_displayName = "Slinger Up 1: Unk 20";
        public const int Slinger_Up_1_Unk_20_sortIndex = 29450;
        [SortOrder(Slinger_Up_1_Unk_20_sortIndex)]
        [DisplayName(Slinger_Up_1_Unk_20_displayName)]
        public virtual byte Slinger_Up_1_Unk_20 {
            get => GetData<byte>(1194);
            set {
                if (GetData<byte>(1194) == value) return;
                SetData(1194, value, nameof(Slinger_Up_1_Unk_20));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_1_Unk_20));
            }
        }

        public const string Slinger_Up_2_Unk_20_displayName = "Slinger Up 2: Unk 20";
        public const int Slinger_Up_2_Unk_20_sortIndex = 29500;
        [SortOrder(Slinger_Up_2_Unk_20_sortIndex)]
        [DisplayName(Slinger_Up_2_Unk_20_displayName)]
        public virtual byte Slinger_Up_2_Unk_20 {
            get => GetData<byte>(1195);
            set {
                if (GetData<byte>(1195) == value) return;
                SetData(1195, value, nameof(Slinger_Up_2_Unk_20));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_2_Unk_20));
            }
        }

        public const string Slinger_Up_3_Unk_20_displayName = "Slinger Up 3: Unk 20";
        public const int Slinger_Up_3_Unk_20_sortIndex = 29550;
        [SortOrder(Slinger_Up_3_Unk_20_sortIndex)]
        [DisplayName(Slinger_Up_3_Unk_20_displayName)]
        public virtual byte Slinger_Up_3_Unk_20 {
            get => GetData<byte>(1196);
            set {
                if (GetData<byte>(1196) == value) return;
                SetData(1196, value, nameof(Slinger_Up_3_Unk_20));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_3_Unk_20));
            }
        }

        public const string Slinger_Up_4_Unk_20_displayName = "Slinger Up 4: Unk 20";
        public const int Slinger_Up_4_Unk_20_sortIndex = 29600;
        [SortOrder(Slinger_Up_4_Unk_20_sortIndex)]
        [DisplayName(Slinger_Up_4_Unk_20_displayName)]
        public virtual byte Slinger_Up_4_Unk_20 {
            get => GetData<byte>(1197);
            set {
                if (GetData<byte>(1197) == value) return;
                SetData(1197, value, nameof(Slinger_Up_4_Unk_20));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_4_Unk_20));
            }
        }

        public const string Slinger_Up_5_Unk_20_displayName = "Slinger Up 5: Unk 20";
        public const int Slinger_Up_5_Unk_20_sortIndex = 29650;
        [SortOrder(Slinger_Up_5_Unk_20_sortIndex)]
        [DisplayName(Slinger_Up_5_Unk_20_displayName)]
        public virtual byte Slinger_Up_5_Unk_20 {
            get => GetData<byte>(1198);
            set {
                if (GetData<byte>(1198) == value) return;
                SetData(1198, value, nameof(Slinger_Up_5_Unk_20));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Slinger_Up_5_Unk_20));
            }
        }

        public const string __29700_displayName = "-------------------------------------------------------------------------------------------";
        public const int __29700_sortIndex = 29700;
        [SortOrder(__29700_sortIndex)]
        [DisplayName(__29700_displayName)]
        [IsReadOnly]
        public virtual byte __29700 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__29700));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__29700));
            }
        }

        public const string Master_Fisher_Add_Hook_Time_displayName = "Master Fisher: Add Hook Time";
        public const int Master_Fisher_Add_Hook_Time_sortIndex = 29750;
        [SortOrder(Master_Fisher_Add_Hook_Time_sortIndex)]
        [DisplayName(Master_Fisher_Add_Hook_Time_displayName)]
        public virtual float Master_Fisher_Add_Hook_Time {
            get => GetData<float>(1199);
            set {
                if (GetData<float>(1199) == value) return;
                SetData(1199, value, nameof(Master_Fisher_Add_Hook_Time));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Master_Fisher_Add_Hook_Time));
            }
        }

        public const string Master_Fisher_Big_Fish_Catch_Rate_displayName = "Master Fisher: Big Fish Catch Rate";
        public const int Master_Fisher_Big_Fish_Catch_Rate_sortIndex = 29800;
        [SortOrder(Master_Fisher_Big_Fish_Catch_Rate_sortIndex)]
        [DisplayName(Master_Fisher_Big_Fish_Catch_Rate_displayName)]
        public virtual float Master_Fisher_Big_Fish_Catch_Rate {
            get => GetData<float>(1203);
            set {
                if (GetData<float>(1203) == value) return;
                SetData(1203, value, nameof(Master_Fisher_Big_Fish_Catch_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Master_Fisher_Big_Fish_Catch_Rate));
            }
        }

        public const string __29850_displayName = "-------------------------------------------------------------------------------------------";
        public const int __29850_sortIndex = 29850;
        [SortOrder(__29850_sortIndex)]
        [DisplayName(__29850_displayName)]
        [IsReadOnly]
        public virtual byte __29850 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__29850));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__29850));
            }
        }

        public const string Adrenaline_Stamina_Rate_displayName = "Adrenaline: Stamina Rate";
        public const int Adrenaline_Stamina_Rate_sortIndex = 29900;
        [SortOrder(Adrenaline_Stamina_Rate_sortIndex)]
        [DisplayName(Adrenaline_Stamina_Rate_displayName)]
        public virtual float Adrenaline_Stamina_Rate {
            get => GetData<float>(1207);
            set {
                if (GetData<float>(1207) == value) return;
                SetData(1207, value, nameof(Adrenaline_Stamina_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Adrenaline_Stamina_Rate));
            }
        }

        public const string __29950_displayName = "-------------------------------------------------------------------------------------------";
        public const int __29950_sortIndex = 29950;
        [SortOrder(__29950_sortIndex)]
        [DisplayName(__29950_displayName)]
        [IsReadOnly]
        public virtual byte __29950 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__29950));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__29950));
            }
        }

        public const string Elemental_Airborne_Great_Sword_Rate_displayName = "Elemental Airborne: (Great Sword) Rate";
        public const int Elemental_Airborne_Great_Sword_Rate_sortIndex = 30000;
        [SortOrder(Elemental_Airborne_Great_Sword_Rate_sortIndex)]
        [DisplayName(Elemental_Airborne_Great_Sword_Rate_displayName)]
        public virtual float Elemental_Airborne_Great_Sword_Rate {
            get => GetData<float>(1211);
            set {
                if (GetData<float>(1211) == value) return;
                SetData(1211, value, nameof(Elemental_Airborne_Great_Sword_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Elemental_Airborne_Great_Sword_Rate));
            }
        }

        public const string Elemental_Airborne_Sword_Shield_Rate_displayName = "Elemental Airborne: (Sword & Shield) Rate";
        public const int Elemental_Airborne_Sword_Shield_Rate_sortIndex = 30050;
        [SortOrder(Elemental_Airborne_Sword_Shield_Rate_sortIndex)]
        [DisplayName(Elemental_Airborne_Sword_Shield_Rate_displayName)]
        public virtual float Elemental_Airborne_Sword_Shield_Rate {
            get => GetData<float>(1215);
            set {
                if (GetData<float>(1215) == value) return;
                SetData(1215, value, nameof(Elemental_Airborne_Sword_Shield_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Elemental_Airborne_Sword_Shield_Rate));
            }
        }

        public const string Elemental_Airborne_Dual_Blades_Rate_displayName = "Elemental Airborne: (Dual Blades) Rate";
        public const int Elemental_Airborne_Dual_Blades_Rate_sortIndex = 30100;
        [SortOrder(Elemental_Airborne_Dual_Blades_Rate_sortIndex)]
        [DisplayName(Elemental_Airborne_Dual_Blades_Rate_displayName)]
        public virtual float Elemental_Airborne_Dual_Blades_Rate {
            get => GetData<float>(1219);
            set {
                if (GetData<float>(1219) == value) return;
                SetData(1219, value, nameof(Elemental_Airborne_Dual_Blades_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Elemental_Airborne_Dual_Blades_Rate));
            }
        }

        public const string Elemental_Airborne_Long_Sword_Rate_displayName = "Elemental Airborne: (Long Sword) Rate";
        public const int Elemental_Airborne_Long_Sword_Rate_sortIndex = 30150;
        [SortOrder(Elemental_Airborne_Long_Sword_Rate_sortIndex)]
        [DisplayName(Elemental_Airborne_Long_Sword_Rate_displayName)]
        public virtual float Elemental_Airborne_Long_Sword_Rate {
            get => GetData<float>(1223);
            set {
                if (GetData<float>(1223) == value) return;
                SetData(1223, value, nameof(Elemental_Airborne_Long_Sword_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Elemental_Airborne_Long_Sword_Rate));
            }
        }

        public const string Elemental_Airborne_Hammer_Rate_displayName = "Elemental Airborne: (Hammer) Rate";
        public const int Elemental_Airborne_Hammer_Rate_sortIndex = 30200;
        [SortOrder(Elemental_Airborne_Hammer_Rate_sortIndex)]
        [DisplayName(Elemental_Airborne_Hammer_Rate_displayName)]
        public virtual float Elemental_Airborne_Hammer_Rate {
            get => GetData<float>(1227);
            set {
                if (GetData<float>(1227) == value) return;
                SetData(1227, value, nameof(Elemental_Airborne_Hammer_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Elemental_Airborne_Hammer_Rate));
            }
        }

        public const string Elemental_Airborne_Hunting_Horn_Rate_displayName = "Elemental Airborne: (Hunting Horn) Rate";
        public const int Elemental_Airborne_Hunting_Horn_Rate_sortIndex = 30250;
        [SortOrder(Elemental_Airborne_Hunting_Horn_Rate_sortIndex)]
        [DisplayName(Elemental_Airborne_Hunting_Horn_Rate_displayName)]
        public virtual float Elemental_Airborne_Hunting_Horn_Rate {
            get => GetData<float>(1231);
            set {
                if (GetData<float>(1231) == value) return;
                SetData(1231, value, nameof(Elemental_Airborne_Hunting_Horn_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Elemental_Airborne_Hunting_Horn_Rate));
            }
        }

        public const string Elemental_Airborne_Lance_Rate_displayName = "Elemental Airborne: (Lance) Rate";
        public const int Elemental_Airborne_Lance_Rate_sortIndex = 30300;
        [SortOrder(Elemental_Airborne_Lance_Rate_sortIndex)]
        [DisplayName(Elemental_Airborne_Lance_Rate_displayName)]
        public virtual float Elemental_Airborne_Lance_Rate {
            get => GetData<float>(1235);
            set {
                if (GetData<float>(1235) == value) return;
                SetData(1235, value, nameof(Elemental_Airborne_Lance_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Elemental_Airborne_Lance_Rate));
            }
        }

        public const string Elemental_Airborne_Gunlance_Rate_displayName = "Elemental Airborne: (Gunlance) Rate";
        public const int Elemental_Airborne_Gunlance_Rate_sortIndex = 30350;
        [SortOrder(Elemental_Airborne_Gunlance_Rate_sortIndex)]
        [DisplayName(Elemental_Airborne_Gunlance_Rate_displayName)]
        public virtual float Elemental_Airborne_Gunlance_Rate {
            get => GetData<float>(1239);
            set {
                if (GetData<float>(1239) == value) return;
                SetData(1239, value, nameof(Elemental_Airborne_Gunlance_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Elemental_Airborne_Gunlance_Rate));
            }
        }

        public const string Elemental_Airborne_Switch_Axe_Rate_displayName = "Elemental Airborne: (Switch Axe) Rate";
        public const int Elemental_Airborne_Switch_Axe_Rate_sortIndex = 30400;
        [SortOrder(Elemental_Airborne_Switch_Axe_Rate_sortIndex)]
        [DisplayName(Elemental_Airborne_Switch_Axe_Rate_displayName)]
        public virtual float Elemental_Airborne_Switch_Axe_Rate {
            get => GetData<float>(1243);
            set {
                if (GetData<float>(1243) == value) return;
                SetData(1243, value, nameof(Elemental_Airborne_Switch_Axe_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Elemental_Airborne_Switch_Axe_Rate));
            }
        }

        public const string Elemental_Airborne_Charge_Blade_Rate_displayName = "Elemental Airborne: (Charge Blade) Rate";
        public const int Elemental_Airborne_Charge_Blade_Rate_sortIndex = 30450;
        [SortOrder(Elemental_Airborne_Charge_Blade_Rate_sortIndex)]
        [DisplayName(Elemental_Airborne_Charge_Blade_Rate_displayName)]
        public virtual float Elemental_Airborne_Charge_Blade_Rate {
            get => GetData<float>(1247);
            set {
                if (GetData<float>(1247) == value) return;
                SetData(1247, value, nameof(Elemental_Airborne_Charge_Blade_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Elemental_Airborne_Charge_Blade_Rate));
            }
        }

        public const string Elemental_Airborne_Insect_Glaive_Rate_displayName = "Elemental Airborne: (Insect Glaive) Rate";
        public const int Elemental_Airborne_Insect_Glaive_Rate_sortIndex = 30500;
        [SortOrder(Elemental_Airborne_Insect_Glaive_Rate_sortIndex)]
        [DisplayName(Elemental_Airborne_Insect_Glaive_Rate_displayName)]
        public virtual float Elemental_Airborne_Insect_Glaive_Rate {
            get => GetData<float>(1251);
            set {
                if (GetData<float>(1251) == value) return;
                SetData(1251, value, nameof(Elemental_Airborne_Insect_Glaive_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Elemental_Airborne_Insect_Glaive_Rate));
            }
        }

        public const string Elemental_Airborne_Bow_Rate_displayName = "Elemental Airborne: (Bow) Rate";
        public const int Elemental_Airborne_Bow_Rate_sortIndex = 30550;
        [SortOrder(Elemental_Airborne_Bow_Rate_sortIndex)]
        [DisplayName(Elemental_Airborne_Bow_Rate_displayName)]
        public virtual float Elemental_Airborne_Bow_Rate {
            get => GetData<float>(1255);
            set {
                if (GetData<float>(1255) == value) return;
                SetData(1255, value, nameof(Elemental_Airborne_Bow_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Elemental_Airborne_Bow_Rate));
            }
        }

        public const string Elemental_Airborne_HBG_Rate_displayName = "Elemental Airborne: (HBG) Rate";
        public const int Elemental_Airborne_HBG_Rate_sortIndex = 30600;
        [SortOrder(Elemental_Airborne_HBG_Rate_sortIndex)]
        [DisplayName(Elemental_Airborne_HBG_Rate_displayName)]
        public virtual float Elemental_Airborne_HBG_Rate {
            get => GetData<float>(1259);
            set {
                if (GetData<float>(1259) == value) return;
                SetData(1259, value, nameof(Elemental_Airborne_HBG_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Elemental_Airborne_HBG_Rate));
            }
        }

        public const string Elemental_Airborne_LBG_Rate_displayName = "Elemental Airborne: (LBG) Rate";
        public const int Elemental_Airborne_LBG_Rate_sortIndex = 30650;
        [SortOrder(Elemental_Airborne_LBG_Rate_sortIndex)]
        [DisplayName(Elemental_Airborne_LBG_Rate_displayName)]
        public virtual float Elemental_Airborne_LBG_Rate {
            get => GetData<float>(1263);
            set {
                if (GetData<float>(1263) == value) return;
                SetData(1263, value, nameof(Elemental_Airborne_LBG_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Elemental_Airborne_LBG_Rate));
            }
        }

        public const string __30700_displayName = "-------------------------------------------------------------------------------------------";
        public const int __30700_sortIndex = 30700;
        [SortOrder(__30700_sortIndex)]
        [DisplayName(__30700_displayName)]
        [IsReadOnly]
        public virtual byte __30700 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__30700));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__30700));
            }
        }

        public const string Unk22_displayName = "Unk22";
        public const int Unk22_sortIndex = 30750;
        [SortOrder(Unk22_sortIndex)]
        [DisplayName(Unk22_displayName)]
        public virtual byte Unk22 {
            get => GetData<byte>(1267);
            set {
                if (GetData<byte>(1267) == value) return;
                SetData(1267, value, nameof(Unk22));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk22));
            }
        }

        public const string Unk23_displayName = "Unk23";
        public const int Unk23_sortIndex = 30800;
        [SortOrder(Unk23_sortIndex)]
        [DisplayName(Unk23_displayName)]
        public virtual byte Unk23 {
            get => GetData<byte>(1268);
            set {
                if (GetData<byte>(1268) == value) return;
                SetData(1268, value, nameof(Unk23));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk23));
            }
        }

        public const string Unk24_displayName = "Unk24";
        public const int Unk24_sortIndex = 30850;
        [SortOrder(Unk24_sortIndex)]
        [DisplayName(Unk24_displayName)]
        public virtual byte Unk24 {
            get => GetData<byte>(1269);
            set {
                if (GetData<byte>(1269) == value) return;
                SetData(1269, value, nameof(Unk24));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk24));
            }
        }

        public const string Unk25_displayName = "Unk25";
        public const int Unk25_sortIndex = 30900;
        [SortOrder(Unk25_sortIndex)]
        [DisplayName(Unk25_displayName)]
        public virtual byte Unk25 {
            get => GetData<byte>(1270);
            set {
                if (GetData<byte>(1270) == value) return;
                SetData(1270, value, nameof(Unk25));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk25));
            }
        }

        public const string Unk26_displayName = "Unk26";
        public const int Unk26_sortIndex = 30950;
        [SortOrder(Unk26_sortIndex)]
        [DisplayName(Unk26_displayName)]
        public virtual byte Unk26 {
            get => GetData<byte>(1271);
            set {
                if (GetData<byte>(1271) == value) return;
                SetData(1271, value, nameof(Unk26));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk26));
            }
        }

        public const string Unk27_displayName = "Unk27";
        public const int Unk27_sortIndex = 31000;
        [SortOrder(Unk27_sortIndex)]
        [DisplayName(Unk27_displayName)]
        public virtual byte Unk27 {
            get => GetData<byte>(1272);
            set {
                if (GetData<byte>(1272) == value) return;
                SetData(1272, value, nameof(Unk27));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk27));
            }
        }

        public const string Unk28_displayName = "Unk28";
        public const int Unk28_sortIndex = 31050;
        [SortOrder(Unk28_sortIndex)]
        [DisplayName(Unk28_displayName)]
        public virtual byte Unk28 {
            get => GetData<byte>(1273);
            set {
                if (GetData<byte>(1273) == value) return;
                SetData(1273, value, nameof(Unk28));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk28));
            }
        }

        public const string Unk29_displayName = "Unk29";
        public const int Unk29_sortIndex = 31100;
        [SortOrder(Unk29_sortIndex)]
        [DisplayName(Unk29_displayName)]
        public virtual byte Unk29 {
            get => GetData<byte>(1274);
            set {
                if (GetData<byte>(1274) == value) return;
                SetData(1274, value, nameof(Unk29));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk29));
            }
        }

        public const string Unk30_displayName = "Unk30";
        public const int Unk30_sortIndex = 31150;
        [SortOrder(Unk30_sortIndex)]
        [DisplayName(Unk30_displayName)]
        public virtual byte Unk30 {
            get => GetData<byte>(1275);
            set {
                if (GetData<byte>(1275) == value) return;
                SetData(1275, value, nameof(Unk30));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk30));
            }
        }

        public const string Unk31_displayName = "Unk31";
        public const int Unk31_sortIndex = 31200;
        [SortOrder(Unk31_sortIndex)]
        [DisplayName(Unk31_displayName)]
        public virtual byte Unk31 {
            get => GetData<byte>(1276);
            set {
                if (GetData<byte>(1276) == value) return;
                SetData(1276, value, nameof(Unk31));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk31));
            }
        }

        public const string Unk32_displayName = "Unk32";
        public const int Unk32_sortIndex = 31250;
        [SortOrder(Unk32_sortIndex)]
        [DisplayName(Unk32_displayName)]
        public virtual float Unk32 {
            get => GetData<float>(1277);
            set {
                if (GetData<float>(1277) == value) return;
                SetData(1277, value, nameof(Unk32));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk32));
            }
        }

        public const string __31300_displayName = "-------------------------------------------------------------------------------------------";
        public const int __31300_sortIndex = 31300;
        [SortOrder(__31300_sortIndex)]
        [DisplayName(__31300_displayName)]
        [IsReadOnly]
        public virtual byte __31300 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__31300));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__31300));
            }
        }

        public const string Frostcraft_Great_Sword_Level_Multiplier_0_15__displayName = "Frostcraft: (Great Sword) Level Multiplier (0-15%)";
        public const int Frostcraft_Great_Sword_Level_Multiplier_0_15__sortIndex = 31350;
        [SortOrder(Frostcraft_Great_Sword_Level_Multiplier_0_15__sortIndex)]
        [DisplayName(Frostcraft_Great_Sword_Level_Multiplier_0_15__displayName)]
        public virtual float Frostcraft_Great_Sword_Level_Multiplier_0_15_ {
            get => GetData<float>(1281);
            set {
                if (GetData<float>(1281) == value) return;
                SetData(1281, value, nameof(Frostcraft_Great_Sword_Level_Multiplier_0_15_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Great_Sword_Level_Multiplier_0_15_));
            }
        }

        public const string Frostcraft_Great_Sword_Level_Multiplier_16_45__displayName = "Frostcraft: (Great Sword) Level Multiplier (16-45%)";
        public const int Frostcraft_Great_Sword_Level_Multiplier_16_45__sortIndex = 31400;
        [SortOrder(Frostcraft_Great_Sword_Level_Multiplier_16_45__sortIndex)]
        [DisplayName(Frostcraft_Great_Sword_Level_Multiplier_16_45__displayName)]
        public virtual float Frostcraft_Great_Sword_Level_Multiplier_16_45_ {
            get => GetData<float>(1285);
            set {
                if (GetData<float>(1285) == value) return;
                SetData(1285, value, nameof(Frostcraft_Great_Sword_Level_Multiplier_16_45_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Great_Sword_Level_Multiplier_16_45_));
            }
        }

        public const string Frostcraft_Great_Sword_Level_Multiplier_46_80__displayName = "Frostcraft: (Great Sword) Level Multiplier (46-80%)";
        public const int Frostcraft_Great_Sword_Level_Multiplier_46_80__sortIndex = 31450;
        [SortOrder(Frostcraft_Great_Sword_Level_Multiplier_46_80__sortIndex)]
        [DisplayName(Frostcraft_Great_Sword_Level_Multiplier_46_80__displayName)]
        public virtual float Frostcraft_Great_Sword_Level_Multiplier_46_80_ {
            get => GetData<float>(1289);
            set {
                if (GetData<float>(1289) == value) return;
                SetData(1289, value, nameof(Frostcraft_Great_Sword_Level_Multiplier_46_80_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Great_Sword_Level_Multiplier_46_80_));
            }
        }

        public const string Frostcraft_Great_Sword_Level_Multiplier_81_100__displayName = "Frostcraft: (Great Sword) Level Multiplier (81-100%)";
        public const int Frostcraft_Great_Sword_Level_Multiplier_81_100__sortIndex = 31500;
        [SortOrder(Frostcraft_Great_Sword_Level_Multiplier_81_100__sortIndex)]
        [DisplayName(Frostcraft_Great_Sword_Level_Multiplier_81_100__displayName)]
        public virtual float Frostcraft_Great_Sword_Level_Multiplier_81_100_ {
            get => GetData<float>(1293);
            set {
                if (GetData<float>(1293) == value) return;
                SetData(1293, value, nameof(Frostcraft_Great_Sword_Level_Multiplier_81_100_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Great_Sword_Level_Multiplier_81_100_));
            }
        }

        public const string Frostcraft_Great_Sword_Recovery_Speed_Unsheathed_displayName = "Frostcraft: (Great Sword) Recovery Speed: Unsheathed";
        public const int Frostcraft_Great_Sword_Recovery_Speed_Unsheathed_sortIndex = 31550;
        [SortOrder(Frostcraft_Great_Sword_Recovery_Speed_Unsheathed_sortIndex)]
        [DisplayName(Frostcraft_Great_Sword_Recovery_Speed_Unsheathed_displayName)]
        public virtual float Frostcraft_Great_Sword_Recovery_Speed_Unsheathed {
            get => GetData<float>(1297);
            set {
                if (GetData<float>(1297) == value) return;
                SetData(1297, value, nameof(Frostcraft_Great_Sword_Recovery_Speed_Unsheathed));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Great_Sword_Recovery_Speed_Unsheathed));
            }
        }

        public const string Frostcraft_Great_Sword_Recovery_Speed_Sheathed_displayName = "Frostcraft: (Great Sword) Recovery Speed: Sheathed";
        public const int Frostcraft_Great_Sword_Recovery_Speed_Sheathed_sortIndex = 31600;
        [SortOrder(Frostcraft_Great_Sword_Recovery_Speed_Sheathed_sortIndex)]
        [DisplayName(Frostcraft_Great_Sword_Recovery_Speed_Sheathed_displayName)]
        public virtual float Frostcraft_Great_Sword_Recovery_Speed_Sheathed {
            get => GetData<float>(1301);
            set {
                if (GetData<float>(1301) == value) return;
                SetData(1301, value, nameof(Frostcraft_Great_Sword_Recovery_Speed_Sheathed));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Great_Sword_Recovery_Speed_Sheathed));
            }
        }

        public const string Frostcraft_Great_Sword_Consumption_per_Hit_displayName = "Frostcraft: (Great Sword) Consumption per Hit";
        public const int Frostcraft_Great_Sword_Consumption_per_Hit_sortIndex = 31650;
        [SortOrder(Frostcraft_Great_Sword_Consumption_per_Hit_sortIndex)]
        [DisplayName(Frostcraft_Great_Sword_Consumption_per_Hit_displayName)]
        public virtual float Frostcraft_Great_Sword_Consumption_per_Hit {
            get => GetData<float>(1305);
            set {
                if (GetData<float>(1305) == value) return;
                SetData(1305, value, nameof(Frostcraft_Great_Sword_Consumption_per_Hit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Great_Sword_Consumption_per_Hit));
            }
        }

        public const string __31700_displayName = "-------------------------------------------------------------------------------------------";
        public const int __31700_sortIndex = 31700;
        [SortOrder(__31700_sortIndex)]
        [DisplayName(__31700_displayName)]
        [IsReadOnly]
        public virtual byte __31700 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__31700));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__31700));
            }
        }

        public const string Frostcraft_Sword_Shield_Level_Multiplier_0_15__displayName = "Frostcraft: (Sword & Shield) Level Multiplier (0-15%)";
        public const int Frostcraft_Sword_Shield_Level_Multiplier_0_15__sortIndex = 31750;
        [SortOrder(Frostcraft_Sword_Shield_Level_Multiplier_0_15__sortIndex)]
        [DisplayName(Frostcraft_Sword_Shield_Level_Multiplier_0_15__displayName)]
        public virtual float Frostcraft_Sword_Shield_Level_Multiplier_0_15_ {
            get => GetData<float>(1309);
            set {
                if (GetData<float>(1309) == value) return;
                SetData(1309, value, nameof(Frostcraft_Sword_Shield_Level_Multiplier_0_15_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Sword_Shield_Level_Multiplier_0_15_));
            }
        }

        public const string Frostcraft_Sword_Shield_Level_Multiplier_16_45__displayName = "Frostcraft: (Sword & Shield) Level Multiplier (16-45%)";
        public const int Frostcraft_Sword_Shield_Level_Multiplier_16_45__sortIndex = 31800;
        [SortOrder(Frostcraft_Sword_Shield_Level_Multiplier_16_45__sortIndex)]
        [DisplayName(Frostcraft_Sword_Shield_Level_Multiplier_16_45__displayName)]
        public virtual float Frostcraft_Sword_Shield_Level_Multiplier_16_45_ {
            get => GetData<float>(1313);
            set {
                if (GetData<float>(1313) == value) return;
                SetData(1313, value, nameof(Frostcraft_Sword_Shield_Level_Multiplier_16_45_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Sword_Shield_Level_Multiplier_16_45_));
            }
        }

        public const string Frostcraft_Sword_Shield_Level_Multiplier_46_80__displayName = "Frostcraft: (Sword & Shield) Level Multiplier (46-80%)";
        public const int Frostcraft_Sword_Shield_Level_Multiplier_46_80__sortIndex = 31850;
        [SortOrder(Frostcraft_Sword_Shield_Level_Multiplier_46_80__sortIndex)]
        [DisplayName(Frostcraft_Sword_Shield_Level_Multiplier_46_80__displayName)]
        public virtual float Frostcraft_Sword_Shield_Level_Multiplier_46_80_ {
            get => GetData<float>(1317);
            set {
                if (GetData<float>(1317) == value) return;
                SetData(1317, value, nameof(Frostcraft_Sword_Shield_Level_Multiplier_46_80_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Sword_Shield_Level_Multiplier_46_80_));
            }
        }

        public const string Frostcraft_Sword_Shield_Level_Multiplier_81_100__displayName = "Frostcraft: (Sword & Shield) Level Multiplier (81-100%)";
        public const int Frostcraft_Sword_Shield_Level_Multiplier_81_100__sortIndex = 31900;
        [SortOrder(Frostcraft_Sword_Shield_Level_Multiplier_81_100__sortIndex)]
        [DisplayName(Frostcraft_Sword_Shield_Level_Multiplier_81_100__displayName)]
        public virtual float Frostcraft_Sword_Shield_Level_Multiplier_81_100_ {
            get => GetData<float>(1321);
            set {
                if (GetData<float>(1321) == value) return;
                SetData(1321, value, nameof(Frostcraft_Sword_Shield_Level_Multiplier_81_100_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Sword_Shield_Level_Multiplier_81_100_));
            }
        }

        public const string Frostcraft_Sword_Shield_Recovery_Speed_Unsheathed_displayName = "Frostcraft: (Sword & Shield) Recovery Speed: Unsheathed";
        public const int Frostcraft_Sword_Shield_Recovery_Speed_Unsheathed_sortIndex = 31950;
        [SortOrder(Frostcraft_Sword_Shield_Recovery_Speed_Unsheathed_sortIndex)]
        [DisplayName(Frostcraft_Sword_Shield_Recovery_Speed_Unsheathed_displayName)]
        public virtual float Frostcraft_Sword_Shield_Recovery_Speed_Unsheathed {
            get => GetData<float>(1325);
            set {
                if (GetData<float>(1325) == value) return;
                SetData(1325, value, nameof(Frostcraft_Sword_Shield_Recovery_Speed_Unsheathed));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Sword_Shield_Recovery_Speed_Unsheathed));
            }
        }

        public const string Frostcraft_Sword_Shield_Recovery_Speed_Sheathed_displayName = "Frostcraft: (Sword & Shield) Recovery Speed: Sheathed";
        public const int Frostcraft_Sword_Shield_Recovery_Speed_Sheathed_sortIndex = 32000;
        [SortOrder(Frostcraft_Sword_Shield_Recovery_Speed_Sheathed_sortIndex)]
        [DisplayName(Frostcraft_Sword_Shield_Recovery_Speed_Sheathed_displayName)]
        public virtual float Frostcraft_Sword_Shield_Recovery_Speed_Sheathed {
            get => GetData<float>(1329);
            set {
                if (GetData<float>(1329) == value) return;
                SetData(1329, value, nameof(Frostcraft_Sword_Shield_Recovery_Speed_Sheathed));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Sword_Shield_Recovery_Speed_Sheathed));
            }
        }

        public const string Frostcraft_Sword_Shield_Consumption_per_Hit_displayName = "Frostcraft: (Sword & Shield) Consumption per Hit";
        public const int Frostcraft_Sword_Shield_Consumption_per_Hit_sortIndex = 32050;
        [SortOrder(Frostcraft_Sword_Shield_Consumption_per_Hit_sortIndex)]
        [DisplayName(Frostcraft_Sword_Shield_Consumption_per_Hit_displayName)]
        public virtual float Frostcraft_Sword_Shield_Consumption_per_Hit {
            get => GetData<float>(1333);
            set {
                if (GetData<float>(1333) == value) return;
                SetData(1333, value, nameof(Frostcraft_Sword_Shield_Consumption_per_Hit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Sword_Shield_Consumption_per_Hit));
            }
        }

        public const string __32100_displayName = "-------------------------------------------------------------------------------------------";
        public const int __32100_sortIndex = 32100;
        [SortOrder(__32100_sortIndex)]
        [DisplayName(__32100_displayName)]
        [IsReadOnly]
        public virtual byte __32100 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__32100));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__32100));
            }
        }

        public const string Frostcraft_Dual_Blades_Level_Multiplier_0_15__displayName = "Frostcraft: (Dual Blades) Level Multiplier (0-15%)";
        public const int Frostcraft_Dual_Blades_Level_Multiplier_0_15__sortIndex = 32150;
        [SortOrder(Frostcraft_Dual_Blades_Level_Multiplier_0_15__sortIndex)]
        [DisplayName(Frostcraft_Dual_Blades_Level_Multiplier_0_15__displayName)]
        public virtual float Frostcraft_Dual_Blades_Level_Multiplier_0_15_ {
            get => GetData<float>(1337);
            set {
                if (GetData<float>(1337) == value) return;
                SetData(1337, value, nameof(Frostcraft_Dual_Blades_Level_Multiplier_0_15_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Dual_Blades_Level_Multiplier_0_15_));
            }
        }

        public const string Frostcraft_Dual_Blades_Level_Multiplier_16_45__displayName = "Frostcraft: (Dual Blades) Level Multiplier (16-45%)";
        public const int Frostcraft_Dual_Blades_Level_Multiplier_16_45__sortIndex = 32200;
        [SortOrder(Frostcraft_Dual_Blades_Level_Multiplier_16_45__sortIndex)]
        [DisplayName(Frostcraft_Dual_Blades_Level_Multiplier_16_45__displayName)]
        public virtual float Frostcraft_Dual_Blades_Level_Multiplier_16_45_ {
            get => GetData<float>(1341);
            set {
                if (GetData<float>(1341) == value) return;
                SetData(1341, value, nameof(Frostcraft_Dual_Blades_Level_Multiplier_16_45_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Dual_Blades_Level_Multiplier_16_45_));
            }
        }

        public const string Frostcraft_Dual_Blades_Level_Multiplier_46_80__displayName = "Frostcraft: (Dual Blades) Level Multiplier (46-80%)";
        public const int Frostcraft_Dual_Blades_Level_Multiplier_46_80__sortIndex = 32250;
        [SortOrder(Frostcraft_Dual_Blades_Level_Multiplier_46_80__sortIndex)]
        [DisplayName(Frostcraft_Dual_Blades_Level_Multiplier_46_80__displayName)]
        public virtual float Frostcraft_Dual_Blades_Level_Multiplier_46_80_ {
            get => GetData<float>(1345);
            set {
                if (GetData<float>(1345) == value) return;
                SetData(1345, value, nameof(Frostcraft_Dual_Blades_Level_Multiplier_46_80_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Dual_Blades_Level_Multiplier_46_80_));
            }
        }

        public const string Frostcraft_Dual_Blades_Level_Multiplier_81_100__displayName = "Frostcraft: (Dual Blades) Level Multiplier (81-100%)";
        public const int Frostcraft_Dual_Blades_Level_Multiplier_81_100__sortIndex = 32300;
        [SortOrder(Frostcraft_Dual_Blades_Level_Multiplier_81_100__sortIndex)]
        [DisplayName(Frostcraft_Dual_Blades_Level_Multiplier_81_100__displayName)]
        public virtual float Frostcraft_Dual_Blades_Level_Multiplier_81_100_ {
            get => GetData<float>(1349);
            set {
                if (GetData<float>(1349) == value) return;
                SetData(1349, value, nameof(Frostcraft_Dual_Blades_Level_Multiplier_81_100_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Dual_Blades_Level_Multiplier_81_100_));
            }
        }

        public const string Frostcraft_Dual_Blades_Recovery_Speed_Unsheathed_displayName = "Frostcraft: (Dual Blades) Recovery Speed: Unsheathed";
        public const int Frostcraft_Dual_Blades_Recovery_Speed_Unsheathed_sortIndex = 32350;
        [SortOrder(Frostcraft_Dual_Blades_Recovery_Speed_Unsheathed_sortIndex)]
        [DisplayName(Frostcraft_Dual_Blades_Recovery_Speed_Unsheathed_displayName)]
        public virtual float Frostcraft_Dual_Blades_Recovery_Speed_Unsheathed {
            get => GetData<float>(1353);
            set {
                if (GetData<float>(1353) == value) return;
                SetData(1353, value, nameof(Frostcraft_Dual_Blades_Recovery_Speed_Unsheathed));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Dual_Blades_Recovery_Speed_Unsheathed));
            }
        }

        public const string Frostcraft_Dual_Blades_Recovery_Speed_Sheathed_displayName = "Frostcraft: (Dual Blades) Recovery Speed: Sheathed";
        public const int Frostcraft_Dual_Blades_Recovery_Speed_Sheathed_sortIndex = 32400;
        [SortOrder(Frostcraft_Dual_Blades_Recovery_Speed_Sheathed_sortIndex)]
        [DisplayName(Frostcraft_Dual_Blades_Recovery_Speed_Sheathed_displayName)]
        public virtual float Frostcraft_Dual_Blades_Recovery_Speed_Sheathed {
            get => GetData<float>(1357);
            set {
                if (GetData<float>(1357) == value) return;
                SetData(1357, value, nameof(Frostcraft_Dual_Blades_Recovery_Speed_Sheathed));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Dual_Blades_Recovery_Speed_Sheathed));
            }
        }

        public const string Frostcraft_Dual_Blades_Consumption_per_Hit_displayName = "Frostcraft: (Dual Blades) Consumption per Hit";
        public const int Frostcraft_Dual_Blades_Consumption_per_Hit_sortIndex = 32450;
        [SortOrder(Frostcraft_Dual_Blades_Consumption_per_Hit_sortIndex)]
        [DisplayName(Frostcraft_Dual_Blades_Consumption_per_Hit_displayName)]
        public virtual float Frostcraft_Dual_Blades_Consumption_per_Hit {
            get => GetData<float>(1361);
            set {
                if (GetData<float>(1361) == value) return;
                SetData(1361, value, nameof(Frostcraft_Dual_Blades_Consumption_per_Hit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Dual_Blades_Consumption_per_Hit));
            }
        }

        public const string __32500_displayName = "-------------------------------------------------------------------------------------------";
        public const int __32500_sortIndex = 32500;
        [SortOrder(__32500_sortIndex)]
        [DisplayName(__32500_displayName)]
        [IsReadOnly]
        public virtual byte __32500 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__32500));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__32500));
            }
        }

        public const string Frostcraft_Long_Sword_Level_Multiplier_0_15__displayName = "Frostcraft: (Long Sword) Level Multiplier (0-15%)";
        public const int Frostcraft_Long_Sword_Level_Multiplier_0_15__sortIndex = 32550;
        [SortOrder(Frostcraft_Long_Sword_Level_Multiplier_0_15__sortIndex)]
        [DisplayName(Frostcraft_Long_Sword_Level_Multiplier_0_15__displayName)]
        public virtual float Frostcraft_Long_Sword_Level_Multiplier_0_15_ {
            get => GetData<float>(1365);
            set {
                if (GetData<float>(1365) == value) return;
                SetData(1365, value, nameof(Frostcraft_Long_Sword_Level_Multiplier_0_15_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Long_Sword_Level_Multiplier_0_15_));
            }
        }

        public const string Frostcraft_Long_Sword_Level_Multiplier_16_45__displayName = "Frostcraft: (Long Sword) Level Multiplier (16-45%)";
        public const int Frostcraft_Long_Sword_Level_Multiplier_16_45__sortIndex = 32600;
        [SortOrder(Frostcraft_Long_Sword_Level_Multiplier_16_45__sortIndex)]
        [DisplayName(Frostcraft_Long_Sword_Level_Multiplier_16_45__displayName)]
        public virtual float Frostcraft_Long_Sword_Level_Multiplier_16_45_ {
            get => GetData<float>(1369);
            set {
                if (GetData<float>(1369) == value) return;
                SetData(1369, value, nameof(Frostcraft_Long_Sword_Level_Multiplier_16_45_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Long_Sword_Level_Multiplier_16_45_));
            }
        }

        public const string Frostcraft_Long_Sword_Level_Multiplier_46_80__displayName = "Frostcraft: (Long Sword) Level Multiplier (46-80%)";
        public const int Frostcraft_Long_Sword_Level_Multiplier_46_80__sortIndex = 32650;
        [SortOrder(Frostcraft_Long_Sword_Level_Multiplier_46_80__sortIndex)]
        [DisplayName(Frostcraft_Long_Sword_Level_Multiplier_46_80__displayName)]
        public virtual float Frostcraft_Long_Sword_Level_Multiplier_46_80_ {
            get => GetData<float>(1373);
            set {
                if (GetData<float>(1373) == value) return;
                SetData(1373, value, nameof(Frostcraft_Long_Sword_Level_Multiplier_46_80_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Long_Sword_Level_Multiplier_46_80_));
            }
        }

        public const string Frostcraft_Long_Sword_Level_Multiplier_81_100__displayName = "Frostcraft: (Long Sword) Level Multiplier (81-100%)";
        public const int Frostcraft_Long_Sword_Level_Multiplier_81_100__sortIndex = 32700;
        [SortOrder(Frostcraft_Long_Sword_Level_Multiplier_81_100__sortIndex)]
        [DisplayName(Frostcraft_Long_Sword_Level_Multiplier_81_100__displayName)]
        public virtual float Frostcraft_Long_Sword_Level_Multiplier_81_100_ {
            get => GetData<float>(1377);
            set {
                if (GetData<float>(1377) == value) return;
                SetData(1377, value, nameof(Frostcraft_Long_Sword_Level_Multiplier_81_100_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Long_Sword_Level_Multiplier_81_100_));
            }
        }

        public const string Frostcraft_Long_Sword_Recovery_Speed_Unsheathed_displayName = "Frostcraft: (Long Sword) Recovery Speed: Unsheathed";
        public const int Frostcraft_Long_Sword_Recovery_Speed_Unsheathed_sortIndex = 32750;
        [SortOrder(Frostcraft_Long_Sword_Recovery_Speed_Unsheathed_sortIndex)]
        [DisplayName(Frostcraft_Long_Sword_Recovery_Speed_Unsheathed_displayName)]
        public virtual float Frostcraft_Long_Sword_Recovery_Speed_Unsheathed {
            get => GetData<float>(1381);
            set {
                if (GetData<float>(1381) == value) return;
                SetData(1381, value, nameof(Frostcraft_Long_Sword_Recovery_Speed_Unsheathed));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Long_Sword_Recovery_Speed_Unsheathed));
            }
        }

        public const string Frostcraft_Long_Sword_Recovery_Speed_Sheathed_displayName = "Frostcraft: (Long Sword) Recovery Speed: Sheathed";
        public const int Frostcraft_Long_Sword_Recovery_Speed_Sheathed_sortIndex = 32800;
        [SortOrder(Frostcraft_Long_Sword_Recovery_Speed_Sheathed_sortIndex)]
        [DisplayName(Frostcraft_Long_Sword_Recovery_Speed_Sheathed_displayName)]
        public virtual float Frostcraft_Long_Sword_Recovery_Speed_Sheathed {
            get => GetData<float>(1385);
            set {
                if (GetData<float>(1385) == value) return;
                SetData(1385, value, nameof(Frostcraft_Long_Sword_Recovery_Speed_Sheathed));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Long_Sword_Recovery_Speed_Sheathed));
            }
        }

        public const string Frostcraft_Long_Sword_Consumption_per_Hit_displayName = "Frostcraft: (Long Sword) Consumption per Hit";
        public const int Frostcraft_Long_Sword_Consumption_per_Hit_sortIndex = 32850;
        [SortOrder(Frostcraft_Long_Sword_Consumption_per_Hit_sortIndex)]
        [DisplayName(Frostcraft_Long_Sword_Consumption_per_Hit_displayName)]
        public virtual float Frostcraft_Long_Sword_Consumption_per_Hit {
            get => GetData<float>(1389);
            set {
                if (GetData<float>(1389) == value) return;
                SetData(1389, value, nameof(Frostcraft_Long_Sword_Consumption_per_Hit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Long_Sword_Consumption_per_Hit));
            }
        }

        public const string __32900_displayName = "-------------------------------------------------------------------------------------------";
        public const int __32900_sortIndex = 32900;
        [SortOrder(__32900_sortIndex)]
        [DisplayName(__32900_displayName)]
        [IsReadOnly]
        public virtual byte __32900 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__32900));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__32900));
            }
        }

        public const string Frostcraft_Hammer_Level_Multiplier_0_15__displayName = "Frostcraft: (Hammer) Level Multiplier (0-15%)";
        public const int Frostcraft_Hammer_Level_Multiplier_0_15__sortIndex = 32950;
        [SortOrder(Frostcraft_Hammer_Level_Multiplier_0_15__sortIndex)]
        [DisplayName(Frostcraft_Hammer_Level_Multiplier_0_15__displayName)]
        public virtual float Frostcraft_Hammer_Level_Multiplier_0_15_ {
            get => GetData<float>(1393);
            set {
                if (GetData<float>(1393) == value) return;
                SetData(1393, value, nameof(Frostcraft_Hammer_Level_Multiplier_0_15_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Hammer_Level_Multiplier_0_15_));
            }
        }

        public const string Frostcraft_Hammer_Level_Multiplier_16_45__displayName = "Frostcraft: (Hammer) Level Multiplier (16-45%)";
        public const int Frostcraft_Hammer_Level_Multiplier_16_45__sortIndex = 33000;
        [SortOrder(Frostcraft_Hammer_Level_Multiplier_16_45__sortIndex)]
        [DisplayName(Frostcraft_Hammer_Level_Multiplier_16_45__displayName)]
        public virtual float Frostcraft_Hammer_Level_Multiplier_16_45_ {
            get => GetData<float>(1397);
            set {
                if (GetData<float>(1397) == value) return;
                SetData(1397, value, nameof(Frostcraft_Hammer_Level_Multiplier_16_45_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Hammer_Level_Multiplier_16_45_));
            }
        }

        public const string Frostcraft_Hammer_Level_Multiplier_46_80__displayName = "Frostcraft: (Hammer) Level Multiplier (46-80%)";
        public const int Frostcraft_Hammer_Level_Multiplier_46_80__sortIndex = 33050;
        [SortOrder(Frostcraft_Hammer_Level_Multiplier_46_80__sortIndex)]
        [DisplayName(Frostcraft_Hammer_Level_Multiplier_46_80__displayName)]
        public virtual float Frostcraft_Hammer_Level_Multiplier_46_80_ {
            get => GetData<float>(1401);
            set {
                if (GetData<float>(1401) == value) return;
                SetData(1401, value, nameof(Frostcraft_Hammer_Level_Multiplier_46_80_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Hammer_Level_Multiplier_46_80_));
            }
        }

        public const string Frostcraft_Hammer_Level_Multiplier_81_100__displayName = "Frostcraft: (Hammer) Level Multiplier (81-100%)";
        public const int Frostcraft_Hammer_Level_Multiplier_81_100__sortIndex = 33100;
        [SortOrder(Frostcraft_Hammer_Level_Multiplier_81_100__sortIndex)]
        [DisplayName(Frostcraft_Hammer_Level_Multiplier_81_100__displayName)]
        public virtual float Frostcraft_Hammer_Level_Multiplier_81_100_ {
            get => GetData<float>(1405);
            set {
                if (GetData<float>(1405) == value) return;
                SetData(1405, value, nameof(Frostcraft_Hammer_Level_Multiplier_81_100_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Hammer_Level_Multiplier_81_100_));
            }
        }

        public const string Frostcraft_Hammer_Recovery_Speed_Unsheathed_displayName = "Frostcraft: (Hammer) Recovery Speed: Unsheathed";
        public const int Frostcraft_Hammer_Recovery_Speed_Unsheathed_sortIndex = 33150;
        [SortOrder(Frostcraft_Hammer_Recovery_Speed_Unsheathed_sortIndex)]
        [DisplayName(Frostcraft_Hammer_Recovery_Speed_Unsheathed_displayName)]
        public virtual float Frostcraft_Hammer_Recovery_Speed_Unsheathed {
            get => GetData<float>(1409);
            set {
                if (GetData<float>(1409) == value) return;
                SetData(1409, value, nameof(Frostcraft_Hammer_Recovery_Speed_Unsheathed));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Hammer_Recovery_Speed_Unsheathed));
            }
        }

        public const string Frostcraft_Hammer_Recovery_Speed_Sheathed_displayName = "Frostcraft: (Hammer) Recovery Speed: Sheathed";
        public const int Frostcraft_Hammer_Recovery_Speed_Sheathed_sortIndex = 33200;
        [SortOrder(Frostcraft_Hammer_Recovery_Speed_Sheathed_sortIndex)]
        [DisplayName(Frostcraft_Hammer_Recovery_Speed_Sheathed_displayName)]
        public virtual float Frostcraft_Hammer_Recovery_Speed_Sheathed {
            get => GetData<float>(1413);
            set {
                if (GetData<float>(1413) == value) return;
                SetData(1413, value, nameof(Frostcraft_Hammer_Recovery_Speed_Sheathed));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Hammer_Recovery_Speed_Sheathed));
            }
        }

        public const string Frostcraft_Hammer_Consumption_per_Hit_displayName = "Frostcraft: (Hammer) Consumption per Hit";
        public const int Frostcraft_Hammer_Consumption_per_Hit_sortIndex = 33250;
        [SortOrder(Frostcraft_Hammer_Consumption_per_Hit_sortIndex)]
        [DisplayName(Frostcraft_Hammer_Consumption_per_Hit_displayName)]
        public virtual float Frostcraft_Hammer_Consumption_per_Hit {
            get => GetData<float>(1417);
            set {
                if (GetData<float>(1417) == value) return;
                SetData(1417, value, nameof(Frostcraft_Hammer_Consumption_per_Hit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Hammer_Consumption_per_Hit));
            }
        }

        public const string __33300_displayName = "-------------------------------------------------------------------------------------------";
        public const int __33300_sortIndex = 33300;
        [SortOrder(__33300_sortIndex)]
        [DisplayName(__33300_displayName)]
        [IsReadOnly]
        public virtual byte __33300 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__33300));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__33300));
            }
        }

        public const string Frostcraft_Hunting_Horn_Level_Multiplier_0_15__displayName = "Frostcraft: (Hunting Horn) Level Multiplier (0-15%)";
        public const int Frostcraft_Hunting_Horn_Level_Multiplier_0_15__sortIndex = 33350;
        [SortOrder(Frostcraft_Hunting_Horn_Level_Multiplier_0_15__sortIndex)]
        [DisplayName(Frostcraft_Hunting_Horn_Level_Multiplier_0_15__displayName)]
        public virtual float Frostcraft_Hunting_Horn_Level_Multiplier_0_15_ {
            get => GetData<float>(1421);
            set {
                if (GetData<float>(1421) == value) return;
                SetData(1421, value, nameof(Frostcraft_Hunting_Horn_Level_Multiplier_0_15_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Hunting_Horn_Level_Multiplier_0_15_));
            }
        }

        public const string Frostcraft_Hunting_Horn_Level_Multiplier_16_45__displayName = "Frostcraft: (Hunting Horn) Level Multiplier (16-45%)";
        public const int Frostcraft_Hunting_Horn_Level_Multiplier_16_45__sortIndex = 33400;
        [SortOrder(Frostcraft_Hunting_Horn_Level_Multiplier_16_45__sortIndex)]
        [DisplayName(Frostcraft_Hunting_Horn_Level_Multiplier_16_45__displayName)]
        public virtual float Frostcraft_Hunting_Horn_Level_Multiplier_16_45_ {
            get => GetData<float>(1425);
            set {
                if (GetData<float>(1425) == value) return;
                SetData(1425, value, nameof(Frostcraft_Hunting_Horn_Level_Multiplier_16_45_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Hunting_Horn_Level_Multiplier_16_45_));
            }
        }

        public const string Frostcraft_Hunting_Horn_Level_Multiplier_46_80__displayName = "Frostcraft: (Hunting Horn) Level Multiplier (46-80%)";
        public const int Frostcraft_Hunting_Horn_Level_Multiplier_46_80__sortIndex = 33450;
        [SortOrder(Frostcraft_Hunting_Horn_Level_Multiplier_46_80__sortIndex)]
        [DisplayName(Frostcraft_Hunting_Horn_Level_Multiplier_46_80__displayName)]
        public virtual float Frostcraft_Hunting_Horn_Level_Multiplier_46_80_ {
            get => GetData<float>(1429);
            set {
                if (GetData<float>(1429) == value) return;
                SetData(1429, value, nameof(Frostcraft_Hunting_Horn_Level_Multiplier_46_80_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Hunting_Horn_Level_Multiplier_46_80_));
            }
        }

        public const string Frostcraft_Hunting_Horn_Level_Multiplier_81_100__displayName = "Frostcraft: (Hunting Horn) Level Multiplier (81-100%)";
        public const int Frostcraft_Hunting_Horn_Level_Multiplier_81_100__sortIndex = 33500;
        [SortOrder(Frostcraft_Hunting_Horn_Level_Multiplier_81_100__sortIndex)]
        [DisplayName(Frostcraft_Hunting_Horn_Level_Multiplier_81_100__displayName)]
        public virtual float Frostcraft_Hunting_Horn_Level_Multiplier_81_100_ {
            get => GetData<float>(1433);
            set {
                if (GetData<float>(1433) == value) return;
                SetData(1433, value, nameof(Frostcraft_Hunting_Horn_Level_Multiplier_81_100_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Hunting_Horn_Level_Multiplier_81_100_));
            }
        }

        public const string Frostcraft_Hunting_Horn_Recovery_Speed_Unsheathed_displayName = "Frostcraft: (Hunting Horn) Recovery Speed: Unsheathed";
        public const int Frostcraft_Hunting_Horn_Recovery_Speed_Unsheathed_sortIndex = 33550;
        [SortOrder(Frostcraft_Hunting_Horn_Recovery_Speed_Unsheathed_sortIndex)]
        [DisplayName(Frostcraft_Hunting_Horn_Recovery_Speed_Unsheathed_displayName)]
        public virtual float Frostcraft_Hunting_Horn_Recovery_Speed_Unsheathed {
            get => GetData<float>(1437);
            set {
                if (GetData<float>(1437) == value) return;
                SetData(1437, value, nameof(Frostcraft_Hunting_Horn_Recovery_Speed_Unsheathed));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Hunting_Horn_Recovery_Speed_Unsheathed));
            }
        }

        public const string Frostcraft_Hunting_Horn_Recovery_Speed_Sheathed_displayName = "Frostcraft: (Hunting Horn) Recovery Speed: Sheathed";
        public const int Frostcraft_Hunting_Horn_Recovery_Speed_Sheathed_sortIndex = 33600;
        [SortOrder(Frostcraft_Hunting_Horn_Recovery_Speed_Sheathed_sortIndex)]
        [DisplayName(Frostcraft_Hunting_Horn_Recovery_Speed_Sheathed_displayName)]
        public virtual float Frostcraft_Hunting_Horn_Recovery_Speed_Sheathed {
            get => GetData<float>(1441);
            set {
                if (GetData<float>(1441) == value) return;
                SetData(1441, value, nameof(Frostcraft_Hunting_Horn_Recovery_Speed_Sheathed));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Hunting_Horn_Recovery_Speed_Sheathed));
            }
        }

        public const string Frostcraft_Hunting_Horn_Consumption_per_Hit_displayName = "Frostcraft: (Hunting Horn) Consumption per Hit";
        public const int Frostcraft_Hunting_Horn_Consumption_per_Hit_sortIndex = 33650;
        [SortOrder(Frostcraft_Hunting_Horn_Consumption_per_Hit_sortIndex)]
        [DisplayName(Frostcraft_Hunting_Horn_Consumption_per_Hit_displayName)]
        public virtual float Frostcraft_Hunting_Horn_Consumption_per_Hit {
            get => GetData<float>(1445);
            set {
                if (GetData<float>(1445) == value) return;
                SetData(1445, value, nameof(Frostcraft_Hunting_Horn_Consumption_per_Hit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Hunting_Horn_Consumption_per_Hit));
            }
        }

        public const string __33700_displayName = "-------------------------------------------------------------------------------------------";
        public const int __33700_sortIndex = 33700;
        [SortOrder(__33700_sortIndex)]
        [DisplayName(__33700_displayName)]
        [IsReadOnly]
        public virtual byte __33700 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__33700));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__33700));
            }
        }

        public const string Frostcraft_Lance_Level_Multiplier_0_15__displayName = "Frostcraft: (Lance) Level Multiplier (0-15%)";
        public const int Frostcraft_Lance_Level_Multiplier_0_15__sortIndex = 33750;
        [SortOrder(Frostcraft_Lance_Level_Multiplier_0_15__sortIndex)]
        [DisplayName(Frostcraft_Lance_Level_Multiplier_0_15__displayName)]
        public virtual float Frostcraft_Lance_Level_Multiplier_0_15_ {
            get => GetData<float>(1449);
            set {
                if (GetData<float>(1449) == value) return;
                SetData(1449, value, nameof(Frostcraft_Lance_Level_Multiplier_0_15_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Lance_Level_Multiplier_0_15_));
            }
        }

        public const string Frostcraft_Lance_Level_Multiplier_16_45__displayName = "Frostcraft: (Lance) Level Multiplier (16-45%)";
        public const int Frostcraft_Lance_Level_Multiplier_16_45__sortIndex = 33800;
        [SortOrder(Frostcraft_Lance_Level_Multiplier_16_45__sortIndex)]
        [DisplayName(Frostcraft_Lance_Level_Multiplier_16_45__displayName)]
        public virtual float Frostcraft_Lance_Level_Multiplier_16_45_ {
            get => GetData<float>(1453);
            set {
                if (GetData<float>(1453) == value) return;
                SetData(1453, value, nameof(Frostcraft_Lance_Level_Multiplier_16_45_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Lance_Level_Multiplier_16_45_));
            }
        }

        public const string Frostcraft_Lance_Level_Multiplier_46_80__displayName = "Frostcraft: (Lance) Level Multiplier (46-80%)";
        public const int Frostcraft_Lance_Level_Multiplier_46_80__sortIndex = 33850;
        [SortOrder(Frostcraft_Lance_Level_Multiplier_46_80__sortIndex)]
        [DisplayName(Frostcraft_Lance_Level_Multiplier_46_80__displayName)]
        public virtual float Frostcraft_Lance_Level_Multiplier_46_80_ {
            get => GetData<float>(1457);
            set {
                if (GetData<float>(1457) == value) return;
                SetData(1457, value, nameof(Frostcraft_Lance_Level_Multiplier_46_80_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Lance_Level_Multiplier_46_80_));
            }
        }

        public const string Frostcraft_Lance_Level_Multiplier_81_100__displayName = "Frostcraft: (Lance) Level Multiplier (81-100%)";
        public const int Frostcraft_Lance_Level_Multiplier_81_100__sortIndex = 33900;
        [SortOrder(Frostcraft_Lance_Level_Multiplier_81_100__sortIndex)]
        [DisplayName(Frostcraft_Lance_Level_Multiplier_81_100__displayName)]
        public virtual float Frostcraft_Lance_Level_Multiplier_81_100_ {
            get => GetData<float>(1461);
            set {
                if (GetData<float>(1461) == value) return;
                SetData(1461, value, nameof(Frostcraft_Lance_Level_Multiplier_81_100_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Lance_Level_Multiplier_81_100_));
            }
        }

        public const string Frostcraft_Lance_Recovery_Speed_Unsheathed_displayName = "Frostcraft: (Lance) Recovery Speed: Unsheathed";
        public const int Frostcraft_Lance_Recovery_Speed_Unsheathed_sortIndex = 33950;
        [SortOrder(Frostcraft_Lance_Recovery_Speed_Unsheathed_sortIndex)]
        [DisplayName(Frostcraft_Lance_Recovery_Speed_Unsheathed_displayName)]
        public virtual float Frostcraft_Lance_Recovery_Speed_Unsheathed {
            get => GetData<float>(1465);
            set {
                if (GetData<float>(1465) == value) return;
                SetData(1465, value, nameof(Frostcraft_Lance_Recovery_Speed_Unsheathed));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Lance_Recovery_Speed_Unsheathed));
            }
        }

        public const string Frostcraft_Lance_Recovery_Speed_Sheathed_displayName = "Frostcraft: (Lance) Recovery Speed: Sheathed";
        public const int Frostcraft_Lance_Recovery_Speed_Sheathed_sortIndex = 34000;
        [SortOrder(Frostcraft_Lance_Recovery_Speed_Sheathed_sortIndex)]
        [DisplayName(Frostcraft_Lance_Recovery_Speed_Sheathed_displayName)]
        public virtual float Frostcraft_Lance_Recovery_Speed_Sheathed {
            get => GetData<float>(1469);
            set {
                if (GetData<float>(1469) == value) return;
                SetData(1469, value, nameof(Frostcraft_Lance_Recovery_Speed_Sheathed));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Lance_Recovery_Speed_Sheathed));
            }
        }

        public const string Frostcraft_Lance_Consumption_per_Hit_displayName = "Frostcraft: (Lance) Consumption per Hit";
        public const int Frostcraft_Lance_Consumption_per_Hit_sortIndex = 34050;
        [SortOrder(Frostcraft_Lance_Consumption_per_Hit_sortIndex)]
        [DisplayName(Frostcraft_Lance_Consumption_per_Hit_displayName)]
        public virtual float Frostcraft_Lance_Consumption_per_Hit {
            get => GetData<float>(1473);
            set {
                if (GetData<float>(1473) == value) return;
                SetData(1473, value, nameof(Frostcraft_Lance_Consumption_per_Hit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Lance_Consumption_per_Hit));
            }
        }

        public const string __34100_displayName = "-------------------------------------------------------------------------------------------";
        public const int __34100_sortIndex = 34100;
        [SortOrder(__34100_sortIndex)]
        [DisplayName(__34100_displayName)]
        [IsReadOnly]
        public virtual byte __34100 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__34100));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__34100));
            }
        }

        public const string Frostcraft_Gunlance_Level_Multiplier_0_15__displayName = "Frostcraft: (Gunlance) Level Multiplier (0-15%)";
        public const int Frostcraft_Gunlance_Level_Multiplier_0_15__sortIndex = 34150;
        [SortOrder(Frostcraft_Gunlance_Level_Multiplier_0_15__sortIndex)]
        [DisplayName(Frostcraft_Gunlance_Level_Multiplier_0_15__displayName)]
        public virtual float Frostcraft_Gunlance_Level_Multiplier_0_15_ {
            get => GetData<float>(1477);
            set {
                if (GetData<float>(1477) == value) return;
                SetData(1477, value, nameof(Frostcraft_Gunlance_Level_Multiplier_0_15_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Gunlance_Level_Multiplier_0_15_));
            }
        }

        public const string Frostcraft_Gunlance_Level_Multiplier_16_45__displayName = "Frostcraft: (Gunlance) Level Multiplier (16-45%)";
        public const int Frostcraft_Gunlance_Level_Multiplier_16_45__sortIndex = 34200;
        [SortOrder(Frostcraft_Gunlance_Level_Multiplier_16_45__sortIndex)]
        [DisplayName(Frostcraft_Gunlance_Level_Multiplier_16_45__displayName)]
        public virtual float Frostcraft_Gunlance_Level_Multiplier_16_45_ {
            get => GetData<float>(1481);
            set {
                if (GetData<float>(1481) == value) return;
                SetData(1481, value, nameof(Frostcraft_Gunlance_Level_Multiplier_16_45_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Gunlance_Level_Multiplier_16_45_));
            }
        }

        public const string Frostcraft_Gunlance_Level_Multiplier_46_80__displayName = "Frostcraft: (Gunlance) Level Multiplier (46-80%)";
        public const int Frostcraft_Gunlance_Level_Multiplier_46_80__sortIndex = 34250;
        [SortOrder(Frostcraft_Gunlance_Level_Multiplier_46_80__sortIndex)]
        [DisplayName(Frostcraft_Gunlance_Level_Multiplier_46_80__displayName)]
        public virtual float Frostcraft_Gunlance_Level_Multiplier_46_80_ {
            get => GetData<float>(1485);
            set {
                if (GetData<float>(1485) == value) return;
                SetData(1485, value, nameof(Frostcraft_Gunlance_Level_Multiplier_46_80_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Gunlance_Level_Multiplier_46_80_));
            }
        }

        public const string Frostcraft_Gunlance_Level_Multiplier_81_100__displayName = "Frostcraft: (Gunlance) Level Multiplier (81-100%)";
        public const int Frostcraft_Gunlance_Level_Multiplier_81_100__sortIndex = 34300;
        [SortOrder(Frostcraft_Gunlance_Level_Multiplier_81_100__sortIndex)]
        [DisplayName(Frostcraft_Gunlance_Level_Multiplier_81_100__displayName)]
        public virtual float Frostcraft_Gunlance_Level_Multiplier_81_100_ {
            get => GetData<float>(1489);
            set {
                if (GetData<float>(1489) == value) return;
                SetData(1489, value, nameof(Frostcraft_Gunlance_Level_Multiplier_81_100_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Gunlance_Level_Multiplier_81_100_));
            }
        }

        public const string Frostcraft_Gunlance_Recovery_Speed_Unsheathed_displayName = "Frostcraft: (Gunlance) Recovery Speed: Unsheathed";
        public const int Frostcraft_Gunlance_Recovery_Speed_Unsheathed_sortIndex = 34350;
        [SortOrder(Frostcraft_Gunlance_Recovery_Speed_Unsheathed_sortIndex)]
        [DisplayName(Frostcraft_Gunlance_Recovery_Speed_Unsheathed_displayName)]
        public virtual float Frostcraft_Gunlance_Recovery_Speed_Unsheathed {
            get => GetData<float>(1493);
            set {
                if (GetData<float>(1493) == value) return;
                SetData(1493, value, nameof(Frostcraft_Gunlance_Recovery_Speed_Unsheathed));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Gunlance_Recovery_Speed_Unsheathed));
            }
        }

        public const string Frostcraft_Gunlance_Recovery_Speed_Sheathed_displayName = "Frostcraft: (Gunlance) Recovery Speed: Sheathed";
        public const int Frostcraft_Gunlance_Recovery_Speed_Sheathed_sortIndex = 34400;
        [SortOrder(Frostcraft_Gunlance_Recovery_Speed_Sheathed_sortIndex)]
        [DisplayName(Frostcraft_Gunlance_Recovery_Speed_Sheathed_displayName)]
        public virtual float Frostcraft_Gunlance_Recovery_Speed_Sheathed {
            get => GetData<float>(1497);
            set {
                if (GetData<float>(1497) == value) return;
                SetData(1497, value, nameof(Frostcraft_Gunlance_Recovery_Speed_Sheathed));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Gunlance_Recovery_Speed_Sheathed));
            }
        }

        public const string Frostcraft_Gunlance_Consumption_per_Hit_displayName = "Frostcraft: (Gunlance) Consumption per Hit";
        public const int Frostcraft_Gunlance_Consumption_per_Hit_sortIndex = 34450;
        [SortOrder(Frostcraft_Gunlance_Consumption_per_Hit_sortIndex)]
        [DisplayName(Frostcraft_Gunlance_Consumption_per_Hit_displayName)]
        public virtual float Frostcraft_Gunlance_Consumption_per_Hit {
            get => GetData<float>(1501);
            set {
                if (GetData<float>(1501) == value) return;
                SetData(1501, value, nameof(Frostcraft_Gunlance_Consumption_per_Hit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Gunlance_Consumption_per_Hit));
            }
        }

        public const string __34500_displayName = "-------------------------------------------------------------------------------------------";
        public const int __34500_sortIndex = 34500;
        [SortOrder(__34500_sortIndex)]
        [DisplayName(__34500_displayName)]
        [IsReadOnly]
        public virtual byte __34500 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__34500));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__34500));
            }
        }

        public const string Frostcraft_Switch_Axe_Level_Multiplier_0_15__displayName = "Frostcraft: (Switch Axe) Level Multiplier (0-15%)";
        public const int Frostcraft_Switch_Axe_Level_Multiplier_0_15__sortIndex = 34550;
        [SortOrder(Frostcraft_Switch_Axe_Level_Multiplier_0_15__sortIndex)]
        [DisplayName(Frostcraft_Switch_Axe_Level_Multiplier_0_15__displayName)]
        public virtual float Frostcraft_Switch_Axe_Level_Multiplier_0_15_ {
            get => GetData<float>(1505);
            set {
                if (GetData<float>(1505) == value) return;
                SetData(1505, value, nameof(Frostcraft_Switch_Axe_Level_Multiplier_0_15_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Switch_Axe_Level_Multiplier_0_15_));
            }
        }

        public const string Frostcraft_Switch_Axe_Level_Multiplier_16_45__displayName = "Frostcraft: (Switch Axe) Level Multiplier (16-45%)";
        public const int Frostcraft_Switch_Axe_Level_Multiplier_16_45__sortIndex = 34600;
        [SortOrder(Frostcraft_Switch_Axe_Level_Multiplier_16_45__sortIndex)]
        [DisplayName(Frostcraft_Switch_Axe_Level_Multiplier_16_45__displayName)]
        public virtual float Frostcraft_Switch_Axe_Level_Multiplier_16_45_ {
            get => GetData<float>(1509);
            set {
                if (GetData<float>(1509) == value) return;
                SetData(1509, value, nameof(Frostcraft_Switch_Axe_Level_Multiplier_16_45_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Switch_Axe_Level_Multiplier_16_45_));
            }
        }

        public const string Frostcraft_Switch_Axe_Level_Multiplier_46_80__displayName = "Frostcraft: (Switch Axe) Level Multiplier (46-80%)";
        public const int Frostcraft_Switch_Axe_Level_Multiplier_46_80__sortIndex = 34650;
        [SortOrder(Frostcraft_Switch_Axe_Level_Multiplier_46_80__sortIndex)]
        [DisplayName(Frostcraft_Switch_Axe_Level_Multiplier_46_80__displayName)]
        public virtual float Frostcraft_Switch_Axe_Level_Multiplier_46_80_ {
            get => GetData<float>(1513);
            set {
                if (GetData<float>(1513) == value) return;
                SetData(1513, value, nameof(Frostcraft_Switch_Axe_Level_Multiplier_46_80_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Switch_Axe_Level_Multiplier_46_80_));
            }
        }

        public const string Frostcraft_Switch_Axe_Level_Multiplier_81_100__displayName = "Frostcraft: (Switch Axe) Level Multiplier (81-100%)";
        public const int Frostcraft_Switch_Axe_Level_Multiplier_81_100__sortIndex = 34700;
        [SortOrder(Frostcraft_Switch_Axe_Level_Multiplier_81_100__sortIndex)]
        [DisplayName(Frostcraft_Switch_Axe_Level_Multiplier_81_100__displayName)]
        public virtual float Frostcraft_Switch_Axe_Level_Multiplier_81_100_ {
            get => GetData<float>(1517);
            set {
                if (GetData<float>(1517) == value) return;
                SetData(1517, value, nameof(Frostcraft_Switch_Axe_Level_Multiplier_81_100_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Switch_Axe_Level_Multiplier_81_100_));
            }
        }

        public const string Frostcraft_Switch_Axe_Recovery_Speed_Unsheathed_displayName = "Frostcraft: (Switch Axe) Recovery Speed: Unsheathed";
        public const int Frostcraft_Switch_Axe_Recovery_Speed_Unsheathed_sortIndex = 34750;
        [SortOrder(Frostcraft_Switch_Axe_Recovery_Speed_Unsheathed_sortIndex)]
        [DisplayName(Frostcraft_Switch_Axe_Recovery_Speed_Unsheathed_displayName)]
        public virtual float Frostcraft_Switch_Axe_Recovery_Speed_Unsheathed {
            get => GetData<float>(1521);
            set {
                if (GetData<float>(1521) == value) return;
                SetData(1521, value, nameof(Frostcraft_Switch_Axe_Recovery_Speed_Unsheathed));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Switch_Axe_Recovery_Speed_Unsheathed));
            }
        }

        public const string Frostcraft_Switch_Axe_Recovery_Speed_Sheathed_displayName = "Frostcraft: (Switch Axe) Recovery Speed: Sheathed";
        public const int Frostcraft_Switch_Axe_Recovery_Speed_Sheathed_sortIndex = 34800;
        [SortOrder(Frostcraft_Switch_Axe_Recovery_Speed_Sheathed_sortIndex)]
        [DisplayName(Frostcraft_Switch_Axe_Recovery_Speed_Sheathed_displayName)]
        public virtual float Frostcraft_Switch_Axe_Recovery_Speed_Sheathed {
            get => GetData<float>(1525);
            set {
                if (GetData<float>(1525) == value) return;
                SetData(1525, value, nameof(Frostcraft_Switch_Axe_Recovery_Speed_Sheathed));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Switch_Axe_Recovery_Speed_Sheathed));
            }
        }

        public const string Frostcraft_Switch_Axe_Consumption_per_Hit_displayName = "Frostcraft: (Switch Axe) Consumption per Hit";
        public const int Frostcraft_Switch_Axe_Consumption_per_Hit_sortIndex = 34850;
        [SortOrder(Frostcraft_Switch_Axe_Consumption_per_Hit_sortIndex)]
        [DisplayName(Frostcraft_Switch_Axe_Consumption_per_Hit_displayName)]
        public virtual float Frostcraft_Switch_Axe_Consumption_per_Hit {
            get => GetData<float>(1529);
            set {
                if (GetData<float>(1529) == value) return;
                SetData(1529, value, nameof(Frostcraft_Switch_Axe_Consumption_per_Hit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Switch_Axe_Consumption_per_Hit));
            }
        }

        public const string __34900_displayName = "-------------------------------------------------------------------------------------------";
        public const int __34900_sortIndex = 34900;
        [SortOrder(__34900_sortIndex)]
        [DisplayName(__34900_displayName)]
        [IsReadOnly]
        public virtual byte __34900 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__34900));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__34900));
            }
        }

        public const string Frostcraft_Charge_Blade_Level_Multiplier_0_15__displayName = "Frostcraft: (Charge Blade) Level Multiplier (0-15%)";
        public const int Frostcraft_Charge_Blade_Level_Multiplier_0_15__sortIndex = 34950;
        [SortOrder(Frostcraft_Charge_Blade_Level_Multiplier_0_15__sortIndex)]
        [DisplayName(Frostcraft_Charge_Blade_Level_Multiplier_0_15__displayName)]
        public virtual float Frostcraft_Charge_Blade_Level_Multiplier_0_15_ {
            get => GetData<float>(1533);
            set {
                if (GetData<float>(1533) == value) return;
                SetData(1533, value, nameof(Frostcraft_Charge_Blade_Level_Multiplier_0_15_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Charge_Blade_Level_Multiplier_0_15_));
            }
        }

        public const string Frostcraft_Charge_Blade_Level_Multiplier_16_45__displayName = "Frostcraft: (Charge Blade) Level Multiplier (16-45%)";
        public const int Frostcraft_Charge_Blade_Level_Multiplier_16_45__sortIndex = 35000;
        [SortOrder(Frostcraft_Charge_Blade_Level_Multiplier_16_45__sortIndex)]
        [DisplayName(Frostcraft_Charge_Blade_Level_Multiplier_16_45__displayName)]
        public virtual float Frostcraft_Charge_Blade_Level_Multiplier_16_45_ {
            get => GetData<float>(1537);
            set {
                if (GetData<float>(1537) == value) return;
                SetData(1537, value, nameof(Frostcraft_Charge_Blade_Level_Multiplier_16_45_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Charge_Blade_Level_Multiplier_16_45_));
            }
        }

        public const string Frostcraft_Charge_Blade_Level_Multiplier_46_80__displayName = "Frostcraft: (Charge Blade) Level Multiplier (46-80%)";
        public const int Frostcraft_Charge_Blade_Level_Multiplier_46_80__sortIndex = 35050;
        [SortOrder(Frostcraft_Charge_Blade_Level_Multiplier_46_80__sortIndex)]
        [DisplayName(Frostcraft_Charge_Blade_Level_Multiplier_46_80__displayName)]
        public virtual float Frostcraft_Charge_Blade_Level_Multiplier_46_80_ {
            get => GetData<float>(1541);
            set {
                if (GetData<float>(1541) == value) return;
                SetData(1541, value, nameof(Frostcraft_Charge_Blade_Level_Multiplier_46_80_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Charge_Blade_Level_Multiplier_46_80_));
            }
        }

        public const string Frostcraft_Charge_Blade_Level_Multiplier_81_100__displayName = "Frostcraft: (Charge Blade) Level Multiplier (81-100%)";
        public const int Frostcraft_Charge_Blade_Level_Multiplier_81_100__sortIndex = 35100;
        [SortOrder(Frostcraft_Charge_Blade_Level_Multiplier_81_100__sortIndex)]
        [DisplayName(Frostcraft_Charge_Blade_Level_Multiplier_81_100__displayName)]
        public virtual float Frostcraft_Charge_Blade_Level_Multiplier_81_100_ {
            get => GetData<float>(1545);
            set {
                if (GetData<float>(1545) == value) return;
                SetData(1545, value, nameof(Frostcraft_Charge_Blade_Level_Multiplier_81_100_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Charge_Blade_Level_Multiplier_81_100_));
            }
        }

        public const string Frostcraft_Charge_Blade_Recovery_Speed_Unsheathed_displayName = "Frostcraft: (Charge Blade) Recovery Speed: Unsheathed";
        public const int Frostcraft_Charge_Blade_Recovery_Speed_Unsheathed_sortIndex = 35150;
        [SortOrder(Frostcraft_Charge_Blade_Recovery_Speed_Unsheathed_sortIndex)]
        [DisplayName(Frostcraft_Charge_Blade_Recovery_Speed_Unsheathed_displayName)]
        public virtual float Frostcraft_Charge_Blade_Recovery_Speed_Unsheathed {
            get => GetData<float>(1549);
            set {
                if (GetData<float>(1549) == value) return;
                SetData(1549, value, nameof(Frostcraft_Charge_Blade_Recovery_Speed_Unsheathed));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Charge_Blade_Recovery_Speed_Unsheathed));
            }
        }

        public const string Frostcraft_Charge_Blade_Recovery_Speed_Sheathed_displayName = "Frostcraft: (Charge Blade) Recovery Speed: Sheathed";
        public const int Frostcraft_Charge_Blade_Recovery_Speed_Sheathed_sortIndex = 35200;
        [SortOrder(Frostcraft_Charge_Blade_Recovery_Speed_Sheathed_sortIndex)]
        [DisplayName(Frostcraft_Charge_Blade_Recovery_Speed_Sheathed_displayName)]
        public virtual float Frostcraft_Charge_Blade_Recovery_Speed_Sheathed {
            get => GetData<float>(1553);
            set {
                if (GetData<float>(1553) == value) return;
                SetData(1553, value, nameof(Frostcraft_Charge_Blade_Recovery_Speed_Sheathed));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Charge_Blade_Recovery_Speed_Sheathed));
            }
        }

        public const string Frostcraft_Charge_Blade_Consumption_per_Hit_displayName = "Frostcraft: (Charge Blade) Consumption per Hit";
        public const int Frostcraft_Charge_Blade_Consumption_per_Hit_sortIndex = 35250;
        [SortOrder(Frostcraft_Charge_Blade_Consumption_per_Hit_sortIndex)]
        [DisplayName(Frostcraft_Charge_Blade_Consumption_per_Hit_displayName)]
        public virtual float Frostcraft_Charge_Blade_Consumption_per_Hit {
            get => GetData<float>(1557);
            set {
                if (GetData<float>(1557) == value) return;
                SetData(1557, value, nameof(Frostcraft_Charge_Blade_Consumption_per_Hit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Charge_Blade_Consumption_per_Hit));
            }
        }

        public const string __35300_displayName = "-------------------------------------------------------------------------------------------";
        public const int __35300_sortIndex = 35300;
        [SortOrder(__35300_sortIndex)]
        [DisplayName(__35300_displayName)]
        [IsReadOnly]
        public virtual byte __35300 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__35300));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__35300));
            }
        }

        public const string Frostcraft_Insect_Glaive_Level_Multiplier_0_15__displayName = "Frostcraft: (Insect Glaive) Level Multiplier (0-15%)";
        public const int Frostcraft_Insect_Glaive_Level_Multiplier_0_15__sortIndex = 35350;
        [SortOrder(Frostcraft_Insect_Glaive_Level_Multiplier_0_15__sortIndex)]
        [DisplayName(Frostcraft_Insect_Glaive_Level_Multiplier_0_15__displayName)]
        public virtual float Frostcraft_Insect_Glaive_Level_Multiplier_0_15_ {
            get => GetData<float>(1561);
            set {
                if (GetData<float>(1561) == value) return;
                SetData(1561, value, nameof(Frostcraft_Insect_Glaive_Level_Multiplier_0_15_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Insect_Glaive_Level_Multiplier_0_15_));
            }
        }

        public const string Frostcraft_Insect_Glaive_Level_Multiplier_16_45__displayName = "Frostcraft: (Insect Glaive) Level Multiplier (16-45%)";
        public const int Frostcraft_Insect_Glaive_Level_Multiplier_16_45__sortIndex = 35400;
        [SortOrder(Frostcraft_Insect_Glaive_Level_Multiplier_16_45__sortIndex)]
        [DisplayName(Frostcraft_Insect_Glaive_Level_Multiplier_16_45__displayName)]
        public virtual float Frostcraft_Insect_Glaive_Level_Multiplier_16_45_ {
            get => GetData<float>(1565);
            set {
                if (GetData<float>(1565) == value) return;
                SetData(1565, value, nameof(Frostcraft_Insect_Glaive_Level_Multiplier_16_45_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Insect_Glaive_Level_Multiplier_16_45_));
            }
        }

        public const string Frostcraft_Insect_Glaive_Level_Multiplier_46_80__displayName = "Frostcraft: (Insect Glaive) Level Multiplier (46-80%)";
        public const int Frostcraft_Insect_Glaive_Level_Multiplier_46_80__sortIndex = 35450;
        [SortOrder(Frostcraft_Insect_Glaive_Level_Multiplier_46_80__sortIndex)]
        [DisplayName(Frostcraft_Insect_Glaive_Level_Multiplier_46_80__displayName)]
        public virtual float Frostcraft_Insect_Glaive_Level_Multiplier_46_80_ {
            get => GetData<float>(1569);
            set {
                if (GetData<float>(1569) == value) return;
                SetData(1569, value, nameof(Frostcraft_Insect_Glaive_Level_Multiplier_46_80_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Insect_Glaive_Level_Multiplier_46_80_));
            }
        }

        public const string Frostcraft_Insect_Glaive_Level_Multiplier_81_100__displayName = "Frostcraft: (Insect Glaive) Level Multiplier (81-100%)";
        public const int Frostcraft_Insect_Glaive_Level_Multiplier_81_100__sortIndex = 35500;
        [SortOrder(Frostcraft_Insect_Glaive_Level_Multiplier_81_100__sortIndex)]
        [DisplayName(Frostcraft_Insect_Glaive_Level_Multiplier_81_100__displayName)]
        public virtual float Frostcraft_Insect_Glaive_Level_Multiplier_81_100_ {
            get => GetData<float>(1573);
            set {
                if (GetData<float>(1573) == value) return;
                SetData(1573, value, nameof(Frostcraft_Insect_Glaive_Level_Multiplier_81_100_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Insect_Glaive_Level_Multiplier_81_100_));
            }
        }

        public const string Frostcraft_Insect_Glaive_Recovery_Speed_Unsheathed_displayName = "Frostcraft: (Insect Glaive) Recovery Speed: Unsheathed";
        public const int Frostcraft_Insect_Glaive_Recovery_Speed_Unsheathed_sortIndex = 35550;
        [SortOrder(Frostcraft_Insect_Glaive_Recovery_Speed_Unsheathed_sortIndex)]
        [DisplayName(Frostcraft_Insect_Glaive_Recovery_Speed_Unsheathed_displayName)]
        public virtual float Frostcraft_Insect_Glaive_Recovery_Speed_Unsheathed {
            get => GetData<float>(1577);
            set {
                if (GetData<float>(1577) == value) return;
                SetData(1577, value, nameof(Frostcraft_Insect_Glaive_Recovery_Speed_Unsheathed));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Insect_Glaive_Recovery_Speed_Unsheathed));
            }
        }

        public const string Frostcraft_Insect_Glaive_Recovery_Speed_Sheathed_displayName = "Frostcraft: (Insect Glaive) Recovery Speed: Sheathed";
        public const int Frostcraft_Insect_Glaive_Recovery_Speed_Sheathed_sortIndex = 35600;
        [SortOrder(Frostcraft_Insect_Glaive_Recovery_Speed_Sheathed_sortIndex)]
        [DisplayName(Frostcraft_Insect_Glaive_Recovery_Speed_Sheathed_displayName)]
        public virtual float Frostcraft_Insect_Glaive_Recovery_Speed_Sheathed {
            get => GetData<float>(1581);
            set {
                if (GetData<float>(1581) == value) return;
                SetData(1581, value, nameof(Frostcraft_Insect_Glaive_Recovery_Speed_Sheathed));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Insect_Glaive_Recovery_Speed_Sheathed));
            }
        }

        public const string Frostcraft_Insect_Glaive_Consumption_per_Hit_displayName = "Frostcraft: (Insect Glaive) Consumption per Hit";
        public const int Frostcraft_Insect_Glaive_Consumption_per_Hit_sortIndex = 35650;
        [SortOrder(Frostcraft_Insect_Glaive_Consumption_per_Hit_sortIndex)]
        [DisplayName(Frostcraft_Insect_Glaive_Consumption_per_Hit_displayName)]
        public virtual float Frostcraft_Insect_Glaive_Consumption_per_Hit {
            get => GetData<float>(1585);
            set {
                if (GetData<float>(1585) == value) return;
                SetData(1585, value, nameof(Frostcraft_Insect_Glaive_Consumption_per_Hit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Insect_Glaive_Consumption_per_Hit));
            }
        }

        public const string __35700_displayName = "-------------------------------------------------------------------------------------------";
        public const int __35700_sortIndex = 35700;
        [SortOrder(__35700_sortIndex)]
        [DisplayName(__35700_displayName)]
        [IsReadOnly]
        public virtual byte __35700 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__35700));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__35700));
            }
        }

        public const string Frostcraft_Bow_Level_Multiplier_0_15__displayName = "Frostcraft: (Bow) Level Multiplier (0-15%)";
        public const int Frostcraft_Bow_Level_Multiplier_0_15__sortIndex = 35750;
        [SortOrder(Frostcraft_Bow_Level_Multiplier_0_15__sortIndex)]
        [DisplayName(Frostcraft_Bow_Level_Multiplier_0_15__displayName)]
        public virtual float Frostcraft_Bow_Level_Multiplier_0_15_ {
            get => GetData<float>(1589);
            set {
                if (GetData<float>(1589) == value) return;
                SetData(1589, value, nameof(Frostcraft_Bow_Level_Multiplier_0_15_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Bow_Level_Multiplier_0_15_));
            }
        }

        public const string Frostcraft_Bow_Level_Multiplier_16_45__displayName = "Frostcraft: (Bow) Level Multiplier (16-45%)";
        public const int Frostcraft_Bow_Level_Multiplier_16_45__sortIndex = 35800;
        [SortOrder(Frostcraft_Bow_Level_Multiplier_16_45__sortIndex)]
        [DisplayName(Frostcraft_Bow_Level_Multiplier_16_45__displayName)]
        public virtual float Frostcraft_Bow_Level_Multiplier_16_45_ {
            get => GetData<float>(1593);
            set {
                if (GetData<float>(1593) == value) return;
                SetData(1593, value, nameof(Frostcraft_Bow_Level_Multiplier_16_45_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Bow_Level_Multiplier_16_45_));
            }
        }

        public const string Frostcraft_Bow_Level_Multiplier_46_80__displayName = "Frostcraft: (Bow) Level Multiplier (46-80%)";
        public const int Frostcraft_Bow_Level_Multiplier_46_80__sortIndex = 35850;
        [SortOrder(Frostcraft_Bow_Level_Multiplier_46_80__sortIndex)]
        [DisplayName(Frostcraft_Bow_Level_Multiplier_46_80__displayName)]
        public virtual float Frostcraft_Bow_Level_Multiplier_46_80_ {
            get => GetData<float>(1597);
            set {
                if (GetData<float>(1597) == value) return;
                SetData(1597, value, nameof(Frostcraft_Bow_Level_Multiplier_46_80_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Bow_Level_Multiplier_46_80_));
            }
        }

        public const string Frostcraft_Bow_Level_Multiplier_81_100__displayName = "Frostcraft: (Bow) Level Multiplier (81-100%)";
        public const int Frostcraft_Bow_Level_Multiplier_81_100__sortIndex = 35900;
        [SortOrder(Frostcraft_Bow_Level_Multiplier_81_100__sortIndex)]
        [DisplayName(Frostcraft_Bow_Level_Multiplier_81_100__displayName)]
        public virtual float Frostcraft_Bow_Level_Multiplier_81_100_ {
            get => GetData<float>(1601);
            set {
                if (GetData<float>(1601) == value) return;
                SetData(1601, value, nameof(Frostcraft_Bow_Level_Multiplier_81_100_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Bow_Level_Multiplier_81_100_));
            }
        }

        public const string Frostcraft_Bow_Recovery_Speed_Unsheathed_displayName = "Frostcraft: (Bow) Recovery Speed: Unsheathed";
        public const int Frostcraft_Bow_Recovery_Speed_Unsheathed_sortIndex = 35950;
        [SortOrder(Frostcraft_Bow_Recovery_Speed_Unsheathed_sortIndex)]
        [DisplayName(Frostcraft_Bow_Recovery_Speed_Unsheathed_displayName)]
        public virtual float Frostcraft_Bow_Recovery_Speed_Unsheathed {
            get => GetData<float>(1605);
            set {
                if (GetData<float>(1605) == value) return;
                SetData(1605, value, nameof(Frostcraft_Bow_Recovery_Speed_Unsheathed));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Bow_Recovery_Speed_Unsheathed));
            }
        }

        public const string Frostcraft_Bow_Recovery_Speed_Sheathed_displayName = "Frostcraft: (Bow) Recovery Speed: Sheathed";
        public const int Frostcraft_Bow_Recovery_Speed_Sheathed_sortIndex = 36000;
        [SortOrder(Frostcraft_Bow_Recovery_Speed_Sheathed_sortIndex)]
        [DisplayName(Frostcraft_Bow_Recovery_Speed_Sheathed_displayName)]
        public virtual float Frostcraft_Bow_Recovery_Speed_Sheathed {
            get => GetData<float>(1609);
            set {
                if (GetData<float>(1609) == value) return;
                SetData(1609, value, nameof(Frostcraft_Bow_Recovery_Speed_Sheathed));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Bow_Recovery_Speed_Sheathed));
            }
        }

        public const string Frostcraft_Bow_Consumption_per_Hit_displayName = "Frostcraft: (Bow) Consumption per Hit";
        public const int Frostcraft_Bow_Consumption_per_Hit_sortIndex = 36050;
        [SortOrder(Frostcraft_Bow_Consumption_per_Hit_sortIndex)]
        [DisplayName(Frostcraft_Bow_Consumption_per_Hit_displayName)]
        public virtual float Frostcraft_Bow_Consumption_per_Hit {
            get => GetData<float>(1613);
            set {
                if (GetData<float>(1613) == value) return;
                SetData(1613, value, nameof(Frostcraft_Bow_Consumption_per_Hit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Bow_Consumption_per_Hit));
            }
        }

        public const string __36100_displayName = "-------------------------------------------------------------------------------------------";
        public const int __36100_sortIndex = 36100;
        [SortOrder(__36100_sortIndex)]
        [DisplayName(__36100_displayName)]
        [IsReadOnly]
        public virtual byte __36100 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__36100));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__36100));
            }
        }

        public const string Frostcraft_HBG_Level_Multiplier_0_15__displayName = "Frostcraft: (HBG) Level Multiplier (0-15%)";
        public const int Frostcraft_HBG_Level_Multiplier_0_15__sortIndex = 36150;
        [SortOrder(Frostcraft_HBG_Level_Multiplier_0_15__sortIndex)]
        [DisplayName(Frostcraft_HBG_Level_Multiplier_0_15__displayName)]
        public virtual float Frostcraft_HBG_Level_Multiplier_0_15_ {
            get => GetData<float>(1617);
            set {
                if (GetData<float>(1617) == value) return;
                SetData(1617, value, nameof(Frostcraft_HBG_Level_Multiplier_0_15_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_HBG_Level_Multiplier_0_15_));
            }
        }

        public const string Frostcraft_HBG_Level_Multiplier_16_45__displayName = "Frostcraft: (HBG) Level Multiplier (16-45%)";
        public const int Frostcraft_HBG_Level_Multiplier_16_45__sortIndex = 36200;
        [SortOrder(Frostcraft_HBG_Level_Multiplier_16_45__sortIndex)]
        [DisplayName(Frostcraft_HBG_Level_Multiplier_16_45__displayName)]
        public virtual float Frostcraft_HBG_Level_Multiplier_16_45_ {
            get => GetData<float>(1621);
            set {
                if (GetData<float>(1621) == value) return;
                SetData(1621, value, nameof(Frostcraft_HBG_Level_Multiplier_16_45_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_HBG_Level_Multiplier_16_45_));
            }
        }

        public const string Frostcraft_HBG_Level_Multiplier_46_80__displayName = "Frostcraft: (HBG) Level Multiplier (46-80%)";
        public const int Frostcraft_HBG_Level_Multiplier_46_80__sortIndex = 36250;
        [SortOrder(Frostcraft_HBG_Level_Multiplier_46_80__sortIndex)]
        [DisplayName(Frostcraft_HBG_Level_Multiplier_46_80__displayName)]
        public virtual float Frostcraft_HBG_Level_Multiplier_46_80_ {
            get => GetData<float>(1625);
            set {
                if (GetData<float>(1625) == value) return;
                SetData(1625, value, nameof(Frostcraft_HBG_Level_Multiplier_46_80_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_HBG_Level_Multiplier_46_80_));
            }
        }

        public const string Frostcraft_HBG_Level_Multiplier_81_100__displayName = "Frostcraft: (HBG) Level Multiplier (81-100%)";
        public const int Frostcraft_HBG_Level_Multiplier_81_100__sortIndex = 36300;
        [SortOrder(Frostcraft_HBG_Level_Multiplier_81_100__sortIndex)]
        [DisplayName(Frostcraft_HBG_Level_Multiplier_81_100__displayName)]
        public virtual float Frostcraft_HBG_Level_Multiplier_81_100_ {
            get => GetData<float>(1629);
            set {
                if (GetData<float>(1629) == value) return;
                SetData(1629, value, nameof(Frostcraft_HBG_Level_Multiplier_81_100_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_HBG_Level_Multiplier_81_100_));
            }
        }

        public const string Frostcraft_HBG_Recovery_Speed_Unsheathed_displayName = "Frostcraft: (HBG) Recovery Speed: Unsheathed";
        public const int Frostcraft_HBG_Recovery_Speed_Unsheathed_sortIndex = 36350;
        [SortOrder(Frostcraft_HBG_Recovery_Speed_Unsheathed_sortIndex)]
        [DisplayName(Frostcraft_HBG_Recovery_Speed_Unsheathed_displayName)]
        public virtual float Frostcraft_HBG_Recovery_Speed_Unsheathed {
            get => GetData<float>(1633);
            set {
                if (GetData<float>(1633) == value) return;
                SetData(1633, value, nameof(Frostcraft_HBG_Recovery_Speed_Unsheathed));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_HBG_Recovery_Speed_Unsheathed));
            }
        }

        public const string Frostcraft_HBG_Recovery_Speed_Sheathed_displayName = "Frostcraft: (HBG) Recovery Speed: Sheathed";
        public const int Frostcraft_HBG_Recovery_Speed_Sheathed_sortIndex = 36400;
        [SortOrder(Frostcraft_HBG_Recovery_Speed_Sheathed_sortIndex)]
        [DisplayName(Frostcraft_HBG_Recovery_Speed_Sheathed_displayName)]
        public virtual float Frostcraft_HBG_Recovery_Speed_Sheathed {
            get => GetData<float>(1637);
            set {
                if (GetData<float>(1637) == value) return;
                SetData(1637, value, nameof(Frostcraft_HBG_Recovery_Speed_Sheathed));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_HBG_Recovery_Speed_Sheathed));
            }
        }

        public const string Frostcraft_HBG_Consumption_per_Hit_displayName = "Frostcraft: (HBG) Consumption per Hit";
        public const int Frostcraft_HBG_Consumption_per_Hit_sortIndex = 36450;
        [SortOrder(Frostcraft_HBG_Consumption_per_Hit_sortIndex)]
        [DisplayName(Frostcraft_HBG_Consumption_per_Hit_displayName)]
        public virtual float Frostcraft_HBG_Consumption_per_Hit {
            get => GetData<float>(1641);
            set {
                if (GetData<float>(1641) == value) return;
                SetData(1641, value, nameof(Frostcraft_HBG_Consumption_per_Hit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_HBG_Consumption_per_Hit));
            }
        }

        public const string __36500_displayName = "-------------------------------------------------------------------------------------------";
        public const int __36500_sortIndex = 36500;
        [SortOrder(__36500_sortIndex)]
        [DisplayName(__36500_displayName)]
        [IsReadOnly]
        public virtual byte __36500 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__36500));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__36500));
            }
        }

        public const string Frostcraft_LBG_Level_Multiplier_0_15__displayName = "Frostcraft: (LBG) Level Multiplier (0-15%)";
        public const int Frostcraft_LBG_Level_Multiplier_0_15__sortIndex = 36550;
        [SortOrder(Frostcraft_LBG_Level_Multiplier_0_15__sortIndex)]
        [DisplayName(Frostcraft_LBG_Level_Multiplier_0_15__displayName)]
        public virtual float Frostcraft_LBG_Level_Multiplier_0_15_ {
            get => GetData<float>(1645);
            set {
                if (GetData<float>(1645) == value) return;
                SetData(1645, value, nameof(Frostcraft_LBG_Level_Multiplier_0_15_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_LBG_Level_Multiplier_0_15_));
            }
        }

        public const string Frostcraft_LBG_Level_Multiplier_16_45__displayName = "Frostcraft: (LBG) Level Multiplier (16-45%)";
        public const int Frostcraft_LBG_Level_Multiplier_16_45__sortIndex = 36600;
        [SortOrder(Frostcraft_LBG_Level_Multiplier_16_45__sortIndex)]
        [DisplayName(Frostcraft_LBG_Level_Multiplier_16_45__displayName)]
        public virtual float Frostcraft_LBG_Level_Multiplier_16_45_ {
            get => GetData<float>(1649);
            set {
                if (GetData<float>(1649) == value) return;
                SetData(1649, value, nameof(Frostcraft_LBG_Level_Multiplier_16_45_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_LBG_Level_Multiplier_16_45_));
            }
        }

        public const string Frostcraft_LBG_Level_Multiplier_46_80__displayName = "Frostcraft: (LBG) Level Multiplier (46-80%)";
        public const int Frostcraft_LBG_Level_Multiplier_46_80__sortIndex = 36650;
        [SortOrder(Frostcraft_LBG_Level_Multiplier_46_80__sortIndex)]
        [DisplayName(Frostcraft_LBG_Level_Multiplier_46_80__displayName)]
        public virtual float Frostcraft_LBG_Level_Multiplier_46_80_ {
            get => GetData<float>(1653);
            set {
                if (GetData<float>(1653) == value) return;
                SetData(1653, value, nameof(Frostcraft_LBG_Level_Multiplier_46_80_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_LBG_Level_Multiplier_46_80_));
            }
        }

        public const string Frostcraft_LBG_Level_Multiplier_81_100__displayName = "Frostcraft: (LBG) Level Multiplier (81-100%)";
        public const int Frostcraft_LBG_Level_Multiplier_81_100__sortIndex = 36700;
        [SortOrder(Frostcraft_LBG_Level_Multiplier_81_100__sortIndex)]
        [DisplayName(Frostcraft_LBG_Level_Multiplier_81_100__displayName)]
        public virtual float Frostcraft_LBG_Level_Multiplier_81_100_ {
            get => GetData<float>(1657);
            set {
                if (GetData<float>(1657) == value) return;
                SetData(1657, value, nameof(Frostcraft_LBG_Level_Multiplier_81_100_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_LBG_Level_Multiplier_81_100_));
            }
        }

        public const string Frostcraft_LBG_Recovery_Speed_Unsheathed_displayName = "Frostcraft: (LBG) Recovery Speed: Unsheathed";
        public const int Frostcraft_LBG_Recovery_Speed_Unsheathed_sortIndex = 36750;
        [SortOrder(Frostcraft_LBG_Recovery_Speed_Unsheathed_sortIndex)]
        [DisplayName(Frostcraft_LBG_Recovery_Speed_Unsheathed_displayName)]
        public virtual float Frostcraft_LBG_Recovery_Speed_Unsheathed {
            get => GetData<float>(1661);
            set {
                if (GetData<float>(1661) == value) return;
                SetData(1661, value, nameof(Frostcraft_LBG_Recovery_Speed_Unsheathed));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_LBG_Recovery_Speed_Unsheathed));
            }
        }

        public const string Frostcraft_LBG_Recovery_Speed_Sheathed_displayName = "Frostcraft: (LBG) Recovery Speed: Sheathed";
        public const int Frostcraft_LBG_Recovery_Speed_Sheathed_sortIndex = 36800;
        [SortOrder(Frostcraft_LBG_Recovery_Speed_Sheathed_sortIndex)]
        [DisplayName(Frostcraft_LBG_Recovery_Speed_Sheathed_displayName)]
        public virtual float Frostcraft_LBG_Recovery_Speed_Sheathed {
            get => GetData<float>(1665);
            set {
                if (GetData<float>(1665) == value) return;
                SetData(1665, value, nameof(Frostcraft_LBG_Recovery_Speed_Sheathed));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_LBG_Recovery_Speed_Sheathed));
            }
        }

        public const string Frostcraft_LBG_Consumption_per_Hit_displayName = "Frostcraft: (LBG) Consumption per Hit";
        public const int Frostcraft_LBG_Consumption_per_Hit_sortIndex = 36850;
        [SortOrder(Frostcraft_LBG_Consumption_per_Hit_sortIndex)]
        [DisplayName(Frostcraft_LBG_Consumption_per_Hit_displayName)]
        public virtual float Frostcraft_LBG_Consumption_per_Hit {
            get => GetData<float>(1669);
            set {
                if (GetData<float>(1669) == value) return;
                SetData(1669, value, nameof(Frostcraft_LBG_Consumption_per_Hit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_LBG_Consumption_per_Hit));
            }
        }

        public const string __36900_displayName = "-------------------------------------------------------------------------------------------";
        public const int __36900_sortIndex = 36900;
        [SortOrder(__36900_sortIndex)]
        [DisplayName(__36900_displayName)]
        [IsReadOnly]
        public virtual byte __36900 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__36900));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__36900));
            }
        }

        public const string Unk33_displayName = "Unk33";
        public const int Unk33_sortIndex = 36950;
        [SortOrder(Unk33_sortIndex)]
        [DisplayName(Unk33_displayName)]
        public virtual byte Unk33 {
            get => GetData<byte>(1673);
            set {
                if (GetData<byte>(1673) == value) return;
                SetData(1673, value, nameof(Unk33));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk33));
            }
        }

        public const string Unk34_displayName = "Unk34";
        public const int Unk34_sortIndex = 37000;
        [SortOrder(Unk34_sortIndex)]
        [DisplayName(Unk34_displayName)]
        public virtual byte Unk34 {
            get => GetData<byte>(1674);
            set {
                if (GetData<byte>(1674) == value) return;
                SetData(1674, value, nameof(Unk34));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk34));
            }
        }

        public const string Unk35_displayName = "Unk35";
        public const int Unk35_sortIndex = 37050;
        [SortOrder(Unk35_sortIndex)]
        [DisplayName(Unk35_displayName)]
        public virtual byte Unk35 {
            get => GetData<byte>(1675);
            set {
                if (GetData<byte>(1675) == value) return;
                SetData(1675, value, nameof(Unk35));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk35));
            }
        }

        public const string __37100_displayName = "-------------------------------------------------------------------------------------------";
        public const int __37100_sortIndex = 37100;
        [SortOrder(__37100_sortIndex)]
        [DisplayName(__37100_displayName)]
        [IsReadOnly]
        public virtual byte __37100 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__37100));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__37100));
            }
        }

        public const string Frostcraft_Bow_Rapid_Shot_Clutch_Claw_Arrow_Consumption_per_Hit_displayName = "Frostcraft: Bow: (Rapid Shot & Clutch Claw Arrow) Consumption per Hit";
        public const int Frostcraft_Bow_Rapid_Shot_Clutch_Claw_Arrow_Consumption_per_Hit_sortIndex = 37150;
        [SortOrder(Frostcraft_Bow_Rapid_Shot_Clutch_Claw_Arrow_Consumption_per_Hit_sortIndex)]
        [DisplayName(Frostcraft_Bow_Rapid_Shot_Clutch_Claw_Arrow_Consumption_per_Hit_displayName)]
        public virtual byte Frostcraft_Bow_Rapid_Shot_Clutch_Claw_Arrow_Consumption_per_Hit {
            get => GetData<byte>(1676);
            set {
                if (GetData<byte>(1676) == value) return;
                SetData(1676, value, nameof(Frostcraft_Bow_Rapid_Shot_Clutch_Claw_Arrow_Consumption_per_Hit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Bow_Rapid_Shot_Clutch_Claw_Arrow_Consumption_per_Hit));
            }
        }

        public const string Frostcraft_Bow_Power_Shot_Consumption_per_Hit_displayName = "Frostcraft: Bow: (Power Shot) Consumption per Hit";
        public const int Frostcraft_Bow_Power_Shot_Consumption_per_Hit_sortIndex = 37200;
        [SortOrder(Frostcraft_Bow_Power_Shot_Consumption_per_Hit_sortIndex)]
        [DisplayName(Frostcraft_Bow_Power_Shot_Consumption_per_Hit_displayName)]
        public virtual byte Frostcraft_Bow_Power_Shot_Consumption_per_Hit {
            get => GetData<byte>(1677);
            set {
                if (GetData<byte>(1677) == value) return;
                SetData(1677, value, nameof(Frostcraft_Bow_Power_Shot_Consumption_per_Hit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Bow_Power_Shot_Consumption_per_Hit));
            }
        }

        public const string Frostcraft_Bow_Arc_Shot_Consumption_per_Hit_displayName = "Frostcraft: Bow: (Arc Shot) Consumption per Hit";
        public const int Frostcraft_Bow_Arc_Shot_Consumption_per_Hit_sortIndex = 37250;
        [SortOrder(Frostcraft_Bow_Arc_Shot_Consumption_per_Hit_sortIndex)]
        [DisplayName(Frostcraft_Bow_Arc_Shot_Consumption_per_Hit_displayName)]
        public virtual byte Frostcraft_Bow_Arc_Shot_Consumption_per_Hit {
            get => GetData<byte>(1678);
            set {
                if (GetData<byte>(1678) == value) return;
                SetData(1678, value, nameof(Frostcraft_Bow_Arc_Shot_Consumption_per_Hit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Bow_Arc_Shot_Consumption_per_Hit));
            }
        }

        public const string Frostcraft_Bow_Dragonpiercer_Consumption_per_Hit_displayName = "Frostcraft: Bow: (Dragonpiercer) Consumption per Hit";
        public const int Frostcraft_Bow_Dragonpiercer_Consumption_per_Hit_sortIndex = 37300;
        [SortOrder(Frostcraft_Bow_Dragonpiercer_Consumption_per_Hit_sortIndex)]
        [DisplayName(Frostcraft_Bow_Dragonpiercer_Consumption_per_Hit_displayName)]
        public virtual byte Frostcraft_Bow_Dragonpiercer_Consumption_per_Hit {
            get => GetData<byte>(1679);
            set {
                if (GetData<byte>(1679) == value) return;
                SetData(1679, value, nameof(Frostcraft_Bow_Dragonpiercer_Consumption_per_Hit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Bow_Dragonpiercer_Consumption_per_Hit));
            }
        }

        public const string Frostcraft_Bow_Thousand_Dragons_Consumption_per_Hit_displayName = "Frostcraft: Bow: (Thousand Dragons) Consumption per Hit";
        public const int Frostcraft_Bow_Thousand_Dragons_Consumption_per_Hit_sortIndex = 37350;
        [SortOrder(Frostcraft_Bow_Thousand_Dragons_Consumption_per_Hit_sortIndex)]
        [DisplayName(Frostcraft_Bow_Thousand_Dragons_Consumption_per_Hit_displayName)]
        public virtual byte Frostcraft_Bow_Thousand_Dragons_Consumption_per_Hit {
            get => GetData<byte>(1680);
            set {
                if (GetData<byte>(1680) == value) return;
                SetData(1680, value, nameof(Frostcraft_Bow_Thousand_Dragons_Consumption_per_Hit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Bow_Thousand_Dragons_Consumption_per_Hit));
            }
        }

        public const string __37400_displayName = "-------------------------------------------------------------------------------------------";
        public const int __37400_sortIndex = 37400;
        [SortOrder(__37400_sortIndex)]
        [DisplayName(__37400_displayName)]
        [IsReadOnly]
        public virtual byte __37400 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__37400));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__37400));
            }
        }

        public const string Frostcraft_Bowgun_Normal_Ammo_Consumption_per_Hit_displayName = "Frostcraft: Bowgun: (Normal Ammo) Consumption per Hit";
        public const int Frostcraft_Bowgun_Normal_Ammo_Consumption_per_Hit_sortIndex = 37450;
        [SortOrder(Frostcraft_Bowgun_Normal_Ammo_Consumption_per_Hit_sortIndex)]
        [DisplayName(Frostcraft_Bowgun_Normal_Ammo_Consumption_per_Hit_displayName)]
        public virtual byte Frostcraft_Bowgun_Normal_Ammo_Consumption_per_Hit {
            get => GetData<byte>(1681);
            set {
                if (GetData<byte>(1681) == value) return;
                SetData(1681, value, nameof(Frostcraft_Bowgun_Normal_Ammo_Consumption_per_Hit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Bowgun_Normal_Ammo_Consumption_per_Hit));
            }
        }

        public const string Frostcraft_Bowgun_Pierce_Ammo_Consumption_per_Hit_displayName = "Frostcraft: Bowgun: (Pierce Ammo) Consumption per Hit";
        public const int Frostcraft_Bowgun_Pierce_Ammo_Consumption_per_Hit_sortIndex = 37500;
        [SortOrder(Frostcraft_Bowgun_Pierce_Ammo_Consumption_per_Hit_sortIndex)]
        [DisplayName(Frostcraft_Bowgun_Pierce_Ammo_Consumption_per_Hit_displayName)]
        public virtual byte Frostcraft_Bowgun_Pierce_Ammo_Consumption_per_Hit {
            get => GetData<byte>(1682);
            set {
                if (GetData<byte>(1682) == value) return;
                SetData(1682, value, nameof(Frostcraft_Bowgun_Pierce_Ammo_Consumption_per_Hit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Bowgun_Pierce_Ammo_Consumption_per_Hit));
            }
        }

        public const string Frostcraft_Bowgun_Spread_Ammo_Consumption_per_Hit_displayName = "Frostcraft: Bowgun: (Spread Ammo) Consumption per Hit";
        public const int Frostcraft_Bowgun_Spread_Ammo_Consumption_per_Hit_sortIndex = 37550;
        [SortOrder(Frostcraft_Bowgun_Spread_Ammo_Consumption_per_Hit_sortIndex)]
        [DisplayName(Frostcraft_Bowgun_Spread_Ammo_Consumption_per_Hit_displayName)]
        public virtual byte Frostcraft_Bowgun_Spread_Ammo_Consumption_per_Hit {
            get => GetData<byte>(1683);
            set {
                if (GetData<byte>(1683) == value) return;
                SetData(1683, value, nameof(Frostcraft_Bowgun_Spread_Ammo_Consumption_per_Hit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Bowgun_Spread_Ammo_Consumption_per_Hit));
            }
        }

        public const string Frostcraft_Bowgun_Sticky_Ammo_Consumption_per_Hit_displayName = "Frostcraft: Bowgun: (Sticky Ammo) Consumption per Hit";
        public const int Frostcraft_Bowgun_Sticky_Ammo_Consumption_per_Hit_sortIndex = 37600;
        [SortOrder(Frostcraft_Bowgun_Sticky_Ammo_Consumption_per_Hit_sortIndex)]
        [DisplayName(Frostcraft_Bowgun_Sticky_Ammo_Consumption_per_Hit_displayName)]
        public virtual byte Frostcraft_Bowgun_Sticky_Ammo_Consumption_per_Hit {
            get => GetData<byte>(1684);
            set {
                if (GetData<byte>(1684) == value) return;
                SetData(1684, value, nameof(Frostcraft_Bowgun_Sticky_Ammo_Consumption_per_Hit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Bowgun_Sticky_Ammo_Consumption_per_Hit));
            }
        }

        public const string Frostcraft_Bowgun_Cluster_Ammo_Consumption_per_Hit_displayName = "Frostcraft: Bowgun: (Cluster Ammo) Consumption per Hit";
        public const int Frostcraft_Bowgun_Cluster_Ammo_Consumption_per_Hit_sortIndex = 37650;
        [SortOrder(Frostcraft_Bowgun_Cluster_Ammo_Consumption_per_Hit_sortIndex)]
        [DisplayName(Frostcraft_Bowgun_Cluster_Ammo_Consumption_per_Hit_displayName)]
        public virtual byte Frostcraft_Bowgun_Cluster_Ammo_Consumption_per_Hit {
            get => GetData<byte>(1685);
            set {
                if (GetData<byte>(1685) == value) return;
                SetData(1685, value, nameof(Frostcraft_Bowgun_Cluster_Ammo_Consumption_per_Hit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Bowgun_Cluster_Ammo_Consumption_per_Hit));
            }
        }

        public const string Frostcraft_Bowgun_Elemental_Ammo_Consumption_per_Hit_displayName = "Frostcraft: Bowgun: (Elemental Ammo) Consumption per Hit";
        public const int Frostcraft_Bowgun_Elemental_Ammo_Consumption_per_Hit_sortIndex = 37700;
        [SortOrder(Frostcraft_Bowgun_Elemental_Ammo_Consumption_per_Hit_sortIndex)]
        [DisplayName(Frostcraft_Bowgun_Elemental_Ammo_Consumption_per_Hit_displayName)]
        public virtual byte Frostcraft_Bowgun_Elemental_Ammo_Consumption_per_Hit {
            get => GetData<byte>(1686);
            set {
                if (GetData<byte>(1686) == value) return;
                SetData(1686, value, nameof(Frostcraft_Bowgun_Elemental_Ammo_Consumption_per_Hit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Bowgun_Elemental_Ammo_Consumption_per_Hit));
            }
        }

        public const string Frostcraft_Bowgun_Status_Ammo_Consumption_per_Hit_displayName = "Frostcraft: Bowgun: (Status Ammo) Consumption per Hit";
        public const int Frostcraft_Bowgun_Status_Ammo_Consumption_per_Hit_sortIndex = 37750;
        [SortOrder(Frostcraft_Bowgun_Status_Ammo_Consumption_per_Hit_sortIndex)]
        [DisplayName(Frostcraft_Bowgun_Status_Ammo_Consumption_per_Hit_displayName)]
        public virtual byte Frostcraft_Bowgun_Status_Ammo_Consumption_per_Hit {
            get => GetData<byte>(1687);
            set {
                if (GetData<byte>(1687) == value) return;
                SetData(1687, value, nameof(Frostcraft_Bowgun_Status_Ammo_Consumption_per_Hit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Bowgun_Status_Ammo_Consumption_per_Hit));
            }
        }

        public const string Frostcraft_Bowgun_Wyvern_Ammo_Consumption_per_Hit_displayName = "Frostcraft: Bowgun: (Wyvern Ammo) Consumption per Hit";
        public const int Frostcraft_Bowgun_Wyvern_Ammo_Consumption_per_Hit_sortIndex = 37800;
        [SortOrder(Frostcraft_Bowgun_Wyvern_Ammo_Consumption_per_Hit_sortIndex)]
        [DisplayName(Frostcraft_Bowgun_Wyvern_Ammo_Consumption_per_Hit_displayName)]
        public virtual byte Frostcraft_Bowgun_Wyvern_Ammo_Consumption_per_Hit {
            get => GetData<byte>(1688);
            set {
                if (GetData<byte>(1688) == value) return;
                SetData(1688, value, nameof(Frostcraft_Bowgun_Wyvern_Ammo_Consumption_per_Hit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Bowgun_Wyvern_Ammo_Consumption_per_Hit));
            }
        }

        public const string Frostcraft_Bowgun_Slicing_Ammo_Consumption_per_Hit_displayName = "Frostcraft: Bowgun: (Slicing Ammo) Consumption per Hit";
        public const int Frostcraft_Bowgun_Slicing_Ammo_Consumption_per_Hit_sortIndex = 37850;
        [SortOrder(Frostcraft_Bowgun_Slicing_Ammo_Consumption_per_Hit_sortIndex)]
        [DisplayName(Frostcraft_Bowgun_Slicing_Ammo_Consumption_per_Hit_displayName)]
        public virtual byte Frostcraft_Bowgun_Slicing_Ammo_Consumption_per_Hit {
            get => GetData<byte>(1689);
            set {
                if (GetData<byte>(1689) == value) return;
                SetData(1689, value, nameof(Frostcraft_Bowgun_Slicing_Ammo_Consumption_per_Hit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_Bowgun_Slicing_Ammo_Consumption_per_Hit));
            }
        }

        public const string __37900_displayName = "-------------------------------------------------------------------------------------------";
        public const int __37900_sortIndex = 37900;
        [SortOrder(__37900_sortIndex)]
        [DisplayName(__37900_displayName)]
        [IsReadOnly]
        public virtual byte __37900 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__37900));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__37900));
            }
        }

        public const string Frostcraft_HBG_Wyvernheart_Consumption_per_Hit_displayName = "Frostcraft: HBG: (Wyvernheart) Consumption per Hit";
        public const int Frostcraft_HBG_Wyvernheart_Consumption_per_Hit_sortIndex = 37950;
        [SortOrder(Frostcraft_HBG_Wyvernheart_Consumption_per_Hit_sortIndex)]
        [DisplayName(Frostcraft_HBG_Wyvernheart_Consumption_per_Hit_displayName)]
        public virtual byte Frostcraft_HBG_Wyvernheart_Consumption_per_Hit {
            get => GetData<byte>(1690);
            set {
                if (GetData<byte>(1690) == value) return;
                SetData(1690, value, nameof(Frostcraft_HBG_Wyvernheart_Consumption_per_Hit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_HBG_Wyvernheart_Consumption_per_Hit));
            }
        }

        public const string Frostcraft_HBG_Wyvernsnipe_Consumption_per_Hit_displayName = "Frostcraft: HBG: (Wyvernsnipe) Consumption per Hit";
        public const int Frostcraft_HBG_Wyvernsnipe_Consumption_per_Hit_sortIndex = 38000;
        [SortOrder(Frostcraft_HBG_Wyvernsnipe_Consumption_per_Hit_sortIndex)]
        [DisplayName(Frostcraft_HBG_Wyvernsnipe_Consumption_per_Hit_displayName)]
        public virtual byte Frostcraft_HBG_Wyvernsnipe_Consumption_per_Hit {
            get => GetData<byte>(1691);
            set {
                if (GetData<byte>(1691) == value) return;
                SetData(1691, value, nameof(Frostcraft_HBG_Wyvernsnipe_Consumption_per_Hit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_HBG_Wyvernsnipe_Consumption_per_Hit));
            }
        }

        public const string Frostcraft_HBG_Wyvernsnipe_Type_2_Consumption_per_Hit_displayName = "Frostcraft: HBG: (Wyvernsnipe Type 2) Consumption per Hit";
        public const int Frostcraft_HBG_Wyvernsnipe_Type_2_Consumption_per_Hit_sortIndex = 38050;
        [SortOrder(Frostcraft_HBG_Wyvernsnipe_Type_2_Consumption_per_Hit_sortIndex)]
        [DisplayName(Frostcraft_HBG_Wyvernsnipe_Type_2_Consumption_per_Hit_displayName)]
        public virtual byte Frostcraft_HBG_Wyvernsnipe_Type_2_Consumption_per_Hit {
            get => GetData<byte>(1692);
            set {
                if (GetData<byte>(1692) == value) return;
                SetData(1692, value, nameof(Frostcraft_HBG_Wyvernsnipe_Type_2_Consumption_per_Hit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_HBG_Wyvernsnipe_Type_2_Consumption_per_Hit));
            }
        }

        public const string Frostcraft_HBG_Claw_Wyvernheart_Gatling_Consumption_per_Hit_displayName = "Frostcraft: HBG: (Claw Wyvernheart Gatling) Consumption per Hit";
        public const int Frostcraft_HBG_Claw_Wyvernheart_Gatling_Consumption_per_Hit_sortIndex = 38100;
        [SortOrder(Frostcraft_HBG_Claw_Wyvernheart_Gatling_Consumption_per_Hit_sortIndex)]
        [DisplayName(Frostcraft_HBG_Claw_Wyvernheart_Gatling_Consumption_per_Hit_displayName)]
        public virtual byte Frostcraft_HBG_Claw_Wyvernheart_Gatling_Consumption_per_Hit {
            get => GetData<byte>(1694);
            set {
                if (GetData<byte>(1694) == value) return;
                SetData(1694, value, nameof(Frostcraft_HBG_Claw_Wyvernheart_Gatling_Consumption_per_Hit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_HBG_Claw_Wyvernheart_Gatling_Consumption_per_Hit));
            }
        }

        public const string Frostcraft_HBG_Claw_Wyvernheart_Finish_Consumption_per_Hit_displayName = "Frostcraft: HBG: (Claw Wyvernheart Finish) Consumption per Hit";
        public const int Frostcraft_HBG_Claw_Wyvernheart_Finish_Consumption_per_Hit_sortIndex = 38150;
        [SortOrder(Frostcraft_HBG_Claw_Wyvernheart_Finish_Consumption_per_Hit_sortIndex)]
        [DisplayName(Frostcraft_HBG_Claw_Wyvernheart_Finish_Consumption_per_Hit_displayName)]
        public virtual byte Frostcraft_HBG_Claw_Wyvernheart_Finish_Consumption_per_Hit {
            get => GetData<byte>(1695);
            set {
                if (GetData<byte>(1695) == value) return;
                SetData(1695, value, nameof(Frostcraft_HBG_Claw_Wyvernheart_Finish_Consumption_per_Hit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_HBG_Claw_Wyvernheart_Finish_Consumption_per_Hit));
            }
        }

        public const string Frostcraft_HBG_Wyvernsnipe_Claw_Consumption_per_Hit_displayName = "Frostcraft: HBG: (Wyvernsnipe Claw) Consumption per Hit";
        public const int Frostcraft_HBG_Wyvernsnipe_Claw_Consumption_per_Hit_sortIndex = 38200;
        [SortOrder(Frostcraft_HBG_Wyvernsnipe_Claw_Consumption_per_Hit_sortIndex)]
        [DisplayName(Frostcraft_HBG_Wyvernsnipe_Claw_Consumption_per_Hit_displayName)]
        public virtual byte Frostcraft_HBG_Wyvernsnipe_Claw_Consumption_per_Hit {
            get => GetData<byte>(1696);
            set {
                if (GetData<byte>(1696) == value) return;
                SetData(1696, value, nameof(Frostcraft_HBG_Wyvernsnipe_Claw_Consumption_per_Hit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_HBG_Wyvernsnipe_Claw_Consumption_per_Hit));
            }
        }

        public const string __38250_displayName = "-------------------------------------------------------------------------------------------";
        public const int __38250_sortIndex = 38250;
        [SortOrder(__38250_sortIndex)]
        [DisplayName(__38250_displayName)]
        [IsReadOnly]
        public virtual byte __38250 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__38250));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__38250));
            }
        }

        public const string Frostcraft_LBG_Wyvernblast_Consumption_per_Hit_displayName = "Frostcraft: LBG: (Wyvernblast) Consumption per Hit";
        public const int Frostcraft_LBG_Wyvernblast_Consumption_per_Hit_sortIndex = 38300;
        [SortOrder(Frostcraft_LBG_Wyvernblast_Consumption_per_Hit_sortIndex)]
        [DisplayName(Frostcraft_LBG_Wyvernblast_Consumption_per_Hit_displayName)]
        public virtual byte Frostcraft_LBG_Wyvernblast_Consumption_per_Hit {
            get => GetData<byte>(1693);
            set {
                if (GetData<byte>(1693) == value) return;
                SetData(1693, value, nameof(Frostcraft_LBG_Wyvernblast_Consumption_per_Hit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_LBG_Wyvernblast_Consumption_per_Hit));
            }
        }

        public const string Frostcraft_LBG_Wyvernblast_Claw_Consumption_per_Hit_displayName = "Frostcraft: LBG: (Wyvernblast Claw) Consumption per Hit";
        public const int Frostcraft_LBG_Wyvernblast_Claw_Consumption_per_Hit_sortIndex = 38350;
        [SortOrder(Frostcraft_LBG_Wyvernblast_Claw_Consumption_per_Hit_sortIndex)]
        [DisplayName(Frostcraft_LBG_Wyvernblast_Claw_Consumption_per_Hit_displayName)]
        public virtual byte Frostcraft_LBG_Wyvernblast_Claw_Consumption_per_Hit {
            get => GetData<byte>(1697);
            set {
                if (GetData<byte>(1697) == value) return;
                SetData(1697, value, nameof(Frostcraft_LBG_Wyvernblast_Claw_Consumption_per_Hit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Frostcraft_LBG_Wyvernblast_Claw_Consumption_per_Hit));
            }
        }

        public const string __38400_displayName = "-------------------------------------------------------------------------------------------";
        public const int __38400_sortIndex = 38400;
        [SortOrder(__38400_sortIndex)]
        [DisplayName(__38400_displayName)]
        [IsReadOnly]
        public virtual byte __38400 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__38400));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__38400));
            }
        }

        public const string Unk_Safi_1_displayName = "Unk Safi 1";
        public const int Unk_Safi_1_sortIndex = 38450;
        [SortOrder(Unk_Safi_1_sortIndex)]
        [DisplayName(Unk_Safi_1_displayName)]
        public virtual byte Unk_Safi_1 {
            get => GetData<byte>(1698);
            set {
                if (GetData<byte>(1698) == value) return;
                SetData(1698, value, nameof(Unk_Safi_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk_Safi_1));
            }
        }

        public const string Unk36_displayName = "Unk36";
        public const int Unk36_sortIndex = 38500;
        [SortOrder(Unk36_sortIndex)]
        [DisplayName(Unk36_displayName)]
        public virtual float Unk36 {
            get => GetData<float>(1699);
            set {
                if (GetData<float>(1699) == value) return;
                SetData(1699, value, nameof(Unk36));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk36));
            }
        }

        public const string Unk37_displayName = "Unk37";
        public const int Unk37_sortIndex = 38550;
        [SortOrder(Unk37_sortIndex)]
        [DisplayName(Unk37_displayName)]
        public virtual float Unk37 {
            get => GetData<float>(1703);
            set {
                if (GetData<float>(1703) == value) return;
                SetData(1703, value, nameof(Unk37));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk37));
            }
        }

        public const string Unk38_displayName = "Unk38";
        public const int Unk38_sortIndex = 38600;
        [SortOrder(Unk38_sortIndex)]
        [DisplayName(Unk38_displayName)]
        public virtual float Unk38 {
            get => GetData<float>(1707);
            set {
                if (GetData<float>(1707) == value) return;
                SetData(1707, value, nameof(Unk38));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk38));
            }
        }

        public const string Unk39_displayName = "Unk39";
        public const int Unk39_sortIndex = 38650;
        [SortOrder(Unk39_sortIndex)]
        [DisplayName(Unk39_displayName)]
        public virtual float Unk39 {
            get => GetData<float>(1711);
            set {
                if (GetData<float>(1711) == value) return;
                SetData(1711, value, nameof(Unk39));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk39));
            }
        }

        public const string Unk40_displayName = "Unk40";
        public const int Unk40_sortIndex = 38700;
        [SortOrder(Unk40_sortIndex)]
        [DisplayName(Unk40_displayName)]
        public virtual float Unk40 {
            get => GetData<float>(1715);
            set {
                if (GetData<float>(1715) == value) return;
                SetData(1715, value, nameof(Unk40));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk40));
            }
        }

        public const string Unk41_displayName = "Unk41";
        public const int Unk41_sortIndex = 38750;
        [SortOrder(Unk41_sortIndex)]
        [DisplayName(Unk41_displayName)]
        public virtual float Unk41 {
            get => GetData<float>(1719);
            set {
                if (GetData<float>(1719) == value) return;
                SetData(1719, value, nameof(Unk41));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk41));
            }
        }

        public const string Unk42_displayName = "Unk42";
        public const int Unk42_sortIndex = 38800;
        [SortOrder(Unk42_sortIndex)]
        [DisplayName(Unk42_displayName)]
        public virtual float Unk42 {
            get => GetData<float>(1723);
            set {
                if (GetData<float>(1723) == value) return;
                SetData(1723, value, nameof(Unk42));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk42));
            }
        }

        public const string Unk43_displayName = "Unk43";
        public const int Unk43_sortIndex = 38850;
        [SortOrder(Unk43_sortIndex)]
        [DisplayName(Unk43_displayName)]
        public virtual float Unk43 {
            get => GetData<float>(1727);
            set {
                if (GetData<float>(1727) == value) return;
                SetData(1727, value, nameof(Unk43));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk43));
            }
        }

        public const string Unk44_displayName = "Unk44";
        public const int Unk44_sortIndex = 38900;
        [SortOrder(Unk44_sortIndex)]
        [DisplayName(Unk44_displayName)]
        public virtual float Unk44 {
            get => GetData<float>(1731);
            set {
                if (GetData<float>(1731) == value) return;
                SetData(1731, value, nameof(Unk44));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk44));
            }
        }

        public const string Unk45_displayName = "Unk45";
        public const int Unk45_sortIndex = 38950;
        [SortOrder(Unk45_sortIndex)]
        [DisplayName(Unk45_displayName)]
        public virtual float Unk45 {
            get => GetData<float>(1735);
            set {
                if (GetData<float>(1735) == value) return;
                SetData(1735, value, nameof(Unk45));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk45));
            }
        }

        public const string Unk46_displayName = "Unk46";
        public const int Unk46_sortIndex = 39000;
        [SortOrder(Unk46_sortIndex)]
        [DisplayName(Unk46_displayName)]
        public virtual float Unk46 {
            get => GetData<float>(1739);
            set {
                if (GetData<float>(1739) == value) return;
                SetData(1739, value, nameof(Unk46));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk46));
            }
        }

        public const string Unk47_displayName = "Unk47";
        public const int Unk47_sortIndex = 39050;
        [SortOrder(Unk47_sortIndex)]
        [DisplayName(Unk47_displayName)]
        public virtual float Unk47 {
            get => GetData<float>(1743);
            set {
                if (GetData<float>(1743) == value) return;
                SetData(1743, value, nameof(Unk47));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk47));
            }
        }

        public const string Unk48_displayName = "Unk48";
        public const int Unk48_sortIndex = 39100;
        [SortOrder(Unk48_sortIndex)]
        [DisplayName(Unk48_displayName)]
        public virtual float Unk48 {
            get => GetData<float>(1747);
            set {
                if (GetData<float>(1747) == value) return;
                SetData(1747, value, nameof(Unk48));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk48));
            }
        }

        public const string Unk49_displayName = "Unk49";
        public const int Unk49_sortIndex = 39150;
        [SortOrder(Unk49_sortIndex)]
        [DisplayName(Unk49_displayName)]
        public virtual float Unk49 {
            get => GetData<float>(1751);
            set {
                if (GetData<float>(1751) == value) return;
                SetData(1751, value, nameof(Unk49));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk49));
            }
        }

        public const string Unk50_displayName = "Unk50";
        public const int Unk50_sortIndex = 39200;
        [SortOrder(Unk50_sortIndex)]
        [DisplayName(Unk50_displayName)]
        public virtual float Unk50 {
            get => GetData<float>(1755);
            set {
                if (GetData<float>(1755) == value) return;
                SetData(1755, value, nameof(Unk50));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk50));
            }
        }

        public const string Unk51_displayName = "Unk51";
        public const int Unk51_sortIndex = 39250;
        [SortOrder(Unk51_sortIndex)]
        [DisplayName(Unk51_displayName)]
        public virtual float Unk51 {
            get => GetData<float>(1759);
            set {
                if (GetData<float>(1759) == value) return;
                SetData(1759, value, nameof(Unk51));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk51));
            }
        }

        public const string Unk52_displayName = "Unk52";
        public const int Unk52_sortIndex = 39300;
        [SortOrder(Unk52_sortIndex)]
        [DisplayName(Unk52_displayName)]
        public virtual float Unk52 {
            get => GetData<float>(1763);
            set {
                if (GetData<float>(1763) == value) return;
                SetData(1763, value, nameof(Unk52));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk52));
            }
        }

        public const string Unk53_displayName = "Unk53";
        public const int Unk53_sortIndex = 39350;
        [SortOrder(Unk53_sortIndex)]
        [DisplayName(Unk53_displayName)]
        public virtual float Unk53 {
            get => GetData<float>(1767);
            set {
                if (GetData<float>(1767) == value) return;
                SetData(1767, value, nameof(Unk53));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk53));
            }
        }

        public const string Unk54_displayName = "Unk54";
        public const int Unk54_sortIndex = 39400;
        [SortOrder(Unk54_sortIndex)]
        [DisplayName(Unk54_displayName)]
        public virtual float Unk54 {
            get => GetData<float>(1771);
            set {
                if (GetData<float>(1771) == value) return;
                SetData(1771, value, nameof(Unk54));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk54));
            }
        }

        public const string Unk55_displayName = "Unk55";
        public const int Unk55_sortIndex = 39450;
        [SortOrder(Unk55_sortIndex)]
        [DisplayName(Unk55_displayName)]
        public virtual float Unk55 {
            get => GetData<float>(1775);
            set {
                if (GetData<float>(1775) == value) return;
                SetData(1775, value, nameof(Unk55));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk55));
            }
        }

        public const string Unk56_displayName = "Unk56";
        public const int Unk56_sortIndex = 39500;
        [SortOrder(Unk56_sortIndex)]
        [DisplayName(Unk56_displayName)]
        public virtual float Unk56 {
            get => GetData<float>(1779);
            set {
                if (GetData<float>(1779) == value) return;
                SetData(1779, value, nameof(Unk56));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk56));
            }
        }

        public const string Unk57_displayName = "Unk57";
        public const int Unk57_sortIndex = 39550;
        [SortOrder(Unk57_sortIndex)]
        [DisplayName(Unk57_displayName)]
        public virtual float Unk57 {
            get => GetData<float>(1783);
            set {
                if (GetData<float>(1783) == value) return;
                SetData(1783, value, nameof(Unk57));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk57));
            }
        }

        public const string Unk58_displayName = "Unk58";
        public const int Unk58_sortIndex = 39600;
        [SortOrder(Unk58_sortIndex)]
        [DisplayName(Unk58_displayName)]
        public virtual float Unk58 {
            get => GetData<float>(1787);
            set {
                if (GetData<float>(1787) == value) return;
                SetData(1787, value, nameof(Unk58));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk58));
            }
        }

        public const string Unk59_displayName = "Unk59";
        public const int Unk59_sortIndex = 39650;
        [SortOrder(Unk59_sortIndex)]
        [DisplayName(Unk59_displayName)]
        public virtual float Unk59 {
            get => GetData<float>(1791);
            set {
                if (GetData<float>(1791) == value) return;
                SetData(1791, value, nameof(Unk59));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk59));
            }
        }

        public const string Unk60_displayName = "Unk60";
        public const int Unk60_sortIndex = 39700;
        [SortOrder(Unk60_sortIndex)]
        [DisplayName(Unk60_displayName)]
        public virtual float Unk60 {
            get => GetData<float>(1795);
            set {
                if (GetData<float>(1795) == value) return;
                SetData(1795, value, nameof(Unk60));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk60));
            }
        }

        public const string Unk61_displayName = "Unk61";
        public const int Unk61_sortIndex = 39750;
        [SortOrder(Unk61_sortIndex)]
        [DisplayName(Unk61_displayName)]
        public virtual float Unk61 {
            get => GetData<float>(1799);
            set {
                if (GetData<float>(1799) == value) return;
                SetData(1799, value, nameof(Unk61));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk61));
            }
        }

        public const string Unk62_displayName = "Unk62";
        public const int Unk62_sortIndex = 39800;
        [SortOrder(Unk62_sortIndex)]
        [DisplayName(Unk62_displayName)]
        public virtual float Unk62 {
            get => GetData<float>(1803);
            set {
                if (GetData<float>(1803) == value) return;
                SetData(1803, value, nameof(Unk62));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk62));
            }
        }

        public const string Unk63_displayName = "Unk63";
        public const int Unk63_sortIndex = 39850;
        [SortOrder(Unk63_sortIndex)]
        [DisplayName(Unk63_displayName)]
        public virtual float Unk63 {
            get => GetData<float>(1807);
            set {
                if (GetData<float>(1807) == value) return;
                SetData(1807, value, nameof(Unk63));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk63));
            }
        }

        public const string Unk64_displayName = "Unk64";
        public const int Unk64_sortIndex = 39900;
        [SortOrder(Unk64_sortIndex)]
        [DisplayName(Unk64_displayName)]
        public virtual float Unk64 {
            get => GetData<float>(1811);
            set {
                if (GetData<float>(1811) == value) return;
                SetData(1811, value, nameof(Unk64));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk64));
            }
        }

        public const string Unk65_displayName = "Unk65";
        public const int Unk65_sortIndex = 39950;
        [SortOrder(Unk65_sortIndex)]
        [DisplayName(Unk65_displayName)]
        public virtual float Unk65 {
            get => GetData<float>(1815);
            set {
                if (GetData<float>(1815) == value) return;
                SetData(1815, value, nameof(Unk65));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk65));
            }
        }

        public const string Unk66_displayName = "Unk66";
        public const int Unk66_sortIndex = 40000;
        [SortOrder(Unk66_sortIndex)]
        [DisplayName(Unk66_displayName)]
        public virtual float Unk66 {
            get => GetData<float>(1819);
            set {
                if (GetData<float>(1819) == value) return;
                SetData(1819, value, nameof(Unk66));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk66));
            }
        }

        public const string Unk67_displayName = "Unk67";
        public const int Unk67_sortIndex = 40050;
        [SortOrder(Unk67_sortIndex)]
        [DisplayName(Unk67_displayName)]
        public virtual float Unk67 {
            get => GetData<float>(1823);
            set {
                if (GetData<float>(1823) == value) return;
                SetData(1823, value, nameof(Unk67));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk67));
            }
        }

        public const string Unk68_displayName = "Unk68";
        public const int Unk68_sortIndex = 40100;
        [SortOrder(Unk68_sortIndex)]
        [DisplayName(Unk68_displayName)]
        public virtual float Unk68 {
            get => GetData<float>(1827);
            set {
                if (GetData<float>(1827) == value) return;
                SetData(1827, value, nameof(Unk68));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk68));
            }
        }

        public const string Unk69_displayName = "Unk69";
        public const int Unk69_sortIndex = 40150;
        [SortOrder(Unk69_sortIndex)]
        [DisplayName(Unk69_displayName)]
        public virtual float Unk69 {
            get => GetData<float>(1831);
            set {
                if (GetData<float>(1831) == value) return;
                SetData(1831, value, nameof(Unk69));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk69));
            }
        }

        public const string Unk70_displayName = "Unk70";
        public const int Unk70_sortIndex = 40200;
        [SortOrder(Unk70_sortIndex)]
        [DisplayName(Unk70_displayName)]
        public virtual float Unk70 {
            get => GetData<float>(1835);
            set {
                if (GetData<float>(1835) == value) return;
                SetData(1835, value, nameof(Unk70));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk70));
            }
        }

        public const string Unk71_displayName = "Unk71";
        public const int Unk71_sortIndex = 40250;
        [SortOrder(Unk71_sortIndex)]
        [DisplayName(Unk71_displayName)]
        public virtual float Unk71 {
            get => GetData<float>(1839);
            set {
                if (GetData<float>(1839) == value) return;
                SetData(1839, value, nameof(Unk71));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk71));
            }
        }

        public const string Unk72_displayName = "Unk72";
        public const int Unk72_sortIndex = 40300;
        [SortOrder(Unk72_sortIndex)]
        [DisplayName(Unk72_displayName)]
        public virtual float Unk72 {
            get => GetData<float>(1843);
            set {
                if (GetData<float>(1843) == value) return;
                SetData(1843, value, nameof(Unk72));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk72));
            }
        }

        public const string Unk73_displayName = "Unk73";
        public const int Unk73_sortIndex = 40350;
        [SortOrder(Unk73_sortIndex)]
        [DisplayName(Unk73_displayName)]
        public virtual float Unk73 {
            get => GetData<float>(1847);
            set {
                if (GetData<float>(1847) == value) return;
                SetData(1847, value, nameof(Unk73));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk73));
            }
        }

        public const string Unk74_displayName = "Unk74";
        public const int Unk74_sortIndex = 40400;
        [SortOrder(Unk74_sortIndex)]
        [DisplayName(Unk74_displayName)]
        public virtual float Unk74 {
            get => GetData<float>(1851);
            set {
                if (GetData<float>(1851) == value) return;
                SetData(1851, value, nameof(Unk74));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk74));
            }
        }

        public const string Unk75_displayName = "Unk75";
        public const int Unk75_sortIndex = 40450;
        [SortOrder(Unk75_sortIndex)]
        [DisplayName(Unk75_displayName)]
        public virtual float Unk75 {
            get => GetData<float>(1855);
            set {
                if (GetData<float>(1855) == value) return;
                SetData(1855, value, nameof(Unk75));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk75));
            }
        }

        public const string Unk76_displayName = "Unk76";
        public const int Unk76_sortIndex = 40500;
        [SortOrder(Unk76_sortIndex)]
        [DisplayName(Unk76_displayName)]
        public virtual float Unk76 {
            get => GetData<float>(1859);
            set {
                if (GetData<float>(1859) == value) return;
                SetData(1859, value, nameof(Unk76));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk76));
            }
        }

        public const string Unk77_displayName = "Unk77";
        public const int Unk77_sortIndex = 40550;
        [SortOrder(Unk77_sortIndex)]
        [DisplayName(Unk77_displayName)]
        public virtual float Unk77 {
            get => GetData<float>(1863);
            set {
                if (GetData<float>(1863) == value) return;
                SetData(1863, value, nameof(Unk77));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk77));
            }
        }

        public const string Unk78_displayName = "Unk78";
        public const int Unk78_sortIndex = 40600;
        [SortOrder(Unk78_sortIndex)]
        [DisplayName(Unk78_displayName)]
        public virtual float Unk78 {
            get => GetData<float>(1867);
            set {
                if (GetData<float>(1867) == value) return;
                SetData(1867, value, nameof(Unk78));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk78));
            }
        }

        public const string Unk79_displayName = "Unk79";
        public const int Unk79_sortIndex = 40650;
        [SortOrder(Unk79_sortIndex)]
        [DisplayName(Unk79_displayName)]
        public virtual float Unk79 {
            get => GetData<float>(1871);
            set {
                if (GetData<float>(1871) == value) return;
                SetData(1871, value, nameof(Unk79));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk79));
            }
        }

        public const string Unk80_displayName = "Unk80";
        public const int Unk80_sortIndex = 40700;
        [SortOrder(Unk80_sortIndex)]
        [DisplayName(Unk80_displayName)]
        public virtual float Unk80 {
            get => GetData<float>(1875);
            set {
                if (GetData<float>(1875) == value) return;
                SetData(1875, value, nameof(Unk80));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk80));
            }
        }

        public const string Unk81_displayName = "Unk81";
        public const int Unk81_sortIndex = 40750;
        [SortOrder(Unk81_sortIndex)]
        [DisplayName(Unk81_displayName)]
        public virtual float Unk81 {
            get => GetData<float>(1879);
            set {
                if (GetData<float>(1879) == value) return;
                SetData(1879, value, nameof(Unk81));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk81));
            }
        }

        public const string Offensive_Guard_displayName = "Offensive Guard";
        public const int Offensive_Guard_sortIndex = 40800;
        [SortOrder(Offensive_Guard_sortIndex)]
        [DisplayName(Offensive_Guard_displayName)]
        public virtual float Offensive_Guard {
            get => GetData<float>(1883);
            set {
                if (GetData<float>(1883) == value) return;
                SetData(1883, value, nameof(Offensive_Guard));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Offensive_Guard));
            }
        }

        public const string Coalescence_displayName = "Coalescence";
        public const int Coalescence_sortIndex = 40850;
        [SortOrder(Coalescence_sortIndex)]
        [DisplayName(Coalescence_displayName)]
        public virtual float Coalescence {
            get => GetData<float>(1887);
            set {
                if (GetData<float>(1887) == value) return;
                SetData(1887, value, nameof(Coalescence));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Coalescence));
            }
        }

        public const string __40900_displayName = "-------------------------------------------------------------------------------------------";
        public const int __40900_sortIndex = 40900;
        [SortOrder(__40900_sortIndex)]
        [DisplayName(__40900_displayName)]
        [IsReadOnly]
        public virtual byte __40900 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__40900));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__40900));
            }
        }

        public const string Unk_Safi_2_displayName = "Unk Safi 2";
        public const int Unk_Safi_2_sortIndex = 40950;
        [SortOrder(Unk_Safi_2_sortIndex)]
        [DisplayName(Unk_Safi_2_displayName)]
        public virtual float Unk_Safi_2 {
            get => GetData<float>(1891);
            set {
                if (GetData<float>(1891) == value) return;
                SetData(1891, value, nameof(Unk_Safi_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk_Safi_2));
            }
        }

        public const string Unk_Safi_3_displayName = "Unk Safi 3";
        public const int Unk_Safi_3_sortIndex = 41000;
        [SortOrder(Unk_Safi_3_sortIndex)]
        [DisplayName(Unk_Safi_3_displayName)]
        public virtual float Unk_Safi_3 {
            get => GetData<float>(1895);
            set {
                if (GetData<float>(1895) == value) return;
                SetData(1895, value, nameof(Unk_Safi_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk_Safi_3));
            }
        }

        public const string Unk_Safi_4_displayName = "Unk Safi 4";
        public const int Unk_Safi_4_sortIndex = 41050;
        [SortOrder(Unk_Safi_4_sortIndex)]
        [DisplayName(Unk_Safi_4_displayName)]
        public virtual float Unk_Safi_4 {
            get => GetData<float>(1899);
            set {
                if (GetData<float>(1899) == value) return;
                SetData(1899, value, nameof(Unk_Safi_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk_Safi_4));
            }
        }

        public const string Unk_Safi_5_displayName = "Unk Safi 5";
        public const int Unk_Safi_5_sortIndex = 41100;
        [SortOrder(Unk_Safi_5_sortIndex)]
        [DisplayName(Unk_Safi_5_displayName)]
        public virtual uint Unk_Safi_5 {
            get => GetData<uint>(1903);
            set {
                if (GetData<uint>(1903) == value) return;
                SetData(1903, value, nameof(Unk_Safi_5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk_Safi_5));
            }
        }

        public const string Unk_Safi_6_displayName = "Unk Safi 6";
        public const int Unk_Safi_6_sortIndex = 41150;
        [SortOrder(Unk_Safi_6_sortIndex)]
        [DisplayName(Unk_Safi_6_displayName)]
        public virtual uint Unk_Safi_6 {
            get => GetData<uint>(1907);
            set {
                if (GetData<uint>(1907) == value) return;
                SetData(1907, value, nameof(Unk_Safi_6));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk_Safi_6));
            }
        }

        public const string Unk_Safi_7_displayName = "Unk Safi 7";
        public const int Unk_Safi_7_sortIndex = 41200;
        [SortOrder(Unk_Safi_7_sortIndex)]
        [DisplayName(Unk_Safi_7_displayName)]
        public virtual float Unk_Safi_7 {
            get => GetData<float>(1911);
            set {
                if (GetData<float>(1911) == value) return;
                SetData(1911, value, nameof(Unk_Safi_7));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk_Safi_7));
            }
        }

        public const string Set_3_Elemental_Bonus_displayName = "Set(3) Elemental Bonus";
        public const int Set_3_Elemental_Bonus_sortIndex = 41250;
        [SortOrder(Set_3_Elemental_Bonus_sortIndex)]
        [DisplayName(Set_3_Elemental_Bonus_displayName)]
        public virtual float Set_3_Elemental_Bonus {
            get => GetData<float>(1915);
            set {
                if (GetData<float>(1915) == value) return;
                SetData(1915, value, nameof(Set_3_Elemental_Bonus));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Set_3_Elemental_Bonus));
            }
        }

        public const string Set_5_Elemental_Bonus_displayName = "Set(5) Elemental Bonus";
        public const int Set_5_Elemental_Bonus_sortIndex = 41300;
        [SortOrder(Set_5_Elemental_Bonus_sortIndex)]
        [DisplayName(Set_5_Elemental_Bonus_displayName)]
        public virtual float Set_5_Elemental_Bonus {
            get => GetData<float>(1919);
            set {
                if (GetData<float>(1919) == value) return;
                SetData(1919, value, nameof(Set_5_Elemental_Bonus));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Set_5_Elemental_Bonus));
            }
        }

        public const string Set_3_Status_Bonus_displayName = "Set(3) Status Bonus";
        public const int Set_3_Status_Bonus_sortIndex = 41350;
        [SortOrder(Set_3_Status_Bonus_sortIndex)]
        [DisplayName(Set_3_Status_Bonus_displayName)]
        public virtual float Set_3_Status_Bonus {
            get => GetData<float>(1923);
            set {
                if (GetData<float>(1923) == value) return;
                SetData(1923, value, nameof(Set_3_Status_Bonus));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Set_3_Status_Bonus));
            }
        }

        public const string Set_5_Status_Bonus_displayName = "Set(5) Status Bonus";
        public const int Set_5_Status_Bonus_sortIndex = 41400;
        [SortOrder(Set_5_Status_Bonus_sortIndex)]
        [DisplayName(Set_5_Status_Bonus_displayName)]
        public virtual float Set_5_Status_Bonus {
            get => GetData<float>(1927);
            set {
                if (GetData<float>(1927) == value) return;
                SetData(1927, value, nameof(Set_5_Status_Bonus));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Set_5_Status_Bonus));
            }
        }

        public const string Set_3_Affinity_Bonus_displayName = "Set(3) Affinity Bonus";
        public const int Set_3_Affinity_Bonus_sortIndex = 41450;
        [SortOrder(Set_3_Affinity_Bonus_sortIndex)]
        [DisplayName(Set_3_Affinity_Bonus_displayName)]
        public virtual uint Set_3_Affinity_Bonus {
            get => GetData<uint>(1931);
            set {
                if (GetData<uint>(1931) == value) return;
                SetData(1931, value, nameof(Set_3_Affinity_Bonus));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Set_3_Affinity_Bonus));
            }
        }

        public const string Set_5_Affinity_Bonus_displayName = "Set(5) Affinity Bonus";
        public const int Set_5_Affinity_Bonus_sortIndex = 41500;
        [SortOrder(Set_5_Affinity_Bonus_sortIndex)]
        [DisplayName(Set_5_Affinity_Bonus_displayName)]
        public virtual uint Set_5_Affinity_Bonus {
            get => GetData<uint>(1935);
            set {
                if (GetData<uint>(1935) == value) return;
                SetData(1935, value, nameof(Set_5_Affinity_Bonus));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Set_5_Affinity_Bonus));
            }
        }

        public const string __41550_displayName = "-------------------------------------------------------------------------------------------";
        public const int __41550_sortIndex = 41550;
        [SortOrder(__41550_sortIndex)]
        [DisplayName(__41550_displayName)]
        [IsReadOnly]
        public virtual byte __41550 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__41550));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__41550));
            }
        }

        public const string Safi_Jiva_Seal_Great_Sword_Hit_Combo_to_Heal_displayName = "Safi'Jiva Seal: (Great Sword) Hit Combo to Heal";
        public const int Safi_Jiva_Seal_Great_Sword_Hit_Combo_to_Heal_sortIndex = 41600;
        [SortOrder(Safi_Jiva_Seal_Great_Sword_Hit_Combo_to_Heal_sortIndex)]
        [DisplayName(Safi_Jiva_Seal_Great_Sword_Hit_Combo_to_Heal_displayName)]
        public virtual byte Safi_Jiva_Seal_Great_Sword_Hit_Combo_to_Heal {
            get => GetData<byte>(1939);
            set {
                if (GetData<byte>(1939) == value) return;
                SetData(1939, value, nameof(Safi_Jiva_Seal_Great_Sword_Hit_Combo_to_Heal));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Safi_Jiva_Seal_Great_Sword_Hit_Combo_to_Heal));
            }
        }

        public const string Safi_Jiva_Seal_Sword_Shield_Hit_Combo_to_Heal_displayName = "Safi'Jiva Seal: (Sword & Shield) Hit Combo to Heal";
        public const int Safi_Jiva_Seal_Sword_Shield_Hit_Combo_to_Heal_sortIndex = 41650;
        [SortOrder(Safi_Jiva_Seal_Sword_Shield_Hit_Combo_to_Heal_sortIndex)]
        [DisplayName(Safi_Jiva_Seal_Sword_Shield_Hit_Combo_to_Heal_displayName)]
        public virtual byte Safi_Jiva_Seal_Sword_Shield_Hit_Combo_to_Heal {
            get => GetData<byte>(1940);
            set {
                if (GetData<byte>(1940) == value) return;
                SetData(1940, value, nameof(Safi_Jiva_Seal_Sword_Shield_Hit_Combo_to_Heal));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Safi_Jiva_Seal_Sword_Shield_Hit_Combo_to_Heal));
            }
        }

        public const string Safi_Jiva_Seal_Dual_Blades_Hit_Combo_to_Heal_displayName = "Safi'Jiva Seal: (Dual Blades) Hit Combo to Heal";
        public const int Safi_Jiva_Seal_Dual_Blades_Hit_Combo_to_Heal_sortIndex = 41700;
        [SortOrder(Safi_Jiva_Seal_Dual_Blades_Hit_Combo_to_Heal_sortIndex)]
        [DisplayName(Safi_Jiva_Seal_Dual_Blades_Hit_Combo_to_Heal_displayName)]
        public virtual byte Safi_Jiva_Seal_Dual_Blades_Hit_Combo_to_Heal {
            get => GetData<byte>(1941);
            set {
                if (GetData<byte>(1941) == value) return;
                SetData(1941, value, nameof(Safi_Jiva_Seal_Dual_Blades_Hit_Combo_to_Heal));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Safi_Jiva_Seal_Dual_Blades_Hit_Combo_to_Heal));
            }
        }

        public const string Safi_Jiva_Seal_Long_Sword_Hit_Combo_to_Heal_displayName = "Safi'Jiva Seal: (Long Sword) Hit Combo to Heal";
        public const int Safi_Jiva_Seal_Long_Sword_Hit_Combo_to_Heal_sortIndex = 41750;
        [SortOrder(Safi_Jiva_Seal_Long_Sword_Hit_Combo_to_Heal_sortIndex)]
        [DisplayName(Safi_Jiva_Seal_Long_Sword_Hit_Combo_to_Heal_displayName)]
        public virtual byte Safi_Jiva_Seal_Long_Sword_Hit_Combo_to_Heal {
            get => GetData<byte>(1942);
            set {
                if (GetData<byte>(1942) == value) return;
                SetData(1942, value, nameof(Safi_Jiva_Seal_Long_Sword_Hit_Combo_to_Heal));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Safi_Jiva_Seal_Long_Sword_Hit_Combo_to_Heal));
            }
        }

        public const string Safi_Jiva_Seal_Hammer_Hit_Combo_to_Heal_displayName = "Safi'Jiva Seal: (Hammer) Hit Combo to Heal";
        public const int Safi_Jiva_Seal_Hammer_Hit_Combo_to_Heal_sortIndex = 41800;
        [SortOrder(Safi_Jiva_Seal_Hammer_Hit_Combo_to_Heal_sortIndex)]
        [DisplayName(Safi_Jiva_Seal_Hammer_Hit_Combo_to_Heal_displayName)]
        public virtual byte Safi_Jiva_Seal_Hammer_Hit_Combo_to_Heal {
            get => GetData<byte>(1943);
            set {
                if (GetData<byte>(1943) == value) return;
                SetData(1943, value, nameof(Safi_Jiva_Seal_Hammer_Hit_Combo_to_Heal));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Safi_Jiva_Seal_Hammer_Hit_Combo_to_Heal));
            }
        }

        public const string Safi_Jiva_Seal_Hunting_Horn_Hit_Combo_to_Heal_displayName = "Safi'Jiva Seal: (Hunting Horn) Hit Combo to Heal";
        public const int Safi_Jiva_Seal_Hunting_Horn_Hit_Combo_to_Heal_sortIndex = 41850;
        [SortOrder(Safi_Jiva_Seal_Hunting_Horn_Hit_Combo_to_Heal_sortIndex)]
        [DisplayName(Safi_Jiva_Seal_Hunting_Horn_Hit_Combo_to_Heal_displayName)]
        public virtual byte Safi_Jiva_Seal_Hunting_Horn_Hit_Combo_to_Heal {
            get => GetData<byte>(1944);
            set {
                if (GetData<byte>(1944) == value) return;
                SetData(1944, value, nameof(Safi_Jiva_Seal_Hunting_Horn_Hit_Combo_to_Heal));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Safi_Jiva_Seal_Hunting_Horn_Hit_Combo_to_Heal));
            }
        }

        public const string Safi_Jiva_Seal_Lance_Hit_Combo_to_Heal_displayName = "Safi'Jiva Seal: (Lance) Hit Combo to Heal";
        public const int Safi_Jiva_Seal_Lance_Hit_Combo_to_Heal_sortIndex = 41900;
        [SortOrder(Safi_Jiva_Seal_Lance_Hit_Combo_to_Heal_sortIndex)]
        [DisplayName(Safi_Jiva_Seal_Lance_Hit_Combo_to_Heal_displayName)]
        public virtual byte Safi_Jiva_Seal_Lance_Hit_Combo_to_Heal {
            get => GetData<byte>(1945);
            set {
                if (GetData<byte>(1945) == value) return;
                SetData(1945, value, nameof(Safi_Jiva_Seal_Lance_Hit_Combo_to_Heal));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Safi_Jiva_Seal_Lance_Hit_Combo_to_Heal));
            }
        }

        public const string Safi_Jiva_Seal_Gunlance_Hit_Combo_to_Heal_displayName = "Safi'Jiva Seal: (Gunlance) Hit Combo to Heal";
        public const int Safi_Jiva_Seal_Gunlance_Hit_Combo_to_Heal_sortIndex = 41950;
        [SortOrder(Safi_Jiva_Seal_Gunlance_Hit_Combo_to_Heal_sortIndex)]
        [DisplayName(Safi_Jiva_Seal_Gunlance_Hit_Combo_to_Heal_displayName)]
        public virtual byte Safi_Jiva_Seal_Gunlance_Hit_Combo_to_Heal {
            get => GetData<byte>(1946);
            set {
                if (GetData<byte>(1946) == value) return;
                SetData(1946, value, nameof(Safi_Jiva_Seal_Gunlance_Hit_Combo_to_Heal));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Safi_Jiva_Seal_Gunlance_Hit_Combo_to_Heal));
            }
        }

        public const string Safi_Jiva_Seal_Switch_Axe_Hit_Combo_to_Heal_displayName = "Safi'Jiva Seal: (Switch Axe) Hit Combo to Heal";
        public const int Safi_Jiva_Seal_Switch_Axe_Hit_Combo_to_Heal_sortIndex = 42000;
        [SortOrder(Safi_Jiva_Seal_Switch_Axe_Hit_Combo_to_Heal_sortIndex)]
        [DisplayName(Safi_Jiva_Seal_Switch_Axe_Hit_Combo_to_Heal_displayName)]
        public virtual byte Safi_Jiva_Seal_Switch_Axe_Hit_Combo_to_Heal {
            get => GetData<byte>(1947);
            set {
                if (GetData<byte>(1947) == value) return;
                SetData(1947, value, nameof(Safi_Jiva_Seal_Switch_Axe_Hit_Combo_to_Heal));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Safi_Jiva_Seal_Switch_Axe_Hit_Combo_to_Heal));
            }
        }

        public const string Safi_Jiva_Seal_Charge_Blade_Hit_Combo_to_Heal_displayName = "Safi'Jiva Seal: (Charge Blade) Hit Combo to Heal";
        public const int Safi_Jiva_Seal_Charge_Blade_Hit_Combo_to_Heal_sortIndex = 42050;
        [SortOrder(Safi_Jiva_Seal_Charge_Blade_Hit_Combo_to_Heal_sortIndex)]
        [DisplayName(Safi_Jiva_Seal_Charge_Blade_Hit_Combo_to_Heal_displayName)]
        public virtual byte Safi_Jiva_Seal_Charge_Blade_Hit_Combo_to_Heal {
            get => GetData<byte>(1948);
            set {
                if (GetData<byte>(1948) == value) return;
                SetData(1948, value, nameof(Safi_Jiva_Seal_Charge_Blade_Hit_Combo_to_Heal));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Safi_Jiva_Seal_Charge_Blade_Hit_Combo_to_Heal));
            }
        }

        public const string Safi_Jiva_Seal_Insect_Glaive_Hit_Combo_to_Heal_displayName = "Safi'Jiva Seal: (Insect Glaive) Hit Combo to Heal";
        public const int Safi_Jiva_Seal_Insect_Glaive_Hit_Combo_to_Heal_sortIndex = 42100;
        [SortOrder(Safi_Jiva_Seal_Insect_Glaive_Hit_Combo_to_Heal_sortIndex)]
        [DisplayName(Safi_Jiva_Seal_Insect_Glaive_Hit_Combo_to_Heal_displayName)]
        public virtual byte Safi_Jiva_Seal_Insect_Glaive_Hit_Combo_to_Heal {
            get => GetData<byte>(1949);
            set {
                if (GetData<byte>(1949) == value) return;
                SetData(1949, value, nameof(Safi_Jiva_Seal_Insect_Glaive_Hit_Combo_to_Heal));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Safi_Jiva_Seal_Insect_Glaive_Hit_Combo_to_Heal));
            }
        }

        public const string Safi_Jiva_Seal_Bow_Hit_Combo_to_Heal_displayName = "Safi'Jiva Seal: (Bow) Hit Combo to Heal";
        public const int Safi_Jiva_Seal_Bow_Hit_Combo_to_Heal_sortIndex = 42150;
        [SortOrder(Safi_Jiva_Seal_Bow_Hit_Combo_to_Heal_sortIndex)]
        [DisplayName(Safi_Jiva_Seal_Bow_Hit_Combo_to_Heal_displayName)]
        public virtual byte Safi_Jiva_Seal_Bow_Hit_Combo_to_Heal {
            get => GetData<byte>(1950);
            set {
                if (GetData<byte>(1950) == value) return;
                SetData(1950, value, nameof(Safi_Jiva_Seal_Bow_Hit_Combo_to_Heal));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Safi_Jiva_Seal_Bow_Hit_Combo_to_Heal));
            }
        }

        public const string Safi_Jiva_Seal_HBG_Hit_Combo_to_Heal_displayName = "Safi'Jiva Seal: (HBG) Hit Combo to Heal";
        public const int Safi_Jiva_Seal_HBG_Hit_Combo_to_Heal_sortIndex = 42200;
        [SortOrder(Safi_Jiva_Seal_HBG_Hit_Combo_to_Heal_sortIndex)]
        [DisplayName(Safi_Jiva_Seal_HBG_Hit_Combo_to_Heal_displayName)]
        public virtual byte Safi_Jiva_Seal_HBG_Hit_Combo_to_Heal {
            get => GetData<byte>(1951);
            set {
                if (GetData<byte>(1951) == value) return;
                SetData(1951, value, nameof(Safi_Jiva_Seal_HBG_Hit_Combo_to_Heal));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Safi_Jiva_Seal_HBG_Hit_Combo_to_Heal));
            }
        }

        public const string Safi_Jiva_Seal_LBG_Hit_Combo_to_Heal_displayName = "Safi'Jiva Seal: (LBG) Hit Combo to Heal";
        public const int Safi_Jiva_Seal_LBG_Hit_Combo_to_Heal_sortIndex = 42250;
        [SortOrder(Safi_Jiva_Seal_LBG_Hit_Combo_to_Heal_sortIndex)]
        [DisplayName(Safi_Jiva_Seal_LBG_Hit_Combo_to_Heal_displayName)]
        public virtual byte Safi_Jiva_Seal_LBG_Hit_Combo_to_Heal {
            get => GetData<byte>(1952);
            set {
                if (GetData<byte>(1952) == value) return;
                SetData(1952, value, nameof(Safi_Jiva_Seal_LBG_Hit_Combo_to_Heal));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Safi_Jiva_Seal_LBG_Hit_Combo_to_Heal));
            }
        }

        public const string __42300_displayName = "-------------------------------------------------------------------------------------------";
        public const int __42300_sortIndex = 42300;
        [SortOrder(__42300_sortIndex)]
        [DisplayName(__42300_displayName)]
        [IsReadOnly]
        public virtual byte __42300 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__42300));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__42300));
            }
        }

        public const string Safi_Jiva_Seal_Great_Sword_HP_Lost_Per_Hit_displayName = "Safi'Jiva Seal: (Great Sword) HP Lost Per Hit";
        public const int Safi_Jiva_Seal_Great_Sword_HP_Lost_Per_Hit_sortIndex = 42350;
        [SortOrder(Safi_Jiva_Seal_Great_Sword_HP_Lost_Per_Hit_sortIndex)]
        [DisplayName(Safi_Jiva_Seal_Great_Sword_HP_Lost_Per_Hit_displayName)]
        public virtual float Safi_Jiva_Seal_Great_Sword_HP_Lost_Per_Hit {
            get => GetData<float>(1953);
            set {
                if (GetData<float>(1953) == value) return;
                SetData(1953, value, nameof(Safi_Jiva_Seal_Great_Sword_HP_Lost_Per_Hit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Safi_Jiva_Seal_Great_Sword_HP_Lost_Per_Hit));
            }
        }

        public const string Safi_Jiva_Seal_Sword_Shield_HP_Lost_Per_Hit_displayName = "Safi'Jiva Seal: (Sword & Shield) HP Lost Per Hit";
        public const int Safi_Jiva_Seal_Sword_Shield_HP_Lost_Per_Hit_sortIndex = 42400;
        [SortOrder(Safi_Jiva_Seal_Sword_Shield_HP_Lost_Per_Hit_sortIndex)]
        [DisplayName(Safi_Jiva_Seal_Sword_Shield_HP_Lost_Per_Hit_displayName)]
        public virtual float Safi_Jiva_Seal_Sword_Shield_HP_Lost_Per_Hit {
            get => GetData<float>(1957);
            set {
                if (GetData<float>(1957) == value) return;
                SetData(1957, value, nameof(Safi_Jiva_Seal_Sword_Shield_HP_Lost_Per_Hit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Safi_Jiva_Seal_Sword_Shield_HP_Lost_Per_Hit));
            }
        }

        public const string Safi_Jiva_Seal_Dual_Blades_HP_Lost_Per_Hit_displayName = "Safi'Jiva Seal: (Dual Blades) HP Lost Per Hit";
        public const int Safi_Jiva_Seal_Dual_Blades_HP_Lost_Per_Hit_sortIndex = 42450;
        [SortOrder(Safi_Jiva_Seal_Dual_Blades_HP_Lost_Per_Hit_sortIndex)]
        [DisplayName(Safi_Jiva_Seal_Dual_Blades_HP_Lost_Per_Hit_displayName)]
        public virtual float Safi_Jiva_Seal_Dual_Blades_HP_Lost_Per_Hit {
            get => GetData<float>(1961);
            set {
                if (GetData<float>(1961) == value) return;
                SetData(1961, value, nameof(Safi_Jiva_Seal_Dual_Blades_HP_Lost_Per_Hit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Safi_Jiva_Seal_Dual_Blades_HP_Lost_Per_Hit));
            }
        }

        public const string Safi_Jiva_Seal_Long_Sword_HP_Lost_Per_Hit_displayName = "Safi'Jiva Seal: (Long Sword) HP Lost Per Hit";
        public const int Safi_Jiva_Seal_Long_Sword_HP_Lost_Per_Hit_sortIndex = 42500;
        [SortOrder(Safi_Jiva_Seal_Long_Sword_HP_Lost_Per_Hit_sortIndex)]
        [DisplayName(Safi_Jiva_Seal_Long_Sword_HP_Lost_Per_Hit_displayName)]
        public virtual float Safi_Jiva_Seal_Long_Sword_HP_Lost_Per_Hit {
            get => GetData<float>(1965);
            set {
                if (GetData<float>(1965) == value) return;
                SetData(1965, value, nameof(Safi_Jiva_Seal_Long_Sword_HP_Lost_Per_Hit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Safi_Jiva_Seal_Long_Sword_HP_Lost_Per_Hit));
            }
        }

        public const string Safi_Jiva_Seal_Hammer_HP_Lost_Per_Hit_displayName = "Safi'Jiva Seal: (Hammer) HP Lost Per Hit";
        public const int Safi_Jiva_Seal_Hammer_HP_Lost_Per_Hit_sortIndex = 42550;
        [SortOrder(Safi_Jiva_Seal_Hammer_HP_Lost_Per_Hit_sortIndex)]
        [DisplayName(Safi_Jiva_Seal_Hammer_HP_Lost_Per_Hit_displayName)]
        public virtual float Safi_Jiva_Seal_Hammer_HP_Lost_Per_Hit {
            get => GetData<float>(1969);
            set {
                if (GetData<float>(1969) == value) return;
                SetData(1969, value, nameof(Safi_Jiva_Seal_Hammer_HP_Lost_Per_Hit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Safi_Jiva_Seal_Hammer_HP_Lost_Per_Hit));
            }
        }

        public const string Safi_Jiva_Seal_Hunting_Horn_HP_Lost_Per_Hit_displayName = "Safi'Jiva Seal: (Hunting Horn) HP Lost Per Hit";
        public const int Safi_Jiva_Seal_Hunting_Horn_HP_Lost_Per_Hit_sortIndex = 42600;
        [SortOrder(Safi_Jiva_Seal_Hunting_Horn_HP_Lost_Per_Hit_sortIndex)]
        [DisplayName(Safi_Jiva_Seal_Hunting_Horn_HP_Lost_Per_Hit_displayName)]
        public virtual float Safi_Jiva_Seal_Hunting_Horn_HP_Lost_Per_Hit {
            get => GetData<float>(1973);
            set {
                if (GetData<float>(1973) == value) return;
                SetData(1973, value, nameof(Safi_Jiva_Seal_Hunting_Horn_HP_Lost_Per_Hit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Safi_Jiva_Seal_Hunting_Horn_HP_Lost_Per_Hit));
            }
        }

        public const string Safi_Jiva_Seal_Lance_HP_Lost_Per_Hit_displayName = "Safi'Jiva Seal: (Lance) HP Lost Per Hit";
        public const int Safi_Jiva_Seal_Lance_HP_Lost_Per_Hit_sortIndex = 42650;
        [SortOrder(Safi_Jiva_Seal_Lance_HP_Lost_Per_Hit_sortIndex)]
        [DisplayName(Safi_Jiva_Seal_Lance_HP_Lost_Per_Hit_displayName)]
        public virtual float Safi_Jiva_Seal_Lance_HP_Lost_Per_Hit {
            get => GetData<float>(1977);
            set {
                if (GetData<float>(1977) == value) return;
                SetData(1977, value, nameof(Safi_Jiva_Seal_Lance_HP_Lost_Per_Hit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Safi_Jiva_Seal_Lance_HP_Lost_Per_Hit));
            }
        }

        public const string Safi_Jiva_Seal_Gunlance_HP_Lost_Per_Hit_displayName = "Safi'Jiva Seal: (Gunlance) HP Lost Per Hit";
        public const int Safi_Jiva_Seal_Gunlance_HP_Lost_Per_Hit_sortIndex = 42700;
        [SortOrder(Safi_Jiva_Seal_Gunlance_HP_Lost_Per_Hit_sortIndex)]
        [DisplayName(Safi_Jiva_Seal_Gunlance_HP_Lost_Per_Hit_displayName)]
        public virtual float Safi_Jiva_Seal_Gunlance_HP_Lost_Per_Hit {
            get => GetData<float>(1981);
            set {
                if (GetData<float>(1981) == value) return;
                SetData(1981, value, nameof(Safi_Jiva_Seal_Gunlance_HP_Lost_Per_Hit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Safi_Jiva_Seal_Gunlance_HP_Lost_Per_Hit));
            }
        }

        public const string Safi_Jiva_Seal_Switch_Axe_HP_Lost_Per_Hit_displayName = "Safi'Jiva Seal: (Switch Axe) HP Lost Per Hit";
        public const int Safi_Jiva_Seal_Switch_Axe_HP_Lost_Per_Hit_sortIndex = 42750;
        [SortOrder(Safi_Jiva_Seal_Switch_Axe_HP_Lost_Per_Hit_sortIndex)]
        [DisplayName(Safi_Jiva_Seal_Switch_Axe_HP_Lost_Per_Hit_displayName)]
        public virtual float Safi_Jiva_Seal_Switch_Axe_HP_Lost_Per_Hit {
            get => GetData<float>(1985);
            set {
                if (GetData<float>(1985) == value) return;
                SetData(1985, value, nameof(Safi_Jiva_Seal_Switch_Axe_HP_Lost_Per_Hit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Safi_Jiva_Seal_Switch_Axe_HP_Lost_Per_Hit));
            }
        }

        public const string Safi_Jiva_Seal_Charge_Blade_HP_Lost_Per_Hit_displayName = "Safi'Jiva Seal: (Charge Blade) HP Lost Per Hit";
        public const int Safi_Jiva_Seal_Charge_Blade_HP_Lost_Per_Hit_sortIndex = 42800;
        [SortOrder(Safi_Jiva_Seal_Charge_Blade_HP_Lost_Per_Hit_sortIndex)]
        [DisplayName(Safi_Jiva_Seal_Charge_Blade_HP_Lost_Per_Hit_displayName)]
        public virtual float Safi_Jiva_Seal_Charge_Blade_HP_Lost_Per_Hit {
            get => GetData<float>(1989);
            set {
                if (GetData<float>(1989) == value) return;
                SetData(1989, value, nameof(Safi_Jiva_Seal_Charge_Blade_HP_Lost_Per_Hit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Safi_Jiva_Seal_Charge_Blade_HP_Lost_Per_Hit));
            }
        }

        public const string Safi_Jiva_Seal_Insect_Glaive_HP_Lost_Per_Hit_displayName = "Safi'Jiva Seal: (Insect Glaive) HP Lost Per Hit";
        public const int Safi_Jiva_Seal_Insect_Glaive_HP_Lost_Per_Hit_sortIndex = 42850;
        [SortOrder(Safi_Jiva_Seal_Insect_Glaive_HP_Lost_Per_Hit_sortIndex)]
        [DisplayName(Safi_Jiva_Seal_Insect_Glaive_HP_Lost_Per_Hit_displayName)]
        public virtual float Safi_Jiva_Seal_Insect_Glaive_HP_Lost_Per_Hit {
            get => GetData<float>(1993);
            set {
                if (GetData<float>(1993) == value) return;
                SetData(1993, value, nameof(Safi_Jiva_Seal_Insect_Glaive_HP_Lost_Per_Hit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Safi_Jiva_Seal_Insect_Glaive_HP_Lost_Per_Hit));
            }
        }

        public const string Safi_Jiva_Seal_Bow_HP_Lost_Per_Hit_displayName = "Safi'Jiva Seal: (Bow) HP Lost Per Hit";
        public const int Safi_Jiva_Seal_Bow_HP_Lost_Per_Hit_sortIndex = 42900;
        [SortOrder(Safi_Jiva_Seal_Bow_HP_Lost_Per_Hit_sortIndex)]
        [DisplayName(Safi_Jiva_Seal_Bow_HP_Lost_Per_Hit_displayName)]
        public virtual float Safi_Jiva_Seal_Bow_HP_Lost_Per_Hit {
            get => GetData<float>(1997);
            set {
                if (GetData<float>(1997) == value) return;
                SetData(1997, value, nameof(Safi_Jiva_Seal_Bow_HP_Lost_Per_Hit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Safi_Jiva_Seal_Bow_HP_Lost_Per_Hit));
            }
        }

        public const string Safi_Jiva_Seal_HBG_HP_Lost_Per_Hit_displayName = "Safi'Jiva Seal: (HBG) HP Lost Per Hit";
        public const int Safi_Jiva_Seal_HBG_HP_Lost_Per_Hit_sortIndex = 42950;
        [SortOrder(Safi_Jiva_Seal_HBG_HP_Lost_Per_Hit_sortIndex)]
        [DisplayName(Safi_Jiva_Seal_HBG_HP_Lost_Per_Hit_displayName)]
        public virtual float Safi_Jiva_Seal_HBG_HP_Lost_Per_Hit {
            get => GetData<float>(2001);
            set {
                if (GetData<float>(2001) == value) return;
                SetData(2001, value, nameof(Safi_Jiva_Seal_HBG_HP_Lost_Per_Hit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Safi_Jiva_Seal_HBG_HP_Lost_Per_Hit));
            }
        }

        public const string Safi_Jiva_Seal_LBG_HP_Lost_Per_Hit_displayName = "Safi'Jiva Seal: (LBG) HP Lost Per Hit";
        public const int Safi_Jiva_Seal_LBG_HP_Lost_Per_Hit_sortIndex = 43000;
        [SortOrder(Safi_Jiva_Seal_LBG_HP_Lost_Per_Hit_sortIndex)]
        [DisplayName(Safi_Jiva_Seal_LBG_HP_Lost_Per_Hit_displayName)]
        public virtual float Safi_Jiva_Seal_LBG_HP_Lost_Per_Hit {
            get => GetData<float>(2005);
            set {
                if (GetData<float>(2005) == value) return;
                SetData(2005, value, nameof(Safi_Jiva_Seal_LBG_HP_Lost_Per_Hit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Safi_Jiva_Seal_LBG_HP_Lost_Per_Hit));
            }
        }

        public const string __43050_displayName = "-------------------------------------------------------------------------------------------";
        public const int __43050_sortIndex = 43050;
        [SortOrder(__43050_sortIndex)]
        [DisplayName(__43050_displayName)]
        [IsReadOnly]
        public virtual byte __43050 {
            get => GetData<byte>(3);
            set {
                if (GetData<byte>(3) == value) return;
                SetData(3, value, nameof(__43050));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__43050));
            }
        }

        public const string Safi_Recovery_Interval_displayName = "Safi: Recovery Interval";
        public const int Safi_Recovery_Interval_sortIndex = 43100;
        [SortOrder(Safi_Recovery_Interval_sortIndex)]
        [DisplayName(Safi_Recovery_Interval_displayName)]
        public virtual float Safi_Recovery_Interval {
            get => GetData<float>(2009);
            set {
                if (GetData<float>(2009) == value) return;
                SetData(2009, value, nameof(Safi_Recovery_Interval));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Safi_Recovery_Interval));
            }
        }

        public const string Safi_Recovery_Amount_displayName = "Safi: Recovery Amount";
        public const int Safi_Recovery_Amount_sortIndex = 43150;
        [SortOrder(Safi_Recovery_Amount_sortIndex)]
        [DisplayName(Safi_Recovery_Amount_displayName)]
        public virtual float Safi_Recovery_Amount {
            get => GetData<float>(2013);
            set {
                if (GetData<float>(2013) == value) return;
                SetData(2013, value, nameof(Safi_Recovery_Amount));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Safi_Recovery_Amount));
            }
        }

        public const string Safi_Recovery_Time_displayName = "Safi: Recovery Time";
        public const int Safi_Recovery_Time_sortIndex = 43200;
        [SortOrder(Safi_Recovery_Time_sortIndex)]
        [DisplayName(Safi_Recovery_Time_displayName)]
        public virtual float Safi_Recovery_Time {
            get => GetData<float>(2017);
            set {
                if (GetData<float>(2017) == value) return;
                SetData(2017, value, nameof(Safi_Recovery_Time));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Safi_Recovery_Time));
            }
        }

        public const string Unk_Safi_8_displayName = "Unk Safi 8";
        public const int Unk_Safi_8_sortIndex = 43250;
        [SortOrder(Unk_Safi_8_sortIndex)]
        [DisplayName(Unk_Safi_8_displayName)]
        public virtual float Unk_Safi_8 {
            get => GetData<float>(2021);
            set {
                if (GetData<float>(2021) == value) return;
                SetData(2021, value, nameof(Unk_Safi_8));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk_Safi_8));
            }
        }

        public const string Set_3_Elemental_Limit_displayName = "Set(3) Elemental Limit";
        public const int Set_3_Elemental_Limit_sortIndex = 43300;
        [SortOrder(Set_3_Elemental_Limit_sortIndex)]
        [DisplayName(Set_3_Elemental_Limit_displayName)]
        public virtual float Set_3_Elemental_Limit {
            get => GetData<float>(2025);
            set {
                if (GetData<float>(2025) == value) return;
                SetData(2025, value, nameof(Set_3_Elemental_Limit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Set_3_Elemental_Limit));
            }
        }

        public const string Set_5_Elemental_Limit_displayName = "Set(5) Elemental Limit";
        public const int Set_5_Elemental_Limit_sortIndex = 43350;
        [SortOrder(Set_5_Elemental_Limit_sortIndex)]
        [DisplayName(Set_5_Elemental_Limit_displayName)]
        public virtual float Set_5_Elemental_Limit {
            get => GetData<float>(2029);
            set {
                if (GetData<float>(2029) == value) return;
                SetData(2029, value, nameof(Set_5_Elemental_Limit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Set_5_Elemental_Limit));
            }
        }

        public const string Set_3_Bowgun_Elemental_Limit_displayName = "Set(3) Bowgun Elemental Limit";
        public const int Set_3_Bowgun_Elemental_Limit_sortIndex = 43400;
        [SortOrder(Set_3_Bowgun_Elemental_Limit_sortIndex)]
        [DisplayName(Set_3_Bowgun_Elemental_Limit_displayName)]
        public virtual float Set_3_Bowgun_Elemental_Limit {
            get => GetData<float>(2033);
            set {
                if (GetData<float>(2033) == value) return;
                SetData(2033, value, nameof(Set_3_Bowgun_Elemental_Limit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Set_3_Bowgun_Elemental_Limit));
            }
        }

        public const string Set_5_Bowgun_Elemental_Limit_displayName = "Set(5) Bowgun Elemental Limit";
        public const int Set_5_Bowgun_Elemental_Limit_sortIndex = 43450;
        [SortOrder(Set_5_Bowgun_Elemental_Limit_sortIndex)]
        [DisplayName(Set_5_Bowgun_Elemental_Limit_displayName)]
        public virtual float Set_5_Bowgun_Elemental_Limit {
            get => GetData<float>(2037);
            set {
                if (GetData<float>(2037) == value) return;
                SetData(2037, value, nameof(Set_5_Bowgun_Elemental_Limit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Set_5_Bowgun_Elemental_Limit));
            }
        }

        public const string Set_3_Status_Limit_displayName = "Set(3) Status Limit";
        public const int Set_3_Status_Limit_sortIndex = 43500;
        [SortOrder(Set_3_Status_Limit_sortIndex)]
        [DisplayName(Set_3_Status_Limit_displayName)]
        public virtual float Set_3_Status_Limit {
            get => GetData<float>(2041);
            set {
                if (GetData<float>(2041) == value) return;
                SetData(2041, value, nameof(Set_3_Status_Limit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Set_3_Status_Limit));
            }
        }

        public const string Set_5_Status_Limit_displayName = "Set(5) Status Limit";
        public const int Set_5_Status_Limit_sortIndex = 43550;
        [SortOrder(Set_5_Status_Limit_sortIndex)]
        [DisplayName(Set_5_Status_Limit_displayName)]
        public virtual float Set_5_Status_Limit {
            get => GetData<float>(2045);
            set {
                if (GetData<float>(2045) == value) return;
                SetData(2045, value, nameof(Set_5_Status_Limit));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Set_5_Status_Limit));
            }
        }

        public const string __43600_displayName = "-------------------------------------------------------------------------------------------";
        public const int __43600_sortIndex = 43600;
        [SortOrder(__43600_sortIndex)]
        [DisplayName(__43600_displayName)]
        [IsReadOnly]
        public virtual byte __43600 {
            get => GetData<byte>(162);
            set {
                if (GetData<byte>(162) == value) return;
                SetData(162, value, nameof(__43600));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__43600));
            }
        }

        public const string Food_Effect_Life_Up_1_displayName = "Food Effect: Life Up 1";
        public const int Food_Effect_Life_Up_1_sortIndex = 43650;
        [SortOrder(Food_Effect_Life_Up_1_sortIndex)]
        [DisplayName(Food_Effect_Life_Up_1_displayName)]
        public virtual ushort Food_Effect_Life_Up_1 {
            get => GetData<ushort>(2049);
            set {
                if (GetData<ushort>(2049) == value) return;
                SetData(2049, value, nameof(Food_Effect_Life_Up_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Food_Effect_Life_Up_1));
            }
        }

        public const string Food_Effect_Life_Up_2_displayName = "Food Effect: Life Up 2";
        public const int Food_Effect_Life_Up_2_sortIndex = 43700;
        [SortOrder(Food_Effect_Life_Up_2_sortIndex)]
        [DisplayName(Food_Effect_Life_Up_2_displayName)]
        public virtual ushort Food_Effect_Life_Up_2 {
            get => GetData<ushort>(2051);
            set {
                if (GetData<ushort>(2051) == value) return;
                SetData(2051, value, nameof(Food_Effect_Life_Up_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Food_Effect_Life_Up_2));
            }
        }

        public const string Food_Effect_Life_Up_3_displayName = "Food Effect: Life Up 3";
        public const int Food_Effect_Life_Up_3_sortIndex = 43750;
        [SortOrder(Food_Effect_Life_Up_3_sortIndex)]
        [DisplayName(Food_Effect_Life_Up_3_displayName)]
        public virtual ushort Food_Effect_Life_Up_3 {
            get => GetData<ushort>(2053);
            set {
                if (GetData<ushort>(2053) == value) return;
                SetData(2053, value, nameof(Food_Effect_Life_Up_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Food_Effect_Life_Up_3));
            }
        }

        public const string Food_Effect_Life_Up_4_displayName = "Food Effect: Life Up 4";
        public const int Food_Effect_Life_Up_4_sortIndex = 43800;
        [SortOrder(Food_Effect_Life_Up_4_sortIndex)]
        [DisplayName(Food_Effect_Life_Up_4_displayName)]
        public virtual ushort Food_Effect_Life_Up_4 {
            get => GetData<ushort>(2055);
            set {
                if (GetData<ushort>(2055) == value) return;
                SetData(2055, value, nameof(Food_Effect_Life_Up_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Food_Effect_Life_Up_4));
            }
        }

        public const string Food_Effect_Life_Up_5_displayName = "Food Effect: Life Up 5";
        public const int Food_Effect_Life_Up_5_sortIndex = 43850;
        [SortOrder(Food_Effect_Life_Up_5_sortIndex)]
        [DisplayName(Food_Effect_Life_Up_5_displayName)]
        public virtual ushort Food_Effect_Life_Up_5 {
            get => GetData<ushort>(2057);
            set {
                if (GetData<ushort>(2057) == value) return;
                SetData(2057, value, nameof(Food_Effect_Life_Up_5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Food_Effect_Life_Up_5));
            }
        }

        public const string Food_Effect_Life_Up_6_displayName = "Food Effect: Life Up 6";
        public const int Food_Effect_Life_Up_6_sortIndex = 43900;
        [SortOrder(Food_Effect_Life_Up_6_sortIndex)]
        [DisplayName(Food_Effect_Life_Up_6_displayName)]
        public virtual ushort Food_Effect_Life_Up_6 {
            get => GetData<ushort>(2059);
            set {
                if (GetData<ushort>(2059) == value) return;
                SetData(2059, value, nameof(Food_Effect_Life_Up_6));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Food_Effect_Life_Up_6));
            }
        }

        public const string __43950_displayName = "-------------------------------------------------------------------------------------------";
        public const int __43950_sortIndex = 43950;
        [SortOrder(__43950_sortIndex)]
        [DisplayName(__43950_displayName)]
        [IsReadOnly]
        public virtual byte __43950 {
            get => GetData<byte>(162);
            set {
                if (GetData<byte>(162) == value) return;
                SetData(162, value, nameof(__43950));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__43950));
            }
        }

        public const string Food_Effect_Stamina_Up_1_displayName = "Food Effect: Stamina Up 1";
        public const int Food_Effect_Stamina_Up_1_sortIndex = 44000;
        [SortOrder(Food_Effect_Stamina_Up_1_sortIndex)]
        [DisplayName(Food_Effect_Stamina_Up_1_displayName)]
        public virtual ushort Food_Effect_Stamina_Up_1 {
            get => GetData<ushort>(2061);
            set {
                if (GetData<ushort>(2061) == value) return;
                SetData(2061, value, nameof(Food_Effect_Stamina_Up_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Food_Effect_Stamina_Up_1));
            }
        }

        public const string Food_Effect_Stamina_Up_2_displayName = "Food Effect: Stamina Up 2";
        public const int Food_Effect_Stamina_Up_2_sortIndex = 44050;
        [SortOrder(Food_Effect_Stamina_Up_2_sortIndex)]
        [DisplayName(Food_Effect_Stamina_Up_2_displayName)]
        public virtual ushort Food_Effect_Stamina_Up_2 {
            get => GetData<ushort>(2063);
            set {
                if (GetData<ushort>(2063) == value) return;
                SetData(2063, value, nameof(Food_Effect_Stamina_Up_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Food_Effect_Stamina_Up_2));
            }
        }

        public const string Food_Effect_Stamina_Up_3_displayName = "Food Effect: Stamina Up 3";
        public const int Food_Effect_Stamina_Up_3_sortIndex = 44100;
        [SortOrder(Food_Effect_Stamina_Up_3_sortIndex)]
        [DisplayName(Food_Effect_Stamina_Up_3_displayName)]
        public virtual ushort Food_Effect_Stamina_Up_3 {
            get => GetData<ushort>(2065);
            set {
                if (GetData<ushort>(2065) == value) return;
                SetData(2065, value, nameof(Food_Effect_Stamina_Up_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Food_Effect_Stamina_Up_3));
            }
        }

        public const string __44150_displayName = "-------------------------------------------------------------------------------------------";
        public const int __44150_sortIndex = 44150;
        [SortOrder(__44150_sortIndex)]
        [DisplayName(__44150_displayName)]
        [IsReadOnly]
        public virtual byte __44150 {
            get => GetData<byte>(162);
            set {
                if (GetData<byte>(162) == value) return;
                SetData(162, value, nameof(__44150));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__44150));
            }
        }

        public const string Food_Effect_Attack_Up_1_displayName = "Food Effect: Attack Up 1";
        public const int Food_Effect_Attack_Up_1_sortIndex = 44200;
        [SortOrder(Food_Effect_Attack_Up_1_sortIndex)]
        [DisplayName(Food_Effect_Attack_Up_1_displayName)]
        public virtual ushort Food_Effect_Attack_Up_1 {
            get => GetData<ushort>(2067);
            set {
                if (GetData<ushort>(2067) == value) return;
                SetData(2067, value, nameof(Food_Effect_Attack_Up_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Food_Effect_Attack_Up_1));
            }
        }

        public const string Food_Effect_Attack_Up_2_displayName = "Food Effect: Attack Up 2";
        public const int Food_Effect_Attack_Up_2_sortIndex = 44250;
        [SortOrder(Food_Effect_Attack_Up_2_sortIndex)]
        [DisplayName(Food_Effect_Attack_Up_2_displayName)]
        public virtual ushort Food_Effect_Attack_Up_2 {
            get => GetData<ushort>(2069);
            set {
                if (GetData<ushort>(2069) == value) return;
                SetData(2069, value, nameof(Food_Effect_Attack_Up_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Food_Effect_Attack_Up_2));
            }
        }

        public const string Food_Effect_Attack_Up_3_displayName = "Food Effect: Attack Up 3";
        public const int Food_Effect_Attack_Up_3_sortIndex = 44300;
        [SortOrder(Food_Effect_Attack_Up_3_sortIndex)]
        [DisplayName(Food_Effect_Attack_Up_3_displayName)]
        public virtual ushort Food_Effect_Attack_Up_3 {
            get => GetData<ushort>(2071);
            set {
                if (GetData<ushort>(2071) == value) return;
                SetData(2071, value, nameof(Food_Effect_Attack_Up_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Food_Effect_Attack_Up_3));
            }
        }

        public const string Food_Effect_Attack_Up_4_displayName = "Food Effect: Attack Up 4";
        public const int Food_Effect_Attack_Up_4_sortIndex = 44350;
        [SortOrder(Food_Effect_Attack_Up_4_sortIndex)]
        [DisplayName(Food_Effect_Attack_Up_4_displayName)]
        public virtual ushort Food_Effect_Attack_Up_4 {
            get => GetData<ushort>(2073);
            set {
                if (GetData<ushort>(2073) == value) return;
                SetData(2073, value, nameof(Food_Effect_Attack_Up_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Food_Effect_Attack_Up_4));
            }
        }

        public const string __44400_displayName = "-------------------------------------------------------------------------------------------";
        public const int __44400_sortIndex = 44400;
        [SortOrder(__44400_sortIndex)]
        [DisplayName(__44400_displayName)]
        [IsReadOnly]
        public virtual byte __44400 {
            get => GetData<byte>(162);
            set {
                if (GetData<byte>(162) == value) return;
                SetData(162, value, nameof(__44400));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__44400));
            }
        }

        public const string Food_Effect_Defense_Up_1_displayName = "Food Effect: Defense Up 1";
        public const int Food_Effect_Defense_Up_1_sortIndex = 44450;
        [SortOrder(Food_Effect_Defense_Up_1_sortIndex)]
        [DisplayName(Food_Effect_Defense_Up_1_displayName)]
        public virtual ushort Food_Effect_Defense_Up_1 {
            get => GetData<ushort>(2075);
            set {
                if (GetData<ushort>(2075) == value) return;
                SetData(2075, value, nameof(Food_Effect_Defense_Up_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Food_Effect_Defense_Up_1));
            }
        }

        public const string Food_Effect_Defense_Up_2_displayName = "Food Effect: Defense Up 2";
        public const int Food_Effect_Defense_Up_2_sortIndex = 44500;
        [SortOrder(Food_Effect_Defense_Up_2_sortIndex)]
        [DisplayName(Food_Effect_Defense_Up_2_displayName)]
        public virtual ushort Food_Effect_Defense_Up_2 {
            get => GetData<ushort>(2077);
            set {
                if (GetData<ushort>(2077) == value) return;
                SetData(2077, value, nameof(Food_Effect_Defense_Up_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Food_Effect_Defense_Up_2));
            }
        }

        public const string Food_Effect_Defense_Up_3_displayName = "Food Effect: Defense Up 3";
        public const int Food_Effect_Defense_Up_3_sortIndex = 44550;
        [SortOrder(Food_Effect_Defense_Up_3_sortIndex)]
        [DisplayName(Food_Effect_Defense_Up_3_displayName)]
        public virtual ushort Food_Effect_Defense_Up_3 {
            get => GetData<ushort>(2079);
            set {
                if (GetData<ushort>(2079) == value) return;
                SetData(2079, value, nameof(Food_Effect_Defense_Up_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Food_Effect_Defense_Up_3));
            }
        }

        public const string Food_Effect_Defense_Up_4_displayName = "Food Effect: Defense Up 4";
        public const int Food_Effect_Defense_Up_4_sortIndex = 44600;
        [SortOrder(Food_Effect_Defense_Up_4_sortIndex)]
        [DisplayName(Food_Effect_Defense_Up_4_displayName)]
        public virtual ushort Food_Effect_Defense_Up_4 {
            get => GetData<ushort>(2081);
            set {
                if (GetData<ushort>(2081) == value) return;
                SetData(2081, value, nameof(Food_Effect_Defense_Up_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Food_Effect_Defense_Up_4));
            }
        }

        public const string __44650_displayName = "-------------------------------------------------------------------------------------------";
        public const int __44650_sortIndex = 44650;
        [SortOrder(__44650_sortIndex)]
        [DisplayName(__44650_displayName)]
        [IsReadOnly]
        public virtual byte __44650 {
            get => GetData<byte>(162);
            set {
                if (GetData<byte>(162) == value) return;
                SetData(162, value, nameof(__44650));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__44650));
            }
        }

        public const string Food_Effect_All_Resistances_Up_1_displayName = "Food Effect: All Resistances Up 1";
        public const int Food_Effect_All_Resistances_Up_1_sortIndex = 44700;
        [SortOrder(Food_Effect_All_Resistances_Up_1_sortIndex)]
        [DisplayName(Food_Effect_All_Resistances_Up_1_displayName)]
        public virtual ushort Food_Effect_All_Resistances_Up_1 {
            get => GetData<ushort>(2083);
            set {
                if (GetData<ushort>(2083) == value) return;
                SetData(2083, value, nameof(Food_Effect_All_Resistances_Up_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Food_Effect_All_Resistances_Up_1));
            }
        }

        public const string Food_Effect_All_Resistances_Up_2_displayName = "Food Effect: All Resistances Up 2";
        public const int Food_Effect_All_Resistances_Up_2_sortIndex = 44750;
        [SortOrder(Food_Effect_All_Resistances_Up_2_sortIndex)]
        [DisplayName(Food_Effect_All_Resistances_Up_2_displayName)]
        public virtual ushort Food_Effect_All_Resistances_Up_2 {
            get => GetData<ushort>(2085);
            set {
                if (GetData<ushort>(2085) == value) return;
                SetData(2085, value, nameof(Food_Effect_All_Resistances_Up_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Food_Effect_All_Resistances_Up_2));
            }
        }

        public const string Food_Effect_All_Resistances_Up_3_displayName = "Food Effect: All Resistances Up 3";
        public const int Food_Effect_All_Resistances_Up_3_sortIndex = 44800;
        [SortOrder(Food_Effect_All_Resistances_Up_3_sortIndex)]
        [DisplayName(Food_Effect_All_Resistances_Up_3_displayName)]
        public virtual ushort Food_Effect_All_Resistances_Up_3 {
            get => GetData<ushort>(2087);
            set {
                if (GetData<ushort>(2087) == value) return;
                SetData(2087, value, nameof(Food_Effect_All_Resistances_Up_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Food_Effect_All_Resistances_Up_3));
            }
        }

        public const string Food_Effect_All_Resistances_Up_4_displayName = "Food Effect: All Resistances Up 4";
        public const int Food_Effect_All_Resistances_Up_4_sortIndex = 44850;
        [SortOrder(Food_Effect_All_Resistances_Up_4_sortIndex)]
        [DisplayName(Food_Effect_All_Resistances_Up_4_displayName)]
        public virtual ushort Food_Effect_All_Resistances_Up_4 {
            get => GetData<ushort>(2089);
            set {
                if (GetData<ushort>(2089) == value) return;
                SetData(2089, value, nameof(Food_Effect_All_Resistances_Up_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Food_Effect_All_Resistances_Up_4));
            }
        }

        public const string __44900_displayName = "-------------------------------------------------------------------------------------------";
        public const int __44900_sortIndex = 44900;
        [SortOrder(__44900_sortIndex)]
        [DisplayName(__44900_displayName)]
        [IsReadOnly]
        public virtual byte __44900 {
            get => GetData<byte>(162);
            set {
                if (GetData<byte>(162) == value) return;
                SetData(162, value, nameof(__44900));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__44900));
            }
        }

        public const string Feline_Polisher_1_displayName = "Feline Polisher: % 1";
        public const int Feline_Polisher_1_sortIndex = 44950;
        [SortOrder(Feline_Polisher_1_sortIndex)]
        [DisplayName(Feline_Polisher_1_displayName)]
        public virtual byte Feline_Polisher_1 {
            get => GetData<byte>(2091);
            set {
                if (GetData<byte>(2091) == value) return;
                SetData(2091, value, nameof(Feline_Polisher_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Polisher_1));
            }
        }

        public const string Feline_Polisher_2_displayName = "Feline Polisher: % 2";
        public const int Feline_Polisher_2_sortIndex = 45000;
        [SortOrder(Feline_Polisher_2_sortIndex)]
        [DisplayName(Feline_Polisher_2_displayName)]
        public virtual byte Feline_Polisher_2 {
            get => GetData<byte>(2092);
            set {
                if (GetData<byte>(2092) == value) return;
                SetData(2092, value, nameof(Feline_Polisher_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Polisher_2));
            }
        }

        public const string Feline_Polisher_3_displayName = "Feline Polisher: % 3";
        public const int Feline_Polisher_3_sortIndex = 45050;
        [SortOrder(Feline_Polisher_3_sortIndex)]
        [DisplayName(Feline_Polisher_3_displayName)]
        public virtual byte Feline_Polisher_3 {
            get => GetData<byte>(2093);
            set {
                if (GetData<byte>(2093) == value) return;
                SetData(2093, value, nameof(Feline_Polisher_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Polisher_3));
            }
        }

        public const string Feline_Polisher_Loop_1_displayName = "Feline Polisher: Loop # 1";
        public const int Feline_Polisher_Loop_1_sortIndex = 45100;
        [SortOrder(Feline_Polisher_Loop_1_sortIndex)]
        [DisplayName(Feline_Polisher_Loop_1_displayName)]
        public virtual byte Feline_Polisher_Loop_1 {
            get => GetData<byte>(2094);
            set {
                if (GetData<byte>(2094) == value) return;
                SetData(2094, value, nameof(Feline_Polisher_Loop_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Polisher_Loop_1));
            }
        }

        public const string Feline_Polisher_Loop_2_displayName = "Feline Polisher: Loop # 2";
        public const int Feline_Polisher_Loop_2_sortIndex = 45150;
        [SortOrder(Feline_Polisher_Loop_2_sortIndex)]
        [DisplayName(Feline_Polisher_Loop_2_displayName)]
        public virtual byte Feline_Polisher_Loop_2 {
            get => GetData<byte>(2095);
            set {
                if (GetData<byte>(2095) == value) return;
                SetData(2095, value, nameof(Feline_Polisher_Loop_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Polisher_Loop_2));
            }
        }

        public const string Feline_Polisher_Loop_3_displayName = "Feline Polisher: Loop # 3";
        public const int Feline_Polisher_Loop_3_sortIndex = 45200;
        [SortOrder(Feline_Polisher_Loop_3_sortIndex)]
        [DisplayName(Feline_Polisher_Loop_3_displayName)]
        public virtual byte Feline_Polisher_Loop_3 {
            get => GetData<byte>(2096);
            set {
                if (GetData<byte>(2096) == value) return;
                SetData(2096, value, nameof(Feline_Polisher_Loop_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Polisher_Loop_3));
            }
        }

        public const string __45250_displayName = "-------------------------------------------------------------------------------------------";
        public const int __45250_sortIndex = 45250;
        [SortOrder(__45250_sortIndex)]
        [DisplayName(__45250_displayName)]
        [IsReadOnly]
        public virtual byte __45250 {
            get => GetData<byte>(162);
            set {
                if (GetData<byte>(162) == value) return;
                SetData(162, value, nameof(__45250));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__45250));
            }
        }

        public const string Feline_Rider_Attack_Rate_displayName = "Feline Rider: Attack Rate";
        public const int Feline_Rider_Attack_Rate_sortIndex = 45300;
        [SortOrder(Feline_Rider_Attack_Rate_sortIndex)]
        [DisplayName(Feline_Rider_Attack_Rate_displayName)]
        public virtual float Feline_Rider_Attack_Rate {
            get => GetData<float>(2097);
            set {
                if (GetData<float>(2097) == value) return;
                SetData(2097, value, nameof(Feline_Rider_Attack_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Rider_Attack_Rate));
            }
        }

        public const string __45350_displayName = "-------------------------------------------------------------------------------------------";
        public const int __45350_sortIndex = 45350;
        [SortOrder(__45350_sortIndex)]
        [DisplayName(__45350_displayName)]
        [IsReadOnly]
        public virtual byte __45350 {
            get => GetData<byte>(162);
            set {
                if (GetData<byte>(162) == value) return;
                SetData(162, value, nameof(__45350));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__45350));
            }
        }

        public const string Feline_Heroics_Attack_Rate_displayName = "Feline Heroics: Attack Rate";
        public const int Feline_Heroics_Attack_Rate_sortIndex = 45400;
        [SortOrder(Feline_Heroics_Attack_Rate_sortIndex)]
        [DisplayName(Feline_Heroics_Attack_Rate_displayName)]
        public virtual float Feline_Heroics_Attack_Rate {
            get => GetData<float>(2101);
            set {
                if (GetData<float>(2101) == value) return;
                SetData(2101, value, nameof(Feline_Heroics_Attack_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Heroics_Attack_Rate));
            }
        }

        public const string Feline_Heroics_Defense_Rate_displayName = "Feline Heroics: Defense Rate";
        public const int Feline_Heroics_Defense_Rate_sortIndex = 45450;
        [SortOrder(Feline_Heroics_Defense_Rate_sortIndex)]
        [DisplayName(Feline_Heroics_Defense_Rate_displayName)]
        public virtual float Feline_Heroics_Defense_Rate {
            get => GetData<float>(2105);
            set {
                if (GetData<float>(2105) == value) return;
                SetData(2105, value, nameof(Feline_Heroics_Defense_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Heroics_Defense_Rate));
            }
        }

        public const string Feline_Heroics_Life_Activation_Threshold_displayName = "Feline Heroics: Life Activation Threshold";
        public const int Feline_Heroics_Life_Activation_Threshold_sortIndex = 45500;
        [SortOrder(Feline_Heroics_Life_Activation_Threshold_sortIndex)]
        [DisplayName(Feline_Heroics_Life_Activation_Threshold_displayName)]
        public virtual byte Feline_Heroics_Life_Activation_Threshold {
            get => GetData<byte>(2109);
            set {
                if (GetData<byte>(2109) == value) return;
                SetData(2109, value, nameof(Feline_Heroics_Life_Activation_Threshold));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Heroics_Life_Activation_Threshold));
            }
        }

        public const string __45550_displayName = "-------------------------------------------------------------------------------------------";
        public const int __45550_sortIndex = 45550;
        [SortOrder(__45550_sortIndex)]
        [DisplayName(__45550_displayName)]
        [IsReadOnly]
        public virtual byte __45550 {
            get => GetData<byte>(162);
            set {
                if (GetData<byte>(162) == value) return;
                SetData(162, value, nameof(__45550));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__45550));
            }
        }

        public const string Feline_Carving_L_Lottery_1_displayName = "Feline Carving L: Lottery % 1";
        public const int Feline_Carving_L_Lottery_1_sortIndex = 45600;
        [SortOrder(Feline_Carving_L_Lottery_1_sortIndex)]
        [DisplayName(Feline_Carving_L_Lottery_1_displayName)]
        public virtual byte Feline_Carving_L_Lottery_1 {
            get => GetData<byte>(2110);
            set {
                if (GetData<byte>(2110) == value) return;
                SetData(2110, value, nameof(Feline_Carving_L_Lottery_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Carving_L_Lottery_1));
            }
        }

        public const string Feline_Carving_L_Lottery_2_displayName = "Feline Carving L: Lottery % 2";
        public const int Feline_Carving_L_Lottery_2_sortIndex = 45650;
        [SortOrder(Feline_Carving_L_Lottery_2_sortIndex)]
        [DisplayName(Feline_Carving_L_Lottery_2_displayName)]
        public virtual byte Feline_Carving_L_Lottery_2 {
            get => GetData<byte>(2111);
            set {
                if (GetData<byte>(2111) == value) return;
                SetData(2111, value, nameof(Feline_Carving_L_Lottery_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Carving_L_Lottery_2));
            }
        }

        public const string Feline_Carving_L_Lottery_3_displayName = "Feline Carving L: Lottery % 3";
        public const int Feline_Carving_L_Lottery_3_sortIndex = 45700;
        [SortOrder(Feline_Carving_L_Lottery_3_sortIndex)]
        [DisplayName(Feline_Carving_L_Lottery_3_displayName)]
        public virtual byte Feline_Carving_L_Lottery_3 {
            get => GetData<byte>(2112);
            set {
                if (GetData<byte>(2112) == value) return;
                SetData(2112, value, nameof(Feline_Carving_L_Lottery_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Carving_L_Lottery_3));
            }
        }

        public const string Feline_Carving_L_Up_1_displayName = "Feline Carving L: Up % 1";
        public const int Feline_Carving_L_Up_1_sortIndex = 45750;
        [SortOrder(Feline_Carving_L_Up_1_sortIndex)]
        [DisplayName(Feline_Carving_L_Up_1_displayName)]
        public virtual byte Feline_Carving_L_Up_1 {
            get => GetData<byte>(2113);
            set {
                if (GetData<byte>(2113) == value) return;
                SetData(2113, value, nameof(Feline_Carving_L_Up_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Carving_L_Up_1));
            }
        }

        public const string Feline_Carving_L_Up_2_displayName = "Feline Carving L: Up % 2";
        public const int Feline_Carving_L_Up_2_sortIndex = 45800;
        [SortOrder(Feline_Carving_L_Up_2_sortIndex)]
        [DisplayName(Feline_Carving_L_Up_2_displayName)]
        public virtual byte Feline_Carving_L_Up_2 {
            get => GetData<byte>(2114);
            set {
                if (GetData<byte>(2114) == value) return;
                SetData(2114, value, nameof(Feline_Carving_L_Up_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Carving_L_Up_2));
            }
        }

        public const string Feline_Carving_L_Up_3_displayName = "Feline Carving L: Up % 3";
        public const int Feline_Carving_L_Up_3_sortIndex = 45850;
        [SortOrder(Feline_Carving_L_Up_3_sortIndex)]
        [DisplayName(Feline_Carving_L_Up_3_displayName)]
        public virtual byte Feline_Carving_L_Up_3 {
            get => GetData<byte>(2115);
            set {
                if (GetData<byte>(2115) == value) return;
                SetData(2115, value, nameof(Feline_Carving_L_Up_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Carving_L_Up_3));
            }
        }

        public const string Feline_Carving_L_Up_4_displayName = "Feline Carving L: Up % 4";
        public const int Feline_Carving_L_Up_4_sortIndex = 45900;
        [SortOrder(Feline_Carving_L_Up_4_sortIndex)]
        [DisplayName(Feline_Carving_L_Up_4_displayName)]
        public virtual byte Feline_Carving_L_Up_4 {
            get => GetData<byte>(2116);
            set {
                if (GetData<byte>(2116) == value) return;
                SetData(2116, value, nameof(Feline_Carving_L_Up_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Carving_L_Up_4));
            }
        }

        public const string __45950_displayName = "-------------------------------------------------------------------------------------------";
        public const int __45950_sortIndex = 45950;
        [SortOrder(__45950_sortIndex)]
        [DisplayName(__45950_displayName)]
        [IsReadOnly]
        public virtual byte __45950 {
            get => GetData<byte>(162);
            set {
                if (GetData<byte>(162) == value) return;
                SetData(162, value, nameof(__45950));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__45950));
            }
        }

        public const string Feline_Carving_S_Lottery__displayName = "Feline Carving S: Lottery %";
        public const int Feline_Carving_S_Lottery__sortIndex = 46000;
        [SortOrder(Feline_Carving_S_Lottery__sortIndex)]
        [DisplayName(Feline_Carving_S_Lottery__displayName)]
        public virtual byte Feline_Carving_S_Lottery_ {
            get => GetData<byte>(2117);
            set {
                if (GetData<byte>(2117) == value) return;
                SetData(2117, value, nameof(Feline_Carving_S_Lottery_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Carving_S_Lottery_));
            }
        }

        public const string Feline_Carving_S_Up__displayName = "Feline Carving S: Up %";
        public const int Feline_Carving_S_Up__sortIndex = 46050;
        [SortOrder(Feline_Carving_S_Up__sortIndex)]
        [DisplayName(Feline_Carving_S_Up__displayName)]
        public virtual byte Feline_Carving_S_Up_ {
            get => GetData<byte>(2118);
            set {
                if (GetData<byte>(2118) == value) return;
                SetData(2118, value, nameof(Feline_Carving_S_Up_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Carving_S_Up_));
            }
        }

        public const string __46100_displayName = "-------------------------------------------------------------------------------------------";
        public const int __46100_sortIndex = 46100;
        [SortOrder(__46100_sortIndex)]
        [DisplayName(__46100_displayName)]
        [IsReadOnly]
        public virtual byte __46100 {
            get => GetData<byte>(162);
            set {
                if (GetData<byte>(162) == value) return;
                SetData(162, value, nameof(__46100));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__46100));
            }
        }

        public const string Feline_Medic_Heal_Rate_displayName = "Feline Medic: Heal Rate";
        public const int Feline_Medic_Heal_Rate_sortIndex = 46150;
        [SortOrder(Feline_Medic_Heal_Rate_sortIndex)]
        [DisplayName(Feline_Medic_Heal_Rate_displayName)]
        public virtual float Feline_Medic_Heal_Rate {
            get => GetData<float>(2119);
            set {
                if (GetData<float>(2119) == value) return;
                SetData(2119, value, nameof(Feline_Medic_Heal_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Medic_Heal_Rate));
            }
        }

        public const string __46200_displayName = "-------------------------------------------------------------------------------------------";
        public const int __46200_sortIndex = 46200;
        [SortOrder(__46200_sortIndex)]
        [DisplayName(__46200_displayName)]
        [IsReadOnly]
        public virtual byte __46200 {
            get => GetData<byte>(162);
            set {
                if (GetData<byte>(162) == value) return;
                SetData(162, value, nameof(__46200));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__46200));
            }
        }

        public const string Feline_Black_Belt_Stamina_Rate_displayName = "Feline Black Belt: Stamina Rate";
        public const int Feline_Black_Belt_Stamina_Rate_sortIndex = 46250;
        [SortOrder(Feline_Black_Belt_Stamina_Rate_sortIndex)]
        [DisplayName(Feline_Black_Belt_Stamina_Rate_displayName)]
        public virtual float Feline_Black_Belt_Stamina_Rate {
            get => GetData<float>(2123);
            set {
                if (GetData<float>(2123) == value) return;
                SetData(2123, value, nameof(Feline_Black_Belt_Stamina_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Black_Belt_Stamina_Rate));
            }
        }

        public const string __46300_displayName = "-------------------------------------------------------------------------------------------";
        public const int __46300_sortIndex = 46300;
        [SortOrder(__46300_sortIndex)]
        [DisplayName(__46300_displayName)]
        [IsReadOnly]
        public virtual byte __46300 {
            get => GetData<byte>(162);
            set {
                if (GetData<byte>(162) == value) return;
                SetData(162, value, nameof(__46300));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__46300));
            }
        }

        public const string Feline_Special_Attack_Condition_Attack_Bonus_displayName = "Feline Special Attack: Condition Attack Bonus";
        public const int Feline_Special_Attack_Condition_Attack_Bonus_sortIndex = 46350;
        [SortOrder(Feline_Special_Attack_Condition_Attack_Bonus_sortIndex)]
        [DisplayName(Feline_Special_Attack_Condition_Attack_Bonus_displayName)]
        public virtual ushort Feline_Special_Attack_Condition_Attack_Bonus {
            get => GetData<ushort>(2127);
            set {
                if (GetData<ushort>(2127) == value) return;
                SetData(2127, value, nameof(Feline_Special_Attack_Condition_Attack_Bonus));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Special_Attack_Condition_Attack_Bonus));
            }
        }

        public const string Feline_Special_Attack_Capture_Attack_Rate_displayName = "Feline Special Attack: Capture Attack Rate";
        public const int Feline_Special_Attack_Capture_Attack_Rate_sortIndex = 46400;
        [SortOrder(Feline_Special_Attack_Capture_Attack_Rate_sortIndex)]
        [DisplayName(Feline_Special_Attack_Capture_Attack_Rate_displayName)]
        public virtual float Feline_Special_Attack_Capture_Attack_Rate {
            get => GetData<float>(2129);
            set {
                if (GetData<float>(2129) == value) return;
                SetData(2129, value, nameof(Feline_Special_Attack_Capture_Attack_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Special_Attack_Capture_Attack_Rate));
            }
        }

        public const string __46450_displayName = "-------------------------------------------------------------------------------------------";
        public const int __46450_sortIndex = 46450;
        [SortOrder(__46450_sortIndex)]
        [DisplayName(__46450_displayName)]
        [IsReadOnly]
        public virtual byte __46450 {
            get => GetData<byte>(162);
            set {
                if (GetData<byte>(162) == value) return;
                SetData(162, value, nameof(__46450));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__46450));
            }
        }

        public const string Feline_Defense_S__displayName = "Feline Defense S: %";
        public const int Feline_Defense_S__sortIndex = 46500;
        [SortOrder(Feline_Defense_S__sortIndex)]
        [DisplayName(Feline_Defense_S__displayName)]
        public virtual byte Feline_Defense_S_ {
            get => GetData<byte>(2133);
            set {
                if (GetData<byte>(2133) == value) return;
                SetData(2133, value, nameof(Feline_Defense_S_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Defense_S_));
            }
        }

        public const string Feline_Defense_S_Damage_Rate_displayName = "Feline Defense S: Damage Rate";
        public const int Feline_Defense_S_Damage_Rate_sortIndex = 46550;
        [SortOrder(Feline_Defense_S_Damage_Rate_sortIndex)]
        [DisplayName(Feline_Defense_S_Damage_Rate_displayName)]
        public virtual float Feline_Defense_S_Damage_Rate {
            get => GetData<float>(2135);
            set {
                if (GetData<float>(2135) == value) return;
                SetData(2135, value, nameof(Feline_Defense_S_Damage_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Defense_S_Damage_Rate));
            }
        }

        public const string Feline_Defense_L__displayName = "Feline Defense L: %";
        public const int Feline_Defense_L__sortIndex = 46600;
        [SortOrder(Feline_Defense_L__sortIndex)]
        [DisplayName(Feline_Defense_L__displayName)]
        public virtual byte Feline_Defense_L_ {
            get => GetData<byte>(2134);
            set {
                if (GetData<byte>(2134) == value) return;
                SetData(2134, value, nameof(Feline_Defense_L_));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Defense_L_));
            }
        }

        public const string Feline_Defense_L_Damage_Rate_displayName = "Feline Defense L: Damage Rate";
        public const int Feline_Defense_L_Damage_Rate_sortIndex = 46650;
        [SortOrder(Feline_Defense_L_Damage_Rate_sortIndex)]
        [DisplayName(Feline_Defense_L_Damage_Rate_displayName)]
        public virtual float Feline_Defense_L_Damage_Rate {
            get => GetData<float>(2139);
            set {
                if (GetData<float>(2139) == value) return;
                SetData(2139, value, nameof(Feline_Defense_L_Damage_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Defense_L_Damage_Rate));
            }
        }

        public const string __46700_displayName = "-------------------------------------------------------------------------------------------";
        public const int __46700_sortIndex = 46700;
        [SortOrder(__46700_sortIndex)]
        [DisplayName(__46700_displayName)]
        [IsReadOnly]
        public virtual byte __46700 {
            get => GetData<byte>(162);
            set {
                if (GetData<byte>(162) == value) return;
                SetData(162, value, nameof(__46700));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__46700));
            }
        }

        public const string Feline_Harvest_Cooldown_Multiplier_displayName = "Feline Harvest: Cooldown Multiplier";
        public const int Feline_Harvest_Cooldown_Multiplier_sortIndex = 46750;
        [SortOrder(Feline_Harvest_Cooldown_Multiplier_sortIndex)]
        [DisplayName(Feline_Harvest_Cooldown_Multiplier_displayName)]
        public virtual float Feline_Harvest_Cooldown_Multiplier {
            get => GetData<float>(2143);
            set {
                if (GetData<float>(2143) == value) return;
                SetData(2143, value, nameof(Feline_Harvest_Cooldown_Multiplier));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Harvest_Cooldown_Multiplier));
            }
        }

        public const string __46800_displayName = "-------------------------------------------------------------------------------------------";
        public const int __46800_sortIndex = 46800;
        [SortOrder(__46800_sortIndex)]
        [DisplayName(__46800_displayName)]
        [IsReadOnly]
        public virtual byte __46800 {
            get => GetData<byte>(162);
            set {
                if (GetData<byte>(162) == value) return;
                SetData(162, value, nameof(__46800));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__46800));
            }
        }

        public const string Feline_Sharpshooter_Shell_Attack_Rate_displayName = "Feline Sharpshooter: Shell Attack Rate";
        public const int Feline_Sharpshooter_Shell_Attack_Rate_sortIndex = 46850;
        [SortOrder(Feline_Sharpshooter_Shell_Attack_Rate_sortIndex)]
        [DisplayName(Feline_Sharpshooter_Shell_Attack_Rate_displayName)]
        public virtual float Feline_Sharpshooter_Shell_Attack_Rate {
            get => GetData<float>(2147);
            set {
                if (GetData<float>(2147) == value) return;
                SetData(2147, value, nameof(Feline_Sharpshooter_Shell_Attack_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Sharpshooter_Shell_Attack_Rate));
            }
        }

        public const string __46900_displayName = "-------------------------------------------------------------------------------------------";
        public const int __46900_sortIndex = 46900;
        [SortOrder(__46900_sortIndex)]
        [DisplayName(__46900_displayName)]
        [IsReadOnly]
        public virtual byte __46900 {
            get => GetData<byte>(162);
            set {
                if (GetData<byte>(162) == value) return;
                SetData(162, value, nameof(__46900));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__46900));
            }
        }

        public const string Feline_Escape_Artist_Dash_Stamina_Rate_displayName = "Feline Escape Artist: Dash Stamina Rate";
        public const int Feline_Escape_Artist_Dash_Stamina_Rate_sortIndex = 46950;
        [SortOrder(Feline_Escape_Artist_Dash_Stamina_Rate_sortIndex)]
        [DisplayName(Feline_Escape_Artist_Dash_Stamina_Rate_displayName)]
        public virtual float Feline_Escape_Artist_Dash_Stamina_Rate {
            get => GetData<float>(2151);
            set {
                if (GetData<float>(2151) == value) return;
                SetData(2151, value, nameof(Feline_Escape_Artist_Dash_Stamina_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Escape_Artist_Dash_Stamina_Rate));
            }
        }

        public const string __47000_displayName = "-------------------------------------------------------------------------------------------";
        public const int __47000_sortIndex = 47000;
        [SortOrder(__47000_sortIndex)]
        [DisplayName(__47000_displayName)]
        [IsReadOnly]
        public virtual byte __47000 {
            get => GetData<byte>(162);
            set {
                if (GetData<byte>(162) == value) return;
                SetData(162, value, nameof(__47000));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__47000));
            }
        }

        public const string Feline_Delivery_Dash_Stamina_Rate_displayName = "Feline Delivery: Dash Stamina Rate";
        public const int Feline_Delivery_Dash_Stamina_Rate_sortIndex = 47050;
        [SortOrder(Feline_Delivery_Dash_Stamina_Rate_sortIndex)]
        [DisplayName(Feline_Delivery_Dash_Stamina_Rate_displayName)]
        public virtual float Feline_Delivery_Dash_Stamina_Rate {
            get => GetData<float>(2155);
            set {
                if (GetData<float>(2155) == value) return;
                SetData(2155, value, nameof(Feline_Delivery_Dash_Stamina_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Delivery_Dash_Stamina_Rate));
            }
        }

        public const string __47100_displayName = "-------------------------------------------------------------------------------------------";
        public const int __47100_sortIndex = 47100;
        [SortOrder(__47100_sortIndex)]
        [DisplayName(__47100_displayName)]
        [IsReadOnly]
        public virtual byte __47100 {
            get => GetData<byte>(162);
            set {
                if (GetData<byte>(162) == value) return;
                SetData(162, value, nameof(__47100));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__47100));
            }
        }

        public const string Feline_Riser_S_IFrames_displayName = "Feline Riser S: IFrames";
        public const int Feline_Riser_S_IFrames_sortIndex = 47150;
        [SortOrder(Feline_Riser_S_IFrames_sortIndex)]
        [DisplayName(Feline_Riser_S_IFrames_displayName)]
        public virtual float Feline_Riser_S_IFrames {
            get => GetData<float>(2159);
            set {
                if (GetData<float>(2159) == value) return;
                SetData(2159, value, nameof(Feline_Riser_S_IFrames));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Riser_S_IFrames));
            }
        }

        public const string Feline_Riser_L_IFrames_displayName = "Feline Riser L: IFrames";
        public const int Feline_Riser_L_IFrames_sortIndex = 47200;
        [SortOrder(Feline_Riser_L_IFrames_sortIndex)]
        [DisplayName(Feline_Riser_L_IFrames_displayName)]
        public virtual float Feline_Riser_L_IFrames {
            get => GetData<float>(2163);
            set {
                if (GetData<float>(2163) == value) return;
                SetData(2163, value, nameof(Feline_Riser_L_IFrames));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Riser_L_IFrames));
            }
        }

        public const string __47250_displayName = "-------------------------------------------------------------------------------------------";
        public const int __47250_sortIndex = 47250;
        [SortOrder(__47250_sortIndex)]
        [DisplayName(__47250_displayName)]
        [IsReadOnly]
        public virtual byte __47250 {
            get => GetData<byte>(162);
            set {
                if (GetData<byte>(162) == value) return;
                SetData(162, value, nameof(__47250));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__47250));
            }
        }

        public const string Feline_Temper_Shell_Attack_Rate_displayName = "Feline Temper: Shell Attack Rate";
        public const int Feline_Temper_Shell_Attack_Rate_sortIndex = 47300;
        [SortOrder(Feline_Temper_Shell_Attack_Rate_sortIndex)]
        [DisplayName(Feline_Temper_Shell_Attack_Rate_displayName)]
        public virtual float Feline_Temper_Shell_Attack_Rate {
            get => GetData<float>(2167);
            set {
                if (GetData<float>(2167) == value) return;
                SetData(2167, value, nameof(Feline_Temper_Shell_Attack_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Temper_Shell_Attack_Rate));
            }
        }

        public const string Feline_Temper_Blur_Level_Bonus_displayName = "Feline Temper: Blur Level Bonus";
        public const int Feline_Temper_Blur_Level_Bonus_sortIndex = 47350;
        [SortOrder(Feline_Temper_Blur_Level_Bonus_sortIndex)]
        [DisplayName(Feline_Temper_Blur_Level_Bonus_displayName)]
        public virtual byte Feline_Temper_Blur_Level_Bonus {
            get => GetData<byte>(2171);
            set {
                if (GetData<byte>(2171) == value) return;
                SetData(2171, value, nameof(Feline_Temper_Blur_Level_Bonus));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Temper_Blur_Level_Bonus));
            }
        }

        public const string __47400_displayName = "-------------------------------------------------------------------------------------------";
        public const int __47400_sortIndex = 47400;
        [SortOrder(__47400_sortIndex)]
        [DisplayName(__47400_displayName)]
        [IsReadOnly]
        public virtual byte __47400 {
            get => GetData<byte>(162);
            set {
                if (GetData<byte>(162) == value) return;
                SetData(162, value, nameof(__47400));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__47400));
            }
        }

        public const string Feline_Cliffhanger_Stamina_Rate_displayName = "Feline Cliffhanger: Stamina Rate";
        public const int Feline_Cliffhanger_Stamina_Rate_sortIndex = 47450;
        [SortOrder(Feline_Cliffhanger_Stamina_Rate_sortIndex)]
        [DisplayName(Feline_Cliffhanger_Stamina_Rate_displayName)]
        public virtual float Feline_Cliffhanger_Stamina_Rate {
            get => GetData<float>(2172);
            set {
                if (GetData<float>(2172) == value) return;
                SetData(2172, value, nameof(Feline_Cliffhanger_Stamina_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Cliffhanger_Stamina_Rate));
            }
        }

        public const string __47500_displayName = "-------------------------------------------------------------------------------------------";
        public const int __47500_sortIndex = 47500;
        [SortOrder(__47500_sortIndex)]
        [DisplayName(__47500_displayName)]
        [IsReadOnly]
        public virtual byte __47500 {
            get => GetData<byte>(162);
            set {
                if (GetData<byte>(162) == value) return;
                SetData(162, value, nameof(__47500));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__47500));
            }
        }

        public const string Feline_Slugger_Stun_Attack_Rate_displayName = "Feline Slugger: Stun Attack Rate";
        public const int Feline_Slugger_Stun_Attack_Rate_sortIndex = 47550;
        [SortOrder(Feline_Slugger_Stun_Attack_Rate_sortIndex)]
        [DisplayName(Feline_Slugger_Stun_Attack_Rate_displayName)]
        public virtual float Feline_Slugger_Stun_Attack_Rate {
            get => GetData<float>(2176);
            set {
                if (GetData<float>(2176) == value) return;
                SetData(2176, value, nameof(Feline_Slugger_Stun_Attack_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Slugger_Stun_Attack_Rate));
            }
        }

        public const string __47600_displayName = "-------------------------------------------------------------------------------------------";
        public const int __47600_sortIndex = 47600;
        [SortOrder(__47600_sortIndex)]
        [DisplayName(__47600_displayName)]
        [IsReadOnly]
        public virtual byte __47600 {
            get => GetData<byte>(162);
            set {
                if (GetData<byte>(162) == value) return;
                SetData(162, value, nameof(__47600));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__47600));
            }
        }

        public const string Feline_Bombardier_Ballista_Attack_Rate_displayName = "Feline Bombardier: Ballista Attack Rate";
        public const int Feline_Bombardier_Ballista_Attack_Rate_sortIndex = 47650;
        [SortOrder(Feline_Bombardier_Ballista_Attack_Rate_sortIndex)]
        [DisplayName(Feline_Bombardier_Ballista_Attack_Rate_displayName)]
        public virtual float Feline_Bombardier_Ballista_Attack_Rate {
            get => GetData<float>(2180);
            set {
                if (GetData<float>(2180) == value) return;
                SetData(2180, value, nameof(Feline_Bombardier_Ballista_Attack_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Bombardier_Ballista_Attack_Rate));
            }
        }

        public const string Feline_Bombardier_Cannon_Attack_Rate_displayName = "Feline Bombardier: Cannon Attack Rate";
        public const int Feline_Bombardier_Cannon_Attack_Rate_sortIndex = 47700;
        [SortOrder(Feline_Bombardier_Cannon_Attack_Rate_sortIndex)]
        [DisplayName(Feline_Bombardier_Cannon_Attack_Rate_displayName)]
        public virtual float Feline_Bombardier_Cannon_Attack_Rate {
            get => GetData<float>(2184);
            set {
                if (GetData<float>(2184) == value) return;
                SetData(2184, value, nameof(Feline_Bombardier_Cannon_Attack_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Bombardier_Cannon_Attack_Rate));
            }
        }

        public const string Feline_Bombardier_Gunlance_Shell_Attack_Rate_displayName = "Feline Bombardier: Gunlance Shell Attack Rate";
        public const int Feline_Bombardier_Gunlance_Shell_Attack_Rate_sortIndex = 47750;
        [SortOrder(Feline_Bombardier_Gunlance_Shell_Attack_Rate_sortIndex)]
        [DisplayName(Feline_Bombardier_Gunlance_Shell_Attack_Rate_displayName)]
        public virtual float Feline_Bombardier_Gunlance_Shell_Attack_Rate {
            get => GetData<float>(2188);
            set {
                if (GetData<float>(2188) == value) return;
                SetData(2188, value, nameof(Feline_Bombardier_Gunlance_Shell_Attack_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Bombardier_Gunlance_Shell_Attack_Rate));
            }
        }

        public const string Feline_Bombardier_Gunlance_WyvernFire_Attack_Rate_displayName = "Feline Bombardier: Gunlance WyvernFire Attack Rate";
        public const int Feline_Bombardier_Gunlance_WyvernFire_Attack_Rate_sortIndex = 47800;
        [SortOrder(Feline_Bombardier_Gunlance_WyvernFire_Attack_Rate_sortIndex)]
        [DisplayName(Feline_Bombardier_Gunlance_WyvernFire_Attack_Rate_displayName)]
        public virtual float Feline_Bombardier_Gunlance_WyvernFire_Attack_Rate {
            get => GetData<float>(2192);
            set {
                if (GetData<float>(2192) == value) return;
                SetData(2192, value, nameof(Feline_Bombardier_Gunlance_WyvernFire_Attack_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Bombardier_Gunlance_WyvernFire_Attack_Rate));
            }
        }

        public const string Feline_Bombardier_Gunlance_Wyrmstake_Cannon_Attack_Rate_displayName = "Feline Bombardier: Gunlance Wyrmstake Cannon Attack Rate";
        public const int Feline_Bombardier_Gunlance_Wyrmstake_Cannon_Attack_Rate_sortIndex = 47850;
        [SortOrder(Feline_Bombardier_Gunlance_Wyrmstake_Cannon_Attack_Rate_sortIndex)]
        [DisplayName(Feline_Bombardier_Gunlance_Wyrmstake_Cannon_Attack_Rate_displayName)]
        public virtual float Feline_Bombardier_Gunlance_Wyrmstake_Cannon_Attack_Rate {
            get => GetData<float>(2196);
            set {
                if (GetData<float>(2196) == value) return;
                SetData(2196, value, nameof(Feline_Bombardier_Gunlance_Wyrmstake_Cannon_Attack_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Bombardier_Gunlance_Wyrmstake_Cannon_Attack_Rate));
            }
        }

        public const string Feline_Bombardier_Charge_Blade_Impact_Phial_Attack_Rate_displayName = "Feline Bombardier: Charge Blade Impact Phial Attack Rate";
        public const int Feline_Bombardier_Charge_Blade_Impact_Phial_Attack_Rate_sortIndex = 47900;
        [SortOrder(Feline_Bombardier_Charge_Blade_Impact_Phial_Attack_Rate_sortIndex)]
        [DisplayName(Feline_Bombardier_Charge_Blade_Impact_Phial_Attack_Rate_displayName)]
        public virtual float Feline_Bombardier_Charge_Blade_Impact_Phial_Attack_Rate {
            get => GetData<float>(2200);
            set {
                if (GetData<float>(2200) == value) return;
                SetData(2200, value, nameof(Feline_Bombardier_Charge_Blade_Impact_Phial_Attack_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Bombardier_Charge_Blade_Impact_Phial_Attack_Rate));
            }
        }

        public const string Feline_Bombardier_Bowgun_Sticky_Ammo_Attack_Rate_displayName = "Feline Bombardier: Bowgun Sticky Ammo Attack Rate";
        public const int Feline_Bombardier_Bowgun_Sticky_Ammo_Attack_Rate_sortIndex = 47950;
        [SortOrder(Feline_Bombardier_Bowgun_Sticky_Ammo_Attack_Rate_sortIndex)]
        [DisplayName(Feline_Bombardier_Bowgun_Sticky_Ammo_Attack_Rate_displayName)]
        public virtual float Feline_Bombardier_Bowgun_Sticky_Ammo_Attack_Rate {
            get => GetData<float>(2204);
            set {
                if (GetData<float>(2204) == value) return;
                SetData(2204, value, nameof(Feline_Bombardier_Bowgun_Sticky_Ammo_Attack_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Bombardier_Bowgun_Sticky_Ammo_Attack_Rate));
            }
        }

        public const string Feline_Bombardier_Bowgun_Wyvern_Ammo_Attack_Rate_displayName = "Feline Bombardier: Bowgun Wyvern Ammo Attack Rate";
        public const int Feline_Bombardier_Bowgun_Wyvern_Ammo_Attack_Rate_sortIndex = 48000;
        [SortOrder(Feline_Bombardier_Bowgun_Wyvern_Ammo_Attack_Rate_sortIndex)]
        [DisplayName(Feline_Bombardier_Bowgun_Wyvern_Ammo_Attack_Rate_displayName)]
        public virtual float Feline_Bombardier_Bowgun_Wyvern_Ammo_Attack_Rate {
            get => GetData<float>(2208);
            set {
                if (GetData<float>(2208) == value) return;
                SetData(2208, value, nameof(Feline_Bombardier_Bowgun_Wyvern_Ammo_Attack_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Bombardier_Bowgun_Wyvern_Ammo_Attack_Rate));
            }
        }

        public const string __48050_displayName = "-------------------------------------------------------------------------------------------";
        public const int __48050_sortIndex = 48050;
        [SortOrder(__48050_sortIndex)]
        [DisplayName(__48050_displayName)]
        [IsReadOnly]
        public virtual byte __48050 {
            get => GetData<byte>(162);
            set {
                if (GetData<byte>(162) == value) return;
                SetData(162, value, nameof(__48050));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__48050));
            }
        }

        public const string Feline_Moxie_Health_Threshold_displayName = "Feline Moxie: Health Threshold";
        public const int Feline_Moxie_Health_Threshold_sortIndex = 48100;
        [SortOrder(Feline_Moxie_Health_Threshold_sortIndex)]
        [DisplayName(Feline_Moxie_Health_Threshold_displayName)]
        public virtual byte Feline_Moxie_Health_Threshold {
            get => GetData<byte>(2212);
            set {
                if (GetData<byte>(2212) == value) return;
                SetData(2212, value, nameof(Feline_Moxie_Health_Threshold));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Moxie_Health_Threshold));
            }
        }

        public const string __48150_displayName = "-------------------------------------------------------------------------------------------";
        public const int __48150_sortIndex = 48150;
        [SortOrder(__48150_sortIndex)]
        [DisplayName(__48150_displayName)]
        [IsReadOnly]
        public virtual byte __48150 {
            get => GetData<byte>(162);
            set {
                if (GetData<byte>(162) == value) return;
                SetData(162, value, nameof(__48150));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__48150));
            }
        }

        public const string Feline_Dungmaster_Escape_Bonus_displayName = "Feline Dungmaster: Escape % Bonus";
        public const int Feline_Dungmaster_Escape_Bonus_sortIndex = 48200;
        [SortOrder(Feline_Dungmaster_Escape_Bonus_sortIndex)]
        [DisplayName(Feline_Dungmaster_Escape_Bonus_displayName)]
        public virtual byte Feline_Dungmaster_Escape_Bonus {
            get => GetData<byte>(2213);
            set {
                if (GetData<byte>(2213) == value) return;
                SetData(2213, value, nameof(Feline_Dungmaster_Escape_Bonus));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Dungmaster_Escape_Bonus));
            }
        }

        public const string __48250_displayName = "-------------------------------------------------------------------------------------------";
        public const int __48250_sortIndex = 48250;
        [SortOrder(__48250_sortIndex)]
        [DisplayName(__48250_displayName)]
        [IsReadOnly]
        public virtual byte __48250 {
            get => GetData<byte>(162);
            set {
                if (GetData<byte>(162) == value) return;
                SetData(162, value, nameof(__48250));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__48250));
            }
        }

        public const string Feline_Provoker_Rate_displayName = "Feline Provoker: Rate";
        public const int Feline_Provoker_Rate_sortIndex = 48300;
        [SortOrder(Feline_Provoker_Rate_sortIndex)]
        [DisplayName(Feline_Provoker_Rate_displayName)]
        public virtual float Feline_Provoker_Rate {
            get => GetData<float>(2214);
            set {
                if (GetData<float>(2214) == value) return;
                SetData(2214, value, nameof(Feline_Provoker_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Provoker_Rate));
            }
        }

        public const string __48350_displayName = "-------------------------------------------------------------------------------------------";
        public const int __48350_sortIndex = 48350;
        [SortOrder(__48350_sortIndex)]
        [DisplayName(__48350_displayName)]
        [IsReadOnly]
        public virtual byte __48350 {
            get => GetData<byte>(162);
            set {
                if (GetData<byte>(162) == value) return;
                SetData(162, value, nameof(__48350));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__48350));
            }
        }

        public const string Feline_Cool_Cat_Power_UP_Time_Needed_displayName = "Feline Cool Cat: Power UP Time Needed";
        public const int Feline_Cool_Cat_Power_UP_Time_Needed_sortIndex = 48400;
        [SortOrder(Feline_Cool_Cat_Power_UP_Time_Needed_sortIndex)]
        [DisplayName(Feline_Cool_Cat_Power_UP_Time_Needed_displayName)]
        public virtual float Feline_Cool_Cat_Power_UP_Time_Needed {
            get => GetData<float>(2218);
            set {
                if (GetData<float>(2218) == value) return;
                SetData(2218, value, nameof(Feline_Cool_Cat_Power_UP_Time_Needed));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Cool_Cat_Power_UP_Time_Needed));
            }
        }

        public const string Feline_Cool_Cat_Power_UP_Duration_displayName = "Feline Cool Cat: Power UP Duration";
        public const int Feline_Cool_Cat_Power_UP_Duration_sortIndex = 48450;
        [SortOrder(Feline_Cool_Cat_Power_UP_Duration_sortIndex)]
        [DisplayName(Feline_Cool_Cat_Power_UP_Duration_displayName)]
        public virtual float Feline_Cool_Cat_Power_UP_Duration {
            get => GetData<float>(2222);
            set {
                if (GetData<float>(2222) == value) return;
                SetData(2222, value, nameof(Feline_Cool_Cat_Power_UP_Duration));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Cool_Cat_Power_UP_Duration));
            }
        }

        public const string Feline_Cool_Cat_Attack_Bonus_displayName = "Feline Cool Cat: Attack Bonus";
        public const int Feline_Cool_Cat_Attack_Bonus_sortIndex = 48500;
        [SortOrder(Feline_Cool_Cat_Attack_Bonus_sortIndex)]
        [DisplayName(Feline_Cool_Cat_Attack_Bonus_displayName)]
        public virtual float Feline_Cool_Cat_Attack_Bonus {
            get => GetData<float>(2226);
            set {
                if (GetData<float>(2226) == value) return;
                SetData(2226, value, nameof(Feline_Cool_Cat_Attack_Bonus));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Cool_Cat_Attack_Bonus));
            }
        }

        public const string __48550_displayName = "-------------------------------------------------------------------------------------------";
        public const int __48550_sortIndex = 48550;
        [SortOrder(__48550_sortIndex)]
        [DisplayName(__48550_displayName)]
        [IsReadOnly]
        public virtual byte __48550 {
            get => GetData<byte>(162);
            set {
                if (GetData<byte>(162) == value) return;
                SetData(162, value, nameof(__48550));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__48550));
            }
        }

        public const string Feline_Booster_Attack_Bonus_displayName = "Feline Booster: Attack Bonus";
        public const int Feline_Booster_Attack_Bonus_sortIndex = 48600;
        [SortOrder(Feline_Booster_Attack_Bonus_sortIndex)]
        [DisplayName(Feline_Booster_Attack_Bonus_displayName)]
        public virtual float Feline_Booster_Attack_Bonus {
            get => GetData<float>(2230);
            set {
                if (GetData<float>(2230) == value) return;
                SetData(2230, value, nameof(Feline_Booster_Attack_Bonus));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Booster_Attack_Bonus));
            }
        }

        public const string Feline_Booster_Defense_Bonus_displayName = "Feline Booster: Defense Bonus";
        public const int Feline_Booster_Defense_Bonus_sortIndex = 48650;
        [SortOrder(Feline_Booster_Defense_Bonus_sortIndex)]
        [DisplayName(Feline_Booster_Defense_Bonus_displayName)]
        public virtual float Feline_Booster_Defense_Bonus {
            get => GetData<float>(2234);
            set {
                if (GetData<float>(2234) == value) return;
                SetData(2234, value, nameof(Feline_Booster_Defense_Bonus));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Booster_Defense_Bonus));
            }
        }

        public const string Feline_Booster_Duration_displayName = "Feline Booster: Duration";
        public const int Feline_Booster_Duration_sortIndex = 48700;
        [SortOrder(Feline_Booster_Duration_sortIndex)]
        [DisplayName(Feline_Booster_Duration_displayName)]
        public virtual float Feline_Booster_Duration {
            get => GetData<float>(2238);
            set {
                if (GetData<float>(2238) == value) return;
                SetData(2238, value, nameof(Feline_Booster_Duration));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Booster_Duration));
            }
        }

        public const string __48750_displayName = "-------------------------------------------------------------------------------------------";
        public const int __48750_sortIndex = 48750;
        [SortOrder(__48750_sortIndex)]
        [DisplayName(__48750_displayName)]
        [IsReadOnly]
        public virtual byte __48750 {
            get => GetData<byte>(162);
            set {
                if (GetData<byte>(162) == value) return;
                SetData(162, value, nameof(__48750));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__48750));
            }
        }

        public const string Feline_Groomer_Defense_Down_Duration_Multiplier_displayName = "Feline Groomer: Defense Down Duration Multiplier";
        public const int Feline_Groomer_Defense_Down_Duration_Multiplier_sortIndex = 48800;
        [SortOrder(Feline_Groomer_Defense_Down_Duration_Multiplier_sortIndex)]
        [DisplayName(Feline_Groomer_Defense_Down_Duration_Multiplier_displayName)]
        public virtual float Feline_Groomer_Defense_Down_Duration_Multiplier {
            get => GetData<float>(2242);
            set {
                if (GetData<float>(2242) == value) return;
                SetData(2242, value, nameof(Feline_Groomer_Defense_Down_Duration_Multiplier));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Groomer_Defense_Down_Duration_Multiplier));
            }
        }

        public const string Feline_Groomer_Element_Blight_Recovery_Multiplier_displayName = "Feline Groomer: Element Blight Recovery Multiplier";
        public const int Feline_Groomer_Element_Blight_Recovery_Multiplier_sortIndex = 48850;
        [SortOrder(Feline_Groomer_Element_Blight_Recovery_Multiplier_sortIndex)]
        [DisplayName(Feline_Groomer_Element_Blight_Recovery_Multiplier_displayName)]
        public virtual float Feline_Groomer_Element_Blight_Recovery_Multiplier {
            get => GetData<float>(2246);
            set {
                if (GetData<float>(2246) == value) return;
                SetData(2246, value, nameof(Feline_Groomer_Element_Blight_Recovery_Multiplier));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Groomer_Element_Blight_Recovery_Multiplier));
            }
        }

        public const string __48900_displayName = "-------------------------------------------------------------------------------------------";
        public const int __48900_sortIndex = 48900;
        [SortOrder(__48900_sortIndex)]
        [DisplayName(__48900_displayName)]
        [IsReadOnly]
        public virtual byte __48900 {
            get => GetData<byte>(162);
            set {
                if (GetData<byte>(162) == value) return;
                SetData(162, value, nameof(__48900));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__48900));
            }
        }

        public const string Feline_Parting_Gift_Radius_displayName = "Feline Parting Gift: Radius";
        public const int Feline_Parting_Gift_Radius_sortIndex = 48950;
        [SortOrder(Feline_Parting_Gift_Radius_sortIndex)]
        [DisplayName(Feline_Parting_Gift_Radius_displayName)]
        public virtual float Feline_Parting_Gift_Radius {
            get => GetData<float>(2250);
            set {
                if (GetData<float>(2250) == value) return;
                SetData(2250, value, nameof(Feline_Parting_Gift_Radius));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Parting_Gift_Radius));
            }
        }

        public const string Feline_Parting_Gift_Recovery_Value_displayName = "Feline Parting Gift: Recovery Value";
        public const int Feline_Parting_Gift_Recovery_Value_sortIndex = 49000;
        [SortOrder(Feline_Parting_Gift_Recovery_Value_sortIndex)]
        [DisplayName(Feline_Parting_Gift_Recovery_Value_displayName)]
        public virtual ushort Feline_Parting_Gift_Recovery_Value {
            get => GetData<ushort>(2254);
            set {
                if (GetData<ushort>(2254) == value) return;
                SetData(2254, value, nameof(Feline_Parting_Gift_Recovery_Value));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Parting_Gift_Recovery_Value));
            }
        }

        public const string __49050_displayName = "-------------------------------------------------------------------------------------------";
        public const int __49050_sortIndex = 49050;
        [SortOrder(__49050_sortIndex)]
        [DisplayName(__49050_displayName)]
        [IsReadOnly]
        public virtual byte __49050 {
            get => GetData<byte>(162);
            set {
                if (GetData<byte>(162) == value) return;
                SetData(162, value, nameof(__49050));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__49050));
            }
        }

        public const string Feline_Recoil_Attack_Multiplier_1_displayName = "Feline Recoil: Attack Multiplier 1";
        public const int Feline_Recoil_Attack_Multiplier_1_sortIndex = 49100;
        [SortOrder(Feline_Recoil_Attack_Multiplier_1_sortIndex)]
        [DisplayName(Feline_Recoil_Attack_Multiplier_1_displayName)]
        public virtual float Feline_Recoil_Attack_Multiplier_1 {
            get => GetData<float>(2256);
            set {
                if (GetData<float>(2256) == value) return;
                SetData(2256, value, nameof(Feline_Recoil_Attack_Multiplier_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Recoil_Attack_Multiplier_1));
            }
        }

        public const string Feline_Recoil_Attack_Multiplier_2_displayName = "Feline Recoil: Attack Multiplier 2";
        public const int Feline_Recoil_Attack_Multiplier_2_sortIndex = 49150;
        [SortOrder(Feline_Recoil_Attack_Multiplier_2_sortIndex)]
        [DisplayName(Feline_Recoil_Attack_Multiplier_2_displayName)]
        public virtual float Feline_Recoil_Attack_Multiplier_2 {
            get => GetData<float>(2260);
            set {
                if (GetData<float>(2260) == value) return;
                SetData(2260, value, nameof(Feline_Recoil_Attack_Multiplier_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Recoil_Attack_Multiplier_2));
            }
        }

        public const string Feline_Recoil_Attack_Multiplier_3_displayName = "Feline Recoil: Attack Multiplier 3";
        public const int Feline_Recoil_Attack_Multiplier_3_sortIndex = 49200;
        [SortOrder(Feline_Recoil_Attack_Multiplier_3_sortIndex)]
        [DisplayName(Feline_Recoil_Attack_Multiplier_3_displayName)]
        public virtual float Feline_Recoil_Attack_Multiplier_3 {
            get => GetData<float>(2264);
            set {
                if (GetData<float>(2264) == value) return;
                SetData(2264, value, nameof(Feline_Recoil_Attack_Multiplier_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Recoil_Attack_Multiplier_3));
            }
        }

        public const string Feline_Recoil_Attack_Multiplier_4_displayName = "Feline Recoil: Attack Multiplier 4";
        public const int Feline_Recoil_Attack_Multiplier_4_sortIndex = 49250;
        [SortOrder(Feline_Recoil_Attack_Multiplier_4_sortIndex)]
        [DisplayName(Feline_Recoil_Attack_Multiplier_4_displayName)]
        public virtual float Feline_Recoil_Attack_Multiplier_4 {
            get => GetData<float>(2268);
            set {
                if (GetData<float>(2268) == value) return;
                SetData(2268, value, nameof(Feline_Recoil_Attack_Multiplier_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Recoil_Attack_Multiplier_4));
            }
        }

        public const string Feline_Recoil_Attack_Multiplier_5_displayName = "Feline Recoil: Attack Multiplier 5";
        public const int Feline_Recoil_Attack_Multiplier_5_sortIndex = 49300;
        [SortOrder(Feline_Recoil_Attack_Multiplier_5_sortIndex)]
        [DisplayName(Feline_Recoil_Attack_Multiplier_5_displayName)]
        public virtual float Feline_Recoil_Attack_Multiplier_5 {
            get => GetData<float>(2272);
            set {
                if (GetData<float>(2272) == value) return;
                SetData(2272, value, nameof(Feline_Recoil_Attack_Multiplier_5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Recoil_Attack_Multiplier_5));
            }
        }

        public const string __49350_displayName = "-------------------------------------------------------------------------------------------";
        public const int __49350_sortIndex = 49350;
        [SortOrder(__49350_sortIndex)]
        [DisplayName(__49350_displayName)]
        [IsReadOnly]
        public virtual byte __49350 {
            get => GetData<byte>(162);
            set {
                if (GetData<byte>(162) == value) return;
                SetData(162, value, nameof(__49350));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__49350));
            }
        }

        public const string Feline_Tailor_displayName = "Feline Tailor";
        public const int Feline_Tailor_sortIndex = 49400;
        [SortOrder(Feline_Tailor_sortIndex)]
        [DisplayName(Feline_Tailor_displayName)]
        public virtual float Feline_Tailor {
            get => GetData<float>(2276);
            set {
                if (GetData<float>(2276) == value) return;
                SetData(2276, value, nameof(Feline_Tailor));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Feline_Tailor));
            }
        }

        public const string __49450_displayName = "-------------------------------------------------------------------------------------------";
        public const int __49450_sortIndex = 49450;
        [SortOrder(__49450_sortIndex)]
        [DisplayName(__49450_displayName)]
        [IsReadOnly]
        public virtual byte __49450 {
            get => GetData<byte>(162);
            set {
                if (GetData<byte>(162) == value) return;
                SetData(162, value, nameof(__49450));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__49450));
            }
        }

        public const string Music_Skill_Bless_Random_Rate_displayName = "Music Skill: Bless: Random Rate";
        public const int Music_Skill_Bless_Random_Rate_sortIndex = 49500;
        [SortOrder(Music_Skill_Bless_Random_Rate_sortIndex)]
        [DisplayName(Music_Skill_Bless_Random_Rate_displayName)]
        public virtual float Music_Skill_Bless_Random_Rate {
            get => GetData<float>(2280);
            set {
                if (GetData<float>(2280) == value) return;
                SetData(2280, value, nameof(Music_Skill_Bless_Random_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Music_Skill_Bless_Random_Rate));
            }
        }

        public const string Music_Skill_Bless_Damage_Cut_Rate_displayName = "Music Skill: Bless: Damage Cut Rate";
        public const int Music_Skill_Bless_Damage_Cut_Rate_sortIndex = 49550;
        [SortOrder(Music_Skill_Bless_Damage_Cut_Rate_sortIndex)]
        [DisplayName(Music_Skill_Bless_Damage_Cut_Rate_displayName)]
        public virtual float Music_Skill_Bless_Damage_Cut_Rate {
            get => GetData<float>(2284);
            set {
                if (GetData<float>(2284) == value) return;
                SetData(2284, value, nameof(Music_Skill_Bless_Damage_Cut_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Music_Skill_Bless_Damage_Cut_Rate));
            }
        }

        public const string Music_Skill_Extend_Time_displayName = "Music Skill: Extend: Time";
        public const int Music_Skill_Extend_Time_sortIndex = 49600;
        [SortOrder(Music_Skill_Extend_Time_sortIndex)]
        [DisplayName(Music_Skill_Extend_Time_displayName)]
        public virtual float Music_Skill_Extend_Time {
            get => GetData<float>(2288);
            set {
                if (GetData<float>(2288) == value) return;
                SetData(2288, value, nameof(Music_Skill_Extend_Time));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Music_Skill_Extend_Time));
            }
        }

        public const string Music_Skill_Extend_Time_Master_displayName = "Music Skill: Extend: Time Master";
        public const int Music_Skill_Extend_Time_Master_sortIndex = 49650;
        [SortOrder(Music_Skill_Extend_Time_Master_sortIndex)]
        [DisplayName(Music_Skill_Extend_Time_Master_displayName)]
        public virtual float Music_Skill_Extend_Time_Master {
            get => GetData<float>(2292);
            set {
                if (GetData<float>(2292) == value) return;
                SetData(2292, value, nameof(Music_Skill_Extend_Time_Master));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Music_Skill_Extend_Time_Master));
            }
        }

        public const string Music_Skill_Extend_Time_MR_Master_displayName = "Music Skill: Extend: Time MR Master";
        public const int Music_Skill_Extend_Time_MR_Master_sortIndex = 49700;
        [SortOrder(Music_Skill_Extend_Time_MR_Master_sortIndex)]
        [DisplayName(Music_Skill_Extend_Time_MR_Master_displayName)]
        public virtual float Music_Skill_Extend_Time_MR_Master {
            get => GetData<float>(2296);
            set {
                if (GetData<float>(2296) == value) return;
                SetData(2296, value, nameof(Music_Skill_Extend_Time_MR_Master));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Music_Skill_Extend_Time_MR_Master));
            }
        }

        public const string Music_Skill_Major_Heal_Rand_Rate_displayName = "Music Skill: Major Heal: Rand Rate";
        public const int Music_Skill_Major_Heal_Rand_Rate_sortIndex = 49750;
        [SortOrder(Music_Skill_Major_Heal_Rand_Rate_sortIndex)]
        [DisplayName(Music_Skill_Major_Heal_Rand_Rate_displayName)]
        public virtual float Music_Skill_Major_Heal_Rand_Rate {
            get => GetData<float>(2300);
            set {
                if (GetData<float>(2300) == value) return;
                SetData(2300, value, nameof(Music_Skill_Major_Heal_Rand_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Music_Skill_Major_Heal_Rand_Rate));
            }
        }

        public const string Music_Skill_Major_Heal_Rand_Master_Rate_displayName = "Music Skill: Major Heal: Rand Master Rate";
        public const int Music_Skill_Major_Heal_Rand_Master_Rate_sortIndex = 49800;
        [SortOrder(Music_Skill_Major_Heal_Rand_Master_Rate_sortIndex)]
        [DisplayName(Music_Skill_Major_Heal_Rand_Master_Rate_displayName)]
        public virtual float Music_Skill_Major_Heal_Rand_Master_Rate {
            get => GetData<float>(2304);
            set {
                if (GetData<float>(2304) == value) return;
                SetData(2304, value, nameof(Music_Skill_Major_Heal_Rand_Master_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Music_Skill_Major_Heal_Rand_Master_Rate));
            }
        }

        public const string Music_Skill_Major_Heal_Rand_MR_Master_Rate_displayName = "Music Skill: Major Heal: Rand MR Master Rate";
        public const int Music_Skill_Major_Heal_Rand_MR_Master_Rate_sortIndex = 49850;
        [SortOrder(Music_Skill_Major_Heal_Rand_MR_Master_Rate_sortIndex)]
        [DisplayName(Music_Skill_Major_Heal_Rand_MR_Master_Rate_displayName)]
        public virtual float Music_Skill_Major_Heal_Rand_MR_Master_Rate {
            get => GetData<float>(2308);
            set {
                if (GetData<float>(2308) == value) return;
                SetData(2308, value, nameof(Music_Skill_Major_Heal_Rand_MR_Master_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Music_Skill_Major_Heal_Rand_MR_Master_Rate));
            }
        }

        public const string Music_Skill_Heal_0_Minor_displayName = "Music Skill: Heal 0: Minor";
        public const int Music_Skill_Heal_0_Minor_sortIndex = 49900;
        [SortOrder(Music_Skill_Heal_0_Minor_sortIndex)]
        [DisplayName(Music_Skill_Heal_0_Minor_displayName)]
        public virtual float Music_Skill_Heal_0_Minor {
            get => GetData<float>(2312);
            set {
                if (GetData<float>(2312) == value) return;
                SetData(2312, value, nameof(Music_Skill_Heal_0_Minor));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Music_Skill_Heal_0_Minor));
            }
        }

        public const string Music_Skill_Heal_0_Major_displayName = "Music Skill: Heal 0: Major";
        public const int Music_Skill_Heal_0_Major_sortIndex = 49950;
        [SortOrder(Music_Skill_Heal_0_Major_sortIndex)]
        [DisplayName(Music_Skill_Heal_0_Major_displayName)]
        public virtual float Music_Skill_Heal_0_Major {
            get => GetData<float>(2316);
            set {
                if (GetData<float>(2316) == value) return;
                SetData(2316, value, nameof(Music_Skill_Heal_0_Major));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Music_Skill_Heal_0_Major));
            }
        }

        public const string Music_Skill_Heal_1_Minor_displayName = "Music Skill: Heal 1: Minor";
        public const int Music_Skill_Heal_1_Minor_sortIndex = 50000;
        [SortOrder(Music_Skill_Heal_1_Minor_sortIndex)]
        [DisplayName(Music_Skill_Heal_1_Minor_displayName)]
        public virtual float Music_Skill_Heal_1_Minor {
            get => GetData<float>(2320);
            set {
                if (GetData<float>(2320) == value) return;
                SetData(2320, value, nameof(Music_Skill_Heal_1_Minor));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Music_Skill_Heal_1_Minor));
            }
        }

        public const string Music_Skill_Heal_1_Major_displayName = "Music Skill: Heal 1: Major";
        public const int Music_Skill_Heal_1_Major_sortIndex = 50050;
        [SortOrder(Music_Skill_Heal_1_Major_sortIndex)]
        [DisplayName(Music_Skill_Heal_1_Major_displayName)]
        public virtual float Music_Skill_Heal_1_Major {
            get => GetData<float>(2324);
            set {
                if (GetData<float>(2324) == value) return;
                SetData(2324, value, nameof(Music_Skill_Heal_1_Major));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Music_Skill_Heal_1_Major));
            }
        }

        public const string Music_Skill_Heal_2_Minor_displayName = "Music Skill: Heal 2: Minor";
        public const int Music_Skill_Heal_2_Minor_sortIndex = 50100;
        [SortOrder(Music_Skill_Heal_2_Minor_sortIndex)]
        [DisplayName(Music_Skill_Heal_2_Minor_displayName)]
        public virtual float Music_Skill_Heal_2_Minor {
            get => GetData<float>(2328);
            set {
                if (GetData<float>(2328) == value) return;
                SetData(2328, value, nameof(Music_Skill_Heal_2_Minor));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Music_Skill_Heal_2_Minor));
            }
        }

        public const string Music_Skill_Heal_2_Major_displayName = "Music Skill: Heal 2: Major";
        public const int Music_Skill_Heal_2_Major_sortIndex = 50150;
        [SortOrder(Music_Skill_Heal_2_Major_sortIndex)]
        [DisplayName(Music_Skill_Heal_2_Major_displayName)]
        public virtual float Music_Skill_Heal_2_Major {
            get => GetData<float>(2332);
            set {
                if (GetData<float>(2332) == value) return;
                SetData(2332, value, nameof(Music_Skill_Heal_2_Major));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Music_Skill_Heal_2_Major));
            }
        }

        public const string Music_Skill_Hp_Up_0_displayName = "Music Skill: Hp Up 0";
        public const int Music_Skill_Hp_Up_0_sortIndex = 50200;
        [SortOrder(Music_Skill_Hp_Up_0_sortIndex)]
        [DisplayName(Music_Skill_Hp_Up_0_displayName)]
        public virtual uint Music_Skill_Hp_Up_0 {
            get => GetData<uint>(2336);
            set {
                if (GetData<uint>(2336) == value) return;
                SetData(2336, value, nameof(Music_Skill_Hp_Up_0));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Music_Skill_Hp_Up_0));
            }
        }

        public const string Music_Skill_Hp_Up_1_displayName = "Music Skill: Hp Up 1";
        public const int Music_Skill_Hp_Up_1_sortIndex = 50250;
        [SortOrder(Music_Skill_Hp_Up_1_sortIndex)]
        [DisplayName(Music_Skill_Hp_Up_1_displayName)]
        public virtual uint Music_Skill_Hp_Up_1 {
            get => GetData<uint>(2340);
            set {
                if (GetData<uint>(2340) == value) return;
                SetData(2340, value, nameof(Music_Skill_Hp_Up_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Music_Skill_Hp_Up_1));
            }
        }

        public const string Music_Skill_Mantle_Duration_displayName = "Music Skill: Mantle Duration";
        public const int Music_Skill_Mantle_Duration_sortIndex = 50300;
        [SortOrder(Music_Skill_Mantle_Duration_sortIndex)]
        [DisplayName(Music_Skill_Mantle_Duration_displayName)]
        public virtual float Music_Skill_Mantle_Duration {
            get => GetData<float>(2344);
            set {
                if (GetData<float>(2344) == value) return;
                SetData(2344, value, nameof(Music_Skill_Mantle_Duration));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Music_Skill_Mantle_Duration));
            }
        }

        public const string Music_Skill_Mantle_Duration_Put_displayName = "Music Skill: Mantle Duration Put";
        public const int Music_Skill_Mantle_Duration_Put_sortIndex = 50350;
        [SortOrder(Music_Skill_Mantle_Duration_Put_sortIndex)]
        [DisplayName(Music_Skill_Mantle_Duration_Put_displayName)]
        public virtual float Music_Skill_Mantle_Duration_Put {
            get => GetData<float>(2348);
            set {
                if (GetData<float>(2348) == value) return;
                SetData(2348, value, nameof(Music_Skill_Mantle_Duration_Put));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Music_Skill_Mantle_Duration_Put));
            }
        }

        public const string Music_Skill_Stamina_Up_Rate_displayName = "Music Skill: Stamina Up Rate";
        public const int Music_Skill_Stamina_Up_Rate_sortIndex = 50400;
        [SortOrder(Music_Skill_Stamina_Up_Rate_sortIndex)]
        [DisplayName(Music_Skill_Stamina_Up_Rate_displayName)]
        public virtual float Music_Skill_Stamina_Up_Rate {
            get => GetData<float>(2352);
            set {
                if (GetData<float>(2352) == value) return;
                SetData(2352, value, nameof(Music_Skill_Stamina_Up_Rate));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Music_Skill_Stamina_Up_Rate));
            }
        }

        public const string __50450_displayName = "-------------------------------------------------------------------------------------------";
        public const int __50450_sortIndex = 50450;
        [SortOrder(__50450_sortIndex)]
        [DisplayName(__50450_displayName)]
        [IsReadOnly]
        public virtual byte __50450 {
            get => GetData<byte>(162);
            set {
                if (GetData<byte>(162) == value) return;
                SetData(162, value, nameof(__50450));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(__50450));
            }
        }

        public const string Unk82_displayName = "Unk82";
        public const int Unk82_sortIndex = 50500;
        [SortOrder(Unk82_sortIndex)]
        [DisplayName(Unk82_displayName)]
        public virtual float Unk82 {
            get => GetData<float>(2356);
            set {
                if (GetData<float>(2356) == value) return;
                SetData(2356, value, nameof(Unk82));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk82));
            }
        }

        public const string Unk83_displayName = "Unk83";
        public const int Unk83_sortIndex = 50550;
        [SortOrder(Unk83_sortIndex)]
        [DisplayName(Unk83_displayName)]
        public virtual float Unk83 {
            get => GetData<float>(2360);
            set {
                if (GetData<float>(2360) == value) return;
                SetData(2360, value, nameof(Unk83));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk83));
            }
        }

        public const string Unk84_displayName = "Unk84";
        public const int Unk84_sortIndex = 50600;
        [SortOrder(Unk84_sortIndex)]
        [DisplayName(Unk84_displayName)]
        public virtual uint Unk84 {
            get => GetData<uint>(2364);
            set {
                if (GetData<uint>(2364) == value) return;
                SetData(2364, value, nameof(Unk84));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk84));
            }
        }

        public const string Unk85_displayName = "Unk85";
        public const int Unk85_sortIndex = 50650;
        [SortOrder(Unk85_sortIndex)]
        [DisplayName(Unk85_displayName)]
        public virtual uint Unk85 {
            get => GetData<uint>(2368);
            set {
                if (GetData<uint>(2368) == value) return;
                SetData(2368, value, nameof(Unk85));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk85));
            }
        }

        public const string Unk86_displayName = "Unk86";
        public const int Unk86_sortIndex = 50700;
        [SortOrder(Unk86_sortIndex)]
        [DisplayName(Unk86_displayName)]
        public virtual float Unk86 {
            get => GetData<float>(2372);
            set {
                if (GetData<float>(2372) == value) return;
                SetData(2372, value, nameof(Unk86));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk86));
            }
        }

        public const string Unk87_displayName = "Unk87";
        public const int Unk87_sortIndex = 50750;
        [SortOrder(Unk87_sortIndex)]
        [DisplayName(Unk87_displayName)]
        public virtual float Unk87 {
            get => GetData<float>(2376);
            set {
                if (GetData<float>(2376) == value) return;
                SetData(2376, value, nameof(Unk87));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk87));
            }
        }

        public const string Unk88_displayName = "Unk88";
        public const int Unk88_sortIndex = 50800;
        [SortOrder(Unk88_sortIndex)]
        [DisplayName(Unk88_displayName)]
        public virtual float Unk88 {
            get => GetData<float>(2380);
            set {
                if (GetData<float>(2380) == value) return;
                SetData(2380, value, nameof(Unk88));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk88));
            }
        }

        public const string Unk89_displayName = "Unk89";
        public const int Unk89_sortIndex = 50850;
        [SortOrder(Unk89_sortIndex)]
        [DisplayName(Unk89_displayName)]
        public virtual uint Unk89 {
            get => GetData<uint>(2384);
            set {
                if (GetData<uint>(2384) == value) return;
                SetData(2384, value, nameof(Unk89));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk89));
            }
        }

        public const string Unk90_displayName = "Unk90";
        public const int Unk90_sortIndex = 50900;
        [SortOrder(Unk90_sortIndex)]
        [DisplayName(Unk90_displayName)]
        public virtual uint Unk90 {
            get => GetData<uint>(2388);
            set {
                if (GetData<uint>(2388) == value) return;
                SetData(2388, value, nameof(Unk90));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk90));
            }
        }

        public const string Unk91_displayName = "Unk91";
        public const int Unk91_sortIndex = 50950;
        [SortOrder(Unk91_sortIndex)]
        [DisplayName(Unk91_displayName)]
        public virtual float Unk91 {
            get => GetData<float>(2392);
            set {
                if (GetData<float>(2392) == value) return;
                SetData(2392, value, nameof(Unk91));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk91));
            }
        }

        public const string Unk92_displayName = "Unk92";
        public const int Unk92_sortIndex = 51000;
        [SortOrder(Unk92_sortIndex)]
        [DisplayName(Unk92_displayName)]
        public virtual float Unk92 {
            get => GetData<float>(2396);
            set {
                if (GetData<float>(2396) == value) return;
                SetData(2396, value, nameof(Unk92));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk92));
            }
        }

        public const int lastSortIndex = 51050;
    }
}
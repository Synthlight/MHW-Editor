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

        public const string __1000_displayName = "------------------------------------------------------";
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

        public const string __1600_displayName = "------------------------------------------------------";
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

        public const string __2150_displayName = "------------------------------------------------------";
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

        public const string __3150_displayName = "------------------------------------------------------";
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

        public const string __3650_displayName = "------------------------------------------------------";
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

        public const string __4000_displayName = "------------------------------------------------------";
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

        public const string __4350_displayName = "------------------------------------------------------";
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

        public const string __4700_displayName = "------------------------------------------------------";
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

        public const string __5050_displayName = "------------------------------------------------------";
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

        public const string __5400_displayName = "------------------------------------------------------";
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

        public const string __5750_displayName = "------------------------------------------------------";
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

        public const string __6100_displayName = "------------------------------------------------------";
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

        public const string __6450_displayName = "------------------------------------------------------";
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

        public const string __6800_displayName = "------------------------------------------------------";
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

        public const string __7150_displayName = "------------------------------------------------------";
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

        public const string __7500_displayName = "------------------------------------------------------";
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

        public const string __7850_displayName = "------------------------------------------------------";
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

        public const string __8200_displayName = "------------------------------------------------------";
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

        public const string __8550_displayName = "------------------------------------------------------";
        public const int __8550_sortIndex = 8550;
        [SortOrder(__8550_sortIndex)]
        [DisplayName(__8550_displayName)]
        public virtual byte __8550 {
            get => GetData<byte>(3);
        }

        public const string __8600_displayName = "------------------------------------------------------";
        public const int __8600_sortIndex = 8600;
        [SortOrder(__8600_sortIndex)]
        [DisplayName(__8600_displayName)]
        public virtual byte __8600 {
            get => GetData<byte>(3);
        }

        public const string _Skipping_the_rest__8650_displayName = "------Skipping the rest.";
        public const int _Skipping_the_rest__8650_sortIndex = 8650;
        [SortOrder(_Skipping_the_rest__8650_sortIndex)]
        [DisplayName(_Skipping_the_rest__8650_displayName)]
        public virtual byte _Skipping_the_rest__8650 {
            get => GetData<byte>(3);
        }

        public const int lastSortIndex = 8700;
    }
}
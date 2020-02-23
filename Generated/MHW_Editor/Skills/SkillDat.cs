using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Skills {
    public partial class SkillDat {
        public const uint StructSize = 27;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public const string EncryptionKey = null;
        public override string UniqueId => $"{Id}|{Level}";

        public const string Id_displayName = "Id";
        public const int Id_sortIndex = 50;
        [SortOrder(Id_sortIndex)]
        [DisplayName(Id_displayName)]
        public virtual ushort Id {
            get => GetData<ushort>(0);
        }

        public const string Level_displayName = "Level";
        public const int Level_sortIndex = 100;
        [SortOrder(Level_sortIndex)]
        [DisplayName(Level_displayName)]
        public virtual byte Level {
            get => GetData<byte>(2);
        }

        public const string Unlock_Skill_1_displayName = "Unlock Skill 1";
        public const int Unlock_Skill_1_sortIndex = 150;
        [SortOrder(Unlock_Skill_1_sortIndex)]
        [DisplayName(Unlock_Skill_1_displayName)]
        [DataSource(DataSourceType.SkillDat)]
        public virtual uint Unlock_Skill_1 {
            get => GetData<uint>(3);
            set {
                if (GetData<uint>(3) == value) return;
                SetData(3, value, nameof(Unlock_Skill_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unlock_Skill_1));
                OnPropertyChanged(nameof(Unlock_Skill_1_button));
            }
        }

        [SortOrder(Unlock_Skill_1_sortIndex)]
        [DisplayName(Unlock_Skill_1_displayName)]
        [CustomSorter(typeof(UInt16Sorter))]
        public string Unlock_Skill_1_button => MainWindow.skillDatLookup.TryGet((ushort) Unlock_Skill_1, IdNamePair.Unknown((ushort) Unlock_Skill_1)).ToString();

        public const string Unlock_Skill_2_displayName = "Unlock Skill 2";
        public const int Unlock_Skill_2_sortIndex = 200;
        [SortOrder(Unlock_Skill_2_sortIndex)]
        [DisplayName(Unlock_Skill_2_displayName)]
        [DataSource(DataSourceType.SkillDat)]
        public virtual uint Unlock_Skill_2 {
            get => GetData<uint>(7);
            set {
                if (GetData<uint>(7) == value) return;
                SetData(7, value, nameof(Unlock_Skill_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unlock_Skill_2));
                OnPropertyChanged(nameof(Unlock_Skill_2_button));
            }
        }

        [SortOrder(Unlock_Skill_2_sortIndex)]
        [DisplayName(Unlock_Skill_2_displayName)]
        [CustomSorter(typeof(UInt16Sorter))]
        public string Unlock_Skill_2_button => MainWindow.skillDatLookup.TryGet((ushort) Unlock_Skill_2, IdNamePair.Unknown((ushort) Unlock_Skill_2)).ToString();

        public const string Unlock_Skill_3_displayName = "Unlock Skill 3";
        public const int Unlock_Skill_3_sortIndex = 250;
        [SortOrder(Unlock_Skill_3_sortIndex)]
        [DisplayName(Unlock_Skill_3_displayName)]
        [DataSource(DataSourceType.SkillDat)]
        public virtual uint Unlock_Skill_3 {
            get => GetData<uint>(11);
            set {
                if (GetData<uint>(11) == value) return;
                SetData(11, value, nameof(Unlock_Skill_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unlock_Skill_3));
                OnPropertyChanged(nameof(Unlock_Skill_3_button));
            }
        }

        [SortOrder(Unlock_Skill_3_sortIndex)]
        [DisplayName(Unlock_Skill_3_displayName)]
        [CustomSorter(typeof(UInt16Sorter))]
        public string Unlock_Skill_3_button => MainWindow.skillDatLookup.TryGet((ushort) Unlock_Skill_3, IdNamePair.Unknown((ushort) Unlock_Skill_3)).ToString();

        public const string Unlock_Skill_4_displayName = "Unlock Skill 4";
        public const int Unlock_Skill_4_sortIndex = 300;
        [SortOrder(Unlock_Skill_4_sortIndex)]
        [DisplayName(Unlock_Skill_4_displayName)]
        [DataSource(DataSourceType.SkillDat)]
        public virtual uint Unlock_Skill_4 {
            get => GetData<uint>(15);
            set {
                if (GetData<uint>(15) == value) return;
                SetData(15, value, nameof(Unlock_Skill_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unlock_Skill_4));
                OnPropertyChanged(nameof(Unlock_Skill_4_button));
            }
        }

        [SortOrder(Unlock_Skill_4_sortIndex)]
        [DisplayName(Unlock_Skill_4_displayName)]
        [CustomSorter(typeof(UInt16Sorter))]
        public string Unlock_Skill_4_button => MainWindow.skillDatLookup.TryGet((ushort) Unlock_Skill_4, IdNamePair.Unknown((ushort) Unlock_Skill_4)).ToString();

        public const string Param_5_displayName = "Param 5";
        public const int Param_5_sortIndex = 350;
        [SortOrder(Param_5_sortIndex)]
        [DisplayName(Param_5_displayName)]
        public virtual ushort Param_5 {
            get => GetData<ushort>(19);
            set {
                if (GetData<ushort>(19) == value) return;
                SetData(19, value, nameof(Param_5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Param_5));
            }
        }

        public const string Param_6_displayName = "Param 6";
        public const int Param_6_sortIndex = 400;
        [SortOrder(Param_6_sortIndex)]
        [DisplayName(Param_6_displayName)]
        public virtual ushort Param_6 {
            get => GetData<ushort>(21);
            set {
                if (GetData<ushort>(21) == value) return;
                SetData(21, value, nameof(Param_6));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Param_6));
            }
        }

        public const string Param_7_displayName = "Param 7";
        public const int Param_7_sortIndex = 450;
        [SortOrder(Param_7_sortIndex)]
        [DisplayName(Param_7_displayName)]
        public virtual ushort Param_7 {
            get => GetData<ushort>(23);
            set {
                if (GetData<ushort>(23) == value) return;
                SetData(23, value, nameof(Param_7));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Param_7));
            }
        }

        public const string Param_8_displayName = "Param 8";
        public const int Param_8_sortIndex = 500;
        [SortOrder(Param_8_sortIndex)]
        [DisplayName(Param_8_displayName)]
        public virtual ushort Param_8 {
            get => GetData<ushort>(25);
            set {
                if (GetData<ushort>(25) == value) return;
                SetData(25, value, nameof(Param_8));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Param_8));
            }
        }

        public const int lastSortIndex = 550;
    }
}
using System;
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Gems {
    public partial class Gem {
        public const uint StructSize = 28;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public const string EncryptionKey = null;
        public override string UniqueId => $"{Id}";

        public const string Index_displayName = "Index";
        public const int Index_sortIndex = 50;
        [SortOrder(Index_sortIndex)]
        [DisplayName(Index_displayName)]
        public virtual ushort Index {
            get => GetData<ushort>(4);
        }

        public const string Id_displayName = "Id";
        public const int Id_sortIndex = 100;
        [SortOrder(Id_sortIndex)]
        [DisplayName(Id_displayName)]
        public virtual ushort Id {
            get => GetData<ushort>(0);
        }

        public const string Size_displayName = "Size";
        public const int Size_sortIndex = 150;
        [SortOrder(Size_sortIndex)]
        [DisplayName(Size_displayName)]
        public virtual byte Size {
            get => GetData<byte>(8);
            set {
                if (GetData<byte>(8) == value) return;
                SetData(8, value, nameof(Size));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Size));
            }
        }

        public const string Skill_1_displayName = "Skill 1";
        public const int Skill_1_sortIndex = 200;
        [SortOrder(Skill_1_sortIndex)]
        [DisplayName(Skill_1_displayName)]
        [DataSource(DataSourceType.Skills)]
        public virtual ushort Skill_1 {
            get => GetData<ushort>(12);
            set {
                if (GetData<ushort>(12) == value) return;
                SetData(12, value, nameof(Skill_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Skill_1));
                OnPropertyChanged(nameof(Skill_1_button));
            }
        }

        [SortOrder(Skill_1_sortIndex)]
        [DisplayName(Skill_1_displayName)]
        [CustomSorter(typeof(ButtonSorter))]
        public string Skill_1_button => DataHelper.skillNames[MainWindow.locale].TryGet(Skill_1).ToStringWithId(Skill_1);

        public const string Skill_1_Level_displayName = "Skill 1 Level";
        public const int Skill_1_Level_sortIndex = 250;
        [SortOrder(Skill_1_Level_sortIndex)]
        [DisplayName(Skill_1_Level_displayName)]
        public virtual byte Skill_1_Level {
            get => GetData<byte>(16);
            set {
                if (GetData<byte>(16) == value) return;
                SetData(16, value, nameof(Skill_1_Level));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Skill_1_Level));
            }
        }

        public const string Skill_2_displayName = "Skill 2";
        public const int Skill_2_sortIndex = 300;
        [SortOrder(Skill_2_sortIndex)]
        [DisplayName(Skill_2_displayName)]
        [DataSource(DataSourceType.Skills)]
        public virtual ushort Skill_2 {
            get => GetData<ushort>(20);
            set {
                if (GetData<ushort>(20) == value) return;
                SetData(20, value, nameof(Skill_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Skill_2));
                OnPropertyChanged(nameof(Skill_2_button));
            }
        }

        [SortOrder(Skill_2_sortIndex)]
        [DisplayName(Skill_2_displayName)]
        [CustomSorter(typeof(ButtonSorter))]
        public string Skill_2_button => DataHelper.skillNames[MainWindow.locale].TryGet(Skill_2).ToStringWithId(Skill_2);

        public const string Skill_2_Level_displayName = "Skill 2 Level";
        public const int Skill_2_Level_sortIndex = 350;
        [SortOrder(Skill_2_Level_sortIndex)]
        [DisplayName(Skill_2_Level_displayName)]
        public virtual byte Skill_2_Level {
            get => GetData<byte>(24);
            set {
                if (GetData<byte>(24) == value) return;
                SetData(24, value, nameof(Skill_2_Level));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Skill_2_Level));
            }
        }

        public const int lastSortIndex = 400;
    }
}
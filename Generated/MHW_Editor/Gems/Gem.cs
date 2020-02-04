
using System.ComponentModel;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Gems {
    public partial class Gem {
        public const uint StructSize = 28;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        protected const string Index_displayName = "Index";
        protected const int Index_sortIndex = 50;
        [SortOrder(Index_sortIndex)]
        [DisplayName(Index_displayName)]
        private ushort Index {
            get => GetData<ushort>(4);
        }
        protected const string Id_displayName = "Id";
        protected const int Id_sortIndex = 100;
        [SortOrder(Id_sortIndex)]
        [DisplayName(Id_displayName)]
        public ushort Id {
            get => GetData<ushort>(0);
        }
        protected const string Size_displayName = "Size";
        protected const int Size_sortIndex = 150;
        [SortOrder(Size_sortIndex)]
        [DisplayName(Size_displayName)]
        public byte Size {
            get => GetData<byte>(8);
            set {
                SetData(8, value);
                OnPropertyChanged(nameof(Size));
            }
        }
        protected const string Skill_1_displayName = "Skill 1";
        protected const int Skill_1_sortIndex = 200;
        [SortOrder(Skill_1_sortIndex)]
        [DisplayName(Skill_1_displayName)]
        [DataSource(DataSourceType.Skills)]
        public ushort Skill_1 {
            get => GetData<ushort>(12);
            set {
                SetData(12, value);
                OnPropertyChanged(nameof(Skill_1));
            }
        }
        protected const string Skill_1_Level_displayName = "Skill 1 Level";
        protected const int Skill_1_Level_sortIndex = 250;
        [SortOrder(Skill_1_Level_sortIndex)]
        [DisplayName(Skill_1_Level_displayName)]
        public byte Skill_1_Level {
            get => GetData<byte>(16);
            set {
                SetData(16, value);
                OnPropertyChanged(nameof(Skill_1_Level));
            }
        }
        protected const string Skill_2_displayName = "Skill 2";
        protected const int Skill_2_sortIndex = 300;
        [SortOrder(Skill_2_sortIndex)]
        [DisplayName(Skill_2_displayName)]
        [DataSource(DataSourceType.Skills)]
        public ushort Skill_2 {
            get => GetData<ushort>(20);
            set {
                SetData(20, value);
                OnPropertyChanged(nameof(Skill_2));
            }
        }
        protected const string Skill_2_Level_displayName = "Skill 2 Level";
        protected const int Skill_2_Level_sortIndex = 350;
        [SortOrder(Skill_2_Level_sortIndex)]
        [DisplayName(Skill_2_Level_displayName)]
        public byte Skill_2_Level {
            get => GetData<byte>(24);
            set {
                SetData(24, value);
                OnPropertyChanged(nameof(Skill_2_Level));
            }
        }
    }
}
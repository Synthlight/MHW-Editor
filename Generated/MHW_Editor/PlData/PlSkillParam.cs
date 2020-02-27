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

        public const int lastSortIndex = 100;
    }
}
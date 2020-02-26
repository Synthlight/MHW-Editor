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

        public const string A_displayName = "A";
        public const int A_sortIndex = 50;
        [SortOrder(A_sortIndex)]
        [DisplayName(A_displayName)]
        public virtual float A {
            get => GetData<float>(8);
            set {
                if (GetData<float>(8) == value) return;
                SetData(8, value, nameof(A));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(A));
            }
        }

        public const int lastSortIndex = 100;
    }
}
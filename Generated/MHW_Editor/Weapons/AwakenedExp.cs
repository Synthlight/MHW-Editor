using System;
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Weapons {
    public partial class AwakenedExp {
        public const uint StructSize = 2;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public const string EncryptionKey = null;
        public override string UniqueId => $"{Level}";

        public const string Needed_Exp_for_Next_Level_displayName = "Needed Exp for Next Level";
        public const int Needed_Exp_for_Next_Level_sortIndex = 50;
        [SortOrder(Needed_Exp_for_Next_Level_sortIndex)]
        [DisplayName(Needed_Exp_for_Next_Level_displayName)]
        public virtual ushort Needed_Exp_for_Next_Level {
            get => GetData<ushort>(0);
            set {
                if (GetData<ushort>(0) == value) return;
                SetData(0, value, nameof(Needed_Exp_for_Next_Level));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Needed_Exp_for_Next_Level));
            }
        }

        public const int lastSortIndex = 100;
    }
}
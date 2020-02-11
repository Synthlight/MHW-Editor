using System.ComponentModel;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Skills {
    public partial class MusicSkill {
        public const uint StructSize = 20;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public const string EncryptionKey = "qm7psvaMXQoay7kARXpNPcLNWqsbqcOyI4lqHtxFh26HSuE6RHNq7J4e";

        public const string Song_Id_Raw_displayName = "Song Id Raw";
        public const int Song_Id_Raw_sortIndex = 50;
        [SortOrder(Song_Id_Raw_sortIndex)]
        [DisplayName(Song_Id_Raw_displayName)]
        public virtual uint Song_Id_Raw {
            get => GetData<uint>(0);
        }

        public const string Note_1_displayName = "Note 1";
        public const int Note_1_sortIndex = 100;
        [SortOrder(Note_1_sortIndex)]
        [DisplayName(Note_1_displayName)]
        public virtual MHW_Template.Weapons.NoteColorWithDisabled Note_1 {
            get => (MHW_Template.Weapons.NoteColorWithDisabled) GetData<int>(4);
            set {
                if ((MHW_Template.Weapons.NoteColorWithDisabled) GetData<int>(4) == value) return;
                SetData(4, (int) value, nameof(Note_1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Note_1));
            }
        }

        public const string Note_2_displayName = "Note 2";
        public const int Note_2_sortIndex = 150;
        [SortOrder(Note_2_sortIndex)]
        [DisplayName(Note_2_displayName)]
        public virtual MHW_Template.Weapons.NoteColorWithDisabled Note_2 {
            get => (MHW_Template.Weapons.NoteColorWithDisabled) GetData<int>(8);
            set {
                if ((MHW_Template.Weapons.NoteColorWithDisabled) GetData<int>(8) == value) return;
                SetData(8, (int) value, nameof(Note_2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Note_2));
            }
        }

        public const string Note_3_displayName = "Note 3";
        public const int Note_3_sortIndex = 200;
        [SortOrder(Note_3_sortIndex)]
        [DisplayName(Note_3_displayName)]
        public virtual MHW_Template.Weapons.NoteColorWithDisabled Note_3 {
            get => (MHW_Template.Weapons.NoteColorWithDisabled) GetData<int>(12);
            set {
                if ((MHW_Template.Weapons.NoteColorWithDisabled) GetData<int>(12) == value) return;
                SetData(12, (int) value, nameof(Note_3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Note_3));
            }
        }

        public const string Note_4_displayName = "Note 4";
        public const int Note_4_sortIndex = 250;
        [SortOrder(Note_4_sortIndex)]
        [DisplayName(Note_4_displayName)]
        public virtual MHW_Template.Weapons.NoteColorWithDisabled Note_4 {
            get => (MHW_Template.Weapons.NoteColorWithDisabled) GetData<int>(16);
            set {
                if ((MHW_Template.Weapons.NoteColorWithDisabled) GetData<int>(16) == value) return;
                SetData(16, (int) value, nameof(Note_4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Note_4));
            }
        }

        public const int lastSortIndex = 300;
    }
}
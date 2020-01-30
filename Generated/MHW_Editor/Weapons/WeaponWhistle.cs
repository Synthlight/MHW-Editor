
using System.ComponentModel;
using MHW_Template;

namespace MHW_Editor.Weapons {
    public partial class WeaponWhistle {
        public const uint StructSize = 7;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        [DisplayName("Id")]
        public uint Id {
            get => GetData<uint>(0);
        }
        [DisplayName("Note 1")]
        public MHW_Template.Weapons.Note Note_1 {
            get => (MHW_Template.Weapons.Note) GetData<byte>(4);
            set {
                SetData(4, (byte) value);
                OnPropertyChanged(nameof(Note_1));
            }
        }
        [DisplayName("Note 2")]
        public MHW_Template.Weapons.Note Note_2 {
            get => (MHW_Template.Weapons.Note) GetData<byte>(4);
            set {
                SetData(4, (byte) value);
                OnPropertyChanged(nameof(Note_2));
            }
        }
        [DisplayName("Note 3")]
        public MHW_Template.Weapons.Note Note_3 {
            get => (MHW_Template.Weapons.Note) GetData<byte>(4);
            set {
                SetData(4, (byte) value);
                OnPropertyChanged(nameof(Note_3));
            }
        }
    }
}
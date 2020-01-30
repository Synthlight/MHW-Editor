
using System.ComponentModel;
using MHW_Template;

namespace MHW_Editor.Items {
    public partial class BottleTable {
        public const uint StructSize = 6;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        [DisplayName("Close Range")]
        public MHW_Template.Weapons.CoatingType Close_Range {
            get => (MHW_Template.Weapons.CoatingType) GetData<byte>(0);
            set {
                SetData(0, (byte) value);
                OnPropertyChanged(nameof(Close_Range));
            }
        }
        [DisplayName("Power")]
        public MHW_Template.Weapons.CoatingType Power {
            get => (MHW_Template.Weapons.CoatingType) GetData<byte>(1);
            set {
                SetData(1, (byte) value);
                OnPropertyChanged(nameof(Power));
            }
        }
        [DisplayName("Paralysis")]
        public MHW_Template.Weapons.CoatingType Paralysis {
            get => (MHW_Template.Weapons.CoatingType) GetData<byte>(2);
            set {
                SetData(2, (byte) value);
                OnPropertyChanged(nameof(Paralysis));
            }
        }
        [DisplayName("Poison")]
        public MHW_Template.Weapons.CoatingType Poison {
            get => (MHW_Template.Weapons.CoatingType) GetData<byte>(3);
            set {
                SetData(3, (byte) value);
                OnPropertyChanged(nameof(Poison));
            }
        }
        [DisplayName("Sleep")]
        public MHW_Template.Weapons.CoatingType Sleep {
            get => (MHW_Template.Weapons.CoatingType) GetData<byte>(4);
            set {
                SetData(4, (byte) value);
                OnPropertyChanged(nameof(Sleep));
            }
        }
        [DisplayName("Blast")]
        public MHW_Template.Weapons.CoatingType Blast {
            get => (MHW_Template.Weapons.CoatingType) GetData<byte>(5);
            set {
                SetData(5, (byte) value);
                OnPropertyChanged(nameof(Blast));
            }
        }
    }
}
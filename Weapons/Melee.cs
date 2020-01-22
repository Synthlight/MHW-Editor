using MHW_Editor.Gems;

namespace MHW_Editor.Weapons {
    public partial class Melee : MhwItem, IWeapon, ISlots {
        public Melee(byte[] bytes, int offset) : base(bytes, offset) {
        }

        public byte Sharpness_Quality {
            get => Sharpness_Quality_Raw;
            set => Sharpness_Quality_Raw = value.Clamp((byte) 1, (byte) 118);
        }

        public byte Sharpness_Amount {
            get => Sharpness_Amount_Raw;
            set => Sharpness_Amount_Raw = value.Clamp((byte) 1, (byte) 8);
        }

        public sbyte Affinity {
            get => Affinity_Raw;
            set => Affinity_Raw = value.Clamp((sbyte) -100, (sbyte) 100);
        }
    }
}
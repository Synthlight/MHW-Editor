using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHW_Weapon_Editor.Weapons {
    public class Melee {
        public byte Rarity { get; set; }
        public byte SharpnessQuality { get; set; }
        public byte SharpnessAmount { get; set; }
        public byte Damage1 { get; set; }
        public byte Damage2 { get; set; }
        public byte Defense1 { get; set; }
        public byte Defense2 { get; set; }
        public byte Affinity { get; set; }
        public Element ElemType { get; set; }
        public byte ElemDmg1 { get; set; }
        public byte ElemDmg2 { get; set; }
        public byte HiddenElemType { get; set; }
        public byte HiddenElemDmg1 { get; set; }
        public byte HiddenElemDmg2 { get; set; }
        public byte ElderSeal { get; set; }
        public byte Slots { get; set; }
        public byte Slot1Size { get; set; }
        public byte Slot2Size { get; set; }
        public byte Slot3Size { get; set; }
        public byte Ability { get; set; }

        public int offset;
    }
}
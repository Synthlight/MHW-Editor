﻿using System.ComponentModel;
using MHW_Editor.Models;
using MHW_Template.Weapons;

namespace MHW_Editor.Items {
    public partial class KulveItemLottery : MhwItem, IHasWeaponType {
        public KulveItemLottery(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        [DisplayName("")]
        public override string Name => "None";

        public WeaponType GetWeaponType() {
            return Weapon_Type;
        }
    }
}
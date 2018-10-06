using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using MHW_Weapon_Editor.Weapons;
using Microsoft.Win32;

namespace MHW_Weapon_Editor {
    public partial class MainWindow {
        private readonly List<IWeapon> weapons = new List<IWeapon>();
        private string targetFile;

        public MainWindow() {
            InitializeComponent();

            btn_open.Click += Btn_open_Click;
            btn_slot_hack.Click += Btn_slot_hack_Click;
            btn_save.Click += Btn_save_Click;
        }

        private void Btn_open_Click(object sender, RoutedEventArgs e) {
            Open();
            if (string.IsNullOrEmpty(targetFile)) return;
            Load();

            // Cast cuz' it generates columns from the data type.
            dg_weapons.ItemsSource = null;
            if (IsMelee()) {
                dg_weapons.ItemsSource = weapons.Cast<Melee>();
            } else if (IsRanged()) {
                dg_weapons.ItemsSource = weapons.Cast<Ranged>();
            }
        }

        private void Btn_slot_hack_Click(object sender, RoutedEventArgs e) {
            if (string.IsNullOrEmpty(targetFile)) return;

            foreach (var weapon in weapons) {
                weapon.Slots = 3;
                weapon.Slot1Size = 3;
                weapon.Slot2Size = 3;
                weapon.Slot3Size = 3;
            }
        }

        private void Btn_save_Click(object sender, RoutedEventArgs e) {
            if (string.IsNullOrEmpty(targetFile)) return;
            Save();
        }

        private void Open() {
            var ofdResult = new OpenFileDialog() {
                Filter = "Melee/Ranged Weapons (*.wp_dat/wp_dat_g)|*.wp_dat;*.wp_dat_g",
                Multiselect = false
            };
            ofdResult.ShowDialog();

            targetFile = ofdResult.FileName;
        }

        private void Load() {
            weapons.Clear();

            int initialOffset;
            int weaponSize;
            int weaponBetweenOffset;

            if (IsMelee()) {
                initialOffset = Melee.WEAPON_OFFSET_INITIAL;
                weaponSize = Melee.WEAPON_SIZE;
                weaponBetweenOffset = Melee.WEAPON_OFFSET_BETWEEN;
            } else if (IsRanged()) {
                initialOffset = Ranged.WEAPON_OFFSET_INITIAL;
                weaponSize = Ranged.WEAPON_SIZE;
                weaponBetweenOffset = Ranged.WEAPON_OFFSET_BETWEEN;
            } else {
                return;
            }

            using (var wpDat = new BinaryReader(new FileStream(targetFile, FileMode.Open, FileAccess.Read))) {
                var len = wpDat.BaseStream.Length;
                var offset = initialOffset;

                do {
                    var buff = new byte[weaponSize];
                    wpDat.BaseStream.Seek(offset, SeekOrigin.Begin);
                    wpDat.Read(buff, 0, weaponSize);

                    IWeapon weapon;
                    if (IsMelee()) {
                        weapon = Melee.FromByteArray(buff);
                    } else if (IsRanged()) {
                        weapon = Ranged.FromByteArray(buff);
                    } else {
                        return;
                    }

                    weapon.Offset = offset;
                    weapons.Add(weapon);

                    offset += weaponBetweenOffset;
                } while (offset + weaponSize <= len);
            }
        }

        private void Save() {
            using (var wpDat = new BinaryWriter(new FileStream(targetFile, FileMode.Open, FileAccess.Write))) {
                foreach (var weapon in weapons) {
                    // First starts at 25, so should be safe.
                    if (weapon.Offset == 0) continue;

                    var buff = weapon.ToByteArray();

                    wpDat.Seek(weapon.Offset, SeekOrigin.Begin);
                    wpDat.Write(buff);
                }
            }
        }

        private bool IsRanged() => Path.GetExtension(targetFile) == ".wp_dat_g";
        private bool IsMelee() => Path.GetExtension(targetFile) == ".wp_dat";
    }
}
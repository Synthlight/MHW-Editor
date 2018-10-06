using System.Collections.Generic;
using System.IO;
using System.Windows;
using MHW_Weapon_Editor.Weapons;
using Microsoft.Win32;

namespace MHW_Weapon_Editor {
    public partial class MainWindow {
        protected internal const int WEAPON_SIZE = 20;
        protected internal const int WEAPON_OFFSET_INITIAL = 25;
        protected internal const int WEAPON_OFFSET_BETWEEN = 65;

        private readonly List<Melee> weapons = new List<Melee>();
        private string targetFile;

        public MainWindow() {
            InitializeComponent();

            dg_weapons.ItemsSource = weapons;

            btn_open.Click += Btn_open_Click;
            btn_slot_hack.Click += Btn_slot_hack_Click;
            btn_save.Click += Btn_save_Click;
        }

        private void Btn_open_Click(object sender, RoutedEventArgs e) {
            Open();
            if (string.IsNullOrEmpty(targetFile)) return;
            Load();
            dg_weapons.Items.Refresh();
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
                Filter = "Melee Weapons (*.wp_dat)|*.wp_dat",
                Multiselect = false
            };
            ofdResult.ShowDialog();

            targetFile = ofdResult.FileName;
        }

        private void Load() {
            weapons.Clear();

            using (var wpDat = new BinaryReader(new FileStream(targetFile, FileMode.Open, FileAccess.Read))) {
                var len = wpDat.BaseStream.Length;
                var offset = WEAPON_OFFSET_INITIAL;

                do {
                    var buff = new byte[WEAPON_SIZE];
                    wpDat.BaseStream.Seek(offset, SeekOrigin.Begin);
                    wpDat.Read(buff, 0, WEAPON_SIZE);

                    var weapon = Melee.FromByteArray(buff);
                    weapon.offset = offset;
                    weapons.Add(weapon);

                    offset += WEAPON_OFFSET_BETWEEN;
                } while (offset + WEAPON_SIZE <= len);
            }
        }

        private void Save() {
            using (var wpDat = new BinaryWriter(new FileStream(targetFile, FileMode.Open, FileAccess.Write))) {
                foreach (var weapon in weapons) {
                    // First starts at 25, so should be safe.
                    if (weapon.offset == 0) continue;

                    var buff = weapon.ToByteArray();

                    wpDat.Seek(weapon.offset, SeekOrigin.Begin);
                    wpDat.Write(buff);
                }
            }
        }
    }
}
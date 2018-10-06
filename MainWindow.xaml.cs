using System.Collections.Generic;
using System.IO;
using System.Windows;
using MHW_Weapon_Editor.Gems;
using MHW_Weapon_Editor.Weapons;
using Microsoft.Win32;

namespace MHW_Weapon_Editor {
    public partial class MainWindow {
        private readonly List<dynamic> items = new List<dynamic>();
        private string targetFile;

        public MainWindow() {
            InitializeComponent();

            btn_open.Click += Btn_open_Click;
            btn_save.Click += Btn_save_Click;
            btn_slot_hack.Click += Btn_slot_hack_Click;
            btn_gem_hack.Click += Btn_gem_hack_Click;
        }

        private void Btn_open_Click(object sender, RoutedEventArgs e) {
            Open();
            if (string.IsNullOrEmpty(targetFile)) return;
            Load();

            dg_items.ItemsSource = null;
            dg_items.ItemsSource = items;
        }

        private void Btn_save_Click(object sender, RoutedEventArgs e) {
            if (string.IsNullOrEmpty(targetFile)) return;
            Save();
        }

        private void Btn_slot_hack_Click(object sender, RoutedEventArgs e) {
            if (string.IsNullOrEmpty(targetFile)) return;

            if (!IsMelee() && !IsRanged()) return;

            foreach (var item in items) {
                IWeapon weapon = item;
                weapon.Slots = 3;
                weapon.Slot1Size = 3;
                weapon.Slot2Size = 3;
                weapon.Slot3Size = 3;
                ((dynamic) weapon).OnPropertyChanged();
            }
        }

        private void Btn_gem_hack_Click(object sender, RoutedEventArgs e) {
            if (string.IsNullOrEmpty(targetFile)) return;

            if (!IsGem()) return;

            foreach (var item in items) {
                Gem gem = item;
                gem.SkillLevel = 10;
                ((dynamic) gem).OnPropertyChanged();
            }
        }

        private void Open() {
            var ofdResult = new OpenFileDialog() {
                // ReSharper disable StringLiteralTypo
                Filter = "Weapons / Gems (*.wp_dat/_g, *.sgpa)|*.wp_dat;*.wp_dat_g;*.sgpa",
                Multiselect = false
            };
            ofdResult.ShowDialog();

            targetFile = ofdResult.FileName;
        }

        private void Load() {
            items.Clear();

            int initialOffset;
            int itemSize;
            int itemBetweenOffset;

            if (IsMelee()) {
                initialOffset = Melee.WEAPON_OFFSET_INITIAL;
                itemSize = Melee.WEAPON_SIZE;
                itemBetweenOffset = Melee.WEAPON_OFFSET_BETWEEN;
            } else if (IsRanged()) {
                initialOffset = Ranged.WEAPON_OFFSET_INITIAL;
                itemSize = Ranged.WEAPON_SIZE;
                itemBetweenOffset = Ranged.WEAPON_OFFSET_BETWEEN;
            } else if (IsGem()) {
                initialOffset = Gem.GEM_OFFSET_INITIAL;
                itemSize = Gem.GEM_SIZE;
                itemBetweenOffset = Gem.GEM_OFFSET_BETWEEN;
            } else {
                return;
            }

            using (var wpDat = new BinaryReader(new FileStream(targetFile, FileMode.Open, FileAccess.Read))) {
                var len = wpDat.BaseStream.Length;
                var offset = initialOffset;

                do {
                    var buff = new byte[itemSize];
                    wpDat.BaseStream.Seek(offset, SeekOrigin.Begin);
                    wpDat.Read(buff, 0, itemSize);

                    dynamic weapon;
                    if (IsMelee()) {
                        weapon = Melee.FromByteArray(buff);
                    } else if (IsRanged()) {
                        weapon = Ranged.FromByteArray(buff);
                    } else if (IsGem()) {
                        weapon = Gem.FromByteArray(buff);
                    } else {
                        return;
                    }

                    weapon.Offset = offset;
                    items.Add(weapon);

                    offset += itemBetweenOffset;
                } while (offset + itemSize <= len);
            }
        }

        private void Save() {
            using (var wpDat = new BinaryWriter(new FileStream(targetFile, FileMode.Open, FileAccess.Write))) {
                foreach (var item in items) {
                    // First starts at 25, so should be safe.
                    if (item.Offset == 0) continue;

                    var buff = item.ToByteArray();

                    wpDat.Seek(item.Offset, SeekOrigin.Begin);
                    wpDat.Write(buff);
                }
            }
        }

        private bool IsRanged() => Path.GetExtension(targetFile) == ".wp_dat_g";
        private bool IsMelee() => Path.GetExtension(targetFile) == ".wp_dat";
        private bool IsGem() => Path.GetExtension(targetFile) == ".sgpa";
    }
}
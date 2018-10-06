using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MHW_Weapon_Editor.Weapons;
using Microsoft.Win32;

namespace MHW_Weapon_Editor {
    public partial class MainWindow {
        private readonly List<Melee> weapons = new List<Melee>();

        public MainWindow() {
            InitializeComponent();

            var ofdResult = new OpenFileDialog() {
                DefaultExt = ".wp_dat",
                Multiselect = false,
                InitialDirectory = @"C:\SteamLibrary\steamapps\common\Monster Hunter World\"
            };
            ofdResult.ShowDialog();

            if (string.IsNullOrEmpty(ofdResult.FileName)) {
                Close();
                return;
            }

            using (var wpDat = new BinaryReader(new FileStream(ofdResult.FileName, FileMode.Open))) {
                var len = wpDat.BaseStream.Length;
                var offset = 0x19;

                do {
                    var buff = new byte[20];
                    wpDat.BaseStream.Seek(offset, SeekOrigin.Begin);
                    wpDat.Read(buff, 0, 20);

                    weapons.Add(new Melee {
                        offset = offset,
                        Rarity = buff[0],
                        SharpnessQuality = buff[1],
                        SharpnessAmount = buff[2],
                        Damage1 = buff[3],
                        Damage2 = buff[4],
                        Defense1 = buff[5],
                        Defense2 = buff[6],
                        Affinity = buff[7],
                        ElemType = (Element) buff[8],
                        ElemDmg1 = buff[9],
                        ElemDmg2 = buff[10],
                        HiddenElemType = buff[11],
                        HiddenElemDmg1 = buff[12],
                        HiddenElemDmg2 = buff[13],
                        ElderSeal = buff[14],
                        Slots = buff[15],
                        Slot1Size = buff[16],
                        Slot2Size = buff[17],
                        Slot3Size = buff[18],
                        Ability = buff[19]
                    });
                    offset += 0x41;
                } while (offset + 20 <= len);
            }

            dg_weapons.ItemsSource = weapons;
        }
    }
}
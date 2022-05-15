using System.Diagnostics.CodeAnalysis;
using System.IO;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Editor.Windows;
using MHW_Template;

namespace MHW_Editor.Structs.Weapons {
    public partial class CustomOuterWeapon : MhwSingleStructFile<CustomOuterWeapon, CustomOuterWeapon.Entries>, ITargetFile {
        public void Init(string targetFile) {
            var target = Path.GetFileNameWithoutExtension(targetFile);
            foreach (var entry in GetSingleStructList()) {
                entry.Init(target);
            }
        }

        public partial class Entries {
            private string targetType;

            [SuppressMessage("ReSharper", "ParameterHidesMember")]
            public void Init(string targetFile) {
                targetType = targetFile switch {
                    "customOuterBow" => "bow",
                    "customOuterCaxe" => "c_axe",
                    "customOuterGlance" => "g_lance",
                    "customOuterHammer" => "hammer",
                    "customOuterHbg" => "hbg",
                    "customOuterLswd" => "l_sword",
                    "customOuterLance" => "lance",
                    "customOuterLbg" => "lbg",
                    "customOuterRod" => "rod",
                    "customOuterSaxe" => "s_axe",
                    "customOuterSwd" => "sword",
                    "customOuterTachi" => "tachi",
                    "customOuterWswd" => "w_sword",
                    "customOuterWsl" => "whistle",
                    _ => targetType
                };
            }

            public string Name => DataHelper.weaponOuData[MainWindow.locale][targetType].TryGet((uint) Index);
        }
    }
}
using System.Diagnostics.CodeAnalysis;
using System.IO;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Editor.Windows;
using MHW_Template;

namespace MHW_Editor.Structs.GuildCard {
    public partial class GcData : MhwSingleStructFile<GcData, GcData.Entries>, ITargetFile {
        public void Init(string targetFile) {
            var target = Path.GetFileNameWithoutExtension(targetFile);
            foreach (var entry in GetSingleStructList()) {
                entry.Init(target);
            }
        }

        public partial class Entries {
            private string targetFile;

            [SuppressMessage("ReSharper", "ParameterHidesMember")]
            public void Init(string targetFile) {
                this.targetFile = targetFile;
            }

            [SuppressMessage("ReSharper", "ConvertIfStatementToReturnStatement")]
            public string Name {
                get {
                    if (targetFile.StartsWith("gc_data_bg")) return DataHelper.gcBackgroundsGmd[MainWindow.locale].TryGet((uint) Index * 2);
                    if (targetFile.StartsWith("gc_data_face")) return DataHelper.gcExpressionsGmd[MainWindow.locale].TryGet((uint) Index * 2);
                    if (targetFile.StartsWith("gc_data_pose")) return DataHelper.gcPosesGmd[MainWindow.locale].TryGet((uint) Index * 2);
                    if (targetFile.StartsWith("gc_data_title1")) return DataHelper.gcTitles1Gmd[MainWindow.locale].TryGet((uint) Index * 2);
                    if (targetFile.StartsWith("gc_data_title2")) return DataHelper.gcTitles2Gmd[MainWindow.locale].TryGet((uint) Index * 2);
                    return "Unknown";
                }
            }

            [SortOrder(lastSortIndex + 1)]
            [SuppressMessage("ReSharper", "ConvertIfStatementToReturnStatement")]
            public string Description {
                get {
                    if (targetFile.StartsWith("gc_data_bg")) return DataHelper.gcBackgroundsGmd[MainWindow.locale].TryGet((uint) Index * 2 + 1).Replace("\r\n", " ");
                    if (targetFile.StartsWith("gc_data_face")) return DataHelper.gcExpressionsGmd[MainWindow.locale].TryGet((uint) Index * 2 + 1).Replace("\r\n", " ");
                    if (targetFile.StartsWith("gc_data_pose")) return DataHelper.gcPosesGmd[MainWindow.locale].TryGet((uint) Index * 2 + 1).Replace("\r\n", " ");
                    if (targetFile.StartsWith("gc_data_title1")) return DataHelper.gcTitles1Gmd[MainWindow.locale].TryGet((uint) Index * 2 + 1).Replace("\r\n", " ");
                    if (targetFile.StartsWith("gc_data_title2")) return DataHelper.gcTitles2Gmd[MainWindow.locale].TryGet((uint) Index * 2 + 1).Replace("\r\n", " ");
                    return "Unknown";
                }
            }
        }
    }
}
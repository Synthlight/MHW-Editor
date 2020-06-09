using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;

namespace MHW_Editor.GuildCard {
    public partial class GcData : MhwMultiStructItem<GcData>, IShowAsSingleStruct<GcData.Entries> {
        public void Init(string targetFile) {
            foreach (var entry in GetIterableStructList()) {
                entry.Init(targetFile);
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

        public ObservableCollection<object> GetStructList() {
            return data.Last.Value.list;
        }

        public IEnumerable<Entries> GetIterableStructList() {
            return GetStructList().Cast<Entries>();
        }
    }
}
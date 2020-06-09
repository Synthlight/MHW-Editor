using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using MHW_Editor.Models;

namespace MHW_Editor.Weapons {
    public partial class ShellTable : MhwMultiStructItem<ShellTable>, IShowAsSingleStruct<ShellTable.Entries> {
        public static readonly Dictionary<byte, string> recoilLookup = new Dictionary<byte, string> {
            {0, "Normal (Recoil +1)"},

            {1, "Normal (Recoil +2) M1"},
            {2, "Normal (Recoil +2) M2"},
            {3, "Normal (Recoil +2) M3"},
            {36, "Normal (Recoil +2) M4"},

            {24, "Normal (Recoil +3) M1.2"},
            {11, "Normal (Recoil +3) M1.3"},
            {7, "Normal (Recoil +3) M1.4"},
            {20, "Normal (Recoil +3) M2.3"},
            {5, "Normal (Recoil +3) M2.4"},
            {4, "Normal (Recoil +3) M3"},
            {32, "Normal (Recoil +3) M4"},

            {25, "Normal (Recoil +4) M1.2.3"},
            {19, "Normal (Recoil +4) M1.2.4"},
            {8, "Normal (Recoil +4) M1.3"},
            {12, "Normal (Recoil +4) M1.4"},
            {13, "Normal (Recoil +4) M2.3"},
            {6, "Normal (Recoil +4) M2.4"},
            {9, "Normal (Recoil +4) M3"},
            {21, "Normal (Recoil +4)"},

            {18, "Cluster (Recoil +1)"},

            {27, "Cluster (Recoil +2) M2"},
            {14, "Cluster (Recoil +2) M3"},

            {26, "Cluster (Recoil +3) M1.4"},
            {22, "Cluster (Recoil +3) M2.3"},
            {15, "Cluster (Recoil +3) M2.4"},
            {23, "Cluster (Recoil +3) M3"},
            {16, "Cluster (Recoil +3) M4"},

            {29, "Rapid Fire (Recoil +2) M1"},
            {28, "Rapid Fire (Recoil +2) M2"},
            {30, "Rapid Fire (Recoil +2) M3"},
            {34, "Rapid Fire (Recoil +2) M4"},

            {33, "Rapid Fire (Recoil +3) M2.3"},
            {31, "Rapid Fire (Recoil +3) M3"},

            {35, "Rapid Fire (Sticky)"},

            {10, "Auto-Reload"},

            {17, "Wyvern"}
        };

        public static readonly Dictionary<byte, string> reloadLookup = new Dictionary<byte, string> {
            {17, "Fast Reload"},

            {14, "Normal Reload M1"},
            {0, "Normal Reload M2"},
            {1, "Normal Reload M3"},
            {18, "Normal Reload M4"},

            {15, "Slow Reload M1.2"},
            {3, "Slow Reload M1.3"},
            {2, "Slow Reload M1.4"},
            {16, "Slow Reload M2.3"},
            {4, "Slow Reload M2.4"},
            {5, "Slow Reload M3"},
            {11, "Slow Reload M4"},

            {19, "Very Slow Reload M1.2.3"},
            {13, "Very Slow Reload M1.2.4"},
            {8, "Very Slow Reload M1.3"},
            {12, "Very Slow Reload M1.4"},
            {20, "Very Slow Reload M1"},
            {9, "Very Slow Reload M2.3"},
            {6, "Very Slow Reload M2.4"},
            {7, "Very Slow Reload M3"},
            {10, "Very Slow Reload"}
        };

        public ObservableCollection<object> GetStructList() {
            return data.Last.Value.list;
        }

        public IEnumerable<Entries> GetIterableStructList() {
            return GetStructList().Cast<Entries>();
        }
    }
}
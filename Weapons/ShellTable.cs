using System.Collections.Generic;
using System.ComponentModel;
using MHW_Editor.Models;

namespace MHW_Editor.Weapons {
    public partial class ShellTable : MhwItem {
        public static readonly Dictionary<byte, string> recoilLookup = new Dictionary<byte, string>();
        public static readonly Dictionary<byte, string> reloadLookup = new Dictionary<byte, string>();

        static ShellTable() {
            // Recoil
            recoilLookup[0]  = "Normal (Recoil +1)";

            recoilLookup[1]  = "Normal (Recoil +2) M1";
            recoilLookup[2]  = "Normal (Recoil +2) M2";
            recoilLookup[3]  = "Normal (Recoil +2) M3";
            recoilLookup[36] = "Normal (Recoil +2) M4";

            recoilLookup[24] = "Normal (Recoil +3) M1.2";
            recoilLookup[11] = "Normal (Recoil +3) M1.3";
            recoilLookup[7]  = "Normal (Recoil +3) M1.4";
            recoilLookup[20] = "Normal (Recoil +3) M2.3";
            recoilLookup[5]  = "Normal (Recoil +3) M2.4";
            recoilLookup[4]  = "Normal (Recoil +3) M3";
            recoilLookup[32] = "Normal (Recoil +3) M4";

            recoilLookup[25] = "Normal (Recoil +4) M1.2.3";
            recoilLookup[19] = "Normal (Recoil +4) M1.2.4";
            recoilLookup[8]  = "Normal (Recoil +4) M1.3";
            recoilLookup[12] = "Normal (Recoil +4) M1.4";
            recoilLookup[13] = "Normal (Recoil +4) M2.3";
            recoilLookup[6]  = "Normal (Recoil +4) M2.4";
            recoilLookup[9]  = "Normal (Recoil +4) M3";
            recoilLookup[21] = "Normal (Recoil +4)";

            recoilLookup[18] = "Cluster (Recoil +1)";

            recoilLookup[27] = "Cluster (Recoil +2) M2";
            recoilLookup[14] = "Cluster (Recoil +2) M3";

            recoilLookup[26] = "Cluster (Recoil +3) M1.4";
            recoilLookup[22] = "Cluster (Recoil +3) M2.3";
            recoilLookup[15] = "Cluster (Recoil +3) M2.4";
            recoilLookup[23] = "Cluster (Recoil +3) M3";
            recoilLookup[16] = "Cluster (Recoil +3) M4";

            recoilLookup[29] = "Rapid Fire (Recoil +2) M1";
            recoilLookup[28] = "Rapid Fire (Recoil +2) M2";
            recoilLookup[30] = "Rapid Fire (Recoil +2) M3";
            recoilLookup[34] = "Rapid Fire (Recoil +2) M4";

            recoilLookup[33] = "Rapid Fire (Recoil +3) M2.3";
            recoilLookup[31] = "Rapid Fire (Recoil +3) M3";

            recoilLookup[35] = "Rapid Fire (Sticky)";

            recoilLookup[10] = "Auto-Reload";

            recoilLookup[17] = "Wyvern";

            // Reload
            reloadLookup[17] = "Fast Reload";

            reloadLookup[14] = "Normal Reload M1";
            reloadLookup[0]  = "Normal Reload M2";
            reloadLookup[1]  = "Normal Reload M3";
            reloadLookup[18] = "Normal Reload M4";

            reloadLookup[15] = "Slow Reload M1.2";
            reloadLookup[3]  = "Slow Reload M1.3";
            reloadLookup[2]  = "Slow Reload M1.4";
            reloadLookup[16] = "Slow Reload M2.3";
            reloadLookup[4]  = "Slow Reload M2.4";
            reloadLookup[5]  = "Slow Reload M3";
            reloadLookup[11] = "Slow Reload M4";

            reloadLookup[19] = "Very Slow Reload M1.2.3";
            reloadLookup[13] = "Very Slow Reload M1.2.4";
            reloadLookup[8]  = "Very Slow Reload M1.3";
            reloadLookup[12] = "Very Slow Reload M1.4";
            reloadLookup[20] = "Very Slow Reload M1";
            reloadLookup[9]  = "Very Slow Reload M2.3";
            reloadLookup[6]  = "Very Slow Reload M2.4";
            reloadLookup[7]  = "Very Slow Reload M3";
            reloadLookup[10] = "Very Slow Reload";
        }

        public ShellTable(byte[] bytes, ulong offset) : base(bytes, offset) {
        }

        [DisplayName("")]
        public override string Name => "None";

        [SortOrder(0)]
        public ulong Id => (Offset - InitialOffset) / StructSize;
    }
}
using System.IO;
using System.Text;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Parameters;

namespace MHW_Editor {
    public class EncryptionHelper {
        public const string PL_PARAM_KEY = "j1P15gEkgVa7NdFxiqwCPitykHctY2nZPjSaElvqb0eSwcLO1cOlTqqv"; // mParam
        public const string OWP_DAT_KEY = "FZoS8QLyOyeFmkdrz73P9Fh2N4NcTwy3QQPjc1YRII5KWovK6yFuU8SL"; // rOtomoToolLevelTbl
        public const string DTT_EDA_KEY = "Fqkpg1xx1cMlvg3AtKOCLxFgVFBwHkCbjizBRV49hWmEe5lOAaNOTm7m"; // rEmDamageAttr
        public const string DTT_EPG_KEY = "sJV4g7d55gKnQB5nS6XJ9pZ1qZmmQwNnSbidUW1OeAhHrpPd6MKbfsrt"; // rEmPartsGroup

        // The rest are untested.
        public const string SAVE_FILE_KEY = "xieZjoe#P2134-3zmaghgpqoe0z8$3azeq";
        public const string UNKNOWN_KEY_1 = "PCEBFfRCbwIdy6AZIoNA5lXV6FEki0yBEyW4FPXZUyWgeauqY8PYeZkM"; // rCharmData
        public const string UNKNOWN_KEY_2 = "ZduEVAgrFnd8jpnwHF2ur64BHcd37gEYDQwRbeBwMt6dGRK3tUwm2wx5"; // rSpecialTraceLotData
        public const string UNKNOWN_KEY_3 = "b71AMFJuw63cUTlDt5ntSAtaAvwLKizNtapy4W0QAsC39QXPr6b78Asz"; // cRomPacketSysSyncStart
        public const string UNKNOWN_KEY_4 = "Nb06gpPJ9WtbO6FF1ZYqm5NbLREsCzuqAY0G25ug2Ei5XkkAtVXD5Uda"; // rASkillData
        public const string UNKNOWN_KEY_5 = "D7N88VEGEnRl0HEHTO0xMQkbeMb37arJF488lREp90WYojAONkLoxfMt"; // rItemData
        public const string UNKNOWN_KEY_7 = "qm7psvaMXQoay7kARXpNPcLNWqsbqcOyI4lqHtxFh26HSuE6RHNq7J4e"; // Otomo stuff?
        public const string UNKNOWN_KEY_8 = "TZNgJfzyD2WKiuV4SglmI6oN5jP2hhRJcBwzUooyfIUTM4ptDYGjuRTP";
        public const string UNKNOWN_KEY_9 = "SFghFQVFJycHnypExurPwut98ZZq1cwvm7lpDpASeP4biRhstQgULzlb"; // mMoneyItemTbl

        public static void DecryptFiles() {
            const string fileRoot = @"V:\MHW\IB\chunk_combined\common";
            Decrypt(PL_PARAM_KEY, $@"{fileRoot}\pl\pl_param.plp", $@"{fileRoot}\pl\pl_param.decrypted.plp");
            Decrypt(PL_PARAM_KEY, $@"{fileRoot}\pl\pl_skill_param.plsp", $@"{fileRoot}\pl\pl_skill_param.decrypted.plsp");
            Decrypt(OWP_DAT_KEY, $@"{fileRoot}\equip\otomoWeapon.owp_dat", $@"{fileRoot}\equip\otomoWeapon.decrypted.owp_dat");
            Encrypt(OWP_DAT_KEY, $@"{fileRoot}\equip\otomoWeapon.decrypted.owp_dat", $@"{fileRoot}\equip\otomoWeapon.recrypted.owp_dat");
        }

        public static void Decrypt(string key, string inFile, string outFile) {
            var outBytes = Decrypt(key, File.ReadAllBytes(inFile));
            File.WriteAllBytes(outFile, outBytes);
        }

        public static byte[] Decrypt(string key, byte[] inBytes) {
            var cipher = new BufferedBlockCipher(new BlowfishEngine());
            cipher.Init(false, new KeyParameter(Encoding.UTF8.GetBytes(key)));

            inBytes = BSwap(inBytes);

            var outBytes = new byte[cipher.GetOutputSize(inBytes.Length)];

            var len2 = cipher.ProcessBytes(inBytes, 0, inBytes.Length, outBytes, 0);
            cipher.DoFinal(outBytes, len2);

            return outBytes;
        }

        public static void Encrypt(string key, string inFile, string outFile) {
            var outBytes = Encrypt(key, File.ReadAllBytes(inFile));
            File.WriteAllBytes(outFile, outBytes);
        }

        public static byte[] Encrypt(string key, byte[] inBytes) {
            var cipher = new BufferedBlockCipher(new BlowfishEngine());
            cipher.Init(true, new KeyParameter(Encoding.UTF8.GetBytes(key)));

            var outBytes = new byte[cipher.GetOutputSize(inBytes.Length)];

            var len2 = cipher.ProcessBytes(inBytes, 0, inBytes.Length, outBytes, 0);
            cipher.DoFinal(outBytes, len2);

            outBytes = BSwap(outBytes);

            return outBytes;
        }

        public static byte[] BSwap(byte[] data) {
            var result = new byte[data.Length];

            for (var i = 0; i < data.Length; i += 4) {
                result[i] = data[i + 3];
                result[i + 1] = data[i + 2];
                result[i + 2] = data[i + 1];
                result[i + 3] = data[i];
            }

            return result;
        }
    }
}
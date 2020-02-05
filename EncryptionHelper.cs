using System.IO;
using System.Text;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Parameters;

namespace MHW_Editor {
    public static class EncryptionHelper {
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

            outBytes = BSwap(outBytes);

            return outBytes;
        }

        public static void Encrypt(string key, string inFile, string outFile) {
            var outBytes = Encrypt(key, File.ReadAllBytes(inFile));
            File.WriteAllBytes(outFile, outBytes);
        }

        public static byte[] Encrypt(string key, byte[] inBytes) {
            var cipher = new BufferedBlockCipher(new BlowfishEngine());
            cipher.Init(true, new KeyParameter(Encoding.UTF8.GetBytes(key)));

            inBytes = BSwap(inBytes);

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
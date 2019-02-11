using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Contro_unity.Clases
{
    public class Encriptar
    {
        private static RijndaelManaged rm = new RijndaelManaged();
        public Encriptar()
        {
            //Establece el modo para el funcionamiento del algoritmo
            rm.Mode = CipherMode.CBC;
            //Establece el modo de relleno utilizando el algoritmo
            rm.Padding = PaddingMode.PKCS7;
            //Establece el tamaño, en bit, para la clave secreta
            rm.KeySize = 0x80;
            //Establece el tamaño del bloque en bit para la operacion criptografica
            rm.BlockSize = 0x80;
        }
        public static string EncryptData(string textData, string Encryptionkey)
        {
            byte[] passBytes = Encoding.UTF8.GetBytes(Encryptionkey);
            //Establece el vector de inicializacion (IV) para el algoritmo simetrico
            byte[] EncryptionkeyBytes = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
            int len = passBytes.Length;
            if (len > EncryptionkeyBytes.Length)
            {
                len = EncryptionkeyBytes.Length;
            }
            Array.Copy(passBytes, EncryptionkeyBytes, len);
            rm.Key = EncryptionkeyBytes;
            rm.IV = EncryptionkeyBytes;
            //Crea un objeto AES simetrico con la clave actual y el vector de inicializacion IV
            ICryptoTransform objtransform = rm.CreateEncryptor();
            byte[] textDataByte = Encoding.UTF8.GetBytes(textData);
            return Convert.ToBase64String(objtransform.TransformFinalBlock(textDataByte, 0, textDataByte.Length));
        }

        public static string DecryptData(string EncryptedText, string Encryptionkey)
        {
            byte[] encryptedTextByte = Convert.FromBase64String(EncryptedText);
            byte[] passBytes = Encoding.UTF8.GetBytes(Encryptionkey);
            byte[] EncryptionkeyBytes = new byte[0x10];

            int len = passBytes.Length;
            if (len > EncryptionkeyBytes.Length)
            {
                len = EncryptionkeyBytes.Length;
            }
            Array.Copy(passBytes, EncryptionkeyBytes, len);
            rm.Key = EncryptionkeyBytes;
            rm.IV = EncryptionkeyBytes;

            byte[] TextByte = rm.CreateDecryptor().TransformFinalBlock(encryptedTextByte, 0, encryptedTextByte.Length);
            return Encoding.UTF8.GetString(TextByte);
        }
    }
}

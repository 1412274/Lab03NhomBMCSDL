using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Numerics;
using System.Security.Cryptography;


namespace QLSV.DAO
{
    public class Security
    {
        public static byte[] SHA1Hash(string data)
        {
            //create new instance of md5
            SHA1 sha1 = SHA1.Create();

            //convert the input text to array of bytes
            byte[] hashData = sha1.ComputeHash(Encoding.Default.GetBytes(data));
            return hashData;
            ////create new instance of StringBuilder to save hashed data
            //StringBuilder returnValue = new StringBuilder();

            ////loop for each byte and add it to StringBuilder
            //for (int i = 0; i < hashData.Length; i++)
            //{
            //    returnValue.Append(hashData[i].ToString());
            //}

            //// return hexadecimal string
            //return returnValue.ToString();
        }
        public static byte[] MD5Hash(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));

            //get hash result after compute it
            byte[] result = md5.Hash;
            return result;
            //StringBuilder strBuilder = new StringBuilder();
            //for (int i = 0; i < result.Length; i++)
            //{
            //    //change it into 2 hexadecimal digits
            //    //for each byte
            //    strBuilder.Append(result[i].ToString("x2"));
            //}

            //return strBuilder.ToString();
        }
        public static byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
        {
            byte[] encryptedBytes = null;

            // Set your salt here, change it to meet your flavor:
            // The salt bytes must be at least 8 bytes.
            byte[] saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;

                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);

                    AES.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, AES.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
                        cs.Close();
                    }
                    encryptedBytes = ms.ToArray();
                }
            }

            return encryptedBytes;
        }

        public static byte[] AES_Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
        {
            byte[] decryptedBytes = null;

            // Set your salt here, change it to meet your flavor:
            // The salt bytes must be at least 8 bytes.
            byte[] saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;

                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);

                    AES.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, AES.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
                        cs.Close();
                    }
                    decryptedBytes = ms.ToArray();
                }
            }

            return decryptedBytes;
        }

        public static byte[] AES256EncryptText(string input, string password)
        {
            // Get the bytes of the string
            byte[] bytesToBeEncrypted = Encoding.UTF8.GetBytes(input);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            // Hash the password with SHA256
            passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

            byte[] bytesEncrypted = AES_Encrypt(bytesToBeEncrypted, passwordBytes);

            return bytesEncrypted;
        }

        public static string AES256DecryptText(byte[] bytesToBeDecrypted, string password)
        {
            // Get the bytes of the string
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

            byte[] bytesDecrypted = AES_Decrypt(bytesToBeDecrypted, passwordBytes);

            string result = Encoding.UTF8.GetString(bytesDecrypted);

            return result;
        }
    }

    public static class EncryptorRSA
    {

        public static String createKeyPair(String privateKey)//return public key
        {
            CspParameters cspParams1 = new CspParameters();
            cspParams1.KeyContainerName = privateKey;
            cspParams1.Flags = CspProviderFlags.UseMachineKeyStore;
            String publicKeyWithSize = null;
            using (RSACryptoServiceProvider provider = new RSACryptoServiceProvider(512, cspParams1))
            {
                var pubKey = provider.ToXmlString(false);

                publicKeyWithSize = IncludeKeyInEncryptionString(pubKey, 512);
            }
            return publicKeyWithSize;

        }

        private static string IncludeKeyInEncryptionString(string publicKey, int keySize)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(keySize.ToString() + "!" + publicKey));
        }

        private static void GetKeyFromEncryptionString(string rawkey, out int keySize, out string xmlKey)
        {
            keySize = 0;
            xmlKey = "";

            if (rawkey != null && rawkey.Length > 0)
            {
                byte[] keyBytes = Convert.FromBase64String(rawkey);
                var stringKey = Encoding.UTF8.GetString(keyBytes);

                if (stringKey.Contains("!"))
                {
                    var splittedValues = stringKey.Split(new char[] { '!' }, 2);

                    try
                    {
                        keySize = int.Parse(splittedValues[0]);
                        xmlKey = splittedValues[1];
                    }
                    catch (Exception e) { }
                }
            }
        }

        public static byte[] RSAencrypt(String plainTextData, String pubKey)
        {
            //for encryption, always handle bytes...
            byte[] bytesPlainTextData = System.Text.Encoding.Unicode.GetBytes(plainTextData);
            RSACryptoServiceProvider csp2 = new RSACryptoServiceProvider(512);
            int keySize = 0;
            string publicKeyXml = "";

            GetKeyFromEncryptionString(pubKey, out keySize, out publicKeyXml);
            csp2.FromXmlString(publicKeyXml);
            //apply pkcs#1.5 padding and encrypt our data 
            byte[] bytesCypherText = csp2.Encrypt(bytesPlainTextData, false);
            return bytesCypherText;

            //we might want a string representation of our cypher text... base64 will do
            //var cypherText = Convert.ToBase64String(bytesCypherText);

        }

        public static String RSAdecrypt(byte[] cypherTextData, String privateKey)
        {
            try
            {
                //we want to decrypt, therefore we need a csp and load our private key
                CspParameters cspParams2 = new CspParameters();
                cspParams2.KeyContainerName = privateKey;
                cspParams2.Flags = CspProviderFlags.UseMachineKeyStore;
                RSACryptoServiceProvider csp3 = new RSACryptoServiceProvider(512, cspParams2);

                byte[] bytesPlainTextData = csp3.Decrypt(cypherTextData, false);

                //get our original plainText back...
                String plainTextData = System.Text.Encoding.Unicode.GetString(bytesPlainTextData);

                return plainTextData;

            }
            catch (Exception)
            {
                return null;
            }
        }
    }

}

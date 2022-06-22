using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MD5Helper
    {
        //Khởi tạo Dictionary chứa key để mã hóa / giải mã
        private static readonly Dictionary<int, string> keyValuePairs = new Dictionary<int, string>()
        {
            [1] = "124wwdsffsd2_#$@24",
            [2] = "jhds*&Q&*$jfsjfssj",
            [3] = "*@ksp54wqdj23dkddw",
            [4] = "knsn21e1##@*$kkjad",
            [5] = "iuf*qdo#!(5454f88efw",
            [6] = "kjkdkfdlfslfsklfkfl",
            [7] = "54w54ewref*$fsdfkjsff",
            [8] = "239lksdkef323#(@(#&Y#@",
            [9] = "iji*$*#$jfskkja7wq8_-",
            [10] = "os$&*1242safjsjhkefeje",
            [11] = "SH8$^(hjd544/+42&$*fskj"
        };

        /// <summary>
        /// Mã hóa chuỗi ký tự với thuật toán mã hóa MD5
        /// </summary>
        /// <param name="_textNeedEncrypt">Chuỗi ký tự cần mã hóa</param>
        /// <param name="key">Vị trí của key mã hóa (key <= 11)</param>
        /// <returns>Chuỗi ký tự đã được mã hóa bằng thuật toán mã hóa MD5</returns>
        public static string Encrypt(string textNeedEncrypt, int keyLocation = 1)
        {
            if (keyLocation < 1 || keyLocation > keyValuePairs.Keys.Count)
            {
                throw new Exception("Index was out of range!");
            }
            string key = keyValuePairs[keyLocation];
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            TripleDESCryptoServiceProvider tDCSP = new TripleDESCryptoServiceProvider
            {
                Key = md5.ComputeHash(Encoding.UTF8.GetBytes(key)),
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };
            ICryptoTransform transform = tDCSP.CreateEncryptor();
            byte[] textByte = Encoding.UTF8.GetBytes(textNeedEncrypt);
            byte[] text = transform.TransformFinalBlock(textByte, 0, textByte.Length);
            string strEncrypted = Convert.ToBase64String(text);


            return strEncrypted;
        }


        /// <summary>
        /// Giải mã chuỗi ký tự đã được mã hóa bằng thuật toán mã hóa MD5
        /// </summary>
        /// <param name="_textNeedDecrypt">Chuỗi ký tự cần mã hóa</param>
        /// <param name="keyLocation">Vị trí của key đã dùng để mã hóa (key <= 11)</param>
        /// <returns>Chuỗi ký tự đã được giải mã</returns>
        public static string Decrypt(string textNeedDecrypt, int keyLocation = 1)
        {
            if (keyLocation < 1 || keyLocation > keyValuePairs.Keys.Count)
            {
                throw new Exception("Index was out of range!");
            }
            string key = keyValuePairs[keyLocation];
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            TripleDESCryptoServiceProvider tDCSP = new TripleDESCryptoServiceProvider
            {
                Key = md5.ComputeHash(Encoding.UTF8.GetBytes(key)),
                Mode = CipherMode.ECB,
                Padding = PaddingMode.PKCS7
            };

            ICryptoTransform transform = tDCSP.CreateDecryptor();
            byte[] textByte = Convert.FromBase64String(textNeedDecrypt);
            byte[] text = transform.TransformFinalBlock(textByte, 0, textByte.Length);
            string decrypted = Encoding.UTF8.GetString(text);
            return decrypted;
        }
    }
}

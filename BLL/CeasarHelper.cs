using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CeasarHelper
    {
        //chuỗi ký tự dùng để thực hiện mã hóa ceasar
        private static readonly char[] bangChuCai = {'h', 'i', 'â', 'B', 'C', 'D', 'E', 'F', 'G', 'ấ', 'p', '5', '1', 'j', '2', 'r', 'n', 'g', 'o',
                'w', '3', 'ế', 'ề', 'ệ', '4', 'a', 'e', 'f', 'ừ', 'ủ', 'ú', 's', 'x', 't', 'u', 'v', 'm', 'ê', 'á', 'à',
                'ư', 'ứ', '9', ' ', 'k', 'l', 'ử', 'L', 'M', 'N', 'O', 'P', 'Q', '6', 'b', 'c', 'ỏ', 'ó', 'ọ',
                'A', 'H', 'I', 'ũ', 'y', '8', 'q', 'z', 'J', 'K', 'R', 'd', '7', 'ù', 'ò', 'ạ', 'S', 'T', 'U', 'W', 'X', '.', 'Y', 'Z'};

        /// <summary>
        /// Mã hóa chuỗi ký tự bằng thuật toán ceasar
        /// </summary>
        /// <param name="rawText">Chuỗi ký tự cần mã hóa</param>
        /// <param name="key">Key mã hóa chuỗi ký tự</param>
        /// <returns>Chuỗi đã được mã hóa</returns>
        public static string Encrypt(string rawText, int key = 5)
        {
            string strEncrypted = "";
            for (int i = 0; i < rawText.Length; i++)
            {
                int indexOfChar = Array.IndexOf(bangChuCai, rawText[i]);
                if (indexOfChar == -1)
                    strEncrypted += rawText[i];
                else
                    strEncrypted += bangChuCai[(indexOfChar + key) % bangChuCai.Length];
            }
            return strEncrypted;
        }

        /// <summary>
        /// Giải mã chuỗi đã mã hóa bằng thuật toán ceasar
        /// </summary>
        /// <param name="rawText">Chuỗi cần giải mã</param>
        /// <param name="key">Key mã hóa của chuỗi</param>
        /// <returns>Chuỗi đã được giải mã</returns>
        public static string Decrypt(string rawText, int key = 5)
        {
            string strDecrypted = "";
            for (int i = 0; i < rawText.Length; i++)
            {
                int indexOfChar = Array.IndexOf(bangChuCai, rawText[i]);
                if (indexOfChar == -1)
                    strDecrypted += rawText[i];
                else
                    strDecrypted += (indexOfChar - key) >= 0 ? bangChuCai[(indexOfChar - key) % bangChuCai.Length] :
                        bangChuCai[(indexOfChar - key + bangChuCai.Length) % bangChuCai.Length];
            }
            return strDecrypted;
        }
    }
}

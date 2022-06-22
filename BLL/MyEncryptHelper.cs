using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MyEncryptHelper
    {
        /// <summary>
        /// Mã hóa dựa trên mã ASCII của mỗi ký tự
        /// </summary>
        /// <param name="str_input">Chuỗi cần mã hóa</param>
        /// <returns>Chuỗi đã được mã hóa</returns>
        public static string Encrypt(string str_input)
        {
            //Chuyển chuỗi ký tự thành mảng char
            char[] char_input = str_input.ToCharArray();
            //Using Linq, lambda expression, anonymous type
            //select value, index => anonymous type
            var input_withIndex = char_input.Select((val, index) => new { val, index }).ToArray();
            //Mã hóa (Mã ASCII của ký tự đó + index của nó + (Mã ASCII của ký tự liền sau nó) % 2
            var char_input_encrypted = input_withIndex.Select(c => c.val + c.index +
                  (input_withIndex.Length > c.index + 1 ? input_withIndex[c.index + 1].val % 2 : 0)).Select(c => (char)c).ToArray();
            //Chuyển thành kiểu string
            string resVal = new string(char_input_encrypted);
            return resVal;
        }

        /// <summary>
        /// Giải mã chuỗi ký tự được mã hóa
        /// </summary>
        /// <param name="str_input">Chuỗi ký tự cần giải mã</param>
        /// <returns>Chuỗi ký tự đã được giải mã</returns>
        public static string Decrypt(string str_input)
        {
            //Chuyển chuỗi ký tự thành mảng char
            char[] char_input = str_input.ToCharArray();
            int length = char_input.Length;
            for (int i = length - 1; i >= 0; i--)
            {
                char_input[i] = (char)(char_input[i] - i - (i == length - 1 ? 0 : char_input[i + 1] % 2));
            }
            string resVal = new string(char_input);
            return resVal;
        }
    }
}

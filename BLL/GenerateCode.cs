using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GenerateCode
    {
        private enum KyTu
        {
            KyTuSo = 1,
            KyTuInHoa = 2,
            KyTuThuong = 3
        }
        public static string Code()
        {
            string codeAuthentic = "";
            Random rd = new Random();
            for (int i = 0; i < 10; ++i)
            {
                KyTu kyTu = (KyTu)rd.Next(1, 4);
                switch (kyTu)
                {
                    case KyTu.KyTuSo:
                        codeAuthentic += rd.Next(0, 9).ToString();
                        break;
                    case KyTu.KyTuInHoa:
                        codeAuthentic += ((char)rd.Next(65, 91)).ToString();
                        break;
                    case KyTu.KyTuThuong:
                        codeAuthentic += ((char)rd.Next(97, 123)).ToString();
                        break;
                }
            }
            return codeAuthentic;
        }
    }
}

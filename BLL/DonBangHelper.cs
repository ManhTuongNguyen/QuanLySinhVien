using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DonBangHelper
    {
        static readonly char[] BCC = new char[]
        {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm','n', 'o','p', 'q', 'r',
            's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '1', '2', '3', '4', '5', '6', '7', '8', '9', '.',
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
            'ấ', 'ẩ', 'ú', 'ù', 'ụ', 'ứ', 'ừ', 'ử', 'á', 'ả', 'à', 'Á', 'ể', 'ủ', 'ắ', 'ò', 'ó', 'ọ', 'ệ'
        };

        private static readonly Dictionary<int, string> myKeys = new Dictionary<int, string>()
        {
            [1] = ".tD5ấÁẩ1YJ6BhgvắAqr9Uó4HQọfểKòneExSừNl8dáW3ùbụTaIiGCRúủ2ứàPVXOMLpoảFusmkZjzửywc7ệ",
            [2] = "inkfzúZNụMomGấ6áảhDùÁjắVb3JOQứ97LRừAửểavPEFeàWYlUòqCẩgHọtycủurXósI4STBdKpxw28.51ệ",
            [3] = "9túJr2UhNiyG8a.I3PLjảửTR5unSZắcKòCểọmùfbO6F7pAdQủvWHseEXYoqówkDụlừVÁxB4ấẩM1ứzgáàệ",
            [4] = "vta2zgSfGmdYHúoàxpnPLóể4Uw1CcNKMẩ83W9Zòb5ấừùJhETieáọÁứửy6ROkụsjủFBắqADI.rl7ảuQXVệ",
            [5] = "MtừasụxắP5S3zàTkả9GdOXKÁ8EbqứmFijg.ủwửHUấZùI642oeòyọ1NRúLểCQYchAẩBpr7WáfóVnJDluvệ",
            [6] = ".vtRòểSủZóWBdk1IxTouUúYùmPG5àa6Xfe8EắẩMb2A4wọHFáipnDlzVNJ9CryscừOÁKảấụL3gjửq7Qứhệ",
            [7] = "ểắYzứám4vXfJEiopòIhFUó5qOTÁHủduV2bst7aKB9ZửgàxQcNP.ọrnDừMLWkụG6wC1yRảùẩúeAjấl38Sệ",
            [8] = "adÁúEOxC3WeuVj4ửKm9ZJ7ứọzYDlnR6GụipP8ùB1MkbsSFàfẩểóNrò.LtủAXho2UyQHTắấwáIcq5vừgảệ",
            [9] = "2PKMotdUFÁqeắvnb7rHúọwấBgXDLGòIQùOfuứN1zjC8kẩá4ủJZểó9xmiửlEAY.hS3Vs5pàyừụcWRả6Taệ",
            [10] = "Sọilt3mCKgfL9ắ8YGQừsukbứUảAWửVqFể1DhpBP5òvZùcnTó4àrE72ÁMủxHzụ.NẩúIOdyoJaá6jeRwấXệ"
        };

        /// <summary>
        /// Tạo khóa với những ký tự như trong bảng chữ cái nhưng thay đổi vị trí ngẫu nhiên
        /// </summary>
        /// <returns></returns>
        public static string TaoKhoa()
        {
            string khoa = "";
            List<char> bCC1 = BCC.ToList();
            Random rand = new Random();
            int viTri;
            for (int i = 0; i < BCC.Length; ++i)
            {
                viTri = rand.Next(bCC1.Count - 1);
                khoa += bCC1[viTri].ToString();
                bCC1.RemoveAt(viTri);
            }
            return khoa;
        }


        /// <summary>
        /// Mã hóa chuỗi ký tự bằng phương pháp mã hóa đơn bảng
        /// </summary>
        /// <param name="_duLieuCanMaHoa">Chuỗi ký tự cần mã hóa</param>
        /// <param name="_khoa">Khóa dùng để mã hóa ký tự (key <= 10)</param>
        /// <returns>Chuỗi đã được mã hóa bằng phương pháp mã hóa đơn bảng</returns>
        public static string Encrypt(string duLieuCanMaHoa, int khoa = 1)
        {
            if (khoa < 1 || khoa > myKeys.Keys.Count)
            {
                throw new Exception("Index was out of range!");
            }
            string _khoa = myKeys[khoa];
            string chuoiDaMaHoa = "";
            for (int i = 0; i < duLieuCanMaHoa.Length; ++i)
            {
                int viTri = Array.IndexOf(BCC, duLieuCanMaHoa[i]);
                if (viTri == -1)
                {
                    //Ký tự không có trong bảng chữ cái, bỏ qua ký tự này và không mã hóa
                    chuoiDaMaHoa += duLieuCanMaHoa[i];
                }
                else
                {
                    chuoiDaMaHoa += _khoa[viTri];
                }
            }
            return chuoiDaMaHoa;
        }

        /// <summary>
        /// Giải mã chuỗi ký tự
        /// </summary>
        /// <param name="_duLieuCanGiaiMa">Chuỗi ký tự cần giải mã</param>
        /// <param name="_khoa">Khóa đã dùng mã hóa chuỗi ký tự (key <= 10)</param>
        /// <returns>Chuỗi đã được giải mã</returns>
        public static string Decrypt(string _duLieuCanGiaiMa, int khoa = 1)
        {
            if (khoa < 1 || khoa > myKeys.Keys.Count)
            {
                throw new Exception("Index was out of range!");
            }
            string _khoa = myKeys[khoa];
            string chuoiDaGiaiMa = "";
            for (int i = 0; i < _duLieuCanGiaiMa.Length; ++i)
            {
                int viTri = _khoa.IndexOf(_duLieuCanGiaiMa[i]);
                if (viTri == -1)
                {
                    chuoiDaGiaiMa += _duLieuCanGiaiMa[i];
                }
                else
                {
                    chuoiDaGiaiMa += BCC[viTri];
                }
            }
            return chuoiDaGiaiMa;
        }
    }
}

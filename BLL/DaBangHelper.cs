using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DaBangHelper
    {
        private readonly static char[] BCC = new char[]
            {
                'h', 'i', 'â', 'B', 'C', 'D', 'E', 'F', 'G', 'ấ', 'p', '5', '1', 'j', '2', 'r', 'n', 'g', 'o',
                'w', '3', 'ế', 'ề', 'ệ', '4', 'a', 'e', 'f', 'ừ', 'ủ', 'ú', 's', 'x', 't', 'u', 'v', 'm', 'ê', 'á', 'à',
                'ư', 'ứ', '9', ' ', 'k', 'l', 'ử', 'L', 'M', 'N', 'O', 'P', 'Q', '6', 'b', 'c', 'ỏ', 'ó', 'ọ',
                'A', 'H', 'I', 'ũ', 'y', '8', 'q', 'z', 'J', 'K', 'R', 'd', '7', 'ù', 'ò', 'ạ', 'S', 'T', 'U', 'W', 'X', '.', 'Y', 'Z'
            };

        static readonly Dictionary<int, string> myKey = new Dictionary<int, string>()
        {
            [1] = "àúâzT3KếLếỏ5Efu1N1UNdư7qkạáwL8ừUũNạlXPềgywââêKùdpóbkoếềYưwềâyNỏ8ạIúáv72.ùAJPêKfóiNấ",
            [2] = "òML4tH3QdMêũD3ứ ỏửkò 1le.JLE1Si2buyềúe1YtEù4rScqHiUJcCứHB3aLj2àUửềGQáwjúukưmế35C1yf",
            [3] = "bjepmạRâừửodwWọDhCjWệdwpệQLtSd ùoqqHLwóạ2WUbDA 3Aeừ9á6UzTnKqemấàBừPv1XưũủếyeạửCửấfc",
            [4] = "aJấyùwbh5SosC1MSũX5nnJ3duIóạHBỏulw6.ũhiyâSILạhêIừừoấpKAưLếừ5kIềGozJzứOjũUújềDcUtệUử",
            [5] = "5aFsWQmóEdửtứ ềsxJSEifúPạếũạULh59ấSiDêIpxoDọbg8YjbêvejũqTêàỏ7kIưRuùsOếaTD8ỏ8ềbWỏáũI",
            [6] = " IJAROwymấạd2c UEâplRYm6 fọUdWYXvũaT3rềPtửấl.NJo7vùUệ2M 4jn9ạệạàấUuuúMóùIư1ệùùcTứưE",
            [7] = "oXứóTừYMủeá7làứL2qMtHũũ4lYủoIPG.x4â.M4úũGSCvR6JòaệừiáAiêng5UYũRAoưàếê Y7vJ4zófêò2êạ",
            [8] = "Fứ5ưbqLdêiWnSGgSd8DếbáDFấPUgTử2òjềấrjbóIYOửủigFáciróHTúOmBúBdúTùRCâ6YâIrFaềBạóEò à ",
            [9] = "RJscfTều31nLu79óhh6T2ấPGHS3K ạxOò4HGJ1ừkêgxêáQ8rK ừ1lừdArệTtỏmùfũMcấpt7d6ấàXAjPGpCY",
            [10] = "byỏtáfFgtitAaòX8SềzMflJv9úrềGế GọyYDXửềứòcXủc3àLyâêN61ưGWếòG5zG5ư4h ạạzừYaỏbMáIếùOư"
        };


        private static char[,] BangTra = new char[BCC.Length, BCC.Length];

        public static void TaoBang()
        {
            BangTra = new char[BCC.Length, BCC.Length];
            for (int i = 0; i < BCC.Length; i++)
            {
                for (int j = 0; j < BCC.Length; j++)
                {
                    BangTra[i, j] = BCC[(i + j) % BCC.Length];
                }
            }
        }

        
        public static string TaoKhoa(int doDaiKhoa)
        {
            Random rd = new Random();
            String khoa = "";
            for (int i = 0; i < doDaiKhoa; i++)
                khoa += BCC[rd.Next(BCC.Length - 1)].ToString();
            return khoa;
        }

        /// <summary>
        /// Mã hóa chuỗi ký tự bằng phương pháp mã hóa đa bảng
        /// </summary>
        /// <param name="rawString">Chuỗi ký tự cần mã hóa</param>
        /// <param name="keyLocation">Vị trí của khóa dùng để mã hóa chuỗi ký tự (key <= 10)</param>
        /// <returns>Chuỗi ký tự mã hóa bằng phương pháp mã hóa đa bảng</returns>
        public static string Encrypt(string rawString, int keyLocation = 2)
        {
            TaoBang();
            if (keyLocation < 1 || keyLocation > myKey.Keys.Count)
            {
                throw new Exception("Index was out of range!");
            }
            string khoa = myKey[keyLocation];
            String ketQua = "";
            for (int i = 0; i < rawString.Length; i++)
            {
                char kyTuCanMaHoa = rawString[i];
                char kyTuKhoa = khoa[i];

                int viTriKyTuCanMaHoa = Array.IndexOf(BCC, kyTuCanMaHoa);

                if (viTriKyTuCanMaHoa == -1)
                {
                    ketQua += kyTuCanMaHoa;
                }
                else
                {
                    int viTriKyTuKhoa = -1;
                    for (int j = 0; j < BCC.Length; j++)
                    {
                        if (BCC[j] == kyTuKhoa)
                        {
                            viTriKyTuKhoa = j;
                            break;
                        }
                    }
                    ketQua += BangTra[viTriKyTuKhoa, viTriKyTuCanMaHoa];
                }
            }
            return ketQua;
        }

        /// <summary>
        /// Giải mã chuỗi ký tự bị mã hóa bằng phương pháp đa bảng
        /// </summary>
        /// <param name="rawString">Chuỗi ký tự cần giải mã</param>
        /// <param name="keyLocation">Vị trí của khóa dùng để giải mã chuỗi ký tự (key <= 10)</param>
        /// <returns>Chuỗi ký tự sau khi giải mã</returns>
        public static string Decrypt(string rawString, int keyLocation = 2)
        {
            TaoBang();
            if (keyLocation < 1 || keyLocation > myKey.Keys.Count)
            {
                throw new Exception("Index was out of range!");
            }
            string khoa = myKey[keyLocation];
            String ketQua = "";
            for (int i = 0; i < rawString.Length; i++)
            {
                char kyTuCanGiaiMa = rawString[i];
                char kyTuKhoa = khoa[i];

                // Tim vi tri cua ky tu khoa trong BCC
                int viTriKhoa = Array.IndexOf(BCC, kyTuKhoa);

                // Tim vi tri ky tu can giai ma trong dong viTriKhoa o bang tra
                int viTriKyTuCanGiaiMa = -1;
                for (int j = 0; j < BCC.Length; j++)
                {
                    if (BangTra[viTriKhoa, j] == kyTuCanGiaiMa)
                    {
                        viTriKyTuCanGiaiMa = j;
                        break;
                    }
                }

                if (viTriKyTuCanGiaiMa == -1)
                {
                    //Ky tu can giai ma khong co trong bang tra
                    ketQua += kyTuCanGiaiMa;
                }
                else
                {
                    ketQua += BCC[viTriKyTuCanGiaiMa];
                }
            }
            return ketQua;
        }
    }
}

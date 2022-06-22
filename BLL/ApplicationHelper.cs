using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ApplicationHelper
    {
        /// <summary>
        /// Tính toán thời gian chênh lệch giữa hai thời điểm
        /// </summary>
        /// <param name="time1">Thời gian thứ nhất</param>
        /// <param name="time2">Thời gian thứ hai</param>
        /// <returns>Số giây chênh lệch của thời gian thứ hai đối với thời gian thứ nhất</returns>
        public static double CaculateTimeDifferent(string time1, string time2)
        {

            DateTime timer1 = Convert.ToDateTime(time1);
            DateTime timer2 = Convert.ToDateTime(time2);

            TimeSpan duration = timer2.Subtract(timer1);

            return duration.TotalSeconds;
        }

        public static void WriteDictionaryToFile(Dictionary<string, string> myDictionary, string fileName)
        {
            String csv = String.Join(
                            Environment.NewLine,
                            myDictionary.Select(d => $"{d.Key};{d.Value};")
                        );
            File.WriteAllText(fileName, csv);
        }

        public static Dictionary<string, string> ReadDictionaryFromFile(string pathToCsvFile)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            using (var reader = new StreamReader(pathToCsvFile))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (line == null)
                        continue;
                    var values = line.Split(';');
                    dictionary.Add(values[0], values[1]);
                }
            }

            return dictionary;
        }

        public static string GetPublicIPV4()
        {
            List<string> services = new List<string>()
            {
                "https://ipinfo.io/ip",
                "https://ipecho.net/plain",
                "https://api.ipify.org",
                "https://checkip.amazonaws.com",
                "https://wtfismyip.com/text",
                "http://icanhazip.com",
            };
            using (var webclient = new WebClient())
                foreach (var service in services)
                {
                    try
                    {
                        return webclient.DownloadString(service);
                    }
                    catch
                    {

                    }
                }
            return "";
        }

        public static string GetLocalHostName()
        {
            return Dns.GetHostName();
        }

        public static string MessageError()
        {
            string message = "OPPS...!" + Environment.NewLine;
            message += "Có một lỗi chưa xác định đã phát sinh!" + Environment.NewLine;
            message += "Vui lòng liên hệ với tôi qua địa chỉ: Mtuongpk@gmail.com" + Environment.NewLine;
            message += "để được biết thêm thông tin cho tiết!" + Environment.NewLine;
            message += "Rất xin lỗi khi để xảy ra sự cố đáng tiếc này!";
            return message;
        }

        private static readonly string[] VietnameseSigns = new string[]
        {

            "aAeEoOuUiIdDyY",
            "áàạảãâấầậẩẫăắằặẳẵ",
            "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",
            "éèẹẻẽêếềệểễ",
            "ÉÈẸẺẼÊẾỀỆỂỄ",
            "óòọỏõôốồộổỗơớờợởỡ",
            "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",
            "úùụủũưứừựửữ",
            "ÚÙỤỦŨƯỨỪỰỬỮ",
            "íìịỉĩ",
            "ÍÌỊỈĨ",
            "đ",
            "Đ",
            "ýỳỵỷỹ",
            "ÝỲỴỶỸ"
        };

        public static string RemoveSignForVietnameseString(string str)
        {
            for (int i = 1; i < VietnameseSigns.Length; i++)
            {
                for (int j = 0; j < VietnameseSigns[i].Length; j++)
                    str = str.Replace(VietnameseSigns[i][j], VietnameseSigns[0][i - 1]);
            }
            return str;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RSAHelper
    {
        /// <summary>
        /// Dictionary lưu trữ các khóa chung, dùng để mã hóa dữ liệu
        /// </summary>
        private static readonly Dictionary<int, string> publicKeys = new Dictionary<int, string>()
        {
            [1] = "<RSAKeyValue><Modulus>0Tf1/qhJ+qu66cT3opFypM8rWAye5QEjaJV7FHi+wdqj" +
            "WaP1c/p5O53qpdrkgTL+wrontIAMLUZwrrvWkUWHnBqdGNTHm5s1x+gsJB0mN8Xof+XOIO1rUB9" +
            "CZd7wbz6SxqZS9ZFFaThRjUv1wa7ggFcErS5RDGsLa21PwWM9Qo0=</Modulus><Exponent>AQA" +
            "B</Exponent></RSAKeyValue>",
            [2] = "<RSAKeyValue><Modulus>sXnDH2km48iLldNS574CiC62SsT+VxGT11D9IXbjy4oOIi2P" +
            "Y0IcNm/iUrppNSSFq2HWWnPXULjLu+Pnd4b6IKlqPtTd7/4/x0xxiba7Q60Qidkuo5jJDLVilHoO" +
            "my17ptgkfsegoLslaDUhMEqUbuc6NVIiWGKZcvBDLKhymqE=</Modulus><Exponent>AQAB</Ex" +
            "ponent></RSAKeyValue>",
            [3] = "<RSAKeyValue><Modulus>yonwY0C+YcC8H29/wZ4r2CNFHZ37XfaVBfI/LvdPU" +
            "H9mDiyOsoKDmG5GJwLfuelJyTixFNSejlgw/uXd+Moa7xug0Ev5beTJArdy15y6gOB56" +
            "IYGbRZhQYiDQdkQa4xZ5hna4ek5v3TzLz2cXP4uPll99TKdTyLwIa0xMi77cBU=</Mo" +
            "dulus><Exponent>AQAB</Exponent></RSAKeyValue>",
            [4] = "<RSAKeyValue><Modulus>m7lwVNhRvAhrSQvnCzv4HdsK5G6kZE4y6z" +
            "dAUF8qdrOHyueEqQwTVliC4YO+Jo49NNuY0YYd6Vt7jiuihk1Pz7OuD7xqDLSQ" +
            "0Z9DsJEqjfsu0qmwtnCz6URWSPnpl2SBejpqgv5qo8UxOTUpfN4AHjAiNcnlHm" +
            "dFa3PPnSni3Zk=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>",
            [5] = "<RSAKeyValue><Modulus>rU8wQENQiJXD++35gvNCy9E6hPONfXcSe4" +
            "ze8DnXwgNHVy/CeTpWCCYSbXGGhSW2KxyuPUTl43qFh/FU201BL3rgQZ2B1kyf" +
            "tavHBk8REBJOZtHkOXVe7mG1aP2FPdypaBanOyuEZz2gWb+aCnRXE/HxbXQbap" +
            "7uSAtcu0EA1xE=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>"
        };

        /// <summary>
        /// Dictionary dùng để lưu trữ khóa riêng ứng với mỗi khóa chung,
        /// dùng để giải mã dữ liệu đã bị mã hóa bằng khóa riêng tương ứng
        /// </summary>
        private static readonly Dictionary<int, string> privateKeys = new Dictionary<int, string>()
        {
            [1] = "<RSAKeyValue><Modulus>0Tf1/qhJ+qu66cT3opFypM8rWAye5QEjaJV7FHi+wdqjWaP1c/p5" +
            "O53qpdrkgTL+wrontIAMLUZwrrvWkUWHnBqdGNTHm5s1x+gsJB0mN8Xof+XOIO1rUB9CZd7wbz6SxqZS9" +
            "ZFFaThRjUv1wa7ggFcErS5RDGsLa21PwWM9Qo0=</Modulus><Exponent>AQAB</Exponent><P>59Jv" +
            "fcYh62M4TIbjuaEaHkX5GFP2LMshQChHsS2ZJS4JTu4N/wYANzg0WRrJo4V7hw5h/hX7lh0q0gHiUVjVZw" +
            "==</P><Q>5woFteDeNAVGFWkbo7FdAXoQcLsZrRbhsqyXOgdukx68cGZiCrQb4Z1PHhxdUuaGG33KQDV4D" +
            "vOUwr243SSb6w==</Q><DP>Nv5x2nl1NHz+LxFU1oWER6g71mycmrW5dpnXoA18JhjMtn+8rEIFLRRVPsof" +
            "CX6x9jEQSBF49HyI2vb9dGTJgw==</DP><DQ>wXkqGQnK6eM0sj9Hrwea696tH8n+kW0k6bwQE78fgMHvaWz" +
            "DU1VKN9/E3mFAYWi8Cw+Gq8ha1qJyA7ZetYmvqw==</DQ><InverseQ>fwMXaHRmzP4ZU7x17O8lBB1ULLr" +
            "/QxDBKuIQJ6hBFoG5FU7VIuL7MPChEJYDYnkQpyYgeX5bA11f2LTvHkYLtA==</InverseQ><D>tW6jHCjSp" +
            "tg/6jPOUCNz2OpzexLOxGcdTre6mYEwY6n32GewFtiSQ5npf9T4LfaMKVAH2KbmaGjalRz9sNMsCilBMGUtgs" +
            "h0uRr4kyHrPviYxDQf2W4otk0d2lcJIHi3wlaPSDrIGaSBC4F7nW7yT2Kv0ZjUMa0Ween+77L02T0=</D></RSAKeyValue>",
            [2] = "<RSAKeyValue><Modulus>sXnDH2km48iLldNS574CiC62SsT+VxGT11D9IXbjy4oOIi2PY0IcNm/" +
            "iUrppNSSFq2HWWnPXULjLu+Pnd4b6IKlqPtTd7/4/x0xxiba7Q60Qidkuo5jJDLVilHoOmy17ptgkfsegoL" +
            "slaDUhMEqUbuc6NVIiWGKZcvBDLKhymqE=</Modulus><Exponent>AQAB</Exponent><P>0U2DR9wWA3v" +
            "5qjduPXMa/j0GdcRNkFNdzLgdlUdxV8uTU4Z0wfjN4lu9nJxzJVrPXUJZ6gd4BsrfQC5NPrXo1w==</P><" +
            "Q>2RJq47WSg17pqy4zUW+VIbRRup7qAL3uLMtcKWvDR4s4uU8C7Qiuwn46JDFbNefqkuxlsTb4vr26FpaN" +
            "W+VRRw==</Q><DP>f1jdLqTPVBFjh9iwH31giB4TRyZIVy8SHFRN050jblqz6hceBUNf6YEOLjLWsHy/PKv" +
            "5TzZ6Jg/bpA5H+4btAw==</DP><DQ>bh4Xt1g+8QHPDBWt1twCDU0KQN+o2aOAFZ08LY8LS1nm9qqMU26a" +
            "KPQbzoxzNs9lgg8GL3YxjaF1q0vIfhvAtQ==</DQ><InverseQ>GtopENJi5GB3mbGddrxt4pISwoP+rwh" +
            "46d/2GF+tp6BVfGtIlbutjWQ6l6VbLJHY33EKSK5tI025LoX2oqVD1w==</InverseQ><D>rJAzPFh22ua" +
            "FasHWi8RCG/4ne539m9VYhfSWnDJIngD3ax4XnLCMVBYH3t6oK2b+nbx8uuiGBFQarO+Vga/5hagAdJuYs" +
            "qiRreLpbetId3exTAzO9pSug7Vo4kooPhiaFy+2ALVdD66p3YcOCFy1epr3Rpb1FKCw4JORsuEIeS0=</D></RSAKeyValue>",
            [3] = "<RSAKeyValue><Modulus>yonwY0C+YcC8H29/wZ4r2CNFHZ37XfaVBfI/LvdPUH9mDiyOso" +
            "KDmG5GJwLfuelJyTixFNSejlgw/uXd+Moa7xug0Ev5beTJArdy15y6gOB56IYGbRZhQYiDQdkQa4xZ" +
            "5hna4ek5v3TzLz2cXP4uPll99TKdTyLwIa0xMi77cBU=</Modulus><Exponent>AQAB</Exponent" +
            "><P>5NAwybwFhDPP3xJDx7JnXA7WLDweGFBKV822K4NjeGhVYKM0+9nOitgecD4OB56eUjDEV98HQS" +
            "UX+kBD0RDVMw==</P><Q>4pqPS4nJZdayp+fhi89dNJz/hwNcrpKgZWbZ9KQJxxwLSsEbxNqNoHtm4" +
            "pg+3yPEPGY3gsL9MEubd0aMCC2Vlw==</Q><DP>K2FRLp4ICbVs/qTO1uh68hgaAM7xAbkPLzBgDkX" +
            "dsPFO5oBqxijYILiypKMPM+CdsYVvZB1zmaU3s4lFkjh3ww==</DP><DQ>2nfIzzr4QIbNl7Onb/Ns" +
            "GN2EPdav9F7I5PpUB9he1Ofkux2SeCd9g8t1VeESPG9vMgwaWKdFEtrR+By7xOat4Q==</DQ><Inve" +
            "rseQ>S3CF4TzFk4H69lCo3UTel73KJGPsAsCfwgVcpvgYie3Mu7AVrMyACGer5BXgi3eq+zWehNH52" +
            "BCn/MIpaYkVzQ==</InverseQ><D>FCi0l3xrNpmTX+GeKqxOmt2v1GnUCh8v5/6bkVYmO9HiW4jNz" +
            "zC0XmijbOCZWgzBPlj5LySWf36Bqe1BMbEUCwk1tFlteWZlraalbMFi90NONItsJ9QHtCXaOFA6SI1" +
            "nNzeub3ZECITccnIesp1SK/c/FBRQu7d9AoDHza/Q94U=</D></RSAKeyValue>",
            [4] = "<RSAKeyValue><Modulus>m7lwVNhRvAhrSQvnCzv4HdsK5G6kZE4y6zdAUF8qdrOHyueEq" +
            "QwTVliC4YO+Jo49NNuY0YYd6Vt7jiuihk1Pz7OuD7xqDLSQ0Z9DsJEqjfsu0qmwtnCz6URWSPnpl2" +
            "SBejpqgv5qo8UxOTUpfN4AHjAiNcnlHmdFa3PPnSni3Zk=</Modulus><Exponent>AQAB</Expon" +
            "ent><P>wkG7HH5thLIJlpBB7sw+zyLXttZHHuynH4HUceh+/AX6XwQpcww1gpA/RldlsRoEphxHj3" +
            "xoTmXU0tPv8enGvw==</P><Q>zThoQ7qk1BgJDET/fceGGIHaoMYtOqLkHXel7K1WqupbdG5qTxdp" +
            "KIqbVHgbnQJ8BA1PTaj6JGebwLpyeHqJpw==</Q><DP>CTooEiVrPFdcnztA9n/bJ+mmx3eML0rcc" +
            "WGwXqzFg2EhUGwZL+7Ph+EkMEoseWob+Gv1djpZlge+QTlx91K8bw==</DP><DQ>k5gD9OIhdaCrs" +
            "TVWgwGiwbFyqbqeANPyN/c7UFMCR/4xNDXNI4D00oGNYVzYjz2gL9HavUHQVapmbGArv9ZxdQ==</" +
            "DQ><InverseQ>JhSOzKJPzpZL78MubpZPJ5AZlZEANDkjRLQpE6YqQPIWzTYPOew3EigXBbAk8jyc" +
            "0+rLLdggrK8obJFrJyAHJg==</InverseQ><D>FdzeEXthVkXUUigSovgjaIWlLNb/y3lTGsTiCaa" +
            "ivpGMAgepD1a7rEa28VResOkNXMtr1BbBQk7utNIZekOGbcmVZJy4351c9NlZ486+QLK2lL0RTQoU" +
            "uALOm88g3jVwGC1Ap9zNl8DG3TdMZM4ZxbbWZfGVJZ037wfnAIl8CfU=</D></RSAKeyValue>",
            [5] = "<RSAKeyValue><Modulus>rU8wQENQiJXD++35gvNCy9E6hPONfXcSe4ze8DnXwgNHVy/Ce" +
            "TpWCCYSbXGGhSW2KxyuPUTl43qFh/FU201BL3rgQZ2B1kyftavHBk8REBJOZtHkOXVe7mG1aP2FPd" +
            "ypaBanOyuEZz2gWb+aCnRXE/HxbXQbap7uSAtcu0EA1xE=</Modulus><Exponent>AQAB</Expon" +
            "ent><P>yIFnz5EaUCz70wPag0zxMHGx9iHf6I3/4BgzLeEPWtPKY3aTEAT1THOLC2snahK+I3Yztm" +
            "aTS9WgsDZUtunyfw==</P><Q>3UbUQw/nu3pq4Bme0wRmzMBmQKr67nit+tVNlrcgFLwVD0+nRHkj" +
            "9l3Bk9gLvUBC6imk4DQERw7O4hTCg1JObw==</Q><DP>FHh5w8xZtmPRVgrnrU4Wtc51z95HgPO2c" +
            "welegKnUaub1ynM++61qJeHU6QeAwtk1DQGNZIlabGm1TbG0WHzOw==</DP><DQ>2TD3kaef9nYPR" +
            "03+hfNRD/Jdq2XoDYBojMcndCLlG1UNeszdSql5Mg4OvpYV17mmtH8RtXt5I2IWkPR9hDaagw==</" +
            "DQ><InverseQ>kma0+fZzja6zo25RpPMNNvCO+qnLfevQsk58j7rCU+hO1xwv11OY7bCC3zfEhBsF" +
            "3juwXCGxRrwiHZDW5MNG6Q==</InverseQ><D>XLY3Frmr9FVB8Zyd1MqzmfsEtijgMRUowwVaIeK" +
            "fpD9Cw8Zd36Iwcc2EIB4SG1pQOIHwSAB6hpV9p3qXrXWHf7A2WIixu3pCG2T0tuA/F4fbi8V12/0T" +
            "MvmnKXiCgCwm86zPajadPcwFRX1eV3Dw0/ZmGh/gkYYoIjCqGjgwpC0=</D></RSAKeyValue>"
        };
        
        // Hàm xuất khóa chung và khóa riêng để mã hóa và giải mã với RSA
        /*
        public string XuatKhoaChung()
        {
            RSACryptoServiceProvider rSA = new RSACryptoServiceProvider();
            return rSA.ToXmlString(false);
        }
        public string XuatKhoaRieng()
        {
            RSACryptoServiceProvider rSA = new RSACryptoServiceProvider();
            return rSA.ToXmlString(true);
        }
        */
        

        static byte[] Encrypt(byte[] dataNeedEncrypt, string publicKey)
        {
            RSACryptoServiceProvider rSA = new RSACryptoServiceProvider();
            rSA.FromXmlString(publicKey);
            byte[] dataEncryped = rSA.Encrypt(dataNeedEncrypt, false);
            return dataEncryped;
        }

        public static string Encrypt(string rawText, int keyLocation)
        {
            if (keyLocation < 1 || keyLocation > publicKeys.Keys.Count)
            {
                throw new Exception("Index was out of range!");
            }
            string publicKey = publicKeys[keyLocation];
            byte[] dataNeedEncrypt = Encoding.UTF8.GetBytes(rawText);
            byte[] dataEncrypted = Encrypt(dataNeedEncrypt, publicKey);
            return Convert.ToBase64String(dataEncrypted);
        }

        static byte[] Decrypt(byte[] dataNeedDecrypt, string privateKey)
        {
            RSACryptoServiceProvider rSA = new RSACryptoServiceProvider();
            rSA.FromXmlString(privateKey);
            byte[] dataDecrypted = rSA.Decrypt(dataNeedDecrypt, false);
            return dataDecrypted;
        }

        public static string Decrypt(string rawText, int keyLocation)
        {
            if (keyLocation < 1 || keyLocation > publicKeys.Keys.Count)
            {
                throw new Exception("Index was out of range!");
            }
            string privateKey = privateKeys[keyLocation];
            byte[] dataNeedDecrypt = Convert.FromBase64String(rawText);
            byte[] dataDecrypted = Decrypt(dataNeedDecrypt, privateKey);
            return Encoding.UTF8.GetString(dataDecrypted);
        }
    }
}

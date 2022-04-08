using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace tpmodul7_1302204014
{
    internal class Program
    {
        public static int CONFIG1 { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Berapa suhu badan anda saat ini?", CONFIG1);
            Console.WriteLine("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala deman? ");

        }

        public class covidConfig
        {
            string CONFIG1 = "Celsius";
            int CONFIG2 = 14;
            string CONFIG3 = "Anda tidak diperbolehkan masuk ke dalam gedung ini";
            string CONFIG4 = "Anda dipersilahkan untuk masuk ke dalam gedung ini";
            var json = @"{""satuan_suhu"": ""CONFIG1"",
                        ""batas_hari_deman"": ""CONFIG2"",
                        ""pesan_ditolak"": ""CONFIG3"",
                        ""pesan_diterima"": ""CONFIG4""}";
        }
}
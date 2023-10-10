using System;

namespace Decision_Making_with_different_Method
{
    class InputData
    {
        // Deklarasi Variabel
        public static double nilM;
        public static double nilB;
        public static double rerata;
        public static string status;

        // Membuat Method
        public void Data()
        {
            // Display "Masukkan Nilai Matematika"
            Console.Write("Masukkan Nilai Matematika =");

            // Accept Nilai Matematika
            nilM = Convert.ToDouble(Console.ReadLine());

            // Display "Masukkan Nilai Bahasa Inggris"
            Console.Write("Masukkan Nilai Bahasa Inggris =");

            // Accept Nilai Bahasa Inggris
            nilB = Convert.ToDouble(Console.ReadLine());
        }
    }
    class ProsesData
    {
        // Membuat Method Proses rerata
        public double Compute()
        {
            // Memanggil rerata,nilM,nilB pada class InputData
            InputData.rerata = (InputData.nilM + InputData.nilB) / 2;
            return InputData.rerata;
        }
    }
    class OutputData
    {
        // Membuat method menampilkan
        public void Keluar()
        {
            // Menggunakan IF ELSE untuk eksekusi status
            // Memanggil rerata,nilM,nilB,status pada class InputData
            if (InputData.rerata >= 60 && InputData.nilM >= 70)
            {
                InputData.status = "Lulus";
            }
            else
            {
                InputData.status = "Gagal";
            }
            Console.WriteLine("Status Peserta Adalah {0}", InputData.status);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Membuat Objek
            InputData xx = new InputData();
            ProsesData yy = new ProsesData();
            OutputData zz = new OutputData();

            // Memanggil Objek 
            xx.Data();
            yy.Compute();
            zz.Keluar();
        }
    }
}
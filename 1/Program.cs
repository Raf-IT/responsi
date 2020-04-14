using System;
using System.Runtime.CompilerServices;
namespace ResponsiPemrograman2707
{
    class KARYAWAN
    {
        public string NIK { set; get; }
        public string NAMA { set; get; }
        public int GAJIBULANAN { set; get; }
        public int newGAJI { set; get; }
        public KARYAWAN(string newNIK, string newNAMA, int newGAJIBULANAN)
        {
            NIK = newNIK; NAMA = newNAMA; GAJIBULANAN = newGAJIBULANAN;
            if (newGAJIBULANAN < 0)
            {
                GAJIBULANAN = 0;
            }
        }
        public void getGAJIBARU()
        {
            int BONUSGAJI = GAJIBULANAN / newGAJI;
            GAJIBULANAN = GAJIBULANAN + BONUSGAJI;
            Console.WriteLine("{0} {1}\t\t\t{2}", NIK, NAMA, GAJIBULANAN);
        }
        public void getKARYAWAN()
        {
            Console.WriteLine("{0} {1}\t\t\t{2}", NIK, NAMA, GAJIBULANAN);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NIK/NAMA\t\t\tGAJIBULANAN\n-------------------------------");
            KARYAWAN KARI1 = new KARYAWAN("19112707", "AZIZ", 5000000);
            KARI1.getKARYAWAN();

            KARYAWAN KARI2 = new KARYAWAN("19119999", "LAIYO", 4000000);
            KARI2.getKARYAWAN();

            Console.WriteLine("NIK/NAMA\t\t\tGAJI BULANAN\n-------------------------------");
            KARI1.newGAJI = 10;
            KARI1.getGAJIBARU();
            KARI2.newGAJI = 10;
            KARI2.getGAJIBARU();
        }
    }
}




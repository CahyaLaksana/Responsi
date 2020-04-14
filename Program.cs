using System;

namespace responsi
{

   public class Karyawan
    {
        
        public int no { get; set; }
        public int nik { get; set; }
        public string nama { get; set; }
        public int gaji { get; set; }
        
        
        public Karyawan(int no, int nik, string nama, int gaji)
        {
            this.no = no;
            this.nik= nik;
            this.nama= nama;
            this.gaji=gaji;
            
        }
        
    public void GetKary()
        {
            Console.WriteLine("{0}  {1} {2}     {3}", no, nik, nama, gaji);
        }
        
    
    }
    public class katam : Karyawan
     {
         
            public katam(int no, int nik, string nama, int gaji)
            :base(no, nik, nama, gaji)
            {

            if (gaji < 0)
                {
                this.gaji = 0;    
                }
                else
                {
               this.gaji = Convert.ToInt32((gaji * 1.1));
                }
    
            }
           
     }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NO. NIK NAMA     GAJI BULANAN");
            Console.WriteLine("------------------------------");
            Karyawan karyawan1 = new Karyawan(1, 1535, "Cahya", 200000);
            karyawan1.GetKary();
            
            Karyawan karyawan2 = new Karyawan(2, 9523, "Kamus", 400000);
            karyawan2.GetKary();
            
            Karyawan karyawan3 = new Karyawan(3, 9535, "Nanas", 700000);
            karyawan3.GetKary();

          Console.WriteLine("\nNO. NIK NAMA     GAJI TAMBAHAN");
          Console.WriteLine("------------------------------");
            Karyawan katam1 = new katam(1, 1535, "Cahya", 200000);
            katam1.GetKary();
            
            Karyawan katam2 = new katam(2, 9523, "Kamus", 400000);
            katam2.GetKary();
            
            Karyawan katam3 = new katam(3, 9535, "Nanas", 700000);
            katam3.GetKary();
            Console.ReadKey();
        }
    }
}

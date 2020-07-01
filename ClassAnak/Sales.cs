using System;
using System.Collections.Generic;
using System.Text;

namespace tugas_lab_9.Class_Obj
{
    public class Sales : Karyawan
    {
        public double JumlahPenjualan;
        public double Komisi;
        public override double Gaji()
        {
            return this.JumlahPenjualan * this.Komisi;
        }
    }
}
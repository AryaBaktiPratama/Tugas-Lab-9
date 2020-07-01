using System;
using System.Collections.Generic;
using System.Text;

namespace tugas_lab_9.Class_Obj
{
    public class KaryawanTetap : Karyawan
    {

        public double GajiBulanan;
        public override double Gaji()
        {
            return this.GajiBulanan;
        }
    }
}
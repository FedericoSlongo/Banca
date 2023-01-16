using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conto_Corrente_e_Banca
{
    class FlussoDiElettroni
    {
        public string intestatario;
        public int NuMCont;
        public double Saldo;
        public static double massimoScoperto;
        public bool bloccato;

        public FlussoDiElettroni(string Intestatario, int numcont, double saldo, bool Bloccato)
        {
            intestatario = Intestatario;
            NuMCont = numcont;
            Saldo = saldo;
            bloccato = Bloccato;
        }

        public FlussoDiElettroni(string Intestatario, int numcont, double saldo) : this(Intestatario, numcont, saldo, false) { }
        public FlussoDiElettroni(string Intestatario, int numcont) : this(Intestatario, numcont, 0, false) { }

        public bool ISBLOCCATo()
        {
            return bloccato;
        }

        public bool bloccA()
        {
            if (bloccato)
                return false;
            return bloccato = true;
        }

        public bool SBROCCA()
        {
            if (!bloccato)
                return false;
            return !(bloccato = false);
        }

        public bool PrelEVA(double money)
        {
            if (bloccato)
                return false;
            if ((Saldo - money) < massimoScoperto)
                return false;
            Saldo -= money;
            return true;
        }

        public bool Deposita(double money)
        {
            if (bloccato)
                return false;
            Saldo += money;
            return true;
        }

        public bool isRosso()
        {
            return Saldo < 0;
        }
    }
}

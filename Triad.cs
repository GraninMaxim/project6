using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project6
{
    internal class Triad
    {
        public Triad(uint number1, uint number2, uint number3)
        {
            Number1 = number1;
            Number2 = number2;
            Number3 = number3;
        }


        public uint Number1 { get; set; }
        public uint Number2 { get; set; }
        public uint Number3 { get; set; }

        public uint Amount()
        {
            uint amount = Number1 + Number2 + Number3;
            return amount;
        }

        public void SetParams(uint number1, uint number2, uint number3)
        {
            Number1 = number1;
            Number2 = number2;
            Number3 = number3;
        }

        public void SetParams(uint number1)
        {
            Number1 = number1;
        }

        public void SetParams(uint number1, uint number2)
        {
            Number1 = number1;
            Number2 = number2;
        }


        public void ClearTriad()
        {
            Number1 = 0;
            Number2 = 0;
            Number3 = 0;
        }

        public static bool operator !=(Triad firstTriad, Triad secondTriad)
        {
            return firstTriad != secondTriad;
        }

        public static bool operator ==(Triad firstTriad, Triad secondTriad)
        {
            if (firstTriad.Number1 == secondTriad.Number1 && firstTriad.Number2 == secondTriad.Number2 && firstTriad.Number3 == secondTriad.Number3)
            {
                return true;
            }
            return false;
        }

        public static bool operator true(Triad triad)
        {
            if (triad.Number1 == triad.Number2 && triad.Number1 == triad.Number3) return true;
            return false;
        }

        public static bool operator false(Triad triad)
        {
            return triad.Number1 != triad.Number2 || triad.Number1 != triad.Number3;
        }

        public static bool operator >(Triad firstTriad, Triad secondTriad)
        {
            if (firstTriad.Amount() > secondTriad.Amount()) return true;
            else return false;
        }

        public static bool operator <(Triad firstTriad, Triad secondTriad)
        {
            return firstTriad.Amount() < secondTriad.Amount();
        }
    }
}

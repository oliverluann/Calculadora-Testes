using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace NewTalents
{
    public class Calculadora
    {
        private List<string> listahistorico;
        public Calculadora()
        {
            listahistorico = new List<string>();
        }


        public int somar(int num1, int num2)
        {
            int res = num1 + num2;
            listahistorico.Insert(0, "Res: " + res);
            return res;
        }

        public int subtrair(int num1, int num2)
        {
            int res = num1 - num2;
            listahistorico.Insert(0, "Res: " + res);
            return res;
        }

        public int multiplicar(int num1, int num2)
        {
            int res = num1 * num2;
            listahistorico.Insert(0, "Res: " + res);
            return res;
        }

        public int dividir(int num1, int num2)
        {
            int res = num1 / num2;
            listahistorico.Insert(0, "Res: " + res);
            return res;
        }

        public List<string> historico()
        {            
            listahistorico.RemoveRange(3, listahistorico.Count - 3);
            return listahistorico;
        }
    }
}

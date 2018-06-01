using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimularCaixaEletronico
{
    class ValidaNumeroInteiro
    {
        public bool GetInteger(string ValorSaque)
        {
            //System.Console.WriteLine(ValorSaque);
            bool isvalid;
            int valor = 0;

            if (int.TryParse(ValorSaque, out valor))
            {
                isvalid = true;
                return (isvalid);
            }
            else
            {
                isvalid = false;
                return (isvalid);
            }
        }
    }
}

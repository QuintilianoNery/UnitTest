using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto.Shared.Test
{
    public static class Helper
    {
        public static bool verificaIdadeDeRisco(int idade)
        {
            if(idade>= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool verificaNomeDeRisco(string nome)
        {
            if(nome == "Corona")
            {
                return false;
            }

            else
            {
                return true;
            }
        }


    }
}

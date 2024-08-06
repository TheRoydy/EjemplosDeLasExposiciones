using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{
    class program
    {
        public static void Main(String[] args)
        {
            ClaseHija herencia = new ClaseHija();

            herencia.Saludar();
            herencia.Despedirse();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string S;


            do
            {  
                Console.WriteLine("Digite se sexo (F para feminino e M para masculino): ");
            S = Console.ReadLine();
        }
            while ((S != "F")&(S != "M")) ;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRecursividade
{
    public class recursividadeHelper:IfcRecursividade
    {

        // retorna o fatorial de n versão recursiva 
      //  public static long getFatorial(int n)
      //  {
          //  for (int n = 0; n < 10; n++ {

          //  }
         //  return 1;
       // }

        // retorna o fatorial de n versão iterativa 
        public static long getFatorial(long n, bool flag)
        {

            return 1; }

        // retorna o fatorial de n versão recursiva 
        public static long getFibonacci(long n) {
            if (n == 1)
            {
                return 0;

            } else if (n == 2) {
                return 1;

            } else {
                return getFibonacci(n - 2) + getFibonacci(n - 1);
            }
        }
        // retorna o fatorial de n versão iterativa 
        public  static long getFibonacci(long n, bool flag)
        {
            return 1; 
        }

        static long IfcRecursividade.getFatorial(long n)
        {
            throw new NotImplementedException();
        }
    }
}

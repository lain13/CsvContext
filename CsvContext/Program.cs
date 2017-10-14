using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvContext
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new MyContext();

            var aaa = from c in context.Persons where c.Name == "KANG" select c;

            //
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvContext
{
    public class MyContext
    {
        public IDbSet<Person> Persons { get; set; }
    }

    public class Person
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}

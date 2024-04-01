using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirus
{
    public class Person
    {
        private sbyte _age;
       
        public sbyte Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Age must be equal or greater than 0");
                }
                else
                {
                    _age = value;
                }
            }
        }
        //private string _name;
        //public string Name
        //{
        //    get { return _name; }
        //    set { _name = value; }
        //}
        public string Name { get; set; }
        public Person(sbyte age)
        {
            Age = age;
        }
    }
}
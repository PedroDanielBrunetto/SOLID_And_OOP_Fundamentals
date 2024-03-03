using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers
{
    internal class Class1
    {
        internal string name;

        static void Main(string[] args)
        {
            Class2 c2 = new Class2();
            c2.name = "classe2";
        }
    }
}

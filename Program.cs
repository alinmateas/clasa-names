using System;

namespace Names
{
    class Program
    {
        static void Main(string[] args)
        {
            Names namesList = new Names();
            Name n1 = namesList[1];
            Name n2 = namesList["Ciprian"];

            Name n3 = namesList[45];
        }
    }
}

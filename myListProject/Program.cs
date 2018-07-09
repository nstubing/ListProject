using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            NateList<int> myList1 = new NateList<int>();
            myList1.Add(1);
            myList1.Add(2);
            NateList<int> myList2 = new NateList<int>();
            myList2.Add(1);
            myList2.Add(4);

            int[] expected = { 1, 2, 4 };
            int[] actual = myList1 - myList2;
        }
    }
}

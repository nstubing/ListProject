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
            NateList<int> myList = new NateList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            string actual = myList.ToString(myList.list);
        }
    }
}

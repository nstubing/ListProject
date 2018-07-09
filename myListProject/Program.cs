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
            NateList<string> myList = new NateList<string>();
            myList.Add("this");
            myList.Add("that");
            myList.Add("those");
            myList.Add("things");
            myList.Remove("that");
            myList.Remove("those");
        }
    }
}

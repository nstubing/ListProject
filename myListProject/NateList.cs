using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myListProject
{
    public class NateList<T>
    {
        T[] list;
        int count;



        public NateList()
        {
            list = new T[10];
            count = 0;
        }

        public T[] Add(T item)
        {
            if (count>9)
            {
                NewArrayNeeded();
            }
            list[count] = item;
            count++;
            return CurrentList();
        }

        public void NewArrayNeeded()
        {
            if (count % 10 == 0)
            {
                T[] newList = new T[count + 10];
                for (int i=0; i < count; i++ )
                {
                    newList[i] = list[i];
                }
                list = newList;
            }
        }
        public T[] CurrentList()
        {
            T[] currentList = new T[count];
            for( int i =0; i<count;i++)
            {
                currentList[i] = list[i];
            }
            return currentList;

        }
    }
}

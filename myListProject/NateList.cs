using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myListProject
{
    public class NateList<T>
    {
        public T[] list;
        public int count;
        public NateList()
        {
            list = new T[5];
            count = 0;
        }

        public T[] Add(T item)
        {
            if (count>4)
            {
                NewArrayNeeded();
            }
            list[count] = item;
            count++;
            return list;
        }

        public void NewArrayNeeded()
        {
            if (count % 5 == 0)
            {
                T[] newList = new T[count + 5];
                for (int i=0; i < count; i++ )
                {
                    newList[i] = list[i];
                }
                list = newList;
            }
        }
      
        public T[] Remove(T item)
        {
            T[] currentArray = new T[list.Length];
            int currentCount = count;
            currentArray = list;
            list = new T[5];
            count = 0;
            for(int i = 0; i<currentCount;i++)
            {
                if(currentArray[i].Equals(item))
                {
                }
                else
                {
                    Add(currentArray[i]);
                }
            }
            return list;
        }
    }
}

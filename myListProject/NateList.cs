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
        public T this [int i] { get => list[i]; set => list[i] = value; }
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

        public string ToString(T[] list)
        {
            string newString = "";
            for(int i=0; i<count; i++)
            {
                newString += ""+list[i];
            }
            return newString;

        }

        public static T[] operator +(NateList<T> listOne, NateList<T> listTwo)
        {
            NateList<T> newList= new NateList<T>();
            newList.list = listOne.list;
            for(int i=0; i<listTwo.count;i++)
            {
                newList.Add(listTwo.list[i]);
            }
            return newList.list;
        }
        public static T[] operator -(NateList<T> listOne, NateList<T> listTwo)
        {
            NateList<T> newList = new NateList<T>();
            newList.list = listOne.list;
            bool isMatch;
            for (int i = 0; i < listTwo.count; i++)
            {
                isMatch = false;
                for (int j = 0; j < listOne.count; j++)
                {
                    if (newList[j].Equals(listTwo.list[i]) == true)
                    {
                        isMatch = true;
                    }
                }
                if (isMatch==false)
                {
                    newList.Add(listTwo.list[i]);
                }
            }
            return newList.list;
        }

        public T[] Zipper(NateList<T> listTwo)
        {
            T[] currentArray = new T[list.Length];
            int currentCount = count;
            currentArray = list;
            list = new T[5];
            count = 0;

            for (int i = 0; i<currentCount; i++)
            {
                Add(currentArray[i]);
                Add(listTwo.list[i]);            
            }
            return list;
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myListProject
{
    public class NateList<T>: IEnumerable
    {
        public T[] list;
        public int count;
        public T this [int i] //{ get => list[i]; set => list[i] = value; }
        {
            get
            {
                if (i <=count)
                {
                    return list[i];
                }
                else
                {
                    throw new IndexOutOfRangeException(); 
                }
            }
            set {list[i] = value; }
        }

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
      
        public NateList<T> Remove(T item)
        {
            NateList<T> currentArray = new NateList<T>();
            for(int i = 0; i<count;i++)
            {
                if(list[i].Equals(item)==false)
                {
                    currentArray.Add(list[i]);
                }
            }
            this.list = currentArray.list;
            this.count = currentArray.count;
            return currentArray;
        }

        public override string ToString()
        {
            //stringbuilder
            
            StringBuilder sb = new StringBuilder();
            for (int i=0; i < count; i++)
            {
                sb.Insert(i, list[i]);
            }
            return sb.ToString();

        }

        public static NateList<T> operator +(NateList<T> listOne, NateList<T> listTwo)
        {
            NateList<T> newList= new NateList<T>();
            newList.list = listOne.list;
            newList.count = listOne.count;
            for(int i=0; i<listTwo.count;i++)
            {
                newList.Add(listTwo.list[i]);
            }
            
            return newList;
        }
        public static NateList<T> operator -(NateList<T> listOne, NateList<T> listTwo)
        {
            NateList<T> newList = new NateList<T>();
            newList = listOne;
            bool isMatch;
            for (int i = 0; i < listTwo.count; i++)
            {
                isMatch = false;
                for (int j = 0; j < listOne.count; j++)
                {
                    if (listOne[j].Equals(listTwo.list[i]) == true)
                    {
                        isMatch = true;
                    }
                }
                if (isMatch==false)
                {
                    newList.Add(listTwo.list[i]);
                }
            }
            return newList;
        }

        public NateList<T> Zipper(NateList<T> listTwo)
        {
            NateList<T> currentArray = new NateList<T>();
            
            for (int i = 0; i<count && i<listTwo.count; i++)
            {
                currentArray.Add(list[i]);
                currentArray.Add(listTwo[i]);            
            }
            if (count > listTwo.count)
            {
                for (int j = count; j<(count - listTwo.count); j++)
                {
                    currentArray.Add(list[j]);
                }
            }
            else if (listTwo.count > count)
            {
                for (int k = listTwo.count; k < (listTwo.count - count); k++)
                {
                    currentArray.Add(listTwo[k]);
                }
            }
            this.list = currentArray.list;
            this.count = currentArray.count;
            return currentArray;
        }


        public IEnumerator GetEnumerator()
        {
            for (int i=0; i<count;i++)
            {
                yield return list[i];
            }
        }
    }
}

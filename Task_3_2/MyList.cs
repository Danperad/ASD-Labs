using System.Collections.Generic;

namespace Task_3_2
{
    public static class MyList<T>
    {
        public static List<T> getMyList1(List<T> L1, List<T> L2)
        {
            List<T> list = new List<T>();
            foreach (T i in L1)
            {
                list.Add(i);
            }

            foreach (T i in L2)
            {
                if(!list.Contains(i)) list.Add(i);
            }

            return list;
        }
        public static List<T> getMyList2(List<T> L1, List<T> L2)
        {
            List<T> list = new List<T>();
            foreach (T i in L1)
            {
                if(L2.Contains(i)) list.Add(i);
            }

            return list;
        }
        public static List<T> getMyList3(List<T> L1, List<T> L2)
        {
            List<T> list = new List<T>();
            foreach (T i in L1)
            {
                if(!L2.Contains(i)) list.Add(i);
            }

            return list;
        }
        public static List<T> getMyList4(List<T> L1, List<T> L2)
        {
            List<T> list = new List<T>();
            foreach (T i in L1)
            {
                if(!L2.Contains(i)) list.Add(i);
            }
            foreach (T i in L2)
            {
                if(!L1.Contains(i)) list.Add(i);
            }

            return list;
        }
    }
}
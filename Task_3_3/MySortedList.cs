using System.Collections;
using System.Collections.Generic;

namespace Task_3_3
{
    public class MySortedList : IEnumerable<double>
    {
        private List<double> _list;

        public MySortedList()
        {
            this._list = new List<double>();
        }

        public void add(double d)
        {
            _list.Add(d);
            this._list.Sort();
        }
        
        public static MySortedList getNewList(MySortedList L1, MySortedList L2)
        {
            MySortedList list = new MySortedList();
            foreach (double d in L1._list)
            {
                list.add(d);
            }
            foreach (double d in L2._list)
            {
                list.add(d);
            }

            return list;
        }

        public IEnumerator<double> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
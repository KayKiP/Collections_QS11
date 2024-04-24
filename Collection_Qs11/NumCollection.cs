using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Qs11
{
    public class NumCollection<T> where T : struct
    {
        private List<T> collection;
        public NumCollection()
        {
            collection = new List<T>();
        }

        public void AddNum(T num)
        {
            collection.Add(num);
        }

        public T GetNum(int index)
        {
            if (index < 0 || index >= collection.Count)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }

            return collection[index];
        }

        public List<T> DescNum()
        {
            List<T> sortCollection = collection.OrderByDescending(x => x).ToList();
            return sortCollection;
        }
    }
}

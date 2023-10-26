using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2_NikaKhorbaladze.Task1
{
    public class DataHandler<T>
    {
        private List<T> data = new List<T>();

        public void AddData(T element)
        {
            data.Add(element);
        }

        public T RetrieveData(int index)
        {
            if (index >= 0 && index < data.Count)
            {
                return data[index];
            }
            throw new IndexOutOfRangeException("Index out of range.");
        }
    }
}

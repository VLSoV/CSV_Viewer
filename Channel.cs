using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_IBA_AG
{
    public class Channel
    {
        public Channel() { }
        public Channel(string name)
        {
            Name = name;
        }
        public Channel(int size)
        {
            _numbers = new List<double>(size);
            Count = size;
        }
        public Channel(string name, int size)
        {
            Name = name;
            _numbers = new List<double>(size);
            Count = size;
        }
        public Channel(List<double> numbers)
        {
            _numbers = new List<double>(numbers);
            Count = numbers.Count;
        }
        public Channel(string name, List<double> numbers)
        {
            Name = name;
            _numbers = new List<double>(numbers);
            Count = numbers.Count;
        }

        public string Name;
        private List<double> _numbers = new List<double>();
        public int Count = 0;
        public int NaNs = 0;
        public int Valid = 0;
        public bool IsActive = false;

        public double this[int index]
        {
            get { return _numbers[index]; }
            set { _numbers[index] = value; }
        }

        public void Add(double value)
        {
            _numbers.Add(value);
            Count++;
            if (double.IsNaN(value))
                NaNs++;
            else
                Valid++;
        }
        public double Min()
        {
            if (NaNs == 0)
                return _numbers.Min();
            else
            {
                List<double> numbersWithoutNaNs = new List<double>(_numbers);
                numbersWithoutNaNs.RemoveAll(item => double.IsNaN(item));
                return numbersWithoutNaNs.Min();
            }
        }
        public double Max()
        {
            if (NaNs == 0)
                return _numbers.Max();
            else
            {
                List<double> numbersWithoutNaNs = new List<double>(_numbers);
                numbersWithoutNaNs.RemoveAll(item => double.IsNaN(item));
                return numbersWithoutNaNs.Max();
            }
        }
        public double Avg()
        {
            if (NaNs == 0)
                return _numbers.Average();
            else
            {
                List<double> numbersWithoutNaNs = new List<double>(_numbers);
                numbersWithoutNaNs.RemoveAll(item => double.IsNaN(item));
                return numbersWithoutNaNs.Average();
            }
        }
    }
}

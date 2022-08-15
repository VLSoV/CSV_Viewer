using System;
using System.Collections.Generic;
using System.Linq;

namespace Test_IBA_AG
{
    public class Channel
    {
        private List<double> _numbers = new List<double>();
        private List<double> _numbersWithoutNaNs = new List<double>();
        public string Name;
        public int Count = 0;
        public int NaNs = 0;
        public int Valid = 0;
        public bool IsActive = false;

        public Channel() { }
        public Channel(string name)
        {
            Name = name;
        }
        public Channel(List<double> numbers)
        {
            foreach (var item in _numbers)
            {
                Add(item);
            }
        }
        public Channel(string name, List<double> numbers)
        {
            Name = name;
            foreach (var item in _numbers)
            {
                Add(item);
            }
        }

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
            {
                Valid++;
                _numbersWithoutNaNs.Add(value);
            }
        }
        public double Min()
        {
            return _numbersWithoutNaNs.DefaultIfEmpty<double>(double.NaN).Min();
        }
        public double Max()
        {
            return _numbersWithoutNaNs.DefaultIfEmpty<double>(double.NaN).Max();
        }
        public double Avg()
        {
            return _numbersWithoutNaNs.DefaultIfEmpty<double>(double.NaN).Average();
        }
    }
}

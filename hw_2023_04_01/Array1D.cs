using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_2023_04_01
{
    internal class Array1D : IEnumerable
    {
        int[] _array;
        int _size;
        private void CreateArray() 
        {
            _array = new int[_size];
        }
        public int Size { get { return _size; } }
        public Array1D(int size)
        {
            if (size > 0)
            {
                _size = size;
                CreateArray();
            }
        }
        public int this[int index]
        { 
            get
            {
                if (index >= 0 && index < _size)
                {
                    return _array[index];
                }

                throw new IndexOutOfRangeException();
            }
            set
            {
                if (index >= 0 && index < _size)
                {
                    _array[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }
        IEnumerator IEnumerable.GetEnumerator() 
        {
            return _array.GetEnumerator();
        }
    }
}

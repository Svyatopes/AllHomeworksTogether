using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class ArrayList
    {
        private int[] _array;
        private int _currentUsedLength;
        private const int _minLength = 10;

        public ArrayList()
        {
            _array = new int[_minLength];
            _currentUsedLength = 0;
        }

        public ArrayList(int value)
        {
            _array = new int[_minLength];
            _array[0] = value;
            _currentUsedLength = 1;
        }

        public ArrayList(int[] array)
        {
            _array = new int[_minLength];
            _currentUsedLength = 0;

            Enlarge(array.Length);

            for (int i = 0; i < array.Length; i++)
            {
                _array[i] = array[i];
                _currentUsedLength++;
            }
        }

        private void Enlarge(int neededLength)
        {
            if (neededLength <= _array.Length)
            {
                return;
            }

            int newLengthArray = _array.Length;
            while (newLengthArray < neededLength)
            {
                newLengthArray = newLengthArray * 3 / 2;
            }

            int[] newInternalArray = new int[newLengthArray];
            for (int i = 0; i < _currentUsedLength; i++)
            {
                newInternalArray[i] = _array[i];
            }
            _array = newInternalArray;
        }

        private void Shrink()
        {
            int minPossibleLength = FindMinPossibleLength();
            if (minPossibleLength == _array.Length)
            {
                return;
            }

            int[] newArray = new int[minPossibleLength];
            for (int i = 0; i < _currentUsedLength; i++)
            {
                newArray[i] = _array[i];
            }
            _array = newArray;
        }

        private int FindMinPossibleLength()
        {
            int targetLength = _array.Length;

            while (targetLength > _currentUsedLength && targetLength != _minLength)
            {
                if (targetLength * 2 % 3 != 0)
                {
                    //need because of Round int mathematic when Enlarge()
                    targetLength = targetLength * 2 / 3 + 1;
                }
                else
                {
                    targetLength = targetLength * 2 / 3;
                }

            }

            if (targetLength < _currentUsedLength)
            {
                targetLength = targetLength * 3 / 2;
            }

            return targetLength;
        }

        private void MoveRight(int startIndex, int numberOfElements)
        {
            if (numberOfElements == 0)
            {
                return;
            }
            Enlarge(_currentUsedLength + numberOfElements);
            for (int i = _currentUsedLength + numberOfElements - 1; i >= startIndex + numberOfElements; i--)
            {
                _array[i] = _array[i - numberOfElements];
            }
        }


        public int GetLength()
        {
            return _currentUsedLength;
        }

        public int[] ToArray()
        {
            int[] arrayToReturn = new int[_currentUsedLength];
            for (int i = 0; i < _currentUsedLength; i++)
            {
                arrayToReturn[i] = _array[i];
            }
            return arrayToReturn;
        }

        public void AddFirst(int value)
        {
            MoveRight(0, 1);
            _array[0] = value;
            _currentUsedLength++;
        }

        public void AddFirst(ArrayList list)
        {
            MoveRight(0, list._currentUsedLength);
            for (int i = 0; i < list._currentUsedLength; i++)
            {
                _array[i] = list._array[i];
                _currentUsedLength++;
            }
        }

        public void AddLast(int value)
        {
            Enlarge(_currentUsedLength + 1);
            _array[_currentUsedLength] = value;
            _currentUsedLength++;
        }

        public void AddLast(ArrayList list)
        {
            Enlarge(_currentUsedLength + list._currentUsedLength);

            int listIndex = 0;
            int endIndex = _currentUsedLength + list._currentUsedLength;
            for (int i = _currentUsedLength; i < endIndex; i++)
            {
                _array[i] = list._array[listIndex];
                listIndex++;
                _currentUsedLength++;
            }
        }

        public void AddAt(int index, int value)
        {
            if (index > _currentUsedLength || index < 0)
            {
                throw new IndexOutOfRangeException();
            }

            MoveRight(index, 1);

            _array[index] = value;
            _currentUsedLength++;

        }

        public void AddAt(int index, ArrayList list)
        {
            if (index > _currentUsedLength || index < 0)
            {
                throw new IndexOutOfRangeException();
            }

            MoveRight(index, list._currentUsedLength);

            int listIndex = 0;
            for (int i = index; i < index + list._currentUsedLength; i++)
            {
                _array[i] = list._array[listIndex];
                listIndex++;
                _currentUsedLength++;
            }

        }

        public void Set(int index, int value)
        {
            if (index >= _currentUsedLength || index < 0)
            {
                throw new IndexOutOfRangeException();
            }

            _array[index] = value;
        }

        public void RemoveFirst()
        {
            RemoveAtMultiple(0, 1);
        }

        public void RemoveLast()
        {
            RemoveAtMultiple(_currentUsedLength - 1, 1);
        }

        public void RemoveAt(int index)
        {
            RemoveAtMultiple(index, 1);
        }

        public void RemoveFirstMultiple(int count)
        {
            RemoveAtMultiple(0, count);
        }

        public void RemoveLastMultiple(int count)
        {
            RemoveAtMultiple(_currentUsedLength - count, count);
        }

        public void RemoveAtMultiple(int index, int count)
        {
            if (count == 0)
            {
                return;
            }

            if (count < 0)
            {
                throw new ArgumentException("Count can't be less than zero");
            }


            if (index + count > _currentUsedLength)
            {
                throw new IndexOutOfRangeException("You cannot remove elements outside of range of ArrayList");
            }

            if (index >= _currentUsedLength || index < 0)
            {
                throw new IndexOutOfRangeException();
            }



            for (int i = index + count; i < _currentUsedLength; i++)
            {
                _array[i - count] = _array[i];
            }

            _currentUsedLength -= count;
           
            
            Shrink();

            if (_array.Length > _currentUsedLength)
            {
                for (int i = _currentUsedLength; i < _array.Length; i++)
                {
                    _array[i] = 0;
                }
            }
        }

        public int RemoveFirst(int value)
        {
            int index = IndexOf(value);
            if (index == -1)
            {
                return index;
            }

            RemoveAt(index);
            return index;
        }

        public int RemoveAll(int value)
        {
            int countOfRemoved = 0;

            for (int i = 0; i < _currentUsedLength; i++)
            {
                if (_array[i] == value)
                {
                    RemoveAt(i);
                    i--;
                    countOfRemoved++;
                }
            }

            return countOfRemoved;

        }

        public bool Contains(int value)
        {
            return IndexOf(value) != -1;
        }

        public int IndexOf(int value)
        {
            for (int i = 0; i < _currentUsedLength; i++)
            {
                if (_array[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }

        public int GetFirst()
        {
            return Get(0);
        }

        public int GetLast()
        {
            return Get(_currentUsedLength - 1);
        }

        public int Get(int index)
        {
            if (index >= _currentUsedLength || index < 0)
            {
                throw new IndexOutOfRangeException();
            }

            return _array[index];
        }

        private static void Swap<T>(ref T firstVariable, ref T secondVariable)
        {
            T _ = firstVariable;
            firstVariable = secondVariable;
            secondVariable = _;
        }

        public void Reverse()
        {
            for (int i = 0; i < _currentUsedLength / 2; i++)
            {
                Swap(ref _array[i], ref _array[_currentUsedLength - 1 - i]);
            }
        }

        private static int FindMaxValue(int[] array, int startIndex, int endIndex)
        {
            int maxElement = array[startIndex];
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                if (array[i] > maxElement)
                    maxElement = array[i];
            }
            return maxElement;
        }

        public int Max()
        {
            if (_currentUsedLength == 0)
            {
                throw new IndexOutOfRangeException();
            }
            return FindMaxValue(_array, 0, _currentUsedLength - 1);
        }

        private static int FindMinValue(int[] array, int startIndex, int endIndex)
        {
            int minElement = array[startIndex];
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                if (array[i] < minElement)
                    minElement = array[i];
            }
            return minElement;
        }

        public int Min()
        {
            if (_currentUsedLength == 0)
            {
                throw new IndexOutOfRangeException();
            }
            return FindMinValue(_array, 0, _currentUsedLength - 1);
        }

        private static int FindIndexOfMaxValue(int[] array, int startIndex, int endIndex)
        {
            int maxElement = array[startIndex];
            int indexOfMaxValue = startIndex;
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                if (array[i] > maxElement)
                {
                    maxElement = array[i];
                    indexOfMaxValue = i;
                }
            }
            return indexOfMaxValue;

        }

        public int IndexOfMax()
        {
            if (_currentUsedLength == 0)
            {
                return -1;
            }
            return FindIndexOfMaxValue(_array, 0, _currentUsedLength - 1);
        }


        private static int FindIndexOfMinValue(int[] array, int startIndex, int endIndex)
        {
            int minElement = array[startIndex];
            int indexOfMinValue = startIndex;
            for (int i = startIndex + 1; i <= endIndex; i++)
            {
                if (array[i] < minElement)
                {
                    minElement = array[i];
                    indexOfMinValue = i;
                }
            }
            return indexOfMinValue;
        }

        public int IndexOfMin()
        {
            if (_currentUsedLength == 0)
            {
                return -1;
            }
            return FindIndexOfMinValue(_array, 0, _currentUsedLength - 1);
        }

        public void Sort()
        {
            if(_currentUsedLength == 0)
            {
                return;
            }

            for (int i = 0; i < _currentUsedLength; i++)
            {
                for (int j = 0; j < _currentUsedLength - 1; j++)
                {
                    if (_array[j] > _array[j + 1])
                    {
                        Swap(ref _array[j], ref _array[j + 1]);
                    }
                }
            }
        }

        public void SortDesc()
        {
            if (_currentUsedLength == 0)
            {
                return;
            }

            for (int i = 0; i < _currentUsedLength - 1; i++)
            {
                int indexMaxElement = FindIndexOfMaxValue(_array, i, _currentUsedLength - 1);
                if (indexMaxElement != i)
                {
                    Swap(ref _array[i], ref _array[indexMaxElement]);
                }
            }
        }


        public override bool Equals(object obj)
        {
            return obj is ArrayList list &&
                   Enumerable.SequenceEqual(list._array, _array) &&
                   _currentUsedLength == list._currentUsedLength;
        }
    }
}

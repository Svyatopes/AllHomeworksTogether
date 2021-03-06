using NUnit.Framework;
using System;

namespace Core.Tests
{
    public class LinkedListTests
    {

        [SetUp]
        public void Setup()
        {
        }

        [TestCase(new int[] { 3, 4, 7, 8 }, new int[] { 3, 4, 7, 8 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 })]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 5 }, new int[] { 5 })]
        public void ToArrayTest(int[] userArray, int[] expected)
        {
            //arrange
            LinkedList list = new LinkedList(userArray);


            //act
            int[] actualResult = list.ToArray();


            //assert
            Assert.AreEqual(expected, actualResult);
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        public void AddFirstIntTest(int index)
        {
            //arrange
            LinkedList list = TestDataLinkedList.GetLinkedListForAddFirstInt(index);
            LinkedList expected = TestDataLinkedList.GetExpectedLinkedListForAddFirstInt(index);

            //act
            list.AddFirst(TestDataLinkedList.GetIntToAddForAddFirstInt(index));


            //assert

            Assert.AreEqual(expected.ToArray(), list.ToArray());
        }


        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        public void AddFirstLinkedListTest(int index)
        {
            //arrange
            LinkedList list = TestDataLinkedList.GetLinkedListForAddFirstLinkedList(index);
            LinkedList listToAddFirst = TestDataLinkedList.GetLinkedListToAddForAddFirstLinkedList(index);
            LinkedList expected = TestDataLinkedList.GetExpectedLinkedListForAddFirstLinkedList(index);

            //act
            list.AddFirst(listToAddFirst);

            //assert

            Assert.AreEqual(expected.ToArray(), list.ToArray());
        }


        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        public void AddLastIntTest(int index)
        {
            //arrange
            LinkedList list = TestDataLinkedList.GetLinkedListForAddLastInt(index);
            LinkedList expected = TestDataLinkedList.GetExpectedLinkedListForAddLastInt(index);

            //act
            list.AddLast(TestDataLinkedList.GetIntToAddForAddLastInt(index));

            //assert

            Assert.AreEqual(expected.ToArray(), list.ToArray());
        }


        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        public void AddLastLinkedListTest(int index)
        {
            //arrange
            LinkedList list = TestDataLinkedList.GetLinkedListForAddLastLinkedList(index);
            LinkedList listToAddFirst = TestDataLinkedList.GetLinkedListToAddForAddLastLinkedList(index);
            LinkedList expected = TestDataLinkedList.GetExpectedLinkedListForAddLastLinkedList(index);

            //act
            list.AddLast(listToAddFirst);

            //assert

            Assert.AreEqual(expected.ToArray(), list.ToArray());
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        public void AddAtIntTest(int index)
        {
            //arrange
            LinkedList list = TestDataLinkedList.GetLinkedListForAddAtInt(index);
            (int indexToAdd, int value) = TestDataLinkedList.GetIndexAndValueToAddForAddAtInt(index);
            LinkedList expected = TestDataLinkedList.GetExpectedLinkedListForAddAtInt(index);

            //act
            list.AddAt(indexToAdd, value);

            //assert

            Assert.AreEqual(expected.ToArray(), list.ToArray());
        }


        [TestCase(new int[] { 1, 2, 3 }, 4, 0)]
        [TestCase(new int[] { }, 1, 1)]
        [TestCase(new int[] { 5 }, 2, 10)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, -1, 10)]
        [TestCase(new int[] { 1, 2, 3 }, 500, 10)]
        public void AddAtIntTestNegative(int[] arrayToMakeLinkedList, int indexToAdd, int value)
        {
            //arrange
            LinkedList list = new LinkedList(arrayToMakeLinkedList);

            //act assert
            IndexOutOfRangeException ex = Assert.Throws<IndexOutOfRangeException>(() => list.AddAt(indexToAdd, value));
        }


        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        public void AddAtLinkedListTest(int index)
        {
            //arrange
            LinkedList list = TestDataLinkedList.GetLinkedListForAddAtLinkedList(index);
            (int indexAtAdd, LinkedList listToAdd) = TestDataLinkedList.GetIndexAndLinkedListToAddForAddAtLinkedList(index);
            LinkedList expected = TestDataLinkedList.GetExpectedLinkedListForAddAtLinkedList(index);

            //act
            list.AddAt(indexAtAdd, listToAdd);

            //assert

            Assert.AreEqual(expected.ToArray(), list.ToArray());
        }

        [TestCase(0, 4)]
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, -1)]
        public void AddAtLinkedListTestNegative(int indexLinkedList, int indexToAdd)
        {
            //arrange
            LinkedList list = TestDataLinkedList.GetLinkedListForAddAtLinkedListTestNegative(indexLinkedList);
            LinkedList addList = new LinkedList(5);

            //act assert
            IndexOutOfRangeException ex = Assert.Throws<IndexOutOfRangeException>(() => list.AddAt(indexToAdd, addList));
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        public void SetTest(int index)
        {
            //arrange
            LinkedList list = TestDataLinkedList.GetLinkedListForSetTest(index);
            (int indexAtAdd, int listToAdd) = TestDataLinkedList.GetIndexAndValueForSetTest(index);
            LinkedList expected = TestDataLinkedList.GetExpectedLinkedListForSetTest(index);

            //act
            list.Set(indexAtAdd, listToAdd);

            //assert

            Assert.AreEqual(expected.ToArray(), list.ToArray());
        }

        [TestCase(0, 3)]
        [TestCase(1, 0)]
        [TestCase(2, -1)]
        public void SetTestNegative(int indexLinkedList, int indexToAdd)
        {
            //arrange
            LinkedList list = TestDataLinkedList.GetLinkedListForAddAtLinkedListTestNegative(indexLinkedList);
            int value = 5;

            //act assert
            IndexOutOfRangeException ex = Assert.Throws<IndexOutOfRangeException>(() => list.Set(indexToAdd, value));
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        public void RemoveFirstTest(int index)
        {
            //arrange
            LinkedList list = TestDataLinkedList.GetLinkedListForRemoveFirstTest(index);
            LinkedList expected = TestDataLinkedList.GetExpectedLinkedListForRemoveFirstTest(index);

            //act
            list.RemoveFirst();

            //assert

            Assert.AreEqual(expected.ToArray(), list.ToArray());
        }


        [Test]
        public void RemoveFirstTestNegative()
        {
            //arrange
            LinkedList list = new LinkedList();

            //act assert
            IndexOutOfRangeException ex = Assert.Throws<IndexOutOfRangeException>(() => list.RemoveFirst());
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        public void RemoveLastTest(int index)
        {
            //arrange
            LinkedList list = TestDataLinkedList.GetLinkedListForRemoveLastTest(index);
            LinkedList expected = TestDataLinkedList.GetExpectedLinkedListForRemoveLastTest(index);

            //act
            list.RemoveLast();

            //assert

            Assert.AreEqual(expected.ToArray(), list.ToArray());
        }

        [Test]
        public void RemoveLastTestNegative()
        {
            //arrange
            LinkedList list = new LinkedList();

            //act assert
            IndexOutOfRangeException ex = Assert.Throws<IndexOutOfRangeException>(() => list.RemoveLast());
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        public void RemoveAtTest(int index)
        {
            //arrange
            LinkedList list = TestDataLinkedList.GetLinkedListForRemoveAtTest(index);
            int indexToRemove = TestDataLinkedList.GetIndexForRemoveAtTest(index);
            LinkedList expected = TestDataLinkedList.GetExpectedLinkedListForRemoveAtTest(index);

            //act
            list.RemoveAt(indexToRemove);

            //assert

            Assert.AreEqual(expected.ToArray(), list.ToArray());
        }


        [TestCase(3, new int[] { 1, 2, 3 })]
        [TestCase(1, new int[] { 1 })]
        [TestCase(0, new int[] { })]
        [TestCase(-1, new int[] { 1, 2, 3 })]
        public void RemoveAtTestNegative(int index, int[] array)
        {

            //arrange
            LinkedList list = new LinkedList(array);

            //act assert
            IndexOutOfRangeException ex = Assert.Throws<IndexOutOfRangeException>(() => list.RemoveAt(index));
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        public void RemoveFirstMultipleTest(int index)
        {
            //arrange
            LinkedList list = TestDataLinkedList.GetLinkedListForRemoveFirstMultipleTest(index);
            int count = TestDataLinkedList.GetCountForRemoveFirstMulptipleTest(index);
            LinkedList expected = TestDataLinkedList.GetExpectedLinkedListForRemoveFirstMultipleTest(index);

            //act
            list.RemoveFirstMultiple(count);

            //assert

            Assert.AreEqual(expected.ToArray(), list.ToArray());
        }


        [TestCase(4, new int[] { 1, 2, 3 })]
        [TestCase(1, new int[] { })]
        public void RemoveFirstMultipleTestNegative(int count, int[] array)
        {

            //arrange
            LinkedList list = new LinkedList(array);

            //act assert
            IndexOutOfRangeException ex = Assert.Throws<IndexOutOfRangeException>(() => list.RemoveFirstMultiple(count));
        }

        [TestCase(-1, new int[] { 1, 2, 3 })]
        public void RemoveFirstMultipleTestNegative2(int count, int[] array)
        {

            //arrange
            LinkedList list = new LinkedList(array);

            //act assert
            ArgumentException ex = Assert.Throws<ArgumentException>(() => list.RemoveFirstMultiple(count));

            Assert.AreEqual("Count can't be less than zero", ex.Message);
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        public void RemoveLastMultipleTest(int index)
        {
            //arrange
            LinkedList list = TestDataLinkedList.GetLinkedListForRemoveLastMultipleTest(index);
            int count = TestDataLinkedList.GetCountForRemoveLastMulptipleTest(index);
            LinkedList expected = TestDataLinkedList.GetExpectedLinkedListForRemoveLastMultipleTest(index);

            //act
            list.RemoveLastMultiple(count);

            //assert

            Assert.AreEqual(expected.ToArray(), list.ToArray());
        }

        [TestCase(1, new int[] { })]
        public void RemoveLastMultipleTestNegative(int count, int[] array)
        {

            //arrange
            LinkedList list = new LinkedList(array);

            //act assert
            IndexOutOfRangeException ex = Assert.Throws<IndexOutOfRangeException>(() => list.RemoveLastMultiple(count));


        }

        [TestCase(-1, new int[] { 1, 2, 3 })]
        public void RemoveLastMultipleTestNegative2(int count, int[] array)
        {

            //arrange
            LinkedList list = new LinkedList(array);

            //act assert
            ArgumentException ex = Assert.Throws<ArgumentException>(() => list.RemoveLastMultiple(count));

            Assert.AreEqual("Count can't be less than zero", ex.Message);
        }

        [TestCase(4, new int[] { 1, 2, 3 })]
        public void RemoveLastMultipleTestNegative3(int count, int[] array)
        {

            //arrange
            LinkedList list = new LinkedList(array);

            //act assert
            IndexOutOfRangeException ex = Assert.Throws<IndexOutOfRangeException>(() => list.RemoveLastMultiple(count));

            Assert.AreEqual("Count of removed elements can't be grater than current length of LinkedList", ex.Message);
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        [TestCase(6)]
        public void RemoveAtMultipleTest(int index)
        {
            //arrange
            LinkedList list = TestDataLinkedList.GetLinkedListForRemoveAtMultipleTest(index);
            (int indexToRemove, int count) = TestDataLinkedList.GetIndexToRemoveAndCountForRemoveAtMulptipleTest(index);
            LinkedList expected = TestDataLinkedList.GetExpectedLinkedListForRemoveAtMultipleTest(index);

            //act
            list.RemoveAtMultiple(indexToRemove, count);

            //assert

            Assert.AreEqual(expected.ToArray(), list.ToArray());
        }


        [TestCase(0, 4, new int[] { 1, 2, 3 })]
        [TestCase(0, 1, new int[] { })]
        public void RemoveAtMultipleTestNegative(int index, int count, int[] array)
        {

            //arrange
            LinkedList list = new LinkedList(array);

            //act assert
            IndexOutOfRangeException ex = Assert.Throws<IndexOutOfRangeException>(() => list.RemoveAtMultiple(index, count));
        }

        [TestCase(1, -1, new int[] { 1, 2, 3 })]
        public void RemoveAtMultipleTestNegative2(int index, int count, int[] array)
        {

            //arrange
            LinkedList list = new LinkedList(array);

            //act assert
            ArgumentException ex = Assert.Throws<ArgumentException>(() => list.RemoveAtMultiple(index, count));

            Assert.AreEqual("Count can't be less than zero", ex.Message);
        }


        [TestCase(7, 10, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 })]
        public void RemoveAtMultipleTestNegative3(int index, int count, int[] array)
        {

            //arrange
            LinkedList list = new LinkedList(array);

            //act assert
            IndexOutOfRangeException ex = Assert.Throws<IndexOutOfRangeException>(() => list.RemoveAtMultiple(index, count));

            Assert.AreEqual("You can't remove items outside of bounds LinkedList", ex.Message);

        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        [TestCase(6)]
        [TestCase(7)]
        public void RemoveFirstValueTest(int index)
        {
            //arrange
            LinkedList list = TestDataLinkedList.GetLinkedListForRemoveFirstValueTest(index);
            int value = TestDataLinkedList.GetValueToRemoveForRemoveFirstValueTest(index);
            (LinkedList expected, int expected2) = TestDataLinkedList.GetExpectedLinkedListAndIndexForRemoveFirstValueTest(index);

            //act
            int actual2 = list.RemoveFirst(value);

            //assert

            Assert.AreEqual(expected.ToArray(), list.ToArray());
            Assert.AreEqual(expected2, actual2);
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        [TestCase(6)]
        [TestCase(7)]
        [TestCase(8)]
        public void RemoveAllTest(int index)
        {
            //arrange
            LinkedList list = TestDataLinkedList.GetLinkedListForRemoveAllTest(index);
            int value = TestDataLinkedList.GetValueToRemoveForRemoveAllTest(index);
            (LinkedList expected, int expected2) = TestDataLinkedList.GetExpectedLinkedListAndCountForRemoveAllTest(index);

            //act
            int actual2 = list.RemoveAll(value);

            //assert

            Assert.AreEqual(expected.ToArray(), list.ToArray());
            Assert.AreEqual(expected2, actual2);
        }

        [TestCase(new int[] { 1, 2, 3 }, 4, false)]
        [TestCase(new int[] { 1, 2, 3 }, 2, true)]
        [TestCase(new int[] { 3, 3, 3, 3, 3, 3, 3, 3, 2 }, 2, true)]
        [TestCase(new int[] { 2, 3, 3, 3, 3, 3, 3, 3, 3 }, 2, true)]
        [TestCase(new int[] { 3, 3, 3, 3, 3, 3, 3, 2, 3 }, 2, true)]
        [TestCase(new int[] { }, 4, false)]
        [TestCase(new int[] { 1 }, 4, false)]
        public void ContainsTest(int[] array, int value, bool expected)
        {
            //arrange
            LinkedList list = new LinkedList(array);

            //act
            bool actual = list.Contains(value);

            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3 }, 4, -1)]
        [TestCase(new int[] { 1, 2, 3 }, 2, 1)]
        [TestCase(new int[] { 3, 3, 3, 3, 3, 3, 3, 3, 2 }, 2, 8)]
        [TestCase(new int[] { 3, 3, 3, 3, 3, 3, 3, 3, 2 }, 3, 0)]
        [TestCase(new int[] { }, 4, -1)]
        [TestCase(new int[] { 1 }, 4, -1)]
        public void IndexOfTest(int[] array, int value, int expected)
        {
            //arrange
            LinkedList list = new LinkedList(array);

            //act
            int actual = list.IndexOf(value);

            //assert

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 1, 2, 3 }, 1)]
        [TestCase(new int[] { 5 }, 5)]
        [TestCase(new int[] { 42, 15, 13 }, 42)]
        public void GetFirstTest(int[] array, int expected)
        {
            //arrange
            LinkedList list = new LinkedList(array);

            //act
            int actual = list.GetFirst();

            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        public void GetFirstTestNegative(int[] array)
        {

            //arrange
            LinkedList list = new LinkedList(array);

            //act assert
            IndexOutOfRangeException ex = Assert.Throws<IndexOutOfRangeException>(() => list.GetFirst());
        }


        [TestCase(new int[] { 1, 2, 3 }, 3)]
        [TestCase(new int[] { 5 }, 5)]
        [TestCase(new int[] { 42, 15, 13 }, 13)]
        [TestCase(new int[] { 42, 15, 13, 15, 13, 23, 593, 23, 12375, 123, 21345 }, 21345)]
        public void GetLastTest(int[] array, int expected)
        {
            //arrange
            LinkedList list = new LinkedList(array);

            //act
            int actual = list.GetLast();

            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        public void GetLastTestNegative(int[] array)
        {

            //arrange
            LinkedList list = new LinkedList(array);

            //act assert
            IndexOutOfRangeException ex = Assert.Throws<IndexOutOfRangeException>(() => list.GetLast());
        }

        [TestCase(new int[] { 1, 2, 3 }, 1, 2)]
        [TestCase(new int[] { 5 }, 0, 5)]
        [TestCase(new int[] { 42, 15, 13 }, 1, 15)]
        [TestCase(new int[] { 42, 15, 13, 15, 13, 23, 593, 23, 12375, 123, 21345 }, 6, 593)]
        public void GetByIndexTest(int[] array, int index, int expected)
        {
            //arrange
            LinkedList list = new LinkedList(array);

            //act
            int actual = list.Get(index);

            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { }, 0)]
        [TestCase(new int[] { 1, 2, 3, 4 }, -1)]
        [TestCase(new int[] { 1, 2, 3, 4 }, 4)]
        [TestCase(new int[] { 1, 2, 3, 4 }, 500)]
        public void GetByIndexTestNegative(int[] array, int index)
        {

            //arrange
            LinkedList list = new LinkedList(array);

            //act assert
            IndexOutOfRangeException ex = Assert.Throws<IndexOutOfRangeException>(() => list.Get(index));
        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 })]
        [TestCase(new int[] { 5 }, new int[] { 5 })]
        [TestCase(new int[] { 42, 15, 13 }, new int[] { 13, 15, 42 })]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 2, 2, 2, 2 }, new int[] { 2, 2, 2, 2 })]
        [TestCase(new int[] { 10, 12, 13, 18, 19, 20, 25 }, new int[] { 25, 20, 19, 18, 13, 12, 10 })]
        [TestCase(new int[] { 42, 13 }, new int[] { 13, 42 })]
        public void ReverseTest(int[] array, int[] array2)
        {
            //arrange
            LinkedList list = new LinkedList(array);
            LinkedList expected = new LinkedList(array2);

            //act
            list.Reverse();

            //assert

            Assert.AreEqual(expected.ToArray(), list.ToArray());
        }

        [TestCase(new int[] { 10, 12, 13, 18, 19, 20, 25 }, 25)]
        [TestCase(new int[] { 1, 2, 500, 3, 4 }, 500)]
        [TestCase(new int[] { 501, 2, 500, 3, 4 }, 501)]
        [TestCase(new int[] { 501, 2, 500, 3, 502 }, 502)]
        [TestCase(new int[] { 10 }, 10)]
        [TestCase(new int[] { -10, -15, -13, -5, -3 }, -3)]
        public void MaxTest(int[] array, int expected)
        {
            //arrange
            LinkedList list = new LinkedList(array);

            //act
            int actual = list.Max();

            //assert

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { })]
        public void MaxTestNegative(int[] array)
        {

            //arrange
            LinkedList list = new LinkedList(array);

            //act assert
            IndexOutOfRangeException ex = Assert.Throws<IndexOutOfRangeException>(() => list.Max());
        }

        [TestCase(new int[] { 10, 12, 13, 18, 19, 20, 25 }, 10)]
        [TestCase(new int[] { 1, 2, -1, 3, 4 }, -1)]
        [TestCase(new int[] { -10, 2, -1, 3, 4 }, -10)]
        [TestCase(new int[] { -10, 2, -1, 3, -20 }, -20)]
        [TestCase(new int[] { 10 }, 10)]
        [TestCase(new int[] { -10, -15, -13, -5, -3 }, -15)]
        public void MinTest(int[] array, int expected)
        {
            //arrange
            LinkedList list = new LinkedList(array);

            //act
            int actual = list.Min();

            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { })]
        public void MinTestNegative(int[] array)
        {

            //arrange
            LinkedList list = new LinkedList(array);

            //act assert
            IndexOutOfRangeException ex = Assert.Throws<IndexOutOfRangeException>(() => list.Min());
        }


        [TestCase(new int[] { 10, 12, 13, 18, 19, 20, 25 }, 6)]
        [TestCase(new int[] { 1, 2, 500, 3, 4 }, 2)]
        [TestCase(new int[] { 501, 2, 500, 3, 4 }, 0)]
        [TestCase(new int[] { 501, 2, 500, 3, 502 }, 4)]
        [TestCase(new int[] { 10 }, 0)]
        [TestCase(new int[] { -10, -15, -13, -5, -3 }, 4)]
        [TestCase(new int[] { }, -1)]
        public void IndexOfMaxTest(int[] array, int expected)
        {
            //arrange
            LinkedList list = new LinkedList(array);

            //act
            int actual = list.IndexOfMax();

            //assert

            Assert.AreEqual(expected, actual);
        }


        [TestCase(new int[] { 10, 12, 13, 18, 19, 20, 25 }, 0)]
        [TestCase(new int[] { 1, 2, -1, 3, 4 }, 2)]
        [TestCase(new int[] { -10, 2, -1, 3, 4 }, 0)]
        [TestCase(new int[] { -10, 2, -1, 3, -20 }, 4)]
        [TestCase(new int[] { 10 }, 0)]
        [TestCase(new int[] { -10, -15, -13, -5, -3 }, 1)]
        [TestCase(new int[] { }, -1)]
        public void IndexOfMinTest(int[] array, int expected)
        {
            //arrange
            LinkedList list = new LinkedList(array);

            //act
            int actual = list.IndexOfMin();

            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 })]
        [TestCase(new int[] { 3, 5, 1, 9, 2, 9, 6 }, new int[] { 1, 2, 3, 5, 6, 9, 9 })]
        [TestCase(new int[] { 3, 3, 4, 7, -10, 2, -5, -5, 4, 4 }, new int[] { -10, -5, -5, 2, 3, 3, 4, 4, 4, 7 })]
        [TestCase(new int[] { -10, 15, 2, 4, 0, 2, 5, -20 }, new int[] { -20, -10, 0, 2, 2, 4, 5, 15 })]
        [TestCase(new int[] { 2, 2, 2 }, new int[] { 2, 2, 2 })]
        [TestCase(new int[] { 1, 3 }, new int[] { 1, 3 })]
        [TestCase(new int[] { 3, 1 }, new int[] { 1, 3 })]
        [TestCase(new int[] { }, new int[] { })]
        public void SortTest(int[] array, int[] array2)
        {
            //arrange
            LinkedList list = new LinkedList(array);
            LinkedList expected = new LinkedList(array2);

            //act
            list.Sort();

            //assert

            Assert.AreEqual(expected.ToArray(), list.ToArray());
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 })]
        [TestCase(new int[] { 3, 5, 1, 9, 2, 9, 6 }, new int[] { 9, 9, 6, 5, 3, 2, 1 })]
        [TestCase(new int[] { 3, 3, 4, 7, -10, 2, -5, -5, 4, 4 }, new int[] { 7, 4, 4, 4, 3, 3, 2, -5, -5, -10 })]
        [TestCase(new int[] { -10, 15, 2, 4, 0, 2, 5, -20 }, new int[] { 15, 5, 4, 2, 2, 0, -10, -20 })]
        [TestCase(new int[] { 2, 2, 2 }, new int[] { 2, 2, 2 })]
        [TestCase(new int[] { }, new int[] { })]
        public void SortDescTest(int[] array, int[] array2)
        {
            //arrange
            LinkedList list = new LinkedList(array);
            LinkedList expected = new LinkedList(array2);

            //act
            list.SortDesc();

            //assert

            Assert.AreEqual(expected.ToArray(), list.ToArray());
        }

    }
}

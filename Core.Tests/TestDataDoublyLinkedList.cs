using System;

namespace Core.Tests
{
    public static class TestDataDoublyLinkedList
    {
        public static DoublyLinkedList GetDoublyLinkedListForAddFirstInt(int index)
        {
            return index switch
            {
                0 => new DoublyLinkedList(new int[] { 1, 2, 3 }),
                1 => new DoublyLinkedList(),
                2 => new DoublyLinkedList(5),
                3 => new DoublyLinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }),
                _ => throw new NotImplementedException()
            };
        }

        public static int GetIntToAddForAddFirstInt(int index)
        {
            return index switch
            {
                0 => 5,
                1 => 0,
                2 => -2,
                3 => 0,
                _ => throw new NotImplementedException()
            };
        }

        public static DoublyLinkedList GetExpectedDoublyLinkedListForAddFirstInt(int index)
        {
            return index switch
            {
                0 => new DoublyLinkedList(new int[] { 5, 1, 2, 3 }),
                1 => new DoublyLinkedList(0),
                2 => new DoublyLinkedList(new int[] { -2, 5 }),
                3 => new DoublyLinkedList(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }),
                _ => throw new NotImplementedException()
            };
        }


        public static DoublyLinkedList GetDoublyLinkedListForAddFirstDoublyLinkedList(int index)
        {
            return index switch
            {
                0 => new DoublyLinkedList(new int[] { 1, 2, 3 }),
                1 => new DoublyLinkedList(),
                2 => new DoublyLinkedList(5),
                3 => new DoublyLinkedList(5),
                4 => new DoublyLinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }),
                _ => throw new NotImplementedException()
            };
        }


        public static DoublyLinkedList GetDoublyLinkedListToAddForAddFirstDoublyLinkedList(int index)
        {
            return index switch
            {
                0 => new DoublyLinkedList(new int[] { 4, 5, 6 }),
                1 => new DoublyLinkedList(new int[] { 1, 2 }),
                2 => new DoublyLinkedList(),
                3 => new DoublyLinkedList(7),
                4 => new DoublyLinkedList(7),
                _ => throw new NotImplementedException()
            };
        }

        public static DoublyLinkedList GetExpectedDoublyLinkedListForAddFirstDoublyLinkedList(int index)
        {
            return index switch
            {
                0 => new DoublyLinkedList(new int[] { 4, 5, 6, 1, 2, 3 }),
                1 => new DoublyLinkedList(new int[] { 1, 2 }),
                2 => new DoublyLinkedList(5),
                3 => new DoublyLinkedList(new int[] { 7, 5 }),
                4 => new DoublyLinkedList(new int[] { 7, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }),
                _ => throw new NotImplementedException()
            };
        }

        public static DoublyLinkedList GetDoublyLinkedListForAddLastInt(int index)
        {
            return index switch
            {
                0 => new DoublyLinkedList(new int[] { 1, 2, 3 }),
                1 => new DoublyLinkedList(),
                2 => new DoublyLinkedList(5),
                3 => new DoublyLinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }),
                _ => throw new NotImplementedException()
            };
        }

        public static int GetIntToAddForAddLastInt(int index)
        {
            return index switch
            {
                0 => 5,
                1 => 0,
                2 => -2,
                3 => 0,
                _ => throw new NotImplementedException()
            };
        }

        public static DoublyLinkedList GetExpectedDoublyLinkedListForAddLastInt(int index)
        {
            return index switch
            {
                0 => new DoublyLinkedList(new int[] { 1, 2, 3, 5 }),
                1 => new DoublyLinkedList(0),
                2 => new DoublyLinkedList(new int[] { 5, -2 }),
                3 => new DoublyLinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 0 }),
                _ => throw new NotImplementedException()
            };
        }

        public static DoublyLinkedList GetDoublyLinkedListForAddLastDoublyLinkedList(int index)
        {
            return index switch
            {
                0 => new DoublyLinkedList(new int[] { 1, 2, 3 }),
                1 => new DoublyLinkedList(),
                2 => new DoublyLinkedList(5),
                3 => new DoublyLinkedList(5),
                4 => new DoublyLinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }),
                _ => throw new NotImplementedException()
            };
        }


        public static DoublyLinkedList GetDoublyLinkedListToAddForAddLastDoublyLinkedList(int index)
        {
            return index switch
            {
                0 => new DoublyLinkedList(new int[] { 4, 5, 6 }),
                1 => new DoublyLinkedList(new int[] { 1, 2 }),
                2 => new DoublyLinkedList(),
                3 => new DoublyLinkedList(7),
                4 => new DoublyLinkedList(7),
                _ => throw new NotImplementedException()
            };
        }

        public static DoublyLinkedList GetExpectedDoublyLinkedListForAddLastDoublyLinkedList(int index)
        {
            return index switch
            {
                0 => new DoublyLinkedList(new int[] { 1, 2, 3, 4, 5, 6 }),
                1 => new DoublyLinkedList(new int[] { 1, 2 }),
                2 => new DoublyLinkedList(5),
                3 => new DoublyLinkedList(new int[] { 5, 7 }),
                4 => new DoublyLinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 7 }),
                _ => throw new NotImplementedException()
            };
        }

        public static DoublyLinkedList GetDoublyLinkedListForAddAtInt(int index)
        {
            return index switch
            {
                0 => new DoublyLinkedList(new int[] { 1, 2, 3 }),
                1 => new DoublyLinkedList(),
                2 => new DoublyLinkedList(5),
                3 => new DoublyLinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }),
                4 => new DoublyLinkedList(new int[] { 1, 2, 3 }),
                _ => throw new NotImplementedException()
            };
        }

        public static (int index, int value) GetIndexAndValueToAddForAddAtInt(int index)
        {
            return index switch
            {
                0 => (1, 5),
                1 => (0, 10),
                2 => (1, 10),
                3 => (5, 10),
                4 => (3, 10),
                _ => throw new NotImplementedException()
            };
        }

        public static DoublyLinkedList GetExpectedDoublyLinkedListForAddAtInt(int index)
        {
            return index switch
            {
                0 => new DoublyLinkedList(new int[] { 1, 5, 2, 3 }),
                1 => new DoublyLinkedList(10),
                2 => new DoublyLinkedList(new int[] { 5, 10 }),
                3 => new DoublyLinkedList(new int[] { 1, 2, 3, 4, 5, 10, 6, 7, 8, 9, 10 }),
                4 => new DoublyLinkedList(new int[] { 1, 2, 3, 10 }),
                _ => throw new NotImplementedException()
            };
        }

        public static DoublyLinkedList GetDoublyLinkedListForAddAtDoublyLinkedList(int index)
        {
            return index switch
            {
                0 => new DoublyLinkedList(new int[] { 1, 2, 3 }),
                1 => new DoublyLinkedList(),
                2 => new DoublyLinkedList(new int[] { 1, 2, 3 }),
                3 => new DoublyLinkedList(5),
                4 => new DoublyLinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }),
                5 => new DoublyLinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }),
                _ => throw new NotImplementedException()
            };
        }


        public static (int index, DoublyLinkedList list) GetIndexAndDoublyLinkedListToAddForAddAtDoublyLinkedList(int index)
        {
            return index switch
            {
                0 => (0, new DoublyLinkedList(new int[] { 4, 5, 6 })),
                1 => (0, new DoublyLinkedList(new int[] { 1, 2 })),
                2 => (1, new DoublyLinkedList(new int[] { 8, 9 })),
                3 => (1, new DoublyLinkedList(7)),
                4 => (7, new DoublyLinkedList(15)),
                5 => (7, new DoublyLinkedList()),
                _ => throw new NotImplementedException()
            };
        }

        public static DoublyLinkedList GetExpectedDoublyLinkedListForAddAtDoublyLinkedList(int index)
        {
            return index switch
            {
                0 => new DoublyLinkedList(new int[] { 4, 5, 6, 1, 2, 3 }),
                1 => new DoublyLinkedList(new int[] { 1, 2 }),
                2 => new DoublyLinkedList(new int[] { 1, 8, 9, 2, 3 }),
                3 => new DoublyLinkedList(new int[] { 5, 7 }),
                4 => new DoublyLinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 15, 8, 9, 10 }),
                5 => new DoublyLinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }),
                _ => throw new NotImplementedException()
            };
        }

        public static DoublyLinkedList GetDoublyLinkedListForAddAtDoublyLinkedListTestNegative(int index)
        {
            return index switch
            {
                0 => new DoublyLinkedList(new int[] { 1, 2, 3 }),
                1 => new DoublyLinkedList(),
                2 => new DoublyLinkedList(5),
                3 => new DoublyLinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }),
                _ => throw new NotImplementedException()
            };
        }


        public static DoublyLinkedList GetDoublyLinkedListForSetTest(int index)
        {
            return index switch
            {
                0 => new DoublyLinkedList(new int[] { 1, 2, 3 }),
                1 => new DoublyLinkedList(new int[] { 1, 2, 3 }),
                2 => new DoublyLinkedList(new int[] { 1, 2, 3 }),
                3 => new DoublyLinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }),
                _ => throw new NotImplementedException()
            };
        }

        public static (int index, int value) GetIndexAndValueForSetTest(int index)
        {
            return index switch
            {
                0 => (1, 5),
                1 => (0, 10),
                2 => (2, 10),
                3 => (9, 50),
                _ => throw new NotImplementedException()
            };
        }

        public static DoublyLinkedList GetExpectedDoublyLinkedListForSetTest(int index)
        {
            return index switch
            {
                0 => new DoublyLinkedList(new int[] { 1, 5, 3 }),
                1 => new DoublyLinkedList(new int[] { 10, 2, 3 }),
                2 => new DoublyLinkedList(new int[] { 1, 2, 10 }),
                3 => new DoublyLinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 50 }),
                _ => throw new NotImplementedException()
            };
        }

        public static DoublyLinkedList GetDoublyLinkedListForRemoveFirstTest(int index)
        {
            return index switch
            {
                0 => new DoublyLinkedList(new int[] { 1, 2, 3 }),
                1 => new DoublyLinkedList(1),
                2 => new DoublyLinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }),
                _ => throw new NotImplementedException()
            };
        }

        public static DoublyLinkedList GetExpectedDoublyLinkedListForRemoveFirstTest(int index)
        {
            return index switch
            {
                0 => new DoublyLinkedList(new int[] { 2, 3 }),
                1 => new DoublyLinkedList(),
                2 => new DoublyLinkedList(new int[] { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }),
                _ => throw new NotImplementedException()
            };
        }

        public static DoublyLinkedList GetDoublyLinkedListForRemoveLastTest(int index)
        {
            return index switch
            {
                0 => new DoublyLinkedList(new int[] { 1, 2, 3 }),
                1 => new DoublyLinkedList(1),
                2 => new DoublyLinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }),
                _ => throw new NotImplementedException()
            };
        }

        public static DoublyLinkedList GetExpectedDoublyLinkedListForRemoveLastTest(int index)
        {
            return index switch
            {
                0 => new DoublyLinkedList(new int[] { 1, 2 }),
                1 => new DoublyLinkedList(),
                2 => new DoublyLinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }),
                _ => throw new NotImplementedException()
            };
        }

        public static DoublyLinkedList GetDoublyLinkedListForRemoveAtTest(int index)
        {
            return index switch
            {
                0 => new DoublyLinkedList(new int[] { 1, 2, 3 }),
                1 => new DoublyLinkedList(1),
                2 => new DoublyLinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }),
                3 => new DoublyLinkedList(new int[] { 1, 2, 3, 4, 5, 6 }),
                _ => throw new NotImplementedException()
            };
        }

        public static int GetIndexForRemoveAtTest(int index)
        {
            return index switch
            {
                0 => 1,
                1 => 0,
                2 => 7,
                3 => 5,
                _ => throw new NotImplementedException()
            };
        }

        public static DoublyLinkedList GetExpectedDoublyLinkedListForRemoveAtTest(int index)
        {
            return index switch
            {
                0 => new DoublyLinkedList(new int[] { 1, 3 }),
                1 => new DoublyLinkedList(),
                2 => new DoublyLinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 9, 10, 11 }),
                3 => new DoublyLinkedList(new int[] { 1, 2, 3, 4, 5 }),
                _ => throw new NotImplementedException()
            };
        }


        public static DoublyLinkedList GetDoublyLinkedListForRemoveFirstMultipleTest(int index)
        {
            return index switch
            {
                0 => new DoublyLinkedList(new int[] { 1, 2, 3 }),
                1 => new DoublyLinkedList(new int[] { 1, 2, 3 }),
                2 => new DoublyLinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }),
                3 => new DoublyLinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }),
                4 => new DoublyLinkedList(new int[] { 1, 2, 3 }),
                _ => throw new NotImplementedException()
            };
        }

        public static int GetCountForRemoveFirstMulptipleTest(int index)
        {
            return index switch
            {
                0 => 2,
                1 => 3,
                2 => 5,
                3 => 15,
                4 => 0,
                _ => throw new NotImplementedException()
            };
        }

        public static DoublyLinkedList GetExpectedDoublyLinkedListForRemoveFirstMultipleTest(int index)
        {
            return index switch
            {
                0 => new DoublyLinkedList(new int[] { 3 }),
                1 => new DoublyLinkedList(),
                2 => new DoublyLinkedList(new int[] { 6, 7, 8, 9, 10, 11 }),
                3 => new DoublyLinkedList(new int[] { 16 }),
                4 => new DoublyLinkedList(new int[] { 1, 2, 3 }),
                _ => throw new NotImplementedException()
            };
        }

        public static DoublyLinkedList GetDoublyLinkedListForRemoveLastMultipleTest(int index)
        {
            return index switch
            {
                0 => new DoublyLinkedList(new int[] { 1, 2, 3 }),
                1 => new DoublyLinkedList(new int[] { 1, 2, 3 }),
                2 => new DoublyLinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }),
                3 => new DoublyLinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }),
                4 => new DoublyLinkedList(new int[] { 1, 2, 3 }),
                5 => new DoublyLinkedList(new int[] { 1, 2, 3, 4, 5, 6 }),
                _ => throw new NotImplementedException()
            };
        }

        public static int GetCountForRemoveLastMulptipleTest(int index)
        {
            return index switch
            {
                0 => 2,
                1 => 3,
                2 => 7,
                3 => 15,
                4 => 0,
                5 => 1,
                _ => throw new NotImplementedException()
            };
        }

        public static DoublyLinkedList GetExpectedDoublyLinkedListForRemoveLastMultipleTest(int index)
        {
            return index switch
            {
                0 => new DoublyLinkedList(new int[] { 1 }),
                1 => new DoublyLinkedList(),
                2 => new DoublyLinkedList(new int[] { 1, 2, 3, 4 }),
                3 => new DoublyLinkedList(new int[] { 1 }),
                4 => new DoublyLinkedList(new int[] { 1, 2, 3 }),
                5 => new DoublyLinkedList(new int[] { 1, 2, 3, 4, 5 }),
                _ => throw new NotImplementedException()
            };
        }


        public static DoublyLinkedList GetDoublyLinkedListForRemoveAtMultipleTest(int index)
        {
            return index switch
            {
                0 => new DoublyLinkedList(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }),
                1 => new DoublyLinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }),
                2 => new DoublyLinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }),
                3 => new DoublyLinkedList(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }),
                4 => new DoublyLinkedList(new int[] { 1, 2, 3 }),
                5 => new DoublyLinkedList(new int[] { 1, 2, 3 }),
                6 => new DoublyLinkedList(new int[] { 1, 2, 3, 4, 5, 6 }),
                _ => throw new NotImplementedException()
            };
        }

        public static (int indexToRemove, int count) GetIndexToRemoveAndCountForRemoveAtMulptipleTest(int index)
        {
            return index switch
            {
                0 => (4, 4),
                1 => (1, 10),
                2 => (1, 14),
                3 => (10, 5),
                4 => (1, 0),
                5 => (0, 3),
                6 => (3, 3),
                _ => throw new NotImplementedException()
            };
        }

        public static DoublyLinkedList GetExpectedDoublyLinkedListForRemoveAtMultipleTest(int index)
        {
            return index switch
            {
                0 => new DoublyLinkedList(new int[] { 0, 1, 2, 3, 8, 9 }),
                1 => new DoublyLinkedList(1),
                2 => new DoublyLinkedList(new int[] { 1, 16 }),
                3 => new DoublyLinkedList(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 15 }),
                4 => new DoublyLinkedList(new int[] { 1, 2, 3 }),
                5 => new DoublyLinkedList(),
                6 => new DoublyLinkedList(new int[] { 1, 2, 3 }),
                _ => throw new NotImplementedException()
            };
        }

        public static DoublyLinkedList GetDoublyLinkedListForRemoveFirstValueTest(int index)
        {
            return index switch
            {
                0 => new DoublyLinkedList(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }),
                1 => new DoublyLinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }),
                2 => new DoublyLinkedList(new int[] { 1, 2, 3, 4 }),
                3 => new DoublyLinkedList(new int[] { 1, 2, 3, 4 }),
                4 => new DoublyLinkedList(new int[] { 1, 2, 3, 4 }),
                5 => new DoublyLinkedList(new int[] { 1, 2 }),
                6 => new DoublyLinkedList(1),
                7 => new DoublyLinkedList(),
                _ => throw new NotImplementedException()
            };
        }

        public static int GetValueToRemoveForRemoveFirstValueTest(int index)
        {
            return index switch
            {
                0 => 4,
                1 => 11,
                2 => 5,
                3 => 1,
                4 => 2,
                5 => 2,
                6 => 1,
                7 => 10,
                _ => throw new NotImplementedException()
            };
        }

        public static (DoublyLinkedList expectedArray, int expectedIndex) GetExpectedDoublyLinkedListAndIndexForRemoveFirstValueTest(int index)
        {
            return index switch
            {
                0 => (new DoublyLinkedList(new int[] { 0, 1, 2, 3, 5, 6, 7, 8, 9 }), 4),
                1 => (new DoublyLinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }), 10),
                2 => (new DoublyLinkedList(new int[] { 1, 2, 3, 4 }), -1),
                3 => (new DoublyLinkedList(new int[] { 2, 3, 4 }), 0),
                4 => (new DoublyLinkedList(new int[] { 1, 3, 4 }), 1),
                5 => (new DoublyLinkedList(1), 1),
                6 => (new DoublyLinkedList(), 0),
                7 => (new DoublyLinkedList(), -1),
                _ => throw new NotImplementedException()
            };
        }

        public static DoublyLinkedList GetDoublyLinkedListForRemoveAllTest(int index)
        {
            return index switch
            {
                0 => new DoublyLinkedList(new int[] { 4, 3, 2, 4, 4 }),
                1 => new DoublyLinkedList(new int[] { 1, 2, 3 }),
                2 => new DoublyLinkedList(new int[] { 5, 5, 5, 5, 5, 5, 5, 5 }),
                3 => new DoublyLinkedList(new int[] { 5, 5, 5, 5, 7, 5, 5, 5 }),
                4 => new DoublyLinkedList(new int[] { 2, 9, 4, 2, 3, 6, 2, 10, 80 }),
                5 => new DoublyLinkedList(),
                6 => new DoublyLinkedList(new int[] { 5, 5, 5, 7, 5, 5, 5, 7, 5, 5, 5, 7 }),
                7 => new DoublyLinkedList(new int[] { 5, 5, 5, 7, 5, 5, 5, 7, 5, 5, 5, 7, 5, 5, 5 }),
                8 => new DoublyLinkedList(new int[] { 7, 5, 5, 5, 7, 5, 5, 5, 7, 5, 5, 5, 7 }),
                _ => throw new NotImplementedException()
            };
        }

        public static int GetValueToRemoveForRemoveAllTest(int index)
        {
            return index switch
            {
                0 => 4,
                1 => 5,
                2 => 5,
                3 => 7,
                4 => 2,
                5 => 10,
                6 => 5,
                7 => 5,
                8 => 5,
                _ => throw new NotImplementedException()
            };
        }

        public static (DoublyLinkedList expectedArray, int expectedIndex) GetExpectedDoublyLinkedListAndCountForRemoveAllTest(int index)
        {
            return index switch
            {
                0 => (new DoublyLinkedList(new int[] { 3, 2 }), 3),
                1 => (new DoublyLinkedList(new int[] { 1, 2, 3 }), 0),
                2 => (new DoublyLinkedList(), 8),
                3 => (new DoublyLinkedList(new int[] { 5, 5, 5, 5, 5, 5, 5 }), 1),
                4 => (new DoublyLinkedList(new int[] { 9, 4, 3, 6, 10, 80 }), 3),
                5 => (new DoublyLinkedList(), 0),
                6 => (new DoublyLinkedList(new int[] { 7, 7, 7 }), 9),
                7 => (new DoublyLinkedList(new int[] { 7, 7, 7 }), 12),
                8 => (new DoublyLinkedList(new int[] { 7, 7, 7, 7 }), 9),
                _ => throw new NotImplementedException()
            };
        }
    }
}

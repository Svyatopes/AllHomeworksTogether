using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Tests
{
    public static class TestDataLinkedList
    {
        public static LinkedList GetLinkedListForAddFirstInt(int index)
        {
            return index switch
            {
                0 => new LinkedList(new int[] { 1, 2, 3 }),
                1 => new LinkedList(),
                2 => new LinkedList(5),
                3 => new LinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }),
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

        public static LinkedList GetExpectedLinkedListForAddFirstInt(int index)
        {
            return index switch
            {
                0 => new LinkedList(new int[] { 5, 1, 2, 3 }),
                1 => new LinkedList(0),
                2 => new LinkedList(new int[] { -2, 5 }),
                3 => new LinkedList(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }),
                _ => throw new NotImplementedException()
            };
        }


        public static LinkedList GetLinkedListForAddFirstLinkedList(int index)
        {
            return index switch
            {
                0 => new LinkedList(new int[] { 1, 2, 3 }),
                1 => new LinkedList(),
                2 => new LinkedList(5),
                3 => new LinkedList(5),
                4 => new LinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }),
                _ => throw new NotImplementedException()
            };
        }


        public static LinkedList GetLinkedListToAddForAddFirstLinkedList(int index)
        {
            return index switch
            {
                0 => new LinkedList(new int[] { 4, 5, 6 }),
                1 => new LinkedList(new int[] { 1, 2 }),
                2 => new LinkedList(),
                3 => new LinkedList(7),
                4 => new LinkedList(7),
                _ => throw new NotImplementedException()
            };
        }

        public static LinkedList GetExpectedLinkedListForAddFirstLinkedList(int index)
        {
            return index switch
            {
                0 => new LinkedList(new int[] { 4, 5, 6, 1, 2, 3 }),
                1 => new LinkedList(new int[] { 1, 2 }),
                2 => new LinkedList(5),
                3 => new LinkedList(new int[] { 7, 5 }),
                4 => new LinkedList(new int[] { 7, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }),
                _ => throw new NotImplementedException()
            };
        }

        public static LinkedList GetLinkedListForAddLastInt(int index)
        {
            return index switch
            {
                0 => new LinkedList(new int[] { 1, 2, 3 }),
                1 => new LinkedList(),
                2 => new LinkedList(5),
                3 => new LinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }),
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

        public static LinkedList GetExpectedLinkedListForAddLastInt(int index)
        {
            return index switch
            {
                0 => new LinkedList(new int[] { 1, 2, 3, 5 }),
                1 => new LinkedList(0),
                2 => new LinkedList(new int[] { 5, -2 }),
                3 => new LinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 0 }),
                _ => throw new NotImplementedException()
            };
        }

        public static LinkedList GetLinkedListForAddLastLinkedList(int index)
        {
            return index switch
            {
                0 => new LinkedList(new int[] { 1, 2, 3 }),
                1 => new LinkedList(),
                2 => new LinkedList(5),
                3 => new LinkedList(5),
                4 => new LinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }),
                _ => throw new NotImplementedException()
            };
        }


        public static LinkedList GetLinkedListToAddForAddLastLinkedList(int index)
        {
            return index switch
            {
                0 => new LinkedList(new int[] { 4, 5, 6 }),
                1 => new LinkedList(new int[] { 1, 2 }),
                2 => new LinkedList(),
                3 => new LinkedList(7),
                4 => new LinkedList(7),
                _ => throw new NotImplementedException()
            };
        }

        public static LinkedList GetExpectedLinkedListForAddLastLinkedList(int index)
        {
            return index switch
            {
                0 => new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 }),
                1 => new LinkedList(new int[] { 1, 2 }),
                2 => new LinkedList(5),
                3 => new LinkedList(new int[] { 5, 7 }),
                4 => new LinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 7 }),
                _ => throw new NotImplementedException()
            };
        }

        public static LinkedList GetLinkedListForAddAtInt(int index)
        {
            return index switch
            {
                0 => new LinkedList(new int[] { 1, 2, 3 }),
                1 => new LinkedList(),
                2 => new LinkedList(5),
                3 => new LinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }),
                4 => new LinkedList(new int[] { 1, 2, 3 }),
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

        public static LinkedList GetExpectedLinkedListForAddAtInt(int index)
        {
            return index switch
            {
                0 => new LinkedList(new int[] { 1, 5, 2, 3 }),
                1 => new LinkedList(10),
                2 => new LinkedList(new int[] { 5, 10 }),
                3 => new LinkedList(new int[] { 1, 2, 3, 4, 5, 10, 6, 7, 8, 9, 10 }),
                4 => new LinkedList(new int[] { 1, 2, 3, 10 }),
                _ => throw new NotImplementedException()
            };
        }

        public static LinkedList GetLinkedListForAddAtLinkedList(int index)
        {
            return index switch
            {
                0 => new LinkedList(new int[] { 1, 2, 3 }),
                1 => new LinkedList(),
                2 => new LinkedList(new int[] { 1, 2, 3 }),
                3 => new LinkedList(5),
                4 => new LinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }),
                5 => new LinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }),
                _ => throw new NotImplementedException()
            };
        }


        public static (int index, LinkedList list) GetIndexAndLinkedListToAddForAddAtLinkedList(int index)
        {
            return index switch
            {
                0 => (0, new LinkedList(new int[] { 4, 5, 6 })),
                1 => (0, new LinkedList(new int[] { 1, 2 })),
                2 => (1, new LinkedList(new int[] { 8, 9 })),
                3 => (1, new LinkedList(7)),
                4 => (7, new LinkedList(15)),
                5 => (7, new LinkedList()),
                _ => throw new NotImplementedException()
            };
        }

        public static LinkedList GetExpectedLinkedListForAddAtLinkedList(int index)
        {
            return index switch
            {
                0 => new LinkedList(new int[] { 4, 5, 6, 1, 2, 3 }),
                1 => new LinkedList(new int[] { 1, 2 }),
                2 => new LinkedList(new int[] { 1, 8, 9, 2, 3 }),
                3 => new LinkedList(new int[] { 5, 7 }),
                4 => new LinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 15, 8, 9, 10 }),
                5 => new LinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }),
                _ => throw new NotImplementedException()
            };
        }

        public static LinkedList GetLinkedListForAddAtLinkedListTestNegative(int index)
        {
            return index switch
            {
                0 => new LinkedList(new int[] { 1, 2, 3 }),
                1 => new LinkedList(),
                2 => new LinkedList(5),
                3 => new LinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }),
                _ => throw new NotImplementedException()
            };
        }


        public static LinkedList GetLinkedListForSetTest(int index)
        {
            return index switch
            {
                0 => new LinkedList(new int[] { 1, 2, 3 }),
                1 => new LinkedList(new int[] { 1, 2, 3 }),
                2 => new LinkedList(new int[] { 1, 2, 3 }),
                3 => new LinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }),
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

        public static LinkedList GetExpectedLinkedListForSetTest(int index)
        {
            return index switch
            {
                0 => new LinkedList(new int[] { 1, 5, 3 }),
                1 => new LinkedList(new int[] { 10, 2, 3 }),
                2 => new LinkedList(new int[] { 1, 2, 10 }),
                3 => new LinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 50 }),
                _ => throw new NotImplementedException()
            };
        }

        public static LinkedList GetLinkedListForRemoveFirstTest(int index)
        {
            return index switch
            {
                0 => new LinkedList(new int[] { 1, 2, 3 }),
                1 => new LinkedList(1),
                2 => new LinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }),
                _ => throw new NotImplementedException()
            };
        }

        public static LinkedList GetExpectedLinkedListForRemoveFirstTest(int index)
        {
            return index switch
            {
                0 => new LinkedList(new int[] { 2, 3 }),
                1 => new LinkedList(),
                2 => new LinkedList(new int[] { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }),
                _ => throw new NotImplementedException()
            };
        }

        public static LinkedList GetLinkedListForRemoveLastTest(int index)
        {
            return index switch
            {
                0 => new LinkedList(new int[] { 1, 2, 3 }),
                1 => new LinkedList(1),
                2 => new LinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }),
                _ => throw new NotImplementedException()
            };
        }

        public static LinkedList GetExpectedLinkedListForRemoveLastTest(int index)
        {
            return index switch
            {
                0 => new LinkedList(new int[] { 1, 2 }),
                1 => new LinkedList(),
                2 => new LinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }),
                _ => throw new NotImplementedException()
            };
        }

        public static LinkedList GetLinkedListForRemoveAtTest(int index)
        {
            return index switch
            {
                0 => new LinkedList(new int[] { 1, 2, 3 }),
                1 => new LinkedList(1),
                2 => new LinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }),
                3 => new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 }),
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

        public static LinkedList GetExpectedLinkedListForRemoveAtTest(int index)
        {
            return index switch
            {
                0 => new LinkedList(new int[] { 1, 3 }),
                1 => new LinkedList(),
                2 => new LinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 9, 10, 11 }),
                3 => new LinkedList(new int[] { 1, 2, 3, 4, 5 }),
                _ => throw new NotImplementedException()
            };
        }


        public static LinkedList GetLinkedListForRemoveFirstMultipleTest(int index)
        {
            return index switch
            {
                0 => new LinkedList(new int[] { 1, 2, 3 }),
                1 => new LinkedList(new int[] { 1, 2, 3 }),
                2 => new LinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }),
                3 => new LinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }),
                4 => new LinkedList(new int[] { 1, 2, 3 }),
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

        public static LinkedList GetExpectedLinkedListForRemoveFirstMultipleTest(int index)
        {
            return index switch
            {
                0 => new LinkedList(new int[] { 3 }),
                1 => new LinkedList(),
                2 => new LinkedList(new int[] { 6, 7, 8, 9, 10, 11 }),
                3 => new LinkedList(new int[] { 16 }),
                4 => new LinkedList(new int[] { 1, 2, 3 }),
                _ => throw new NotImplementedException()
            };
        }

        public static LinkedList GetLinkedListForRemoveLastMultipleTest(int index)
        {
            return index switch
            {
                0 => new LinkedList(new int[] { 1, 2, 3 }),
                1 => new LinkedList(new int[] { 1, 2, 3 }),
                2 => new LinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }),
                3 => new LinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }),
                4 => new LinkedList(new int[] { 1, 2, 3 }),
                5 => new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 }),
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

        public static LinkedList GetExpectedLinkedListForRemoveLastMultipleTest(int index)
        {
            return index switch
            {
                0 => new LinkedList(new int[] { 1 }),
                1 => new LinkedList(),
                2 => new LinkedList(new int[] { 1, 2, 3, 4 }),
                3 => new LinkedList(new int[] { 1 }),
                4 => new LinkedList(new int[] { 1, 2, 3 }),
                5 => new LinkedList(new int[] { 1, 2, 3, 4, 5 }),
                _ => throw new NotImplementedException()
            };
        }


        public static LinkedList GetLinkedListForRemoveAtMultipleTest(int index)
        {
            return index switch
            {
                0 => new LinkedList(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }),
                1 => new LinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }),
                2 => new LinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }),
                3 => new LinkedList(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }),
                4 => new LinkedList(new int[] { 1, 2, 3 }),
                5 => new LinkedList(new int[] { 1, 2, 3 }),
                6 => new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 }),
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

        public static LinkedList GetExpectedLinkedListForRemoveAtMultipleTest(int index)
        {
            return index switch
            {
                0 => new LinkedList(new int[] { 0, 1, 2, 3, 8, 9 }),
                1 => new LinkedList(1),
                2 => new LinkedList(new int[] { 1, 16 }),
                3 => new LinkedList(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 15 }),
                4 => new LinkedList(new int[] { 1, 2, 3 }),
                5 => new LinkedList(),
                6 => new LinkedList(new int[] { 1, 2, 3 }),
                _ => throw new NotImplementedException()
            };
        }

        public static LinkedList GetLinkedListForRemoveFirstValueTest(int index)
        {
            return index switch
            {
                0 => new LinkedList(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }),
                1 => new LinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }),
                2 => new LinkedList(new int[] { 1, 2, 3, 4 }),
                3 => new LinkedList(new int[] { 1, 2, 3, 4 }),
                4 => new LinkedList(new int[] { 1, 2, 3, 4 }),
                5 => new LinkedList(new int[] { 1, 2 }),
                6 => new LinkedList(1),
                7 => new LinkedList(),
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

        public static (LinkedList expectedArray, int expectedIndex) GetExpectedLinkedListAndIndexForRemoveFirstValueTest(int index)
        {
            return index switch
            {
                0 => (new LinkedList(new int[] { 0, 1, 2, 3, 5, 6, 7, 8, 9 }), 4),
                1 => (new LinkedList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }), 10),
                2 => (new LinkedList(new int[] { 1, 2, 3, 4 }), -1),
                3 => (new LinkedList(new int[] { 2, 3, 4 }), 0),
                4 => (new LinkedList(new int[] { 1, 3, 4 }), 1),
                5 => (new LinkedList(1), 1),
                6 => (new LinkedList(), 0),
                7 => (new LinkedList(), -1),
                _ => throw new NotImplementedException()
            };
        }

        public static LinkedList GetLinkedListForRemoveAllTest(int index)
        {
            return index switch
            {
                0 => new LinkedList(new int[] { 4, 3, 2, 4, 4 }),
                1 => new LinkedList(new int[] { 1, 2, 3 }),
                2 => new LinkedList(new int[] { 5, 5, 5, 5, 5, 5, 5, 5 }),
                3 => new LinkedList(new int[] { 5, 5, 5, 5, 7, 5, 5, 5 }),
                4 => new LinkedList(new int[] { 2, 9, 4, 2, 3, 6, 2, 10, 80 }),
                5 => new LinkedList(),
                6 => new LinkedList(new int[] { 5, 5, 5, 7, 5, 5, 5, 7, 5, 5, 5, 7 }),
                7 => new LinkedList(new int[] { 5, 5, 5, 7, 5, 5, 5, 7, 5, 5, 5, 7, 5, 5, 5 }),
                8 => new LinkedList(new int[] { 7, 5, 5, 5, 7, 5, 5, 5, 7, 5, 5, 5, 7 }),
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

        public static (LinkedList expectedArray, int expectedIndex) GetExpectedLinkedListAndCountForRemoveAllTest(int index)
        {
            return index switch
            {
                0 => (new LinkedList(new int[] { 3, 2 }), 3),
                1 => (new LinkedList(new int[] { 1, 2, 3 }), 0),
                2 => (new LinkedList(), 8),
                3 => (new LinkedList(new int[] { 5, 5, 5, 5, 5, 5, 5 }), 1),
                4 => (new LinkedList(new int[] { 9, 4, 3, 6, 10, 80 }), 3),
                5 => (new LinkedList(), 0),
                6 => (new LinkedList(new int[] { 7, 7, 7 }), 9),
                7 => (new LinkedList(new int[] { 7, 7, 7 }), 12),
                8 => (new LinkedList(new int[] { 7, 7, 7, 7 }), 9),
                _ => throw new NotImplementedException()
            };
        }
    }
}

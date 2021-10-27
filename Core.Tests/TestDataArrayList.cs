using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Tests
{
    public static class TestDataArrayList
    {


        public static ArrayList GetArrayListForAddFirstInt(int index)
        {
            return index switch
            {
                0 => new ArrayList(new int[] { 1, 2, 3 }),
                1 => new ArrayList(),
                2 => new ArrayList(5),
                3 => new ArrayList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }),
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

        public static ArrayList GetExpectedArrayListForAddFirstInt(int index)
        {
            return index switch
            {
                0 => new ArrayList(new int[] { 5, 1, 2, 3 }),
                1 => new ArrayList(0),
                2 => new ArrayList(new int[] { -2, 5 }),
                3 => new ArrayList(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }),
                _ => throw new NotImplementedException()
            };
        }

        public static ArrayList GetArrayListForAddFirstArrayList(int index)
        {
            return index switch
            {
                0 => new ArrayList(new int[] { 1, 2, 3 }),
                1 => new ArrayList(),
                2 => new ArrayList(5),
                3 => new ArrayList(5),
                4 => new ArrayList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }),
                _ => throw new NotImplementedException()
            };
        }


        public static ArrayList GetArrayListToAddForAddFirstArrayList(int index)
        {
            return index switch
            {
                0 => new ArrayList(new int[] { 4, 5, 6 }),
                1 => new ArrayList(new int[] { 1, 2 }),
                2 => new ArrayList(),
                3 => new ArrayList(7),
                4 => new ArrayList(7),
                _ => throw new NotImplementedException()
            };
        }

        public static ArrayList GetExpectedArrayListForAddFirstArrayList(int index)
        {
            return index switch
            {
                0 => new ArrayList(new int[] { 4, 5, 6, 1, 2, 3 }),
                1 => new ArrayList(new int[] { 1, 2 }),
                2 => new ArrayList(5),
                3 => new ArrayList(new int[] { 7, 5 }),
                4 => new ArrayList(new int[] { 7, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }),
                _ => throw new NotImplementedException()
            };
        }


        public static ArrayList GetArrayListForAddLastInt(int index)
        {
            return index switch
            {
                0 => new ArrayList(new int[] { 1, 2, 3 }),
                1 => new ArrayList(),
                2 => new ArrayList(5),
                3 => new ArrayList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }),
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

        public static ArrayList GetExpectedArrayListForAddLastInt(int index)
        {
            return index switch
            {
                0 => new ArrayList(new int[] { 1, 2, 3, 5 }),
                1 => new ArrayList(0),
                2 => new ArrayList(new int[] { 5, -2 }),
                3 => new ArrayList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 0 }),
                _ => throw new NotImplementedException()
            };
        }


        public static ArrayList GetArrayListForAddLastArrayList(int index)
        {
            return index switch
            {
                0 => new ArrayList(new int[] { 1, 2, 3 }),
                1 => new ArrayList(),
                2 => new ArrayList(5),
                3 => new ArrayList(5),
                4 => new ArrayList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }),
                _ => throw new NotImplementedException()
            };
        }


        public static ArrayList GetArrayListToAddForAddLastArrayList(int index)
        {
            return index switch
            {
                0 => new ArrayList(new int[] { 4, 5, 6 }),
                1 => new ArrayList(new int[] { 1, 2 }),
                2 => new ArrayList(),
                3 => new ArrayList(7),
                4 => new ArrayList(7),
                _ => throw new NotImplementedException()
            };
        }

        public static ArrayList GetExpectedArrayListForAddLastArrayList(int index)
        {
            return index switch
            {
                0 => new ArrayList(new int[] { 1, 2, 3, 4, 5, 6 }),
                1 => new ArrayList(new int[] { 1, 2 }),
                2 => new ArrayList(5),
                3 => new ArrayList(new int[] { 5, 7 }),
                4 => new ArrayList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 7 }),
                _ => throw new NotImplementedException()
            };
        }



        public static ArrayList GetArrayListForAddAtInt(int index)
        {
            return index switch
            {
                0 => new ArrayList(new int[] { 1, 2, 3 }),
                1 => new ArrayList(),
                2 => new ArrayList(5),
                3 => new ArrayList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }),
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
                _ => throw new NotImplementedException()
            };
        }

        public static ArrayList GetExpectedArrayListForAddAtInt(int index)
        {
            return index switch
            {
                0 => new ArrayList(new int[] { 1, 5, 2, 3 }),
                1 => new ArrayList(10),
                2 => new ArrayList(new int[] { 5, 10 }),
                3 => new ArrayList(new int[] { 1, 2, 3, 4, 5, 10, 6, 7, 8, 9, 10 }),
                _ => throw new NotImplementedException()
            };
        }


        public static ArrayList GetArrayListForAddAtArrayList(int index)
        {
            return index switch
            {
                0 => new ArrayList(new int[] { 1, 2, 3 }),
                1 => new ArrayList(),
                2 => new ArrayList(new int[] { 1, 2, 3 }),
                3 => new ArrayList(5),
                4 => new ArrayList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }),
                5 => new ArrayList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }),
                _ => throw new NotImplementedException()
            };
        }


        public static (int index, ArrayList list) GetIndexAndArrayListToAddForAddAtArrayList(int index)
        {
            return index switch
            {
                0 => (0, new ArrayList(new int[] { 4, 5, 6 })),
                1 => (0, new ArrayList(new int[] { 1, 2 })),
                2 => (1, new ArrayList(new int[] { 8, 9 })),
                3 => (1, new ArrayList(7)),
                4 => (7, new ArrayList(15)),
                5 => (7, new ArrayList()),
                _ => throw new NotImplementedException()
            };
        }

        public static ArrayList GetExpectedArrayListForAddAtArrayList(int index)
        {
            return index switch
            {
                0 => new ArrayList(new int[] { 4, 5, 6, 1, 2, 3 }),
                1 => new ArrayList(new int[] { 1, 2 }),
                2 => new ArrayList(new int[] { 1, 8, 9, 2, 3 }),
                3 => new ArrayList(new int[] { 5, 7 }),
                4 => new ArrayList(new int[] { 1, 2, 3, 4, 5, 6, 7, 15, 8, 9, 10 }),
                5 => new ArrayList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }),
                _ => throw new NotImplementedException()
            };
        }

        public static ArrayList GetArrayListForAddAtArrayListTestNegative(int index)
        {
            return index switch
            {
                0 => new ArrayList(new int[] { 1, 2, 3 }),
                1 => new ArrayList(),
                2 => new ArrayList(5),
                3 => new ArrayList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }),
                _ => throw new NotImplementedException()
            };
        }


        public static ArrayList GetArrayListForSetTest(int index)
        {
            return index switch
            {
                0 => new ArrayList(new int[] { 1, 2, 3 }),
                1 => new ArrayList(new int[] { 1, 2, 3 }),
                2 => new ArrayList(new int[] { 1, 2, 3 }),
                3 => new ArrayList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }),
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

        public static ArrayList GetExpectedArrayListForSetTest(int index)
        {
            return index switch
            {
                0 => new ArrayList(new int[] { 1, 5, 3 }),
                1 => new ArrayList(new int[] { 10, 2, 3 }),
                2 => new ArrayList(new int[] { 1, 2, 10 }),
                3 => new ArrayList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 50 }),
                _ => throw new NotImplementedException()
            };
        }


        public static ArrayList GetArrayListForSetTestNegative(int index)
        {
            return index switch
            {
                0 => new ArrayList(new int[] { 1, 2, 3 }),
                1 => new ArrayList(),
                2 => new ArrayList(5),
                _ => throw new NotImplementedException()
            };
        }

        public static ArrayList GetArrayListForRemoveFirstTest(int index)
        {
            return index switch
            {
                0 => new ArrayList(new int[] { 1, 2, 3 }),
                1 => new ArrayList(1),
                //for shrink testing
                2 => new ArrayList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }),
                //for shrink testing when avoid Round int
                3 => new ArrayList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }),
                _ => throw new NotImplementedException()
            };
        }

        public static ArrayList GetExpectedArrayListForRemoveFirstTest(int index)
        {
            return index switch
            {
                0 => new ArrayList(new int[] { 2, 3 }),
                1 => new ArrayList(),
                2 => new ArrayList(new int[] { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }),
                3 => new ArrayList(new int[] { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }),
                _ => throw new NotImplementedException()
            };
        }

        public static ArrayList GetArrayListForRemoveLastTest(int index)
        {
            return index switch
            {
                0 => new ArrayList(new int[] { 1, 2, 3 }),
                1 => new ArrayList(1),
                //for shrink testing
                2 => new ArrayList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }),
                //for shrink testing when avoid Round int
                3 => new ArrayList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }),
                _ => throw new NotImplementedException()
            };
        }

        public static ArrayList GetExpectedArrayListForRemoveLastTest(int index)
        {
            return index switch
            {
                0 => new ArrayList(new int[] { 1, 2 }),
                1 => new ArrayList(),
                2 => new ArrayList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }),
                3 => new ArrayList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }),
                _ => throw new NotImplementedException()
            };
        }


        public static ArrayList GetArrayListForRemoveAtTest(int index)
        {
            return index switch
            {
                0 => new ArrayList(new int[] { 1, 2, 3 }),
                1 => new ArrayList(1),
                2 => new ArrayList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }),
                3 => new ArrayList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }),
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
                3 => 3,
                _ => throw new NotImplementedException()
            };
        }

        public static ArrayList GetExpectedArrayListForRemoveAtTest(int index)
        {
            return index switch
            {
                0 => new ArrayList(new int[] { 1, 3 }),
                1 => new ArrayList(),
                2 => new ArrayList(new int[] { 1, 2, 3, 4, 5, 6, 7, 9, 10, 11 }),
                3 => new ArrayList(new int[] { 1, 2, 3, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }),
                _ => throw new NotImplementedException()
            };
        }


        public static ArrayList GetArrayListForRemoveFirstMultipleTest(int index)
        {
            return index switch
            {
                0 => new ArrayList(new int[] { 1, 2, 3 }),
                1 => new ArrayList(new int[] { 1, 2, 3 }),
                2 => new ArrayList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }),
                3 => new ArrayList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }),
                4 => new ArrayList(new int[] { 1, 2, 3 }),
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

        public static ArrayList GetExpectedArrayListForRemoveFirstMultipleTest(int index)
        {
            return index switch
            {
                0 => new ArrayList(new int[] { 3 }),
                1 => new ArrayList(),
                2 => new ArrayList(new int[] { 6, 7, 8, 9, 10, 11 }),
                3 => new ArrayList(new int[] { 16 }),
                4 => new ArrayList(new int[] { 1, 2, 3 }),
                _ => throw new NotImplementedException()
            };
        }


        public static ArrayList GetArrayListForRemoveLastMultipleTest(int index)
        {
            return index switch
            {
                0 => new ArrayList(new int[] { 1, 2, 3 }),
                1 => new ArrayList(new int[] { 1, 2, 3 }),
                2 => new ArrayList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }),
                3 => new ArrayList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }),
                4 => new ArrayList(new int[] { 1, 2, 3 }),
                5 => new ArrayList(new int[] { 1, 2, 3, 4, 5, 6 }),
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

        public static ArrayList GetExpectedArrayListForRemoveLastMultipleTest(int index)
        {
            return index switch
            {
                0 => new ArrayList(new int[] { 1 }),
                1 => new ArrayList(),
                2 => new ArrayList(new int[] { 1, 2, 3, 4 }),
                3 => new ArrayList(new int[] { 1 }),
                4 => new ArrayList(new int[] { 1, 2, 3 }),
                5 => new ArrayList(new int[] { 1, 2, 3, 4, 5 }),
                _ => throw new NotImplementedException()
            };
        }


        public static ArrayList GetArrayListForRemoveAtMultipleTest(int index)
        {
            return index switch
            {
                0 => new ArrayList(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }),
                1 => new ArrayList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }),
                2 => new ArrayList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }),
                3 => new ArrayList(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }),
                4 => new ArrayList(new int[] { 1, 2, 3 }),
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
                _ => throw new NotImplementedException()
            };
        }

        public static ArrayList GetExpectedArrayListForRemoveAtMultipleTest(int index)
        {
            return index switch
            {
                0 => new ArrayList(new int[] { 0, 1, 2, 3, 8, 9 }),
                1 => new ArrayList(1),
                2 => new ArrayList(new int[] { 1, 16 }),
                3 => new ArrayList(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 15 }),
                4 => new ArrayList(new int[] { 1, 2, 3 }),
                _ => throw new NotImplementedException()
            };
        }


        public static ArrayList GetArrayListForRemoveFirstValueTest(int index)
        {
            return index switch
            {
                0 => new ArrayList(new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }),
                1 => new ArrayList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 }),
                2 => new ArrayList(new int[] { 1, 2, 3, 4 }),
                3 => new ArrayList(new int[] { 1, 2, 3, 4 }),
                4 => new ArrayList(new int[] { 1, 2, 3, 4 }),
                5 => new ArrayList(new int[] { 1, 2 }),
                6 => new ArrayList(1),
                7 => new ArrayList(),
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

        public static (ArrayList expectedArray, int expectedIndex) GetExpectedArrayListAndIndexForRemoveFirstValueTest(int index)
        {
            return index switch
            {
                0 => (new ArrayList(new int[] { 0, 1, 2, 3, 5, 6, 7, 8, 9 }), 4),
                1 => (new ArrayList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }), 10),
                2 => (new ArrayList(new int[] { 1, 2, 3, 4 }), -1),
                3 => (new ArrayList(new int[] { 2, 3, 4 }), 0),
                4 => (new ArrayList(new int[] { 1, 3, 4 }), 1),
                5 => (new ArrayList(1), 1),
                6 => (new ArrayList(), 0),
                7 => (new ArrayList(), -1),
                _ => throw new NotImplementedException()
            };
        }


        public static ArrayList GetArrayListForRemoveAllTest(int index)
        {
            return index switch
            {
                0 => new ArrayList(new int[] { 4, 3, 2, 4, 4 }),
                1 => new ArrayList(new int[] { 1, 2, 3 }),
                2 => new ArrayList(new int[] { 5, 5, 5, 5, 5, 5, 5, 5 }),
                3 => new ArrayList(new int[] { 5, 5, 5, 5, 7, 5, 5, 5 }),
                4 => new ArrayList(new int[] { 2, 9, 4, 2, 3, 6, 2, 10, 80 }),
                5 => new ArrayList(),
                6 => new ArrayList(new int[] { 5, 5, 5, 7, 5, 5, 5, 7, 5, 5, 5, 7 }),
                7 => new ArrayList(new int[] { 5, 5, 5, 7, 5, 5, 5, 7, 5, 5, 5, 7, 5, 5, 5 }),
                8 => new ArrayList(new int[] { 7, 5, 5, 5, 7, 5, 5, 5, 7, 5, 5, 5, 7 }),
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

        public static (ArrayList expectedArray, int expectedIndex) GetExpectedArrayListAndCountForRemoveAllTest(int index)
        {
            return index switch
            {
                0 => (new ArrayList(new int[] { 3, 2 }), 3),
                1 => (new ArrayList(new int[] { 1, 2, 3 }), 0),
                2 => (new ArrayList(), 8),
                3 => (new ArrayList(new int[] { 5, 5, 5, 5, 5, 5, 5 }), 1),
                4 => (new ArrayList(new int[] { 9, 4, 3, 6, 10, 80 }), 3),
                5 => (new ArrayList(), 0),
                6 => (new ArrayList(new int[] { 7, 7, 7 }), 9),
                7 => (new ArrayList(new int[] { 7, 7, 7 }), 12),
                8 => (new ArrayList(new int[] { 7, 7, 7, 7 }), 9),
                _ => throw new NotImplementedException()
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class LinkedList
    {
        private LinkedListNode _head;


        private LinkedListNode GetLastNode()
        {
            if (_head == null)
                return null;
            LinkedListNode currentNode = _head;
            while (currentNode.Next != null)
            {
                currentNode = currentNode.Next;
            }
            return currentNode;
        }


        public LinkedList()
        {
            _head = null;
        }

        public LinkedList(int value)
        {
            var node = new LinkedListNode { Value = value };
            _head = node;
        }

        public LinkedList(int[] array)
        {
            _head = null;

            if (array.Length == 0)
            {
                return;
            }

            _head = new LinkedListNode { Value = array[0] };
            LinkedListNode current = _head;
            for (int i = 1; i < array.Length; i++)
            {
                LinkedListNode previous = current;
                current = new LinkedListNode { Value = array[i] };
                previous.Next = current;
            }
        }

        public int GetLength()
        {
            int length = 0;
            LinkedListNode current = _head;
            while (current != null)
            {
                length++;
                current = current.Next;
            }
            return length;
        }

        public int[] ToArray()
        {
            int[] arrayToReturn = new int[GetLength()];

            int i = 0;
            LinkedListNode current = _head;
            while (current != null)
            {
                arrayToReturn[i] = current.Value;

                i++;
                current = current.Next;
            }
            return arrayToReturn;
        }

        public void AddFirst(int value)
        {
            AddAt(0, value);
        }

        private (LinkedListNode head, LinkedListNode tail) GetNewChainNodsByLinkedList(LinkedList list)
        {
            if (list._head == null)
                return (null, null);

            LinkedListNode currentNewChain = new LinkedListNode { Value = list._head.Value };
            LinkedListNode headNewChain = currentNewChain;

            LinkedListNode currentInList = list._head.Next;

            while (currentInList != null)
            {
                LinkedListNode previousToAdd = currentNewChain;
                currentNewChain = new LinkedListNode { Value = currentInList.Value };
                previousToAdd.Next = currentNewChain;

                currentInList = currentInList.Next;

            }

            return (headNewChain, currentNewChain);
        }

        public void AddFirst(LinkedList list)
        {
            if (list._head == null)
                return;

            (LinkedListNode headNewChain, LinkedListNode tailNewChain) = GetNewChainNodsByLinkedList(list);

            tailNewChain.Next = _head;
            _head = headNewChain;
        }

        public void AddLast(int value)
        {
            LinkedListNode node = new LinkedListNode { Value = value };
            if (_head == null)
            {
                _head = node;
                return;
            }
            LinkedListNode last = GetLastNode();
            last.Next = node;
        }

        public void AddLast(LinkedList list)
        {
            if (list._head == null)
                return;

            (LinkedListNode headNewChain, LinkedListNode tailNewChain) = GetNewChainNodsByLinkedList(list);

            if (_head == null)
            {
                _head = headNewChain;
                return;
            }

            LinkedListNode last = GetLastNode();
            last.Next = headNewChain;

        }

        public void AddAt(int index, int value)
        {
            if (index == 0)
            {
                LinkedListNode node = new LinkedListNode { Value = value, Next = _head };
                _head = node;
                return;
            }

            if (index < 0 || (index > 0 && _head == null))
            {
                throw new IndexOutOfRangeException();
            }


            LinkedListNode currentElement = _head;
            int currentIndex = 0;
            while (currentIndex != index - 1)
            {
                if (currentElement.Next == null)
                {
                    throw new IndexOutOfRangeException();
                }
                currentElement = currentElement.Next;
                currentIndex++;
            }

            LinkedListNode nodeToAdd = new LinkedListNode() { Value = value, Next = currentElement.Next };
            currentElement.Next = nodeToAdd;

        }

        private LinkedListNode GetPreviousNodeByIndex(int index)
        {
            LinkedListNode currentElement = _head;
            int currentIndex = 0;
            while (currentIndex != index - 1)
            {
                if (currentElement.Next == null)
                {
                    throw new IndexOutOfRangeException();
                }
                currentElement = currentElement.Next;
                currentIndex++;
            }
            return currentElement;
        }

        public void AddAt(int index, LinkedList list)
        {

            if (list._head == null)
                return;

            if (index < 0 || (index > 0 && _head == null))
            {
                throw new IndexOutOfRangeException();
            }

            if (index == 0)
            {
                AddFirst(list);
                return;
            }



            (LinkedListNode headNewChain, LinkedListNode tailNewChain) = GetNewChainNodsByLinkedList(list);

            LinkedListNode currentElement = GetPreviousNodeByIndex(index);

            if (currentElement.Next != null)
            {
                tailNewChain.Next = currentElement.Next;
            }

            currentElement.Next = headNewChain;

        }

        public void Set(int index, int value)
        {

            // for situation when LinkedList is empty you cannot set ANY value.
            // Even with zero index. You need to use Add method
            if (index < 0 || _head == null)
            {
                throw new IndexOutOfRangeException();
            }

            LinkedListNode currentElement = _head;
            int currentIndex = 0;
            while (currentIndex != index)
            {
                if (currentElement.Next == null)
                {
                    throw new IndexOutOfRangeException();
                }
                currentElement = currentElement.Next;
                currentIndex++;
            }
            currentElement.Value = value;
        }

        public void RemoveFirst()
        {
            if (_head == null)
            {
                throw new IndexOutOfRangeException();
            }

            _head = _head.Next;
        }

        public void RemoveLast()
        {
            if (_head == null)
            {
                throw new IndexOutOfRangeException();
            }

            if (_head.Next == null)
            {
                _head = null;
                return;
            }

            LinkedListNode current = _head;
            while (current.Next.Next != null)
            {
                current = current.Next;
            }

            current.Next = null;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || _head == null)
            {
                throw new IndexOutOfRangeException();
            }

            if (index == 0)
            {
                RemoveFirst();
                return;
            }

            LinkedListNode currentElement = GetPreviousNodeByIndex(index);

            if (currentElement.Next == null)
            {
                throw new IndexOutOfRangeException();
            }

            currentElement.Next = currentElement.Next.Next;
        }

        public void RemoveFirstMultiple(int count)
        {
            if (count == 0)
            {
                return;
            }

            if (count < 0)
            {
                throw new ArgumentException("Count can't be less than zero");
            }

            if (_head == null)
            {
                throw new IndexOutOfRangeException();
            }

            var previousElem = GetPreviousNodeByIndex(count);

            _head = previousElem.Next;

        }

        public void RemoveLastMultiple(int count)
        {
            if (count == 0)
            {
                return;
            }

            if (count < 0)
            {
                throw new ArgumentException("Count can't be less than zero");
            }

            if (_head == null)
            {
                throw new IndexOutOfRangeException();
            }

            int currentLength = GetLength();
            if (count > currentLength)
            {
                throw new IndexOutOfRangeException("Count of removed elements can't be grater than current length of LinkedList");
            }

            if (count == currentLength)
            {
                _head = null;
                return;
            }

            LinkedListNode nodeToRemoveLink = GetPreviousNodeByIndex(currentLength - count);

            nodeToRemoveLink.Next = null;

        }

        public void RemoveAtMultiple(int index, int count)
        {
            if (index == 0)
            {
                RemoveFirstMultiple(count);
                return;
            }

            if (count == 0)
            {
                return;
            }

            if (count < 0)
            {
                throw new ArgumentException("Count can't be less than zero");
            }

            if (_head == null)
            {
                throw new IndexOutOfRangeException();
            }

            int currentLength = GetLength();
            if (index + count > currentLength)
            {
                throw new IndexOutOfRangeException("You can't remove items outside of bounds LinkedList");
            }

            LinkedListNode currentElement = _head;
            int currentIndex = 0;
            LinkedListNode nodeToReplaceLink = new LinkedListNode();
            while (currentIndex != index + count - 1)
            {
                if (currentElement.Next == null)
                {
                    throw new IndexOutOfRangeException();
                }

                if (index == currentIndex + 1)
                {
                    nodeToReplaceLink = currentElement;
                }

                currentElement = currentElement.Next;
                currentIndex++;
            }

            nodeToReplaceLink.Next = currentElement.Next;
           
        }

        public int RemoveFirst(int value)
        {
            int indexToRemove = 0;
            LinkedListNode currentNode = _head;
            LinkedListNode previousNode = null;

            while (currentNode != null && currentNode.Value != value)
            {
                previousNode = currentNode;
                currentNode = currentNode.Next;
                indexToRemove++;
            }

            if (currentNode == null)
            {
                return -1;
            }

            if (indexToRemove == 0)
            {
                _head = _head.Next;
                return 0;
            }

            previousNode.Next = previousNode.Next.Next;
            return indexToRemove;
        }

        public int RemoveAll(int value)
        {
            // easy realisation with O(n^2) complexity (or not? I think it's that difficult)

            //int removedCount = 0;
            //while(RemoveFirst(value) != -1)
            //{
            //    removedCount++;
            //}
            //return removedCount;



            // more efficient realisation (because we pass through  LinkedList just once, and have O(n) complexity)

            LinkedListNode currentNode = _head;
            LinkedListNode newTail = _head;
            int removedCount = 0;

            while (currentNode != null)
            {
                if (currentNode.Value == value)
                {
                    if (currentNode == _head)
                    {
                        _head = _head.Next;
                    }
                    else
                    {
                        newTail.Next = currentNode.Next;
                    }
                    removedCount++;
                }
                else
                {
                    newTail = currentNode;
                }

                currentNode = currentNode.Next;

            }

            return removedCount;
        }

        public bool Contains(int value)
        {
            LinkedListNode currentNode = _head;
            while (currentNode != null)
            {
                if (currentNode.Value == value)
                    return true;

                currentNode = currentNode.Next;
            }
            return false;
        }

        public int IndexOf(int value)
        {
            int currentIndex = 0;
            LinkedListNode currentNode = _head;
            while (currentNode != null)
            {
                if (currentNode.Value == value)
                    return currentIndex;

                currentIndex++;
                currentNode = currentNode.Next;
            }
            return -1;
        }

        public int GetFirst()
        {
            if (_head == null)
                throw new IndexOutOfRangeException();

            return _head.Value;
        }

        public int GetLast()
        {
            if (_head == null)
                throw new IndexOutOfRangeException();

            return GetLastNode().Value;
        }

        public int Get(int index)
        {
            if (index < 0 || _head == null)
                throw new IndexOutOfRangeException();

            LinkedListNode currentNode = _head;
            int currentIndex = 0;

            while (currentNode != null)
            {
                if (currentIndex == index)
                    return currentNode.Value;

                currentIndex++;
                currentNode = currentNode.Next;
            }

            throw new IndexOutOfRangeException();

        }

        public void Reverse()
        {
            if (_head == null || _head.Next == null)
                return;

            LinkedListNode currentNode = _head.Next;
            LinkedListNode previousNode = _head;
            while (currentNode != null)
            {
                LinkedListNode next = currentNode.Next;

                currentNode.Next = previousNode;
                previousNode = currentNode;

                //for next loop
                currentNode = next;
            }

            _head.Next = null;
            _head = previousNode;
        }

        public int Max()
        {
            if (_head == null)
                throw new IndexOutOfRangeException();

            int maxValue = _head.Value;
            LinkedListNode currentNode = _head.Next;
            while (currentNode != null)
            {
                if (maxValue < currentNode.Value)
                {
                    maxValue = currentNode.Value;
                }
                currentNode = currentNode.Next;
            }
            return maxValue;
        }

        public int Min()
        {
            if (_head == null)
                throw new IndexOutOfRangeException();

            int minValue = _head.Value;
            LinkedListNode currentNode = _head.Next;
            while (currentNode != null)
            {
                if (minValue > currentNode.Value)
                {
                    minValue = currentNode.Value;
                }
                currentNode = currentNode.Next;
            }
            return minValue;
        }

        public int IndexOfMax()
        {
            if (_head == null)
                return -1;

            int maxValue = _head.Value;
            int indexOfMaxValue = 0;

            LinkedListNode currentNode = _head.Next;
            int currentIndex = 0;
            while (currentNode != null)
            {
                currentIndex++;
                if (maxValue < currentNode.Value)
                {
                    maxValue = currentNode.Value;
                    indexOfMaxValue = currentIndex;
                }
                currentNode = currentNode.Next;
            }
            return indexOfMaxValue;
        }

        public int IndexOfMin()
        {
            if (_head == null)
                return -1;

            int minValue = _head.Value;
            int indexOfMinValue = 0;

            LinkedListNode currentNode = _head.Next;
            int currentIndex = 0;
            while (currentNode != null)
            {
                currentIndex++;
                if (minValue > currentNode.Value)
                {
                    minValue = currentNode.Value;
                    indexOfMinValue = currentIndex;
                }
                currentNode = currentNode.Next;
            }
            return indexOfMinValue;
        }

        public void Sort()
        {
            if (_head == null || _head.Next == null)
                return;


            LinkedListNode currentNodeToCheck = _head;
            // bug or feature?
            LinkedListNode previousNodeToCheck = new LinkedListNode() { Next = _head };

            while (currentNodeToCheck.Next != null)
            {
                int minValue = currentNodeToCheck.Value;
                LinkedListNode previousNodeOfMinValueNode = previousNodeToCheck;

                LinkedListNode previousNodeOfFindMinValueNode = currentNodeToCheck;
                LinkedListNode currentNodeToFindMinValue = currentNodeToCheck.Next;

                while (currentNodeToFindMinValue != null)
                {
                    if (currentNodeToFindMinValue.Value < minValue)
                    {
                        minValue = currentNodeToFindMinValue.Value;
                        previousNodeOfMinValueNode = previousNodeOfFindMinValueNode;
                    }

                    previousNodeOfFindMinValueNode = currentNodeToFindMinValue;
                    currentNodeToFindMinValue = currentNodeToFindMinValue.Next;
                }


                if (previousNodeOfMinValueNode.Next.Value != previousNodeToCheck.Next.Value)
                {
                    // fucking magic -_- swap two Nodes of linked list


                    //for near nodes
                    if (previousNodeToCheck.Next == previousNodeOfMinValueNode)
                    {
                        LinkedListNode tmp1 = previousNodeOfMinValueNode.Next;
                        previousNodeOfMinValueNode.Next = previousNodeOfMinValueNode.Next.Next;

                        LinkedListNode tmp2 = previousNodeToCheck.Next;
                        if (previousNodeToCheck.Next == _head)
                        {
                            _head = tmp1;
                        }
                        else
                        {
                            previousNodeToCheck.Next = tmp1;
                        }
                        // for next loop
                        previousNodeToCheck = tmp1;

                        tmp1.Next = tmp2;
                    }
                    else
                    {
                        LinkedListNode _ = previousNodeOfMinValueNode.Next.Next;
                        previousNodeOfMinValueNode.Next.Next = previousNodeToCheck.Next.Next;
                        previousNodeToCheck.Next.Next = _;

                        _ = previousNodeToCheck.Next;
                        if (previousNodeToCheck.Next == _head)
                        {
                            _head = previousNodeOfMinValueNode.Next;
                        }
                        else
                        {
                            previousNodeToCheck.Next = previousNodeOfMinValueNode.Next;
                        }
                        //for next loop
                        previousNodeToCheck = previousNodeOfMinValueNode.Next;

                        previousNodeOfMinValueNode.Next = _;
                    }
                    //for next loop
                    currentNodeToCheck = previousNodeToCheck.Next;
                }
                else
                {
                    //for next loop
                    previousNodeToCheck = currentNodeToCheck;
                    currentNodeToCheck = currentNodeToCheck.Next;
                }

            }

        }

        public void SortDesc()
        {
            if (_head == null || _head.Next == null)
                return;


            LinkedListNode currentNodeToCheck = _head;
            // bug or feature?
            LinkedListNode previousNodeToCheck = new LinkedListNode() { Next = _head };

            while (currentNodeToCheck.Next != null)
            {
                int maxValue = currentNodeToCheck.Value;
                LinkedListNode previousNodeOfMaxValueNode = previousNodeToCheck;

                LinkedListNode previousNodeOfFindMaxValueNode = currentNodeToCheck;
                LinkedListNode currentNodeToFindMaxValue = currentNodeToCheck.Next;

                while (currentNodeToFindMaxValue != null)
                {
                    if (currentNodeToFindMaxValue.Value > maxValue)
                    {
                        maxValue = currentNodeToFindMaxValue.Value;
                        previousNodeOfMaxValueNode = previousNodeOfFindMaxValueNode;
                    }

                    previousNodeOfFindMaxValueNode = currentNodeToFindMaxValue;
                    currentNodeToFindMaxValue = currentNodeToFindMaxValue.Next;
                }


                if (previousNodeOfMaxValueNode.Next.Value != previousNodeToCheck.Next.Value)
                {
                    // fucking magic -_- swap two Nodes of linked list


                    //for near nodes
                    if (previousNodeToCheck.Next == previousNodeOfMaxValueNode)
                    {
                        LinkedListNode tmp1 = previousNodeOfMaxValueNode.Next;
                        previousNodeOfMaxValueNode.Next = previousNodeOfMaxValueNode.Next.Next;

                        LinkedListNode tmp2 = previousNodeToCheck.Next;
                        if (previousNodeToCheck.Next == _head)
                        {
                            _head = tmp1;
                        }
                        else
                        {
                            previousNodeToCheck.Next = tmp1;
                        }
                        // for next loop
                        previousNodeToCheck = tmp1;

                        tmp1.Next = tmp2;
                    }
                    else
                    {
                        LinkedListNode _ = previousNodeOfMaxValueNode.Next.Next;
                        previousNodeOfMaxValueNode.Next.Next = previousNodeToCheck.Next.Next;
                        previousNodeToCheck.Next.Next = _;

                        _ = previousNodeToCheck.Next;
                        if (previousNodeToCheck.Next == _head)
                        {
                            _head = previousNodeOfMaxValueNode.Next;
                        }
                        else
                        {
                            previousNodeToCheck.Next = previousNodeOfMaxValueNode.Next;
                        }
                        //for next loop
                        previousNodeToCheck = previousNodeOfMaxValueNode.Next;

                        previousNodeOfMaxValueNode.Next = _;
                    }
                    //for next loop
                    currentNodeToCheck = previousNodeToCheck.Next;
                }
                else
                {
                    //for next loop
                    previousNodeToCheck = currentNodeToCheck;
                    currentNodeToCheck = currentNodeToCheck.Next;
                }

            }

        }
    }

}

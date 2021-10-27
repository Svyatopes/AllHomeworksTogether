using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class LinkedList
    {
        private Node _head;
        private Node _tail;

        public LinkedList()
        {
            _head = null;
            _tail = null;
        }

        public LinkedList(int value)
        {
            var node = new Node { Value = value };
            _head = node;
            _tail = node;
        }

        public LinkedList(int[] array)
        {
            _head = null;
            _tail = null;

            if (array.Length == 0)
            {
                return;
            }

            _head = new Node { Value = array[0] };
            Node current = _head;
            for (int i = 1; i < array.Length; i++)
            {
                Node previous = current;
                current = new Node { Value = array[i] };
                previous.Next = current;
            }
            _tail = current;
        }

        public int GetLength()
        {
            int length = 0;
            Node current = _head;
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
            Node current = _head;
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

        private (Node head, Node tail) GetNewChainNodsByLinkedList(LinkedList list)
        {
            if (list._head == null)
                return (null, null);

            Node currentNewChain = new Node { Value = list._head.Value };
            Node headNewChain = currentNewChain;

            Node currentInList = list._head.Next;

            while (currentInList != null)
            {
                Node previousToAdd = currentNewChain;
                currentNewChain = new Node { Value = currentInList.Value };
                previousToAdd.Next = currentNewChain;

                currentInList = currentInList.Next;

            }

            return (headNewChain, currentNewChain);
        }

        public void AddFirst(LinkedList list)
        {
            if (list._head == null)
                return;

            (Node headNewChain, Node tailNewChain) = GetNewChainNodsByLinkedList(list);

            tailNewChain.Next = _head;
            _head = headNewChain;
        }

        public void AddLast(int value)
        {
            Node node = new Node { Value = value };
            if (_head == null)
            {
                _head = node;
                _tail = node;
            }
            else
            {
                _tail.Next = node;
                _tail = node;
            }
        }

        public void AddLast(LinkedList list)
        {
            if (list._head == null)
                return;

            (Node headNewChain, Node tailNewChain) = GetNewChainNodsByLinkedList(list);

            if (_head == null)
            {
                _head = headNewChain;
                _tail = tailNewChain;
            }
            else
            {
                _tail.Next = headNewChain;
                _tail = tailNewChain;
            }

        }

        public void AddAt(int index, int value)
        {
            if (index == 0)
            {
                Node node = new Node { Value = value, Next = _head };
                _head = node;
                if (_tail == null)
                {
                    _tail = node;
                }
                return;
            }

            if (index < 0 || (index > 0 && _head == null))
            {
                throw new IndexOutOfRangeException();
            }


            Node currentElement = _head;
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

            Node nodeToAdd = new Node() { Value = value, Next = currentElement.Next };
            if (currentElement.Next == null)
            {
                _tail = nodeToAdd;
            }
            currentElement.Next = nodeToAdd;

        }

        private Node GetPreviousNodeByIndex(int index)
        {
            Node currentElement = _head;
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



            (Node headNewChain, Node tailNewChain) = GetNewChainNodsByLinkedList(list);

            Node currentElement = GetPreviousNodeByIndex(index);

            if (currentElement.Next == null)
            {
                _tail = tailNewChain;
            }
            else
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

            Node currentElement = _head;
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
                _tail = null;
                return;
            }

            Node current = _head;
            while (current.Next.Next != null)
            {
                current = current.Next;
            }

            current.Next = null;
            _tail = current;
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

            Node currentElement = GetPreviousNodeByIndex(index);

            if (currentElement.Next == null)
            {
                throw new IndexOutOfRangeException();
            }

            if (currentElement.Next.Next == null)
            {
                _tail = currentElement;
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
            if (_head == null)
            {
                _tail = null;
            }

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
                _tail = null;
                return;
            }

            Node nodeToRemoveLink = GetPreviousNodeByIndex(currentLength - count);

            nodeToRemoveLink.Next = null;
            _tail = nodeToRemoveLink;

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

            Node currentElement = _head;
            int currentIndex = 0;
            Node nodeToReplaceLink = new Node();
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
            if (nodeToReplaceLink.Next == null)
            {
                _tail = nodeToReplaceLink;
            }
        }

        public int RemoveFirst(int value)
        {
            int indexToRemove = 0;
            Node currentNode = _head;
            Node previousNode = null;

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
                if (_head == null)
                {
                    _tail = _head;
                }
                return 0;
            }

            previousNode.Next = previousNode.Next.Next;
            if (previousNode.Next == null)
            {
                _tail = previousNode;
            }
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

            Node currentNode = _head;
            Node newTail = _head;
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

            _tail = _head == null ? null : newTail;

            return removedCount;
        }

        public bool Contains(int value)
        {
            Node currentNode = _head;
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
            Node currentNode = _head;
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

            return _tail.Value;
        }

        public int Get(int index)
        {
            if (index < 0 || _head == null)
                throw new IndexOutOfRangeException();

            Node currentNode = _head;
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

            Node currentNode = _head.Next;
            Node previousNode = _head;
            while (currentNode != null)
            {
                Node next = currentNode.Next;

                currentNode.Next = previousNode;
                previousNode = currentNode;

                //for next loop
                currentNode = next;
            }

            _head.Next = null;
            _tail = _head;
            _head = previousNode;
        }

        public int Max()
        {
            if (_head == null)
                throw new IndexOutOfRangeException();

            int maxValue = _head.Value;
            Node currentNode = _head.Next;
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
            Node currentNode = _head.Next;
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

            Node currentNode = _head.Next;
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

            Node currentNode = _head.Next;
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


            Node currentNodeToCheck = _head;
            // bug or feature?
            Node previousNodeToCheck = new Node() { Next = _head };

            while (currentNodeToCheck.Next != null)
            {
                int minValue = currentNodeToCheck.Value;
                Node previousNodeOfMinValueNode = previousNodeToCheck;

                Node previousNodeOfFindMinValueNode = currentNodeToCheck;
                Node currentNodeToFindMinValue = currentNodeToCheck.Next;

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
                        Node tmp1 = previousNodeOfMinValueNode.Next;
                        previousNodeOfMinValueNode.Next = previousNodeOfMinValueNode.Next.Next;

                        Node tmp2 = previousNodeToCheck.Next;
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
                        Node _ = previousNodeOfMinValueNode.Next.Next;
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


            Node currentNodeToCheck = _head;
            // bug or feature?
            Node previousNodeToCheck = new Node() { Next = _head };

            while (currentNodeToCheck.Next != null)
            {
                int maxValue = currentNodeToCheck.Value;
                Node previousNodeOfMaxValueNode = previousNodeToCheck;

                Node previousNodeOfFindMaxValueNode = currentNodeToCheck;
                Node currentNodeToFindMaxValue = currentNodeToCheck.Next;

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
                        Node tmp1 = previousNodeOfMaxValueNode.Next;
                        previousNodeOfMaxValueNode.Next = previousNodeOfMaxValueNode.Next.Next;

                        Node tmp2 = previousNodeToCheck.Next;
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
                        Node _ = previousNodeOfMaxValueNode.Next.Next;
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

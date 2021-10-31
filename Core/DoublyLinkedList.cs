using System;

namespace Core
{
    public class DoublyLinkedList
    {
        private DoublyLinkedListNode _head;
        private DoublyLinkedListNode _tail;

        public DoublyLinkedList()
        {
            _head = null;
            _tail = null;
        }

        public DoublyLinkedList(int value)
        {
            var node = new DoublyLinkedListNode { Value = value };
            _head = node;
            _tail = node;
        }

        public DoublyLinkedList(int[] array)
        {
            _head = null;
            _tail = null;

            if (array.Length == 0)
            {
                return;
            }

            _head = new DoublyLinkedListNode { Value = array[0] };
            DoublyLinkedListNode current = _head;
            for (int i = 1; i < array.Length; i++)
            {
                DoublyLinkedListNode previous = current;
                current = new DoublyLinkedListNode { Value = array[i], Previous = previous };
                previous.Next = current;
            }
            _tail = current;
        }

        public int GetLength()
        {
            int length = 0;
            DoublyLinkedListNode current = _head;
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
            DoublyLinkedListNode current = _head;
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

        private static (DoublyLinkedListNode head, DoublyLinkedListNode tail) GetNewChainNodsByDoublyLinkedList(DoublyLinkedList list)
        {
            if (list._head == null)
                return (null, null);

            DoublyLinkedListNode currentNewChain = new DoublyLinkedListNode { Value = list._head.Value, Previous = null };
            DoublyLinkedListNode headNewChain = currentNewChain;

            DoublyLinkedListNode currentInList = list._head.Next;

            while (currentInList != null)
            {
                DoublyLinkedListNode previousToAdd = currentNewChain;
                currentNewChain = new DoublyLinkedListNode { Value = currentInList.Value, Previous = previousToAdd };
                previousToAdd.Next = currentNewChain;

                currentInList = currentInList.Next;

            }

            return (headNewChain, currentNewChain);
        }

        public void AddFirst(DoublyLinkedList list)
        {
            if (list._head == null)
                return;

            (DoublyLinkedListNode headNewChain, DoublyLinkedListNode tailNewChain) = GetNewChainNodsByDoublyLinkedList(list);

            tailNewChain.Next = _head;
            if (tailNewChain.Next != null)
            {
                tailNewChain.Next.Previous = tailNewChain;
            }
            else
            {
                _tail = tailNewChain;
            }
            _head = headNewChain;
        }

        public void AddLast(int value)
        {
            DoublyLinkedListNode node = new DoublyLinkedListNode { Value = value };
            if (_head == null)
            {
                _head = node;
                _tail = node;
                return;
            }

            _tail.Next = node;
            node.Previous = _tail;
            _tail = node;
        }

        public void AddLast(DoublyLinkedList list)
        {
            if (list._head == null)
                return;

            (DoublyLinkedListNode headNewChain, DoublyLinkedListNode tailNewChain) = GetNewChainNodsByDoublyLinkedList(list);

            if (_head == null)
            {
                _head = headNewChain;
                _tail = tailNewChain;
                return;
            }

            _tail.Next = headNewChain;
            headNewChain.Previous = _tail;
            _tail = tailNewChain;
        }

        public void AddAt(int index, int value)
        {
            if (index == 0)
            {
                DoublyLinkedListNode node = new DoublyLinkedListNode { Value = value, Next = _head };
                if (_head == null)
                {
                    _tail = node;
                }
                _head = node;
                return;
            }

            if (index < 0 || (index > 0 && _head == null))
            {
                throw new IndexOutOfRangeException();
            }


            DoublyLinkedListNode currentElement = _head;
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

            DoublyLinkedListNode nodeToAdd = new DoublyLinkedListNode() { Value = value, Next = currentElement.Next, Previous = currentElement };
            nodeToAdd.Previous.Next = nodeToAdd;
            if (nodeToAdd.Next != null)
            {
                nodeToAdd.Next.Previous = nodeToAdd;
            }
            else
            {
                _tail = nodeToAdd;
            }

        }

        private DoublyLinkedListNode GetPreviousNodeByIndex(int index)
        {
            DoublyLinkedListNode currentElement = _head;
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

        public void AddAt(int index, DoublyLinkedList list)
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



            (DoublyLinkedListNode headNewChain, DoublyLinkedListNode tailNewChain) = GetNewChainNodsByDoublyLinkedList(list);

            DoublyLinkedListNode currentElement = GetPreviousNodeByIndex(index);

            if (currentElement.Next != null)
            {
                tailNewChain.Next = currentElement.Next;
            }
            else
            {
                _tail = tailNewChain;
            }

            currentElement.Next = headNewChain;
            headNewChain.Previous = currentElement;

        }

        public void Set(int index, int value)
        {

            // for situation when LinkedList is empty you cannot set ANY value.
            // Even with zero index. You need to use Add method
            if (index < 0 || _head == null)
            {
                throw new IndexOutOfRangeException();
            }

            DoublyLinkedListNode currentElement = _head;
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

            if (_head.Next != null)
            {
                _head.Next.Previous = null;
            }
            else
            {
                _tail = null;
            }
            _head = _head.Next;
        }

        public void RemoveLast()
        {
            if (_head == null)
            {
                throw new IndexOutOfRangeException();
            }

            if (_tail.Previous == null)
            {
                _head = null;
                _tail = null;
                return;
            }

            _tail.Previous.Next = null;
            _tail = _tail.Previous;

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

            DoublyLinkedListNode currentElement = GetPreviousNodeByIndex(index);

            if (currentElement.Next == null)
            {
                throw new IndexOutOfRangeException();
            }

            if (currentElement.Next.Next != null)
            {
                currentElement.Next.Next.Previous = currentElement;
            }
            else
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
            if (_head ==  null || _head.Next == null)
            {
                _tail = _head;
            }
            if (_head != null)
            {
                _head.Previous = null;
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

            int currentCount = 0;
            DoublyLinkedListNode currentNode = _tail;

            while (currentCount != count - 1)
            {
                if (currentNode.Previous == null)
                {
                    throw new IndexOutOfRangeException();
                }

                currentNode = currentNode.Previous;
                currentCount++;
            }

            if (currentNode.Previous != null)
            {
                _tail = currentNode.Previous;
                _tail.Next = null;
            }
            else
            {
                _head = null;
                _tail = null;
            }


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


            DoublyLinkedListNode currentElement = _head;
            int currentIndex = 0;
            DoublyLinkedListNode nodeToReplaceLink = new DoublyLinkedListNode();
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
            if (nodeToReplaceLink.Next != null)
            {
                nodeToReplaceLink.Next.Previous = nodeToReplaceLink;
            }
            else
            {
                _tail = nodeToReplaceLink;
            }

        }

        public int RemoveFirst(int value)
        {
            int indexToRemove = 0;
            DoublyLinkedListNode currentNode = _head;
            DoublyLinkedListNode previousNode = null;

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
                if (_head != null)
                {
                    _head.Previous = null;
                }
                if (_head == null || _head.Next == null)
                {
                    _tail = _head;
                }
                return 0;
            }

            previousNode.Next = previousNode.Next.Next;
            if (previousNode.Next != null)
            {
                previousNode.Next.Previous = previousNode;
            }
            else
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

            DoublyLinkedListNode currentNode = _head;
            DoublyLinkedListNode newTail = _head;
            int removedCount = 0;

            while (currentNode != null)
            {
                if (currentNode.Value == value)
                {
                    if (currentNode == _head)
                    {
                        _head = _head.Next;
                        if (_head != null)
                        {
                            _head.Previous = null;
                        }
                    }
                    else
                    {
                        newTail.Next = currentNode.Next;
                        if (newTail.Next != null)
                        {
                            newTail.Next.Previous = newTail;
                        }
                    }
                    removedCount++;
                }
                else
                {
                    newTail = currentNode;
                }

                currentNode = currentNode.Next;

            }
            if (_head == null)
            {
                _tail = null;
            }
            else
            {
                _tail = newTail;
            }
            return removedCount;
        }

        public bool Contains(int value)
        {
            return IndexOf(value) != -1;
        }

        public int IndexOf(int value)
        {
            int currentIndex = 0;
            DoublyLinkedListNode currentNode = _head;
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

            DoublyLinkedListNode currentNode = _head;
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

            DoublyLinkedListNode currentNode = _head;
            while (currentNode != null)
            {
                DoublyLinkedListNode next = currentNode.Next;

                currentNode.Next = currentNode.Previous;
                currentNode.Previous = next;

                //for next loop
                currentNode = next;
            }

            DoublyLinkedListNode _ = _head;
            _head = _tail;
            _tail = _;
        }

        public int Max()
        {
            if (_head == null)
                throw new IndexOutOfRangeException();

            int maxValue = _head.Value;
            DoublyLinkedListNode currentNode = _head.Next;
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
            DoublyLinkedListNode currentNode = _head.Next;
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

            DoublyLinkedListNode currentNode = _head.Next;
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

            DoublyLinkedListNode currentNode = _head.Next;
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


            DoublyLinkedListNode currentNodeToCheck = _head;
            DoublyLinkedListNode newTail = _tail;

            while (currentNodeToCheck.Next != null)
            {
                int minValue = currentNodeToCheck.Value;

                DoublyLinkedListNode minValueNode = currentNodeToCheck;
                DoublyLinkedListNode currentNodeToFindMinValue = currentNodeToCheck.Next;

                while (currentNodeToFindMinValue != null)
                {
                    if (currentNodeToFindMinValue.Value < minValue)
                    {
                        minValue = currentNodeToFindMinValue.Value;
                        minValueNode = currentNodeToFindMinValue;
                    }
                    currentNodeToFindMinValue = currentNodeToFindMinValue.Next;
                }


                if (minValueNode.Value != currentNodeToCheck.Value)
                {
                    //for near nodes
                    if (currentNodeToCheck == minValueNode.Previous)
                    {
                        if (currentNodeToCheck == _head)
                        {
                            _head = minValueNode;
                        }
                        else
                        {
                            currentNodeToCheck.Previous.Next = minValueNode;
                        }

                        if (minValueNode.Next != null)
                        {
                            minValueNode.Next.Previous = currentNodeToCheck;
                        }

                        currentNodeToCheck.Next = minValueNode.Next;
                        minValueNode.Previous = currentNodeToCheck.Previous;

                        currentNodeToCheck.Previous = minValueNode;
                        minValueNode.Next = currentNodeToCheck;

                        if (currentNodeToCheck.Next == null)
                        {
                            newTail = currentNodeToCheck;
                        }

                        //for next loop
                        // nothing to do because we have moved to right when swap nodes
                    }
                    else
                    {
                        if (currentNodeToCheck == _head)
                        {
                            _head = minValueNode;
                        }
                        else
                        {
                            currentNodeToCheck.Previous.Next = minValueNode;
                        }
                        currentNodeToCheck.Next.Previous = minValueNode;

                        minValueNode.Previous.Next = currentNodeToCheck;
                        if (minValueNode.Next == null)
                        {
                            newTail = currentNodeToCheck;
                        }
                        else
                        {
                            minValueNode.Next.Previous = currentNodeToCheck;
                        }

                        DoublyLinkedListNode _ = currentNodeToCheck.Previous;
                        currentNodeToCheck.Previous = minValueNode.Previous;
                        minValueNode.Previous = _;

                        _ = currentNodeToCheck.Next;
                        currentNodeToCheck.Next = minValueNode.Next;
                        minValueNode.Next = _;

                        //for next loop
                        currentNodeToCheck = minValueNode.Next;
                    }
                }
                else
                {
                    //for next loop
                    currentNodeToCheck = currentNodeToCheck.Next;
                }

            }


            _tail = newTail;

        }


        public void SortDesc()
        {
            if (_head == null || _head.Next == null)
                return;


            DoublyLinkedListNode currentNodeToCheck = _head;
            DoublyLinkedListNode newTail = _tail;

            while (currentNodeToCheck.Next != null)
            {
                int maxValue = currentNodeToCheck.Value;

                DoublyLinkedListNode maxValueNode = currentNodeToCheck;
                DoublyLinkedListNode currentNodeToFindMaxValue = currentNodeToCheck.Next;

                while (currentNodeToFindMaxValue != null)
                {
                    if (currentNodeToFindMaxValue.Value > maxValue)
                    {
                        maxValue = currentNodeToFindMaxValue.Value;
                        maxValueNode = currentNodeToFindMaxValue;
                    }
                    currentNodeToFindMaxValue = currentNodeToFindMaxValue.Next;
                }


                if (maxValueNode.Value != currentNodeToCheck.Value)
                {
                    //for near nodes
                    if (currentNodeToCheck == maxValueNode.Previous)
                    {
                        if (currentNodeToCheck == _head)
                        {
                            _head = maxValueNode;
                        }
                        else
                        {
                            currentNodeToCheck.Previous.Next = maxValueNode;
                        }

                        if (maxValueNode.Next != null)
                        {
                            maxValueNode.Next.Previous = currentNodeToCheck;
                        }

                        currentNodeToCheck.Next = maxValueNode.Next;
                        maxValueNode.Previous = currentNodeToCheck.Previous;

                        currentNodeToCheck.Previous = maxValueNode;
                        maxValueNode.Next = currentNodeToCheck;

                        if (currentNodeToCheck.Next == null)
                        {
                            newTail = currentNodeToCheck;
                        }

                        //for next loop
                        // nothing to do because we have moved to right when swap nodes
                    }
                    else
                    {
                        if (currentNodeToCheck == _head)
                        {
                            _head = maxValueNode;
                        }
                        else
                        {
                            currentNodeToCheck.Previous.Next = maxValueNode;
                        }
                        currentNodeToCheck.Next.Previous = maxValueNode;

                        maxValueNode.Previous.Next = currentNodeToCheck;
                        if (maxValueNode.Next == null)
                        {
                            newTail = currentNodeToCheck;
                        }
                        else
                        {
                            maxValueNode.Next.Previous = currentNodeToCheck;
                        }

                        DoublyLinkedListNode _ = currentNodeToCheck.Previous;
                        currentNodeToCheck.Previous = maxValueNode.Previous;
                        maxValueNode.Previous = _;

                        _ = currentNodeToCheck.Next;
                        currentNodeToCheck.Next = maxValueNode.Next;
                        maxValueNode.Next = _;

                        //for next loop
                        currentNodeToCheck = maxValueNode.Next;
                    }
                }
                else
                {
                    //for next loop
                    currentNodeToCheck = currentNodeToCheck.Next;
                }

            }


            _tail = newTail;

        }
    }
}

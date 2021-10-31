using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class DoublyLinkedListNode
    {
        public int Value { get; set; }

        public DoublyLinkedListNode Previous { get; set; }
        public DoublyLinkedListNode Next { get; set; }
    }
}

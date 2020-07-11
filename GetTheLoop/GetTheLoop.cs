using System;
using System.Collections.Generic;
using System.Linq;

namespace GetTheLoop
{
    public class Node : IEquatable<Node>
    {
        public Guid Id { get; }
        public Node Next { get; set; }
        public Node()
        {
            Id = Guid.NewGuid();
        }

        public bool Equals(Node other)
        {
            return this.Id.Equals(other.Id);
        }
    }

    public class GetTheLoopKata
    {
        public static int GetLoopSize(Node startNode)
        {
            var slow = startNode;
            var fast = startNode.Next;
            while (!fast.Equals(slow))
            {
                slow = slow.Next;
                fast = fast.Next.Next;
            }

            fast = fast.Next;
            int steps = 1;
            while (!slow.Equals(fast))
            {
                fast = fast.Next;
                steps++;
            }

            return steps;
        }
    }
}

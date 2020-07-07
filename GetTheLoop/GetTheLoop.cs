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
            var fast = startNode.Next.Next;
            var slow = startNode.Next;
            while (fast != slow)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
            }

            fast = fast.Next;
            int steps = 1;
            if (!slow.Equals(fast))
            {
                fast = fast.Next;
                steps++;
            }

            return steps;
        }
    }
}

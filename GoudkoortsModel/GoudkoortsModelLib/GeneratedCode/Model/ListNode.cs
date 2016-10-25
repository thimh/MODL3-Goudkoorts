using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace GoudkoortsModelLib.GeneratedCode.Model
{
    public class ListNode<BaseTile> : IEnumerable<BaseTile>
    {
        public BaseTile tile;
        public ListNode<BaseTile> Next;
        private ListNode() { }

        public ListNode(IEnumerable<BaseTile> init)
        {
            ListNode<BaseTile> current = null;
            foreach (var elem in init)
            {
                if (current == null)
                {
                    current = this;
                }
                else
                {
                    current = current.Next = new ListNode<BaseTile>();
                }
                current.tile = elem;
            }
        }

        class ListEnum : IEnumerator<BaseTile>
        {
            private ListNode<BaseTile> first;
            private ListNode<BaseTile> current;
            private bool more;

            public ListEnum(ListNode<BaseTile> first)
            {
                this.first = first;
                more = true;
            }

            public BaseTile Current { get { return current.tile; } }

            public void Dispose()
            {

            }

            object System.Collections.IEnumerator.Current { get { return current.tile; } }

            public void Reset()
            {
                current = null;
                more = true;
            }

            public bool MoveNext()
            {
                if (!more)
                {
                    return false;
                }
                else if (current == null)
                {
                    return more = ((current = first) != null);
                }
                else
                {
                    return more = ((current = current.Next) != null);
                }
            }
        }

        public IEnumerator<BaseTile> GetEnumerator()
        {
            return new ListEnum(this);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

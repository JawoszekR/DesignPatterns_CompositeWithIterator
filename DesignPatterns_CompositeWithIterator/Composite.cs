using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns_CompositeWithIterator
{
    abstract class Composite : IEnumerable
    {
        public virtual void Add(Composite composite)
        {
            throw new NotSupportedException();
        }

        public virtual void Remove(Composite composite)
        {
            throw new NotSupportedException();
        }

        public virtual void Write()
        {
            throw new NotSupportedException();
        }

        public IEnumerator GetEnumerator()
        {
            return new CompositeEnumerator(this);
        }

        sealed class CompositeEnumerator : IEnumerator
        {
            public object Current { get; private set; }
            private Composite _startPoint;
            private Stack<IEnumerator> _stack;

            public CompositeEnumerator(Composite composite)
            {
                Current = composite;
                _startPoint = composite;
                _stack = new Stack<IEnumerator>();
            }

            public bool MoveNext()
            {
                if (HasNext())
                {
                    Current = _stack.Peek().Current;
                    return true;
                }
                return false;
            }

            private bool HasNext()
            {
                if (Current is Node)
                {
                    var node = Current as Node;
                    _stack.Push(node.GetChildrensEnumerator());
                    if (!_stack.Peek().MoveNext())
                    {
                        return GoUp();
                    }
                }
                else if (Current is Leaf && !_stack.Peek().MoveNext())
                {
                    return GoUp();
                }
                return true;
            }

            private bool GoUp()
            {
                if (_stack.Count < 2)
                    return false;
                _stack.Pop();
                if (_stack.Peek().MoveNext())
                {
                    return true;
                }
                else
                {
                    return GoUp();
                }

            }

            public void Reset()
            {
                Current = _startPoint;
            }
        }
    }
}

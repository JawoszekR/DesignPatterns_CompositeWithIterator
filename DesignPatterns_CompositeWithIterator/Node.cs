using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns_CompositeWithIterator
{
    class Node : Composite
    {
        protected List<Composite> Childrens;
        string _text;

        public Node(string text)
        {
            Childrens = new List<Composite>();
            _text = text;
        }

        public override void Add(Composite composite)
        {
            Childrens.Add(composite);
        }

        public override void Remove(Composite composite)
        {
            Childrens.Remove(composite);
        }

        public override void Write()
        {
            Console.WriteLine(_text);
        }

        public IEnumerator<Composite> GetChildrensEnumerator()
        {
            return Childrens.GetEnumerator();
        }
    }
}

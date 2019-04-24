using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns_CompositeWithIterator
{
    class Leaf : Composite
    {
        private string _text;

        public Leaf(string text)
        {
            _text = text;
        }

        public override void Write()
        {
            Console.WriteLine(_text);
        }
    }
}

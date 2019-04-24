using System;

namespace DesignPatterns_CompositeWithIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Node node1 = new Node("-----------Node1------------");
            Node node2 = new Node("-----------Node2------------");
            Node node3 = new Node("-----------Node3------------");
            Node node4 = new Node("-----------Node4------------");

            Leaf leaf1 = new Leaf("Leaf1");
            Leaf leaf2 = new Leaf("Leaf2");
            Leaf leaf3 = new Leaf("Leaf3");
            Leaf leaf4 = new Leaf("Leaf4");
            Leaf leaf5 = new Leaf("Leaf5");
            Leaf leaf6 = new Leaf("Leaf6");
            Leaf leaf7 = new Leaf("Leaf7");
            Leaf leaf8 = new Leaf("Leaf8");
            Leaf leaf9 = new Leaf("Leaf9");
            Leaf leaf10 = new Leaf("Leaf10");

            node1.Add(leaf1);
            node1.Add(leaf2);
            node1.Add(node2);
            node1.Add(leaf3);
            node1.Add(node3);
            node2.Add(leaf4);
            node2.Add(leaf5);
            node3.Add(leaf6);
            node3.Add(leaf7);
            node3.Add(node4);
            node4.Add(leaf8);
            node4.Add(leaf9);
            node3.Add(leaf10);

            foreach (Composite composit in node1)
            {
                composit.Write();
            }

            Console.ReadKey();
        }
    }
}

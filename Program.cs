namespace HashTable1
{ 
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to hashtable");
            MyMapNode<string, string> node = new MyMapNode<string, string>(5);
            node.Add("0", "Paranoids");
            node.Add("1", "are");
            node.Add("2", "not");
            node.Add("3", "Paranoid");
            node.Add("4", "because");
            node.Add("5", "they");
            node.Add("6", "are");
            node.Add("7", "paranoid");
            node.Add("8", "but");
            node.Add("9", "beacudse");
            node.Add("10", "they");
            node.Add("11", "keep");
            node.Add("12", "putting");
            node.Add("13", "themselves");
            node.Add("14", "deliberately");
            node.Add("15", "into");
            node.Add("16", "paranoid");
            node.Add("17", "avoidable");
            node.Add("18", "situation");


            string node0 = node.Get("0");
            Console.WriteLine("0th index value: " + node0);
            string node1 = node.Get("1");
            Console.WriteLine("1st index value: " + node1);
            string node2 = node.Get("2");
            Console.WriteLine("2nd index value: " + node2);
            string node3 = node.Get("3");
            Console.WriteLine("3rd index value: " + node3);
            string node4 = node.Get("4");
            Console.WriteLine("4th index value: " + node4);
            string node5 = node.Get("5");
            Console.WriteLine("5th index value: " + node5);
            string node6 = node.Get("6");
            Console.WriteLine("6th index value: " + node6);
            string node7 = node.Get("7");
            Console.WriteLine("7th index value: " + node7);
            string node8 = node.Get("8");
            Console.WriteLine("8th index value: " + node8);
            string node9 = node.Get("9");
            Console.WriteLine("9th index value: " + node9);
            string node10 = node.Get("10");
            Console.WriteLine("10th index value: " + node10);
            string node11 = node.Get("11");
            Console.WriteLine("11th index value: " + node11);
            string node12 = node.Get("12");
            Console.WriteLine("12th index value: " + node12);
            string node13 = node.Get("13");
            Console.WriteLine("13th index value: " + node13);
            string node14 = node.Get("14");
            Console.WriteLine("14th index value: " + node14);
            string node15 = node.Get("15");
            Console.WriteLine("15th index value: " + node15);
            string node16 = node.Get("16");
            Console.WriteLine("16th index value: " + node16);
            string node17 = node.Get("17");
            Console.WriteLine("17th index value: " + node17);
            string node18 = node.Get("18");
            Console.WriteLine("18th index value: " + node18);
        }
    }
}

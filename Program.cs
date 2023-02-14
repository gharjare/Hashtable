namespace HashTable1
{ 
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to hashtable");
            MyMapNode<string, string> list = new MyMapNode<string, string>(18);
            list.Add("0", "Paranoids");
            list.Add("1", "are");
            list.Add("2", "not");
            list.Add("3", "Paranoid");
            list.Add("4", "because");
            list.Add("5", "they");
            list.Add("6", "are");
            list.Add("7", "paranoid");
            list.Add("8", "but");
            list.Add("9", "beacudse");
            list.Add("10", "they");
            list.Add("11", "keep");
            list.Add("12", "putting");
            list.Add("13", "themselves");
            list.Add("14", "deliberately");
            list.Add("15", "into");
            list.Add("16", "paranoid");
            list.Add("17", "avoidable");
            list.Add("18", "situation");

            string list0 = list.Get("0");
            Console.WriteLine("0th index value: " + list0);
            string list1 = list.Get("1");
            Console.WriteLine("1st index value: " + list1);
            string list2 = list.Get("2");
            Console.WriteLine("2nd index value: " + list2);
            string list3 = list.Get("3");
            Console.WriteLine("3rd index value: " + list3);
            string list4 = list.Get("4");
            Console.WriteLine("4th index value: " + list4);
            string list5 = list.Get("5");
            Console.WriteLine("5th index value: " + list5);
            string list6 = list.Get("6");
            Console.WriteLine("6th index value: " + list6);
            string list7 = list.Get("7");
            Console.WriteLine("7th index value: " + list7);
            string list8 = list.Get("8");
            Console.WriteLine("8th index value: " + list8);
            string list9 = list.Get("9");
            Console.WriteLine("9th index value: " + list9);
            string list10 = list.Get("10");
            Console.WriteLine("10th index value: " + list10);
            string list11 = list.Get("11");
            Console.WriteLine("11th index value: " + list11);
            string list12 = list.Get("12");
            Console.WriteLine("12th index value: " + list12);
            string list13 = list.Get("13");
            Console.WriteLine("13th index value: " + list13);
            string list14 = list.Get("14");
            Console.WriteLine("14th index value: " + list14);
            string list15 = list.Get("15");
            Console.WriteLine("15th index value: " + list15);
            string list16 = list.Get("16");
            Console.WriteLine("16th index value: " + list16);

            list.Remove("17");
            string list17 = list.Get("17");
            Console.WriteLine("17th index value: " + list17);
            string list18 = list.Get("18");
            Console.WriteLine("18th index value: " + list18);
        }
    }
}

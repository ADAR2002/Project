namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            int size_of_array = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            string[] ele = s.Split(' ');
            List<int> arr = new List<int>();
            for (int i = 0; i < ele.Length; i++)
            {
                arr.Add(int.Parse(ele[i]));
            }
            int number_of_queries = int.Parse(Console.ReadLine());
            int l, r;
            string[] query;
            Segment_tree tree = new Segment_tree(arr, size_of_array);
            while(number_of_queries > 0)
            {
                number_of_queries--;
                s = Console.ReadLine();
                query = s.Split(' ');
                l = int.Parse(query[0]);
                r = int.Parse(query[1]);
                l--;
                r--;
                Console.WriteLine(tree.get_max(l, r));
            }


        }
    }
}

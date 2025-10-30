internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Stack<int> s1 = new Stack<int>();
        s1.Push(10);
        s1.Push(20);
        Console.WriteLine(s1.Count);
    }
    public int CalPoints(string[] operations)
    {
        // Stack<char> s1 = new Stack<char>;
        char[] array = new char[operations.Length];

        for (int i = 0; i < operations.Length; i++)
        {
            switch (operations[i])
            {
                case "+":
                    if (array.Length > 0)
                    {

                    }
                    break;
            }
        }

        return 0;
    }
}
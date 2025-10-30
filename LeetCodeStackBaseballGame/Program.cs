internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
    public int CalPoints(string[] operations)
    {
        // Stack<char> s1 = new Stack<char>;
        char[] array = new char[operations.Length];

        for (int i = 0; i < operations.Length; i++)
        {
            switch (operations[i])
            {
                case '+':
                    if (array.Length > 0)
                    {

                    }
            }
        }
    }
}
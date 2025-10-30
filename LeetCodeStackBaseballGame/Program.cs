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
        Stack<char> s1 = new Stack<char>();
        char[] array = new char[operations.Length];

        for (int i = 0; i < operations.Length; i++)
        {
            switch (operations[i])
            {
                case "+":
                    if (s1.Count > 1)
                    {
                        char l1 = s1.Peek();
                        s1.Pop();
                        char l2 = s1.Peek();
                        s1.Push(l1);
                        int sum = (l1 - '0') + (l2 - '0');
                        s1.Push((char)(sum + '0'));
                    }
                    break;
                case "D":
                    if (s1.Count > 0)
                    {
                        char last = s1.Peek();
                        int value = (last - '0') * 2;
                        s1.Push((char)(value + '0'));
                    }
                    break;
                case "C":
                    if (s1.Count > 0)
                    {
                        s1.Pop();
                    }
                    break;
                default:
                    char v = operations[i];
                    s1.Push((char)(v + '0'));
                    break;
            }
        }

    }
}
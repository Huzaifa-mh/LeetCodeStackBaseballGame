internal class Program
{
    private static void Main(string[] args)
    {
        string[] operations = { "5", "2", "C", "D", "+" };
        int result = CalPoints(operations);
        Console.WriteLine(result);
    }

    public static int CalPoints(string[] operations)
    {
        Stack<int> s1 = new Stack<int>();
        char[] array = new char[operations.Length];

        for (int i = 0; i < operations.Length; i++)
        {
            switch (operations[i])
            {
                case "+":
                    if (s1.Count > 1)
                    {
                        int l1 = s1.Peek();
                        s1.Pop();
                        int l2 = s1.Peek();
                        s1.Push(l1);
                        s1.Push(l1 + l2);
                    }
                    break;
                case "D":
                    if (s1.Count > 0)
                    {
                        int last = s1.Peek();
                        s1.Push(last * 2);
                    }
                    break;
                case "C":
                    if (s1.Count > 0)
                    {
                        s1.Pop();
                    }
                    break;
                default:
                    int value = int.Parse(operations[i]);
                    s1.Push(value);
                    break;
            }
        }

        return s1.Sum();
    }

}
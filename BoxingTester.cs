public static class BoxingTester
{
public static void Test()
{
    int a = 10;

    object b = a;
    // з heap дістається значення і копіюється у нову ділянку памяті Heap

    int c = (int)b;
    //значення дістається з Heap і копіюється у нову змінну в Stack

    Console.WriteLine($"a - int on Stack: {a}");
    Console.WriteLine($"b - object on Heap: {b}");
    Console.WriteLine($"c - int on Stack: {c}");

}
}
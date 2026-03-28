var container = new DataContainer<DataItem>();
for (int i = 0; i < 10000; i++)
{
var item = new DataItem
{
Id = $"item-{i}",
Payload = new byte[1024]
};

    container.AddItem(item);
}
Console.WriteLine($"Total size before GC: {container.GetTotalSize()} bytes");
GC.Collect();

Console.WriteLine("GC.Collect() was called.");
Console.WriteLine($"Total size after GC: {container.GetTotalSize()} bytes");
Console.WriteLine("Пояснення:всі обьєкти, що ми створили лежать у списку і тому розмір памяті не змінився, оскільки видалення відбувається за умови, що на обьєкти ніхто не посилається");
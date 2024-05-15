GetListInts().ToList().ForEach(Console.WriteLine);
Console.WriteLine("--------------------------------------");
GetYieldInts().ToList().ForEach(Console.WriteLine);

IEnumerable<int> GetListInts()
{
    List<int> ints = [];

    for (int i = 0; i < 5; i++)
    {
        ints.Add(i);
    }

    return ints;
}

IEnumerable<int> GetYieldInts()
{
    for (int i = 0; i < 5; i++)
    {
        yield return i;
    }
}
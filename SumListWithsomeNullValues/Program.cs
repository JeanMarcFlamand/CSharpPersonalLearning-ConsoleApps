List<int?> numberList = new();
numberList.Add(32);
numberList.Add(21);
numberList.Add(null);
numberList.Add(11);
numberList.Add(89);
int? result = 0;

foreach (var item in numberList)
{
    result += item.GetValueOrDefault();
}

Console.WriteLine($"without if statement Value is : {result}");

//Reset result
result = 0;

foreach (var item in numberList)
{
    if (item != null)
    {
        result += item.GetValueOrDefault() ;
    }
    
}

Console.WriteLine($"with if statement Value is : {result}");
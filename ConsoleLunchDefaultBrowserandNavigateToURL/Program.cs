// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

try
{
    string request = "https://www.google.com";
    System.Diagnostics.ProcessStartInfo ps = new System.Diagnostics.ProcessStartInfo
    {
        FileName = request,
        UseShellExecute = true
    };
    System.Diagnostics.Process.Start(ps);
}
catch (Exception err)
{
    Console.WriteLine(err.Message);
}
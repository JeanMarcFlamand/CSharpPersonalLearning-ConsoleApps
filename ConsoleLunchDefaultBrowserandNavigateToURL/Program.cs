// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//try
//{
//    string request = "https://www.google.com";
//    System.Diagnostics.ProcessStartInfo ps = new System.Diagnostics.ProcessStartInfo
//    {
//        FileName = request,
//        UseShellExecute = true
//    };
//    System.Diagnostics.Process.Start(ps);
//}
//catch (Exception err)
//{
//    Console.WriteLine(err.Message);
//}
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

IWebDriver driver = new ChromeDriver();
driver.Navigate().GoToUrl("https://www.google.ca/");
IWebElement element = driver.FindElement(By.Name("q"));
element.SendKeys("Jean-Marc Flamand");


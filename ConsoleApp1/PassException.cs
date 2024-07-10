namespace ConsoleApp1;

internal class PassException:Exception
{
    public string Message { get; set; }

    public PassException(string message) : base(message)
    {
        Console.WriteLine(message);
    }


}


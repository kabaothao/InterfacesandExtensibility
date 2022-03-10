// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

namespace InterfacesandExtensibility // Note: actual namespace depends on the project name.
{
    public interface ILogger
    {
        void LogError(string message);
        void LogInfo(string message);
    }
}




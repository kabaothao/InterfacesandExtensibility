namespace InterfacesandExtensibility
{
    public class FileLogger  : ILogger
    {
        private readonly string _path;   
        public FileLogger(string path)
        {
            _path = path;
        }

        public void LogError(string message)
        {
            Log(message, "ERROR");


        }

        public void LogInfo(string message)
        {
            Log(message, "INFO");


        }

        private void Log(string message, string messageType)
        {

            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine(messageType + ": " + message);

            }
        }
    }


}


/*
 Well it is possible by using extensibility which means instead of changing the code in the existing

classes simply add in new classes that change the behavior of the system.

With this way of thinking every time we want to change the behavior of our solver we create new classes


So the Logger technique you are using here is called dependency injection which means in the constructor

you are specifying the dependencies where it is DB migrator class and later in the main method 
.
 */
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesandExtensibility
{

    public class ConsoleLogger : ILogger
    {
        public void LogError(string message)
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
        }

        public  void LogInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
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
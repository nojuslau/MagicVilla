﻿namespace MagicVilla_VillaApi.Logging
{
    public class Logging : ILogging
    {
        public void Log(string message, string type) 
        {
            if (type == "error") 
            {
                Console.Error.WriteLine("ERROR - " + message);
            }
            else
            {
                Console.Error.WriteLine(message);
            }
        }
    }
}

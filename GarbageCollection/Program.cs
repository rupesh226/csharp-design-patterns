// See https://aka.ms/new-console-template for more information
using GarbageCollection;
using System;


    

        MyGarbageCollection.Run();

        Console.WriteLine("\nLeaving 'Run'...");

        GC.Collect();
        GC.WaitForPendingFinalizers();
  


//#define WE_BE_DEBUGIN // alternative in project properties-BUILD-CONDITIONAL Completion SYMBOLS- then copypaste WE_BE_DEBUGIN
using System;
using System.Diagnostics;

//ref link: https://www.youtube.com/watch?v=6KkIYL_WoqE&list=PLRwVmtr-pp05brRDYXh-OTAIi-9kYcw3r&index=11&t=1s
//

class MainClass
{
    static void Main()
    {
        TraceDebuggingStuff("We are debugging here");
    }
    [Conditional("WE_BE_DEBUGIN")] // product shipping must vaporize before shipping
    public static void TraceDebuggingStuff(string messageToTrace)
    {
        Console.WriteLine("Debugging: " + messageToTrace);
    }
}
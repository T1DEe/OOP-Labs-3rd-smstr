using System;

namespace OOP_Lab09
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var c = new Class(); 

            User Alex = new User();

            Alex.AddEvent += Class.Work;
            Alex.AddEvent += Class.Upgrade;
            Alex.a(5);
            Alex.a.Invoke(5);

            Alex.MessageEvent += (message) => Console.WriteLine(message);

            Alex.CallEvents(User.CALL_ADD_EVENT, 5);


            string str = "Hello! I sitting, doing this lab and don't understand what the fuck is going on in it. Sorry, Olga";
            Action<string> actionOnConsole = (s) => Console.WriteLine(s);
            actionOnConsole(str);

            Func<string, string> func = User.AddSymbols;
            actionOnConsole(str = func(str));
            func += User.ToUpperCase;
            actionOnConsole(str = func(str));

            func += User.AfterFirstWord;
            actionOnConsole(str = func(str));

            func += User.RemoveSpaces;
            actionOnConsole(str = func(str));

            func += User.RemoveCommasDotes;
            actionOnConsole(str = func(str));
        }
    }
}

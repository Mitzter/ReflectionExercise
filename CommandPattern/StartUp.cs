

namespace CommandPattern
{
    using CommandPattern.Core;
    using CommandPattern.Core.Contracts;
    using System;
    using IO;
    using IO.Contracts;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();

            ICommandInterpreter command = new CommandInterpreter();
            IEngine engine = new Engine(command, reader, writer);
            engine.Run();
        }
    }
}

using System;
using CommandSystem;
using Exiled.API.Features;

namespace ExamplePlugin.Commands
{
    [CommandHandler(typeof(ClientCommandHandler))]
    public class TestCommand : ICommand
    {
        public string Command { get; } = "test";

        public string[] Aliases { get; } = new[] { "t" };

        public string Description { get; } = "测试命令";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            Player player = Player.Get(sender);
            player.Broadcast(5, "Hello World!");

            response = $"{Command}指令执行完毕!";
            return true;
        }
    }
}
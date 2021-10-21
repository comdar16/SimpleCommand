using Microsoft.Xna.Framework;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Terraria;
using TerrariaApi.Server;
using TShockAPI;

namespace SimpleCommand
{
	[ApiVersion(2, 1)]

	public class SimpleCommand : TerrariaPlugin
	{
		public override string Name
		{
			get { return "SimpleCommand"; }
		}

		public override string Author
		{
			get { return "comdar"; }
		}

		public override string Description
		{
			get { return "Simple command plugin template!"; }
		}

        public string HelpText { get; private set; }

        public SimpleCommand(Main game)
			: base(game)
		{
			Order = +4;
		}

		public override void Initialize()
		{
			Commands.ChatCommands.Add(new Command("simple.command", hello, "hello"));
		}

		void hello(CommandArgs args)
		{
			args.Player.SendInfoMessage("Hello world", Color.Yellow);
		}
	}
}
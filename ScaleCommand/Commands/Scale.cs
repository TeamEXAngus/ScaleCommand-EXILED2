using System;
using System.Collections.Generic;
using Exiled.API.Features;
using CommandSystem;
using UnityEngine;
using Exiled.Permissions.Extensions;

namespace ScaleCommand.Commands
{
    //Command to set the class of a chosen player to a random SCP
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    public class SpawnRandSCP : ICommand
    {
        public string Command { get; } = "scale";

        public string[] Aliases { get; } = { };

        public string Description { get; } = "Scales the specified player";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            if (!(sender as CommandSender).CheckPermission("scale.scale"))
            {
                response = "You do not have permission to use ths command! Missing permission \"scale.scale\"";
                return false;
            }

            //Make sure that arguments exist
            if (arguments.Count != 4)
            {
                response = "Usage: scale <player> <x> <y> <z>";
                return false;
            }

            //Get the player and scale they should be set to and do data validation
            Player TargetPlayer = Player.Get(arguments.At(0)); Vector3 NewScale;
            if (TargetPlayer == null) { response = "You entered an invalid player name!"; return false; }
            try { NewScale = new Vector3(float.Parse(arguments.At(1)), float.Parse(arguments.At(2)), float.Parse(arguments.At(3))); }
            catch { response = "Something went wrong! Make sure you input numbers!"; return false; }

            TargetPlayer.Scale = NewScale;
            response = $"Success! {TargetPlayer.Nickname}'s scale was set to {NewScale}";
            return true;
        }
    }
}
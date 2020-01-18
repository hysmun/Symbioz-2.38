﻿using Symbioz.Auth.Transition;
using Symbioz.Core;
using Symbioz.Core.Commands;
using Symbioz.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Symbioz.Protocol.Selfmade.Messages;
using System.Threading.Tasks;
using System.Threading;
using Symbioz.Auth.Records;
using Symbioz.Network.Servers;
using Symbioz.Protocol.Selfmade.Enums;

namespace Symbioz.Auth
{
    class CommandsRepertory
    {
        static Logger logger = new Logger();

        [ConsoleCommand("infos")]
        public static void Infos(string input)
        {
            logger.White("Clients Connecteds: " + AuthServer.Instance.ClientsCount);
        }
        [ConsoleCommand("banip")]
        public static void BanIp(string input)
        {
            BanIpRecord record = new BanIpRecord(input);
            record.AddInstantElement();
        }

        [ConsoleCommand("create")]
        public static void CreateUser(string input)
        {
            string[] split = input.Split(' ');
            if (split.Length != 0)
            {
                AccountRecord account = null;

                if (split.Length == 2)
                {
                    account = new AccountRecord(split[0], split[1]);
                    account.Id = 6;
                    account.Banned = false;
                    account.CharacterSlots = 5;
                    account.Nickname = split[0];
                    account.Role = (sbyte) ServerRoleEnum.Player;
                }

                account?.AddInstantElement();
            }
        }
    }
}

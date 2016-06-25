﻿using NullObjectPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheInterface
{
    class Program
    {
        static IUserRepository userRepository = new UserRepository();

        static void Main(string[] args)
        {
            var user = userRepository.GetByID(Guid.NewGuid());
            user.IncrementSessionTicket();

            string userName;
            if(!user.IsNull)
            {
                userName = user.Name;
            }
            else
            {
                userName = "UNKNOW";
            }

            Console.WriteLine("The user's name is {0}", userName);
            Console.ReadKey();
        }
    }
}

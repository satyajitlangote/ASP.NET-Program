﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journal_4
{
    public partial class User
    {
        private String name;
        private String location;
        public User(String a, String b)
        {
            this.name = a;
            this.location = b;
        }
    }
    public partial class User
    {
        public void getUserDetails()
        {
            Console.WriteLine("\nName: " + name);
            Console.WriteLine("Location: " + location);
        }
    }
    class PartialClass
    {
        static void Main(String[] args)
        {
            Console.WriteLine("\nEnter name:");
            String name = Console.ReadLine();
            Console.WriteLine("\nEnter city:");
            String city = Console.ReadLine();
            User u = new User(name, city);
            u.getUserDetails();
            Console.ReadLine();
        }
    }
}
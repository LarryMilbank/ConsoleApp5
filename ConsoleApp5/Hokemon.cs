﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Hokemon_U
{
    class Hokemon
    {
        // MEMBERS - All Attributes, Methods and Properties are MEMBERS of this CLASS

        // VARIABLES a.k.a ATTRIBUTES inside a class can also be refered to as FIELDS
        private string name;
        private int health;
        private int max_health;
        private int attack;
        private int speed;
        private int defense;

        //Properties

        public string Name
        {
            get { return name; } // access to the name attribute
            set { name = value; }
        }

        public int Health
        {
            get { return health; } // access to the health attribute
            set { health = value; }
        }

        //Methods

        public Hokemon()   // CONSTRUCTOR method runs 1st when INSTANTIATED
        {
            provide_name();
            max_health = 100;
            health = Random_int_generator(10, max_health);
            attack = Random_int_generator(10, 100);
            speed = Random_int_generator(10, 100);
            defense = Random_int_generator(10, 100);

        }


        public void provide_name() // METHOD
        {
            Console.WriteLine("Enter a name for your Hokemon: ");
            name = Console.ReadLine();
        }


        public void get_details()
        {
            Console.WriteLine("\n\n*********\nName: {0}\n" +
                "Health: {1}/{2}\n" +
                "Attack value: {3}\n" +
                "Speed value: {4}\n" +
                "Defense: {5}", name, Health, max_health, attack, speed, defense);
        }


        public int Random_int_generator(int min_value, int max_value)
        {
            Random rnd = new Random();  // Creating a new OBJECT called rnd this is an
                                        // INSTANCE of RANDOM class

            int randomValue;

            randomValue = rnd.Next(min_value, max_value);   // Using the NEXT method from the RANDOM class found in rnd OBJECT

            return randomValue;
        }


        public void about()
        {
            Console.WriteLine("I am a mystical species known as Hokemon!!");
        }



    }
}

using System;
using System.Collections.Generic;

namespace Quest
{
    // An instance of the Adventurer class is an object that will undergo some challenges
    public class Adventurer
    {
        // This is an "immutable" property. It only has a "get".
        // The only place the Name can be set is in the Adventurer constructor
        // Note: the constructor is defined below.
        public string Name { get; }

        // This is a mutable property it has a "get" and a "set"
        //  So it can be read and changed by any code in the application
        public int Awesomeness { get; set; }

        // A constructor to make a new Adventurer object with a given name
        public Robe ColorfulRobe { get; } = new Robe();
        public Hat UserHat { get; } = new Hat();
        public Adventurer(string name, Robe robe, Hat hat)
        {
            Name = name;
            Awesomeness = 50;
            ColorfulRobe = robe;
            UserHat = hat;
        }


        // This method returns a string that describes the Adventurer's status
        // Note one way to describe what this method does is:
        //   it transforms the Awesomeness integer into a status string
        public string GetAdventurerStatus()
        {
            string status = "okay";
            if (Awesomeness >= 75)
            {
                status = "great";
            }
            else if (Awesomeness < 25 && Awesomeness >= 10)
            {
                status = "not so good";
            }
            else if (Awesomeness < 10 && Awesomeness > 0)
            {
                status = "barely hanging on";
            }
            else if (Awesomeness <= 0)
            {
                status = "not gonna make it";
            }

            return $"Adventurer, {Name}, is {status}";
        }

        public string GetDescription()
        {
            return $"{Name} is wearing a {ColorfulRobe.Length}-inch,  {string.Join(", ", ColorfulRobe.Colors)} robe and a hat with a shininess level of {UserHat.ShininessDescription(UserHat.ShininessLevel)}";
        }
    }
}
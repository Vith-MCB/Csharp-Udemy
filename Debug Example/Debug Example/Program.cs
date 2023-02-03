/*
 * CODE EXAMPLE
 * 
 using System.Collections.Generic;
namespace Debugging
{
    class Program
    {
        public static void Main(string[] args)
        {
            var friends = new List<string> { "Frank", "Joe", "Michelle", "Andy", "Maia", "Carlos", "Angelina"};
            var partyFriends = GetPartyFriends(friends, 3);

            foreach(var name in partyFriends)
            {
                Console.WriteLine(name);
            }
        }

        public static List<string> GetPartyFriends(List<string> list, int count)
        {
            var partyFriends = new List<string>();

            while(partyFriends.Count < count) 
            {
                var currentFriend = GetPartyFriend(list);
                partyFriends.Add(currentFriend);
                list.Remove(currentFriend);
            }
            return partyFriends;
        }

        public static string GetPartyFriend(List<string> list)
        {
            string shortestName = list[0];
            for(var i = 0; i< list.Count; i++)
            {
                if (list[i].Length > shortestName.Length)
                {
                    shortestName = list[i];
                }
            }
            return shortestName;
        }
    }
}
 */

/*
 * DEBUGGING COMMANDS
 * F9 - CREATE A NEW BREAK POINT
 * F10 - JUMP TO THE NEXT LINE
 * F11 - JUMP TO THE FUNCTION THAT IS BEING CALLED
 */

/*
 * FUNCTIONS AND TOOLS
 * AUTOS - SHOWS THE VARIABLES THAT WERE DEFINED BEFORE AND AT THE CURRENT LINE (VALUE, NAME, TYPE)
 * WATCH - ITEMS CAN BE ADDED AND IT WILL ME WATCHED
 * LOCALS - VARIABLES THAT ARE AVALIABLE AT THE CURRENT SCOPE
 */

using System.Collections.Generic;
namespace Debugging
{
    class Program
    {
        public static void Main(string[] args)
        {
            var friends = new List<string> { "Frank", "Joe", "Michelle", "Andy", "Maia", "Carlos", "Angelina" };
            var partyFriends = GetPartyFriends(friends, 3);

            foreach (var name in partyFriends)
            {
                Console.WriteLine(name);
            }
        }

        public static List<string> GetPartyFriends(List<string> list, int count)
        {
            var partyFriends = new List<string>();

            while (partyFriends.Count < count)
            {
                var currentFriend = GetPartyFriend(list);
                partyFriends.Add(currentFriend);
                list.Remove(currentFriend);
            }
            return partyFriends;
        }

        public static string GetPartyFriend(List<string> list)
        {
            string shortestName = list[0];
            for (var i = 0; i < list.Count; i++)
            {
                if (list[i].Length < shortestName.Length)
                {
                    shortestName = list[i];
                }
            }
            return shortestName;
        }
    }
}
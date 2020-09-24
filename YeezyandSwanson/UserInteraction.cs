using System;
using System.Collections.Generic;
using System.Text;

namespace YeezyandSwanson
{
    public class UserInteraction
    {
        public static void ConversationStarter()
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            
            Console.WriteLine($"Hi {name}, would you like to ask Kanye West a question? Please enter: Yes/No");
            var answer = Console.ReadLine().ToLower();
            if(answer == "yes" || answer == "y")
            {
                Console.WriteLine("Enter your question:");
                var userResp = Console.ReadLine();
                Console.WriteLine($"Hey Kanye, {name} has a question for you: {userResp}");
            }
            else
            {
                Console.WriteLine("Well what the hell are you here for then?!");
            }
        }
        public static void RonQuestion()
        {
            Console.WriteLine($"Would you like to ask Ron Swanson a question? Please enter: Yes/No");
            var answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "y")
            {
                Console.WriteLine("Enter your question:");
                var userResp = Console.ReadLine();
                Console.WriteLine($"Hey Ron, quick question for you: {userResp}");
            }
            else
            {
                Console.WriteLine("Well what the hell are you here for then?!");
            }
        }
    }
}

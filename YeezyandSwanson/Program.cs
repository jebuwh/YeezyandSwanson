using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace YeezyandSwanson
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInteraction.ConversationStarter();
            QuoteFactory.KanyeQuote();
            UserInteraction.RonQuestion();
            QuoteFactory.RonQuote();
        }
    }
}

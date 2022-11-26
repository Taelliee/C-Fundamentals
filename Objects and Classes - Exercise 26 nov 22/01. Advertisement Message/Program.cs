using System;
using System.Collections.Generic;

namespace _01._Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> phrases = new List<string>() { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product." };
            List<string> events = new List<string>() { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            List<string> authors = new List<string>() { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            List<string> cities = new List<string>() { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random rnd = new Random();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int rndPhrase = rnd.Next(0, phrases.Count);
                int rndEvent = rnd.Next(0, events.Count);
                int rndAuthor = rnd.Next(0, authors.Count);
                int rndCity = rnd.Next(0, cities.Count);

                Advertisement rndAd = new Advertisement(phrases[rndPhrase], events[rndEvent], authors[rndAuthor], cities[rndCity]);
                
                Console.WriteLine($"{rndAd.Phrase} {rndAd.Event} {rndAd.Author} – {rndAd.City}.");
            }
        }
    }
    class Advertisement
    {
        public Advertisement(string phrase, string @event, string author, string city)
        {
            Phrase = phrase;
            Event = @event;
            Author = author;
            City = city;
        }

        public string Phrase { get; set; }
        public string Event { get; set; }
        public string Author { get; set; }
        public string City { get; set; }
    }
}

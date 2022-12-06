using System;
using System.Collections.Generic;

namespace _03._Messages_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, User> dict = new Dictionary<string, User>();
            
            int numberOfAllMessages = int.Parse(Console.ReadLine());

            string input;
            while ((input = Console.ReadLine()) != "Statistics")
            {
                string[] info = input.Split("=", StringSplitOptions.RemoveEmptyEntries);

                string command = info[0];

                if (command == "Add")
                {
                    string user = info[1];
                    int sentMessages = int.Parse(info[2]);
                    int receivedMessages = int.Parse(info[3]);

                    if (!dict.ContainsKey(user))
                    {
                        dict.Add(user, new User(sentMessages, receivedMessages));
                    }
                }
                else if (command == "Message")
                {
                    string sender = info[1];
                    string receiver = info[2];

                    if (dict.ContainsKey(sender) && dict.ContainsKey(receiver))
                    {
                        dict[sender].SentMessages++;
                        dict[receiver].ReceivedMessages++;

                        if (dict[sender].SentMessages + dict[sender].ReceivedMessages >= numberOfAllMessages)
                        {
                            Console.WriteLine($"{sender} reached the capacity!");
                            dict.Remove(sender);
                        }
                        //check both the recieved and the sent
                        if (dict[receiver].ReceivedMessages + dict[receiver].SentMessages >= numberOfAllMessages)
                        {
                            Console.WriteLine($"{receiver} reached the capacity!");
                            dict.Remove(receiver);
                        }
                    }
                }
                else if (command == "Empty")
                {
                    string user = info[1];

                    if (user == "All")
                    {
                        dict.Clear();
                        continue;
                    }

                    if (!dict.ContainsKey(user))
                    {
                        continue;
                    }

                    dict.Remove(user);
                }
            }

            Console.WriteLine($"Users count: {dict.Count}");
            foreach (var (user, info) in dict)
            {
                Console.WriteLine($"{user} - {info.SentMessages + info.ReceivedMessages}");
            }
        }
    }
    class User
    {
        public User(int sentMessages, int receivedMessages)
        {
            SentMessages = sentMessages;
            ReceivedMessages = receivedMessages;
        }
        public int SentMessages { get; set; }
        public int ReceivedMessages { get; set; }
    }
}

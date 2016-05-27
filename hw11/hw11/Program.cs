using System;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Threading.Tasks;

namespace hw11
{
    class MainClass
    {
        /// <summary>
        /// The entry point of the program, where the program control starts and ends.
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
        public static void Main(string[] args)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("homework");
            var collection = database.GetCollection<PhoneBookRecord>("phonebook");

            Console.WriteLine("Welcome to the PhoneBook.NET");
            bool goOn = true;
            while (goOn)
            {
                Console.WriteLine("Choose an option");
                Console.WriteLine("0 - Exit");
                Console.WriteLine("1 - Add a record");
                Console.WriteLine("2 - Find a phone number by name");
                Console.WriteLine("3 - Find a name by phone number");
                uint choice;
                if (!UInt32.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Incorrect input");
                    return;
                }
                switch (choice)
                {
                    case 0:
                        goOn = false;
                        break;
                    case 1:
                        SaveRecord(collection).GetAwaiter().GetResult();
                        break;
                    case 2:
                        FindPhone(collection).GetAwaiter().GetResult();
                        break;
                    case 3:
                        FindName(collection).GetAwaiter().GetResult();
                        break;
                    default:
                        Console.WriteLine("Wrong input. Enter a number from 0 to 3.");
                        break;
                }
            }
        }

        /// <summary>
        /// Saves a record to database.
        /// </summary>
        /// <returns>The record.</returns>
        /// <param name="collection">Collection.</param>
        private static async Task SaveRecord(IMongoCollection<PhoneBookRecord> collection)
        {
            Console.WriteLine("Enter a name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter a phone:");
            string phone = Console.ReadLine();

            PhoneBookRecord record = new PhoneBookRecord(){ Name = name, Phone = phone };

            await collection.InsertOneAsync(record);
        }

        /// <summary>
        /// Finds phones in database using a name.
        /// </summary>
        /// <returns>The phone.</returns>
        /// <param name="collection">Collection.</param>
        private static async Task FindPhone(IMongoCollection<PhoneBookRecord> collection)
        {
            Console.WriteLine("Enter a name");
            string name = Console.ReadLine();
            var filter = Builders<PhoneBookRecord>.Filter.Eq("Name", name);
            var names = await collection.Find(filter).ToListAsync();
            foreach (var n in names)
            {
                Console.WriteLine(n.Phone);
            }

        }

        /// <summary>
        /// Finds names in database using a phone.
        /// </summary>
        /// <returns>The name.</returns>
        /// <param name="collection">Collection.</param>
        private static async Task FindName(IMongoCollection<PhoneBookRecord> collection)
        {
            Console.WriteLine("Enter a phone");
            string phone = Console.ReadLine();
            var filter = Builders<PhoneBookRecord>.Filter.Eq("Phone", phone);
            var phones = await collection.Find(filter).ToListAsync();
            foreach (var p in phones)
            {
                Console.WriteLine(p.Name);
            }
        }
    }
}

using System;
using NamespaceHashTable;

namespace hw2_3
{
    class Program
    {
        public static void Main(string[] args)
        {
            HashTable myHashTable;
            int hashTableSize;
            while (true)
            {
                Console.WriteLine("Enter a size of hash table");
                if (!int.TryParse(Console.ReadLine(), out hashTableSize))
                {
                    Console.WriteLine("Incorrect input. Enter a positive integer number");
                }
                else
                {
                    if (hashTableSize > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input. Enter a positive integer number");
                    }
                }	
            }
            int hashFunction;
            Console.WriteLine("Choose a hash function:");
            Console.WriteLine("1 - simple hash function");
            Console.WriteLine("2 - hash function Hash37");
            Console.WriteLine("3 - second simple hash function");
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out hashFunction))
                {
                    Console.WriteLine("Incorrect input. Enter a number from 1 to 3");
                }
                else
                {
                    break;
                }
            }	
            IHashFunction myHashFunction;
            switch (hashFunction)
            {
                case 1:
                    myHashFunction = new SimpleHashFunction();
                    break;
                case 2:
                    myHashFunction = new HashFunction37();
                    break;
                case 3:
                    myHashFunction = new SimpleHashFunction();
                    break;
                default:
                    myHashFunction = new AnotherSimpleHashFunction();
                    break;
            }

            myHashTable = new HashTable(hashTableSize, myHashFunction);

            bool goOn = true;
            while (goOn)
            {
                Console.WriteLine("Choose an action:");
                Console.WriteLine("1 - check if there is a specific element");
                Console.WriteLine("2 - add a new element");
                Console.WriteLine("3 - delete a specific element");
                Console.WriteLine("4 - exit the program");
                int choice = 0;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            CheckBeloning(myHashTable);
                            break;
                        case 2:
                            Add(myHashTable);
                            break;
                        case 3:
                            Delete(myHashTable);
                            break;
                        case 4:
                            goOn = false;
                            break;
                        default:
                            Console.WriteLine("Incorrect input. Please try again");
                            break;
                    }
                }
            }
        }

        private static void CheckBeloning(HashTable hashTable)
        {
            Console.WriteLine("Enter a string");
            if (hashTable.Exists(Console.ReadLine()))
            {
                Console.WriteLine("This elements exists in the hash table");
            }
            else
            {
                Console.WriteLine("This elements doesn't exist in the hash table");
            }
        }

        private static void Add(HashTable hashTable)
        {
            Console.WriteLine("Enter a string");
            hashTable.AddValue(Console.ReadLine());
            Console.WriteLine("Element is added");
        }

        private static void Delete(HashTable hashTable)
        {
            Console.WriteLine("Enter a string");
            if (hashTable.DeleteValue(Console.ReadLine()))
            {
                Console.WriteLine("Element is deleted");
            }
            else
            {
                Console.WriteLine("There's no such element");
            }
        }
    }
}

using System;

namespace List
{
	class MainClass
	{
        /// <summary>
        /// The entry point of the program, where the program control starts and ends.
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
		public static void Main(string[] args)
		{
		    UniqueList ulist = new UniqueList();
            ulist.AddElement(6);
            try
            {
                ulist.AddElement(6);           
            }
            catch(RepeatedValueException)
            {
                Console.WriteLine("Error 1");
            }

            try
            {
                ulist.DeleteElement(8);
            }
            catch(NonexistentElementException)
            {
                Console.WriteLine("Error 2");
            }

            ulist.DeleteElement(6);

            try
            {
                ulist.DeleteElement(8);
            }
            catch(EmptyListException)
            {
                Console.Write("Error 3");
            }
		}
	}
}

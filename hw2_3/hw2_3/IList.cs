namespace NamespaceIList
{
	interface IList
	{

		// adds new element to the list
		void addElement(string element);

		// returns true if the list is empty
		bool isEmpty();

		// returns true if element is deleted, otherwise it's not in the list
		bool deleteElement(string element);

		// returns true if there is the given element in the list, and false if there is no
		bool isIn(string element);
	}
}


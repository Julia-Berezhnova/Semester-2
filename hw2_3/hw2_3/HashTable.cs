using NamespaceList;

namespace NamespaceHashTable
{
    /// <summary>
    /// Hash table.
    /// </summary>
    class HashTable: IHashTable
    {
        private const int arraySize = 100;
        private List[] array = new List[arraySize];

        public HashTable()
        {
            for (int i = 0; i < arraySize; ++i)
            {
                this.array[i] = new List();
            }
        }

        private int HashFunction(string element)
        {
            int result = 0;
            for (int i = 0; i < element.Length; ++i)
            {
                result = result + element[i] - 'a' + 1;
            }
            return result / arraySize;
        }

        public void AddValue(string element)
        {
            this.array[HashFunction(element)].AddElement(element);
        }

        public bool DeleteValue(string element)
        {
            return this.array[HashFunction(element)].DeleteElement(element);
        }

        public bool Exists(string element)
        {
            return this.array[HashFunction(element)].IsIn(element);
        }

    }
}


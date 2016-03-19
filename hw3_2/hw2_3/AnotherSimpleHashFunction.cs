namespace NamespaceHashTable
{
    /// <summary>
    /// Hash function.
    /// </summary>
    public class AnotherSimpleHashFunction: IHashFunction
    {
        public int Hash(int size, string element)
        {
            int result = 0;
            for (int i = 0; i < element.Length; ++i)
            {
                result = result + element[i];
                result = result % size;
            }
            return result;
        }
    }
}


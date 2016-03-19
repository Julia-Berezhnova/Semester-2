namespace NamespaceHashTable
{
    /// <summary>
    /// Hash function.
    /// </summary>
    public class HashFunction37: IHashFunction
    {
        public int Hash(int size, string element)
        {
            int simpleNumber = 37;
            int pows = 37;
            int result = element[0] * pows;
            pows = pows * simpleNumber;
            if (element.Length > 1)
            {
                result = result + element[1] * pows;
                pows = pows * simpleNumber;
            }
            if (element.Length > 2)
            {
                result = result + element[2] * pows;
                pows = pows * simpleNumber;
            }
            return result % size;
        }
    }
}


namespace NamespaceHashTable
{
	public class SimpleHashFunction: IHashFunction
	{
		public int Hash(int size, string element)
		{
			int result = element [0] - 'a' + 1;
			if (element.Length > 1)
			{
				result = result + element [1] - 'a' + 1;
			}
			if (element.Length > 2) 
			{
					result = result + element [2] - 'a' + 1;
			}
			return result % size;
		}
	}
}


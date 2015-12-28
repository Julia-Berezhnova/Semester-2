#include <iostream>
#include <fstream>
#include <string>

using namespace std;

/// function fullfills prefix array
void prefixFunction(string someString, int prefix[])
{
	prefix[0] = 0;
	for (int i = 1; i < someString.length(); ++i)
	{
		int j = prefix[i - 1];
		while (j > 0 && someString[j] != someString[i])
		{
			j = prefix[j - 1];
		}
		if (someString[i] == someString[j])
		{
			++j;
		}
		prefix[i] = j;
	}
}

int main()
{
	ifstream file("input.txt");
	if (!file.is_open())
	{
		cout << "File not found" << endl;
		return 1;
	}
	string text = {};
	while (!file.eof())
	{
		file >> text;
	}
	file.close();
	cout << "Enter a string to find in the text: " << endl;
	string pattern = {};
	cin >> pattern;
	if (text.length() < pattern.length() || text.length() == 0)
	{
		cout << "Incorrect input" << endl;
		return 1;
	}
	const int size = 100;
	int* prefix = new int[size];
	prefixFunction(pattern + text, prefix);
	for (int i = 0; i < (pattern + text).length(); ++i)
	{
		if (prefix[i] == pattern.length())
		{
			cout << "First entry of pattern in the text: " << i - 2 * pattern.length() + 2 << endl;
			delete[] prefix;
			return 0;
		}
	}
	cout << "Pattern is not found" << endl;
	delete[] prefix;
	return 1;
}

/// test 1
/// input
/// text: kokolokoljk
/// pattern: kol
/// output
/// 3

/// test 2
/// input
/// text: dontknowwhattosay
/// pattern: m
/// output
/// Pattern is not found

/// test 3
/// input
/// text: happy
/// pattern: newyear
/// output
/// Incorrect input

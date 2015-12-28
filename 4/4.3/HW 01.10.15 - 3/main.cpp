#include <fstream>
#include <iostream>
#include <string>
#include <locale.h>

using namespace std;

int main()
{
	setlocale(LC_ALL, "RUS");
	ifstream file("text.txt", ios::in);
	if (!file.is_open())
	{
		cout << "not found" << endl;
		return 1;
	}

	int emptyLines = 0;
	while (!file.eof())
	{
		string buffer;
		getline(file, buffer);
		bool isEmpty = true;
		for (int i = 0; i < buffer.size(); ++i)
		{
			if ((buffer[i] == ' ' || buffer[i] == '\t' || buffer[i] == '\n') && isEmpty)
				isEmpty = true;
			else
				isEmpty = false;
		}
		if (isEmpty)
			emptyLines++;
	}
	file.close();
	cout << emptyLines << endl;
	return 0;
}
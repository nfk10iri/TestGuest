// c_plus_plus.cpp : Defines the entry point for the console application.
//

#include <stdafx.h>
#include <iostream>
using namespace std;

class my_obj{
	public:
		int return_value(int x, int y){
			return x*y;
		}
};

int main()
{
	int val = 0;
	my_obj obj;
	val = obj.return_value(10,20);
	int pause = 0;

	cout<<val;
	cin>>pause;
	return 0;
}


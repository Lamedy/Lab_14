#include <iostream>
#include <vector>
using namespace std;

class one {
public:
	virtual void print() = 0;
};

class two : public one {
public:
	int x;
	two() { x = 0; }
	two(int a) { x = a; }

	void print() override {
		cout << "X = " << x << endl;
	};
};
class three : public one {
public:
	int x;
	int y;
	three() { x = 0; y = 0; }
	three(int a, int b) { x = a; y = b; }
	void print() override {
		cout << "X = " << x << "\tY = " << y << endl;
	}
};

int main()
{
	vector<one*> arr;
	two *a = new two(1);
	three *b = new three(2,3);
	arr.push_back(a);
	arr.push_back(b);
	arr[0]->print();
	arr[1]->print();
}

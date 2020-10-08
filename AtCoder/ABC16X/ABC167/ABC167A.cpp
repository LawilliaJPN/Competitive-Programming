#include <iostream>
using namespace std;

int main() {
	string s, t;
	cin >> s >> t;

	bool canRegistrate = (s == t.substr(0, s.size()));

	string answer = canRegistrate ? "Yes" : "No";
	cout << answer << endl;
}
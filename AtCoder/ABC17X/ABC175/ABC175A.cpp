#include <algorithm>
#include <iostream>
using namespace std;

int main() {
    string s;
    cin >> s;

    if (s == "RSR") cout << 1;
    else cout << count(s.begin(), s.end(), 'R');
}
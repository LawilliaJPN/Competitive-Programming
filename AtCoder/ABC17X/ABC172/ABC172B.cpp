#include <iostream>
using namespace std;

int main() {
    string s, t;
    cin >> s >> t;

    int count = 0;
    for (auto i = 0; i < s.size(); i++) if (s[i] != t[i]) count++;
    cout << count;
}
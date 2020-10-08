#include <iostream>
#include <map>
using namespace std;

int main() {
    int n;
    cin >> n;

    string keys[4] = {"AC", "WA", "TLE", "RE"};
    map<string, int> c {
        {keys[0], 0},
        {keys[1], 0},
        {keys[2], 0},
        {keys[3], 0},
    };

    for (auto i = 0; i < n; i++) {
        string s;
        cin >> s;

        c[s]++;
    }

    for (auto key: keys) {
        cout << key << " x " << c[key] << endl;
    }
}
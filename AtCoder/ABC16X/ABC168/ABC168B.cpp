#include <iostream>
using namespace std;

int main() {
    int k;
    string s;
    cin >> k >> s;

    string answer = (s.size() <= k) ? s : s.substr(0, k) + "...";
    cout << answer;
}
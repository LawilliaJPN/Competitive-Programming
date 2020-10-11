#include <iostream>
using namespace std;

int main() {
    string s;
    cin >> s;

    string answer = (s.back() == 's') ? (s + "es") : (s + "s");
    cout << answer;
}
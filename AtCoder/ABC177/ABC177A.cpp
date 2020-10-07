#include <iostream>
using namespace std;

int main() {
    float d, t, s;
    cin >> d >> t >> s;

    string answer = (d / s <= t) ? "Yes" : "No";
    cout << answer;
}
#include <iostream>
using namespace std;

int main() {
    int x, y;
    cin >> x >> y;

    bool exist = false;
    for (auto cranes = 0; cranes <= x; cranes++) {
        int turtles = x - cranes;
        int legs = 2 * cranes + 4 * turtles;

        if (legs == y) exist = true;
    }

    string answer = exist ? "Yes" : "No";
    cout << answer;
}
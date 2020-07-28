#include <iostream>
using namespace std;

int main() {
    char alpha;
    cin >> alpha;

    char answer = (alpha < 'a') ? 'A' : 'a';
    cout << answer;
}
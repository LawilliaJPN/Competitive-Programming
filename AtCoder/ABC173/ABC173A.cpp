#include <iostream>
using namespace std;

int main() {
    int n;
    cin >> n;

    int answer = (n % 1000 == 0) ? 0 : (1000 - (n % 1000));
    cout << answer;
}
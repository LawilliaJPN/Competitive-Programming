#include <algorithm>
#include <iostream>
using namespace std;

int main() {
    int n;
    cin >> n;

    long long a[n];
    for (auto i = 0; i < n; i++) {
        cin >> a[i];
    }

    sort(a, a + n);
    if (a[0] == 0) {
        cout << "0";
        return 0;
    }

    long long product = 1;
    for (auto elem: a) {
        if (elem > 1000000000000000000ULL / product) {
            cout << "-1";
            return 0;
        }
        product *= elem;
    }

    cout << product;
}
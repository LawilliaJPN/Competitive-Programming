#include <algorithm>
#include <iostream>
#include <numeric>
using namespace std;

int main() {
    int n, k;
    cin >> n >> k;

    int p[n];
    for (auto i = 0; i < n; i++) cin >> p[i];
    sort(p, p + n);

    cout << accumulate(p, p + k, 0);
}
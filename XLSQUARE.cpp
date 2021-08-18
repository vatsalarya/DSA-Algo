#include <bits/stdc++.h>
using namespace std;

int main(){
    int t;
    cin >> t;
    double N, A;
    while(t--){
        cin >> N >> A;
        long long area;
        area = A*A*N;
        int ans = int(sqrt(area));
        ans = ans/A;
        ans = ans * A;
        cout << ans << endl;
    }
}
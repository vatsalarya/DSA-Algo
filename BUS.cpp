#include <bits/stdc++.h>
using namespace std;

int main(){
    int t ,N, M, Q, limit;
    cin >> t;
    while(t--){
        limit = 0;
        string ans = "Consistent";
        cin >> N >> M >> Q;
        vector <int> bus(N,0);
        while(Q--){
            char ch;
            int i;
            cin >> ch >> i;
            i--;
            if(ch == '+'){
                if(bus[i] == 0){
                    bus[i] = 1;
                    limit++;
                }
                else{
                    ans = "Inconsistent";
                }
            }
            else{
                if(bus[i] == 1){
                    bus[i] = 0;
                    limit--;
                }
                else{
                    ans = "Inconsistent";
                }
            }
            if(limit > M){
                ans = "Inconsistent";
            }
        }
        cout << ans << endl;
    }
}
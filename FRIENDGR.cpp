// #include <bits/stdc++.h>
// using namespace std;

// int main(){
//     long long t ,N, K;
//     string S;
//     cin >> t;

//     while(t--){
//         cin >> N >> K >> S;
//         for(int i=0; i<N; i++){
//             bool isThere = false;
//             if(S[i+1] == 0){
//                 for(int j=1; j<=K+2; K++){
//                     if(S[i+j] == 1){
//                         isThere = true;
//                         break;
//                     }
//                 }
//             }
//             if(isThere == true){
//                 S[i] = 0;
//                 S[i+1] = 1;
//                 i = i+2;
//             }
//         }
//     }
// }


#include <bits/stdc++.h>
using namespace std;

int main(){
    long long t ,N, K, temp, solun;
    string S;
    cin >> t;
    while(t--){
    vector<int> ans(0);
        cin >> N >> K;
        cin >> S;
        solun = 0;
        for(int i=1; i<N; i++){
            temp = 0;
            if(S[i] == '1'){
                while(i<N && S[i+1] == '0'){
                    i++;
                    temp++;
                }
                if(temp - 1 <= K)
                   solun ++;
            }
        }
        if(S[0] == '1')
            solun--;
        if(S[N-1] == '1')
            solun--;
        cout << solun <<endl;
    }
}
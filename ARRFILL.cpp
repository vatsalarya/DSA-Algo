// You are given an array A of size N. Initially, the array is filled with 0-s.

// There are M types of operations that you can perform on array A. The ith operation can be described by two integers (xi,yi). In this operation, you choose a set of indices S such that

// 1≤j≤N,
// (jmodyi)≠0,
// Aj=0,
// , then you set Aj=xi for all j∈S.

// You can perform the operations in any order, but one type of operation can't be done more than once. What is the maximum sum of integers of the array A you obtain if you perform the M operations optimally?

// For example, consider the array A=[0,0,0,0].

// Suppose x=3,y=2. Here you can choose indices 1 and 3 and set A1=A3=3. So the array A becomes [3,0,3,0]. In this operation you can't choose the indices 2 and 4 because (2mod2)=0, (4mod2)=0.

// Suppose x=5,y=3 and you set A2=5. So the array A becomes [3,5,3,0]. Here you can't choose index 1 because A1>0 and index 3 because (3mod3)=0 and A3>0. However, you could also set A4=5.

// Suppose x=4,y=4. Now you can't choose any index because Aj>0 for all 1≤j≤3 and (4mod4)=0. So the array remains same.

// Note: Since input-output is large, prefer using fast input-output methods.

// Input Format
// The first line of the input contains a single integer T denoting the number of test cases. The description of T test cases follows.
// Each testcase contains M+1 lines of input.
// The first line of each test case contains two space-separated integers N,M.
// M lines follow. For each valid i, the ith of these lines contains two space-separated integers xi,yi - parameters of the ith operation.
// Output Format
// For each test case, output in a single line the maximum sum of integers of the array A after M operations.

// Constraints
// 1≤T≤12600
// 1≤N≤109
// 1≤M≤105
// 1≤xi≤109
// 2≤yi≤109
// The sum of M over all test cases does not exceed 106.
// Subtasks
// Subtask #1 (100 points): original constraints

// Sample Input 1 
// 3
// 10 1
// 5 2
// 8 2
// 5 2
// 6 3
// 3 2
// 2 2
// 1 3
// Sample Output 1 
// 25
// 41
// 5
// Explanation
// Test case 1: Optimal filling is [5,0,5,0,5,0,5,0,5,0].

// Test case 2: Optimal filling is [6,6,5,6,6,0,6,6].

// Test case 3: Optimal filling is [2,1,2].

#include <bits/stdc++.h>
using namespace std;

#define ll  long long

bool compare(pair<int, int> x, pair<int, int> y){
   if (x.first != y.first)
      return x.first > y.first;
   else
      return x.second > y.second;
}

int main(){
    long long t, M, N, x, y;
    cin >> t;

    while(t--){
        cin >> N >> M;
        vector< pair <long long,long long> > vect(M);
        for(long long i=0; i<M; i++){
            cin >> x >> y;
            vect.push_back(make_pair(x, y));
        }
        sort(vect.begin(), vect.end(), compare);
        ll k = 1, p = N, ans = 0;

        for (int i = 0; i < M && N > 0; ++i){
            ll f = vect[i].first;
            ll s = vect[i].second;
            k = (k * s) / (__gcd(k, s));
            ans += f * (N - p / k);
            N = p / k;
        }
        cout << ans << endl;
    }
}
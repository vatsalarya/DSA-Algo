// You are given an array of N integers. Find the minimum number of integers you need to delete from the array such that the absolute difference between each pair of integers in the remaining array will become equal.

// Input Format
// The first line of input contains a single integer T denoting the number of test cases. The description of T test cases follows.
// The first line of each test case contains an integer N.
// The second line of each test case contains N space-separated integers A1,A2,…,AN.
// Output Format
// For each test case, print a single line containing one integer - the minimum number of integers to be deleted to satisfy the given condition.

// Constraints
// 1≤T≤104
// 1≤N≤105
// 1≤Ai≤109
// Sum of N over all test cases does not exceed 5⋅105.
// Sample Input 1 
// 3
// 2
// 1 2
// 5
// 2 5 1 2 2
// 4
// 1 2 1 2
// Sample Output 1 
// 0
// 2
// 2
// Explanation
// Test case 1: There is only one pair of integers and the absolute difference between them is |A1−A2|=|1−2|=1. So there is no need to delete any integer from the given array.

// Test case 2: If the integers 1 and 5 are deleted, the array A becomes [2,2,2] and the absolute difference between each pair of integers is 0. There is no possible way to delete less than two integers to satisfy the given condition.


#include<bits/stdc++.h>
using namespace std;
int main(){
    int t,n,big,ans,x;
    cin>>t;
    while(t--){
        cin>>n;
        big=0;
        ans=0;
        map<int ,int> mp;
        for(int i=0;i<n;i++){
            cin>>x;
            mp[x]++;
            big=max(big,mp[x]);
        }
        if(n>2){
            if(big == 1)
                ans=n-2;
            else 
                ans = n-big;
        }
        cout << ans << endl;
    }
    return 0;
}
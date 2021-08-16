int main(){
    int t, team1, team2, input;
    cin >> t;

    while(t--){
        team1 = 0;
        team2 = 0;
        for(int i=1; i<11; i++){
            cin >> input;
            if(input%2 == 0){
                team1++;
            }
            else
                team2++;
        }
        if(team1 > team2)
            cout << 1 << endl;
        else if(team1 < team2)
            cout << 2 << endl;
        else
            cout << 0 << endl;
    }
}
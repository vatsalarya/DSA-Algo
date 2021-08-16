# cook your dish here

t = int(input())
for i in range(t):
    N, M, X = [int(x) for x in input().split()]
    distance = {}
    my_lis = [int(x) for x in input().split()]
    for j in range(N):
        distance[j] = my_lis[j]
    # distance = sorted (distance.keys())
    distance = sorted(distance.items(), key=lambda x: x[1], reverse=True)
    lis = distance.values()
    play = 0
    while True:
        if lis[play] >= M:
            play = play+ 1
        else:
            break
    if play < X:
        play = X
    print(X, end =" ")
    final = distance.keys()
    for sol in range(play):
        print(final[sol], end =" ")
    print()
    
h = int(input().split()[0])
a = [int(s) for s in input().split()]

answer = "Yes" if sum(a) >= h else "No"
print(answer)

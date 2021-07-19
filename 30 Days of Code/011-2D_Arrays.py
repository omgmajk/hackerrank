def max_hourglass(arr):
    max_sum = -10000
    for i in range(0, 4):
        for j in range(0, 4):
            current_sum = (arr[i][j] + arr[i][j + 1] + arr[i][j + 2]) + (arr[i + 1][j + 1]) + (arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2])

            if(current_sum > max_sum):
                max_sum = current_sum
            else:
                continue
    return max_sum

arr = []

for _ in range(6):
    arr.append(list(map(int, input().rstrip().split())))

print(max_hourglass(arr))

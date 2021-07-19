n = int(input())
phoneList = [input().split() for x in range(n)]
phoneBook = {k: v for k, v in phoneList}

while(1):
    try:
        name = input()
        if name in phoneBook:
            print(f"{name}={phoneBook[name]}")
        else:
            print("Not found")
    except EOFError:
        break

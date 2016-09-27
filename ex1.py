for i in range(1,10):
    for x in range(1,10-i):
        print("0", end='')
    for y in range(1,i+1):
        print(i, end='')
    print('')

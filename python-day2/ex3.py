import math
a=input('Enter 10 digit number: ')
x=[int(x) for x in a]
for i in range(10):
    if x[i] % 2==1:
        print(x[i],end=' ')
print('\n', end=' ')
for i in range(10):
    if x[i] % 2==0:
        print(x[i],end=' ')

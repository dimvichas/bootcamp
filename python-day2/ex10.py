import math
a=list(input('Enter binary sequence: '))
if a.count(1)> a.count(0):
    print('Longest run was ones with length: ',a.count(1))
elif a.count(1)< a.count(0):
    print('Longest run was zeros with length: ',a.count(0))
else:
    print('Equal longest run of ones and zeros with length: ',a.count(1))

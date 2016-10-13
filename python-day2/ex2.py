a=input('Enter binary number: ')
x=[int(x) for x in a[:7]]
#print(x)
y=int(a[7])
#print(y)
for i in range (len(x)):
    sum=x.count(1)
#print(sum)
if sum%2==0 and y==0:
    print('Parity check OK.')
elif sum%2==1 and y==1:
    print('Parity check OK.')
elif sum%2==0 and y==1:
    print('Parity check not OK.')
elif sum%2==1 and y==0:
    print('Parity check not OK.')

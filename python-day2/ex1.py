import math
a=(input("Enter Tax Identification Number: "))
x=[int(x) for x in a[:8]]
x.reverse()
y=int(a[8])
sum=0
#print(x)
#print(type(y))
for i in range (len(x)):
    sum=sum+x[i]*(2**(i+1))
    #print(sum)
h=sum%11
if h==y:
    print('Tax Identification Number valid')
else:
    print('Tax Identification Number not valid')

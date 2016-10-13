import math
for y in range(1900,2100):
    y=int(input("Enter year: "))
    a=y%4
    b=y%7
    c=y%19
    d=((19*c)+15)%30
    e=((2*a)+(4*b)-d+34)%7
    day=((d+e+114)%31)+1
    month=((d+e+114)//31)
    D=day+13
    if D>30:
        month+=1
        D=D-30
    print('Day: ',D,' ','Month: ',month)

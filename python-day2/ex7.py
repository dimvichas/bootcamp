import math
a=input('Enter date: ')
x=a.split('/')
d1=(int(x[0]))
m1=(int(x[1]))
y1=(int(x[2]))
b=input('Enter date: ')
y=b.split('/')
d2=(int(y[0]))
m2=(int(y[1]))
y2=(int(y[2]))
c1=(365*y1)+(y1//4)-(y1//100)+(y1//400)+(((306*m1)+5)//10)+(d1-1)
c2=(365*y2)+(y2//4)-(y2//100)+(y2//400)+(((306*m2)+5)//10)+(d2-1)
if c1>c2:
    print(c1-c2, 'days')
else:
    print(c2-c1, 'days')

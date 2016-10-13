import math
a=int(input("Give value for a "))
b=int(input("Give value for b "))
c=int(input("Give value for c "))
i=b**2-4*a*c
if i>0:
    x1=((-b)+ math.sqrt(i))/(2*a)
    x2=((-b)- math.sqrt(i))/(2*a)
    print(x1)
    print(x2)
else :
    print("No real-valued solutions exist")
 



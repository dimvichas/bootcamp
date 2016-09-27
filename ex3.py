import math
a=int(input("Give side A "))
b=int(input("Give side B "))
c=int(input("Give side C "))
x=1/4*math.sqrt((a+b+c)*(-a+b+c)*(a-b+c)*(a+b-c))
print(x)
    

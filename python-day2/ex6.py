a=list(input('Enter numbers: ').split(' '))
b=a[0::3]
c=a[1::3]
d=a[2::3]
print('{:>8} {:>8} {:>8}'.format(*b))
print('{:>8} {:>8} {:>8}'.format(*c))
print('{:>8} {:>8} {:>8}'.format(*d))

print("Hi Digvijay!")
print('\n\n')
# this is traditional if else condition
a, b = 3, 4
if a < b:
    print('{} is '
          'less'
          ' than {}'
          .format(a, b))
else:
    print('{} is less than {}'.format(b, a))

print('\n\n')
# This is if else condition where if-else part should be write at same place
print(
    '{} is less than {}'.format(a,b)
    if a<b
    else
    "Something"
)
print('\n\n')

# This is for while loop
a,b=0,1
print("This is fibonacci series : ")
while b<100:
    print(b,end=" ")
    a,b=b,a+b
print('\n\n')

# This is for for-loop
stri='Digviajay'
for letter in stri:
    if not(stri[-1]==letter):
        print(letter, end='+')
    else:
        print(letter)
print('\n\n')

def even(max=0):
    n=0
    while n<max:
        yield 2**n
        n+=1
print(sum(even(6)))

for m in even(8):
    print(m)
print("Total sum with help of Generator  "+str(sum(x for x in range(2,4,1))))
#print("Print sum : " + ','.join(str(sum(x+2)) for x in range(2,4,1)))





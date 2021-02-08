def is_prime(num):
    if num==1:
        print("special number .")
        return False
    for n in range(2,num,1):
        if num%n==0:
            print(" {} is not Prime number  {} * {}".format(num,num,n))
            return
    else:
        print("{} prime number.".format(num))

for nn in range(1,23,1):
    is_prime(nn)
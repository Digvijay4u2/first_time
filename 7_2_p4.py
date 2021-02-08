
try:
    fh= open('xline.txt')

    for l in fh.readlines():
        print(l)

except IOError as e:
    print("File is not found {}.".format(e))

def fun():
    print("hu")

fun()




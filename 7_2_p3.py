class Animal:
    min = 34

    def speed(self): return self.fun1['speed']

    def sound(self): return self.fun1['sound']

    fun1 = dict(
        speed="Generally Animals are faster than human",
        sound="Generally they make lots of noise also"
    )


class Dog(Animal):
    fun1 = dict(
        speed="Fast as compare to human",
        sound="can make more sound than human"
    )


class Duck(Animal):
    fast=40

    fun1 = dict(
        speed="Slower than human",
        sound="can make higher than human but generally low . "
    )


duckObject = Duck()
dogObject = Dog()
print(dogObject.speed() + " " + str(dogObject.min))
animaObject = Animal()
print(animaObject.speed())

for object in (dogObject,duckObject,animaObject):
    print(object.speed())

def main():
    cat=Animal("Pet animal")
    fish=Animal()
    print("cat is of category  " +  cat.whatkind()+ " "+"\nfish is of category " + fish.whatkind())


class Animal:
    def __init__(self,kind="Amphibian"):
        self.kind=kind

    def whatkind(self):
        return self.kind

if __name__ == "__main__":main()

print("outside")
import numpy as np
print(numpy.__version__)


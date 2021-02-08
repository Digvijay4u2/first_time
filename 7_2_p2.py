
class Fibonacci(num=0):
    def __init__(self, a, b):
        self.a = a
        self.b = b

    def series(self):
        while True and self.b < 50:
            yield self.b
            self.a.self.b = self.b, self.a + self.b


f = Fibonacci(2, 4)
for num in f.series():
    print(num, end=" -> ")

file = open("Numerot.txt", "r")
sum = 0

for line in file:
    number = float(line)
    sum += number

print("\nSumma: ", round(sum, 2))

file.close()

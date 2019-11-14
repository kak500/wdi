a = int(input("Podaj a: "))
if a < 0:
    zbior = "ujemne"
elif a in range(0, 9):
    zbior = "jednocyfrowe dodatnie"
elif a in range(10, 99):
    zbior = "dwucyfrowe dodatnie"
else:
    zbior = "pozostale"
print(zbior)
message = input("Enter message you want to decript: ")
translated = ""

i = len(message) - 1
while i >= 0:
    translated = translated + message[i]
    i = i - 1

print("The encrypted message is: " + translated)

def kalkulator():
    print("\n--- Prosty kalkulator ---")

    liczba1 = float(input("Podaj pierwszą liczbę: "))
    liczba2 = float(input("Podaj drugą liczbę: "))
    operacja = input("Wybierz operację (+, -, *, /): ")

    if operacja == "+":
        wynik = liczba1 + liczba2
        print("Wynik:", wynik)
    elif operacja == "-":
        wynik = liczba1 - liczba2
        print("Wynik:", wynik)
    elif operacja == "*":
        wynik = liczba1 * liczba2
        print("Wynik:", wynik)
    elif operacja == "/":
        if liczba2 != 0:
            wynik = liczba1 / liczba2
            print("Wynik:", wynik)
        else:
            print("Nie można dzielić przez zero.")
    else:
        print("Nieznana operacja.")


def konwerter_temperatur():
    print("\n--- Konwerter temperatur ---")

    wybor = input("Wybierz kierunek konwersji (C - Celsius na Fahrenheit, F - Fahrenheit na Celsius): ")
    temperatura = float(input("Podaj temperaturę: "))

    if wybor == "C" or wybor == "c":
        wynik = temperatura * 1.8 + 32
        print(f"{temperatura}°C = {wynik}°F")
    elif wybor == "F" or wybor == "f":
        wynik = (temperatura - 32) / 1.8
        print(f"{temperatura}°F = {wynik:.2f}°C")
    else:
        print("Nieznany wybór.")


def srednia_ocen():
    print("\n--- Średnia ocen ucznia ---")

    liczba_ocen = int(input("Podaj liczbę ocen: "))
    suma = 0

    for i in range(liczba_ocen):
        ocena = float(input(f"Podaj ocenę {i + 1}: "))
        suma = suma + ocena

    srednia = suma / liczba_ocen

    print(f"Średnia: {srednia:.2f}")

    if srednia >= 3.0:
        print("Uczeń zdał.")
    else:
        print("Uczeń nie zdał.")


def main():
    while True:
        print("\n=== MENU ===")
        print("1. Prosty kalkulator")
        print("2. Konwerter temperatur")
        print("3. Średnia ocen ucznia")
        print("0. Zakończ")

        wybor = input("Wybierz zadanie: ")

        if wybor == "1":
            kalkulator()
        elif wybor == "2":
            konwerter_temperatur()
        elif wybor == "3":
            srednia_ocen()
        elif wybor == "0":
            print("Koniec programu.")
            break
        else:
            print("Nieprawidłowy wybór.")

if __name__ == "__main__":
    main()

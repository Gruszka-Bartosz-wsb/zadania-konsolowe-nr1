using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n=== MENU ===");
            Console.WriteLine("1. Prosty kalkulator");
            Console.WriteLine("2. Konwerter temperatur");
            Console.WriteLine("3. Średnia ocen ucznia");
            Console.WriteLine("0. Zakończ");
            Console.Write("Wybierz zadanie: ");

            string wybor = Console.ReadLine();

            switch (wybor)
            {
                case "1":
                    Kalkulator();
                    break;

                case "2":
                    KonwerterTemperatur();
                    break;

                case "3":
                    SredniaOcen();
                    break;

                case "0":
                    Console.WriteLine("Koniec programu.");
                    return;

                default:
                    Console.WriteLine("Nieprawidłowy wybór.");
                    break;
            }
        }
    }

    static void Kalkulator()
    {
        Console.WriteLine("\n--- Prosty kalkulator ---");

        Console.Write("Podaj pierwszą liczbę: ");
        double liczba1 = double.Parse(Console.ReadLine());

        Console.Write("Podaj drugą liczbę: ");
        double liczba2 = double.Parse(Console.ReadLine());

        Console.Write("Wybierz operację (+, -, *, /): ");
        string operacja = Console.ReadLine();

        if (operacja == "+")
        {
            Console.WriteLine("Wynik: " + (liczba1 + liczba2));
        }
        else if (operacja == "-")
        {
            Console.WriteLine("Wynik: " + (liczba1 - liczba2));
        }
        else if (operacja == "*")
        {
            Console.WriteLine("Wynik: " + (liczba1 * liczba2));
        }
        else if (operacja == "/")
        {
            if (liczba2 != 0)
            {
                Console.WriteLine("Wynik: " + (liczba1 / liczba2));
            }
            else
            {
                Console.WriteLine("Nie można dzielić przez zero.");
            }
        }
        else
        {
            Console.WriteLine("Nieznana operacja.");
        }
    }

    static void KonwerterTemperatur()
    {
        Console.WriteLine("\n--- Konwerter temperatur ---");

        Console.Write("Wybierz kierunek konwersji (C - Celsius na Fahrenheit, F - Fahrenheit na Celsius): ");
        string wybor = Console.ReadLine();

        Console.Write("Podaj temperaturę: ");
        double temperatura = double.Parse(Console.ReadLine());

        if (wybor == "C" || wybor == "c")
        {
            double wynik = temperatura * 1.8 + 32;
            Console.WriteLine(temperatura + "°C = " + wynik + "°F");
        }
        else if (wybor == "F" || wybor == "f")
        {
            double wynik = (temperatura - 32) / 1.8;
            Console.WriteLine(temperatura + "°F = " + wynik.ToString("0.00") + "°C");
        }
        else
        {
            Console.WriteLine("Nieznany wybór.");
        }
    }

    static void SredniaOcen()
    {
        Console.WriteLine("\n--- Średnia ocen ucznia ---");

        Console.Write("Podaj liczbę ocen: ");
        int liczbaOcen = int.Parse(Console.ReadLine());

        double suma = 0;

        for (int i = 0; i < liczbaOcen; i++)
        {
            Console.Write("Podaj ocenę " + (i + 1) + ": ");
            double ocena = double.Parse(Console.ReadLine());
            suma = suma + ocena;
        }

        double srednia = suma / liczbaOcen;

        Console.WriteLine("Średnia: " + srednia.ToString("0.00"));

        if (srednia >= 3.0)
        {
            Console.WriteLine("Uczeń zdał.");
        }
        else
        {
            Console.WriteLine("Uczeń nie zdał.");
        }
    }
}

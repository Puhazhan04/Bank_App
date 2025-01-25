using System;

namespace BankApp
{
    class Programm
    {
        // Kontostand als Feld der Klasse
        private static double Kontostand = 0;

        // Methode, um den Kontostand anzuzeigen
        public static void ZeigeKontostand()
        {
            Console.WriteLine($"Der aktuelle Kontostand beträgt: {Kontostand:C}");
        }

        // Methode, um eine Einzahlung vorzunehmen
        public static void Einzahlung()
        {
            Console.WriteLine("Geben Sie den Betrag für die Einzahlung ein:");
            double Betrag = double.Parse(Console.ReadLine());
            if (Betrag > 0)
            {
                Kontostand += Betrag;
                Console.WriteLine($"Einzahlung von {Betrag:C} erfolgreich. Neuer Kontostand: {Kontostand:C}");
            }
            else
            {
                Console.WriteLine("Der Betrag muss positiv sein.");
            }
        }

        // Methode, um eine Auszahlung vorzunehmen
        public static void Auszahlung()
        {
            Console.WriteLine("Geben Sie den Betrag für die Auszahlung ein:");
            double Betrag = double.Parse(Console.ReadLine());
            if (Betrag > 0 && Betrag <= Kontostand)
            {
                Kontostand -= Betrag;
                Console.WriteLine($"Auszahlung von {Betrag:C} erfolgreich. Neuer Kontostand: {Kontostand:C}");
            }
            else if (Betrag > Kontostand)
            {
                Console.WriteLine("Unzureichender Kontostand für diese Auszahlung.");
            }
            else
            {
                Console.WriteLine("Der Betrag muss positiv sein.");
            }
        }

        // Methode, um den Kontoauszug anzuzeigen
        public static void Kontoauszug()
        {
            Console.WriteLine($"Ihr aktueller Kontostand ist: {Kontostand:C}");
        }

        // Methode, um das Programm zu beenden
        public static void ProgrammBeenden()
        {
            Console.WriteLine("Das Programm wird beendet.");
            Environment.Exit(0);
        }

        // Main-Methode, die das Hauptmenü enthält
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n1. Kontostand anzeigen");
                Console.WriteLine("2. Einzahlung");
                Console.WriteLine("3. Auszahlung");
                Console.WriteLine("4. Kontoauszug");
                Console.WriteLine("5. Programm Beenden");
                Console.WriteLine("Bitte wählen Sie eine Option:");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        ZeigeKontostand();
                        break;

                    case "2":
                        Einzahlung();
                        break;

                    case "3":
                        Auszahlung();
                        break;

                    case "4":
                        Kontoauszug();
                        break;

                    case "5":
                        ProgrammBeenden();
                        break;

                    default:
                        Console.WriteLine("Ungültige Option. Bitte wählen Sie eine gültige Option.");
                        break;
                }
            }
        }
    }
}

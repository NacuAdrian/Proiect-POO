using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        try
        {
            // Specifică calea către fișierul de intrare
            string caleFisier = "date.txt";

            // Citirea datelor din fișier și afișarea lor
            AfisareToatePersoanele(caleFisier);

            // Meniul principal
            while (true)
            {
                Console.WriteLine("Meniu:");
                Console.WriteLine("1. Cautare persoana");
                Console.WriteLine("2. Adaugare persoana");
                Console.WriteLine("3. Afisare toate persoanele");
                Console.WriteLine("4. Afisare cel mai mare scor");
                Console.WriteLine("0. Iesire");

                Console.Write("Selectati optiunea: ");
                string optiune = Console.ReadLine();

                switch (optiune)
                {
                    case "1":
                        CautarePersoana();
                        break;
                    case "2":
                        AdaugarePersoana(caleFisier);
                        break;
                    case "3":
                        AfisareToatePersoanele(caleFisier);
                        break;
                    case "4":
                        AfisareCelMaiMareScor(caleFisier);
                        break;
                    case "0":
                        Console.WriteLine("La revedere!");
                        return;
                    default:
                        Console.WriteLine("Optiune invalida.");
                        break;
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"A apărut o eroare: {ex.Message}");
        }
    }

    // Metoda pentru căutarea unei singure persoane
    static void CautarePersoana()
    {
        Console.Write("Introduceti numele persoanei: ");
        string numeCautat = Console.ReadLine();

        // Citim din nou fișierul pentru a găsi persoana
        string caleFisier = "date.txt";
        bool gasit = false;
        using (StreamReader sr = new StreamReader(caleFisier))
        {
            string linie;
            while ((linie = sr.ReadLine()) != null)
            {
                string[] date = linie.Split(',');
                if (date.Length == 3 && date[0] == numeCautat)
                {
                    string nume = date[0];
                    string prenume = date[1];
                    int scor = int.Parse(date[2]);

                    Console.WriteLine($"Nume: {nume}, Prenume: {prenume}, Scor: {scor}");
                    gasit = true;
                    break;
                }
            }
        }

        if (!gasit)
            Console.WriteLine("Persoana nu a fost gasita.");
    }

    // Metoda pentru afișarea tuturor persoanelor
    static void AfisareToatePersoanele(string caleFisier)
    {
        Console.WriteLine("Toate persoanele:");

        // Citirea datelor din fișier și afișarea lor
        using (StreamReader sr = new StreamReader(caleFisier))
        {
            string linie;
            while ((linie = sr.ReadLine()) != null)
            {
                // Se presupune că datele sunt separate prin virgulă
                string[] date = linie.Split(',');

                if (date.Length == 3)
                {
                    string nume = date[0];
                    string prenume = date[1];
                    int scor = int.Parse(date[2]);

                    // Afișarea datelor
                    Console.WriteLine($"Nume: {nume}, Prenume: {prenume}, Scor: {scor}");
                }
                else
                {
                    Console.WriteLine("Formatul liniei din fișier este incorect.");
                }
            }
        }
    }

    // Metoda pentru afișarea celui mai mare scor
    static void AfisareCelMaiMareScor(string caleFisier)
    {
        int celMaiMareScor = int.MinValue;
        string numeCelMaiMareScor = "";
        string prenumeCelMaiMareScor = "";

        // Citirea datelor din fișier și găsirea celui mai mare scor
        using (StreamReader sr = new StreamReader(caleFisier))
        {
            string linie;
            while ((linie = sr.ReadLine()) != null)
            {
                string[] date = linie.Split(',');
                if (date.Length == 3)
                {
                    int scor = int.Parse(date[2]);
                    if (scor > celMaiMareScor)
                    {
                        celMaiMareScor = scor;
                        numeCelMaiMareScor = date[0];
                        prenumeCelMaiMareScor = date[1];
                    }
                }
            }
        }

        if (celMaiMareScor != int.MinValue)
        {
            Console.WriteLine($"Cel mai mare scor: {celMaiMareScor} pentru {numeCelMaiMareScor} {prenumeCelMaiMareScor}");
        }
        else
        {
            Console.WriteLine("Nu exista scoruri in fisier.");
        }
    }

    // Metoda pentru adaugarea unei persoane noi
    static void AdaugarePersoana(string caleFisier)
    {
        Console.Write("Introduceti numele: ");
        string nume = Console.ReadLine();

        Console.Write("Introduceti prenumele: ");
        string prenume = Console.ReadLine();

        Console.Write("Introduceti scorul: ");
        if (int.TryParse(Console.ReadLine(), out int scor))
        {
            // Adăugăm persoana în fișier
            using (StreamWriter sw = new StreamWriter(caleFisier, true))
            {
                sw.WriteLine($"{nume},{prenume},{scor}");
                Console.WriteLine("Persoana a fost adaugata cu succes.");
            }
        }
        else
        {
            Console.WriteLine("Scorul introdus nu este valid.");
        }
    }
}

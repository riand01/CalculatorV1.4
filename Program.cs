
using System.Diagnostics.SymbolStore;
// Create a list
List<string> resultat = new List<string>();
// Create a string to capture user input choise
string kategori = "";

// While loop so the program those not end after firstchoise
while (kategori != "3")
{
    // Meny text
    Console.WriteLine("   Kalkylator\n----------------");
    Console.WriteLine("\n Gör något av följande val:\n\n 1. Kalkylator\n 2. Tidigare Resultat\n 3. Avsluta Programmet");
    Console.Write(" ");
    // User input 
    kategori = Console.ReadLine();

    // Switch that contains meny choises
    switch (kategori)
    {
        // Case 1 includes Calculator
        case "1":

            // declare the letter y to break the loop
            char more = 'y';
            // Aslong the user chooses y the calculator-loop will continue
            while (more == 'y')
            { 

                
                Console.Clear();
                Console.WriteLine("   Kalkylator");
                Console.WriteLine("----------------\n");
                Console.WriteLine("Skriv in en valfri beräkning, t.ex 4,6*3,2\n");
                // Declare user input 
                string beräkning = Console.ReadLine();

                // if case with contains method to declare user operator
                if (beräkning.Contains("*"))
                {
                    // declar operator
                    int gångerIndex = beräkning.IndexOf("*");
                    // declar first number
                    string tal1Text = beräkning[..gångerIndex];
                    // declar second number
                    string tal2Text = beräkning[(gångerIndex + 1)..];
                    // convert numbers from string to double
                    double tal1 = double.Parse(tal1Text);
                    double tal2 = double.Parse(tal2Text);
                    // declare the calculation
                    double produkt = tal1 * tal2;
                    // Print the calculation
                    Console.WriteLine(beräkning + " = " + produkt);
                    // catch the calculation to the list
                    string execution1 = $"{beräkning} = {produkt.ToString()}";
                    resultat.Add(execution1);
                    // Ask user to do a new calculation or return to meny
                    Console.WriteLine("Vill du göra en ny uträkning? (y/n)?");
                    // control char y
                    more = Convert.ToChar(Console.ReadLine());
                    Console.Clear();
                
                }
                // Same but different operator
                else if (beräkning.Contains("-"))
                {
                    int minusIndex = beräkning.IndexOf("-");
                    string tal1Text = beräkning[..minusIndex];
                    string tal2Text = beräkning[(minusIndex + 1)..];
                    double tal1 = double.Parse(tal1Text);
                    double tal2 = double.Parse(tal2Text);
                    double produkt = tal1 - tal2;
                    Console.WriteLine(beräkning + " = " + produkt);
                    string execution2 = $"{beräkning} = {produkt.ToString()}";
                    resultat.Add(execution2);
                    Console.WriteLine("Vill du göra en ny uträkning? (y/n)?");
                    more = Convert.ToChar(Console.ReadLine());
                    Console.Clear();
                }
                // Same but different operator
                else if (beräkning.Contains("+"))
                {
                    int plusIndex = beräkning.IndexOf("+");
                    string tal1Text = beräkning[..plusIndex];
                    string tal2Text = beräkning[(plusIndex + 1)..];
                    double tal1 = double.Parse(tal1Text);
                    double tal2 = double.Parse(tal2Text);
                    double produkt = tal1 + tal2;
                    Console.WriteLine(beräkning + " = " + produkt);
                    string execution3 = $"{beräkning} = {produkt.ToString()}";
                    resultat.Add(execution3);
                    Console.WriteLine("Vill du göra en ny uträkning? (y/n)?");
                    more = Convert.ToChar(Console.ReadLine());
                    Console.Clear();
                }
                // Same but different operator
                else if (beräkning.Contains("/"))
                {
                    int delatIndex = beräkning.IndexOf("/");
                    string tal1Text = beräkning[..delatIndex];
                    string tal2Text = beräkning[(delatIndex + 1)..];
                    double tal1 = double.Parse(tal1Text);
                    double tal2 = double.Parse(tal2Text);
                    double produkt = tal1 / tal2;
                // Catch error when dividing with zero
                if (tal2 == 0)
                {
                    Console.WriteLine("Du kan inte dividera med 0");
                        Console.ReadKey();
                    continue;
                }
                else
                    Console.WriteLine(beräkning + " = " + produkt);
                    string execution4 = $"{beräkning} = {produkt.ToString()}";
                    resultat.Add(execution4);
                    Console.WriteLine("Vill du göra en ny uträkning? (y/n)?");
                    more = Convert.ToChar(Console.ReadLine());
                    Console.Clear();


                }
                else
                {
                    // Invalid Operator
                    Console.WriteLine("Ogiltigt val!");
                    Console.WriteLine("Vill du göra en ny uträkning? (y/n)?");
                    more = Convert.ToChar(Console.ReadLine());
                }
            }
                break;
        // Case 2 includes List of former calculations   
        case "2":
            
            Console.Clear();
            Console.WriteLine("   Tidigare Resultat");
            Console.WriteLine("-------------------------\n");
            // Print entire List with foreach loop
            foreach (string print in resultat)
            {
                Console.WriteLine(print + " ");
            }
            Console.WriteLine("\n\nTryck Enter för att gå tillbaka till menyn");
            Console.ReadKey();
            Console.Clear();
            break;
        // Quite Program 
        case "3":
            // Avsluta Programmet
            Console.WriteLine("\n Programmet kommer att avslutas!");
            Console.WriteLine(" Tryck Enter för att bekräfta!");
            Console.ReadKey();
            // Code to exit program
            Environment.Exit(1);
            break;
        // Catch invalid choise
        default:
            Console.WriteLine("Ogiltigt val, Tryck Enter och försök igen!");
            Console.ReadKey();
            Console.Clear();
            break;
    }
}


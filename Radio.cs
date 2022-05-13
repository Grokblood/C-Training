//Radio
using System;

class TestRadio
{
    //Main Methode
    static void Main(){
        // Erstellt ein bisschen Interface
        Console.WriteLine("       ~~~~~~~~~");
        Console.WriteLine("         Radio");
        Console.WriteLine("       ~~~~~~~~~");

         Console.WriteLine("Soll das Radio eingeschaltet werden? Wenn ja, bitte '1' eingeben!");
        //Eingabe durch Nutzer*in wird in einen Int16 umgewandelt
        string input = Console.ReadLine();
        int start = Int16.Parse(input);
            //If abgrage ob das Radio ein oder ausgeschaltet wird mit aufruf der jeweiligen Methoden                         
            if (start != 1) {
            Console.WriteLine("Ok, schade! Radio bleibt aus.");
            Main();

                } else {
            Functions();
        }
    }

    //Functions Methode lässt Nutzer*innen entscheiden welche frequenz und lautstärke. Prüft in While schleifen ob der richtige Datentyp genutzt wurde
    static void Functions(){

            Console.WriteLine("Welche Frequenz soll das Radio eingestellt sein?");
                string variableFrequenz = Console.ReadLine();
                while(double.TryParse(variableFrequenz, out double n) == false)
                {
                    Console.WriteLine("Bitte eine Zahl/Kommazahl als Frequenz eingeben! Programm fängt von vorne an!");
                    Functions();
                }

                Console.WriteLine("Welche Lautstärke soll das Radio eingestellt sein?");
                string variableLautstärke = Console.ReadLine();
                while(int.TryParse(variableLautstärke,out int n) == false){
                    Console.WriteLine("Bitte einen Zahlenwert für die Lautstärke eingeben! Programm fängt von vorne an!");
                    Functions();
                }
                //Ausgabe des Laufenden Radios
                Console.WriteLine("Radio ist eingeschaltet, es läuft auf der Frequenz: " + variableFrequenz + " mhz");
                Console.WriteLine("und ist auf die Lautstärke " + variableLautstärke + " eingestellt");
                End();

    }

    //End Methode fragt Nutzer*in ob Radio abgeschaltet werden soll, oder die Frequenz geändert werden soll.
    static void End(){

              Console.Write("Soll das Radio ausgeschaltet werden? Wenn ja, bitte '1' eingeben!");
                string inEnd = Console.ReadLine();
                int ende = Int16.Parse(inEnd);

                if (ende !=1){
                    Console.WriteLine("Das Radio läuft weiter...");
                    Task.Delay(10000);
                    Console.WriteLine("Soll eine andere Frequenz oder Lautstärke eingestellt werden? Wenn ja, bitte '1' eingeben!");
                    string inChange = Console.ReadLine();
                    int change = Int16.Parse(inChange);

                    if (change !=1){
                        End();
                    } else {
                        Functions();
                    }
                     
                } else {
                    Console.WriteLine("Das Radio wird ausgeschaltet!");
                    System.Environment.Exit(0);
                }
                }
} 
# Lernbericht 
Alberto Manser
## Einleitung
In diesem Projekt musste ich ein Spiel programmieren, bei dem wir eine zufällige Zahl generieren und diese erraten mussten.
## Was hab ich gelernt?
Ich habe gelernt wie man try und catch benutzt und habe denn Umgang mit Variablen besser kennengelernt.
## Beschreibung


Try catch ist eine Funktion, die ein Code teil auszuführen versucht (try) und falls dies ein Error auswirft wird dieser aufgefangen und nicht an den code weitergeleitet.
somit kann man dann eine Error Message in der Konsole ausgeben lassen kann (catch), wie sie hier sehen:
![image](https://user-images.githubusercontent.com/110892537/189847729-657478d8-1dee-4ebb-b5c7-afdf24768ee6.png)




```c#
                    try
                    {
                        Console.Write("in welcher Zahlenrange wollen Sie spielen? (nur das maximum angeben) ");
                        int Range = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("geben Sie bitte eine Zahl zwischen 1 und {0}", Range);
                        int Zahleingabe = System.Convert.ToInt32(Console.ReadLine());
                        Random rnd = new Random();
                        int RNG = rnd.Next(1, 13);

                    if (Zahleingabe >= 1 && Zahleingabe <= (Range))
                    {

                        while (Zahleingabe != RNG)
                        {
                            if (Zahleingabe > RNG)
                            {
                                Console.WriteLine("Ihre Zahl ist zu gross");
                                Variable = true;
                            }
                            else
                            {
                                Console.WriteLine("Ihre Zahl ist zu klein");
                                Variable = true;
                            }

                            Console.Write("geben sie bitte noch eine Zahl ein: ");
                            Zahleingabe = Convert.ToInt32(Console.ReadLine());
                        }
                        if (Zahleingabe == RNG)
                        {
                            Console.WriteLine("Glückwunsch sie habe die richtige Zahl erraten!");

                        }

                    }
                    else
                    {
                            throw new Exception();

                    }
                    }
                    catch
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Falsche eingabe, geben Sie bitte eine korrekte Zahl ein");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
```
Hier sehen Sie, wie ich extra einen Error erstellt habe, falls die Person eine falsche Zahl eingibt. 

## Verifikation
Im Bild sehen sie wie es aussieht, wenn man eine falsche Eingabe macht und im Code Snippet sehen Sie, wie ich dies erreicht habe.
## Reflektion
Ich habe die neuen Funktionen sehr schnell gelernt und konnte sie schnell anwenden.
Ich hätte aber ein besseres Design machen sollen und schon früher anfangen, die Testfälle auszuführen.
**VBV** länger nach Features nachdenken die man implementieren könnte und falls ich fertig bin nicht faul sein, sondern schon voraus arbeiten.


 

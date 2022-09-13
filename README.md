# Projekt-Dokumentation

Alberto Manser

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
| 23.8.2022 | 0.0.1   |  Angefangen mit der Projekt dokumentation                |
| 30.8.2022 | o.o.2   |  Fast alle arbeitpakete durchgeführt, auser 3.A          |
| 6.9.2022  | 1.0.0   |  Alle arbeitpakete durchgeführt.                         |

## 1 Informieren

### 1.1 Ihr Projekt

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |  muss | funktional     | Als ein Kunde möchte ich mit dem Programm eine Zahl erraten können, damit das Spiel auch nutzbar ist |
| 2    |  muss | funktional     | Als ein Kunde möchte ich, dass es nicht bei einem falschen Input kaputtgeht, damit das Spiel zuverlässig ist |
| 3    |  kann | Qualität     | Als ein Kunde möchte ich das es einfach zu nutzen ist, damit neue Nutzer es auch verstehen |
| 4    |  kann | Qualität     | Als ein Kunde möchte ich die Schwierigkeit (nicht 1 - 100, sondern vielleicht 1 -1000) einstellen können, damit es nicht langweilig wird |
| 5    | muss  |  funktional | Als ein Kunde möchte ich, dass das Programm wirklich eine zufällige Zahl generiert und nicht eine Reihenfolge dahinter steht, damit man nicht cheaten kann |


### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  | Zahl ist generiert | Zahl innerhalb der Range | richtig / falsch, grösser oder kleiner |
| 2.1  | Zahl ist generiert | Zahl ausserhalb Range | Zahl nicht innerhalb der Range, bitte geben sie eine Zahl zwischen 1 und 100 an |
| 2.2  | Zahl ist generiert | Buchstaben anstatt Zahlen eingeben | Falsche eingabe, geben sie eine Zahl ein |
| 2.3  | Range muss eingegeben werden | Buchstaben eingeben | Falsche eingabe, Geben sie eine Zahl ein |
| 4.1  | Andere Schwierigkeit eingegeben | Zahl innerhalb neuer Range | richtig /falsch, grösser oder kleiner |

### 1.4 Diagramme
![Hauptprogramm 1](https://user-images.githubusercontent.com/110892537/186104282-ad0d494e-9a5b-40d8-abe2-43dc7af567b6.png)


## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |       |  Alberto  |  RNG & eingabefeld & raten mit Rückgabe | 30 min        |
| 2.A  |       |  Alberto  |  BEi Falschem input rückmeldung geben | 20 min              |
| 4.A  |       |  ALberto  | Vor dem generieren Fragen in welcher vorgesetzter Range die Zahl sein soll | 45 min |
| 3.A  |       |  Alberto  | Simples Design |20 min |


Total: 


## 3 Entscheiden

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  | 30 .8.2022   | Alberto        |  30min             | 40 min               |
| 2.A  | 30.8.2022    | Alberto        |  20min             | 10 min               |
| 3.A  | 6.9.2022     | Alberto        |  20min             | 5  min               |
| 4.A  | 30.8.2022    | Alberto        |  45 min            | 20 min               |


## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |  13.9.2022 | Ihre Zahl ist zu klein, Ihre Zahl ist zu gross | Alberto |
| 2.1  | 13.9.2022  | Falsche eingabe, geben sie bitte eine korrekte Zahl ein | Alberto |
| 2.2  | 13.9.2022  | Falsche eingabe, geben sie bitte eine korrekte Zahl ein | Alberto |
| 2.3  | 13.9.2022  | Falsche eingabe, geben sie bitte eine korrekte Zahl ein | Alberto |
| 4.1  | 13.9.2022  | Ihre Zahl ist zu klein, Ihre Zahl ist zu gross | Alberto |


### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |     Die gesuchte Zahl wurde erraten         |    "false"     |       Programm beendet sich   |      "Wollen Sie nocheinmal spielen?"                |
| II  |   Als maximale Zahl wurde -100 eingetragen, anschliessend kann die Zahl erraten werden     |   Es wurde -10 eingetragen |  "Die gesuchte Zahl ist grösser/kleiner als die eingegebene Zahl | "Falsche Eingabe", es kann erneut eine maximale Zahl gewählt werden  |


## 6 Auswerten


[Hier](Lernbericht.md) ist mein Lernbericht

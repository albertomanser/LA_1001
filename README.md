# Projekt-Dokumentation

☝️ Alle Text-Stellen, welche mit einem ✍️ beginnen, können Sie löschen, sobald Sie die entsprechende Stellen ausgefüllt haben.

Alberto Manser

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
| 23.8.2022 | 0.0.1   |  Angefangen mit der Projekt dokumentation                |
| 30.8.2022 | o.o.2   |  Fast alle arbeitpakete durchgeführt, auser 3.A          |
| 6.9.2022  | 1.0.0   |  Alle arbeitpakete durchgeführt.                         |

## 1 Informieren

### 1.1 Ihr Projekt

✍️ In diesem Projekt geht es darum, ein Random Number Generator zu programmieren, bei dem der Nutzer eine zufällige Nummer zwischen 1 und 100 erraten muss.

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

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, die der Testfall abdeckt, und `m` von `1` an nach oben gezählt. Beispiel: Der dritte Testfall, der die zweite User Story abdeckt, hat also die Nummer `2.3`.

### 1.4 Diagramme
![Hauptprogramm 1](https://user-images.githubusercontent.com/110892537/186104282-ad0d494e-9a5b-40d8-abe2-43dc7af567b6.png)


✍️ Hier können Sie PAPs, Use Case- und Gantt-Diagramme oder Ähnliches einfügen.

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 1.A  |       |  Alberto  |  RNG & eingabefeld & raten mit Rückgabe | 30 min        |
| 2.A  |       |  Alberto  |  BEi Falschem input rückmeldung geben | 20 min              |
| 4.A  |       |  ALberto  | Vor dem generieren Fragen in welcher vorgesetzter Range die Zahl sein soll | 45 min |
| 3.A  |       |  Alberto  | Simples Design |20 min |


Total: 

✍️ Die Nummer hat das Format `N.m`, wobei `N` die Nummer der User Story ist, auf die sich das Arbeitspaket bezieht, und `m` von `A` an nach oben buchstabiert. Beispiel: Das dritte Arbeitspaket, das die zweite User Story betrifft, hat also die Nummer `2.C`.

✍️ Ein Arbeitspaket sollte etwa 45' für eine Person in Anspruch nehmen. Die totale Anzahl Arbeitspakete sollte etwa Folgendem entsprechen: `Anzahl R-Sitzungen` ╳ `Anzahl Gruppenmitglieder` ╳ `4`. Wenn Sie also zu dritt an einem Projekt arbeiten, für welches zwei R-Sitzungen geplant sind, sollten Sie auf `2` ╳ `3` ╳`4` = `24` Arbeitspakete kommen. Sollten Sie merken, dass Sie hier nicht genügend Arbeitspakte haben, denken Sie sich weitere "Kann"-User Stories für Kapitel 1.2 aus.

## 3 Entscheiden

✍️ Dokumentieren Sie hier Ihre Entscheidungen und Annahmen, die Sie im Bezug auf Ihre User Stories und die Implementierung getroffen haben.

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 1.A  | 30 .8.2022   | Alberto        |  30min             | 40 min               |
| 2.A  | 30.8.2022    | Alberto        |  20min             | 10 min               |
| 3.A  | 6.9.2022     | Alberto        |  20min             | 5  min               |
| 4.A  | 30.8.2022    | Alberto        |  45 min            | 20 min               |

✍️ Tragen Sie jedes Mal, wenn Sie ein Arbeitspaket abschließen, hier ein, wie lang Sie effektiv dafür hatten.

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  |  13.9.2022 | Ihre Zahl ist zu klein, Ihre Zahl ist zu gross | Alberto |
| 2.1  | 13.9.2022  | Falsche eingabe, geben sie bitte eine korrekte Zahl ein | Alberto |
| 2.2  | 13.9.2022  | Falsche eingabe, geben sie bitte eine korrekte Zahl ein | Alberto |
| 2.3  | 13.9.2022  | Falsche eingabe, geben sie bitte eine korrekte Zahl ein | Alberto |
| 4.1  | 13.9.2022  | Ihre Zahl ist zu klein, Ihre Zahl ist zu gross | Alberto |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    |              |         |                   |                      |
| ...  |              |         |                   |                      |

✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

✍️ Fügen Sie hier eine Verknüpfung zu Ihrem Lern-Bericht ein.

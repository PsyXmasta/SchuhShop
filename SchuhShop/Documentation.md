# Mini Schuhshop

## Projektidee
Ich entwickle einen einfachen Schuhshop als Konsolenanwendung in C#.  
Das Thema ist für mich interessant, da ich bereits in der Schuhbranche gearbeitet habe.

Die Anwendung soll grundlegende Shop-Funktionen enthalten, wie das Anzeigen von Produkten und das spätere Hinzufügen in einen Warenkorb.

------------------------------------------------------------------------------------------------------------------

## Funktionen (geplant)
- Produkte anzeigen
- Produkt suchen
- Produkt in Warenkorb hinzufügen
- Warenkorb anzeigen
- Produkt entfernen
- Bestellung abschließen

------------------------------------------------------------------------------------------------------------------

## Tag 1 – Projektstart

Am ersten Tag habe ich die Grundlage des Projekts erstellt.

### Umgesetzte Schritte:
- Projekt in Visual Studio erstellt
- Git-Repository eingerichtet
- Projekt auf GitHub hochgeladen
- Grundstruktur des Projekts erstellt

### Klassenstruktur:
Folgende Klassen wurden angelegt:
- Product
- CartItem
- Cart
- ShopService

Diese Klassen sind zunächst leer und dienen als Grundlage für die weitere Entwicklung.

### Ziel:
Ziel war es, eine saubere und übersichtliche Struktur zu schaffen, um später einfacher weiterarbeiten zu können.

------------------------------------------------------------------------------------------------------------------

## Tag 2 – Produktmodell und Anzeige

Am zweiten Tag habe ich mit der eigentlichen Implementierung begonnen.

### Umgesetzte Schritte:
- Klasse Product definiert
- Eigenschaften hinzugefügt:
  - Id
  - Name
  - Price
- Konstruktor für Product erstellt
- Liste von Produkten erstellt
- Ausgabe der Produkte in der Konsole implementiert

Ergebnis:
Das Programm zeigt nun eine Liste von Schuhen mit Preis in der Konsole an.
Ziel:
Ziel war es, ein erstes funktionierendes Feature zu implementieren und mit objektorientierter Programmierung zu arbeiten.

Probleme und Lösungen
Problem:
Doppelte Definition der Klasse Product
Lösung:
Die Klasse wurde aus Program.cs entfernt und in eine eigene Datei (Product.cs) ausgelagert.

Nächste Schritte

Menü erstellen
Benutzer-Eingaben verarbeiten
Warenkorb implementieren

------------------------------------------------------------------------------------------------------------------


## Tag 3 – Menü und Benutzereingaben

Am dritten Tag habe ich ein Menü implementiert.

### Umgesetzte Schritte:
- Menü in der Konsole erstellt
- Benutzereingaben mit Console.ReadLine() verarbeitet
- Switch-Case zur Steuerung der Aktionen verwendet
- Anzeige der Produkte in eine separate Methode ausgelagert

### Ergebnis:
Der Benutzer kann jetzt über das Menü eine Aktion auswählen.

### Ziel:
Die Anwendung soll interaktiv werden und auf Eingaben des Benutzers reagieren.

------------------------------------------------------------------------------------------------------------------



Beispiel-Testfall:

ID: T01
Beschreibung: Einloggen als Administrator
Vorbedingung: Die Anwendung startet im Anmeldedialog.
Test-Schritte:
Admin E-Mail „melih@gmail.com“ eingeben.
Passwort „melih@gmail.com“ eingeben.
Login durchführen und in den Admin-Tab wechseln.
Erwartetes Resultat: Admin kann Punkte anderer Nutzer anpassen.

ID: T02
Beschreibung: Punkte anzeigen lassen
Vorbedingung: Die Anwendung startet im Anmeldedialog.
Test-Schritte:
E-Mail „melih@gmail.com“ eingeben.
Login durchführen
Erwartetes Resultat: Punkte werden für den jeweiligen Nutzer angezeigt.

# Testfälle für Schwimmbad Treueprogramm

## Testfall 1: Einloggen als Nutzer
**ID:** T01  
**Beschreibung:** Einloggen als normaler Nutzer, um den Punktestand anzuzeigen.  
**Vorbedingungen:**  
- Das Programm ist im Anmeldedialog.  
- Ein registrierter Name und E-Mail existieren.

**Test-Schritte:**
1. Im Feld "E-Mail" wird ein existierende E-Mail eingegeben (z.B. "melih2@gmail.com").
2. Der "Login"-Button wird geklickt.

**Erwartetes Resultat:**
- Der Nutzer wird eingeloggt.
- Der Punktestand des Nutzers wird im Dashboard angezeigt.
- Der Zugriff auf die Funktionen "Punkte einsehen" und "Punkte einlösen" wird gewährt.
- Im Dashboard wird die Anzahl der Besuche sichtbar.

---

## Testfall 2: Registrierung eines neuen Nutzers
**ID:** T02  
**Beschreibung:** Registrierung eines neuen Nutzers im System.  
**Vorbedingungen:**  
- Das Programm ist im Registrierungsdialog.  
- Es existiert noch kein Benutzer mit der gleichen E-Mail.

**Test-Schritte:**
1. Im Feld "E-Mail" wird ein neue E-Mail eingegeben (z.B. "melih2@gmail.com").
2. Im Feld "Name" wird ein Name eingegeben (z.B. "melih2").
3. Der "Registrieren"-Button wird geklickt.

**Erwartetes Resultat:**
- Der neue Nutzer wird erfolgreich registriert.
- Der Punktestand des Nutzers wird im Dashboard angezeigt.
- Im Dashboard wird die Anzahl der Besuche sichtbar.
- Eine Bestätigungsmeldung wie "Erfolgreich registriert" erscheint.

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Supernova.helper
{
    class HelperTexts
    {

        public string GetLogin()
        {
            string meintext = @"{\rtf1 Geben Sie ihren Benutzernamen und anschließend ihr Passwort in die zugehörigen\par Felder ein. Mit einem Klick auf den Button {\b 'Login'} melden Sie sich an.\par \par Wenn sie einen unbekannten Benutzernamen oder ein falsches Passwort eingegeben\par haben, weist Supernova Sie darauf hin.\par \par Wenn Sie sich nicht anmelden können, wenden Sie sich an Ihren Administrator.}";
            return meintext;
        }

        public string GetAbteilungskapazitaet()
        {
            string meintext = @"{\rtf1 Unter {\b 'Admin'} --> {\b 'Abteilungskapazität'} können Sie die Kapazitäten der eingetragenen\par Abteilungen einsehen, neue Abteilungen erstellen und bestehende Abteilungen\par löschen.\par \par Abteilungsleiter können nur die Kapazitäten ihrer eigenen Abteilung ändern\par und haben keinen Zugriff auf weitere Abteilungen. Geschäftsleitung und\par Administratoren haben Zugriff auf alle Abteilungen und Funktionen.\par \par In der Combobox {\b 'Abteilungsname'} wird eine Abteilung ausgewählt und deren Daten\par mit Klick auf den Button {\b 'Abteilungsname'} geladen.\par \par Die Daten zum aktuellen Abteilungsleiter und den Kapazitäten für die nächsten\par drei Jahre werden hier angezeigt.\par \par Der Abteilungsleiter kann hier nicht geändert werden. Dies ist nur über die\par Benutzerverwaltung möglich.\par \par Eine Änderung an den Abteilungskapazitäten muss mit einem Klick auf {\b 'Speichern'}\par übernommen werden, dies wird mit der Meldung {\b 'Die Daten wurden erfolgreich'}\par {\b 'gespeichert'} bestätigt. Mit dem Button {\b 'Verwerfen'} werden die Felder der\par Abteilungskapazitäten geleert. Alle drei Felder müssen allerdings ausgefüllt\par sein, um neu gespeichert werden zu können.\par \par Über {\b 'Neue Abteilung erstellen'} können neue Abteilungen erstellt werden.\par Es öffnet sich dafür ein neues Fenster, in dem Abteilungsname und die\par Abteilungskapazitäten der nächsten drei Jahre eingetragen werden. Mit {\b 'Ok'} wird\par die Abteilung angelegt, mit {\b 'Abbrechen'} wird der Vorgang beendet, ohne eine neue\par Abteilung anzulegen.\par \par Der Button {\b 'Diese Abteilung löschen'} ermöglicht die aktuell geladene Abteilung\par zu löschen. Nach einer Bestätigungsabfrage wird die Abteilung gelöscht.}";
            return meintext;
        }

        public string GetBenutzerinformationen()
        {
            string meintext = @"{\rtf1 Unter {\b 'Account'} --> {\b 'Benutzerinformationen'} finden Sie eine Übersicht über ihre\par öffentlichen Benutzerdaten: Ihren eingetragenen Vornamen, Nachnamen,\par Benutzernamen (zur Anmeldung) und Ihre Email-Adresse.}";
            return meintext;
        }

        public string GetBenutzerverwaltung()
        {
            string meintext = @"{\rtf1 Unter {\b 'Admin'} --> {\b 'Benutzerverwaltung'} kann man alle Benutzer des Programms verwalten.\par Dieses Menü ist nur für Geschäftsleitung und Administratoren verfügbar.\par \par Es gibt zwei Möglichkeiten, einen Benutzer zu laden: Entweder gibt man seinen\par Benutzernamen in das Feld {\b 'Benutzername'} ein und klickt auf den Button {\b 'Benutzer}\par {\b laden'}, oder man wählt ihn nach einem Klick auf {\b 'Benutzer Liste'} im sich neu\par öffnenden Fenster aus. In beiden Fällen werden die Benutzerdaten im unteren Teil\par des Fensters geladen.\par \par Um einen neuen Benutzer erstellen zu können, müssen alle Felder im unteren Teil\par leer sein. Wenn die Benutzerverwaltung neu geöffnet wurde, ist dies der Fall.\par Alternativ werden mit einem Klick auf den Button {\b 'Verwerfen'} ebenfalls alle\par Felder geleert. Wenn alle Felder leer sind, können die Daten des neuen Benutzers\par eingetragen werden und dieser mittels {\b 'Benutzer Speichern'} angelegt werden.\par \par Wenn ein Benutzer geladen ist, kann dieser über den Button {\b 'Benutzer löschen'}\par gelöscht werden. Der aktuell eingeloggte Benutzer kann nicht gelöscht werden.\par \par Die Daten eines Benutzers können geändert werden, nachdem dieser geladen wurde.\par Nur der Benutzername kann nicht verändert werden. Änderungen werden mittels\par {\b 'Benutzer Speichern'} übernommen.}";
            return meintext;
        }

        public string GetPasswortAendern()
        {
            string meintext = @"{\rtf1 Unter Account --> Passwort ändern können Sie ihr Passwort durch ein neues\par ersetzen. Geben Sie dazu zunächst Ihr altes Passwort ein und danach in die\par jeweiligen Textfelder das Neue und dessen Wiederholung. Mit einem Klick auf den\par Button {\b 'Passwort ändern'} wird das neue Passwort gesetzt.\par \par {\b Wichtig:} Das Passwort darf nur aus Zahlen bestehen! Andere Zeichen sind nicht\par möglich. Wenn die Änderung erfolgreich war, werden Sie mit dem Hinweis {\b 'Passwort}\par {\b wurde geändert'} darauf hingewiesen.\par \par Bei Fehlern werden Sie mit einer Fehlermeldung darauf hingewiesen. Versuchen Sie\par die Änderung dann erneut mit korrekten Daten.}";
            return meintext;
        }

        public string GetProjekteAnzeigen()
        {
            string meintext = @"{\rtf1 Unter 'Projekte --> Projekte anzeigen' gibt es eine Übersicht über alle Projekte,\par die aktuell erfasst sind. Diese Übersicht ist in drei Bereiche aufgeteilt:\par 'Filtern', 'Auswertungen' und die Liste aller Projekte.\par \par Mittels {\b 'Filtern'} kann eingestellt werden, welche Projekte in der Liste\par angezeigt werden. Dabei können spezielle Strategien oder Kategorien ausgewählt\par werden. Zusätzlich können nur 'Muss-Projekte' oder Projekte, denen man als\par Projektleiter zugeteilt ist, gefiltert werden.\par \par Die Liste der Projekte beinhaltet die Informationen zu Titel, Beschreibung,\par Kategorie, Projektleiter, Zeitraum, der errechneten Priorisierung, dem daraus\par folgenden Optimierungswert und der Angabe, ob ein Projekt ein 'Muss-Projekt'\par ist. Über das Kontextmenü ('Rechtsklick') können Projektdetails angezeigt,\par Änderungen vorgenommen, Projekte als 'Muss-Projekte' an- oder abgewählt und das\par Projekt gelöscht werden. Änderungen werden in der gleichen Weise vorgenommen,\par wie Projekte erstellt werden (siehe die Hilfe dort).\par \par Die {\b 'Auswertung'} bietet mehrere Möglichkeiten der Analysen.\par \par Die 'Ressourcen-Auslastung' öffnet ein kleines Fenster, in dem die geplanten\par und offenen Werte für Budget und Ressourcen der nächsten drei Jahre in\par Balkendiagrammen miteinander verglichen werden. Die Ressourcen, oder 'Kapazität'\par wird dabei nach Abteilung angezeigt. Um eine neue Abteilung anzuzeigen, wird\par diese im Dropdown-Menü ausgewählt und der Button 'Abteilung laden' geklickt.\par \par Die 'Strategie-Auswertung' zeigt im Reiter 'Strategie' an, welche Strategie von\par den aktuellen Muss-Projekten wie stark unterstützt wird. Im Reiter 'Kategorie'\par wird gezeigt, welche Kategorie wie stark von den aktuellen Muss-Projekten\par unterstützt wird.\par \par Beide Auswertungen lassen sich mittels des Buttons 'Excel-Export' zusammen mit\par ihren Werten nach Excel exportieren.\par \par In den Bereich unter 'Projekt-Analyse' können bis zu fünf Projekte aus der\par Liste mittels Drag&Drop gezogen und nach einem Klick auf den Button miteinander\par verglichen werden. Dabei werden die Kosten gegen das Risiko aufgetragen. Die\par größe der Punkte geben den NPV der Projekte an.\par \par Über den Button 'Excel-Export' wird die aktuelle Liste der Projekte nach Excel\par exportiert.}";
            return meintext;
        }

        public string GetProjekteErstellen()
        {
            string meintext = @"{\rtf1 Unter 'Projekte --> Projekt erstellen' können Sie neue Projekte erfassen und ins\par System übernehmen. Dieser Vorgang besteht aus fünf einzelnen Schritten. Mittels\par der Buttons 'Weiter' und zurück können Sie zwischen den einzelnen Schritten hin\par und her wechseln und auch nachträglich noch Änderungen anbringen. Der Button\par 'Verwerfen' löscht alle bisherigen Eingaben.\par \par {\b Schritt 1 - allgemeine Daten}\par \par Im ersten Schritt werden Projektbezeichnung und eine kurze Beschreibung, sowie\par der Projektleiter und die Kategorie eingetragen.\par \par Die beiden Textfelder sind Pflicht und müssen beide ausgefüllt werden, die\par Projektbezeichnung muss dabei einzigartig sein. Projektleiter und Kategorie\par lassen sich über Dropdown-Menüs aus der Liste der Vorhandenen auswählen. Jeder\par Projektleiter kann dabei aber nur ein Projekt leiten!\par \par {\b Schritt 2 - Daten und Kosten}\par \par Im zweiten Schritten wird der zeitliche und finanzielle Rahmen des Projektes\par erfasst, alle ausfüllbaren Felder sind Pflicht.\par \par Der Start- und End-Termin werden auf den Monat genau fest gelegt.\par \par Die Kosten für das zweite und dritte Jahr müssen nur ausgefüllt werden, wenn das\par Projekt auch so lange dauert.\par \par Die Daten sind für die spätere Auswertung und Priorisierung alle wichtig.\par \par {\b Schritt 3 - Abteilungskapazitäten}\par \par Im dritten Schritt werden die geplanten Manntage pro Abteilung für das Projekt\par erfasst. Die Manntage für das zweite und dritte Jahr müssen nur bei Projekten\par erfasst werden, die auch so lange gehen.\par \par Es muss mindestens ein Manntag erfasst werden.\par \par {\b Schritt 4 - Risiken}\par \par Im vierten Schritt werden die Risiken des Projektes erfasst. Dabei müssen\par technisches, finanzielles, sicherheitsrelevantes und qualitatives Risiko auf\par einer Skala von Null bis Zehn beurteilt werden. Rechts neben den Schiebereglern\par wird der aktuelle Wert ausgewiesen, es gibt keinen Default-Wert.\par \par {\b Schritt 5 - Strategische Ausrichtung}\par \par Im fünften Schritt wird erfasst, wie stark das Projekt die aktuellen Strategien\par des Unternehmens unterstützt. Dabei kann zwischen 'sehr hoch', 'hoch', 'mittel',\par 'gering' und 'gar nicht' unterschieden werden. Die Default-Werte sind 'mittel'.\par \par Über den Button 'Speichern' wird das erfasste Projekt gespeichert und\par übernommen.}";
            return meintext;
        }

        public string GetKriterienPriorisieren()
        {
            string meintext = @"{\rtf1 Über 'Admin --> Kriterien priorisieren' können die Kriterien, die bei der\par automatischen Priorisierung beachtet werden, eingestellt und gegeneinander\par gewichtet werden, sowie die Skalierung einzelner Kriterien erfasst werden.\par \par Im {\b linken Bereich} kann zunächst eingestellt werden, welche Kriterien überhaupt\par beachtet werden sollen. Kriterien, deren Checkbox angehakt ist, werden für die\par Priorisierung beachtet. Änderungen werden nach einem Klick auf 'Speichern'\par übernommen. Mit 'Verwerfen' können Änderungen verworfen werden und der bisherige\par Stand wiederhergestellt werden.\par \par Im {\b rechten Bereich} können nun die einzelnen Kriterien gegeneinander gewichtet\par werden und die Skalierung verändert werden.\par \par Im Tab 'Gewichtung' wird erfasst, welchen Wert ein einzelnes Kriterium\par verglichen mit einem anderen hat. Dabei wird das linke Kriterium gegenüber dem\par oberen Kriterium gewichtet. Ein Wert von 4 bedeutet 'viel wichtiger', 3 bedeutet\par 'wichtiger', 2 bedeutet 'gleich' wichtig, 1 bedeutet 'unwichtiger' und 0\par bedeutet 'unwichtig'. Kriterien, die mit sich selbst verglichen werden, erhalten\par immer den Wert 0. Wenn ein Feld ausgewählt wird.\par \par Wenn ein Feld ausgewählt wird, wird immer das dazu gehörige Gegenfeld rot\par hinterlegt. Die Summe der beiden Felder beträgt immer 4 und wird angepasst,\par sobald eines der beiden Felder verändert wird. Die Werte können von 0 bis 4\par eingetragen werden.\par \par Mittels 'Speichern' werden Änderungen übernommen (dies kann ein paar Augenblicke\par dauern) und mit 'Verwerfen' werden Änderungen verworfen und der bisherige Stand\par wieder angezeigt.\par \par Im Tab 'Skalierung' wird für die Kriterien 'Dauer', 'Gesamtkosten', 'NPV' und\par 'Time to market' angegeben, welcher Bereich wie viele 'Punkte' gibt. Die Punkte\par bewegen sich zwischen 1 und 10, wobei 10 das Beste ist. Die Wertebereiche je\par Punkt können frei angegeben werden, wobei das Minimum immer dem Maximum des\par Vorgängers entsprechen muss.\par \par Auch hier werden Änderungen mit 'Speichern' übernommen und mit 'Verwerfen'\par verworfen.}";
            return meintext;
        }

        public string GetBudget()
        {
            string meintext = @"{\rtf1 Über 'Admin --> Budget ' kann das gesamt Budget für die kommenden 3 Jahre eingestellt werden";
            return meintext;
        }
    }
}

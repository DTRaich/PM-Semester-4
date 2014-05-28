using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Supernova.helper
{
    class HelperTexts
    {

        public string GetLogin()
        {
            string meintext = "Geben Sie ihren Benutzernamen und anschließend ihr Passwort in die zugehörigen\nFelder ein. Mit einem Klick auf den Button 'Login' melden Sie sich an.\n\nWenn sie einen unbekannten Benutzernamen oder ein falsches Passwort eingegeben\nhaben, weist Supernova Sie darauf hin.\n\nWenn Sie sich nicht anmelden können, wenden Sie sich an Ihren Administrator.\n\n";
            return meintext;
        }

        public string GetAbteilungskapazitaet()
        {
            string meintext = "Unter Admin → Abteilungskapazität können Sie die Kapazitäten der eingetragenen\nAbteilungen einsehen, neue Abteilungen erstellen und bestehende Abteilungen\nlöschen.\n\nAbteilungsleiter können nur die Kapazitäten ihrer eigenen Abteilung ändern\nund haben keinen Zugriff auf weitere Abteilungen. Geschäftsleitung und\nAdministratoren haben Zugriff auf alle Abteilungen und Funktionen.\n\nIn der Combobox 'Abteilungsname' wird eine Abteilung ausgewählt und deren Daten\nmit Klick auf den Button 'Abteilung laden' geladen.\n\nDie Daten zum aktuellen Abteilungsleiter und den Kapazitäten für die nächsten\ndrei Jahre werden hier angezeigt.\n\nDer Abteilungsleiter kann hier nicht geändert werden. Dies ist nur über die\nBenutzerverwaltung möglich.\n\nEine Änderung an den Abteilungskapazitäten muss mit einem Klick auf 'Speichern'\nübernommen werden, dies wird mit der Meldung 'Die Daten wurden erfolgreich\ngespeichert' bestätigt. Mit dem Button 'Verwerfen' werden die Felder der\nAbteilungskapazitäten geleert. Alle drei Felder müssen allerdings ausgefüllt\nsein, um neu gespeichert werden zu können.\n\nÜber 'Neue Abteilung erstellen' können neue Abteilungen erstellt werden.\nEs öffnet sich dafür ein neues Fenster, in dem Abteilungsname und die\nAbteilungskapazitäten der nächsten drei Jahre eingetragen werden. Mit 'Ok' wird\ndie Abteilung angelegt, mit 'Abbrechen' wird der Vorgang beendet, ohne eine neue\nAbteilung anzulegen.\n\nDer Button 'Diese Abteilung löschen' ermöglicht die aktuell geladene Abteilung\nzu löschen. Nach einer Bestätigungsabfrage wird die Abteilung gelöscht.\n\n";
            return meintext;
        }

        public string GetBenutzerinformationen()
        {
            string meintext = "Unter Account → Benutzerinformationen finden Sie eine Übersicht über ihre\nöffentlichen Benutzerdaten: Ihren eingetragenen Vornamen, Nachnamen,\nBenutzernamen (zur Anmeldung) und Ihre Email-Adresse.\n\n";
            return meintext;
        }

        public string GetBenutzerverwaltung()
        {
            string meintext = "Unter Admin → Benutzerverwaltung kann man alle Benutzer des Programms verwalten.\nDieses Menü ist nur für Geschäftsleitung und Administratoren verfügbar.\n\nEs gibt zwei Möglichkeiten, einen Benutzer zu laden: Entweder gibt man seinen\nBenutzernamen in das Feld 'Benutzername' ein und klickt auf den Button 'Benutzer\n laden', oder man wählt ihn nach einem Klick auf 'Benutzer Liste' im sich neu\nöffnenden Fenster aus. In beiden Fällen werden die Benutzerdaten im unteren Teil\ndes Fensters geladen.\n\nUm einen neuen Benutzer erstellen zu können, müssen alle Felder im unteren Teil\nleer sein. Wenn die Benutzerverwaltung neu geöffnet wurde, ist dies der Fall.\nAlternativ werden mit einem Klick auf den Button 'Verwerfen' ebenfalls alle\nFelder geleert. Wenn alle Felder leer sind, können die Daten des neuen Benutzers\neingetragen werden und dieser mittels 'Benutzer Speichern' angelegt werden.\n\nWenn ein Benutzer geladen ist, kann dieser über den Button 'Benutzer löschen'\ngelöscht werden. Der aktuell eingeloggte Benutzer kann nicht gelöscht werden.\n\nDie Daten eines Benutzers können geändert werden, nachdem dieser geladen wurde.\nNur der Benutzername kann nicht verändert werden. Änderungen werden mittels\n'Benutzer Speichern' übernommen.\n\n";
            return meintext;
        }

        public string GetPasswortAendern()
        {
            string meintext = "Unter Account → Passwort ändern können Sie ihr Passwort durch ein neues\nersetzen. Geben Sie dazu zunächst Ihr altes Passwort ein und danach in die\njeweiligen Textfelder das Neue und dessen Wiederholung. Mit einem Klick auf den\nButton 'Passwort ändern' wird das neue Passwort gesetzt.\n\nWichtig: Das Passwort darf nur aus Zahlen bestehen! Andere Zeichen sind nicht\nmöglich. Wenn die Änderung erfolgreich war, werden Sie mit dem Hinweis 'Passwort\n wurde geändert' darauf hingewiesen.\n\nBei Fehlern werden Sie mit einer Fehlermeldung darauf hingewiesen. Versuchen Sie\ndie Änderung dann erneut mit korrekten Daten.\n\n";
            return meintext;
        }
    }
}

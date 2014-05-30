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
            string meintext = @"{\rtf1 Geben Sie ihren Benutzernamen und anschließend ihr Passwort in die zugehörigen\par Felder ein. Mit einem Klick auf den Button {\b 'Login'} melden Sie sich an.\par \par Wenn sie einen unbekannten Benutzernamen oder ein falsches Passwort eingegeben\par haben, weist Supernova Sie darauf hin.\par \par Wenn Sie sich nicht anmelden können, wenden Sie sich an Ihren Administrator.}";
            return meintext;
        }

        public string GetAbteilungskapazitaet()
        {
            string meintext = @"{\rtf1 Unter {\b 'Admin'} → {\b 'Abteilungskapazität'} können Sie die Kapazitäten der eingetragenen\par Abteilungen einsehen, neue Abteilungen erstellen und bestehende Abteilungen\par löschen.\par \par Abteilungsleiter können nur die Kapazitäten ihrer eigenen Abteilung ändern\par und haben keinen Zugriff auf weitere Abteilungen. Geschäftsleitung und\par Administratoren haben Zugriff auf alle Abteilungen und Funktionen.\par \par In der Combobox {\b 'Abteilungsname'} wird eine Abteilung ausgewählt und deren Daten\par mit Klick auf den Button {\b 'Abteilungsname'} geladen.\par \par Die Daten zum aktuellen Abteilungsleiter und den Kapazitäten für die nächsten\par drei Jahre werden hier angezeigt.\par \par Der Abteilungsleiter kann hier nicht geändert werden. Dies ist nur über die\par Benutzerverwaltung möglich.\par \par Eine Änderung an den Abteilungskapazitäten muss mit einem Klick auf {\b 'Speichern'}\par übernommen werden, dies wird mit der Meldung {\b 'Die Daten wurden erfolgreich'}\par {\b 'gespeichert'} bestätigt. Mit dem Button {\b 'Verwerfen'} werden die Felder der\par Abteilungskapazitäten geleert. Alle drei Felder müssen allerdings ausgefüllt\par sein, um neu gespeichert werden zu können.\par \par Über {\b 'Neue Abteilung erstellen'} können neue Abteilungen erstellt werden.\par Es öffnet sich dafür ein neues Fenster, in dem Abteilungsname und die\par Abteilungskapazitäten der nächsten drei Jahre eingetragen werden. Mit {\b 'Ok'} wird\par die Abteilung angelegt, mit {\b 'Abbrechen'} wird der Vorgang beendet, ohne eine neue\par Abteilung anzulegen.\par \par Der Button {\b 'Diese Abteilung löschen'} ermöglicht die aktuell geladene Abteilung\par zu löschen. Nach einer Bestätigungsabfrage wird die Abteilung gelöscht.}";
            return meintext;
        }

        public string GetBenutzerinformationen()
        {
            string meintext = @"{\rtf1 Unter {\b 'Account'} → {\b 'Benutzerinformationen'} finden Sie eine Übersicht über ihre\par öffentlichen Benutzerdaten: Ihren eingetragenen Vornamen, Nachnamen,\par Benutzernamen (zur Anmeldung) und Ihre Email-Adresse.}";
            return meintext;
        }

        public string GetBenutzerverwaltung()
        {
            string meintext = @"{\rtf1 Unter {\b 'Login'} → {\b 'Benutzerverwaltung'} kann man alle Benutzer des Programms verwalten.\par Dieses Menü ist nur für Geschäftsleitung und Administratoren verfügbar.\par \par Es gibt zwei Möglichkeiten, einen Benutzer zu laden: Entweder gibt man seinen\par Benutzernamen in das Feld {\b 'Benutzername'} ein und klickt auf den Button {\b 'Benutzer}\par {\b laden'}, oder man wählt ihn nach einem Klick auf {\b 'Benutzer Liste'} im sich neu\par öffnenden Fenster aus. In beiden Fällen werden die Benutzerdaten im unteren Teil\par des Fensters geladen.\par \par Um einen neuen Benutzer erstellen zu können, müssen alle Felder im unteren Teil\par leer sein. Wenn die Benutzerverwaltung neu geöffnet wurde, ist dies der Fall.\par Alternativ werden mit einem Klick auf den Button {\b 'Verwerfen'} ebenfalls alle\par Felder geleert. Wenn alle Felder leer sind, können die Daten des neuen Benutzers\par eingetragen werden und dieser mittels {\b 'Benutzer Speichern'} angelegt werden.\par \par Wenn ein Benutzer geladen ist, kann dieser über den Button {\b 'Benutzer löschen'}\par gelöscht werden. Der aktuell eingeloggte Benutzer kann nicht gelöscht werden.\par \par Die Daten eines Benutzers können geändert werden, nachdem dieser geladen wurde.\par Nur der Benutzername kann nicht verändert werden. Änderungen werden mittels\par {\b 'Benutzer Speichern'} übernommen.}";
            return meintext;
        }

        public string GetPasswortAendern()
        {
            string meintext = @"{\rtf1 Unter Account → Passwort ändern können Sie ihr Passwort durch ein neues\par ersetzen. Geben Sie dazu zunächst Ihr altes Passwort ein und danach in die\par jeweiligen Textfelder das Neue und dessen Wiederholung. Mit einem Klick auf den\par Button {\b 'Passwort ändern'} wird das neue Passwort gesetzt.\par \par {\b Wichtig:} Das Passwort darf nur aus Zahlen bestehen! Andere Zeichen sind nicht\par möglich. Wenn die Änderung erfolgreich war, werden Sie mit dem Hinweis {\b 'Passwort}\par {\b wurde geändert'} darauf hingewiesen.\par \par Bei Fehlern werden Sie mit einer Fehlermeldung darauf hingewiesen. Versuchen Sie\par die Änderung dann erneut mit korrekten Daten.}";
            return meintext;
        }
    }
}

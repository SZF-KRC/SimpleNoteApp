using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace SimpleNoteApp
{
    internal class WrongInput
    {

        private TextBox _txtInput;
        private ChangeStyle _changeStyle;

        /// <summary>
        /// Konstruktor der Klasse, der die TextBoxen und ChangeStyle initialisiert
        /// </summary>
        /// <param name="txtInput">TextBox für den Namen des Aufgabe</param>
        public WrongInput(TextBox txtInput)
        {
            _txtInput = txtInput;
            _changeStyle = new ChangeStyle(txtInput);// Initialisiert die ChangeStyle-Instanz
        }

        /// <summary>
        /// Überprüfung der Richtigkeit des eingegebenen Aufgaben. Die Aufgabe darf keine 
        /// Zahlen enthalten und die Größe des Aufgabe muss mehr als 3 Buchstaben betragen
        /// </summary>
        /// <param name="entry">Der eingegebene Name</param>
        /// <returns>True, wenn die Aufgabe korrekt ist, andernfalls False</returns>
        public bool IsCorrectName(string entry)
        {
            if (entry.Any(char.IsDigit))// Überprüft, ob die Aufgabe Zahlen enthält
            {
                _changeStyle.ChangeColorTXT("txtInput", "no");// Ändert die Farbe der TextBox zu rot
                MessageBox.Show("Ungültige Eingabe. Schreiben Sie nur Alphabete für Aufgabe");// Zeigt eine Fehlermeldung an
                _txtInput.Clear();// Löscht den Inhalt der TextBox
                return false;
            }
            else if (entry.Length < 3)
            {
                _changeStyle.ChangeColorTXT("txtInput", "no");// Ändert die Farbe der TextBox zu rot
                MessageBox.Show("Die Aufgabe ist zu kurz, bitte geben Sie minimum Wort mit drei Buchstaben ");
                _txtInput.Clear();// Löscht den Inhalt der TextBox
                return false;
            }
            _changeStyle.ChangeColorTXT("txtInput", "yes");// Ändert die Farbe der TextBox zu weiß
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace SimpleNoteApp
{
    internal class ChangeStyle
    {
        private TextBox _txtInput;

        /// <summary>
        /// Konstruktor der Klasse, der die TextBoxen initialisiert
        /// </summary>
        /// <param name="txtInput">TextBox für input Aufgabe</param>
        public ChangeStyle(TextBox txtInput)
        {
            _txtInput = txtInput;
        }

        /// <summary>
        /// Methode zur Änderung der TextBox-Farbe basierend auf der Validität der Eingabe
        /// </summary>
        /// <param name="txtForm">Der Typ der TextBox ("txtInput")</param>
        /// <param name="isCorrect">Der Status der Validität ("yes" oder "no")</param>
        public void ChangeColorTXT(string txtForm, string isCorrect)
        {
            switch (txtForm)
            {
                case "txtInput":
                    switch (isCorrect)
                    {
                        // Wechselt die Farbe der Name-TextBox basierend auf isCorrect
                        case "no":
                            _txtInput.Background = new SolidColorBrush(Colors.Red);
                            _txtInput.Foreground = new SolidColorBrush(Colors.White);
                            break;
                        case "yes":
                            _txtInput.Background = new SolidColorBrush(Colors.White);
                            _txtInput.Foreground = new SolidColorBrush(Colors.Black);
                            break;
                    }
                    break;           
            }
        }
    }
}

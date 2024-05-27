using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SimpleNoteApp
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        WrongInput _wrongInput;

        /// <summary>
        /// Konstruktor für MainWindow Klasse.
        /// Initialisiert die Komponente und erstellt eine neue Instanz von WrongInput.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            _wrongInput = new WrongInput(txtInput);
        }

        /// <summary>
        /// Ereignishandler für den Klick auf die Hinzufügen-Schaltfläche.
        /// Überprüft, ob der eingegebene Name korrekt ist, und fügt ihn der Liste hinzu.
        /// </summary>
        /// <param name="sender">Das Objekt, das das Ereignis ausgelöst hat.</param>
        /// <param name="e">Die Daten des Ereignisses.</param>
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if(_wrongInput.IsCorrectName(txtInput.Text))
            {
                lstList.Items.Add(txtInput.Text);
                txtInput.Clear();//Bereinigen der Texteingabe
                lstList.SelectedItem = null;//die Markierung des Artikels im Brief ist deaktiviert
            }
        }

        /// <summary>
        /// Ereignishandler für den Klick auf die Löschen-Schaltfläche.
        /// Entfernt das ausgewählte Element aus der Liste.
        /// </summary>
        /// <param name="sender">Das Objekt, das das Ereignis ausgelöst hat.</param>
        /// <param name="e">Die Daten des Ereignisses.</param>
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if(lstList.Items.Count == 0 || lstList.SelectedItem == null) { return; }
            lstList.Items.Remove(lstList.SelectedItem);
        }
    }
}

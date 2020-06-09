using System;
using System.Collections.Generic;
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

namespace MomentoPattern
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Originator originator = new Originator();
        CareTaker<string> careTaker = new CareTaker<string>();
        int currentStatement = -1, saveFiles=0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string text = theStatement.Text;
            originator.SetText(text);
            careTaker.SaveMomento(originator.StoreInMomento());
            saveFiles++;
            currentStatement++;
            btnUndo.IsEnabled = true;
        }

        private void btnUndo_Click(object sender, RoutedEventArgs e)
        {
            if (currentStatement >= 0)
            {
                currentStatement--;
                theStatement.Text = originator.RestoreFromMomento(careTaker.GetMomento(currentStatement));
                btnRedo.IsEnabled = true;
            }
            else
            {
                btnUndo.IsEnabled = false;
            }
        }

        private void btnRedo_Click(object sender, RoutedEventArgs e)
        {
            if ((saveFiles - 1) > currentStatement)
            {
                currentStatement++;
                theStatement.Text = originator.RestoreFromMomento(careTaker.GetMomento(currentStatement));
                btnRedo.IsEnabled = true;
            }
            else
                btnRedo.IsEnabled = false;

            btnUndo.IsEnabled = true;
        }
    }
}

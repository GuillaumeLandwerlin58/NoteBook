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
using System.Windows.Shapes;

namespace NoteBook
{
    /// <summary>
    /// Logique d'interaction pour EditUnit.xaml
    /// </summary>
    public partial class EditUnit : Window
    {
        private Logic.NoteBook n;
        public EditUnit(Logic.NoteBook n)
        {
            this.n = n;
            InitializeComponent();
            DrawUnits();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void addUnit(object sender, RoutedEventArgs e)
        {
            
        }

        private void DrawUnits()
        {
            var list = n.listUnits();
            units.Items.Clear();
            foreach (var item in list)
                units.Items.Add(item);
        }
    }
}

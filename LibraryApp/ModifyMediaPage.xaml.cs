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

namespace LibraryApp
{
    /// <summary>
    /// Interaction logic for ModifyMediaPage.xaml
    /// </summary>
    public partial class ModifyMediaPage : Page
    {
        Media toModify;
        object previousContent;

        public ModifyMediaPage(Media _toModify, object _previousContent)
        {
            InitializeComponent();
            toModify = _toModify;
            previousContent = _previousContent;
            SetInitialValues();
        }

        private void SetInitialValues()
        {
            name.Text = toModify.Title;
            type.Text = toModify.MediaType;
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            toModify.ModifyFields(name.Text, type.Text);
            ((MainWindow)(Application.Current.MainWindow)).RefreshMediaGrid();
            Application.Current.MainWindow.Content = previousContent;
        }
    }
}

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
    /// Interaction logic for ModifyMemberPage.xaml
    /// </summary>
    public partial class ModifyMemberPage : Page
    {
        LibraryMember toModify;
        object previousContent;

        public ModifyMemberPage(LibraryMember _toModify, object _previousContent)
        {
            InitializeComponent();
            toModify = _toModify;
            previousContent = _previousContent;
            SetInitialValues();
        }

        private void SetInitialValues()
        {
            name.Text = toModify.Name;
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            toModify.ModifyFields(name.Text);
            ((MainWindow)(Application.Current.MainWindow)).RefreshMemberGrid();
            Application.Current.MainWindow.Content = previousContent;
        }
    }
}

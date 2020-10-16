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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            mediaGrid.ItemsSource = Library.media;
            memberGrid.ItemsSource = Library.member;
        }

        public void RefreshMemberGrid()
        {
            memberGrid.ItemsSource = Library.member.ToList();
        }

        public void RefreshMediaGrid()
        {
            mediaGrid.ItemsSource = Library.media.ToList();
        }

        private void LentButton_Click(object sender, RoutedEventArgs e)
        {
            if ((memberGrid.SelectedValue != null) && (mediaGrid.SelectedValue != null))
            {
                LibraryMember md = (LibraryMember)(memberGrid.SelectedItem);
                Media m = (Media)(mediaGrid.SelectedItem);
                if (m.MemberBorrowMedia == null)
                {
                    m.MemberBorrowMedia = md.Name;
                    m.IndicateStatus = true;
                    mediaGrid.ItemsSource = null;
                    mediaGrid.ItemsSource = Library.media;
                    MessageBox.Show("This media is lented by " + m.MemberBorrowMedia);
                }
                else
                {
                    MessageBox.Show("This Media is already lented. Please select another media.");
                }
            }
            else
            {
                MessageBox.Show("Select Member and Media both.");
            }
        }


        private void ReturnButton_Click(object sender, RoutedEventArgs e)
        {
            if ((mediaGrid.SelectedValue != null))
            {
                LibraryMember md = (LibraryMember)(memberGrid.SelectedItem);
                Media m = (Media)(mediaGrid.SelectedItem);
                if (m.MemberBorrowMedia != null)
                {
                    m.MemberBorrowMedia = null;
                    m.IndicateStatus = false;
                    mediaGrid.ItemsSource = null;
                    mediaGrid.ItemsSource = Library.media;
                    MessageBox.Show("This media is return by " + md.Name);
                }
                else
                {
                    MessageBox.Show("This media is not lented yet. ");
                }
            }
            else
            {
                MessageBox.Show("Select media to return first.");
            }
        }
       
        private void ModifyMemberButton_Click(object sender, RoutedEventArgs e)
        {
            ModifyMemberPage modifyMemberPage;
            if ((LibraryMember)(memberGrid.SelectedItem) != null)
            {
                modifyMemberPage = new ModifyMemberPage((LibraryMember)(memberGrid.SelectedItem), this.Content);
                this.Content = modifyMemberPage;
            }
            else
            {
                MessageBox.Show("Select Member to Modify.");
            }
        }

        private void ModifyMediaButton_Click(object sender, RoutedEventArgs e)
        {
            ModifyMediaPage modifyMediaPage;
            if (mediaGrid.SelectedValue != null)
            {
                modifyMediaPage = new ModifyMediaPage((Media)(mediaGrid.SelectedItem), this.Content);
                this.Content = modifyMediaPage;
            }
            else
            {
                MessageBox.Show("Select Media to Modify.");
            }
        }

        private void MediaInfoButton_Click(object sender, RoutedEventArgs e)
        {
            if (mediaGrid.SelectedValue != null)
            {
                Media m = (Media)(mediaGrid.SelectedItem);
                if (m.MemberBorrowMedia != null)
                {
                    MessageBox.Show(m.MediaInfo());
                }
                else
                {
                    MessageBox.Show("First lent media by member");
                }
            }
            else
            {
                MessageBox.Show("Select Media");
            }
        }

        private void MemberInfoButton_Click(object sender, RoutedEventArgs e)
        {
            if ((memberGrid.SelectedValue != null) && (mediaGrid.SelectedValue != null))
            {
                LibraryMember md = (LibraryMember)(memberGrid.SelectedItem);
                Media m = (Media)(mediaGrid.SelectedItem);
                if (m.MemberBorrowMedia == null)
                {
                    MessageBox.Show("Lent this Media first.");
                }
                else
                {
                    MessageBox.Show(m.Title + " lented by " + md.MemberInfo());
                }
            }
            else
            {
                MessageBox.Show("Select Member and Media both.");
            }
        }
    }
}

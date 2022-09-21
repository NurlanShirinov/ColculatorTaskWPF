using System;
using System.Collections.Generic;
using System.Data;
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
using static System.Net.Mime.MediaTypeNames;

namespace ColculatorTaskWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
            foreach (UIElement el in GroupButton.Children)
            {
                if (el is Button)
                {
                    ((Button)el).Click += ButtonClick;
                }
            }
        }
        private void ButtonClick(object sender, RoutedEventArgs e)
        {

            string textButton = ((Button)e.OriginalSource).Content.ToString();

            if (textButton == "C")
            {
                txtBlock.Text = txtBlock.Text.Substring(txtBlock.Text.Length);
            }
            else if (textButton == "=")
            {
                txtBlock.Text = new DataTable().Compute(txtBlock.Text, null).ToString();
            }
            else txtBlock.Text += textButton;
        }

    }
}

using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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
using System.Xml.Serialization;
using WpfApplicationForInterface.Data;

namespace WpfApplicationForInterface
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //Binding binding = BindingOperations.GetBinding(myTextBlock, TextBlock.TextProperty);
            Binding binding = new Binding();
            binding.ElementName = "myTextBox";
            binding.Path = new PropertyPath("Text");
            myTextBlock.SetBinding(TextBlock.TagProperty, binding);
        }

        private void Button_Shifrovka(object sender, RoutedEventArgs e)
        {
            string text = myTextBlock.Text;
            int TypeOfEnicrypt = enicrypt.SelectedIndex;
        }

        public EnicryptionText GetObject()
        {
            MD5 md5Hasher = MD5.Create();
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(myTextBlock.Text));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return new EnicryptionText
            {
                Text = myTextBlock.Text,
                Hash = sBuilder.ToString()
            };
        }

        private void Button_Rashifrovka(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Create(object sender, RoutedEventArgs e)
        {
            myTextBlock.Text = "";
            keyBox.Text = "";
        }

        private void MenuItem_Open(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Save(object sender, RoutedEventArgs e)
        {
            var sfd = new SaveFileDialog() { Filter = "*.secret|*.secret" };
            if ((bool)sfd.ShowDialog(this))
            {
                var data = GetObject();
                var xs = new XmlSerializer(typeof(EnicryptionText));
                using (var fileStream = File.Create(sfd.FileName))
                {
                    xs.Serialize(fileStream, data);
                }
            }
        }

        private void MenuItem_Exit(object sender, RoutedEventArgs e)
        {

        }
    }
}

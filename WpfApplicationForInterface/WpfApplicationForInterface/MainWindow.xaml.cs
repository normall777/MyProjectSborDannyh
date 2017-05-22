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
            string key = keyBox.Text;
            string shifr;
            if (key.Length == 0)
            {
                MessageBox.Show("Ключ не может быть пустым", "Ошибка");
                return;
            }
            int TypeOfEnicrypt = enicrypt.SelectedIndex;
            if (TypeOfEnicrypt == 0)
            {
                if (ProverkaPerestanovka(key))
                {
                    shifr = ShifrPerestanovka(text, key);
                    myTextBlock.Text = shifr;
                }
            }



            if (TypeOfEnicrypt == 1)
            {
                myTextBlock.Text = ShifrGronsveld(text, key);
            }


            if (TypeOfEnicrypt == 2)
            {
                myTextBlock.Text = ShifrZesar(text, key);
            }

        }

        private void Button_Rashifrovka(object sender, RoutedEventArgs e)
        {
            string text = myTextBlock.Text;
            string key = keyBox.Text;
            if (key.Length == 0)
            {
                MessageBox.Show("Ключ не может быть пустым", "Ошибка");
                return;
            }
            int TypeOfEnicrypt = enicrypt.SelectedIndex;
            if (TypeOfEnicrypt == 0)
            {
                if (ProverkaPerestanovka(key))
                {
                    myTextBlock.Text = RashifrPerestanovka(text, key);
                }
            }
            if (TypeOfEnicrypt == 1)
            {
                myTextBlock.Text = RashifrGronsveld(text, key);
            }


            if (TypeOfEnicrypt == 2)
            {
                myTextBlock.Text = RashifrZesar(text, key);
            }
            
        }

        private string ShifrGronsveld(string text, string key)
        {
            string shifr="";
            if (ProverkaFormatInt(key))
            {
                int colvoSlogov = text.Length / key.Length;
                if (text.Length % key.Length != 0) colvoSlogov++;
                for (int i=0; i < colvoSlogov; i++)
                {
                    for (int j = 0; j < key.Length; j++)
                    {
                        if (i * key.Length + j < text.Length) { 
                            shifr += (char)(text[i * key.Length + j] + Convert.ToInt32(key[j].ToString()));
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            return shifr;
        }

        private string RashifrGronsveld(string text, string key)
        {
            string rashifr = "";
            if (ProverkaFormatInt(key))
            {
                int colvoSlogov = text.Length / key.Length;
                if (text.Length % key.Length != 0) colvoSlogov++;
                for (int i=0; i < colvoSlogov; i++)
                {
                    for (int j = 0; j < key.Length; j++)
                    {
                        if (i * key.Length + j < text.Length)
                        {
                            rashifr += (char)(text[i * key.Length + j] - Convert.ToInt32(key[j].ToString()));
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            return rashifr;
        }

        private bool ProverkaFormatInt(string key)
        {
            long a;
            if (!Int64.TryParse(key, out a))
            {
                MessageBox.Show("Неправильный формат ключа", "Ошибка");
                return false;
            }
            return true;
        }

        public EnicryptionText GetObject()
        {
            EnicryptionText eniText = (EnicryptionText)this.Resources["MyText"];
            string text = eniText.TextMsg;
            string hash = HashOfText(text);
            return new EnicryptionText
            {
                TextMsg = myTextBlock.Text,
                Hash = hash
            };
        }

        private string HashOfText(string text)
        {
            MD5 md5Hasher = MD5.Create();
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(text));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

        private void MenuItem_Create(object sender, RoutedEventArgs e)
        {
            if (myTextBlock.Text!="" || keyBox.Text != "")
            {
                if (MessageBox.Show("Вы уверены, что хотите создать новый документ?", "Вопрос", MessageBoxButton.OKCancel) == MessageBoxResult.Cancel)
                    return; 
            }
            myTextBlock.Text = "";
            keyBox.Text = "";
        }

        private void MenuItem_Open(object sender, RoutedEventArgs e)
        {
            keyBox.Text = "";
            keyBox.Focus();
            var ofd = new OpenFileDialog() { Filter = "*.secret|*.secret" };
            EnicryptionText data;
            if ((bool)ofd.ShowDialog())
            {
                var xs = new XmlSerializer(typeof(EnicryptionText));
                using (var file = File.OpenRead(ofd.FileName))
                {
                    data = (EnicryptionText)xs.Deserialize(file);
                }
                var hash = HashOfText(data.TextMsg);
                if (hash == data.Hash)
                {
                    EnicryptionText eniText = (EnicryptionText)this.Resources["MyText"];
                    eniText.TextMsg = data.TextMsg;
                }
                else
                {
                    if (MessageBox.Show("Хэш не совпадает. Сообщение было изменено. Продолжить?", "Ошибка хэша", MessageBoxButton.YesNo)==MessageBoxResult.No)
                    {
                        return;
                    }
                    EnicryptionText eniText = (EnicryptionText)this.Resources["MyText"];
                    eniText.TextMsg = data.TextMsg;
                }
            }
            
        }

        //private void SetObject(EnicryptionText data)
        //{
        //    EnicryptionText eniText = (EnicryptionText)this.Resources["MyText"];
        //    eniText.TextMsg = data.TextMsg;
        //}

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
            this.Close();
        }

        private bool ProverkaPerestanovka(string key)
        {
            int flag = 0;
            int sum = 0;
            if (!ProverkaFormatInt(key)) return false;
            for (int i = 0; i < key.Length; i++)
            {
                sum += i+1;
                flag += Convert.ToInt32(key[i].ToString());
            }
            if (sum != flag)
            {
                MessageBox.Show("Неправильный формат ключа", "Ошибка");
                return false;
            }
            return true;
        }

        private string ShifrPerestanovka(string text, string key)
        {
            int colvoSlogov = text.Length / key.Length;
            if (text.Length % key.Length != 0) colvoSlogov++;
            string shifr = "";
            for (int i = 0; i < colvoSlogov; i++)
            {
                for (int j = 0; j < key.Length; j++)
                {

                    int lol = Convert.ToInt32(key[j].ToString()) - 1 + (i * key.Length);
                    if ((Convert.ToInt32(key[j].ToString()) - 1 + (i * key.Length)) >= text.Length)
                    {
                        shifr += ' ';
                    }
                    else {
                        shifr += text[Convert.ToInt32(key[j].ToString()) - 1 + i * key.Length];
                    }
                }
            }
            return shifr;
        }

        private string RashifrPerestanovka(string text, string key)
        {
            int colvoSlogov = text.Length / key.Length;
            char[] ras = new char[key.Length];
            string shifr = "";
            for (int i = 0; i < colvoSlogov; i++)
            {
                for (int j = 0; j < key.Length; j++)
                {
                    ras[Convert.ToInt32(key[j].ToString()) - 1] = text[j + (i * key.Length)];
                }
                foreach (var ch in ras)
                {
                    shifr += ch;
                }
            }
            return shifr;
        }

        private string ShifrZesar(string text, string key)
        {
            string shifr = "";
            if (ProverkaFormatInt(key))
            {
                int iKey = Convert.ToInt32(key);
                foreach (var bukva in text)
                {
                    shifr += (char)(bukva + iKey);
                }
            }
            return shifr;
        }

        private string RashifrZesar(string text, string key)
        {
            string rashifr = "";
            if (ProverkaFormatInt(key))
            {
                int iKey = Convert.ToInt32(key);
                foreach (var bukva in text)
                {
                    rashifr += (char)(bukva - iKey);
                }
            }
            return rashifr;
        }
    }
}

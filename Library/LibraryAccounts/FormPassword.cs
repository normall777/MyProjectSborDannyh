using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryAccounts
{
    public partial class FormPassword : Form
    {
        public FormPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxPassword1.Text == textBoxPassword2.Text)
            {
                var mydocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Library";
                if (!Directory.Exists(mydocs))
                {
                    Directory.CreateDirectory(mydocs);
                    Directory.CreateDirectory(mydocs + "\\hash").Attributes = FileAttributes.Directory | FileAttributes.Hidden;
                }
                else if (!Directory.Exists(mydocs + "\\hash"))
                {
                    Directory.CreateDirectory(mydocs + "\\hash").Attributes = FileAttributes.Directory | FileAttributes.Hidden; 
                }

                if (File.Exists(mydocs + "\\hash"+textBoxLogin.Text+".hlb"))
                {
                    MessageBox.Show("Пользователь с таким логином уже существует", "Ошибка");
                }
                else
                {

                    MD5 md5Hasher = MD5.Create();
                    byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(textBoxPassword2.Text));
                    StringBuilder sBuilder = new StringBuilder();

                    for (int i = 0; i < data.Length; i++)
                    {
                        sBuilder.Append(data[i].ToString("x2"));
                    }
                    string hash = sBuilder.ToString();

                    StreamWriter SW = new StreamWriter(new FileStream(mydocs + "\\hash\\" + textBoxLogin.Text + ".hlb", FileMode.Create, FileAccess.Write));
                    SW.Write(hash);
                    SW.Close();
                    //File.Create(mydocs + "\\hash"+textBoxLogin.Text + ".hlb");
                    //var file = File.OpenWrite(mydocs + "\\hash" + textBoxLogin.Text + "hlb");
                    //file.Write();
                    MessageBox.Show("Пользователь успешно зарегистрирован", "Успех");
                    textBoxLogin.Text = "";
                    textBoxPassword1.Text = "";
                    textBoxPassword2.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Пароли не совпадают", "Ошибка");
            }
        }
    }
}

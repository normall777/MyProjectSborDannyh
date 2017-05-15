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

namespace Library
{
    public partial class Authentication : Form
    {
        public Authentication()
        {
            InitializeComponent();
            var mydocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Library";
            if (!Directory.Exists(mydocs))
            {
                Directory.CreateDirectory(mydocs);
                Directory.CreateDirectory(mydocs + "\\hash").Attributes = FileAttributes.Directory | FileAttributes.Hidden; ;
            }
        }
        Form form = null;
        public Authentication(Object o)
        {
            InitializeComponent();
            if (o is KabOfLibrarian)
            {
                form = (KabOfLibrarian)o;
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Введите логин и пароль","Ошибка ввода");
                return;
            }
            MD5 md5Hasher = MD5.Create();
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(textBoxPassword.Text));
            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            var mydocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Library\\hash\\";
            
            string path = mydocs + textBoxLogin.Text + ".hlb";
            if (File.Exists(path))
            {
                StreamReader file = File.OpenText(@path);
                //string hashFile = null;
                string hashFile = file.ReadLine();
                //string login;
                if (hashFile == sBuilder.ToString())
                {
                    KabOfLibrarian kabOfLibrarian = new KabOfLibrarian(this, textBoxLogin.Text);
                    this.Hide();
                    textBoxLogin.Text = "";
                    textBoxPassword.Text = "";
                    kabOfLibrarian.Show();
                }
                else
                {
                    MessageBox.Show("Ошибка при вводе логина пользователя или пароля", "Ошибка");
                }
            }
            else
            {
                MessageBox.Show("Ошибка при вводе логина пользователя или пароля", "Ошибка");
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new AboutBox1();
            form.ShowDialog(this);
        }

        protected override void OnDeactivate(EventArgs e)
        {
            base.OnDeactivate(e);
        }

        private void открытьСписокКнигToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CollectOfBooks collectOfBooks = new CollectOfBooks();
            collectOfBooks.ShowDialog();
        }
    }
}

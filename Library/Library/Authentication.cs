using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            KabOfLibrarian kabOfLibrarian = new KabOfLibrarian(this,textBoxLogin.Text);
            this.Hide();
            textBoxLogin.Text = "";
            textBoxPassword.Text = "";
            kabOfLibrarian.Show();
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

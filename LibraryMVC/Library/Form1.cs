using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Linq;
using LibraryModel;

namespace Library
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student> { };
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LicenseValidator.CheckIfLicenseValid();
            if (LicenseValidator.HasLicense)
            {
                //MessageBox.Show("Лицензия владельца программы: " + LicenseValidator.ToWhom);
                buttonOpen.Enabled = LicenseValidator.CanRead;
                buttonSave.Enabled = LicenseValidator.CanWrite;
                label9.Text = LicenseValidator.ToWhom;
                label9.ForeColor = System.Drawing.Color.Green;
                button1.Visible = false;
            }
            else
            {
                var result = MessageBox.Show(this, $"{LicenseValidator.UserMessage}. Продолжить?", "Ошибка лицензии", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    Close();
                    return;
                }
                buttonOpen.Enabled = false;
                buttonSave.Enabled = false;
                button1.Visible = true;
                label9.Text = "Без лицензии";
                label9.ForeColor = System.Drawing.Color.Red;
                buttonAddUser.Enabled = false;
                numericUpDownSumOfBooks.Enabled = false;
            }

        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            var form = new FormForUsers();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                listBoxUsers.Items.Add(form.GetObject());
            }
            ProverkaNalichia();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCheat_Click(object sender, EventArgs e)
        {
            FormForUsers form = new FormForUsers(GetObject().student[listBoxUsers.SelectedIndex]);
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                var student = GetObject();
                listBoxUsers.Items[listBoxUsers.SelectedIndex] = form.GetObject();
            }
        }
        Book GetObject()
        {
            return new Book
            {
                Title = textBoxName.Text,
                Author = textBoxAuthor.Text,
                ISBN = maskedTextBoxISBN.Text,
                Izdatelstvo = textBoxIzdatelstvo.Text,
                SumOfBooks = Decimal.ToInt32(numericUpDownSumOfBooks.Value),
                Town = textBoxTown.Text,
                YearOfPublic = Decimal.ToInt32(numericUpDownYearOfPublic.Value),
                student = listBoxUsers.Items.OfType<Student>().ToList(),
                CountOfStudent = listBoxUsers.Items.OfType<Student>().Count()
            };
        }
        private void SetObject(Book data)
        {
            textBoxName.Text = data.Title;
            textBoxAuthor.Text = data.Author;
            textBoxTown.Text = data.Town;
            textBoxIzdatelstvo.Text = data.Izdatelstvo;
            maskedTextBoxISBN.Text = data.ISBN;
            numericUpDownSumOfBooks.Value = data.SumOfBooks;
            numericUpDownYearOfPublic.Value = data.YearOfPublic;
            listBoxUsers.Items.Clear();
            foreach (var item in data.student)
            {
                listBoxUsers.Items.Add(item);
            }
            ProverkaNalichia();
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog() { Filter = "*.lb|*.lb" };
            if (sfd.ShowDialog(this)== DialogResult.OK)
            {
                var data = GetObject();
                var xs = new XmlSerializer(typeof(Book));
                using (var fileStream = File.Create(sfd.FileName))
                {
                    xs.Serialize(fileStream, data);
                }
            }

        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog() { Filter = "*.lb|*.lb" };
            Book data;
            if (ofd.ShowDialog(this) == DialogResult.OK)
            {
                var xs = new XmlSerializer(typeof(Book));
                using (var file = File.OpenRead(ofd.FileName))
                {
                    data = (Book)xs.Deserialize(file);
                }
                SetObject(data);
            }
            buttonDeleteUser.Enabled = false;
            buttonCheat.Enabled = false;
        }

        private void ProverkaNalichia()
        {
            if (listBoxUsers.Items.Count >= numericUpDownSumOfBooks.Value)
            {
                labelNalichie.Text = "Нет в наличии";
                labelNalichie.ForeColor = System.Drawing.Color.Red;
                buttonAddUser.Enabled = false;
            }
            else
            {
                labelNalichie.Text = "В наличии";
                labelNalichie.ForeColor = System.Drawing.Color.Green;
                buttonAddUser.Enabled = true;
            }
            numericUpDownSumOfBooks.Minimum = listBoxUsers.Items.Count;
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            listBoxUsers.Items.RemoveAt(listBoxUsers.SelectedIndex);
            ProverkaNalichia();
            BlockDelAndCheat();
        }

        private void listBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxUsers.SelectedIndex != -1)
            {
                buttonDeleteUser.Enabled = true;
                buttonCheat.Enabled = true;
            }
            else
            {
                BlockDelAndCheat();
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            ProverkaNalichia();
        }

        private void numericUpDownSumOfBooks_ValueChanged(object sender, EventArgs e)
        {
            ProverkaNalichia();
        }


        private void BlockDelAndCheat()
        {
            buttonDeleteUser.Enabled = false;
            buttonCheat.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LicenseValidator.CheckIfLicenseValid();
            if (LicenseValidator.HasLicense)
            {
                //MessageBox.Show("Лицензия владельца программы: " + LicenseValidator.ToWhom);
                buttonOpen.Enabled = LicenseValidator.CanRead;
                buttonSave.Enabled = LicenseValidator.CanWrite;
                button1.Visible = false;
                label9.Text = LicenseValidator.ToWhom;
                label9.ForeColor = System.Drawing.Color.Green;
                buttonAddUser.Enabled = true;
                numericUpDownSumOfBooks.Enabled = true;
            }
            else
            {
                buttonOpen.Enabled = false;
                buttonSave.Enabled = false;
                button1.Visible = true;
                label9.Text = "Без лицензии";
                label9.ForeColor = System.Drawing.Color.Red;
            }
            
        }
    }


}

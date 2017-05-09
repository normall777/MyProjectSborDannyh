﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Linq;
using LibraryModel;

namespace Library
{
    public partial class KabOfLibrarian : Form
    {
        static bool exit;//С этой переменной можно сделать нормальный выход
        List<Student> students = new List<Student> { };//Хранит студентов на форме, позволяет сохранять
        public KabOfLibrarian()
        {
            InitializeComponent();
        }
        Authentication authentication = null;
        public KabOfLibrarian(Object o, string login)
        {
            InitializeComponent();
            if (o is Authentication)
            {
                authentication = (Authentication)o;
            }
            labelLogin.Text = $"Вы вошли как {login}";
        }

        protected override void OnDeactivate(EventArgs e)
        {
            //authentication.Show();
            base.OnDeactivate(e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //List<Student> studentsInDGV = new List<Student> { };
            exit = false;
            dataGridViewUsers.ContextMenuStrip = contextMenuStrip1;
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            AddUser();
        }

        private void AddUser()
        {
            var form = new AddEditUsers();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                dataGridViewUsers.Rows.Add();
                int numberOfUsers = Convert.ToInt32(dataGridViewUsers.Rows.Count.ToString()) - 1;
                var newStudent = form.GetObject();
                students.Add(newStudent);
                dataGridViewUsers.Rows[numberOfUsers].Cells[0].Value = newStudent.Name + " " + newStudent.Surname;
                dataGridViewUsers.Rows[numberOfUsers].Cells[1].Value = newStudent.NumberOfTicket;
                dataGridViewUsers.Rows[numberOfUsers].Cells[2].Value = newStudent.Vidacha.ToString("d");
                dataGridViewUsers.Rows[numberOfUsers].Cells[3].Value = newStudent.Sdacha.ToString("d");
            }
            ProverkaNalichia();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonCheat_Click(object sender, EventArgs e)
        {
            var numberOfNote = dataGridViewUsers.CurrentRow.Index;
            RedactUser(numberOfNote);
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
                student = students.ToList()
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
            students = data.student;
            dataGridViewUsers.Rows.Clear();
            int numberOfUsers = 0;
            dataGridViewUsers.Rows.Add(data.student.Count());
            foreach (var item in students)
            {
                dataGridViewUsers.Rows[numberOfUsers].Cells[0].Value = item.Name + " " + item.Surname;
                dataGridViewUsers.Rows[numberOfUsers].Cells[1].Value = item.NumberOfTicket;
                dataGridViewUsers.Rows[numberOfUsers].Cells[2].Value = item.Vidacha.ToString("d");
                dataGridViewUsers.Rows[numberOfUsers].Cells[3].Value = item.Sdacha.ToString("d");
                numberOfUsers++;
            }
            ProverkaNalichia();
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void SaveFile()
        {
            var mydocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var sfd = new SaveFileDialog() { Filter = "*.lb|*.lb" };
            if (sfd.ShowDialog(this) == DialogResult.OK)
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
            OpenFile();
        }

        private void OpenFile()
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
            //buttonDeleteUser.Enabled = false;
            //buttonCheat.Enabled = false;
            ProverkaNalichia();
        }

        private void ProverkaNalichia()
        {
            //if (listBoxUsers.Items.Count >= numericUpDownSumOfBooks.Value)
            if (students.Count >=numericUpDownSumOfBooks.Value)
            {
                labelNalichie.Text = "Нет в наличии";
                labelNalichie.ForeColor = System.Drawing.Color.Red;
                buttonAddUser.Enabled = false;
                toolStripMenuItemAddUser.Enabled = false;
                добавитьЧитателяToolStripMenuItem.Enabled = false;
            }
            else
            {
                labelNalichie.Text = "В наличии";
                labelNalichie.ForeColor = System.Drawing.Color.Green;
                buttonAddUser.Enabled = true;
                toolStripMenuItemAddUser.Enabled = true;
                добавитьЧитателяToolStripMenuItem.Enabled = true;
            }
            numericUpDownSumOfBooks.Minimum = students.Count;
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            var numberOfNote = dataGridViewUsers.CurrentRow.Index;
            delUser(numberOfNote);
        }

        private void delUser(int numberOfNote)
        {
            students.RemoveAt(numberOfNote);
            dataGridViewUsers.Rows.Remove(dataGridViewUsers.Rows[numberOfNote]);
            ProverkaNalichia();
            BlockDelAndCheat();
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
            if (dataGridViewUsers.RowCount == 0)
            {
                buttonDeleteUser.Enabled = false;
                buttonCheat.Enabled = false;
                редактироватьЧитателяToolStripMenuItem.Enabled = false;
                удалитьЧитателяToolStripMenuItem.Enabled = false;
                toolStripMenuItemDelUser.Enabled = false;
                toolStripMenuItemEditUser.Enabled = false;
            }
            else
            {
                buttonDeleteUser.Enabled = true;
                buttonCheat.Enabled = true;
                редактироватьЧитателяToolStripMenuItem.Enabled = true;
                удалитьЧитателяToolStripMenuItem.Enabled = true;
                toolStripMenuItemEditUser.Enabled = true;
                toolStripMenuItemDelUser.Enabled = true;
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new AboutBox1();
            form.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти?", "Выход", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Authentication authentification = new Authentication(this);
                this.Hide();
                authentication.Show();
            }
            
        }

        private void KabOfLibrarian_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (exit == false)
            {
                if (MessageBox.Show("Вы уверены, что хотите выйти?", "Выход", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else {
                    e.Cancel = false;
                    exit = true;
                    Application.Exit();
                }
            }
        }

        private void списокКнигToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CollectOfBooks collectOfBooks = new CollectOfBooks();
            collectOfBooks.ShowDialog();
        }

        private void добавитьЧитателяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUser();
        }

        private void редактироватьЧитателяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var numberOfNote = dataGridViewUsers.CurrentRow.Index;
            RedactUser(numberOfNote);
        }

        private void удалитьЧитателяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var numberOfNote = dataGridViewUsers.CurrentRow.Index;
            delUser(numberOfNote);
            
        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            buttonCheat.Enabled = true;
            buttonDeleteUser.Enabled = true;
        }

        private void RedactUser(int numberOfUsers)
        {
            AddEditUsers form = new AddEditUsers(GetObject().student[numberOfUsers]);
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                var newStudent = form.GetObject();
                dataGridViewUsers.Rows[numberOfUsers].Cells[0].Value = newStudent.Name + " " + newStudent.Surname;
                dataGridViewUsers.Rows[numberOfUsers].Cells[1].Value = newStudent.NumberOfTicket;
                dataGridViewUsers.Rows[numberOfUsers].Cells[2].Value = newStudent.Vidacha.ToString("d");
                dataGridViewUsers.Rows[numberOfUsers].Cells[3].Value = newStudent.Sdacha.ToString("d");
                students[numberOfUsers] = newStudent;
            }
        }

        private void dataGridViewUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var numberOfNote = dataGridViewUsers.CurrentRow.Index;
            RedactUser(numberOfNote);
        }

        private void dataGridViewUsers_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            BlockDelAndCheat();
        }

        private void toolStripMenuItemAddUser_Click(object sender, EventArgs e)
        {
            AddUser();
        }

        private void toolStripMenuItemEditUser_Click(object sender, EventArgs e)
        {
            var numberOfNote = dataGridViewUsers.CurrentRow.Index;
            RedactUser(numberOfNote);
        }

        private void toolStripMenuItemDelUser_Click(object sender, EventArgs e)
        {
            var numberOfNote = dataGridViewUsers.CurrentRow.Index;
            delUser(numberOfNote);
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            students.Clear();
            dataGridViewUsers.Rows.Clear();
            textBoxAuthor.Clear();
            textBoxIzdatelstvo.Clear();
            textBoxName.Clear();
            textBoxTown.Clear();
            maskedTextBoxISBN.Clear();
            numericUpDownYearOfPublic.Value = 2012;
            ProverkaNalichia();
            numericUpDownSumOfBooks.Value = 1;
            
        }
    }
}

using System;
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
        List<Student> students = new List<Student> { };
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


            int id = dataGridViewUsers.Rows.Add();
            dataGridViewUsers.Rows[id].Cells[0].Value = "Изотов Илья";
            dataGridViewUsers.Rows[id].Cells[1].Value = "6229491916261";
            dataGridViewUsers.Rows[id].Cells[2].Value = "03.12.1996";
            dataGridViewUsers.Rows[id].Cells[3].Value = "03.12.1998";

            id = dataGridViewUsers.Rows.Add();
            dataGridViewUsers.Rows[id].Cells[0].Value = "Изотов Илья";
            dataGridViewUsers.Rows[id].Cells[1].Value = "6229491916261";
            dataGridViewUsers.Rows[id].Cells[2].Value = "03.12.1996";
            dataGridViewUsers.Rows[id].Cells[3].Value = "03.12.1998";
        }

        protected override void OnDeactivate(EventArgs e)
        {
            //authentication.Show();
            base.OnDeactivate(e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //List<Student> studentsInDGV = new List<Student> { };
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            var form = new AddEditUsers();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                dataGridViewUsers.Rows.Add();
                int numberOfUsers = Convert.ToInt32(dataGridViewUsers.Rows.Count.ToString())-1;
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
            //AddEditUsers form = new AddEditUsers(GetObject().student[listBoxUsers.SelectedIndex]);
            //if (Form.ShowDialog(this) == DialogResult.OK)
            {
                var student = GetObject();
                //listBoxUsers.Items[listBoxUsers.SelectedIndex] = form.GetObject();
            }
        }
        Book GetObject(int NumberOfUser = 0)
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
                //student = dataGridViewUsers.da.OfType<Student>.ToList()
                student = students
                
                //student = listBoxUsers.Items.OfType<Student>().ToList(),
                //CountOfStudent = listBoxUsers.Items.OfType<Student>().Count()
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
            dataGridViewUsers.Rows.Clear();
            int numberOfUsers = 0;
            dataGridViewUsers.Rows.Add(data.student.Count());
            foreach (var item in data.student)
            {
                dataGridViewUsers.Rows[numberOfUsers].Cells[0].Value = item.Name + " " + item.Surname;
                dataGridViewUsers.Rows[numberOfUsers].Cells[1].Value = item.NumberOfTicket;
                dataGridViewUsers.Rows[numberOfUsers].Cells[2].Value = item.Vidacha.ToString("d");
                dataGridViewUsers.Rows[numberOfUsers].Cells[3].Value = item.Sdacha.ToString("d");
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
            //if (listBoxUsers.Items.Count >= numericUpDownSumOfBooks.Value)
            {
                labelNalichie.Text = "Нет в наличии";
                labelNalichie.ForeColor = System.Drawing.Color.Red;
                buttonAddUser.Enabled = false;
            }
            //else
            {
                labelNalichie.Text = "В наличии";
                labelNalichie.ForeColor = System.Drawing.Color.Green;
                buttonAddUser.Enabled = true;
            }
            //numericUpDownSumOfBooks.Minimum = listBoxUsers.Items.Count;
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            //listBoxUsers.Items.RemoveAt(listBoxUsers.SelectedIndex);
            ProverkaNalichia();
            BlockDelAndCheat();
        }

        private void listBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (listBoxUsers.SelectedIndex != -1)
            {
                buttonDeleteUser.Enabled = true;
                buttonCheat.Enabled = true;
            }
            //else
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
            Authentication authentification = new Authentication(this);
            this.Hide();
            authentication.Show();
        }

        private void KabOfLibrarian_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void списокКнигToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CollectOfBooks collectOfBooks = new CollectOfBooks();
            collectOfBooks.ShowDialog();
        }

        private void добавитьЧитателяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new AddEditUsers();
            if (form.ShowDialog(this) == DialogResult.OK)
            {
                dataGridViewUsers.Rows.Add();
                int numberOfUsers = Convert.ToInt32(dataGridViewUsers.Rows.Count.ToString());
            }
            ProverkaNalichia();
        }

        private void редактироватьЧитателяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AddEditUsers form = new AddEditUsers(GetObject().student[listBoxUsers.SelectedIndex]);
            //if (Form.ShowDialog(this) == DialogResult.OK)
            {
                var student = GetObject();
                //listBoxUsers.Items[listBoxUsers.SelectedIndex] = form.GetObject();
            }
        }

        private void удалитьЧитателяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //listBoxUsers.Items.RemoveAt(listBoxUsers.SelectedIndex);
            ProverkaNalichia();
            BlockDelAndCheat();
        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var numberOfNote = dataGridViewUsers.CurrentRow.Index;
            RedactUser(numberOfNote);
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
            }
        }
    }


}

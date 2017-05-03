using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryModel;

namespace Library
{
    public partial class AddEditUsers : Form
    {
        public AddEditUsers()
        {
            InitializeComponent();
        }

        public AddEditUsers(Student student)
        {
            InitializeComponent();
            try {
                this.dateSdacha.MinDate = this.dateVidacha.Value.AddHours(23);
                textBoxName.Text = student.Name;
                textBoxSurname.Text = student.Surname;
                maskedTextBoxGroup.Text = student.NumberOfTicket;
                dateVidacha.Value = student.Vidacha;
                dateSdacha.Value = student.Sdacha;
            } catch (ArgumentOutOfRangeException)
            {
                this.dateSdacha.MinDate = this.dateSdacha.Value.AddHours(-23);
                dateSdacha.Value = student.Sdacha;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        //private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        //{
            
        //}

        public Student GetObject()
        {
            var student = new Student
            {
                Name = textBoxName.Text,
                Surname = textBoxSurname.Text,
                NumberOfTicket = maskedTextBoxGroup.Text,
                Vidacha = dateVidacha.Value,
                Sdacha = dateSdacha.Value
            };
            return student;

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //var now = 
            //this.Close();
        }

        private void dateVidacha_ValueChanged(object sender, EventArgs e)
        {
            this.dateSdacha.MinDate = this.dateVidacha.Value.AddDays(1);
        }

    }


}

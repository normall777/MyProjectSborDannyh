using LibraryModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Library
{
    public partial class CollectOfBooks : Form
    {
        public CollectOfBooks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CollectOfBooks_Load(object sender, EventArgs e)
        {
            dataGridViewBooks.Rows.Clear();
            var mydocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Library";
            var files = Directory.GetFiles(mydocs, "*.lb");
            int numberOfBooks = 0;
            foreach (var item in files)
            {
                Book data;
                var xs = new XmlSerializer(typeof(Book));
                using (var file = File.OpenRead(item))
                {
                    data = (Book)xs.Deserialize(file);
                }
                dataGridViewBooks.Rows.Add(1);
                dataGridViewBooks.Rows[numberOfBooks].Cells[0].Value = data.Title;
                dataGridViewBooks.Rows[numberOfBooks].Cells[1].Value = data.Author;
                dataGridViewBooks.Rows[numberOfBooks].Cells[2].Value = data.YearOfPublic;
                dataGridViewBooks.Rows[numberOfBooks].Cells[3].Value = data.Izdatelstvo;
                dataGridViewBooks.Rows[numberOfBooks].Cells[5].Value = data.ISBN;
                dataGridViewBooks.Rows[numberOfBooks].Cells[4].Value = data.SumOfBooks-data.student.Count;
                numberOfBooks++;
            }
            dataGridViewBooks.Sort(dataGridViewBooks.Columns[1], ListSortDirection.Ascending);
        }
    }
}

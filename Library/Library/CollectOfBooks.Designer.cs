namespace Library
{
    partial class CollectOfBooks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CollectOfBooks));
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.TitleOfBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AutorOfBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearOfPublicOfBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IzdatelstvoOfBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountOfBookVNalichii = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBNOfBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.AllowUserToAddRows = false;
            this.dataGridViewBooks.AllowUserToDeleteRows = false;
            this.dataGridViewBooks.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TitleOfBook,
            this.AutorOfBook,
            this.YearOfPublicOfBook,
            this.IzdatelstvoOfBook,
            this.CountOfBookVNalichii,
            this.ISBNOfBook});
            this.dataGridViewBooks.Location = new System.Drawing.Point(0, 32);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.ReadOnly = true;
            this.dataGridViewBooks.Size = new System.Drawing.Size(707, 266);
            this.dataGridViewBooks.TabIndex = 0;
            // 
            // TitleOfBook
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TitleOfBook.DefaultCellStyle = dataGridViewCellStyle2;
            this.TitleOfBook.Frozen = true;
            this.TitleOfBook.HeaderText = "Название книги";
            this.TitleOfBook.Name = "TitleOfBook";
            this.TitleOfBook.ReadOnly = true;
            this.TitleOfBook.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TitleOfBook.Width = 150;
            // 
            // AutorOfBook
            // 
            this.AutorOfBook.Frozen = true;
            this.AutorOfBook.HeaderText = "Автор";
            this.AutorOfBook.Name = "AutorOfBook";
            this.AutorOfBook.ReadOnly = true;
            this.AutorOfBook.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // YearOfPublicOfBook
            // 
            this.YearOfPublicOfBook.Frozen = true;
            this.YearOfPublicOfBook.HeaderText = "Год издания";
            this.YearOfPublicOfBook.Name = "YearOfPublicOfBook";
            this.YearOfPublicOfBook.ReadOnly = true;
            this.YearOfPublicOfBook.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.YearOfPublicOfBook.Width = 60;
            // 
            // IzdatelstvoOfBook
            // 
            this.IzdatelstvoOfBook.Frozen = true;
            this.IzdatelstvoOfBook.HeaderText = "Издательство";
            this.IzdatelstvoOfBook.Name = "IzdatelstvoOfBook";
            this.IzdatelstvoOfBook.ReadOnly = true;
            this.IzdatelstvoOfBook.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IzdatelstvoOfBook.Width = 135;
            // 
            // CountOfBookVNalichii
            // 
            this.CountOfBookVNalichii.Frozen = true;
            this.CountOfBookVNalichii.HeaderText = "Количество экземпляров в наличии";
            this.CountOfBookVNalichii.Name = "CountOfBookVNalichii";
            this.CountOfBookVNalichii.ReadOnly = true;
            this.CountOfBookVNalichii.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CountOfBookVNalichii.Width = 120;
            // 
            // ISBNOfBook
            // 
            this.ISBNOfBook.Frozen = true;
            this.ISBNOfBook.HeaderText = "Код ISBN";
            this.ISBNOfBook.Name = "ISBNOfBook";
            this.ISBNOfBook.ReadOnly = true;
            this.ISBNOfBook.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ISBNOfBook.Width = 105;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(620, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CollectOfBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(707, 298);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewBooks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CollectOfBooks";
            this.Text = "Список книг";
            this.Load += new System.EventHandler(this.CollectOfBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleOfBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn AutorOfBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearOfPublicOfBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn IzdatelstvoOfBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountOfBookVNalichii;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBNOfBook;
    }
}
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TitleOfBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AutorOfBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearOfPublicOfBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IzdatelstvoOfBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountOfBookVNalichii = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBNOfBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TitleOfBook,
            this.AutorOfBook,
            this.YearOfPublicOfBook,
            this.IzdatelstvoOfBook,
            this.CountOfBookVNalichii,
            this.ISBNOfBook});
            this.dataGridView1.Location = new System.Drawing.Point(0, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(707, 266);
            this.dataGridView1.TabIndex = 0;
            // 
            // TitleOfBook
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.TitleOfBook.DefaultCellStyle = dataGridViewCellStyle2;
            this.TitleOfBook.Frozen = true;
            this.TitleOfBook.HeaderText = "Название книги";
            this.TitleOfBook.Name = "TitleOfBook";
            this.TitleOfBook.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TitleOfBook.Width = 150;
            // 
            // AutorOfBook
            // 
            this.AutorOfBook.Frozen = true;
            this.AutorOfBook.HeaderText = "Автор";
            this.AutorOfBook.Name = "AutorOfBook";
            this.AutorOfBook.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // YearOfPublicOfBook
            // 
            this.YearOfPublicOfBook.Frozen = true;
            this.YearOfPublicOfBook.HeaderText = "Год издания";
            this.YearOfPublicOfBook.Name = "YearOfPublicOfBook";
            this.YearOfPublicOfBook.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.YearOfPublicOfBook.Width = 60;
            // 
            // IzdatelstvoOfBook
            // 
            this.IzdatelstvoOfBook.Frozen = true;
            this.IzdatelstvoOfBook.HeaderText = "Издательство";
            this.IzdatelstvoOfBook.Name = "IzdatelstvoOfBook";
            this.IzdatelstvoOfBook.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IzdatelstvoOfBook.Width = 135;
            // 
            // CountOfBookVNalichii
            // 
            this.CountOfBookVNalichii.Frozen = true;
            this.CountOfBookVNalichii.HeaderText = "Количество экземпляров в наличии";
            this.CountOfBookVNalichii.Name = "CountOfBookVNalichii";
            this.CountOfBookVNalichii.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CountOfBookVNalichii.Width = 125;
            // 
            // ISBNOfBook
            // 
            this.ISBNOfBook.Frozen = true;
            this.ISBNOfBook.HeaderText = "Код ISBN";
            this.ISBNOfBook.Name = "ISBNOfBook";
            this.ISBNOfBook.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CollectOfBooks";
            this.Text = "Список книг";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleOfBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn AutorOfBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearOfPublicOfBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn IzdatelstvoOfBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountOfBookVNalichii;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBNOfBook;
        private System.Windows.Forms.Button button1;
    }
}
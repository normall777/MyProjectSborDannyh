namespace Library
{
    partial class KabOfLibrarian
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KabOfLibrarian));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelNalichie = new System.Windows.Forms.Label();
            this.numericUpDownSumOfBooks = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.maskedTextBoxISBN = new System.Windows.Forms.MaskedTextBox();
            this.textBoxTown = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownYearOfPublic = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxIzdatelstvo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.NameOfUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfTicket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateVidachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateVosvrat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.buttonCheat = new System.Windows.Forms.Button();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.списокКнигToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.читателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьЧитателяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьЧитателяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьЧитателяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelLogin = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemAddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemEditUser = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDelUser = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSumOfBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYearOfPublic)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelNalichie);
            this.groupBox1.Controls.Add(this.numericUpDownSumOfBooks);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.maskedTextBoxISBN);
            this.groupBox1.Controls.Add(this.textBoxTown);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.numericUpDownYearOfPublic);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxIzdatelstvo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxAuthor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(702, 125);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Книга";
            // 
            // labelNalichie
            // 
            this.labelNalichie.AutoSize = true;
            this.labelNalichie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNalichie.ForeColor = System.Drawing.Color.Green;
            this.labelNalichie.Location = new System.Drawing.Point(556, 93);
            this.labelNalichie.Name = "labelNalichie";
            this.labelNalichie.Size = new System.Drawing.Size(88, 20);
            this.labelNalichie.TabIndex = 17;
            this.labelNalichie.Text = "В наличии";
            // 
            // numericUpDownSumOfBooks
            // 
            this.numericUpDownSumOfBooks.Location = new System.Drawing.Point(476, 91);
            this.numericUpDownSumOfBooks.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSumOfBooks.Name = "numericUpDownSumOfBooks";
            this.numericUpDownSumOfBooks.Size = new System.Drawing.Size(50, 26);
            this.numericUpDownSumOfBooks.TabIndex = 16;
            this.numericUpDownSumOfBooks.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSumOfBooks.ValueChanged += new System.EventHandler(this.numericUpDownSumOfBooks_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(313, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Всего экземпляров";
            // 
            // maskedTextBoxISBN
            // 
            this.maskedTextBoxISBN.Location = new System.Drawing.Point(133, 90);
            this.maskedTextBoxISBN.Mask = "999-9-999-99999-9";
            this.maskedTextBoxISBN.Name = "maskedTextBoxISBN";
            this.maskedTextBoxISBN.Size = new System.Drawing.Size(155, 26);
            this.maskedTextBoxISBN.TabIndex = 6;
            // 
            // textBoxTown
            // 
            this.textBoxTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTown.Location = new System.Drawing.Point(62, 56);
            this.textBoxTown.Name = "textBoxTown";
            this.textBoxTown.Size = new System.Drawing.Size(147, 26);
            this.textBoxTown.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Город";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(44, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Код ISBN";
            // 
            // numericUpDownYearOfPublic
            // 
            this.numericUpDownYearOfPublic.Location = new System.Drawing.Point(620, 57);
            this.numericUpDownYearOfPublic.Maximum = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            this.numericUpDownYearOfPublic.Name = "numericUpDownYearOfPublic";
            this.numericUpDownYearOfPublic.Size = new System.Drawing.Size(70, 26);
            this.numericUpDownYearOfPublic.TabIndex = 5;
            this.numericUpDownYearOfPublic.Value = new decimal(new int[] {
            2012,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(508, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Год издания";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(215, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Издательство";
            // 
            // textBoxIzdatelstvo
            // 
            this.textBoxIzdatelstvo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxIzdatelstvo.Location = new System.Drawing.Point(341, 56);
            this.textBoxIzdatelstvo.Name = "textBoxIzdatelstvo";
            this.textBoxIzdatelstvo.Size = new System.Drawing.Size(161, 26);
            this.textBoxIzdatelstvo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(450, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Автор";
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAuthor.Location = new System.Drawing.Point(512, 24);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(180, 26);
            this.textBoxAuthor.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Название";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(95, 24);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(347, 26);
            this.textBoxName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Библиотека";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewUsers);
            this.groupBox2.Controls.Add(this.buttonDeleteUser);
            this.groupBox2.Controls.Add(this.buttonCheat);
            this.groupBox2.Controls.Add(this.buttonAddUser);
            this.groupBox2.Location = new System.Drawing.Point(12, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(702, 196);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Читатели";
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.AllowUserToResizeColumns = false;
            this.dataGridViewUsers.AllowUserToResizeRows = false;
            this.dataGridViewUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridViewUsers.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridViewUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameOfUser,
            this.NumberOfTicket,
            this.DateVidachi,
            this.DateVosvrat});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewUsers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewUsers.Location = new System.Drawing.Point(10, 14);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.RowTemplate.ReadOnly = true;
            this.dataGridViewUsers.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewUsers.Size = new System.Drawing.Size(562, 176);
            this.dataGridViewUsers.TabIndex = 9;
            this.dataGridViewUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsers_CellContentClick);
            this.dataGridViewUsers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsers_CellDoubleClick);
            this.dataGridViewUsers.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUsers_CellEnter);
            // 
            // NameOfUser
            // 
            this.NameOfUser.HeaderText = "Имя";
            this.NameOfUser.MaxInputLength = 15;
            this.NameOfUser.Name = "NameOfUser";
            this.NameOfUser.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NameOfUser.Width = 130;
            // 
            // NumberOfTicket
            // 
            this.NumberOfTicket.HeaderText = "Номер читательского билета";
            this.NumberOfTicket.Name = "NumberOfTicket";
            this.NumberOfTicket.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NumberOfTicket.Width = 130;
            // 
            // DateVidachi
            // 
            this.DateVidachi.HeaderText = "Дата выдачи";
            this.DateVidachi.Name = "DateVidachi";
            this.DateVidachi.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DateVidachi.Width = 128;
            // 
            // DateVosvrat
            // 
            this.DateVosvrat.HeaderText = "Дата возврата";
            this.DateVosvrat.Name = "DateVosvrat";
            this.DateVosvrat.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DateVosvrat.Width = 128;
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Enabled = false;
            this.buttonDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteUser.Location = new System.Drawing.Point(578, 135);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(118, 55);
            this.buttonDeleteUser.TabIndex = 8;
            this.buttonDeleteUser.Text = "Удалить";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // buttonCheat
            // 
            this.buttonCheat.Enabled = false;
            this.buttonCheat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCheat.Location = new System.Drawing.Point(578, 72);
            this.buttonCheat.Name = "buttonCheat";
            this.buttonCheat.Size = new System.Drawing.Size(118, 57);
            this.buttonCheat.TabIndex = 7;
            this.buttonCheat.Text = "Редактировать";
            this.buttonCheat.UseVisualStyleBackColor = true;
            this.buttonCheat.Click += new System.EventHandler(this.buttonCheat_Click);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddUser.Location = new System.Drawing.Point(578, 14);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(118, 52);
            this.buttonAddUser.TabIndex = 6;
            this.buttonAddUser.Text = "Добавить";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(123, 384);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(106, 23);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Сохранить...";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpen.Location = new System.Drawing.Point(12, 384);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(105, 23);
            this.buttonOpen.TabIndex = 8;
            this.buttonOpen.Text = "Загрузить...";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.читателиToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(726, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.toolStripMenuItem1,
            this.списокКнигToolStripMenuItem,
            this.toolStripMenuItem2,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // списокКнигToolStripMenuItem
            // 
            this.списокКнигToolStripMenuItem.Name = "списокКнигToolStripMenuItem";
            this.списокКнигToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.списокКнигToolStripMenuItem.Text = "Список книг";
            this.списокКнигToolStripMenuItem.Click += new System.EventHandler(this.списокКнигToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // читателиToolStripMenuItem
            // 
            this.читателиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьЧитателяToolStripMenuItem,
            this.редактироватьЧитателяToolStripMenuItem,
            this.удалитьЧитателяToolStripMenuItem});
            this.читателиToolStripMenuItem.Name = "читателиToolStripMenuItem";
            this.читателиToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.читателиToolStripMenuItem.Text = "Читатели";
            // 
            // добавитьЧитателяToolStripMenuItem
            // 
            this.добавитьЧитателяToolStripMenuItem.Name = "добавитьЧитателяToolStripMenuItem";
            this.добавитьЧитателяToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.добавитьЧитателяToolStripMenuItem.Text = "Добавить";
            this.добавитьЧитателяToolStripMenuItem.Click += new System.EventHandler(this.добавитьЧитателяToolStripMenuItem_Click);
            // 
            // редактироватьЧитателяToolStripMenuItem
            // 
            this.редактироватьЧитателяToolStripMenuItem.Name = "редактироватьЧитателяToolStripMenuItem";
            this.редактироватьЧитателяToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.редактироватьЧитателяToolStripMenuItem.Text = "Редактировать";
            this.редактироватьЧитателяToolStripMenuItem.Click += new System.EventHandler(this.редактироватьЧитателяToolStripMenuItem_Click);
            // 
            // удалитьЧитателяToolStripMenuItem
            // 
            this.удалитьЧитателяToolStripMenuItem.Name = "удалитьЧитателяToolStripMenuItem";
            this.удалитьЧитателяToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.удалитьЧитателяToolStripMenuItem.Text = "Удалить";
            this.удалитьЧитателяToolStripMenuItem.Click += new System.EventHandler(this.удалитьЧитателяToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(354, 28);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(273, 23);
            this.labelLogin.TabIndex = 11;
            this.labelLogin.Text = "Вы вошли как Normall777";
            this.labelLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(632, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 25);
            this.button1.TabIndex = 12;
            this.button1.Text = "Выйти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAddUser,
            this.toolStripMenuItemEditUser,
            this.toolStripMenuItemDelUser});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(233, 70);
            // 
            // toolStripMenuItemAddUser
            // 
            this.toolStripMenuItemAddUser.Name = "toolStripMenuItemAddUser";
            this.toolStripMenuItemAddUser.Size = new System.Drawing.Size(232, 22);
            this.toolStripMenuItemAddUser.Text = "Добавить пользователя";
            this.toolStripMenuItemAddUser.Click += new System.EventHandler(this.toolStripMenuItemAddUser_Click);
            // 
            // toolStripMenuItemEditUser
            // 
            this.toolStripMenuItemEditUser.Name = "toolStripMenuItemEditUser";
            this.toolStripMenuItemEditUser.Size = new System.Drawing.Size(232, 22);
            this.toolStripMenuItemEditUser.Text = "Редактировать пользователя";
            this.toolStripMenuItemEditUser.Click += new System.EventHandler(this.toolStripMenuItemEditUser_Click);
            // 
            // toolStripMenuItemDelUser
            // 
            this.toolStripMenuItemDelUser.Name = "toolStripMenuItemDelUser";
            this.toolStripMenuItemDelUser.Size = new System.Drawing.Size(232, 22);
            this.toolStripMenuItemDelUser.Text = "Удалить пользователя";
            this.toolStripMenuItemDelUser.Click += new System.EventHandler(this.toolStripMenuItemDelUser_Click);
            // 
            // KabOfLibrarian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 419);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KabOfLibrarian";
            this.Text = "Кабинет библиотекаря";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KabOfLibrarian_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSumOfBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYearOfPublic)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxTown;
        private System.Windows.Forms.NumericUpDown numericUpDownYearOfPublic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxIzdatelstvo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxISBN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericUpDownSumOfBooks;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.Button buttonCheat;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Label labelNalichie;
        private System.Windows.Forms.TextBox textBoxAuthor;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem читателиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьЧитателяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьЧитателяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьЧитателяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem списокКнигToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameOfUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateVidachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateVosvrat;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAddUser;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEditUser;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDelUser;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}


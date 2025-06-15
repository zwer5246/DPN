namespace test
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("1-семестр");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("2-семестр");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Посещаемость (по датам)", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("1-семестр");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("2-семестр");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Посещаемость (по фамилиям)", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Безымянная группа", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6});
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выпоонитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.импортВMicrosoftExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.men2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статистикаПодключенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fillerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.обновитьПОToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataGridView_main = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_main)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu1ToolStripMenuItem,
            this.выпоонитьToolStripMenuItem,
            this.men2ToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(866, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu1ToolStripMenuItem
            // 
            this.menu1ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("menu1ToolStripMenuItem.Image")));
            this.menu1ToolStripMenuItem.Name = "menu1ToolStripMenuItem";
            this.menu1ToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.menu1ToolStripMenuItem.Text = "Войти";
            this.menu1ToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.menu1ToolStripMenuItem.Click += new System.EventHandler(this.menu1ToolStripMenuItem_Click);
            // 
            // выпоонитьToolStripMenuItem
            // 
            this.выпоонитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.импортВMicrosoftExcelToolStripMenuItem});
            this.выпоонитьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("выпоонитьToolStripMenuItem.Image")));
            this.выпоонитьToolStripMenuItem.Name = "выпоонитьToolStripMenuItem";
            this.выпоонитьToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.выпоонитьToolStripMenuItem.Text = "Выполнить";
            this.выпоонитьToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Enabled = false;
            this.testToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("testToolStripMenuItem.Image")));
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(317, 22);
            this.testToolStripMenuItem.Text = "Выполнить пользовательский запрос T-SQL";

            // 
            // импортВMicrosoftExcelToolStripMenuItem
            // 
            this.импортВMicrosoftExcelToolStripMenuItem.Enabled = false;
            this.импортВMicrosoftExcelToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("импортВMicrosoftExcelToolStripMenuItem.Image")));
            this.импортВMicrosoftExcelToolStripMenuItem.Name = "импортВMicrosoftExcelToolStripMenuItem";
            this.импортВMicrosoftExcelToolStripMenuItem.Size = new System.Drawing.Size(317, 22);
            this.импортВMicrosoftExcelToolStripMenuItem.Text = "Импорт в .txt файл";
            // 
            // men2ToolStripMenuItem
            // 
            this.men2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.статистикаПодключенияToolStripMenuItem,
            this.fillerToolStripMenuItem,
            this.toolStripSeparator1,
            this.обновитьПОToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.men2ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("men2ToolStripMenuItem.Image")));
            this.men2ToolStripMenuItem.Name = "men2ToolStripMenuItem";
            this.men2ToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.men2ToolStripMenuItem.Text = "Справка";
            this.men2ToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // статистикаПодключенияToolStripMenuItem
            // 
            this.статистикаПодключенияToolStripMenuItem.Enabled = false;
            this.статистикаПодключенияToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("статистикаПодключенияToolStripMenuItem.Image")));
            this.статистикаПодключенияToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.статистикаПодключенияToolStripMenuItem.Name = "статистикаПодключенияToolStripMenuItem";
            this.статистикаПодключенияToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.статистикаПодключенияToolStripMenuItem.Text = "Статистика подключения";
            this.статистикаПодключенияToolStripMenuItem.Click += new System.EventHandler(this.статистикаПодключенияToolStripMenuItem_Click);
            // 
            // fillerToolStripMenuItem
            // 
            this.fillerToolStripMenuItem.Enabled = false;
            this.fillerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fillerToolStripMenuItem.Image")));
            this.fillerToolStripMenuItem.Name = "fillerToolStripMenuItem";
            this.fillerToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.fillerToolStripMenuItem.Text = "Обозначения в таблице";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(211, 6);
            // 
            // обновитьПОToolStripMenuItem
            // 
            this.обновитьПОToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("обновитьПОToolStripMenuItem.Image")));
            this.обновитьПОToolStripMenuItem.Name = "обновитьПОToolStripMenuItem";
            this.обновитьПОToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.обновитьПОToolStripMenuItem.Text = "Обновить ПО";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("оПрограммеToolStripMenuItem.Image")));
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("выходToolStripMenuItem.Image")));
            this.выходToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 515);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(866, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(145, 17);
            this.toolStripStatusLabel1.Text = "Текущая системная дата:";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.Enabled = false;
            this.treeView1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.treeView1.Location = new System.Drawing.Point(12, 67);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Узел3";
            treeNode1.Text = "1-семестр";
            treeNode2.Name = "Узел4";
            treeNode2.Text = "2-семестр";
            treeNode3.Name = "Узел2";
            treeNode3.Text = "Посещаемость (по датам)";
            treeNode4.Name = "Узел10";
            treeNode4.Text = "1-семестр";
            treeNode5.Name = "Узел11";
            treeNode5.Text = "2-семестр";
            treeNode6.Name = "Узел5";
            treeNode6.Text = "Посещаемость (по фамилиям)";
            treeNode7.Name = "Node1";
            treeNode7.Text = "Безымянная группа";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7});
            this.treeView1.Size = new System.Drawing.Size(180, 355);
            this.treeView1.TabIndex = 4;
            this.treeView1.DoubleClick += new System.EventHandler(this.treeView1_DoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // dataGridView_main
            // 
            this.dataGridView_main.AllowUserToAddRows = false;
            this.dataGridView_main.AllowUserToDeleteRows = false;
            this.dataGridView_main.AllowUserToResizeRows = false;
            this.dataGridView_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_main.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_main.Location = new System.Drawing.Point(198, 67);
            this.dataGridView_main.MultiSelect = false;
            this.dataGridView_main.Name = "dataGridView_main";
            this.dataGridView_main.ReadOnly = true;
            this.dataGridView_main.RowHeadersVisible = false;
            this.dataGridView_main.Size = new System.Drawing.Size(656, 435);
            this.dataGridView_main.TabIndex = 5;
            this.dataGridView_main.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_main_CellClick);
            this.dataGridView_main.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_main_CellValueChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(112, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Перезапросить БД";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(12, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 34);
            this.button2.TabIndex = 7;
            this.button2.Text = "Отключится";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(247, 27);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(154, 34);
            this.button4.TabIndex = 9;
            this.button4.Text = "Начать редактирование";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Требуется вход!";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 428);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 74);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Статус:";
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(99, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "0.1.2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(28, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Версия ПО";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(503, 27);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(66, 34);
            this.button5.TabIndex = 12;
            this.button5.Text = "Готово";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(407, 27);
            this.button6.MinimumSize = new System.Drawing.Size(70, 34);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(90, 34);
            this.button6.TabIndex = 13;
            this.button6.Text = "Остановить";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(575, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 34);
            this.button3.TabIndex = 14;
            this.button3.Text = "Отрисовать диаграмму";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(866, 537);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView_main);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(799, 576);
            this.Name = "MainForm";
            this.Text = "Менеджер успеваемости";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_main)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem men2ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem выпоонитьToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView dataGridView_main;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem статистикаПодключенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fillerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem импортВMicrosoftExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьПОToolStripMenuItem;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Button button3;
    }
}


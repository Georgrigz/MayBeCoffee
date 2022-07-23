namespace WinFormsApp1
{
    partial class AdminForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблицыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ингридиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.чайToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сиропыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расходныеМатериаллыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортироватьПоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.названиюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.колличествуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.датеЗавозаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.рецептыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.сортироватьПоToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(768, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицыToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // таблицыToolStripMenuItem
            // 
            this.таблицыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ингридиентыToolStripMenuItem,
            this.чайToolStripMenuItem,
            this.сиропыToolStripMenuItem,
            this.расходныеМатериаллыToolStripMenuItem,
            this.рецептыToolStripMenuItem});
            this.таблицыToolStripMenuItem.Name = "таблицыToolStripMenuItem";
            this.таблицыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.таблицыToolStripMenuItem.Text = "Таблицы";
            // 
            // ингридиентыToolStripMenuItem
            // 
            this.ингридиентыToolStripMenuItem.Name = "ингридиентыToolStripMenuItem";
            this.ингридиентыToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.ингридиентыToolStripMenuItem.Text = "Ингридиенты";
            this.ингридиентыToolStripMenuItem.Click += new System.EventHandler(this.ингридиентыToolStripMenuItem_Click);
            // 
            // чайToolStripMenuItem
            // 
            this.чайToolStripMenuItem.Name = "чайToolStripMenuItem";
            this.чайToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.чайToolStripMenuItem.Text = "Чай";
            this.чайToolStripMenuItem.Click += new System.EventHandler(this.чайToolStripMenuItem_Click);
            // 
            // сиропыToolStripMenuItem
            // 
            this.сиропыToolStripMenuItem.Name = "сиропыToolStripMenuItem";
            this.сиропыToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.сиропыToolStripMenuItem.Text = "Сиропы";
            this.сиропыToolStripMenuItem.Click += new System.EventHandler(this.сиропыToolStripMenuItem_Click);
            // 
            // расходныеМатериаллыToolStripMenuItem
            // 
            this.расходныеМатериаллыToolStripMenuItem.Name = "расходныеМатериаллыToolStripMenuItem";
            this.расходныеМатериаллыToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.расходныеМатериаллыToolStripMenuItem.Text = "Расходные материаллы";
            this.расходныеМатериаллыToolStripMenuItem.Click += new System.EventHandler(this.расходныеМатериаллыToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // сортироватьПоToolStripMenuItem
            // 
            this.сортироватьПоToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.названиюToolStripMenuItem,
            this.колличествуToolStripMenuItem,
            this.датеЗавозаToolStripMenuItem});
            this.сортироватьПоToolStripMenuItem.Name = "сортироватьПоToolStripMenuItem";
            this.сортироватьПоToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.сортироватьПоToolStripMenuItem.Text = "Сортировать по";
            // 
            // названиюToolStripMenuItem
            // 
            this.названиюToolStripMenuItem.Name = "названиюToolStripMenuItem";
            this.названиюToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.названиюToolStripMenuItem.Text = "Названию";
            this.названиюToolStripMenuItem.Click += new System.EventHandler(this.названиюToolStripMenuItem_Click);
            // 
            // колличествуToolStripMenuItem
            // 
            this.колличествуToolStripMenuItem.Name = "колличествуToolStripMenuItem";
            this.колличествуToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.колличествуToolStripMenuItem.Text = "Колличеству";
            this.колличествуToolStripMenuItem.Click += new System.EventHandler(this.колличествуToolStripMenuItem_Click);
            // 
            // датеЗавозаToolStripMenuItem
            // 
            this.датеЗавозаToolStripMenuItem.Name = "датеЗавозаToolStripMenuItem";
            this.датеЗавозаToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.датеЗавозаToolStripMenuItem.Text = "Дате завоза";
            this.датеЗавозаToolStripMenuItem.Click += new System.EventHandler(this.датеЗавозаToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(768, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(61, 22);
            this.toolStripLabel1.Text = "Обновить";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(768, 487);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserAddedRow);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 546);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Приход";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 545);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Наименование";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(290, 542);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 542);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Применить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(108, 542);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 8;
            // 
            // рецептыToolStripMenuItem
            // 
            this.рецептыToolStripMenuItem.Name = "рецептыToolStripMenuItem";
            this.рецептыToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.рецептыToolStripMenuItem.Text = "Рецепты";
            this.рецептыToolStripMenuItem.Click += new System.EventHandler(this.рецептыToolStripMenuItem_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(768, 569);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminForm";
            this.Text = "Учет товаров";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminForm_FormClosing);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private DataGridView dataGridView1;
        private ToolStripMenuItem таблицыToolStripMenuItem;
        private ToolStripMenuItem ингридиентыToolStripMenuItem;
        private ToolStripMenuItem сиропыToolStripMenuItem;
        private ToolStripMenuItem расходныеМатериаллыToolStripMenuItem;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Button button1;
        private ComboBox comboBox1;
        private ToolStripMenuItem сортироватьПоToolStripMenuItem;
        private ToolStripMenuItem названиюToolStripMenuItem;
        private ToolStripMenuItem колличествуToolStripMenuItem;
        private ToolStripMenuItem датеЗавозаToolStripMenuItem;
        private ToolStripMenuItem чайToolStripMenuItem;
        private ToolStripMenuItem рецептыToolStripMenuItem;
    }
}
namespace Pandora
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.новыйКлиентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйКлиентToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOtch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBonus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtbPhone = new System.Windows.Forms.MaskedTextBox();
            this.tbFam = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbOtch = new System.Windows.Forms.TextBox();
            this.tbBonus = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйКлиентToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(943, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // новыйКлиентToolStripMenuItem
            // 
            this.новыйКлиентToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйКлиентToolStripMenuItem1,
            this.выходToolStripMenuItem});
            this.новыйКлиентToolStripMenuItem.Name = "новыйКлиентToolStripMenuItem";
            this.новыйКлиентToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.новыйКлиентToolStripMenuItem.Text = "Файл";
            // 
            // новыйКлиентToolStripMenuItem1
            // 
            this.новыйКлиентToolStripMenuItem1.Name = "новыйКлиентToolStripMenuItem1";
            this.новыйКлиентToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.новыйКлиентToolStripMenuItem1.Text = "Новый клиент";
            this.новыйКлиентToolStripMenuItem1.Click += new System.EventHandler(this.новыйКлиентToolStripMenuItem1_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmPhone,
            this.clmFam,
            this.clmName,
            this.clmOtch,
            this.clmBonus});
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(943, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // clmPhone
            // 
            this.clmPhone.HeaderText = "Телефон";
            this.clmPhone.Name = "clmPhone";
            this.clmPhone.ReadOnly = true;
            // 
            // clmFam
            // 
            this.clmFam.HeaderText = "Фамилия";
            this.clmFam.Name = "clmFam";
            this.clmFam.ReadOnly = true;
            // 
            // clmName
            // 
            this.clmName.HeaderText = "Имя";
            this.clmName.Name = "clmName";
            this.clmName.ReadOnly = true;
            // 
            // clmOtch
            // 
            this.clmOtch.HeaderText = "Отчество";
            this.clmOtch.Name = "clmOtch";
            this.clmOtch.ReadOnly = true;
            // 
            // clmBonus
            // 
            this.clmBonus.HeaderText = "Баллы";
            this.clmBonus.Name = "clmBonus";
            this.clmBonus.ReadOnly = true;
            // 
            // mtbPhone
            // 
            this.mtbPhone.Location = new System.Drawing.Point(57, 195);
            this.mtbPhone.Mask = "0(000)-000-00-00";
            this.mtbPhone.Name = "mtbPhone";
            this.mtbPhone.Size = new System.Drawing.Size(100, 20);
            this.mtbPhone.TabIndex = 2;
            this.mtbPhone.KeyUp += new System.Windows.Forms.KeyEventHandler(this.maskedTextBox1_KeyUp);
            // 
            // tbFam
            // 
            this.tbFam.Location = new System.Drawing.Point(223, 195);
            this.tbFam.Name = "tbFam";
            this.tbFam.Size = new System.Drawing.Size(100, 20);
            this.tbFam.TabIndex = 3;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(423, 195);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 4;
            // 
            // tbOtch
            // 
            this.tbOtch.Location = new System.Drawing.Point(595, 195);
            this.tbOtch.Name = "tbOtch";
            this.tbOtch.Size = new System.Drawing.Size(100, 20);
            this.tbOtch.TabIndex = 5;
            // 
            // tbBonus
            // 
            this.tbBonus.Location = new System.Drawing.Point(774, 195);
            this.tbBonus.Name = "tbBonus";
            this.tbBonus.Size = new System.Drawing.Size(100, 20);
            this.tbBonus.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 343);
            this.Controls.Add(this.tbBonus);
            this.Controls.Add(this.tbOtch);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbFam);
            this.Controls.Add(this.mtbPhone);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лазертаг Pandora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem новыйКлиентToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйКлиентToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFam;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOtch;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBonus;
        private System.Windows.Forms.MaskedTextBox mtbPhone;
        private System.Windows.Forms.TextBox tbFam;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbOtch;
        private System.Windows.Forms.TextBox tbBonus;
    }
}


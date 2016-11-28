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
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbFam = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbOtch = new System.Windows.Forms.TextBox();
            this.tbBonus = new System.Windows.Forms.TextBox();
            this.mtbSearchPhone = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNumber7 = new System.Windows.Forms.Label();
            this.lblBonus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPriceGame = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйКлиентToolStripMenuItem,
            this.помощьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(480, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // новыйКлиентToolStripMenuItem
            // 
            this.новыйКлиентToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.новыйКлиентToolStripMenuItem.Name = "новыйКлиентToolStripMenuItem";
            this.новыйКлиентToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.новыйКлиентToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
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
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // tbFam
            // 
            this.tbFam.Location = new System.Drawing.Point(23, 86);
            this.tbFam.Name = "tbFam";
            this.tbFam.Size = new System.Drawing.Size(100, 20);
            this.tbFam.TabIndex = 3;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(23, 112);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 4;
            // 
            // tbOtch
            // 
            this.tbOtch.Location = new System.Drawing.Point(23, 138);
            this.tbOtch.Name = "tbOtch";
            this.tbOtch.Size = new System.Drawing.Size(100, 20);
            this.tbOtch.TabIndex = 5;
            // 
            // tbBonus
            // 
            this.tbBonus.Location = new System.Drawing.Point(356, 73);
            this.tbBonus.Name = "tbBonus";
            this.tbBonus.Size = new System.Drawing.Size(100, 20);
            this.tbBonus.TabIndex = 6;
            this.tbBonus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBonus_KeyPress);
            // 
            // mtbSearchPhone
            // 
            this.mtbSearchPhone.Location = new System.Drawing.Point(39, 36);
            this.mtbSearchPhone.Mask = "(000)-000-00-00";
            this.mtbSearchPhone.Name = "mtbSearchPhone";
            this.mtbSearchPhone.Size = new System.Drawing.Size(84, 20);
            this.mtbSearchPhone.TabIndex = 8;
            this.mtbSearchPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtbSearchPhone_KeyPress);
            this.mtbSearchPhone.KeyUp += new System.Windows.Forms.KeyEventHandler(this.mtbSearchPhone_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Бонусы:";
            // 
            // lblNumber7
            // 
            this.lblNumber7.AutoSize = true;
            this.lblNumber7.Location = new System.Drawing.Point(18, 39);
            this.lblNumber7.Name = "lblNumber7";
            this.lblNumber7.Size = new System.Drawing.Size(19, 13);
            this.lblNumber7.TabIndex = 14;
            this.lblNumber7.Text = "+7";
            // 
            // lblBonus
            // 
            this.lblBonus.AutoSize = true;
            this.lblBonus.Location = new System.Drawing.Point(236, 76);
            this.lblBonus.Name = "lblBonus";
            this.lblBonus.Size = new System.Drawing.Size(13, 13);
            this.lblBonus.TabIndex = 15;
            this.lblBonus.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "потратить";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(191, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Цена игры:";
            // 
            // tbPriceGame
            // 
            this.tbPriceGame.Location = new System.Drawing.Point(261, 102);
            this.tbPriceGame.Name = "tbPriceGame";
            this.tbPriceGame.Size = new System.Drawing.Size(62, 20);
            this.tbPriceGame.TabIndex = 18;
            this.tbPriceGame.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(329, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "К оплате:";
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Location = new System.Drawing.Point(381, 105);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(13, 13);
            this.lblPayment.TabIndex = 20;
            this.lblPayment.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 240);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbPriceGame);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBonus);
            this.Controls.Add(this.lblNumber7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mtbSearchPhone);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tbBonus);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbFam);
            this.Controls.Add(this.tbOtch);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лазертаг Pandora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem новыйКлиентToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.TextBox tbFam;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbOtch;
        private System.Windows.Forms.TextBox tbBonus;
        private System.Windows.Forms.MaskedTextBox mtbSearchPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNumber7;
        private System.Windows.Forms.Label lblBonus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPriceGame;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPayment;
    }
}


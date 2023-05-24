
namespace Угрюмова_зачёт_ОА1
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
        protected override void Dispose (bool disposing)
        {
            if ( disposing && (components != null) )
            {
                components.Dispose( );
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent ()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.namepr_txt = new System.Windows.Forms.TextBox();
            this.nmgroup_txt = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.delElem_btn = new System.Windows.Forms.Button();
            this.delgroup_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.addgroup_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.namegroup_txt = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.group_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FloralWhite;
            this.listBox1.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(483, 42);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(293, 382);
            this.listBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(727, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // namepr_txt
            // 
            this.namepr_txt.BackColor = System.Drawing.SystemColors.Window;
            this.namepr_txt.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.namepr_txt.Location = new System.Drawing.Point(24, 47);
            this.namepr_txt.Name = "namepr_txt";
            this.namepr_txt.Size = new System.Drawing.Size(172, 29);
            this.namepr_txt.TabIndex = 2;
            this.namepr_txt.TextChanged += new System.EventHandler(this.namepr_txt_TextChanged);
            // 
            // nmgroup_txt
            // 
            this.nmgroup_txt.BackColor = System.Drawing.SystemColors.Window;
            this.nmgroup_txt.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nmgroup_txt.Location = new System.Drawing.Point(24, 119);
            this.nmgroup_txt.Name = "nmgroup_txt";
            this.nmgroup_txt.Size = new System.Drawing.Size(172, 29);
            this.nmgroup_txt.TabIndex = 3;
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.Orange;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_btn.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_btn.Location = new System.Drawing.Point(24, 180);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(134, 38);
            this.add_btn.TabIndex = 4;
            this.add_btn.Text = "добавить";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // delElem_btn
            // 
            this.delElem_btn.BackColor = System.Drawing.Color.Orange;
            this.delElem_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delElem_btn.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delElem_btn.Location = new System.Drawing.Point(24, 26);
            this.delElem_btn.Name = "delElem_btn";
            this.delElem_btn.Size = new System.Drawing.Size(158, 41);
            this.delElem_btn.TabIndex = 5;
            this.delElem_btn.Text = "удалить элемент";
            this.delElem_btn.UseVisualStyleBackColor = false;
            // 
            // delgroup_btn
            // 
            this.delgroup_btn.BackColor = System.Drawing.Color.Orange;
            this.delgroup_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.delgroup_btn.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delgroup_btn.Location = new System.Drawing.Point(0, 70);
            this.delgroup_btn.Name = "delgroup_btn";
            this.delgroup_btn.Size = new System.Drawing.Size(158, 41);
            this.delgroup_btn.TabIndex = 6;
            this.delgroup_btn.Text = "удалить группу";
            this.delgroup_btn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.delgroup_btn);
            this.panel1.Location = new System.Drawing.Point(24, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 111);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "удалить с элементами";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Window;
            this.textBox3.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(0, 22);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(158, 29);
            this.textBox3.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(20, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Навзание ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(20, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Группа";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(31, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(431, 382);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FloralWhite;
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.add_btn);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.namepr_txt);
            this.tabPage1.Controls.Add(this.nmgroup_txt);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(423, 348);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "продукт";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FloralWhite;
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.addgroup_btn);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.namegroup_txt);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(423, 348);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "группа";
            // 
            // addgroup_btn
            // 
            this.addgroup_btn.BackColor = System.Drawing.Color.Orange;
            this.addgroup_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addgroup_btn.Location = new System.Drawing.Point(22, 208);
            this.addgroup_btn.Name = "addgroup_btn";
            this.addgroup_btn.Size = new System.Drawing.Size(135, 40);
            this.addgroup_btn.TabIndex = 2;
            this.addgroup_btn.Text = "добавить";
            this.addgroup_btn.UseVisualStyleBackColor = false;
            this.addgroup_btn.Click += new System.EventHandler(this.addgroup_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "название группы";
            // 
            // namegroup_txt
            // 
            this.namegroup_txt.Location = new System.Drawing.Point(22, 48);
            this.namegroup_txt.Name = "namegroup_txt";
            this.namegroup_txt.Size = new System.Drawing.Size(160, 29);
            this.namegroup_txt.TabIndex = 0;
            this.namegroup_txt.TextChanged += new System.EventHandler(this.namegroup_txt_TextChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FloralWhite;
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Controls.Add(this.delElem_btn);
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 30);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(423, 348);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "группировки";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel2.Controls.Add(this.group_btn);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(235, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 296);
            this.panel2.TabIndex = 8;
            // 
            // group_btn
            // 
            this.group_btn.BackColor = System.Drawing.Color.Orange;
            this.group_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.group_btn.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_btn.Location = new System.Drawing.Point(0, 49);
            this.group_btn.Name = "group_btn";
            this.group_btn.Size = new System.Drawing.Size(160, 41);
            this.group_btn.TabIndex = 7;
            this.group_btn.Text = "по группам";
            this.group_btn.UseVisualStyleBackColor = false;
            this.group_btn.Click += new System.EventHandler(this.group_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "группировка:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 29);
            this.textBox1.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "цена";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox namepr_txt;
        private System.Windows.Forms.TextBox nmgroup_txt;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button delElem_btn;
        private System.Windows.Forms.Button delgroup_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button group_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addgroup_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox namegroup_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
    }
}


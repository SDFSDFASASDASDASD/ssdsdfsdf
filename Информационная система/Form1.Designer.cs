
namespace Информационная_система
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
            this.components = new System.ComponentModel.Container();
            this.panel_black = new System.Windows.Forms.Panel();
            this.label_nametop = new System.Windows.Forms.Label();
            this.panel_white = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label_login = new System.Windows.Forms.Label();
            this.label_pass = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.label_error = new System.Windows.Forms.Label();
            this.button_enter = new System.Windows.Forms.Button();
            this.label_tryestext = new System.Windows.Forms.Label();
            this.label_timer = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label_tryescount = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.panel_black.SuspendLayout();
            this.panel_white.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_black
            // 
            this.panel_black.BackColor = System.Drawing.Color.White;
            this.panel_black.Controls.Add(this.label_nametop);
            this.panel_black.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_black.Location = new System.Drawing.Point(0, 0);
            this.panel_black.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel_black.Name = "panel_black";
            this.panel_black.Size = new System.Drawing.Size(555, 12);
            this.panel_black.TabIndex = 0;
            // 
            // label_nametop
            // 
            this.label_nametop.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_nametop.ForeColor = System.Drawing.Color.White;
            this.label_nametop.Location = new System.Drawing.Point(135, 59);
            this.label_nametop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_nametop.Name = "label_nametop";
            this.label_nametop.Size = new System.Drawing.Size(294, 51);
            this.label_nametop.TabIndex = 0;
            this.label_nametop.Text = "Информацiонная система";
            // 
            // panel_white
            // 
            this.panel_white.BackColor = System.Drawing.Color.White;
            this.panel_white.Controls.Add(this.numericUpDown1);
            this.panel_white.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_white.Location = new System.Drawing.Point(0, 512);
            this.panel_white.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel_white.Name = "panel_white";
            this.panel_white.Size = new System.Drawing.Size(555, 67);
            this.panel_white.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(2, 140);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.Visible = false;
            // 
            // label_login
            // 
            this.label_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_login.Location = new System.Drawing.Point(156, 110);
            this.label_login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(102, 39);
            this.label_login.TabIndex = 3;
            this.label_login.Text = "Логин";
            // 
            // label_pass
            // 
            this.label_pass.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_pass.Location = new System.Drawing.Point(160, 199);
            this.label_pass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(109, 39);
            this.label_pass.TabIndex = 4;
            this.label_pass.Text = "Пароль";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(160, 152);
            this.textBox_login.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(198, 20);
            this.textBox_login.TabIndex = 5;
            // 
            // textBox_pass
            // 
            this.textBox_pass.Location = new System.Drawing.Point(160, 255);
            this.textBox_pass.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.Size = new System.Drawing.Size(198, 20);
            this.textBox_pass.TabIndex = 6;
            // 
            // label_error
            // 
            this.label_error.BackColor = System.Drawing.Color.White;
            this.label_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_error.Location = new System.Drawing.Point(121, 292);
            this.label_error.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(282, 24);
            this.label_error.TabIndex = 7;
            this.label_error.Text = "Неправильный логин или пароль";
            this.label_error.Visible = false;
            this.label_error.Click += new System.EventHandler(this.label_error_Click);
            // 
            // button_enter
            // 
            this.button_enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_enter.Location = new System.Drawing.Point(165, 347);
            this.button_enter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button_enter.Name = "button_enter";
            this.button_enter.Size = new System.Drawing.Size(216, 46);
            this.button_enter.TabIndex = 8;
            this.button_enter.Text = "Enter";
            this.button_enter.UseVisualStyleBackColor = true;
            this.button_enter.Click += new System.EventHandler(this.button_enter_Click);
            // 
            // label_tryestext
            // 
            this.label_tryestext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tryestext.Location = new System.Drawing.Point(161, 316);
            this.label_tryestext.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_tryestext.Name = "label_tryestext";
            this.label_tryestext.Size = new System.Drawing.Size(172, 28);
            this.label_tryestext.TabIndex = 9;
            this.label_tryestext.Text = "Осталось попыток";
            this.label_tryestext.Visible = false;
            // 
            // label_timer
            // 
            this.label_timer.BackColor = System.Drawing.Color.White;
            this.label_timer.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_timer.ForeColor = System.Drawing.Color.Black;
            this.label_timer.Location = new System.Drawing.Point(277, 413);
            this.label_timer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_timer.Name = "label_timer";
            this.label_timer.Size = new System.Drawing.Size(45, 39);
            this.label_timer.TabIndex = 11;
            this.label_timer.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "До повторения ввода";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(336, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "сек.";
            this.label2.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(0, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(73, 19);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label_tryescount
            // 
            this.label_tryescount.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_tryescount.Location = new System.Drawing.Point(334, 316);
            this.label_tryescount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_tryescount.Name = "label_tryescount";
            this.label_tryescount.Size = new System.Drawing.Size(24, 28);
            this.label_tryescount.TabIndex = 10;
            this.label_tryescount.Visible = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(385, 254);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(160, 24);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "Показать пароль";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(555, 579);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_timer);
            this.Controls.Add(this.label_tryescount);
            this.Controls.Add(this.label_tryestext);
            this.Controls.Add(this.button_enter);
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.textBox_pass);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.label_pass);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.panel_white);
            this.Controls.Add(this.panel_black);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "ИС";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_black.ResumeLayout(false);
            this.panel_white.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_black;
        private System.Windows.Forms.Panel panel_white;
        private System.Windows.Forms.Label label_nametop;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_pass;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.Label label_error;
        private System.Windows.Forms.Button button_enter;
        private System.Windows.Forms.Label label_tryestext;
        private System.Windows.Forms.Label label_timer;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label_tryescount;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}



namespace Информационная_система
{
    partial class Form2
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
            this.label_petition = new System.Windows.Forms.Label();
            this.textBox_pin = new System.Windows.Forms.TextBox();
            this.button_enter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_petition
            // 
            this.label_petition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_petition.Location = new System.Drawing.Point(74, 25);
            this.label_petition.Name = "label_petition";
            this.label_petition.Size = new System.Drawing.Size(274, 30);
            this.label_petition.TabIndex = 0;
            this.label_petition.Text = "Введите код подтверждения";
            // 
            // textBox_pin
            // 
            this.textBox_pin.Location = new System.Drawing.Point(77, 58);
            this.textBox_pin.Name = "textBox_pin";
            this.textBox_pin.Size = new System.Drawing.Size(193, 20);
            this.textBox_pin.TabIndex = 1;
            this.textBox_pin.TextChanged += new System.EventHandler(this.textBox_pin_TextChanged);
            // 
            // button_enter
            // 
            this.button_enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_enter.Location = new System.Drawing.Point(81, 100);
            this.button_enter.Name = "button_enter";
            this.button_enter.Size = new System.Drawing.Size(70, 33);
            this.button_enter.TabIndex = 2;
            this.button_enter.Text = "Enter";
            this.button_enter.UseVisualStyleBackColor = true;
            this.button_enter.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(360, 145);
            this.Controls.Add(this.button_enter);
            this.Controls.Add(this.textBox_pin);
            this.Controls.Add(this.label_petition);
            this.Name = "Form2";
            this.Text = "Аутентификация";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_petition;
        private System.Windows.Forms.TextBox textBox_pin;
        private System.Windows.Forms.Button button_enter;
    }
}
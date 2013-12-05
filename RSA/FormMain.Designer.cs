namespace RSA
{
    partial class FormMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_calculate = new System.Windows.Forms.Button();
            this.tb_messageFile = new System.Windows.Forms.TextBox();
            this.tb_cipherFile = new System.Windows.Forms.TextBox();
            this.bt_openMessage = new System.Windows.Forms.Button();
            this.bt_openCipher = new System.Windows.Forms.Button();
            this.gb_main = new System.Windows.Forms.GroupBox();
            this.rb_encrypt = new System.Windows.Forms.RadioButton();
            this.rb_decrypt = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.gb_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_calculate
            // 
            this.bt_calculate.Location = new System.Drawing.Point(139, 183);
            this.bt_calculate.Name = "bt_calculate";
            this.bt_calculate.Size = new System.Drawing.Size(197, 45);
            this.bt_calculate.TabIndex = 0;
            this.bt_calculate.Text = "button1";
            this.bt_calculate.UseVisualStyleBackColor = true;
            this.bt_calculate.Click += new System.EventHandler(this.bt_calculate_Click);
            // 
            // tb_messageFile
            // 
            this.tb_messageFile.Location = new System.Drawing.Point(38, 17);
            this.tb_messageFile.Name = "tb_messageFile";
            this.tb_messageFile.Size = new System.Drawing.Size(193, 20);
            this.tb_messageFile.TabIndex = 1;
            // 
            // tb_cipherFile
            // 
            this.tb_cipherFile.Location = new System.Drawing.Point(38, 61);
            this.tb_cipherFile.Name = "tb_cipherFile";
            this.tb_cipherFile.Size = new System.Drawing.Size(193, 20);
            this.tb_cipherFile.TabIndex = 2;
            // 
            // bt_openMessage
            // 
            this.bt_openMessage.Location = new System.Drawing.Point(256, 17);
            this.bt_openMessage.Name = "bt_openMessage";
            this.bt_openMessage.Size = new System.Drawing.Size(79, 20);
            this.bt_openMessage.TabIndex = 3;
            this.bt_openMessage.Text = "...";
            this.bt_openMessage.UseVisualStyleBackColor = true;
            this.bt_openMessage.Click += new System.EventHandler(this.bt_openMessage_Click);
            // 
            // bt_openCipher
            // 
            this.bt_openCipher.Location = new System.Drawing.Point(256, 60);
            this.bt_openCipher.Name = "bt_openCipher";
            this.bt_openCipher.Size = new System.Drawing.Size(79, 20);
            this.bt_openCipher.TabIndex = 4;
            this.bt_openCipher.Text = "...";
            this.bt_openCipher.UseVisualStyleBackColor = true;
            this.bt_openCipher.Click += new System.EventHandler(this.bt_openCipher_Click);
            // 
            // gb_main
            // 
            this.gb_main.Controls.Add(this.rb_decrypt);
            this.gb_main.Controls.Add(this.rb_encrypt);
            this.gb_main.Location = new System.Drawing.Point(372, 14);
            this.gb_main.Name = "gb_main";
            this.gb_main.Size = new System.Drawing.Size(107, 66);
            this.gb_main.TabIndex = 5;
            this.gb_main.TabStop = false;
            // 
            // rb_encrypt
            // 
            this.rb_encrypt.AutoSize = true;
            this.rb_encrypt.Checked = true;
            this.rb_encrypt.Location = new System.Drawing.Point(14, 16);
            this.rb_encrypt.Name = "rb_encrypt";
            this.rb_encrypt.Size = new System.Drawing.Size(61, 17);
            this.rb_encrypt.TabIndex = 0;
            this.rb_encrypt.TabStop = true;
            this.rb_encrypt.Text = "Encrypt";
            this.rb_encrypt.UseVisualStyleBackColor = true;
            // 
            // rb_decrypt
            // 
            this.rb_decrypt.AutoSize = true;
            this.rb_decrypt.Location = new System.Drawing.Point(14, 39);
            this.rb_decrypt.Name = "rb_decrypt";
            this.rb_decrypt.Size = new System.Drawing.Size(62, 17);
            this.rb_decrypt.TabIndex = 1;
            this.rb_decrypt.Text = "Decrypt";
            this.rb_decrypt.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 293);
            this.Controls.Add(this.gb_main);
            this.Controls.Add(this.bt_openCipher);
            this.Controls.Add(this.bt_openMessage);
            this.Controls.Add(this.tb_cipherFile);
            this.Controls.Add(this.tb_messageFile);
            this.Controls.Add(this.bt_calculate);
            this.Name = "FormMain";
            this.Text = "RSA";
            this.gb_main.ResumeLayout(false);
            this.gb_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_calculate;
        private System.Windows.Forms.TextBox tb_messageFile;
        private System.Windows.Forms.TextBox tb_cipherFile;
        private System.Windows.Forms.Button bt_openMessage;
        private System.Windows.Forms.Button bt_openCipher;
        private System.Windows.Forms.GroupBox gb_main;
        private System.Windows.Forms.RadioButton rb_decrypt;
        private System.Windows.Forms.RadioButton rb_encrypt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}


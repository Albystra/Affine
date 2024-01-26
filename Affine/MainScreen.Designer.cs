
namespace Affine
{
    partial class MainScreen
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
            this.eButton = new System.Windows.Forms.Button();
            this.encodeText = new System.Windows.Forms.RichTextBox();
            this.originText = new System.Windows.Forms.RichTextBox();
            this.bKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.aKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // eButton
            // 
            this.eButton.AutoSize = true;
            this.eButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.eButton.Location = new System.Drawing.Point(294, 348);
            this.eButton.Name = "eButton";
            this.eButton.Size = new System.Drawing.Size(230, 77);
            this.eButton.TabIndex = 37;
            this.eButton.Text = "> Зашифровать >";
            this.eButton.UseVisualStyleBackColor = true;
            this.eButton.Click += new System.EventHandler(this.eButton_Click);
            // 
            // encodeText
            // 
            this.encodeText.Location = new System.Drawing.Point(530, 299);
            this.encodeText.Name = "encodeText";
            this.encodeText.Size = new System.Drawing.Size(268, 294);
            this.encodeText.TabIndex = 36;
            this.encodeText.Text = "";
            // 
            // originText
            // 
            this.originText.Location = new System.Drawing.Point(12, 299);
            this.originText.Name = "originText";
            this.originText.Size = new System.Drawing.Size(276, 294);
            this.originText.TabIndex = 35;
            this.originText.Text = "";
            // 
            // bKey
            // 
            this.bKey.Location = new System.Drawing.Point(342, 180);
            this.bKey.Name = "bKey";
            this.bKey.Size = new System.Drawing.Size(95, 27);
            this.bKey.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.label3.Location = new System.Drawing.Point(294, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 47);
            this.label3.TabIndex = 33;
            this.label3.Text = "B";
            // 
            // aKey
            // 
            this.aKey.Location = new System.Drawing.Point(130, 180);
            this.aKey.Name = "aKey";
            this.aKey.Size = new System.Drawing.Size(95, 27);
            this.aKey.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.label2.Location = new System.Drawing.Point(82, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 47);
            this.label2.TabIndex = 31;
            this.label2.Text = "A";
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("OCR A Extended", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.exit.Location = new System.Drawing.Point(775, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(35, 35);
            this.exit.TabIndex = 30;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(810, 122);
            this.label1.TabIndex = 29;
            this.label1.Text = "Affine Cipher App";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.panel2.Location = new System.Drawing.Point(0, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(907, 10);
            this.panel2.TabIndex = 28;
            // 
            // dButton
            // 
            this.dButton.AutoSize = true;
            this.dButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dButton.Location = new System.Drawing.Point(294, 463);
            this.dButton.Name = "dButton";
            this.dButton.Size = new System.Drawing.Size(230, 77);
            this.dButton.TabIndex = 37;
            this.dButton.Text = "< Расшифровать <";
            this.dButton.UseVisualStyleBackColor = true;
            this.dButton.Click += new System.EventHandler(this.dButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.label4.Location = new System.Drawing.Point(28, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(241, 23);
            this.label4.TabIndex = 38;
            this.label4.Text = "Нормальный текст сюда";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.label5.Location = new System.Drawing.Point(546, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 23);
            this.label5.TabIndex = 39;
            this.label5.Text = "Шифрованный текст сюда";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 671);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dButton);
            this.Controls.Add(this.eButton);
            this.Controls.Add(this.encodeText);
            this.Controls.Add(this.originText);
            this.Controls.Add(this.bKey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.aKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button eButton;
        private System.Windows.Forms.RichTextBox encodeText;
        private System.Windows.Forms.RichTextBox originText;
        private System.Windows.Forms.TextBox bKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox aKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button dButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
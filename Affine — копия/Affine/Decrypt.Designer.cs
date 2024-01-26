
namespace Affine
{
    partial class Decrypt
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
            this.dButton = new System.Windows.Forms.Button();
            this.decodeText = new System.Windows.Forms.RichTextBox();
            this.encodeText = new System.Windows.Forms.RichTextBox();
            this.bKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.aKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.back = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dButton
            // 
            this.dButton.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dButton.Location = new System.Drawing.Point(343, 365);
            this.dButton.Name = "dButton";
            this.dButton.Size = new System.Drawing.Size(135, 145);
            this.dButton.TabIndex = 37;
            this.dButton.Text = ">";
            this.dButton.UseVisualStyleBackColor = true;
            this.dButton.Click += new System.EventHandler(this.dButton_Click);
            // 
            // decodeText
            // 
            this.decodeText.Location = new System.Drawing.Point(484, 299);
            this.decodeText.Name = "decodeText";
            this.decodeText.Size = new System.Drawing.Size(254, 294);
            this.decodeText.TabIndex = 36;
            this.decodeText.Text = "";
            // 
            // encodeText
            // 
            this.encodeText.Location = new System.Drawing.Point(82, 299);
            this.encodeText.Name = "encodeText";
            this.encodeText.Size = new System.Drawing.Size(254, 294);
            this.encodeText.TabIndex = 35;
            this.encodeText.Text = "";
            // 
            // bKey
            // 
            this.bKey.Location = new System.Drawing.Point(342, 203);
            this.bKey.Name = "bKey";
            this.bKey.Size = new System.Drawing.Size(95, 27);
            this.bKey.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.label3.Location = new System.Drawing.Point(294, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 47);
            this.label3.TabIndex = 33;
            this.label3.Text = "B";
            // 
            // aKey
            // 
            this.aKey.Location = new System.Drawing.Point(130, 203);
            this.aKey.Name = "aKey";
            this.aKey.Size = new System.Drawing.Size(95, 27);
            this.aKey.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.label2.Location = new System.Drawing.Point(82, 194);
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
            this.label1.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(810, 122);
            this.label1.TabIndex = 29;
            this.label1.Text = "Расшифровка";
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
            // back
            // 
            this.back.AutoSize = true;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(82)))));
            this.back.Location = new System.Drawing.Point(356, 624);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(107, 38);
            this.back.TabIndex = 38;
            this.back.Text = "Назад";
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Decrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 671);
            this.Controls.Add(this.back);
            this.Controls.Add(this.dButton);
            this.Controls.Add(this.decodeText);
            this.Controls.Add(this.encodeText);
            this.Controls.Add(this.bKey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.aKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Name = "Decrypt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Decrypt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dButton;
        private System.Windows.Forms.RichTextBox decodeText;
        private System.Windows.Forms.RichTextBox encodeText;
        private System.Windows.Forms.TextBox bKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox aKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label back;
    }
}
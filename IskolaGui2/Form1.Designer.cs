
namespace IskolaGui2
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnBetöltés = new System.Windows.Forms.Button();
            this.btnMentés = new System.Windows.Forms.Button();
            this.btnTörlés = new System.Windows.Forms.Button();
            this.btnKilépés = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(194, 342);
            this.listBox1.TabIndex = 0;
            // 
            // btnBetöltés
            // 
            this.btnBetöltés.Location = new System.Drawing.Point(12, 360);
            this.btnBetöltés.Name = "btnBetöltés";
            this.btnBetöltés.Size = new System.Drawing.Size(75, 23);
            this.btnBetöltés.TabIndex = 1;
            this.btnBetöltés.Text = "Betöltés";
            this.btnBetöltés.UseVisualStyleBackColor = true;
            // 
            // btnMentés
            // 
            this.btnMentés.Location = new System.Drawing.Point(131, 360);
            this.btnMentés.Name = "btnMentés";
            this.btnMentés.Size = new System.Drawing.Size(75, 23);
            this.btnMentés.TabIndex = 2;
            this.btnMentés.Text = "Mentés";
            this.btnMentés.UseVisualStyleBackColor = true;
            this.btnMentés.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnTörlés
            // 
            this.btnTörlés.Location = new System.Drawing.Point(12, 389);
            this.btnTörlés.Name = "btnTörlés";
            this.btnTörlés.Size = new System.Drawing.Size(75, 23);
            this.btnTörlés.TabIndex = 3;
            this.btnTörlés.Text = "Törlés";
            this.btnTörlés.UseVisualStyleBackColor = true;
            // 
            // btnKilépés
            // 
            this.btnKilépés.Location = new System.Drawing.Point(131, 389);
            this.btnKilépés.Name = "btnKilépés";
            this.btnKilépés.Size = new System.Drawing.Size(75, 23);
            this.btnKilépés.TabIndex = 4;
            this.btnKilépés.Text = "Kilépés";
            this.btnKilépés.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 430);
            this.Controls.Add(this.btnKilépés);
            this.Controls.Add(this.btnTörlés);
            this.Controls.Add(this.btnMentés);
            this.Controls.Add(this.btnBetöltés);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnBetöltés;
        private System.Windows.Forms.Button btnMentés;
        private System.Windows.Forms.Button btnTörlés;
        private System.Windows.Forms.Button btnKilépés;
    }
}


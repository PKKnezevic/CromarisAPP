using System.ComponentModel;

namespace DatabaseConnection.AddElementForms
{
    partial class TableFormZaduzenjec
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.KadrovskiBox = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.brojOpremeBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // KadrovskiBox
            // 
            this.KadrovskiBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.KadrovskiBox.Location = new System.Drawing.Point(60, 20);
            this.KadrovskiBox.Name = "KadrovskiBox";
            this.KadrovskiBox.Size = new System.Drawing.Size(158, 23);
            this.KadrovskiBox.TabIndex = 0;
            this.KadrovskiBox.Text = "Kadrovski broj:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(350, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(358, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(366, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(374, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(382, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(118, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "label7";
            // 
            // brojOpremeBox
            // 
            this.brojOpremeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.brojOpremeBox.Location = new System.Drawing.Point(15, 55);
            this.brojOpremeBox.Name = "brojOpremeBox";
            this.brojOpremeBox.Size = new System.Drawing.Size(203, 23);
            this.brojOpremeBox.TabIndex = 7;
            this.brojOpremeBox.Text = "Interni broj opreme:";
            this.brojOpremeBox.Click += new System.EventHandler(this.label8_Click);
            // 
            // TableFormZaduzenjec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.brojOpremeBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.KadrovskiBox);
            this.Name = "TableFormZaduzenjec";
            this.Text = "TableFormZaduzenjec";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label KadrovskiBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label brojOpremeBox;

        #endregion
    }
}
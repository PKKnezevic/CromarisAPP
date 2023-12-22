using System.ComponentModel;

namespace DatabaseConnection.AddElementForms
{
    partial class TableFormMT
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
            this.AddMT = new System.Windows.Forms.Button();
            this.SAP_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SAPbox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddMT
            // 
            this.AddMT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddMT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddMT.Location = new System.Drawing.Point(0, 137);
            this.AddMT.Name = "AddMT";
            this.AddMT.Size = new System.Drawing.Size(282, 50);
            this.AddMT.TabIndex = 0;
            this.AddMT.Text = "Dodaj";
            this.AddMT.UseVisualStyleBackColor = true;
            this.AddMT.Click += new System.EventHandler(this.addMT_Click);
            // 
            // SAP_label
            // 
            this.SAP_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SAP_label.Location = new System.Drawing.Point(12, 26);
            this.SAP_label.Name = "SAP_label";
            this.SAP_label.Size = new System.Drawing.Size(100, 23);
            this.SAP_label.TabIndex = 1;
            this.SAP_label.Text = "SAP sifra:";
            this.SAP_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Naziv:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SAPbox
            // 
            this.SAPbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SAPbox.Location = new System.Drawing.Point(118, 29);
            this.SAPbox.Name = "SAPbox";
            this.SAPbox.Size = new System.Drawing.Size(120, 30);
            this.SAPbox.TabIndex = 3;
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameBox.Location = new System.Drawing.Point(118, 76);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(120, 30);
            this.NameBox.TabIndex = 4;
            // 
            // TableFormMT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 187);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.SAPbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SAP_label);
            this.Controls.Add(this.AddMT);
            this.Name = "TableFormMT";
            this.Text = "TableFormMT";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox SAPbox;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label SAP_label;

        private System.Windows.Forms.Button AddMT;

        #endregion
    }
}
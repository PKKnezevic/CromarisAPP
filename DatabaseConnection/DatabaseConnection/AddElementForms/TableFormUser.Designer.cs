using System.ComponentModel;

namespace DatabaseConnection.AddElementForms
{
    partial class TableFormUser
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
            this.NameBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.SendDataToKorisnik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(175, 35);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(120, 22);
            this.NameBox.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameLabel.Location = new System.Drawing.Point(12, 35);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(157, 23);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Prezime,Ime:";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // idLabel
            // 
            this.idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.idLabel.Location = new System.Drawing.Point(12, 76);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(157, 27);
            this.idLabel.TabIndex = 2;
            this.idLabel.Text = "Kadrovski Broj:";
            this.idLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IDBox
            // 
            this.IDBox.Location = new System.Drawing.Point(175, 76);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(120, 22);
            this.IDBox.TabIndex = 3;
            // 
            // SendDataToKorisnik
            // 
            this.SendDataToKorisnik.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SendDataToKorisnik.Location = new System.Drawing.Point(0, 130);
            this.SendDataToKorisnik.Name = "SendDataToKorisnik";
            this.SendDataToKorisnik.Size = new System.Drawing.Size(307, 53);
            this.SendDataToKorisnik.TabIndex = 4;
            this.SendDataToKorisnik.Text = "Dodaj";
            this.SendDataToKorisnik.UseVisualStyleBackColor = true;
            this.SendDataToKorisnik.Click += new System.EventHandler(this.SendDataToKorisnik_Click);
            // 
            // TableFormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 183);
            this.Controls.Add(this.SendDataToKorisnik);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.NameBox);
            this.Name = "TableFormUser";
            this.Text = "Korisnik";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button SendDataToKorisnik;

        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox IDBox;

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox NameBox;

        #endregion
    }
}
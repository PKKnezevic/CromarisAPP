using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DatabaseConnection
{
    partial class DatabaseQueryForm
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
            string[] tableItems = {"Korisnik","Lokacija","MT","Oprema","RIF","Zaduzenje"};

            this.connectionButton = new System.Windows.Forms.Button();
            this.databaseTables = new System.Windows.Forms.ComboBox();
            
            this.SuspendLayout();
            
            this.connectionButton.Location = new System.Drawing.Point(628, 377);
            this.connectionButton.Name = "connectionButton";
            this.connectionButton.Size = new System.Drawing.Size(160, 61);
            this.connectionButton.TabIndex = 0;
            this.connectionButton.Text = "ConnectToTable";
            this.connectionButton.UseVisualStyleBackColor = true;
            this.connectionButton.Click += new System.EventHandler(this.ConnectionButtonClick);
            
            this.databaseTables.Location = new System.Drawing.Point(628, 340);
            this.databaseTables.Name = "databaseTables";
            this.databaseTables.Size = new System.Drawing.Size(160, 25);
            this.databaseTables.Items.AddRange(tableItems);
            
            //this.AutoScaleDimensions = new System.Drawing.SizeF(8D, 16D);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.databaseTables);
            this.Controls.Add(this.connectionButton);
            this.Name = "DatabaseQueryForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        //Database tables
        private ComboBox databaseTables;
        
        //Button which handles connecting to the database
        private System.Windows.Forms.Button connectionButton;

        #endregion
    }
}
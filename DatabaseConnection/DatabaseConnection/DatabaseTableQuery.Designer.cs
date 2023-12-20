﻿using System.ComponentModel;

namespace DatabaseConnection
{
    partial class DatabaseTableQuery
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.databaseView = new System.Windows.Forms.DataGridView();
            this.connectToDB = new System.Windows.Forms.Button();
            this.databaseTables = new System.Windows.Forms.ComboBox();
            this.addEntry = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.databaseView);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 408);
            this.panel1.TabIndex = 0;
            // 
            // databaseView
            // 
            this.databaseView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.databaseView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.databaseView.Location = new System.Drawing.Point(0, 0);
            this.databaseView.Name = "databaseView";
            this.databaseView.RowTemplate.Height = 24;
            this.databaseView.Size = new System.Drawing.Size(776, 408);
            this.databaseView.TabIndex = 0;
            // 
            // connectToDB
            // 
            this.connectToDB.Location = new System.Drawing.Point(667, 511);
            this.connectToDB.Name = "connectToDB";
            this.connectToDB.Size = new System.Drawing.Size(121, 39);
            this.connectToDB.TabIndex = 1;
            this.connectToDB.Text = "Spoji tablicu";
            this.connectToDB.UseVisualStyleBackColor = true;
            this.connectToDB.Click += new System.EventHandler(this.connectToDB_Click);
            // 
            // databaseTables
            // 
            this.databaseTables.FormattingEnabled = true;
            this.databaseTables.Items.AddRange(new object[] { "Korisnik", "Lokacija", "MT", "RIF", "Oprema", "Zaduzenje" });
            this.databaseTables.Location = new System.Drawing.Point(667, 481);
            this.databaseTables.Name = "databaseTables";
            this.databaseTables.Size = new System.Drawing.Size(121, 24);
            this.databaseTables.TabIndex = 2;
            // 
            // addEntry
            // 
            this.addEntry.Location = new System.Drawing.Point(12, 511);
            this.addEntry.Name = "addEntry";
            this.addEntry.Size = new System.Drawing.Size(100, 39);
            this.addEntry.TabIndex = 3;
            this.addEntry.Text = "Dodaj zapis";
            this.addEntry.UseVisualStyleBackColor = true;
            this.addEntry.Click += new System.EventHandler(this.addEntry_Click);
            // 
            // DatabaseTableQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.addEntry);
            this.Controls.Add(this.databaseTables);
            this.Controls.Add(this.connectToDB);
            this.Controls.Add(this.panel1);
            this.Name = "DatabaseTableQuery";
            this.Text = "DatabaseTableQuery";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.databaseView)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button addEntry;

        private System.Windows.Forms.Button connectToDB;
        private System.Windows.Forms.ComboBox databaseTables;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView databaseView;

        #endregion
    }
}
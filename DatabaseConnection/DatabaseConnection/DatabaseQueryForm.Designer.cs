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
            
            // Element intialization
            this.connectionButton = new System.Windows.Forms.Button();
            this.databaseTables = new System.Windows.Forms.ComboBox();
            this.tablePanel = new System.Windows.Forms.Panel();
            
            this.SuspendLayout();
            
            // Connection button specifics
            this.connectionButton.Location = new System.Drawing.Point(600, 750);
            this.connectionButton.Name = "connectionButton";
            this.connectionButton.Size = new System.Drawing.Size(160, 60);
            this.connectionButton.TabIndex = 0;
            this.connectionButton.Text = "ConnectToTable";
            this.connectionButton.UseVisualStyleBackColor = true;
            this.connectionButton.Click += new System.EventHandler(this.ConnectionButtonClick);
            
            // Combo box which contains database tables elements
            this.databaseTables.Location = new System.Drawing.Point(600, 700);
            this.databaseTables.Name = "databaseTables";
            this.databaseTables.Size = new System.Drawing.Size(160, 25);
            this.databaseTables.Items.AddRange(tableItems);

            // Window panel which contains the table elements for showing each table from the database
            this.tablePanel.Location = new System.Drawing.Point(25, 10);
            this.tablePanel.Size = new System.Drawing.Size(500, 790);
            this.tablePanel.Dock = DockStyle.Fill;
            this.tablePanel.AutoScroll = true;
            this.tablePanel.AutoSize = false;
            
            
            // Adding everything to the window
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 850);
            this.Controls.Add(this.databaseTables);
            this.Controls.Add(this.connectionButton);
            this.Controls.Add(this.tablePanel);
            this.Name = "DatabaseQueryForm";
            this.Text = "OsnovnaSredstva";
            this.ResumeLayout(false);
        }

        //Database tables
        private ComboBox databaseTables;
        
        //Button which handles connecting to the database
        private System.Windows.Forms.Button connectionButton;
        private System.Windows.Forms.Panel tablePanel;

        #endregion
    }
}
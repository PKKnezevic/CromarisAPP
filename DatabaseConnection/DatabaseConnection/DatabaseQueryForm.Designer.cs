using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DatabaseConnection.Models;

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
            this.addNewEleButton = new System.Windows.Forms.Button();
            this.databaseTables = new System.Windows.Forms.ComboBox();
            this.tablePanel = new System.Windows.Forms.Panel();
            this.databaseView = new DataGridView();
            
            this.SuspendLayout();

            this.addNewEleButton.Location = new Point(100, 750);
            this.addNewEleButton.Size = new Size(150, 50);
            this.addNewEleButton.Anchor = AnchorStyles.Left;
            this.addNewEleButton.Name = "addNewEleButton";
            this.addNewEleButton.Text = "Dodaj zapis";
            this.addNewEleButton.TabIndex = 0;
            this.addNewEleButton.Visible = true;
            this.addNewEleButton.Click += new System.EventHandler(this.AddNewEleButtonOnClick);
                
            // Connection button specifics
            this.connectionButton.Location = new System.Drawing.Point(600, 750);
            this.connectionButton.Name = "connectionButton";
            this.connectionButton.Size = new System.Drawing.Size(150, 50);
            this.connectionButton.Anchor = AnchorStyles.Right;
            this.connectionButton.TabIndex = 1;
            this.connectionButton.Text = "Spoji na tablicu";
            this.connectionButton.UseVisualStyleBackColor = true;
            this.connectionButton.Click += new System.EventHandler(this.ConnectionButtonClick);
            
            // Combo box which contains database tables elements
            this.databaseTables.Location = new System.Drawing.Point(600, 700);
            this.databaseTables.Name = "databaseTables";
            this.databaseTables.Size = new System.Drawing.Size(160, 25);
            this.databaseTables.Anchor = AnchorStyles.Right;
            this.databaseTables.TabIndex = 2;
            this.databaseTables.Items.AddRange(tableItems);

            // Window panel which contains the table elements for showing each table from the database
            this.tablePanel.Location = new System.Drawing.Point(25, 10);
            this.tablePanel.Size = new System.Drawing.Size(250, 790);
            this.tablePanel.Dock = DockStyle.Fill;
            this.tablePanel.TabIndex = 3;
            this.tablePanel.AutoScroll = true;
            
            
            this.databaseView.Parent = tablePanel;
            this.databaseView.Dock = DockStyle.Top;
            this.databaseView.Size = new Size(250, 650);
            this.databaseView.TabIndex = 4;
            
            // Adding everything to the window
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 850);
            this.Controls.Add(this.databaseTables);
            this.Controls.Add(this.connectionButton);
            this.Controls.Add(this.tablePanel);
            this.Controls.Add(this.addNewEleButton);
            this.Name = "DatabaseQueryForm";
            this.Text = "OsnovnaSredstva";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        //Database tables
        private ComboBox databaseTables;
        
        //List of all the elements on the window
        private System.Windows.Forms.Button connectionButton;
        private System.Windows.Forms.Panel tablePanel;
        private System.Windows.Forms.DataGridView databaseView;
        private System.Windows.Forms.Button addNewEleButton;

        #endregion
        
    }
}
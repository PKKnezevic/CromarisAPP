using System.ComponentModel;

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
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.columnPickerCBox = new System.Windows.Forms.ComboBox();
            this.columnPickerLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.databaseView.AllowUserToAddRows = false;
            this.databaseView.AllowUserToDeleteRows = false;
            this.databaseView.AllowUserToOrderColumns = true;
            this.databaseView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.databaseView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.databaseView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.databaseView.Location = new System.Drawing.Point(0, 0);
            this.databaseView.Name = "databaseView";
            this.databaseView.RowTemplate.Height = 24;
            this.databaseView.Size = new System.Drawing.Size(776, 408);
            this.databaseView.TabIndex = 0;
            this.databaseView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.databaseView_CellContentClick);
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
            this.addEntry.Location = new System.Drawing.Point(667, 436);
            this.addEntry.Name = "addEntry";
            this.addEntry.Size = new System.Drawing.Size(121, 39);
            this.addEntry.TabIndex = 3;
            this.addEntry.Text = "Dodaj zapis";
            this.addEntry.UseVisualStyleBackColor = true;
            this.addEntry.Click += new System.EventHandler(this.addEntry_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.searchLabel.Location = new System.Drawing.Point(12, 519);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(269, 31);
            this.searchLabel.TabIndex = 4;
            this.searchLabel.Text = "Termin za pretraživanje:";
            this.searchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.searchBox.Location = new System.Drawing.Point(287, 518);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(150, 32);
            this.searchBox.TabIndex = 5;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // columnPickerCBox
            // 
            this.columnPickerCBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.columnPickerCBox.FormattingEnabled = true;
            this.columnPickerCBox.Location = new System.Drawing.Point(187, 441);
            this.columnPickerCBox.Name = "columnPickerCBox";
            this.columnPickerCBox.Size = new System.Drawing.Size(200, 34);
            this.columnPickerCBox.TabIndex = 6;
            // 
            // columnPickerLabel
            // 
            this.columnPickerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.columnPickerLabel.Location = new System.Drawing.Point(12, 441);
            this.columnPickerLabel.Name = "columnPickerLabel";
            this.columnPickerLabel.Size = new System.Drawing.Size(169, 34);
            this.columnPickerLabel.TabIndex = 7;
            this.columnPickerLabel.Text = "Odabir stupca:";
            this.columnPickerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(552, 481);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Odaberi tablicu:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DatabaseTableQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.columnPickerLabel);
            this.Controls.Add(this.columnPickerCBox);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.addEntry);
            this.Controls.Add(this.databaseTables);
            this.Controls.Add(this.connectToDB);
            this.Controls.Add(this.panel1);
            this.Name = "DatabaseTableQuery";
            this.Text = "DatabaseTableQuery";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.databaseView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.ComboBox columnPickerCBox;
        private System.Windows.Forms.Label columnPickerLabel;

        private System.Windows.Forms.TextBox searchBox;

        private System.Windows.Forms.Label searchLabel;

        private System.Windows.Forms.Button addEntry;

        private System.Windows.Forms.Button connectToDB;
        private System.Windows.Forms.ComboBox databaseTables;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView databaseView;

        #endregion
    }
}
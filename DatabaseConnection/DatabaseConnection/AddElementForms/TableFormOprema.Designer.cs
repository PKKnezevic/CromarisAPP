using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace DatabaseConnection.AddElementForms
{
    partial class TableFormOprema
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
            this.AddGear = new System.Windows.Forms.Button();
            this.InternalLabel = new System.Windows.Forms.Label();
            this.SerialLabel = new System.Windows.Forms.Label();
            this.ProviderLabel = new System.Windows.Forms.Label();
            this.RIFLabel = new System.Windows.Forms.Label();
            this.SAPNameLabel = new System.Windows.Forms.Label();
            this.CodeLabel = new System.Windows.Forms.Label();
            this.DateActivationLabel = new System.Windows.Forms.Label();
            this.FondLabel = new System.Windows.Forms.Label();
            this.ReceivingLabel = new System.Windows.Forms.Label();
            this.IPLabel = new System.Windows.Forms.Label();
            this.ReceivingDateLabel = new System.Windows.Forms.Label();
            this.InternalBox = new System.Windows.Forms.TextBox();
            this.ActivationDateBox = new System.Windows.Forms.TextBox();
            this.SAPCodeBox = new System.Windows.Forms.TextBox();
            this.SAPNameBox = new System.Windows.Forms.TextBox();
            this.RIFBox = new System.Windows.Forms.TextBox();
            this.ProviderBox = new System.Windows.Forms.TextBox();
            this.SerialBox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ReceivingDateBox = new System.Windows.Forms.TextBox();
            this.RecivingBox = new System.Windows.Forms.TextBox();
            this.IPBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddGear
            // 
            this.AddGear.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddGear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddGear.Location = new System.Drawing.Point(0, 430);
            this.AddGear.Name = "AddGear";
            this.AddGear.Size = new System.Drawing.Size(782, 54);
            this.AddGear.TabIndex = 0;
            this.AddGear.Text = "Dodaj";
            this.AddGear.UseVisualStyleBackColor = true;
            // 
            // InternalLabel
            // 
            this.InternalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InternalLabel.Location = new System.Drawing.Point(10, 30);
            this.InternalLabel.Name = "InternalLabel";
            this.InternalLabel.Size = new System.Drawing.Size(138, 23);
            this.InternalLabel.TabIndex = 1;
            this.InternalLabel.Text = "Interni Broj:";
            this.InternalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SerialLabel
            // 
            this.SerialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SerialLabel.Location = new System.Drawing.Point(10, 75);
            this.SerialLabel.Name = "SerialLabel";
            this.SerialLabel.Size = new System.Drawing.Size(138, 23);
            this.SerialLabel.TabIndex = 2;
            this.SerialLabel.Text = "Serijski Broj:";
            this.SerialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProviderLabel
            // 
            this.ProviderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ProviderLabel.Location = new System.Drawing.Point(10, 120);
            this.ProviderLabel.Name = "ProviderLabel";
            this.ProviderLabel.Size = new System.Drawing.Size(138, 23);
            this.ProviderLabel.TabIndex = 3;
            this.ProviderLabel.Text = "Dobavljac:";
            this.ProviderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RIFLabel
            // 
            this.RIFLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RIFLabel.Location = new System.Drawing.Point(10, 165);
            this.RIFLabel.Name = "RIFLabel";
            this.RIFLabel.Size = new System.Drawing.Size(138, 23);
            this.RIFLabel.TabIndex = 4;
            this.RIFLabel.Text = "RIF ID:";
            this.RIFLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SAPNameLabel
            // 
            this.SAPNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SAPNameLabel.Location = new System.Drawing.Point(10, 210);
            this.SAPNameLabel.Name = "SAPNameLabel";
            this.SAPNameLabel.Size = new System.Drawing.Size(138, 23);
            this.SAPNameLabel.TabIndex = 5;
            this.SAPNameLabel.Text = "SAP naziv:";
            this.SAPNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CodeLabel
            // 
            this.CodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CodeLabel.Location = new System.Drawing.Point(413, 30);
            this.CodeLabel.Name = "CodeLabel";
            this.CodeLabel.Size = new System.Drawing.Size(131, 23);
            this.CodeLabel.TabIndex = 6;
            this.CodeLabel.Text = "SAP Sifra:";
            this.CodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DateActivationLabel
            // 
            this.DateActivationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DateActivationLabel.Location = new System.Drawing.Point(369, 73);
            this.DateActivationLabel.Name = "DateActivationLabel";
            this.DateActivationLabel.Size = new System.Drawing.Size(175, 23);
            this.DateActivationLabel.TabIndex = 7;
            this.DateActivationLabel.Text = "DAT aktivacije:";
            this.DateActivationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FondLabel
            // 
            this.FondLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FondLabel.Location = new System.Drawing.Point(400, 120);
            this.FondLabel.Name = "FondLabel";
            this.FondLabel.Size = new System.Drawing.Size(144, 23);
            this.FondLabel.TabIndex = 8;
            this.FondLabel.Text = "EU Fond:";
            this.FondLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ReceivingLabel
            // 
            this.ReceivingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ReceivingLabel.Location = new System.Drawing.Point(390, 163);
            this.ReceivingLabel.Name = "ReceivingLabel";
            this.ReceivingLabel.Size = new System.Drawing.Size(154, 23);
            this.ReceivingLabel.TabIndex = 9;
            this.ReceivingLabel.Text = "DAT Primke:";
            this.ReceivingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IPLabel
            // 
            this.IPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IPLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IPLabel.Location = new System.Drawing.Point(144, 310);
            this.IPLabel.Name = "IPLabel";
            this.IPLabel.Size = new System.Drawing.Size(150, 23);
            this.IPLabel.TabIndex = 10;
            this.IPLabel.Text = "IP Adresa:";
            this.IPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ReceivingDateLabel
            // 
            this.ReceivingDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ReceivingDateLabel.Location = new System.Drawing.Point(349, 210);
            this.ReceivingDateLabel.Name = "ReceivingDateLabel";
            this.ReceivingDateLabel.Size = new System.Drawing.Size(195, 23);
            this.ReceivingDateLabel.TabIndex = 11;
            this.ReceivingDateLabel.Text = "DAT Zaprimanja:";
            this.ReceivingDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // InternalBox
            // 
            this.InternalBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InternalBox.Location = new System.Drawing.Point(154, 25);
            this.InternalBox.Name = "InternalBox";
            this.InternalBox.Size = new System.Drawing.Size(175, 32);
            this.InternalBox.TabIndex = 18;
            // 
            // ActivationDateBox
            // 
            this.ActivationDateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ActivationDateBox.Location = new System.Drawing.Point(550, 70);
            this.ActivationDateBox.Name = "ActivationDateBox";
            this.ActivationDateBox.Size = new System.Drawing.Size(175, 32);
            this.ActivationDateBox.TabIndex = 19;
            // 
            // SAPCodeBox
            // 
            this.SAPCodeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SAPCodeBox.Location = new System.Drawing.Point(550, 25);
            this.SAPCodeBox.Name = "SAPCodeBox";
            this.SAPCodeBox.Size = new System.Drawing.Size(175, 32);
            this.SAPCodeBox.TabIndex = 20;
            // 
            // SAPNameBox
            // 
            this.SAPNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SAPNameBox.Location = new System.Drawing.Point(154, 205);
            this.SAPNameBox.Name = "SAPNameBox";
            this.SAPNameBox.Size = new System.Drawing.Size(175, 32);
            this.SAPNameBox.TabIndex = 21;
            // 
            // RIFBox
            // 
            this.RIFBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RIFBox.Location = new System.Drawing.Point(154, 160);
            this.RIFBox.Name = "RIFBox";
            this.RIFBox.Size = new System.Drawing.Size(175, 32);
            this.RIFBox.TabIndex = 22;
            // 
            // ProviderBox
            // 
            this.ProviderBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ProviderBox.Location = new System.Drawing.Point(154, 115);
            this.ProviderBox.Name = "ProviderBox";
            this.ProviderBox.Size = new System.Drawing.Size(175, 32);
            this.ProviderBox.TabIndex = 23;
            // 
            // SerialBox
            // 
            this.SerialBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SerialBox.Location = new System.Drawing.Point(154, 70);
            this.SerialBox.Name = "SerialBox";
            this.SerialBox.Size = new System.Drawing.Size(175, 32);
            this.SerialBox.TabIndex = 24;
            // 
            // checkBox1
            // 
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBox1.Location = new System.Drawing.Point(550, 119);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(24, 24);
            this.checkBox1.TabIndex = 25;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // ReceivingDateBox
            // 
            this.ReceivingDateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ReceivingDateBox.Location = new System.Drawing.Point(550, 205);
            this.ReceivingDateBox.Name = "ReceivingDateBox";
            this.ReceivingDateBox.Size = new System.Drawing.Size(175, 32);
            this.ReceivingDateBox.TabIndex = 26;
            // 
            // RecivingBox
            // 
            this.RecivingBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RecivingBox.Location = new System.Drawing.Point(550, 160);
            this.RecivingBox.Name = "RecivingBox";
            this.RecivingBox.Size = new System.Drawing.Size(175, 32);
            this.RecivingBox.TabIndex = 27;
            // 
            // IPBox
            // 
            this.IPBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.IPBox.Location = new System.Drawing.Point(300, 305);
            this.IPBox.Name = "IPBox";
            this.IPBox.Size = new System.Drawing.Size(175, 32);
            this.IPBox.TabIndex = 28;
            // 
            // TableFormOprema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 484);
            this.Controls.Add(this.IPBox);
            this.Controls.Add(this.RecivingBox);
            this.Controls.Add(this.ReceivingDateBox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.SerialBox);
            this.Controls.Add(this.ProviderBox);
            this.Controls.Add(this.RIFBox);
            this.Controls.Add(this.SAPNameBox);
            this.Controls.Add(this.SAPCodeBox);
            this.Controls.Add(this.ActivationDateBox);
            this.Controls.Add(this.InternalBox);
            this.Controls.Add(this.ReceivingDateLabel);
            this.Controls.Add(this.IPLabel);
            this.Controls.Add(this.ReceivingLabel);
            this.Controls.Add(this.FondLabel);
            this.Controls.Add(this.DateActivationLabel);
            this.Controls.Add(this.CodeLabel);
            this.Controls.Add(this.SAPNameLabel);
            this.Controls.Add(this.RIFLabel);
            this.Controls.Add(this.ProviderLabel);
            this.Controls.Add(this.SerialLabel);
            this.Controls.Add(this.InternalLabel);
            this.Controls.Add(this.AddGear);
            this.Name = "TableFormOprema";
            this.Text = "Oprema";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox ReceivingDateBox;

        private System.Windows.Forms.TextBox RecivingBox;
        private System.Windows.Forms.TextBox IPBox;

        private System.Windows.Forms.CheckBox checkBox1;

        private System.Windows.Forms.TextBox ActivationDateBox;
        private System.Windows.Forms.TextBox SAPCodeBox;
        private System.Windows.Forms.TextBox SAPNameBox;
        private System.Windows.Forms.TextBox RIFBox;
        private System.Windows.Forms.TextBox ProviderBox;
        private System.Windows.Forms.TextBox InternalBox;
        private System.Windows.Forms.TextBox SerialBox;

        private System.Windows.Forms.Label InternalLabel;
        private System.Windows.Forms.Label SerialLabel;
        private System.Windows.Forms.Label ProviderLabel;
        private System.Windows.Forms.Label RIFLabel;
        private System.Windows.Forms.Label SAPNameLabel;
        private System.Windows.Forms.Label CodeLabel;
        private System.Windows.Forms.Label DateActivationLabel;
        private System.Windows.Forms.Label FondLabel;
        private System.Windows.Forms.Label ReceivingLabel;
        private System.Windows.Forms.Label IPLabel;
        private System.Windows.Forms.Label ReceivingDateLabel;

        private System.Windows.Forms.Button AddGear;

        #endregion
    }
}
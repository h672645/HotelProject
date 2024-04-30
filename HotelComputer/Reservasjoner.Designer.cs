using System;

namespace HotelComputer
{
    partial class Reservasjoner
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
            this.reservasjonsliste_liste = new System.Windows.Forms.ListView();
            this.start_dato_selector = new System.Windows.Forms.DateTimePicker();
            this.slutt_dato_selector = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.reservasjonsliste_label = new System.Windows.Forms.Label();
            this.search_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reservasjonsliste_liste
            // 
            this.reservasjonsliste_liste.HideSelection = false;
            this.reservasjonsliste_liste.Location = new System.Drawing.Point(12, 26);
            this.reservasjonsliste_liste.Name = "reservasjonsliste_liste";
            this.reservasjonsliste_liste.Size = new System.Drawing.Size(164, 412);
            this.reservasjonsliste_liste.TabIndex = 1;
            this.reservasjonsliste_liste.UseCompatibleStateImageBehavior = false;
            // 
            // start_dato_selector
            // 
            this.start_dato_selector.Location = new System.Drawing.Point(193, 45);
            this.start_dato_selector.Name = "start_dato_selector";
            this.start_dato_selector.Size = new System.Drawing.Size(200, 20);
            this.start_dato_selector.TabIndex = 4;
            // 
            // slutt_dato_selector
            // 
            this.slutt_dato_selector.Location = new System.Drawing.Point(193, 116);
            this.slutt_dato_selector.Name = "slutt_dato_selector";
            this.slutt_dato_selector.Size = new System.Drawing.Size(200, 20);
            this.slutt_dato_selector.TabIndex = 5;
            this.slutt_dato_selector.Value = new System.DateTime(2025, 4, 30, 14, 46, 0, 0);
            this.slutt_dato_selector.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Start-Dato";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // reservasjonsliste_label
            // 
            this.reservasjonsliste_label.AutoSize = true;
            this.reservasjonsliste_label.Location = new System.Drawing.Point(13, 7);
            this.reservasjonsliste_label.Name = "reservasjonsliste_label";
            this.reservasjonsliste_label.Size = new System.Drawing.Size(89, 13);
            this.reservasjonsliste_label.TabIndex = 7;
            this.reservasjonsliste_label.Text = "Reservasjonsliste";
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(399, 118);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(137, 20);
            this.search_button.TabIndex = 8;
            this.search_button.Text = "Søk";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Slutt-Dato";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(596, 396);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(192, 42);
            this.backButton.TabIndex = 13;
            this.backButton.Text = "Tilbake";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // Reservasjoner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.reservasjonsliste_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.slutt_dato_selector);
            this.Controls.Add(this.start_dato_selector);
            this.Controls.Add(this.reservasjonsliste_liste);
            this.Name = "Reservasjoner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView reservasjonsliste_liste;
        private System.Windows.Forms.DateTimePicker start_dato_selector;
        private System.Windows.Forms.DateTimePicker slutt_dato_selector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label reservasjonsliste_label;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button backButton;
    }


}
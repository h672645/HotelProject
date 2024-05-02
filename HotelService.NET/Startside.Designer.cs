using System;

namespace HotelComputer
{
    partial class Startside
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button cleaning_button;
        private System.Windows.Forms.Button maintenence_button;
        private System.Windows.Forms.Button service_button;

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
            cleaning_button = new Button();
            maintenence_button = new Button();
            service_button = new Button();
            SuspendLayout();
            // 
            // cleaning_button
            // 
            cleaning_button.BackColor = SystemColors.Control;
            cleaning_button.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cleaning_button.Location = new Point(14, 14);
            cleaning_button.Margin = new Padding(4);
            cleaning_button.Name = "cleaning_button";
            cleaning_button.Size = new Size(262, 491);
            cleaning_button.TabIndex = 0;
            cleaning_button.Text = "Maintenance";
            cleaning_button.UseVisualStyleBackColor = true;
            cleaning_button.Click += service_button_Click;
            // 
            // maintenence_button
            // 
            maintenence_button.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maintenence_button.Location = new Point(339, 14);
            maintenence_button.Margin = new Padding(4);
            maintenence_button.Name = "maintenence_button";
            maintenence_button.Size = new Size(262, 491);
            maintenence_button.TabIndex = 2;
            maintenence_button.Text = "Service";
            maintenence_button.UseVisualStyleBackColor = true;
            maintenence_button.Click += maintenence_button_Click;
            // 
            // service_button
            // 
            service_button.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            service_button.Location = new Point(657, 14);
            service_button.Margin = new Padding(4);
            service_button.Name = "service_button";
            service_button.Size = new Size(262, 491);
            service_button.TabIndex = 3;
            service_button.Text = "Service";
            service_button.UseVisualStyleBackColor = true;
            service_button.Click += cleaning_button_Click;
            // 
            // Startside
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 519);
            Controls.Add(service_button);
            Controls.Add(maintenence_button);
            Controls.Add(cleaning_button);
            Margin = new Padding(4);
            Name = "Startside";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
    }
}
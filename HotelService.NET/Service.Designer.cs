using HotelClasses.NET.YourOutputDirectory;
using System.Collections.ObjectModel;

namespace HotelComputer
{
    partial class Service
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
            backButton = new Button();
            listofjobs = new ListView();
            SuspendLayout();
            // 
            // backButton
            // 
            backButton.Location = new Point(696, 457);
            backButton.Margin = new Padding(4, 4, 4, 4);
            backButton.Name = "backButton";
            backButton.Size = new Size(224, 49);
            backButton.TabIndex = 13;
            backButton.Text = "Tilbake";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // listofjobs
            // 
            listofjobs.Location = new Point(113, 74);
            listofjobs.Margin = new Padding(3, 2, 3, 2);
            listofjobs.Name = "listofjobs";
            listofjobs.Size = new Size(613, 301);
            listofjobs.TabIndex = 100;
            listofjobs.UseCompatibleStateImageBehavior = false;
            listofjobs.View = View.Details;

            // Add columns to the ListView
            listofjobs.Columns.Add("RoomID", 100); // Width set to 100 pixels, adjust as needed
            listofjobs.Columns.Add("Tjeneste", 500); // Width set to 500 pixels, adjust as needed


            // 
            // Service
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 519);
            Controls.Add(listofjobs);
            Controls.Add(backButton);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Service";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button backButton;
        private ListView listofjobs;
    }
}
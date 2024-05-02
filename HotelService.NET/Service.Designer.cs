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
            backButton.Location = new Point(795, 609);
            backButton.Margin = new Padding(4, 5, 4, 5);
            backButton.Name = "backButton";
            backButton.Size = new Size(256, 65);
            backButton.TabIndex = 13;
            backButton.Text = "Tilbake";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // listofjobs
            // 
            listofjobs.Location = new Point(129, 98);
            listofjobs.Name = "listofjobs";
            listofjobs.Size = new Size(700, 400);
            listofjobs.TabIndex = 100;
            listofjobs.UseCompatibleStateImageBehavior = false;
            // 
            // Service
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 692);
            Controls.Add(listofjobs);
            Controls.Add(backButton);
            Margin = new Padding(4, 5, 4, 5);
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
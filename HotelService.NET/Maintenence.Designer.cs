namespace HotelComputer
{
    partial class Maintenence
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
            label1 = new Label();
            backButton = new Button();
            listofjobs = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)listofjobs).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 33);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Cleaning";
            // 
            // backButton
            // 
            backButton.Location = new Point(697, 457);
            backButton.Margin = new Padding(4);
            backButton.Name = "backButton";
            backButton.Size = new Size(224, 49);
            backButton.TabIndex = 101;
            backButton.Text = "Tilbake";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click_1;
            // 
            // listofjobs
            // 
            listofjobs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listofjobs.Location = new Point(74, 71);
            listofjobs.Name = "listofjobs";
            listofjobs.Size = new Size(607, 284);
            listofjobs.TabIndex = 102;
            // 
            // Maintenence
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 519);
            Controls.Add(listofjobs);
            Controls.Add(backButton);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "Maintenence";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)listofjobs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button backButton;
        private DataGridView listofjobs;
    }
}
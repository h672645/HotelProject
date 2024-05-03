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
            label1.Location = new Point(126, 44);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Cleaning";
            // 
            // backButton
            // 
            backButton.Location = new Point(797, 609);
            backButton.Margin = new Padding(5, 5, 5, 5);
            backButton.Name = "backButton";
            backButton.Size = new Size(256, 65);
            backButton.TabIndex = 101;
            backButton.Text = "Tilbake";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click_1;
            // 
            // listofjobs
            // 
            listofjobs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listofjobs.Location = new Point(29, 95);
            listofjobs.Margin = new Padding(3, 4, 3, 4);
            listofjobs.Name = "listofjobs";
            listofjobs.RowHeadersWidth = 51;
            listofjobs.Size = new Size(999, 379);
            listofjobs.TabIndex = 102;
            // 
            // Maintenence
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 692);
            Controls.Add(listofjobs);
            Controls.Add(backButton);
            Controls.Add(label1);
            Margin = new Padding(5, 5, 5, 5);
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
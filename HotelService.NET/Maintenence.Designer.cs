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
            button1 = new Button();
            listofjobs = new ListView();
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
            // button1
            // 
            button1.Location = new Point(742, 303);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Return";
            button1.UseVisualStyleBackColor = true;
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
            listofjobs.Columns.Add("RoomNummer", 100); // Width set to 100 pixels, adjust as needed
            listofjobs.Columns.Add("SkalVaskes", 500); // Width set to 500 pixels, adjust as needed
            // Maintenence
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 692);
            Controls.Add(listofjobs);
            Controls.Add(button1);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Maintenence";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private ListView listofjobs;
    }
}
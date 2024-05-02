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
            romvelger_label = new Label();
            rom_label = new Label();
            romvelger_listebox = new ListBox();
            rom_liste = new ListView();
            status_label = new Label();
            status_liste = new ListView();
            reservasjonsliste_liste = new ListView();
            reservasjonsliste_label = new Label();
            tidsrom_liste = new ListView();
            tidsrom_label = new Label();
            backButton = new Button();
            SuspendLayout();
            // 
            // romvelger_label
            // 
            romvelger_label.AutoSize = true;
            romvelger_label.Location = new Point(17, 43);
            romvelger_label.Margin = new Padding(4, 0, 4, 0);
            romvelger_label.Name = "romvelger_label";
            romvelger_label.Size = new Size(91, 20);
            romvelger_label.TabIndex = 1;
            romvelger_label.Text = "Rom-Velger:";
            // 
            // rom_label
            // 
            rom_label.AutoSize = true;
            rom_label.Location = new Point(236, 48);
            rom_label.Margin = new Padding(4, 0, 4, 0);
            rom_label.Name = "rom_label";
            rom_label.Size = new Size(43, 20);
            rom_label.TabIndex = 3;
            rom_label.Text = "Rom:";
            // 
            // romvelger_listebox
            // 
            romvelger_listebox.FormattingEnabled = true;
            romvelger_listebox.Location = new Point(16, 72);
            romvelger_listebox.Margin = new Padding(4, 5, 4, 5);
            romvelger_listebox.Name = "romvelger_listebox";
            romvelger_listebox.Size = new Size(83, 604);
            romvelger_listebox.TabIndex = 4;
            romvelger_listebox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // rom_liste
            // 
            rom_liste.Location = new Point(236, 94);
            rom_liste.Margin = new Padding(4, 5, 4, 5);
            rom_liste.Name = "rom_liste";
            rom_liste.Size = new Size(160, 147);
            rom_liste.TabIndex = 5;
            rom_liste.UseCompatibleStateImageBehavior = false;
            // 
            // status_label
            // 
            status_label.AutoSize = true;
            status_label.Location = new Point(240, 305);
            status_label.Margin = new Padding(4, 0, 4, 0);
            status_label.Name = "status_label";
            status_label.Size = new Size(52, 20);
            status_label.TabIndex = 6;
            status_label.Text = "Status:";
            // 
            // status_liste
            // 
            status_liste.Location = new Point(240, 331);
            status_liste.Margin = new Padding(4, 5, 4, 5);
            status_liste.Name = "status_liste";
            status_liste.Size = new Size(160, 147);
            status_liste.TabIndex = 7;
            status_liste.UseCompatibleStateImageBehavior = false;
            // 
            // reservasjonsliste_liste
            // 
            reservasjonsliste_liste.Location = new Point(723, 72);
            reservasjonsliste_liste.Margin = new Padding(4, 5, 4, 5);
            reservasjonsliste_liste.Name = "reservasjonsliste_liste";
            reservasjonsliste_liste.Size = new Size(163, 406);
            reservasjonsliste_liste.TabIndex = 8;
            reservasjonsliste_liste.UseCompatibleStateImageBehavior = false;
            // 
            // reservasjonsliste_label
            // 
            reservasjonsliste_label.AutoSize = true;
            reservasjonsliste_label.Location = new Point(719, 48);
            reservasjonsliste_label.Margin = new Padding(4, 0, 4, 0);
            reservasjonsliste_label.Name = "reservasjonsliste_label";
            reservasjonsliste_label.Size = new Size(171, 20);
            reservasjonsliste_label.TabIndex = 9;
            reservasjonsliste_label.Text = "Tilhørende reservasjoner";
            // 
            // tidsrom_liste
            // 
            tidsrom_liste.Location = new Point(896, 72);
            tidsrom_liste.Margin = new Padding(4, 5, 4, 5);
            tidsrom_liste.Name = "tidsrom_liste";
            tidsrom_liste.Size = new Size(131, 406);
            tidsrom_liste.TabIndex = 10;
            tidsrom_liste.UseCompatibleStateImageBehavior = false;
            // 
            // tidsrom_label
            // 
            tidsrom_label.AutoSize = true;
            tidsrom_label.Location = new Point(895, 48);
            tidsrom_label.Margin = new Padding(4, 0, 4, 0);
            tidsrom_label.Name = "tidsrom_label";
            tidsrom_label.Size = new Size(72, 20);
            tidsrom_label.TabIndex = 11;
            tidsrom_label.Text = "Tids-rom:";
            // 
            // backButton
            // 
            backButton.Location = new Point(772, 609);
            backButton.Margin = new Padding(4, 5, 4, 5);
            backButton.Name = "backButton";
            backButton.Size = new Size(256, 65);
            backButton.TabIndex = 12;
            backButton.Text = "Tilbake";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // Rom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 692);
            Controls.Add(backButton);
            Controls.Add(tidsrom_label);
            Controls.Add(tidsrom_liste);
            Controls.Add(reservasjonsliste_label);
            Controls.Add(reservasjonsliste_liste);
            Controls.Add(status_liste);
            Controls.Add(status_label);
            Controls.Add(rom_liste);
            Controls.Add(romvelger_listebox);
            Controls.Add(rom_label);
            Controls.Add(romvelger_label);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Rom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label romvelger_label;
        private System.Windows.Forms.Label rom_label;
        private System.Windows.Forms.ListBox romvelger_listebox;
        private System.Windows.Forms.ListView rom_liste;
        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.ListView status_liste;
        private System.Windows.Forms.ListView reservasjonsliste_liste;
        private System.Windows.Forms.Label reservasjonsliste_label;
        private System.Windows.Forms.ListView tidsrom_liste;
        private System.Windows.Forms.Label tidsrom_label;
        private System.Windows.Forms.Button backButton;
    }
}
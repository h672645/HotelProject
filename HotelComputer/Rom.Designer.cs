namespace HotelComputer
{
    partial class Rom
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
            this.romvelger_label = new System.Windows.Forms.Label();
            this.rom_label = new System.Windows.Forms.Label();
            this.romvelger_listebox = new System.Windows.Forms.ListBox();
            this.rom_liste = new System.Windows.Forms.ListView();
            this.status_label = new System.Windows.Forms.Label();
            this.status_liste = new System.Windows.Forms.ListView();
            this.reservasjonsliste_liste = new System.Windows.Forms.ListView();
            this.reservasjonsliste_label = new System.Windows.Forms.Label();
            this.tidsrom_liste = new System.Windows.Forms.ListView();
            this.tidsrom_label = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // romvelger_label
            // 
            this.romvelger_label.AutoSize = true;
            this.romvelger_label.Location = new System.Drawing.Point(13, 28);
            this.romvelger_label.Name = "romvelger_label";
            this.romvelger_label.Size = new System.Drawing.Size(65, 13);
            this.romvelger_label.TabIndex = 1;
            this.romvelger_label.Text = "Rom-Velger:";
            // 
            // rom_label
            // 
            this.rom_label.AutoSize = true;
            this.rom_label.Location = new System.Drawing.Point(177, 31);
            this.rom_label.Name = "rom_label";
            this.rom_label.Size = new System.Drawing.Size(32, 13);
            this.rom_label.TabIndex = 3;
            this.rom_label.Text = "Rom:";
            // 
            // romvelger_listebox
            // 
            this.romvelger_listebox.FormattingEnabled = true;
            this.romvelger_listebox.Location = new System.Drawing.Point(12, 47);
            this.romvelger_listebox.Name = "romvelger_listebox";
            this.romvelger_listebox.Size = new System.Drawing.Size(63, 394);
            this.romvelger_listebox.TabIndex = 4;
            this.romvelger_listebox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // rom_liste
            // 
            this.rom_liste.HideSelection = false;
            this.rom_liste.Location = new System.Drawing.Point(180, 47);
            this.rom_liste.Name = "rom_liste";
            this.rom_liste.Size = new System.Drawing.Size(121, 97);
            this.rom_liste.TabIndex = 5;
            this.rom_liste.UseCompatibleStateImageBehavior = false;
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Location = new System.Drawing.Point(180, 198);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(40, 13);
            this.status_label.TabIndex = 6;
            this.status_label.Text = "Status:";
            // 
            // status_liste
            // 
            this.status_liste.HideSelection = false;
            this.status_liste.Location = new System.Drawing.Point(180, 215);
            this.status_liste.Name = "status_liste";
            this.status_liste.Size = new System.Drawing.Size(121, 97);
            this.status_liste.TabIndex = 7;
            this.status_liste.UseCompatibleStateImageBehavior = false;
            // 
            // reservasjonsliste_liste
            // 
            this.reservasjonsliste_liste.HideSelection = false;
            this.reservasjonsliste_liste.Location = new System.Drawing.Point(542, 47);
            this.reservasjonsliste_liste.Name = "reservasjonsliste_liste";
            this.reservasjonsliste_liste.Size = new System.Drawing.Size(123, 265);
            this.reservasjonsliste_liste.TabIndex = 8;
            this.reservasjonsliste_liste.UseCompatibleStateImageBehavior = false;
            // 
            // reservasjonsliste_label
            // 
            this.reservasjonsliste_label.AutoSize = true;
            this.reservasjonsliste_label.Location = new System.Drawing.Point(539, 31);
            this.reservasjonsliste_label.Name = "reservasjonsliste_label";
            this.reservasjonsliste_label.Size = new System.Drawing.Size(123, 13);
            this.reservasjonsliste_label.TabIndex = 9;
            this.reservasjonsliste_label.Text = "Tilhørende reservasjoner";
            // 
            // tidsrom_liste
            // 
            this.tidsrom_liste.HideSelection = false;
            this.tidsrom_liste.Location = new System.Drawing.Point(672, 47);
            this.tidsrom_liste.Name = "tidsrom_liste";
            this.tidsrom_liste.Size = new System.Drawing.Size(99, 265);
            this.tidsrom_liste.TabIndex = 10;
            this.tidsrom_liste.UseCompatibleStateImageBehavior = false;
            // 
            // tidsrom_label
            // 
            this.tidsrom_label.AutoSize = true;
            this.tidsrom_label.Location = new System.Drawing.Point(671, 31);
            this.tidsrom_label.Name = "tidsrom_label";
            this.tidsrom_label.Size = new System.Drawing.Size(50, 13);
            this.tidsrom_label.TabIndex = 11;
            this.tidsrom_label.Text = "Tids-rom:";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(579, 396);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(192, 42);
            this.backButton.TabIndex = 12;
            this.backButton.Text = "Tilbake";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // Rom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.tidsrom_label);
            this.Controls.Add(this.tidsrom_liste);
            this.Controls.Add(this.reservasjonsliste_label);
            this.Controls.Add(this.reservasjonsliste_liste);
            this.Controls.Add(this.status_liste);
            this.Controls.Add(this.status_label);
            this.Controls.Add(this.rom_liste);
            this.Controls.Add(this.romvelger_listebox);
            this.Controls.Add(this.rom_label);
            this.Controls.Add(this.romvelger_label);
            this.Name = "Rom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

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
namespace HotelComputer
{
    partial class NyReservasjon
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
            this.fornavn_field = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.etternavn_label = new System.Windows.Forms.Label();
            this.etternavn_field = new System.Windows.Forms.TextBox();
            this.registrer_button = new System.Windows.Forms.Button();
            this.start_dato_selector = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.slutt_dato_selector = new System.Windows.Forms.DateTimePicker();
            this.hotellromnr_label = new System.Windows.Forms.Label();
            this.hotellromnr_field = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fornavn_field
            // 
            this.fornavn_field.Location = new System.Drawing.Point(353, 38);
            this.fornavn_field.Name = "fornavn_field";
            this.fornavn_field.Size = new System.Drawing.Size(100, 20);
            this.fornavn_field.TabIndex = 0;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(291, 41);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(49, 13);
            this.name_label.TabIndex = 1;
            this.name_label.Text = "Fornavn:";
            // 
            // etternavn_label
            // 
            this.etternavn_label.AutoSize = true;
            this.etternavn_label.Location = new System.Drawing.Point(291, 79);
            this.etternavn_label.Name = "etternavn_label";
            this.etternavn_label.Size = new System.Drawing.Size(56, 13);
            this.etternavn_label.TabIndex = 3;
            this.etternavn_label.Text = "Etternavn:";
            // 
            // etternavn_field
            // 
            this.etternavn_field.Location = new System.Drawing.Point(353, 76);
            this.etternavn_field.Name = "etternavn_field";
            this.etternavn_field.Size = new System.Drawing.Size(100, 20);
            this.etternavn_field.TabIndex = 2;
            // 
            // registrer_button
            // 
            this.registrer_button.Location = new System.Drawing.Point(353, 330);
            this.registrer_button.Name = "registrer_button";
            this.registrer_button.Size = new System.Drawing.Size(100, 26);
            this.registrer_button.TabIndex = 4;
            this.registrer_button.Text = "Registrer";
            this.registrer_button.UseVisualStyleBackColor = true;
            // 
            // start_dato_selector
            // 
            this.start_dato_selector.Location = new System.Drawing.Point(294, 150);
            this.start_dato_selector.Name = "start_dato_selector";
            this.start_dato_selector.Size = new System.Drawing.Size(200, 20);
            this.start_dato_selector.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(291, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Start-Dato";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(291, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Slutt-Dato";
            // 
            // slutt_dato_selector
            // 
            this.slutt_dato_selector.Location = new System.Drawing.Point(294, 209);
            this.slutt_dato_selector.Name = "slutt_dato_selector";
            this.slutt_dato_selector.Size = new System.Drawing.Size(200, 20);
            this.slutt_dato_selector.TabIndex = 7;
            // 
            // hotellromnr_label
            // 
            this.hotellromnr_label.AutoSize = true;
            this.hotellromnr_label.Location = new System.Drawing.Point(282, 272);
            this.hotellromnr_label.Name = "hotellromnr_label";
            this.hotellromnr_label.Size = new System.Drawing.Size(65, 13);
            this.hotellromnr_label.TabIndex = 10;
            this.hotellromnr_label.Text = "HotellromNr:";
            // 
            // hotellromnr_field
            // 
            this.hotellromnr_field.Location = new System.Drawing.Point(353, 269);
            this.hotellromnr_field.Name = "hotellromnr_field";
            this.hotellromnr_field.Size = new System.Drawing.Size(100, 20);
            this.hotellromnr_field.TabIndex = 9;
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
            // NyReservasjon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.hotellromnr_label);
            this.Controls.Add(this.hotellromnr_field);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.slutt_dato_selector);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.start_dato_selector);
            this.Controls.Add(this.registrer_button);
            this.Controls.Add(this.etternavn_label);
            this.Controls.Add(this.etternavn_field);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.fornavn_field);
            this.Name = "NyReservasjon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fornavn_field;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label etternavn_label;
        private System.Windows.Forms.TextBox etternavn_field;
        private System.Windows.Forms.Button registrer_button;
        private System.Windows.Forms.DateTimePicker start_dato_selector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker slutt_dato_selector;
        private System.Windows.Forms.Label hotellromnr_label;
        private System.Windows.Forms.TextBox hotellromnr_field;
        private System.Windows.Forms.Button backButton;
    }
}
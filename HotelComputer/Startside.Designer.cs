using System;

namespace HotelComputer
{
    partial class Startside
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button reservation_button;
        private System.Windows.Forms.Button room_button;
        private System.Windows.Forms.Button nyReservation_button;

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
            this.reservation_button = new System.Windows.Forms.Button();
            this.room_button = new System.Windows.Forms.Button();
            this.nyReservation_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reservation_button
            // 
            this.reservation_button.BackColor = System.Drawing.SystemColors.Control;
            this.reservation_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservation_button.Location = new System.Drawing.Point(12, 12);
            this.reservation_button.Name = "reservation_button";
            this.reservation_button.Size = new System.Drawing.Size(225, 426);
            this.reservation_button.TabIndex = 0;
            this.reservation_button.Text = "Reservasjoner";
            this.reservation_button.UseVisualStyleBackColor = true;
            this.reservation_button.Click += new System.EventHandler(this.reservation_button_Click);
            // 
            // room_button
            // 
            this.room_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room_button.Location = new System.Drawing.Point(290, 12);
            this.room_button.Name = "room_button";
            this.room_button.Size = new System.Drawing.Size(225, 426);
            this.room_button.TabIndex = 2;
            this.room_button.Text = "Rom";
            this.room_button.UseVisualStyleBackColor = true;
            this.room_button.Click += new System.EventHandler(this.room_button_Click);
            // 
            // nyReservation_button
            // 
            this.nyReservation_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nyReservation_button.Location = new System.Drawing.Point(563, 12);
            this.nyReservation_button.Name = "nyReservation_button";
            this.nyReservation_button.Size = new System.Drawing.Size(225, 426);
            this.nyReservation_button.TabIndex = 3;
            this.nyReservation_button.Text = "Ny Reservasjon";
            this.nyReservation_button.UseVisualStyleBackColor = true;
            this.nyReservation_button.Click += new System.EventHandler(this.nyReservation_button_Click_1);
            // 
            // Startside
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nyReservation_button);
            this.Controls.Add(this.room_button);
            this.Controls.Add(this.reservation_button);
            this.Name = "Startside";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
    }
}


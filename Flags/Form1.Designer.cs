namespace Flags
{
    partial class Form1
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
            this.instructionLabel = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.pbxNZ = new System.Windows.Forms.PictureBox();
            this.pbxPulau = new System.Windows.Forms.PictureBox();
            this.pbxMarshallIslands = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxNZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPulau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMarshallIslands)).BeginInit();
            this.SuspendLayout();
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(89, 9);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(254, 16);
            this.instructionLabel.TabIndex = 3;
            this.instructionLabel.Text = "Click a flag to see the name of the country.";
            // 
            // lblCountry
            // 
            this.lblCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(79, 134);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(274, 23);
            this.lblCountry.TabIndex = 4;
            this.lblCountry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxNZ
            // 
            this.pbxNZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxNZ.Image = global::Flags.Properties.Resources.flagNZ;
            this.pbxNZ.Location = new System.Drawing.Point(272, 44);
            this.pbxNZ.Name = "pbxNZ";
            this.pbxNZ.Size = new System.Drawing.Size(71, 87);
            this.pbxNZ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxNZ.TabIndex = 7;
            this.pbxNZ.TabStop = false;
            this.pbxNZ.Click += new System.EventHandler(this.pbxNZ_Click);
            // 
            // pbxPulau
            // 
            this.pbxPulau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxPulau.Image = global::Flags.Properties.Resources.flagPulau;
            this.pbxPulau.Location = new System.Drawing.Point(92, 44);
            this.pbxPulau.Name = "pbxPulau";
            this.pbxPulau.Size = new System.Drawing.Size(71, 87);
            this.pbxPulau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPulau.TabIndex = 6;
            this.pbxPulau.TabStop = false;
            this.pbxPulau.Click += new System.EventHandler(this.pbxPulau_Click);
            // 
            // pbxMarshallIslands
            // 
            this.pbxMarshallIslands.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxMarshallIslands.Image = global::Flags.Properties.Resources.flagMarshallIslands;
            this.pbxMarshallIslands.Location = new System.Drawing.Point(180, 44);
            this.pbxMarshallIslands.Name = "pbxMarshallIslands";
            this.pbxMarshallIslands.Size = new System.Drawing.Size(71, 87);
            this.pbxMarshallIslands.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMarshallIslands.TabIndex = 5;
            this.pbxMarshallIslands.TabStop = false;
            this.pbxMarshallIslands.Click += new System.EventHandler(this.pbxMarshallIslands_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 174);
            this.Controls.Add(this.pbxNZ);
            this.Controls.Add(this.pbxPulau);
            this.Controls.Add(this.pbxMarshallIslands);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.instructionLabel);
            this.Name = "Form1";
            this.Text = "Flags";
            ((System.ComponentModel.ISupportInitialize)(this.pbxNZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPulau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMarshallIslands)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.PictureBox pbxMarshallIslands;
        private System.Windows.Forms.PictureBox pbxPulau;
        private System.Windows.Forms.PictureBox pbxNZ;
    }
}


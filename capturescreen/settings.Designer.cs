
namespace capturescreen
{
    partial class settings
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
            this.label1 = new System.Windows.Forms.Label();
            this.url = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.localLocation = new System.Windows.Forms.TextBox();
            this.copyImage = new System.Windows.Forms.RadioButton();
            this.copyURL = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.key = new System.Windows.Forms.TextBox();
            this.openPNG = new System.Windows.Forms.CheckBox();
            this.openURL = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 1;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // url
            // 
            this.url.Location = new System.Drawing.Point(117, 200);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(219, 22);
            this.url.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "URL";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "KEY";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // localLocation
            // 
            this.localLocation.ImeMode = System.Windows.Forms.ImeMode.On;
            this.localLocation.Location = new System.Drawing.Point(116, 60);
            this.localLocation.Name = "localLocation";
            this.localLocation.Size = new System.Drawing.Size(219, 22);
            this.localLocation.TabIndex = 5;
            // 
            // copyImage
            // 
            this.copyImage.AutoSize = true;
            this.copyImage.Location = new System.Drawing.Point(116, 115);
            this.copyImage.Name = "copyImage";
            this.copyImage.Size = new System.Drawing.Size(181, 21);
            this.copyImage.TabIndex = 6;
            this.copyImage.TabStop = true;
            this.copyImage.Text = "Copy image to clipboard";
            this.copyImage.UseVisualStyleBackColor = true;
            this.copyImage.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // copyURL
            // 
            this.copyURL.AutoSize = true;
            this.copyURL.Location = new System.Drawing.Point(117, 280);
            this.copyURL.Name = "copyURL";
            this.copyURL.Size = new System.Drawing.Size(171, 21);
            this.copyURL.TabIndex = 7;
            this.copyURL.TabStop = true;
            this.copyURL.Text = "Copy URL to clipboard";
            this.copyURL.UseVisualStyleBackColor = true;
            this.copyURL.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(521, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 8;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.CausesValidation = false;
            this.label5.Location = new System.Drawing.Point(342, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "(leave empty if no upload)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label6.Location = new System.Drawing.Point(6, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 31);
            this.label6.TabIndex = 10;
            this.label6.Text = "Upload Settings";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label7.Location = new System.Drawing.Point(9, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 31);
            this.label7.TabIndex = 11;
            this.label7.Text = "Local Settings";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Save Location";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // key
            // 
            this.key.Location = new System.Drawing.Point(116, 225);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(219, 22);
            this.key.TabIndex = 13;
            // 
            // openPNG
            // 
            this.openPNG.AutoSize = true;
            this.openPNG.Location = new System.Drawing.Point(116, 88);
            this.openPNG.Name = "openPNG";
            this.openPNG.Size = new System.Drawing.Size(99, 21);
            this.openPNG.TabIndex = 14;
            this.openPNG.Text = "Open PNG";
            this.openPNG.UseVisualStyleBackColor = true;
            // 
            // openURL
            // 
            this.openURL.AutoSize = true;
            this.openURL.Location = new System.Drawing.Point(117, 253);
            this.openURL.Name = "openURL";
            this.openURL.Size = new System.Drawing.Size(97, 21);
            this.openURL.TabIndex = 15;
            this.openURL.Text = "Open URL";
            this.openURL.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(341, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "(leave empty if no save)";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(359, 320);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 28);
            this.cancelButton.TabIndex = 17;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(444, 320);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 28);
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.save_click);
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 355);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.openURL);
            this.Controls.Add(this.openPNG);
            this.Controls.Add(this.key);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.copyURL);
            this.Controls.Add(this.copyImage);
            this.Controls.Add(this.localLocation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.url);
            this.Controls.Add(this.label1);
            this.Name = "settings";
            this.Text = "settings";
            this.Load += new System.EventHandler(this.settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox url;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox localLocation;
        private System.Windows.Forms.RadioButton copyImage;
        private System.Windows.Forms.RadioButton copyURL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox key;
        private System.Windows.Forms.CheckBox openPNG;
        private System.Windows.Forms.CheckBox openURL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
    }
}
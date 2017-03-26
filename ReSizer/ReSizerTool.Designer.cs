namespace ReSizer
{
    partial class ReSizerTool
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnResize = new System.Windows.Forms.Button();
            this.chkUwp = new System.Windows.Forms.CheckBox();
            this.chkAndroid = new System.Windows.Forms.CheckBox();
            this.chkiOS = new System.Windows.Forms.CheckBox();
            this.lblUWPValues = new System.Windows.Forms.Label();
            this.lblUWPTitle = new System.Windows.Forms.Label();
            this.lblAndroidValue = new System.Windows.Forms.Label();
            this.lblAndroid = new System.Windows.Forms.Label();
            this.lbliOSValue = new System.Windows.Forms.Label();
            this.lbliOSTitle = new System.Windows.Forms.Label();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.lblBaseImagePath = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnResize);
            this.groupBox1.Controls.Add(this.chkUwp);
            this.groupBox1.Controls.Add(this.chkAndroid);
            this.groupBox1.Controls.Add(this.chkiOS);
            this.groupBox1.Controls.Add(this.lblUWPValues);
            this.groupBox1.Controls.Add(this.lblUWPTitle);
            this.groupBox1.Controls.Add(this.lblAndroidValue);
            this.groupBox1.Controls.Add(this.lblAndroid);
            this.groupBox1.Controls.Add(this.lbliOSValue);
            this.groupBox1.Controls.Add(this.lbliOSTitle);
            this.groupBox1.Controls.Add(this.btnSelectImage);
            this.groupBox1.Controls.Add(this.lblBaseImagePath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 175);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnResize
            // 
            this.btnResize.Location = new System.Drawing.Point(260, 15);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(104, 23);
            this.btnResize.TabIndex = 12;
            this.btnResize.Text = "Re-Size";
            this.btnResize.UseVisualStyleBackColor = true;
            this.btnResize.Click += new System.EventHandler(this.btnResize_Click);
            // 
            // chkUwp
            // 
            this.chkUwp.AutoSize = true;
            this.chkUwp.Location = new System.Drawing.Point(269, 71);
            this.chkUwp.Name = "chkUwp";
            this.chkUwp.Size = new System.Drawing.Size(52, 17);
            this.chkUwp.TabIndex = 11;
            this.chkUwp.Text = "UWP";
            this.chkUwp.UseVisualStyleBackColor = true;
            // 
            // chkAndroid
            // 
            this.chkAndroid.AutoSize = true;
            this.chkAndroid.Location = new System.Drawing.Point(201, 71);
            this.chkAndroid.Name = "chkAndroid";
            this.chkAndroid.Size = new System.Drawing.Size(62, 17);
            this.chkAndroid.TabIndex = 10;
            this.chkAndroid.Text = "Android";
            this.chkAndroid.UseVisualStyleBackColor = true;
            // 
            // chkiOS
            // 
            this.chkiOS.AutoSize = true;
            this.chkiOS.Location = new System.Drawing.Point(152, 71);
            this.chkiOS.Name = "chkiOS";
            this.chkiOS.Size = new System.Drawing.Size(43, 17);
            this.chkiOS.TabIndex = 9;
            this.chkiOS.Text = "iOS";
            this.chkiOS.UseVisualStyleBackColor = true;
            // 
            // lblUWPValues
            // 
            this.lblUWPValues.AutoSize = true;
            this.lblUWPValues.Location = new System.Drawing.Point(149, 147);
            this.lblUWPValues.Name = "lblUWPValues";
            this.lblUWPValues.Size = new System.Drawing.Size(118, 13);
            this.lblUWPValues.TabIndex = 8;
            this.lblUWPValues.Text = "Base Image Path Value";
            this.lblUWPValues.Visible = false;
            // 
            // lblUWPTitle
            // 
            this.lblUWPTitle.AutoSize = true;
            this.lblUWPTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUWPTitle.Location = new System.Drawing.Point(9, 147);
            this.lblUWPTitle.Name = "lblUWPTitle";
            this.lblUWPTitle.Size = new System.Drawing.Size(122, 13);
            this.lblUWPTitle.TabIndex = 7;
            this.lblUWPTitle.Text = "UWP Images Path : ";
            this.lblUWPTitle.Visible = false;
            // 
            // lblAndroidValue
            // 
            this.lblAndroidValue.AutoSize = true;
            this.lblAndroidValue.Location = new System.Drawing.Point(149, 124);
            this.lblAndroidValue.Name = "lblAndroidValue";
            this.lblAndroidValue.Size = new System.Drawing.Size(118, 13);
            this.lblAndroidValue.TabIndex = 6;
            this.lblAndroidValue.Text = "Base Image Path Value";
            this.lblAndroidValue.Visible = false;
            // 
            // lblAndroid
            // 
            this.lblAndroid.AutoSize = true;
            this.lblAndroid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAndroid.Location = new System.Drawing.Point(9, 124);
            this.lblAndroid.Name = "lblAndroid";
            this.lblAndroid.Size = new System.Drawing.Size(136, 13);
            this.lblAndroid.TabIndex = 5;
            this.lblAndroid.Text = "Android Images Path : ";
            this.lblAndroid.Visible = false;
            // 
            // lbliOSValue
            // 
            this.lbliOSValue.AutoSize = true;
            this.lbliOSValue.Location = new System.Drawing.Point(149, 101);
            this.lbliOSValue.Name = "lbliOSValue";
            this.lbliOSValue.Size = new System.Drawing.Size(118, 13);
            this.lbliOSValue.TabIndex = 4;
            this.lbliOSValue.Text = "Base Image Path Value";
            this.lbliOSValue.Visible = false;
            // 
            // lbliOSTitle
            // 
            this.lbliOSTitle.AutoSize = true;
            this.lbliOSTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbliOSTitle.Location = new System.Drawing.Point(9, 101);
            this.lbliOSTitle.Name = "lbliOSTitle";
            this.lbliOSTitle.Size = new System.Drawing.Size(113, 13);
            this.lbliOSTitle.TabIndex = 3;
            this.lbliOSTitle.Text = "iOS Images Path : ";
            this.lbliOSTitle.Visible = false;
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Location = new System.Drawing.Point(150, 15);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(104, 23);
            this.btnSelectImage.TabIndex = 2;
            this.btnSelectImage.Text = "Select Base Image";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // lblBaseImagePath
            // 
            this.lblBaseImagePath.AutoSize = true;
            this.lblBaseImagePath.Location = new System.Drawing.Point(149, 46);
            this.lblBaseImagePath.Name = "lblBaseImagePath";
            this.lblBaseImagePath.Size = new System.Drawing.Size(118, 13);
            this.lblBaseImagePath.TabIndex = 1;
            this.lblBaseImagePath.Text = "Base Image Path Value";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base Image : ";
            // 
            // ReSizerTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 196);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "ReSizerTool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App Image ReSizer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.Label lblBaseImagePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkUwp;
        private System.Windows.Forms.CheckBox chkAndroid;
        private System.Windows.Forms.CheckBox chkiOS;
        private System.Windows.Forms.Label lblUWPValues;
        private System.Windows.Forms.Label lblUWPTitle;
        private System.Windows.Forms.Label lblAndroidValue;
        private System.Windows.Forms.Label lblAndroid;
        private System.Windows.Forms.Label lbliOSValue;
        private System.Windows.Forms.Label lbliOSTitle;
        private System.Windows.Forms.Button btnResize;
    }
}


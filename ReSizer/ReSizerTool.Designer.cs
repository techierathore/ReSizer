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
            this.grpiOS = new System.Windows.Forms.GroupBox();
            this.chkLstiOS = new System.Windows.Forms.CheckedListBox();
            this.chlLstAndroid = new System.Windows.Forms.CheckedListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkLstUwp = new System.Windows.Forms.CheckedListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblNewImagePathValue = new System.Windows.Forms.Label();
            this.lblNewImagePath = new System.Windows.Forms.Label();
            this.txtCusomHeight = new System.Windows.Forms.TextBox();
            this.txtCustomWidth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCustomImgPath = new System.Windows.Forms.Label();
            this.btnReSizeCustom = new System.Windows.Forms.Button();
            this.btnSelectCustomImage = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpiOS.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(26, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(748, 337);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnResize
            // 
            this.btnResize.Location = new System.Drawing.Point(520, 29);
            this.btnResize.Margin = new System.Windows.Forms.Padding(6);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(208, 44);
            this.btnResize.TabIndex = 12;
            this.btnResize.Text = "Re-Size";
            this.btnResize.UseVisualStyleBackColor = true;
            this.btnResize.Click += new System.EventHandler(this.btnResize_Click);
            // 
            // chkUwp
            // 
            this.chkUwp.AutoSize = true;
            this.chkUwp.Location = new System.Drawing.Point(538, 137);
            this.chkUwp.Margin = new System.Windows.Forms.Padding(6);
            this.chkUwp.Name = "chkUwp";
            this.chkUwp.Size = new System.Drawing.Size(93, 29);
            this.chkUwp.TabIndex = 11;
            this.chkUwp.Text = "UWP";
            this.chkUwp.UseVisualStyleBackColor = true;
            // 
            // chkAndroid
            // 
            this.chkAndroid.AutoSize = true;
            this.chkAndroid.Location = new System.Drawing.Point(402, 137);
            this.chkAndroid.Margin = new System.Windows.Forms.Padding(6);
            this.chkAndroid.Name = "chkAndroid";
            this.chkAndroid.Size = new System.Drawing.Size(118, 29);
            this.chkAndroid.TabIndex = 10;
            this.chkAndroid.Text = "Android";
            this.chkAndroid.UseVisualStyleBackColor = true;
            // 
            // chkiOS
            // 
            this.chkiOS.AutoSize = true;
            this.chkiOS.Location = new System.Drawing.Point(304, 137);
            this.chkiOS.Margin = new System.Windows.Forms.Padding(6);
            this.chkiOS.Name = "chkiOS";
            this.chkiOS.Size = new System.Drawing.Size(79, 29);
            this.chkiOS.TabIndex = 9;
            this.chkiOS.Text = "iOS";
            this.chkiOS.UseVisualStyleBackColor = true;
            // 
            // lblUWPValues
            // 
            this.lblUWPValues.AutoSize = true;
            this.lblUWPValues.Location = new System.Drawing.Point(298, 283);
            this.lblUWPValues.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUWPValues.Name = "lblUWPValues";
            this.lblUWPValues.Size = new System.Drawing.Size(236, 25);
            this.lblUWPValues.TabIndex = 8;
            this.lblUWPValues.Text = "Base Image Path Value";
            this.lblUWPValues.Visible = false;
            // 
            // lblUWPTitle
            // 
            this.lblUWPTitle.AutoSize = true;
            this.lblUWPTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUWPTitle.Location = new System.Drawing.Point(18, 283);
            this.lblUWPTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUWPTitle.Name = "lblUWPTitle";
            this.lblUWPTitle.Size = new System.Drawing.Size(229, 26);
            this.lblUWPTitle.TabIndex = 7;
            this.lblUWPTitle.Text = "UWP Images Path : ";
            this.lblUWPTitle.Visible = false;
            // 
            // lblAndroidValue
            // 
            this.lblAndroidValue.AutoSize = true;
            this.lblAndroidValue.Location = new System.Drawing.Point(298, 238);
            this.lblAndroidValue.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAndroidValue.Name = "lblAndroidValue";
            this.lblAndroidValue.Size = new System.Drawing.Size(236, 25);
            this.lblAndroidValue.TabIndex = 6;
            this.lblAndroidValue.Text = "Base Image Path Value";
            this.lblAndroidValue.Visible = false;
            // 
            // lblAndroid
            // 
            this.lblAndroid.AutoSize = true;
            this.lblAndroid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAndroid.Location = new System.Drawing.Point(18, 238);
            this.lblAndroid.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAndroid.Name = "lblAndroid";
            this.lblAndroid.Size = new System.Drawing.Size(256, 26);
            this.lblAndroid.TabIndex = 5;
            this.lblAndroid.Text = "Android Images Path : ";
            this.lblAndroid.Visible = false;
            // 
            // lbliOSValue
            // 
            this.lbliOSValue.AutoSize = true;
            this.lbliOSValue.Location = new System.Drawing.Point(298, 194);
            this.lbliOSValue.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbliOSValue.Name = "lbliOSValue";
            this.lbliOSValue.Size = new System.Drawing.Size(236, 25);
            this.lbliOSValue.TabIndex = 4;
            this.lbliOSValue.Text = "Base Image Path Value";
            this.lbliOSValue.Visible = false;
            // 
            // lbliOSTitle
            // 
            this.lbliOSTitle.AutoSize = true;
            this.lbliOSTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbliOSTitle.Location = new System.Drawing.Point(18, 194);
            this.lbliOSTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbliOSTitle.Name = "lbliOSTitle";
            this.lbliOSTitle.Size = new System.Drawing.Size(214, 26);
            this.lbliOSTitle.TabIndex = 3;
            this.lbliOSTitle.Text = "iOS Images Path : ";
            this.lbliOSTitle.Visible = false;
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Location = new System.Drawing.Point(300, 29);
            this.btnSelectImage.Margin = new System.Windows.Forms.Padding(6);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(208, 44);
            this.btnSelectImage.TabIndex = 2;
            this.btnSelectImage.Text = "Select Base Image";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // lblBaseImagePath
            // 
            this.lblBaseImagePath.AutoSize = true;
            this.lblBaseImagePath.Location = new System.Drawing.Point(298, 88);
            this.lblBaseImagePath.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblBaseImagePath.Name = "lblBaseImagePath";
            this.lblBaseImagePath.Size = new System.Drawing.Size(0, 25);
            this.lblBaseImagePath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base Image : ";
            // 
            // grpiOS
            // 
            this.grpiOS.Controls.Add(this.chkLstiOS);
            this.grpiOS.Location = new System.Drawing.Point(26, 371);
            this.grpiOS.Name = "grpiOS";
            this.grpiOS.Size = new System.Drawing.Size(438, 550);
            this.grpiOS.TabIndex = 1;
            this.grpiOS.TabStop = false;
            this.grpiOS.Text = "iOS Image Sizes";
            // 
            // chkLstiOS
            // 
            this.chkLstiOS.FormattingEnabled = true;
            this.chkLstiOS.Location = new System.Drawing.Point(21, 29);
            this.chkLstiOS.Name = "chkLstiOS";
            this.chkLstiOS.Size = new System.Drawing.Size(394, 498);
            this.chkLstiOS.TabIndex = 0;
            // 
            // chlLstAndroid
            // 
            this.chlLstAndroid.FormattingEnabled = true;
            this.chlLstAndroid.Location = new System.Drawing.Point(20, 30);
            this.chlLstAndroid.Name = "chlLstAndroid";
            this.chlLstAndroid.Size = new System.Drawing.Size(394, 498);
            this.chlLstAndroid.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chlLstAndroid);
            this.groupBox3.Location = new System.Drawing.Point(482, 371);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(438, 550);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Android Image Sizes";
            // 
            // chkLstUwp
            // 
            this.chkLstUwp.FormattingEnabled = true;
            this.chkLstUwp.Location = new System.Drawing.Point(21, 29);
            this.chkLstUwp.Name = "chkLstUwp";
            this.chkLstUwp.Size = new System.Drawing.Size(394, 498);
            this.chkLstUwp.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkLstUwp);
            this.groupBox4.Location = new System.Drawing.Point(942, 371);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(438, 550);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "UWP Image Sizes";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblNewImagePathValue);
            this.groupBox2.Controls.Add(this.lblNewImagePath);
            this.groupBox2.Controls.Add(this.txtCusomHeight);
            this.groupBox2.Controls.Add(this.txtCustomWidth);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblCustomImgPath);
            this.groupBox2.Controls.Add(this.btnReSizeCustom);
            this.groupBox2.Controls.Add(this.btnSelectCustomImage);
            this.groupBox2.Location = new System.Drawing.Point(783, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(597, 324);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create Custom Size Icon";
            // 
            // lblNewImagePathValue
            // 
            this.lblNewImagePathValue.AutoSize = true;
            this.lblNewImagePathValue.Location = new System.Drawing.Point(222, 200);
            this.lblNewImagePathValue.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNewImagePathValue.Name = "lblNewImagePathValue";
            this.lblNewImagePathValue.Size = new System.Drawing.Size(236, 25);
            this.lblNewImagePathValue.TabIndex = 20;
            this.lblNewImagePathValue.Text = "Base Image Path Value";
            this.lblNewImagePathValue.Visible = false;
            // 
            // lblNewImagePath
            // 
            this.lblNewImagePath.AutoSize = true;
            this.lblNewImagePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewImagePath.Location = new System.Drawing.Point(12, 200);
            this.lblNewImagePath.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNewImagePath.Name = "lblNewImagePath";
            this.lblNewImagePath.Size = new System.Drawing.Size(209, 26);
            this.lblNewImagePath.TabIndex = 13;
            this.lblNewImagePath.Text = "New Image Path : ";
            this.lblNewImagePath.Visible = false;
            // 
            // txtCusomHeight
            // 
            this.txtCusomHeight.Location = new System.Drawing.Point(452, 141);
            this.txtCusomHeight.Name = "txtCusomHeight";
            this.txtCusomHeight.Size = new System.Drawing.Size(122, 31);
            this.txtCusomHeight.TabIndex = 18;
            // 
            // txtCustomWidth
            // 
            this.txtCustomWidth.Location = new System.Drawing.Point(159, 141);
            this.txtCustomWidth.Name = "txtCustomWidth";
            this.txtCustomWidth.Size = new System.Drawing.Size(134, 31);
            this.txtCustomWidth.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(302, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 26);
            this.label4.TabIndex = 16;
            this.label4.Text = "New Height : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "New Width : ";
            // 
            // lblCustomImgPath
            // 
            this.lblCustomImgPath.AutoSize = true;
            this.lblCustomImgPath.Location = new System.Drawing.Point(12, 92);
            this.lblCustomImgPath.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCustomImgPath.Name = "lblCustomImgPath";
            this.lblCustomImgPath.Size = new System.Drawing.Size(0, 25);
            this.lblCustomImgPath.TabIndex = 15;
            // 
            // btnReSizeCustom
            // 
            this.btnReSizeCustom.Location = new System.Drawing.Point(17, 261);
            this.btnReSizeCustom.Margin = new System.Windows.Forms.Padding(6);
            this.btnReSizeCustom.Name = "btnReSizeCustom";
            this.btnReSizeCustom.Size = new System.Drawing.Size(557, 44);
            this.btnReSizeCustom.TabIndex = 14;
            this.btnReSizeCustom.Text = "Create Custom Size Icon";
            this.btnReSizeCustom.UseVisualStyleBackColor = true;
            this.btnReSizeCustom.Click += new System.EventHandler(this.btnReSizeCustom_Click);
            // 
            // btnSelectCustomImage
            // 
            this.btnSelectCustomImage.Location = new System.Drawing.Point(17, 33);
            this.btnSelectCustomImage.Margin = new System.Windows.Forms.Padding(6);
            this.btnSelectCustomImage.Name = "btnSelectCustomImage";
            this.btnSelectCustomImage.Size = new System.Drawing.Size(557, 44);
            this.btnSelectCustomImage.TabIndex = 13;
            this.btnSelectCustomImage.Text = "Select Base Image for Custom ReSize";
            this.btnSelectCustomImage.UseVisualStyleBackColor = true;
            this.btnSelectCustomImage.Click += new System.EventHandler(this.btnSelectCustomImage_Click);
            // 
            // ReSizerTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 933);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpiOS);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "ReSizerTool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App Image ReSizer";
            this.Load += new System.EventHandler(this.ReSizerTool_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpiOS.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.GroupBox grpiOS;
        private System.Windows.Forms.CheckedListBox chkLstiOS;
        private System.Windows.Forms.CheckedListBox chlLstAndroid;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckedListBox chkLstUwp;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnReSizeCustom;
        private System.Windows.Forms.Button btnSelectCustomImage;
        private System.Windows.Forms.Label lblNewImagePathValue;
        private System.Windows.Forms.Label lblNewImagePath;
        private System.Windows.Forms.TextBox txtCusomHeight;
        private System.Windows.Forms.TextBox txtCustomWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCustomImgPath;
    }
}


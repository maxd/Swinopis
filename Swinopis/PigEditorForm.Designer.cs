namespace Swinopis
{
    partial class PigEditorForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btCancel = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.udWeight = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.srFunny = new ThirstyCrow.WinForms.Controls.StarRating();
            this.srSpeed = new ThirstyCrow.WinForms.Controls.StarRating();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picPicture = new System.Windows.Forms.PictureBox();
            this.llblBrowseImage = new System.Windows.Forms.LinkLabel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.ctlDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.srGluttony = new ThirstyCrow.WinForms.Controls.StarRating();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udWeight)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btCancel);
            this.panel1.Controls.Add(this.btOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 304);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 60);
            this.panel1.TabIndex = 0;
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(93, 19);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 1;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // btOK
            // 
            this.btOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOK.Location = new System.Drawing.Point(12, 19);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 23);
            this.btOK.TabIndex = 0;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(453, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(12, 143);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(67, 13);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Day Of Birth:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(12, 38);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(453, 85);
            this.txtDescription.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Weight:";
            // 
            // udWeight
            // 
            this.udWeight.Location = new System.Drawing.Point(341, 141);
            this.udWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.udWeight.Name = "udWeight";
            this.udWeight.Size = new System.Drawing.Size(120, 20);
            this.udWeight.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.srGluttony);
            this.groupBox1.Controls.Add(this.srFunny);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.srSpeed);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 112);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Skills";
            // 
            // srFunny
            // 
            this.srFunny.BackColor = System.Drawing.Color.Transparent;
            this.srFunny.ControlLayout = ThirstyCrow.WinForms.Controls.StarRating.Layouts.Horizontal;
            this.srFunny.Location = new System.Drawing.Point(81, 64);
            this.srFunny.Margin = new System.Windows.Forms.Padding(0);
            this.srFunny.Name = "srFunny";
            this.srFunny.Padding = new System.Windows.Forms.Padding(1);
            this.srFunny.Rating = 0;
            this.srFunny.Size = new System.Drawing.Size(102, 22);
            this.srFunny.TabIndex = 3;
            this.srFunny.WrapperPanelBorderStyle = System.Windows.Forms.BorderStyle.None;
            // 
            // srSpeed
            // 
            this.srSpeed.BackColor = System.Drawing.Color.Transparent;
            this.srSpeed.ControlLayout = ThirstyCrow.WinForms.Controls.StarRating.Layouts.Horizontal;
            this.srSpeed.Location = new System.Drawing.Point(81, 33);
            this.srSpeed.Margin = new System.Windows.Forms.Padding(0);
            this.srSpeed.Name = "srSpeed";
            this.srSpeed.Padding = new System.Windows.Forms.Padding(1);
            this.srSpeed.Rating = 0;
            this.srSpeed.Size = new System.Drawing.Size(102, 22);
            this.srSpeed.TabIndex = 2;
            this.srSpeed.WrapperPanelBorderStyle = System.Windows.Forms.BorderStyle.None;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Funny";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Speed";
            // 
            // picPicture
            // 
            this.picPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPicture.Location = new System.Drawing.Point(476, 12);
            this.picPicture.Name = "picPicture";
            this.picPicture.Size = new System.Drawing.Size(334, 254);
            this.picPicture.TabIndex = 9;
            this.picPicture.TabStop = false;
            // 
            // llblBrowseImage
            // 
            this.llblBrowseImage.AutoSize = true;
            this.llblBrowseImage.Location = new System.Drawing.Point(794, 275);
            this.llblBrowseImage.Name = "llblBrowseImage";
            this.llblBrowseImage.Size = new System.Drawing.Size(16, 13);
            this.llblBrowseImage.TabIndex = 10;
            this.llblBrowseImage.TabStop = true;
            this.llblBrowseImage.Text = "...";
            this.llblBrowseImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblBrowseImage_LinkClicked);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // ctlDateOfBirth
            // 
            this.ctlDateOfBirth.Location = new System.Drawing.Point(85, 141);
            this.ctlDateOfBirth.Name = "ctlDateOfBirth";
            this.ctlDateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.ctlDateOfBirth.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Gluttony";
            // 
            // srGluttony
            // 
            this.srGluttony.BackColor = System.Drawing.Color.Transparent;
            this.srGluttony.ControlLayout = ThirstyCrow.WinForms.Controls.StarRating.Layouts.Horizontal;
            this.srGluttony.Location = new System.Drawing.Point(262, 33);
            this.srGluttony.Margin = new System.Windows.Forms.Padding(0);
            this.srGluttony.Name = "srGluttony";
            this.srGluttony.Padding = new System.Windows.Forms.Padding(1);
            this.srGluttony.Rating = 0;
            this.srGluttony.Size = new System.Drawing.Size(102, 22);
            this.srGluttony.TabIndex = 3;
            this.srGluttony.WrapperPanelBorderStyle = System.Windows.Forms.BorderStyle.None;
            // 
            // txtImage
            // 
            this.txtImage.Location = new System.Drawing.Point(476, 272);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(312, 20);
            this.txtImage.TabIndex = 12;
            // 
            // PigEditorForm
            // 
            this.AcceptButton = this.btOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(822, 364);
            this.Controls.Add(this.txtImage);
            this.Controls.Add(this.ctlDateOfBirth);
            this.Controls.Add(this.llblBrowseImage);
            this.Controls.Add(this.picPicture);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.udWeight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.panel1);
            this.Name = "PigEditorForm";
            this.Text = "PigEditorForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.udWeight)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown udWeight;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ThirstyCrow.WinForms.Controls.StarRating srFunny;
        private ThirstyCrow.WinForms.Controls.StarRating srSpeed;
        private System.Windows.Forms.PictureBox picPicture;
        private System.Windows.Forms.LinkLabel llblBrowseImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DateTimePicker ctlDateOfBirth;
        private ThirstyCrow.WinForms.Controls.StarRating srGluttony;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtImage;
    }
}
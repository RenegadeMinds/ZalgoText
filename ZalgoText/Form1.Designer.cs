namespace ZalgoText
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnZalgify = new System.Windows.Forms.Button();
            this.txtText = new System.Windows.Forms.TextBox();
            this.txtZalgo = new System.Windows.Forms.TextBox();
            this.rbMini = new System.Windows.Forms.RadioButton();
            this.gbxFuckUp = new System.Windows.Forms.GroupBox();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.rbMax = new System.Windows.Forms.RadioButton();
            this.chkUp = new System.Windows.Forms.CheckBox();
            this.chkMiddle = new System.Windows.Forms.CheckBox();
            this.chkDown = new System.Windows.Forms.CheckBox();
            this.gbxDirection = new System.Windows.Forms.GroupBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbxFuckUp.SuspendLayout();
            this.gbxDirection.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnZalgify
            // 
            this.btnZalgify.Location = new System.Drawing.Point(354, 212);
            this.btnZalgify.Name = "btnZalgify";
            this.btnZalgify.Size = new System.Drawing.Size(92, 23);
            this.btnZalgify.TabIndex = 0;
            this.btnZalgify.Text = "Zalgify";
            this.btnZalgify.UseVisualStyleBackColor = true;
            this.btnZalgify.Click += new System.EventHandler(this.btnZalgify_Click);
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(12, 12);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtText.Size = new System.Drawing.Size(336, 426);
            this.txtText.TabIndex = 1;
            // 
            // txtZalgo
            // 
            this.txtZalgo.Location = new System.Drawing.Point(452, 12);
            this.txtZalgo.Multiline = true;
            this.txtZalgo.Name = "txtZalgo";
            this.txtZalgo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtZalgo.Size = new System.Drawing.Size(336, 426);
            this.txtZalgo.TabIndex = 2;
            // 
            // rbMini
            // 
            this.rbMini.AutoSize = true;
            this.rbMini.Location = new System.Drawing.Point(13, 19);
            this.rbMini.Name = "rbMini";
            this.rbMini.Size = new System.Drawing.Size(44, 17);
            this.rbMini.TabIndex = 5;
            this.rbMini.Text = "Mini";
            this.rbMini.UseVisualStyleBackColor = true;
            // 
            // gbxFuckUp
            // 
            this.gbxFuckUp.Controls.Add(this.rbMax);
            this.gbxFuckUp.Controls.Add(this.rbNormal);
            this.gbxFuckUp.Controls.Add(this.rbMini);
            this.gbxFuckUp.Location = new System.Drawing.Point(354, 12);
            this.gbxFuckUp.Name = "gbxFuckUp";
            this.gbxFuckUp.Size = new System.Drawing.Size(92, 92);
            this.gbxFuckUp.TabIndex = 6;
            this.gbxFuckUp.TabStop = false;
            this.gbxFuckUp.Text = "Fuck up";
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Checked = true;
            this.rbNormal.Location = new System.Drawing.Point(13, 42);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(58, 17);
            this.rbNormal.TabIndex = 6;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "Normal";
            this.rbNormal.UseVisualStyleBackColor = true;
            // 
            // rbMax
            // 
            this.rbMax.AutoSize = true;
            this.rbMax.Location = new System.Drawing.Point(13, 65);
            this.rbMax.Name = "rbMax";
            this.rbMax.Size = new System.Drawing.Size(45, 17);
            this.rbMax.TabIndex = 7;
            this.rbMax.Text = "Max";
            this.rbMax.UseVisualStyleBackColor = true;
            // 
            // chkUp
            // 
            this.chkUp.AutoSize = true;
            this.chkUp.Checked = true;
            this.chkUp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUp.Location = new System.Drawing.Point(6, 19);
            this.chkUp.Name = "chkUp";
            this.chkUp.Size = new System.Drawing.Size(40, 17);
            this.chkUp.TabIndex = 7;
            this.chkUp.Text = "Up";
            this.chkUp.UseVisualStyleBackColor = true;
            // 
            // chkMiddle
            // 
            this.chkMiddle.AutoSize = true;
            this.chkMiddle.Checked = true;
            this.chkMiddle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMiddle.Location = new System.Drawing.Point(6, 42);
            this.chkMiddle.Name = "chkMiddle";
            this.chkMiddle.Size = new System.Drawing.Size(57, 17);
            this.chkMiddle.TabIndex = 8;
            this.chkMiddle.Text = "Middle";
            this.chkMiddle.UseVisualStyleBackColor = true;
            // 
            // chkDown
            // 
            this.chkDown.AutoSize = true;
            this.chkDown.Checked = true;
            this.chkDown.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDown.Location = new System.Drawing.Point(6, 65);
            this.chkDown.Name = "chkDown";
            this.chkDown.Size = new System.Drawing.Size(54, 17);
            this.chkDown.TabIndex = 9;
            this.chkDown.Text = "Down";
            this.chkDown.UseVisualStyleBackColor = true;
            // 
            // gbxDirection
            // 
            this.gbxDirection.Controls.Add(this.chkUp);
            this.gbxDirection.Controls.Add(this.chkDown);
            this.gbxDirection.Controls.Add(this.chkMiddle);
            this.gbxDirection.Location = new System.Drawing.Point(354, 110);
            this.gbxDirection.Name = "gbxDirection";
            this.gbxDirection.Size = new System.Drawing.Size(92, 96);
            this.gbxDirection.TabIndex = 10;
            this.gbxDirection.TabStop = false;
            this.gbxDirection.Text = "Fuck direction";
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(354, 241);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(92, 23);
            this.btnCopy.TabIndex = 11;
            this.btnCopy.Text = "Copy Zalgo text";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(354, 270);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.gbxDirection);
            this.Controls.Add(this.gbxFuckUp);
            this.Controls.Add(this.txtZalgo);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.btnZalgify);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Zalgo Text - ported from eeemo.net";
            this.gbxFuckUp.ResumeLayout(false);
            this.gbxFuckUp.PerformLayout();
            this.gbxDirection.ResumeLayout(false);
            this.gbxDirection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZalgify;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.TextBox txtZalgo;
        private System.Windows.Forms.RadioButton rbMini;
        private System.Windows.Forms.GroupBox gbxFuckUp;
        private System.Windows.Forms.RadioButton rbMax;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.CheckBox chkUp;
        private System.Windows.Forms.CheckBox chkMiddle;
        private System.Windows.Forms.CheckBox chkDown;
        private System.Windows.Forms.GroupBox gbxDirection;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnClear;
    }
}


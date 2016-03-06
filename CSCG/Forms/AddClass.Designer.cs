namespace CSCG.Forms
{
    partial class AddClass
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cxCtor = new System.Windows.Forms.CheckBox();
            this.cbAccess = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(81, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(274, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Maroon;
            this.lblError.Location = new System.Drawing.Point(78, 80);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(15, 83);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(340, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cxCtor
            // 
            this.cxCtor.AutoSize = true;
            this.cxCtor.Location = new System.Drawing.Point(81, 60);
            this.cxCtor.Name = "cxCtor";
            this.cxCtor.Size = new System.Drawing.Size(139, 17);
            this.cxCtor.TabIndex = 4;
            this.cxCtor.Text = "Add Default Constructor";
            this.cxCtor.UseVisualStyleBackColor = true;
            // 
            // cbAccess
            // 
            this.cbAccess.FormattingEnabled = true;
            this.cbAccess.Location = new System.Drawing.Point(81, 33);
            this.cbAccess.Name = "cbAccess";
            this.cbAccess.Size = new System.Drawing.Size(274, 21);
            this.cbAccess.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Accessibility";
            // 
            // AddClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 116);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbAccess);
            this.Controls.Add(this.cxCtor);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "AddClass";
            this.Text = "Add Class";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox cxCtor;
        private System.Windows.Forms.ComboBox cbAccess;
        private System.Windows.Forms.Label label2;
    }
}
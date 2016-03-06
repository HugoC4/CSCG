namespace CSCG.Forms
{
    partial class AddParameter
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
            this.cbNamespace = new System.Windows.Forms.ComboBox();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.txtNamespace = new System.Windows.Forms.TextBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.cxCustom = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Param Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(82, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(273, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Maroon;
            this.lblError.Location = new System.Drawing.Point(79, 159);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(27, 13);
            this.lblError.TabIndex = 2;
            this.lblError.Text = "asdf";
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(15, 175);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(343, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbNamespace
            // 
            this.cbNamespace.FormattingEnabled = true;
            this.cbNamespace.Location = new System.Drawing.Point(82, 32);
            this.cbNamespace.Name = "cbNamespace";
            this.cbNamespace.Size = new System.Drawing.Size(273, 21);
            this.cbNamespace.TabIndex = 4;
            // 
            // cbClass
            // 
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(82, 59);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(273, 21);
            this.cbClass.TabIndex = 5;
            // 
            // txtNamespace
            // 
            this.txtNamespace.Enabled = false;
            this.txtNamespace.Location = new System.Drawing.Point(82, 110);
            this.txtNamespace.Name = "txtNamespace";
            this.txtNamespace.Size = new System.Drawing.Size(273, 20);
            this.txtNamespace.TabIndex = 6;
            // 
            // txtClass
            // 
            this.txtClass.Enabled = false;
            this.txtClass.Location = new System.Drawing.Point(82, 136);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(273, 20);
            this.txtClass.TabIndex = 7;
            // 
            // cxCustom
            // 
            this.cxCustom.AutoSize = true;
            this.cxCustom.Location = new System.Drawing.Point(82, 87);
            this.cxCustom.Name = "cxCustom";
            this.cxCustom.Size = new System.Drawing.Size(93, 17);
            this.cxCustom.TabIndex = 8;
            this.cxCustom.Text = "Custom Types";
            this.cxCustom.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Namespace";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Class";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Class";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Namespace";
            // 
            // AddParameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 208);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cxCustom);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.txtNamespace);
            this.Controls.Add(this.cbClass);
            this.Controls.Add(this.cbNamespace);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "AddParameter";
            this.Text = "Add Namespace";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbNamespace;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.TextBox txtNamespace;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.CheckBox cxCustom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
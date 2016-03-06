namespace CSCG.Forms
{
    partial class AddCtor
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
            this.lblError = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.paramList = new CSCG.Controls.ParamList();
            this.SuspendLayout();
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Maroon;
            this.lblError.Location = new System.Drawing.Point(127, 153);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(27, 13);
            this.lblError.TabIndex = 2;
            this.lblError.Text = "asdf";
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(9, 166);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(349, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Done";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // paramList
            // 
            this.paramList.Location = new System.Drawing.Point(9, 13);
            this.paramList.Name = "paramList";
            this.paramList.Size = new System.Drawing.Size(352, 140);
            this.paramList.TabIndex = 4;
            // 
            // AddCtor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 198);
            this.Controls.Add(this.paramList);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblError);
            this.Name = "AddCtor";
            this.Text = "Add Constructor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnAdd;
        private Controls.ParamList paramList;
    }
}
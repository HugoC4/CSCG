namespace CSCG.Controls
{
    partial class ParamList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddParam = new System.Windows.Forms.Button();
            this.lbParams = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(61, 90);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(52, 23);
            this.btnDown.TabIndex = 15;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = true;
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(3, 90);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(52, 23);
            this.btnUp.TabIndex = 14;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(3, 61);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(110, 23);
            this.btnRemove.TabIndex = 13;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(3, 32);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 23);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAddParam
            // 
            this.btnAddParam.Location = new System.Drawing.Point(3, 3);
            this.btnAddParam.Name = "btnAddParam";
            this.btnAddParam.Size = new System.Drawing.Size(110, 23);
            this.btnAddParam.TabIndex = 11;
            this.btnAddParam.Text = "Add";
            this.btnAddParam.UseVisualStyleBackColor = true;
            this.btnAddParam.Click += new System.EventHandler(this.btnAddParam_Click);
            // 
            // lbParams
            // 
            this.lbParams.FormattingEnabled = true;
            this.lbParams.Location = new System.Drawing.Point(119, 3);
            this.lbParams.Name = "lbParams";
            this.lbParams.Size = new System.Drawing.Size(230, 134);
            this.lbParams.TabIndex = 10;
            // 
            // ParamList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAddParam);
            this.Controls.Add(this.lbParams);
            this.Name = "ParamList";
            this.Size = new System.Drawing.Size(352, 140);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddParam;
        private System.Windows.Forms.ListBox lbParams;
    }
}

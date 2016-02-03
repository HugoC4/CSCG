using System;

namespace CSCG.Controls
{
    partial class ProjectSummary
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlDates = new System.Windows.Forms.Panel();
            this.lblUpdated = new System.Windows.Forms.Label();
            this.lblCreated = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.tlpMain.SuspendLayout();
            this.tlpInfo.SuspendLayout();
            this.pnlDates.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.tlpInfo, 1, 0);
            this.tlpMain.Controls.Add(this.lblId, 0, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpMain.Size = new System.Drawing.Size(240, 60);
            this.tlpMain.TabIndex = 0;
            // 
            // tlpInfo
            // 
            this.tlpInfo.ColumnCount = 1;
            this.tlpInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInfo.Controls.Add(this.lblTitle, 0, 0);
            this.tlpInfo.Controls.Add(this.pnlDates, 0, 1);
            this.tlpInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInfo.Location = new System.Drawing.Point(60, 0);
            this.tlpInfo.Margin = new System.Windows.Forms.Padding(0);
            this.tlpInfo.Name = "tlpInfo";
            this.tlpInfo.RowCount = 2;
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpInfo.Size = new System.Drawing.Size(180, 60);
            this.tlpInfo.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(174, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "###Title###";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlDates
            // 
            this.pnlDates.Controls.Add(this.lblUpdated);
            this.pnlDates.Controls.Add(this.lblCreated);
            this.pnlDates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDates.Location = new System.Drawing.Point(3, 30);
            this.pnlDates.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.pnlDates.Name = "pnlDates";
            this.pnlDates.Size = new System.Drawing.Size(174, 30);
            this.pnlDates.TabIndex = 1;
            // 
            // lblUpdated
            // 
            this.lblUpdated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUpdated.Location = new System.Drawing.Point(0, 13);
            this.lblUpdated.Margin = new System.Windows.Forms.Padding(3);
            this.lblUpdated.Name = "lblUpdated";
            this.lblUpdated.Size = new System.Drawing.Size(174, 17);
            this.lblUpdated.TabIndex = 1;
            this.lblUpdated.Text = "Updated: ##-##-####";
            // 
            // lblCreated
            // 
            this.lblCreated.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCreated.Location = new System.Drawing.Point(0, 0);
            this.lblCreated.Name = "lblCreated";
            this.lblCreated.Size = new System.Drawing.Size(174, 13);
            this.lblCreated.TabIndex = 0;
            this.lblCreated.Text = "Created: ##-##-####";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(0, 0);
            this.lblId.Margin = new System.Windows.Forms.Padding(0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(60, 60);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "###";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProjectSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpMain);
            this.Name = "ProjectSummary";
            this.Size = new System.Drawing.Size(240, 60);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.tlpInfo.ResumeLayout(false);
            this.pnlDates.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TableLayoutPanel tlpInfo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlDates;
        private System.Windows.Forms.Label lblUpdated;
        private System.Windows.Forms.Label lblCreated;
        private System.Windows.Forms.Label lblId;
    }
}

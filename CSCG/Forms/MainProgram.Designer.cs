namespace CSCG.Forms
{
    partial class MainProgram
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainProgram));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvProject = new System.Windows.Forms.TreeView();
            this.tvProjectImageList = new System.Windows.Forms.ImageList(this.components);
            this.tcProject = new System.Windows.Forms.TabControl();
            this.tpProject = new System.Windows.Forms.TabPage();
            this.lblProjectUpdated = new System.Windows.Forms.Label();
            this.lblProjectCreated = new System.Windows.Forms.Label();
            this.lblProjectNamespace = new System.Windows.Forms.Label();
            this.lblProjectTitle = new System.Windows.Forms.Label();
            this.lblProjectId = new System.Windows.Forms.Label();
            this.tpNamespace = new System.Windows.Forms.TabPage();
            this.tpNamespaces = new System.Windows.Forms.TabPage();
            this.lvNamespaces = new System.Windows.Forms.ListView();
            this.chNsId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNsName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNsNamespace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNsNamespaces = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNsClasses = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNsAbstracts = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNsInterfaces = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tpClass = new System.Windows.Forms.TabPage();
            this.tpClasses = new System.Windows.Forms.TabPage();
            this.tpAbstract = new System.Windows.Forms.TabPage();
            this.tpAbstracts = new System.Windows.Forms.TabPage();
            this.tpInterface = new System.Windows.Forms.TabPage();
            this.tpInterfaces = new System.Windows.Forms.TabPage();
            this.tpConstructor = new System.Windows.Forms.TabPage();
            this.tpConstructors = new System.Windows.Forms.TabPage();
            this.tpProperties = new System.Windows.Forms.TabPage();
            this.tpField = new System.Windows.Forms.TabPage();
            this.tpMethod = new System.Windows.Forms.TabPage();
            this.tpMethods = new System.Windows.Forms.TabPage();
            this.tpParameters = new System.Windows.Forms.TabPage();
            this.cmNamespace = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmNsAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.cmNsAddClass = new System.Windows.Forms.ToolStripMenuItem();
            this.cmNsAddAbstract = new System.Windows.Forms.ToolStripMenuItem();
            this.cmNsAddInterface = new System.Windows.Forms.ToolStripMenuItem();
            this.cmNsAddNamespace = new System.Windows.Forms.ToolStripMenuItem();
            this.cmNsRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.cmClass = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmClassAddConstructor = new System.Windows.Forms.ToolStripMenuItem();
            this.cmClassAddField = new System.Windows.Forms.ToolStripMenuItem();
            this.cmClassAddProperty = new System.Windows.Forms.ToolStripMenuItem();
            this.cmClassAddMethod = new System.Windows.Forms.ToolStripMenuItem();
            this.cmClassRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tcProject.SuspendLayout();
            this.tpProject.SuspendLayout();
            this.tpNamespaces.SuspendLayout();
            this.cmNamespace.SuspendLayout();
            this.cmClass.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.fileToolStripMenuItem,
            this.projectToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(774, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.propertiesToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.projectToolStripMenuItem.Text = "Project";
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.propertiesToolStripMenuItem.Text = "Properties";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvProject);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tcProject);
            this.splitContainer1.Size = new System.Drawing.Size(774, 400);
            this.splitContainer1.SplitterDistance = 320;
            this.splitContainer1.TabIndex = 1;
            // 
            // tvProject
            // 
            this.tvProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvProject.ImageIndex = 0;
            this.tvProject.ImageList = this.tvProjectImageList;
            this.tvProject.Location = new System.Drawing.Point(0, 0);
            this.tvProject.Name = "tvProject";
            this.tvProject.SelectedImageIndex = 0;
            this.tvProject.Size = new System.Drawing.Size(320, 400);
            this.tvProject.TabIndex = 0;
            this.tvProject.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tvProject_MouseUp);
            // 
            // tvProjectImageList
            // 
            this.tvProjectImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("tvProjectImageList.ImageStream")));
            this.tvProjectImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.tvProjectImageList.Images.SetKeyName(0, "ns.png");
            this.tvProjectImageList.Images.SetKeyName(1, "class.png");
            this.tvProjectImageList.Images.SetKeyName(2, "abstract.png");
            this.tvProjectImageList.Images.SetKeyName(3, "interface.png");
            this.tvProjectImageList.Images.SetKeyName(4, "prop.png");
            this.tvProjectImageList.Images.SetKeyName(5, "field.png");
            this.tvProjectImageList.Images.SetKeyName(6, "ctor.png");
            this.tvProjectImageList.Images.SetKeyName(7, "method.png");
            // 
            // tcProject
            // 
            this.tcProject.Controls.Add(this.tpProject);
            this.tcProject.Controls.Add(this.tpNamespace);
            this.tcProject.Controls.Add(this.tpNamespaces);
            this.tcProject.Controls.Add(this.tpClass);
            this.tcProject.Controls.Add(this.tpClasses);
            this.tcProject.Controls.Add(this.tpAbstract);
            this.tcProject.Controls.Add(this.tpAbstracts);
            this.tcProject.Controls.Add(this.tpInterface);
            this.tcProject.Controls.Add(this.tpInterfaces);
            this.tcProject.Controls.Add(this.tpConstructor);
            this.tcProject.Controls.Add(this.tpConstructors);
            this.tcProject.Controls.Add(this.tpProperties);
            this.tcProject.Controls.Add(this.tpField);
            this.tcProject.Controls.Add(this.tpMethod);
            this.tcProject.Controls.Add(this.tpMethods);
            this.tcProject.Controls.Add(this.tpParameters);
            this.tcProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcProject.Location = new System.Drawing.Point(0, 0);
            this.tcProject.Multiline = true;
            this.tcProject.Name = "tcProject";
            this.tcProject.SelectedIndex = 0;
            this.tcProject.Size = new System.Drawing.Size(450, 400);
            this.tcProject.TabIndex = 0;
            // 
            // tpProject
            // 
            this.tpProject.Controls.Add(this.lblProjectUpdated);
            this.tpProject.Controls.Add(this.lblProjectCreated);
            this.tpProject.Controls.Add(this.lblProjectNamespace);
            this.tpProject.Controls.Add(this.lblProjectTitle);
            this.tpProject.Controls.Add(this.lblProjectId);
            this.tpProject.Location = new System.Drawing.Point(4, 58);
            this.tpProject.Name = "tpProject";
            this.tpProject.Padding = new System.Windows.Forms.Padding(3);
            this.tpProject.Size = new System.Drawing.Size(442, 338);
            this.tpProject.TabIndex = 0;
            this.tpProject.Text = "Project";
            this.tpProject.UseVisualStyleBackColor = true;
            // 
            // lblProjectUpdated
            // 
            this.lblProjectUpdated.AutoSize = true;
            this.lblProjectUpdated.Location = new System.Drawing.Point(6, 55);
            this.lblProjectUpdated.Name = "lblProjectUpdated";
            this.lblProjectUpdated.Size = new System.Drawing.Size(136, 13);
            this.lblProjectUpdated.TabIndex = 4;
            this.lblProjectUpdated.Text = "Updated: ##-##-## ##:##";
            // 
            // lblProjectCreated
            // 
            this.lblProjectCreated.AutoSize = true;
            this.lblProjectCreated.Location = new System.Drawing.Point(6, 42);
            this.lblProjectCreated.Name = "lblProjectCreated";
            this.lblProjectCreated.Size = new System.Drawing.Size(132, 13);
            this.lblProjectCreated.TabIndex = 3;
            this.lblProjectCreated.Text = "Created: ##-##-## ##:##";
            // 
            // lblProjectNamespace
            // 
            this.lblProjectNamespace.AutoSize = true;
            this.lblProjectNamespace.Location = new System.Drawing.Point(6, 29);
            this.lblProjectNamespace.Name = "lblProjectNamespace";
            this.lblProjectNamespace.Size = new System.Drawing.Size(115, 13);
            this.lblProjectNamespace.TabIndex = 2;
            this.lblProjectNamespace.Text = "Namespace: ###.###";
            // 
            // lblProjectTitle
            // 
            this.lblProjectTitle.AutoSize = true;
            this.lblProjectTitle.Location = new System.Drawing.Point(6, 16);
            this.lblProjectTitle.Name = "lblProjectTitle";
            this.lblProjectTitle.Size = new System.Drawing.Size(54, 13);
            this.lblProjectTitle.TabIndex = 1;
            this.lblProjectTitle.Text = "Title: ###";
            // 
            // lblProjectId
            // 
            this.lblProjectId.AutoSize = true;
            this.lblProjectId.Location = new System.Drawing.Point(6, 3);
            this.lblProjectId.Name = "lblProjectId";
            this.lblProjectId.Size = new System.Drawing.Size(79, 13);
            this.lblProjectId.TabIndex = 0;
            this.lblProjectId.Text = "Project Id: ###";
            // 
            // tpNamespace
            // 
            this.tpNamespace.Location = new System.Drawing.Point(4, 58);
            this.tpNamespace.Name = "tpNamespace";
            this.tpNamespace.Padding = new System.Windows.Forms.Padding(3);
            this.tpNamespace.Size = new System.Drawing.Size(442, 338);
            this.tpNamespace.TabIndex = 1;
            this.tpNamespace.Text = "Namespace";
            this.tpNamespace.UseVisualStyleBackColor = true;
            // 
            // tpNamespaces
            // 
            this.tpNamespaces.Controls.Add(this.lvNamespaces);
            this.tpNamespaces.Location = new System.Drawing.Point(4, 58);
            this.tpNamespaces.Name = "tpNamespaces";
            this.tpNamespaces.Size = new System.Drawing.Size(442, 338);
            this.tpNamespaces.TabIndex = 7;
            this.tpNamespaces.Text = "Namespaces";
            this.tpNamespaces.UseVisualStyleBackColor = true;
            // 
            // lvNamespaces
            // 
            this.lvNamespaces.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNsId,
            this.chNsName,
            this.chNsNamespace,
            this.chNsNamespaces,
            this.chNsClasses,
            this.chNsAbstracts,
            this.chNsInterfaces});
            this.lvNamespaces.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvNamespaces.Location = new System.Drawing.Point(0, 0);
            this.lvNamespaces.Name = "lvNamespaces";
            this.lvNamespaces.Size = new System.Drawing.Size(442, 338);
            this.lvNamespaces.TabIndex = 0;
            this.lvNamespaces.UseCompatibleStateImageBehavior = false;
            this.lvNamespaces.View = System.Windows.Forms.View.Details;
            // 
            // chNsId
            // 
            this.chNsId.Text = "Id";
            this.chNsId.Width = 20;
            // 
            // chNsName
            // 
            this.chNsName.Text = "Name";
            // 
            // chNsNamespace
            // 
            this.chNsNamespace.Text = "Namespace";
            // 
            // chNsNamespaces
            // 
            this.chNsNamespaces.Text = "Namespaces";
            // 
            // chNsClasses
            // 
            this.chNsClasses.Text = "Classes";
            // 
            // chNsAbstracts
            // 
            this.chNsAbstracts.Text = "Abstract";
            // 
            // chNsInterfaces
            // 
            this.chNsInterfaces.Text = "Interfaces";
            // 
            // tpClass
            // 
            this.tpClass.Location = new System.Drawing.Point(4, 58);
            this.tpClass.Name = "tpClass";
            this.tpClass.Size = new System.Drawing.Size(442, 338);
            this.tpClass.TabIndex = 2;
            this.tpClass.Text = "Class";
            this.tpClass.UseVisualStyleBackColor = true;
            // 
            // tpClasses
            // 
            this.tpClasses.Location = new System.Drawing.Point(4, 58);
            this.tpClasses.Name = "tpClasses";
            this.tpClasses.Size = new System.Drawing.Size(442, 338);
            this.tpClasses.TabIndex = 8;
            this.tpClasses.Text = "Classes";
            this.tpClasses.UseVisualStyleBackColor = true;
            // 
            // tpAbstract
            // 
            this.tpAbstract.Location = new System.Drawing.Point(4, 58);
            this.tpAbstract.Name = "tpAbstract";
            this.tpAbstract.Size = new System.Drawing.Size(442, 338);
            this.tpAbstract.TabIndex = 3;
            this.tpAbstract.Text = "Abstract";
            this.tpAbstract.UseVisualStyleBackColor = true;
            // 
            // tpAbstracts
            // 
            this.tpAbstracts.Location = new System.Drawing.Point(4, 58);
            this.tpAbstracts.Name = "tpAbstracts";
            this.tpAbstracts.Size = new System.Drawing.Size(442, 338);
            this.tpAbstracts.TabIndex = 10;
            this.tpAbstracts.Text = "Abstracts";
            this.tpAbstracts.UseVisualStyleBackColor = true;
            // 
            // tpInterface
            // 
            this.tpInterface.Location = new System.Drawing.Point(4, 58);
            this.tpInterface.Name = "tpInterface";
            this.tpInterface.Size = new System.Drawing.Size(442, 338);
            this.tpInterface.TabIndex = 4;
            this.tpInterface.Text = "Interface";
            this.tpInterface.UseVisualStyleBackColor = true;
            // 
            // tpInterfaces
            // 
            this.tpInterfaces.Location = new System.Drawing.Point(4, 58);
            this.tpInterfaces.Name = "tpInterfaces";
            this.tpInterfaces.Size = new System.Drawing.Size(442, 338);
            this.tpInterfaces.TabIndex = 9;
            this.tpInterfaces.Text = "Interfaces";
            this.tpInterfaces.UseVisualStyleBackColor = true;
            // 
            // tpConstructor
            // 
            this.tpConstructor.Location = new System.Drawing.Point(4, 58);
            this.tpConstructor.Name = "tpConstructor";
            this.tpConstructor.Size = new System.Drawing.Size(442, 338);
            this.tpConstructor.TabIndex = 13;
            this.tpConstructor.Text = "Constructor";
            this.tpConstructor.UseVisualStyleBackColor = true;
            // 
            // tpConstructors
            // 
            this.tpConstructors.Location = new System.Drawing.Point(4, 58);
            this.tpConstructors.Name = "tpConstructors";
            this.tpConstructors.Size = new System.Drawing.Size(442, 338);
            this.tpConstructors.TabIndex = 14;
            this.tpConstructors.Text = "Constructors";
            this.tpConstructors.UseVisualStyleBackColor = true;
            // 
            // tpProperties
            // 
            this.tpProperties.Location = new System.Drawing.Point(4, 58);
            this.tpProperties.Name = "tpProperties";
            this.tpProperties.Size = new System.Drawing.Size(442, 338);
            this.tpProperties.TabIndex = 6;
            this.tpProperties.Text = "Properties";
            this.tpProperties.UseVisualStyleBackColor = true;
            // 
            // tpField
            // 
            this.tpField.Location = new System.Drawing.Point(4, 58);
            this.tpField.Name = "tpField";
            this.tpField.Size = new System.Drawing.Size(442, 338);
            this.tpField.TabIndex = 11;
            this.tpField.Text = "Field";
            this.tpField.UseVisualStyleBackColor = true;
            // 
            // tpMethod
            // 
            this.tpMethod.Location = new System.Drawing.Point(4, 58);
            this.tpMethod.Name = "tpMethod";
            this.tpMethod.Size = new System.Drawing.Size(442, 338);
            this.tpMethod.TabIndex = 15;
            this.tpMethod.Text = "Method";
            this.tpMethod.UseVisualStyleBackColor = true;
            // 
            // tpMethods
            // 
            this.tpMethods.Location = new System.Drawing.Point(4, 58);
            this.tpMethods.Name = "tpMethods";
            this.tpMethods.Size = new System.Drawing.Size(442, 338);
            this.tpMethods.TabIndex = 16;
            this.tpMethods.Text = "Methods";
            this.tpMethods.UseVisualStyleBackColor = true;
            // 
            // tpParameters
            // 
            this.tpParameters.Location = new System.Drawing.Point(4, 58);
            this.tpParameters.Name = "tpParameters";
            this.tpParameters.Size = new System.Drawing.Size(442, 338);
            this.tpParameters.TabIndex = 17;
            this.tpParameters.Text = "Parameters";
            this.tpParameters.UseVisualStyleBackColor = true;
            // 
            // cmNamespace
            // 
            this.cmNamespace.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmNsAdd,
            this.cmNsAddNamespace,
            this.cmNsRemove});
            this.cmNamespace.Name = "cmNamespace";
            this.cmNamespace.Size = new System.Drawing.Size(162, 92);
            // 
            // cmNsAdd
            // 
            this.cmNsAdd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmNsAddClass,
            this.cmNsAddAbstract,
            this.cmNsAddInterface});
            this.cmNsAdd.Name = "cmNsAdd";
            this.cmNsAdd.Size = new System.Drawing.Size(161, 22);
            this.cmNsAdd.Text = "Add Class";
            // 
            // cmNsAddClass
            // 
            this.cmNsAddClass.Name = "cmNsAddClass";
            this.cmNsAddClass.Size = new System.Drawing.Size(120, 22);
            this.cmNsAddClass.Tag = CSCG.NodeType.Class;
            this.cmNsAddClass.Text = "Class";
            this.cmNsAddClass.Click += new System.EventHandler(this.cmNsAddClass_Click);
            // 
            // cmNsAddAbstract
            // 
            this.cmNsAddAbstract.Name = "cmNsAddAbstract";
            this.cmNsAddAbstract.Size = new System.Drawing.Size(120, 22);
            this.cmNsAddAbstract.Tag = CSCG.NodeType.Abstract;
            this.cmNsAddAbstract.Text = "Abstract";
            this.cmNsAddAbstract.Click += new System.EventHandler(this.cmNsAddClass_Click);
            // 
            // cmNsAddInterface
            // 
            this.cmNsAddInterface.Name = "cmNsAddInterface";
            this.cmNsAddInterface.Size = new System.Drawing.Size(120, 22);
            this.cmNsAddInterface.Tag = CSCG.NodeType.Interface;
            this.cmNsAddInterface.Text = "Interface";
            this.cmNsAddInterface.Click += new System.EventHandler(this.cmNsAddClass_Click);
            // 
            // cmNsAddNamespace
            // 
            this.cmNsAddNamespace.Name = "cmNsAddNamespace";
            this.cmNsAddNamespace.Size = new System.Drawing.Size(161, 22);
            this.cmNsAddNamespace.Text = "Add Namespace";
            this.cmNsAddNamespace.Click += new System.EventHandler(this.cmNsAddNamespace_Click);
            // 
            // cmNsRemove
            // 
            this.cmNsRemove.Name = "cmNsRemove";
            this.cmNsRemove.Size = new System.Drawing.Size(161, 22);
            this.cmNsRemove.Text = "Remove";
            this.cmNsRemove.Click += new System.EventHandler(this.cmNsRemove_Click);
            // 
            // cmClass
            // 
            this.cmClass.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmClassAddConstructor,
            this.cmClassAddField,
            this.cmClassAddProperty,
            this.cmClassAddMethod,
            this.cmClassRemove});
            this.cmClass.Name = "cmClass";
            this.cmClass.Size = new System.Drawing.Size(163, 114);
            // 
            // cmClassAddConstructor
            // 
            this.cmClassAddConstructor.Name = "cmClassAddConstructor";
            this.cmClassAddConstructor.Size = new System.Drawing.Size(162, 22);
            this.cmClassAddConstructor.Text = "Add Constructor";
            // 
            // cmClassAddField
            // 
            this.cmClassAddField.Name = "cmClassAddField";
            this.cmClassAddField.Size = new System.Drawing.Size(162, 22);
            this.cmClassAddField.Text = "Add Field";
            // 
            // cmClassAddProperty
            // 
            this.cmClassAddProperty.Name = "cmClassAddProperty";
            this.cmClassAddProperty.Size = new System.Drawing.Size(162, 22);
            this.cmClassAddProperty.Text = "Add Property";
            // 
            // cmClassAddMethod
            // 
            this.cmClassAddMethod.Name = "cmClassAddMethod";
            this.cmClassAddMethod.Size = new System.Drawing.Size(162, 22);
            this.cmClassAddMethod.Text = "Add Method";
            // 
            // cmClassRemove
            // 
            this.cmClassRemove.Name = "cmClassRemove";
            this.cmClassRemove.Size = new System.Drawing.Size(162, 22);
            this.cmClassRemove.Text = "Remove";
            // 
            // MainProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 424);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainProgram";
            this.Text = "Project";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tcProject.ResumeLayout(false);
            this.tpProject.ResumeLayout(false);
            this.tpProject.PerformLayout();
            this.tpNamespaces.ResumeLayout(false);
            this.cmNamespace.ResumeLayout(false);
            this.cmClass.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvProject;
        private System.Windows.Forms.TabControl tcProject;
        private System.Windows.Forms.TabPage tpProject;
        private System.Windows.Forms.TabPage tpNamespace;
        private System.Windows.Forms.TabPage tpNamespaces;
        private System.Windows.Forms.TabPage tpClass;
        private System.Windows.Forms.TabPage tpClasses;
        private System.Windows.Forms.TabPage tpAbstract;
        private System.Windows.Forms.TabPage tpAbstracts;
        private System.Windows.Forms.TabPage tpInterface;
        private System.Windows.Forms.TabPage tpInterfaces;
        private System.Windows.Forms.TabPage tpConstructor;
        private System.Windows.Forms.TabPage tpConstructors;
        private System.Windows.Forms.TabPage tpProperties;
        private System.Windows.Forms.TabPage tpField;
        private System.Windows.Forms.TabPage tpMethod;
        private System.Windows.Forms.TabPage tpMethods;
        private System.Windows.Forms.TabPage tpParameters;
        private System.Windows.Forms.Label lblProjectNamespace;
        private System.Windows.Forms.Label lblProjectTitle;
        private System.Windows.Forms.Label lblProjectId;
        private System.Windows.Forms.Label lblProjectUpdated;
        private System.Windows.Forms.Label lblProjectCreated;
        private System.Windows.Forms.ListView lvNamespaces;
        private System.Windows.Forms.ColumnHeader chNsId;
        private System.Windows.Forms.ColumnHeader chNsName;
        private System.Windows.Forms.ColumnHeader chNsNamespace;
        private System.Windows.Forms.ColumnHeader chNsNamespaces;
        private System.Windows.Forms.ColumnHeader chNsClasses;
        private System.Windows.Forms.ColumnHeader chNsAbstracts;
        private System.Windows.Forms.ColumnHeader chNsInterfaces;
        private System.Windows.Forms.ContextMenuStrip cmNamespace;
        private System.Windows.Forms.ToolStripMenuItem cmNsAdd;
        private System.Windows.Forms.ToolStripMenuItem cmNsRemove;
        private System.Windows.Forms.ToolStripMenuItem cmNsAddClass;
        private System.Windows.Forms.ToolStripMenuItem cmNsAddAbstract;
        private System.Windows.Forms.ToolStripMenuItem cmNsAddInterface;
        private System.Windows.Forms.ToolStripMenuItem cmNsAddNamespace;
        private System.Windows.Forms.ContextMenuStrip cmClass;
        private System.Windows.Forms.ToolStripMenuItem cmClassRemove;
        private System.Windows.Forms.ToolStripMenuItem cmClassAddMethod;
        private System.Windows.Forms.ToolStripMenuItem cmClassAddProperty;
        private System.Windows.Forms.ToolStripMenuItem cmClassAddConstructor;
        private System.Windows.Forms.ToolStripMenuItem cmClassAddField;
        private System.Windows.Forms.ImageList tvProjectImageList;
    }
}
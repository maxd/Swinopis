namespace Swinopis
{
    partial class MainForm
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
            this.mmMain = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuImport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAction = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeleteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStatistic = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAvgWeight = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMinWeight = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMaxWeight = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAuthors = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tbrMain = new System.Windows.Forms.ToolStrip();
            this.btnAvgWeight = new System.Windows.Forms.ToolStripButton();
            this.btnMinWeight = new System.Windows.Forms.ToolStripButton();
            this.btnMaxWeight = new System.Windows.Forms.ToolStripButton();
            this.sbMain = new System.Windows.Forms.StatusStrip();
            this.lblPigCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.alMain = new Crad.Windows.Forms.Actions.ActionList();
            this.actNew = new Crad.Windows.Forms.Actions.Action();
            this.actOpen = new Crad.Windows.Forms.Actions.Action();
            this.actSave = new Crad.Windows.Forms.Actions.Action();
            this.actExport = new Crad.Windows.Forms.Actions.Action();
            this.actImport = new Crad.Windows.Forms.Actions.Action();
            this.actExit = new Crad.Windows.Forms.Actions.Action();
            this.actNewItem = new Crad.Windows.Forms.Actions.Action();
            this.actEditItem = new Crad.Windows.Forms.Actions.Action();
            this.actDeleteItem = new Crad.Windows.Forms.Actions.Action();
            this.actAvgWeight = new Crad.Windows.Forms.Actions.Action();
            this.actMinWeight = new Crad.Windows.Forms.Actions.Action();
            this.actMaxWeight = new Crad.Windows.Forms.Actions.Action();
            this.actHelp = new Crad.Windows.Forms.Actions.Action();
            this.actAuthors = new Crad.Windows.Forms.Actions.Action();
            this.actAbout = new Crad.Windows.Forms.Actions.AboutAction();
            this.cmnuNewItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuEditItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnuDeleteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgDatabase = new System.Windows.Forms.FolderBrowserDialog();
            this.cmnuMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lvPigs = new Swinopis.PigList();
            this.mmMain.SuspendLayout();
            this.tbrMain.SuspendLayout();
            this.sbMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actAbout)).BeginInit();
            this.cmnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mmMain
            // 
            this.mmMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuAction,
            this.mnuStatistic,
            this.helpToolStripMenuItem});
            this.mmMain.Location = new System.Drawing.Point(0, 0);
            this.mmMain.Name = "mmMain";
            this.mmMain.Size = new System.Drawing.Size(870, 24);
            this.mmMain.TabIndex = 0;
            this.mmMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNew,
            this.mnuOpen,
            this.mnuSave,
            this.toolStripMenuItem1,
            this.mnuExport,
            this.mnuImport,
            this.toolStripMenuItem3,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuNew
            // 
            this.alMain.SetAction(this.mnuNew, this.actNew);
            this.mnuNew.Name = "mnuNew";
            this.mnuNew.Size = new System.Drawing.Size(119, 22);
            this.mnuNew.Text = "New";
            // 
            // mnuOpen
            // 
            this.alMain.SetAction(this.mnuOpen, this.actOpen);
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.Size = new System.Drawing.Size(119, 22);
            this.mnuOpen.Text = "Open...";
            // 
            // mnuSave
            // 
            this.alMain.SetAction(this.mnuSave, this.actSave);
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(119, 22);
            this.mnuSave.Text = "Save";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(116, 6);
            // 
            // mnuExport
            // 
            this.alMain.SetAction(this.mnuExport, this.actExport);
            this.mnuExport.Name = "mnuExport";
            this.mnuExport.Size = new System.Drawing.Size(119, 22);
            this.mnuExport.Text = "Export...";
            // 
            // mnuImport
            // 
            this.alMain.SetAction(this.mnuImport, this.actImport);
            this.mnuImport.Name = "mnuImport";
            this.mnuImport.Size = new System.Drawing.Size(119, 22);
            this.mnuImport.Text = "Import...";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(116, 6);
            // 
            // mnuExit
            // 
            this.alMain.SetAction(this.mnuExit, this.actExit);
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(119, 22);
            this.mnuExit.Text = "Exit...";
            // 
            // mnuAction
            // 
            this.mnuAction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNewItem,
            this.mnuEditItem,
            this.mnuDeleteItem});
            this.mnuAction.Name = "mnuAction";
            this.mnuAction.Size = new System.Drawing.Size(54, 20);
            this.mnuAction.Text = "Action";
            // 
            // mnuNewItem
            // 
            this.alMain.SetAction(this.mnuNewItem, this.actNewItem);
            this.mnuNewItem.Name = "mnuNewItem";
            this.mnuNewItem.Size = new System.Drawing.Size(116, 22);
            this.mnuNewItem.Text = "New...";
            // 
            // mnuEditItem
            // 
            this.alMain.SetAction(this.mnuEditItem, this.actEditItem);
            this.mnuEditItem.Name = "mnuEditItem";
            this.mnuEditItem.Size = new System.Drawing.Size(116, 22);
            this.mnuEditItem.Text = "Edit...";
            // 
            // mnuDeleteItem
            // 
            this.alMain.SetAction(this.mnuDeleteItem, this.actDeleteItem);
            this.mnuDeleteItem.Name = "mnuDeleteItem";
            this.mnuDeleteItem.Size = new System.Drawing.Size(116, 22);
            this.mnuDeleteItem.Text = "Delete...";
            // 
            // mnuStatistic
            // 
            this.mnuStatistic.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAvgWeight,
            this.mnuMinWeight,
            this.mnuMaxWeight});
            this.mnuStatistic.Name = "mnuStatistic";
            this.mnuStatistic.Size = new System.Drawing.Size(60, 20);
            this.mnuStatistic.Text = "Statistic";
            // 
            // mnuAvgWeight
            // 
            this.alMain.SetAction(this.mnuAvgWeight, this.actAvgWeight);
            this.mnuAvgWeight.Name = "mnuAvgWeight";
            this.mnuAvgWeight.Size = new System.Drawing.Size(139, 22);
            this.mnuAvgWeight.Text = "Avg. Weight";
            // 
            // mnuMinWeight
            // 
            this.alMain.SetAction(this.mnuMinWeight, this.actMinWeight);
            this.mnuMinWeight.Name = "mnuMinWeight";
            this.mnuMinWeight.Size = new System.Drawing.Size(139, 22);
            this.mnuMinWeight.Text = "Min Weight";
            // 
            // mnuMaxWeight
            // 
            this.alMain.SetAction(this.mnuMaxWeight, this.actMaxWeight);
            this.mnuMaxWeight.Name = "mnuMaxWeight";
            this.mnuMaxWeight.Size = new System.Drawing.Size(139, 22);
            this.mnuMaxWeight.Text = "Max Weight";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelp,
            this.toolStripMenuItem2,
            this.mnuAuthors,
            this.mnuAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // mnuHelp
            // 
            this.alMain.SetAction(this.mnuHelp, this.actHelp);
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(116, 22);
            this.mnuHelp.Text = "Help...";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(113, 6);
            // 
            // mnuAuthors
            // 
            this.alMain.SetAction(this.mnuAuthors, this.actAuthors);
            this.mnuAuthors.Name = "mnuAuthors";
            this.mnuAuthors.Size = new System.Drawing.Size(116, 22);
            this.mnuAuthors.Text = "Authors";
            // 
            // mnuAbout
            // 
            this.alMain.SetAction(this.mnuAbout, this.actAbout);
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(116, 22);
            this.mnuAbout.Text = "About";
            // 
            // tbrMain
            // 
            this.tbrMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAvgWeight,
            this.btnMinWeight,
            this.btnMaxWeight});
            this.tbrMain.Location = new System.Drawing.Point(0, 24);
            this.tbrMain.Name = "tbrMain";
            this.tbrMain.Size = new System.Drawing.Size(870, 25);
            this.tbrMain.TabIndex = 1;
            this.tbrMain.Text = "toolStrip1";
            // 
            // btnAvgWeight
            // 
            this.alMain.SetAction(this.btnAvgWeight, this.actAvgWeight);
            this.btnAvgWeight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAvgWeight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAvgWeight.Name = "btnAvgWeight";
            this.btnAvgWeight.Size = new System.Drawing.Size(23, 22);
            this.btnAvgWeight.Text = "Avg. Weight";
            // 
            // btnMinWeight
            // 
            this.alMain.SetAction(this.btnMinWeight, this.actMinWeight);
            this.btnMinWeight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMinWeight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMinWeight.Name = "btnMinWeight";
            this.btnMinWeight.Size = new System.Drawing.Size(23, 22);
            this.btnMinWeight.Text = "Min Weight";
            // 
            // btnMaxWeight
            // 
            this.alMain.SetAction(this.btnMaxWeight, this.actMaxWeight);
            this.btnMaxWeight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMaxWeight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMaxWeight.Name = "btnMaxWeight";
            this.btnMaxWeight.Size = new System.Drawing.Size(23, 22);
            this.btnMaxWeight.Text = "Max Weight";
            // 
            // sbMain
            // 
            this.sbMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblPigCount});
            this.sbMain.Location = new System.Drawing.Point(0, 469);
            this.sbMain.Name = "sbMain";
            this.sbMain.Size = new System.Drawing.Size(870, 22);
            this.sbMain.TabIndex = 3;
            this.sbMain.Text = "statusStrip1";
            // 
            // lblPigCount
            // 
            this.lblPigCount.Name = "lblPigCount";
            this.lblPigCount.Size = new System.Drawing.Size(32, 17);
            this.lblPigCount.Text = "Pigs:";
            // 
            // alMain
            // 
            this.alMain.Actions.Add(this.actAbout);
            this.alMain.Actions.Add(this.actAuthors);
            this.alMain.Actions.Add(this.actHelp);
            this.alMain.Actions.Add(this.actExit);
            this.alMain.Actions.Add(this.actExport);
            this.alMain.Actions.Add(this.actImport);
            this.alMain.Actions.Add(this.actAvgWeight);
            this.alMain.Actions.Add(this.actMinWeight);
            this.alMain.Actions.Add(this.actMaxWeight);
            this.alMain.Actions.Add(this.actNewItem);
            this.alMain.Actions.Add(this.actEditItem);
            this.alMain.Actions.Add(this.actDeleteItem);
            this.alMain.Actions.Add(this.actOpen);
            this.alMain.Actions.Add(this.actSave);
            this.alMain.Actions.Add(this.actNew);
            this.alMain.ContainerControl = this;
            // 
            // actNew
            // 
            this.actNew.Text = "New";
            this.actNew.Execute += new System.EventHandler(this.actNew_Execute);
            // 
            // actOpen
            // 
            this.actOpen.Text = "Open...";
            this.actOpen.Execute += new System.EventHandler(this.actOpen_Execute);
            // 
            // actSave
            // 
            this.actSave.Text = "Save";
            this.actSave.Execute += new System.EventHandler(this.actSave_Execute);
            // 
            // actExport
            // 
            this.actExport.Text = "Export...";
            // 
            // actImport
            // 
            this.actImport.Text = "Import...";
            // 
            // actExit
            // 
            this.actExit.Text = "Exit...";
            this.actExit.Execute += new System.EventHandler(this.actExit_Execute);
            // 
            // actNewItem
            // 
            this.actNewItem.Text = "New...";
            this.actNewItem.Execute += new System.EventHandler(this.actNewItem_Execute);
            // 
            // actEditItem
            // 
            this.actEditItem.Text = "Edit...";
            this.actEditItem.Execute += new System.EventHandler(this.actEditItem_Execute);
            // 
            // actDeleteItem
            // 
            this.actDeleteItem.Text = "Delete...";
            this.actDeleteItem.Execute += new System.EventHandler(this.actDeleteItem_Execute);
            // 
            // actAvgWeight
            // 
            this.actAvgWeight.Text = "Avg. Weight";
            // 
            // actMinWeight
            // 
            this.actMinWeight.Text = "Min Weight";
            // 
            // actMaxWeight
            // 
            this.actMaxWeight.Text = "Max Weight";
            // 
            // actHelp
            // 
            this.actHelp.Text = "Help...";
            // 
            // actAuthors
            // 
            this.actAuthors.Text = "Authors";
            // 
            // actAbout
            // 
            this.actAbout.Text = "About";
            // 
            // cmnuNewItem
            // 
            this.alMain.SetAction(this.cmnuNewItem, this.actNewItem);
            this.cmnuNewItem.Name = "cmnuNewItem";
            this.cmnuNewItem.Size = new System.Drawing.Size(116, 22);
            this.cmnuNewItem.Text = "New...";
            // 
            // cmnuEditItem
            // 
            this.alMain.SetAction(this.cmnuEditItem, this.actEditItem);
            this.cmnuEditItem.Name = "cmnuEditItem";
            this.cmnuEditItem.Size = new System.Drawing.Size(116, 22);
            this.cmnuEditItem.Text = "Edit...";
            // 
            // cmnuDeleteItem
            // 
            this.alMain.SetAction(this.cmnuDeleteItem, this.actDeleteItem);
            this.cmnuDeleteItem.Name = "cmnuDeleteItem";
            this.cmnuDeleteItem.Size = new System.Drawing.Size(116, 22);
            this.cmnuDeleteItem.Text = "Delete...";
            // 
            // dlgDatabase
            // 
            this.dlgDatabase.RootFolder = System.Environment.SpecialFolder.CommonDocuments;
            // 
            // cmnuMain
            // 
            this.cmnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmnuNewItem,
            this.cmnuEditItem,
            this.cmnuDeleteItem});
            this.cmnuMain.Name = "cmnuMain";
            this.cmnuMain.Size = new System.Drawing.Size(117, 70);
            // 
            // lvPigs
            // 
            this.lvPigs.ContextMenuStrip = this.cmnuMain;
            this.lvPigs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPigs.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lvPigs.ItemHeight = 32;
            this.lvPigs.Location = new System.Drawing.Point(0, 49);
            this.lvPigs.Name = "lvPigs";
            this.lvPigs.Size = new System.Drawing.Size(870, 420);
            this.lvPigs.TabIndex = 4;
            this.lvPigs.DoubleClick += new System.EventHandler(this.actEditItem_Execute);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 491);
            this.Controls.Add(this.lvPigs);
            this.Controls.Add(this.sbMain);
            this.Controls.Add(this.tbrMain);
            this.Controls.Add(this.mmMain);
            this.MainMenuStrip = this.mmMain;
            this.Name = "MainForm";
            this.Text = "Свинопись 2010";
            this.mmMain.ResumeLayout(false);
            this.mmMain.PerformLayout();
            this.tbrMain.ResumeLayout(false);
            this.tbrMain.PerformLayout();
            this.sbMain.ResumeLayout(false);
            this.sbMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actAbout)).EndInit();
            this.cmnuMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mmMain;
        private System.Windows.Forms.ToolStripMenuItem mnuAction;
        private System.Windows.Forms.ToolStripMenuItem mnuStatistic;
        private System.Windows.Forms.ToolStripMenuItem mnuAvgWeight;
        private System.Windows.Forms.ToolStripMenuItem mnuMinWeight;
        private System.Windows.Forms.ToolStripMenuItem mnuMaxWeight;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuAuthors;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStrip tbrMain;
        private System.Windows.Forms.ToolStripButton btnAvgWeight;
        private System.Windows.Forms.ToolStripButton btnMinWeight;
        private System.Windows.Forms.ToolStripButton btnMaxWeight;
        private Crad.Windows.Forms.Actions.ActionList alMain;
        private Crad.Windows.Forms.Actions.AboutAction actAbout;
        private Crad.Windows.Forms.Actions.Action actAuthors;
        private Crad.Windows.Forms.Actions.Action actHelp;
        private Crad.Windows.Forms.Actions.Action actExit;
        private Crad.Windows.Forms.Actions.Action actExport;
        private Crad.Windows.Forms.Actions.Action actImport;
        private Crad.Windows.Forms.Actions.Action actAvgWeight;
        private Crad.Windows.Forms.Actions.Action actMinWeight;
        private Crad.Windows.Forms.Actions.Action actMaxWeight;
        private System.Windows.Forms.StatusStrip sbMain;
        private System.Windows.Forms.ToolStripMenuItem mnuNewItem;
        private Crad.Windows.Forms.Actions.Action actNewItem;
        private Crad.Windows.Forms.Actions.Action actEditItem;
        private Crad.Windows.Forms.Actions.Action actDeleteItem;
        private System.Windows.Forms.ToolStripMenuItem mnuEditItem;
        private System.Windows.Forms.ToolStripMenuItem mnuDeleteItem;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private Crad.Windows.Forms.Actions.Action actOpen;
        private Crad.Windows.Forms.Actions.Action actSave;
        private System.Windows.Forms.ToolStripMenuItem mnuNew;
        private Crad.Windows.Forms.Actions.Action actNew;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuExport;
        private System.Windows.Forms.ToolStripMenuItem mnuImport;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.FolderBrowserDialog dlgDatabase;
        private PigList lvPigs;
        private System.Windows.Forms.ContextMenuStrip cmnuMain;
        private System.Windows.Forms.ToolStripMenuItem cmnuNewItem;
        private System.Windows.Forms.ToolStripMenuItem cmnuEditItem;
        private System.Windows.Forms.ToolStripMenuItem cmnuDeleteItem;
        private System.Windows.Forms.ToolStripStatusLabel lblPigCount;
    }
}
namespace Aydsko.iRacingSdkSample.Client;

partial class Main
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
        var resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
        menuStripMain = new MenuStrip();
        menuItemFile = new ToolStripMenuItem();
        menuItemFileOpen = new ToolStripMenuItem();
        toolStripSeparator1 = new ToolStripSeparator();
        menuItemFileExit = new ToolStripMenuItem();
        editToolStripMenuItem = new ToolStripMenuItem();
        undoToolStripMenuItem = new ToolStripMenuItem();
        redoToolStripMenuItem = new ToolStripMenuItem();
        toolStripSeparator3 = new ToolStripSeparator();
        cutToolStripMenuItem = new ToolStripMenuItem();
        copyToolStripMenuItem = new ToolStripMenuItem();
        pasteToolStripMenuItem = new ToolStripMenuItem();
        toolStripSeparator4 = new ToolStripSeparator();
        selectAllToolStripMenuItem = new ToolStripMenuItem();
        menuItemHelp = new ToolStripMenuItem();
        menuItemHelpAbout = new ToolStripMenuItem();
        textSessionStringDisplay = new TextBox();
        splitContainer1 = new SplitContainer();
        labelSessionStringHeader = new Label();
        gridViewTelemetryVariables = new DataGridView();
        labelSessionVariables = new Label();
        menuStripMain.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
        splitContainer1.Panel1.SuspendLayout();
        splitContainer1.Panel2.SuspendLayout();
        splitContainer1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)gridViewTelemetryVariables).BeginInit();
        SuspendLayout();
        // 
        // menuStripMain
        // 
        menuStripMain.Items.AddRange(new ToolStripItem[] { menuItemFile, editToolStripMenuItem, menuItemHelp });
        menuStripMain.Location = new Point(0, 0);
        menuStripMain.Name = "menuStripMain";
        menuStripMain.Size = new Size(784, 24);
        menuStripMain.TabIndex = 0;
        menuStripMain.Text = "menuStrip1";
        // 
        // menuItemFile
        // 
        menuItemFile.DropDownItems.AddRange(new ToolStripItem[] { menuItemFileOpen, toolStripSeparator1, menuItemFileExit });
        menuItemFile.Name = "menuItemFile";
        menuItemFile.Size = new Size(37, 20);
        menuItemFile.Text = "&File";
        // 
        // menuItemFileOpen
        // 
        menuItemFileOpen.Image = (Image)resources.GetObject("menuItemFileOpen.Image");
        menuItemFileOpen.ImageTransparentColor = Color.Magenta;
        menuItemFileOpen.Name = "menuItemFileOpen";
        menuItemFileOpen.ShortcutKeys = Keys.Control | Keys.O;
        menuItemFileOpen.Size = new Size(146, 22);
        menuItemFileOpen.Text = "&Open";
        menuItemFileOpen.Click += MenuItemFileOpen_Click;
        // 
        // toolStripSeparator1
        // 
        toolStripSeparator1.Name = "toolStripSeparator1";
        toolStripSeparator1.Size = new Size(143, 6);
        // 
        // menuItemFileExit
        // 
        menuItemFileExit.Name = "menuItemFileExit";
        menuItemFileExit.Size = new Size(146, 22);
        menuItemFileExit.Text = "E&xit";
        menuItemFileExit.Click += MenuItemFileExit_Click;
        // 
        // editToolStripMenuItem
        // 
        editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, toolStripSeparator3, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, toolStripSeparator4, selectAllToolStripMenuItem });
        editToolStripMenuItem.Name = "editToolStripMenuItem";
        editToolStripMenuItem.Size = new Size(39, 20);
        editToolStripMenuItem.Text = "&Edit";
        // 
        // undoToolStripMenuItem
        // 
        undoToolStripMenuItem.Name = "undoToolStripMenuItem";
        undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
        undoToolStripMenuItem.Size = new Size(144, 22);
        undoToolStripMenuItem.Text = "&Undo";
        // 
        // redoToolStripMenuItem
        // 
        redoToolStripMenuItem.Name = "redoToolStripMenuItem";
        redoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
        redoToolStripMenuItem.Size = new Size(144, 22);
        redoToolStripMenuItem.Text = "&Redo";
        // 
        // toolStripSeparator3
        // 
        toolStripSeparator3.Name = "toolStripSeparator3";
        toolStripSeparator3.Size = new Size(141, 6);
        // 
        // cutToolStripMenuItem
        // 
        cutToolStripMenuItem.Image = (Image)resources.GetObject("cutToolStripMenuItem.Image");
        cutToolStripMenuItem.ImageTransparentColor = Color.Magenta;
        cutToolStripMenuItem.Name = "cutToolStripMenuItem";
        cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
        cutToolStripMenuItem.Size = new Size(144, 22);
        cutToolStripMenuItem.Text = "Cu&t";
        // 
        // copyToolStripMenuItem
        // 
        copyToolStripMenuItem.Image = (Image)resources.GetObject("copyToolStripMenuItem.Image");
        copyToolStripMenuItem.ImageTransparentColor = Color.Magenta;
        copyToolStripMenuItem.Name = "copyToolStripMenuItem";
        copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
        copyToolStripMenuItem.Size = new Size(144, 22);
        copyToolStripMenuItem.Text = "&Copy";
        // 
        // pasteToolStripMenuItem
        // 
        pasteToolStripMenuItem.Image = (Image)resources.GetObject("pasteToolStripMenuItem.Image");
        pasteToolStripMenuItem.ImageTransparentColor = Color.Magenta;
        pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
        pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
        pasteToolStripMenuItem.Size = new Size(144, 22);
        pasteToolStripMenuItem.Text = "&Paste";
        // 
        // toolStripSeparator4
        // 
        toolStripSeparator4.Name = "toolStripSeparator4";
        toolStripSeparator4.Size = new Size(141, 6);
        // 
        // selectAllToolStripMenuItem
        // 
        selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
        selectAllToolStripMenuItem.Size = new Size(144, 22);
        selectAllToolStripMenuItem.Text = "Select &All";
        // 
        // menuItemHelp
        // 
        menuItemHelp.DropDownItems.AddRange(new ToolStripItem[] { menuItemHelpAbout });
        menuItemHelp.Name = "menuItemHelp";
        menuItemHelp.Size = new Size(44, 20);
        menuItemHelp.Text = "&Help";
        // 
        // menuItemHelpAbout
        // 
        menuItemHelpAbout.Name = "menuItemHelpAbout";
        menuItemHelpAbout.Size = new Size(116, 22);
        menuItemHelpAbout.Text = "&About...";
        menuItemHelpAbout.Click += MenuItemHelpAbout_Click;
        // 
        // textSessionStringDisplay
        // 
        textSessionStringDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        textSessionStringDisplay.BackColor = SystemColors.Window;
        textSessionStringDisplay.Font = new Font("Consolas", 10F);
        textSessionStringDisplay.Location = new Point(0, 34);
        textSessionStringDisplay.Multiline = true;
        textSessionStringDisplay.Name = "textSessionStringDisplay";
        textSessionStringDisplay.ReadOnly = true;
        textSessionStringDisplay.ScrollBars = ScrollBars.Both;
        textSessionStringDisplay.Size = new Size(784, 234);
        textSessionStringDisplay.TabIndex = 1;
        // 
        // splitContainer1
        // 
        splitContainer1.Dock = DockStyle.Fill;
        splitContainer1.Location = new Point(0, 24);
        splitContainer1.Name = "splitContainer1";
        splitContainer1.Orientation = Orientation.Horizontal;
        // 
        // splitContainer1.Panel1
        // 
        splitContainer1.Panel1.Controls.Add(labelSessionStringHeader);
        splitContainer1.Panel1.Controls.Add(textSessionStringDisplay);
        // 
        // splitContainer1.Panel2
        // 
        splitContainer1.Panel2.Controls.Add(gridViewTelemetryVariables);
        splitContainer1.Panel2.Controls.Add(labelSessionVariables);
        splitContainer1.Size = new Size(784, 537);
        splitContainer1.SplitterDistance = 268;
        splitContainer1.TabIndex = 2;
        // 
        // labelSessionStringHeader
        // 
        labelSessionStringHeader.AutoSize = true;
        labelSessionStringHeader.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        labelSessionStringHeader.Location = new Point(12, 11);
        labelSessionStringHeader.Name = "labelSessionStringHeader";
        labelSessionStringHeader.Size = new Size(168, 20);
        labelSessionStringHeader.TabIndex = 2;
        labelSessionStringHeader.Text = "Session String (YAML):";
        // 
        // gridViewTelemetryVariables
        // 
        gridViewTelemetryVariables.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        gridViewTelemetryVariables.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        gridViewTelemetryVariables.Location = new Point(0, 35);
        gridViewTelemetryVariables.Name = "gridViewTelemetryVariables";
        gridViewTelemetryVariables.Size = new Size(784, 230);
        gridViewTelemetryVariables.TabIndex = 4;
        // 
        // labelSessionVariables
        // 
        labelSessionVariables.AutoSize = true;
        labelSessionVariables.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        labelSessionVariables.Location = new Point(12, 12);
        labelSessionVariables.Name = "labelSessionVariables";
        labelSessionVariables.Size = new Size(132, 20);
        labelSessionVariables.TabIndex = 3;
        labelSessionVariables.Text = "Session Variables:";
        // 
        // Main
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(784, 561);
        Controls.Add(splitContainer1);
        Controls.Add(menuStripMain);
        Margin = new Padding(2);
        MinimumSize = new Size(100, 100);
        Name = "Main";
        Text = "iRacing SDK Sample";
        FormClosed += Main_FormClosed;
        Load += Main_Load;
        menuStripMain.ResumeLayout(false);
        menuStripMain.PerformLayout();
        splitContainer1.Panel1.ResumeLayout(false);
        splitContainer1.Panel1.PerformLayout();
        splitContainer1.Panel2.ResumeLayout(false);
        splitContainer1.Panel2.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
        splitContainer1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)gridViewTelemetryVariables).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private MenuStrip menuStripMain;
    private ToolStripMenuItem menuItemFile;
    private ToolStripMenuItem menuItemFileOpen;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripMenuItem menuItemFileExit;
    private ToolStripMenuItem editToolStripMenuItem;
    private ToolStripMenuItem undoToolStripMenuItem;
    private ToolStripMenuItem redoToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator3;
    private ToolStripMenuItem cutToolStripMenuItem;
    private ToolStripMenuItem copyToolStripMenuItem;
    private ToolStripMenuItem pasteToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator4;
    private ToolStripMenuItem selectAllToolStripMenuItem;
    private ToolStripMenuItem menuItemHelp;
    private ToolStripMenuItem menuItemHelpAbout;
    private TextBox textSessionStringDisplay;
    private SplitContainer splitContainer1;
    private Label labelSessionStringHeader;
    private DataGridView gridViewTelemetryVariables;
    private Label labelSessionVariables;
}

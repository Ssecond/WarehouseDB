namespace DataBase
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            Table = new DataGridView();
            Close = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            listOfTables = new ListBox();
            menuStrip1 = new MenuStrip();
            FileToolStripMenuItem = new ToolStripMenuItem();
            OpenDBToolStripMenuItem = new ToolStripMenuItem();
            ExitToolStripMenuItem = new ToolStripMenuItem();
            EditToolStripMenuItem = new ToolStripMenuItem();
            QAToolStripMenuItem = new ToolStripMenuItem();
            AboutProgramToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)Table).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Table
            // 
            resources.ApplyResources(Table, "Table");
            Table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Table.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Table.Name = "Table";
            Table.RowTemplate.Height = 29;
            // 
            // Close
            // 
            resources.ApplyResources(Close, "Close");
            Close.Name = "Close";
            Close.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Controls.Add(Table);
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            resources.ApplyResources(groupBox2, "groupBox2");
            groupBox2.Controls.Add(listOfTables);
            groupBox2.Name = "groupBox2";
            groupBox2.TabStop = false;
            // 
            // listOfTables
            // 
            resources.ApplyResources(listOfTables, "listOfTables");
            listOfTables.FormattingEnabled = true;
            listOfTables.Name = "listOfTables";
            listOfTables.SelectedValueChanged += listOfTables_SelectedValueChanged;
            // 
            // menuStrip1
            // 
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { FileToolStripMenuItem, EditToolStripMenuItem, QAToolStripMenuItem });
            menuStrip1.Name = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            resources.ApplyResources(FileToolStripMenuItem, "FileToolStripMenuItem");
            FileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { OpenDBToolStripMenuItem, ExitToolStripMenuItem });
            FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            // 
            // OpenDBToolStripMenuItem
            // 
            resources.ApplyResources(OpenDBToolStripMenuItem, "OpenDBToolStripMenuItem");
            OpenDBToolStripMenuItem.Name = "OpenDBToolStripMenuItem";
            OpenDBToolStripMenuItem.Click += ConnectDBToolStripMenuItem_Click;
            // 
            // ExitToolStripMenuItem
            // 
            resources.ApplyResources(ExitToolStripMenuItem, "ExitToolStripMenuItem");
            ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            ExitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // EditToolStripMenuItem
            // 
            resources.ApplyResources(EditToolStripMenuItem, "EditToolStripMenuItem");
            EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            // 
            // QAToolStripMenuItem
            // 
            resources.ApplyResources(QAToolStripMenuItem, "QAToolStripMenuItem");
            QAToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AboutProgramToolStripMenuItem });
            QAToolStripMenuItem.Name = "QAToolStripMenuItem";
            // 
            // AboutProgramToolStripMenuItem
            // 
            resources.ApplyResources(AboutProgramToolStripMenuItem, "AboutProgramToolStripMenuItem");
            AboutProgramToolStripMenuItem.Name = "AboutProgramToolStripMenuItem";
            AboutProgramToolStripMenuItem.Click += AboutProgramToolStripMenuItem_Click;
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(Close);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainWindow";
            FormClosed += MainWindow_FormClosed;
            ((System.ComponentModel.ISupportInitialize)Table).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Table;
        private Button Close;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem FileToolStripMenuItem;
        private ToolStripMenuItem EditToolStripMenuItem;
        private ToolStripMenuItem QAToolStripMenuItem;
        private ToolStripMenuItem OpenDBToolStripMenuItem;
        private ToolStripMenuItem ExitToolStripMenuItem;
        private ToolStripMenuItem AboutProgramToolStripMenuItem;
        private ListBox listOfTables;
    }
}
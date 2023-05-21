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
            viewTables = new DataGridView();
            Close = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            listOfTables = new ListBox();
            menuStrip1 = new MenuStrip();
            FileToolStripMenuItem = new ToolStripMenuItem();
            RefreshToolStripMenuItem = new ToolStripMenuItem();
            ExitToolStripMenuItem = new ToolStripMenuItem();
            QAToolStripMenuItem = new ToolStripMenuItem();
            AboutProgramToolStripMenuItem = new ToolStripMenuItem();
            editNote = new Button();
            exit = new Button();
            createNewNote = new Button();
            deleteNote = new Button();
            ((System.ComponentModel.ISupportInitialize)viewTables).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // viewTables
            // 
            resources.ApplyResources(viewTables, "viewTables");
            viewTables.AllowUserToAddRows = false;
            viewTables.AllowUserToDeleteRows = false;
            viewTables.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            viewTables.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            viewTables.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            viewTables.Name = "viewTables";
            viewTables.ReadOnly = true;
            viewTables.RowTemplate.Height = 29;
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
            groupBox1.Controls.Add(viewTables);
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { FileToolStripMenuItem, QAToolStripMenuItem });
            menuStrip1.Name = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            resources.ApplyResources(FileToolStripMenuItem, "FileToolStripMenuItem");
            FileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { RefreshToolStripMenuItem, ExitToolStripMenuItem });
            FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            // 
            // RefreshToolStripMenuItem
            // 
            resources.ApplyResources(RefreshToolStripMenuItem, "RefreshToolStripMenuItem");
            RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem";
            RefreshToolStripMenuItem.Click += RefreshToolStripMenuItem_Click;
            // 
            // ExitToolStripMenuItem
            // 
            resources.ApplyResources(ExitToolStripMenuItem, "ExitToolStripMenuItem");
            ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            ExitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
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
            // editNote
            // 
            resources.ApplyResources(editNote, "editNote");
            editNote.Name = "editNote";
            editNote.UseVisualStyleBackColor = true;
            editNote.Click += editNote_Click;
            // 
            // exit
            // 
            resources.ApplyResources(exit, "exit");
            exit.Name = "exit";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // createNewNote
            // 
            resources.ApplyResources(createNewNote, "createNewNote");
            createNewNote.Name = "createNewNote";
            createNewNote.UseVisualStyleBackColor = true;
            createNewNote.Click += createNewNote_Click;
            // 
            // deleteNote
            // 
            resources.ApplyResources(deleteNote, "deleteNote");
            deleteNote.Name = "deleteNote";
            deleteNote.UseVisualStyleBackColor = true;
            deleteNote.Click += deleteNote_Click;
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(deleteNote);
            Controls.Add(createNewNote);
            Controls.Add(exit);
            Controls.Add(editNote);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(Close);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainWindow";
            ((System.ComponentModel.ISupportInitialize)viewTables).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView viewTables;
        private Button Close;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem FileToolStripMenuItem;
        private ToolStripMenuItem QAToolStripMenuItem;
        private ToolStripMenuItem RefreshToolStripMenuItem;
        private ToolStripMenuItem ExitToolStripMenuItem;
        private ToolStripMenuItem AboutProgramToolStripMenuItem;
        private ListBox listOfTables;
        private Button editNote;
        private Button exit;
        private Button createNewNote;
        private Button deleteNote;
    }
}
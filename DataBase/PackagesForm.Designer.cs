namespace DataBase
{
    partial class PackagesForm
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
            idLabel = new Label();
            name = new Label();
            idTextBox = new TextBox();
            textBox1 = new TextBox();
            clearForm = new Button();
            insertNewNote = new Button();
            closeForm = new Button();
            saveChanges = new Button();
            SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(12, 9);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(24, 15);
            idLabel.TabIndex = 18;
            idLabel.Text = "ИД";
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(12, 37);
            name.Name = "name";
            name.Size = new Size(59, 15);
            name.TabIndex = 19;
            name.Text = "Название";
            // 
            // idTextBox
            // 
            idTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            idTextBox.Location = new Point(228, 6);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(490, 23);
            idTextBox.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(228, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(490, 23);
            textBox1.TabIndex = 13;
            // 
            // clearForm
            // 
            clearForm.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            clearForm.Location = new Point(222, 77);
            clearForm.Name = "clearForm";
            clearForm.Size = new Size(128, 23);
            clearForm.TabIndex = 11;
            clearForm.Text = "Отчистить все поля";
            clearForm.UseVisualStyleBackColor = true;
            // 
            // insertNewNote
            // 
            insertNewNote.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            insertNewNote.Location = new Point(566, 77);
            insertNewNote.Name = "insertNewNote";
            insertNewNote.Size = new Size(145, 23);
            insertNewNote.TabIndex = 10;
            insertNewNote.Text = "Вставить новую запись";
            insertNewNote.UseVisualStyleBackColor = true;
            // 
            // closeForm
            // 
            closeForm.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            closeForm.Location = new Point(12, 77);
            closeForm.Name = "closeForm";
            closeForm.Size = new Size(115, 23);
            closeForm.TabIndex = 9;
            closeForm.Text = "Закрыть форму";
            closeForm.UseVisualStyleBackColor = true;
            // 
            // saveChanges
            // 
            saveChanges.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveChanges.Location = new Point(366, 77);
            saveChanges.Name = "saveChanges";
            saveChanges.Size = new Size(194, 23);
            saveChanges.TabIndex = 8;
            saveChanges.Text = "Сохранить изменения сущ. зап.";
            saveChanges.UseVisualStyleBackColor = true;
            // 
            // PackagesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 112);
            Controls.Add(idLabel);
            Controls.Add(name);
            Controls.Add(idTextBox);
            Controls.Add(textBox1);
            Controls.Add(clearForm);
            Controls.Add(insertNewNote);
            Controls.Add(closeForm);
            Controls.Add(saveChanges);
            Name = "PackagesForm";
            Text = "Справочник упаковок";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label idLabel;
        private Label name;
        private TextBox idTextBox;
        private TextBox textBox1;
        private Button clearForm;
        private Button insertNewNote;
        private Button closeForm;
        private Button saveChanges;
    }
}
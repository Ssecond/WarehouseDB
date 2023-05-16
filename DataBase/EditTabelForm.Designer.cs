namespace DataBase
{
    partial class EditTabelForm
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
            saveChanges = new Button();
            closeForm = new Button();
            insertNewNote = new Button();
            clearForm = new Button();
            SuspendLayout();
            // 
            // saveChanges
            // 
            saveChanges.Location = new Point(440, 436);
            saveChanges.Name = "saveChanges";
            saveChanges.Size = new Size(194, 23);
            saveChanges.TabIndex = 0;
            saveChanges.Text = "Сохранить изменения сущ. зап.";
            saveChanges.UseVisualStyleBackColor = true;
            // 
            // closeForm
            // 
            closeForm.Location = new Point(12, 436);
            closeForm.Name = "closeForm";
            closeForm.Size = new Size(115, 23);
            closeForm.TabIndex = 1;
            closeForm.Text = "Закрыть форму";
            closeForm.UseVisualStyleBackColor = true;
            // 
            // insertNewNote
            // 
            insertNewNote.Location = new Point(640, 436);
            insertNewNote.Name = "insertNewNote";
            insertNewNote.Size = new Size(145, 23);
            insertNewNote.TabIndex = 2;
            insertNewNote.Text = "Вставить новую запись";
            insertNewNote.UseVisualStyleBackColor = true;
            // 
            // clearForm
            // 
            clearForm.Location = new Point(222, 436);
            clearForm.Name = "clearForm";
            clearForm.Size = new Size(128, 23);
            clearForm.TabIndex = 3;
            clearForm.Text = "Отчистить все поля";
            clearForm.UseVisualStyleBackColor = true;
            // 
            // EditTabelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 471);
            Controls.Add(clearForm);
            Controls.Add(insertNewNote);
            Controls.Add(closeForm);
            Controls.Add(saveChanges);
            Name = "EditTabelForm";
            Text = "Редактирование записи";
            ResumeLayout(false);
        }

        #endregion

        private Button saveChanges;
        private Button closeForm;
        private Button insertNewNote;
        private Button clearForm;
    }
}
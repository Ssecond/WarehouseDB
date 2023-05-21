namespace DataBase
{
    partial class StreetsForm
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            checkBox1 = new CheckBox();
            name = new Label();
            nameSign = new Label();
            order = new Label();
            idLabel = new Label();
            idTextBox = new TextBox();
            SuspendLayout();
            // 
            // saveChanges
            // 
            saveChanges.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveChanges.Location = new Point(446, 135);
            saveChanges.Name = "saveChanges";
            saveChanges.Size = new Size(194, 23);
            saveChanges.TabIndex = 0;
            saveChanges.Text = "Сохранить изменения сущ. зап.";
            saveChanges.UseVisualStyleBackColor = true;
            // 
            // closeForm
            // 
            closeForm.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            closeForm.Location = new Point(18, 135);
            closeForm.Name = "closeForm";
            closeForm.Size = new Size(115, 23);
            closeForm.TabIndex = 1;
            closeForm.Text = "Закрыть форму";
            closeForm.UseVisualStyleBackColor = true;
            // 
            // insertNewNote
            // 
            insertNewNote.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            insertNewNote.Location = new Point(646, 135);
            insertNewNote.Name = "insertNewNote";
            insertNewNote.Size = new Size(145, 23);
            insertNewNote.TabIndex = 2;
            insertNewNote.Text = "Вставить новую запись";
            insertNewNote.UseVisualStyleBackColor = true;
            // 
            // clearForm
            // 
            clearForm.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            clearForm.Location = new Point(228, 135);
            clearForm.Name = "clearForm";
            clearForm.Size = new Size(128, 23);
            clearForm.TabIndex = 3;
            clearForm.Text = "Отчистить все поля";
            clearForm.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(228, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(557, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(228, 66);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(557, 23);
            textBox2.TabIndex = 5;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(228, 95);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 6;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(12, 37);
            name.Name = "name";
            name.Size = new Size(59, 15);
            name.TabIndex = 7;
            name.Text = "Название";
            // 
            // nameSign
            // 
            nameSign.AutoSize = true;
            nameSign.Location = new Point(12, 69);
            nameSign.Name = "nameSign";
            nameSign.Size = new Size(210, 15);
            nameSign.TabIndex = 7;
            nameSign.Text = "Признак адреса (улица, шоссе и т.д.)";
            // 
            // order
            // 
            order.AutoSize = true;
            order.Location = new Point(12, 95);
            order.Name = "order";
            order.Size = new Size(197, 15);
            order.TabIndex = 7;
            order.Text = "Порядок (до названия ли признак)";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(12, 9);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(24, 15);
            idLabel.TabIndex = 7;
            idLabel.Text = "ИД";
            // 
            // idTextBox
            // 
            idTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            idTextBox.Location = new Point(228, 6);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(557, 23);
            idTextBox.TabIndex = 4;
            // 
            // StreetsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 171);
            Controls.Add(order);
            Controls.Add(nameSign);
            Controls.Add(idLabel);
            Controls.Add(name);
            Controls.Add(checkBox1);
            Controls.Add(textBox2);
            Controls.Add(idTextBox);
            Controls.Add(textBox1);
            Controls.Add(clearForm);
            Controls.Add(insertNewNote);
            Controls.Add(closeForm);
            Controls.Add(saveChanges);
            Name = "StreetsForm";
            Text = "Справочник улиц";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saveChanges;
        private Button closeForm;
        private Button insertNewNote;
        private Button clearForm;
        private TextBox textBox1;
        private TextBox textBox2;
        private CheckBox checkBox1;
        private Label name;
        private Label nameSign;
        private Label order;
        private Label idLabel;
        private TextBox idTextBox;
    }
}
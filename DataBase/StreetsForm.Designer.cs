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
            nameStreet = new TextBox();
            streetRoad = new TextBox();
            orderStreet = new CheckBox();
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
            saveChanges.Location = new Point(564, 180);
            saveChanges.Margin = new Padding(3, 4, 3, 4);
            saveChanges.Name = "saveChanges";
            saveChanges.Size = new Size(222, 31);
            saveChanges.TabIndex = 0;
            saveChanges.Text = "Сохранить изменения сущ. зап.";
            saveChanges.UseVisualStyleBackColor = true;
            saveChanges.Click += saveChanges_Click;
            // 
            // closeForm
            // 
            closeForm.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            closeForm.Location = new Point(21, 180);
            closeForm.Margin = new Padding(3, 4, 3, 4);
            closeForm.Name = "closeForm";
            closeForm.Size = new Size(131, 31);
            closeForm.TabIndex = 1;
            closeForm.Text = "Закрыть форму";
            closeForm.UseVisualStyleBackColor = true;
            closeForm.Click += closeForm_Click;
            // 
            // insertNewNote
            // 
            insertNewNote.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            insertNewNote.Location = new Point(792, 180);
            insertNewNote.Margin = new Padding(3, 4, 3, 4);
            insertNewNote.Name = "insertNewNote";
            insertNewNote.Size = new Size(166, 31);
            insertNewNote.TabIndex = 2;
            insertNewNote.Text = "Вставить новую запись";
            insertNewNote.UseVisualStyleBackColor = true;
            insertNewNote.Click += insertNewNote_Click;
            // 
            // clearForm
            // 
            clearForm.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            clearForm.Location = new Point(261, 180);
            clearForm.Margin = new Padding(3, 4, 3, 4);
            clearForm.Name = "clearForm";
            clearForm.Size = new Size(146, 31);
            clearForm.TabIndex = 3;
            clearForm.Text = "Отчистить все поля";
            clearForm.UseVisualStyleBackColor = true;
            clearForm.Click += clearForm_Click;
            // 
            // nameStreet
            // 
            nameStreet.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameStreet.Location = new Point(287, 49);
            nameStreet.Margin = new Padding(3, 4, 3, 4);
            nameStreet.Name = "nameStreet";
            nameStreet.Size = new Size(664, 27);
            nameStreet.TabIndex = 4;
            // 
            // streetRoad
            // 
            streetRoad.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            streetRoad.Location = new Point(287, 88);
            streetRoad.Margin = new Padding(3, 4, 3, 4);
            streetRoad.Name = "streetRoad";
            streetRoad.Size = new Size(664, 27);
            streetRoad.TabIndex = 5;
            // 
            // orderStreet
            // 
            orderStreet.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            orderStreet.AutoSize = true;
            orderStreet.Location = new Point(287, 130);
            orderStreet.Margin = new Padding(3, 4, 3, 4);
            orderStreet.Name = "orderStreet";
            orderStreet.Size = new Size(18, 17);
            orderStreet.TabIndex = 6;
            orderStreet.UseVisualStyleBackColor = true;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(14, 49);
            name.Name = "name";
            name.Size = new Size(77, 20);
            name.TabIndex = 7;
            name.Text = "Название";
            // 
            // nameSign
            // 
            nameSign.AutoSize = true;
            nameSign.Location = new Point(14, 92);
            nameSign.Name = "nameSign";
            nameSign.Size = new Size(263, 20);
            nameSign.TabIndex = 7;
            nameSign.Text = "Признак адреса (улица, шоссе и т.д.)";
            // 
            // order
            // 
            order.AutoSize = true;
            order.Location = new Point(14, 127);
            order.Name = "order";
            order.Size = new Size(254, 20);
            order.TabIndex = 7;
            order.Text = "Порядок (до названия ли признак)";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(14, 12);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(30, 20);
            idLabel.TabIndex = 7;
            idLabel.Text = "ИД";
            // 
            // idTextBox
            // 
            idTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            idTextBox.Location = new Point(287, 8);
            idTextBox.Margin = new Padding(3, 4, 3, 4);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(664, 27);
            idTextBox.TabIndex = 4;
            // 
            // StreetsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 228);
            Controls.Add(order);
            Controls.Add(nameSign);
            Controls.Add(idLabel);
            Controls.Add(name);
            Controls.Add(orderStreet);
            Controls.Add(streetRoad);
            Controls.Add(idTextBox);
            Controls.Add(nameStreet);
            Controls.Add(clearForm);
            Controls.Add(insertNewNote);
            Controls.Add(closeForm);
            Controls.Add(saveChanges);
            Margin = new Padding(3, 4, 3, 4);
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
        private TextBox nameStreet;
        private TextBox streetRoad;
        private CheckBox orderStreet;
        private Label name;
        private Label nameSign;
        private Label order;
        private Label idLabel;
        private TextBox idTextBox;
    }
}
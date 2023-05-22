namespace DataBase
{
    partial class ProducersForm
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
            streetLabel = new Label();
            houseNumberTextBox = new TextBox();
            additionalLabel = new Label();
            additionalTextBox = new TextBox();
            companyNameLabel = new Label();
            companyName = new TextBox();
            streetComboBox = new ComboBox();
            brokerSignLabel = new Label();
            honeLabel = new Label();
            tinLabel = new Label();
            phoneNumber = new TextBox();
            nameLabel = new Label();
            brokerSignCheckBox = new CheckBox();
            tinTextBox = new TextBox();
            clearForm = new Button();
            insertNewNote = new Button();
            closeForm = new Button();
            saveChanges = new Button();
            SuspendLayout();
            // 
            // streetLabel
            // 
            streetLabel.AutoSize = true;
            streetLabel.Location = new Point(12, 185);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new Size(41, 15);
            streetLabel.TabIndex = 50;
            streetLabel.Text = "Улица";
            // 
            // houseNumberTextBox
            // 
            houseNumberTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            houseNumberTextBox.Location = new Point(228, 60);
            houseNumberTextBox.Name = "houseNumberTextBox";
            houseNumberTextBox.Size = new Size(846, 23);
            houseNumberTextBox.TabIndex = 44;
            // 
            // additionalLabel
            // 
            additionalLabel.AutoSize = true;
            additionalLabel.Location = new Point(11, 156);
            additionalLabel.Name = "additionalLabel";
            additionalLabel.Size = new Size(192, 15);
            additionalLabel.TabIndex = 49;
            additionalLabel.Text = "Правовая форма (АО, ООО и т.д.)";
            // 
            // additionalTextBox
            // 
            additionalTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            additionalTextBox.Location = new Point(227, 153);
            additionalTextBox.Name = "additionalTextBox";
            additionalTextBox.Size = new Size(846, 23);
            additionalTextBox.TabIndex = 43;
            // 
            // companyNameLabel
            // 
            companyNameLabel.AutoSize = true;
            companyNameLabel.Location = new Point(12, 125);
            companyNameLabel.Name = "companyNameLabel";
            companyNameLabel.Size = new Size(118, 15);
            companyNameLabel.TabIndex = 47;
            companyNameLabel.Text = "Название компании";
            // 
            // companyName
            // 
            companyName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            companyName.Location = new Point(228, 122);
            companyName.Name = "companyName";
            companyName.Size = new Size(846, 23);
            companyName.TabIndex = 41;
            // 
            // streetComboBox
            // 
            streetComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            streetComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            streetComboBox.FormattingEnabled = true;
            streetComboBox.Location = new Point(228, 185);
            streetComboBox.Name = "streetComboBox";
            streetComboBox.Size = new Size(846, 23);
            streetComboBox.TabIndex = 40;
            // 
            // brokerSignLabel
            // 
            brokerSignLabel.AutoSize = true;
            brokerSignLabel.Location = new Point(12, 35);
            brokerSignLabel.Name = "brokerSignLabel";
            brokerSignLabel.Size = new Size(122, 15);
            brokerSignLabel.TabIndex = 33;
            brokerSignLabel.Text = "Признак посредника";
            // 
            // honeLabel
            // 
            honeLabel.AutoSize = true;
            honeLabel.Location = new Point(12, 92);
            honeLabel.Name = "honeLabel";
            honeLabel.Size = new Size(55, 15);
            honeLabel.TabIndex = 36;
            honeLabel.Text = "Телефон";
            // 
            // tinLabel
            // 
            tinLabel.AutoSize = true;
            tinLabel.Location = new Point(12, 9);
            tinLabel.Name = "tinLabel";
            tinLabel.Size = new Size(34, 15);
            tinLabel.TabIndex = 38;
            tinLabel.Text = "ИНН";
            // 
            // phoneNumber
            // 
            phoneNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            phoneNumber.Location = new Point(228, 89);
            phoneNumber.Name = "phoneNumber";
            phoneNumber.Size = new Size(846, 23);
            phoneNumber.TabIndex = 30;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(12, 60);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(85, 15);
            nameLabel.TabIndex = 39;
            nameLabel.Text = "Номер здания";
            // 
            // brokerSignCheckBox
            // 
            brokerSignCheckBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            brokerSignCheckBox.AutoSize = true;
            brokerSignCheckBox.Location = new Point(228, 35);
            brokerSignCheckBox.Name = "brokerSignCheckBox";
            brokerSignCheckBox.Size = new Size(15, 14);
            brokerSignCheckBox.TabIndex = 32;
            brokerSignCheckBox.UseVisualStyleBackColor = true;
            // 
            // tinTextBox
            // 
            tinTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tinTextBox.Location = new Point(228, 6);
            tinTextBox.Name = "tinTextBox";
            tinTextBox.Size = new Size(846, 23);
            tinTextBox.TabIndex = 27;
            // 
            // clearForm
            // 
            clearForm.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            clearForm.Location = new Point(217, 223);
            clearForm.Name = "clearForm";
            clearForm.Size = new Size(128, 23);
            clearForm.TabIndex = 26;
            clearForm.Text = "Отчистить все поля";
            clearForm.UseVisualStyleBackColor = true;
            clearForm.Click += clearForm_Click;
            // 
            // insertNewNote
            // 
            insertNewNote.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            insertNewNote.Location = new Point(930, 223);
            insertNewNote.Name = "insertNewNote";
            insertNewNote.Size = new Size(145, 23);
            insertNewNote.TabIndex = 25;
            insertNewNote.Text = "Вставить новую запись";
            insertNewNote.UseVisualStyleBackColor = true;
            insertNewNote.Click += insertNewNote_Click;
            // 
            // closeForm
            // 
            closeForm.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            closeForm.Location = new Point(7, 223);
            closeForm.Name = "closeForm";
            closeForm.Size = new Size(115, 23);
            closeForm.TabIndex = 24;
            closeForm.Text = "Закрыть форму";
            closeForm.UseVisualStyleBackColor = true;
            closeForm.Click += closeForm_Click;
            // 
            // saveChanges
            // 
            saveChanges.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveChanges.Location = new Point(730, 223);
            saveChanges.Name = "saveChanges";
            saveChanges.Size = new Size(194, 23);
            saveChanges.TabIndex = 23;
            saveChanges.Text = "Сохранить изменения сущ. зап.";
            saveChanges.UseVisualStyleBackColor = true;
            saveChanges.Click += saveChanges_Click;
            // 
            // ProducersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 258);
            Controls.Add(streetLabel);
            Controls.Add(houseNumberTextBox);
            Controls.Add(additionalLabel);
            Controls.Add(additionalTextBox);
            Controls.Add(companyNameLabel);
            Controls.Add(companyName);
            Controls.Add(streetComboBox);
            Controls.Add(brokerSignLabel);
            Controls.Add(honeLabel);
            Controls.Add(tinLabel);
            Controls.Add(phoneNumber);
            Controls.Add(nameLabel);
            Controls.Add(brokerSignCheckBox);
            Controls.Add(tinTextBox);
            Controls.Add(clearForm);
            Controls.Add(insertNewNote);
            Controls.Add(closeForm);
            Controls.Add(saveChanges);
            Name = "ProducersForm";
            Text = "Поставщики";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label streetLabel;
        private TextBox houseNumberTextBox;
        private Label additionalLabel;
        private TextBox additionalTextBox;
        private Label companyNameLabel;
        private TextBox companyName;
        private ComboBox streetComboBox;
        private Label brokerSignLabel;
        private Label honeLabel;
        private Label tinLabel;
        private TextBox phoneNumber;
        private Label nameLabel;
        private CheckBox brokerSignCheckBox;
        private TextBox tinTextBox;
        private Button clearForm;
        private Button insertNewNote;
        private Button closeForm;
        private Button saveChanges;
    }
}
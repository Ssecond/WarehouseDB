namespace DataBase
{
    partial class CustomersForm
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
            houseNumberLabel = new Label();
            houseNumberTextBox = new TextBox();
            sellerSurnameLabel = new Label();
            sellerSurnameTextBox = new TextBox();
            givenDate = new Label();
            phoneNumberTextBox = new TextBox();
            countLabel = new Label();
            countTextBox = new TextBox();
            soldDateTextBox = new TextBox();
            goodsComboBox = new ComboBox();
            isCashLabel = new Label();
            soldDateLabel = new Label();
            outCheckLabel = new Label();
            TINLabel = new Label();
            idLabel = new Label();
            sumTextBox = new TextBox();
            streetLabel = new Label();
            isCashCheckBox = new CheckBox();
            TIN = new TextBox();
            clearForm = new Button();
            insertNewNote = new Button();
            closeForm = new Button();
            saveChanges = new Button();
            streetComboBox = new ComboBox();
            SuspendLayout();
            // 
            // houseNumberLabel
            // 
            houseNumberLabel.AutoSize = true;
            houseNumberLabel.Location = new Point(12, 270);
            houseNumberLabel.Name = "houseNumberLabel";
            houseNumberLabel.Size = new Size(85, 15);
            houseNumberLabel.TabIndex = 51;
            houseNumberLabel.Text = "Номер здания";
            // 
            // houseNumberTextBox
            // 
            houseNumberTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            houseNumberTextBox.Location = new Point(228, 267);
            houseNumberTextBox.Name = "houseNumberTextBox";
            houseNumberTextBox.Size = new Size(584, 23);
            houseNumberTextBox.TabIndex = 45;
            // 
            // sellerSurnameLabel
            // 
            sellerSurnameLabel.AutoSize = true;
            sellerSurnameLabel.Location = new Point(12, 242);
            sellerSurnameLabel.Name = "sellerSurnameLabel";
            sellerSurnameLabel.Size = new Size(113, 15);
            sellerSurnameLabel.TabIndex = 50;
            sellerSurnameLabel.Text = "Фамилия продавца";
            // 
            // sellerSurnameTextBox
            // 
            sellerSurnameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            sellerSurnameTextBox.Location = new Point(228, 239);
            sellerSurnameTextBox.Name = "sellerSurnameTextBox";
            sellerSurnameTextBox.Size = new Size(584, 23);
            sellerSurnameTextBox.TabIndex = 44;
            // 
            // givenDate
            // 
            givenDate.AutoSize = true;
            givenDate.Location = new Point(12, 212);
            givenDate.Name = "givenDate";
            givenDate.Size = new Size(55, 15);
            givenDate.TabIndex = 49;
            givenDate.Text = "Телефон";
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            phoneNumberTextBox.Location = new Point(228, 209);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(584, 23);
            phoneNumberTextBox.TabIndex = 43;
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Location = new Point(12, 182);
            countLabel.Name = "countLabel";
            countLabel.Size = new Size(46, 15);
            countLabel.TabIndex = 48;
            countLabel.Text = "Кол-во";
            // 
            // countTextBox
            // 
            countTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            countTextBox.Location = new Point(228, 179);
            countTextBox.Name = "countTextBox";
            countTextBox.Size = new Size(584, 23);
            countTextBox.TabIndex = 42;
            // 
            // soldDateTextBox
            // 
            soldDateTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            soldDateTextBox.Location = new Point(229, 149);
            soldDateTextBox.Name = "soldDateTextBox";
            soldDateTextBox.Size = new Size(584, 23);
            soldDateTextBox.TabIndex = 41;
            // 
            // goodsComboBox
            // 
            goodsComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            goodsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            goodsComboBox.FormattingEnabled = true;
            goodsComboBox.Location = new Point(228, 10);
            goodsComboBox.Name = "goodsComboBox";
            goodsComboBox.Size = new Size(584, 23);
            goodsComboBox.TabIndex = 40;
            // 
            // isCashLabel
            // 
            isCashLabel.AutoSize = true;
            isCashLabel.Location = new Point(12, 95);
            isCashLabel.Name = "isCashLabel";
            isCashLabel.Size = new Size(65, 15);
            isCashLabel.TabIndex = 33;
            isCashLabel.Text = "Наличные";
            // 
            // soldDateLabel
            // 
            soldDateLabel.AutoSize = true;
            soldDateLabel.Location = new Point(12, 149);
            soldDateLabel.Name = "soldDateLabel";
            soldDateLabel.Size = new Size(84, 15);
            soldDateLabel.TabIndex = 37;
            soldDateLabel.Text = "Дата продажи";
            // 
            // outCheckLabel
            // 
            outCheckLabel.AutoSize = true;
            outCheckLabel.Location = new Point(12, 123);
            outCheckLabel.Name = "outCheckLabel";
            outCheckLabel.Size = new Size(45, 15);
            outCheckLabel.TabIndex = 36;
            outCheckLabel.Text = "Сумма";
            // 
            // TINLabel
            // 
            TINLabel.AutoSize = true;
            TINLabel.Location = new Point(12, 69);
            TINLabel.Name = "TINLabel";
            TINLabel.Size = new Size(34, 15);
            TINLabel.TabIndex = 34;
            TINLabel.Text = "ИНН";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(12, 9);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(39, 15);
            idLabel.TabIndex = 38;
            idLabel.Text = "Товар";
            // 
            // sumTextBox
            // 
            sumTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            sumTextBox.Location = new Point(228, 120);
            sumTextBox.Name = "sumTextBox";
            sumTextBox.Size = new Size(584, 23);
            sumTextBox.TabIndex = 30;
            // 
            // streetLabel
            // 
            streetLabel.AutoSize = true;
            streetLabel.Location = new Point(12, 37);
            streetLabel.Name = "streetLabel";
            streetLabel.Size = new Size(41, 15);
            streetLabel.TabIndex = 39;
            streetLabel.Text = "Улица";
            // 
            // isCashCheckBox
            // 
            isCashCheckBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            isCashCheckBox.AutoSize = true;
            isCashCheckBox.Location = new Point(228, 95);
            isCashCheckBox.Name = "isCashCheckBox";
            isCashCheckBox.Size = new Size(15, 14);
            isCashCheckBox.TabIndex = 32;
            isCashCheckBox.UseVisualStyleBackColor = true;
            // 
            // TIN
            // 
            TIN.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TIN.Location = new Point(228, 66);
            TIN.Name = "TIN";
            TIN.Size = new Size(584, 23);
            TIN.TabIndex = 28;
            // 
            // clearForm
            // 
            clearForm.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            clearForm.Location = new Point(217, 305);
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
            insertNewNote.Location = new Point(663, 305);
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
            closeForm.Location = new Point(7, 305);
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
            saveChanges.Location = new Point(463, 305);
            saveChanges.Name = "saveChanges";
            saveChanges.Size = new Size(194, 23);
            saveChanges.TabIndex = 23;
            saveChanges.Text = "Сохранить изменения сущ. зап.";
            saveChanges.UseVisualStyleBackColor = true;
            saveChanges.Click += saveChanges_Click;
            // 
            // streetComboBox
            // 
            streetComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            streetComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            streetComboBox.FormattingEnabled = true;
            streetComboBox.Location = new Point(228, 37);
            streetComboBox.Name = "streetComboBox";
            streetComboBox.Size = new Size(585, 23);
            streetComboBox.TabIndex = 40;
            // 
            // CustomersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 340);
            Controls.Add(houseNumberLabel);
            Controls.Add(houseNumberTextBox);
            Controls.Add(sellerSurnameLabel);
            Controls.Add(sellerSurnameTextBox);
            Controls.Add(givenDate);
            Controls.Add(phoneNumberTextBox);
            Controls.Add(countLabel);
            Controls.Add(countTextBox);
            Controls.Add(soldDateTextBox);
            Controls.Add(streetComboBox);
            Controls.Add(goodsComboBox);
            Controls.Add(isCashLabel);
            Controls.Add(soldDateLabel);
            Controls.Add(outCheckLabel);
            Controls.Add(TINLabel);
            Controls.Add(idLabel);
            Controls.Add(sumTextBox);
            Controls.Add(streetLabel);
            Controls.Add(isCashCheckBox);
            Controls.Add(TIN);
            Controls.Add(clearForm);
            Controls.Add(insertNewNote);
            Controls.Add(closeForm);
            Controls.Add(saveChanges);
            Name = "CustomersForm";
            Text = "Покупатели";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label houseNumberLabel;
        private TextBox houseNumberTextBox;
        private Label sellerSurnameLabel;
        private TextBox sellerSurnameTextBox;
        private Label givenDate;
        private TextBox phoneNumberTextBox;
        private Label countLabel;
        private TextBox countTextBox;
        private TextBox soldDateTextBox;
        private ComboBox goodsComboBox;
        private Label isCashLabel;
        private Label soldDateLabel;
        private Label outCheckLabel;
        private Label label1;
        private Label TINLabel;
        private Label idLabel;
        private TextBox sumTextBox;
        private Label streetLabel;
        private CheckBox isCashCheckBox;
        private TextBox TIN;
        private Button clearForm;
        private Button insertNewNote;
        private Button closeForm;
        private Button saveChanges;
        private ComboBox streetComboBox;
    }
}
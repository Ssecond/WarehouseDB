namespace DataBase
{
    partial class GoodsForm
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
            order = new Label();
            producerTINLabel = new Label();
            idLabel = new Label();
            nameLabel = new Label();
            signCheckBox = new CheckBox();
            producerTIN = new TextBox();
            idTextBox = new TextBox();
            clearForm = new Button();
            insertNewNote = new Button();
            closeForm = new Button();
            saveChanges = new Button();
            choosePackage = new ComboBox();
            signData = new TextBox();
            label1 = new Label();
            outCheckNumber = new TextBox();
            outCheckLabel = new Label();
            instrustionsTextBox = new TextBox();
            label2 = new Label();
            priceLabel = new Label();
            price = new TextBox();
            inCheckNumber = new TextBox();
            label3 = new Label();
            givenDateTextBox = new TextBox();
            givenDate = new Label();
            experiationDateTextBox = new TextBox();
            experiationDate = new Label();
            textBox1 = new TextBox();
            productionDateLabel = new Label();
            productNameTextBox = new TextBox();
            productNameLabel = new Label();
            SuspendLayout();
            // 
            // order
            // 
            order.AutoSize = true;
            order.Location = new Point(12, 127);
            order.Name = "order";
            order.Size = new Size(148, 15);
            order.TabIndex = 16;
            order.Text = "Сертификат соответствия";
            // 
            // producerTINLabel
            // 
            producerTINLabel.AutoSize = true;
            producerTINLabel.Location = new Point(12, 69);
            producerTINLabel.Name = "producerTINLabel";
            producerTINLabel.Size = new Size(120, 15);
            producerTINLabel.TabIndex = 17;
            producerTINLabel.Text = "ИНН производителя";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(12, 9);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(64, 15);
            idLabel.TabIndex = 18;
            idLabel.Text = "ИД товара";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(12, 37);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(58, 15);
            nameLabel.TabIndex = 19;
            nameLabel.Text = "Упаковка";
            // 
            // signCheckBox
            // 
            signCheckBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            signCheckBox.AutoSize = true;
            signCheckBox.Location = new Point(228, 127);
            signCheckBox.Name = "signCheckBox";
            signCheckBox.Size = new Size(15, 14);
            signCheckBox.TabIndex = 15;
            signCheckBox.UseVisualStyleBackColor = true;
            // 
            // producerTIN
            // 
            producerTIN.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            producerTIN.Location = new Point(228, 66);
            producerTIN.Name = "producerTIN";
            producerTIN.Size = new Size(586, 23);
            producerTIN.TabIndex = 14;
            // 
            // idTextBox
            // 
            idTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            idTextBox.Location = new Point(228, 6);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(586, 23);
            idTextBox.TabIndex = 12;
            // 
            // clearForm
            // 
            clearForm.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            clearForm.Location = new Point(222, 415);
            clearForm.Name = "clearForm";
            clearForm.Size = new Size(128, 23);
            clearForm.TabIndex = 11;
            clearForm.Text = "Отчистить все поля";
            clearForm.UseVisualStyleBackColor = true;
            // 
            // insertNewNote
            // 
            insertNewNote.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            insertNewNote.Location = new Point(669, 415);
            insertNewNote.Name = "insertNewNote";
            insertNewNote.Size = new Size(145, 23);
            insertNewNote.TabIndex = 10;
            insertNewNote.Text = "Вставить новую запись";
            insertNewNote.UseVisualStyleBackColor = true;
            // 
            // closeForm
            // 
            closeForm.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            closeForm.Location = new Point(12, 415);
            closeForm.Name = "closeForm";
            closeForm.Size = new Size(115, 23);
            closeForm.TabIndex = 9;
            closeForm.Text = "Закрыть форму";
            closeForm.UseVisualStyleBackColor = true;
            // 
            // saveChanges
            // 
            saveChanges.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveChanges.Location = new Point(469, 415);
            saveChanges.Name = "saveChanges";
            saveChanges.Size = new Size(194, 23);
            saveChanges.TabIndex = 8;
            saveChanges.Text = "Сохранить изменения сущ. зап.";
            saveChanges.UseVisualStyleBackColor = true;
            // 
            // choosePackage
            // 
            choosePackage.FormattingEnabled = true;
            choosePackage.Location = new Point(228, 37);
            choosePackage.Name = "choosePackage";
            choosePackage.Size = new Size(586, 23);
            choosePackage.TabIndex = 20;
            // 
            // signData
            // 
            signData.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            signData.Location = new Point(228, 98);
            signData.Name = "signData";
            signData.Size = new Size(586, 23);
            signData.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 101);
            label1.Name = "label1";
            label1.Size = new Size(180, 15);
            label1.TabIndex = 17;
            label1.Text = "Дата сертификата соответствия";
            // 
            // outCheckNumber
            // 
            outCheckNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            outCheckNumber.Location = new Point(228, 151);
            outCheckNumber.Name = "outCheckNumber";
            outCheckNumber.Size = new Size(586, 23);
            outCheckNumber.TabIndex = 14;
            // 
            // outCheckLabel
            // 
            outCheckLabel.AutoSize = true;
            outCheckLabel.Location = new Point(12, 154);
            outCheckLabel.Name = "outCheckLabel";
            outCheckLabel.Size = new Size(165, 15);
            outCheckLabel.TabIndex = 17;
            outCheckLabel.Text = "Номер выходной накладной";
            // 
            // instrustionsTextBox
            // 
            instrustionsTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            instrustionsTextBox.Location = new Point(228, 180);
            instrustionsTextBox.Multiline = true;
            instrustionsTextBox.Name = "instrustionsTextBox";
            instrustionsTextBox.Size = new Size(586, 46);
            instrustionsTextBox.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 183);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 17;
            label2.Text = "Инструкции";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(12, 235);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(35, 15);
            priceLabel.TabIndex = 22;
            priceLabel.Text = "Цена";
            // 
            // price
            // 
            price.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            price.Location = new Point(228, 232);
            price.Name = "price";
            price.Size = new Size(586, 23);
            price.TabIndex = 21;
            // 
            // inCheckNumber
            // 
            inCheckNumber.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            inCheckNumber.Location = new Point(228, 260);
            inCheckNumber.Name = "inCheckNumber";
            inCheckNumber.Size = new Size(586, 23);
            inCheckNumber.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 263);
            label3.Name = "label3";
            label3.Size = new Size(172, 15);
            label3.TabIndex = 22;
            label3.Text = "Номер прих. накл. ведомости";
            // 
            // givenDateTextBox
            // 
            givenDateTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            givenDateTextBox.Location = new Point(228, 287);
            givenDateTextBox.Name = "givenDateTextBox";
            givenDateTextBox.Size = new Size(586, 23);
            givenDateTextBox.TabIndex = 21;
            // 
            // givenDate
            // 
            givenDate.AutoSize = true;
            givenDate.Location = new Point(12, 290);
            givenDate.Name = "givenDate";
            givenDate.Size = new Size(106, 15);
            givenDate.TabIndex = 22;
            givenDate.Text = "Дата поступления";
            // 
            // experiationDateTextBox
            // 
            experiationDateTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            experiationDateTextBox.Location = new Point(228, 315);
            experiationDateTextBox.Name = "experiationDateTextBox";
            experiationDateTextBox.Size = new Size(586, 23);
            experiationDateTextBox.TabIndex = 21;
            // 
            // experiationDate
            // 
            experiationDate.AutoSize = true;
            experiationDate.Location = new Point(12, 318);
            experiationDate.Name = "experiationDate";
            experiationDate.Size = new Size(88, 15);
            experiationDate.TabIndex = 22;
            experiationDate.Text = "Срок годности";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(228, 343);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(586, 23);
            textBox1.TabIndex = 21;
            // 
            // productionDateLabel
            // 
            productionDateLabel.AutoSize = true;
            productionDateLabel.Location = new Point(12, 346);
            productionDateLabel.Name = "productionDateLabel";
            productionDateLabel.Size = new Size(110, 15);
            productionDateLabel.TabIndex = 22;
            productionDateLabel.Text = "Дата производства";
            // 
            // productNameTextBox
            // 
            productNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            productNameTextBox.Location = new Point(228, 372);
            productNameTextBox.Name = "productNameTextBox";
            productNameTextBox.Size = new Size(586, 23);
            productNameTextBox.TabIndex = 21;
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Location = new Point(12, 375);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new Size(59, 15);
            productNameLabel.TabIndex = 22;
            productNameLabel.Text = "Название";
            // 
            // GoodsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 450);
            Controls.Add(productNameLabel);
            Controls.Add(productNameTextBox);
            Controls.Add(productionDateLabel);
            Controls.Add(textBox1);
            Controls.Add(experiationDate);
            Controls.Add(experiationDateTextBox);
            Controls.Add(givenDate);
            Controls.Add(givenDateTextBox);
            Controls.Add(label3);
            Controls.Add(inCheckNumber);
            Controls.Add(priceLabel);
            Controls.Add(price);
            Controls.Add(choosePackage);
            Controls.Add(order);
            Controls.Add(label2);
            Controls.Add(outCheckLabel);
            Controls.Add(label1);
            Controls.Add(producerTINLabel);
            Controls.Add(instrustionsTextBox);
            Controls.Add(idLabel);
            Controls.Add(outCheckNumber);
            Controls.Add(nameLabel);
            Controls.Add(signData);
            Controls.Add(signCheckBox);
            Controls.Add(producerTIN);
            Controls.Add(idTextBox);
            Controls.Add(clearForm);
            Controls.Add(insertNewNote);
            Controls.Add(closeForm);
            Controls.Add(saveChanges);
            Name = "GoodsForm";
            Text = "Товары";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label order;
        private Label producerTINLabel;
        private Label idLabel;
        private Label nameLabel;
        private CheckBox signCheckBox;
        private TextBox producerTIN;
        private TextBox idTextBox;
        private Button clearForm;
        private Button insertNewNote;
        private Button closeForm;
        private Button saveChanges;
        private ComboBox choosePackage;
        private TextBox signData;
        private Label label1;
        private TextBox outCheckNumber;
        private Label outCheckLabel;
        private TextBox instrustionsTextBox;
        private Label label2;
        private Label priceLabel;
        private TextBox price;
        private TextBox inCheckNumber;
        private Label label3;
        private TextBox givenDateTextBox;
        private Label givenDate;
        private TextBox experiationDateTextBox;
        private Label experiationDate;
        private TextBox textBox1;
        private Label productionDateLabel;
        private TextBox productNameTextBox;
        private Label productNameLabel;
    }
}
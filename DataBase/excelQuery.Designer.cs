namespace DataBase
{
    partial class ExcelQueryForm
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
            excelOut = new Button();
            queryDataGridView = new DataGridView();
            closeButton = new Button();
            saveFileDialog1 = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)queryDataGridView).BeginInit();
            SuspendLayout();
            // 
            // excelOut
            // 
            excelOut.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            excelOut.Location = new Point(741, 467);
            excelOut.Name = "excelOut";
            excelOut.Size = new Size(118, 23);
            excelOut.TabIndex = 0;
            excelOut.Text = "Вывести в Excel";
            excelOut.UseVisualStyleBackColor = true;
            excelOut.Click += excelOut_Click;
            // 
            // queryDataGridView
            // 
            queryDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            queryDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            queryDataGridView.Location = new Point(12, 12);
            queryDataGridView.Name = "queryDataGridView";
            queryDataGridView.RowTemplate.Height = 25;
            queryDataGridView.Size = new Size(847, 449);
            queryDataGridView.TabIndex = 1;
            // 
            // closeButton
            // 
            closeButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            closeButton.Location = new Point(12, 467);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(118, 23);
            closeButton.TabIndex = 0;
            closeButton.Text = "Закрыть";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // ExcelQueryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 502);
            Controls.Add(queryDataGridView);
            Controls.Add(closeButton);
            Controls.Add(excelOut);
            Name = "ExcelQueryForm";
            Text = "Запрос";
            ((System.ComponentModel.ISupportInitialize)queryDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button excelOut;
        private DataGridView queryDataGridView;
        private Button closeButton;
        private SaveFileDialog saveFileDialog1;
    }
}
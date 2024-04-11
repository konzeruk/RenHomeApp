namespace RenHomeApp.Forms
{
    partial class NewReviewForm
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
            labelGrade = new Label();
            numericUpDownGrade = new NumericUpDown();
            textBoxReview = new TextBox();
            labelReview = new Label();
            bOk = new Button();
            bCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGrade).BeginInit();
            SuspendLayout();
            // 
            // labelGrade
            // 
            labelGrade.AutoSize = true;
            labelGrade.Location = new Point(12, 14);
            labelGrade.Name = "labelGrade";
            labelGrade.Size = new Size(51, 15);
            labelGrade.TabIndex = 0;
            labelGrade.Text = "Оценка:";
            // 
            // numericUpDownGrade
            // 
            numericUpDownGrade.Location = new Point(69, 12);
            numericUpDownGrade.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDownGrade.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownGrade.Name = "numericUpDownGrade";
            numericUpDownGrade.Size = new Size(38, 23);
            numericUpDownGrade.TabIndex = 2;
            numericUpDownGrade.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // textBoxReview
            // 
            textBoxReview.Location = new Point(12, 64);
            textBoxReview.Multiline = true;
            textBoxReview.Name = "textBoxReview";
            textBoxReview.Size = new Size(251, 218);
            textBoxReview.TabIndex = 3;
            // 
            // labelReview
            // 
            labelReview.AutoSize = true;
            labelReview.Location = new Point(12, 46);
            labelReview.Name = "labelReview";
            labelReview.Size = new Size(87, 15);
            labelReview.TabIndex = 4;
            labelReview.Text = "Комментарий:";
            // 
            // bOk
            // 
            bOk.Location = new Point(12, 290);
            bOk.Name = "bOk";
            bOk.Size = new Size(75, 23);
            bOk.TabIndex = 5;
            bOk.Text = "OK";
            bOk.UseVisualStyleBackColor = true;
            bOk.Click += bOk_Click;
            // 
            // bCancel
            // 
            bCancel.Location = new Point(188, 290);
            bCancel.Name = "bCancel";
            bCancel.Size = new Size(75, 23);
            bCancel.TabIndex = 6;
            bCancel.Text = "Отмена";
            bCancel.UseVisualStyleBackColor = true;
            bCancel.Click += bCancel_Click;
            // 
            // NewReviewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 325);
            ControlBox = false;
            Controls.Add(bCancel);
            Controls.Add(bOk);
            Controls.Add(labelReview);
            Controls.Add(textBoxReview);
            Controls.Add(numericUpDownGrade);
            Controls.Add(labelGrade);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NewReviewForm";
            Text = "Комментарий";
            ((System.ComponentModel.ISupportInitialize)numericUpDownGrade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelGrade;
        private NumericUpDown numericUpDownGrade;
        private TextBox textBoxReview;
        private Label labelReview;
        private Button bOk;
        private Button bCancel;
    }
}
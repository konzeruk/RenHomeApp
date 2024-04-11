namespace RenHomeApp.Forms
{
    partial class ReservationForm
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
            bOk = new Button();
            bCancel = new Button();
            labelStartDate = new Label();
            labelEndDate = new Label();
            dateTimePickerStart = new DateTimePicker();
            dateTimePickerEnd = new DateTimePicker();
            SuspendLayout();
            // 
            // bOk
            // 
            bOk.Location = new Point(18, 70);
            bOk.Name = "bOk";
            bOk.Size = new Size(75, 23);
            bOk.TabIndex = 1;
            bOk.Text = "OK";
            bOk.UseVisualStyleBackColor = true;
            bOk.Click += bOk_Click;
            // 
            // bCancel
            // 
            bCancel.Location = new Point(235, 70);
            bCancel.Name = "bCancel";
            bCancel.Size = new Size(75, 23);
            bCancel.TabIndex = 2;
            bCancel.Text = "Отмена";
            bCancel.UseVisualStyleBackColor = true;
            bCancel.Click += bCancel_Click;
            // 
            // labelStartDate
            // 
            labelStartDate.AutoSize = true;
            labelStartDate.Location = new Point(18, 18);
            labelStartDate.Name = "labelStartDate";
            labelStartDate.Size = new Size(68, 15);
            labelStartDate.TabIndex = 3;
            labelStartDate.Text = "Заселение:";
            // 
            // labelEndDate
            // 
            labelEndDate.AutoSize = true;
            labelEndDate.Location = new Point(18, 47);
            labelEndDate.Name = "labelEndDate";
            labelEndDate.Size = new Size(43, 15);
            labelEndDate.TabIndex = 4;
            labelEndDate.Text = "Выезд:";
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new Point(92, 12);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(218, 23);
            dateTimePickerStart.TabIndex = 5;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Location = new Point(92, 41);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(218, 23);
            dateTimePickerEnd.TabIndex = 6;
            // 
            // ReservationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 105);
            ControlBox = false;
            Controls.Add(dateTimePickerEnd);
            Controls.Add(dateTimePickerStart);
            Controls.Add(labelEndDate);
            Controls.Add(labelStartDate);
            Controls.Add(bCancel);
            Controls.Add(bOk);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ReservationForm";
            Text = "Бронирование";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button bOk;
        private Button bCancel;
        private Label labelStartDate;
        private Label labelEndDate;
        private DateTimePicker dateTimePickerStart;
        private DateTimePicker dateTimePickerEnd;
    }
}
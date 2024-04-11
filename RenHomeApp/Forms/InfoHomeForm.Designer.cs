namespace RenHomeApp.Forms
{
    partial class InfoHomeForm
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
            Label labelDescription;
            labelAddress = new Label();
            labelPrice = new Label();
            textBoxAddress = new TextBox();
            textBoxPrice = new TextBox();
            textBoxDescription = new TextBox();
            reviewLayoutPanel = new FlowLayoutPanel();
            labelReview = new Label();
            bReservation = new Button();
            bAddReview = new Button();
            labelDescription = new Label();
            SuspendLayout();
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(214, 86);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(62, 15);
            labelDescription.TabIndex = 3;
            labelDescription.Text = "Описание";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(12, 15);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(43, 15);
            labelAddress.TabIndex = 0;
            labelAddress.Text = "Адрес:";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(12, 44);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(38, 15);
            labelPrice.TabIndex = 2;
            labelPrice.Text = "Цена:";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(61, 12);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.ReadOnly = true;
            textBoxAddress.Size = new Size(411, 23);
            textBoxAddress.TabIndex = 4;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(61, 41);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.ReadOnly = true;
            textBoxPrice.Size = new Size(411, 23);
            textBoxPrice.TabIndex = 6;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(12, 115);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.ReadOnly = true;
            textBoxDescription.Size = new Size(460, 135);
            textBoxDescription.TabIndex = 7;
            // 
            // reviewLayoutPanel
            // 
            reviewLayoutPanel.AutoScroll = true;
            reviewLayoutPanel.Location = new Point(9, 311);
            reviewLayoutPanel.Name = "reviewLayoutPanel";
            reviewLayoutPanel.Size = new Size(460, 180);
            reviewLayoutPanel.TabIndex = 8;
            // 
            // labelReview
            // 
            labelReview.AutoSize = true;
            labelReview.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelReview.Location = new Point(187, 277);
            labelReview.Name = "labelReview";
            labelReview.Size = new Size(109, 21);
            labelReview.TabIndex = 9;
            labelReview.Text = "Комментарии";
            // 
            // bReservation
            // 
            bReservation.Location = new Point(352, 256);
            bReservation.Name = "bReservation";
            bReservation.Size = new Size(120, 23);
            bReservation.TabIndex = 10;
            bReservation.Text = "Забронировать";
            bReservation.UseVisualStyleBackColor = true;
            bReservation.Click += bReservation_Click;
            // 
            // bAddReview
            // 
            bAddReview.Location = new Point(352, 497);
            bAddReview.Name = "bAddReview";
            bAddReview.Size = new Size(117, 23);
            bAddReview.TabIndex = 11;
            bAddReview.Text = "Комментировать";
            bAddReview.UseVisualStyleBackColor = true;
            bAddReview.Click += bAddReview_Click;
            // 
            // InfoHomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 528);
            Controls.Add(bAddReview);
            Controls.Add(bReservation);
            Controls.Add(labelReview);
            Controls.Add(reviewLayoutPanel);
            Controls.Add(textBoxDescription);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxAddress);
            Controls.Add(labelDescription);
            Controls.Add(labelPrice);
            Controls.Add(labelAddress);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InfoHomeForm";
            Text = "Жильё";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAddress;
        private Label labelPrice;
        private Label labelDescription;
        private TextBox textBoxAddress;
        private TextBox textBoxPrice;
        private TextBox textBoxDescription;
        private FlowLayoutPanel reviewLayoutPanel;
        private Label labelReview;
        private Button bReservation;
        private Button bAddReview;
    }
}
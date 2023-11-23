namespace DemoVar2023.Pages
{
    partial class AddCommentPage
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
            txtBoxDescriptionError = new TextBox();
            btnAddOrder = new Button();
            label3 = new Label();
            txtBoxIndex = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtBoxDescriptionError
            // 
            txtBoxDescriptionError.Location = new Point(14, 91);
            txtBoxDescriptionError.Margin = new Padding(5);
            txtBoxDescriptionError.Multiline = true;
            txtBoxDescriptionError.Name = "txtBoxDescriptionError";
            txtBoxDescriptionError.Size = new Size(245, 90);
            txtBoxDescriptionError.TabIndex = 4;
            txtBoxDescriptionError.TextChanged += textBoxChanged;
            // 
            // btnAddOrder
            // 
            btnAddOrder.Enabled = false;
            btnAddOrder.Location = new Point(43, 189);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(178, 37);
            btnAddOrder.TabIndex = 11;
            btnAddOrder.Text = "Добавить ";
            btnAddOrder.UseVisualStyleBackColor = true;
            btnAddOrder.Click += btnAddOrder_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 61);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(132, 25);
            label3.TabIndex = 5;
            label3.Text = "Комментарий";
            // 
            // txtBoxIndex
            // 
            txtBoxIndex.Location = new Point(12, 33);
            txtBoxIndex.Name = "txtBoxIndex";
            txtBoxIndex.ReadOnly = true;
            txtBoxIndex.Size = new Size(243, 33);
            txtBoxIndex.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 5);
            label2.Name = "label2";
            label2.Size = new Size(75, 25);
            label2.TabIndex = 15;
            label2.Text = "Индекс";
            // 
            // AddCommentPage
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 240);
            Controls.Add(label2);
            Controls.Add(txtBoxIndex);
            Controls.Add(btnAddOrder);
            Controls.Add(label3);
            Controls.Add(txtBoxDescriptionError);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "AddCommentPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавление комментария";
            SizeChanged += UpdateOrderPage_SizeChanged;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtBoxDescriptionError;
        private Button btnAddOrder;
        private Label label3;
        private TextBox txtBoxIndex;
        private Label label2;
    }
}
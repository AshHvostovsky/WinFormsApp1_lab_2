namespace WinFormsApp1_lab_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label2 = new Label();
            txtBoxMoney = new TextBox();
            label1 = new Label();
            button2 = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(15, 128);
            button1.Name = "button1";
            button1.Size = new Size(159, 23);
            button1.TabIndex = 1;
            button1.Text = "Конвертировать деньги";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Location = new Point(12, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(308, 80);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(300, 75);
            label2.TabIndex = 2;
            label2.Text = "Дано натуральное число 1<=n<=9999, определяющее стоимость товара в копейках. Выразить стоимость в рублях и копейках, например, 3 рубля 21 копейка, 15 рублей 5 копеек, 1 рубль ровно и т. п.";
            // 
            // txtBoxMoney
            // 
            txtBoxMoney.Location = new Point(118, 99);
            txtBoxMoney.Name = "txtBoxMoney";
            txtBoxMoney.Size = new Size(197, 23);
            txtBoxMoney.TabIndex = 0;
            txtBoxMoney.KeyDown += txtBoxMoney_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 102);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 3;
            label1.Text = "Введите деньги:";
            // 
            // button2
            // 
            button2.Location = new Point(185, 128);
            button2.Name = "button2";
            button2.Size = new Size(130, 23);
            button2.TabIndex = 2;
            button2.Text = "Очистить поле";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 158);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(txtBoxMoney);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Расчитать рубли и  копейки";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private TextBox txtBoxMoney;
        private Label label1;
        private Button button2;
    }
}

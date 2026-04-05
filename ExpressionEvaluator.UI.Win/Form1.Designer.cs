namespace ExpressionEvaluator.UI.Win
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtDisplay = new TextBox();
            btn7 = new Button();
            btn8 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn9 = new Button();
            btn3 = new Button();
            btn0 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btn6 = new Button();
            bntDot = new Button();
            btnMinus = new Button();
            btnMultiplay = new Button();
            btnPlus = new Button();
            btnDivide = new Button();
            btnOpenParenthesis = new Button();
            btnPow = new Button();
            bntResult = new Button();
            btnCloseParenthesis = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.BackColor = Color.Green;
            txtDisplay.Font = new Font("Segoe UI", 18F);
            txtDisplay.ForeColor = Color.White;
            txtDisplay.Location = new Point(12, 12);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(527, 55);
            txtDisplay.TabIndex = 0;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn7.Location = new Point(12, 73);
            btn7.Name = "btn7";
            btn7.Size = new Size(71, 70);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn8.Location = new Point(89, 73);
            btn8.Name = "btn8";
            btn8.Size = new Size(71, 70);
            btn8.TabIndex = 2;
            btn8.Text = "8";
            btn8.Click += btn8_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn5.Location = new Point(89, 149);
            btn5.Name = "btn5";
            btn5.Size = new Size(71, 70);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn4.Location = new Point(12, 149);
            btn4.Name = "btn4";
            btn4.Size = new Size(71, 70);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.Click += btn4_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn9.Location = new Point(166, 73);
            btn9.Name = "btn9";
            btn9.Size = new Size(71, 70);
            btn9.TabIndex = 3;
            btn9.Text = "9";
            btn9.Click += btn9_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn3.Location = new Point(166, 225);
            btn3.Name = "btn3";
            btn3.Size = new Size(71, 70);
            btn3.TabIndex = 9;
            btn3.Text = "3";
            btn3.Click += btn3_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn0.Location = new Point(12, 301);
            btn0.Name = "btn0";
            btn0.Size = new Size(148, 70);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.Click += btn0_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn2.Location = new Point(89, 225);
            btn2.Name = "btn2";
            btn2.Size = new Size(71, 70);
            btn2.TabIndex = 8;
            btn2.Text = "2";
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn1.Location = new Point(12, 225);
            btn1.Name = "btn1";
            btn1.Size = new Size(71, 70);
            btn1.TabIndex = 7;
            btn1.Text = "1";
            btn1.Click += btn1_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btn6.Location = new Point(166, 149);
            btn6.Name = "btn6";
            btn6.Size = new Size(71, 70);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.Click += btn6_Click;
            // 
            // bntDot
            // 
            bntDot.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            bntDot.Location = new Point(166, 301);
            bntDot.Name = "bntDot";
            bntDot.Size = new Size(71, 70);
            bntDot.TabIndex = 11;
            bntDot.Text = ".";
            bntDot.Click += btnDot_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.FromArgb(255, 128, 0);
            btnMinus.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnMinus.Location = new Point(320, 149);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(71, 70);
            btnMinus.TabIndex = 15;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnMultiplay
            // 
            btnMultiplay.BackColor = Color.FromArgb(255, 128, 0);
            btnMultiplay.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnMultiplay.Location = new Point(320, 73);
            btnMultiplay.Name = "btnMultiplay";
            btnMultiplay.Size = new Size(71, 70);
            btnMultiplay.TabIndex = 13;
            btnMultiplay.Text = "*";
            btnMultiplay.UseVisualStyleBackColor = false;
            btnMultiplay.Click += btnMultiplay_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.FromArgb(255, 128, 0);
            btnPlus.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnPlus.Location = new Point(243, 149);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(71, 70);
            btnPlus.TabIndex = 14;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.FromArgb(255, 128, 0);
            btnDivide.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnDivide.Location = new Point(243, 73);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(71, 70);
            btnDivide.TabIndex = 12;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnOpenParenthesis
            // 
            btnOpenParenthesis.BackColor = Color.FromArgb(255, 128, 0);
            btnOpenParenthesis.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnOpenParenthesis.Location = new Point(243, 225);
            btnOpenParenthesis.Name = "btnOpenParenthesis";
            btnOpenParenthesis.Size = new Size(71, 70);
            btnOpenParenthesis.TabIndex = 16;
            btnOpenParenthesis.Text = "(";
            btnOpenParenthesis.UseVisualStyleBackColor = false;
            btnOpenParenthesis.Click += btnOpenParenthesis_Click;
            // 
            // btnPow
            // 
            btnPow.BackColor = Color.FromArgb(255, 128, 0);
            btnPow.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnPow.Location = new Point(397, 225);
            btnPow.Name = "btnPow";
            btnPow.Size = new Size(142, 70);
            btnPow.TabIndex = 18;
            btnPow.Text = "^";
            btnPow.UseVisualStyleBackColor = false;
            btnPow.Click += btnPow_Click;
            // 
            // bntResult
            // 
            bntResult.BackColor = Color.FromArgb(255, 128, 0);
            bntResult.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            bntResult.Location = new Point(243, 301);
            bntResult.Name = "bntResult";
            bntResult.Size = new Size(296, 70);
            bntResult.TabIndex = 21;
            bntResult.Text = "=";
            bntResult.UseVisualStyleBackColor = false;
            bntResult.Click += btnResult_Click;
            // 
            // btnCloseParenthesis
            // 
            btnCloseParenthesis.BackColor = Color.FromArgb(255, 128, 0);
            btnCloseParenthesis.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnCloseParenthesis.Location = new Point(320, 225);
            btnCloseParenthesis.Name = "btnCloseParenthesis";
            btnCloseParenthesis.Size = new Size(71, 70);
            btnCloseParenthesis.TabIndex = 17;
            btnCloseParenthesis.Text = ")";
            btnCloseParenthesis.UseVisualStyleBackColor = false;
            btnCloseParenthesis.Click += btnCloseParenthesis_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(255, 128, 0);
            btnClear.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnClear.Location = new Point(397, 149);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(142, 70);
            btnClear.TabIndex = 20;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 128, 0);
            btnDelete.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnDelete.Location = new Point(397, 73);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(142, 70);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            BackColor = Color.White;
            ClientSize = new Size(551, 381);
            Controls.Add(txtDisplay);
            Controls.Add(btn7);
            Controls.Add(btn8);
            Controls.Add(btn9);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btn1);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btn0);
            Controls.Add(bntDot);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiplay);
            Controls.Add(btnPlus);
            Controls.Add(btnMinus);
            Controls.Add(btnOpenParenthesis);
            Controls.Add(btnCloseParenthesis);
            Controls.Add(btnPow);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(bntResult);
            Name = "Form1";
            Text = "Functions Evaluator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox txtDisplay;
        private Button btn7, btn8, btn9, btn4, btn5, btn6, btn1, btn2, btn3, btn0;
        private Button bntDot;
        private Button btnMinus, btnMultiplay, btnPlus, btnDivide;
        private Button btnOpenParenthesis, btnPow, bntResult, btnCloseParenthesis;
        private Button btnClear, btnDelete;
    }
}
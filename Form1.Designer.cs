namespace FormsApp02
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
            groupBox1 = new GroupBox();
            txtRadius = new TextBox();
            btnCircleArea = new Button();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtWidht = new TextBox();
            txtHeight = new TextBox();
            button2 = new Button();
            label3 = new Label();
            label2 = new Label();
            groupBox3 = new GroupBox();
            txtHexagonWidth = new TextBox();
            btnHexagonArea = new Button();
            label4 = new Label();
            lblResult = new Label();
            label6 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(255, 192, 255);
            groupBox1.Controls.Add(txtRadius);
            groupBox1.Controls.Add(btnCircleArea);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(23, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(553, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "คำนวณพื้นที่วงกลม";
            // 
            // txtRadius
            // 
            txtRadius.Location = new Point(142, 60);
            txtRadius.Name = "txtRadius";
            txtRadius.Size = new Size(212, 27);
            txtRadius.TabIndex = 2;
            // 
            // btnCircleArea
            // 
            btnCircleArea.Location = new Point(386, 60);
            btnCircleArea.Name = "btnCircleArea";
            btnCircleArea.Size = new Size(128, 29);
            btnCircleArea.TabIndex = 1;
            btnCircleArea.Text = "คำนวณพื้นที่วงกลม";
            btnCircleArea.UseVisualStyleBackColor = true;
            btnCircleArea.Click += btnCircleArea_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(53, 64);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 0;
            label1.Text = "รัศมี";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(128, 128, 255);
            groupBox2.Controls.Add(txtWidht);
            groupBox2.Controls.Add(txtHeight);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(23, 203);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(553, 158);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "คำนวณพื้นที่สามเหลี่ยม";
            // 
            // txtWidht
            // 
            txtWidht.Location = new Point(153, 102);
            txtWidht.Name = "txtWidht";
            txtWidht.Size = new Size(201, 27);
            txtWidht.TabIndex = 2;
            txtWidht.TextChanged += txtWidht_TextChanged;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(153, 42);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(201, 27);
            txtHeight.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(374, 76);
            button2.Name = "button2";
            button2.Size = new Size(173, 29);
            button2.TabIndex = 2;
            button2.Text = "คำนวณพื้นที่สามเหลี่ยม";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Location = new Point(41, 109);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 1;
            label3.Text = "ความยาวฐาน";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(53, 45);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 0;
            label2.Text = "ความสูง";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Yellow;
            groupBox3.Controls.Add(txtHexagonWidth);
            groupBox3.Controls.Add(btnHexagonArea);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(23, 395);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(553, 125);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "คำนวณพื้นที่หกเหลี่ยมด้านเท่า";
            // 
            // txtHexagonWidth
            // 
            txtHexagonWidth.Location = new Point(153, 60);
            txtHexagonWidth.Name = "txtHexagonWidth";
            txtHexagonWidth.Size = new Size(201, 27);
            txtHexagonWidth.TabIndex = 2;
            // 
            // btnHexagonArea
            // 
            btnHexagonArea.Location = new Point(386, 59);
            btnHexagonArea.Name = "btnHexagonArea";
            btnHexagonArea.Size = new Size(146, 29);
            btnHexagonArea.TabIndex = 1;
            btnHexagonArea.Text = "คำนวณพื้นที่หกเหลี่ยมด้านเท่า";
            btnHexagonArea.UseVisualStyleBackColor = true;
            btnHexagonArea.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Location = new Point(41, 64);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 0;
            label4.Text = "ความยาวฐาน";
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.FromArgb(192, 255, 255);
            lblResult.Location = new Point(665, 149);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(198, 79);
            lblResult.TabIndex = 3;
            lblResult.Text = "label5";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            lblResult.UseWaitCursor = true;
            // 
            // label6
            // 
            label6.Location = new Point(665, 129);
            label6.Name = "label6";
            label6.Size = new Size(198, 25);
            label6.TabIndex = 4;
            label6.Text = "พื้นที่(ตารางหน่วย)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 192);
            ClientSize = new Size(952, 584);
            Controls.Add(label6);
            Controls.Add(lblResult);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "โปรแกรมคำนวณพื้นที่";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
        private GroupBox groupBox3;
        private Label label4;
        private TextBox txtRadius;
        private Button btnCircleArea;
        private TextBox txtWidht;
        private TextBox txtHeight;
        private Button button2;
        private TextBox txtHexagonWidth;
        private Button btnHexagonArea;
        private Label lblResult;
        private Label label6;
    }
}

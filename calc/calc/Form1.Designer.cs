namespace calc
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.display = new System.Windows.Forms.Label();
            this.button_Result = new System.Windows.Forms.Button();
            this.button_Subtract = new System.Windows.Forms.Button();
            this.button_Three = new System.Windows.Forms.Button();
            this.button_Two = new System.Windows.Forms.Button();
            this.button_One = new System.Windows.Forms.Button();
            this.button_Multiplly = new System.Windows.Forms.Button();
            this.button_Six = new System.Windows.Forms.Button();
            this.button_Five = new System.Windows.Forms.Button();
            this.button_Four = new System.Windows.Forms.Button();
            this.button_Divide = new System.Windows.Forms.Button();
            this.button_Nine = new System.Windows.Forms.Button();
            this.button_Eight = new System.Windows.Forms.Button();
            this.button_Seven = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.botton_Zero = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.Dock = System.Windows.Forms.DockStyle.Top;
            this.display.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.display.Location = new System.Drawing.Point(0, 0);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(546, 51);
            this.display.TabIndex = 0;
            this.display.Text = "0";
            this.display.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button_Result
            // 
            this.button_Result.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_Result.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_Result.Location = new System.Drawing.Point(0, 477);
            this.button_Result.Margin = new System.Windows.Forms.Padding(0);
            this.button_Result.Name = "button_Result";
            this.button_Result.Size = new System.Drawing.Size(546, 46);
            this.button_Result.TabIndex = 14;
            this.button_Result.Text = "=";
            this.button_Result.UseVisualStyleBackColor = true;
            this.button_Result.Click += new System.EventHandler(this.button_Result_Click);
            // 
            // button_Subtract
            // 
            this.button_Subtract.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_Subtract.Location = new System.Drawing.Point(399, 200);
            this.button_Subtract.Margin = new System.Windows.Forms.Padding(0);
            this.button_Subtract.Name = "button_Subtract";
            this.button_Subtract.Size = new System.Drawing.Size(127, 94);
            this.button_Subtract.TabIndex = 11;
            this.button_Subtract.Text = "－";
            this.button_Subtract.UseVisualStyleBackColor = true;
            this.button_Subtract.Click += new System.EventHandler(this.button_Subtract_Click);
            // 
            // button_Three
            // 
            this.button_Three.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_Three.Location = new System.Drawing.Point(266, 200);
            this.button_Three.Margin = new System.Windows.Forms.Padding(0);
            this.button_Three.Name = "button_Three";
            this.button_Three.Size = new System.Drawing.Size(127, 94);
            this.button_Three.TabIndex = 10;
            this.button_Three.Text = "3";
            this.button_Three.UseVisualStyleBackColor = true;
            this.button_Three.Click += new System.EventHandler(this.button_Three_Click);
            // 
            // button_Two
            // 
            this.button_Two.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_Two.Location = new System.Drawing.Point(133, 200);
            this.button_Two.Margin = new System.Windows.Forms.Padding(0);
            this.button_Two.Name = "button_Two";
            this.button_Two.Size = new System.Drawing.Size(127, 94);
            this.button_Two.TabIndex = 9;
            this.button_Two.Text = "2";
            this.button_Two.UseVisualStyleBackColor = true;
            this.button_Two.Click += new System.EventHandler(this.button_Two_Click);
            // 
            // button_One
            // 
            this.button_One.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_One.Location = new System.Drawing.Point(0, 200);
            this.button_One.Margin = new System.Windows.Forms.Padding(0);
            this.button_One.Name = "button_One";
            this.button_One.Size = new System.Drawing.Size(127, 94);
            this.button_One.TabIndex = 8;
            this.button_One.Text = "1";
            this.button_One.UseVisualStyleBackColor = true;
            this.button_One.Click += new System.EventHandler(this.button_One_Click);
            // 
            // button_Multiplly
            // 
            this.button_Multiplly.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_Multiplly.Location = new System.Drawing.Point(399, 100);
            this.button_Multiplly.Margin = new System.Windows.Forms.Padding(0);
            this.button_Multiplly.Name = "button_Multiplly";
            this.button_Multiplly.Size = new System.Drawing.Size(127, 94);
            this.button_Multiplly.TabIndex = 7;
            this.button_Multiplly.Text = "×";
            this.button_Multiplly.UseVisualStyleBackColor = true;
            this.button_Multiplly.Click += new System.EventHandler(this.button_Multiply_Click);
            // 
            // button_Six
            // 
            this.button_Six.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_Six.Location = new System.Drawing.Point(266, 100);
            this.button_Six.Margin = new System.Windows.Forms.Padding(0);
            this.button_Six.Name = "button_Six";
            this.button_Six.Size = new System.Drawing.Size(127, 94);
            this.button_Six.TabIndex = 6;
            this.button_Six.Text = "6";
            this.button_Six.UseVisualStyleBackColor = true;
            this.button_Six.Click += new System.EventHandler(this.button_Six_Click);
            // 
            // button_Five
            // 
            this.button_Five.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_Five.Location = new System.Drawing.Point(133, 100);
            this.button_Five.Margin = new System.Windows.Forms.Padding(0);
            this.button_Five.Name = "button_Five";
            this.button_Five.Size = new System.Drawing.Size(127, 94);
            this.button_Five.TabIndex = 5;
            this.button_Five.Text = "5";
            this.button_Five.UseVisualStyleBackColor = true;
            this.button_Five.Click += new System.EventHandler(this.button_Five_Click);
            // 
            // button_Four
            // 
            this.button_Four.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_Four.Location = new System.Drawing.Point(0, 100);
            this.button_Four.Margin = new System.Windows.Forms.Padding(0);
            this.button_Four.Name = "button_Four";
            this.button_Four.Size = new System.Drawing.Size(127, 94);
            this.button_Four.TabIndex = 4;
            this.button_Four.Text = "4";
            this.button_Four.UseVisualStyleBackColor = true;
            this.button_Four.Click += new System.EventHandler(this.button_Four_Click);
            // 
            // button_Divide
            // 
            this.button_Divide.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_Divide.Location = new System.Drawing.Point(399, 0);
            this.button_Divide.Margin = new System.Windows.Forms.Padding(0);
            this.button_Divide.Name = "button_Divide";
            this.button_Divide.Size = new System.Drawing.Size(127, 94);
            this.button_Divide.TabIndex = 3;
            this.button_Divide.Text = "÷";
            this.button_Divide.UseVisualStyleBackColor = true;
            this.button_Divide.Click += new System.EventHandler(this.button_Divide_Click);
            // 
            // button_Nine
            // 
            this.button_Nine.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_Nine.Location = new System.Drawing.Point(266, 0);
            this.button_Nine.Margin = new System.Windows.Forms.Padding(0);
            this.button_Nine.Name = "button_Nine";
            this.button_Nine.Size = new System.Drawing.Size(127, 94);
            this.button_Nine.TabIndex = 2;
            this.button_Nine.Text = "9";
            this.button_Nine.UseVisualStyleBackColor = true;
            this.button_Nine.Click += new System.EventHandler(this.button_Nine_Click);
            // 
            // button_Eight
            // 
            this.button_Eight.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_Eight.Location = new System.Drawing.Point(133, 0);
            this.button_Eight.Margin = new System.Windows.Forms.Padding(0);
            this.button_Eight.Name = "button_Eight";
            this.button_Eight.Size = new System.Drawing.Size(127, 94);
            this.button_Eight.TabIndex = 1;
            this.button_Eight.Text = "8";
            this.button_Eight.UseVisualStyleBackColor = true;
            this.button_Eight.Click += new System.EventHandler(this.button_Eight_Click);
            // 
            // button_Seven
            // 
            this.button_Seven.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_Seven.Location = new System.Drawing.Point(0, 0);
            this.button_Seven.Margin = new System.Windows.Forms.Padding(0);
            this.button_Seven.Name = "button_Seven";
            this.button_Seven.Size = new System.Drawing.Size(127, 94);
            this.button_Seven.TabIndex = 0;
            this.button_Seven.Text = "7";
            this.button_Seven.UseVisualStyleBackColor = true;
            this.button_Seven.Click += new System.EventHandler(this.button_Seven_Click);
            // 
            // button_Add
            // 
            this.button_Add.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_Add.Location = new System.Drawing.Point(266, 300);
            this.button_Add.Margin = new System.Windows.Forms.Padding(0);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(127, 94);
            this.button_Add.TabIndex = 13;
            this.button_Add.Text = "＋";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // botton_Zero
            // 
            this.botton_Zero.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.botton_Zero.Location = new System.Drawing.Point(133, 300);
            this.botton_Zero.Margin = new System.Windows.Forms.Padding(0);
            this.botton_Zero.Name = "botton_Zero";
            this.botton_Zero.Size = new System.Drawing.Size(127, 94);
            this.botton_Zero.TabIndex = 15;
            this.botton_Zero.Text = "0";
            this.botton_Zero.UseVisualStyleBackColor = true;
            this.botton_Zero.Click += new System.EventHandler(this.botton_Zero_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.botton_Zero, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button_Add, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button_Seven, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_Eight, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_Nine, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_Divide, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_Four, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_Five, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_Six, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_Multiplly, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_One, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_Two, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_Three, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_Subtract, 3, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 70);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(535, 402);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(0, 300);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 94);
            this.button1.TabIndex = 16;
            this.button1.Text = "－";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 523);
            this.Controls.Add(this.button_Result);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.display);
            this.Name = "Form1";
            this.Text = "calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label display;
        private System.Windows.Forms.Button button_Result;
        private System.Windows.Forms.Button button_Subtract;
        private System.Windows.Forms.Button button_Three;
        private System.Windows.Forms.Button button_Two;
        private System.Windows.Forms.Button button_One;
        private System.Windows.Forms.Button button_Multiplly;
        private System.Windows.Forms.Button button_Six;
        private System.Windows.Forms.Button button_Five;
        private System.Windows.Forms.Button button_Four;
        private System.Windows.Forms.Button button_Divide;
        private System.Windows.Forms.Button button_Nine;
        private System.Windows.Forms.Button button_Eight;
        private System.Windows.Forms.Button button_Seven;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button botton_Zero;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
    }
}


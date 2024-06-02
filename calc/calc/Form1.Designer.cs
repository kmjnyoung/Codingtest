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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bottonzero = new System.Windows.Forms.Button();
            this.buttonAC = new System.Windows.Forms.Button();
            this.buttonplus = new System.Windows.Forms.Button();
            this.buttonseven = new System.Windows.Forms.Button();
            this.buttoneight = new System.Windows.Forms.Button();
            this.buttonnine = new System.Windows.Forms.Button();
            this.buttondivide = new System.Windows.Forms.Button();
            this.buttonfour = new System.Windows.Forms.Button();
            this.buttonfive = new System.Windows.Forms.Button();
            this.buttonsix = new System.Windows.Forms.Button();
            this.buttonmultiple = new System.Windows.Forms.Button();
            this.buttonone = new System.Windows.Forms.Button();
            this.buttontwo = new System.Windows.Forms.Button();
            this.buttonthree = new System.Windows.Forms.Button();
            this.buttonminus = new System.Windows.Forms.Button();
            this.buttonresult = new System.Windows.Forms.Button();
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.bottonzero, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonAC, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonplus, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonseven, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttoneight, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonnine, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttondivide, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonfour, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonfive, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonsix, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonmultiple, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonone, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttontwo, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonthree, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonminus, 3, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 70);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(535, 402);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // bottonzero
            // 
            this.bottonzero.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bottonzero.Location = new System.Drawing.Point(0, 300);
            this.bottonzero.Margin = new System.Windows.Forms.Padding(0);
            this.bottonzero.Name = "bottonzero";
            this.bottonzero.Size = new System.Drawing.Size(127, 94);
            this.bottonzero.TabIndex = 15;
            this.bottonzero.Text = "0";
            this.bottonzero.UseVisualStyleBackColor = true;
            this.bottonzero.Click += new System.EventHandler(this.bottonzero_Click);
            // 
            // buttonAC
            // 
            this.buttonAC.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonAC.Location = new System.Drawing.Point(133, 300);
            this.buttonAC.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAC.Name = "buttonAC";
            this.buttonAC.Size = new System.Drawing.Size(127, 94);
            this.buttonAC.TabIndex = 14;
            this.buttonAC.Text = "AC";
            this.buttonAC.UseVisualStyleBackColor = true;
            this.buttonAC.Click += new System.EventHandler(this.buttonAC_Click);
            // 
            // buttonplus
            // 
            this.buttonplus.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonplus.Location = new System.Drawing.Point(266, 300);
            this.buttonplus.Margin = new System.Windows.Forms.Padding(0);
            this.buttonplus.Name = "buttonplus";
            this.buttonplus.Size = new System.Drawing.Size(127, 94);
            this.buttonplus.TabIndex = 13;
            this.buttonplus.Text = "＋";
            this.buttonplus.UseVisualStyleBackColor = true;
            this.buttonplus.Click += new System.EventHandler(this.buttonplus_Click);
            // 
            // buttonseven
            // 
            this.buttonseven.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonseven.Location = new System.Drawing.Point(0, 0);
            this.buttonseven.Margin = new System.Windows.Forms.Padding(0);
            this.buttonseven.Name = "buttonseven";
            this.buttonseven.Size = new System.Drawing.Size(127, 94);
            this.buttonseven.TabIndex = 0;
            this.buttonseven.Text = "7";
            this.buttonseven.UseVisualStyleBackColor = true;
            this.buttonseven.Click += new System.EventHandler(this.buttonseven_Click);
            // 
            // buttoneight
            // 
            this.buttoneight.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttoneight.Location = new System.Drawing.Point(133, 0);
            this.buttoneight.Margin = new System.Windows.Forms.Padding(0);
            this.buttoneight.Name = "buttoneight";
            this.buttoneight.Size = new System.Drawing.Size(127, 94);
            this.buttoneight.TabIndex = 1;
            this.buttoneight.Text = "8";
            this.buttoneight.UseVisualStyleBackColor = true;
            this.buttoneight.Click += new System.EventHandler(this.buttoneight_Click);
            // 
            // buttonnine
            // 
            this.buttonnine.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonnine.Location = new System.Drawing.Point(266, 0);
            this.buttonnine.Margin = new System.Windows.Forms.Padding(0);
            this.buttonnine.Name = "buttonnine";
            this.buttonnine.Size = new System.Drawing.Size(127, 94);
            this.buttonnine.TabIndex = 2;
            this.buttonnine.Text = "9";
            this.buttonnine.UseVisualStyleBackColor = true;
            this.buttonnine.Click += new System.EventHandler(this.buttonnine_Click);
            // 
            // buttondivide
            // 
            this.buttondivide.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttondivide.Location = new System.Drawing.Point(399, 0);
            this.buttondivide.Margin = new System.Windows.Forms.Padding(0);
            this.buttondivide.Name = "buttondivide";
            this.buttondivide.Size = new System.Drawing.Size(127, 94);
            this.buttondivide.TabIndex = 3;
            this.buttondivide.Text = "÷";
            this.buttondivide.UseVisualStyleBackColor = true;
            this.buttondivide.Click += new System.EventHandler(this.buttondivide_Click);
            // 
            // buttonfour
            // 
            this.buttonfour.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonfour.Location = new System.Drawing.Point(0, 100);
            this.buttonfour.Margin = new System.Windows.Forms.Padding(0);
            this.buttonfour.Name = "buttonfour";
            this.buttonfour.Size = new System.Drawing.Size(127, 94);
            this.buttonfour.TabIndex = 4;
            this.buttonfour.Text = "4";
            this.buttonfour.UseVisualStyleBackColor = true;
            this.buttonfour.Click += new System.EventHandler(this.buttonfour_Click);
            // 
            // buttonfive
            // 
            this.buttonfive.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonfive.Location = new System.Drawing.Point(133, 100);
            this.buttonfive.Margin = new System.Windows.Forms.Padding(0);
            this.buttonfive.Name = "buttonfive";
            this.buttonfive.Size = new System.Drawing.Size(127, 94);
            this.buttonfive.TabIndex = 5;
            this.buttonfive.Text = "5";
            this.buttonfive.UseVisualStyleBackColor = true;
            this.buttonfive.Click += new System.EventHandler(this.buttonfive_Click);
            // 
            // buttonsix
            // 
            this.buttonsix.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonsix.Location = new System.Drawing.Point(266, 100);
            this.buttonsix.Margin = new System.Windows.Forms.Padding(0);
            this.buttonsix.Name = "buttonsix";
            this.buttonsix.Size = new System.Drawing.Size(127, 94);
            this.buttonsix.TabIndex = 6;
            this.buttonsix.Text = "6";
            this.buttonsix.UseVisualStyleBackColor = true;
            this.buttonsix.Click += new System.EventHandler(this.buttonsix_Click);
            // 
            // buttonmultiple
            // 
            this.buttonmultiple.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonmultiple.Location = new System.Drawing.Point(399, 100);
            this.buttonmultiple.Margin = new System.Windows.Forms.Padding(0);
            this.buttonmultiple.Name = "buttonmultiple";
            this.buttonmultiple.Size = new System.Drawing.Size(127, 94);
            this.buttonmultiple.TabIndex = 7;
            this.buttonmultiple.Text = "×";
            this.buttonmultiple.UseVisualStyleBackColor = true;
            this.buttonmultiple.Click += new System.EventHandler(this.buttonmultiple_Click);
            // 
            // buttonone
            // 
            this.buttonone.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonone.Location = new System.Drawing.Point(0, 200);
            this.buttonone.Margin = new System.Windows.Forms.Padding(0);
            this.buttonone.Name = "buttonone";
            this.buttonone.Size = new System.Drawing.Size(127, 94);
            this.buttonone.TabIndex = 8;
            this.buttonone.Text = "1";
            this.buttonone.UseVisualStyleBackColor = true;
            this.buttonone.Click += new System.EventHandler(this.buttonone_Click);
            // 
            // buttontwo
            // 
            this.buttontwo.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttontwo.Location = new System.Drawing.Point(133, 200);
            this.buttontwo.Margin = new System.Windows.Forms.Padding(0);
            this.buttontwo.Name = "buttontwo";
            this.buttontwo.Size = new System.Drawing.Size(127, 94);
            this.buttontwo.TabIndex = 9;
            this.buttontwo.Text = "2";
            this.buttontwo.UseVisualStyleBackColor = true;
            this.buttontwo.Click += new System.EventHandler(this.buttontwo_Click);
            // 
            // buttonthree
            // 
            this.buttonthree.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonthree.Location = new System.Drawing.Point(266, 200);
            this.buttonthree.Margin = new System.Windows.Forms.Padding(0);
            this.buttonthree.Name = "buttonthree";
            this.buttonthree.Size = new System.Drawing.Size(127, 94);
            this.buttonthree.TabIndex = 10;
            this.buttonthree.Text = "3";
            this.buttonthree.UseVisualStyleBackColor = true;
            this.buttonthree.Click += new System.EventHandler(this.buttonthree_Click);
            // 
            // buttonminus
            // 
            this.buttonminus.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonminus.Location = new System.Drawing.Point(399, 200);
            this.buttonminus.Margin = new System.Windows.Forms.Padding(0);
            this.buttonminus.Name = "buttonminus";
            this.buttonminus.Size = new System.Drawing.Size(127, 94);
            this.buttonminus.TabIndex = 11;
            this.buttonminus.Text = "－";
            this.buttonminus.UseVisualStyleBackColor = true;
            this.buttonminus.Click += new System.EventHandler(this.buttonminus_Click);
            // 
            // buttonresult
            // 
            this.buttonresult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonresult.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.buttonresult.Location = new System.Drawing.Point(0, 477);
            this.buttonresult.Margin = new System.Windows.Forms.Padding(0);
            this.buttonresult.Name = "buttonresult";
            this.buttonresult.Size = new System.Drawing.Size(546, 46);
            this.buttonresult.TabIndex = 14;
            this.buttonresult.Text = "=";
            this.buttonresult.UseVisualStyleBackColor = true;
            this.buttonresult.Click += new System.EventHandler(this.buttonresult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 523);
            this.Controls.Add(this.buttonresult);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.display);
            this.Name = "Form1";
            this.Text = "calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label display;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonseven;
        private System.Windows.Forms.Button buttoneight;
        private System.Windows.Forms.Button buttonnine;
        private System.Windows.Forms.Button buttondivide;
        private System.Windows.Forms.Button buttonfour;
        private System.Windows.Forms.Button buttonfive;
        private System.Windows.Forms.Button buttonsix;
        private System.Windows.Forms.Button buttonmultiple;
        private System.Windows.Forms.Button buttonone;
        private System.Windows.Forms.Button bottonzero;
        private System.Windows.Forms.Button buttonAC;
        private System.Windows.Forms.Button buttonplus;
        private System.Windows.Forms.Button buttontwo;
        private System.Windows.Forms.Button buttonthree;
        private System.Windows.Forms.Button buttonminus;
        private System.Windows.Forms.Button buttonresult;
    }
}


﻿namespace Calculator
{
    partial class Calculator
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
            this.NumButton1 = new System.Windows.Forms.Button();
            this.NumButton2 = new System.Windows.Forms.Button();
            this.NumScreen = new System.Windows.Forms.Label();
            this.Numplus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumButton1
            // 
            this.NumButton1.Location = new System.Drawing.Point(12, 109);
            this.NumButton1.Name = "NumButton1";
            this.NumButton1.Size = new System.Drawing.Size(57, 56);
            this.NumButton1.TabIndex = 0;
            this.NumButton1.Text = "1";
            this.NumButton1.UseVisualStyleBackColor = true;
            this.NumButton1.Click += new System.EventHandler(this.NumButton1_Click);
            // 
            // NumButton2
            // 
            this.NumButton2.Location = new System.Drawing.Point(75, 109);
            this.NumButton2.Name = "NumButton2";
            this.NumButton2.Size = new System.Drawing.Size(57, 56);
            this.NumButton2.TabIndex = 1;
            this.NumButton2.Text = "2";
            this.NumButton2.UseVisualStyleBackColor = true;
            this.NumButton2.Click += new System.EventHandler(this.NumButton2_Click);
            // 
            // NumScreen
            // 
            this.NumScreen.BackColor = System.Drawing.Color.White;
            this.NumScreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NumScreen.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NumScreen.Location = new System.Drawing.Point(12, 9);
            this.NumScreen.Name = "NumScreen";
            this.NumScreen.Size = new System.Drawing.Size(273, 43);
            this.NumScreen.TabIndex = 2;
            this.NumScreen.Text = "0";
            this.NumScreen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Numplus
            // 
            this.Numplus.Location = new System.Drawing.Point(228, 109);
            this.Numplus.Name = "Numplus";
            this.Numplus.Size = new System.Drawing.Size(57, 56);
            this.Numplus.TabIndex = 3;
            this.Numplus.Text = "+";
            this.Numplus.UseVisualStyleBackColor = true;
            this.Numplus.Click += new System.EventHandler(this.Numplus_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 397);
            this.Controls.Add(this.Numplus);
            this.Controls.Add(this.NumScreen);
            this.Controls.Add(this.NumButton2);
            this.Controls.Add(this.NumButton1);
            this.Name = "Calculator";
            this.Text = "계산기 프로그램";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NumButton1;
        private System.Windows.Forms.Button NumButton2;
        private System.Windows.Forms.Label NumScreen;
        private System.Windows.Forms.Button Numplus;
    }
}


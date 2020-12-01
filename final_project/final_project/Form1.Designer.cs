namespace final_project
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.form_money_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // form_money_btn
            // 
            this.form_money_btn.Location = new System.Drawing.Point(648, 293);
            this.form_money_btn.Name = "form_money_btn";
            this.form_money_btn.Size = new System.Drawing.Size(91, 31);
            this.form_money_btn.TabIndex = 0;
            this.form_money_btn.Text = "記帳頁面";
            this.form_money_btn.UseVisualStyleBackColor = true;
            this.form_money_btn.Click += new System.EventHandler(this.form_money_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.form_money_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button form_money_btn;
    }
}


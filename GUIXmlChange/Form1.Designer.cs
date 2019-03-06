namespace GUIXmlChange
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
            this.label1 = new System.Windows.Forms.Label();
            this.TBINI = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.BtnINI = new System.Windows.Forms.Button();
            this.BtnXml = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TBXml = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.LBINI = new System.Windows.Forms.ListBox();
            this.BtnSwap = new System.Windows.Forms.Button();
            this.BtnRead = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LBMsg = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "INI File : ";
            // 
            // TBINI
            // 
            this.TBINI.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBINI.Location = new System.Drawing.Point(163, 12);
            this.TBINI.Name = "TBINI";
            this.TBINI.Size = new System.Drawing.Size(699, 34);
            this.TBINI.TabIndex = 1;
            // 
            // BtnINI
            // 
            this.BtnINI.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnINI.Location = new System.Drawing.Point(868, 12);
            this.BtnINI.Name = "BtnINI";
            this.BtnINI.Size = new System.Drawing.Size(124, 34);
            this.BtnINI.TabIndex = 2;
            this.BtnINI.Text = "Search";
            this.BtnINI.UseVisualStyleBackColor = true;
            this.BtnINI.Click += new System.EventHandler(this.BtnINI_Click);
            // 
            // BtnXml
            // 
            this.BtnXml.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnXml.Location = new System.Drawing.Point(868, 53);
            this.BtnXml.Name = "BtnXml";
            this.BtnXml.Size = new System.Drawing.Size(124, 35);
            this.BtnXml.TabIndex = 3;
            this.BtnXml.Text = "Search";
            this.BtnXml.UseVisualStyleBackColor = true;
            this.BtnXml.Click += new System.EventHandler(this.BtnXml_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Xml File : ";
            // 
            // TBXml
            // 
            this.TBXml.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXml.Location = new System.Drawing.Point(163, 54);
            this.TBXml.Name = "TBXml";
            this.TBXml.Size = new System.Drawing.Size(699, 34);
            this.TBXml.TabIndex = 5;
            // 
            // LBINI
            // 
            this.LBINI.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBINI.FormattingEnabled = true;
            this.LBINI.ItemHeight = 23;
            this.LBINI.Location = new System.Drawing.Point(17, 145);
            this.LBINI.Name = "LBINI";
            this.LBINI.Size = new System.Drawing.Size(663, 464);
            this.LBINI.TabIndex = 6;
            // 
            // BtnSwap
            // 
            this.BtnSwap.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSwap.Location = new System.Drawing.Point(868, 560);
            this.BtnSwap.Name = "BtnSwap";
            this.BtnSwap.Size = new System.Drawing.Size(124, 49);
            this.BtnSwap.TabIndex = 8;
            this.BtnSwap.Text = "Swap";
            this.BtnSwap.UseVisualStyleBackColor = true;
            this.BtnSwap.Click += new System.EventHandler(this.BtnSwap_Click);
            // 
            // BtnRead
            // 
            this.BtnRead.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRead.Location = new System.Drawing.Point(698, 560);
            this.BtnRead.Name = "BtnRead";
            this.BtnRead.Size = new System.Drawing.Size(135, 49);
            this.BtnRead.TabIndex = 9;
            this.BtnRead.Text = "Read INI";
            this.BtnRead.UseVisualStyleBackColor = true;
            this.BtnRead.Click += new System.EventHandler(this.BtnRead_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(206, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "INI Content";
            // 
            // LBMsg
            // 
            this.LBMsg.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBMsg.FormattingEnabled = true;
            this.LBMsg.ItemHeight = 23;
            this.LBMsg.Location = new System.Drawing.Point(698, 145);
            this.LBMsg.Name = "LBMsg";
            this.LBMsg.Size = new System.Drawing.Size(294, 395);
            this.LBMsg.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(800, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 28);
            this.label4.TabIndex = 12;
            this.label4.Text = "Message";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 621);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LBMsg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnRead);
            this.Controls.Add(this.BtnSwap);
            this.Controls.Add(this.LBINI);
            this.Controls.Add(this.TBXml);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnXml);
            this.Controls.Add(this.BtnINI);
            this.Controls.Add(this.TBINI);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBINI;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button BtnINI;
        private System.Windows.Forms.Button BtnXml;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBXml;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ListBox LBINI;
        private System.Windows.Forms.Button BtnSwap;
        private System.Windows.Forms.Button BtnRead;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox LBMsg;
        private System.Windows.Forms.Label label4;
    }
}


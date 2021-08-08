
namespace CotacaoDolarMS
{
    partial class FrmCotacaoDolar
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSell = new System.Windows.Forms.Label();
            this.lblBuy = new System.Windows.Forms.Label();
            this.lblVar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(-2, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dólar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.Location = new System.Drawing.Point(128, 317);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(157, 57);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Pesquisar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Compra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Venda:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Variação:";
            // 
            // lblSell
            // 
            this.lblSell.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSell.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSell.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSell.Location = new System.Drawing.Point(155, 181);
            this.lblSell.Name = "lblSell";
            this.lblSell.Size = new System.Drawing.Size(246, 48);
            this.lblSell.TabIndex = 5;
            this.lblSell.Text = "0,0";
            this.lblSell.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBuy
            // 
            this.lblBuy.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBuy.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBuy.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBuy.Location = new System.Drawing.Point(155, 123);
            this.lblBuy.Name = "lblBuy";
            this.lblBuy.Size = new System.Drawing.Size(246, 48);
            this.lblBuy.TabIndex = 6;
            this.lblBuy.Text = "0,0";
            this.lblBuy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVar
            // 
            this.lblVar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblVar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblVar.Location = new System.Drawing.Point(155, 239);
            this.lblVar.Name = "lblVar";
            this.lblVar.Size = new System.Drawing.Size(246, 48);
            this.lblVar.TabIndex = 7;
            this.lblVar.Text = "0,0";
            this.lblVar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmCotacaoDolar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 450);
            this.Controls.Add(this.lblVar);
            this.Controls.Add(this.lblBuy);
            this.Controls.Add(this.lblSell);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCotacaoDolar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cotação Dolar";
            //this.Load += new System.EventHandler(this.FrmCotacaoDolar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSell;
        private System.Windows.Forms.Label lblBuy;
        private System.Windows.Forms.Label lblVar;
    }
}


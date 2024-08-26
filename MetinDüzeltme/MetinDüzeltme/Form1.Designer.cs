namespace MetinDüzeltme
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.TBoxMetin = new System.Windows.Forms.TextBox();
            this.TBoxEskiParca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnDuzelt = new System.Windows.Forms.Button();
            this.DGV1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TBoxYeniParca = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(38, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Metniniz:";
            // 
            // TBoxMetin
            // 
            this.TBoxMetin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBoxMetin.Location = new System.Drawing.Point(143, 53);
            this.TBoxMetin.Multiline = true;
            this.TBoxMetin.Name = "TBoxMetin";
            this.TBoxMetin.Size = new System.Drawing.Size(573, 467);
            this.TBoxMetin.TabIndex = 1;
            // 
            // TBoxEskiParca
            // 
            this.TBoxEskiParca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBoxEskiParca.Location = new System.Drawing.Point(317, 546);
            this.TBoxEskiParca.Multiline = true;
            this.TBoxEskiParca.Name = "TBoxEskiParca";
            this.TBoxEskiParca.Size = new System.Drawing.Size(399, 51);
            this.TBoxEskiParca.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(38, 565);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Değiştirmek istediğiniz parçalar:";
            // 
            // BtnDuzelt
            // 
            this.BtnDuzelt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDuzelt.Location = new System.Drawing.Point(780, 53);
            this.BtnDuzelt.Name = "BtnDuzelt";
            this.BtnDuzelt.Size = new System.Drawing.Size(115, 64);
            this.BtnDuzelt.TabIndex = 4;
            this.BtnDuzelt.Text = "Düzelt";
            this.BtnDuzelt.UseVisualStyleBackColor = true;
            this.BtnDuzelt.Click += new System.EventHandler(this.BtnDuzelt_Click);
            // 
            // DGV1
            // 
            this.DGV1.AllowUserToAddRows = false;
            this.DGV1.AllowUserToDeleteRows = false;
            this.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV1.Location = new System.Drawing.Point(42, 746);
            this.DGV1.Name = "DGV1";
            this.DGV1.ReadOnly = true;
            this.DGV1.RowHeadersWidth = 51;
            this.DGV1.RowTemplate.Height = 24;
            this.DGV1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV1.Size = new System.Drawing.Size(1089, 297);
            this.DGV1.TabIndex = 5;
            this.DGV1.SelectionChanged += new System.EventHandler(this.DGV1_SelectionChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(38, 712);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Önceden yaptıklarınız:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(134, 640);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Yerine yazılacaklar:";
            // 
            // TBoxYeniParca
            // 
            this.TBoxYeniParca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TBoxYeniParca.Location = new System.Drawing.Point(317, 620);
            this.TBoxYeniParca.Multiline = true;
            this.TBoxYeniParca.Name = "TBoxYeniParca";
            this.TBoxYeniParca.Size = new System.Drawing.Size(399, 51);
            this.TBoxYeniParca.TabIndex = 9;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1214, 1055);
            this.Controls.Add(this.TBoxYeniParca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DGV1);
            this.Controls.Add(this.BtnDuzelt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBoxEskiParca);
            this.Controls.Add(this.TBoxMetin);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBoxMetin;
        private System.Windows.Forms.TextBox TBoxEskiParca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnDuzelt;
        private System.Windows.Forms.DataGridView DGV1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBoxYeniParca;
    }
}


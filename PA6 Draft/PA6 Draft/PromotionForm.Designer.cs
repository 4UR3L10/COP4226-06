namespace PA6_Draft
{
    partial class PromotionForm
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
            this.comboBoxPromotion = new System.Windows.Forms.ComboBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelPromotion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxPromotion
            // 
            this.comboBoxPromotion.FormattingEnabled = true;
            this.comboBoxPromotion.Items.AddRange(new object[] {
            "Queen",
            "Rook",
            "Bishop",
            "Knight"});
            this.comboBoxPromotion.Location = new System.Drawing.Point(116, 41);
            this.comboBoxPromotion.Name = "comboBoxPromotion";
            this.comboBoxPromotion.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPromotion.TabIndex = 3;
            this.comboBoxPromotion.SelectedIndexChanged += new System.EventHandler(this.comboBoxPromotion_SelectedIndexChanged);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(79, 82);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "&Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // labelPromotion
            // 
            this.labelPromotion.AutoSize = true;
            this.labelPromotion.Location = new System.Drawing.Point(12, 44);
            this.labelPromotion.Name = "labelPromotion";
            this.labelPromotion.Size = new System.Drawing.Size(98, 13);
            this.labelPromotion.TabIndex = 5;
            this.labelPromotion.Text = "Select a promotion:";
            // 
            // PromotionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 129);
            this.Controls.Add(this.labelPromotion);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.comboBoxPromotion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PromotionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PromotionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPromotion;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label labelPromotion;
    }
}
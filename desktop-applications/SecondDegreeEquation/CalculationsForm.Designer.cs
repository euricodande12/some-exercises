namespace SecondDegreeEquation
{
    partial class CalculationsForm
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
            this.LblX = new System.Windows.Forms.Label();
            this.LblX2Calculation = new System.Windows.Forms.Label();
            this.LblDiscriminant = new System.Windows.Forms.Label();
            this.LblX1Calculation = new System.Windows.Forms.Label();
            this.LblDiscriminantCalculation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblX
            // 
            this.LblX.AutoSize = true;
            this.LblX.Location = new System.Drawing.Point(109, 9);
            this.LblX.Name = "LblX";
            this.LblX.Size = new System.Drawing.Size(70, 19);
            this.LblX.TabIndex = 0;
            this.LblX.Text = "X values";
            // 
            // LblX2Calculation
            // 
            this.LblX2Calculation.AutoSize = true;
            this.LblX2Calculation.Location = new System.Drawing.Point(23, 76);
            this.LblX2Calculation.Name = "LblX2Calculation";
            this.LblX2Calculation.Size = new System.Drawing.Size(123, 19);
            this.LblX2Calculation.TabIndex = 1;
            this.LblX2Calculation.Text = "x1 = -b + √Δ / 2a";
            // 
            // LblDiscriminant
            // 
            this.LblDiscriminant.AutoSize = true;
            this.LblDiscriminant.Location = new System.Drawing.Point(570, 9);
            this.LblDiscriminant.Name = "LblDiscriminant";
            this.LblDiscriminant.Size = new System.Drawing.Size(101, 19);
            this.LblDiscriminant.TabIndex = 2;
            this.LblDiscriminant.Text = "Discriminant";
            // 
            // LblX1Calculation
            // 
            this.LblX1Calculation.AutoSize = true;
            this.LblX1Calculation.Location = new System.Drawing.Point(23, 186);
            this.LblX1Calculation.Name = "LblX1Calculation";
            this.LblX1Calculation.Size = new System.Drawing.Size(123, 19);
            this.LblX1Calculation.TabIndex = 3;
            this.LblX1Calculation.Text = "x1 = -b - √Δ / 2a";
            // 
            // LblDiscriminantCalculation
            // 
            this.LblDiscriminantCalculation.AutoSize = true;
            this.LblDiscriminantCalculation.Location = new System.Drawing.Point(565, 76);
            this.LblDiscriminantCalculation.Name = "LblDiscriminantCalculation";
            this.LblDiscriminantCalculation.Size = new System.Drawing.Size(82, 19);
            this.LblDiscriminantCalculation.TabIndex = 4;
            this.LblDiscriminantCalculation.Text = "Δ = b²-4ac";
            // 
            // CalculationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 423);
            this.Controls.Add(this.LblDiscriminantCalculation);
            this.Controls.Add(this.LblX1Calculation);
            this.Controls.Add(this.LblDiscriminant);
            this.Controls.Add(this.LblX2Calculation);
            this.Controls.Add(this.LblX);
            this.Font = new System.Drawing.Font("Bahnschrift", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CalculationsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The calculations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblX;
        private System.Windows.Forms.Label LblX2Calculation;
        private System.Windows.Forms.Label LblDiscriminant;
        private System.Windows.Forms.Label LblX1Calculation;
        private System.Windows.Forms.Label LblDiscriminantCalculation;
    }
}
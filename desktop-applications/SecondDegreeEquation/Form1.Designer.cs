namespace SecondDegreeEquation
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtA = new System.Windows.Forms.TextBox();
            this.nudValueOfA = new System.Windows.Forms.NumericUpDown();
            this.nudValueOfB = new System.Windows.Forms.NumericUpDown();
            this.txtB = new System.Windows.Forms.TextBox();
            this.nudValueOfC = new System.Windows.Forms.NumericUpDown();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtTheTypeIs = new System.Windows.Forms.TextBox();
            this.txtTheType = new System.Windows.Forms.TextBox();
            this.txtTheDiscriminant = new System.Windows.Forms.TextBox();
            this.txtTheDiscriminantIs = new System.Windows.Forms.TextBox();
            this.txtTheEquation = new System.Windows.Forms.TextBox();
            this.txtTheEquationDescribedWas = new System.Windows.Forms.TextBox();
            this.lblIntroduceTheValues = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtValueOfX1 = new System.Windows.Forms.TextBox();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.txtValueOfX2 = new System.Windows.Forms.TextBox();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.txtValueOfX = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtResultDescription = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudValueOfA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValueOfB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValueOfC)).BeginInit();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.Enabled = false;
            this.txtA.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.Location = new System.Drawing.Point(46, 68);
            this.txtA.Margin = new System.Windows.Forms.Padding(4);
            this.txtA.Name = "txtA";
            this.txtA.ReadOnly = true;
            this.txtA.Size = new System.Drawing.Size(76, 27);
            this.txtA.TabIndex = 0;
            this.txtA.TabStop = false;
            this.txtA.Text = "A =";
            this.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudValueOfA
            // 
            this.nudValueOfA.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudValueOfA.Location = new System.Drawing.Point(122, 68);
            this.nudValueOfA.Margin = new System.Windows.Forms.Padding(4);
            this.nudValueOfA.Name = "nudValueOfA";
            this.nudValueOfA.Size = new System.Drawing.Size(84, 27);
            this.nudValueOfA.TabIndex = 1;
            // 
            // nudValueOfB
            // 
            this.nudValueOfB.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudValueOfB.Location = new System.Drawing.Point(122, 116);
            this.nudValueOfB.Margin = new System.Windows.Forms.Padding(4);
            this.nudValueOfB.Name = "nudValueOfB";
            this.nudValueOfB.Size = new System.Drawing.Size(84, 27);
            this.nudValueOfB.TabIndex = 3;
            // 
            // txtB
            // 
            this.txtB.Enabled = false;
            this.txtB.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.Location = new System.Drawing.Point(46, 116);
            this.txtB.Margin = new System.Windows.Forms.Padding(4);
            this.txtB.Name = "txtB";
            this.txtB.ReadOnly = true;
            this.txtB.Size = new System.Drawing.Size(76, 27);
            this.txtB.TabIndex = 2;
            this.txtB.TabStop = false;
            this.txtB.Text = "B =";
            this.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudValueOfC
            // 
            this.nudValueOfC.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudValueOfC.Location = new System.Drawing.Point(122, 165);
            this.nudValueOfC.Margin = new System.Windows.Forms.Padding(4);
            this.nudValueOfC.Name = "nudValueOfC";
            this.nudValueOfC.Size = new System.Drawing.Size(84, 27);
            this.nudValueOfC.TabIndex = 5;
            // 
            // txtC
            // 
            this.txtC.Enabled = false;
            this.txtC.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC.Location = new System.Drawing.Point(46, 165);
            this.txtC.Margin = new System.Windows.Forms.Padding(4);
            this.txtC.Name = "txtC";
            this.txtC.ReadOnly = true;
            this.txtC.Size = new System.Drawing.Size(76, 27);
            this.txtC.TabIndex = 4;
            this.txtC.TabStop = false;
            this.txtC.Text = "C =";
            this.txtC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTheTypeIs
            // 
            this.txtTheTypeIs.Enabled = false;
            this.txtTheTypeIs.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTheTypeIs.Location = new System.Drawing.Point(254, 116);
            this.txtTheTypeIs.Margin = new System.Windows.Forms.Padding(4);
            this.txtTheTypeIs.Name = "txtTheTypeIs";
            this.txtTheTypeIs.ReadOnly = true;
            this.txtTheTypeIs.Size = new System.Drawing.Size(226, 27);
            this.txtTheTypeIs.TabIndex = 6;
            this.txtTheTypeIs.TabStop = false;
            this.txtTheTypeIs.Text = "The type is:";
            this.txtTheTypeIs.Visible = false;
            // 
            // txtTheType
            // 
            this.txtTheType.Enabled = false;
            this.txtTheType.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTheType.Location = new System.Drawing.Point(478, 116);
            this.txtTheType.Margin = new System.Windows.Forms.Padding(4);
            this.txtTheType.Name = "txtTheType";
            this.txtTheType.ReadOnly = true;
            this.txtTheType.Size = new System.Drawing.Size(219, 27);
            this.txtTheType.TabIndex = 7;
            this.txtTheType.TabStop = false;
            this.txtTheType.Text = "ax² + bx + c = 0";
            this.txtTheType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTheType.Visible = false;
            // 
            // txtTheDiscriminant
            // 
            this.txtTheDiscriminant.Enabled = false;
            this.txtTheDiscriminant.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTheDiscriminant.Location = new System.Drawing.Point(478, 164);
            this.txtTheDiscriminant.Margin = new System.Windows.Forms.Padding(4);
            this.txtTheDiscriminant.Name = "txtTheDiscriminant";
            this.txtTheDiscriminant.ReadOnly = true;
            this.txtTheDiscriminant.Size = new System.Drawing.Size(219, 27);
            this.txtTheDiscriminant.TabIndex = 9;
            this.txtTheDiscriminant.TabStop = false;
            this.txtTheDiscriminant.Text = "5";
            this.txtTheDiscriminant.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTheDiscriminant.Visible = false;
            // 
            // txtTheDiscriminantIs
            // 
            this.txtTheDiscriminantIs.Enabled = false;
            this.txtTheDiscriminantIs.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTheDiscriminantIs.Location = new System.Drawing.Point(254, 164);
            this.txtTheDiscriminantIs.Margin = new System.Windows.Forms.Padding(4);
            this.txtTheDiscriminantIs.Name = "txtTheDiscriminantIs";
            this.txtTheDiscriminantIs.ReadOnly = true;
            this.txtTheDiscriminantIs.Size = new System.Drawing.Size(226, 27);
            this.txtTheDiscriminantIs.TabIndex = 8;
            this.txtTheDiscriminantIs.TabStop = false;
            this.txtTheDiscriminantIs.Text = "The discriminant is:";
            this.txtTheDiscriminantIs.Visible = false;
            // 
            // txtTheEquation
            // 
            this.txtTheEquation.Enabled = false;
            this.txtTheEquation.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTheEquation.Location = new System.Drawing.Point(478, 67);
            this.txtTheEquation.Margin = new System.Windows.Forms.Padding(4);
            this.txtTheEquation.Name = "txtTheEquation";
            this.txtTheEquation.ReadOnly = true;
            this.txtTheEquation.Size = new System.Drawing.Size(219, 27);
            this.txtTheEquation.TabIndex = 11;
            this.txtTheEquation.TabStop = false;
            this.txtTheEquation.Text = "2x² + 4x + 1 = 0";
            this.txtTheEquation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTheEquation.Visible = false;
            // 
            // txtTheEquationDescribedWas
            // 
            this.txtTheEquationDescribedWas.Enabled = false;
            this.txtTheEquationDescribedWas.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTheEquationDescribedWas.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtTheEquationDescribedWas.Location = new System.Drawing.Point(254, 67);
            this.txtTheEquationDescribedWas.Margin = new System.Windows.Forms.Padding(4);
            this.txtTheEquationDescribedWas.Name = "txtTheEquationDescribedWas";
            this.txtTheEquationDescribedWas.ReadOnly = true;
            this.txtTheEquationDescribedWas.Size = new System.Drawing.Size(226, 27);
            this.txtTheEquationDescribedWas.TabIndex = 10;
            this.txtTheEquationDescribedWas.TabStop = false;
            this.txtTheEquationDescribedWas.Tag = "";
            this.txtTheEquationDescribedWas.Text = "The equation described was:";
            this.txtTheEquationDescribedWas.Visible = false;
            // 
            // lblIntroduceTheValues
            // 
            this.lblIntroduceTheValues.AutoSize = true;
            this.lblIntroduceTheValues.Location = new System.Drawing.Point(46, 28);
            this.lblIntroduceTheValues.Name = "lblIntroduceTheValues";
            this.lblIntroduceTheValues.Size = new System.Drawing.Size(161, 19);
            this.lblIntroduceTheValues.TabIndex = 12;
            this.lblIntroduceTheValues.Text = "Introduce the values:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(46, 214);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(652, 30);
            this.btnCalculate.TabIndex = 13;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // txtValueOfX1
            // 
            this.txtValueOfX1.Enabled = false;
            this.txtValueOfX1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValueOfX1.Location = new System.Drawing.Point(122, 317);
            this.txtValueOfX1.Margin = new System.Windows.Forms.Padding(4);
            this.txtValueOfX1.Name = "txtValueOfX1";
            this.txtValueOfX1.ReadOnly = true;
            this.txtValueOfX1.Size = new System.Drawing.Size(85, 27);
            this.txtValueOfX1.TabIndex = 15;
            this.txtValueOfX1.TabStop = false;
            this.txtValueOfX1.Text = "3";
            this.txtValueOfX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValueOfX1.Visible = false;
            // 
            // txtX1
            // 
            this.txtX1.Enabled = false;
            this.txtX1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtX1.Location = new System.Drawing.Point(46, 317);
            this.txtX1.Margin = new System.Windows.Forms.Padding(4);
            this.txtX1.Name = "txtX1";
            this.txtX1.ReadOnly = true;
            this.txtX1.Size = new System.Drawing.Size(76, 27);
            this.txtX1.TabIndex = 14;
            this.txtX1.TabStop = false;
            this.txtX1.Text = "x1 =";
            this.txtX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtX1.Visible = false;
            // 
            // txtValueOfX2
            // 
            this.txtValueOfX2.Enabled = false;
            this.txtValueOfX2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValueOfX2.Location = new System.Drawing.Point(613, 317);
            this.txtValueOfX2.Margin = new System.Windows.Forms.Padding(4);
            this.txtValueOfX2.Name = "txtValueOfX2";
            this.txtValueOfX2.ReadOnly = true;
            this.txtValueOfX2.Size = new System.Drawing.Size(85, 27);
            this.txtValueOfX2.TabIndex = 17;
            this.txtValueOfX2.TabStop = false;
            this.txtValueOfX2.Text = "3";
            this.txtValueOfX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValueOfX2.Visible = false;
            // 
            // txtX2
            // 
            this.txtX2.Enabled = false;
            this.txtX2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtX2.Location = new System.Drawing.Point(537, 317);
            this.txtX2.Margin = new System.Windows.Forms.Padding(4);
            this.txtX2.Name = "txtX2";
            this.txtX2.ReadOnly = true;
            this.txtX2.Size = new System.Drawing.Size(76, 27);
            this.txtX2.TabIndex = 16;
            this.txtX2.TabStop = false;
            this.txtX2.Text = "x2 =";
            this.txtX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtX2.Visible = false;
            // 
            // txtValueOfX
            // 
            this.txtValueOfX.Enabled = false;
            this.txtValueOfX.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValueOfX.Location = new System.Drawing.Point(368, 317);
            this.txtValueOfX.Margin = new System.Windows.Forms.Padding(4);
            this.txtValueOfX.Name = "txtValueOfX";
            this.txtValueOfX.ReadOnly = true;
            this.txtValueOfX.Size = new System.Drawing.Size(85, 27);
            this.txtValueOfX.TabIndex = 19;
            this.txtValueOfX.TabStop = false;
            this.txtValueOfX.Text = "3";
            this.txtValueOfX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValueOfX.Visible = false;
            // 
            // txtX
            // 
            this.txtX.Enabled = false;
            this.txtX.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtX.Location = new System.Drawing.Point(292, 317);
            this.txtX.Margin = new System.Windows.Forms.Padding(4);
            this.txtX.Name = "txtX";
            this.txtX.ReadOnly = true;
            this.txtX.Size = new System.Drawing.Size(76, 27);
            this.txtX.TabIndex = 18;
            this.txtX.TabStop = false;
            this.txtX.Text = "x =";
            this.txtX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtX.Visible = false;
            // 
            // txtResultDescription
            // 
            this.txtResultDescription.Enabled = false;
            this.txtResultDescription.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultDescription.Location = new System.Drawing.Point(46, 266);
            this.txtResultDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtResultDescription.Name = "txtResultDescription";
            this.txtResultDescription.ReadOnly = true;
            this.txtResultDescription.Size = new System.Drawing.Size(652, 27);
            this.txtResultDescription.TabIndex = 20;
            this.txtResultDescription.Text = "The discriminant is positive, so we have two x values:";
            this.txtResultDescription.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 383);
            this.Controls.Add(this.txtResultDescription);
            this.Controls.Add(this.txtValueOfX);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.txtValueOfX2);
            this.Controls.Add(this.txtX2);
            this.Controls.Add(this.txtValueOfX1);
            this.Controls.Add(this.txtX1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblIntroduceTheValues);
            this.Controls.Add(this.txtTheEquation);
            this.Controls.Add(this.txtTheEquationDescribedWas);
            this.Controls.Add(this.txtTheDiscriminant);
            this.Controls.Add(this.txtTheDiscriminantIs);
            this.Controls.Add(this.txtTheType);
            this.Controls.Add(this.txtTheTypeIs);
            this.Controls.Add(this.nudValueOfC);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.nudValueOfB);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.nudValueOfA);
            this.Controls.Add(this.txtA);
            this.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(764, 422);
            this.MinimumSize = new System.Drawing.Size(764, 422);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Second Degree Equation";
            ((System.ComponentModel.ISupportInitialize)(this.nudValueOfA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValueOfB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValueOfC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.NumericUpDown nudValueOfA;
        private System.Windows.Forms.NumericUpDown nudValueOfB;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.NumericUpDown nudValueOfC;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtTheTypeIs;
        private System.Windows.Forms.TextBox txtTheType;
        private System.Windows.Forms.TextBox txtTheDiscriminant;
        private System.Windows.Forms.TextBox txtTheDiscriminantIs;
        private System.Windows.Forms.TextBox txtTheEquation;
        private System.Windows.Forms.TextBox txtTheEquationDescribedWas;
        private System.Windows.Forms.Label lblIntroduceTheValues;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtValueOfX1;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.TextBox txtValueOfX2;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.TextBox txtValueOfX;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtResultDescription;
    }
}


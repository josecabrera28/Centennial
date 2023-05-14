namespace Lab_Fractions
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOperation = new System.Windows.Forms.Button();
            this.txtFirstTop = new System.Windows.Forms.TextBox();
            this.txtFirstBottom = new System.Windows.Forms.TextBox();
            this.txtSecondBottom = new System.Windows.Forms.TextBox();
            this.txtSecondTop = new System.Windows.Forms.TextBox();
            this.txtResBottom = new System.Windows.Forms.TextBox();
            this.txtResTop = new System.Windows.Forms.TextBox();
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.lblSlash1 = new System.Windows.Forms.Label();
            this.lblSlash3 = new System.Windows.Forms.Label();
            this.lblSlash2 = new System.Windows.Forms.Label();
            this.rbtnAdd = new System.Windows.Forms.RadioButton();
            this.rbtnDiv = new System.Windows.Forms.RadioButton();
            this.rbtnMult = new System.Windows.Forms.RadioButton();
            this.rbtnSubs = new System.Windows.Forms.RadioButton();
            this.lblEqual = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOperation
            // 
            this.btnOperation.Location = new System.Drawing.Point(25, 181);
            this.btnOperation.Name = "btnOperation";
            this.btnOperation.Size = new System.Drawing.Size(351, 23);
            this.btnOperation.TabIndex = 8;
            this.btnOperation.Text = "Perform Operation";
            this.btnOperation.UseVisualStyleBackColor = true;
            this.btnOperation.Click += new System.EventHandler(this.btn_click);
            // 
            // txtFirstTop
            // 
            this.txtFirstTop.Location = new System.Drawing.Point(25, 91);
            this.txtFirstTop.Name = "txtFirstTop";
            this.txtFirstTop.Size = new System.Drawing.Size(28, 20);
            this.txtFirstTop.TabIndex = 0;
            this.txtFirstTop.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtFirstTop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FirstT_KeyPress);
            // 
            // txtFirstBottom
            // 
            this.txtFirstBottom.Location = new System.Drawing.Point(77, 91);
            this.txtFirstBottom.Name = "txtFirstBottom";
            this.txtFirstBottom.Size = new System.Drawing.Size(28, 20);
            this.txtFirstBottom.TabIndex = 1;
            this.txtFirstBottom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FirstB_KeyPress);
            // 
            // txtSecondBottom
            // 
            this.txtSecondBottom.Location = new System.Drawing.Point(236, 91);
            this.txtSecondBottom.Name = "txtSecondBottom";
            this.txtSecondBottom.Size = new System.Drawing.Size(28, 20);
            this.txtSecondBottom.TabIndex = 7;
            this.txtSecondBottom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SecondB_KeyPress);
            // 
            // txtSecondTop
            // 
            this.txtSecondTop.Location = new System.Drawing.Point(184, 91);
            this.txtSecondTop.Name = "txtSecondTop";
            this.txtSecondTop.Size = new System.Drawing.Size(28, 20);
            this.txtSecondTop.TabIndex = 6;
            this.txtSecondTop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SecondT_KeyPress);
            // 
            // txtResBottom
            // 
            this.txtResBottom.Enabled = false;
            this.txtResBottom.Location = new System.Drawing.Point(348, 91);
            this.txtResBottom.Name = "txtResBottom";
            this.txtResBottom.Size = new System.Drawing.Size(28, 20);
            this.txtResBottom.TabIndex = 8;
            this.txtResBottom.TabStop = false;
            // 
            // txtResTop
            // 
            this.txtResTop.Enabled = false;
            this.txtResTop.Location = new System.Drawing.Point(296, 91);
            this.txtResTop.Name = "txtResTop";
            this.txtResTop.Size = new System.Drawing.Size(28, 20);
            this.txtResTop.TabIndex = 7;
            this.txtResTop.TabStop = false;
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(22, 54);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(26, 13);
            this.lblFirst.TabIndex = 9;
            this.lblFirst.Text = "First";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(293, 54);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 10;
            this.lblResult.Text = "Result";
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Location = new System.Drawing.Point(181, 54);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(44, 13);
            this.lblSecond.TabIndex = 11;
            this.lblSecond.Text = "Second";
            // 
            // lblSlash1
            // 
            this.lblSlash1.AutoSize = true;
            this.lblSlash1.Location = new System.Drawing.Point(59, 94);
            this.lblSlash1.Name = "lblSlash1";
            this.lblSlash1.Size = new System.Drawing.Size(12, 13);
            this.lblSlash1.TabIndex = 17;
            this.lblSlash1.Text = "/";
            // 
            // lblSlash3
            // 
            this.lblSlash3.AutoSize = true;
            this.lblSlash3.Location = new System.Drawing.Point(330, 94);
            this.lblSlash3.Name = "lblSlash3";
            this.lblSlash3.Size = new System.Drawing.Size(12, 13);
            this.lblSlash3.TabIndex = 18;
            this.lblSlash3.Text = "/";
            // 
            // lblSlash2
            // 
            this.lblSlash2.AutoSize = true;
            this.lblSlash2.Location = new System.Drawing.Point(218, 94);
            this.lblSlash2.Name = "lblSlash2";
            this.lblSlash2.Size = new System.Drawing.Size(12, 13);
            this.lblSlash2.TabIndex = 19;
            this.lblSlash2.Text = "/";
            // 
            // rbtnAdd
            // 
            this.rbtnAdd.AutoSize = true;
            this.rbtnAdd.Location = new System.Drawing.Point(133, 36);
            this.rbtnAdd.Name = "rbtnAdd";
            this.rbtnAdd.Size = new System.Drawing.Size(31, 17);
            this.rbtnAdd.TabIndex = 2;
            this.rbtnAdd.TabStop = true;
            this.rbtnAdd.Text = "+";
            this.rbtnAdd.UseVisualStyleBackColor = true;
            this.rbtnAdd.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rbtnDiv
            // 
            this.rbtnDiv.AutoSize = true;
            this.rbtnDiv.Location = new System.Drawing.Point(133, 142);
            this.rbtnDiv.Name = "rbtnDiv";
            this.rbtnDiv.Size = new System.Drawing.Size(30, 17);
            this.rbtnDiv.TabIndex = 5;
            this.rbtnDiv.TabStop = true;
            this.rbtnDiv.Text = "/";
            this.rbtnDiv.UseVisualStyleBackColor = true;
            this.rbtnDiv.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rbtnMult
            // 
            this.rbtnMult.AutoSize = true;
            this.rbtnMult.Location = new System.Drawing.Point(133, 107);
            this.rbtnMult.Name = "rbtnMult";
            this.rbtnMult.Size = new System.Drawing.Size(29, 17);
            this.rbtnMult.TabIndex = 4;
            this.rbtnMult.TabStop = true;
            this.rbtnMult.Text = "*";
            this.rbtnMult.UseVisualStyleBackColor = true;
            this.rbtnMult.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rbtnSubs
            // 
            this.rbtnSubs.AutoSize = true;
            this.rbtnSubs.Location = new System.Drawing.Point(133, 73);
            this.rbtnSubs.Name = "rbtnSubs";
            this.rbtnSubs.Size = new System.Drawing.Size(28, 17);
            this.rbtnSubs.TabIndex = 3;
            this.rbtnSubs.TabStop = true;
            this.rbtnSubs.Text = "-";
            this.rbtnSubs.UseVisualStyleBackColor = true;
            this.rbtnSubs.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // lblEqual
            // 
            this.lblEqual.AutoSize = true;
            this.lblEqual.Location = new System.Drawing.Point(277, 94);
            this.lblEqual.Name = "lblEqual";
            this.lblEqual.Size = new System.Drawing.Size(13, 13);
            this.lblEqual.TabIndex = 27;
            this.lblEqual.Text = "=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(404, 231);
            this.Controls.Add(this.lblEqual);
            this.Controls.Add(this.rbtnSubs);
            this.Controls.Add(this.rbtnMult);
            this.Controls.Add(this.rbtnDiv);
            this.Controls.Add(this.rbtnAdd);
            this.Controls.Add(this.lblSlash2);
            this.Controls.Add(this.lblSlash3);
            this.Controls.Add(this.lblSlash1);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.txtResBottom);
            this.Controls.Add(this.txtResTop);
            this.Controls.Add(this.txtSecondBottom);
            this.Controls.Add(this.txtSecondTop);
            this.Controls.Add(this.txtFirstBottom);
            this.Controls.Add(this.txtFirstTop);
            this.Controls.Add(this.btnOperation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fractions";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOperation;
        private System.Windows.Forms.TextBox txtFirstTop;
        private System.Windows.Forms.TextBox txtFirstBottom;
        private System.Windows.Forms.TextBox txtSecondBottom;
        private System.Windows.Forms.TextBox txtSecondTop;
        private System.Windows.Forms.TextBox txtResBottom;
        private System.Windows.Forms.TextBox txtResTop;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Label lblSlash1;
        private System.Windows.Forms.Label lblSlash3;
        private System.Windows.Forms.Label lblSlash2;
        private System.Windows.Forms.RadioButton rbtnAdd;
        private System.Windows.Forms.RadioButton rbtnDiv;
        private System.Windows.Forms.RadioButton rbtnMult;
        private System.Windows.Forms.RadioButton rbtnSubs;
        private System.Windows.Forms.Label lblEqual;
    }
}


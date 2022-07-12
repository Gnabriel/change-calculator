namespace ChangeCalculatorWinForms
{
  partial class Form
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
      this.btnCalculate = new System.Windows.Forms.Button();
      this.lblCost = new System.Windows.Forms.Label();
      this.lblPaid = new System.Windows.Forms.Label();
      this.lblResult = new System.Windows.Forms.Label();
      this.costInput = new System.Windows.Forms.NumericUpDown();
      this.paidInput = new System.Windows.Forms.NumericUpDown();
      ((System.ComponentModel.ISupportInitialize)(this.costInput)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.paidInput)).BeginInit();
      this.SuspendLayout();
      // 
      // btnCalculate
      // 
      this.btnCalculate.Location = new System.Drawing.Point(149, 289);
      this.btnCalculate.Name = "btnCalculate";
      this.btnCalculate.Size = new System.Drawing.Size(112, 34);
      this.btnCalculate.TabIndex = 0;
      this.btnCalculate.Text = "Calculate";
      this.btnCalculate.UseVisualStyleBackColor = true;
      this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
      // 
      // lblCost
      // 
      this.lblCost.AutoSize = true;
      this.lblCost.Location = new System.Drawing.Point(149, 98);
      this.lblCost.Name = "lblCost";
      this.lblCost.Size = new System.Drawing.Size(48, 25);
      this.lblCost.TabIndex = 2;
      this.lblCost.Text = "Cost";
      this.lblCost.Click += new System.EventHandler(this.label1_Click);
      // 
      // lblPaid
      // 
      this.lblPaid.AutoSize = true;
      this.lblPaid.Location = new System.Drawing.Point(149, 187);
      this.lblPaid.Name = "lblPaid";
      this.lblPaid.Size = new System.Drawing.Size(117, 25);
      this.lblPaid.TabIndex = 3;
      this.lblPaid.Text = "Amount paid";
      // 
      // lblResult
      // 
      this.lblResult.AutoSize = true;
      this.lblResult.Location = new System.Drawing.Point(451, 98);
      this.lblResult.Name = "lblResult";
      this.lblResult.Size = new System.Drawing.Size(0, 25);
      this.lblResult.TabIndex = 5;
      // 
      // costInput
      // 
      this.costInput.Location = new System.Drawing.Point(149, 126);
      this.costInput.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
      this.costInput.Name = "costInput";
      this.costInput.Size = new System.Drawing.Size(180, 31);
      this.costInput.TabIndex = 6;
      // 
      // paidInput
      // 
      this.paidInput.Location = new System.Drawing.Point(149, 215);
      this.paidInput.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
      this.paidInput.Name = "paidInput";
      this.paidInput.Size = new System.Drawing.Size(180, 31);
      this.paidInput.TabIndex = 7;
      // 
      // Form
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.paidInput);
      this.Controls.Add(this.costInput);
      this.Controls.Add(this.lblResult);
      this.Controls.Add(this.lblPaid);
      this.Controls.Add(this.lblCost);
      this.Controls.Add(this.btnCalculate);
      this.Name = "Form";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.costInput)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.paidInput)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Button btnCalculate;
    private Label lblCost;
    private Label lblPaid;
    private Label lblResult;
    private NumericUpDown costInput;
    private NumericUpDown paidInput;
  }
}
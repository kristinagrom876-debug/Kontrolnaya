using System;

namespace Kontrolnaya {
  partial class Form1 {
    private System.ComponentModel.IContainer components = null;

    private System.Windows.Forms.MenuStrip menuStrip;
    private System.Windows.Forms.ToolStripMenuItem menuItemCalculate;
    private System.Windows.Forms.ToolStripMenuItem menuItemClear;
    private System.Windows.Forms.ToolStripMenuItem menuItemExit;

    private System.Windows.Forms.Label labelA;
    private System.Windows.Forms.Label labelB;
    private System.Windows.Forms.Label labelС;
    private System.Windows.Forms.Label labelFormula;
    private System.Windows.Forms.Label labelAnswerTitle;

    private System.Windows.Forms.Label labelMethod;
    private System.Windows.Forms.ComboBox comboBoxMethod;

    private System.Windows.Forms.TextBox textBoxA;
    private System.Windows.Forms.TextBox textBoxB;
    private System.Windows.Forms.TextBox textBoxС;
    private System.Windows.Forms.TextBox textBoxFormula;
    private System.Windows.Forms.TextBox textBoxAnswer;

    private System.Windows.Forms.PictureBox pictureBoxPlot;
    private System.Windows.Forms.StatusStrip statusStrip;
    private System.Windows.Forms.ToolStripStatusLabel statusLabel;

    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    private void InitializeComponent() {
      this.menuStrip = new System.Windows.Forms.MenuStrip();
      this.menuItemCalculate = new System.Windows.Forms.ToolStripMenuItem();
      this.menuItemClear = new System.Windows.Forms.ToolStripMenuItem();
      this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
      this.labelA = new System.Windows.Forms.Label();
      this.labelB = new System.Windows.Forms.Label();
      this.labelС = new System.Windows.Forms.Label();
      this.labelFormula = new System.Windows.Forms.Label();
      this.labelAnswerTitle = new System.Windows.Forms.Label();
      this.labelMethod = new System.Windows.Forms.Label();
      this.comboBoxMethod = new System.Windows.Forms.ComboBox();
      this.textBoxA = new System.Windows.Forms.TextBox();
      this.textBoxB = new System.Windows.Forms.TextBox();
      this.textBoxС = new System.Windows.Forms.TextBox();
      this.textBoxFormula = new System.Windows.Forms.TextBox();
      this.textBoxAnswer = new System.Windows.Forms.TextBox();
      this.pictureBoxPlot = new System.Windows.Forms.PictureBox();
      this.statusStrip = new System.Windows.Forms.StatusStrip();
      this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.menuStrip.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlot)).BeginInit();
      this.statusStrip.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip
      // 
      this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemCalculate,
            this.menuItemClear,
            this.menuItemExit});
      this.menuStrip.Location = new System.Drawing.Point(0, 0);
      this.menuStrip.Name = "menuStrip";
      this.menuStrip.Size = new System.Drawing.Size(1187, 28);
      this.menuStrip.TabIndex = 0;
      // 
      // menuItemCalculate
      // 
      this.menuItemCalculate.Name = "menuItemCalculate";
      this.menuItemCalculate.Size = new System.Drawing.Size(98, 24);
      this.menuItemCalculate.Text = "Рассчитать";
      this.menuItemCalculate.Click += new System.EventHandler(this.menuItemCalculate_Click);
      // 
      // menuItemClear
      // 
      this.menuItemClear.Name = "menuItemClear";
      this.menuItemClear.Size = new System.Drawing.Size(87, 24);
      this.menuItemClear.Text = "Очистить";
      this.menuItemClear.Click += new System.EventHandler(this.MenuItemClear_Click);
      // 
      // menuItemExit
      // 
      this.menuItemExit.Name = "menuItemExit";
      this.menuItemExit.Size = new System.Drawing.Size(67, 24);
      this.menuItemExit.Text = "Выход";
      this.menuItemExit.Click += new System.EventHandler(this.MenuItemExit_Click);
      // 
      // labelA
      // 
      this.labelA.AutoSize = true;
      this.labelA.Location = new System.Drawing.Point(20, 49);
      this.labelA.Name = "labelA";
      this.labelA.Size = new System.Drawing.Size(18, 16);
      this.labelA.TabIndex = 1;
      this.labelA.Text = "a:";
      // 
      // labelB
      // 
      this.labelB.AutoSize = true;
      this.labelB.Location = new System.Drawing.Point(220, 49);
      this.labelB.Name = "labelB";
      this.labelB.Size = new System.Drawing.Size(18, 16);
      this.labelB.TabIndex = 3;
      this.labelB.Text = "b:";
      // 
      // labelС
      // 
      this.labelС.AutoSize = true;
      this.labelС.Location = new System.Drawing.Point(420, 49);
      this.labelС.Name = "labelС";
      this.labelС.Size = new System.Drawing.Size(17, 16);
      this.labelС.TabIndex = 5;
      this.labelС.Text = "c:";
      // 
      // labelFormula
      // 
      this.labelFormula.AutoSize = true;
      this.labelFormula.Location = new System.Drawing.Point(20, 92);
      this.labelFormula.Name = "labelFormula";
      this.labelFormula.Size = new System.Drawing.Size(34, 16);
      this.labelFormula.TabIndex = 9;
      this.labelFormula.Text = "f(x) =";
      // 
      // labelAnswerTitle
      // 
      this.labelAnswerTitle.AutoSize = true;
      this.labelAnswerTitle.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
      this.labelAnswerTitle.ForeColor = System.Drawing.Color.Purple;
      this.labelAnswerTitle.Location = new System.Drawing.Point(623, 48);
      this.labelAnswerTitle.Name = "labelAnswerTitle";
      this.labelAnswerTitle.Size = new System.Drawing.Size(54, 18);
      this.labelAnswerTitle.TabIndex = 7;
      this.labelAnswerTitle.Text = "Ответ:";
      this.labelAnswerTitle.Click += new System.EventHandler(this.labelAnswerTitle_Click);
      // 
      // labelMethod
      // 
      this.labelMethod.AutoSize = true;
      this.labelMethod.Location = new System.Drawing.Point(20, 131);
      this.labelMethod.Name = "labelMethod";
      this.labelMethod.Size = new System.Drawing.Size(111, 16);
      this.labelMethod.TabIndex = 11;
      this.labelMethod.Text = "Метод решения:";
      // 
      // comboBoxMethod
      // 
      this.comboBoxMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBoxMethod.FormattingEnabled = true;
      this.comboBoxMethod.Items.AddRange(new object[] {
            "Дискриминант",
            "Теорема Виета"});
      this.comboBoxMethod.Location = new System.Drawing.Point(137, 128);
      this.comboBoxMethod.Name = "comboBoxMethod";
      this.comboBoxMethod.Size = new System.Drawing.Size(150, 24);
      this.comboBoxMethod.TabIndex = 10;
      // 
      // textBoxA
      // 
      this.textBoxA.Location = new System.Drawing.Point(46, 47);
      this.textBoxA.Name = "textBoxA";
      this.textBoxA.Size = new System.Drawing.Size(132, 22);
      this.textBoxA.TabIndex = 2;
      this.textBoxA.Text = "0";
      // 
      // textBoxB
      // 
      this.textBoxB.Location = new System.Drawing.Point(260, 46);
      this.textBoxB.Name = "textBoxB";
      this.textBoxB.Size = new System.Drawing.Size(132, 22);
      this.textBoxB.TabIndex = 4;
      this.textBoxB.Text = "3";
      // 
      // textBoxС
      // 
      this.textBoxС.Location = new System.Drawing.Point(460, 46);
      this.textBoxС.Name = "textBoxС";
      this.textBoxС.Size = new System.Drawing.Size(132, 22);
      this.textBoxС.TabIndex = 6;
      this.textBoxС.Text = "0,0001";
      // 
      // textBoxFormula
      // 
      this.textBoxFormula.Location = new System.Drawing.Point(62, 89);
      this.textBoxFormula.Name = "textBoxFormula";
      this.textBoxFormula.Size = new System.Drawing.Size(480, 22);
      this.textBoxFormula.TabIndex = 10;
      this.textBoxFormula.Text = "x^2+2*x-6";
      // 
      // textBoxAnswer
      // 
      this.textBoxAnswer.BackColor = System.Drawing.Color.LightYellow;
      this.textBoxAnswer.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
      this.textBoxAnswer.ForeColor = System.Drawing.Color.DarkRed;
      this.textBoxAnswer.Location = new System.Drawing.Point(683, 34);
      this.textBoxAnswer.Multiline = true;
      this.textBoxAnswer.Name = "textBoxAnswer";
      this.textBoxAnswer.ReadOnly = true;
      this.textBoxAnswer.Size = new System.Drawing.Size(287, 118);
      this.textBoxAnswer.TabIndex = 8;
      this.textBoxAnswer.TabStop = false;
      // 
      // pictureBoxPlot
      // 
      this.pictureBoxPlot.BackColor = System.Drawing.Color.White;
      this.pictureBoxPlot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pictureBoxPlot.Location = new System.Drawing.Point(0, 185);
      this.pictureBoxPlot.Name = "pictureBoxPlot";
      this.pictureBoxPlot.Size = new System.Drawing.Size(1114, 432);
      this.pictureBoxPlot.TabIndex = 12;
      this.pictureBoxPlot.TabStop = false;
      // 
      // statusStrip
      // 
      this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
      this.statusStrip.Location = new System.Drawing.Point(0, 651);
      this.statusStrip.Name = "statusStrip";
      this.statusStrip.Size = new System.Drawing.Size(1187, 26);
      this.statusStrip.TabIndex = 13;
      // 
      // statusLabel
      // 
      this.statusLabel.Name = "statusLabel";
      this.statusLabel.Size = new System.Drawing.Size(57, 20);
      this.statusLabel.Text = "Готово";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1187, 677);
      this.Controls.Add(this.menuStrip);
      this.Controls.Add(this.labelA);
      this.Controls.Add(this.textBoxA);
      this.Controls.Add(this.labelB);
      this.Controls.Add(this.textBoxB);
      this.Controls.Add(this.labelС);
      this.Controls.Add(this.textBoxС);
      this.Controls.Add(this.labelAnswerTitle);
      this.Controls.Add(this.textBoxAnswer);
      this.Controls.Add(this.labelFormula);
      this.Controls.Add(this.textBoxFormula);
      this.Controls.Add(this.labelMethod);
      this.Controls.Add(this.comboBoxMethod);
      this.Controls.Add(this.pictureBoxPlot);
      this.Controls.Add(this.statusStrip);
      this.MainMenuStrip = this.menuStrip;
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Контрольная работа. Виета и Дискриминант";
      this.menuStrip.ResumeLayout(false);
      this.menuStrip.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlot)).EndInit();
      this.statusStrip.ResumeLayout(false);
      this.statusStrip.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }
  }
}
using System;
using System.Windows.Forms;

namespace Kontrolnaya {
  public partial class Form1 : Form {
    private MathSolver solver = new MathSolver();

    public Form1() {
      InitializeComponent();
      comboBoxMethod.SelectedIndex = 0;
    }

    private void menuItemCalculate_Click(object sender, EventArgs e) {
      try {
        double a = double.Parse(textBoxA.Text);
        double b = double.Parse(textBoxB.Text);
        double c = double.Parse(textBoxС.Text);

        if (comboBoxMethod.SelectedIndex == 0) {
          textBoxAnswer.Text = solver.SolveDiscriminant(a, b, c);
        } else if (comboBoxMethod.SelectedIndex == 1) {
          textBoxAnswer.Text = solver.SolveVieta(a, b, c);
        }
      } catch (Exception) {
        MessageBox.Show("Ошибка ввода! Введите корректные числа.", "Ошибка");
      }
    }

    private void MenuItemClear_Click(object sender, EventArgs e) {
      textBoxA.Text = "0";
      textBoxB.Text = "0";
      textBoxС.Text = "0";
      textBoxAnswer.Text = "";
    }

    private void MenuItemExit_Click(object sender, EventArgs e) {
      Close();
    }

    private void labelAnswerTitle_Click(object sender, EventArgs e) {

    }
  }
}
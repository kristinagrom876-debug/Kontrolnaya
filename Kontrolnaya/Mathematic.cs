using System;

namespace Kontrolnaya {
  public class MathSolver {
    public string SolveDiscriminant(double a, double b, double c) {
      if (a == 0)
        return "Ошибка: коэффициент 'a' не может быть равен 0.";

      double d = b * b - 4 * a * c;

      d = Math.Round(d, 3);
      string result = "Метод Дискриминанта:\r\nD = " + d + "\r\n";

      if (d > 0) {
        double x1 = (-b + Math.Sqrt(d)) / (2 * a);
        double x2 = (-b - Math.Sqrt(d)) / (2 * a);

        x1 = Math.Round(x1, 3);
        x2 = Math.Round(x2, 3);
        result += "Два корня:\r\nx1 = " + x1 + "\r\nx2 = " + x2;
      } else if (d == 0) {
        double x = -b / (2 * a);
        x = Math.Round(x, 3);
        result += "Один корень:\r\nx = " + x;
      } else {
        result += "Корней нет (D < 0)";
      }
      return result;
    }

    public string SolveVieta(double a, double b, double c) {
      if (a == 0)
        return "Ошибка: коэффициент 'a' не может быть равен 0.";

      double sum = -b / a;
      double product = c / a;

      sum = Math.Round(sum, 3);
      product = Math.Round(product, 3);

      string result = "Метод Виета:\r\nСумма: " + sum + "\r\nПроизведение: " + product + "\r\n\r\n";

      double d = b * b - 4 * a * c;
      if (d >= 0) {
        double x1 = (sum + Math.Sqrt(d)) / 2;
        double x2 = (sum - Math.Sqrt(d)) / 2;

        x1 = Math.Round(x1, 3);
        x2 = Math.Round(x2, 3);
        result += "Корни:\r\nx1 = " + x1 + "\r\nx2 = " + x2;
      } else {
        result += "Корней нет (D < 0)";
      }
      return result;
    }
  }
}
// Задача: 
// Написать программу умножения двух многочленов
int[] Multi(int[] f, int[] g)
{
    int[] result = new int[f.Length + g.Length - 1];
    for (int i = 0; i < f.Length; i++)
    for (int j = 0; j < g.Length; j++)
    result[i + j] +=  f[i] * g[j];
    return result;
}
string Print(int[] f)
{
  Console.OutputEncoding = System.Text.Encoding.UTF8;
  string[] pows = { "⁰", "¹", "²", "³", "⁴", "⁵", "⁶", "⁷", "⁸", "⁹" };
  string output = String.Empty;
  for (int i = 0; i < f.Length; i++)
  {

    int t = f[i];
    if (f[i] == 0) continue;
    if (f[i] < 0) { output += " - "; }
    else if (i != 0) { output += " + "; }

    if (t < 0) t = -t;
    if (i == 1) { output += $"{t}x"; }
    if (i == 0) { output += $"{t}"; }
    if (i != 1 && i != 0 && f[i] != 0) { output += $"{t}x{pows[i]}"; }
    // if (flag && f[i] != 0 && i < f.Length - 1) output += " + ";
  }

  return output;
}

int[] f = { 1, 0, 0, 0, -9, -6 };
int[] g = { 1, 1, -2, -5, 0, 0 };
Console.WriteLine(Print(f));
Console.WriteLine(Print(g));
int[] m = Multi(f, g);
Console.WriteLine(Print(m));

System.Console.WriteLine();
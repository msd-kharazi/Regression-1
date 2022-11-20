using System.ComponentModel;
using System.Linq;

namespace Regression._1.WinForms
{
    public partial class frmMain : Form
    {

        #region [Properties]

        private BindingList<KeyValuePair<decimal, decimal>> inputData2;
        private const string Sigma = "\u03A3";
        private const string Xbar = "X\u0304";
        private const string Ybar = "Y\u0304";
        private const string SquareRoot = "\u221A";

        #endregion


        public frmMain()
        {
            InitializeComponent();
            inputData = new BindingList<KeyValuePair<decimal, decimal>>()
                
                //Exercise data
                {
                    new KeyValuePair<decimal, decimal>(1,6),
                    new KeyValuePair<decimal, decimal>(2,4.75M),
                    new KeyValuePair<decimal, decimal>(3,7),
                    new KeyValuePair<decimal, decimal>(4,8.5M),
                    new KeyValuePair<decimal, decimal>(5,12) 
                }
                
                ;
            dgInputData.DataSource = inputData;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtX.Text, out var inputX))
            {
                MessageBox.Show("Please input a valid decimal value for X.");
                return;
            }

            if (!decimal.TryParse(txtY.Text, out var inputY))
            {
                MessageBox.Show("Please input a valid decimal value for Y.");
                return;
            }

            if (inputData.Any(x => x.Key == inputX && x.Value == inputY))
            {
                MessageBox.Show("This row exists!");
                return;
            }

            inputData.Add(new KeyValuePair<decimal, decimal>(inputX,inputY));
            dgInputData.Refresh();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            inputData.Clear();
            txtX.Clear();
            txtY.Clear();
            dgInputData.ResetBindings();
        }

        private void btnLinear_Click(object sender, EventArgs e)
        {
            var xSum = inputData.Sum(x => x.Key);
            var x2Sum = inputData.Sum(x => x.Key*x.Key);
            var ySum = inputData.Sum(x => x.Value);
            var xAvg = inputData.Average(x => x.Key);
            var yAvg = inputData.Average(x => x.Value);
            var sigmaXY = inputData.Sum(x => x.Key * x.Value);
            var n = inputData.Count;
            var b = ((n * sigmaXY) - (xSum * ySum)) / ((n * x2Sum) - (xSum * xSum));
            var a = yAvg - (b * xAvg);
            var st = inputData.Sum(x => (x.Value - yAvg) * (x.Value - yAvg));
            var error = inputData.Select(x=>x.Value -  a - b*x.Key).ToList();
            var error2 = error.Select(x=>x*x).ToList();
            var error2Sum = error2.Sum();
            var r2 = (st - error2Sum) / st;
            var r = Math.Sqrt((double)r2);
            var sy = Math.Sqrt((double)st / (n - 1.0));

        var lines = new List<string>();
            lines.Add("Y = a + bX + e");
            lines.Add("==============================================");
            lines.Add($"n = {n}");
            lines.Add($"{Sigma}X = {xSum}");
            lines.Add($"{Xbar} = {xAvg}");
            lines.Add($"{Sigma}Y = {ySum}");
            lines.Add($"{Ybar} = {yAvg}");
            lines.Add($"{Sigma}(X^2) = {x2Sum}");
            lines.Add($"{Sigma}XY = {sigmaXY}");

            lines.Add(null);
            lines.Add($"b = (n * {Sigma}XY - {Sigma}X{Sigma}Y) / ( n * ( {Sigma}(X^2) ) - (({Sigma}X)^2) )");
            lines.Add($"b = ( ({n}*{sigmaXY}) - ({xSum}*{ySum}) ) / ( ( {n} * {x2Sum} ) - ({xSum}^2) ) = {b}");
            lines.Add(null);
            lines.Add($"a = {Ybar} - b{Xbar} = {yAvg} - ({b} * {xAvg}) = {a}");
            lines.Add(null);
            lines.Add($"Y = {a} + {b}X + e");
            
            lines.Add(null);
            lines.Add($"e = Y - a - bX, {{{string.Join(",", error)}}}");
            lines.Add($"e^2 = {{{string.Join(",", error2)}}}");
            lines.Add($"Sr = {Sigma}(e^2) = {error2Sum}");

            lines.Add(null); 
            lines.Add($"St = {Sigma}((Y-{Ybar})^2) = {string.Join(" + ",inputData.Select(x=>$"(({x.Value} - {yAvg})^2)"))}");
            lines.Add($"St = {string.Join(" + ",inputData.Select(x=>$"{(x.Value - yAvg) * (x.Value - yAvg)}"))} = {st}");

            lines.Add(null);
            lines.Add($"Sy = {SquareRoot}(St/(n-1)) = {SquareRoot}({st}/{n - 1}) = {sy}");

            lines.Add(null); 
            lines.Add($"r^2 = (St-Sr)/St = ({st} - {error2Sum})/{st} = {r2}");
            lines.Add($"r = {SquareRoot}r^2 = {r}");




            rtResult.Clear();
            rtResult.Lines = lines.ToArray();
        }

        private void btnPower_Click(object sender, EventArgs e)
        {

            var convertedInput = inputData2.Select(x =>
                new KeyValuePair<double, double>(Math.Log10((double) x.Key), Math.Log10((double) x.Value))).ToList();






            var xSum = convertedInput.Sum(x => x.Key);
            var x2Sum = convertedInput.Sum(x => x.Key * x.Key);
            var ySum = convertedInput.Sum(x => x.Value);
            var xAvg = convertedInput.Average(x => x.Key);
            var yAvg = convertedInput.Average(x => x.Value);
            var sigmaXY = convertedInput.Sum(x => x.Key * x.Value);
            var n = convertedInput.Count;
            var b = ((n * sigmaXY) - (xSum * ySum)) / ((n * x2Sum) - (xSum * xSum));
            var a = yAvg - (b * xAvg);
            var st = convertedInput.Sum(x => (x.Value - yAvg) * (x.Value - yAvg));
            var error = convertedInput.Select(x => x.Value - a - b * x.Key).ToList();
            var error2 = error.Select(x => x * x).ToList();
            var error2Sum = error2.Sum();
            var r2 = (st - error2Sum) / st;
            var r = Math.Sqrt((double)r2);
            var sy = Math.Sqrt((double)st / (n - 1.0));

            var lines = new List<string>();
            lines.Add("Y = a(X^b)");
            lines.Add("log(Y) = log(a(X^b))");
            lines.Add("log(Y) = log(a) + log(X^b)");
            lines.Add("log(Y) = log(a) + b * log(X)");
            lines.Add("Y* = log(Y)");
            lines.Add("a* = log(a)");
            lines.Add("X* = log(X)");
            lines.Add("==============================================");
            lines.Add($"n = {n}");
            lines.Add($"{Sigma}X* = {xSum}");
            lines.Add($"{Xbar} = {xAvg}");
            lines.Add($"{Sigma}Y* = {ySum}");
            lines.Add($"{Ybar} = {yAvg}");
            lines.Add($"{Sigma}(X*^2) = {x2Sum}");
            lines.Add($"{Sigma}X*Y* = {sigmaXY}");


            lines.Add(null);
            lines.Add($"b = (n * {Sigma}X*Y* - {Sigma}X*{Sigma}Y*) / ( n * ( {Sigma}(X*^2) ) - (({Sigma}X*)^2) )");
            lines.Add($"b = ( ({n}*{sigmaXY}) - ({xSum}*{ySum}) ) / ( ( {n} * {x2Sum} ) - ({xSum}^2) ) = {b}");
            lines.Add(null);
            lines.Add($"a = {Ybar} - b{Xbar} = {yAvg} - ({b} * {xAvg}) = {a}");
            lines.Add(null);
            lines.Add($"Y* = {a} + {b}X* + e");
            lines.Add($"log(Y) = {a} + {b}log(X)");
            lines.Add($"log(Y) = {a} + {b}log(X)");






            lines.Add(null);
            lines.Add($"e = Y* - a - bX*, {{{string.Join(",", error)}}}");
            lines.Add($"e^2 = {{{string.Join(",", error2)}}}");
            lines.Add($"Sr = {Sigma}(e^2) = {error2Sum}");

            lines.Add(null);
            lines.Add($"St = {Sigma}((Y-{Ybar})^2) = {string.Join(" + ", convertedInput.Select(x => $"(({x.Value} - {yAvg})^2)"))}");
            lines.Add($"St = {string.Join(" + ", convertedInput.Select(x => $"{(x.Value - yAvg) * (x.Value - yAvg)}"))} = {st}");

            lines.Add(null);
            lines.Add($"Sy = {SquareRoot}(St/(n-1)) = {SquareRoot}({st}/{n - 1}) = {sy}");

            lines.Add(null);
            lines.Add($"r^2 = (St-Sr)/St = ({st} - {error2Sum})/{st} = {r2}");
            lines.Add($"r = {SquareRoot}r^2 = {r}");




            rtResult.Clear();
            rtResult.Lines = lines.ToArray();
        }
    }
}
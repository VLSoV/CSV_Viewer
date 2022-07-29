using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Test_IBA_AG
{
    /// <summary>
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class UserControlLegend : UserControl
    {
        public UserControlLegend()
        {
            InitializeComponent();
            Clear();
        }

        public void AddLine(string line, System.Drawing.Color color)
        {
            stackPanel1.Children.Add(new TextBlock()
            {
                Text = line,
                Foreground = new SolidColorBrush(Color.FromArgb(color.A, color.R, color.G, color.B)),
                FontWeight = FontWeights.Bold
            });
        }

        public void SetColor(System.Drawing.Color color)
        {

        }

        public void Clear()
        {
            stackPanel1.Children.Clear();
        }
    }
}

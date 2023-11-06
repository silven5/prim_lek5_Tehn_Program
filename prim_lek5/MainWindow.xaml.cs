using prim_lek5.Class;
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

namespace prim_lek5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        string calculate (ISeries ob,int n,int x1,int x2)
        {
            var s = "";
            ob?.SetStart(x1,x2);//if (ob!=null)
            for (int i = 0; i < n; i++)
            {  s += ob?.GetNext() + " ";  } //if (ob!=null
            return s;

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var arif = new Arif();
            var geom=new Geom();
            var fib=new Fib();
            var lion = new Leon();
           
            try
            {
                arif_rez.Content = calculate(arif,
                    Convert.ToInt32(n_arif.Text),
                    Convert.ToInt32(a1.Text),
                    Convert.ToInt32(d.Text)
                    );

                geom_rez.Content = calculate(geom,
                    Convert.ToInt32(n_geom.Text),
                    Convert.ToInt32(b1.Text),
                    Convert.ToInt32(q.Text)
                    );
                fib_rez.Content = calculate(fib,
                   Convert.ToInt32(n_fib.Text), 0, 1);
                lion_rez.Content = calculate(lion,
                 Convert.ToInt32(n_lion.Text), 1, 1);
               
            }
            catch {
                new Exception("Error");
            }
        }
    }
}

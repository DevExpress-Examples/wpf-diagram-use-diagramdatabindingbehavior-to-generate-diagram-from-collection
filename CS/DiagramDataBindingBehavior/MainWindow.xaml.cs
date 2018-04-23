using DiagramDataBindingBehavior.Data;
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

namespace DiagramDataBindingBehavior
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

        private void DiagramDataBindingBehavior_GenerateItem(object sender, DevExpress.Xpf.Diagram.DiagramGenerateItemEventArgs e)
        {
            if (((ClassData)e.DataObject).Type == ClassType.Interface)
                e.Item = e.CreateItemFromTemplate("InterfaceShape");
            else e.Item = e.CreateItemFromTemplate("ClassShape");
        }

        private void DiagramDataBindingBehavior_GenerateConnector(object sender, DevExpress.Xpf.Diagram.DiagramGenerateConnectorEventArgs e)
        {
            if (((ClassData)e.From).Type == ClassType.Interface || ((ClassData)e.To).Type == ClassType.Interface)
                e.Connector = e.CreateConnectorFromTemplate("InterfaceConnector");
            else e.Connector = e.CreateConnectorFromTemplate("ClassConnector");
        }
    }
}

using Syncfusion.Data;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.XPS;
using System.Collections.Generic;
using Windows.Foundation;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Printing;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SfDataGridDemo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {          
            if (dataGrid != null)
            {
                dataGrid.PrintSettings.AllowPrintStyles = true;            
                dataGrid.PrintSettings.PrintManagerBase = new CustomPrintManager(dataGrid);
                dataGrid.PrintSettings.PrintManagerBase.Print();
            }
        }
    }

    public class CustomPrintManager : GridPrintManager
    {
        private double indentColumnWidth = 0;
        public SfDataGrid sfDatagrid;
        public CustomPrintManager(SfDataGrid grid)
            : base(grid)
        {
            sfDatagrid = grid;
            IndentColumnWidth = indentColumnWidth;
        }       
    }  
}

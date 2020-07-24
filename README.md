# How to set the IndentColumnWidth when print the UWP DataGrid (SfDataGrid)?

## About the sample
This example illustrates how to set the IndentColumnWidth when print the UWP DataGrid (SfDataGrid)?

SfDataGrid allows you to set IndentColumnWidth while printing. You can achieve this by set the IndentColumnWidth property by override the GridPrintManager in PrintManagerBase class.

```C#
private void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
{          
        if (dataGrid != null)
        {   
            dataGrid.PrintSettings.AllowPrintStyles = true;              
            dataGrid.PrintSettings.PrintManagerBase = new CustomPrintManager(dataGrid);
            dataGrid.PrintSettings.PrintManagerBase.Print();
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
```
## Requirements to run the demo
Visual Studio 2015 and above versions


# How to Set the IndentColumnWidth When Print the UWP DataGrid?

This example illustrates how to set the [IndentColumnWidth](https://help.syncfusion.com/cr/uwp/Syncfusion.UI.Xaml.Grid.PrintManagerBase.html#Syncfusion_UI_Xaml_Grid_PrintManagerBase_IndentColumnWidth) when print the [UWP DataGrid](https://www.syncfusion.com/uwp-ui-controls/datagrid) (SfDataGrid).

`DataGrid` allows you to set `IndentColumnWidth` while printing. You can achieve this by set the `IndentColumnWidth` property by override the [GridPrintManager](https://help.syncfusion.com/cr/uwp/Syncfusion.UI.Xaml.Grid.GridPrintManager.html) in [PrintManagerBase](https://help.syncfusion.com/cr/uwp/Syncfusion.UI.Xaml.Grid.PrintManagerBase.html) class.

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

    public CustomPrintManager(SfDataGrid grid) : base(grid)
    {
        sfDatagrid = grid;
        IndentColumnWidth = indentColumnWidth;
    }       
}
```

The following screenshot illustrates the IndentColumnWidth set as 0 while printing,

![DataGrid with the IndentColumnWidth set as 0 while printing](DataGridWith0IndentWidth.png)

The following screenshot illustrates the IndentColumnWidth set as 20 while printing,

![DataGrid with the IndentColumnWidth set as 20 while printing](DataGridWith20IndentWidth.png)
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace IS_Hospital
{
    public class DataGridSupport
    {
        public void ExcelExport(ref DataGrid gridView)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            ExcelApp.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value); ;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Sheets[1];


            ExcelWorkBook.Title = "Больница";

            ExcelWorkSheet.Name = "Пользователи";

            for (int i = 0; i < gridView.Columns.Count; i++)
            {
                //ExcelWorkSheet.Range["A1"].Offset[0, i].Value = gridView.Columns[i].ToString();
                Microsoft.Office.Interop.Excel.Range range = (Microsoft.Office.Interop.Excel.Range)ExcelWorkSheet.Cells[1, i + 1];
                range.Value2 = gridView.Columns[i].Header;
            }

            for (int i = 0; i < gridView.Columns.Count; i++)
            {
                for (int j = 0; j < gridView.Items.Count; j++)
                {
                    TextBlock b = gridView.Columns[i].GetCellContent(gridView.Items[j]) as TextBlock;
                    Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)ExcelWorkSheet.Cells[j + 2, i + 1];
                    myRange.Value2 = b.Text;
                }
            }

            ExcelWorkSheet.Columns.AutoFit();
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }

        public void PdfExport(DataGrid dataGrid, string fileName)
        {
            PdfPTable table = new PdfPTable(dataGrid.Columns.Count);
            using (Document doc = new Document(iTextSharp.text.PageSize.A4))
            {
                using (PdfWriter writer = PdfWriter.GetInstance(doc, new System.IO.FileStream($"{fileName}.pdf", FileMode.Create)))
                {
                    doc.Open();
                    for (int j = 0; j < dataGrid.Columns.Count; j++)
                    {
                        table.AddCell(new Phrase(dataGrid.Columns[j].Header.ToString()));
                    }
                    table.HeaderRows = 1;
                    IEnumerable itemsSource = dataGrid.ItemsSource as IEnumerable;
                    if (itemsSource != null)
                    {
                        foreach (var item in itemsSource)
                        {
                            DataGridRow row = dataGrid.ItemContainerGenerator.ContainerFromItem(item) as DataGridRow;
                            if (row != null)
                            {
                                DataGridCellsPresenter presenter = FindVisualChild<DataGridCellsPresenter>(row);
                                for (int i = 0; i < dataGrid.Columns.Count; ++i)
                                {
                                    DataGridCell cell = (DataGridCell)presenter.ItemContainerGenerator.ContainerFromIndex(i);
                                    TextBlock txt = cell.Content as TextBlock;
                                    if (txt != null)
                                    {
                                        table.AddCell(new Phrase(txt.Text));
                                    }
                                }
                            }
                        }
                        doc.Add(table);
                        doc.Close();
                    }
                }
            }
        }

        public static IEnumerable<T> FindVisualChildren<T>(DependencyObject depObj)
       where T : DependencyObject
        {
            if (depObj != null)
            {
                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(depObj); i++)
                {
                    DependencyObject child = VisualTreeHelper.GetChild(depObj, i);
                    if (child != null && child is T)
                    {
                        yield return (T)child;
                    }

                    foreach (T childOfChild in FindVisualChildren<T>(child))
                    {
                        yield return childOfChild;
                    }
                }
            }
        }

        public static childItem FindVisualChild<childItem>(DependencyObject obj)
            where childItem : DependencyObject
        {
            foreach (childItem child in FindVisualChildren<childItem>(obj))
            {
                return child;
            }

            return null;
        }

    }

}

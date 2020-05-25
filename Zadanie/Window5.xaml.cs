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
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;
using System.Data.Entity;
using System.Data.Odbc;
using System.Data.Common;
using System.ComponentModel;

namespace Zadanie
{
    /// <summary>
    /// Логика взаимодействия для Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        public Window5()
        {
            InitializeComponent();
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            testEntities db = new testEntities();
            db.sheet1s.Load();
            NikGrid.ItemsSource = db.sheet1s.Local.ToBindingList();
        }

        private void sortButton_Click(object sender, RoutedEventArgs e)
        {
            // Очищаем описание сортировки
            NikGrid.Items.SortDescriptions.Clear();
            // Созадем описание сортировки
            NikGrid.Items.SortDescriptions.Add(new SortDescription(NikGrid.Columns[0].SortMemberPath, ListSortDirection.Descending));

            // Очищаем сортировку всех столбцов
            foreach (var col in NikGrid.Columns)
            {
                col.SortDirection = null;
            }
            // Задаем сортировку времени по убыванию (последняя запись вверху)
            NikGrid.Columns[0].SortDirection = ListSortDirection.Descending;
            // Обновляем записи
            NikGrid.Items.Refresh();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            testEntities db = new testEntities();
            db.SaveChanges();
        }
    }
}

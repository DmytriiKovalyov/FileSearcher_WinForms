using System.Collections;
using System.Windows.Forms;

namespace FileManager_DotNet
{
    /*******************************************************************************/
    public class ListViewSorter : IComparer
    {
        private static ColumnHeader _sortedColumn = null;

        private readonly int _currentColumn;

        private readonly SortOrder _sortingOrder;

        public SortOrder Order { get; set; }

        /*******************************************************************************/
        public ListViewSorter()
        {
            _currentColumn = 0;
            _sortingOrder = Order;
        }

        /*******************************************************************************/
        public ListViewSorter(int column, SortOrder sortOrder)
        {
            _currentColumn = column;
            Order = sortOrder;
        }

        /*******************************************************************************/
        public int Compare(object x, object y)
        {
            ListViewItem first_item = x as ListViewItem;
            ListViewItem second_item = y as ListViewItem;

            int result;

            if (double.TryParse(first_item.SubItems[_currentColumn].Text, out double first_item_as_number) &&
                double.TryParse(second_item.SubItems[_currentColumn].Text, out double second_item_as_number))
            {
                result = first_item_as_number.CompareTo(second_item_as_number);
            }
            else
            {
                result = string.Compare(
                    ((ListViewItem)x).SubItems[_currentColumn].Text,
                    ((ListViewItem)y).SubItems[_currentColumn].Text);
            }

            if (Order == SortOrder.Ascending)
            {
                return result;
            }
            else
            {
                return -result;
            }
        }

        /*******************************************************************************/
        public static SortOrder SetSortingOrder(ColumnHeader currentColumn)
        {
            SortOrder sortOrder;

            if (_sortedColumn == null)
            {
                sortOrder = SortOrder.Ascending;
            }
            else
            {
                if (currentColumn == _sortedColumn)
                {
                    sortOrder = _sortedColumn.Text.StartsWith(" ▲ ") ?
                        SortOrder.Descending :
                        SortOrder.Ascending;
                }
                else
                {
                    sortOrder = SortOrder.Ascending;
                }

                _sortedColumn.Text = _sortedColumn.Text.Substring(3);
            }

            _sortedColumn = currentColumn;

            _sortedColumn.Text = (sortOrder == SortOrder.Ascending) ?
                " ▲ " + _sortedColumn.Text :
                " ▼ " + _sortedColumn.Text;

            return sortOrder;
        }
    }
}
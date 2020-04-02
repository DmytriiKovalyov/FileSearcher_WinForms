using System.Collections;
using System.Windows.Forms;

namespace FileManager_DotNet
{
    public class ListViewSorter : IComparer
    {
        private static ColumnHeader SortedColumn = null;

        private readonly int _col;

        private readonly SortOrder _sortOrder;

        public SortOrder Order { get; set; }

        /*******************************************************************************/
        public ListViewSorter()
        {
            _col = 0;
            _sortOrder = Order;
        }

        /*******************************************************************************/
        public ListViewSorter(int column, SortOrder sortOrder)
        {
            _col = column;
            Order = sortOrder;
        }

        /*******************************************************************************/
        public int Compare(object x, object y)
        {
            ListViewItem first_item = x as ListViewItem;
            ListViewItem second_item = y as ListViewItem;

            int result;

            if (double.TryParse(first_item.SubItems[_col].Text, out double first_item_as_number) &&
                double.TryParse(second_item.SubItems[_col].Text, out double second_item_as_number))
            {
                result = first_item_as_number.CompareTo(second_item_as_number);
            }
            else
            {
                result = string.Compare(
                    ((ListViewItem)x).SubItems[_col].Text,
                    ((ListViewItem)y).SubItems[_col].Text);
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

            if (SortedColumn == null)
            {
                sortOrder = SortOrder.Ascending;
            }
            else
            {
                if (currentColumn == SortedColumn)
                {
                    sortOrder = SortedColumn.Text.StartsWith(" > ") ?
                        SortOrder.Descending :
                        SortOrder.Ascending;
                }
                else
                {
                    sortOrder = SortOrder.Ascending;
                }

                SortedColumn.Text = SortedColumn.Text.Substring(3);
            }

            SortedColumn = currentColumn;

            SortedColumn.Text = (sortOrder == SortOrder.Ascending) ?
                " > " + SortedColumn.Text :
                " < " + SortedColumn.Text;

            return sortOrder;
        }
    }
}

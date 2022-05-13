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

namespace XO_Game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int turn = 1;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Grid_Click(object sender, RoutedEventArgs e)
        {
            Button currentButton = e.OriginalSource as Button;
            if (currentButton.Content == null)
            {
                if (turn % 2 == 0)
                    currentButton.Content = "X";
                else
                    currentButton.Content = "O";
                turn++;
            }
            else
                MessageBox.Show("בחר ריבוע ריק");
            string content = currentButton.Content.ToString();
            int row = (int)currentButton.GetValue(Grid.RowProperty);
            int col = (int)currentButton.GetValue(Grid.ColumnProperty);
            if (turn >= 5)
            {
                bool c = false;
                for (int i = 0; i < 9; i++)
                {
                    int x = i;
                    if (x % 3 == 0)
                    {
                        if ((((sender as Grid).Children[x]) as Button).Content == content && (((sender as Grid).Children[x + 1]) as Button).Content == content && (((sender as Grid).Children[x + 2]) as Button).Content == content)
                        {
                            MessageBox.Show("ה" + content + " !!ניצח");
                            c = true;
                            break;
                        }
                    }
                    if (x == 2)
                    {
                        if ((((sender as Grid).Children[x]) as Button).Content == content && (((sender as Grid).Children[x + 2]) as Button).Content == content && (((sender as Grid).Children[x + 2]) as Button).Content == content)
                        {
                            MessageBox.Show("ה" + content + " !!ניצח");
                            c = true;
                            break;
                        }
                    }
                    if (x <= 2)
                    {
                        if ((((sender as Grid).Children[x]) as Button).Content == content && (((sender as Grid).Children[x + 3]) as Button).Content == content && (((sender as Grid).Children[x + 3]) as Button).Content == content)
                        {
                            MessageBox.Show("ה" + content + " !!ניצח");
                            c = true;
                            break;
                        }
                    }
                    if (x == 0)
                        if ((((sender as Grid).Children[x]) as Button).Content == content && (((sender as Grid).Children[x + 4]) as Button).Content == content && (((sender as Grid).Children[x + 4]) as Button).Content == content)
                        {
                            MessageBox.Show("ה" + content + " !!ניצח");
                            c = true;
                            break;
                        }
                }
                if (c)
                    for (int i = 0; i < 9; i++)
                    {
                        (((sender as Grid).Children[i]) as Button).Content = null;
                        turn = 0;
                    }

            }
        }

        //private void CheckWinning(string content)
        //{
        //    throw new NotImplementedException();
        //}
    }
}


//private int CheckLocation(int row, int col)
//{
//    int loc = 0;
//    switch (col)
//    {
//        case 1:
//            loc = row - 1;
//            break;
//        case 2:
//            loc = row + col;
//            break;

//        case 3:
//            loc = row - 1 + col * 2;
//            break;
//    }
//    return loc;
//}
//private bool chackWinning()
//{

//}




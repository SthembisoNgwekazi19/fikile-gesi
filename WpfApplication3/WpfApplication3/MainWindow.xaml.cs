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
using ThinkLib;

namespace WpfApplication3
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

        int length (string s)
        {
            int counter = 0;

            foreach (char c in s)
            {
                counter++;
            }

            return counter;
        }

        bool contains (string s, string subs)
        {
            int StringCounter = 0;

            int sLength = length(s);
            int subsLength = length(subs);

            int temp = 0;

            int tracker = 0;
            string answer = "";

            for (int counter = 0; counter < sLength; counter++)
            {
                if (s[counter] == subs[tracker])
                {
                    answer += s[counter];
                    while (s[counter] == subs[tracker])
                    {
                        tracker++;
                        if (tracker == subsLength)
                        {
                            break;
                        }
                    }
                }

                if (tracker == subsLength)
                {
                    break;
                }


            }

            if (answer == subs)
            {
                return true;
            }

            return false;
        }

        int indexOf (string s, string subs)
        {
            int counter = 0;
            int tracker = 0;
            char Char = Convert.ToChar(s);

            while (tracker < length(s))
            {
                if (Char == s[tracker])
                {
                    tracker++;
                    
                }
            }

            return -1;
        }

        string insertSubString (string s, string x, int pos)
        {

            return "";
        }

        string replaceSubString (string s, string New, string old)
        {

            return "";
        }

        string deleteSubString (string s, string subs)
        {

            return "";
        }

        List<string> split (string s, char c)
        {
            List<string> ls = new List<string>();

            return ls;
        }

        int stringCompare (string s1, string s2)
        {

            return -1;
        }

        string toLower (string s)
        {
            return "";
        }

        string CapitalLetters (string d)
        {
            int counter = 0;
            char[] CharArray = d.ToCharArray();

            while (counter < length(d))
            {
                switch (CharArray[counter])
                {
                    case 'a': return 'A';
                }
            }

            

            return "";
        }

        string toUpper (string s)
        {
            

            return "";
        }

        private void btnUnitTests_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(length("Fikile"), 6);
            Tester.TestEq(contains("Johannesburg", "han"), true);
            Tester.TestEq(toUpper("duduza"), "DUDUZA");
        }
    }
}

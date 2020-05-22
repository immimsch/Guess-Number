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
using Exercise1402;

namespace Guess_Game_GUI
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>

    public partial class GameWindow : Window
    {
        private int number;
        int count;
        string userinput;
        bool state;

        Guess guess = new Guess(4);

        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }
        public int Count
        {
            get { return count; }
            set
            {
                count = value;
            }
        }


        public string UserInput
        {
            get { return userinput; }
            set
            {
                userinput = value;
            }
        }
        public bool State
        {
            get { return state; }
            set
            {
                state = value;
            }
        }

        public GameWindow()
        {
            InitializeComponent();
            State = false;
        }

        private void NewGameButton_Click(object sender, RoutedEventArgs e)
        {
            TipsRichTextBox.Document.Blocks.Clear();
            guess = new Guess(Number);
            Count = 0;
            UserInput = "";
            State = true;
            TipsRichTextBox.AppendText("Game Start!\r");
            ButtonOne.IsEnabled = true;
            ButtonTwo.IsEnabled = true;
            ButtonThree.IsEnabled = true;
            ButtonFour.IsEnabled = true;
            ButtonFive.IsEnabled = true;
            ButtonSix.IsEnabled = true;
            ButtonSeven.IsEnabled = true;
            ButtonEight.IsEnabled = true;
            ButtonNine.IsEnabled = true;
            ButtonZero.IsEnabled = true;
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void ButtonOne_Click(object sender, RoutedEventArgs e)
        {
            UserInput = UserInput + "1";
            Count++;               
            TipsRichTextBox.AppendText("1");
            if (Count == Number)
                CallGuessGame();
        }

        private void ButtonTwo_Click(object sender, RoutedEventArgs e)
        {
            UserInput = UserInput + "2";
            Count++;
            TipsRichTextBox.AppendText("2");
            if (Count == Number)
                CallGuessGame();
        }

        private void ButtonThree_Click(object sender, RoutedEventArgs e)
        {
            UserInput = UserInput + "3";
            Count++;
            TipsRichTextBox.AppendText("3");
            if (Count == Number)
                CallGuessGame();
        }

        private void ButtonFour_Click(object sender, RoutedEventArgs e)
        {
            UserInput = UserInput + "4";
            Count++;
            TipsRichTextBox.AppendText("4");
            if (Count == Number)
                CallGuessGame();
        }

        private void ButtonFive_Click(object sender, RoutedEventArgs e)
        {
            UserInput = UserInput + "5";
            Count++;
            TipsRichTextBox.AppendText("5");
            if (Count == Number)
                CallGuessGame();
        }

        private void ButtonSix_Click(object sender, RoutedEventArgs e)
        {
            UserInput = UserInput + "6";
            Count++;
            TipsRichTextBox.AppendText("6");
            if (Count == Number)
                CallGuessGame();
        }

        private void ButtonSeven_Click(object sender, RoutedEventArgs e)
        {
            UserInput = UserInput + "7";
            Count++;
            TipsRichTextBox.AppendText("7");
            if (Count == Number)
                CallGuessGame();
        }

        private void ButtonEight_Click(object sender, RoutedEventArgs e)
        {
            UserInput = UserInput + "8";
            Count++;
            TipsRichTextBox.AppendText("8");
            if (Count == Number)
                CallGuessGame();
        }

        private void ButtonNine_Click(object sender, RoutedEventArgs e)
        {
            UserInput = UserInput + "9";
            Count++;
            TipsRichTextBox.AppendText("9");
            if (Count == Number)
                CallGuessGame();
        }

        private void ButtonZero_Click(object sender, RoutedEventArgs e)
        {
            UserInput = UserInput + "0";
            Count++;
            TipsRichTextBox.AppendText("0");
            if (Count == Number)
                CallGuessGame();
        }

        public void CallGuessGame()
        {
            TipsRichTextBox.AppendText("    ");
            if (guess.FindNumber(UserInput))
            {
                guess.ABCounter(UserInput);
                if (guess.ACount == Number)
                {
                    TipsRichTextBox.AppendText("You got it!\r");
                    ButtonOne.IsEnabled = false;
                    ButtonTwo.IsEnabled = false;
                    ButtonThree.IsEnabled = false;
                    ButtonFour.IsEnabled = false;
                    ButtonFive.IsEnabled = false;
                    ButtonSix.IsEnabled = false;
                    ButtonSeven.IsEnabled = false;
                    ButtonEight.IsEnabled = false;
                    ButtonNine.IsEnabled = false;
                    ButtonZero.IsEnabled = false;
                    TipsRichTextBox.AppendText("Press New Game To Start.");
                }
                else
                {
                    TipsRichTextBox.AppendText(guess.ACount + "A" + guess.BCount + "B\r");
                }
                UserInput = "";
                Count = 0;
                guess.ACount = 0;
                guess.BCount = 0;
                TipsRichTextBox.ScrollToEnd();
            }
            else
            {
                TipsRichTextBox.AppendText("Number Invalid. Guess Again!\r");
                UserInput = "";
                Count = 0;
            }
        }
    }
}

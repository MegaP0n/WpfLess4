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

namespace WpfLess4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Keyboard KeyboardUpper { get; set; } = new Keyboard()
        {
            KeyTab = new Key()
            {
                Text = "Tab",
                Color = new SolidColorBrush(Colors.Gray)
            },
            KeyQ = new Key()
            {
                Text = "Q",
                Color = new SolidColorBrush(Colors.Red)
            },
            KeyW = new Key()
            {
                Text = "W",
                Color = new SolidColorBrush(Colors.Yellow)
            },
            KeyE = new Key()
            {
                Text = "E",
                Color = new SolidColorBrush(Colors.Lime)
            },
            KeyR = new Key()
            {
                Text = "R",
                Color = new SolidColorBrush(Colors.Cyan)
            },
            KeyT = new Key()
            {
                Text = "T",
                Color = new SolidColorBrush(Colors.Cyan)
            },
            KeyY = new Key()
            {
                Text = "Y",
                Color = new SolidColorBrush(Colors.Purple)
            },
            KeyU = new Key()
            {
                Text = "U",
                Color = new SolidColorBrush(Colors.Purple)
            },
            KeyI = new Key()
            {
                Text = "I",
                Color = new SolidColorBrush(Colors.Red),
            },
            KeyO = new Key()
            { 
                Text = "O",
                Color = new SolidColorBrush(Colors.Yellow)
            },
            KeyP = new Key()
            {
                Text = "P",
                Color = new SolidColorBrush(Colors.Lime)
            },
            KeyLeftAltBr = new Key()
            {
                Text = "{",
                Color = new SolidColorBrush(Colors.Lime),
            },
            KeyRightAltBr = new Key()
            {
                Text = "}",
                Color = new SolidColorBrush(Colors.Lime),
            },
            KeyStick = new Key()
            {
                Text = "|",
                Color = new SolidColorBrush(Colors.Lime)
            }
        };
        private Keyboard KeyboardLower { get; set; } = new Keyboard()
        {
            KeyTab = new Key()
            {
                Text = "Tab",
                Color = new SolidColorBrush(Colors.Gray)
            },
            KeyQ = new Key()
            {
                Text = "q",
                Color = new SolidColorBrush(Colors.Red)
            },
            KeyW = new Key()
            {
                Text = "w",
                Color = new SolidColorBrush(Colors.Yellow)
            },
            KeyE = new Key()
            {
                Text = "e",
                Color = new SolidColorBrush(Colors.Lime)
            },
            KeyR = new Key()
            {
                Text = "r",
                Color = new SolidColorBrush(Colors.Cyan)
            },
            KeyT = new Key()
            {
                Text = "t",
                Color = new SolidColorBrush(Colors.Cyan)
            },
            KeyY = new Key()
            {
                Text = "y",
                Color = new SolidColorBrush(Colors.Purple)
            },
            KeyU = new Key()
            {
                Text = "u",
                Color = new SolidColorBrush (Colors.Purple)
            },
            KeyI = new Key()
            {
                Text = "i",
                Color = new SolidColorBrush(Colors.Red)
            },
            KeyO = new Key()
            {
                Text = "o",
                Color = new SolidColorBrush (Colors.Yellow)
            },
            KeyP = new Key()
            {
                Text = "p",
                Color = new SolidColorBrush(Colors.Lime)
            },
            KeyLeftAltBr = new Key()
            {
                Text = "[",
                Color = new SolidColorBrush(Colors.Lime)
            },
            KeyRightAltBr = new Key()
            {
                Text = "]",
                Color = new SolidColorBrush(Colors.Lime)
            },
            KeyStick = new Key()
            {
                Text = "\\",
                Color = new SolidColorBrush(Colors.Lime)
            }
        };

        public Keyboard CurrentKeyboard { get; set; }

        public MainWindow()
        {
            CurrentKeyboard = KeyboardLower;
            DataContext = this;
            InitializeComponent();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.LeftShift)
            {
                KeyboardGrid.DataContext = KeyboardUpper;
            }
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.LeftShift)
            {
                KeyboardGrid.DataContext = KeyboardLower;
            }
        }
    }

    public class Keyboard
    {
        public Key KeyTab { get; set; }
        public Key KeyQ { get; set; }
        public Key KeyW { get; set; }
        public Key KeyE { get; set; }
        public Key KeyR { get; set; }
        public Key KeyT { get; set; }
        public Key KeyY { get; set; }
        public Key KeyU { get; set; }
        public Key KeyI { get; set; }
        public Key KeyO { get; set; }
        public Key KeyP { get; set; }
        public Key KeyLeftAltBr { get; set; }
        public Key KeyRightAltBr { get; set; }
        public Key KeyStick { get; set; }
    }
    public class Key
    {
        public string Text { get; set; }
        public SolidColorBrush Color { get; set; }
    }
}


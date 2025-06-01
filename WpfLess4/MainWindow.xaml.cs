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
            public Keyboard Keyboard { get; set; }
        public MainWindow()
        {
            Keyboard = new Keyboard();
    
            InitializeComponent();
            KeyboardGrid.DataContext = Keyboard;
        }
    
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.IsRepeat) return;
    
            switch (e.Key)
            {
                case System.Windows.Input.Key.LeftShift:
                    Keyboard.OnShiftTrigger();
                    break;
                case System.Windows.Input.Key.CapsLock:
                    Keyboard.OnCapsLockTrigger();
                    break;
                default:
                    break;
            }
        }
        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case System.Windows.Input.Key.LeftShift:
                    Keyboard.OnShiftTrigger();
                    break;
                default:
                    break;
            }
        }
    }
    
    public class Keyboard
    {
        public Key KeyNumber0 { get; set; }
        public Key KeyNumber1 { get; set; }
        public Key KeyNumber2 { get; set; }
        public Key KeyNumber3 { get; set; }
        public Key KeyNumber4 { get; set; }
        public Key KeyNumber5 { get; set; }
        public Key KeyNumber6 { get; set; }
        public Key KeyNumber7 { get; set; }
        public Key KeyNumber8 { get; set; }
        public Key KeyNumber9 { get; set; }
        public Key KeyNumber10 { get; set; }
        public Key KeyNumber11 { get; set; }
        public Key KeyNumber12 { get; set; }
        public Key KeyBackspace { get; set; }
    
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
        public Key KeyTab { get; set; }
        public Key KeyLeftAltBr { get; set; }
        public Key KeyRightAltBr { get; set; }
        public Key KeyStick { get; set; }
        public Key KeyCapsLock { get; set; }
        public Key KeyA { get; set; }
        public Key KeyS { get; set; }
        public Key KeyD { get; set; }
        public Key KeyF { get; set; }
        public Key KeyG { get; set; }
        public Key KeyH { get; set; }
        public Key KeyJ { get; set; }
        public Key KeyK { get; set; }
        public Key KeyL { get; set; }
        public Key Key2Dot { get; set; }
        public Key KeyQuot { get; set; }
        public Key KeyEnter { get; set; }
    
    
        public event Action ShiftTrigger;
        public event Action CapsLockTrigger;
    
        public Keyboard()
        {
            KeyNumber0 = CreateNumberKey("`", "~", new SolidColorBrush(Colors.Red));
            KeyNumber1 = CreateNumberKey("1", "!", new SolidColorBrush(Colors.Red));
            KeyNumber2 = CreateNumberKey("2", "@", new SolidColorBrush(Colors.Red));
            KeyNumber3 = CreateNumberKey("3", "#", new SolidColorBrush(Colors.Yellow));
            KeyNumber4 = CreateNumberKey("4", "$", new SolidColorBrush(Colors.Lime));
            KeyNumber5 = CreateNumberKey("5", "%", new SolidColorBrush(Colors.Cyan));
            KeyNumber6 = CreateNumberKey("6", "^", new SolidColorBrush(Colors.Cyan));
            KeyNumber7 = CreateNumberKey("7", "&", new SolidColorBrush(Colors.Purple));
            KeyNumber8 = CreateNumberKey("8", "*", new SolidColorBrush(Colors.Purple));
            KeyNumber9 = CreateNumberKey("9", "(", new SolidColorBrush(Colors.Red));
            KeyNumber10 = CreateNumberKey("0", ")", new SolidColorBrush(Colors.Yellow));
            KeyNumber11 = CreateNumberKey("-", "_", new SolidColorBrush(Colors.Lime));
            KeyNumber12 = CreateNumberKey("=", "+", new SolidColorBrush(Colors.Lime));
            KeyBackspace = CreateSpecialKey("Backspace", new SolidColorBrush(Colors.Gray));
    
            KeyTab = CreateSpecialKey("Tab", new SolidColorBrush(Colors.Gray));
    
            KeyQ = CreateStandartKey("q", "Q", new SolidColorBrush(Colors.Red));
            KeyW = CreateStandartKey("w", "W", new SolidColorBrush(Colors.Yellow));
            KeyE = CreateStandartKey("e", "E", new SolidColorBrush(Colors.Lime));
            KeyR = CreateStandartKey("r", "R", new SolidColorBrush(Colors.Cyan));
            KeyT = CreateStandartKey("t", "T", new SolidColorBrush(Colors.Cyan));
            KeyY = CreateStandartKey("y", "Y", new SolidColorBrush(Colors.Purple));
            KeyU = CreateStandartKey("u", "U", new SolidColorBrush(Colors.Purple));
            KeyI = CreateStandartKey("i", "I", new SolidColorBrush(Colors.Red));
            KeyO = CreateStandartKey("o", "O", new SolidColorBrush(Colors.Yellow));
            KeyP = CreateStandartKey("p", "P", new SolidColorBrush(Colors.Lime));
            KeyLeftAltBr = CreateStandartKey("[", "{", new SolidColorBrush(Colors.Lime));
            KeyRightAltBr = CreateStandartKey("]", "}", new SolidColorBrush(Colors.Lime));
            KeyStick = CreateStandartKey("|", "\\", new SolidColorBrush(Colors.Lime));
    
            KeyCapsLock = CreateSpecialKey("Caps Lock", new SolidColorBrush(Colors.Gray));
            KeyA = CreateStandartKey("a", "A", new SolidColorBrush(Colors.Red));
            KeyS = CreateStandartKey("s", "S", new SolidColorBrush(Colors.Yellow));
            KeyD = CreateStandartKey("d", "D", new SolidColorBrush(Colors.Lime));
            KeyF = CreateStandartKey("f", "F", new SolidColorBrush(Colors.Cyan));
            KeyG = CreateStandartKey("g", "G", new SolidColorBrush(Colors.Cyan));
            KeyH = CreateStandartKey("h", "H", new SolidColorBrush(Colors.Purple));
            KeyJ = CreateStandartKey("j", "J", new SolidColorBrush(Colors.Purple));
            KeyK = CreateStandartKey("k", "K", new SolidColorBrush(Colors.Red));
            KeyL = CreateStandartKey("l", "L", new SolidColorBrush(Colors.Yellow));
            Key2Dot = CreateStandartKey(";", ":", new SolidColorBrush(Colors.Lime));
            KeyQuot = CreateStandartKey("'", "\"", new SolidColorBrush(Colors.Lime));
            KeyEnter = CreateSpecialKey("Enter", new SolidColorBrush(Colors.Gray));
        }
    
        private Key CreateStandartKey(
            string defaultState,
            string alterState,
            SolidColorBrush color)
        {
            var key = new Key(defaultState, alterState)
            {
                Color = color
            };
    
            ShiftTrigger += key.ChangeState;
            CapsLockTrigger += key.ChangeState;
    
            return key;
        }
    
        private Key CreateSpecialKey(string defaultState, SolidColorBrush color)
        {
            var key = new Key(defaultState, defaultState)
            {
                Color = color
            };
    
            return key;
        }
    
        private Key CreateNumberKey(string defaultState, string alterState,
            SolidColorBrush color)
        {
            var key = new Key(defaultState, alterState)
            {
                Color = color
            };
    
            ShiftTrigger += key.ChangeState;
    
            return key;
        }
    
        public void OnShiftTrigger()
        {
            ShiftTrigger?.Invoke();
        }
        public void OnCapsLockTrigger()
        {
            CapsLockTrigger?.Invoke();
        }
    }
    
    public class Key : INotifyPropertyChanged
    {
        private string _defaultState;
        private string _alterState;
        private bool _isDefaultState;
    
        public string Text
        {
            get
            {
                return _isDefaultState
                    ? _defaultState : _alterState;
            }
        }
    
        public SolidColorBrush Color { get; set; }
        public Key(string defaultState, string alterState)
        {
            _defaultState = defaultState;
            _alterState = alterState;
            _isDefaultState = true;
        }
    
        public void ChangeState()
        {
            _isDefaultState = !_isDefaultState;
            OnPropertyChanged("Text");
        }
    
    
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
        }
}


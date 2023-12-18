using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Schema;

namespace HW_WPF_CommandsNBindings
{
    public static class UserCommands
    {
        public static RoutedUICommand Red { get; private set; }
        public static RoutedUICommand Green { get; private set; }
        public static RoutedUICommand Blue { get; private set; }

        static UserCommands()
        {
            InputGestureCollection inputsR = new InputGestureCollection();
            InputGestureCollection inputsG = new InputGestureCollection();
            InputGestureCollection inputsB = new InputGestureCollection();
            inputsR.Add(new KeyGesture(Key.R, ModifierKeys.Control, "Ctrl+R"));
            inputsG.Add(new KeyGesture(Key.G, ModifierKeys.Control, "Ctrl+G"));
            inputsB.Add(new KeyGesture(Key.B, ModifierKeys.Control, "Ctrl+B"));

            Red = new RoutedUICommand("Red", "RedBrush", typeof(UserCommands), inputsR);
            Green = new RoutedUICommand("Green", "GreenBrush", typeof(UserCommands), inputsG);
            Blue = new RoutedUICommand("Blue", "BlueBrush", typeof(UserCommands), inputsB);
        }
        //static UserCommands()
        //{
        //    InputGestureCollection inputs = new InputGestureCollection();
        //    inputs.Add(new KeyGesture(Key.G, ModifierKeys.Control, "Ctrl+G"));
        //
        //    Green = new RoutedUICommand("Green", "GreenBrush", typeof(UserCommands), inputs);
        //}
        //static UserCommands()
        //{
        //    InputGestureCollection inputs = new InputGestureCollection();
        //    inputs.Add(new KeyGesture(Key.B, ModifierKeys.Control, "Ctrl+B"));
        //
        //    Blue = new RoutedUICommand("Blue", "BlueBrush", typeof(UserCommands), inputs);
        //}
    }
}

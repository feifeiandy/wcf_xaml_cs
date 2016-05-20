using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MyHelper
{
    public class TextBoxHelper
    {


        public static int GetMyProperty(DependencyObject obj)
        {
            return (int)obj.GetValue(MyPropertyProperty);
        }

        public static void SetMyProperty(DependencyObject obj, int value)
        {
            obj.SetValue(MyPropertyProperty, value);
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MyPropertyProperty =
            DependencyProperty.RegisterAttached("MyProperty", typeof(int), typeof(TextBoxHelper), new PropertyMetadata(0));




        public static string GetMyText(DependencyObject obj)
        {
            return (string)obj.GetValue(MyTextProperty);
        }

        public static void SetMyText(DependencyObject obj, string value)
        {
            obj.SetValue(MyTextProperty, value);
        }

        // Using a DependencyProperty as the backing store for MyText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MyTextProperty =
            DependencyProperty.RegisterAttached("MyText", typeof(string), typeof(TextBoxHelper), new PropertyMetadata("1"));
        // 此处默认值要设置正确 为字符串格式
        
        
    }
}

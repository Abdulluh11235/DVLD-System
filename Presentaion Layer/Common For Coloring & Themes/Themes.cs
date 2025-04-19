using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentaion_Layer.Common_For_Coloring___Themes
{

    public struct Mode
    {
        /// <summary>
        /// The background color of controls.
        /// </summary>
        public Color BackgroundColor { get; init; }

        /// <summary>
        /// The accent color for borders or secondary elements.
        /// </summary>
        public Color AccentColor { get; init; }

        /// <summary>
        /// The text color for controls.
        /// </summary>
        public Color FontColor { get; init; }
    }
    public static class Themes
    {
      
        public static Mode DarkMode()
        {
            return new Mode
            {
                BackgroundColor = Color.FromArgb(33, 33, 33),
                AccentColor = Color.FromArgb(60, 60, 60),
                FontColor = Color.FromArgb(242, 242, 242)
            };
        }

      
        //public static void ApplyTheme(Control control, Mode mode)
        //{
        //    control.BackColor = mode.BackgroundColor;
        //    control.ForeColor = mode.FontColor;
        //    if (control is ComboBox comboBox)
        //    {
        //        comboBox.FlatStyle = FlatStyle.Flat;
        //        comboBox.DrawMode = DrawMode.OwnerDrawFixed;
        //    }
        //}

    }
}

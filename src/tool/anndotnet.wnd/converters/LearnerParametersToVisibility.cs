﻿using anndotnet.wnd.Models;
using NNetwork.Core.Common;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace anndotnet.wnd.converters
{
    [ValueConversion(typeof(string), typeof(Visibility))]
    public class LearnerParametersToVisibility : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null || string.IsNullOrEmpty(value.ToString()))
                return Visibility.Visible;
            if (value.ToString().Equals("SGDLearner", StringComparison.CurrentCultureIgnoreCase) || value.ToString().Equals("AdaGradLearner", StringComparison.CurrentCultureIgnoreCase))
                return Visibility.Collapsed;
            else
                return Visibility.Visible;
           
        }  

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {    // Don't need any convert back
            return null;
        }
    }
}

// Copyright (c) Brice Lambson
// The Brice Lambson licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.  Code forked from Brice Lambson's https://github.com/bricelam/ImageResizer/

using System;
using System.Globalization;
using ImageResizer.WinUI.Properties;
using Microsoft.UI.Xaml.Data;

namespace ImageResizer.WinUI.Converters
{
    internal class AutoDoubleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var d = (double)value;

            return d != 0
                ? d.ToString(CultureInfo.CurrentCulture)
                : (string)parameter == "Auto"
                    ? Resources.Input_Auto
                    : string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            var text = (string)value;

            return !string.IsNullOrEmpty(text)
                ? double.Parse(text, CultureInfo.CurrentCulture)
                : 0;
        }
    }
}

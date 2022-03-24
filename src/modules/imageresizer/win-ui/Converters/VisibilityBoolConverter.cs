// Copyright (c) Brice Lambson
// The Brice Lambson licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.  Code forked from Brice Lambson's https://github.com/bricelam/ImageResizer/

using System;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Data;

namespace ImageResizer.WinUI.Converters
{
    internal class VisibilityBoolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
            => (Visibility)value == Visibility.Visible;

        public object ConvertBack(object value, Type targetType, object parameter, string language)
            => (bool)value ? Visibility.Visible : Visibility.Collapsed;
    }
}

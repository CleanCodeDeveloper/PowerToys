// Copyright (c) Brice Lambson
// The Brice Lambson licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.  Code forked from Brice Lambson's https://github.com/bricelam/ImageResizer/

using System;
using System.Globalization;
using System.Text;
using ImageResizer.WinUI.Properties;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Data;

namespace ImageResizer.WinUI.Converters
{
    public class EnumValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var type = value?.GetType();
            var builder = new StringBuilder();

            builder
                .Append(type.Name)
                .Append('_')
                .Append(Enum.GetName(type, value));

            var toLower = false;
            if ((string)parameter == "ToLower")
            {
                toLower = true;
            }
            else if (parameter != null)
            {
                builder
                    .Append('_')
                    .Append(parameter);
            }

            var targetValue = Resources.ResourceManager.GetString(builder.ToString(), CultureInfo.CurrentUICulture);

            if (toLower)
            {
                targetValue = targetValue.ToLower(CultureInfo.CurrentCulture);
            }

            return targetValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
            => value;
    }
}

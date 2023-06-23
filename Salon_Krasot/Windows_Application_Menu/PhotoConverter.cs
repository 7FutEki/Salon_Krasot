using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace Salon_Krasot.Windows_Application_Menu
{
    internal class PhotoConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            byte[] photoBytes = values[0] as byte[];
            string photoPath = values[1] as string;

            if (photoBytes != null && photoBytes.Length > 0)
            {
                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = new MemoryStream(photoBytes);
                bitmapImage.EndInit();
                return bitmapImage;
            }
            else if (!string.IsNullOrEmpty(photoPath))
            {
                return new BitmapImage(new Uri(photoPath, UriKind.RelativeOrAbsolute));
            }
            return null;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

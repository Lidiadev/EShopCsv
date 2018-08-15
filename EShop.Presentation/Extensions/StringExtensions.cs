namespace EShop.Presentation.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Converts a string to the int
        /// </summary>
        /// <param name="text">The object to convert</param>
        /// <returns>Defult 0 or the value</returns>
        public static int ConvertToInt(this object item)
        {
            var text = item.ToString();

            if (string.IsNullOrWhiteSpace(text))
                return 0;

            return int.TryParse(text, out int value) ? value : 0;
        }

        /// <summary>
        /// Converts a string to the double
        /// </summary>
        /// <param name="text">The object to convert</param>
        /// <returns>Defult 0 or the value</returns>
        public static double ConvertToDouble(this object item)
        {
            var text = item.ToString();

            if (string.IsNullOrWhiteSpace(text))
                return 0;

            return double.TryParse(text, out double value) ? value : 0;
        }
    }
    }

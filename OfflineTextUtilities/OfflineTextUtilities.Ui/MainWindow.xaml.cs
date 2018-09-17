using Newtonsoft.Json;
using System;
using System.Windows;

namespace OfflineTextUtilities.Ui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Base64Decode_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var bytes = Convert.FromBase64String(Base64DecodeSource.Text);
                var base64 = System.Text.Encoding.UTF8.GetString(bytes);
                Base64DecodeDestination.Text = base64;
            }
            catch
            {
                Base64DecodeDestination.Text = "Failed to decode";
            }
        }

        private void Base64Encode_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                byte[] bytes = System.Text.Encoding.UTF8.GetBytes(Base64EncodeSource.Text);
                var base64 = Convert.ToBase64String(bytes);
                Base64EncodeDestination.Text = base64;
            }
            catch
            {
                Base64DecodeDestination.Text = "Failed to encode";
            }
        }

        private void JsonPrettify_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var jsonObject = JsonConvert.DeserializeObject(JsonPrettifySource.Text);
                var formattedJsonString = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
                JsonPrettifyDestination.Text = formattedJsonString;
            }
            catch
            {
                JsonPrettifyDestination.Text = "Failed to prettify";
            }
        }
    }
}

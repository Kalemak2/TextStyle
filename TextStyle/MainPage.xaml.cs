namespace TextStyle
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            string[] texts = { "Marek", "Kacper", "Wojtek", "Talerz", "Chleb" };
            Random rnd = new Random();
            int i = rnd.Next(0, texts.Length);
            xLabel.Text = texts[i];

            

        }

        private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            sliderLabel.Text = $"Rozmiar: {e.NewValue:F0}";
        }

        private void OnClick(object sender, EventArgs e)
        {
            double fontSize = slider.Value;
            string selectedAlignment = textAlignmentPicker.SelectedItem as string;
            TextAlignment horizontalTextAlignment = TextAlignment.Start;

            if (selectedAlignment == "End")
            {
                horizontalTextAlignment = TextAlignment.End;
            }
            else if (selectedAlignment == "Center")
            {
                horizontalTextAlignment = TextAlignment.Center;
            }


            bool isBold = boldSwitch.IsToggled;
            bool isItalic = italicSwitch.IsToggled;


            FontAttributes fontAttributes = FontAttributes.None;

            if (isBold)
            {
                fontAttributes |= FontAttributes.Bold;
            }
            if (isItalic)
            {
                fontAttributes |= FontAttributes.Italic;
            }


            xLabel.FontSize = fontSize;
            xLabel.HorizontalTextAlignment = horizontalTextAlignment;
            xLabel.FontAttributes = fontAttributes;
        }
    }
}

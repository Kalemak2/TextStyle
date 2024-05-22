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
            double selectedFontSize = slider.Value;


            string selectedAlignmentOption = xpicker.SelectedItem as string;
            TextAlignment textAlignment = TextAlignment.Start;

            if (selectedAlignmentOption == "End")
            {
                textAlignment = TextAlignment.End;
            }
            else if (selectedAlignmentOption == "Center")
            {
                textAlignment = TextAlignment.Center;
            }
            


            FontAttributes fontStyleAttributes = FontAttributes.None;

            bool isTextBold = boldSwitch.IsToggled;

            if (isTextBold)
            {
                fontStyleAttributes |= FontAttributes.Bold;
            }

            bool isTextItalic = italicSwitch.IsToggled;

            if (isTextItalic)
            {
                fontStyleAttributes |= FontAttributes.Italic;
            }

            xLabel.HorizontalTextAlignment = textAlignment;
            xLabel.FontSize = selectedFontSize;
            xLabel.FontAttributes = fontStyleAttributes;
        }
    }
}

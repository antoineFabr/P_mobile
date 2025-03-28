namespace PassionLecture
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
            pickerNumber.ItemsSource = new List<string>
            {
                "1",
                "2",
                "3",
                "4",
            };
        }

      
    }

}

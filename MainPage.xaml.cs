namespace CalculateurAge
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCalculerClicker(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(entryNom.Text))
            {
                DisplayAlert("Erreur", "Entrez un nom", "Ok");
                return;
            }

            DateTime d = (DateTime) pickerDate.Date;
            int age = DateTime.Today.Year - d.Year;

            if (d.Date > DateTime.Today.AddYears(-age)) age--;
            lblResultat.Text = $"{entryNom.Text} vous avez {age} ans";
            lblResultat.IsVisible = true;
}
    }
}

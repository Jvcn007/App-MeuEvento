namespace MeuEvento.Views;

public partial class ResultadoEvento : ContentPage
{
	public ResultadoEvento()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new CadastroEvento());
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "Ok");
        }
    }

   
}
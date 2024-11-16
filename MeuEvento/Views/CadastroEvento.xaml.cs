using MeuEvento.Models;

namespace MeuEvento.Views;

public partial class CadastroEvento : ContentPage
{
	public CadastroEvento()
	{
		InitializeComponent();


        DtInicial.MinimumDate = DateTime.Now;
        DtInicial.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

        DtFinal.MinimumDate = DtInicial.Date.AddDays(1);
        DtFinal.MaximumDate = DtInicial.Date.AddMonths(6);

       
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        try
        {

            Evento DadosDigitados = new Evento()
            {
                Nome = Nome.Text,
                LocalEvento = LocalEvento.Text,
                CustoParticipante = int.Parse(CustoParticipante.Text),
                DtInicial = DtInicial.Date,
                DtFinal = DtFinal.Date,
                NumParticipantes = Convert.ToInt32(NumParticipantes.Value)
            };





            await Navigation.PushAsync(new ResultadoEvento()
                {
                BindingContext = DadosDigitados
                    });




        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "Ok");
        }
    }

    
    private async void DtInicial_Selected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = sender as DatePicker;

        DateTime data_Inicial_selecionada = elemento.Date;

        DtFinal.MinimumDate = data_Inicial_selecionada.AddDays(1);
        DtFinal.MaximumDate = data_Inicial_selecionada.AddMonths(6);
    }

   

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new StartPage());


        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "Ok");
        }
    }
}
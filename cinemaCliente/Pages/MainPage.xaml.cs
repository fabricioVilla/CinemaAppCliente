using cinemaCliente.Models;
using cinemaCliente.PageModels;

namespace cinemaCliente.Pages;

public partial class MainPage : ContentPage
{
	public MainPage(MainPageModel model)
	{
		InitializeComponent();
		BindingContext = model;
	}
}
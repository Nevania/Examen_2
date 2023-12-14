using ExamenProga_2.ViewModels;

namespace ExamenProga_2;

public partial class RectanguloPage : ContentPage
{
	public RectanguloPage()
	{
		InitializeComponent();
		BindingContext = new RectaguloViewModels();
    }
}
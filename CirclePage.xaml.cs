using ExamenProga_2.ViewModels;

namespace ExamenProga_2;

public partial class CirclePage : ContentPage
{
	public CirclePage()
	{
		InitializeComponent();
        BindingContext = new CircleViewModels();
    }
}
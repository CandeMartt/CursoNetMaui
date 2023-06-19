namespace HorizontalVerticalStack;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new VerticalStackLayoutDemo();
	}
}

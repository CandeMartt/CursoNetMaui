namespace PagesDemo;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		var navPage = new NavigationPage(new MainPage());
		navPage.BarBackground = Colors.Chocolate;
		navPage.BarTextColor = Colors.White;

		// Indicamos cual es la pagina inicial de la aplicacion
		MainPage = new TabbedPageDemo();
	}
}

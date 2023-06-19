using Android.App.Admin;
using DatabindingDemo.Models;

namespace DatabindingDemo;

public partial class MainPage : ContentPage
{
	Person person = new Person();
	public MainPage()
	{
		InitializeComponent();
        person = new Person

        {
            Name = "John",
            Phone = "9999",
            Address = " X Address"
        };

        BindingContext = person;
    }

	private void OnCounterClicked(object sender, EventArgs e)
	{
        person.Name = "Peter";
        person.Phone = "0000";
        person.Address = "New Address";


		// var person = new Person
		// {
			// Name = "John",
			// Phone = "9999",
			// Address = " X Address"
		// };

		// BindingContext = person;

		// Donde esta el origen de la informacion
		// txtName.BindingContext = person;
		// Establece la propiedad de la que vamos a tomar la informacion 
        // txtName.SetBinding(Label.TextProperty, "Name");

        // Enlace desde código C#
        // Binding personBinding =
        // 	new Binding();

        // Especificamos el origen de la informacion
        // personBinding.Source = person;

        // Cual es la propiedad de la que se va a extraer la informacion
        // personBinding.Path = "Name";

        // Establecemos el enlace hacia la propiedad específica la cual toma el dato desde el origen de informacion
        // En este caso es la propiedad llamada Name
        // txtName.SetBinding(Label.TextProperty, personBinding);


    }
}


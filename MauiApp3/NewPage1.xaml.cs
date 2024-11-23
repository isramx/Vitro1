namespace MauiApp3;

public partial class NewPage1 : ContentPage
{
    public NewPage1()
    {
        InitializeComponent();
    }

    private void Agregar_Clicked(object sender, EventArgs e)
    {
        // Aquí puedes implementar la lógica para agregar el peso a una lista o base de datos
        string peso = entryPeso.Text;
        // ...
    }

    private void Borrar_Clicked(object sender, EventArgs e)
    {
        // Aquí puedes implementar la lógica para borrar el último peso agregado o limpiar el cuadro de texto
        entryPeso.Text = string.Empty;
        // ...
    }
}
namespace MauiApp3;

public partial class NewPage1 : ContentPage
{
    public NewPage1()
    {
        InitializeComponent();
    }

    private void Agregar_Clicked(object sender, EventArgs e)
    {
        // Aqu� puedes implementar la l�gica para agregar el peso a una lista o base de datos
        string peso = entryPeso.Text;
        // ...
    }

    private void Borrar_Clicked(object sender, EventArgs e)
    {
        // Aqu� puedes implementar la l�gica para borrar el �ltimo peso agregado o limpiar el cuadro de texto
        entryPeso.Text = string.Empty;
        // ...
    }
}
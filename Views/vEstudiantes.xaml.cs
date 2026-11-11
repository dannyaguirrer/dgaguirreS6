using System.Collections.ObjectModel;
using Newtonsoft.Json;
using dgaguirreS6.Models;   // ajusta al namespace real de Estudiantes.cs

namespace dgaguirreS6.Views;

public partial class vEstudiantes : ContentPage
{
    private const string url = "http://192.168.10.251/ws_estudiantes/estudiantes_ws.php";
    private readonly HttpClient _client = new HttpClient();
    private ObservableCollection<Estudiantes> _estudiantes;

    public vEstudiantes()
    {
        InitializeComponent();
        MostrarEstudiantes();
    }

    public async void MostrarEstudiantes()
    {
        var content = await _client.GetStringAsync(url);
        List<Estudiantes> _mostrar = JsonConvert.DeserializeObject<List<Estudiantes>>(content);
        _estudiantes = new ObservableCollection<Estudiantes>(_mostrar);
        lvEstudiantes.ItemsSource = _estudiantes;
    }
}
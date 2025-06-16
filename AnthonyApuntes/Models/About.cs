namespace AnthonyApuntes.Models;

internal class About
{
    public string Title => AppInfo.Name;
    public string Version => AppInfo.VersionString;
    public string MoreInfoUrl => "https://aka.ms/maui";
    public string Name => "Anthony Morales";
    public string Description => "Estudiante de Ingeniería de Software";
    public string Hobbies => "Mis hobbies incluyen escuchar musica, jugar videojuegos y jugar futbol";
}
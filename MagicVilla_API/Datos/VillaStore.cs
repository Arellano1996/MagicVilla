using MagicVilla_API.Modelos.Dto;

namespace MagicVilla_API.Datos
{
    public static class VillaStore
    {
        public static List<VillaDto> villaList = new List<VillaDto>
        {
            new VillaDto{ Id=0, Nombre="Vista de Picina", Ocupantes = 3, MetrosCuadrados = 50},
            new VillaDto{ Id=1, Nombre="Vista a la Playa", MetrosCuadrados = 80, Ocupantes = 4 }
        };
    }
}

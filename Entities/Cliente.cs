using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Cliente
    {
        private int _id;
        private string _nombre;
        private string _calle;
        private string _numeroCalle;
        private string _numeroContacto;
        private string _colonia;
        private string _ciudadMunicipio;
        private string _RFC;
        private string _buscar;
        private DateTime _fecha;

        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string NumeroCalle { get => _numeroCalle; set => _numeroCalle = value; }
        public string NumeroContacto { get => _numeroContacto; set => _numeroContacto = value; }
        public string Colonia { get => _colonia; set => _colonia = value; }
        public string CiudadMunicipio { get => _ciudadMunicipio; set => _ciudadMunicipio = value; }
        public string RFC { get => _RFC; set => _RFC = value; }
        public string Buscar { get => _buscar; set => _buscar = value; }
        public DateTime Fecha { get => _fecha; set => _fecha = value; }
        public string Calle { get => _calle; set => _calle = value; }
    }
}

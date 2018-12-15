using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contro_unity.Clases
{
    class salon:Funciones
    {
        //PRODIEDADES DE LA CLASE
        //CONSTRUCTOR PARA REGISTRAR
        public int Id_salon { get; set; }
        public string Nom_salon { get; set; }
        public string Description_salon { get; set; }

        public salon() { }

        //CONSTRUCTOR DE LA CLASE
        //CONTRUCTOR PARA REGISTRAR
        public salon(string _nom_salon, string _description_salon)
        {
            this.Nom_salon = _nom_salon;
            this.Description_salon = _description_salon;
        }

        //CONSTRUCTOR DE LA CLASE
        //CONTRUCTOR PARA ACTUALIZAR
        public salon(string _nom_salon, string _description_salon,int _id_salon)
        {
            this.Nom_salon = _nom_salon;
            this.Description_salon = _description_salon;
            this.Id_salon = _id_salon;
        }

        //CONSTRUCTOR DE LA CLASE
        //CONSTRUCTOR PARA ELMINAR
        public salon(string _nom_salon)
        {
            this.Nom_salon = _nom_salon;

        }

        public int Registrar()
        {
            throw new NotImplementedException();
        }

        public bool Actualizar()
        {
            throw new NotImplementedException();
        }

        public bool Eliminar()
        {
            throw new NotImplementedException();
        }
    }
}

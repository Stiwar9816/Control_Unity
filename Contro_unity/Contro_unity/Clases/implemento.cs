using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contro_unity.Clases
{
    class implemento:Funciones
    {
        //PRODIEDADES DE LA CLASE
        public int Id_implements { get; set; }
        public int Cod_serie { get; set; }
        public string Nom_implements { get; set; }
        public string Datetime_register_implements { get; set; }
        public int Stock_implements { get; set; }
        public string Brand { get; set; }
        public string Description_implements { get; set; }

        public implemento() { }

        //CONSTRUCTOR DE LA CLASE
        //CONSTRUCTOR PARA REGISTRAR
        public implemento(int _cod_serie, string _nom_implements,string _datetime_register_implements,int _stock, string _brand, string _description_implements)
        {
            this.Cod_serie = _cod_serie;
            this.Nom_implements = _nom_implements;
            this.Datetime_register_implements = _datetime_register_implements;
            this.Stock_implements = _stock;
            this.Brand = _brand;
            this.Description_implements = _description_implements;
        }

        //CONSTRUCTOR DE LA CLASE
        //CONSTRUCTOR PARA REGISTRAR
        public implemento(int _cod_serie, string _nom_implements, string _datetime_register_implements, int _stock, string _brand, string _description_implements,int _id_implements)
        {
            this.Cod_serie = _cod_serie;
            this.Nom_implements = _nom_implements;
            this.Datetime_register_implements = _datetime_register_implements;
            this.Stock_implements = _stock;
            this.Brand = _brand;
            this.Description_implements = _description_implements;
            this.Id_implements = _id_implements;
        }

        //CONSTRUCTOR DE LA CLASE
        //CONSTRUCTOR PARA ELMINAR
        public implemento(int _cod_serie)
        {
            this.Cod_serie = _cod_serie;

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

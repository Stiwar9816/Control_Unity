using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contro_unity.Clases
{
    class profesor:Funciones
    {
        //PRODIEDADES DE LA CLASE
        public int Id_teacher { get; set; }
        public int Cc_teacher { get; set; }
        public string Nom_teacher { get; set; }
        public string Program_teacher { get; set; }

        public profesor() { }

        //CONSTRUCTOR DE LA CLASE
        //CONSTRUCTOR PARA REGISTRAR
        public profesor(int _cc_teacher,string _nom_teacher, string _program_teacher)
        {
            this.Cc_teacher = _cc_teacher;
            this.Nom_teacher = _nom_teacher;
            this.Program_teacher = _program_teacher;
        }

        //CONSTRUCTOR DE LA CLASE
        //CONSTRUCTOR PARA ACTUALIZAR
        public profesor(int _cc_teacher, string _nom_teacher, string _program_teacher, int _id_teacher)
        {
            this.Cc_teacher = _cc_teacher;
            this.Nom_teacher = _nom_teacher;
            this.Program_teacher = _program_teacher;
            this.Id_teacher = _id_teacher;

        }

        //CONSTRUCTOR DE LA CLASE
        //CONSTRUCTOR PARA ELMINAR
        public profesor(int _cc_teacher)
        {
            this.Cc_teacher = _cc_teacher;

        }

        //ACCIONES
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

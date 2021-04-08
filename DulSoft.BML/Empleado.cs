using Dapper;
using DulSoft.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DulSoft.BML
{
    public class Empleado
    {
        private DataAccess dataAccess = DataAccess.Instance();
        public int idEmpleado { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }
        public decimal sueldo { get; set; }
        public string telefono { get; set; }
        public string domicilio { get; set; }
        public bool activo { get; set; }
       
        public Empleado() { }
        public int Add()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@nombre", nombre);
            parametros.Add("@apellido", apellido);
            parametros.Add("@edad", edad);
            parametros.Add("@sueldo", sueldo);
            parametros.Add("@telefono", telefono);
            parametros.Add("@domicilio", domicilio);
            return dataAccess.Execute("stp_empleados_add", parametros);
        }
        public int Update()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idEmpleado", idEmpleado);
            parametros.Add("@nombre", nombre);
            parametros.Add("@apellido", apellido);
            parametros.Add("@edad", edad);
            parametros.Add("@sueldo", sueldo);
            parametros.Add("@telefono", telefono);
            parametros.Add("@domicilio", domicilio);
            return dataAccess.Execute("stp_empleados_update", parametros);
        }
        public List<Empleado> GetAll()
        {
            return dataAccess.Query<Empleado>("stp_empleados_getall");
        }
        public Empleado GetById()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idEmpleado", idEmpleado);
            return dataAccess.QuerySingle<Empleado>("stp_empleados_getbyid", parametros);
        }
        public int Delete()
        {
            var parametros = new DynamicParameters();
            parametros.Add("@idEmpleado", idEmpleado);
            return dataAccess.Execute("stp_empleados_delete", parametros);
        }
    }
}

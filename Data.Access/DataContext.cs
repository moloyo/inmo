namespace Inmobiliaria.DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DataContext : DbContext, IDataContext
    {
        // El contexto se ha configurado para usar una cadena de conexión 'DataModel' del archivo 
        // de configuración de la aplicación (App.config o Web.config). De forma predeterminada, 
        // esta cadena de conexión tiene como destino la base de datos 'Data.Access.DataModel' de la instancia LocalDb. 
        // 
        // Si desea tener como destino una base de datos y/o un proveedor de base de datos diferente, 
        // modifique la cadena de conexión 'DataModel'  en el archivo de configuración de la aplicación.
        public DataContext()
            : base("name=DataModel")
        {
        }

        // Agregue un DbSet para cada tipo de entidad que desee incluir en el modelo. Para obtener más información 
        // sobre cómo configurar y usar un modelo Code First, vea http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: global::System.Data.Objects.DataClasses.EdmSchemaAttribute()]

// Nombre de archivo original:
// Fecha de generación: 10/9/2022 10:43:40 p. m.
namespace WS_controlClima.modelo
{
    
    /// <summary>
    /// No hay ningún comentario para DBClimaModel.tblclima en el esquema.
    /// </summary>
    /// <KeyProperties>
    /// ideclima
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="DBClimaModel", Name="tblclima")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class tblclima : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// Crear un nuevo objeto tblclima.
        /// </summary>
        /// <param name="ideclima">Valor inicial de ideclima.</param>
        /// <param name="idezona">Valor inicial de idezona.</param>
        /// <param name="fechayhora">Valor inicial de fechayhora.</param>
        /// <param name="temperatura">Valor inicial de temperatura.</param>
        /// <param name="presipitacion">Valor inicial de presipitacion.</param>
        /// <param name="viento">Valor inicial de viento.</param>
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public static tblclima Createtblclima(int ideclima, int idezona, global::System.DateTime fechayhora, string temperatura, string presipitacion, string viento)
        {
            tblclima tblclima = new tblclima();
            tblclima.ideclima = ideclima;
            tblclima.idezona = idezona;
            tblclima.fechayhora = fechayhora;
            tblclima.temperatura = temperatura;
            tblclima.presipitacion = presipitacion;
            tblclima.viento = viento;
            return tblclima;
        }
        /// <summary>
        /// No hay ningún comentario para la propiedad ideclima en el esquema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public int ideclima
        {
            get
            {
                return this._ideclima;
            }
            set
            {
                this.OnideclimaChanging(value);
                this.ReportPropertyChanging("ideclima");
                this._ideclima = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("ideclima");
                this.OnideclimaChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private int _ideclima;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnideclimaChanging(int value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnideclimaChanged();
        /// <summary>
        /// No hay ningún comentario para la propiedad idezona en el esquema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public int idezona
        {
            get
            {
                return this._idezona;
            }
            set
            {
                this.OnidezonaChanging(value);
                this.ReportPropertyChanging("idezona");
                this._idezona = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("idezona");
                this.OnidezonaChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private int _idezona;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnidezonaChanging(int value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnidezonaChanged();
        /// <summary>
        /// No hay ningún comentario para la propiedad fechayhora en el esquema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public global::System.DateTime fechayhora
        {
            get
            {
                return this._fechayhora;
            }
            set
            {
                this.OnfechayhoraChanging(value);
                this.ReportPropertyChanging("fechayhora");
                this._fechayhora = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("fechayhora");
                this.OnfechayhoraChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private global::System.DateTime _fechayhora;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnfechayhoraChanging(global::System.DateTime value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnfechayhoraChanged();
        /// <summary>
        /// No hay ningún comentario para la propiedad temperatura en el esquema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public string temperatura
        {
            get
            {
                return this._temperatura;
            }
            set
            {
                this.OntemperaturaChanging(value);
                this.ReportPropertyChanging("temperatura");
                this._temperatura = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("temperatura");
                this.OntemperaturaChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private string _temperatura;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OntemperaturaChanging(string value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OntemperaturaChanged();
        /// <summary>
        /// No hay ningún comentario para la propiedad presipitacion en el esquema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public string presipitacion
        {
            get
            {
                return this._presipitacion;
            }
            set
            {
                this.OnpresipitacionChanging(value);
                this.ReportPropertyChanging("presipitacion");
                this._presipitacion = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("presipitacion");
                this.OnpresipitacionChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private string _presipitacion;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnpresipitacionChanging(string value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnpresipitacionChanged();
        /// <summary>
        /// No hay ningún comentario para la propiedad viento en el esquema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public string viento
        {
            get
            {
                return this._viento;
            }
            set
            {
                this.OnvientoChanging(value);
                this.ReportPropertyChanging("viento");
                this._viento = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("viento");
                this.OnvientoChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private string _viento;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnvientoChanging(string value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnvientoChanged();
    }
    /// <summary>
    /// No hay ningún comentario para DBClimaModel.tblzona en el esquema.
    /// </summary>
    /// <KeyProperties>
    /// idezona
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="DBClimaModel", Name="tblzona")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class tblzona : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// Crear un nuevo objeto tblzona.
        /// </summary>
        /// <param name="idezona">Valor inicial de idezona.</param>
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public static tblzona Createtblzona(int idezona)
        {
            tblzona tblzona = new tblzona();
            tblzona.idezona = idezona;
            return tblzona;
        }
        /// <summary>
        /// No hay ningún comentario para la propiedad idezona en el esquema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public int idezona
        {
            get
            {
                return this._idezona;
            }
            set
            {
                this.OnidezonaChanging(value);
                this.ReportPropertyChanging("idezona");
                this._idezona = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("idezona");
                this.OnidezonaChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private int _idezona;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnidezonaChanging(int value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnidezonaChanged();
        /// <summary>
        /// No hay ningún comentario para la propiedad zona en el esquema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute()]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public string zona
        {
            get
            {
                return this._zona;
            }
            set
            {
                this.OnzonaChanging(value);
                this.ReportPropertyChanging("zona");
                this._zona = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, true);
                this.ReportPropertyChanged("zona");
                this.OnzonaChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private string _zona;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnzonaChanging(string value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnzonaChanged();
    }
    /// <summary>
    /// No hay ningún comentario para DBClimaModel.tlbusuario en el esquema.
    /// </summary>
    /// <KeyProperties>
    /// ideusuario
    /// </KeyProperties>
    [global::System.Data.Objects.DataClasses.EdmEntityTypeAttribute(NamespaceName="DBClimaModel", Name="tlbusuario")]
    [global::System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [global::System.Serializable()]
    public partial class tlbusuario : global::System.Data.Objects.DataClasses.EntityObject
    {
        /// <summary>
        /// Crear un nuevo objeto tlbusuario.
        /// </summary>
        /// <param name="ideusuario">Valor inicial de ideusuario.</param>
        /// <param name="usuario">Valor inicial de usuario.</param>
        /// <param name="contraseña">Valor inicial de contraseña.</param>
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public static tlbusuario Createtlbusuario(int ideusuario, string usuario, string contraseña)
        {
            tlbusuario tlbusuario = new tlbusuario();
            tlbusuario.ideusuario = ideusuario;
            tlbusuario.usuario = usuario;
            tlbusuario.contraseña = contraseña;
            return tlbusuario;
        }
        /// <summary>
        /// No hay ningún comentario para la propiedad ideusuario en el esquema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public int ideusuario
        {
            get
            {
                return this._ideusuario;
            }
            set
            {
                this.OnideusuarioChanging(value);
                this.ReportPropertyChanging("ideusuario");
                this._ideusuario = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value);
                this.ReportPropertyChanged("ideusuario");
                this.OnideusuarioChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private int _ideusuario;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnideusuarioChanging(int value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnideusuarioChanged();
        /// <summary>
        /// No hay ningún comentario para la propiedad usuario en el esquema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public string usuario
        {
            get
            {
                return this._usuario;
            }
            set
            {
                this.OnusuarioChanging(value);
                this.ReportPropertyChanging("usuario");
                this._usuario = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("usuario");
                this.OnusuarioChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private string _usuario;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnusuarioChanging(string value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OnusuarioChanged();
        /// <summary>
        /// No hay ningún comentario para la propiedad contraseña en el esquema.
        /// </summary>
        [global::System.Data.Objects.DataClasses.EdmScalarPropertyAttribute(IsNullable=false)]
        [global::System.Runtime.Serialization.DataMemberAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public string contraseña
        {
            get
            {
                return this._contraseña;
            }
            set
            {
                this.OncontraseñaChanging(value);
                this.ReportPropertyChanging("contraseña");
                this._contraseña = global::System.Data.Objects.DataClasses.StructuralObject.SetValidValue(value, false);
                this.ReportPropertyChanged("contraseña");
                this.OncontraseñaChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private string _contraseña;
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OncontraseñaChanging(string value);
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        partial void OncontraseñaChanged();
    }
    /// <summary>
    /// No hay ningún comentario para DBClimaEntities1 en el esquema.
    /// </summary>
    public partial class DBClimaEntities1 : global::System.Data.Objects.ObjectContext
    {
        /// <summary>
        /// Inicializa un nuevo objeto DBClimaEntities1 usando la cadena de conexión encontrada en la sección 'DBClimaEntities1' del archivo de configuración de la aplicación.
        /// </summary>
        public DBClimaEntities1() : 
                base("name=DBClimaEntities1", "DBClimaEntities1")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Inicializar un nuevo objeto DBClimaEntities1.
        /// </summary>
        public DBClimaEntities1(string connectionString) : 
                base(connectionString, "DBClimaEntities1")
        {
            this.OnContextCreated();
        }
        /// <summary>
        /// Inicializar un nuevo objeto DBClimaEntities1.
        /// </summary>
        public DBClimaEntities1(global::System.Data.EntityClient.EntityConnection connection) : 
                base(connection, "DBClimaEntities1")
        {
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// No hay ningún comentario para tblclimas en el esquema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public global::System.Data.Objects.ObjectQuery<tblclima> tblclimas
        {
            get
            {
                if ((this._tblclimas == null))
                {
                    this._tblclimas = base.CreateQuery<tblclima>("[tblclimas]");
                }
                return this._tblclimas;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private global::System.Data.Objects.ObjectQuery<tblclima> _tblclimas;
        /// <summary>
        /// No hay ningún comentario para tblzonas en el esquema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public global::System.Data.Objects.ObjectQuery<tblzona> tblzonas
        {
            get
            {
                if ((this._tblzonas == null))
                {
                    this._tblzonas = base.CreateQuery<tblzona>("[tblzonas]");
                }
                return this._tblzonas;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private global::System.Data.Objects.ObjectQuery<tblzona> _tblzonas;
        /// <summary>
        /// No hay ningún comentario para tlbusuarios en el esquema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public global::System.Data.Objects.ObjectQuery<tlbusuario> tlbusuarios
        {
            get
            {
                if ((this._tlbusuarios == null))
                {
                    this._tlbusuarios = base.CreateQuery<tlbusuario>("[tlbusuarios]");
                }
                return this._tlbusuarios;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        private global::System.Data.Objects.ObjectQuery<tlbusuario> _tlbusuarios;
        /// <summary>
        /// No hay ningún comentario para tblclimas en el esquema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public void AddTotblclimas(tblclima tblclima)
        {
            base.AddObject("tblclimas", tblclima);
        }
        /// <summary>
        /// No hay ningún comentario para tblzonas en el esquema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public void AddTotblzonas(tblzona tblzona)
        {
            base.AddObject("tblzonas", tblzona);
        }
        /// <summary>
        /// No hay ningún comentario para tlbusuarios en el esquema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("System.Data.Entity.Design.EntityClassGenerator", "4.0.0.0")]
        public void AddTotlbusuarios(tlbusuario tlbusuario)
        {
            base.AddObject("tlbusuarios", tlbusuario);
        }
    }
}

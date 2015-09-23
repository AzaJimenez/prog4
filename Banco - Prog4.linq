<Query Kind="Program" />

void Main()
{
	organizacion org = new organizacion();
	organizacionCliente orgcl = new organizacionCliente();
	cliente client = new cliente();
	clienteCuenta clicue = new clienteCuenta();
	cuenta cuent = new cuenta();
	cuentaTarjeta cuentar = new cuentaTarjeta();
	tarjeta tarj = new tarjeta();
	tarjetaTransaccion tarjtrans = new tarjetaTransaccion();
	transaccion trans = new transaccion();
	
	//org.id = 0;
	
	Console.Write(org); //cuando imprime, se aprecia la clase completa
	//Console.Write(org.id); //cuando imprime se ve solo el valor de id dentro de la clase
	Console.Write(orgcl);
	Console.Write(client);
	Console.Write(clicue);
	Console.Write(cuent);
	Console.Write(cuentar);
	Console.Write(tarj);
	Console.Write(tarjtrans);
	Console.Write(trans);
}

// Define other methods and classes here
public class organizacion
{
	private int 	_id; //id se define con "_" para diferenciar el nombre del atributo y la variable
	private string 	_ruc;
	private string 	_nombre;
	private string 	_direccion;
	private int 	_telefono;
	private int 	_estado;
	
	// get: obtener valor del atributo de la clase
	// set: asigna un valor al tributo de la clase
	
	public int 		id 			{ get { return _id; } set { _id = value; }}
	public string 	ruc 		{ get { return _ruc; } set { _ruc = value; }}
	public string	nombre 		{ get { return _nombre; } set { _nombre = value; }}
	public string 	direccion	{ get { return _direccion; } set { _direccion = value; }}
	public int		telefono	{ get { return _telefono; } set { _telefono = value; }}
	public int		estado		{ get { return _estado; } set { _estado = value; }}
	
	//DataSet: espacio en memoria de C Sharp para almacenamiento de datos desde una DB
	
	//public DataSet consultar()	{ return; }
	//public bool adicionar() 	{ return; }	
	//public bool modificar()		{ return; }
}

public class organizacionCliente
{
	private int 	_id; 
	private int 	_idOrganizacion;
	private int 	_idCliente;
	private int 	_estado;
	
	public int 		id 				{ get { return _id; } set { _id = value; }}
	public int	 	idOrganizacion 	{ get { return _idOrganizacion; } set { _idOrganizacion = value; }}
	public int		idCliente 		{ get { return _idCliente; } set { _idCliente = value; }}
	public int	 	estado			{ get { return _estado; } set { _estado = value; }}
	
	//public DataSet consultar()	{ return; }
	//public bool adicionar() 	{ return; }	
	//public bool modificar()		{ return; }
}

public class cliente
{
	private int 	_id;
	private string 	_identificacion;
	private string	_apellido;
	private string 	_nombre;
	private string	_direccion;
	private string	_telefono;
	private string	_sexo;
	private string	_correoElec;
	private int		_estado;
	
	public int 		id 					{ get { return _id; } set { _id = value; }}
	public string 	identificacion 		{ get { return _identificacion; } set { _identificacion = value; }}
	public string	apellido			{ get { return _apellido; } set { _apellido = value; }}
	public string 	nombre				{ get { return _nombre; } set { _nombre = value; }}
	public string	direccion			{ get { return _direccion; } set { _direccion = value; }}
	public string	telefono			{ get { return _telefono; } set { _telefono = value; }}
	public string	sexo				{ get { return _sexo; } set { _sexo = value; }}
	public string	correoElec			{ get { return _correoElec; } set { _correoElec = value; }}
	public int		estado				{ get { return _estado; } set { _estado = value; }}
	
	//public DataSet consultar()	{ return; }
	//public bool adicionar() 	{ return; }	
	//public bool modificar()		{ return; }
}

public class clienteCuenta
{
	private int 	_id; 
	private int 	_idCliente;
	private int 	_idCuenta;
	private int 	_estado;
	
	public int 		id 			{ get { return _id; } set { _id = value; }}
	public int	 	idCliente 	{ get { return _idCliente; } set { _idCliente = value; }}
	public int		idCuenta 	{ get { return _idCuenta; } set { _idCuenta = value; }}
	public int	 	estado		{ get { return _estado; } set { _estado = value; }}
	
	//public DataSet consultar()	{ return; }
	//public bool adicionar() 	{ return; }	
	//public bool modificar()		{ return; }
}	

public class cuenta
{
	private int 		_id;
	private string 		_numeroCuenta;
	private string		_estatus;
	private DateTime 	_fechaApertura;
	private DateTime	_fechaCierre;
	private float		_saldo;
	private float		_limiteCredito;
	private float		_disponibleCompra;
	private DateTime	_fechaCorte;
	private int			_estado;
	
	public int 			id 					{ get { return _id; } set { _id = value; }}
	public string 		numeroCuenta 		{ get { return _numeroCuenta; } set { _numeroCuenta = value; }}
	public string		estatus				{ get { return _estatus; } set { _estatus = value; }}
	public DateTime 	fechaApertura		{ get { return _fechaApertura; } set { _fechaApertura = value; }}
	public DateTime		fechaCierre			{ get { return _fechaCierre; } set { _fechaCierre = value; }}
	public float		saldo				{ get { return _saldo; } set { _saldo = value; }}
	public float		limiteCredito		{ get { return _limiteCredito; } set { _limiteCredito = value; }}
	public float		disponibleCompra	{ get { return _disponibleCompra; } set { _disponibleCompra = value; }}
	public DateTime		fechaCorte			{ get { return _fechaCorte; } set { _fechaCorte = value; }}
	public int			estado				{ get { return _estado; } set { _estado = value; }}
	
	//public DataSet consultar()	{ return; }
	//public bool adicionar() 	{ return; }	
	//public bool modificar()		{ return; }
}

public class cuentaTarjeta
{
	private int 	_id; 
	private int 	_idCuenta;
	private int 	_idTarjeta;
	private int 	_estado;
	
	public int 		id 			{ get { return _id; } set { _id = value; }}
	public int	 	idCuenta 	{ get { return _idCuenta; } set { _idCuenta = value; }}
	public int		idTarjeta	{ get { return _idTarjeta; } set { _idTarjeta = value; }}
	public int	 	estado		{ get { return _estado; } set { _estado = value; }}
	
	//public DataSet consultar()	{ return; }
	//public bool adicionar() 	{ return; }	
	//public bool modificar()		{ return; }
}

public class tarjeta
{
	private int 		_id;
	private string 		_numeroCuenta;
	private string		_numeroTarjeta;
	private string 		_estatus;
	private string		_apellidoNombre;
	private DateTime	_fechaVencimiento;
	private int			_estado;
	
	public int 		id 					{ get { return _id; } set { _id = value; }}
	public string 	numeroCuenta 		{ get { return _numeroCuenta; } set { _numeroCuenta = value; }}
	public string	numeroTarjeta		{ get { return _numeroTarjeta; } set { _numeroTarjeta = value; }}
	public string 	estatus				{ get { return _estatus; } set { _estatus = value; }}
	public string	apellidoNombre		{ get { return _apellidoNombre; } set { _apellidoNombre = value; }}
	public DateTime	fechaVencimiento	{ get { return _fechaVencimiento; } set { _fechaVencimiento = value; }}
	public int		estado				{ get { return _estado; } set { _estado = value; }}
	
	//public DataSet consultar()	{ return; }
	//public bool adicionar() 	{ return; }	
	//public bool modificar()		{ return; }
}

public class tarjetaTransaccion
{
	private int 	_id; 
	private int 	_idTarjeta;
	private int 	_idTransaccion;
	private int 	_estado;
	
	public int 		id 				{ get { return _id; } set { _id = value; }}
	public int	 	idTarjeta 		{ get { return _idTarjeta; } set { _idTarjeta = value; }}
	public int		idTransaccion	{ get { return _idTransaccion; } set { _idTransaccion = value; }}
	public int	 	estado			{ get { return _estado; } set { _estado = value; }}
	
	//public DataSet consultar()	{ return; }
	//public bool adicionar() 	{ return; }	
	//public bool modificar()		{ return; }
}

public class transaccion
{
	private int 		_id;
	private string 		_numeroCuenta;
	private string		_numeroTarjeta;
	private float	 	_monto;
	private DateTime	_fechaTransaccion;
	private DateTime	_fechaPosteo;
	private string		_comercio;
	private string		_descripcion;
	private int			_estado;
	
	public int 			id 					{ get { return _id; } set { _id = value; }}
	public string 		numeroCuenta 		{ get { return _numeroCuenta; } set { _numeroCuenta = value; }}
	public string		numeroTarjeta		{ get { return _numeroTarjeta; } set { _numeroTarjeta = value; }}
	public float 		monto				{ get { return _monto; } set { _monto = value; }}
	public DateTime		fechaTransaccion	{ get { return _fechaTransaccion; } set { _fechaTransaccion = value; }}
	public DateTime		fechaPosteo			{ get { return _fechaPosteo; } set { _fechaPosteo = value; }}
	public string		comercio			{ get { return _comercio; } set { _comercio = value; }}
	public string		descripcion			{ get { return _descripcion; } set { _descripcion = value; }}
	public int			estado				{ get { return _estado; } set { _estado = value; }}
	
	//public DataSet consultar()	{ return; }
	//public bool adicionar() 	{ return; }	
	//public bool modificar()		{ return; }
}
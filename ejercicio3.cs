cliente micliente = new cliente("Xavier Molina", "0959538700", "Eloy Alfaro 1914" , "xeavi02@gmail.com", true);
Console.WriteLine(micliente);

public struct cliente
{

    public cliente(string nombre, string telefono, string direccion, string email, bool nuevo_cliente)
    {
        NOMBRE = nombre;
        TELEFONO = telefono;
        DIRECCION = direccion;
        EMAIL = email;
        NUEVO_CLIENTE = nuevo_cliente;
    }

    public string NOMBRE { get; }
    public string TELEFONO { get; }
    public string DIRECCION { get; }
    public string EMAIL { get; }
    public bool NUEVO_CLIENTE { get;  }

    public override string ToString()
    {
        return $"Nombre: {NOMBRE}\nTelefono: {TELEFONO}\nDireccion: {DIRECCION}\nEmail: {EMAIL}\nNuevo Cliente: {NUEVO_CLIENTE}";
    }

}

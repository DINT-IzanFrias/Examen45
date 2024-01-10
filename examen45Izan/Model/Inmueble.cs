using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.ComponentModel;

class Inmueble
{
    private string tipo;
    public string Tipo
    {
        get { return tipo; }
        set { tipo = value; }
    }

    private string zona;
    public string Zona
    {
        get { return zona; }
        set { zona = value; }
    }

    private string descripcion;
    public string Descripcion
    {
        get { return descripcion; }
        set { descripcion = value; }
    }

    private string imagen;
    public string Imagen
    {
        get { return imagen; }
        set { imagen = value; }
    }

    private bool reformar;
    public bool Reformar
    {
        get { return reformar; }
        set { reformar = value; }
    }

    private double precio;
    public double Precio
    {
        get { return precio; }
        set { precio = value; }
    }

    private string estado;

    public string Estado
    {
        get { return estado; }
        set { estado = value; }
    }


    public Inmueble(string tipo, string zona, string descripcion, string imagen, bool reformar, double precio, string estado)
    {
        this.Tipo = tipo;
        this.Zona = zona;
        this.Descripcion = descripcion;
        this.Imagen = imagen;
        this.Reformar = reformar;
        this.Precio = precio;
        this.Estado = estado;
    }

}

using System;
using System.Collections.Generic;

namespace HRV2.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public DateTime? Fecha { get; set; }

    public string? Posicion  { get; set; }

    public int Calificacion { get; set; }

    public Usuario(int calificacion)
    {
        Calificacion = calificacion;
    }
}

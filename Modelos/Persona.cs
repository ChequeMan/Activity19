﻿using System.ComponentModel.DataAnnotations;

namespace Catalogo.Modelos
{
    public class Persona
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "El domiciilio es requerido")]
        [StringLength(200, ErrorMessage = "Máximo 200 caracteres")]
        public string? Domicilio { get; set; }
        [Required(ErrorMessage = "El correo es requerido")]
        [EmailAddress(ErrorMessage = "Debe ser un correo válido")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? Correo { get; set; }
        [Required(ErrorMessage = "El teléfono es requerido")]
        [StringLength(10, ErrorMessage = "Máximo 10 caracteres")]
        public string? Telefono { get; set; }

        //Propiedades de navegación EF
        public int ClasificacionId { get; set; }
        virtual public Clasificacion? Clasificacion { get; set; }
    }
}
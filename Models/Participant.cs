using System.ComponentModel.DataAnnotations;


namespace RegistroComunitario.Models;


public enum Gender
{
    Femenino = 1,
    Masculino = 2,
    Otro = 3,
    PrefieroNoDecir = 4
}


public class Participant
{
    [Required(ErrorMessage = "La identificación es obligatoria.")]
    [StringLength(20, ErrorMessage = "La identificación no debe exceder {1} caracteres.")]
    public string Identification { get; set; } = string.Empty;


    [Required(ErrorMessage = "El nombre es obligatorio.")]
    [MinLength(3, ErrorMessage = "El nombre debe tener al menos 3 caracteres.")]
    public string FirstName { get; set; } = string.Empty;


    [Required(ErrorMessage = "Los apellidos son obligatorios.")]
    [MinLength(3, ErrorMessage = "Los apellidos deben tener al menos 3 caracteres.")]
    public string LastName { get; set; } = string.Empty;


    [Phone(ErrorMessage = "El teléfono no tiene un formato válido.")]
    [Display(Name = "Teléfono")]
    public string? Phone { get; set; }


    [Required(ErrorMessage = "El correo es obligatorio.")]
    [EmailAddress(ErrorMessage = "El correo no tiene un formato válido.")]
    public string Email { get; set; } = string.Empty;


    [Required(ErrorMessage = "El género es obligatorio.")]
    [EnumDataType(typeof(Gender), ErrorMessage = "Género inválido.")]
    [Display(Name = "Género")]
    public Gender? Gender { get; set; }


    [Required(ErrorMessage = "La edad es obligatoria.")]
    [Range(1, 120, ErrorMessage = "La edad debe estar entre 1 y 120.")]
    public int? Age { get; set; }
}
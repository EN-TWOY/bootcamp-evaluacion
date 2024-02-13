using System;
namespace Prueba.Api.Exceptions
{
	public class ErrorValidationModel : ErrorModel
	{
        public string? FieldName { get; set; }
    }
}


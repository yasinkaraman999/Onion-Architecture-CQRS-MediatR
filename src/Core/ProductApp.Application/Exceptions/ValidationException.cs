using System;
namespace ProductApp.Application.Exceptions
{
	public class ValidationException:Exception
	{
		public ValidationException():base("Validation error occured")
		{

		}

		public ValidationException(String Message): base(Message)
		{

		}

		public ValidationException(Exception ex) : this(ex.Message)
		{

		}
	}
}


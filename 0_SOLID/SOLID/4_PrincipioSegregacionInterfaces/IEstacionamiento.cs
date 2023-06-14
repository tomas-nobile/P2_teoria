using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._4_PrincipioSegregacionInterfaces
{
	public interface IEstacionamiento
	{

		void estacionarCoche(); // Reducir el recuento de lugares vacíos en 1
		void sacarCoche(); // Aumenta los lugares vacíos en 1
		void capacidadEstacionamiento(); // Devuelve la capacidad del del estacionamiento
		double calcularTarifa(Coche coche); // Devuelve el precio en función del número de horas de estacionamiento.
		void hacerPago(Coche coche);
	}
}

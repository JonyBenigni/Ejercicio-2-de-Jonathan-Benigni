using System;

class ejercicio2
{

	static void Main(string[] args)
	{
		double ax2;
		double by2;
		double by2; ;
		double cx;
		double dy;
		double e;
		Console.WriteLine("Utilizando esta funcion ----> Ax2+By2+Cx+Dy+E=0");
		Console.WriteLine("Ingrese los datos correspondientes para saber el tipo de conica");
		Console.Write(" Ingrese el dato Ax2 ");
		ax2 = Double.Parse(Console.ReadLine());
		Console.Write(" Ingrese el dato By2 ");
		by2 = Double.Parse(Console.ReadLine());
		Console.Write("Ingrese el dato Cx ");
		cx = Double.Parse(Console.ReadLine());
		Console.Write(" Ingrese el dato Dy ");
		dy = Double.Parse(Console.ReadLine());
		Console.Write(" Ingrese el dato E ");
		e = Double.Parse(Console.ReadLine());
		if (ax2 != 0 || by2 != 0)
		{
			Console.Write("Es una Parabola ");
		}
		if (ax2 != 0 && by2 != 0 && ax2 == by2)
		{
			Console.Write("Es una Circunferencia ");
		}
		if ((ax2 != 0 && by2 != 0) && (ax2 <= 0 || ax2 >= 0) && (by2 <= 0 || by2 >= 0) && ax2 != by2;) {
			Console.Write("Es un Elipse ");
		}
		if (ax2 != 0 && by2 != 0 && (ax2 <= 0 || by2 >= 0) && ax2 != by2)
		{
			Console.Write("Es un Hiperbola");
		}
	}

}

}


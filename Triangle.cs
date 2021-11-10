using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangle_uskoreva
{
	class Triangle
	{
		public double a; // первая сторона
		public double b; // вторая сторона
		public double c; // третья сторона

public Triangle(double A, double B, double C) //конструктор
{
			a = A; // создаем с заданными длинами сторон согласно заданию
			b = B;
			c = C;

}
public string outputA() // выводим сторону a, данный метод возращает строковое значение
{
			return Convert.ToString(a); // a - ссылка на внутреннее поле обьекта класса
}
public string outputB()
{
			return Convert.ToString(B); // выводим сторону b
}
public string outputC()
{
			return Convert.ToString(C); // выводим сторону c
}
public double Perimetr() // сумма всех сторон типа double
{
			double p = 0;
			p = a + b + c; // вычисление
			return p; //возрат
}
public double Surface() // аналогично периметру
		{
			double s = 0;
			double p = 0;
			p = (a + b + c) / 2;
			s = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
			return s;
		}

	}
}

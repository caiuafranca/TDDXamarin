using NUnit.Framework;
using System;

namespace TDDOlaMundo
{
	public class Itens
	{
		public string nome;
		public string tipo;
		public int life;

		public Itens(string fruta, string tipo, int life){
			this.nome = fruta;
			this.tipo = tipo;
			this.life = life;
		}
	}


}


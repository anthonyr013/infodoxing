/*created by: anthony_
 */ 
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;




namespace proyecto
{
	class Dox
	{
		public static void Main(string[] args)
		{
			try
			{
			Console.WriteLine("Bienvenidos A "+"InFoDoXiNg");
			
			Console.WriteLine("Herramienta recolectora de Datos Personales");
			
			Console.WriteLine("No me hago responsable por el mal uso de esto");
			
			Console.WriteLine("");
			Console.WriteLine("");
			
			Console.WriteLine("Primero para Acceder a esta herramienta"+"-"+"["+"escribe attack"+"]");
			string key = Console.ReadLine();
			
			
			
			if(key == "attack")
			{
				Console.WriteLine("haz puesto la key correcta"+"-"+"["+"dale a cualquier tecla"+"]");
			}
			else
			{
				Console.WriteLine("haz puesto la key incorreta"+"-"+"["+"no puedes acceder"+"]");
				return;
			}
			
			
			Console.ReadKey();
			Console.WriteLine("");
			Console.WriteLine("");
			
			
			
			Console.Write("Escribe el Nombre de la persona"+":");
			string nombre = Console.ReadLine();
			
			Console.Write("Escribe el Apellido de la persona"+":");
			string apellido = Console.ReadLine();
			
			Console.Write("Escribe el Correo de la persona"+":");
			string correo = Console.ReadLine();
			
			
			Console.Write("Escribe la Edad de la persona"+":");
			string edad = Console.ReadLine();
			
			Console.Write("Escribe la nacionalidad de la persona"+":");
			string nacionalidad = Console.ReadLine();
			
			Console.Write("==============================================");
			Console.WriteLine("");
			
			Console.Write("Escribe la Direcion o link de geolocalizacion de la persona"+":");
			string direccion = Console.ReadLine();
			
			Console.Write("Escribe la ip numerica de la persona"+":");
			string ip = Console.ReadLine();
			
			Console.Write("Escribe las Redes sociales de la persona"+":");
			string redsocial = Console.ReadLine();
			
			Console.Write("============================================");
			Console.WriteLine("");
			
			Console.Write("pon un link con fotos o videos de la persona"+":");
			string identidad = Console.ReadLine(); 
            
            Console.Write("Escribe la targeta de credito de la persona"+":");
			string credito = Console.ReadLine();

            Console.Write("Escribe falso o verdadero si esta persona murio o no"+":");
			string muerte = Console.ReadLine();	
            
			Console.Write("Escribe falso o verdadero si esta persona esta desaparecidad"+":");
			string desaparicion = Console.ReadLine();	
            			
			Console.Write("============================================");
			Console.WriteLine("");
			
			Console.WriteLine("Tus Datos Ya Estan Miralos en el Archivo Creado");
			Console.WriteLine("["+"llamado Datos es un txt Se Encuenta en la misma carpeta"+"]");
			
	     
			StreamWriter sw = new StreamWriter("C:Datos.txt",true);
			              
			sw.WriteLine("Nombre de la persona"+":"+nombre);
			
			sw.WriteLine("Apellido de la persona"+":"+apellido);
	
			sw.WriteLine("Correo de la persona"+":"+correo); 
            
            sw.WriteLine("Edad de la persona"+":"+edad);

            sw.WriteLine("nacionalidad de la persona"+":"+nacionalidad);          
		    
            sw.WriteLine("=====================================================");
            sw.WriteLine("");
            
            sw.WriteLine("direccion de la persona"+":"+direccion);
            
            sw.WriteLine("ip numerica de la persona"+":"+ip);
            
            sw.WriteLine("Redes Sociales de la persona"+":"+redsocial);
            
            sw.WriteLine("=====================================================");
            sw.WriteLine("");
            
            sw.WriteLine("fotos/videos de la persona"+":"+identidad);
            
            sw.WriteLine("targeta de credito de la persona"+":"+credito);
            
            sw.WriteLine("Esta Muerto esta persona"+":"+muerte);
            
            sw.WriteLine("Esta Desaparecido/a esta persona"+":"+desaparicion);
            
            sw.WriteLine("============================================");
            
            sw.Close();
            
            }
			catch(UnauthorizedAccessException e)
			{
				Console.WriteLine(e.Message);
			}
			
			
     
		}
	}
}

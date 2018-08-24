using System;

namespace myApp
{
	public abstract class A 
	{ 
		private int _x; 
		private int _y; 
		
		public int X
		{ 
			get{ 
				return _x; 
			} 
			
			set { 

				if (value < 0 ) { 
					throw new Exception ("Value is less than 0"); 
				} 
				else { 
					_x = value; 
				} 
			} 
		} 

		public int Y 
		{ 
			get { 
				return _y; 
			} 
			set { 
				if (value <  0) throw new Exception("Value is less than 0");				  else { 
					_y = value; 
				} 
			} 
		} 

		public abstract int Area(); 
		public abstract A Clone(); 
	} 

	public class B  : A 
	{ 
		public override int Area() 
		{ 
			return X * Y; 
		}	

		public void Print() 
		{ 
			Console.WriteLine($"x = {X}, y = {Y}");
		} 

		public override A Clone() 
		{ 
			return (B) this.MemberwiseClone(); 
		}

	} 

	public class C : B 
	{ 

	} 

    class Program
    {
        static void Main(string[] args)
        {
			A a = new B(); 
			int x = 0, y = 0; 
		
			try { 
				Console.WriteLine("Enter value for x: "); 
				x = Convert.ToInt32(Console.ReadLine()); 
				Console.WriteLine("Enter value for y: "); 
				y = Convert.ToInt32(Console.ReadLine()); 
				
			} 
			catch (Exception e) { 
				Console.WriteLine(e.Message); 
			} 

			a.X = x; 
			a.Y = y; 

			((B)a).Print();  // Down cast 
			
	
			B b = (B)a; // deep copy 
			// b.Clone(); 
			
			Console.WriteLine("Before change:" ); 	
			b.Print(); 
			
			a.X = 34; 
			a.Y = 43; 

			Console.WriteLine("After change:" ); 	
			b.Print(); 
		
        }
    }
}

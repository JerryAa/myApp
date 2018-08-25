using System; 

namespace myApp 
{ 

	public class D
	{	


		private int [] arr = new int[10]; 

		public void Run() 
		{ 
			Console.WriteLine("Inside Run()"); 
		} 
		
		public int this[int index]
		{ 
			get	
			{ 
				if (index < 0 && index >= arr.Length) 
				{ 
					throw new IndexOutOfRangeException("Index is out of range");	
				} 		
				else 
				{ 
					return arr[index]; 
				} 

			} 
			set 
			{ 
				if (index < 0 && index >= arr.Length) 
					throw new IndexOutOfRangeException("Index is out of range");	
				else 
				{ 
					arr[index] = value;
				} 
			
			} 

		} 

	} 

} 

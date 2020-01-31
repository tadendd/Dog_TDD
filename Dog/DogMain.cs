using System;

namespace Dog
{
	public class Dog
	{

		public static int age;
		
		
		public static String name;
		public static void Main(string[] args)
		{
			Console.WriteLine("The Final Result:" + toString(age, name));
			Console.WriteLine("Dog Years: " + calcDogYears(age)); 
		}

		/**
 * Empty-argument constructor to put object
 * into a consistent state.
 */
		public Dog()
		{
		
		}//end constructor

		/**
		 * Constructor accepts the age and
		 * name of the dog. This is the preferred
		 * constructor.
		 * @param age
		 * @param name
		 */
		public Dog(int age, String name)
		{

			this.setAge(age);
			this.SetName(name);

		}//end constructor

		public static int calcDogYears(int age)
		{
			int dogYears = 15 + (age - 1) * 7;
			return dogYears;
		}

		/**
		 * Getter for age
		 * @return
		 */
		public int getAge()
		{
			return age;
		}//end getAge

		/**
		 * Setter for age
		 * Checks the bounds so 
		 * @param age
		 */
		public void setAge(int age)
		{
			if (age < 0)
				age = 0;
			else
				age = age;
		}//end setAge

		/**
		 * Getter for name
		 * @return
		 */
		public String getName()
		{
			return name;
		}//end getName

		/**
		 * Setter for name. Ensures that only
		 * alpha characters are allowed in the name.
		 * @param name
		 */
		public char[] SetName(string name)
		{
			bool valid = true;
			char[] c = name.ToCharArray();


			for (char n; ;) ;
			{
				return c;
			}

			if (valid == true)
				name = name;
			else
				name = "";

		}//end setName

		
		public static string toString(int age, String name)
		{
			Console.WriteLine("Enter Age:");
			age = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter Name:");
			name = Convert.ToString(Console.ReadLine());

			return "Dog [age= " + age + ", name= " + name + "]";
			
		}//end toString

		
	}//end class	
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog_AST
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog(5, "Fido");
            Console.WriteLine(dog.getName() + " is " + dog.calcDogYears() + " years old in dog years!");
            dog.setAge(8);
            Console.WriteLine(dog.getAge());
            Console.WriteLine(dog.toString());
            System.Threading.Thread.Sleep(10000);
        }
    }
    /**
	 * This class is a converted copy of the Dog.java class written by Dr. Robert Kelley.
	 * 
	 * @author: Andrew Tanner
	 * @version: 2.0
	 */
    class Dog
    {
        private int age;
        private String name;
        
        /**
         * Empty-argument constructor to put object
         * into a consistent state.
         */
        public Dog()
        {
            age = 0;
            name = "";
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
            this.setName(name);

        }//end constructor

        public int calcDogYears()
        {
            int dogYears = 15 + (this.age - 1) * 7;
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
                this.age = 0;
            else
                this.age = age;
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
        public void setName(String name)
        {
            bool valid = true;
            char[] n = name.ToCharArray();

            foreach (char c in n)
            {
                if (!char.IsLetter(c))
                {
                    valid = false;
                    break;
                }
            }

            if (valid)
                this.name = name;
            else
                this.name = "";

        }//end setName
        public String toString()
        {
            return "Dog [age=" + age + ", name=" + name + "]";
        }//end toString

    }//end class

}

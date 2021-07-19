

class Person {
    private int age {get; set;}

	public Person(int initialAge) {
        if (initialAge < 0)
        {
            Console.WriteLine("Age is not valid, setting age to 0.");
            age = 0;
        }
        else
        {
            age = initialAge;
        }
     }
     public void amIOld()
     {
        Console.WriteLine(
            age < 13 ? "You are young." :
            age >= 13 && age < 18 ? "You are a teenager." :
            "You are old."
        );
     }

     public void yearPasses() {
        age++;
     }

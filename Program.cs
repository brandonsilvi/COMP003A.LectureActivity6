using System;

namespace COMP003A.LectureActivity6
{
    class Program
    {
        static void Main(string[] args)
        {
            //2 student objects
            Student student1 = new Student("Alex", 20);
            Student student2 = new Student("Jordan", 22);

            //call instance methods
            student1.DisplayInfo();
            student2.DisplayInfo();

            //modifying one object
            student1.Age = 32;

            //display again
            student1.DisplayInfo();
            student2.DisplayInfo();
        }
    }

}
/* Reflection:
1. Each Student object has its own data because we use the constructor with the new keyword this results
in a seperate instance of student class being created in mmebory with its own Name and Age stored on its own
2. Main doesnt need to know because it calls the method using dot notation.
3. We use encapsulation by having the Student class group its own data and the command that operates on that 
data. The internal implementation is contained in the class and the rest of the program just interacts with it.
*/
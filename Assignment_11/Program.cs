namespace Assignment_11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // *******   OOP 05 – Smart Delivery Management System **********
            //    Part 01 : Theoretical Questions   //

            #region  Question 1 (object copying)

            // a) What happens when you assign one object variable to another object variable?
            // when you assign one object variable to another object variable, both variables will reference the same object in heap.


            //  b) Does assigning one object to another create a new object? Explain.
            // no , assigning one object to another does not create a new object. It simply copies the
            // reference of the original object to the new variable, so both variables point to the same object in memory.


            // c) What is the difference between copying an object and copying its reference?
            // copying an object creates anew independent object in memory , while copying its reference makes both variables point to the same object in memory.
            // Changes made to one variable will affect the other when copying reference, but not when copying an object.


            #endregion


            

        }
    }
}

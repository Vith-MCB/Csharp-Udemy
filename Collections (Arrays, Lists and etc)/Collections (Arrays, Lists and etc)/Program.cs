/*Defining arrays

float[] grades = new float[5]; //Defining int array with 5 positions
float sumGrades = 0, grade;

string gradeString;

//Here, the program saves every grade in a array pos (not worthit bc of 2 for loops usage)
for(int i = 0; i < grades.Length; i++)
{
    Console.WriteLine("Grade: ");
    gradeString = Console.ReadLine();

    bool sucess = float.TryParse(gradeString, out grade);
    if (sucess)
    {
        grades[i] = grade;
    }
}

double AverageCalc(int totalOfStudents, float SumOfrades)
{
    return SumOfrades / totalOfStudents;
}

//Sum of grades
for (int i = 0; i < grades.Length; i++)
{
    sumGrades += grades[i];
}

double average = AverageCalc(grades.Length, sumGrades);

Console.WriteLine("Average = {0}", average);

*/

/*FOREACH LOOPS


string[] friends = {"Guto", "Jao", "Usfi", "Mateus", "Alan"};

int counter = 0;
foreach (string name in friends)
{
    Console.WriteLine("Hi, {0}, is nice to meet you!", name);
}

 */
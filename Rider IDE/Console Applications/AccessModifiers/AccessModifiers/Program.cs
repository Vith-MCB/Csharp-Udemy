//Marking fields and methods with access modifiers increases the safeness of the code 

#region Private Modifier
//private - only accessible INSIDE A CLASS or struct

class personPrivate
{
    private int age = 18; //Private variable

    private void Walk() {} //Private function
}

public void MainPrivate()
{
    personPrivate firstPerson = new personPrivate();
    int i = firstPerson.age; //ERROR
    firstPerson.Walk(); //ERROR
    //age and Walk() are not accessible from another class
}

#endregion

#region Public Modifier
//public  - accessible from everywhere in your project

class personPublic
{
    public int age = 20; //Public variable
    public void Talk(){} //Public function
}

public void MainPublic()
{
    personPublic secondPerson = new personPublic();
    int j = secondPerson.age; // j = 20
    secondPerson.Talk();
    //age and Talk() are accessible from another class
}

#endregion

#region Protected Modifier
//protected  - accessible from THE CLASS AND ALL CLASSES THAT DERIVE FROM IT

class personProtected
{
    public int age = 22; //Protected variable
    public void Run(){} //Protected function
}

class personProtected2 : personProtected
{
    int ageProtected = age; //Protected variable
    //age and Run() are accessible because this class is derived
}

#endregion



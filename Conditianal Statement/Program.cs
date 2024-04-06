internal class Program
{
    private static void Main(string[] args)
    {
        //If Condition
        int x=10;
        if (x>5){
            System.Console.WriteLine("YES it is true!");
        }


        // If -else condition
        int y=10;
        if(y>10){
            System.Console.WriteLine("Y is Greater then 10.");
        }
        else{
            System.Console.WriteLine("Y is Less then 10.");
        }


        // If-else and else if
        int z=33;
        if(z<=20){
                System.Console.WriteLine("Value is less than or equal to 20");
        }
        else if(z<=40){
            System.Console.WriteLine("Value is Greater than 20 but less than or equal to 40");
        }
        else{
            System.Console.WriteLine("Value Greater than 40");
        }


        // nested if else 
        int age=10;
        bool isDL=true;
        if(age>=18){
            if(isDL){
                System.Console.WriteLine("YOU CAN DERIVE");
            }
            else{
                System.Console.WriteLine("Please make first DL");
            }
        }
        else{
            System.Console.WriteLine("You Are Kid and you can'nt derive");
        }

        
        // Switch Case
        System.Console.Write("Chose A Number(1 to 7):");
        int num=Convert.ToInt32(Console.ReadLine());
        switch(num){
            case 1:
                System.Console.WriteLine("Monday");
                break;
            case 2:
                System.Console.WriteLine("Tuesday");
                break;
            case 3:
                System.Console.WriteLine("Wednesday");
                break;
            case 4:
                System.Console.WriteLine("Thursday");
                break;
            case 5:
                System.Console.WriteLine("Friday");
                break;  
            case 6:
                System.Console.WriteLine("Saturday"); 
                break;
            case 7:
                System.Console.WriteLine("Sunday");
                break; 
            default:
                System.Console.WriteLine("Enter with in range");
                break;                
        }
    }
}
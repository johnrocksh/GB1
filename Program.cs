//1. В переменной string есть секретное сообщение, во второй есть пароль.
//Пользователю программы даётся 3 попытки ввести пароль и увидеть секретное сообщение.

String Password = "Normik789";
String SecretMsg= "Secret";

int atemption = 3;

Console.WriteLine("Hi. You have only 3 attemption to enter password.");    

while(atemption >=0 )
{
    Console.WriteLine("Please Enter Password:");
    var str = Console.ReadLine();

    if(Password == str)
    {      
        Console.WriteLine("The password is correct");
        Console.WriteLine($"The Secret Message is '{SecretMsg}'");
        return;
    }   
    else
    {
       atemption--;
        
        if(atemption==0)
        {
            Console.WriteLine($"You have exhausted all attempts");    
            return;
        }
        else
        {
            Console.WriteLine($"Error. \n you only have { atemption } attempts left");
             Console.WriteLine($"Please try again..");
        }                
    }        
}
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string homePhoneNumber = "123456789"; 
        string mobilePhoneNumber = "+123456789";
        string email = "example@gmail.com"; 
        string fullName = "Иванов Иван Иванович"; 

        
        string patternHomePhoneNumber = @"^\d{7,15}$";
        string patternMobilePhoneNumber = @"^\+?\d{7,15}$";
        string patternEmail = @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$";
        string patternFullName = @"^\S{2,20}\s\S{2,20}\s\S{2,20}$";

        
        Console.WriteLine("Домашний номер телефона: " + Regex.IsMatch(homePhoneNumber, patternHomePhoneNumber));
        Console.WriteLine("Мобильный номер телефона: " + Regex.IsMatch(mobilePhoneNumber, patternMobilePhoneNumber));
        Console.WriteLine("Email: " + Regex.IsMatch(email, patternEmail));
        Console.WriteLine("ФИО клиента: " + Regex.IsMatch(fullName, patternFullName));
    }
}
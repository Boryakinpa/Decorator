using Decorator;

internal class Program
{
    private static void Main(string[] args)
    {
        List<string> administrators = new List<string>() { "admin", "manager", "sysadmin" };
        Notifier notifier = new Notifier(administrators);
        notifier.Send("отвал видеочипа спасите");
        Decorator.Decorator decoratorSms = new DecoratorSms();
        Decorator.Decorator decoratorFaceBook = new DecoratorFacebook();
        decoratorSms.SetComponent(notifier);
        decoratorFaceBook.SetComponent(notifier);
        decoratorSms.Send("админ привет", "admin");
        decoratorFaceBook.Send("Всё сломалось", "sysadmin");
        decoratorFaceBook.Send("Всё сломалось", "sysadamin");
    }
}
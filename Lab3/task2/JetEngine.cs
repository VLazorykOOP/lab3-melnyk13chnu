namespace pro100user.task2;

//Реактивний двигун
public class JetEngine : DieselEngine
{
    public override void Show()
    {
        Console.WriteLine("Реактивний двигун <- Дизельний двигун <- Двигун внутрішнього згорання <- Двигун");
    }
}
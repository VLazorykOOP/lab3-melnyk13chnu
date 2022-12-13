namespace pro100user.task2;

//Дизельний двигун
public class DieselEngine : InternalCombustionEngine
{
    public override void Show()
    {
        Console.WriteLine("Дизельний двигун <- Двигун внутрішнього згорання <- Двигун");
    }
}
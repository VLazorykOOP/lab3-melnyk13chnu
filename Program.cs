using System;
using pro100user.task2;

namespace pro100user
{
    /*
     * Лабараторна робота №3
     * Мельник Ганни група 341ск
     * Варіант 12
     * Створити клас із полями, конструкторами, методами та властивостями.
     * До запропонованих полів, методів та властивостей можете додавати власні
     * 1.2. Створити клас Triangle (трикутник), розробивши такі елементи класу:
     *  - Поля (захищені):
     *      - сторони (int a, b, c);
     *      - колір трикутника ( int сolor );
     *  - Конструктор, що дозволяє створити екземпляр класу з заданими довжинами сторін.
     *  - Методи, що дозволяють:
     *      - вивести довжини сторін трикутника;
     *      - розрахувати периметр трикутника;
     *  - Властивості:
     *      - розрахувати площу трикутника.
     *      - дозволяє отримати-встановити довжини сторінтрикутника (доступні для читання і запису),
     *        запис повинен здійснюватися з існування трикутника;
     *      - отримати колір (доступна тільки для читання).
     *
     *
     * Побудувати ієрархію класів відповідно до варіанта завдання.
     * Згідно завдання вибрати базовий клас та похідні.
     * Вкласах задати поля, які характерні для кожного класу.
     * Для всіх класів розробити метод Show(), який виводить дані про об’єкт класу.
     * 2.12. Двигун, двигун внутрішнього згоряння, дизельний двигун, реактивний двигун.
     */
    public class Lab3
    {
        static void Main()
        {
            Console.WriteLine("Завдання 1:");
            task1();
            Console.WriteLine("\n\nЗавдання 2:");
            task2();
        }

        private static void task1()
        {
            Triangle triangle = new Triangle(1, 3, 4, "blue");
            Console.WriteLine(triangle.ToString());
            triangle.A = 10;
            Console.WriteLine(triangle.ToString());
            Console.WriteLine("Triangle perimeter = " + triangle.GetPerimeter());
            Console.WriteLine("Triangle area = " + triangle.GetArea());
        }

        private static void task2()
        {
            Engine engine = new Engine();
            InternalCombustionEngine internalCombustion = new InternalCombustionEngine();
            DieselEngine dieselEngine = new DieselEngine();
            JetEngine jetEngine = new JetEngine();
            engine.Show();
            internalCombustion.Show();
            dieselEngine.Show();
            jetEngine.Show();
        }
    }
}


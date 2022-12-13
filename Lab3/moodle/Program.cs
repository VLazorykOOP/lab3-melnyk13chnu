namespace pro100user 
{
    /*
     * Лабараторна робота №3
     * Мельник Ганни група 341ск
     * Варіант 12
     */
    public class Lab3Moodle
    {
        public static void Main1()
        {
            Console.WriteLine("Завдання 1:");
            task1();
            Console.WriteLine("\n\nЗавдання 2:");
            task2();
        }

        #region task1

        /*
         * Створити клас із полями, конструкторами, методами та властивостями.
         * До запропонованих полів, методів та властивостей можете додавати власні
         * 1.2. Створити клас Triangle (трикутник), розробивши такі елементи класу:
         * - Поля (захищені):
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
         */
        
        private class Triangle
        {
            private int a, b, c;
            private string color;

            public Triangle() {}

            public Triangle(int a, int b, int c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }

            public Triangle(int a, int b, int c, string color)
            {
                this.a = a;
                this.b = b;
                this.c = c;
                this.color = color;
            }

            public int GetPerimeter()
            {
                return a + b + c;
            }

            public double GetArea()
            {
                int p = GetPerimeter() / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));  
            }
    
            public override string ToString()
            {
                return "Triangle {a: " + a + ", b: " + b + ", c: " + c + ", color: " + color + "}";
            }

            public int A
            {
                get => a;
                set => a = value;
            }
    
            public int B
            {
                get => a;
                set => a = value;
            }
    
            public int C
            {
                get => a;
                set => a = value;
            }

            public string Color => color;
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
        
        #endregion

        #region task2
        
        /*
         * Побудувати ієрархію класів відповідно до варіанта завдання.
         * Згідно завдання вибрати базовий клас та похідні.
         * Вкласах задати поля, які характерні для кожного класу.
         * Для всіх класів розробити метод Show(), який виводить дані про об’єкт класу.
         * 2.12. Двигун, двигун внутрішнього згоряння, дизель, реактивний двигун.
         */
        
        
        //Двигун
        public class Engine
        {
            public virtual void Show()
            {
                Console.WriteLine("Двигун");
            }
        }
        
        //Двигун внутрішнього згорання
        public class InternalCombustionEngine : Engine
        {
            public override void Show()
            {
                Console.WriteLine("Двигун внутрішнього згорання <- Двигун");
            }
        }
        
        //Дизельний двигун
        public class DieselEngine : InternalCombustionEngine
        {
            public override void Show()
            {
                Console.WriteLine("Дизельний двигун <- Двигун внутрішнього згорання <- Двигун");
            }
        }
        
        //Реактивний двигун
        public class JetEngine : DieselEngine
        {
            public override void Show()
            {
                Console.WriteLine("Реактивний двигун <- Дизельний двигун <- Двигун внутрішнього згорання <- Двигун");
            }
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
        
        #endregion
    }
}


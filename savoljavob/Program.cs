class Program
{
    static string question = "";
    static string javobA = "";
    static string javobB = "";
    static string javobC = "";
    static string javobD = "";
    static string CorrectAnswer = "";


    public static void Main()
    {
        int Menu = 0;

        do
        {
        int menu = testMenu();

            if(menu == 1)
            {
                Defaultest();
            }
            else if(menu == 2)
            {
                AddTest();
            }
            else if(menu == 3)
            {
            
            }
            else if(menu == 4)
            {
                System.Console.WriteLine("Chiqish uchun biror tugmani bosing...");
                Console.ReadKey();
            }
            else
            {
                System.Console.WriteLine("Siz xato menu kirtingiz");
                testMenu();
            }
        }
        while(Menu != 5);

        static void AddTest()
        {
            while(true)
            {
                
                inputTest();

                if(question.Trim().Length > 0  && javobA.Trim().Length > 0 && javobB.Trim().Length > 0 && javobC.Trim().Length > 0 && javobD.Trim().Length > 0 && CorrectAnswer.Trim().Length > 0)
                {
                    Console.WriteLine("Sizning testingiz muvoffaqqiyatli qo'shildi!");
                }
                else
                {
                    Console.WriteLine("Sizning testingizda hatto topildi!");
                }
            }
        }

        static void inputTest()
        {
            Console.Write("Savol kiriting: ");
            question = Console.ReadLine()!;
            Console.Write("A- ni kiriting: ");
            javobA = Console.ReadLine()!;
            Console.Write("B-ni kiriting: ");
            javobB = Console.ReadLine()!;
            Console.Write("C-ni kiriting: ");
            javobC = Console.ReadLine()!;
            Console.Write("D-ni kiriting: ");
            javobD = Console.ReadLine()!;
            Console.Write("To'g'ri javobni kiriting: ");
            CorrectAnswer = Console.ReadLine()!;
        }

        static void Defaultest()
        {
            int b = 1;
            int k = 0;
            string t;
            key:
            if(b == 1)
            {
            System.Console.WriteLine("1.C# da Contatains ethodi nima vazifani bajaradi?");
            System.Console.WriteLine("A)birnima");
            System.Console.WriteLine("B)birnima");
            System.Console.WriteLine("C)birnima");
            System.Console.WriteLine("D)birnima");
            t = Console.ReadLine()!;
            if(t.ToUpper() == "B")
            {
                k++;
            }
            b++;
            goto key;
            }
            System.Console.WriteLine("To'g'ri jovoblar soni: " + k);
        }

        static int testMenu()
        {
            System.Console.WriteLine("1 -> Test ishlash");
            System.Console.WriteLine("2 -> Test qo'shish");
            System.Console.WriteLine("3 -> Testlarim");
            System.Console.WriteLine("4 -> Chiqish");

            System.Console.WriteLine();
            System.Console.WriteLine("Menu ni tanlang ");
            int menu = int.Parse(Console.ReadLine()!);
            return menu;
        }
    }
}
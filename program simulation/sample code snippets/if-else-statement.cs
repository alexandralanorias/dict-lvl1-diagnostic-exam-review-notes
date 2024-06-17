class IfElse {
    static void Main(string[] args) {
        int grade = 0;

        Console.Write(Input grade: );
        grade = Convert.ToInt32(Console.ReadLine());

        if(grade == 100) {
            Console.Write("Excellent!");
        }
            else if(grade >= 90 && grade <= 99) {
                Console.Write("Very Good!");
            }
                else if(grade >= 80 && grade <= 89) {
                    Console.Write("Very Good!");
                }
    }
}
namespace ForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("         ********** Mini School App **********");
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine();
            Dictionary<string, int> studentGrades = new Dictionary<string, int>();
            Dictionary<string, string> studentStatuses = new Dictionary<string, string>();

            // öğrenci notları ve başarı durumlarını dictionary'e ekliyoruz
            studentGrades.Add("Ahmet", 90);
            studentGrades.Add("Mehmet", 70);
            studentGrades.Add("Ayşe", 80);
            studentGrades.Add("Fatma", 60);
            studentGrades.Add("Ali", 95);
            studentGrades.Add("Can", 75);
            studentGrades.Add("Burak", 85);
            studentGrades.Add("Zeynep", 80);
            studentGrades.Add("Deniz", 75);
            studentGrades.Add("Gökçe", 65);
            int vote; //Burada yapılacak işlem için bir değer ataması yapılıyor
            string[] students = { "Ahmet", "Mehmet", "Ayşe", "Fatma", "Ali", "Can", "Burak", "Zeynep", "Deniz", "Gökçe" };
            int[] grades = new int[10]; // Her öğrenci için bir not kaydedeceğimiz için notlar için bir dizi oluşturuyoruz.

            Console.WriteLine("vote 1 : Student List \nvote 2 : New Student Registration \nvote 3 : information about the student \n");
            Console.WriteLine();

            vote = Convert.ToInt32(Console.ReadLine());//Kullanıcıdan seçim işlemi için değer alımı
            if (vote == 1)
            {
                Console.WriteLine();
                Console.WriteLine("Student List");
                Console.WriteLine();
                int i = 1;
                foreach (string student in students)
                {
                    Console.WriteLine(i + ". " + student);
                    i++;
                }
                Console.WriteLine();
                Console.WriteLine($"There are {i - 1} students here");
            }
            else if (vote == 2)
            {
                Console.WriteLine();
                Console.WriteLine("Please enter the name of the student you want to enroll.");
                string newStudent = Console.ReadLine();

                // Yeni öğrenci ismini mevcut öğrenci listesine ekleyin
                Array.Resize(ref students, students.Length + 1);
                students[students.Length - 1] = newStudent;

                Console.WriteLine();
                Console.WriteLine($"Student {newStudent} has been added to the student list.");
                Console.WriteLine();
                //Öğrenci Listesini Tekrardan yazdırma.
                Console.WriteLine("New student List");
                Console.WriteLine();
                int i = 1;
                foreach (string student in students)
                {
                    Console.WriteLine(i + ". " + student);
                    i++;
                }
                Console.WriteLine();
                Console.WriteLine($"There are {i - 1} students here");
            }
            else if (vote == 3)
            {
                Console.WriteLine();
                Console.WriteLine("Please enter which student you want to receive information about.");
                string studentName = Console.ReadLine();

                // Öğrenci listesinde öğrencinin indeksini bulun
                int studentIndex = Array.IndexOf(students, studentName);

                if (studentIndex == -1) // İstenen öğrenci listede yoksa hata mesajı verin
                {
                    Console.WriteLine($"Student {studentName} not found in the list.");
                }
                else 
                {
                    int studentGrade = studentGrades[studentName];
                    string studentStatus = "";

                    if (studentGrade >= 90) // Notuna göre öğrencinin başarı durumunu hesaplayın
                    {
                        studentStatus = "Excellent";
                    }
                    else if (studentGrade >= 80)
                    {
                        studentStatus = "Very good";
                    }
                    else if (studentGrade >= 70)
                    {
                        studentStatus = "Good";
                    }
                    else if (studentGrade >= 60)
                    {
                        studentStatus = "Pass";
                    }
                    else
                    {
                        studentStatus = "Fail";
                    }

                    studentStatuses[studentName] = studentStatus; // Başarı durumunu dictionary'e ekleyin

                    Console.WriteLine($"Student {studentName} has a grade of {studentGrade} and is {studentStatus}."); // Öğrencinin notunu ve başarı durumunu yazdırın
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select 1, 2 or 3.");
            }

        }    
    }
}
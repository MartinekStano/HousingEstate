using System;
using System.Collections.Generic;

namespace HousingEstate
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = 0;
            do
            {
                Console.WriteLine("1. Pridanie obyvatela");
                Console.WriteLine("2. Vypis obyvatelov bytu");
                Console.WriteLine("3. Vybranie bytu");
                Console.WriteLine("4. Vypis bytu");
                Console.WriteLine("5. KONIEC");
                Console.Write("Vas vyber: ");
               
                answer = int.Parse(Console.ReadLine());
                switch (answer)
                {
                    case 1: AddHabitan(); break;
                        
                    case 2: Flat.GetInfoAboutAllHabitants(); break;

                    case 3: AddNewFlat(); break;

                    case 4: Entrance.GetInfoAboutAllFlats(); break;
                         
                }    
            } while (!(answer == 5));
            Console.WriteLine("KONIEC");
        }
            
            
           
            




                
                

        public static bool IsString(string isString)
        {
            if (isString.Contains("0") || isString.Contains("1") || isString.Contains("2") || isString.Contains("3") || isString.Contains("4") || isString.Contains("5") || isString.Contains("6") || isString.Contains("7") || isString.Contains("8") || isString.Contains("9"))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static void AddHabitan()
        {
            bool running = true;

            do
            {
                try
                {
                    /*if(Flat.PersonsInFlat.Count >= 4)
                    {
                        Console.WriteLine("V byte je maximalny pocet obyvatelov!");
                    }*/


                    Console.Write("Meno: ");
                    string name = Console.ReadLine();

                    if (IsString(name) == false)
                    {
                        Console.WriteLine("Nezadaliste spravnu formu priezviska");
                        do
                        {
                            Console.Write("Meno: ");
                            name = Console.ReadLine();

                        } while (IsString(name) == true);
                    }

                    Console.Write("Priezvisko: ");
                    string surname = Console.ReadLine();

                    if (IsString(surname) == false)
                    {
                        Console.WriteLine("Nezadaliste spravnu formu priezviska");
                        do
                        {
                            Console.Write("Priezvisko: ");
                            surname = Console.ReadLine();

                        } while (IsString(surname) == true);
                    }

                    Console.Write("Vek: ");
                    int age = int.Parse(Console.ReadLine());

                    Flat.Addhabitant(name, surname, age);
                    running = true;

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Niekde sa stala chyba");
                    running = false;
                }
            } while (!(running == false));
            
        }
        public static List<Person> AddHabitanToNewFlat()
        {
            bool running = true;
            List<Person> people = new List<Person>();
            do
            {
                Console.WriteLine("Kolko ludi bude obyvat byt?: ");
                int countOfPeople = int.Parse(Console.ReadLine());

                if (countOfPeople >= 4)
                {
                    Console.WriteLine("Maximalny pocet ludi je 4");
                    running = false;
                }
                else
                {
                    for (int i = 1; i <= countOfPeople; i++)
                    {

                        Console.Write("Meno: ");
                        string name = Console.ReadLine();

                        if (IsString(name) == false)
                        {
                            Console.WriteLine("Nezadaliste spravnu formu priezviska");
                            do
                            {
                                Console.Write("Meno: ");
                                name = Console.ReadLine();

                            } while (IsString(name) == true);
                        }

                        Console.Write("Priezvisko: ");
                        string surname = Console.ReadLine();

                        if (IsString(surname) == false)
                        {
                            Console.WriteLine("Nezadaliste spravnu formu priezviska");
                            do
                            {
                                Console.Write("Priezvisko: ");
                                surname = Console.ReadLine();

                            } while (IsString(surname) == true);
                        }

                        Console.Write("Vek: ");
                        int age = int.Parse(Console.ReadLine());
                    
                        Person person = Person.NewPeopleInFlat(name, surname, age);

                        people.Add(person);

                        running = true;
                    }
                }
            } while (running == false) ;

            return people;
        }
        
        public static void AddNewFlat()
        {
            Console.Write("Cislo bytu: ");
            int numberOfFlat = int.Parse(Console.ReadLine());

            Console.Write("Rozmer bytu: ");
            double areaOfFlat = double.Parse(Console.ReadLine());

            Console.Write("Pocet miestosti: ");
            int countOfRoom = int.Parse(Console.ReadLine());

            List<Person> people = AddHabitanToNewFlat();

            Console.Write("Poschodie: ");
            int floor = Entrance.ChooseFloor();

            Entrance.AddNewFlat(numberOfFlat,areaOfFlat,countOfRoom,people,floor);
        }
    }
}

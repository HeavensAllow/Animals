using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Animals
{
    class Program
    {
        static List<Human> humanList = new List<Human>();
        static List<Pet> petList = new List<Pet>();

        static void Main(string[] args)
        {
            

            int num = 0;
            while (num != 3)
            {
                Console.Clear();
                //menu inicial
                Console.WriteLine("1- Menu humanos");
                Console.WriteLine("2- Menu dogs");
                Console.WriteLine("3- Sair do programa");
                num = Convert.ToInt32(Console.ReadLine()); //serve para guardar a variavel
                if (num == 1)
                {
                    int num1 = 0;
                    while (num1 != 5)
                    {
                        Console.Clear();
                        //quando clicamos 1
                        Console.WriteLine("1-Criar novo humano");
                        //Console.WriteLine("2-Editar humano");
                        //Console.WriteLine("3-Apagar humano");
                        //Console.WriteLine("4-Atribuir um cao a um humano");}
                        Console.WriteLine("5- Voltar ao menu inicial");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        if (num1 == 1)
                        {
                            Console.Clear();
                            string classification, name;
                            int age;
                            Console.WriteLine("Insira a classificacao");
                            classification = Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("Insira o nome");
                            name = Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("Insira a idade");
                            age = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            Human hi = new Human(classification, age, name);
                            humanList.Add(hi);
                        }
                    }
                    }
                if (num == 2)
                {
                    int num2 = 0;
                    while (num2 != 4)
                    {
                        Console.Clear();
                        Console.WriteLine("1- Criar novo cao");
                        //Console.WriteLine("2- Editar cao");
                        //Console.WriteLine("3- Apagar cao");
                        Console.WriteLine("4-Voltar ao menu inicial");
                        num2 = Convert.ToInt32(Console.ReadLine());
                        if (num2 == 1)
                        {
                            Console.Clear();
                            string classification, name, race;
                            int age;
                            Console.WriteLine("Insira a classificacao");
                            classification = Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("Insira o nome");
                            name = Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("Insira a idade");
                            age = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            Console.WriteLine("Insira a raca");
                            race = (Console.ReadLine());
                            Console.Clear();
                            Dog hi = new Dog(classification, age, name, race);
                            petList.Add(hi);
                        }
                        if(num2 == 2)
                        {
                            Console.Clear();
                            foreach (Dog dog in petList)
                            {
                                Console.WriteLine("Name: {0}, raca: {1}, idade: {2}, classificacao: {3}", dog.name, dog.race, dog.age, dog.classification);
                            }
                        }
                    }
                }
                }
                //dog1.Play();
                //h.Play(dog2);
                //h.Run(300);
                //h.Run(20);
                //h.Sleep(500);
                Console.Read();
            }
        }
    }


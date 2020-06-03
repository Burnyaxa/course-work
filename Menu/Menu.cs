using course_work.Gun;
using course_work.ScoreCounter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_work.Menu
{
    class Menu
    {
        public enum Tasks
        {
            Exit,
            Start,
            Leaderboards
        }

        public enum Guns
        {
            Bow,
            Pistol
        }

        public enum Targets
        {
            Circle,
            Human
        }

        public enum ShootTask
        {
            Exit,
            Shoot
        }
        public static void StartMenu()
        {
            DBO.DBController controller = new DBO.DBController();
            Bow bow = new Bow();
            Pistol pistol = new Pistol();
            while (true)
            {
                Console.WriteLine("What to do?");
                Console.WriteLine("1. Start");
                Console.WriteLine("2. Leaderboards");
                Console.WriteLine("0. Exit");

                Tasks task = (Tasks)Convert.ToInt32(Console.ReadLine());

                if(task == Tasks.Exit)
                {
                    break;
                }
                Console.Clear();
                switch (task)
                {
                    case Tasks.Start:
                        Console.Write("Player name: ");
                        string playerName = Console.ReadLine();

                        Shooter.Shooter shooter = Shooter.Shooter.GetInstance(playerName);

                        Console.Clear();

                        Console.WriteLine("Choose a gun: ");
                        Console.WriteLine("0. Bow");
                        Console.WriteLine("1. Pistol");

                        Guns gunChoice = (Guns)Convert.ToInt32(Console.ReadLine());

                        Console.Clear();

                        Console.WriteLine("Choose a target: ");
                        Console.WriteLine("0. Circle(default)");
                        Console.WriteLine("1. Human");

                        Targets targetChoice = (Targets)Convert.ToInt32(Console.ReadLine());

                        Target.Target target;
                        ScoreCounter.ScoreCounter counter;
                        switch (targetChoice)
                        {
                            default:
                                target = new Target.Target(new Target.CircleTarget());
                                counter = new ScoreCounter.ScoreCounter(new ScoreCounter.CircleTargetScoreCounter());
                                break;
                            case Targets.Human:
                                target = new Target.Target(new Target.HumanTarget());
                                counter = new ScoreCounter.ScoreCounter(new ScoreCounter.HumanTargetScoreCounter());
                                break;

                        }

                        while (true)
                        {
                            Console.Clear();

                            Console.WriteLine("What to do?");
                            Console.WriteLine("0. Exit");
                            Console.WriteLine("1. Shoot");
                            ShootTask shootTask = (ShootTask)Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            if(shootTask == ShootTask.Exit)
                            {
                                break;
                            }
                            else
                            {
                                Console.Write("Input X: ");
                                int coordinateX = int.Parse(Console.ReadLine());
                                Console.Write("Input Y: ");
                                int coordinateY = int.Parse(Console.ReadLine());
                                switch (gunChoice)
                                {
                                    case Guns.Bow:
                                        bow.Shoot(ref coordinateX, ref coordinateY, ref target);
                                        break;
                                    case Guns.Pistol:
                                        pistol.Shoot(ref coordinateX, ref coordinateY, ref target);
                                        break;
                                }

                                Target.TargetPrinter.PrintTarget(target);
                                counter.GetScore(coordinateX, coordinateY, target);
                                counter.SumScore();
                                counter.IncreaseShotsCounter();
                                Console.WriteLine("Your score: {0}", counter.Score);
                                Console.WriteLine("Total score: {0}", counter.TotalScore);
                                Console.WriteLine("Press any key to continue....");
                                Console.ReadKey();
                            }
                        }
                        controller.InsertResult(shooter.Name, gunChoice.ToString(), counter.Shots, counter.TotalScore, targetChoice.ToString());
                        counter.Reset();
                        shooter.ResetInstance();
                        break;
                    case Tasks.Leaderboards:
                        controller.GetResults();
                        break;
                }
            }
        }
    }
}

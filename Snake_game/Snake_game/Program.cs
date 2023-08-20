using System;
using System.Collections.Generic;
using System.Threading;

namespace Snake_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DrawMap(60, 20);
            Snake snake = new Snake();
            Food food = new Food();

            while (snake.gameover == false)
            {
                snake.DrawSnake();
                food.DrawFood();
                snake.KeyInput();
                snake.MoveSnake();
                snake.EatFood(food.foodPoint, food);
                snake.ConflictItself();
                snake.ConflictWithWall();
                snake.ConflictItself();
            }
        }

        static void DrawMap(int width, int height)
        {
            for (int i = 0; i < width; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write('#');
                Console.SetCursorPosition(i, height);
                Console.Write('#');
            }

            for (int i = 0; i <= height; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write('#');
                Console.SetCursorPosition(width, i);
                Console.Write('#');
            }
        }
    }

    public class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point(int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public void Clear()
        {
            sym = ' ';
            Draw();
        }
    }

    public class Snake
    {
        public bool gameover = false;
        public int x;
        public int y;
        public int size;
        public int score = 0;
        ConsoleKeyInfo key = new ConsoleKeyInfo();
        public char dir = 'r';
        List<Point> snakeBody = new List<Point>();

        public Snake()
        {
            x = 30;
            y = 10;

            snakeBody.Add(new Point(x - 2, y, '@'));
            snakeBody.Add(new Point(x - 1, y, '@'));
            snakeBody.Add(new Point(x, y, '@'));
        }

        public void KeyInput()
        {
            if (Console.KeyAvailable)
            {
                key = Console.ReadKey(true);
            }
        }

        private void Direction()
        {
            if (key.Key == ConsoleKey.UpArrow && dir != 'd')
            {
                dir = 'u';
            }
            else if (key.Key == ConsoleKey.DownArrow && dir != 'u')
            {
                dir = 'd';
            }
            else if (key.Key == ConsoleKey.LeftArrow && dir != 'r')
            {
                dir = 'l';
            }
            else if (key.Key == ConsoleKey.RightArrow && dir != 'l')
            {
                dir = 'r';
            }
        }

        public void DrawSnake()
        {
            foreach (Point point in snakeBody)
            {
                point.Draw();
            }
        }

        public void MoveSnake()
        {
            Direction();

            if (dir == 'u')
            {
                y--;
            }
            else if (dir == 'd')
            {
                y++;
            }
            else if (dir == 'l')
            {
                x--;
            }
            else if (dir == 'r')
            {
                x++;
            }

            snakeBody.Add(new Point(x, y, '@'));
            snakeBody[snakeBody.Count - 1].Draw();
            snakeBody[0].Clear();
            snakeBody.RemoveAt(0);

            Thread.Sleep(100);
        }

        public void ConflictItself()
        {
            Point head = snakeBody[snakeBody.Count - 1];
            for (int i = 0; i < snakeBody.Count - 2; i++)
            {
                Point body = snakeBody[i];
                if (head.x == body.x && head.y == body.y)
                {
                    gameover = true;
                    Console.SetCursorPosition(0, 22);
                    Console.WriteLine("########################");
                    Console.WriteLine("       GAME OVER!");
                    Console.WriteLine("     Your Score: {0}", score);
                    Console.WriteLine("########################");
                }
            }
        }

        public void ConflictWithWall()
        {
            Point head = snakeBody[snakeBody.Count - 1];

            if (head.x <= 0 || head.x >= 59 || head.y <= 0 || head.y >= 20)
            {
                gameover = true;
                Console.SetCursorPosition(0, 22);
                Console.WriteLine("########################");
                Console.WriteLine("       GAME OVER!");
                Console.WriteLine("     Your Score: {0}", score);
                Console.WriteLine("########################");
            }
        }

        public void EatFood(Point foodPoint, Food food)
        {
            // 뱀의 머리 위치 가져오기
            Point head = snakeBody[snakeBody.Count - 1];

            // 뱀 머리 위치가 음식의 위치와 일치한다면
            if (head.x == foodPoint.x && head.y == foodPoint.y)
            {
                // 현 위치 값을 가지는 새 Position 값 List에 추가
                snakeBody.Add(new Point(x, y, '@'));

                // 음식 - 다음 위치 그리기
                food.DrawNextFood();

                score++;
            }
        }
    }

    public class Food
    {
        Random random = new Random();
        public Point foodPoint = new Point(0, 0, '*');

        public Food()
        {
            foodPoint.x = random.Next(1, 59);
            foodPoint.y = random.Next(1, 19);
        }

        public void DrawFood()
        {
            Console.SetCursorPosition(foodPoint.x, foodPoint.y);
            Console.Write("*");
        }
        public void DrawNextFood()
        {
            foodPoint.x = random.Next(1, 59);
            foodPoint.y = random.Next(1, 19);
        }
    }
}
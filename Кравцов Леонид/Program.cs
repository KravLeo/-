//double a, b, c, d, result;
//double.TryParse(Console.ReadLine(), out a);
//double.TryParse(Console.ReadLine(), out b);
//double.TryParse(Console.ReadLine(), out c);
//double.TryParse(Console.ReadLine(), out d);
//double x = a / c;
//double y = b / d;
//double z = a * b - c;
//double q = c * d;
//result = (x * y) - (z / q); 
//    Console.WriteLine("Ответ:" + result);
// задача номер 2

//Задача номер 3
//double x, y, result;
//double.TryParse(Console.ReadLine(), out x);
//double.TryParse(Console.ReadLine(), out y);
//result = ((Math.Sin(x) + Math.Cos(y)) / (Math.Cos(x) - Math.Sin(y))) * Math.Tan(x * y);
//Console.WriteLine("Ответ:" + result);

//double x, y, result;
//double.TryParse(Console.ReadLine(), out x);
//double.TryParse(Console.ReadLine(), out y);
//double a = Math.Sin(x) + Math.Cos(y);
//double b = Math.Cos(x) - Math.Sin(y);
//double c = Math.Tan(x * y);
//result = a/b * c;
//Console.WriteLine("Ответ:" + result);

//Задача номер 4
//double x, y, result;
//double.TryParse(Console.ReadLine(), out x);
//double.TryParse(Console.ReadLine(), out y);
//result = (x + y) / (y + 1) - (x * y - 12) / (34 + x);
//Console.WriteLine("Ответ:" + result);

//Задача номер 5
//double x, y, result;
//double.TryParse(Console.ReadLine(), out x);
//double.TryParse(Console.ReadLine(), out y);
//result = (3 + Math.Pow(Math.E, y - 1)) / (1 + Math.Pow(x, 2)) * Math.Abs(y - Math.Tan(x));
//Console.WriteLine("Ответ:" + result);

//Задача номер 6 
//double x, result;
//double.TryParse(Console.ReadLine(), out x);
//result = x - (Math.Pow(x, 3) / 3) + (Math.Pow(x, 5) / 5);
//Console.WriteLine("Ответ:"+result);

//Задача номер 7
//double x, y, result;
//double.TryParse(Console.ReadLine(), out x);
//double.TryParse(Console.ReadLine(), out y);
//result = Math.Log(Math.Abs( (y - Math.Sqrt (Math.Abs(x) ) ) * (x - (y / (x + Math.Pow(x, 2) / 4)))));
//Console.WriteLine("Ответ:" + result);

//Задача номер 8
//double x, y, result;
//double.TryParse(Console.ReadLine(), out x);
//double.TryParse(Console.ReadLine(), out y);
//result = Math.Pow(1 - Math.Tan(x), 1 / Math.Tan(x)) + Math.Cos(x - y);
//Console.WriteLine("Ответ:" + result);

//Задача номер 9 
//double x, result;
//double.TryParse(Console.ReadLine(), out x);
//result = Math.Log(Math.Abs(Math.Cos(x))) / Math.Log(1 - Math.Pow(x, 2));
//Console.WriteLine("Ответ:" + result);

//08.09.23
//Задача номер 2
//double x1, y1, x2, y2, x3, y3, P, S;
//double.TryParse(Console.ReadLine(), out x1);
//double.TryParse(Console.ReadLine(), out y1);
//double.TryParse(Console.ReadLine(), out x2);
//double.TryParse(Console.ReadLine(), out y2);    
//double.TryParse(Console.ReadLine(), out x3);
//double.TryParse(Console.ReadLine(), out y3);
//double a = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
//double b = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
//double c = Math.Sqrt(Math.Pow((x3 - x1), 2) +Math.Pow((y3 - y1), 2));
//P = a + b + c;
//S = a * b / 2;
//Console.WriteLine("Периметр:" + P);
//Console.WriteLine("Площадь:" + S);

//Задача номер 3
//double R, D, S;
//double.TryParse(Console.ReadLine(), out R);
//D = 2 * Math.PI * R;
//S = Math.PI * Math.Pow(R, 2);
//Console.WriteLine("Длина окружности:" + D);
//Console.WriteLine("Площадь:" + S);

//Задача номер 5
// произведение двух модулей в степени 2
//double a, b;
//double.TryParse(Console.ReadLine(), out a);
//double.TryParse(Console.ReadLine(), out b);
//double k = (Math.Pow(a, 3) + Math.Pow(b, 3)) / 2;
//double d = Math.Sqrt(Math.Abs(a * b), 2);
//Console.WriteLine("Среднее арифметическое кубов" + k);
//Console.WriteLine("Среднее геометрическое" + d);

//Задача номер 6
//double x1, y1, x2, y2;
//double.TryParse(Console.ReadLine(), out x1);
//double.TryParse(Console.ReadLine(), out y1);
//double.TryParse(Console.ReadLine(), out x2);
//double.TryParse(Console.ReadLine(), out y2);
//double a = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
//Console.WriteLine(a);

//Задача номер 7
//double x, y, A, B, C, D, A1, B1, C1, D1;
//double.TryParse(Console.ReadLine(), out x);
//double.TryParse(Console.ReadLine(), out y);
//A = x + y;
//B = x - y;
//C = x * y;
//D = x / y;
//A1 = x + y;
//B1 = x - y;
//C1= x * y;
//D1 = x / y;
//Console.WriteLine("сумма х и у:" + A);
//Console.WriteLine("разность х и у:" + B);
//Console.WriteLine("произведение х и у:" + C);
//Console.WriteLine("частное х и у:" + D);
//Console.WriteLine("сумма у и х:" + A1);
//Console.WriteLine("разность у и х:" + B1);
//Console.WriteLine("произведение у и х:" + C1);
//Console.WriteLine("частное у и х:" + D1);

//Задача номер 8
//double a, S, O;
//double.TryParse(Console.ReadLine(), out a);
//S = Math.Pow(a, 2);

//Задача номер 3, лог. выраж.
//int x, m, n;
//int.TryParse(Console.ReadLine(), out x);
//int.TryParse(Console.ReadLine(), out m);
//int.TryParse(Console.ReadLine(), out n);
//int y = 0;
//if (m < x && x < n)
//Console.WriteLine("True");
//else 
//    Console.WriteLine("False");
//if (m > n)
//    Console.WriteLine("Не выполнино условие задачи");
//else
//    Console.WriteLine("");

// Задача номер 4, лог. выраж.
//int.TryParse(Console.ReadLine(), out int number);
//int a = number / 100;
//int b = number / 100 % 10;
//int c = number % 10;
//if (Math.Pow(number, 2) == Math.Pow(a + b + c, 3))
//Console.WriteLine("true");
//else
//    Console.WriteLine("false");

//Задача номер 5. лог.выр.
//int.TryParse(Console.ReadLine(), out int n);
//if (n <= 99 &&  n % 2 == 0)
//    Console.WriteLine("true");
//else 
//    Console.WriteLine("false");

//Задача номер 6, лог. выр.
//using System;

//int a, b, c;
//int.TryParse(Console.ReadLine(), out a);
//int.TryParse(Console.ReadLine(), out b);
//int.TryParse(Console.ReadLine(), out c);
//if (a == b && a == c && b == c) 
//    Console.WriteLine("True");
//else 
//    Console.WriteLine("False");

// Задача номер 7. лог.выр.
//int a, b, c;
//int.TryParse(Console.ReadLine(), out a);
//int.TryParse(Console.ReadLine(), out b);
//int.TryParse(Console.ReadLine(), out c);
//if (a == b)
//    Console.WriteLine("True");
//else
//    Console.WriteLine("False");

//Задача номер 8. лог. выр.
//int a, b, c;
//int.TryParse(Console.ReadLine(), out a);
//int.TryParse(Console.ReadLine(), out b);
//int.TryParse(Console.ReadLine(), out c);
//if (a == -b | b == -c| c == -a | b == -a | c == -b)
//    Console.WriteLine("True");
//else
//    Console.WriteLine("False");

//Кравцов Леонид
//Текстовые задачи
// задача 1
//double a, b, c;
//double.TryParse(Console.ReadLine(), out a);
//double.TryParse(Console.ReadLine(), out b);
//double.TryParse(Console.ReadLine(), out c);
//if ( a > 0)
//    Console.WriteLine("квадрат А:" + Math.Pow (a, 2));
//else 
//    Console.WriteLine("А в 4 степени:" + Math.Pow(a, 4));
//if (b > 0)
//    Console.WriteLine("квадрат B:" + Math.Pow(b, 2));
//else
//    Console.WriteLine("B в 4 степени:" + Math.Pow(b, 4));
//if (c > 0)
//    Console.WriteLine("квадрат C:" + Math.Pow(c, 2));
//else
//    Console.WriteLine("C в 4 степени:" + Math.Pow(c, 4));

//Задача 2
//double x1, y1, x2, y2;
//double.TryParse(Console.ReadLine(), out x1);
//double.TryParse(Console.ReadLine(),out y1);
//double.TryParse(Console.ReadLine(), out x2);
//double.TryParse(Console.ReadLine(), out y2);
//double A = Math.Sqrt((x1 * x1) + (y1 * y1));
//double B = Math.Sqrt((x2 * x2) + (y2 * y2));
//if (A > B)
//    Console.WriteLine("тчк А ближе");
//else 
//    Console.WriteLine("тчк В ближе");

//Задача 3
//int a, b;
//int.TryParse(Console.ReadLine(), out a);
//int.TryParse(Console.ReadLine(), out b);
//int c = 180 - (a+b) ;
//if (180 <= (a+b))
//    Console.WriteLine("Треугольник не возможен");
//else 
//    Console.WriteLine("Треугольник возможен");
//if ( a == 90)
//    Console.WriteLine("Треугольник прямоугольный");
//else
//    Console.WriteLine("Треугольник не прямоугольный");
//if (b == 90)
//    Console.WriteLine("Треугольник прямоугольный");
//else
//    Console.WriteLine("Треугольник не прямоугольный");
//if (c == 90)
//    Console.WriteLine("Треугольник прямоугольный");
//else
//    Console.WriteLine("Треугольник не прямоугольный");

//Задача номер 4
//int x, y;
//int.TryParse(Console.ReadLine(), out x);
//int.TryParse(Console.ReadLine(), out y);
//int z = (x + y) / 2;
//int t = (y * x) * 2;
//if (x == y)
//    Console.WriteLine("Условие нарушенно");
//else if (x > y | x < y)
//    Console.WriteLine("Новое значение Х: " + z);
//    Console.WriteLine("Новое значение У: " + t);

// Задача номер 5
//double x, y;
//double.TryParse(Console.ReadLine(), out x);
//double.TryParse(Console.ReadLine(), out y);
//if (x == 0 && y == 0)
//    Console.WriteLine("Тчк в начале координат");
//else if (x == 0 && y > 0)
//    Console.WriteLine("Тчк на положительной части оси У");
//else if (x == 0 && y < 0)
//    Console.WriteLine("Тчк на отрицательной части оси У");
//else if (x > 0 && y == 0)
//    Console.WriteLine("Тчк на положительной части оси Х");
//else if (x < 0 && y == 0)
//    Console.WriteLine("Тчк на отрицательной части оси Х");
//else if (x > 0 && y > 0)
//    Console.WriteLine("Тчк в 1ой четверти");
//else if (x < 0 && y > 0)
//    Console.WriteLine("Тчк во 2ой четверти");
//else if (x < 0 && y < 0)
//    Console.WriteLine("Тчк в 3ей четверти");
//else
//    Console.WriteLine("Тчк в 4ой четверти");

//Задача номер 6
//double m, n;
//double.TryParse(Console.ReadLine(), out m);
//double.TryParse(Console.ReadLine(), out n);
//if (m != n)
//    Console.WriteLine("Оба числа равны  " + Math.Max(m, n));
//else
//    Console.WriteLine("Оба числа равны 0");

//Задача номер 7
//double a, b, c;
//double.TryParse(Console.ReadLine(), out a);
//double.TryParse(Console.ReadLine(), out b);
//double.TryParse(Console.ReadLine(), out c);
//int n = 0;
//if (a < 0)
//    n = n + 1;
//else
//    n = n + 0;
//if (b < 0)
//    n = n + 1;
//else
//    n = n + 0;
//if (c < 0)
//    n = n + 1;
//else
//    n = n + 0;
//Console.WriteLine("Кол-во отриц чисел: " + n);

//Задача номер 8
//double a, b, c;
//double.TryParse(Console.ReadLine(), out a);
//double.TryParse(Console.ReadLine(), out b);
//double.TryParse(Console.ReadLine(), out c);
//int n = 0;
//if (a > 0)
//    n = n + 1;
//else
//    n = n + 0;
//if (b > 0)
//    n = n + 1;
//else
//    n = n + 0;
//if (c > 0) 
//    n = n + 1;
//else
//    n = n + 0;
//Console.WriteLine("Кол-во полож чисел: " + n);

//Оператор выбора Switch 
//Номер 2
//Console.WriteLine("Введите число");
//int.TryParse(Console.ReadLine(), out int number);
//int cifra = number % 10;
//int kvadr = cifra;
//switch (kvadr)
//{
//  case 1:
//  case 9:
//        kvadr = 1;
//        break;
//  case 2:
//  case 8:
//        kvadr = 4;
//        break;
//  case 3:
//  case 7:
//        kvadr = 9;
//        break;
//  case 4:
//  case 6:
//        kvadr = 6;
//        break;
//  case 5: 
//        kvadr = 5;
//        break;
//}
//Console.WriteLine($"Последняя цифра квадрата заданного числа равна: {kvadr}");

//Задача номер 4
//Console.WriteLine("Введите число");
//int.TryParse(Console.ReadLine(), out int number);
//switch (number)
//{
// case 0:
//Console.WriteLine("name of this number is - zero!");
//break;
// case 1:
//        Console.WriteLine("name of this number is - one!");
//        break;
// case 2:
//        Console.WriteLine("name of this number is - two!");
//        break;
// case 3:
//        Console.WriteLine("name of this number is - three!");
//        break;
// case 4:
//        Console.WriteLine("name of this number is - four!");
//        break;
// case 5:
//        Console.WriteLine("name of this number is - five!");
//        break;
// case 6:
//        Console.WriteLine("name of this number is - six!");
//        break;
// case 7:
//        Console.WriteLine("name of this number is - seven!");
//        break;
// case 8:
//        Console.WriteLine("name of this number is - eight!");
//        break;
// case 9:
//        Console.WriteLine("name of this number is - nine!");
//        break;
//    default: 
//        Console.WriteLine("Oh i am so sory, i dont know this number");
//        return;
//}

//Задача номер 5
//Console.WriteLine("Введите номер месяца");
//int.TryParse(Console.ReadLine(), out int month);
//switch (month)
//{
//    case 0:
//        Console.WriteLine("Ты реально решил проверить, что будет если ввести 0? Ну поздравляю такого месяца нет");
//        break;
//    case 1:
//        Console.WriteLine("Первый месяц - Январь");
//        break;
//    case 2:
//        Console.WriteLine("Второй месяц - Февраль");
//        break;
//    case 3:
//        Console.WriteLine("Третий месяц - Март");
//        break;
//    case 4:
//        Console.WriteLine("Четвёртый месяц - Апрель");
//        break;
//    case 5:
//        Console.WriteLine("Пятый месяц - Май");
//        break;
//    case 6:
//        Console.WriteLine("Шестой месяц - Июнь");
//        break;
//    case 7:
//        Console.WriteLine("Седьмой месяц - Июль");
//        break;
//    case 8:
//        Console.WriteLine("Восьмой месяц - Август");
//        break;
//    case 9:
//        Console.WriteLine("Девятый месяц - Сентябрь");
//        break;
//    case 10:
//        Console.WriteLine("Десятый месяц - Октябрь");
//        break;
//    case 11:
//        Console.WriteLine("Одинадцатый месяц - Ноябрь");
//        break;
//    case 12:
//        Console.WriteLine("Двенадцатый месяц - Декабрь");
//        break;


//    default:
//        Console.WriteLine("Такого месяца нет");
//        return;
//}

//Задача номер 6
//Console.WriteLine("Какую оценку вы получили? (1-5)");
//int.TryParse(Console.ReadLine(), out int ozenka);
//switch (ozenka)
//{
//    case 1:
//        Console.WriteLine("Очень плохо");
//        break;
//    case 2:
//        Console.WriteLine("Плохо");
//        break;
//    case 3:
//        Console.WriteLine("Удовретворительно");
//        break;
//    case 4:
//        Console.WriteLine("Хорошо");
//        break;
//    case 5:
//        Console.WriteLine("Отлично! Ты молодец!");
//        break;
//    default:
//        Console.WriteLine("Такой оценки нет");
//        return;

//}
//Задача номер 7
//double S;
//Console.WriteLine("Через какую велечину рассчитать площадь круга? 1-радиус, 2-диаметр, 3-длина окружности. ");
//double.TryParse(Console.ReadLine(), out double velich);

//switch (velich)
//{
//    case 1:
//        Console.WriteLine("Введите значение радуиса");
//        double.TryParse(Console.ReadLine(), out double r);
//        S = Math.PI * Math.Pow(r, 2);
//        Console.WriteLine("Площадь равна: " + S);
//        break;
//    case 2:
//        Console.WriteLine("Введите значение диаметра");
//        double.TryParse(Console.ReadLine(), out double d);
//        S = (Math.PI / 4) * Math.Pow(d, 2);
//        Console.WriteLine("Площадь равна: " + S);
//        break;
//    case 3:
//        Console.WriteLine("Введите значение длины окружности");
//        double.TryParse(Console.ReadLine(), out double l);
//        S = Math.Pow(l, 2) / (4 * Math.PI);
//        Console.WriteLine("Площадь равна: " + S);
//        break;
//    default:
//        Console.WriteLine("Неудаётся расспознать велечину, введите коректную величену.");
//        return;
//}

//Залача номер 8
//double a, b, h, S;
//Console.WriteLine("Введите велечину. 1-катет, 2-гипотенуза, 3-высота, 4-площадь. ");
//double.TryParse(Console.ReadLine(), out double velich);

//switch (velich)
//{
//    case 1:
//        Console.WriteLine("Введите значение катета");
//        double.TryParse(Console.ReadLine(), out a);
//        b = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(a, 2));
//        h = a;
//        S = (b * h) / 2;
//        break;
//    case 2:
//        Console.WriteLine("Введите значение гипотенузы");
//        double.TryParse(Console.ReadLine(), out b);
//        a = b / Math.Sqrt(2) / 2;
//        h = b / 2;


//        S = (b * h) / 2;
//        break;
//    case 3:
//        Console.WriteLine("Введите значение высоты");
//        double.TryParse(Console.ReadLine(), out h);
//        b = h * 2;
//        a = Math.Sqrt(Math.Pow(b, 2) / 2);
//        S = (b * h) / 2;

//        break;
//    case 4:
//        Console.WriteLine("Введите значение площади");
//        double.TryParse(Console.ReadLine(), out S);
//        a = Math.Sqrt(S * 2);
//        b = Math.Sqrt (Math.Pow(a, 2) + Math.Pow(a, 2));
//        h = b / 2;
//        break;

//    default:
//        Console.WriteLine("Неудаётся расспознать велечину, введите коректную величену.");
//        return;
//}
//Console.WriteLine($"Катете равен {a}, Гипотенуза будет равна {b}, Высота будет равна {h}, а Площадь будет равна {S}");

//Циклы
//Задача номер 2
//int s = int.Parse(Console.ReadLine());
//double norm = 10;
//double result = 0;
//for ( int i = 0; i < s; i++)
//{
//    result += norm;
//    norm = norm + norm * 0.1;
//}

//Задача номер 3
//double.TryParse(Console.ReadLine(), out double time);
//double am = 1;
//int i = 1;
//do
//{
//    am = am * 2;
//    i += 3;
//} while (i < time);
//Console.WriteLine($"За {time} часов кол-во амёб будет равно {am}");

//Задача номер 4

//Задача номер 5
//int kroliki = 0;
//int gussi = 0;
//for (int i = 0; i < 17;i++ )
//{
//    gussi = (16 - kroliki) * 2;
//    Console.WriteLine($"Гусей {gussi} , кроликов {kroliki}");
//    kroliki = kroliki + 1;

//}

//Задача номер 6
//int b, k, t;
//for (b=0; b<= (100/10); b++)
//{
//    for (k=0; k<= 100/5;k++)
//    {
//        for (t = 0; t<= 100/0.5; t++)
//        if ((b + k + t) == 100 && (b * 10 + k * 5 + t * 0.5) == 100)
//           Console.WriteLine($"быки {b} коров {k} телята {t}");

//    }
//}

//Задача номер 12
//double a, b, c, m, n, k;
//Console.WriteLine("Введите значение k");
//double.TryParse(Console.ReadLine(), out k);
//for (m = 2; m < k; m++)
//{
//    for (n = 2; n < k; n++)
//    {
//        a = Math.Pow(m, 2) - Math.Pow(n, 2);
//        b = 2 *(m*n);
//        c = Math.Pow(m, 2) + Math.Pow(n, 2);
//        Console.WriteLine($"Значение А {a} Значение B {b} Значение С {c} Значение М {m} Значение N {n}" );
//    }
//}

//Задача номер 13
//double s, a5000, a1000, a500, a100, a50, a10;
//Console.WriteLine("Введите сумму для оплаты");
//double.TryParse(Console.ReadLine(), out s);

//for (a5000 = 0; s >= 5000; a5000++)
//{
//    s -= 5000;

//}
//for (a1000 = 0; s >= 1000; a1000++)
//{
//    s -= 1000;

//}
//for (a500 = 0; s >= 500; a500++)
//{
//    s -= 500;

//}
//for (a100 = 0; s >= 100; a100++)
//{
//    s -= 100;

//}
//for (a50 = 0; s >= 50; a50++)
//{
//    s -= 50;

//}
//for (a10 = 0; s >= 10; a10++)
//{
//    s -= 10;

//}
//Console.WriteLine($"10 : {a10} 50 : {a50} 100: {a100} 500 : {a500} 1000 : {a1000} 5000 : {a5000}");

//задача номер 14
//Console.WriteLine("Введите сумму вашей стипендии");
//double.TryParse(Console.ReadLine(), out double step);
//Console.WriteLine("Сколько вы тратите в месяц?");
//double.TryParse(Console.ReadLine(), out double trati);
//double s = 0;
//for ( int i = 0; i <= 10; i++ )
//{    
//        trati = trati / 100 * 3 + trati;
//    Console.WriteLine($"Трат в месяц: {trati}");
//    s += trati;
//}
//Console.WriteLine($"Траты за год: {s}");
//step = step * 10;
//double result = step - trati;
//Console.WriteLine($"Необходимо попросить у родителей: {result}");
//Кравцов Леонид

//4.2
//Задача 1
//Console.WriteLine("Введите N");
//double.TryParse(Console.ReadLine(), out double n);
//for (int i = 0; i <= n; i++)
//{
//    int a = 2;
//    double s = 1 - 1 / a;
//    a *=2;
//    if (i == n)
//    {
//        s = s + Math.Pow(-1, n) * 1 / Math.Pow(2, n);
//        Console.WriteLine($"{s}");
//    }
//}

//Задача 2
//double n, result;
//Console.WriteLine("Введите N");
//double.TryParse(Console.ReadLine(), out n);
//double s = 0;
//double summa = 0;
//for (int i = 1;  i <=n; i++)
//{
//    s += Math.Sin(i);
//    summa += 1 / s;
//}
//Console.WriteLine(s);

//Задача 3
//Console.WriteLine("Введите N");
//double.TryParse(Console.ReadLine(), out double n);
//double p = 0;
//double summa = 1;
//for (int i = 1; i <= n; i++)
//{
//    p = 2 * i / (double)(2 * i + 1);
//    summa *= p;
//}
//Console.WriteLine(summa);

//Задача 4
//double n;
//Console.WriteLine("Введите N");
//double.TryParse(Console.ReadLine(), out n);
//double s = 0;
//double c = 0;
//double summa = 1;
//for (int i = 1; i <= n; i++)
//{
//    s += Math.Sin(i);
//    c += Math.Cos(i);
//    summa *= c / s;
//}
//Console.WriteLine(summa);

//Задача 5
//Console.WriteLine("Введите Х");
//double.TryParse(Console.ReadLine(), out double x);
//double i = 1;
//double summa = 1;
//double ed = -1;
//for (i = 1; i <= 13; i+=2)
//{
//    double a = (Math.Pow(x, i) / i!);
//    a = 
//    summa *= a;

//}
//Console.WriteLine(summa);

//Задача 6
//Console.WriteLine("Введите Х");
//double.TryParse(Console.ReadLine(), out double x);
//Console.WriteLine("Введите N");
//double.TryParse(Console.ReadLine(), out double n);
//double s = 0;
//for (int i = 1; i <= n; i++)
//{
//    x = Math.Sin(x);
//    s += x;

//    Console.WriteLine(s);

//}

//Задача 7
//Console.WriteLine("Введите A");
//double.TryParse(Console.ReadLine(), out double a);
//Console.WriteLine("Введите N");
//double.TryParse(Console.ReadLine(), out double n);
//double p = 0;
//double summa = 1;
//for (int i = 1; i <= n; i++)
//{
//    p = a * (a + i - 1);
//    summa *= p;
//    Console.WriteLine(summa);

//}

//Задача 8
//double.TryParse(Console.ReadLine(), out double a);
//double.TryParse(Console.ReadLine(), out double n);
//double p = 0;
//double summa = 1;
//for (int i = 0; i <= n; i++)
//{

//}


//Масивы
//Задача номер 1
//int.TryParse(Console.ReadLine(), out int k);
//int.TryParse(Console.ReadLine(), out int count);
//int[] array = new int[count];
//Random random = new Random();
//int summa = 0;
//for (int i = 0; i < count; i++)
//{
//    array[i] = random.Next(1, 1000);
//    if (array[i] % k == 0)
//     summa = summa + array[i];
//}
//Console.WriteLine(summa);

//Задача номер 3
//int.TryParse(Console.ReadLine(), out int count);
//int[] array = new int[count];
//Random random = new Random();

//for (int i = 0; i < count; i++)
//{
//    array[i] = random.Next(-1000, 1000);

//}
//Console.WriteLine(array[0]);
//if (array [0] < 0 )
//    Console.WriteLine("Отриц число раньше");
//else
//    Console.WriteLine("Полож число раньше");

//Задача номер 4
//int.TryParse(Console.ReadLine(), out int count);
//int[] array = new int[count];
//Random random = new Random();

//for (int i = 0; i < count; i++)
//{
//    array[i] = random.Next(-1000, 1000);
//    Console.WriteLine(array[i]);

//}
//bool srfv = false;
//for (int i = 0; i < count - 1; i++)
//{
//    if (array[i] > array[i + 1])
//        srfv = true;
//}
//if (srfv = true)
//    Console.WriteLine("убывающая послед");
//else
//    Console.WriteLine("возрастающая последовательность");

//Задача номер 5
//int.TryParse(Console.ReadLine(), out int count);
//int[] array = new int[count];
//Random random = new Random();
//int twoCount = 0;
//for (int i = 0; i < count; i++)
//{
//    array[i] = random.Next(1, 1000);
//    if (array[i] % 2 == 0)
//        twoCount++;
//    //Console.WriteLine("Вот это выводит" + array[i]);
//    //Console.WriteLine("Во второй массив" + twoCount);
//}
//if (twoCount == 0)
//    Console.WriteLine("Нет чётных чисел");
//int[] array2 = new int[twoCount];
//for (int i = 0, j = 0; i < count; i++)
//{
//    if (array[i] % 2 == 0)
//        array2[j++] = array[i];
//}
//for (int i = 0; i < twoCount; i++)
//{
//    Console.WriteLine(array2[i]);
//}

//Задача номер 6 
//int.TryParse(Console.ReadLine(), out int count);
//int[] array = new int[count];
//Random random = new Random();
//int max = int.MinValue;
//int min = int.MaxValue;

//for (int i = 0; i < count; i++)
//{
//    array[i] = random.Next(1, 1000);
//    if (array[i] > max)
//    { max = array [ i ] ;}
//    if (array[i] < min)
//    { min = array[ i ] ; }
//}
//int a = max - min + 1;
//Console.WriteLine(a);

//Задача номер 7
//int.TryParse(Console.ReadLine(), out int z);
//int.TryParse(Console.ReadLine(), out int count);
//int[] array = new int[count];
//Random random = new Random();
//int s = 0;
//for (int i = 0; i < count; i++)
//{
//    array[i] = random.Next(1, 1000);
//    if (z < array[i])
//    {
//        array[i] = z;
//        s++;
//    }
//    else
//        s += 0;
//}
//Console.WriteLine(s);

//Задача номер 8 
//int.TryParse(Console.ReadLine(), out int count);
//int[] array = new int[count];
//Random random = new Random();
//for (int i = 0; i < count; i++)
//{
//    array[i] = random.Next(-1000, 1000);

//}

//Задача номер 9
//int.TryParse(Console.ReadLine(), out int n);
//int[] array = new int[n];
//Random random = new Random();
//int pol = 0;
//int otr = 0;
//int nul = 0;
//for (int i = 0; i < n; i++)
//{
//    array[i] = int.Parse(Console.ReadLine());
//    if (array[i] > 0)
//    { pol++; }
//    if (array[i] < 0) 
//    { otr++; }
//    if (array[i] == 0)
//    { nul++; }
//}
//Console.WriteLine($"Положительных чисел - {pol}, отрицательных чисел - {otr}, нулей - {nul}");

//Задача номер 10
//int.TryParse(Console.ReadLine(), out int count);
//int[] array = new int[count];
//Random random = new Random();
//int max = int.MinValue;
//int min = int.MaxValue;
//int imin = 0;
//int imax = 0;
//for (int i = 0; i < count; i++)
//{
//    array[i] = random.Next(-1000, 1000);
//    if (array[i] > max)
//    { 
//        max = array[i];
//        imax = i;
//    }
//    if (array[i] < min)
//    {
//        min = array[i];
//        imin = i;
//    }
//}
//array[imin] = max;
//array[imax] = min;
//for ( int i = 0; i < count; i++ )
//{
//    Console.WriteLine($"{i} = {array[i]}");
//}

//Задача номер 11
//int.TryParse(Console.ReadLine(), out int count);
//int[] array = new int[count];
//Random random = new Random();
//for (int i = 0; i < count; i++)
//{
//    array[i] = random.Next(1, 15);
//    if (array[i] >= i)
//    {
//        Console.WriteLine($"{array[i]}");
//    }
//}

//Задача номер 12
//int.TryParse(Console.ReadLine(), out int m);
//int.TryParse(Console.ReadLine(), out int count);
//int[] array = new int[count];
//Random random = new Random();
//for (int i = 0; i < count; i++)
//{
//    array[i] = random.Next(-10, 10);
//    int l = array[i] % m;
//    if (m - 1 >= l && l>= 0 )
//        Console.WriteLine($"{array[i]}");
//}

//Задача номер 13
//int.TryParse(Console.ReadLine(), out int count);
//int[] array = new int[count];
//Random random = new Random();
//for (int i = 0; i < count; i++)
//{
//    array[i] = random.Next(-10, 10);
//    Console.WriteLine(array[i]);
//}
//for (int i = 0;i < count; i+=2)
//{
//    array[i] = array[i+1];
//    Console.WriteLine(array[i]);
//}

//Задача номер 14
//int.TryParse(Console.ReadLine(), out int n);
//int[] array = new int[n];
//Random random = new Random();
//int dop = 0;
//int nedop = 0;
//for (int i = 0; i < n; i++)
//{
//    array[i] = random.Next(2, 6);
//    Console.WriteLine(array[i]);
//    if (array[i] > 2)
//    { dop++; }
//    if (array[i] == 2)
//    { nedop++; }
//}
//Console.WriteLine($"Допущено ко второму экзамену {dop} абитуриентов, не допущенно ко второму экзамену {nedop} абитуриентов ");

//Задача номер 15
//int.TryParse(Console.ReadLine(), out int count);
//int[] array = new int[count];
//Random random = new Random();
//for (int i = 0; i < count; i++)
//{
//    array[i] = random.Next(-10, 10);
//    if (array[i] == 0)
//        break;
//    Console.WriteLine(array[i]);

//}
//Console.WriteLine(0);

//Zadacha nomer 16
//int.TryParse(Console.ReadLine(), out int count);
//int[] array = new int[count];
//Random random = new Random();
//for (int i = 0; i < count; i++)
//{
//    array[i] = random.Next(-10, 10);
//    Console.WriteLine(array[i]);
//}
//Console.WriteLine("========");
//for (int i = 0; i < count / 2; i++)
//{
//    ;
//    Console.WriteLine($"{array[i]} -> {array[i + (count / 2)]}");
//}

//Zadacha nomer 17
//int.TryParse(Console.ReadLine(), out int a);
//int.TryParse(Console.ReadLine(), out int d);
//int.TryParse(Console.ReadLine(), out int count);
//int[] array = new int[count];
//int brak = 0;
//Random random = new Random();
//for (int i = 0; i < count; i++)
//{
//    array[i] = random.Next(0, 500);
//    Console.WriteLine(array[i]);
//    if (array[i] < a - d || array[i] > a + d)
//        brak++;
//}
//if (brak == 0)
//    Console.WriteLine($"BRAKOVANNIH DETALEI NET");
//else
//Console.WriteLine($"Бракованных деталей {brak}");

//Zadacha nomer 18
//int.TryParse(Console.ReadLine(), out int n);
//int[] array = new int[n];
//int max = int.MinValue;
//int imax = 0;
//Random random = new Random();
//for (int i = 0; i < n; i++)
//{
//    array[i] = random.Next(1, 151);
//    Console.WriteLine(array[i]);
//    if (array[i] > max)
//    {
//        max = array[i];
//        imax = i;
//    }
//}
//array[imax] = max;
//Console.WriteLine($"Максимальная цена доллара {array[imax]} рублей");

//Zadacha nomer 19
//int.TryParse(Console.ReadLine(), out int count);
//int[] array = new int[count];
//Random random = new Random();
//for (int i = 0; i < count; i++)
//{
//    array[i] = random.Next(1, 10000);
//}
//for (int i = 1; i < count; i *= 2)
//{
//    Console.WriteLine(array[i]);
//}

//Нерекурсивные процедуры и функции
//static int NOD (int x, int y, int z)
//{
//    for (int i = x; i > 0 ; i--)
//    {
//        if ( x%i == 0 &&  y%i == 0 )
//            return i;
//    }
//    return 1;
//}
//static int NOK (int x,int y,int z)
//{
//    int min = x > y ? x : y;
//    for (int i = min; ; i++) 
//    {
//    if (i%x == 0 && i % y == 0  && i%z == 0)
//            return i;
//    }
//}

//Zad 4 
//int a, b, c;
//int.TryParse(Console.ReadLine(), out a);
//int.TryParse(Console.ReadLine(), out b);
//int.TryParse(Console.ReadLine(), out c);
//int nod = NOK(a, b, c);
//Console.WriteLine($"Naimenshee obshee kratnoe {nod}");

//zad 5
//static int Slozhenie (int x, int y)
//{
//    int summa = x + y;
//    return summa;
//}
//int[] a = new int[3];
//for (int i = 0; i < a.Length; i++)
//{
//    int.TryParse(Console.ReadLine(), out a[i]);
//}
//Console.WriteLine(Slozhenie(a.Max(), a.Min()));

//zad 6
//static double TRE(double x)
//{
//    double y = Math.Pow(x, 2) - Math.Pow(x / 2, 2);
//    double S = (x * y) / 2;
//    return S;
//}
//double a;
//double.TryParse(Console.ReadLine(), out a);
//double S = 6 * TRE(a);
//Console.WriteLine(S);

//zad 7

//static double tchk (double x, double y, double x1, double y1)
//{
//    double s;
//    s = Math.Sqrt(Math.Pow((x1 - x), 2) + Math.Pow(y1 - y, 2));
//    return s;
//}


//Random rnd = new Random();
//int n;
//    int.TryParse( Console.ReadLine(), out n);
//    int[] array = new int[n * 2];
//for (int i = 0; i < array.Length; i+=2)
//{
//    array[i] = rnd.Next(1,100);
//    array[i+1] = rnd.Next(1,100);
//}
//for (int i = 0;i < array.Length; i+=2)
//{
// for (int j = 0; j < array.Length; j+=2)
//    {
//        double z =bonk (array[i], array[j], array[i+1], array[j+1]);
//    }
//}


//Работа со стрингами
//зад 1
//Console.WriteLine("Write text. English please.");
//string text = Console.ReadLine();
//char[] splitter = new char[] { ' ', ',', '.' };
//string[] sub = text.Split(splitter, StringSplitOptions.RemoveEmptyEntries);
//Console.WriteLine(sub.Length);

//zad 2
//Console.WriteLine("Write text. English please.");
//string text = Console.ReadLine();
//char[] splitter = new char[] { ' ', ',', '.' };
//string[] sub = text.Split(splitter, StringSplitOptions.RemoveEmptyEntries);
//int word =  0;
//for  (int i = 0; i < sub.Length; i++)
//{
//    if (sub[i].StartsWith ('b'))
//    {
//    word++;
//    }

//}
//Console.WriteLine(word);

//zad 3
//Console.WriteLine("Write text. English please.");
//string text = Console.ReadLine();
//int r = 0;
//int k = 0;
//int t = 0;
//for (int i = 0; i < text.Length; i++)
//{
//    if (text[i] == 'r')
//    {r++;}
//    if (text[i] == 'k')
//    {k++;}
//    if (text[i] == 't')
//    {t++;}
//}
//Console.WriteLine(r);
//Console.WriteLine(k);
//Console.WriteLine(t);

//zad 4
//Console.WriteLine("Write text. English please.");
//string text = Console.ReadLine();
//int zvez= 0;
//int tkzp = 0;
//int tk = 0;
//for (int i = 0; i < text.Length; i++)
//{
//    if (text[i] == '*')
//    {zvez++;}
//    if (text[i] == ';')
//    {tkzp++;}
//    if (text[i] == ':')
//    {tk++;}
//}
//Console.WriteLine(zvez);
//Console.WriteLine(tkzp);
//Console.WriteLine(tk);

//zad 6
//Console.WriteLine("Write text. English please.");
//string text = Console.ReadLine();
//Console.WriteLine(text.IndexOf(':'));

//zad 7
//Console.WriteLine("Write text. English please.");
//string text = Console.ReadLine();
//char[] splitter = new char[] { ' ', ',', '.' };
//string[] sub = text.Split(splitter, StringSplitOptions.RemoveEmptyEntries);
//for (int i = 0; i < sub.Length; i++)
//{
//    if (sub[i].Length == 3)
//        Console.WriteLine(sub[i]);

//}

//zad 9
//Console.WriteLine("Write text. English please.");
//string text = Console.ReadLine();
//char[] splitter = new char[] { ' ', ',', '.' };
//string[] sub = text.Split(splitter, StringSplitOptions.RemoveEmptyEntries);
//string anotherString = text.Replace("abc", "&");
//int count = 0 ;
//for  (int i = 0; i < sub.Length; i++)
//{
//    if (sub[i] == "&")
//    { count++; }
//}
//Console.WriteLine(count);

//рекурсивные процедуры и функции
//zad 2
//Console.WriteLine("vvedite chislo");
//int chislo;
//int.TryParse(Console.ReadLine(), out chislo);
//int result = kolvo(chislo);
//Console.WriteLine(result);


//static int kolvo(int x)
//{
//    if (x <= 0)
//    { return 0; }
//    else
//    {
//        return 1 + kolvo(x / 10);
//    }
//}

//zad 4

//zad 5

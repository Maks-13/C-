using System;
using System.Collections.Generic;
using System.Text;
using System.IO;




namespace Practical_work__Second_course_
{

    class Matrix
    {
        static int b, c, i, j, k, l;
        static string h, p;
        static List<int> plist = new List<int>();
        static List<int> tlist = new List<int>();

        public Matrix()
        {

        }

        public void matrix_size()
        {

            try
            {
                plist.Clear();
                tlist.Clear();
                Console.WriteLine("Введите кол-во строк для вашей матрицы:");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите кол-во столбцов для вашей матрицы:");
                c = int.Parse(Console.ReadLine());
                Console.WriteLine($"Вы задали следующий размер для своей матрицы, а именно: {b} X {c}");
                Console.ReadLine();
                Console.Clear();

            }
            catch (Exception ex)
            {
                Console.WriteLine("ОШИБКА!!!" + ex.Message);
                Console.WriteLine("Попробуйте ещё раз.");
                Console.ReadLine();
                Console.Clear();
            }


        }
        public void matrix_random()
        {



            if (b == 0 && c == 0)
            {
                Console.WriteLine("Вы проигнорировали пункт под номером 1! Задайте пожалуйста сначала размер матрицы!");
                Console.ReadLine();
                Console.Clear();

            }
            else
            {
                plist.Clear();
                int[,] matrix = new int[b, c];
                Random rnd = new Random();
                for (i = 0; i < b; i++)
                {
                    for (j = 0; j < c; j++)
                    {

                        matrix[i, j] = rnd.Next(1, 9);
                        plist.Add(matrix[i, j]);


                    }

                }
                Console.Write("Ваша матрица сохранена!");
                Console.ReadLine();
                Console.Clear();

            }

        }

        public void matrix_keyboard()
        {
            try
            {
                if (b == 0 && c == 0)
                {
                    Console.WriteLine("Вы проигнорировали пункт под номером 1! Задайте пожалуйста сначала размер матрицы!");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    tlist.Clear();
                    Console.WriteLine("Введите значения матрицы с клавиатуры:");

                    int[,] matrix = new int[b, c];
                    for (k = 0; k < b; k++)
                    {
                        for (l = 0; l < c; l++)
                        {
                            Console.Write($"matrix[{k},{l}]:");
                            matrix[k, l] = int.Parse(Console.ReadLine());
                            tlist.Add(matrix[k, l]);
                        }
                    }
                    Console.Write("Ваша матрица сохранена!");
                    Console.ReadLine();
                    Console.Clear();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ОШИБКА!!!" + ex.Message);
                Console.WriteLine("Попробуйте ещё раз.");
                Console.ReadLine();
                Console.Clear();

            }



        }

        public void matrix_on_screen()
        {
            int a;
            int[,] matrix = new int[b, c];

            try
            {

                Console.WriteLine("Какую матрицу вы хотите вывести на экран?");
                Console.WriteLine();
                Console.WriteLine("1.Созданную с помощью рандомно сгенерированных чисел.");
                Console.WriteLine("2.Созданную с помощью ввода с клавиатуры.");
                Console.WriteLine();
                a = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (a)
                {


                    case 1:
                        int i = 1;
                        foreach (int x in plist)
                            if (i++ % matrix.GetLength(1) == 0)
                                Console.WriteLine(x);
                            else
                                Console.Write(x + " ");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 2:
                        int j = 1;
                        foreach (int x in tlist)
                            if (j++ % matrix.GetLength(1) == 0)
                                Console.WriteLine(x);
                            else
                                Console.Write(x + " ");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("Некорректный ввод! Попробуйте ешё раз.");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ОШИБКА!!!" + ex.Message);
                Console.WriteLine("Попробуйте ещё раз.");
                Console.ReadLine();
                Console.Clear();
            }

        }





        public void matrix_save()
        {
            int a;
            int[,] matrix = new int[b, c];
            try
            {


                Console.WriteLine("Какую матрицу вы хотите сохранить в файл?");
                Console.WriteLine();
                Console.WriteLine("1.Созданную с помощью рандомно сгенерированных чисел.");
                Console.WriteLine("2.Созданную с помощью ввода с клавиатуры.");
                Console.WriteLine();
                a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        Console.WriteLine("Введите директорию записи.");
                        Console.WriteLine();
                        Console.WriteLine(@"Пример: F:\Matrix\input_matrix_random.txt");
                        Console.WriteLine();
                        h = Console.ReadLine();
                        FileStream file1 = new FileStream(h, FileMode.Create);
                        StreamWriter writer1 = new StreamWriter(file1);
                        int i = 1;
                        foreach (int x in plist)
                            if (i++ % matrix.GetLength(1) == 0)
                                writer1.WriteLine(x);
                            else
                                writer1.Write(x + " ");
                        writer1.Close();
                        Console.WriteLine("Вы сохранили матрицу в файл.");
                        Console.ReadLine();
                        Console.Clear();
                        break;


                    case 2:
                        Console.WriteLine("Введите директорию записи.");
                        Console.WriteLine();
                        Console.WriteLine(@"Пример: F:\Matrix\input_matrix_random.txt");
                        Console.WriteLine();
                        p = Console.ReadLine();
                        FileStream file2 = new FileStream(p, FileMode.Create);
                        StreamWriter writer2 = new StreamWriter(file2);
                        int j = 1;
                        foreach (int x in tlist)
                            if (j++ % matrix.GetLength(1) == 0)
                                writer2.WriteLine(x);
                            else
                                writer2.Write(x + " ");
                        writer2.Close();
                        Console.WriteLine("Вы сохранили матрицу в файл.");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("Некорректный ввод! Попробуйте ешё раз.");
                        Console.ReadLine();
                        Console.Clear();
                        break;


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ОШИБКА!!!" + ex.Message);
                Console.WriteLine("Попробуйте ещё раз.");
                Console.ReadLine();
                Console.Clear();

            }

        }

        public void matrix_download()
        {
            int a;
            try
            {


                Console.WriteLine("Какую матрицу вы хотите загрузить из файла?");
                Console.WriteLine();
                Console.WriteLine("1.Созданную с помощью рандомно сгенерированных чисел.");
                Console.WriteLine("2.Созданную с помощью ввода с клавиатуры.");
                Console.WriteLine();
                a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:

                        FileStream file1 = new FileStream(h, FileMode.Open);
                        StreamReader reader1 = new StreamReader(file1);
                        Console.WriteLine(reader1.ReadToEnd());
                        reader1.Close();
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 2:
                        FileStream file2 = new FileStream(p, FileMode.Open);
                        StreamReader reader2 = new StreamReader(file2);
                        Console.WriteLine(reader2.ReadToEnd());
                        reader2.Close();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ОШИБКА!!!" + ex.Message);
                Console.WriteLine("Попробуйте ещё раз.");
                Console.ReadLine();
                Console.Clear();
            }


        }

        public void find_matrix_determinant()
        {
            int[,] matrix = new int[b, c];
            int m;

            try
            {
                Console.WriteLine("У какой матрицы вы хотите найти определитель?");
                Console.WriteLine();
                Console.WriteLine("1.У созданной с помощью рандомно сгенерированных чисел.");
                Console.WriteLine("2.У созданной с помощью ввода с клавиатуры.");
                Console.WriteLine();
                m = int.Parse(Console.ReadLine());
                switch (m)
                {

                    case 1:

                        if (!(b == c))
                        {
                            Console.WriteLine("Задайте пожалуйста квадратную матрицу, если хотите найти определитель!");
                            Console.ReadLine();
                            Console.Clear();

                        }
                        else
                        {
                            if (c > 3)
                            {
                                Console.WriteLine("Задайте пожалуйста матрицу 2 или 3 порядка для нахождения определителя!");
                                Console.ReadLine();
                                Console.Clear();
                            }
                            else
                            {



                                Console.WriteLine($"У вас есть матрица размера {b} X {c}:");
                                Console.WriteLine();
                                int t = 0;
                                int p = 1;
                                foreach (int x in plist)

                                    if (p++ % matrix.GetLength(1) == 0)
                                        Console.WriteLine(x);
                                    else
                                        Console.Write(x + " ");
                                Console.ReadLine();

                                for (i = 0; i < b; i++)
                                {
                                    for (j = 0; j < c; j++)
                                    {
                                        matrix[i, j] = plist[t];
                                        t++;
                                    }



                                }
                                Console.WriteLine();

                                if (c == 2)
                                {
                                    int a = matrix[0, 0] * matrix[1, 1] - matrix[1, 0] * matrix[0, 1];
                                    Console.WriteLine($"det A = {a}");
                                    Console.ReadLine();
                                    Console.Clear();
                                }
                                else
                                {
                                    if (c == 3)
                                    {
                                        int a = matrix[0, 0] * matrix[1, 1] * matrix[2, 2] + matrix[1, 0] * matrix[2, 1] * matrix[0, 2] + matrix[0, 1] * matrix[1, 2] * matrix[2, 0] - matrix[2, 0] * matrix[1, 1] * matrix[0, 2] - matrix[0, 1] * matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1] * matrix[0, 0];
                                        Console.WriteLine($"det A = {a}");
                                        Console.ReadLine();
                                        Console.Clear();
                                    }

                                }


                            }

                        }
                        break;

                    case 2:

                        if (!(b == c))
                        {
                            Console.WriteLine("Задайте пожалуйста квадратную матрицу, если хотите найти определитель!");
                            Console.ReadLine();
                            Console.Clear();

                        }
                        else
                        {
                            Console.WriteLine($"У вас есть матрица размера {b} X {c}:");
                            Console.WriteLine();
                            int t = 0;
                            int p = 1;
                            foreach (int x in tlist)

                                if (p++ % matrix.GetLength(1) == 0)
                                    Console.WriteLine(x);
                                else
                                    Console.Write(x + " ");
                            Console.ReadLine();

                            for (i = 0; i < b; i++)
                            {
                                for (j = 0; j < c; j++)
                                {
                                    matrix[i, j] = tlist[t];
                                    t++;
                                }



                            }
                            Console.WriteLine();

                            if (c == 2)
                            {
                                int a = matrix[0, 0] * matrix[1, 1] - matrix[1, 0] * matrix[0, 1];
                                Console.WriteLine($"det A = {a}");
                                Console.ReadLine();
                                Console.Clear();
                            }
                            else
                            {
                                if (c == 3)
                                {
                                    int a = matrix[0, 0] * matrix[1, 1] * matrix[2, 2] + matrix[1, 0] * matrix[2, 1] * matrix[0, 2] + matrix[0, 1] * matrix[1, 2] * matrix[2, 0] - matrix[2, 0] * matrix[1, 1] * matrix[0, 2] - matrix[0, 1] * matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1] * matrix[0, 0];
                                    Console.WriteLine($"det A = {a}");
                                    Console.ReadLine();
                                    Console.Clear();
                                }




                            }
                        }
                        break;
                }
            }



            catch (Exception ex)
            {
                Console.WriteLine("ОШИБКА!!!" + ex.Message);
                Console.WriteLine("Попробуйте ещё раз.");
                Console.ReadLine();
                Console.Clear();
            }
        }

        public void multiplication_matrix()

        {
            try
            {
                int[,] matrix = new int[b, c];
                int m, d, a;
                Console.WriteLine("Какую матрицу вы хотите перемножить с другой матрицей?");
                Console.WriteLine();
                Console.WriteLine("1.Созданную с помощью рандомно сгенерированных чисел.");
                Console.WriteLine("2.Созданную с помощью ввода с клавиатуры.");
                Console.WriteLine();
                m = int.Parse(Console.ReadLine());
                switch (m)
                {
                    case 1:
                        Console.WriteLine("Матрица №1:");
                        Console.WriteLine();
                        int p = 1;
                        foreach (int x in plist)

                            if (p++ % matrix.GetLength(1) == 0)
                                Console.WriteLine(x);
                            else
                                Console.Write(x + " ");
                        int t = 0;
                        for (i = 0; i < b; i++)
                        {
                            for (j = 0; j < c; j++)
                            {
                                matrix[i, j] = plist[t];
                                t++;
                            }

                        }
                        Console.ReadLine();
                        Console.WriteLine();

                        int s;
                        Console.WriteLine("Как вы хотите задать матрицу, на которую будете умножать?");
                        Console.WriteLine();
                        Console.WriteLine("1.C помощью рандомно сгенерированных чисел.");
                        Console.WriteLine("2.C помощью ввода с клавиатуры.");
                        Console.WriteLine();
                        s = int.Parse(Console.ReadLine());
                        switch (s)
                        {
                            case 1:
                                Console.WriteLine("Введите кол-во столбцов для вашей матрицы:");
                                d = int.Parse(Console.ReadLine());
                                Console.WriteLine($"Вы задали следующий размер для своей матрицы, а именно: {c} X {d}");
                                Console.ReadLine();
                                int[,] matrix1 = new int[c, d];
                                Console.WriteLine("Матрица №2:");
                                Console.WriteLine();
                                Random rnd = new Random();
                                for (i = 0; i < c; i++)
                                {
                                    for (j = 0; j < d; j++)
                                    {

                                        matrix1[i, j] = rnd.Next(1, 9);
                                        Console.Write(matrix1[i, j] + " ");
                                    }
                                    Console.WriteLine();
                                }
                                Console.WriteLine();
                                Console.WriteLine("Результат:");
                                Console.WriteLine();
                                a = 0;
                                int[,] matrix2 = new int[b, d];
                                while (a < b)
                                {


                                    for (j = 0; j < d; j++)
                                    {

                                        for (i = 0; i < c; i++)
                                        {
                                            matrix2[a, j] += matrix[a, i] * matrix1[i, j];
                                        }

                                    }

                                    a++;
                                }

                                for (i = 0; i < b; i++)
                                {
                                    for (j = 0; j < d; j++)
                                    {
                                        Console.Write("{0} ", matrix2[i, j]);
                                    }
                                    Console.WriteLine();
                                }
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            case 2:
                                Console.WriteLine("Введите кол-во столбцов для вашей матрицы:");
                                d = int.Parse(Console.ReadLine());
                                Console.WriteLine($"Вы задали следующий размер для своей матрицы, а именно: {c} X {d}");
                                Console.WriteLine();
                                Console.ReadLine();
                                int[,] matrix_1 = new int[c, d];

                                for (k = 0; k < c; k++)
                                {
                                    for (l = 0; l < d; l++)
                                    {
                                        Console.Write($"matrix_1[{k},{l}]:");
                                        matrix_1[k, l] = int.Parse(Console.ReadLine());

                                    }

                                }
                                Console.WriteLine();
                                Console.WriteLine("Матрица №2:");
                                Console.WriteLine();
                                for (k = 0; k < c; k++)
                                {
                                    for (l = 0; l < d; l++)
                                    {
                                        Console.Write(matrix_1[k, l] + " ");
                                    }
                                    Console.WriteLine();
                                }
                                Console.WriteLine();
                                Console.WriteLine("Результат:");
                                Console.ReadLine();
                                a = 0;
                                int[,] matrix_2 = new int[b, d];
                                while (a < b)
                                {


                                    for (j = 0; j < d; j++)
                                    {

                                        for (i = 0; i < c; i++)
                                        {
                                            matrix_2[a, j] += matrix[a, i] * matrix_1[i, j];


                                        }

                                    }

                                    a++;
                                }

                                for (i = 0; i < b; i++)
                                {
                                    for (j = 0; j < d; j++)
                                    {
                                        Console.Write("{0} ", matrix_2[i, j]);
                                    }
                                    Console.WriteLine();
                                }
                                Console.ReadLine();
                                Console.Clear();

                                break;

                            default:
                                Console.WriteLine("Некорректный ввод! Попробуйте ешё раз.");
                                Console.ReadLine();
                                Console.Clear();
                                break;
                        }
                        break;



                    case 2:
                        Console.WriteLine("Матрица №1:");
                        Console.WriteLine();
                        int o = 1;
                        foreach (int x in tlist)

                            if (o++ % matrix.GetLength(1) == 0)
                                Console.WriteLine(x);
                            else
                                Console.Write(x + " ");
                        int g = 0;
                        for (i = 0; i < b; i++)
                        {
                            for (j = 0; j < c; j++)
                            {
                                matrix[i, j] = tlist[g];
                                g++;
                            }

                        }
                        Console.ReadLine();
                        Console.WriteLine();

                        int h;
                        Console.WriteLine("Как вы хотите задать матрицу, на которую будете умножать?");
                        Console.WriteLine();
                        Console.WriteLine("1.C помощью рандомно сгенерированных чисел.");
                        Console.WriteLine("2.C помощью ввода с клавиатуры.");
                        Console.WriteLine();
                        h = int.Parse(Console.ReadLine());

                        switch (h)
                        {
                            case 1:
                                Console.WriteLine("Введите кол-во столбцов для вашей матрицы:");
                                d = int.Parse(Console.ReadLine());
                                Console.WriteLine($"Вы задали следующий размер для своей матрицы, а именно: {c} X {d}");
                                Console.ReadLine();
                                int[,] matrix1 = new int[c, d];
                                Console.WriteLine("Матрица №2:");
                                Console.WriteLine();
                                Random rnd = new Random();
                                for (i = 0; i < c; i++)
                                {
                                    for (j = 0; j < d; j++)
                                    {

                                        matrix1[i, j] = rnd.Next(1, 9);
                                        Console.Write(matrix1[i, j] + " ");
                                    }
                                    Console.WriteLine();
                                }
                                Console.WriteLine();
                                Console.WriteLine("Результат:");
                                Console.WriteLine();
                                a = 0;
                                int[,] matrix2 = new int[b, d];
                                while (a < b)
                                {


                                    for (j = 0; j < d; j++)
                                    {

                                        for (i = 0; i < c; i++)
                                        {
                                            matrix2[a, j] += matrix[a, i] * matrix1[i, j];
                                        }

                                    }

                                    a++;
                                }

                                for (i = 0; i < b; i++)
                                {
                                    for (j = 0; j < d; j++)
                                    {
                                        Console.Write("{0} ", matrix2[i, j]);
                                    }
                                    Console.WriteLine();
                                }
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            case 2:
                                Console.WriteLine("Введите кол-во столбцов для вашей матрицы:");
                                d = int.Parse(Console.ReadLine());
                                Console.WriteLine($"Вы задали следующий размер для своей матрицы, а именно: {c} X {d}");
                                Console.WriteLine();
                                Console.ReadLine();
                                int[,] matrix_1 = new int[c, d];

                                for (k = 0; k < c; k++)
                                {
                                    for (l = 0; l < d; l++)
                                    {
                                        Console.Write($"matrix_1[{k},{l}]:");
                                        matrix_1[k, l] = int.Parse(Console.ReadLine());

                                    }

                                }
                                Console.WriteLine();
                                Console.WriteLine("Матрица №2:");
                                Console.WriteLine();
                                for (k = 0; k < c; k++)
                                {
                                    for (l = 0; l < d; l++)
                                    {
                                        Console.Write(matrix_1[k, l] + " ");
                                    }
                                    Console.WriteLine();
                                }
                                Console.WriteLine();
                                Console.WriteLine("Результат:");
                                Console.ReadLine();
                                a = 0;
                                int[,] matrix_2 = new int[b, d];
                                while (a < b)
                                {


                                    for (j = 0; j < d; j++)
                                    {

                                        for (i = 0; i < c; i++)
                                        {
                                            matrix_2[a, j] += matrix[a, i] * matrix_1[i, j];


                                        }

                                    }

                                    a++;
                                }

                                for (i = 0; i < b; i++)
                                {
                                    for (j = 0; j < d; j++)
                                    {
                                        Console.Write("{0} ", matrix_2[i, j]);
                                    }
                                    Console.WriteLine();
                                }
                                Console.ReadLine();
                                Console.Clear();

                                break;

                            default:
                                Console.WriteLine("Некорректный ввод! Попробуйте ешё раз.");
                                Console.ReadLine();
                                Console.Clear();
                                break;

                        }
                        break;
                    default:
                        Console.WriteLine("Некорректный ввод! Попробуйте ешё раз.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ОШИБКА!!!" + ex.Message);
                Console.WriteLine("Попробуйте ещё раз.");
                Console.ReadLine();
                Console.Clear();
            }

        }





        public void addition_matrix()
        {
            int[,] matrix = new int[b, c];
            int m;
            try
            {
                Console.WriteLine("Какую матрицу вы хотите сложить с другой матрицей?");
                Console.WriteLine();
                Console.WriteLine("1.Созданную с помощью рандомно сгенерированных чисел.");
                Console.WriteLine("2.Созданную с помощью ввода с клавиатуры.");
                Console.WriteLine();
                m = int.Parse(Console.ReadLine());
                switch (m)
                {
                    case 1:
                        Console.WriteLine("Матрица №1:");
                        Console.WriteLine();
                        int p = 1;
                        foreach (int x in plist)
                            if (p++ % matrix.GetLength(1) == 0)
                                Console.WriteLine(x);
                            else
                                Console.Write(x + " ");
                        int t = 0;
                        for (i = 0; i < b; i++)
                        {
                            for (j = 0; j < c; j++)
                            {
                                matrix[i, j] = plist[t];
                                t++;
                            }

                        }
                        Console.ReadLine();
                        Console.WriteLine();

                        int s;
                        Console.WriteLine("Как вы хотите задать матрицу, с которой будете складывать?");
                        Console.WriteLine();
                        Console.WriteLine("1.C помощью рандомно сгенерированных чисел.");
                        Console.WriteLine("2.C помощью ввода с клавиатуры.");
                        Console.WriteLine();
                        s = int.Parse(Console.ReadLine());
                        switch (s)
                        {
                            case 1:
                                Console.WriteLine($"Вы задали следующий размер для своей матрицы, а именно: {b} X {c}");
                                Console.ReadLine();
                                int[,] matrix1 = new int[b, c];
                                Console.WriteLine("Матрица №2:");
                                Console.WriteLine();
                                Random rnd = new Random();
                                for (i = 0; i < b; i++)
                                {
                                    for (j = 0; j < c; j++)
                                    {

                                        matrix1[i, j] = rnd.Next(1, 9);
                                        Console.Write(matrix1[i, j] + " ");
                                    }
                                    Console.WriteLine();
                                }
                                Console.WriteLine();
                                Console.WriteLine("Результат:");
                                Console.WriteLine();
                                int[,] matrix2 = new int[b, c];
                                for (i = 0; i < b; i++)
                                {

                                    for (j = 0; j < c; j++)
                                    {
                                        matrix2[i, j] = matrix[i, j] + matrix1[i, j];
                                    }

                                }

                                for (i = 0; i < b; i++)
                                {
                                    for (j = 0; j < c; j++)
                                    {
                                        Console.Write("{0} ", matrix2[i, j]);
                                    }
                                    Console.WriteLine();
                                }
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            case 2:
                                Console.WriteLine($"Вы задали следующий размер для своей матрицы, а именно: {b} X {c}");
                                Console.WriteLine();
                                Console.ReadLine();
                                int[,] matrix_1 = new int[b, c];
                                for (k = 0; k < b; k++)
                                {
                                    for (l = 0; l < c; l++)
                                    {
                                        Console.Write($"matrix_1[{k},{l}]:");
                                        matrix_1[k, l] = int.Parse(Console.ReadLine());

                                    }

                                }
                                Console.WriteLine();
                                Console.WriteLine("Матрица №2:");
                                Console.WriteLine();
                                for (k = 0; k < b; k++)
                                {
                                    for (l = 0; l < c; l++)
                                    {
                                        Console.Write(matrix_1[k, l] + " ");
                                    }
                                    Console.WriteLine();
                                }
                                Console.WriteLine();
                                Console.WriteLine("Результат:");
                                Console.ReadLine();
                                int[,] matrix_2 = new int[b, c];
                                for (i = 0; i < b; i++)
                                {

                                    for (j = 0; j < c; j++)
                                    {
                                        matrix_2[i, j] = matrix[i, j] + matrix_1[i, j];
                                    }

                                }

                                for (i = 0; i < b; i++)
                                {
                                    for (j = 0; j < c; j++)
                                    {
                                        Console.Write("{0} ", matrix_2[i, j]);
                                    }
                                    Console.WriteLine();
                                }
                                Console.ReadLine();
                                Console.Clear();
                                break;
                        }
                        break;

                    case 2:
                        Console.WriteLine("Матрица №1:");
                        Console.WriteLine();
                        int o = 1;
                        foreach (int x in tlist)

                            if (o++ % matrix.GetLength(1) == 0)
                                Console.WriteLine(x);
                            else
                                Console.Write(x + " ");
                        int g = 0;
                        for (i = 0; i < b; i++)
                        {
                            for (j = 0; j < c; j++)
                            {
                                matrix[i, j] = tlist[g];
                                g++;
                            }

                        }
                        Console.ReadLine();
                        Console.WriteLine();

                        int h;
                        Console.WriteLine("Как вы хотите задать матрицу, на которую будете умножать?");
                        Console.WriteLine();
                        Console.WriteLine("1.C помощью рандомно сгенерированных чисел.");
                        Console.WriteLine("2.C помощью ввода с клавиатуры.");
                        Console.WriteLine();
                        h = int.Parse(Console.ReadLine());
                        switch (h)
                        {
                            case 1:
                                Console.WriteLine($"Вы задали следующий размер для своей матрицы, а именно: {b} X {c}");
                                Console.ReadLine();
                                int[,] matrix1 = new int[b, c];
                                Console.WriteLine("Матрица №2:");
                                Console.WriteLine();
                                Random rnd = new Random();
                                for (i = 0; i < b; i++)
                                {
                                    for (j = 0; j < c; j++)
                                    {

                                        matrix1[i, j] = rnd.Next(1, 9);
                                        Console.Write(matrix1[i, j] + " ");
                                    }
                                    Console.WriteLine();
                                }
                                Console.WriteLine();
                                Console.WriteLine("Результат:");
                                Console.WriteLine();
                                int[,] matrix2 = new int[b, c];
                                for (i = 0; i < b; i++)
                                {

                                    for (j = 0; j < c; j++)
                                    {
                                        matrix2[i, j] = matrix[i, j] + matrix1[i, j];
                                    }

                                }

                                for (i = 0; i < b; i++)
                                {
                                    for (j = 0; j < c; j++)
                                    {
                                        Console.Write("{0} ", matrix2[i, j]);
                                    }
                                    Console.WriteLine();
                                }
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            case 2:
                                Console.WriteLine($"Вы задали следующий размер для своей матрицы, а именно: {b} X {c}");
                                Console.WriteLine();
                                Console.ReadLine();
                                int[,] matrix_1 = new int[b, c];
                                for (k = 0; k < b; k++)
                                {
                                    for (l = 0; l < c; l++)
                                    {
                                        Console.Write($"matrix_1[{k},{l}]:");
                                        matrix_1[k, l] = int.Parse(Console.ReadLine());

                                    }

                                }
                                Console.WriteLine();
                                Console.WriteLine("Матрица №2:");
                                Console.WriteLine();
                                for (k = 0; k < b; k++)
                                {
                                    for (l = 0; l < c; l++)
                                    {
                                        Console.Write(matrix_1[k, l] + " ");
                                    }
                                    Console.WriteLine();
                                }
                                Console.WriteLine();
                                Console.WriteLine("Результат:");
                                Console.ReadLine();
                                int[,] matrix_2 = new int[b, c];
                                for (i = 0; i < b; i++)
                                {

                                    for (j = 0; j < c; j++)
                                    {
                                        matrix_2[i, j] = matrix[i, j] + matrix_1[i, j];
                                    }

                                }

                                for (i = 0; i < b; i++)
                                {
                                    for (j = 0; j < c; j++)
                                    {
                                        Console.Write("{0} ", matrix_2[i, j]);
                                    }
                                    Console.WriteLine();
                                }
                                Console.ReadLine();
                                Console.Clear();
                                break;
                        }
                        break;

                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("ОШИБКА!!!" + ex.Message);
                Console.WriteLine("Попробуйте ещё раз.");
                Console.ReadLine();
                Console.Clear();
            }
        }




        class Program
        {

            static void Main(string[] args)
            {
                int a;
                try
                {
                Metka:
                    Console.WriteLine("1-Задание размера матрицы");
                    Console.WriteLine();
                    Console.WriteLine("2-Заполнение матрицы случайными значениями");
                    Console.WriteLine();
                    Console.WriteLine("3-Ввод матрицы с клавиатуры");
                    Console.WriteLine();
                    Console.WriteLine("4-Вывод матрицы на экран");
                    Console.WriteLine();
                    Console.WriteLine("5-Сохранение матрицы в файл");
                    Console.WriteLine();
                    Console.WriteLine("6-Загрузка матрицы из файла");
                    Console.WriteLine();
                    Console.WriteLine("7-Нахождение определителя матрицы");
                    Console.WriteLine();
                    Console.WriteLine("8-Умножение на другую матрицу");
                    Console.WriteLine();
                    Console.WriteLine("9-Сложение с другой матрицей");
                    Console.WriteLine();
                    a = int.Parse(Console.ReadLine());
                    Console.Clear();



                    switch (a)
                    {
                        case 1:
                            Matrix p = new Matrix();
                            p.matrix_size();
                            goto Metka;


                        case 2:
                            Matrix f = new Matrix();
                            f.matrix_random();
                            goto Metka;

                        case 3:
                            Matrix l = new Matrix();
                            l.matrix_keyboard();
                            goto Metka;

                        case 4:
                            Matrix s = new Matrix();
                            s.matrix_on_screen();
                            goto Metka;

                        case 5:
                            Matrix y = new Matrix();
                            y.matrix_save();
                            goto Metka;

                        case 6:
                            Matrix z = new Matrix();
                            z.matrix_download();
                            goto Metka;

                        case 7:
                            Matrix n = new Matrix();
                            n.find_matrix_determinant();
                            goto Metka;

                        case 8:
                            Matrix h = new Matrix();
                            h.multiplication_matrix();
                            goto Metka;

                        case 9:
                            Matrix m = new Matrix();
                            m.addition_matrix();
                            goto Metka;

                        default:
                            Console.WriteLine("Некорректный ввод! Попробуйте ешё раз.");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("ОШИБКА!!!" + ex.Message);
                    Console.WriteLine("Попробуйте ещё раз.");
                    Console.ReadLine();
                    Console.Clear();
                }

            }


        }
    }
}


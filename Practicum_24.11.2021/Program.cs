// Комп загадал число в диапазоне
// Далее он предлагает игроку угадать число
// Игрок вводит число
// 1. Правильное ли это число
// 2. Загаданное число больше этого числа
// 3. Загаданное число меньше этого числа
// После этого игрок делает следующую загадку
// У игрока есть некоторое количество попыток

// Если попытки закончились, то игра закончилась
// Если игрок угадал число, игра тоже заканчивается

// 1. Определить диапазон - задаём, рандом, или запросили у пользователя. Определить необходимое количество попыток
// 2. Загадать число в указанном диапазоне
// 3. Начало игры - описываем правила
// 4. Запрашиваем у пользователя число. Пользователь вводит число (можно проверить на нештатную ситуацию). Определяем как оно 
// соотносится с нашим загаданным числом. Если не угадал, попытка сгорает. 
// 5. Игра продолжается, пока есть попытки.

// int requestNumber() - запрашивает число у игрока

// int createNumber() - загадает число в указанном диапазоне и вернёт его нам

// bool MakeMove(int secretNuber, int CountOfAttempts) - метод, в котором запрограммирован один игровой ход, метод возвращает либо
// true либо false

// int SecretNumber = createNumber(1, 10)


// Консольная игра "Угадай число"
// Комп загадал число в некотором диапазоне, например от 1 до 100. Далее он предлагает игроку угадать это число. Игрок вводит некоторое число и комп "отвечает":

// правильное ли это число или
// Загаданное число больше чем введенное
// загаданное число меньше чем введенное. После этого игрок делает следующую догадку. У Игрока есть некоторое количество попыток.
// Если игрок потратил все свои попытки, то игра заканчивается. Если игрок угадал число, но попытки еще остались, игра также заканчивается.

// Определить условия. (какой диапазон для загадывания чисел - мы его задаем, формируем рандомно или запрашиваем у пользователя?; определиться с количеством попыток - высчитать необходимое количество попыток, либо запросить у участника)
// Загадать число в указанном диапазоне.
// Начало игры - описываем правила.
// Запрашиваем у пользователя число. Пользователь вводит некоторое число (добавить проверку нештатных ситуаций). Определяем как оно соотносится с нашим загаданным и даем следующие инструкции игроку. Если пользователь не угадал, то у него сгорает 1 попытка.
// Игра продолжается пока есть попытки или пока пользователь не угадал число.
// int requestNumber() - метод запросит у игрока число, сделает все необходимые преобразования и вернет нам это число. int createNumber(int leftBound, int rightBound) - загадает число в указанном диапазоне и вернет его нам. bool MakeMove(int SecretNumber, int CountOfAttempts) - метод, в котором запрограммирован 1 игровой ход, в результате метод возвращает либо true, либо false. true если пользователь угадал число и игру надо остановить, false, если пользователь не угадал.

// int SecretNumber = createNumber(1, 100); int PlayersNumber = requestNumber();



// void GameInit() // метод с описание игры
// {
//     System.Console.WriteLine("Игра Угадай число");
// }

// 1. int createNumber() - загадает число в указанном диапазоне и вернёт его нам

// 2. int requestNumber() - запрашивает число у игрока

// 3. bool 

int CreateNumber(int leftBound, int rigthBound)
{
    int number = new Random().Next(leftBound, rigthBound);
    return number;
}

int RequestNumber()
{
    string inputdata = String.Empty;
    bool conduction = true;
    do
    {
        inputdata = Console.ReadLine()!;
        conduction = (String.IsNullOrEmpty(inputdata)) || !(Int32.TryParse(inputdata, out int outnumber));
    } while (conduction);
    return Convert.ToInt32(inputdata);
}

// int num = RequestNumber();
// System.Console.WriteLine(num);

// int num = CreateNumber(1, 21);
// System.Console.WriteLine(num);

void MakeMove(int secretNumber)
{
    int countAttempts = 3;
    int playersNumber = 0;
    do
    {
        playersNumber = RequestNumber();

        if (playersNumber == secretNumber)
        {
            System.Console.WriteLine("Вы победили");
        }
        else
        {
            countAttempts -= 1;
            if (playersNumber > secretNumber)
            {
                System.Console.WriteLine("Загаданное число меньше вашего. Количество попыток: " + countAttempts);
            }
            else
            {
                System.Console.WriteLine("Загаданное число больше вашего. Количество попыток: " + countAttempts);
            }
        }
    } while (countAttempts > 0 && playersNumber != secretNumber);
    if (countAttempts == 0)
    {
        System.Console.WriteLine("Вы проиграли");
    }
}

int secretNumber = CreateNumber(1, 21);
System.Console.WriteLine(secretNumber);
MakeMove(secretNumber);

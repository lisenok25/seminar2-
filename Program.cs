// Задача 10.написать прогу, кот принимает на вход трехзначное число и
//на выход показывает вторую цифру этого числа
//(решать через Random)

// возвращаемая функция

// int CutNumber(){
//     int num = new Random().Next(100,1000);
//     Console.WriteLine("numbers is-  " + num);
//     int dec = num / 10;
//     int ed = dec % 10;
//     int result = ed;
//     return result;
// }

// int number = CutNumber();
// Console.WriteLine("Cut number is-  " + number);




// Задача 13.написать прогу, кот выводит третью цифру заданного числа
//или сообщает, что третьей цифры нет

 
//  void Num(int a){
//     while (a > 999){

//         int ed = a / 10;
//         a=ed;
//         } 

//     if (a <= 999){
//         int dec = a % 10;
//         Console.WriteLine("Третья цифра данного числа- " + dec );
//         } 
//     if ( a < 100){
//         Console.WriteLine("Третьей цифры нет");
//     }
//  }

//  Console.WriteLine("Введите любое число");
//  int a = Convert.ToInt32(Console.ReadLine());
//  Num(a);



   

//задача 15.Написать прогу, кот принимает на вход цифру, обозначающую
// день недели, и проверяет, является ли этот день выходным

// void Den(int a){
//     if (a > 0 && a <= 5){
//         Console.WriteLine("Будний день");
//     } 
//         if (a > 5 && a <= 7){
//         Console.WriteLine("Выходной день");
//         }
//         else if(a <= 0 || a > 7) {
//         Console.WriteLine("Нет такого дня недели.Введите число соответствующее дню недели");
//         }                  
    
// }

// Console.WriteLine("Введите число соответствующее дню недели");
// int a = Convert.ToInt32(Console.ReadLine());
// Den(a);
 
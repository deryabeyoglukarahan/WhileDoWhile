Console.Write("Bir limit değeri giriniz:");
int limit = Convert.ToInt32(Console.ReadLine());

//While Döngüsü
int sayac= 0;
while (sayac <= limit)
{
    Console.WriteLine("Ben bir Patika'lıyım");
    sayac++;
}

//Do-While Döngüsü
int sayac2 = 0;
do{
    Console.WriteLine("Ben bir Patika'lıyım");
    sayac2++;
}while (sayac2 <= limit);


/*
WHILE döngüsü önce koşulu kontrol eder, sonra çalışır. Bu yüzden limit negatif olduğunda hiç çalışmaz.
Örnek: limit = -5 → while döngüsü çalışmaz.
        
DO-WHILE döngüsü önce çalışır, sonra koşulu kontrol eder. Bu yüzden limit negatif bile olsa en az bir kez çalışır.
Örnek: limit = -5 → do-while döngüsü ekrana bir kez "Ben bir Patika'lıyım" yazar.
*/



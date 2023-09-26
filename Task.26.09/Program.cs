////////Task1


////////Console.WriteLine("4 reqemli eded daxil edin");
////////int eded = int.Parse(Console.ReadLine());

////////if (eded < 1000 || eded > 9999)
////////{
////////    Console.WriteLine("Eded 4 reqemli deyil");

////////}
////////else
////////{
////////    int minlik = eded / 1000;
////////    int yuzluk = (eded / 100) % 10;
////////    int onluq = (eded / 10) % 10;
////////    int teklik = eded % 10;

////////    int cem = minlik + yuzluk + onluq + teklik;

////////    Console.WriteLine("Mertebelerin cemi- " + cem);

////////}



//////Task 2

//////Console.WriteLine("3 reqemli eded daxil et");

//////int eded = int.Parse(Console.ReadLine());

//////int yuzluk = eded / 100;
//////int onluq = (eded / 10) % 10;
//////int teklik = eded % 10;

//////bool MertebelerFerqlidir = false;

//////if (yuzluk != onluq && yuzluk != teklik && onluq != teklik)
//////{
//////    MertebelerFerqlidir = true;
//////    Console.WriteLine("Mertebeler ferqlidir");

//////}

//////else
//////{
//////    Console.WriteLine("Ferqli olmayanlar var");

//////}




////Task 3
////    Console.Write("a daxil et ");
////int a = int.Parse(Console.ReadLine());

////Console.Write("b daxil et ");
////int b = int.Parse(Console.ReadLine());

////Console.WriteLine("Evvel");

////Console.WriteLine("a =" + a);
////Console.WriteLine("b = " + b);

////a = a + b;
////b = a - b;
////a = a - b;

////Console.WriteLine("Sonra");

////Console.WriteLine("a = " + a);
////Console.WriteLine("b = " + b);





//Task 4

//     Console.Write("Yas daxil edin");
//int age = int.Parse(Console.ReadLine());

//Console.Write("Telebe biletiniz varsa 'true' yoxdursa 'false' daxil edin ");
//bool IsStudent = bool.Parse(Console.ReadLine());

//double TicketPrice = 0.0;

//if (age <= 12 || age >= 60)
//{
//    TicketPrice = 5.0;
//}

//else if (age >= 13 && age <= 59)
//{
//    if (IsStudent)
//    {
//        TicketPrice = 7.5;
//    }
//    else
//    {
//        TicketPrice = 10.0;
//    }
//}

//else
//{
//    Console.WriteLine("Yanlis melumat");
//}

//Console.WriteLine("Bilet qiymeti " + TicketPrice + " azn");

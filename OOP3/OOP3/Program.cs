// See https://aka.ms/new-console-template for more information

using OOP3;
using System.Collections.Generic;

IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
IKrediManager tasitKrediManager = new TasitKrediManager();
IKrediManager konutKrediManager = new KonutKrediManager();

ILoggerService databaseloggerService = new DatabaseLoggerService();
ILoggerService fileloggerService = new FilebaseLoggerService();

BasvuruManager basvuruManager = new BasvuruManager();
basvuruManager.BasvuruYap(new EsnafKredisiManager(), new SmsLoggerService());

List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager };
//basvuruManager.KrediOnBilgilendirmesiYap(krediler);
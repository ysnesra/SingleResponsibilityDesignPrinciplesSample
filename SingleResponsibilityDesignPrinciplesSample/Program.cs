using SingleResponsibilityDesignPrinciplesSample.DataAccess;
using SingleResponsibilityDesignPrinciplesSample.Entities;

BaseOperation<Personel> personeloperation = new BaseOperation<Personel>();
Personel personel=new Personel();

//personel.Id = 1;
personel.Name = "Esra";
personel.Surname = "Yaşın";

var result=personeloperation.Add(personel);
Console.WriteLine(result.Name);  
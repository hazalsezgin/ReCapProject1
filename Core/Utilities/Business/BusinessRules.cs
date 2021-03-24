using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics) //logics iş kuralı demekmiş silersin bunları not yazıyorum
        {
            foreach (var logic in logics)
            {
                if (!logic.Success)
                {
                    return logic;     // burda diyokki ıresult arrayını gez ordaki her bir logicin successi error se yani başarısızsa logiçi çalıştır demekOKİ yani eğer başarılıysa girmiycek
                }
            }
            return null; // bu succes başarılıysa çalışcak boş döndür diye
        }
        
    }
}

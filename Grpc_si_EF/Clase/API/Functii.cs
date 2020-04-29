using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.API
{
    public class Functii
    {
        static public void Inserare_com(string nume, string descriere)
        {
            using (Model1Container context = new Model1Container())
            {
               
                    Comment com = new Comment()
                    {
                        Nume = nume,
                        Descriere = descriere

                    };
                    context.CommentSet.Add(com);
                    context.SaveChanges();
              

            }
        }
    }
}

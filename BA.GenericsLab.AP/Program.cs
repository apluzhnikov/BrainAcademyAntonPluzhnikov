using BA.GenericsLab.AP.GenericStorage;
using BA.GenericsLab.AP.GenericStorage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA.GenericsLab.AP
{
    class Program
    {
        static readonly string[] s_bookNames =
            {
                "Awfully Ancient", "But Is It Art?","Contemporary Cartoon Creators", "Down & Dirty: The Secrets of Soil",
                "Examining Disasters", "Look Inside Machines", "On a Mission", "Write This Way", "Writer’s Notebook"
            };

        static Random rand = new Random();

        static void Main(string[] args) {
            BaseEntity book;
            IEntityService<BaseEntity> entityService = new EntityStorage<BaseEntity>();
            for (int i = 0; i < s_bookNames.Length; i++)
            {
                book = new BookEntity()
                {
                    Id = i + 1,
                    Description = string.Format("Descrition of a book: {0}", s_bookNames[i]),
                    Name = s_bookNames[i],
                    Price = (i + 1) * rand.Next(0, 30)

                };
                entityService.Add(book);
            }

            Console.WriteLine("Library list:");

            ShowAllEntities(entityService);

            Console.WriteLine("If you want to remove a book, then just write an ID below. If no, then press 'Enter' button");
            int id = 0;
            if (int.TryParse(Console.ReadLine(), out id) && id > 0)
            {
                var bookEntity = entityService.Find(id);
                if (bookEntity != null)
                {
                    try
                    {
                        entityService.Delete(bookEntity);
                        ShowAllEntities(entityService);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Exception received while deliting the book with id {0}\nEcxeption message: ", id, ex.Message);
                    }
                } else
                    Console.WriteLine("Book with id {0} not found", id);


            } else
                Console.WriteLine("Nothing to delete");

            Console.ReadLine();
        }

        static void ShowAllEntities<T>(T entityService) where T : IEntityService<BaseEntity> {
            foreach (BaseEntity baseEntity in entityService.GetAll())
                Console.WriteLine(baseEntity);
        }

    }
}

using System.Runtime.CompilerServices;
using Core.Models;
namespace RecordsTuplestask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string title;
            string description;
            string choice;
            string content;
            string idcomment;
            int id;

            do
            {
                Console.WriteLine("1.Blog yarat\n0.Proqramdan cix");
                choice = Console.ReadLine();

                if (choice == "1")
                {

                    do
                    {
                        Console.WriteLine("Blogun title deyerini daxil edin");
                        title = Console.ReadLine();
                    } while (!Helper.CheckBlogTitle(title));

                    do
                    {
                        Console.WriteLine("Blogun description deyerini daxil edin");
                        description = Console.ReadLine();
                    } while (!Helper.CheckBlogDescription(description));


                    Blog blog = new Blog(title, description);


                    do
                    {

                        Console.WriteLine("\n1.Comment yarat\n2.Commentlere bax\n3.Commente bax\n4.Commenti sil\n5.Commenti dəyiş\nProqramdan cıx");
                        choice = Console.ReadLine();
                        switch (choice)

                        {
                            case "o":

                                break;

                            case "1":

                                Console.WriteLine("Comment ucun content daxil edin");
                                content = Console.ReadLine();

                                Comment comment = new Comment(content);
                                blog.AddComment(comment);
                                break;


                            case "2":
                                Console.WriteLine("commentlere bax: ");
                                for (int i = 0; i < blog.GetAllComments().Length; i++)
                                    Console.WriteLine(blog.GetAllComments()[i].ToString());
                                break;

                            case "3":

                                do
                                {
                                    Console.WriteLine("Baxilacaq commentin id nomresini daxil edin:  ");
                                    idcomment = Console.ReadLine();

                                } while (!(int.TryParse(idcomment, out id)));
                                Console.WriteLine(blog.GetComment(id).ToString());
                                break;


                            case "4":


                                {
                                    Console.WriteLine("Silinmeli commentin id sini daxil edin");
                                    idcomment = Console.ReadLine();

                                } while (!(int.TryParse(idcomment, out id))) ;
                                blog.RemoveComment(id);
                                Console.WriteLine($"silinmis {id} li comment");
                                break;

                            case "5":

                                do
                                {
                                    Console.WriteLine("Deyisilen commentin id nomresini daxil edin");
                                    idcomment = Console.ReadLine();
                                } while (!(int.TryParse(idcomment, out id)));

                                Console.WriteLine("Yeni comment ucun content daxil etmek lazimdir");
                                content = Console.ReadLine();

                                Comment Freshcomment = new Comment(content);
                                blog.UptadeComment(id, Freshcomment);
                                break;

                            default:
                                break;

                        }
                    } while (choice ! == "0");
                }

                else if(choice == "0")
                {
                    break;
                }


                        





                    






                





















































            } while (true);










































        }
    }
}

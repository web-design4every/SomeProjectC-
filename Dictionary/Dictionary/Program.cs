using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dictionary
{
    public class Dictionary
    {
    }

    public class Word : Dictionary
    {
        string content;
        public Word(string Content)
        {
            this.content = Content;
        }
        public string getcontent()
        {
            return content;
        }
    }

    public class Description : Dictionary
    {
        string description;
        public Description(string des)
        {
            this.description = des;
        }
        public string getdescription()
        {
            return description;
        }
    }

    public class dic<E,B> where E: Word where B:List<Description>
    {
        public E key;
        public B value;
        public dic()
        {
            
        }

        public void adddic(E Word, B Description)
        {
            this.key = Word;
            this.value = Description;
        }

        public E GetKey()
        {
            return key;
        }

        public void get(List<dic<Word, List<Description>>> listword, string enter)
        {
            bool check = true;
            foreach (dic<Word, List<Description>> dic in listword)
            {
                if (dic.GetKey().getcontent().Equals(enter))
                {
                    Console.WriteLine("Word content: " + enter);
                    Console.WriteLine("Description: ");
                    foreach (Description d in dic.value)
                    {
                        Console.WriteLine("+) " + d.getdescription());
                    }
                    check = true;
                    break;
                }
                else
                {
                    check = false;
                }
            }
            if(check == false)
            {
                Console.WriteLine("Cant find this word!");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string content = null;
            string description;
            dic<Word, List<Description>> dic = new dic<Word, List<Description>>();
            List<dic<Word, List<Description>>> listword = new List<dic<Word, List<Description>>>();
            List<Description> list = new List<Description>();
            Word w = new Word(content);
            while (true)
            {
                Console.WriteLine("\n-----Dictionary-----");
                Console.WriteLine("1. Enter Word");
                Console.WriteLine("2. Find Word");
                Console.WriteLine("3. Exit");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter new word:  ");
                        content = Console.ReadLine();
                        w = new Word(content);
                        dic = new dic<Word, List<Description>>();
                        list = new List<Description>();
                        while (true)
                        {
                            Console.Write("Enter descripption:  ");
                            description = Console.ReadLine();
                            list.Add(new Description(description));
                            Console.WriteLine("Add more description? (Y/N) ");
                            string str = Console.ReadLine();
                            if (str.Equals("N")||str.Equals("n")) break;
                        }
                        dic.adddic(w, list);
                        listword.Add(dic);
                        break;
                    case 2:
                        Console.Write("Enter word:  ");
                        content = Console.ReadLine();
                        dic.get(listword, content);
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Enter again: ");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}

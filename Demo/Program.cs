using Demo.Fifa;
using Demo.YouTube;
using System.Collections;

namespace Demo
{
    internal class Program
    {
        static void Main()
        {
            #region  Non-Generic Hashtables : Hashtable
            // Collection : Built-in Ds in C#
            // Non-Generic Hashtables : Hashtable

            //Hashtable phoneBook  = new Hashtable();
            //phoneBook.Add("Ahmed", 111111);
            //phoneBook.Add("Ali",222222);
            //phoneBook.Add("Amr", 333333);
            //phoneBook.Add(111111, "Ahmed");
            //phoneBook.Add(null, 111111);

            //Console.WriteLine(phoneBook.IsFixedSize); 
            //Console.WriteLine(phoneBook.IsReadOnly);

            //foreach (var item in phoneBook.Values) 
            //{
            //    Console.WriteLine(item);
            //}

            //phoneBook["Ahmedss"] = " 2211133";
            //Console.WriteLine(phoneBook["Ahmed"]);
            //phoneBook.Clear();
            //Console.WriteLine(phoneBook.Count);

            //var flag = phoneBook.Contains("Ahmed");
            //Console.WriteLine(flag);

            //var flag = phoneBook.ContainsValue("Ahmed");
            //Console.WriteLine(flag);

            //phoneBook.Remove(null); //Exception

            //Console.WriteLine();
            //Console.WriteLine("--------------------");

            //foreach (DictionaryEntry item in phoneBook)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Generic Collection : Dictionary

            //Dictionary<string,long> phoneBook = new Dictionary<string,long>();
            //phoneBook.Add("Ahmed",111111);
            //phoneBook.Add("Ali",222222);
            //phoneBook.Add(null,222222);

            //phoneBook.Add("Amr",333333);
            //phoneBook.Add(222222,333333);

            //var flag = phoneBook.Remove("Ahmed", out long result );
            //Console.WriteLine(flag);
            //Console.WriteLine(result);

            //phoneBook.TryAdd("Ahmed",1111);
            //phoneBook.TryGetValue("Ahmedddd", out long result);

            //Console.WriteLine(result);

            //foreach (KeyValuePair<string,long> item in phoneBook)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Generic Collection : HashSet

            //HashSet<string> Names = new HashSet<string>();

            //Names.Add("Ahmed");
            //Names.Add("Ahmed");
            //Names.Add("Amr");
            //Names.Add("Ali");

            //Names.Contains

            //foreach (var item in Names) 
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region SortedDictionary

            //SortedDictionary<int,string>pairs = new SortedDictionary<int,string>();

            //pairs.Add(23,"Ahmed");
            //pairs.Add(13,"Omar");
            //pairs.Add(20,"Amr");
            //pairs.Add(1,"Ali");


            //foreach (var item in pairs)
            //{ 
            //    Console.WriteLine(item);
            //}

            #endregion

            #region  Generic Collection : Sorted DS - SortedList - SortedSet

            //SortedList<int, string> pairs = new SortedList<int, string>();

            //pairs.SetValueAtIndex(1,"ahmed");
            //pairs.Add(1, "Ahmed");
            //pairs.Add(2, "Ali");
            //pairs.Add(3, "Omar");
            //pairs.Add(3, "Omar");//Exception

            //SortedSet<int> values = new SortedSet<int>();

            #endregion

            #region Event Ex01
            //Ball ball = new Ball() { Id = 1};
            //Console.WriteLine(ball);

            //ball.Location = new Location() { X = 1,Y = 1 ,Z = 1};
            //Console.WriteLine(ball);

            //Player P01= new Player() { Name="Messi" , TeamName="Miami" };
            //Player P02= new Player() { Name="Alba" , TeamName="Miami" };

            //Player P03= new Player() { Name="Pedri" , TeamName="Barcelona" };
            //Player P04= new Player() { Name="Gavi" , TeamName= "Barcelona" };
            //Player P05 = new Player() { Name = "Salah", TeamName = "Barcelona" };


            //Refree R01 = new Refree() { Name = "Ibrahim Nour El-Deen"};

            //Coach C01 = new Coach() { Name = "Flek", TeamName = "Barcelona" };

            //ball.Players.Add(P01);
            //ball.Players.Add(P02);
            //ball.Players.Add(P03);
            //ball.Players.Add(P04);
            //ball.Refrees.Add(R01);

            //ball.BallLocationChanged += P01.Run;
            //ball.BallLocationChanged += P02.Run;
            //ball.BallLocationChanged += P03.Run;
            //ball.BallLocationChanged += P04.Run;

            //ball.BallLocationChanged += R01.Look;
            //ball.BallLocationChanged += C01.Order;


            //ball.Location = new Location() { X =2, Y = 1, Z = 1 };
            //Console.WriteLine(ball);

            //Console.WriteLine();

            //Console.WriteLine("After changing Pedri ");

            //ball.BallLocationChanged -= P03.Run;
            //ball.BallLocationChanged += P05.Run;
            //Console.WriteLine();

            //ball.Location = new Location() { X = 3, Y = 1, Z = 1 };
            //Console.WriteLine(ball); 
            #endregion

            #region Event Ex02

            Channel channel = new Channel() { Title="ABC"};
            channel.AddVideo(new Video() { Title = "Title 1", Description = "Description 1" });

            Subscriber S01 = new Subscriber() {Name= "Ahmed" };
            Subscriber S02 = new Subscriber() {Name= "Ali" };
            Subscriber S03 = new Subscriber() {Name= "Mona" };
            Subscriber S04 = new Subscriber() {Name= "Mohamed" };
            Subscriber S05 = new Subscriber() {Name= "Mariam" };

            channel.AddVideo(new Video() { Title = "Title 2", Description = "Description 2" });

            channel.Uploaded += S01.Notify;
            channel.Uploaded += S02.Notify;
            channel.Uploaded += S03.Notify; 
            channel.Uploaded += S04.Notify;

            channel.AddVideo(new Video() { Title = "Title 3", Description = "Description 3" });
           
            Console.WriteLine();
            Console.WriteLine("After Ahmed deleted subscription and Mariam Subscribed ");
            Console.WriteLine();

            channel.Uploaded -= S01.Notify;
            channel.Uploaded += S05.Notify;
            channel.AddVideo(new Video() { Title = "Title 4", Description = "Description 4" });




            #endregion
        }
    }
}

using System;

namespace ConsoleApp{

    class Program{

        static void Main(string[] args){

            Player plyr1 = new Player();
            plyr1.Number = "1";
            plyr1.Name = "Fernando Muslera";
            plyr1.Position = "Goalkeeper";

            Player plyr2 = new Player();
            plyr2.Number = "9";
            plyr2.Name = "Mauro Icardi";
            plyr2.Position = "Striker";

            Player plyr3 = new Player();
            plyr3.Number = "34";
            plyr3.Name = "Lucas Torreira";
            plyr3.Position = "Midfield";

            Player plyr4 = new Player();
            plyr4.Number = "42";
            plyr4.Name = "Abdülkerim Bardakçı";
            plyr4.Position = "Deffender";
            
            Player plyr5 = new Player();
            plyr5.Number = "7";
            plyr5.Name = "Kerem Aktürkoğlu";
            plyr5.Position = "Wing";
            
            Player plyr6 = new Player();
            plyr6.Number = "17";
            plyr6.Name = "Derrick Köhn";
            plyr6.Position = "Back";

            Player[] players = new Player[6] {plyr1 , plyr2 , plyr3 , plyr4 , plyr5 , plyr6};


            foreach (var player in players)
            {
                Console.WriteLine(player.BilgileriYazdir());
            }


        }
    }
}

class Player{
    public string Number { get; set; }
    public string Name { get; set; }
    public string Position { get; set; }


    public string BilgileriYazdir()
    {
        return $"The name of player number {this.Number} is {this.Name} and her position is {this.Position}.";
    }

}




using System;

namespace Quiz_Question_Answer__Day_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Basketbolcuları oluşturalım.
            Basketballer player1 = new Basketballer { Name="Ahmet", Age = 21 , Size= 1.86};
            Basketballer player2 = new Basketballer { Name = "Mehmet", Age = 27, Size= 1.83};
            Basketballer player3 = new Basketballer { Name="Can", Age = 32 , Size= 1.79};
            Basketballer player4 = new Basketballer { Name="Özgür", Age = 24 , Size= 1.89};

            // Basketbolcuları bir dizide tutalım.
            Basketballer[] players = new Basketballer[] {player1,player2,player3,player4};

            // foreach ile dizimiz üzerinde gezinelim.
            foreach (Basketballer player in players)
            {
                // Grup oluşturmak için 1.85 boya göre şart blokları oluşturalım. 
                if(player.Size>= 1.85) // nesnemizin Size özelliğini karşılaştırıyoruz. 
                {
                    Console.WriteLine("Ad: " + player.Name + " Yaş: " + player.Age + " Boy: " + player.Size + " Boy Grubu: UZUN");
                }
                else
                {
                    Console.WriteLine("Ad: " + player.Name + " Yaş: " + player.Age + " Boy: " + player.Size + " Boy Grubu: KISA");
                }
            }
    }
}
}

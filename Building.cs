using System;
using System.Linq;

namespace DDD
{
    public class Building : fDrawing, fOperation
    {
        public Building(int pfloors)
        {
        	floors = pfloors;
        }

        private int floors;

        public void Up(int pUp)
        {
            floors += pUp;
        }

        public void Down(int pDown)
        {
            floors -= pDown;
        }

        public string Data
        {
            get
            {
                return
                	"На данный момент в здании этажей: " + floors + "\n";            
            }
            set
            {
            	floors = int.Parse(value);
            }
        }

        public void DrawContent()
        {
            Console.WriteLine
                (
                    "░░░░╠╩╩╩╣░░░╠╩╩╩╣░░░░\n" +
                    "╠╩╩╩╣░█░╚╩╩╩╝░█░╠╩╩╩╣\n" +
                    "║░░░║░█░░░░░░░█░║░░░║\n" +
                    "║░█░║░░░░███░░░░║░█░║\n" +
                    "║░░░║░░░░███░░░░║░░░║\n"
                );
            Console.WriteLine(Data);
        }
    }
}
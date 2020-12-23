using System;
using System.Linq;

namespace DDD
{
    public class Score : fDrawing, fOperation
    {
        public Score(int ppoints)
        {
        	points = ppoints;
        }

        private int points;

        public void Up(int pUp)
        {
            points += pUp;
        }

        public void Down(int pDown)
        {
            points -= pDown;
        }

        public string Data
        {
            get
            {
                return
                	"На данный момент у вас: " + points + "очков \n";            
            }
            set
            {
            	points = int.Parse(value);
            }
        }

        public void DrawContent()
        {
            Console.WriteLine
                (
                    "|||||||||||||||||||||||\n" +
                    "||||||||///1|||||||||||\n" +
                    "|||||//////2|||||||||||\n" +
                    "|||////////3|||||||||||\n" +
                    "|||||||||||||||||||||||\n"
                );
            Console.WriteLine(Data);
        }
    }
}
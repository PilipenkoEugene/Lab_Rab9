using System;
using System.Linq;

namespace DDD
{
    public interface fDrawing
    {
        string Data {
    		get; 
    		set;
    	}
        void DrawContent();
    }
}
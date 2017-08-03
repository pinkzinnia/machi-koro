using System;
using System.Collections.Generic;
using System.Drawing;
//using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace MachiKoro
{
	public class LandmarkCard:Card
	{
		public LandmarkCard()
		{
			FaceColor= ConsoleColor.Yellow;
		}
	}
	public class Y0:LandmarkCard
	{
		public Y0():base()
		{
			Name = "City Hall";
				
		}
	}
	
		public class Y2:LandmarkCard
	{
		public Y2():base()
		{
			Name = "Harbor";
			Cost = 2;	
		}
	}
		public class Y4:LandmarkCard
	{
		public Y4():base()
		{
			Name = "Train Station";
			Cost = 4;	
		}
	}
		public class Y10:LandmarkCard
	{
		public Y10():base()
		{
			Name = "Shopping Mall";
			Cost = 10;	
		}
	}
	public class Y16:LandmarkCard
	{
		public Y16():base()
		{
			Name = "Amusement Park";
				Cost = 16;
		}
	}
	public class Y22:LandmarkCard
	{
		public Y22():base()
		{
			Name = "Radio Tower";
			Cost = 22;	
		}
		
	}
	
	public class Y33:LandmarkCard
	{
		public Y33():base()
		{
			Name = "Air Port";
				Cost = 30;	
		}
	}
	
}
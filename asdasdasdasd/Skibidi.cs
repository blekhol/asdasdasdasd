namespace asdasdasdasd
{
	internal class Skibidi
	{
		static void Main(string[] args)
		{
			List<String> frames = Frames("új 3.txt");

			while (true)
			{
				foreach (var frame in frames)
				{
					foreach (string line in frame.Split("\n"))
					{
						foreach (char kar in line)
						{
							switch (kar)
							{
								case 'w': Console.BackgroundColor = ConsoleColor.White; Console.Write(" "); break;
								case 'c': Console.BackgroundColor = ConsoleColor.Cyan; Console.Write(" "); break;
								case 'B': Console.BackgroundColor = ConsoleColor.DarkBlue; Console.Write(" "); break;
								case 'C': Console.BackgroundColor = ConsoleColor.DarkCyan; Console.Write(" "); break;
								case 'g': Console.BackgroundColor = ConsoleColor.Gray; Console.Write(" "); break;
								case 'G': Console.BackgroundColor = ConsoleColor.DarkGray; Console.Write(" "); break;
								case 'Z': Console.BackgroundColor = ConsoleColor.DarkGreen; Console.Write(" "); break;
								case 'P': Console.BackgroundColor = ConsoleColor.DarkMagenta; Console.Write(" "); break;
								case 'R': Console.BackgroundColor = ConsoleColor.DarkRed; Console.Write(" "); break;
								case 'Y': Console.BackgroundColor = ConsoleColor.DarkYellow; Console.Write(" "); break;
								case 'r': Console.BackgroundColor = ConsoleColor.Red; Console.Write(" "); break;
								case 'y': Console.BackgroundColor = ConsoleColor.Yellow; Console.Write(" "); break;
								case 'p': Console.BackgroundColor = ConsoleColor.Magenta; Console.Write(" "); break;
								case 'z': Console.BackgroundColor = ConsoleColor.Green; Console.Write(" "); break;
								case 'b': Console.BackgroundColor = ConsoleColor.Blue; Console.Write(" "); break;
								case 'f': Console.BackgroundColor = ConsoleColor.Black; Console.Write(" "); break;
								default: Console.BackgroundColor = ConsoleColor.Black; Console.Write("\n"); break;
							}
						}
						Console.BackgroundColor = ConsoleColor.Black;
					}
					Console.SetCursorPosition(119, 29);
					
				}
			}
        }

		static List<String> Frames(string file)
		{
			StreamReader sr = new(file);
			string a = sr.ReadToEnd();

			List<String> frames = [];

			foreach (string frame in a.Split("="))
			{
				frames.Add(frame);
			}

			return frames;
		}
	}
}

/* ЕСТЕСТВЕННАЯ СОРТИРОВКА СПИСКА

Сниппет позволяет производить естественную сортировку списка, как в жизни: 1.2.3.4.5 итд.
а не 1.10.11.12.2.20.21 итд.

Полезно при работе с файлами, папками, которые нумеруются по порядку.

*/

// Данный код следует добавить в "Директивы using и общий код"
public class NaturalComparer : Comparer<string>, IDisposable
{
	private Dictionary<string, string[]> table;

	public NaturalComparer()
	{
		table = new Dictionary<string, string[]>();
	}

	public void Dispose()
	{
		table.Clear();
		table = null;
	}

	public override int Compare(string x, string y)
	{
		if(x == y)
		{
			return 0;
		}
		
		string[] x1, y1;
		if(!table.TryGetValue(x, out x1))
		{
			x1 = Regex.Split(x.Replace(" ", ""), "([0-9]+)");
			table.Add(x, x1);
	       }
			
		if(!table.TryGetValue(y, out y1))
		{
			y1 = Regex.Split(y.Replace(" ", ""), "([0-9]+)");
			table.Add(y, y1);
		}

		for(int i = 0; i < x1.Length && i < y1.Length; i++)
		{
			if(x1[i] != y1[i])
			{
				return PartCompare(x1[i], y1[i]);
			}
		}
			
		if(y1.Length > x1.Length)
		{
			return 1;
		}
			
		else if(x1.Length > y1.Length)
		{
			return -1;
		}
			
		else
		{
			return 0;
		}
	}

	private static int PartCompare(string left, string right)
	{
		int x, y;
		if(!int.TryParse(left, out x))
		{
			return left.CompareTo(right);
		}

		if(!int.TryParse(right, out y))
		{
			return left.CompareTo(right);
		}
			
	return x.CompareTo(y);
	}
}

// Использование в кубике C#

// исходный ZennoPoster список
IZennoList notSortedZennoList = project.Lists["notSortedZennoList"];
// результирующий ZennoPoster список
IZennoList sortedZennoList = project.Lists["sortedZennoList"];

// промежуточный список в который будет помещён результат
List<string> sortList;

// копируем исходный спиоск в промежуточный
sortList = new List<string>(notSortedZennoList);

// производим естественную сортировку
using(NaturalComparer comparer = new NaturalComparer())
{
	sortList.Sort(comparer);
}

// сохраняем результат в результирующем списке
sortedZennoList.AddRange(sortList);